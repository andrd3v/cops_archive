// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Yoga
internal sealed class BaselineFunction
{
	// Methods

	// RVA: 0x1733FB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17340D4
	public virtual float Invoke(YogaNode node, float width, float height) { }

}

// Namespace: UnityEngine.Yoga
internal sealed class Logger
{
	// Methods

	// RVA: 0x17340E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x173420C
	public virtual void Invoke(YogaConfig config, YogaNode node, YogaLogLevel level, string message) { }

}

// Namespace: UnityEngine.Yoga
internal sealed class MeasureFunction
{
	// Methods

	// RVA: 0x1734220
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1734344
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

}

// Namespace: UnityEngine.Yoga
internal class MeasureOutput
{
	// Methods

	// RVA: 0x1734358
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

	// RVA: 0x173435C
	private void .ctor(IntPtr ygConfig) { }

	// RVA: 0x17343E4
	public void .ctor() { }

	// RVA: 0x1734480
	protected override void Finalize() { }

	// RVA: 0x17345D0
	internal IntPtr get_Handle() { }

	// RVA: 0x1734644
	public bool get_UseWebDefaults() { }

	// RVA: 0x17346E4
	public void set_UseWebDefaults(bool value) { }

	// RVA: 0x17347B4
	public void set_PointScaleFactor(float value) { }

	// RVA: 0x1734884
	private static void .cctor() { }

}

// Namespace: UnityEngine.Yoga
internal static class YogaConstants
{
	// Methods

	// RVA: 0x173495C
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

	// RVA: 0x1734974
	public static IntPtr YGNodeNewWithConfig(IntPtr config) { }

	// RVA: 0x17349C4
	public static void YGNodeFree(IntPtr ygNode) { }

	// RVA: 0x1734A30
	private static void YGNodeFreeInternal(IntPtr ygNode) { }

	// RVA: 0x1734A80
	public static void YGSetManagedObject(IntPtr ygNode, YogaNode node) { }

	// RVA: 0x1734AE8
	public static void YGNodeSetConfig(IntPtr ygNode, IntPtr config) { }

	// RVA: 0x173491C
	public static IntPtr YGConfigGetDefault() { }

	// RVA: 0x1734440
	public static IntPtr YGConfigNew() { }

	// RVA: 0x17345D8
	public static void YGConfigFree(IntPtr config) { }

	// RVA: 0x1734B50
	private static void YGConfigFreeInternal(IntPtr config) { }

	// RVA: 0x173474C
	public static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults) { }

	// RVA: 0x1734694
	public static bool YGConfigGetUseWebDefaults(IntPtr config) { }

	// RVA: 0x173481C
	public static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint) { }

	// RVA: 0x1734BA0
	public static void YGNodeInsertChild(IntPtr node, IntPtr child, UInt32 index) { }

	// RVA: 0x1734BF8
	public static void YGNodeRemoveChild(IntPtr node, IntPtr child) { }

	// RVA: 0x1734C60
	public static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection) { }

	// RVA: 0x1734CC8
	public static void YGNodeMarkDirty(IntPtr node) { }

	// RVA: 0x1734D18
	public static bool YGNodeIsDirty(IntPtr node) { }

	// RVA: 0x1734D68
	public static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode) { }

	// RVA: 0x1734DD0
	public static void YGNodeSetMeasureFunc(IntPtr node) { }

	// RVA: 0x1734E20
	public static void YGNodeRemoveMeasureFunc(IntPtr node) { }

	// RVA: 0x1734E70
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	// RVA: 0x1734FBC
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	// RVA: 0x17350E8
	public static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout) { }

	// RVA: 0x1735150
	public static bool YGNodeGetHasNewLayout(IntPtr node) { }

	// RVA: 0x17351A0
	public static YogaDirection YGNodeStyleGetDirection(IntPtr node) { }

	// RVA: 0x17351F0
	public static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection) { }

	// RVA: 0x1735258
	public static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent) { }

	// RVA: 0x17352C0
	public static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent) { }

	// RVA: 0x1735328
	public static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems) { }

	// RVA: 0x1735390
	public static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf) { }

	// RVA: 0x17353F8
	public static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType) { }

	// RVA: 0x1735460
	public static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap) { }

	// RVA: 0x17354C8
	public static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap) { }

	// RVA: 0x1735530
	public static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display) { }

	// RVA: 0x1735598
	public static void YGNodeStyleSetFlex(IntPtr node, float flex) { }

	// RVA: 0x1735600
	public static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow) { }

	// RVA: 0x1735668
	public static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink) { }

	// RVA: 0x17356D0
	public static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis) { }

	// RVA: 0x1735738
	public static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis) { }

	// RVA: 0x17357A0
	public static void YGNodeStyleSetFlexBasisAuto(IntPtr node) { }

	// RVA: 0x17357F0
	public static void YGNodeStyleSetWidth(IntPtr node, float width) { }

	// RVA: 0x1735858
	public static void YGNodeStyleSetWidthPercent(IntPtr node, float width) { }

	// RVA: 0x17358C0
	public static void YGNodeStyleSetWidthAuto(IntPtr node) { }

	// RVA: 0x1735910
	public static void YGNodeStyleSetHeight(IntPtr node, float height) { }

	// RVA: 0x1735978
	public static void YGNodeStyleSetHeightPercent(IntPtr node, float height) { }

	// RVA: 0x17359E0
	public static void YGNodeStyleSetHeightAuto(IntPtr node) { }

	// RVA: 0x1735A30
	public static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth) { }

	// RVA: 0x1735A98
	public static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth) { }

	// RVA: 0x1735B00
	public static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight) { }

	// RVA: 0x1735B68
	public static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight) { }

	// RVA: 0x1735BD0
	public static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth) { }

	// RVA: 0x1735C38
	public static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth) { }

	// RVA: 0x1735CA0
	public static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight) { }

	// RVA: 0x1735D08
	public static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight) { }

	// RVA: 0x1735D70
	public static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position) { }

	// RVA: 0x1735DD0
	public static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position) { }

	// RVA: 0x1735E30
	public static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin) { }

	// RVA: 0x1735E90
	public static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin) { }

	// RVA: 0x1735EF0
	public static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge) { }

	// RVA: 0x1735F58
	public static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding) { }

	// RVA: 0x1735FB8
	public static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding) { }

	// RVA: 0x1736018
	public static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border) { }

	// RVA: 0x1736078
	public static float YGNodeLayoutGetLeft(IntPtr node) { }

	// RVA: 0x17360C8
	public static float YGNodeLayoutGetTop(IntPtr node) { }

	// RVA: 0x1736118
	public static float YGNodeLayoutGetRight(IntPtr node) { }

	// RVA: 0x1736168
	public static float YGNodeLayoutGetBottom(IntPtr node) { }

	// RVA: 0x17361B8
	public static float YGNodeLayoutGetWidth(IntPtr node) { }

	// RVA: 0x1736208
	public static float YGNodeLayoutGetHeight(IntPtr node) { }

	// RVA: 0x1736258
	public static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge) { }

	// RVA: 0x17362C0
	public static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge) { }

	// RVA: 0x1736328
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

	// RVA: 0x1736390
	public void .ctor(YogaConfig config) { }

	// RVA: 0x17364D0
	protected override void Finalize() { }

	// RVA: 0x173659C
	internal void set_Config(YogaConfig value) { }

	// RVA: 0x1736680
	public bool get_IsDirty() { }

	// RVA: 0x17366D0
	public virtual void MarkDirty() { }

	// RVA: 0x1736720
	public bool get_HasNewLayout() { }

	// RVA: 0x1736770
	public bool get_IsMeasureDefined() { }

	// RVA: 0x1736780
	public bool get_IsBaselineDefined() { }

	// RVA: 0x1736790
	public void CopyStyle(YogaNode srcNode) { }

	// RVA: 0x1736800
	public void set_FlexDirection(YogaFlexDirection value) { }

	// RVA: 0x1736868
	public void set_JustifyContent(YogaJustify value) { }

	// RVA: 0x17368D0
	public void set_Display(YogaDisplay value) { }

	// RVA: 0x1736938
	public void set_AlignItems(YogaAlign value) { }

	// RVA: 0x17369A0
	public void set_AlignSelf(YogaAlign value) { }

	// RVA: 0x1736A08
	public void set_AlignContent(YogaAlign value) { }

	// RVA: 0x1736A70
	public void set_PositionType(YogaPositionType value) { }

	// RVA: 0x1736AD8
	public void set_Wrap(YogaWrap value) { }

	// RVA: 0x1736B40
	public void set_Flex(float value) { }

	// RVA: 0x1736BA8
	public void set_FlexGrow(float value) { }

	// RVA: 0x1736C10
	public void set_FlexShrink(float value) { }

	// RVA: 0x1736C78
	public void set_FlexBasis(YogaValue value) { }

	// RVA: 0x1736D8C
	public void set_Width(YogaValue value) { }

	// RVA: 0x1736E90
	public void set_Height(YogaValue value) { }

	// RVA: 0x1736F94
	public void set_MaxWidth(YogaValue value) { }

	// RVA: 0x1737040
	public void set_MaxHeight(YogaValue value) { }

	// RVA: 0x17370EC
	public void set_MinWidth(YogaValue value) { }

	// RVA: 0x1737198
	public void set_MinHeight(YogaValue value) { }

	// RVA: 0x1737244
	public float get_LayoutX() { }

	// RVA: 0x1737294
	public float get_LayoutY() { }

	// RVA: 0x17372E4
	public float get_LayoutRight() { }

	// RVA: 0x1737334
	public float get_LayoutBottom() { }

	// RVA: 0x1737384
	public float get_LayoutWidth() { }

	// RVA: 0x17373D4
	public float get_LayoutHeight() { }

	// RVA: 0x1737424
	public void set_Overflow(YogaOverflow value) { }

	// RVA: 0x173748C
	public int get_Count() { }

	// RVA: 0x17374E4
	public void MarkLayoutSeen() { }

	// RVA: 0x173753C
	public void Insert(int index, YogaNode node) { }

	// RVA: 0x1737684
	public void RemoveAt(int index) { }

	// RVA: 0x173776C
	public void Clear() { }

	// RVA: 0x17377D4
	public void SetMeasureFunction(MeasureFunction measureFunction) { }

	// RVA: 0x17378F8
	public void CalculateLayout(float width, float height) { }

	// RVA: 0x1734F38
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x173506C
	public static float BaselineInternal(YogaNode node, float width, float height) { }

	// RVA: 0x17379A4
	public System.Collections.Generic.IEnumerator<UnityEngine.Yoga.YogaNode> GetEnumerator() { }

	// RVA: 0x1737B34
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1737CC4
	public void set_Left(YogaValue value) { }

	// RVA: 0x1737DD0
	public void set_Top(YogaValue value) { }

	// RVA: 0x1737E54
	public void set_Right(YogaValue value) { }

	// RVA: 0x1737ED8
	public void set_Bottom(YogaValue value) { }

	// RVA: 0x1737D48
	private void SetStylePosition(YogaEdge edge, YogaValue value) { }

	// RVA: 0x1737F5C
	public void set_MarginLeft(YogaValue value) { }

	// RVA: 0x173811C
	public void set_MarginTop(YogaValue value) { }

	// RVA: 0x1738200
	public void set_MarginRight(YogaValue value) { }

	// RVA: 0x17382E4
	public void set_MarginBottom(YogaValue value) { }

	// RVA: 0x1738040
	private void SetStyleMargin(YogaEdge edge, YogaValue value) { }

	// RVA: 0x17383C8
	public void set_PaddingLeft(YogaValue value) { }

	// RVA: 0x17384D4
	public void set_PaddingTop(YogaValue value) { }

	// RVA: 0x1738558
	public void set_PaddingRight(YogaValue value) { }

	// RVA: 0x17385DC
	public void set_PaddingBottom(YogaValue value) { }

	// RVA: 0x173844C
	private void SetStylePadding(YogaEdge edge, YogaValue value) { }

	// RVA: 0x1738660
	public void set_BorderLeftWidth(float value) { }

	// RVA: 0x17386B4
	public void set_BorderTopWidth(float value) { }

	// RVA: 0x1738708
	public void set_BorderRightWidth(float value) { }

	// RVA: 0x173875C
	public void set_BorderBottomWidth(float value) { }

	// RVA: 0x17387B0
	public float get_LayoutMarginLeft() { }

	// RVA: 0x1738808
	public float get_LayoutMarginTop() { }

	// RVA: 0x1738860
	public float get_LayoutMarginRight() { }

	// RVA: 0x17388B8
	public float get_LayoutMarginBottom() { }

	// RVA: 0x1738910
	public float get_LayoutPaddingLeft() { }

	// RVA: 0x1738968
	public float get_LayoutPaddingTop() { }

	// RVA: 0x17389C0
	public float get_LayoutPaddingRight() { }

	// RVA: 0x1738A18
	public float get_LayoutPaddingBottom() { }

	// RVA: 0x1738A70
	public float get_LayoutBorderLeft() { }

	// RVA: 0x1738AC8
	public float get_LayoutBorderTop() { }

	// RVA: 0x1738B20
	public float get_LayoutBorderRight() { }

	// RVA: 0x1738B78
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

	// RVA: 0x1736D7C
	public YogaUnit get_Unit() { }

	// RVA: 0x1736D84
	public float get_Value() { }

	// RVA: 0x1738BD0
	public static YogaValue Point(float value) { }

	// RVA: 0x1738BF0
	public bool Equals(YogaValue other) { }

	// RVA: 0x1738C74
	public override bool Equals(object obj) { }

	// RVA: 0x1738D54
	public override int GetHashCode() { }

	// RVA: 0x1738D9C
	public static YogaValue Auto() { }

	// RVA: 0x1738DA8
	public static YogaValue Percent(float value) { }

	// RVA: 0x1738DC8
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

	// RVA: 0x1738DE8
	internal static float RoundToPixelGrid(float v, float pixelsPerPoint, float offset) { }

	// RVA: 0x1738E04
	internal static float CeilToPixelGrid(float v, float pixelsPerPoint, float offset) { }

	// RVA: 0x1738E18
	internal static float RoundToPanelPixelSize(VisualElement ve, float v) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class AtlasBase
{
	// Fields
	internal TextureRegistry textureRegistry; // 0x10

	// Methods

	// RVA: 0x1738E68
	public virtual bool TryGetAtlas(VisualElement ctx, Texture2D src, TextureId atlas, RectInt atlasRect) { }

	// RVA: 0x1738EE0
	public virtual void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) { }

	// RVA: 0x1738EE4
	public virtual void Reset() { }

	// RVA: 0x1738EE8
	protected virtual void OnAssignedToPanel(IPanel panel) { }

	// RVA: 0x1738EEC
	protected virtual void OnRemovedFromPanel(IPanel panel) { }

	// RVA: 0x1738EF0
	protected virtual void OnUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x1738EF4
	internal void InvokeAssignedToPanel(IPanel panel) { }

	// RVA: 0x1738F00
	internal void InvokeRemovedFromPanel(IPanel panel) { }

	// RVA: 0x1738F0C
	internal void InvokeUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x1738F18
	protected static void RepaintTexturedElements(IPanel panel) { }

	// RVA: 0x1738FFC
	protected void SetDynamicTexture(TextureId id, Texture texture) { }

	// RVA: 0x1739020
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

	// RVA: 0x17390F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17391B0
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

	// RVA: 0x1739EC4
	private static TextureInfo Create() { }

	// RVA: 0x1739FA4
	private static void Reset(TextureInfo info) { }

	// RVA: 0x1739F50
	public void .ctor() { }

	// RVA: 0x1739FE8
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

	// RVA: 0x17391C4
	internal bool get_isInitialized() { }

	// RVA: 0x17391E4
	protected override void OnAssignedToPanel(IPanel panel) { }

	// RVA: 0x1739278
	protected override void OnRemovedFromPanel(IPanel panel) { }

	// RVA: 0x17393BC
	public override void Reset() { }

	// RVA: 0x173947C
	private void InitPages() { }

	// RVA: 0x1739320
	private void DestroyPages() { }

	// RVA: 0x1739594
	public override bool TryGetAtlas(VisualElement ve, Texture2D src, TextureId atlas, RectInt atlasRect) { }

	// RVA: 0x1739944
	public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) { }

	// RVA: 0x1739A90
	protected override void OnUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x1739B18
	internal static bool IsTextureFormatSupported(TextureFormat format) { }

	// RVA: 0x1739B4C
	public virtual bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode) { }

	// RVA: 0x1739CE8
	public void set_minAtlasSize(int value) { }

	// RVA: 0x1739D08
	public void set_maxAtlasSize(int value) { }

	// RVA: 0x1739D28
	public static DynamicAtlasFilters get_defaultFilters() { }

	// RVA: 0x1739D30
	public void set_activeFilters(DynamicAtlasFilters value) { }

	// RVA: 0x1739CE0
	public int get_maxSubTextureSize() { }

	// RVA: 0x1739D50
	public void set_maxSubTextureSize(int value) { }

	// RVA: 0x1739D70
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	// RVA: 0x1739DD8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public struct BackgroundPosition
{
	// Fields
	public BackgroundPositionKeyword keyword; // 0x10
	public Length offset; // 0x14

	// Methods

	// RVA: 0x173A128
	public void .ctor(BackgroundPositionKeyword keyword) { }

	// RVA: 0x173A16C
	public void .ctor(BackgroundPositionKeyword keyword, Length offset) { }

	// RVA: 0x173A178
	internal static BackgroundPosition Initial() { }

	// RVA: 0x173A1F8
	public override bool Equals(object obj) { }

	// RVA: 0x173A2CC
	public bool Equals(BackgroundPosition other) { }

	// RVA: 0x173A31C
	public override int GetHashCode() { }

	// RVA: 0x173A368
	public static bool op_Equality(BackgroundPosition style1, BackgroundPosition style2) { }

	// RVA: 0x173A3B8
	public static bool op_Inequality(BackgroundPosition style1, BackgroundPosition style2) { }

	// RVA: 0x173A40C
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public static class BackgroundPropertyHelper
{
	// Methods

	// RVA: 0x173A1B8
	public static BackgroundPosition ConvertScaleModeToBackgroundPosition(ScaleMode scaleMode) { }

	// RVA: 0x173A4D0
	public static BackgroundRepeat ConvertScaleModeToBackgroundRepeat(ScaleMode scaleMode) { }

	// RVA: 0x173A4E0
	public static BackgroundSize ConvertScaleModeToBackgroundSize(ScaleMode scaleMode) { }

	// RVA: 0x173A630
	public static ScaleMode ResolveUnityBackgroundScaleMode(BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize, bool valid) { }

}

// Namespace: UnityEngine.UIElements
public struct BackgroundRepeat
{
	// Fields
	public Repeat x; // 0x10
	public Repeat y; // 0x14

	// Methods

	// RVA: 0x173A4D8
	public void .ctor(Repeat repeatX, Repeat repeatY) { }

	// RVA: 0x173AA90
	internal static BackgroundRepeat Initial() { }

	// RVA: 0x173AA98
	public override bool Equals(object obj) { }

	// RVA: 0x173AB38
	public bool Equals(BackgroundRepeat other) { }

	// RVA: 0x173AB60
	public override int GetHashCode() { }

	// RVA: 0x173AA24
	public static bool op_Equality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	// RVA: 0x173ABAC
	public static bool op_Inequality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	// RVA: 0x173ABB8
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

	// RVA: 0x173AC60
	public BackgroundSizeType get_sizeType() { }

	// RVA: 0x173AC68
	public void set_sizeType(BackgroundSizeType value) { }

	// RVA: 0x173ACC8
	public Length get_x() { }

	// RVA: 0x173ACD0
	public void set_x(Length value) { }

	// RVA: 0x173ACDC
	public Length get_y() { }

	// RVA: 0x173ACE4
	public void set_y(Length value) { }

	// RVA: 0x173A620
	public void .ctor(Length sizeX, Length sizeY) { }

	// RVA: 0x173A5C0
	public void .ctor(BackgroundSizeType sizeType) { }

	// RVA: 0x173ACF0
	internal static BackgroundSize Initial() { }

	// RVA: 0x173AD44
	public override bool Equals(object obj) { }

	// RVA: 0x173AE18
	public bool Equals(BackgroundSize other) { }

	// RVA: 0x173AE70
	public override int GetHashCode() { }

	// RVA: 0x173AA30
	public static bool op_Equality(BackgroundSize style1, BackgroundSize style2) { }

	// RVA: 0x173AED8
	public static bool op_Inequality(BackgroundSize style1, BackgroundSize style2) { }

	// RVA: 0x173AF50
	public override string ToString() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x173B0D0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_PropertyPath; // 0x70

	// Methods

	// RVA: 0x173B124
	public void .ctor() { }

	// RVA: 0x173B1C8
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
public class BindableElement
{
	// Fields
	private IBinding <binding>k__BackingField; // 0x3C8
	private string <bindingPath>k__BackingField; // 0x3D0

	// Methods

	// RVA: 0x173B030
	public IBinding get_binding() { }

	// RVA: 0x173B038
	public void set_bindingPath(string value) { }

	// RVA: 0x173B048
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

	// RVA: 0x173B324
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x173B3A0
	public static bool get_disableBindingsThrottling() { }

	// RVA: 0x173B41C
	private IBinding GetBindingObjectFromElement(VisualElement ve) { }

	// RVA: 0x173B6A8
	private void StartTracking(VisualElement ve) { }

	// RVA: 0x173B734
	private void StopTracking(VisualElement ve) { }

	// RVA: 0x173B7C0
	public System.Collections.Generic.Dictionary<System.Object,System.Object> get_temporaryObjectCache() { }

	// RVA: 0x173B604
	public static IBinding GetAdditionalBinding(VisualElement ve) { }

	// RVA: 0x173B7C8
	private void StartTrackingRecursive(VisualElement ve) { }

	// RVA: 0x173B938
	private void StopTrackingRecursive(VisualElement ve) { }

	// RVA: 0x173BAB4
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x173BC4C
	protected override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	// RVA: 0x173BC64
	private static Int64 CurrentTime() { }

	// RVA: 0x173BCD4
	public void PerformTrackingOperations() { }

	// RVA: 0x173C054
	public override void Update() { }

	// RVA: 0x173C7A8
	private void UpdateBindings() { }

	// RVA: 0x173CF84
	public void .ctor() { }

	// RVA: 0x173D128
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

	// RVA: 0x30D4CD4
	public void add_dragging(Action value) { }

	// RVA: 0x30D4CD4
	public void remove_dragging(Action value) { }

	// RVA: 0x30D4CD4
	public void add_draggingEnded(Action value) { }

	// RVA: 0x30D4CD4
	public void remove_draggingEnded(Action value) { }

	// RVA: 0x318DB98
	public DragDirection get_dragDirection() { }

	// RVA: 0x318DB98
	public void set_dragDirection(DragDirection value) { }

	// RVA: 0x30D4CD4
	private void set_slider(UnityEngine.UIElements.BaseSlider<T> value) { }

	// RVA: -1
	public Vector2 get_startMousePosition() { }

	// RVA: -1
	private void set_startMousePosition(Vector2 value) { }

	// RVA: -1
	public Vector2 get_delta() { }

	// RVA: 0x30D5108
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

	// RVA: 0x173D2D4
	public void add_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value) { }

	// RVA: 0x173D388
	public void remove_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value) { }

	// RVA: 0x173D43C
	public void add_clicked(Action value) { }

	// RVA: 0x173D4E0
	public void remove_clicked(Action value) { }

	// RVA: 0x173D584
	protected bool get_active() { }

	// RVA: 0x173D58C
	protected void set_active(bool value) { }

	// RVA: 0x173D594
	public Vector2 get_lastMousePosition() { }

	// RVA: 0x173D59C
	private void set_lastMousePosition(Vector2 value) { }

	// RVA: 0x173D5A4
	internal bool get_acceptClicksIfDisabled() { }

	// RVA: 0x173D5AC
	internal void set_acceptClicksIfDisabled(bool value) { }

	// RVA: 0x173D600
	private InvokePolicy get_invokePolicy() { }

	// RVA: 0x173D608
	public void .ctor(Action handler, Int64 delay, Int64 interval) { }

	// RVA: 0x173D764
	public void .ctor(System.Action<UnityEngine.UIElements.EventBase> handler) { }

	// RVA: 0x173D6C0
	public void .ctor(Action handler) { }

	// RVA: 0x173D800
	private void OnTimer(TimerState timerState) { }

	// RVA: 0x173D918
	private bool IsRepeatable() { }

	// RVA: 0x173DA1C
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x173DF00
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x173E3C0
	protected void OnMouseDown(MouseDownEvent evt) { }

	// RVA: 0x173E48C
	protected void OnMouseMove(MouseMoveEvent evt) { }

	// RVA: 0x173E508
	protected void OnMouseUp(MouseUpEvent evt) { }

	// RVA: 0x173E5DC
	private void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	// RVA: 0x173E670
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x173E7B4
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x173E8E8
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x173EA34
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x173EBAC
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x173D93C
	private bool ContainsPointer(int pointerId) { }

	// RVA: 0x173EB3C
	private static bool IsNotMouseEvent(int pointerId) { }

	// RVA: 0x173D9C0
	protected void Invoke(EventBase evt) { }

	// RVA: 0x173ECA0
	internal void SimulateSingleClick(EventBase evt, int delayMs) { }

	// RVA: 0x173EEDC
	protected virtual void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x173F2F0
	protected virtual void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	// RVA: 0x173F384
	protected virtual void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x173F570
	protected virtual void ProcessCancelEvent(EventBase evt, int pointerId) { }

	// RVA: 0x173F6F0
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

	// RVA: 0x173FDD8
	public void Reset() { }

	// RVA: 0x173FABC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ClickDetector
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.ClickDetector.ButtonClickStatus> m_ClickStatus; // 0x10
	private static int <s_DoubleClickTime>k__BackingField; // 0x0

	// Methods

	// RVA: 0x173F730
	internal static int get_s_DoubleClickTime() { }

	// RVA: 0x173F7AC
	internal static void set_s_DoubleClickTime(int value) { }

	// RVA: 0x173F838
	public void .ctor() { }

	// RVA: 0x173FAC4
	private void StartClickTracking(EventBase evt) { }

	// RVA: 0x173FE50
	private void SendClickEvent(EventBase evt) { }

	// RVA: 0x174037C
	private void CancelClickTracking(EventBase evt) { }

	// RVA: 0x17404E8
	public void ProcessEvent(EventBase evt) { }

	// RVA: 0x1740234
	private static bool ContainsPointer(VisualElement element, Vector2 position) { }

	// RVA: 0x1740AE8
	internal void Cleanup(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x1740E1C
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

	// RVA: 0x1740E6C
	public void add_itemsSourceSizeChanged(Action value) { }

	// RVA: 0x1740F10
	public void remove_itemsSourceSizeChanged(Action value) { }

	// RVA: 0x1740FB4
	public void add_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x1741068
	public void remove_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x174111C
	public void add_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x17411D0
	public void remove_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x1741284
	protected BaseListView get_baseListView() { }

	// RVA: 0x174130C
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1741574
	internal void PostInitRegistration(ReusableListViewItem listItem) { }

	// RVA: 0x1741A0C
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x1741DD0
	public virtual bool NeedsDragHandle(int index) { }

	// RVA: 0x1741DD8
	public virtual void AddItems(int itemCount) { }

	// RVA: 0x174279C
	public virtual void Move(int index, int newIndex) { }

	// RVA: 0x1742BE0
	public virtual void RemoveItem(int index) { }

	// RVA: 0x1742D38
	public virtual void RemoveItems(System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x1743248
	internal virtual void RemoveItems(int itemCount) { }

	// RVA: 0x1743410
	public virtual void ClearItems() { }

	// RVA: 0x1742780
	protected void RaiseOnSizeChanged() { }

	// RVA: 0x1742764
	protected void RaiseItemsAdded(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1742FD4
	protected void RaiseItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1742638
	private static Array AddToArray(Array source, int itemCount) { }

	// RVA: 0x1742FF0
	private static Array RemoveFromArray(Array source, System.Collections.Generic.List<System.Int32> indicesToRemove) { }

	// RVA: 0x174292C
	private void Swap(int lhs, int rhs) { }

	// RVA: 0x17424C0
	private void EnsureItemSourceCanBeResized() { }

	// RVA: 0x17435E0
	protected void .ctor() { }

	// RVA: 0x17435F0
	internal static bool <AddItems>g__IsGenericList|15_0(Type t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public BaseTreeViewController <>4__this; // 0x10
	public ReusableTreeViewItem treeItem; // 0x18

	// Methods

	// RVA: 0x1744A30
	public void .ctor() { }

	// RVA: 0x17480D0
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

	// RVA: 0x17436B8
	protected BaseTreeView get_baseTreeView() { }

	// RVA: 0x1743740
	public override IList get_itemsSource() { }

	// RVA: 0x1743748
	public override void set_itemsSource(IList value) { }

	// RVA: 0x174379C
	public void RebuildTree() { }

	// RVA: 0x1743D00
	public System.Collections.Generic.IEnumerable<System.Int32> GetRootItemIds() { }

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

	// RVA: -1
	public abstract int GetParentId(int id) { }

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	public abstract void Move(int id, int newParentId, int childIndex, bool rebuildTree) { }

	// RVA: 0x1743D08
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x17441B4
	internal override void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x1744678
	internal override void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1743DC8
	internal void PostInitRegistration(ReusableTreeViewItem treeItem) { }

	// RVA: 0x1744BA0
	private void OnItemPointerUp(PointerUpEvent evt) { }

	// RVA: 0x17454DC
	private void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

	// RVA: 0x1746B54
	public override int GetIndexForId(int id) { }

	// RVA: 0x1746C54
	public override int GetIdForIndex(int index) { }

	// RVA: 0x1746DB8
	public virtual bool HasChildren(int id) { }

	// RVA: 0x1746E44
	internal bool Exists(int id) { }

	// RVA: 0x1744578
	public bool HasChildrenByIndex(int index) { }

	// RVA: 0x17453F0
	public System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIdsByIndex(int index) { }

	// RVA: 0x1746EB8
	public int GetChildIndexForId(int id) { }

	// RVA: 0x1747224
	internal int GetIndentationDepth(int id) { }

	// RVA: 0x17443C4
	internal int GetIndentationDepthByIndex(int index) { }

	// RVA: 0x174729C
	internal virtual bool CanChangeExpandedState(int id) { }

	// RVA: 0x17472A4
	public bool IsExpanded(int id) { }

	// RVA: 0x1744464
	public bool IsExpandedByIndex(int index) { }

	// RVA: 0x1745DDC
	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh) { }

	// RVA: 0x1747924
	public void ExpandItem(int id, bool expandAllChildren, bool refresh) { }

	// RVA: 0x174568C
	public void CollapseItemByIndex(int index, bool collapseAllChildren) { }

	// RVA: 0x1747BDC
	public void CollapseItem(int id, bool collapseAllChildren) { }

	// RVA: 0x1743C00
	internal void RegenerateWrappers() { }

	// RVA: 0x174738C
	private void CreateWrappers(System.Collections.Generic.IEnumerable<System.Int32> treeViewItemIds, int depth, System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>& wrappers) { }

	// RVA: 0x1746D40
	private bool IsIndexValid(int index) { }

	// RVA: 0x1747E14
	internal void RaiseItemParentChanged(int id, int newParentId) { }

	// RVA: 0x1747E54
	protected void .ctor() { }

	// RVA: 0x1748000
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

	// RVA: 0x1748100
	public void add_itemsSourceChanged(Action value) { }

	// RVA: 0x17481A4
	public void remove_itemsSourceChanged(Action value) { }

	// RVA: 0x1748248
	public void add_itemIndexChanged(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x17482FC
	public void remove_itemIndexChanged(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x17483B0
	public virtual IList get_itemsSource() { }

	// RVA: 0x17483B8
	public virtual void set_itemsSource(IList value) { }

	// RVA: 0x1747E0C
	protected void SetItemsSourceWithoutNotify(IList source) { }

	// RVA: 0x17484A8
	protected BaseVerticalCollectionView get_view() { }

	// RVA: 0x17484B0
	public void SetView(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x1748574
	protected virtual void PrepareView() { }

	// RVA: 0x1748578
	public virtual void Dispose() { }

	// RVA: 0x17485BC
	public virtual int GetItemsCount() { }

	// RVA: 0x1748680
	internal virtual int GetItemsMinCount() { }

	// RVA: 0x174868C
	public virtual int GetIndexForId(int id) { }

	// RVA: 0x1748694
	public virtual int GetIdForIndex(int index) { }

	// RVA: 0x174869C
	public virtual object GetItemForIndex(int index) { }

	// RVA: 0x17487F8
	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1741CE8
	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x174883C
	internal virtual void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x1744A08
	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	// RVA: -1
	protected abstract VisualElement MakeItem() { }

	// RVA: -1
	protected abstract void BindItem(VisualElement element, int index) { }

	// RVA: -1
	protected abstract void UnbindItem(VisualElement element, int index) { }

	// RVA: -1
	protected abstract void DestroyItem(VisualElement element) { }

	// RVA: 0x174848C
	protected void RaiseItemsSourceChanged() { }

	// RVA: 0x1742BA0
	protected void RaiseItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x17435E8
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultMultiColumnTreeViewController<T0>
{
	// Fields
	private UnityEngine.UIElements.TreeDataController<T> m_TreeDataController; // 0x0

	// Methods

	// RVA: 0x30D3CF0
	private UnityEngine.UIElements.TreeDataController<T> get_treeDataController() { }

	// RVA: 0x30D5108
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x30D3CF0
	public override IList get_itemsSource() { }

	// RVA: 0x30D4CD4
	public override void set_itemsSource(IList value) { }

	// RVA: 0x30D4CD4
	public void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items) { }

	// RVA: -1
	public override object GetItemForIndex(int index) { }

	// RVA: -1
	public override int GetParentId(int id) { }

	// RVA: 0x30D376C
	public override bool HasChildren(int id) { }

	// RVA: -1
	public override System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	public override void Move(int id, int newParentId, int childIndex, bool rebuildTree) { }

	// RVA: -1
	private bool IsChildOf(int childId, int id) { }

	// RVA: 0x30D3DA0
	public override System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultTreeViewController<T0>
{
	// Fields
	private UnityEngine.UIElements.TreeDataController<T> m_TreeDataController; // 0x0

	// Methods

	// RVA: 0x30D3CF0
	private UnityEngine.UIElements.TreeDataController<T> get_treeDataController() { }

	// RVA: 0x30D3CF0
	public override IList get_itemsSource() { }

	// RVA: 0x30D4CD4
	public override void set_itemsSource(IList value) { }

	// RVA: 0x30D4CD4
	public void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items) { }

	// RVA: -1
	public override object GetItemForIndex(int index) { }

	// RVA: -1
	public override int GetParentId(int id) { }

	// RVA: 0x30D376C
	public override bool HasChildren(int id) { }

	// RVA: -1
	public override System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	public override void Move(int id, int newParentId, int childIndex, bool rebuildTree) { }

	// RVA: -1
	private bool IsChildOf(int childId, int id) { }

	// RVA: 0x30D3DA0
	public override System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ListViewController
{
	// Methods

	// RVA: 0x174887C
	protected ListView get_listView() { }

	// RVA: 0x1748904
	protected override VisualElement MakeItem() { }

	// RVA: 0x1748A64
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x1748CD0
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x1748D88
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x1748E38
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MultiColumnListViewController
{
	// Fields
	private MultiColumnController m_ColumnController; // 0x48

	// Methods

	// RVA: 0x1748E40
	public MultiColumnController get_columnController() { }

	// RVA: 0x1748E48
	internal MultiColumnCollectionHeader get_header() { }

	// RVA: 0x1748E60
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x1748EF8
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1749428
	protected override VisualElement MakeItem() { }

	// RVA: 0x1749448
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x17494D4
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x17494F4
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x1749514
	protected override void PrepareView() { }

	// RVA: 0x1749738
	public override void Dispose() { }

	// RVA: 0x174999C
	private void UpdateReorderClassList() { }

}

// Namespace: UnityEngine.UIElements
public abstract class MultiColumnTreeViewController
{
	// Fields
	private MultiColumnController m_ColumnController; // 0x58

	// Methods

	// RVA: 0x1749B18
	public MultiColumnController get_columnController() { }

	// RVA: 0x1749B20
	internal MultiColumnCollectionHeader get_header() { }

	// RVA: 0x1749B38
	protected void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x1749BF0
	internal override void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x174A130
	protected override VisualElement MakeItem() { }

	// RVA: 0x174A150
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x174A1DC
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x174A1FC
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x174A21C
	protected override void PrepareView() { }

	// RVA: 0x174A244
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

	// RVA: 0x30D4A04
	public void .ctor(int <>1__state) { }

	// RVA: 0x30D488C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30D3738
	private bool MoveNext() { }

	// RVA: 0x30D39B8
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x30D4A04
	public void .ctor(int <>1__state) { }

	// RVA: 0x30D488C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30D3738
	private bool MoveNext() { }

	// RVA: 0x30D488C
	private void <>m__Finally1() { }

	// RVA: 0x30D39B8
	private int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class TreeDataController<T0>
{
	// Fields
	private UnityEngine.UIElements.TreeData<T> m_TreeData; // 0x0
	private System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<System.Int32>> m_IteratorStack; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }

	// RVA: 0x318DB98
	public T GetDataForId(int id) { }

	// RVA: -1
	public int GetParentId(int id) { }

	// RVA: 0x30D376C
	public bool HasChildren(int id) { }

	// RVA: 0x30D77E4
	private static System.Collections.Generic.IEnumerable<System.Int32> GetItemIds(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items) { }

	// RVA: -1
	public System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	public void Move(int id, int newParentId, int childIndex) { }

	// RVA: -1
	public bool IsChildOf(int childId, int id) { }

	// RVA: 0x30D3DA0
	public System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class TreeViewController
{
	// Methods

	// RVA: 0x174A2B4
	protected TreeView get_treeView() { }

	// RVA: 0x174A33C
	protected override VisualElement MakeItem() { }

	// RVA: 0x174A49C
	protected override void BindItem(VisualElement element, int index) { }

	// RVA: 0x174A68C
	protected override void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x174A744
	protected override void DestroyItem(VisualElement element) { }

	// RVA: 0x174A7F4
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

	// RVA: 0x174A874
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

	// RVA: 0x30D39B8
	private int get_anchoredIndex() { }

	// RVA: 0x30D4A04
	private void set_anchoredIndex(int value) { }

	// RVA: -1
	private float get_anchorOffset() { }

	// RVA: -1
	private void set_anchorOffset(float value) { }

	// RVA: -1
	private float get_viewportMaxOffset() { }

	// RVA: 0x30D3738
	protected override bool get_alwaysRebindOnRefresh() { }

	// RVA: 0x30D4CD4
	public void .ctor(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x30D4918
	public override void Refresh(bool rebuild) { }

	// RVA: 0x30D4A04
	public override void ScrollToItem(int index) { }

	// RVA: -1
	public override void Resize(Vector2 size) { }

	// RVA: -1
	public override void OnScroll(Vector2 scrollOffset) { }

	// RVA: 0x30D488C
	private void OnScrollUpdate() { }

	// RVA: 0x30D4A04
	private void CycleItems(int firstIndex) { }

	// RVA: 0x30D3738
	private bool NeedsFill() { }

	// RVA: 0x30D488C
	private void Fill() { }

	// RVA: -1
	private void UpdateScrollViewContainer(float previousHeight, float newHeight) { }

	// RVA: 0x30D4918
	private void ApplyScrollViewUpdate(bool dimensionsOnly) { }

	// RVA: 0x30D488C
	private void UpdateAnchor() { }

	// RVA: 0x30D488C
	private void ScheduleFill() { }

	// RVA: 0x30D488C
	private void ScheduleScroll() { }

	// RVA: 0x30D488C
	private void ScheduleScrollDirectionReset() { }

	// RVA: 0x30D488C
	private void ResetScroll() { }

	// RVA: -1
	public override int GetIndexFromPosition(Vector2 position) { }

	// RVA: -1
	public override float GetExpectedItemHeight(int index) { }

	// RVA: 0x318DB98
	private int GetFirstVisibleItem(float offset) { }

	// RVA: -1
	public override float GetExpectedContentHeight() { }

	// RVA: -1
	private float GetContentHeightForIndex(int lastIndex) { }

	// RVA: 0x318DB98
	private ContentHeightCacheInfo GetCachedContentHeight(int index) { }

	// RVA: -1
	private void RegisterItemHeight(int index, float height) { }

	// RVA: 0x30D4A04
	private void UnregisterItemHeight(int index) { }

	// RVA: 0x30D488C
	private void CleanItemHeightCache() { }

	// RVA: 0x30D4CD4
	private void OnRecycledItemGeometryChanged(ReusableCollectionItem item) { }

	// RVA: 0x30D3858
	private bool UpdateRegisteredHeight(ReusableCollectionItem item) { }

	// RVA: 0x318DB98
	internal override T GetOrMakeItemAtIndex(int activeItemIndex, int scrollViewIndex) { }

	// RVA: 0x30D4A04
	internal override void ReleaseItem(int activeItemsIndex) { }

	// RVA: 0x30D4CD4
	internal override void StartDragItem(ReusableCollectionItem item) { }

	// RVA: 0x30D4A04
	internal override void EndDrag(int dropIndex) { }

	// RVA: 0x30D4A04
	private void HideItem(int activeItemsIndex) { }

	// RVA: 0x318DB98
	private void MarkWaitingForLayout(T item) { }

	// RVA: 0x30D376C
	private bool IsIndexOutOfBounds(int i) { }

}

// Namespace: UnityEngine.UIElements
internal class FixedHeightVirtualizationController<T0>
{
	// Methods

	// RVA: -1
	private float get_resolvedItemHeight() { }

	// RVA: 0x318DB98
	protected override bool VisibleItemPredicate(T i) { }

	// RVA: 0x30D4CD4
	public void .ctor(BaseVerticalCollectionView collectionView) { }

	// RVA: -1
	public override int GetIndexFromPosition(Vector2 position) { }

	// RVA: -1
	public override float GetExpectedItemHeight(int index) { }

	// RVA: -1
	public override float GetExpectedContentHeight() { }

	// RVA: 0x30D4A04
	public override void ScrollToItem(int index) { }

	// RVA: -1
	public override void Resize(Vector2 size) { }

	// RVA: -1
	public override void OnScroll(Vector2 scrollOffset) { }

	// RVA: 0x318DB98
	internal override T GetOrMakeItemAtIndex(int activeItemIndex, int scrollViewIndex) { }

	// RVA: 0x30D4A04
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

	// RVA: 0x174A8A8
	public virtual VisualElement get_rootElement() { }

	// RVA: 0x174A8B0
	public VisualElement get_bindableElement() { }

	// RVA: 0x174A8B8
	protected void set_bindableElement(VisualElement value) { }

	// RVA: 0x174A8C0
	public UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> get_animator() { }

	// RVA: 0x174A8C8
	public void set_animator(UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> value) { }

	// RVA: 0x174A8D0
	public int get_index() { }

	// RVA: 0x174A8D8
	public void set_index(int value) { }

	// RVA: 0x174A8E0
	public int get_id() { }

	// RVA: 0x174A8E8
	public void set_id(int value) { }

	// RVA: 0x174A8F0
	internal bool get_isDragGhost() { }

	// RVA: 0x174A8F8
	private void set_isDragGhost(bool value) { }

	// RVA: 0x174A900
	public void add_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x174A9B4
	public void remove_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x174AA68
	internal void add_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x174AB1C
	internal void remove_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x174ABD0
	public void .ctor() { }

	// RVA: 0x174AC6C
	public virtual void Init(VisualElement item) { }

	// RVA: 0x174AC74
	public virtual void PreAttachElement() { }

	// RVA: 0x174AD38
	public virtual void DetachElement() { }

	// RVA: 0x174AE4C
	public virtual void DestroyElement() { }

	// RVA: 0x174AE6C
	public virtual void SetSelected(bool selected) { }

	// RVA: 0x174AF90
	public virtual void SetDragGhost(bool dragGhost) { }

	// RVA: 0x174B14C
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

	// RVA: 0x174B16C
	public override VisualElement get_rootElement() { }

	// RVA: 0x17414A0
	public void Init(VisualElement item, bool usesAnimatedDragger) { }

	// RVA: 0x174B184
	protected void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) { }

	// RVA: 0x1741B98
	public void UpdateDragHandle(bool needsDragHandle) { }

	// RVA: 0x174B448
	public override void PreAttachElement() { }

	// RVA: 0x174B4DC
	public override void DetachElement() { }

	// RVA: 0x174B570
	public override void SetDragGhost(bool dragGhost) { }

	// RVA: 0x174B5F0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableMultiColumnListViewItem
{
	// Methods

	// RVA: 0x174B68C
	public override VisualElement get_rootElement() { }

	// RVA: 0x174B694
	public override void Init(VisualElement item) { }

	// RVA: 0x1749048
	public void Init(VisualElement container, Columns columns, bool usesAnimatedDrag) { }

	// RVA: 0x174B698
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableMultiColumnTreeViewItem
{
	// Methods

	// RVA: 0x174B734
	public override VisualElement get_rootElement() { }

	// RVA: 0x174B73C
	public override void Init(VisualElement item) { }

	// RVA: 0x1749D58
	public void Init(VisualElement container, Columns columns) { }

	// RVA: 0x174BC8C
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

	// RVA: 0x174BE4C
	public override VisualElement get_rootElement() { }

	// RVA: 0x1744A38
	public void add_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value) { }

	// RVA: 0x17448A0
	public void remove_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value) { }

	// RVA: 0x1744AEC
	public void add_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value) { }

	// RVA: 0x1744954
	public void remove_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value) { }

	// RVA: 0x174BC90
	public void .ctor() { }

	// RVA: 0x174BE64
	public override void Init(VisualElement item) { }

	// RVA: 0x174B740
	protected void InitExpandHierarchy(VisualElement root, VisualElement item) { }

	// RVA: 0x174BF48
	public override void PreAttachElement() { }

	// RVA: 0x174C124
	public override void DetachElement() { }

	// RVA: 0x1744450
	public void Indent(int depth) { }

	// RVA: 0x174455C
	public void SetExpandedWithoutNotify(bool expanded) { }

	// RVA: 0x1744664
	public void SetToggleVisibility(bool visible) { }

	// RVA: 0x174C440
	private void OnToggleGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x174C300
	private void UpdateIndentLayout() { }

	// RVA: 0x174C698
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x174C6B4
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal T <.ctor>b__30_0() { }

	// RVA: 0x318DB98
	internal void <.ctor>b__30_1(T i) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D3CF0
	public override System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }

	// RVA: 0x30D39B8
	internal int get_itemsCount() { }

	// RVA: 0x318DB98
	protected virtual bool VisibleItemPredicate(T i) { }

	// RVA: 0x318DB98
	internal T get_firstVisibleItem() { }

	// RVA: 0x318DB98
	internal T get_lastVisibleItem() { }

	// RVA: 0x30D39B8
	public override int get_visibleItemCount() { }

	// RVA: 0x30D3CF0
	protected SerializedVirtualizationData get_serializedData() { }

	// RVA: 0x30D39B8
	public override int get_firstVisibleIndex() { }

	// RVA: 0x30D4A04
	protected override void set_firstVisibleIndex(int value) { }

	// RVA: -1
	protected float get_lastHeight() { }

	// RVA: 0x30D3738
	protected virtual bool get_alwaysRebindOnRefresh() { }

	// RVA: 0x30D4CD4
	protected void .ctor(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x30D4918
	public override void Refresh(bool rebuild) { }

	// RVA: 0x318DB98
	protected void Setup(T recycledItem, int newIndex) { }

	// RVA: 0x30D4CD4
	public override void OnFocus(VisualElement leafTarget) { }

	// RVA: 0x30D4CD4
	public override void OnBlur(VisualElement willFocus) { }

	// RVA: 0x30D4D3C
	private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) { }

	// RVA: 0x30D488C
	public override void UpdateBackground() { }

	// RVA: 0x30D4CD4
	internal override void StartDragItem(ReusableCollectionItem item) { }

	// RVA: 0x30D4A04
	internal override void EndDrag(int dropIndex) { }

	// RVA: 0x318DB98
	internal virtual T GetOrMakeItemAtIndex(int activeItemIndex, int scrollViewIndex) { }

	// RVA: 0x30D4A04
	internal virtual void ReleaseItem(int activeItemsIndex) { }

	// RVA: 0x30D4CD4
	private void OnDestroyItem(ReusableCollectionItem item) { }

	// RVA: 0x30D39B8
	protected int GetDraggedIndex() { }

}

// Namespace: UnityEngine.UIElements
public abstract class ContextualMenuManager
{
	// Fields
	private bool <displayMenuHandledOSX>k__BackingField; // 0x10

	// Methods

	// RVA: 0x174C6D0
	internal bool get_displayMenuHandledOSX() { }

	// RVA: 0x174C6D8
	internal void set_displayMenuHandledOSX(bool value) { }

	// RVA: -1
	public abstract void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler) { }

	// RVA: 0x174C6E0
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

	// RVA: 0x174CABC
	public void .ctor(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent> menuBuilder) { }

	// RVA: 0x174CBFC
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x174CEE4
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x174D1CC
	private void OnMouseUpDownEvent(IMouseEvent evt) { }

	// RVA: 0x174D338
	private void OnMouseDownEventOSX(MouseDownEvent evt) { }

	// RVA: 0x174D44C
	private void OnMouseUpEventOSX(MouseUpEvent evt) { }

	// RVA: 0x174D554
	private void OnKeyUpEvent(KeyUpEvent evt) { }

	// RVA: 0x174D28C
	private void DoDisplayMenu(EventBase evt) { }

	// RVA: 0x174D5C8
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

	// RVA: 0x174D5E4
	public void .ctor(string label) { }

	// RVA: 0x174D9A8
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x174D9E4
	public string get_text() { }

	// RVA: 0x174D908
	public void set_text(string value) { }

	// RVA: 0x174DA00
	protected virtual void InitLabel() { }

	// RVA: 0x174DAA4
	public override void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x174DBAC
	private void OnClickEvent(EventBase evt) { }

	// RVA: 0x174DEA4
	protected virtual void ToggleValue() { }

	// RVA: 0x174DEE4
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x174E130
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x174E24C
	internal override void UnregisterEditingCallbacks() { }

}

// Namespace: 
public sealed class WriteDelegate
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D5174
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal TFieldValue <.ctor>b__0(TFieldValue newValue) { }

	// RVA: 0x30D4CD4
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

	// RVA: 0x30D3CF0
	private VisualElement GetSpacer() { }

	// RVA: -1
	internal abstract FieldDescription[] DescribeFields() { }

	// RVA: 0x30D4D3C
	protected void .ctor(string label, int fieldsByLine) { }

	// RVA: 0x30D488C
	private void UpdateDisplay() { }

	// RVA: 0x318DB98
	public override void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30D488C
	internal override void OnViewDataReady() { }

	// RVA: 0x30D488C
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x30D9218
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

	// RVA: 0x175139C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1751888
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

	// RVA: 0x174E368
	public bool get_showBoundCollectionSize() { }

	// RVA: 0x174E370
	public void set_showBoundCollectionSize(bool value) { }

	// RVA: 0x174E6B4
	public bool get_showFoldoutHeader() { }

	// RVA: 0x174E6BC
	public void set_showFoldoutHeader(bool value) { }

	// RVA: 0x174E388
	internal void SetupArraySizeField() { }

	// RVA: 0x174F108
	public void set_headerTitle(string value) { }

	// RVA: 0x174EBB0
	public bool get_showAddRemoveFooter() { }

	// RVA: 0x174F150
	public void set_showAddRemoveFooter(bool value) { }

	// RVA: 0x174EBC0
	private void EnableFooter(bool enabled) { }

	// RVA: 0x174F154
	private void AddItems(int itemCount) { }

	// RVA: 0x174F270
	private void OnArraySizeFieldChanged(UnityEngine.UIElements.ChangeEvent<System.String> evt) { }

	// RVA: 0x174EFB8
	internal void UpdateArraySizeField() { }

	// RVA: 0x174E90C
	internal void UpdateListViewLabel() { }

	// RVA: 0x174F658
	private void OnAddClicked() { }

	// RVA: 0x174F988
	private void OnRemoveClicked() { }

	// RVA: 0x174FC8C
	internal VisualElement get_footer() { }

	// RVA: 0x174F1E8
	public BaseListViewController get_viewController() { }

	// RVA: 0x174FC94
	internal override void CreateVirtualizationController() { }

	// RVA: 0x174FCE8
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x17503D8
	private void OnItemAdded(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x17503F4
	private void OnItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1750410
	private void OnItemsSourceSizeChanged() { }

	// RVA: 0x1749690
	internal void add_reorderModeChanged(Action value) { }

	// RVA: 0x17498F4
	internal void remove_reorderModeChanged(Action value) { }

	// RVA: 0x17504B4
	public ListViewReorderMode get_reorderMode() { }

	// RVA: 0x17504BC
	public void set_reorderMode(ListViewReorderMode value) { }

	// RVA: 0x175052C
	internal override ListViewDragger CreateDragger() { }

	// RVA: 0x17505D0
	internal override ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x1750638
	public void .ctor() { }

	// RVA: 0x175070C
	internal override void PostRefresh() { }

	// RVA: 0x175073C
	internal override bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	// RVA: 0x1750D90
	private static void .cctor() { }

	// RVA: 0x17512C8
	private void <OnAddClicked>b__38_0() { }

}

// Namespace: 
private class PopupTextElement
{
	// Methods

	// RVA: -1
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
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

	// RVA: 0x30D3CF0
	protected TextElement get_textElement() { }

	// RVA: -1
	internal abstract string GetValueToDisplay() { }

	// RVA: -1
	internal abstract string GetListItemToDisplay(TValueType item) { }

	// RVA: -1
	internal abstract void AddMenuItems(IGenericMenu menu) { }

	// RVA: 0x30D4CD4
	public virtual void set_choices(System.Collections.Generic.List<TValueChoice> value) { }

	// RVA: 0x318DB98
	public override void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30D4CD4
	internal void .ctor(string label) { }

	// RVA: 0x30D4CD4
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x30D4CD4
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x30D376C
	private bool ContainsPointer(int pointerId) { }

	// RVA: 0x30D4CD4
	private void ProcessPointerDown(UnityEngine.UIElements.PointerEventBase<T> evt) { }

	// RVA: 0x30D4CD4
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x30D488C
	internal void ShowMenu() { }

	// RVA: 0x30D488C
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x30D9218
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

	// RVA: 0x30D488C
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

	// RVA: 0x30D3CF0
	internal VisualElement get_dragContainer() { }

	// RVA: 0x30D4CD4
	private void set_dragContainer(VisualElement value) { }

	// RVA: 0x30D3CF0
	internal VisualElement get_dragElement() { }

	// RVA: 0x30D4CD4
	private void set_dragElement(VisualElement value) { }

	// RVA: 0x30D3CF0
	internal VisualElement get_trackElement() { }

	// RVA: 0x30D4CD4
	private void set_trackElement(VisualElement value) { }

	// RVA: 0x30D3CF0
	internal VisualElement get_dragBorderElement() { }

	// RVA: 0x30D4CD4
	private void set_dragBorderElement(VisualElement value) { }

	// RVA: 0x30D3CF0
	internal TextField get_inputTextField() { }

	// RVA: 0x30D4CD4
	private void set_inputTextField(TextField value) { }

	// RVA: 0x318DB98
	public TValueType get_lowValue() { }

	// RVA: 0x318DB98
	public void set_lowValue(TValueType value) { }

	// RVA: 0x318DB98
	public TValueType get_highValue() { }

	// RVA: 0x318DB98
	public void set_highValue(TValueType value) { }

	// RVA: 0x318DB98
	internal void SetHighValueWithoutNotify(TValueType newHighValue) { }

	// RVA: -1
	public virtual float get_pageSize() { }

	// RVA: -1
	public virtual void set_pageSize(float value) { }

	// RVA: 0x30D3738
	public virtual bool get_showInputField() { }

	// RVA: 0x30D4918
	public virtual void set_showInputField(bool value) { }

	// RVA: 0x30D3738
	internal bool get_clamped() { }

	// RVA: 0x30D4918
	internal void set_clamped(bool value) { }

	// RVA: 0x30D3CF0
	internal UnityEngine.UIElements.ClampedDragger<TValueType> get_clampedDragger() { }

	// RVA: 0x30D4CD4
	private void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<TValueType> value) { }

	// RVA: 0x318DB98
	private TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) { }

	// RVA: 0x318DB98
	private TValueType GetClampedValue(TValueType newValue) { }

	// RVA: 0x318DB98
	public override TValueType get_value() { }

	// RVA: 0x318DB98
	public override void set_value(TValueType value) { }

	// RVA: 0x318DB98
	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	// RVA: 0x30D488C
	private void UnityEngine.UIElements.IValueField<TValueType>.StartDragging() { }

	// RVA: 0x30D488C
	private void UnityEngine.UIElements.IValueField<TValueType>.StopDragging() { }

	// RVA: 0x318DB98
	public override void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30D39B8
	public SliderDirection get_direction() { }

	// RVA: 0x30D4A04
	public void set_direction(SliderDirection value) { }

	// RVA: 0x30D3738
	public bool get_inverted() { }

	// RVA: 0x30D4918
	public void set_inverted(bool value) { }

	// RVA: 0x318DB98
	internal void .ctor(string label, TValueType start, TValueType end, SliderDirection direction, float pageSize) { }

	// RVA: -1
	protected static float GetClosestPowerOfTen(float positiveNumber) { }

	// RVA: -1
	protected static float RoundToMultipleOf(float value, float roundingValue) { }

	// RVA: 0x30D488C
	private void ClampValue() { }

	// RVA: -1
	internal abstract TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant) { }

	// RVA: -1
	internal abstract float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue) { }

	// RVA: -1
	internal abstract TValueType ParseStringToValue(string previousValue, string newValue) { }

	// RVA: -1
	internal abstract void ComputeValueFromKey(SliderKey sliderKey, bool isShift) { }

	// RVA: 0x318DB98
	private TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant) { }

	// RVA: 0x30D488C
	private void SetSliderValueFromDrag() { }

	// RVA: 0x318DB98
	private void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos) { }

	// RVA: 0x30D488C
	private void SetSliderValueFromClick() { }

	// RVA: 0x30D4CD4
	private void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x30D4CD4
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	// RVA: -1
	internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	// RVA: -1
	public void AdjustDragElement(float factor) { }

	// RVA: 0x30D4CD4
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	// RVA: 0x30D488C
	internal override void OnViewDataReady() { }

	// RVA: 0x318DB98
	private bool SameValues(float a, float b, float epsilon) { }

	// RVA: 0x30D488C
	private void UpdateDragElementPosition() { }

	// RVA: 0x30D4CD4
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x30D488C
	private void UpdateTextFieldVisibility() { }

	// RVA: 0x30D488C
	private void UpdateTextFieldValue() { }

	// RVA: 0x30D4CD4
	private void OnTextFieldFocusIn(FocusInEvent evt) { }

	// RVA: 0x30D4CD4
	private void OnTextFieldFocusOut(FocusOutEvent evt) { }

	// RVA: 0x30D4CD4
	private void OnInputNavigationMoveEvent(NavigationMoveEvent evt) { }

	// RVA: 0x30D4CD4
	private void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent<System.String> evt) { }

	// RVA: 0x30D488C
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x30D488C
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x30D488C
	internal override void UnregisterEditingCallbacks() { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private readonly UxmlBoolAttributeDescription m_AutoExpand; // 0xB0

	// Methods

	// RVA: 0x175464C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17547A8
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

	// RVA: 0x175204C
	public IList get_itemsSource() { }

	// RVA: 0x17520CC
	public BaseTreeViewController get_viewController() { }

	// RVA: 0x1752154
	internal override void CreateVirtualizationController() { }

	// RVA: 0x17521A8
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x1752450
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x1752684
	internal override ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x17526EC
	public bool get_autoExpand() { }

	// RVA: 0x17526F4
	public void set_autoExpand(bool value) { }

	// RVA: 0x175278C
	internal System.Collections.Generic.List<System.Int32> get_expandedItemIds() { }

	// RVA: 0x1752794
	internal void set_expandedItemIds(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x17527A4
	public void .ctor() { }

	// RVA: 0x17527AC
	public void .ctor(int itemHeight) { }

	// RVA: 0x1752AB4
	internal override void OnViewDataReady() { }

	// RVA: 0x1752BD4
	internal override bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	// RVA: 0x1753828
	public void SetSelectionById(int id) { }

	// RVA: 0x1753AAC
	public void SetSelectionById(System.Collections.Generic.IEnumerable<System.Int32> ids) { }

	// RVA: 0x1753AB4
	internal void SetSelectionInternalById(System.Collections.Generic.IEnumerable<System.Int32> ids, bool sendNotification) { }

	// RVA: 0x175404C
	private int GetItemIndex(int id, bool expand) { }

	// RVA: 0x1754274
	public bool IsExpanded(int id) { }

	// RVA: 0x1754304
	public void CollapseItem(int id, bool collapseAllChildren) { }

	// RVA: 0x17543A4
	public void ExpandItem(int id, bool expandAllChildren) { }

	// RVA: 0x1754440
	private void OnTreeViewPointerUp(PointerUpEvent evt) { }

	// RVA: 0x1753460
	private bool IsExpandedByIndex(int index) { }

	// RVA: 0x175361C
	private void CollapseItemByIndex(int index, bool collapseAll) { }

	// RVA: 0x17534F0
	private void ExpandItemByIndex(int index, bool expandAll) { }

	// RVA: 0x175447C
	private static void .cctor() { }

	// RVA: 0x1754644
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

	// RVA: 0x175487C
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

	// RVA: 0x1751B90
	public void .ctor() { }

	// RVA: 0x1751578
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

	// RVA: 0x175C48C
	public System.Collections.Generic.List<System.Int32> get_selectedIds() { }

	// RVA: 0x175C494
	public void set_selectedIds(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x1754E18
	public int get_indexCount() { }

	// RVA: 0x1756FA8
	public int get_idCount() { }

	// RVA: 0x1758780
	public int get_minIndex() { }

	// RVA: 0x175873C
	public int get_maxIndex() { }

	// RVA: 0x175B738
	public int get_capacity() { }

	// RVA: 0x175B78C
	public void set_capacity(int value) { }

	// RVA: 0x1754E64
	public int FirstIndex() { }

	// RVA: 0x1756FF4
	public bool ContainsIndex(int index) { }

	// RVA: 0x1759E84
	public bool ContainsId(int id) { }

	// RVA: 0x175A844
	public void AddId(int id) { }

	// RVA: 0x1757068
	public void AddIndex(int index, object obj) { }

	// RVA: 0x175B180
	public bool TryRemove(int index) { }

	// RVA: 0x175B2AC
	public void RemoveId(int id) { }

	// RVA: 0x175C49C
	public void ClearItems() { }

	// RVA: 0x175C4F0
	public void ClearIds() { }

	// RVA: 0x1756E48
	public void ClearIndices() { }

	// RVA: 0x175B840
	public void Clear() { }

	// RVA: 0x17561FC
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass162_0
{
	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x17564C0
	public void .ctor() { }

	// RVA: 0x175C5B4
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

	// RVA: 0x1754F84
	public void .ctor(int <>1__state) { }

	// RVA: 0x175C5DC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x175C66C
	private bool MoveNext() { }

	// RVA: 0x175C9D8
	private void <>m__Finally1() { }

	// RVA: 0x175CA34
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x175CA3C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x175CA7C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x175CA84
	private System.Collections.Generic.IEnumerator<System.Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

	// RVA: 0x175CB38
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

	// RVA: 0x1754884
	internal bool HasCanStartDrag() { }

	// RVA: 0x1754894
	internal bool RaiseCanStartDrag(ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids) { }

	// RVA: 0x1754958
	internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids, StartDragArgs args) { }

	// RVA: 0x1754A1C
	internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	// RVA: 0x1754AA8
	internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	// RVA: 0x1754B34
	public IList get_itemsSource() { }

	// RVA: 0x1754B4C
	public void set_itemsSource(IList value) { }

	// RVA: 0x1754C18
	public override VisualElement get_contentContainer() { }

	// RVA: 0x1754C20
	public SelectionType get_selectionType() { }

	// RVA: 0x1754C28
	public void set_selectionType(SelectionType value) { }

	// RVA: 0x1754EFC
	public System.Collections.Generic.IEnumerable<System.Object> get_selectedItems() { }

	// RVA: 0x1753744
	public int get_selectedIndex() { }

	// RVA: 0x1754FBC
	public void set_selectedIndex(int value) { }

	// RVA: 0x1754FC0
	public System.Collections.Generic.IEnumerable<System.Int32> get_selectedIndices() { }

	// RVA: 0x1753440
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedIds() { }

	// RVA: 0x1754FE0
	internal System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }

	// RVA: 0x175507C
	internal ScrollView get_scrollView() { }

	// RVA: 0x1755084
	internal ListViewDragger get_dragger() { }

	// RVA: 0x175508C
	internal CollectionVirtualizationController get_virtualizationController() { }

	// RVA: 0x175511C
	public CollectionViewController get_viewController() { }

	// RVA: 0x1755124
	internal float ResolveItemHeight(float height) { }

	// RVA: 0x1755230
	public void set_showBorder(bool value) { }

	// RVA: 0x17552C8
	public bool get_reorderable() { }

	// RVA: 0x1755460
	public void set_reorderable(bool value) { }

	// RVA: 0x17557E0
	public void set_horizontalScrollingEnabled(bool value) { }

	// RVA: 0x175585C
	public AlternatingRowBackground get_showAlternatingRowBackgrounds() { }

	// RVA: 0x1755864
	public void set_showAlternatingRowBackgrounds(AlternatingRowBackground value) { }

	// RVA: 0x175587C
	public CollectionVirtualizationMethod get_virtualizationMethod() { }

	// RVA: 0x1755884
	public void set_virtualizationMethod(CollectionVirtualizationMethod value) { }

	// RVA: 0x17558D0
	public float get_fixedItemHeight() { }

	// RVA: 0x17558D8
	public void set_fixedItemHeight(float value) { }

	// RVA: 0x17559E8
	internal float get_lastHeight() { }

	// RVA: 0x17559F0
	internal virtual void CreateVirtualizationController() { }

	// RVA: 0x17550D4
	internal CollectionVirtualizationController GetOrCreateVirtualizationController() { }

	// RVA: 0x30D488C
	internal void CreateVirtualizationController() { }

	// RVA: 0x1754BB8
	internal CollectionViewController GetOrCreateViewController() { }

	// RVA: -1
	protected abstract CollectionViewController CreateViewController() { }

	// RVA: 0x175237C
	public virtual void SetViewController(CollectionViewController controller) { }

	// RVA: 0x1755A44
	internal virtual ListViewDragger CreateDragger() { }

	// RVA: 0x1755AAC
	internal void InitializeDragAndDropController(bool enableReordering) { }

	// RVA: -1
	internal abstract ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x1755C08
	public void .ctor() { }

	// RVA: 0x17529B8
	public void .ctor(IList itemsSource, float itemHeight) { }

	// RVA: 0x175635C
	public VisualElement GetRootElementForId(int id) { }

	// RVA: 0x17564C8
	internal virtual bool HasValidDataAndBindings() { }

	// RVA: 0x17564F4
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x1756544
	private void OnItemsSourceChanged() { }

	// RVA: 0x1752454
	public void RefreshItems() { }

	// RVA: 0x17555A8
	public void Rebuild() { }

	// RVA: 0x1756C18
	internal void ScheduleRebuild() { }

	// RVA: 0x1756560
	private void RefreshSelection() { }

	// RVA: 0x175717C
	internal virtual void PostRefresh() { }

	// RVA: 0x1753A38
	public void ScrollToItem(int index) { }

	// RVA: 0x17538A8
	public void ScrollToItemById(int id) { }

	// RVA: 0x1757320
	private void OnScroll(Vector2 offset) { }

	// RVA: 0x1757284
	private void Resize(Vector2 size) { }

	// RVA: 0x17573A8
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x17576F4
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x17579AC
	private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) { }

	// RVA: 0x17587C4
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x1758A6C
	internal virtual bool HandleItemNavigation(bool moveIn, bool altKey) { }

	// RVA: 0x1758A74
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x17594EC
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x17595C8
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x17596A4
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x17590CC
	private void ProcessPointerDown(IPointerEvent evt) { }

	// RVA: 0x1758B10
	private void ProcessPointerUp(IPointerEvent evt) { }

	// RVA: 0x1759780
	private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey) { }

	// RVA: 0x1759FD0
	internal void DoRangeSelection(int rangeSelectionFinalIndex) { }

	// RVA: 0x1759E80
	private void ProcessSingleClick(int clickedIndex) { }

	// RVA: 0x1758064
	internal void SelectAll() { }

	// RVA: 0x1759F54
	public void AddToSelection(int index) { }

	// RVA: 0x175A4DC
	internal void AddToSelection(System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x175A9CC
	private void AddToSelectionWithoutValidation(int index) { }

	// RVA: 0x1759EF8
	public void RemoveFromSelection(int index) { }

	// RVA: 0x175ADE0
	private void RemoveFromSelectionWithoutValidation(int index) { }

	// RVA: 0x1753938
	public void SetSelection(int index) { }

	// RVA: 0x175B34C
	public void SetSelection(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x175B354
	public void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1753BB0
	internal void SetSelectionInternal(System.Collections.Generic.IEnumerable<System.Int32> indices, bool sendNotification) { }

	// RVA: 0x175B35C
	private bool MatchesExistingSelection(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x175A8E4
	private void NotifyOfSelectionChange() { }

	// RVA: 0x1754D88
	public void ClearSelection() { }

	// RVA: 0x175A140
	private void ClearSelectionWithoutValidation() { }

	// RVA: 0x1752B80
	internal override void OnViewDataReady() { }

	// RVA: 0x175B8A4
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x175BCAC
	private void OnSizeChanged(GeometryChangedEvent evt) { }

	// RVA: 0x175BE28
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x175BFD0
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x175BFD4
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x175C00C
	private static void .cctor() { }

	// RVA: 0x175C408
	private void <.ctor>b__159_0(float v) { }

	// RVA: 0x1756F20
	private void <RefreshSelection>g__NotifyIfChanged|172_0(UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass172_0& ) { }

	// RVA: 0x1758578
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

	// RVA: 0x175D5AC
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

	// RVA: 0x175D600
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x175D82C
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

	// RVA: 0x175CB3C
	public void .ctor() { }

	// RVA: 0x175CB44
	public void .ctor(string label) { }

	// RVA: 0x175D06C
	public override void SetValueWithoutNotify(Bounds newValue) { }

	// RVA: 0x175D16C
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x175D23C
	private static void .cctor() { }

	// RVA: 0x175D3C4
	private void <.ctor>b__10_0(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3> e) { }

	// RVA: 0x175D4B8
	private void <.ctor>b__10_1(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3> e) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x175E4D0
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

	// RVA: 0x175E524
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x175E74C
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

	// RVA: 0x175DA60
	public void .ctor() { }

	// RVA: 0x175DA68
	public void .ctor(string label) { }

	// RVA: 0x175DF90
	public override void SetValueWithoutNotify(BoundsInt newValue) { }

	// RVA: 0x175E090
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x175E160
	private static void .cctor() { }

	// RVA: 0x175E2E8
	private void <.ctor>b__10_0(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3Int> e) { }

	// RVA: 0x175E3DC
	private void <.ctor>b__10_1(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3Int> e) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x175EAC8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Box
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x175E980
	public void .ctor() { }

	// RVA: 0x175EA50
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x175EF0C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x175EF60
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

	// RVA: 0x175EB1C
	public Clickable get_clickable() { }

	// RVA: 0x175EB24
	public void set_clickable(Clickable value) { }

	// RVA: 0x175EBC0
	public void .ctor() { }

	// RVA: 0x175EBC8
	public void .ctor(Action clickEvent) { }

	// RVA: 0x175ED68
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x175EDAC
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x175EE6C
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x175F268
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x175F2BC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ButtonStripField
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.Button> m_Buttons; // 0x440

	// Methods

	// RVA: 0x175EFD8
	public void .ctor() { }

	// RVA: 0x175F0A8
	public override void SetValueWithoutNotify(int newValue) { }

	// RVA: 0x175F14C
	private void RefreshButtonsState() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x175FCE8
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

	// RVA: 0x175FD3C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x175FEF8
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

	// RVA: 0x1760094
	private static void .cctor() { }

	// RVA: 0x1760100
	public void .ctor() { }

	// RVA: 0x1760108
	internal float <DescribeFields>b__0_0(Rect r) { }

	// RVA: 0x176010C
	internal void <DescribeFields>b__0_1(Rect r, float v) { }

	// RVA: 0x1760114
	internal float <DescribeFields>b__0_2(Rect r) { }

	// RVA: 0x176011C
	internal void <DescribeFields>b__0_3(Rect r, float v) { }

	// RVA: 0x1760124
	internal float <DescribeFields>b__0_4(Rect r) { }

	// RVA: 0x176012C
	internal void <DescribeFields>b__0_5(Rect r, float v) { }

	// RVA: 0x1760134
	internal float <DescribeFields>b__0_6(Rect r) { }

	// RVA: 0x176013C
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

	// RVA: 0x175F310
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x175FA74
	public void .ctor() { }

	// RVA: 0x175FA7C
	public void .ctor(string label) { }

	// RVA: 0x175FBE8
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1760B1C
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

	// RVA: 0x1760B70
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1760D24
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

	// RVA: 0x1760EC0
	private static void .cctor() { }

	// RVA: 0x1760F2C
	public void .ctor() { }

	// RVA: 0x1760F34
	internal int <DescribeFields>b__0_0(RectInt r) { }

	// RVA: 0x1760F3C
	internal void <DescribeFields>b__0_1(RectInt r, int v) { }

	// RVA: 0x1760F44
	internal int <DescribeFields>b__0_2(RectInt r) { }

	// RVA: 0x1760F4C
	internal void <DescribeFields>b__0_3(RectInt r, int v) { }

	// RVA: 0x1760F54
	internal int <DescribeFields>b__0_4(RectInt r) { }

	// RVA: 0x1760F5C
	internal void <DescribeFields>b__0_5(RectInt r, int v) { }

	// RVA: 0x1760F64
	internal int <DescribeFields>b__0_6(RectInt r) { }

	// RVA: 0x1760F6C
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

	// RVA: 0x1760144
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x17608A8
	public void .ctor() { }

	// RVA: 0x17608B0
	public void .ctor(string label) { }

	// RVA: 0x1760A1C
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17615E4
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlFloatAttributeDescription m_XValue; // 0x80
	private UxmlFloatAttributeDescription m_YValue; // 0x88

	// Methods

	// RVA: 0x1761638
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x176178C
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

	// RVA: 0x1761890
	private static void .cctor() { }

	// RVA: 0x17618FC
	public void .ctor() { }

	// RVA: 0x1761904
	internal float <DescribeFields>b__0_0(Vector2 r) { }

	// RVA: 0x1761908
	internal void <DescribeFields>b__0_1(Vector2 r, float v) { }

	// RVA: 0x1761910
	internal float <DescribeFields>b__0_2(Vector2 r) { }

	// RVA: 0x1761918
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

	// RVA: 0x1760F74
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x1761388
	public void .ctor() { }

	// RVA: 0x1761390
	public void .ctor(string label) { }

	// RVA: 0x17614E4
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1761FE4
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

	// RVA: 0x1762038
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17621BC
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

	// RVA: 0x176230C
	private static void .cctor() { }

	// RVA: 0x1762378
	public void .ctor() { }

	// RVA: 0x1762380
	internal float <DescribeFields>b__0_0(Vector3 r) { }

	// RVA: 0x1762384
	internal void <DescribeFields>b__0_1(Vector3 r, float v) { }

	// RVA: 0x176238C
	internal float <DescribeFields>b__0_2(Vector3 r) { }

	// RVA: 0x1762394
	internal void <DescribeFields>b__0_3(Vector3 r, float v) { }

	// RVA: 0x176239C
	internal float <DescribeFields>b__0_4(Vector3 r) { }

	// RVA: 0x17623A4
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

	// RVA: 0x1761920
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x1761EDC
	public void .ctor() { }

	// RVA: 0x175CF18
	public void .ctor(string label) { }

	// RVA: 0x1761EE4
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1762D6C
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

	// RVA: 0x1762DC0
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1762F7C
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

	// RVA: 0x1763118
	private static void .cctor() { }

	// RVA: 0x1763184
	public void .ctor() { }

	// RVA: 0x176318C
	internal float <DescribeFields>b__0_0(Vector4 r) { }

	// RVA: 0x1763190
	internal void <DescribeFields>b__0_1(Vector4 r, float v) { }

	// RVA: 0x1763198
	internal float <DescribeFields>b__0_2(Vector4 r) { }

	// RVA: 0x17631A0
	internal void <DescribeFields>b__0_3(Vector4 r, float v) { }

	// RVA: 0x17631A8
	internal float <DescribeFields>b__0_4(Vector4 r) { }

	// RVA: 0x17631B0
	internal void <DescribeFields>b__0_5(Vector4 r, float v) { }

	// RVA: 0x17631B8
	internal float <DescribeFields>b__0_6(Vector4 r) { }

	// RVA: 0x17631C0
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

	// RVA: 0x17623AC
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x1762B10
	public void .ctor() { }

	// RVA: 0x1762B18
	public void .ctor(string label) { }

	// RVA: 0x1762C6C
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1763838
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_XValue; // 0x80
	private UxmlIntAttributeDescription m_YValue; // 0x88

	// Methods

	// RVA: 0x176388C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17639D8
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

	// RVA: 0x1763ADC
	private static void .cctor() { }

	// RVA: 0x1763B48
	public void .ctor() { }

	// RVA: 0x1763B50
	internal int <DescribeFields>b__0_0(Vector2Int r) { }

	// RVA: 0x1763B58
	internal void <DescribeFields>b__0_1(Vector2Int r, int v) { }

	// RVA: 0x1763B60
	internal int <DescribeFields>b__0_2(Vector2Int r) { }

	// RVA: 0x1763B68
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

	// RVA: 0x17631C8
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x17635DC
	public void .ctor() { }

	// RVA: 0x17635E4
	public void .ctor(string label) { }

	// RVA: 0x1763738
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1764234
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

	// RVA: 0x1764288
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1764404
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

	// RVA: 0x1764554
	private static void .cctor() { }

	// RVA: 0x17645C0
	public void .ctor() { }

	// RVA: 0x17645C8
	internal int <DescribeFields>b__0_0(Vector3Int r) { }

	// RVA: 0x17645D0
	internal void <DescribeFields>b__0_1(Vector3Int r, int v) { }

	// RVA: 0x17645D8
	internal int <DescribeFields>b__0_2(Vector3Int r) { }

	// RVA: 0x17645E0
	internal void <DescribeFields>b__0_3(Vector3Int r, int v) { }

	// RVA: 0x17645E8
	internal int <DescribeFields>b__0_4(Vector3Int r) { }

	// RVA: 0x17645F0
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

	// RVA: 0x1763B70
	internal override FieldDescription[] DescribeFields() { }

	// RVA: 0x176412C
	public void .ctor() { }

	// RVA: 0x175DE3C
	public void .ctor(string label) { }

	// RVA: 0x1764134
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1764D78
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x1764DCC
	public void .ctor() { }

}

// Namespace: 
private class DoubleInput
{
	// Methods

	// RVA: 0x1764E20
	private DoubleField get_parentDoubleField() { }

	// RVA: 0x1764AB4
	internal void .ctor() { }

	// RVA: 0x1764EA4
	protected override string get_allowedCharacters() { }

	// RVA: 0x1764F20
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Double startValue) { }

	// RVA: 0x176515C
	protected override string ValueToString(Double v) { }

	// RVA: 0x17651B4
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

	// RVA: 0x17645F8
	private DoubleInput get_doubleInput() { }

	// RVA: 0x17646B0
	protected override string ValueToString(Double v) { }

	// RVA: 0x1764770
	protected override Double StringToValue(string str) { }

	// RVA: 0x17648AC
	public void .ctor() { }

	// RVA: 0x17648B8
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x1764B50
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x1764B7C
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Double startValue) { }

	// RVA: 0x1764C78
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1765360
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlIntAttributeDescription m_Index; // 0x80
	private UxmlStringAttributeDescription m_Choices; // 0x88

	// Methods

	// RVA: 0x17653B4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1765540
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DropdownField
{
	// Methods

	// RVA: 0x1765264
	public void .ctor() { }

	// RVA: 0x17652E0
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

	// RVA: 0x1765690
	internal static bool ExtractValue(IUxmlAttributes bag, CreationContext cc, Type resEnumType, Enum resEnumValue, bool resIncludeObsoleteValues) { }

	// RVA: 0x1765A5C
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1767314
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

	// RVA: 0x1767368
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1767644
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

	// RVA: 0x1767704
	private static void .cctor() { }

	// RVA: 0x1767770
	public void .ctor() { }

	// RVA: 0x1767778
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

	// RVA: 0x1765C20
	internal bool get_includeObsoleteValues() { }

	// RVA: 0x1765C28
	private void Initialize(Enum defaultValue) { }

	// RVA: 0x1765DE8
	public void .ctor() { }

	// RVA: 0x1765DF4
	public void .ctor(string label, Enum defaultValue) { }

	// RVA: 0x1765DE0
	public void Init(Enum defaultValue) { }

	// RVA: 0x176618C
	public void Init(Enum defaultValue, bool includeObsoleteValues) { }

	// RVA: 0x176633C
	internal void PopulateDataFromType(Type enumType) { }

	// RVA: 0x17664D4
	public override void SetValueWithoutNotify(Enum newValue) { }

	// RVA: 0x17663F8
	private void UpdateValueLabel(Enum value) { }

	// RVA: 0x17665D4
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x1766630
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x17666CC
	private bool ContainsPointer(int pointerId) { }

	// RVA: 0x30D4CD4
	private void ProcessPointerDown(UnityEngine.UIElements.PointerEventBase<T> evt) { }

	// RVA: 0x1766768
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x1766798
	private void ShowMenu() { }

	// RVA: 0x1766E94
	private void ChangeValueFromMenu(object menuItem) { }

	// RVA: 0x1766F2C
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x17670F4
	private static void .cctor() { }

	// RVA: 0x176727C
	private void <ShowMenu>b__33_0(object contentView) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1767F58
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x1767FAC
	public void .ctor() { }

}

// Namespace: 
private class FloatInput
{
	// Methods

	// RVA: 0x1768000
	private FloatField get_parentFloatField() { }

	// RVA: 0x1767C94
	internal void .ctor() { }

	// RVA: 0x1768084
	protected override string get_allowedCharacters() { }

	// RVA: 0x1768100
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x176836C
	protected override string ValueToString(float v) { }

	// RVA: 0x17683C4
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

	// RVA: 0x17677D8
	private FloatInput get_floatInput() { }

	// RVA: 0x1767890
	protected override string ValueToString(float v) { }

	// RVA: 0x1767950
	protected override float StringToValue(string str) { }

	// RVA: 0x1767A8C
	public void .ctor() { }

	// RVA: 0x1767A98
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x1767D30
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x1767D5C
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x1767E58
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1769330
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x78
	private UxmlBoolAttributeDescription m_Value; // 0x80

	// Methods

	// RVA: 0x1769384
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17694C0
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

	// RVA: 0x1768474
	internal Toggle get_toggle() { }

	// RVA: 0x176847C
	public override VisualElement get_contentContainer() { }

	// RVA: 0x1768484
	public void set_text(string value) { }

	// RVA: 0x17685E4
	public bool get_value() { }

	// RVA: 0x17685EC
	public void set_value(bool value) { }

	// RVA: 0x17687B4
	public void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x176890C
	internal override void OnViewDataReady() { }

	// RVA: 0x1768958
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x1768998
	private bool Apply(KeyboardNavigationOperation op) { }

	// RVA: 0x1768A74
	public void .ctor() { }

	// RVA: 0x1768E8C
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x1769078
	private static void .cctor() { }

	// RVA: 0x17692DC
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

	// RVA: 0x176AFE4
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

	// RVA: 0x17695FC
	internal bool get_isSingleSelectionDropdown() { }

	// RVA: 0x1769604
	internal void set_isSingleSelectionDropdown(bool value) { }

	// RVA: 0x176960C
	internal bool get_closeOnParentResize() { }

	// RVA: 0x1769614
	internal void set_closeOnParentResize(bool value) { }

	// RVA: 0x176961C
	public VisualElement get_contentContainer() { }

	// RVA: 0x1766B60
	public void .ctor() { }

	// RVA: 0x1769644
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x1769A70
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x1769E08
	private void Hide(bool giveFocusBack) { }

	// RVA: 0x1769EAC
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x1769EF8
	private bool Apply(KeyboardNavigationOperation op) { }

	// RVA: 0x176A304
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x176A5BC
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x176A728
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x176A894
	private void OnFocusOut(FocusOutEvent evt) { }

	// RVA: 0x176AA1C
	private void OnParentResized(GeometryChangedEvent evt) { }

	// RVA: 0x176A470
	private void UpdateSelection(VisualElement target) { }

	// RVA: 0x176AA30
	private void ChangeSelectedIndex(int newIndex, int previousIndex) { }

	// RVA: 0x176A0BC
	private int GetSelectedIndex() { }

	// RVA: 0x176AB84
	public void AddItem(string itemName, bool isChecked, Action action) { }

	// RVA: 0x176AEE4
	public void AddItem(string itemName, bool isChecked, System.Action<System.Object> action, object data) { }

	// RVA: 0x176AF20
	public void AddSeparator(string path) { }

	// RVA: 0x176ABC4
	private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data) { }

	// RVA: 0x176AFEC
	public void DropDown(Rect position, VisualElement targetElement, bool anchored) { }

	// RVA: 0x176BECC
	private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x176BF2C
	private void OnContainerGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x176B938
	private void EnsureVisibilityInParent() { }

	// RVA: 0x176BF30
	private static void .cctor() { }

	// RVA: 0x176A240
	private void <Apply>g__UpdateSelectionDown|39_0(int newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass39_0& ) { }

	// RVA: 0x176A178
	private void <Apply>g__UpdateSelectionUp|39_1(int newIndex, UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass39_0& ) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x176C458
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x78

	// Methods

	// RVA: 0x176C4AC
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x176C5A8
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

	// RVA: 0x176C140
	public void set_text(string value) { }

	// RVA: 0x176C284
	public void .ctor() { }

	// RVA: 0x176C30C
	public void .ctor(string text) { }

	// RVA: 0x176C398
	private void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x176C39C
	private void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x176C3A0
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x176D1C4
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x176D218
	public void .ctor() { }

}

// Namespace: 
private class Hash128Input
{
	// Methods

	// RVA: 0x176C808
	internal void .ctor() { }

	// RVA: 0x176D26C
	protected string get_allowedCharacters() { }

	// RVA: 0x176D2B0
	internal override bool AcceptCharacter(Char c) { }

	// RVA: 0x176D368
	protected override Hash128 StringToValue(string str) { }

	// RVA: 0x176CDCC
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

	// RVA: 0x176C64C
	public void .ctor() { }

	// RVA: 0x176C658
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x176C960
	public override Hash128 get_value() { }

	// RVA: 0x176C9C8
	public override void set_value(Hash128 value) { }

	// RVA: 0x176CAA4
	internal override void UpdateValueFromText() { }

	// RVA: 0x176CBA0
	internal override void UpdateTextFromValue() { }

	// RVA: 0x176CC40
	public override void SetValueWithoutNotify(Hash128 newValue) { }

	// RVA: 0x176CD1C
	protected override string ValueToString(Hash128 value) { }

	// RVA: 0x176CD44
	protected override Hash128 StringToValue(string str) { }

	// RVA: 0x176CE54
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x176D0C4
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

	// RVA: 0x17E76A4
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x70
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.HelpBoxMessageType> m_MessageType; // 0x78

	// Methods

	// RVA: 0x17E76F8
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17E7830
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

	// RVA: 0x176D3F0
	public void set_text(string value) { }

	// RVA: 0x176D418
	public void set_messageType(HelpBoxMessageType value) { }

	// RVA: 0x176D5C0
	public void .ctor() { }

	// RVA: 0x176D620
	public void .ctor(string text, HelpBoxMessageType messageType) { }

	// RVA: 0x176D78C
	private string GetIconClass(HelpBoxMessageType messageType) { }

	// RVA: 0x176D430
	private void UpdateIcon(HelpBoxMessageType messageType) { }

	// RVA: 0x176D874
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17E94FC
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17E9550
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

	// RVA: 0x17E797C
	public Texture get_image() { }

	// RVA: 0x17E7984
	public void set_image(Texture value) { }

	// RVA: 0x17E7A9C
	public Sprite get_sprite() { }

	// RVA: 0x17E7AA4
	public void set_sprite(Sprite value) { }

	// RVA: 0x17E7BBC
	public VectorImage get_vectorImage() { }

	// RVA: 0x17E7BC4
	public void set_vectorImage(VectorImage value) { }

	// RVA: 0x17E7CDC
	public Rect get_sourceRect() { }

	// RVA: 0x17E7ED4
	public Rect get_uv() { }

	// RVA: 0x17E7EE8
	public void set_uv(Rect value) { }

	// RVA: 0x17E7F24
	public ScaleMode get_scaleMode() { }

	// RVA: 0x17E7F2C
	public Color get_tintColor() { }

	// RVA: 0x17E7F40
	public void .ctor() { }

	// RVA: 0x17E8118
	private Vector2 GetTextureDisplaySize(Texture texture) { }

	// RVA: 0x17E8218
	private Vector2 GetTextureDisplaySize(Sprite sprite) { }

	// RVA: 0x17E8368
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x17E8618
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x17E8C20
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x17E8C58
	private void ReadCustomProperties(ICustomStyle customStyleProvider) { }

	// RVA: 0x318DB98
	private void SetProperty(T0 src, T0 dst, T1 alt0, T2 alt1) { }

	// RVA: 0x17E91E0
	private void ClearProperty() { }

	// RVA: 0x17E922C
	private void SetScaleMode(ScaleMode mode) { }

	// RVA: 0x17E924C
	private void SetTintColor(Color color) { }

	// RVA: 0x17E7CE0
	private Rect GetSourceRect() { }

	// RVA: 0x17E92BC
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

	// RVA: 0x30D6128
	public static bool RegisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback) { }

	// RVA: 0x30D6128
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: -1
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30D77E4
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

	// RVA: 0x30D3CF0
	internal VisualElement get_visualInput() { }

	// RVA: 0x30D4CD4
	internal void set_visualInput(VisualElement value) { }

	// RVA: 0x318DB98
	protected TValueType get_rawValue() { }

	// RVA: 0x318DB98
	protected void set_rawValue(TValueType value) { }

	// RVA: 0x30D4CD4
	internal void add_onValidateValue(System.Func<TValueType,TValueType> value) { }

	// RVA: 0x30D4CD4
	internal void remove_onValidateValue(System.Func<TValueType,TValueType> value) { }

	// RVA: 0x318DB98
	public virtual TValueType get_value() { }

	// RVA: 0x318DB98
	public virtual void set_value(TValueType value) { }

	// RVA: 0x30D3CF0
	public Label get_labelElement() { }

	// RVA: 0x30D4CD4
	private void set_labelElement(Label value) { }

	// RVA: 0x30D3CF0
	public string get_label() { }

	// RVA: 0x30D4CD4
	public void set_label(string value) { }

	// RVA: 0x30D3738
	public bool get_showMixedValue() { }

	// RVA: 0x30D4918
	public void set_showMixedValue(bool value) { }

	// RVA: 0x30D3CF0
	protected Label get_mixedValueLabel() { }

	// RVA: 0x30D3CF0
	private Action UnityEngine.UIElements.IEditableElement.get_editingStarted() { }

	// RVA: 0x30D3CF0
	private Action UnityEngine.UIElements.IEditableElement.get_editingEnded() { }

	// RVA: 0x30D4CD4
	internal void .ctor(string label) { }

	// RVA: 0x30D4F34
	protected void .ctor(string label, VisualElement visualInput) { }

	// RVA: 0x318DB98
	internal virtual bool EqualsCurrentValue(TValueType value) { }

	// RVA: 0x30D4CD4
	private void OnAttachToPanel(AttachToPanelEvent e) { }

	// RVA: 0x30D4CD4
	private void OnDetachFromPanel(DetachFromPanelEvent e) { }

	// RVA: 0x30D488C
	internal virtual void RegisterEditingCallbacks() { }

	// RVA: 0x30D488C
	internal virtual void UnregisterEditingCallbacks() { }

	// RVA: 0x30D4CD4
	internal void StartEditing(EventBase e) { }

	// RVA: 0x30D4CD4
	internal void EndEditing(EventBase e) { }

	// RVA: 0x30D4CD4
	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	// RVA: 0x30D4CD4
	private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x30D488C
	private void AlignLabel() { }

	// RVA: 0x318DB98
	internal TValueType ValidatedValue(TValueType value) { }

	// RVA: 0x30D488C
	protected virtual void UpdateMixedValueContent() { }

	// RVA: 0x318DB98
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30D488C
	internal override void OnViewDataReady() { }

	// RVA: -1
	internal override Rect GetTooltipRect() { }

	// RVA: 0x30D9218
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

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class KeyboardTextEditorEventHandler
{
	// Fields
	private readonly Event m_ImguiEvent; // 0x20
	internal bool m_Changed; // 0x28

	// Methods

	// RVA: 0x17E9558
	public void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x17E96F0
	public override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x17E9A2C
	private void OnFocus(FocusEvent _) { }

	// RVA: 0x17E9B54
	private void OnBlur(BlurEvent _) { }

	// RVA: 0x17E9BCC
	private void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x17EA944
	private void UpdateLabel() { }

	// RVA: 0x17EA370
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	// RVA: 0x17EA5B8
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	// RVA: 0x30D4CD4
	private void OnNavigationEvent(UnityEngine.UIElements.NavigationEventBase<TEvent> evt) { }

}

// Namespace: UnityEngine.UIElements
internal class TextEditorEventHandler
{
	// Fields
	protected TextElement textElement; // 0x10
	protected TextEditingUtilities editingUtilities; // 0x18

	// Methods

	// RVA: 0x17E96A0
	protected void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x17E9A28
	public virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17EBB24
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private static readonly UxmlStringAttributeDescription k_Value; // 0x0
	private UxmlBoolAttributeDescription m_Multiline; // 0xC8

	// Methods

	// RVA: 0x17EBB78
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17EBD20
	public void .ctor() { }

	// RVA: 0x17EBDD8
	private static void .cctor() { }

}

// Namespace: 
private class TextInput
{
	// Methods

	// RVA: 0x17EADAC
	public void set_multiline(bool value) { }

	// RVA: 0x17EBEF4
	public override void set_isPasswordField(bool value) { }

	// RVA: 0x17EBF70
	protected override string StringToValue(string str) { }

	// RVA: 0x17EB29C
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

	// RVA: 0x17EAC30
	private TextInput get_textInput() { }

	// RVA: 0x17EACE8
	public void set_multiline(bool value) { }

	// RVA: 0x17EB008
	public void .ctor() { }

	// RVA: 0x17EB020
	public void .ctor(string label) { }

	// RVA: 0x17EB034
	public void .ctor(string label, int maxLength, bool multiline, bool isPasswordField, Char maskChar) { }

	// RVA: 0x17EB340
	public override string get_value() { }

	// RVA: 0x17EB3A8
	public override void set_value(string value) { }

	// RVA: 0x17EB4E0
	public override void SetValueWithoutNotify(string newValue) { }

	// RVA: 0x17EB690
	internal override void UpdateTextFromValue() { }

	// RVA: 0x17EB70C
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x17EB944
	internal override void OnViewDataReady() { }

	// RVA: 0x17EBA14
	protected override string ValueToString(string value) { }

	// RVA: 0x17EBA1C
	protected override string StringToValue(string str) { }

	// RVA: 0x17EBA24
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

	// RVA: 0x30D488C
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

	// RVA: 0x30D3CF0
	internal TextElement get_textElement() { }

	// RVA: 0x30D4CD4
	private void set_textElement(TextElement value) { }

	// RVA: 0x30D3CF0
	public ITextSelection get_textSelection() { }

	// RVA: 0x30D3CF0
	public ITextEdition get_textEdition() { }

	// RVA: 0x30D488C
	public void SelectAll() { }

	// RVA: 0x30D488C
	internal void SelectNone() { }

	// RVA: 0x30D3CF0
	internal string get_originalText() { }

	// RVA: 0x318DB98
	protected virtual TValueType StringToValue(string str) { }

	// RVA: 0x30D488C
	internal void UpdateValueFromText() { }

	// RVA: 0x30D488C
	internal void UpdateTextFromValue() { }

	// RVA: 0x30D488C
	internal void MoveFocusToCompositeRoot() { }

	// RVA: 0x30D3738
	public bool get_isReadOnly() { }

	// RVA: 0x30D4A04
	public void set_maxLength(int value) { }

	// RVA: -1
	public void set_maskChar(Char value) { }

	// RVA: 0x30D3738
	public virtual bool get_isPasswordField() { }

	// RVA: 0x30D4918
	public virtual void set_isPasswordField(bool value) { }

	// RVA: 0x30D4918
	internal void set_isDragging(bool value) { }

	// RVA: 0x30D3CF0
	public string get_text() { }

	// RVA: 0x30D4CD4
	public void set_text(string value) { }

	// RVA: 0x30D488C
	internal void .ctor() { }

	// RVA: 0x30D4CD4
	private void MakeSureScrollViewDoesNotLeakEvents(UnityEngine.UIElements.ChangeEvent<System.Single> evt) { }

	// RVA: 0x30D488C
	internal void SetSingleLine() { }

	// RVA: 0x30D488C
	internal void SetMultiline() { }

	// RVA: 0x30D4CD4
	private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e) { }

	// RVA: 0x30D4CD4
	private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e) { }

	// RVA: 0x30D4CD4
	internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x318DB98
	internal virtual bool AcceptCharacter(Char c) { }

	// RVA: 0x30D4918
	internal void UpdateScrollOffset(bool isBackspace) { }

	// RVA: -1
	internal void UpdateScrollOffset(bool isBackspace, bool widthChanged) { }

	// RVA: 0x318DB98
	private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged) { }

	// RVA: 0x30D488C
	internal void SetScrollViewMode() { }

	// RVA: 0x30D488C
	private void SetMultilineContainerStyle() { }

	// RVA: 0x30D488C
	private void RemoveSingleLineComponents() { }

	// RVA: 0x30D488C
	private void RemoveMultilineComponents() { }

	// RVA: 0x30D9218
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

	// RVA: 0x30D3CF0
	protected internal TextInputBase get_textInputBase() { }

	// RVA: 0x30D3CF0
	public string get_text() { }

	// RVA: 0x30D4CD4
	protected internal void set_text(string value) { }

	// RVA: 0x30D4CD4
	protected void add_onIsReadOnlyChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x30D4CD4
	protected void remove_onIsReadOnlyChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x30D3738
	public bool get_isReadOnly() { }

	// RVA: 0x30D4918
	public void set_isReadOnly(bool value) { }

	// RVA: 0x30D4918
	public void set_isPasswordField(bool value) { }

	// RVA: 0x30D4918
	public void set_autoCorrection(bool value) { }

	// RVA: 0x30D4918
	public void set_hideMobileInput(bool value) { }

	// RVA: 0x30D4A04
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x30D3CF0
	public ITextEdition get_textEdition() { }

	// RVA: 0x30D4A04
	public void set_maxLength(int value) { }

	// RVA: 0x30D3738
	public bool get_isDelayed() { }

	// RVA: 0x30D4918
	public void set_isDelayed(bool value) { }

	// RVA: -1
	public void set_maskChar(Char value) { }

	// RVA: -1
	protected abstract string ValueToString(TValueType value) { }

	// RVA: -1
	protected abstract TValueType StringToValue(string str) { }

	// RVA: 0x318DB98
	protected void .ctor(string label, int maxLength, Char maskChar, TextInputBase textInputBase) { }

	// RVA: 0x30D4CD4
	private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x30D4CD4
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x30D488C
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x30D488C
	internal virtual void UpdateValueFromText() { }

	// RVA: 0x30D488C
	internal virtual void UpdateTextFromValue() { }

	// RVA: 0x30D9218
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

	// RVA: 0x17EBF78
	public void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x17EBFDC
	private void PollTouchScreenKeyboard() { }

	// RVA: 0x17EC250
	private void DoPollTouchScreenKeyboard() { }

	// RVA: 0x17ECC34
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x17ECB40
	private void CloseTouchScreenKeyboard() { }

	// RVA: 0x17ECEE8
	private void OpenTouchScreenKeyboard() { }

	// RVA: 0x17ED454
	public override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x17ED65C
	private void OnPointerDownEvent() { }

	// RVA: 0x17ED860
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x17ED884
	private void OnFocusInEvent() { }

	// RVA: 0x17EDA4C
	private void OnFocusOutEvent(FocusOutEvent evt) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17EE690
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17EE6E4
	public void .ctor() { }

}

// Namespace: 
private class IntegerInput
{
	// Methods

	// RVA: 0x17EE738
	private IntegerField get_parentIntegerField() { }

	// RVA: 0x17EE3C4
	internal void .ctor() { }

	// RVA: 0x17EE7BC
	protected override string get_allowedCharacters() { }

	// RVA: 0x17EE838
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x17EEB5C
	protected override string ValueToString(int v) { }

	// RVA: 0x17EEBB4
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

	// RVA: 0x17EDF08
	private IntegerInput get_integerInput() { }

	// RVA: 0x17EDFC0
	protected override string ValueToString(int v) { }

	// RVA: 0x17EE080
	protected override int StringToValue(string str) { }

	// RVA: 0x17EE1BC
	public void .ctor() { }

	// RVA: 0x17EE1C8
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x17EE460
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x17EE48C
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x17EE590
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17EEE24
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17EEE78
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Label
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x17EEC64
	public void .ctor() { }

	// RVA: 0x17EECC0
	public void .ctor(string text) { }

	// RVA: 0x17EEDAC
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17EEFB8
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17EF00C
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

	// RVA: 0x17EEE80
	public System.Func<UnityEngine.UIElements.VisualElement> get_makeItem() { }

	// RVA: 0x17EEE88
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem() { }

	// RVA: 0x17EEE90
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem() { }

	// RVA: 0x17EEE98
	public System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem() { }

	// RVA: 0x17EEEA0
	internal override bool HasValidDataAndBindings() { }

	// RVA: 0x17EEEE4
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x17EEF3C
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17EF79C
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x17EF7F0
	public void .ctor() { }

}

// Namespace: 
private class LongInput
{
	// Methods

	// RVA: 0x17EF844
	private LongField get_parentLongField() { }

	// RVA: 0x17EF4D0
	internal void .ctor() { }

	// RVA: 0x17EF8C8
	protected override string get_allowedCharacters() { }

	// RVA: 0x17EF944
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Int64 startValue) { }

	// RVA: 0x17EFC98
	private Int64 ClampMinMaxLongValue(Int64 niceDelta, Int64 value) { }

	// RVA: 0x17EFD3C
	protected override string ValueToString(Int64 v) { }

	// RVA: 0x17EFD94
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

	// RVA: 0x17EF014
	private LongInput get_longInput() { }

	// RVA: 0x17EF0CC
	protected override string ValueToString(Int64 v) { }

	// RVA: 0x17EF18C
	protected override Int64 StringToValue(string str) { }

	// RVA: 0x17EF2C8
	public void .ctor() { }

	// RVA: 0x17EF2D4
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x17EF56C
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x17EF598
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Int64 startValue) { }

	// RVA: 0x17EF69C
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17F2EF8
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

	// RVA: 0x17F2F4C
	public void .ctor() { }

	// RVA: 0x17F3194
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

	// RVA: 0x17EFE44
	internal VisualElement get_dragElement() { }

	// RVA: 0x17EFE4C
	private void set_dragElement(VisualElement value) { }

	// RVA: 0x17EFE5C
	internal VisualElement get_dragMinThumb() { }

	// RVA: 0x17EFE64
	private void set_dragMinThumb(VisualElement value) { }

	// RVA: 0x17EFE74
	internal VisualElement get_dragMaxThumb() { }

	// RVA: 0x17EFE7C
	private void set_dragMaxThumb(VisualElement value) { }

	// RVA: 0x17EFE8C
	internal UnityEngine.UIElements.ClampedDragger<System.Single> get_clampedDragger() { }

	// RVA: 0x17EFE94
	private void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<System.Single> value) { }

	// RVA: 0x17EFEA4
	public float get_minValue() { }

	// RVA: 0x17EFEB4
	public void set_minValue(float value) { }

	// RVA: 0x17EFFBC
	public float get_maxValue() { }

	// RVA: 0x17EFFE0
	public void set_maxValue(float value) { }

	// RVA: 0x17F00B0
	public override Vector2 get_value() { }

	// RVA: 0x17F0118
	public override void set_value(Vector2 value) { }

	// RVA: 0x17F01BC
	public override void SetValueWithoutNotify(Vector2 newValue) { }

	// RVA: 0x17F110C
	public float get_lowLimit() { }

	// RVA: 0x17F1114
	public void set_lowLimit(float value) { }

	// RVA: 0x17F1284
	public float get_highLimit() { }

	// RVA: 0x17F128C
	public void set_highLimit(float value) { }

	// RVA: 0x17F13FC
	public void .ctor() { }

	// RVA: 0x17F141C
	public void .ctor(string label, float minValue, float maxValue, float minLimit, float maxLimit) { }

	// RVA: 0x17EFF84
	private Vector2 ClampValues(Vector2 valueToClamp) { }

	// RVA: 0x17F1B28
	private void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	// RVA: 0x17F0268
	private void UpdateDragElementPosition() { }

	// RVA: 0x17F1B90
	private void UpdateDragThumbsRect() { }

	// RVA: 0x17F1B80
	internal float SliderLerpUnclamped(float a, float b, float interpolant) { }

	// RVA: 0x17F1B70
	internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	// RVA: 0x17F22D8
	private float ComputeValueFromPosition(float positionToConvert) { }

	// RVA: 0x17F247C
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x17F25CC
	private void SetSliderValueFromDrag() { }

	// RVA: 0x17F280C
	private void SetSliderValueFromClick() { }

	// RVA: 0x17F2664
	private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos) { }

	// RVA: 0x17F2A3C
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x17F2A40
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x17F2B94
	internal override void UnregisterEditingCallbacks() { }

	// RVA: 0x17F2CE8
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

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass15_0
{
	// Fields
	public VisualTreeAsset asset; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3CF0
	internal VisualElement <Init>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass15_1
{
	// Fields
	public VisualTreeAsset asset; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x318DB98
	private static Length ParseLength(string str, Length defaultValue) { }

	// RVA: -1
	public override void Init(T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30D488C
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

	// RVA: 0x17F3348
	public string get_name() { }

	// RVA: 0x17F3350
	public void set_name(string value) { }

	// RVA: 0x17F3408
	public string get_title() { }

	// RVA: 0x17F3410
	public void set_title(string value) { }

	// RVA: 0x17F348C
	public Background get_icon() { }

	// RVA: 0x17F3498
	internal int get_index() { }

	// RVA: 0x17F3620
	internal int get_displayIndex() { }

	// RVA: 0x17F3800
	internal int get_visibleIndex() { }

	// RVA: 0x17F38D8
	public bool get_visible() { }

	// RVA: 0x17F38E0
	public void set_visible(bool value) { }

	// RVA: 0x17F3934
	public Length get_width() { }

	// RVA: 0x17F393C
	public void set_width(Length value) { }

	// RVA: 0x17F39F4
	public Length get_minWidth() { }

	// RVA: 0x17F39FC
	public void set_minWidth(Length value) { }

	// RVA: 0x17F3A60
	public Length get_maxWidth() { }

	// RVA: 0x17F3A68
	public void set_maxWidth(Length value) { }

	// RVA: 0x17F3ACC
	internal float get_desiredWidth() { }

	// RVA: 0x17F39C4
	internal void set_desiredWidth(float value) { }

	// RVA: 0x17F3AD4
	public bool get_sortable() { }

	// RVA: 0x17F3ADC
	public void set_sortable(bool value) { }

	// RVA: 0x17F3B30
	public bool get_stretchable() { }

	// RVA: 0x17F3B38
	public void set_stretchable(bool value) { }

	// RVA: 0x17F3B8C
	public bool get_optional() { }

	// RVA: 0x17F3B94
	public void set_optional(bool value) { }

	// RVA: 0x17F3BE8
	public bool get_resizable() { }

	// RVA: 0x17F3BF0
	public void set_resizable(bool value) { }

	// RVA: 0x17F3C44
	public System.Func<UnityEngine.UIElements.VisualElement> get_makeHeader() { }

	// RVA: 0x17F3C4C
	public void set_makeHeader(System.Func<UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x17F3CC8
	public System.Action<UnityEngine.UIElements.VisualElement> get_bindHeader() { }

	// RVA: 0x17F3CD0
	public System.Action<UnityEngine.UIElements.VisualElement> get_unbindHeader() { }

	// RVA: 0x17F3CD8
	public System.Action<UnityEngine.UIElements.VisualElement> get_destroyHeader() { }

	// RVA: 0x17F3CE0
	public System.Func<UnityEngine.UIElements.VisualElement> get_makeCell() { }

	// RVA: 0x17F3CE8
	public void set_makeCell(System.Func<UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x17F3D64
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindCell() { }

	// RVA: 0x17F3D6C
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindCell() { }

	// RVA: 0x17F3D74
	public System.Action<UnityEngine.UIElements.VisualElement> get_destroyCell() { }

	// RVA: 0x17F3D7C
	public Columns get_collection() { }

	// RVA: 0x17F3D84
	internal void set_collection(Columns value) { }

	// RVA: 0x17F3D8C
	internal void add_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x17F3E40
	internal void remove_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x17F3EF4
	internal void add_resized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17F3FA8
	internal void remove_resized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17F33C8
	private void NotifyChange(ColumnDataType type) { }

	// RVA: 0x17F405C
	internal float GetWidth(float layoutWidth) { }

	// RVA: 0x17F4080
	internal float GetMaxWidth(float layoutWidth) { }

	// RVA: 0x17F40A4
	internal float GetMinWidth(float layoutWidth) { }

	// RVA: 0x17F40C8
	public void .ctor() { }

	// RVA: 0x17F413C
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public float totalColumnWidth; // 0x10
	public ColumnLayout <>4__this; // 0x18

	// Methods

	// RVA: 0x17F800C
	public void .ctor() { }

	// RVA: 0x17F95A8
	internal void <RecomputeToMaxWidthProportionally>b__1(Column c) { }

}

// Namespace: 
private sealed class <>c__DisplayClass54_0
{
	// Fields
	public float totalColumnsWidth; // 0x10
	public ColumnLayout <>4__this; // 0x18

	// Methods

	// RVA: 0x17F81BC
	public void .ctor() { }

	// RVA: 0x17F95E8
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

	// RVA: 0x17F41B4
	public Columns get_columns() { }

	// RVA: 0x17F41BC
	public float get_columnsWidth() { }

	// RVA: 0x17F44BC
	public float get_layoutWidth() { }

	// RVA: 0x17F44C4
	public float get_minColumnsWidth() { }

	// RVA: 0x17F44CC
	public float get_maxColumnsWidth() { }

	// RVA: 0x17F44D4
	public bool get_hasStretchableColumns() { }

	// RVA: 0x17F4528
	public bool get_hasRelativeWidthColumns() { }

	// RVA: 0x17F45A0
	public void add_layoutRequested(Action value) { }

	// RVA: 0x17F4644
	public void remove_layoutRequested(Action value) { }

	// RVA: 0x17F46E8
	public void .ctor(Columns columns) { }

	// RVA: 0x17F51D0
	public void Dirty() { }

	// RVA: 0x17F4CD8
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x17F5378
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x17F55A0
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x17F55F0
	private bool RequiresLayoutUpdate(ColumnDataType type) { }

	// RVA: 0x17F5608
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x17F5680
	private void OnColumnResized(Column column) { }

	// RVA: 0x17F568C
	private static bool IsClamped(float value, float min, float max) { }

	// RVA: 0x17F56A0
	public void DoLayout(float width) { }

	// RVA: 0x17F6EDC
	public void StretchResizeColumns(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x17F6FC8
	private void DistributeOverflow(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x17F724C
	private void DistributeExcess(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x17F7B98
	private float RecomputeToMaxWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x17F76F4
	private float RecomputeToMinWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x17F75B4
	private float RecomputeToDesiredWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	// RVA: 0x17F81C4
	private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	// RVA: 0x17F79F4
	private float RecomputeToMinWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x17F7E7C
	private float RecomputeToMaxWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x17F8384
	public void ResizeToFit(float width) { }

	// RVA: 0x17F8014
	private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly) { }

	// RVA: 0x17F8688
	internal void BeginDragResize(Column column, float pos, bool previewMode) { }

	// RVA: 0x17F8ACC
	public float GetDesiredPosition(Column column) { }

	// RVA: 0x17F6E14
	public float GetDesiredWidth(Column c) { }

	// RVA: 0x17F8C60
	public void DragResize(Column column, float pos) { }

	// RVA: 0x17F8EE8
	internal void EndDragResize(Column column, bool cancelled) { }

	// RVA: 0x17F65F8
	private void UpdateCache() { }

	// RVA: 0x17F6A38
	private void UpdateMinAndMaxColumnsWidth() { }

	// RVA: 0x17F5220
	private void ClearCache() { }

	// RVA: 0x17F93E8
	private int <DoLayout>b__49_0(Column c1, Column c2) { }

	// RVA: 0x17F9458
	private int <DoLayout>b__49_1(Column c1, Column c2) { }

	// RVA: 0x17F94C8
	private int <RecomputeToMaxWidthProportionally>b__53_0(Column c1, Column c2) { }

	// RVA: 0x17F9538
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

	// RVA: 0x30D488C
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

	// RVA: 0x30D488C
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

	// RVA: 0x17FB9EC
	private static void .cctor() { }

	// RVA: 0x17FBA58
	public void .ctor() { }

	// RVA: 0x17FBA60
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

	// RVA: 0x17F9628
	public string get_primaryColumnName() { }

	// RVA: 0x17F9630
	public void set_primaryColumnName(string value) { }

	// RVA: 0x17F96DC
	public bool get_reorderable() { }

	// RVA: 0x17F96E4
	public void set_reorderable(bool value) { }

	// RVA: 0x17F9730
	public bool get_resizable() { }

	// RVA: 0x17F9738
	public void set_resizable(bool value) { }

	// RVA: 0x17F9784
	public bool get_resizePreview() { }

	// RVA: 0x17F978C
	public void set_resizePreview(bool value) { }

	// RVA: 0x17F374C
	internal System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_displayList() { }

	// RVA: 0x17F38B4
	internal System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_visibleList() { }

	// RVA: 0x17F9B4C
	internal void add_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value) { }

	// RVA: 0x17F9C00
	internal void remove_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value) { }

	// RVA: 0x17F9CB4
	public StretchMode get_stretchMode() { }

	// RVA: 0x17F9CBC
	public void set_stretchMode(StretchMode value) { }

	// RVA: 0x17F4FB4
	internal void add_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value) { }

	// RVA: 0x17F9D08
	internal void remove_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value) { }

	// RVA: 0x17F5068
	internal void add_columnRemoved(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17F9DBC
	internal void remove_columnRemoved(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17F9E70
	internal void add_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x17F9F24
	internal void remove_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x17F9FD8
	internal void add_columnResized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17FA08C
	internal void remove_columnResized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17F511C
	internal void add_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value) { }

	// RVA: 0x17FA140
	internal void remove_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value) { }

	// RVA: 0x17FA1F4
	public bool IsPrimary(Column column) { }

	// RVA: 0x17F6D60
	public System.Collections.Generic.IEnumerator<UnityEngine.UIElements.Column> GetEnumerator() { }

	// RVA: 0x17FA2F8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x17FA3AC
	public void Add(Column item) { }

	// RVA: 0x17FA844
	public void Clear() { }

	// RVA: 0x17FAD3C
	public bool Contains(Column item) { }

	// RVA: 0x17FADF4
	public bool Contains(string name) { }

	// RVA: 0x17FB108
	public void CopyTo(Column[] array, int arrayIndex) { }

	// RVA: 0x17FAA08
	public bool Remove(Column column) { }

	// RVA: 0x17FB1C8
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x17FB350
	private void OnColumnResized(Column column) { }

	// RVA: 0x17F4F00
	public int get_Count() { }

	// RVA: 0x17FB36C
	public bool get_IsReadOnly() { }

	// RVA: 0x17F3568
	public int IndexOf(Column column) { }

	// RVA: 0x17FA46C
	public void Insert(int index, Column column) { }

	// RVA: 0x17F4C24
	public Column get_Item(int index) { }

	// RVA: 0x17FB424
	public Column get_Item(string name) { }

	// RVA: 0x17FB738
	public void ReorderDisplay(int from, int to) { }

	// RVA: 0x17F97D8
	private void InitOrderColumns() { }

	// RVA: 0x17FB2AC
	private void DirtyVisibleColumns() { }

	// RVA: 0x17F9878
	private void UpdateVisibleColumns() { }

	// RVA: 0x17F96A4
	private void NotifyChange(ColumnsDataType type) { }

	// RVA: 0x17FB94C
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

	// RVA: 0x17FBA7C
	public void add_columnSortingChanged(Action value) { }

	// RVA: 0x17FBB20
	public void remove_columnSortingChanged(Action value) { }

	// RVA: 0x17FBBC4
	public void add_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17FBC78
	public void remove_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17FBD2C
	internal MultiColumnCollectionHeader get_header() { }

	// RVA: 0x17FBD34
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x318DB98
	private static void BindCellItem(VisualElement ve, int rowIndex, Column column, T item) { }

	// RVA: 0x17FC3A4
	private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column) { }

	// RVA: 0x17FC3EC
	private static VisualElement DefaultMakeCellItem() { }

	// RVA: 0x318DB98
	private static void DefaultBindCellItem(VisualElement ve, Column column, T item) { }

	// RVA: 0x17FC4C4
	public VisualElement MakeItem() { }

	// RVA: 0x318DB98
	public void BindItem(VisualElement element, int index, T item) { }

	// RVA: 0x17FC934
	public void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x17FCD4C
	public void DestroyItem(VisualElement element) { }

	// RVA: 0x17FD184
	public void PrepareView(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x17FD47C
	public void Dispose() { }

	// RVA: 0x17FDBD4
	private void OnHorizontalScrollerValueChanged(float v) { }

	// RVA: 0x17FDBF4
	private void OnViewportGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17FE074
	private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17FDEC0
	private void UpdateContentContainer(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x17FE07C
	private void OnColumnSortingChanged() { }

	// RVA: 0x17FE098
	private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column) { }

	// RVA: 0x17FE0B4
	private void OnColumnResized(int index, float width) { }

	// RVA: 0x17FE484
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x17FE4A4
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x17FE4C4
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x17FE4FC
	private void OnColumnsChanged(Column column, ColumnDataType type) { }

	// RVA: 0x17FE53C
	private void OnColumnChanged(ColumnsDataType type) { }

	// RVA: 0x17FE578
	private void OnViewDataRestored() { }

	// RVA: 0x17FE598
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x17FF7D8
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

	// RVA: 0x17FF82C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x17FF990
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

	// RVA: 0x17FE7C0
	public MultiColumnListViewController get_viewController() { }

	// RVA: 0x17FE850
	public Columns get_columns() { }

	// RVA: 0x17FE858
	private void set_columns(Columns value) { }

	// RVA: 0x17FE96C
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	// RVA: 0x17FE974
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x17FEC40
	public void set_sortingEnabled(bool value) { }

	// RVA: 0x17FED54
	public void .ctor() { }

	// RVA: 0x17FEE3C
	public void .ctor(Columns columns) { }

	// RVA: 0x17FF0F4
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x17FF170
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x17FF768
	internal override void CreateVirtualizationController() { }

	// RVA: 0x17FEC24
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x17FF7BC
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x180091C
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

	// RVA: 0x1800970
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1800AD4
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

	// RVA: 0x17FFAD4
	public MultiColumnTreeViewController get_viewController() { }

	// RVA: 0x17FFB64
	public Columns get_columns() { }

	// RVA: 0x17FFB6C
	private void set_columns(Columns value) { }

	// RVA: 0x17FFC80
	public SortColumnDescriptions get_sortColumnDescriptions() { }

	// RVA: 0x17FFC88
	private void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x17FFDF4
	public void set_sortingEnabled(bool value) { }

	// RVA: 0x17FFF08
	public void .ctor() { }

	// RVA: 0x17FFFF0
	public void .ctor(Columns columns) { }

	// RVA: 0x180021C
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x18002B4
	public override void SetViewController(CollectionViewController controller) { }

	// RVA: 0x18008AC
	internal override void CreateVirtualizationController() { }

	// RVA: 0x17FFDD8
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x1800900
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

	// RVA: 0x30D488C
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

	// RVA: 0x30D488C
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

	// RVA: 0x1800C18
	public string get_columnName() { }

	// RVA: 0x1800C20
	public void set_columnName(string value) { }

	// RVA: 0x1800C94
	public int get_columnIndex() { }

	// RVA: 0x1800C9C
	public void set_columnIndex(int value) { }

	// RVA: 0x1800CD0
	public Column get_column() { }

	// RVA: 0x1800CD8
	internal void set_column(Column value) { }

	// RVA: 0x1800CE0
	public SortDirection get_direction() { }

	// RVA: 0x1800CE8
	public void set_direction(SortDirection value) { }

	// RVA: 0x1800D1C
	internal void add_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value) { }

	// RVA: 0x1800DD0
	internal void remove_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value) { }

	// RVA: 0x1800E84
	public void .ctor() { }

	// RVA: 0x1800E94
	public void .ctor(int columnIndex, SortDirection direction) { }

	// RVA: 0x1800F34
	public void .ctor(string columnName, SortDirection direction) { }

}

// Namespace: 
internal class UxmlObjectFactory<T0>
{
	// Methods

	// RVA: 0x30D488C
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

	// RVA: 0x30D488C
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

	// RVA: 0x1800FEC
	internal void add_changed(Action value) { }

	// RVA: 0x1801090
	internal void remove_changed(Action value) { }

	// RVA: 0x1801134
	public System.Collections.Generic.IEnumerator<UnityEngine.UIElements.SortColumnDescription> GetEnumerator() { }

	// RVA: 0x18011E8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x180129C
	public void Add(SortColumnDescription item) { }

	// RVA: 0x17FEAC4
	public void Clear() { }

	// RVA: 0x1801850
	public bool Contains(SortColumnDescription item) { }

	// RVA: 0x1801908
	public void CopyTo(SortColumnDescription[] array, int arrayIndex) { }

	// RVA: 0x180162C
	public bool Remove(SortColumnDescription desc) { }

	// RVA: 0x18019C8
	private void OnDescriptionChanged(SortColumnDescription desc) { }

	// RVA: 0x18019E4
	public int get_Count() { }

	// RVA: 0x1801A98
	public bool get_IsReadOnly() { }

	// RVA: 0x180135C
	public void Insert(int index, SortColumnDescription desc) { }

	// RVA: 0x17FF068
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass26_0
{
	// Fields
	public T item; // 0x0
	public UnityEngine.UIElements.PopupField<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D3CF0
	internal override string GetValueToDisplay() { }

	// RVA: 0x318DB98
	internal override string GetListItemToDisplay(T value) { }

	// RVA: 0x318DB98
	public override T get_value() { }

	// RVA: 0x318DB98
	public override void set_value(T value) { }

	// RVA: 0x318DB98
	public override void SetValueWithoutNotify(T newValue) { }

	// RVA: 0x30D4A04
	public void set_index(int value) { }

	// RVA: 0x30D4CD4
	public void .ctor(string label) { }

	// RVA: 0x30D4CD4
	internal override void AddMenuItems(IGenericMenu menu) { }

	// RVA: 0x318DB98
	private void ChangeValueFromMenu(T menuItem) { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1801D54
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x1801DA8
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

	// RVA: 0x1801B50
	public void .ctor() { }

	// RVA: 0x1801C94
	public override VisualElement get_contentContainer() { }

	// RVA: 0x1801C9C
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

	// RVA: 0x18027AC
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1802994
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

	// RVA: 0x1801DB0
	public void set_title(string value) { }

	// RVA: 0x1801DD8
	public float get_lowValue() { }

	// RVA: 0x1801DE0
	public void set_lowValue(float value) { }

	// RVA: 0x1801F74
	public float get_highValue() { }

	// RVA: 0x1801F7C
	public void set_highValue(float value) { }

	// RVA: 0x1801F88
	public void .ctor() { }

	// RVA: 0x1802298
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x18022C8
	public virtual float get_value() { }

	// RVA: 0x18022D0
	public virtual void set_value(float value) { }

	// RVA: 0x1802520
	public void SetValueWithoutNotify(float newValue) { }

	// RVA: 0x1801DEC
	private void SetProgress(float p) { }

	// RVA: 0x1802554
	private float CalculateProgressWidth(float width) { }

	// RVA: 0x18025E4
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1802C50
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ProgressBar
{
	// Methods

	// RVA: 0x1802BD0
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x18038C8
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x88

	// Methods

	// RVA: 0x180391C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1803A30
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

	// RVA: 0x1802CA4
	public override bool get_value() { }

	// RVA: 0x1802D0C
	public override void set_value(bool value) { }

	// RVA: 0x1802F14
	public void .ctor() { }

	// RVA: 0x1802F1C
	public void .ctor(string label) { }

	// RVA: 0x18031E0
	private void OnOptionAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x1803284
	private void OnOptionDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x1803328
	protected override void InitLabel() { }

	// RVA: 0x18033B0
	protected override void ToggleValue() { }

	// RVA: 0x1803400
	private void UnityEngine.UIElements.IGroupBoxOption.SetSelected(bool selected) { }

	// RVA: 0x1803410
	public override void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x1802E00
	private void UpdateCheckmark() { }

	// RVA: 0x1803438
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x1803514
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1804CDC
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Choices; // 0x88

	// Methods

	// RVA: 0x1804D30
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1804E5C
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

	// RVA: 0x1803AE8
	public void set_choices(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x180448C
	public override VisualElement get_contentContainer() { }

	// RVA: 0x180449C
	public void .ctor() { }

	// RVA: 0x18044A8
	public void .ctor(string label, System.Collections.Generic.List<System.String> radioButtonChoices) { }

	// RVA: 0x1804714
	private void RadioButtonValueChangedCallback(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

	// RVA: 0x1804864
	public override void SetValueWithoutNotify(int newValue) { }

	// RVA: 0x18041F0
	private void UpdateRadioButtons() { }

	// RVA: 0x18048D8
	private void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x1804AA0
	private void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x1804C24
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x18051E0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlLongAttributeDescription m_Delay; // 0x98
	private UxmlLongAttributeDescription m_Interval; // 0xA0

	// Methods

	// RVA: 0x1805234
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x18053D0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class RepeatButton
{
	// Fields
	private Clickable m_Clickable; // 0x4A0
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x1804F14
	public void .ctor() { }

	// RVA: 0x1804FE4
	public void .ctor(Action clickEvent, Int64 delay, Int64 interval) { }

	// RVA: 0x1805098
	public void SetAction(Action clickEvent, Int64 delay, Int64 interval) { }

	// RVA: 0x1805148
	internal void AddAction(Action clickEvent) { }

	// RVA: 0x1805168
	private static void .cctor() { }

}

// Namespace: 
private class ScrollerSlider
{
	// Methods

	// RVA: 0x1805EE4
	public void .ctor(float start, float end, SliderDirection direction, float pageSize) { }

	// RVA: 0x18064E8
	internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1806520
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

	// RVA: 0x1806574
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x180675C
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

	// RVA: 0x18054C0
	public void add_valueChanged(System.Action<System.Single> value) { }

	// RVA: 0x1805578
	public void remove_valueChanged(System.Action<System.Single> value) { }

	// RVA: 0x1805630
	public Slider get_slider() { }

	// RVA: 0x1805638
	private void set_slider(Slider value) { }

	// RVA: 0x1805648
	public RepeatButton get_lowButton() { }

	// RVA: 0x1805650
	private void set_lowButton(RepeatButton value) { }

	// RVA: 0x1805660
	public RepeatButton get_highButton() { }

	// RVA: 0x1805668
	private void set_highButton(RepeatButton value) { }

	// RVA: 0x1805678
	public float get_value() { }

	// RVA: 0x18056A0
	public void set_value(float value) { }

	// RVA: 0x18056C8
	public float get_lowValue() { }

	// RVA: 0x1805730
	public void set_lowValue(float value) { }

	// RVA: 0x18057A4
	public float get_highValue() { }

	// RVA: 0x180580C
	public void set_highValue(float value) { }

	// RVA: 0x1805880
	public void set_direction(SliderDirection value) { }

	// RVA: 0x1805AE8
	public void .ctor() { }

	// RVA: 0x1805AFC
	public void .ctor(float lowValue, float highValue, System.Action<System.Single> valueChanged, SliderDirection direction) { }

	// RVA: 0x1805F78
	public void Adjust(float factor) { }

	// RVA: 0x1805FF4
	private void OnSliderValueChange(UnityEngine.UIElements.ChangeEvent<System.Single> evt) { }

	// RVA: 0x18060EC
	public void ScrollPageUp() { }

	// RVA: 0x1806200
	public void ScrollPageDown() { }

	// RVA: 0x18060F4
	public void ScrollPageUp(float factor) { }

	// RVA: 0x1806208
	public void ScrollPageDown(float factor) { }

	// RVA: 0x1806314
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

	// RVA: 0x180E0D4
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

	// RVA: 0x180E128
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x180E540
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

	// RVA: 0x1806A04
	public ScrollerVisibility get_horizontalScrollerVisibility() { }

	// RVA: 0x1806A0C
	public void set_horizontalScrollerVisibility(ScrollerVisibility value) { }

	// RVA: 0x1807240
	public ScrollerVisibility get_verticalScrollerVisibility() { }

	// RVA: 0x1807248
	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	// RVA: 0x18073A0
	public void set_showHorizontal(bool value) { }

	// RVA: 0x18073BC
	public void set_showVertical(bool value) { }

	// RVA: 0x1806B68
	internal bool get_needsHorizontal() { }

	// RVA: 0x1806C18
	internal bool get_needsVertical() { }

	// RVA: 0x1807490
	internal bool get_isVerticalScrollDisplayed() { }

	// RVA: 0x1807554
	internal bool get_isHorizontalScrollDisplayed() { }

	// RVA: 0x1807618
	public Vector2 get_scrollOffset() { }

	// RVA: 0x180768C
	public void set_scrollOffset(Vector2 value) { }

	// RVA: 0x1807BD8
	public void set_horizontalPageSize(float value) { }

	// RVA: 0x1807E44
	public void set_verticalPageSize(float value) { }

	// RVA: 0x18080B0
	public float get_mouseWheelScrollSize() { }

	// RVA: 0x18080B8
	public void set_mouseWheelScrollSize(float value) { }

	// RVA: 0x18073D8
	internal float get_scrollableWidth() { }

	// RVA: 0x1807434
	internal float get_scrollableHeight() { }

	// RVA: 0x1808178
	private bool get_hasInertia() { }

	// RVA: 0x1808188
	public float get_scrollDecelerationRate() { }

	// RVA: 0x1808190
	public void set_scrollDecelerationRate(float value) { }

	// RVA: 0x18081A4
	public float get_elasticity() { }

	// RVA: 0x18081AC
	public void set_elasticity(float value) { }

	// RVA: 0x18081C0
	public TouchScrollBehavior get_touchScrollBehavior() { }

	// RVA: 0x18081C8
	public void set_touchScrollBehavior(TouchScrollBehavior value) { }

	// RVA: 0x1808380
	public NestedInteractionKind get_nestedInteractionKind() { }

	// RVA: 0x1808388
	public void set_nestedInteractionKind(NestedInteractionKind value) { }

	// RVA: 0x1808390
	public void set_elasticAnimationIntervalMs(Int64 value) { }

	// RVA: 0x1808558
	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) { }

	// RVA: 0x18085A0
	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) { }

	// RVA: 0x1807BE0
	private void UpdateHorizontalSliderPageSize() { }

	// RVA: 0x1807E4C
	private void UpdateVerticalSliderPageSize() { }

	// RVA: 0x18078B0
	internal void UpdateContentViewTransform() { }

	// RVA: 0x18085E8
	public void ScrollTo(VisualElement child) { }

	// RVA: 0x1808AFC
	private float GetXDeltaOffset(VisualElement child) { }

	// RVA: 0x18088BC
	private float GetYDeltaOffset(VisualElement child) { }

	// RVA: 0x1808D3C
	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) { }

	// RVA: 0x1808D8C
	public VisualElement get_contentViewport() { }

	// RVA: 0x1808D94
	public Scroller get_horizontalScroller() { }

	// RVA: 0x1808D9C
	public Scroller get_verticalScroller() { }

	// RVA: 0x1808DA4
	public override VisualElement get_contentContainer() { }

	// RVA: 0x1808DAC
	public void .ctor() { }

	// RVA: 0x1808DB4
	public void .ctor(ScrollViewMode scrollViewMode) { }

	// RVA: 0x1809E08
	public ScrollViewMode get_mode() { }

	// RVA: 0x1809E10
	public void set_mode(ScrollViewMode value) { }

	// RVA: 0x1809A98
	private void SetScrollViewMode(ScrollViewMode mode) { }

	// RVA: 0x1809E24
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x180A490
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x180AA70
	private void OnPointerCapture(PointerCaptureEvent evt) { }

	// RVA: 0x180ABF4
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x180ADC0
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x180AFB8
	private void ScheduleResetLayoutPass() { }

	// RVA: 0x180AA64
	private void ResetLayoutPass() { }

	// RVA: 0x180B1E0
	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) { }

	// RVA: 0x180B2F0
	private void ComputeInitialSpringBackVelocity() { }

	// RVA: 0x180B558
	private void SpringBack() { }

	// RVA: 0x180B704
	internal void ApplyScrollInertia() { }

	// RVA: 0x180BA78
	private void PostPointerUpAnimation() { }

	// RVA: 0x180BC10
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x180C1B8
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x180CA90
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x180CAFC
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x180BEB4
	internal void InitTouchScrolling(Vector2 position) { }

	// RVA: 0x180C430
	internal TouchScrollingResult ComputeTouchScrolling(Vector2 position) { }

	// RVA: 0x180CBB4
	private bool ApplyTouchScrolling(Vector2 newScrollOffset) { }

	// RVA: 0x180ACDC
	private bool ReleaseScrolling(int pointerId, IEventHandler target) { }

	// RVA: 0x180CE60
	private void ExecuteElasticSpringAnimation() { }

	// RVA: 0x180D108
	private void AdjustScrollers() { }

	// RVA: 0x1806CC8
	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) { }

	// RVA: 0x180D2BC
	private void OnScrollersGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x180D48C
	private void OnScrollWheel(WheelEvent evt) { }

	// RVA: 0x180DBE4
	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	// RVA: 0x180DBE8
	private void OnRootPointerUp(PointerUpEvent evt) { }

	// RVA: 0x180A388
	private void ReadSingleLineHeight() { }

	// RVA: 0x180D968
	private void UpdateElasticBehaviour() { }

	// RVA: 0x180DBF0
	private static void .cctor() { }

	// RVA: 0x180DFD0
	private void <.ctor>b__126_0(float value) { }

	// RVA: 0x180E050
	private void <.ctor>b__126_1(float value) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x180F590
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

	// RVA: 0x180F5E4
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x180F874
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

	// RVA: 0x180EBBC
	public void .ctor() { }

	// RVA: 0x18064DC
	public void .ctor(float start, float end, SliderDirection direction, float pageSize) { }

	// RVA: 0x180EBD4
	public void .ctor(string label, float start, float end, SliderDirection direction, float pageSize) { }

	// RVA: 0x180ED64
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x180EEA8
	internal override float SliderLerpUnclamped(float a, float b, float interpolant) { }

	// RVA: 0x1806510
	internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	// RVA: 0x180F1E4
	internal override float ParseStringToValue(string previousValue, string newValue) { }

	// RVA: 0x180F274
	internal override void ComputeValueFromKey(SliderKey sliderKey, bool isShift) { }

	// RVA: 0x180F490
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1810ADC
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

	// RVA: 0x1810B30
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1810DC4
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

	// RVA: 0x180FB9C
	public void .ctor() { }

	// RVA: 0x180FBB4
	public void .ctor(string label, int start, int end, SliderDirection direction, float pageSize) { }

	// RVA: 0x180FD44
	public override float get_pageSize() { }

	// RVA: 0x180FD98
	public override void set_pageSize(float value) { }

	// RVA: 0x180FEE0
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x18100C4
	internal override int SliderLerpUnclamped(int a, int b, float interpolant) { }

	// RVA: 0x18101F0
	internal override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) { }

	// RVA: 0x181020C
	internal override int ParseStringToValue(string previousValue, string newValue) { }

	// RVA: 0x1810298
	internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	// RVA: 0x18106C8
	internal override void ComputeValueFromKey(SliderKey sliderKey, bool isShift) { }

	// RVA: 0x18109DC
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

	// RVA: 0x30D3CF0
	private UnityEngine.UIElements.TextValueField<TValueType> get_textValueFieldParent() { }

	// RVA: 0x30D488C
	protected void .ctor() { }

	// RVA: 0x318DB98
	internal override bool AcceptCharacter(Char c) { }

	// RVA: -1
	protected abstract string get_allowedCharacters() { }

	// RVA: 0x30D3CF0
	public string get_formatString() { }

	// RVA: 0x30D4CD4
	public void set_formatString(string value) { }

	// RVA: -1
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	// RVA: 0x30D488C
	public void StartDragging() { }

	// RVA: 0x30D488C
	public void StopDragging() { }

	// RVA: -1
	protected abstract string ValueToString(TValueType value) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D3CF0
	private TextValueInput get_textValueInput() { }

	// RVA: 0x30D3CF0
	public string get_formatString() { }

	// RVA: 0x30D4DB0
	protected void .ctor(string label, int maxLength, TextValueInput textValueInput) { }

	// RVA: -1
	public abstract void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	// RVA: 0x30D488C
	public void StartDragging() { }

	// RVA: 0x30D488C
	public void StopDragging() { }

	// RVA: 0x318DB98
	public override TValueType get_value() { }

	// RVA: 0x318DB98
	public override void set_value(TValueType value) { }

	// RVA: 0x30D488C
	internal override void UpdateValueFromText() { }

	// RVA: 0x30D488C
	internal override void UpdateTextFromValue() { }

	// RVA: 0x30D4918
	private void OnIsReadOnlyChanged(bool newValue) { }

	// RVA: 0x30D3858
	internal virtual bool CanTryParse(string textString) { }

	// RVA: 0x30D488C
	protected void AddLabelDragger() { }

	// RVA: 0x30D4918
	private void EnableLabelDragger(bool enable) { }

	// RVA: 0x318DB98
	public override void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x30D4CD4
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x30D488C
	internal override void OnViewDataReady() { }

	// RVA: 0x30D488C
	internal override void RegisterEditingCallbacks() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x18116B8
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x88

	// Methods

	// RVA: 0x181170C
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1811820
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

	// RVA: 0x18110EC
	public void .ctor() { }

	// RVA: 0x18110F4
	public void .ctor(string label) { }

	// RVA: 0x1811220
	protected override void InitLabel() { }

	// RVA: 0x18112A8
	protected override void UpdateMixedValueContent() { }

	// RVA: 0x18114A8
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1811B58
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x1811BAC
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

	// RVA: 0x18118D8
	public System.Func<UnityEngine.UIElements.VisualElement> get_makeItem() { }

	// RVA: 0x18118E0
	public void set_makeItem(System.Func<UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x1811938
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem() { }

	// RVA: 0x1811940
	public void set_bindItem(System.Action<UnityEngine.UIElements.VisualElement,System.Int32> value) { }

	// RVA: 0x1811998
	public System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem() { }

	// RVA: 0x18119A0
	public System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem() { }

	// RVA: 0x18119A8
	internal override bool HasValidDataAndBindings() { }

	// RVA: 0x18119EC
	protected override CollectionViewController CreateViewController() { }

	// RVA: 0x1811A60
	public void .ctor() { }

	// RVA: 0x1811A6C
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

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerable<System.Int32> get_rootItemIds() { }

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }

	// RVA: 0x318DB98
	public UnityEngine.UIElements.TreeViewItemData<T> GetDataForId(int id) { }

	// RVA: -1
	public int GetParentId(int id) { }

	// RVA: -1
	public void Move(int id, int newParentId, int childIndex) { }

	// RVA: -1
	public bool HasAncestor(int childId, int ancestorId) { }

	// RVA: 0x318DB98
	private void AddItemToParent(UnityEngine.UIElements.TreeViewItemData<T> item, int parentId, int childIndex) { }

	// RVA: 0x30D4A74
	private void RemoveFromParent(int id, int parentId) { }

	// RVA: 0x318DB98
	private void UpdateParentTree(UnityEngine.UIElements.TreeViewItemData<T> current) { }

	// RVA: 0x30D4CD4
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

	// RVA: 0x1811BB4
	public int get_id() { }

	// RVA: 0x1811BBC
	public int get_parentId() { }

	// RVA: 0x1811BC4
	public System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds() { }

	// RVA: 0x1811BCC
	public bool get_hasChildren() { }

	// RVA: 0x1811C28
	public void .ctor(int id, int parentId, System.Collections.Generic.IEnumerable<System.Int32> childrenIds) { }

}

// Namespace: UnityEngine.UIElements
internal struct TreeViewItemWrapper
{
	// Fields
	public readonly TreeItem item; // 0x10
	public readonly int depth; // 0x20

	// Methods

	// RVA: 0x1811C38
	public int get_id() { }

	// RVA: 0x1811C40
	public System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds() { }

	// RVA: 0x1811C48
	public bool get_hasChildren() { }

	// RVA: 0x1811CA4
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

	// RVA: 0x30D39B8
	public int get_id() { }

	// RVA: 0x318DB98
	public T get_data() { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> get_children() { }

	// RVA: 0x30D3738
	public bool get_hasChildren() { }

	// RVA: 0x318DB98
	internal void InsertChild(UnityEngine.UIElements.TreeViewItemData<T> child, int index) { }

	// RVA: 0x30D4A04
	internal void RemoveChild(int childId) { }

	// RVA: -1
	internal int GetChildIndex(int itemId) { }

	// RVA: 0x318DB98
	internal void ReplaceChild(UnityEngine.UIElements.TreeViewItemData<T> newChild) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x18156C4
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

	// RVA: 0x1815718
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1815870
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

	// RVA: 0x1811CD8
	public VisualElement get_fixedPane() { }

	// RVA: 0x1811CE0
	public VisualElement get_flexedPane() { }

	// RVA: 0x1811CE8
	internal VisualElement get_dragLine() { }

	// RVA: 0x1811CF0
	public int get_fixedPaneIndex() { }

	// RVA: 0x1811CF8
	public TwoPaneSplitViewOrientation get_orientation() { }

	// RVA: 0x1811D00
	internal float get_fixedPaneDimension() { }

	// RVA: 0x1811D3C
	internal void set_fixedPaneDimension(float value) { }

	// RVA: 0x1811D58
	public void .ctor() { }

	// RVA: 0x1811FC4
	public void CollapseChild(int index) { }

	// RVA: 0x1812658
	internal void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) { }

	// RVA: 0x1813F7C
	private void OnPostDisplaySetup(GeometryChangedEvent evt) { }

	// RVA: 0x18140AC
	private void ReplacePanesBasedOnAnchor() { }

	// RVA: 0x1814228
	private void OnAnchorPostDisplaySetup(GeometryChangedEvent evt) { }

	// RVA: 0x181432C
	private void IdentifyLeftAndRightPane() { }

	// RVA: 0x18129CC
	private void PostDisplaySetup() { }

	// RVA: 0x181448C
	private void OnSizeChange(GeometryChangedEvent evt) { }

	// RVA: 0x1814498
	private void UpdateLayout(bool updateFixedPane, bool updateDragLine) { }

	// RVA: 0x1815444
	public override VisualElement get_contentContainer() { }

	// RVA: 0x181544C
	internal override void OnViewDataReady() { }

	// RVA: 0x1815174
	private void SetDragLineOffset(float offset) { }

	// RVA: 0x18152DC
	private void SetFixedPaneDimension(float dimension) { }

	// RVA: 0x1815494
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

	// RVA: 0x1815A50
	private TwoPaneSplitViewOrientation get_orientation() { }

	// RVA: 0x1815A70
	private VisualElement get_fixedPane() { }

	// RVA: 0x1815A90
	private VisualElement get_flexedPane() { }

	// RVA: 0x1815AB0
	private float get_fixedPaneMinDimension() { }

	// RVA: 0x1815BF4
	private float get_fixedPaneMargins() { }

	// RVA: 0x1815E58
	private float get_flexedPaneMinDimension() { }

	// RVA: 0x1815F9C
	private float get_flexedPaneMargin() { }

	// RVA: 0x18143E8
	public void .ctor(TwoPaneSplitView splitView, int dir) { }

	// RVA: 0x1816200
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x18163C0
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x1816580
	public void ApplyDelta(float delta) { }

	// RVA: 0x181717C
	protected void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x1817258
	protected void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x18176C0
	protected void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x1817628
	protected void InterruptPointerMove(PointerMoveEvent e) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1817F04
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x1817F58
	public void .ctor() { }

}

// Namespace: 
private class UnsignedIntegerInput
{
	// Methods

	// RVA: 0x1817FAC
	private UnsignedIntegerField get_parentUnsignedIntegerField() { }

	// RVA: 0x1817C38
	internal void .ctor() { }

	// RVA: 0x1818030
	protected override string get_allowedCharacters() { }

	// RVA: 0x18180AC
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt32 startValue) { }

	// RVA: 0x18183D0
	protected override string ValueToString(UInt32 v) { }

	// RVA: 0x1818428
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

	// RVA: 0x181777C
	private UnsignedIntegerInput get_integerInput() { }

	// RVA: 0x1817834
	protected override string ValueToString(UInt32 v) { }

	// RVA: 0x18178F4
	protected override UInt32 StringToValue(string str) { }

	// RVA: 0x1817A30
	public void .ctor() { }

	// RVA: 0x1817A3C
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x1817CD4
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x1817D00
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt32 startValue) { }

	// RVA: 0x1817E04
	private static void .cctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1818C60
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x1818CB4
	public void .ctor() { }

}

// Namespace: 
private class UnsignedLongInput
{
	// Methods

	// RVA: 0x1818D08
	private UnsignedLongField get_parentUnsignedLongField() { }

	// RVA: 0x1818994
	internal void .ctor() { }

	// RVA: 0x1818D8C
	protected override string get_allowedCharacters() { }

	// RVA: 0x1818E08
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt64 startValue) { }

	// RVA: 0x1819138
	private UInt64 ClampToMinMaxULongValue(Int64 niceDelta, UInt64 value) { }

	// RVA: 0x18191B8
	protected override string ValueToString(UInt64 v) { }

	// RVA: 0x1819210
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

	// RVA: 0x18184D8
	private UnsignedLongInput get_unsignedLongInput() { }

	// RVA: 0x1818590
	protected override string ValueToString(UInt64 v) { }

	// RVA: 0x1818650
	protected override UInt64 StringToValue(string str) { }

	// RVA: 0x181878C
	public void .ctor() { }

	// RVA: 0x1818798
	public void .ctor(string label, int maxLength) { }

	// RVA: 0x1818A30
	internal override bool CanTryParse(string textString) { }

	// RVA: 0x1818A5C
	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt64 startValue) { }

	// RVA: 0x1818B60
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

	// RVA: 0x18192C0
	private void AdjustSlot(UInt32 index, bool increment) { }

	// RVA: 0x18192F0
	private UInt32 Hash1(UInt32 hash) { }

	// RVA: 0x18192F8
	private UInt32 Hash2(UInt32 hash) { }

	// RVA: 0x1819300
	private bool IsSlotEmpty(UInt32 index) { }

	// RVA: 0x1819310
	public void InsertHash(UInt32 hash) { }

	// RVA: 0x181935C
	public void RemoveHash(UInt32 hash) { }

	// RVA: 0x181938C
	public bool ContainsHash(UInt32 hash) { }

}

// Namespace: UnityEngine.UIElements
internal class AncestorFilter
{
	// Fields
	private CountingBloomFilter m_CountingBloomFilter; // 0x10
	private System.Collections.Generic.Stack<System.Int32> m_HashStack; // 0x4010

	// Methods

	// RVA: 0x18193B4
	public void .ctor() { }

	// RVA: 0x1819448
	private void AddHash(int hash) { }

	// RVA: 0x1819518
	public bool IsCandidate(StyleComplexSelector complexSel) { }

	// RVA: 0x18195D0
	public void PushElement(VisualElement element) { }

	// RVA: 0x1819A00
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

	// RVA: 0x1819B10
	public Texture2D get_texture() { }

	// RVA: 0x1819B18
	public void set_texture(Texture2D value) { }

	// RVA: 0x1819B20
	public Vector2 get_hotspot() { }

	// RVA: 0x1819B28
	public void set_hotspot(Vector2 value) { }

	// RVA: 0x1819B30
	internal int get_defaultCursorId() { }

	// RVA: 0x1819B38
	internal void set_defaultCursorId(int value) { }

	// RVA: 0x1819B40
	public override bool Equals(object obj) { }

	// RVA: 0x1819C78
	public bool Equals(Cursor other) { }

	// RVA: 0x1819D28
	public override int GetHashCode() { }

	// RVA: 0x1819E04
	public static bool op_Equality(Cursor style1, Cursor style2) { }

	// RVA: 0x1819ECC
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

	// RVA: 0x1819F60
	public bool get_isCursorOverriden() { }

	// RVA: 0x1819F68
	private void set_isCursorOverriden(bool value) { }

	// RVA: 0x1819F70
	public void SetCursor(Cursor cursor) { }

	// RVA: 0x181A0D4
	public void ResetCursor() { }

	// RVA: 0x181A140
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

	// RVA: 0x181D45C
	public void .ctor(DefaultEventSystem es) { }

	// RVA: 0x181D4E0
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

	// RVA: 0x181D524
	public bool GetButtonDown(string button) { }

	// RVA: 0x181D530
	public float GetAxisRaw(string axis) { }

	// RVA: 0x181D53C
	public void ClearLastPenContactEvent() { }

	// RVA: 0x181D544
	public PenData GetLastPenContactEvent() { }

	// RVA: 0x181D588
	public int get_touchCount() { }

	// RVA: 0x181D590
	public Touch GetTouch(int index) { }

	// RVA: 0x181D5E4
	public bool get_mousePresent() { }

	// RVA: 0x181D5EC
	public bool GetMouseButtonDown(int button) { }

	// RVA: 0x181D5F8
	public bool GetMouseButtonUp(int button) { }

	// RVA: 0x181D604
	public Vector3 get_mousePosition() { }

	// RVA: 0x181D60C
	public int get_mouseButtonCount() { }

	// RVA: 0x181D614
	public bool get_anyKey() { }

	// RVA: 0x181D61C
	public float get_unscaledTime() { }

	// RVA: 0x181D624
	public float get_doubleClickTime() { }

	// RVA: 0x181D650
	public void .ctor() { }

}

// Namespace: 
private class NoInput
{
	// Methods

	// RVA: 0x181D658
	public bool GetButtonDown(string button) { }

	// RVA: 0x181D660
	public float GetAxisRaw(string axis) { }

	// RVA: 0x181D668
	public int get_touchCount() { }

	// RVA: 0x181D670
	public Touch GetTouch(int index) { }

	// RVA: 0x181D684
	public void ClearLastPenContactEvent() { }

	// RVA: 0x181D688
	public PenData GetLastPenContactEvent() { }

	// RVA: 0x181D698
	public bool get_mousePresent() { }

	// RVA: 0x181D6A0
	public bool GetMouseButtonDown(int button) { }

	// RVA: 0x181D6A8
	public bool GetMouseButtonUp(int button) { }

	// RVA: 0x181D6B0
	public Vector3 get_mousePosition() { }

	// RVA: 0x181D6C0
	public int get_mouseButtonCount() { }

	// RVA: 0x181D6C8
	public bool get_anyKey() { }

	// RVA: 0x181D6D0
	public float get_unscaledTime() { }

	// RVA: 0x181D6D8
	public float get_doubleClickTime() { }

	// RVA: 0x181D6E4
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

	// RVA: 0x181D6EC
	private static void .cctor() { }

	// RVA: 0x181D758
	public void .ctor() { }

	// RVA: 0x181D760
	internal EventBase <SendIMGUIEvents>b__30_0(DefaultEventSystem self) { }

	// RVA: 0x181D7DC
	internal EventBase <SendIMGUIEvents>b__30_1(Vector3 panelPosition, Vector3 _, System.ValueTuple<UnityEngine.EventModifiers,UnityEngine.Vector2> t) { }

	// RVA: 0x181D96C
	internal EventBase <SendIMGUIEvents>b__30_2(Vector3 panelPosition, Vector3 panelDelta, Event evt) { }

	// RVA: 0x181DA18
	internal EventBase <ProcessMouseEvents>b__36_0(Vector3 panelPosition, Vector3 panelDelta, DefaultEventSystem self) { }

	// RVA: 0x181DAB8
	internal EventBase <ProcessMouseEvents>b__36_1(Vector3 panelPosition, Vector3 panelDelta, System.ValueTuple<System.Int32,System.Int32,UnityEngine.EventModifiers> t) { }

	// RVA: 0x181DACC
	internal EventBase <ProcessMouseEvents>b__36_2(Vector3 panelPosition, Vector3 panelDelta, System.ValueTuple<System.Int32,System.Int32,UnityEngine.EventModifiers> t) { }

	// RVA: 0x181DAE0
	internal EventBase <SendInputEvents>b__37_0(DefaultEventSystem self) { }

	// RVA: 0x181DB84
	internal EventBase <SendInputEvents>b__37_1(DefaultEventSystem self) { }

	// RVA: 0x181DC70
	internal EventBase <SendInputEvents>b__37_2(DefaultEventSystem self) { }

	// RVA: 0x181DD5C
	internal EventBase <ProcessTouchEvents>b__45_0(Vector3 panelPosition, Vector3 panelDelta, Touch _touch) { }

	// RVA: 0x181DE48
	internal EventBase <ProcessPenEvents>b__46_0(Vector3 panelPosition, Vector3 panelDelta, PenData _pen) { }

	// RVA: 0x181DF04
	internal EventBase <ProcessTabEvent>b__53_0(System.ValueTuple<UnityEngine.UIElements.NavigationMoveEvent.Direction,UnityEngine.EventModifiers,UnityEngine.UIElements.DefaultEventSystem.IInput> t) { }

	// RVA: 0x181DFF8
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

	// RVA: 0x181A148
	private bool get_isAppFocused() { }

	// RVA: 0x181A1B8
	internal IInput get_input() { }

	// RVA: 0x181A218
	private IInput GetDefaultInput() { }

	// RVA: 0x181A3D0
	private bool ShouldIgnoreEventsOnAppNotFocused() { }

	// RVA: 0x181A3F4
	public BaseRuntimePanel get_focusedPanel() { }

	// RVA: 0x181A3FC
	public void set_focusedPanel(BaseRuntimePanel value) { }

	// RVA: 0x181A45C
	public void Update(UpdateMode updateMode) { }

	// RVA: 0x181B938
	internal FocusBasedEventSequenceContext FocusBasedEventSequence() { }

	// RVA: 0x181B968
	private void SendIMGUIEvents() { }

	// RVA: 0x181ADE4
	private void ProcessMouseEvents() { }

	// RVA: 0x181C12C
	private void SendInputEvents() { }

	// RVA: 0x181CB84
	internal void OnFocusEvent(RuntimePanel panel, FocusEvent evt) { }

	// RVA: 0x318DB98
	internal void SendFocusBasedEvent(System.Func<TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg) { }

	// RVA: 0x318DB98
	private void SendPositionBasedEvent(Vector3 mousePosition, Vector3 delta, int pointerId, System.Nullable<System.Int32> targetDisplay, System.Func<UnityEngine.Vector3,UnityEngine.Vector3,TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg, bool deselectIfNoTarget) { }

	// RVA: 0x181CBE4
	private void UpdateFocusedPanel(BaseRuntimePanel runtimePanel) { }

	// RVA: 0x181CCA4
	private static EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers) { }

	// RVA: 0x181CE2C
	private static EventBase MakePenEvent(PenData pen, EventModifiers modifiers) { }

	// RVA: 0x181A8F4
	private bool ProcessTouchEvents() { }

	// RVA: 0x181A5E4
	private bool ProcessPenEvents() { }

	// RVA: 0x181CEF8
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x181C704
	private bool ShouldSendMoveFromInput() { }

	// RVA: 0x181C538
	private void ProcessTabEvent(Event e, EventModifiers modifiers) { }

	// RVA: 0x181D21C
	public void .ctor() { }

	// RVA: 0x181D388
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DisposeHelper
{
	// Methods

	// RVA: 0x181E000
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

	// RVA: 0x181E0E4
	public System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds() { }

	// RVA: 0x181E0EC
	protected void .ctor(BaseVerticalCollectionView view) { }

	// RVA: 0x181E19C
	public virtual bool get_enableReordering() { }

	// RVA: 0x181E1A4
	public virtual void set_enableReordering(bool value) { }

	// RVA: 0x181E1AC
	public virtual bool CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIds) { }

	// RVA: 0x181E1BC
	public virtual StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, bool skipText) { }

	// RVA: 0x181EAC0
	protected virtual int CompareId(int id1, int id2) { }

	// RVA: -1
	public abstract DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: -1
	public abstract void OnDrop(IListDragAndDropArgs args) { }

	// RVA: 0x181EAEC
	public virtual void DragCleanup() { }

	// RVA: 0x181EAF0
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

	// RVA: 0x181EAF4
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

	// RVA: 0x181EDB0
	public override object get_source() { }

	// RVA: 0x181EE0C
	public override object GetGenericData(string key) { }

	// RVA: 0x181EE74
	public void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	// RVA: 0x181F558
	public void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x181F6FC
	public void AcceptDrag() { }

	// RVA: 0x181F700
	public void SetVisualMode(DragVisualMode mode) { }

	// RVA: 0x181F708
	public void DragCleanup() { }

	// RVA: 0x181F76C
	public DragAndDropData get_data() { }

	// RVA: 0x181ED38
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

	// RVA: 0x181F778
	protected virtual bool get_supportsDragEvents() { }

	// RVA: 0x181F780
	private bool get_useDragEvents() { }

	// RVA: 0x181F7C4
	protected IDragAndDrop get_dragAndDrop() { }

	// RVA: 0x181F7E8
	internal virtual bool get_isEditorContext() { }

	// RVA: 0x181F944
	internal void .ctor(VisualElement target) { }

	// RVA: 0x181FDA8
	private void RegisterCallbacksFromTarget(AttachToPanelEvent evt) { }

	// RVA: 0x181FA98
	private void RegisterCallbacksFromTarget() { }

	// RVA: 0x181FDAC
	private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt) { }

	// RVA: 0x181FDB4
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

	// RVA: 0x18201B4
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x18202B4
	internal void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x182056C
	private void OnPointerLeaveEvent(PointerLeaveEvent evt) { }

	// RVA: 0x182057C
	private void OnPointerCancelEvent(PointerCancelEvent evt) { }

	// RVA: 0x18206C4
	private void OnPointerCapturedOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x18207E0
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x182046C
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

	// RVA: 0x181F770
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

	// RVA: 0x1820ACC
	public void set_target(object value) { }

	// RVA: 0x1820AD4
	public int get_insertAtIndex() { }

	// RVA: 0x1820ADC
	public void set_insertAtIndex(int value) { }

	// RVA: 0x1820AE4
	public int get_parentId() { }

	// RVA: 0x1820AEC
	public void set_parentId(int value) { }

	// RVA: 0x1820AF4
	public int get_childIndex() { }

	// RVA: 0x1820AFC
	public void set_childIndex(int value) { }

	// RVA: 0x1820B04
	public DragAndDropPosition get_dragAndDropPosition() { }

	// RVA: 0x1820B0C
	public void set_dragAndDropPosition(DragAndDropPosition value) { }

	// RVA: 0x1820B14
	public DragAndDropData get_dragAndDropData() { }

	// RVA: 0x1820B1C
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

	// RVA: 0x30D488C
	public virtual void DragCleanup() { }

	// RVA: -1
	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x1820B24
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

	// RVA: 0x1820B68
	internal void .ctor(VisualElement draggedElement, System.Collections.Generic.IEnumerable<System.Int32> selectedIds, StartDragArgs startDragArgs) { }

}

// Namespace: UnityEngine.UIElements
internal struct HandleDragAndDropArgs
{
	// Fields
	private readonly DragAndDropArgs m_DragAndDropArgs; // 0x10
	private readonly Vector2 <position>k__BackingField; // 0x30

	// Methods

	// RVA: 0x1820BC0
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

	// RVA: 0x181EA78
	public void .ctor(string title, DragVisualMode visualMode) { }

	// RVA: 0x1820BD4
	public string get_title() { }

	// RVA: 0x1820BDC
	public DragVisualMode get_visualMode() { }

	// RVA: 0x1820BE4
	internal Hashtable get_genericData() { }

	// RVA: 0x1820BEC
	private void set_genericData(Hashtable value) { }

	// RVA: 0x1820BF4
	internal System.Collections.Generic.IEnumerable<UnityEngine.Object> get_unityObjectReferences() { }

	// RVA: 0x1820BFC
	private void set_unityObjectReferences(System.Collections.Generic.IEnumerable<UnityEngine.Object> value) { }

	// RVA: 0x1820C04
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

	// RVA: 0x18235FC
	public bool Equals(DragPosition other) { }

	// RVA: 0x1825AC4
	public override bool Equals(object obj) { }

	// RVA: 0x1825BAC
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

	// RVA: 0x1820CA4
	protected BaseVerticalCollectionView get_targetView() { }

	// RVA: 0x1820D2C
	protected ScrollView get_targetScrollView() { }

	// RVA: 0x1820DAC
	public ICollectionDragAndDropController get_dragAndDropController() { }

	// RVA: 0x1820DB4
	public void set_dragAndDropController(ICollectionDragAndDropController value) { }

	// RVA: 0x1820DBC
	public void .ctor(BaseVerticalCollectionView listView) { }

	// RVA: 0x1820DC8
	protected override bool CanStartDrag(Vector3 pointerPosition) { }

	// RVA: 0x18216A4
	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: 0x1821C34
	protected internal override void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x1821E38
	private DragVisualMode GetVisualMode(Vector3 pointerPosition, DragPosition dragPosition) { }

	// RVA: 0x182315C
	protected internal override void OnDrop(Vector3 pointerPosition) { }

	// RVA: 0x182202C
	internal void HandleDragAndScroll(Vector2 pointerPosition) { }

	// RVA: 0x18223E4
	private void HandleAutoExpansion(Vector2 pointerPosition) { }

	// RVA: 0x18224D4
	private void ApplyDragAndDropUI(DragPosition dragPosition) { }

	// RVA: 0x182412C
	protected virtual bool TryGetDragPosition(Vector2 pointerPosition, DragPosition dragPosition) { }

	// RVA: 0x1824718
	private void HandleTreePosition(Vector2 pointerPosition, DragPosition dragPosition) { }

	// RVA: 0x1824898
	private void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(DragPosition dragPosition, Vector2 pointerPosition) { }

	// RVA: 0x1824E0C
	private void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, int previousItemId, int nextItemId) { }

	// RVA: 0x1822FB0
	protected DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition) { }

	// RVA: 0x1825198
	private float GetHoverBarTopPosition(ReusableCollectionItem item) { }

	// RVA: 0x1824104
	private void PlaceHoverBarAtElement(ReusableCollectionItem item) { }

	// RVA: 0x1823680
	private void PlaceHoverBarAt(float top, float indentationPadding, float siblingBottom) { }

	// RVA: 0x1825288
	protected override void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x18212D0
	protected ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition) { }

	// RVA: 0x1825984
	private void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(GeometryChangedEvent e) { }

}

// Namespace: UnityEngine.UIElements
internal static class ListViewDraggerExtension
{
	// Methods

	// RVA: 0x181E748
	public static ReusableCollectionItem GetRecycledItemFromId(BaseVerticalCollectionView listView, int id) { }

	// RVA: 0x1823DD4
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

	// RVA: 0x1825C14
	public bool get_isDragging() { }

	// RVA: 0x1825C1C
	private void set_isDragging(bool value) { }

	// RVA: 0x1825C24
	public ReusableCollectionItem get_draggedItem() { }

	// RVA: 0x1825C2C
	protected override bool get_supportsDragEvents() { }

	// RVA: 0x1825C34
	public void .ctor(BaseVerticalCollectionView listView) { }

	// RVA: 0x1825C40
	protected internal override StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: 0x1826A88
	protected internal override void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x1826604
	private void Animate(ReusableCollectionItem element, float paddingTop) { }

	// RVA: 0x1827580
	protected internal override void OnDrop(Vector3 pointerPosition) { }

	// RVA: 0x1827ABC
	protected override void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x1827AC0
	protected override bool TryGetDragPosition(Vector2 pointerPosition, DragPosition dragPosition) { }

}

// Namespace: UnityEngine.UIElements
internal class ListViewReorderableDragAndDropController
{
	// Fields
	protected readonly BaseListView m_ListView; // 0x28

	// Methods

	// RVA: 0x1827B04
	public void .ctor(BaseListView view) { }

	// RVA: 0x1827B34
	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: 0x1827CB0
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

	// RVA: 0x1828048
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

	// RVA: 0x1827F58
	public void .ctor(BaseTreeView view) { }

	// RVA: 0x1828058
	protected override int CompareId(int id1, int id2) { }

	// RVA: 0x18285B0
	public override StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, bool skipText) { }

	// RVA: 0x182865C
	public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: 0x1828768
	public override void OnDrop(IListDragAndDropArgs args) { }

	// RVA: 0x1828F0C
	public override void DragCleanup() { }

	// RVA: 0x1829074
	private void RestoreExpanded(System.Collections.Generic.List<System.Int32> ids) { }

	// RVA: 0x18293C4
	public override void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	// RVA: 0x1829500
	private void DelayExpandDropItem() { }

	// RVA: 0x1829768
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

	// RVA: 0x182996C
	public void .ctor(EventBase e) { }

}

// Namespace: UnityEngine.UIElements
public abstract class DropdownMenuItem
{
	// Methods

	// RVA: 0x1829C94
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DropdownMenuSeparator
{
	// Fields
	private readonly string <subMenuPath>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1829C9C
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

	// RVA: 0x1829CD0
	private void set_status(Status value) { }

	// RVA: 0x1829CD8
	private void set_eventInfo(DropdownMenuEventInfo value) { }

	// RVA: 0x1829CE0
	private void set_userData(object value) { }

	// RVA: 0x1829CE8
	public static Status AlwaysEnabled(DropdownMenuAction a) { }

	// RVA: 0x1829CF0
	public static Status AlwaysDisabled(DropdownMenuAction a) { }

	// RVA: 0x1829CF8
	public void .ctor(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData) { }

	// RVA: 0x1829D78
	public void UpdateActionStatus(DropdownMenuEventInfo eventInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Status status; // 0x10

	// Methods

	// RVA: 0x182A014
	public void .ctor() { }

	// RVA: 0x182A690
	internal Status <AppendAction>b__0(DropdownMenuAction e) { }

}

// Namespace: UnityEngine.UIElements
public class DropdownMenu
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> m_MenuItems; // 0x10
	private DropdownMenuEventInfo m_DropdownMenuEventInfo; // 0x18

	// Methods

	// RVA: 0x1829DEC
	public System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> MenuItems() { }

	// RVA: 0x1829DF4
	public void AppendAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData) { }

	// RVA: 0x1829EDC
	public void AppendAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, Status status) { }

	// RVA: 0x182A01C
	public void AppendSeparator(string subMenuPath) { }

	// RVA: 0x182A158
	public void InsertSeparator(string subMenuPath, int atIndex) { }

	// RVA: 0x182A2A4
	public void PrepareForDisplay(EventBase e) { }

	// RVA: 0x182A604
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class DropdownUtility
{
	// Fields
	internal static System.Func<UnityEngine.UIElements.IGenericMenu> MakeDropdownFunc; // 0x0

	// Methods

	// RVA: 0x182A698
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

	// RVA: 0x182A748
	public void .ctor(EventDispatcher d) { }

	// RVA: 0x182A7E8
	public void Dispose() { }

	// RVA: 0x182A9B4
	public bool Equals(EventDispatcherGate other) { }

	// RVA: 0x182A9C0
	public override bool Equals(object obj) { }

	// RVA: 0x182AA4C
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

	// RVA: 0x182CEE0
	private static void .cctor() { }

	// RVA: 0x182CF4C
	public void .ctor() { }

	// RVA: 0x182CF54
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

	// RVA: 0x182AA64
	internal PointerDispatchState get_pointerState() { }

	// RVA: 0x182AA6C
	internal static EventDispatcher CreateForRuntime(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies) { }

	// RVA: 0x182AAD0
	private void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies) { }

	// RVA: 0x182ACDC
	private bool get_dispatchImmediately() { }

	// RVA: 0x182ACFC
	private void set_processingEvents(bool value) { }

	// RVA: 0x182AD04
	internal void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	// RVA: 0x182BC08
	private bool HandleRecursiveState(EventBase evt) { }

	// RVA: 0x182A7D4
	internal void CloseGate() { }

	// RVA: 0x182A804
	internal void OpenGate() { }

	// RVA: 0x182C098
	private void ProcessEventQueue() { }

	// RVA: 0x182AFE8
	private void ProcessEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x182C494
	private void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	// RVA: 0x182CA00
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

	// RVA: 0x30D4CD4
	private void set_relatedTarget(IEventHandler value) { }

	// RVA: 0x30D39B8
	public int get_pointerId() { }

	// RVA: 0x30D4A04
	private void set_pointerId(int value) { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x318DB98
	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerCaptureOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x182D10C
	private static void .cctor() { }

	// RVA: 0x182D178
	public void .ctor() { }

	// RVA: 0x182D180
	internal PointerCaptureOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class PointerCaptureOutEvent
{
	// Methods

	// RVA: 0x182CFC8
	private static void .cctor() { }

	// RVA: 0x182D0B8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerCaptureEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x182D350
	private static void .cctor() { }

	// RVA: 0x182D3BC
	public void .ctor() { }

	// RVA: 0x182D3C4
	internal PointerCaptureEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class PointerCaptureEvent
{
	// Methods

	// RVA: 0x182D20C
	private static void .cctor() { }

	// RVA: 0x182D2FC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class MouseCaptureEventBase<T0>
{
	// Methods

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseCaptureOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x182D594
	private static void .cctor() { }

	// RVA: 0x182D600
	public void .ctor() { }

	// RVA: 0x182D608
	internal MouseCaptureOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseCaptureOutEvent
{
	// Methods

	// RVA: 0x182D450
	private static void .cctor() { }

	// RVA: 0x182D540
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseCaptureEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x182D7D8
	private static void .cctor() { }

	// RVA: 0x182D844
	public void .ctor() { }

	// RVA: 0x182D84C
	internal MouseCaptureEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseCaptureEvent
{
	// Methods

	// RVA: 0x182D694
	private static void .cctor() { }

	// RVA: 0x182D784
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ChangeEvent.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3CF0
	internal UnityEngine.UIElements.ChangeEvent<T> <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ChangeEvent<T0>
{
	// Fields
	private T <previousValue>k__BackingField; // 0x0
	private T <newValue>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x318DB98
	public T get_previousValue() { }

	// RVA: 0x318DB98
	protected void set_previousValue(T value) { }

	// RVA: 0x318DB98
	public T get_newValue() { }

	// RVA: 0x318DB98
	protected void set_newValue(T value) { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x318DB98
	public static UnityEngine.UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class CommandEventDispatchingStrategy
{
	// Methods

	// RVA: 0x182D8D8
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x182D938
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x182CEC8
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

	// RVA: 0x30D3CF0
	public string get_commandName() { }

	// RVA: 0x30D4CD4
	protected void set_commandName(string value) { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x318DB98
	public static T GetPooled(Event systemEvent) { }

	// RVA: 0x318DB98
	public static T GetPooled(string commandName) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ValidateCommandEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x182E4E0
	private static void .cctor() { }

	// RVA: 0x182E54C
	public void .ctor() { }

	// RVA: 0x182E554
	internal ValidateCommandEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ValidateCommandEvent
{
	// Methods

	// RVA: 0x182E39C
	private static void .cctor() { }

	// RVA: 0x182E48C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ExecuteCommandEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x182E724
	private static void .cctor() { }

	// RVA: 0x182E790
	public void .ctor() { }

	// RVA: 0x182E798
	internal ExecuteCommandEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ExecuteCommandEvent
{
	// Methods

	// RVA: 0x182E5E0
	private static void .cctor() { }

	// RVA: 0x182E6D0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultDispatchingStrategy
{
	// Methods

	// RVA: 0x182E824
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x182E8A8
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x182CED8
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

	// RVA: 0x182EACC
	internal VisualElement GetTopElementUnderPointer(int pointerId, Vector2 pickPosition, bool isTemporary) { }

	// RVA: 0x182EB44
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x182EB78
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos) { }

	// RVA: 0x182ED38
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0x182EF24
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	// RVA: 0x182F1D4
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	// RVA: 0x182EF2C
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary) { }

	// RVA: 0x182F1DC
	internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType) { }

	// RVA: 0x183001C
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

	// RVA: 0x18301CC
	protected static Int64 RegisterEventType() { }

	// RVA: 0x1830220
	public virtual Int64 get_eventTypeId() { }

	// RVA: 0x1830228
	internal EventCategory get_eventCategory() { }

	// RVA: 0x1830230
	public Int64 get_timestamp() { }

	// RVA: 0x1830238
	private void set_timestamp(Int64 value) { }

	// RVA: 0x1830240
	internal UInt64 get_eventId() { }

	// RVA: 0x1830248
	private void set_eventId(UInt64 value) { }

	// RVA: 0x1830250
	private void set_triggerEventId(UInt64 value) { }

	// RVA: 0x1830258
	internal void SetTriggerEventId(UInt64 id) { }

	// RVA: 0x1830260
	internal EventPropagation get_propagation() { }

	// RVA: 0x1830268
	internal void set_propagation(EventPropagation value) { }

	// RVA: 0x1830270
	internal PropagationPaths get_path() { }

	// RVA: 0x1830278
	internal void set_path(PropagationPaths value) { }

	// RVA: 0x1830280
	private LifeCycleStatus get_lifeCycleStatus() { }

	// RVA: 0x1830288
	private void set_lifeCycleStatus(LifeCycleStatus value) { }

	// RVA: 0x1830290
	protected virtual void PreDispatch() { }

	// RVA: 0x1830294
	protected internal virtual void PreDispatch(IPanel panel) { }

	// RVA: 0x18302A0
	protected virtual void PostDispatch() { }

	// RVA: 0x18302A4
	protected internal virtual void PostDispatch(IPanel panel) { }

	// RVA: 0x18302F8
	public bool get_bubbles() { }

	// RVA: 0x1830304
	public bool get_tricklesDown() { }

	// RVA: 0x182C824
	internal bool get_bubblesOrTricklesDown() { }

	// RVA: 0x1830310
	internal bool get_skipDisabledElements() { }

	// RVA: 0x183031C
	internal void set_skipDisabledElements(bool value) { }

	// RVA: 0x183033C
	internal bool get_ignoreCompositeRoots() { }

	// RVA: 0x1830348
	internal void set_ignoreCompositeRoots(bool value) { }

	// RVA: 0x1830368
	internal IEventHandler get_leafTarget() { }

	// RVA: 0x1830370
	private void set_leafTarget(IEventHandler value) { }

	// RVA: 0x182C9F8
	public IEventHandler get_target() { }

	// RVA: 0x182C838
	public void set_target(IEventHandler value) { }

	// RVA: 0x1830378
	internal System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> get_skipElements() { }

	// RVA: 0x182DC48
	internal bool Skip(IEventHandler h) { }

	// RVA: 0x182C488
	public bool get_isPropagationStopped() { }

	// RVA: 0x1830380
	private void set_isPropagationStopped(bool value) { }

	// RVA: 0x182055C
	public void StopPropagation() { }

	// RVA: 0x1830394
	public bool get_isImmediatePropagationStopped() { }

	// RVA: 0x18303A0
	private void set_isImmediatePropagationStopped(bool value) { }

	// RVA: 0x18303C0
	public void StopImmediatePropagation() { }

	// RVA: 0x18303D0
	public bool get_isDefaultPrevented() { }

	// RVA: 0x18303DC
	private void set_isDefaultPrevented(bool value) { }

	// RVA: 0x182DCAC
	public void PreventDefault() { }

	// RVA: 0x18303FC
	public PropagationPhase get_propagationPhase() { }

	// RVA: 0x1830404
	internal void set_propagationPhase(PropagationPhase value) { }

	// RVA: 0x183040C
	public virtual IEventHandler get_currentTarget() { }

	// RVA: 0x1830414
	internal virtual void set_currentTarget(IEventHandler value) { }

	// RVA: 0x183051C
	public bool get_dispatch() { }

	// RVA: 0x1830528
	internal void set_dispatch(bool value) { }

	// RVA: 0x182AF3C
	internal void MarkReceivedByDispatcher() { }

	// RVA: 0x1830568
	private bool get_dispatched() { }

	// RVA: 0x1830548
	private void set_dispatched(bool value) { }

	// RVA: 0x1830574
	internal bool get_processed() { }

	// RVA: 0x18302D8
	private void set_processed(bool value) { }

	// RVA: 0x1830580
	internal bool get_processedByFocusController() { }

	// RVA: 0x183058C
	internal void set_processedByFocusController(bool value) { }

	// RVA: 0x182C47C
	internal bool get_stopDispatch() { }

	// RVA: 0x182E37C
	internal void set_stopDispatch(bool value) { }

	// RVA: 0x182DCC4
	internal bool get_propagateToIMGUI() { }

	// RVA: 0x182E35C
	internal void set_propagateToIMGUI(bool value) { }

	// RVA: 0x18305AC
	private bool get_imguiEventIsValid() { }

	// RVA: 0x18305B8
	private void set_imguiEventIsValid(bool value) { }

	// RVA: 0x182AFD0
	public Event get_imguiEvent() { }

	// RVA: 0x18305D8
	protected void set_imguiEvent(Event value) { }

	// RVA: 0x18306BC
	public Vector2 get_originalMousePosition() { }

	// RVA: 0x18306C4
	private void set_originalMousePosition(Vector2 value) { }

	// RVA: 0x18306CC
	protected virtual void Init() { }

	// RVA: 0x18306D0
	private void LocalInit() { }

	// RVA: 0x18308C4
	internal void .ctor(EventCategory category) { }

	// RVA: 0x1830978
	protected bool get_pooled() { }

	// RVA: 0x18308A4
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
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

	// RVA: 0x30DA164
	internal static void SetCreateFunction(System.Func<T> createMethod) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

	// RVA: 0x30D7144
	public static Int64 TypeId() { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x318DB98
	public static T GetPooled() { }

	// RVA: 0x318DB98
	internal static T GetPooled(EventBase e) { }

	// RVA: 0x318DB98
	private static void ReleasePooled(T evt) { }

	// RVA: 0x30D488C
	internal override void Acquire() { }

	// RVA: 0x30D488C
	public sealed override void Dispose() { }

	// RVA: 0x30D3BC4
	public override Int64 get_eventTypeId() { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public sealed class EventCallback<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(TEventType evt) { }

}

// Namespace: UnityEngine.UIElements
public sealed class EventCallback<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(TEventType evt, TCallbackArgs userArgs) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class EventCallbackFunctorBase
{
	// Fields
	private readonly CallbackPhase <phase>k__BackingField; // 0x10
	private readonly InvokePolicy <invokePolicy>k__BackingField; // 0x14

	// Methods

	// RVA: 0x1830984
	public CallbackPhase get_phase() { }

	// RVA: 0x183098C
	public InvokePolicy get_invokePolicy() { }

	// RVA: 0x1830994
	protected void .ctor(CallbackPhase phase, InvokePolicy invokePolicy) { }

	// RVA: -1
	public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: -1
	public abstract bool IsEquivalentTo(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x18309CC
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

	// RVA: 0x30D4D3C
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

	// RVA: 0x318DB98
	internal TCallbackArgs get_userArgs() { }

	// RVA: 0x318DB98
	internal void set_userArgs(TCallbackArgs value) { }

	// RVA: 0x318DB98
	public void .ctor(UnityEngine.UIElements.EventCallback<TEventType,TCallbackArgs> callback, TCallbackArgs userArgs, CallbackPhase phase, InvokePolicy invokePolicy) { }

	// RVA: 0x30D4D3C
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

	// RVA: 0x1830A08
	public EventCallbackList Get(EventCallbackList initializer) { }

	// RVA: 0x1830EDC
	public void Release(EventCallbackList element) { }

	// RVA: 0x1831070
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

	// RVA: 0x18310FC
	public int get_trickleDownCallbackCount() { }

	// RVA: 0x1831104
	private void set_trickleDownCallbackCount(int value) { }

	// RVA: 0x183110C
	public int get_bubbleUpCallbackCount() { }

	// RVA: 0x1831114
	private void set_bubbleUpCallbackCount(int value) { }

	// RVA: 0x1830C24
	public void .ctor() { }

	// RVA: 0x1830B7C
	public void .ctor(EventCallbackList source) { }

	// RVA: 0x183111C
	public bool Contains(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x1831138
	public EventCallbackFunctorBase Find(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x1831244
	public bool Remove(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x183137C
	public void Add(EventCallbackFunctorBase item) { }

	// RVA: 0x1830CB8
	public void AddRange(EventCallbackList list) { }

	// RVA: 0x1831424
	public int get_Count() { }

	// RVA: 0x1831470
	public EventCallbackFunctorBase get_Item(int i) { }

	// RVA: 0x1830FC4
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

	// RVA: 0x18314E8
	private static EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	// RVA: 0x1831574
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	// RVA: 0x1831600
	public void .ctor() { }

	// RVA: 0x1831628
	private EventCallbackList GetCallbackListForWriting() { }

	// RVA: 0x1831880
	private EventCallbackList GetCallbackListForReading() { }

	// RVA: 0x183189C
	private bool UnregisterCallback(Int64 eventTypeId, Delegate callback, TrickleDown useTrickleDown) { }

	// RVA: -1
	public void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown, InvokePolicy invokePolicy) { }

	// RVA: 0x318DB98
	public void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType,TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown, InvokePolicy invokePolicy) { }

	// RVA: 0x30D38C4
	public bool UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown) { }

	// RVA: 0x1831900
	public void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: 0x1831C9C
	public bool HasTrickleDownHandlers() { }

	// RVA: 0x1831CBC
	public bool HasBubbleHandlers() { }

	// RVA: 0x1831CDC
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogCall
{
	// Methods

	// RVA: 0x1831DD0
	public void .ctor(Delegate callback, EventBase evt) { }

	// RVA: 0x1831DD4
	public void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogIMGUICall
{
	// Methods

	// RVA: 0x1831DD8
	public void .ctor(EventBase evt) { }

	// RVA: 0x1831DDC
	public void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogExecuteDefaultAction
{
	// Methods

	// RVA: 0x1831DE0
	public void .ctor(EventBase evt) { }

	// RVA: 0x1831DE4
	public void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal class EventDebugger
{
	// Methods

	// RVA: 0x182C834
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

	// RVA: 0x30D4D3C
	public void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown) { }

	// RVA: 0x30D488C
	private void AddEventCategories() { }

	// RVA: 0x318DB98
	public void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType,TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown) { }

	// RVA: -1
	internal void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown) { }

	// RVA: 0x30D4D3C
	public void UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown) { }

	// RVA: -1
	public abstract void SendEvent(EventBase e) { }

	// RVA: -1
	internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: 0x1831DE8
	internal void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0x1831E64
	internal void HandleEventAtTargetAndDefaultPhase(EventBase evt) { }

	// RVA: 0x1831E58
	internal void HandleEventAtCurrentTargetAndPhase(EventBase evt) { }

	// RVA: 0x1831EF0
	private void UnityEngine.UIElements.IEventHandler.HandleEvent(EventBase evt) { }

	// RVA: 0x1831EFC
	public virtual void HandleEvent(EventBase evt) { }

	// RVA: 0x18321B0
	public bool HasTrickleDownHandlers() { }

	// RVA: 0x18321D8
	public bool HasBubbleUpHandlers() { }

	// RVA: 0x1832200
	protected virtual void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x1832204
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x1832208
	internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt) { }

	// RVA: 0x183220C
	internal virtual void ExecuteDefaultActionDisabled(EventBase evt) { }

	// RVA: 0x1832210
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

	// RVA: 0x30D3CF0
	public Focusable get_relatedTarget() { }

	// RVA: 0x30D4CD4
	private void set_relatedTarget(Focusable value) { }

	// RVA: 0x30D3CF0
	public FocusChangeDirection get_direction() { }

	// RVA: 0x30D4CD4
	private void set_direction(FocusChangeDirection value) { }

	// RVA: 0x30D3CF0
	protected FocusController get_focusController() { }

	// RVA: 0x30D4CD4
	private void set_focusController(FocusController value) { }

	// RVA: 0x30D3738
	internal bool get_IsFocusDelegated() { }

	// RVA: 0x30D4918
	private void set_IsFocusDelegated(bool value) { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x318DB98
	public static T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.FocusOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18323D8
	private static void .cctor() { }

	// RVA: 0x1832444
	public void .ctor() { }

	// RVA: 0x183244C
	internal FocusOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class FocusOutEvent
{
	// Methods

	// RVA: 0x183221C
	private static void .cctor() { }

	// RVA: 0x183230C
	protected override void Init() { }

	// RVA: 0x183236C
	private void LocalInit() { }

	// RVA: 0x1832378
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.BlurEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18326A4
	private static void .cctor() { }

	// RVA: 0x1832710
	public void .ctor() { }

	// RVA: 0x1832718
	internal BlurEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class BlurEvent
{
	// Methods

	// RVA: 0x18324E0
	private static void .cctor() { }

	// RVA: 0x18325D0
	protected internal override void PreDispatch(IPanel panel) { }

	// RVA: 0x1832650
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.FocusInEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1832960
	private static void .cctor() { }

	// RVA: 0x18329CC
	public void .ctor() { }

	// RVA: 0x18329D4
	internal FocusInEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class FocusInEvent
{
	// Methods

	// RVA: 0x18327A4
	private static void .cctor() { }

	// RVA: 0x1832894
	protected override void Init() { }

	// RVA: 0x18328F4
	private void LocalInit() { }

	// RVA: 0x1832900
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.FocusEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1832C64
	private static void .cctor() { }

	// RVA: 0x1832CD0
	public void .ctor() { }

	// RVA: 0x1832CD8
	internal FocusEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class FocusEvent
{
	// Methods

	// RVA: 0x1832A68
	private static void .cctor() { }

	// RVA: 0x1832B58
	protected internal override void PreDispatch(IPanel panel) { }

	// RVA: 0x1832C10
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

	// RVA: 0x182E1D0
	public static void PropagateEvent(EventBase evt) { }

	// RVA: 0x1832D64
	private static void HandleEventAcrossPropagationPath(EventBase evt) { }

	// RVA: 0x182DCD0
	internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt) { }

	// RVA: 0x182C880
	public static void ExecuteDefaultAction(EventBase evt) { }

}

// Namespace: UnityEngine.UIElements
internal class IMGUIEventDispatchingStrategy
{
	// Methods

	// RVA: 0x183381C
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x18338A0
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x182CED0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.InputEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1833C8C
	private static void .cctor() { }

	// RVA: 0x1833CF8
	public void .ctor() { }

	// RVA: 0x1833D00
	internal InputEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class InputEvent
{
	// Fields
	private string <previousData>k__BackingField; // 0x88
	private string <newData>k__BackingField; // 0x90

	// Methods

	// RVA: 0x183396C
	private static void .cctor() { }

	// RVA: 0x1833A5C
	protected void set_previousData(string value) { }

	// RVA: 0x1833A64
	protected void set_newData(string value) { }

	// RVA: 0x1833A6C
	protected override void Init() { }

	// RVA: 0x1833AE8
	private void LocalInit() { }

	// RVA: 0x1833B24
	public static InputEvent GetPooled(string previousData, string newData) { }

	// RVA: 0x1833BEC
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class KeyboardEventDispatchingStrategy
{
	// Methods

	// RVA: 0x1833DD8
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1833E38
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x182CEB8
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

	// RVA: 0x30D39B8
	public EventModifiers get_modifiers() { }

	// RVA: 0x30D4A04
	protected void set_modifiers(EventModifiers value) { }

	// RVA: -1
	public Char get_character() { }

	// RVA: -1
	protected void set_character(Char value) { }

	// RVA: 0x30D39B8
	public KeyCode get_keyCode() { }

	// RVA: 0x30D4A04
	protected void set_keyCode(KeyCode value) { }

	// RVA: 0x30D3738
	public bool get_shiftKey() { }

	// RVA: 0x30D3738
	public bool get_ctrlKey() { }

	// RVA: 0x30D3738
	public bool get_commandKey() { }

	// RVA: 0x30D3738
	public bool get_altKey() { }

	// RVA: 0x30D3738
	internal bool get_functionKey() { }

	// RVA: 0x30D3738
	public bool get_actionKey() { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x318DB98
	public static T GetPooled(Event systemEvent) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.KeyDownEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1834DD4
	private static void .cctor() { }

	// RVA: 0x1834E40
	public void .ctor() { }

	// RVA: 0x1834E48
	internal KeyDownEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class KeyDownEvent
{
	// Methods

	// RVA: 0x1834150
	private static void .cctor() { }

	// RVA: 0x1834240
	internal void GetEquivalentImguiEvent(Event outImguiEvent) { }

	// RVA: 0x1834310
	protected internal override void PostDispatch(IPanel panel) { }

	// RVA: 0x1834434
	private void SendEquivalentNavigationEventIfAny(IPanel panel) { }

	// RVA: 0x1834D80
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class KeyboardEventExtensions
{
	// Methods

	// RVA: 0x1834BF8
	internal static bool ShouldSendNavigationMoveEvent(KeyDownEvent e) { }

	// RVA: 0x1834ED4
	internal static bool ShouldSendNavigationMoveEventRuntime(Event e) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.KeyUpEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1835070
	private static void .cctor() { }

	// RVA: 0x18350DC
	public void .ctor() { }

	// RVA: 0x18350E4
	internal KeyUpEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class KeyUpEvent
{
	// Methods

	// RVA: 0x1834F2C
	private static void .cctor() { }

	// RVA: 0x183501C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.GeometryChangedEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18354E0
	private static void .cctor() { }

	// RVA: 0x183554C
	public void .ctor() { }

	// RVA: 0x1835554
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

	// RVA: 0x1835170
	private static void .cctor() { }

	// RVA: 0x1835260
	public static GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect) { }

	// RVA: 0x1835344
	protected override void Init() { }

	// RVA: 0x18353C0
	private void LocalInit() { }

	// RVA: 0x1835400
	public Rect get_oldRect() { }

	// RVA: 0x183540C
	private void set_oldRect(Rect value) { }

	// RVA: 0x1835418
	public Rect get_newRect() { }

	// RVA: 0x1835424
	private void set_newRect(Rect value) { }

	// RVA: 0x1835430
	internal int get_layoutPass() { }

	// RVA: 0x1835438
	internal void set_layoutPass(int value) { }

	// RVA: 0x1835440
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

	// RVA: 0x18355A8
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1835648
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x182CEB0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class MouseEventDispatchingStrategy
{
	// Methods

	// RVA: 0x1835C14
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1835C74
	public void DispatchEvent(EventBase evt, IPanel iPanel) { }

	// RVA: 0x1835EB4
	private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x1835EF4
	private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x1835FF0
	private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x1835DB0
	private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x183622C
	private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, VisualElement elementUnderMouse) { }

	// RVA: 0x18361D8
	private static bool IsDone(EventBase evt) { }

	// RVA: 0x182CEC0
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

	// RVA: 0x30D39B8
	public EventModifiers get_modifiers() { }

	// RVA: 0x30D4A04
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

	// RVA: 0x30D39B8
	public int get_clickCount() { }

	// RVA: 0x30D4A04
	protected void set_clickCount(int value) { }

	// RVA: 0x30D39B8
	public int get_button() { }

	// RVA: 0x30D4A04
	protected void set_button(int value) { }

	// RVA: 0x30D39B8
	public int get_pressedButtons() { }

	// RVA: 0x30D4A04
	protected void set_pressedButtons(int value) { }

	// RVA: 0x30D3738
	public bool get_shiftKey() { }

	// RVA: 0x30D3738
	public bool get_ctrlKey() { }

	// RVA: 0x30D3738
	public bool get_commandKey() { }

	// RVA: 0x30D3738
	public bool get_altKey() { }

	// RVA: 0x30D3738
	private bool UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS() { }

	// RVA: 0x30D4918
	private void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(bool value) { }

	// RVA: 0x30D3738
	private bool UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse() { }

	// RVA: 0x30D4918
	private void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(bool value) { }

	// RVA: 0x30D3CF0
	private IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }

	// RVA: 0x30D4CD4
	private void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(IPointerEvent value) { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x30D3CF0
	public override IEventHandler get_currentTarget() { }

	// RVA: 0x30D4CD4
	internal override void set_currentTarget(IEventHandler value) { }

	// RVA: 0x30D4CD4
	protected internal override void PreDispatch(IPanel panel) { }

	// RVA: 0x30D4CD4
	protected internal override void PostDispatch(IPanel panel) { }

	// RVA: 0x318DB98
	public static T GetPooled(Event systemEvent) { }

	// RVA: 0x318DB98
	internal static T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse) { }

	// RVA: 0x318DB98
	public static T GetPooled(IMouseEvent triggerEvent) { }

	// RVA: 0x318DB98
	protected static T GetPooled(IPointerEvent pointerEvent) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseDownEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1836A0C
	private static void .cctor() { }

	// RVA: 0x1836A78
	public void .ctor() { }

	// RVA: 0x1836A80
	internal MouseDownEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseDownEvent
{
	// Methods

	// RVA: 0x1836580
	private static void .cctor() { }

	// RVA: 0x1836670
	protected override void Init() { }

	// RVA: 0x18366D0
	private void LocalInit() { }

	// RVA: 0x18366DC
	public void .ctor() { }

	// RVA: 0x183673C
	private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

	// RVA: 0x183690C
	internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent) { }

	// RVA: 0x183698C
	internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseUpEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1837020
	private static void .cctor() { }

	// RVA: 0x183708C
	public void .ctor() { }

	// RVA: 0x1837094
	internal MouseUpEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseUpEvent
{
	// Methods

	// RVA: 0x1836B14
	private static void .cctor() { }

	// RVA: 0x1836C04
	protected override void Init() { }

	// RVA: 0x1836C64
	private void LocalInit() { }

	// RVA: 0x1836C70
	public void .ctor() { }

	// RVA: 0x1836CD0
	private static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

	// RVA: 0x1836EA0
	internal static MouseUpEvent GetPooled(PointerUpEvent pointerEvent) { }

	// RVA: 0x1836F20
	internal static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent) { }

	// RVA: 0x1836FA0
	internal static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseMoveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1837338
	private static void .cctor() { }

	// RVA: 0x18373A4
	public void .ctor() { }

	// RVA: 0x18373AC
	internal MouseMoveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseMoveEvent
{
	// Methods

	// RVA: 0x1837128
	private static void .cctor() { }

	// RVA: 0x1837218
	protected override void Init() { }

	// RVA: 0x1837278
	private void LocalInit() { }

	// RVA: 0x1837284
	public void .ctor() { }

	// RVA: 0x18372E4
	internal static MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ContextClickEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1837584
	private static void .cctor() { }

	// RVA: 0x18375F0
	public void .ctor() { }

	// RVA: 0x18375F8
	internal ContextClickEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ContextClickEvent
{
	// Methods

	// RVA: 0x1837440
	private static void .cctor() { }

	// RVA: 0x1837530
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.WheelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1837A3C
	private static void .cctor() { }

	// RVA: 0x1837AA8
	public void .ctor() { }

	// RVA: 0x1837AB0
	internal WheelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class WheelEvent
{
	// Fields
	private Vector3 <delta>k__BackingField; // 0xB8

	// Methods

	// RVA: 0x1837684
	private static void .cctor() { }

	// RVA: 0x1837774
	public Vector3 get_delta() { }

	// RVA: 0x1837780
	private void set_delta(Vector3 value) { }

	// RVA: 0x183778C
	public static WheelEvent GetPooled(Event systemEvent) { }

	// RVA: 0x181D878
	internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers) { }

	// RVA: 0x1837814
	internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) { }

	// RVA: 0x1837898
	protected override void Init() { }

	// RVA: 0x1837938
	private void LocalInit() { }

	// RVA: 0x183799C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseEnterEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1837D40
	private static void .cctor() { }

	// RVA: 0x1837DAC
	public void .ctor() { }

	// RVA: 0x1837DB4
	internal MouseEnterEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseEnterEvent
{
	// Methods

	// RVA: 0x1837B84
	private static void .cctor() { }

	// RVA: 0x1837C74
	protected override void Init() { }

	// RVA: 0x1837CD4
	private void LocalInit() { }

	// RVA: 0x1837CE0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseLeaveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1838004
	private static void .cctor() { }

	// RVA: 0x1838070
	public void .ctor() { }

	// RVA: 0x1838078
	internal MouseLeaveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseLeaveEvent
{
	// Methods

	// RVA: 0x1837E48
	private static void .cctor() { }

	// RVA: 0x1837F38
	protected override void Init() { }

	// RVA: 0x1837F98
	private void LocalInit() { }

	// RVA: 0x1837FA4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseEnterWindowEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1838440
	private static void .cctor() { }

	// RVA: 0x18384AC
	public void .ctor() { }

	// RVA: 0x18384B4
	internal MouseEnterWindowEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseEnterWindowEvent
{
	// Methods

	// RVA: 0x183810C
	private static void .cctor() { }

	// RVA: 0x18381FC
	protected override void Init() { }

	// RVA: 0x183825C
	private void LocalInit() { }

	// RVA: 0x1838268
	public void .ctor() { }

	// RVA: 0x18382C8
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseLeaveWindowEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1838AF8
	private static void .cctor() { }

	// RVA: 0x1838B64
	public void .ctor() { }

	// RVA: 0x1838B6C
	internal MouseLeaveWindowEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseLeaveWindowEvent
{
	// Methods

	// RVA: 0x1838548
	private static void .cctor() { }

	// RVA: 0x1838638
	protected override void Init() { }

	// RVA: 0x183871C
	private void LocalInit() { }

	// RVA: 0x18387CC
	public void .ctor() { }

	// RVA: 0x18388B0
	public static MouseLeaveWindowEvent GetPooled(Event systemEvent) { }

	// RVA: 0x1838980
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseOverEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1838D08
	private static void .cctor() { }

	// RVA: 0x1838D74
	public void .ctor() { }

	// RVA: 0x1838D7C
	internal MouseOverEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseOverEvent
{
	// Methods

	// RVA: 0x1838BC4
	private static void .cctor() { }

	// RVA: 0x1838CB4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1838F4C
	private static void .cctor() { }

	// RVA: 0x1838FB8
	public void .ctor() { }

	// RVA: 0x1838FC0
	internal MouseOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseOutEvent
{
	// Methods

	// RVA: 0x1838E08
	private static void .cctor() { }

	// RVA: 0x1838EF8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ContextualMenuPopulateEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1839B88
	private static void .cctor() { }

	// RVA: 0x1839BF4
	public void .ctor() { }

	// RVA: 0x1839BFC
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

	// RVA: 0x183904C
	private static void .cctor() { }

	// RVA: 0x183913C
	public DropdownMenu get_menu() { }

	// RVA: 0x1839144
	private void set_menu(DropdownMenu value) { }

	// RVA: 0x183914C
	public EventBase get_triggerEvent() { }

	// RVA: 0x1839154
	private void set_triggerEvent(EventBase value) { }

	// RVA: 0x183915C
	public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager) { }

	// RVA: 0x1839924
	protected override void Init() { }

	// RVA: 0x18399D0
	private void LocalInit() { }

	// RVA: 0x1839A38
	public void .ctor() { }

	// RVA: 0x1839AE4
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal static class MouseEventsHelper
{
	// Methods

	// RVA: 0x318DB98
	internal static void SendEnterLeave(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

	// RVA: 0x1839CD4
	internal static void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

}

// Namespace: UnityEngine.UIElements
internal static class PointerEventsHelper
{
	// Methods

	// RVA: 0x318DB98
	internal static void SendEnterLeave(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	// RVA: 0x1839FC0
	internal static void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

}

// Namespace: UnityEngine.UIElements
internal class NavigationEventDispatchingStrategy
{
	// Methods

	// RVA: 0x183A2B0
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x183A310
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x183A5EC
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

	// RVA: 0x30D39B8
	public EventModifiers get_modifiers() { }

	// RVA: 0x30D4A04
	protected void set_modifiers(EventModifiers value) { }

	// RVA: 0x30D3738
	public bool get_shiftKey() { }

	// RVA: 0x30D3738
	public bool get_altKey() { }

	// RVA: 0x30D39B8
	internal NavigationDeviceType get_deviceType() { }

	// RVA: 0x30D4A04
	private void set_deviceType(NavigationDeviceType value) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x318DB98
	public static T GetPooled(EventModifiers modifiers) { }

	// RVA: 0x318DB98
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

	// RVA: 0x183AC24
	private static void .cctor() { }

	// RVA: 0x183AC90
	public void .ctor() { }

	// RVA: 0x183AC98
	internal NavigationMoveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class NavigationMoveEvent
{
	// Fields
	private Direction <direction>k__BackingField; // 0x8C
	private Vector2 <move>k__BackingField; // 0x90

	// Methods

	// RVA: 0x183A5F4
	private static void .cctor() { }

	// RVA: 0x183A6E4
	internal static Direction DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x183A734
	public Direction get_direction() { }

	// RVA: 0x183A73C
	private void set_direction(Direction value) { }

	// RVA: 0x183A744
	private void set_move(Vector2 value) { }

	// RVA: 0x183A74C
	public static NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers) { }

	// RVA: 0x183A840
	internal static NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers) { }

	// RVA: 0x183A940
	public static NavigationMoveEvent GetPooled(Direction direction, EventModifiers modifiers) { }

	// RVA: 0x183A9EC
	internal static NavigationMoveEvent GetPooled(Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers) { }

	// RVA: 0x183AAA4
	protected override void Init() { }

	// RVA: 0x183AB90
	public void .ctor() { }

	// RVA: 0x183AB38
	private void LocalInit() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.NavigationCancelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183AEA4
	private static void .cctor() { }

	// RVA: 0x183AF10
	public void .ctor() { }

	// RVA: 0x183AF18
	internal NavigationCancelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class NavigationCancelEvent
{
	// Methods

	// RVA: 0x183AD60
	private static void .cctor() { }

	// RVA: 0x183AE50
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.NavigationSubmitEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183B0E8
	private static void .cctor() { }

	// RVA: 0x183B154
	public void .ctor() { }

	// RVA: 0x183B15C
	internal NavigationSubmitEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class NavigationSubmitEvent
{
	// Methods

	// RVA: 0x183AFA4
	private static void .cctor() { }

	// RVA: 0x183B094
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class PanelChangedEventBase<T0>
{
	// Fields
	private IPanel <originPanel>k__BackingField; // 0x0
	private IPanel <destinationPanel>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30D3CF0
	public IPanel get_originPanel() { }

	// RVA: 0x30D4CD4
	private void set_originPanel(IPanel value) { }

	// RVA: 0x30D3CF0
	public IPanel get_destinationPanel() { }

	// RVA: 0x30D4CD4
	private void set_destinationPanel(IPanel value) { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x318DB98
	public static T GetPooled(IPanel originPanel, IPanel destinationPanel) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.AttachToPanelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183B32C
	private static void .cctor() { }

	// RVA: 0x183B398
	public void .ctor() { }

	// RVA: 0x183B3A0
	internal AttachToPanelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class AttachToPanelEvent
{
	// Methods

	// RVA: 0x183B1E8
	private static void .cctor() { }

	// RVA: 0x183B2D8
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.DetachFromPanelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183B570
	private static void .cctor() { }

	// RVA: 0x183B5DC
	public void .ctor() { }

	// RVA: 0x183B5E4
	internal DetachFromPanelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class DetachFromPanelEvent
{
	// Methods

	// RVA: 0x183B42C
	private static void .cctor() { }

	// RVA: 0x183B51C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class PointerCaptureDispatchingStrategy
{
	// Methods

	// RVA: 0x183B670
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x183B6D0
	public void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x183BD90
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

	// RVA: 0x183C9EC
	internal Vector2 get_Position() { }

	// RVA: 0x183C9F4
	private void set_Position(Vector2 value) { }

	// RVA: 0x183C9FC
	internal IPanel get_Panel() { }

	// RVA: 0x183CA04
	private void set_Panel(IPanel value) { }

	// RVA: 0x183CA0C
	internal LocationFlag get_Flags() { }

	// RVA: 0x183CA14
	private void set_Flags(LocationFlag value) { }

	// RVA: 0x183BFC0
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

	// RVA: 0x183BD98
	internal static void RemovePanelData(IPanel panel) { }

	// RVA: 0x183C0D8
	public static void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType) { }

	// RVA: 0x183C19C
	public static void PressButton(int pointerId, int buttonId) { }

	// RVA: 0x183C27C
	public static void ReleaseButton(int pointerId, int buttonId) { }

	// RVA: 0x183C35C
	public static void ReleaseAllButtons(int pointerId) { }

	// RVA: 0x183C3FC
	public static Vector2 GetPointerPosition(int pointerId, ContextType contextType) { }

	// RVA: 0x183C4A0
	public static IPanel GetPanel(int pointerId, ContextType contextType) { }

	// RVA: 0x183C544
	private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag) { }

	// RVA: 0x183C550
	public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag) { }

	// RVA: 0x183C600
	public static int GetPressedButtons(int pointerId) { }

	// RVA: 0x183C6A0
	internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	// RVA: 0x183C754
	internal static void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel) { }

	// RVA: 0x183C820
	internal static IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId) { }

	// RVA: 0x183C8C0
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class PointerEventDispatchingStrategy
{
	// Methods

	// RVA: 0x183CA1C
	public bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x183CA7C
	public virtual void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x183CDD0
	private static void SendEventToTarget(EventBase evt, IPanel panel) { }

	// RVA: 0x183CB44
	private static void SetBestTargetForEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x183CE8C
	private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, VisualElement elementUnderPointer) { }

	// RVA: 0x183D1A0
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

	// RVA: 0x183D1A8
	internal static string GetPointerType(int pointerId) { }

	// RVA: 0x183D2DC
	internal static bool IsDirectManipulationDevice(string pointerType) { }

	// RVA: 0x183D39C
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

	// RVA: 0x183D494
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

	// RVA: 0x183D550
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

	// RVA: 0x30D39B8
	public int get_pointerId() { }

	// RVA: 0x30D4A04
	protected void set_pointerId(int value) { }

	// RVA: 0x30D3CF0
	public string get_pointerType() { }

	// RVA: 0x30D4CD4
	protected void set_pointerType(string value) { }

	// RVA: 0x30D3738
	public bool get_isPrimary() { }

	// RVA: 0x30D4918
	protected void set_isPrimary(bool value) { }

	// RVA: 0x30D39B8
	public int get_button() { }

	// RVA: 0x30D4A04
	protected void set_button(int value) { }

	// RVA: 0x30D39B8
	public int get_pressedButtons() { }

	// RVA: 0x30D4A04
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

	// RVA: 0x30D39B8
	public int get_clickCount() { }

	// RVA: 0x30D4A04
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

	// RVA: 0x30D39B8
	public PenStatus get_penStatus() { }

	// RVA: 0x30D4A04
	protected void set_penStatus(PenStatus value) { }

	// RVA: -1
	public Vector2 get_radius() { }

	// RVA: -1
	protected void set_radius(Vector2 value) { }

	// RVA: -1
	public Vector2 get_radiusVariance() { }

	// RVA: -1
	protected void set_radiusVariance(Vector2 value) { }

	// RVA: 0x30D39B8
	public EventModifiers get_modifiers() { }

	// RVA: 0x30D4A04
	protected void set_modifiers(EventModifiers value) { }

	// RVA: 0x30D3738
	public bool get_shiftKey() { }

	// RVA: 0x30D3738
	public bool get_ctrlKey() { }

	// RVA: 0x30D3738
	public bool get_commandKey() { }

	// RVA: 0x30D3738
	public bool get_altKey() { }

	// RVA: 0x30D3738
	public bool get_actionKey() { }

	// RVA: 0x30D3738
	private bool UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS() { }

	// RVA: 0x30D4918
	private void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(bool value) { }

	// RVA: 0x30D3738
	private bool UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer() { }

	// RVA: 0x30D4918
	private void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(bool value) { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x30D3CF0
	public override IEventHandler get_currentTarget() { }

	// RVA: 0x30D4CD4
	internal override void set_currentTarget(IEventHandler value) { }

	// RVA: 0x30D5E84
	private static bool IsMouse(Event systemEvent) { }

	// RVA: 0x30D5E84
	private static bool IsTouch(Event systemEvent) { }

	// RVA: 0x318DB98
	private static float TiltToAzimuth(Vector2 tilt) { }

	// RVA: 0x318DB98
	private static Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	// RVA: 0x318DB98
	private static float TiltToAltitude(Vector2 tilt) { }

	// RVA: 0x318DB98
	public static T GetPooled(Event systemEvent) { }

	// RVA: 0x318DB98
	internal static T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers) { }

	// RVA: 0x318DB98
	public static T GetPooled(Touch touch, EventModifiers modifiers) { }

	// RVA: 0x318DB98
	public static T GetPooled(PenData pen, EventModifiers modifiers) { }

	// RVA: 0x318DB98
	internal static T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	// RVA: 0x318DB98
	public static T GetPooled(IPointerEvent triggerEvent) { }

	// RVA: 0x30D4CD4
	protected internal override void PreDispatch(IPanel panel) { }

	// RVA: 0x30D4CD4
	protected internal override void PostDispatch(IPanel panel) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerDownEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183DD48
	private static void .cctor() { }

	// RVA: 0x183DDB4
	public void .ctor() { }

	// RVA: 0x183DDBC
	internal PointerDownEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerDownEvent
{
	// Methods

	// RVA: 0x183D800
	private static void .cctor() { }

	// RVA: 0x183D8F0
	protected override void Init() { }

	// RVA: 0x183D94C
	private void LocalInit() { }

	// RVA: 0x183DA5C
	public void .ctor() { }

	// RVA: 0x183DAB8
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerMoveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183E7B4
	private static void .cctor() { }

	// RVA: 0x183E820
	public void .ctor() { }

	// RVA: 0x183E828
	internal PointerMoveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerMoveEvent
{
	// Fields
	private bool <isHandledByDraggable>k__BackingField; // 0x106

	// Methods

	// RVA: 0x183DE50
	private static void .cctor() { }

	// RVA: 0x183DF40
	internal bool get_isHandledByDraggable() { }

	// RVA: 0x183DF48
	internal void set_isHandledByDraggable(bool value) { }

	// RVA: 0x183DF50
	protected override void Init() { }

	// RVA: 0x183DFAC
	private void LocalInit() { }

	// RVA: 0x183E0C4
	public void .ctor() { }

	// RVA: 0x183E120
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerStationaryEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183EB74
	private static void .cctor() { }

	// RVA: 0x183EBE0
	public void .ctor() { }

	// RVA: 0x183EBE8
	internal PointerStationaryEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerStationaryEvent
{
	// Methods

	// RVA: 0x183E8BC
	private static void .cctor() { }

	// RVA: 0x183E9AC
	protected override void Init() { }

	// RVA: 0x183EA08
	private void LocalInit() { }

	// RVA: 0x183EB18
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerUpEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183F36C
	private static void .cctor() { }

	// RVA: 0x183F3D8
	public void .ctor() { }

	// RVA: 0x183F3E0
	internal PointerUpEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerUpEvent
{
	// Methods

	// RVA: 0x183EC7C
	private static void .cctor() { }

	// RVA: 0x183ED6C
	protected override void Init() { }

	// RVA: 0x183EDC8
	private void LocalInit() { }

	// RVA: 0x183EED8
	public void .ctor() { }

	// RVA: 0x183EF34
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerCancelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183FB28
	private static void .cctor() { }

	// RVA: 0x183FB94
	public void .ctor() { }

	// RVA: 0x183FB9C
	internal PointerCancelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerCancelEvent
{
	// Methods

	// RVA: 0x183F474
	private static void .cctor() { }

	// RVA: 0x183F564
	protected override void Init() { }

	// RVA: 0x183F5C0
	private void LocalInit() { }

	// RVA: 0x183F6D0
	public void .ctor() { }

	// RVA: 0x183F72C
	protected internal override void PostDispatch(IPanel panel) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ClickEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x183FE60
	private static void .cctor() { }

	// RVA: 0x183FECC
	public void .ctor() { }

	// RVA: 0x183FED4
	internal ClickEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class ClickEvent
{
	// Methods

	// RVA: 0x183FC30
	private static void .cctor() { }

	// RVA: 0x183FD20
	protected override void Init() { }

	// RVA: 0x183FD80
	private void LocalInit() { }

	// RVA: 0x183FD8C
	public void .ctor() { }

	// RVA: 0x183FDEC
	internal static ClickEvent GetPooled(PointerUpEvent pointerEvent, int clickCount) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerEnterEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1840124
	private static void .cctor() { }

	// RVA: 0x1840190
	public void .ctor() { }

	// RVA: 0x1840198
	internal PointerEnterEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerEnterEvent
{
	// Methods

	// RVA: 0x183FF68
	private static void .cctor() { }

	// RVA: 0x1840058
	protected override void Init() { }

	// RVA: 0x18400B8
	private void LocalInit() { }

	// RVA: 0x18400C4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerLeaveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18403E8
	private static void .cctor() { }

	// RVA: 0x1840454
	public void .ctor() { }

	// RVA: 0x184045C
	internal PointerLeaveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerLeaveEvent
{
	// Methods

	// RVA: 0x184022C
	private static void .cctor() { }

	// RVA: 0x184031C
	protected override void Init() { }

	// RVA: 0x184037C
	private void LocalInit() { }

	// RVA: 0x1840388
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerOverEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1840634
	private static void .cctor() { }

	// RVA: 0x18406A0
	public void .ctor() { }

	// RVA: 0x18406A8
	internal PointerOverEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerOverEvent
{
	// Methods

	// RVA: 0x18404F0
	private static void .cctor() { }

	// RVA: 0x18405E0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1840878
	private static void .cctor() { }

	// RVA: 0x18408E4
	public void .ctor() { }

	// RVA: 0x18408EC
	internal PointerOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerOutEvent
{
	// Methods

	// RVA: 0x1840734
	private static void .cctor() { }

	// RVA: 0x1840824
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.PropagationPaths.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1840F30
	private static void .cctor() { }

	// RVA: 0x1840F9C
	public void .ctor() { }

	// RVA: 0x1840FA4
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

	// RVA: 0x1840978
	public void .ctor() { }

	// RVA: 0x1840A58
	public static PropagationPaths Build(VisualElement elem, EventBase evt) { }

	// RVA: 0x1840C60
	public void Release() { }

	// RVA: 0x1840E10
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.CustomStyleResolvedEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1841220
	private static void .cctor() { }

	// RVA: 0x184128C
	public void .ctor() { }

	// RVA: 0x1841294
	internal CustomStyleResolvedEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class CustomStyleResolvedEvent
{
	// Methods

	// RVA: 0x1840FF8
	private static void .cctor() { }

	// RVA: 0x18410E8
	public ICustomStyle get_customStyle() { }

	// RVA: 0x184117C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TooltipEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1841648
	private static void .cctor() { }

	// RVA: 0x18416B4
	public void .ctor() { }

	// RVA: 0x18416BC
	internal TooltipEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class TooltipEvent
{
	// Fields
	private string <tooltip>k__BackingField; // 0x88
	private Rect <rect>k__BackingField; // 0x90

	// Methods

	// RVA: 0x1841344
	private static void .cctor() { }

	// RVA: 0x1841434
	public void set_tooltip(string value) { }

	// RVA: 0x184143C
	public void set_rect(Rect value) { }

	// RVA: 0x1841448
	protected override void Init() { }

	// RVA: 0x18414F8
	private void LocalInit() { }

	// RVA: 0x1841574
	public void .ctor() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator m_Enumerator; // 0x10

	// Methods

	// RVA: 0x18417A8
	internal void .ctor(Enumerator enumerator) { }

	// RVA: 0x1841948
	public bool MoveNext() { }

	// RVA: 0x184199C
	public StylePropertyName get_Current() { }

	// RVA: 0x1841A70
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1841BAC
	public void Reset() { }

	// RVA: 0x1841BB0
	public void Dispose() { }

}

// Namespace: UnityEngine.UIElements
public struct StylePropertyNameCollection
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> propertiesList; // 0x10

	// Methods

	// RVA: 0x1841710
	internal void .ctor(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list) { }

	// RVA: 0x1841718
	public Enumerator GetEnumerator() { }

	// RVA: 0x18417B8
	private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator() { }

	// RVA: 0x1841880
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.UIElements
public abstract class TransitionEventBase<T0>
{
	// Fields
	private readonly StylePropertyNameCollection <stylePropertyNames>k__BackingField; // 0x0
	private Double <elapsedTime>k__BackingField; // 0x0

	// Methods

	// RVA: 0x318DB98
	public StylePropertyNameCollection get_stylePropertyNames() { }

	// RVA: -1
	protected void set_elapsedTime(Double value) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

	// RVA: 0x30D488C
	protected override void Init() { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x318DB98
	public static T GetPooled(StylePropertyName stylePropertyName, Double elapsedTime) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionRunEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1841D48
	private static void .cctor() { }

	// RVA: 0x1841DB4
	public void .ctor() { }

	// RVA: 0x1841DBC
	internal TransitionRunEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionRunEvent
{
	// Methods

	// RVA: 0x1841C04
	private static void .cctor() { }

	// RVA: 0x1841CF4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionStartEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1841F8C
	private static void .cctor() { }

	// RVA: 0x1841FF8
	public void .ctor() { }

	// RVA: 0x1842000
	internal TransitionStartEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionStartEvent
{
	// Methods

	// RVA: 0x1841E48
	private static void .cctor() { }

	// RVA: 0x1841F38
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionEndEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18421D0
	private static void .cctor() { }

	// RVA: 0x184223C
	public void .ctor() { }

	// RVA: 0x1842244
	internal TransitionEndEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionEndEvent
{
	// Methods

	// RVA: 0x184208C
	private static void .cctor() { }

	// RVA: 0x184217C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionCancelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1842414
	private static void .cctor() { }

	// RVA: 0x1842480
	public void .ctor() { }

	// RVA: 0x1842488
	internal TransitionCancelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionCancelEvent
{
	// Methods

	// RVA: 0x18422D0
	private static void .cctor() { }

	// RVA: 0x18423C0
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.IMGUIEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18427A8
	private static void .cctor() { }

	// RVA: 0x1842814
	public void .ctor() { }

	// RVA: 0x184281C
	internal IMGUIEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class IMGUIEvent
{
	// Methods

	// RVA: 0x1842514
	private static void .cctor() { }

	// RVA: 0x1842604
	public static IMGUIEvent GetPooled(Event systemEvent) { }

	// RVA: 0x18426B8
	protected override void Init() { }

	// RVA: 0x1842718
	private void LocalInit() { }

	// RVA: 0x1842724
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseFieldMouseDragger
{
	// Methods

	// RVA: 0x18428D4
	public void SetDragZone(VisualElement dragElement) { }

	// RVA: -1
	public abstract void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	// RVA: 0x18428F0
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

	// RVA: 0x30D4CD4
	public void .ctor(UnityEngine.UIElements.IValueField<T> drivenField) { }

	// RVA: 0x30D3738
	public bool get_dragging() { }

	// RVA: 0x30D4918
	public void set_dragging(bool value) { }

	// RVA: 0x318DB98
	public T get_startValue() { }

	// RVA: 0x318DB98
	public void set_startValue(T value) { }

	// RVA: -1
	public sealed override void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	// RVA: 0x318DB98
	private bool CanStartDrag(int button, Vector2 localPosition) { }

	// RVA: 0x30D4CD4
	private void UpdateValueOnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x30D4CD4
	private void ProcessDownEvent(EventBase evt) { }

	// RVA: 0x30D4CD4
	private void UpdateValueOnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x318DB98
	private void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition) { }

	// RVA: 0x30D4CD4
	private void UpdateValueOnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x30D4D3C
	private void ProcessUpEvent(EventBase evt, int pointerId) { }

	// RVA: 0x30D4CD4
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

	// RVA: 0x18428F8
	protected void .ctor() { }

	// RVA: -1
	public abstract FocusController get_focusController() { }

	// RVA: 0x1842928
	public bool get_focusable() { }

	// RVA: 0x1842930
	public void set_focusable(bool value) { }

	// RVA: 0x1842938
	public int get_tabIndex() { }

	// RVA: 0x1842940
	public void set_tabIndex(int value) { }

	// RVA: 0x1842948
	public bool get_delegatesFocus() { }

	// RVA: 0x1842950
	public void set_delegatesFocus(bool value) { }

	// RVA: 0x1842958
	internal bool get_excludeFromFocusRing() { }

	// RVA: 0x1842960
	internal void set_excludeFromFocusRing(bool value) { }

	// RVA: 0x1842A48
	public virtual bool get_canGrabFocus() { }

	// RVA: 0x1842A50
	public virtual void Focus() { }

	// RVA: 0x1842E80
	public virtual void Blur() { }

	// RVA: 0x1843080
	internal void BlurImmediately() { }

	// RVA: 0x1842CF8
	private Focusable GetFocusDelegate() { }

	// RVA: 0x18430C8
	private static Focusable GetFirstFocusableChild(VisualElement ve) { }

	// RVA: 0x1843204
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x18432D4
	internal override void ExecuteDefaultActionDisabled(EventBase evt) { }

	// RVA: 0x1843270
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

	// RVA: 0x1843640
	public static FocusChangeDirection get_unspecified() { }

	// RVA: 0x18436BC
	public static FocusChangeDirection get_none() { }

	// RVA: 0x1843738
	protected static FocusChangeDirection get_lastValue() { }

	// RVA: 0x18437B4
	protected void .ctor(int value) { }

	// RVA: 0x18437E0
	public static int op_Implicit(FocusChangeDirection fcd) { }

	// RVA: 0x18437EC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x18437F8
	protected virtual void Dispose() { }

	// RVA: 0x18437FC
	internal virtual void ApplyTo(FocusController focusController, Focusable f) { }

	// RVA: 0x1843B64
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

	// RVA: 0x1843C6C
	public void .ctor(IFocusRing focusRing) { }

	// RVA: 0x1843D20
	private IFocusRing get_focusRing() { }

	// RVA: 0x1843D28
	internal void set_selectedTextElement(TextElement value) { }

	// RVA: 0x1843E14
	public Focusable get_focusedElement() { }

	// RVA: 0x184416C
	internal bool IsFocused(Focusable f) { }

	// RVA: 0x1843E5C
	internal Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst) { }

	// RVA: 0x183A518
	internal Focusable GetLeafFocusedElement() { }

	// RVA: 0x1844114
	private bool IsLocalElement(Focusable f) { }

	// RVA: 0x1844388
	internal bool IsPendingFocus(Focusable f) { }

	// RVA: 0x1844474
	internal void SetFocusToLastFocusedElement() { }

	// RVA: 0x1844500
	internal void BlurLastFocusedElement() { }

	// RVA: 0x18445AC
	internal void DoFocusChange(Focusable f) { }

	// RVA: 0x1844760
	internal void ProcessPendingFocusChange(Focusable f) { }

	// RVA: 0x18447BC
	internal Focusable FocusNextInDirection(FocusChangeDirection direction) { }

	// RVA: 0x1844964
	private void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x1844AF4
	private void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x1844C84
	private void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x1844E14
	private void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x1842EC8
	internal void Blur(Focusable focusable, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x1842D9C
	internal void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x1843828
	internal void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x1843340
	internal void SwitchFocusOnEvent(EventBase e) { }

	// RVA: 0x1844FA8
	internal void ReevaluateFocus() { }

	// RVA: 0x1845080
	internal bool GetFocusableParentForPointerEvent(Focusable target, Focusable effectiveTarget) { }

	// RVA: 0x18451D8
	internal int get_imguiKeyboardControl() { }

	// RVA: 0x18451E0
	internal void set_imguiKeyboardControl(int value) { }

	// RVA: 0x18451E8
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

	// RVA: 0x1845318
	public int get_minAtlasSize() { }

	// RVA: 0x1845320
	public void set_minAtlasSize(int value) { }

	// RVA: 0x1845328
	public int get_maxAtlasSize() { }

	// RVA: 0x1845330
	public void set_maxAtlasSize(int value) { }

	// RVA: 0x1845338
	public int get_maxSubTextureSize() { }

	// RVA: 0x1845340
	public void set_maxSubTextureSize(int value) { }

	// RVA: 0x1845348
	public DynamicAtlasFilters get_activeFilters() { }

	// RVA: 0x1845350
	public void set_activeFilters(DynamicAtlasFilters value) { }

	// RVA: 0x1845358
	public static DynamicAtlasFilters get_defaultFilters() { }

	// RVA: 0x1845360
	public DynamicAtlasCustomFilter get_customFilter() { }

	// RVA: 0x1845368
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	// RVA: 0x1845370
	public static DynamicAtlasSettings get_defaults() { }

	// RVA: 0x1845400
	public void .ctor() { }

}

// Namespace: 
public class ChangeDirection
{
	// Methods

	// RVA: 0x18464F4
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

	// RVA: 0x1846564
	private bool ValidateHierarchyTraversal(VisualElement v) { }

	// RVA: 0x1846650
	private bool ValidateElement(VisualElement v) { }

	// RVA: 0x184675C
	private int Order(VisualElement a, VisualElement b) { }

	// RVA: 0x1846C00
	private int StrictOrder(VisualElement a, VisualElement b) { }

	// RVA: 0x18468D4
	private int StrictOrder(Rect ra, Rect rb) { }

	// RVA: 0x1846AFC
	private int TieBreaker(Rect ra, Rect rb) { }

	// RVA: 0x1845F5C
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

	// RVA: 0x1845408
	private FocusController get_focusController() { }

	// RVA: 0x1845430
	public void .ctor(VisualElement root) { }

	// RVA: 0x18454C4
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x1845918
	public virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	// RVA: 0x1845AC8
	private Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction) { }

	// RVA: 0x18460BC
	private static bool IsActive(VisualElement v) { }

	// RVA: 0x18461A8
	private static bool IsNavigable(Focusable focusable) { }

	// RVA: 0x184621C
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

	// RVA: 0x18474B8
	internal void .ctor(PanelSettings settings) { }

	// RVA: 0x1847330
	internal bool get_isInitialized() { }

	// RVA: 0x1847168
	internal BaseRuntimePanel get_panel() { }

	// RVA: 0x184792C
	internal void DisposePanel() { }

	// RVA: 0x1846ED4
	internal void SetTargetTexture() { }

	// RVA: 0x1847060
	internal void SetSortingPriority() { }

	// RVA: 0x18470D8
	internal void SetTargetDisplay() { }

	// RVA: 0x1848D40
	private BaseRuntimePanel CreateRelatedRuntimePanel() { }

	// RVA: 0x1848E5C
	private void DisposeRelatedPanel() { }

	// RVA: 0x1848CB0
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

	// RVA: 0x1846C88
	public ThemeStyleSheet get_themeStyleSheet() { }

	// RVA: 0x1846C90
	public void set_themeStyleSheet(ThemeStyleSheet value) { }

	// RVA: 0x1846E70
	public RenderTexture get_targetTexture() { }

	// RVA: 0x1846E78
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x1846F0C
	public PanelScaleMode get_scaleMode() { }

	// RVA: 0x1846F14
	public void set_scaleMode(PanelScaleMode value) { }

	// RVA: 0x1846F1C
	public float get_referenceSpritePixelsPerUnit() { }

	// RVA: 0x1846F24
	public void set_referenceSpritePixelsPerUnit(float value) { }

	// RVA: 0x1846F2C
	public float get_scale() { }

	// RVA: 0x1846F34
	public void set_scale(float value) { }

	// RVA: 0x1846F3C
	public float get_referenceDpi() { }

	// RVA: 0x1846F44
	public void set_referenceDpi(float value) { }

	// RVA: 0x1846F74
	public float get_fallbackDpi() { }

	// RVA: 0x1846F7C
	public void set_fallbackDpi(float value) { }

	// RVA: 0x1846FAC
	public Vector2Int get_referenceResolution() { }

	// RVA: 0x1846FB4
	public void set_referenceResolution(Vector2Int value) { }

	// RVA: 0x1846FBC
	public PanelScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x1846FC4
	public void set_screenMatchMode(PanelScreenMatchMode value) { }

	// RVA: 0x1846FCC
	public float get_match() { }

	// RVA: 0x1846FD4
	public void set_match(float value) { }

	// RVA: 0x1846FDC
	public float get_sortingOrder() { }

	// RVA: 0x1846FE4
	public void set_sortingOrder(float value) { }

	// RVA: 0x1847024
	internal void ApplySortingOrder() { }

	// RVA: 0x1847098
	public int get_targetDisplay() { }

	// RVA: 0x18470A0
	public void set_targetDisplay(int value) { }

	// RVA: 0x1847104
	public bool get_clearDepthStencil() { }

	// RVA: 0x184710C
	public void set_clearDepthStencil(bool value) { }

	// RVA: 0x1847114
	public float get_depthClearValue() { }

	// RVA: 0x1847124
	public bool get_clearColor() { }

	// RVA: 0x184712C
	public void set_clearColor(bool value) { }

	// RVA: 0x1847134
	public Color get_colorClearValue() { }

	// RVA: 0x1847140
	public void set_colorClearValue(Color value) { }

	// RVA: 0x184714C
	internal BaseRuntimePanel get_panel() { }

	// RVA: 0x1847310
	internal bool get_isInitialized() { }

	// RVA: 0x1847340
	internal VisualElement get_visualTree() { }

	// RVA: 0x1847370
	public DynamicAtlasSettings get_dynamicAtlasSettings() { }

	// RVA: 0x1847378
	public void set_dynamicAtlasSettings(DynamicAtlasSettings value) { }

	// RVA: 0x1847380
	private void .ctor() { }

	// RVA: 0x18474EC
	private void Reset() { }

	// RVA: 0x18474F0
	private void OnEnable() { }

	// RVA: 0x1847890
	private void OnDisable() { }

	// RVA: 0x18479C0
	internal void DisposePanel() { }

	// RVA: 0x1847A5C
	private float get_ScreenDPI() { }

	// RVA: 0x1847A64
	private void set_ScreenDPI(float value) { }

	// RVA: 0x184761C
	internal void UpdateScreenDPI() { }

	// RVA: 0x1846CBC
	private void ApplyThemeStyleSheet(VisualElement root) { }

	// RVA: 0x1847644
	private void InitializeShaders() { }

	// RVA: 0x1847A6C
	internal void ApplyPanelSettings() { }

	// RVA: 0x18484B0
	public void SetScreenToPanelSpaceFunction(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> screentoPanelSpaceFunction) { }

	// RVA: 0x18482A4
	internal float ResolveScale(Rect targetRect, float screenDpi) { }

	// RVA: 0x1848184
	internal Rect GetDisplayRect() { }

	// RVA: 0x18484F4
	internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) { }

	// RVA: 0x1848B70
	internal void DetachUIDocument(UIDocument uiDocument) { }

}

// Namespace: UnityEngine.UIElements
internal static class RuntimeEventDispatcher
{
	// Methods

	// RVA: 0x1848EEC
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

	// RVA: 0x1849898
	private static void .cctor() { }

	// RVA: 0x1849904
	public void .ctor() { }

	// RVA: 0x184990C
	internal void <.ctor>b__5_0(FocusEvent e, RuntimePanel p) { }

}

// Namespace: UnityEngine.UIElements
internal class RuntimePanel
{
	// Fields
	internal static readonly EventDispatcher s_EventDispatcher; // 0x0
	private readonly PanelSettings m_PanelSettings; // 0x1E8

	// Methods

	// RVA: 0x1849144
	public PanelSettings get_panelSettings() { }

	// RVA: 0x184914C
	public static RuntimePanel Create(ScriptableObject ownerObject) { }

	// RVA: 0x18491B0
	private void .ctor(ScriptableObject ownerObject) { }

	// RVA: 0x18495DC
	public override void Update() { }

	// RVA: 0x18497A8
	private void OnElementFocus(FocusEvent evt) { }

	// RVA: 0x184983C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UIDocumentList
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_AttachedUIDocuments; // 0x10

	// Methods

	// RVA: 0x1848704
	internal void RemoveFromListAndFromVisualTree(UIDocument uiDocument) { }

	// RVA: 0x184878C
	internal void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex) { }

	// RVA: 0x1848678
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

	// RVA: 0x18499AC
	public PanelSettings get_panelSettings() { }

	// RVA: 0x18499B4
	public void set_panelSettings(PanelSettings value) { }

	// RVA: 0x1849DA8
	public UIDocument get_parentUI() { }

	// RVA: 0x1849DB0
	private void set_parentUI(UIDocument value) { }

	// RVA: 0x1849DB8
	public VisualTreeAsset get_visualTreeAsset() { }

	// RVA: 0x1849DC0
	public void set_visualTreeAsset(VisualTreeAsset value) { }

	// RVA: 0x18499A4
	public VisualElement get_rootVisualElement() { }

	// RVA: 0x184A35C
	internal int get_firstChildInserIndex() { }

	// RVA: 0x184A364
	public float get_sortingOrder() { }

	// RVA: 0x184A36C
	public void set_sortingOrder(float value) { }

	// RVA: 0x184A384
	internal void ApplySortingOrder() { }

	// RVA: 0x184A498
	private void .ctor() { }

	// RVA: 0x184A53C
	private void Awake() { }

	// RVA: 0x184A658
	private void OnEnable() { }

	// RVA: 0x184A540
	private void SetupFromHierarchy() { }

	// RVA: 0x184A804
	private UIDocument FindUIDocumentParent() { }

	// RVA: 0x184A8DC
	internal void Reset() { }

	// RVA: 0x184AA6C
	private void AddChildAndInsertContentToVisualTree(UIDocument child) { }

	// RVA: 0x184A778
	private void RemoveChild(UIDocument child) { }

	// RVA: 0x1849DE8
	private void RecreateUI() { }

	// RVA: 0x184AD28
	private void SetupRootClassList() { }

	// RVA: 0x184A388
	private void AddRootVisualElementToTree() { }

	// RVA: 0x184ABCC
	private void RemoveFromHierarchy() { }

	// RVA: 0x184ADD4
	private void OnDisable() { }

	// RVA: 0x184AE18
	private void OnTransformChildrenChanged() { }

	// RVA: 0x184B25C
	private void OnTransformParentChanged() { }

	// RVA: 0x184B0F8
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

	// RVA: 0x318DB98
	public static void RegisterGroupBoxOption(T option) { }

	// RVA: 0x318DB98
	public static void UnregisterGroupBoxOption(T option) { }

	// RVA: 0x318DB98
	public static void OnOptionSelected(T selectedOption) { }

	// RVA: 0x184B260
	private static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox) { }

	// RVA: 0x184B954
	private static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x184BA28
	private static void OnPanelDestroyed(BaseVisualElementPanel panel) { }

	// RVA: 0x184BC54
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class IEnumerableExtensions
{
	// Methods

	// RVA: 0x184BDAC
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

	// RVA: 0x184C084
	public void Init(IGroupBox groupBox) { }

	// RVA: 0x184C08C
	public void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	// RVA: 0x184C304
	public void RegisterOption(IGroupBoxOption option) { }

	// RVA: 0x184C41C
	public void UnregisterOption(IGroupBoxOption option) { }

	// RVA: 0x184B814
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x18502EC
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Methods

	// RVA: 0x1850340
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

	// RVA: 0x184C4FC
	public Action get_onGUIHandler() { }

	// RVA: 0x184C504
	public void set_onGUIHandler(Action value) { }

	// RVA: 0x184C56C
	internal ObjectGUIState get_guiState() { }

	// RVA: 0x184C65C
	internal Rect get_lastWorldClip() { }

	// RVA: 0x184C670
	internal void set_lastWorldClip(Rect value) { }

	// RVA: 0x184C684
	public bool get_cullingEnabled() { }

	// RVA: 0x184C68C
	private LayoutCache get_cache() { }

	// RVA: 0x184C71C
	private float get_layoutMeasuredWidth() { }

	// RVA: 0x184C7B0
	private float get_layoutMeasuredHeight() { }

	// RVA: 0x184C844
	public ContextType get_contextType() { }

	// RVA: 0x184C84C
	public void set_contextType(ContextType value) { }

	// RVA: 0x184C854
	internal bool get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0x184C85C
	public override bool get_canGrabFocus() { }

	// RVA: 0x184C87C
	private static void .cctor() { }

	// RVA: 0x184CC08
	public void .ctor() { }

	// RVA: 0x184CC10
	public void .ctor(Action onGUIHandler) { }

	// RVA: 0x184CEE4
	private void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x184D018
	private void SaveGlobals() { }

	// RVA: 0x184D124
	private void RestoreGlobals() { }

	// RVA: 0x184D240
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x184E12C
	public void MarkDirtyLayout() { }

	// RVA: 0x184E140
	internal void ProcessEvent(EventBase evt) { }

	// RVA: 0x184E5E0
	private void DoIMGUIRepaint() { }

	// RVA: 0x184E32C
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	// RVA: 0x184ED5C
	private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	// RVA: 0x184EF38
	private bool VerifyBounds(EventBase evt) { }

	// RVA: 0x184F0B4
	private bool IsContainerCapturingTheMouse() { }

	// RVA: 0x184F1E0
	private bool IsLocalEvent(EventBase evt) { }

	// RVA: 0x184F4A0
	private bool IsEventInsideLocalWindow(EventBase evt) { }

	// RVA: 0x184F698
	private static bool IsDockAreaMouseUp(EventBase evt) { }

	// RVA: 0x184EFEC
	private bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	// RVA: 0x184F850
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x184E8C0
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x184FB10
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x184FE48
	private void SetFoldoutDepthClass() { }

	// RVA: 0x184FFF0
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x184F810
	private Rect GetCurrentClipRect() { }

	// RVA: 0x184F918
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, Matrix4x4 transform, Rect clipRect) { }

	// RVA: 0x1850234
	public void Dispose() { }

	// RVA: 0x18502C8
	protected virtual void Dispose(bool disposeManaged) { }

	// RVA: 0x18502E0
	private void <DoOnGUI>b__56_0() { }

}

// Namespace: UnityEngine.UIElements
internal class ImmediateModeException
{
	// Methods

	// RVA: 0x18503E4
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

	// RVA: 0x1850468
	public void .ctor(System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase> action) { }

	// RVA: 0x18504A4
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x18506BC
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x18508CC
	internal void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x1850A60
	private void OnNavigationCancel(NavigationCancelEvent evt) { }

	// RVA: 0x1850AA0
	private void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x1850AE0
	private void OnNavigationMove(NavigationMoveEvent evt) { }

	// RVA: 0x1850A28
	private void Invoke(KeyboardNavigationOperation operation, EventBase evt) { }

	// RVA: 0x185092C
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

	// RVA: 0x1850B80
	public MouseButton get_button() { }

	// RVA: 0x1850B88
	public void set_button(MouseButton value) { }

	// RVA: 0x1850B90
	public EventModifiers get_modifiers() { }

	// RVA: 0x1850B98
	public void set_modifiers(EventModifiers value) { }

	// RVA: 0x1850BA0
	public int get_clickCount() { }

	// RVA: 0x1850BA8
	public override bool Equals(object obj) { }

	// RVA: 0x1850C58
	public bool Equals(ManipulatorActivationFilter other) { }

	// RVA: 0x1850C8C
	public override int GetHashCode() { }

	// RVA: 0x1850D18
	public bool Matches(IMouseEvent e) { }

	// RVA: 0x1850EBC
	private bool HasModifiers(IMouseEvent e) { }

	// RVA: 0x1851148
	public bool Matches(IPointerEvent e) { }

	// RVA: 0x18512EC
	private bool HasModifiers(IPointerEvent e) { }

	// RVA: 0x18510F4
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

	// RVA: 0x18506B4
	public VisualElement get_target() { }

	// RVA: 0x1851524
	public void set_target(VisualElement value) { }

	// RVA: 0x185049C
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

	// RVA: 0x184FA50
	public static bool HasMouseCapture(IEventHandler handler) { }

	// RVA: 0x185159C
	public static void CaptureMouse(IEventHandler handler) { }

	// RVA: 0x1851674
	public static void ReleaseMouse(IEventHandler handler) { }

}

// Namespace: UnityEngine.UIElements
public abstract class MouseManipulator
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> <activators>k__BackingField; // 0x18
	private ManipulatorActivationFilter m_currentActivator; // 0x20

	// Methods

	// RVA: 0x185174C
	public System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> get_activators() { }

	// RVA: 0x1851754
	private void set_activators(System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> value) { }

	// RVA: 0x185175C
	protected void .ctor() { }

	// RVA: 0x18517E8
	protected bool CanStartManipulation(IMouseEvent e) { }

	// RVA: 0x1851A00
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

	// RVA: 0x1851AD0
	public static IntPtr Create(bool computeBBox) { }

	// RVA: 0x1851B20
	public static void Destroy(IntPtr handle) { }

	// RVA: 0x1851B70
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

	// RVA: 0x1851BC0
	public static MeshWriteDataInterface MakeBorder(NativeBorderParams borderParams, float posZ) { }

	// RVA: 0x1851CA4
	public static MeshWriteDataInterface MakeSolidRect(NativeRectParams rectParams, float posZ) { }

	// RVA: 0x1851D88
	public static MeshWriteDataInterface MakeTexturedRect(NativeRectParams rectParams, float posZ) { }

	// RVA: 0x1851E6C
	public static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage, int settingIndexOffset, int finalVertexCount, int finalIndexCount) { }

	// RVA: 0x185201C
	public static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage, int settingIndexOffset) { }

	// RVA: 0x1851C44
	private static void MakeBorder_Injected(NativeBorderParams borderParams, float posZ, MeshWriteDataInterface ret) { }

	// RVA: 0x1851D28
	private static void MakeSolidRect_Injected(NativeRectParams rectParams, float posZ, MeshWriteDataInterface ret) { }

	// RVA: 0x1851E0C
	private static void MakeTexturedRect_Injected(NativeRectParams rectParams, float posZ, MeshWriteDataInterface ret) { }

	// RVA: 0x1851F50
	private static void MakeVectorGraphicsStretchBackground_Injected(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage, int settingIndexOffset, int finalVertexCount, int finalIndexCount, MeshWriteDataInterface ret) { }

	// RVA: 0x18520E0
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

	// RVA: 0x1852190
	public static void RepaintOverlayPanels() { }

	// RVA: 0x18521F8
	public static void UpdateRuntimePanels() { }

	// RVA: 0x1852260
	public static void RepaintOffscreenPanels() { }

	// RVA: 0x18522C8
	public static void RegisterPlayerloopCallback() { }

	// RVA: 0x1852308
	public static void UnregisterPlayerloopCallback() { }

	// RVA: 0x1852348
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D39B8
	public int get_maxSize() { }

	// RVA: 0x30D4A04
	public void set_maxSize(int value) { }

	// RVA: 0x30D4D3C
	public void .ctor(System.Func<T> CreateFunc, int maxSize) { }

	// RVA: 0x30D39B8
	public int Size() { }

	// RVA: 0x318DB98
	public T Get() { }

	// RVA: 0x318DB98
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

	// RVA: 0x1852388
	public Matrix4x4 get_currentOffset() { }

	// RVA: 0x185239C
	public Rect get_currentWorldClip() { }

	// RVA: 0x18523A8
	public Event get_repaintEvent() { }

	// RVA: 0x18523B0
	public void set_repaintEvent(Event value) { }

	// RVA: 0x18523B8
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class HierarchyEvent
{
	// Methods

	// RVA: 0x185241C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1852540
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

	// RVA: 0x184B8A0
	internal void add_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x184BBA0
	internal void remove_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x1852554
	internal UIElementsBridge get_uiElementsBridge() { }

	// RVA: 0x18525BC
	protected void .ctor() { }

	// RVA: 0x1852714
	public void Dispose() { }

	// RVA: 0x18527A8
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

	// RVA: 0x1852934
	internal float get_scale() { }

	// RVA: 0x184839C
	internal void set_scale(float value) { }

	// RVA: 0x185294C
	internal void set_pixelsPerPoint(float value) { }

	// RVA: 0x185293C
	public float get_scaledPixelsPerPoint() { }

	// RVA: 0x1852A60
	public float get_referenceSpritePixelsPerUnit() { }

	// RVA: 0x1852A68
	public void set_referenceSpritePixelsPerUnit(float value) { }

	// RVA: 0x1852A70
	internal PanelClearSettings get_clearSettings() { }

	// RVA: 0x1852A84
	internal void set_clearSettings(PanelClearSettings value) { }

	// RVA: 0x1852A98
	internal bool get_duringLayoutPhase() { }

	// RVA: 0x1852AA0
	internal void set_duringLayoutPhase(bool value) { }

	// RVA: -1
	internal abstract UInt32 get_version() { }

	// RVA: -1
	internal abstract UInt32 get_hierarchyVersion() { }

	// RVA: -1
	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	// RVA: 0x1852AA8
	internal virtual RepaintData get_repaintData() { }

	// RVA: 0x1852AB0
	internal virtual void set_repaintData(RepaintData value) { }

	// RVA: 0x1852AB8
	internal virtual ICursorManager get_cursorManager() { }

	// RVA: 0x1852AC0
	internal virtual void set_cursorManager(ICursorManager value) { }

	// RVA: 0x1852AC8
	public ContextualMenuManager get_contextualMenuManager() { }

	// RVA: 0x1852AD0
	internal void set_contextualMenuManager(ContextualMenuManager value) { }

	// RVA: -1
	public abstract VisualElement get_visualTree() { }

	// RVA: -1
	public abstract EventDispatcher get_dispatcher() { }

	// RVA: -1
	public abstract void set_dispatcher(EventDispatcher value) { }

	// RVA: 0x1852AD8
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

	// RVA: 0x1852BA8
	internal bool get_disposed() { }

	// RVA: 0x1852BB0
	private void set_disposed(bool value) { }

	// RVA: -1
	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x183D180
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x183BB7C
	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) { }

	// RVA: 0x183F340
	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) { }

	// RVA: 0x1852BB8
	internal void CommitElementUnderPointers() { }

	// RVA: -1
	internal abstract Shader get_standardShader() { }

	// RVA: 0x1852C20
	internal virtual Shader get_standardWorldSpaceShader() { }

	// RVA: 0x1852C28
	internal void add_standardShaderChanged(Action value) { }

	// RVA: 0x1852CCC
	internal void remove_standardShaderChanged(Action value) { }

	// RVA: 0x1852D70
	internal void add_standardWorldSpaceShaderChanged(Action value) { }

	// RVA: 0x1852E14
	internal void remove_standardWorldSpaceShaderChanged(Action value) { }

	// RVA: 0x1852EB8
	internal void add_atlasChanged(Action value) { }

	// RVA: 0x1852F5C
	internal void remove_atlasChanged(Action value) { }

	// RVA: 0x1853000
	protected void InvokeAtlasChanged() { }

	// RVA: -1
	public abstract AtlasBase get_atlas() { }

	// RVA: -1
	public abstract void set_atlas(AtlasBase value) { }

	// RVA: 0x185301C
	internal void InvokeUpdateMaterial(Material mat) { }

	// RVA: 0x1853038
	internal void add_hierarchyChanged(HierarchyEvent value) { }

	// RVA: 0x18530DC
	internal void remove_hierarchyChanged(HierarchyEvent value) { }

	// RVA: 0x1853180
	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	// RVA: 0x185319C
	internal void InvokeBeforeUpdate() { }

	// RVA: 0x18531BC
	internal void UpdateElementUnderPointers() { }

	// RVA: 0x1853544
	private void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x1853548
	private void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x184969C
	public virtual void Update() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class LoadResourceFunction
{
	// Methods

	// RVA: 0x185354C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1853608
	public virtual object Invoke(string pathName, Type type, float dpiScaling) { }

}

// Namespace: UnityEngine.UIElements
internal sealed class TimeMsFunction
{
	// Methods

	// RVA: 0x185361C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18536BC
	public virtual Int64 Invoke() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class GetViewDataDictionary
{
	// Methods

	// RVA: 0x18536D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1853770
	public virtual ISerializableJsonDictionary Invoke() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class SavePersistentViewData
{
	// Methods

	// RVA: 0x1853784
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1853824
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

	// RVA: 0x1853838
	public sealed override VisualElement get_visualTree() { }

	// RVA: 0x1853840
	public sealed override EventDispatcher get_dispatcher() { }

	// RVA: 0x1853848
	public sealed override void set_dispatcher(EventDispatcher value) { }

	// RVA: 0x1853858
	public TimerEventScheduler get_timerEventScheduler() { }

	// RVA: 0x18538E8
	internal override IScheduler get_scheduler() { }

	// RVA: 0x1853978
	internal override IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	// RVA: 0x1853980
	internal override void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	// RVA: 0x1853A58
	public override ScriptableObject get_ownerObject() { }

	// RVA: 0x1853A60
	protected override void set_ownerObject(ScriptableObject value) { }

	// RVA: 0x1853A70
	public override ContextType get_contextType() { }

	// RVA: 0x1853A78
	protected override void set_contextType(ContextType value) { }

	// RVA: 0x1853A80
	public override SavePersistentViewData get_saveViewData() { }

	// RVA: 0x1853A88
	public override GetViewDataDictionary get_getViewDataDictionary() { }

	// RVA: 0x1853A90
	public sealed override FocusController get_focusController() { }

	// RVA: 0x1853A98
	public sealed override void set_focusController(FocusController value) { }

	// RVA: 0x1853AA8
	public override EventInterests get_IMGUIEventInterests() { }

	// RVA: 0x1853AB8
	public override void set_IMGUIEventInterests(EventInterests value) { }

	// RVA: 0x1853AC8
	private static LoadResourceFunction get_loadResourceFunc() { }

	// RVA: 0x1853B44
	internal static object LoadResource(string pathName, Type type, float dpiScaling) { }

	// RVA: 0x1853CC4
	internal void Focus() { }

	// RVA: 0x1853CD0
	internal void Blur() { }

	// RVA: 0x1853D90
	public override void ValidateFocus() { }

	// RVA: 0x1853E3C
	internal string get_name() { }

	// RVA: 0x18495B4
	internal void set_name(string value) { }

	// RVA: 0x1853E44
	private void CreateMarkers() { }

	// RVA: 0x185409C
	private static TimeMsFunction get_TimeSinceStartup() { }

	// RVA: 0x1854118
	public override int get_IMGUIContainersCount() { }

	// RVA: 0x1854120
	public override void set_IMGUIContainersCount(int value) { }

	// RVA: 0x1854128
	public override IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0x1854130
	internal override UInt32 get_version() { }

	// RVA: 0x1854138
	internal override UInt32 get_hierarchyVersion() { }

	// RVA: 0x1854140
	internal override Shader get_standardShader() { }

	// RVA: 0x1854148
	public override AtlasBase get_atlas() { }

	// RVA: 0x1854150
	public override void set_atlas(AtlasBase value) { }

	// RVA: 0x18541E0
	public void .ctor(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) { }

	// RVA: 0x18545E8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1854654
	public static Int64 TimeSinceStartupMs() { }

	// RVA: 0x1854764
	internal static Int64 DefaultTimeSinceStartupMs() { }

	// RVA: 0x18547A0
	private static VisualElement PickAll(VisualElement root, Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked, bool includeIgnoredElement) { }

	// RVA: 0x1854864
	private static VisualElement PerformPick(VisualElement root, Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked, bool includeIgnoredElement) { }

	// RVA: 0x1854B80
	public override VisualElement PickAll(Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked) { }

	// RVA: 0x1854D14
	public override VisualElement Pick(Vector2 point) { }

	// RVA: 0x1855138
	public override void ValidateLayout() { }

	// RVA: 0x18551CC
	public override void UpdateAnimations() { }

	// RVA: 0x1855214
	public override void UpdateBindings() { }

	// RVA: 0x185525C
	public override void ApplyStyles() { }

	// RVA: 0x1855280
	private void UpdateForRepaint() { }

	// RVA: 0x1855300
	public override void Repaint(Event e) { }

	// RVA: 0x18555DC
	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x185562C
	internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x185564C
	private static void .cctor() { }

	// RVA: 0x185504C
	internal static Vector2Int <Pick>g__PixelOf|101_0(Vector2 p) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.BaseRuntimePanel.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1870468
	private static void .cctor() { }

	// RVA: 0x18704D4
	public void .ctor() { }

	// RVA: 0x18704DC
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

	// RVA: 0x186EFBC
	public GameObject get_selectableGameObject() { }

	// RVA: 0x186EFC4
	public void set_selectableGameObject(GameObject value) { }

	// RVA: 0x186F468
	public float get_sortingPriority() { }

	// RVA: 0x186F470
	public void set_sortingPriority(float value) { }

	// RVA: 0x186F588
	public void add_destroyed(Action value) { }

	// RVA: 0x186F630
	public void remove_destroyed(Action value) { }

	// RVA: 0x186F6D8
	protected void .ctor(ScriptableObject ownerObject, EventDispatcher dispatcher) { }

	// RVA: 0x186F80C
	protected override void Dispose(bool disposing) { }

	// RVA: 0x186F868
	internal override Shader get_standardWorldSpaceShader() { }

	// RVA: 0x186F870
	internal bool get_drawToCameras() { }

	// RVA: 0x186F878
	internal void set_drawToCameras(bool value) { }

	// RVA: 0x186F9EC
	internal int get_targetDisplay() { }

	// RVA: 0x186F9F4
	internal void set_targetDisplay(int value) { }

	// RVA: 0x186F9FC
	internal int get_screenRenderingWidth() { }

	// RVA: 0x186FB48
	internal int get_screenRenderingHeight() { }

	// RVA: 0x186FBD0
	internal static int getScreenRenderingHeight(int display) { }

	// RVA: 0x186FA84
	internal static int getScreenRenderingWidth(int display) { }

	// RVA: 0x186FC94
	public override void Repaint(Event e) { }

	// RVA: 0x186FF54
	public System.Func<UnityEngine.Vector2,UnityEngine.Vector2> get_screenToPanelSpace() { }

	// RVA: 0x186FF5C
	public void set_screenToPanelSpace(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> value) { }

	// RVA: 0x186FFF8
	internal Vector2 ScreenToPanel(Vector2 screen) { }

	// RVA: 0x1870068
	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, Vector2 panelPosition, Vector2 panelDelta, bool allowOutside) { }

	// RVA: 0x186F098
	private void AssignPanelToComponents(BaseRuntimePanel panel) { }

	// RVA: 0x1870230
	internal void PointerLeavesPanel(int pointerId, Vector2 position) { }

	// RVA: 0x18702F0
	internal void PointerEntersPanel(int pointerId, Vector2 position) { }

	// RVA: 0x1870390
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

	// RVA: 0x18704E0
	private static PointerDispatchState GetStateFor(IEventHandler handler) { }

	// RVA: 0x1870610
	public static bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0x18706A0
	public static void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x1870838
	public static void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x1870904
	public static IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	// RVA: 0x1870A48
	public static void ReleasePointer(IPanel panel, int pointerId) { }

	// RVA: 0x1870B80
	internal static void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	// RVA: 0x1870CB8
	internal static void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	// RVA: 0x1870DE8
	internal static bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	// RVA: 0x187115C
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

	// RVA: 0x1871B14
	public void .ctor() { }

	// RVA: 0x1871C14
	internal void Reset() { }

	// RVA: 0x1870A14
	public IEventHandler GetCapturingElement(int pointerId) { }

	// RVA: 0x1870664
	public bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0x18706DC
	public void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x1870B48
	public void ReleasePointer(int pointerId) { }

	// RVA: 0x18708AC
	public void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x187123C
	public void ProcessPointerCapture(int pointerId) { }

	// RVA: 0x1870C80
	public void ActivateCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x1870DB4
	public void PreventCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x1870FFC
	public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

// Namespace: UnityEngine.UIElements
public abstract class PointerManipulator
{
	// Fields
	private int m_CurrentPointerId; // 0x2C

	// Methods

	// RVA: 0x1871CDC
	protected bool CanStartManipulation(IPointerEvent e) { }

	// RVA: 0x1871F6C
	protected bool CanStopManipulation(IPointerEvent e) { }

	// RVA: 0x1872038
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class ProjectionUtils
{
	// Methods

	// RVA: 0x1872040
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far) { }

}

// Namespace: UnityEngine.UIElements
internal struct SafeHandleAccess
{
	// Fields
	private IntPtr m_Handle; // 0x10

	// Methods

	// RVA: 0x18720B0
	public void .ctor(IntPtr ptr) { }

	// RVA: 0x18720B8
	public bool IsNull() { }

	// RVA: 0x18720C8
	public static IntPtr op_Implicit(SafeHandleAccess a) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIRAtlasAllocator.Row.<>c <>9; // 0x0

	// Methods

	// RVA: 0x187356C
	private static void .cctor() { }

	// RVA: 0x18735D8
	public void .ctor() { }

	// RVA: 0x18735E0
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

	// RVA: 0x187340C
	public int get_offsetX() { }

	// RVA: 0x1873414
	private void set_offsetX(int value) { }

	// RVA: 0x187341C
	public int get_offsetY() { }

	// RVA: 0x1873424
	private void set_offsetY(int value) { }

	// RVA: 0x187342C
	public int get_width() { }

	// RVA: 0x1873434
	private void set_width(int value) { }

	// RVA: 0x187343C
	private void set_height(int value) { }

	// RVA: 0x1873154
	public static Row Acquire(int offsetX, int offsetY, int width, int height) { }

	// RVA: 0x18723E0
	public void Release() { }

	// RVA: 0x1873444
	public void .ctor() { }

	// RVA: 0x187344C
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIRAtlasAllocator.AreaNode.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1873760
	private static void .cctor() { }

	// RVA: 0x18737CC
	public void .ctor() { }

	// RVA: 0x18737D4
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

	// RVA: 0x187286C
	public static AreaNode Acquire(RectInt rect) { }

	// RVA: 0x1872494
	public void Release() { }

	// RVA: 0x1873230
	public void RemoveFromChain() { }

	// RVA: 0x1873294
	public void AddAfter(AreaNode previous) { }

	// RVA: 0x1873638
	public void .ctor() { }

	// RVA: 0x1873640
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

	// RVA: 0x187212C
	public int get_maxAtlasSize() { }

	// RVA: 0x1872134
	public int get_maxImageWidth() { }

	// RVA: 0x187213C
	public int get_maxImageHeight() { }

	// RVA: 0x1872144
	public int get_virtualWidth() { }

	// RVA: 0x187214C
	private void set_virtualWidth(int value) { }

	// RVA: 0x1872154
	public int get_virtualHeight() { }

	// RVA: 0x187215C
	private void set_virtualHeight(int value) { }

	// RVA: 0x1872164
	public int get_physicalWidth() { }

	// RVA: 0x187216C
	private void set_physicalWidth(int value) { }

	// RVA: 0x1872174
	public int get_physicalHeight() { }

	// RVA: 0x187217C
	private void set_physicalHeight(int value) { }

	// RVA: 0x1872184
	protected bool get_disposed() { }

	// RVA: 0x187218C
	private void set_disposed(bool value) { }

	// RVA: 0x1872194
	public void Dispose() { }

	// RVA: 0x1872224
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1872538
	private static int GetLog2OfNextPower(int n) { }

	// RVA: 0x18726BC
	public void .ctor(int initialAtlasSize, int maxAtlasSize, int sidePadding) { }

	// RVA: 0x1872A58
	public bool TryAllocate(int width, int height, RectInt location) { }

	// RVA: 0x1872E78
	private bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) { }

	// RVA: 0x1872954
	private void BuildAreas() { }

	// RVA: 0x187338C
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

	// RVA: 0x187382C
	public TextureId get_textureId() { }

	// RVA: 0x1873834
	private void set_textureId(TextureId value) { }

	// RVA: 0x187383C
	public RenderTexture get_atlas() { }

	// RVA: 0x1873844
	private void set_atlas(RenderTexture value) { }

	// RVA: 0x187384C
	public RenderTextureFormat get_format() { }

	// RVA: 0x1873854
	public FilterMode get_filterMode() { }

	// RVA: 0x187385C
	public void .ctor(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize) { }

	// RVA: 0x18739FC
	protected bool get_disposed() { }

	// RVA: 0x1873A04
	private void set_disposed(bool value) { }

	// RVA: 0x1873A0C
	public void Dispose() { }

	// RVA: 0x1873A9C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1874160
	public bool TryAdd(Texture2D image, Alloc2D alloc, RectInt rect) { }

	// RVA: 0x18744A8
	public void Update(Texture2D image, RectInt rect) { }

	// RVA: 0x18745F4
	public void Remove(Alloc2D alloc) { }

	// RVA: 0x18746E8
	public void Commit() { }

	// RVA: 0x187473C
	private void UpdateAtlasTexture() { }

	// RVA: 0x1874B4C
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

	// RVA: 0x1874C80
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x1874CFC
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x1874D54
	public override void Update() { }

	// RVA: 0x187507C
	private void UpdateSubTree(VisualElement ve, bool isDisplayed, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents) { }

	// RVA: 0x18757C0
	private void DispatchChangeEvents(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents, int currentLayoutPass) { }

	// RVA: 0x1875C8C
	public void .ctor() { }

	// RVA: 0x1875D18
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

	// RVA: 0x1875DC0
	internal void .ctor() { }

	// RVA: 0x1875DC8
	public int get_vertexCount() { }

	// RVA: 0x1875E1C
	public int get_indexCount() { }

	// RVA: 0x1875E70
	public Rect get_uvRegion() { }

	// RVA: 0x1875E7C
	public void SetNextVertex(Vertex vertex) { }

	// RVA: 0x1875F00
	public void SetNextIndex(UInt16 index) { }

	// RVA: 0x1875F78
	public void SetAllVertices(Vertex[] vertices) { }

	// RVA: 0x1876050
	public void SetAllIndices(UInt16[] indices) { }

	// RVA: 0x1876128
	internal void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices) { }

	// RVA: 0x1876144
	internal void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, Rect uvRegion) { }

}

// Namespace: UnityEngine.UIElements
internal struct ColorPage
{
	// Fields
	public bool isValid; // 0x10
	public Color32 pageAndID; // 0x14

	// Methods

	// RVA: 0x187615C
	public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc) { }

	// RVA: 0x1876254
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

	// RVA: 0x1876B80
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

	// RVA: 0x1876BF0
	private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, Rect rectOut, Rect uvOut) { }

	// RVA: 0x1876D98
	private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, Rect rectOut, Rect uvOut) { }

	// RVA: 0x18770D4
	internal static Rect RectIntersection(Rect a, Rect b) { }

	// RVA: 0x18771B0
	private static Rect ComputeGeomRect(Sprite sprite) { }

	// RVA: 0x1877260
	private static Rect ComputeUVRect(Sprite sprite) { }

	// RVA: 0x1877310
	private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation) { }

	// RVA: 0x1877368
	public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, ContextType panelContext) { }

	// RVA: 0x1877544
	public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, ContextType panelContext, bool hasRadius, Vector4 slices, bool useForRepeat) { }

	// RVA: 0x1877F90
	public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, ContextType panelContext) { }

	// RVA: 0x1878120
	internal bool HasRadius(float epsilon) { }

	// RVA: 0x18781A4
	internal bool HasSlices(float epsilon) { }

	// RVA: 0x18781F0
	internal NativeRectParams ToNativeParams(Rect uvRegion) { }

}

// Namespace: UnityEngine.UIElements
internal static class MeshGenerationContextUtils
{
	// Methods

	// RVA: 0x1876264
	public static void Rectangle(MeshGenerationContext mgc, RectangleParams rectParams) { }

	// RVA: 0x1876358
	public static void Text(MeshGenerationContext mgc, TextElement te) { }

	// RVA: 0x1876430
	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) { }

	// RVA: 0x187646C
	public static void GetVisualElementRadii(VisualElement ve, Vector2 topLeft, Vector2 bottomLeft, Vector2 topRight, Vector2 bottomRight) { }

	// RVA: 0x18766F4
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

	// RVA: 0x1878274
	public Painter2D get_painter2D() { }

	// RVA: 0x18783AC
	internal bool get_hasPainter2D() { }

	// RVA: 0x18783BC
	internal void .ctor(IStylePainter painter) { }

	// RVA: 0x18783F0
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

	// RVA: 0x1878310
	internal void .ctor(MeshGenerationContext ctx) { }

	// RVA: 0x18784A8
	internal void Reset() { }

	// RVA: 0x1878514
	public void Dispose() { }

	// RVA: 0x18785B4
	private void Dispose(bool disposing) { }

	// RVA: 0x1878670
	internal static void set_isPainterActive(bool value) { }

	// RVA: 0x18786FC
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

	// RVA: 0x18787C4
	public void .ctor() { }

	// RVA: 0x1878858
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x18788D4
	public bool get_drawStats() { }

	// RVA: 0x18788DC
	public bool get_breakBatches() { }

	// RVA: 0x18788E4
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x18789E0
	public override void Update() { }

	// RVA: 0x1878B78
	protected virtual RenderChain CreateRenderChain() { }

	// RVA: 0x1878BF0
	private static void .cctor() { }

	// RVA: 0x1878D10
	private static void OnGraphicsResourcesRecreate(bool recreate) { }

	// RVA: 0x1879198
	private void OnPanelChanged(BaseVisualElementPanel obj) { }

	// RVA: 0x18793BC
	private void AttachToPanel() { }

	// RVA: 0x18791BC
	private void DetachFromPanel() { }

	// RVA: 0x1878AAC
	private void InitRenderChain() { }

	// RVA: 0x186F97C
	internal void DestroyRenderChain() { }

	// RVA: 0x18799E4
	private void OnPanelAtlasChanged() { }

	// RVA: 0x1879A54
	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	// RVA: 0x18795C0
	private void OnPanelStandardShaderChanged() { }

	// RVA: 0x1879774
	private void OnPanelStandardWorldSpaceShaderChanged() { }

	// RVA: 0x1879928
	private void ResetAllElementsDataRecursive(VisualElement ve) { }

	// RVA: 0x1879A8C
	protected bool get_disposed() { }

	// RVA: 0x1879A94
	private void set_disposed(bool value) { }

	// RVA: 0x1879A9C
	protected override void Dispose(bool disposing) { }

}

// Namespace: UnityEngine.UIElements
internal struct TextureId
{
	// Fields
	private readonly int m_Index; // 0x10
	public static readonly TextureId invalid; // 0x0

	// Methods

	// RVA: 0x1879AE0
	public void .ctor(int index) { }

	// RVA: 0x1879AEC
	public int get_index() { }

	// RVA: 0x1879AF8
	public float ConvertToGpu() { }

	// RVA: 0x1879B60
	public override bool Equals(object obj) { }

	// RVA: 0x1879C30
	public override int GetHashCode() { }

	// RVA: 0x1879C38
	public static bool op_Equality(TextureId left, TextureId right) { }

	// RVA: 0x1879C44
	public static bool op_Inequality(TextureId left, TextureId right) { }

	// RVA: 0x1879CD0
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

	// RVA: 0x1879D1C
	public static TextureRegistry get_instance() { }

	// RVA: 0x1879D98
	public Texture GetTexture(TextureId id) { }

	// RVA: 0x18739F0
	public TextureId AllocAndAcquireDynamic() { }

	// RVA: 0x187A240
	public void UpdateDynamic(TextureId id, Texture texture) { }

	// RVA: 0x1879FB0
	private TextureId AllocAndAcquire(Texture texture, bool dynamic) { }

	// RVA: 0x187A4E8
	public TextureId Acquire(Texture tex) { }

	// RVA: 0x1873E80
	public void Release(TextureId id) { }

	// RVA: 0x187A66C
	public void .ctor() { }

	// RVA: 0x187A7A8
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIRUtility
{
	// Fields
	public static readonly string k_DefaultShaderName; // 0x0
	public static readonly string k_DefaultWorldSpaceShaderName; // 0x8

	// Methods

	// RVA: 0x187A810
	public static bool ShapeWindingIsClockwise(int maskDepth, int stencilRef) { }

	// RVA: 0x187A890
	public static bool IsRoundRect(VisualElement ve) { }

	// RVA: 0x187AAC0
	public static bool IsVectorImageBackground(VisualElement ve) { }

	// RVA: 0x187AB58
	public static bool IsElementSelfHidden(VisualElement ve) { }

	// RVA: 0x1873D2C
	public static void Destroy(object obj) { }

	// RVA: 0x187AC1C
	public static int GetPrevPow2(int n) { }

	// RVA: 0x187448C
	public static int GetNextPow2(int n) { }

	// RVA: 0x187AC5C
	public static int GetNextPow2Exp(int n) { }

	// RVA: 0x187AC8C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public struct TimerState
{
	// Fields
	private Int64 <start>k__BackingField; // 0x10
	private Int64 <now>k__BackingField; // 0x18

	// Methods

	// RVA: 0x187AD2C
	public Int64 get_start() { }

	// RVA: 0x187AD34
	public void set_start(Int64 value) { }

	// RVA: 0x187AD3C
	public Int64 get_now() { }

	// RVA: 0x187AD44
	public void set_now(Int64 value) { }

	// RVA: 0x187AD4C
	public Int64 get_deltaTime() { }

	// RVA: 0x187AD58
	public override bool Equals(object obj) { }

	// RVA: 0x187ADF8
	public bool Equals(TimerState other) { }

	// RVA: 0x187AE1C
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

	// RVA: 0x187B1C4
	private static void .cctor() { }

	// RVA: 0x187B230
	public void .ctor() { }

	// RVA: 0x187B238
	internal bool <.cctor>b__25_0() { }

	// RVA: 0x187B240
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

	// RVA: 0x187AEAC
	public Int64 get_startMs() { }

	// RVA: 0x187AEB4
	public void set_startMs(Int64 value) { }

	// RVA: 0x187AEBC
	public Int64 get_delayMs() { }

	// RVA: 0x187AEC4
	public void set_delayMs(Int64 value) { }

	// RVA: 0x187AECC
	public Int64 get_intervalMs() { }

	// RVA: 0x187AED4
	public void set_intervalMs(Int64 value) { }

	// RVA: 0x187AEDC
	public Int64 get_endTimeMs() { }

	// RVA: 0x187AEE4
	public void .ctor() { }

	// RVA: 0x187AFD4
	protected void ResetStartTime() { }

	// RVA: -1
	public abstract void PerformTimerUpdate(TimerState state) { }

	// RVA: 0x187B03C
	internal virtual void OnItemUnscheduled() { }

	// RVA: 0x187B040
	public virtual bool ShouldUnschedule() { }

	// RVA: 0x187B090
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

	// RVA: 0x187B248
	public void Schedule(ScheduledItem item) { }

	// RVA: 0x187B3D0
	private bool RemovedScheduledItemAt(int index) { }

	// RVA: 0x187B458
	public void Unschedule(ScheduledItem item) { }

	// RVA: 0x187B5F8
	private bool PrivateUnSchedule(ScheduledItem sItem) { }

	// RVA: 0x187B6FC
	public void UpdateScheduledEvents() { }

	// RVA: 0x187BA18
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

	// RVA: 0x187BB28
	public float get_horizontal() { }

	// RVA: 0x187BB38
	public float get_vertical() { }

	// RVA: 0x187BB48
	public void .ctor(float left, float top, float right, float bottom) { }

	// RVA: 0x187BB54
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

	// RVA: 0x187BB84
	internal static Angle None() { }

	// RVA: 0x187BB98
	public float get_value() { }

	// RVA: 0x187BBA0
	public void .ctor(float value, AngleUnit unit) { }

	// RVA: 0x187BB8C
	private void .ctor(float value, Unit unit) { }

	// RVA: 0x187BBAC
	public float ToDegrees() { }

	// RVA: 0x187BC38
	public static Angle op_Implicit(float value) { }

	// RVA: 0x187BC40
	public static bool op_Equality(Angle lhs, Angle rhs) { }

	// RVA: 0x187BC60
	public bool Equals(Angle other) { }

	// RVA: 0x187BC80
	public override bool Equals(object obj) { }

	// RVA: 0x187BD1C
	public override int GetHashCode() { }

	// RVA: 0x187BD50
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

	// RVA: 0x187BF50
	public Texture2D get_texture() { }

	// RVA: 0x187BF58
	public void set_texture(Texture2D value) { }

	// RVA: 0x187C040
	public Sprite get_sprite() { }

	// RVA: 0x187C048
	public void set_sprite(Sprite value) { }

	// RVA: 0x187C144
	public RenderTexture get_renderTexture() { }

	// RVA: 0x187C14C
	public void set_renderTexture(RenderTexture value) { }

	// RVA: 0x187AB50
	public VectorImage get_vectorImage() { }

	// RVA: 0x187C248
	public void set_vectorImage(VectorImage value) { }

	// RVA: 0x187C344
	public static Background FromTexture2D(Texture2D t) { }

	// RVA: 0x187C384
	public static Background FromRenderTexture(RenderTexture rt) { }

	// RVA: 0x187C3C4
	public static Background FromSprite(Sprite s) { }

	// RVA: 0x187C404
	public static Background FromVectorImage(VectorImage vi) { }

	// RVA: 0x187C444
	internal static Background FromObject(object obj) { }

	// RVA: 0x187C70C
	public static bool op_Equality(Background lhs, Background rhs) { }

	// RVA: 0x187C87C
	public static bool op_Inequality(Background lhs, Background rhs) { }

	// RVA: 0x187C8B4
	public bool Equals(Background other) { }

	// RVA: 0x187C8E8
	public override bool Equals(object obj) { }

	// RVA: 0x187C990
	public override int GetHashCode() { }

	// RVA: 0x187CA44
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

	// RVA: 0x18556CC
	public int get_customPropertiesCount() { }

	// RVA: 0x1855728
	public bool get_hasTransition() { }

	// RVA: 0x1855748
	public void FinalizeApply(ComputedStyle parentStyle) { }

	// RVA: 0x1855970
	public void SyncWithLayout(YogaNode targetNode) { }

	// RVA: 0x1856EE0
	private bool ApplyGlobalKeyword(StylePropertyReader reader, ComputedStyle parentStyle) { }

	// RVA: 0x18570B8
	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ComputedStyle parentStyle) { }

	// RVA: 0x18592EC
	private void RemoveCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x18593A4
	private void ApplyCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x18594AC
	private void ApplyAllPropertyInitial() { }

	// RVA: 0x1859680
	private void ResetComputedTransitions() { }

	// RVA: 0x185968C
	public static bool StartAnimationInlineTranslate(VisualElement element, ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1856D14
	public Align get_alignContent() { }

	// RVA: 0x1856D70
	public Align get_alignItems() { }

	// RVA: 0x1856AEC
	public Align get_alignSelf() { }

	// RVA: 0x1859894
	public Color get_backgroundColor() { }

	// RVA: 0x18598F4
	public Background get_backgroundImage() { }

	// RVA: 0x1859958
	public BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x18599BC
	public BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x1859A20
	public BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x1859A7C
	public BackgroundSize get_backgroundSize() { }

	// RVA: 0x1859AE8
	public Color get_borderBottomColor() { }

	// RVA: 0x1859B48
	public Length get_borderBottomLeftRadius() { }

	// RVA: 0x1859BA4
	public Length get_borderBottomRightRadius() { }

	// RVA: 0x1856920
	public float get_borderBottomWidth() { }

	// RVA: 0x1859C00
	public Color get_borderLeftColor() { }

	// RVA: 0x185680C
	public float get_borderLeftWidth() { }

	// RVA: 0x1859C60
	public Color get_borderRightColor() { }

	// RVA: 0x18568C4
	public float get_borderRightWidth() { }

	// RVA: 0x1859CC0
	public Color get_borderTopColor() { }

	// RVA: 0x1859D20
	public Length get_borderTopLeftRadius() { }

	// RVA: 0x1859D7C
	public Length get_borderTopRightRadius() { }

	// RVA: 0x1856868
	public float get_borderTopWidth() { }

	// RVA: 0x18564D0
	public Length get_bottom() { }

	// RVA: 0x1859DD8
	public Color get_color() { }

	// RVA: 0x1859E38
	public Cursor get_cursor() { }

	// RVA: 0x1856E84
	public DisplayStyle get_display() { }

	// RVA: 0x1856360
	public Length get_flexBasis() { }

	// RVA: 0x1856CB8
	public FlexDirection get_flexDirection() { }

	// RVA: 0x18562A8
	public float get_flexGrow() { }

	// RVA: 0x1856304
	public float get_flexShrink() { }

	// RVA: 0x1856E28
	public Wrap get_flexWrap() { }

	// RVA: 0x1855914
	public Length get_fontSize() { }

	// RVA: 0x18569D8
	public Length get_height() { }

	// RVA: 0x1856DCC
	public Justify get_justifyContent() { }

	// RVA: 0x18563BC
	public Length get_left() { }

	// RVA: 0x1859EA4
	public Length get_letterSpacing() { }

	// RVA: 0x1856640
	public Length get_marginBottom() { }

	// RVA: 0x185652C
	public Length get_marginLeft() { }

	// RVA: 0x18565E4
	public Length get_marginRight() { }

	// RVA: 0x1856588
	public Length get_marginTop() { }

	// RVA: 0x1856BA4
	public Length get_maxHeight() { }

	// RVA: 0x1856B48
	public Length get_maxWidth() { }

	// RVA: 0x1856C5C
	public Length get_minHeight() { }

	// RVA: 0x1856C00
	public Length get_minWidth() { }

	// RVA: 0x1859F00
	public float get_opacity() { }

	// RVA: 0x1856A90
	public OverflowInternal get_overflow() { }

	// RVA: 0x18567B0
	public Length get_paddingBottom() { }

	// RVA: 0x185669C
	public Length get_paddingLeft() { }

	// RVA: 0x1856754
	public Length get_paddingRight() { }

	// RVA: 0x18566F8
	public Length get_paddingTop() { }

	// RVA: 0x1856A34
	public Position get_position() { }

	// RVA: 0x1856474
	public Length get_right() { }

	// RVA: 0x1859F5C
	public Rotate get_rotate() { }

	// RVA: 0x1859FC8
	public Scale get_scale() { }

	// RVA: 0x185A028
	public TextOverflow get_textOverflow() { }

	// RVA: 0x185A084
	public TextShadow get_textShadow() { }

	// RVA: 0x1856418
	public Length get_top() { }

	// RVA: 0x185A0F0
	public TransformOrigin get_transformOrigin() { }

	// RVA: 0x185A15C
	public System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay() { }

	// RVA: 0x185A1B8
	public System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration() { }

	// RVA: 0x185A214
	public System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty() { }

	// RVA: 0x185A270
	public System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x185A2CC
	public Translate get_translate() { }

	// RVA: 0x185A338
	public Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x185A398
	public Font get_unityFont() { }

	// RVA: 0x185A3F4
	public FontDefinition get_unityFontDefinition() { }

	// RVA: 0x185A454
	public FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x185A4B0
	public OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x185A50C
	public Length get_unityParagraphSpacing() { }

	// RVA: 0x185A568
	public int get_unitySliceBottom() { }

	// RVA: 0x185A5C4
	public int get_unitySliceLeft() { }

	// RVA: 0x185A620
	public int get_unitySliceRight() { }

	// RVA: 0x185A67C
	public float get_unitySliceScale() { }

	// RVA: 0x185A6D8
	public int get_unitySliceTop() { }

	// RVA: 0x185A734
	public TextAnchor get_unityTextAlign() { }

	// RVA: 0x185A790
	public Color get_unityTextOutlineColor() { }

	// RVA: 0x185A7F0
	public float get_unityTextOutlineWidth() { }

	// RVA: 0x185A84C
	public TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x185A8A8
	public Visibility get_visibility() { }

	// RVA: 0x185A904
	public WhiteSpace get_whiteSpace() { }

	// RVA: 0x185697C
	public Length get_width() { }

	// RVA: 0x185A960
	public Length get_wordSpacing() { }

	// RVA: 0x185A9BC
	public static ComputedStyle Create(ComputedStyle parentStyle) { }

	// RVA: 0x185ABC4
	public static ComputedStyle CreateInitial() { }

	// RVA: 0x185AD80
	public ComputedStyle Acquire() { }

	// RVA: 0x185AEB4
	public void Release() { }

	// RVA: 0x1859518
	public void CopyFrom(ComputedStyle other) { }

	// RVA: 0x185AFB8
	public void ApplyProperties(StylePropertyReader reader, ComputedStyle parentStyle) { }

	// RVA: 0x185C3B8
	public void ApplyStyleValue(StyleValue sv, ComputedStyle parentStyle) { }

	// RVA: 0x185D228
	public void ApplyStyleValueManaged(StyleValueManaged sv, ComputedStyle parentStyle) { }

	// RVA: 0x185D69C
	public void ApplyStyleCursor(Cursor cursor) { }

	// RVA: 0x185D70C
	public void ApplyStyleTextShadow(TextShadow st) { }

	// RVA: 0x185D780
	public void ApplyFromComputedStyle(StylePropertyId id, ComputedStyle other) { }

	// RVA: 0x185F008
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) { }

	// RVA: 0x185F7E4
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) { }

	// RVA: 0x185FB38
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) { }

	// RVA: 0x186033C
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue) { }

	// RVA: 0x186054C
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue) { }

	// RVA: 0x18606E0
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue) { }

	// RVA: 0x1860830
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue) { }

	// RVA: 0x1860AE8
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) { }

	// RVA: 0x1860C8C
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) { }

	// RVA: 0x1860E60
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) { }

	// RVA: 0x1861004
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) { }

	// RVA: 0x186115C
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) { }

	// RVA: 0x18612AC
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) { }

	// RVA: 0x18613FC
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) { }

	// RVA: 0x1861544
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) { }

	// RVA: 0x186168C
	public static bool StartAnimation(VisualElement element, StylePropertyId id, ComputedStyle oldStyle, ComputedStyle newStyle, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186565C
	public static bool StartAnimationAllProperty(VisualElement element, ComputedStyle oldStyle, ComputedStyle newStyle, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18695D4
	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x186C7D8
	public void ApplyStyleTransformOrigin(TransformOrigin st) { }

	// RVA: 0x186C844
	public void ApplyStyleTranslate(Translate translateValue) { }

	// RVA: 0x186C8B0
	public void ApplyStyleRotate(Rotate rotateValue) { }

	// RVA: 0x186C91C
	public void ApplyStyleScale(Scale scaleValue) { }

	// RVA: 0x186C988
	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue) { }

	// RVA: 0x1856FD8
	public void ApplyInitialValue(StylePropertyReader reader) { }

	// RVA: 0x18570E8
	public void ApplyInitialValue(StylePropertyId id) { }

	// RVA: 0x1857088
	public void ApplyUnsetValue(StylePropertyReader reader, ComputedStyle parentStyle) { }

	// RVA: 0x186C9F4
	public void ApplyUnsetValue(StylePropertyId id, ComputedStyle parentStyle) { }

	// RVA: 0x186D000
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

	// RVA: 0x187EC74
	private static void .cctor() { }

	// RVA: 0x187ECE0
	public void .ctor() { }

	// RVA: 0x187ECE8
	internal float <ConvertTransitionFunction>b__12_0(float t) { }

	// RVA: 0x187ED24
	internal float <ConvertTransitionFunction>b__12_1(float t) { }

	// RVA: 0x187ED2C
	internal float <ConvertTransitionFunction>b__12_2(float t) { }

	// RVA: 0x187ED34
	internal float <ConvertTransitionFunction>b__12_3(float t) { }

	// RVA: 0x187ED3C
	internal float <ConvertTransitionFunction>b__12_4(float t) { }

	// RVA: 0x187ED44
	internal float <ConvertTransitionFunction>b__12_5(float t) { }

	// RVA: 0x187ED4C
	internal float <ConvertTransitionFunction>b__12_6(float t) { }

	// RVA: 0x187ED54
	internal float <ConvertTransitionFunction>b__12_7(float t) { }

	// RVA: 0x187ED5C
	internal float <ConvertTransitionFunction>b__12_8(float t) { }

	// RVA: 0x187ED64
	internal float <ConvertTransitionFunction>b__12_9(float t) { }

	// RVA: 0x187ED6C
	internal float <ConvertTransitionFunction>b__12_10(float t) { }

	// RVA: 0x187ED74
	internal float <ConvertTransitionFunction>b__12_11(float t) { }

	// RVA: 0x187ED7C
	internal float <ConvertTransitionFunction>b__12_12(float t) { }

	// RVA: 0x187ED84
	internal float <ConvertTransitionFunction>b__12_13(float t) { }

	// RVA: 0x187ED8C
	internal float <ConvertTransitionFunction>b__12_14(float t) { }

	// RVA: 0x187ED94
	internal float <ConvertTransitionFunction>b__12_15(float t) { }

	// RVA: 0x187ED9C
	internal float <ConvertTransitionFunction>b__12_16(float t) { }

	// RVA: 0x187EDA4
	internal float <ConvertTransitionFunction>b__12_17(float t) { }

	// RVA: 0x187EDAC
	internal float <ConvertTransitionFunction>b__12_18(float t) { }

	// RVA: 0x187EDB4
	internal float <ConvertTransitionFunction>b__12_19(float t) { }

	// RVA: 0x187EDBC
	internal float <ConvertTransitionFunction>b__12_20(float t) { }

	// RVA: 0x187EDC4
	internal float <ConvertTransitionFunction>b__12_21(float t) { }

	// RVA: 0x187EDCC
	internal float <ConvertTransitionFunction>b__12_22(float t) { }

}

// Namespace: UnityEngine.UIElements
internal static class ComputedTransitionUtils
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> s_ComputedTransitionsBuffer; // 0x0

	// Methods

	// RVA: 0x187CBEC
	internal static void UpdateComputedTransitions(ComputedStyle computedStyle) { }

	// RVA: 0x187CEB4
	internal static bool HasTransitionProperty(ComputedStyle computedStyle, StylePropertyId id) { }

	// RVA: 0x187CF8C
	internal static bool GetTransitionProperty(ComputedStyle computedStyle, StylePropertyId id, ComputedTransitionProperty result) { }

	// RVA: 0x187CC6C
	private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ComputedStyle computedStyle) { }

	// RVA: 0x187D0E4
	private static int GetTransitionHashCode(ComputedStyle cs) { }

	// RVA: 0x187DA48
	internal static bool SameTransitionProperty(ComputedStyle x, ComputedStyle y) { }

	// RVA: 0x187DBBC
	private static bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> a, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> b) { }

	// RVA: 0x187DCC8
	private static bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> a, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> b) { }

	// RVA: 0x187D768
	private static void ComputeTransitionPropertyData(ComputedStyle computedStyle, System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> outData) { }

	// RVA: 0x318DB98
	private static T GetWrappingTransitionData(System.Collections.Generic.List<T> list, int i, T defaultValue) { }

	// RVA: 0x187DDF0
	private static int ConvertTransitionTime(TimeValue time) { }

	// RVA: 0x187DF24
	private static System.Func<System.Single,System.Single> ConvertTransitionFunction(EasingMode mode) { }

	// RVA: 0x187EBD8
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public struct CustomStyleProperty<T0>
{
	// Fields
	private string <name>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30D3CF0
	public string get_name() { }

	// RVA: 0x30D4CD4
	private void set_name(string value) { }

	// RVA: 0x30D4CD4
	public void .ctor(string propertyName) { }

	// RVA: 0x30D3858
	public override bool Equals(object obj) { }

	// RVA: 0x318DB98
	public bool Equals(UnityEngine.UIElements.CustomStyleProperty<T> other) { }

	// RVA: 0x30D39B8
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

	// RVA: 0x187EDD4
	public EasingMode get_mode() { }

	// RVA: 0x187EDDC
	public void .ctor(EasingMode mode) { }

	// RVA: 0x187DF20
	public static EasingFunction op_Implicit(EasingMode easingMode) { }

	// RVA: 0x187EDE4
	public static bool op_Equality(EasingFunction lhs, EasingFunction rhs) { }

	// RVA: 0x187EDF0
	public bool Equals(EasingFunction other) { }

	// RVA: 0x187EE00
	public override bool Equals(object obj) { }

	// RVA: 0x187EE90
	public override string ToString() { }

	// RVA: 0x187DA40
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public struct FontDefinition
{
	// Fields
	private Font m_Font; // 0x10
	private FontAsset m_FontAsset; // 0x18

	// Methods

	// RVA: 0x187EF04
	public Font get_font() { }

	// RVA: 0x187EF0C
	public FontAsset get_fontAsset() { }

	// RVA: 0x187EF14
	public static FontDefinition FromFont(Font f) { }

	// RVA: 0x187EF40
	public static FontDefinition FromSDFFont(FontAsset f) { }

	// RVA: 0x187EF70
	internal static FontDefinition FromObject(object obj) { }

	// RVA: 0x187F0E4
	internal bool IsEmpty() { }

	// RVA: 0x187F1AC
	public override string ToString() { }

	// RVA: 0x187F248
	public bool Equals(FontDefinition other) { }

	// RVA: 0x187F290
	public override bool Equals(object obj) { }

	// RVA: 0x187F330
	public override int GetHashCode() { }

	// RVA: 0x187F468
	public static bool op_Equality(FontDefinition left, FontDefinition right) { }

	// RVA: 0x187F4B0
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

	// RVA: 0x187F504
	private void UnityEngine.UIElements.IStyle.set_backgroundColor(StyleColor value) { }

	// RVA: 0x187F728
	private void UnityEngine.UIElements.IStyle.set_borderBottomColor(StyleColor value) { }

	// RVA: 0x187F788
	private void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(StyleLength value) { }

	// RVA: 0x187F97C
	private void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(StyleLength value) { }

	// RVA: 0x187F9D4
	private void UnityEngine.UIElements.IStyle.set_borderBottomWidth(StyleFloat value) { }

	// RVA: 0x187FBD0
	private void UnityEngine.UIElements.IStyle.set_borderLeftColor(StyleColor value) { }

	// RVA: 0x187FC30
	private void UnityEngine.UIElements.IStyle.set_borderLeftWidth(StyleFloat value) { }

	// RVA: 0x187FCAC
	private void UnityEngine.UIElements.IStyle.set_borderRightColor(StyleColor value) { }

	// RVA: 0x187FD0C
	private void UnityEngine.UIElements.IStyle.set_borderRightWidth(StyleFloat value) { }

	// RVA: 0x187FD88
	private void UnityEngine.UIElements.IStyle.set_borderTopColor(StyleColor value) { }

	// RVA: 0x187FDE8
	private void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(StyleLength value) { }

	// RVA: 0x187FE40
	private void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(StyleLength value) { }

	// RVA: 0x187FE98
	private void UnityEngine.UIElements.IStyle.set_borderTopWidth(StyleFloat value) { }

	// RVA: 0x187FF14
	private void UnityEngine.UIElements.IStyle.set_bottom(StyleLength value) { }

	// RVA: 0x187FFA4
	private void UnityEngine.UIElements.IStyle.set_color(StyleColor value) { }

	// RVA: 0x1880000
	private UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }

	// RVA: 0x18800A8
	private void UnityEngine.UIElements.IStyle.set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value) { }

	// RVA: 0x1880168
	private void UnityEngine.UIElements.IStyle.set_flexBasis(StyleLength value) { }

	// RVA: 0x18801F8
	private void UnityEngine.UIElements.IStyle.set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value) { }

	// RVA: 0x18802B8
	private void UnityEngine.UIElements.IStyle.set_flexGrow(StyleFloat value) { }

	// RVA: 0x1880334
	private void UnityEngine.UIElements.IStyle.set_flexShrink(StyleFloat value) { }

	// RVA: 0x18803B0
	private void UnityEngine.UIElements.IStyle.set_fontSize(StyleLength value) { }

	// RVA: 0x1880404
	private void UnityEngine.UIElements.IStyle.set_height(StyleLength value) { }

	// RVA: 0x1880494
	private void UnityEngine.UIElements.IStyle.set_left(StyleLength value) { }

	// RVA: 0x1880524
	private void UnityEngine.UIElements.IStyle.set_marginBottom(StyleLength value) { }

	// RVA: 0x18805B4
	private void UnityEngine.UIElements.IStyle.set_marginLeft(StyleLength value) { }

	// RVA: 0x1880644
	private void UnityEngine.UIElements.IStyle.set_marginRight(StyleLength value) { }

	// RVA: 0x18806D4
	private void UnityEngine.UIElements.IStyle.set_marginTop(StyleLength value) { }

	// RVA: 0x1880764
	private void UnityEngine.UIElements.IStyle.set_maxHeight(StyleLength value) { }

	// RVA: 0x18807F4
	private void UnityEngine.UIElements.IStyle.set_maxWidth(StyleLength value) { }

	// RVA: 0x1880884
	private void UnityEngine.UIElements.IStyle.set_minWidth(StyleLength value) { }

	// RVA: 0x1880914
	private void UnityEngine.UIElements.IStyle.set_opacity(StyleFloat value) { }

	// RVA: 0x1880964
	private void UnityEngine.UIElements.IStyle.set_overflow(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Overflow> value) { }

	// RVA: 0x1880AA8
	private void UnityEngine.UIElements.IStyle.set_paddingBottom(StyleLength value) { }

	// RVA: 0x1880B38
	private void UnityEngine.UIElements.IStyle.set_paddingLeft(StyleLength value) { }

	// RVA: 0x1880BC8
	private void UnityEngine.UIElements.IStyle.set_paddingRight(StyleLength value) { }

	// RVA: 0x1880C58
	private StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }

	// RVA: 0x1880C7C
	private void UnityEngine.UIElements.IStyle.set_paddingTop(StyleLength value) { }

	// RVA: 0x1880D0C
	private void UnityEngine.UIElements.IStyle.set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value) { }

	// RVA: 0x1880DCC
	private void UnityEngine.UIElements.IStyle.set_right(StyleLength value) { }

	// RVA: 0x1880E5C
	private void UnityEngine.UIElements.IStyle.set_top(StyleLength value) { }

	// RVA: 0x1880EEC
	private void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(StyleColor value) { }

	// RVA: 0x1880F4C
	private void UnityEngine.UIElements.IStyle.set_unityFont(StyleFont value) { }

	// RVA: 0x188122C
	private void UnityEngine.UIElements.IStyle.set_unityFontDefinition(StyleFontDefinition value) { }

	// RVA: 0x1881610
	private void UnityEngine.UIElements.IStyle.set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value) { }

	// RVA: 0x18816A4
	private StyleLength UnityEngine.UIElements.IStyle.get_width() { }

	// RVA: 0x18816C8
	private void UnityEngine.UIElements.IStyle.set_width(StyleLength value) { }

	// RVA: 0x1881758
	private VisualElement get_ve() { }

	// RVA: 0x1881760
	private void set_ve(VisualElement value) { }

	// RVA: 0x1881768
	public void .ctor(VisualElement ve) { }

	// RVA: 0x188179C
	protected override void Finalize() { }

	// RVA: 0x1881904
	public void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x1882620
	public bool IsValueSet(StylePropertyId id) { }

	// RVA: 0x18819C8
	public void ApplyInlineStyles(ComputedStyle computedStyle) { }

	// RVA: 0x1882A74
	private StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }

	// RVA: 0x1882B30
	private StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }

	// RVA: 0x1882BC0
	private StyleBackgroundSize UnityEngine.UIElements.IStyle.get_backgroundSize() { }

	// RVA: 0x1882C4C
	private StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }

	// RVA: 0x1882CD8
	private StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }

	// RVA: 0x1882D70
	private void UnityEngine.UIElements.IStyle.set_translate(StyleTranslate value) { }

	// RVA: 0x1882F40
	private StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }

	// RVA: 0x1882FD8
	private StyleScale UnityEngine.UIElements.IStyle.get_scale() { }

	// RVA: 0x187F7DC
	private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) { }

	// RVA: 0x187FA50
	private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) { }

	// RVA: 0x187F560
	private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) { }

	// RVA: 0x318DB98
	private bool SetStyleValue(StylePropertyId id, UnityEngine.UIElements.StyleEnum<T> inlineValue) { }

	// RVA: 0x188128C
	private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue) { }

	// RVA: 0x1880FA0
	private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue) { }

	// RVA: 0x1882DC8
	private bool SetInlineTranslate(StyleTranslate inlineValue) { }

	// RVA: 0x188350C
	private void ApplyStyleTranslate(StyleTranslate translate) { }

	// RVA: 0x1883180
	private void ApplyStyleValue(StyleValue value) { }

	// RVA: 0x1883064
	private bool RemoveInlineStyle(StylePropertyId id) { }

	// RVA: 0x18837C8
	private void ApplyFromComputedStyle(StylePropertyId id, ComputedStyle newStyle) { }

	// RVA: 0x1882AF4
	public bool TryGetInlineCursor(StyleCursor value) { }

	// RVA: 0x1882BA0
	public bool TryGetInlineTextShadow(StyleTextShadow value) { }

	// RVA: 0x1882CB4
	public bool TryGetInlineTransformOrigin(StyleTransformOrigin value) { }

	// RVA: 0x1882D44
	public bool TryGetInlineTranslate(StyleTranslate value) { }

	// RVA: 0x1882FAC
	public bool TryGetInlineRotate(StyleRotate value) { }

	// RVA: 0x1883040
	public bool TryGetInlineScale(StyleScale value) { }

	// RVA: 0x1882C28
	public bool TryGetInlineBackgroundSize(StyleBackgroundSize value) { }

	// RVA: 0x1883AA8
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

	// RVA: 0x1896398
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

	// RVA: 0x18963EC
	protected UxmlIntAttributeDescription get_focusIndex() { }

	// RVA: 0x18963F4
	protected UxmlBoolAttributeDescription get_focusable() { }

	// RVA: 0x18963FC
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x18966F8
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

	// RVA: 0x18869DC
	public VisualElement get_parent() { }

	// RVA: 0x1896CB8
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> get_children() { }

	// RVA: 0x188B9C8
	internal void .ctor(VisualElement element) { }

	// RVA: 0x1892F34
	public void Add(VisualElement child) { }

	// RVA: 0x1893088
	public void Insert(int index, VisualElement child) { }

	// RVA: 0x1894740
	public void Remove(VisualElement child) { }

	// RVA: 0x1896EF4
	public void RemoveAt(int index) { }

	// RVA: 0x18934C8
	public void Clear() { }

	// RVA: 0x18942C8
	internal void BringToFront(VisualElement child) { }

	// RVA: 0x189441C
	internal void SendToBack(VisualElement child) { }

	// RVA: 0x18945EC
	internal void PlaceBehind(VisualElement child, VisualElement over) { }

	// RVA: 0x18973AC
	private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) { }

	// RVA: 0x1893BB8
	public int get_childCount() { }

	// RVA: 0x1893AA0
	public VisualElement get_Item(int key) { }

	// RVA: 0x1893CC4
	public int IndexOf(VisualElement element) { }

	// RVA: 0x18974C0
	public VisualElement ElementAt(int index) { }

	// RVA: 0x1894268
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children() { }

	// RVA: 0x1896E14
	private void SetParent(VisualElement value) { }

	// RVA: 0x1896CD8
	private void PutChildAtIndex(VisualElement child, int index) { }

	// RVA: 0x18971F4
	private void RemoveChildAtIndex(int index) { }

	// RVA: 0x189727C
	private void ReleaseChildList() { }

	// RVA: 0x1897540
	public bool Equals(Hierarchy other) { }

	// RVA: 0x189755C
	public override bool Equals(object obj) { }

	// RVA: 0x18975EC
	public override int GetHashCode() { }

	// RVA: 0x1897550
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

	// RVA: 0x1897604
	public VisualElement get_element() { }

	// RVA: 0x189760C
	private void set_element(VisualElement value) { }

	// RVA: 0x1897614
	public bool get_isActive() { }

	// RVA: 0x1897634
	protected void .ctor(VisualElement handler) { }

	// RVA: 0x18976EC
	public IVisualElementScheduledItem StartingIn(Int64 delayMs) { }

	// RVA: 0x18976F4
	public IVisualElementScheduledItem Every(Int64 intervalMs) { }

	// RVA: 0x18977F8
	internal override void OnItemUnscheduled() { }

	// RVA: 0x1895770
	public void Resume() { }

	// RVA: 0x1897848
	public void Pause() { }

	// RVA: 0x189786C
	public void ExecuteLater(Int64 delayMs) { }

	// RVA: 0x18978BC
	public void OnPanelActivate() { }

	// RVA: 0x18979C4
	public void OnPanelDeactivate() { }

	// RVA: 0x1897AB8
	public bool CanBeActivated() { }

}

// Namespace: 
private abstract class VisualElementScheduledItem<T0>
{
	// Fields
	public ActionType updateEvent; // 0x0

	// Methods

	// RVA: 0x318DB98
	public void .ctor(VisualElement handler, ActionType upEvent) { }

}

// Namespace: 
private class TimerStateScheduledItem
{
	// Methods

	// RVA: 0x1895704
	public void .ctor(VisualElement handler, System.Action<UnityEngine.UIElements.TimerState> updateEvent) { }

	// RVA: 0x1897AFC
	public override void PerformTimerUpdate(TimerState state) { }

}

// Namespace: 
private class SimpleScheduledItem
{
	// Methods

	// RVA: 0x1895894
	public void .ctor(VisualElement handler, Action updateEvent) { }

	// RVA: 0x1897B40
	public override void PerformTimerUpdate(TimerState state) { }

}

// Namespace: 
internal class CustomStyleAccess
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_CustomProperties; // 0x10
	private float m_DpiScaling; // 0x18

	// Methods

	// RVA: 0x18959B4
	public void SetContext(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties, float dpiScaling) { }

	// RVA: 0x1897B78
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, float value) { }

	// RVA: 0x1897D70
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, int value) { }

	// RVA: 0x1897EDC
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, Color value) { }

	// RVA: 0x1898140
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, Texture2D value) { }

	// RVA: 0x1898254
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, Sprite value) { }

	// RVA: 0x1898368
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, VectorImage value) { }

	// RVA: 0x189847C
	public bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, string value) { }

	// RVA: 0x1897C9C
	private bool TryGetValue(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

	// RVA: 0x189803C
	private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

	// RVA: 0x189638C
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

	// RVA: 0x1898550
	public Type get_type() { }

	// RVA: 0x1896010
	public void .ctor(Type type) { }

	// RVA: 0x188B484
	public string get_fullTypeName() { }

	// RVA: 0x188B500
	public string get_typeName() { }

	// RVA: 0x1898558
	public string get_typeNamespace() { }

}

// Namespace: 
private sealed class <>c__DisplayClass492_0
{
	// Fields
	public VisualElement <>4__this; // 0x10
	public StyleValues to; // 0x18

	// Methods

	// RVA: 0x18925D4
	public void .ctor() { }

	// RVA: 0x18985B8
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

	// RVA: 0x1883B30
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0x1883B34
	private Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }

	// RVA: 0x1883B48
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }

	// RVA: 0x1883B54
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }

	// RVA: 0x1883B74
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }

	// RVA: 0x1883B94
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }

	// RVA: 0x1883BB4
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }

	// RVA: 0x1883BC0
	private float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }

	// RVA: 0x1883BE0
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }

	// RVA: 0x1883BEC
	private float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }

	// RVA: 0x1883C0C
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }

	// RVA: 0x1883C18
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }

	// RVA: 0x1883C38
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }

	// RVA: 0x1883C58
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }

	// RVA: 0x1883C78
	private float UnityEngine.UIElements.IResolvedStyle.get_bottom() { }

	// RVA: 0x1883C98
	private Color UnityEngine.UIElements.IResolvedStyle.get_color() { }

	// RVA: 0x1883CA4
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0x1883CB0
	private FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }

	// RVA: 0x1883CBC
	private float UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }

	// RVA: 0x1883CC8
	private float UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }

	// RVA: 0x1883CD4
	private float UnityEngine.UIElements.IResolvedStyle.get_height() { }

	// RVA: 0x1883CF4
	private float UnityEngine.UIElements.IResolvedStyle.get_left() { }

	// RVA: 0x1883D14
	private float UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }

	// RVA: 0x1883D34
	private float UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }

	// RVA: 0x1883D54
	private float UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }

	// RVA: 0x1883D74
	private float UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }

	// RVA: 0x1883D94
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }

	// RVA: 0x1883F8C
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }

	// RVA: 0x1883FC0
	private float UnityEngine.UIElements.IResolvedStyle.get_opacity() { }

	// RVA: 0x1883FCC
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }

	// RVA: 0x1883FEC
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }

	// RVA: 0x188400C
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }

	// RVA: 0x188402C
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }

	// RVA: 0x188404C
	private float UnityEngine.UIElements.IResolvedStyle.get_right() { }

	// RVA: 0x188406C
	private Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }

	// RVA: 0x1884078
	private float UnityEngine.UIElements.IResolvedStyle.get_top() { }

	// RVA: 0x1884098
	private Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }

	// RVA: 0x18843A0
	private Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }

	// RVA: 0x188459C
	private Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }

	// RVA: 0x18845A8
	private int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }

	// RVA: 0x18845B4
	private int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }

	// RVA: 0x18845C0
	private float UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale() { }

	// RVA: 0x18845CC
	private Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }

	// RVA: 0x18845D8
	private float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }

	// RVA: 0x18845E4
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0x18845F0
	private float UnityEngine.UIElements.IResolvedStyle.get_width() { }

	// RVA: 0x1884610
	internal bool get_hasRunningAnimations() { }

	// RVA: 0x18846C4
	internal bool get_hasCompletedAnimations() { }

	// RVA: 0x1884774
	private int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }

	// RVA: 0x188477C
	private void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value) { }

	// RVA: 0x1884784
	private int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }

	// RVA: 0x188478C
	private void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value) { }

	// RVA: 0x1884794
	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }

	// RVA: 0x18846C0
	internal IStylePropertyAnimations get_styleAnimation() { }

	// RVA: 0x18847B0
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18848B8
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18849D4
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1884AF0
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1884C44
	private bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1884D60
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1884EA0
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1884FD0
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18850EC
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x188524C
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x188537C
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18854DC
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x188563C
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x188579C
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18858CC
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18859E8
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1885B48
	private void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(StylePropertyId id) { }

	// RVA: 0x1885C28
	private void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }

	// RVA: 0x1885E50
	private void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) { }

	// RVA: 0x1885F24
	private void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: 0x1886154
	internal bool TryConvertLengthUnits(StylePropertyId id, Length from, Length to, int subPropertyIndex) { }

	// RVA: 0x18867EC
	internal bool TryConvertTransformOriginUnits(TransformOrigin from, TransformOrigin to) { }

	// RVA: 0x1886874
	internal bool TryConvertTranslateUnits(Translate from, Translate to) { }

	// RVA: 0x18868FC
	internal bool TryConvertBackgroundSizeUnits(BackgroundSize from, BackgroundSize to) { }

	// RVA: 0x18864B8
	private System.Nullable<System.Single> GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex) { }

	// RVA: 0x18869FC
	internal bool get_isCompositeRoot() { }

	// RVA: 0x1886A08
	internal void set_isCompositeRoot(bool value) { }

	// RVA: 0x1886BD0
	internal bool get_isHierarchyDisplayed() { }

	// RVA: 0x1886BDC
	internal void set_isHierarchyDisplayed(bool value) { }

	// RVA: 0x1886BFC
	public string get_viewDataKey() { }

	// RVA: 0x1886C04
	public void set_viewDataKey(string value) { }

	// RVA: 0x1886CB0
	internal bool get_enableViewDataPersistence() { }

	// RVA: 0x1886CBC
	private void set_enableViewDataPersistence(bool value) { }

	// RVA: 0x1886CDC
	public object get_userData() { }

	// RVA: 0x1886F9C
	public void set_userData(object value) { }

	// RVA: 0x18872EC
	public override bool get_canGrabFocus() { }

	// RVA: 0x1887560
	public override FocusController get_focusController() { }

	// RVA: 0x188762C
	public UsageHints get_usageHints() { }

	// RVA: 0x188764C
	public void set_usageHints(UsageHints value) { }

	// RVA: 0x1887644
	internal RenderHints get_renderHints() { }

	// RVA: 0x18877E4
	internal void set_renderHints(RenderHints value) { }

	// RVA: 0x188782C
	internal void MarkRenderHintsClean() { }

	// RVA: 0x188783C
	public ITransform get_transform() { }

	// RVA: 0x1887840
	private Vector3 UnityEngine.UIElements.ITransform.get_position() { }

	// RVA: 0x18878F4
	private void UnityEngine.UIElements.ITransform.set_position(Vector3 value) { }

	// RVA: 0x1887B60
	private Vector3 UnityEngine.UIElements.ITransform.get_scale() { }

	// RVA: 0x1887C18
	internal bool get_isLayoutManual() { }

	// RVA: 0x1887C24
	private void set_isLayoutManual(bool value) { }

	// RVA: 0x1887C44
	internal float get_scaledPixelsPerPoint() { }

	// RVA: 0x1887CC4
	public Rect get_layout() { }

	// RVA: 0x1887D68
	internal void set_layout(Rect value) { }

	// RVA: 0x18885F0
	internal void ClearManualLayout() { }

	// RVA: 0x1888C50
	public Rect get_contentRect() { }

	// RVA: 0x1888E68
	protected Rect get_paddingRect() { }

	// RVA: 0x18890A4
	internal bool get_isBoundingBoxDirty() { }

	// RVA: 0x18890B0
	internal void set_isBoundingBoxDirty(bool value) { }

	// RVA: 0x18890D0
	internal void set_isWorldBoundingBoxDirty(bool value) { }

	// RVA: 0x18890F0
	internal bool get_isWorldBoundingBoxOrDependenciesDirty() { }

	// RVA: 0x1889104
	internal Rect get_boundingBox() { }

	// RVA: 0x18893AC
	internal Rect get_worldBoundingBox() { }

	// RVA: 0x1889538
	private Rect get_boundingBoxInParentSpace() { }

	// RVA: 0x188914C
	internal void UpdateBoundingBox() { }

	// RVA: 0x18893FC
	internal void UpdateWorldBoundingBox() { }

	// RVA: 0x1889794
	public Rect get_worldBound() { }

	// RVA: 0x1889884
	public Rect get_localBound() { }

	// RVA: 0x1889088
	internal Rect get_rect() { }

	// RVA: 0x18898CC
	internal bool get_isWorldTransformDirty() { }

	// RVA: 0x18898D8
	internal void set_isWorldTransformDirty(bool value) { }

	// RVA: 0x18898EC
	internal void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0x188990C
	internal bool get_isWorldTransformInverseOrDependenciesDirty() { }

	// RVA: 0x188991C
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0x1889764
	internal Matrix4x4 get_worldTransformRef() { }

	// RVA: 0x1889C64
	internal Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0x188995C
	internal void UpdateWorldTransform() { }

	// RVA: 0x1889CD0
	internal void UpdateWorldTransformInverse() { }

	// RVA: 0x188A1D4
	internal bool get_isWorldClipDirty() { }

	// RVA: 0x188A1E0
	internal void set_isWorldClipDirty(bool value) { }

	// RVA: 0x188A200
	internal Rect get_worldClip() { }

	// RVA: 0x188A578
	internal Rect get_worldClipMinusGroup() { }

	// RVA: 0x188A5C0
	internal bool get_worldClipIsInfinite() { }

	// RVA: 0x188A5FC
	internal void EnsureWorldTransformAndClipUpToDate() { }

	// RVA: 0x188A248
	private void UpdateWorldClip() { }

	// RVA: 0x188AC00
	private Rect CombineClipRects(Rect rect, Rect parentRect) { }

	// RVA: 0x188A654
	private Rect SubstractBorderPadding(Rect worldRect) { }

	// RVA: 0x188AC50
	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) { }

	// RVA: 0x188AD70
	internal PseudoStates get_pseudoStates() { }

	// RVA: 0x188AD78
	internal void set_pseudoStates(PseudoStates value) { }

	// RVA: 0x188AE00
	internal int get_containedPointerIds() { }

	// RVA: 0x188AE08
	private void set_containedPointerIds(int value) { }

	// RVA: 0x188AE10
	private void UpdateHoverPseudoState() { }

	// RVA: 0x188B00C
	private static bool IsPartOfCapturedChain(VisualElement self, IEventHandler capturingElement) { }

	// RVA: 0x188B118
	public PickingMode get_pickingMode() { }

	// RVA: 0x188B120
	public void set_pickingMode(PickingMode value) { }

	// RVA: 0x188B158
	public string get_name() { }

	// RVA: 0x188B160
	public void set_name(string value) { }

	// RVA: 0x188B1D8
	internal System.Collections.Generic.List<System.String> get_classList() { }

	// RVA: 0x188B2D4
	internal string get_fullTypeName() { }

	// RVA: 0x188B4E4
	internal string get_typeName() { }

	// RVA: 0x188B5C0
	internal YogaNode get_yogaNode() { }

	// RVA: 0x188B5C8
	private void set_yogaNode(YogaNode value) { }

	// RVA: 0x1883B40
	internal ComputedStyle get_computedStyle() { }

	// RVA: 0x188B5D8
	internal bool get_hasInlineStyle() { }

	// RVA: 0x188B5E8
	internal bool get_styleInitialized() { }

	// RVA: 0x188B5F4
	internal void set_styleInitialized(bool value) { }

	// RVA: 0x188B614
	private void ChangeIMGUIContainerCount(int delta) { }

	// RVA: 0x188B648
	public void .ctor() { }

	// RVA: 0x188B9F0
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x188C660
	internal virtual Rect GetTooltipRect() { }

	// RVA: 0x188C574
	private void SetTooltip(TooltipEvent e) { }

	// RVA: 0x188C788
	public sealed override void Focus() { }

	// RVA: 0x188C7EC
	internal void SetPanel(BaseVisualElementPanel p) { }

	// RVA: 0x188D3DC
	private void WillChangePanel(BaseVisualElementPanel destinationPanel) { }

	// RVA: 0x188D5D0
	private void HasChangedPanel(BaseVisualElementPanel prevPanel) { }

	// RVA: 0x188DB38
	public sealed override void SendEvent(EventBase e) { }

	// RVA: 0x188DB50
	internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: 0x1886C8C
	internal void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0x188DB64
	internal void InvokeHierarchyChanged(HierarchyChangeType changeType) { }

	// RVA: 0x188DB80
	private bool SetEnabledFromHierarchyPrivate(bool state) { }

	// RVA: 0x188DF68
	private bool get_isParentEnabledInHierarchy() { }

	// RVA: 0x1887550
	public bool get_enabledInHierarchy() { }

	// RVA: 0x188E2E4
	public bool get_enabledSelf() { }

	// RVA: 0x188E2EC
	private void set_enabledSelf(bool value) { }

	// RVA: 0x188B9D0
	public void SetEnabled(bool value) { }

	// RVA: 0x188E2F4
	private void PropagateEnabledToChildren(bool value) { }

	// RVA: 0x188E3C0
	public LanguageDirection get_languageDirection() { }

	// RVA: 0x188E3C8
	internal LanguageDirection get_localLanguageDirection() { }

	// RVA: 0x188E3D0
	internal void set_localLanguageDirection(LanguageDirection value) { }

	// RVA: 0x18874A0
	public bool get_visible() { }

	// RVA: 0x188E4E0
	public void set_visible(bool value) { }

	// RVA: 0x188E658
	public void MarkDirtyRepaint() { }

	// RVA: 0x188E67C
	public System.Action<UnityEngine.UIElements.MeshGenerationContext> get_generateVisualContent() { }

	// RVA: 0x188E684
	public void set_generateVisualContent(System.Action<UnityEngine.UIElements.MeshGenerationContext> value) { }

	// RVA: 0x188E694
	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x188E894
	internal void GetFullHierarchicalViewDataKey(StringBuilder key) { }

	// RVA: 0x188E938
	internal string GetFullHierarchicalViewDataKey() { }

	// RVA: 0x318DB98
	internal T GetOrCreateViewData(object existing, string key) { }

	// RVA: 0x188E9B8
	internal void OverwriteFromViewData(object obj, string key) { }

	// RVA: 0x188ECF8
	internal void SaveViewData() { }

	// RVA: 0x188ED84
	internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState) { }

	// RVA: 0x188EE30
	internal void OnViewDataReady(bool enablePersistence) { }

	// RVA: 0x188EE5C
	internal virtual void OnViewDataReady() { }

	// RVA: 0x188EE60
	public virtual bool ContainsPoint(Vector2 localPoint) { }

	// RVA: 0x188EEB4
	internal bool get_requireMeasureFunction() { }

	// RVA: 0x188EEC0
	internal void set_requireMeasureFunction(bool value) { }

	// RVA: 0x188EFD0
	private void AssignMeasureFunction() { }

	// RVA: 0x188F064
	private void RemoveMeasureFunction() { }

	// RVA: 0x188F088
	protected internal virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x188F098
	internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x188F21C
	private void FinalizeLayout() { }

	// RVA: 0x188F314
	internal void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x188F3BC
	internal void SetComputedStyle(ComputedStyle newStyle) { }

	// RVA: 0x188F580
	public override string ToString() { }

	// RVA: 0x188F760
	internal System.Collections.Generic.List<System.String> GetClassesForIteration() { }

	// RVA: 0x188E0E4
	public void AddToClassList(string className) { }

	// RVA: 0x188DFA4
	public void RemoveFromClassList(string className) { }

	// RVA: 0x188E2D8
	public void EnableInClassList(string className, bool enable) { }

	// RVA: 0x188F768
	public bool ClassListContains(string cls) { }

	// RVA: 0x188F830
	internal object GetProperty(PropertyName key) { }

	// RVA: 0x188FA24
	internal void SetProperty(PropertyName key, object value) { }

	// RVA: 0x188FAA8
	internal bool HasProperty(PropertyName key) { }

	// RVA: 0x1886D60
	private bool TryGetPropertyInternal(PropertyName key, object value) { }

	// RVA: 0x188F8BC
	private static void CheckUserKeyArgument(PropertyName key) { }

	// RVA: 0x1887010
	private void SetPropertyInternal(PropertyName key, object value) { }

	// RVA: 0x188C0E8
	private void UpdateCursorStyle(Int64 eventType) { }

	// RVA: 0x188FB30
	internal RenderTargetMode get_subRenderTargetMode() { }

	// RVA: 0x188FB38
	internal Material get_defaultMaterial() { }

	// RVA: 0x188FB40
	private VisualElementAnimationSystem GetAnimationSystem() { }

	// RVA: 0x188FBE0
	internal void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x188FD2C
	internal void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x188D8E8
	private void UnregisterRunningAnimations() { }

	// RVA: 0x188DA60
	private void RegisterRunningAnimations() { }

	// RVA: 0x318DB98
	private static UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation(UnityEngine.UIElements.Experimental.ValueAnimation<T> anim, System.Func<UnityEngine.UIElements.VisualElement,T> fromValueGetter, T to, int durationMs, System.Action<UnityEngine.UIElements.VisualElement,T> onValueChanged) { }

	// RVA: 0x188FE1C
	private static void AssignStyleValues(VisualElement ve, StyleValues src) { }

	// RVA: 0x189152C
	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) { }

	// RVA: 0x18924C8
	private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(StyleValues to, int durationMs) { }

	// RVA: 0x18925DC
	private UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.Experimental.StyleValues> fromValueGetter, StyleValues to, int durationMs) { }

	// RVA: 0x189276C
	private void DirtyNextParentWithEventCallback() { }

	// RVA: 0x1886B08
	private void SetAsNextParentWithEventCallback() { }

	// RVA: 0x18927F0
	internal bool GetCachedNextParentWithEventCallback(VisualElement nextParent) { }

	// RVA: 0x1892848
	internal VisualElement get_nextParentWithEventCallback() { }

	// RVA: 0x18929CC
	private void PropagateCachedNextParentWithEventCallback(VisualElement nextParent, VisualElement stopParent) { }

	// RVA: 0x1892A50
	internal int get_eventCallbackCategories() { }

	// RVA: 0x1892A58
	internal void set_eventCallbackCategories(int value) { }

	// RVA: 0x1892B68
	internal int get_eventCallbackParentCategories() { }

	// RVA: 0x1892BBC
	internal bool get_isEventCallbackParentCategoriesDirty() { }

	// RVA: 0x1892CAC
	internal void set_isEventCallbackParentCategoriesDirty(bool value) { }

	// RVA: 0x1892BC8
	private void UpdateCallbackParentCategories() { }

	// RVA: 0x1892CCC
	internal bool HasEventCallbacks(EventCategory eventCategory) { }

	// RVA: 0x1892CDC
	internal bool HasParentEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x188DA40
	internal bool HasEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x1892D4C
	internal bool HasParentEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x1892DB4
	internal bool HasEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x1892DCC
	internal bool HasDefaultAction(EventCategory eventCategory) { }

	// RVA: 0x1892DDC
	public IExperimentalFeatures get_experimental() { }

	// RVA: 0x1892DE0
	private ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }

	// RVA: 0x1892DE4
	public Hierarchy get_hierarchy() { }

	// RVA: 0x1892DEC
	private void set_hierarchy(Hierarchy value) { }

	// RVA: 0x1892E00
	internal bool get_isRootVisualContainer() { }

	// RVA: 0x1892E08
	internal void set_isRootVisualContainer(bool value) { }

	// RVA: 0x1892E10
	internal bool get_disableClipping() { }

	// RVA: 0x1892E1C
	internal void set_disableClipping(bool value) { }

	// RVA: 0x188972C
	internal bool ShouldClip() { }

	// RVA: 0x1887498
	public VisualElement get_parent() { }

	// RVA: 0x1892E3C
	internal BaseVisualElementPanel get_elementPanel() { }

	// RVA: 0x1892E44
	private void set_elementPanel(BaseVisualElementPanel value) { }

	// RVA: 0x1887624
	public IPanel get_panel() { }

	// RVA: 0x1892E54
	public virtual VisualElement get_contentContainer() { }

	// RVA: 0x1892E58
	internal void set_visualTreeAssetSource(VisualTreeAsset value) { }

	// RVA: 0x1892E68
	public void Add(VisualElement child) { }

	// RVA: 0x1892FE8
	public void Insert(int index, VisualElement element) { }

	// RVA: 0x1893454
	public void Clear() { }

	// RVA: 0x1893908
	public VisualElement ElementAt(int index) { }

	// RVA: 0x18939D4
	public VisualElement get_Item(int key) { }

	// RVA: 0x1893B20
	public int get_childCount() { }

	// RVA: 0x1893C0C
	public int IndexOf(VisualElement element) { }

	// RVA: 0x1893D30
	internal VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> childIndexes) { }

	// RVA: 0x1893FE8
	internal bool FindElementInTree(VisualElement element, System.Collections.Generic.List<System.Int32> outChildIndexes) { }

	// RVA: 0x18941A0
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children() { }

	// RVA: 0x1894288
	public void BringToFront() { }

	// RVA: 0x18943DC
	public void SendToBack() { }

	// RVA: 0x18944F8
	public void PlaceBehind(VisualElement sibling) { }

	// RVA: 0x1894700
	public void RemoveFromHierarchy() { }

	// RVA: 0x318DB98
	public T GetFirstOfType() { }

	// RVA: 0x318DB98
	public T GetFirstAncestorOfType() { }

	// RVA: 0x1894838
	internal VisualElement GetFirstAncestorWhere(System.Predicate<UnityEngine.UIElements.VisualElement> predicate) { }

	// RVA: 0x188B0E0
	public bool Contains(VisualElement child) { }

	// RVA: 0x188D2F0
	private void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x189489C
	public VisualElement FindCommonAncestor(VisualElement other) { }

	// RVA: 0x18949CC
	internal VisualElement GetRoot() { }

	// RVA: 0x1894A94
	internal VisualElement GetRootVisualContainer() { }

	// RVA: 0x1894AD0
	internal VisualElement GetNextElementDepthFirst() { }

	// RVA: 0x1894BF4
	internal VisualElement GetPreviousElementDepthFirst() { }

	// RVA: 0x1894D04
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0x1889D30
	private Vector3 get_positionWithLayout() { }

	// RVA: 0x1889D84
	internal void GetPivotedMatrixWithLayout(Matrix4x4 result) { }

	// RVA: 0x1894EA4
	internal bool get_hasDefaultRotationAndScale() { }

	// RVA: 0x1894F98
	internal static float Min(float a, float b, float c, float d) { }

	// RVA: 0x1894FB4
	internal static float Max(float a, float b, float c, float d) { }

	// RVA: 0x1894FD0
	private void TransformAlignedRectToParentSpace(Rect rect) { }

	// RVA: 0x1895164
	internal static Rect CalculateConservativeRect(Matrix4x4 matrix, Rect rect) { }

	// RVA: 0x18953DC
	internal static void TransformAlignedRect(Matrix4x4 matrix, Rect rect) { }

	// RVA: 0x1895388
	internal static void OrderMinMaxRect(Rect rect) { }

	// RVA: 0x1895474
	internal static Vector2 MultiplyMatrix44Point2(Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0x1895498
	internal static Vector2 MultiplyVector2(Matrix4x4 lhs, Vector2 vector) { }

	// RVA: 0x188A018
	internal static void MultiplyMatrix34(Matrix4x4 lhs, Matrix4x4 rhs, Matrix4x4 res) { }

	// RVA: 0x18954B4
	private static void TranslateMatrix34(Matrix4x4 lhs, Vector3 rhs, Matrix4x4 res) { }

	// RVA: 0x18955A4
	private static void TranslateMatrix34InPlace(Matrix4x4 lhs, Vector3 rhs) { }

	// RVA: 0x1895600
	public IVisualElementScheduler get_schedule() { }

	// RVA: 0x1895604
	private IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent) { }

	// RVA: 0x1895794
	private IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action updateEvent) { }

	// RVA: 0x1887AC4
	public IStyle get_style() { }

	// RVA: 0x1895900
	public ICustomStyle get_customStyle() { }

	// RVA: 0x18959EC
	public VisualElementStyleSheetSet get_styleSheets() { }

	// RVA: 0x1895A1C
	internal void AddStyleSheetPath(string sheetPath) { }

	// RVA: 0x1883DC8
	private StyleFloat ResolveLengthValue(Length length, bool isRow) { }

	// RVA: 0x18843A4
	private Vector3 ResolveTranslate() { }

	// RVA: 0x188409C
	private Vector3 ResolveTransformOrigin() { }

	// RVA: 0x1894D70
	private Quaternion ResolveRotation() { }

	// RVA: 0x1894E04
	private Vector3 ResolveScale() { }

	// RVA: 0x188C664
	public string get_tooltip() { }

	// RVA: 0x1895CE4
	public void set_tooltip(string value) { }

	// RVA: 0x1895ED8
	internal static TypeData GetOrCreateTypeData(Type t) { }

	// RVA: 0x188B33C
	private TypeData get_typeData() { }

	// RVA: 0x18960C0
	private static void .cctor() { }

	// RVA: 0x1896394
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

	// RVA: 0x18985D8
	public InheritedData Copy() { }

	// RVA: 0x1898604
	public void CopyFrom(InheritedData other) { }

	// RVA: 0x1898630
	public static bool op_Equality(InheritedData lhs, InheritedData rhs) { }

	// RVA: 0x18988A8
	public bool Equals(InheritedData other) { }

	// RVA: 0x1898924
	public override bool Equals(object obj) { }

	// RVA: 0x1898A0C
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

	// RVA: 0x1898C70
	public LayoutData Copy() { }

	// RVA: 0x1898CAC
	public void CopyFrom(LayoutData other) { }

	// RVA: 0x1898CB4
	public static bool op_Equality(LayoutData lhs, LayoutData rhs) { }

	// RVA: 0x1899068
	public bool Equals(LayoutData other) { }

	// RVA: 0x1899104
	public override bool Equals(object obj) { }

	// RVA: 0x189920C
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

	// RVA: 0x1899584
	public RareData Copy() { }

	// RVA: 0x18995A0
	public void CopyFrom(RareData other) { }

	// RVA: 0x18995CC
	public static bool op_Equality(RareData lhs, RareData rhs) { }

	// RVA: 0x1899718
	public bool Equals(RareData other) { }

	// RVA: 0x1899850
	public override bool Equals(object obj) { }

	// RVA: 0x18999E4
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

	// RVA: 0x1899AF0
	public TransformData Copy() { }

	// RVA: 0x1899B14
	public void CopyFrom(TransformData other) { }

	// RVA: 0x1899B1C
	public static bool op_Equality(TransformData lhs, TransformData rhs) { }

	// RVA: 0x1899EAC
	public bool Equals(TransformData other) { }

	// RVA: 0x1899F10
	public override bool Equals(object obj) { }

	// RVA: 0x1899FE8
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

	// RVA: 0x189A358
	public TransitionData Copy() { }

	// RVA: 0x189A4F4
	public void CopyFrom(TransitionData other) { }

	// RVA: 0x189A794
	public static bool op_Equality(TransitionData lhs, TransitionData rhs) { }

	// RVA: 0x189A7F0
	public bool Equals(TransitionData other) { }

	// RVA: 0x189A82C
	public override bool Equals(object obj) { }

	// RVA: 0x189A8DC
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

	// RVA: 0x189A97C
	public VisualData Copy() { }

	// RVA: 0x189A9B8
	public void CopyFrom(VisualData other) { }

	// RVA: 0x189A9E4
	public static bool op_Equality(VisualData lhs, VisualData rhs) { }

	// RVA: 0x189ADC8
	public bool Equals(VisualData other) { }

	// RVA: 0x189AE64
	public override bool Equals(object obj) { }

	// RVA: 0x189AF6C
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal class StyleValueCollection
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValue> m_Values; // 0x10

	// Methods

	// RVA: 0x189B278
	public StyleLength GetStyleLength(StylePropertyId id) { }

	// RVA: 0x189B580
	public StyleFloat GetStyleFloat(StylePropertyId id) { }

	// RVA: 0x189B5FC
	public StyleInt GetStyleInt(StylePropertyId id) { }

	// RVA: 0x189B2F4
	public bool TryGetStyleValue(StylePropertyId id, StyleValue value) { }

	// RVA: 0x189B690
	public void SetStyleValue(StyleValue value) { }

	// RVA: 0x189B814
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

	// RVA: 0x189B8A0
	public static Length Percent(float value) { }

	// RVA: 0x189B8E8
	public static Length Auto() { }

	// RVA: 0x189B914
	public static Length None() { }

	// RVA: 0x189B91C
	public float get_value() { }

	// RVA: 0x189B924
	public void set_value(float value) { }

	// RVA: 0x189B944
	public LengthUnit get_unit() { }

	// RVA: 0x189B94C
	public bool IsAuto() { }

	// RVA: 0x189B95C
	public bool IsNone() { }

	// RVA: 0x189B96C
	public void .ctor(float value) { }

	// RVA: 0x189B8C4
	public void .ctor(float value, LengthUnit unit) { }

	// RVA: 0x189B8F0
	private void .ctor(float value, Unit unit) { }

	// RVA: 0x189B990
	public static Length op_Implicit(float value) { }

	// RVA: 0x1899048
	public static bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x189B9B0
	public static bool op_Inequality(Length lhs, Length rhs) { }

	// RVA: 0x189B9D0
	public bool Equals(Length other) { }

	// RVA: 0x189B9F0
	public override bool Equals(object obj) { }

	// RVA: 0x1899550
	public override int GetHashCode() { }

	// RVA: 0x189BA8C
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

	// RVA: 0x189BC74
	public void .ctor(Angle angle) { }

	// RVA: 0x189BCD8
	internal static Rotate Initial() { }

	// RVA: 0x189BD54
	public static Rotate None() { }

	// RVA: 0x189BDDC
	public Angle get_angle() { }

	// RVA: 0x189BDE4
	public void set_angle(Angle value) { }

	// RVA: 0x189BDEC
	internal Vector3 get_axis() { }

	// RVA: 0x1899CFC
	public static bool op_Equality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x189BDF8
	public static bool op_Inequality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x189BEA0
	public bool Equals(Rotate other) { }

	// RVA: 0x189BF4C
	public override bool Equals(object obj) { }

	// RVA: 0x189A124
	public override int GetHashCode() { }

	// RVA: 0x189C06C
	public override string ToString() { }

	// RVA: 0x189C0EC
	internal Quaternion ToQuaternion() { }

}

// Namespace: UnityEngine.UIElements
public struct Scale
{
	// Fields
	private Vector3 m_Scale; // 0x10
	private bool m_IsNone; // 0x1C

	// Methods

	// RVA: 0x189C11C
	public void .ctor(Vector3 scale) { }

	// RVA: 0x189C234
	internal static Scale Initial() { }

	// RVA: 0x189C29C
	public static Scale None() { }

	// RVA: 0x189C30C
	public Vector3 get_value() { }

	// RVA: 0x1899D90
	public static bool op_Equality(Scale lhs, Scale rhs) { }

	// RVA: 0x189C318
	public static bool op_Inequality(Scale lhs, Scale rhs) { }

	// RVA: 0x189C370
	public bool Equals(Scale other) { }

	// RVA: 0x189C3C0
	public override bool Equals(object obj) { }

	// RVA: 0x189A1FC
	public override int GetHashCode() { }

	// RVA: 0x189C48C
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleBackgroundSize
{
	// Fields
	private BackgroundSize m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x24

	// Methods

	// RVA: 0x189C49C
	public BackgroundSize get_value() { }

	// RVA: 0x189C4EC
	public StyleKeyword get_keyword() { }

	// RVA: 0x189C4F4
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189C500
	internal void .ctor(BackgroundSize v, StyleKeyword keyword) { }

	// RVA: 0x189C518
	public static bool op_Equality(StyleBackgroundSize lhs, StyleBackgroundSize rhs) { }

	// RVA: 0x189C580
	public static StyleBackgroundSize op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189C58C
	public bool Equals(StyleBackgroundSize other) { }

	// RVA: 0x189C5F4
	public override bool Equals(object obj) { }

	// RVA: 0x189C6CC
	public override int GetHashCode() { }

	// RVA: 0x189C700
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleColor
{
	// Fields
	private Color m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x20

	// Methods

	// RVA: 0x189C78C
	public Color get_value() { }

	// RVA: 0x189C7B4
	public StyleKeyword get_keyword() { }

	// RVA: 0x189C7BC
	public void .ctor(Color v) { }

	// RVA: 0x189C7CC
	internal void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0x189C7DC
	public static bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0x189C838
	public static StyleColor op_Implicit(Color v) { }

	// RVA: 0x189C848
	public bool Equals(StyleColor other) { }

	// RVA: 0x189C8A4
	public override bool Equals(object obj) { }

	// RVA: 0x189C974
	public override int GetHashCode() { }

	// RVA: 0x189CA18
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleCursor
{
	// Fields
	private Cursor m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x28

	// Methods

	// RVA: 0x189CAA4
	public Cursor get_value() { }

	// RVA: 0x189CAF0
	public StyleKeyword get_keyword() { }

	// RVA: 0x189CAF8
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189CB0C
	internal void .ctor(Cursor v, StyleKeyword keyword) { }

	// RVA: 0x189CB28
	public static bool op_Equality(StyleCursor lhs, StyleCursor rhs) { }

	// RVA: 0x189CB90
	public static StyleCursor op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189CBD4
	public bool Equals(StyleCursor other) { }

	// RVA: 0x189CC3C
	public override bool Equals(object obj) { }

	// RVA: 0x189CD18
	public override int GetHashCode() { }

	// RVA: 0x189CD4C
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

	// RVA: 0x30D39B8
	public int get_refCount() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D488C
	public void Acquire() { }

	// RVA: 0x30D488C
	public void Release() { }

	// RVA: 0x30D3CF0
	public RefCounted Copy() { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct StyleDataRef<T0>
{
	// Fields
	private RefCounted m_Ref; // 0x0

	// Methods

	// RVA: 0x318DB98
	public UnityEngine.UIElements.StyleDataRef<T> Acquire() { }

	// RVA: 0x30D488C
	public void Release() { }

	// RVA: 0x318DB98
	public void CopyFrom(UnityEngine.UIElements.StyleDataRef<T> other) { }

	// RVA: 0x30D3CF0
	public T Read() { }

	// RVA: 0x30D3CF0
	public T Write() { }

	// RVA: 0x318DB98
	public static UnityEngine.UIElements.StyleDataRef<T> Create() { }

	// RVA: 0x30D39B8
	public override int GetHashCode() { }

	// RVA: 0x318DB98
	public static bool op_Equality(UnityEngine.UIElements.StyleDataRef<T> lhs, UnityEngine.UIElements.StyleDataRef<T> rhs) { }

	// RVA: 0x318DB98
	public bool Equals(UnityEngine.UIElements.StyleDataRef<T> other) { }

	// RVA: 0x30D3858
	public override bool Equals(object obj) { }

	// RVA: 0x318DB98
	public bool ReferenceEquals(UnityEngine.UIElements.StyleDataRef<T> other) { }

}

// Namespace: UnityEngine.UIElements
public struct StyleEnum<T0>
{
	// Fields
	private T m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x0

	// Methods

	// RVA: 0x318DB98
	public T get_value() { }

	// RVA: 0x30D39B8
	public StyleKeyword get_keyword() { }

	// RVA: 0x318DB98
	public void .ctor(T v) { }

	// RVA: 0x30D4A04
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x318DB98
	internal void .ctor(T v, StyleKeyword keyword) { }

	// RVA: 0x318DB98
	public static bool op_Equality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs) { }

	// RVA: 0x318DB98
	public static bool op_Inequality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs) { }

	// RVA: 0x318DB98
	public static UnityEngine.UIElements.StyleEnum<T> op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x318DB98
	public static UnityEngine.UIElements.StyleEnum<T> op_Implicit(T v) { }

	// RVA: 0x318DB98
	public bool Equals(UnityEngine.UIElements.StyleEnum<T> other) { }

	// RVA: 0x30D3858
	public override bool Equals(object obj) { }

	// RVA: 0x30D39B8
	public override int GetHashCode() { }

	// RVA: 0x30D3CF0
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFloat
{
	// Fields
	private float m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x14

	// Methods

	// RVA: 0x189CDD0
	public float get_value() { }

	// RVA: 0x189CDE8
	public StyleKeyword get_keyword() { }

	// RVA: 0x189CDF0
	public void .ctor(float v) { }

	// RVA: 0x189CDFC
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189B5E8
	internal void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0x189CE04
	public static bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0x189B5F4
	public static StyleFloat op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189CE24
	public static StyleFloat op_Implicit(float v) { }

	// RVA: 0x189CE2C
	public bool Equals(StyleFloat other) { }

	// RVA: 0x189CE4C
	public override bool Equals(object obj) { }

	// RVA: 0x189CEE8
	public override int GetHashCode() { }

	// RVA: 0x189CF1C
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFont
{
	// Fields
	private Font m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x18

	// Methods

	// RVA: 0x189CFA0
	public Font get_value() { }

	// RVA: 0x189CFB8
	public StyleKeyword get_keyword() { }

	// RVA: 0x189CFC0
	public void .ctor(Font v) { }

	// RVA: 0x189CFCC
	internal void .ctor(Font v, StyleKeyword keyword) { }

	// RVA: 0x189CFD8
	public static bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0x189D07C
	public static StyleFont op_Implicit(Font v) { }

	// RVA: 0x189D0A8
	public bool Equals(StyleFont other) { }

	// RVA: 0x189D14C
	public override bool Equals(object obj) { }

	// RVA: 0x189D234
	public override int GetHashCode() { }

	// RVA: 0x189D310
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFontDefinition
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private FontDefinition m_Value; // 0x18

	// Methods

	// RVA: 0x189D394
	public FontDefinition get_value() { }

	// RVA: 0x189D3B0
	public StyleKeyword get_keyword() { }

	// RVA: 0x189D3B8
	public void .ctor(FontDefinition f) { }

	// RVA: 0x189D3CC
	internal void .ctor(FontDefinition f, StyleKeyword keyword) { }

	// RVA: 0x189D3E0
	public static StyleFontDefinition op_Implicit(FontDefinition f) { }

	// RVA: 0x189D430
	public bool Equals(StyleFontDefinition other) { }

	// RVA: 0x189D45C
	public override bool Equals(object obj) { }

	// RVA: 0x189D4F8
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleInt
{
	// Fields
	private int m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x14

	// Methods

	// RVA: 0x189D528
	public int get_value() { }

	// RVA: 0x189D540
	public StyleKeyword get_keyword() { }

	// RVA: 0x189D548
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189B680
	internal void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0x189D550
	public static bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0x189B688
	public static StyleInt op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189D55C
	public bool Equals(StyleInt other) { }

	// RVA: 0x189D56C
	public override bool Equals(object obj) { }

	// RVA: 0x189D5FC
	public override int GetHashCode() { }

	// RVA: 0x189D610
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleLength
{
	// Fields
	private Length m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x18

	// Methods

	// RVA: 0x189D694
	public Length get_value() { }

	// RVA: 0x189D6BC
	public StyleKeyword get_keyword() { }

	// RVA: 0x189D6C4
	public void .ctor(float v) { }

	// RVA: 0x189D6EC
	public void .ctor(Length v) { }

	// RVA: 0x189D70C
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189B554
	internal void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0x189D718
	public static bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x189B574
	public static StyleLength op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189D740
	public static StyleLength op_Implicit(float v) { }

	// RVA: 0x189D764
	public static StyleLength op_Implicit(Length v) { }

	// RVA: 0x189D778
	public bool Equals(StyleLength other) { }

	// RVA: 0x189D7AC
	public override bool Equals(object obj) { }

	// RVA: 0x189D858
	public override int GetHashCode() { }

	// RVA: 0x189D894
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleRotate
{
	// Fields
	private Rotate m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x28

	// Methods

	// RVA: 0x189D920
	public Rotate get_value() { }

	// RVA: 0x189DA74
	public StyleKeyword get_keyword() { }

	// RVA: 0x189DA7C
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189DA8C
	internal void .ctor(Rotate v, StyleKeyword keyword) { }

	// RVA: 0x189DAA4
	public static bool op_Equality(StyleRotate lhs, StyleRotate rhs) { }

	// RVA: 0x189DB60
	public static StyleRotate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189DB70
	public bool Equals(StyleRotate other) { }

	// RVA: 0x189DC28
	public override bool Equals(object obj) { }

	// RVA: 0x189DD50
	public override int GetHashCode() { }

	// RVA: 0x189DD80
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleScale
{
	// Fields
	private Scale m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x20

	// Methods

	// RVA: 0x189DE0C
	public Scale get_value() { }

	// RVA: 0x189DF48
	public StyleKeyword get_keyword() { }

	// RVA: 0x189DF50
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189DF5C
	internal void .ctor(Scale v, StyleKeyword keyword) { }

	// RVA: 0x189DF68
	public static bool op_Equality(StyleScale lhs, StyleScale rhs) { }

	// RVA: 0x189DFD0
	public static StyleScale op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189DFDC
	public bool Equals(StyleScale other) { }

	// RVA: 0x189E044
	public override bool Equals(object obj) { }

	// RVA: 0x189E120
	public override int GetHashCode() { }

	// RVA: 0x189E188
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleTranslate
{
	// Fields
	private Translate m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x28

	// Methods

	// RVA: 0x189E214
	public Translate get_value() { }

	// RVA: 0x189E308
	public StyleKeyword get_keyword() { }

	// RVA: 0x189E310
	public void .ctor(Translate v) { }

	// RVA: 0x189E34C
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189E334
	internal void .ctor(Translate v, StyleKeyword keyword) { }

	// RVA: 0x189E35C
	public static bool op_Equality(StyleTranslate lhs, StyleTranslate rhs) { }

	// RVA: 0x189E3D0
	public static StyleTranslate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189E3E0
	public static StyleTranslate op_Implicit(Translate v) { }

	// RVA: 0x189E3F8
	public bool Equals(StyleTranslate other) { }

	// RVA: 0x189E474
	public override bool Equals(object obj) { }

	// RVA: 0x189E564
	public override int GetHashCode() { }

	// RVA: 0x189E5F0
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleTextShadow
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private TextShadow m_Value; // 0x14

	// Methods

	// RVA: 0x189E67C
	public TextShadow get_value() { }

	// RVA: 0x189E6D4
	public StyleKeyword get_keyword() { }

	// RVA: 0x189E6DC
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189E6F4
	internal void .ctor(TextShadow v, StyleKeyword keyword) { }

	// RVA: 0x189E714
	public static bool op_Equality(StyleTextShadow lhs, StyleTextShadow rhs) { }

	// RVA: 0x189E784
	public static StyleTextShadow op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189E79C
	public bool Equals(StyleTextShadow other) { }

	// RVA: 0x189E804
	public override bool Equals(object obj) { }

	// RVA: 0x189E8E0
	public override int GetHashCode() { }

	// RVA: 0x189E92C
	public override string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleTransformOrigin
{
	// Fields
	private TransformOrigin m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x24

	// Methods

	// RVA: 0x189E9B0
	public TransformOrigin get_value() { }

	// RVA: 0x189EA60
	public StyleKeyword get_keyword() { }

	// RVA: 0x189EA68
	public void .ctor(StyleKeyword keyword) { }

	// RVA: 0x189EA74
	internal void .ctor(TransformOrigin v, StyleKeyword keyword) { }

	// RVA: 0x189EA8C
	public static bool op_Equality(StyleTransformOrigin lhs, StyleTransformOrigin rhs) { }

	// RVA: 0x189EAF0
	public static StyleTransformOrigin op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x189EAFC
	public bool Equals(StyleTransformOrigin other) { }

	// RVA: 0x189EB68
	public override bool Equals(object obj) { }

	// RVA: 0x189EC48
	public override int GetHashCode() { }

	// RVA: 0x189ECD4
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

	// RVA: 0x30D77E4
	internal static string DebugString(UnityEngine.UIElements.IStyleValue<T> styleValue) { }

	// RVA: 0x189ED60
	internal static YogaValue ToYogaValue(Length length) { }

	// RVA: 0x189EEC0
	internal static Length ToLength(StyleKeyword keyword) { }

	// RVA: 0x189EFD4
	internal static Rotate ToRotate(StyleKeyword keyword) { }

	// RVA: 0x189F148
	internal static Scale ToScale(StyleKeyword keyword) { }

	// RVA: 0x189F2A4
	internal static Translate ToTranslate(StyleKeyword keyword) { }

	// RVA: 0x189F3F0
	internal static Length ToLength(StyleLength styleLength) { }

	// RVA: 0x30DB358
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

	// RVA: 0x189F420
	public float get_value() { }

	// RVA: 0x189F428
	public TimeUnit get_unit() { }

	// RVA: 0x189F430
	public void .ctor(float value) { }

	// RVA: 0x189F43C
	public void .ctor(float value, TimeUnit unit) { }

	// RVA: 0x189F448
	public static TimeValue op_Implicit(float value) { }

	// RVA: 0x189F450
	public static bool op_Equality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x189F470
	public static bool op_Inequality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x189F490
	public bool Equals(TimeValue other) { }

	// RVA: 0x189F4B0
	public override bool Equals(object obj) { }

	// RVA: 0x189F54C
	public override int GetHashCode() { }

	// RVA: 0x189F580
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

	// RVA: 0x189F6A0
	public void .ctor(Length x, Length y, float z) { }

	// RVA: 0x189EA48
	public static TransformOrigin Initial() { }

	// RVA: 0x189F6AC
	public Length get_x() { }

	// RVA: 0x189F6B4
	public void set_x(Length value) { }

	// RVA: 0x189F6BC
	public Length get_y() { }

	// RVA: 0x189F6C4
	public void set_y(Length value) { }

	// RVA: 0x189F6CC
	public float get_z() { }

	// RVA: 0x1899DE8
	public static bool op_Equality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x189F6D4
	public static bool op_Inequality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x189F728
	public bool Equals(TransformOrigin other) { }

	// RVA: 0x189F77C
	public override bool Equals(object obj) { }

	// RVA: 0x189A258
	public override int GetHashCode() { }

	// RVA: 0x189F844
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

	// RVA: 0x189F9EC
	public void .ctor(Length x, Length y, float z) { }

	// RVA: 0x189E2EC
	public static Translate None() { }

	// RVA: 0x189F9FC
	public Length get_x() { }

	// RVA: 0x189FA04
	public void set_x(Length value) { }

	// RVA: 0x189FA0C
	public Length get_y() { }

	// RVA: 0x189FA14
	public void set_y(Length value) { }

	// RVA: 0x189FA1C
	public float get_z() { }

	// RVA: 0x1899E44
	public static bool op_Equality(Translate lhs, Translate rhs) { }

	// RVA: 0x189FA24
	public static bool op_Inequality(Translate lhs, Translate rhs) { }

	// RVA: 0x189FA8C
	public bool Equals(Translate other) { }

	// RVA: 0x189FAF8
	public override bool Equals(object obj) { }

	// RVA: 0x189A2D8
	public override int GetHashCode() { }

	// RVA: 0x189FBD0
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

	// RVA: 0x30D39B8
	private int get_capacity() { }

	// RVA: 0x30D4A04
	private void set_capacity(int value) { }

	// RVA: 0x30D488C
	private void LocalInit() { }

	// RVA: 0x318DB98
	public static UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<TTimingData,TStyleData> Create() { }

	// RVA: -1
	public bool IndexOf(VisualElement ve, StylePropertyId prop, int index) { }

	// RVA: 0x318DB98
	public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) { }

	// RVA: 0x30D4A04
	public void Remove(int cancelledIndex) { }

	// RVA: 0x318DB98
	public void Replace(int index, TTimingData timingData, TStyleData styleData) { }

	// RVA: 0x30D4CD4
	public void RemoveAll(VisualElement ve) { }

	// RVA: 0x30D488C
	public void RemoveAll() { }

	// RVA: 0x30D4F34
	public void GetActivePropertiesForElement(VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outProperties) { }

}

// Namespace: 
private class EqualityComparer
{
	// Methods

	// RVA: 0x18A17BC
	public bool Equals(ElementPropertyPair x, ElementPropertyPair y) { }

	// RVA: 0x18A17CC
	public int GetHashCode(ElementPropertyPair obj) { }

	// RVA: 0x18A17B4
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

	// RVA: 0x18A1700
	public void .ctor(VisualElement element, StylePropertyId property) { }

	// RVA: 0x18A172C
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

	// RVA: 0x18A1810
	protected void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x30D77AC
	public static System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> GetPooledQueue() { }

	// RVA: 0x30D488C
	public void RegisterChange() { }

	// RVA: 0x30D488C
	public void UnregisterChange() { }

	// RVA: 0x30D3738
	public bool StateChanged() { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D9218
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

	// RVA: 0x30D9218
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

	// RVA: 0x30D3738
	public bool get_isEmpty() { }

	// RVA: -1
	public abstract System.Func<T,T,System.Boolean> get_SameFunc() { }

	// RVA: -1
	protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, T a, T b) { }

	// RVA: 0x30D488C
	protected void .ctor() { }

	// RVA: 0x30D488C
	private void SwapFrameStates() { }

	// RVA: 0x318DB98
	private void QueueEvent(EventBase evt, ElementPropertyPair epp) { }

	// RVA: 0x318DB98
	private void ClearEventQueue(ElementPropertyPair epp) { }

	// RVA: 0x30D4D3C
	private void QueueTransitionRunEvent(VisualElement ve, int runningIndex) { }

	// RVA: 0x30D4D3C
	private void QueueTransitionStartEvent(VisualElement ve, int runningIndex) { }

	// RVA: 0x30D4D3C
	private void QueueTransitionEndEvent(VisualElement ve, int runningIndex) { }

	// RVA: 0x318DB98
	private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, Int64 panelElapsedMs) { }

	// RVA: 0x318DB98
	private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, Int64 panelElapsedMs) { }

	// RVA: 0x30D488C
	public sealed override void CancelAllAnimations() { }

	// RVA: 0x30D4CD4
	public sealed override void CancelAllAnimations(VisualElement ve) { }

	// RVA: 0x30D4D3C
	public sealed override void CancelAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: 0x30D4D3C
	public sealed override void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: 0x30D4F34
	public sealed override void GetAllAnimations(VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: -1
	private float ComputeReversingShorteningFactor(int oldIndex) { }

	// RVA: 0x318DB98
	private int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor) { }

	// RVA: 0x318DB98
	private int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor) { }

	// RVA: 0x318DB98
	public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve, Int64 currentTimeMs) { }

	// RVA: 0x30D4A04
	private void ForceComputedStyleEndValue(int runningIndex) { }

	// RVA: -1
	public sealed override void Update(Int64 currentTimeMs) { }

	// RVA: 0x30D488C
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

	// RVA: 0x18A1818
	public override System.Func<System.Single,System.Single,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A1820
	private static bool IsSame(float a, float b) { }

	// RVA: 0x18A18B8
	private static float Lerp(float a, float b, float t) { }

	// RVA: 0x18A18C8
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A194C
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A1A1C
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A1AD0
	public void .ctor() { }

}

// Namespace: 
private class ValuesInt
{
	// Fields
	private readonly System.Func<System.Int32,System.Int32,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18A1B80
	public override System.Func<System.Int32,System.Int32,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A1B88
	private static bool IsSame(int a, int b) { }

	// RVA: 0x18A1B94
	private static int Lerp(int a, int b, float t) { }

	// RVA: 0x18A1CC0
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A1D5C
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A1E2C
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A1EE0
	public void .ctor() { }

}

// Namespace: 
private class ValuesLength
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18A1F90
	public override System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A1F98
	private static bool IsSame(Length a, Length b) { }

	// RVA: 0x18A2048
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, Length a, Length b) { }

	// RVA: 0x18A2074
	internal static Length Lerp(Length a, Length b, float t) { }

	// RVA: 0x18A20B0
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A2164
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A2234
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A22E8
	public void .ctor() { }

}

// Namespace: 
private class ValuesColor
{
	// Fields
	private readonly System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18A2398
	public override System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A23A0
	private static bool IsSame(Color c, Color d) { }

	// RVA: 0x18A24F4
	private static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x18A252C
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A25B0
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A2688
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A2740
	public void .ctor() { }

}

// Namespace: 
private abstract class ValuesDiscrete<T0>
{
	// Fields
	private readonly System.Func<T,T,System.Boolean> <SameFunc>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30D3CF0
	public override System.Func<T,T,System.Boolean> get_SameFunc() { }

	// RVA: 0x318DB98
	private static bool IsSame(T a, T b) { }

	// RVA: 0x318DB98
	private static T Lerp(T a, T b, float t) { }

	// RVA: 0x30D488C
	protected sealed override void UpdateValues() { }

	// RVA: 0x30D488C
	protected void .ctor() { }

}

// Namespace: 
private class ValuesBackground
{
	// Methods

	// RVA: 0x18A27F0
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A28D4
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A299C
	public void .ctor() { }

}

// Namespace: 
private class ValuesFontDefinition
{
	// Methods

	// RVA: 0x18A29F0
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A2AC4
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A2B78
	public void .ctor() { }

}

// Namespace: 
private class ValuesFont
{
	// Methods

	// RVA: 0x18A2BCC
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A2C9C
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A2D50
	public void .ctor() { }

}

// Namespace: 
private class ValuesTextShadow
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18A2DA4
	public override System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A2DAC
	private static bool IsSame(TextShadow a, TextShadow b) { }

	// RVA: 0x18A2DF4
	private static TextShadow Lerp(TextShadow a, TextShadow b, float t) { }

	// RVA: 0x18A2E5C
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A2F58
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A304C
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A3128
	public void .ctor() { }

}

// Namespace: 
private class ValuesScale
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18A31D8
	public override System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A31E0
	private static bool IsSame(Scale a, Scale b) { }

	// RVA: 0x18A3238
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A330C
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A33C0
	private static Scale Lerp(Scale a, Scale b, float t) { }

	// RVA: 0x18A3430
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A3510
	public void .ctor() { }

}

// Namespace: 
private class ValuesRotate
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18A35C0
	public override System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A35C8
	private static bool IsSame(Rotate a, Rotate b) { }

	// RVA: 0x18A3674
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A3760
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A3834
	private static Rotate Lerp(Rotate a, Rotate b, float t) { }

	// RVA: 0x18A38F4
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A3A34
	public void .ctor() { }

}

// Namespace: 
private class ValuesTranslate
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18A3AE4
	public override System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A3AEC
	private static bool IsSame(Translate a, Translate b) { }

	// RVA: 0x18A3B58
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, Translate a, Translate b) { }

	// RVA: 0x18A3B7C
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A3C68
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A3D3C
	private static Translate Lerp(Translate a, Translate b, float t) { }

	// RVA: 0x18A3DBC
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A3EB4
	public void .ctor() { }

}

// Namespace: 
private class ValuesTransformOrigin
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18A3F64
	public override System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A3F6C
	private static bool IsSame(TransformOrigin a, TransformOrigin b) { }

	// RVA: 0x18A3FC0
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, TransformOrigin a, TransformOrigin b) { }

	// RVA: 0x18A3FE4
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A40D0
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A41A4
	private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) { }

	// RVA: 0x18A4220
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A430C
	public void .ctor() { }

}

// Namespace: 
private class ValuesBackgroundPosition
{
	// Methods

	// RVA: 0x18A43BC
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A44A8
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A4564
	public void .ctor() { }

}

// Namespace: 
private class ValuesBackgroundRepeat
{
	// Methods

	// RVA: 0x18A45B8
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A4688
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A473C
	public void .ctor() { }

}

// Namespace: 
private class ValuesBackgroundSize
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.BackgroundSize,UnityEngine.UIElements.BackgroundSize,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x18A4790
	public override System.Func<UnityEngine.UIElements.BackgroundSize,UnityEngine.UIElements.BackgroundSize,System.Boolean> get_SameFunc() { }

	// RVA: 0x18A4798
	private static bool IsSame(BackgroundSize a, BackgroundSize b) { }

	// RVA: 0x18A47E0
	protected sealed override bool ConvertUnits(VisualElement owner, StylePropertyId prop, BackgroundSize a, BackgroundSize b) { }

	// RVA: 0x18A4804
	protected sealed override void UpdateComputedStyle() { }

	// RVA: 0x18A48F0
	protected sealed override void UpdateComputedStyle(int i) { }

	// RVA: 0x18A49C4
	private static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t) { }

	// RVA: 0x18A4AB4
	protected sealed override void UpdateValues() { }

	// RVA: 0x18A4C6C
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

	// RVA: 0x189FD78
	public void .ctor() { }

	// RVA: 0x318DB98
	private T GetOrCreate(T values) { }

	// RVA: 0x318DB98
	private bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve, UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values) { }

	// RVA: 0x189FE98
	public bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x189FF88
	public bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A0070
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A0154
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A027C
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A037C
	public bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A0474
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A0554
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A0674
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A076C
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A088C
	public bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A09AC
	public bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A0ACC
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A0BCC
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A0CB0
	public bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x18A0DD0
	public void CancelAllAnimations() { }

	// RVA: 0x18A0F94
	public void CancelAllAnimations(VisualElement owner) { }

	// RVA: 0x18A12C8
	public void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x18A1368
	public void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x18A1408
	public void GetAllAnimations(VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds) { }

	// RVA: 0x30D4CD4
	private void UpdateTracking(UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values) { }

	// RVA: 0x18A15EC
	private Int64 CurrentTimeMs() { }

	// RVA: 0x18A15F4
	public void Update() { }

}

// Namespace: UnityEngine.UIElements
public struct StylePropertyName
{
	// Fields
	private readonly StylePropertyId <id>k__BackingField; // 0x10
	private readonly string <name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x18A4D1C
	internal StylePropertyId get_id() { }

	// RVA: 0x18A4D24
	private string get_name() { }

	// RVA: 0x18A4D2C
	internal static StylePropertyId StylePropertyIdFromString(string name) { }

	// RVA: 0x18A4DF4
	internal void .ctor(StylePropertyId stylePropertyId) { }

	// RVA: 0x18A4EC4
	public void .ctor(string name) { }

	// RVA: 0x18A4FC0
	public static bool op_Equality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x18A4FCC
	public static bool op_Inequality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x18A4FD8
	public static StylePropertyName op_Implicit(string name) { }

	// RVA: 0x18A5004
	public override int GetHashCode() { }

	// RVA: 0x18A500C
	public override bool Equals(object other) { }

	// RVA: 0x18A509C
	public bool Equals(StylePropertyName other) { }

	// RVA: 0x18A50AC
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

	// RVA: 0x18A56AC
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

	// RVA: 0x18A5E8C
	private static void .cctor() { }

	// RVA: 0x18A5EF8
	public void .ctor() { }

	// RVA: 0x18A5F00
	internal string <ToString>b__24_0(StyleSelector x) { }

	// RVA: 0x18A5F28
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

	// RVA: 0x18A50B4
	public int get_specificity() { }

	// RVA: 0x18A50BC
	public StyleRule get_rule() { }

	// RVA: 0x18A50C4
	internal void set_rule(StyleRule value) { }

	// RVA: 0x18A50CC
	public bool get_isSimple() { }

	// RVA: 0x18A50D4
	public StyleSelector[] get_selectors() { }

	// RVA: 0x18A50DC
	internal void set_selectors(StyleSelector[] value) { }

	// RVA: 0x18A5124
	public void OnBeforeSerialize() { }

	// RVA: 0x18A5128
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x18A5154
	internal void CachePseudoStateMasks() { }

	// RVA: 0x18A56D0
	public override string ToString() { }

	// RVA: 0x18A584C
	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	// RVA: 0x18A58A0
	internal void CalculateHashes() { }

	// RVA: 0x18A5DF0
	public void .ctor() { }

	// RVA: 0x18A5DF8
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

	// RVA: 0x18A5F40
	public string get_name() { }

	// RVA: 0x18A5F48
	public StyleValueHandle[] get_values() { }

	// RVA: 0x18A5F50
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

	// RVA: 0x18A5F58
	public StyleProperty[] get_properties() { }

	// RVA: 0x18A5F60
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

	// RVA: 0x18A60E4
	private static void .cctor() { }

	// RVA: 0x18A6150
	public void .ctor() { }

	// RVA: 0x18A6158
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

	// RVA: 0x18A56B8
	public StyleSelectorPart[] get_parts() { }

	// RVA: 0x18A5F68
	internal void set_parts(StyleSelectorPart[] value) { }

	// RVA: 0x18A5F70
	public StyleSelectorRelationship get_previousRelationship() { }

	// RVA: 0x18A5F78
	internal void set_previousRelationship(StyleSelectorRelationship value) { }

	// RVA: 0x18A5F80
	public override string ToString() { }

	// RVA: 0x18A60D4
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

	// RVA: 0x18A56C8
	public string get_value() { }

	// RVA: 0x18A56C0
	public StyleSelectorType get_type() { }

	// RVA: 0x18A6294
	internal void set_type(StyleSelectorType value) { }

	// RVA: 0x18A6160
	public override string ToString() { }

	// RVA: 0x18A629C
	public static StyleSelectorPart CreateClass(string className) { }

	// RVA: 0x18A62EC
	public static StyleSelectorPart CreateId(string Id) { }

	// RVA: 0x18A633C
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

	// RVA: 0x18A6390
	public bool get_importedWithErrors() { }

	// RVA: 0x18A6398
	internal void set_importedWithErrors(bool value) { }

	// RVA: 0x18A63A0
	public bool get_importedWithWarnings() { }

	// RVA: 0x18A63A8
	internal void set_importedWithWarnings(bool value) { }

	// RVA: 0x18A63B0
	internal StyleRule[] get_rules() { }

	// RVA: 0x18A63B8
	internal void set_rules(StyleRule[] value) { }

	// RVA: 0x18A6A30
	internal StyleComplexSelector[] get_complexSelectors() { }

	// RVA: 0x18A6A38
	internal void set_complexSelectors(StyleComplexSelector[] value) { }

	// RVA: 0x18A6A60
	internal System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_flattenedRecursiveImports() { }

	// RVA: 0x18A6A68
	public int get_contentHash() { }

	// RVA: 0x18A6A70
	public void set_contentHash(int value) { }

	// RVA: 0x18A6A78
	internal bool get_isDefaultStyleSheet() { }

	// RVA: 0x18A6A80
	internal void set_isDefaultStyleSheet(bool value) { }

	// RVA: 0x318DB98
	private bool TryCheckAccess(T[] list, StyleValueType type, StyleValueHandle handle, T value) { }

	// RVA: 0x318DB98
	private T CheckAccess(T[] list, StyleValueType type, StyleValueHandle handle) { }

	// RVA: 0x18A6C54
	internal virtual void OnEnable() { }

	// RVA: 0x18A6C58
	internal void FlattenImportedStyleSheetsRecursive() { }

	// RVA: 0x18A6CE4
	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	// RVA: 0x18A63E0
	private void SetupReferences() { }

	// RVA: 0x18A6ED8
	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	// RVA: 0x18A6EE0
	internal float ReadFloat(StyleValueHandle handle) { }

	// RVA: 0x18A6FB0
	internal bool TryReadFloat(StyleValueHandle handle, float value) { }

	// RVA: 0x18A708C
	internal Dimension ReadDimension(StyleValueHandle handle) { }

	// RVA: 0x18A716C
	internal bool TryReadDimension(StyleValueHandle handle, Dimension value) { }

	// RVA: 0x18A7254
	internal Color ReadColor(StyleValueHandle handle) { }

	// RVA: 0x18A72D0
	internal bool TryReadColor(StyleValueHandle handle, Color value) { }

	// RVA: 0x18A7344
	internal string ReadString(StyleValueHandle handle) { }

	// RVA: 0x18A73BC
	internal bool TryReadString(StyleValueHandle handle, string value) { }

	// RVA: 0x18A7430
	internal string ReadEnum(StyleValueHandle handle) { }

	// RVA: 0x18A74A8
	internal bool TryReadEnum(StyleValueHandle handle, string value) { }

	// RVA: 0x18A751C
	internal string ReadVariable(StyleValueHandle handle) { }

	// RVA: 0x18A7594
	internal bool TryReadVariable(StyleValueHandle handle, string value) { }

	// RVA: 0x18A7608
	internal string ReadResourcePath(StyleValueHandle handle) { }

	// RVA: 0x18A7680
	internal bool TryReadResourcePath(StyleValueHandle handle, string value) { }

	// RVA: 0x18A76F4
	internal object ReadAssetReference(StyleValueHandle handle) { }

	// RVA: 0x18A776C
	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	// RVA: 0x18A77E4
	internal bool TryReadAssetReference(StyleValueHandle handle, object value) { }

	// RVA: 0x18A7858
	internal StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	// RVA: 0x18A7860
	internal string ReadFunctionName(StyleValueHandle handle) { }

	// RVA: 0x18A7B1C
	internal ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	// RVA: 0x18A6E04
	private static bool CustomStartsWith(string originalString, string pattern) { }

	// RVA: 0x18A7B94
	public void .ctor() { }

	// RVA: 0x18A7B9C
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

	// RVA: 0x18A7A20
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

	// RVA: 0x18A6FA8
	public StyleValueType get_valueType() { }

	// RVA: 0x18A7C14
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

	// RVA: 0x18A7C1C
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

	// RVA: 0x18A7D44
	public void .ctor(string name, StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x18A7D94
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

	// RVA: 0x18A7E0C
	public void Add(StyleVariable sv) { }

	// RVA: 0x18A80E4
	public void AddInitialRange(StyleVariableContext other) { }

	// RVA: 0x18A8200
	public void Clear() { }

	// RVA: 0x18A8384
	public void .ctor() { }

	// RVA: 0x18A848C
	public void .ctor(StyleVariableContext other) { }

	// RVA: 0x18A85C4
	public bool TryFindVariable(string name, StyleVariable v) { }

	// RVA: 0x18A86C0
	public int GetVariableHash() { }

	// RVA: 0x18A86C8
	private static void .cctor() { }

	// RVA: 0x18A80D8
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

	// RVA: 0x18A8730
	private StyleSheet get_currentSheet() { }

	// RVA: 0x18A8738
	private StyleValueHandle[] get_currentHandles() { }

	// RVA: 0x18A8740
	public System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> get_resolvedValues() { }

	// RVA: 0x18A8748
	public StyleVariableContext get_variableContext() { }

	// RVA: 0x18A8750
	public void set_variableContext(StyleVariableContext value) { }

	// RVA: 0x18A8758
	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x18A8850
	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x18A890C
	private void PopContext() { }

	// RVA: 0x18A89AC
	public void AddValue(StyleValueHandle handle) { }

	// RVA: 0x18A8A3C
	public bool ResolveVarFunction(int index) { }

	// RVA: 0x18A8CA8
	private Result ResolveVarFunction(int index, int argc, string varName) { }

	// RVA: 0x18A92FC
	public bool ValidateResolvedValues() { }

	// RVA: 0x18A8E38
	private Result ResolveVariable(string variableName) { }

	// RVA: 0x18A909C
	private Result ResolveFallback(int index) { }

	// RVA: 0x18A8B14
	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, int index, int argCount, string variableName) { }

	// RVA: 0x18A948C
	public void .ctor() { }

	// RVA: 0x18A9600
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
[Serializable]
public class ThemeStyleSheet
{
	// Methods

	// RVA: 0x18A9688
	internal override void OnEnable() { }

	// RVA: 0x18A96B0
	public void .ctor() { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x18A97FC
	public override string get_uxmlName() { }

	// RVA: 0x18A9840
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x18A98C0
	public void .ctor() { }

}

// Namespace: 
public class UxmlTraits
{
	// Fields
	private UxmlStringAttributeDescription m_Template; // 0x78

	// Methods

	// RVA: 0x18A9914
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x18A9D8C
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

	// RVA: 0x18A9738
	public string get_templateId() { }

	// RVA: 0x18A9740
	private void set_templateId(string value) { }

	// RVA: 0x18A9750
	internal void set_templateSource(VisualTreeAsset value) { }

	// RVA: 0x18A9760
	public void .ctor() { }

	// RVA: 0x18A97A0
	public void .ctor(string templateId) { }

	// RVA: 0x18A97E4
	public override VisualElement get_contentContainer() { }

	// RVA: 0x18A97EC
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

	// RVA: 0x18A9E38
	internal static PanelTextSettings get_defaultPanelTextSettings() { }

	// RVA: 0x18AA008
	internal static void UpdateLocalizationFontAsset() { }

	// RVA: 0x18AA69C
	internal FontAsset GetCachedFontAsset(Font font) { }

	// RVA: 0x18AA6A4
	public void .ctor() { }

	// RVA: 0x18AA6AC
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

	// RVA: 0x18AA718
	private bool get_touchScreenTextFieldChanged() { }

	// RVA: 0x18AA8B8
	public void .ctor(TextElement textElement) { }

	// RVA: 0x18AA9A8
	private void InitTextEditorEventHandler() { }

	// RVA: 0x18AAA7C
	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x18AAC10
	private void OnFocusInEvent(FocusInEvent _) { }

	// RVA: 0x18AAF0C
	private void OnFocusOutEvent(FocusOutEvent _) { }

	// RVA: 0x18AAFC4
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

	// RVA: 0x18AB014
	internal bool get_isClicking() { }

	// RVA: 0x18AB01C
	internal void set_isClicking(bool value) { }

	// RVA: 0x18AB030
	public void .ctor(TextElement textElement) { }

	// RVA: 0x18AB2F8
	internal int get_cursorIndex() { }

	// RVA: 0x18AB310
	internal void set_cursorIndex(int value) { }

	// RVA: 0x18AB330
	internal int get_selectIndex() { }

	// RVA: 0x18AB348
	internal void set_selectIndex(int value) { }

	// RVA: 0x18AB368
	private void OnRevealCursor() { }

	// RVA: 0x18AB38C
	private void OnSelectIndexChange() { }

	// RVA: 0x18AB51C
	private void OnCursorIndexChange() { }

	// RVA: 0x18AB68C
	internal bool RevealCursor() { }

	// RVA: 0x18AB4FC
	internal bool HasSelection() { }

	// RVA: 0x18AB6AC
	internal bool HasFocus() { }

	// RVA: 0x18AB6CC
	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x18AB944
	private void OnFocusEvent(FocusEvent evt) { }

	// RVA: 0x18ABC00
	private void OnBlurEvent(BlurEvent evt) { }

	// RVA: 0x18AC12C
	private void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x18ABCC0
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x18AC1A4
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x18AC3F8
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x18AC4C4
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	// RVA: 0x18AC658
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	// RVA: 0x18AC798
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

	// RVA: 0x18AC7BC
	public void .ctor(TextElement te) { }

	// RVA: 0x18AC844
	public Vector2 get_MeasuredSizes() { }

	// RVA: 0x18AC84C
	public void set_MeasuredSizes(Vector2 value) { }

	// RVA: 0x18AC854
	public Vector2 get_RoundedSizes() { }

	// RVA: 0x18AC85C
	public void set_RoundedSizes(Vector2 value) { }

	// RVA: 0x18AC864
	public float ComputeTextWidth(string textToMeasure, bool wordWrap, float width, float height) { }

	// RVA: 0x18ACCB8
	public float ComputeTextHeight(string textToMeasure, float width, float height) { }

	// RVA: 0x18ACD7C
	public TextInfo Update() { }

	// RVA: 0x18AD80C
	private void ATagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x18AD9A0
	private void ATagOnPointerOver(PointerOverEvent _) { }

	// RVA: 0x18AD9A8
	private void ATagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x18ADC5C
	private void ATagOnPointerOut(PointerOutEvent _) { }

	// RVA: 0x18ADC64
	internal void LinkTagOnPointerDown(PointerDownEvent pde) { }

	// RVA: 0x18ADF00
	internal void LinkTagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x18AE19C
	internal void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x18AE6F0
	private void LinkTagOnPointerOut(PointerOutEvent poe) { }

	// RVA: 0x18AD3F8
	private void HandleLinkTag() { }

	// RVA: 0x18ACE88
	private void HandleATag() { }

	// RVA: 0x18AE8C8
	private TextOverflowMode GetTextOverflowMode() { }

	// RVA: 0x18AC938
	internal void ConvertUssToTextGenerationSettings(TextGenerationSettings tgs) { }

	// RVA: 0x18AE98C
	internal bool TextLibraryCanElide() { }

	// RVA: 0x18AE9C0
	internal float GetTextEffectPadding(FontAsset fontAsset) { }

	// RVA: 0x18AEB6C
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class TextUtilities
{
	// Methods

	// RVA: 0x176DA3C
	internal static Vector2 MeasureVisualElementTextSize(TextElement te, string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	// RVA: 0x176DC9C
	internal static FontAsset GetFontAsset(VisualElement ve) { }

	// RVA: 0x176DBB0
	internal static bool IsFontAssigned(VisualElement ve) { }

	// RVA: 0x176DE70
	internal static PanelTextSettings GetTextSettingsFrom(VisualElement ve) { }

	// RVA: 0x176DF4C
	internal static float ConvertPixelUnitsToTextCoreRelativeUnits(VisualElement ve, FontAsset fontAsset) { }

	// RVA: 0x176E008
	internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve) { }

}

// Namespace: 
public class UxmlFactory
{
	// Methods

	// RVA: 0x1773100
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

	// RVA: 0x1773154
	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1773330
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

	// RVA: 0x176E414
	public void .ctor() { }

	// RVA: 0x176E668
	internal UITKTextHandle get_uitkTextHandle() { }

	// RVA: 0x176E670
	internal void set_uitkTextHandle(UITKTextHandle value) { }

	// RVA: 0x176E680
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x176E7DC
	public virtual string get_text() { }

	// RVA: 0x176E890
	public virtual void set_text(string value) { }

	// RVA: 0x176E93C
	public bool get_enableRichText() { }

	// RVA: 0x176E944
	public void set_enableRichText(bool value) { }

	// RVA: 0x176E960
	public bool get_parseEscapeSequences() { }

	// RVA: 0x176E968
	public void set_parseEscapeSequences(bool value) { }

	// RVA: 0x176E984
	public bool get_displayTooltipWhenElided() { }

	// RVA: 0x176E98C
	public void set_displayTooltipWhenElided(bool value) { }

	// RVA: 0x176E9D0
	public bool get_isElided() { }

	// RVA: 0x176E9D8
	private void set_isElided(bool value) { }

	// RVA: 0x176E9E0
	internal void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x176FDC8
	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	// RVA: 0x176EDE8
	private void UpdateTooltip() { }

	// RVA: 0x176E684
	private void UpdateVisibleText() { }

	// RVA: 0x176ED88
	private bool ShouldElide() { }

	// RVA: 0x17702D8
	internal bool get_hasFocus() { }

	// RVA: 0x17702D4
	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	// RVA: 0x1770320
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x17705A0
	private string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	// RVA: 0x177060C
	private void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	// RVA: 0x17708D4
	private void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	// RVA: 0x176F9D4
	internal ITextEdition get_edition() { }

	// RVA: 0x1770AC8
	private bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	// RVA: 0x1770AD0
	private void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	// RVA: 0x1770BB8
	private TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	// RVA: 0x1770BC0
	private void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1770BC8
	private bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	// RVA: 0x1770C94
	private void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	// RVA: 0x1770D5C
	private bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	// RVA: 0x1770D8C
	private void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	// RVA: 0x1770E3C
	private void ProcessMenuCommand(string command) { }

	// RVA: 0x1770FAC
	private void Cut(DropdownMenuAction a) { }

	// RVA: 0x1771000
	private void Copy(DropdownMenuAction a) { }

	// RVA: 0x1771054
	private void Paste(DropdownMenuAction a) { }

	// RVA: 0x17710A8
	private void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x1771438
	private Status CutActionStatus(DropdownMenuAction a) { }

	// RVA: 0x177158C
	private Status CopyActionStatus(DropdownMenuAction a) { }

	// RVA: 0x17716E4
	private Status PasteActionStatus(DropdownMenuAction a) { }

	// RVA: 0x1771744
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x1771C1C
	private int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	// RVA: 0x1771C24
	private void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	// RVA: 0x1771D04
	private bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	// RVA: 0x1771D0C
	private void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	// RVA: 0x1771D14
	private void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	// RVA: 0x1771D4C
	private void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	// RVA: 0x1771D60
	private System.Func<System.Char,System.Boolean> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	// RVA: 0x1771D68
	private void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(System.Func<System.Char,System.Boolean> value) { }

	// RVA: 0x1771D78
	private System.Action<System.Boolean> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	// RVA: 0x1771D80
	private void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(System.Action<System.Boolean> value) { }

	// RVA: 0x1771D90
	private Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	// RVA: 0x1771D98
	private void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	// RVA: 0x1771DA8
	private Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	// RVA: 0x1771DB0
	private void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	// RVA: 0x1771DC0
	private Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	// RVA: 0x1771DC8
	private void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	// RVA: 0x1771DD8
	private void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	// RVA: 0x1772070
	private string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	// RVA: 0x177216C
	private void UnityEngine.UIElements.ITextEdition.set_maskChar(Char value) { }

	// RVA: 0x1772254
	private Char get_effectiveMaskChar() { }

	// RVA: 0x1772314
	private bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	// RVA: 0x177231C
	private void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	// RVA: 0x177233C
	private bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	// RVA: 0x1772344
	private void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	// RVA: 0x1770378
	internal string get_renderedText() { }

	// RVA: 0x1770A5C
	internal void set_renderedText(string value) { }

	// RVA: 0x177234C
	internal string get_originalText() { }

	// RVA: 0x176EE68
	public ITextSelection get_selection() { }

	// RVA: 0x1772354
	private bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	// RVA: 0x1772374
	private void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	// RVA: 0x177238C
	private int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	// RVA: 0x17724C4
	private void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	// RVA: 0x1772600
	private int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	// RVA: 0x1772738
	private void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	// RVA: 0x1772874
	private void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	// RVA: 0x17729AC
	private void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	// RVA: 0x1772AE4
	private bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	// RVA: 0x1772C18
	private bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	// RVA: 0x1772C20
	private bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	// RVA: 0x1772C28
	private bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	// RVA: 0x1772C30
	private void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	// RVA: 0x1772C38
	private bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	// RVA: 0x1772C40
	private void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	// RVA: 0x1772C48
	private Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	// RVA: 0x1772D44
	private float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	// RVA: 0x1772E10
	private Color UnityEngine.UIElements.ITextSelection.get_selectionColor() { }

	// RVA: 0x1772E24
	private void UnityEngine.UIElements.ITextSelection.set_selectionColor(Color value) { }

	// RVA: 0x1772E90
	private Color UnityEngine.UIElements.ITextSelection.get_cursorColor() { }

	// RVA: 0x1772EA4
	private void UnityEngine.UIElements.ITextSelection.set_cursorColor(Color value) { }

	// RVA: 0x1772F10
	private float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	// RVA: 0x176EE6C
	internal TextSelectingManipulator get_selectingManipulator() { }

	// RVA: 0x176EF0C
	private void DrawHighlighting(MeshGenerationContext mgc) { }

	// RVA: 0x176F9D8
	internal void DrawCaret(MeshGenerationContext mgc) { }

	// RVA: 0x1772F18
	private int GetLastCharacterAt(int lineIndex) { }

	// RVA: 0x1773060
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

	// RVA: 0x17736C4
	public virtual bool get_autoCorrection() { }

	// RVA: 0x1773790
	public virtual void set_autoCorrection(bool value) { }

	// RVA: 0x177386C
	public virtual bool get_hideMobileInput() { }

	// RVA: 0x1773938
	public virtual void set_hideMobileInput(bool value) { }

	// RVA: 0x1773A14
	public virtual TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1773AE0
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

	// RVA: 0x1773BBC
	public override bool Equals(object obj) { }

	// RVA: 0x1773CB4
	public bool Equals(TextShadow other) { }

	// RVA: 0x1773D38
	public override int GetHashCode() { }

	// RVA: 0x1773E14
	public static bool op_Equality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x1773E98
	public static bool op_Inequality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x1773F18
	public override string ToString() { }

	// RVA: 0x177400C
	internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class UIElementsBridge
{
	// Methods

	// RVA: -1
	public abstract void SetWantsMouseJumping(int value) { }

	// RVA: 0x177405C
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class RuntimeUIElementsBridge
{
	// Methods

	// RVA: 0x1774064
	public override void SetWantsMouseJumping(int value) { }

	// RVA: 0x1774068
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIElementsPackageUtility
{
	// Fields
	private static bool <IsUIEPackageLoaded>k__BackingField; // 0x0
	private static string <EditorResourcesBasePath>k__BackingField; // 0x8

	// Methods

	// RVA: 0x1774070
	internal static bool get_IsUIEPackageLoaded() { }

	// RVA: 0x17740EC
	private static void set_IsUIEPackageLoaded(bool value) { }

	// RVA: 0x1774178
	internal static string get_EditorResourcesBasePath() { }

	// RVA: 0x17741F4
	private static void set_EditorResourcesBasePath(string value) { }

	// RVA: 0x1774260
	private static void .cctor() { }

	// RVA: 0x1774264
	internal static void Refresh() { }

}

// Namespace: 
public sealed class CreateRuntimePanelDelegate
{
	// Methods

	// RVA: 0x1777A28
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1777B48
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

	// RVA: 0x1777B5C
	private static void .cctor() { }

	// RVA: 0x1777BC8
	public void .ctor() { }

	// RVA: 0x1777BD0
	internal void <.cctor>b__9_0() { }

	// RVA: 0x1777BD4
	internal void <.cctor>b__9_1(int displayIndex, int sortOrder) { }

	// RVA: 0x1777C60
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

	// RVA: 0x17743AC
	public static void add_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value) { }

	// RVA: 0x17744BC
	public static void remove_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value) { }

	// RVA: 0x17745CC
	private static void .cctor() { }

	// RVA: 0x1774998
	public static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x1774DD0
	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate) { }

	// RVA: 0x1775508
	public static void DisposeRuntimePanel(ScriptableObject ownerObject) { }

	// RVA: 0x1775324
	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel) { }

	// RVA: 0x17750B8
	private static void RemoveCachedPanelInternal(int instanceID) { }

	// RVA: 0x1775CBC
	public static void RepaintOffscreenPanels() { }

	// RVA: 0x1776050
	public static void RepaintOverlayPanel(BaseRuntimePanel panel) { }

	// RVA: 0x17761D0
	internal static void BeginRenderOverlays(int displayIndex) { }

	// RVA: 0x177624C
	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) { }

	// RVA: 0x177644C
	internal static void EndRenderOverlays(int displayIndex) { }

	// RVA: 0x17764C8
	internal static object get_activeEventSystem() { }

	// RVA: 0x1776544
	private static void set_activeEventSystem(object value) { }

	// RVA: 0x17765B0
	internal static bool get_useDefaultEventSystem() { }

	// RVA: 0x17766C4
	public static void RegisterEventSystem(object eventSystem) { }

	// RVA: 0x1776998
	public static void UnregisterEventSystem(object eventSystem) { }

	// RVA: 0x1776B38
	internal static DefaultEventSystem get_defaultEventSystem() { }

	// RVA: 0x1776C10
	public static void UpdateRuntimePanels() { }

	// RVA: 0x17771EC
	internal static void MarkPotentiallyEmpty(PanelSettings settings) { }

	// RVA: 0x1776F10
	internal static void RemoveUnusedPanels() { }

	// RVA: 0x1775724
	public static void RegisterPlayerloopCallback() { }

	// RVA: 0x1775C64
	public static void UnregisterPlayerloopCallback() { }

	// RVA: 0x17772E8
	internal static void SetPanelOrderingDirty() { }

	// RVA: 0x1775F7C
	internal static System.Collections.Generic.List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels() { }

	// RVA: 0x177736C
	private static void SortPanels() { }

	// RVA: 0x1777694
	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, System.Nullable<System.Int32>& targetDisplay) { }

	// RVA: 0x17777BC
	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, System.Nullable<System.Int32>& targetDisplay) { }

	// RVA: 0x1777930
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	// RVA: 0x1777A20
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

	// RVA: 0x1779368
	private static void .cctor() { }

	// RVA: 0x17793D4
	public void .ctor() { }

	// RVA: 0x17793DC
	internal void <.cctor>b__1_0() { }

	// RVA: 0x1779444
	internal void <.cctor>b__1_1() { }

	// RVA: 0x17794AC
	internal bool <.cctor>b__1_2(int i, IntPtr ptr) { }

	// RVA: 0x1779538
	internal void <.cctor>b__1_3() { }

	// RVA: 0x17795A0
	internal bool <.cctor>b__1_4(Exception exception) { }

	// RVA: 0x1779620
	internal void <.cctor>b__1_5() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIEventRegistration
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.IUIElementsUtility> s_Utilities; // 0x0

	// Methods

	// RVA: 0x1777DF4
	private static void .cctor() { }

	// RVA: 0x1778320
	internal static void RegisterUIElementSystem(IUIElementsUtility utility) { }

	// RVA: 0x17783C8
	private static void TakeCapture() { }

	// RVA: 0x1778644
	private static void ReleaseCapture() { }

	// RVA: 0x17788C4
	private static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x1778BA0
	private static bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0x1778E68
	private static void CleanupRoots() { }

	// RVA: 0x17790E8
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

	// RVA: 0x1779688
	private void .ctor() { }

	// RVA: 0x1779790
	private bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0x1779888
	private bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }

	// RVA: 0x177997C
	private bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }

	// RVA: 0x1779984
	private bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, bool eventHandled) { }

	// RVA: 0x177A0E0
	private bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }

	// RVA: 0x177A178
	private bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x1775668
	public static void RegisterCachedPanel(int instanceID, Panel panel) { }

	// RVA: 0x17757C8
	public static void RemoveCachedPanel(int instanceID) { }

	// RVA: 0x1774FFC
	public static bool TryGetPanel(int instanceID, Panel panel) { }

	// RVA: 0x177A2A8
	internal static void BeginContainerGUI(LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0x177A534
	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0x177A7AC
	internal static EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x1774A2C
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0x1779AA4
	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0x177587C
	internal static void GetAllPanels(System.Collections.Generic.List<UnityEngine.UIElements.Panel> panels, ContextType contextType) { }

	// RVA: 0x177A840
	internal static Enumerator GetPanelsIterator() { }

	// RVA: 0x177A918
	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) { }

	// RVA: 0x177AA0C
	internal static string ParseMenuName(string menuName) { }

	// RVA: 0x177AB60
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct RuleMatcher
{
	// Fields
	public StyleSheet sheet; // 0x10
	public StyleComplexSelector complexSelector; // 0x18

	// Methods

	// RVA: 0x177AE20
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

	// RVA: 0x30D3858
	public bool Predicate(object e) { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D9218
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

	// RVA: 0x177B0B4
	private static void .cctor() { }

	// RVA: 0x177B120
	public void .ctor() { }

	// RVA: 0x177B128
	internal void <TraverseRecursive>b__5_0(VisualElement e, MatchResultInfo i) { }

}

// Namespace: 
internal abstract class UQueryMatcher
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers; // 0x10

	// Methods

	// RVA: 0x177AE44
	protected void .ctor() { }

	// RVA: 0x177AE4C
	public override void Traverse(VisualElement element) { }

	// RVA: 0x177AE54
	protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x177AE5C
	private static void NoProcessResult(VisualElement e, MatchResultInfo i) { }

	// RVA: 0x177AE60
	public override void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x177B078
	public virtual void Run(VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

}

// Namespace: 
internal abstract class SingleQueryMatcher
{
	// Fields
	private VisualElement <match>k__BackingField; // 0x18

	// Methods

	// RVA: 0x177B12C
	public VisualElement get_match() { }

	// RVA: 0x177B134
	public void set_match(VisualElement value) { }

	// RVA: 0x177B13C
	public override void Run(VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

	// RVA: 0x177B1A8
	public bool IsInUse() { }

	// RVA: -1
	public abstract SingleQueryMatcher CreateNew() { }

	// RVA: 0x177B1B8
	protected void .ctor() { }

}

// Namespace: 
internal class FirstQueryMatcher
{
	// Fields
	public static readonly FirstQueryMatcher Instance; // 0x0

	// Methods

	// RVA: 0x177B1C0
	protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x177B1F4
	public override SingleQueryMatcher CreateNew() { }

	// RVA: 0x177B24C
	public void .ctor() { }

	// RVA: 0x177B254
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

	// RVA: 0x30D3CF0
	public System.Collections.Generic.List<TElement> get_matches() { }

	// RVA: 0x30D4CD4
	public void set_matches(System.Collections.Generic.List<TElement> value) { }

	// RVA: -1
	protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: 
private class ActionQueryMatcher
{
	// Fields
	private System.Action<T> <callBack>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30D3CF0
	internal System.Action<T> get_callBack() { }

	// RVA: -1
	protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> iterationList; // 0x0
	private int currentIndex; // 0x0

	// Methods

	// RVA: 0x318DB98
	internal void .ctor(UnityEngine.UIElements.UQueryState<T> queryState) { }

	// RVA: 0x318DB98
	public T get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D4F34
	internal void .ctor(VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

	// RVA: 0x318DB98
	public UnityEngine.UIElements.UQueryState<T> RebuildOn(VisualElement element) { }

	// RVA: 0x318DB98
	private T Single(SingleQueryMatcher matcher) { }

	// RVA: 0x318DB98
	public T First() { }

	// RVA: 0x318DB98
	public Enumerator GetEnumerator() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x318DB98
	public bool Equals(UnityEngine.UIElements.UQueryState<T> other) { }

	// RVA: 0x30D3858
	public override bool Equals(object obj) { }

	// RVA: 0x30D39B8
	public override int GetHashCode() { }

	// RVA: 0x30D9218
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

	// RVA: 0x30D3CF0
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> get_styleSelectors() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> get_parts() { }

	// RVA: 0x30D4CD4
	public void .ctor(VisualElement visualElement) { }

	// RVA: 0x318DB98
	public UnityEngine.UIElements.UQueryBuilder<T> Class(string classname) { }

	// RVA: 0x318DB98
	public UnityEngine.UIElements.UQueryBuilder<T> Name(string id) { }

	// RVA: 0x318DB98
	internal UnityEngine.UIElements.UQueryBuilder<T> SingleBaseType() { }

	// RVA: 0x30D4CD4
	private void AddClass(string c) { }

	// RVA: 0x30D4CD4
	private void AddName(string id) { }

	// RVA: 0x30D488C
	private void AddPseudoStatesRuleIfNecessasy() { }

	// RVA: 0x30D488C
	private void FinishSelector() { }

	// RVA: 0x30D3738
	private bool CurrentSelectorEmpty() { }

	// RVA: 0x30D488C
	private void FinishCurrentSelector() { }

	// RVA: 0x318DB98
	public UnityEngine.UIElements.UQueryState<T> Build() { }

	// RVA: 0x318DB98
	public bool Equals(UnityEngine.UIElements.UQueryBuilder<T> other) { }

	// RVA: 0x30D3858
	public override bool Equals(object obj) { }

	// RVA: 0x30D39B8
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

	// RVA: 0x318DB98
	public static T Q(VisualElement e, string name, string className) { }

	// RVA: 0x177B2C0
	public static VisualElement Q(VisualElement e, string name, string className) { }

	// RVA: 0x177B760
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

	// RVA: 0x177BCC0
	public override string get_uxmlName() { }

	// RVA: 0x177BD04
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x177BD84
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177BD8C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlRootElementTraits
{
	// Fields
	protected UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Class; // 0x20

	// Methods

	// RVA: 0x177BDE0
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlStyleFactory
{
	// Methods

	// RVA: 0x177BF00
	public override string get_uxmlName() { }

	// RVA: 0x177BF44
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x177BFC4
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177BFCC
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

	// RVA: 0x177C020
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlTemplateFactory
{
	// Methods

	// RVA: 0x177C15C
	public override string get_uxmlName() { }

	// RVA: 0x177C1A0
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x177C220
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177C228
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

	// RVA: 0x177C27C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlAttributeOverridesFactory
{
	// Methods

	// RVA: 0x177C3C0
	public override string get_uxmlName() { }

	// RVA: 0x177C404
	public override string get_uxmlQualifiedName() { }

	// RVA: 0x177C484
	public override VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177C48C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlAttributeOverridesTraits
{
	// Fields
	private UxmlStringAttributeDescription m_ElementName; // 0x18

	// Methods

	// RVA: 0x177C4E0
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

	// RVA: 0x177C594
	public System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	// RVA: 0x177C634
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

	// RVA: 0x177C63C
	protected void .ctor() { }

	// RVA: 0x177C674
	public string get_name() { }

	// RVA: 0x177C67C
	public void set_name(string value) { }

	// RVA: 0x177C684
	public void set_obsoleteNames(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x177C6EC
	protected void set_type(string value) { }

	// RVA: 0x177C6F4
	protected void set_typeNamespace(string value) { }

	// RVA: 0x177C6FC
	public void set_use(Use value) { }

	// RVA: 0x177C704
	public void set_restriction(UxmlTypeRestriction value) { }

	// RVA: 0x177C70C
	internal bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, string value) { }

	// RVA: 0x318DB98
	protected bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue, T value) { }

	// RVA: 0x318DB98
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

	// RVA: 0x318DB98
	public T get_defaultValue() { }

	// RVA: 0x318DB98
	public void set_defaultValue(T value) { }

	// RVA: 0x30D488C
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

	// RVA: 0x177D018
	private static void .cctor() { }

	// RVA: 0x177D084
	public void .ctor() { }

	// RVA: 0x177D08C
	internal string <GetValueFromBag>b__3_0(string s, string t) { }

	// RVA: 0x177D094
	internal string <TryGetValueFromBag>b__4_0(string s, string t) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlStringAttributeDescription
{
	// Methods

	// RVA: 0x1773508
	public void .ctor() { }

	// RVA: 0x177CC80
	public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177CE48
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

	// RVA: 0x177D3E4
	private static void .cctor() { }

	// RVA: 0x177D450
	public void .ctor() { }

	// RVA: 0x177D458
	internal float <GetValueFromBag>b__3_0(string s, float f) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlFloatAttributeDescription
{
	// Methods

	// RVA: 0x177D09C
	public void .ctor() { }

	// RVA: 0x177D174
	public override float GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177D344
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

	// RVA: 0x177D840
	private static void .cctor() { }

	// RVA: 0x177D8AC
	public void .ctor() { }

	// RVA: 0x177D8B4
	internal Double <GetValueFromBag>b__3_0(string s, Double d) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlDoubleAttributeDescription
{
	// Methods

	// RVA: 0x177D4F8
	public void .ctor() { }

	// RVA: 0x177D5D0
	public override Double GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177D7A0
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

	// RVA: 0x177DE1C
	private static void .cctor() { }

	// RVA: 0x177DE88
	public void .ctor() { }

	// RVA: 0x177DE90
	internal int <GetValueFromBag>b__3_0(string s, int i) { }

	// RVA: 0x177DEDC
	internal int <TryGetValueFromBag>b__4_0(string s, int i) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlIntAttributeDescription
{
	// Methods

	// RVA: 0x177D954
	public void .ctor() { }

	// RVA: 0x177DA2C
	public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177DBFC
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, int value) { }

	// RVA: 0x177DDD4
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

	// RVA: 0x177E218
	private static void .cctor() { }

	// RVA: 0x177E284
	public void .ctor() { }

	// RVA: 0x177E28C
	internal UInt32 <GetValueFromBag>b__3_0(string s, UInt32 i) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlUnsignedIntAttributeDescription
{
	// Methods

	// RVA: 0x177DF28
	public void .ctor() { }

	// RVA: 0x177E000
	public override UInt32 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177E1D0
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

	// RVA: 0x177E5C8
	private static void .cctor() { }

	// RVA: 0x177E634
	public void .ctor() { }

	// RVA: 0x177E63C
	internal UInt64 <GetValueFromBag>b__3_0(string s, UInt64 l) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlUnsignedLongAttributeDescription
{
	// Methods

	// RVA: 0x177E2D8
	public void .ctor() { }

	// RVA: 0x177E3B0
	public override UInt64 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177E580
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

	// RVA: 0x177E978
	private static void .cctor() { }

	// RVA: 0x177E9E4
	public void .ctor() { }

	// RVA: 0x177E9EC
	internal Int64 <GetValueFromBag>b__3_0(string s, Int64 l) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlLongAttributeDescription
{
	// Methods

	// RVA: 0x177E688
	public void .ctor() { }

	// RVA: 0x177E760
	public override Int64 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177E930
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

	// RVA: 0x177ECB4
	private static void .cctor() { }

	// RVA: 0x177ED20
	public void .ctor() { }

	// RVA: 0x177ED28
	internal bool <GetValueFromBag>b__3_0(string s, bool b) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlBoolAttributeDescription
{
	// Methods

	// RVA: 0x17735EC
	public void .ctor() { }

	// RVA: 0x177EA38
	public override bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177EC08
	private static bool ConvertValueToBool(string v, bool defaultValue) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlTypeAttributeDescription<T0>
{
	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: -1
	public override Type GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30D3E84
	private Type ConvertValueToType(string v, Type defaultValue) { }

	// RVA: 0x30D3E84
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal T <GetValueFromBag>b__3_0(string s, T convertible) { }

	// RVA: 0x318DB98
	internal T <TryGetValueFromBag>b__4_0(string s, T convertible) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlEnumAttributeDescription<T0>
{
	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x318DB98
	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, T value) { }

	// RVA: 0x318DB98
	private static U ConvertValueToEnum(string v, U defaultValue) { }

	// RVA: 0x30D78C4
	private static string GetEnumNameErrorMessage(string v, Type enumType) { }

	// RVA: 0x30D78C4
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

	// RVA: 0x177F07C
	private static void .cctor() { }

	// RVA: 0x177F0E8
	public void .ctor() { }

	// RVA: 0x177F0F0
	internal Hash128 <GetValueFromBag>b__3_0(string s, Hash128 i) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlHash128AttributeDescription
{
	// Methods

	// RVA: 0x177EDD4
	public void .ctor() { }

	// RVA: 0x177EEAC
	public override Hash128 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectAttributeDescription<T0>
{
	// Fields
	private T <defaultValue>k__BackingField; // 0x0

	// Methods

	// RVA: 0x318DB98
	public T get_defaultValue() { }

	// RVA: 0x318DB98
	public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectListAttributeDescription<T0>
{
	// Methods

	// RVA: -1
	public override System.Collections.Generic.List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseUxmlTraits
{
	// Fields
	private bool <canHaveAnyAttribute>k__BackingField; // 0x10

	// Methods

	// RVA: 0x177F0FC
	protected void .ctor() { }

	// RVA: 0x177F128
	protected void set_canHaveAnyAttribute(bool value) { }

}

// Namespace: UnityEngine.UIElements
public abstract class UxmlTraits
{
	// Methods

	// RVA: 0x177F130
	public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177BED4
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class UxmlObjectTraits<T0>
{
	// Methods

	// RVA: -1
	public virtual void Init(T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D488C
	protected void .ctor() { }

	// RVA: 0x30D3CF0
	public virtual string get_uxmlName() { }

	// RVA: 0x30D3CF0
	public virtual string get_uxmlNamespace() { }

	// RVA: 0x30D3CF0
	public virtual string get_uxmlQualifiedName() { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectFactory<T0, T1>
{
	// Methods

	// RVA: 0x318DB98
	public virtual TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlFactory<T0>
{
	// Methods

	// RVA: 0x30D488C
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

	// RVA: 0x177F134
	public string get_fullTypeName() { }

	// RVA: 0x177F13C
	public int get_id() { }

	// RVA: 0x177F144
	public int get_orderInDocument() { }

	// RVA: 0x177F14C
	public int get_parentId() { }

	// RVA: 0x177F154
	public bool TryGetAttributeValue(string propertyName, string value) { }

	// RVA: 0x177F26C
	public void SetAttribute(string name, string value) { }

	// RVA: 0x177F270
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

	// RVA: 0x177F3FC
	internal static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>> get_factories() { }

	// RVA: 0x177FA2C
	protected static void RegisterFactory(IBaseUxmlObjectFactory factory) { }

	// RVA: 0x177FEFC
	internal static bool TryGetFactories(string fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>& factoryList) { }

	// RVA: 0x177F4D4
	private static void RegisterEngineFactories() { }

	// RVA: 0x177F730
	private static void RegisterUserFactories() { }

}

// Namespace: UnityEngine.UIElements
public abstract class UxmlTypeRestriction
{
	// Methods

	// RVA: 0x177FF64
	public virtual bool Equals(UxmlTypeRestriction other) { }

	// RVA: 0x177FF70
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlEnumeration
{
	// Fields
	private System.Collections.Generic.List<System.String> m_Values; // 0x10

	// Methods

	// RVA: 0x177FF78
	public System.Collections.Generic.IEnumerable<System.String> get_values() { }

	// RVA: 0x177FF80
	public void set_values(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x177FFE8
	public override bool Equals(UxmlTypeRestriction other) { }

	// RVA: 0x178014C
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

	// RVA: 0x17801D8
	public int get_ruleIndex() { }

	// RVA: 0x17801E0
	public string[] get_classes() { }

	// RVA: 0x17801E8
	public System.Collections.Generic.List<System.String> get_stylesheetPaths() { }

	// RVA: 0x1780288
	public bool get_hasStylesheetPaths() { }

	// RVA: 0x1780298
	public System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_stylesheets() { }

	// RVA: 0x1780338
	public bool get_hasStylesheets() { }

	// RVA: 0x1780348
	internal bool get_skipClone() { }

	// RVA: 0x1780350
	public void OnBeforeSerialize() { }

	// RVA: 0x1780354
	public void OnAfterDeserialize() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualElementFactoryRegistry
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> s_Factories; // 0x0
	private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> s_MovedTypesFactories; // 0x8

	// Methods

	// RVA: 0x17804E8
	private static string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr) { }

	// RVA: 0x178066C
	internal static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> get_factories() { }

	// RVA: 0x1781EB0
	protected static void RegisterFactory(IUxmlFactory factory) { }

	// RVA: 0x17824C4
	internal static bool TryGetValue(string fullTypeName, System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>& factoryList) { }

	// RVA: 0x1780790
	private static void RegisterEngineFactories() { }

	// RVA: 0x1781BB4
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

	// RVA: 0x1785D68
	public void .ctor(string alias, string path) { }

	// RVA: 0x1785FF4
	private static void .cctor() { }

}

// Namespace: 
private class UsingEntryComparer
{
	// Methods

	// RVA: 0x1786084
	public int Compare(UsingEntry x, UsingEntry y) { }

	// RVA: 0x178607C
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

	// RVA: 0x1782BF0
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

	// RVA: 0x1782E78
	public Type get_type() { }

	// RVA: 0x1783094
	public void .ctor(string path, Type type, object asset) { }

}

// Namespace: 
private sealed class <>c__DisplayClass61_0
{
	// Fields
	public VisualElementAsset childVea; // 0x10

	// Methods

	// RVA: 0x1785A30
	public void .ctor() { }

	// RVA: 0x1786094
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

	// RVA: 0x1782760
	public void .ctor(int <>1__state) { }

	// RVA: 0x17860BC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1786270
	private bool MoveNext() { }

	// RVA: 0x1786D5C
	private void <>m__Finally1() { }

	// RVA: 0x1786CA4
	private void <>m__Finally2() { }

	// RVA: 0x1786D00
	private void <>m__Finally3() { }

	// RVA: 0x1786DB8
	private StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current() { }

	// RVA: 0x1786DC0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1786E00
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1786E08
	private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator() { }

	// RVA: 0x1786EBC
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

	// RVA: 0x17826A0
	public void .ctor(int <>1__state) { }

	// RVA: 0x1786EC0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1786F50
	private bool MoveNext() { }

	// RVA: 0x17875D8
	private void <>m__Finally1() { }

	// RVA: 0x1787634
	private VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current() { }

	// RVA: 0x178763C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x178767C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1787684
	private System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator() { }

	// RVA: 0x1787738
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

	// RVA: 0x1782578
	public bool get_importedWithErrors() { }

	// RVA: 0x1782580
	internal void set_importedWithErrors(bool value) { }

	// RVA: 0x1782588
	public bool get_importedWithWarnings() { }

	// RVA: 0x1782590
	internal void set_importedWithWarnings(bool value) { }

	// RVA: 0x1782598
	internal int GetNextChildSerialNumber() { }

	// RVA: 0x1782618
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset> get_templateDependencies() { }

	// RVA: 0x17826D8
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet> get_stylesheets() { }

	// RVA: 0x1782798
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> get_visualElementAssets() { }

	// RVA: 0x17827A0
	internal void set_visualElementAssets(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> value) { }

	// RVA: 0x17827A8
	internal System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> get_templateAssets() { }

	// RVA: 0x17827B0
	internal void set_templateAssets(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> value) { }

	// RVA: 0x17827B8
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry> get_uxmlObjectEntries() { }

	// RVA: 0x17827C0
	internal System.Collections.Generic.List<System.Int32> get_uxmlObjectIds() { }

	// RVA: 0x17827C8
	internal void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: -1
	internal System.Collections.Generic.List<T> GetUxmlObjects(IUxmlAttributes asset, CreationContext cc) { }

	// RVA: 0x1782C00
	internal bool AssetEntryExists(string path, Type type) { }

	// RVA: 0x1782F54
	internal void RegisterAssetEntry(string path, Type type, object asset) { }

	// RVA: 0x318DB98
	internal T GetAsset(string path) { }

	// RVA: 0x1782A04
	internal UxmlObjectEntry GetUxmlObjectEntry(int id) { }

	// RVA: 0x1783110
	private IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: 0x178365C
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> get_slots() { }

	// RVA: 0x1783664
	internal void set_slots(System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> value) { }

	// RVA: 0x178366C
	internal int get_contentContainerId() { }

	// RVA: 0x1783674
	internal void set_contentContainerId(int value) { }

	// RVA: 0x178367C
	public TemplateContainer Instantiate() { }

	// RVA: 0x1784004
	public TemplateContainer Instantiate(string bindingPath) { }

	// RVA: 0x1784044
	public TemplateContainer CloneTree() { }

	// RVA: 0x1784048
	public TemplateContainer CloneTree(string bindingPath) { }

	// RVA: 0x1784088
	public void CloneTree(VisualElement target) { }

	// RVA: 0x17840B4
	public void CloneTree(VisualElement target, int firstElementIndex, int elementAddedCount) { }

	// RVA: 0x17837D0
	internal void CloneTree(VisualElement target, System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides) { }

	// RVA: 0x1784718
	private VisualElement CloneSetupRecursively(VisualElementAsset root, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>> idToChildren, CreationContext context) { }

	// RVA: 0x1785A38
	private static int CompareForOrder(VisualElementAsset a, VisualElementAsset b) { }

	// RVA: 0x178593C
	internal bool TryGetSlotInsertionPoint(int insertionPointId, string slotName) { }

	// RVA: 0x1785A74
	internal VisualTreeAsset ResolveTemplate(string templateName) { }

	// RVA: 0x17852B8
	internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx) { }

	// RVA: 0x178427C
	private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x17842F4
	private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x1785F0C
	public int get_contentHash() { }

	// RVA: 0x1785F14
	public void set_contentHash(int value) { }

	// RVA: 0x1785F1C
	public void .ctor() { }

	// RVA: 0x1785F24
	private static void .cctor() { }

	// RVA: 0x1785DAC
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

	// RVA: 0x178773C
	public VisualElement get_target() { }

	// RVA: 0x1787744
	private void set_target(VisualElement value) { }

	// RVA: 0x178774C
	public VisualTreeAsset get_visualTreeAsset() { }

	// RVA: 0x1787754
	private void set_visualTreeAsset(VisualTreeAsset value) { }

	// RVA: 0x178775C
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> get_slotInsertionPoints() { }

	// RVA: 0x1787764
	private void set_slotInsertionPoints(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x178776C
	internal System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	// RVA: 0x1787774
	private void set_attributeOverrides(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> value) { }

	// RVA: 0x1783558
	internal void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x1784660
	internal void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x178777C
	public override bool Equals(object obj) { }

	// RVA: 0x178785C
	public bool Equals(CreationContext other) { }

	// RVA: 0x17879D8
	public override int GetHashCode() { }

	// RVA: 0x1787B18
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

	// RVA: 0x1787B68
	public float get_width() { }

	// RVA: 0x1787B70
	public float get_height() { }

	// RVA: 0x1787B78
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

	// RVA: 0x1788028
	private static void .cctor() { }

	// RVA: 0x1788094
	public void .ctor() { }

	// RVA: 0x178809C
	internal System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> <.cctor>b__4_0() { }

}

// Namespace: UnityEngine.UIElements
internal static class VisualElementListPool
{
	// Fields
	private static UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>> pool; // 0x0

	// Methods

	// RVA: 0x1787C14
	public static System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Copy(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x1787CF8
	public static System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Get(int initialCapacity) { }

	// RVA: 0x1787E0C
	public static void Release(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x1787F08
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.ObjectListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3CF0
	internal System.Collections.Generic.List<T> <.cctor>b__4_0() { }

}

// Namespace: UnityEngine.UIElements
internal class ObjectListPool<T0>
{
	// Fields
	private static UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<T>> pool; // 0x0

	// Methods

	// RVA: 0x30D77AC
	public static System.Collections.Generic.List<T> Get() { }

	// RVA: 0x30DA164
	public static void Release(System.Collections.Generic.List<T> elements) { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public static class VisualElementExtensions
{
	// Methods

	// RVA: 0x1788110
	public static void StretchToParentSize(VisualElement elem) { }

	// RVA: 0x1788444
	public static void AddManipulator(VisualElement ele, IManipulator manipulator) { }

	// RVA: 0x1788500
	public static void RemoveManipulator(VisualElement ele, IManipulator manipulator) { }

	// RVA: 0x17885C0
	public static Vector2 WorldToLocal(VisualElement ele, Vector2 p) { }

	// RVA: 0x17886A8
	public static Vector2 LocalToWorld(VisualElement ele, Vector2 p) { }

	// RVA: 0x1788790
	public static Rect WorldToLocal(VisualElement ele, Rect r) { }

	// RVA: 0x1788878
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

	// RVA: 0x178889C
	internal static void GetDefaultEventInterests(Type elementType, int defaultActionCategories, int defaultActionAtTargetCategories) { }

	// RVA: 0x1788B14
	private static int ComputeDefaultEventInterests(Type elementType, string methodName) { }

	// RVA: 0x1788D0C
	internal static EventCategory GetEventCategory(Type eventType) { }

	// RVA: 0x1788F48
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

	// RVA: 0x178903C
	public void .ctor(Type[] eventTypes) { }

	// RVA: 0x1789074
	public void .ctor(EventInterestOptions interests) { }

}

// Namespace: UnityEngine.UIElements
internal class EventCategoryAttribute
{
	// Fields
	internal EventCategory category; // 0x10

	// Methods

	// RVA: 0x17890A4
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

	// RVA: 0x17890D0
	public static FocusChangeDirection get_left() { }

	// RVA: 0x178914C
	public static FocusChangeDirection get_right() { }

	// RVA: 0x17891C8
	protected void .ctor(int value) { }

	// RVA: 0x1789234
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.VisualElementFocusChangeTarget.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17897F0
	private static void .cctor() { }

	// RVA: 0x178985C
	public void .ctor() { }

	// RVA: 0x1789864
	internal VisualElementFocusChangeTarget <.cctor>b__9_0() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualElementFocusChangeTarget
{
	// Fields
	private static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.VisualElementFocusChangeTarget> Pool; // 0x0
	private Focusable <target>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1789438
	public static VisualElementFocusChangeTarget GetPooled(Focusable target) { }

	// RVA: 0x1789508
	protected override void Dispose() { }

	// RVA: 0x17895A4
	internal override void ApplyTo(FocusController focusController, Focusable f) { }

	// RVA: 0x17895EC
	public void .ctor() { }

	// RVA: 0x17896C0
	public Focusable get_target() { }

	// RVA: 0x17896C8
	private void set_target(Focusable value) { }

	// RVA: 0x17896D0
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

	// RVA: 0x178B0C0
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

	// RVA: 0x17898B8
	public void .ctor(VisualElement root, DefaultFocusOrder dfo) { }

	// RVA: 0x1789968
	private FocusController get_focusController() { }

	// RVA: 0x1789990
	public DefaultFocusOrder get_defaultFocusOrder() { }

	// RVA: 0x1789998
	public void set_defaultFocusOrder(DefaultFocusOrder value) { }

	// RVA: 0x17899A0
	private int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b) { }

	// RVA: 0x1789CE0
	private int FocusRingSort(FocusRingRecord a, FocusRingRecord b) { }

	// RVA: 0x1789DEC
	private void DoUpdate() { }

	// RVA: 0x1789F14
	private void BuildRingForScopeRecursive(VisualElement ve, int scopeIndex, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> scopeList) { }

	// RVA: 0x178A1CC
	private void SortAndFlattenScopeLists(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> rootScopeList) { }

	// RVA: 0x178A4EC
	private int GetFocusableInternalIndex(Focusable f) { }

	// RVA: 0x178A5A8
	public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x178A9F0
	public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	// RVA: 0x178AEFC
	internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable) { }

	// RVA: 0x178AFB8
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

	// RVA: 0x178B0C8
	public bool get_isActive() { }

	// RVA: 0x178B0D0
	private void set_isActive(bool value) { }

	// RVA: 0x178B0D8
	public bool get_isDetaching() { }

	// RVA: 0x178B0E0
	private void set_isDetaching(bool value) { }

	// RVA: 0x178B0E8
	public void .ctor(IVisualElementPanelActivatable activatable) { }

	// RVA: 0x178B1F4
	public void SetActive(bool action) { }

	// RVA: 0x178B4F0
	public void SendActivation() { }

	// RVA: 0x178B638
	public void SendDeactivation() { }

	// RVA: 0x178B780
	private void OnEnter(AttachToPanelEvent evt) { }

	// RVA: 0x178B790
	private void OnLeave(DetachFromPanelEvent evt) { }

}

// Namespace: UnityEngine.UIElements
public struct VisualElementStyleSheetSet
{
	// Fields
	private readonly VisualElement m_Element; // 0x10

	// Methods

	// RVA: 0x178B80C
	internal void .ctor(VisualElement element) { }

	// RVA: 0x178B814
	public void Add(StyleSheet styleSheet) { }

	// RVA: 0x178B9C8
	public bool Remove(StyleSheet styleSheet) { }

	// RVA: 0x178BB28
	public bool Equals(VisualElementStyleSheetSet other) { }

	// RVA: 0x178BB34
	public override bool Equals(object obj) { }

	// RVA: 0x178BBC0
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

	// RVA: 0x178C054
	private static void .cctor() { }

	// RVA: 0x178C0C0
	public void .ctor() { }

	// RVA: 0x178C0C8
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

	// RVA: 0x178BBD8
	public static string GetUniqueName(string nameBase) { }

	// RVA: 0x178BD08
	internal static int GetFoldoutDepth(VisualElement element) { }

	// RVA: 0x178BDFC
	internal static void AssignInspectorStyleIfNecessary(VisualElement element, string classNameToEnable) { }

	// RVA: 0x178BF2C
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

	// RVA: 0x178C150
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x178C1CC
	private static ProfilerMarker get_stylePropertyAnimationProfilerMarker() { }

	// RVA: 0x178C248
	public void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x178C2B8
	public void UnregisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims) { }

	// RVA: 0x178C4B4
	public void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x178C524
	public void RegisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims) { }

	// RVA: 0x178C720
	public override void Update() { }

	// RVA: 0x178CBF4
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x178CBF8
	public void .ctor() { }

	// RVA: 0x178CCE4
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

	// RVA: 0x178CDDC
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x178CE58
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x178CF40
	private static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	// RVA: 0x178D03C
	private static void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	// RVA: 0x178D0EC
	public override void Update() { }

	// RVA: 0x178D158
	public void .ctor() { }

	// RVA: 0x178D164
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

	// RVA: 0x178D20C
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x178D5A4
	public override void Update() { }

	// RVA: 0x178D394
	private void ProcessNewChange(VisualElement ve) { }

	// RVA: 0x178D4E8
	private void ProcessAddOrMove(VisualElement ve) { }

	// RVA: 0x178D44C
	private void ProcessRemove(VisualElement ve) { }

	// RVA: 0x178D65C
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

	// RVA: 0x178D668
	public static bool TryGetValue(Int64 hash, ComputedStyle data) { }

	// RVA: 0x178D724
	public static void SetValue(Int64 hash, ComputedStyle data) { }

	// RVA: 0x178D800
	public static bool TryGetValue(int hash, StyleVariableContext data) { }

	// RVA: 0x178D8BC
	public static void SetValue(int hash, StyleVariableContext data) { }

	// RVA: 0x178D978
	public static bool TryGetValue(int hash, ComputedTransitionProperty[] data) { }

	// RVA: 0x178DA34
	public static void SetValue(int hash, ComputedTransitionProperty[] data) { }

	// RVA: 0x178DAF0
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

	// RVA: 0x178DC3C
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x178DCB8
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x178DE64
	public override void Update() { }

	// RVA: 0x178E854
	protected bool get_disposed() { }

	// RVA: 0x178E85C
	private void set_disposed(bool value) { }

	// RVA: 0x178E864
	protected override void Dispose(bool disposing) { }

	// RVA: 0x178E2DC
	private void ApplyStyles() { }

	// RVA: 0x178E8E0
	public void .ctor() { }

	// RVA: 0x178EC28
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

	// RVA: 0x178ECD0
	public int get_styleSheetCount() { }

	// RVA: 0x178ED1C
	public void .ctor(System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult) { }

	// RVA: 0x178EE50
	public void AddStyleSheet(StyleSheet sheet) { }

	// RVA: 0x178EF1C
	public void RemoveStyleSheetRange(int index, int count) { }

	// RVA: 0x178EF88
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

	// RVA: 0x1790C88
	private static void .cctor() { }

	// RVA: 0x1790CF4
	public void .ctor() { }

	// RVA: 0x1790CFC
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

	// RVA: 0x178F000
	private float get_currentPixelsPerPoint() { }

	// RVA: 0x178F008
	private void set_currentPixelsPerPoint(float value) { }

	// RVA: 0x178E8D8
	public void PrepareTraversal(float pixelsPerPoint) { }

	// RVA: 0x178DDE0
	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x178E3D0
	public void Clear() { }

	// RVA: 0x178F010
	private void PropagateToChildren(VisualElement ve) { }

	// RVA: 0x178F0F0
	private void PropagateToParents(VisualElement ve) { }

	// RVA: 0x178F1A0
	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) { }

	// RVA: 0x178F1D4
	public override void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x179071C
	private void ProcessTransitions(VisualElement element, ComputedStyle oldStyle, ComputedStyle newStyle) { }

	// RVA: 0x1790810
	private void ForceUpdateTransitions(VisualElement element) { }

	// RVA: 0x178E4A4
	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ComputedStyle newStyle) { }

	// RVA: 0x178FA9C
	protected bool ShouldSkipElement(VisualElement element) { }

	// RVA: 0x178FB34
	private ComputedStyle ProcessMatchedRules(VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchingSelectors) { }

	// RVA: 0x1790B94
	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x178E9D4
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

	// RVA: 0x1790E20
	public void .ctor() { }

	// RVA: 0x1791478
	public void set_Item(VisualTreeUpdatePhase phase, IVisualTreeUpdater value) { }

	// RVA: 0x1791300
	public IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0x17910D8
	public IVisualTreeUpdater get_Item(int index) { }

}

// Namespace: UnityEngine.UIElements
internal sealed class VisualTreeUpdater
{
	// Fields
	private BaseVisualElementPanel m_Panel; // 0x10
	private UpdaterArray m_UpdaterArray; // 0x18

	// Methods

	// RVA: 0x1790D44
	public void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x1790FD8
	public void Dispose() { }

	// RVA: 0x179110C
	public void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x1791334
	public void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x30D4A04
	public void SetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x179143C
	public IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x1790E90
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

	// RVA: 0x17914EC
	public void add_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x17915A0
	public void remove_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x178CBEC
	public BaseVisualElementPanel get_panel() { }

	// RVA: 0x1791654
	public void set_panel(BaseVisualElementPanel value) { }

	// RVA: 0x178E8B0
	public VisualElement get_visualTree() { }

	// RVA: -1
	public abstract ProfilerMarker get_profilerMarker() { }

	// RVA: 0x17916A4
	public void Dispose() { }

	// RVA: 0x1791734
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1
	public abstract void Update() { }

	// RVA: -1
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x178CCDC
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

	// RVA: 0x1791738
	public override ProfilerMarker get_profilerMarker() { }

	// RVA: 0x17917B4
	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x17918F8
	public override void Update() { }

	// RVA: 0x1791B44
	private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence) { }

	// RVA: 0x1791848
	private void PropagateToParents(VisualElement ve) { }

	// RVA: 0x1791CA0
	public void .ctor() { }

	// RVA: 0x1791D54
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

	// RVA: 0x30D4A74
	public void .ctor(int elementCount, GPUBufferType type) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x318DB98
	public void UpdateRanges(Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax) { }

	// RVA: 0x30D39B8
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

	// RVA: 0x318DB98
	public static void SetVectorArray(MaterialPropertyBlock props, int name, Unity.Collections.NativeSlice<T> vector4s) { }

	// RVA: 0x1791DFC
	public static void add_GraphicsResourcesRecreate(System.Action<System.Boolean> value) { }

	// RVA: 0x1791F0C
	public static void remove_GraphicsResourcesRecreate(System.Action<System.Boolean> value) { }

	// RVA: 0x179201C
	public static void add_EngineUpdate(Action value) { }

	// RVA: 0x179210C
	public static void remove_EngineUpdate(Action value) { }

	// RVA: 0x17921FC
	public static void add_FlushPendingResources(Action value) { }

	// RVA: 0x17922EC
	public static void remove_FlushPendingResources(Action value) { }

	// RVA: 0x17923DC
	public static void add_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x17924F0
	public static void remove_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x1792604
	public static void add_RenderNodeExecute(System.Action<System.IntPtr> value) { }

	// RVA: 0x1792718
	public static void remove_RenderNodeExecute(System.Action<System.IntPtr> value) { }

	// RVA: 0x179282C
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	// RVA: 0x17928D4
	internal static void RaiseEngineUpdate() { }

	// RVA: 0x17929AC
	internal static void RaiseFlushPendingResources() { }

	// RVA: 0x1792A3C
	internal static void RaiseRegisterIntermediateRenderers(Camera camera) { }

	// RVA: 0x1792AE0
	internal static void RaiseRenderNodeAdd(IntPtr userData) { }

	// RVA: 0x1792B88
	internal static void RaiseRenderNodeExecute(IntPtr userData) { }

	// RVA: 0x1792C30
	internal static void RaiseRenderNodeCleanup(IntPtr userData) { }

	// RVA: 0x1792CD8
	private static IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) { }

	// RVA: 0x1792D30
	private static void FreeBuffer(IntPtr buffer) { }

	// RVA: 0x1792D80
	private static void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) { }

	// RVA: 0x1792DF0
	private static void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count) { }

	// RVA: 0x1792E58
	public static IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) { }

	// RVA: 0x1792EA8
	public static void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, UInt64 sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	// RVA: 0x1793068
	public static void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) { }

	// RVA: 0x17930E8
	public static void SetPropertyBlock(MaterialPropertyBlock props) { }

	// RVA: 0x1793138
	public static void SetScissorRect(RectInt scissorRect) { }

	// RVA: 0x179323C
	public static void DisableScissor() { }

	// RVA: 0x179327C
	public static IntPtr CreateStencilState(StencilState stencilState) { }

	// RVA: 0x1793384
	public static void SetStencilState(IntPtr stencilState, int stencilRef) { }

	// RVA: 0x17933EC
	public static bool HasMappedBufferRange() { }

	// RVA: 0x179342C
	public static UInt32 InsertCPUFence() { }

	// RVA: 0x179346C
	public static bool CPUFencePassed(UInt32 fence) { }

	// RVA: 0x17934BC
	public static void WaitForCPUFencePassed(UInt32 fence) { }

	// RVA: 0x179350C
	public static void SyncRenderThread() { }

	// RVA: 0x179354C
	public static RectInt GetActiveViewport() { }

	// RVA: 0x1793644
	public static void ProfileDrawChainBegin() { }

	// RVA: 0x1793684
	public static void ProfileDrawChainEnd() { }

	// RVA: 0x17936C4
	public static void NotifyOfUIREvents(bool subscribe) { }

	// RVA: 0x1793714
	public static Matrix4x4 GetUnityProjectionMatrix() { }

	// RVA: 0x1793834
	private static void .cctor() { }

	// RVA: 0x1792FAC
	private static void RegisterIntermediateRenderer_Injected(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, UInt64 sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	// RVA: 0x17931EC
	private static void SetScissorRect_Injected(RectInt scissorRect) { }

	// RVA: 0x1793334
	private static IntPtr CreateStencilState_Injected(StencilState stencilState) { }

	// RVA: 0x17935F4
	private static void GetActiveViewport_Injected(RectInt ret) { }

	// RVA: 0x17937E4
	private static void GetUnityProjectionMatrix_Injected(Matrix4x4 ret) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal static class JobProcessor
{
	// Methods

	// RVA: 0x17938B4
	internal static JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x1793974
	internal static JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x1793A34
	internal static JobHandle ScheduleCopyClosingMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x179391C
	private static void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, JobHandle ret) { }

	// RVA: 0x17939DC
	private static void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, JobHandle ret) { }

	// RVA: 0x1793A9C
	private static void ScheduleCopyClosingMeshJobs_Injected(IntPtr buffer, int jobCount, JobHandle ret) { }

}

// Namespace: 
public class Area
{
	// Fields
	public RectInt rect; // 0x10
	public BestFitAllocator allocator; // 0x20

	// Methods

	// RVA: 0x1794FCC
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

	// RVA: 0x179505C
	private static Row Create() { }

	// RVA: 0x179513C
	private static void Reset(Row row) { }

	// RVA: 0x17950E8
	public void .ctor() { }

	// RVA: 0x1795194
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

	// RVA: 0x17948EC
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

	// RVA: 0x1793AF4
	public void .ctor(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	// RVA: 0x17941E0
	public bool TryAllocate(int width, int height, Alloc2D alloc2D) { }

	// RVA: 0x1794B08
	public void Free(Alloc2D alloc2D) { }

	// RVA: 0x1793DCC
	private static void BuildAreas(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	// RVA: 0x1794038
	private static Vector2Int ComputeMaxAllocSize(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, int rowHeightBias) { }

	// RVA: 0x1794158
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

	// RVA: 0x17952D4
	public void Dispose() { }

	// RVA: 0x17953DC
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

	// RVA: 0x1795488
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

	// RVA: 0x1797458
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

	// RVA: 0x179D674
	private static void .cctor() { }

	// RVA: 0x179D6E0
	public void .ctor() { }

	// RVA: 0x179D6E8
	internal MeshHandle <.ctor>b__50_0() { }

	// RVA: 0x179D774
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

	// RVA: 0x17954DC
	internal UInt32 get_maxVerticesPerPage() { }

	// RVA: 0x17954E4
	internal bool get_breakBatches() { }

	// RVA: 0x17954EC
	internal void set_breakBatches(bool value) { }

	// RVA: 0x17954F4
	private static void .cctor() { }

	// RVA: 0x1795824
	public void .ctor(UInt32 initialVertexCapacity, UInt32 initialIndexCapacity) { }

	// RVA: 0x179582C
	protected void .ctor(UInt32 initialVertexCapacity, UInt32 initialIndexCapacity, bool mockDevice) { }

	// RVA: 0x17960A4
	internal static Texture2D get_defaultShaderInfoTexFloat() { }

	// RVA: 0x179648C
	internal static Texture2D get_defaultShaderInfoTexARGB8() { }

	// RVA: 0x17967BC
	internal static bool get_vertexTexturingIsAvailable() { }

	// RVA: 0x17969F8
	internal static bool get_shaderModelIs35() { }

	// RVA: 0x1796C34
	private void InitVertexDeclaration() { }

	// RVA: 0x1796F08
	private void CompleteCreation() { }

	// RVA: 0x1797158
	private bool get_fullyCreated() { }

	// RVA: 0x1797168
	protected bool get_disposed() { }

	// RVA: 0x1797170
	private void set_disposed(bool value) { }

	// RVA: 0x1797178
	public void Dispose() { }

	// RVA: 0x1797208
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1797B4C
	public MeshHandle Allocate(UInt32 vertexCount, UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, UInt16 indexOffset) { }

	// RVA: 0x1798384
	public void Update(MeshHandle mesh, UInt32 vertexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData) { }

	// RVA: 0x1798B94
	public void Update(MeshHandle mesh, UInt32 vertexCount, UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, UInt16 indexOffset) { }

	// RVA: 0x1798D44
	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	// RVA: 0x1798EAC
	internal System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	// RVA: 0x1798F40
	private bool TryAllocFromPage(Page page, UInt32 vertexCount, UInt32 indexCount, Alloc va, Alloc ia, bool shortLived) { }

	// RVA: 0x1797C18
	private void Allocate(MeshHandle meshHandle, UInt32 vertexCount, UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, bool shortLived) { }

	// RVA: 0x179857C
	private void UpdateAfterGPUUsedData(MeshHandle mesh, UInt32 vertexCount, UInt32 indexCount, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, Unity.Collections.NativeSlice<System.UInt16>& indexData, UInt16 indexOffset, AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	// RVA: 0x17994B0
	public void Free(MeshHandle mesh) { }

	// RVA: 0x1799AA4
	public void OnFrameRenderingBegin() { }

	// RVA: 0x318DB98
	internal static Unity.Collections.NativeSlice<T> PtrToSlice(Void* p, int count) { }

	// RVA: 0x179A7EC
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, EvaluationState st) { }

	// RVA: 0x179A9DC
	private void ApplyBatchState(EvaluationState st, bool allowMaterialChange) { }

	// RVA: 0x179ABE4
	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transforms, Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, Exception immediateException) { }

	// RVA: 0x179CDB0
	private void UpdateFenceValue() { }

	// RVA: 0x179BCF8
	private void KickRanges(DrawBufferRange* ranges, int rangesReady, int rangesStart, int rangesCount, Page curPage) { }

	// RVA: 0x318DB98
	private void DrawRanges(UnityEngine.UIElements.UIR.Utility.GPUBuffer<I> ib, UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> vb, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.DrawBufferRange> ranges) { }

	// RVA: 0x179CEB4
	private void WaitOnCpuFence(UInt32 fence) { }

	// RVA: 0x1799BC8
	public void AdvanceFrame() { }

	// RVA: 0x179CFF8
	private void PruneUnusedPages() { }

	// RVA: 0x179D238
	internal static void PrepareForGfxDeviceRecreate() { }

	// RVA: 0x179D43C
	internal static void WrapUpGfxDeviceRecreate() { }

	// RVA: 0x179D4A0
	internal static void FlushAllPendingDeviceDisposes() { }

	// RVA: 0x179D570
	internal DrawStatistics GatherDrawStatistics() { }

	// RVA: 0x1797514
	private static void ProcessDeviceFreeQueue() { }

	// RVA: 0x179D588
	private static void OnEngineUpdateGlobal() { }

	// RVA: 0x179D5F0
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

	// RVA: 0x179DB60
	private static Block CreateBlock() { }

	// RVA: 0x179DC40
	private static void ResetBlock(Block block) { }

	// RVA: 0x179D778
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

	// RVA: 0x179D8BC
	public UInt32 get_size() { }

	// RVA: 0x179DBEC
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

	// RVA: 0x1794A28
	public void .ctor(UInt32 size) { }

	// RVA: 0x179D870
	public UInt32 get_totalSize() { }

	// RVA: 0x1794FC4
	public UInt32 get_highWatermark() { }

	// RVA: 0x17946CC
	public Alloc Allocate(UInt32 size) { }

	// RVA: 0x1794D20
	public void Free(Alloc alloc) { }

	// RVA: 0x179DA38
	private Block CoalesceBlockWithPrevious(Block block) { }

	// RVA: 0x179D878
	private Block BestFitFindAvailableBlock(UInt32 size) { }

	// RVA: 0x179D8C8
	private void SplitBlock(Block block, UInt32 size) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class GPUBufferAllocator
{
	// Fields
	private BestFitAllocator m_Low; // 0x10
	private BestFitAllocator m_High; // 0x18

	// Methods

	// RVA: 0x179DC44
	public void .ctor(UInt32 maxSize) { }

	// RVA: 0x17990BC
	public Alloc Allocate(UInt32 size, bool shortLived) { }

	// RVA: 0x1799230
	public void Free(Alloc alloc) { }

	// RVA: 0x179DD20
	public bool get_isEmpty() { }

	// RVA: 0x179DCE4
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

	// RVA: 0x318DB98
	public void .ctor(GPUBufferType bufferType, UInt32 totalCount, UInt32 maxQueuedFrameCount, UInt32 updateRangePoolSize, bool mockBuffer) { }

	// RVA: 0x30D3738
	protected bool get_disposed() { }

	// RVA: 0x30D4918
	private void set_disposed(bool value) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D4918
	public void Dispose(bool disposing) { }

	// RVA: 0x318DB98
	public void RegisterUpdate(UInt32 start, UInt32 size) { }

	// RVA: 0x30D3738
	private bool HasMappedBufferRange() { }

	// RVA: 0x30D488C
	public void SendUpdates() { }

	// RVA: 0x30D488C
	public void SendFullRange() { }

	// RVA: 0x30D488C
	public void SendPartialRanges() { }

	// RVA: 0x30D488C
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

	// RVA: 0x17992B4
	public void .ctor(UInt32 vertexMaxCount, UInt32 indexMaxCount, UInt32 maxQueuedFrameCount, bool mockPage) { }

	// RVA: 0x179DD64
	protected bool get_disposed() { }

	// RVA: 0x179DD6C
	private void set_disposed(bool value) { }

	// RVA: 0x179D1A8
	public void Dispose() { }

	// RVA: 0x179DD74
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1799414
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

	// RVA: 0x179B8D0
	public void Reset() { }

	// RVA: 0x1795F0C
	public void .ctor() { }

	// RVA: 0x179DE20
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

	// RVA: 0x179DE7C
	internal void Reset() { }

	// RVA: 0x179BF50
	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, Exception immediateException) { }

	// RVA: 0x179E4E8
	private void Blit(Texture source, RenderTexture destination, float depth) { }

	// RVA: 0x179E3D4
	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	// RVA: 0x179DEF4
	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	// RVA: 0x179E660
	public void .ctor() { }

	// RVA: 0x179E6B4
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

	// RVA: 0x179F0C4
	public void WriteRawInt2Packed(int v0, int v1, int destX, int destY) { }

	// RVA: 0x179F004
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

	// RVA: 0x179E760
	internal int get_length() { }

	// RVA: 0x179E768
	protected bool get_disposed() { }

	// RVA: 0x179E770
	private void set_disposed(bool value) { }

	// RVA: 0x179E778
	public void Dispose() { }

	// RVA: 0x179E808
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x179E8A4
	public void .ctor(int length) { }

	// RVA: 0x179E8D8
	public void Reset() { }

	// RVA: 0x179E9AC
	public Texture2D get_atlas() { }

	// RVA: 0x179E9B4
	public Alloc Add(int count) { }

	// RVA: 0x179EAC4
	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) { }

	// RVA: 0x179F148
	public bool get_MustCommit() { }

	// RVA: 0x179F150
	private void set_MustCommit(bool value) { }

	// RVA: 0x179F158
	public void Commit() { }

	// RVA: 0x179F22C
	private void PrepareAtlas() { }

	// RVA: 0x179F3DC
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

	// RVA: 0x179F494
	public void Add(NudgeJobData job) { }

	// RVA: 0x179F4F8
	public void Add(ConvertMeshJobData job) { }

	// RVA: 0x179F55C
	public void Add(CopyClosingMeshJobData job) { }

	// RVA: 0x179F5C0
	public void CompleteNudgeJobs() { }

	// RVA: 0x179FA8C
	public void CompleteConvertMeshJobs() { }

	// RVA: 0x179FE30
	public void CompleteClosingMeshJobs() { }

	// RVA: 0x17A01D4
	protected bool get_disposed() { }

	// RVA: 0x17A01DC
	private void set_disposed(bool value) { }

	// RVA: 0x17A01E4
	public void Dispose() { }

	// RVA: 0x17A0284
	protected void Dispose(bool disposing) { }

	// RVA: 0x17A04EC
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

	// RVA: 0x17A066C
	public void .ctor(int capacity) { }

	// RVA: 0x179F964
	public void Add(JobHandle job) { }

	// RVA: 0x179F9E8
	public JobHandle MergeAndReset() { }

	// RVA: 0x17A0728
	protected bool get_disposed() { }

	// RVA: 0x17A0730
	private void set_disposed(bool value) { }

	// RVA: 0x17A0410
	public void Dispose() { }

	// RVA: 0x17A0738
	protected void Dispose(bool disposing) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class LinkedPoolItem<T0>
{
	// Fields
	internal T poolNext; // 0x0

	// Methods

	// RVA: 0x30D488C
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

	// RVA: 0x30D4FA0
	public void .ctor(System.Func<T> createFunc, System.Action<T> resetAction, int limit) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D4A04
	private void set_Count(int value) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public T Get() { }

	// RVA: 0x318DB98
	public void Return(T item) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNode<T0>
{
	// Fields
	public UnityEngine.UIElements.UIR.BasicNode<T> next; // 0x0
	public T data; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void InsertFirst(UnityEngine.UIElements.UIR.BasicNode<T>& first) { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNodePool<T0>
{
	// Methods

	// RVA: 0x30DA164
	private static void Reset(UnityEngine.UIElements.UIR.BasicNode<T> node) { }

	// RVA: 0x30D77AC
	private static UnityEngine.UIElements.UIR.BasicNode<T> Create() { }

	// RVA: 0x30D488C
	public void .ctor() { }

}

// Namespace: 
internal sealed class Allocator
{
	// Methods

	// RVA: 0x17A10CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17A1170
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

	// RVA: 0x17A0F68
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

	// RVA: 0x17A07C0
	private static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags, bool isDynamicColor) { }

	// RVA: 0x17A08A8
	private static int LimitTextVertices(int vertexCount, bool logTruncation) { }

	// RVA: 0x17A0A10
	internal static void MakeText(MeshInfo meshInfo, Vector2 offset, AllocMeshData meshAlloc, VertexFlags flags, bool isDynamicColor) { }

	// RVA: 0x17A0F94
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

	// RVA: 0x30D4A04
	public void .ctor(int poolCapacity) { }

	// RVA: 0x30D4CD4
	public void Add(T data) { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.List<Unity.Collections.NativeSlice<T>> GetPages() { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x30D3738
	protected bool get_disposed() { }

	// RVA: 0x30D4918
	private void set_disposed(bool value) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D4918
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

	// RVA: 0x17A14CC
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

	// RVA: 0x17A1184
	public void CreateJob(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> oldVerts, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	// RVA: 0x17A1284
	public void CompleteJobs() { }

	// RVA: 0x17A1320
	protected bool get_disposed() { }

	// RVA: 0x17A1328
	private void set_disposed(bool value) { }

	// RVA: 0x17A1330
	public void Dispose() { }

	// RVA: 0x17A13C0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17A1448
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

	// RVA: 0x17A5D64
	public void EnsureFits(int maxDepth) { }

	// RVA: 0x17A5E00
	public void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) { }

	// RVA: 0x17A6024
	public void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse) { }

	// RVA: 0x17A620C
	public void Reset() { }

}

// Namespace: 
private struct RenderChainStaticIndexAllocator
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain> renderChains; // 0x0

	// Methods

	// RVA: 0x17A62F4
	public static int AllocateIndex(RenderChain renderChain) { }

	// RVA: 0x17A644C
	public static void FreeIndex(int index) { }

	// RVA: 0x17A64F4
	public static RenderChain AccessIndex(int index) { }

	// RVA: 0x17A65AC
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

	// RVA: 0x17A664C
	private static void .cctor() { }

	// RVA: 0x17A66B8
	public void .ctor() { }

	// RVA: 0x17A66C0
	internal RenderChainCommand <.ctor>b__34_0() { }

	// RVA: 0x17A6718
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

	// RVA: 0x17A15A8
	public OpacityIdAccelerator get_opacityIdAccelerator() { }

	// RVA: 0x17A15B0
	private void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	// RVA: 0x17A15B8
	private static void .cctor() { }

	// RVA: 0x17A1868
	public void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x17A1C54
	private void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan) { }

	// RVA: 0x17A2134
	private void Destructor() { }

	// RVA: 0x17A27C8
	protected bool get_disposed() { }

	// RVA: 0x17A27D0
	private void set_disposed(bool value) { }

	// RVA: 0x17A27D8
	public void Dispose() { }

	// RVA: 0x17A287C
	protected void Dispose(bool disposing) { }

	// RVA: 0x17A28C0
	public void ProcessChanges() { }

	// RVA: 0x17A309C
	public void Render() { }

	// RVA: 0x17A3F3C
	public void UIEOnChildAdded(VisualElement ve) { }

	// RVA: 0x17A42FC
	public void UIEOnChildrenReordered(VisualElement ve) { }

	// RVA: 0x17A44C0
	public void UIEOnChildRemoving(VisualElement ve) { }

	// RVA: 0x17A45C8
	public void UIEOnRenderHintsChanged(VisualElement ve) { }

	// RVA: 0x17A411C
	public void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x17A41BC
	public void UIEOnOpacityChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x17A46B0
	public void UIEOnColorChanged(VisualElement ve) { }

	// RVA: 0x17A4744
	public void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	// RVA: 0x17A425C
	public void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x17A47E4
	public void UIEOnOpacityIdChanged(VisualElement ve) { }

	// RVA: 0x17A4878
	internal BaseVisualElementPanel get_panel() { }

	// RVA: 0x17A4880
	private void set_panel(BaseVisualElementPanel value) { }

	// RVA: 0x17A4890
	internal UIRenderDevice get_device() { }

	// RVA: 0x17A4898
	private void set_device(UIRenderDevice value) { }

	// RVA: 0x17A48A8
	internal AtlasBase get_atlas() { }

	// RVA: 0x17A48B0
	private void set_atlas(AtlasBase value) { }

	// RVA: 0x17A48C0
	internal VectorImageManager get_vectorImageManager() { }

	// RVA: 0x17A48C8
	private void set_vectorImageManager(VectorImageManager value) { }

	// RVA: 0x17A48D8
	internal UnityEngine.UIElements.UIR.TempAllocator<UnityEngine.UIElements.Vertex> get_vertsPool() { }

	// RVA: 0x17A48E0
	private void set_vertsPool(UnityEngine.UIElements.UIR.TempAllocator<UnityEngine.UIElements.Vertex> value) { }

	// RVA: 0x17A48F0
	internal UnityEngine.UIElements.UIR.TempAllocator<System.UInt16> get_indicesPool() { }

	// RVA: 0x17A48F8
	private void set_indicesPool(UnityEngine.UIElements.UIR.TempAllocator<System.UInt16> value) { }

	// RVA: 0x17A4908
	internal JobManager get_jobManager() { }

	// RVA: 0x17A4910
	private void set_jobManager(JobManager value) { }

	// RVA: 0x17A4920
	internal UIRStylePainter get_painter() { }

	// RVA: 0x17A4928
	private void set_painter(UIRStylePainter value) { }

	// RVA: 0x17A4938
	internal bool get_drawStats() { }

	// RVA: 0x17A4940
	internal void set_drawStats(bool value) { }

	// RVA: 0x17A4948
	internal bool get_drawInCameras() { }

	// RVA: 0x17A4950
	private void set_drawInCameras(bool value) { }

	// RVA: 0x17A4958
	internal void set_defaultShader(Shader value) { }

	// RVA: 0x17A4A68
	internal void set_defaultWorldSpaceShader(Shader value) { }

	// RVA: 0x17A33D8
	internal Material GetStandardMaterial() { }

	// RVA: 0x17A4B78
	internal Material GetStandardWorldSpaceMaterial() { }

	// RVA: 0x17A4CD8
	internal void EnsureFitsDepth(int depth) { }

	// RVA: 0x17A4CE4
	internal void ChildWillBeRemoved(VisualElement ve) { }

	// RVA: 0x17A4DB4
	internal RenderChainCommand AllocCommand() { }

	// RVA: 0x17A4E78
	internal void FreeCommand(RenderChainCommand cmd) { }

	// RVA: 0x17A4FA4
	internal void OnRenderCommandAdded(RenderChainCommand command) { }

	// RVA: 0x17A507C
	internal void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	// RVA: 0x17A50B0
	private static RenderNodeData AccessRenderNodeData(IntPtr obj) { }

	// RVA: 0x17A5184
	private static void OnRenderNodeExecute(IntPtr obj) { }

	// RVA: 0x17A5234
	private static void OnRegisterIntermediateRenderers(Camera camera) { }

	// RVA: 0x17A5864
	private static void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, RenderNodeData rnd, Camera camera, int sameDistanceSortPriority) { }

	// RVA: 0x17A5BC0
	internal void RepaintTexturedElements() { }

	// RVA: 0x17A5CA4
	public void InsertTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) { }

	// RVA: 0x17A2554
	public void ResetTextures(VisualElement ve) { }

	// RVA: 0x17A3538
	private void DrawStats() { }

	// RVA: 0x17A2534
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

	// RVA: 0x17A671C
	internal RenderChainCommand get_lastClosingOrLastCommand() { }

	// RVA: 0x17A6734
	internal static bool AllocatesID(BMPAlloc alloc) { }

	// RVA: 0x17A67C8
	internal static bool InheritsID(BMPAlloc alloc) { }

	// RVA: 0x17A6844
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

	// RVA: 0x17A6850
	protected bool get_disposed() { }

	// RVA: 0x17A6858
	private void set_disposed(bool value) { }

	// RVA: 0x17A6860
	public void Dispose() { }

	// RVA: 0x17A68F0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17A6908
	protected void .ctor() { }

	// RVA: 0x17A6910
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

	// RVA: 0x30D4918
	protected override void Dispose(bool disposing) { }

	// RVA: 0x30D3CF0
	public override Texture2D get_texture() { }

	// RVA: -1
	public override bool AllocateRect(int width, int height, RectInt uvs) { }

	// RVA: -1
	public override void SetTexel(int x, int y, Color color) { }

	// RVA: 0x30D488C
	public override void UpdateTexture() { }

	// RVA: 0x30D488C
	private void CreateOrExpandTexture() { }

	// RVA: 0x318DB98
	private static void CpuBlit(Unity.Collections.NativeArray<T> src, int srcWidth, int srcHeight, Unity.Collections.NativeArray<T> dst, int dstWidth, int dstHeight) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.ShaderInfoStorageRGBA32.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17A6B7C
	private static void .cctor() { }

	// RVA: 0x17A6BE8
	public void .ctor() { }

	// RVA: 0x17A6BF0
	internal Color32 <.cctor>b__2_0(Color c) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorageRGBA32
{
	// Fields
	private static readonly System.Func<UnityEngine.Color,UnityEngine.Color32> s_Convert; // 0x0

	// Methods

	// RVA: 0x17A6A08
	public void .ctor(int initialSize, int maxSize) { }

	// RVA: 0x17A6AA8
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17A6D6C
	private static void .cctor() { }

	// RVA: 0x17A6DD8
	public void .ctor() { }

	// RVA: 0x17A6DE0
	internal Color <.cctor>b__2_0(Color c) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorageRGBAFloat
{
	// Fields
	private static readonly System.Func<UnityEngine.Color,UnityEngine.Color> s_Convert; // 0x0

	// Methods

	// RVA: 0x17A6BF8
	public void .ctor(int initialSize, int maxSize) { }

	// RVA: 0x17A6C98
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

	// RVA: 0x17A6DE4
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

	// RVA: 0x30D3738
	protected bool get_disposed() { }

	// RVA: 0x30D4918
	private void set_disposed(bool value) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D4918
	protected void Dispose(bool disposing) { }

	// RVA: 0x318DB98
	public Unity.Collections.NativeSlice<T> Alloc(int count) { }

	// RVA: 0x30D488C
	public void Reset() { }

	// RVA: 0x30D488C
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

	// RVA: 0x17A70B8
	public override bool Equals(object obj) { }

	// RVA: 0x17A7160
	public bool Equals(TextCoreSettings other) { }

	// RVA: 0x17A7264
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

	// RVA: 0x17A7400
	protected bool get_disposed() { }

	// RVA: 0x17A7408
	private void set_disposed(bool value) { }

	// RVA: 0x17A7410
	public void Dispose() { }

	// RVA: 0x17A74A0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17A7550
	private static void .cctor() { }

	// RVA: 0x17A7694
	public void .ctor(int capacity) { }

	// RVA: 0x17A7760
	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x17A7894
	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x17A8330
	public void Commit(RenderTexture dst) { }

	// RVA: 0x17A7A2C
	private void BeginBlit(RenderTexture dst) { }

	// RVA: 0x17A7CA8
	private void DoBlit(System.Collections.Generic.IList<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> blitInfos, int startIndex) { }

	// RVA: 0x17A82A8
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

	// RVA: 0x17A851C
	private static void .cctor() { }

	// RVA: 0x17A86CC
	public void .ctor() { }

	// RVA: 0x17A88A4
	public void Reset() { }

	// RVA: 0x17A8B38
	public void StartNewBatch() { }

	// RVA: 0x17A8BB0
	public int IndexOf(TextureId id) { }

	// RVA: 0x17A8CC0
	public void MarkUsed(int slotIndex) { }

	// RVA: 0x17A8D1C
	public int get_FreeSlots() { }

	// RVA: 0x17A8D24
	private void set_FreeSlots(int value) { }

	// RVA: 0x17A8D2C
	public int FindOldestSlot() { }

	// RVA: 0x17A8E7C
	public void Bind(TextureId id, float sdfScale, int slot, MaterialPropertyBlock mat) { }

	// RVA: 0x17A89C8
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

	// RVA: 0x17A9254
	private static void .cctor() { }

	// RVA: 0x17A92C0
	public void .ctor() { }

	// RVA: 0x17A92C8
	internal VectorImageRenderInfo <.ctor>b__0_0() { }

	// RVA: 0x17A93A8
	internal void <.ctor>b__0_1(VectorImageRenderInfo vectorImageInfo) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageRenderInfoPool
{
	// Methods

	// RVA: 0x17A9080
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

	// RVA: 0x17A93E8
	public void Reset() { }

	// RVA: 0x17A9354
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

	// RVA: 0x17A95F4
	private static void .cctor() { }

	// RVA: 0x17A9660
	public void .ctor() { }

	// RVA: 0x17A9668
	internal GradientRemap <.ctor>b__0_0() { }

	// RVA: 0x17A9748
	internal void <.ctor>b__0_1(GradientRemap gradientRemap) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientRemapPool
{
	// Methods

	// RVA: 0x17A9420
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

	// RVA: 0x17A97C4
	public void Reset() { }

	// RVA: 0x17A96F4
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

	// RVA: 0x17A9838
	public Texture2D get_atlas() { }

	// RVA: 0x17A984C
	public void .ctor(AtlasBase atlas) { }

	// RVA: 0x17A9A20
	protected bool get_disposed() { }

	// RVA: 0x17A9A28
	private void set_disposed(bool value) { }

	// RVA: 0x17A9A30
	public void Dispose() { }

	// RVA: 0x17A9AC0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17A9BF4
	public void Commit() { }

	// RVA: 0x17A9C28
	public GradientRemap AddUser(VectorImage vi, VisualElement context) { }

	// RVA: 0x17A9D5C
	private VectorImageRenderInfo Register(VectorImage vi, VisualElement context) { }

	// RVA: 0x17AA250
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

	// RVA: 0x17AA36C
	public bool Equals(BMPAlloc other) { }

	// RVA: 0x17A67B8
	public bool IsValid() { }

	// RVA: 0x17AA3A4
	public override string ToString() { }

	// RVA: 0x17AA498
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

	// RVA: 0x17AA4E8
	public void Construct(int pageHeight, int entryWidth, int entryHeight) { }

	// RVA: 0x17AA618
	public void ForceFirstAlloc(UInt16 firstPageX, UInt16 firstPageY) { }

	// RVA: 0x17AA71C
	public BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	// RVA: 0x17AABF0
	public void Free(BMPAlloc alloc) { }

	// RVA: 0x17AAD60
	public int get_entryWidth() { }

	// RVA: 0x17AAD68
	public int get_entryHeight() { }

	// RVA: 0x17AAD70
	internal void GetAllocPageAtlasLocation(int page, UInt16 x, UInt16 y) { }

	// RVA: 0x17AAB8C
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

	// RVA: 0x17AAE04
	private static int get_pageWidth() { }

	// RVA: 0x17AAE0C
	private static int get_pageHeight() { }

	// RVA: 0x17AAE14
	private static Vector2Int AllocToTexelCoord(BitmapAllocator32 allocator, BMPAlloc alloc) { }

	// RVA: 0x17AAEAC
	private static int AllocToConstantBufferIndex(BMPAlloc alloc) { }

	// RVA: 0x17AAF18
	private static bool AtlasRectMatchesPage(BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	// RVA: 0x17AB12C
	public Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> get_transformConstants() { }

	// RVA: 0x17AB180
	public Unity.Collections.NativeSlice<UnityEngine.Vector4> get_clipRectConstants() { }

	// RVA: 0x17AB1D4
	public Texture get_atlas() { }

	// RVA: 0x17AB294
	public void Construct() { }

	// RVA: 0x17AB584
	private void ReallyCreateStorage() { }

	// RVA: 0x17AC690
	public void Dispose() { }

	// RVA: 0x17AC7A4
	public void IssuePendingStorageChanges() { }

	// RVA: 0x17AC7BC
	public BMPAlloc AllocTransform() { }

	// RVA: 0x17AC954
	public BMPAlloc AllocClipRect() { }

	// RVA: 0x17ACAEC
	public BMPAlloc AllocOpacity() { }

	// RVA: 0x17ACB74
	public BMPAlloc AllocColor() { }

	// RVA: 0x17ACBFC
	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	// RVA: 0x17ABA58
	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	// RVA: 0x17ABD68
	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	// RVA: 0x17ABF94
	public void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	// RVA: 0x17AC12C
	public void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext) { }

	// RVA: 0x17AC334
	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext) { }

	// RVA: 0x17ACC84
	public void FreeTransform(BMPAlloc alloc) { }

	// RVA: 0x17ACD44
	public void FreeClipRect(BMPAlloc alloc) { }

	// RVA: 0x17ACE04
	public void FreeOpacity(BMPAlloc alloc) { }

	// RVA: 0x17ACEC4
	public void FreeColor(BMPAlloc alloc) { }

	// RVA: 0x17ACF84
	public void FreeTextCoreSettings(BMPAlloc alloc) { }

	// RVA: 0x17AD044
	public Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x17AD1A8
	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x17AD30C
	public Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x17AD440
	public Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x17AD574
	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	// RVA: 0x17AD6A8
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

	// RVA: 0x17AD85C
	private static void GetVerticesTransformInfo(VisualElement ve, Matrix4x4 transform) { }

	// RVA: 0x17ADA24
	internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, Matrix4x4 result) { }

	// RVA: 0x17ADC38
	private static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child) { }

	// RVA: 0x17ADCD0
	public static ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ChainBuilderStats stats) { }

	// RVA: 0x17B1E34
	private static void InvokeGenerateVisualContent(VisualElement ve, MeshGenerationContext ctx) { }

	// RVA: 0x17B2FD4
	private static Material CreateBlitShader(float colorConversion) { }

	// RVA: 0x17B2A8C
	private static Material GetBlitMaterial(RenderTargetMode mode) { }

	// RVA: 0x17B3240
	public static void ClosePaintElement(VisualElement ve, ClosingInfo closingInfo, RenderChain renderChain, ChainBuilderStats stats) { }

	// RVA: 0x17B2050
	private static void UpdateOrAllocate(MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& verts, Unity.Collections.NativeSlice<System.UInt16>& indices, UInt16 indexOffset, ChainBuilderStats stats) { }

	// RVA: 0x17B3474
	public static void UpdateOpacityId(VisualElement ve, RenderChain renderChain) { }

	// RVA: 0x17B3580
	private static void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh) { }

	// RVA: 0x17B36A0
	public static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device) { }

	// RVA: 0x17B3A70
	private static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, IntPtr src, IntPtr dst, int count) { }

	// RVA: 0x17B2498
	private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, RenderChainCommand cmdPrev, RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x17B2E14
	private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, RenderChainCommand cmdPrev, RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x17B2148
	private static void FindCommandInsertionPoint(VisualElement ve, RenderChainCommand prev, RenderChainCommand next) { }

	// RVA: 0x17B26E8
	private static void FindClosingCommandInsertionPoint(VisualElement ve, RenderChainCommand prev, RenderChainCommand next) { }

	// RVA: 0x17B25D0
	private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, RenderChainCommand prev, RenderChainCommand next) { }

	// RVA: 0x17B292C
	private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, RenderChainCommand prev, RenderChainCommand next) { }

	// RVA: 0x17AF2A0
	public static void ResetCommands(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x17B3B8C
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

	// RVA: 0x17B3D34
	internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x17B45C0
	internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x17B4B94
	internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x17B4E74
	internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x17B5440
	internal static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x17B5B50
	private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve) { }

	// RVA: 0x17B5CE8
	private static Vector4 GetClipRectIDClipInfo(VisualElement ve) { }

	// RVA: 0x17B5F04
	internal static UInt32 DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState) { }

	// RVA: 0x17B79F0
	internal static UInt32 DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x17B3E28
	private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, UInt32 dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ChainBuilderStats stats) { }

	// RVA: 0x17B46C8
	private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, UInt32 dirtyID, bool hierarchical, ChainBuilderStats stats, bool isDoingFullVertexRegeneration) { }

	// RVA: 0x17B4C20
	private static void OnColorChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ChainBuilderStats stats) { }

	// RVA: 0x17B4F3C
	private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, UInt32 dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ChainBuilderStats stats) { }

	// RVA: 0x17B561C
	private static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, bool parentHierarchyHidden, bool hierarchical, ChainBuilderStats stats) { }

	// RVA: 0x17B89AC
	private static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x17B5558
	private static bool IsElementHierarchyHidden(VisualElement ve) { }

	// RVA: 0x17B67F0
	private static VisualElement GetLastDeepestChild(VisualElement ve) { }

	// RVA: 0x17B8874
	private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x17B6680
	private static bool UpdateLocalFlipsWinding(VisualElement ve) { }

	// RVA: 0x17B904C
	private static void UpdateWorldFlipsWinding(VisualElement ve) { }

	// RVA: 0x17B8E74
	private static void UpdateZeroScaling(VisualElement ve) { }

	// RVA: 0x17B6878
	private static bool NeedsTransformID(VisualElement ve) { }

	// RVA: 0x17B68C8
	internal static bool NeedsColorID(VisualElement ve) { }

	// RVA: 0x17B90AC
	internal static bool NeedsTextCoreSettings(VisualElement ve) { }

	// RVA: 0x17B68EC
	private static bool InitColorIDs(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x17B728C
	private static void SetColorValues(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x17B9174
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

	// RVA: 0x17B91C8
	private MeshWriteData GetPooledMeshWriteData() { }

	// RVA: 0x17B92C0
	private MeshWriteData AllocRawVertsIndices(UInt32 vertexCount, UInt32 indexCount, AllocMeshData allocatorData) { }

	// RVA: 0x17B9380
	private MeshWriteData AllocThroughDrawMesh(UInt32 vertexCount, UInt32 indexCount, AllocMeshData allocatorData) { }

	// RVA: 0x17B9818
	public void .ctor(RenderChain renderChain) { }

	// RVA: 0x17B9B20
	public MeshGenerationContext get_meshGenerationContext() { }

	// RVA: 0x17B9B28
	public VisualElement get_currentElement() { }

	// RVA: 0x17B9B30
	private void set_currentElement(VisualElement value) { }

	// RVA: 0x17B2048
	public System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> get_entries() { }

	// RVA: 0x17B26CC
	public ClosingInfo get_closingInfo() { }

	// RVA: 0x17B9B40
	public int get_totalVertices() { }

	// RVA: 0x17B9B48
	private void set_totalVertices(int value) { }

	// RVA: 0x17B9B50
	public int get_totalIndices() { }

	// RVA: 0x17B9B58
	private void set_totalIndices(int value) { }

	// RVA: 0x17AF614
	public void Begin(VisualElement ve) { }

	// RVA: 0x17B2F54
	public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd) { }

	// RVA: 0x17B23F8
	public void LandClipRegisterMesh(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, int indexOffset) { }

	// RVA: 0x17B9394
	public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshFlags flags) { }

	// RVA: 0x17B9B60
	internal void TryAtlasTexture(Texture texture, MeshFlags flags, Rect outUVRegion, bool outIsAtlas, TextureId outTextureId, VertexFlags outAddFlags) { }

	// RVA: 0x17B9D74
	internal void BuildEntryFromNativeMesh(MeshWriteDataInterface meshData, Texture texture, TextureId textureId, bool isAtlas, Material material, MeshFlags flags, Rect uvRegion, VertexFlags addFlags) { }

	// RVA: 0x17BA17C
	internal void BuildGradientEntryFromNativeMesh(MeshWriteDataInterface meshData, TextureId svgTextureId) { }

	// RVA: 0x17BA4C8
	public void BuildRawEntryFromNativeMesh(MeshWriteDataInterface meshData) { }

	// RVA: 0x17BA69C
	public void DrawText(TextElement te) { }

	// RVA: 0x17BA738
	private void DrawTextInfo(TextInfo textInfo, Vector2 offset, bool useHints) { }

	// RVA: 0x17BADCC
	public void DrawRectangle(RectangleParams rectParams) { }

	// RVA: 0x17BBB08
	public void DrawBorder(BorderParams borderParams) { }

	// RVA: 0x17BBBAC
	public void DrawImmediate(Action callback, bool cullingEnabled) { }

	// RVA: 0x17BBCA4
	public VisualElement get_visualElement() { }

	// RVA: 0x17AFA00
	public void DrawVisualElementBackground() { }

	// RVA: 0x17BBDC4
	private void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	// RVA: 0x17BD4B0
	private void StampRectangleWithSubRect(RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV) { }

	// RVA: 0x17B10F8
	public void DrawVisualElementBorder() { }

	// RVA: 0x17B1C40
	public void ApplyVisualElementClipping() { }

	// RVA: 0x17BE40C
	private UInt16[] AdjustSpriteWinding(Vector2[] vertices, UInt16[] indices) { }

	// RVA: 0x17BB50C
	public void DrawSprite(RectangleParams rectParams) { }

	// RVA: 0x17BB8A8
	private void ApplyInset(NativeRectParams rectParams, Texture tex) { }

	// RVA: 0x17BB10C
	public void DrawVectorImage(RectangleParams rectParams) { }

	// RVA: 0x17BE740
	private void MakeVectorGraphics(RectangleParams rectParams, bool isUsingGradients, TextureId svgTexture, int settingIndexOffset, int finalVertexCount, int finalIndexCount) { }

	// RVA: 0x17B1F7C
	internal void Reset() { }

	// RVA: 0x17BEB40
	private void ValidateMeshWriteData() { }

	// RVA: 0x17BDA8C
	private void GenerateStencilClipEntryForRoundedRectBackground() { }

	// RVA: 0x17BD784
	private void GenerateStencilClipEntryForSVGBackground() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal abstract class HierarchyTraversal
{
	// Methods

	// RVA: 0x17BF034
	public virtual void Traverse(VisualElement element) { }

	// RVA: -1
	public abstract void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x17BF044
	protected void Recurse(VisualElement element, int depth) { }

	// RVA: 0x17BF11C
	protected void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class InitialStyle
{
	// Fields
	private static ComputedStyle s_InitialStyle; // 0x0

	// Methods

	// RVA: 0x17BF124
	public static ComputedStyle Get() { }

	// RVA: 0x17BF198
	public static ComputedStyle Acquire() { }

	// RVA: 0x17BF244
	private static void .cctor() { }

	// RVA: 0x17BFF74
	public static Align get_alignContent() { }

	// RVA: 0x17BFFF0
	public static Align get_alignItems() { }

	// RVA: 0x17C006C
	public static Align get_alignSelf() { }

	// RVA: 0x17C00E8
	public static Color get_backgroundColor() { }

	// RVA: 0x17C0168
	public static Background get_backgroundImage() { }

	// RVA: 0x17C01F4
	public static BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x17C0278
	public static BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x17C02FC
	public static BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x17C0378
	public static BackgroundSize get_backgroundSize() { }

	// RVA: 0x17C040C
	public static Color get_borderBottomColor() { }

	// RVA: 0x17C048C
	public static Length get_borderBottomLeftRadius() { }

	// RVA: 0x17C0508
	public static Length get_borderBottomRightRadius() { }

	// RVA: 0x17C0584
	public static float get_borderBottomWidth() { }

	// RVA: 0x17C0600
	public static Color get_borderLeftColor() { }

	// RVA: 0x17C0680
	public static float get_borderLeftWidth() { }

	// RVA: 0x17C06FC
	public static Color get_borderRightColor() { }

	// RVA: 0x17C077C
	public static float get_borderRightWidth() { }

	// RVA: 0x17C07F8
	public static Color get_borderTopColor() { }

	// RVA: 0x17C0878
	public static Length get_borderTopLeftRadius() { }

	// RVA: 0x17C08F4
	public static Length get_borderTopRightRadius() { }

	// RVA: 0x17C0970
	public static float get_borderTopWidth() { }

	// RVA: 0x17C09EC
	public static Length get_bottom() { }

	// RVA: 0x17C0A68
	public static Color get_color() { }

	// RVA: 0x17C0AE4
	public static Cursor get_cursor() { }

	// RVA: 0x17C0B78
	public static DisplayStyle get_display() { }

	// RVA: 0x17C0BF4
	public static Length get_flexBasis() { }

	// RVA: 0x17C0C70
	public static FlexDirection get_flexDirection() { }

	// RVA: 0x17C0CEC
	public static float get_flexGrow() { }

	// RVA: 0x17C0D68
	public static float get_flexShrink() { }

	// RVA: 0x17C0DE4
	public static Wrap get_flexWrap() { }

	// RVA: 0x17C0E60
	public static Length get_fontSize() { }

	// RVA: 0x17C0ED8
	public static Length get_height() { }

	// RVA: 0x17C0F54
	public static Justify get_justifyContent() { }

	// RVA: 0x17C0FD0
	public static Length get_left() { }

	// RVA: 0x17C104C
	public static Length get_letterSpacing() { }

	// RVA: 0x17C10C4
	public static Length get_marginBottom() { }

	// RVA: 0x17C1140
	public static Length get_marginLeft() { }

	// RVA: 0x17C11BC
	public static Length get_marginRight() { }

	// RVA: 0x17C1238
	public static Length get_marginTop() { }

	// RVA: 0x17C12B4
	public static Length get_maxHeight() { }

	// RVA: 0x17C1330
	public static Length get_maxWidth() { }

	// RVA: 0x17C13AC
	public static Length get_minHeight() { }

	// RVA: 0x17C1428
	public static Length get_minWidth() { }

	// RVA: 0x17C14A4
	public static float get_opacity() { }

	// RVA: 0x17C1520
	public static OverflowInternal get_overflow() { }

	// RVA: 0x17C159C
	public static Length get_paddingBottom() { }

	// RVA: 0x17C1618
	public static Length get_paddingLeft() { }

	// RVA: 0x17C1694
	public static Length get_paddingRight() { }

	// RVA: 0x17C1710
	public static Length get_paddingTop() { }

	// RVA: 0x17C178C
	public static Position get_position() { }

	// RVA: 0x17C1808
	public static Length get_right() { }

	// RVA: 0x17C1884
	public static Rotate get_rotate() { }

	// RVA: 0x17C1918
	public static Scale get_scale() { }

	// RVA: 0x17C1998
	public static TextOverflow get_textOverflow() { }

	// RVA: 0x17C1A14
	public static TextShadow get_textShadow() { }

	// RVA: 0x17C1AA4
	public static Length get_top() { }

	// RVA: 0x17C1B20
	public static TransformOrigin get_transformOrigin() { }

	// RVA: 0x17C1BB4
	public static System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay() { }

	// RVA: 0x17C1C30
	public static System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration() { }

	// RVA: 0x17C1CAC
	public static System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty() { }

	// RVA: 0x17C1D28
	public static System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x17C1DA4
	public static Translate get_translate() { }

	// RVA: 0x17C1E38
	public static Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x17C1EB8
	public static Font get_unityFont() { }

	// RVA: 0x17C1F30
	public static FontDefinition get_unityFontDefinition() { }

	// RVA: 0x17C1FAC
	public static FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x17C2024
	public static OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x17C20A0
	public static Length get_unityParagraphSpacing() { }

	// RVA: 0x17C2118
	public static int get_unitySliceBottom() { }

	// RVA: 0x17C2194
	public static int get_unitySliceLeft() { }

	// RVA: 0x17C2210
	public static int get_unitySliceRight() { }

	// RVA: 0x17C228C
	public static float get_unitySliceScale() { }

	// RVA: 0x17C2308
	public static int get_unitySliceTop() { }

	// RVA: 0x17C2384
	public static TextAnchor get_unityTextAlign() { }

	// RVA: 0x17C23FC
	public static Color get_unityTextOutlineColor() { }

	// RVA: 0x17C2478
	public static float get_unityTextOutlineWidth() { }

	// RVA: 0x17C24F0
	public static TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x17C256C
	public static Visibility get_visibility() { }

	// RVA: 0x17C25E4
	public static WhiteSpace get_whiteSpace() { }

	// RVA: 0x17C265C
	public static Length get_width() { }

	// RVA: 0x17C26D8
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

	// RVA: 0x17C2750
	public static void ApplyBackgroundPosition(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C2FB0
	public static void ApplyBorderColor(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C323C
	public static void ApplyBorderRadius(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C3480
	public static void ApplyBorderWidth(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C3690
	public static void ApplyFlex(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C3B3C
	public static void ApplyMargin(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C3DC8
	public static void ApplyPadding(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C3EB8
	public static void ApplyTransition(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C4BCC
	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C4DDC
	public static void ApplyUnityTextOutline(StylePropertyReader reader, ComputedStyle computedStyle) { }

	// RVA: 0x17C3764
	private static bool CompileFlexShorthand(StylePropertyReader reader, float grow, float shrink, Length basis) { }

	// RVA: 0x17C332C
	private static void CompileBorderRadius(StylePropertyReader reader, Length top, Length right, Length bottom, Length left) { }

	// RVA: 0x17C2828
	private static void CompileBackgroundPosition(StylePropertyReader reader, BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY) { }

	// RVA: 0x17C4D30
	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize) { }

	// RVA: 0x17C3C2C
	private static void CompileBoxArea(StylePropertyReader reader, Length top, Length right, Length bottom, Length left) { }

	// RVA: 0x17C35CC
	private static void CompileBoxArea(StylePropertyReader reader, float top, float right, float bottom, float left) { }

	// RVA: 0x17C30A8
	private static void CompileBoxArea(StylePropertyReader reader, Color top, Color right, Color bottom, Color left) { }

	// RVA: 0x17C4E98
	private static void CompileTextOutline(StylePropertyReader reader, Color outlineColor, float outlineWidth) { }

	// RVA: 0x17C4014
	private static void CompileTransition(StylePropertyReader reader, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDelay, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDuration, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>& outProperty, System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>& outTimingFunction) { }

	// RVA: 0x17C6A50
	private static void .cctor() { }

	// RVA: 0x17C5558
	internal static void <CompileBackgroundPosition>g__SwapKeyword|16_0(BackgroundPositionKeyword a, BackgroundPositionKeyword b) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StylePropertyCache
{
	// Fields
	internal static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_PropertySyntaxCache; // 0x0
	internal static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_NonTerminalValues; // 0x8

	// Methods

	// RVA: 0x17C6BC4
	public static bool TryGetSyntax(string name, string syntax) { }

	// RVA: 0x17C6C70
	public static bool TryGetNonTerminalValue(string name, string syntax) { }

	// RVA: 0x17C6D1C
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

	// RVA: 0x17C57C0
	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, int intValue) { }

	// RVA: 0x17C8168
	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) { }

	// RVA: 0x17C8300
	public static bool IsAnimatable(StylePropertyId id) { }

	// RVA: 0x17C83B4
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

	// RVA: 0x17CAF0C
	public void .ctor(float value, Unit unit) { }

	// RVA: 0x17C551C
	public Length ToLength() { }

	// RVA: 0x17CAF18
	public TimeValue ToTime() { }

	// RVA: 0x17CAF54
	public Angle ToAngle() { }

	// RVA: 0x17CB028
	public static bool op_Equality(Dimension lhs, Dimension rhs) { }

	// RVA: 0x17CB048
	public bool Equals(Dimension other) { }

	// RVA: 0x17CB068
	public override bool Equals(object obj) { }

	// RVA: 0x17CB104
	public override int GetHashCode() { }

	// RVA: 0x17CB150
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

	// RVA: 0x17CB288
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

	// RVA: 0x17CB418
	public bool IsNull() { }

}

// Namespace: 
internal sealed class GetCursorIdFunction
{
	// Methods

	// RVA: 0x17CF92C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17CFA50
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

	// RVA: 0x17CB564
	public StyleProperty get_property() { }

	// RVA: 0x17CB56C
	private void set_property(StyleProperty value) { }

	// RVA: 0x17CB574
	public StylePropertyId get_propertyId() { }

	// RVA: 0x17CB57C
	private void set_propertyId(StylePropertyId value) { }

	// RVA: 0x17CB584
	public int get_valueCount() { }

	// RVA: 0x17CB58C
	private void set_valueCount(int value) { }

	// RVA: 0x17CB594
	public float get_dpiScaling() { }

	// RVA: 0x17CB59C
	private void set_dpiScaling(float value) { }

	// RVA: 0x17CB5A4
	public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling) { }

	// RVA: 0x17CBA98
	public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling) { }

	// RVA: 0x17CBB00
	public StylePropertyId MoveNextProperty() { }

	// RVA: 0x17C537C
	public StylePropertyValue GetValue(int index) { }

	// RVA: 0x17C512C
	public StyleValueType GetValueType(int index) { }

	// RVA: 0x17C4FEC
	public bool IsValueType(int index, StyleValueType type) { }

	// RVA: 0x17C5088
	public bool IsKeyword(int index, StyleValueKeyword keyword) { }

	// RVA: 0x17C573C
	public string ReadAsString(int index) { }

	// RVA: 0x17C51BC
	public Length ReadLength(int index) { }

	// RVA: 0x17C568C
	public TimeValue ReadTimeValue(int index) { }

	// RVA: 0x17CBC44
	public Translate ReadTranslate(int index) { }

	// RVA: 0x17CC018
	public TransformOrigin ReadTransformOrigin(int index) { }

	// RVA: 0x17CC304
	public Rotate ReadRotate(int index) { }

	// RVA: 0x17CC55C
	public Scale ReadScale(int index) { }

	// RVA: 0x17C52F0
	public float ReadFloat(int index) { }

	// RVA: 0x17CC878
	public int ReadInt(int index) { }

	// RVA: 0x17C556C
	public Color ReadColor(int index) { }

	// RVA: 0x17C53F8
	public int ReadEnum(StyleEnumType enumType, int index) { }

	// RVA: 0x17CC91C
	public FontDefinition ReadFontDefinition(int index) { }

	// RVA: 0x17CCEC4
	public Font ReadFont(int index) { }

	// RVA: 0x17CD248
	public Background ReadBackground(int index) { }

	// RVA: 0x17CDE34
	public Cursor ReadCursor(int index) { }

	// RVA: 0x17CE220
	public TextShadow ReadTextShadow(int index) { }

	// RVA: 0x17CE6BC
	public BackgroundPosition ReadBackgroundPositionX(int index) { }

	// RVA: 0x17CE7B4
	public BackgroundPosition ReadBackgroundPositionY(int index) { }

	// RVA: 0x17CE6D8
	private BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword) { }

	// RVA: 0x17CE958
	public BackgroundRepeat ReadBackgroundRepeat(int index) { }

	// RVA: 0x17CEB7C
	public BackgroundSize ReadBackgroundSize(int index) { }

	// RVA: 0x17CEEA4
	public void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> list, int index) { }

	// RVA: 0x17CF0AC
	public void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> list, int index) { }

	// RVA: 0x17CF270
	public void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list, int index) { }

	// RVA: 0x17CB69C
	private void LoadProperties() { }

	// RVA: 0x17CBB3C
	private void SetCurrentProperty() { }

	// RVA: 0x17CC150
	public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) { }

	// RVA: 0x17CF420
	private static Length ReadTransformOriginEnum(StylePropertyValue value, bool isVertical, bool isHorizontal) { }

	// RVA: 0x17CBD7C
	public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x17CC674
	public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x17CC43C
	public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) { }

	// RVA: 0x17CF718
	private static bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, int intValue) { }

	// RVA: 0x17CF59C
	private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value) { }

	// RVA: 0x17CF68C
	public static Angle ReadAngle(StylePropertyValue value) { }

	// RVA: 0x17CE7D0
	public static BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword) { }

	// RVA: 0x17CEAB4
	public static BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x17CEC6C
	public static BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x17CD51C
	internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, ImageSource source) { }

	// RVA: 0x17CF80C
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

	// RVA: 0x17CFA64
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

	// RVA: 0x17CFA70
	public void .ctor(StyleSheet sheet, int styleSheetIndexInStack) { }

	// RVA: 0x17CFAA0
	public static int Compare(SelectorMatchRecord a, SelectorMatchRecord b) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSelectorHelper
{
	// Methods

	// RVA: 0x17CFB9C
	public static MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	// RVA: 0x17CFE84
	public static bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult) { }

	// RVA: 0x17D00D8
	private static void FastLookup(System.Collections.Generic.IDictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> table, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, SelectorMatchRecord record) { }

	// RVA: 0x17D02CC
	public static void FindMatches(StyleMatchingContext context, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }

}

// Namespace: 
private struct SheetHandleKey
{
	// Fields
	public readonly int sheetInstanceID; // 0x10
	public readonly int index; // 0x14

	// Methods

	// RVA: 0x17D0A34
	public void .ctor(StyleSheet sheet, int index) { }

}

// Namespace: 
private class SheetHandleKeyComparer
{
	// Methods

	// RVA: 0x17D0D58
	public bool Equals(SheetHandleKey x, SheetHandleKey y) { }

	// RVA: 0x17D0D64
	public int GetHashCode(SheetHandleKey key) { }

	// RVA: 0x17D0D50
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetCache
{
	// Fields
	private static SheetHandleKeyComparer s_Comparer; // 0x0
	private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey,UnityEngine.UIElements.StyleSheets.StylePropertyId[]> s_RulePropertyIdsCache; // 0x8

	// Methods

	// RVA: 0x17D0868
	internal static StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) { }

	// RVA: 0x17D0B74
	internal static StylePropertyId[] GetPropertyIds(StyleRule rule) { }

	// RVA: 0x17D0A6C
	private static StylePropertyId GetPropertyId(StyleRule rule, int index) { }

	// RVA: 0x17D0C60
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetColor
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.Color32> s_NameToColor; // 0x0

	// Methods

	// RVA: 0x17D0DAC
	public static bool TryGetColor(string name, Color color) { }

	// RVA: 0x17D0EC0
	private static Color32 HexToColor32(UInt32 color) { }

	// RVA: 0x17D0ED4
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetExtensions
{
	// Methods

	// RVA: 0x17D2D44
	public static string ReadAsString(StyleSheet sheet, StyleValueHandle handle) { }

	// RVA: 0x17D30AC
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

	// RVA: 0x17D30E4
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

	// RVA: 0x17D30F4
	public bool get_hasCurrent() { }

	// RVA: 0x17D3128
	public int get_currentIndex() { }

	// RVA: 0x17D3130
	public void set_currentIndex(int value) { }

	// RVA: 0x17D3138
	public int get_matchedVariableCount() { }

	// RVA: 0x17D3140
	public void set_matchedVariableCount(int value) { }

	// RVA: 0x17D3148
	protected void Initialize() { }

	// RVA: 0x17D31A0
	public void MoveNext() { }

	// RVA: 0x17D31E8
	public void SaveContext() { }

	// RVA: 0x17D3254
	public void RestoreContext() { }

	// RVA: 0x17D32C0
	public void DropContext() { }

	// RVA: 0x17D3324
	protected bool Match(Expression exp) { }

	// RVA: 0x17D33E4
	private bool MatchExpression(Expression exp) { }

	// RVA: 0x17D362C
	private bool MatchExpressionWithMultiplier(Expression exp) { }

	// RVA: 0x17D3ACC
	private bool MatchGroup(Expression exp) { }

	// RVA: 0x17D37C8
	private bool MatchCombinator(Expression exp) { }

	// RVA: 0x17D3B84
	private bool MatchOr(Expression exp) { }

	// RVA: 0x17D3CF4
	private bool MatchOrOr(Expression exp) { }

	// RVA: 0x17D3D10
	private bool MatchAndAnd(Expression exp) { }

	// RVA: 0x17D3DB8
	private int MatchMany(Expression exp) { }

	// RVA: 0x17D4160
	private int MatchManyByOrder(Expression exp, Int32* matchOrder) { }

	// RVA: 0x17D3D4C
	private bool MatchJuxtaposition(Expression exp) { }

	// RVA: 0x17D399C
	private bool MatchDataType(Expression exp) { }

	// RVA: 0x17D4318
	protected void .ctor() { }

	// RVA: 0x17D43A4
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class StylePropertyValueMatcher
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values; // 0x20

	// Methods

	// RVA: 0x17D4448
	private StylePropertyValue get_current() { }

	// RVA: 0x17D44EC
	public override int get_valueCount() { }

	// RVA: 0x17D4538
	public override bool get_isCurrentVariable() { }

	// RVA: 0x17D4540
	public override bool get_isCurrentComma() { }

	// RVA: 0x17D45FC
	public MatchResult Match(Expression exp, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> values) { }

	// RVA: 0x17D4918
	protected override bool MatchKeyword(string keyword) { }

	// RVA: 0x17D4A4C
	protected override bool MatchNumber() { }

	// RVA: 0x17D4AF8
	protected override bool MatchInteger() { }

	// RVA: 0x17D4BA4
	protected override bool MatchLength() { }

	// RVA: 0x17D4D30
	protected override bool MatchPercentage() { }

	// RVA: 0x17D4EBC
	protected override bool MatchColor() { }

	// RVA: 0x17D501C
	protected override bool MatchResource() { }

	// RVA: 0x17D50C8
	protected override bool MatchUrl() { }

	// RVA: 0x17D5178
	protected override bool MatchTime() { }

	// RVA: 0x17D5258
	protected override bool MatchCustomIdent() { }

	// RVA: 0x17D53A0
	protected override bool MatchAngle() { }

	// RVA: 0x17D5534
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

	// RVA: 0x17D55F8
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

	// RVA: 0x17D33DC
	public ExpressionMultiplierType get_type() { }

	// RVA: 0x17D56B4
	public void set_type(ExpressionMultiplierType value) { }

	// RVA: 0x17D5658
	public void .ctor(ExpressionMultiplierType type) { }

	// RVA: 0x17D5710
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

	// RVA: 0x17D576C
	public Expression Parse(string syntax) { }

	// RVA: 0x17D653C
	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17D7148
	private void ProcessCombinatorStack() { }

	// RVA: 0x17D69C4
	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17D6F74
	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17D6BF0
	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17D7434
	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17D7F10
	private Expression ParseNonTerminalValue(string syntax) { }

	// RVA: 0x17D80B0
	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17D7BA8
	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ExpressionMultiplier multiplier) { }

	// RVA: 0x17D8484
	private void ParseRanges(StyleSyntaxTokenizer tokenizer, int min, int max) { }

	// RVA: 0x17D7E2C
	private static void EatSpace(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x17D7420
	private static bool IsExpressionEnd(StyleSyntaxToken token) { }

	// RVA: 0x17D7E18
	private static bool IsCombinator(StyleSyntaxToken token) { }

	// RVA: 0x17D846C
	private static bool IsMultiplier(StyleSyntaxToken token) { }

	// RVA: 0x17D8628
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

	// RVA: 0x17D87B0
	public void .ctor(StyleSyntaxTokenType t) { }

	// RVA: 0x17D87E0
	public void .ctor(StyleSyntaxTokenType type, string text) { }

	// RVA: 0x17D8810
	public void .ctor(StyleSyntaxTokenType type, int number) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class StyleSyntaxTokenizer
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken> m_Tokens; // 0x10
	private int m_CurrentTokenIndex; // 0x18

	// Methods

	// RVA: 0x17D68EC
	public StyleSyntaxToken get_current() { }

	// RVA: 0x17D7970
	public StyleSyntaxToken MoveNext() { }

	// RVA: 0x17D7D3C
	public StyleSyntaxToken PeekNext() { }

	// RVA: 0x17D5A1C
	public void Tokenize(string syntax) { }

	// RVA: 0x17D88A8
	private static bool IsNextCharacter(string s, int index, Char c) { }

	// RVA: 0x17D89B8
	private static bool IsNextLetterOrDash(string s, int index) { }

	// RVA: 0x17D88FC
	private static bool IsNextNumber(string s, int index) { }

	// RVA: 0x17D8844
	private static int GlobCharacter(string s, int index, Char c) { }

	// RVA: 0x17D5988
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public static class Easing
{
	// Methods

	// RVA: 0x17D8AA4
	public static float Linear(float t) { }

	// RVA: 0x17D8AA8
	public static float InSine(float t) { }

	// RVA: 0x17D8ADC
	public static float OutSine(float t) { }

	// RVA: 0x17D8AF0
	public static float InOutSine(float t) { }

	// RVA: 0x17D8B2C
	public static float InQuad(float t) { }

	// RVA: 0x17D8B34
	public static float OutQuad(float t) { }

	// RVA: 0x17D8B44
	public static float InOutQuad(float t) { }

	// RVA: 0x17D8B84
	public static float InCubic(float t) { }

	// RVA: 0x17D8B94
	public static float OutCubic(float t) { }

	// RVA: 0x17D8BF8
	public static float InOutCubic(float t) { }

	// RVA: 0x17D8B8C
	public static float InPower(float t, int power) { }

	// RVA: 0x17D8BBC
	public static float OutPower(float t, int power) { }

	// RVA: 0x17D8C50
	public static float InOutPower(float t, int power) { }

	// RVA: 0x17D8CCC
	public static float InBounce(float t) { }

	// RVA: 0x17D8DCC
	public static float OutBounce(float t) { }

	// RVA: 0x17D8EA4
	public static float InOutBounce(float t) { }

	// RVA: 0x17D90E8
	public static float InElastic(float t) { }

	// RVA: 0x17D9174
	public static float OutElastic(float t) { }

	// RVA: 0x17D9204
	public static float InOutElastic(float t) { }

	// RVA: 0x17D9338
	public static float InBack(float t) { }

	// RVA: 0x17D9364
	public static float OutBack(float t) { }

	// RVA: 0x17D939C
	public static float InOutBack(float t) { }

	// RVA: 0x17D9424
	public static float InCirc(float t) { }

	// RVA: 0x17D9444
	public static float OutCirc(float t) { }

	// RVA: 0x17D9460
	public static float InOutCirc(float t) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerOverLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17D971C
	private static void .cctor() { }

	// RVA: 0x17D9788
	public void .ctor() { }

	// RVA: 0x17D9790
	internal PointerOverLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerOverLinkTagEvent
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x17D94A8
	private static void .cctor() { }

	// RVA: 0x17D9598
	private void set_linkID(string value) { }

	// RVA: 0x17D95A8
	private void set_linkText(string value) { }

	// RVA: 0x17D95B8
	protected override void Init() { }

	// RVA: 0x17D9618
	private void LocalInit() { }

	// RVA: 0x17D9624
	public static PointerOverLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x17D96BC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerMoveLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17D9A98
	private static void .cctor() { }

	// RVA: 0x17D9B04
	public void .ctor() { }

	// RVA: 0x17D9B0C
	internal PointerMoveLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerMoveLinkTagEvent
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x17D9824
	private static void .cctor() { }

	// RVA: 0x17D9914
	private void set_linkID(string value) { }

	// RVA: 0x17D9924
	private void set_linkText(string value) { }

	// RVA: 0x17D9934
	protected override void Init() { }

	// RVA: 0x17D9994
	private void LocalInit() { }

	// RVA: 0x17D99A0
	public static PointerMoveLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x17D9A38
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerOutLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17D9DB0
	private static void .cctor() { }

	// RVA: 0x17D9E1C
	public void .ctor() { }

	// RVA: 0x17D9E24
	internal PointerOutLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerOutLinkTagEvent
{
	// Methods

	// RVA: 0x17D9BA0
	private static void .cctor() { }

	// RVA: 0x17D9C90
	protected override void Init() { }

	// RVA: 0x17D9CF0
	private void LocalInit() { }

	// RVA: 0x17D9CFC
	public static PointerOutLinkTagEvent GetPooled(IPointerEvent evt, string linkID) { }

	// RVA: 0x17D9D50
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerDownLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17DA12C
	private static void .cctor() { }

	// RVA: 0x17DA198
	public void .ctor() { }

	// RVA: 0x17DA1A0
	internal PointerDownLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public sealed class PointerDownLinkTagEvent
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x17D9EB8
	private static void .cctor() { }

	// RVA: 0x17D9FA8
	private void set_linkID(string value) { }

	// RVA: 0x17D9FB8
	private void set_linkText(string value) { }

	// RVA: 0x17D9FC8
	protected override void Init() { }

	// RVA: 0x17DA028
	private void LocalInit() { }

	// RVA: 0x17DA034
	public static PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x17DA0CC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerUpLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17DA4A8
	private static void .cctor() { }

	// RVA: 0x17DA514
	public void .ctor() { }

	// RVA: 0x17DA51C
	internal PointerUpLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerUpLinkTagEvent
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x17DA234
	private static void .cctor() { }

	// RVA: 0x17DA324
	private void set_linkID(string value) { }

	// RVA: 0x17DA334
	private void set_linkText(string value) { }

	// RVA: 0x17DA344
	protected override void Init() { }

	// RVA: 0x17DA3A4
	private void LocalInit() { }

	// RVA: 0x17DA3B0
	public static PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x17DA448
	public void .ctor() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public struct StyleValues
{
	// Fields
	internal StyleValueCollection m_StyleValues; // 0x10

	// Methods

	// RVA: 0x17DA5B0
	public void set_top(float value) { }

	// RVA: 0x17DA6BC
	public void set_left(float value) { }

	// RVA: 0x17DA6C8
	public void set_width(float value) { }

	// RVA: 0x17DA6D4
	public void set_height(float value) { }

	// RVA: 0x17DA6E0
	public void set_right(float value) { }

	// RVA: 0x17DA6EC
	public void set_bottom(float value) { }

	// RVA: 0x17DA6F8
	public void set_color(Color value) { }

	// RVA: 0x17DA7F4
	public void set_backgroundColor(Color value) { }

	// RVA: 0x17DA7FC
	public void set_unityBackgroundImageTintColor(Color value) { }

	// RVA: 0x17DA808
	public void set_borderColor(Color value) { }

	// RVA: 0x17DA814
	public void set_marginLeft(float value) { }

	// RVA: 0x17DA820
	public void set_marginTop(float value) { }

	// RVA: 0x17DA82C
	public void set_marginRight(float value) { }

	// RVA: 0x17DA838
	public void set_marginBottom(float value) { }

	// RVA: 0x17DA844
	public void set_paddingLeft(float value) { }

	// RVA: 0x17DA850
	public float get_paddingTop() { }

	// RVA: 0x17DA97C
	public void set_paddingTop(float value) { }

	// RVA: 0x17DA988
	public void set_paddingRight(float value) { }

	// RVA: 0x17DA994
	public void set_paddingBottom(float value) { }

	// RVA: 0x17DA9A0
	public void set_borderLeftWidth(float value) { }

	// RVA: 0x17DA9AC
	public void set_borderRightWidth(float value) { }

	// RVA: 0x17DA9B8
	public void set_borderTopWidth(float value) { }

	// RVA: 0x17DA9C4
	public void set_borderBottomWidth(float value) { }

	// RVA: 0x17DA9D0
	public void set_borderTopLeftRadius(float value) { }

	// RVA: 0x17DA9DC
	public void set_borderTopRightRadius(float value) { }

	// RVA: 0x17DA9E8
	public void set_borderBottomLeftRadius(float value) { }

	// RVA: 0x17DA9F0
	public void set_borderBottomRightRadius(float value) { }

	// RVA: 0x17DA9FC
	public void set_opacity(float value) { }

	// RVA: 0x17DAA08
	public void set_flexGrow(float value) { }

	// RVA: 0x17DAA14
	public void set_flexShrink(float value) { }

	// RVA: 0x17DA5BC
	internal void SetValue(StylePropertyId id, float value) { }

	// RVA: 0x17DA700
	internal void SetValue(StylePropertyId id, Color value) { }

	// RVA: 0x17DA8F4
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

	// RVA: 0x17DAA20
	public static float Interpolate(float start, float end, float ratio) { }

	// RVA: 0x17DAA30
	public static Color Interpolate(Color start, Color end, float ratio) { }

	// RVA: 0x17DAA68
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x30D39B8
	public int get_durationMs() { }

	// RVA: 0x30D4A04
	public void set_durationMs(int value) { }

	// RVA: 0x30D3CF0
	public System.Func<System.Single,System.Single> get_easingCurve() { }

	// RVA: 0x30D4CD4
	public void set_easingCurve(System.Func<System.Single,System.Single> value) { }

	// RVA: 0x30D3738
	public bool get_isRunning() { }

	// RVA: 0x30D4918
	private void set_isRunning(bool value) { }

	// RVA: 0x30D3CF0
	public Action get_onAnimationCompleted() { }

	// RVA: 0x30D4CD4
	public void set_onAnimationCompleted(Action value) { }

	// RVA: 0x30D3738
	public bool get_autoRecycle() { }

	// RVA: 0x30D4918
	public void set_autoRecycle(bool value) { }

	// RVA: 0x30D3738
	private bool get_recycled() { }

	// RVA: 0x30D4918
	private void set_recycled(bool value) { }

	// RVA: 0x30D3CF0
	private VisualElement get_owner() { }

	// RVA: 0x30D4CD4
	private void set_owner(VisualElement value) { }

	// RVA: 0x30D3CF0
	public System.Action<UnityEngine.UIElements.VisualElement,T> get_valueUpdated() { }

	// RVA: 0x30D4CD4
	public void set_valueUpdated(System.Action<UnityEngine.UIElements.VisualElement,T> value) { }

	// RVA: 0x30D3CF0
	public System.Func<UnityEngine.UIElements.VisualElement,T> get_initialValue() { }

	// RVA: 0x30D4CD4
	public void set_initialValue(System.Func<UnityEngine.UIElements.VisualElement,T> value) { }

	// RVA: 0x30D3CF0
	public System.Func<T,T,System.Single,T> get_interpolator() { }

	// RVA: 0x30D4CD4
	public void set_interpolator(System.Func<T,T,System.Single,T> value) { }

	// RVA: 0x318DB98
	public T get_from() { }

	// RVA: 0x318DB98
	public void set_from(T value) { }

	// RVA: 0x318DB98
	public T get_to() { }

	// RVA: 0x318DB98
	public void set_to(T value) { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D488C
	public void Start() { }

	// RVA: 0x30D488C
	public void Stop() { }

	// RVA: 0x30D488C
	public void Recycle() { }

	// RVA: -1
	private void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(Int64 currentTimeMs) { }

	// RVA: 0x30D488C
	private void SetDefaultValues() { }

	// RVA: 0x30D488C
	private void Unregister() { }

	// RVA: 0x30D488C
	private void Register() { }

	// RVA: 0x30D4CD4
	internal void SetOwner(VisualElement e) { }

	// RVA: 0x30D488C
	private void CheckNotRecycled() { }

	// RVA: 0x30D78C4
	public static UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(VisualElement e, System.Func<T,T,System.Single,T> interpolator) { }

	// RVA: 0x30D3CF0
	public UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive() { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMovePreview
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x17DAF30
	public void .ctor() { }

	// RVA: 0x17DB010
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMoveLocationPreview
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x17DB0C0
	public void .ctor() { }

	// RVA: 0x17DB1F4
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

	// RVA: 0x17DB2E4
	public ColumnLayout get_columnLayout() { }

	// RVA: 0x17DB2EC
	public void set_columnLayout(ColumnLayout value) { }

	// RVA: 0x17DB2F4
	public bool get_active() { }

	// RVA: 0x17DB2FC
	public void set_active(bool value) { }

	// RVA: 0x17DB330
	public bool get_moving() { }

	// RVA: 0x17DB338
	public void set_moving(bool value) { }

	// RVA: 0x17DB36C
	public void add_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x17DB420
	public void remove_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x17DB4D4
	public void add_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x17DB588
	public void remove_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x17DB63C
	public void .ctor() { }

	// RVA: 0x17DB6B4
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x17DBBF4
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x17DC134
	protected void OnMouseDown(MouseDownEvent evt) { }

	// RVA: 0x17DC400
	protected void OnMouseMove(MouseMoveEvent evt) { }

	// RVA: 0x17DC59C
	protected void OnMouseUp(MouseUpEvent evt) { }

	// RVA: 0x17DC778
	private void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	// RVA: 0x17DC8F0
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x17DCA2C
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x17DCB58
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x17DCC98
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x17DCE08
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x17DCD98
	private static bool IsNotMouseEvent(int pointerId) { }

	// RVA: 0x17DC804
	protected void ProcessCancelEvent(EventBase evt, int pointerId) { }

	// RVA: 0x17DD04C
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x17DC1F8
	private void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x17DC474
	private void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	// RVA: 0x17DC650
	private void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x17DD0C8
	private void BeginDragMove(float pos) { }

	// RVA: 0x17DD558
	internal void DragMove(float pos) { }

	// RVA: 0x17DD8DC
	private void UpdatePreviewPosition() { }

	// RVA: 0x17DD560
	private void UpdateMoveLocation() { }

	// RVA: 0x17DCEF4
	private void EndDragMove(bool cancelled) { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnResizePreview
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x17DDB58
	public void .ctor() { }

	// RVA: 0x17DDC8C
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

	// RVA: 0x17DDD7C
	public ColumnLayout get_columnLayout() { }

	// RVA: 0x17DDD84
	public void set_columnLayout(ColumnLayout value) { }

	// RVA: 0x17DDD8C
	public bool get_preview() { }

	// RVA: 0x17DDD94
	public void set_preview(bool value) { }

	// RVA: 0x17DDD9C
	public void .ctor(Column column) { }

	// RVA: 0x17DDE38
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x17DE078
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x17DE2B8
	private void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x17DE3DC
	private void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x17DE6AC
	private void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x17DE858
	private void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x17DE654
	private void BeginDragResize(float pos) { }

	// RVA: 0x17DE808
	private void DragResize(float pos) { }

	// RVA: 0x17DE9DC
	private void UpdatePreviewPosition() { }

	// RVA: 0x17DE364
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

	// RVA: 0x17E3DF8
	internal void Save(MultiColumnCollectionHeader header) { }

	// RVA: 0x17E3A14
	internal void Apply(MultiColumnCollectionHeader header) { }

	// RVA: 0x17E4A30
	public void .ctor() { }

}

// Namespace: 
internal class ColumnData
{
	// Fields
	private MultiColumnHeaderColumn <control>k__BackingField; // 0x10
	private MultiColumnHeaderColumnResizeHandle <resizeHandle>k__BackingField; // 0x18

	// Methods

	// RVA: 0x17E4B10
	public MultiColumnHeaderColumn get_control() { }

	// RVA: 0x17E4B18
	public void set_control(MultiColumnHeaderColumn value) { }

	// RVA: 0x17E4B20
	public MultiColumnHeaderColumnResizeHandle get_resizeHandle() { }

	// RVA: 0x17E4B28
	public void set_resizeHandle(MultiColumnHeaderColumnResizeHandle value) { }

	// RVA: 0x17E1600
	public void .ctor() { }

}

// Namespace: 
private struct SortedColumnState
{
	// Fields
	public SortColumnDescription columnDesc; // 0x10
	public SortDirection direction; // 0x18

	// Methods

	// RVA: 0x17E0D48
	public void .ctor(SortColumnDescription desc, SortDirection dir) { }

}

// Namespace: 
private sealed class <>c__DisplayClass65_0
{
	// Fields
	public Column column; // 0x10
	public MultiColumnCollectionHeader <>4__this; // 0x18

	// Methods

	// RVA: 0x17E2D18
	public void .ctor() { }

	// RVA: 0x17E4B30
	internal void <OnContextualMenuManipulator>b__1(DropdownMenuAction a) { }

	// RVA: 0x17E4B5C
	internal Status <OnContextualMenuManipulator>b__2(DropdownMenuAction a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass71_0
{
	// Fields
	public Column column; // 0x10

	// Methods

	// RVA: 0x17E3730
	public void .ctor() { }

	// RVA: 0x17E4BF0
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

	// RVA: 0x17DEAEC
	internal bool get_isApplyingViewState() { }

	// RVA: 0x17DEAF4
	public System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ColumnData> get_columnDataMap() { }

	// RVA: 0x17DEAFC
	public ColumnLayout get_columnLayout() { }

	// RVA: 0x17DEB04
	public VisualElement get_columnContainer() { }

	// RVA: 0x17DEB0C
	public VisualElement get_resizeHandleContainer() { }

	// RVA: 0x17DEB14
	public System.Collections.Generic.IEnumerable<UnityEngine.UIElements.SortColumnDescription> get_sortedColumns() { }

	// RVA: 0x17DEB1C
	public SortColumnDescriptions get_sortDescriptions() { }

	// RVA: 0x17DEB24
	protected internal void set_sortDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x17DF35C
	public Columns get_columns() { }

	// RVA: 0x17DF364
	public bool get_sortingEnabled() { }

	// RVA: 0x17DF36C
	public void set_sortingEnabled(bool value) { }

	// RVA: 0x17DF9EC
	public void add_columnResized(System.Action<System.Int32,System.Single> value) { }

	// RVA: 0x17DFAA4
	public void remove_columnResized(System.Action<System.Int32,System.Single> value) { }

	// RVA: 0x17DFB5C
	public void add_columnSortingChanged(Action value) { }

	// RVA: 0x17DFC04
	public void remove_columnSortingChanged(Action value) { }

	// RVA: 0x17DFCAC
	public void add_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17DFD64
	public void remove_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x17DFE1C
	internal void add_viewDataRestored(Action value) { }

	// RVA: 0x17DFEC4
	internal void remove_viewDataRestored(Action value) { }

	// RVA: 0x17DFF6C
	public void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x17E0BE8
	private void ScheduleDoLayout() { }

	// RVA: 0x17E0D10
	private void ResizeToFit() { }

	// RVA: 0x17DEBDC
	private void UpdateSortedColumns() { }

	// RVA: 0x17E0E04
	private void UpdateColumnControls() { }

	// RVA: 0x17E15FC
	private void OnColumnAdded(Column column, int index) { }

	// RVA: 0x17E07B0
	private void OnColumnAdded(Column column) { }

	// RVA: 0x17E1608
	private void OnColumnRemoved(Column column) { }

	// RVA: 0x17E1920
	private void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x17E2244
	private void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x17E2408
	private void OnColumnResized(Column column) { }

	// RVA: 0x17E2450
	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x17E2D20
	private void OnMoveManipulatorActivated(ColumnMover mover) { }

	// RVA: 0x17E2E28
	private void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x17E2EC8
	private void DoLayout() { }

	// RVA: 0x17E2F0C
	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x17E327C
	private void OnColumnClicked(EventBase evt) { }

	// RVA: 0x17E34A8
	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) { }

	// RVA: 0x17E3738
	public void ScrollHorizontally(float horizontalOffset) { }

	// RVA: 0x17E3174
	private void RaiseColumnResized(int columnIndex) { }

	// RVA: 0x17E0DBC
	private void RaiseColumnSortingChanged() { }

	// RVA: 0x17E19C8
	private void ApplyColumnSorting() { }

	// RVA: 0x17DF3AC
	private void UpdateSortingStatus() { }

	// RVA: 0x17E3900
	internal override void OnViewDataReady() { }

	// RVA: 0x17E0D74
	private void SaveViewState() { }

	// RVA: 0x17E16F8
	private void CleanupColumnData(ColumnData data) { }

	// RVA: 0x17E4458
	public void Dispose() { }

	// RVA: 0x17E48B8
	private static void .cctor() { }

	// RVA: 0x17E49F8
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

	// RVA: 0x17E4C84
	public void set_sortOrderLabel(string value) { }

	// RVA: 0x17E4CAC
	public void .ctor() { }

	// RVA: 0x17E4E58
	private static void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnIcon
{
	// Fields
	public static readonly string ussClassName; // 0x0
	private bool <isImageInline>k__BackingField; // 0x40B

	// Methods

	// RVA: 0x17E4F90
	public bool get_isImageInline() { }

	// RVA: 0x17E4F98
	public void set_isImageInline(bool value) { }

	// RVA: 0x17E4FA0
	public void .ctor() { }

	// RVA: 0x17E50B4
	public void UpdateClassList() { }

	// RVA: 0x17E5258
	private static void .cctor() { }

	// RVA: 0x17E5308
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

	// RVA: 0x17E530C
	public Clickable get_clickable() { }

	// RVA: 0x17E5314
	private void set_clickable(Clickable value) { }

	// RVA: 0x17E5324
	public ColumnMover get_mover() { }

	// RVA: 0x17E532C
	private void set_mover(ColumnMover value) { }

	// RVA: 0x17E533C
	public void set_sortOrderLabel(string value) { }

	// RVA: 0x17E535C
	public Column get_column() { }

	// RVA: 0x17E5364
	private void set_column(Column value) { }

	// RVA: 0x17E5374
	public VisualElement get_content() { }

	// RVA: 0x17E537C
	public void set_content(VisualElement value) { }

	// RVA: 0x17E5640
	private bool get_isContentBound() { }

	// RVA: 0x17E5718
	private void set_isContentBound(bool value) { }

	// RVA: 0x17E57D8
	public void .ctor(Column column) { }

	// RVA: 0x17E64E0
	private void OnColumnChanged(Column c, ColumnDataType role) { }

	// RVA: 0x17E6714
	private void OnColumnResized(Column c) { }

	// RVA: 0x17E6300
	private void InitManipulators() { }

	// RVA: 0x17E6718
	private void OnMoverChanged(ColumnMover mv) { }

	// RVA: 0x17E66CC
	private void UpdateDataFromColumn() { }

	// RVA: 0x17E68A4
	private void BindHeaderContent() { }

	// RVA: 0x17E67BC
	private void UnbindHeaderContent() { }

	// RVA: 0x17E5478
	private void DestroyHeaderContent() { }

	// RVA: 0x17E698C
	private VisualElement CreateDefaultHeaderContent() { }

	// RVA: 0x17E6B20
	private void DefaultBindHeaderContent(VisualElement ve) { }

	// RVA: 0x17E5FDC
	private void UpdateHeaderTemplate() { }

	// RVA: 0x17E61F0
	private void UpdateGeometryFromColumn() { }

	// RVA: 0x17E6E9C
	public void Dispose() { }

	// RVA: 0x17E7044
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

	// RVA: 0x17E747C
	public VisualElement get_dragArea() { }

	// RVA: 0x17E7484
	public void .ctor() { }

	// RVA: 0x17E75B4
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


