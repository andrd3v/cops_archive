// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Yoga
internal sealed class BaselineFunction
{
	// Methods

	// RVA: 0x1701B6C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1701C90
	public virtual float Invoke(YogaNode node, float width, float height) { }

}

// Namespace: UnityEngine.Yoga
internal sealed class Logger
{
	// Methods

	// RVA: 0x1701CA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1701DC8
	public virtual void Invoke(YogaConfig config, YogaNode node, YogaLogLevel level, string message) { }

}

// Namespace: UnityEngine.Yoga
internal sealed class MeasureFunction
{
	// Methods

	// RVA: 0x1701DDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1701F00
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

}

// Namespace: UnityEngine.Yoga
internal class MeasureOutput
{
	// Methods

	// RVA: 0x1701F14
	public static YogaSize Make(float width, float height) { }

}

// Namespace: UnityEngine.Yoga
internal enum YogaAlign
{
	// Fields
	public int value__; // 0x10
	public const YogaAlign Auto = 0;
	public const YogaAlign FlexStart = 1;
	public const YogaAlign Center = 2;
	public const YogaAlign FlexEnd = 3;
	public const YogaAlign Stretch = 4;
	public const YogaAlign Baseline = 5;
	public const YogaAlign SpaceBetween = 6;
	public const YogaAlign SpaceAround = 7;
}

// Namespace: UnityEngine.Yoga
internal class YogaConfig
{
	// Fields
	internal static readonly YogaConfig Default; // 0x0
	private IntPtr _ygConfig; // 0x10
	private Logger _logger; // 0x18

	// Methods

	// RVA: 0x1701F18
	private void .ctor(IntPtr ygConfig) { }

	// RVA: 0x1701FA0
	public void .ctor() { }

	// RVA: 0x170203C
	protected override void Finalize() { }

	// RVA: 0x170218C
	internal IntPtr get_Handle() { }

	// RVA: 0x1702200
	public bool get_UseWebDefaults() { }

	// RVA: 0x17022A0
	public void set_UseWebDefaults(bool value) { }

	// RVA: 0x1702370
	public void set_PointScaleFactor(float value) { }

	// RVA: 0x1702440
	private static void .cctor() { }

}

// Namespace: UnityEngine.Yoga
internal static class YogaConstants
{
	// Methods

	// RVA: 0x1702518
	public static bool IsUndefined(float value) { }

}

// Namespace: UnityEngine.Yoga
internal enum YogaDirection
{
	// Fields
	public int value__; // 0x10
	public const YogaDirection Inherit = 0;
	public const YogaDirection LTR = 1;
	public const YogaDirection RTL = 2;
}

// Namespace: UnityEngine.Yoga
internal enum YogaDisplay
{
	// Fields
	public int value__; // 0x10
	public const YogaDisplay Flex = 0;
	public const YogaDisplay None = 1;
}

// Namespace: UnityEngine.Yoga
internal enum YogaEdge
{
	// Fields
	public int value__; // 0x10
	public const YogaEdge Left = 0;
	public const YogaEdge Top = 1;
	public const YogaEdge Right = 2;
	public const YogaEdge Bottom = 3;
	public const YogaEdge Start = 4;
	public const YogaEdge End = 5;
	public const YogaEdge Horizontal = 6;
	public const YogaEdge Vertical = 7;
	public const YogaEdge All = 8;
}

// Namespace: UnityEngine.Yoga
internal enum YogaFlexDirection
{
	// Fields
	public int value__; // 0x10
	public const YogaFlexDirection Column = 0;
	public const YogaFlexDirection ColumnReverse = 1;
	public const YogaFlexDirection Row = 2;
	public const YogaFlexDirection RowReverse = 3;
}

// Namespace: UnityEngine.Yoga
internal enum YogaJustify
{
	// Fields
	public int value__; // 0x10
	public const YogaJustify FlexStart = 0;
	public const YogaJustify Center = 1;
	public const YogaJustify FlexEnd = 2;
	public const YogaJustify SpaceBetween = 3;
	public const YogaJustify SpaceAround = 4;
}

// Namespace: UnityEngine.Yoga
internal enum YogaLogLevel
{
	// Fields
	public int value__; // 0x10
	public const YogaLogLevel Error = 0;
	public const YogaLogLevel Warn = 1;
	public const YogaLogLevel Info = 2;
	public const YogaLogLevel Debug = 3;
	public const YogaLogLevel Verbose = 4;
	public const YogaLogLevel Fatal = 5;
}

// Namespace: UnityEngine.Yoga
internal enum YogaMeasureMode
{
	// Fields
	public int value__; // 0x10
	public const YogaMeasureMode Undefined = 0;
	public const YogaMeasureMode Exactly = 1;
	public const YogaMeasureMode AtMost = 2;
}

// Namespace: UnityEngine.Yoga
internal static class Native
{
	// Methods

	// RVA: 0x1702530
	public static IntPtr YGNodeNewWithConfig(IntPtr config) { }

	// RVA: 0x1702580
	public static void YGNodeFree(IntPtr ygNode) { }

	// RVA: 0x17025EC
	private static void YGNodeFreeInternal(IntPtr ygNode) { }

	// RVA: 0x170263C
	public static void YGSetManagedObject(IntPtr ygNode, YogaNode node) { }

	// RVA: 0x17026A4
	public static void YGNodeSetConfig(IntPtr ygNode, IntPtr config) { }

	// RVA: 0x17024D8
	public static IntPtr YGConfigGetDefault() { }

	// RVA: 0x1701FFC
	public static IntPtr YGConfigNew() { }

	// RVA: 0x1702194
	public static void YGConfigFree(IntPtr config) { }

	// RVA: 0x170270C
	private static void YGConfigFreeInternal(IntPtr config) { }

	// RVA: 0x1702308
	public static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults) { }

	// RVA: 0x1702250
	public static bool YGConfigGetUseWebDefaults(IntPtr config) { }

	// RVA: 0x17023D8
	public static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint) { }

	// RVA: 0x170275C
	public static void YGNodeInsertChild(IntPtr node, IntPtr child, UInt32 index) { }

	// RVA: 0x17027B4
	public static void YGNodeRemoveChild(IntPtr node, IntPtr child) { }

	// RVA: 0x170281C
	public static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection) { }

	// RVA: 0x1702884
	public static void YGNodeMarkDirty(IntPtr node) { }

	// RVA: 0x17028D4
	public static bool YGNodeIsDirty(IntPtr node) { }

	// RVA: 0x1702924
	public static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode) { }

	// RVA: 0x170298C
	public static void YGNodeSetMeasureFunc(IntPtr node) { }

	// RVA: 0x17029DC
	public static void YGNodeRemoveMeasureFunc(IntPtr node) { }

	// RVA: 0x1702A2C
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	// RVA: 0x1702B78
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	// RVA: 0x1702CA4
	public static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout) { }

	// RVA: 0x1702D0C
	public static bool YGNodeGetHasNewLayout(IntPtr node) { }

	// RVA: 0x1702D5C
	public static YogaDirection YGNodeStyleGetDirection(IntPtr node) { }

	// RVA: 0x1702DAC
	public static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection) { }

	// RVA: 0x1702E14
	public static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent) { }

	// RVA: 0x1702E7C
	public static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent) { }

	// RVA: 0x1702EE4
	public static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems) { }

	// RVA: 0x1702F4C
	public static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf) { }

	// RVA: 0x1702FB4
	public static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType) { }

	// RVA: 0x170301C
	public static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap) { }

	// RVA: 0x1703084
	public static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap) { }

	// RVA: 0x17030EC
	public static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display) { }

	// RVA: 0x1703154
	public static void YGNodeStyleSetFlex(IntPtr node, float flex) { }

	// RVA: 0x17031BC
	public static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow) { }

	// RVA: 0x1703224
	public static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink) { }

	// RVA: 0x170328C
	public static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis) { }

	// RVA: 0x17032F4
	public static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis) { }

	// RVA: 0x170335C
	public static void YGNodeStyleSetFlexBasisAuto(IntPtr node) { }

	// RVA: 0x17033AC
	public static void YGNodeStyleSetWidth(IntPtr node, float width) { }

	// RVA: 0x1703414
	public static void YGNodeStyleSetWidthPercent(IntPtr node, float width) { }

	// RVA: 0x170347C
	public static void YGNodeStyleSetWidthAuto(IntPtr node) { }

	// RVA: 0x17034CC
	public static void YGNodeStyleSetHeight(IntPtr node, float height) { }

	// RVA: 0x1703534
	public static void YGNodeStyleSetHeightPercent(IntPtr node, float height) { }

	// RVA: 0x170359C
	public static void YGNodeStyleSetHeightAuto(IntPtr node) { }

	// RVA: 0x17035EC
	public static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth) { }

	// RVA: 0x1703654
	public static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth) { }

	// RVA: 0x17036BC
	public static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight) { }

	// RVA: 0x1703724
	public static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight) { }

	// RVA: 0x170378C
	public static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth) { }

	// RVA: 0x17037F4
	public static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth) { }

	// RVA: 0x170385C
	public static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight) { }

	// RVA: 0x17038C4
	public static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight) { }

	// RVA: 0x170392C
	public static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position) { }

	// RVA: 0x170398C
	public static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position) { }

	// RVA: 0x17039EC
	public static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin) { }

	// RVA: 0x1703A4C
	public static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin) { }

	// RVA: 0x1703AAC
	public static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge) { }

	// RVA: 0x1703B14
	public static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding) { }

	// RVA: 0x1703B74
	public static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding) { }

	// RVA: 0x1703BD4
	public static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border) { }

	// RVA: 0x1703C34
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	// RVA: 0x1703C84
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	// RVA: 0x1703CD4
	public static float YGNodeLayoutGetRight(IntPtr node) { }

	// RVA: 0x1703D24
	public static float YGNodeLayoutGetBottom(IntPtr node) { }

	// RVA: 0x1703D74
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	// RVA: 0x1703DC4
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

	// RVA: 0x1703E14
	public static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge) { }

	// RVA: 0x1703E7C
	public static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge) { }

	// RVA: 0x1703EE4
	public static float YGNodeLayoutGetBorder(IntPtr node, YogaEdge edge) { }

}

// Namespace: UnityEngine.Yoga
internal class YogaNode
{
	// Fields
	internal IntPtr _ygNode; // 0x10
	private YogaConfig _config; // 0x18
	private WeakReference _parent; // 0x20
	private System.Collections.Generic.List<UnityEngine.Yoga.YogaNode> _children; // 0x28
	private MeasureFunction _measureFunction; // 0x30
	private BaselineFunction _baselineFunction; // 0x38
	private object _data; // 0x40

	// Methods

	// RVA: 0x1703F4C
	public void .ctor(YogaConfig config) { }

	// RVA: 0x170408C
	protected override void Finalize() { }

	// RVA: 0x1704158
	internal void set_Config(YogaConfig value) { }

	// RVA: 0x170423C
	public bool get_IsDirty() { }

	// RVA: 0x170428C
	public virtual void MarkDirty() { }

	// RVA: 0x17042DC
	public bool get_HasNewLayout() { }

	// RVA: 0x170432C
	public bool get_IsMeasureDefined() { }

	// RVA: 0x170433C
	public bool get_IsBaselineDefined() { }

	// RVA: 0x170434C
	public void CopyStyle(YogaNode srcNode) { }

	// RVA: 0x17043BC
	public void set_FlexDirection(YogaFlexDirection value) { }

	// RVA: 0x1704424
	public void set_JustifyContent(YogaJustify value) { }

	// RVA: 0x170448C
	public void set_Display(YogaDisplay value) { }

	// RVA: 0x17044F4
	public void set_AlignItems(YogaAlign value) { }

	// RVA: 0x170455C
	public void set_AlignSelf(YogaAlign value) { }

	// RVA: 0x17045C4
	public void set_AlignContent(YogaAlign value) { }

	// RVA: 0x170462C
	public void set_PositionType(YogaPositionType value) { }

	// RVA: 0x1704694
	public void set_Wrap(YogaWrap value) { }

	// RVA: 0x17046FC
	public void set_Flex(float value) { }

	// RVA: 0x1704764
	public void set_FlexGrow(float value) { }

	// RVA: 0x17047CC
	public void set_FlexShrink(float value) { }

	// RVA: 0x1704834
	public void set_FlexBasis(YogaValue value) { }

	// RVA: 0x1704948
	public void set_Width(YogaValue value) { }

	// RVA: 0x1704A4C
	public void set_Height(YogaValue value) { }

	// RVA: 0x1704B50
	public void set_MaxWidth(YogaValue value) { }

	// RVA: 0x1704BFC
	public void set_MaxHeight(YogaValue value) { }

	// RVA: 0x1704CA8
	public void set_MinWidth(YogaValue value) { }

	// RVA: 0x1704D54
	public void set_MinHeight(YogaValue value) { }

	// RVA: 0x1704E00
	public float get_LayoutX() { }

	// RVA: 0x1704E50
	public float get_LayoutY() { }

	// RVA: 0x1704EA0
	public float get_LayoutRight() { }

	// RVA: 0x1704EF0
	public float get_LayoutBottom() { }

	// RVA: 0x1704F40
	public float get_LayoutWidth() { }

	// RVA: 0x1704F90
	public float get_LayoutHeight() { }

	// RVA: 0x1704FE0
	public void set_Overflow(YogaOverflow value) { }

	// RVA: 0x1705048
	public int get_Count() { }

	// RVA: 0x17050A0
	public void MarkLayoutSeen() { }

	// RVA: 0x17050F8
	public void Insert(int index, YogaNode node) { }

	// RVA: 0x1705240
	public void RemoveAt(int index) { }

	// RVA: 0x1705328
	public void Clear() { }

	// RVA: 0x1705390
	public void SetMeasureFunction(MeasureFunction measureFunction) { }

	// RVA: 0x17054B4
	public void CalculateLayout(float width, float height) { }

	// RVA: 0x1702AF4
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x1702C28
	public static float BaselineInternal(YogaNode node, float width, float height) { }

	// RVA: 0x1705560
	public System.Collections.Generic.IEnumerator<UnityEngine.Yoga.YogaNode> GetEnumerator() { }

	// RVA: 0x17056F0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1705880
	public void set_Left(YogaValue value) { }

	// RVA: 0x170598C
	public void set_Top(YogaValue value) { }

	// RVA: 0x1705A10
	public void set_Right(YogaValue value) { }

	// RVA: 0x1705A94
	public void set_Bottom(YogaValue value) { }

	// RVA: 0x1705904
	private void SetStylePosition(YogaEdge edge, YogaValue value) { }

	// RVA: 0x1705B18
	public void set_MarginLeft(YogaValue value) { }

	// RVA: 0x1705CD8
	public void set_MarginTop(YogaValue value) { }

	// RVA: 0x1705DBC
	public void set_MarginRight(YogaValue value) { }

	// RVA: 0x1705EA0
	public void set_MarginBottom(YogaValue value) { }

	// RVA: 0x1705BFC
	private void SetStyleMargin(YogaEdge edge, YogaValue value) { }

	// RVA: 0x1705F84
	public void set_PaddingLeft(YogaValue value) { }

	// RVA: 0x1706090
	public void set_PaddingTop(YogaValue value) { }

	// RVA: 0x1706114
	public void set_PaddingRight(YogaValue value) { }

	// RVA: 0x1706198
	public void set_PaddingBottom(YogaValue value) { }

	// RVA: 0x1706008
	private void SetStylePadding(YogaEdge edge, YogaValue value) { }

	// RVA: 0x170621C
	public void set_BorderLeftWidth(float value) { }

	// RVA: 0x1706270
	public void set_BorderTopWidth(float value) { }

	// RVA: 0x17062C4
	public void set_BorderRightWidth(float value) { }

	// RVA: 0x1706318
	public void set_BorderBottomWidth(float value) { }

	// RVA: 0x170636C
	public float get_LayoutMarginLeft() { }

	// RVA: 0x17063C4
	public float get_LayoutMarginTop() { }

	// RVA: 0x170641C
	public float get_LayoutMarginRight() { }

	// RVA: 0x1706474
	public float get_LayoutMarginBottom() { }

	// RVA: 0x17064CC
	public float get_LayoutPaddingLeft() { }

	// RVA: 0x1706524
	public float get_LayoutPaddingTop() { }

	// RVA: 0x170657C
	public float get_LayoutPaddingRight() { }

	// RVA: 0x17065D4
	public float get_LayoutPaddingBottom() { }

	// RVA: 0x170662C
	public float get_LayoutBorderLeft() { }

	// RVA: 0x1706684
	public float get_LayoutBorderTop() { }

	// RVA: 0x17066DC
	public float get_LayoutBorderRight() { }

	// RVA: 0x1706734
	public float get_LayoutBorderBottom() { }

}

// Namespace: UnityEngine.Yoga
internal enum YogaOverflow
{
	// Fields
	public int value__; // 0x10
	public const YogaOverflow Visible = 0;
	public const YogaOverflow Hidden = 1;
	public const YogaOverflow Scroll = 2;
}

// Namespace: UnityEngine.Yoga
internal enum YogaPositionType
{
	// Fields
	public int value__; // 0x10
	public const YogaPositionType Relative = 0;
	public const YogaPositionType Absolute = 1;
}

// Namespace: UnityEngine.Yoga
internal struct YogaSize
{
	// Fields
	public float width; // 0x10
	public float height; // 0x14
}

// Namespace: UnityEngine.Yoga
internal enum YogaUnit
{
	// Fields
	public int value__; // 0x10
	public const YogaUnit Undefined = 0;
	public const YogaUnit Point = 1;
	public const YogaUnit Percent = 2;
	public const YogaUnit Auto = 3;
}

// Namespace: UnityEngine.Yoga
internal struct YogaValue
{
	// Fields
	private float value; // 0x10
	private YogaUnit unit; // 0x14

	// Methods

	// RVA: 0x1704938
	public YogaUnit get_Unit() { }

	// RVA: 0x1704940
	public float get_Value() { }

	// RVA: 0x170678C
	public static YogaValue Point(float value) { }

	// RVA: 0x17067AC
	public bool Equals(YogaValue other) { }

	// RVA: 0x1706830
	public override bool Equals(object obj) { }

	// RVA: 0x1706910
	public override int GetHashCode() { }

	// RVA: 0x1706958
	public static YogaValue Auto() { }

	// RVA: 0x1706964
	public static YogaValue Percent(float value) { }

	// RVA: 0x1706984
	public static YogaValue op_Implicit(float pointValue) { }

}

// Namespace: UnityEngine.Yoga
internal enum YogaWrap
{
	// Fields
	public int value__; // 0x10
	public const YogaWrap NoWrap = 0;
	public const YogaWrap Wrap = 1;
	public const YogaWrap WrapReverse = 2;
}

// Namespace: UnityEngine.UIElements
internal static class AlignmentUtils
{
	// Methods

	// RVA: 0x17069A4
	internal static float RoundToPixelGrid(float v, float pixelsPerPoint, float offset) { }

	// RVA: 0x17069C0
	internal static float CeilToPixelGrid(float v, float pixelsPerPoint, float offset) { }

	// RVA: 0x17069D4
	internal static float RoundToPanelPixelSize(VisualElement ve, float v) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class AtlasBase
{
	// Fields
	internal TextureRegistry textureRegistry; // 0x10

	// Methods

	// RVA: 0x1706A24
	public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, TextureId atlas, RectInt atlasRect) { }

	// RVA: 0x1706A9C
	public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) { }

	// RVA: 0x1706AA0
	public virtual void Reset() { }

	// RVA: 0x1706AA4
	protected virtual void OnAssignedToPanel(IPanel panel) { }

	// RVA: 0x1706AA8
	protected virtual void OnRemovedFromPanel(IPanel panel) { }

	// RVA: 0x1706AAC
	protected virtual void OnUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x1706AB0
	internal void InvokeAssignedToPanel(IPanel panel) { }

	// RVA: 0x1706ABC
	internal void InvokeRemovedFromPanel(IPanel panel) { }

	// RVA: 0x1706AC8
	internal void InvokeUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x1706AD4
	protected static void RepaintTexturedElements(IPanel panel) { }

	// RVA: 0x1706BB8
	protected void SetDynamicTexture(TextureId id, Texture texture) { }

	// RVA: 0x1706BDC
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public enum DynamicAtlasFilters
{
	// Fields
	public int value__; // 0x10
	public const DynamicAtlasFilters None = 0;
	public const DynamicAtlasFilters Readability = 1;
	public const DynamicAtlasFilters Size = 2;
	public const DynamicAtlasFilters Format = 4;
	public const DynamicAtlasFilters ColorSpace = 8;
	public const DynamicAtlasFilters FilterMode = 16;
}

// Namespace: UnityEngine.UIElements
public sealed class DynamicAtlasCustomFilter
{
	// Methods

	// RVA: 0x1706CB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1706D6C
	public virtual bool Invoke(Texture2D texture, DynamicAtlasFilters filtersToApply) { }

}

// Namespace: 
private class TextureInfo
{
	// Fields
	public DynamicAtlasPage page; // 0x18
	public int counter; // 0x20
	public Alloc2D alloc; // 0x28
	public RectInt rect; // 0x58
	public static readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.DynamicAtlas.TextureInfo> pool; // 0x0

	// Methods

	// RVA: 0x1707A80
	private static TextureInfo Create() { }

	// RVA: 0x1707B60
	private static void Reset(TextureInfo info) { }

	// RVA: 0x1707B0C
	public void .ctor() { }

	// RVA: 0x1707BA4
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DynamicAtlas
{
	// Fields
	private System.Collections.Generic.Dictionary<UnityEngine.Texture,UnityEngine.UIElements.DynamicAtlas.TextureInfo> m_Database; // 0x18
	private DynamicAtlasPage m_PointPage; // 0x20
	private DynamicAtlasPage m_BilinearPage; // 0x28
	private ColorSpace m_ColorSpace; // 0x30
	private System.Collections.Generic.List<UnityEngine.UIElements.IPanel> m_Panels; // 0x38
	private int m_MinAtlasSize; // 0x40
	private int m_MaxAtlasSize; // 0x44
	private int m_MaxSubTextureSize; // 0x48
	private DynamicAtlasFilters m_ActiveFilters; // 0x4C
	private DynamicAtlasCustomFilter m_CustomFilter; // 0x50

	// Methods

	// RVA: 0x1706D80
	internal bool get_isInitialized() { }

	// RVA: 0x1706DA0
	protected override void OnAssignedToPanel(IPanel panel) { }

	// RVA: 0x1706E34
	protected override void OnRemovedFromPanel(IPanel panel) { }

	// RVA: 0x1706F78
	public override void Reset() { }

	// RVA: 0x1707038
	private void InitPages() { }

	// RVA: 0x1706EDC
	private void DestroyPages() { }

	// RVA: 0x1707150
	public override bool TryGetAtlas(VisualElement ve, Texture2D src, TextureId atlas, RectInt atlasRect) { }

	// RVA: 0x1707500
	public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) { }

	// RVA: 0x170764C
	protected override void OnUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x17076D4
	internal static bool IsTextureFormatSupported(TextureFormat format) { }

	// RVA: 0x1707708
	public virtual bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode) { }

	// RVA: 0x17078A4
	public void set_minAtlasSize(int value) { }

	// RVA: 0x17078C4
	public void set_maxAtlasSize(int value) { }

	// RVA: 0x17078E4
	public static DynamicAtlasFilters get_defaultFilters() { }

	// RVA: 0x17078EC
	public void set_activeFilters(DynamicAtlasFilters value) { }

	// RVA: 0x170789C
	public int get_maxSubTextureSize() { }

	// RVA: 0x170790C
	public void set_maxSubTextureSize(int value) { }

	// RVA: 0x170792C
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	// RVA: 0x1707994
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public struct BackgroundPosition
{
	// Fields
	public BackgroundPositionKeyword keyword; // 0x10
	public Length offset; // 0x14

	// Methods

	// RVA: 0x1707CE4
	public void .ctor(BackgroundPositionKeyword keyword) { }

	// RVA: 0x1707D28
	public void .ctor(BackgroundPositionKeyword keyword, Length offset) { }

	// RVA: 0x1707D34
	internal static BackgroundPosition Initial() { }

	// RVA: 0x1707DB4
	public override bool Equals(object obj) { }

	// RVA: 0x1707E88
	public bool Equals(BackgroundPosition other) { }

	// RVA: 0x1707ED8
	public override int GetHashCode() { }

	// RVA: 0x1707F24
	public static bool op_Equality(BackgroundPosition style1, BackgroundPosition style2) { }

	// RVA: 0x1707F74
	public static bool op_Inequality(BackgroundPosition style1, BackgroundPosition style2) { }

	// RVA: 0x1707FC8
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public static class BackgroundPropertyHelper
{
	// Methods

	// RVA: 0x1707D74
	public static BackgroundPosition ConvertScaleModeToBackgroundPosition(ScaleMode scaleMode) { }

	// RVA: 0x170808C
	public static BackgroundRepeat ConvertScaleModeToBackgroundRepeat(ScaleMode scaleMode) { }

	// RVA: 0x170809C
	public static BackgroundSize ConvertScaleModeToBackgroundSize(ScaleMode scaleMode) { }

	// RVA: 0x17081EC
	public static ScaleMode ResolveUnityBackgroundScaleMode(BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize, bool valid) { }

}

// Namespace: UnityEngine.UIElements
public struct BackgroundRepeat
{
	// Fields
	public Repeat x; // 0x10
	public Repeat y; // 0x14

	// Methods

	// RVA: 0x1708094
	public void .ctor(Repeat repeatX, Repeat repeatY) { }

	// RVA: 0x170864C
	internal static BackgroundRepeat Initial() { }

	// RVA: 0x1708654
	public override bool Equals(object obj) { }

	// RVA: 0x17086F4
	public bool Equals(BackgroundRepeat other) { }

	// RVA: 0x170871C
	public override int GetHashCode() { }

	// RVA: 0x17085E0
	public static bool op_Equality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	// RVA: 0x1708768
	public static bool op_Inequality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	// RVA: 0x1708774
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct BackgroundSize
{
	// Fields
	private BackgroundSizeType m_SizeType; // 0x10
	private Length m_X; // 0x14
	private Length m_Y; // 0x1C

	// Methods

	// RVA: 0x170881C
	public BackgroundSizeType get_sizeType() { }

	// RVA: 0x1708824
	public void set_sizeType(BackgroundSizeType value) { }

	// RVA: 0x1708884
	public Length get_x() { }

	// RVA: 0x170888C
	public void set_x(Length value) { }

	// RVA: 0x1708898
	public Length get_y() { }

	// RVA: 0x17088A0
	public void set_y(Length value) { }

	// RVA: 0x17081DC
	public void .ctor(Length sizeX, Length sizeY) { }

	// RVA: 0x170817C
	public void .ctor(BackgroundSizeType sizeType) { }

	// RVA: 0x17088AC
	internal static BackgroundSize Initial() { }

	// RVA: 0x1708900
	public override bool Equals(object obj) { }

	// RVA: 0x17089D4
	public bool Equals(BackgroundSize other) { }

	// RVA: 0x1708A2C
	public override int GetHashCode() { }

	// RVA: 0x17085EC
	public static bool op_Equality(BackgroundSize style1, BackgroundSize style2) { }

	// RVA: 0x1708A94
	public static bool op_Inequality(BackgroundSize style1, BackgroundSize style2) { }

	// RVA: 0x1708B0C
	public override string ToString() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1708C8C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_PropertyPath; // 0x70

	// Methods

	// RVA: 0x1708CE0
	public void .ctor() { }

	// RVA: 0x1708D84
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
public class BindableElement
{
	// Fields
	private IBinding <binding>k__BackingField; // 0x3C8
	private string <bindingPath>k__BackingField; // 0x3D0

	// Methods

	// RVA: 0x1708BEC
	public IBinding get_binding() { }

	// RVA: 0x1708BF4
	public void set_bindingPath(string value) { }

	// RVA: 0x1708C04
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal interface IBindingRequest
{
	// Methods

	// RVA: -1
	public abstract void Bind(VisualElement element) { }

}

// Namespace: UnityEngine.UIElements
internal class VisualTreeBindingsUpdater
{
	// Fields
	private static readonly PropertyName s_BindingRequestObjectVEPropertyName; // 0x0
	private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName; // 0x4
	private static readonly string s_Description; // 0x8
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x10
	private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker; // 0x18
	private static ProfilerMarker s_MarkerUpdate; // 0x20
	private static ProfilerMarker s_MarkerPoll; // 0x28
	private static bool <disableBindingsThrottling>k__BackingField; // 0x30
	private readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsWithBindings; // 0x38
	private readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToAdd; // 0x40
	private readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToRemove; // 0x48
	private Int64 m_LastUpdateTime; // 0x50
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ElementsToBind; // 0x58
	private System.Collections.Generic.Dictionary<System.Object,System.Object> <temporaryObjectCache>k__BackingField; // 0x60
	private System.Collections.Generic.List<UnityEngine.UIElements.IBinding> updatedBindings; // 0x68

	// Methods

	// RVA: 0x1708EE0
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x1708F5C
	public static bool get_disableBindingsThrottling() { }

	// RVA: 0x1708FD8
	private IBinding GetBindingObjectFromElement(VisualElement ve) { }

	// RVA: 0x1709264
	private void StartTracking(VisualElement ve) { }

	// RVA: 0x17092F0
	private void StopTracking(VisualElement ve) { }

	// RVA: 0x170937C
	public System.Collections.Generic.Dictionary<System.Object,System.Object> get_temporaryObjectCache() { }

	// RVA: 0x17091C0
	public static IBinding GetAdditionalBinding(VisualElement ve) { }

	// RVA: 0x1709384
	private void StartTrackingRecursive(VisualElement ve) { }

	// RVA: 0x17094F4
	private void StopTrackingRecursive(VisualElement ve) { }

	// RVA: 0x1709670
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x1709808
	protected override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	// RVA: 0x1709820
	private static Int64 CurrentTime() { }

	// RVA: 0x1709890
	public void PerformTrackingOperations() { }

	// RVA: 0x1709C10
	public override void Update() { }

	// RVA: 0x170A364
	private void UpdateBindings() { }

	// RVA: 0x170AB40
	public void .ctor() { }

	// RVA: 0x170ACE4
	private static void .cctor() { }

}

// Namespace: 
public enum DragDirection
{
	// Fields
	public int value__; // 0x0
	public const DragDirection None = 0;
	public const DragDirection LowToHigh = 1;
	public const DragDirection HighToLow = 2;
	public const DragDirection Free = 4;
}

// Namespace: UnityEngine.UIElements
internal class ClampedDragger<T0>
{
	// Fields
	private Action dragging; // 0x0
	private Action draggingEnded; // 0x0
	private DragDirection <dragDirection>k__BackingField; // 0x0
	private UnityEngine.UIElements.BaseSlider<T> <slider>k__BackingField; // 0x0
	private Vector2 <startMousePosition>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void add_dragging(Action value) { }

	// RVA: 0x30A27C0
	public void remove_dragging(Action value) { }

	// RVA: 0x30A27C0
	public void add_draggingEnded(Action value) { }

	// RVA: 0x30A27C0
	public void remove_draggingEnded(Action value) { }

	// RVA: 0x315B3A8
	public DragDirection get_dragDirection() { }

	// RVA: 0x315B3A8
	public void set_dragDirection(DragDirection value) { }

	// RVA: 0x30A27C0
	private void set_slider(UnityEngine.UIElements.BaseSlider<T> value) { }

	// RVA: -1
	public Vector2 get_startMousePosition() { }

	// RVA: -1
	private void set_startMousePosition(Vector2 value) { }

	// RVA: -1
	public Vector2 get_delta() { }

	// RVA: 0x30A2BF4
	public void .ctor(UnityEngine.UIElements.BaseSlider<T> slider, Action clickHandler, Action dragHandler) { }

	// RVA: -1
	protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: -1
	protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: -1
	protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

}

// Namespace: UnityEngine.UIElements
public class Clickable
{
	// Fields
	private System.Action<UnityEngine.UIElements.EventBase> clickedWithEventInfo; // 0x30
	private Action clicked; // 0x38
	private readonly Int64 m_Delay; // 0x40
	private readonly Int64 m_Interval; // 0x48
	private bool <active>k__BackingField; // 0x50
	private Vector2 <lastMousePosition>k__BackingField; // 0x54
	private int m_ActivePointerId; // 0x5C
	private bool m_AcceptClicksIfDisabled; // 0x60
	private IVisualElementScheduledItem m_Repeater; // 0x68

	// Methods

	// RVA: 0x170AE90
	public void add_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value) { }

	// RVA: 0x170AF44
	public void remove_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value) { }

	// RVA: 0x170AFF8
	public void add_clicked(Action value) { }

	// RVA: 0x170B09C
	public void remove_clicked(Action value) { }

	// RVA: 0x170B140
	protected bool get_active() { }

	// RVA: 0x170B148
	protected void set_active(bool value) { }

	// RVA: 0x170B150
	public Vector2 get_lastMousePosition() { }

	// RVA: 0x170B158
	private void set_lastMousePosition(Vector2 value) { }

	// RVA: 0x170B160
	internal bool get_acceptClicksIfDisabled() { }

	// RVA: 0x170B168
	internal void set_acceptClicksIfDisabled(bool value) { }

	// RVA: 0x170B1BC
	private InvokePolicy get_invokePolicy() { }

	// RVA: 0x170B1C4
	public void .ctor(Action handler, Int64 delay, Int64 interval) { }

	// RVA: 0x170B320
	public void .ctor(System.Action<UnityEngine.UIElements.EventBase> handler) { }

	// RVA: 0x170B27C
	public void .ctor(Action handler) { }

	// RVA: 0x170B3BC
	private void OnTimer(TimerState timerState) { }

	// RVA: 0x170B4D4
	private bool IsRepeatable() { }

	// RVA: 0x170B5D8
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x170BABC
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x170BF7C
	protected void OnMouseDown(MouseDownEvent evt) { }

	// RVA: 0x170C048
	protected void OnMouseMove(MouseMoveEvent evt) { }

	// RVA: 0x170C0C4
	protected void OnMouseUp(MouseUpEvent evt) { }

	// RVA: 0x170C198
	private void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	// RVA: 0x170C22C
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x170C370
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x170C4A4
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x170C5F0
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x170C768
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x170B4F8
	private bool ContainsPointer(int pointerId) { }

	// RVA: 0x170C6F8
	private static bool IsNotMouseEvent(int pointerId) { }

	// RVA: 0x170B57C
	protected void Invoke(EventBase evt) { }

	// RVA: 0x170C85C
	internal void SimulateSingleClick(EventBase evt, int delayMs) { }

	// RVA: 0x170CA98
	protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x170CEAC
	protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	// RVA: 0x170CF40
	protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x170D12C
	protected virtual void ProcessCancelEvent(EventBase evt, int pointerId) { }

	// RVA: 0x170D2AC
	private void <SimulateSingleClick>b__43_0() { }

}

// Namespace: 
private class ButtonClickStatus
{
	// Fields
	public VisualElement m_Target; // 0x10
	public Vector3 m_PointerDownPosition; // 0x18
	public Int64 m_LastPointerDownTime; // 0x28
	public int m_ClickCount; // 0x30

	// Methods

	// RVA: 0x170D994
	public void Reset() { }

	// RVA: 0x170D678
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ClickDetector
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.ClickDetector.ButtonClickStatus> m_ClickStatus; // 0x10
	private static int <s_DoubleClickTime>k__BackingField; // 0x0

	// Methods

	// RVA: 0x170D2EC
	internal static int get_s_DoubleClickTime() { }

	// RVA: 0x170D368
	internal static void set_s_DoubleClickTime(int value) { }

	// RVA: 0x170D3F4
	public void .ctor() { }

	// RVA: 0x170D680
	private void StartClickTracking(EventBase evt) { }

	// RVA: 0x170DA0C
	private void SendClickEvent(EventBase evt) { }

	// RVA: 0x170DF38
	private void CancelClickTracking(EventBase evt) { }

	// RVA: 0x170E0A4
	public void ProcessEvent(EventBase evt) { }

	// RVA: 0x170DDF0
	private static bool ContainsPointer(VisualElement element, Vector2 position) { }

	// RVA: 0x170E6A4
	internal void Cleanup(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x170E9D8
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseListViewController
{
	// Fields
	private Action itemsSourceSizeChanged; // 0x30
	private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsAdded; // 0x38
	private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsRemoved; // 0x40

	// Methods

	// RVA: 0x170EA28
	public void add_itemsSourceSizeChanged(Action value) { }

	// RVA: 0x170EACC
	public void remove_itemsSourceSizeChanged(Action value) { }

	// RVA: 0x170EB70
	public void add_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x170EC24
	public void remove_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x170ECD8
	public void add_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x170ED8C
	public void remove_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x170EE40
	protected BaseListView get_baseListView() { }

	// RVA: 0x170EEC8
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x170F130
	internal void PostInitRegistration(ReusableListViewItem listItem) { }

	// RVA: 0x170F5C8
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x170F98C
	public virtual bool NeedsDragHandle(int index) { }

	// RVA: 0x170F994
	public virtual void AddItems(int itemCount) { }

	// RVA: 0x1710358
	public virtual void Move(int index, int newIndex) { }

	// RVA: 0x171079C
	public virtual void RemoveItem(int index) { }

	// RVA: 0x17108F4
	public virtual void RemoveItems(System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x1710E04
	internal virtual void RemoveItems(int itemCount) { }

	// RVA: 0x1710FCC
	public virtual void ClearItems() { }

	// RVA: 0x171033C
	protected void RaiseOnSizeChanged() { }

	// RVA: 0x1710320
	protected void RaiseItemsAdded(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1710B90
	protected void RaiseItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x17101F4
	private static Array AddToArray(Array source, int itemCount) { }

	// RVA: 0x1710BAC
	private static Array RemoveFromArray(Array source, System.Collections.Generic.List<System.Int32> indicesToRemove) { }

	// RVA: 0x17104E8
	private void Swap(int lhs, int rhs) { }

	// RVA: 0x171007C
	private void EnsureItemSourceCanBeResized() { }

	// RVA: 0x171119C
	protected void .ctor() { }

	// RVA: 0x17111AC
	internal static bool <AddItems>g__IsGenericList|15_0(Type t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public BaseTreeViewController <>4__this; // 0x10
	public ReusableTreeViewItem treeItem; // 0x18

	// Methods

	// RVA: 0x17125EC
	public void .ctor() { }

	// RVA: 0x1715C8C
	internal void <PostInitRegistration>b__0() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseTreeViewController
{
	// Fields
	private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.TreeItem> m_TreeItems; // 0x30
	private System.Collections.Generic.List<System.Int32> m_RootIndices; // 0x38
	private System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper> m_ItemWrappers; // 0x40
	private System.Collections.Generic.HashSet<System.Int32> m_TreeItemIdsWithItemWrappers; // 0x48
	private System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper> m_WrapperInsertionList; // 0x50
	private static readonly ProfilerMarker K_ExpandItemByIndex; // 0x0
	private static readonly ProfilerMarker k_CreateWrappers; // 0x8

	// Methods

	// RVA: 0x1711274
	protected BaseTreeView get_baseTreeView() { }

	// RVA: 0x17112FC
	public override IList get_itemsSource() { }

	// RVA: 0x1711304
	public override void set_itemsSource(IList value) { }

	// RVA: 0x1711358
	public void RebuildTree() { }

	// RVA: 0x17118BC
	public System.Collections.Generic.IEnumerable<System.Int32> GetRootItemIds() { }

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

	// RVA: -1
	public abstract int GetParentId(int id) { }

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	public abstract void Move(int id, int newParentId, int childIndex, bool rebuildTree) { }

	// RVA: 0x17118C4
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1711D70
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x1712234
	internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1711984
	internal void PostInitRegistration(ReusableTreeViewItem treeItem) { }

	// RVA: 0x171275C
	private void OnItemPointerUp(PointerUpEvent evt) { }

	// RVA: 0x1713098
	private void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

	// RVA: 0x1714710
	public override int GetIndexForId(int id) { }

	// RVA: 0x1714810
	public override int GetIdForIndex(int index) { }

	// RVA: 0x1714974
	public virtual bool HasChildren(int id) { }

	// RVA: 0x1714A00
	internal bool Exists(int id) { }

	// RVA: 0x1712134
	public bool HasChildrenByIndex(int index) { }

	// RVA: 0x1712FAC
	public System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIdsByIndex(int index) { }

	// RVA: 0x1714A74
	public int GetChildIndexForId(int id) { }

	// RVA: 0x1714DE0
	internal int GetIndentationDepth(int id) { }

	// RVA: 0x1711F80
	internal int GetIndentationDepthByIndex(int index) { }

	// RVA: 0x1714E58
	internal virtual bool CanChangeExpandedState(int id) { }

	// RVA: 0x1714E60
	public bool IsExpanded(int id) { }

	// RVA: 0x1712020
	public bool IsExpandedByIndex(int index) { }

	// RVA: 0x1713998
	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh) { }

	// RVA: 0x17154E0
	public void ExpandItem(int id, bool expandAllChildren, bool refresh) { }

	// RVA: 0x1713248
	public void CollapseItemByIndex(int index, bool collapseAllChildren) { }

	// RVA: 0x1715798
	public void CollapseItem(int id, bool collapseAllChildren) { }

	// RVA: 0x17117BC
	internal void RegenerateWrappers() { }

	// RVA: 0x1714F48
	private void CreateWrappers(System.Collections.Generic.IEnumerable<System.Int32> treeViewItemIds, int depth, System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>& wrappers) { }

	// RVA: 0x17148FC
	private bool IsIndexValid(int index) { }

	// RVA: 0x17159D0
	internal void RaiseItemParentChanged(int id, int newParentId) { }

	// RVA: 0x1715A10
	protected void .ctor() { }

	// RVA: 0x1715BBC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class CollectionViewController
{
	// Fields
	private BaseVerticalCollectionView m_View; // 0x10
	private IList m_ItemsSource; // 0x18
	private Action itemsSourceChanged; // 0x20
	private System.Action<System.Int32,System.Int32> itemIndexChanged; // 0x28

	// Methods

	// RVA: 0x1715CBC
	public void add_itemsSourceChanged(Action value) { }

	// RVA: 0x1715D60
	public void remove_itemsSourceChanged(Action value) { }

	// RVA: 0x1715E04
	public void add_itemIndexChanged(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x1715EB8
	public void remove_itemIndexChanged(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x1715F6C
	public virtual IList get_itemsSource() { }

	// RVA: 0x1715F74
	public virtual void set_itemsSource(IList value) { }

	// RVA: 0x17159C8
	protected void SetItemsSourceWithoutNotify(IList source) { }

	// RVA: 0x1716064
	protected BaseVerticalCollectionView get_view() { }

	// RVA: 0x171606C
	public void SetView(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x1716130
	protected virtual void PrepareView() { }

	// RVA: 0x1716134
	public virtual void Dispose() { }

	// RVA: 0x1716178
	public virtual int GetItemsCount() { }

	// RVA: 0x171623C
	internal virtual int GetItemsMinCount() { }

	// RVA: 0x1716248
	public virtual int GetIndexForId(int id) { }

	// RVA: 0x1716250
	public virtual int GetIdForIndex(int index) { }

	// RVA: 0x1716258
	public virtual object GetItemForIndex(int index) { }

	// RVA: 0x17163B4
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x170F8A4
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x17163F8
	internal virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x17125C4
	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	// RVA: -1
	protected abstract VisualElement MakeItem() { }

	// RVA: -1
	protected abstract void BindItem(VisualElement element, int index) { }

	// RVA: -1
	protected abstract void UnbindItem(VisualElement element, int index) { }

	// RVA: -1
	protected abstract void DestroyItem(VisualElement element) { }

	// RVA: 0x1716048
	protected void RaiseItemsSourceChanged() { }

	// RVA: 0x171075C
	protected void RaiseItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x17111A4
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultMultiColumnTreeViewController<T0>
{
	// Fields
	private UnityEngine.UIElements.TreeDataController<T> m_TreeDataController; // 0x0

	// Methods

	// RVA: 0x30A17DC
	private UnityEngine.UIElements.TreeDataController<T> get_treeDataController() { }

	// RVA: 0x30A2BF4
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x30A17DC
	public override IList get_itemsSource() { }

	// RVA: 0x30A27C0
	public override void set_itemsSource(IList value) { }

	// RVA: 0x30A27C0
	public void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items) { }

	// RVA: -1
	public override object GetItemForIndex(int index) { }

	// RVA: -1
	public override int GetParentId(int id) { }

	// RVA: 0x30A1258
	public override bool HasChildren(int id) { }

	// RVA: -1
	public override System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	public override void Move(int id, int newParentId, int childIndex, bool rebuildTree) { }

	// RVA: -1
	private bool IsChildOf(int childId, int id) { }

	// RVA: 0x30A188C
	public override System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultTreeViewController<T0>
{
	// Fields
	private UnityEngine.UIElements.TreeDataController<T> m_TreeDataController; // 0x0

	// Methods

	// RVA: 0x30A17DC
	private UnityEngine.UIElements.TreeDataController<T> get_treeDataController() { }

	// RVA: 0x30A17DC
	public override IList get_itemsSource() { }

	// RVA: 0x30A27C0
	public override void set_itemsSource(IList value) { }

	// RVA: 0x30A27C0
	public void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items) { }

	// RVA: -1
	public override object GetItemForIndex(int index) { }

	// RVA: -1
	public override int GetParentId(int id) { }

	// RVA: 0x30A1258
	public override bool HasChildren(int id) { }

	// RVA: -1
	public override System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	public override void Move(int id, int newParentId, int childIndex, bool rebuildTree) { }

	// RVA: -1
	private bool IsChildOf(int childId, int id) { }

	// RVA: 0x30A188C
	public override System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ListViewController
{
	// Methods

	// RVA: 0x1716438
	protected ListView get_listView() { }

	// RVA: 0x17164C0
	protected override VisualElement MakeItem() { }

	// RVA: 0x1716620
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x171688C
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x1716944
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x17169F4
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MultiColumnListViewController
{
	// Fields
	private MultiColumnController m_ColumnController; // 0x48

	// Methods

	// RVA: 0x17169FC
	public MultiColumnController get_columnController() { }

	// RVA: 0x1716A04
	internal MultiColumnCollectionHeader get_header() { }

	// RVA: 0x1716A1C
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x1716AB4
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1716FE4
	protected override VisualElement MakeItem() { }

	// RVA: 0x1717004
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x1717090
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x17170B0
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x17170D0
	protected override void PrepareView() { }

	// RVA: 0x17172F4
	public override void Dispose() { }

	// RVA: 0x1717558
	private void UpdateReorderClassList() { }

}

// Namespace: UnityEngine.UIElements
public abstract class MultiColumnTreeViewController
{
	// Fields
	private MultiColumnController m_ColumnController; // 0x58

	// Methods

	// RVA: 0x17176D4
	public MultiColumnController get_columnController() { }

	// RVA: 0x17176DC
	internal MultiColumnCollectionHeader get_header() { }

	// RVA: 0x17176F4
	protected void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x17177AC
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1717CEC
	protected override VisualElement MakeItem() { }

	// RVA: 0x1717D0C
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x1717D98
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x1717DB8
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x1717DD8
	protected override void PrepareView() { }

	// RVA: 0x1717E00
	public override void Dispose() { }

}

// Namespace: 
private sealed class <GetAllItemIds>d__13
{
	// Fields
	private int <>1__state; // 0x0
	private int <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private System.Collections.Generic.IEnumerable<System.Int32> rootIds; // 0x0
	public System.Collections.Generic.IEnumerable<System.Int32> <>3__rootIds; // 0x0
	public UnityEngine.UIElements.TreeDataController<T> <>4__this; // 0x0
	private System.Collections.Generic.IEnumerator<System.Int32> <currentIterator>5__1; // 0x0
	private bool <hasNext>5__2; // 0x0
	private int <currentItemId>5__3; // 0x0

	// Methods

	// RVA: 0x30A24F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x30A2378
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30A1224
	private bool MoveNext() { }

	// RVA: 0x30A14A4
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <GetItemIds>d__9
{
	// Fields
	private int <>1__state; // 0x0
	private int <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items; // 0x0
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> <>3__items; // 0x0
	private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.TreeViewItemData<T>> <>s__1; // 0x0
	private UnityEngine.UIElements.TreeViewItemData<T> <item>5__2; // 0x0

	// Methods

	// RVA: 0x30A24F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x30A2378
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30A1224
	private bool MoveNext() { }

	// RVA: 0x30A2378
	private void <>m__Finally1() { }

	// RVA: 0x30A14A4
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class TreeDataController<T0>
{
	// Fields
	private UnityEngine.UIElements.TreeData<T> m_TreeData; // 0x0
	private System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<System.Int32>> m_IteratorStack; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }

	// RVA: 0x315B3A8
	public T GetDataForId(int id) { }

	// RVA: -1
	public int GetParentId(int id) { }

	// RVA: 0x30A1258
	public bool HasChildren(int id) { }

	// RVA: 0x30A52D0
	private static System.Collections.Generic.IEnumerable<System.Int32> GetItemIds(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items) { }

	// RVA: -1
	public System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	public void Move(int id, int newParentId, int childIndex) { }

	// RVA: -1
	public bool IsChildOf(int childId, int id) { }

	// RVA: 0x30A188C
	public System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class TreeViewController
{
	// Methods

	// RVA: 0x1717E70
	protected TreeView get_treeView() { }

	// RVA: 0x1717EF8
	protected override VisualElement MakeItem() { }

	// RVA: 0x1718058
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x1718248
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x1718300
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x17183B0
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class CollectionVirtualizationController
{
	// Fields
	protected readonly ScrollView m_ScrollView; // 0x10

	// Methods

	// RVA: -1
	public abstract int get_firstVisibleIndex() { }

	// RVA: -1
	protected abstract void set_firstVisibleIndex(int value) { }

	// RVA: -1
	public abstract int get_visibleItemCount() { }

	// RVA: 0x1718430
	protected void .ctor(ScrollView scrollView) { }

	// RVA: -1
	public abstract void Refresh(bool rebuild) { }

	// RVA: -1
	public abstract void ScrollToItem(int id) { }

	// RVA: -1
	public abstract void Resize(Vector2 size) { }

	// RVA: -1
	public abstract void OnScroll(Vector2 offset) { }

	// RVA: -1
	public abstract int GetIndexFromPosition(Vector2 position) { }

	// RVA: -1
	public abstract float GetExpectedItemHeight(int index) { }

	// RVA: -1
	public abstract float GetExpectedContentHeight() { }

	// RVA: -1
	public abstract void OnFocus(VisualElement leafTarget) { }

	// RVA: -1
	public abstract void OnBlur(VisualElement willFocus) { }

	// RVA: -1
	public abstract void UpdateBackground() { }

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }

	// RVA: -1
	internal abstract void StartDragItem(ReusableCollectionItem item) { }

	// RVA: -1
	internal abstract void EndDrag(int dropIndex) { }

}

// Namespace: 
private struct ContentHeightCacheInfo
{
	// Fields
	public readonly float sum; // 0x0
	public readonly int count; // 0x0

	// Methods

	// RVA: -1
	public void .ctor(float sum, int count) { }

}

// Namespace: 
private enum VirtualizationChange
{
	// Fields
	public int value__; // 0x0
	public const VirtualizationChange None = 0;
	public const VirtualizationChange Resize = 1;
	public const VirtualizationChange Scroll = 2;
	public const VirtualizationChange ForcedScroll = 3;
}

// Namespace: 
private enum ScrollDirection
{
	// Fields
	public int value__; // 0x0
	public const ScrollDirection Idle = 0;
	public const ScrollDirection Up = 1;
	public const ScrollDirection Down = 2;
}

// Namespace: UnityEngine.UIElements
internal class DynamicHeightVirtualizationController<T0>
{
	// Fields
	private int m_HighestCachedIndex; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.Int32,System.Single> m_ItemHeightCache; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.DynamicHeightVirtualizationController.ContentHeightCacheInfo<T>> m_ContentHeightCache; // 0x0
	private readonly System.Collections.Generic.HashSet<System.Int32> m_WaitingCache; // 0x0
	private int m_ForcedFirstVisibleItem; // 0x0
	private int m_ForcedLastVisibleItem; // 0x0
	private bool m_StickToBottom; // 0x0
	private VirtualizationChange m_LastChange; // 0x0
	private ScrollDirection m_ScrollDirection; // 0x0
	private Vector2 m_DelayedScrollOffset; // 0x0
	private float m_AccumulatedHeight; // 0x0
	private float m_MinimumItemHeight; // 0x0
	private Action m_FillCallback; // 0x0
	private Action m_ScrollCallback; // 0x0
	private Action m_ScrollResetCallback; // 0x0
	private System.Action<UnityEngine.UIElements.ReusableCollectionItem> m_GeometryChangedCallback; // 0x0
	private IVisualElementScheduledItem m_ScheduledItem; // 0x0
	private IVisualElementScheduledItem m_ScrollScheduledItem; // 0x0
	private IVisualElementScheduledItem m_ScrollResetScheduledItem; // 0x0
	private System.Predicate<System.Int32> m_IndexOutOfBoundsPredicate; // 0x0

	// Methods

	// RVA: -1
	private float get_defaultExpectedHeight() { }

	// RVA: -1
	private float get_contentPadding() { }

	// RVA: -1
	private void set_contentPadding(float value) { }

	// RVA: -1
	private float get_contentHeight() { }

	// RVA: -1
	private void set_contentHeight(float value) { }

	// RVA: 0x30A14A4
	private int get_anchoredIndex() { }

	// RVA: 0x30A24F0
	private void set_anchoredIndex(int value) { }

	// RVA: -1
	private float get_anchorOffset() { }

	// RVA: -1
	private void set_anchorOffset(float value) { }

	// RVA: -1
	private float get_viewportMaxOffset() { }

	// RVA: 0x30A1224
	protected override bool get_alwaysRebindOnRefresh() { }

	// RVA: 0x30A27C0
	public void .ctor(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x30A2404
	public override void Refresh(bool rebuild) { }

	// RVA: 0x30A24F0
	public override void ScrollToItem(int index) { }

	// RVA: -1
	public override void Resize(Vector2 size) { }

	// RVA: -1
	public override void OnScroll(Vector2 scrollOffset) { }

	// RVA: 0x30A2378
	private void OnScrollUpdate() { }

	// RVA: 0x30A24F0
	private void CycleItems(int firstIndex) { }

	// RVA: 0x30A1224
	private bool NeedsFill() { }

	// RVA: 0x30A2378
	private void Fill() { }

	// RVA: -1
	private void UpdateScrollViewContainer(float previousHeight, float newHeight) { }

	// RVA: 0x30A2404
	private void ApplyScrollViewUpdate(bool dimensionsOnly) { }

	// RVA: 0x30A2378
	private void UpdateAnchor() { }

	// RVA: 0x30A2378
	private void ScheduleFill() { }

	// RVA: 0x30A2378
	private void ScheduleScroll() { }

	// RVA: 0x30A2378
	private void ScheduleScrollDirectionReset() { }

	// RVA: 0x30A2378
	private void ResetScroll() { }

	// RVA: -1
	public override int GetIndexFromPosition(Vector2 position) { }

	// RVA: -1
	public override float GetExpectedItemHeight(int index) { }

	// RVA: 0x315B3A8
	private int GetFirstVisibleItem(float offset) { }

	// RVA: -1
	public override float GetExpectedContentHeight() { }

	// RVA: -1
	private float GetContentHeightForIndex(int lastIndex) { }

	// RVA: 0x315B3A8
	private ContentHeightCacheInfo GetCachedContentHeight(int index) { }

	// RVA: -1
	private void RegisterItemHeight(int index, float height) { }

	// RVA: 0x30A24F0
	private void UnregisterItemHeight(int index) { }

	// RVA: 0x30A2378
	private void CleanItemHeightCache() { }

	// RVA: 0x30A27C0
	private void OnRecycledItemGeometryChanged(ReusableCollectionItem item) { }

	// RVA: 0x30A1344
	private bool UpdateRegisteredHeight(ReusableCollectionItem item) { }

	// RVA: 0x315B3A8
	internal override T GetOrMakeItemAtIndex(int activeItemIndex, int scrollViewIndex) { }

	// RVA: 0x30A24F0
	internal override void ReleaseItem(int activeItemsIndex) { }

	// RVA: 0x30A27C0
	internal override void StartDragItem(ReusableCollectionItem item) { }

	// RVA: 0x30A24F0
	internal override void EndDrag(int dropIndex) { }

	// RVA: 0x30A24F0
	private void HideItem(int activeItemsIndex) { }

	// RVA: 0x315B3A8
	private void MarkWaitingForLayout(T item) { }

	// RVA: 0x30A1258
	private bool IsIndexOutOfBounds(int i) { }

}

// Namespace: UnityEngine.UIElements
internal class FixedHeightVirtualizationController<T0>
{
	// Methods

	// RVA: -1
	private float get_resolvedItemHeight() { }

	// RVA: 0x315B3A8
	protected override bool VisibleItemPredicate(T i) { }

	// RVA: 0x30A27C0
	public void .ctor(BaseVerticalCollectionView collectionView) { }

	// RVA: -1
	public override int GetIndexFromPosition(Vector2 position) { }

	// RVA: -1
	public override float GetExpectedItemHeight(int index) { }

	// RVA: -1
	public override float GetExpectedContentHeight() { }

	// RVA: 0x30A24F0
	public override void ScrollToItem(int index) { }

	// RVA: -1
	public override void Resize(Vector2 size) { }

	// RVA: -1
	public override void OnScroll(Vector2 scrollOffset) { }

	// RVA: 0x315B3A8
	internal override T GetOrMakeItemAtIndex(int activeItemIndex, int scrollViewIndex) { }

	// RVA: 0x30A24F0
	internal override void EndDrag(int dropIndex) { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableCollectionItem
{
	// Fields
	private VisualElement <bindableElement>k__BackingField; // 0x10
	private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> <animator>k__BackingField; // 0x18
	private int <index>k__BackingField; // 0x20
	private int <id>k__BackingField; // 0x24
	private bool <isDragGhost>k__BackingField; // 0x28
	private System.Action<UnityEngine.UIElements.ReusableCollectionItem> onGeometryChanged; // 0x30
	protected UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent> m_GeometryChangedEventCallback; // 0x38
	private System.Action<UnityEngine.UIElements.ReusableCollectionItem> onDestroy; // 0x40

	// Methods

	// RVA: 0x1718464
	public virtual VisualElement get_rootElement() { }

	// RVA: 0x171846C
	public VisualElement get_bindableElement() { }

	// RVA: 0x1718474
	protected void set_bindableElement(VisualElement value) { }

	// RVA: 0x171847C
	public UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> get_animator() { }

	// RVA: 0x1718484
	public void set_animator(UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> value) { }

	// RVA: 0x171848C
	public int get_index() { }

	// RVA: 0x1718494
	public void set_index(int value) { }

	// RVA: 0x171849C
	public int get_id() { }

	// RVA: 0x17184A4
	public void set_id(int value) { }

	// RVA: 0x17184AC
	internal bool get_isDragGhost() { }

	// RVA: 0x17184B4
	private void set_isDragGhost(bool value) { }

	// RVA: 0x17184BC
	public void add_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x1718570
	public void remove_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x1718624
	internal void add_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x17186D8
	internal void remove_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x171878C
	public void .ctor() { }

	// RVA: 0x1718828
	public virtual void Init(VisualElement item) { }

	// RVA: 0x1718830
	public virtual void PreAttachElement() { }

	// RVA: 0x17188F4
	public virtual void DetachElement() { }

	// RVA: 0x1718A08
	public virtual void DestroyElement() { }

	// RVA: 0x1718A28
	public virtual void SetSelected(bool selected) { }

	// RVA: 0x1718B4C
	public virtual void SetDragGhost(bool dragGhost) { }

	// RVA: 0x1718D08
	protected void OnGeometryChanged(GeometryChangedEvent evt) { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableListViewItem
{
	// Fields
	private VisualElement m_Container; // 0x48
	private VisualElement m_DragHandle; // 0x50
	private VisualElement m_ItemContainer; // 0x58

	// Methods

	// RVA: 0x1718D28
	public override VisualElement get_rootElement() { }

	// RVA: 0x170F05C
	public void Init(VisualElement item, bool usesAnimatedDragger) { }

	// RVA: 0x1718D40
	protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) { }

	// RVA: 0x170F754
	public void UpdateDragHandle(bool needsDragHandle) { }

	// RVA: 0x1719004
	public override void PreAttachElement() { }

	// RVA: 0x1719098
	public override void DetachElement() { }

	// RVA: 0x171912C
	public override void SetDragGhost(bool dragGhost) { }

	// RVA: 0x17191AC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableMultiColumnListViewItem
{
	// Methods

	// RVA: 0x1719248
	public override VisualElement get_rootElement() { }

	// RVA: 0x1719250
	public override void Init(VisualElement item) { }

	// RVA: 0x1716C04
	public void Init(VisualElement container, Columns columns, bool usesAnimatedDrag) { }

	// RVA: 0x1719254
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableMultiColumnTreeViewItem
{
	// Methods

	// RVA: 0x17192F0
	public override VisualElement get_rootElement() { }

	// RVA: 0x17192F8
	public override void Init(VisualElement item) { }

	// RVA: 0x1717914
	public void Init(VisualElement container, Columns columns) { }

	// RVA: 0x1719848
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableTreeViewItem
{
	// Fields
	private Toggle m_Toggle; // 0x48
	private VisualElement m_Container; // 0x50
	private VisualElement m_IndentElement; // 0x58
	private VisualElement m_BindableContainer; // 0x60
	private VisualElement m_Checkmark; // 0x68
	private System.Action<UnityEngine.UIElements.PointerUpEvent> onPointerUp; // 0x70
	private System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> onToggleValueChanged; // 0x78
	private int m_Depth; // 0x80
	private float m_IndentWidth; // 0x84
	private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent> m_PointerUpCallback; // 0x88
	private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<System.Boolean>> m_ToggleValueChangedCallback; // 0x90
	private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.GeometryChangedEvent> m_ToggleGeometryChangedCallback; // 0x98

	// Methods

	// RVA: 0x1719A08
	public override VisualElement get_rootElement() { }

	// RVA: 0x17125F4
	public void add_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value) { }

	// RVA: 0x171245C
	public void remove_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value) { }

	// RVA: 0x17126A8
	public void add_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value) { }

	// RVA: 0x1712510
	public void remove_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value) { }

	// RVA: 0x171984C
	public void .ctor() { }

	// RVA: 0x1719A20
	public override void Init(VisualElement item) { }

	// RVA: 0x17192FC
	protected void InitExpandHierarchy(VisualElement root, VisualElement item) { }

	// RVA: 0x1719B04
	public override void PreAttachElement() { }

	// RVA: 0x1719CE0
	public override void DetachElement() { }

	// RVA: 0x171200C
	public void Indent(int depth) { }

	// RVA: 0x1712118
	public void SetExpandedWithoutNotify(bool expanded) { }

	// RVA: 0x1712220
	public void SetToggleVisibility(bool visible) { }

	// RVA: 0x1719FFC
	private void OnToggleGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x1719EBC
	private void UpdateIndentLayout() { }

	// RVA: 0x171A254
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x171A270
	private void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.VerticalVirtualizationController.<>c<T> <>9; // 0x0
	public static System.Func<T> <>9__30_0; // 0x0
	public static System.Action<T> <>9__30_1; // 0x0
	public static System.Action<T> <>9__30_2; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal T <.ctor>b__30_0() { }

	// RVA: 0x315B3A8
	internal void <.ctor>b__30_1(T i) { }

	// RVA: 0x315B3A8
	internal void <.ctor>b__30_2(T i) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class VerticalVirtualizationController<T0>
{
	// Fields
	private readonly UnityEngine.Pool.ObjectPool<T> m_Pool; // 0x0
	protected BaseVerticalCollectionView m_CollectionView; // 0x0
	protected System.Collections.Generic.List<T> m_ActiveItems; // 0x0
	protected T m_DraggedItem; // 0x0
	private int m_LastFocusedElementIndex; // 0x0
	private System.Collections.Generic.List<System.Int32> m_LastFocusedElementTreeChildIndexes; // 0x0
	protected readonly System.Func<T,System.Boolean> m_VisibleItemPredicateDelegate; // 0x0
	protected System.Collections.Generic.List<T> m_ScrollInsertionList; // 0x0
	private VisualElement m_EmptyRows; // 0x0

	// Methods

	// RVA: 0x30A17DC
	public override System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }

	// RVA: 0x30A14A4
	internal int get_itemsCount() { }

	// RVA: 0x315B3A8
	protected virtual bool VisibleItemPredicate(T i) { }

	// RVA: 0x315B3A8
	internal T get_firstVisibleItem() { }

	// RVA: 0x315B3A8
	internal T get_lastVisibleItem() { }

	// RVA: 0x30A14A4
	public override int get_visibleItemCount() { }

	// RVA: 0x30A17DC
	protected SerializedVirtualizationData get_serializedData() { }

	// RVA: 0x30A14A4
	public override int get_firstVisibleIndex() { }

	// RVA: 0x30A24F0
	protected override void set_firstVisibleIndex(int value) { }

	// RVA: -1
	protected float get_lastHeight() { }

	// RVA: 0x30A1224
	protected virtual bool get_alwaysRebindOnRefresh() { }

	// RVA: 0x30A27C0
	protected void .ctor(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x30A2404
	public override void Refresh(bool rebuild) { }

	// RVA: 0x315B3A8
	protected void Setup(T recycledItem, int newIndex) { }

	// RVA: 0x30A27C0
	public override void OnFocus(VisualElement leafTarget) { }

	// RVA: 0x30A27C0
	public override void OnBlur(VisualElement willFocus) { }

	// RVA: 0x30A2828
	private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) { }

	// RVA: 0x30A2378
	public override void UpdateBackground() { }

	// RVA: 0x30A27C0
	internal override void StartDragItem(ReusableCollectionItem item) { }

	// RVA: 0x30A24F0
	internal override void EndDrag(int dropIndex) { }

	// RVA: 0x315B3A8
	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex, int scrollViewIndex) { }

	// RVA: 0x30A24F0
	internal virtual void ReleaseItem(int activeItemsIndex) { }

	// RVA: 0x30A27C0
	private void OnDestroyItem(ReusableCollectionItem item) { }

	// RVA: 0x30A14A4
	protected int GetDraggedIndex() { }

}

// Namespace: UnityEngine.UIElements
public abstract class ContextualMenuManager
{
	// Fields
	private bool <displayMenuHandledOSX>k__BackingField; // 0x10

	// Methods

	// RVA: 0x171A28C
	internal bool get_displayMenuHandledOSX() { }

	// RVA: 0x171A294
	internal void set_displayMenuHandledOSX(bool value) { }

	// RVA: -1
	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler) { }

	// RVA: 0x171A29C
	public void DisplayMenu(EventBase triggerEvent, IEventHandler target) { }

	// RVA: -1
	protected internal abstract void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent) { }

}

// Namespace: UnityEngine.UIElements
public class ContextualMenuManipulator
{
	// Fields
	private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent> m_MenuBuilder; // 0x30

	// Methods

	// RVA: 0x171A678
	public void .ctor(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent> menuBuilder) { }

	// RVA: 0x171A7B8
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x171AAA0
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x171AD88
	private void OnMouseUpDownEvent(IMouseEvent evt) { }

	// RVA: 0x171AEF4
	private void OnMouseDownEventOSX(MouseDownEvent evt) { }

	// RVA: 0x171B008
	private void OnMouseUpEventOSX(MouseUpEvent evt) { }

	// RVA: 0x171B110
	private void OnKeyUpEvent(KeyUpEvent evt) { }

	// RVA: 0x171AE48
	private void DoDisplayMenu(EventBase evt) { }

	// RVA: 0x171B184
	private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt) { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseBoolField
{
	// Fields
	protected Label m_Label; // 0x440
	protected readonly VisualElement m_CheckMark; // 0x448
	internal Clickable m_Clickable; // 0x450
	private string m_OriginalText; // 0x458

	// Methods

	// RVA: 0x171B1A0
	public void .ctor(string label) { }

	// RVA: 0x171B564
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x171B5A0
	public string get_text() { }

	// RVA: 0x171B4C4
	public void set_text(string value) { }

	// RVA: 0x171B5BC
	protected virtual void InitLabel() { }

	// RVA: 0x171B660
	public override void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x171B768
	private void OnClickEvent(EventBase evt) { }

	// RVA: 0x171BA60
	protected virtual void ToggleValue() { }

	// RVA: 0x171BAA0
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x171BCEC
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x171BE08
	internal override void UnregisterEditingCallbacks() { }

}

// Namespace: 
public sealed class WriteDelegate
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(TValueType val, TFieldValue fieldValue) { }

}

// Namespace: 
internal struct FieldDescription
{
	// Fields
	internal readonly string name; // 0x0
	internal readonly string ussName; // 0x0
	internal readonly System.Func<TValueType,TFieldValue> read; // 0x0
	internal readonly WriteDelegate write; // 0x0

	// Methods

	// RVA: 0x30A2C60
	public void .ctor(string name, string ussName, System.Func<TValueType,TFieldValue> read, WriteDelegate write) { }

}

// Namespace: 
private sealed class <>c__DisplayClass24_0
{
	// Fields
	public FieldDescription desc; // 0x0
	public TField field; // 0x0
	public UnityEngine.UIElements.BaseCompositeField<TValueType,TField,TFieldValue> <>4__this; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal TFieldValue <.ctor>b__0(TFieldValue newValue) { }

	// RVA: 0x30A27C0
	internal void <.ctor>b__1(UnityEngine.UIElements.ChangeEvent<TFieldValue> e) { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseCompositeField<T0, T1, T2>
{
	// Fields
	private System.Collections.Generic.List<TField> m_Fields; // 0x0
	private bool m_ShouldUpdateDisplay; // 0x0
	private bool m_ForceUpdateDisplay; // 0x0
	private int m_PropertyIndex; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0
	public static readonly string spacerUssClassName; // 0x0
	public static readonly string multilineVariantUssClassName; // 0x0
	public static readonly string fieldGroupUssClassName; // 0x0
	public static readonly string fieldUssClassName; // 0x0
	public static readonly string firstFieldVariantUssClassName; // 0x0
	public static readonly string twoLinesVariantUssClassName; // 0x0

	// Methods

	// RVA: 0x30A17DC
	private VisualElement GetSpacer() { }

	// RVA: -1
	internal abstract FieldDescription[] DescribeFields() { }

	// RVA: 0x30A2828
	protected void .ctor(string label, int fieldsByLine) { }

	// RVA: 0x30A2378
	private void UpdateDisplay() { }

	// RVA: 0x315B3A8
	public override void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30A2378
	internal override void OnViewDataReady() { }

	// RVA: 0x30A2378
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public enum ListViewReorderMode
{
	// Fields
	public int value__; // 0x10
	public const ListViewReorderMode Simple = 0;
	public const ListViewReorderMode Animated = 1;
}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader; // 0xB0
	private readonly UxmlStringAttributeDescription m_HeaderTitle; // 0xB8
	private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter; // 0xC0
	private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ListViewReorderMode> m_ReorderMode; // 0xC8
	private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize; // 0xD0

	// Methods

	// RVA: 0x171EF58
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x171F444
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseListView
{
	// Fields
	private static readonly string k_SizeFieldLabel; // 0x0
	private bool m_ShowBoundCollectionSize; // 0x4AC
	private bool m_ShowFoldoutHeader; // 0x4AD
	private string m_HeaderTitle; // 0x4B0
	private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsAdded; // 0x4B8
	private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsRemoved; // 0x4C0
	private Action itemsSourceSizeChanged; // 0x4C8
	private Label m_ListViewLabel; // 0x4D0
	private Foldout m_Foldout; // 0x4D8
	private TextField m_ArraySizeField; // 0x4E0
	private bool m_IsOverMultiEditLimit; // 0x4E8
	private VisualElement m_Footer; // 0x4F0
	private Button m_AddButton; // 0x4F8
	private Button m_RemoveButton; // 0x500
	private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> m_ItemAddedCallback; // 0x508
	private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> m_ItemRemovedCallback; // 0x510
	private Action m_ItemsSourceSizeChangedCallback; // 0x518
	private ListViewReorderMode m_ReorderMode; // 0x520
	private Action reorderModeChanged; // 0x528
	public static readonly string ussClassName; // 0x8
	public static readonly string itemUssClassName; // 0x10
	public static readonly string emptyLabelUssClassName; // 0x18
	public static readonly string overMaxMultiEditLimitClassName; // 0x20
	public static readonly string reorderableUssClassName; // 0x28
	public static readonly string reorderableItemUssClassName; // 0x30
	public static readonly string reorderableItemContainerUssClassName; // 0x38
	public static readonly string reorderableItemHandleUssClassName; // 0x40
	public static readonly string reorderableItemHandleBarUssClassName; // 0x48
	public static readonly string footerUssClassName; // 0x50
	public static readonly string foldoutHeaderUssClassName; // 0x58
	public static readonly string arraySizeFieldUssClassName; // 0x60
	public static readonly string arraySizeFieldWithHeaderUssClassName; // 0x68
	public static readonly string arraySizeFieldWithFooterUssClassName; // 0x70
	public static readonly string listViewWithHeaderUssClassName; // 0x78
	public static readonly string listViewWithFooterUssClassName; // 0x80
	public static readonly string scrollViewWithFooterUssClassName; // 0x88
	public static readonly string footerAddButtonName; // 0x90
	public static readonly string footerRemoveButtonName; // 0x98
	private string m_MaxMultiEditStr; // 0x530
	private static readonly string k_EmptyListStr; // 0xA0

	// Methods

	// RVA: 0x171BF24
	public bool get_showBoundCollectionSize() { }

	// RVA: 0x171BF2C
	public void set_showBoundCollectionSize(bool value) { }

	// RVA: 0x171C270
	public bool get_showFoldoutHeader() { }

	// RVA: 0x171C278
	public void set_showFoldoutHeader(bool value) { }

	// RVA: 0x171BF44
	internal void SetupArraySizeField() { }

	// RVA: 0x171CCC4
	public void set_headerTitle(string value) { }

	// RVA: 0x171C76C
	public bool get_showAddRemoveFooter() { }

	// RVA: 0x171CD0C
	public void set_showAddRemoveFooter(bool value) { }

	// RVA: 0x171C77C
	private void EnableFooter(bool enabled) { }

	// RVA: 0x171CD10
	private void AddItems(int itemCount) { }

	// RVA: 0x171CE2C
	private void OnArraySizeFieldChanged(UnityEngine.UIElements.ChangeEvent<System.String> evt) { }

	// RVA: 0x171CB74
	internal void UpdateArraySizeField() { }

	// RVA: 0x171C4C8
	internal void UpdateListViewLabel() { }

	// RVA: 0x171D214
	private void OnAddClicked() { }

	// RVA: 0x171D544
	private void OnRemoveClicked() { }

	// RVA: 0x171D848
	internal VisualElement get_footer() { }

	// RVA: 0x171CDA4
	public BaseListViewController get_viewController() { }

	// RVA: 0x171D850
	internal override void CreateVirtualizationController() { }

	// RVA: 0x171D8A4
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x171DF94
	private void OnItemAdded(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x171DFB0
	private void OnItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x171DFCC
	private void OnItemsSourceSizeChanged() { }

	// RVA: 0x171724C
	internal void add_reorderModeChanged(Action value) { }

	// RVA: 0x17174B0
	internal void remove_reorderModeChanged(Action value) { }

	// RVA: 0x171E070
	public ListViewReorderMode get_reorderMode() { }

	// RVA: 0x171E078
	public void set_reorderMode(ListViewReorderMode value) { }

	// RVA: 0x171E0E8
	internal override ListViewDragger CreateDragger() { }

	// RVA: 0x171E18C
	internal override ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x171E1F4
	public void .ctor() { }

	// RVA: 0x171E2C8
	internal override void PostRefresh() { }

	// RVA: 0x171E2F8
	internal override bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	// RVA: 0x171E94C
	private static void .cctor() { }

	// RVA: 0x171EE84
	private void <OnAddClicked>b__38_0() { }

}

// Namespace: 
private class PopupTextElement
{
	// Methods

	// RVA: -1
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.BasePopupField.<>c<TValueType,TValueChoice> <>9; // 0x0
	public static UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.MouseDownEvent> <>9__23_0; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
	internal void <.ctor>b__23_0(MouseDownEvent e) { }

}

// Namespace: UnityEngine.UIElements
public abstract class BasePopupField<T0, T1>
{
	// Fields
	internal System.Collections.Generic.List<TValueChoice> m_Choices; // 0x0
	private TextElement m_TextElement; // 0x0
	private VisualElement m_ArrowElement; // 0x0
	internal System.Func<TValueChoice,System.String> m_FormatSelectedValueCallback; // 0x0
	internal System.Func<TValueChoice,System.String> m_FormatListItemCallback; // 0x0
	internal System.Func<UnityEngine.UIElements.IGenericMenu> createMenuCallback; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string textUssClassName; // 0x0
	public static readonly string arrowUssClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0

	// Methods

	// RVA: 0x30A17DC
	protected TextElement get_textElement() { }

	// RVA: -1
	internal abstract string GetValueToDisplay() { }

	// RVA: -1
	internal abstract string GetListItemToDisplay(TValueType item) { }

	// RVA: -1
	internal abstract void AddMenuItems(IGenericMenu menu) { }

	// RVA: 0x30A27C0
	public virtual void set_choices(System.Collections.Generic.List<TValueChoice> value) { }

	// RVA: 0x315B3A8
	public override void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30A27C0
	internal void .ctor(string label) { }

	// RVA: 0x30A27C0
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x30A27C0
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x30A1258
	private bool ContainsPointer(int pointerId) { }

	// RVA: 0x30A27C0
	private void ProcessPointerDown(UnityEngine.UIElements.PointerEventBase<T> evt) { }

	// RVA: 0x30A27C0
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x30A2378
	internal void ShowMenu() { }

	// RVA: 0x30A2378
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public enum SliderDirection
{
	// Fields
	public int value__; // 0x10
	public const SliderDirection Horizontal = 0;
	public const SliderDirection Vertical = 1;
}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
internal enum SliderKey
{
	// Fields
	public int value__; // 0x0
	public const SliderKey None = 0;
	public const SliderKey Lowest = 1;
	public const SliderKey LowerPage = 2;
	public const SliderKey Lower = 3;
	public const SliderKey Higher = 4;
	public const SliderKey HigherPage = 5;
	public const SliderKey Highest = 6;
}

// Namespace: UnityEngine.UIElements
public abstract class BaseSlider<T0>
{
	// Fields
	private VisualElement <dragContainer>k__BackingField; // 0x0
	private VisualElement <dragElement>k__BackingField; // 0x0
	private VisualElement <trackElement>k__BackingField; // 0x0
	private VisualElement <dragBorderElement>k__BackingField; // 0x0
	private TextField <inputTextField>k__BackingField; // 0x0
	private bool m_IsEditingTextField; // 0x0
	private TValueType m_LowValue; // 0x0
	private TValueType m_HighValue; // 0x0
	private float m_PageSize; // 0x0
	private bool m_ShowInputField; // 0x0
	private bool <clamped>k__BackingField; // 0x0
	private UnityEngine.UIElements.ClampedDragger<TValueType> <clampedDragger>k__BackingField; // 0x0
	private Rect m_DragElementStartPos; // 0x0
	private SliderDirection m_Direction; // 0x0
	private bool m_Inverted; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0
	public static readonly string horizontalVariantUssClassName; // 0x0
	public static readonly string verticalVariantUssClassName; // 0x0
	public static readonly string dragContainerUssClassName; // 0x0
	public static readonly string trackerUssClassName; // 0x0
	public static readonly string draggerUssClassName; // 0x0
	public static readonly string draggerBorderUssClassName; // 0x0
	public static readonly string textFieldClassName; // 0x0

	// Methods

	// RVA: 0x30A17DC
	internal VisualElement get_dragContainer() { }

	// RVA: 0x30A27C0
	private void set_dragContainer(VisualElement value) { }

	// RVA: 0x30A17DC
	internal VisualElement get_dragElement() { }

	// RVA: 0x30A27C0
	private void set_dragElement(VisualElement value) { }

	// RVA: 0x30A17DC
	internal VisualElement get_trackElement() { }

	// RVA: 0x30A27C0
	private void set_trackElement(VisualElement value) { }

	// RVA: 0x30A17DC
	internal VisualElement get_dragBorderElement() { }

	// RVA: 0x30A27C0
	private void set_dragBorderElement(VisualElement value) { }

	// RVA: 0x30A17DC
	internal TextField get_inputTextField() { }

	// RVA: 0x30A27C0
	private void set_inputTextField(TextField value) { }

	// RVA: 0x315B3A8
	public TValueType get_lowValue() { }

	// RVA: 0x315B3A8
	public void set_lowValue(TValueType value) { }

	// RVA: 0x315B3A8
	public TValueType get_highValue() { }

	// RVA: 0x315B3A8
	public void set_highValue(TValueType value) { }

	// RVA: 0x315B3A8
	internal void SetHighValueWithoutNotify(TValueType newHighValue) { }

	// RVA: -1
	public virtual float get_pageSize() { }

	// RVA: -1
	public virtual void set_pageSize(float value) { }

	// RVA: 0x30A1224
	public virtual bool get_showInputField() { }

	// RVA: 0x30A2404
	public virtual void set_showInputField(bool value) { }

	// RVA: 0x30A1224
	internal bool get_clamped() { }

	// RVA: 0x30A2404
	internal void set_clamped(bool value) { }

	// RVA: 0x30A17DC
	internal UnityEngine.UIElements.ClampedDragger<TValueType> get_clampedDragger() { }

	// RVA: 0x30A27C0
	private void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<TValueType> value) { }

	// RVA: 0x315B3A8
	private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) { }

	// RVA: 0x315B3A8
	private TValueType GetClampedValue(TValueType newValue) { }

	// RVA: 0x315B3A8
	public override TValueType get_value() { }

	// RVA: 0x315B3A8
	public override void set_value(TValueType value) { }

	// RVA: 0x315B3A8
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	// RVA: 0x30A2378
	private void UnityEngine.UIElements.IValueField<TValueType>.StartDragging() { }

	// RVA: 0x30A2378
	private void UnityEngine.UIElements.IValueField<TValueType>.StopDragging() { }

	// RVA: 0x315B3A8
	public override void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30A14A4
	public SliderDirection get_direction() { }

	// RVA: 0x30A24F0
	public void set_direction(SliderDirection value) { }

	// RVA: 0x30A1224
	public bool get_inverted() { }

	// RVA: 0x30A2404
	public void set_inverted(bool value) { }

	// RVA: 0x315B3A8
	internal void .ctor(string label, TValueType start, TValueType end, SliderDirection direction, float pageSize) { }

	// RVA: -1
	protected static float GetClosestPowerOfTen(float positiveNumber) { }

	// RVA: -1
	protected static float RoundToMultipleOf(float value, float roundingValue) { }

	// RVA: 0x30A2378
	private void ClampValue() { }

	// RVA: -1
	internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant) { }

	// RVA: -1
	internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue) { }

	// RVA: -1
	internal abstract TValueType ParseStringToValue(string previousValue, string newValue) { }

	// RVA: -1
	internal abstract void ComputeValueFromKey(SliderKey sliderKey, bool isShift) { }

	// RVA: 0x315B3A8
	private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant) { }

	// RVA: 0x30A2378
	private void SetSliderValueFromDrag() { }

	// RVA: 0x315B3A8
	private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos) { }

	// RVA: 0x30A2378
	private void SetSliderValueFromClick() { }

	// RVA: 0x30A27C0
	private void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x30A27C0
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	// RVA: -1
	internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	// RVA: -1
	public void AdjustDragElement(float factor) { }

	// RVA: 0x30A27C0
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	// RVA: 0x30A2378
	internal override void OnViewDataReady() { }

	// RVA: 0x315B3A8
	private bool SameValues(float a, float b, float epsilon) { }

	// RVA: 0x30A2378
	private void UpdateDragElementPosition() { }

	// RVA: 0x30A27C0
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x30A2378
	private void UpdateTextFieldVisibility() { }

	// RVA: 0x30A2378
	private void UpdateTextFieldValue() { }

	// RVA: 0x30A27C0
	private void OnTextFieldFocusIn(FocusInEvent evt) { }

	// RVA: 0x30A27C0
	private void OnTextFieldFocusOut(FocusOutEvent evt) { }

	// RVA: 0x30A27C0
	private void OnInputNavigationMoveEvent(NavigationMoveEvent evt) { }

	// RVA: 0x30A27C0
	private void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent<System.String> evt) { }

	// RVA: 0x30A2378
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x30A2378
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x30A2378
	internal override void UnregisterEditingCallbacks() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private readonly UxmlBoolAttributeDescription m_AutoExpand; // 0xB0

	// Methods

	// RVA: 0x1722208
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1722364
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseTreeView
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string itemUssClassName; // 0x8
	public static readonly string itemToggleUssClassName; // 0x10
	public static readonly string itemIndentsContainerUssClassName; // 0x18
	public static readonly string itemIndentUssClassName; // 0x20
	public static readonly string itemContentContainerUssClassName; // 0x28
	private bool m_AutoExpand; // 0x4AC
	private System.Collections.Generic.List<System.Int32> m_ExpandedItemIds; // 0x4B0

	// Methods

	// RVA: 0x171FC08
	public IList get_itemsSource() { }

	// RVA: 0x171FC88
	public BaseTreeViewController get_viewController() { }

	// RVA: 0x171FD10
	internal override void CreateVirtualizationController() { }

	// RVA: 0x171FD64
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x172000C
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x1720240
	internal override ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x17202A8
	public bool get_autoExpand() { }

	// RVA: 0x17202B0
	public void set_autoExpand(bool value) { }

	// RVA: 0x1720348
	internal System.Collections.Generic.List<System.Int32> get_expandedItemIds() { }

	// RVA: 0x1720350
	internal void set_expandedItemIds(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x1720360
	public void .ctor() { }

	// RVA: 0x1720368
	public void .ctor(int itemHeight) { }

	// RVA: 0x1720670
	internal override void OnViewDataReady() { }

	// RVA: 0x1720790
	internal override bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	// RVA: 0x17213E4
	public void SetSelectionById(int id) { }

	// RVA: 0x1721668
	public void SetSelectionById(System.Collections.Generic.IEnumerable<System.Int32> ids) { }

	// RVA: 0x1721670
	internal void SetSelectionInternalById(System.Collections.Generic.IEnumerable<System.Int32> ids, bool sendNotification) { }

	// RVA: 0x1721C08
	private int GetItemIndex(int id, bool expand) { }

	// RVA: 0x1721E30
	public bool IsExpanded(int id) { }

	// RVA: 0x1721EC0
	public void CollapseItem(int id, bool collapseAllChildren) { }

	// RVA: 0x1721F60
	public void ExpandItem(int id, bool expandAllChildren) { }

	// RVA: 0x1721FFC
	private void OnTreeViewPointerUp(PointerUpEvent evt) { }

	// RVA: 0x172101C
	private bool IsExpandedByIndex(int index) { }

	// RVA: 0x17211D8
	private void CollapseItemByIndex(int index, bool collapseAll) { }

	// RVA: 0x17210AC
	private void ExpandItemByIndex(int index, bool expandAll) { }

	// RVA: 0x1722038
	private static void .cctor() { }

	// RVA: 0x1722200
	private int <SetSelectionInternalById>b__47_0(int id) { }

}

// Namespace: UnityEngine.UIElements
public enum AlternatingRowBackground
{
	// Fields
	public int value__; // 0x10
	public const AlternatingRowBackground None = 0;
	public const AlternatingRowBackground ContentOnly = 1;
	public const AlternatingRowBackground All = 2;
}

// Namespace: UnityEngine.UIElements
public enum CollectionVirtualizationMethod
{
	// Fields
	public int value__; // 0x10
	public const CollectionVirtualizationMethod FixedHeight = 0;
	public const CollectionVirtualizationMethod DynamicHeight = 1;
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class SerializedVirtualizationData
{
	// Fields
	public Vector2 scrollOffset; // 0x10
	public int firstVisibleIndex; // 0x18
	public float contentPadding; // 0x1C
	public float contentHeight; // 0x20
	public int anchoredItemIndex; // 0x24
	public float anchorOffset; // 0x28

	// Methods

	// RVA: 0x1722438
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private readonly UxmlIntAttributeDescription m_FixedItemHeight; // 0x78
	private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.CollectionVirtualizationMethod> m_VirtualizationMethod; // 0x80
	private readonly UxmlBoolAttributeDescription m_ShowBorder; // 0x88
	private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SelectionType> m_SelectionType; // 0x90
	private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.AlternatingRowBackground> m_ShowAlternatingRowBackgrounds; // 0x98
	private readonly UxmlBoolAttributeDescription m_Reorderable; // 0xA0
	private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled; // 0xA8

	// Methods

	// RVA: 0x171F74C
	public void .ctor() { }

	// RVA: 0x171F134
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: 
private class Selection
{
	// Fields
	private readonly System.Collections.Generic.HashSet<System.Int32> m_IndexLookup; // 0x10
	private readonly System.Collections.Generic.HashSet<System.Int32> m_IdLookup; // 0x18
	private int m_MinIndex; // 0x20
	private int m_MaxIndex; // 0x24
	private System.Collections.Generic.List<System.Int32> <selectedIds>k__BackingField; // 0x28
	public readonly System.Collections.Generic.List<System.Int32> indices; // 0x30
	public readonly System.Collections.Generic.Dictionary<System.Int32,System.Object> items; // 0x38

	// Methods

	// RVA: 0x172A048
	public System.Collections.Generic.List<System.Int32> get_selectedIds() { }

	// RVA: 0x172A050
	public void set_selectedIds(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x17229D4
	public int get_indexCount() { }

	// RVA: 0x1724B64
	public int get_idCount() { }

	// RVA: 0x172633C
	public int get_minIndex() { }

	// RVA: 0x17262F8
	public int get_maxIndex() { }

	// RVA: 0x17292F4
	public int get_capacity() { }

	// RVA: 0x1729348
	public void set_capacity(int value) { }

	// RVA: 0x1722A20
	public int FirstIndex() { }

	// RVA: 0x1724BB0
	public bool ContainsIndex(int index) { }

	// RVA: 0x1727A40
	public bool ContainsId(int id) { }

	// RVA: 0x1728400
	public void AddId(int id) { }

	// RVA: 0x1724C24
	public void AddIndex(int index, object obj) { }

	// RVA: 0x1728D3C
	public bool TryRemove(int index) { }

	// RVA: 0x1728E68
	public void RemoveId(int id) { }

	// RVA: 0x172A058
	public void ClearItems() { }

	// RVA: 0x172A0AC
	public void ClearIds() { }

	// RVA: 0x1724A04
	public void ClearIndices() { }

	// RVA: 0x17293FC
	public void Clear() { }

	// RVA: 0x1723DB8
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass162_0
{
	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x172407C
	public void .ctor() { }

	// RVA: 0x172A170
	internal bool <GetRootElementForId>b__0(ReusableCollectionItem t) { }

}

// Namespace: 
private struct <>c__DisplayClass172_0
{
	// Fields
	public bool selectedIndicesChanged; // 0x10
	public BaseVerticalCollectionView <>4__this; // 0x18
	public int previousSelectionCount; // 0x20
}

// Namespace: 
private struct <>c__DisplayClass183_0
{
	// Fields
	public BaseVerticalCollectionView <>4__this; // 0x10
	public bool shiftKey; // 0x18
}

// Namespace: 
private sealed class <get_selectedItems>d__72
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public BaseVerticalCollectionView <>4__this; // 0x28
	private Enumerator <>s__1; // 0x30
	private int <index>5__2; // 0x48
	private object <item>5__3; // 0x50

	// Methods

	// RVA: 0x1722B40
	public void .ctor(int <>1__state) { }

	// RVA: 0x172A198
	private void System.IDisposable.Dispose() { }

	// RVA: 0x172A228
	private bool MoveNext() { }

	// RVA: 0x172A594
	private void <>m__Finally1() { }

	// RVA: 0x172A5F0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x172A5F8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x172A638
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x172A640
	private System.Collections.Generic.IEnumerator<System.Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

	// RVA: 0x172A6F4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseVerticalCollectionView
{
	// Fields
	private static readonly ProfilerMarker k_RefreshMarker; // 0x0
	private static readonly ProfilerMarker k_RebuildMarker; // 0x8
	private System.Action<System.Collections.Generic.IEnumerable<System.Object>> itemsChosen; // 0x3D8
	private System.Action<System.Collections.Generic.IEnumerable<System.Object>> selectionChanged; // 0x3E0
	private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> selectedIndicesChanged; // 0x3E8
	private System.Action<System.Int32,System.Int32> itemIndexChanged; // 0x3F0
	private Action itemsSourceChanged; // 0x3F8
	private Action selectionNotChanged; // 0x400
	private System.Func<UnityEngine.UIElements.CanStartDragArgs,System.Boolean> canStartDrag; // 0x408
	private System.Func<UnityEngine.UIElements.SetupDragAndDropArgs,UnityEngine.UIElements.StartDragArgs> setupDragAndDrop; // 0x410
	private System.Func<UnityEngine.UIElements.HandleDragAndDropArgs,UnityEngine.UIElements.DragVisualMode> dragAndDropUpdate; // 0x418
	private System.Func<UnityEngine.UIElements.HandleDragAndDropArgs,UnityEngine.UIElements.DragVisualMode> handleDrop; // 0x420
	private SelectionType m_SelectionType; // 0x428
	private static readonly System.Collections.Generic.List<UnityEngine.UIElements.ReusableCollectionItem> k_EmptyItems; // 0x10
	private bool m_HorizontalScrollingEnabled; // 0x42C
	private AlternatingRowBackground m_ShowAlternatingRowBackgrounds; // 0x430
	internal static readonly int s_DefaultItemHeight; // 0x18
	internal float m_FixedItemHeight; // 0x434
	internal bool m_ItemHeightIsInline; // 0x438
	private CollectionVirtualizationMethod m_VirtualizationMethod; // 0x43C
	private readonly ScrollView m_ScrollView; // 0x440
	private CollectionViewController m_ViewController; // 0x448
	private CollectionVirtualizationController m_VirtualizationController; // 0x450
	private KeyboardNavigationManipulator m_NavigationManipulator; // 0x458
	internal SerializedVirtualizationData serializedVirtualizationData; // 0x460
	private readonly System.Collections.Generic.List<System.Int32> m_SelectedIds; // 0x468
	private readonly Selection m_Selection; // 0x470
	private float m_LastHeight; // 0x478
	private bool m_IsRangeSelectionDirectionUp; // 0x47C
	private ListViewDragger m_Dragger; // 0x480
	internal static UnityEngine.UIElements.CustomStyleProperty<System.Int32> s_ItemHeightProperty; // 0x20
	private System.Action<System.Int32,System.Int32> m_ItemIndexChangedCallback; // 0x488
	private Action m_ItemsSourceChangedCallback; // 0x490
	internal IVisualElementScheduledItem m_RebuildScheduled; // 0x498
	public static readonly string ussClassName; // 0x28
	public static readonly string borderUssClassName; // 0x30
	public static readonly string itemUssClassName; // 0x38
	public static readonly string dragHoverBarUssClassName; // 0x40
	public static readonly string dragHoverMarkerUssClassName; // 0x48
	public static readonly string itemDragHoverUssClassName; // 0x50
	public static readonly string itemSelectedVariantUssClassName; // 0x58
	public static readonly string itemAlternativeBackgroundUssClassName; // 0x60
	public static readonly string listScrollViewUssClassName; // 0x68
	internal static readonly string backgroundFillUssClassName; // 0x70
	private Vector3 m_TouchDownPosition; // 0x4A0

	// Methods

	// RVA: 0x1722440
	internal bool HasCanStartDrag() { }

	// RVA: 0x1722450
	internal bool RaiseCanStartDrag(ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids) { }

	// RVA: 0x1722514
	internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids, StartDragArgs args) { }

	// RVA: 0x17225D8
	internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	// RVA: 0x1722664
	internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	// RVA: 0x17226F0
	public IList get_itemsSource() { }

	// RVA: 0x1722708
	public void set_itemsSource(IList value) { }

	// RVA: 0x17227D4
	public override VisualElement get_contentContainer() { }

	// RVA: 0x17227DC
	public SelectionType get_selectionType() { }

	// RVA: 0x17227E4
	public void set_selectionType(SelectionType value) { }

	// RVA: 0x1722AB8
	public System.Collections.Generic.IEnumerable<System.Object> get_selectedItems() { }

	// RVA: 0x1721300
	public int get_selectedIndex() { }

	// RVA: 0x1722B78
	public void set_selectedIndex(int value) { }

	// RVA: 0x1722B7C
	public System.Collections.Generic.IEnumerable<System.Int32> get_selectedIndices() { }

	// RVA: 0x1720FFC
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedIds() { }

	// RVA: 0x1722B9C
	internal System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }

	// RVA: 0x1722C38
	internal ScrollView get_scrollView() { }

	// RVA: 0x1722C40
	internal ListViewDragger get_dragger() { }

	// RVA: 0x1722C48
	internal CollectionVirtualizationController get_virtualizationController() { }

	// RVA: 0x1722CD8
	public CollectionViewController get_viewController() { }

	// RVA: 0x1722CE0
	internal float ResolveItemHeight(float height) { }

	// RVA: 0x1722DEC
	public void set_showBorder(bool value) { }

	// RVA: 0x1722E84
	public bool get_reorderable() { }

	// RVA: 0x172301C
	public void set_reorderable(bool value) { }

	// RVA: 0x172339C
	public void set_horizontalScrollingEnabled(bool value) { }

	// RVA: 0x1723418
	public AlternatingRowBackground get_showAlternatingRowBackgrounds() { }

	// RVA: 0x1723420
	public void set_showAlternatingRowBackgrounds(AlternatingRowBackground value) { }

	// RVA: 0x1723438
	public CollectionVirtualizationMethod get_virtualizationMethod() { }

	// RVA: 0x1723440
	public void set_virtualizationMethod(CollectionVirtualizationMethod value) { }

	// RVA: 0x172348C
	public float get_fixedItemHeight() { }

	// RVA: 0x1723494
	public void set_fixedItemHeight(float value) { }

	// RVA: 0x17235A4
	internal float get_lastHeight() { }

	// RVA: 0x17235AC
	internal virtual void CreateVirtualizationController() { }

	// RVA: 0x1722C90
	internal CollectionVirtualizationController GetOrCreateVirtualizationController() { }

	// RVA: 0x30A2378
	internal void CreateVirtualizationController() { }

	// RVA: 0x1722774
	internal CollectionViewController GetOrCreateViewController() { }

	// RVA: -1
	protected abstract CollectionViewController CreateViewController() { }

	// RVA: 0x171FF38
	public virtual void SetViewController(CollectionViewController controller) { }

	// RVA: 0x1723600
	internal virtual ListViewDragger CreateDragger() { }

	// RVA: 0x1723668
	internal void InitializeDragAndDropController(bool enableReordering) { }

	// RVA: -1
	internal abstract ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x17237C4
	public void .ctor() { }

	// RVA: 0x1720574
	public void .ctor(IList itemsSource, float itemHeight) { }

	// RVA: 0x1723F18
	public VisualElement GetRootElementForId(int id) { }

	// RVA: 0x1724084
	internal virtual bool HasValidDataAndBindings() { }

	// RVA: 0x17240B0
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x1724100
	private void OnItemsSourceChanged() { }

	// RVA: 0x1720010
	public void RefreshItems() { }

	// RVA: 0x1723164
	public void Rebuild() { }

	// RVA: 0x17247D4
	internal void ScheduleRebuild() { }

	// RVA: 0x172411C
	private void RefreshSelection() { }

	// RVA: 0x1724D38
	internal virtual void PostRefresh() { }

	// RVA: 0x17215F4
	public void ScrollToItem(int index) { }

	// RVA: 0x1721464
	public void ScrollToItemById(int id) { }

	// RVA: 0x1724EDC
	private void OnScroll(Vector2 offset) { }

	// RVA: 0x1724E40
	private void Resize(Vector2 size) { }

	// RVA: 0x1724F64
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x17252B0
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x1725568
	private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) { }

	// RVA: 0x1726380
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x1726628
	internal virtual bool HandleItemNavigation(bool moveIn, bool altKey) { }

	// RVA: 0x1726630
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x17270A8
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x1727184
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x1727260
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x1726C88
	private void ProcessPointerDown(IPointerEvent evt) { }

	// RVA: 0x17266CC
	private void ProcessPointerUp(IPointerEvent evt) { }

	// RVA: 0x172733C
	private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey) { }

	// RVA: 0x1727B8C
	internal void DoRangeSelection(int rangeSelectionFinalIndex) { }

	// RVA: 0x1727A3C
	private void ProcessSingleClick(int clickedIndex) { }

	// RVA: 0x1725C20
	internal void SelectAll() { }

	// RVA: 0x1727B10
	public void AddToSelection(int index) { }

	// RVA: 0x1728098
	internal void AddToSelection(System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1728588
	private void AddToSelectionWithoutValidation(int index) { }

	// RVA: 0x1727AB4
	public void RemoveFromSelection(int index) { }

	// RVA: 0x172899C
	private void RemoveFromSelectionWithoutValidation(int index) { }

	// RVA: 0x17214F4
	public void SetSelection(int index) { }

	// RVA: 0x1728F08
	public void SetSelection(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1728F10
	public void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x172176C
	internal void SetSelectionInternal(System.Collections.Generic.IEnumerable<System.Int32> indices, bool sendNotification) { }

	// RVA: 0x1728F18
	private bool MatchesExistingSelection(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x17284A0
	private void NotifyOfSelectionChange() { }

	// RVA: 0x1722944
	public void ClearSelection() { }

	// RVA: 0x1727CFC
	private void ClearSelectionWithoutValidation() { }

	// RVA: 0x172073C
	internal override void OnViewDataReady() { }

	// RVA: 0x1729460
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x1729868
	private void OnSizeChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17299E4
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x1729B8C
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1729B90
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x1729BC8
	private static void .cctor() { }

	// RVA: 0x1729FC4
	private void <.ctor>b__159_0(float v) { }

	// RVA: 0x1724ADC
	private void <RefreshSelection>g__NotifyIfChanged|172_0(UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass172_0& ) { }

	// RVA: 0x1726134
	private void <Apply>g__HandleSelectionAndScroll|183_0(int index, UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass183_0& ) { }

}

// Namespace: UnityEngine.UIElements
public interface IBindable
{
	// Methods

	// RVA: -1
	public abstract IBinding get_binding() { }

	// RVA: -1
	public abstract void set_bindingPath(string value) { }

}

// Namespace: UnityEngine.UIElements
public interface IBinding
{
	// Methods

	// RVA: -1
	public abstract void PreUpdate() { }

	// RVA: -1
	public abstract void Update() { }

	// RVA: -1
	public abstract void Release() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x172B168
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_CenterXValue; // 0x80
	private UxmlFloatAttributeDescription m_CenterYValue; // 0x88
	private UxmlFloatAttributeDescription m_CenterZValue; // 0x90
	private UxmlFloatAttributeDescription m_ExtentsXValue; // 0x98
	private UxmlFloatAttributeDescription m_ExtentsYValue; // 0xA0
	private UxmlFloatAttributeDescription m_ExtentsZValue; // 0xA8

	// Methods

	// RVA: 0x172B1BC
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x172B3E8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class BoundsField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10
	public static readonly string centerFieldUssClassName; // 0x18
	public static readonly string extentsFieldUssClassName; // 0x20
	private Vector3Field m_CenterField; // 0x450
	private Vector3Field m_ExtentsField; // 0x458

	// Methods

	// RVA: 0x172A6F8
	public void .ctor() { }

	// RVA: 0x172A700
	public void .ctor(string label) { }

	// RVA: 0x172AC28
	public override void SetValueWithoutNotify(Bounds newValue) { }

	// RVA: 0x172AD28
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x172ADF8
	private static void .cctor() { }

	// RVA: 0x172AF80
	private void <.ctor>b__10_0(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3> e) { }

	// RVA: 0x172B074
	private void <.ctor>b__10_1(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3> e) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x172C08C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_PositionXValue; // 0x80
	private UxmlIntAttributeDescription m_PositionYValue; // 0x88
	private UxmlIntAttributeDescription m_PositionZValue; // 0x90
	private UxmlIntAttributeDescription m_SizeXValue; // 0x98
	private UxmlIntAttributeDescription m_SizeYValue; // 0xA0
	private UxmlIntAttributeDescription m_SizeZValue; // 0xA8

	// Methods

	// RVA: 0x172C0E0
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x172C308
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class BoundsIntField
{
	// Fields
	private Vector3IntField m_PositionField; // 0x450
	private Vector3IntField m_SizeField; // 0x458
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10
	public static readonly string positionUssClassName; // 0x18
	public static readonly string sizeUssClassName; // 0x20

	// Methods

	// RVA: 0x172B61C
	public void .ctor() { }

	// RVA: 0x172B624
	public void .ctor(string label) { }

	// RVA: 0x172BB4C
	public override void SetValueWithoutNotify(BoundsInt newValue) { }

	// RVA: 0x172BC4C
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x172BD1C
	private static void .cctor() { }

	// RVA: 0x172BEA4
	private void <.ctor>b__10_0(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3Int> e) { }

	// RVA: 0x172BF98
	private void <.ctor>b__10_1(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3Int> e) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x172C684
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Box
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x172C53C
	public void .ctor() { }

	// RVA: 0x172C60C
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x172CAC8
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x172CB1C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Button
{
	// Fields
	public static readonly string ussClassName; // 0x0
	private Clickable m_Clickable; // 0x4A0
	private static readonly string NonEmptyString; // 0x8

	// Methods

	// RVA: 0x172C6D8
	public Clickable get_clickable() { }

	// RVA: 0x172C6E0
	public void set_clickable(Clickable value) { }

	// RVA: 0x172C77C
	public void .ctor() { }

	// RVA: 0x172C784
	public void .ctor(Action clickEvent) { }

	// RVA: 0x172C924
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x172C968
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x172CA28
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x172CE24
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x172CE78
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ButtonStripField
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.Button> m_Buttons; // 0x440

	// Methods

	// RVA: 0x172CB94
	public void .ctor() { }

	// RVA: 0x172CC64
	public override void SetValueWithoutNotify(int newValue) { }

	// RVA: 0x172CD08
	private void RefreshButtonsState() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x172D8A4
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_XValue; // 0x80
	private UxmlFloatAttributeDescription m_YValue; // 0x88
	private UxmlFloatAttributeDescription m_WValue; // 0x90
	private UxmlFloatAttributeDescription m_HValue; // 0x98

	// Methods

	// RVA: 0x172D8F8
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x172DAB4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.RectField.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Rect,System.Single> <>9__0_0; // 0x8
	public static WriteDelegate <>9__0_1; // 0x10
	public static System.Func<UnityEngine.Rect,System.Single> <>9__0_2; // 0x18
	public static WriteDelegate <>9__0_3; // 0x20
	public static System.Func<UnityEngine.Rect,System.Single> <>9__0_4; // 0x28
	public static WriteDelegate <>9__0_5; // 0x30
	public static System.Func<UnityEngine.Rect,System.Single> <>9__0_6; // 0x38
	public static WriteDelegate <>9__0_7; // 0x40

	// Methods

	// RVA: 0x172DC50
	private static void .cctor() { }

	// RVA: 0x172DCBC
	public void .ctor() { }

	// RVA: 0x172DCC4
	internal float <DescribeFields>b__0_0(Rect r) { }

	// RVA: 0x172DCC8
	internal void <DescribeFields>b__0_1(Rect r, float v) { }

	// RVA: 0x172DCD0
	internal float <DescribeFields>b__0_2(Rect r) { }

	// RVA: 0x172DCD8
	internal void <DescribeFields>b__0_3(Rect r, float v) { }

	// RVA: 0x172DCE0
	internal float <DescribeFields>b__0_4(Rect r) { }

	// RVA: 0x172DCE8
	internal void <DescribeFields>b__0_5(Rect r, float v) { }

	// RVA: 0x172DCF0
	internal float <DescribeFields>b__0_6(Rect r) { }

	// RVA: 0x172DCF8
	internal void <DescribeFields>b__0_7(Rect r, float v) { }

}

// Namespace: UnityEngine.UIElements
public class RectField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x172CECC
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x172D630
	public void .ctor() { }

	// RVA: 0x172D638
	public void .ctor(string label) { }

	// RVA: 0x172D7A4
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x172E6D8
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_XValue; // 0x80
	private UxmlIntAttributeDescription m_YValue; // 0x88
	private UxmlIntAttributeDescription m_WValue; // 0x90
	private UxmlIntAttributeDescription m_HValue; // 0x98

	// Methods

	// RVA: 0x172E72C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x172E8E0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.RectIntField.<>c <>9; // 0x0
	public static System.Func<UnityEngine.RectInt,System.Int32> <>9__0_0; // 0x8
	public static WriteDelegate <>9__0_1; // 0x10
	public static System.Func<UnityEngine.RectInt,System.Int32> <>9__0_2; // 0x18
	public static WriteDelegate <>9__0_3; // 0x20
	public static System.Func<UnityEngine.RectInt,System.Int32> <>9__0_4; // 0x28
	public static WriteDelegate <>9__0_5; // 0x30
	public static System.Func<UnityEngine.RectInt,System.Int32> <>9__0_6; // 0x38
	public static WriteDelegate <>9__0_7; // 0x40

	// Methods

	// RVA: 0x172EA7C
	private static void .cctor() { }

	// RVA: 0x172EAE8
	public void .ctor() { }

	// RVA: 0x172EAF0
	internal int <DescribeFields>b__0_0(RectInt r) { }

	// RVA: 0x172EAF8
	internal void <DescribeFields>b__0_1(RectInt r, int v) { }

	// RVA: 0x172EB00
	internal int <DescribeFields>b__0_2(RectInt r) { }

	// RVA: 0x172EB08
	internal void <DescribeFields>b__0_3(RectInt r, int v) { }

	// RVA: 0x172EB10
	internal int <DescribeFields>b__0_4(RectInt r) { }

	// RVA: 0x172EB18
	internal void <DescribeFields>b__0_5(RectInt r, int v) { }

	// RVA: 0x172EB20
	internal int <DescribeFields>b__0_6(RectInt r) { }

	// RVA: 0x172EB28
	internal void <DescribeFields>b__0_7(RectInt r, int v) { }

}

// Namespace: UnityEngine.UIElements
public class RectIntField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x172DD00
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x172E464
	public void .ctor() { }

	// RVA: 0x172E46C
	public void .ctor(string label) { }

	// RVA: 0x172E5D8
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x172F1A0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_XValue; // 0x80
	private UxmlFloatAttributeDescription m_YValue; // 0x88

	// Methods

	// RVA: 0x172F1F4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x172F348
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Vector2Field.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector2,System.Single> <>9__0_0; // 0x8
	public static WriteDelegate <>9__0_1; // 0x10
	public static System.Func<UnityEngine.Vector2,System.Single> <>9__0_2; // 0x18
	public static WriteDelegate <>9__0_3; // 0x20

	// Methods

	// RVA: 0x172F44C
	private static void .cctor() { }

	// RVA: 0x172F4B8
	public void .ctor() { }

	// RVA: 0x172F4C0
	internal float <DescribeFields>b__0_0(Vector2 r) { }

	// RVA: 0x172F4C4
	internal void <DescribeFields>b__0_1(Vector2 r, float v) { }

	// RVA: 0x172F4CC
	internal float <DescribeFields>b__0_2(Vector2 r) { }

	// RVA: 0x172F4D4
	internal void <DescribeFields>b__0_3(Vector2 r, float v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector2Field
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x172EB30
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x172EF44
	public void .ctor() { }

	// RVA: 0x172EF4C
	public void .ctor(string label) { }

	// RVA: 0x172F0A0
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x172FBA0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_XValue; // 0x80
	private UxmlFloatAttributeDescription m_YValue; // 0x88
	private UxmlFloatAttributeDescription m_ZValue; // 0x90

	// Methods

	// RVA: 0x172FBF4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x172FD78
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Vector3Field.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector3,System.Single> <>9__0_0; // 0x8
	public static WriteDelegate <>9__0_1; // 0x10
	public static System.Func<UnityEngine.Vector3,System.Single> <>9__0_2; // 0x18
	public static WriteDelegate <>9__0_3; // 0x20
	public static System.Func<UnityEngine.Vector3,System.Single> <>9__0_4; // 0x28
	public static WriteDelegate <>9__0_5; // 0x30

	// Methods

	// RVA: 0x172FEC8
	private static void .cctor() { }

	// RVA: 0x172FF34
	public void .ctor() { }

	// RVA: 0x172FF3C
	internal float <DescribeFields>b__0_0(Vector3 r) { }

	// RVA: 0x172FF40
	internal void <DescribeFields>b__0_1(Vector3 r, float v) { }

	// RVA: 0x172FF48
	internal float <DescribeFields>b__0_2(Vector3 r) { }

	// RVA: 0x172FF50
	internal void <DescribeFields>b__0_3(Vector3 r, float v) { }

	// RVA: 0x172FF58
	internal float <DescribeFields>b__0_4(Vector3 r) { }

	// RVA: 0x172FF60
	internal void <DescribeFields>b__0_5(Vector3 r, float v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector3Field
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x172F4DC
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x172FA98
	public void .ctor() { }

	// RVA: 0x172AAD4
	public void .ctor(string label) { }

	// RVA: 0x172FAA0
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1730928
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_XValue; // 0x80
	private UxmlFloatAttributeDescription m_YValue; // 0x88
	private UxmlFloatAttributeDescription m_ZValue; // 0x90
	private UxmlFloatAttributeDescription m_WValue; // 0x98

	// Methods

	// RVA: 0x173097C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1730B38
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Vector4Field.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector4,System.Single> <>9__0_0; // 0x8
	public static WriteDelegate <>9__0_1; // 0x10
	public static System.Func<UnityEngine.Vector4,System.Single> <>9__0_2; // 0x18
	public static WriteDelegate <>9__0_3; // 0x20
	public static System.Func<UnityEngine.Vector4,System.Single> <>9__0_4; // 0x28
	public static WriteDelegate <>9__0_5; // 0x30
	public static System.Func<UnityEngine.Vector4,System.Single> <>9__0_6; // 0x38
	public static WriteDelegate <>9__0_7; // 0x40

	// Methods

	// RVA: 0x1730CD4
	private static void .cctor() { }

	// RVA: 0x1730D40
	public void .ctor() { }

	// RVA: 0x1730D48
	internal float <DescribeFields>b__0_0(Vector4 r) { }

	// RVA: 0x1730D4C
	internal void <DescribeFields>b__0_1(Vector4 r, float v) { }

	// RVA: 0x1730D54
	internal float <DescribeFields>b__0_2(Vector4 r) { }

	// RVA: 0x1730D5C
	internal void <DescribeFields>b__0_3(Vector4 r, float v) { }

	// RVA: 0x1730D64
	internal float <DescribeFields>b__0_4(Vector4 r) { }

	// RVA: 0x1730D6C
	internal void <DescribeFields>b__0_5(Vector4 r, float v) { }

	// RVA: 0x1730D74
	internal float <DescribeFields>b__0_6(Vector4 r) { }

	// RVA: 0x1730D7C
	internal void <DescribeFields>b__0_7(Vector4 r, float v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector4Field
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x172FF68
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x17306CC
	public void .ctor() { }

	// RVA: 0x17306D4
	public void .ctor(string label) { }

	// RVA: 0x1730828
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17313F4
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_XValue; // 0x80
	private UxmlIntAttributeDescription m_YValue; // 0x88

	// Methods

	// RVA: 0x1731448
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1731594
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Vector2IntField.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector2Int,System.Int32> <>9__0_0; // 0x8
	public static WriteDelegate <>9__0_1; // 0x10
	public static System.Func<UnityEngine.Vector2Int,System.Int32> <>9__0_2; // 0x18
	public static WriteDelegate <>9__0_3; // 0x20

	// Methods

	// RVA: 0x1731698
	private static void .cctor() { }

	// RVA: 0x1731704
	public void .ctor() { }

	// RVA: 0x173170C
	internal int <DescribeFields>b__0_0(Vector2Int r) { }

	// RVA: 0x1731714
	internal void <DescribeFields>b__0_1(Vector2Int r, int v) { }

	// RVA: 0x173171C
	internal int <DescribeFields>b__0_2(Vector2Int r) { }

	// RVA: 0x1731724
	internal void <DescribeFields>b__0_3(Vector2Int r, int v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector2IntField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x1730D84
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x1731198
	public void .ctor() { }

	// RVA: 0x17311A0
	public void .ctor(string label) { }

	// RVA: 0x17312F4
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1731DF0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_XValue; // 0x80
	private UxmlIntAttributeDescription m_YValue; // 0x88
	private UxmlIntAttributeDescription m_ZValue; // 0x90

	// Methods

	// RVA: 0x1731E44
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1731FC0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Vector3IntField.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector3Int,System.Int32> <>9__0_0; // 0x8
	public static WriteDelegate <>9__0_1; // 0x10
	public static System.Func<UnityEngine.Vector3Int,System.Int32> <>9__0_2; // 0x18
	public static WriteDelegate <>9__0_3; // 0x20
	public static System.Func<UnityEngine.Vector3Int,System.Int32> <>9__0_4; // 0x28
	public static WriteDelegate <>9__0_5; // 0x30

	// Methods

	// RVA: 0x1732110
	private static void .cctor() { }

	// RVA: 0x173217C
	public void .ctor() { }

	// RVA: 0x1732184
	internal int <DescribeFields>b__0_0(Vector3Int r) { }

	// RVA: 0x173218C
	internal void <DescribeFields>b__0_1(Vector3Int r, int v) { }

	// RVA: 0x1732194
	internal int <DescribeFields>b__0_2(Vector3Int r) { }

	// RVA: 0x173219C
	internal void <DescribeFields>b__0_3(Vector3Int r, int v) { }

	// RVA: 0x17321A4
	internal int <DescribeFields>b__0_4(Vector3Int r) { }

	// RVA: 0x17321AC
	internal void <DescribeFields>b__0_5(Vector3Int r, int v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector3IntField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x173172C
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x1731CE8
	public void .ctor() { }

	// RVA: 0x172B9F8
	public void .ctor(string label) { }

	// RVA: 0x1731CF0
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1732934
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x1732988
	public void .ctor() { }

}

// Namespace: 
private class DoubleInput
{
	// Methods

	// RVA: 0x17329DC
	private DoubleField get_parentDoubleField() { }

	// RVA: 0x1732670
	internal void .ctor() { }

	// RVA: 0x1732A60
	protected override string get_allowedCharacters() { }

	// RVA: 0x1732ADC
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Double startValue) { }

	// RVA: 0x1732D18
	protected override string ValueToString(Double v) { }

	// RVA: 0x1732D70
	protected override Double StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class DoubleField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x17321B4
	private DoubleInput get_doubleInput() { }

	// RVA: 0x173226C
	protected override string ValueToString(Double v) { }

	// RVA: 0x173232C
	protected override Double StringToValue(string str) { }

	// RVA: 0x1732468
	public void .ctor() { }

	// RVA: 0x1732474
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x173270C
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x1732738
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Double startValue) { }

	// RVA: 0x1732834
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1732F1C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_Index; // 0x80
	private UxmlStringAttributeDescription m_Choices; // 0x88

	// Methods

	// RVA: 0x1732F70
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17330FC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DropdownField
{
	// Methods

	// RVA: 0x1732E20
	public void .ctor() { }

	// RVA: 0x1732E9C
	public void .ctor(string label) { }

}

// Namespace: UnityEngine.UIElements
internal static class EnumFieldHelpers
{
	// Fields
	internal static readonly UnityEngine.UIElements.UxmlTypeAttributeDescription<System.Enum> type; // 0x0
	internal static readonly UxmlStringAttributeDescription value; // 0x8
	internal static readonly UxmlBoolAttributeDescription includeObsoleteValues; // 0x10

	// Methods

	// RVA: 0x173324C
	internal static bool ExtractValue(IUxmlAttributes bag, CreationContext cc, Type resEnumType, Enum resEnumValue, bool resIncludeObsoleteValues) { }

	// RVA: 0x1733618
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1734ED0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UnityEngine.UIElements.UxmlTypeAttributeDescription<System.Enum> m_Type; // 0x80
	private UxmlStringAttributeDescription m_Value; // 0x88
	private UxmlBoolAttributeDescription m_IncludeObsoleteValues; // 0x90

	// Methods

	// RVA: 0x1734F24
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1735200
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.EnumField.<>c <>9; // 0x0
	public static UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.MouseDownEvent> <>9__22_0; // 0x8

	// Methods

	// RVA: 0x17352C0
	private static void .cctor() { }

	// RVA: 0x173532C
	public void .ctor() { }

	// RVA: 0x1735334
	internal void <.ctor>b__22_0(MouseDownEvent e) { }

}

// Namespace: UnityEngine.UIElements
public class EnumField
{
	// Fields
	private Type m_EnumType; // 0x440
	private bool m_IncludeObsoleteValues; // 0x448
	private TextElement m_TextElement; // 0x450
	private VisualElement m_ArrowElement; // 0x458
	private EnumData m_EnumData; // 0x460
	internal System.Func<UnityEngine.UIElements.IGenericMenu> createMenuCallback; // 0x4A0
	public static readonly string ussClassName; // 0x0
	public static readonly string textUssClassName; // 0x8
	public static readonly string arrowUssClassName; // 0x10
	public static readonly string labelUssClassName; // 0x18
	public static readonly string inputUssClassName; // 0x20

	// Methods

	// RVA: 0x17337DC
	internal bool get_includeObsoleteValues() { }

	// RVA: 0x17337E4
	private void Initialize(Enum defaultValue) { }

	// RVA: 0x17339A4
	public void .ctor() { }

	// RVA: 0x17339B0
	public void .ctor(string label, Enum defaultValue) { }

	// RVA: 0x173399C
	public void Init(Enum defaultValue) { }

	// RVA: 0x1733D48
	public void Init(Enum defaultValue, bool includeObsoleteValues) { }

	// RVA: 0x1733EF8
	internal void PopulateDataFromType(Type enumType) { }

	// RVA: 0x1734090
	public override void SetValueWithoutNotify(Enum newValue) { }

	// RVA: 0x1733FB4
	private void UpdateValueLabel(Enum value) { }

	// RVA: 0x1734190
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x17341EC
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x1734288
	private bool ContainsPointer(int pointerId) { }

	// RVA: 0x30A27C0
	private void ProcessPointerDown(UnityEngine.UIElements.PointerEventBase<T> evt) { }

	// RVA: 0x1734324
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x1734354
	private void ShowMenu() { }

	// RVA: 0x1734A50
	private void ChangeValueFromMenu(object menuItem) { }

	// RVA: 0x1734AE8
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x1734CB0
	private static void .cctor() { }

	// RVA: 0x1734E38
	private void <ShowMenu>b__33_0(object contentView) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1735B14
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x1735B68
	public void .ctor() { }

}

// Namespace: 
private class FloatInput
{
	// Methods

	// RVA: 0x1735BBC
	private FloatField get_parentFloatField() { }

	// RVA: 0x1735850
	internal void .ctor() { }

	// RVA: 0x1735C40
	protected override string get_allowedCharacters() { }

	// RVA: 0x1735CBC
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x1735F28
	protected override string ValueToString(float v) { }

	// RVA: 0x1735F80
	protected override float StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class FloatField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x1735394
	private FloatInput get_floatInput() { }

	// RVA: 0x173544C
	protected override string ValueToString(float v) { }

	// RVA: 0x173550C
	protected override float StringToValue(string str) { }

	// RVA: 0x1735648
	public void .ctor() { }

	// RVA: 0x1735654
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x17358EC
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x1735918
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x1735A14
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1736EEC
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x78
	private UxmlBoolAttributeDescription m_Value; // 0x80

	// Methods

	// RVA: 0x1736F40
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x173707C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Foldout
{
	// Fields
	private Toggle m_Toggle; // 0x3D8
	private VisualElement m_Container; // 0x3E0
	private bool m_Value; // 0x3E8
	public static readonly string ussClassName; // 0x0
	public static readonly string toggleUssClassName; // 0x8
	public static readonly string contentUssClassName; // 0x10
	public static readonly string inputUssClassName; // 0x18
	public static readonly string checkmarkUssClassName; // 0x20
	public static readonly string textUssClassName; // 0x28
	internal static readonly string toggleInspectorUssClassName; // 0x30
	internal static readonly string ussFoldoutDepthClassName; // 0x38
	internal static readonly int ussFoldoutMaxDepth; // 0x40
	private KeyboardNavigationManipulator m_NavigationManipulator; // 0x3F0

	// Methods

	// RVA: 0x1736030
	internal Toggle get_toggle() { }

	// RVA: 0x1736038
	public override VisualElement get_contentContainer() { }

	// RVA: 0x1736040
	public void set_text(string value) { }

	// RVA: 0x17361A0
	public bool get_value() { }

	// RVA: 0x17361A8
	public void set_value(bool value) { }

	// RVA: 0x1736370
	public void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x17364C8
	internal override void OnViewDataReady() { }

	// RVA: 0x1736514
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x1736554
	private bool Apply(KeyboardNavigationOperation op) { }

	// RVA: 0x1736630
	public void .ctor() { }

	// RVA: 0x1736A48
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x1736C34
	private static void .cctor() { }

	// RVA: 0x1736E98
	private void <.ctor>b__29_0(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

}

// Namespace: UnityEngine.UIElements
internal interface IGenericMenu
{
	// Methods

	// RVA: -1
	public abstract void AddItem(string itemName, bool isChecked, Action action) { }

	// RVA: -1
	public abstract void AddItem(string itemName, bool isChecked, System.Action<System.Object> action, object data) { }

	// RVA: -1
	public abstract void DropDown(Rect position, VisualElement targetElement, bool anchored) { }

}

// Namespace: 
internal class MenuItem
{
	// Fields
	public string name; // 0x10
	public VisualElement element; // 0x18
	public Action action; // 0x20
	public System.Action<System.Object> actionUserData; // 0x28

	// Methods

	// RVA: 0x1738BA0
	public void .ctor() { }

}

// Namespace: 
private struct <>c__DisplayClass39_0
{
	// Fields
	public GenericDropdownMenu <>4__this; // 0x10
	public int selectedIndex; // 0x18
}

// Namespace: UnityEngine.UIElements
public class GenericDropdownMenu
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string itemUssClassName; // 0x8
	public static readonly string labelUssClassName; // 0x10
	public static readonly string containerInnerUssClassName; // 0x18
	public static readonly string containerOuterUssClassName; // 0x20
	public static readonly string checkmarkUssClassName; // 0x28
	public static readonly string separatorUssClassName; // 0x30
	private System.Collections.Generic.List<UnityEngine.UIElements.GenericDropdownMenu.MenuItem> m_Items; // 0x10
	private VisualElement m_MenuContainer; // 0x18
	private VisualElement m_OuterContainer; // 0x20
	private ScrollView m_ScrollView; // 0x28
	private VisualElement m_PanelRootVisualContainer; // 0x30
	private VisualElement m_TargetElement; // 0x38
	private Rect m_DesiredRect; // 0x40
	private KeyboardNavigationManipulator m_NavigationManipulator; // 0x50
	private bool <isSingleSelectionDropdown>k__BackingField; // 0x58
	private bool <closeOnParentResize>k__BackingField; // 0x59
	private Vector2 m_MousePosition; // 0x5C

	// Methods

	// RVA: 0x17371B8
	internal bool get_isSingleSelectionDropdown() { }

	// RVA: 0x17371C0
	internal void set_isSingleSelectionDropdown(bool value) { }

	// RVA: 0x17371C8
	internal bool get_closeOnParentResize() { }

	// RVA: 0x17371D0
	internal void set_closeOnParentResize(bool value) { }

	// RVA: 0x17371D8
	public VisualElement get_contentContainer() { }

	// RVA: 0x173471C
	public void .ctor() { }

	// RVA: 0x1737200
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x173762C
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x17379C4
	private void Hide(bool giveFocusBack) { }

	// RVA: 0x1737A68
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x1737AB4
	private bool Apply(KeyboardNavigationOperation op) { }

	// RVA: 0x1737EC0
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x1738178
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x17382E4
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x1738450
	private void OnFocusOut(FocusOutEvent evt) { }

	// RVA: 0x17385D8
	private void OnParentResized(GeometryChangedEvent evt) { }

	// RVA: 0x173802C
	private void UpdateSelection(VisualElement target) { }

	// RVA: 0x17385EC
	private void ChangeSelectedIndex(int newIndex, int previousIndex) { }

	// RVA: 0x1737C78
	private int GetSelectedIndex() { }

	// RVA: 0x1738740
	public void AddItem(string itemName, bool isChecked, Action action) { }

	// RVA: 0x1738AA0
	public void AddItem(string itemName, bool isChecked, System.Action<System.Object> action, object data) { }

	// RVA: 0x1738ADC
	public void AddSeparator(string path) { }

	// RVA: 0x1738780
	private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data) { }

	// RVA: 0x1738BA8
	public void DropDown(Rect position, VisualElement targetElement, bool anchored) { }

	// RVA: 0x1739A88
	private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x1739AE8
	private void OnContainerGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17394F4
	private void EnsureVisibilityInParent() { }

	// RVA: 0x1739AEC
	private static void .cctor() { }

	// RVA: 0x1737DFC
	private void <Apply>g__UpdateSelectionDown|39_0(int newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass39_0& ) { }

	// RVA: 0x1737D34
	private void <Apply>g__UpdateSelectionUp|39_1(int newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass39_0& ) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x173A014
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x78

	// Methods

	// RVA: 0x173A068
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x173A164
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class GroupBox
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	private Label m_TitleLabel; // 0x3D8

	// Methods

	// RVA: 0x1739CFC
	public void set_text(string value) { }

	// RVA: 0x1739E40
	public void .ctor() { }

	// RVA: 0x1739EC8
	public void .ctor(string text) { }

	// RVA: 0x1739F54
	private void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x1739F58
	private void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x1739F5C
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x173AD80
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x173ADD4
	public void .ctor() { }

}

// Namespace: 
private class Hash128Input
{
	// Methods

	// RVA: 0x173A3C4
	internal void .ctor() { }

	// RVA: 0x173AE28
	protected string get_allowedCharacters() { }

	// RVA: 0x173AE6C
	internal override bool AcceptCharacter(Char c) { }

	// RVA: 0x173AF24
	protected override Hash128 StringToValue(string str) { }

	// RVA: 0x173A988
	internal static Hash128 Parse(string str) { }

}

// Namespace: UnityEngine.UIElements
public class Hash128Field
{
	// Fields
	internal bool m_UpdateTextFromValue; // 0x460
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x173A208
	public void .ctor() { }

	// RVA: 0x173A214
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x173A51C
	public override Hash128 get_value() { }

	// RVA: 0x173A584
	public override void set_value(Hash128 value) { }

	// RVA: 0x173A660
	internal override void UpdateValueFromText() { }

	// RVA: 0x173A75C
	internal override void UpdateTextFromValue() { }

	// RVA: 0x173A7FC
	public override void SetValueWithoutNotify(Hash128 newValue) { }

	// RVA: 0x173A8D8
	protected override string ValueToString(Hash128 value) { }

	// RVA: 0x173A900
	protected override Hash128 StringToValue(string str) { }

	// RVA: 0x173AA10
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x173AC80
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public enum HelpBoxMessageType
{
	// Fields
	public int value__; // 0x10
	public const HelpBoxMessageType None = 0;
	public const HelpBoxMessageType Info = 1;
	public const HelpBoxMessageType Warning = 2;
	public const HelpBoxMessageType Error = 3;
}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17B5260
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x70
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.HelpBoxMessageType> m_MessageType; // 0x78

	// Methods

	// RVA: 0x17B52B4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17B53EC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class HelpBox
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string iconUssClassName; // 0x10
	public static readonly string iconInfoUssClassName; // 0x18
	public static readonly string iconwarningUssClassName; // 0x20
	public static readonly string iconErrorUssClassName; // 0x28
	private HelpBoxMessageType m_HelpBoxMessageType; // 0x3C8
	private VisualElement m_Icon; // 0x3D0
	private string m_IconClass; // 0x3D8
	private Label m_Label; // 0x3E0

	// Methods

	// RVA: 0x173AFAC
	public void set_text(string value) { }

	// RVA: 0x173AFD4
	public void set_messageType(HelpBoxMessageType value) { }

	// RVA: 0x173B17C
	public void .ctor() { }

	// RVA: 0x173B1DC
	public void .ctor(string text, HelpBoxMessageType messageType) { }

	// RVA: 0x173B348
	private string GetIconClass(HelpBoxMessageType messageType) { }

	// RVA: 0x173AFEC
	private void UpdateIcon(HelpBoxMessageType messageType) { }

	// RVA: 0x173B430
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17B70B8
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17B710C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Image
{
	// Fields
	private ScaleMode m_ScaleMode; // 0x3C8
	private Texture m_Image; // 0x3D0
	private Sprite m_Sprite; // 0x3D8
	private VectorImage m_VectorImage; // 0x3E0
	private Rect m_UV; // 0x3E8
	private Color m_TintColor; // 0x3F8
	internal bool m_ImageIsInline; // 0x408
	private bool m_ScaleModeIsInline; // 0x409
	private bool m_TintColorIsInline; // 0x40A
	public static readonly string ussClassName; // 0x0
	private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> s_ImageProperty; // 0x8
	private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> s_SpriteProperty; // 0x10
	private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> s_VectorImageProperty; // 0x18
	private static UnityEngine.UIElements.CustomStyleProperty<System.String> s_ScaleModeProperty; // 0x20
	private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_TintColorProperty; // 0x28

	// Methods

	// RVA: 0x17B5538
	public Texture get_image() { }

	// RVA: 0x17B5540
	public void set_image(Texture value) { }

	// RVA: 0x17B5658
	public Sprite get_sprite() { }

	// RVA: 0x17B5660
	public void set_sprite(Sprite value) { }

	// RVA: 0x17B5778
	public VectorImage get_vectorImage() { }

	// RVA: 0x17B5780
	public void set_vectorImage(VectorImage value) { }

	// RVA: 0x17B5898
	public Rect get_sourceRect() { }

	// RVA: 0x17B5A90
	public Rect get_uv() { }

	// RVA: 0x17B5AA4
	public void set_uv(Rect value) { }

	// RVA: 0x17B5AE0
	public ScaleMode get_scaleMode() { }

	// RVA: 0x17B5AE8
	public Color get_tintColor() { }

	// RVA: 0x17B5AFC
	public void .ctor() { }

	// RVA: 0x17B5CD4
	private Vector2 GetTextureDisplaySize(Texture texture) { }

	// RVA: 0x17B5DD4
	private Vector2 GetTextureDisplaySize(Sprite sprite) { }

	// RVA: 0x17B5F24
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x17B61D4
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x17B67DC
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x17B6814
	private void ReadCustomProperties(ICustomStyle customStyleProvider) { }

	// RVA: 0x315B3A8
	private void SetProperty(T0 src, T0 dst, T1 alt0, T2 alt1) { }

	// RVA: 0x17B6D9C
	private void ClearProperty() { }

	// RVA: 0x17B6DE8
	private void SetScaleMode(ScaleMode mode) { }

	// RVA: 0x17B6E08
	private void SetTintColor(Color color) { }

	// RVA: 0x17B589C
	private Rect GetSourceRect() { }

	// RVA: 0x17B6E78
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface INotifyValueChanged<T0>
{
	// Methods

	// RVA: -1
	public abstract T get_value() { }

	// RVA: -1
	public abstract void set_value(T value) { }

	// RVA: -1
	public abstract void SetValueWithoutNotify(T newValue) { }

}

// Namespace: UnityEngine.UIElements
public static class INotifyValueChangedExtensions
{
	// Methods

	// RVA: 0x30A3C14
	public static bool RegisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback) { }

	// RVA: 0x30A3C14
	public static bool UnregisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback) { }

}

// Namespace: UnityEngine.UIElements
internal interface IEditableElement
{
	// Methods

	// RVA: -1
	internal abstract Action get_editingStarted() { }

	// RVA: -1
	internal abstract Action get_editingEnded() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Label; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: -1
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A52D0
	internal static System.Collections.Generic.List<System.String> ParseChoiceList(string choicesFromBag) { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseField<T0>
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0
	public static readonly string noLabelVariantUssClassName; // 0x0
	public static readonly string labelDraggerVariantUssClassName; // 0x0
	public static readonly string mixedValueLabelUssClassName; // 0x0
	public static readonly string alignedFieldUssClassName; // 0x0
	private static readonly string inspectorFieldUssClassName; // 0x0
	protected internal static readonly string mixedValueString; // 0x0
	protected internal static readonly PropertyName serializedPropertyCopyName; // 0x0
	private static UnityEngine.UIElements.CustomStyleProperty<System.Single> s_LabelWidthRatioProperty; // 0x0
	private static UnityEngine.UIElements.CustomStyleProperty<System.Single> s_LabelExtraPaddingProperty; // 0x0
	private static UnityEngine.UIElements.CustomStyleProperty<System.Single> s_LabelBaseMinWidthProperty; // 0x0
	private static UnityEngine.UIElements.CustomStyleProperty<System.Single> s_LabelExtraContextWidthProperty; // 0x0
	private float m_LabelWidthRatio; // 0x0
	private float m_LabelExtraPadding; // 0x0
	private float m_LabelBaseMinWidth; // 0x0
	private float m_LabelExtraContextWidth; // 0x0
	private VisualElement m_VisualInput; // 0x0
	private TValueType m_Value; // 0x0
	private System.Func<TValueType,TValueType> onValidateValue; // 0x0
	private Label <labelElement>k__BackingField; // 0x0
	private bool m_ShowMixedValue; // 0x0
	private Label m_MixedValueLabel; // 0x0
	private bool m_SkipValidation; // 0x0
	private VisualElement m_CachedContextWidthElement; // 0x0
	private VisualElement m_CachedInspectorElement; // 0x0
	private Action <UnityEngine.UIElements.IEditableElement.editingStarted>k__BackingField; // 0x0
	private Action <UnityEngine.UIElements.IEditableElement.editingEnded>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A17DC
	internal VisualElement get_visualInput() { }

	// RVA: 0x30A27C0
	internal void set_visualInput(VisualElement value) { }

	// RVA: 0x315B3A8
	protected TValueType get_rawValue() { }

	// RVA: 0x315B3A8
	protected void set_rawValue(TValueType value) { }

	// RVA: 0x30A27C0
	internal void add_onValidateValue(System.Func<TValueType,TValueType> value) { }

	// RVA: 0x30A27C0
	internal void remove_onValidateValue(System.Func<TValueType,TValueType> value) { }

	// RVA: 0x315B3A8
	public virtual TValueType get_value() { }

	// RVA: 0x315B3A8
	public virtual void set_value(TValueType value) { }

	// RVA: 0x30A17DC
	public Label get_labelElement() { }

	// RVA: 0x30A27C0
	private void set_labelElement(Label value) { }

	// RVA: 0x30A17DC
	public string get_label() { }

	// RVA: 0x30A27C0
	public void set_label(string value) { }

	// RVA: 0x30A1224
	public bool get_showMixedValue() { }

	// RVA: 0x30A2404
	public void set_showMixedValue(bool value) { }

	// RVA: 0x30A17DC
	protected Label get_mixedValueLabel() { }

	// RVA: 0x30A17DC
	private Action UnityEngine.UIElements.IEditableElement.get_editingStarted() { }

	// RVA: 0x30A17DC
	private Action UnityEngine.UIElements.IEditableElement.get_editingEnded() { }

	// RVA: 0x30A27C0
	internal void .ctor(string label) { }

	// RVA: 0x30A2A20
	protected void .ctor(string label, VisualElement visualInput) { }

	// RVA: 0x315B3A8
	internal virtual bool EqualsCurrentValue(TValueType value) { }

	// RVA: 0x30A27C0
	private void OnAttachToPanel(AttachToPanelEvent e) { }

	// RVA: 0x30A27C0
	private void OnDetachFromPanel(DetachFromPanelEvent e) { }

	// RVA: 0x30A2378
	internal virtual void RegisterEditingCallbacks() { }

	// RVA: 0x30A2378
	internal virtual void UnregisterEditingCallbacks() { }

	// RVA: 0x30A27C0
	internal void StartEditing(EventBase e) { }

	// RVA: 0x30A27C0
	internal void EndEditing(EventBase e) { }

	// RVA: 0x30A27C0
	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	// RVA: 0x30A27C0
	private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x30A2378
	private void AlignLabel() { }

	// RVA: 0x315B3A8
	internal TValueType ValidatedValue(TValueType value) { }

	// RVA: 0x30A2378
	protected virtual void UpdateMixedValueContent() { }

	// RVA: 0x315B3A8
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30A2378
	internal override void OnViewDataReady() { }

	// RVA: -1
	internal override Rect GetTooltipRect() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public class BaseFieldTraits<T0, T1>
{
	// Fields
	private TValueUxmlAttributeType m_Value; // 0x0

	// Methods

	// RVA: -1
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class KeyboardTextEditorEventHandler
{
	// Fields
	private readonly Event m_ImguiEvent; // 0x20
	internal bool m_Changed; // 0x28

	// Methods

	// RVA: 0x17B7114
	public void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x17B72AC
	public override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x17B75E8
	private void OnFocus(FocusEvent _) { }

	// RVA: 0x17B7710
	private void OnBlur(BlurEvent _) { }

	// RVA: 0x17B7788
	private void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x17B8500
	private void UpdateLabel() { }

	// RVA: 0x17B7F2C
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	// RVA: 0x17B8174
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	// RVA: 0x30A27C0
	private void OnNavigationEvent(UnityEngine.UIElements.NavigationEventBase<TEvent> evt) { }

}

// Namespace: UnityEngine.UIElements
internal class TextEditorEventHandler
{
	// Fields
	protected TextElement textElement; // 0x10
	protected TextEditingUtilities editingUtilities; // 0x18

	// Methods

	// RVA: 0x17B725C
	protected void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x17B75E4
	public virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17B96E0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private static readonly UxmlStringAttributeDescription k_Value; // 0x0
	private UxmlBoolAttributeDescription m_Multiline; // 0xC8

	// Methods

	// RVA: 0x17B9734
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17B98DC
	public void .ctor() { }

	// RVA: 0x17B9994
	private static void .cctor() { }

}

// Namespace: 
private class TextInput
{
	// Methods

	// RVA: 0x17B8968
	public void set_multiline(bool value) { }

	// RVA: 0x17B9AB0
	public override void set_isPasswordField(bool value) { }

	// RVA: 0x17B9B2C
	protected override string StringToValue(string str) { }

	// RVA: 0x17B8E58
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class TextField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x17B87EC
	private TextInput get_textInput() { }

	// RVA: 0x17B88A4
	public void set_multiline(bool value) { }

	// RVA: 0x17B8BC4
	public void .ctor() { }

	// RVA: 0x17B8BDC
	public void .ctor(string label) { }

	// RVA: 0x17B8BF0
	public void .ctor(string label, int maxLength, bool multiline, bool isPasswordField, Char maskChar) { }

	// RVA: 0x17B8EFC
	public override string get_value() { }

	// RVA: 0x17B8F64
	public override void set_value(string value) { }

	// RVA: 0x17B909C
	public override void SetValueWithoutNotify(string newValue) { }

	// RVA: 0x17B924C
	internal override void UpdateTextFromValue() { }

	// RVA: 0x17B92C8
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x17B9500
	internal override void OnViewDataReady() { }

	// RVA: 0x17B95D0
	protected override string ValueToString(string value) { }

	// RVA: 0x17B95D8
	protected override string StringToValue(string str) { }

	// RVA: 0x17B95E0
	private static void .cctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_MaxLength; // 0x0
	private UxmlBoolAttributeDescription m_Password; // 0x0
	private UxmlStringAttributeDescription m_MaskCharacter; // 0x0
	private UxmlBoolAttributeDescription m_IsReadOnly; // 0x0
	private UxmlBoolAttributeDescription m_IsDelayed; // 0x0
	private UxmlBoolAttributeDescription m_HideMobileInput; // 0x0
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.TouchScreenKeyboardType> m_KeyboardType; // 0x0
	private UxmlBoolAttributeDescription m_AutoCorrection; // 0x0

	// Methods

	// RVA: -1
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
protected internal abstract class TextInputBase
{
	// Fields
	private TextElement <textElement>k__BackingField; // 0x0
	internal ScrollView scrollView; // 0x0
	internal VisualElement multilineContainer; // 0x0
	public static readonly string innerComponentsModifierName; // 0x0
	public static readonly string innerTextElementUssClassName; // 0x0
	internal static readonly string innerTextElementWithScrollViewUssClassName; // 0x0
	public static readonly string horizontalVariantInnerTextElementUssClassName; // 0x0
	public static readonly string verticalVariantInnerTextElementUssClassName; // 0x0
	public static readonly string verticalHorizontalVariantInnerTextElementUssClassName; // 0x0
	public static readonly string innerScrollviewUssClassName; // 0x0
	public static readonly string innerViewportUssClassName; // 0x0
	public static readonly string innerContentContainerUssClassName; // 0x0
	private bool <isDragging>k__BackingField; // 0x0
	internal Vector2 scrollOffset; // 0x0
	private bool m_ScrollViewWasClamped; // 0x0
	private Vector2 lastCursorPos; // 0x0
	private ScrollerVisibility m_VerticalScrollerVisibility; // 0x0

	// Methods

	// RVA: 0x30A17DC
	internal TextElement get_textElement() { }

	// RVA: 0x30A27C0
	private void set_textElement(TextElement value) { }

	// RVA: 0x30A17DC
	public ITextSelection get_textSelection() { }

	// RVA: 0x30A17DC
	public ITextEdition get_textEdition() { }

	// RVA: 0x30A2378
	public void SelectAll() { }

	// RVA: 0x30A2378
	internal void SelectNone() { }

	// RVA: 0x30A17DC
	internal string get_originalText() { }

	// RVA: 0x315B3A8
	protected virtual TValueType StringToValue(string str) { }

	// RVA: 0x30A2378
	internal void UpdateValueFromText() { }

	// RVA: 0x30A2378
	internal void UpdateTextFromValue() { }

	// RVA: 0x30A2378
	internal void MoveFocusToCompositeRoot() { }

	// RVA: 0x30A1224
	public bool get_isReadOnly() { }

	// RVA: 0x30A24F0
	public void set_maxLength(int value) { }

	// RVA: -1
	public void set_maskChar(Char value) { }

	// RVA: 0x30A1224
	public virtual bool get_isPasswordField() { }

	// RVA: 0x30A2404
	public virtual void set_isPasswordField(bool value) { }

	// RVA: 0x30A2404
	internal void set_isDragging(bool value) { }

	// RVA: 0x30A17DC
	public string get_text() { }

	// RVA: 0x30A27C0
	public void set_text(string value) { }

	// RVA: 0x30A2378
	internal void .ctor() { }

	// RVA: 0x30A27C0
	private void MakeSureScrollViewDoesNotLeakEvents(UnityEngine.UIElements.ChangeEvent<System.Single> evt) { }

	// RVA: 0x30A2378
	internal void SetSingleLine() { }

	// RVA: 0x30A2378
	internal void SetMultiline() { }

	// RVA: 0x30A27C0
	private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e) { }

	// RVA: 0x30A27C0
	private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e) { }

	// RVA: 0x30A27C0
	internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x315B3A8
	internal virtual bool AcceptCharacter(Char c) { }

	// RVA: 0x30A2404
	internal void UpdateScrollOffset(bool isBackspace) { }

	// RVA: -1
	internal void UpdateScrollOffset(bool isBackspace, bool widthChanged) { }

	// RVA: 0x315B3A8
	private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged) { }

	// RVA: 0x30A2378
	internal void SetScrollViewMode() { }

	// RVA: 0x30A2378
	private void SetMultilineContainerStyle() { }

	// RVA: 0x30A2378
	private void RemoveSingleLineComponents() { }

	// RVA: 0x30A2378
	private void RemoveMultilineComponents() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class TextInputBaseField<T0>
{
	// Fields
	private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_SelectionColorProperty; // 0x0
	private static UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> s_CursorColorProperty; // 0x0
	private int m_VisualInputTabIndex; // 0x0
	private TextInputBase m_TextInputBase; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0
	internal static readonly string multilineContainerClassName; // 0x0
	public static readonly string singleLineInputUssClassName; // 0x0
	public static readonly string multilineInputUssClassName; // 0x0
	internal static readonly string multilineInputWithScrollViewUssClassName; // 0x0
	public static readonly string textInputUssName; // 0x0
	private System.Action<System.Boolean> onIsReadOnlyChanged; // 0x0

	// Methods

	// RVA: 0x30A17DC
	protected internal TextInputBase get_textInputBase() { }

	// RVA: 0x30A17DC
	public string get_text() { }

	// RVA: 0x30A27C0
	protected internal void set_text(string value) { }

	// RVA: 0x30A27C0
	protected void add_onIsReadOnlyChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x30A27C0
	protected void remove_onIsReadOnlyChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x30A1224
	public bool get_isReadOnly() { }

	// RVA: 0x30A2404
	public void set_isReadOnly(bool value) { }

	// RVA: 0x30A2404
	public void set_isPasswordField(bool value) { }

	// RVA: 0x30A2404
	public void set_autoCorrection(bool value) { }

	// RVA: 0x30A2404
	public void set_hideMobileInput(bool value) { }

	// RVA: 0x30A24F0
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x30A17DC
	public ITextEdition get_textEdition() { }

	// RVA: 0x30A24F0
	public void set_maxLength(int value) { }

	// RVA: 0x30A1224
	public bool get_isDelayed() { }

	// RVA: 0x30A2404
	public void set_isDelayed(bool value) { }

	// RVA: -1
	public void set_maskChar(Char value) { }

	// RVA: -1
	protected abstract string ValueToString(TValueType value) { }

	// RVA: -1
	protected abstract TValueType StringToValue(string str) { }

	// RVA: 0x315B3A8
	protected void .ctor(string label, int maxLength, Char maskChar, TextInputBase textInputBase) { }

	// RVA: 0x30A27C0
	private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x30A27C0
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x30A2378
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x30A2378
	internal virtual void UpdateValueFromText() { }

	// RVA: 0x30A2378
	internal virtual void UpdateTextFromValue() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class TouchScreenTextEditorEventHandler
{
	// Fields
	private IVisualElementScheduledItem m_TouchKeyboardPoller; // 0x20
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x28
	private bool m_IsClicking; // 0x29

	// Methods

	// RVA: 0x17B9B34
	public void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x17B9B98
	private void PollTouchScreenKeyboard() { }

	// RVA: 0x17B9E0C
	private void DoPollTouchScreenKeyboard() { }

	// RVA: 0x17BA7F0
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x17BA6FC
	private void CloseTouchScreenKeyboard() { }

	// RVA: 0x17BAAA4
	private void OpenTouchScreenKeyboard() { }

	// RVA: 0x17BB010
	public override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x17BB218
	private void OnPointerDownEvent() { }

	// RVA: 0x17BB41C
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x17BB440
	private void OnFocusInEvent() { }

	// RVA: 0x17BB608
	private void OnFocusOutEvent(FocusOutEvent evt) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17BC24C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17BC2A0
	public void .ctor() { }

}

// Namespace: 
private class IntegerInput
{
	// Methods

	// RVA: 0x17BC2F4
	private IntegerField get_parentIntegerField() { }

	// RVA: 0x17BBF80
	internal void .ctor() { }

	// RVA: 0x17BC378
	protected override string get_allowedCharacters() { }

	// RVA: 0x17BC3F4
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x17BC718
	protected override string ValueToString(int v) { }

	// RVA: 0x17BC770
	protected override int StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class IntegerField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x17BBAC4
	private IntegerInput get_integerInput() { }

	// RVA: 0x17BBB7C
	protected override string ValueToString(int v) { }

	// RVA: 0x17BBC3C
	protected override int StringToValue(string str) { }

	// RVA: 0x17BBD78
	public void .ctor() { }

	// RVA: 0x17BBD84
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x17BC01C
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x17BC048
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x17BC14C
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17BC9E0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17BCA34
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Label
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x17BC820
	public void .ctor() { }

	// RVA: 0x17BC87C
	public void .ctor(string text) { }

	// RVA: 0x17BC968
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17BCB74
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17BCBC8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ListView
{
	// Fields
	private System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem; // 0x538
	private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> m_BindItem; // 0x540
	private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> <unbindItem>k__BackingField; // 0x548
	private System.Action<UnityEngine.UIElements.VisualElement> <destroyItem>k__BackingField; // 0x550

	// Methods

	// RVA: 0x17BCA3C
	public System.Func<UnityEngine.UIElements.VisualElement> get_makeItem() { }

	// RVA: 0x17BCA44
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem() { }

	// RVA: 0x17BCA4C
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem() { }

	// RVA: 0x17BCA54
	public System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem() { }

	// RVA: 0x17BCA5C
	internal override bool HasValidDataAndBindings() { }

	// RVA: 0x17BCAA0
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x17BCAF8
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17BD358
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17BD3AC
	public void .ctor() { }

}

// Namespace: 
private class LongInput
{
	// Methods

	// RVA: 0x17BD400
	private LongField get_parentLongField() { }

	// RVA: 0x17BD08C
	internal void .ctor() { }

	// RVA: 0x17BD484
	protected override string get_allowedCharacters() { }

	// RVA: 0x17BD500
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Int64 startValue) { }

	// RVA: 0x17BD854
	private Int64 ClampMinMaxLongValue(Int64 niceDelta, Int64 value) { }

	// RVA: 0x17BD8F8
	protected override string ValueToString(Int64 v) { }

	// RVA: 0x17BD950
	protected override Int64 StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class LongField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x17BCBD0
	private LongInput get_longInput() { }

	// RVA: 0x17BCC88
	protected override string ValueToString(Int64 v) { }

	// RVA: 0x17BCD48
	protected override Int64 StringToValue(string str) { }

	// RVA: 0x17BCE84
	public void .ctor() { }

	// RVA: 0x17BCE90
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x17BD128
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x17BD154
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Int64 startValue) { }

	// RVA: 0x17BD258
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17C0AB4
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_MinValue; // 0x80
	private UxmlFloatAttributeDescription m_MaxValue; // 0x88
	private UxmlFloatAttributeDescription m_LowLimit; // 0x90
	private UxmlFloatAttributeDescription m_HighLimit; // 0x98

	// Methods

	// RVA: 0x17C0B08
	public void .ctor() { }

	// RVA: 0x17C0D50
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: 
private enum DragState
{
	// Fields
	public int value__; // 0x10
	public const DragState NoThumb = 0;
	public const DragState MinThumb = 1;
	public const DragState MiddleThumb = 2;
	public const DragState MaxThumb = 3;
}

// Namespace: UnityEngine.UIElements
public class MinMaxSlider
{
	// Fields
	private VisualElement <dragElement>k__BackingField; // 0x440
	private VisualElement <dragMinThumb>k__BackingField; // 0x448
	private VisualElement <dragMaxThumb>k__BackingField; // 0x450
	private UnityEngine.UIElements.ClampedDragger<System.Single> <clampedDragger>k__BackingField; // 0x458
	private Vector2 m_DragElementStartPos; // 0x460
	private Vector2 m_ValueStartPos; // 0x468
	private Rect m_DragMinThumbRect; // 0x470
	private Rect m_DragMaxThumbRect; // 0x480
	private DragState m_DragState; // 0x490
	private float m_MinLimit; // 0x494
	private float m_MaxLimit; // 0x498
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10
	public static readonly string trackerUssClassName; // 0x18
	public static readonly string draggerUssClassName; // 0x20
	public static readonly string minThumbUssClassName; // 0x28
	public static readonly string maxThumbUssClassName; // 0x30

	// Methods

	// RVA: 0x17BDA00
	internal VisualElement get_dragElement() { }

	// RVA: 0x17BDA08
	private void set_dragElement(VisualElement value) { }

	// RVA: 0x17BDA18
	internal VisualElement get_dragMinThumb() { }

	// RVA: 0x17BDA20
	private void set_dragMinThumb(VisualElement value) { }

	// RVA: 0x17BDA30
	internal VisualElement get_dragMaxThumb() { }

	// RVA: 0x17BDA38
	private void set_dragMaxThumb(VisualElement value) { }

	// RVA: 0x17BDA48
	internal UnityEngine.UIElements.ClampedDragger<System.Single> get_clampedDragger() { }

	// RVA: 0x17BDA50
	private void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<System.Single> value) { }

	// RVA: 0x17BDA60
	public float get_minValue() { }

	// RVA: 0x17BDA70
	public void set_minValue(float value) { }

	// RVA: 0x17BDB78
	public float get_maxValue() { }

	// RVA: 0x17BDB9C
	public void set_maxValue(float value) { }

	// RVA: 0x17BDC6C
	public override Vector2 get_value() { }

	// RVA: 0x17BDCD4
	public override void set_value(Vector2 value) { }

	// RVA: 0x17BDD78
	public override void SetValueWithoutNotify(Vector2 newValue) { }

	// RVA: 0x17BECC8
	public float get_lowLimit() { }

	// RVA: 0x17BECD0
	public void set_lowLimit(float value) { }

	// RVA: 0x17BEE40
	public float get_highLimit() { }

	// RVA: 0x17BEE48
	public void set_highLimit(float value) { }

	// RVA: 0x17BEFB8
	public void .ctor() { }

	// RVA: 0x17BEFD8
	public void .ctor(string label, float minValue, float maxValue, float minLimit, float maxLimit) { }

	// RVA: 0x17BDB40
	private Vector2 ClampValues(Vector2 valueToClamp) { }

	// RVA: 0x17BF6E4
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	// RVA: 0x17BDE24
	private void UpdateDragElementPosition() { }

	// RVA: 0x17BF74C
	private void UpdateDragThumbsRect() { }

	// RVA: 0x17BF73C
	internal float SliderLerpUnclamped(float a, float b, float interpolant) { }

	// RVA: 0x17BF72C
	internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	// RVA: 0x17BFE94
	private float ComputeValueFromPosition(float positionToConvert) { }

	// RVA: 0x17C0038
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x17C0188
	private void SetSliderValueFromDrag() { }

	// RVA: 0x17C03C8
	private void SetSliderValueFromClick() { }

	// RVA: 0x17C0220
	private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos) { }

	// RVA: 0x17C05F8
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x17C05FC
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x17C0750
	internal override void UnregisterEditingCallbacks() { }

	// RVA: 0x17C08A4
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal enum ColumnDataType
{
	// Fields
	public int value__; // 0x10
	public const ColumnDataType Name = 0;
	public const ColumnDataType Title = 1;
	public const ColumnDataType Icon = 2;
	public const ColumnDataType Visibility = 3;
	public const ColumnDataType Width = 4;
	public const ColumnDataType MaxWidth = 5;
	public const ColumnDataType MinWidth = 6;
	public const ColumnDataType Stretchable = 7;
	public const ColumnDataType Sortable = 8;
	public const ColumnDataType Optional = 9;
	public const ColumnDataType Resizable = 10;
	public const ColumnDataType HeaderTemplate = 11;
	public const ColumnDataType CellTemplate = 12;
}

// Namespace: 
internal class UxmlObjectFactory<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass15_0
{
	// Fields
	public VisualTreeAsset asset; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A17DC
	internal VisualElement <Init>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass15_1
{
	// Fields
	public VisualTreeAsset asset; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A17DC
	internal VisualElement <Init>b__1() { }

}

// Namespace: 
internal class UxmlObjectTraits<T0>
{
	// Fields
	private UxmlStringAttributeDescription m_Name; // 0x0
	private UxmlStringAttributeDescription m_Text; // 0x0
	private UxmlBoolAttributeDescription m_Visible; // 0x0
	private UxmlStringAttributeDescription m_Width; // 0x0
	private UxmlStringAttributeDescription m_MinWidth; // 0x0
	private UxmlStringAttributeDescription m_MaxWidth; // 0x0
	private UxmlBoolAttributeDescription m_Stretch; // 0x0
	private UxmlBoolAttributeDescription m_Sortable; // 0x0
	private UxmlBoolAttributeDescription m_Optional; // 0x0
	private UxmlBoolAttributeDescription m_Resizable; // 0x0
	private UxmlStringAttributeDescription m_HeaderTemplateId; // 0x0
	private UxmlStringAttributeDescription m_CellTemplateId; // 0x0

	// Methods

	// RVA: 0x315B3A8
	private static Length ParseLength(string str, Length defaultValue) { }

	// RVA: -1
	public override void Init(T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Column
{
	// Fields
	private static readonly string k_InvalidTemplateError; // 0x0
	private string m_Name; // 0x10
	private string m_Title; // 0x18
	private Background m_Icon; // 0x20
	private bool m_Visible; // 0x40
	private Length m_Width; // 0x44
	private Length m_MinWidth; // 0x4C
	private Length m_MaxWidth; // 0x54
	private float m_DesiredWidth; // 0x5C
	private bool m_Stretchable; // 0x60
	private bool m_Sortable; // 0x61
	private bool m_Optional; // 0x62
	private bool m_Resizable; // 0x63
	private System.Func<UnityEngine.UIElements.VisualElement> m_MakeHeader; // 0x68
	private System.Action<UnityEngine.UIElements.VisualElement> m_BindHeader; // 0x70
	private System.Action<UnityEngine.UIElements.VisualElement> m_UnbindHeader; // 0x78
	private System.Action<UnityEngine.UIElements.VisualElement> m_DestroyHeader; // 0x80
	private System.Func<UnityEngine.UIElements.VisualElement> m_MakeCell; // 0x88
	private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> m_BindCell; // 0x90
	private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> m_UnbindCellItem; // 0x98
	private System.Action<UnityEngine.UIElements.VisualElement> <destroyCell>k__BackingField; // 0xA0
	private Columns <collection>k__BackingField; // 0xA8
	private System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> changed; // 0xB0
	private System.Action<UnityEngine.UIElements.Column> resized; // 0xB8

	// Methods

	// RVA: 0x17C0F04
	public string get_name() { }

	// RVA: 0x17C0F0C
	public void set_name(string value) { }

	// RVA: 0x17C0FC4
	public string get_title() { }

	// RVA: 0x17C0FCC
	public void set_title(string value) { }

	// RVA: 0x17C1048
	public Background get_icon() { }

	// RVA: 0x17C1054
	internal int get_index() { }

	// RVA: 0x17C11DC
	internal int get_displayIndex() { }

	// RVA: 0x17C13BC
	internal int get_visibleIndex() { }

	// RVA: 0x17C1494
	public bool get_visible() { }

	// RVA: 0x17C149C
	public void set_visible(bool value) { }

	// RVA: 0x17C14F0
	public Length get_width() { }

	// RVA: 0x17C14F8
	public void set_width(Length value) { }

	// RVA: 0x17C15B0
	public Length get_minWidth() { }

	// RVA: 0x17C15B8
	public void set_minWidth(Length value) { }

	// RVA: 0x17C161C
	public Length get_maxWidth() { }

	// RVA: 0x17C1624
	public void set_maxWidth(Length value) { }

	// RVA: 0x17C1688
	internal float get_desiredWidth() { }

	// RVA: 0x17C1580
	internal void set_desiredWidth(float value) { }

	// RVA: 0x17C1690
	public bool get_sortable() { }

	// RVA: 0x17C1698
	public void set_sortable(bool value) { }

	// RVA: 0x17C16EC
	public bool get_stretchable() { }

	// RVA: 0x17C16F4
	public void set_stretchable(bool value) { }

	// RVA: 0x17C1748
	public bool get_optional() { }

	// RVA: 0x17C1750
	public void set_optional(bool value) { }

	// RVA: 0x17C17A4
	public bool get_resizable() { }

	// RVA: 0x17C17AC
	public void set_resizable(bool value) { }

	// RVA: 0x17C1800
	public System.Func<UnityEngine.UIElements.VisualElement> get_makeHeader() { }

	// RVA: 0x17C1808
	public void set_makeHeader(System.Func<UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x17C1884
	public System.Action<UnityEngine.UIElements.VisualElement> get_bindHeader() { }

	// RVA: 0x17C188C
	public System.Action<UnityEngine.UIElements.VisualElement> get_unbindHeader() { }

	// RVA: 0x17C1894
	public System.Action<UnityEngine.UIElements.VisualElement> get_destroyHeader() { }

	// RVA: 0x17C189C
	public System.Func<UnityEngine.UIElements.VisualElement> get_makeCell() { }

	// RVA: 0x17C18A4
	public void set_makeCell(System.Func<UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x17C1920
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindCell() { }

	// RVA: 0x17C1928
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindCell() { }

	// RVA: 0x17C1930
	public System.Action<UnityEngine.UIElements.VisualElement> get_destroyCell() { }

	// RVA: 0x17C1938
	public Columns get_collection() { }

	// RVA: 0x17C1940
	internal void set_collection(Columns value) { }

	// RVA: 0x17C1948
	internal void add_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x17C19FC
	internal void remove_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x17C1AB0
	internal void add_resized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17C1B64
	internal void remove_resized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17C0F84
	private void NotifyChange(ColumnDataType type) { }

	// RVA: 0x17C1C18
	internal float GetWidth(float layoutWidth) { }

	// RVA: 0x17C1C3C
	internal float GetMaxWidth(float layoutWidth) { }

	// RVA: 0x17C1C60
	internal float GetMinWidth(float layoutWidth) { }

	// RVA: 0x17C1C84
	public void .ctor() { }

	// RVA: 0x17C1CF8
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public float totalColumnWidth; // 0x10
	public ColumnLayout <>4__this; // 0x18

	// Methods

	// RVA: 0x17C5BC8
	public void .ctor() { }

	// RVA: 0x17C7164
	internal void <RecomputeToMaxWidthProportionally>b__1(Column c) { }

}

// Namespace: 
private sealed class <>c__DisplayClass54_0
{
	// Fields
	public float totalColumnsWidth; // 0x10
	public ColumnLayout <>4__this; // 0x18

	// Methods

	// RVA: 0x17C5D78
	public void .ctor() { }

	// RVA: 0x17C71A4
	internal void <RecomputeToMinWidthProportionally>b__1(Column c) { }

}

// Namespace: UnityEngine.UIElements
internal class ColumnLayout
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_StretchableColumns; // 0x10
	private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_FixedColumns; // 0x18
	private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_RelativeWidthColumns; // 0x20
	private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_MixedWidthColumns; // 0x28
	private Columns m_Columns; // 0x30
	private float m_ColumnsWidth; // 0x38
	private bool m_ColumnsWidthDirty; // 0x3C
	private float m_MaxColumnsWidth; // 0x40
	private float m_MinColumnsWidth; // 0x44
	private bool m_IsDirty; // 0x48
	private float m_PreviousWidth; // 0x4C
	private float m_LayoutWidth; // 0x50
	private bool m_DragResizeInPreviewMode; // 0x54
	private bool m_DragResizing; // 0x55
	private float m_DragStartPos; // 0x58
	private float m_DragLastPos; // 0x5C
	private float m_DragInitialColumnWidth; // 0x60
	private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_DragStretchableColumns; // 0x68
	private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_DragRelativeColumns; // 0x70
	private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_DragFixedColumns; // 0x78
	private System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,System.Single> m_PreviewDesiredWidths; // 0x80
	private Action layoutRequested; // 0x88

	// Methods

	// RVA: 0x17C1D70
	public Columns get_columns() { }

	// RVA: 0x17C1D78
	public float get_columnsWidth() { }

	// RVA: 0x17C2078
	public float get_layoutWidth() { }

	// RVA: 0x17C2080
	public float get_minColumnsWidth() { }

	// RVA: 0x17C2088
	public float get_maxColumnsWidth() { }

	// RVA: 0x17C2090
	public bool get_hasStretchableColumns() { }

	// RVA: 0x17C20E4
	public bool get_hasRelativeWidthColumns() { }

	// RVA: 0x17C215C
	public void add_layoutRequested(Action value) { }

	// RVA: 0x17C2200
	public void remove_layoutRequested(Action value) { }

	// RVA: 0x17C22A4
	public void .ctor(Columns columns) { }

	// RVA: 0x17C2D8C
	public void Dirty() { }

	// RVA: 0x17C2894
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x17C2F34
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x17C315C
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x17C31AC
	private bool RequiresLayoutUpdate(ColumnDataType type) { }

	// RVA: 0x17C31C4
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x17C323C
	private void OnColumnResized(Column column) { }

	// RVA: 0x17C3248
	private static bool IsClamped(float value, float min, float max) { }

	// RVA: 0x17C325C
	public void DoLayout(float width) { }

	// RVA: 0x17C4A98
	public void StretchResizeColumns(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x17C4B84
	private void DistributeOverflow(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x17C4E08
	private void DistributeExcess(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x17C5754
	private float RecomputeToMaxWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x17C52B0
	private float RecomputeToMinWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x17C5170
	private float RecomputeToDesiredWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	// RVA: 0x17C5D80
	private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	// RVA: 0x17C55B0
	private float RecomputeToMinWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x17C5A38
	private float RecomputeToMaxWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x17C5F40
	public void ResizeToFit(float width) { }

	// RVA: 0x17C5BD0
	private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly) { }

	// RVA: 0x17C6244
	internal void BeginDragResize(Column column, float pos, bool previewMode) { }

	// RVA: 0x17C6688
	public float GetDesiredPosition(Column column) { }

	// RVA: 0x17C49D0
	public float GetDesiredWidth(Column c) { }

	// RVA: 0x17C681C
	public void DragResize(Column column, float pos) { }

	// RVA: 0x17C6AA4
	internal void EndDragResize(Column column, bool cancelled) { }

	// RVA: 0x17C41B4
	private void UpdateCache() { }

	// RVA: 0x17C45F4
	private void UpdateMinAndMaxColumnsWidth() { }

	// RVA: 0x17C2DDC
	private void ClearCache() { }

	// RVA: 0x17C6FA4
	private int <DoLayout>b__49_0(Column c1, Column c2) { }

	// RVA: 0x17C7014
	private int <DoLayout>b__49_1(Column c1, Column c2) { }

	// RVA: 0x17C7084
	private int <RecomputeToMaxWidthProportionally>b__53_0(Column c1, Column c2) { }

	// RVA: 0x17C70F4
	private int <RecomputeToMinWidthProportionally>b__54_0(Column c1, Column c2) { }

}

// Namespace: UnityEngine.UIElements
internal enum ColumnsDataType
{
	// Fields
	public int value__; // 0x10
	public const ColumnsDataType PrimaryColumn = 0;
	public const ColumnsDataType StretchMode = 1;
	public const ColumnsDataType Reorderable = 2;
	public const ColumnsDataType Resizable = 3;
	public const ColumnsDataType ResizePreview = 4;
}

// Namespace: 
public enum StretchMode
{
	// Fields
	public int value__; // 0x10
	public const StretchMode Grow = 0;
	public const StretchMode GrowAndFill = 1;
}

// Namespace: 
internal class UxmlObjectFactory<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
internal class UxmlObjectTraits<T0>
{
	// Fields
	private readonly UxmlStringAttributeDescription m_PrimaryColumnName; // 0x0
	private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.Columns.StretchMode> m_StretchMode; // 0x0
	private readonly UxmlBoolAttributeDescription m_Reorderable; // 0x0
	private readonly UxmlBoolAttributeDescription m_Resizable; // 0x0
	private readonly UxmlBoolAttributeDescription m_ResizePreview; // 0x0
	private readonly UnityEngine.UIElements.UxmlObjectListAttributeDescription<UnityEngine.UIElements.Column> m_Columns; // 0x0

	// Methods

	// RVA: -1
	public override void Init(T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Columns.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.UIElements.Column> <>9__76_0; // 0x8

	// Methods

	// RVA: 0x17C95A8
	private static void .cctor() { }

	// RVA: 0x17C9614
	public void .ctor() { }

	// RVA: 0x17C961C
	internal bool <UpdateVisibleColumns>b__76_0(Column c) { }

}

// Namespace: UnityEngine.UIElements
public class Columns
{
	// Fields
	private System.Collections.Generic.IList<UnityEngine.UIElements.Column> m_Columns; // 0x10
	private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_DisplayColumns; // 0x18
	private System.Collections.Generic.List<UnityEngine.UIElements.Column> m_VisibleColumns; // 0x20
	private bool m_VisibleColumnsDirty; // 0x28
	private StretchMode m_StretchMode; // 0x2C
	private bool m_Reorderable; // 0x30
	private bool m_Resizable; // 0x31
	private bool m_ResizePreview; // 0x32
	private string m_PrimaryColumnName; // 0x38
	private System.Action<UnityEngine.UIElements.ColumnsDataType> changed; // 0x40
	private System.Action<UnityEngine.UIElements.Column,System.Int32> columnAdded; // 0x48
	private System.Action<UnityEngine.UIElements.Column> columnRemoved; // 0x50
	private System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> columnChanged; // 0x58
	private System.Action<UnityEngine.UIElements.Column> columnResized; // 0x60
	private System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> columnReordered; // 0x68

	// Methods

	// RVA: 0x17C71E4
	public string get_primaryColumnName() { }

	// RVA: 0x17C71EC
	public void set_primaryColumnName(string value) { }

	// RVA: 0x17C7298
	public bool get_reorderable() { }

	// RVA: 0x17C72A0
	public void set_reorderable(bool value) { }

	// RVA: 0x17C72EC
	public bool get_resizable() { }

	// RVA: 0x17C72F4
	public void set_resizable(bool value) { }

	// RVA: 0x17C7340
	public bool get_resizePreview() { }

	// RVA: 0x17C7348
	public void set_resizePreview(bool value) { }

	// RVA: 0x17C1308
	internal System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_displayList() { }

	// RVA: 0x17C1470
	internal System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_visibleList() { }

	// RVA: 0x17C7708
	internal void add_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value) { }

	// RVA: 0x17C77BC
	internal void remove_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value) { }

	// RVA: 0x17C7870
	public StretchMode get_stretchMode() { }

	// RVA: 0x17C7878
	public void set_stretchMode(StretchMode value) { }

	// RVA: 0x17C2B70
	internal void add_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value) { }

	// RVA: 0x17C78C4
	internal void remove_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value) { }

	// RVA: 0x17C2C24
	internal void add_columnRemoved(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17C7978
	internal void remove_columnRemoved(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17C7A2C
	internal void add_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x17C7AE0
	internal void remove_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x17C7B94
	internal void add_columnResized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17C7C48
	internal void remove_columnResized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17C2CD8
	internal void add_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value) { }

	// RVA: 0x17C7CFC
	internal void remove_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value) { }

	// RVA: 0x17C7DB0
	public bool IsPrimary(Column column) { }

	// RVA: 0x17C491C
	public System.Collections.Generic.IEnumerator<UnityEngine.UIElements.Column> GetEnumerator() { }

	// RVA: 0x17C7EB4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x17C7F68
	public void Add(Column item) { }

	// RVA: 0x17C8400
	public void Clear() { }

	// RVA: 0x17C88F8
	public bool Contains(Column item) { }

	// RVA: 0x17C89B0
	public bool Contains(string name) { }

	// RVA: 0x17C8CC4
	public void CopyTo(Column[] array, int arrayIndex) { }

	// RVA: 0x17C85C4
	public bool Remove(Column column) { }

	// RVA: 0x17C8D84
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x17C8F0C
	private void OnColumnResized(Column column) { }

	// RVA: 0x17C2ABC
	public int get_Count() { }

	// RVA: 0x17C8F28
	public bool get_IsReadOnly() { }

	// RVA: 0x17C1124
	public int IndexOf(Column column) { }

	// RVA: 0x17C8028
	public void Insert(int index, Column column) { }

	// RVA: 0x17C27E0
	public Column get_Item(int index) { }

	// RVA: 0x17C8FE0
	public Column get_Item(string name) { }

	// RVA: 0x17C92F4
	public void ReorderDisplay(int from, int to) { }

	// RVA: 0x17C7394
	private void InitOrderColumns() { }

	// RVA: 0x17C8E68
	private void DirtyVisibleColumns() { }

	// RVA: 0x17C7434
	private void UpdateVisibleColumns() { }

	// RVA: 0x17C7260
	private void NotifyChange(ColumnsDataType type) { }

	// RVA: 0x17C9508
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MultiColumnController
{
	// Fields
	private static readonly PropertyName k_BoundColumnVePropertyName; // 0x0
	internal static readonly PropertyName bindableElementPropertyName; // 0x4
	internal static readonly string baseUssClassName; // 0x8
	private static readonly string k_HeaderContainerViewDataKey; // 0x10
	public static readonly string headerContainerUssClassName; // 0x18
	public static readonly string rowContainerUssClassName; // 0x20
	public static readonly string cellUssClassName; // 0x28
	public static readonly string cellLabelUssClassName; // 0x30
	private static readonly string k_HeaderViewDataKey; // 0x38
	private Action columnSortingChanged; // 0x10
	private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> headerContextMenuPopulateEvent; // 0x18
	private BaseVerticalCollectionView m_View; // 0x20
	private VisualElement m_HeaderContainer; // 0x28
	private MultiColumnCollectionHeader m_MultiColumnHeader; // 0x30

	// Methods

	// RVA: 0x17C9638
	public void add_columnSortingChanged(Action value) { }

	// RVA: 0x17C96DC
	public void remove_columnSortingChanged(Action value) { }

	// RVA: 0x17C9780
	public void add_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17C9834
	public void remove_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17C98E8
	internal MultiColumnCollectionHeader get_header() { }

	// RVA: 0x17C98F0
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x315B3A8
	private static void BindCellItem(VisualElement ve, int rowIndex, Column column, T item) { }

	// RVA: 0x17C9F60
	private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column) { }

	// RVA: 0x17C9FA8
	private static VisualElement DefaultMakeCellItem() { }

	// RVA: 0x315B3A8
	private static void DefaultBindCellItem(VisualElement ve, Column column, T item) { }

	// RVA: 0x17CA080
	public VisualElement MakeItem() { }

	// RVA: 0x315B3A8
	public void BindItem(VisualElement element, int index, T item) { }

	// RVA: 0x17CA4F0
	public void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x17CA908
	public void DestroyItem(VisualElement element) { }

	// RVA: 0x17CAD40
	public void PrepareView(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x17CB038
	public void Dispose() { }

	// RVA: 0x17CB790
	private void OnHorizontalScrollerValueChanged(float v) { }

	// RVA: 0x17CB7B0
	private void OnViewportGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17CBC30
	private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17CBA7C
	private void UpdateContentContainer(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x17CBC38
	private void OnColumnSortingChanged() { }

	// RVA: 0x17CBC54
	private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column) { }

	// RVA: 0x17CBC70
	private void OnColumnResized(int index, float width) { }

	// RVA: 0x17CC040
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x17CC060
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x17CC080
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x17CC0B8
	private void OnColumnsChanged(Column column, ColumnDataType type) { }

	// RVA: 0x17CC0F8
	private void OnColumnChanged(ColumnsDataType type) { }

	// RVA: 0x17CC134
	private void OnViewDataRestored() { }

	// RVA: 0x17CC154
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17CD394
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xD8
	private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns> m_Columns; // 0xE0
	private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions> m_SortColumnDescriptions; // 0xE8

	// Methods

	// RVA: 0x17CD3E8
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17CD54C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MultiColumnListView
{
	// Fields
	private Columns m_Columns; // 0x538
	private bool m_SortingEnabled; // 0x540
	private SortColumnDescriptions m_SortColumnDescriptions; // 0x548
	private System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns; // 0x550
	private Action columnSortingChanged; // 0x558
	private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> headerContextMenuPopulateEvent; // 0x560

	// Methods

	// RVA: 0x17CC37C
	public MultiColumnListViewController get_viewController() { }

	// RVA: 0x17CC40C
	public Columns get_columns() { }

	// RVA: 0x17CC414
	private void set_columns(Columns value) { }

	// RVA: 0x17CC528
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	// RVA: 0x17CC530
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x17CC7FC
	public void set_sortingEnabled(bool value) { }

	// RVA: 0x17CC910
	public void .ctor() { }

	// RVA: 0x17CC9F8
	public void .ctor(Columns columns) { }

	// RVA: 0x17CCCB0
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x17CCD2C
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x17CD324
	internal override void CreateVirtualizationController() { }

	// RVA: 0x17CC7E0
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x17CD378
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17CE4D8
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xB8
	private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns> m_Columns; // 0xC0
	private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions> m_SortColumnDescriptions; // 0xC8

	// Methods

	// RVA: 0x17CE52C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17CE690
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MultiColumnTreeView
{
	// Fields
	private Columns m_Columns; // 0x4B8
	private bool m_SortingEnabled; // 0x4C0
	private SortColumnDescriptions m_SortColumnDescriptions; // 0x4C8
	private System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns; // 0x4D0
	private Action columnSortingChanged; // 0x4D8
	private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> headerContextMenuPopulateEvent; // 0x4E0

	// Methods

	// RVA: 0x17CD690
	public MultiColumnTreeViewController get_viewController() { }

	// RVA: 0x17CD720
	public Columns get_columns() { }

	// RVA: 0x17CD728
	private void set_columns(Columns value) { }

	// RVA: 0x17CD83C
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	// RVA: 0x17CD844
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x17CD9B0
	public void set_sortingEnabled(bool value) { }

	// RVA: 0x17CDAC4
	public void .ctor() { }

	// RVA: 0x17CDBAC
	public void .ctor(Columns columns) { }

	// RVA: 0x17CDDD8
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x17CDE70
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x17CE468
	internal override void CreateVirtualizationController() { }

	// RVA: 0x17CD994
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x17CE4BC
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

}

// Namespace: UnityEngine.UIElements
public enum SortDirection
{
	// Fields
	public int value__; // 0x10
	public const SortDirection Ascending = 0;
	public const SortDirection Descending = 1;
}

// Namespace: 
internal class UxmlObjectFactory<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
internal class UxmlObjectTraits<T0>
{
	// Fields
	private readonly UxmlStringAttributeDescription m_ColumnName; // 0x0
	private readonly UxmlIntAttributeDescription m_ColumnIndex; // 0x0
	private readonly UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SortDirection> m_SortDescription; // 0x0

	// Methods

	// RVA: -1
	public override void Init(T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
public class SortColumnDescription
{
	// Fields
	private int m_ColumnIndex; // 0x10
	private string m_ColumnName; // 0x18
	private SortDirection m_SortDirection; // 0x20
	private Column <column>k__BackingField; // 0x28
	private System.Action<UnityEngine.UIElements.SortColumnDescription> changed; // 0x30

	// Methods

	// RVA: 0x17CE7D4
	public string get_columnName() { }

	// RVA: 0x17CE7DC
	public void set_columnName(string value) { }

	// RVA: 0x17CE850
	public int get_columnIndex() { }

	// RVA: 0x17CE858
	public void set_columnIndex(int value) { }

	// RVA: 0x17CE88C
	public Column get_column() { }

	// RVA: 0x17CE894
	internal void set_column(Column value) { }

	// RVA: 0x17CE89C
	public SortDirection get_direction() { }

	// RVA: 0x17CE8A4
	public void set_direction(SortDirection value) { }

	// RVA: 0x17CE8D8
	internal void add_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value) { }

	// RVA: 0x17CE98C
	internal void remove_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value) { }

	// RVA: 0x17CEA40
	public void .ctor() { }

	// RVA: 0x17CEA50
	public void .ctor(int columnIndex, SortDirection direction) { }

	// RVA: 0x17CEAF0
	public void .ctor(string columnName, SortDirection direction) { }

}

// Namespace: 
internal class UxmlObjectFactory<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
internal class UxmlObjectTraits<T0>
{
	// Fields
	private readonly UnityEngine.UIElements.UxmlObjectListAttributeDescription<UnityEngine.UIElements.SortColumnDescription> m_SortColumnDescriptions; // 0x0

	// Methods

	// RVA: -1
	public override void Init(T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
public class SortColumnDescriptions
{
	// Fields
	private readonly System.Collections.Generic.IList<UnityEngine.UIElements.SortColumnDescription> m_Descriptions; // 0x10
	private Action changed; // 0x18

	// Methods

	// RVA: 0x17CEBA8
	internal void add_changed(Action value) { }

	// RVA: 0x17CEC4C
	internal void remove_changed(Action value) { }

	// RVA: 0x17CECF0
	public System.Collections.Generic.IEnumerator<UnityEngine.UIElements.SortColumnDescription> GetEnumerator() { }

	// RVA: 0x17CEDA4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x17CEE58
	public void Add(SortColumnDescription item) { }

	// RVA: 0x17CC680
	public void Clear() { }

	// RVA: 0x17CF40C
	public bool Contains(SortColumnDescription item) { }

	// RVA: 0x17CF4C4
	public void CopyTo(SortColumnDescription[] array, int arrayIndex) { }

	// RVA: 0x17CF1E8
	public bool Remove(SortColumnDescription desc) { }

	// RVA: 0x17CF584
	private void OnDescriptionChanged(SortColumnDescription desc) { }

	// RVA: 0x17CF5A0
	public int get_Count() { }

	// RVA: 0x17CF654
	public bool get_IsReadOnly() { }

	// RVA: 0x17CEF18
	public void Insert(int index, SortColumnDescription desc) { }

	// RVA: 0x17CCC24
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass26_0
{
	// Fields
	public T item; // 0x0
	public UnityEngine.UIElements.PopupField<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A2378
	internal void <AddMenuItems>b__0() { }

}

// Namespace: UnityEngine.UIElements
public class PopupField<T0>
{
	// Fields
	private int m_Index; // 0x0
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x0
	public static readonly string inputUssClassName; // 0x0

	// Methods

	// RVA: 0x30A17DC
	internal override string GetValueToDisplay() { }

	// RVA: 0x315B3A8
	internal override string GetListItemToDisplay(T value) { }

	// RVA: 0x315B3A8
	public override T get_value() { }

	// RVA: 0x315B3A8
	public override void set_value(T value) { }

	// RVA: 0x315B3A8
	public override void SetValueWithoutNotify(T newValue) { }

	// RVA: 0x30A24F0
	public void set_index(int value) { }

	// RVA: 0x30A27C0
	public void .ctor(string label) { }

	// RVA: 0x30A27C0
	internal override void AddMenuItems(IGenericMenu menu) { }

	// RVA: 0x315B3A8
	private void ChangeValueFromMenu(T menuItem) { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17CF910
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17CF964
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class PopupWindow
{
	// Fields
	private VisualElement m_ContentContainer; // 0x4A0
	public static readonly string ussClassName; // 0x0
	public static readonly string contentUssClassName; // 0x8

	// Methods

	// RVA: 0x17CF70C
	public void .ctor() { }

	// RVA: 0x17CF850
	public override VisualElement get_contentContainer() { }

	// RVA: 0x17CF858
	private static void .cctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_LowValue; // 0x78
	private UxmlFloatAttributeDescription m_HighValue; // 0x80
	private UxmlFloatAttributeDescription m_Value; // 0x88
	private UxmlStringAttributeDescription m_Title; // 0x90

	// Methods

	// RVA: 0x17D0368
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17D0550
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class AbstractProgressBar
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string containerUssClassName; // 0x8
	public static readonly string titleUssClassName; // 0x10
	public static readonly string titleContainerUssClassName; // 0x18
	public static readonly string progressUssClassName; // 0x20
	public static readonly string backgroundUssClassName; // 0x28
	private readonly VisualElement m_Background; // 0x3D8
	private readonly VisualElement m_Progress; // 0x3E0
	private readonly Label m_Title; // 0x3E8
	private float m_LowValue; // 0x3F0
	private float m_HighValue; // 0x3F4
	private float m_Value; // 0x3F8

	// Methods

	// RVA: 0x17CF96C
	public void set_title(string value) { }

	// RVA: 0x17CF994
	public float get_lowValue() { }

	// RVA: 0x17CF99C
	public void set_lowValue(float value) { }

	// RVA: 0x17CFB30
	public float get_highValue() { }

	// RVA: 0x17CFB38
	public void set_highValue(float value) { }

	// RVA: 0x17CFB44
	public void .ctor() { }

	// RVA: 0x17CFE54
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x17CFE84
	public virtual float get_value() { }

	// RVA: 0x17CFE8C
	public virtual void set_value(float value) { }

	// RVA: 0x17D00DC
	public void SetValueWithoutNotify(float newValue) { }

	// RVA: 0x17CF9A8
	private void SetProgress(float p) { }

	// RVA: 0x17D0110
	private float CalculateProgressWidth(float width) { }

	// RVA: 0x17D01A0
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17D080C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ProgressBar
{
	// Methods

	// RVA: 0x17D078C
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17D1484
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x88

	// Methods

	// RVA: 0x17D14D8
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17D15EC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class RadioButton
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10
	public static readonly string checkmarkBackgroundUssClassName; // 0x18
	public static readonly string checkmarkUssClassName; // 0x20
	public static readonly string textUssClassName; // 0x28
	private VisualElement m_CheckmarkBackground; // 0x460

	// Methods

	// RVA: 0x17D0860
	public override bool get_value() { }

	// RVA: 0x17D08C8
	public override void set_value(bool value) { }

	// RVA: 0x17D0AD0
	public void .ctor() { }

	// RVA: 0x17D0AD8
	public void .ctor(string label) { }

	// RVA: 0x17D0D9C
	private void OnOptionAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x17D0E40
	private void OnOptionDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x17D0EE4
	protected override void InitLabel() { }

	// RVA: 0x17D0F6C
	protected override void ToggleValue() { }

	// RVA: 0x17D0FBC
	private void UnityEngine.UIElements.IGroupBoxOption.SetSelected(bool selected) { }

	// RVA: 0x17D0FCC
	public override void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x17D09BC
	private void UpdateCheckmark() { }

	// RVA: 0x17D0FF4
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x17D10D0
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17D2898
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Choices; // 0x88

	// Methods

	// RVA: 0x17D28EC
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17D2A18
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class RadioButtonGroup
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string containerUssClassName; // 0x8
	private System.Collections.Generic.List<UnityEngine.UIElements.RadioButton> m_RadioButtons; // 0x440
	private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<System.Boolean>> m_RadioButtonValueChangedCallback; // 0x448
	private VisualElement m_RadioButtonContainer; // 0x450

	// Methods

	// RVA: 0x17D16A4
	public void set_choices(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x17D2048
	public override VisualElement get_contentContainer() { }

	// RVA: 0x17D2058
	public void .ctor() { }

	// RVA: 0x17D2064
	public void .ctor(string label, System.Collections.Generic.List<System.String> radioButtonChoices) { }

	// RVA: 0x17D22D0
	private void RadioButtonValueChangedCallback(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

	// RVA: 0x17D2420
	public override void SetValueWithoutNotify(int newValue) { }

	// RVA: 0x17D1DAC
	private void UpdateRadioButtons() { }

	// RVA: 0x17D2494
	private void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x17D265C
	private void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x17D27E0
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17D2D9C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlLongAttributeDescription m_Delay; // 0x98
	private UxmlLongAttributeDescription m_Interval; // 0xA0

	// Methods

	// RVA: 0x17D2DF0
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17D2F8C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class RepeatButton
{
	// Fields
	private Clickable m_Clickable; // 0x4A0
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x17D2AD0
	public void .ctor() { }

	// RVA: 0x17D2BA0
	public void .ctor(Action clickEvent, Int64 delay, Int64 interval) { }

	// RVA: 0x17D2C54
	public void SetAction(Action clickEvent, Int64 delay, Int64 interval) { }

	// RVA: 0x17D2D04
	internal void AddAction(Action clickEvent) { }

	// RVA: 0x17D2D24
	private static void .cctor() { }

}

// Namespace: 
private class ScrollerSlider
{
	// Methods

	// RVA: 0x17D3AA0
	public void .ctor(float start, float end, SliderDirection direction, float pageSize) { }

	// RVA: 0x17D40A4
	internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17D40DC
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_LowValue; // 0x70
	private UxmlFloatAttributeDescription m_HighValue; // 0x78
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction; // 0x80
	private UxmlFloatAttributeDescription m_Value; // 0x88

	// Methods

	// RVA: 0x17D4130
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17D4318
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Scroller
{
	// Fields
	private System.Action<System.Single> valueChanged; // 0x3C8
	private Slider <slider>k__BackingField; // 0x3D0
	private RepeatButton <lowButton>k__BackingField; // 0x3D8
	private RepeatButton <highButton>k__BackingField; // 0x3E0
	public static readonly string ussClassName; // 0x0
	public static readonly string horizontalVariantUssClassName; // 0x8
	public static readonly string verticalVariantUssClassName; // 0x10
	public static readonly string sliderUssClassName; // 0x18
	public static readonly string lowButtonUssClassName; // 0x20
	public static readonly string highButtonUssClassName; // 0x28

	// Methods

	// RVA: 0x17D307C
	public void add_valueChanged(System.Action<System.Single> value) { }

	// RVA: 0x17D3134
	public void remove_valueChanged(System.Action<System.Single> value) { }

	// RVA: 0x17D31EC
	public Slider get_slider() { }

	// RVA: 0x17D31F4
	private void set_slider(Slider value) { }

	// RVA: 0x17D3204
	public RepeatButton get_lowButton() { }

	// RVA: 0x17D320C
	private void set_lowButton(RepeatButton value) { }

	// RVA: 0x17D321C
	public RepeatButton get_highButton() { }

	// RVA: 0x17D3224
	private void set_highButton(RepeatButton value) { }

	// RVA: 0x17D3234
	public float get_value() { }

	// RVA: 0x17D325C
	public void set_value(float value) { }

	// RVA: 0x17D3284
	public float get_lowValue() { }

	// RVA: 0x17D32EC
	public void set_lowValue(float value) { }

	// RVA: 0x17D3360
	public float get_highValue() { }

	// RVA: 0x17D33C8
	public void set_highValue(float value) { }

	// RVA: 0x17D343C
	public void set_direction(SliderDirection value) { }

	// RVA: 0x17D36A4
	public void .ctor() { }

	// RVA: 0x17D36B8
	public void .ctor(float lowValue, float highValue, System.Action<System.Single> valueChanged, SliderDirection direction) { }

	// RVA: 0x17D3B34
	public void Adjust(float factor) { }

	// RVA: 0x17D3BB0
	private void OnSliderValueChange(UnityEngine.UIElements.ChangeEvent<System.Single> evt) { }

	// RVA: 0x17D3CA8
	public void ScrollPageUp() { }

	// RVA: 0x17D3DBC
	public void ScrollPageDown() { }

	// RVA: 0x17D3CB0
	public void ScrollPageUp(float factor) { }

	// RVA: 0x17D3DC4
	public void ScrollPageDown(float factor) { }

	// RVA: 0x17D3ED0
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public enum ScrollViewMode
{
	// Fields
	public int value__; // 0x10
	public const ScrollViewMode Vertical = 0;
	public const ScrollViewMode Horizontal = 1;
	public const ScrollViewMode VerticalAndHorizontal = 2;
}

// Namespace: UnityEngine.UIElements
public enum ScrollerVisibility
{
	// Fields
	public int value__; // 0x10
	public const ScrollerVisibility Auto = 0;
	public const ScrollerVisibility AlwaysVisible = 1;
	public const ScrollerVisibility Hidden = 2;
}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17DBC90
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollViewMode> m_ScrollViewMode; // 0x70
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.NestedInteractionKind> m_NestedInteractionKind; // 0x78
	private UxmlBoolAttributeDescription m_ShowHorizontal; // 0x80
	private UxmlBoolAttributeDescription m_ShowVertical; // 0x88
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility> m_HorizontalScrollerVisibility; // 0x90
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollerVisibility> m_VerticalScrollerVisibility; // 0x98
	private UxmlFloatAttributeDescription m_HorizontalPageSize; // 0xA0
	private UxmlFloatAttributeDescription m_VerticalPageSize; // 0xA8
	private UxmlFloatAttributeDescription m_MouseWheelScrollSize; // 0xB0
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.ScrollView.TouchScrollBehavior> m_TouchScrollBehavior; // 0xB8
	private UxmlFloatAttributeDescription m_ScrollDecelerationRate; // 0xC0
	private UxmlFloatAttributeDescription m_Elasticity; // 0xC8
	private UxmlLongAttributeDescription m_ElasticAnimationIntervalMs; // 0xD0

	// Methods

	// RVA: 0x17DBCE4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17DC0FC
	public void .ctor() { }

}

// Namespace: 
public enum TouchScrollBehavior
{
	// Fields
	public int value__; // 0x10
	public const TouchScrollBehavior Unrestricted = 0;
	public const TouchScrollBehavior Elastic = 1;
	public const TouchScrollBehavior Clamped = 2;
}

// Namespace: 
public enum NestedInteractionKind
{
	// Fields
	public int value__; // 0x10
	public const NestedInteractionKind Default = 0;
	public const NestedInteractionKind StopScrolling = 1;
	public const NestedInteractionKind ForwardScrolling = 2;
}

// Namespace: 
internal enum TouchScrollingResult
{
	// Fields
	public int value__; // 0x10
	public const TouchScrollingResult Apply = 0;
	public const TouchScrollingResult Forward = 1;
	public const TouchScrollingResult Block = 2;
}

// Namespace: UnityEngine.UIElements
public class ScrollView
{
	// Fields
	private int m_FirstLayoutPass; // 0x3C8
	private ScrollerVisibility m_HorizontalScrollerVisibility; // 0x3CC
	private ScrollerVisibility m_VerticalScrollerVisibility; // 0x3D0
	private VisualElement m_AttachedRootVisualContainer; // 0x3D8
	private float m_SingleLineHeight; // 0x3E0
	internal bool m_MouseWheelScrollSizeIsInline; // 0x3E4
	private float m_HorizontalPageSize; // 0x3E8
	private float m_VerticalPageSize; // 0x3EC
	private float m_MouseWheelScrollSize; // 0x3F0
	private static readonly float k_DefaultScrollDecelerationRate; // 0x0
	private float m_ScrollDecelerationRate; // 0x3F4
	private float k_ScaledPixelsPerPointMultiplier; // 0x3F8
	private float k_TouchScrollInertiaBaseTimeInterval; // 0x3FC
	private static readonly float k_DefaultElasticity; // 0x4
	private float m_Elasticity; // 0x400
	private TouchScrollBehavior m_TouchScrollBehavior; // 0x404
	private NestedInteractionKind m_NestedInteractionKind; // 0x408
	private static readonly Int64 k_DefaultElasticAnimationInterval; // 0x8
	private Int64 m_ElasticAnimationIntervalMs; // 0x410
	private readonly VisualElement <contentViewport>k__BackingField; // 0x418
	private readonly Scroller <horizontalScroller>k__BackingField; // 0x420
	private readonly Scroller <verticalScroller>k__BackingField; // 0x428
	private VisualElement m_ContentContainer; // 0x430
	private VisualElement m_ContentAndVerticalScrollContainer; // 0x438
	private float previousVerticalTouchScrollTimeStamp; // 0x440
	private float previousHorizontalTouchScrollTimeStamp; // 0x444
	private float elapsedTimeSinceLastVerticalTouchScroll; // 0x448
	private float elapsedTimeSinceLastHorizontalTouchScroll; // 0x44C
	public static readonly string ussClassName; // 0x10
	public static readonly string viewportUssClassName; // 0x18
	public static readonly string horizontalVariantViewportUssClassName; // 0x20
	public static readonly string verticalVariantViewportUssClassName; // 0x28
	public static readonly string verticalHorizontalVariantViewportUssClassName; // 0x30
	public static readonly string contentAndVerticalScrollUssClassName; // 0x38
	public static readonly string contentUssClassName; // 0x40
	public static readonly string horizontalVariantContentUssClassName; // 0x48
	public static readonly string verticalVariantContentUssClassName; // 0x50
	public static readonly string verticalHorizontalVariantContentUssClassName; // 0x58
	public static readonly string hScrollerUssClassName; // 0x60
	public static readonly string vScrollerUssClassName; // 0x68
	public static readonly string horizontalVariantUssClassName; // 0x70
	public static readonly string verticalVariantUssClassName; // 0x78
	public static readonly string verticalHorizontalVariantUssClassName; // 0x80
	public static readonly string scrollVariantUssClassName; // 0x88
	private ScrollViewMode m_Mode; // 0x450
	private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; // 0x458
	private Vector2 m_StartPosition; // 0x460
	private Vector2 m_PointerStartPosition; // 0x468
	private Vector2 m_Velocity; // 0x470
	private Vector2 m_SpringBackVelocity; // 0x478
	private Vector2 m_LowBounds; // 0x480
	private Vector2 m_HighBounds; // 0x488
	private float m_LastVelocityLerpTime; // 0x490
	private bool m_StartedMoving; // 0x494
	private bool m_TouchPointerMoveAllowed; // 0x495
	private bool m_TouchStoppedVelocity; // 0x496
	private VisualElement m_CapturedTarget; // 0x498
	private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerMoveEvent> m_CapturedTargetPointerMoveCallback; // 0x4A0
	private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.PointerUpEvent> m_CapturedTargetPointerUpCallback; // 0x4A8
	internal IVisualElementScheduledItem m_PostPointerUpAnimation; // 0x4B0

	// Methods

	// RVA: 0x17D45C0
	public ScrollerVisibility get_horizontalScrollerVisibility() { }

	// RVA: 0x17D45C8
	public void set_horizontalScrollerVisibility(ScrollerVisibility value) { }

	// RVA: 0x17D4DFC
	public ScrollerVisibility get_verticalScrollerVisibility() { }

	// RVA: 0x17D4E04
	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	// RVA: 0x17D4F5C
	public void set_showHorizontal(bool value) { }

	// RVA: 0x17D4F78
	public void set_showVertical(bool value) { }

	// RVA: 0x17D4724
	internal bool get_needsHorizontal() { }

	// RVA: 0x17D47D4
	internal bool get_needsVertical() { }

	// RVA: 0x17D504C
	internal bool get_isVerticalScrollDisplayed() { }

	// RVA: 0x17D5110
	internal bool get_isHorizontalScrollDisplayed() { }

	// RVA: 0x17D51D4
	public Vector2 get_scrollOffset() { }

	// RVA: 0x17D5248
	public void set_scrollOffset(Vector2 value) { }

	// RVA: 0x17D5794
	public void set_horizontalPageSize(float value) { }

	// RVA: 0x17D5A00
	public void set_verticalPageSize(float value) { }

	// RVA: 0x17D5C6C
	public float get_mouseWheelScrollSize() { }

	// RVA: 0x17D5C74
	public void set_mouseWheelScrollSize(float value) { }

	// RVA: 0x17D4F94
	internal float get_scrollableWidth() { }

	// RVA: 0x17D4FF0
	internal float get_scrollableHeight() { }

	// RVA: 0x17D5D34
	private bool get_hasInertia() { }

	// RVA: 0x17D5D44
	public float get_scrollDecelerationRate() { }

	// RVA: 0x17D5D4C
	public void set_scrollDecelerationRate(float value) { }

	// RVA: 0x17D5D60
	public float get_elasticity() { }

	// RVA: 0x17D5D68
	public void set_elasticity(float value) { }

	// RVA: 0x17D5D7C
	public TouchScrollBehavior get_touchScrollBehavior() { }

	// RVA: 0x17D5D84
	public void set_touchScrollBehavior(TouchScrollBehavior value) { }

	// RVA: 0x17D5F3C
	public NestedInteractionKind get_nestedInteractionKind() { }

	// RVA: 0x17D5F44
	public void set_nestedInteractionKind(NestedInteractionKind value) { }

	// RVA: 0x17D5F4C
	public void set_elasticAnimationIntervalMs(Int64 value) { }

	// RVA: 0x17D6114
	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17D615C
	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17D579C
	private void UpdateHorizontalSliderPageSize() { }

	// RVA: 0x17D5A08
	private void UpdateVerticalSliderPageSize() { }

	// RVA: 0x17D546C
	internal void UpdateContentViewTransform() { }

	// RVA: 0x17D61A4
	public void ScrollTo(VisualElement child) { }

	// RVA: 0x17D66B8
	private float GetXDeltaOffset(VisualElement child) { }

	// RVA: 0x17D6478
	private float GetYDeltaOffset(VisualElement child) { }

	// RVA: 0x17D68F8
	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) { }

	// RVA: 0x17D6948
	public VisualElement get_contentViewport() { }

	// RVA: 0x17D6950
	public Scroller get_horizontalScroller() { }

	// RVA: 0x17D6958
	public Scroller get_verticalScroller() { }

	// RVA: 0x17D6960
	public override VisualElement get_contentContainer() { }

	// RVA: 0x17D6968
	public void .ctor() { }

	// RVA: 0x17D6970
	public void .ctor(ScrollViewMode scrollViewMode) { }

	// RVA: 0x17D79C4
	public ScrollViewMode get_mode() { }

	// RVA: 0x17D79CC
	public void set_mode(ScrollViewMode value) { }

	// RVA: 0x17D7654
	private void SetScrollViewMode(ScrollViewMode mode) { }

	// RVA: 0x17D79E0
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x17D804C
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x17D862C
	private void OnPointerCapture(PointerCaptureEvent evt) { }

	// RVA: 0x17D87B0
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x17D897C
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17D8B74
	private void ScheduleResetLayoutPass() { }

	// RVA: 0x17D8620
	private void ResetLayoutPass() { }

	// RVA: 0x17D8D9C
	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) { }

	// RVA: 0x17D8EAC
	private void ComputeInitialSpringBackVelocity() { }

	// RVA: 0x17D9114
	private void SpringBack() { }

	// RVA: 0x17D92C0
	internal void ApplyScrollInertia() { }

	// RVA: 0x17D9634
	private void PostPointerUpAnimation() { }

	// RVA: 0x17D97CC
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x17D9D74
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x17DA64C
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x17DA6B8
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x17D9A70
	internal void InitTouchScrolling(Vector2 position) { }

	// RVA: 0x17D9FEC
	internal TouchScrollingResult ComputeTouchScrolling(Vector2 position) { }

	// RVA: 0x17DA770
	private bool ApplyTouchScrolling(Vector2 newScrollOffset) { }

	// RVA: 0x17D8898
	private bool ReleaseScrolling(int pointerId, IEventHandler target) { }

	// RVA: 0x17DAA1C
	private void ExecuteElasticSpringAnimation() { }

	// RVA: 0x17DACC4
	private void AdjustScrollers() { }

	// RVA: 0x17D4884
	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) { }

	// RVA: 0x17DAE78
	private void OnScrollersGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17DB048
	private void OnScrollWheel(WheelEvent evt) { }

	// RVA: 0x17DB7A0
	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	// RVA: 0x17DB7A4
	private void OnRootPointerUp(PointerUpEvent evt) { }

	// RVA: 0x17D7F44
	private void ReadSingleLineHeight() { }

	// RVA: 0x17DB524
	private void UpdateElasticBehaviour() { }

	// RVA: 0x17DB7AC
	private static void .cctor() { }

	// RVA: 0x17DBB8C
	private void <.ctor>b__126_0(float value) { }

	// RVA: 0x17DBC0C
	private void <.ctor>b__126_1(float value) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17DD14C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_LowValue; // 0x80
	private UxmlFloatAttributeDescription m_HighValue; // 0x88
	private UxmlFloatAttributeDescription m_PageSize; // 0x90
	private UxmlBoolAttributeDescription m_ShowInputField; // 0x98
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction; // 0xA0
	private UxmlBoolAttributeDescription m_Inverted; // 0xA8

	// Methods

	// RVA: 0x17DD1A0
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17DD430
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Slider
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x17DC778
	public void .ctor() { }

	// RVA: 0x17D4098
	public void .ctor(float start, float end, SliderDirection direction, float pageSize) { }

	// RVA: 0x17DC790
	public void .ctor(string label, float start, float end, SliderDirection direction, float pageSize) { }

	// RVA: 0x17DC920
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x17DCA64
	internal override float SliderLerpUnclamped(float a, float b, float interpolant) { }

	// RVA: 0x17D40CC
	internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	// RVA: 0x17DCDA0
	internal override float ParseStringToValue(string previousValue, string newValue) { }

	// RVA: 0x17DCE30
	internal override void ComputeValueFromKey(SliderKey sliderKey, bool isShift) { }

	// RVA: 0x17DD04C
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17DE698
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_LowValue; // 0x80
	private UxmlIntAttributeDescription m_HighValue; // 0x88
	private UxmlIntAttributeDescription m_PageSize; // 0x90
	private UxmlBoolAttributeDescription m_ShowInputField; // 0x98
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.SliderDirection> m_Direction; // 0xA0
	private UxmlBoolAttributeDescription m_Inverted; // 0xA8

	// Methods

	// RVA: 0x17DE6EC
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17DE980
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class SliderInt
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x17DD758
	public void .ctor() { }

	// RVA: 0x17DD770
	public void .ctor(string label, int start, int end, SliderDirection direction, float pageSize) { }

	// RVA: 0x17DD900
	public override float get_pageSize() { }

	// RVA: 0x17DD954
	public override void set_pageSize(float value) { }

	// RVA: 0x17DDA9C
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x17DDC80
	internal override int SliderLerpUnclamped(int a, int b, float interpolant) { }

	// RVA: 0x17DDDAC
	internal override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) { }

	// RVA: 0x17DDDC8
	internal override int ParseStringToValue(string previousValue, string newValue) { }

	// RVA: 0x17DDE54
	internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	// RVA: 0x17DE284
	internal override void ComputeValueFromKey(SliderKey sliderKey, bool isShift) { }

	// RVA: 0x17DE598
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public enum DeltaSpeed
{
	// Fields
	public int value__; // 0x10
	public const DeltaSpeed Fast = 0;
	public const DeltaSpeed Normal = 1;
	public const DeltaSpeed Slow = 2;
}

// Namespace: UnityEngine.UIElements
public interface IValueField<T0>
{
	// Methods

	// RVA: -1
	public abstract T get_value() { }

	// RVA: -1
	public abstract void set_value(T value) { }

	// RVA: -1
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue) { }

	// RVA: -1
	public abstract void StartDragging() { }

	// RVA: -1
	public abstract void StopDragging() { }

}

// Namespace: 
protected abstract class TextValueInput
{
	// Fields
	private string <formatString>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A17DC
	private UnityEngine.UIElements.TextValueField<TValueType> get_textValueFieldParent() { }

	// RVA: 0x30A2378
	protected void .ctor() { }

	// RVA: 0x315B3A8
	internal override bool AcceptCharacter(Char c) { }

	// RVA: -1
	protected abstract string get_allowedCharacters() { }

	// RVA: 0x30A17DC
	public string get_formatString() { }

	// RVA: 0x30A27C0
	public void set_formatString(string value) { }

	// RVA: -1
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	// RVA: 0x30A2378
	public void StartDragging() { }

	// RVA: 0x30A2378
	public void StopDragging() { }

	// RVA: -1
	protected abstract string ValueToString(TValueType value) { }

	// RVA: 0x315B3A8
	protected override TValueType StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public abstract class TextValueField<T0>
{
	// Fields
	private BaseFieldMouseDragger m_Dragger; // 0x0
	internal bool m_UpdateTextFromValue; // 0x0
	private bool m_ForceUpdateDisplay; // 0x0

	// Methods

	// RVA: 0x30A17DC
	private TextValueInput get_textValueInput() { }

	// RVA: 0x30A17DC
	public string get_formatString() { }

	// RVA: 0x30A289C
	protected void .ctor(string label, int maxLength, TextValueInput textValueInput) { }

	// RVA: -1
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	// RVA: 0x30A2378
	public void StartDragging() { }

	// RVA: 0x30A2378
	public void StopDragging() { }

	// RVA: 0x315B3A8
	public override TValueType get_value() { }

	// RVA: 0x315B3A8
	public override void set_value(TValueType value) { }

	// RVA: 0x30A2378
	internal override void UpdateValueFromText() { }

	// RVA: 0x30A2378
	internal override void UpdateTextFromValue() { }

	// RVA: 0x30A2404
	private void OnIsReadOnlyChanged(bool newValue) { }

	// RVA: 0x30A1344
	internal virtual bool CanTryParse(string textString) { }

	// RVA: 0x30A2378
	protected void AddLabelDragger() { }

	// RVA: 0x30A2404
	private void EnableLabelDragger(bool enable) { }

	// RVA: 0x315B3A8
	public override void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30A27C0
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x30A2378
	internal override void OnViewDataReady() { }

	// RVA: 0x30A2378
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x30A2378
	internal override void UnregisterEditingCallbacks() { }

}

// Namespace: UnityEngine.UIElements
public class TextValueFieldTraits<T0, T1>
{
	// Fields
	private UxmlBoolAttributeDescription m_IsReadOnly; // 0x0
	private UxmlBoolAttributeDescription m_IsDelayed; // 0x0

	// Methods

	// RVA: -1
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17DF274
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x88

	// Methods

	// RVA: 0x17DF2C8
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17DF3DC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Toggle
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10
	public static readonly string noTextVariantUssClassName; // 0x18
	public static readonly string checkmarkUssClassName; // 0x20
	public static readonly string textUssClassName; // 0x28
	public static readonly string mixedValuesUssClassName; // 0x30

	// Methods

	// RVA: 0x17DECA8
	public void .ctor() { }

	// RVA: 0x17DECB0
	public void .ctor(string label) { }

	// RVA: 0x17DEDDC
	protected override void InitLabel() { }

	// RVA: 0x17DEE64
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x17DF064
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17DF714
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17DF768
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class TreeView
{
	// Fields
	private System.Func<UnityEngine.UIElements.VisualElement> m_MakeItem; // 0x4B8
	private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> m_BindItem; // 0x4C0
	private System.Action<UnityEngine.UIElements.VisualElement,System.Int32> <unbindItem>k__BackingField; // 0x4C8
	private System.Action<UnityEngine.UIElements.VisualElement> <destroyItem>k__BackingField; // 0x4D0

	// Methods

	// RVA: 0x17DF494
	public System.Func<UnityEngine.UIElements.VisualElement> get_makeItem() { }

	// RVA: 0x17DF49C
	public void set_makeItem(System.Func<UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x17DF4F4
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem() { }

	// RVA: 0x17DF4FC
	public void set_bindItem(System.Action<UnityEngine.UIElements.VisualElement,System.Int32> value) { }

	// RVA: 0x17DF554
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem() { }

	// RVA: 0x17DF55C
	public System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem() { }

	// RVA: 0x17DF564
	internal override bool HasValidDataAndBindings() { }

	// RVA: 0x17DF5A8
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x17DF61C
	public void .ctor() { }

	// RVA: 0x17DF628
	public void .ctor(System.Func<UnityEngine.UIElements.VisualElement> makeItem, System.Action<UnityEngine.UIElements.VisualElement,System.Int32> bindItem) { }

}

// Namespace: UnityEngine.UIElements
internal struct TreeData<T0>
{
	// Fields
	private readonly System.Collections.Generic.IList<System.Int32> m_RootItemIds; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.TreeViewItemData<T>> m_Tree; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_ParentIds; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>> m_ChildrenIds; // 0x0

	// Methods

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerable<System.Int32> get_rootItemIds() { }

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }

	// RVA: 0x315B3A8
	public UnityEngine.UIElements.TreeViewItemData<T> GetDataForId(int id) { }

	// RVA: -1
	public int GetParentId(int id) { }

	// RVA: -1
	public void Move(int id, int newParentId, int childIndex) { }

	// RVA: -1
	public bool HasAncestor(int childId, int ancestorId) { }

	// RVA: 0x315B3A8
	private void AddItemToParent(UnityEngine.UIElements.TreeViewItemData<T> item, int parentId, int childIndex) { }

	// RVA: 0x30A2560
	private void RemoveFromParent(int id, int parentId) { }

	// RVA: 0x315B3A8
	private void UpdateParentTree(UnityEngine.UIElements.TreeViewItemData<T> current) { }

	// RVA: 0x30A27C0
	private void RefreshTree(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }

	// RVA: -1
	private void BuildTree(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items, bool isRoot) { }

}

// Namespace: UnityEngine.UIElements
internal struct TreeItem
{
	// Fields
	private readonly int <id>k__BackingField; // 0x10
	private readonly int <parentId>k__BackingField; // 0x14
	private readonly System.Collections.Generic.IEnumerable<System.Int32> <childrenIds>k__BackingField; // 0x18

	// Methods

	// RVA: 0x17DF770
	public int get_id() { }

	// RVA: 0x17DF778
	public int get_parentId() { }

	// RVA: 0x17DF780
	public System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds() { }

	// RVA: 0x17DF788
	public bool get_hasChildren() { }

	// RVA: 0x17DF7E4
	public void .ctor(int id, int parentId, System.Collections.Generic.IEnumerable<System.Int32> childrenIds) { }

}

// Namespace: UnityEngine.UIElements
internal struct TreeViewItemWrapper
{
	// Fields
	public readonly TreeItem item; // 0x10
	public readonly int depth; // 0x20

	// Methods

	// RVA: 0x17DF7F4
	public int get_id() { }

	// RVA: 0x17DF7FC
	public System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds() { }

	// RVA: 0x17DF804
	public bool get_hasChildren() { }

	// RVA: 0x17DF860
	public void .ctor(TreeItem item, int depth) { }

}

// Namespace: UnityEngine.UIElements
public struct TreeViewItemData<T0>
{
	// Fields
	private readonly int <id>k__BackingField; // 0x0
	private readonly T m_Data; // 0x0
	private readonly System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> m_Children; // 0x0

	// Methods

	// RVA: 0x30A14A4
	public int get_id() { }

	// RVA: 0x315B3A8
	public T get_data() { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> get_children() { }

	// RVA: 0x30A1224
	public bool get_hasChildren() { }

	// RVA: 0x315B3A8
	internal void InsertChild(UnityEngine.UIElements.TreeViewItemData<T> child, int index) { }

	// RVA: 0x30A24F0
	internal void RemoveChild(int childId) { }

	// RVA: -1
	internal int GetChildIndex(int itemId) { }

	// RVA: 0x315B3A8
	internal void ReplaceChild(UnityEngine.UIElements.TreeViewItemData<T> newChild) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17E3280
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_FixedPaneIndex; // 0x70
	private UxmlIntAttributeDescription m_FixedPaneInitialDimension; // 0x78
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.TwoPaneSplitViewOrientation> m_Orientation; // 0x80

	// Methods

	// RVA: 0x17E32D4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17E342C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class TwoPaneSplitView
{
	// Fields
	private static readonly string s_UssClassName; // 0x0
	private static readonly string s_ContentContainerClassName; // 0x8
	private static readonly string s_HandleDragLineClassName; // 0x10
	private static readonly string s_HandleDragLineVerticalClassName; // 0x18
	private static readonly string s_HandleDragLineHorizontalClassName; // 0x20
	private static readonly string s_HandleDragLineAnchorClassName; // 0x28
	private static readonly string s_HandleDragLineAnchorVerticalClassName; // 0x30
	private static readonly string s_HandleDragLineAnchorHorizontalClassName; // 0x38
	private static readonly string s_VerticalClassName; // 0x40
	private static readonly string s_HorizontalClassName; // 0x48
	private VisualElement m_LeftPane; // 0x3C8
	private VisualElement m_RightPane; // 0x3D0
	private VisualElement m_FixedPane; // 0x3D8
	private VisualElement m_FlexedPane; // 0x3E0
	private float m_FixedPaneDimension; // 0x3E8
	private VisualElement m_DragLine; // 0x3F0
	private VisualElement m_DragLineAnchor; // 0x3F8
	private bool m_CollapseMode; // 0x400
	private bool m_CollapseChildCalledBeforeSetupComplete; // 0x401
	private int m_CollapsedChildIndex; // 0x404
	private VisualElement m_Content; // 0x408
	private TwoPaneSplitViewOrientation m_Orientation; // 0x410
	private int m_FixedPaneIndex; // 0x414
	private float m_FixedPaneInitialDimension; // 0x418
	internal TwoPaneSplitViewResizer m_Resizer; // 0x420

	// Methods

	// RVA: 0x17DF894
	public VisualElement get_fixedPane() { }

	// RVA: 0x17DF89C
	public VisualElement get_flexedPane() { }

	// RVA: 0x17DF8A4
	internal VisualElement get_dragLine() { }

	// RVA: 0x17DF8AC
	public int get_fixedPaneIndex() { }

	// RVA: 0x17DF8B4
	public TwoPaneSplitViewOrientation get_orientation() { }

	// RVA: 0x17DF8BC
	internal float get_fixedPaneDimension() { }

	// RVA: 0x17DF8F8
	internal void set_fixedPaneDimension(float value) { }

	// RVA: 0x17DF914
	public void .ctor() { }

	// RVA: 0x17DFB80
	public void CollapseChild(int index) { }

	// RVA: 0x17E0214
	internal void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) { }

	// RVA: 0x17E1B38
	private void OnPostDisplaySetup(GeometryChangedEvent evt) { }

	// RVA: 0x17E1C68
	private void ReplacePanesBasedOnAnchor() { }

	// RVA: 0x17E1DE4
	private void OnAnchorPostDisplaySetup(GeometryChangedEvent evt) { }

	// RVA: 0x17E1EE8
	private void IdentifyLeftAndRightPane() { }

	// RVA: 0x17E0588
	private void PostDisplaySetup() { }

	// RVA: 0x17E2048
	private void OnSizeChange(GeometryChangedEvent evt) { }

	// RVA: 0x17E2054
	private void UpdateLayout(bool updateFixedPane, bool updateDragLine) { }

	// RVA: 0x17E3000
	public override VisualElement get_contentContainer() { }

	// RVA: 0x17E3008
	internal override void OnViewDataReady() { }

	// RVA: 0x17E2D30
	private void SetDragLineOffset(float offset) { }

	// RVA: 0x17E2E98
	private void SetFixedPaneDimension(float dimension) { }

	// RVA: 0x17E3050
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public enum TwoPaneSplitViewOrientation
{
	// Fields
	public int value__; // 0x10
	public const TwoPaneSplitViewOrientation Horizontal = 0;
	public const TwoPaneSplitViewOrientation Vertical = 1;
}

// Namespace: UnityEngine.UIElements
internal class TwoPaneSplitViewResizer
{
	// Fields
	private Vector3 m_Start; // 0x30
	protected bool m_Active; // 0x3C
	private TwoPaneSplitView m_SplitView; // 0x40
	private int m_Direction; // 0x48

	// Methods

	// RVA: 0x17E360C
	private TwoPaneSplitViewOrientation get_orientation() { }

	// RVA: 0x17E362C
	private VisualElement get_fixedPane() { }

	// RVA: 0x17E364C
	private VisualElement get_flexedPane() { }

	// RVA: 0x17E366C
	private float get_fixedPaneMinDimension() { }

	// RVA: 0x17E37B0
	private float get_fixedPaneMargins() { }

	// RVA: 0x17E3A14
	private float get_flexedPaneMinDimension() { }

	// RVA: 0x17E3B58
	private float get_flexedPaneMargin() { }

	// RVA: 0x17E1FA4
	public void .ctor(TwoPaneSplitView splitView, int dir) { }

	// RVA: 0x17E3DBC
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x17E3F7C
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x17E413C
	public void ApplyDelta(float delta) { }

	// RVA: 0x17E4D38
	protected void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x17E4E14
	protected void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x17E527C
	protected void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x17E51E4
	protected void InterruptPointerMove(PointerMoveEvent e) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17E5AC0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17E5B14
	public void .ctor() { }

}

// Namespace: 
private class UnsignedIntegerInput
{
	// Methods

	// RVA: 0x17E5B68
	private UnsignedIntegerField get_parentUnsignedIntegerField() { }

	// RVA: 0x17E57F4
	internal void .ctor() { }

	// RVA: 0x17E5BEC
	protected override string get_allowedCharacters() { }

	// RVA: 0x17E5C68
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt32 startValue) { }

	// RVA: 0x17E5F8C
	protected override string ValueToString(UInt32 v) { }

	// RVA: 0x17E5FE4
	protected override UInt32 StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class UnsignedIntegerField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x17E5338
	private UnsignedIntegerInput get_integerInput() { }

	// RVA: 0x17E53F0
	protected override string ValueToString(UInt32 v) { }

	// RVA: 0x17E54B0
	protected override UInt32 StringToValue(string str) { }

	// RVA: 0x17E55EC
	public void .ctor() { }

	// RVA: 0x17E55F8
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x17E5890
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x17E58BC
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt32 startValue) { }

	// RVA: 0x17E59C0
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17E681C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17E6870
	public void .ctor() { }

}

// Namespace: 
private class UnsignedLongInput
{
	// Methods

	// RVA: 0x17E68C4
	private UnsignedLongField get_parentUnsignedLongField() { }

	// RVA: 0x17E6550
	internal void .ctor() { }

	// RVA: 0x17E6948
	protected override string get_allowedCharacters() { }

	// RVA: 0x17E69C4
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt64 startValue) { }

	// RVA: 0x17E6CF4
	private UInt64 ClampToMinMaxULongValue(Int64 niceDelta, UInt64 value) { }

	// RVA: 0x17E6D74
	protected override string ValueToString(UInt64 v) { }

	// RVA: 0x17E6DCC
	protected override UInt64 StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class UnsignedLongField
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x17E6094
	private UnsignedLongInput get_unsignedLongInput() { }

	// RVA: 0x17E614C
	protected override string ValueToString(UInt64 v) { }

	// RVA: 0x17E620C
	protected override UInt64 StringToValue(string str) { }

	// RVA: 0x17E6348
	public void .ctor() { }

	// RVA: 0x17E6354
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x17E65EC
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x17E6618
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt64 startValue) { }

	// RVA: 0x17E671C
	private static void .cctor() { }

}

// Namespace: 
public struct <m_Counters>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.UIElements
internal struct CountingBloomFilter
{
	// Fields
	private UnityEngine.UIElements.CountingBloomFilter.<m_Counters>e__FixedBuffer m_Counters; // 0x10

	// Methods

	// RVA: 0x17E6E7C
	private void AdjustSlot(UInt32 index, bool increment) { }

	// RVA: 0x17E6EAC
	private UInt32 Hash1(UInt32 hash) { }

	// RVA: 0x17E6EB4
	private UInt32 Hash2(UInt32 hash) { }

	// RVA: 0x17E6EBC
	private bool IsSlotEmpty(UInt32 index) { }

	// RVA: 0x17E6ECC
	public void InsertHash(UInt32 hash) { }

	// RVA: 0x17E6F18
	public void RemoveHash(UInt32 hash) { }

	// RVA: 0x17E6F48
	public bool ContainsHash(UInt32 hash) { }

}

// Namespace: UnityEngine.UIElements
internal class AncestorFilter
{
	// Fields
	private CountingBloomFilter m_CountingBloomFilter; // 0x10
	private System.Collections.Generic.Stack<System.Int32> m_HashStack; // 0x4010

	// Methods

	// RVA: 0x17E6F70
	public void .ctor() { }

	// RVA: 0x17E7004
	private void AddHash(int hash) { }

	// RVA: 0x17E70D4
	public bool IsCandidate(StyleComplexSelector complexSel) { }

	// RVA: 0x17E718C
	public void PushElement(VisualElement element) { }

	// RVA: 0x17E75BC
	public void PopElement() { }

}

// Namespace: UnityEngine.UIElements
public struct Cursor
{
	// Fields
	private Texture2D <texture>k__BackingField; // 0x10
	private Vector2 <hotspot>k__BackingField; // 0x18
	private int <defaultCursorId>k__BackingField; // 0x20

	// Methods

	// RVA: 0x17E76CC
	public Texture2D get_texture() { }

	// RVA: 0x17E76D4
	public void set_texture(Texture2D value) { }

	// RVA: 0x17E76DC
	public Vector2 get_hotspot() { }

	// RVA: 0x17E76E4
	public void set_hotspot(Vector2 value) { }

	// RVA: 0x17E76EC
	internal int get_defaultCursorId() { }

	// RVA: 0x17E76F4
	internal void set_defaultCursorId(int value) { }

	// RVA: 0x17E76FC
	public override bool Equals(object obj) { }

	// RVA: 0x17E7834
	public bool Equals(Cursor other) { }

	// RVA: 0x17E78E4
	public override int GetHashCode() { }

	// RVA: 0x17E79C0
	public static bool op_Equality(Cursor style1, Cursor style2) { }

	// RVA: 0x17E7A88
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
internal interface ICursorManager
{
	// Methods

	// RVA: -1
	public abstract void SetCursor(Cursor cursor) { }

	// RVA: -1
	public abstract void ResetCursor() { }

}

// Namespace: UnityEngine.UIElements
internal class CursorManager
{
	// Fields
	private bool <isCursorOverriden>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17E7B1C
	public bool get_isCursorOverriden() { }

	// RVA: 0x17E7B24
	private void set_isCursorOverriden(bool value) { }

	// RVA: 0x17E7B2C
	public void SetCursor(Cursor cursor) { }

	// RVA: 0x17E7C90
	public void ResetCursor() { }

	// RVA: 0x17E7CFC
	public void .ctor() { }

}

// Namespace: 
public enum UpdateMode
{
	// Fields
	public int value__; // 0x10
	public const UpdateMode Always = 0;
	public const UpdateMode IgnoreIfAppNotFocused = 1;
}

// Namespace: 
internal struct FocusBasedEventSequenceContext
{
	// Fields
	private DefaultEventSystem es; // 0x10

	// Methods

	// RVA: 0x17EB018
	public void .ctor(DefaultEventSystem es) { }

	// RVA: 0x17EB09C
	public void Dispose() { }

}

// Namespace: 
internal interface IInput
{
	// Methods

	// RVA: -1
	public abstract bool GetButtonDown(string button) { }

	// RVA: -1
	public abstract float GetAxisRaw(string axis) { }

	// RVA: -1
	public abstract void ClearLastPenContactEvent() { }

	// RVA: -1
	public abstract PenData GetLastPenContactEvent() { }

	// RVA: -1
	public abstract int get_touchCount() { }

	// RVA: -1
	public abstract Touch GetTouch(int index) { }

	// RVA: -1
	public abstract bool get_mousePresent() { }

	// RVA: -1
	public abstract bool GetMouseButtonDown(int button) { }

	// RVA: -1
	public abstract bool GetMouseButtonUp(int button) { }

	// RVA: -1
	public abstract Vector3 get_mousePosition() { }

	// RVA: -1
	public abstract int get_mouseButtonCount() { }

	// RVA: -1
	public abstract bool get_anyKey() { }

	// RVA: -1
	public abstract float get_unscaledTime() { }

	// RVA: -1
	public abstract float get_doubleClickTime() { }

}

// Namespace: 
private class Input
{
	// Methods

	// RVA: 0x17EB0E0
	public bool GetButtonDown(string button) { }

	// RVA: 0x17EB0EC
	public float GetAxisRaw(string axis) { }

	// RVA: 0x17EB0F8
	public void ClearLastPenContactEvent() { }

	// RVA: 0x17EB100
	public PenData GetLastPenContactEvent() { }

	// RVA: 0x17EB144
	public int get_touchCount() { }

	// RVA: 0x17EB14C
	public Touch GetTouch(int index) { }

	// RVA: 0x17EB1A0
	public bool get_mousePresent() { }

	// RVA: 0x17EB1A8
	public bool GetMouseButtonDown(int button) { }

	// RVA: 0x17EB1B4
	public bool GetMouseButtonUp(int button) { }

	// RVA: 0x17EB1C0
	public Vector3 get_mousePosition() { }

	// RVA: 0x17EB1C8
	public int get_mouseButtonCount() { }

	// RVA: 0x17EB1D0
	public bool get_anyKey() { }

	// RVA: 0x17EB1D8
	public float get_unscaledTime() { }

	// RVA: 0x17EB1E0
	public float get_doubleClickTime() { }

	// RVA: 0x17EB20C
	public void .ctor() { }

}

// Namespace: 
private class NoInput
{
	// Methods

	// RVA: 0x17EB214
	public bool GetButtonDown(string button) { }

	// RVA: 0x17EB21C
	public float GetAxisRaw(string axis) { }

	// RVA: 0x17EB224
	public int get_touchCount() { }

	// RVA: 0x17EB22C
	public Touch GetTouch(int index) { }

	// RVA: 0x17EB240
	public void ClearLastPenContactEvent() { }

	// RVA: 0x17EB244
	public PenData GetLastPenContactEvent() { }

	// RVA: 0x17EB254
	public bool get_mousePresent() { }

	// RVA: 0x17EB25C
	public bool GetMouseButtonDown(int button) { }

	// RVA: 0x17EB264
	public bool GetMouseButtonUp(int button) { }

	// RVA: 0x17EB26C
	public Vector3 get_mousePosition() { }

	// RVA: 0x17EB27C
	public int get_mouseButtonCount() { }

	// RVA: 0x17EB284
	public bool get_anyKey() { }

	// RVA: 0x17EB28C
	public float get_unscaledTime() { }

	// RVA: 0x17EB294
	public float get_doubleClickTime() { }

	// RVA: 0x17EB2A0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.DefaultEventSystem.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase> <>9__30_0; // 0x8
	public static System.Func<UnityEngine.Vector3,UnityEngine.Vector3,System.ValueTuple<UnityEngine.EventModifiers,UnityEngine.Vector2>,UnityEngine.UIElements.EventBase> <>9__30_1; // 0x10
	public static System.Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Event,UnityEngine.UIElements.EventBase> <>9__30_2; // 0x18
	public static System.Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase> <>9__36_0; // 0x20
	public static System.Func<UnityEngine.Vector3,UnityEngine.Vector3,System.ValueTuple<System.Int32,System.Int32,UnityEngine.EventModifiers>,UnityEngine.UIElements.EventBase> <>9__36_1; // 0x28
	public static System.Func<UnityEngine.Vector3,UnityEngine.Vector3,System.ValueTuple<System.Int32,System.Int32,UnityEngine.EventModifiers>,UnityEngine.UIElements.EventBase> <>9__36_2; // 0x30
	public static System.Func<UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase> <>9__37_0; // 0x38
	public static System.Func<UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase> <>9__37_1; // 0x40
	public static System.Func<UnityEngine.UIElements.DefaultEventSystem,UnityEngine.UIElements.EventBase> <>9__37_2; // 0x48
	public static System.Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.Touch,UnityEngine.UIElements.EventBase> <>9__45_0; // 0x50
	public static System.Func<UnityEngine.Vector3,UnityEngine.Vector3,UnityEngine.PenData,UnityEngine.UIElements.EventBase> <>9__46_0; // 0x58
	public static System.Func<System.ValueTuple<UnityEngine.UIElements.NavigationMoveEvent.Direction,UnityEngine.EventModifiers,UnityEngine.UIElements.DefaultEventSystem.IInput>,UnityEngine.UIElements.EventBase> <>9__53_0; // 0x60

	// Methods

	// RVA: 0x17EB2A8
	private static void .cctor() { }

	// RVA: 0x17EB314
	public void .ctor() { }

	// RVA: 0x17EB31C
	internal EventBase <SendIMGUIEvents>b__30_0(DefaultEventSystem self) { }

	// RVA: 0x17EB398
	internal EventBase <SendIMGUIEvents>b__30_1(Vector3 panelPosition, Vector3 _, System.ValueTuple<UnityEngine.EventModifiers,UnityEngine.Vector2> t) { }

	// RVA: 0x17EB528
	internal EventBase <SendIMGUIEvents>b__30_2(Vector3 panelPosition, Vector3 panelDelta, Event evt) { }

	// RVA: 0x17EB5D4
	internal EventBase <ProcessMouseEvents>b__36_0(Vector3 panelPosition, Vector3 panelDelta, DefaultEventSystem self) { }

	// RVA: 0x17EB674
	internal EventBase <ProcessMouseEvents>b__36_1(Vector3 panelPosition, Vector3 panelDelta, System.ValueTuple<System.Int32,System.Int32,UnityEngine.EventModifiers> t) { }

	// RVA: 0x17EB688
	internal EventBase <ProcessMouseEvents>b__36_2(Vector3 panelPosition, Vector3 panelDelta, System.ValueTuple<System.Int32,System.Int32,UnityEngine.EventModifiers> t) { }

	// RVA: 0x17EB69C
	internal EventBase <SendInputEvents>b__37_0(DefaultEventSystem self) { }

	// RVA: 0x17EB740
	internal EventBase <SendInputEvents>b__37_1(DefaultEventSystem self) { }

	// RVA: 0x17EB82C
	internal EventBase <SendInputEvents>b__37_2(DefaultEventSystem self) { }

	// RVA: 0x17EB918
	internal EventBase <ProcessTouchEvents>b__45_0(Vector3 panelPosition, Vector3 panelDelta, Touch _touch) { }

	// RVA: 0x17EBA04
	internal EventBase <ProcessPenEvents>b__46_0(Vector3 panelPosition, Vector3 panelDelta, PenData _pen) { }

	// RVA: 0x17EBAC0
	internal EventBase <ProcessTabEvent>b__53_0(System.ValueTuple<UnityEngine.UIElements.NavigationMoveEvent.Direction,UnityEngine.EventModifiers,UnityEngine.UIElements.DefaultEventSystem.IInput> t) { }

	// RVA: 0x17EBBB4
	internal bool <.cctor>b__58_0() { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultEventSystem
{
	// Fields
	internal static System.Func<System.Boolean> IsEditorRemoteConnected; // 0x0
	private IInput m_Input; // 0x10
	private readonly string m_HorizontalAxis; // 0x18
	private readonly string m_VerticalAxis; // 0x20
	private readonly string m_SubmitButton; // 0x28
	private readonly string m_CancelButton; // 0x30
	private readonly float m_InputActionsPerSecond; // 0x38
	private readonly float m_RepeatDelay; // 0x3C
	private bool m_SendingTouchEvents; // 0x40
	private bool m_SendingPenEvent; // 0x41
	private Event m_Event; // 0x48
	private BaseRuntimePanel m_FocusedPanel; // 0x50
	private BaseRuntimePanel m_PreviousFocusedPanel; // 0x58
	private Focusable m_PreviousFocusedElement; // 0x60
	private EventModifiers m_CurrentModifiers; // 0x68
	private int m_LastMousePressButton; // 0x6C
	private float m_NextMousePressTime; // 0x70
	private int m_LastMouseClickCount; // 0x74
	private Vector2 m_LastMousePosition; // 0x78
	private bool m_MouseProcessedAtLeastOnce; // 0x80
	private int m_ConsecutiveMoveCount; // 0x84
	private Vector2 m_LastMoveVector; // 0x88
	private float m_PrevActionTime; // 0x90
	private bool m_IsMoveFromKeyboard; // 0x94

	// Methods

	// RVA: 0x17E7D04
	private bool get_isAppFocused() { }

	// RVA: 0x17E7D74
	internal IInput get_input() { }

	// RVA: 0x17E7DD4
	private IInput GetDefaultInput() { }

	// RVA: 0x17E7F8C
	private bool ShouldIgnoreEventsOnAppNotFocused() { }

	// RVA: 0x17E7FB0
	public BaseRuntimePanel get_focusedPanel() { }

	// RVA: 0x17E7FB8
	public void set_focusedPanel(BaseRuntimePanel value) { }

	// RVA: 0x17E8018
	public void Update(UpdateMode updateMode) { }

	// RVA: 0x17E94F4
	internal FocusBasedEventSequenceContext FocusBasedEventSequence() { }

	// RVA: 0x17E9524
	private void SendIMGUIEvents() { }

	// RVA: 0x17E89A0
	private void ProcessMouseEvents() { }

	// RVA: 0x17E9CE8
	private void SendInputEvents() { }

	// RVA: 0x17EA740
	internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt) { }

	// RVA: 0x315B3A8
	internal void SendFocusBasedEvent(System.Func<TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg) { }

	// RVA: 0x315B3A8
	private void SendPositionBasedEvent(Vector3 mousePosition, Vector3 delta, int pointerId, System.Nullable<System.Int32> targetDisplay, System.Func<UnityEngine.Vector3,UnityEngine.Vector3,TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg, bool deselectIfNoTarget) { }

	// RVA: 0x17EA7A0
	private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel) { }

	// RVA: 0x17EA860
	private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers) { }

	// RVA: 0x17EA9E8
	private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers) { }

	// RVA: 0x17E84B0
	private bool ProcessTouchEvents() { }

	// RVA: 0x17E81A0
	private bool ProcessPenEvents() { }

	// RVA: 0x17EAAB4
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x17EA2C0
	private bool ShouldSendMoveFromInput() { }

	// RVA: 0x17EA0F4
	private void ProcessTabEvent(Event e, EventModifiers modifiers) { }

	// RVA: 0x17EADD8
	public void .ctor() { }

	// RVA: 0x17EAF44
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DisposeHelper
{
	// Methods

	// RVA: 0x17EBBBC
	public static void NotifyDisposedUsed(IDisposable disposable) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class BaseReorderableDragAndDropController
{
	// Fields
	protected readonly BaseVerticalCollectionView m_View; // 0x10
	protected System.Collections.Generic.List<System.Int32> m_SortedSelectedIds; // 0x18
	private bool <enableReordering>k__BackingField; // 0x20

	// Methods

	// RVA: 0x17EBCA0
	public System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds() { }

	// RVA: 0x17EBCA8
	protected void .ctor(BaseVerticalCollectionView view) { }

	// RVA: 0x17EBD58
	public virtual bool get_enableReordering() { }

	// RVA: 0x17EBD60
	public virtual void set_enableReordering(bool value) { }

	// RVA: 0x17EBD68
	public virtual bool CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIds) { }

	// RVA: 0x17EBD78
	public virtual StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, bool skipText) { }

	// RVA: 0x17EC67C
	protected virtual int CompareId(int id1, int id2) { }

	// RVA: -1
	public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: -1
	public abstract void OnDrop(IListDragAndDropArgs args) { }

	// RVA: 0x17EC6A8
	public virtual void DragCleanup() { }

	// RVA: 0x17EC6AC
	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

}

// Namespace: UnityEngine.UIElements
internal static class DragAndDropUtility
{
	// Fields
	private static System.Func<UnityEngine.UIElements.IDragAndDrop> s_MakeDragAndDropClientFunc; // 0x0
	private static IDragAndDrop s_DragAndDropEditor; // 0x8
	private static IDragAndDrop s_DragAndDropPlayMode; // 0x10

	// Methods

	// RVA: 0x17EC6B0
	internal static IDragAndDrop GetDragAndDrop(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultDragAndDropClient
{
	// Fields
	private readonly Hashtable m_GenericData; // 0x10
	private Label m_DraggedInfoLabel; // 0x18
	private DragVisualMode m_VisualMode; // 0x20
	private System.Collections.Generic.IEnumerable<UnityEngine.Object> m_UnityObjectReferences; // 0x28

	// Methods

	// RVA: 0x17EC96C
	public override object get_source() { }

	// RVA: 0x17EC9C8
	public override object GetGenericData(string key) { }

	// RVA: 0x17ECA30
	public void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	// RVA: 0x17ED114
	public void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x17ED2B8
	public void AcceptDrag() { }

	// RVA: 0x17ED2BC
	public void SetVisualMode(DragVisualMode mode) { }

	// RVA: 0x17ED2C4
	public void DragCleanup() { }

	// RVA: 0x17ED328
	public DragAndDropData get_data() { }

	// RVA: 0x17EC8F4
	public void .ctor() { }

}

// Namespace: 
internal enum DragState
{
	// Fields
	public int value__; // 0x10
	public const DragState None = 0;
	public const DragState CanStartDrag = 1;
	public const DragState Dragging = 2;
}

// Namespace: UnityEngine.UIElements
internal abstract class DragEventsProcessor
{
	// Fields
	private bool m_IsRegistered; // 0x10
	private DragState m_DragState; // 0x14
	private Vector3 m_Start; // 0x18
	protected readonly VisualElement m_Target; // 0x28

	// Methods

	// RVA: 0x17ED334
	protected virtual bool get_supportsDragEvents() { }

	// RVA: 0x17ED33C
	private bool get_useDragEvents() { }

	// RVA: 0x17ED380
	protected IDragAndDrop get_dragAndDrop() { }

	// RVA: 0x17ED3A4
	internal virtual bool get_isEditorContext() { }

	// RVA: 0x17ED500
	internal void .ctor(VisualElement target) { }

	// RVA: 0x17ED964
	private void RegisterCallbacksFromTarget(AttachToPanelEvent evt) { }

	// RVA: 0x17ED654
	private void RegisterCallbacksFromTarget() { }

	// RVA: 0x17ED968
	private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt) { }

	// RVA: 0x17ED970
	internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents) { }

	// RVA: -1
	protected abstract bool CanStartDrag(Vector3 pointerPosition) { }

	// RVA: -1
	protected internal abstract StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: -1
	protected internal abstract void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: -1
	protected internal abstract void OnDrop(Vector3 pointerPosition) { }

	// RVA: -1
	protected abstract void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x17EDD70
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x17EDE70
	internal void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x17EE128
	private void OnPointerLeaveEvent(PointerLeaveEvent evt) { }

	// RVA: 0x17EE138
	private void OnPointerCancelEvent(PointerCancelEvent evt) { }

	// RVA: 0x17EE280
	private void OnPointerCapturedOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x17EE39C
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x17EE028
	private DragEventsProcessor GetDropTarget(Vector2 position) { }

}

// Namespace: UnityEngine.UIElements
internal interface ICollectionDragAndDropController
{}

// Namespace: UnityEngine.UIElements
internal interface IDragAndDrop
{
	// Methods

	// RVA: -1
	public abstract void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	// RVA: -1
	public abstract void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: -1
	public abstract void AcceptDrag() { }

	// RVA: -1
	public abstract void DragCleanup() { }

	// RVA: -1
	public abstract void SetVisualMode(DragVisualMode visualMode) { }

	// RVA: -1
	public abstract DragAndDropData get_data() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class DragAndDropData
{
	// Methods

	// RVA: -1
	public abstract object GetGenericData(string key) { }

	// RVA: -1
	public abstract object get_source() { }

	// RVA: 0x17ED32C
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal interface IListDragAndDropArgs
{
	// Methods

	// RVA: -1
	public abstract int get_insertAtIndex() { }

	// RVA: -1
	public abstract int get_parentId() { }

	// RVA: -1
	public abstract int get_childIndex() { }

	// RVA: -1
	public abstract DragAndDropData get_dragAndDropData() { }

	// RVA: -1
	public abstract DragAndDropPosition get_dragAndDropPosition() { }

}

// Namespace: UnityEngine.UIElements
internal struct DragAndDropArgs
{
	// Fields
	private object <target>k__BackingField; // 0x10
	private int <insertAtIndex>k__BackingField; // 0x18
	private int <parentId>k__BackingField; // 0x1C
	private int <childIndex>k__BackingField; // 0x20
	private DragAndDropPosition <dragAndDropPosition>k__BackingField; // 0x24
	private DragAndDropData <dragAndDropData>k__BackingField; // 0x28

	// Methods

	// RVA: 0x17EE688
	public void set_target(object value) { }

	// RVA: 0x17EE690
	public int get_insertAtIndex() { }

	// RVA: 0x17EE698
	public void set_insertAtIndex(int value) { }

	// RVA: 0x17EE6A0
	public int get_parentId() { }

	// RVA: 0x17EE6A8
	public void set_parentId(int value) { }

	// RVA: 0x17EE6B0
	public int get_childIndex() { }

	// RVA: 0x17EE6B8
	public void set_childIndex(int value) { }

	// RVA: 0x17EE6C0
	public DragAndDropPosition get_dragAndDropPosition() { }

	// RVA: 0x17EE6C8
	public void set_dragAndDropPosition(DragAndDropPosition value) { }

	// RVA: 0x17EE6D0
	public DragAndDropData get_dragAndDropData() { }

	// RVA: 0x17EE6D8
	public void set_dragAndDropData(DragAndDropData value) { }

}

// Namespace: UnityEngine.UIElements
internal enum DragAndDropPosition
{
	// Fields
	public int value__; // 0x10
	public const DragAndDropPosition OverItem = 0;
	public const DragAndDropPosition BetweenItems = 1;
	public const DragAndDropPosition OutsideItems = 2;
}

// Namespace: UnityEngine.UIElements
internal interface IDragAndDropController<T0>
{
	// Methods

	// RVA: -1
	public abstract bool CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIds) { }

	// RVA: -1
	public abstract StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, bool skipText) { }

	// RVA: -1
	public abstract DragVisualMode HandleDragAndDrop(TArgs args) { }

	// RVA: -1
	public abstract void OnDrop(TArgs args) { }

	// RVA: 0x30A2378
	public virtual void DragCleanup() { }

	// RVA: -1
	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	// RVA: 0x30A17DC
	public virtual System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds() { }

}

// Namespace: UnityEngine.UIElements
internal enum DragVisualMode
{
	// Fields
	public int value__; // 0x10
	public const DragVisualMode None = 0;
	public const DragVisualMode Copy = 1;
	public const DragVisualMode Move = 2;
	public const DragVisualMode Rejected = 3;
}

// Namespace: UnityEngine.UIElements
internal struct CanStartDragArgs
{
	// Fields
	public readonly VisualElement draggedElement; // 0x10
	public readonly int id; // 0x18
	public readonly System.Collections.Generic.IEnumerable<System.Int32> selectedIds; // 0x20

	// Methods

	// RVA: 0x17EE6E0
	internal void .ctor(VisualElement draggedElement, int id, System.Collections.Generic.IEnumerable<System.Int32> selectedIds) { }

}

// Namespace: UnityEngine.UIElements
internal struct SetupDragAndDropArgs
{
	// Fields
	public readonly VisualElement draggedElement; // 0x10
	public readonly System.Collections.Generic.IEnumerable<System.Int32> selectedIds; // 0x18
	public readonly StartDragArgs startDragArgs; // 0x20

	// Methods

	// RVA: 0x17EE724
	internal void .ctor(VisualElement draggedElement, System.Collections.Generic.IEnumerable<System.Int32> selectedIds, StartDragArgs startDragArgs) { }

}

// Namespace: UnityEngine.UIElements
internal struct HandleDragAndDropArgs
{
	// Fields
	private readonly DragAndDropArgs m_DragAndDropArgs; // 0x10
	private readonly Vector2 <position>k__BackingField; // 0x30

	// Methods

	// RVA: 0x17EE77C
	internal void .ctor(Vector2 position, DragAndDropArgs dragAndDropArgs) { }

}

// Namespace: UnityEngine.UIElements
internal struct StartDragArgs
{
	// Fields
	private readonly string <title>k__BackingField; // 0x10
	private readonly DragVisualMode <visualMode>k__BackingField; // 0x18
	private Hashtable <genericData>k__BackingField; // 0x20
	private System.Collections.Generic.IEnumerable<UnityEngine.Object> <unityObjectReferences>k__BackingField; // 0x28

	// Methods

	// RVA: 0x17EC634
	public void .ctor(string title, DragVisualMode visualMode) { }

	// RVA: 0x17EE790
	public string get_title() { }

	// RVA: 0x17EE798
	public DragVisualMode get_visualMode() { }

	// RVA: 0x17EE7A0
	internal Hashtable get_genericData() { }

	// RVA: 0x17EE7A8
	private void set_genericData(Hashtable value) { }

	// RVA: 0x17EE7B0
	internal System.Collections.Generic.IEnumerable<UnityEngine.Object> get_unityObjectReferences() { }

	// RVA: 0x17EE7B8
	private void set_unityObjectReferences(System.Collections.Generic.IEnumerable<UnityEngine.Object> value) { }

	// RVA: 0x17EE7C0
	public void SetGenericData(string key, object data) { }

}

// Namespace: UnityEngine.UIElements
internal interface IReorderable
{
	// Methods

	// RVA: -1
	public abstract bool get_enableReordering() { }

	// RVA: -1
	public abstract void set_enableReordering(bool value) { }

}

// Namespace: 
internal struct DragPosition
{
	// Fields
	public int insertAtIndex; // 0x10
	public int parentId; // 0x14
	public int childIndex; // 0x18
	public ReusableCollectionItem recycledItem; // 0x20
	public DragAndDropPosition dropPosition; // 0x28

	// Methods

	// RVA: 0x17F11B8
	public bool Equals(DragPosition other) { }

	// RVA: 0x17F3680
	public override bool Equals(object obj) { }

	// RVA: 0x17F3768
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal class ListViewDragger
{
	// Fields
	private DragPosition m_LastDragPosition; // 0x30
	private VisualElement m_DragHoverBar; // 0x50
	private VisualElement m_DragHoverItemMarker; // 0x58
	private VisualElement m_DragHoverSiblingMarker; // 0x60
	private float m_LeftIndentation; // 0x68
	private float m_SiblingBottom; // 0x6C
	private ICollectionDragAndDropController <dragAndDropController>k__BackingField; // 0x70

	// Methods

	// RVA: 0x17EE860
	protected BaseVerticalCollectionView get_targetView() { }

	// RVA: 0x17EE8E8
	protected ScrollView get_targetScrollView() { }

	// RVA: 0x17EE968
	public ICollectionDragAndDropController get_dragAndDropController() { }

	// RVA: 0x17EE970
	public void set_dragAndDropController(ICollectionDragAndDropController value) { }

	// RVA: 0x17EE978
	public void .ctor(BaseVerticalCollectionView listView) { }

	// RVA: 0x17EE984
	protected override bool CanStartDrag(Vector3 pointerPosition) { }

	// RVA: 0x17EF260
	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: 0x17EF7F0
	protected internal override void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x17EF9F4
	private DragVisualMode GetVisualMode(Vector3 pointerPosition, DragPosition dragPosition) { }

	// RVA: 0x17F0D18
	protected internal override void OnDrop(Vector3 pointerPosition) { }

	// RVA: 0x17EFBE8
	internal void HandleDragAndScroll(Vector2 pointerPosition) { }

	// RVA: 0x17EFFA0
	private void HandleAutoExpansion(Vector2 pointerPosition) { }

	// RVA: 0x17F0090
	private void ApplyDragAndDropUI(DragPosition dragPosition) { }

	// RVA: 0x17F1CE8
	protected virtual bool TryGetDragPosition(Vector2 pointerPosition, DragPosition dragPosition) { }

	// RVA: 0x17F22D4
	private void HandleTreePosition(Vector2 pointerPosition, DragPosition dragPosition) { }

	// RVA: 0x17F2454
	private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(DragPosition dragPosition, Vector2 pointerPosition) { }

	// RVA: 0x17F29C8
	private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, int previousItemId, int nextItemId) { }

	// RVA: 0x17F0B6C
	protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition) { }

	// RVA: 0x17F2D54
	private float GetHoverBarTopPosition(ReusableCollectionItem item) { }

	// RVA: 0x17F1CC0
	private void PlaceHoverBarAtElement(ReusableCollectionItem item) { }

	// RVA: 0x17F123C
	private void PlaceHoverBarAt(float top, float indentationPadding, float siblingBottom) { }

	// RVA: 0x17F2E44
	protected override void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x17EEE8C
	protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition) { }

	// RVA: 0x17F3540
	private void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(GeometryChangedEvent e) { }

}

// Namespace: UnityEngine.UIElements
internal static class ListViewDraggerExtension
{
	// Methods

	// RVA: 0x17EC304
	public static ReusableCollectionItem GetRecycledItemFromId(BaseVerticalCollectionView listView, int id) { }

	// RVA: 0x17F1990
	public static ReusableCollectionItem GetRecycledItemFromIndex(BaseVerticalCollectionView listView, int index) { }

}

// Namespace: UnityEngine.UIElements
internal class ListViewDraggerAnimated
{
	// Fields
	private int m_DragStartIndex; // 0x78
	private int m_CurrentIndex; // 0x7C
	private float m_SelectionHeight; // 0x80
	private float m_LocalOffsetOnStart; // 0x84
	private Vector3 m_CurrentPointerPosition; // 0x88
	private ReusableCollectionItem m_Item; // 0x98
	private ReusableCollectionItem m_OffsetItem; // 0xA0
	private bool <isDragging>k__BackingField; // 0xA8

	// Methods

	// RVA: 0x17F37D0
	public bool get_isDragging() { }

	// RVA: 0x17F37D8
	private void set_isDragging(bool value) { }

	// RVA: 0x17F37E0
	public ReusableCollectionItem get_draggedItem() { }

	// RVA: 0x17F37E8
	protected override bool get_supportsDragEvents() { }

	// RVA: 0x17F37F0
	public void .ctor(BaseVerticalCollectionView listView) { }

	// RVA: 0x17F37FC
	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: 0x17F4644
	protected internal override void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x17F41C0
	private void Animate(ReusableCollectionItem element, float paddingTop) { }

	// RVA: 0x17F513C
	protected internal override void OnDrop(Vector3 pointerPosition) { }

	// RVA: 0x17F5678
	protected override void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x17F567C
	protected override bool TryGetDragPosition(Vector2 pointerPosition, DragPosition dragPosition) { }

}

// Namespace: UnityEngine.UIElements
internal class ListViewReorderableDragAndDropController
{
	// Fields
	protected readonly BaseListView m_ListView; // 0x28

	// Methods

	// RVA: 0x17F56C0
	public void .ctor(BaseListView view) { }

	// RVA: 0x17F56F0
	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: 0x17F586C
	public override void OnDrop(IListDragAndDropArgs args) { }

}

// Namespace: 
protected class DropData
{
	// Fields
	public int[] expandedIdsBeforeDrag; // 0x10
	public int[] draggedIds; // 0x18
	public int lastItemId; // 0x20
	public float expandItemBeginTimerMs; // 0x24
	public Vector2 expandItemBeginPosition; // 0x28

	// Methods

	// RVA: 0x17F5C04
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class TreeViewReorderableDragAndDropController
{
	// Fields
	protected DropData m_DropData; // 0x28
	protected readonly BaseTreeView m_TreeView; // 0x30
	private IVisualElementScheduledItem m_ExpandDropItemScheduledItem; // 0x38
	private Action m_ExpandDropItemCallback; // 0x40

	// Methods

	// RVA: 0x17F5B14
	public void .ctor(BaseTreeView view) { }

	// RVA: 0x17F5C14
	protected override int CompareId(int id1, int id2) { }

	// RVA: 0x17F616C
	public override StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, bool skipText) { }

	// RVA: 0x17F6218
	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: 0x17F6324
	public override void OnDrop(IListDragAndDropArgs args) { }

	// RVA: 0x17F6AC8
	public override void DragCleanup() { }

	// RVA: 0x17F6C30
	private void RestoreExpanded(System.Collections.Generic.List<System.Int32> ids) { }

	// RVA: 0x17F6F80
	public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	// RVA: 0x17F70BC
	private void DelayExpandDropItem() { }

	// RVA: 0x17F7324
	private void ExpandDropItem() { }

}

// Namespace: UnityEngine.UIElements
public class DropdownMenuEventInfo
{
	// Fields
	private readonly EventModifiers <modifiers>k__BackingField; // 0x10
	private readonly Vector2 <mousePosition>k__BackingField; // 0x14
	private readonly Vector2 <localMousePosition>k__BackingField; // 0x1C
	private readonly Char <character>k__BackingField; // 0x24
	private readonly KeyCode <keyCode>k__BackingField; // 0x28

	// Methods

	// RVA: 0x17F7528
	public void .ctor(EventBase e) { }

}

// Namespace: UnityEngine.UIElements
public abstract class DropdownMenuItem
{
	// Methods

	// RVA: 0x17F7850
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DropdownMenuSeparator
{
	// Fields
	private readonly string <subMenuPath>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17F7858
	public void .ctor(string subMenuPath) { }

}

// Namespace: 
public enum Status
{
	// Fields
	public int value__; // 0x10
	public const Status None = 0;
	public const Status Normal = 1;
	public const Status Disabled = 2;
	public const Status Checked = 4;
	public const Status Hidden = 8;
}

// Namespace: UnityEngine.UIElements
public class DropdownMenuAction
{
	// Fields
	private readonly string <name>k__BackingField; // 0x10
	private Status <status>k__BackingField; // 0x18
	private DropdownMenuEventInfo <eventInfo>k__BackingField; // 0x20
	private object <userData>k__BackingField; // 0x28
	private readonly System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback; // 0x30
	private readonly System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback; // 0x38

	// Methods

	// RVA: 0x17F788C
	private void set_status(Status value) { }

	// RVA: 0x17F7894
	private void set_eventInfo(DropdownMenuEventInfo value) { }

	// RVA: 0x17F789C
	private void set_userData(object value) { }

	// RVA: 0x17F78A4
	public static Status AlwaysEnabled(DropdownMenuAction a) { }

	// RVA: 0x17F78AC
	public static Status AlwaysDisabled(DropdownMenuAction a) { }

	// RVA: 0x17F78B4
	public void .ctor(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData) { }

	// RVA: 0x17F7934
	public void UpdateActionStatus(DropdownMenuEventInfo eventInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Status status; // 0x10

	// Methods

	// RVA: 0x17F7BD0
	public void .ctor() { }

	// RVA: 0x17F824C
	internal Status <AppendAction>b__0(DropdownMenuAction e) { }

}

// Namespace: UnityEngine.UIElements
public class DropdownMenu
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> m_MenuItems; // 0x10
	private DropdownMenuEventInfo m_DropdownMenuEventInfo; // 0x18

	// Methods

	// RVA: 0x17F79A8
	public System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> MenuItems() { }

	// RVA: 0x17F79B0
	public void AppendAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData) { }

	// RVA: 0x17F7A98
	public void AppendAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, Status status) { }

	// RVA: 0x17F7BD8
	public void AppendSeparator(string subMenuPath) { }

	// RVA: 0x17F7D14
	public void InsertSeparator(string subMenuPath, int atIndex) { }

	// RVA: 0x17F7E60
	public void PrepareForDisplay(EventBase e) { }

	// RVA: 0x17F81C0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class DropdownUtility
{
	// Fields
	internal static System.Func<UnityEngine.UIElements.IGenericMenu> MakeDropdownFunc; // 0x0

	// Methods

	// RVA: 0x17F8254
	internal static IGenericMenu CreateDropdown() { }

}

// Namespace: UnityEngine.UIElements
internal enum DispatchMode
{
	// Fields
	public int value__; // 0x10
	public const DispatchMode Default = 1;
	public const DispatchMode Queued = 1;
	public const DispatchMode Immediate = 2;
}

// Namespace: UnityEngine.UIElements
public struct EventDispatcherGate
{
	// Fields
	private readonly EventDispatcher m_Dispatcher; // 0x10

	// Methods

	// RVA: 0x17F8304
	public void .ctor(EventDispatcher d) { }

	// RVA: 0x17F83A4
	public void Dispose() { }

	// RVA: 0x17F8570
	public bool Equals(EventDispatcherGate other) { }

	// RVA: 0x17F857C
	public override bool Equals(object obj) { }

	// RVA: 0x17F8608
	public override int GetHashCode() { }

}

// Namespace: 
private struct EventRecord
{
	// Fields
	public EventBase m_Event; // 0x10
	public IPanel m_Panel; // 0x18
}

// Namespace: 
private struct DispatchContext
{
	// Fields
	public UInt32 m_GateCount; // 0x10
	public System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> m_Queue; // 0x18
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.EventDispatcher.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17FAA9C
	private static void .cctor() { }

	// RVA: 0x17FAB08
	public void .ctor() { }

	// RVA: 0x17FAB10
	internal System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> <.cctor>b__40_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class EventDispatcher
{
	// Fields
	internal ClickDetector m_ClickDetector; // 0x10
	private System.Collections.Generic.List<UnityEngine.UIElements.IEventDispatchingStrategy> m_DispatchingStrategies; // 0x18
	private static readonly UnityEngine.UIElements.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord>> k_EventQueuePool; // 0x0
	private System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> m_Queue; // 0x20
	private readonly PointerDispatchState <pointerState>k__BackingField; // 0x28
	private UInt32 m_GateCount; // 0x30
	private UInt32 m_GateDepth; // 0x34
	internal const int k_MaxGateDepth = 500;
	internal const int k_NumberOfEventsWithStackInfo = 10;
	internal const int k_NumberOfEventsWithEventInfo = 100;
	private int m_DispatchStackFrame; // 0x38
	private EventBase m_CurrentEvent; // 0x40
	private System.Collections.Generic.Stack<UnityEngine.UIElements.EventDispatcher.DispatchContext> m_DispatchContexts; // 0x48
	private static readonly IEventDispatchingStrategy[] s_EditorStrategies; // 0x8
	private bool m_Immediate; // 0x50
	private bool <processingEvents>k__BackingField; // 0x51

	// Methods

	// RVA: 0x17F8620
	internal PointerDispatchState get_pointerState() { }

	// RVA: 0x17F8628
	internal static EventDispatcher CreateForRuntime(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies) { }

	// RVA: 0x17F868C
	private void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies) { }

	// RVA: 0x17F8898
	private bool get_dispatchImmediately() { }

	// RVA: 0x17F88B8
	private void set_processingEvents(bool value) { }

	// RVA: 0x17F88C0
	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	// RVA: 0x17F97C4
	private bool HandleRecursiveState(EventBase evt) { }

	// RVA: 0x17F8390
	internal void CloseGate() { }

	// RVA: 0x17F83C0
	internal void OpenGate() { }

	// RVA: 0x17F9C54
	private void ProcessEventQueue() { }

	// RVA: 0x17F8BA4
	private void ProcessEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x17FA050
	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	// RVA: 0x17FA5BC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal interface IPointerCaptureEventInternal
{
	// Methods

	// RVA: -1
	public abstract int get_pointerId() { }

}

// Namespace: UnityEngine.UIElements
public abstract class PointerCaptureEventBase<T0>
{
	// Fields
	private IEventHandler <relatedTarget>k__BackingField; // 0x0
	private int <pointerId>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A27C0
	private void set_relatedTarget(IEventHandler value) { }

	// RVA: 0x30A14A4
	public int get_pointerId() { }

	// RVA: 0x30A24F0
	private void set_pointerId(int value) { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x315B3A8
	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerCaptureOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17FACC8
	private static void .cctor() { }

	// RVA: 0x17FAD34
	public void .ctor() { }

	// RVA: 0x17FAD3C
	internal PointerCaptureOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class PointerCaptureOutEvent
{
	// Methods

	// RVA: 0x17FAB84
	private static void .cctor() { }

	// RVA: 0x17FAC74
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerCaptureEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17FAF0C
	private static void .cctor() { }

	// RVA: 0x17FAF78
	public void .ctor() { }

	// RVA: 0x17FAF80
	internal PointerCaptureEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class PointerCaptureEvent
{
	// Methods

	// RVA: 0x17FADC8
	private static void .cctor() { }

	// RVA: 0x17FAEB8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class MouseCaptureEventBase<T0>
{
	// Methods

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseCaptureOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17FB150
	private static void .cctor() { }

	// RVA: 0x17FB1BC
	public void .ctor() { }

	// RVA: 0x17FB1C4
	internal MouseCaptureOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseCaptureOutEvent
{
	// Methods

	// RVA: 0x17FB00C
	private static void .cctor() { }

	// RVA: 0x17FB0FC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseCaptureEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17FB394
	private static void .cctor() { }

	// RVA: 0x17FB400
	public void .ctor() { }

	// RVA: 0x17FB408
	internal MouseCaptureEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseCaptureEvent
{
	// Methods

	// RVA: 0x17FB250
	private static void .cctor() { }

	// RVA: 0x17FB340
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ChangeEvent.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A17DC
	internal UnityEngine.UIElements.ChangeEvent<T> <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ChangeEvent<T0>
{
	// Fields
	private T <previousValue>k__BackingField; // 0x0
	private T <newValue>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x315B3A8
	public T get_previousValue() { }

	// RVA: 0x315B3A8
	protected void set_previousValue(T value) { }

	// RVA: 0x315B3A8
	public T get_newValue() { }

	// RVA: 0x315B3A8
	protected void set_newValue(T value) { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x315B3A8
	public static UnityEngine.UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class CommandEventDispatchingStrategy
{
	// Methods

	// RVA: 0x17FB494
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x17FB4F4
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x17FAA84
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface ICommandEvent
{}

// Namespace: UnityEngine.UIElements
public abstract class CommandEventBase<T0>
{
	// Fields
	private string m_CommandName; // 0x0

	// Methods

	// RVA: 0x30A17DC
	public string get_commandName() { }

	// RVA: 0x30A27C0
	protected void set_commandName(string value) { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x315B3A8
	public static T GetPooled(Event systemEvent) { }

	// RVA: 0x315B3A8
	public static T GetPooled(string commandName) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ValidateCommandEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17FC09C
	private static void .cctor() { }

	// RVA: 0x17FC108
	public void .ctor() { }

	// RVA: 0x17FC110
	internal ValidateCommandEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ValidateCommandEvent
{
	// Methods

	// RVA: 0x17FBF58
	private static void .cctor() { }

	// RVA: 0x17FC048
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ExecuteCommandEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17FC2E0
	private static void .cctor() { }

	// RVA: 0x17FC34C
	public void .ctor() { }

	// RVA: 0x17FC354
	internal ExecuteCommandEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ExecuteCommandEvent
{
	// Methods

	// RVA: 0x17FC19C
	private static void .cctor() { }

	// RVA: 0x17FC28C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultDispatchingStrategy
{
	// Methods

	// RVA: 0x17FC3E0
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x17FC464
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x17FAA94
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ElementUnderPointer
{
	// Fields
	private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
	private VisualElement[] m_TopElementUnderPointer; // 0x18
	private IPointerEvent[] m_TriggerPointerEvent; // 0x20
	private IMouseEvent[] m_TriggerMouseEvent; // 0x28
	private Vector2[] m_PickingPointerPositions; // 0x30
	private bool[] m_IsPickingPointerTemporaries; // 0x38

	// Methods

	// RVA: 0x17FC688
	internal VisualElement GetTopElementUnderPointer(int pointerId, Vector2 pickPosition, bool isTemporary) { }

	// RVA: 0x17FC700
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x17FC734
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos) { }

	// RVA: 0x17FC8F4
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0x17FCAE0
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	// RVA: 0x17FCD90
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	// RVA: 0x17FCAE8
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary) { }

	// RVA: 0x17FCD98
	internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType) { }

	// RVA: 0x17FDBD8
	public void .ctor() { }

}

// Namespace: 
internal enum EventPropagation
{
	// Fields
	public int value__; // 0x10
	public const EventPropagation None = 0;
	public const EventPropagation Bubbles = 1;
	public const EventPropagation TricklesDown = 2;
	public const EventPropagation Cancellable = 4;
	public const EventPropagation SkipDisabledElements = 8;
	public const EventPropagation IgnoreCompositeRoots = 16;
}

// Namespace: 
private enum LifeCycleStatus
{
	// Fields
	public int value__; // 0x10
	public const LifeCycleStatus None = 0;
	public const LifeCycleStatus PropagationStopped = 1;
	public const LifeCycleStatus ImmediatePropagationStopped = 2;
	public const LifeCycleStatus DefaultPrevented = 4;
	public const LifeCycleStatus Dispatching = 8;
	public const LifeCycleStatus Pooled = 16;
	public const LifeCycleStatus IMGUIEventIsValid = 32;
	public const LifeCycleStatus StopDispatch = 64;
	public const LifeCycleStatus PropagateToIMGUI = 128;
	public const LifeCycleStatus Dispatched = 512;
	public const LifeCycleStatus Processed = 1024;
	public const LifeCycleStatus ProcessedByFocusController = 2048;
}

// Namespace: UnityEngine.UIElements
public abstract class EventBase
{
	// Fields
	private static Int64 s_LastTypeId; // 0x0
	private readonly EventCategory <eventCategory>k__BackingField; // 0x10
	private static UInt64 s_NextEventId; // 0x8
	private Int64 <timestamp>k__BackingField; // 0x18
	private UInt64 <eventId>k__BackingField; // 0x20
	private UInt64 <triggerEventId>k__BackingField; // 0x28
	private EventPropagation <propagation>k__BackingField; // 0x30
	private PropagationPaths <path>k__BackingField; // 0x38
	private LifeCycleStatus <lifeCycleStatus>k__BackingField; // 0x40
	private IEventHandler <leafTarget>k__BackingField; // 0x48
	private IEventHandler m_Target; // 0x50
	private readonly System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> <skipElements>k__BackingField; // 0x58
	private PropagationPhase <propagationPhase>k__BackingField; // 0x60
	private IEventHandler m_CurrentTarget; // 0x68
	private Event m_ImguiEvent; // 0x70
	private Vector2 <originalMousePosition>k__BackingField; // 0x78

	// Methods

	// RVA: 0x17FDD88
	protected static Int64 RegisterEventType() { }

	// RVA: 0x17FDDDC
	public virtual Int64 get_eventTypeId() { }

	// RVA: 0x17FDDE4
	internal EventCategory get_eventCategory() { }

	// RVA: 0x17FDDEC
	public Int64 get_timestamp() { }

	// RVA: 0x17FDDF4
	private void set_timestamp(Int64 value) { }

	// RVA: 0x17FDDFC
	internal UInt64 get_eventId() { }

	// RVA: 0x17FDE04
	private void set_eventId(UInt64 value) { }

	// RVA: 0x17FDE0C
	private void set_triggerEventId(UInt64 value) { }

	// RVA: 0x17FDE14
	internal void SetTriggerEventId(UInt64 id) { }

	// RVA: 0x17FDE1C
	internal EventPropagation get_propagation() { }

	// RVA: 0x17FDE24
	internal void set_propagation(EventPropagation value) { }

	// RVA: 0x17FDE2C
	internal PropagationPaths get_path() { }

	// RVA: 0x17FDE34
	internal void set_path(PropagationPaths value) { }

	// RVA: 0x17FDE3C
	private LifeCycleStatus get_lifeCycleStatus() { }

	// RVA: 0x17FDE44
	private void set_lifeCycleStatus(LifeCycleStatus value) { }

	// RVA: 0x17FDE4C
	protected virtual void PreDispatch() { }

	// RVA: 0x17FDE50
	protected internal virtual void PreDispatch(IPanel panel) { }

	// RVA: 0x17FDE5C
	protected virtual void PostDispatch() { }

	// RVA: 0x17FDE60
	protected internal virtual void PostDispatch(IPanel panel) { }

	// RVA: 0x17FDEB4
	public bool get_bubbles() { }

	// RVA: 0x17FDEC0
	public bool get_tricklesDown() { }

	// RVA: 0x17FA3E0
	internal bool get_bubblesOrTricklesDown() { }

	// RVA: 0x17FDECC
	internal bool get_skipDisabledElements() { }

	// RVA: 0x17FDED8
	internal void set_skipDisabledElements(bool value) { }

	// RVA: 0x17FDEF8
	internal bool get_ignoreCompositeRoots() { }

	// RVA: 0x17FDF04
	internal void set_ignoreCompositeRoots(bool value) { }

	// RVA: 0x17FDF24
	internal IEventHandler get_leafTarget() { }

	// RVA: 0x17FDF2C
	private void set_leafTarget(IEventHandler value) { }

	// RVA: 0x17FA5B4
	public IEventHandler get_target() { }

	// RVA: 0x17FA3F4
	public void set_target(IEventHandler value) { }

	// RVA: 0x17FDF34
	internal System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> get_skipElements() { }

	// RVA: 0x17FB804
	internal bool Skip(IEventHandler h) { }

	// RVA: 0x17FA044
	public bool get_isPropagationStopped() { }

	// RVA: 0x17FDF3C
	private void set_isPropagationStopped(bool value) { }

	// RVA: 0x17EE118
	public void StopPropagation() { }

	// RVA: 0x17FDF50
	public bool get_isImmediatePropagationStopped() { }

	// RVA: 0x17FDF5C
	private void set_isImmediatePropagationStopped(bool value) { }

	// RVA: 0x17FDF7C
	public void StopImmediatePropagation() { }

	// RVA: 0x17FDF8C
	public bool get_isDefaultPrevented() { }

	// RVA: 0x17FDF98
	private void set_isDefaultPrevented(bool value) { }

	// RVA: 0x17FB868
	public void PreventDefault() { }

	// RVA: 0x17FDFB8
	public PropagationPhase get_propagationPhase() { }

	// RVA: 0x17FDFC0
	internal void set_propagationPhase(PropagationPhase value) { }

	// RVA: 0x17FDFC8
	public virtual IEventHandler get_currentTarget() { }

	// RVA: 0x17FDFD0
	internal virtual void set_currentTarget(IEventHandler value) { }

	// RVA: 0x17FE0D8
	public bool get_dispatch() { }

	// RVA: 0x17FE0E4
	internal void set_dispatch(bool value) { }

	// RVA: 0x17F8AF8
	internal void MarkReceivedByDispatcher() { }

	// RVA: 0x17FE124
	private bool get_dispatched() { }

	// RVA: 0x17FE104
	private void set_dispatched(bool value) { }

	// RVA: 0x17FE130
	internal bool get_processed() { }

	// RVA: 0x17FDE94
	private void set_processed(bool value) { }

	// RVA: 0x17FE13C
	internal bool get_processedByFocusController() { }

	// RVA: 0x17FE148
	internal void set_processedByFocusController(bool value) { }

	// RVA: 0x17FA038
	internal bool get_stopDispatch() { }

	// RVA: 0x17FBF38
	internal void set_stopDispatch(bool value) { }

	// RVA: 0x17FB880
	internal bool get_propagateToIMGUI() { }

	// RVA: 0x17FBF18
	internal void set_propagateToIMGUI(bool value) { }

	// RVA: 0x17FE168
	private bool get_imguiEventIsValid() { }

	// RVA: 0x17FE174
	private void set_imguiEventIsValid(bool value) { }

	// RVA: 0x17F8B8C
	public Event get_imguiEvent() { }

	// RVA: 0x17FE194
	protected void set_imguiEvent(Event value) { }

	// RVA: 0x17FE278
	public Vector2 get_originalMousePosition() { }

	// RVA: 0x17FE280
	private void set_originalMousePosition(Vector2 value) { }

	// RVA: 0x17FE288
	protected virtual void Init() { }

	// RVA: 0x17FE28C
	private void LocalInit() { }

	// RVA: 0x17FE480
	internal void .ctor(EventCategory category) { }

	// RVA: 0x17FE534
	protected bool get_pooled() { }

	// RVA: 0x17FE460
	protected void set_pooled(bool value) { }

	// RVA: -1
	internal abstract void Acquire() { }

	// RVA: -1
	public abstract void Dispose() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.EventBase.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal T <.cctor>b__15_0() { }

}

// Namespace: UnityEngine.UIElements
public abstract class EventBase<T0>
{
	// Fields
	private static readonly Int64 s_TypeId; // 0x0
	private static readonly UnityEngine.UIElements.ObjectPool<T> s_Pool; // 0x0
	private int m_RefCount; // 0x0
	internal static readonly EventCategory EventCategory; // 0x0

	// Methods

	// RVA: 0x30A7C50
	internal static void SetCreateFunction(System.Func<T> createMethod) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

	// RVA: 0x30A4C30
	public static Int64 TypeId() { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x315B3A8
	public static T GetPooled() { }

	// RVA: 0x315B3A8
	internal static T GetPooled(EventBase e) { }

	// RVA: 0x315B3A8
	private static void ReleasePooled(T evt) { }

	// RVA: 0x30A2378
	internal override void Acquire() { }

	// RVA: 0x30A2378
	public sealed override void Dispose() { }

	// RVA: 0x30A16B0
	public override Int64 get_eventTypeId() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public sealed class EventCallback<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(TEventType evt) { }

}

// Namespace: UnityEngine.UIElements
public sealed class EventCallback<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(TEventType evt, TCallbackArgs userArgs) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class EventCallbackFunctorBase
{
	// Fields
	private readonly CallbackPhase <phase>k__BackingField; // 0x10
	private readonly InvokePolicy <invokePolicy>k__BackingField; // 0x14

	// Methods

	// RVA: 0x17FE540
	public CallbackPhase get_phase() { }

	// RVA: 0x17FE548
	public InvokePolicy get_invokePolicy() { }

	// RVA: 0x17FE550
	protected void .ctor(CallbackPhase phase, InvokePolicy invokePolicy) { }

	// RVA: -1
	public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: -1
	public abstract bool IsEquivalentTo(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x17FE588
	protected bool PhaseMatches(PropagationPhase propagationPhase) { }

}

// Namespace: UnityEngine.UIElements
internal class EventCallbackFunctor<T0>
{
	// Fields
	private readonly UnityEngine.UIElements.EventCallback<TEventType> m_Callback; // 0x0
	private readonly Int64 m_EventTypeId; // 0x0

	// Methods

	// RVA: -1
	public void .ctor(UnityEngine.UIElements.EventCallback<TEventType> callback, CallbackPhase phase, InvokePolicy invokePolicy) { }

	// RVA: 0x30A2828
	public override void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: -1
	public override bool IsEquivalentTo(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

}

// Namespace: UnityEngine.UIElements
internal class EventCallbackFunctor<T0, T1>
{
	// Fields
	private readonly UnityEngine.UIElements.EventCallback<TEventType,TCallbackArgs> m_Callback; // 0x0
	private readonly Int64 m_EventTypeId; // 0x0
	private TCallbackArgs <userArgs>k__BackingField; // 0x0

	// Methods

	// RVA: 0x315B3A8
	internal TCallbackArgs get_userArgs() { }

	// RVA: 0x315B3A8
	internal void set_userArgs(TCallbackArgs value) { }

	// RVA: 0x315B3A8
	public void .ctor(UnityEngine.UIElements.EventCallback<TEventType,TCallbackArgs> callback, TCallbackArgs userArgs, CallbackPhase phase, InvokePolicy invokePolicy) { }

	// RVA: 0x30A2828
	public override void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: -1
	public override bool IsEquivalentTo(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

}

// Namespace: UnityEngine.UIElements
public enum TrickleDown
{
	// Fields
	public int value__; // 0x10
	public const TrickleDown NoTrickleDown = 0;
	public const TrickleDown TrickleDown = 1;
}

// Namespace: UnityEngine.UIElements
internal enum CallbackPhase
{
	// Fields
	public int value__; // 0x10
	public const CallbackPhase TargetAndBubbleUp = 1;
	public const CallbackPhase TrickleDownAndTarget = 2;
}

// Namespace: UnityEngine.UIElements
internal enum InvokePolicy
{
	// Fields
	public int value__; // 0x10
	public const InvokePolicy Default = 0;
	public const InvokePolicy IncludeDisabled = 1;
}

// Namespace: UnityEngine.UIElements
internal class EventCallbackListPool
{
	// Fields
	private readonly System.Collections.Generic.Stack<UnityEngine.UIElements.EventCallbackList> m_Stack; // 0x10

	// Methods

	// RVA: 0x17FE5C4
	public EventCallbackList Get(EventCallbackList initializer) { }

	// RVA: 0x17FEA98
	public void Release(EventCallbackList element) { }

	// RVA: 0x17FEC2C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class EventCallbackList
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.EventCallbackFunctorBase> m_List; // 0x10
	private int <trickleDownCallbackCount>k__BackingField; // 0x18
	private int <bubbleUpCallbackCount>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x17FECB8
	public int get_trickleDownCallbackCount() { }

	// RVA: 0x17FECC0
	private void set_trickleDownCallbackCount(int value) { }

	// RVA: 0x17FECC8
	public int get_bubbleUpCallbackCount() { }

	// RVA: 0x17FECD0
	private void set_bubbleUpCallbackCount(int value) { }

	// RVA: 0x17FE7E0
	public void .ctor() { }

	// RVA: 0x17FE738
	public void .ctor(EventCallbackList source) { }

	// RVA: 0x17FECD8
	public bool Contains(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x17FECF4
	public EventCallbackFunctorBase Find(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x17FEE00
	public bool Remove(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x17FEF38
	public void Add(EventCallbackFunctorBase item) { }

	// RVA: 0x17FE874
	public void AddRange(EventCallbackList list) { }

	// RVA: 0x17FEFE0
	public int get_Count() { }

	// RVA: 0x17FF02C
	public EventCallbackFunctorBase get_Item(int i) { }

	// RVA: 0x17FEB80
	public void Clear() { }

}

// Namespace: UnityEngine.UIElements
internal class EventCallbackRegistry
{
	// Fields
	private static readonly EventCallbackListPool s_ListPool; // 0x0
	private EventCallbackList m_Callbacks; // 0x10
	private EventCallbackList m_TemporaryCallbacks; // 0x18
	private int m_IsInvoking; // 0x20

	// Methods

	// RVA: 0x17FF0A4
	private static EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	// RVA: 0x17FF130
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	// RVA: 0x17FF1BC
	public void .ctor() { }

	// RVA: 0x17FF1E4
	private EventCallbackList GetCallbackListForWriting() { }

	// RVA: 0x17FF43C
	private EventCallbackList GetCallbackListForReading() { }

	// RVA: 0x17FF458
	private bool UnregisterCallback(Int64 eventTypeId, Delegate callback, TrickleDown useTrickleDown) { }

	// RVA: -1
	public void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown, InvokePolicy invokePolicy) { }

	// RVA: 0x315B3A8
	public void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType,TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown, InvokePolicy invokePolicy) { }

	// RVA: 0x30A13B0
	public bool UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown) { }

	// RVA: 0x17FF4BC
	public void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: 0x17FF858
	public bool HasTrickleDownHandlers() { }

	// RVA: 0x17FF878
	public bool HasBubbleHandlers() { }

	// RVA: 0x17FF898
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogCall
{
	// Methods

	// RVA: 0x17FF98C
	public void .ctor(Delegate callback, EventBase evt) { }

	// RVA: 0x17FF990
	public void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogIMGUICall
{
	// Methods

	// RVA: 0x17FF994
	public void .ctor(EventBase evt) { }

	// RVA: 0x17FF998
	public void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogExecuteDefaultAction
{
	// Methods

	// RVA: 0x17FF99C
	public void .ctor(EventBase evt) { }

	// RVA: 0x17FF9A0
	public void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal class EventDebugger
{
	// Methods

	// RVA: 0x17FA3F0
	public static void LogPropagationPaths(EventBase evt, PropagationPaths paths) { }

}

// Namespace: UnityEngine.UIElements
public interface IEventHandler
{
	// Methods

	// RVA: -1
	public abstract void SendEvent(EventBase e) { }

	// RVA: -1
	public abstract void HandleEvent(EventBase evt) { }

}

// Namespace: UnityEngine.UIElements
public abstract class CallbackEventHandler
{
	// Fields
	internal bool isIMGUIContainer; // 0x10
	private EventCallbackRegistry m_CallbackRegistry; // 0x18
	internal const string ExecuteDefaultActionName = "ExecuteDefaultAction";
	internal const string ExecuteDefaultActionAtTargetName = "ExecuteDefaultActionAtTarget";

	// Methods

	// RVA: 0x30A2828
	public void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown) { }

	// RVA: 0x30A2378
	private void AddEventCategories() { }

	// RVA: 0x315B3A8
	public void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType,TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown) { }

	// RVA: -1
	internal void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown) { }

	// RVA: 0x30A2828
	public void UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown) { }

	// RVA: -1
	public abstract void SendEvent(EventBase e) { }

	// RVA: -1
	internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: 0x17FF9A4
	internal void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0x17FFA20
	internal void HandleEventAtTargetAndDefaultPhase(EventBase evt) { }

	// RVA: 0x17FFA14
	internal void HandleEventAtCurrentTargetAndPhase(EventBase evt) { }

	// RVA: 0x17FFAAC
	private void UnityEngine.UIElements.IEventHandler.HandleEvent(EventBase evt) { }

	// RVA: 0x17FFAB8
	public virtual void HandleEvent(EventBase evt) { }

	// RVA: 0x17FFD6C
	public bool HasTrickleDownHandlers() { }

	// RVA: 0x17FFD94
	public bool HasBubbleUpHandlers() { }

	// RVA: 0x17FFDBC
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x17FFDC0
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x17FFDC4
	internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt) { }

	// RVA: 0x17FFDC8
	internal virtual void ExecuteDefaultActionDisabled(EventBase evt) { }

	// RVA: 0x17FFDCC
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class FocusEventBase<T0>
{
	// Fields
	private Focusable <relatedTarget>k__BackingField; // 0x0
	private FocusChangeDirection <direction>k__BackingField; // 0x0
	private FocusController <focusController>k__BackingField; // 0x0
	private bool <IsFocusDelegated>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A17DC
	public Focusable get_relatedTarget() { }

	// RVA: 0x30A27C0
	private void set_relatedTarget(Focusable value) { }

	// RVA: 0x30A17DC
	public FocusChangeDirection get_direction() { }

	// RVA: 0x30A27C0
	private void set_direction(FocusChangeDirection value) { }

	// RVA: 0x30A17DC
	protected FocusController get_focusController() { }

	// RVA: 0x30A27C0
	private void set_focusController(FocusController value) { }

	// RVA: 0x30A1224
	internal bool get_IsFocusDelegated() { }

	// RVA: 0x30A2404
	private void set_IsFocusDelegated(bool value) { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x315B3A8
	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.FocusOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17FFF94
	private static void .cctor() { }

	// RVA: 0x1800000
	public void .ctor() { }

	// RVA: 0x1800008
	internal FocusOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class FocusOutEvent
{
	// Methods

	// RVA: 0x17FFDD8
	private static void .cctor() { }

	// RVA: 0x17FFEC8
	protected override void Init() { }

	// RVA: 0x17FFF28
	private void LocalInit() { }

	// RVA: 0x17FFF34
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.BlurEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1800260
	private static void .cctor() { }

	// RVA: 0x18002CC
	public void .ctor() { }

	// RVA: 0x18002D4
	internal BlurEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class BlurEvent
{
	// Methods

	// RVA: 0x180009C
	private static void .cctor() { }

	// RVA: 0x180018C
	protected internal override void PreDispatch(IPanel panel) { }

	// RVA: 0x180020C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.FocusInEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180051C
	private static void .cctor() { }

	// RVA: 0x1800588
	public void .ctor() { }

	// RVA: 0x1800590
	internal FocusInEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class FocusInEvent
{
	// Methods

	// RVA: 0x1800360
	private static void .cctor() { }

	// RVA: 0x1800450
	protected override void Init() { }

	// RVA: 0x18004B0
	private void LocalInit() { }

	// RVA: 0x18004BC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.FocusEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1800820
	private static void .cctor() { }

	// RVA: 0x180088C
	public void .ctor() { }

	// RVA: 0x1800894
	internal FocusEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class FocusEvent
{
	// Methods

	// RVA: 0x1800624
	private static void .cctor() { }

	// RVA: 0x1800714
	protected internal override void PreDispatch(IPanel panel) { }

	// RVA: 0x18007CC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public enum PropagationPhase
{
	// Fields
	public int value__; // 0x10
	public const PropagationPhase None = 0;
	public const PropagationPhase TrickleDown = 1;
	public const PropagationPhase AtTarget = 2;
	public const PropagationPhase DefaultActionAtTarget = 5;
	public const PropagationPhase BubbleUp = 3;
	public const PropagationPhase DefaultAction = 4;
}

// Namespace: UnityEngine.UIElements
internal interface IEventDispatchingStrategy
{
	// Methods

	// RVA: -1
	public abstract bool CanDispatchEvent(EventBase evt) { }

	// RVA: -1
	public abstract void DispatchEvent(EventBase evt, IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal static class EventDispatchUtilities
{
	// Methods

	// RVA: 0x17FBD8C
	public static void PropagateEvent(EventBase evt) { }

	// RVA: 0x1800920
	private static void HandleEventAcrossPropagationPath(EventBase evt) { }

	// RVA: 0x17FB88C
	internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt) { }

	// RVA: 0x17FA43C
	public static void ExecuteDefaultAction(EventBase evt) { }

}

// Namespace: UnityEngine.UIElements
internal class IMGUIEventDispatchingStrategy
{
	// Methods

	// RVA: 0x18013D8
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x180145C
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x17FAA8C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.InputEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1801848
	private static void .cctor() { }

	// RVA: 0x18018B4
	public void .ctor() { }

	// RVA: 0x18018BC
	internal InputEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class InputEvent
{
	// Fields
	private string <previousData>k__BackingField; // 0x88
	private string <newData>k__BackingField; // 0x90

	// Methods

	// RVA: 0x1801528
	private static void .cctor() { }

	// RVA: 0x1801618
	protected void set_previousData(string value) { }

	// RVA: 0x1801620
	protected void set_newData(string value) { }

	// RVA: 0x1801628
	protected override void Init() { }

	// RVA: 0x18016A4
	private void LocalInit() { }

	// RVA: 0x18016E0
	public static InputEvent GetPooled(string previousData, string newData) { }

	// RVA: 0x18017A8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class KeyboardEventDispatchingStrategy
{
	// Methods

	// RVA: 0x1801994
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x18019F4
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x17FAA74
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IKeyboardEvent
{
	// Methods

	// RVA: -1
	public abstract EventModifiers get_modifiers() { }

	// RVA: -1
	public abstract Char get_character() { }

	// RVA: -1
	public abstract KeyCode get_keyCode() { }

}

// Namespace: UnityEngine.UIElements
public abstract class KeyboardEventBase<T0>
{
	// Fields
	private EventModifiers <modifiers>k__BackingField; // 0x0
	private Char <character>k__BackingField; // 0x0
	private KeyCode <keyCode>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A14A4
	public EventModifiers get_modifiers() { }

	// RVA: 0x30A24F0
	protected void set_modifiers(EventModifiers value) { }

	// RVA: -1
	public Char get_character() { }

	// RVA: -1
	protected void set_character(Char value) { }

	// RVA: 0x30A14A4
	public KeyCode get_keyCode() { }

	// RVA: 0x30A24F0
	protected void set_keyCode(KeyCode value) { }

	// RVA: 0x30A1224
	public bool get_shiftKey() { }

	// RVA: 0x30A1224
	public bool get_ctrlKey() { }

	// RVA: 0x30A1224
	public bool get_commandKey() { }

	// RVA: 0x30A1224
	public bool get_altKey() { }

	// RVA: 0x30A1224
	internal bool get_functionKey() { }

	// RVA: 0x30A1224
	public bool get_actionKey() { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x315B3A8
	public static T GetPooled(Event systemEvent) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.KeyDownEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1802990
	private static void .cctor() { }

	// RVA: 0x18029FC
	public void .ctor() { }

	// RVA: 0x1802A04
	internal KeyDownEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class KeyDownEvent
{
	// Methods

	// RVA: 0x1801D0C
	private static void .cctor() { }

	// RVA: 0x1801DFC
	internal void GetEquivalentImguiEvent(Event outImguiEvent) { }

	// RVA: 0x1801ECC
	protected internal override void PostDispatch(IPanel panel) { }

	// RVA: 0x1801FF0
	private void SendEquivalentNavigationEventIfAny(IPanel panel) { }

	// RVA: 0x180293C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class KeyboardEventExtensions
{
	// Methods

	// RVA: 0x18027B4
	internal static bool ShouldSendNavigationMoveEvent(KeyDownEvent e) { }

	// RVA: 0x1802A90
	internal static bool ShouldSendNavigationMoveEventRuntime(Event e) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.KeyUpEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1802C2C
	private static void .cctor() { }

	// RVA: 0x1802C98
	public void .ctor() { }

	// RVA: 0x1802CA0
	internal KeyUpEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class KeyUpEvent
{
	// Methods

	// RVA: 0x1802AE8
	private static void .cctor() { }

	// RVA: 0x1802BD8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.GeometryChangedEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180309C
	private static void .cctor() { }

	// RVA: 0x1803108
	public void .ctor() { }

	// RVA: 0x1803110
	internal GeometryChangedEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class GeometryChangedEvent
{
	// Fields
	private Rect <oldRect>k__BackingField; // 0x84
	private Rect <newRect>k__BackingField; // 0x94
	private int <layoutPass>k__BackingField; // 0xA4

	// Methods

	// RVA: 0x1802D2C
	private static void .cctor() { }

	// RVA: 0x1802E1C
	public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect) { }

	// RVA: 0x1802F00
	protected override void Init() { }

	// RVA: 0x1802F7C
	private void LocalInit() { }

	// RVA: 0x1802FBC
	public Rect get_oldRect() { }

	// RVA: 0x1802FC8
	private void set_oldRect(Rect value) { }

	// RVA: 0x1802FD4
	public Rect get_newRect() { }

	// RVA: 0x1802FE0
	private void set_newRect(Rect value) { }

	// RVA: 0x1802FEC
	internal int get_layoutPass() { }

	// RVA: 0x1802FF4
	internal void set_layoutPass(int value) { }

	// RVA: 0x1802FFC
	public void .ctor() { }

}

// Namespace: 
private enum EventBehavior
{
	// Fields
	public int value__; // 0x10
	public const EventBehavior None = 0;
	public const EventBehavior IsCapturable = 1;
	public const EventBehavior IsSentExclusivelyToCapturingElement = 2;
}

// Namespace: UnityEngine.UIElements
internal class MouseCaptureDispatchingStrategy
{
	// Methods

	// RVA: 0x1803164
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1803204
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x17FAA6C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class MouseEventDispatchingStrategy
{
	// Methods

	// RVA: 0x18037D0
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1803830
	public void DispatchEvent(EventBase evt, IPanel iPanel) { }

	// RVA: 0x1803A70
	private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x1803AB0
	private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x1803BAC
	private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x180396C
	private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x1803DE8
	private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, VisualElement elementUnderMouse) { }

	// RVA: 0x1803D94
	private static bool IsDone(EventBase evt) { }

	// RVA: 0x17FAA7C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IMouseEvent
{
	// Methods

	// RVA: -1
	public abstract EventModifiers get_modifiers() { }

	// RVA: -1
	public abstract Vector2 get_mousePosition() { }

	// RVA: -1
	public abstract Vector2 get_localMousePosition() { }

	// RVA: -1
	public abstract Vector2 get_mouseDelta() { }

	// RVA: -1
	public abstract int get_clickCount() { }

	// RVA: -1
	public abstract int get_button() { }

	// RVA: -1
	public abstract int get_pressedButtons() { }

	// RVA: -1
	public abstract bool get_shiftKey() { }

	// RVA: -1
	public abstract bool get_ctrlKey() { }

	// RVA: -1
	public abstract bool get_commandKey() { }

	// RVA: -1
	public abstract bool get_altKey() { }

}

// Namespace: UnityEngine.UIElements
internal interface IMouseEventInternal
{
	// Methods

	// RVA: -1
	public abstract bool get_triggeredByOS() { }

	// RVA: -1
	public abstract void set_triggeredByOS(bool value) { }

	// RVA: -1
	public abstract bool get_recomputeTopElementUnderMouse() { }

	// RVA: -1
	public abstract void set_recomputeTopElementUnderMouse(bool value) { }

	// RVA: -1
	public abstract IPointerEvent get_sourcePointerEvent() { }

	// RVA: -1
	public abstract void set_sourcePointerEvent(IPointerEvent value) { }

}

// Namespace: UnityEngine.UIElements
public abstract class MouseEventBase<T0>
{
	// Fields
	private EventModifiers <modifiers>k__BackingField; // 0x0
	private Vector2 <mousePosition>k__BackingField; // 0x0
	private Vector2 <localMousePosition>k__BackingField; // 0x0
	private Vector2 <mouseDelta>k__BackingField; // 0x0
	private int <clickCount>k__BackingField; // 0x0
	private int <button>k__BackingField; // 0x0
	private int <pressedButtons>k__BackingField; // 0x0
	private bool <UnityEngine.UIElements.IMouseEventInternal.triggeredByOS>k__BackingField; // 0x0
	private bool <UnityEngine.UIElements.IMouseEventInternal.recomputeTopElementUnderMouse>k__BackingField; // 0x0
	private IPointerEvent <UnityEngine.UIElements.IMouseEventInternal.sourcePointerEvent>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A14A4
	public EventModifiers get_modifiers() { }

	// RVA: 0x30A24F0
	protected void set_modifiers(EventModifiers value) { }

	// RVA: -1
	public Vector2 get_mousePosition() { }

	// RVA: -1
	protected void set_mousePosition(Vector2 value) { }

	// RVA: -1
	public Vector2 get_localMousePosition() { }

	// RVA: -1
	internal void set_localMousePosition(Vector2 value) { }

	// RVA: -1
	public Vector2 get_mouseDelta() { }

	// RVA: -1
	protected void set_mouseDelta(Vector2 value) { }

	// RVA: 0x30A14A4
	public int get_clickCount() { }

	// RVA: 0x30A24F0
	protected void set_clickCount(int value) { }

	// RVA: 0x30A14A4
	public int get_button() { }

	// RVA: 0x30A24F0
	protected void set_button(int value) { }

	// RVA: 0x30A14A4
	public int get_pressedButtons() { }

	// RVA: 0x30A24F0
	protected void set_pressedButtons(int value) { }

	// RVA: 0x30A1224
	public bool get_shiftKey() { }

	// RVA: 0x30A1224
	public bool get_ctrlKey() { }

	// RVA: 0x30A1224
	public bool get_commandKey() { }

	// RVA: 0x30A1224
	public bool get_altKey() { }

	// RVA: 0x30A1224
	private bool UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS() { }

	// RVA: 0x30A2404
	private void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(bool value) { }

	// RVA: 0x30A1224
	private bool UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse() { }

	// RVA: 0x30A2404
	private void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(bool value) { }

	// RVA: 0x30A17DC
	private IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }

	// RVA: 0x30A27C0
	private void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(IPointerEvent value) { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x30A17DC
	public override IEventHandler get_currentTarget() { }

	// RVA: 0x30A27C0
	internal override void set_currentTarget(IEventHandler value) { }

	// RVA: 0x30A27C0
	protected internal override void PreDispatch(IPanel panel) { }

	// RVA: 0x30A27C0
	protected internal override void PostDispatch(IPanel panel) { }

	// RVA: 0x315B3A8
	public static T GetPooled(Event systemEvent) { }

	// RVA: 0x315B3A8
	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse) { }

	// RVA: 0x315B3A8
	public static T GetPooled(IMouseEvent triggerEvent) { }

	// RVA: 0x315B3A8
	protected static T GetPooled(IPointerEvent pointerEvent) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseDownEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18045C8
	private static void .cctor() { }

	// RVA: 0x1804634
	public void .ctor() { }

	// RVA: 0x180463C
	internal MouseDownEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseDownEvent
{
	// Methods

	// RVA: 0x180413C
	private static void .cctor() { }

	// RVA: 0x180422C
	protected override void Init() { }

	// RVA: 0x180428C
	private void LocalInit() { }

	// RVA: 0x1804298
	public void .ctor() { }

	// RVA: 0x18042F8
	private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

	// RVA: 0x18044C8
	internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent) { }

	// RVA: 0x1804548
	internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseUpEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1804BDC
	private static void .cctor() { }

	// RVA: 0x1804C48
	public void .ctor() { }

	// RVA: 0x1804C50
	internal MouseUpEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseUpEvent
{
	// Methods

	// RVA: 0x18046D0
	private static void .cctor() { }

	// RVA: 0x18047C0
	protected override void Init() { }

	// RVA: 0x1804820
	private void LocalInit() { }

	// RVA: 0x180482C
	public void .ctor() { }

	// RVA: 0x180488C
	private static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

	// RVA: 0x1804A5C
	internal static MouseUpEvent GetPooled(PointerUpEvent pointerEvent) { }

	// RVA: 0x1804ADC
	internal static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent) { }

	// RVA: 0x1804B5C
	internal static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseMoveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1804EF4
	private static void .cctor() { }

	// RVA: 0x1804F60
	public void .ctor() { }

	// RVA: 0x1804F68
	internal MouseMoveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseMoveEvent
{
	// Methods

	// RVA: 0x1804CE4
	private static void .cctor() { }

	// RVA: 0x1804DD4
	protected override void Init() { }

	// RVA: 0x1804E34
	private void LocalInit() { }

	// RVA: 0x1804E40
	public void .ctor() { }

	// RVA: 0x1804EA0
	internal static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ContextClickEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1805140
	private static void .cctor() { }

	// RVA: 0x18051AC
	public void .ctor() { }

	// RVA: 0x18051B4
	internal ContextClickEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ContextClickEvent
{
	// Methods

	// RVA: 0x1804FFC
	private static void .cctor() { }

	// RVA: 0x18050EC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.WheelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18055F8
	private static void .cctor() { }

	// RVA: 0x1805664
	public void .ctor() { }

	// RVA: 0x180566C
	internal WheelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class WheelEvent
{
	// Fields
	private Vector3 <delta>k__BackingField; // 0xB8

	// Methods

	// RVA: 0x1805240
	private static void .cctor() { }

	// RVA: 0x1805330
	public Vector3 get_delta() { }

	// RVA: 0x180533C
	private void set_delta(Vector3 value) { }

	// RVA: 0x1805348
	public static WheelEvent GetPooled(Event systemEvent) { }

	// RVA: 0x17EB434
	internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers) { }

	// RVA: 0x18053D0
	internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) { }

	// RVA: 0x1805454
	protected override void Init() { }

	// RVA: 0x18054F4
	private void LocalInit() { }

	// RVA: 0x1805558
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseEnterEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18058FC
	private static void .cctor() { }

	// RVA: 0x1805968
	public void .ctor() { }

	// RVA: 0x1805970
	internal MouseEnterEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseEnterEvent
{
	// Methods

	// RVA: 0x1805740
	private static void .cctor() { }

	// RVA: 0x1805830
	protected override void Init() { }

	// RVA: 0x1805890
	private void LocalInit() { }

	// RVA: 0x180589C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseLeaveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1805BC0
	private static void .cctor() { }

	// RVA: 0x1805C2C
	public void .ctor() { }

	// RVA: 0x1805C34
	internal MouseLeaveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseLeaveEvent
{
	// Methods

	// RVA: 0x1805A04
	private static void .cctor() { }

	// RVA: 0x1805AF4
	protected override void Init() { }

	// RVA: 0x1805B54
	private void LocalInit() { }

	// RVA: 0x1805B60
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseEnterWindowEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1805FFC
	private static void .cctor() { }

	// RVA: 0x1806068
	public void .ctor() { }

	// RVA: 0x1806070
	internal MouseEnterWindowEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseEnterWindowEvent
{
	// Methods

	// RVA: 0x1805CC8
	private static void .cctor() { }

	// RVA: 0x1805DB8
	protected override void Init() { }

	// RVA: 0x1805E18
	private void LocalInit() { }

	// RVA: 0x1805E24
	public void .ctor() { }

	// RVA: 0x1805E84
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseLeaveWindowEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18066B4
	private static void .cctor() { }

	// RVA: 0x1806720
	public void .ctor() { }

	// RVA: 0x1806728
	internal MouseLeaveWindowEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseLeaveWindowEvent
{
	// Methods

	// RVA: 0x1806104
	private static void .cctor() { }

	// RVA: 0x18061F4
	protected override void Init() { }

	// RVA: 0x18062D8
	private void LocalInit() { }

	// RVA: 0x1806388
	public void .ctor() { }

	// RVA: 0x180646C
	public static MouseLeaveWindowEvent GetPooled(Event systemEvent) { }

	// RVA: 0x180653C
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseOverEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18068C4
	private static void .cctor() { }

	// RVA: 0x1806930
	public void .ctor() { }

	// RVA: 0x1806938
	internal MouseOverEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseOverEvent
{
	// Methods

	// RVA: 0x1806780
	private static void .cctor() { }

	// RVA: 0x1806870
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1806B08
	private static void .cctor() { }

	// RVA: 0x1806B74
	public void .ctor() { }

	// RVA: 0x1806B7C
	internal MouseOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseOutEvent
{
	// Methods

	// RVA: 0x18069C4
	private static void .cctor() { }

	// RVA: 0x1806AB4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ContextualMenuPopulateEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1807744
	private static void .cctor() { }

	// RVA: 0x18077B0
	public void .ctor() { }

	// RVA: 0x18077B8
	internal ContextualMenuPopulateEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ContextualMenuPopulateEvent
{
	// Fields
	private DropdownMenu <menu>k__BackingField; // 0xB8
	private EventBase <triggerEvent>k__BackingField; // 0xC0
	private ContextualMenuManager m_ContextualMenuManager; // 0xC8

	// Methods

	// RVA: 0x1806C08
	private static void .cctor() { }

	// RVA: 0x1806CF8
	public DropdownMenu get_menu() { }

	// RVA: 0x1806D00
	private void set_menu(DropdownMenu value) { }

	// RVA: 0x1806D08
	public EventBase get_triggerEvent() { }

	// RVA: 0x1806D10
	private void set_triggerEvent(EventBase value) { }

	// RVA: 0x1806D18
	public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager) { }

	// RVA: 0x18074E0
	protected override void Init() { }

	// RVA: 0x180758C
	private void LocalInit() { }

	// RVA: 0x18075F4
	public void .ctor() { }

	// RVA: 0x18076A0
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal static class MouseEventsHelper
{
	// Methods

	// RVA: 0x315B3A8
	internal static void SendEnterLeave(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

	// RVA: 0x1807890
	internal static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

}

// Namespace: UnityEngine.UIElements
internal static class PointerEventsHelper
{
	// Methods

	// RVA: 0x315B3A8
	internal static void SendEnterLeave(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	// RVA: 0x1807B7C
	internal static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

}

// Namespace: UnityEngine.UIElements
internal class NavigationEventDispatchingStrategy
{
	// Methods

	// RVA: 0x1807E6C
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1807ECC
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x18081A8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface INavigationEvent
{
	// Methods

	// RVA: -1
	public abstract bool get_shiftKey() { }

	// RVA: -1
	public abstract bool get_altKey() { }

}

// Namespace: UnityEngine.UIElements
internal enum NavigationDeviceType
{
	// Fields
	public int value__; // 0x10
	public const NavigationDeviceType Unknown = 0;
	public const NavigationDeviceType Keyboard = 1;
	public const NavigationDeviceType NonKeyboard = 2;
}

// Namespace: UnityEngine.UIElements
public abstract class NavigationEventBase<T0>
{
	// Fields
	private EventModifiers <modifiers>k__BackingField; // 0x0
	private NavigationDeviceType <deviceType>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A14A4
	public EventModifiers get_modifiers() { }

	// RVA: 0x30A24F0
	protected void set_modifiers(EventModifiers value) { }

	// RVA: 0x30A1224
	public bool get_shiftKey() { }

	// RVA: 0x30A1224
	public bool get_altKey() { }

	// RVA: 0x30A14A4
	internal NavigationDeviceType get_deviceType() { }

	// RVA: 0x30A24F0
	private void set_deviceType(NavigationDeviceType value) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x315B3A8
	public static T GetPooled(EventModifiers modifiers) { }

	// RVA: 0x315B3A8
	internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers) { }

}

// Namespace: 
public enum Direction
{
	// Fields
	public int value__; // 0x10
	public const Direction None = 0;
	public const Direction Left = 1;
	public const Direction Up = 2;
	public const Direction Right = 3;
	public const Direction Down = 4;
	public const Direction Next = 5;
	public const Direction Previous = 6;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.NavigationMoveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18087E0
	private static void .cctor() { }

	// RVA: 0x180884C
	public void .ctor() { }

	// RVA: 0x1808854
	internal NavigationMoveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class NavigationMoveEvent
{
	// Fields
	private Direction <direction>k__BackingField; // 0x8C
	private Vector2 <move>k__BackingField; // 0x90

	// Methods

	// RVA: 0x18081B0
	private static void .cctor() { }

	// RVA: 0x18082A0
	internal static Direction DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x18082F0
	public Direction get_direction() { }

	// RVA: 0x18082F8
	private void set_direction(Direction value) { }

	// RVA: 0x1808300
	private void set_move(Vector2 value) { }

	// RVA: 0x1808308
	public static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers) { }

	// RVA: 0x18083FC
	internal static NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers) { }

	// RVA: 0x18084FC
	public static NavigationMoveEvent GetPooled(Direction direction, EventModifiers modifiers) { }

	// RVA: 0x18085A8
	internal static NavigationMoveEvent GetPooled(Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers) { }

	// RVA: 0x1808660
	protected override void Init() { }

	// RVA: 0x180874C
	public void .ctor() { }

	// RVA: 0x18086F4
	private void LocalInit() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.NavigationCancelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1808A60
	private static void .cctor() { }

	// RVA: 0x1808ACC
	public void .ctor() { }

	// RVA: 0x1808AD4
	internal NavigationCancelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class NavigationCancelEvent
{
	// Methods

	// RVA: 0x180891C
	private static void .cctor() { }

	// RVA: 0x1808A0C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.NavigationSubmitEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1808CA4
	private static void .cctor() { }

	// RVA: 0x1808D10
	public void .ctor() { }

	// RVA: 0x1808D18
	internal NavigationSubmitEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class NavigationSubmitEvent
{
	// Methods

	// RVA: 0x1808B60
	private static void .cctor() { }

	// RVA: 0x1808C50
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class PanelChangedEventBase<T0>
{
	// Fields
	private IPanel <originPanel>k__BackingField; // 0x0
	private IPanel <destinationPanel>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A17DC
	public IPanel get_originPanel() { }

	// RVA: 0x30A27C0
	private void set_originPanel(IPanel value) { }

	// RVA: 0x30A17DC
	public IPanel get_destinationPanel() { }

	// RVA: 0x30A27C0
	private void set_destinationPanel(IPanel value) { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x315B3A8
	public static T GetPooled(IPanel originPanel, IPanel destinationPanel) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.AttachToPanelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1808EE8
	private static void .cctor() { }

	// RVA: 0x1808F54
	public void .ctor() { }

	// RVA: 0x1808F5C
	internal AttachToPanelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class AttachToPanelEvent
{
	// Methods

	// RVA: 0x1808DA4
	private static void .cctor() { }

	// RVA: 0x1808E94
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.DetachFromPanelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180912C
	private static void .cctor() { }

	// RVA: 0x1809198
	public void .ctor() { }

	// RVA: 0x18091A0
	internal DetachFromPanelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class DetachFromPanelEvent
{
	// Methods

	// RVA: 0x1808FE8
	private static void .cctor() { }

	// RVA: 0x18090D8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class PointerCaptureDispatchingStrategy
{
	// Methods

	// RVA: 0x180922C
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x180928C
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x180994C
	public void .ctor() { }

}

// Namespace: 
internal enum LocationFlag
{
	// Fields
	public int value__; // 0x10
	public const LocationFlag None = 0;
	public const LocationFlag OutsidePanel = 1;
}

// Namespace: 
private struct PointerLocation
{
	// Fields
	private Vector2 <Position>k__BackingField; // 0x10
	private IPanel <Panel>k__BackingField; // 0x18
	private LocationFlag <Flags>k__BackingField; // 0x20

	// Methods

	// RVA: 0x180A5A8
	internal Vector2 get_Position() { }

	// RVA: 0x180A5B0
	private void set_Position(Vector2 value) { }

	// RVA: 0x180A5B8
	internal IPanel get_Panel() { }

	// RVA: 0x180A5C0
	private void set_Panel(IPanel value) { }

	// RVA: 0x180A5C8
	internal LocationFlag get_Flags() { }

	// RVA: 0x180A5D0
	private void set_Flags(LocationFlag value) { }

	// RVA: 0x1809B7C
	internal void SetLocation(Vector2 position, IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal static class PointerDeviceState
{
	// Fields
	private static PointerLocation[] s_PlayerPointerLocations; // 0x0
	private static int[] s_PressedButtons; // 0x8
	private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture; // 0x10

	// Methods

	// RVA: 0x1809954
	internal static void RemovePanelData(IPanel panel) { }

	// RVA: 0x1809C94
	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType) { }

	// RVA: 0x1809D58
	public static void PressButton(int pointerId, int buttonId) { }

	// RVA: 0x1809E38
	public static void ReleaseButton(int pointerId, int buttonId) { }

	// RVA: 0x1809F18
	public static void ReleaseAllButtons(int pointerId) { }

	// RVA: 0x1809FB8
	public static Vector2 GetPointerPosition(int pointerId, ContextType contextType) { }

	// RVA: 0x180A05C
	public static IPanel GetPanel(int pointerId, ContextType contextType) { }

	// RVA: 0x180A100
	private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag) { }

	// RVA: 0x180A10C
	public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag) { }

	// RVA: 0x180A1BC
	public static int GetPressedButtons(int pointerId) { }

	// RVA: 0x180A25C
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	// RVA: 0x180A310
	internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel) { }

	// RVA: 0x180A3DC
	internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId) { }

	// RVA: 0x180A47C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class PointerEventDispatchingStrategy
{
	// Methods

	// RVA: 0x180A5D8
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x180A638
	public virtual void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x180A98C
	private static void SendEventToTarget(EventBase evt, IPanel panel) { }

	// RVA: 0x180A700
	private static void SetBestTargetForEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x180AA48
	private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, VisualElement elementUnderPointer) { }

	// RVA: 0x180AD5C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public static class PointerType
{
	// Fields
	public static readonly string mouse; // 0x0
	public static readonly string touch; // 0x8
	public static readonly string pen; // 0x10
	public static readonly string unknown; // 0x18

	// Methods

	// RVA: 0x180AD64
	internal static string GetPointerType(int pointerId) { }

	// RVA: 0x180AE98
	internal static bool IsDirectManipulationDevice(string pointerType) { }

	// RVA: 0x180AF58
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public static class PointerId
{
	// Fields
	public static readonly int maxPointers; // 0x0
	public static readonly int invalidPointerId; // 0x4
	public static readonly int mousePointerId; // 0x8
	public static readonly int touchPointerIdBase; // 0xC
	public static readonly int touchPointerCount; // 0x10
	public static readonly int penPointerIdBase; // 0x14
	public static readonly int penPointerCount; // 0x18
	internal static readonly int[] hoveringPointers; // 0x20

	// Methods

	// RVA: 0x180B050
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IPointerEvent
{
	// Methods

	// RVA: -1
	public abstract int get_pointerId() { }

	// RVA: -1
	public abstract string get_pointerType() { }

	// RVA: -1
	public abstract bool get_isPrimary() { }

	// RVA: -1
	public abstract int get_button() { }

	// RVA: -1
	public abstract int get_pressedButtons() { }

	// RVA: -1
	public abstract Vector3 get_position() { }

	// RVA: -1
	public abstract Vector3 get_localPosition() { }

	// RVA: -1
	public abstract Vector3 get_deltaPosition() { }

	// RVA: -1
	public abstract float get_deltaTime() { }

	// RVA: -1
	public abstract int get_clickCount() { }

	// RVA: -1
	public abstract float get_pressure() { }

	// RVA: -1
	public abstract float get_tangentialPressure() { }

	// RVA: -1
	public abstract float get_altitudeAngle() { }

	// RVA: -1
	public abstract float get_azimuthAngle() { }

	// RVA: -1
	public abstract float get_twist() { }

	// RVA: -1
	public abstract Vector2 get_tilt() { }

	// RVA: -1
	public abstract PenStatus get_penStatus() { }

	// RVA: -1
	public abstract Vector2 get_radius() { }

	// RVA: -1
	public abstract Vector2 get_radiusVariance() { }

	// RVA: -1
	public abstract EventModifiers get_modifiers() { }

	// RVA: -1
	public abstract bool get_shiftKey() { }

	// RVA: -1
	public abstract bool get_ctrlKey() { }

	// RVA: -1
	public abstract bool get_commandKey() { }

	// RVA: -1
	public abstract bool get_altKey() { }

	// RVA: -1
	public abstract bool get_actionKey() { }

}

// Namespace: UnityEngine.UIElements
internal interface IPointerEventInternal
{
	// Methods

	// RVA: -1
	public abstract bool get_triggeredByOS() { }

	// RVA: -1
	public abstract void set_triggeredByOS(bool value) { }

	// RVA: -1
	public abstract bool get_recomputeTopElementUnderPointer() { }

	// RVA: -1
	public abstract void set_recomputeTopElementUnderPointer(bool value) { }

}

// Namespace: UnityEngine.UIElements
internal static class PointerEventHelper
{
	// Methods

	// RVA: 0x180B10C
	public static EventBase GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers) { }

}

// Namespace: UnityEngine.UIElements
public abstract class PointerEventBase<T0>
{
	// Fields
	private bool m_AltitudeNeedsConversion; // 0x0
	private bool m_AzimuthNeedsConversion; // 0x0
	private float m_AltitudeAngle; // 0x0
	private float m_AzimuthAngle; // 0x0
	private bool m_TiltNeeded; // 0x0
	private Vector2 m_Tilt; // 0x0
	private int <pointerId>k__BackingField; // 0x0
	private string <pointerType>k__BackingField; // 0x0
	private bool <isPrimary>k__BackingField; // 0x0
	private int <button>k__BackingField; // 0x0
	private int <pressedButtons>k__BackingField; // 0x0
	private Vector3 <position>k__BackingField; // 0x0
	private Vector3 <localPosition>k__BackingField; // 0x0
	private Vector3 <deltaPosition>k__BackingField; // 0x0
	private float <deltaTime>k__BackingField; // 0x0
	private int <clickCount>k__BackingField; // 0x0
	private float <pressure>k__BackingField; // 0x0
	private float <tangentialPressure>k__BackingField; // 0x0
	private float <twist>k__BackingField; // 0x0
	private PenStatus <penStatus>k__BackingField; // 0x0
	private Vector2 <radius>k__BackingField; // 0x0
	private Vector2 <radiusVariance>k__BackingField; // 0x0
	private EventModifiers <modifiers>k__BackingField; // 0x0
	private bool <UnityEngine.UIElements.IPointerEventInternal.triggeredByOS>k__BackingField; // 0x0
	private bool <UnityEngine.UIElements.IPointerEventInternal.recomputeTopElementUnderPointer>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A14A4
	public int get_pointerId() { }

	// RVA: 0x30A24F0
	protected void set_pointerId(int value) { }

	// RVA: 0x30A17DC
	public string get_pointerType() { }

	// RVA: 0x30A27C0
	protected void set_pointerType(string value) { }

	// RVA: 0x30A1224
	public bool get_isPrimary() { }

	// RVA: 0x30A2404
	protected void set_isPrimary(bool value) { }

	// RVA: 0x30A14A4
	public int get_button() { }

	// RVA: 0x30A24F0
	protected void set_button(int value) { }

	// RVA: 0x30A14A4
	public int get_pressedButtons() { }

	// RVA: 0x30A24F0
	protected void set_pressedButtons(int value) { }

	// RVA: -1
	public Vector3 get_position() { }

	// RVA: -1
	protected void set_position(Vector3 value) { }

	// RVA: -1
	public Vector3 get_localPosition() { }

	// RVA: -1
	protected void set_localPosition(Vector3 value) { }

	// RVA: -1
	public Vector3 get_deltaPosition() { }

	// RVA: -1
	protected void set_deltaPosition(Vector3 value) { }

	// RVA: -1
	public float get_deltaTime() { }

	// RVA: -1
	protected void set_deltaTime(float value) { }

	// RVA: 0x30A14A4
	public int get_clickCount() { }

	// RVA: 0x30A24F0
	protected void set_clickCount(int value) { }

	// RVA: -1
	public float get_pressure() { }

	// RVA: -1
	protected void set_pressure(float value) { }

	// RVA: -1
	public float get_tangentialPressure() { }

	// RVA: -1
	protected void set_tangentialPressure(float value) { }

	// RVA: -1
	public float get_altitudeAngle() { }

	// RVA: -1
	protected void set_altitudeAngle(float value) { }

	// RVA: -1
	public float get_azimuthAngle() { }

	// RVA: -1
	protected void set_azimuthAngle(float value) { }

	// RVA: -1
	public float get_twist() { }

	// RVA: -1
	protected void set_twist(float value) { }

	// RVA: -1
	public Vector2 get_tilt() { }

	// RVA: -1
	protected void set_tilt(Vector2 value) { }

	// RVA: 0x30A14A4
	public PenStatus get_penStatus() { }

	// RVA: 0x30A24F0
	protected void set_penStatus(PenStatus value) { }

	// RVA: -1
	public Vector2 get_radius() { }

	// RVA: -1
	protected void set_radius(Vector2 value) { }

	// RVA: -1
	public Vector2 get_radiusVariance() { }

	// RVA: -1
	protected void set_radiusVariance(Vector2 value) { }

	// RVA: 0x30A14A4
	public EventModifiers get_modifiers() { }

	// RVA: 0x30A24F0
	protected void set_modifiers(EventModifiers value) { }

	// RVA: 0x30A1224
	public bool get_shiftKey() { }

	// RVA: 0x30A1224
	public bool get_ctrlKey() { }

	// RVA: 0x30A1224
	public bool get_commandKey() { }

	// RVA: 0x30A1224
	public bool get_altKey() { }

	// RVA: 0x30A1224
	public bool get_actionKey() { }

	// RVA: 0x30A1224
	private bool UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS() { }

	// RVA: 0x30A2404
	private void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(bool value) { }

	// RVA: 0x30A1224
	private bool UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer() { }

	// RVA: 0x30A2404
	private void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(bool value) { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x30A17DC
	public override IEventHandler get_currentTarget() { }

	// RVA: 0x30A27C0
	internal override void set_currentTarget(IEventHandler value) { }

	// RVA: 0x30A3970
	private static bool IsMouse(Event systemEvent) { }

	// RVA: 0x30A3970
	private static bool IsTouch(Event systemEvent) { }

	// RVA: 0x315B3A8
	private static float TiltToAzimuth(Vector2 tilt) { }

	// RVA: 0x315B3A8
	private static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	// RVA: 0x315B3A8
	private static float TiltToAltitude(Vector2 tilt) { }

	// RVA: 0x315B3A8
	public static T GetPooled(Event systemEvent) { }

	// RVA: 0x315B3A8
	internal static T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers) { }

	// RVA: 0x315B3A8
	public static T GetPooled(Touch touch, EventModifiers modifiers) { }

	// RVA: 0x315B3A8
	public static T GetPooled(PenData pen, EventModifiers modifiers) { }

	// RVA: 0x315B3A8
	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	// RVA: 0x315B3A8
	public static T GetPooled(IPointerEvent triggerEvent) { }

	// RVA: 0x30A27C0
	protected internal override void PreDispatch(IPanel panel) { }

	// RVA: 0x30A27C0
	protected internal override void PostDispatch(IPanel panel) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerDownEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180B904
	private static void .cctor() { }

	// RVA: 0x180B970
	public void .ctor() { }

	// RVA: 0x180B978
	internal PointerDownEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerDownEvent
{
	// Methods

	// RVA: 0x180B3BC
	private static void .cctor() { }

	// RVA: 0x180B4AC
	protected override void Init() { }

	// RVA: 0x180B508
	private void LocalInit() { }

	// RVA: 0x180B618
	public void .ctor() { }

	// RVA: 0x180B674
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerMoveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180C370
	private static void .cctor() { }

	// RVA: 0x180C3DC
	public void .ctor() { }

	// RVA: 0x180C3E4
	internal PointerMoveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerMoveEvent
{
	// Fields
	private bool <isHandledByDraggable>k__BackingField; // 0x106

	// Methods

	// RVA: 0x180BA0C
	private static void .cctor() { }

	// RVA: 0x180BAFC
	internal bool get_isHandledByDraggable() { }

	// RVA: 0x180BB04
	internal void set_isHandledByDraggable(bool value) { }

	// RVA: 0x180BB0C
	protected override void Init() { }

	// RVA: 0x180BB68
	private void LocalInit() { }

	// RVA: 0x180BC80
	public void .ctor() { }

	// RVA: 0x180BCDC
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerStationaryEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180C730
	private static void .cctor() { }

	// RVA: 0x180C79C
	public void .ctor() { }

	// RVA: 0x180C7A4
	internal PointerStationaryEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerStationaryEvent
{
	// Methods

	// RVA: 0x180C478
	private static void .cctor() { }

	// RVA: 0x180C568
	protected override void Init() { }

	// RVA: 0x180C5C4
	private void LocalInit() { }

	// RVA: 0x180C6D4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerUpEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180CF28
	private static void .cctor() { }

	// RVA: 0x180CF94
	public void .ctor() { }

	// RVA: 0x180CF9C
	internal PointerUpEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerUpEvent
{
	// Methods

	// RVA: 0x180C838
	private static void .cctor() { }

	// RVA: 0x180C928
	protected override void Init() { }

	// RVA: 0x180C984
	private void LocalInit() { }

	// RVA: 0x180CA94
	public void .ctor() { }

	// RVA: 0x180CAF0
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerCancelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180D6E4
	private static void .cctor() { }

	// RVA: 0x180D750
	public void .ctor() { }

	// RVA: 0x180D758
	internal PointerCancelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerCancelEvent
{
	// Methods

	// RVA: 0x180D030
	private static void .cctor() { }

	// RVA: 0x180D120
	protected override void Init() { }

	// RVA: 0x180D17C
	private void LocalInit() { }

	// RVA: 0x180D28C
	public void .ctor() { }

	// RVA: 0x180D2E8
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ClickEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180DA1C
	private static void .cctor() { }

	// RVA: 0x180DA88
	public void .ctor() { }

	// RVA: 0x180DA90
	internal ClickEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class ClickEvent
{
	// Methods

	// RVA: 0x180D7EC
	private static void .cctor() { }

	// RVA: 0x180D8DC
	protected override void Init() { }

	// RVA: 0x180D93C
	private void LocalInit() { }

	// RVA: 0x180D948
	public void .ctor() { }

	// RVA: 0x180D9A8
	internal static ClickEvent GetPooled(PointerUpEvent pointerEvent, int clickCount) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerEnterEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180DCE0
	private static void .cctor() { }

	// RVA: 0x180DD4C
	public void .ctor() { }

	// RVA: 0x180DD54
	internal PointerEnterEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerEnterEvent
{
	// Methods

	// RVA: 0x180DB24
	private static void .cctor() { }

	// RVA: 0x180DC14
	protected override void Init() { }

	// RVA: 0x180DC74
	private void LocalInit() { }

	// RVA: 0x180DC80
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerLeaveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180DFA4
	private static void .cctor() { }

	// RVA: 0x180E010
	public void .ctor() { }

	// RVA: 0x180E018
	internal PointerLeaveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerLeaveEvent
{
	// Methods

	// RVA: 0x180DDE8
	private static void .cctor() { }

	// RVA: 0x180DED8
	protected override void Init() { }

	// RVA: 0x180DF38
	private void LocalInit() { }

	// RVA: 0x180DF44
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerOverEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180E1F0
	private static void .cctor() { }

	// RVA: 0x180E25C
	public void .ctor() { }

	// RVA: 0x180E264
	internal PointerOverEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerOverEvent
{
	// Methods

	// RVA: 0x180E0AC
	private static void .cctor() { }

	// RVA: 0x180E19C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180E434
	private static void .cctor() { }

	// RVA: 0x180E4A0
	public void .ctor() { }

	// RVA: 0x180E4A8
	internal PointerOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerOutEvent
{
	// Methods

	// RVA: 0x180E2F0
	private static void .cctor() { }

	// RVA: 0x180E3E0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PropagationPaths.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180EAEC
	private static void .cctor() { }

	// RVA: 0x180EB58
	public void .ctor() { }

	// RVA: 0x180EB60
	internal PropagationPaths <.cctor>b__12_0() { }

}

// Namespace: UnityEngine.UIElements
internal class PropagationPaths
{
	// Fields
	private static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.PropagationPaths> s_Pool; // 0x0
	public readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> trickleDownPath; // 0x10
	public readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> targetElements; // 0x18
	public readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> bubbleUpPath; // 0x20
	private const int k_DefaultPropagationDepth = 16;
	private const int k_DefaultTargetCount = 4;

	// Methods

	// RVA: 0x180E534
	public void .ctor() { }

	// RVA: 0x180E614
	public static PropagationPaths Build(VisualElement elem, EventBase evt) { }

	// RVA: 0x180E81C
	public void Release() { }

	// RVA: 0x180E9CC
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.CustomStyleResolvedEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180EDDC
	private static void .cctor() { }

	// RVA: 0x180EE48
	public void .ctor() { }

	// RVA: 0x180EE50
	internal CustomStyleResolvedEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class CustomStyleResolvedEvent
{
	// Methods

	// RVA: 0x180EBB4
	private static void .cctor() { }

	// RVA: 0x180ECA4
	public ICustomStyle get_customStyle() { }

	// RVA: 0x180ED38
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TooltipEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180F204
	private static void .cctor() { }

	// RVA: 0x180F270
	public void .ctor() { }

	// RVA: 0x180F278
	internal TooltipEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class TooltipEvent
{
	// Fields
	private string <tooltip>k__BackingField; // 0x88
	private Rect <rect>k__BackingField; // 0x90

	// Methods

	// RVA: 0x180EF00
	private static void .cctor() { }

	// RVA: 0x180EFF0
	public void set_tooltip(string value) { }

	// RVA: 0x180EFF8
	public void set_rect(Rect value) { }

	// RVA: 0x180F004
	protected override void Init() { }

	// RVA: 0x180F0B4
	private void LocalInit() { }

	// RVA: 0x180F130
	public void .ctor() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator m_Enumerator; // 0x10

	// Methods

	// RVA: 0x180F364
	internal void .ctor(Enumerator enumerator) { }

	// RVA: 0x180F504
	public bool MoveNext() { }

	// RVA: 0x180F558
	public StylePropertyName get_Current() { }

	// RVA: 0x180F62C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x180F768
	public void Reset() { }

	// RVA: 0x180F76C
	public void Dispose() { }

}

// Namespace: UnityEngine.UIElements
public struct StylePropertyNameCollection
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> propertiesList; // 0x10

	// Methods

	// RVA: 0x180F2CC
	internal void .ctor(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list) { }

	// RVA: 0x180F2D4
	public Enumerator GetEnumerator() { }

	// RVA: 0x180F374
	private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator() { }

	// RVA: 0x180F43C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.UIElements
public abstract class TransitionEventBase<T0>
{
	// Fields
	private readonly StylePropertyNameCollection <stylePropertyNames>k__BackingField; // 0x0
	private Double <elapsedTime>k__BackingField; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public StylePropertyNameCollection get_stylePropertyNames() { }

	// RVA: -1
	protected void set_elapsedTime(Double value) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

	// RVA: 0x30A2378
	protected override void Init() { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x315B3A8
	public static T GetPooled(StylePropertyName stylePropertyName, Double elapsedTime) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionRunEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180F904
	private static void .cctor() { }

	// RVA: 0x180F970
	public void .ctor() { }

	// RVA: 0x180F978
	internal TransitionRunEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionRunEvent
{
	// Methods

	// RVA: 0x180F7C0
	private static void .cctor() { }

	// RVA: 0x180F8B0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionStartEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180FB48
	private static void .cctor() { }

	// RVA: 0x180FBB4
	public void .ctor() { }

	// RVA: 0x180FBBC
	internal TransitionStartEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionStartEvent
{
	// Methods

	// RVA: 0x180FA04
	private static void .cctor() { }

	// RVA: 0x180FAF4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionEndEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180FD8C
	private static void .cctor() { }

	// RVA: 0x180FDF8
	public void .ctor() { }

	// RVA: 0x180FE00
	internal TransitionEndEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionEndEvent
{
	// Methods

	// RVA: 0x180FC48
	private static void .cctor() { }

	// RVA: 0x180FD38
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionCancelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x180FFD0
	private static void .cctor() { }

	// RVA: 0x181003C
	public void .ctor() { }

	// RVA: 0x1810044
	internal TransitionCancelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionCancelEvent
{
	// Methods

	// RVA: 0x180FE8C
	private static void .cctor() { }

	// RVA: 0x180FF7C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.IMGUIEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1810364
	private static void .cctor() { }

	// RVA: 0x18103D0
	public void .ctor() { }

	// RVA: 0x18103D8
	internal IMGUIEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class IMGUIEvent
{
	// Methods

	// RVA: 0x18100D0
	private static void .cctor() { }

	// RVA: 0x18101C0
	public static IMGUIEvent GetPooled(Event systemEvent) { }

	// RVA: 0x1810274
	protected override void Init() { }

	// RVA: 0x18102D4
	private void LocalInit() { }

	// RVA: 0x18102E0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseFieldMouseDragger
{
	// Methods

	// RVA: 0x1810490
	public void SetDragZone(VisualElement dragElement) { }

	// RVA: -1
	public abstract void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	// RVA: 0x18104AC
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class FieldMouseDragger<T0>
{
	// Fields
	private readonly UnityEngine.UIElements.IValueField<T> m_DrivenField; // 0x0
	private VisualElement m_DragElement; // 0x0
	private Rect m_DragHotZone; // 0x0
	private bool <dragging>k__BackingField; // 0x0
	private T <startValue>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(UnityEngine.UIElements.IValueField<T> drivenField) { }

	// RVA: 0x30A1224
	public bool get_dragging() { }

	// RVA: 0x30A2404
	public void set_dragging(bool value) { }

	// RVA: 0x315B3A8
	public T get_startValue() { }

	// RVA: 0x315B3A8
	public void set_startValue(T value) { }

	// RVA: -1
	public sealed override void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	// RVA: 0x315B3A8
	private bool CanStartDrag(int button, Vector2 localPosition) { }

	// RVA: 0x30A27C0
	private void UpdateValueOnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x30A27C0
	private void ProcessDownEvent(EventBase evt) { }

	// RVA: 0x30A27C0
	private void UpdateValueOnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x315B3A8
	private void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition) { }

	// RVA: 0x30A27C0
	private void UpdateValueOnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x30A2828
	private void ProcessUpEvent(EventBase evt, int pointerId) { }

	// RVA: 0x30A27C0
	private void UpdateValueOnKeyDown(KeyDownEvent evt) { }

}

// Namespace: UnityEngine.UIElements
public abstract class Focusable
{
	// Fields
	private bool <focusable>k__BackingField; // 0x20
	private int <tabIndex>k__BackingField; // 0x24
	private bool m_DelegatesFocus; // 0x28
	private bool m_ExcludeFromFocusRing; // 0x29

	// Methods

	// RVA: 0x18104B4
	protected void .ctor() { }

	// RVA: -1
	public abstract FocusController get_focusController() { }

	// RVA: 0x18104E4
	public bool get_focusable() { }

	// RVA: 0x18104EC
	public void set_focusable(bool value) { }

	// RVA: 0x18104F4
	public int get_tabIndex() { }

	// RVA: 0x18104FC
	public void set_tabIndex(int value) { }

	// RVA: 0x1810504
	public bool get_delegatesFocus() { }

	// RVA: 0x181050C
	public void set_delegatesFocus(bool value) { }

	// RVA: 0x1810514
	internal bool get_excludeFromFocusRing() { }

	// RVA: 0x181051C
	internal void set_excludeFromFocusRing(bool value) { }

	// RVA: 0x1810604
	public virtual bool get_canGrabFocus() { }

	// RVA: 0x181060C
	public virtual void Focus() { }

	// RVA: 0x1810A3C
	public virtual void Blur() { }

	// RVA: 0x1810C3C
	internal void BlurImmediately() { }

	// RVA: 0x18108B4
	private Focusable GetFocusDelegate() { }

	// RVA: 0x1810C84
	private static Focusable GetFirstFocusableChild(VisualElement ve) { }

	// RVA: 0x1810DC0
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x1810E90
	internal override void ExecuteDefaultActionDisabled(EventBase evt) { }

	// RVA: 0x1810E2C
	private void ProcessEvent(EventBase evt) { }

}

// Namespace: UnityEngine.UIElements
public class FocusChangeDirection
{
	// Fields
	private static readonly FocusChangeDirection <unspecified>k__BackingField; // 0x0
	private static readonly FocusChangeDirection <none>k__BackingField; // 0x8
	private static readonly FocusChangeDirection <lastValue>k__BackingField; // 0x10
	private readonly int m_Value; // 0x10

	// Methods

	// RVA: 0x18111FC
	public static FocusChangeDirection get_unspecified() { }

	// RVA: 0x1811278
	public static FocusChangeDirection get_none() { }

	// RVA: 0x18112F4
	protected static FocusChangeDirection get_lastValue() { }

	// RVA: 0x1811370
	protected void .ctor(int value) { }

	// RVA: 0x181139C
	public static int op_Implicit(FocusChangeDirection fcd) { }

	// RVA: 0x18113A8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18113B4
	protected virtual void Dispose() { }

	// RVA: 0x18113B8
	internal virtual void ApplyTo(FocusController focusController, Focusable f) { }

	// RVA: 0x1811720
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IFocusRing
{
	// Methods

	// RVA: -1
	public abstract FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: -1
	public abstract Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

}

// Namespace: 
private struct FocusedElement
{
	// Fields
	public VisualElement m_SubTreeRoot; // 0x10
	public Focusable m_FocusedElement; // 0x18
}

// Namespace: UnityEngine.UIElements
public class FocusController
{
	// Fields
	private readonly IFocusRing <focusRing>k__BackingField; // 0x10
	private TextElement m_SelectedTextElement; // 0x18
	private System.Collections.Generic.List<UnityEngine.UIElements.FocusController.FocusedElement> m_FocusedElements; // 0x20
	private Focusable m_LastFocusedElement; // 0x28
	internal Focusable m_LastPendingFocusedElement; // 0x30
	private int m_PendingFocusCount; // 0x38
	private int <imguiKeyboardControl>k__BackingField; // 0x3C

	// Methods

	// RVA: 0x1811828
	public void .ctor(IFocusRing focusRing) { }

	// RVA: 0x18118DC
	private IFocusRing get_focusRing() { }

	// RVA: 0x18118E4
	internal void set_selectedTextElement(TextElement value) { }

	// RVA: 0x18119D0
	public Focusable get_focusedElement() { }

	// RVA: 0x1811D28
	internal bool IsFocused(Focusable f) { }

	// RVA: 0x1811A18
	internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst) { }

	// RVA: 0x18080D4
	internal Focusable GetLeafFocusedElement() { }

	// RVA: 0x1811CD0
	private bool IsLocalElement(Focusable f) { }

	// RVA: 0x1811F44
	internal bool IsPendingFocus(Focusable f) { }

	// RVA: 0x1812030
	internal void SetFocusToLastFocusedElement() { }

	// RVA: 0x18120BC
	internal void BlurLastFocusedElement() { }

	// RVA: 0x1812168
	internal void DoFocusChange(Focusable f) { }

	// RVA: 0x181231C
	internal void ProcessPendingFocusChange(Focusable f) { }

	// RVA: 0x1812378
	internal Focusable FocusNextInDirection(FocusChangeDirection direction) { }

	// RVA: 0x1812520
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x18126B0
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x1812840
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x18129D0
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x1810A84
	internal void Blur(Focusable focusable, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x1810958
	internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x18113E4
	internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x1810EFC
	internal void SwitchFocusOnEvent(EventBase e) { }

	// RVA: 0x1812B64
	internal void ReevaluateFocus() { }

	// RVA: 0x1812C3C
	internal bool GetFocusableParentForPointerEvent(Focusable target, Focusable effectiveTarget) { }

	// RVA: 0x1812D94
	internal int get_imguiKeyboardControl() { }

	// RVA: 0x1812D9C
	internal void set_imguiKeyboardControl(int value) { }

	// RVA: 0x1812DA4
	internal void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
public class DynamicAtlasSettings
{
	// Fields
	private int m_MinAtlasSize; // 0x10
	private int m_MaxAtlasSize; // 0x14
	private int m_MaxSubTextureSize; // 0x18
	private DynamicAtlasFilters m_ActiveFilters; // 0x1C
	private DynamicAtlasCustomFilter m_CustomFilter; // 0x20

	// Methods

	// RVA: 0x1812ED4
	public int get_minAtlasSize() { }

	// RVA: 0x1812EDC
	public void set_minAtlasSize(int value) { }

	// RVA: 0x1812EE4
	public int get_maxAtlasSize() { }

	// RVA: 0x1812EEC
	public void set_maxAtlasSize(int value) { }

	// RVA: 0x1812EF4
	public int get_maxSubTextureSize() { }

	// RVA: 0x1812EFC
	public void set_maxSubTextureSize(int value) { }

	// RVA: 0x1812F04
	public DynamicAtlasFilters get_activeFilters() { }

	// RVA: 0x1812F0C
	public void set_activeFilters(DynamicAtlasFilters value) { }

	// RVA: 0x1812F14
	public static DynamicAtlasFilters get_defaultFilters() { }

	// RVA: 0x1812F1C
	public DynamicAtlasCustomFilter get_customFilter() { }

	// RVA: 0x1812F24
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	// RVA: 0x1812F2C
	public static DynamicAtlasSettings get_defaults() { }

	// RVA: 0x1812FBC
	public void .ctor() { }

}

// Namespace: 
public class ChangeDirection
{
	// Methods

	// RVA: 0x18140B0
	public void .ctor(int i) { }

}

// Namespace: 
private struct FocusableHierarchyTraversal
{
	// Fields
	public VisualElement currentFocusable; // 0x10
	public Rect validRect; // 0x18
	public bool firstPass; // 0x28
	public ChangeDirection direction; // 0x30

	// Methods

	// RVA: 0x1814120
	private bool ValidateHierarchyTraversal(VisualElement v) { }

	// RVA: 0x181420C
	private bool ValidateElement(VisualElement v) { }

	// RVA: 0x1814318
	private int Order(VisualElement a, VisualElement b) { }

	// RVA: 0x18147BC
	private int StrictOrder(VisualElement a, VisualElement b) { }

	// RVA: 0x1814490
	private int StrictOrder(Rect ra, Rect rb) { }

	// RVA: 0x18146B8
	private int TieBreaker(Rect ra, Rect rb) { }

	// RVA: 0x1813B18
	public VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar) { }

}

// Namespace: UnityEngine.UIElements
internal class NavigateFocusRing
{
	// Fields
	public static readonly ChangeDirection Left; // 0x0
	public static readonly ChangeDirection Right; // 0x8
	public static readonly ChangeDirection Up; // 0x10
	public static readonly ChangeDirection Down; // 0x18
	public static readonly FocusChangeDirection Next; // 0x20
	public static readonly FocusChangeDirection Previous; // 0x28
	private readonly VisualElement m_Root; // 0x10
	private readonly VisualElementFocusRing m_Ring; // 0x18

	// Methods

	// RVA: 0x1812FC4
	private FocusController get_focusController() { }

	// RVA: 0x1812FEC
	public void .ctor(VisualElement root) { }

	// RVA: 0x1813080
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x18134D4
	public virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	// RVA: 0x1813684
	private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction) { }

	// RVA: 0x1813C78
	private static bool IsActive(VisualElement v) { }

	// RVA: 0x1813D64
	private static bool IsNavigable(Focusable focusable) { }

	// RVA: 0x1813DD8
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public enum PanelScaleMode
{
	// Fields
	public int value__; // 0x10
	public const PanelScaleMode ConstantPixelSize = 0;
	public const PanelScaleMode ConstantPhysicalSize = 1;
	public const PanelScaleMode ScaleWithScreenSize = 2;
}

// Namespace: UnityEngine.UIElements
public enum PanelScreenMatchMode
{
	// Fields
	public int value__; // 0x10
	public const PanelScreenMatchMode MatchWidthOrHeight = 0;
	public const PanelScreenMatchMode Shrink = 1;
	public const PanelScreenMatchMode Expand = 2;
}

// Namespace: 
private class RuntimePanelAccess
{
	// Fields
	private readonly PanelSettings m_Settings; // 0x10
	private BaseRuntimePanel m_RuntimePanel; // 0x18

	// Methods

	// RVA: 0x1815074
	internal void .ctor(PanelSettings settings) { }

	// RVA: 0x1814EEC
	internal bool get_isInitialized() { }

	// RVA: 0x1814D24
	internal BaseRuntimePanel get_panel() { }

	// RVA: 0x18154E8
	internal void DisposePanel() { }

	// RVA: 0x1814A90
	internal void SetTargetTexture() { }

	// RVA: 0x1814C1C
	internal void SetSortingPriority() { }

	// RVA: 0x1814C94
	internal void SetTargetDisplay() { }

	// RVA: 0x18168FC
	private BaseRuntimePanel CreateRelatedRuntimePanel() { }

	// RVA: 0x1816A18
	private void DisposeRelatedPanel() { }

	// RVA: 0x181686C
	internal void MarkPotentiallyEmpty() { }

}

// Namespace: UnityEngine.UIElements
public class PanelSettings
{
	// Fields
	private const int k_DefaultSortingOrder = 0;
	private const float k_DefaultScaleValue = 1;
	internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset";
	private ThemeStyleSheet themeUss; // 0x18
	private RenderTexture m_TargetTexture; // 0x20
	private PanelScaleMode m_ScaleMode; // 0x28
	private float m_ReferenceSpritePixelsPerUnit; // 0x2C
	private float m_Scale; // 0x30
	private const float DefaultDpi = 96;
	private float m_ReferenceDpi; // 0x34
	private float m_FallbackDpi; // 0x38
	private Vector2Int m_ReferenceResolution; // 0x3C
	private PanelScreenMatchMode m_ScreenMatchMode; // 0x44
	private float m_Match; // 0x48
	private float m_SortingOrder; // 0x4C
	private int m_TargetDisplay; // 0x50
	private bool m_ClearDepthStencil; // 0x54
	private bool m_ClearColor; // 0x55
	private Color m_ColorClearValue; // 0x58
	private RuntimePanelAccess m_PanelAccess; // 0x68
	internal UIDocumentList m_AttachedUIDocumentsList; // 0x70
	private DynamicAtlasSettings m_DynamicAtlasSettings; // 0x78
	private Shader m_AtlasBlitShader; // 0x80
	private Shader m_RuntimeShader; // 0x88
	private Shader m_RuntimeWorldShader; // 0x90
	public PanelTextSettings textSettings; // 0x98
	private Rect m_TargetRect; // 0xA0
	private float m_ResolvedScale; // 0xB0
	private StyleSheet m_OldThemeUss; // 0xB8
	private float <ScreenDPI>k__BackingField; // 0xC0
	private System.Func<UnityEngine.Vector2,UnityEngine.Vector2> m_AssignedScreenToPanel; // 0xC8

	// Methods

	// RVA: 0x1814844
	public ThemeStyleSheet get_themeStyleSheet() { }

	// RVA: 0x181484C
	public void set_themeStyleSheet(ThemeStyleSheet value) { }

	// RVA: 0x1814A2C
	public RenderTexture get_targetTexture() { }

	// RVA: 0x1814A34
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x1814AC8
	public PanelScaleMode get_scaleMode() { }

	// RVA: 0x1814AD0
	public void set_scaleMode(PanelScaleMode value) { }

	// RVA: 0x1814AD8
	public float get_referenceSpritePixelsPerUnit() { }

	// RVA: 0x1814AE0
	public void set_referenceSpritePixelsPerUnit(float value) { }

	// RVA: 0x1814AE8
	public float get_scale() { }

	// RVA: 0x1814AF0
	public void set_scale(float value) { }

	// RVA: 0x1814AF8
	public float get_referenceDpi() { }

	// RVA: 0x1814B00
	public void set_referenceDpi(float value) { }

	// RVA: 0x1814B30
	public float get_fallbackDpi() { }

	// RVA: 0x1814B38
	public void set_fallbackDpi(float value) { }

	// RVA: 0x1814B68
	public Vector2Int get_referenceResolution() { }

	// RVA: 0x1814B70
	public void set_referenceResolution(Vector2Int value) { }

	// RVA: 0x1814B78
	public PanelScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x1814B80
	public void set_screenMatchMode(PanelScreenMatchMode value) { }

	// RVA: 0x1814B88
	public float get_match() { }

	// RVA: 0x1814B90
	public void set_match(float value) { }

	// RVA: 0x1814B98
	public float get_sortingOrder() { }

	// RVA: 0x1814BA0
	public void set_sortingOrder(float value) { }

	// RVA: 0x1814BE0
	internal void ApplySortingOrder() { }

	// RVA: 0x1814C54
	public int get_targetDisplay() { }

	// RVA: 0x1814C5C
	public void set_targetDisplay(int value) { }

	// RVA: 0x1814CC0
	public bool get_clearDepthStencil() { }

	// RVA: 0x1814CC8
	public void set_clearDepthStencil(bool value) { }

	// RVA: 0x1814CD0
	public float get_depthClearValue() { }

	// RVA: 0x1814CE0
	public bool get_clearColor() { }

	// RVA: 0x1814CE8
	public void set_clearColor(bool value) { }

	// RVA: 0x1814CF0
	public Color get_colorClearValue() { }

	// RVA: 0x1814CFC
	public void set_colorClearValue(Color value) { }

	// RVA: 0x1814D08
	internal BaseRuntimePanel get_panel() { }

	// RVA: 0x1814ECC
	internal bool get_isInitialized() { }

	// RVA: 0x1814EFC
	internal VisualElement get_visualTree() { }

	// RVA: 0x1814F2C
	public DynamicAtlasSettings get_dynamicAtlasSettings() { }

	// RVA: 0x1814F34
	public void set_dynamicAtlasSettings(DynamicAtlasSettings value) { }

	// RVA: 0x1814F3C
	private void .ctor() { }

	// RVA: 0x18150A8
	private void Reset() { }

	// RVA: 0x18150AC
	private void OnEnable() { }

	// RVA: 0x181544C
	private void OnDisable() { }

	// RVA: 0x181557C
	internal void DisposePanel() { }

	// RVA: 0x1815618
	private float get_ScreenDPI() { }

	// RVA: 0x1815620
	private void set_ScreenDPI(float value) { }

	// RVA: 0x18151D8
	internal void UpdateScreenDPI() { }

	// RVA: 0x1814878
	private void ApplyThemeStyleSheet(VisualElement root) { }

	// RVA: 0x1815200
	private void InitializeShaders() { }

	// RVA: 0x1815628
	internal void ApplyPanelSettings() { }

	// RVA: 0x181606C
	public void SetScreenToPanelSpaceFunction(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> screentoPanelSpaceFunction) { }

	// RVA: 0x1815E60
	internal float ResolveScale(Rect targetRect, float screenDpi) { }

	// RVA: 0x1815D40
	internal Rect GetDisplayRect() { }

	// RVA: 0x18160B0
	internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) { }

	// RVA: 0x181672C
	internal void DetachUIDocument(UIDocument uiDocument) { }

}

// Namespace: UnityEngine.UIElements
internal static class RuntimeEventDispatcher
{
	// Methods

	// RVA: 0x1816AA8
	public static EventDispatcher Create() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.RuntimePanel.<>c <>9; // 0x0
	public static UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.FocusEvent,UnityEngine.UIElements.RuntimePanel> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x1817454
	private static void .cctor() { }

	// RVA: 0x18174C0
	public void .ctor() { }

	// RVA: 0x18174C8
	internal void <.ctor>b__5_0(FocusEvent e, RuntimePanel p) { }

}

// Namespace: UnityEngine.UIElements
internal class RuntimePanel
{
	// Fields
	internal static readonly EventDispatcher s_EventDispatcher; // 0x0
	private readonly PanelSettings m_PanelSettings; // 0x1E8

	// Methods

	// RVA: 0x1816D00
	public PanelSettings get_panelSettings() { }

	// RVA: 0x1816D08
	public static RuntimePanel Create(ScriptableObject ownerObject) { }

	// RVA: 0x1816D6C
	private void .ctor(ScriptableObject ownerObject) { }

	// RVA: 0x1817198
	public override void Update() { }

	// RVA: 0x1817364
	private void OnElementFocus(FocusEvent evt) { }

	// RVA: 0x18173F8
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UIDocumentList
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_AttachedUIDocuments; // 0x10

	// Methods

	// RVA: 0x18162C0
	internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument) { }

	// RVA: 0x1816348
	internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex) { }

	// RVA: 0x1816234
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public sealed class UIDocument
{
	// Fields
	internal const string k_RootStyleClassName = "unity-ui-document__root";
	internal const string k_VisualElementNameSuffix = "-container";
	private const int k_DefaultSortingOrder = 0;
	private static int s_CurrentUIDocumentCounter; // 0x0
	internal readonly int m_UIDocumentCreationIndex; // 0x20
	private PanelSettings m_PanelSettings; // 0x28
	private PanelSettings m_PreviousPanelSettings; // 0x30
	private UIDocument m_ParentUI; // 0x38
	private UIDocumentList m_ChildrenContent; // 0x40
	private System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_ChildrenContentCopy; // 0x48
	private VisualTreeAsset sourceAsset; // 0x50
	private VisualElement m_RootVisualElement; // 0x58
	private int m_FirstChildInsertIndex; // 0x60
	private float m_SortingOrder; // 0x64

	// Methods

	// RVA: 0x1817568
	public PanelSettings get_panelSettings() { }

	// RVA: 0x1817570
	public void set_panelSettings(PanelSettings value) { }

	// RVA: 0x1817964
	public UIDocument get_parentUI() { }

	// RVA: 0x181796C
	private void set_parentUI(UIDocument value) { }

	// RVA: 0x1817974
	public VisualTreeAsset get_visualTreeAsset() { }

	// RVA: 0x181797C
	public void set_visualTreeAsset(VisualTreeAsset value) { }

	// RVA: 0x1817560
	public VisualElement get_rootVisualElement() { }

	// RVA: 0x1817F18
	internal int get_firstChildInserIndex() { }

	// RVA: 0x1817F20
	public float get_sortingOrder() { }

	// RVA: 0x1817F28
	public void set_sortingOrder(float value) { }

	// RVA: 0x1817F40
	internal void ApplySortingOrder() { }

	// RVA: 0x1818054
	private void .ctor() { }

	// RVA: 0x18180F8
	private void Awake() { }

	// RVA: 0x1818214
	private void OnEnable() { }

	// RVA: 0x18180FC
	private void SetupFromHierarchy() { }

	// RVA: 0x18183C0
	private UIDocument FindUIDocumentParent() { }

	// RVA: 0x1818498
	internal void Reset() { }

	// RVA: 0x1818628
	private void AddChildAndInsertContentToVisualTree(UIDocument child) { }

	// RVA: 0x1818334
	private void RemoveChild(UIDocument child) { }

	// RVA: 0x18179A4
	private void RecreateUI() { }

	// RVA: 0x18188E4
	private void SetupRootClassList() { }

	// RVA: 0x1817F44
	private void AddRootVisualElementToTree() { }

	// RVA: 0x1818788
	private void RemoveFromHierarchy() { }

	// RVA: 0x1818990
	private void OnDisable() { }

	// RVA: 0x18189D4
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1818E18
	private void OnTransformParentChanged() { }

	// RVA: 0x1818CB4
	internal void ReactToHierarchyChanged() { }

}

// Namespace: UnityEngine.UIElements
internal static class GroupBoxUtility
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBox,UnityEngine.UIElements.IGroupManager> s_GroupManagers; // 0x0
	private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBoxOption,UnityEngine.UIElements.IGroupManager> s_GroupOptionManagerCache; // 0x8
	private static readonly Type k_GenericGroupBoxType; // 0x10

	// Methods

	// RVA: 0x315B3A8
	public static void RegisterGroupBoxOption(T option) { }

	// RVA: 0x315B3A8
	public static void UnregisterGroupBoxOption(T option) { }

	// RVA: 0x315B3A8
	public static void OnOptionSelected(T selectedOption) { }

	// RVA: 0x1818E1C
	private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox) { }

	// RVA: 0x1819510
	private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x18195E4
	private static void OnPanelDestroyed(BaseVisualElementPanel panel) { }

	// RVA: 0x1819810
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class IEnumerableExtensions
{
	// Methods

	// RVA: 0x1819968
	internal static bool HasValues(System.Collections.Generic.IEnumerable<System.String> collection) { }

}

// Namespace: UnityEngine.UIElements
internal interface IGroupBoxOption
{
	// Methods

	// RVA: -1
	public abstract void SetSelected(bool selected) { }

}

// Namespace: UnityEngine.UIElements
internal interface IGroupBox
{
	// Methods

	// RVA: -1
	public abstract void OnOptionAdded(IGroupBoxOption option) { }

	// RVA: -1
	public abstract void OnOptionRemoved(IGroupBoxOption option) { }

}

// Namespace: UnityEngine.UIElements
internal interface IGroupBox<T0>
{}

// Namespace: UnityEngine.UIElements
internal interface IGroupManager
{
	// Methods

	// RVA: -1
	public abstract void Init(IGroupBox groupBox) { }

	// RVA: -1
	public abstract void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	// RVA: -1
	public abstract void RegisterOption(IGroupBoxOption option) { }

	// RVA: -1
	public abstract void UnregisterOption(IGroupBoxOption option) { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultGroupManager
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.IGroupBoxOption> m_GroupOptions; // 0x10
	private IGroupBoxOption m_SelectedOption; // 0x18
	private IGroupBox m_GroupBox; // 0x20

	// Methods

	// RVA: 0x1819C40
	public void Init(IGroupBox groupBox) { }

	// RVA: 0x1819C48
	public void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	// RVA: 0x1819EC0
	public void RegisterOption(IGroupBoxOption option) { }

	// RVA: 0x1819FD8
	public void UnregisterOption(IGroupBoxOption option) { }

	// RVA: 0x18193D0
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x181DEA8
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x181DEFC
	public void .ctor() { }

}

// Namespace: 
private struct GUIGlobals
{
	// Fields
	public Matrix4x4 matrix; // 0x10
	public Color color; // 0x50
	public Color contentColor; // 0x60
	public Color backgroundColor; // 0x70
	public bool enabled; // 0x80
	public bool changed; // 0x81
	public int displayIndex; // 0x84
}

// Namespace: UnityEngine.UIElements
public class IMGUIContainer
{
	// Fields
	private Action m_OnGUIHandler; // 0x3C8
	private ObjectGUIState m_ObjectGUIState; // 0x3D0
	internal bool useOwnerObjectGUIState; // 0x3D8
	private Rect <lastWorldClip>k__BackingField; // 0x3DC
	private bool m_CullingEnabled; // 0x3EC
	private bool m_IsFocusDelegated; // 0x3ED
	private bool m_RefreshCachedLayout; // 0x3EE
	private LayoutCache m_Cache; // 0x3F0
	private Rect m_CachedClippingRect; // 0x3F8
	private Matrix4x4 m_CachedTransform; // 0x408
	private ContextType <contextType>k__BackingField; // 0x448
	private bool lostFocus; // 0x44C
	private bool receivedFocus; // 0x44D
	private FocusChangeDirection focusChangeDirection; // 0x450
	private bool hasFocusableControls; // 0x458
	private int newKeyboardFocusControlID; // 0x45C
	private bool <focusOnlyIfHasFocusableControls>k__BackingField; // 0x460
	public static readonly string ussClassName; // 0x0
	internal static readonly string ussFoldoutChildDepthClassName; // 0x8
	internal static readonly System.Collections.Generic.List<System.String> ussFoldoutChildDepthClassNames; // 0x10
	private GUIGlobals m_GUIGlobals; // 0x464
	private static readonly ProfilerMarker k_OnGUIMarker; // 0x18
	private static readonly ProfilerMarker k_ImmediateCallbackMarker; // 0x20
	private static Event s_DefaultMeasureEvent; // 0x28
	private static Event s_MeasureEvent; // 0x30
	private static Event s_CurrentEvent; // 0x38

	// Methods

	// RVA: 0x181A0B8
	public Action get_onGUIHandler() { }

	// RVA: 0x181A0C0
	public void set_onGUIHandler(Action value) { }

	// RVA: 0x181A128
	internal ObjectGUIState get_guiState() { }

	// RVA: 0x181A218
	internal Rect get_lastWorldClip() { }

	// RVA: 0x181A22C
	internal void set_lastWorldClip(Rect value) { }

	// RVA: 0x181A240
	public bool get_cullingEnabled() { }

	// RVA: 0x181A248
	private LayoutCache get_cache() { }

	// RVA: 0x181A2D8
	private float get_layoutMeasuredWidth() { }

	// RVA: 0x181A36C
	private float get_layoutMeasuredHeight() { }

	// RVA: 0x181A400
	public ContextType get_contextType() { }

	// RVA: 0x181A408
	public void set_contextType(ContextType value) { }

	// RVA: 0x181A410
	internal bool get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0x181A418
	public override bool get_canGrabFocus() { }

	// RVA: 0x181A438
	private static void .cctor() { }

	// RVA: 0x181A7C4
	public void .ctor() { }

	// RVA: 0x181A7CC
	public void .ctor(Action onGUIHandler) { }

	// RVA: 0x181AAA0
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x181ABD4
	private void SaveGlobals() { }

	// RVA: 0x181ACE0
	private void RestoreGlobals() { }

	// RVA: 0x181ADFC
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x181BCE8
	public void MarkDirtyLayout() { }

	// RVA: 0x181BCFC
	internal void ProcessEvent(EventBase evt) { }

	// RVA: 0x181C19C
	private void DoIMGUIRepaint() { }

	// RVA: 0x181BEE8
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	// RVA: 0x181C918
	private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	// RVA: 0x181CAF4
	private bool VerifyBounds(EventBase evt) { }

	// RVA: 0x181CC70
	private bool IsContainerCapturingTheMouse() { }

	// RVA: 0x181CD9C
	private bool IsLocalEvent(EventBase evt) { }

	// RVA: 0x181D05C
	private bool IsEventInsideLocalWindow(EventBase evt) { }

	// RVA: 0x181D254
	private static bool IsDockAreaMouseUp(EventBase evt) { }

	// RVA: 0x181CBA8
	private bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	// RVA: 0x181D40C
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x181C47C
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x181D6CC
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x181DA04
	private void SetFoldoutDepthClass() { }

	// RVA: 0x181DBAC
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x181D3CC
	private Rect GetCurrentClipRect() { }

	// RVA: 0x181D4D4
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, Matrix4x4 transform, Rect clipRect) { }

	// RVA: 0x181DDF0
	public void Dispose() { }

	// RVA: 0x181DE84
	protected virtual void Dispose(bool disposeManaged) { }

	// RVA: 0x181DE9C
	private void <DoOnGUI>b__56_0() { }

}

// Namespace: UnityEngine.UIElements
internal class ImmediateModeException
{
	// Methods

	// RVA: 0x181DFA0
	public void .ctor(Exception inner) { }

}

// Namespace: UnityEngine.UIElements
public enum SelectionType
{
	// Fields
	public int value__; // 0x10
	public const SelectionType None = 0;
	public const SelectionType Single = 1;
	public const SelectionType Multiple = 2;
}

// Namespace: UnityEngine.UIElements
internal interface ISerializableJsonDictionary
{
	// Methods

	// RVA: -1
	public abstract void Set(string key, T value) { }

	// RVA: -1
	public abstract T Get(string key) { }

	// RVA: -1
	public abstract void Overwrite(object obj, string key) { }

	// RVA: -1
	public abstract bool ContainsKey(string key) { }

}

// Namespace: UnityEngine.UIElements
public interface ITransform
{
	// Methods

	// RVA: -1
	public abstract Vector3 get_position() { }

	// RVA: -1
	public abstract void set_position(Vector3 value) { }

	// RVA: -1
	public abstract Vector3 get_scale() { }

}

// Namespace: UnityEngine.UIElements
public enum KeyboardNavigationOperation
{
	// Fields
	public int value__; // 0x10
	public const KeyboardNavigationOperation None = 0;
	public const KeyboardNavigationOperation SelectAll = 1;
	public const KeyboardNavigationOperation Cancel = 2;
	public const KeyboardNavigationOperation Submit = 3;
	public const KeyboardNavigationOperation Previous = 4;
	public const KeyboardNavigationOperation Next = 5;
	public const KeyboardNavigationOperation MoveRight = 6;
	public const KeyboardNavigationOperation MoveLeft = 7;
	public const KeyboardNavigationOperation PageUp = 8;
	public const KeyboardNavigationOperation PageDown = 9;
	public const KeyboardNavigationOperation Begin = 10;
	public const KeyboardNavigationOperation End = 11;
}

// Namespace: 
private struct <>c__DisplayClass4_0
{
	// Fields
	public KeyDownEvent evt; // 0x10
}

// Namespace: UnityEngine.UIElements
public class KeyboardNavigationManipulator
{
	// Fields
	private readonly System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase> m_Action; // 0x18

	// Methods

	// RVA: 0x181E024
	public void .ctor(System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase> action) { }

	// RVA: 0x181E060
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x181E278
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x181E488
	internal void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x181E61C
	private void OnNavigationCancel(NavigationCancelEvent evt) { }

	// RVA: 0x181E65C
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x181E69C
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	// RVA: 0x181E5E4
	private void Invoke(KeyboardNavigationOperation operation, EventBase evt) { }

	// RVA: 0x181E4E8
	internal static KeyboardNavigationOperation <OnKeyDown>g__GetOperation|4_0(UnityEngine.UIElements.KeyboardNavigationManipulator.<>c__DisplayClass4_0& ) { }

}

// Namespace: UnityEngine.UIElements
public struct ManipulatorActivationFilter
{
	// Fields
	private MouseButton <button>k__BackingField; // 0x10
	private EventModifiers <modifiers>k__BackingField; // 0x14
	private int <clickCount>k__BackingField; // 0x18

	// Methods

	// RVA: 0x181E73C
	public MouseButton get_button() { }

	// RVA: 0x181E744
	public void set_button(MouseButton value) { }

	// RVA: 0x181E74C
	public EventModifiers get_modifiers() { }

	// RVA: 0x181E754
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x181E75C
	public int get_clickCount() { }

	// RVA: 0x181E764
	public override bool Equals(object obj) { }

	// RVA: 0x181E814
	public bool Equals(ManipulatorActivationFilter other) { }

	// RVA: 0x181E848
	public override int GetHashCode() { }

	// RVA: 0x181E8D4
	public bool Matches(IMouseEvent e) { }

	// RVA: 0x181EA78
	private bool HasModifiers(IMouseEvent e) { }

	// RVA: 0x181ED04
	public bool Matches(IPointerEvent e) { }

	// RVA: 0x181EEA8
	private bool HasModifiers(IPointerEvent e) { }

	// RVA: 0x181ECB0
	private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command) { }

}

// Namespace: UnityEngine.UIElements
public interface IManipulator
{
	// Methods

	// RVA: -1
	public abstract void set_target(VisualElement value) { }

}

// Namespace: UnityEngine.UIElements
public abstract class Manipulator
{
	// Fields
	private VisualElement m_Target; // 0x10

	// Methods

	// RVA: -1
	protected abstract void RegisterCallbacksOnTarget() { }

	// RVA: -1
	protected abstract void UnregisterCallbacksFromTarget() { }

	// RVA: 0x181E270
	public VisualElement get_target() { }

	// RVA: 0x181F0E0
	public void set_target(VisualElement value) { }

	// RVA: 0x181E058
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public enum MouseButton
{
	// Fields
	public int value__; // 0x10
	public const MouseButton LeftMouse = 0;
	public const MouseButton RightMouse = 1;
	public const MouseButton MiddleMouse = 2;
}

// Namespace: UnityEngine.UIElements
public static class MouseCaptureController
{
	// Methods

	// RVA: 0x181D60C
	public static bool HasMouseCapture(IEventHandler handler) { }

	// RVA: 0x181F158
	public static void CaptureMouse(IEventHandler handler) { }

	// RVA: 0x181F230
	public static void ReleaseMouse(IEventHandler handler) { }

}

// Namespace: UnityEngine.UIElements
public abstract class MouseManipulator
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> <activators>k__BackingField; // 0x18
	private ManipulatorActivationFilter m_currentActivator; // 0x20

	// Methods

	// RVA: 0x181F308
	public System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> get_activators() { }

	// RVA: 0x181F310
	private void set_activators(System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> value) { }

	// RVA: 0x181F318
	protected void .ctor() { }

	// RVA: 0x181F3A4
	protected bool CanStartManipulation(IMouseEvent e) { }

	// RVA: 0x181F5BC
	protected bool CanStopManipulation(IMouseEvent e) { }

}

// Namespace: UnityEngine.UIElements
internal struct MeshWriteDataInterface
{
	// Fields
	public IntPtr vertices; // 0x10
	public IntPtr indices; // 0x18
	public int vertexCount; // 0x20
	public int indexCount; // 0x24
}

// Namespace: UnityEngine.UIElements
internal static class UIPainter2D
{
	// Methods

	// RVA: 0x181F68C
	public static IntPtr Create(bool computeBBox) { }

	// RVA: 0x181F6DC
	public static void Destroy(IntPtr handle) { }

	// RVA: 0x181F72C
	public static void Reset(IntPtr handle) { }

}

// Namespace: 
public struct NativeColorPage
{
	// Fields
	public int isValid; // 0x10
	public Color32 pageAndID; // 0x14
}

// Namespace: 
public struct NativeBorderParams
{
	// Fields
	public Rect rect; // 0x10
	public Color leftColor; // 0x20
	public Color topColor; // 0x30
	public Color rightColor; // 0x40
	public Color bottomColor; // 0x50
	public float leftWidth; // 0x60
	public float topWidth; // 0x64
	public float rightWidth; // 0x68
	public float bottomWidth; // 0x6C
	public Vector2 topLeftRadius; // 0x70
	public Vector2 topRightRadius; // 0x78
	public Vector2 bottomRightRadius; // 0x80
	public Vector2 bottomLeftRadius; // 0x88
	internal NativeColorPage leftColorPage; // 0x90
	internal NativeColorPage topColorPage; // 0x98
	internal NativeColorPage rightColorPage; // 0xA0
	internal NativeColorPage bottomColorPage; // 0xA8
}

// Namespace: 
public struct NativeRectParams
{
	// Fields
	public Rect rect; // 0x10
	public Rect subRect; // 0x20
	public Rect uv; // 0x30
	public Rect uvRegion; // 0x40
	public Color color; // 0x50
	public ScaleMode scaleMode; // 0x60
	public Vector2 topLeftRadius; // 0x64
	public Vector2 topRightRadius; // 0x6C
	public Vector2 bottomRightRadius; // 0x74
	public Vector2 bottomLeftRadius; // 0x7C
	public Rect backgroundRepeatRect; // 0x84
	public Vector2 contentSize; // 0x94
	public Vector2 textureSize; // 0x9C
	public float texturePixelsPerPoint; // 0xA4
	public int leftSlice; // 0xA8
	public int topSlice; // 0xAC
	public int rightSlice; // 0xB0
	public int bottomSlice; // 0xB4
	public float sliceScale; // 0xB8
	public Vector4 rectInset; // 0xBC
	public NativeColorPage colorPage; // 0xCC
}

// Namespace: UnityEngine.UIElements
internal static class MeshBuilderNative
{
	// Methods

	// RVA: 0x181F77C
	public static MeshWriteDataInterface MakeBorder(NativeBorderParams borderParams, float posZ) { }

	// RVA: 0x181F860
	public static MeshWriteDataInterface MakeSolidRect(NativeRectParams rectParams, float posZ) { }

	// RVA: 0x181F944
	public static MeshWriteDataInterface MakeTexturedRect(NativeRectParams rectParams, float posZ) { }

	// RVA: 0x181FA28
	public static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage, int settingIndexOffset, int finalVertexCount, int finalIndexCount) { }

	// RVA: 0x181FBD8
	public static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage, int settingIndexOffset) { }

	// RVA: 0x181F800
	private static void MakeBorder_Injected(NativeBorderParams borderParams, float posZ, MeshWriteDataInterface ret) { }

	// RVA: 0x181F8E4
	private static void MakeSolidRect_Injected(NativeRectParams rectParams, float posZ, MeshWriteDataInterface ret) { }

	// RVA: 0x181F9C8
	private static void MakeTexturedRect_Injected(NativeRectParams rectParams, float posZ, MeshWriteDataInterface ret) { }

	// RVA: 0x181FB0C
	private static void MakeVectorGraphicsStretchBackground_Injected(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage, int settingIndexOffset, int finalVertexCount, int finalIndexCount, MeshWriteDataInterface ret) { }

	// RVA: 0x181FC9C
	private static void MakeVectorGraphics9SliceBackground_Injected(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage, int settingIndexOffset, MeshWriteDataInterface ret) { }

}

// Namespace: UnityEngine.UIElements
internal static class UIElementsRuntimeUtilityNative
{
	// Fields
	internal static Action RepaintOverlayPanelsCallback; // 0x0
	internal static Action UpdateRuntimePanelsCallback; // 0x8
	internal static Action RepaintOffscreenPanelsCallback; // 0x10

	// Methods

	// RVA: 0x181FD4C
	public static void RepaintOverlayPanels() { }

	// RVA: 0x181FDB4
	public static void UpdateRuntimePanels() { }

	// RVA: 0x181FE1C
	public static void RepaintOffscreenPanels() { }

	// RVA: 0x181FE84
	public static void RegisterPlayerloopCallback() { }

	// RVA: 0x181FEC4
	public static void UnregisterPlayerloopCallback() { }

	// RVA: 0x181FF04
	public static void VisualElementCreation() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ObjectPool.<>c<T> <>9; // 0x0
	public static System.Func<T> <>9__6_0; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal T <.ctor>b__6_0() { }

}

// Namespace: UnityEngine.UIElements
internal class ObjectPool<T0>
{
	// Fields
	private readonly System.Collections.Generic.Stack<T> m_Stack; // 0x0
	private int m_MaxSize; // 0x0
	internal System.Func<T> CreateFunc; // 0x0

	// Methods

	// RVA: 0x30A14A4
	public int get_maxSize() { }

	// RVA: 0x30A24F0
	public void set_maxSize(int value) { }

	// RVA: 0x30A2828
	public void .ctor(System.Func<T> CreateFunc, int maxSize) { }

	// RVA: 0x30A14A4
	public int Size() { }

	// RVA: 0x315B3A8
	public T Get() { }

	// RVA: 0x315B3A8
	public void Release(T element) { }

}

// Namespace: UnityEngine.UIElements
public enum ContextType
{
	// Fields
	public int value__; // 0x10
	public const ContextType Player = 0;
	public const ContextType Editor = 1;
}

// Namespace: UnityEngine.UIElements
internal enum VersionChangeType
{
	// Fields
	public int value__; // 0x10
	public const VersionChangeType Bindings = 1;
	public const VersionChangeType ViewData = 2;
	public const VersionChangeType Hierarchy = 4;
	public const VersionChangeType Layout = 8;
	public const VersionChangeType StyleSheet = 16;
	public const VersionChangeType Styles = 32;
	public const VersionChangeType Overflow = 64;
	public const VersionChangeType BorderRadius = 128;
	public const VersionChangeType BorderWidth = 256;
	public const VersionChangeType Transform = 512;
	public const VersionChangeType Size = 1024;
	public const VersionChangeType Repaint = 2048;
	public const VersionChangeType Opacity = 4096;
	public const VersionChangeType Color = 8192;
	public const VersionChangeType RenderHints = 16384;
	public const VersionChangeType TransitionProperty = 32768;
	public const VersionChangeType EventCallbackCategories = 65536;
	public const VersionChangeType Picking = 1048576;
}

// Namespace: UnityEngine.UIElements
public enum UsageHints
{
	// Fields
	public int value__; // 0x10
	public const UsageHints None = 0;
	public const UsageHints DynamicTransform = 1;
	public const UsageHints GroupTransform = 2;
	public const UsageHints MaskContainer = 4;
	public const UsageHints DynamicColor = 8;
}

// Namespace: UnityEngine.UIElements
internal enum RenderHints
{
	// Fields
	public int value__; // 0x10
	public const RenderHints None = 0;
	public const RenderHints GroupTransform = 1;
	public const RenderHints BoneTransform = 2;
	public const RenderHints ClipWithScissors = 4;
	public const RenderHints MaskContainer = 8;
	public const RenderHints DynamicColor = 16;
	public const RenderHints DirtyOffset = 5;
	public const RenderHints DirtyGroupTransform = 32;
	public const RenderHints DirtyBoneTransform = 64;
	public const RenderHints DirtyClipWithScissors = 128;
	public const RenderHints DirtyMaskContainer = 256;
	public const RenderHints DirtyDynamicColor = 512;
	public const RenderHints DirtyAll = 992;
}

// Namespace: UnityEngine.UIElements
internal struct PanelClearSettings
{
	// Fields
	public bool clearDepthStencil; // 0x10
	public bool clearColor; // 0x11
	public Color color; // 0x14
}

// Namespace: UnityEngine.UIElements
internal class RepaintData
{
	// Fields
	private Matrix4x4 <currentOffset>k__BackingField; // 0x10
	private Vector2 <mousePosition>k__BackingField; // 0x50
	private Rect <currentWorldClip>k__BackingField; // 0x58
	private Event <repaintEvent>k__BackingField; // 0x68

	// Methods

	// RVA: 0x181FF44
	public Matrix4x4 get_currentOffset() { }

	// RVA: 0x181FF58
	public Rect get_currentWorldClip() { }

	// RVA: 0x181FF64
	public Event get_repaintEvent() { }

	// RVA: 0x181FF6C
	public void set_repaintEvent(Event value) { }

	// RVA: 0x181FF74
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class HierarchyEvent
{
	// Methods

	// RVA: 0x181FFD8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18200FC
	public virtual void Invoke(VisualElement ve, HierarchyChangeType changeType) { }

}

// Namespace: UnityEngine.UIElements
public interface IPanel
{
	// Methods

	// RVA: -1
	public abstract VisualElement get_visualTree() { }

	// RVA: -1
	public abstract EventDispatcher get_dispatcher() { }

	// RVA: -1
	public abstract ContextType get_contextType() { }

	// RVA: -1
	public abstract FocusController get_focusController() { }

	// RVA: -1
	public abstract VisualElement Pick(Vector2 point) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class BaseVisualElementPanel
{
	// Fields
	private System.Action<UnityEngine.UIElements.BaseVisualElementPanel> panelDisposed; // 0x10
	private UIElementsBridge m_UIElementsBridge; // 0x18
	private float m_Scale; // 0x20
	internal YogaConfig yogaConfig; // 0x28
	private float m_PixelsPerPoint; // 0x30
	private float <referenceSpritePixelsPerUnit>k__BackingField; // 0x34
	private PanelClearSettings <clearSettings>k__BackingField; // 0x38
	private bool <duringLayoutPhase>k__BackingField; // 0x4C
	private RepaintData <repaintData>k__BackingField; // 0x50
	private ICursorManager <cursorManager>k__BackingField; // 0x58
	private ContextualMenuManager <contextualMenuManager>k__BackingField; // 0x60
	private bool <disposed>k__BackingField; // 0x68
	internal ElementUnderPointer m_TopElementUnderPointers; // 0x70
	private Action standardShaderChanged; // 0x78
	private Action standardWorldSpaceShaderChanged; // 0x80
	private Action atlasChanged; // 0x88
	private System.Action<UnityEngine.Material> updateMaterial; // 0x90
	private HierarchyEvent hierarchyChanged; // 0x98
	private System.Action<UnityEngine.UIElements.IPanel> beforeUpdate; // 0xA0

	// Methods

	// RVA: -1
	public abstract EventInterests get_IMGUIEventInterests() { }

	// RVA: -1
	public abstract void set_IMGUIEventInterests(EventInterests value) { }

	// RVA: -1
	public abstract ScriptableObject get_ownerObject() { }

	// RVA: -1
	protected abstract void set_ownerObject(ScriptableObject value) { }

	// RVA: -1
	public abstract SavePersistentViewData get_saveViewData() { }

	// RVA: -1
	public abstract GetViewDataDictionary get_getViewDataDictionary() { }

	// RVA: -1
	public abstract int get_IMGUIContainersCount() { }

	// RVA: -1
	public abstract void set_IMGUIContainersCount(int value) { }

	// RVA: -1
	public abstract FocusController get_focusController() { }

	// RVA: -1
	public abstract void set_focusController(FocusController value) { }

	// RVA: -1
	public abstract IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0x181945C
	internal void add_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x181975C
	internal void remove_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x1820110
	internal UIElementsBridge get_uiElementsBridge() { }

	// RVA: 0x1820178
	protected void .ctor() { }

	// RVA: 0x18202D0
	public void Dispose() { }

	// RVA: 0x1820364
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1
	public abstract void Repaint(Event e) { }

	// RVA: -1
	public abstract void ValidateFocus() { }

	// RVA: -1
	public abstract void ValidateLayout() { }

	// RVA: -1
	public abstract void UpdateAnimations() { }

	// RVA: -1
	public abstract void UpdateBindings() { }

	// RVA: -1
	public abstract void ApplyStyles() { }

	// RVA: 0x18204F0
	internal float get_scale() { }

	// RVA: 0x1815F58
	internal void set_scale(float value) { }

	// RVA: 0x1820508
	internal void set_pixelsPerPoint(float value) { }

	// RVA: 0x18204F8
	public float get_scaledPixelsPerPoint() { }

	// RVA: 0x182061C
	public float get_referenceSpritePixelsPerUnit() { }

	// RVA: 0x1820624
	public void set_referenceSpritePixelsPerUnit(float value) { }

	// RVA: 0x182062C
	internal PanelClearSettings get_clearSettings() { }

	// RVA: 0x1820640
	internal void set_clearSettings(PanelClearSettings value) { }

	// RVA: 0x1820654
	internal bool get_duringLayoutPhase() { }

	// RVA: 0x182065C
	internal void set_duringLayoutPhase(bool value) { }

	// RVA: -1
	internal abstract UInt32 get_version() { }

	// RVA: -1
	internal abstract UInt32 get_hierarchyVersion() { }

	// RVA: -1
	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	// RVA: 0x1820664
	internal virtual RepaintData get_repaintData() { }

	// RVA: 0x182066C
	internal virtual void set_repaintData(RepaintData value) { }

	// RVA: 0x1820674
	internal virtual ICursorManager get_cursorManager() { }

	// RVA: 0x182067C
	internal virtual void set_cursorManager(ICursorManager value) { }

	// RVA: 0x1820684
	public ContextualMenuManager get_contextualMenuManager() { }

	// RVA: 0x182068C
	internal void set_contextualMenuManager(ContextualMenuManager value) { }

	// RVA: -1
	public abstract VisualElement get_visualTree() { }

	// RVA: -1
	public abstract EventDispatcher get_dispatcher() { }

	// RVA: -1
	public abstract void set_dispatcher(EventDispatcher value) { }

	// RVA: 0x1820694
	internal void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: -1
	internal abstract IScheduler get_scheduler() { }

	// RVA: -1
	internal abstract IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	// RVA: -1
	internal abstract void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	// RVA: -1
	public abstract ContextType get_contextType() { }

	// RVA: -1
	protected abstract void set_contextType(ContextType value) { }

	// RVA: -1
	public abstract VisualElement Pick(Vector2 point) { }

	// RVA: -1
	public abstract VisualElement PickAll(Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked) { }

	// RVA: 0x1820764
	internal bool get_disposed() { }

	// RVA: 0x182076C
	private void set_disposed(bool value) { }

	// RVA: -1
	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x180AD3C
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x1809738
	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) { }

	// RVA: 0x180CEFC
	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) { }

	// RVA: 0x1820774
	internal void CommitElementUnderPointers() { }

	// RVA: -1
	internal abstract Shader get_standardShader() { }

	// RVA: 0x18207DC
	internal virtual Shader get_standardWorldSpaceShader() { }

	// RVA: 0x18207E4
	internal void add_standardShaderChanged(Action value) { }

	// RVA: 0x1820888
	internal void remove_standardShaderChanged(Action value) { }

	// RVA: 0x182092C
	internal void add_standardWorldSpaceShaderChanged(Action value) { }

	// RVA: 0x18209D0
	internal void remove_standardWorldSpaceShaderChanged(Action value) { }

	// RVA: 0x1820A74
	internal void add_atlasChanged(Action value) { }

	// RVA: 0x1820B18
	internal void remove_atlasChanged(Action value) { }

	// RVA: 0x1820BBC
	protected void InvokeAtlasChanged() { }

	// RVA: -1
	public abstract AtlasBase get_atlas() { }

	// RVA: -1
	public abstract void set_atlas(AtlasBase value) { }

	// RVA: 0x1820BD8
	internal void InvokeUpdateMaterial(Material mat) { }

	// RVA: 0x1820BF4
	internal void add_hierarchyChanged(HierarchyEvent value) { }

	// RVA: 0x1820C98
	internal void remove_hierarchyChanged(HierarchyEvent value) { }

	// RVA: 0x1820D3C
	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	// RVA: 0x1820D58
	internal void InvokeBeforeUpdate() { }

	// RVA: 0x1820D78
	internal void UpdateElementUnderPointers() { }

	// RVA: 0x1821100
	private void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x1821104
	private void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x1817258
	public virtual void Update() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class LoadResourceFunction
{
	// Methods

	// RVA: 0x1821108
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18211C4
	public virtual object Invoke(string pathName, Type type, float dpiScaling) { }

}

// Namespace: UnityEngine.UIElements
internal sealed class TimeMsFunction
{
	// Methods

	// RVA: 0x18211D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1821278
	public virtual Int64 Invoke() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class GetViewDataDictionary
{
	// Methods

	// RVA: 0x182128C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x182132C
	public virtual ISerializableJsonDictionary Invoke() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class SavePersistentViewData
{
	// Methods

	// RVA: 0x1821340
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18213E0
	public virtual void Invoke() { }

}

// Namespace: UnityEngine.UIElements
internal class Panel
{
	// Fields
	private VisualElement m_RootContainer; // 0xA8
	private VisualTreeUpdater m_VisualTreeUpdater; // 0xB0
	private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; // 0xB8
	private string m_PanelName; // 0xC0
	private UInt32 m_Version; // 0xC8
	private UInt32 m_RepaintVersion; // 0xCC
	private UInt32 m_HierarchyVersion; // 0xD0
	private ProfilerMarker m_MarkerBeforeUpdate; // 0xD8
	private ProfilerMarker m_MarkerUpdate; // 0xE0
	private ProfilerMarker m_MarkerLayout; // 0xE8
	private ProfilerMarker m_MarkerBindings; // 0xF0
	private ProfilerMarker m_MarkerAnimations; // 0xF8
	private static ProfilerMarker s_MarkerPickAll; // 0x0
	private EventDispatcher <dispatcher>k__BackingField; // 0x100
	private TimerEventScheduler m_Scheduler; // 0x108
	private ScriptableObject <ownerObject>k__BackingField; // 0x110
	private ContextType <contextType>k__BackingField; // 0x118
	private SavePersistentViewData <saveViewData>k__BackingField; // 0x120
	private GetViewDataDictionary <getViewDataDictionary>k__BackingField; // 0x128
	private FocusController <focusController>k__BackingField; // 0x130
	private EventInterests <IMGUIEventInterests>k__BackingField; // 0x138
	private static LoadResourceFunction <loadResourceFunc>k__BackingField; // 0x8
	private bool m_JustReceivedFocus; // 0x13B
	private static TimeMsFunction <TimeSinceStartup>k__BackingField; // 0x10
	private int <IMGUIContainersCount>k__BackingField; // 0x13C
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; // 0x140
	private Shader m_StandardShader; // 0x148
	private AtlasBase m_Atlas; // 0x150
	private bool m_ValidatingLayout; // 0x158
	private static System.Action<UnityEngine.UIElements.Panel> beforeAnyRepaint; // 0x18

	// Methods

	// RVA: 0x18213F4
	public sealed override VisualElement get_visualTree() { }

	// RVA: 0x18213FC
	public sealed override EventDispatcher get_dispatcher() { }

	// RVA: 0x1821404
	public sealed override void set_dispatcher(EventDispatcher value) { }

	// RVA: 0x1821414
	public TimerEventScheduler get_timerEventScheduler() { }

	// RVA: 0x18214A4
	internal override IScheduler get_scheduler() { }

	// RVA: 0x1821534
	internal override IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	// RVA: 0x182153C
	internal override void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	// RVA: 0x1821614
	public override ScriptableObject get_ownerObject() { }

	// RVA: 0x182161C
	protected override void set_ownerObject(ScriptableObject value) { }

	// RVA: 0x182162C
	public override ContextType get_contextType() { }

	// RVA: 0x1821634
	protected override void set_contextType(ContextType value) { }

	// RVA: 0x182163C
	public override SavePersistentViewData get_saveViewData() { }

	// RVA: 0x1821644
	public override GetViewDataDictionary get_getViewDataDictionary() { }

	// RVA: 0x182164C
	public sealed override FocusController get_focusController() { }

	// RVA: 0x1821654
	public sealed override void set_focusController(FocusController value) { }

	// RVA: 0x1821664
	public override EventInterests get_IMGUIEventInterests() { }

	// RVA: 0x1821674
	public override void set_IMGUIEventInterests(EventInterests value) { }

	// RVA: 0x1821684
	private static LoadResourceFunction get_loadResourceFunc() { }

	// RVA: 0x1821700
	internal static object LoadResource(string pathName, Type type, float dpiScaling) { }

	// RVA: 0x1821880
	internal void Focus() { }

	// RVA: 0x182188C
	internal void Blur() { }

	// RVA: 0x182194C
	public override void ValidateFocus() { }

	// RVA: 0x18219F8
	internal string get_name() { }

	// RVA: 0x1817170
	internal void set_name(string value) { }

	// RVA: 0x1821A00
	private void CreateMarkers() { }

	// RVA: 0x1821C58
	private static TimeMsFunction get_TimeSinceStartup() { }

	// RVA: 0x1821CD4
	public override int get_IMGUIContainersCount() { }

	// RVA: 0x1821CDC
	public override void set_IMGUIContainersCount(int value) { }

	// RVA: 0x1821CE4
	public override IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0x1821CEC
	internal override UInt32 get_version() { }

	// RVA: 0x1821CF4
	internal override UInt32 get_hierarchyVersion() { }

	// RVA: 0x1821CFC
	internal override Shader get_standardShader() { }

	// RVA: 0x1821D04
	public override AtlasBase get_atlas() { }

	// RVA: 0x1821D0C
	public override void set_atlas(AtlasBase value) { }

	// RVA: 0x1821D9C
	public void .ctor(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) { }

	// RVA: 0x18221A4
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1822210
	public static Int64 TimeSinceStartupMs() { }

	// RVA: 0x1822320
	internal static Int64 DefaultTimeSinceStartupMs() { }

	// RVA: 0x182235C
	private static VisualElement PickAll(VisualElement root, Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked, bool includeIgnoredElement) { }

	// RVA: 0x1822420
	private static VisualElement PerformPick(VisualElement root, Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked, bool includeIgnoredElement) { }

	// RVA: 0x182273C
	public override VisualElement PickAll(Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked) { }

	// RVA: 0x18228D0
	public override VisualElement Pick(Vector2 point) { }

	// RVA: 0x1822CF4
	public override void ValidateLayout() { }

	// RVA: 0x1822D88
	public override void UpdateAnimations() { }

	// RVA: 0x1822DD0
	public override void UpdateBindings() { }

	// RVA: 0x1822E18
	public override void ApplyStyles() { }

	// RVA: 0x1822E3C
	private void UpdateForRepaint() { }

	// RVA: 0x1822EBC
	public override void Repaint(Event e) { }

	// RVA: 0x1823198
	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x18231E8
	internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x1823208
	private static void .cctor() { }

	// RVA: 0x1822C08
	internal static Vector2Int <Pick>g__PixelOf|101_0(Vector2 p) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.BaseRuntimePanel.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183E024
	private static void .cctor() { }

	// RVA: 0x183E090
	public void .ctor() { }

	// RVA: 0x183E098
	internal Vector2 <.cctor>b__47_0(Vector2 p) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class BaseRuntimePanel
{
	// Fields
	private GameObject m_SelectableGameObject; // 0x160
	private static int s_CurrentRuntimePanelCounter; // 0x0
	internal readonly int m_RuntimePanelCreationIndex; // 0x168
	private float m_SortingPriority; // 0x16C
	internal int resolvedSortingIndex; // 0x170
	private Action destroyed; // 0x178
	private Shader m_StandardWorldSpaceShader; // 0x180
	private bool m_DrawToCameras; // 0x188
	internal RenderTexture targetTexture; // 0x190
	internal Matrix4x4 panelToWorld; // 0x198
	private int <targetDisplay>k__BackingField; // 0x1D8
	internal static readonly System.Func<UnityEngine.Vector2,UnityEngine.Vector2> DefaultScreenToPanelSpace; // 0x8
	private System.Func<UnityEngine.Vector2,UnityEngine.Vector2> m_ScreenToPanelSpace; // 0x1E0

	// Methods

	// RVA: 0x183CB78
	public GameObject get_selectableGameObject() { }

	// RVA: 0x183CB80
	public void set_selectableGameObject(GameObject value) { }

	// RVA: 0x183D024
	public float get_sortingPriority() { }

	// RVA: 0x183D02C
	public void set_sortingPriority(float value) { }

	// RVA: 0x183D144
	public void add_destroyed(Action value) { }

	// RVA: 0x183D1EC
	public void remove_destroyed(Action value) { }

	// RVA: 0x183D294
	protected void .ctor(ScriptableObject ownerObject, EventDispatcher dispatcher) { }

	// RVA: 0x183D3C8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x183D424
	internal override Shader get_standardWorldSpaceShader() { }

	// RVA: 0x183D42C
	internal bool get_drawToCameras() { }

	// RVA: 0x183D434
	internal void set_drawToCameras(bool value) { }

	// RVA: 0x183D5A8
	internal int get_targetDisplay() { }

	// RVA: 0x183D5B0
	internal void set_targetDisplay(int value) { }

	// RVA: 0x183D5B8
	internal int get_screenRenderingWidth() { }

	// RVA: 0x183D704
	internal int get_screenRenderingHeight() { }

	// RVA: 0x183D78C
	internal static int getScreenRenderingHeight(int display) { }

	// RVA: 0x183D640
	internal static int getScreenRenderingWidth(int display) { }

	// RVA: 0x183D850
	public override void Repaint(Event e) { }

	// RVA: 0x183DB10
	public System.Func<UnityEngine.Vector2,UnityEngine.Vector2> get_screenToPanelSpace() { }

	// RVA: 0x183DB18
	public void set_screenToPanelSpace(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> value) { }

	// RVA: 0x183DBB4
	internal Vector2 ScreenToPanel(Vector2 screen) { }

	// RVA: 0x183DC24
	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, Vector2 panelPosition, Vector2 panelDelta, bool allowOutside) { }

	// RVA: 0x183CC54
	private void AssignPanelToComponents(BaseRuntimePanel panel) { }

	// RVA: 0x183DDEC
	internal void PointerLeavesPanel(int pointerId, Vector2 position) { }

	// RVA: 0x183DEAC
	internal void PointerEntersPanel(int pointerId, Vector2 position) { }

	// RVA: 0x183DF4C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal interface IRuntimePanelComponent
{
	// Methods

	// RVA: -1
	public abstract void set_panel(IPanel value) { }

}

// Namespace: UnityEngine.UIElements
public static class PointerCaptureHelper
{
	// Methods

	// RVA: 0x183E09C
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	// RVA: 0x183E1CC
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0x183E25C
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x183E3F4
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x183E4C0
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	// RVA: 0x183E604
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	// RVA: 0x183E73C
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	// RVA: 0x183E874
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	// RVA: 0x183E9A4
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	// RVA: 0x183ED18
	internal static void ProcessPointerCapture(IPanel panel, int pointerId) { }

}

// Namespace: UnityEngine.UIElements
internal class PointerDispatchState
{
	// Fields
	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20

	// Methods

	// RVA: 0x183F6D0
	public void .ctor() { }

	// RVA: 0x183F7D0
	internal void Reset() { }

	// RVA: 0x183E5D0
	public IEventHandler GetCapturingElement(int pointerId) { }

	// RVA: 0x183E220
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0x183E298
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x183E704
	public void ReleasePointer(int pointerId) { }

	// RVA: 0x183E468
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x183EDF8
	public void ProcessPointerCapture(int pointerId) { }

	// RVA: 0x183E83C
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x183E970
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x183EBB8
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

// Namespace: UnityEngine.UIElements
public abstract class PointerManipulator
{
	// Fields
	private int m_CurrentPointerId; // 0x2C

	// Methods

	// RVA: 0x183F898
	protected bool CanStartManipulation(IPointerEvent e) { }

	// RVA: 0x183FB28
	protected bool CanStopManipulation(IPointerEvent e) { }

	// RVA: 0x183FBF4
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class ProjectionUtils
{
	// Methods

	// RVA: 0x183FBFC
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far) { }

}

// Namespace: UnityEngine.UIElements
internal struct SafeHandleAccess
{
	// Fields
	private IntPtr m_Handle; // 0x10

	// Methods

	// RVA: 0x183FC6C
	public void .ctor(IntPtr ptr) { }

	// RVA: 0x183FC74
	public bool IsNull() { }

	// RVA: 0x183FC84
	public static IntPtr op_Implicit(SafeHandleAccess a) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIRAtlasAllocator.Row.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1841128
	private static void .cctor() { }

	// RVA: 0x1841194
	public void .ctor() { }

	// RVA: 0x184119C
	internal Row <.cctor>b__21_0() { }

}

// Namespace: 
private class Row
{
	// Fields
	private static UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.Row> s_Pool; // 0x0
	private int <offsetX>k__BackingField; // 0x10
	private int <offsetY>k__BackingField; // 0x14
	private int <width>k__BackingField; // 0x18
	private int <height>k__BackingField; // 0x1C
	public int Cursor; // 0x20

	// Methods

	// RVA: 0x1840FC8
	public int get_offsetX() { }

	// RVA: 0x1840FD0
	private void set_offsetX(int value) { }

	// RVA: 0x1840FD8
	public int get_offsetY() { }

	// RVA: 0x1840FE0
	private void set_offsetY(int value) { }

	// RVA: 0x1840FE8
	public int get_width() { }

	// RVA: 0x1840FF0
	private void set_width(int value) { }

	// RVA: 0x1840FF8
	private void set_height(int value) { }

	// RVA: 0x1840D10
	public static Row Acquire(int offsetX, int offsetY, int width, int height) { }

	// RVA: 0x183FF9C
	public void Release() { }

	// RVA: 0x1841000
	public void .ctor() { }

	// RVA: 0x1841008
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIRAtlasAllocator.AreaNode.<>c <>9; // 0x0

	// Methods

	// RVA: 0x184131C
	private static void .cctor() { }

	// RVA: 0x1841388
	public void .ctor() { }

	// RVA: 0x1841390
	internal AreaNode <.cctor>b__9_0() { }

}

// Namespace: 
private class AreaNode
{
	// Fields
	private static UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.UIRAtlasAllocator.AreaNode> s_Pool; // 0x0
	public RectInt rect; // 0x10
	public AreaNode previous; // 0x20
	public AreaNode next; // 0x28

	// Methods

	// RVA: 0x1840428
	public static AreaNode Acquire(RectInt rect) { }

	// RVA: 0x1840050
	public void Release() { }

	// RVA: 0x1840DEC
	public void RemoveFromChain() { }

	// RVA: 0x1840E50
	public void AddAfter(AreaNode previous) { }

	// RVA: 0x18411F4
	public void .ctor() { }

	// RVA: 0x18411FC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UIRAtlasAllocator
{
	// Fields
	private readonly int <maxAtlasSize>k__BackingField; // 0x10
	private readonly int <maxImageWidth>k__BackingField; // 0x14
	private readonly int <maxImageHeight>k__BackingField; // 0x18
	private int <virtualWidth>k__BackingField; // 0x1C
	private int <virtualHeight>k__BackingField; // 0x20
	private int <physicalWidth>k__BackingField; // 0x24
	private int <physicalHeight>k__BackingField; // 0x28
	private AreaNode m_FirstUnpartitionedArea; // 0x30
	private Row[] m_OpenRows; // 0x38
	private int m_1SidePadding; // 0x40
	private int m_2SidePadding; // 0x44
	private static ProfilerMarker s_MarkerTryAllocate; // 0x0
	private bool <disposed>k__BackingField; // 0x48

	// Methods

	// RVA: 0x183FCE8
	public int get_maxAtlasSize() { }

	// RVA: 0x183FCF0
	public int get_maxImageWidth() { }

	// RVA: 0x183FCF8
	public int get_maxImageHeight() { }

	// RVA: 0x183FD00
	public int get_virtualWidth() { }

	// RVA: 0x183FD08
	private void set_virtualWidth(int value) { }

	// RVA: 0x183FD10
	public int get_virtualHeight() { }

	// RVA: 0x183FD18
	private void set_virtualHeight(int value) { }

	// RVA: 0x183FD20
	public int get_physicalWidth() { }

	// RVA: 0x183FD28
	private void set_physicalWidth(int value) { }

	// RVA: 0x183FD30
	public int get_physicalHeight() { }

	// RVA: 0x183FD38
	private void set_physicalHeight(int value) { }

	// RVA: 0x183FD40
	protected bool get_disposed() { }

	// RVA: 0x183FD48
	private void set_disposed(bool value) { }

	// RVA: 0x183FD50
	public void Dispose() { }

	// RVA: 0x183FDE0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18400F4
	private static int GetLog2OfNextPower(int n) { }

	// RVA: 0x1840278
	public void .ctor(int initialAtlasSize, int maxAtlasSize, int sidePadding) { }

	// RVA: 0x1840614
	public bool TryAllocate(int width, int height, RectInt location) { }

	// RVA: 0x1840A34
	private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) { }

	// RVA: 0x1840510
	private void BuildAreas() { }

	// RVA: 0x1840F48
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DynamicAtlasPage
{
	// Fields
	private TextureId <textureId>k__BackingField; // 0x10
	private RenderTexture <atlas>k__BackingField; // 0x18
	private readonly RenderTextureFormat <format>k__BackingField; // 0x20
	private readonly FilterMode <filterMode>k__BackingField; // 0x24
	private readonly Vector2Int <minSize>k__BackingField; // 0x28
	private readonly Vector2Int <maxSize>k__BackingField; // 0x30
	private readonly int m_1Padding; // 0x38
	private readonly int m_2Padding; // 0x3C
	private Allocator2D m_Allocator; // 0x40
	private TextureBlitter m_Blitter; // 0x48
	private Vector2Int m_CurrentSize; // 0x50
	private static int s_TextureCounter; // 0x0
	private bool <disposed>k__BackingField; // 0x58

	// Methods

	// RVA: 0x18413E8
	public TextureId get_textureId() { }

	// RVA: 0x18413F0
	private void set_textureId(TextureId value) { }

	// RVA: 0x18413F8
	public RenderTexture get_atlas() { }

	// RVA: 0x1841400
	private void set_atlas(RenderTexture value) { }

	// RVA: 0x1841408
	public RenderTextureFormat get_format() { }

	// RVA: 0x1841410
	public FilterMode get_filterMode() { }

	// RVA: 0x1841418
	public void .ctor(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize) { }

	// RVA: 0x18415B8
	protected bool get_disposed() { }

	// RVA: 0x18415C0
	private void set_disposed(bool value) { }

	// RVA: 0x18415C8
	public void Dispose() { }

	// RVA: 0x1841658
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1841D1C
	public bool TryAdd(Texture2D image, Alloc2D alloc, RectInt rect) { }

	// RVA: 0x1842064
	public void Update(Texture2D image, RectInt rect) { }

	// RVA: 0x18421B0
	public void Remove(Alloc2D alloc) { }

	// RVA: 0x18422A4
	public void Commit() { }

	// RVA: 0x18422F8
	private void UpdateAtlasTexture() { }

	// RVA: 0x1842708
	private RenderTexture CreateAtlasTexture() { }

}

// Namespace: UnityEngine.UIElements
internal class UIRLayoutUpdater
{
	// Fields
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEventsList; // 0x20

	// Methods

	// RVA: 0x184283C
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x18428B8
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x1842910
	public override void Update() { }

	// RVA: 0x1842C38
	private void UpdateSubTree(VisualElement ve, bool isDisplayed, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents) { }

	// RVA: 0x184337C
	private void DispatchChangeEvents(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents, int currentLayoutPass) { }

	// RVA: 0x1843848
	public void .ctor() { }

	// RVA: 0x18438D4
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public struct Vertex
{
	// Fields
	public static readonly float nearZ; // 0x0
	public Vector3 position; // 0x10
	public Color32 tint; // 0x1C
	public Vector2 uv; // 0x20
	internal Color32 xformClipPages; // 0x28
	internal Color32 ids; // 0x2C
	internal Color32 flags; // 0x30
	internal Color32 opacityColorPages; // 0x34
	internal Color32 settingIndex; // 0x38
	internal Vector4 circle; // 0x3C
	internal float textureId; // 0x4C
}

// Namespace: UnityEngine.UIElements
public class MeshWriteData
{
	// Fields
	internal Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> m_Vertices; // 0x10
	internal Unity.Collections.NativeSlice<System.UInt16> m_Indices; // 0x20
	internal Rect m_UVRegion; // 0x30
	internal int currentIndex; // 0x40
	internal int currentVertex; // 0x44

	// Methods

	// RVA: 0x184397C
	internal void .ctor() { }

	// RVA: 0x1843984
	public int get_vertexCount() { }

	// RVA: 0x18439D8
	public int get_indexCount() { }

	// RVA: 0x1843A2C
	public Rect get_uvRegion() { }

	// RVA: 0x1843A38
	public void SetNextVertex(Vertex vertex) { }

	// RVA: 0x1843ABC
	public void SetNextIndex(UInt16 index) { }

	// RVA: 0x1843B34
	public void SetAllVertices(Vertex[] vertices) { }

	// RVA: 0x1843C0C
	public void SetAllIndices(UInt16[] indices) { }

	// RVA: 0x1843CE4
	internal void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices) { }

	// RVA: 0x1843D00
	internal void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, Rect uvRegion) { }

}

// Namespace: UnityEngine.UIElements
internal struct ColorPage
{
	// Fields
	public bool isValid; // 0x10
	public Color32 pageAndID; // 0x14

	// Methods

	// RVA: 0x1843D18
	public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc) { }

	// RVA: 0x1843E10
	public NativeColorPage ToNativeColorPage() { }

}

// Namespace: 
public struct BorderParams
{
	// Fields
	public Rect rect; // 0x10
	public Color playmodeTintColor; // 0x20
	public Color leftColor; // 0x30
	public Color topColor; // 0x40
	public Color rightColor; // 0x50
	public Color bottomColor; // 0x60
	public float leftWidth; // 0x70
	public float topWidth; // 0x74
	public float rightWidth; // 0x78
	public float bottomWidth; // 0x7C
	public Vector2 topLeftRadius; // 0x80
	public Vector2 topRightRadius; // 0x88
	public Vector2 bottomRightRadius; // 0x90
	public Vector2 bottomLeftRadius; // 0x98
	public Material material; // 0xA0
	internal ColorPage leftColorPage; // 0xA8
	internal ColorPage topColorPage; // 0xB0
	internal ColorPage rightColorPage; // 0xB8
	internal ColorPage bottomColorPage; // 0xC0

	// Methods

	// RVA: 0x184473C
	internal NativeBorderParams ToNativeParams() { }

}

// Namespace: 
public struct RectangleParams
{
	// Fields
	public Rect rect; // 0x10
	public Rect uv; // 0x20
	public Color color; // 0x30
	public Rect subRect; // 0x40
	public Rect backgroundRepeatRect; // 0x50
	public BackgroundPosition backgroundPositionX; // 0x60
	public BackgroundPosition backgroundPositionY; // 0x6C
	public BackgroundRepeat backgroundRepeat; // 0x78
	public BackgroundSize backgroundSize; // 0x80
	public Texture texture; // 0x98
	public Sprite sprite; // 0xA0
	public VectorImage vectorImage; // 0xA8
	public Material material; // 0xB0
	public ScaleMode scaleMode; // 0xB8
	public Color playmodeTintColor; // 0xBC
	public Vector2 topLeftRadius; // 0xCC
	public Vector2 topRightRadius; // 0xD4
	public Vector2 bottomRightRadius; // 0xDC
	public Vector2 bottomLeftRadius; // 0xE4
	public Vector2 contentSize; // 0xEC
	public Vector2 textureSize; // 0xF4
	public int leftSlice; // 0xFC
	public int topSlice; // 0x100
	public int rightSlice; // 0x104
	public int bottomSlice; // 0x108
	public float sliceScale; // 0x10C
	internal Rect spriteGeomRect; // 0x110
	public Vector4 rectInset; // 0x120
	internal ColorPage colorPage; // 0x130
	internal MeshFlags meshFlags; // 0x138

	// Methods

	// RVA: 0x18447AC
	private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, Rect rectOut, Rect uvOut) { }

	// RVA: 0x1844954
	private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, Rect rectOut, Rect uvOut) { }

	// RVA: 0x1844C90
	internal static Rect RectIntersection(Rect a, Rect b) { }

	// RVA: 0x1844D6C
	private static Rect ComputeGeomRect(Sprite sprite) { }

	// RVA: 0x1844E1C
	private static Rect ComputeUVRect(Sprite sprite) { }

	// RVA: 0x1844ECC
	private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation) { }

	// RVA: 0x1844F24
	public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, ContextType panelContext) { }

	// RVA: 0x1845100
	public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, ContextType panelContext, bool hasRadius, Vector4 slices, bool useForRepeat) { }

	// RVA: 0x1845B4C
	public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, ContextType panelContext) { }

	// RVA: 0x1845CDC
	internal bool HasRadius(float epsilon) { }

	// RVA: 0x1845D60
	internal bool HasSlices(float epsilon) { }

	// RVA: 0x1845DAC
	internal NativeRectParams ToNativeParams(Rect uvRegion) { }

}

// Namespace: UnityEngine.UIElements
internal static class MeshGenerationContextUtils
{
	// Methods

	// RVA: 0x1843E20
	public static void Rectangle(MeshGenerationContext mgc, RectangleParams rectParams) { }

	// RVA: 0x1843F14
	public static void Text(MeshGenerationContext mgc, TextElement te) { }

	// RVA: 0x1843FEC
	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) { }

	// RVA: 0x1844028
	public static void GetVisualElementRadii(VisualElement ve, Vector2 topLeft, Vector2 bottomLeft, Vector2 topRight, Vector2 bottomRight) { }

	// RVA: 0x18442B0
	public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, RectangleParams rectParams) { }

}

// Namespace: 
internal enum MeshFlags
{
	// Fields
	public int value__; // 0x10
	public const MeshFlags None = 0;
	public const MeshFlags UVisDisplacement = 1;
	public const MeshFlags SkipDynamicAtlas = 2;
}

// Namespace: UnityEngine.UIElements
public class MeshGenerationContext
{
	// Fields
	private Painter2D m_Painter2D; // 0x10
	private static readonly ProfilerMarker s_AllocateMarker; // 0x0
	private static readonly ProfilerMarker s_DrawVectorImageMarker; // 0x8
	internal IStylePainter painter; // 0x18

	// Methods

	// RVA: 0x1845E30
	public Painter2D get_painter2D() { }

	// RVA: 0x1845F68
	internal bool get_hasPainter2D() { }

	// RVA: 0x1845F78
	internal void .ctor(IStylePainter painter) { }

	// RVA: 0x1845FAC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public class Painter2D
{
	// Fields
	private MeshGenerationContext m_Ctx; // 0x10
	internal DetachedAllocator m_DetachedAllocator; // 0x18
	internal SafeHandleAccess m_Handle; // 0x20
	private bool m_Disposed; // 0x28
	private static bool <isPainterActive>k__BackingField; // 0x0
	private static float s_MaxArcRadius; // 0x4
	private static readonly ProfilerMarker s_StrokeMarker; // 0x8
	private static readonly ProfilerMarker s_FillMarker; // 0x10

	// Methods

	// RVA: 0x1845ECC
	internal void .ctor(MeshGenerationContext ctx) { }

	// RVA: 0x1846064
	internal void Reset() { }

	// RVA: 0x18460D0
	public void Dispose() { }

	// RVA: 0x1846170
	private void Dispose(bool disposing) { }

	// RVA: 0x184622C
	internal static void set_isPainterActive(bool value) { }

	// RVA: 0x18462B8
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UIRRepaintUpdater
{
	// Fields
	private BaseVisualElementPanel attachedPanel; // 0x20
	internal RenderChain renderChain; // 0x28
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	private bool <drawStats>k__BackingField; // 0x30
	private bool <breakBatches>k__BackingField; // 0x31
	private bool <disposed>k__BackingField; // 0x32

	// Methods

	// RVA: 0x1846380
	public void .ctor() { }

	// RVA: 0x1846414
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x1846490
	public bool get_drawStats() { }

	// RVA: 0x1846498
	public bool get_breakBatches() { }

	// RVA: 0x18464A0
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x184659C
	public override void Update() { }

	// RVA: 0x1846734
	protected virtual RenderChain CreateRenderChain() { }

	// RVA: 0x18467AC
	private static void .cctor() { }

	// RVA: 0x18468CC
	private static void OnGraphicsResourcesRecreate(bool recreate) { }

	// RVA: 0x1846D54
	private void OnPanelChanged(BaseVisualElementPanel obj) { }

	// RVA: 0x1846F78
	private void AttachToPanel() { }

	// RVA: 0x1846D78
	private void DetachFromPanel() { }

	// RVA: 0x1846668
	private void InitRenderChain() { }

	// RVA: 0x183D538
	internal void DestroyRenderChain() { }

	// RVA: 0x18475A0
	private void OnPanelAtlasChanged() { }

	// RVA: 0x1847610
	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	// RVA: 0x184717C
	private void OnPanelStandardShaderChanged() { }

	// RVA: 0x1847330
	private void OnPanelStandardWorldSpaceShaderChanged() { }

	// RVA: 0x18474E4
	private void ResetAllElementsDataRecursive(VisualElement ve) { }

	// RVA: 0x1847648
	protected bool get_disposed() { }

	// RVA: 0x1847650
	private void set_disposed(bool value) { }

	// RVA: 0x1847658
	protected override void Dispose(bool disposing) { }

}

// Namespace: UnityEngine.UIElements
internal struct TextureId
{
	// Fields
	private readonly int m_Index; // 0x10
	public static readonly TextureId invalid; // 0x0

	// Methods

	// RVA: 0x184769C
	public void .ctor(int index) { }

	// RVA: 0x18476A8
	public int get_index() { }

	// RVA: 0x18476B4
	public float ConvertToGpu() { }

	// RVA: 0x184771C
	public override bool Equals(object obj) { }

	// RVA: 0x18477EC
	public override int GetHashCode() { }

	// RVA: 0x18477F4
	public static bool op_Equality(TextureId left, TextureId right) { }

	// RVA: 0x1847800
	public static bool op_Inequality(TextureId left, TextureId right) { }

	// RVA: 0x184788C
	private static void .cctor() { }

}

// Namespace: 
private struct TextureInfo
{
	// Fields
	public Texture texture; // 0x10
	public bool dynamic; // 0x18
	public int refCount; // 0x1C
}

// Namespace: UnityEngine.UIElements
internal class TextureRegistry
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.TextureRegistry.TextureInfo> m_Textures; // 0x10
	private System.Collections.Generic.Dictionary<UnityEngine.Texture,UnityEngine.UIElements.TextureId> m_TextureToId; // 0x18
	private System.Collections.Generic.Stack<UnityEngine.UIElements.TextureId> m_FreeIds; // 0x20
	internal const int maxTextures = 2048;
	private static readonly TextureRegistry <instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x18478D8
	public static TextureRegistry get_instance() { }

	// RVA: 0x1847954
	public Texture GetTexture(TextureId id) { }

	// RVA: 0x18415AC
	public TextureId AllocAndAcquireDynamic() { }

	// RVA: 0x1847DFC
	public void UpdateDynamic(TextureId id, Texture texture) { }

	// RVA: 0x1847B6C
	private TextureId AllocAndAcquire(Texture texture, bool dynamic) { }

	// RVA: 0x18480A4
	public TextureId Acquire(Texture tex) { }

	// RVA: 0x1841A3C
	public void Release(TextureId id) { }

	// RVA: 0x1848228
	public void .ctor() { }

	// RVA: 0x1848364
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIRUtility
{
	// Fields
	public static readonly string k_DefaultShaderName; // 0x0
	public static readonly string k_DefaultWorldSpaceShaderName; // 0x8

	// Methods

	// RVA: 0x18483CC
	public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef) { }

	// RVA: 0x184844C
	public static bool IsRoundRect(VisualElement ve) { }

	// RVA: 0x184867C
	public static bool IsVectorImageBackground(VisualElement ve) { }

	// RVA: 0x1848714
	public static bool IsElementSelfHidden(VisualElement ve) { }

	// RVA: 0x18418E8
	public static void Destroy(object obj) { }

	// RVA: 0x18487D8
	public static int GetPrevPow2(int n) { }

	// RVA: 0x1842048
	public static int GetNextPow2(int n) { }

	// RVA: 0x1848818
	public static int GetNextPow2Exp(int n) { }

	// RVA: 0x1848848
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public struct TimerState
{
	// Fields
	private Int64 <start>k__BackingField; // 0x10
	private Int64 <now>k__BackingField; // 0x18

	// Methods

	// RVA: 0x18488E8
	public Int64 get_start() { }

	// RVA: 0x18488F0
	public void set_start(Int64 value) { }

	// RVA: 0x18488F8
	public Int64 get_now() { }

	// RVA: 0x1848900
	public void set_now(Int64 value) { }

	// RVA: 0x1848908
	public Int64 get_deltaTime() { }

	// RVA: 0x1848914
	public override bool Equals(object obj) { }

	// RVA: 0x18489B4
	public bool Equals(TimerState other) { }

	// RVA: 0x18489D8
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal interface IScheduler
{
	// Methods

	// RVA: -1
	public abstract void Unschedule(ScheduledItem item) { }

	// RVA: -1
	public abstract void Schedule(ScheduledItem item) { }

	// RVA: -1
	public abstract void UpdateScheduledEvents() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ScheduledItem.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1848D80
	private static void .cctor() { }

	// RVA: 0x1848DEC
	public void .ctor() { }

	// RVA: 0x1848DF4
	internal bool <.cctor>b__25_0() { }

	// RVA: 0x1848DFC
	internal bool <.cctor>b__25_1() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class ScheduledItem
{
	// Fields
	public System.Func<System.Boolean> timerUpdateStopCondition; // 0x10
	public static readonly System.Func<System.Boolean> OnceCondition; // 0x0
	public static readonly System.Func<System.Boolean> ForeverCondition; // 0x8
	private Int64 <startMs>k__BackingField; // 0x18
	private Int64 <delayMs>k__BackingField; // 0x20
	private Int64 <intervalMs>k__BackingField; // 0x28
	private Int64 <endTimeMs>k__BackingField; // 0x30

	// Methods

	// RVA: 0x1848A68
	public Int64 get_startMs() { }

	// RVA: 0x1848A70
	public void set_startMs(Int64 value) { }

	// RVA: 0x1848A78
	public Int64 get_delayMs() { }

	// RVA: 0x1848A80
	public void set_delayMs(Int64 value) { }

	// RVA: 0x1848A88
	public Int64 get_intervalMs() { }

	// RVA: 0x1848A90
	public void set_intervalMs(Int64 value) { }

	// RVA: 0x1848A98
	public Int64 get_endTimeMs() { }

	// RVA: 0x1848AA0
	public void .ctor() { }

	// RVA: 0x1848B90
	protected void ResetStartTime() { }

	// RVA: -1
	public abstract void PerformTimerUpdate(TimerState state) { }

	// RVA: 0x1848BF8
	internal virtual void OnItemUnscheduled() { }

	// RVA: 0x1848BFC
	public virtual bool ShouldUnschedule() { }

	// RVA: 0x1848C4C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class TimerEventScheduler
{
	// Fields
	private readonly System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem> m_ScheduledItems; // 0x10
	private bool m_TransactionMode; // 0x18
	private readonly System.Collections.Generic.List<UnityEngine.UIElements.ScheduledItem> m_ScheduleTransactions; // 0x20
	private readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.ScheduledItem> m_UnscheduleTransactions; // 0x28
	internal bool disableThrottling; // 0x30
	private int m_LastUpdatedIndex; // 0x34

	// Methods

	// RVA: 0x1848E04
	public void Schedule(ScheduledItem item) { }

	// RVA: 0x1848F8C
	private bool RemovedScheduledItemAt(int index) { }

	// RVA: 0x1849014
	public void Unschedule(ScheduledItem item) { }

	// RVA: 0x18491B4
	private bool PrivateUnSchedule(ScheduledItem sItem) { }

	// RVA: 0x18492B8
	public void UpdateScheduledEvents() { }

	// RVA: 0x18495D4
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct Spacing
{
	// Fields
	public float left; // 0x10
	public float top; // 0x14
	public float right; // 0x18
	public float bottom; // 0x1C

	// Methods

	// RVA: 0x18496E4
	public float get_horizontal() { }

	// RVA: 0x18496F4
	public float get_vertical() { }

	// RVA: 0x1849704
	public void .ctor(float left, float top, float right, float bottom) { }

	// RVA: 0x1849710
	public static Rect op_Subtraction(Rect r, Spacing a) { }

}

// Namespace: UnityEngine.UIElements
public enum AngleUnit
{
	// Fields
	public int value__; // 0x10
	public const AngleUnit Degree = 0;
	public const AngleUnit Gradian = 1;
	public const AngleUnit Radian = 2;
	public const AngleUnit Turn = 3;
}

// Namespace: 
private enum Unit
{
	// Fields
	public int value__; // 0x10
	public const Unit Degree = 0;
	public const Unit Gradian = 1;
	public const Unit Radian = 2;
	public const Unit Turn = 3;
	public const Unit None = 4;
}

// Namespace: UnityEngine.UIElements
public struct Angle
{
	// Fields
	private float m_Value; // 0x10
	private Unit m_Unit; // 0x14

	// Methods

	// RVA: 0x1849740
	internal static Angle None() { }

	// RVA: 0x1849754
	public float get_value() { }

	// RVA: 0x184975C
	public void .ctor(float value, AngleUnit unit) { }

	// RVA: 0x1849748
	private void .ctor(float value, Unit unit) { }

	// RVA: 0x1849768
	public float ToDegrees() { }

	// RVA: 0x18497F4
	public static Angle op_Implicit(float value) { }

	// RVA: 0x18497FC
	public static bool op_Equality(Angle lhs, Angle rhs) { }

	// RVA: 0x184981C
	public bool Equals(Angle other) { }

	// RVA: 0x184983C
	public override bool Equals(object obj) { }

	// RVA: 0x18498D8
	public override int GetHashCode() { }

	// RVA: 0x184990C
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct Background
{
	// Fields
	private Texture2D m_Texture; // 0x10
	private Sprite m_Sprite; // 0x18
	private RenderTexture m_RenderTexture; // 0x20
	private VectorImage m_VectorImage; // 0x28

	// Methods

	// RVA: 0x1849B0C
	public Texture2D get_texture() { }

	// RVA: 0x1849B14
	public void set_texture(Texture2D value) { }

	// RVA: 0x1849BFC
	public Sprite get_sprite() { }

	// RVA: 0x1849C04
	public void set_sprite(Sprite value) { }

	// RVA: 0x1849D00
	public RenderTexture get_renderTexture() { }

	// RVA: 0x1849D08
	public void set_renderTexture(RenderTexture value) { }

	// RVA: 0x184870C
	public VectorImage get_vectorImage() { }

	// RVA: 0x1849E04
	public void set_vectorImage(VectorImage value) { }

	// RVA: 0x1849F00
	public static Background FromTexture2D(Texture2D t) { }

	// RVA: 0x1849F40
	public static Background FromRenderTexture(RenderTexture rt) { }

	// RVA: 0x1849F80
	public static Background FromSprite(Sprite s) { }

	// RVA: 0x1849FC0
	public static Background FromVectorImage(VectorImage vi) { }

	// RVA: 0x184A000
	internal static Background FromObject(object obj) { }

	// RVA: 0x184A2C8
	public static bool op_Equality(Background lhs, Background rhs) { }

	// RVA: 0x184A438
	public static bool op_Inequality(Background lhs, Background rhs) { }

	// RVA: 0x184A470
	public bool Equals(Background other) { }

	// RVA: 0x184A4A4
	public override bool Equals(object obj) { }

	// RVA: 0x184A54C
	public override int GetHashCode() { }

	// RVA: 0x184A600
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
internal struct ComputedStyle
{
	// Fields
	public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.InheritedData> inheritedData; // 0x10
	public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.LayoutData> layoutData; // 0x18
	public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.RareData> rareData; // 0x20
	public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransformData> transformData; // 0x28
	public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.TransitionData> transitionData; // 0x30
	public UnityEngine.UIElements.StyleDataRef<UnityEngine.UIElements.VisualData> visualData; // 0x38
	public YogaNode yogaNode; // 0x40
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties; // 0x48
	public Int64 matchingRulesHash; // 0x50
	public float dpiScaling; // 0x58
	public ComputedTransitionProperty[] computedTransitions; // 0x60

	// Methods

	// RVA: 0x1823288
	public int get_customPropertiesCount() { }

	// RVA: 0x18232E4
	public bool get_hasTransition() { }

	// RVA: 0x1823304
	public void FinalizeApply(ComputedStyle parentStyle) { }

	// RVA: 0x182352C
	public void SyncWithLayout(YogaNode targetNode) { }

	// RVA: 0x1824A9C
	private bool ApplyGlobalKeyword(StylePropertyReader reader, ComputedStyle parentStyle) { }

	// RVA: 0x1824C74
	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ComputedStyle parentStyle) { }

	// RVA: 0x1826EA8
	private void RemoveCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x1826F60
	private void ApplyCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x1827068
	private void ApplyAllPropertyInitial() { }

	// RVA: 0x182723C
	private void ResetComputedTransitions() { }

	// RVA: 0x1827248
	public static bool StartAnimationInlineTranslate(VisualElement element, ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18248D0
	public Align get_alignContent() { }

	// RVA: 0x182492C
	public Align get_alignItems() { }

	// RVA: 0x18246A8
	public Align get_alignSelf() { }

	// RVA: 0x1827450
	public Color get_backgroundColor() { }

	// RVA: 0x18274B0
	public Background get_backgroundImage() { }

	// RVA: 0x1827514
	public BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x1827578
	public BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x18275DC
	public BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x1827638
	public BackgroundSize get_backgroundSize() { }

	// RVA: 0x18276A4
	public Color get_borderBottomColor() { }

	// RVA: 0x1827704
	public Length get_borderBottomLeftRadius() { }

	// RVA: 0x1827760
	public Length get_borderBottomRightRadius() { }

	// RVA: 0x18244DC
	public float get_borderBottomWidth() { }

	// RVA: 0x18277BC
	public Color get_borderLeftColor() { }

	// RVA: 0x18243C8
	public float get_borderLeftWidth() { }

	// RVA: 0x182781C
	public Color get_borderRightColor() { }

	// RVA: 0x1824480
	public float get_borderRightWidth() { }

	// RVA: 0x182787C
	public Color get_borderTopColor() { }

	// RVA: 0x18278DC
	public Length get_borderTopLeftRadius() { }

	// RVA: 0x1827938
	public Length get_borderTopRightRadius() { }

	// RVA: 0x1824424
	public float get_borderTopWidth() { }

	// RVA: 0x182408C
	public Length get_bottom() { }

	// RVA: 0x1827994
	public Color get_color() { }

	// RVA: 0x18279F4
	public Cursor get_cursor() { }

	// RVA: 0x1824A40
	public DisplayStyle get_display() { }

	// RVA: 0x1823F1C
	public Length get_flexBasis() { }

	// RVA: 0x1824874
	public FlexDirection get_flexDirection() { }

	// RVA: 0x1823E64
	public float get_flexGrow() { }

	// RVA: 0x1823EC0
	public float get_flexShrink() { }

	// RVA: 0x18249E4
	public Wrap get_flexWrap() { }

	// RVA: 0x18234D0
	public Length get_fontSize() { }

	// RVA: 0x1824594
	public Length get_height() { }

	// RVA: 0x1824988
	public Justify get_justifyContent() { }

	// RVA: 0x1823F78
	public Length get_left() { }

	// RVA: 0x1827A60
	public Length get_letterSpacing() { }

	// RVA: 0x18241FC
	public Length get_marginBottom() { }

	// RVA: 0x18240E8
	public Length get_marginLeft() { }

	// RVA: 0x18241A0
	public Length get_marginRight() { }

	// RVA: 0x1824144
	public Length get_marginTop() { }

	// RVA: 0x1824760
	public Length get_maxHeight() { }

	// RVA: 0x1824704
	public Length get_maxWidth() { }

	// RVA: 0x1824818
	public Length get_minHeight() { }

	// RVA: 0x18247BC
	public Length get_minWidth() { }

	// RVA: 0x1827ABC
	public float get_opacity() { }

	// RVA: 0x182464C
	public OverflowInternal get_overflow() { }

	// RVA: 0x182436C
	public Length get_paddingBottom() { }

	// RVA: 0x1824258
	public Length get_paddingLeft() { }

	// RVA: 0x1824310
	public Length get_paddingRight() { }

	// RVA: 0x18242B4
	public Length get_paddingTop() { }

	// RVA: 0x18245F0
	public Position get_position() { }

	// RVA: 0x1824030
	public Length get_right() { }

	// RVA: 0x1827B18
	public Rotate get_rotate() { }

	// RVA: 0x1827B84
	public Scale get_scale() { }

	// RVA: 0x1827BE4
	public TextOverflow get_textOverflow() { }

	// RVA: 0x1827C40
	public TextShadow get_textShadow() { }

	// RVA: 0x1823FD4
	public Length get_top() { }

	// RVA: 0x1827CAC
	public TransformOrigin get_transformOrigin() { }

	// RVA: 0x1827D18
	public System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay() { }

	// RVA: 0x1827D74
	public System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration() { }

	// RVA: 0x1827DD0
	public System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty() { }

	// RVA: 0x1827E2C
	public System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x1827E88
	public Translate get_translate() { }

	// RVA: 0x1827EF4
	public Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x1827F54
	public Font get_unityFont() { }

	// RVA: 0x1827FB0
	public FontDefinition get_unityFontDefinition() { }

	// RVA: 0x1828010
	public FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x182806C
	public OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x18280C8
	public Length get_unityParagraphSpacing() { }

	// RVA: 0x1828124
	public int get_unitySliceBottom() { }

	// RVA: 0x1828180
	public int get_unitySliceLeft() { }

	// RVA: 0x18281DC
	public int get_unitySliceRight() { }

	// RVA: 0x1828238
	public float get_unitySliceScale() { }

	// RVA: 0x1828294
	public int get_unitySliceTop() { }

	// RVA: 0x18282F0
	public TextAnchor get_unityTextAlign() { }

	// RVA: 0x182834C
	public Color get_unityTextOutlineColor() { }

	// RVA: 0x18283AC
	public float get_unityTextOutlineWidth() { }

	// RVA: 0x1828408
	public TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x1828464
	public Visibility get_visibility() { }

	// RVA: 0x18284C0
	public WhiteSpace get_whiteSpace() { }

	// RVA: 0x1824538
	public Length get_width() { }

	// RVA: 0x182851C
	public Length get_wordSpacing() { }

	// RVA: 0x1828578
	public static ComputedStyle Create(ComputedStyle parentStyle) { }

	// RVA: 0x1828780
	public static ComputedStyle CreateInitial() { }

	// RVA: 0x182893C
	public ComputedStyle Acquire() { }

	// RVA: 0x1828A70
	public void Release() { }

	// RVA: 0x18270D4
	public void CopyFrom(ComputedStyle other) { }

	// RVA: 0x1828B74
	public void ApplyProperties(StylePropertyReader reader, ComputedStyle parentStyle) { }

	// RVA: 0x1829F74
	public void ApplyStyleValue(StyleValue sv, ComputedStyle parentStyle) { }

	// RVA: 0x182ADE4
	public void ApplyStyleValueManaged(StyleValueManaged sv, ComputedStyle parentStyle) { }

	// RVA: 0x182B258
	public void ApplyStyleCursor(Cursor cursor) { }

	// RVA: 0x182B2C8
	public void ApplyStyleTextShadow(TextShadow st) { }

	// RVA: 0x182B33C
	public void ApplyFromComputedStyle(StylePropertyId id, ComputedStyle other) { }

	// RVA: 0x182CBC4
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) { }

	// RVA: 0x182D3A0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) { }

	// RVA: 0x182D6F4
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) { }

	// RVA: 0x182DEF8
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue) { }

	// RVA: 0x182E108
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue) { }

	// RVA: 0x182E29C
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue) { }

	// RVA: 0x182E3EC
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue) { }

	// RVA: 0x182E6A4
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) { }

	// RVA: 0x182E848
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) { }

	// RVA: 0x182EA1C
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) { }

	// RVA: 0x182EBC0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) { }

	// RVA: 0x182ED18
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) { }

	// RVA: 0x182EE68
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) { }

	// RVA: 0x182EFB8
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) { }

	// RVA: 0x182F100
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) { }

	// RVA: 0x182F248
	public static bool StartAnimation(VisualElement element, StylePropertyId id, ComputedStyle oldStyle, ComputedStyle newStyle, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1833218
	public static bool StartAnimationAllProperty(VisualElement element, ComputedStyle oldStyle, ComputedStyle newStyle, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1837190
	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x183A394
	public void ApplyStyleTransformOrigin(TransformOrigin st) { }

	// RVA: 0x183A400
	public void ApplyStyleTranslate(Translate translateValue) { }

	// RVA: 0x183A46C
	public void ApplyStyleRotate(Rotate rotateValue) { }

	// RVA: 0x183A4D8
	public void ApplyStyleScale(Scale scaleValue) { }

	// RVA: 0x183A544
	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue) { }

	// RVA: 0x1824B94
	public void ApplyInitialValue(StylePropertyReader reader) { }

	// RVA: 0x1824CA4
	public void ApplyInitialValue(StylePropertyId id) { }

	// RVA: 0x1824C44
	public void ApplyUnsetValue(StylePropertyReader reader, ComputedStyle parentStyle) { }

	// RVA: 0x183A5B0
	public void ApplyUnsetValue(StylePropertyId id, ComputedStyle parentStyle) { }

	// RVA: 0x183ABBC
	public static VersionChangeType CompareChanges(ComputedStyle x, ComputedStyle y) { }

}

// Namespace: UnityEngine.UIElements
internal struct ComputedTransitionProperty
{
	// Fields
	public StylePropertyId id; // 0x10
	public int durationMs; // 0x14
	public int delayMs; // 0x18
	public System.Func<System.Single,System.Single> easingCurve; // 0x20
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ComputedTransitionUtils.<>c <>9; // 0x0
	public static System.Func<System.Single,System.Single> <>9__12_0; // 0x8
	public static System.Func<System.Single,System.Single> <>9__12_1; // 0x10
	public static System.Func<System.Single,System.Single> <>9__12_2; // 0x18
	public static System.Func<System.Single,System.Single> <>9__12_3; // 0x20
	public static System.Func<System.Single,System.Single> <>9__12_4; // 0x28
	public static System.Func<System.Single,System.Single> <>9__12_5; // 0x30
	public static System.Func<System.Single,System.Single> <>9__12_6; // 0x38
	public static System.Func<System.Single,System.Single> <>9__12_7; // 0x40
	public static System.Func<System.Single,System.Single> <>9__12_8; // 0x48
	public static System.Func<System.Single,System.Single> <>9__12_9; // 0x50
	public static System.Func<System.Single,System.Single> <>9__12_10; // 0x58
	public static System.Func<System.Single,System.Single> <>9__12_11; // 0x60
	public static System.Func<System.Single,System.Single> <>9__12_12; // 0x68
	public static System.Func<System.Single,System.Single> <>9__12_13; // 0x70
	public static System.Func<System.Single,System.Single> <>9__12_14; // 0x78
	public static System.Func<System.Single,System.Single> <>9__12_15; // 0x80
	public static System.Func<System.Single,System.Single> <>9__12_16; // 0x88
	public static System.Func<System.Single,System.Single> <>9__12_17; // 0x90
	public static System.Func<System.Single,System.Single> <>9__12_18; // 0x98
	public static System.Func<System.Single,System.Single> <>9__12_19; // 0xA0
	public static System.Func<System.Single,System.Single> <>9__12_20; // 0xA8
	public static System.Func<System.Single,System.Single> <>9__12_21; // 0xB0
	public static System.Func<System.Single,System.Single> <>9__12_22; // 0xB8

	// Methods

	// RVA: 0x184C830
	private static void .cctor() { }

	// RVA: 0x184C89C
	public void .ctor() { }

	// RVA: 0x184C8A4
	internal float <ConvertTransitionFunction>b__12_0(float t) { }

	// RVA: 0x184C8E0
	internal float <ConvertTransitionFunction>b__12_1(float t) { }

	// RVA: 0x184C8E8
	internal float <ConvertTransitionFunction>b__12_2(float t) { }

	// RVA: 0x184C8F0
	internal float <ConvertTransitionFunction>b__12_3(float t) { }

	// RVA: 0x184C8F8
	internal float <ConvertTransitionFunction>b__12_4(float t) { }

	// RVA: 0x184C900
	internal float <ConvertTransitionFunction>b__12_5(float t) { }

	// RVA: 0x184C908
	internal float <ConvertTransitionFunction>b__12_6(float t) { }

	// RVA: 0x184C910
	internal float <ConvertTransitionFunction>b__12_7(float t) { }

	// RVA: 0x184C918
	internal float <ConvertTransitionFunction>b__12_8(float t) { }

	// RVA: 0x184C920
	internal float <ConvertTransitionFunction>b__12_9(float t) { }

	// RVA: 0x184C928
	internal float <ConvertTransitionFunction>b__12_10(float t) { }

	// RVA: 0x184C930
	internal float <ConvertTransitionFunction>b__12_11(float t) { }

	// RVA: 0x184C938
	internal float <ConvertTransitionFunction>b__12_12(float t) { }

	// RVA: 0x184C940
	internal float <ConvertTransitionFunction>b__12_13(float t) { }

	// RVA: 0x184C948
	internal float <ConvertTransitionFunction>b__12_14(float t) { }

	// RVA: 0x184C950
	internal float <ConvertTransitionFunction>b__12_15(float t) { }

	// RVA: 0x184C958
	internal float <ConvertTransitionFunction>b__12_16(float t) { }

	// RVA: 0x184C960
	internal float <ConvertTransitionFunction>b__12_17(float t) { }

	// RVA: 0x184C968
	internal float <ConvertTransitionFunction>b__12_18(float t) { }

	// RVA: 0x184C970
	internal float <ConvertTransitionFunction>b__12_19(float t) { }

	// RVA: 0x184C978
	internal float <ConvertTransitionFunction>b__12_20(float t) { }

	// RVA: 0x184C980
	internal float <ConvertTransitionFunction>b__12_21(float t) { }

	// RVA: 0x184C988
	internal float <ConvertTransitionFunction>b__12_22(float t) { }

}

// Namespace: UnityEngine.UIElements
internal static class ComputedTransitionUtils
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> s_ComputedTransitionsBuffer; // 0x0

	// Methods

	// RVA: 0x184A7A8
	internal static void UpdateComputedTransitions(ComputedStyle computedStyle) { }

	// RVA: 0x184AA70
	internal static bool HasTransitionProperty(ComputedStyle computedStyle, StylePropertyId id) { }

	// RVA: 0x184AB48
	internal static bool GetTransitionProperty(ComputedStyle computedStyle, StylePropertyId id, ComputedTransitionProperty result) { }

	// RVA: 0x184A828
	private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ComputedStyle computedStyle) { }

	// RVA: 0x184ACA0
	private static int GetTransitionHashCode(ComputedStyle cs) { }

	// RVA: 0x184B604
	internal static bool SameTransitionProperty(ComputedStyle x, ComputedStyle y) { }

	// RVA: 0x184B778
	private static bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> a, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> b) { }

	// RVA: 0x184B884
	private static bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> a, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> b) { }

	// RVA: 0x184B324
	private static void ComputeTransitionPropertyData(ComputedStyle computedStyle, System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> outData) { }

	// RVA: 0x315B3A8
	private static T GetWrappingTransitionData(System.Collections.Generic.List<T> list, int i, T defaultValue) { }

	// RVA: 0x184B9AC
	private static int ConvertTransitionTime(TimeValue time) { }

	// RVA: 0x184BAE0
	private static System.Func<System.Single,System.Single> ConvertTransitionFunction(EasingMode mode) { }

	// RVA: 0x184C794
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public struct CustomStyleProperty<T0>
{
	// Fields
	private string <name>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A17DC
	public string get_name() { }

	// RVA: 0x30A27C0
	private void set_name(string value) { }

	// RVA: 0x30A27C0
	public void .ctor(string propertyName) { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x315B3A8
	public bool Equals(UnityEngine.UIElements.CustomStyleProperty<T> other) { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public interface ICustomStyle
{
	// Methods

	// RVA: -1
	public abstract bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, float value) { }

	// RVA: -1
	public abstract bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, int value) { }

	// RVA: -1
	public abstract bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, Color value) { }

	// RVA: -1
	public abstract bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, Texture2D value) { }

	// RVA: -1
	public abstract bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, Sprite value) { }

	// RVA: -1
	public abstract bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, VectorImage value) { }

	// RVA: -1
	public abstract bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, string value) { }

}

// Namespace: UnityEngine.UIElements
public enum EasingMode
{
	// Fields
	public int value__; // 0x10
	public const EasingMode Ease = 0;
	public const EasingMode EaseIn = 1;
	public const EasingMode EaseOut = 2;
	public const EasingMode EaseInOut = 3;
	public const EasingMode Linear = 4;
	public const EasingMode EaseInSine = 5;
	public const EasingMode EaseOutSine = 6;
	public const EasingMode EaseInOutSine = 7;
	public const EasingMode EaseInCubic = 8;
	public const EasingMode EaseOutCubic = 9;
	public const EasingMode EaseInOutCubic = 10;
	public const EasingMode EaseInCirc = 11;
	public const EasingMode EaseOutCirc = 12;
	public const EasingMode EaseInOutCirc = 13;
	public const EasingMode EaseInElastic = 14;
	public const EasingMode EaseOutElastic = 15;
	public const EasingMode EaseInOutElastic = 16;
	public const EasingMode EaseInBack = 17;
	public const EasingMode EaseOutBack = 18;
	public const EasingMode EaseInOutBack = 19;
	public const EasingMode EaseInBounce = 20;
	public const EasingMode EaseOutBounce = 21;
	public const EasingMode EaseInOutBounce = 22;
}

// Namespace: UnityEngine.UIElements
public struct EasingFunction
{
	// Fields
	private EasingMode m_Mode; // 0x10

	// Methods

	// RVA: 0x184C990
	public EasingMode get_mode() { }

	// RVA: 0x184C998
	public void .ctor(EasingMode mode) { }

	// RVA: 0x184BADC
	public static EasingFunction op_Implicit(EasingMode easingMode) { }

	// RVA: 0x184C9A0
	public static bool op_Equality(EasingFunction lhs, EasingFunction rhs) { }

	// RVA: 0x184C9AC
	public bool Equals(EasingFunction other) { }

	// RVA: 0x184C9BC
	public override bool Equals(object obj) { }

	// RVA: 0x184CA4C
	public override string ToString() { }

	// RVA: 0x184B5FC
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public struct FontDefinition
{
	// Fields
	private Font m_Font; // 0x10
	private FontAsset m_FontAsset; // 0x18

	// Methods

	// RVA: 0x184CAC0
	public Font get_font() { }

	// RVA: 0x184CAC8
	public FontAsset get_fontAsset() { }

	// RVA: 0x184CAD0
	public static FontDefinition FromFont(Font f) { }

	// RVA: 0x184CAFC
	public static FontDefinition FromSDFFont(FontAsset f) { }

	// RVA: 0x184CB2C
	internal static FontDefinition FromObject(object obj) { }

	// RVA: 0x184CCA0
	internal bool IsEmpty() { }

	// RVA: 0x184CD68
	public override string ToString() { }

	// RVA: 0x184CE04
	public bool Equals(FontDefinition other) { }

	// RVA: 0x184CE4C
	public override bool Equals(object obj) { }

	// RVA: 0x184CEEC
	public override int GetHashCode() { }

	// RVA: 0x184D024
	public static bool op_Equality(FontDefinition left, FontDefinition right) { }

	// RVA: 0x184D06C
	public static bool op_Inequality(FontDefinition left, FontDefinition right) { }

}

// Namespace: 
internal struct InlineRule
{
	// Fields
	public StyleSheet sheet; // 0x10
	public StyleRule rule; // 0x18
	public StylePropertyId[] propertyIds; // 0x20
}

// Namespace: UnityEngine.UIElements
internal class InlineStyleAccess
{
	// Fields
	private static StylePropertyReader s_StylePropertyReader; // 0x0
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValueManaged> m_ValuesManaged; // 0x18
	private VisualElement <ve>k__BackingField; // 0x20
	private bool m_HasInlineCursor; // 0x28
	private StyleCursor m_InlineCursor; // 0x30
	private bool m_HasInlineTextShadow; // 0x50
	private StyleTextShadow m_InlineTextShadow; // 0x54
	private bool m_HasInlineTransformOrigin; // 0x74
	private StyleTransformOrigin m_InlineTransformOrigin; // 0x78
	private bool m_HasInlineTranslate; // 0x90
	private StyleTranslate m_InlineTranslateOperation; // 0x94
	private bool m_HasInlineRotate; // 0xB0
	private StyleRotate m_InlineRotateOperation; // 0xB4
	private bool m_HasInlineScale; // 0xD0
	private StyleScale m_InlineScale; // 0xD4
	private bool m_HasInlineBackgroundSize; // 0xE8
	public StyleBackgroundSize m_InlineBackgroundSize; // 0xEC
	private InlineRule m_InlineRule; // 0x108

	// Methods

	// RVA: 0x184D0C0
	private void UnityEngine.UIElements.IStyle.set_backgroundColor(StyleColor value) { }

	// RVA: 0x184D2E4
	private void UnityEngine.UIElements.IStyle.set_borderBottomColor(StyleColor value) { }

	// RVA: 0x184D344
	private void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(StyleLength value) { }

	// RVA: 0x184D538
	private void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(StyleLength value) { }

	// RVA: 0x184D590
	private void UnityEngine.UIElements.IStyle.set_borderBottomWidth(StyleFloat value) { }

	// RVA: 0x184D78C
	private void UnityEngine.UIElements.IStyle.set_borderLeftColor(StyleColor value) { }

	// RVA: 0x184D7EC
	private void UnityEngine.UIElements.IStyle.set_borderLeftWidth(StyleFloat value) { }

	// RVA: 0x184D868
	private void UnityEngine.UIElements.IStyle.set_borderRightColor(StyleColor value) { }

	// RVA: 0x184D8C8
	private void UnityEngine.UIElements.IStyle.set_borderRightWidth(StyleFloat value) { }

	// RVA: 0x184D944
	private void UnityEngine.UIElements.IStyle.set_borderTopColor(StyleColor value) { }

	// RVA: 0x184D9A4
	private void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(StyleLength value) { }

	// RVA: 0x184D9FC
	private void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(StyleLength value) { }

	// RVA: 0x184DA54
	private void UnityEngine.UIElements.IStyle.set_borderTopWidth(StyleFloat value) { }

	// RVA: 0x184DAD0
	private void UnityEngine.UIElements.IStyle.set_bottom(StyleLength value) { }

	// RVA: 0x184DB60
	private void UnityEngine.UIElements.IStyle.set_color(StyleColor value) { }

	// RVA: 0x184DBBC
	private UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }

	// RVA: 0x184DC64
	private void UnityEngine.UIElements.IStyle.set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value) { }

	// RVA: 0x184DD24
	private void UnityEngine.UIElements.IStyle.set_flexBasis(StyleLength value) { }

	// RVA: 0x184DDB4
	private void UnityEngine.UIElements.IStyle.set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value) { }

	// RVA: 0x184DE74
	private void UnityEngine.UIElements.IStyle.set_flexGrow(StyleFloat value) { }

	// RVA: 0x184DEF0
	private void UnityEngine.UIElements.IStyle.set_flexShrink(StyleFloat value) { }

	// RVA: 0x184DF6C
	private void UnityEngine.UIElements.IStyle.set_fontSize(StyleLength value) { }

	// RVA: 0x184DFC0
	private void UnityEngine.UIElements.IStyle.set_height(StyleLength value) { }

	// RVA: 0x184E050
	private void UnityEngine.UIElements.IStyle.set_left(StyleLength value) { }

	// RVA: 0x184E0E0
	private void UnityEngine.UIElements.IStyle.set_marginBottom(StyleLength value) { }

	// RVA: 0x184E170
	private void UnityEngine.UIElements.IStyle.set_marginLeft(StyleLength value) { }

	// RVA: 0x184E200
	private void UnityEngine.UIElements.IStyle.set_marginRight(StyleLength value) { }

	// RVA: 0x184E290
	private void UnityEngine.UIElements.IStyle.set_marginTop(StyleLength value) { }

	// RVA: 0x184E320
	private void UnityEngine.UIElements.IStyle.set_maxHeight(StyleLength value) { }

	// RVA: 0x184E3B0
	private void UnityEngine.UIElements.IStyle.set_maxWidth(StyleLength value) { }

	// RVA: 0x184E440
	private void UnityEngine.UIElements.IStyle.set_minWidth(StyleLength value) { }

	// RVA: 0x184E4D0
	private void UnityEngine.UIElements.IStyle.set_opacity(StyleFloat value) { }

	// RVA: 0x184E520
	private void UnityEngine.UIElements.IStyle.set_overflow(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Overflow> value) { }

	// RVA: 0x184E664
	private void UnityEngine.UIElements.IStyle.set_paddingBottom(StyleLength value) { }

	// RVA: 0x184E6F4
	private void UnityEngine.UIElements.IStyle.set_paddingLeft(StyleLength value) { }

	// RVA: 0x184E784
	private void UnityEngine.UIElements.IStyle.set_paddingRight(StyleLength value) { }

	// RVA: 0x184E814
	private StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }

	// RVA: 0x184E838
	private void UnityEngine.UIElements.IStyle.set_paddingTop(StyleLength value) { }

	// RVA: 0x184E8C8
	private void UnityEngine.UIElements.IStyle.set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value) { }

	// RVA: 0x184E988
	private void UnityEngine.UIElements.IStyle.set_right(StyleLength value) { }

	// RVA: 0x184EA18
	private void UnityEngine.UIElements.IStyle.set_top(StyleLength value) { }

	// RVA: 0x184EAA8
	private void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(StyleColor value) { }

	// RVA: 0x184EB08
	private void UnityEngine.UIElements.IStyle.set_unityFont(StyleFont value) { }

	// RVA: 0x184EDE8
	private void UnityEngine.UIElements.IStyle.set_unityFontDefinition(StyleFontDefinition value) { }

	// RVA: 0x184F1CC
	private void UnityEngine.UIElements.IStyle.set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value) { }

	// RVA: 0x184F260
	private StyleLength UnityEngine.UIElements.IStyle.get_width() { }

	// RVA: 0x184F284
	private void UnityEngine.UIElements.IStyle.set_width(StyleLength value) { }

	// RVA: 0x184F314
	private VisualElement get_ve() { }

	// RVA: 0x184F31C
	private void set_ve(VisualElement value) { }

	// RVA: 0x184F324
	public void .ctor(VisualElement ve) { }

	// RVA: 0x184F358
	protected override void Finalize() { }

	// RVA: 0x184F4C0
	public void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x18501DC
	public bool IsValueSet(StylePropertyId id) { }

	// RVA: 0x184F584
	public void ApplyInlineStyles(ComputedStyle computedStyle) { }

	// RVA: 0x1850630
	private StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }

	// RVA: 0x18506EC
	private StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }

	// RVA: 0x185077C
	private StyleBackgroundSize UnityEngine.UIElements.IStyle.get_backgroundSize() { }

	// RVA: 0x1850808
	private StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }

	// RVA: 0x1850894
	private StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }

	// RVA: 0x185092C
	private void UnityEngine.UIElements.IStyle.set_translate(StyleTranslate value) { }

	// RVA: 0x1850AFC
	private StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }

	// RVA: 0x1850B94
	private StyleScale UnityEngine.UIElements.IStyle.get_scale() { }

	// RVA: 0x184D398
	private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) { }

	// RVA: 0x184D60C
	private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) { }

	// RVA: 0x184D11C
	private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) { }

	// RVA: 0x315B3A8
	private bool SetStyleValue(StylePropertyId id, UnityEngine.UIElements.StyleEnum<T> inlineValue) { }

	// RVA: 0x184EE48
	private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue) { }

	// RVA: 0x184EB5C
	private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue) { }

	// RVA: 0x1850984
	private bool SetInlineTranslate(StyleTranslate inlineValue) { }

	// RVA: 0x18510C8
	private void ApplyStyleTranslate(StyleTranslate translate) { }

	// RVA: 0x1850D3C
	private void ApplyStyleValue(StyleValue value) { }

	// RVA: 0x1850C20
	private bool RemoveInlineStyle(StylePropertyId id) { }

	// RVA: 0x1851384
	private void ApplyFromComputedStyle(StylePropertyId id, ComputedStyle newStyle) { }

	// RVA: 0x18506B0
	public bool TryGetInlineCursor(StyleCursor value) { }

	// RVA: 0x185075C
	public bool TryGetInlineTextShadow(StyleTextShadow value) { }

	// RVA: 0x1850870
	public bool TryGetInlineTransformOrigin(StyleTransformOrigin value) { }

	// RVA: 0x1850900
	public bool TryGetInlineTranslate(StyleTranslate value) { }

	// RVA: 0x1850B68
	public bool TryGetInlineRotate(StyleRotate value) { }

	// RVA: 0x1850BFC
	public bool TryGetInlineScale(StyleScale value) { }

	// RVA: 0x18507E4
	public bool TryGetInlineBackgroundSize(StyleBackgroundSize value) { }

	// RVA: 0x1851664
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IResolvedStyle
{
	// Methods

	// RVA: -1
	public abstract Color get_backgroundColor() { }

	// RVA: -1
	public abstract Color get_borderBottomColor() { }

	// RVA: -1
	public abstract float get_borderBottomLeftRadius() { }

	// RVA: -1
	public abstract float get_borderBottomRightRadius() { }

	// RVA: -1
	public abstract float get_borderBottomWidth() { }

	// RVA: -1
	public abstract Color get_borderLeftColor() { }

	// RVA: -1
	public abstract float get_borderLeftWidth() { }

	// RVA: -1
	public abstract Color get_borderRightColor() { }

	// RVA: -1
	public abstract float get_borderRightWidth() { }

	// RVA: -1
	public abstract Color get_borderTopColor() { }

	// RVA: -1
	public abstract float get_borderTopLeftRadius() { }

	// RVA: -1
	public abstract float get_borderTopRightRadius() { }

	// RVA: -1
	public abstract float get_borderTopWidth() { }

	// RVA: -1
	public abstract float get_bottom() { }

	// RVA: -1
	public abstract Color get_color() { }

	// RVA: -1
	public abstract DisplayStyle get_display() { }

	// RVA: -1
	public abstract FlexDirection get_flexDirection() { }

	// RVA: -1
	public abstract float get_flexGrow() { }

	// RVA: -1
	public abstract float get_flexShrink() { }

	// RVA: -1
	public abstract float get_height() { }

	// RVA: -1
	public abstract float get_left() { }

	// RVA: -1
	public abstract float get_marginBottom() { }

	// RVA: -1
	public abstract float get_marginLeft() { }

	// RVA: -1
	public abstract float get_marginRight() { }

	// RVA: -1
	public abstract float get_marginTop() { }

	// RVA: -1
	public abstract StyleFloat get_minHeight() { }

	// RVA: -1
	public abstract StyleFloat get_minWidth() { }

	// RVA: -1
	public abstract float get_opacity() { }

	// RVA: -1
	public abstract float get_paddingBottom() { }

	// RVA: -1
	public abstract float get_paddingLeft() { }

	// RVA: -1
	public abstract float get_paddingRight() { }

	// RVA: -1
	public abstract float get_paddingTop() { }

	// RVA: -1
	public abstract float get_right() { }

	// RVA: -1
	public abstract Scale get_scale() { }

	// RVA: -1
	public abstract float get_top() { }

	// RVA: -1
	public abstract Vector3 get_transformOrigin() { }

	// RVA: -1
	public abstract Vector3 get_translate() { }

	// RVA: -1
	public abstract Color get_unityBackgroundImageTintColor() { }

	// RVA: -1
	public abstract int get_unitySliceLeft() { }

	// RVA: -1
	public abstract int get_unitySliceRight() { }

	// RVA: -1
	public abstract float get_unitySliceScale() { }

	// RVA: -1
	public abstract Color get_unityTextOutlineColor() { }

	// RVA: -1
	public abstract float get_unityTextOutlineWidth() { }

	// RVA: -1
	public abstract Visibility get_visibility() { }

	// RVA: -1
	public abstract float get_width() { }

}

// Namespace: UnityEngine.UIElements
public interface IStyle
{
	// Methods

	// RVA: -1
	public abstract void set_backgroundColor(StyleColor value) { }

	// RVA: -1
	public abstract StyleBackgroundSize get_backgroundSize() { }

	// RVA: -1
	public abstract void set_borderBottomColor(StyleColor value) { }

	// RVA: -1
	public abstract void set_borderBottomLeftRadius(StyleLength value) { }

	// RVA: -1
	public abstract void set_borderBottomRightRadius(StyleLength value) { }

	// RVA: -1
	public abstract void set_borderBottomWidth(StyleFloat value) { }

	// RVA: -1
	public abstract void set_borderLeftColor(StyleColor value) { }

	// RVA: -1
	public abstract void set_borderLeftWidth(StyleFloat value) { }

	// RVA: -1
	public abstract void set_borderRightColor(StyleColor value) { }

	// RVA: -1
	public abstract void set_borderRightWidth(StyleFloat value) { }

	// RVA: -1
	public abstract void set_borderTopColor(StyleColor value) { }

	// RVA: -1
	public abstract void set_borderTopLeftRadius(StyleLength value) { }

	// RVA: -1
	public abstract void set_borderTopRightRadius(StyleLength value) { }

	// RVA: -1
	public abstract void set_borderTopWidth(StyleFloat value) { }

	// RVA: -1
	public abstract void set_bottom(StyleLength value) { }

	// RVA: -1
	public abstract void set_color(StyleColor value) { }

	// RVA: -1
	public abstract StyleCursor get_cursor() { }

	// RVA: -1
	public abstract UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> get_display() { }

	// RVA: -1
	public abstract void set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value) { }

	// RVA: -1
	public abstract void set_flexBasis(StyleLength value) { }

	// RVA: -1
	public abstract void set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value) { }

	// RVA: -1
	public abstract void set_flexGrow(StyleFloat value) { }

	// RVA: -1
	public abstract void set_flexShrink(StyleFloat value) { }

	// RVA: -1
	public abstract void set_fontSize(StyleLength value) { }

	// RVA: -1
	public abstract void set_height(StyleLength value) { }

	// RVA: -1
	public abstract void set_left(StyleLength value) { }

	// RVA: -1
	public abstract void set_marginBottom(StyleLength value) { }

	// RVA: -1
	public abstract void set_marginLeft(StyleLength value) { }

	// RVA: -1
	public abstract void set_marginRight(StyleLength value) { }

	// RVA: -1
	public abstract void set_marginTop(StyleLength value) { }

	// RVA: -1
	public abstract void set_maxHeight(StyleLength value) { }

	// RVA: -1
	public abstract void set_maxWidth(StyleLength value) { }

	// RVA: -1
	public abstract void set_minWidth(StyleLength value) { }

	// RVA: -1
	public abstract void set_opacity(StyleFloat value) { }

	// RVA: -1
	public abstract void set_overflow(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Overflow> value) { }

	// RVA: -1
	public abstract void set_paddingBottom(StyleLength value) { }

	// RVA: -1
	public abstract void set_paddingLeft(StyleLength value) { }

	// RVA: -1
	public abstract void set_paddingRight(StyleLength value) { }

	// RVA: -1
	public abstract StyleLength get_paddingTop() { }

	// RVA: -1
	public abstract void set_paddingTop(StyleLength value) { }

	// RVA: -1
	public abstract void set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value) { }

	// RVA: -1
	public abstract void set_right(StyleLength value) { }

	// RVA: -1
	public abstract StyleRotate get_rotate() { }

	// RVA: -1
	public abstract StyleScale get_scale() { }

	// RVA: -1
	public abstract StyleTextShadow get_textShadow() { }

	// RVA: -1
	public abstract void set_top(StyleLength value) { }

	// RVA: -1
	public abstract StyleTransformOrigin get_transformOrigin() { }

	// RVA: -1
	public abstract StyleTranslate get_translate() { }

	// RVA: -1
	public abstract void set_translate(StyleTranslate value) { }

	// RVA: -1
	public abstract void set_unityBackgroundImageTintColor(StyleColor value) { }

	// RVA: -1
	public abstract void set_unityFont(StyleFont value) { }

	// RVA: -1
	public abstract void set_unityFontDefinition(StyleFontDefinition value) { }

	// RVA: -1
	public abstract void set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value) { }

	// RVA: -1
	public abstract StyleLength get_width() { }

	// RVA: -1
	public abstract void set_width(StyleLength value) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1863F54
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	protected UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_ViewDataKey; // 0x20
	protected UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.PickingMode> m_PickingMode; // 0x28
	private UxmlStringAttributeDescription m_Tooltip; // 0x30
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.UsageHints> m_UsageHints; // 0x38
	private UxmlIntAttributeDescription <focusIndex>k__BackingField; // 0x40
	private UxmlIntAttributeDescription m_TabIndex; // 0x48
	private UxmlBoolAttributeDescription <focusable>k__BackingField; // 0x50
	private UxmlStringAttributeDescription m_Class; // 0x58
	private UxmlStringAttributeDescription m_ContentContainer; // 0x60
	private UxmlStringAttributeDescription m_Style; // 0x68

	// Methods

	// RVA: 0x1863FA8
	protected UxmlIntAttributeDescription get_focusIndex() { }

	// RVA: 0x1863FB0
	protected UxmlBoolAttributeDescription get_focusable() { }

	// RVA: 0x1863FB8
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x18642B4
	public void .ctor() { }

}

// Namespace: 
public enum MeasureMode
{
	// Fields
	public int value__; // 0x10
	public const MeasureMode Undefined = 0;
	public const MeasureMode Exactly = 1;
	public const MeasureMode AtMost = 2;
}

// Namespace: 
internal enum RenderTargetMode
{
	// Fields
	public int value__; // 0x10
	public const RenderTargetMode None = 0;
	public const RenderTargetMode NoColorConversion = 1;
	public const RenderTargetMode LinearToGamma = 2;
	public const RenderTargetMode GammaToLinear = 3;
}

// Namespace: 
public struct Hierarchy
{
	// Fields
	private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation";
	private readonly VisualElement m_Owner; // 0x10

	// Methods

	// RVA: 0x1854598
	public VisualElement get_parent() { }

	// RVA: 0x1864874
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> get_children() { }

	// RVA: 0x1859584
	internal void .ctor(VisualElement element) { }

	// RVA: 0x1860AF0
	public void Add(VisualElement child) { }

	// RVA: 0x1860C44
	public void Insert(int index, VisualElement child) { }

	// RVA: 0x18622FC
	public void Remove(VisualElement child) { }

	// RVA: 0x1864AB0
	public void RemoveAt(int index) { }

	// RVA: 0x1861084
	public void Clear() { }

	// RVA: 0x1861E84
	internal void BringToFront(VisualElement child) { }

	// RVA: 0x1861FD8
	internal void SendToBack(VisualElement child) { }

	// RVA: 0x18621A8
	internal void PlaceBehind(VisualElement child, VisualElement over) { }

	// RVA: 0x1864F68
	private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) { }

	// RVA: 0x1861774
	public int get_childCount() { }

	// RVA: 0x186165C
	public VisualElement get_Item(int key) { }

	// RVA: 0x1861880
	public int IndexOf(VisualElement element) { }

	// RVA: 0x186507C
	public VisualElement ElementAt(int index) { }

	// RVA: 0x1861E24
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children() { }

	// RVA: 0x18649D0
	private void SetParent(VisualElement value) { }

	// RVA: 0x1864894
	private void PutChildAtIndex(VisualElement child, int index) { }

	// RVA: 0x1864DB0
	private void RemoveChildAtIndex(int index) { }

	// RVA: 0x1864E38
	private void ReleaseChildList() { }

	// RVA: 0x18650FC
	public bool Equals(Hierarchy other) { }

	// RVA: 0x1865118
	public override bool Equals(object obj) { }

	// RVA: 0x18651A8
	public override int GetHashCode() { }

	// RVA: 0x186510C
	public static bool op_Equality(Hierarchy x, Hierarchy y) { }

}

// Namespace: 
private abstract class BaseVisualElementScheduledItem
{
	// Fields
	private VisualElement <element>k__BackingField; // 0x38
	public bool isScheduled; // 0x40
	private VisualElementPanelActivator m_Activator; // 0x48

	// Methods

	// RVA: 0x18651C0
	public VisualElement get_element() { }

	// RVA: 0x18651C8
	private void set_element(VisualElement value) { }

	// RVA: 0x18651D0
	public bool get_isActive() { }

	// RVA: 0x18651F0
	protected void .ctor(VisualElement handler) { }

	// RVA: 0x18652A8
	public IVisualElementScheduledItem StartingIn(Int64 delayMs) { }

	// RVA: 0x18652B0
	public IVisualElementScheduledItem Every(Int64 intervalMs) { }

	// RVA: 0x18653B4
	internal override void OnItemUnscheduled() { }

	// RVA: 0x186332C
	public void Resume() { }

	// RVA: 0x1865404
	public void Pause() { }

	// RVA: 0x1865428
	public void ExecuteLater(Int64 delayMs) { }

	// RVA: 0x1865478
	public void OnPanelActivate() { }

	// RVA: 0x1865580
	public void OnPanelDeactivate() { }

	// RVA: 0x1865674
	public bool CanBeActivated() { }

}

// Namespace: 
private abstract class VisualElementScheduledItem<T0>
{
	// Fields
	public ActionType updateEvent; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public void .ctor(VisualElement handler, ActionType upEvent) { }

}

// Namespace: 
private class TimerStateScheduledItem
{
	// Methods

	// RVA: 0x18632C0
	public void .ctor(VisualElement handler, System.Action<UnityEngine.UIElements.TimerState> updateEvent) { }

	// RVA: 0x18656B8
	public override void PerformTimerUpdate(TimerState state) { }

}

// Namespace: 
private class SimpleScheduledItem
{
	// Methods

	// RVA: 0x1863450
	public void .ctor(VisualElement handler, Action updateEvent) { }

	// RVA: 0x18656FC
	public override void PerformTimerUpdate(TimerState state) { }

}

// Namespace: 
internal class CustomStyleAccess
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_CustomProperties; // 0x10
	private float m_DpiScaling; // 0x18

	// Methods

	// RVA: 0x1863570
	public void SetContext(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties, float dpiScaling) { }

	// RVA: 0x1865734
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, float value) { }

	// RVA: 0x186592C
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, int value) { }

	// RVA: 0x1865A98
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, Color value) { }

	// RVA: 0x1865CFC
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, Texture2D value) { }

	// RVA: 0x1865E10
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, Sprite value) { }

	// RVA: 0x1865F24
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, VectorImage value) { }

	// RVA: 0x1866038
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, string value) { }

	// RVA: 0x1865858
	private bool TryGetValue(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

	// RVA: 0x1865BF8
	private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

	// RVA: 0x1863F48
	public void .ctor() { }

}

// Namespace: 
internal class TypeData
{
	// Fields
	private readonly Type <type>k__BackingField; // 0x10
	private string m_FullTypeName; // 0x18
	private string m_TypeName; // 0x20
	private string m_TypeNamespace; // 0x28

	// Methods

	// RVA: 0x186610C
	public Type get_type() { }

	// RVA: 0x1863BCC
	public void .ctor(Type type) { }

	// RVA: 0x1859040
	public string get_fullTypeName() { }

	// RVA: 0x18590BC
	public string get_typeName() { }

	// RVA: 0x1866114
	public string get_typeNamespace() { }

}

// Namespace: 
private sealed class <>c__DisplayClass492_0
{
	// Fields
	public VisualElement <>4__this; // 0x10
	public StyleValues to; // 0x18

	// Methods

	// RVA: 0x1860190
	public void .ctor() { }

	// RVA: 0x1866174
	internal StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(VisualElement e) { }

}

// Namespace: UnityEngine.UIElements
public class VisualElement
{
	// Fields
	private int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField; // 0x2C
	private int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField; // 0x30
	private static UInt32 s_NextId; // 0x0
	private static System.Collections.Generic.List<System.String> s_EmptyClassList; // 0x8
	internal static readonly PropertyName userDataPropertyKey; // 0x10
	public static readonly string disabledUssClassName; // 0x18
	private string m_Name; // 0x38
	private System.Collections.Generic.List<System.String> m_ClassList; // 0x40
	private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.PropertyName,System.Object>> m_PropertyBag; // 0x48
	internal VisualElementFlags m_Flags; // 0x50
	private string m_ViewDataKey; // 0x58
	private RenderHints m_RenderHints; // 0x60
	internal Rect lastLayout; // 0x64
	internal Rect lastPseudoPadding; // 0x74
	internal RenderChainVEData renderChainData; // 0x88
	private Rect m_Layout; // 0x1D0
	private Rect m_BoundingBox; // 0x1E0
	private const VisualElementFlags worldBoundingBoxDirtyDependencies = 25;
	private Rect m_WorldBoundingBox; // 0x1F0
	private const VisualElementFlags worldTransformInverseDirtyDependencies = 3;
	private Matrix4x4 m_WorldTransformCache; // 0x200
	private Matrix4x4 m_WorldTransformInverseCache; // 0x240
	private Rect m_WorldClip; // 0x280
	private Rect m_WorldClipMinusGroup; // 0x290
	private bool m_WorldClipIsInfinite; // 0x2A0
	internal static readonly Rect s_InfiniteRect; // 0x20
	internal PseudoStates triggerPseudoMask; // 0x2A4
	internal PseudoStates dependencyPseudoMask; // 0x2A8
	private PseudoStates m_PseudoStates; // 0x2AC
	private int <containedPointerIds>k__BackingField; // 0x2B0
	private PickingMode m_PickingMode; // 0x2B4
	private YogaNode <yogaNode>k__BackingField; // 0x2B8
	internal ComputedStyle m_Style; // 0x2C0
	internal StyleVariableContext variableContext; // 0x318
	internal int inheritedStylesHash; // 0x320
	internal readonly UInt32 controlid; // 0x324
	internal int imguiContainerDescendantCount; // 0x328
	private bool <enabledSelf>k__BackingField; // 0x32C
	private LanguageDirection m_LanguageDirection; // 0x330
	private LanguageDirection m_LocalLanguageDirection; // 0x334
	private System.Action<UnityEngine.UIElements.MeshGenerationContext> <generateVisualContent>k__BackingField; // 0x338
	private static readonly ProfilerMarker k_GenerateVisualContentMarker; // 0x30
	private RenderTargetMode m_SubRenderTargetMode; // 0x340
	private static Material s_runtimeMaterial; // 0x38
	private Material m_defaultMaterial; // 0x348
	private System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_RunningAnimations; // 0x350
	private static UInt32 s_NextParentVersion; // 0x40
	private UInt32 m_NextParentCachedVersion; // 0x358
	private UInt32 m_NextParentRequiredVersion; // 0x35C
	private VisualElement m_CachedNextParentWithEventCallback; // 0x360
	private int m_EventCallbackCategories; // 0x368
	private int m_CachedEventCallbackParentCategories; // 0x36C
	private readonly int m_DefaultActionEventCategories; // 0x370
	private readonly int m_DefaultActionAtTargetEventCategories; // 0x374
	internal const string k_RootVisualContainerName = "rootVisualContainer";
	private Hierarchy <hierarchy>k__BackingField; // 0x378
	private bool <isRootVisualContainer>k__BackingField; // 0x380
	private bool <cacheAsBitmap>k__BackingField; // 0x381
	private VisualElement m_PhysicalParent; // 0x388
	private VisualElement m_LogicalParent; // 0x390
	private static readonly System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> s_EmptyList; // 0x48
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> m_Children; // 0x398
	private BaseVisualElementPanel <elementPanel>k__BackingField; // 0x3A0
	private VisualTreeAsset m_VisualTreeAssetSource; // 0x3A8
	internal static CustomStyleAccess s_CustomStyleAccess; // 0x50
	internal InlineStyleAccess inlineStyleAccess; // 0x3B0
	internal System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> styleSheetList; // 0x3B8
	private static readonly Regex s_InternalStyleSheetPath; // 0x58
	internal static readonly PropertyName tooltipPropertyKey; // 0x60
	private static readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.UIElements.VisualElement.TypeData> s_TypeData; // 0x68
	private TypeData m_TypeData; // 0x3C0

	// Methods

	// RVA: 0x18516EC
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0x18516F0
	private Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }

	// RVA: 0x1851704
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }

	// RVA: 0x1851710
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }

	// RVA: 0x1851730
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }

	// RVA: 0x1851750
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }

	// RVA: 0x1851770
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }

	// RVA: 0x185177C
	private float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }

	// RVA: 0x185179C
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }

	// RVA: 0x18517A8
	private float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }

	// RVA: 0x18517C8
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }

	// RVA: 0x18517D4
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }

	// RVA: 0x18517F4
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }

	// RVA: 0x1851814
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }

	// RVA: 0x1851834
	private float UnityEngine.UIElements.IResolvedStyle.get_bottom() { }

	// RVA: 0x1851854
	private Color UnityEngine.UIElements.IResolvedStyle.get_color() { }

	// RVA: 0x1851860
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0x185186C
	private FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }

	// RVA: 0x1851878
	private float UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }

	// RVA: 0x1851884
	private float UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }

	// RVA: 0x1851890
	private float UnityEngine.UIElements.IResolvedStyle.get_height() { }

	// RVA: 0x18518B0
	private float UnityEngine.UIElements.IResolvedStyle.get_left() { }

	// RVA: 0x18518D0
	private float UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }

	// RVA: 0x18518F0
	private float UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }

	// RVA: 0x1851910
	private float UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }

	// RVA: 0x1851930
	private float UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }

	// RVA: 0x1851950
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }

	// RVA: 0x1851B48
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }

	// RVA: 0x1851B7C
	private float UnityEngine.UIElements.IResolvedStyle.get_opacity() { }

	// RVA: 0x1851B88
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }

	// RVA: 0x1851BA8
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }

	// RVA: 0x1851BC8
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }

	// RVA: 0x1851BE8
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }

	// RVA: 0x1851C08
	private float UnityEngine.UIElements.IResolvedStyle.get_right() { }

	// RVA: 0x1851C28
	private Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }

	// RVA: 0x1851C34
	private float UnityEngine.UIElements.IResolvedStyle.get_top() { }

	// RVA: 0x1851C54
	private Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }

	// RVA: 0x1851F5C
	private Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }

	// RVA: 0x1852158
	private Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }

	// RVA: 0x1852164
	private int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }

	// RVA: 0x1852170
	private int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }

	// RVA: 0x185217C
	private float UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale() { }

	// RVA: 0x1852188
	private Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }

	// RVA: 0x1852194
	private float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }

	// RVA: 0x18521A0
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0x18521AC
	private float UnityEngine.UIElements.IResolvedStyle.get_width() { }

	// RVA: 0x18521CC
	internal bool get_hasRunningAnimations() { }

	// RVA: 0x1852280
	internal bool get_hasCompletedAnimations() { }

	// RVA: 0x1852330
	private int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }

	// RVA: 0x1852338
	private void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value) { }

	// RVA: 0x1852340
	private int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }

	// RVA: 0x1852348
	private void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value) { }

	// RVA: 0x1852350
	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }

	// RVA: 0x185227C
	internal IStylePropertyAnimations get_styleAnimation() { }

	// RVA: 0x185236C
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1852474
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1852590
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18526AC
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1852800
	private bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x185291C
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1852A5C
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1852B8C
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1852CA8
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1852E08
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1852F38
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1853098
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18531F8
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1853358
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1853488
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18535A4
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1853704
	private void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(StylePropertyId id) { }

	// RVA: 0x18537E4
	private void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }

	// RVA: 0x1853A0C
	private void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) { }

	// RVA: 0x1853AE0
	private void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: 0x1853D10
	internal bool TryConvertLengthUnits(StylePropertyId id, Length from, Length to, int subPropertyIndex) { }

	// RVA: 0x18543A8
	internal bool TryConvertTransformOriginUnits(TransformOrigin from, TransformOrigin to) { }

	// RVA: 0x1854430
	internal bool TryConvertTranslateUnits(Translate from, Translate to) { }

	// RVA: 0x18544B8
	internal bool TryConvertBackgroundSizeUnits(BackgroundSize from, BackgroundSize to) { }

	// RVA: 0x1854074
	private System.Nullable<System.Single> GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex) { }

	// RVA: 0x18545B8
	internal bool get_isCompositeRoot() { }

	// RVA: 0x18545C4
	internal void set_isCompositeRoot(bool value) { }

	// RVA: 0x185478C
	internal bool get_isHierarchyDisplayed() { }

	// RVA: 0x1854798
	internal void set_isHierarchyDisplayed(bool value) { }

	// RVA: 0x18547B8
	public string get_viewDataKey() { }

	// RVA: 0x18547C0
	public void set_viewDataKey(string value) { }

	// RVA: 0x185486C
	internal bool get_enableViewDataPersistence() { }

	// RVA: 0x1854878
	private void set_enableViewDataPersistence(bool value) { }

	// RVA: 0x1854898
	public object get_userData() { }

	// RVA: 0x1854B58
	public void set_userData(object value) { }

	// RVA: 0x1854EA8
	public override bool get_canGrabFocus() { }

	// RVA: 0x185511C
	public override FocusController get_focusController() { }

	// RVA: 0x18551E8
	public UsageHints get_usageHints() { }

	// RVA: 0x1855208
	public void set_usageHints(UsageHints value) { }

	// RVA: 0x1855200
	internal RenderHints get_renderHints() { }

	// RVA: 0x18553A0
	internal void set_renderHints(RenderHints value) { }

	// RVA: 0x18553E8
	internal void MarkRenderHintsClean() { }

	// RVA: 0x18553F8
	public ITransform get_transform() { }

	// RVA: 0x18553FC
	private Vector3 UnityEngine.UIElements.ITransform.get_position() { }

	// RVA: 0x18554B0
	private void UnityEngine.UIElements.ITransform.set_position(Vector3 value) { }

	// RVA: 0x185571C
	private Vector3 UnityEngine.UIElements.ITransform.get_scale() { }

	// RVA: 0x18557D4
	internal bool get_isLayoutManual() { }

	// RVA: 0x18557E0
	private void set_isLayoutManual(bool value) { }

	// RVA: 0x1855800
	internal float get_scaledPixelsPerPoint() { }

	// RVA: 0x1855880
	public Rect get_layout() { }

	// RVA: 0x1855924
	internal void set_layout(Rect value) { }

	// RVA: 0x18561AC
	internal void ClearManualLayout() { }

	// RVA: 0x185680C
	public Rect get_contentRect() { }

	// RVA: 0x1856A24
	protected Rect get_paddingRect() { }

	// RVA: 0x1856C60
	internal bool get_isBoundingBoxDirty() { }

	// RVA: 0x1856C6C
	internal void set_isBoundingBoxDirty(bool value) { }

	// RVA: 0x1856C8C
	internal void set_isWorldBoundingBoxDirty(bool value) { }

	// RVA: 0x1856CAC
	internal bool get_isWorldBoundingBoxOrDependenciesDirty() { }

	// RVA: 0x1856CC0
	internal Rect get_boundingBox() { }

	// RVA: 0x1856F68
	internal Rect get_worldBoundingBox() { }

	// RVA: 0x18570F4
	private Rect get_boundingBoxInParentSpace() { }

	// RVA: 0x1856D08
	internal void UpdateBoundingBox() { }

	// RVA: 0x1856FB8
	internal void UpdateWorldBoundingBox() { }

	// RVA: 0x1857350
	public Rect get_worldBound() { }

	// RVA: 0x1857440
	public Rect get_localBound() { }

	// RVA: 0x1856C44
	internal Rect get_rect() { }

	// RVA: 0x1857488
	internal bool get_isWorldTransformDirty() { }

	// RVA: 0x1857494
	internal void set_isWorldTransformDirty(bool value) { }

	// RVA: 0x18574A8
	internal void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0x18574C8
	internal bool get_isWorldTransformInverseOrDependenciesDirty() { }

	// RVA: 0x18574D8
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0x1857320
	internal Matrix4x4 get_worldTransformRef() { }

	// RVA: 0x1857820
	internal Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0x1857518
	internal void UpdateWorldTransform() { }

	// RVA: 0x185788C
	internal void UpdateWorldTransformInverse() { }

	// RVA: 0x1857D90
	internal bool get_isWorldClipDirty() { }

	// RVA: 0x1857D9C
	internal void set_isWorldClipDirty(bool value) { }

	// RVA: 0x1857DBC
	internal Rect get_worldClip() { }

	// RVA: 0x1858134
	internal Rect get_worldClipMinusGroup() { }

	// RVA: 0x185817C
	internal bool get_worldClipIsInfinite() { }

	// RVA: 0x18581B8
	internal void EnsureWorldTransformAndClipUpToDate() { }

	// RVA: 0x1857E04
	private void UpdateWorldClip() { }

	// RVA: 0x18587BC
	private Rect CombineClipRects(Rect rect, Rect parentRect) { }

	// RVA: 0x1858210
	private Rect SubstractBorderPadding(Rect worldRect) { }

	// RVA: 0x185880C
	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) { }

	// RVA: 0x185892C
	internal PseudoStates get_pseudoStates() { }

	// RVA: 0x1858934
	internal void set_pseudoStates(PseudoStates value) { }

	// RVA: 0x18589BC
	internal int get_containedPointerIds() { }

	// RVA: 0x18589C4
	private void set_containedPointerIds(int value) { }

	// RVA: 0x18589CC
	private void UpdateHoverPseudoState() { }

	// RVA: 0x1858BC8
	private static bool IsPartOfCapturedChain(VisualElement self, IEventHandler capturingElement) { }

	// RVA: 0x1858CD4
	public PickingMode get_pickingMode() { }

	// RVA: 0x1858CDC
	public void set_pickingMode(PickingMode value) { }

	// RVA: 0x1858D14
	public string get_name() { }

	// RVA: 0x1858D1C
	public void set_name(string value) { }

	// RVA: 0x1858D94
	internal System.Collections.Generic.List<System.String> get_classList() { }

	// RVA: 0x1858E90
	internal string get_fullTypeName() { }

	// RVA: 0x18590A0
	internal string get_typeName() { }

	// RVA: 0x185917C
	internal YogaNode get_yogaNode() { }

	// RVA: 0x1859184
	private void set_yogaNode(YogaNode value) { }

	// RVA: 0x18516FC
	internal ComputedStyle get_computedStyle() { }

	// RVA: 0x1859194
	internal bool get_hasInlineStyle() { }

	// RVA: 0x18591A4
	internal bool get_styleInitialized() { }

	// RVA: 0x18591B0
	internal void set_styleInitialized(bool value) { }

	// RVA: 0x18591D0
	private void ChangeIMGUIContainerCount(int delta) { }

	// RVA: 0x1859204
	public void .ctor() { }

	// RVA: 0x18595AC
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x185A21C
	internal virtual Rect GetTooltipRect() { }

	// RVA: 0x185A130
	private void SetTooltip(TooltipEvent e) { }

	// RVA: 0x185A344
	public sealed override void Focus() { }

	// RVA: 0x185A3A8
	internal void SetPanel(BaseVisualElementPanel p) { }

	// RVA: 0x185AF98
	private void WillChangePanel(BaseVisualElementPanel destinationPanel) { }

	// RVA: 0x185B18C
	private void HasChangedPanel(BaseVisualElementPanel prevPanel) { }

	// RVA: 0x185B6F4
	public sealed override void SendEvent(EventBase e) { }

	// RVA: 0x185B70C
	internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: 0x1854848
	internal void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0x185B720
	internal void InvokeHierarchyChanged(HierarchyChangeType changeType) { }

	// RVA: 0x185B73C
	private bool SetEnabledFromHierarchyPrivate(bool state) { }

	// RVA: 0x185BB24
	private bool get_isParentEnabledInHierarchy() { }

	// RVA: 0x185510C
	public bool get_enabledInHierarchy() { }

	// RVA: 0x185BEA0
	public bool get_enabledSelf() { }

	// RVA: 0x185BEA8
	private void set_enabledSelf(bool value) { }

	// RVA: 0x185958C
	public void SetEnabled(bool value) { }

	// RVA: 0x185BEB0
	private void PropagateEnabledToChildren(bool value) { }

	// RVA: 0x185BF7C
	public LanguageDirection get_languageDirection() { }

	// RVA: 0x185BF84
	internal LanguageDirection get_localLanguageDirection() { }

	// RVA: 0x185BF8C
	internal void set_localLanguageDirection(LanguageDirection value) { }

	// RVA: 0x185505C
	public bool get_visible() { }

	// RVA: 0x185C09C
	public void set_visible(bool value) { }

	// RVA: 0x185C214
	public void MarkDirtyRepaint() { }

	// RVA: 0x185C238
	public System.Action<UnityEngine.UIElements.MeshGenerationContext> get_generateVisualContent() { }

	// RVA: 0x185C240
	public void set_generateVisualContent(System.Action<UnityEngine.UIElements.MeshGenerationContext> value) { }

	// RVA: 0x185C250
	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x185C450
	internal void GetFullHierarchicalViewDataKey(StringBuilder key) { }

	// RVA: 0x185C4F4
	internal string GetFullHierarchicalViewDataKey() { }

	// RVA: 0x315B3A8
	internal T GetOrCreateViewData(object existing, string key) { }

	// RVA: 0x185C574
	internal void OverwriteFromViewData(object obj, string key) { }

	// RVA: 0x185C8B4
	internal void SaveViewData() { }

	// RVA: 0x185C940
	internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState) { }

	// RVA: 0x185C9EC
	internal void OnViewDataReady(bool enablePersistence) { }

	// RVA: 0x185CA18
	internal virtual void OnViewDataReady() { }

	// RVA: 0x185CA1C
	public virtual bool ContainsPoint(Vector2 localPoint) { }

	// RVA: 0x185CA70
	internal bool get_requireMeasureFunction() { }

	// RVA: 0x185CA7C
	internal void set_requireMeasureFunction(bool value) { }

	// RVA: 0x185CB8C
	private void AssignMeasureFunction() { }

	// RVA: 0x185CC20
	private void RemoveMeasureFunction() { }

	// RVA: 0x185CC44
	protected internal virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x185CC54
	internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x185CDD8
	private void FinalizeLayout() { }

	// RVA: 0x185CED0
	internal void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x185CF78
	internal void SetComputedStyle(ComputedStyle newStyle) { }

	// RVA: 0x185D13C
	public override string ToString() { }

	// RVA: 0x185D31C
	internal System.Collections.Generic.List<System.String> GetClassesForIteration() { }

	// RVA: 0x185BCA0
	public void AddToClassList(string className) { }

	// RVA: 0x185BB60
	public void RemoveFromClassList(string className) { }

	// RVA: 0x185BE94
	public void EnableInClassList(string className, bool enable) { }

	// RVA: 0x185D324
	public bool ClassListContains(string cls) { }

	// RVA: 0x185D3EC
	internal object GetProperty(PropertyName key) { }

	// RVA: 0x185D5E0
	internal void SetProperty(PropertyName key, object value) { }

	// RVA: 0x185D664
	internal bool HasProperty(PropertyName key) { }

	// RVA: 0x185491C
	private bool TryGetPropertyInternal(PropertyName key, object value) { }

	// RVA: 0x185D478
	private static void CheckUserKeyArgument(PropertyName key) { }

	// RVA: 0x1854BCC
	private void SetPropertyInternal(PropertyName key, object value) { }

	// RVA: 0x1859CA4
	private void UpdateCursorStyle(Int64 eventType) { }

	// RVA: 0x185D6EC
	internal RenderTargetMode get_subRenderTargetMode() { }

	// RVA: 0x185D6F4
	internal Material get_defaultMaterial() { }

	// RVA: 0x185D6FC
	private VisualElementAnimationSystem GetAnimationSystem() { }

	// RVA: 0x185D79C
	internal void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x185D8E8
	internal void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x185B4A4
	private void UnregisterRunningAnimations() { }

	// RVA: 0x185B61C
	private void RegisterRunningAnimations() { }

	// RVA: 0x315B3A8
	private static UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation(UnityEngine.UIElements.Experimental.ValueAnimation<T> anim, System.Func<UnityEngine.UIElements.VisualElement,T> fromValueGetter, T to, int durationMs, System.Action<UnityEngine.UIElements.VisualElement,T> onValueChanged) { }

	// RVA: 0x185D9D8
	private static void AssignStyleValues(VisualElement ve, StyleValues src) { }

	// RVA: 0x185F0E8
	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) { }

	// RVA: 0x1860084
	private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(StyleValues to, int durationMs) { }

	// RVA: 0x1860198
	private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.Experimental.StyleValues> fromValueGetter, StyleValues to, int durationMs) { }

	// RVA: 0x1860328
	private void DirtyNextParentWithEventCallback() { }

	// RVA: 0x18546C4
	private void SetAsNextParentWithEventCallback() { }

	// RVA: 0x18603AC
	internal bool GetCachedNextParentWithEventCallback(VisualElement nextParent) { }

	// RVA: 0x1860404
	internal VisualElement get_nextParentWithEventCallback() { }

	// RVA: 0x1860588
	private void PropagateCachedNextParentWithEventCallback(VisualElement nextParent, VisualElement stopParent) { }

	// RVA: 0x186060C
	internal int get_eventCallbackCategories() { }

	// RVA: 0x1860614
	internal void set_eventCallbackCategories(int value) { }

	// RVA: 0x1860724
	internal int get_eventCallbackParentCategories() { }

	// RVA: 0x1860778
	internal bool get_isEventCallbackParentCategoriesDirty() { }

	// RVA: 0x1860868
	internal void set_isEventCallbackParentCategoriesDirty(bool value) { }

	// RVA: 0x1860784
	private void UpdateCallbackParentCategories() { }

	// RVA: 0x1860888
	internal bool HasEventCallbacks(EventCategory eventCategory) { }

	// RVA: 0x1860898
	internal bool HasParentEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x185B5FC
	internal bool HasEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x1860908
	internal bool HasParentEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x1860970
	internal bool HasEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x1860988
	internal bool HasDefaultAction(EventCategory eventCategory) { }

	// RVA: 0x1860998
	public IExperimentalFeatures get_experimental() { }

	// RVA: 0x186099C
	private ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }

	// RVA: 0x18609A0
	public Hierarchy get_hierarchy() { }

	// RVA: 0x18609A8
	private void set_hierarchy(Hierarchy value) { }

	// RVA: 0x18609BC
	internal bool get_isRootVisualContainer() { }

	// RVA: 0x18609C4
	internal void set_isRootVisualContainer(bool value) { }

	// RVA: 0x18609CC
	internal bool get_disableClipping() { }

	// RVA: 0x18609D8
	internal void set_disableClipping(bool value) { }

	// RVA: 0x18572E8
	internal bool ShouldClip() { }

	// RVA: 0x1855054
	public VisualElement get_parent() { }

	// RVA: 0x18609F8
	internal BaseVisualElementPanel get_elementPanel() { }

	// RVA: 0x1860A00
	private void set_elementPanel(BaseVisualElementPanel value) { }

	// RVA: 0x18551E0
	public IPanel get_panel() { }

	// RVA: 0x1860A10
	public virtual VisualElement get_contentContainer() { }

	// RVA: 0x1860A14
	internal void set_visualTreeAssetSource(VisualTreeAsset value) { }

	// RVA: 0x1860A24
	public void Add(VisualElement child) { }

	// RVA: 0x1860BA4
	public void Insert(int index, VisualElement element) { }

	// RVA: 0x1861010
	public void Clear() { }

	// RVA: 0x18614C4
	public VisualElement ElementAt(int index) { }

	// RVA: 0x1861590
	public VisualElement get_Item(int key) { }

	// RVA: 0x18616DC
	public int get_childCount() { }

	// RVA: 0x18617C8
	public int IndexOf(VisualElement element) { }

	// RVA: 0x18618EC
	internal VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> childIndexes) { }

	// RVA: 0x1861BA4
	internal bool FindElementInTree(VisualElement element, System.Collections.Generic.List<System.Int32> outChildIndexes) { }

	// RVA: 0x1861D5C
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children() { }

	// RVA: 0x1861E44
	public void BringToFront() { }

	// RVA: 0x1861F98
	public void SendToBack() { }

	// RVA: 0x18620B4
	public void PlaceBehind(VisualElement sibling) { }

	// RVA: 0x18622BC
	public void RemoveFromHierarchy() { }

	// RVA: 0x315B3A8
	public T GetFirstOfType() { }

	// RVA: 0x315B3A8
	public T GetFirstAncestorOfType() { }

	// RVA: 0x18623F4
	internal VisualElement GetFirstAncestorWhere(System.Predicate<UnityEngine.UIElements.VisualElement> predicate) { }

	// RVA: 0x1858C9C
	public bool Contains(VisualElement child) { }

	// RVA: 0x185AEAC
	private void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x1862458
	public VisualElement FindCommonAncestor(VisualElement other) { }

	// RVA: 0x1862588
	internal VisualElement GetRoot() { }

	// RVA: 0x1862650
	internal VisualElement GetRootVisualContainer() { }

	// RVA: 0x186268C
	internal VisualElement GetNextElementDepthFirst() { }

	// RVA: 0x18627B0
	internal VisualElement GetPreviousElementDepthFirst() { }

	// RVA: 0x18628C0
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0x18578EC
	private Vector3 get_positionWithLayout() { }

	// RVA: 0x1857940
	internal void GetPivotedMatrixWithLayout(Matrix4x4 result) { }

	// RVA: 0x1862A60
	internal bool get_hasDefaultRotationAndScale() { }

	// RVA: 0x1862B54
	internal static float Min(float a, float b, float c, float d) { }

	// RVA: 0x1862B70
	internal static float Max(float a, float b, float c, float d) { }

	// RVA: 0x1862B8C
	private void TransformAlignedRectToParentSpace(Rect rect) { }

	// RVA: 0x1862D20
	internal static Rect CalculateConservativeRect(Matrix4x4 matrix, Rect rect) { }

	// RVA: 0x1862F98
	internal static void TransformAlignedRect(Matrix4x4 matrix, Rect rect) { }

	// RVA: 0x1862F44
	internal static void OrderMinMaxRect(Rect rect) { }

	// RVA: 0x1863030
	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0x1863054
	internal static Vector2 MultiplyVector2(Matrix4x4 lhs, Vector2 vector) { }

	// RVA: 0x1857BD4
	internal static void MultiplyMatrix34(Matrix4x4 lhs, Matrix4x4 rhs, Matrix4x4 res) { }

	// RVA: 0x1863070
	private static void TranslateMatrix34(Matrix4x4 lhs, Vector3 rhs, Matrix4x4 res) { }

	// RVA: 0x1863160
	private static void TranslateMatrix34InPlace(Matrix4x4 lhs, Vector3 rhs) { }

	// RVA: 0x18631BC
	public IVisualElementScheduler get_schedule() { }

	// RVA: 0x18631C0
	private IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent) { }

	// RVA: 0x1863350
	private IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action updateEvent) { }

	// RVA: 0x1855680
	public IStyle get_style() { }

	// RVA: 0x18634BC
	public ICustomStyle get_customStyle() { }

	// RVA: 0x18635A8
	public VisualElementStyleSheetSet get_styleSheets() { }

	// RVA: 0x18635D8
	internal void AddStyleSheetPath(string sheetPath) { }

	// RVA: 0x1851984
	private StyleFloat ResolveLengthValue(Length length, bool isRow) { }

	// RVA: 0x1851F60
	private Vector3 ResolveTranslate() { }

	// RVA: 0x1851C58
	private Vector3 ResolveTransformOrigin() { }

	// RVA: 0x186292C
	private Quaternion ResolveRotation() { }

	// RVA: 0x18629C0
	private Vector3 ResolveScale() { }

	// RVA: 0x185A220
	public string get_tooltip() { }

	// RVA: 0x18638A0
	public void set_tooltip(string value) { }

	// RVA: 0x1863A94
	internal static TypeData GetOrCreateTypeData(Type t) { }

	// RVA: 0x1858EF8
	private TypeData get_typeData() { }

	// RVA: 0x1863C7C
	private static void .cctor() { }

	// RVA: 0x1863F50
	private YogaSize <AssignMeasureFunction>b__432_0(YogaNode node, float f, YogaMeasureMode mode, float f1, YogaMeasureMode heightMode) { }

}

// Namespace: UnityEngine.UIElements
internal interface IStyleDataGroup<T0>
{
	// Methods

	// RVA: -1
	public abstract T Copy() { }

	// RVA: -1
	public abstract void CopyFrom(T other) { }

}

// Namespace: UnityEngine.UIElements
internal struct InheritedData
{
	// Fields
	public Color color; // 0x10
	public Length fontSize; // 0x20
	public Length letterSpacing; // 0x28
	public TextShadow textShadow; // 0x30
	public Font unityFont; // 0x50
	public FontDefinition unityFontDefinition; // 0x58
	public FontStyle unityFontStyleAndWeight; // 0x68
	public Length unityParagraphSpacing; // 0x6C
	public TextAnchor unityTextAlign; // 0x74
	public Color unityTextOutlineColor; // 0x78
	public float unityTextOutlineWidth; // 0x88
	public Visibility visibility; // 0x8C
	public WhiteSpace whiteSpace; // 0x90
	public Length wordSpacing; // 0x94

	// Methods

	// RVA: 0x1866194
	public InheritedData Copy() { }

	// RVA: 0x18661C0
	public void CopyFrom(InheritedData other) { }

	// RVA: 0x18661EC
	public static bool op_Equality(InheritedData lhs, InheritedData rhs) { }

	// RVA: 0x1866464
	public bool Equals(InheritedData other) { }

	// RVA: 0x18664E0
	public override bool Equals(object obj) { }

	// RVA: 0x18665C8
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal struct LayoutData
{
	// Fields
	public Align alignContent; // 0x10
	public Align alignItems; // 0x14
	public Align alignSelf; // 0x18
	public float borderBottomWidth; // 0x1C
	public float borderLeftWidth; // 0x20
	public float borderRightWidth; // 0x24
	public float borderTopWidth; // 0x28
	public Length bottom; // 0x2C
	public DisplayStyle display; // 0x34
	public Length flexBasis; // 0x38
	public FlexDirection flexDirection; // 0x40
	public float flexGrow; // 0x44
	public float flexShrink; // 0x48
	public Wrap flexWrap; // 0x4C
	public Length height; // 0x50
	public Justify justifyContent; // 0x58
	public Length left; // 0x5C
	public Length marginBottom; // 0x64
	public Length marginLeft; // 0x6C
	public Length marginRight; // 0x74
	public Length marginTop; // 0x7C
	public Length maxHeight; // 0x84
	public Length maxWidth; // 0x8C
	public Length minHeight; // 0x94
	public Length minWidth; // 0x9C
	public Length paddingBottom; // 0xA4
	public Length paddingLeft; // 0xAC
	public Length paddingRight; // 0xB4
	public Length paddingTop; // 0xBC
	public Position position; // 0xC4
	public Length right; // 0xC8
	public Length top; // 0xD0
	public Length width; // 0xD8

	// Methods

	// RVA: 0x186682C
	public LayoutData Copy() { }

	// RVA: 0x1866868
	public void CopyFrom(LayoutData other) { }

	// RVA: 0x1866870
	public static bool op_Equality(LayoutData lhs, LayoutData rhs) { }

	// RVA: 0x1866C24
	public bool Equals(LayoutData other) { }

	// RVA: 0x1866CC0
	public override bool Equals(object obj) { }

	// RVA: 0x1866DC8
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal struct RareData
{
	// Fields
	public Cursor cursor; // 0x10
	public TextOverflow textOverflow; // 0x28
	public Color unityBackgroundImageTintColor; // 0x2C
	public OverflowClipBox unityOverflowClipBox; // 0x3C
	public int unitySliceBottom; // 0x40
	public int unitySliceLeft; // 0x44
	public int unitySliceRight; // 0x48
	public float unitySliceScale; // 0x4C
	public int unitySliceTop; // 0x50
	public TextOverflowPosition unityTextOverflowPosition; // 0x54

	// Methods

	// RVA: 0x1867140
	public RareData Copy() { }

	// RVA: 0x186715C
	public void CopyFrom(RareData other) { }

	// RVA: 0x1867188
	public static bool op_Equality(RareData lhs, RareData rhs) { }

	// RVA: 0x18672D4
	public bool Equals(RareData other) { }

	// RVA: 0x186740C
	public override bool Equals(object obj) { }

	// RVA: 0x18675A0
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal struct TransformData
{
	// Fields
	public Rotate rotate; // 0x10
	public Scale scale; // 0x28
	public TransformOrigin transformOrigin; // 0x38
	public Translate translate; // 0x4C

	// Methods

	// RVA: 0x18676AC
	public TransformData Copy() { }

	// RVA: 0x18676D0
	public void CopyFrom(TransformData other) { }

	// RVA: 0x18676D8
	public static bool op_Equality(TransformData lhs, TransformData rhs) { }

	// RVA: 0x1867A68
	public bool Equals(TransformData other) { }

	// RVA: 0x1867ACC
	public override bool Equals(object obj) { }

	// RVA: 0x1867BA4
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal struct TransitionData
{
	// Fields
	public System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> transitionDelay; // 0x10
	public System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> transitionDuration; // 0x18
	public System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> transitionProperty; // 0x20
	public System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> transitionTimingFunction; // 0x28

	// Methods

	// RVA: 0x1867F14
	public TransitionData Copy() { }

	// RVA: 0x18680B0
	public void CopyFrom(TransitionData other) { }

	// RVA: 0x1868350
	public static bool op_Equality(TransitionData lhs, TransitionData rhs) { }

	// RVA: 0x18683AC
	public bool Equals(TransitionData other) { }

	// RVA: 0x18683E8
	public override bool Equals(object obj) { }

	// RVA: 0x1868498
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal struct VisualData
{
	// Fields
	public Color backgroundColor; // 0x10
	public Background backgroundImage; // 0x20
	public BackgroundPosition backgroundPositionX; // 0x40
	public BackgroundPosition backgroundPositionY; // 0x4C
	public BackgroundRepeat backgroundRepeat; // 0x58
	public BackgroundSize backgroundSize; // 0x60
	public Color borderBottomColor; // 0x74
	public Length borderBottomLeftRadius; // 0x84
	public Length borderBottomRightRadius; // 0x8C
	public Color borderLeftColor; // 0x94
	public Color borderRightColor; // 0xA4
	public Color borderTopColor; // 0xB4
	public Length borderTopLeftRadius; // 0xC4
	public Length borderTopRightRadius; // 0xCC
	public float opacity; // 0xD4
	public OverflowInternal overflow; // 0xD8

	// Methods

	// RVA: 0x1868538
	public VisualData Copy() { }

	// RVA: 0x1868574
	public void CopyFrom(VisualData other) { }

	// RVA: 0x18685A0
	public static bool op_Equality(VisualData lhs, VisualData rhs) { }

	// RVA: 0x1868984
	public bool Equals(VisualData other) { }

	// RVA: 0x1868A20
	public override bool Equals(object obj) { }

	// RVA: 0x1868B28
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal class StyleValueCollection
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValue> m_Values; // 0x10

	// Methods

	// RVA: 0x1868E34
	public StyleLength GetStyleLength(StylePropertyId id) { }

	// RVA: 0x186913C
	public StyleFloat GetStyleFloat(StylePropertyId id) { }

	// RVA: 0x18691B8
	public StyleInt GetStyleInt(StylePropertyId id) { }

	// RVA: 0x1868EB0
	public bool TryGetStyleValue(StylePropertyId id, StyleValue value) { }

	// RVA: 0x186924C
	public void SetStyleValue(StyleValue value) { }

	// RVA: 0x18693D0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public enum LengthUnit
{
	// Fields
	public int value__; // 0x10
	public const LengthUnit Pixel = 0;
	public const LengthUnit Percent = 1;
}

// Namespace: 
private enum Unit
{
	// Fields
	public int value__; // 0x10
	public const Unit Pixel = 0;
	public const Unit Percent = 1;
	public const Unit Auto = 2;
	public const Unit None = 3;
}

// Namespace: UnityEngine.UIElements
[Serializable]
public struct Length
{
	// Fields
	internal const float k_MaxValue = 8.38861e+06;
	private float m_Value; // 0x10
	private Unit m_Unit; // 0x14

	// Methods

	// RVA: 0x186945C
	public static Length Percent(float value) { }

	// RVA: 0x18694A4
	public static Length Auto() { }

	// RVA: 0x18694D0
	public static Length None() { }

	// RVA: 0x18694D8
	public float get_value() { }

	// RVA: 0x18694E0
	public void set_value(float value) { }

	// RVA: 0x1869500
	public LengthUnit get_unit() { }

	// RVA: 0x1869508
	public bool IsAuto() { }

	// RVA: 0x1869518
	public bool IsNone() { }

	// RVA: 0x1869528
	public void .ctor(float value) { }

	// RVA: 0x1869480
	public void .ctor(float value, LengthUnit unit) { }

	// RVA: 0x18694AC
	private void .ctor(float value, Unit unit) { }

	// RVA: 0x186954C
	public static Length op_Implicit(float value) { }

	// RVA: 0x1866C04
	public static bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x186956C
	public static bool op_Inequality(Length lhs, Length rhs) { }

	// RVA: 0x186958C
	public bool Equals(Length other) { }

	// RVA: 0x18695AC
	public override bool Equals(object obj) { }

	// RVA: 0x186710C
	public override int GetHashCode() { }

	// RVA: 0x1869648
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct Rotate
{
	// Fields
	private Angle m_Angle; // 0x10
	private Vector3 m_Axis; // 0x18
	private bool m_IsNone; // 0x24

	// Methods

	// RVA: 0x1869830
	public void .ctor(Angle angle) { }

	// RVA: 0x1869894
	internal static Rotate Initial() { }

	// RVA: 0x1869910
	public static Rotate None() { }

	// RVA: 0x1869998
	public Angle get_angle() { }

	// RVA: 0x18699A0
	public void set_angle(Angle value) { }

	// RVA: 0x18699A8
	internal Vector3 get_axis() { }

	// RVA: 0x18678B8
	public static bool op_Equality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x18699B4
	public static bool op_Inequality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x1869A5C
	public bool Equals(Rotate other) { }

	// RVA: 0x1869B08
	public override bool Equals(object obj) { }

	// RVA: 0x1867CE0
	public override int GetHashCode() { }

	// RVA: 0x1869C28
	public override string ToString() { }

	// RVA: 0x1869CA8
	internal Quaternion ToQuaternion() { }

}

// Namespace: UnityEngine.UIElements
public struct Scale
{
	// Fields
	private Vector3 m_Scale; // 0x10
	private bool m_IsNone; // 0x1C

	// Methods

	// RVA: 0x1869CD8
	public void .ctor(Vector3 scale) { }

	// RVA: 0x1869DF0
	internal static Scale Initial() { }

	// RVA: 0x1869E58
	public static Scale None() { }

	// RVA: 0x1869EC8
	public Vector3 get_value() { }

	// RVA: 0x186794C
	public static bool op_Equality(Scale lhs, Scale rhs) { }

	// RVA: 0x1869ED4
	public static bool op_Inequality(Scale lhs, Scale rhs) { }

	// RVA: 0x1869F2C
	public bool Equals(Scale other) { }

	// RVA: 0x1869F7C
	public override bool Equals(object obj) { }

	// RVA: 0x1867DB8
	public override int GetHashCode() { }

	// RVA: 0x186A048
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleBackgroundSize
{
	// Fields
	private BackgroundSize m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x24

	// Methods

	// RVA: 0x186A058
	public BackgroundSize get_value() { }

	// RVA: 0x186A0A8
	public StyleKeyword get_keyword() { }

	// RVA: 0x186A0B0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x186A0BC
	internal void .ctor(BackgroundSize v, StyleKeyword keyword) { }

	// RVA: 0x186A0D4
	public static bool op_Equality(StyleBackgroundSize lhs, StyleBackgroundSize rhs) { }

	// RVA: 0x186A13C
	public static StyleBackgroundSize op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186A148
	public bool Equals(StyleBackgroundSize other) { }

	// RVA: 0x186A1B0
	public override bool Equals(object obj) { }

	// RVA: 0x186A288
	public override int GetHashCode() { }

	// RVA: 0x186A2BC
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleColor
{
	// Fields
	private Color m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x20

	// Methods

	// RVA: 0x186A348
	public Color get_value() { }

	// RVA: 0x186A370
	public StyleKeyword get_keyword() { }

	// RVA: 0x186A378
	public void .ctor(Color v) { }

	// RVA: 0x186A388
	internal void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0x186A398
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0x186A3F4
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0x186A404
	public bool Equals(StyleColor other) { }

	// RVA: 0x186A460
	public override bool Equals(object obj) { }

	// RVA: 0x186A530
	public override int GetHashCode() { }

	// RVA: 0x186A5D4
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleCursor
{
	// Fields
	private Cursor m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x28

	// Methods

	// RVA: 0x186A660
	public Cursor get_value() { }

	// RVA: 0x186A6AC
	public StyleKeyword get_keyword() { }

	// RVA: 0x186A6B4
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x186A6C8
	internal void .ctor(Cursor v, StyleKeyword keyword) { }

	// RVA: 0x186A6E4
	public static bool op_Equality(StyleCursor lhs, StyleCursor rhs) { }

	// RVA: 0x186A74C
	public static StyleCursor op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186A790
	public bool Equals(StyleCursor other) { }

	// RVA: 0x186A7F8
	public override bool Equals(object obj) { }

	// RVA: 0x186A8D4
	public override int GetHashCode() { }

	// RVA: 0x186A908
	public override string ToString() { }

}

// Namespace: 
private class RefCounted
{
	// Fields
	private static UInt32 m_NextId; // 0x0
	private int m_RefCount; // 0x0
	private readonly UInt32 m_Id; // 0x0
	public T value; // 0x0

	// Methods

	// RVA: 0x30A14A4
	public int get_refCount() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A2378
	public void Acquire() { }

	// RVA: 0x30A2378
	public void Release() { }

	// RVA: 0x30A17DC
	public RefCounted Copy() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct StyleDataRef<T0>
{
	// Fields
	private RefCounted m_Ref; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public UnityEngine.UIElements.StyleDataRef<T> Acquire() { }

	// RVA: 0x30A2378
	public void Release() { }

	// RVA: 0x315B3A8
	public void CopyFrom(UnityEngine.UIElements.StyleDataRef<T> other) { }

	// RVA: 0x30A17DC
	public T Read() { }

	// RVA: 0x30A17DC
	public T Write() { }

	// RVA: 0x315B3A8
	public static UnityEngine.UIElements.StyleDataRef<T> Create() { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

	// RVA: 0x315B3A8
	public static bool op_Equality(UnityEngine.UIElements.StyleDataRef<T> lhs, UnityEngine.UIElements.StyleDataRef<T> rhs) { }

	// RVA: 0x315B3A8
	public bool Equals(UnityEngine.UIElements.StyleDataRef<T> other) { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x315B3A8
	public bool ReferenceEquals(UnityEngine.UIElements.StyleDataRef<T> other) { }

}

// Namespace: UnityEngine.UIElements
public struct StyleEnum<T0>
{
	// Fields
	private T m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public T get_value() { }

	// RVA: 0x30A14A4
	public StyleKeyword get_keyword() { }

	// RVA: 0x315B3A8
	public void .ctor(T v) { }

	// RVA: 0x30A24F0
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x315B3A8
	internal void .ctor(T v, StyleKeyword keyword) { }

	// RVA: 0x315B3A8
	public static bool op_Equality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs) { }

	// RVA: 0x315B3A8
	public static bool op_Inequality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs) { }

	// RVA: 0x315B3A8
	public static UnityEngine.UIElements.StyleEnum<T> op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x315B3A8
	public static UnityEngine.UIElements.StyleEnum<T> op_Implicit(T v) { }

	// RVA: 0x315B3A8
	public bool Equals(UnityEngine.UIElements.StyleEnum<T> other) { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

	// RVA: 0x30A17DC
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFloat
{
	// Fields
	private float m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x14

	// Methods

	// RVA: 0x186A98C
	public float get_value() { }

	// RVA: 0x186A9A4
	public StyleKeyword get_keyword() { }

	// RVA: 0x186A9AC
	public void .ctor(float v) { }

	// RVA: 0x186A9B8
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x18691A4
	internal void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0x186A9C0
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0x18691B0
	public static StyleFloat op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186A9E0
	public static StyleFloat op_Implicit(float v) { }

	// RVA: 0x186A9E8
	public bool Equals(StyleFloat other) { }

	// RVA: 0x186AA08
	public override bool Equals(object obj) { }

	// RVA: 0x186AAA4
	public override int GetHashCode() { }

	// RVA: 0x186AAD8
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFont
{
	// Fields
	private Font m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x18

	// Methods

	// RVA: 0x186AB5C
	public Font get_value() { }

	// RVA: 0x186AB74
	public StyleKeyword get_keyword() { }

	// RVA: 0x186AB7C
	public void .ctor(Font v) { }

	// RVA: 0x186AB88
	internal void .ctor(Font v, StyleKeyword keyword) { }

	// RVA: 0x186AB94
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0x186AC38
	public static StyleFont op_Implicit(Font v) { }

	// RVA: 0x186AC64
	public bool Equals(StyleFont other) { }

	// RVA: 0x186AD08
	public override bool Equals(object obj) { }

	// RVA: 0x186ADF0
	public override int GetHashCode() { }

	// RVA: 0x186AECC
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFontDefinition
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private FontDefinition m_Value; // 0x18

	// Methods

	// RVA: 0x186AF50
	public FontDefinition get_value() { }

	// RVA: 0x186AF6C
	public StyleKeyword get_keyword() { }

	// RVA: 0x186AF74
	public void .ctor(FontDefinition f) { }

	// RVA: 0x186AF88
	internal void .ctor(FontDefinition f, StyleKeyword keyword) { }

	// RVA: 0x186AF9C
	public static StyleFontDefinition op_Implicit(FontDefinition f) { }

	// RVA: 0x186AFEC
	public bool Equals(StyleFontDefinition other) { }

	// RVA: 0x186B018
	public override bool Equals(object obj) { }

	// RVA: 0x186B0B4
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleInt
{
	// Fields
	private int m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x14

	// Methods

	// RVA: 0x186B0E4
	public int get_value() { }

	// RVA: 0x186B0FC
	public StyleKeyword get_keyword() { }

	// RVA: 0x186B104
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x186923C
	internal void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0x186B10C
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0x1869244
	public static StyleInt op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186B118
	public bool Equals(StyleInt other) { }

	// RVA: 0x186B128
	public override bool Equals(object obj) { }

	// RVA: 0x186B1B8
	public override int GetHashCode() { }

	// RVA: 0x186B1CC
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleLength
{
	// Fields
	private Length m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x18

	// Methods

	// RVA: 0x186B250
	public Length get_value() { }

	// RVA: 0x186B278
	public StyleKeyword get_keyword() { }

	// RVA: 0x186B280
	public void .ctor(float v) { }

	// RVA: 0x186B2A8
	public void .ctor(Length v) { }

	// RVA: 0x186B2C8
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x1869110
	internal void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0x186B2D4
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x1869130
	public static StyleLength op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186B2FC
	public static StyleLength op_Implicit(float v) { }

	// RVA: 0x186B320
	public static StyleLength op_Implicit(Length v) { }

	// RVA: 0x186B334
	public bool Equals(StyleLength other) { }

	// RVA: 0x186B368
	public override bool Equals(object obj) { }

	// RVA: 0x186B414
	public override int GetHashCode() { }

	// RVA: 0x186B450
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleRotate
{
	// Fields
	private Rotate m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x28

	// Methods

	// RVA: 0x186B4DC
	public Rotate get_value() { }

	// RVA: 0x186B630
	public StyleKeyword get_keyword() { }

	// RVA: 0x186B638
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x186B648
	internal void .ctor(Rotate v, StyleKeyword keyword) { }

	// RVA: 0x186B660
	public static bool op_Equality(StyleRotate lhs, StyleRotate rhs) { }

	// RVA: 0x186B71C
	public static StyleRotate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186B72C
	public bool Equals(StyleRotate other) { }

	// RVA: 0x186B7E4
	public override bool Equals(object obj) { }

	// RVA: 0x186B90C
	public override int GetHashCode() { }

	// RVA: 0x186B93C
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleScale
{
	// Fields
	private Scale m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x20

	// Methods

	// RVA: 0x186B9C8
	public Scale get_value() { }

	// RVA: 0x186BB04
	public StyleKeyword get_keyword() { }

	// RVA: 0x186BB0C
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x186BB18
	internal void .ctor(Scale v, StyleKeyword keyword) { }

	// RVA: 0x186BB24
	public static bool op_Equality(StyleScale lhs, StyleScale rhs) { }

	// RVA: 0x186BB8C
	public static StyleScale op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186BB98
	public bool Equals(StyleScale other) { }

	// RVA: 0x186BC00
	public override bool Equals(object obj) { }

	// RVA: 0x186BCDC
	public override int GetHashCode() { }

	// RVA: 0x186BD44
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleTranslate
{
	// Fields
	private Translate m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x28

	// Methods

	// RVA: 0x186BDD0
	public Translate get_value() { }

	// RVA: 0x186BEC4
	public StyleKeyword get_keyword() { }

	// RVA: 0x186BECC
	public void .ctor(Translate v) { }

	// RVA: 0x186BF08
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x186BEF0
	internal void .ctor(Translate v, StyleKeyword keyword) { }

	// RVA: 0x186BF18
	public static bool op_Equality(StyleTranslate lhs, StyleTranslate rhs) { }

	// RVA: 0x186BF8C
	public static StyleTranslate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186BF9C
	public static StyleTranslate op_Implicit(Translate v) { }

	// RVA: 0x186BFB4
	public bool Equals(StyleTranslate other) { }

	// RVA: 0x186C030
	public override bool Equals(object obj) { }

	// RVA: 0x186C120
	public override int GetHashCode() { }

	// RVA: 0x186C1AC
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleTextShadow
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private TextShadow m_Value; // 0x14

	// Methods

	// RVA: 0x186C238
	public TextShadow get_value() { }

	// RVA: 0x186C290
	public StyleKeyword get_keyword() { }

	// RVA: 0x186C298
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x186C2B0
	internal void .ctor(TextShadow v, StyleKeyword keyword) { }

	// RVA: 0x186C2D0
	public static bool op_Equality(StyleTextShadow lhs, StyleTextShadow rhs) { }

	// RVA: 0x186C340
	public static StyleTextShadow op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186C358
	public bool Equals(StyleTextShadow other) { }

	// RVA: 0x186C3C0
	public override bool Equals(object obj) { }

	// RVA: 0x186C49C
	public override int GetHashCode() { }

	// RVA: 0x186C4E8
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleTransformOrigin
{
	// Fields
	private TransformOrigin m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x24

	// Methods

	// RVA: 0x186C56C
	public TransformOrigin get_value() { }

	// RVA: 0x186C61C
	public StyleKeyword get_keyword() { }

	// RVA: 0x186C624
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x186C630
	internal void .ctor(TransformOrigin v, StyleKeyword keyword) { }

	// RVA: 0x186C648
	public static bool op_Equality(StyleTransformOrigin lhs, StyleTransformOrigin rhs) { }

	// RVA: 0x186C6AC
	public static StyleTransformOrigin op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x186C6B8
	public bool Equals(StyleTransformOrigin other) { }

	// RVA: 0x186C724
	public override bool Equals(object obj) { }

	// RVA: 0x186C804
	public override int GetHashCode() { }

	// RVA: 0x186C890
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
internal interface IStyleValue<T0>
{
	// Methods

	// RVA: -1
	public abstract T get_value() { }

	// RVA: -1
	public abstract StyleKeyword get_keyword() { }

}

// Namespace: UnityEngine.UIElements
public enum StyleKeyword
{
	// Fields
	public int value__; // 0x10
	public const StyleKeyword Undefined = 0;
	public const StyleKeyword Null = 1;
	public const StyleKeyword Auto = 2;
	public const StyleKeyword None = 3;
	public const StyleKeyword Initial = 4;
}

// Namespace: UnityEngine.UIElements
internal static class StyleValueExtensions
{
	// Methods

	// RVA: 0x30A52D0
	internal static string DebugString(UnityEngine.UIElements.IStyleValue<T> styleValue) { }

	// RVA: 0x186C91C
	internal static YogaValue ToYogaValue(Length length) { }

	// RVA: 0x186CA7C
	internal static Length ToLength(StyleKeyword keyword) { }

	// RVA: 0x186CB90
	internal static Rotate ToRotate(StyleKeyword keyword) { }

	// RVA: 0x186CD04
	internal static Scale ToScale(StyleKeyword keyword) { }

	// RVA: 0x186CE60
	internal static Translate ToTranslate(StyleKeyword keyword) { }

	// RVA: 0x186CFAC
	internal static Length ToLength(StyleLength styleLength) { }

	// RVA: 0x30A8E44
	internal static void CopyFrom(System.Collections.Generic.List<T> list, System.Collections.Generic.List<T> other) { }

}

// Namespace: UnityEngine.UIElements
public enum TimeUnit
{
	// Fields
	public int value__; // 0x10
	public const TimeUnit Second = 0;
	public const TimeUnit Millisecond = 1;
}

// Namespace: UnityEngine.UIElements
public struct TimeValue
{
	// Fields
	private float m_Value; // 0x10
	private TimeUnit m_Unit; // 0x14

	// Methods

	// RVA: 0x186CFDC
	public float get_value() { }

	// RVA: 0x186CFE4
	public TimeUnit get_unit() { }

	// RVA: 0x186CFEC
	public void .ctor(float value) { }

	// RVA: 0x186CFF8
	public void .ctor(float value, TimeUnit unit) { }

	// RVA: 0x186D004
	public static TimeValue op_Implicit(float value) { }

	// RVA: 0x186D00C
	public static bool op_Equality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x186D02C
	public static bool op_Inequality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x186D04C
	public bool Equals(TimeValue other) { }

	// RVA: 0x186D06C
	public override bool Equals(object obj) { }

	// RVA: 0x186D108
	public override int GetHashCode() { }

	// RVA: 0x186D13C
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct TransformOrigin
{
	// Fields
	private Length m_X; // 0x10
	private Length m_Y; // 0x18
	private float m_Z; // 0x20

	// Methods

	// RVA: 0x186D25C
	public void .ctor(Length x, Length y, float z) { }

	// RVA: 0x186C604
	public static TransformOrigin Initial() { }

	// RVA: 0x186D268
	public Length get_x() { }

	// RVA: 0x186D270
	public void set_x(Length value) { }

	// RVA: 0x186D278
	public Length get_y() { }

	// RVA: 0x186D280
	public void set_y(Length value) { }

	// RVA: 0x186D288
	public float get_z() { }

	// RVA: 0x18679A4
	public static bool op_Equality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x186D290
	public static bool op_Inequality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x186D2E4
	public bool Equals(TransformOrigin other) { }

	// RVA: 0x186D338
	public override bool Equals(object obj) { }

	// RVA: 0x1867E14
	public override int GetHashCode() { }

	// RVA: 0x186D400
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct Translate
{
	// Fields
	private Length m_X; // 0x10
	private Length m_Y; // 0x18
	private float m_Z; // 0x20
	private bool m_isNone; // 0x24

	// Methods

	// RVA: 0x186D5A8
	public void .ctor(Length x, Length y, float z) { }

	// RVA: 0x186BEA8
	public static Translate None() { }

	// RVA: 0x186D5B8
	public Length get_x() { }

	// RVA: 0x186D5C0
	public void set_x(Length value) { }

	// RVA: 0x186D5C8
	public Length get_y() { }

	// RVA: 0x186D5D0
	public void set_y(Length value) { }

	// RVA: 0x186D5D8
	public float get_z() { }

	// RVA: 0x1867A00
	public static bool op_Equality(Translate lhs, Translate rhs) { }

	// RVA: 0x186D5E0
	public static bool op_Inequality(Translate lhs, Translate rhs) { }

	// RVA: 0x186D648
	public bool Equals(Translate other) { }

	// RVA: 0x186D6B4
	public override bool Equals(object obj) { }

	// RVA: 0x1867E94
	public override int GetHashCode() { }

	// RVA: 0x186D78C
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public enum Position
{
	// Fields
	public int value__; // 0x10
	public const Position Relative = 0;
	public const Position Absolute = 1;
}

// Namespace: UnityEngine.UIElements
public enum Overflow
{
	// Fields
	public int value__; // 0x10
	public const Overflow Visible = 0;
	public const Overflow Hidden = 1;
}

// Namespace: UnityEngine.UIElements
internal enum OverflowInternal
{
	// Fields
	public int value__; // 0x10
	public const OverflowInternal Visible = 0;
	public const OverflowInternal Hidden = 1;
	public const OverflowInternal Scroll = 2;
}

// Namespace: UnityEngine.UIElements
public enum OverflowClipBox
{
	// Fields
	public int value__; // 0x10
	public const OverflowClipBox PaddingBox = 0;
	public const OverflowClipBox ContentBox = 1;
}

// Namespace: UnityEngine.UIElements
public enum FlexDirection
{
	// Fields
	public int value__; // 0x10
	public const FlexDirection Column = 0;
	public const FlexDirection ColumnReverse = 1;
	public const FlexDirection Row = 2;
	public const FlexDirection RowReverse = 3;
}

// Namespace: UnityEngine.UIElements
public enum Wrap
{
	// Fields
	public int value__; // 0x10
	public const Wrap NoWrap = 0;
	public const Wrap Wrap = 1;
	public const Wrap WrapReverse = 2;
}

// Namespace: UnityEngine.UIElements
public enum Align
{
	// Fields
	public int value__; // 0x10
	public const Align Auto = 0;
	public const Align FlexStart = 1;
	public const Align Center = 2;
	public const Align FlexEnd = 3;
	public const Align Stretch = 4;
}

// Namespace: UnityEngine.UIElements
public enum Justify
{
	// Fields
	public int value__; // 0x10
	public const Justify FlexStart = 0;
	public const Justify Center = 1;
	public const Justify FlexEnd = 2;
	public const Justify SpaceBetween = 3;
	public const Justify SpaceAround = 4;
}

// Namespace: UnityEngine.UIElements
public enum TextOverflowPosition
{
	// Fields
	public int value__; // 0x10
	public const TextOverflowPosition End = 0;
	public const TextOverflowPosition Start = 1;
	public const TextOverflowPosition Middle = 2;
}

// Namespace: UnityEngine.UIElements
public enum TextOverflow
{
	// Fields
	public int value__; // 0x10
	public const TextOverflow Clip = 0;
	public const TextOverflow Ellipsis = 1;
}

// Namespace: UnityEngine.UIElements
public enum TransformOriginOffset
{
	// Fields
	public int value__; // 0x10
	public const TransformOriginOffset Left = 1;
	public const TransformOriginOffset Right = 2;
	public const TransformOriginOffset Top = 3;
	public const TransformOriginOffset Bottom = 4;
	public const TransformOriginOffset Center = 5;
}

// Namespace: UnityEngine.UIElements
public enum Visibility
{
	// Fields
	public int value__; // 0x10
	public const Visibility Visible = 0;
	public const Visibility Hidden = 1;
}

// Namespace: UnityEngine.UIElements
public enum WhiteSpace
{
	// Fields
	public int value__; // 0x10
	public const WhiteSpace Normal = 0;
	public const WhiteSpace NoWrap = 1;
}

// Namespace: UnityEngine.UIElements
public enum DisplayStyle
{
	// Fields
	public int value__; // 0x10
	public const DisplayStyle Flex = 0;
	public const DisplayStyle None = 1;
}

// Namespace: UnityEngine.UIElements
public enum BackgroundPositionKeyword
{
	// Fields
	public int value__; // 0x10
	public const BackgroundPositionKeyword Center = 0;
	public const BackgroundPositionKeyword Top = 1;
	public const BackgroundPositionKeyword Bottom = 2;
	public const BackgroundPositionKeyword Left = 3;
	public const BackgroundPositionKeyword Right = 4;
}

// Namespace: UnityEngine.UIElements
public enum Repeat
{
	// Fields
	public int value__; // 0x10
	public const Repeat NoRepeat = 0;
	public const Repeat Space = 1;
	public const Repeat Round = 2;
	public const Repeat Repeat = 3;
}

// Namespace: UnityEngine.UIElements
public enum BackgroundSizeType
{
	// Fields
	public int value__; // 0x10
	public const BackgroundSizeType Length = 0;
	public const BackgroundSizeType Cover = 1;
	public const BackgroundSizeType Contain = 2;
}

// Namespace: UnityEngine.UIElements
internal interface IStylePainter
{
	// Methods

	// RVA: -1
	public abstract void DrawText(TextElement te) { }

	// RVA: -1
	public abstract void DrawRectangle(RectangleParams rectParams) { }

	// RVA: -1
	public abstract void DrawImmediate(Action callback, bool cullingEnabled) { }

}

// Namespace: UnityEngine.UIElements
internal interface IStylePropertyAnimations
{
	// Methods

	// RVA: -1
	public abstract bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract void UpdateAnimation(StylePropertyId id) { }

	// RVA: -1
	public abstract void GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: -1
	public abstract void CancelAnimation(StylePropertyId id) { }

	// RVA: -1
	public abstract void CancelAllAnimations() { }

	// RVA: -1
	public abstract int get_runningAnimationCount() { }

	// RVA: -1
	public abstract void set_runningAnimationCount(int value) { }

	// RVA: -1
	public abstract int get_completedAnimationCount() { }

	// RVA: -1
	public abstract void set_completedAnimationCount(int value) { }

}

// Namespace: UnityEngine.UIElements
internal interface IStylePropertyAnimationSystem
{
	// Methods

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	public abstract void CancelAllAnimations() { }

	// RVA: -1
	public abstract void CancelAllAnimations(VisualElement owner) { }

	// RVA: -1
	public abstract void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: -1
	public abstract void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: -1
	public abstract void GetAllAnimations(VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds) { }

	// RVA: -1
	public abstract void Update() { }

}

// Namespace: 
private enum TransitionState
{
	// Fields
	public int value__; // 0x10
	public const TransitionState None = 0;
	public const TransitionState Running = 1;
	public const TransitionState Started = 2;
	public const TransitionState Ended = 4;
	public const TransitionState Canceled = 8;
}

// Namespace: 
private struct AnimationDataSet<T0, T1>
{
	// Fields
	public VisualElement[] elements; // 0x0
	public StylePropertyId[] properties; // 0x0
	public TTimingData[] timing; // 0x0
	public TStyleData[] style; // 0x0
	public int count; // 0x0
	private System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,System.Int32> indices; // 0x0

	// Methods

	// RVA: 0x30A14A4
	private int get_capacity() { }

	// RVA: 0x30A24F0
	private void set_capacity(int value) { }

	// RVA: 0x30A2378
	private void LocalInit() { }

	// RVA: 0x315B3A8
	public static UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<TTimingData,TStyleData> Create() { }

	// RVA: -1
	public bool IndexOf(VisualElement ve, StylePropertyId prop, int index) { }

	// RVA: 0x315B3A8
	public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) { }

	// RVA: 0x30A24F0
	public void Remove(int cancelledIndex) { }

	// RVA: 0x315B3A8
	public void Replace(int index, TTimingData timingData, TStyleData styleData) { }

	// RVA: 0x30A27C0
	public void RemoveAll(VisualElement ve) { }

	// RVA: 0x30A2378
	public void RemoveAll() { }

	// RVA: 0x30A2A20
	public void GetActivePropertiesForElement(VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outProperties) { }

}

// Namespace: 
private class EqualityComparer
{
	// Methods

	// RVA: 0x186F378
	public bool Equals(ElementPropertyPair x, ElementPropertyPair y) { }

	// RVA: 0x186F388
	public int GetHashCode(ElementPropertyPair obj) { }

	// RVA: 0x186F370
	public void .ctor() { }

}

// Namespace: 
private struct ElementPropertyPair
{
	// Fields
	public static readonly System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair> Comparer; // 0x0
	public readonly VisualElement element; // 0x10
	public readonly StylePropertyId property; // 0x18

	// Methods

	// RVA: 0x186F2BC
	public void .ctor(VisualElement element, StylePropertyId property) { }

	// RVA: 0x186F2E8
	private static void .cctor() { }

}

// Namespace: 
private abstract class Values
{
	// Methods

	// RVA: -1
	public abstract void CancelAllAnimations() { }

	// RVA: -1
	public abstract void CancelAllAnimations(VisualElement ve) { }

	// RVA: -1
	public abstract void CancelAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: -1
	public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: -1
	public abstract void GetAllAnimations(VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: -1
	public abstract void Update(Int64 currentTimeMs) { }

	// RVA: -1
	protected abstract void UpdateValues() { }

	// RVA: -1
	protected abstract void UpdateComputedStyle() { }

	// RVA: -1
	protected abstract void UpdateComputedStyle(int i) { }

	// RVA: 0x186F3CC
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A17DC
	internal System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> <.cctor>b__11_0() { }

}

// Namespace: 
private class TransitionEventsFrameState
{
	// Fields
	private static readonly UnityEngine.Pool.ObjectPool<System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>> k_EventQueuePool; // 0x0
	public readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,UnityEngine.UIElements.StylePropertyAnimationSystem.TransitionState> elementPropertyStateDelta; // 0x0
	public readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair,System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase>> elementPropertyQueuedEvents; // 0x0
	public IPanel panel; // 0x0
	private int m_ChangesCount; // 0x0

	// Methods

	// RVA: 0x30A5298
	public static System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> GetPooledQueue() { }

	// RVA: 0x30A2378
	public void RegisterChange() { }

	// RVA: 0x30A2378
	public void UnregisterChange() { }

	// RVA: 0x30A1224
	public bool StateChanged() { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: 
public struct TimingData
{
	// Fields
	public Int64 startTimeMs; // 0x0
	public int durationMs; // 0x0
	public System.Func<System.Single,System.Single> easingCurve; // 0x0
	public float easedProgress; // 0x0
	public float reversingShorteningFactor; // 0x0
	public bool isStarted; // 0x0
	public int delayMs; // 0x0
}

// Namespace: 
public struct StyleData
{
	// Fields
	public T startValue; // 0x0
	public T endValue; // 0x0
	public T reversingAdjustedStartValue; // 0x0
	public T currentValue; // 0x0
}

// Namespace: 
public struct EmptyData
{
	// Fields
	public static EmptyData Default; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: 
private abstract class Values<T0>
{
	// Fields
	private Int64 m_CurrentTimeMs; // 0x0
	private TransitionEventsFrameState m_CurrentFrameEventsState; // 0x0
	private TransitionEventsFrameState m_NextFrameEventsState; // 0x0
	public UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TimingData<T>,UnityEngine.UIElements.StylePropertyAnimationSystem.Values.StyleData<T>> running; // 0x0
	public UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<UnityEngine.UIElements.StylePropertyAnimationSystem.Values.EmptyData<T>,T> completed; // 0x0

	// Methods

	// RVA: 0x30A1224
	public bool get_isEmpty() { }

	// RVA: -1
	public abstract System.Func<T,T,System.Boolean> get_SameFunc() { }

	// RVA: -1
	protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, T a, T b) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

	// RVA: 0x30A2378
	private void SwapFrameStates() { }

	// RVA: 0x315B3A8
	private void QueueEvent(EventBase evt, ElementPropertyPair epp) { }

	// RVA: 0x315B3A8
	private void ClearEventQueue(ElementPropertyPair epp) { }

	// RVA: 0x30A2828
	private void QueueTransitionRunEvent(VisualElement ve, int runningIndex) { }

	// RVA: 0x30A2828
	private void QueueTransitionStartEvent(VisualElement ve, int runningIndex) { }

	// RVA: 0x30A2828
	private void QueueTransitionEndEvent(VisualElement ve, int runningIndex) { }

	// RVA: 0x315B3A8
	private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, Int64 panelElapsedMs) { }

	// RVA: 0x315B3A8
	private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, Int64 panelElapsedMs) { }

	// RVA: 0x30A2378
	public sealed override void CancelAllAnimations() { }

	// RVA: 0x30A27C0
	public sealed override void CancelAllAnimations(VisualElement ve) { }

	// RVA: 0x30A2828
	public sealed override void CancelAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: 0x30A2828
	public sealed override void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: 0x30A2A20
	public sealed override void GetAllAnimations(VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: -1
	private float ComputeReversingShorteningFactor(int oldIndex) { }

	// RVA: 0x315B3A8
	private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor) { }

	// RVA: 0x315B3A8
	private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor) { }

	// RVA: 0x315B3A8
	public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve, Int64 currentTimeMs) { }

	// RVA: 0x30A24F0
	private void ForceComputedStyleEndValue(int runningIndex) { }

	// RVA: -1
	public sealed override void Update(Int64 currentTimeMs) { }

	// RVA: 0x30A2378
	private void ProcessEventQueue() { }

	// RVA: -1
	private void UpdateProgress(Int64 currentTimeMs) { }

}

// Namespace: 
private class ValuesFloat
{
	// Fields
	private readonly System.Func<System.Single,System.Single,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x186F3D4
	public override System.Func<System.Single,System.Single,System.Boolean> get_SameFunc() { }

	// RVA: 0x186F3DC
	private static bool IsSame(float a, float b) { }

	// RVA: 0x186F474
	private static float Lerp(float a, float b, float t) { }

	// RVA: 0x186F484
	protected sealed override void UpdateValues() { }

	// RVA: 0x186F508
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x186F5D8
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x186F68C
	public void .ctor() { }

}

// Namespace: 
private class ValuesInt
{
	// Fields
	private readonly System.Func<System.Int32,System.Int32,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x186F73C
	public override System.Func<System.Int32,System.Int32,System.Boolean> get_SameFunc() { }

	// RVA: 0x186F744
	private static bool IsSame(int a, int b) { }

	// RVA: 0x186F750
	private static int Lerp(int a, int b, float t) { }

	// RVA: 0x186F87C
	protected sealed override void UpdateValues() { }

	// RVA: 0x186F918
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x186F9E8
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x186FA9C
	public void .ctor() { }

}

// Namespace: 
private class ValuesLength
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x186FB4C
	public override System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean> get_SameFunc() { }

	// RVA: 0x186FB54
	private static bool IsSame(Length a, Length b) { }

	// RVA: 0x186FC04
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, Length a, Length b) { }

	// RVA: 0x186FC30
	internal static Length Lerp(Length a, Length b, float t) { }

	// RVA: 0x186FC6C
	protected sealed override void UpdateValues() { }

	// RVA: 0x186FD20
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x186FDF0
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x186FEA4
	public void .ctor() { }

}

// Namespace: 
private class ValuesColor
{
	// Fields
	private readonly System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x186FF54
	public override System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean> get_SameFunc() { }

	// RVA: 0x186FF5C
	private static bool IsSame(Color c, Color d) { }

	// RVA: 0x18700B0
	private static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x18700E8
	protected sealed override void UpdateValues() { }

	// RVA: 0x187016C
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1870244
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18702FC
	public void .ctor() { }

}

// Namespace: 
private abstract class ValuesDiscrete<T0>
{
	// Fields
	private readonly System.Func<T,T,System.Boolean> <SameFunc>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A17DC
	public override System.Func<T,T,System.Boolean> get_SameFunc() { }

	// RVA: 0x315B3A8
	private static bool IsSame(T a, T b) { }

	// RVA: 0x315B3A8
	private static T Lerp(T a, T b, float t) { }

	// RVA: 0x30A2378
	protected sealed override void UpdateValues() { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
private class ValuesBackground
{
	// Methods

	// RVA: 0x18703AC
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1870490
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x1870558
	public void .ctor() { }

}

// Namespace: 
private class ValuesFontDefinition
{
	// Methods

	// RVA: 0x18705AC
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1870680
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x1870734
	public void .ctor() { }

}

// Namespace: 
private class ValuesFont
{
	// Methods

	// RVA: 0x1870788
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1870858
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x187090C
	public void .ctor() { }

}

// Namespace: 
private class ValuesTextShadow
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x1870960
	public override System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean> get_SameFunc() { }

	// RVA: 0x1870968
	private static bool IsSame(TextShadow a, TextShadow b) { }

	// RVA: 0x18709B0
	private static TextShadow Lerp(TextShadow a, TextShadow b, float t) { }

	// RVA: 0x1870A18
	protected sealed override void UpdateValues() { }

	// RVA: 0x1870B14
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1870C08
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x1870CE4
	public void .ctor() { }

}

// Namespace: 
private class ValuesScale
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x1870D94
	public override System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean> get_SameFunc() { }

	// RVA: 0x1870D9C
	private static bool IsSame(Scale a, Scale b) { }

	// RVA: 0x1870DF4
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1870EC8
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x1870F7C
	private static Scale Lerp(Scale a, Scale b, float t) { }

	// RVA: 0x1870FEC
	protected sealed override void UpdateValues() { }

	// RVA: 0x18710CC
	public void .ctor() { }

}

// Namespace: 
private class ValuesRotate
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x187117C
	public override System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean> get_SameFunc() { }

	// RVA: 0x1871184
	private static bool IsSame(Rotate a, Rotate b) { }

	// RVA: 0x1871230
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x187131C
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18713F0
	private static Rotate Lerp(Rotate a, Rotate b, float t) { }

	// RVA: 0x18714B0
	protected sealed override void UpdateValues() { }

	// RVA: 0x18715F0
	public void .ctor() { }

}

// Namespace: 
private class ValuesTranslate
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18716A0
	public override System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean> get_SameFunc() { }

	// RVA: 0x18716A8
	private static bool IsSame(Translate a, Translate b) { }

	// RVA: 0x1871714
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, Translate a, Translate b) { }

	// RVA: 0x1871738
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1871824
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18718F8
	private static Translate Lerp(Translate a, Translate b, float t) { }

	// RVA: 0x1871978
	protected sealed override void UpdateValues() { }

	// RVA: 0x1871A70
	public void .ctor() { }

}

// Namespace: 
private class ValuesTransformOrigin
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x1871B20
	public override System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean> get_SameFunc() { }

	// RVA: 0x1871B28
	private static bool IsSame(TransformOrigin a, TransformOrigin b) { }

	// RVA: 0x1871B7C
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, TransformOrigin a, TransformOrigin b) { }

	// RVA: 0x1871BA0
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1871C8C
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x1871D60
	private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) { }

	// RVA: 0x1871DDC
	protected sealed override void UpdateValues() { }

	// RVA: 0x1871EC8
	public void .ctor() { }

}

// Namespace: 
private class ValuesBackgroundPosition
{
	// Methods

	// RVA: 0x1871F78
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1872064
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x1872120
	public void .ctor() { }

}

// Namespace: 
private class ValuesBackgroundRepeat
{
	// Methods

	// RVA: 0x1872174
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x1872244
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18722F8
	public void .ctor() { }

}

// Namespace: 
private class ValuesBackgroundSize
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.BackgroundSize,UnityEngine.UIElements.BackgroundSize,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x187234C
	public override System.Func<UnityEngine.UIElements.BackgroundSize,UnityEngine.UIElements.BackgroundSize,System.Boolean> get_SameFunc() { }

	// RVA: 0x1872354
	private static bool IsSame(BackgroundSize a, BackgroundSize b) { }

	// RVA: 0x187239C
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, BackgroundSize a, BackgroundSize b) { }

	// RVA: 0x18723C0
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18724AC
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x1872580
	private static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t) { }

	// RVA: 0x1872670
	protected sealed override void UpdateValues() { }

	// RVA: 0x1872828
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class StylePropertyAnimationSystem
{
	// Fields
	private Int64 m_CurrentTimeMs; // 0x10
	private ValuesFloat m_Floats; // 0x18
	private ValuesInt m_Ints; // 0x20
	private ValuesLength m_Lengths; // 0x28
	private ValuesColor m_Colors; // 0x30
	private ValuesBackground m_Backgrounds; // 0x38
	private ValuesFontDefinition m_FontDefinitions; // 0x40
	private ValuesFont m_Fonts; // 0x48
	private ValuesTextShadow m_TextShadows; // 0x50
	private ValuesScale m_Scale; // 0x58
	private ValuesRotate m_Rotate; // 0x60
	private ValuesTranslate m_Translate; // 0x68
	private ValuesTransformOrigin m_TransformOrigin; // 0x70
	private ValuesBackgroundPosition m_BackgroundPosition; // 0x78
	private ValuesBackgroundRepeat m_BackgroundRepeat; // 0x80
	private ValuesBackgroundSize m_BackgroundSize; // 0x88
	private readonly System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyAnimationSystem.Values> m_AllValues; // 0x90
	private readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId,UnityEngine.UIElements.StylePropertyAnimationSystem.Values> m_PropertyToValues; // 0x98

	// Methods

	// RVA: 0x186D934
	public void .ctor() { }

	// RVA: 0x315B3A8
	private T GetOrCreate(T values) { }

	// RVA: 0x315B3A8
	private bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve, UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values) { }

	// RVA: 0x186DA54
	public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186DB44
	public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186DC2C
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186DD10
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186DE38
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186DF38
	public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E030
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E110
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E230
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E328
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E448
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E568
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E688
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E788
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E86C
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186E98C
	public void CancelAllAnimations() { }

	// RVA: 0x186EB50
	public void CancelAllAnimations(VisualElement owner) { }

	// RVA: 0x186EE84
	public void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x186EF24
	public void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x186EFC4
	public void GetAllAnimations(VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds) { }

	// RVA: 0x30A27C0
	private void UpdateTracking(UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values) { }

	// RVA: 0x186F1A8
	private Int64 CurrentTimeMs() { }

	// RVA: 0x186F1B0
	public void Update() { }

}

// Namespace: UnityEngine.UIElements
public struct StylePropertyName
{
	// Fields
	private readonly StylePropertyId <id>k__BackingField; // 0x10
	private readonly string <name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x18728D8
	internal StylePropertyId get_id() { }

	// RVA: 0x18728E0
	private string get_name() { }

	// RVA: 0x18728E8
	internal static StylePropertyId StylePropertyIdFromString(string name) { }

	// RVA: 0x18729B0
	internal void .ctor(StylePropertyId stylePropertyId) { }

	// RVA: 0x1872A80
	public void .ctor(string name) { }

	// RVA: 0x1872B7C
	public static bool op_Equality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x1872B88
	public static bool op_Inequality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x1872B94
	public static StylePropertyName op_Implicit(string name) { }

	// RVA: 0x1872BC0
	public override int GetHashCode() { }

	// RVA: 0x1872BC8
	public override bool Equals(object other) { }

	// RVA: 0x1872C58
	public bool Equals(StylePropertyName other) { }

	// RVA: 0x1872C68
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
internal enum Salt
{
	// Fields
	public int value__; // 0x10
	public const Salt TagNameSalt = 13;
	public const Salt IdSalt = 17;
	public const Salt ClassSalt = 19;
}

// Namespace: 
public struct <hashes>e__FixedBuffer
{
	// Fields
	public int FixedElementField; // 0x10
}

// Namespace: UnityEngine.UIElements
internal struct Hashes
{
	// Fields
	public const int kSize = 4;
	public UnityEngine.UIElements.Hashes.<hashes>e__FixedBuffer hashes; // 0x10
}

// Namespace: 
private struct PseudoStateData
{
	// Fields
	public readonly PseudoStates state; // 0x10
	public readonly bool negate; // 0x14

	// Methods

	// RVA: 0x1873268
	public void .ctor(PseudoStates state, bool negate) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.StyleComplexSelector.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.StyleSelector,System.String> <>9__24_0; // 0x8
	public static System.Predicate<UnityEngine.UIElements.StyleSelectorPart> <>9__27_0; // 0x10

	// Methods

	// RVA: 0x1873A48
	private static void .cctor() { }

	// RVA: 0x1873AB4
	public void .ctor() { }

	// RVA: 0x1873ABC
	internal string <ToString>b__24_0(StyleSelector x) { }

	// RVA: 0x1873AE4
	internal bool <CalculateHashes>b__27_0(StyleSelectorPart p) { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class StyleComplexSelector
{
	// Fields
	public Hashes ancestorHashes; // 0x10
	private int m_Specificity; // 0x20
	private StyleRule <rule>k__BackingField; // 0x28
	private bool m_isSimple; // 0x30
	private StyleSelector[] m_Selectors; // 0x38
	internal int ruleIndex; // 0x40
	internal StyleComplexSelector nextInTable; // 0x48
	internal int orderInStyleSheet; // 0x50
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector.PseudoStateData> s_PseudoStates; // 0x0
	private static System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> m_HashList; // 0x8

	// Methods

	// RVA: 0x1872C70
	public int get_specificity() { }

	// RVA: 0x1872C78
	public StyleRule get_rule() { }

	// RVA: 0x1872C80
	internal void set_rule(StyleRule value) { }

	// RVA: 0x1872C88
	public bool get_isSimple() { }

	// RVA: 0x1872C90
	public StyleSelector[] get_selectors() { }

	// RVA: 0x1872C98
	internal void set_selectors(StyleSelector[] value) { }

	// RVA: 0x1872CE0
	public void OnBeforeSerialize() { }

	// RVA: 0x1872CE4
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x1872D10
	internal void CachePseudoStateMasks() { }

	// RVA: 0x187328C
	public override string ToString() { }

	// RVA: 0x1873408
	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	// RVA: 0x187345C
	internal void CalculateHashes() { }

	// RVA: 0x18739AC
	public void .ctor() { }

	// RVA: 0x18739B4
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class StyleProperty
{
	// Fields
	private string m_Name; // 0x10
	private int m_Line; // 0x18
	private StyleValueHandle[] m_Values; // 0x20
	internal bool isCustomProperty; // 0x28
	internal bool requireVariableResolve; // 0x29

	// Methods

	// RVA: 0x1873AFC
	public string get_name() { }

	// RVA: 0x1873B04
	public StyleValueHandle[] get_values() { }

	// RVA: 0x1873B0C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class StyleRule
{
	// Fields
	private StyleProperty[] m_Properties; // 0x10
	internal int line; // 0x18
	internal int customPropertiesCount; // 0x1C

	// Methods

	// RVA: 0x1873B14
	public StyleProperty[] get_properties() { }

	// RVA: 0x1873B1C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.StyleSelector.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.StyleSelectorPart,System.String> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x1873CA0
	private static void .cctor() { }

	// RVA: 0x1873D0C
	public void .ctor() { }

	// RVA: 0x1873D14
	internal string <ToString>b__10_0(StyleSelectorPart p) { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class StyleSelector
{
	// Fields
	private StyleSelectorPart[] m_Parts; // 0x10
	private StyleSelectorRelationship m_PreviousRelationship; // 0x18
	internal int pseudoStateMask; // 0x1C
	internal int negatedPseudoStateMask; // 0x20

	// Methods

	// RVA: 0x1873274
	public StyleSelectorPart[] get_parts() { }

	// RVA: 0x1873B24
	internal void set_parts(StyleSelectorPart[] value) { }

	// RVA: 0x1873B2C
	public StyleSelectorRelationship get_previousRelationship() { }

	// RVA: 0x1873B34
	internal void set_previousRelationship(StyleSelectorRelationship value) { }

	// RVA: 0x1873B3C
	public override string ToString() { }

	// RVA: 0x1873C90
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
internal struct StyleSelectorPart
{
	// Fields
	private string m_Value; // 0x10
	private StyleSelectorType m_Type; // 0x18
	internal object tempData; // 0x20

	// Methods

	// RVA: 0x1873284
	public string get_value() { }

	// RVA: 0x187327C
	public StyleSelectorType get_type() { }

	// RVA: 0x1873E50
	internal void set_type(StyleSelectorType value) { }

	// RVA: 0x1873D1C
	public override string ToString() { }

	// RVA: 0x1873E58
	public static StyleSelectorPart CreateClass(string className) { }

	// RVA: 0x1873EA8
	public static StyleSelectorPart CreateId(string Id) { }

	// RVA: 0x1873EF8
	public static StyleSelectorPart CreatePredicate(object predicate) { }

}

// Namespace: UnityEngine.UIElements
internal enum StyleSelectorRelationship
{
	// Fields
	public int value__; // 0x10
	public const StyleSelectorRelationship None = 0;
	public const StyleSelectorRelationship Child = 1;
	public const StyleSelectorRelationship Descendent = 2;
}

// Namespace: UnityEngine.UIElements
internal enum StyleSelectorType
{
	// Fields
	public int value__; // 0x10
	public const StyleSelectorType Unknown = 0;
	public const StyleSelectorType Wildcard = 1;
	public const StyleSelectorType Type = 2;
	public const StyleSelectorType Class = 3;
	public const StyleSelectorType PseudoClass = 4;
	public const StyleSelectorType RecursivePseudoClass = 5;
	public const StyleSelectorType ID = 6;
	public const StyleSelectorType Predicate = 7;
}

// Namespace: 
[Serializable]
internal struct ImportStruct
{
	// Fields
	public StyleSheet styleSheet; // 0x10
	public string[] mediaQueries; // 0x18
}

// Namespace: UnityEngine.UIElements
[Serializable]
public class StyleSheet
{
	// Fields
	private bool m_ImportedWithErrors; // 0x18
	private bool m_ImportedWithWarnings; // 0x19
	private StyleRule[] m_Rules; // 0x20
	private StyleComplexSelector[] m_ComplexSelectors; // 0x28
	internal float[] floats; // 0x30
	internal Dimension[] dimensions; // 0x38
	internal Color[] colors; // 0x40
	internal string[] strings; // 0x48
	internal object[] assets; // 0x50
	internal ImportStruct[] imports; // 0x58
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_FlattenedImportedStyleSheets; // 0x60
	private int m_ContentHash; // 0x68
	internal ScalableImage[] scalableImages; // 0x70
	internal System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> orderedNameSelectors; // 0x78
	internal System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> orderedTypeSelectors; // 0x80
	internal System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> orderedClassSelectors; // 0x88
	private bool m_IsDefaultStyleSheet; // 0x90
	private static string kCustomPropertyMarker; // 0x0

	// Methods

	// RVA: 0x1873F4C
	public bool get_importedWithErrors() { }

	// RVA: 0x1873F54
	internal void set_importedWithErrors(bool value) { }

	// RVA: 0x1873F5C
	public bool get_importedWithWarnings() { }

	// RVA: 0x1873F64
	internal void set_importedWithWarnings(bool value) { }

	// RVA: 0x1873F6C
	internal StyleRule[] get_rules() { }

	// RVA: 0x1873F74
	internal void set_rules(StyleRule[] value) { }

	// RVA: 0x18745EC
	internal StyleComplexSelector[] get_complexSelectors() { }

	// RVA: 0x18745F4
	internal void set_complexSelectors(StyleComplexSelector[] value) { }

	// RVA: 0x187461C
	internal System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_flattenedRecursiveImports() { }

	// RVA: 0x1874624
	public int get_contentHash() { }

	// RVA: 0x187462C
	public void set_contentHash(int value) { }

	// RVA: 0x1874634
	internal bool get_isDefaultStyleSheet() { }

	// RVA: 0x187463C
	internal void set_isDefaultStyleSheet(bool value) { }

	// RVA: 0x315B3A8
	private bool TryCheckAccess(T[] list, StyleValueType type, StyleValueHandle handle, T value) { }

	// RVA: 0x315B3A8
	private T CheckAccess(T[] list, StyleValueType type, StyleValueHandle handle) { }

	// RVA: 0x1874810
	internal virtual void OnEnable() { }

	// RVA: 0x1874814
	internal void FlattenImportedStyleSheetsRecursive() { }

	// RVA: 0x18748A0
	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	// RVA: 0x1873F9C
	private void SetupReferences() { }

	// RVA: 0x1874A94
	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	// RVA: 0x1874A9C
	internal float ReadFloat(StyleValueHandle handle) { }

	// RVA: 0x1874B6C
	internal bool TryReadFloat(StyleValueHandle handle, float value) { }

	// RVA: 0x1874C48
	internal Dimension ReadDimension(StyleValueHandle handle) { }

	// RVA: 0x1874D28
	internal bool TryReadDimension(StyleValueHandle handle, Dimension value) { }

	// RVA: 0x1874E10
	internal Color ReadColor(StyleValueHandle handle) { }

	// RVA: 0x1874E8C
	internal bool TryReadColor(StyleValueHandle handle, Color value) { }

	// RVA: 0x1874F00
	internal string ReadString(StyleValueHandle handle) { }

	// RVA: 0x1874F78
	internal bool TryReadString(StyleValueHandle handle, string value) { }

	// RVA: 0x1874FEC
	internal string ReadEnum(StyleValueHandle handle) { }

	// RVA: 0x1875064
	internal bool TryReadEnum(StyleValueHandle handle, string value) { }

	// RVA: 0x18750D8
	internal string ReadVariable(StyleValueHandle handle) { }

	// RVA: 0x1875150
	internal bool TryReadVariable(StyleValueHandle handle, string value) { }

	// RVA: 0x18751C4
	internal string ReadResourcePath(StyleValueHandle handle) { }

	// RVA: 0x187523C
	internal bool TryReadResourcePath(StyleValueHandle handle, string value) { }

	// RVA: 0x18752B0
	internal object ReadAssetReference(StyleValueHandle handle) { }

	// RVA: 0x1875328
	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	// RVA: 0x18753A0
	internal bool TryReadAssetReference(StyleValueHandle handle, object value) { }

	// RVA: 0x1875414
	internal StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	// RVA: 0x187541C
	internal string ReadFunctionName(StyleValueHandle handle) { }

	// RVA: 0x18756D8
	internal ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	// RVA: 0x18749C0
	private static bool CustomStartsWith(string originalString, string pattern) { }

	// RVA: 0x1875750
	public void .ctor() { }

	// RVA: 0x1875758
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal enum StyleValueFunction
{
	// Fields
	public int value__; // 0x10
	public const StyleValueFunction Unknown = 0;
	public const StyleValueFunction Var = 1;
	public const StyleValueFunction Env = 2;
	public const StyleValueFunction LinearGradient = 3;
}

// Namespace: UnityEngine.UIElements
internal static class StyleValueFunctionExtension
{
	// Methods

	// RVA: 0x18755DC
	public static string ToUssString(StyleValueFunction svf) { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
internal struct StyleValueHandle
{
	// Fields
	private StyleValueType m_ValueType; // 0x10
	internal int valueIndex; // 0x14

	// Methods

	// RVA: 0x1874B64
	public StyleValueType get_valueType() { }

	// RVA: 0x18757D0
	internal void set_valueType(StyleValueType value) { }

}

// Namespace: UnityEngine.UIElements
internal enum StyleValueKeyword
{
	// Fields
	public int value__; // 0x10
	public const StyleValueKeyword Inherit = 0;
	public const StyleValueKeyword Initial = 1;
	public const StyleValueKeyword Auto = 2;
	public const StyleValueKeyword Unset = 3;
	public const StyleValueKeyword True = 4;
	public const StyleValueKeyword False = 5;
	public const StyleValueKeyword None = 6;
}

// Namespace: UnityEngine.UIElements
internal static class StyleValueKeywordExtension
{
	// Methods

	// RVA: 0x18757D8
	public static string ToUssString(StyleValueKeyword svk) { }

}

// Namespace: UnityEngine.UIElements
internal enum StyleValueType
{
	// Fields
	public int value__; // 0x10
	public const StyleValueType Invalid = 0;
	public const StyleValueType Keyword = 1;
	public const StyleValueType Float = 2;
	public const StyleValueType Dimension = 3;
	public const StyleValueType Color = 4;
	public const StyleValueType ResourcePath = 5;
	public const StyleValueType AssetReference = 6;
	public const StyleValueType Enum = 7;
	public const StyleValueType Variable = 8;
	public const StyleValueType String = 9;
	public const StyleValueType Function = 10;
	public const StyleValueType CommaSeparator = 11;
	public const StyleValueType ScalableImage = 12;
	public const StyleValueType MissingAssetReference = 13;
}

// Namespace: UnityEngine.UIElements
internal struct StyleVariable
{
	// Fields
	public readonly string name; // 0x10
	public readonly StyleSheet sheet; // 0x18
	public readonly StyleValueHandle[] handles; // 0x20

	// Methods

	// RVA: 0x1875900
	public void .ctor(string name, StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x1875950
	public override int GetHashCode() { }

}

// Namespace: 
private struct <>c__DisplayClass7_0
{
	// Fields
	public int hash; // 0x10
}

// Namespace: UnityEngine.UIElements
internal class StyleVariableContext
{
	// Fields
	public static readonly StyleVariableContext none; // 0x0
	private int m_VariableHash; // 0x10
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleVariable> m_Variables; // 0x18
	private System.Collections.Generic.List<System.Int32> m_SortedHash; // 0x20
	private System.Collections.Generic.List<System.Int32> m_UnsortedHash; // 0x28

	// Methods

	// RVA: 0x18759C8
	public void Add(StyleVariable sv) { }

	// RVA: 0x1875CA0
	public void AddInitialRange(StyleVariableContext other) { }

	// RVA: 0x1875DBC
	public void Clear() { }

	// RVA: 0x1875F40
	public void .ctor() { }

	// RVA: 0x1876048
	public void .ctor(StyleVariableContext other) { }

	// RVA: 0x1876180
	public bool TryFindVariable(string name, StyleVariable v) { }

	// RVA: 0x187627C
	public int GetVariableHash() { }

	// RVA: 0x1876284
	private static void .cctor() { }

	// RVA: 0x1875C94
	internal static int <Add>g__ComputeOrderSensitiveHash|7_0(int index, UnityEngine.UIElements.StyleVariableContext.<>c__DisplayClass7_0& ) { }

}

// Namespace: 
private enum Result
{
	// Fields
	public int value__; // 0x10
	public const Result Valid = 0;
	public const Result Invalid = 1;
	public const Result NotFound = 2;
}

// Namespace: 
private struct ResolveContext
{
	// Fields
	public StyleSheet sheet; // 0x10
	public StyleValueHandle[] handles; // 0x18
}

// Namespace: UnityEngine.UIElements
internal class StyleVariableResolver
{
	// Fields
	internal const int kMaxResolves = 100;
	private static StyleSyntaxParser s_SyntaxParser; // 0x0
	private StylePropertyValueMatcher m_Matcher; // 0x10
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_ResolvedValues; // 0x18
	private System.Collections.Generic.Stack<System.String> m_ResolvedVarStack; // 0x20
	private StyleProperty m_Property; // 0x28
	private System.Collections.Generic.Stack<UnityEngine.UIElements.StyleVariableResolver.ResolveContext> m_ContextStack; // 0x30
	private ResolveContext m_CurrentContext; // 0x38
	private StyleVariableContext <variableContext>k__BackingField; // 0x48

	// Methods

	// RVA: 0x18762EC
	private StyleSheet get_currentSheet() { }

	// RVA: 0x18762F4
	private StyleValueHandle[] get_currentHandles() { }

	// RVA: 0x18762FC
	public System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> get_resolvedValues() { }

	// RVA: 0x1876304
	public StyleVariableContext get_variableContext() { }

	// RVA: 0x187630C
	public void set_variableContext(StyleVariableContext value) { }

	// RVA: 0x1876314
	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x187640C
	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x18764C8
	private void PopContext() { }

	// RVA: 0x1876568
	public void AddValue(StyleValueHandle handle) { }

	// RVA: 0x18765F8
	public bool ResolveVarFunction(int index) { }

	// RVA: 0x1876864
	private Result ResolveVarFunction(int index, int argc, string varName) { }

	// RVA: 0x1876EB8
	public bool ValidateResolvedValues() { }

	// RVA: 0x18769F4
	private Result ResolveVariable(string variableName) { }

	// RVA: 0x1876C58
	private Result ResolveFallback(int index) { }

	// RVA: 0x18766D0
	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, int index, int argCount, string variableName) { }

	// RVA: 0x1877048
	public void .ctor() { }

	// RVA: 0x18771BC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
public class ThemeStyleSheet
{
	// Methods

	// RVA: 0x1877244
	internal override void OnEnable() { }

	// RVA: 0x187726C
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x18773B8
	public override string get_uxmlName() { }

	// RVA: 0x18773FC
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x187747C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Template; // 0x78

	// Methods

	// RVA: 0x18774D0
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1877948
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class TemplateContainer
{
	// Fields
	private string <templateId>k__BackingField; // 0x3D8
	private VisualElement m_ContentContainer; // 0x3E0
	private VisualTreeAsset m_TemplateSource; // 0x3E8

	// Methods

	// RVA: 0x18772F4
	public string get_templateId() { }

	// RVA: 0x18772FC
	private void set_templateId(string value) { }

	// RVA: 0x187730C
	internal void set_templateSource(VisualTreeAsset value) { }

	// RVA: 0x187731C
	public void .ctor() { }

	// RVA: 0x187735C
	public void .ctor(string templateId) { }

	// RVA: 0x18773A0
	public override VisualElement get_contentContainer() { }

	// RVA: 0x18773A8
	internal void SetContentContainer(VisualElement content) { }

}

// Namespace: UnityEngine.UIElements
public class PanelTextSettings
{
	// Fields
	private static PanelTextSettings s_DefaultPanelTextSettings; // 0x0
	internal static System.Func<System.String,UnityEngine.Object> EditorGUIUtilityLoad; // 0x8
	internal static System.Func<UnityEngine.SystemLanguage> GetCurrentLanguage; // 0x10
	internal static readonly string s_DefaultEditorPanelTextSettingPath; // 0x18

	// Methods

	// RVA: 0x18779F4
	internal static PanelTextSettings get_defaultPanelTextSettings() { }

	// RVA: 0x1877BC4
	internal static void UpdateLocalizationFontAsset() { }

	// RVA: 0x1878258
	internal FontAsset GetCachedFontAsset(Font font) { }

	// RVA: 0x1878260
	public void .ctor() { }

	// RVA: 0x1878268
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class TextEditingManipulator
{
	// Fields
	private TextElement m_TextElement; // 0x10
	internal TextEditorEventHandler editingEventHandler; // 0x18
	internal TextEditingUtilities editingUtilities; // 0x20
	private bool m_TouchScreenTextFieldInitialized; // 0x28
	private IVisualElementScheduledItem m_HardwareKeyboardPoller; // 0x30

	// Methods

	// RVA: 0x18782D4
	private bool get_touchScreenTextFieldChanged() { }

	// RVA: 0x1878474
	public void .ctor(TextElement textElement) { }

	// RVA: 0x1878564
	private void InitTextEditorEventHandler() { }

	// RVA: 0x1878638
	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x18787CC
	private void OnFocusInEvent(FocusInEvent _) { }

	// RVA: 0x1878AC8
	private void OnFocusOutEvent(FocusOutEvent _) { }

	// RVA: 0x1878B80
	private void <OnFocusInEvent>b__10_0() { }

}

// Namespace: UnityEngine.UIElements
internal class TextSelectingManipulator
{
	// Fields
	internal TextSelectingUtilities m_SelectingUtilities; // 0x10
	private bool selectAllOnMouseUp; // 0x18
	private TextElement m_TextElement; // 0x20
	private Vector2 m_ClickStartPosition; // 0x28
	private bool m_Dragged; // 0x30
	private bool m_IsClicking; // 0x31
	private const int k_DragThresholdSqr = 16;
	private int m_ConsecutiveMouseDownCount; // 0x34
	private Int64 m_LastMouseDownTimeStamp; // 0x38
	private readonly Event m_ImguiEvent; // 0x40

	// Methods

	// RVA: 0x1878BD0
	internal bool get_isClicking() { }

	// RVA: 0x1878BD8
	internal void set_isClicking(bool value) { }

	// RVA: 0x1878BEC
	public void .ctor(TextElement textElement) { }

	// RVA: 0x1878EB4
	internal int get_cursorIndex() { }

	// RVA: 0x1878ECC
	internal void set_cursorIndex(int value) { }

	// RVA: 0x1878EEC
	internal int get_selectIndex() { }

	// RVA: 0x1878F04
	internal void set_selectIndex(int value) { }

	// RVA: 0x1878F24
	private void OnRevealCursor() { }

	// RVA: 0x1878F48
	private void OnSelectIndexChange() { }

	// RVA: 0x18790D8
	private void OnCursorIndexChange() { }

	// RVA: 0x1879248
	internal bool RevealCursor() { }

	// RVA: 0x18790B8
	internal bool HasSelection() { }

	// RVA: 0x1879268
	internal bool HasFocus() { }

	// RVA: 0x1879288
	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x1879500
	private void OnFocusEvent(FocusEvent evt) { }

	// RVA: 0x18797BC
	private void OnBlurEvent(BlurEvent evt) { }

	// RVA: 0x1879CE8
	private void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x187987C
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x1879D60
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x1879FB4
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x187A080
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	// RVA: 0x187A214
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	// RVA: 0x187A354
	private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) { }

}

// Namespace: UnityEngine.UIElements
internal class UITKTextHandle
{
	// Fields
	private Vector2 <MeasuredSizes>k__BackingField; // 0x34
	private Vector2 <RoundedSizes>k__BackingField; // 0x3C
	private TextElement m_TextElement; // 0x48
	internal bool isOverridingCursor; // 0x50
	internal int currentLinkIDHash; // 0x54
	internal bool hasLinkTag; // 0x58
	internal bool hasATag; // 0x59
	internal static readonly float k_MinPadding; // 0x0

	// Methods

	// RVA: 0x187A378
	public void .ctor(TextElement te) { }

	// RVA: 0x187A400
	public Vector2 get_MeasuredSizes() { }

	// RVA: 0x187A408
	public void set_MeasuredSizes(Vector2 value) { }

	// RVA: 0x187A410
	public Vector2 get_RoundedSizes() { }

	// RVA: 0x187A418
	public void set_RoundedSizes(Vector2 value) { }

	// RVA: 0x187A420
	public float ComputeTextWidth(string textToMeasure, bool wordWrap, float width, float height) { }

	// RVA: 0x187A874
	public float ComputeTextHeight(string textToMeasure, float width, float height) { }

	// RVA: 0x187A938
	public TextInfo Update() { }

	// RVA: 0x187B3C8
	private void ATagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x187B55C
	private void ATagOnPointerOver(PointerOverEvent _) { }

	// RVA: 0x187B564
	private void ATagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x187B818
	private void ATagOnPointerOut(PointerOutEvent _) { }

	// RVA: 0x187B820
	internal void LinkTagOnPointerDown(PointerDownEvent pde) { }

	// RVA: 0x187BABC
	internal void LinkTagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x187BD58
	internal void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x187C2AC
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	// RVA: 0x187AFB4
	private void HandleLinkTag() { }

	// RVA: 0x187AA44
	private void HandleATag() { }

	// RVA: 0x187C484
	private TextOverflowMode GetTextOverflowMode() { }

	// RVA: 0x187A4F4
	internal void ConvertUssToTextGenerationSettings(TextGenerationSettings tgs) { }

	// RVA: 0x187C548
	internal bool TextLibraryCanElide() { }

	// RVA: 0x187C57C
	internal float GetTextEffectPadding(FontAsset fontAsset) { }

	// RVA: 0x187C728
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class TextUtilities
{
	// Methods

	// RVA: 0x173B5F8
	internal static Vector2 MeasureVisualElementTextSize(TextElement te, string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	// RVA: 0x173B858
	internal static FontAsset GetFontAsset(VisualElement ve) { }

	// RVA: 0x173B76C
	internal static bool IsFontAssigned(VisualElement ve) { }

	// RVA: 0x173BA2C
	internal static PanelTextSettings GetTextSettingsFrom(VisualElement ve) { }

	// RVA: 0x173BB08
	internal static float ConvertPixelUnitsToTextCoreRelativeUnits(VisualElement ve, FontAsset fontAsset) { }

	// RVA: 0x173BBC4
	internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1740CBC
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x78
	private UxmlBoolAttributeDescription m_EnableRichText; // 0x80
	private UxmlBoolAttributeDescription m_ParseEscapeSequences; // 0x88
	private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided; // 0x90

	// Methods

	// RVA: 0x1740D10
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1740EEC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class TextElement
{
	// Fields
	public static readonly string ussClassName; // 0x0
	private UITKTextHandle <uitkTextHandle>k__BackingField; // 0x3D8
	private string m_Text; // 0x3E0
	private bool m_EnableRichText; // 0x3E8
	private bool m_ParseEscapeSequences; // 0x3E9
	private bool m_DisplayTooltipWhenElided; // 0x3EA
	private bool <isElided>k__BackingField; // 0x3EB
	internal static readonly string k_EllipsisText; // 0x8
	internal string elidedText; // 0x3F0
	private bool m_WasElided; // 0x3F8
	internal TextEditingManipulator editingManipulator; // 0x400
	private bool m_Multiline; // 0x408
	internal TouchScreenKeyboard m_TouchScreenKeyboard; // 0x410
	internal TouchScreenKeyboardType m_KeyboardType; // 0x418
	private bool m_HideMobileInput; // 0x41C
	private bool m_IsReadOnly; // 0x41D
	private int m_MaxLength; // 0x420
	private bool <UnityEngine.UIElements.ITextEdition.isDelayed>k__BackingField; // 0x424
	private System.Func<System.Char,System.Boolean> <UnityEngine.UIElements.ITextEdition.AcceptCharacter>k__BackingField; // 0x428
	private System.Action<System.Boolean> <UnityEngine.UIElements.ITextEdition.UpdateScrollOffset>k__BackingField; // 0x430
	private Action <UnityEngine.UIElements.ITextEdition.UpdateValueFromText>k__BackingField; // 0x438
	private Action <UnityEngine.UIElements.ITextEdition.UpdateTextFromValue>k__BackingField; // 0x440
	private Action <UnityEngine.UIElements.ITextEdition.MoveFocusToCompositeRoot>k__BackingField; // 0x448
	private string m_RenderedText; // 0x450
	private string m_OriginalText; // 0x458
	private Char m_MaskChar; // 0x460
	private bool m_IsPassword; // 0x462
	private bool m_AutoCorrection; // 0x463
	private TextSelectingManipulator m_SelectingManipulator; // 0x468
	private bool m_IsSelectable; // 0x470
	private bool <UnityEngine.UIElements.ITextSelection.doubleClickSelectsWord>k__BackingField; // 0x471
	private bool <UnityEngine.UIElements.ITextSelection.tripleClickSelectsLine>k__BackingField; // 0x472
	private bool <UnityEngine.UIElements.ITextSelection.selectAllOnFocus>k__BackingField; // 0x473
	private bool <UnityEngine.UIElements.ITextSelection.selectAllOnMouseUp>k__BackingField; // 0x474
	private Color m_SelectionColor; // 0x478
	private Color m_CursorColor; // 0x488
	private float m_CursorWidth; // 0x498

	// Methods

	// RVA: 0x173BFD0
	public void .ctor() { }

	// RVA: 0x173C224
	internal UITKTextHandle get_uitkTextHandle() { }

	// RVA: 0x173C22C
	internal void set_uitkTextHandle(UITKTextHandle value) { }

	// RVA: 0x173C23C
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x173C398
	public virtual string get_text() { }

	// RVA: 0x173C44C
	public virtual void set_text(string value) { }

	// RVA: 0x173C4F8
	public bool get_enableRichText() { }

	// RVA: 0x173C500
	public void set_enableRichText(bool value) { }

	// RVA: 0x173C51C
	public bool get_parseEscapeSequences() { }

	// RVA: 0x173C524
	public void set_parseEscapeSequences(bool value) { }

	// RVA: 0x173C540
	public bool get_displayTooltipWhenElided() { }

	// RVA: 0x173C548
	public void set_displayTooltipWhenElided(bool value) { }

	// RVA: 0x173C58C
	public bool get_isElided() { }

	// RVA: 0x173C594
	private void set_isElided(bool value) { }

	// RVA: 0x173C59C
	internal void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x173D984
	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	// RVA: 0x173C9A4
	private void UpdateTooltip() { }

	// RVA: 0x173C240
	private void UpdateVisibleText() { }

	// RVA: 0x173C944
	private bool ShouldElide() { }

	// RVA: 0x173DE94
	internal bool get_hasFocus() { }

	// RVA: 0x173DE90
	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	// RVA: 0x173DEDC
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x173E15C
	private string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	// RVA: 0x173E1C8
	private void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	// RVA: 0x173E490
	private void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	// RVA: 0x173D590
	internal ITextEdition get_edition() { }

	// RVA: 0x173E684
	private bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	// RVA: 0x173E68C
	private void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	// RVA: 0x173E774
	private TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	// RVA: 0x173E77C
	private void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x173E784
	private bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	// RVA: 0x173E850
	private void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	// RVA: 0x173E918
	private bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	// RVA: 0x173E948
	private void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	// RVA: 0x173E9F8
	private void ProcessMenuCommand(string command) { }

	// RVA: 0x173EB68
	private void Cut(DropdownMenuAction a) { }

	// RVA: 0x173EBBC
	private void Copy(DropdownMenuAction a) { }

	// RVA: 0x173EC10
	private void Paste(DropdownMenuAction a) { }

	// RVA: 0x173EC64
	private void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x173EFF4
	private Status CutActionStatus(DropdownMenuAction a) { }

	// RVA: 0x173F148
	private Status CopyActionStatus(DropdownMenuAction a) { }

	// RVA: 0x173F2A0
	private Status PasteActionStatus(DropdownMenuAction a) { }

	// RVA: 0x173F300
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x173F7D8
	private int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	// RVA: 0x173F7E0
	private void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	// RVA: 0x173F8C0
	private bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	// RVA: 0x173F8C8
	private void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	// RVA: 0x173F8D0
	private void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	// RVA: 0x173F908
	private void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	// RVA: 0x173F91C
	private System.Func<System.Char,System.Boolean> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	// RVA: 0x173F924
	private void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(System.Func<System.Char,System.Boolean> value) { }

	// RVA: 0x173F934
	private System.Action<System.Boolean> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	// RVA: 0x173F93C
	private void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(System.Action<System.Boolean> value) { }

	// RVA: 0x173F94C
	private Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	// RVA: 0x173F954
	private void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	// RVA: 0x173F964
	private Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	// RVA: 0x173F96C
	private void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	// RVA: 0x173F97C
	private Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	// RVA: 0x173F984
	private void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	// RVA: 0x173F994
	private void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	// RVA: 0x173FC2C
	private string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	// RVA: 0x173FD28
	private void UnityEngine.UIElements.ITextEdition.set_maskChar(Char value) { }

	// RVA: 0x173FE10
	private Char get_effectiveMaskChar() { }

	// RVA: 0x173FED0
	private bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	// RVA: 0x173FED8
	private void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	// RVA: 0x173FEF8
	private bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	// RVA: 0x173FF00
	private void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	// RVA: 0x173DF34
	internal string get_renderedText() { }

	// RVA: 0x173E618
	internal void set_renderedText(string value) { }

	// RVA: 0x173FF08
	internal string get_originalText() { }

	// RVA: 0x173CA24
	public ITextSelection get_selection() { }

	// RVA: 0x173FF10
	private bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	// RVA: 0x173FF30
	private void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	// RVA: 0x173FF48
	private int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	// RVA: 0x1740080
	private void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	// RVA: 0x17401BC
	private int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	// RVA: 0x17402F4
	private void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	// RVA: 0x1740430
	private void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	// RVA: 0x1740568
	private void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	// RVA: 0x17406A0
	private bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	// RVA: 0x17407D4
	private bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	// RVA: 0x17407DC
	private bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	// RVA: 0x17407E4
	private bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	// RVA: 0x17407EC
	private void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	// RVA: 0x17407F4
	private bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	// RVA: 0x17407FC
	private void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	// RVA: 0x1740804
	private Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	// RVA: 0x1740900
	private float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	// RVA: 0x17409CC
	private Color UnityEngine.UIElements.ITextSelection.get_selectionColor() { }

	// RVA: 0x17409E0
	private void UnityEngine.UIElements.ITextSelection.set_selectionColor(Color value) { }

	// RVA: 0x1740A4C
	private Color UnityEngine.UIElements.ITextSelection.get_cursorColor() { }

	// RVA: 0x1740A60
	private void UnityEngine.UIElements.ITextSelection.set_cursorColor(Color value) { }

	// RVA: 0x1740ACC
	private float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	// RVA: 0x173CA28
	internal TextSelectingManipulator get_selectingManipulator() { }

	// RVA: 0x173CAC8
	private void DrawHighlighting(MeshGenerationContext mgc) { }

	// RVA: 0x173D594
	internal void DrawCaret(MeshGenerationContext mgc) { }

	// RVA: 0x1740AD4
	private int GetLastCharacterAt(int lineIndex) { }

	// RVA: 0x1740C1C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface ITextEdition
{
	// Methods

	// RVA: -1
	internal abstract bool get_multiline() { }

	// RVA: -1
	internal abstract void set_multiline(bool value) { }

	// RVA: -1
	public abstract bool get_isReadOnly() { }

	// RVA: -1
	public abstract void set_isReadOnly(bool value) { }

	// RVA: -1
	public abstract int get_maxLength() { }

	// RVA: -1
	public abstract void set_maxLength(int value) { }

	// RVA: -1
	public abstract bool get_isDelayed() { }

	// RVA: -1
	public abstract void set_isDelayed(bool value) { }

	// RVA: -1
	internal abstract void SaveValueAndText() { }

	// RVA: -1
	internal abstract void RestoreValueAndText() { }

	// RVA: -1
	internal abstract System.Func<System.Char,System.Boolean> get_AcceptCharacter() { }

	// RVA: -1
	internal abstract void set_AcceptCharacter(System.Func<System.Char,System.Boolean> value) { }

	// RVA: -1
	internal abstract System.Action<System.Boolean> get_UpdateScrollOffset() { }

	// RVA: -1
	internal abstract void set_UpdateScrollOffset(System.Action<System.Boolean> value) { }

	// RVA: -1
	internal abstract Action get_UpdateValueFromText() { }

	// RVA: -1
	internal abstract void set_UpdateValueFromText(Action value) { }

	// RVA: -1
	internal abstract Action get_UpdateTextFromValue() { }

	// RVA: -1
	internal abstract void set_UpdateTextFromValue(Action value) { }

	// RVA: -1
	internal abstract Action get_MoveFocusToCompositeRoot() { }

	// RVA: -1
	internal abstract void set_MoveFocusToCompositeRoot(Action value) { }

	// RVA: -1
	internal abstract void UpdateText(string value) { }

	// RVA: -1
	internal abstract string CullString(string s) { }

	// RVA: -1
	public abstract void set_maskChar(Char value) { }

	// RVA: -1
	public abstract bool get_isPassword() { }

	// RVA: -1
	public abstract void set_isPassword(bool value) { }

	// RVA: 0x1741280
	public virtual bool get_autoCorrection() { }

	// RVA: 0x174134C
	public virtual void set_autoCorrection(bool value) { }

	// RVA: 0x1741428
	public virtual bool get_hideMobileInput() { }

	// RVA: 0x17414F4
	public virtual void set_hideMobileInput(bool value) { }

	// RVA: 0x17415D0
	public virtual TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x174169C
	public virtual void set_keyboardType(TouchScreenKeyboardType value) { }

}

// Namespace: UnityEngine.UIElements
public interface ITextSelection
{
	// Methods

	// RVA: -1
	public abstract bool get_isSelectable() { }

	// RVA: -1
	public abstract void set_isSelectable(bool value) { }

	// RVA: -1
	public abstract Color get_cursorColor() { }

	// RVA: -1
	public abstract void set_cursorColor(Color value) { }

	// RVA: -1
	public abstract int get_cursorIndex() { }

	// RVA: -1
	public abstract void set_cursorIndex(int value) { }

	// RVA: -1
	public abstract bool get_doubleClickSelectsWord() { }

	// RVA: -1
	public abstract int get_selectIndex() { }

	// RVA: -1
	public abstract void set_selectIndex(int value) { }

	// RVA: -1
	public abstract Color get_selectionColor() { }

	// RVA: -1
	public abstract void set_selectionColor(Color value) { }

	// RVA: -1
	public abstract bool get_tripleClickSelectsLine() { }

	// RVA: -1
	public abstract bool HasSelection() { }

	// RVA: -1
	public abstract void SelectAll() { }

	// RVA: -1
	public abstract void SelectNone() { }

	// RVA: -1
	internal abstract bool get_selectAllOnFocus() { }

	// RVA: -1
	internal abstract void set_selectAllOnFocus(bool value) { }

	// RVA: -1
	internal abstract bool get_selectAllOnMouseUp() { }

	// RVA: -1
	internal abstract void set_selectAllOnMouseUp(bool value) { }

	// RVA: -1
	public abstract Vector2 get_cursorPosition() { }

	// RVA: -1
	internal abstract float get_lineHeightAtCursorPosition() { }

	// RVA: -1
	internal abstract float get_cursorWidth() { }

}

// Namespace: UnityEngine.UIElements
public struct TextShadow
{
	// Fields
	public Vector2 offset; // 0x10
	public float blurRadius; // 0x18
	public Color color; // 0x1C

	// Methods

	// RVA: 0x1741778
	public override bool Equals(object obj) { }

	// RVA: 0x1741870
	public bool Equals(TextShadow other) { }

	// RVA: 0x17418F4
	public override int GetHashCode() { }

	// RVA: 0x17419D0
	public static bool op_Equality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x1741A54
	public static bool op_Inequality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x1741AD4
	public override string ToString() { }

	// RVA: 0x1741BC8
	internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class UIElementsBridge
{
	// Methods

	// RVA: -1
	public abstract void SetWantsMouseJumping(int value) { }

	// RVA: 0x1741C18
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class RuntimeUIElementsBridge
{
	// Methods

	// RVA: 0x1741C20
	public override void SetWantsMouseJumping(int value) { }

	// RVA: 0x1741C24
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIElementsPackageUtility
{
	// Fields
	private static bool <IsUIEPackageLoaded>k__BackingField; // 0x0
	private static string <EditorResourcesBasePath>k__BackingField; // 0x8

	// Methods

	// RVA: 0x1741C2C
	internal static bool get_IsUIEPackageLoaded() { }

	// RVA: 0x1741CA8
	private static void set_IsUIEPackageLoaded(bool value) { }

	// RVA: 0x1741D34
	internal static string get_EditorResourcesBasePath() { }

	// RVA: 0x1741DB0
	private static void set_EditorResourcesBasePath(string value) { }

	// RVA: 0x1741E1C
	private static void .cctor() { }

	// RVA: 0x1741E20
	internal static void Refresh() { }

}

// Namespace: 
public sealed class CreateRuntimePanelDelegate
{
	// Methods

	// RVA: 0x17455E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1745704
	public virtual BaseRuntimePanel Invoke(ScriptableObject ownerObject) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIElementsRuntimeUtility.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.UIElements.Panel> <>9__48_0; // 0x8

	// Methods

	// RVA: 0x1745718
	private static void .cctor() { }

	// RVA: 0x1745784
	public void .ctor() { }

	// RVA: 0x174578C
	internal void <.cctor>b__9_0() { }

	// RVA: 0x1745790
	internal void <.cctor>b__9_1(int displayIndex, int sortOrder) { }

	// RVA: 0x174581C
	internal int <SortPanels>b__48_0(Panel a, Panel b) { }

}

// Namespace: UnityEngine.UIElements
internal static class UIElementsRuntimeUtility
{
	// Fields
	private static System.Action<UnityEngine.UIElements.BaseRuntimePanel> onCreatePanel; // 0x0
	private static bool s_RegisteredPlayerloopCallback; // 0x8
	private static System.Collections.Generic.List<UnityEngine.UIElements.Panel> s_SortedRuntimePanels; // 0x10
	private static bool s_PanelOrderingDirty; // 0x18
	internal static int s_ResolvedSortingIndexMax; // 0x1C
	internal static readonly string s_RepaintProfilerMarkerName; // 0x20
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x28
	private static int currentOverlayIndex; // 0x30
	private static object <activeEventSystem>k__BackingField; // 0x38
	private static DefaultEventSystem s_DefaultEventSystem; // 0x40
	private static System.Collections.Generic.List<UnityEngine.UIElements.PanelSettings> s_PotentiallyEmptyPanelSettings; // 0x48

	// Methods

	// RVA: 0x1741F68
	public static void add_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value) { }

	// RVA: 0x1742078
	public static void remove_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value) { }

	// RVA: 0x1742188
	private static void .cctor() { }

	// RVA: 0x1742554
	public static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x174298C
	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate) { }

	// RVA: 0x17430C4
	public static void DisposeRuntimePanel(ScriptableObject ownerObject) { }

	// RVA: 0x1742EE0
	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) { }

	// RVA: 0x1742C74
	private static void RemoveCachedPanelInternal(int instanceID) { }

	// RVA: 0x1743878
	public static void RepaintOffscreenPanels() { }

	// RVA: 0x1743C0C
	public static void RepaintOverlayPanel(BaseRuntimePanel panel) { }

	// RVA: 0x1743D8C
	internal static void BeginRenderOverlays(int displayIndex) { }

	// RVA: 0x1743E08
	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) { }

	// RVA: 0x1744008
	internal static void EndRenderOverlays(int displayIndex) { }

	// RVA: 0x1744084
	internal static object get_activeEventSystem() { }

	// RVA: 0x1744100
	private static void set_activeEventSystem(object value) { }

	// RVA: 0x174416C
	internal static bool get_useDefaultEventSystem() { }

	// RVA: 0x1744280
	public static void RegisterEventSystem(object eventSystem) { }

	// RVA: 0x1744554
	public static void UnregisterEventSystem(object eventSystem) { }

	// RVA: 0x17446F4
	internal static DefaultEventSystem get_defaultEventSystem() { }

	// RVA: 0x17447CC
	public static void UpdateRuntimePanels() { }

	// RVA: 0x1744DA8
	internal static void MarkPotentiallyEmpty(PanelSettings settings) { }

	// RVA: 0x1744ACC
	internal static void RemoveUnusedPanels() { }

	// RVA: 0x17432E0
	public static void RegisterPlayerloopCallback() { }

	// RVA: 0x1743820
	public static void UnregisterPlayerloopCallback() { }

	// RVA: 0x1744EA4
	internal static void SetPanelOrderingDirty() { }

	// RVA: 0x1743B38
	internal static System.Collections.Generic.List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels() { }

	// RVA: 0x1744F28
	private static void SortPanels() { }

	// RVA: 0x1745250
	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, System.Nullable<System.Int32>& targetDisplay) { }

	// RVA: 0x1745378
	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, System.Nullable<System.Int32>& targetDisplay) { }

	// RVA: 0x17454EC
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	// RVA: 0x17455DC
	internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

}

// Namespace: UnityEngine.UIElements
internal interface IUIElementsUtility
{
	// Methods

	// RVA: -1
	public abstract bool TakeCapture() { }

	// RVA: -1
	public abstract bool ReleaseCapture() { }

	// RVA: -1
	public abstract bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, bool eventHandled) { }

	// RVA: -1
	public abstract bool CleanupRoots() { }

	// RVA: -1
	public abstract bool EndContainerGUIFromException(Exception exception) { }

	// RVA: -1
	public abstract bool MakeCurrentIMGUIContainerDirty() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIEventRegistration.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1746F24
	private static void .cctor() { }

	// RVA: 0x1746F90
	public void .ctor() { }

	// RVA: 0x1746F98
	internal void <.cctor>b__1_0() { }

	// RVA: 0x1747000
	internal void <.cctor>b__1_1() { }

	// RVA: 0x1747068
	internal bool <.cctor>b__1_2(int i, IntPtr ptr) { }

	// RVA: 0x17470F4
	internal void <.cctor>b__1_3() { }

	// RVA: 0x174715C
	internal bool <.cctor>b__1_4(Exception exception) { }

	// RVA: 0x17471DC
	internal void <.cctor>b__1_5() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIEventRegistration
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.IUIElementsUtility> s_Utilities; // 0x0

	// Methods

	// RVA: 0x17459B0
	private static void .cctor() { }

	// RVA: 0x1745EDC
	internal static void RegisterUIElementSystem(IUIElementsUtility utility) { }

	// RVA: 0x1745F84
	private static void TakeCapture() { }

	// RVA: 0x1746200
	private static void ReleaseCapture() { }

	// RVA: 0x1746480
	private static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x174675C
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0x1746A24
	private static void CleanupRoots() { }

	// RVA: 0x1746CA4
	internal static void MakeCurrentIMGUIContainerDirty() { }

}

// Namespace: UnityEngine.UIElements
internal class UIElementsUtility
{
	// Fields
	private static System.Collections.Generic.Stack<UnityEngine.UIElements.IMGUIContainer> s_ContainerStack; // 0x0
	private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.Panel> s_UIElementsCache; // 0x8
	private static Event s_EventInstance; // 0x10
	internal static Color editorPlayModeTintColor; // 0x18
	internal static float singleLineHeight; // 0x28
	private static UIElementsUtility s_Instance; // 0x30
	internal static System.Collections.Generic.List<UnityEngine.UIElements.Panel> s_PanelsIterationList; // 0x38
	internal static readonly string s_RepaintProfilerMarkerName; // 0x40
	internal static readonly string s_EventProfilerMarkerName; // 0x48
	private static readonly ProfilerMarker s_RepaintProfilerMarker; // 0x50
	private static readonly ProfilerMarker s_EventProfilerMarker; // 0x58
	internal static Char[] s_Modifiers; // 0x60

	// Methods

	// RVA: 0x1747244
	private void .ctor() { }

	// RVA: 0x174734C
	private bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0x1747444
	private bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }

	// RVA: 0x1747538
	private bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }

	// RVA: 0x1747540
	private bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, bool eventHandled) { }

	// RVA: 0x1747C9C
	private bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }

	// RVA: 0x1747D34
	private bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x1743224
	public static void RegisterCachedPanel(int instanceID, Panel panel) { }

	// RVA: 0x1743384
	public static void RemoveCachedPanel(int instanceID) { }

	// RVA: 0x1742BB8
	public static bool TryGetPanel(int instanceID, Panel panel) { }

	// RVA: 0x1747E64
	internal static void BeginContainerGUI(LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0x17480F0
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0x1748368
	internal static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x17425E8
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0x1747660
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0x1743438
	internal static void GetAllPanels(System.Collections.Generic.List<UnityEngine.UIElements.Panel> panels, ContextType contextType) { }

	// RVA: 0x17483FC
	internal static Enumerator GetPanelsIterator() { }

	// RVA: 0x17484D4
	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) { }

	// RVA: 0x17485C8
	internal static string ParseMenuName(string menuName) { }

	// RVA: 0x174871C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct RuleMatcher
{
	// Fields
	public StyleSheet sheet; // 0x10
	public StyleComplexSelector complexSelector; // 0x18

	// Methods

	// RVA: 0x17489DC
	public override string ToString() { }

}

// Namespace: 
internal interface IVisualPredicateWrapper
{
	// Methods

	// RVA: -1
	public abstract bool Predicate(object e) { }

}

// Namespace: 
internal class IsOfType<T0>
{
	// Fields
	public static UnityEngine.UIElements.UQuery.IsOfType<T> s_Instance; // 0x0

	// Methods

	// RVA: 0x30A1344
	public bool Predicate(object e) { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UQuery.UQueryMatcher.<>c <>9; // 0x0
	public static System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x1748C70
	private static void .cctor() { }

	// RVA: 0x1748CDC
	public void .ctor() { }

	// RVA: 0x1748CE4
	internal void <TraverseRecursive>b__5_0(VisualElement e, MatchResultInfo i) { }

}

// Namespace: 
internal abstract class UQueryMatcher
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers; // 0x10

	// Methods

	// RVA: 0x1748A00
	protected void .ctor() { }

	// RVA: 0x1748A08
	public override void Traverse(VisualElement element) { }

	// RVA: 0x1748A10
	protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x1748A18
	private static void NoProcessResult(VisualElement e, MatchResultInfo i) { }

	// RVA: 0x1748A1C
	public override void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x1748C34
	public virtual void Run(VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

}

// Namespace: 
internal abstract class SingleQueryMatcher
{
	// Fields
	private VisualElement <match>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1748CE8
	public VisualElement get_match() { }

	// RVA: 0x1748CF0
	public void set_match(VisualElement value) { }

	// RVA: 0x1748CF8
	public override void Run(VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

	// RVA: 0x1748D64
	public bool IsInUse() { }

	// RVA: -1
	public abstract SingleQueryMatcher CreateNew() { }

	// RVA: 0x1748D74
	protected void .ctor() { }

}

// Namespace: 
internal class FirstQueryMatcher
{
	// Fields
	public static readonly FirstQueryMatcher Instance; // 0x0

	// Methods

	// RVA: 0x1748D7C
	protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x1748DB0
	public override SingleQueryMatcher CreateNew() { }

	// RVA: 0x1748E08
	public void .ctor() { }

	// RVA: 0x1748E10
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public static class UQuery
{}

// Namespace: 
private class ListQueryMatcher<T0>
{
	// Fields
	private System.Collections.Generic.List<TElement> <matches>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A17DC
	public System.Collections.Generic.List<TElement> get_matches() { }

	// RVA: 0x30A27C0
	public void set_matches(System.Collections.Generic.List<TElement> value) { }

	// RVA: -1
	protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
private class ActionQueryMatcher
{
	// Fields
	private System.Action<T> <callBack>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A17DC
	internal System.Action<T> get_callBack() { }

	// RVA: -1
	protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> iterationList; // 0x0
	private int currentIndex; // 0x0

	// Methods

	// RVA: 0x315B3A8
	internal void .ctor(UnityEngine.UIElements.UQueryState<T> queryState) { }

	// RVA: 0x315B3A8
	public T get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x30A2378
	public void Dispose() { }

}

// Namespace: UnityEngine.UIElements
public struct UQueryState<T0>
{
	// Fields
	private static ActionQueryMatcher s_Action; // 0x0
	private readonly VisualElement m_Element; // 0x0
	internal readonly System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers; // 0x0
	private static readonly UnityEngine.UIElements.UQueryState.ListQueryMatcher<T,T> s_List; // 0x0
	private static readonly UnityEngine.UIElements.UQueryState.ListQueryMatcher<T,UnityEngine.UIElements.VisualElement> s_EnumerationList; // 0x0

	// Methods

	// RVA: 0x30A2A20
	internal void .ctor(VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

	// RVA: 0x315B3A8
	public UnityEngine.UIElements.UQueryState<T> RebuildOn(VisualElement element) { }

	// RVA: 0x315B3A8
	private T Single(SingleQueryMatcher matcher) { }

	// RVA: 0x315B3A8
	public T First() { }

	// RVA: 0x315B3A8
	public Enumerator GetEnumerator() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	public bool Equals(UnityEngine.UIElements.UQueryState<T> other) { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public struct UQueryBuilder<T0>
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> m_StyleSelectors; // 0x0
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> m_Parts; // 0x0
	private VisualElement m_Element; // 0x0
	private System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers; // 0x0
	private StyleSelectorRelationship m_Relationship; // 0x0
	private int pseudoStatesMask; // 0x0
	private int negatedPseudoStatesMask; // 0x0

	// Methods

	// RVA: 0x30A17DC
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> get_styleSelectors() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> get_parts() { }

	// RVA: 0x30A27C0
	public void .ctor(VisualElement visualElement) { }

	// RVA: 0x315B3A8
	public UnityEngine.UIElements.UQueryBuilder<T> Class(string classname) { }

	// RVA: 0x315B3A8
	public UnityEngine.UIElements.UQueryBuilder<T> Name(string id) { }

	// RVA: 0x315B3A8
	internal UnityEngine.UIElements.UQueryBuilder<T> SingleBaseType() { }

	// RVA: 0x30A27C0
	private void AddClass(string c) { }

	// RVA: 0x30A27C0
	private void AddName(string id) { }

	// RVA: 0x30A2378
	private void AddPseudoStatesRuleIfNecessasy() { }

	// RVA: 0x30A2378
	private void FinishSelector() { }

	// RVA: 0x30A1224
	private bool CurrentSelectorEmpty() { }

	// RVA: 0x30A2378
	private void FinishCurrentSelector() { }

	// RVA: 0x315B3A8
	public UnityEngine.UIElements.UQueryState<T> Build() { }

	// RVA: 0x315B3A8
	public bool Equals(UnityEngine.UIElements.UQueryBuilder<T> other) { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public static class UQueryExtensions
{
	// Fields
	private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementEmptyQuery; // 0x0
	private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementNameQuery; // 0x10
	private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementClassQuery; // 0x20
	private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementNameAndClassQuery; // 0x30
	private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeQuery; // 0x40
	private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameQuery; // 0x50
	private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndClassQuery; // 0x60
	private static UnityEngine.UIElements.UQueryState<UnityEngine.UIElements.VisualElement> SingleElementTypeAndNameAndClassQuery; // 0x70

	// Methods

	// RVA: 0x315B3A8
	public static T Q(VisualElement e, string name, string className) { }

	// RVA: 0x1748E7C
	public static VisualElement Q(VisualElement e, string name, string className) { }

	// RVA: 0x174931C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IUxmlAttributes
{
	// Methods

	// RVA: -1
	public abstract bool TryGetAttributeValue(string attributeName, string value) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlRootElementFactory
{
	// Methods

	// RVA: 0x174987C
	public override string get_uxmlName() { }

	// RVA: 0x17498C0
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x1749940
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1749948
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlRootElementTraits
{
	// Fields
	protected UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Class; // 0x20

	// Methods

	// RVA: 0x174999C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlStyleFactory
{
	// Methods

	// RVA: 0x1749ABC
	public override string get_uxmlName() { }

	// RVA: 0x1749B00
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x1749B80
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1749B88
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlStyleTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Path; // 0x20
	private UxmlStringAttributeDescription m_Src; // 0x28

	// Methods

	// RVA: 0x1749BDC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlTemplateFactory
{
	// Methods

	// RVA: 0x1749D18
	public override string get_uxmlName() { }

	// RVA: 0x1749D5C
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x1749DDC
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1749DE4
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlTemplateTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Path; // 0x20
	private UxmlStringAttributeDescription m_Src; // 0x28

	// Methods

	// RVA: 0x1749E38
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlAttributeOverridesFactory
{
	// Methods

	// RVA: 0x1749F7C
	public override string get_uxmlName() { }

	// RVA: 0x1749FC0
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x174A040
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x174A048
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlAttributeOverridesTraits
{
	// Fields
	private UxmlStringAttributeDescription m_ElementName; // 0x18

	// Methods

	// RVA: 0x174A09C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public struct AttributeOverride
{
	// Fields
	public string m_ElementName; // 0x10
	public string m_AttributeName; // 0x18
	public string m_Value; // 0x20
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class TemplateAsset
{
	// Fields
	private string m_TemplateAlias; // 0x70
	private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> m_AttributeOverrides; // 0x78
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> m_SlotUsages; // 0x80

	// Methods

	// RVA: 0x174A150
	public System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	// RVA: 0x174A1F0
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> get_slotUsages() { }

}

// Namespace: 
public enum Use
{
	// Fields
	public int value__; // 0x10
	public const Use None = 0;
	public const Use Optional = 1;
	public const Use Prohibited = 2;
	public const Use Required = 3;
}

// Namespace: UnityEngine.UIElements
public abstract class UxmlAttributeDescription
{
	// Fields
	private string <name>k__BackingField; // 0x10
	private string[] m_ObsoleteNames; // 0x18
	private string <type>k__BackingField; // 0x20
	private string <typeNamespace>k__BackingField; // 0x28
	private Use <use>k__BackingField; // 0x30
	private UxmlTypeRestriction <restriction>k__BackingField; // 0x38

	// Methods

	// RVA: 0x174A1F8
	protected void .ctor() { }

	// RVA: 0x174A230
	public string get_name() { }

	// RVA: 0x174A238
	public void set_name(string value) { }

	// RVA: 0x174A240
	public void set_obsoleteNames(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x174A2A8
	protected void set_type(string value) { }

	// RVA: 0x174A2B0
	protected void set_typeNamespace(string value) { }

	// RVA: 0x174A2B8
	public void set_use(Use value) { }

	// RVA: 0x174A2C0
	public void set_restriction(UxmlTypeRestriction value) { }

	// RVA: 0x174A2C8
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, string value) { }

	// RVA: 0x315B3A8
	protected bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue, T value) { }

	// RVA: 0x315B3A8
	protected T GetValueFromBag(IUxmlAttributes bag, CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue) { }

}

// Namespace: UnityEngine.UIElements
public abstract class TypedUxmlAttributeDescription<T0>
{
	// Fields
	private T <defaultValue>k__BackingField; // 0x0

	// Methods

	// RVA: -1
	public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x315B3A8
	public T get_defaultValue() { }

	// RVA: 0x315B3A8
	public void set_defaultValue(T value) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlStringAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.String,System.String> <>9__3_0; // 0x8
	public static System.Func<System.String,System.String,System.String> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x174ABD4
	private static void .cctor() { }

	// RVA: 0x174AC40
	public void .ctor() { }

	// RVA: 0x174AC48
	internal string <GetValueFromBag>b__3_0(string s, string t) { }

	// RVA: 0x174AC50
	internal string <TryGetValueFromBag>b__4_0(string s, string t) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlStringAttributeDescription
{
	// Methods

	// RVA: 0x17410C4
	public void .ctor() { }

	// RVA: 0x174A83C
	public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x174AA04
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, string value) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlFloatAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Single,System.Single> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x174AFA0
	private static void .cctor() { }

	// RVA: 0x174B00C
	public void .ctor() { }

	// RVA: 0x174B014
	internal float <GetValueFromBag>b__3_0(string s, float f) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlFloatAttributeDescription
{
	// Methods

	// RVA: 0x174AC58
	public void .ctor() { }

	// RVA: 0x174AD30
	public override float GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x174AF00
	private static float ConvertValueToFloat(string v, float defaultValue) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlDoubleAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Double,System.Double> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x174B3FC
	private static void .cctor() { }

	// RVA: 0x174B468
	public void .ctor() { }

	// RVA: 0x174B470
	internal Double <GetValueFromBag>b__3_0(string s, Double d) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlDoubleAttributeDescription
{
	// Methods

	// RVA: 0x174B0B4
	public void .ctor() { }

	// RVA: 0x174B18C
	public override Double GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x174B35C
	private static Double ConvertValueToDouble(string v, Double defaultValue) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlIntAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Int32,System.Int32> <>9__3_0; // 0x8
	public static System.Func<System.String,System.Int32,System.Int32> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x174B9D8
	private static void .cctor() { }

	// RVA: 0x174BA44
	public void .ctor() { }

	// RVA: 0x174BA4C
	internal int <GetValueFromBag>b__3_0(string s, int i) { }

	// RVA: 0x174BA98
	internal int <TryGetValueFromBag>b__4_0(string s, int i) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlIntAttributeDescription
{
	// Methods

	// RVA: 0x174B510
	public void .ctor() { }

	// RVA: 0x174B5E8
	public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x174B7B8
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, int value) { }

	// RVA: 0x174B990
	private static int ConvertValueToInt(string v, int defaultValue) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlUnsignedIntAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.UInt32,System.UInt32> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x174BDD4
	private static void .cctor() { }

	// RVA: 0x174BE40
	public void .ctor() { }

	// RVA: 0x174BE48
	internal UInt32 <GetValueFromBag>b__3_0(string s, UInt32 i) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlUnsignedIntAttributeDescription
{
	// Methods

	// RVA: 0x174BAE4
	public void .ctor() { }

	// RVA: 0x174BBBC
	public override UInt32 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x174BD8C
	private static UInt32 ConvertValueToUInt(string v, UInt32 defaultValue) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlUnsignedLongAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.UInt64,System.UInt64> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x174C184
	private static void .cctor() { }

	// RVA: 0x174C1F0
	public void .ctor() { }

	// RVA: 0x174C1F8
	internal UInt64 <GetValueFromBag>b__3_0(string s, UInt64 l) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlUnsignedLongAttributeDescription
{
	// Methods

	// RVA: 0x174BE94
	public void .ctor() { }

	// RVA: 0x174BF6C
	public override UInt64 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x174C13C
	private static UInt64 ConvertValueToUlong(string v, UInt64 defaultValue) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlLongAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Int64,System.Int64> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x174C534
	private static void .cctor() { }

	// RVA: 0x174C5A0
	public void .ctor() { }

	// RVA: 0x174C5A8
	internal Int64 <GetValueFromBag>b__3_0(string s, Int64 l) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlLongAttributeDescription
{
	// Methods

	// RVA: 0x174C244
	public void .ctor() { }

	// RVA: 0x174C31C
	public override Int64 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x174C4EC
	private static Int64 ConvertValueToLong(string v, Int64 defaultValue) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlBoolAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Boolean,System.Boolean> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x174C870
	private static void .cctor() { }

	// RVA: 0x174C8DC
	public void .ctor() { }

	// RVA: 0x174C8E4
	internal bool <GetValueFromBag>b__3_0(string s, bool b) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlBoolAttributeDescription
{
	// Methods

	// RVA: 0x17411A8
	public void .ctor() { }

	// RVA: 0x174C5F4
	public override bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x174C7C4
	private static bool ConvertValueToBool(string v, bool defaultValue) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlTypeAttributeDescription<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: -1
	public override Type GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A1970
	private Type ConvertValueToType(string v, Type defaultValue) { }

	// RVA: 0x30A1970
	private Type <GetValueFromBag>b__3_0(string s, Type type1) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlEnumAttributeDescription.<>c<T> <>9; // 0x0
	public static System.Func<System.String,T,T> <>9__3_0; // 0x0
	public static System.Func<System.String,T,T> <>9__4_0; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal T <GetValueFromBag>b__3_0(string s, T convertible) { }

	// RVA: 0x315B3A8
	internal T <TryGetValueFromBag>b__4_0(string s, T convertible) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlEnumAttributeDescription<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x315B3A8
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, T value) { }

	// RVA: 0x315B3A8
	private static U ConvertValueToEnum(string v, U defaultValue) { }

	// RVA: 0x30A53B0
	private static string GetEnumNameErrorMessage(string v, Type enumType) { }

	// RVA: 0x30A53B0
	private static string GetEnumRangeErrorMessage(string v, Type enumType) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlHash128AttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,UnityEngine.Hash128,UnityEngine.Hash128> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x174CC38
	private static void .cctor() { }

	// RVA: 0x174CCA4
	public void .ctor() { }

	// RVA: 0x174CCAC
	internal Hash128 <GetValueFromBag>b__3_0(string s, Hash128 i) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlHash128AttributeDescription
{
	// Methods

	// RVA: 0x174C990
	public void .ctor() { }

	// RVA: 0x174CA68
	public override Hash128 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectAttributeDescription<T0>
{
	// Fields
	private T <defaultValue>k__BackingField; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public T get_defaultValue() { }

	// RVA: 0x315B3A8
	public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectListAttributeDescription<T0>
{
	// Methods

	// RVA: -1
	public override System.Collections.Generic.List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseUxmlTraits
{
	// Fields
	private bool <canHaveAnyAttribute>k__BackingField; // 0x10

	// Methods

	// RVA: 0x174CCB8
	protected void .ctor() { }

	// RVA: 0x174CCE4
	protected void set_canHaveAnyAttribute(bool value) { }

}

// Namespace: UnityEngine.UIElements
public abstract class UxmlTraits
{
	// Methods

	// RVA: 0x174CCEC
	public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1749A90
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class UxmlObjectTraits<T0>
{
	// Methods

	// RVA: -1
	public virtual void Init(T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IBaseUxmlFactory
{
	// Methods

	// RVA: -1
	public abstract string get_uxmlQualifiedName() { }

	// RVA: -1
	public abstract Type get_uxmlType() { }

	// RVA: -1
	public abstract bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
public interface IUxmlFactory
{
	// Methods

	// RVA: -1
	public abstract VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
internal interface IBaseUxmlObjectFactory
{}

// Namespace: UnityEngine.UIElements
internal interface IUxmlObjectFactory<T0>
{
	// Methods

	// RVA: -1
	public abstract T CreateObject(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseUxmlFactory<T0, T1>
{
	// Fields
	internal TTraits m_Traits; // 0x0

	// Methods

	// RVA: 0x30A2378
	protected void .ctor() { }

	// RVA: 0x30A17DC
	public virtual string get_uxmlName() { }

	// RVA: 0x30A17DC
	public virtual string get_uxmlNamespace() { }

	// RVA: 0x30A17DC
	public virtual string get_uxmlQualifiedName() { }

	// RVA: 0x30A17DC
	public virtual Type get_uxmlType() { }

	// RVA: -1
	public virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlFactory<T0, T1>
{
	// Methods

	// RVA: -1
	public virtual VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectFactory<T0, T1>
{
	// Methods

	// RVA: 0x315B3A8
	public virtual TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlFactory<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class UxmlAsset
{
	// Fields
	private string m_FullTypeName; // 0x10
	private int m_Id; // 0x18
	private int m_OrderInDocument; // 0x1C
	private int m_ParentId; // 0x20
	protected System.Collections.Generic.List<System.String> m_Properties; // 0x28

	// Methods

	// RVA: 0x174CCF0
	public string get_fullTypeName() { }

	// RVA: 0x174CCF8
	public int get_id() { }

	// RVA: 0x174CD00
	public int get_orderInDocument() { }

	// RVA: 0x174CD08
	public int get_parentId() { }

	// RVA: 0x174CD10
	public bool TryGetAttributeValue(string propertyName, string value) { }

	// RVA: 0x174CE28
	public void SetAttribute(string name, string value) { }

	// RVA: 0x174CE2C
	private void SetOrAddProperty(string propertyName, string propertyValue) { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
internal sealed class UxmlObjectAsset
{}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectFactoryRegistry
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>> s_Factories; // 0x0

	// Methods

	// RVA: 0x174CFB8
	internal static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>> get_factories() { }

	// RVA: 0x174D5E8
	protected static void RegisterFactory(IBaseUxmlObjectFactory factory) { }

	// RVA: 0x174DAB8
	internal static bool TryGetFactories(string fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>& factoryList) { }

	// RVA: 0x174D090
	private static void RegisterEngineFactories() { }

	// RVA: 0x174D2EC
	private static void RegisterUserFactories() { }

}

// Namespace: UnityEngine.UIElements
public abstract class UxmlTypeRestriction
{
	// Methods

	// RVA: 0x174DB20
	public virtual bool Equals(UxmlTypeRestriction other) { }

	// RVA: 0x174DB2C
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlEnumeration
{
	// Fields
	private System.Collections.Generic.List<System.String> m_Values; // 0x10

	// Methods

	// RVA: 0x174DB34
	public System.Collections.Generic.IEnumerable<System.String> get_values() { }

	// RVA: 0x174DB3C
	public void set_values(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x174DBA4
	public override bool Equals(UxmlTypeRestriction other) { }

	// RVA: 0x174DD08
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
internal class VisualElementAsset
{
	// Fields
	private string m_Name; // 0x30
	private int m_RuleIndex; // 0x38
	private string m_Text; // 0x40
	private PickingMode m_PickingMode; // 0x48
	private string[] m_Classes; // 0x50
	private System.Collections.Generic.List<System.String> m_StylesheetPaths; // 0x58
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_Stylesheets; // 0x60
	private bool m_SkipClone; // 0x68

	// Methods

	// RVA: 0x174DD94
	public int get_ruleIndex() { }

	// RVA: 0x174DD9C
	public string[] get_classes() { }

	// RVA: 0x174DDA4
	public System.Collections.Generic.List<System.String> get_stylesheetPaths() { }

	// RVA: 0x174DE44
	public bool get_hasStylesheetPaths() { }

	// RVA: 0x174DE54
	public System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_stylesheets() { }

	// RVA: 0x174DEF4
	public bool get_hasStylesheets() { }

	// RVA: 0x174DF04
	internal bool get_skipClone() { }

	// RVA: 0x174DF0C
	public void OnBeforeSerialize() { }

	// RVA: 0x174DF10
	public void OnAfterDeserialize() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualElementFactoryRegistry
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> s_Factories; // 0x0
	private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> s_MovedTypesFactories; // 0x8

	// Methods

	// RVA: 0x174E0A4
	private static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr) { }

	// RVA: 0x174E228
	internal static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> get_factories() { }

	// RVA: 0x174FA6C
	protected static void RegisterFactory(IUxmlFactory factory) { }

	// RVA: 0x1750080
	internal static bool TryGetValue(string fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>& factoryList) { }

	// RVA: 0x174E34C
	private static void RegisterEngineFactories() { }

	// RVA: 0x174F770
	internal static void RegisterUserFactories() { }

}

// Namespace: 
[Serializable]
internal struct UsingEntry
{
	// Fields
	internal static readonly System.Collections.Generic.IComparer<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> comparer; // 0x0
	public string alias; // 0x10
	public string path; // 0x18
	public VisualTreeAsset asset; // 0x20

	// Methods

	// RVA: 0x1753924
	public void .ctor(string alias, string path) { }

	// RVA: 0x1753BB0
	private static void .cctor() { }

}

// Namespace: 
private class UsingEntryComparer
{
	// Methods

	// RVA: 0x1753C40
	public int Compare(UsingEntry x, UsingEntry y) { }

	// RVA: 0x1753C38
	public void .ctor() { }

}

// Namespace: 
[Serializable]
internal struct SlotDefinition
{
	// Fields
	public string name; // 0x10
	public int insertionPointId; // 0x18
}

// Namespace: 
[Serializable]
internal struct SlotUsageEntry
{
	// Fields
	public string slotName; // 0x10
	public int assetId; // 0x18
}

// Namespace: 
[Serializable]
internal struct UxmlObjectEntry
{
	// Fields
	public int parentId; // 0x10
	public System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset> uxmlObjectAssets; // 0x18

	// Methods

	// RVA: 0x17507AC
	public void .ctor(int parentId, System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset> uxmlObjectAssets) { }

}

// Namespace: 
[Serializable]
private struct AssetEntry
{
	// Fields
	public string path; // 0x10
	public string typeFullName; // 0x18
	public object asset; // 0x20
	private Type m_CachedType; // 0x28

	// Methods

	// RVA: 0x1750A34
	public Type get_type() { }

	// RVA: 0x1750C50
	public void .ctor(string path, Type type, object asset) { }

}

// Namespace: 
private sealed class <>c__DisplayClass61_0
{
	// Fields
	public VisualElementAsset childVea; // 0x10

	// Methods

	// RVA: 0x17535EC
	public void .ctor() { }

	// RVA: 0x1753C50
	internal bool <CloneSetupRecursively>b__0(SlotUsageEntry u) { }

}

// Namespace: 
private struct <>c__DisplayClass65_0
{
	// Fields
	public VisualElementAsset asset; // 0x10
}

// Namespace: 
private sealed class <get_stylesheets>d__23
{
	// Fields
	private int <>1__state; // 0x10
	private StyleSheet <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public VisualTreeAsset <>4__this; // 0x28
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheet> <sent>5__1; // 0x30
	private Enumerator <>s__2; // 0x38
	private VisualElementAsset <vea>5__3; // 0x50
	private Enumerator <>s__4; // 0x58
	private StyleSheet <stylesheet>5__5; // 0x70
	private Enumerator <>s__6; // 0x78
	private string <stylesheetPath>5__7; // 0x90
	private StyleSheet <stylesheet>5__8; // 0x98

	// Methods

	// RVA: 0x175031C
	public void .ctor(int <>1__state) { }

	// RVA: 0x1753C78
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1753E2C
	private bool MoveNext() { }

	// RVA: 0x1754918
	private void <>m__Finally1() { }

	// RVA: 0x1754860
	private void <>m__Finally2() { }

	// RVA: 0x17548BC
	private void <>m__Finally3() { }

	// RVA: 0x1754974
	private StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current() { }

	// RVA: 0x175497C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x17549BC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x17549C4
	private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator() { }

	// RVA: 0x1754A78
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <get_templateDependencies>d__19
{
	// Fields
	private int <>1__state; // 0x10
	private VisualTreeAsset <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public VisualTreeAsset <>4__this; // 0x28
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualTreeAsset> <sent>5__1; // 0x30
	private Enumerator <>s__2; // 0x38
	private UsingEntry <entry>5__3; // 0x60
	private VisualTreeAsset <vta>5__4; // 0x78

	// Methods

	// RVA: 0x175025C
	public void .ctor(int <>1__state) { }

	// RVA: 0x1754A7C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1754B0C
	private bool MoveNext() { }

	// RVA: 0x1755194
	private void <>m__Finally1() { }

	// RVA: 0x17551F0
	private VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current() { }

	// RVA: 0x17551F8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1755238
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1755240
	private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator() { }

	// RVA: 0x17552F4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
public class VisualTreeAsset
{
	// Fields
	internal static string LinkedVEAInTemplatePropertyName; // 0x0
	private bool m_ImportedWithErrors; // 0x18
	private bool m_ImportedWithWarnings; // 0x19
	private static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> s_TemporarySlotInsertionPoints; // 0x8
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> m_Usings; // 0x20
	internal StyleSheet inlineSheet; // 0x28
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> m_VisualElementAssets; // 0x30
	private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> m_TemplateAssets; // 0x38
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry> m_UxmlObjectEntries; // 0x40
	private System.Collections.Generic.List<System.Int32> m_UxmlObjectIds; // 0x48
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.AssetEntry> m_AssetEntries; // 0x50
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> m_Slots; // 0x58
	private int m_ContentContainerId; // 0x60
	private int m_ContentHash; // 0x64

	// Methods

	// RVA: 0x1750134
	public bool get_importedWithErrors() { }

	// RVA: 0x175013C
	internal void set_importedWithErrors(bool value) { }

	// RVA: 0x1750144
	public bool get_importedWithWarnings() { }

	// RVA: 0x175014C
	internal void set_importedWithWarnings(bool value) { }

	// RVA: 0x1750154
	internal int GetNextChildSerialNumber() { }

	// RVA: 0x17501D4
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset> get_templateDependencies() { }

	// RVA: 0x1750294
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet> get_stylesheets() { }

	// RVA: 0x1750354
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> get_visualElementAssets() { }

	// RVA: 0x175035C
	internal void set_visualElementAssets(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> value) { }

	// RVA: 0x1750364
	internal System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> get_templateAssets() { }

	// RVA: 0x175036C
	internal void set_templateAssets(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> value) { }

	// RVA: 0x1750374
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry> get_uxmlObjectEntries() { }

	// RVA: 0x175037C
	internal System.Collections.Generic.List<System.Int32> get_uxmlObjectIds() { }

	// RVA: 0x1750384
	internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: -1
	internal System.Collections.Generic.List<T> GetUxmlObjects(IUxmlAttributes asset, CreationContext cc) { }

	// RVA: 0x17507BC
	internal bool AssetEntryExists(string path, Type type) { }

	// RVA: 0x1750B10
	internal void RegisterAssetEntry(string path, Type type, object asset) { }

	// RVA: 0x315B3A8
	internal T GetAsset(string path) { }

	// RVA: 0x17505C0
	internal UxmlObjectEntry GetUxmlObjectEntry(int id) { }

	// RVA: 0x1750CCC
	private IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: 0x1751218
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> get_slots() { }

	// RVA: 0x1751220
	internal void set_slots(System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> value) { }

	// RVA: 0x1751228
	internal int get_contentContainerId() { }

	// RVA: 0x1751230
	internal void set_contentContainerId(int value) { }

	// RVA: 0x1751238
	public TemplateContainer Instantiate() { }

	// RVA: 0x1751BC0
	public TemplateContainer Instantiate(string bindingPath) { }

	// RVA: 0x1751C00
	public TemplateContainer CloneTree() { }

	// RVA: 0x1751C04
	public TemplateContainer CloneTree(string bindingPath) { }

	// RVA: 0x1751C44
	public void CloneTree(VisualElement target) { }

	// RVA: 0x1751C70
	public void CloneTree(VisualElement target, int firstElementIndex, int elementAddedCount) { }

	// RVA: 0x175138C
	internal void CloneTree(VisualElement target, System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides) { }

	// RVA: 0x17522D4
	private VisualElement CloneSetupRecursively(VisualElementAsset root, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>> idToChildren, CreationContext context) { }

	// RVA: 0x17535F4
	private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b) { }

	// RVA: 0x17534F8
	internal bool TryGetSlotInsertionPoint(int insertionPointId, string slotName) { }

	// RVA: 0x1753630
	internal VisualTreeAsset ResolveTemplate(string templateName) { }

	// RVA: 0x1752E74
	internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx) { }

	// RVA: 0x1751E38
	private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x1751EB0
	private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x1753AC8
	public int get_contentHash() { }

	// RVA: 0x1753AD0
	public void set_contentHash(int value) { }

	// RVA: 0x1753AD8
	public void .ctor() { }

	// RVA: 0x1753AE0
	private static void .cctor() { }

	// RVA: 0x1753968
	internal static VisualElement <Create>g__CreateError|65_0(UnityEngine.UIElements.VisualTreeAsset.<>c__DisplayClass65_0& ) { }

}

// Namespace: UnityEngine.UIElements
public struct CreationContext
{
	// Fields
	public static readonly CreationContext Default; // 0x0
	private VisualElement <target>k__BackingField; // 0x10
	private VisualTreeAsset <visualTreeAsset>k__BackingField; // 0x18
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> <slotInsertionPoints>k__BackingField; // 0x20
	private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> <attributeOverrides>k__BackingField; // 0x28

	// Methods

	// RVA: 0x17552F8
	public VisualElement get_target() { }

	// RVA: 0x1755300
	private void set_target(VisualElement value) { }

	// RVA: 0x1755308
	public VisualTreeAsset get_visualTreeAsset() { }

	// RVA: 0x1755310
	private void set_visualTreeAsset(VisualTreeAsset value) { }

	// RVA: 0x1755318
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> get_slotInsertionPoints() { }

	// RVA: 0x1755320
	private void set_slotInsertionPoints(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x1755328
	internal System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	// RVA: 0x1755330
	private void set_attributeOverrides(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> value) { }

	// RVA: 0x1751114
	internal void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x175221C
	internal void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x1755338
	public override bool Equals(object obj) { }

	// RVA: 0x1755418
	public bool Equals(CreationContext other) { }

	// RVA: 0x1755594
	public override int GetHashCode() { }

	// RVA: 0x17556D4
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal enum GradientType
{
	// Fields
	public int value__; // 0x10
	public const GradientType Linear = 0;
	public const GradientType Radial = 1;
}

// Namespace: UnityEngine.UIElements
internal enum AddressMode
{
	// Fields
	public int value__; // 0x10
	public const AddressMode Wrap = 0;
	public const AddressMode Clamp = 1;
	public const AddressMode Mirror = 2;
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal struct VectorImageVertex
{
	// Fields
	public Vector3 position; // 0x10
	public Color32 tint; // 0x1C
	public Vector2 uv; // 0x20
	public UInt32 settingIndex; // 0x28
	public Color32 flags; // 0x2C
	public Vector4 circle; // 0x30
}

// Namespace: UnityEngine.UIElements
[Serializable]
internal struct GradientSettings
{
	// Fields
	public GradientType gradientType; // 0x10
	public AddressMode addressMode; // 0x14
	public Vector2 radialFocus; // 0x18
	public RectInt location; // 0x20
}

// Namespace: UnityEngine.UIElements
[Serializable]
public class VectorImage
{
	// Fields
	internal int version; // 0x18
	internal Texture2D atlas; // 0x20
	internal VectorImageVertex[] vertices; // 0x28
	internal UInt16[] indices; // 0x30
	internal GradientSettings[] settings; // 0x38
	internal Vector2 size; // 0x40

	// Methods

	// RVA: 0x1755724
	public float get_width() { }

	// RVA: 0x175572C
	public float get_height() { }

	// RVA: 0x1755734
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal enum PseudoStates
{
	// Fields
	public int value__; // 0x10
	public const PseudoStates Active = 1;
	public const PseudoStates Hover = 2;
	public const PseudoStates Checked = 8;
	public const PseudoStates Disabled = 32;
	public const PseudoStates Focus = 64;
	public const PseudoStates Root = 128;
}

// Namespace: UnityEngine.UIElements
internal enum VisualElementFlags
{
	// Fields
	public int value__; // 0x10
	public const VisualElementFlags WorldTransformDirty = 1;
	public const VisualElementFlags WorldTransformInverseDirty = 2;
	public const VisualElementFlags WorldClipDirty = 4;
	public const VisualElementFlags BoundingBoxDirty = 8;
	public const VisualElementFlags WorldBoundingBoxDirty = 16;
	public const VisualElementFlags EventCallbackParentCategoriesDirty = 32;
	public const VisualElementFlags LayoutManual = 64;
	public const VisualElementFlags CompositeRoot = 128;
	public const VisualElementFlags RequireMeasureFunction = 256;
	public const VisualElementFlags EnableViewDataPersistence = 512;
	public const VisualElementFlags DisableClipping = 1024;
	public const VisualElementFlags NeedsAttachToPanelEvent = 2048;
	public const VisualElementFlags HierarchyDisplayed = 4096;
	public const VisualElementFlags StyleInitialized = 8192;
	public const VisualElementFlags Init = 4159;
}

// Namespace: UnityEngine.UIElements
public enum PickingMode
{
	// Fields
	public int value__; // 0x10
	public const PickingMode Position = 0;
	public const PickingMode Ignore = 1;
}

// Namespace: UnityEngine.UIElements
public enum LanguageDirection
{
	// Fields
	public int value__; // 0x10
	public const LanguageDirection Inherit = 0;
	public const LanguageDirection LTR = 1;
	public const LanguageDirection RTL = 2;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.VisualElementListPool.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1755BE4
	private static void .cctor() { }

	// RVA: 0x1755C50
	public void .ctor() { }

	// RVA: 0x1755C58
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> <.cctor>b__4_0() { }

}

// Namespace: UnityEngine.UIElements
internal static class VisualElementListPool
{
	// Fields
	private static UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>> pool; // 0x0

	// Methods

	// RVA: 0x17557D0
	public static System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Copy(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x17558B4
	public static System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Get(int initialCapacity) { }

	// RVA: 0x17559C8
	public static void Release(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x1755AC4
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ObjectListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A17DC
	internal System.Collections.Generic.List<T> <.cctor>b__4_0() { }

}

// Namespace: UnityEngine.UIElements
internal class ObjectListPool<T0>
{
	// Fields
	private static UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<T>> pool; // 0x0

	// Methods

	// RVA: 0x30A5298
	public static System.Collections.Generic.List<T> Get() { }

	// RVA: 0x30A7C50
	public static void Release(System.Collections.Generic.List<T> elements) { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public static class VisualElementExtensions
{
	// Methods

	// RVA: 0x1755CCC
	public static void StretchToParentSize(VisualElement elem) { }

	// RVA: 0x1756000
	public static void AddManipulator(VisualElement ele, IManipulator manipulator) { }

	// RVA: 0x17560BC
	public static void RemoveManipulator(VisualElement ele, IManipulator manipulator) { }

	// RVA: 0x175617C
	public static Vector2 WorldToLocal(VisualElement ele, Vector2 p) { }

	// RVA: 0x1756264
	public static Vector2 LocalToWorld(VisualElement ele, Vector2 p) { }

	// RVA: 0x175634C
	public static Rect WorldToLocal(VisualElement ele, Rect r) { }

	// RVA: 0x1756434
	public static Vector2 ChangeCoordinatesTo(VisualElement src, VisualElement dest, Vector2 point) { }

}

// Namespace: 
private struct DefaultEventInterests
{
	// Fields
	public int DefaultActionCategories; // 0x10
	public int DefaultActionAtTargetCategories; // 0x14
}

// Namespace: UnityEngine.UIElements
internal static class EventInterestReflectionUtils
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.UIElements.EventInterestReflectionUtils.DefaultEventInterests> s_DefaultEventInterests; // 0x0
	private static readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.UIElements.EventCategory> s_EventCategories; // 0x8

	// Methods

	// RVA: 0x1756458
	internal static void GetDefaultEventInterests(Type elementType, int defaultActionCategories, int defaultActionAtTargetCategories) { }

	// RVA: 0x17566D0
	private static int ComputeDefaultEventInterests(Type elementType, string methodName) { }

	// RVA: 0x17568C8
	internal static EventCategory GetEventCategory(Type eventType) { }

	// RVA: 0x1756B04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal enum EventCategory
{
	// Fields
	public int value__; // 0x10
	public const EventCategory Default = 0;
	public const EventCategory Pointer = 1;
	public const EventCategory PointerMove = 2;
	public const EventCategory EnterLeave = 3;
	public const EventCategory EnterLeaveWindow = 4;
	public const EventCategory Keyboard = 5;
	public const EventCategory Geometry = 6;
	public const EventCategory Style = 7;
	public const EventCategory ChangeValue = 8;
	public const EventCategory Bind = 9;
	public const EventCategory Focus = 10;
	public const EventCategory ChangePanel = 11;
	public const EventCategory StyleTransition = 12;
	public const EventCategory Navigation = 13;
	public const EventCategory Command = 14;
	public const EventCategory Tooltip = 15;
	public const EventCategory IMGUI = 16;
	public const EventCategory Reserved = 31;
}

// Namespace: UnityEngine.UIElements
internal enum EventCategoryFlags
{
	// Fields
	public int value__; // 0x10
	public const EventCategoryFlags None = 0;
	public const EventCategoryFlags All = 4294967295;
	public const EventCategoryFlags TriggeredByOS = 81974;
	public const EventCategoryFlags TargetOnly = 2768;
}

// Namespace: UnityEngine.UIElements
public enum EventInterestOptions
{
	// Fields
	public int value__; // 0x10
	public const EventInterestOptions Inherit = 0;
	public const EventInterestOptions AllEventTypes = 4294967295;
}

// Namespace: UnityEngine.UIElements
public class EventInterestAttribute
{
	// Fields
	internal Type[] eventTypes; // 0x10
	internal EventCategoryFlags categoryFlags; // 0x18

	// Methods

	// RVA: 0x1756BF8
	public void .ctor(Type[] eventTypes) { }

	// RVA: 0x1756C30
	public void .ctor(EventInterestOptions interests) { }

}

// Namespace: UnityEngine.UIElements
internal class EventCategoryAttribute
{
	// Fields
	internal EventCategory category; // 0x10

	// Methods

	// RVA: 0x1756C60
	public void .ctor(EventCategory category) { }

}

// Namespace: UnityEngine.UIElements
public interface IExperimentalFeatures
{
	// Methods

	// RVA: -1
	public abstract ITransitionAnimations get_animation() { }

}

// Namespace: UnityEngine.UIElements
public class VisualElementFocusChangeDirection
{
	// Fields
	private static readonly VisualElementFocusChangeDirection s_Left; // 0x0
	private static readonly VisualElementFocusChangeDirection s_Right; // 0x8

	// Methods

	// RVA: 0x1756C8C
	public static FocusChangeDirection get_left() { }

	// RVA: 0x1756D08
	public static FocusChangeDirection get_right() { }

	// RVA: 0x1756D84
	protected void .ctor(int value) { }

	// RVA: 0x1756DF0
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.VisualElementFocusChangeTarget.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17573AC
	private static void .cctor() { }

	// RVA: 0x1757418
	public void .ctor() { }

	// RVA: 0x1757420
	internal VisualElementFocusChangeTarget <.cctor>b__9_0() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualElementFocusChangeTarget
{
	// Fields
	private static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.VisualElementFocusChangeTarget> Pool; // 0x0
	private Focusable <target>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1756FF4
	public static VisualElementFocusChangeTarget GetPooled(Focusable target) { }

	// RVA: 0x17570C4
	protected override void Dispose() { }

	// RVA: 0x1757160
	internal override void ApplyTo(FocusController focusController, Focusable f) { }

	// RVA: 0x17571A8
	public void .ctor() { }

	// RVA: 0x175727C
	public Focusable get_target() { }

	// RVA: 0x1757284
	private void set_target(Focusable value) { }

	// RVA: 0x175728C
	private static void .cctor() { }

}

// Namespace: 
public enum DefaultFocusOrder
{
	// Fields
	public int value__; // 0x10
	public const DefaultFocusOrder ChildOrder = 0;
	public const DefaultFocusOrder PositionXY = 1;
	public const DefaultFocusOrder PositionYX = 2;
}

// Namespace: 
private class FocusRingRecord
{
	// Fields
	public int m_AutoIndex; // 0x10
	public Focusable m_Focusable; // 0x18
	public bool m_IsSlot; // 0x20
	public System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> m_ScopeNavigationOrder; // 0x28

	// Methods

	// RVA: 0x1758C7C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class VisualElementFocusRing
{
	// Fields
	private readonly VisualElement root; // 0x10
	private DefaultFocusOrder <defaultFocusOrder>k__BackingField; // 0x18
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> m_FocusRing; // 0x20

	// Methods

	// RVA: 0x1757474
	public void .ctor(VisualElement root, DefaultFocusOrder dfo) { }

	// RVA: 0x1757524
	private FocusController get_focusController() { }

	// RVA: 0x175754C
	public DefaultFocusOrder get_defaultFocusOrder() { }

	// RVA: 0x1757554
	public void set_defaultFocusOrder(DefaultFocusOrder value) { }

	// RVA: 0x175755C
	private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b) { }

	// RVA: 0x175789C
	private int FocusRingSort(FocusRingRecord a, FocusRingRecord b) { }

	// RVA: 0x17579A8
	private void DoUpdate() { }

	// RVA: 0x1757AD0
	private void BuildRingForScopeRecursive(VisualElement ve, int scopeIndex, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> scopeList) { }

	// RVA: 0x1757D88
	private void SortAndFlattenScopeLists(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> rootScopeList) { }

	// RVA: 0x17580A8
	private int GetFocusableInternalIndex(Focusable f) { }

	// RVA: 0x1758164
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x17585AC
	public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	// RVA: 0x1758AB8
	internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable) { }

	// RVA: 0x1758B74
	internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable) { }

}

// Namespace: UnityEngine.UIElements
public interface IVisualElementScheduledItem
{
	// Methods

	// RVA: -1
	public abstract bool get_isActive() { }

	// RVA: -1
	public abstract void Resume() { }

	// RVA: -1
	public abstract void Pause() { }

	// RVA: -1
	public abstract void ExecuteLater(Int64 delayMs) { }

	// RVA: -1
	public abstract IVisualElementScheduledItem StartingIn(Int64 delayMs) { }

	// RVA: -1
	public abstract IVisualElementScheduledItem Every(Int64 intervalMs) { }

}

// Namespace: UnityEngine.UIElements
public interface IVisualElementScheduler
{
	// Methods

	// RVA: -1
	public abstract IVisualElementScheduledItem Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent) { }

	// RVA: -1
	public abstract IVisualElementScheduledItem Execute(Action updateEvent) { }

}

// Namespace: UnityEngine.UIElements
internal interface IVisualElementPanelActivatable
{
	// Methods

	// RVA: -1
	public abstract VisualElement get_element() { }

	// RVA: -1
	public abstract bool CanBeActivated() { }

	// RVA: -1
	public abstract void OnPanelActivate() { }

	// RVA: -1
	public abstract void OnPanelDeactivate() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualElementPanelActivator
{
	// Fields
	private IVisualElementPanelActivatable m_Activatable; // 0x10
	private bool <isActive>k__BackingField; // 0x18
	private bool <isDetaching>k__BackingField; // 0x19
	private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.AttachToPanelEvent> m_OnAttachToPanelCallback; // 0x20
	private UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.DetachFromPanelEvent> m_OnDetachFromPanelCallback; // 0x28

	// Methods

	// RVA: 0x1758C84
	public bool get_isActive() { }

	// RVA: 0x1758C8C
	private void set_isActive(bool value) { }

	// RVA: 0x1758C94
	public bool get_isDetaching() { }

	// RVA: 0x1758C9C
	private void set_isDetaching(bool value) { }

	// RVA: 0x1758CA4
	public void .ctor(IVisualElementPanelActivatable activatable) { }

	// RVA: 0x1758DB0
	public void SetActive(bool action) { }

	// RVA: 0x17590AC
	public void SendActivation() { }

	// RVA: 0x17591F4
	public void SendDeactivation() { }

	// RVA: 0x175933C
	private void OnEnter(AttachToPanelEvent evt) { }

	// RVA: 0x175934C
	private void OnLeave(DetachFromPanelEvent evt) { }

}

// Namespace: UnityEngine.UIElements
public struct VisualElementStyleSheetSet
{
	// Fields
	private readonly VisualElement m_Element; // 0x10

	// Methods

	// RVA: 0x17593C8
	internal void .ctor(VisualElement element) { }

	// RVA: 0x17593D0
	public void Add(StyleSheet styleSheet) { }

	// RVA: 0x1759584
	public bool Remove(StyleSheet styleSheet) { }

	// RVA: 0x17596E4
	public bool Equals(VisualElementStyleSheetSet other) { }

	// RVA: 0x17596F0
	public override bool Equals(object obj) { }

	// RVA: 0x175977C
	public override int GetHashCode() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.VisualElementUtils.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.UIElements.VisualElement> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x1759C10
	private static void .cctor() { }

	// RVA: 0x1759C7C
	public void .ctor() { }

	// RVA: 0x1759C84
	internal bool <AssignInspectorStyleIfNecessary>b__5_0(VisualElement i) { }

}

// Namespace: UnityEngine.UIElements
internal static class VisualElementUtils
{
	// Fields
	private static readonly System.Collections.Generic.HashSet<System.String> s_usedNames; // 0x0
	private static readonly Type s_FoldoutType; // 0x8
	private static readonly string s_InspectorElementUssClassName; // 0x10

	// Methods

	// RVA: 0x1759794
	public static string GetUniqueName(string nameBase) { }

	// RVA: 0x17598C4
	internal static int GetFoldoutDepth(VisualElement element) { }

	// RVA: 0x17599B8
	internal static void AssignInspectorStyleIfNecessary(VisualElement element, string classNameToEnable) { }

	// RVA: 0x1759AE8
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualElementAnimationSystem
{
	// Fields
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_Animations; // 0x20
	private System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_IterationList; // 0x28
	private bool m_HasNewAnimations; // 0x30
	private bool m_IterationListDirty; // 0x31
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	private static readonly string s_StylePropertyAnimationDescription; // 0x10
	private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker; // 0x18
	private Int64 lastUpdate; // 0x38

	// Methods

	// RVA: 0x1759D0C
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x1759D88
	private static ProfilerMarker get_stylePropertyAnimationProfilerMarker() { }

	// RVA: 0x1759E04
	public void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x1759E74
	public void UnregisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims) { }

	// RVA: 0x175A070
	public void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x175A0E0
	public void RegisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims) { }

	// RVA: 0x175A2DC
	public override void Update() { }

	// RVA: 0x175A7B0
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x175A7B4
	public void .ctor() { }

	// RVA: 0x175A8A0
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualTreeHierarchyFlagsUpdater
{
	// Fields
	private UInt32 m_Version; // 0x20
	private UInt32 m_LastVersion; // 0x24
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8

	// Methods

	// RVA: 0x175A998
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x175AA14
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x175AAFC
	private static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	// RVA: 0x175ABF8
	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	// RVA: 0x175ACA8
	public override void Update() { }

	// RVA: 0x175AD14
	public void .ctor() { }

	// RVA: 0x175AD20
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal enum HierarchyChangeType
{
	// Fields
	public int value__; // 0x10
	public const HierarchyChangeType Add = 0;
	public const HierarchyChangeType Remove = 1;
	public const HierarchyChangeType Move = 2;
}

// Namespace: 
private enum State
{
	// Fields
	public int value__; // 0x10
	public const State Waiting = 0;
	public const State TrackingAddOrMove = 1;
	public const State TrackingRemove = 2;
}

// Namespace: UnityEngine.UIElements
internal abstract class BaseVisualTreeHierarchyTrackerUpdater
{
	// Fields
	private State m_State; // 0x20
	private VisualElement m_CurrentChangeElement; // 0x28
	private VisualElement m_CurrentChangeParent; // 0x30

	// Methods

	// RVA: -1
	protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	// RVA: 0x175ADC8
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x175B160
	public override void Update() { }

	// RVA: 0x175AF50
	private void ProcessNewChange(VisualElement ve) { }

	// RVA: 0x175B0A4
	private void ProcessAddOrMove(VisualElement ve) { }

	// RVA: 0x175B008
	private void ProcessRemove(VisualElement ve) { }

	// RVA: 0x175B218
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class StyleCache
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int64,UnityEngine.UIElements.ComputedStyle> s_ComputedStyleCache; // 0x0
	private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.StyleVariableContext> s_StyleVariableContextCache; // 0x8
	private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.ComputedTransitionProperty[]> s_ComputedTransitionsCache; // 0x10

	// Methods

	// RVA: 0x175B224
	public static bool TryGetValue(Int64 hash, ComputedStyle data) { }

	// RVA: 0x175B2E0
	public static void SetValue(Int64 hash, ComputedStyle data) { }

	// RVA: 0x175B3BC
	public static bool TryGetValue(int hash, StyleVariableContext data) { }

	// RVA: 0x175B478
	public static void SetValue(int hash, StyleVariableContext data) { }

	// RVA: 0x175B534
	public static bool TryGetValue(int hash, ComputedTransitionProperty[] data) { }

	// RVA: 0x175B5F0
	public static void SetValue(int hash, ComputedTransitionProperty[] data) { }

	// RVA: 0x175B6AC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualTreeStyleUpdater
{
	// Fields
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ApplyStyleUpdateList; // 0x20
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_TransitionPropertyUpdateList; // 0x28
	private bool m_IsApplyingStyles; // 0x30
	private UInt32 m_Version; // 0x34
	private UInt32 m_LastVersion; // 0x38
	private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal; // 0x40
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	private bool <disposed>k__BackingField; // 0x48

	// Methods

	// RVA: 0x175B7F8
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x175B874
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x175BA20
	public override void Update() { }

	// RVA: 0x175C410
	protected bool get_disposed() { }

	// RVA: 0x175C418
	private void set_disposed(bool value) { }

	// RVA: 0x175C420
	protected override void Dispose(bool disposing) { }

	// RVA: 0x175BE98
	private void ApplyStyles() { }

	// RVA: 0x175C49C
	public void .ctor() { }

	// RVA: 0x175C7E4
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class StyleMatchingContext
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> m_StyleSheetStack; // 0x10
	public StyleVariableContext variableContext; // 0x18
	public VisualElement currentElement; // 0x20
	public System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult; // 0x28
	public AncestorFilter ancestorFilter; // 0x30

	// Methods

	// RVA: 0x175C88C
	public int get_styleSheetCount() { }

	// RVA: 0x175C8D8
	public void .ctor(System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult) { }

	// RVA: 0x175CA0C
	public void AddStyleSheet(StyleSheet sheet) { }

	// RVA: 0x175CAD8
	public void RemoveStyleSheetRange(int index, int count) { }

	// RVA: 0x175CB44
	public StyleSheet GetStyleSheetAt(int index) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> <>9__24_0; // 0x8

	// Methods

	// RVA: 0x175E844
	private static void .cctor() { }

	// RVA: 0x175E8B0
	public void .ctor() { }

	// RVA: 0x175E8B8
	internal int <ProcessMatchedRules>b__24_0(SelectorMatchRecord a, SelectorMatchRecord b) { }

}

// Namespace: UnityEngine.UIElements
internal class VisualTreeStyleUpdaterTraversal
{
	// Fields
	private StyleVariableContext m_ProcessVarContext; // 0x10
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_UpdateList; // 0x18
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ParentList; // 0x20
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> m_TempMatchResults; // 0x28
	private float <currentPixelsPerPoint>k__BackingField; // 0x30
	private StyleMatchingContext m_StyleMatchingContext; // 0x38
	private StylePropertyReader m_StylePropertyReader; // 0x40
	private readonly System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> m_AnimatedProperties; // 0x48

	// Methods

	// RVA: 0x175CBBC
	private float get_currentPixelsPerPoint() { }

	// RVA: 0x175CBC4
	private void set_currentPixelsPerPoint(float value) { }

	// RVA: 0x175C494
	public void PrepareTraversal(float pixelsPerPoint) { }

	// RVA: 0x175B99C
	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x175BF8C
	public void Clear() { }

	// RVA: 0x175CBCC
	private void PropagateToChildren(VisualElement ve) { }

	// RVA: 0x175CCAC
	private void PropagateToParents(VisualElement ve) { }

	// RVA: 0x175CD5C
	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) { }

	// RVA: 0x175CD90
	public override void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x175E2D8
	private void ProcessTransitions(VisualElement element, ComputedStyle oldStyle, ComputedStyle newStyle) { }

	// RVA: 0x175E3CC
	private void ForceUpdateTransitions(VisualElement element) { }

	// RVA: 0x175C060
	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ComputedStyle newStyle) { }

	// RVA: 0x175D658
	protected bool ShouldSkipElement(VisualElement element) { }

	// RVA: 0x175D6F0
	private ComputedStyle ProcessMatchedRules(VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchingSelectors) { }

	// RVA: 0x175E750
	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x175C590
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal enum VisualTreeUpdatePhase
{
	// Fields
	public int value__; // 0x10
	public const VisualTreeUpdatePhase ViewData = 0;
	public const VisualTreeUpdatePhase Bindings = 1;
	public const VisualTreeUpdatePhase Animation = 2;
	public const VisualTreeUpdatePhase Styles = 3;
	public const VisualTreeUpdatePhase Layout = 4;
	public const VisualTreeUpdatePhase TransformClip = 5;
	public const VisualTreeUpdatePhase Repaint = 6;
	public const VisualTreeUpdatePhase Count = 7;
}

// Namespace: 
private class UpdaterArray
{
	// Fields
	private IVisualTreeUpdater[] m_VisualTreeUpdaters; // 0x10

	// Methods

	// RVA: 0x175E9DC
	public void .ctor() { }

	// RVA: 0x175F034
	public void set_Item(VisualTreeUpdatePhase phase, IVisualTreeUpdater value) { }

	// RVA: 0x175EEBC
	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0x175EC94
	public IVisualTreeUpdater get_Item(int index) { }

}

// Namespace: UnityEngine.UIElements
internal sealed class VisualTreeUpdater
{
	// Fields
	private BaseVisualElementPanel m_Panel; // 0x10
	private UpdaterArray m_UpdaterArray; // 0x18

	// Methods

	// RVA: 0x175E900
	public void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x175EB94
	public void Dispose() { }

	// RVA: 0x175ECC8
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x175EEF0
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x30A24F0
	public void SetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x175EFF8
	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x175EA4C
	private void SetDefaultUpdaters() { }

}

// Namespace: UnityEngine.UIElements
internal interface IVisualTreeUpdater
{
	// Methods

	// RVA: -1
	public abstract void set_panel(BaseVisualElementPanel value) { }

	// RVA: -1
	public abstract ProfilerMarker get_profilerMarker() { }

	// RVA: -1
	public abstract void Update() { }

	// RVA: -1
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class BaseVisualTreeUpdater
{
	// Fields
	private System.Action<UnityEngine.UIElements.BaseVisualElementPanel> panelChanged; // 0x10
	private BaseVisualElementPanel m_Panel; // 0x18

	// Methods

	// RVA: 0x175F0A8
	public void add_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x175F15C
	public void remove_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x175A7A8
	public BaseVisualElementPanel get_panel() { }

	// RVA: 0x175F210
	public void set_panel(BaseVisualElementPanel value) { }

	// RVA: 0x175C46C
	public VisualElement get_visualTree() { }

	// RVA: -1
	public abstract ProfilerMarker get_profilerMarker() { }

	// RVA: 0x175F260
	public void Dispose() { }

	// RVA: 0x175F2F0
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1
	public abstract void Update() { }

	// RVA: -1
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x175A898
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualTreeViewDataUpdater
{
	// Fields
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_UpdateList; // 0x20
	private System.Collections.Generic.HashSet<UnityEngine.UIElements.VisualElement> m_ParentList; // 0x28
	private UInt32 m_Version; // 0x30
	private UInt32 m_LastVersion; // 0x34
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8

	// Methods

	// RVA: 0x175F2F4
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x175F370
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x175F4B4
	public override void Update() { }

	// RVA: 0x175F700
	private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence) { }

	// RVA: 0x175F404
	private void PropagateToParents(VisualElement ve) { }

	// RVA: 0x175F85C
	public void .ctor() { }

	// RVA: 0x175F910
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal struct GfxUpdateBufferRange
{
	// Fields
	public UInt32 offsetFromWriteStart; // 0x10
	public UInt32 size; // 0x14
	public UIntPtr source; // 0x18
}

// Namespace: UnityEngine.UIElements.UIR
internal struct DrawBufferRange
{
	// Fields
	public int firstIndex; // 0x10
	public int indexCount; // 0x14
	public int minIndexVal; // 0x18
	public int vertsReferenced; // 0x1C
}

// Namespace: 
internal enum GPUBufferType
{
	// Fields
	public int value__; // 0x10
	public const GPUBufferType Vertex = 0;
	public const GPUBufferType Index = 1;
}

// Namespace: 
public class GPUBuffer<T0>
{
	// Fields
	private IntPtr buffer; // 0x0
	private int elemCount; // 0x0
	private int elemStride; // 0x0

	// Methods

	// RVA: 0x30A2560
	public void .ctor(int elementCount, GPUBufferType type) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x315B3A8
	public void UpdateRanges(Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax) { }

	// RVA: 0x30A14A4
	public int get_ElementStride() { }

	// RVA: -1
	internal IntPtr get_BufferPointer() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class Utility
{
	// Fields
	private static System.Action<System.Boolean> GraphicsResourcesRecreate; // 0x0
	private static Action EngineUpdate; // 0x8
	private static Action FlushPendingResources; // 0x10
	private static System.Action<UnityEngine.Camera> RegisterIntermediateRenderers; // 0x18
	private static System.Action<System.IntPtr> RenderNodeAdd; // 0x20
	private static System.Action<System.IntPtr> RenderNodeExecute; // 0x28
	private static System.Action<System.IntPtr> RenderNodeCleanup; // 0x30
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x38

	// Methods

	// RVA: 0x315B3A8
	public static void SetVectorArray(MaterialPropertyBlock props, int name, Unity.Collections.NativeSlice<T> vector4s) { }

	// RVA: 0x175F9B8
	public static void add_GraphicsResourcesRecreate(System.Action<System.Boolean> value) { }

	// RVA: 0x175FAC8
	public static void remove_GraphicsResourcesRecreate(System.Action<System.Boolean> value) { }

	// RVA: 0x175FBD8
	public static void add_EngineUpdate(Action value) { }

	// RVA: 0x175FCC8
	public static void remove_EngineUpdate(Action value) { }

	// RVA: 0x175FDB8
	public static void add_FlushPendingResources(Action value) { }

	// RVA: 0x175FEA8
	public static void remove_FlushPendingResources(Action value) { }

	// RVA: 0x175FF98
	public static void add_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x17600AC
	public static void remove_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x17601C0
	public static void add_RenderNodeExecute(System.Action<System.IntPtr> value) { }

	// RVA: 0x17602D4
	public static void remove_RenderNodeExecute(System.Action<System.IntPtr> value) { }

	// RVA: 0x17603E8
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	// RVA: 0x1760490
	internal static void RaiseEngineUpdate() { }

	// RVA: 0x1760568
	internal static void RaiseFlushPendingResources() { }

	// RVA: 0x17605F8
	internal static void RaiseRegisterIntermediateRenderers(Camera camera) { }

	// RVA: 0x176069C
	internal static void RaiseRenderNodeAdd(IntPtr userData) { }

	// RVA: 0x1760744
	internal static void RaiseRenderNodeExecute(IntPtr userData) { }

	// RVA: 0x17607EC
	internal static void RaiseRenderNodeCleanup(IntPtr userData) { }

	// RVA: 0x1760894
	private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) { }

	// RVA: 0x17608EC
	private static void FreeBuffer(IntPtr buffer) { }

	// RVA: 0x176093C
	private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) { }

	// RVA: 0x17609AC
	private static void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count) { }

	// RVA: 0x1760A14
	public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) { }

	// RVA: 0x1760A64
	public static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, UInt64 sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	// RVA: 0x1760C24
	public static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) { }

	// RVA: 0x1760CA4
	public static void SetPropertyBlock(MaterialPropertyBlock props) { }

	// RVA: 0x1760CF4
	public static void SetScissorRect(RectInt scissorRect) { }

	// RVA: 0x1760DF8
	public static void DisableScissor() { }

	// RVA: 0x1760E38
	public static IntPtr CreateStencilState(StencilState stencilState) { }

	// RVA: 0x1760F40
	public static void SetStencilState(IntPtr stencilState, int stencilRef) { }

	// RVA: 0x1760FA8
	public static bool HasMappedBufferRange() { }

	// RVA: 0x1760FE8
	public static UInt32 InsertCPUFence() { }

	// RVA: 0x1761028
	public static bool CPUFencePassed(UInt32 fence) { }

	// RVA: 0x1761078
	public static void WaitForCPUFencePassed(UInt32 fence) { }

	// RVA: 0x17610C8
	public static void SyncRenderThread() { }

	// RVA: 0x1761108
	public static RectInt GetActiveViewport() { }

	// RVA: 0x1761200
	public static void ProfileDrawChainBegin() { }

	// RVA: 0x1761240
	public static void ProfileDrawChainEnd() { }

	// RVA: 0x1761280
	public static void NotifyOfUIREvents(bool subscribe) { }

	// RVA: 0x17612D0
	public static Matrix4x4 GetUnityProjectionMatrix() { }

	// RVA: 0x17613F0
	private static void .cctor() { }

	// RVA: 0x1760B68
	private static void RegisterIntermediateRenderer_Injected(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, UInt64 sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	// RVA: 0x1760DA8
	private static void SetScissorRect_Injected(RectInt scissorRect) { }

	// RVA: 0x1760EF0
	private static IntPtr CreateStencilState_Injected(StencilState stencilState) { }

	// RVA: 0x17611B0
	private static void GetActiveViewport_Injected(RectInt ret) { }

	// RVA: 0x17613A0
	private static void GetUnityProjectionMatrix_Injected(Matrix4x4 ret) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal static class JobProcessor
{
	// Methods

	// RVA: 0x1761470
	internal static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x1761530
	internal static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x17615F0
	internal static JobHandle ScheduleCopyClosingMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x17614D8
	private static void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, JobHandle ret) { }

	// RVA: 0x1761598
	private static void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, JobHandle ret) { }

	// RVA: 0x1761658
	private static void ScheduleCopyClosingMeshJobs_Injected(IntPtr buffer, int jobCount, JobHandle ret) { }

}

// Namespace: 
public class Area
{
	// Fields
	public RectInt rect; // 0x10
	public BestFitAllocator allocator; // 0x20

	// Methods

	// RVA: 0x1762B88
	public void .ctor(RectInt rect) { }

}

// Namespace: 
public class Row
{
	// Fields
	public RectInt rect; // 0x18
	public Area area; // 0x28
	public BestFitAllocator allocator; // 0x30
	public Alloc alloc; // 0x38
	public Row next; // 0x50
	public static readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.Allocator2D.Row> pool; // 0x0

	// Methods

	// RVA: 0x1762C18
	private static Row Create() { }

	// RVA: 0x1762CF8
	private static void Reset(Row row) { }

	// RVA: 0x1762CA4
	public void .ctor() { }

	// RVA: 0x1762D50
	private static void .cctor() { }

}

// Namespace: 
public struct Alloc2D
{
	// Fields
	public RectInt rect; // 0x10
	public Row row; // 0x20
	public Alloc alloc; // 0x28

	// Methods

	// RVA: 0x17624A8
	public void .ctor(Row row, Alloc alloc, int width, int height) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class Allocator2D
{
	// Fields
	private readonly Vector2Int m_MinSize; // 0x10
	private readonly Vector2Int m_MaxSize; // 0x18
	private readonly Vector2Int m_MaxAllocSize; // 0x20
	private readonly int m_RowHeightBias; // 0x28
	private readonly Row[] m_Rows; // 0x30
	private readonly System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> m_Areas; // 0x38

	// Methods

	// RVA: 0x17616B0
	public void .ctor(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	// RVA: 0x1761D9C
	public bool TryAllocate(int width, int height, Alloc2D alloc2D) { }

	// RVA: 0x17626C4
	public void Free(Alloc2D alloc2D) { }

	// RVA: 0x1761988
	private static void BuildAreas(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	// RVA: 0x1761BF4
	private static Vector2Int ComputeMaxAllocSize(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, int rowHeightBias) { }

	// RVA: 0x1761D14
	private static Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class DetachedAllocator
{
	// Fields
	private UnityEngine.UIElements.UIR.TempAllocator<UnityEngine.UIElements.Vertex> m_VertsPool; // 0x10
	private UnityEngine.UIElements.UIR.TempAllocator<System.UInt16> m_IndexPool; // 0x18
	private System.Collections.Generic.List<UnityEngine.UIElements.MeshWriteData> m_MeshWriteDataPool; // 0x20
	private int m_MeshWriteDataCount; // 0x28
	private bool m_Disposed; // 0x2C

	// Methods

	// RVA: 0x1762E90
	public void Dispose() { }

	// RVA: 0x1762F98
	protected void Dispose(bool disposing) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal struct Transform3x4
{
	// Fields
	public Vector4 v0; // 0x10
	public Vector4 v1; // 0x20
	public Vector4 v2; // 0x30
}

// Namespace: UnityEngine.UIElements.UIR
internal class MeshHandle
{
	// Fields
	internal Alloc allocVerts; // 0x18
	internal Alloc allocIndices; // 0x30
	internal UInt32 triangleCount; // 0x48
	internal Page allocPage; // 0x50
	internal UInt32 allocTime; // 0x58
	internal UInt32 updateAllocID; // 0x5C

	// Methods

	// RVA: 0x1763044
	public void .ctor() { }

}

// Namespace: 
internal struct AllocToUpdate
{
	// Fields
	public UInt32 id; // 0x10
	public UInt32 allocTime; // 0x14
	public MeshHandle meshHandle; // 0x18
	public Alloc permAllocVerts; // 0x20
	public Alloc permAllocIndices; // 0x38
	public Page permPage; // 0x50
	public bool copyBackIndices; // 0x58
}

// Namespace: 
private struct AllocToFree
{
	// Fields
	public Alloc alloc; // 0x10
	public Page page; // 0x28
	public bool vertices; // 0x30
}

// Namespace: 
private struct DeviceToFree
{
	// Fields
	public UInt32 handle; // 0x10
	public Page page; // 0x18

	// Methods

	// RVA: 0x1765014
	public void Dispose() { }

}

// Namespace: 
private struct EvaluationState
{
	// Fields
	public MaterialPropertyBlock stateMatProps; // 0x10
	public Material defaultMat; // 0x18
	public State curState; // 0x20
	public Page curPage; // 0x38
	public bool mustApplyMaterial; // 0x40
	public bool mustApplyCommonBlock; // 0x41
	public bool mustApplyStateBlock; // 0x42
	public bool mustApplyStencil; // 0x43
}

// Namespace: 
internal struct DrawStatistics
{
	// Fields
	public int currentFrameIndex; // 0x10
	public UInt32 totalIndices; // 0x14
	public UInt32 commandCount; // 0x18
	public UInt32 drawCommandCount; // 0x1C
	public UInt32 materialSetCount; // 0x20
	public UInt32 drawRangeCount; // 0x24
	public UInt32 drawRangeCallCount; // 0x28
	public UInt32 immediateDraws; // 0x2C
	public UInt32 stencilRefChanges; // 0x30
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.UIRenderDevice.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.UIR.MeshHandle> <>9__50_0; // 0x8
	public static System.Action<UnityEngine.UIElements.UIR.MeshHandle> <>9__50_1; // 0x10

	// Methods

	// RVA: 0x176B230
	private static void .cctor() { }

	// RVA: 0x176B29C
	public void .ctor() { }

	// RVA: 0x176B2A4
	internal MeshHandle <.ctor>b__50_0() { }

	// RVA: 0x176B330
	internal void <.ctor>b__50_1(MeshHandle mh) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class UIRenderDevice
{
	// Fields
	private readonly bool m_MockDevice; // 0x10
	private IntPtr m_DefaultStencilState; // 0x18
	private IntPtr m_VertexDecl; // 0x20
	private Page m_FirstPage; // 0x28
	private UInt32 m_NextPageVertexCount; // 0x30
	private UInt32 m_LargeMeshVertexCount; // 0x34
	private float m_IndexToVertexCountRatio; // 0x38
	private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToFree>> m_DeferredFrees; // 0x40
	private System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate>> m_Updates; // 0x48
	private UInt32[] m_Fences; // 0x50
	private MaterialPropertyBlock m_StandardMatProps; // 0x58
	private UInt32 m_FrameIndex; // 0x60
	private UInt32 m_NextUpdateID; // 0x64
	private DrawStatistics m_DrawStats; // 0x68
	private readonly UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.MeshHandle> m_MeshHandles; // 0x90
	private readonly DrawParams m_DrawParams; // 0x98
	private readonly TextureSlotManager m_TextureSlotManager; // 0xA0
	private static System.Collections.Generic.LinkedList<UnityEngine.UIElements.UIR.UIRenderDevice.DeviceToFree> m_DeviceFreeQueue; // 0x0
	private static int m_ActiveDeviceCount; // 0x8
	private static bool m_SubscribedToNotifications; // 0xC
	private static bool m_SynchronousFree; // 0xD
	private static readonly int s_GradientSettingsTexID; // 0x10
	private static readonly int s_ShaderInfoTexID; // 0x14
	private static readonly int s_TransformsPropID; // 0x18
	private static readonly int s_ClipRectsPropID; // 0x1C
	private static ProfilerMarker s_MarkerAllocate; // 0x20
	private static ProfilerMarker s_MarkerFree; // 0x28
	private static ProfilerMarker s_MarkerAdvanceFrame; // 0x30
	private static ProfilerMarker s_MarkerFence; // 0x38
	private static ProfilerMarker s_MarkerBeforeDraw; // 0x40
	private static System.Nullable<System.Boolean> s_VertexTexturingIsAvailable; // 0x48
	private static System.Nullable<System.Boolean> s_ShaderModelIs35; // 0x4A
	private readonly UInt32 <maxVerticesPerPage>k__BackingField; // 0xA8
	private bool <breakBatches>k__BackingField; // 0xAC
	private static Texture2D s_DefaultShaderInfoTexFloat; // 0x50
	private static Texture2D s_DefaultShaderInfoTexARGB8; // 0x58
	private bool <disposed>k__BackingField; // 0xAD

	// Methods

	// RVA: 0x1763098
	internal UInt32 get_maxVerticesPerPage() { }

	// RVA: 0x17630A0
	internal bool get_breakBatches() { }

	// RVA: 0x17630A8
	internal void set_breakBatches(bool value) { }

	// RVA: 0x17630B0
	private static void .cctor() { }

	// RVA: 0x17633E0
	public void .ctor(UInt32 initialVertexCapacity, UInt32 initialIndexCapacity) { }

	// RVA: 0x17633E8
	protected void .ctor(UInt32 initialVertexCapacity, UInt32 initialIndexCapacity, bool mockDevice) { }

	// RVA: 0x1763C60
	internal static Texture2D get_defaultShaderInfoTexFloat() { }

	// RVA: 0x1764048
	internal static Texture2D get_defaultShaderInfoTexARGB8() { }

	// RVA: 0x1764378
	internal static bool get_vertexTexturingIsAvailable() { }

	// RVA: 0x17645B4
	internal static bool get_shaderModelIs35() { }

	// RVA: 0x17647F0
	private void InitVertexDeclaration() { }

	// RVA: 0x1764AC4
	private void CompleteCreation() { }

	// RVA: 0x1764D14
	private bool get_fullyCreated() { }

	// RVA: 0x1764D24
	protected bool get_disposed() { }

	// RVA: 0x1764D2C
	private void set_disposed(bool value) { }

	// RVA: 0x1764D34
	public void Dispose() { }

	// RVA: 0x1764DC4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1765708
	public MeshHandle Allocate(UInt32 vertexCount, UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, UInt16 indexOffset) { }

	// RVA: 0x1765F40
	public void Update(MeshHandle mesh, UInt32 vertexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData) { }

	// RVA: 0x1766750
	public void Update(MeshHandle mesh, UInt32 vertexCount, UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, UInt16 indexOffset) { }

	// RVA: 0x1766900
	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	// RVA: 0x1766A68
	internal System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	// RVA: 0x1766AFC
	private bool TryAllocFromPage(Page page, UInt32 vertexCount, UInt32 indexCount, Alloc va, Alloc ia, bool shortLived) { }

	// RVA: 0x17657D4
	private void Allocate(MeshHandle meshHandle, UInt32 vertexCount, UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, bool shortLived) { }

	// RVA: 0x1766138
	private void UpdateAfterGPUUsedData(MeshHandle mesh, UInt32 vertexCount, UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, UInt16 indexOffset, AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	// RVA: 0x176706C
	public void Free(MeshHandle mesh) { }

	// RVA: 0x1767660
	public void OnFrameRenderingBegin() { }

	// RVA: 0x315B3A8
	internal static Unity.Collections.NativeSlice<T> PtrToSlice(Void* p, int count) { }

	// RVA: 0x17683A8
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, EvaluationState st) { }

	// RVA: 0x1768598
	private void ApplyBatchState(EvaluationState st, bool allowMaterialChange) { }

	// RVA: 0x17687A0
	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transforms, Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, Exception immediateException) { }

	// RVA: 0x176A96C
	private void UpdateFenceValue() { }

	// RVA: 0x17698B4
	private void KickRanges(DrawBufferRange* ranges, int rangesReady, int rangesStart, int rangesCount, Page curPage) { }

	// RVA: 0x315B3A8
	private void DrawRanges(UnityEngine.UIElements.UIR.Utility.GPUBuffer<I> ib, UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> vb, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.DrawBufferRange> ranges) { }

	// RVA: 0x176AA70
	private void WaitOnCpuFence(UInt32 fence) { }

	// RVA: 0x1767784
	public void AdvanceFrame() { }

	// RVA: 0x176ABB4
	private void PruneUnusedPages() { }

	// RVA: 0x176ADF4
	internal static void PrepareForGfxDeviceRecreate() { }

	// RVA: 0x176AFF8
	internal static void WrapUpGfxDeviceRecreate() { }

	// RVA: 0x176B05C
	internal static void FlushAllPendingDeviceDisposes() { }

	// RVA: 0x176B12C
	internal DrawStatistics GatherDrawStatistics() { }

	// RVA: 0x17650D0
	private static void ProcessDeviceFreeQueue() { }

	// RVA: 0x176B144
	private static void OnEngineUpdateGlobal() { }

	// RVA: 0x176B1AC
	private static void OnFlushPendingResources() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal struct Alloc
{
	// Fields
	public UInt32 start; // 0x10
	public UInt32 size; // 0x14
	internal object handle; // 0x18
	internal bool shortLived; // 0x20
}

// Namespace: 
private class BlockPool
{
	// Methods

	// RVA: 0x176B71C
	private static Block CreateBlock() { }

	// RVA: 0x176B7FC
	private static void ResetBlock(Block block) { }

	// RVA: 0x176B334
	public void .ctor() { }

}

// Namespace: 
private class Block
{
	// Fields
	public UInt32 start; // 0x18
	public UInt32 end; // 0x1C
	public Block prev; // 0x20
	public Block next; // 0x28
	public Block prevAvailable; // 0x30
	public Block nextAvailable; // 0x38
	public bool allocated; // 0x40

	// Methods

	// RVA: 0x176B478
	public UInt32 get_size() { }

	// RVA: 0x176B7A8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class BestFitAllocator
{
	// Fields
	private readonly UInt32 <totalSize>k__BackingField; // 0x10
	private Block m_FirstBlock; // 0x18
	private Block m_FirstAvailableBlock; // 0x20
	private BlockPool m_BlockPool; // 0x28
	private UInt32 m_HighWatermark; // 0x30

	// Methods

	// RVA: 0x17625E4
	public void .ctor(UInt32 size) { }

	// RVA: 0x176B42C
	public UInt32 get_totalSize() { }

	// RVA: 0x1762B80
	public UInt32 get_highWatermark() { }

	// RVA: 0x1762288
	public Alloc Allocate(UInt32 size) { }

	// RVA: 0x17628DC
	public void Free(Alloc alloc) { }

	// RVA: 0x176B5F4
	private Block CoalesceBlockWithPrevious(Block block) { }

	// RVA: 0x176B434
	private Block BestFitFindAvailableBlock(UInt32 size) { }

	// RVA: 0x176B484
	private void SplitBlock(Block block, UInt32 size) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class GPUBufferAllocator
{
	// Fields
	private BestFitAllocator m_Low; // 0x10
	private BestFitAllocator m_High; // 0x18

	// Methods

	// RVA: 0x176B800
	public void .ctor(UInt32 maxSize) { }

	// RVA: 0x1766C78
	public Alloc Allocate(UInt32 size, bool shortLived) { }

	// RVA: 0x1766DEC
	public void Free(Alloc alloc) { }

	// RVA: 0x176B8DC
	public bool get_isEmpty() { }

	// RVA: 0x176B8A0
	private bool HighLowCollide() { }

}

// Namespace: 
public class DataSet<T0>
{
	// Fields
	private bool <disposed>k__BackingField; // 0x0
	public UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> gpuData; // 0x0
	public Unity.Collections.NativeArray<T> cpuData; // 0x0
	public Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> updateRanges; // 0x0
	public GPUBufferAllocator allocator; // 0x0
	private readonly UInt32 m_UpdateRangePoolSize; // 0x0
	private UInt32 m_ElemStride; // 0x0
	private UInt32 m_UpdateRangeMin; // 0x0
	private UInt32 m_UpdateRangeMax; // 0x0
	private UInt32 m_UpdateRangesEnqueued; // 0x0
	private UInt32 m_UpdateRangesBatchStart; // 0x0
	private bool m_UpdateRangesSaturated; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public void .ctor(GPUBufferType bufferType, UInt32 totalCount, UInt32 maxQueuedFrameCount, UInt32 updateRangePoolSize, bool mockBuffer) { }

	// RVA: 0x30A1224
	protected bool get_disposed() { }

	// RVA: 0x30A2404
	private void set_disposed(bool value) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A2404
	public void Dispose(bool disposing) { }

	// RVA: 0x315B3A8
	public void RegisterUpdate(UInt32 start, UInt32 size) { }

	// RVA: 0x30A1224
	private bool HasMappedBufferRange() { }

	// RVA: 0x30A2378
	public void SendUpdates() { }

	// RVA: 0x30A2378
	public void SendFullRange() { }

	// RVA: 0x30A2378
	public void SendPartialRanges() { }

	// RVA: 0x30A2378
	private void ResetUpdateState() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class Page
{
	// Fields
	private bool <disposed>k__BackingField; // 0x10
	public UnityEngine.UIElements.UIR.Page.DataSet<UnityEngine.UIElements.Vertex> vertices; // 0x18
	public UnityEngine.UIElements.UIR.Page.DataSet<System.UInt16> indices; // 0x20
	public Page next; // 0x28
	public int framesEmpty; // 0x30

	// Methods

	// RVA: 0x1766E70
	public void .ctor(UInt32 vertexMaxCount, UInt32 indexMaxCount, UInt32 maxQueuedFrameCount, bool mockPage) { }

	// RVA: 0x176B920
	protected bool get_disposed() { }

	// RVA: 0x176B928
	private void set_disposed(bool value) { }

	// RVA: 0x176AD64
	public void Dispose() { }

	// RVA: 0x176B930
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1766FD0
	public bool get_isEmpty() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal enum VertexFlags
{
	// Fields
	public int value__; // 0x10
	public const VertexFlags IsSolid = 0;
	public const VertexFlags IsText = 1;
	public const VertexFlags IsTextured = 2;
	public const VertexFlags IsDynamic = 3;
	public const VertexFlags IsSvgGradients = 4;
	public const VertexFlags LastType = 10;
	public const VertexFlags IsGraphViewEdge = 10;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct State
{
	// Fields
	public Material material; // 0x10
	public TextureId texture; // 0x18
	public int stencilRef; // 0x1C
	public float sdfScale; // 0x20
}

// Namespace: UnityEngine.UIElements.UIR
internal enum CommandType
{
	// Fields
	public int value__; // 0x10
	public const CommandType Draw = 0;
	public const CommandType ImmediateCull = 1;
	public const CommandType Immediate = 2;
	public const CommandType PushView = 3;
	public const CommandType PopView = 4;
	public const CommandType PushScissor = 5;
	public const CommandType PopScissor = 6;
	public const CommandType PushRenderTexture = 7;
	public const CommandType PopRenderTexture = 8;
	public const CommandType BlitToPreviousRT = 9;
	public const CommandType PushDefaultMaterial = 10;
	public const CommandType PopDefaultMaterial = 11;
}

// Namespace: UnityEngine.UIElements.UIR
internal class DrawParams
{
	// Fields
	internal static readonly Rect k_UnlimitedRect; // 0x0
	internal static readonly Rect k_FullNormalizedRect; // 0x10
	internal readonly System.Collections.Generic.Stack<UnityEngine.Matrix4x4> view; // 0x10
	internal readonly System.Collections.Generic.Stack<UnityEngine.Rect> scissor; // 0x18
	internal readonly System.Collections.Generic.List<UnityEngine.RenderTexture> renderTexture; // 0x20
	internal readonly System.Collections.Generic.List<UnityEngine.Material> defaultMaterial; // 0x28

	// Methods

	// RVA: 0x176948C
	public void Reset() { }

	// RVA: 0x1763AC8
	public void .ctor() { }

	// RVA: 0x176B9DC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class RenderChainCommand
{
	// Fields
	internal VisualElement owner; // 0x18
	internal RenderChainCommand prev; // 0x20
	internal RenderChainCommand next; // 0x28
	internal bool closing; // 0x30
	internal CommandType type; // 0x34
	internal State state; // 0x38
	internal MeshHandle mesh; // 0x50
	internal int indexOffset; // 0x58
	internal int indexCount; // 0x5C
	internal Action callback; // 0x60
	private static readonly int k_ID_MainTex; // 0x0
	private static ProfilerMarker s_ImmediateOverheadMarker; // 0x8

	// Methods

	// RVA: 0x176BA38
	internal void Reset() { }

	// RVA: 0x1769B0C
	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, Exception immediateException) { }

	// RVA: 0x176C0A4
	private void Blit(Texture source, RenderTexture destination, float depth) { }

	// RVA: 0x176BF90
	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	// RVA: 0x176BAB0
	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	// RVA: 0x176C21C
	public void .ctor() { }

	// RVA: 0x176C270
	private static void .cctor() { }

}

// Namespace: 
private struct RawTexture
{
	// Fields
	public Color32[] rgba; // 0x10
	public int width; // 0x18
	public int height; // 0x1C

	// Methods

	// RVA: 0x176CC80
	public void WriteRawInt2Packed(int v0, int v1, int destX, int destY) { }

	// RVA: 0x176CBC0
	public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientSettingsAtlas
{
	// Fields
	private static ProfilerMarker s_MarkerWrite; // 0x0
	private static ProfilerMarker s_MarkerCommit; // 0x8
	private readonly int m_Length; // 0x10
	private readonly int m_ElemWidth; // 0x14
	private BestFitAllocator m_Allocator; // 0x18
	private Texture2D m_Atlas; // 0x20
	private RawTexture m_RawAtlas; // 0x28
	private static int s_TextureCounter; // 0x10
	private bool <disposed>k__BackingField; // 0x38
	private bool <MustCommit>k__BackingField; // 0x39

	// Methods

	// RVA: 0x176C31C
	internal int get_length() { }

	// RVA: 0x176C324
	protected bool get_disposed() { }

	// RVA: 0x176C32C
	private void set_disposed(bool value) { }

	// RVA: 0x176C334
	public void Dispose() { }

	// RVA: 0x176C3C4
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x176C460
	public void .ctor(int length) { }

	// RVA: 0x176C494
	public void Reset() { }

	// RVA: 0x176C568
	public Texture2D get_atlas() { }

	// RVA: 0x176C570
	public Alloc Add(int count) { }

	// RVA: 0x176C680
	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) { }

	// RVA: 0x176CD04
	public bool get_MustCommit() { }

	// RVA: 0x176CD0C
	private void set_MustCommit(bool value) { }

	// RVA: 0x176CD14
	public void Commit() { }

	// RVA: 0x176CDE8
	private void PrepareAtlas() { }

	// RVA: 0x176CF98
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class JobManager
{
	// Fields
	private UnityEngine.UIElements.UIR.NativePagedList<UnityEngine.UIElements.UIR.NudgeJobData> m_NudgeJobs; // 0x10
	private UnityEngine.UIElements.UIR.NativePagedList<UnityEngine.UIElements.UIR.ConvertMeshJobData> m_ConvertMeshJobs; // 0x18
	private UnityEngine.UIElements.UIR.NativePagedList<UnityEngine.UIElements.UIR.CopyClosingMeshJobData> m_CopyClosingMeshJobs; // 0x20
	private JobMerger m_JobMerger; // 0x28
	private bool <disposed>k__BackingField; // 0x30

	// Methods

	// RVA: 0x176D050
	public void Add(NudgeJobData job) { }

	// RVA: 0x176D0B4
	public void Add(ConvertMeshJobData job) { }

	// RVA: 0x176D118
	public void Add(CopyClosingMeshJobData job) { }

	// RVA: 0x176D17C
	public void CompleteNudgeJobs() { }

	// RVA: 0x176D648
	public void CompleteConvertMeshJobs() { }

	// RVA: 0x176D9EC
	public void CompleteClosingMeshJobs() { }

	// RVA: 0x176DD90
	protected bool get_disposed() { }

	// RVA: 0x176DD98
	private void set_disposed(bool value) { }

	// RVA: 0x176DDA0
	public void Dispose() { }

	// RVA: 0x176DE40
	protected void Dispose(bool disposing) { }

	// RVA: 0x176E0A8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal struct NudgeJobData
{
	// Fields
	public IntPtr src; // 0x10
	public IntPtr dst; // 0x18
	public int count; // 0x20
	public IntPtr closingSrc; // 0x28
	public IntPtr closingDst; // 0x30
	public int closingCount; // 0x38
	public Matrix4x4 transform; // 0x3C
	public int vertsBeforeUVDisplacement; // 0x7C
	public int vertsAfterUVDisplacement; // 0x80
}

// Namespace: UnityEngine.UIElements.UIR
internal struct ConvertMeshJobData
{
	// Fields
	public IntPtr vertSrc; // 0x10
	public IntPtr vertDst; // 0x18
	public int vertCount; // 0x20
	public Matrix4x4 transform; // 0x24
	public int transformUVs; // 0x64
	public Color32 xformClipPages; // 0x68
	public Color32 ids; // 0x6C
	public Color32 addFlags; // 0x70
	public Color32 opacityPage; // 0x74
	public Color32 textCoreSettingsPage; // 0x78
	public int isText; // 0x7C
	public float textureId; // 0x80
	public IntPtr indexSrc; // 0x88
	public IntPtr indexDst; // 0x90
	public int indexCount; // 0x98
	public int indexOffset; // 0x9C
	public int flipIndices; // 0xA0
}

// Namespace: UnityEngine.UIElements.UIR
internal struct CopyClosingMeshJobData
{
	// Fields
	public IntPtr vertSrc; // 0x10
	public IntPtr vertDst; // 0x18
	public int vertCount; // 0x20
	public IntPtr indexSrc; // 0x28
	public IntPtr indexDst; // 0x30
	public int indexCount; // 0x38
	public int indexOffset; // 0x3C
}

// Namespace: UnityEngine.UIElements.UIR
internal class JobMerger
{
	// Fields
	private Unity.Collections.NativeArray<Unity.Jobs.JobHandle> m_Jobs; // 0x10
	private int m_JobCount; // 0x20
	private bool <disposed>k__BackingField; // 0x24

	// Methods

	// RVA: 0x176E228
	public void .ctor(int capacity) { }

	// RVA: 0x176D520
	public void Add(JobHandle job) { }

	// RVA: 0x176D5A4
	public JobHandle MergeAndReset() { }

	// RVA: 0x176E2E4
	protected bool get_disposed() { }

	// RVA: 0x176E2EC
	private void set_disposed(bool value) { }

	// RVA: 0x176DFCC
	public void Dispose() { }

	// RVA: 0x176E2F4
	protected void Dispose(bool disposing) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class LinkedPoolItem<T0>
{
	// Fields
	internal T poolNext; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class LinkedPool<T0>
{
	// Fields
	private readonly System.Func<T> m_CreateFunc; // 0x0
	private readonly System.Action<T> m_ResetAction; // 0x0
	private readonly int m_Limit; // 0x0
	private T m_PoolFirst; // 0x0
	private int <Count>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A2A8C
	public void .ctor(System.Func<T> createFunc, System.Action<T> resetAction, int limit) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A24F0
	private void set_Count(int value) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public T Get() { }

	// RVA: 0x315B3A8
	public void Return(T item) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNode<T0>
{
	// Fields
	public UnityEngine.UIElements.UIR.BasicNode<T> next; // 0x0
	public T data; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void InsertFirst(UnityEngine.UIElements.UIR.BasicNode<T>& first) { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNodePool<T0>
{
	// Methods

	// RVA: 0x30A7C50
	private static void Reset(UnityEngine.UIElements.UIR.BasicNode<T> node) { }

	// RVA: 0x30A5298
	private static UnityEngine.UIElements.UIR.BasicNode<T> Create() { }

	// RVA: 0x30A2378
	public void .ctor() { }

}

// Namespace: 
internal sealed class Allocator
{
	// Methods

	// RVA: 0x176EC88
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x176ED2C
	public virtual MeshWriteData Invoke(UInt32 vertexCount, UInt32 indexCount, AllocMeshData allocatorData) { }

}

// Namespace: 
internal struct AllocMeshData
{
	// Fields
	internal Allocator alloc; // 0x10
	internal Texture texture; // 0x18
	internal TextureId svgTexture; // 0x20
	internal Material material; // 0x28
	internal MeshFlags flags; // 0x30
	internal BMPAlloc colorAlloc; // 0x34

	// Methods

	// RVA: 0x176EB24
	internal MeshWriteData Allocate(UInt32 vertexCount, UInt32 indexCount) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal static class MeshBuilder
{
	// Fields
	private static ProfilerMarker s_VectorGraphics9Slice; // 0x0
	private static ProfilerMarker s_VectorGraphicsSplitTriangle; // 0x8
	private static ProfilerMarker s_VectorGraphicsScaleTriangle; // 0x10
	private static ProfilerMarker s_VectorGraphicsStretch; // 0x18
	internal static readonly int s_MaxTextMeshVertices; // 0x20

	// Methods

	// RVA: 0x176E37C
	private static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags, bool isDynamicColor) { }

	// RVA: 0x176E464
	private static int LimitTextVertices(int vertexCount, bool logTruncation) { }

	// RVA: 0x176E5CC
	internal static void MakeText(MeshInfo meshInfo, Vector2 offset, AllocMeshData meshAlloc, VertexFlags flags, bool isDynamicColor) { }

	// RVA: 0x176EB50
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class NativePagedList<T0>
{
	// Fields
	private readonly int k_PoolCapacity; // 0x0
	private System.Collections.Generic.List<Unity.Collections.NativeArray<T>> m_Pages; // 0x0
	private Unity.Collections.NativeArray<T> m_CurrentPage; // 0x0
	private int m_CurrentPageCount; // 0x0
	private System.Collections.Generic.List<Unity.Collections.NativeSlice<T>> m_Enumerator; // 0x0
	private bool <disposed>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A24F0
	public void .ctor(int poolCapacity) { }

	// RVA: 0x30A27C0
	public void Add(T data) { }

	// RVA: 0x30A17DC
	public System.Collections.Generic.List<Unity.Collections.NativeSlice<T>> GetPages() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x30A1224
	protected bool get_disposed() { }

	// RVA: 0x30A2404
	private void set_disposed(bool value) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A2404
	protected void Dispose(bool disposing) { }

}

// Namespace: 
private struct OpacityIdUpdateJob
{
	// Fields
	public Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> oldVerts; // 0x10
	public Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> newVerts; // 0x20
	public Color32 opacityData; // 0x30

	// Methods

	// RVA: 0x176F088
	public void Execute(int i) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class OpacityIdAccelerator
{
	// Fields
	private Unity.Collections.NativeArray<Unity.Jobs.JobHandle> m_Jobs; // 0x10
	private int m_NextJobIndex; // 0x20
	private bool <disposed>k__BackingField; // 0x24

	// Methods

	// RVA: 0x176ED40
	public void CreateJob(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> oldVerts, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	// RVA: 0x176EE40
	public void CompleteJobs() { }

	// RVA: 0x176EEDC
	protected bool get_disposed() { }

	// RVA: 0x176EEE4
	private void set_disposed(bool value) { }

	// RVA: 0x176EEEC
	public void Dispose() { }

	// RVA: 0x176EF7C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x176F004
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal struct ChainBuilderStats
{
	// Fields
	public UInt32 elementsAdded; // 0x10
	public UInt32 elementsRemoved; // 0x14
	public UInt32 recursiveClipUpdates; // 0x18
	public UInt32 recursiveClipUpdatesExpanded; // 0x1C
	public UInt32 nonRecursiveClipUpdates; // 0x20
	public UInt32 recursiveTransformUpdates; // 0x24
	public UInt32 recursiveTransformUpdatesExpanded; // 0x28
	public UInt32 recursiveOpacityUpdates; // 0x2C
	public UInt32 recursiveOpacityUpdatesExpanded; // 0x30
	public UInt32 opacityIdUpdates; // 0x34
	public UInt32 colorUpdates; // 0x38
	public UInt32 colorUpdatesExpanded; // 0x3C
	public UInt32 recursiveVisualUpdates; // 0x40
	public UInt32 recursiveVisualUpdatesExpanded; // 0x44
	public UInt32 nonRecursiveVisualUpdates; // 0x48
	public UInt32 dirtyProcessed; // 0x4C
	public UInt32 nudgeTransformed; // 0x50
	public UInt32 boneTransformed; // 0x54
	public UInt32 skipTransformed; // 0x58
	public UInt32 visualUpdateTransformed; // 0x5C
	public UInt32 updatedMeshAllocations; // 0x60
	public UInt32 newMeshAllocations; // 0x64
	public UInt32 groupTransformElementsChanged; // 0x68
	public UInt32 immedateRenderersActive; // 0x6C
}

// Namespace: 
private struct DepthOrderedDirtyTracking
{
	// Fields
	public System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> heads; // 0x10
	public System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> tails; // 0x18
	public int[] minDepths; // 0x20
	public int[] maxDepths; // 0x28
	public UInt32 dirtyID; // 0x30

	// Methods

	// RVA: 0x1773920
	public void EnsureFits(int maxDepth) { }

	// RVA: 0x17739BC
	public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) { }

	// RVA: 0x1773BE0
	public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse) { }

	// RVA: 0x1773DC8
	public void Reset() { }

}

// Namespace: 
private struct RenderChainStaticIndexAllocator
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain> renderChains; // 0x0

	// Methods

	// RVA: 0x1773EB0
	public static int AllocateIndex(RenderChain renderChain) { }

	// RVA: 0x1774008
	public static void FreeIndex(int index) { }

	// RVA: 0x17740B0
	public static RenderChain AccessIndex(int index) { }

	// RVA: 0x1774168
	private static void .cctor() { }

}

// Namespace: 
private struct RenderNodeData
{
	// Fields
	public Material standardMaterial; // 0x10
	public Material initialMaterial; // 0x18
	public MaterialPropertyBlock matPropBlock; // 0x20
	public RenderChainCommand firstCommand; // 0x28
	public UIRenderDevice device; // 0x30
	public Texture vectorAtlas; // 0x38
	public Texture shaderInfoAtlas; // 0x40
	public float dpiScale; // 0x48
	public Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transformConstants; // 0x50
	public Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRectConstants; // 0x60
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.RenderChain.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.UIR.RenderChainCommand> <>9__34_0; // 0x8
	public static System.Action<UnityEngine.UIElements.UIR.RenderChainCommand> <>9__34_1; // 0x10

	// Methods

	// RVA: 0x1774208
	private static void .cctor() { }

	// RVA: 0x1774274
	public void .ctor() { }

	// RVA: 0x177427C
	internal RenderChainCommand <.ctor>b__34_0() { }

	// RVA: 0x17742D4
	internal void <.ctor>b__34_1(RenderChainCommand cmd) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class RenderChain
{
	// Fields
	private RenderChainCommand m_FirstCommand; // 0x10
	private DepthOrderedDirtyTracking m_DirtyTracker; // 0x18
	private UnityEngine.UIElements.UIR.LinkedPool<UnityEngine.UIElements.UIR.RenderChainCommand> m_CommandPool; // 0x40
	private UnityEngine.UIElements.UIR.BasicNodePool<UnityEngine.UIElements.UIR.TextureEntry> m_TexturePool; // 0x48
	private System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain.RenderNodeData> m_RenderNodesData; // 0x50
	private Shader m_DefaultShader; // 0x58
	private Shader m_DefaultWorldSpaceShader; // 0x60
	private Material m_DefaultMat; // 0x68
	private Material m_DefaultWorldSpaceMat; // 0x70
	private bool m_BlockDirtyRegistration; // 0x78
	private int m_StaticIndex; // 0x7C
	private int m_ActiveRenderNodes; // 0x80
	private int m_CustomMaterialCommands; // 0x84
	private ChainBuilderStats m_Stats; // 0x88
	private UInt32 m_StatsElementsAdded; // 0xE8
	private UInt32 m_StatsElementsRemoved; // 0xEC
	private TextureRegistry m_TextureRegistry; // 0xF0
	private OpacityIdAccelerator <opacityIdAccelerator>k__BackingField; // 0xF8
	private static ProfilerMarker s_MarkerProcess; // 0x0
	private static ProfilerMarker s_MarkerClipProcessing; // 0x8
	private static ProfilerMarker s_MarkerOpacityProcessing; // 0x10
	private static ProfilerMarker s_MarkerColorsProcessing; // 0x18
	private static ProfilerMarker s_MarkerTransformProcessing; // 0x20
	private static ProfilerMarker s_MarkerVisualsProcessing; // 0x28
	private static ProfilerMarker s_MarkerTextRegen; // 0x30
	private bool <disposed>k__BackingField; // 0x100
	internal static Action OnPreRender; // 0x38
	private BaseVisualElementPanel <panel>k__BackingField; // 0x108
	private UIRenderDevice <device>k__BackingField; // 0x110
	private AtlasBase <atlas>k__BackingField; // 0x118
	private VectorImageManager <vectorImageManager>k__BackingField; // 0x120
	private UnityEngine.UIElements.UIR.TempAllocator<UnityEngine.UIElements.Vertex> <vertsPool>k__BackingField; // 0x128
	private UnityEngine.UIElements.UIR.TempAllocator<System.UInt16> <indicesPool>k__BackingField; // 0x130
	private JobManager <jobManager>k__BackingField; // 0x138
	internal UIRVEShaderInfoAllocator shaderInfoAllocator; // 0x140
	private UIRStylePainter <painter>k__BackingField; // 0x210
	private bool <drawStats>k__BackingField; // 0x218
	private bool <drawInCameras>k__BackingField; // 0x219

	// Methods

	// RVA: 0x176F164
	public OpacityIdAccelerator get_opacityIdAccelerator() { }

	// RVA: 0x176F16C
	private void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	// RVA: 0x176F174
	private static void .cctor() { }

	// RVA: 0x176F424
	public void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x176F810
	private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan) { }

	// RVA: 0x176FCF0
	private void Destructor() { }

	// RVA: 0x1770384
	protected bool get_disposed() { }

	// RVA: 0x177038C
	private void set_disposed(bool value) { }

	// RVA: 0x1770394
	public void Dispose() { }

	// RVA: 0x1770438
	protected void Dispose(bool disposing) { }

	// RVA: 0x177047C
	public void ProcessChanges() { }

	// RVA: 0x1770C58
	public void Render() { }

	// RVA: 0x1771AF8
	public void UIEOnChildAdded(VisualElement ve) { }

	// RVA: 0x1771EB8
	public void UIEOnChildrenReordered(VisualElement ve) { }

	// RVA: 0x177207C
	public void UIEOnChildRemoving(VisualElement ve) { }

	// RVA: 0x1772184
	public void UIEOnRenderHintsChanged(VisualElement ve) { }

	// RVA: 0x1771CD8
	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x1771D78
	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x177226C
	public void UIEOnColorChanged(VisualElement ve) { }

	// RVA: 0x1772300
	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	// RVA: 0x1771E18
	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x17723A0
	public void UIEOnOpacityIdChanged(VisualElement ve) { }

	// RVA: 0x1772434
	internal BaseVisualElementPanel get_panel() { }

	// RVA: 0x177243C
	private void set_panel(BaseVisualElementPanel value) { }

	// RVA: 0x177244C
	internal UIRenderDevice get_device() { }

	// RVA: 0x1772454
	private void set_device(UIRenderDevice value) { }

	// RVA: 0x1772464
	internal AtlasBase get_atlas() { }

	// RVA: 0x177246C
	private void set_atlas(AtlasBase value) { }

	// RVA: 0x177247C
	internal VectorImageManager get_vectorImageManager() { }

	// RVA: 0x1772484
	private void set_vectorImageManager(VectorImageManager value) { }

	// RVA: 0x1772494
	internal UnityEngine.UIElements.UIR.TempAllocator<UnityEngine.UIElements.Vertex> get_vertsPool() { }

	// RVA: 0x177249C
	private void set_vertsPool(UnityEngine.UIElements.UIR.TempAllocator<UnityEngine.UIElements.Vertex> value) { }

	// RVA: 0x17724AC
	internal UnityEngine.UIElements.UIR.TempAllocator<System.UInt16> get_indicesPool() { }

	// RVA: 0x17724B4
	private void set_indicesPool(UnityEngine.UIElements.UIR.TempAllocator<System.UInt16> value) { }

	// RVA: 0x17724C4
	internal JobManager get_jobManager() { }

	// RVA: 0x17724CC
	private void set_jobManager(JobManager value) { }

	// RVA: 0x17724DC
	internal UIRStylePainter get_painter() { }

	// RVA: 0x17724E4
	private void set_painter(UIRStylePainter value) { }

	// RVA: 0x17724F4
	internal bool get_drawStats() { }

	// RVA: 0x17724FC
	internal void set_drawStats(bool value) { }

	// RVA: 0x1772504
	internal bool get_drawInCameras() { }

	// RVA: 0x177250C
	private void set_drawInCameras(bool value) { }

	// RVA: 0x1772514
	internal void set_defaultShader(Shader value) { }

	// RVA: 0x1772624
	internal void set_defaultWorldSpaceShader(Shader value) { }

	// RVA: 0x1770F94
	internal Material GetStandardMaterial() { }

	// RVA: 0x1772734
	internal Material GetStandardWorldSpaceMaterial() { }

	// RVA: 0x1772894
	internal void EnsureFitsDepth(int depth) { }

	// RVA: 0x17728A0
	internal void ChildWillBeRemoved(VisualElement ve) { }

	// RVA: 0x1772970
	internal RenderChainCommand AllocCommand() { }

	// RVA: 0x1772A34
	internal void FreeCommand(RenderChainCommand cmd) { }

	// RVA: 0x1772B60
	internal void OnRenderCommandAdded(RenderChainCommand command) { }

	// RVA: 0x1772C38
	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	// RVA: 0x1772C6C
	private static RenderNodeData AccessRenderNodeData(IntPtr obj) { }

	// RVA: 0x1772D40
	private static void OnRenderNodeExecute(IntPtr obj) { }

	// RVA: 0x1772DF0
	private static void OnRegisterIntermediateRenderers(Camera camera) { }

	// RVA: 0x1773420
	private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, RenderNodeData rnd, Camera camera, int sameDistanceSortPriority) { }

	// RVA: 0x177377C
	internal void RepaintTexturedElements() { }

	// RVA: 0x1773860
	public void InsertTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) { }

	// RVA: 0x1770110
	public void ResetTextures(VisualElement ve) { }

	// RVA: 0x17710F4
	private void DrawStats() { }

	// RVA: 0x17700F0
	private static VisualElement GetFirstElementInPanel(VisualElement ve) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal enum RenderDataDirtyTypes
{
	// Fields
	public int value__; // 0x10
	public const RenderDataDirtyTypes None = 0;
	public const RenderDataDirtyTypes Transform = 1;
	public const RenderDataDirtyTypes ClipRectSize = 2;
	public const RenderDataDirtyTypes Clipping = 4;
	public const RenderDataDirtyTypes ClippingHierarchy = 8;
	public const RenderDataDirtyTypes Visuals = 16;
	public const RenderDataDirtyTypes VisualsHierarchy = 32;
	public const RenderDataDirtyTypes VisualsOpacityId = 64;
	public const RenderDataDirtyTypes Opacity = 128;
	public const RenderDataDirtyTypes OpacityHierarchy = 256;
	public const RenderDataDirtyTypes Color = 512;
	public const RenderDataDirtyTypes AllVisuals = 112;
}

// Namespace: UnityEngine.UIElements.UIR
internal enum RenderDataDirtyTypeClasses
{
	// Fields
	public int value__; // 0x10
	public const RenderDataDirtyTypeClasses Clipping = 0;
	public const RenderDataDirtyTypeClasses Opacity = 1;
	public const RenderDataDirtyTypeClasses Color = 2;
	public const RenderDataDirtyTypeClasses TransformSize = 3;
	public const RenderDataDirtyTypeClasses Visuals = 4;
	public const RenderDataDirtyTypeClasses Count = 5;
}

// Namespace: UnityEngine.UIElements.UIR
internal enum RenderDataFlags
{
	// Fields
	public int value__; // 0x10
	public const RenderDataFlags IsIgnoringDynamicColorHint = 1;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct RenderChainVEData
{
	// Fields
	internal VisualElement prev; // 0x10
	internal VisualElement next; // 0x18
	internal VisualElement groupTransformAncestor; // 0x20
	internal VisualElement boneTransformAncestor; // 0x28
	internal VisualElement prevDirty; // 0x30
	internal VisualElement nextDirty; // 0x38
	internal RenderDataFlags flags; // 0x40
	internal int hierarchyDepth; // 0x44
	internal RenderDataDirtyTypes dirtiedValues; // 0x48
	internal UInt32 dirtyID; // 0x4C
	internal RenderChainCommand firstCommand; // 0x50
	internal RenderChainCommand lastCommand; // 0x58
	internal RenderChainCommand firstClosingCommand; // 0x60
	internal RenderChainCommand lastClosingCommand; // 0x68
	internal bool isInChain; // 0x70
	internal bool isHierarchyHidden; // 0x71
	internal bool localFlipsWinding; // 0x72
	internal bool localTransformScaleZero; // 0x73
	internal bool worldFlipsWinding; // 0x74
	public bool worldTransformScaleZero; // 0x75
	internal ClipMethod clipMethod; // 0x78
	internal int childrenStencilRef; // 0x7C
	internal int childrenMaskDepth; // 0x80
	internal bool disableNudging; // 0x84
	internal MeshHandle data; // 0x88
	internal MeshHandle closingData; // 0x90
	internal Matrix4x4 verticesSpace; // 0x98
	internal int displacementUVStart; // 0xD8
	internal int displacementUVEnd; // 0xDC
	internal BMPAlloc transformID; // 0xE0
	internal BMPAlloc clipRectID; // 0xE8
	internal BMPAlloc opacityID; // 0xF0
	internal BMPAlloc textCoreSettingsID; // 0xF8
	internal BMPAlloc colorID; // 0x100
	internal BMPAlloc backgroundColorID; // 0x108
	internal BMPAlloc borderLeftColorID; // 0x110
	internal BMPAlloc borderTopColorID; // 0x118
	internal BMPAlloc borderRightColorID; // 0x120
	internal BMPAlloc borderBottomColorID; // 0x128
	internal BMPAlloc tintColorID; // 0x130
	internal float compositeOpacity; // 0x138
	internal Color backgroundColor; // 0x13C
	internal UnityEngine.UIElements.UIR.BasicNode<UnityEngine.UIElements.UIR.TextureEntry> textures; // 0x150

	// Methods

	// RVA: 0x17742D8
	internal RenderChainCommand get_lastClosingOrLastCommand() { }

	// RVA: 0x17742F0
	internal static bool AllocatesID(BMPAlloc alloc) { }

	// RVA: 0x1774384
	internal static bool InheritsID(BMPAlloc alloc) { }

	// RVA: 0x1774400
	public bool get_isIgnoringDynamicColorHint() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal struct TextureEntry
{
	// Fields
	public Texture source; // 0x10
	public TextureId actual; // 0x18
	public bool replaced; // 0x1C
}

// Namespace: UnityEngine.UIElements.UIR
internal abstract class BaseShaderInfoStorage
{
	// Fields
	protected static int s_TextureCounter; // 0x0
	internal static ProfilerMarker s_MarkerCopyTexture; // 0x8
	internal static ProfilerMarker s_MarkerGetTextureData; // 0x10
	internal static ProfilerMarker s_MarkerUpdateTexture; // 0x18
	private bool <disposed>k__BackingField; // 0x10

	// Methods

	// RVA: -1
	public abstract Texture2D get_texture() { }

	// RVA: -1
	public abstract bool AllocateRect(int width, int height, RectInt uvs) { }

	// RVA: -1
	public abstract void SetTexel(int x, int y, Color color) { }

	// RVA: -1
	public abstract void UpdateTexture() { }

	// RVA: 0x177440C
	protected bool get_disposed() { }

	// RVA: 0x1774414
	private void set_disposed(bool value) { }

	// RVA: 0x177441C
	public void Dispose() { }

	// RVA: 0x17744AC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17744C4
	protected void .ctor() { }

	// RVA: 0x17744CC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorage<T0>
{
	// Fields
	private readonly int m_InitialSize; // 0x0
	private readonly int m_MaxSize; // 0x0
	private readonly TextureFormat m_Format; // 0x0
	private readonly System.Func<UnityEngine.Color,T> m_Convert; // 0x0
	private UIRAtlasAllocator m_Allocator; // 0x0
	private Texture2D m_Texture; // 0x0
	private Unity.Collections.NativeArray<T> m_Texels; // 0x0

	// Methods

	// RVA: -1
	public void .ctor(TextureFormat format, System.Func<UnityEngine.Color,T> convert, int initialSize, int maxSize) { }

	// RVA: 0x30A2404
	protected override void Dispose(bool disposing) { }

	// RVA: 0x30A17DC
	public override Texture2D get_texture() { }

	// RVA: -1
	public override bool AllocateRect(int width, int height, RectInt uvs) { }

	// RVA: -1
	public override void SetTexel(int x, int y, Color color) { }

	// RVA: 0x30A2378
	public override void UpdateTexture() { }

	// RVA: 0x30A2378
	private void CreateOrExpandTexture() { }

	// RVA: 0x315B3A8
	private static void CpuBlit(Unity.Collections.NativeArray<T> src, int srcWidth, int srcHeight, Unity.Collections.NativeArray<T> dst, int dstWidth, int dstHeight) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.ShaderInfoStorageRGBA32.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1774738
	private static void .cctor() { }

	// RVA: 0x17747A4
	public void .ctor() { }

	// RVA: 0x17747AC
	internal Color32 <.cctor>b__2_0(Color c) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorageRGBA32
{
	// Fields
	private static readonly System.Func<UnityEngine.Color,UnityEngine.Color32> s_Convert; // 0x0

	// Methods

	// RVA: 0x17745C4
	public void .ctor(int initialSize, int maxSize) { }

	// RVA: 0x1774664
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1774928
	private static void .cctor() { }

	// RVA: 0x1774994
	public void .ctor() { }

	// RVA: 0x177499C
	internal Color <.cctor>b__2_0(Color c) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorageRGBAFloat
{
	// Fields
	private static readonly System.Func<UnityEngine.Color,UnityEngine.Color> s_Convert; // 0x0

	// Methods

	// RVA: 0x17747B4
	public void .ctor(int initialSize, int maxSize) { }

	// RVA: 0x1774854
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal static class Shaders
{
	// Fields
	public static readonly string k_AtlasBlit; // 0x0
	public static readonly string k_Editor; // 0x8
	public static readonly string k_Runtime; // 0x10
	public static readonly string k_RuntimeWorld; // 0x18
	public static readonly string k_GraphView; // 0x20
	public static readonly string k_ColorConversionBlit; // 0x28

	// Methods

	// RVA: 0x17749A0
	private static void .cctor() { }

}

// Namespace: 
private struct Page
{
	// Fields
	public Unity.Collections.NativeArray<T> array; // 0x0
	public int used; // 0x0
}

// Namespace: UnityEngine.UIElements.UIR
internal class TempAllocator<T0>
{
	// Fields
	private readonly int m_ExcessMinCapacity; // 0x0
	private readonly int m_ExcessMaxCapacity; // 0x0
	private Page m_Pool; // 0x0
	private System.Collections.Generic.List<UnityEngine.UIElements.UIR.TempAllocator.Page<T>> m_Excess; // 0x0
	private int m_NextExcessSize; // 0x0
	private bool <disposed>k__BackingField; // 0x0

	// Methods

	// RVA: -1
	public void .ctor(int poolCapacity, int excessMinCapacity, int excessMaxCapacity) { }

	// RVA: 0x30A1224
	protected bool get_disposed() { }

	// RVA: 0x30A2404
	private void set_disposed(bool value) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A2404
	protected void Dispose(bool disposing) { }

	// RVA: 0x315B3A8
	public Unity.Collections.NativeSlice<T> Alloc(int count) { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x30A2378
	private void ReleaseExcess() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal struct TextCoreSettings
{
	// Fields
	public Color faceColor; // 0x10
	public Color outlineColor; // 0x20
	public float outlineWidth; // 0x30
	public Color underlayColor; // 0x34
	public Vector2 underlayOffset; // 0x44
	public float underlaySoftness; // 0x4C

	// Methods

	// RVA: 0x1774C74
	public override bool Equals(object obj) { }

	// RVA: 0x1774D1C
	public bool Equals(TextCoreSettings other) { }

	// RVA: 0x1774E20
	public override int GetHashCode() { }

}

// Namespace: 
private struct BlitInfo
{
	// Fields
	public Texture src; // 0x10
	public RectInt srcRect; // 0x18
	public Vector2Int dstPos; // 0x28
	public int border; // 0x30
	public Color tint; // 0x34
}

// Namespace: UnityEngine.UIElements.UIR
internal class TextureBlitter
{
	// Fields
	private static readonly int[] k_TextureIds; // 0x0
	private static ProfilerMarker s_CommitSampler; // 0x8
	private BlitInfo[] m_SingleBlit; // 0x10
	private Material m_BlitMaterial; // 0x18
	private MaterialPropertyBlock m_Properties; // 0x20
	private RectInt m_Viewport; // 0x28
	private RenderTexture m_PrevRT; // 0x38
	private System.Collections.Generic.List<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> m_PendingBlits; // 0x40
	private bool <disposed>k__BackingField; // 0x48

	// Methods

	// RVA: 0x1774FBC
	protected bool get_disposed() { }

	// RVA: 0x1774FC4
	private void set_disposed(bool value) { }

	// RVA: 0x1774FCC
	public void Dispose() { }

	// RVA: 0x177505C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x177510C
	private static void .cctor() { }

	// RVA: 0x1775250
	public void .ctor(int capacity) { }

	// RVA: 0x177531C
	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x1775450
	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x1775EEC
	public void Commit(RenderTexture dst) { }

	// RVA: 0x17755E8
	private void BeginBlit(RenderTexture dst) { }

	// RVA: 0x1775864
	private void DoBlit(System.Collections.Generic.IList<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> blitInfos, int startIndex) { }

	// RVA: 0x1775E64
	private void EndBlit() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class TextureSlotManager
{
	// Fields
	internal static readonly int k_SlotCount; // 0x0
	internal static readonly int k_SlotSize; // 0x4
	internal static readonly int[] slotIds; // 0x8
	internal static readonly int textureTableId; // 0x10
	private TextureId[] m_Textures; // 0x10
	private int[] m_Tickets; // 0x18
	private int m_CurrentTicket; // 0x20
	private int m_FirstUsedTicket; // 0x24
	private Vector4[] m_GpuTextures; // 0x28
	private int <FreeSlots>k__BackingField; // 0x30
	internal TextureRegistry textureRegistry; // 0x38

	// Methods

	// RVA: 0x17760D8
	private static void .cctor() { }

	// RVA: 0x1776288
	public void .ctor() { }

	// RVA: 0x1776460
	public void Reset() { }

	// RVA: 0x17766F4
	public void StartNewBatch() { }

	// RVA: 0x177676C
	public int IndexOf(TextureId id) { }

	// RVA: 0x177687C
	public void MarkUsed(int slotIndex) { }

	// RVA: 0x17768D8
	public int get_FreeSlots() { }

	// RVA: 0x17768E0
	private void set_FreeSlots(int value) { }

	// RVA: 0x17768E8
	public int FindOldestSlot() { }

	// RVA: 0x1776A38
	public void Bind(TextureId id, float sdfScale, int slot, MaterialPropertyBlock mat) { }

	// RVA: 0x1776584
	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.VectorImageRenderInfoPool.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.UIR.VectorImageRenderInfo> <>9__0_0; // 0x8
	public static System.Action<UnityEngine.UIElements.UIR.VectorImageRenderInfo> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x1776E10
	private static void .cctor() { }

	// RVA: 0x1776E7C
	public void .ctor() { }

	// RVA: 0x1776E84
	internal VectorImageRenderInfo <.ctor>b__0_0() { }

	// RVA: 0x1776F64
	internal void <.ctor>b__0_1(VectorImageRenderInfo vectorImageInfo) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageRenderInfoPool
{
	// Methods

	// RVA: 0x1776C3C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageRenderInfo
{
	// Fields
	public int useCount; // 0x18
	public GradientRemap firstGradientRemap; // 0x20
	public Alloc gradientSettingsAlloc; // 0x28

	// Methods

	// RVA: 0x1776FA4
	public void Reset() { }

	// RVA: 0x1776F10
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.GradientRemapPool.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.UIR.GradientRemap> <>9__0_0; // 0x8
	public static System.Action<UnityEngine.UIElements.UIR.GradientRemap> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x17771B0
	private static void .cctor() { }

	// RVA: 0x177721C
	public void .ctor() { }

	// RVA: 0x1777224
	internal GradientRemap <.ctor>b__0_0() { }

	// RVA: 0x1777304
	internal void <.ctor>b__0_1(GradientRemap gradientRemap) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientRemapPool
{
	// Methods

	// RVA: 0x1776FDC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientRemap
{
	// Fields
	public int origIndex; // 0x18
	public int destIndex; // 0x1C
	public RectInt location; // 0x20
	public GradientRemap next; // 0x30
	public TextureId atlas; // 0x38

	// Methods

	// RVA: 0x1777380
	public void Reset() { }

	// RVA: 0x17772B0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageManager
{
	// Fields
	public static System.Collections.Generic.List<UnityEngine.UIElements.UIR.VectorImageManager> instances; // 0x0
	private static ProfilerMarker s_MarkerRegister; // 0x8
	private static ProfilerMarker s_MarkerUnregister; // 0x10
	private readonly AtlasBase m_Atlas; // 0x10
	private System.Collections.Generic.Dictionary<UnityEngine.UIElements.VectorImage,UnityEngine.UIElements.UIR.VectorImageRenderInfo> m_Registered; // 0x18
	private VectorImageRenderInfoPool m_RenderInfoPool; // 0x20
	private GradientRemapPool m_GradientRemapPool; // 0x28
	private GradientSettingsAtlas m_GradientSettingsAtlas; // 0x30
	private bool m_LoggedExhaustedSettingsAtlas; // 0x38
	private bool <disposed>k__BackingField; // 0x39

	// Methods

	// RVA: 0x17773F4
	public Texture2D get_atlas() { }

	// RVA: 0x1777408
	public void .ctor(AtlasBase atlas) { }

	// RVA: 0x17775DC
	protected bool get_disposed() { }

	// RVA: 0x17775E4
	private void set_disposed(bool value) { }

	// RVA: 0x17775EC
	public void Dispose() { }

	// RVA: 0x177767C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17777B0
	public void Commit() { }

	// RVA: 0x17777E4
	public GradientRemap AddUser(VectorImage vi, VisualElement context) { }

	// RVA: 0x1777918
	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) { }

	// RVA: 0x1777E0C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal enum OwnedState
{
	// Fields
	public Byte value__; // 0x10
	public const OwnedState Inherited = 0;
	public const OwnedState Owned = 1;
}

// Namespace: UnityEngine.UIElements.UIR
internal struct BMPAlloc
{
	// Fields
	public static readonly BMPAlloc Invalid; // 0x0
	public int page; // 0x10
	public UInt16 pageLine; // 0x14
	public Byte bitIndex; // 0x16
	public OwnedState ownedState; // 0x17

	// Methods

	// RVA: 0x1777F28
	public bool Equals(BMPAlloc other) { }

	// RVA: 0x1774374
	public bool IsValid() { }

	// RVA: 0x1777F60
	public override string ToString() { }

	// RVA: 0x1778054
	private static void .cctor() { }

}

// Namespace: 
private struct Page
{
	// Fields
	public UInt16 x; // 0x10
	public UInt16 y; // 0x12
	public int freeSlots; // 0x14
}

// Namespace: UnityEngine.UIElements.UIR
internal struct BitmapAllocator32
{
	// Fields
	private int m_PageHeight; // 0x10
	private System.Collections.Generic.List<UnityEngine.UIElements.UIR.BitmapAllocator32.Page> m_Pages; // 0x18
	private System.Collections.Generic.List<System.UInt32> m_AllocMap; // 0x20
	private int m_EntryWidth; // 0x28
	private int m_EntryHeight; // 0x2C

	// Methods

	// RVA: 0x17780A4
	public void Construct(int pageHeight, int entryWidth, int entryHeight) { }

	// RVA: 0x17781D4
	public void ForceFirstAlloc(UInt16 firstPageX, UInt16 firstPageY) { }

	// RVA: 0x17782D8
	public BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	// RVA: 0x17787AC
	public void Free(BMPAlloc alloc) { }

	// RVA: 0x177891C
	public int get_entryWidth() { }

	// RVA: 0x1778924
	public int get_entryHeight() { }

	// RVA: 0x177892C
	internal void GetAllocPageAtlasLocation(int page, UInt16 x, UInt16 y) { }

	// RVA: 0x1778748
	private static Byte CountTrailingZeroes(UInt32 val) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal struct UIRVEShaderInfoAllocator
{
	// Fields
	private BaseShaderInfoStorage m_Storage; // 0x10
	private BitmapAllocator32 m_TransformAllocator; // 0x18
	private BitmapAllocator32 m_ClipRectAllocator; // 0x38
	private BitmapAllocator32 m_OpacityAllocator; // 0x58
	private BitmapAllocator32 m_ColorAllocator; // 0x78
	private BitmapAllocator32 m_TextSettingsAllocator; // 0x98
	private bool m_StorageReallyCreated; // 0xB8
	private bool m_VertexTexturingEnabled; // 0xB9
	private Unity.Collections.NativeArray<UnityEngine.UIElements.UIR.Transform3x4> m_Transforms; // 0xC0
	private Unity.Collections.NativeArray<UnityEngine.Vector4> m_ClipRects; // 0xD0
	internal static readonly Vector2Int identityTransformTexel; // 0x0
	internal static readonly Vector2Int infiniteClipRectTexel; // 0x8
	internal static readonly Vector2Int fullOpacityTexel; // 0x10
	internal static readonly Vector2Int clearColorTexel; // 0x18
	internal static readonly Vector2Int defaultTextCoreSettingsTexel; // 0x20
	internal static readonly Matrix4x4 identityTransformValue; // 0x28
	internal static readonly Vector4 identityTransformRow0Value; // 0x68
	internal static readonly Vector4 identityTransformRow1Value; // 0x78
	internal static readonly Vector4 identityTransformRow2Value; // 0x88
	internal static readonly Vector4 infiniteClipRectValue; // 0x98
	internal static readonly Vector4 fullOpacityValue; // 0xA8
	internal static readonly Vector4 clearColorValue; // 0xB8
	internal static readonly TextCoreSettings defaultTextCoreSettingsValue; // 0xC8
	public static readonly BMPAlloc identityTransform; // 0x108
	public static readonly BMPAlloc infiniteClipRect; // 0x110
	public static readonly BMPAlloc fullOpacity; // 0x118
	public static readonly BMPAlloc clearColor; // 0x120
	public static readonly BMPAlloc defaultTextCoreSettings; // 0x128

	// Methods

	// RVA: 0x17789C0
	private static int get_pageWidth() { }

	// RVA: 0x17789C8
	private static int get_pageHeight() { }

	// RVA: 0x17789D0
	private static Vector2Int AllocToTexelCoord(BitmapAllocator32 allocator, BMPAlloc alloc) { }

	// RVA: 0x1778A68
	private static int AllocToConstantBufferIndex(BMPAlloc alloc) { }

	// RVA: 0x1778AD4
	private static bool AtlasRectMatchesPage(BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	// RVA: 0x1778CE8
	public Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> get_transformConstants() { }

	// RVA: 0x1778D3C
	public Unity.Collections.NativeSlice<UnityEngine.Vector4> get_clipRectConstants() { }

	// RVA: 0x1778D90
	public Texture get_atlas() { }

	// RVA: 0x1778E50
	public void Construct() { }

	// RVA: 0x1779140
	private void ReallyCreateStorage() { }

	// RVA: 0x177A24C
	public void Dispose() { }

	// RVA: 0x177A360
	public void IssuePendingStorageChanges() { }

	// RVA: 0x177A378
	public BMPAlloc AllocTransform() { }

	// RVA: 0x177A510
	public BMPAlloc AllocClipRect() { }

	// RVA: 0x177A6A8
	public BMPAlloc AllocOpacity() { }

	// RVA: 0x177A730
	public BMPAlloc AllocColor() { }

	// RVA: 0x177A7B8
	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	// RVA: 0x1779614
	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	// RVA: 0x1779924
	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	// RVA: 0x1779B50
	public void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	// RVA: 0x1779CE8
	public void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext) { }

	// RVA: 0x1779EF0
	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext) { }

	// RVA: 0x177A840
	public void FreeTransform(BMPAlloc alloc) { }

	// RVA: 0x177A900
	public void FreeClipRect(BMPAlloc alloc) { }

	// RVA: 0x177A9C0
	public void FreeOpacity(BMPAlloc alloc) { }

	// RVA: 0x177AA80
	public void FreeColor(BMPAlloc alloc) { }

	// RVA: 0x177AB40
	public void FreeTextCoreSettings(BMPAlloc alloc) { }

	// RVA: 0x177AC00
	public Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x177AD64
	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x177AEC8
	public Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x177AFFC
	public Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x177B130
	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	// RVA: 0x177B264
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.UIR.Implementation
internal static class CommandGenerator
{
	// Fields
	private static readonly ProfilerMarker k_GenerateEntries; // 0x0
	private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker; // 0x8
	private static readonly ProfilerMarker k_GenerateClosingCommandsMarker; // 0x10
	private static readonly ProfilerMarker k_NudgeVerticesMarker; // 0x18
	private static readonly ProfilerMarker k_UpdateOpacityIdMarker; // 0x20
	private static readonly ProfilerMarker k_ComputeTransformMatrixMarker; // 0x28
	private static Material s_blitMaterial_LinearToGamma; // 0x30
	private static Material s_blitMaterial_GammaToLinear; // 0x38
	private static Material s_blitMaterial_NoChange; // 0x40
	private static Shader s_blitShader; // 0x48

	// Methods

	// RVA: 0x177B418
	private static void GetVerticesTransformInfo(VisualElement ve, Matrix4x4 transform) { }

	// RVA: 0x177B5E0
	internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, Matrix4x4 result) { }

	// RVA: 0x177B7F4
	private static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child) { }

	// RVA: 0x177B88C
	public static ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ChainBuilderStats stats) { }

	// RVA: 0x177F9F0
	private static void InvokeGenerateVisualContent(VisualElement ve, MeshGenerationContext ctx) { }

	// RVA: 0x1780B90
	private static Material CreateBlitShader(float colorConversion) { }

	// RVA: 0x1780648
	private static Material GetBlitMaterial(RenderTargetMode mode) { }

	// RVA: 0x1780DFC
	public static void ClosePaintElement(VisualElement ve, ClosingInfo closingInfo, RenderChain renderChain, ChainBuilderStats stats) { }

	// RVA: 0x177FC0C
	private static void UpdateOrAllocate(MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& verts, Unity.Collections.NativeSlice<System.UInt16>& indices, UInt16 indexOffset, ChainBuilderStats stats) { }

	// RVA: 0x1781030
	public static void UpdateOpacityId(VisualElement ve, RenderChain renderChain) { }

	// RVA: 0x178113C
	private static void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh) { }

	// RVA: 0x178125C
	public static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device) { }

	// RVA: 0x178162C
	private static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, IntPtr src, IntPtr dst, int count) { }

	// RVA: 0x1780054
	private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, RenderChainCommand cmdPrev, RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x17809D0
	private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, RenderChainCommand cmdPrev, RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x177FD04
	private static void FindCommandInsertionPoint(VisualElement ve, RenderChainCommand prev, RenderChainCommand next) { }

	// RVA: 0x17802A4
	private static void FindClosingCommandInsertionPoint(VisualElement ve, RenderChainCommand prev, RenderChainCommand next) { }

	// RVA: 0x178018C
	private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, RenderChainCommand prev, RenderChainCommand next) { }

	// RVA: 0x17804E8
	private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, RenderChainCommand prev, RenderChainCommand next) { }

	// RVA: 0x177CE5C
	public static void ResetCommands(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x1781748
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.UIR.Implementation
internal enum ClipMethod
{
	// Fields
	public int value__; // 0x10
	public const ClipMethod Undetermined = 0;
	public const ClipMethod NotClipped = 1;
	public const ClipMethod Scissor = 2;
	public const ClipMethod ShaderDiscard = 3;
	public const ClipMethod Stencil = 4;
}

// Namespace: UnityEngine.UIElements.UIR.Implementation
internal static class RenderEvents
{
	// Fields
	private static readonly float VisibilityTreshold; // 0x0

	// Methods

	// RVA: 0x17818F0
	internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x178217C
	internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x1782750
	internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x1782A30
	internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x1782FFC
	internal static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x178370C
	private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve) { }

	// RVA: 0x17838A4
	private static Vector4 GetClipRectIDClipInfo(VisualElement ve) { }

	// RVA: 0x1783AC0
	internal static UInt32 DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState) { }

	// RVA: 0x17855AC
	internal static UInt32 DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x17819E4
	private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, UInt32 dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ChainBuilderStats stats) { }

	// RVA: 0x1782284
	private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, UInt32 dirtyID, bool hierarchical, ChainBuilderStats stats, bool isDoingFullVertexRegeneration) { }

	// RVA: 0x17827DC
	private static void OnColorChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x1782AF8
	private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, UInt32 dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ChainBuilderStats stats) { }

	// RVA: 0x17831D8
	private static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, bool parentHierarchyHidden, bool hierarchical, ChainBuilderStats stats) { }

	// RVA: 0x1786568
	private static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x1783114
	private static bool IsElementHierarchyHidden(VisualElement ve) { }

	// RVA: 0x17843AC
	private static VisualElement GetLastDeepestChild(VisualElement ve) { }

	// RVA: 0x1786430
	private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x178423C
	private static bool UpdateLocalFlipsWinding(VisualElement ve) { }

	// RVA: 0x1786C08
	private static void UpdateWorldFlipsWinding(VisualElement ve) { }

	// RVA: 0x1786A30
	private static void UpdateZeroScaling(VisualElement ve) { }

	// RVA: 0x1784434
	private static bool NeedsTransformID(VisualElement ve) { }

	// RVA: 0x1784484
	internal static bool NeedsColorID(VisualElement ve) { }

	// RVA: 0x1786C68
	internal static bool NeedsTextCoreSettings(VisualElement ve) { }

	// RVA: 0x17844A8
	private static bool InitColorIDs(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x1784E48
	private static void SetColorValues(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x1786D30
	private static void .cctor() { }

}

// Namespace: 
internal struct Entry
{
	// Fields
	public Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices; // 0x10
	public Unity.Collections.NativeSlice<System.UInt16> indices; // 0x20
	public Material material; // 0x30
	public float fontTexSDFScale; // 0x38
	public TextureId texture; // 0x3C
	public RenderChainCommand customCommand; // 0x40
	public BMPAlloc clipRectID; // 0x48
	public VertexFlags addFlags; // 0x50
	public bool uvIsDisplacement; // 0x54
	public bool isTextEntry; // 0x55
	public bool isClipRegisterEntry; // 0x56
	public int stencilRef; // 0x58
	public int maskDepth; // 0x5C
}

// Namespace: 
internal struct ClosingInfo
{
	// Fields
	public bool needsClosing; // 0x10
	public bool popViewMatrix; // 0x11
	public bool popScissorClip; // 0x12
	public bool blitAndPopRenderTexture; // 0x13
	public bool PopDefaultMaterial; // 0x14
	public RenderChainCommand clipUnregisterDrawCommand; // 0x18
	public Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> clipperRegisterVertices; // 0x20
	public Unity.Collections.NativeSlice<System.UInt16> clipperRegisterIndices; // 0x30
	public int clipperRegisterIndexOffset; // 0x40
	public int maskStencilRef; // 0x44
}

// Namespace: 
private struct RepeatRectUV
{
	// Fields
	public Rect rect; // 0x10
	public Rect uv; // 0x20
}

// Namespace: UnityEngine.UIElements.UIR.Implementation
internal class UIRStylePainter
{
	// Fields
	private RenderChain m_Owner; // 0x10
	private System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> m_Entries; // 0x18
	private AtlasBase m_Atlas; // 0x20
	private VectorImageManager m_VectorImageManager; // 0x28
	private Entry m_CurrentEntry; // 0x30
	private ClosingInfo m_ClosingInfo; // 0x80
	private int m_MaskDepth; // 0xB8
	private int m_StencilRef; // 0xBC
	private BMPAlloc m_ClipRectID; // 0xC0
	private int m_SVGBackgroundEntryIndex; // 0xC8
	private UnityEngine.UIElements.UIR.TempAllocator<UnityEngine.UIElements.Vertex> m_VertsPool; // 0xD0
	private UnityEngine.UIElements.UIR.TempAllocator<System.UInt16> m_IndicesPool; // 0xD8
	private System.Collections.Generic.List<UnityEngine.UIElements.MeshWriteData> m_MeshWriteDataPool; // 0xE0
	private int m_NextMeshWriteDataPoolItem; // 0xE8
	private System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.RepeatRectUV>[] m_RepeatRectUVList; // 0xF0
	private Allocator m_AllocRawVertsIndicesDelegate; // 0xF8
	private Allocator m_AllocThroughDrawMeshDelegate; // 0x100
	private readonly MeshGenerationContext <meshGenerationContext>k__BackingField; // 0x108
	private VisualElement <currentElement>k__BackingField; // 0x110
	private int <totalVertices>k__BackingField; // 0x118
	private int <totalIndices>k__BackingField; // 0x11C
	private TextInfo m_TextInfo; // 0x120

	// Methods

	// RVA: 0x1786D84
	private MeshWriteData GetPooledMeshWriteData() { }

	// RVA: 0x1786E7C
	private MeshWriteData AllocRawVertsIndices(UInt32 vertexCount, UInt32 indexCount, AllocMeshData allocatorData) { }

	// RVA: 0x1786F3C
	private MeshWriteData AllocThroughDrawMesh(UInt32 vertexCount, UInt32 indexCount, AllocMeshData allocatorData) { }

	// RVA: 0x17873D4
	public void .ctor(RenderChain renderChain) { }

	// RVA: 0x17876DC
	public MeshGenerationContext get_meshGenerationContext() { }

	// RVA: 0x17876E4
	public VisualElement get_currentElement() { }

	// RVA: 0x17876EC
	private void set_currentElement(VisualElement value) { }

	// RVA: 0x177FC04
	public System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> get_entries() { }

	// RVA: 0x1780288
	public ClosingInfo get_closingInfo() { }

	// RVA: 0x17876FC
	public int get_totalVertices() { }

	// RVA: 0x1787704
	private void set_totalVertices(int value) { }

	// RVA: 0x178770C
	public int get_totalIndices() { }

	// RVA: 0x1787714
	private void set_totalIndices(int value) { }

	// RVA: 0x177D1D0
	public void Begin(VisualElement ve) { }

	// RVA: 0x1780B10
	public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd) { }

	// RVA: 0x177FFB4
	public void LandClipRegisterMesh(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, int indexOffset) { }

	// RVA: 0x1786F50
	public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshFlags flags) { }

	// RVA: 0x178771C
	internal void TryAtlasTexture(Texture texture, MeshFlags flags, Rect outUVRegion, bool outIsAtlas, TextureId outTextureId, VertexFlags outAddFlags) { }

	// RVA: 0x1787930
	internal void BuildEntryFromNativeMesh(MeshWriteDataInterface meshData, Texture texture, TextureId textureId, bool isAtlas, Material material, MeshFlags flags, Rect uvRegion, VertexFlags addFlags) { }

	// RVA: 0x1787D38
	internal void BuildGradientEntryFromNativeMesh(MeshWriteDataInterface meshData, TextureId svgTextureId) { }

	// RVA: 0x1788084
	public void BuildRawEntryFromNativeMesh(MeshWriteDataInterface meshData) { }

	// RVA: 0x1788258
	public void DrawText(TextElement te) { }

	// RVA: 0x17882F4
	private void DrawTextInfo(TextInfo textInfo, Vector2 offset, bool useHints) { }

	// RVA: 0x1788988
	public void DrawRectangle(RectangleParams rectParams) { }

	// RVA: 0x17896C4
	public void DrawBorder(BorderParams borderParams) { }

	// RVA: 0x1789768
	public void DrawImmediate(Action callback, bool cullingEnabled) { }

	// RVA: 0x1789860
	public VisualElement get_visualElement() { }

	// RVA: 0x177D5BC
	public void DrawVisualElementBackground() { }

	// RVA: 0x1789980
	private void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	// RVA: 0x178B06C
	private void StampRectangleWithSubRect(RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV) { }

	// RVA: 0x177ECB4
	public void DrawVisualElementBorder() { }

	// RVA: 0x177F7FC
	public void ApplyVisualElementClipping() { }

	// RVA: 0x178BFC8
	private UInt16[] AdjustSpriteWinding(Vector2[] vertices, UInt16[] indices) { }

	// RVA: 0x17890C8
	public void DrawSprite(RectangleParams rectParams) { }

	// RVA: 0x1789464
	private void ApplyInset(NativeRectParams rectParams, Texture tex) { }

	// RVA: 0x1788CC8
	public void DrawVectorImage(RectangleParams rectParams) { }

	// RVA: 0x178C2FC
	private void MakeVectorGraphics(RectangleParams rectParams, bool isUsingGradients, TextureId svgTexture, int settingIndexOffset, int finalVertexCount, int finalIndexCount) { }

	// RVA: 0x177FB38
	internal void Reset() { }

	// RVA: 0x178C6FC
	private void ValidateMeshWriteData() { }

	// RVA: 0x178B648
	private void GenerateStencilClipEntryForRoundedRectBackground() { }

	// RVA: 0x178B340
	private void GenerateStencilClipEntryForSVGBackground() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal abstract class HierarchyTraversal
{
	// Methods

	// RVA: 0x178CBF0
	public virtual void Traverse(VisualElement element) { }

	// RVA: -1
	public abstract void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x178CC00
	protected void Recurse(VisualElement element, int depth) { }

	// RVA: 0x178CCD8
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class InitialStyle
{
	// Fields
	private static ComputedStyle s_InitialStyle; // 0x0

	// Methods

	// RVA: 0x178CCE0
	public static ComputedStyle Get() { }

	// RVA: 0x178CD54
	public static ComputedStyle Acquire() { }

	// RVA: 0x178CE00
	private static void .cctor() { }

	// RVA: 0x178DB30
	public static Align get_alignContent() { }

	// RVA: 0x178DBAC
	public static Align get_alignItems() { }

	// RVA: 0x178DC28
	public static Align get_alignSelf() { }

	// RVA: 0x178DCA4
	public static Color get_backgroundColor() { }

	// RVA: 0x178DD24
	public static Background get_backgroundImage() { }

	// RVA: 0x178DDB0
	public static BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x178DE34
	public static BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x178DEB8
	public static BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x178DF34
	public static BackgroundSize get_backgroundSize() { }

	// RVA: 0x178DFC8
	public static Color get_borderBottomColor() { }

	// RVA: 0x178E048
	public static Length get_borderBottomLeftRadius() { }

	// RVA: 0x178E0C4
	public static Length get_borderBottomRightRadius() { }

	// RVA: 0x178E140
	public static float get_borderBottomWidth() { }

	// RVA: 0x178E1BC
	public static Color get_borderLeftColor() { }

	// RVA: 0x178E23C
	public static float get_borderLeftWidth() { }

	// RVA: 0x178E2B8
	public static Color get_borderRightColor() { }

	// RVA: 0x178E338
	public static float get_borderRightWidth() { }

	// RVA: 0x178E3B4
	public static Color get_borderTopColor() { }

	// RVA: 0x178E434
	public static Length get_borderTopLeftRadius() { }

	// RVA: 0x178E4B0
	public static Length get_borderTopRightRadius() { }

	// RVA: 0x178E52C
	public static float get_borderTopWidth() { }

	// RVA: 0x178E5A8
	public static Length get_bottom() { }

	// RVA: 0x178E624
	public static Color get_color() { }

	// RVA: 0x178E6A0
	public static Cursor get_cursor() { }

	// RVA: 0x178E734
	public static DisplayStyle get_display() { }

	// RVA: 0x178E7B0
	public static Length get_flexBasis() { }

	// RVA: 0x178E82C
	public static FlexDirection get_flexDirection() { }

	// RVA: 0x178E8A8
	public static float get_flexGrow() { }

	// RVA: 0x178E924
	public static float get_flexShrink() { }

	// RVA: 0x178E9A0
	public static Wrap get_flexWrap() { }

	// RVA: 0x178EA1C
	public static Length get_fontSize() { }

	// RVA: 0x178EA94
	public static Length get_height() { }

	// RVA: 0x178EB10
	public static Justify get_justifyContent() { }

	// RVA: 0x178EB8C
	public static Length get_left() { }

	// RVA: 0x178EC08
	public static Length get_letterSpacing() { }

	// RVA: 0x178EC80
	public static Length get_marginBottom() { }

	// RVA: 0x178ECFC
	public static Length get_marginLeft() { }

	// RVA: 0x178ED78
	public static Length get_marginRight() { }

	// RVA: 0x178EDF4
	public static Length get_marginTop() { }

	// RVA: 0x178EE70
	public static Length get_maxHeight() { }

	// RVA: 0x178EEEC
	public static Length get_maxWidth() { }

	// RVA: 0x178EF68
	public static Length get_minHeight() { }

	// RVA: 0x178EFE4
	public static Length get_minWidth() { }

	// RVA: 0x178F060
	public static float get_opacity() { }

	// RVA: 0x178F0DC
	public static OverflowInternal get_overflow() { }

	// RVA: 0x178F158
	public static Length get_paddingBottom() { }

	// RVA: 0x178F1D4
	public static Length get_paddingLeft() { }

	// RVA: 0x178F250
	public static Length get_paddingRight() { }

	// RVA: 0x178F2CC
	public static Length get_paddingTop() { }

	// RVA: 0x178F348
	public static Position get_position() { }

	// RVA: 0x178F3C4
	public static Length get_right() { }

	// RVA: 0x178F440
	public static Rotate get_rotate() { }

	// RVA: 0x178F4D4
	public static Scale get_scale() { }

	// RVA: 0x178F554
	public static TextOverflow get_textOverflow() { }

	// RVA: 0x178F5D0
	public static TextShadow get_textShadow() { }

	// RVA: 0x178F660
	public static Length get_top() { }

	// RVA: 0x178F6DC
	public static TransformOrigin get_transformOrigin() { }

	// RVA: 0x178F770
	public static System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay() { }

	// RVA: 0x178F7EC
	public static System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration() { }

	// RVA: 0x178F868
	public static System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty() { }

	// RVA: 0x178F8E4
	public static System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x178F960
	public static Translate get_translate() { }

	// RVA: 0x178F9F4
	public static Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x178FA74
	public static Font get_unityFont() { }

	// RVA: 0x178FAEC
	public static FontDefinition get_unityFontDefinition() { }

	// RVA: 0x178FB68
	public static FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x178FBE0
	public static OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x178FC5C
	public static Length get_unityParagraphSpacing() { }

	// RVA: 0x178FCD4
	public static int get_unitySliceBottom() { }

	// RVA: 0x178FD50
	public static int get_unitySliceLeft() { }

	// RVA: 0x178FDCC
	public static int get_unitySliceRight() { }

	// RVA: 0x178FE48
	public static float get_unitySliceScale() { }

	// RVA: 0x178FEC4
	public static int get_unitySliceTop() { }

	// RVA: 0x178FF40
	public static TextAnchor get_unityTextAlign() { }

	// RVA: 0x178FFB8
	public static Color get_unityTextOutlineColor() { }

	// RVA: 0x1790034
	public static float get_unityTextOutlineWidth() { }

	// RVA: 0x17900AC
	public static TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x1790128
	public static Visibility get_visibility() { }

	// RVA: 0x17901A0
	public static WhiteSpace get_whiteSpace() { }

	// RVA: 0x1790218
	public static Length get_width() { }

	// RVA: 0x1790294
	public static Length get_wordSpacing() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class ShorthandApplicator
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> s_TransitionDelayList; // 0x0
	private static System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> s_TransitionDurationList; // 0x8
	private static System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> s_TransitionPropertyList; // 0x10
	private static System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> s_TransitionTimingFunctionList; // 0x18

	// Methods

	// RVA: 0x179030C
	public static void ApplyBackgroundPosition(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x1790B6C
	public static void ApplyBorderColor(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x1790DF8
	public static void ApplyBorderRadius(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x179103C
	public static void ApplyBorderWidth(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x179124C
	public static void ApplyFlex(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17916F8
	public static void ApplyMargin(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x1791984
	public static void ApplyPadding(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x1791A74
	public static void ApplyTransition(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x1792788
	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x1792998
	public static void ApplyUnityTextOutline(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x1791320
	private static bool CompileFlexShorthand(StylePropertyReader reader, float grow, float shrink, Length basis) { }

	// RVA: 0x1790EE8
	private static void CompileBorderRadius(StylePropertyReader reader, Length top, Length right, Length bottom, Length left) { }

	// RVA: 0x17903E4
	private static void CompileBackgroundPosition(StylePropertyReader reader, BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY) { }

	// RVA: 0x17928EC
	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize) { }

	// RVA: 0x17917E8
	private static void CompileBoxArea(StylePropertyReader reader, Length top, Length right, Length bottom, Length left) { }

	// RVA: 0x1791188
	private static void CompileBoxArea(StylePropertyReader reader, float top, float right, float bottom, float left) { }

	// RVA: 0x1790C64
	private static void CompileBoxArea(StylePropertyReader reader, Color top, Color right, Color bottom, Color left) { }

	// RVA: 0x1792A54
	private static void CompileTextOutline(StylePropertyReader reader, Color outlineColor, float outlineWidth) { }

	// RVA: 0x1791BD0
	private static void CompileTransition(StylePropertyReader reader, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDelay, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDuration, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>& outProperty, System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>& outTimingFunction) { }

	// RVA: 0x179460C
	private static void .cctor() { }

	// RVA: 0x1793114
	internal static void <CompileBackgroundPosition>g__SwapKeyword|16_0(BackgroundPositionKeyword a, BackgroundPositionKeyword b) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StylePropertyCache
{
	// Fields
	internal static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_PropertySyntaxCache; // 0x0
	internal static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_NonTerminalValues; // 0x8

	// Methods

	// RVA: 0x1794780
	public static bool TryGetSyntax(string name, string syntax) { }

	// RVA: 0x179482C
	public static bool TryGetNonTerminalValue(string name, string syntax) { }

	// RVA: 0x17948D8
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum StyleEnumType
{
	// Fields
	public int value__; // 0x10
	public const StyleEnumType Align = 0;
	public const StyleEnumType BackgroundPositionKeyword = 1;
	public const StyleEnumType BackgroundSizeType = 2;
	public const StyleEnumType DisplayStyle = 3;
	public const StyleEnumType EasingMode = 4;
	public const StyleEnumType FlexDirection = 5;
	public const StyleEnumType FontStyle = 6;
	public const StyleEnumType Justify = 7;
	public const StyleEnumType Overflow = 8;
	public const StyleEnumType OverflowClipBox = 9;
	public const StyleEnumType OverflowInternal = 10;
	public const StyleEnumType Position = 11;
	public const StyleEnumType Repeat = 12;
	public const StyleEnumType RepeatXY = 13;
	public const StyleEnumType ScaleMode = 14;
	public const StyleEnumType TextAnchor = 15;
	public const StyleEnumType TextOverflow = 16;
	public const StyleEnumType TextOverflowPosition = 17;
	public const StyleEnumType TransformOriginOffset = 18;
	public const StyleEnumType Visibility = 19;
	public const StyleEnumType WhiteSpace = 20;
	public const StyleEnumType Wrap = 21;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum StylePropertyId
{
	// Fields
	public int value__; // 0x10
	public const StylePropertyId Unknown = 0;
	public const StylePropertyId Custom = 4294967295;
	public const StylePropertyId AlignContent = 131072;
	public const StylePropertyId AlignItems = 131073;
	public const StylePropertyId AlignSelf = 131074;
	public const StylePropertyId All = 262144;
	public const StylePropertyId BackgroundColor = 458752;
	public const StylePropertyId BackgroundImage = 458753;
	public const StylePropertyId BackgroundPosition = 262145;
	public const StylePropertyId BackgroundPositionX = 458754;
	public const StylePropertyId BackgroundPositionY = 458755;
	public const StylePropertyId BackgroundRepeat = 458756;
	public const StylePropertyId BackgroundSize = 458757;
	public const StylePropertyId BorderBottomColor = 458758;
	public const StylePropertyId BorderBottomLeftRadius = 458759;
	public const StylePropertyId BorderBottomRightRadius = 458760;
	public const StylePropertyId BorderBottomWidth = 131075;
	public const StylePropertyId BorderColor = 262146;
	public const StylePropertyId BorderLeftColor = 458761;
	public const StylePropertyId BorderLeftWidth = 131076;
	public const StylePropertyId BorderRadius = 262147;
	public const StylePropertyId BorderRightColor = 458762;
	public const StylePropertyId BorderRightWidth = 131077;
	public const StylePropertyId BorderTopColor = 458763;
	public const StylePropertyId BorderTopLeftRadius = 458764;
	public const StylePropertyId BorderTopRightRadius = 458765;
	public const StylePropertyId BorderTopWidth = 131078;
	public const StylePropertyId BorderWidth = 262148;
	public const StylePropertyId Bottom = 131079;
	public const StylePropertyId Color = 65536;
	public const StylePropertyId Cursor = 196608;
	public const StylePropertyId Display = 131080;
	public const StylePropertyId Flex = 262149;
	public const StylePropertyId FlexBasis = 131081;
	public const StylePropertyId FlexDirection = 131082;
	public const StylePropertyId FlexGrow = 131083;
	public const StylePropertyId FlexShrink = 131084;
	public const StylePropertyId FlexWrap = 131085;
	public const StylePropertyId FontSize = 65537;
	public const StylePropertyId Height = 131086;
	public const StylePropertyId JustifyContent = 131087;
	public const StylePropertyId Left = 131088;
	public const StylePropertyId LetterSpacing = 65538;
	public const StylePropertyId Margin = 262150;
	public const StylePropertyId MarginBottom = 131089;
	public const StylePropertyId MarginLeft = 131090;
	public const StylePropertyId MarginRight = 131091;
	public const StylePropertyId MarginTop = 131092;
	public const StylePropertyId MaxHeight = 131093;
	public const StylePropertyId MaxWidth = 131094;
	public const StylePropertyId MinHeight = 131095;
	public const StylePropertyId MinWidth = 131096;
	public const StylePropertyId Opacity = 458766;
	public const StylePropertyId Overflow = 458767;
	public const StylePropertyId Padding = 262151;
	public const StylePropertyId PaddingBottom = 131097;
	public const StylePropertyId PaddingLeft = 131098;
	public const StylePropertyId PaddingRight = 131099;
	public const StylePropertyId PaddingTop = 131100;
	public const StylePropertyId Position = 131101;
	public const StylePropertyId Right = 131102;
	public const StylePropertyId Rotate = 327680;
	public const StylePropertyId Scale = 327681;
	public const StylePropertyId TextOverflow = 196609;
	public const StylePropertyId TextShadow = 65539;
	public const StylePropertyId Top = 131103;
	public const StylePropertyId TransformOrigin = 327682;
	public const StylePropertyId Transition = 262152;
	public const StylePropertyId TransitionDelay = 393216;
	public const StylePropertyId TransitionDuration = 393217;
	public const StylePropertyId TransitionProperty = 393218;
	public const StylePropertyId TransitionTimingFunction = 393219;
	public const StylePropertyId Translate = 327683;
	public const StylePropertyId UnityBackgroundImageTintColor = 196610;
	public const StylePropertyId UnityBackgroundScaleMode = 262153;
	public const StylePropertyId UnityFont = 65540;
	public const StylePropertyId UnityFontDefinition = 65541;
	public const StylePropertyId UnityFontStyleAndWeight = 65542;
	public const StylePropertyId UnityOverflowClipBox = 196611;
	public const StylePropertyId UnityParagraphSpacing = 65543;
	public const StylePropertyId UnitySliceBottom = 196612;
	public const StylePropertyId UnitySliceLeft = 196613;
	public const StylePropertyId UnitySliceRight = 196614;
	public const StylePropertyId UnitySliceScale = 196615;
	public const StylePropertyId UnitySliceTop = 196616;
	public const StylePropertyId UnityTextAlign = 65544;
	public const StylePropertyId UnityTextOutline = 262154;
	public const StylePropertyId UnityTextOutlineColor = 65545;
	public const StylePropertyId UnityTextOutlineWidth = 65546;
	public const StylePropertyId UnityTextOverflowPosition = 196617;
	public const StylePropertyId Visibility = 65547;
	public const StylePropertyId WhiteSpace = 65548;
	public const StylePropertyId Width = 131104;
	public const StylePropertyId WordSpacing = 65549;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StylePropertyUtil
{
	// Fields
	internal static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyId> s_NameToId; // 0x0
	internal static readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId,System.String> s_IdToName; // 0x8
	internal static readonly System.Collections.Generic.HashSet<UnityEngine.UIElements.StyleSheets.StylePropertyId> s_AnimatableProperties; // 0x10
	internal static readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId,UnityEngine.UIElements.UsageHints> s_AnimatableWithUsageHintProperties; // 0x18

	// Methods

	// RVA: 0x179337C
	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, int intValue) { }

	// RVA: 0x1795D24
	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) { }

	// RVA: 0x1795EBC
	public static bool IsAnimatable(StylePropertyId id) { }

	// RVA: 0x1795F70
	private static void .cctor() { }

}

// Namespace: 
public enum Unit
{
	// Fields
	public int value__; // 0x10
	public const Unit Unitless = 0;
	public const Unit Pixel = 1;
	public const Unit Percent = 2;
	public const Unit Second = 3;
	public const Unit Millisecond = 4;
	public const Unit Degree = 5;
	public const Unit Gradian = 6;
	public const Unit Radian = 7;
	public const Unit Turn = 8;
}

// Namespace: UnityEngine.UIElements.StyleSheets
[Serializable]
internal struct Dimension
{
	// Fields
	public Unit unit; // 0x10
	public float value; // 0x14

	// Methods

	// RVA: 0x1798AC8
	public void .ctor(float value, Unit unit) { }

	// RVA: 0x17930D8
	public Length ToLength() { }

	// RVA: 0x1798AD4
	public TimeValue ToTime() { }

	// RVA: 0x1798B10
	public Angle ToAngle() { }

	// RVA: 0x1798BE4
	public static bool op_Equality(Dimension lhs, Dimension rhs) { }

	// RVA: 0x1798C04
	public bool Equals(Dimension other) { }

	// RVA: 0x1798C24
	public override bool Equals(object obj) { }

	// RVA: 0x1798CC0
	public override int GetHashCode() { }

	// RVA: 0x1798D0C
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
[Serializable]
internal struct ScalableImage
{
	// Fields
	public Texture2D normalImage; // 0x10
	public Texture2D highResolutionImage; // 0x18

	// Methods

	// RVA: 0x1798E44
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct StylePropertyValue
{
	// Fields
	public StyleSheet sheet; // 0x10
	public StyleValueHandle handle; // 0x18
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct ImageSource
{
	// Fields
	public Texture2D texture; // 0x10
	public Sprite sprite; // 0x18
	public VectorImage vectorImage; // 0x20
	public RenderTexture renderTexture; // 0x28

	// Methods

	// RVA: 0x1798FD4
	public bool IsNull() { }

}

// Namespace: 
internal sealed class GetCursorIdFunction
{
	// Methods

	// RVA: 0x179D4E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x179D60C
	public virtual int Invoke(StyleSheet sheet, StyleValueHandle handle) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class StylePropertyReader
{
	// Fields
	internal static GetCursorIdFunction getCursorIdFunc; // 0x0
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values; // 0x10
	private System.Collections.Generic.List<System.Int32> m_ValueCount; // 0x18
	private StyleVariableResolver m_Resolver; // 0x20
	private StyleSheet m_Sheet; // 0x28
	private StyleProperty[] m_Properties; // 0x30
	private StylePropertyId[] m_PropertyIds; // 0x38
	private int m_CurrentValueIndex; // 0x40
	private int m_CurrentPropertyIndex; // 0x44
	private StyleProperty <property>k__BackingField; // 0x48
	private StylePropertyId <propertyId>k__BackingField; // 0x50
	private int <valueCount>k__BackingField; // 0x54
	private float <dpiScaling>k__BackingField; // 0x58

	// Methods

	// RVA: 0x1799120
	public StyleProperty get_property() { }

	// RVA: 0x1799128
	private void set_property(StyleProperty value) { }

	// RVA: 0x1799130
	public StylePropertyId get_propertyId() { }

	// RVA: 0x1799138
	private void set_propertyId(StylePropertyId value) { }

	// RVA: 0x1799140
	public int get_valueCount() { }

	// RVA: 0x1799148
	private void set_valueCount(int value) { }

	// RVA: 0x1799150
	public float get_dpiScaling() { }

	// RVA: 0x1799158
	private void set_dpiScaling(float value) { }

	// RVA: 0x1799160
	public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling) { }

	// RVA: 0x1799654
	public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling) { }

	// RVA: 0x17996BC
	public StylePropertyId MoveNextProperty() { }

	// RVA: 0x1792F38
	public StylePropertyValue GetValue(int index) { }

	// RVA: 0x1792CE8
	public StyleValueType GetValueType(int index) { }

	// RVA: 0x1792BA8
	public bool IsValueType(int index, StyleValueType type) { }

	// RVA: 0x1792C44
	public bool IsKeyword(int index, StyleValueKeyword keyword) { }

	// RVA: 0x17932F8
	public string ReadAsString(int index) { }

	// RVA: 0x1792D78
	public Length ReadLength(int index) { }

	// RVA: 0x1793248
	public TimeValue ReadTimeValue(int index) { }

	// RVA: 0x1799800
	public Translate ReadTranslate(int index) { }

	// RVA: 0x1799BD4
	public TransformOrigin ReadTransformOrigin(int index) { }

	// RVA: 0x1799EC0
	public Rotate ReadRotate(int index) { }

	// RVA: 0x179A118
	public Scale ReadScale(int index) { }

	// RVA: 0x1792EAC
	public float ReadFloat(int index) { }

	// RVA: 0x179A434
	public int ReadInt(int index) { }

	// RVA: 0x1793128
	public Color ReadColor(int index) { }

	// RVA: 0x1792FB4
	public int ReadEnum(StyleEnumType enumType, int index) { }

	// RVA: 0x179A4D8
	public FontDefinition ReadFontDefinition(int index) { }

	// RVA: 0x179AA80
	public Font ReadFont(int index) { }

	// RVA: 0x179AE04
	public Background ReadBackground(int index) { }

	// RVA: 0x179B9F0
	public Cursor ReadCursor(int index) { }

	// RVA: 0x179BDDC
	public TextShadow ReadTextShadow(int index) { }

	// RVA: 0x179C278
	public BackgroundPosition ReadBackgroundPositionX(int index) { }

	// RVA: 0x179C370
	public BackgroundPosition ReadBackgroundPositionY(int index) { }

	// RVA: 0x179C294
	private BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword) { }

	// RVA: 0x179C514
	public BackgroundRepeat ReadBackgroundRepeat(int index) { }

	// RVA: 0x179C738
	public BackgroundSize ReadBackgroundSize(int index) { }

	// RVA: 0x179CA60
	public void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> list, int index) { }

	// RVA: 0x179CC68
	public void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> list, int index) { }

	// RVA: 0x179CE2C
	public void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list, int index) { }

	// RVA: 0x1799258
	private void LoadProperties() { }

	// RVA: 0x17996F8
	private void SetCurrentProperty() { }

	// RVA: 0x1799D0C
	public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) { }

	// RVA: 0x179CFDC
	private static Length ReadTransformOriginEnum(StylePropertyValue value, bool isVertical, bool isHorizontal) { }

	// RVA: 0x1799938
	public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x179A230
	public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x1799FF8
	public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) { }

	// RVA: 0x179D2D4
	private static bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, int intValue) { }

	// RVA: 0x179D158
	private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value) { }

	// RVA: 0x179D248
	public static Angle ReadAngle(StylePropertyValue value) { }

	// RVA: 0x179C38C
	public static BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword) { }

	// RVA: 0x179C670
	public static BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x179C828
	public static BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x179B0D8
	internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, ImageSource source) { }

	// RVA: 0x179D3C8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct MatchResultInfo
{
	// Fields
	public readonly bool success; // 0x10
	public readonly PseudoStates triggerPseudoMask; // 0x14
	public readonly PseudoStates dependencyPseudoMask; // 0x18

	// Methods

	// RVA: 0x179D620
	public void .ctor(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct SelectorMatchRecord
{
	// Fields
	public StyleSheet sheet; // 0x10
	public int styleSheetIndexInStack; // 0x18
	public StyleComplexSelector complexSelector; // 0x20

	// Methods

	// RVA: 0x179D62C
	public void .ctor(StyleSheet sheet, int styleSheetIndexInStack) { }

	// RVA: 0x179D65C
	public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSelectorHelper
{
	// Methods

	// RVA: 0x179D758
	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	// RVA: 0x179DA40
	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult) { }

	// RVA: 0x179DC94
	private static void FastLookup(System.Collections.Generic.IDictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> table, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, SelectorMatchRecord record) { }

	// RVA: 0x179DE88
	public static void FindMatches(StyleMatchingContext context, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }

}

// Namespace: 
private struct SheetHandleKey
{
	// Fields
	public readonly int sheetInstanceID; // 0x10
	public readonly int index; // 0x14

	// Methods

	// RVA: 0x179E5F0
	public void .ctor(StyleSheet sheet, int index) { }

}

// Namespace: 
private class SheetHandleKeyComparer
{
	// Methods

	// RVA: 0x179E914
	public bool Equals(SheetHandleKey x, SheetHandleKey y) { }

	// RVA: 0x179E920
	public int GetHashCode(SheetHandleKey key) { }

	// RVA: 0x179E90C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetCache
{
	// Fields
	private static SheetHandleKeyComparer s_Comparer; // 0x0
	private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey,UnityEngine.UIElements.StyleSheets.StylePropertyId[]> s_RulePropertyIdsCache; // 0x8

	// Methods

	// RVA: 0x179E424
	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) { }

	// RVA: 0x179E730
	internal static StylePropertyId[] GetPropertyIds(StyleRule rule) { }

	// RVA: 0x179E628
	private static StylePropertyId GetPropertyId(StyleRule rule, int index) { }

	// RVA: 0x179E81C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetColor
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.Color32> s_NameToColor; // 0x0

	// Methods

	// RVA: 0x179E968
	public static bool TryGetColor(string name, Color color) { }

	// RVA: 0x179EA7C
	private static Color32 HexToColor32(UInt32 color) { }

	// RVA: 0x179EA90
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetExtensions
{
	// Methods

	// RVA: 0x17A0900
	public static string ReadAsString(StyleSheet sheet, StyleValueHandle handle) { }

	// RVA: 0x17A0C68
	public static bool IsVarFunction(StyleValueHandle handle) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct StyleValue
{
	// Fields
	public StylePropertyId id; // 0x10
	public StyleKeyword keyword; // 0x14
	public float number; // 0x18
	public Length length; // 0x18
	public Color color; // 0x18
	public GCHandle resource; // 0x18
	public BackgroundPosition position; // 0x18
	public BackgroundRepeat repeat; // 0x18
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct StyleValueManaged
{
	// Fields
	public StylePropertyId id; // 0x10
	public StyleKeyword keyword; // 0x14
	public object value; // 0x18
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal enum MatchResultErrorCode
{
	// Fields
	public int value__; // 0x10
	public const MatchResultErrorCode None = 0;
	public const MatchResultErrorCode Syntax = 1;
	public const MatchResultErrorCode EmptyValue = 2;
	public const MatchResultErrorCode ExpectedEndOfValue = 3;
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct MatchResult
{
	// Fields
	public MatchResultErrorCode errorCode; // 0x10
	public string errorValue; // 0x18

	// Methods

	// RVA: 0x17A0CA0
	public bool get_success() { }

}

// Namespace: 
private struct MatchContext
{
	// Fields
	public int valueIndex; // 0x10
	public int matchedVariableCount; // 0x14
}

// Namespace: UnityEngine.UIElements.StyleSheets
internal abstract class BaseStyleMatcher
{
	// Fields
	protected static readonly Regex s_CustomIdentRegex; // 0x0
	private System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.BaseStyleMatcher.MatchContext> m_ContextStack; // 0x10
	private MatchContext m_CurrentContext; // 0x18

	// Methods

	// RVA: -1
	protected abstract bool MatchKeyword(string keyword) { }

	// RVA: -1
	protected abstract bool MatchNumber() { }

	// RVA: -1
	protected abstract bool MatchInteger() { }

	// RVA: -1
	protected abstract bool MatchLength() { }

	// RVA: -1
	protected abstract bool MatchPercentage() { }

	// RVA: -1
	protected abstract bool MatchColor() { }

	// RVA: -1
	protected abstract bool MatchResource() { }

	// RVA: -1
	protected abstract bool MatchUrl() { }

	// RVA: -1
	protected abstract bool MatchTime() { }

	// RVA: -1
	protected abstract bool MatchAngle() { }

	// RVA: -1
	protected abstract bool MatchCustomIdent() { }

	// RVA: -1
	public abstract int get_valueCount() { }

	// RVA: -1
	public abstract bool get_isCurrentVariable() { }

	// RVA: -1
	public abstract bool get_isCurrentComma() { }

	// RVA: 0x17A0CB0
	public bool get_hasCurrent() { }

	// RVA: 0x17A0CE4
	public int get_currentIndex() { }

	// RVA: 0x17A0CEC
	public void set_currentIndex(int value) { }

	// RVA: 0x17A0CF4
	public int get_matchedVariableCount() { }

	// RVA: 0x17A0CFC
	public void set_matchedVariableCount(int value) { }

	// RVA: 0x17A0D04
	protected void Initialize() { }

	// RVA: 0x17A0D5C
	public void MoveNext() { }

	// RVA: 0x17A0DA4
	public void SaveContext() { }

	// RVA: 0x17A0E10
	public void RestoreContext() { }

	// RVA: 0x17A0E7C
	public void DropContext() { }

	// RVA: 0x17A0EE0
	protected bool Match(Expression exp) { }

	// RVA: 0x17A0FA0
	private bool MatchExpression(Expression exp) { }

	// RVA: 0x17A11E8
	private bool MatchExpressionWithMultiplier(Expression exp) { }

	// RVA: 0x17A1688
	private bool MatchGroup(Expression exp) { }

	// RVA: 0x17A1384
	private bool MatchCombinator(Expression exp) { }

	// RVA: 0x17A1740
	private bool MatchOr(Expression exp) { }

	// RVA: 0x17A18B0
	private bool MatchOrOr(Expression exp) { }

	// RVA: 0x17A18CC
	private bool MatchAndAnd(Expression exp) { }

	// RVA: 0x17A1974
	private int MatchMany(Expression exp) { }

	// RVA: 0x17A1D1C
	private int MatchManyByOrder(Expression exp, Int32* matchOrder) { }

	// RVA: 0x17A1908
	private bool MatchJuxtaposition(Expression exp) { }

	// RVA: 0x17A1558
	private bool MatchDataType(Expression exp) { }

	// RVA: 0x17A1ED4
	protected void .ctor() { }

	// RVA: 0x17A1F60
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class StylePropertyValueMatcher
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values; // 0x20

	// Methods

	// RVA: 0x17A2004
	private StylePropertyValue get_current() { }

	// RVA: 0x17A20A8
	public override int get_valueCount() { }

	// RVA: 0x17A20F4
	public override bool get_isCurrentVariable() { }

	// RVA: 0x17A20FC
	public override bool get_isCurrentComma() { }

	// RVA: 0x17A21B8
	public MatchResult Match(Expression exp, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> values) { }

	// RVA: 0x17A24D4
	protected override bool MatchKeyword(string keyword) { }

	// RVA: 0x17A2608
	protected override bool MatchNumber() { }

	// RVA: 0x17A26B4
	protected override bool MatchInteger() { }

	// RVA: 0x17A2760
	protected override bool MatchLength() { }

	// RVA: 0x17A28EC
	protected override bool MatchPercentage() { }

	// RVA: 0x17A2A78
	protected override bool MatchColor() { }

	// RVA: 0x17A2BD8
	protected override bool MatchResource() { }

	// RVA: 0x17A2C84
	protected override bool MatchUrl() { }

	// RVA: 0x17A2D34
	protected override bool MatchTime() { }

	// RVA: 0x17A2E14
	protected override bool MatchCustomIdent() { }

	// RVA: 0x17A2F5C
	protected override bool MatchAngle() { }

	// RVA: 0x17A30F0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class Expression
{
	// Fields
	public ExpressionType type; // 0x10
	public ExpressionMultiplier multiplier; // 0x14
	public DataType dataType; // 0x20
	public ExpressionCombinator combinator; // 0x24
	public Expression[] subExpressions; // 0x28
	public string keyword; // 0x30

	// Methods

	// RVA: 0x17A31B4
	public void .ctor(ExpressionType type) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum ExpressionType
{
	// Fields
	public int value__; // 0x10
	public const ExpressionType Unknown = 0;
	public const ExpressionType Data = 1;
	public const ExpressionType Keyword = 2;
	public const ExpressionType Combinator = 3;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum DataType
{
	// Fields
	public int value__; // 0x10
	public const DataType None = 0;
	public const DataType Number = 1;
	public const DataType Integer = 2;
	public const DataType Length = 3;
	public const DataType Percentage = 4;
	public const DataType Color = 5;
	public const DataType Resource = 6;
	public const DataType Url = 7;
	public const DataType Time = 8;
	public const DataType Angle = 9;
	public const DataType CustomIdent = 10;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum ExpressionCombinator
{
	// Fields
	public int value__; // 0x10
	public const ExpressionCombinator None = 0;
	public const ExpressionCombinator Or = 1;
	public const ExpressionCombinator OrOr = 2;
	public const ExpressionCombinator AndAnd = 3;
	public const ExpressionCombinator Juxtaposition = 4;
	public const ExpressionCombinator Group = 5;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum ExpressionMultiplierType
{
	// Fields
	public int value__; // 0x10
	public const ExpressionMultiplierType None = 0;
	public const ExpressionMultiplierType ZeroOrMore = 1;
	public const ExpressionMultiplierType OneOrMore = 2;
	public const ExpressionMultiplierType ZeroOrOne = 3;
	public const ExpressionMultiplierType Ranges = 4;
	public const ExpressionMultiplierType OneOrMoreComma = 5;
	public const ExpressionMultiplierType GroupAtLeastOne = 6;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal struct ExpressionMultiplier
{
	// Fields
	public const int Infinity = 100;
	private ExpressionMultiplierType m_Type; // 0x10
	public int min; // 0x14
	public int max; // 0x18

	// Methods

	// RVA: 0x17A0F98
	public ExpressionMultiplierType get_type() { }

	// RVA: 0x17A3270
	public void set_type(ExpressionMultiplierType value) { }

	// RVA: 0x17A3214
	public void .ctor(ExpressionMultiplierType type) { }

	// RVA: 0x17A32CC
	private void SetType(ExpressionMultiplierType value) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class StyleSyntaxParser
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ProcessExpressionList; // 0x10
	private System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ExpressionStack; // 0x18
	private System.Collections.Generic.Stack<UnityEngine.UIElements.StyleSheets.Syntax.ExpressionCombinator> m_CombinatorStack; // 0x20
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.Syntax.Expression> m_ParsedExpressionCache; // 0x28

	// Methods

	// RVA: 0x17A3328
	public Expression Parse(string syntax) { }

	// RVA: 0x17A40F8
	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17A4D04
	private void ProcessCombinatorStack() { }

	// RVA: 0x17A4580
	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17A4B30
	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17A47AC
	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17A4FF0
	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17A5ACC
	private Expression ParseNonTerminalValue(string syntax) { }

	// RVA: 0x17A5C6C
	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17A5764
	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ExpressionMultiplier multiplier) { }

	// RVA: 0x17A6040
	private void ParseRanges(StyleSyntaxTokenizer tokenizer, int min, int max) { }

	// RVA: 0x17A59E8
	private static void EatSpace(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17A4FDC
	private static bool IsExpressionEnd(StyleSyntaxToken token) { }

	// RVA: 0x17A59D4
	private static bool IsCombinator(StyleSyntaxToken token) { }

	// RVA: 0x17A6028
	private static bool IsMultiplier(StyleSyntaxToken token) { }

	// RVA: 0x17A61E4
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal enum StyleSyntaxTokenType
{
	// Fields
	public int value__; // 0x10
	public const StyleSyntaxTokenType Unknown = 0;
	public const StyleSyntaxTokenType String = 1;
	public const StyleSyntaxTokenType Number = 2;
	public const StyleSyntaxTokenType Space = 3;
	public const StyleSyntaxTokenType SingleBar = 4;
	public const StyleSyntaxTokenType DoubleBar = 5;
	public const StyleSyntaxTokenType DoubleAmpersand = 6;
	public const StyleSyntaxTokenType Comma = 7;
	public const StyleSyntaxTokenType SingleQuote = 8;
	public const StyleSyntaxTokenType Asterisk = 9;
	public const StyleSyntaxTokenType Plus = 10;
	public const StyleSyntaxTokenType QuestionMark = 11;
	public const StyleSyntaxTokenType HashMark = 12;
	public const StyleSyntaxTokenType ExclamationPoint = 13;
	public const StyleSyntaxTokenType OpenBracket = 14;
	public const StyleSyntaxTokenType CloseBracket = 15;
	public const StyleSyntaxTokenType OpenBrace = 16;
	public const StyleSyntaxTokenType CloseBrace = 17;
	public const StyleSyntaxTokenType LessThan = 18;
	public const StyleSyntaxTokenType GreaterThan = 19;
	public const StyleSyntaxTokenType End = 20;
}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal struct StyleSyntaxToken
{
	// Fields
	public StyleSyntaxTokenType type; // 0x10
	public string text; // 0x18
	public int number; // 0x20

	// Methods

	// RVA: 0x17A636C
	public void .ctor(StyleSyntaxTokenType t) { }

	// RVA: 0x17A639C
	public void .ctor(StyleSyntaxTokenType type, string text) { }

	// RVA: 0x17A63CC
	public void .ctor(StyleSyntaxTokenType type, int number) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class StyleSyntaxTokenizer
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken> m_Tokens; // 0x10
	private int m_CurrentTokenIndex; // 0x18

	// Methods

	// RVA: 0x17A44A8
	public StyleSyntaxToken get_current() { }

	// RVA: 0x17A552C
	public StyleSyntaxToken MoveNext() { }

	// RVA: 0x17A58F8
	public StyleSyntaxToken PeekNext() { }

	// RVA: 0x17A35D8
	public void Tokenize(string syntax) { }

	// RVA: 0x17A6464
	private static bool IsNextCharacter(string s, int index, Char c) { }

	// RVA: 0x17A6574
	private static bool IsNextLetterOrDash(string s, int index) { }

	// RVA: 0x17A64B8
	private static bool IsNextNumber(string s, int index) { }

	// RVA: 0x17A6400
	private static int GlobCharacter(string s, int index, Char c) { }

	// RVA: 0x17A3544
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public static class Easing
{
	// Methods

	// RVA: 0x17A6660
	public static float Linear(float t) { }

	// RVA: 0x17A6664
	public static float InSine(float t) { }

	// RVA: 0x17A6698
	public static float OutSine(float t) { }

	// RVA: 0x17A66AC
	public static float InOutSine(float t) { }

	// RVA: 0x17A66E8
	public static float InQuad(float t) { }

	// RVA: 0x17A66F0
	public static float OutQuad(float t) { }

	// RVA: 0x17A6700
	public static float InOutQuad(float t) { }

	// RVA: 0x17A6740
	public static float InCubic(float t) { }

	// RVA: 0x17A6750
	public static float OutCubic(float t) { }

	// RVA: 0x17A67B4
	public static float InOutCubic(float t) { }

	// RVA: 0x17A6748
	public static float InPower(float t, int power) { }

	// RVA: 0x17A6778
	public static float OutPower(float t, int power) { }

	// RVA: 0x17A680C
	public static float InOutPower(float t, int power) { }

	// RVA: 0x17A6888
	public static float InBounce(float t) { }

	// RVA: 0x17A6988
	public static float OutBounce(float t) { }

	// RVA: 0x17A6A60
	public static float InOutBounce(float t) { }

	// RVA: 0x17A6CA4
	public static float InElastic(float t) { }

	// RVA: 0x17A6D30
	public static float OutElastic(float t) { }

	// RVA: 0x17A6DC0
	public static float InOutElastic(float t) { }

	// RVA: 0x17A6EF4
	public static float InBack(float t) { }

	// RVA: 0x17A6F20
	public static float OutBack(float t) { }

	// RVA: 0x17A6F58
	public static float InOutBack(float t) { }

	// RVA: 0x17A6FE0
	public static float InCirc(float t) { }

	// RVA: 0x17A7000
	public static float OutCirc(float t) { }

	// RVA: 0x17A701C
	public static float InOutCirc(float t) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerOverLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17A72D8
	private static void .cctor() { }

	// RVA: 0x17A7344
	public void .ctor() { }

	// RVA: 0x17A734C
	internal PointerOverLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerOverLinkTagEvent
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x17A7064
	private static void .cctor() { }

	// RVA: 0x17A7154
	private void set_linkID(string value) { }

	// RVA: 0x17A7164
	private void set_linkText(string value) { }

	// RVA: 0x17A7174
	protected override void Init() { }

	// RVA: 0x17A71D4
	private void LocalInit() { }

	// RVA: 0x17A71E0
	public static PointerOverLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x17A7278
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerMoveLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17A7654
	private static void .cctor() { }

	// RVA: 0x17A76C0
	public void .ctor() { }

	// RVA: 0x17A76C8
	internal PointerMoveLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerMoveLinkTagEvent
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x17A73E0
	private static void .cctor() { }

	// RVA: 0x17A74D0
	private void set_linkID(string value) { }

	// RVA: 0x17A74E0
	private void set_linkText(string value) { }

	// RVA: 0x17A74F0
	protected override void Init() { }

	// RVA: 0x17A7550
	private void LocalInit() { }

	// RVA: 0x17A755C
	public static PointerMoveLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x17A75F4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerOutLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17A796C
	private static void .cctor() { }

	// RVA: 0x17A79D8
	public void .ctor() { }

	// RVA: 0x17A79E0
	internal PointerOutLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerOutLinkTagEvent
{
	// Methods

	// RVA: 0x17A775C
	private static void .cctor() { }

	// RVA: 0x17A784C
	protected override void Init() { }

	// RVA: 0x17A78AC
	private void LocalInit() { }

	// RVA: 0x17A78B8
	public static PointerOutLinkTagEvent GetPooled(IPointerEvent evt, string linkID) { }

	// RVA: 0x17A790C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerDownLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17A7CE8
	private static void .cctor() { }

	// RVA: 0x17A7D54
	public void .ctor() { }

	// RVA: 0x17A7D5C
	internal PointerDownLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public sealed class PointerDownLinkTagEvent
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x17A7A74
	private static void .cctor() { }

	// RVA: 0x17A7B64
	private void set_linkID(string value) { }

	// RVA: 0x17A7B74
	private void set_linkText(string value) { }

	// RVA: 0x17A7B84
	protected override void Init() { }

	// RVA: 0x17A7BE4
	private void LocalInit() { }

	// RVA: 0x17A7BF0
	public static PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x17A7C88
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerUpLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17A8064
	private static void .cctor() { }

	// RVA: 0x17A80D0
	public void .ctor() { }

	// RVA: 0x17A80D8
	internal PointerUpLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerUpLinkTagEvent
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x17A7DF0
	private static void .cctor() { }

	// RVA: 0x17A7EE0
	private void set_linkID(string value) { }

	// RVA: 0x17A7EF0
	private void set_linkText(string value) { }

	// RVA: 0x17A7F00
	protected override void Init() { }

	// RVA: 0x17A7F60
	private void LocalInit() { }

	// RVA: 0x17A7F6C
	public static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x17A8004
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public struct StyleValues
{
	// Fields
	internal StyleValueCollection m_StyleValues; // 0x10

	// Methods

	// RVA: 0x17A816C
	public void set_top(float value) { }

	// RVA: 0x17A8278
	public void set_left(float value) { }

	// RVA: 0x17A8284
	public void set_width(float value) { }

	// RVA: 0x17A8290
	public void set_height(float value) { }

	// RVA: 0x17A829C
	public void set_right(float value) { }

	// RVA: 0x17A82A8
	public void set_bottom(float value) { }

	// RVA: 0x17A82B4
	public void set_color(Color value) { }

	// RVA: 0x17A83B0
	public void set_backgroundColor(Color value) { }

	// RVA: 0x17A83B8
	public void set_unityBackgroundImageTintColor(Color value) { }

	// RVA: 0x17A83C4
	public void set_borderColor(Color value) { }

	// RVA: 0x17A83D0
	public void set_marginLeft(float value) { }

	// RVA: 0x17A83DC
	public void set_marginTop(float value) { }

	// RVA: 0x17A83E8
	public void set_marginRight(float value) { }

	// RVA: 0x17A83F4
	public void set_marginBottom(float value) { }

	// RVA: 0x17A8400
	public void set_paddingLeft(float value) { }

	// RVA: 0x17A840C
	public float get_paddingTop() { }

	// RVA: 0x17A8538
	public void set_paddingTop(float value) { }

	// RVA: 0x17A8544
	public void set_paddingRight(float value) { }

	// RVA: 0x17A8550
	public void set_paddingBottom(float value) { }

	// RVA: 0x17A855C
	public void set_borderLeftWidth(float value) { }

	// RVA: 0x17A8568
	public void set_borderRightWidth(float value) { }

	// RVA: 0x17A8574
	public void set_borderTopWidth(float value) { }

	// RVA: 0x17A8580
	public void set_borderBottomWidth(float value) { }

	// RVA: 0x17A858C
	public void set_borderTopLeftRadius(float value) { }

	// RVA: 0x17A8598
	public void set_borderTopRightRadius(float value) { }

	// RVA: 0x17A85A4
	public void set_borderBottomLeftRadius(float value) { }

	// RVA: 0x17A85AC
	public void set_borderBottomRightRadius(float value) { }

	// RVA: 0x17A85B8
	public void set_opacity(float value) { }

	// RVA: 0x17A85C4
	public void set_flexGrow(float value) { }

	// RVA: 0x17A85D0
	public void set_flexShrink(float value) { }

	// RVA: 0x17A8178
	internal void SetValue(StylePropertyId id, float value) { }

	// RVA: 0x17A82BC
	internal void SetValue(StylePropertyId id, Color value) { }

	// RVA: 0x17A84B0
	internal StyleValueCollection Values() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public interface ITransitionAnimations
{
	// Methods

	// RVA: -1
	public abstract UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(StyleValues to, int durationMs) { }

}

// Namespace: UnityEngine.UIElements.Experimental
internal static class Lerp
{
	// Methods

	// RVA: 0x17A85DC
	public static float Interpolate(float start, float end, float ratio) { }

	// RVA: 0x17A85EC
	public static Color Interpolate(Color start, Color end, float ratio) { }

	// RVA: 0x17A8624
	internal static StyleValues Interpolate(StyleValues start, StyleValues end, float ratio) { }

}

// Namespace: UnityEngine.UIElements.Experimental
internal interface IValueAnimationUpdate
{
	// Methods

	// RVA: -1
	public abstract void Tick(Int64 currentTimeMs) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.ValueAnimation.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A17DC
	internal UnityEngine.UIElements.Experimental.ValueAnimation<T> <.cctor>b__67_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public sealed class ValueAnimation<T0>
{
	// Fields
	private Int64 m_StartTimeMs; // 0x0
	private int m_DurationMs; // 0x0
	private System.Func<System.Single,System.Single> <easingCurve>k__BackingField; // 0x0
	private bool <isRunning>k__BackingField; // 0x0
	private Action <onAnimationCompleted>k__BackingField; // 0x0
	private bool <autoRecycle>k__BackingField; // 0x0
	private bool <recycled>k__BackingField; // 0x0
	private static UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.Experimental.ValueAnimation<T>> sObjectPool; // 0x0
	private VisualElement <owner>k__BackingField; // 0x0
	private System.Action<UnityEngine.UIElements.VisualElement,T> <valueUpdated>k__BackingField; // 0x0
	private System.Func<UnityEngine.UIElements.VisualElement,T> <initialValue>k__BackingField; // 0x0
	private System.Func<T,T,System.Single,T> <interpolator>k__BackingField; // 0x0
	private T _from; // 0x0
	private bool fromValueSet; // 0x0
	private T <to>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30A14A4
	public int get_durationMs() { }

	// RVA: 0x30A24F0
	public void set_durationMs(int value) { }

	// RVA: 0x30A17DC
	public System.Func<System.Single,System.Single> get_easingCurve() { }

	// RVA: 0x30A27C0
	public void set_easingCurve(System.Func<System.Single,System.Single> value) { }

	// RVA: 0x30A1224
	public bool get_isRunning() { }

	// RVA: 0x30A2404
	private void set_isRunning(bool value) { }

	// RVA: 0x30A17DC
	public Action get_onAnimationCompleted() { }

	// RVA: 0x30A27C0
	public void set_onAnimationCompleted(Action value) { }

	// RVA: 0x30A1224
	public bool get_autoRecycle() { }

	// RVA: 0x30A2404
	public void set_autoRecycle(bool value) { }

	// RVA: 0x30A1224
	private bool get_recycled() { }

	// RVA: 0x30A2404
	private void set_recycled(bool value) { }

	// RVA: 0x30A17DC
	private VisualElement get_owner() { }

	// RVA: 0x30A27C0
	private void set_owner(VisualElement value) { }

	// RVA: 0x30A17DC
	public System.Action<UnityEngine.UIElements.VisualElement,T> get_valueUpdated() { }

	// RVA: 0x30A27C0
	public void set_valueUpdated(System.Action<UnityEngine.UIElements.VisualElement,T> value) { }

	// RVA: 0x30A17DC
	public System.Func<UnityEngine.UIElements.VisualElement,T> get_initialValue() { }

	// RVA: 0x30A27C0
	public void set_initialValue(System.Func<UnityEngine.UIElements.VisualElement,T> value) { }

	// RVA: 0x30A17DC
	public System.Func<T,T,System.Single,T> get_interpolator() { }

	// RVA: 0x30A27C0
	public void set_interpolator(System.Func<T,T,System.Single,T> value) { }

	// RVA: 0x315B3A8
	public T get_from() { }

	// RVA: 0x315B3A8
	public void set_from(T value) { }

	// RVA: 0x315B3A8
	public T get_to() { }

	// RVA: 0x315B3A8
	public void set_to(T value) { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A2378
	public void Start() { }

	// RVA: 0x30A2378
	public void Stop() { }

	// RVA: 0x30A2378
	public void Recycle() { }

	// RVA: -1
	private void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(Int64 currentTimeMs) { }

	// RVA: 0x30A2378
	private void SetDefaultValues() { }

	// RVA: 0x30A2378
	private void Unregister() { }

	// RVA: 0x30A2378
	private void Register() { }

	// RVA: 0x30A27C0
	internal void SetOwner(VisualElement e) { }

	// RVA: 0x30A2378
	private void CheckNotRecycled() { }

	// RVA: 0x30A53B0
	public static UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(VisualElement e, System.Func<T,T,System.Single,T> interpolator) { }

	// RVA: 0x30A17DC
	public UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMovePreview
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x17A8AEC
	public void .ctor() { }

	// RVA: 0x17A8BCC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMoveLocationPreview
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x17A8C7C
	public void .ctor() { }

	// RVA: 0x17A8DB0
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class ColumnMover
{
	// Fields
	private float m_StartPos; // 0x30
	private float m_LastPos; // 0x34
	private bool m_Active; // 0x38
	private bool m_Moving; // 0x39
	private bool m_Cancelled; // 0x3A
	private MultiColumnCollectionHeader m_Header; // 0x40
	private VisualElement m_PreviewElement; // 0x48
	private MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement; // 0x50
	private Column m_ColumnToMove; // 0x58
	private float m_ColumnToMovePos; // 0x60
	private float m_ColumnToMoveWidth; // 0x64
	private Column m_DestinationColumn; // 0x68
	private bool m_MoveBeforeDestination; // 0x70
	private ColumnLayout <columnLayout>k__BackingField; // 0x78
	private System.Action<UnityEngine.UIElements.Internal.ColumnMover> activeChanged; // 0x80
	private System.Action<UnityEngine.UIElements.Internal.ColumnMover> movingChanged; // 0x88

	// Methods

	// RVA: 0x17A8EA0
	public ColumnLayout get_columnLayout() { }

	// RVA: 0x17A8EA8
	public void set_columnLayout(ColumnLayout value) { }

	// RVA: 0x17A8EB0
	public bool get_active() { }

	// RVA: 0x17A8EB8
	public void set_active(bool value) { }

	// RVA: 0x17A8EEC
	public bool get_moving() { }

	// RVA: 0x17A8EF4
	public void set_moving(bool value) { }

	// RVA: 0x17A8F28
	public void add_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x17A8FDC
	public void remove_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x17A9090
	public void add_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x17A9144
	public void remove_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x17A91F8
	public void .ctor() { }

	// RVA: 0x17A9270
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x17A97B0
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x17A9CF0
	protected void OnMouseDown(MouseDownEvent evt) { }

	// RVA: 0x17A9FBC
	protected void OnMouseMove(MouseMoveEvent evt) { }

	// RVA: 0x17AA158
	protected void OnMouseUp(MouseUpEvent evt) { }

	// RVA: 0x17AA334
	private void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	// RVA: 0x17AA4AC
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x17AA5E8
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x17AA714
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x17AA854
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x17AA9C4
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x17AA954
	private static bool IsNotMouseEvent(int pointerId) { }

	// RVA: 0x17AA3C0
	protected void ProcessCancelEvent(EventBase evt, int pointerId) { }

	// RVA: 0x17AAC08
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x17A9DB4
	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x17AA030
	private void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	// RVA: 0x17AA20C
	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x17AAC84
	private void BeginDragMove(float pos) { }

	// RVA: 0x17AB114
	internal void DragMove(float pos) { }

	// RVA: 0x17AB498
	private void UpdatePreviewPosition() { }

	// RVA: 0x17AB11C
	private void UpdateMoveLocation() { }

	// RVA: 0x17AAAB0
	private void EndDragMove(bool cancelled) { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnResizePreview
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x17AB714
	public void .ctor() { }

	// RVA: 0x17AB848
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class ColumnResizer
{
	// Fields
	private Vector2 m_Start; // 0x30
	protected bool m_Active; // 0x38
	private bool m_Resizing; // 0x39
	private MultiColumnCollectionHeader m_Header; // 0x40
	private Column m_Column; // 0x48
	private VisualElement m_PreviewElement; // 0x50
	private ColumnLayout <columnLayout>k__BackingField; // 0x58
	private bool <preview>k__BackingField; // 0x60

	// Methods

	// RVA: 0x17AB938
	public ColumnLayout get_columnLayout() { }

	// RVA: 0x17AB940
	public void set_columnLayout(ColumnLayout value) { }

	// RVA: 0x17AB948
	public bool get_preview() { }

	// RVA: 0x17AB950
	public void set_preview(bool value) { }

	// RVA: 0x17AB958
	public void .ctor(Column column) { }

	// RVA: 0x17AB9F4
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x17ABC34
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x17ABE74
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x17ABF98
	private void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x17AC268
	private void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x17AC414
	private void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x17AC210
	private void BeginDragResize(float pos) { }

	// RVA: 0x17AC3C4
	private void DragResize(float pos) { }

	// RVA: 0x17AC598
	private void UpdatePreviewPosition() { }

	// RVA: 0x17ABF20
	private void EndDragResize(float pos, bool cancelled) { }

}

// Namespace: 
[Serializable]
private struct ColumnState
{
	// Fields
	public int index; // 0x10
	public string name; // 0x18
	public float actualWidth; // 0x20
	public Length width; // 0x24
	public bool visible; // 0x2C
}

// Namespace: 
[Serializable]
private class ViewState
{
	// Fields
	private bool m_HasPersistedData; // 0x10
	private System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> m_SortDescriptions; // 0x18
	private System.Collections.Generic.List<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ViewState.ColumnState> m_OrderedColumnStates; // 0x20

	// Methods

	// RVA: 0x17B19B4
	internal void Save(MultiColumnCollectionHeader header) { }

	// RVA: 0x17B15D0
	internal void Apply(MultiColumnCollectionHeader header) { }

	// RVA: 0x17B25EC
	public void .ctor() { }

}

// Namespace: 
internal class ColumnData
{
	// Fields
	private MultiColumnHeaderColumn <control>k__BackingField; // 0x10
	private MultiColumnHeaderColumnResizeHandle <resizeHandle>k__BackingField; // 0x18

	// Methods

	// RVA: 0x17B26CC
	public MultiColumnHeaderColumn get_control() { }

	// RVA: 0x17B26D4
	public void set_control(MultiColumnHeaderColumn value) { }

	// RVA: 0x17B26DC
	public MultiColumnHeaderColumnResizeHandle get_resizeHandle() { }

	// RVA: 0x17B26E4
	public void set_resizeHandle(MultiColumnHeaderColumnResizeHandle value) { }

	// RVA: 0x17AF1BC
	public void .ctor() { }

}

// Namespace: 
private struct SortedColumnState
{
	// Fields
	public SortColumnDescription columnDesc; // 0x10
	public SortDirection direction; // 0x18

	// Methods

	// RVA: 0x17AE904
	public void .ctor(SortColumnDescription desc, SortDirection dir) { }

}

// Namespace: 
private sealed class <>c__DisplayClass65_0
{
	// Fields
	public Column column; // 0x10
	public MultiColumnCollectionHeader <>4__this; // 0x18

	// Methods

	// RVA: 0x17B08D4
	public void .ctor() { }

	// RVA: 0x17B26EC
	internal void <OnContextualMenuManipulator>b__1(DropdownMenuAction a) { }

	// RVA: 0x17B2718
	internal Status <OnContextualMenuManipulator>b__2(DropdownMenuAction a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass71_0
{
	// Fields
	public Column column; // 0x10

	// Methods

	// RVA: 0x17B12EC
	public void .ctor() { }

	// RVA: 0x17B27AC
	internal bool <UpdateSortColumnDescriptionsOnClick>b__0(SortColumnDescription d) { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnCollectionHeader
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string columnContainerUssClassName; // 0x8
	public static readonly string handleContainerUssClassName; // 0x10
	public static readonly string reorderableUssClassName; // 0x18
	private bool m_SortingEnabled; // 0x3C8
	private System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns; // 0x3D0
	private SortColumnDescriptions m_SortDescriptions; // 0x3D8
	private System.Collections.Generic.List<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.SortedColumnState> m_OldSortedColumnStates; // 0x3E0
	private bool m_SortingUpdatesTemporarilyDisabled; // 0x3E8
	private ViewState m_ViewState; // 0x3F0
	private bool m_ApplyingViewState; // 0x3F8
	private bool m_DoLayoutScheduled; // 0x3F9
	private readonly System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ColumnData> <columnDataMap>k__BackingField; // 0x400
	private readonly ColumnLayout <columnLayout>k__BackingField; // 0x408
	private readonly VisualElement <columnContainer>k__BackingField; // 0x410
	private readonly VisualElement <resizeHandleContainer>k__BackingField; // 0x418
	private readonly Columns <columns>k__BackingField; // 0x420
	private System.Action<System.Int32,System.Single> columnResized; // 0x428
	private Action columnSortingChanged; // 0x430
	private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> contextMenuPopulateEvent; // 0x438
	private Action viewDataRestored; // 0x440

	// Methods

	// RVA: 0x17AC6A8
	internal bool get_isApplyingViewState() { }

	// RVA: 0x17AC6B0
	public System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ColumnData> get_columnDataMap() { }

	// RVA: 0x17AC6B8
	public ColumnLayout get_columnLayout() { }

	// RVA: 0x17AC6C0
	public VisualElement get_columnContainer() { }

	// RVA: 0x17AC6C8
	public VisualElement get_resizeHandleContainer() { }

	// RVA: 0x17AC6D0
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.SortColumnDescription> get_sortedColumns() { }

	// RVA: 0x17AC6D8
	public SortColumnDescriptions get_sortDescriptions() { }

	// RVA: 0x17AC6E0
	protected internal void set_sortDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x17ACF18
	public Columns get_columns() { }

	// RVA: 0x17ACF20
	public bool get_sortingEnabled() { }

	// RVA: 0x17ACF28
	public void set_sortingEnabled(bool value) { }

	// RVA: 0x17AD5A8
	public void add_columnResized(System.Action<System.Int32,System.Single> value) { }

	// RVA: 0x17AD660
	public void remove_columnResized(System.Action<System.Int32,System.Single> value) { }

	// RVA: 0x17AD718
	public void add_columnSortingChanged(Action value) { }

	// RVA: 0x17AD7C0
	public void remove_columnSortingChanged(Action value) { }

	// RVA: 0x17AD868
	public void add_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17AD920
	public void remove_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17AD9D8
	internal void add_viewDataRestored(Action value) { }

	// RVA: 0x17ADA80
	internal void remove_viewDataRestored(Action value) { }

	// RVA: 0x17ADB28
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x17AE7A4
	private void ScheduleDoLayout() { }

	// RVA: 0x17AE8CC
	private void ResizeToFit() { }

	// RVA: 0x17AC798
	private void UpdateSortedColumns() { }

	// RVA: 0x17AE9C0
	private void UpdateColumnControls() { }

	// RVA: 0x17AF1B8
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x17AE36C
	private void OnColumnAdded(Column column) { }

	// RVA: 0x17AF1C4
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x17AF4DC
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x17AFE00
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x17AFFC4
	private void OnColumnResized(Column column) { }

	// RVA: 0x17B000C
	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x17B08DC
	private void OnMoveManipulatorActivated(ColumnMover mover) { }

	// RVA: 0x17B09E4
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x17B0A84
	private void DoLayout() { }

	// RVA: 0x17B0AC8
	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17B0E38
	private void OnColumnClicked(EventBase evt) { }

	// RVA: 0x17B1064
	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) { }

	// RVA: 0x17B12F4
	public void ScrollHorizontally(float horizontalOffset) { }

	// RVA: 0x17B0D30
	private void RaiseColumnResized(int columnIndex) { }

	// RVA: 0x17AE978
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x17AF584
	private void ApplyColumnSorting() { }

	// RVA: 0x17ACF68
	private void UpdateSortingStatus() { }

	// RVA: 0x17B14BC
	internal override void OnViewDataReady() { }

	// RVA: 0x17AE930
	private void SaveViewState() { }

	// RVA: 0x17AF2B4
	private void CleanupColumnData(ColumnData data) { }

	// RVA: 0x17B2014
	public void Dispose() { }

	// RVA: 0x17B2474
	private static void .cctor() { }

	// RVA: 0x17B25B4
	private void <OnContextualMenuManipulator>b__65_0(DropdownMenuAction a) { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnSortIndicator
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string arrowUssClassName; // 0x8
	public static readonly string indexLabelUssClassName; // 0x10
	private Label m_IndexLabel; // 0x3C8

	// Methods

	// RVA: 0x17B2840
	public void set_sortOrderLabel(string value) { }

	// RVA: 0x17B2868
	public void .ctor() { }

	// RVA: 0x17B2A14
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnIcon
{
	// Fields
	public static readonly string ussClassName; // 0x0
	private bool <isImageInline>k__BackingField; // 0x40B

	// Methods

	// RVA: 0x17B2B4C
	public bool get_isImageInline() { }

	// RVA: 0x17B2B54
	public void set_isImageInline(bool value) { }

	// RVA: 0x17B2B5C
	public void .ctor() { }

	// RVA: 0x17B2C70
	public void UpdateClassList() { }

	// RVA: 0x17B2E14
	private static void .cctor() { }

	// RVA: 0x17B2EC4
	private void <.ctor>b__5_0(CustomStyleResolvedEvent evt) { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumn
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string sortableUssClassName; // 0x8
	public static readonly string sortedAscendingUssClassName; // 0x10
	public static readonly string sortedDescendingUssClassName; // 0x18
	public static readonly string movingUssClassName; // 0x20
	public static readonly string contentContainerUssClassName; // 0x28
	public static readonly string contentUssClassName; // 0x30
	public static readonly string defaultContentUssClassName; // 0x38
	public static readonly string hasIconUssClassName; // 0x40
	public static readonly string hasTitleUssClassName; // 0x48
	public static readonly string titleUssClassName; // 0x50
	public static readonly string iconElementName; // 0x58
	public static readonly string titleElementName; // 0x60
	private static readonly string s_BoundVEPropertyName; // 0x68
	private static readonly string s_BindingCallbackVEPropertyName; // 0x70
	private static readonly string s_UnbindingCallbackVEPropertyName; // 0x78
	private static readonly string s_DestroyCallbackVEPropertyName; // 0x80
	private VisualElement m_ContentContainer; // 0x3C8
	private VisualElement m_Content; // 0x3D0
	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; // 0x3D8
	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; // 0x3E0
	private Clickable <clickable>k__BackingField; // 0x3E8
	private ColumnMover <mover>k__BackingField; // 0x3F0
	private Column <column>k__BackingField; // 0x3F8

	// Methods

	// RVA: 0x17B2EC8
	public Clickable get_clickable() { }

	// RVA: 0x17B2ED0
	private void set_clickable(Clickable value) { }

	// RVA: 0x17B2EE0
	public ColumnMover get_mover() { }

	// RVA: 0x17B2EE8
	private void set_mover(ColumnMover value) { }

	// RVA: 0x17B2EF8
	public void set_sortOrderLabel(string value) { }

	// RVA: 0x17B2F18
	public Column get_column() { }

	// RVA: 0x17B2F20
	private void set_column(Column value) { }

	// RVA: 0x17B2F30
	public VisualElement get_content() { }

	// RVA: 0x17B2F38
	public void set_content(VisualElement value) { }

	// RVA: 0x17B31FC
	private bool get_isContentBound() { }

	// RVA: 0x17B32D4
	private void set_isContentBound(bool value) { }

	// RVA: 0x17B3394
	public void .ctor(Column column) { }

	// RVA: 0x17B409C
	private void OnColumnChanged(Column c, ColumnDataType role) { }

	// RVA: 0x17B42D0
	private void OnColumnResized(Column c) { }

	// RVA: 0x17B3EBC
	private void InitManipulators() { }

	// RVA: 0x17B42D4
	private void OnMoverChanged(ColumnMover mv) { }

	// RVA: 0x17B4288
	private void UpdateDataFromColumn() { }

	// RVA: 0x17B4460
	private void BindHeaderContent() { }

	// RVA: 0x17B4378
	private void UnbindHeaderContent() { }

	// RVA: 0x17B3034
	private void DestroyHeaderContent() { }

	// RVA: 0x17B4548
	private VisualElement CreateDefaultHeaderContent() { }

	// RVA: 0x17B46DC
	private void DefaultBindHeaderContent(VisualElement ve) { }

	// RVA: 0x17B3B98
	private void UpdateHeaderTemplate() { }

	// RVA: 0x17B3DAC
	private void UpdateGeometryFromColumn() { }

	// RVA: 0x17B4A58
	public void Dispose() { }

	// RVA: 0x17B4C00
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnResizeHandle
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string dragAreaUssClassName; // 0x8
	private readonly VisualElement <dragArea>k__BackingField; // 0x3C8

	// Methods

	// RVA: 0x17B5038
	public VisualElement get_dragArea() { }

	// RVA: 0x17B5040
	public void .ctor() { }

	// RVA: 0x17B5170
	private static void .cctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=10
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=10 4E0024C7427C17CC639390B3368A37AF4019570161E69CF30B89796DCC90F605; // 0x0
}


