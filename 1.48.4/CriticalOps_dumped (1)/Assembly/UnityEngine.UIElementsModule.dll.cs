// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine.Yoga
internal sealed class BaselineFunction 
{
	// Methods

	// RVA: 0x161CB88
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x161CCAC
	internal float Invoke(YogaNode node, float width, float height) { }

}

// Namespace: UnityEngine.Yoga
internal sealed class Logger 
{
	// Methods

	// RVA: 0x161CCC0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x161CDE4
	internal void Invoke(YogaConfig config, YogaNode node, YogaLogLevel level, string message) { }

}

// Namespace: UnityEngine.Yoga
internal sealed class MeasureFunction 
{
	// Methods

	// RVA: 0x161CDF8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x161CF1C
	internal YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

}

// Namespace: UnityEngine.Yoga
internal class MeasureOutput 
{
	// Methods

	// RVA: 0x161CF30
	YogaSize Make(float width, float height) { }

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

	// RVA: 0x161CF34
	void .ctor(IntPtr ygConfig) { }

	// RVA: 0x161CFBC
	void .ctor() { }

	// RVA: 0x161D058
	void Finalize() { }

	// RVA: 0x161D1A8
	IntPtr get_Handle() { }

	// RVA: 0x161D21C
	bool get_UseWebDefaults() { }

	// RVA: 0x161D2BC
	void set_UseWebDefaults(bool value) { }

	// RVA: 0x161D38C
	void set_PointScaleFactor(float value) { }

	// RVA: 0x161D45C
	void .cctor() { }

}

// Namespace: UnityEngine.Yoga
internal static class YogaConstants 
{
	// Methods

	// RVA: 0x161D534
	bool IsUndefined(float value) { }

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

	// RVA: 0x161D54C
	IntPtr YGNodeNewWithConfig(IntPtr config) { }

	// RVA: 0x161D59C
	void YGNodeFree(IntPtr ygNode) { }

	// RVA: 0x161D608
	void YGNodeFreeInternal(IntPtr ygNode) { }

	// RVA: 0x161D658
	void YGSetManagedObject(IntPtr ygNode, YogaNode node) { }

	// RVA: 0x161D6C0
	void YGNodeSetConfig(IntPtr ygNode, IntPtr config) { }

	// RVA: 0x161D4F4
	IntPtr YGConfigGetDefault() { }

	// RVA: 0x161D018
	IntPtr YGConfigNew() { }

	// RVA: 0x161D1B0
	void YGConfigFree(IntPtr config) { }

	// RVA: 0x161D728
	void YGConfigFreeInternal(IntPtr config) { }

	// RVA: 0x161D324
	void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults) { }

	// RVA: 0x161D26C
	bool YGConfigGetUseWebDefaults(IntPtr config) { }

	// RVA: 0x161D3F4
	void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint) { }

	// RVA: 0x161D778
	void YGNodeInsertChild(IntPtr node, IntPtr child, UInt32 index) { }

	// RVA: 0x161D7D0
	void YGNodeRemoveChild(IntPtr node, IntPtr child) { }

	// RVA: 0x161D838
	void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection) { }

	// RVA: 0x161D8A0
	void YGNodeMarkDirty(IntPtr node) { }

	// RVA: 0x161D8F0
	bool YGNodeIsDirty(IntPtr node) { }

	// RVA: 0x161D940
	void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode) { }

	// RVA: 0x161D9A8
	void YGNodeSetMeasureFunc(IntPtr node) { }

	// RVA: 0x161D9F8
	void YGNodeRemoveMeasureFunc(IntPtr node) { }

	// RVA: 0x161DA48
	void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress) { }

	// RVA: 0x161DB94
	void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress) { }

	// RVA: 0x161DCC0
	void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout) { }

	// RVA: 0x161DD28
	bool YGNodeGetHasNewLayout(IntPtr node) { }

	// RVA: 0x161DD78
	YogaDirection YGNodeStyleGetDirection(IntPtr node) { }

	// RVA: 0x161DDC8
	void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection) { }

	// RVA: 0x161DE30
	void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent) { }

	// RVA: 0x161DE98
	void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent) { }

	// RVA: 0x161DF00
	void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems) { }

	// RVA: 0x161DF68
	void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf) { }

	// RVA: 0x161DFD0
	void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType) { }

	// RVA: 0x161E038
	void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap) { }

	// RVA: 0x161E0A0
	void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap) { }

	// RVA: 0x161E108
	void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display) { }

	// RVA: 0x161E170
	void YGNodeStyleSetFlex(IntPtr node, float flex) { }

	// RVA: 0x161E1D8
	void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow) { }

	// RVA: 0x161E240
	void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink) { }

	// RVA: 0x161E2A8
	void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis) { }

	// RVA: 0x161E310
	void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis) { }

	// RVA: 0x161E378
	void YGNodeStyleSetFlexBasisAuto(IntPtr node) { }

	// RVA: 0x161E3C8
	void YGNodeStyleSetWidth(IntPtr node, float width) { }

	// RVA: 0x161E430
	void YGNodeStyleSetWidthPercent(IntPtr node, float width) { }

	// RVA: 0x161E498
	void YGNodeStyleSetWidthAuto(IntPtr node) { }

	// RVA: 0x161E4E8
	void YGNodeStyleSetHeight(IntPtr node, float height) { }

	// RVA: 0x161E550
	void YGNodeStyleSetHeightPercent(IntPtr node, float height) { }

	// RVA: 0x161E5B8
	void YGNodeStyleSetHeightAuto(IntPtr node) { }

	// RVA: 0x161E608
	void YGNodeStyleSetMinWidth(IntPtr node, float minWidth) { }

	// RVA: 0x161E670
	void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth) { }

	// RVA: 0x161E6D8
	void YGNodeStyleSetMinHeight(IntPtr node, float minHeight) { }

	// RVA: 0x161E740
	void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight) { }

	// RVA: 0x161E7A8
	void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth) { }

	// RVA: 0x161E810
	void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth) { }

	// RVA: 0x161E878
	void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight) { }

	// RVA: 0x161E8E0
	void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight) { }

	// RVA: 0x161E948
	void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position) { }

	// RVA: 0x161E9A8
	void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position) { }

	// RVA: 0x161EA08
	void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin) { }

	// RVA: 0x161EA68
	void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin) { }

	// RVA: 0x161EAC8
	void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge) { }

	// RVA: 0x161EB30
	void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding) { }

	// RVA: 0x161EB90
	void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding) { }

	// RVA: 0x161EBF0
	void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border) { }

	// RVA: 0x161EC50
	float YGNodeLayoutGetLeft(IntPtr node) { }

	// RVA: 0x161ECA0
	float YGNodeLayoutGetTop(IntPtr node) { }

	// RVA: 0x161ECF0
	float YGNodeLayoutGetRight(IntPtr node) { }

	// RVA: 0x161ED40
	float YGNodeLayoutGetBottom(IntPtr node) { }

	// RVA: 0x161ED90
	float YGNodeLayoutGetWidth(IntPtr node) { }

	// RVA: 0x161EDE0
	float YGNodeLayoutGetHeight(IntPtr node) { }

	// RVA: 0x161EE30
	float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge) { }

	// RVA: 0x161EE98
	float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge) { }

	// RVA: 0x161EF00
	float YGNodeLayoutGetBorder(IntPtr node, YogaEdge edge) { }

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

	// RVA: 0x161EF68
	void .ctor(YogaConfig config) { }

	// RVA: 0x161F0A8
	void Finalize() { }

	// RVA: 0x161F174
	void set_Config(YogaConfig value) { }

	// RVA: 0x161F258
	bool get_IsDirty() { }

	// RVA: 0x161F2A8
	void MarkDirty() { }

	// RVA: 0x161F2F8
	bool get_HasNewLayout() { }

	// RVA: 0x161F348
	bool get_IsMeasureDefined() { }

	// RVA: 0x161F358
	bool get_IsBaselineDefined() { }

	// RVA: 0x161F368
	void CopyStyle(YogaNode srcNode) { }

	// RVA: 0x161F3D8
	void set_FlexDirection(YogaFlexDirection value) { }

	// RVA: 0x161F440
	void set_JustifyContent(YogaJustify value) { }

	// RVA: 0x161F4A8
	void set_Display(YogaDisplay value) { }

	// RVA: 0x161F510
	void set_AlignItems(YogaAlign value) { }

	// RVA: 0x161F578
	void set_AlignSelf(YogaAlign value) { }

	// RVA: 0x161F5E0
	void set_AlignContent(YogaAlign value) { }

	// RVA: 0x161F648
	void set_PositionType(YogaPositionType value) { }

	// RVA: 0x161F6B0
	void set_Wrap(YogaWrap value) { }

	// RVA: 0x161F718
	void set_Flex(float value) { }

	// RVA: 0x161F780
	void set_FlexGrow(float value) { }

	// RVA: 0x161F7E8
	void set_FlexShrink(float value) { }

	// RVA: 0x161F850
	void set_FlexBasis(YogaValue value) { }

	// RVA: 0x161F964
	void set_Width(YogaValue value) { }

	// RVA: 0x161FA68
	void set_Height(YogaValue value) { }

	// RVA: 0x161FB6C
	void set_MaxWidth(YogaValue value) { }

	// RVA: 0x161FC18
	void set_MaxHeight(YogaValue value) { }

	// RVA: 0x161FCC4
	void set_MinWidth(YogaValue value) { }

	// RVA: 0x161FD70
	void set_MinHeight(YogaValue value) { }

	// RVA: 0x161FE1C
	float get_LayoutX() { }

	// RVA: 0x161FE6C
	float get_LayoutY() { }

	// RVA: 0x161FEBC
	float get_LayoutRight() { }

	// RVA: 0x161FF0C
	float get_LayoutBottom() { }

	// RVA: 0x161FF5C
	float get_LayoutWidth() { }

	// RVA: 0x161FFAC
	float get_LayoutHeight() { }

	// RVA: 0x161FFFC
	void set_Overflow(YogaOverflow value) { }

	// RVA: 0x1620064
	int get_Count() { }

	// RVA: 0x16200BC
	void MarkLayoutSeen() { }

	// RVA: 0x1620114
	void Insert(int index, YogaNode node) { }

	// RVA: 0x162025C
	void RemoveAt(int index) { }

	// RVA: 0x1620344
	void Clear() { }

	// RVA: 0x16203AC
	void SetMeasureFunction(MeasureFunction measureFunction) { }

	// RVA: 0x16204D0
	void CalculateLayout(float width, float height) { }

	// RVA: 0x161DB10
	YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x161DC44
	float BaselineInternal(YogaNode node, float width, float height) { }

	// RVA: 0x162057C
	System.Collections.Generic.IEnumerator<UnityEngine.Yoga.YogaNode> GetEnumerator() { }

	// RVA: 0x162070C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x162089C
	void set_Left(YogaValue value) { }

	// RVA: 0x16209A8
	void set_Top(YogaValue value) { }

	// RVA: 0x1620A2C
	void set_Right(YogaValue value) { }

	// RVA: 0x1620AB0
	void set_Bottom(YogaValue value) { }

	// RVA: 0x1620920
	void SetStylePosition(YogaEdge edge, YogaValue value) { }

	// RVA: 0x1620B34
	void set_MarginLeft(YogaValue value) { }

	// RVA: 0x1620CF4
	void set_MarginTop(YogaValue value) { }

	// RVA: 0x1620DD8
	void set_MarginRight(YogaValue value) { }

	// RVA: 0x1620EBC
	void set_MarginBottom(YogaValue value) { }

	// RVA: 0x1620C18
	void SetStyleMargin(YogaEdge edge, YogaValue value) { }

	// RVA: 0x1620FA0
	void set_PaddingLeft(YogaValue value) { }

	// RVA: 0x16210AC
	void set_PaddingTop(YogaValue value) { }

	// RVA: 0x1621130
	void set_PaddingRight(YogaValue value) { }

	// RVA: 0x16211B4
	void set_PaddingBottom(YogaValue value) { }

	// RVA: 0x1621024
	void SetStylePadding(YogaEdge edge, YogaValue value) { }

	// RVA: 0x1621238
	void set_BorderLeftWidth(float value) { }

	// RVA: 0x162128C
	void set_BorderTopWidth(float value) { }

	// RVA: 0x16212E0
	void set_BorderRightWidth(float value) { }

	// RVA: 0x1621334
	void set_BorderBottomWidth(float value) { }

	// RVA: 0x1621388
	float get_LayoutMarginLeft() { }

	// RVA: 0x16213E0
	float get_LayoutMarginTop() { }

	// RVA: 0x1621438
	float get_LayoutMarginRight() { }

	// RVA: 0x1621490
	float get_LayoutMarginBottom() { }

	// RVA: 0x16214E8
	float get_LayoutPaddingLeft() { }

	// RVA: 0x1621540
	float get_LayoutPaddingTop() { }

	// RVA: 0x1621598
	float get_LayoutPaddingRight() { }

	// RVA: 0x16215F0
	float get_LayoutPaddingBottom() { }

	// RVA: 0x1621648
	float get_LayoutBorderLeft() { }

	// RVA: 0x16216A0
	float get_LayoutBorderTop() { }

	// RVA: 0x16216F8
	float get_LayoutBorderRight() { }

	// RVA: 0x1621750
	float get_LayoutBorderBottom() { }

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

	// RVA: 0x161F954
	YogaUnit get_Unit() { }

	// RVA: 0x161F95C
	float get_Value() { }

	// RVA: 0x16217A8
	YogaValue Point(float value) { }

	// RVA: 0x16217C8
	bool Equals(YogaValue other) { }

	// RVA: 0x162184C
	bool Equals(object obj) { }

	// RVA: 0x162192C
	int GetHashCode() { }

	// RVA: 0x1621974
	YogaValue Auto() { }

	// RVA: 0x1621980
	YogaValue Percent(float value) { }

	// RVA: 0x16219A0
	YogaValue op_Implicit(float pointValue) { }

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

	// RVA: 0x16219C0
	float RoundToPixelGrid(float v, float pixelsPerPoint, float offset) { }

	// RVA: 0x16219DC
	float CeilToPixelGrid(float v, float pixelsPerPoint, float offset) { }

	// RVA: 0x16219F0
	float RoundToPanelPixelSize(VisualElement ve, float v) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class AtlasBase 
{
	// Fields
	internal TextureRegistry textureRegistry; // 0x10

	// Methods

	// RVA: 0x1621A40
	bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

	// RVA: 0x1621AB8
	void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) { }

	// RVA: 0x1621ABC
	void Reset() { }

	// RVA: 0x1621AC0
	void OnAssignedToPanel(IPanel panel) { }

	// RVA: 0x1621AC4
	void OnRemovedFromPanel(IPanel panel) { }

	// RVA: 0x1621AC8
	void OnUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x1621ACC
	void InvokeAssignedToPanel(IPanel panel) { }

	// RVA: 0x1621AD8
	void InvokeRemovedFromPanel(IPanel panel) { }

	// RVA: 0x1621AE4
	void InvokeUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x1621AF0
	void RepaintTexturedElements(IPanel panel) { }

	// RVA: 0x1621BD4
	void SetDynamicTexture(TextureId id, Texture texture) { }

	// RVA: 0x1621BF8
	void .ctor() { }

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

	// RVA: 0x1621CCC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1621D88
	internal bool Invoke(Texture2D texture, ref DynamicAtlasFilters filtersToApply) { }

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

	// RVA: 0x1622A9C
	TextureInfo Create() { }

	// RVA: 0x1622B7C
	void Reset(TextureInfo info) { }

	// RVA: 0x1622B28
	void .ctor() { }

	// RVA: 0x1622BC0
	void .cctor() { }

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

	// RVA: 0x1621D9C
	bool get_isInitialized() { }

	// RVA: 0x1621DBC
	void OnAssignedToPanel(IPanel panel) { }

	// RVA: 0x1621E50
	void OnRemovedFromPanel(IPanel panel) { }

	// RVA: 0x1621F94
	void Reset() { }

	// RVA: 0x1622054
	void InitPages() { }

	// RVA: 0x1621EF8
	void DestroyPages() { }

	// RVA: 0x162216C
	bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

	// RVA: 0x162251C
	void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) { }

	// RVA: 0x1622668
	void OnUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x16226F0
	bool IsTextureFormatSupported(TextureFormat format) { }

	// RVA: 0x1622724
	bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode) { }

	// RVA: 0x16228C0
	void set_minAtlasSize(int value) { }

	// RVA: 0x16228E0
	void set_maxAtlasSize(int value) { }

	// RVA: 0x1622900
	DynamicAtlasFilters get_defaultFilters() { }

	// RVA: 0x1622908
	void set_activeFilters(DynamicAtlasFilters value) { }

	// RVA: 0x16228B8
	int get_maxSubTextureSize() { }

	// RVA: 0x1622928
	void set_maxSubTextureSize(int value) { }

	// RVA: 0x1622948
	void set_customFilter(DynamicAtlasCustomFilter value) { }

	// RVA: 0x16229B0
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public struct BackgroundPosition 
{
	// Fields
	public BackgroundPositionKeyword keyword; // 0x10
	public Length offset; // 0x14

	// Methods

	// RVA: 0x1622D00
	void .ctor(BackgroundPositionKeyword keyword) { }

	// RVA: 0x1622D44
	void .ctor(BackgroundPositionKeyword keyword, Length offset) { }

	// RVA: 0x1622D50
	BackgroundPosition Initial() { }

	// RVA: 0x1622DD0
	bool Equals(object obj) { }

	// RVA: 0x1622EA4
	bool Equals(BackgroundPosition other) { }

	// RVA: 0x1622EF4
	int GetHashCode() { }

	// RVA: 0x1622F40
	bool op_Equality(BackgroundPosition style1, BackgroundPosition style2) { }

	// RVA: 0x1622F90
	bool op_Inequality(BackgroundPosition style1, BackgroundPosition style2) { }

	// RVA: 0x1622FE4
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public static class BackgroundPropertyHelper 
{
	// Methods

	// RVA: 0x1622D90
	BackgroundPosition ConvertScaleModeToBackgroundPosition(ScaleMode scaleMode) { }

	// RVA: 0x16230A8
	BackgroundRepeat ConvertScaleModeToBackgroundRepeat(ScaleMode scaleMode) { }

	// RVA: 0x16230B8
	BackgroundSize ConvertScaleModeToBackgroundSize(ScaleMode scaleMode) { }

	// RVA: 0x1623208
	ScaleMode ResolveUnityBackgroundScaleMode(BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize, out bool valid) { }

}

// Namespace: UnityEngine.UIElements
public struct BackgroundRepeat 
{
	// Fields
	public Repeat x; // 0x10
	public Repeat y; // 0x14

	// Methods

	// RVA: 0x16230B0
	void .ctor(Repeat repeatX, Repeat repeatY) { }

	// RVA: 0x1623668
	BackgroundRepeat Initial() { }

	// RVA: 0x1623670
	bool Equals(object obj) { }

	// RVA: 0x1623710
	bool Equals(BackgroundRepeat other) { }

	// RVA: 0x1623738
	int GetHashCode() { }

	// RVA: 0x16235FC
	bool op_Equality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	// RVA: 0x1623784
	bool op_Inequality(BackgroundRepeat style1, BackgroundRepeat style2) { }

	// RVA: 0x1623790
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct BackgroundSize 
{
	// Fields
	private BackgroundSizeType m_SizeType; // 0x10
	private Length m_X; // 0x14
	private Length m_Y; // 0x1C

	// Methods

	// RVA: 0x1623838
	BackgroundSizeType get_sizeType() { }

	// RVA: 0x1623840
	void set_sizeType(BackgroundSizeType value) { }

	// RVA: 0x16238A0
	Length get_x() { }

	// RVA: 0x16238A8
	void set_x(Length value) { }

	// RVA: 0x16238B4
	Length get_y() { }

	// RVA: 0x16238BC
	void set_y(Length value) { }

	// RVA: 0x16231F8
	void .ctor(Length sizeX, Length sizeY) { }

	// RVA: 0x1623198
	void .ctor(BackgroundSizeType sizeType) { }

	// RVA: 0x16238C8
	BackgroundSize Initial() { }

	// RVA: 0x162391C
	bool Equals(object obj) { }

	// RVA: 0x16239F0
	bool Equals(BackgroundSize other) { }

	// RVA: 0x1623A48
	int GetHashCode() { }

	// RVA: 0x1623608
	bool op_Equality(BackgroundSize style1, BackgroundSize style2) { }

	// RVA: 0x1623AB0
	bool op_Inequality(BackgroundSize style1, BackgroundSize style2) { }

	// RVA: 0x1623B28
	string ToString() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1623CA8
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_PropertyPath; // 0x70

	// Methods

	// RVA: 0x1623CFC
	void .ctor() { }

	// RVA: 0x1623DA0
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
public class BindableElement 
{
	// Fields
	private IBinding <binding>k__BackingField; // 0x3C8
	private string <bindingPath>k__BackingField; // 0x3D0

	// Methods

	// RVA: 0x1623C08
	IBinding get_binding() { }

	// RVA: 0x1623C10
	void set_bindingPath(string value) { }

	// RVA: 0x1623C20
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal interface IBindingRequest 
{
	// Methods

	// RVA: 0x2FE4574
	void Bind(VisualElement element) { }

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

	// RVA: 0x1623EFC
	ProfilerMarker get_profilerMarker() { }

	// RVA: 0x1623F78
	bool get_disableBindingsThrottling() { }

	// RVA: 0x1623FF4
	IBinding GetBindingObjectFromElement(VisualElement ve) { }

	// RVA: 0x1624280
	void StartTracking(VisualElement ve) { }

	// RVA: 0x162430C
	void StopTracking(VisualElement ve) { }

	// RVA: 0x1624398
	System.Collections.Generic.Dictionary<System.Object,System.Object> get_temporaryObjectCache() { }

	// RVA: 0x16241DC
	IBinding GetAdditionalBinding(VisualElement ve) { }

	// RVA: 0x16243A0
	void StartTrackingRecursive(VisualElement ve) { }

	// RVA: 0x1624510
	void StopTrackingRecursive(VisualElement ve) { }

	// RVA: 0x162468C
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x1624824
	void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	// RVA: 0x162483C
	Int64 CurrentTime() { }

	// RVA: 0x16248AC
	void PerformTrackingOperations() { }

	// RVA: 0x1624C2C
	void Update() { }

	// RVA: 0x1625380
	void UpdateBindings() { }

	// RVA: 0x1625B5C
	void .ctor() { }

	// RVA: 0x1625D00
	void .cctor() { }

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

	// RVA: 0x2FE4574
	void add_dragging(Action value) { }

	// RVA: 0x2FE4574
	void remove_dragging(Action value) { }

	// RVA: 0x2FE4574
	void add_draggingEnded(Action value) { }

	// RVA: 0x2FE4574
	void remove_draggingEnded(Action value) { }

	// RVA: 0x309AF8C
	DragDirection get_dragDirection() { }

	// RVA: 0x309AF8C
	void set_dragDirection(DragDirection value) { }

	// RVA: 0x2FE4574
	void set_slider(UnityEngine.UIElements.BaseSlider<T> value) { }

	// RVA: -1
	Vector2 get_startMousePosition() { }

	// RVA: -1
	void set_startMousePosition(Vector2 value) { }

	// RVA: -1
	Vector2 get_delta() { }

	// RVA: 0x2FE49A8
	void .ctor(UnityEngine.UIElements.BaseSlider<T> slider, Action clickHandler, Action dragHandler) { }

	// RVA: -1
	void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: -1
	void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: -1
	void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

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

	// RVA: 0x1625EAC
	void add_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value) { }

	// RVA: 0x1625F60
	void remove_clickedWithEventInfo(System.Action<UnityEngine.UIElements.EventBase> value) { }

	// RVA: 0x1626014
	void add_clicked(Action value) { }

	// RVA: 0x16260B8
	void remove_clicked(Action value) { }

	// RVA: 0x162615C
	bool get_active() { }

	// RVA: 0x1626164
	void set_active(bool value) { }

	// RVA: 0x162616C
	Vector2 get_lastMousePosition() { }

	// RVA: 0x1626174
	void set_lastMousePosition(Vector2 value) { }

	// RVA: 0x162617C
	bool get_acceptClicksIfDisabled() { }

	// RVA: 0x1626184
	void set_acceptClicksIfDisabled(bool value) { }

	// RVA: 0x16261D8
	InvokePolicy get_invokePolicy() { }

	// RVA: 0x16261E0
	void .ctor(Action handler, Int64 delay, Int64 interval) { }

	// RVA: 0x162633C
	void .ctor(System.Action<UnityEngine.UIElements.EventBase> handler) { }

	// RVA: 0x1626298
	void .ctor(Action handler) { }

	// RVA: 0x16263D8
	void OnTimer(TimerState timerState) { }

	// RVA: 0x16264F0
	bool IsRepeatable() { }

	// RVA: 0x16265F4
	void RegisterCallbacksOnTarget() { }

	// RVA: 0x1626AD8
	void UnregisterCallbacksFromTarget() { }

	// RVA: 0x1626F98
	void OnMouseDown(MouseDownEvent evt) { }

	// RVA: 0x1627064
	void OnMouseMove(MouseMoveEvent evt) { }

	// RVA: 0x16270E0
	void OnMouseUp(MouseUpEvent evt) { }

	// RVA: 0x16271B4
	void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	// RVA: 0x1627248
	void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x162738C
	void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x16274C0
	void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x162760C
	void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x1627784
	void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x1626514
	bool ContainsPointer(int pointerId) { }

	// RVA: 0x1627714
	bool IsNotMouseEvent(int pointerId) { }

	// RVA: 0x1626598
	void Invoke(EventBase evt) { }

	// RVA: 0x1627878
	void SimulateSingleClick(EventBase evt, int delayMs) { }

	// RVA: 0x1627AB4
	void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x1627EC8
	void ProcessMoveEvent(EventBase evt, Vector2 localPosition) { }

	// RVA: 0x1627F5C
	void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x1628148
	void ProcessCancelEvent(EventBase evt, int pointerId) { }

	// RVA: 0x16282C8
	void <SimulateSingleClick>b__43_0() { }

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

	// RVA: 0x16289B0
	void Reset() { }

	// RVA: 0x1628694
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ClickDetector 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.ClickDetector.ButtonClickStatus> m_ClickStatus; // 0x10
	private static int <s_DoubleClickTime>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1628308
	int get_s_DoubleClickTime() { }

	// RVA: 0x1628384
	void set_s_DoubleClickTime(int value) { }

	// RVA: 0x1628410
	void .ctor() { }

	// RVA: 0x162869C
	void StartClickTracking(EventBase evt) { }

	// RVA: 0x1628A28
	void SendClickEvent(EventBase evt) { }

	// RVA: 0x1628F54
	void CancelClickTracking(EventBase evt) { }

	// RVA: 0x16290C0
	void ProcessEvent(EventBase evt) { }

	// RVA: 0x1628E0C
	bool ContainsPointer(VisualElement element, Vector2 position) { }

	// RVA: 0x16296C0
	void Cleanup(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x16299F4
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseListViewController 
{
	// Fields
	private Action itemsSourceSizeChanged; // 0x30
	private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsAdded; // 0x38
	private System.Action<System.Collections.Generic.IEnumerable<System.Int32>> itemsRemoved; // 0x40

	// Methods

	// RVA: 0x1629A44
	void add_itemsSourceSizeChanged(Action value) { }

	// RVA: 0x1629AE8
	void remove_itemsSourceSizeChanged(Action value) { }

	// RVA: 0x1629B8C
	void add_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x1629C40
	void remove_itemsAdded(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x1629CF4
	void add_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x1629DA8
	void remove_itemsRemoved(System.Action<System.Collections.Generic.IEnumerable<System.Int32>> value) { }

	// RVA: 0x1629E5C
	BaseListView get_baseListView() { }

	// RVA: 0x1629EE4
	void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x162A14C
	void PostInitRegistration(ReusableListViewItem listItem) { }

	// RVA: 0x162A5E4
	void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x162A9A8
	bool NeedsDragHandle(int index) { }

	// RVA: 0x162A9B0
	void AddItems(int itemCount) { }

	// RVA: 0x162B374
	void Move(int index, int newIndex) { }

	// RVA: 0x162B7B8
	void RemoveItem(int index) { }

	// RVA: 0x162B910
	void RemoveItems(System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x162BE20
	void RemoveItems(int itemCount) { }

	// RVA: 0x162BFE8
	void ClearItems() { }

	// RVA: 0x162B358
	void RaiseOnSizeChanged() { }

	// RVA: 0x162B33C
	void RaiseItemsAdded(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x162BBAC
	void RaiseItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x162B210
	Array AddToArray(Array source, int itemCount) { }

	// RVA: 0x162BBC8
	Array RemoveFromArray(Array source, System.Collections.Generic.List<System.Int32> indicesToRemove) { }

	// RVA: 0x162B504
	void Swap(int lhs, int rhs) { }

	// RVA: 0x162B098
	void EnsureItemSourceCanBeResized() { }

	// RVA: 0x162C1B8
	void .ctor() { }

	// RVA: 0x162C1C8
	bool <AddItems>g__IsGenericList|15_0(Type t) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0 
{
	// Fields
	public BaseTreeViewController <>4__this; // 0x10
	public ReusableTreeViewItem treeItem; // 0x18

	// Methods

	// RVA: 0x162D608
	void .ctor() { }

	// RVA: 0x1630CA8
	void <PostInitRegistration>b__0() { }

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

	// RVA: 0x162C290
	BaseTreeView get_baseTreeView() { }

	// RVA: 0x162C318
	IList get_itemsSource() { }

	// RVA: 0x162C320
	void set_itemsSource(IList value) { }

	// RVA: 0x162C374
	void RebuildTree() { }

	// RVA: 0x162C8D8
	System.Collections.Generic.IEnumerable<System.Int32> GetRootItemIds() { }

	// RVA: 0x2FE36BC
	System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

	// RVA: -1
	int GetParentId(int id) { }

	// RVA: -1
	System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	void Move(int id, int newParentId, int childIndex, bool rebuildTree) { }

	// RVA: 0x162C8E0
	void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x162CD8C
	void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x162D250
	void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x162C9A0
	void PostInitRegistration(ReusableTreeViewItem treeItem) { }

	// RVA: 0x162D778
	void OnItemPointerUp(PointerUpEvent evt) { }

	// RVA: 0x162E0B4
	void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

	// RVA: 0x162F72C
	int GetIndexForId(int id) { }

	// RVA: 0x162F82C
	int GetIdForIndex(int index) { }

	// RVA: 0x162F990
	bool HasChildren(int id) { }

	// RVA: 0x162FA1C
	bool Exists(int id) { }

	// RVA: 0x162D150
	bool HasChildrenByIndex(int index) { }

	// RVA: 0x162DFC8
	System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIdsByIndex(int index) { }

	// RVA: 0x162FA90
	int GetChildIndexForId(int id) { }

	// RVA: 0x162FDFC
	int GetIndentationDepth(int id) { }

	// RVA: 0x162CF9C
	int GetIndentationDepthByIndex(int index) { }

	// RVA: 0x162FE74
	bool CanChangeExpandedState(int id) { }

	// RVA: 0x162FE7C
	bool IsExpanded(int id) { }

	// RVA: 0x162D03C
	bool IsExpandedByIndex(int index) { }

	// RVA: 0x162E9B4
	void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh) { }

	// RVA: 0x16304FC
	void ExpandItem(int id, bool expandAllChildren, bool refresh) { }

	// RVA: 0x162E264
	void CollapseItemByIndex(int index, bool collapseAllChildren) { }

	// RVA: 0x16307B4
	void CollapseItem(int id, bool collapseAllChildren) { }

	// RVA: 0x162C7D8
	void RegenerateWrappers() { }

	// RVA: 0x162FF64
	void CreateWrappers(System.Collections.Generic.IEnumerable<System.Int32> treeViewItemIds, int depth, ref System.Collections.Generic.List<UnityEngine.UIElements.TreeViewItemWrapper>& wrappers) { }

	// RVA: 0x162F918
	bool IsIndexValid(int index) { }

	// RVA: 0x16309EC
	void RaiseItemParentChanged(int id, int newParentId) { }

	// RVA: 0x1630A2C
	void .ctor() { }

	// RVA: 0x1630BD8
	void .cctor() { }

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

	// RVA: 0x1630CD8
	void add_itemsSourceChanged(Action value) { }

	// RVA: 0x1630D7C
	void remove_itemsSourceChanged(Action value) { }

	// RVA: 0x1630E20
	void add_itemIndexChanged(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x1630ED4
	void remove_itemIndexChanged(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x1630F88
	IList get_itemsSource() { }

	// RVA: 0x1630F90
	void set_itemsSource(IList value) { }

	// RVA: 0x16309E4
	void SetItemsSourceWithoutNotify(IList source) { }

	// RVA: 0x1631080
	BaseVerticalCollectionView get_view() { }

	// RVA: 0x1631088
	void SetView(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x163114C
	void PrepareView() { }

	// RVA: 0x1631150
	void Dispose() { }

	// RVA: 0x1631194
	int GetItemsCount() { }

	// RVA: 0x1631258
	int GetItemsMinCount() { }

	// RVA: 0x1631264
	int GetIndexForId(int id) { }

	// RVA: 0x163126C
	int GetIdForIndex(int index) { }

	// RVA: 0x1631274
	object GetItemForIndex(int index) { }

	// RVA: 0x16313D0
	void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x162A8C0
	void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x1631414
	void InvokeUnbindItem(ReusableCollectionItem reusableItem, int index) { }

	// RVA: 0x162D5E0
	void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x2FE360C
	VisualElement MakeItem() { }

	// RVA: 0x2FE45DC
	void BindItem(VisualElement element, int index) { }

	// RVA: 0x2FE45DC
	void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x2FE4574
	void DestroyItem(VisualElement element) { }

	// RVA: 0x1631064
	void RaiseItemsSourceChanged() { }

	// RVA: 0x162B778
	void RaiseItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x162C1C0
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultMultiColumnTreeViewController<T0> 
{
	// Fields
	private UnityEngine.UIElements.TreeDataController<T> m_TreeDataController; // 0x0

	// Methods

	// RVA: 0x2FE360C
	UnityEngine.UIElements.TreeDataController<T> get_treeDataController() { }

	// RVA: 0x2FE49A8
	void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x2FE360C
	IList get_itemsSource() { }

	// RVA: 0x2FE4574
	void set_itemsSource(IList value) { }

	// RVA: 0x2FE4574
	void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items) { }

	// RVA: -1
	object GetItemForIndex(int index) { }

	// RVA: -1
	int GetParentId(int id) { }

	// RVA: 0x2FE3088
	bool HasChildren(int id) { }

	// RVA: -1
	System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	void Move(int id, int newParentId, int childIndex, bool rebuildTree) { }

	// RVA: -1
	bool IsChildOf(int childId, int id) { }

	// RVA: 0x2FE36BC
	System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultTreeViewController<T0> 
{
	// Fields
	private UnityEngine.UIElements.TreeDataController<T> m_TreeDataController; // 0x0

	// Methods

	// RVA: 0x2FE360C
	UnityEngine.UIElements.TreeDataController<T> get_treeDataController() { }

	// RVA: 0x2FE360C
	IList get_itemsSource() { }

	// RVA: 0x2FE4574
	void set_itemsSource(IList value) { }

	// RVA: 0x2FE4574
	void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> items) { }

	// RVA: -1
	object GetItemForIndex(int index) { }

	// RVA: -1
	int GetParentId(int id) { }

	// RVA: 0x2FE3088
	bool HasChildren(int id) { }

	// RVA: -1
	System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	void Move(int id, int newParentId, int childIndex, bool rebuildTree) { }

	// RVA: -1
	bool IsChildOf(int childId, int id) { }

	// RVA: 0x2FE36BC
	System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ListViewController 
{
	// Methods

	// RVA: 0x1631454
	ListView get_listView() { }

	// RVA: 0x16314DC
	VisualElement MakeItem() { }

	// RVA: 0x163163C
	void BindItem(VisualElement element, int index) { }

	// RVA: 0x16318A8
	void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x1631960
	void DestroyItem(VisualElement element) { }

	// RVA: 0x1631A10
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class MultiColumnListViewController 
{
	// Fields
	private MultiColumnController m_ColumnController; // 0x48

	// Methods

	// RVA: 0x1631A18
	MultiColumnController get_columnController() { }

	// RVA: 0x1631A20
	MultiColumnCollectionHeader get_header() { }

	// RVA: 0x1631A38
	void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x1631AD0
	void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1632000
	VisualElement MakeItem() { }

	// RVA: 0x1632020
	void BindItem(VisualElement element, int index) { }

	// RVA: 0x16320AC
	void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x16320CC
	void DestroyItem(VisualElement element) { }

	// RVA: 0x16320EC
	void PrepareView() { }

	// RVA: 0x1632310
	void Dispose() { }

	// RVA: 0x1632574
	void UpdateReorderClassList() { }

}

// Namespace: UnityEngine.UIElements
public abstract class MultiColumnTreeViewController 
{
	// Fields
	private MultiColumnController m_ColumnController; // 0x58

	// Methods

	// RVA: 0x16326F0
	MultiColumnController get_columnController() { }

	// RVA: 0x16326F8
	MultiColumnCollectionHeader get_header() { }

	// RVA: 0x1632710
	void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x16327C8
	void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	// RVA: 0x1632D08
	VisualElement MakeItem() { }

	// RVA: 0x1632D28
	void BindItem(VisualElement element, int index) { }

	// RVA: 0x1632DB4
	void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x1632DD4
	void DestroyItem(VisualElement element) { }

	// RVA: 0x1632DF4
	void PrepareView() { }

	// RVA: 0x1632E1C
	void Dispose() { }

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

	// RVA: 0x2FE42A4
	void .ctor(int <>1__state) { }

	// RVA: 0x2FE41A8
	void System.IDisposable.Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE32D4
	int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x2FE42A4
	void .ctor(int <>1__state) { }

	// RVA: 0x2FE41A8
	void System.IDisposable.Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void <>m__Finally1() { }

	// RVA: 0x2FE32D4
	int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<System.Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class TreeDataController<T0> 
{
	// Fields
	private UnityEngine.UIElements.TreeData<T> m_TreeData; // 0x0
	private System.Collections.Generic.Stack<System.Collections.Generic.IEnumerator<System.Int32>> m_IteratorStack; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void SetRootItems(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }

	// RVA: 0x309AF8C
	T GetDataForId(int id) { }

	// RVA: -1
	int GetParentId(int id) { }

	// RVA: 0x2FE3088
	bool HasChildren(int id) { }

	// RVA: 0x2FE7084
	System.Collections.Generic.IEnumerable<System.Int32> GetItemIds(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items) { }

	// RVA: -1
	System.Collections.Generic.IEnumerable<System.Int32> GetChildrenIds(int id) { }

	// RVA: -1
	void Move(int id, int newParentId, int childIndex) { }

	// RVA: -1
	bool IsChildOf(int childId, int id) { }

	// RVA: 0x2FE36BC
	System.Collections.Generic.IEnumerable<System.Int32> GetAllItemIds(System.Collections.Generic.IEnumerable<System.Int32> rootIds) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class TreeViewController 
{
	// Methods

	// RVA: 0x1632E8C
	TreeView get_treeView() { }

	// RVA: 0x1632F14
	VisualElement MakeItem() { }

	// RVA: 0x1633074
	void BindItem(VisualElement element, int index) { }

	// RVA: 0x1633264
	void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x163331C
	void DestroyItem(VisualElement element) { }

	// RVA: 0x16333CC
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class CollectionVirtualizationController 
{
	// Fields
	protected readonly ScrollView m_ScrollView; // 0x10

	// Methods

	// RVA: 0x2FE32D4
	int get_firstVisibleIndex() { }

	// RVA: 0x2FE42A4
	void set_firstVisibleIndex(int value) { }

	// RVA: 0x2FE32D4
	int get_visibleItemCount() { }

	// RVA: 0x163344C
	void .ctor(ScrollView scrollView) { }

	// RVA: 0x2FE4234
	void Refresh(bool rebuild) { }

	// RVA: 0x2FE42A4
	void ScrollToItem(int id) { }

	// RVA: -1
	void Resize(Vector2 size) { }

	// RVA: -1
	void OnScroll(Vector2 offset) { }

	// RVA: -1
	int GetIndexFromPosition(Vector2 position) { }

	// RVA: -1
	float GetExpectedItemHeight(int index) { }

	// RVA: -1
	float GetExpectedContentHeight() { }

	// RVA: 0x2FE4574
	void OnFocus(VisualElement leafTarget) { }

	// RVA: 0x2FE4574
	void OnBlur(VisualElement willFocus) { }

	// RVA: 0x2FE41A8
	void UpdateBackground() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }

	// RVA: 0x2FE4574
	void StartDragItem(ReusableCollectionItem item) { }

	// RVA: 0x2FE42A4
	void EndDrag(int dropIndex) { }

}

// Namespace: 
private struct ContentHeightCacheInfo 
{
	// Fields
	public readonly float sum; // 0x0
	public readonly int count; // 0x0

	// Methods

	// RVA: -1
	void .ctor(float sum, int count) { }

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
	float get_defaultExpectedHeight() { }

	// RVA: -1
	float get_contentPadding() { }

	// RVA: -1
	void set_contentPadding(float value) { }

	// RVA: -1
	float get_contentHeight() { }

	// RVA: -1
	void set_contentHeight(float value) { }

	// RVA: 0x2FE32D4
	int get_anchoredIndex() { }

	// RVA: 0x2FE42A4
	void set_anchoredIndex(int value) { }

	// RVA: -1
	float get_anchorOffset() { }

	// RVA: -1
	void set_anchorOffset(float value) { }

	// RVA: -1
	float get_viewportMaxOffset() { }

	// RVA: 0x2FE3054
	bool get_alwaysRebindOnRefresh() { }

	// RVA: 0x2FE4574
	void .ctor(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x2FE4234
	void Refresh(bool rebuild) { }

	// RVA: 0x2FE42A4
	void ScrollToItem(int index) { }

	// RVA: -1
	void Resize(Vector2 size) { }

	// RVA: -1
	void OnScroll(Vector2 scrollOffset) { }

	// RVA: 0x2FE41A8
	void OnScrollUpdate() { }

	// RVA: 0x2FE42A4
	void CycleItems(int firstIndex) { }

	// RVA: 0x2FE3054
	bool NeedsFill() { }

	// RVA: 0x2FE41A8
	void Fill() { }

	// RVA: -1
	void UpdateScrollViewContainer(float previousHeight, float newHeight) { }

	// RVA: 0x2FE4234
	void ApplyScrollViewUpdate(bool dimensionsOnly) { }

	// RVA: 0x2FE41A8
	void UpdateAnchor() { }

	// RVA: 0x2FE41A8
	void ScheduleFill() { }

	// RVA: 0x2FE41A8
	void ScheduleScroll() { }

	// RVA: 0x2FE41A8
	void ScheduleScrollDirectionReset() { }

	// RVA: 0x2FE41A8
	void ResetScroll() { }

	// RVA: -1
	int GetIndexFromPosition(Vector2 position) { }

	// RVA: -1
	float GetExpectedItemHeight(int index) { }

	// RVA: 0x309AF8C
	int GetFirstVisibleItem(float offset) { }

	// RVA: -1
	float GetExpectedContentHeight() { }

	// RVA: -1
	float GetContentHeightForIndex(int lastIndex) { }

	// RVA: 0x309AF8C
	ContentHeightCacheInfo GetCachedContentHeight(int index) { }

	// RVA: -1
	void RegisterItemHeight(int index, float height) { }

	// RVA: 0x2FE42A4
	void UnregisterItemHeight(int index) { }

	// RVA: 0x2FE41A8
	void CleanItemHeightCache() { }

	// RVA: 0x2FE4574
	void OnRecycledItemGeometryChanged(ReusableCollectionItem item) { }

	// RVA: 0x2FE3174
	bool UpdateRegisteredHeight(ReusableCollectionItem item) { }

	// RVA: 0x309AF8C
	T GetOrMakeItemAtIndex(int activeItemIndex, int scrollViewIndex) { }

	// RVA: 0x2FE42A4
	void ReleaseItem(int activeItemsIndex) { }

	// RVA: 0x2FE4574
	void StartDragItem(ReusableCollectionItem item) { }

	// RVA: 0x2FE42A4
	void EndDrag(int dropIndex) { }

	// RVA: 0x2FE42A4
	void HideItem(int activeItemsIndex) { }

	// RVA: 0x309AF8C
	void MarkWaitingForLayout(T item) { }

	// RVA: 0x2FE3088
	bool IsIndexOutOfBounds(int i) { }

}

// Namespace: UnityEngine.UIElements
internal class FixedHeightVirtualizationController<T0> 
{
	// Methods

	// RVA: -1
	float get_resolvedItemHeight() { }

	// RVA: 0x309AF8C
	bool VisibleItemPredicate(T i) { }

	// RVA: 0x2FE4574
	void .ctor(BaseVerticalCollectionView collectionView) { }

	// RVA: -1
	int GetIndexFromPosition(Vector2 position) { }

	// RVA: -1
	float GetExpectedItemHeight(int index) { }

	// RVA: -1
	float GetExpectedContentHeight() { }

	// RVA: 0x2FE42A4
	void ScrollToItem(int index) { }

	// RVA: -1
	void Resize(Vector2 size) { }

	// RVA: -1
	void OnScroll(Vector2 scrollOffset) { }

	// RVA: 0x309AF8C
	T GetOrMakeItemAtIndex(int activeItemIndex, int scrollViewIndex) { }

	// RVA: 0x2FE42A4
	void EndDrag(int dropIndex) { }

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

	// RVA: 0x1633480
	VisualElement get_rootElement() { }

	// RVA: 0x1633488
	VisualElement get_bindableElement() { }

	// RVA: 0x1633490
	void set_bindableElement(VisualElement value) { }

	// RVA: 0x1633498
	UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> get_animator() { }

	// RVA: 0x16334A0
	void set_animator(UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> value) { }

	// RVA: 0x16334A8
	int get_index() { }

	// RVA: 0x16334B0
	void set_index(int value) { }

	// RVA: 0x16334B8
	int get_id() { }

	// RVA: 0x16334C0
	void set_id(int value) { }

	// RVA: 0x16334C8
	bool get_isDragGhost() { }

	// RVA: 0x16334D0
	void set_isDragGhost(bool value) { }

	// RVA: 0x16334D8
	void add_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x163358C
	void remove_onGeometryChanged(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x1633640
	void add_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x16336F4
	void remove_onDestroy(System.Action<UnityEngine.UIElements.ReusableCollectionItem> value) { }

	// RVA: 0x16337A8
	void .ctor() { }

	// RVA: 0x1633844
	void Init(VisualElement item) { }

	// RVA: 0x163384C
	void PreAttachElement() { }

	// RVA: 0x1633910
	void DetachElement() { }

	// RVA: 0x1633A24
	void DestroyElement() { }

	// RVA: 0x1633A44
	void SetSelected(bool selected) { }

	// RVA: 0x1633B68
	void SetDragGhost(bool dragGhost) { }

	// RVA: 0x1633D24
	void OnGeometryChanged(GeometryChangedEvent evt) { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableListViewItem 
{
	// Fields
	private VisualElement m_Container; // 0x48
	private VisualElement m_DragHandle; // 0x50
	private VisualElement m_ItemContainer; // 0x58

	// Methods

	// RVA: 0x1633D44
	VisualElement get_rootElement() { }

	// RVA: 0x162A078
	void Init(VisualElement item, bool usesAnimatedDragger) { }

	// RVA: 0x1633D5C
	void UpdateHierarchy(VisualElement root, VisualElement item, bool usesAnimatedDragger) { }

	// RVA: 0x162A770
	void UpdateDragHandle(bool needsDragHandle) { }

	// RVA: 0x1634020
	void PreAttachElement() { }

	// RVA: 0x16340B4
	void DetachElement() { }

	// RVA: 0x1634148
	void SetDragGhost(bool dragGhost) { }

	// RVA: 0x16341C8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableMultiColumnListViewItem 
{
	// Methods

	// RVA: 0x1634264
	VisualElement get_rootElement() { }

	// RVA: 0x163426C
	void Init(VisualElement item) { }

	// RVA: 0x1631C20
	void Init(VisualElement container, Columns columns, bool usesAnimatedDrag) { }

	// RVA: 0x1634270
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ReusableMultiColumnTreeViewItem 
{
	// Methods

	// RVA: 0x163430C
	VisualElement get_rootElement() { }

	// RVA: 0x1634314
	void Init(VisualElement item) { }

	// RVA: 0x1632930
	void Init(VisualElement container, Columns columns) { }

	// RVA: 0x1634864
	void .ctor() { }

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

	// RVA: 0x1634A24
	VisualElement get_rootElement() { }

	// RVA: 0x162D610
	void add_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value) { }

	// RVA: 0x162D478
	void remove_onPointerUp(System.Action<UnityEngine.UIElements.PointerUpEvent> value) { }

	// RVA: 0x162D6C4
	void add_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value) { }

	// RVA: 0x162D52C
	void remove_onToggleValueChanged(System.Action<UnityEngine.UIElements.ChangeEvent<System.Boolean>> value) { }

	// RVA: 0x1634868
	void .ctor() { }

	// RVA: 0x1634A3C
	void Init(VisualElement item) { }

	// RVA: 0x1634318
	void InitExpandHierarchy(VisualElement root, VisualElement item) { }

	// RVA: 0x1634B20
	void PreAttachElement() { }

	// RVA: 0x1634CFC
	void DetachElement() { }

	// RVA: 0x162D028
	void Indent(int depth) { }

	// RVA: 0x162D134
	void SetExpandedWithoutNotify(bool expanded) { }

	// RVA: 0x162D23C
	void SetToggleVisibility(bool visible) { }

	// RVA: 0x1635018
	void OnToggleGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x1634ED8
	void UpdateIndentLayout() { }

	// RVA: 0x1635270
	void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x163528C
	void OnToggleValueChanged(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.VerticalVirtualizationController.<>c<T> <>9; // 0x0
	public static System.Func<T> <>9__30_0; // 0x0
	public static System.Action<T> <>9__30_1; // 0x0
	public static System.Action<T> <>9__30_2; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	T <.ctor>b__30_0() { }

	// RVA: 0x309AF8C
	void <.ctor>b__30_1(T i) { }

	// RVA: 0x309AF8C
	void <.ctor>b__30_2(T i) { }

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

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }

	// RVA: 0x2FE32D4
	int get_itemsCount() { }

	// RVA: 0x309AF8C
	bool VisibleItemPredicate(T i) { }

	// RVA: 0x309AF8C
	T get_firstVisibleItem() { }

	// RVA: 0x309AF8C
	T get_lastVisibleItem() { }

	// RVA: 0x2FE32D4
	int get_visibleItemCount() { }

	// RVA: 0x2FE360C
	SerializedVirtualizationData get_serializedData() { }

	// RVA: 0x2FE32D4
	int get_firstVisibleIndex() { }

	// RVA: 0x2FE42A4
	void set_firstVisibleIndex(int value) { }

	// RVA: -1
	float get_lastHeight() { }

	// RVA: 0x2FE3054
	bool get_alwaysRebindOnRefresh() { }

	// RVA: 0x2FE4574
	void .ctor(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x2FE4234
	void Refresh(bool rebuild) { }

	// RVA: 0x309AF8C
	void Setup(T recycledItem, int newIndex) { }

	// RVA: 0x2FE4574
	void OnFocus(VisualElement leafTarget) { }

	// RVA: 0x2FE4574
	void OnBlur(VisualElement willFocus) { }

	// RVA: 0x2FE45DC
	void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) { }

	// RVA: 0x2FE41A8
	void UpdateBackground() { }

	// RVA: 0x2FE4574
	void StartDragItem(ReusableCollectionItem item) { }

	// RVA: 0x2FE42A4
	void EndDrag(int dropIndex) { }

	// RVA: 0x309AF8C
	T GetOrMakeItemAtIndex(int activeItemIndex, int scrollViewIndex) { }

	// RVA: 0x2FE42A4
	void ReleaseItem(int activeItemsIndex) { }

	// RVA: 0x2FE4574
	void OnDestroyItem(ReusableCollectionItem item) { }

	// RVA: 0x2FE32D4
	int GetDraggedIndex() { }

}

// Namespace: UnityEngine.UIElements
public abstract class ContextualMenuManager 
{
	// Fields
	private bool <displayMenuHandledOSX>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16352A8
	bool get_displayMenuHandledOSX() { }

	// RVA: 0x16352B0
	void set_displayMenuHandledOSX(bool value) { }

	// RVA: 0x2FE47D4
	void DisplayMenuIfEventMatches(EventBase evt, IEventHandler eventHandler) { }

	// RVA: 0x16352B8
	void DisplayMenu(EventBase triggerEvent, IEventHandler target) { }

	// RVA: 0x2FE47D4
	void DoDisplayMenu(DropdownMenu menu, EventBase triggerEvent) { }

}

// Namespace: UnityEngine.UIElements
public class ContextualMenuManipulator 
{
	// Fields
	private System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent> m_MenuBuilder; // 0x30

	// Methods

	// RVA: 0x1635694
	void .ctor(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent> menuBuilder) { }

	// RVA: 0x16357D4
	void RegisterCallbacksOnTarget() { }

	// RVA: 0x1635ABC
	void UnregisterCallbacksFromTarget() { }

	// RVA: 0x1635DA4
	void OnMouseUpDownEvent(IMouseEvent evt) { }

	// RVA: 0x1635F10
	void OnMouseDownEventOSX(MouseDownEvent evt) { }

	// RVA: 0x1636024
	void OnMouseUpEventOSX(MouseUpEvent evt) { }

	// RVA: 0x163612C
	void OnKeyUpEvent(KeyUpEvent evt) { }

	// RVA: 0x1635E64
	void DoDisplayMenu(EventBase evt) { }

	// RVA: 0x16361A0
	void OnContextualMenuEvent(ContextualMenuPopulateEvent evt) { }

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

	// RVA: 0x16361BC
	void .ctor(string label) { }

	// RVA: 0x1636580
	void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x16365BC
	string get_text() { }

	// RVA: 0x16364E0
	void set_text(string value) { }

	// RVA: 0x16365D8
	void InitLabel() { }

	// RVA: 0x163667C
	void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x1636784
	void OnClickEvent(EventBase evt) { }

	// RVA: 0x1636A7C
	void ToggleValue() { }

	// RVA: 0x1636ABC
	void UpdateMixedValueContent() { }

	// RVA: 0x1636D08
	void RegisterEditingCallbacks() { }

	// RVA: 0x1636E24
	void UnregisterEditingCallbacks() { }

}

// Namespace: 
public sealed class WriteDelegate 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(ref TValueType val, TFieldValue fieldValue) { }

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

	// RVA: 0x2FE4A14
	void .ctor(string name, string ussName, System.Func<TValueType,TFieldValue> read, WriteDelegate write) { }

}

// Namespace: 
private sealed class <>c__DisplayClass24_0 
{
	// Fields
	public FieldDescription desc; // 0x0
	public TField field; // 0x0
	public UnityEngine.UIElements.BaseCompositeField<TValueType,TField,TFieldValue> <>4__this; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	TFieldValue <.ctor>b__0(TFieldValue newValue) { }

	// RVA: 0x2FE4574
	void <.ctor>b__1(UnityEngine.UIElements.ChangeEvent<TFieldValue> e) { }

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

	// RVA: 0x2FE360C
	VisualElement GetSpacer() { }

	// RVA: 0x2FE360C
	FieldDescription[] DescribeFields() { }

	// RVA: 0x2FE45DC
	void .ctor(string label, int fieldsByLine) { }

	// RVA: 0x2FE41A8
	void UpdateDisplay() { }

	// RVA: 0x309AF8C
	void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x2FE41A8
	void OnViewDataReady() { }

	// RVA: 0x2FE41A8
	void UpdateMixedValueContent() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

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

	// RVA: 0x1639F74
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x163A460
	void .ctor() { }

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

	// RVA: 0x1636F40
	bool get_showBoundCollectionSize() { }

	// RVA: 0x1636F48
	void set_showBoundCollectionSize(bool value) { }

	// RVA: 0x163728C
	bool get_showFoldoutHeader() { }

	// RVA: 0x1637294
	void set_showFoldoutHeader(bool value) { }

	// RVA: 0x1636F60
	void SetupArraySizeField() { }

	// RVA: 0x1637CE0
	void set_headerTitle(string value) { }

	// RVA: 0x1637788
	bool get_showAddRemoveFooter() { }

	// RVA: 0x1637D28
	void set_showAddRemoveFooter(bool value) { }

	// RVA: 0x1637798
	void EnableFooter(bool enabled) { }

	// RVA: 0x1637D2C
	void AddItems(int itemCount) { }

	// RVA: 0x1637E48
	void OnArraySizeFieldChanged(UnityEngine.UIElements.ChangeEvent<System.String> evt) { }

	// RVA: 0x1637B90
	void UpdateArraySizeField() { }

	// RVA: 0x16374E4
	void UpdateListViewLabel() { }

	// RVA: 0x1638230
	void OnAddClicked() { }

	// RVA: 0x1638560
	void OnRemoveClicked() { }

	// RVA: 0x1638864
	VisualElement get_footer() { }

	// RVA: 0x1637DC0
	BaseListViewController get_viewController() { }

	// RVA: 0x163886C
	void CreateVirtualizationController() { }

	// RVA: 0x16388C0
	void SetViewController(CollectionViewController controller) { }

	// RVA: 0x1638FB0
	void OnItemAdded(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1638FCC
	void OnItemsRemoved(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1638FE8
	void OnItemsSourceSizeChanged() { }

	// RVA: 0x1632268
	void add_reorderModeChanged(Action value) { }

	// RVA: 0x16324CC
	void remove_reorderModeChanged(Action value) { }

	// RVA: 0x163908C
	ListViewReorderMode get_reorderMode() { }

	// RVA: 0x1639094
	void set_reorderMode(ListViewReorderMode value) { }

	// RVA: 0x1639104
	ListViewDragger CreateDragger() { }

	// RVA: 0x16391A8
	ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x1639210
	void .ctor() { }

	// RVA: 0x16392E4
	void PostRefresh() { }

	// RVA: 0x1639314
	bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	// RVA: 0x1639968
	void .cctor() { }

	// RVA: 0x1639EA0
	void <OnAddClicked>b__38_0() { }

}

// Namespace: 
private class PopupTextElement 
{
	// Methods

	// RVA: -1
	Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.BasePopupField.<>c<TValueType,TValueChoice> <>9; // 0x0
	public static UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.MouseDownEvent> <>9__23_0; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void <.ctor>b__23_0(MouseDownEvent e) { }

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

	// RVA: 0x2FE360C
	TextElement get_textElement() { }

	// RVA: 0x2FE360C
	string GetValueToDisplay() { }

	// RVA: 0x309AF8C
	string GetListItemToDisplay(TValueType item) { }

	// RVA: 0x2FE4574
	void AddMenuItems(IGenericMenu menu) { }

	// RVA: 0x2FE4574
	void set_choices(System.Collections.Generic.List<TValueChoice> value) { }

	// RVA: 0x309AF8C
	void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x2FE4574
	void .ctor(string label) { }

	// RVA: 0x2FE4574
	void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x2FE4574
	void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x2FE3088
	bool ContainsPointer(int pointerId) { }

	// RVA: 0x2FE4574
	void ProcessPointerDown(UnityEngine.UIElements.PointerEventBase<T> evt) { }

	// RVA: 0x2FE4574
	void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x2FE41A8
	void ShowMenu() { }

	// RVA: 0x2FE41A8
	void UpdateMixedValueContent() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

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

	// RVA: 0x2FE41A8
	void .ctor() { }

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

	// RVA: 0x2FE360C
	VisualElement get_dragContainer() { }

	// RVA: 0x2FE4574
	void set_dragContainer(VisualElement value) { }

	// RVA: 0x2FE360C
	VisualElement get_dragElement() { }

	// RVA: 0x2FE4574
	void set_dragElement(VisualElement value) { }

	// RVA: 0x2FE360C
	VisualElement get_trackElement() { }

	// RVA: 0x2FE4574
	void set_trackElement(VisualElement value) { }

	// RVA: 0x2FE360C
	VisualElement get_dragBorderElement() { }

	// RVA: 0x2FE4574
	void set_dragBorderElement(VisualElement value) { }

	// RVA: 0x2FE360C
	TextField get_inputTextField() { }

	// RVA: 0x2FE4574
	void set_inputTextField(TextField value) { }

	// RVA: 0x309AF8C
	TValueType get_lowValue() { }

	// RVA: 0x309AF8C
	void set_lowValue(TValueType value) { }

	// RVA: 0x309AF8C
	TValueType get_highValue() { }

	// RVA: 0x309AF8C
	void set_highValue(TValueType value) { }

	// RVA: 0x309AF8C
	void SetHighValueWithoutNotify(TValueType newHighValue) { }

	// RVA: -1
	float get_pageSize() { }

	// RVA: -1
	void set_pageSize(float value) { }

	// RVA: 0x2FE3054
	bool get_showInputField() { }

	// RVA: 0x2FE4234
	void set_showInputField(bool value) { }

	// RVA: 0x2FE3054
	bool get_clamped() { }

	// RVA: 0x2FE4234
	void set_clamped(bool value) { }

	// RVA: 0x2FE360C
	UnityEngine.UIElements.ClampedDragger<TValueType> get_clampedDragger() { }

	// RVA: 0x2FE4574
	void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<TValueType> value) { }

	// RVA: 0x309AF8C
	TValueType Clamp(TValueType value, TValueType lowBound, TValueType highBound) { }

	// RVA: 0x309AF8C
	TValueType GetClampedValue(TValueType newValue) { }

	// RVA: 0x309AF8C
	TValueType get_value() { }

	// RVA: 0x309AF8C
	void set_value(TValueType value) { }

	// RVA: 0x309AF8C
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	// RVA: 0x2FE41A8
	void UnityEngine.UIElements.IValueField<TValueType>.StartDragging() { }

	// RVA: 0x2FE41A8
	void UnityEngine.UIElements.IValueField<TValueType>.StopDragging() { }

	// RVA: 0x309AF8C
	void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x2FE32D4
	SliderDirection get_direction() { }

	// RVA: 0x2FE42A4
	void set_direction(SliderDirection value) { }

	// RVA: 0x2FE3054
	bool get_inverted() { }

	// RVA: 0x2FE4234
	void set_inverted(bool value) { }

	// RVA: 0x309AF8C
	void .ctor(string label, TValueType start, TValueType end, SliderDirection direction, float pageSize) { }

	// RVA: -1
	float GetClosestPowerOfTen(float positiveNumber) { }

	// RVA: -1
	float RoundToMultipleOf(float value, float roundingValue) { }

	// RVA: 0x2FE41A8
	void ClampValue() { }

	// RVA: 0x309AF8C
	TValueType SliderLerpUnclamped(TValueType a, TValueType b, float interpolant) { }

	// RVA: 0x309AF8C
	float SliderNormalizeValue(TValueType currentValue, TValueType lowerValue, TValueType higherValue) { }

	// RVA: 0x309AF8C
	TValueType ParseStringToValue(string previousValue, string newValue) { }

	// RVA: 0x309AF8C
	void ComputeValueFromKey(SliderKey sliderKey, bool isShift) { }

	// RVA: 0x309AF8C
	TValueType SliderLerpDirectionalUnclamped(TValueType a, TValueType b, float positionInterpolant) { }

	// RVA: 0x2FE41A8
	void SetSliderValueFromDrag() { }

	// RVA: 0x309AF8C
	void ComputeValueAndDirectionFromDrag(float sliderLength, float dragElementLength, float dragElementPos) { }

	// RVA: 0x2FE41A8
	void SetSliderValueFromClick() { }

	// RVA: 0x2FE4574
	void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x2FE4574
	void OnNavigationMove(NavigationMoveEvent evt) { }

	// RVA: -1
	void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	// RVA: -1
	void AdjustDragElement(float factor) { }

	// RVA: 0x2FE4574
	void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	// RVA: 0x2FE41A8
	void OnViewDataReady() { }

	// RVA: 0x309AF8C
	bool SameValues(float a, float b, float epsilon) { }

	// RVA: 0x2FE41A8
	void UpdateDragElementPosition() { }

	// RVA: 0x2FE4574
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x2FE41A8
	void UpdateTextFieldVisibility() { }

	// RVA: 0x2FE41A8
	void UpdateTextFieldValue() { }

	// RVA: 0x2FE4574
	void OnTextFieldFocusIn(FocusInEvent evt) { }

	// RVA: 0x2FE4574
	void OnTextFieldFocusOut(FocusOutEvent evt) { }

	// RVA: 0x2FE4574
	void OnInputNavigationMoveEvent(NavigationMoveEvent evt) { }

	// RVA: 0x2FE4574
	void OnTextFieldValueChange(UnityEngine.UIElements.ChangeEvent<System.String> evt) { }

	// RVA: 0x2FE41A8
	void UpdateMixedValueContent() { }

	// RVA: 0x2FE41A8
	void RegisterEditingCallbacks() { }

	// RVA: 0x2FE41A8
	void UnregisterEditingCallbacks() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private readonly UxmlBoolAttributeDescription m_AutoExpand; // 0xB0

	// Methods

	// RVA: 0x163D224
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x163D380
	void .ctor() { }

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

	// RVA: 0x163AC24
	IList get_itemsSource() { }

	// RVA: 0x163ACA4
	BaseTreeViewController get_viewController() { }

	// RVA: 0x163AD2C
	void CreateVirtualizationController() { }

	// RVA: 0x163AD80
	void SetViewController(CollectionViewController controller) { }

	// RVA: 0x163B028
	void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x163B25C
	ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x163B2C4
	bool get_autoExpand() { }

	// RVA: 0x163B2CC
	void set_autoExpand(bool value) { }

	// RVA: 0x163B364
	System.Collections.Generic.List<System.Int32> get_expandedItemIds() { }

	// RVA: 0x163B36C
	void set_expandedItemIds(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x163B37C
	void .ctor() { }

	// RVA: 0x163B384
	void .ctor(int itemHeight) { }

	// RVA: 0x163B68C
	void OnViewDataReady() { }

	// RVA: 0x163B7AC
	bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	// RVA: 0x163C400
	void SetSelectionById(int id) { }

	// RVA: 0x163C684
	void SetSelectionById(System.Collections.Generic.IEnumerable<System.Int32> ids) { }

	// RVA: 0x163C68C
	void SetSelectionInternalById(System.Collections.Generic.IEnumerable<System.Int32> ids, bool sendNotification) { }

	// RVA: 0x163CC24
	int GetItemIndex(int id, bool expand) { }

	// RVA: 0x163CE4C
	bool IsExpanded(int id) { }

	// RVA: 0x163CEDC
	void CollapseItem(int id, bool collapseAllChildren) { }

	// RVA: 0x163CF7C
	void ExpandItem(int id, bool expandAllChildren) { }

	// RVA: 0x163D018
	void OnTreeViewPointerUp(PointerUpEvent evt) { }

	// RVA: 0x163C038
	bool IsExpandedByIndex(int index) { }

	// RVA: 0x163C1F4
	void CollapseItemByIndex(int index, bool collapseAll) { }

	// RVA: 0x163C0C8
	void ExpandItemByIndex(int index, bool expandAll) { }

	// RVA: 0x163D054
	void .cctor() { }

	// RVA: 0x163D21C
	int <SetSelectionInternalById>b__47_0(int id) { }

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

	// RVA: 0x163D454
	void .ctor() { }

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

	// RVA: 0x163A768
	void .ctor() { }

	// RVA: 0x163A150
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

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

	// RVA: 0x1645064
	System.Collections.Generic.List<System.Int32> get_selectedIds() { }

	// RVA: 0x164506C
	void set_selectedIds(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x163D9F0
	int get_indexCount() { }

	// RVA: 0x163FB80
	int get_idCount() { }

	// RVA: 0x1641358
	int get_minIndex() { }

	// RVA: 0x1641314
	int get_maxIndex() { }

	// RVA: 0x1644310
	int get_capacity() { }

	// RVA: 0x1644364
	void set_capacity(int value) { }

	// RVA: 0x163DA3C
	int FirstIndex() { }

	// RVA: 0x163FBCC
	bool ContainsIndex(int index) { }

	// RVA: 0x1642A5C
	bool ContainsId(int id) { }

	// RVA: 0x164341C
	void AddId(int id) { }

	// RVA: 0x163FC40
	void AddIndex(int index, object obj) { }

	// RVA: 0x1643D58
	bool TryRemove(int index) { }

	// RVA: 0x1643E84
	void RemoveId(int id) { }

	// RVA: 0x1645074
	void ClearItems() { }

	// RVA: 0x16450C8
	void ClearIds() { }

	// RVA: 0x163FA20
	void ClearIndices() { }

	// RVA: 0x1644418
	void Clear() { }

	// RVA: 0x163EDD4
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass162_0 
{
	// Fields
	public int id; // 0x10

	// Methods

	// RVA: 0x163F098
	void .ctor() { }

	// RVA: 0x164518C
	bool <GetRootElementForId>b__0(ReusableCollectionItem t) { }

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

	// RVA: 0x163DB5C
	void .ctor(int <>1__state) { }

	// RVA: 0x16451B4
	void System.IDisposable.Dispose() { }

	// RVA: 0x1645244
	bool MoveNext() { }

	// RVA: 0x16455B0
	void <>m__Finally1() { }

	// RVA: 0x164560C
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x1645614
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1645654
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x164565C
	System.Collections.Generic.IEnumerator<System.Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

	// RVA: 0x1645710
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x163D45C
	bool HasCanStartDrag() { }

	// RVA: 0x163D46C
	bool RaiseCanStartDrag(ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids) { }

	// RVA: 0x163D530
	StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, System.Collections.Generic.IEnumerable<System.Int32> ids, StartDragArgs args) { }

	// RVA: 0x163D5F4
	DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	// RVA: 0x163D680
	DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	// RVA: 0x163D70C
	IList get_itemsSource() { }

	// RVA: 0x163D724
	void set_itemsSource(IList value) { }

	// RVA: 0x163D7F0
	VisualElement get_contentContainer() { }

	// RVA: 0x163D7F8
	SelectionType get_selectionType() { }

	// RVA: 0x163D800
	void set_selectionType(SelectionType value) { }

	// RVA: 0x163DAD4
	System.Collections.Generic.IEnumerable<System.Object> get_selectedItems() { }

	// RVA: 0x163C31C
	int get_selectedIndex() { }

	// RVA: 0x163DB94
	void set_selectedIndex(int value) { }

	// RVA: 0x163DB98
	System.Collections.Generic.IEnumerable<System.Int32> get_selectedIndices() { }

	// RVA: 0x163C018
	System.Collections.Generic.IEnumerable<System.Int32> get_selectedIds() { }

	// RVA: 0x163DBB8
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.ReusableCollectionItem> get_activeItems() { }

	// RVA: 0x163DC54
	ScrollView get_scrollView() { }

	// RVA: 0x163DC5C
	ListViewDragger get_dragger() { }

	// RVA: 0x163DC64
	CollectionVirtualizationController get_virtualizationController() { }

	// RVA: 0x163DCF4
	CollectionViewController get_viewController() { }

	// RVA: 0x163DCFC
	float ResolveItemHeight(float height) { }

	// RVA: 0x163DE08
	void set_showBorder(bool value) { }

	// RVA: 0x163DEA0
	bool get_reorderable() { }

	// RVA: 0x163E038
	void set_reorderable(bool value) { }

	// RVA: 0x163E3B8
	void set_horizontalScrollingEnabled(bool value) { }

	// RVA: 0x163E434
	AlternatingRowBackground get_showAlternatingRowBackgrounds() { }

	// RVA: 0x163E43C
	void set_showAlternatingRowBackgrounds(AlternatingRowBackground value) { }

	// RVA: 0x163E454
	CollectionVirtualizationMethod get_virtualizationMethod() { }

	// RVA: 0x163E45C
	void set_virtualizationMethod(CollectionVirtualizationMethod value) { }

	// RVA: 0x163E4A8
	float get_fixedItemHeight() { }

	// RVA: 0x163E4B0
	void set_fixedItemHeight(float value) { }

	// RVA: 0x163E5C0
	float get_lastHeight() { }

	// RVA: 0x163E5C8
	void CreateVirtualizationController() { }

	// RVA: 0x163DCAC
	CollectionVirtualizationController GetOrCreateVirtualizationController() { }

	// RVA: 0x2FE41A8
	void CreateVirtualizationController() { }

	// RVA: 0x163D790
	CollectionViewController GetOrCreateViewController() { }

	// RVA: 0x2FE360C
	CollectionViewController CreateViewController() { }

	// RVA: 0x163AF54
	void SetViewController(CollectionViewController controller) { }

	// RVA: 0x163E61C
	ListViewDragger CreateDragger() { }

	// RVA: 0x163E684
	void InitializeDragAndDropController(bool enableReordering) { }

	// RVA: 0x2FE360C
	ICollectionDragAndDropController CreateDragAndDropController() { }

	// RVA: 0x163E7E0
	void .ctor() { }

	// RVA: 0x163B590
	void .ctor(IList itemsSource, float itemHeight) { }

	// RVA: 0x163EF34
	VisualElement GetRootElementForId(int id) { }

	// RVA: 0x163F0A0
	bool HasValidDataAndBindings() { }

	// RVA: 0x163F0CC
	void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	// RVA: 0x163F11C
	void OnItemsSourceChanged() { }

	// RVA: 0x163B02C
	void RefreshItems() { }

	// RVA: 0x163E180
	void Rebuild() { }

	// RVA: 0x163F7F0
	void ScheduleRebuild() { }

	// RVA: 0x163F138
	void RefreshSelection() { }

	// RVA: 0x163FD54
	void PostRefresh() { }

	// RVA: 0x163C610
	void ScrollToItem(int index) { }

	// RVA: 0x163C480
	void ScrollToItemById(int id) { }

	// RVA: 0x163FEF8
	void OnScroll(Vector2 offset) { }

	// RVA: 0x163FE5C
	void Resize(Vector2 size) { }

	// RVA: 0x163FF80
	void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x16402CC
	void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x1640584
	bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) { }

	// RVA: 0x164139C
	void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x1641644
	bool HandleItemNavigation(bool moveIn, bool altKey) { }

	// RVA: 0x164164C
	void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x16420C4
	void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x16421A0
	void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x164227C
	void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x1641CA4
	void ProcessPointerDown(IPointerEvent evt) { }

	// RVA: 0x16416E8
	void ProcessPointerUp(IPointerEvent evt) { }

	// RVA: 0x1642358
	void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey) { }

	// RVA: 0x1642BA8
	void DoRangeSelection(int rangeSelectionFinalIndex) { }

	// RVA: 0x1642A58
	void ProcessSingleClick(int clickedIndex) { }

	// RVA: 0x1640C3C
	void SelectAll() { }

	// RVA: 0x1642B2C
	void AddToSelection(int index) { }

	// RVA: 0x16430B4
	void AddToSelection(System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x16435A4
	void AddToSelectionWithoutValidation(int index) { }

	// RVA: 0x1642AD0
	void RemoveFromSelection(int index) { }

	// RVA: 0x16439B8
	void RemoveFromSelectionWithoutValidation(int index) { }

	// RVA: 0x163C510
	void SetSelection(int index) { }

	// RVA: 0x1643F24
	void SetSelection(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1643F2C
	void SetSelectionWithoutNotify(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x163C788
	void SetSelectionInternal(System.Collections.Generic.IEnumerable<System.Int32> indices, bool sendNotification) { }

	// RVA: 0x1643F34
	bool MatchesExistingSelection(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x16434BC
	void NotifyOfSelectionChange() { }

	// RVA: 0x163D960
	void ClearSelection() { }

	// RVA: 0x1642D18
	void ClearSelectionWithoutValidation() { }

	// RVA: 0x163B758
	void OnViewDataReady() { }

	// RVA: 0x164447C
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x1644884
	void OnSizeChanged(GeometryChangedEvent evt) { }

	// RVA: 0x1644A00
	void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x1644BA8
	void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1644BAC
	void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x1644BE4
	void .cctor() { }

	// RVA: 0x1644FE0
	void <.ctor>b__159_0(float v) { }

	// RVA: 0x163FAF8
	void <RefreshSelection>g__NotifyIfChanged|172_0(ref UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass172_0& ) { }

	// RVA: 0x1641150
	void <Apply>g__HandleSelectionAndScroll|183_0(int index, ref UnityEngine.UIElements.BaseVerticalCollectionView.<>c__DisplayClass183_0& ) { }

}

// Namespace: UnityEngine.UIElements
public interface IBindable 
{
	// Methods

	// RVA: 0x2FE360C
	IBinding get_binding() { }

	// RVA: 0x2FE4574
	void set_bindingPath(string value) { }

}

// Namespace: UnityEngine.UIElements
public interface IBinding 
{
	// Methods

	// RVA: 0x2FE41A8
	void PreUpdate() { }

	// RVA: 0x2FE41A8
	void Update() { }

	// RVA: 0x2FE41A8
	void Release() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1646184
	void .ctor() { }

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

	// RVA: 0x16461D8
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1646404
	void .ctor() { }

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

	// RVA: 0x1645714
	void .ctor() { }

	// RVA: 0x164571C
	void .ctor(string label) { }

	// RVA: 0x1645C44
	void SetValueWithoutNotify(Bounds newValue) { }

	// RVA: 0x1645D44
	void UpdateMixedValueContent() { }

	// RVA: 0x1645E14
	void .cctor() { }

	// RVA: 0x1645F9C
	void <.ctor>b__10_0(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3> e) { }

	// RVA: 0x1646090
	void <.ctor>b__10_1(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3> e) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16470A8
	void .ctor() { }

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

	// RVA: 0x16470FC
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1647324
	void .ctor() { }

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

	// RVA: 0x1646638
	void .ctor() { }

	// RVA: 0x1646640
	void .ctor(string label) { }

	// RVA: 0x1646B68
	void SetValueWithoutNotify(BoundsInt newValue) { }

	// RVA: 0x1646C68
	void UpdateMixedValueContent() { }

	// RVA: 0x1646D38
	void .cctor() { }

	// RVA: 0x1646EC0
	void <.ctor>b__10_0(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3Int> e) { }

	// RVA: 0x1646FB4
	void <.ctor>b__10_1(UnityEngine.UIElements.ChangeEvent<UnityEngine.Vector3Int> e) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16476A0
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Box 
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x1647558
	void .ctor() { }

	// RVA: 0x1647628
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1647AE4
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x1647B38
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Button 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	private Clickable m_Clickable; // 0x4A0
	private static readonly string NonEmptyString; // 0x8

	// Methods

	// RVA: 0x16476F4
	Clickable get_clickable() { }

	// RVA: 0x16476FC
	void set_clickable(Clickable value) { }

	// RVA: 0x1647798
	void .ctor() { }

	// RVA: 0x16477A0
	void .ctor(Action clickEvent) { }

	// RVA: 0x1647940
	void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x1647984
	Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x1647A44
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1647E40
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x1647E94
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class ButtonStripField 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.Button> m_Buttons; // 0x440

	// Methods

	// RVA: 0x1647BB0
	void .ctor() { }

	// RVA: 0x1647C80
	void SetValueWithoutNotify(int newValue) { }

	// RVA: 0x1647D24
	void RefreshButtonsState() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16488C0
	void .ctor() { }

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

	// RVA: 0x1648914
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1648AD0
	void .ctor() { }

}

// Namespace: 
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

	// RVA: 0x1648C6C
	void .cctor() { }

	// RVA: 0x1648CD8
	void .ctor() { }

	// RVA: 0x1648CE0
	float <DescribeFields>b__0_0(Rect r) { }

	// RVA: 0x1648CE4
	void <DescribeFields>b__0_1(ref Rect r, float v) { }

	// RVA: 0x1648CEC
	float <DescribeFields>b__0_2(Rect r) { }

	// RVA: 0x1648CF4
	void <DescribeFields>b__0_3(ref Rect r, float v) { }

	// RVA: 0x1648CFC
	float <DescribeFields>b__0_4(Rect r) { }

	// RVA: 0x1648D04
	void <DescribeFields>b__0_5(ref Rect r, float v) { }

	// RVA: 0x1648D0C
	float <DescribeFields>b__0_6(Rect r) { }

	// RVA: 0x1648D14
	void <DescribeFields>b__0_7(ref Rect r, float v) { }

}

// Namespace: UnityEngine.UIElements
public class RectField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x1647EE8
	FieldDescription[] DescribeFields() { }

	// RVA: 0x164864C
	void .ctor() { }

	// RVA: 0x1648654
	void .ctor(string label) { }

	// RVA: 0x16487C0
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16496F4
	void .ctor() { }

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

	// RVA: 0x1649748
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16498FC
	void .ctor() { }

}

// Namespace: 
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

	// RVA: 0x1649A98
	void .cctor() { }

	// RVA: 0x1649B04
	void .ctor() { }

	// RVA: 0x1649B0C
	int <DescribeFields>b__0_0(RectInt r) { }

	// RVA: 0x1649B14
	void <DescribeFields>b__0_1(ref RectInt r, int v) { }

	// RVA: 0x1649B1C
	int <DescribeFields>b__0_2(RectInt r) { }

	// RVA: 0x1649B24
	void <DescribeFields>b__0_3(ref RectInt r, int v) { }

	// RVA: 0x1649B2C
	int <DescribeFields>b__0_4(RectInt r) { }

	// RVA: 0x1649B34
	void <DescribeFields>b__0_5(ref RectInt r, int v) { }

	// RVA: 0x1649B3C
	int <DescribeFields>b__0_6(RectInt r) { }

	// RVA: 0x1649B44
	void <DescribeFields>b__0_7(ref RectInt r, int v) { }

}

// Namespace: UnityEngine.UIElements
public class RectIntField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x1648D1C
	FieldDescription[] DescribeFields() { }

	// RVA: 0x1649480
	void .ctor() { }

	// RVA: 0x1649488
	void .ctor(string label) { }

	// RVA: 0x16495F4
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x164A1BC
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlFloatAttributeDescription m_XValue; // 0x80
	private UxmlFloatAttributeDescription m_YValue; // 0x88

	// Methods

	// RVA: 0x164A210
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x164A364
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.Vector2Field.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector2,System.Single> <>9__0_0; // 0x8
	public static WriteDelegate <>9__0_1; // 0x10
	public static System.Func<UnityEngine.Vector2,System.Single> <>9__0_2; // 0x18
	public static WriteDelegate <>9__0_3; // 0x20

	// Methods

	// RVA: 0x164A468
	void .cctor() { }

	// RVA: 0x164A4D4
	void .ctor() { }

	// RVA: 0x164A4DC
	float <DescribeFields>b__0_0(Vector2 r) { }

	// RVA: 0x164A4E0
	void <DescribeFields>b__0_1(ref Vector2 r, float v) { }

	// RVA: 0x164A4E8
	float <DescribeFields>b__0_2(Vector2 r) { }

	// RVA: 0x164A4F0
	void <DescribeFields>b__0_3(ref Vector2 r, float v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector2Field 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x1649B4C
	FieldDescription[] DescribeFields() { }

	// RVA: 0x1649F60
	void .ctor() { }

	// RVA: 0x1649F68
	void .ctor(string label) { }

	// RVA: 0x164A0BC
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x164ABBC
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlFloatAttributeDescription m_XValue; // 0x80
	private UxmlFloatAttributeDescription m_YValue; // 0x88
	private UxmlFloatAttributeDescription m_ZValue; // 0x90

	// Methods

	// RVA: 0x164AC10
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x164AD94
	void .ctor() { }

}

// Namespace: 
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

	// RVA: 0x164AEE4
	void .cctor() { }

	// RVA: 0x164AF50
	void .ctor() { }

	// RVA: 0x164AF58
	float <DescribeFields>b__0_0(Vector3 r) { }

	// RVA: 0x164AF5C
	void <DescribeFields>b__0_1(ref Vector3 r, float v) { }

	// RVA: 0x164AF64
	float <DescribeFields>b__0_2(Vector3 r) { }

	// RVA: 0x164AF6C
	void <DescribeFields>b__0_3(ref Vector3 r, float v) { }

	// RVA: 0x164AF74
	float <DescribeFields>b__0_4(Vector3 r) { }

	// RVA: 0x164AF7C
	void <DescribeFields>b__0_5(ref Vector3 r, float v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector3Field 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x164A4F8
	FieldDescription[] DescribeFields() { }

	// RVA: 0x164AAB4
	void .ctor() { }

	// RVA: 0x1645AF0
	void .ctor(string label) { }

	// RVA: 0x164AABC
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x164B944
	void .ctor() { }

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

	// RVA: 0x164B998
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x164BB54
	void .ctor() { }

}

// Namespace: 
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

	// RVA: 0x164BCF0
	void .cctor() { }

	// RVA: 0x164BD5C
	void .ctor() { }

	// RVA: 0x164BD64
	float <DescribeFields>b__0_0(Vector4 r) { }

	// RVA: 0x164BD68
	void <DescribeFields>b__0_1(ref Vector4 r, float v) { }

	// RVA: 0x164BD70
	float <DescribeFields>b__0_2(Vector4 r) { }

	// RVA: 0x164BD78
	void <DescribeFields>b__0_3(ref Vector4 r, float v) { }

	// RVA: 0x164BD80
	float <DescribeFields>b__0_4(Vector4 r) { }

	// RVA: 0x164BD88
	void <DescribeFields>b__0_5(ref Vector4 r, float v) { }

	// RVA: 0x164BD90
	float <DescribeFields>b__0_6(Vector4 r) { }

	// RVA: 0x164BD98
	void <DescribeFields>b__0_7(ref Vector4 r, float v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector4Field 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x164AF84
	FieldDescription[] DescribeFields() { }

	// RVA: 0x164B6E8
	void .ctor() { }

	// RVA: 0x164B6F0
	void .ctor(string label) { }

	// RVA: 0x164B844
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x164C410
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlIntAttributeDescription m_XValue; // 0x80
	private UxmlIntAttributeDescription m_YValue; // 0x88

	// Methods

	// RVA: 0x164C464
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x164C5B0
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.Vector2IntField.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector2Int,System.Int32> <>9__0_0; // 0x8
	public static WriteDelegate <>9__0_1; // 0x10
	public static System.Func<UnityEngine.Vector2Int,System.Int32> <>9__0_2; // 0x18
	public static WriteDelegate <>9__0_3; // 0x20

	// Methods

	// RVA: 0x164C6B4
	void .cctor() { }

	// RVA: 0x164C720
	void .ctor() { }

	// RVA: 0x164C728
	int <DescribeFields>b__0_0(Vector2Int r) { }

	// RVA: 0x164C730
	void <DescribeFields>b__0_1(ref Vector2Int r, int v) { }

	// RVA: 0x164C738
	int <DescribeFields>b__0_2(Vector2Int r) { }

	// RVA: 0x164C740
	void <DescribeFields>b__0_3(ref Vector2Int r, int v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector2IntField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x164BDA0
	FieldDescription[] DescribeFields() { }

	// RVA: 0x164C1B4
	void .ctor() { }

	// RVA: 0x164C1BC
	void .ctor(string label) { }

	// RVA: 0x164C310
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x164CE0C
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlIntAttributeDescription m_XValue; // 0x80
	private UxmlIntAttributeDescription m_YValue; // 0x88
	private UxmlIntAttributeDescription m_ZValue; // 0x90

	// Methods

	// RVA: 0x164CE60
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x164CFDC
	void .ctor() { }

}

// Namespace: 
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

	// RVA: 0x164D12C
	void .cctor() { }

	// RVA: 0x164D198
	void .ctor() { }

	// RVA: 0x164D1A0
	int <DescribeFields>b__0_0(Vector3Int r) { }

	// RVA: 0x164D1A8
	void <DescribeFields>b__0_1(ref Vector3Int r, int v) { }

	// RVA: 0x164D1B0
	int <DescribeFields>b__0_2(Vector3Int r) { }

	// RVA: 0x164D1B8
	void <DescribeFields>b__0_3(ref Vector3Int r, int v) { }

	// RVA: 0x164D1C0
	int <DescribeFields>b__0_4(Vector3Int r) { }

	// RVA: 0x164D1C8
	void <DescribeFields>b__0_5(ref Vector3Int r, int v) { }

}

// Namespace: UnityEngine.UIElements
public class Vector3IntField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x164C748
	FieldDescription[] DescribeFields() { }

	// RVA: 0x164CD04
	void .ctor() { }

	// RVA: 0x1646A14
	void .ctor(string label) { }

	// RVA: 0x164CD0C
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x164D950
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x164D9A4
	void .ctor() { }

}

// Namespace: 
private class DoubleInput 
{
	// Methods

	// RVA: 0x164D9F8
	DoubleField get_parentDoubleField() { }

	// RVA: 0x164D68C
	void .ctor() { }

	// RVA: 0x164DA7C
	string get_allowedCharacters() { }

	// RVA: 0x164DAF8
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Double startValue) { }

	// RVA: 0x164DD34
	string ValueToString(Double v) { }

	// RVA: 0x164DD8C
	Double StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class DoubleField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x164D1D0
	DoubleInput get_doubleInput() { }

	// RVA: 0x164D288
	string ValueToString(Double v) { }

	// RVA: 0x164D348
	Double StringToValue(string str) { }

	// RVA: 0x164D484
	void .ctor() { }

	// RVA: 0x164D490
	void .ctor(string label, int maxLength) { }

	// RVA: 0x164D728
	bool CanTryParse(string textString) { }

	// RVA: 0x164D754
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Double startValue) { }

	// RVA: 0x164D850
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x164DF38
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlIntAttributeDescription m_Index; // 0x80
	private UxmlStringAttributeDescription m_Choices; // 0x88

	// Methods

	// RVA: 0x164DF8C
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x164E118
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DropdownField 
{
	// Methods

	// RVA: 0x164DE3C
	void .ctor() { }

	// RVA: 0x164DEB8
	void .ctor(string label) { }

}

// Namespace: UnityEngine.UIElements
internal static class EnumFieldHelpers 
{
	// Fields
	internal static readonly UnityEngine.UIElements.UxmlTypeAttributeDescription<System.Enum> type; // 0x0
	internal static readonly UxmlStringAttributeDescription value; // 0x8
	internal static readonly UxmlBoolAttributeDescription includeObsoleteValues; // 0x10

	// Methods

	// RVA: 0x164E268
	bool ExtractValue(IUxmlAttributes bag, CreationContext cc, out Type resEnumType, out Enum resEnumValue, out bool resIncludeObsoleteValues) { }

	// RVA: 0x164E634
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x164FEEC
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UnityEngine.UIElements.UxmlTypeAttributeDescription<System.Enum> m_Type; // 0x80
	private UxmlStringAttributeDescription m_Value; // 0x88
	private UxmlBoolAttributeDescription m_IncludeObsoleteValues; // 0x90

	// Methods

	// RVA: 0x164FF40
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x165021C
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.EnumField.<>c <>9; // 0x0
	public static UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.MouseDownEvent> <>9__22_0; // 0x8

	// Methods

	// RVA: 0x16502DC
	void .cctor() { }

	// RVA: 0x1650348
	void .ctor() { }

	// RVA: 0x1650350
	void <.ctor>b__22_0(MouseDownEvent e) { }

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

	// RVA: 0x164E7F8
	bool get_includeObsoleteValues() { }

	// RVA: 0x164E800
	void Initialize(Enum defaultValue) { }

	// RVA: 0x164E9C0
	void .ctor() { }

	// RVA: 0x164E9CC
	void .ctor(string label, Enum defaultValue) { }

	// RVA: 0x164E9B8
	void Init(Enum defaultValue) { }

	// RVA: 0x164ED64
	void Init(Enum defaultValue, bool includeObsoleteValues) { }

	// RVA: 0x164EF14
	void PopulateDataFromType(Type enumType) { }

	// RVA: 0x164F0AC
	void SetValueWithoutNotify(Enum newValue) { }

	// RVA: 0x164EFD0
	void UpdateValueLabel(Enum value) { }

	// RVA: 0x164F1AC
	void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x164F208
	void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x164F2A4
	bool ContainsPointer(int pointerId) { }

	// RVA: 0x2FE4574
	void ProcessPointerDown(UnityEngine.UIElements.PointerEventBase<T> evt) { }

	// RVA: 0x164F340
	void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x164F370
	void ShowMenu() { }

	// RVA: 0x164FA6C
	void ChangeValueFromMenu(object menuItem) { }

	// RVA: 0x164FB04
	void UpdateMixedValueContent() { }

	// RVA: 0x164FCCC
	void .cctor() { }

	// RVA: 0x164FE54
	void <ShowMenu>b__33_0(object contentView) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1650B30
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x1650B84
	void .ctor() { }

}

// Namespace: 
private class FloatInput 
{
	// Methods

	// RVA: 0x1650BD8
	FloatField get_parentFloatField() { }

	// RVA: 0x165086C
	void .ctor() { }

	// RVA: 0x1650C5C
	string get_allowedCharacters() { }

	// RVA: 0x1650CD8
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x1650F44
	string ValueToString(float v) { }

	// RVA: 0x1650F9C
	float StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class FloatField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x16503B0
	FloatInput get_floatInput() { }

	// RVA: 0x1650468
	string ValueToString(float v) { }

	// RVA: 0x1650528
	float StringToValue(string str) { }

	// RVA: 0x1650664
	void .ctor() { }

	// RVA: 0x1650670
	void .ctor(string label, int maxLength) { }

	// RVA: 0x1650908
	bool CanTryParse(string textString) { }

	// RVA: 0x1650934
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x1650A30
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1651F08
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x78
	private UxmlBoolAttributeDescription m_Value; // 0x80

	// Methods

	// RVA: 0x1651F5C
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1652098
	void .ctor() { }

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

	// RVA: 0x165104C
	Toggle get_toggle() { }

	// RVA: 0x1651054
	VisualElement get_contentContainer() { }

	// RVA: 0x165105C
	void set_text(string value) { }

	// RVA: 0x16511BC
	bool get_value() { }

	// RVA: 0x16511C4
	void set_value(bool value) { }

	// RVA: 0x165138C
	void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x16514E4
	void OnViewDataReady() { }

	// RVA: 0x1651530
	void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x1651570
	bool Apply(KeyboardNavigationOperation op) { }

	// RVA: 0x165164C
	void .ctor() { }

	// RVA: 0x1651A64
	void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x1651C50
	void .cctor() { }

	// RVA: 0x1651EB4
	void <.ctor>b__29_0(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

}

// Namespace: UnityEngine.UIElements
internal interface IGenericMenu 
{
	// Methods

	// RVA: -1
	void AddItem(string itemName, bool isChecked, Action action) { }

	// RVA: -1
	void AddItem(string itemName, bool isChecked, System.Action<System.Object> action, object data) { }

	// RVA: -1
	void DropDown(Rect position, VisualElement targetElement, bool anchored) { }

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

	// RVA: 0x1653BBC
	void .ctor() { }

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

	// RVA: 0x16521D4
	bool get_isSingleSelectionDropdown() { }

	// RVA: 0x16521DC
	void set_isSingleSelectionDropdown(bool value) { }

	// RVA: 0x16521E4
	bool get_closeOnParentResize() { }

	// RVA: 0x16521EC
	void set_closeOnParentResize(bool value) { }

	// RVA: 0x16521F4
	VisualElement get_contentContainer() { }

	// RVA: 0x164F738
	void .ctor() { }

	// RVA: 0x165221C
	void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x1652648
	void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x16529E0
	void Hide(bool giveFocusBack) { }

	// RVA: 0x1652A84
	void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	// RVA: 0x1652AD0
	bool Apply(KeyboardNavigationOperation op) { }

	// RVA: 0x1652EDC
	void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x1653194
	void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x1653300
	void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x165346C
	void OnFocusOut(FocusOutEvent evt) { }

	// RVA: 0x16535F4
	void OnParentResized(GeometryChangedEvent evt) { }

	// RVA: 0x1653048
	void UpdateSelection(VisualElement target) { }

	// RVA: 0x1653608
	void ChangeSelectedIndex(int newIndex, int previousIndex) { }

	// RVA: 0x1652C94
	int GetSelectedIndex() { }

	// RVA: 0x165375C
	void AddItem(string itemName, bool isChecked, Action action) { }

	// RVA: 0x1653ABC
	void AddItem(string itemName, bool isChecked, System.Action<System.Object> action, object data) { }

	// RVA: 0x1653AF8
	void AddSeparator(string path) { }

	// RVA: 0x165379C
	MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data) { }

	// RVA: 0x1653BC4
	void DropDown(Rect position, VisualElement targetElement, bool anchored) { }

	// RVA: 0x1654AA4
	void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x1654B04
	void OnContainerGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x1654510
	void EnsureVisibilityInParent() { }

	// RVA: 0x1654B08
	void .cctor() { }

	// RVA: 0x1652E18
	void <Apply>g__UpdateSelectionDown|39_0(int newIndex, ref UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass39_0& ) { }

	// RVA: 0x1652D50
	void <Apply>g__UpdateSelectionUp|39_1(int newIndex, ref UnityEngine.UIElements.GenericDropdownMenu.<>c__DisplayClass39_0& ) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1655030
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x78

	// Methods

	// RVA: 0x1655084
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1655180
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class GroupBox 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	private Label m_TitleLabel; // 0x3D8

	// Methods

	// RVA: 0x1654D18
	void set_text(string value) { }

	// RVA: 0x1654E5C
	void .ctor() { }

	// RVA: 0x1654EE4
	void .ctor(string text) { }

	// RVA: 0x1654F70
	void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x1654F74
	void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x1654F78
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1655D9C
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x1655DF0
	void .ctor() { }

}

// Namespace: 
private class Hash128Input 
{
	// Methods

	// RVA: 0x16553E0
	void .ctor() { }

	// RVA: 0x1655E44
	string get_allowedCharacters() { }

	// RVA: 0x1655E88
	bool AcceptCharacter(Char c) { }

	// RVA: 0x1655F40
	Hash128 StringToValue(string str) { }

	// RVA: 0x16559A4
	Hash128 Parse(string str) { }

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

	// RVA: 0x1655224
	void .ctor() { }

	// RVA: 0x1655230
	void .ctor(string label, int maxLength) { }

	// RVA: 0x1655538
	Hash128 get_value() { }

	// RVA: 0x16555A0
	void set_value(Hash128 value) { }

	// RVA: 0x165567C
	void UpdateValueFromText() { }

	// RVA: 0x1655778
	void UpdateTextFromValue() { }

	// RVA: 0x1655818
	void SetValueWithoutNotify(Hash128 newValue) { }

	// RVA: 0x16558F4
	string ValueToString(Hash128 value) { }

	// RVA: 0x165591C
	Hash128 StringToValue(string str) { }

	// RVA: 0x1655A2C
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x1655C9C
	void .cctor() { }

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

	// RVA: 0x16D027C
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x70
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.HelpBoxMessageType> m_MessageType; // 0x78

	// Methods

	// RVA: 0x16D02D0
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16D0408
	void .ctor() { }

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

	// RVA: 0x1655FC8
	void set_text(string value) { }

	// RVA: 0x1655FF0
	void set_messageType(HelpBoxMessageType value) { }

	// RVA: 0x1656198
	void .ctor() { }

	// RVA: 0x16561F8
	void .ctor(string text, HelpBoxMessageType messageType) { }

	// RVA: 0x1656364
	string GetIconClass(HelpBoxMessageType messageType) { }

	// RVA: 0x1656008
	void UpdateIcon(HelpBoxMessageType messageType) { }

	// RVA: 0x165644C
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16D20D4
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x16D2128
	void .ctor() { }

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

	// RVA: 0x16D0554
	Texture get_image() { }

	// RVA: 0x16D055C
	void set_image(Texture value) { }

	// RVA: 0x16D0674
	Sprite get_sprite() { }

	// RVA: 0x16D067C
	void set_sprite(Sprite value) { }

	// RVA: 0x16D0794
	VectorImage get_vectorImage() { }

	// RVA: 0x16D079C
	void set_vectorImage(VectorImage value) { }

	// RVA: 0x16D08B4
	Rect get_sourceRect() { }

	// RVA: 0x16D0AAC
	Rect get_uv() { }

	// RVA: 0x16D0AC0
	void set_uv(Rect value) { }

	// RVA: 0x16D0AFC
	ScaleMode get_scaleMode() { }

	// RVA: 0x16D0B04
	Color get_tintColor() { }

	// RVA: 0x16D0B18
	void .ctor() { }

	// RVA: 0x16D0CF0
	Vector2 GetTextureDisplaySize(Texture texture) { }

	// RVA: 0x16D0DF0
	Vector2 GetTextureDisplaySize(Sprite sprite) { }

	// RVA: 0x16D0F40
	Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x16D11F0
	void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x16D17F8
	void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x16D1830
	void ReadCustomProperties(ICustomStyle customStyleProvider) { }

	// RVA: 0x309AF8C
	void SetProperty(T0 src, ref T0 dst, ref T1 alt0, ref T2 alt1) { }

	// RVA: 0x16D1DB8
	void ClearProperty() { }

	// RVA: 0x16D1E04
	void SetScaleMode(ScaleMode mode) { }

	// RVA: 0x16D1E24
	void SetTintColor(Color color) { }

	// RVA: 0x16D08B8
	Rect GetSourceRect() { }

	// RVA: 0x16D1E94
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface INotifyValueChanged<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	T get_value() { }

	// RVA: 0x309AF8C
	void set_value(T value) { }

	// RVA: 0x309AF8C
	void SetValueWithoutNotify(T newValue) { }

}

// Namespace: UnityEngine.UIElements
public static class INotifyValueChangedExtensions 
{
	// Methods

	// RVA: 0x2FE59C8
	bool RegisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback) { }

	// RVA: 0x2FE59C8
	bool UnregisterValueChangedCallback(UnityEngine.UIElements.INotifyValueChanged<T> control, UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.ChangeEvent<T>> callback) { }

}

// Namespace: UnityEngine.UIElements
internal interface IEditableElement 
{
	// Methods

	// RVA: 0x2FE360C
	Action get_editingStarted() { }

	// RVA: 0x2FE360C
	Action get_editingEnded() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Label; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: -1
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE7084
	System.Collections.Generic.List<System.String> ParseChoiceList(string choicesFromBag) { }

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

	// RVA: 0x2FE360C
	VisualElement get_visualInput() { }

	// RVA: 0x2FE4574
	void set_visualInput(VisualElement value) { }

	// RVA: 0x309AF8C
	TValueType get_rawValue() { }

	// RVA: 0x309AF8C
	void set_rawValue(TValueType value) { }

	// RVA: 0x2FE4574
	void add_onValidateValue(System.Func<TValueType,TValueType> value) { }

	// RVA: 0x2FE4574
	void remove_onValidateValue(System.Func<TValueType,TValueType> value) { }

	// RVA: 0x309AF8C
	TValueType get_value() { }

	// RVA: 0x309AF8C
	void set_value(TValueType value) { }

	// RVA: 0x2FE360C
	Label get_labelElement() { }

	// RVA: 0x2FE4574
	void set_labelElement(Label value) { }

	// RVA: 0x2FE360C
	string get_label() { }

	// RVA: 0x2FE4574
	void set_label(string value) { }

	// RVA: 0x2FE3054
	bool get_showMixedValue() { }

	// RVA: 0x2FE4234
	void set_showMixedValue(bool value) { }

	// RVA: 0x2FE360C
	Label get_mixedValueLabel() { }

	// RVA: 0x2FE360C
	Action UnityEngine.UIElements.IEditableElement.get_editingStarted() { }

	// RVA: 0x2FE360C
	Action UnityEngine.UIElements.IEditableElement.get_editingEnded() { }

	// RVA: 0x2FE4574
	void .ctor(string label) { }

	// RVA: 0x2FE47D4
	void .ctor(string label, VisualElement visualInput) { }

	// RVA: 0x309AF8C
	bool EqualsCurrentValue(TValueType value) { }

	// RVA: 0x2FE4574
	void OnAttachToPanel(AttachToPanelEvent e) { }

	// RVA: 0x2FE4574
	void OnDetachFromPanel(DetachFromPanelEvent e) { }

	// RVA: 0x2FE41A8
	void RegisterEditingCallbacks() { }

	// RVA: 0x2FE41A8
	void UnregisterEditingCallbacks() { }

	// RVA: 0x2FE4574
	void StartEditing(EventBase e) { }

	// RVA: 0x2FE4574
	void EndEditing(EventBase e) { }

	// RVA: 0x2FE4574
	void OnCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	// RVA: 0x2FE4574
	void OnInspectorFieldGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x2FE41A8
	void AlignLabel() { }

	// RVA: 0x309AF8C
	TValueType ValidatedValue(TValueType value) { }

	// RVA: 0x2FE41A8
	void UpdateMixedValueContent() { }

	// RVA: 0x309AF8C
	void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x2FE41A8
	void OnViewDataReady() { }

	// RVA: -1
	Rect GetTooltipRect() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public class BaseFieldTraits<T0, T1> 
{
	// Fields
	private TValueUxmlAttributeType m_Value; // 0x0

	// Methods

	// RVA: -1
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class KeyboardTextEditorEventHandler 
{
	// Fields
	private readonly Event m_ImguiEvent; // 0x20
	internal bool m_Changed; // 0x28

	// Methods

	// RVA: 0x16D2130
	void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x16D22C8
	void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x16D2604
	void OnFocus(FocusEvent _) { }

	// RVA: 0x16D272C
	void OnBlur(BlurEvent _) { }

	// RVA: 0x16D27A4
	void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x16D351C
	void UpdateLabel() { }

	// RVA: 0x16D2F48
	void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	// RVA: 0x16D3190
	void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	// RVA: 0x2FE4574
	void OnNavigationEvent(UnityEngine.UIElements.NavigationEventBase<TEvent> evt) { }

}

// Namespace: UnityEngine.UIElements
internal class TextEditorEventHandler 
{
	// Fields
	protected TextElement textElement; // 0x10
	protected TextEditingUtilities editingUtilities; // 0x18

	// Methods

	// RVA: 0x16D2278
	void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x16D2600
	void ExecuteDefaultActionAtTarget(EventBase evt) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16D46FC
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private static readonly UxmlStringAttributeDescription k_Value; // 0x0
	private UxmlBoolAttributeDescription m_Multiline; // 0xC8

	// Methods

	// RVA: 0x16D4750
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16D48F8
	void .ctor() { }

	// RVA: 0x16D49B0
	void .cctor() { }

}

// Namespace: 
private class TextInput 
{
	// Methods

	// RVA: 0x16D3984
	void set_multiline(bool value) { }

	// RVA: 0x16D4ACC
	void set_isPasswordField(bool value) { }

	// RVA: 0x16D4B48
	string StringToValue(string str) { }

	// RVA: 0x16D3E74
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class TextField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x16D3808
	TextInput get_textInput() { }

	// RVA: 0x16D38C0
	void set_multiline(bool value) { }

	// RVA: 0x16D3BE0
	void .ctor() { }

	// RVA: 0x16D3BF8
	void .ctor(string label) { }

	// RVA: 0x16D3C0C
	void .ctor(string label, int maxLength, bool multiline, bool isPasswordField, Char maskChar) { }

	// RVA: 0x16D3F18
	string get_value() { }

	// RVA: 0x16D3F80
	void set_value(string value) { }

	// RVA: 0x16D40B8
	void SetValueWithoutNotify(string newValue) { }

	// RVA: 0x16D4268
	void UpdateTextFromValue() { }

	// RVA: 0x16D42E4
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x16D451C
	void OnViewDataReady() { }

	// RVA: 0x16D45EC
	string ValueToString(string value) { }

	// RVA: 0x16D45F4
	string StringToValue(string str) { }

	// RVA: 0x16D45FC
	void .cctor() { }

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
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

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

	// RVA: 0x2FE360C
	TextElement get_textElement() { }

	// RVA: 0x2FE4574
	void set_textElement(TextElement value) { }

	// RVA: 0x2FE360C
	ITextSelection get_textSelection() { }

	// RVA: 0x2FE360C
	ITextEdition get_textEdition() { }

	// RVA: 0x2FE41A8
	void SelectAll() { }

	// RVA: 0x2FE41A8
	void SelectNone() { }

	// RVA: 0x2FE360C
	string get_originalText() { }

	// RVA: 0x309AF8C
	TValueType StringToValue(string str) { }

	// RVA: 0x2FE41A8
	void UpdateValueFromText() { }

	// RVA: 0x2FE41A8
	void UpdateTextFromValue() { }

	// RVA: 0x2FE41A8
	void MoveFocusToCompositeRoot() { }

	// RVA: 0x2FE3054
	bool get_isReadOnly() { }

	// RVA: 0x2FE42A4
	void set_maxLength(int value) { }

	// RVA: -1
	void set_maskChar(Char value) { }

	// RVA: 0x2FE3054
	bool get_isPasswordField() { }

	// RVA: 0x2FE4234
	void set_isPasswordField(bool value) { }

	// RVA: 0x2FE4234
	void set_isDragging(bool value) { }

	// RVA: 0x2FE360C
	string get_text() { }

	// RVA: 0x2FE4574
	void set_text(string value) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void MakeSureScrollViewDoesNotLeakEvents(UnityEngine.UIElements.ChangeEvent<System.Single> evt) { }

	// RVA: 0x2FE41A8
	void SetSingleLine() { }

	// RVA: 0x2FE41A8
	void SetMultiline() { }

	// RVA: 0x2FE4574
	void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e) { }

	// RVA: 0x2FE4574
	void TextElementOnGeometryChangedEvent(GeometryChangedEvent e) { }

	// RVA: 0x2FE4574
	void OnInputCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x309AF8C
	bool AcceptCharacter(Char c) { }

	// RVA: 0x2FE4234
	void UpdateScrollOffset(bool isBackspace) { }

	// RVA: -1
	void UpdateScrollOffset(bool isBackspace, bool widthChanged) { }

	// RVA: 0x309AF8C
	Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged) { }

	// RVA: 0x2FE41A8
	void SetScrollViewMode() { }

	// RVA: 0x2FE41A8
	void SetMultilineContainerStyle() { }

	// RVA: 0x2FE41A8
	void RemoveSingleLineComponents() { }

	// RVA: 0x2FE41A8
	void RemoveMultilineComponents() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

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

	// RVA: 0x2FE360C
	TextInputBase get_textInputBase() { }

	// RVA: 0x2FE360C
	string get_text() { }

	// RVA: 0x2FE4574
	void set_text(string value) { }

	// RVA: 0x2FE4574
	void add_onIsReadOnlyChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x2FE4574
	void remove_onIsReadOnlyChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x2FE3054
	bool get_isReadOnly() { }

	// RVA: 0x2FE4234
	void set_isReadOnly(bool value) { }

	// RVA: 0x2FE4234
	void set_isPasswordField(bool value) { }

	// RVA: 0x2FE4234
	void set_autoCorrection(bool value) { }

	// RVA: 0x2FE4234
	void set_hideMobileInput(bool value) { }

	// RVA: 0x2FE42A4
	void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x2FE360C
	ITextEdition get_textEdition() { }

	// RVA: 0x2FE42A4
	void set_maxLength(int value) { }

	// RVA: 0x2FE3054
	bool get_isDelayed() { }

	// RVA: 0x2FE4234
	void set_isDelayed(bool value) { }

	// RVA: -1
	void set_maskChar(Char value) { }

	// RVA: 0x309AF8C
	string ValueToString(TValueType value) { }

	// RVA: 0x309AF8C
	TValueType StringToValue(string str) { }

	// RVA: 0x309AF8C
	void .ctor(string label, int maxLength, Char maskChar, TextInputBase textInputBase) { }

	// RVA: 0x2FE4574
	void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e) { }

	// RVA: 0x2FE4574
	void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x2FE41A8
	void UpdateMixedValueContent() { }

	// RVA: 0x2FE41A8
	void UpdateValueFromText() { }

	// RVA: 0x2FE41A8
	void UpdateTextFromValue() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class TouchScreenTextEditorEventHandler 
{
	// Fields
	private IVisualElementScheduledItem m_TouchKeyboardPoller; // 0x20
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x28
	private bool m_IsClicking; // 0x29

	// Methods

	// RVA: 0x16D4B50
	void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x16D4BB4
	void PollTouchScreenKeyboard() { }

	// RVA: 0x16D4E28
	void DoPollTouchScreenKeyboard() { }

	// RVA: 0x16D580C
	void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x16D5718
	void CloseTouchScreenKeyboard() { }

	// RVA: 0x16D5AC0
	void OpenTouchScreenKeyboard() { }

	// RVA: 0x16D602C
	void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x16D6234
	void OnPointerDownEvent() { }

	// RVA: 0x16D6438
	void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x16D645C
	void OnFocusInEvent() { }

	// RVA: 0x16D6624
	void OnFocusOutEvent(FocusOutEvent evt) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16D7268
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x16D72BC
	void .ctor() { }

}

// Namespace: 
private class IntegerInput 
{
	// Methods

	// RVA: 0x16D7310
	IntegerField get_parentIntegerField() { }

	// RVA: 0x16D6F9C
	void .ctor() { }

	// RVA: 0x16D7394
	string get_allowedCharacters() { }

	// RVA: 0x16D7410
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x16D7734
	string ValueToString(int v) { }

	// RVA: 0x16D778C
	int StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class IntegerField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x16D6AE0
	IntegerInput get_integerInput() { }

	// RVA: 0x16D6B98
	string ValueToString(int v) { }

	// RVA: 0x16D6C58
	int StringToValue(string str) { }

	// RVA: 0x16D6D94
	void .ctor() { }

	// RVA: 0x16D6DA0
	void .ctor(string label, int maxLength) { }

	// RVA: 0x16D7038
	bool CanTryParse(string textString) { }

	// RVA: 0x16D7064
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x16D7168
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16D79FC
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x16D7A50
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Label 
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x16D783C
	void .ctor() { }

	// RVA: 0x16D7898
	void .ctor(string text) { }

	// RVA: 0x16D7984
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16D7B90
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x16D7BE4
	void .ctor() { }

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

	// RVA: 0x16D7A58
	System.Func<UnityEngine.UIElements.VisualElement> get_makeItem() { }

	// RVA: 0x16D7A60
	System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem() { }

	// RVA: 0x16D7A68
	System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem() { }

	// RVA: 0x16D7A70
	System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem() { }

	// RVA: 0x16D7A78
	bool HasValidDataAndBindings() { }

	// RVA: 0x16D7ABC
	CollectionViewController CreateViewController() { }

	// RVA: 0x16D7B14
	void .ctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16D8374
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x16D83C8
	void .ctor() { }

}

// Namespace: 
private class LongInput 
{
	// Methods

	// RVA: 0x16D841C
	LongField get_parentLongField() { }

	// RVA: 0x16D80A8
	void .ctor() { }

	// RVA: 0x16D84A0
	string get_allowedCharacters() { }

	// RVA: 0x16D851C
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Int64 startValue) { }

	// RVA: 0x16D8870
	Int64 ClampMinMaxLongValue(Int64 niceDelta, Int64 value) { }

	// RVA: 0x16D8914
	string ValueToString(Int64 v) { }

	// RVA: 0x16D896C
	Int64 StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class LongField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x16D7BEC
	LongInput get_longInput() { }

	// RVA: 0x16D7CA4
	string ValueToString(Int64 v) { }

	// RVA: 0x16D7D64
	Int64 StringToValue(string str) { }

	// RVA: 0x16D7EA0
	void .ctor() { }

	// RVA: 0x16D7EAC
	void .ctor(string label, int maxLength) { }

	// RVA: 0x16D8144
	bool CanTryParse(string textString) { }

	// RVA: 0x16D8170
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, Int64 startValue) { }

	// RVA: 0x16D8274
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16DBAD0
	void .ctor() { }

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

	// RVA: 0x16DBB24
	void .ctor() { }

	// RVA: 0x16DBD6C
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

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

	// RVA: 0x16D8A1C
	VisualElement get_dragElement() { }

	// RVA: 0x16D8A24
	void set_dragElement(VisualElement value) { }

	// RVA: 0x16D8A34
	VisualElement get_dragMinThumb() { }

	// RVA: 0x16D8A3C
	void set_dragMinThumb(VisualElement value) { }

	// RVA: 0x16D8A4C
	VisualElement get_dragMaxThumb() { }

	// RVA: 0x16D8A54
	void set_dragMaxThumb(VisualElement value) { }

	// RVA: 0x16D8A64
	UnityEngine.UIElements.ClampedDragger<System.Single> get_clampedDragger() { }

	// RVA: 0x16D8A6C
	void set_clampedDragger(UnityEngine.UIElements.ClampedDragger<System.Single> value) { }

	// RVA: 0x16D8A7C
	float get_minValue() { }

	// RVA: 0x16D8A8C
	void set_minValue(float value) { }

	// RVA: 0x16D8B94
	float get_maxValue() { }

	// RVA: 0x16D8BB8
	void set_maxValue(float value) { }

	// RVA: 0x16D8C88
	Vector2 get_value() { }

	// RVA: 0x16D8CF0
	void set_value(Vector2 value) { }

	// RVA: 0x16D8D94
	void SetValueWithoutNotify(Vector2 newValue) { }

	// RVA: 0x16D9CE4
	float get_lowLimit() { }

	// RVA: 0x16D9CEC
	void set_lowLimit(float value) { }

	// RVA: 0x16D9E5C
	float get_highLimit() { }

	// RVA: 0x16D9E64
	void set_highLimit(float value) { }

	// RVA: 0x16D9FD4
	void .ctor() { }

	// RVA: 0x16D9FF4
	void .ctor(string label, float minValue, float maxValue, float minLimit, float maxLimit) { }

	// RVA: 0x16D8B5C
	Vector2 ClampValues(Vector2 valueToClamp) { }

	// RVA: 0x16DA700
	void UpdateDragElementPosition(GeometryChangedEvent evt) { }

	// RVA: 0x16D8E40
	void UpdateDragElementPosition() { }

	// RVA: 0x16DA768
	void UpdateDragThumbsRect() { }

	// RVA: 0x16DA758
	float SliderLerpUnclamped(float a, float b, float interpolant) { }

	// RVA: 0x16DA748
	float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	// RVA: 0x16DAEB0
	float ComputeValueFromPosition(float positionToConvert) { }

	// RVA: 0x16DB054
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x16DB1A4
	void SetSliderValueFromDrag() { }

	// RVA: 0x16DB3E4
	void SetSliderValueFromClick() { }

	// RVA: 0x16DB23C
	void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos) { }

	// RVA: 0x16DB614
	void UpdateMixedValueContent() { }

	// RVA: 0x16DB618
	void RegisterEditingCallbacks() { }

	// RVA: 0x16DB76C
	void UnregisterEditingCallbacks() { }

	// RVA: 0x16DB8C0
	void .cctor() { }

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

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass15_0 
{
	// Fields
	public VisualTreeAsset asset; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE360C
	VisualElement <Init>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass15_1 
{
	// Fields
	public VisualTreeAsset asset; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE360C
	VisualElement <Init>b__1() { }

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

	// RVA: 0x309AF8C
	Length ParseLength(string str, Length defaultValue) { }

	// RVA: -1
	void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

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

	// RVA: 0x16DBF20
	string get_name() { }

	// RVA: 0x16DBF28
	void set_name(string value) { }

	// RVA: 0x16DBFE0
	string get_title() { }

	// RVA: 0x16DBFE8
	void set_title(string value) { }

	// RVA: 0x16DC064
	Background get_icon() { }

	// RVA: 0x16DC070
	int get_index() { }

	// RVA: 0x16DC1F8
	int get_displayIndex() { }

	// RVA: 0x16DC3D8
	int get_visibleIndex() { }

	// RVA: 0x16DC4B0
	bool get_visible() { }

	// RVA: 0x16DC4B8
	void set_visible(bool value) { }

	// RVA: 0x16DC50C
	Length get_width() { }

	// RVA: 0x16DC514
	void set_width(Length value) { }

	// RVA: 0x16DC5CC
	Length get_minWidth() { }

	// RVA: 0x16DC5D4
	void set_minWidth(Length value) { }

	// RVA: 0x16DC638
	Length get_maxWidth() { }

	// RVA: 0x16DC640
	void set_maxWidth(Length value) { }

	// RVA: 0x16DC6A4
	float get_desiredWidth() { }

	// RVA: 0x16DC59C
	void set_desiredWidth(float value) { }

	// RVA: 0x16DC6AC
	bool get_sortable() { }

	// RVA: 0x16DC6B4
	void set_sortable(bool value) { }

	// RVA: 0x16DC708
	bool get_stretchable() { }

	// RVA: 0x16DC710
	void set_stretchable(bool value) { }

	// RVA: 0x16DC764
	bool get_optional() { }

	// RVA: 0x16DC76C
	void set_optional(bool value) { }

	// RVA: 0x16DC7C0
	bool get_resizable() { }

	// RVA: 0x16DC7C8
	void set_resizable(bool value) { }

	// RVA: 0x16DC81C
	System.Func<UnityEngine.UIElements.VisualElement> get_makeHeader() { }

	// RVA: 0x16DC824
	void set_makeHeader(System.Func<UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x16DC8A0
	System.Action<UnityEngine.UIElements.VisualElement> get_bindHeader() { }

	// RVA: 0x16DC8A8
	System.Action<UnityEngine.UIElements.VisualElement> get_unbindHeader() { }

	// RVA: 0x16DC8B0
	System.Action<UnityEngine.UIElements.VisualElement> get_destroyHeader() { }

	// RVA: 0x16DC8B8
	System.Func<UnityEngine.UIElements.VisualElement> get_makeCell() { }

	// RVA: 0x16DC8C0
	void set_makeCell(System.Func<UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x16DC93C
	System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindCell() { }

	// RVA: 0x16DC944
	System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindCell() { }

	// RVA: 0x16DC94C
	System.Action<UnityEngine.UIElements.VisualElement> get_destroyCell() { }

	// RVA: 0x16DC954
	Columns get_collection() { }

	// RVA: 0x16DC95C
	void set_collection(Columns value) { }

	// RVA: 0x16DC964
	void add_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x16DCA18
	void remove_changed(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x16DCACC
	void add_resized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16DCB80
	void remove_resized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16DBFA0
	void NotifyChange(ColumnDataType type) { }

	// RVA: 0x16DCC34
	float GetWidth(float layoutWidth) { }

	// RVA: 0x16DCC58
	float GetMaxWidth(float layoutWidth) { }

	// RVA: 0x16DCC7C
	float GetMinWidth(float layoutWidth) { }

	// RVA: 0x16DCCA0
	void .ctor() { }

	// RVA: 0x16DCD14
	void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0 
{
	// Fields
	public float totalColumnWidth; // 0x10
	public ColumnLayout <>4__this; // 0x18

	// Methods

	// RVA: 0x16E0BE4
	void .ctor() { }

	// RVA: 0x16E2180
	void <RecomputeToMaxWidthProportionally>b__1(Column c) { }

}

// Namespace: 
private sealed class <>c__DisplayClass54_0 
{
	// Fields
	public float totalColumnsWidth; // 0x10
	public ColumnLayout <>4__this; // 0x18

	// Methods

	// RVA: 0x16E0D94
	void .ctor() { }

	// RVA: 0x16E21C0
	void <RecomputeToMinWidthProportionally>b__1(Column c) { }

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

	// RVA: 0x16DCD8C
	Columns get_columns() { }

	// RVA: 0x16DCD94
	float get_columnsWidth() { }

	// RVA: 0x16DD094
	float get_layoutWidth() { }

	// RVA: 0x16DD09C
	float get_minColumnsWidth() { }

	// RVA: 0x16DD0A4
	float get_maxColumnsWidth() { }

	// RVA: 0x16DD0AC
	bool get_hasStretchableColumns() { }

	// RVA: 0x16DD100
	bool get_hasRelativeWidthColumns() { }

	// RVA: 0x16DD178
	void add_layoutRequested(Action value) { }

	// RVA: 0x16DD21C
	void remove_layoutRequested(Action value) { }

	// RVA: 0x16DD2C0
	void .ctor(Columns columns) { }

	// RVA: 0x16DDDA8
	void Dirty() { }

	// RVA: 0x16DD8B0
	void OnColumnAdded(Column column, int index) { }

	// RVA: 0x16DDF50
	void OnColumnRemoved(Column column) { }

	// RVA: 0x16DE178
	void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x16DE1C8
	bool RequiresLayoutUpdate(ColumnDataType type) { }

	// RVA: 0x16DE1E0
	void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x16DE258
	void OnColumnResized(Column column) { }

	// RVA: 0x16DE264
	bool IsClamped(float value, float min, float max) { }

	// RVA: 0x16DE278
	void DoLayout(float width) { }

	// RVA: 0x16DFAB4
	void StretchResizeColumns(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x16DFBA0
	void DistributeOverflow(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x16DFE24
	void DistributeExcess(System.Collections.Generic.List<UnityEngine.UIElements.Column> stretchableColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> fixedColumns, System.Collections.Generic.List<UnityEngine.UIElements.Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	// RVA: 0x16E0770
	float RecomputeToMaxWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x16E02CC
	float RecomputeToMinWidthProportionally(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x16E018C
	float RecomputeToDesiredWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	// RVA: 0x16E0D9C
	float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	// RVA: 0x16E05CC
	float RecomputeToMinWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x16E0A54
	float RecomputeToMaxWidth(System.Collections.Generic.List<UnityEngine.UIElements.Column> columns, float distributedDelta, bool setDesiredWidthOnly) { }

	// RVA: 0x16E0F5C
	void ResizeToFit(float width) { }

	// RVA: 0x16E0BEC
	void ResizeColumn(Column column, float width, bool setDesiredWidthOnly) { }

	// RVA: 0x16E1260
	void BeginDragResize(Column column, float pos, bool previewMode) { }

	// RVA: 0x16E16A4
	float GetDesiredPosition(Column column) { }

	// RVA: 0x16DF9EC
	float GetDesiredWidth(Column c) { }

	// RVA: 0x16E1838
	void DragResize(Column column, float pos) { }

	// RVA: 0x16E1AC0
	void EndDragResize(Column column, bool cancelled) { }

	// RVA: 0x16DF1D0
	void UpdateCache() { }

	// RVA: 0x16DF610
	void UpdateMinAndMaxColumnsWidth() { }

	// RVA: 0x16DDDF8
	void ClearCache() { }

	// RVA: 0x16E1FC0
	int <DoLayout>b__49_0(Column c1, Column c2) { }

	// RVA: 0x16E2030
	int <DoLayout>b__49_1(Column c1, Column c2) { }

	// RVA: 0x16E20A0
	int <RecomputeToMaxWidthProportionally>b__53_0(Column c1, Column c2) { }

	// RVA: 0x16E2110
	int <RecomputeToMinWidthProportionally>b__54_0(Column c1, Column c2) { }

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

	// RVA: 0x2FE41A8
	void .ctor() { }

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
	void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.Columns.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.UIElements.Column> <>9__76_0; // 0x8

	// Methods

	// RVA: 0x16E45C4
	void .cctor() { }

	// RVA: 0x16E4630
	void .ctor() { }

	// RVA: 0x16E4638
	bool <UpdateVisibleColumns>b__76_0(Column c) { }

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

	// RVA: 0x16E2200
	string get_primaryColumnName() { }

	// RVA: 0x16E2208
	void set_primaryColumnName(string value) { }

	// RVA: 0x16E22B4
	bool get_reorderable() { }

	// RVA: 0x16E22BC
	void set_reorderable(bool value) { }

	// RVA: 0x16E2308
	bool get_resizable() { }

	// RVA: 0x16E2310
	void set_resizable(bool value) { }

	// RVA: 0x16E235C
	bool get_resizePreview() { }

	// RVA: 0x16E2364
	void set_resizePreview(bool value) { }

	// RVA: 0x16DC324
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_displayList() { }

	// RVA: 0x16DC48C
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.Column> get_visibleList() { }

	// RVA: 0x16E2724
	void add_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value) { }

	// RVA: 0x16E27D8
	void remove_changed(System.Action<UnityEngine.UIElements.ColumnsDataType> value) { }

	// RVA: 0x16E288C
	StretchMode get_stretchMode() { }

	// RVA: 0x16E2894
	void set_stretchMode(StretchMode value) { }

	// RVA: 0x16DDB8C
	void add_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value) { }

	// RVA: 0x16E28E0
	void remove_columnAdded(System.Action<UnityEngine.UIElements.Column,System.Int32> value) { }

	// RVA: 0x16DDC40
	void add_columnRemoved(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16E2994
	void remove_columnRemoved(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16E2A48
	void add_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x16E2AFC
	void remove_columnChanged(System.Action<UnityEngine.UIElements.Column,UnityEngine.UIElements.ColumnDataType> value) { }

	// RVA: 0x16E2BB0
	void add_columnResized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16E2C64
	void remove_columnResized(System.Action<UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16DDCF4
	void add_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value) { }

	// RVA: 0x16E2D18
	void remove_columnReordered(System.Action<UnityEngine.UIElements.Column,System.Int32,System.Int32> value) { }

	// RVA: 0x16E2DCC
	bool IsPrimary(Column column) { }

	// RVA: 0x16DF938
	System.Collections.Generic.IEnumerator<UnityEngine.UIElements.Column> GetEnumerator() { }

	// RVA: 0x16E2ED0
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x16E2F84
	void Add(Column item) { }

	// RVA: 0x16E341C
	void Clear() { }

	// RVA: 0x16E3914
	bool Contains(Column item) { }

	// RVA: 0x16E39CC
	bool Contains(string name) { }

	// RVA: 0x16E3CE0
	void CopyTo(Column[] array, int arrayIndex) { }

	// RVA: 0x16E35E0
	bool Remove(Column column) { }

	// RVA: 0x16E3DA0
	void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x16E3F28
	void OnColumnResized(Column column) { }

	// RVA: 0x16DDAD8
	int get_Count() { }

	// RVA: 0x16E3F44
	bool get_IsReadOnly() { }

	// RVA: 0x16DC140
	int IndexOf(Column column) { }

	// RVA: 0x16E3044
	void Insert(int index, Column column) { }

	// RVA: 0x16DD7FC
	Column get_Item(int index) { }

	// RVA: 0x16E3FFC
	Column get_Item(string name) { }

	// RVA: 0x16E4310
	void ReorderDisplay(int from, int to) { }

	// RVA: 0x16E23B0
	void InitOrderColumns() { }

	// RVA: 0x16E3E84
	void DirtyVisibleColumns() { }

	// RVA: 0x16E2450
	void UpdateVisibleColumns() { }

	// RVA: 0x16E227C
	void NotifyChange(ColumnsDataType type) { }

	// RVA: 0x16E4524
	void .ctor() { }

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

	// RVA: 0x16E4654
	void add_columnSortingChanged(Action value) { }

	// RVA: 0x16E46F8
	void remove_columnSortingChanged(Action value) { }

	// RVA: 0x16E479C
	void add_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16E4850
	void remove_headerContextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16E4904
	MultiColumnCollectionHeader get_header() { }

	// RVA: 0x16E490C
	void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x309AF8C
	void BindCellItem(VisualElement ve, int rowIndex, Column column, T item) { }

	// RVA: 0x16E4F7C
	void UnbindCellItem(VisualElement ve, int rowIndex, Column column) { }

	// RVA: 0x16E4FC4
	VisualElement DefaultMakeCellItem() { }

	// RVA: 0x309AF8C
	void DefaultBindCellItem(VisualElement ve, Column column, T item) { }

	// RVA: 0x16E509C
	VisualElement MakeItem() { }

	// RVA: 0x309AF8C
	void BindItem(VisualElement element, int index, T item) { }

	// RVA: 0x16E550C
	void UnbindItem(VisualElement element, int index) { }

	// RVA: 0x16E5924
	void DestroyItem(VisualElement element) { }

	// RVA: 0x16E5D5C
	void PrepareView(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x16E6054
	void Dispose() { }

	// RVA: 0x16E67AC
	void OnHorizontalScrollerValueChanged(float v) { }

	// RVA: 0x16E67CC
	void OnViewportGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x16E6C4C
	void OnColumnContainerGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x16E6A98
	void UpdateContentContainer(BaseVerticalCollectionView collectionView) { }

	// RVA: 0x16E6C54
	void OnColumnSortingChanged() { }

	// RVA: 0x16E6C70
	void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column) { }

	// RVA: 0x16E6C8C
	void OnColumnResized(int index, float width) { }

	// RVA: 0x16E705C
	void OnColumnAdded(Column column, int index) { }

	// RVA: 0x16E707C
	void OnColumnRemoved(Column column) { }

	// RVA: 0x16E709C
	void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x16E70D4
	void OnColumnsChanged(Column column, ColumnDataType type) { }

	// RVA: 0x16E7114
	void OnColumnChanged(ColumnsDataType type) { }

	// RVA: 0x16E7150
	void OnViewDataRestored() { }

	// RVA: 0x16E7170
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16E83B0
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xD8
	private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns> m_Columns; // 0xE0
	private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions> m_SortColumnDescriptions; // 0xE8

	// Methods

	// RVA: 0x16E8404
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16E8568
	void .ctor() { }

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

	// RVA: 0x16E7398
	MultiColumnListViewController get_viewController() { }

	// RVA: 0x16E7428
	Columns get_columns() { }

	// RVA: 0x16E7430
	void set_columns(Columns value) { }

	// RVA: 0x16E7544
	SortColumnDescriptions get_sortColumnDescriptions() { }

	// RVA: 0x16E754C
	void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x16E7818
	void set_sortingEnabled(bool value) { }

	// RVA: 0x16E792C
	void .ctor() { }

	// RVA: 0x16E7A14
	void .ctor(Columns columns) { }

	// RVA: 0x16E7CCC
	CollectionViewController CreateViewController() { }

	// RVA: 0x16E7D48
	void SetViewController(CollectionViewController controller) { }

	// RVA: 0x16E8340
	void CreateVirtualizationController() { }

	// RVA: 0x16E77FC
	void RaiseColumnSortingChanged() { }

	// RVA: 0x16E8394
	void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16E94F4
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private readonly UxmlBoolAttributeDescription m_SortingEnabled; // 0xB8
	private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.Columns> m_Columns; // 0xC0
	private readonly UnityEngine.UIElements.UxmlObjectAttributeDescription<UnityEngine.UIElements.SortColumnDescriptions> m_SortColumnDescriptions; // 0xC8

	// Methods

	// RVA: 0x16E9548
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16E96AC
	void .ctor() { }

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

	// RVA: 0x16E86AC
	MultiColumnTreeViewController get_viewController() { }

	// RVA: 0x16E873C
	Columns get_columns() { }

	// RVA: 0x16E8744
	void set_columns(Columns value) { }

	// RVA: 0x16E8858
	SortColumnDescriptions get_sortColumnDescriptions() { }

	// RVA: 0x16E8860
	void set_sortColumnDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x16E89CC
	void set_sortingEnabled(bool value) { }

	// RVA: 0x16E8AE0
	void .ctor() { }

	// RVA: 0x16E8BC8
	void .ctor(Columns columns) { }

	// RVA: 0x16E8DF4
	CollectionViewController CreateViewController() { }

	// RVA: 0x16E8E8C
	void SetViewController(CollectionViewController controller) { }

	// RVA: 0x16E9484
	void CreateVirtualizationController() { }

	// RVA: 0x16E89B0
	void RaiseColumnSortingChanged() { }

	// RVA: 0x16E94D8
	void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column) { }

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

	// RVA: 0x2FE41A8
	void .ctor() { }

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
	void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class SortColumnDescription 
{
	// Fields
	private int m_ColumnIndex; // 0x10
	private string m_ColumnName; // 0x18
	private SortDirection m_SortDirection; // 0x20
	private Column <column>k__BackingField; // 0x28
	private System.Action<UnityEngine.UIElements.SortColumnDescription> changed; // 0x30

	// Methods

	// RVA: 0x16E97F0
	string get_columnName() { }

	// RVA: 0x16E97F8
	void set_columnName(string value) { }

	// RVA: 0x16E986C
	int get_columnIndex() { }

	// RVA: 0x16E9874
	void set_columnIndex(int value) { }

	// RVA: 0x16E98A8
	Column get_column() { }

	// RVA: 0x16E98B0
	void set_column(Column value) { }

	// RVA: 0x16E98B8
	SortDirection get_direction() { }

	// RVA: 0x16E98C0
	void set_direction(SortDirection value) { }

	// RVA: 0x16E98F4
	void add_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value) { }

	// RVA: 0x16E99A8
	void remove_changed(System.Action<UnityEngine.UIElements.SortColumnDescription> value) { }

	// RVA: 0x16E9A5C
	void .ctor() { }

	// RVA: 0x16E9A6C
	void .ctor(int columnIndex, SortDirection direction) { }

	// RVA: 0x16E9B0C
	void .ctor(string columnName, SortDirection direction) { }

}

// Namespace: 
internal class UxmlObjectFactory<T0> 
{
	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
internal class UxmlObjectTraits<T0> 
{
	// Fields
	private readonly UnityEngine.UIElements.UxmlObjectListAttributeDescription<UnityEngine.UIElements.SortColumnDescription> m_SortColumnDescriptions; // 0x0

	// Methods

	// RVA: -1
	void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class SortColumnDescriptions 
{
	// Fields
	private readonly System.Collections.Generic.IList<UnityEngine.UIElements.SortColumnDescription> m_Descriptions; // 0x10
	private Action changed; // 0x18

	// Methods

	// RVA: 0x16E9BC4
	void add_changed(Action value) { }

	// RVA: 0x16E9C68
	void remove_changed(Action value) { }

	// RVA: 0x16E9D0C
	System.Collections.Generic.IEnumerator<UnityEngine.UIElements.SortColumnDescription> GetEnumerator() { }

	// RVA: 0x16E9DC0
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x16E9E74
	void Add(SortColumnDescription item) { }

	// RVA: 0x16E769C
	void Clear() { }

	// RVA: 0x16EA428
	bool Contains(SortColumnDescription item) { }

	// RVA: 0x16EA4E0
	void CopyTo(SortColumnDescription[] array, int arrayIndex) { }

	// RVA: 0x16EA204
	bool Remove(SortColumnDescription desc) { }

	// RVA: 0x16EA5A0
	void OnDescriptionChanged(SortColumnDescription desc) { }

	// RVA: 0x16EA5BC
	int get_Count() { }

	// RVA: 0x16EA670
	bool get_IsReadOnly() { }

	// RVA: 0x16E9F34
	void Insert(int index, SortColumnDescription desc) { }

	// RVA: 0x16E7C40
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass26_0 
{
	// Fields
	public T item; // 0x0
	public UnityEngine.UIElements.PopupField<T> <>4__this; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void <AddMenuItems>b__0() { }

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

	// RVA: 0x2FE360C
	string GetValueToDisplay() { }

	// RVA: 0x309AF8C
	string GetListItemToDisplay(T value) { }

	// RVA: 0x309AF8C
	T get_value() { }

	// RVA: 0x309AF8C
	void set_value(T value) { }

	// RVA: 0x309AF8C
	void SetValueWithoutNotify(T newValue) { }

	// RVA: 0x2FE42A4
	void set_index(int value) { }

	// RVA: 0x2FE4574
	void .ctor(string label) { }

	// RVA: 0x2FE4574
	void AddMenuItems(IGenericMenu menu) { }

	// RVA: 0x309AF8C
	void ChangeValueFromMenu(T menuItem) { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16EA92C
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x16EA980
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class PopupWindow 
{
	// Fields
	private VisualElement m_ContentContainer; // 0x4A0
	public static readonly string ussClassName; // 0x0
	public static readonly string contentUssClassName; // 0x8

	// Methods

	// RVA: 0x16EA728
	void .ctor() { }

	// RVA: 0x16EA86C
	VisualElement get_contentContainer() { }

	// RVA: 0x16EA874
	void .cctor() { }

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

	// RVA: 0x16EB384
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16EB56C
	void .ctor() { }

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

	// RVA: 0x16EA988
	void set_title(string value) { }

	// RVA: 0x16EA9B0
	float get_lowValue() { }

	// RVA: 0x16EA9B8
	void set_lowValue(float value) { }

	// RVA: 0x16EAB4C
	float get_highValue() { }

	// RVA: 0x16EAB54
	void set_highValue(float value) { }

	// RVA: 0x16EAB60
	void .ctor() { }

	// RVA: 0x16EAE70
	void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x16EAEA0
	float get_value() { }

	// RVA: 0x16EAEA8
	void set_value(float value) { }

	// RVA: 0x16EB0F8
	void SetValueWithoutNotify(float newValue) { }

	// RVA: 0x16EA9C4
	void SetProgress(float p) { }

	// RVA: 0x16EB12C
	float CalculateProgressWidth(float width) { }

	// RVA: 0x16EB1BC
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16EB828
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class ProgressBar 
{
	// Methods

	// RVA: 0x16EB7A8
	void .ctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16EC4A0
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x88

	// Methods

	// RVA: 0x16EC4F4
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16EC608
	void .ctor() { }

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

	// RVA: 0x16EB87C
	bool get_value() { }

	// RVA: 0x16EB8E4
	void set_value(bool value) { }

	// RVA: 0x16EBAEC
	void .ctor() { }

	// RVA: 0x16EBAF4
	void .ctor(string label) { }

	// RVA: 0x16EBDB8
	void OnOptionAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x16EBE5C
	void OnOptionDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x16EBF00
	void InitLabel() { }

	// RVA: 0x16EBF88
	void ToggleValue() { }

	// RVA: 0x16EBFD8
	void UnityEngine.UIElements.IGroupBoxOption.SetSelected(bool selected) { }

	// RVA: 0x16EBFE8
	void SetValueWithoutNotify(bool newValue) { }

	// RVA: 0x16EB9D8
	void UpdateCheckmark() { }

	// RVA: 0x16EC010
	void UpdateMixedValueContent() { }

	// RVA: 0x16EC0EC
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16ED8B4
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Choices; // 0x88

	// Methods

	// RVA: 0x16ED908
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16EDA34
	void .ctor() { }

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

	// RVA: 0x16EC6C0
	void set_choices(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x16ED064
	VisualElement get_contentContainer() { }

	// RVA: 0x16ED074
	void .ctor() { }

	// RVA: 0x16ED080
	void .ctor(string label, System.Collections.Generic.List<System.String> radioButtonChoices) { }

	// RVA: 0x16ED2EC
	void RadioButtonValueChangedCallback(UnityEngine.UIElements.ChangeEvent<System.Boolean> evt) { }

	// RVA: 0x16ED43C
	void SetValueWithoutNotify(int newValue) { }

	// RVA: 0x16ECDC8
	void UpdateRadioButtons() { }

	// RVA: 0x16ED4B0
	void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x16ED678
	void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x16ED7FC
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16EDDB8
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlLongAttributeDescription m_Delay; // 0x98
	private UxmlLongAttributeDescription m_Interval; // 0xA0

	// Methods

	// RVA: 0x16EDE0C
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16EDFA8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class RepeatButton 
{
	// Fields
	private Clickable m_Clickable; // 0x4A0
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x16EDAEC
	void .ctor() { }

	// RVA: 0x16EDBBC
	void .ctor(Action clickEvent, Int64 delay, Int64 interval) { }

	// RVA: 0x16EDC70
	void SetAction(Action clickEvent, Int64 delay, Int64 interval) { }

	// RVA: 0x16EDD20
	void AddAction(Action clickEvent) { }

	// RVA: 0x16EDD40
	void .cctor() { }

}

// Namespace: 
private class ScrollerSlider 
{
	// Methods

	// RVA: 0x16EEABC
	void .ctor(float start, float end, SliderDirection direction, float pageSize) { }

	// RVA: 0x16EF0C0
	float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16EF0F8
	void .ctor() { }

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

	// RVA: 0x16EF14C
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16EF334
	void .ctor() { }

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

	// RVA: 0x16EE098
	void add_valueChanged(System.Action<System.Single> value) { }

	// RVA: 0x16EE150
	void remove_valueChanged(System.Action<System.Single> value) { }

	// RVA: 0x16EE208
	Slider get_slider() { }

	// RVA: 0x16EE210
	void set_slider(Slider value) { }

	// RVA: 0x16EE220
	RepeatButton get_lowButton() { }

	// RVA: 0x16EE228
	void set_lowButton(RepeatButton value) { }

	// RVA: 0x16EE238
	RepeatButton get_highButton() { }

	// RVA: 0x16EE240
	void set_highButton(RepeatButton value) { }

	// RVA: 0x16EE250
	float get_value() { }

	// RVA: 0x16EE278
	void set_value(float value) { }

	// RVA: 0x16EE2A0
	float get_lowValue() { }

	// RVA: 0x16EE308
	void set_lowValue(float value) { }

	// RVA: 0x16EE37C
	float get_highValue() { }

	// RVA: 0x16EE3E4
	void set_highValue(float value) { }

	// RVA: 0x16EE458
	void set_direction(SliderDirection value) { }

	// RVA: 0x16EE6C0
	void .ctor() { }

	// RVA: 0x16EE6D4
	void .ctor(float lowValue, float highValue, System.Action<System.Single> valueChanged, SliderDirection direction) { }

	// RVA: 0x16EEB50
	void Adjust(float factor) { }

	// RVA: 0x16EEBCC
	void OnSliderValueChange(UnityEngine.UIElements.ChangeEvent<System.Single> evt) { }

	// RVA: 0x16EECC4
	void ScrollPageUp() { }

	// RVA: 0x16EEDD8
	void ScrollPageDown() { }

	// RVA: 0x16EECCC
	void ScrollPageUp(float factor) { }

	// RVA: 0x16EEDE0
	void ScrollPageDown(float factor) { }

	// RVA: 0x16EEEEC
	void .cctor() { }

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

	// RVA: 0x16F6CAC
	void .ctor() { }

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

	// RVA: 0x16F6D00
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16F7118
	void .ctor() { }

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

	// RVA: 0x16EF5DC
	ScrollerVisibility get_horizontalScrollerVisibility() { }

	// RVA: 0x16EF5E4
	void set_horizontalScrollerVisibility(ScrollerVisibility value) { }

	// RVA: 0x16EFE18
	ScrollerVisibility get_verticalScrollerVisibility() { }

	// RVA: 0x16EFE20
	void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	// RVA: 0x16EFF78
	void set_showHorizontal(bool value) { }

	// RVA: 0x16EFF94
	void set_showVertical(bool value) { }

	// RVA: 0x16EF740
	bool get_needsHorizontal() { }

	// RVA: 0x16EF7F0
	bool get_needsVertical() { }

	// RVA: 0x16F0068
	bool get_isVerticalScrollDisplayed() { }

	// RVA: 0x16F012C
	bool get_isHorizontalScrollDisplayed() { }

	// RVA: 0x16F01F0
	Vector2 get_scrollOffset() { }

	// RVA: 0x16F0264
	void set_scrollOffset(Vector2 value) { }

	// RVA: 0x16F07B0
	void set_horizontalPageSize(float value) { }

	// RVA: 0x16F0A1C
	void set_verticalPageSize(float value) { }

	// RVA: 0x16F0C88
	float get_mouseWheelScrollSize() { }

	// RVA: 0x16F0C90
	void set_mouseWheelScrollSize(float value) { }

	// RVA: 0x16EFFB0
	float get_scrollableWidth() { }

	// RVA: 0x16F000C
	float get_scrollableHeight() { }

	// RVA: 0x16F0D50
	bool get_hasInertia() { }

	// RVA: 0x16F0D60
	float get_scrollDecelerationRate() { }

	// RVA: 0x16F0D68
	void set_scrollDecelerationRate(float value) { }

	// RVA: 0x16F0D7C
	float get_elasticity() { }

	// RVA: 0x16F0D84
	void set_elasticity(float value) { }

	// RVA: 0x16F0D98
	TouchScrollBehavior get_touchScrollBehavior() { }

	// RVA: 0x16F0DA0
	void set_touchScrollBehavior(TouchScrollBehavior value) { }

	// RVA: 0x16F0F58
	NestedInteractionKind get_nestedInteractionKind() { }

	// RVA: 0x16F0F60
	void set_nestedInteractionKind(NestedInteractionKind value) { }

	// RVA: 0x16F0F68
	void set_elasticAnimationIntervalMs(Int64 value) { }

	// RVA: 0x16F1130
	void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) { }

	// RVA: 0x16F1178
	void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) { }

	// RVA: 0x16F07B8
	void UpdateHorizontalSliderPageSize() { }

	// RVA: 0x16F0A24
	void UpdateVerticalSliderPageSize() { }

	// RVA: 0x16F0488
	void UpdateContentViewTransform() { }

	// RVA: 0x16F11C0
	void ScrollTo(VisualElement child) { }

	// RVA: 0x16F16D4
	float GetXDeltaOffset(VisualElement child) { }

	// RVA: 0x16F1494
	float GetYDeltaOffset(VisualElement child) { }

	// RVA: 0x16F1914
	float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) { }

	// RVA: 0x16F1964
	VisualElement get_contentViewport() { }

	// RVA: 0x16F196C
	Scroller get_horizontalScroller() { }

	// RVA: 0x16F1974
	Scroller get_verticalScroller() { }

	// RVA: 0x16F197C
	VisualElement get_contentContainer() { }

	// RVA: 0x16F1984
	void .ctor() { }

	// RVA: 0x16F198C
	void .ctor(ScrollViewMode scrollViewMode) { }

	// RVA: 0x16F29E0
	ScrollViewMode get_mode() { }

	// RVA: 0x16F29E8
	void set_mode(ScrollViewMode value) { }

	// RVA: 0x16F2670
	void SetScrollViewMode(ScrollViewMode mode) { }

	// RVA: 0x16F29FC
	void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x16F3068
	void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x16F3648
	void OnPointerCapture(PointerCaptureEvent evt) { }

	// RVA: 0x16F37CC
	void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x16F3998
	void OnGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x16F3B90
	void ScheduleResetLayoutPass() { }

	// RVA: 0x16F363C
	void ResetLayoutPass() { }

	// RVA: 0x16F3DB8
	float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) { }

	// RVA: 0x16F3EC8
	void ComputeInitialSpringBackVelocity() { }

	// RVA: 0x16F4130
	void SpringBack() { }

	// RVA: 0x16F42DC
	void ApplyScrollInertia() { }

	// RVA: 0x16F4650
	void PostPointerUpAnimation() { }

	// RVA: 0x16F47E8
	void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x16F4D90
	void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x16F5668
	void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x16F56D4
	void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x16F4A8C
	void InitTouchScrolling(Vector2 position) { }

	// RVA: 0x16F5008
	TouchScrollingResult ComputeTouchScrolling(Vector2 position) { }

	// RVA: 0x16F578C
	bool ApplyTouchScrolling(Vector2 newScrollOffset) { }

	// RVA: 0x16F38B4
	bool ReleaseScrolling(int pointerId, IEventHandler target) { }

	// RVA: 0x16F5A38
	void ExecuteElasticSpringAnimation() { }

	// RVA: 0x16F5CE0
	void AdjustScrollers() { }

	// RVA: 0x16EF8A0
	void UpdateScrollers(bool displayHorizontal, bool displayVertical) { }

	// RVA: 0x16F5E94
	void OnScrollersGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x16F6064
	void OnScrollWheel(WheelEvent evt) { }

	// RVA: 0x16F67BC
	void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	// RVA: 0x16F67C0
	void OnRootPointerUp(PointerUpEvent evt) { }

	// RVA: 0x16F2F60
	void ReadSingleLineHeight() { }

	// RVA: 0x16F6540
	void UpdateElasticBehaviour() { }

	// RVA: 0x16F67C8
	void .cctor() { }

	// RVA: 0x16F6BA8
	void <.ctor>b__126_0(float value) { }

	// RVA: 0x16F6C28
	void <.ctor>b__126_1(float value) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16F8168
	void .ctor() { }

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

	// RVA: 0x16F81BC
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16F844C
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class Slider 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x16F7794
	void .ctor() { }

	// RVA: 0x16EF0B4
	void .ctor(float start, float end, SliderDirection direction, float pageSize) { }

	// RVA: 0x16F77AC
	void .ctor(string label, float start, float end, SliderDirection direction, float pageSize) { }

	// RVA: 0x16F793C
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue) { }

	// RVA: 0x16F7A80
	float SliderLerpUnclamped(float a, float b, float interpolant) { }

	// RVA: 0x16EF0E8
	float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	// RVA: 0x16F7DBC
	float ParseStringToValue(string previousValue, string newValue) { }

	// RVA: 0x16F7E4C
	void ComputeValueFromKey(SliderKey sliderKey, bool isShift) { }

	// RVA: 0x16F8068
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16F96B4
	void .ctor() { }

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

	// RVA: 0x16F9708
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16F999C
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class SliderInt 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x16F8774
	void .ctor() { }

	// RVA: 0x16F878C
	void .ctor(string label, int start, int end, SliderDirection direction, float pageSize) { }

	// RVA: 0x16F891C
	float get_pageSize() { }

	// RVA: 0x16F8970
	void set_pageSize(float value) { }

	// RVA: 0x16F8AB8
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	// RVA: 0x16F8C9C
	int SliderLerpUnclamped(int a, int b, float interpolant) { }

	// RVA: 0x16F8DC8
	float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) { }

	// RVA: 0x16F8DE4
	int ParseStringToValue(string previousValue, string newValue) { }

	// RVA: 0x16F8E70
	void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	// RVA: 0x16F92A0
	void ComputeValueFromKey(SliderKey sliderKey, bool isShift) { }

	// RVA: 0x16F95B4
	void .cctor() { }

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

	// RVA: 0x309AF8C
	T get_value() { }

	// RVA: 0x309AF8C
	void set_value(T value) { }

	// RVA: 0x309AF8C
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, T startValue) { }

	// RVA: 0x2FE41A8
	void StartDragging() { }

	// RVA: 0x2FE41A8
	void StopDragging() { }

}

// Namespace: 
protected abstract class TextValueInput 
{
	// Fields
	private string <formatString>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE360C
	UnityEngine.UIElements.TextValueField<TValueType> get_textValueFieldParent() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	bool AcceptCharacter(Char c) { }

	// RVA: 0x2FE360C
	string get_allowedCharacters() { }

	// RVA: 0x2FE360C
	string get_formatString() { }

	// RVA: 0x2FE4574
	void set_formatString(string value) { }

	// RVA: 0x309AF8C
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	// RVA: 0x2FE41A8
	void StartDragging() { }

	// RVA: 0x2FE41A8
	void StopDragging() { }

	// RVA: 0x309AF8C
	string ValueToString(TValueType value) { }

	// RVA: 0x309AF8C
	TValueType StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public abstract class TextValueField<T0> 
{
	// Fields
	private BaseFieldMouseDragger m_Dragger; // 0x0
	internal bool m_UpdateTextFromValue; // 0x0
	private bool m_ForceUpdateDisplay; // 0x0

	// Methods

	// RVA: 0x2FE360C
	TextValueInput get_textValueInput() { }

	// RVA: 0x2FE360C
	string get_formatString() { }

	// RVA: 0x2FE4650
	void .ctor(string label, int maxLength, TextValueInput textValueInput) { }

	// RVA: 0x309AF8C
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, TValueType startValue) { }

	// RVA: 0x2FE41A8
	void StartDragging() { }

	// RVA: 0x2FE41A8
	void StopDragging() { }

	// RVA: 0x309AF8C
	TValueType get_value() { }

	// RVA: 0x309AF8C
	void set_value(TValueType value) { }

	// RVA: 0x2FE41A8
	void UpdateValueFromText() { }

	// RVA: 0x2FE41A8
	void UpdateTextFromValue() { }

	// RVA: 0x2FE4234
	void OnIsReadOnlyChanged(bool newValue) { }

	// RVA: 0x2FE3174
	bool CanTryParse(string textString) { }

	// RVA: 0x2FE41A8
	void AddLabelDragger() { }

	// RVA: 0x2FE4234
	void EnableLabelDragger(bool enable) { }

	// RVA: 0x309AF8C
	void SetValueWithoutNotify(TValueType newValue) { }

	// RVA: 0x2FE4574
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x2FE41A8
	void OnViewDataReady() { }

	// RVA: 0x2FE41A8
	void RegisterEditingCallbacks() { }

	// RVA: 0x2FE41A8
	void UnregisterEditingCallbacks() { }

}

// Namespace: UnityEngine.UIElements
public class TextValueFieldTraits<T0, T1> 
{
	// Fields
	private UxmlBoolAttributeDescription m_IsReadOnly; // 0x0
	private UxmlBoolAttributeDescription m_IsDelayed; // 0x0

	// Methods

	// RVA: -1
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16FA290
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Text; // 0x88

	// Methods

	// RVA: 0x16FA2E4
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16FA3F8
	void .ctor() { }

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

	// RVA: 0x16F9CC4
	void .ctor() { }

	// RVA: 0x16F9CCC
	void .ctor(string label) { }

	// RVA: 0x16F9DF8
	void InitLabel() { }

	// RVA: 0x16F9E80
	void UpdateMixedValueContent() { }

	// RVA: 0x16FA080
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16FA730
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x16FA784
	void .ctor() { }

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

	// RVA: 0x16FA4B0
	System.Func<UnityEngine.UIElements.VisualElement> get_makeItem() { }

	// RVA: 0x16FA4B8
	void set_makeItem(System.Func<UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x16FA510
	System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_bindItem() { }

	// RVA: 0x16FA518
	void set_bindItem(System.Action<UnityEngine.UIElements.VisualElement,System.Int32> value) { }

	// RVA: 0x16FA570
	System.Action<UnityEngine.UIElements.VisualElement,System.Int32> get_unbindItem() { }

	// RVA: 0x16FA578
	System.Action<UnityEngine.UIElements.VisualElement> get_destroyItem() { }

	// RVA: 0x16FA580
	bool HasValidDataAndBindings() { }

	// RVA: 0x16FA5C4
	CollectionViewController CreateViewController() { }

	// RVA: 0x16FA638
	void .ctor() { }

	// RVA: 0x16FA644
	void .ctor(System.Func<UnityEngine.UIElements.VisualElement> makeItem, System.Action<UnityEngine.UIElements.VisualElement,System.Int32> bindItem) { }

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

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<System.Int32> get_rootItemIds() { }

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.TreeViewItemData<T> GetDataForId(int id) { }

	// RVA: -1
	int GetParentId(int id) { }

	// RVA: -1
	void Move(int id, int newParentId, int childIndex) { }

	// RVA: -1
	bool HasAncestor(int childId, int ancestorId) { }

	// RVA: 0x309AF8C
	void AddItemToParent(UnityEngine.UIElements.TreeViewItemData<T> item, int parentId, int childIndex) { }

	// RVA: 0x2FE4314
	void RemoveFromParent(int id, int parentId) { }

	// RVA: 0x309AF8C
	void UpdateParentTree(UnityEngine.UIElements.TreeViewItemData<T> current) { }

	// RVA: 0x2FE4574
	void RefreshTree(System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> rootItems) { }

	// RVA: -1
	void BuildTree(System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> items, bool isRoot) { }

}

// Namespace: UnityEngine.UIElements
internal struct TreeItem 
{
	// Fields
	private readonly int <id>k__BackingField; // 0x10
	private readonly int <parentId>k__BackingField; // 0x14
	private readonly System.Collections.Generic.IEnumerable<System.Int32> <childrenIds>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16FA78C
	int get_id() { }

	// RVA: 0x16FA794
	int get_parentId() { }

	// RVA: 0x16FA79C
	System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds() { }

	// RVA: 0x16FA7A4
	bool get_hasChildren() { }

	// RVA: 0x16FA800
	void .ctor(int id, int parentId, System.Collections.Generic.IEnumerable<System.Int32> childrenIds) { }

}

// Namespace: UnityEngine.UIElements
internal struct TreeViewItemWrapper 
{
	// Fields
	public readonly TreeItem item; // 0x10
	public readonly int depth; // 0x20

	// Methods

	// RVA: 0x16FA810
	int get_id() { }

	// RVA: 0x16FA818
	System.Collections.Generic.IEnumerable<System.Int32> get_childrenIds() { }

	// RVA: 0x16FA820
	bool get_hasChildren() { }

	// RVA: 0x16FA87C
	void .ctor(TreeItem item, int depth) { }

}

// Namespace: UnityEngine.UIElements
public struct TreeViewItemData<T0> 
{
	// Fields
	private readonly int <id>k__BackingField; // 0x0
	private readonly T m_Data; // 0x0
	private readonly System.Collections.Generic.IList<UnityEngine.UIElements.TreeViewItemData<T>> m_Children; // 0x0

	// Methods

	// RVA: 0x2FE32D4
	int get_id() { }

	// RVA: 0x309AF8C
	T get_data() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.TreeViewItemData<T>> get_children() { }

	// RVA: 0x2FE3054
	bool get_hasChildren() { }

	// RVA: 0x309AF8C
	void InsertChild(UnityEngine.UIElements.TreeViewItemData<T> child, int index) { }

	// RVA: 0x2FE42A4
	void RemoveChild(int childId) { }

	// RVA: -1
	int GetChildIndex(int itemId) { }

	// RVA: 0x309AF8C
	void ReplaceChild(UnityEngine.UIElements.TreeViewItemData<T> newChild) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x16FE29C
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlIntAttributeDescription m_FixedPaneIndex; // 0x70
	private UxmlIntAttributeDescription m_FixedPaneInitialDimension; // 0x78
	private UnityEngine.UIElements.UxmlEnumAttributeDescription<UnityEngine.UIElements.TwoPaneSplitViewOrientation> m_Orientation; // 0x80

	// Methods

	// RVA: 0x16FE2F0
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16FE448
	void .ctor() { }

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

	// RVA: 0x16FA8B0
	VisualElement get_fixedPane() { }

	// RVA: 0x16FA8B8
	VisualElement get_flexedPane() { }

	// RVA: 0x16FA8C0
	VisualElement get_dragLine() { }

	// RVA: 0x16FA8C8
	int get_fixedPaneIndex() { }

	// RVA: 0x16FA8D0
	TwoPaneSplitViewOrientation get_orientation() { }

	// RVA: 0x16FA8D8
	float get_fixedPaneDimension() { }

	// RVA: 0x16FA914
	void set_fixedPaneDimension(float value) { }

	// RVA: 0x16FA930
	void .ctor() { }

	// RVA: 0x16FAB9C
	void CollapseChild(int index) { }

	// RVA: 0x16FB230
	void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) { }

	// RVA: 0x16FCB54
	void OnPostDisplaySetup(GeometryChangedEvent evt) { }

	// RVA: 0x16FCC84
	void ReplacePanesBasedOnAnchor() { }

	// RVA: 0x16FCE00
	void OnAnchorPostDisplaySetup(GeometryChangedEvent evt) { }

	// RVA: 0x16FCF04
	void IdentifyLeftAndRightPane() { }

	// RVA: 0x16FB5A4
	void PostDisplaySetup() { }

	// RVA: 0x16FD064
	void OnSizeChange(GeometryChangedEvent evt) { }

	// RVA: 0x16FD070
	void UpdateLayout(bool updateFixedPane, bool updateDragLine) { }

	// RVA: 0x16FE01C
	VisualElement get_contentContainer() { }

	// RVA: 0x16FE024
	void OnViewDataReady() { }

	// RVA: 0x16FDD4C
	void SetDragLineOffset(float offset) { }

	// RVA: 0x16FDEB4
	void SetFixedPaneDimension(float dimension) { }

	// RVA: 0x16FE06C
	void .cctor() { }

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

	// RVA: 0x16FE628
	TwoPaneSplitViewOrientation get_orientation() { }

	// RVA: 0x16FE648
	VisualElement get_fixedPane() { }

	// RVA: 0x16FE668
	VisualElement get_flexedPane() { }

	// RVA: 0x16FE688
	float get_fixedPaneMinDimension() { }

	// RVA: 0x16FE7CC
	float get_fixedPaneMargins() { }

	// RVA: 0x16FEA30
	float get_flexedPaneMinDimension() { }

	// RVA: 0x16FEB74
	float get_flexedPaneMargin() { }

	// RVA: 0x16FCFC0
	void .ctor(TwoPaneSplitView splitView, int dir) { }

	// RVA: 0x16FEDD8
	void RegisterCallbacksOnTarget() { }

	// RVA: 0x16FEF98
	void UnregisterCallbacksFromTarget() { }

	// RVA: 0x16FF158
	void ApplyDelta(float delta) { }

	// RVA: 0x16FFD54
	void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x16FFE30
	void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x1700298
	void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x1700200
	void InterruptPointerMove(PointerMoveEvent e) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1700ADC
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x1700B30
	void .ctor() { }

}

// Namespace: 
private class UnsignedIntegerInput 
{
	// Methods

	// RVA: 0x1700B84
	UnsignedIntegerField get_parentUnsignedIntegerField() { }

	// RVA: 0x1700810
	void .ctor() { }

	// RVA: 0x1700C08
	string get_allowedCharacters() { }

	// RVA: 0x1700C84
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt32 startValue) { }

	// RVA: 0x1700FA8
	string ValueToString(UInt32 v) { }

	// RVA: 0x1701000
	UInt32 StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class UnsignedIntegerField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x1700354
	UnsignedIntegerInput get_integerInput() { }

	// RVA: 0x170040C
	string ValueToString(UInt32 v) { }

	// RVA: 0x17004CC
	UInt32 StringToValue(string str) { }

	// RVA: 0x1700608
	void .ctor() { }

	// RVA: 0x1700614
	void .ctor(string label, int maxLength) { }

	// RVA: 0x17008AC
	bool CanTryParse(string textString) { }

	// RVA: 0x17008D8
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt32 startValue) { }

	// RVA: 0x17009DC
	void .cctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1701838
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x170188C
	void .ctor() { }

}

// Namespace: 
private class UnsignedLongInput 
{
	// Methods

	// RVA: 0x17018E0
	UnsignedLongField get_parentUnsignedLongField() { }

	// RVA: 0x170156C
	void .ctor() { }

	// RVA: 0x1701964
	string get_allowedCharacters() { }

	// RVA: 0x17019E0
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt64 startValue) { }

	// RVA: 0x1701D10
	UInt64 ClampToMinMaxULongValue(Int64 niceDelta, UInt64 value) { }

	// RVA: 0x1701D90
	string ValueToString(UInt64 v) { }

	// RVA: 0x1701DE8
	UInt64 StringToValue(string str) { }

}

// Namespace: UnityEngine.UIElements
public class UnsignedLongField 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string labelUssClassName; // 0x8
	public static readonly string inputUssClassName; // 0x10

	// Methods

	// RVA: 0x17010B0
	UnsignedLongInput get_unsignedLongInput() { }

	// RVA: 0x1701168
	string ValueToString(UInt64 v) { }

	// RVA: 0x1701228
	UInt64 StringToValue(string str) { }

	// RVA: 0x1701364
	void .ctor() { }

	// RVA: 0x1701370
	void .ctor(string label, int maxLength) { }

	// RVA: 0x1701608
	bool CanTryParse(string textString) { }

	// RVA: 0x1701634
	void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, UInt64 startValue) { }

	// RVA: 0x1701738
	void .cctor() { }

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

	// RVA: 0x1701E98
	void AdjustSlot(UInt32 index, bool increment) { }

	// RVA: 0x1701EC8
	UInt32 Hash1(UInt32 hash) { }

	// RVA: 0x1701ED0
	UInt32 Hash2(UInt32 hash) { }

	// RVA: 0x1701ED8
	bool IsSlotEmpty(UInt32 index) { }

	// RVA: 0x1701EE8
	void InsertHash(UInt32 hash) { }

	// RVA: 0x1701F34
	void RemoveHash(UInt32 hash) { }

	// RVA: 0x1701F64
	bool ContainsHash(UInt32 hash) { }

}

// Namespace: UnityEngine.UIElements
internal class AncestorFilter 
{
	// Fields
	private CountingBloomFilter m_CountingBloomFilter; // 0x10
	private System.Collections.Generic.Stack<System.Int32> m_HashStack; // 0x4010

	// Methods

	// RVA: 0x1701F8C
	void .ctor() { }

	// RVA: 0x1702020
	void AddHash(int hash) { }

	// RVA: 0x17020F0
	bool IsCandidate(StyleComplexSelector complexSel) { }

	// RVA: 0x17021A8
	void PushElement(VisualElement element) { }

	// RVA: 0x17025D8
	void PopElement() { }

}

// Namespace: UnityEngine.UIElements
public struct Cursor 
{
	// Fields
	private Texture2D <texture>k__BackingField; // 0x10
	private Vector2 <hotspot>k__BackingField; // 0x18
	private int <defaultCursorId>k__BackingField; // 0x20

	// Methods

	// RVA: 0x17026E8
	Texture2D get_texture() { }

	// RVA: 0x17026F0
	void set_texture(Texture2D value) { }

	// RVA: 0x17026F8
	Vector2 get_hotspot() { }

	// RVA: 0x1702700
	void set_hotspot(Vector2 value) { }

	// RVA: 0x1702708
	int get_defaultCursorId() { }

	// RVA: 0x1702710
	void set_defaultCursorId(int value) { }

	// RVA: 0x1702718
	bool Equals(object obj) { }

	// RVA: 0x1702850
	bool Equals(Cursor other) { }

	// RVA: 0x1702900
	int GetHashCode() { }

	// RVA: 0x17029DC
	bool op_Equality(Cursor style1, Cursor style2) { }

	// RVA: 0x1702AA4
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
internal interface ICursorManager 
{
	// Methods

	// RVA: -1
	void SetCursor(Cursor cursor) { }

	// RVA: 0x2FE41A8
	void ResetCursor() { }

}

// Namespace: UnityEngine.UIElements
internal class CursorManager 
{
	// Fields
	private bool <isCursorOverriden>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1702B38
	bool get_isCursorOverriden() { }

	// RVA: 0x1702B40
	void set_isCursorOverriden(bool value) { }

	// RVA: 0x1702B48
	void SetCursor(Cursor cursor) { }

	// RVA: 0x1702CAC
	void ResetCursor() { }

	// RVA: 0x1702D18
	void .ctor() { }

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

	// RVA: 0x1706034
	void .ctor(DefaultEventSystem es) { }

	// RVA: 0x17060B8
	void Dispose() { }

}

// Namespace: 
internal interface IInput 
{
	// Methods

	// RVA: 0x2FE3174
	bool GetButtonDown(string button) { }

	// RVA: -1
	float GetAxisRaw(string axis) { }

	// RVA: 0x2FE41A8
	void ClearLastPenContactEvent() { }

	// RVA: -1
	PenData GetLastPenContactEvent() { }

	// RVA: 0x2FE32D4
	int get_touchCount() { }

	// RVA: -1
	Touch GetTouch(int index) { }

	// RVA: 0x2FE3054
	bool get_mousePresent() { }

	// RVA: 0x2FE3088
	bool GetMouseButtonDown(int button) { }

	// RVA: 0x2FE3088
	bool GetMouseButtonUp(int button) { }

	// RVA: -1
	Vector3 get_mousePosition() { }

	// RVA: 0x2FE32D4
	int get_mouseButtonCount() { }

	// RVA: 0x2FE3054
	bool get_anyKey() { }

	// RVA: -1
	float get_unscaledTime() { }

	// RVA: -1
	float get_doubleClickTime() { }

}

// Namespace: 
private class Input 
{
	// Methods

	// RVA: 0x17060FC
	bool GetButtonDown(string button) { }

	// RVA: 0x1706108
	float GetAxisRaw(string axis) { }

	// RVA: 0x1706114
	void ClearLastPenContactEvent() { }

	// RVA: 0x170611C
	PenData GetLastPenContactEvent() { }

	// RVA: 0x1706160
	int get_touchCount() { }

	// RVA: 0x1706168
	Touch GetTouch(int index) { }

	// RVA: 0x17061BC
	bool get_mousePresent() { }

	// RVA: 0x17061C4
	bool GetMouseButtonDown(int button) { }

	// RVA: 0x17061D0
	bool GetMouseButtonUp(int button) { }

	// RVA: 0x17061DC
	Vector3 get_mousePosition() { }

	// RVA: 0x17061E4
	int get_mouseButtonCount() { }

	// RVA: 0x17061EC
	bool get_anyKey() { }

	// RVA: 0x17061F4
	float get_unscaledTime() { }

	// RVA: 0x17061FC
	float get_doubleClickTime() { }

	// RVA: 0x1706228
	void .ctor() { }

}

// Namespace: 
private class NoInput 
{
	// Methods

	// RVA: 0x1706230
	bool GetButtonDown(string button) { }

	// RVA: 0x1706238
	float GetAxisRaw(string axis) { }

	// RVA: 0x1706240
	int get_touchCount() { }

	// RVA: 0x1706248
	Touch GetTouch(int index) { }

	// RVA: 0x170625C
	void ClearLastPenContactEvent() { }

	// RVA: 0x1706260
	PenData GetLastPenContactEvent() { }

	// RVA: 0x1706270
	bool get_mousePresent() { }

	// RVA: 0x1706278
	bool GetMouseButtonDown(int button) { }

	// RVA: 0x1706280
	bool GetMouseButtonUp(int button) { }

	// RVA: 0x1706288
	Vector3 get_mousePosition() { }

	// RVA: 0x1706298
	int get_mouseButtonCount() { }

	// RVA: 0x17062A0
	bool get_anyKey() { }

	// RVA: 0x17062A8
	float get_unscaledTime() { }

	// RVA: 0x17062B0
	float get_doubleClickTime() { }

	// RVA: 0x17062BC
	void .ctor() { }

}

// Namespace: 
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

	// RVA: 0x17062C4
	void .cctor() { }

	// RVA: 0x1706330
	void .ctor() { }

	// RVA: 0x1706338
	EventBase <SendIMGUIEvents>b__30_0(DefaultEventSystem self) { }

	// RVA: 0x17063B4
	EventBase <SendIMGUIEvents>b__30_1(Vector3 panelPosition, Vector3 _, System.ValueTuple<UnityEngine.EventModifiers,UnityEngine.Vector2> t) { }

	// RVA: 0x1706544
	EventBase <SendIMGUIEvents>b__30_2(Vector3 panelPosition, Vector3 panelDelta, Event evt) { }

	// RVA: 0x17065F0
	EventBase <ProcessMouseEvents>b__36_0(Vector3 panelPosition, Vector3 panelDelta, DefaultEventSystem self) { }

	// RVA: 0x1706690
	EventBase <ProcessMouseEvents>b__36_1(Vector3 panelPosition, Vector3 panelDelta, System.ValueTuple<System.Int32,System.Int32,UnityEngine.EventModifiers> t) { }

	// RVA: 0x17066A4
	EventBase <ProcessMouseEvents>b__36_2(Vector3 panelPosition, Vector3 panelDelta, System.ValueTuple<System.Int32,System.Int32,UnityEngine.EventModifiers> t) { }

	// RVA: 0x17066B8
	EventBase <SendInputEvents>b__37_0(DefaultEventSystem self) { }

	// RVA: 0x170675C
	EventBase <SendInputEvents>b__37_1(DefaultEventSystem self) { }

	// RVA: 0x1706848
	EventBase <SendInputEvents>b__37_2(DefaultEventSystem self) { }

	// RVA: 0x1706934
	EventBase <ProcessTouchEvents>b__45_0(Vector3 panelPosition, Vector3 panelDelta, Touch _touch) { }

	// RVA: 0x1706A20
	EventBase <ProcessPenEvents>b__46_0(Vector3 panelPosition, Vector3 panelDelta, PenData _pen) { }

	// RVA: 0x1706ADC
	EventBase <ProcessTabEvent>b__53_0(System.ValueTuple<UnityEngine.UIElements.NavigationMoveEvent.Direction,UnityEngine.EventModifiers,UnityEngine.UIElements.DefaultEventSystem.IInput> t) { }

	// RVA: 0x1706BD0
	bool <.cctor>b__58_0() { }

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

	// RVA: 0x1702D20
	bool get_isAppFocused() { }

	// RVA: 0x1702D90
	IInput get_input() { }

	// RVA: 0x1702DF0
	IInput GetDefaultInput() { }

	// RVA: 0x1702FA8
	bool ShouldIgnoreEventsOnAppNotFocused() { }

	// RVA: 0x1702FCC
	BaseRuntimePanel get_focusedPanel() { }

	// RVA: 0x1702FD4
	void set_focusedPanel(BaseRuntimePanel value) { }

	// RVA: 0x1703034
	void Update(UpdateMode updateMode) { }

	// RVA: 0x1704510
	FocusBasedEventSequenceContext FocusBasedEventSequence() { }

	// RVA: 0x1704540
	void SendIMGUIEvents() { }

	// RVA: 0x17039BC
	void ProcessMouseEvents() { }

	// RVA: 0x1704D04
	void SendInputEvents() { }

	// RVA: 0x170575C
	void OnFocusEvent(RuntimePanel panel, FocusEvent evt) { }

	// RVA: 0x309AF8C
	void SendFocusBasedEvent(System.Func<TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg) { }

	// RVA: 0x309AF8C
	void SendPositionBasedEvent(Vector3 mousePosition, Vector3 delta, int pointerId, System.Nullable<System.Int32> targetDisplay, System.Func<UnityEngine.Vector3,UnityEngine.Vector3,TArg,UnityEngine.UIElements.EventBase> evtFactory, TArg arg, bool deselectIfNoTarget) { }

	// RVA: 0x17057BC
	void UpdateFocusedPanel(BaseRuntimePanel runtimePanel) { }

	// RVA: 0x170587C
	EventBase MakeTouchEvent(Touch touch, EventModifiers modifiers) { }

	// RVA: 0x1705A04
	EventBase MakePenEvent(PenData pen, EventModifiers modifiers) { }

	// RVA: 0x17034CC
	bool ProcessTouchEvents() { }

	// RVA: 0x17031BC
	bool ProcessPenEvents() { }

	// RVA: 0x1705AD0
	Vector2 GetRawMoveVector() { }

	// RVA: 0x17052DC
	bool ShouldSendMoveFromInput() { }

	// RVA: 0x1705110
	void ProcessTabEvent(Event e, EventModifiers modifiers) { }

	// RVA: 0x1705DF4
	void .ctor() { }

	// RVA: 0x1705F60
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DisposeHelper 
{
	// Methods

	// RVA: 0x1706BD8
	void NotifyDisposedUsed(IDisposable disposable) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class BaseReorderableDragAndDropController 
{
	// Fields
	protected readonly BaseVerticalCollectionView m_View; // 0x10
	protected System.Collections.Generic.List<System.Int32> m_SortedSelectedIds; // 0x18
	private bool <enableReordering>k__BackingField; // 0x20

	// Methods

	// RVA: 0x1706CBC
	System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds() { }

	// RVA: 0x1706CC4
	void .ctor(BaseVerticalCollectionView view) { }

	// RVA: 0x1706D74
	bool get_enableReordering() { }

	// RVA: 0x1706D7C
	void set_enableReordering(bool value) { }

	// RVA: 0x1706D84
	bool CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIds) { }

	// RVA: 0x1706D94
	StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, bool skipText) { }

	// RVA: 0x1707698
	int CompareId(int id1, int id2) { }

	// RVA: 0x2FE3404
	DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: 0x2FE4574
	void OnDrop(IListDragAndDropArgs args) { }

	// RVA: 0x17076C4
	void DragCleanup() { }

	// RVA: 0x17076C8
	void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

}

// Namespace: UnityEngine.UIElements
internal static class DragAndDropUtility 
{
	// Fields
	private static System.Func<UnityEngine.UIElements.IDragAndDrop> s_MakeDragAndDropClientFunc; // 0x0
	private static IDragAndDrop s_DragAndDropEditor; // 0x8
	private static IDragAndDrop s_DragAndDropPlayMode; // 0x10

	// Methods

	// RVA: 0x17076CC
	IDragAndDrop GetDragAndDrop(IPanel panel) { }

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

	// RVA: 0x1707988
	object get_source() { }

	// RVA: 0x17079E4
	object GetGenericData(string key) { }

	// RVA: 0x1707A4C
	void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	// RVA: 0x1708130
	void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x17082D4
	void AcceptDrag() { }

	// RVA: 0x17082D8
	void SetVisualMode(DragVisualMode mode) { }

	// RVA: 0x17082E0
	void DragCleanup() { }

	// RVA: 0x1708344
	DragAndDropData get_data() { }

	// RVA: 0x1707910
	void .ctor() { }

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

	// RVA: 0x1708350
	bool get_supportsDragEvents() { }

	// RVA: 0x1708358
	bool get_useDragEvents() { }

	// RVA: 0x170839C
	IDragAndDrop get_dragAndDrop() { }

	// RVA: 0x17083C0
	bool get_isEditorContext() { }

	// RVA: 0x170851C
	void .ctor(VisualElement target) { }

	// RVA: 0x1708980
	void RegisterCallbacksFromTarget(AttachToPanelEvent evt) { }

	// RVA: 0x1708670
	void RegisterCallbacksFromTarget() { }

	// RVA: 0x1708984
	void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt) { }

	// RVA: 0x170898C
	void UnregisterCallbacksFromTarget(bool unregisterPanelEvents) { }

	// RVA: -1
	bool CanStartDrag(Vector3 pointerPosition) { }

	// RVA: -1
	StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: -1
	void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: -1
	void OnDrop(Vector3 pointerPosition) { }

	// RVA: 0x2FE4234
	void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x1708D8C
	void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x1708E8C
	void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x1709144
	void OnPointerLeaveEvent(PointerLeaveEvent evt) { }

	// RVA: 0x1709154
	void OnPointerCancelEvent(PointerCancelEvent evt) { }

	// RVA: 0x170929C
	void OnPointerCapturedOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x17093B8
	void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x1709044
	DragEventsProcessor GetDropTarget(Vector2 position) { }

}

// Namespace: UnityEngine.UIElements
internal interface ICollectionDragAndDropController 
{}

// Namespace: UnityEngine.UIElements
internal interface IDragAndDrop 
{
	// Methods

	// RVA: -1
	void StartDrag(StartDragArgs args, Vector3 pointerPosition) { }

	// RVA: -1
	void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x2FE41A8
	void AcceptDrag() { }

	// RVA: 0x2FE41A8
	void DragCleanup() { }

	// RVA: 0x2FE42A4
	void SetVisualMode(DragVisualMode visualMode) { }

	// RVA: 0x2FE360C
	DragAndDropData get_data() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class DragAndDropData 
{
	// Methods

	// RVA: 0x2FE36BC
	object GetGenericData(string key) { }

	// RVA: 0x2FE360C
	object get_source() { }

	// RVA: 0x1708348
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal interface IListDragAndDropArgs 
{
	// Methods

	// RVA: 0x2FE32D4
	int get_insertAtIndex() { }

	// RVA: 0x2FE32D4
	int get_parentId() { }

	// RVA: 0x2FE32D4
	int get_childIndex() { }

	// RVA: 0x2FE360C
	DragAndDropData get_dragAndDropData() { }

	// RVA: 0x2FE32D4
	DragAndDropPosition get_dragAndDropPosition() { }

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

	// RVA: 0x17096A4
	void set_target(object value) { }

	// RVA: 0x17096AC
	int get_insertAtIndex() { }

	// RVA: 0x17096B4
	void set_insertAtIndex(int value) { }

	// RVA: 0x17096BC
	int get_parentId() { }

	// RVA: 0x17096C4
	void set_parentId(int value) { }

	// RVA: 0x17096CC
	int get_childIndex() { }

	// RVA: 0x17096D4
	void set_childIndex(int value) { }

	// RVA: 0x17096DC
	DragAndDropPosition get_dragAndDropPosition() { }

	// RVA: 0x17096E4
	void set_dragAndDropPosition(DragAndDropPosition value) { }

	// RVA: 0x17096EC
	DragAndDropData get_dragAndDropData() { }

	// RVA: 0x17096F4
	void set_dragAndDropData(DragAndDropData value) { }

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

	// RVA: 0x2FE3174
	bool CanStartDrag(System.Collections.Generic.IEnumerable<System.Int32> itemIds) { }

	// RVA: -1
	StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, bool skipText) { }

	// RVA: 0x309AF8C
	DragVisualMode HandleDragAndDrop(TArgs args) { }

	// RVA: 0x309AF8C
	void OnDrop(TArgs args) { }

	// RVA: 0x2FE41A8
	void DragCleanup() { }

	// RVA: -1
	void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<System.Int32> GetSortedSelectedIds() { }

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

	// RVA: 0x17096FC
	void .ctor(VisualElement draggedElement, int id, System.Collections.Generic.IEnumerable<System.Int32> selectedIds) { }

}

// Namespace: UnityEngine.UIElements
internal struct SetupDragAndDropArgs 
{
	// Fields
	public readonly VisualElement draggedElement; // 0x10
	public readonly System.Collections.Generic.IEnumerable<System.Int32> selectedIds; // 0x18
	public readonly StartDragArgs startDragArgs; // 0x20

	// Methods

	// RVA: 0x1709740
	void .ctor(VisualElement draggedElement, System.Collections.Generic.IEnumerable<System.Int32> selectedIds, StartDragArgs startDragArgs) { }

}

// Namespace: UnityEngine.UIElements
internal struct HandleDragAndDropArgs 
{
	// Fields
	private readonly DragAndDropArgs m_DragAndDropArgs; // 0x10
	private readonly Vector2 <position>k__BackingField; // 0x30

	// Methods

	// RVA: 0x1709798
	void .ctor(Vector2 position, DragAndDropArgs dragAndDropArgs) { }

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

	// RVA: 0x1707650
	void .ctor(string title, DragVisualMode visualMode) { }

	// RVA: 0x17097AC
	string get_title() { }

	// RVA: 0x17097B4
	DragVisualMode get_visualMode() { }

	// RVA: 0x17097BC
	Hashtable get_genericData() { }

	// RVA: 0x17097C4
	void set_genericData(Hashtable value) { }

	// RVA: 0x17097CC
	System.Collections.Generic.IEnumerable<UnityEngine.Object> get_unityObjectReferences() { }

	// RVA: 0x17097D4
	void set_unityObjectReferences(System.Collections.Generic.IEnumerable<UnityEngine.Object> value) { }

	// RVA: 0x17097DC
	void SetGenericData(string key, object data) { }

}

// Namespace: UnityEngine.UIElements
internal interface IReorderable 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_enableReordering() { }

	// RVA: 0x2FE4234
	void set_enableReordering(bool value) { }

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

	// RVA: 0x170C1D4
	bool Equals(DragPosition other) { }

	// RVA: 0x170E69C
	bool Equals(object obj) { }

	// RVA: 0x170E784
	int GetHashCode() { }

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

	// RVA: 0x170987C
	BaseVerticalCollectionView get_targetView() { }

	// RVA: 0x1709904
	ScrollView get_targetScrollView() { }

	// RVA: 0x1709984
	ICollectionDragAndDropController get_dragAndDropController() { }

	// RVA: 0x170998C
	void set_dragAndDropController(ICollectionDragAndDropController value) { }

	// RVA: 0x1709994
	void .ctor(BaseVerticalCollectionView listView) { }

	// RVA: 0x17099A0
	bool CanStartDrag(Vector3 pointerPosition) { }

	// RVA: 0x170A27C
	StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: 0x170A80C
	void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x170AA10
	DragVisualMode GetVisualMode(Vector3 pointerPosition, ref DragPosition dragPosition) { }

	// RVA: 0x170BD34
	void OnDrop(Vector3 pointerPosition) { }

	// RVA: 0x170AC04
	void HandleDragAndScroll(Vector2 pointerPosition) { }

	// RVA: 0x170AFBC
	void HandleAutoExpansion(Vector2 pointerPosition) { }

	// RVA: 0x170B0AC
	void ApplyDragAndDropUI(DragPosition dragPosition) { }

	// RVA: 0x170CD04
	bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	// RVA: 0x170D2F0
	void HandleTreePosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	// RVA: 0x170D470
	void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(ref DragPosition dragPosition, Vector2 pointerPosition) { }

	// RVA: 0x170D9E4
	void GetPreviousAndNextItemsIgnoringDraggedItems(int insertAtIndex, out int previousItemId, out int nextItemId) { }

	// RVA: 0x170BB88
	DragAndDropArgs MakeDragAndDropArgs(DragPosition dragPosition) { }

	// RVA: 0x170DD70
	float GetHoverBarTopPosition(ReusableCollectionItem item) { }

	// RVA: 0x170CCDC
	void PlaceHoverBarAtElement(ReusableCollectionItem item) { }

	// RVA: 0x170C258
	void PlaceHoverBarAt(float top, float indentationPadding, float siblingBottom) { }

	// RVA: 0x170DE60
	void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x1709EA8
	ReusableCollectionItem GetRecycledItem(Vector3 pointerPosition) { }

	// RVA: 0x170E55C
	void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(GeometryChangedEvent e) { }

}

// Namespace: UnityEngine.UIElements
internal static class ListViewDraggerExtension 
{
	// Methods

	// RVA: 0x1707320
	ReusableCollectionItem GetRecycledItemFromId(BaseVerticalCollectionView listView, int id) { }

	// RVA: 0x170C9AC
	ReusableCollectionItem GetRecycledItemFromIndex(BaseVerticalCollectionView listView, int index) { }

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

	// RVA: 0x170E7EC
	bool get_isDragging() { }

	// RVA: 0x170E7F4
	void set_isDragging(bool value) { }

	// RVA: 0x170E7FC
	ReusableCollectionItem get_draggedItem() { }

	// RVA: 0x170E804
	bool get_supportsDragEvents() { }

	// RVA: 0x170E80C
	void .ctor(BaseVerticalCollectionView listView) { }

	// RVA: 0x170E818
	StartDragArgs StartDrag(Vector3 pointerPosition) { }

	// RVA: 0x170F660
	void UpdateDrag(Vector3 pointerPosition) { }

	// RVA: 0x170F1DC
	void Animate(ReusableCollectionItem element, float paddingTop) { }

	// RVA: 0x1710158
	void OnDrop(Vector3 pointerPosition) { }

	// RVA: 0x1710694
	void ClearDragAndDropUI(bool dragCancelled) { }

	// RVA: 0x1710698
	bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

}

// Namespace: UnityEngine.UIElements
internal class ListViewReorderableDragAndDropController 
{
	// Fields
	protected readonly BaseListView m_ListView; // 0x28

	// Methods

	// RVA: 0x17106DC
	void .ctor(BaseListView view) { }

	// RVA: 0x171070C
	DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: 0x1710888
	void OnDrop(IListDragAndDropArgs args) { }

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

	// RVA: 0x1710C20
	void .ctor() { }

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

	// RVA: 0x1710B30
	void .ctor(BaseTreeView view) { }

	// RVA: 0x1710C30
	int CompareId(int id1, int id2) { }

	// RVA: 0x1711188
	StartDragArgs SetupDragAndDrop(System.Collections.Generic.IEnumerable<System.Int32> itemIds, bool skipText) { }

	// RVA: 0x1711234
	DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	// RVA: 0x1711340
	void OnDrop(IListDragAndDropArgs args) { }

	// RVA: 0x1711AE4
	void DragCleanup() { }

	// RVA: 0x1711C4C
	void RestoreExpanded(System.Collections.Generic.List<System.Int32> ids) { }

	// RVA: 0x1711F9C
	void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	// RVA: 0x17120D8
	void DelayExpandDropItem() { }

	// RVA: 0x1712340
	void ExpandDropItem() { }

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

	// RVA: 0x1712544
	void .ctor(EventBase e) { }

}

// Namespace: UnityEngine.UIElements
public abstract class DropdownMenuItem 
{
	// Methods

	// RVA: 0x171286C
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class DropdownMenuSeparator 
{
	// Fields
	private readonly string <subMenuPath>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1712874
	void .ctor(string subMenuPath) { }

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

	// RVA: 0x17128A8
	void set_status(Status value) { }

	// RVA: 0x17128B0
	void set_eventInfo(DropdownMenuEventInfo value) { }

	// RVA: 0x17128B8
	void set_userData(object value) { }

	// RVA: 0x17128C0
	Status AlwaysEnabled(DropdownMenuAction a) { }

	// RVA: 0x17128C8
	Status AlwaysDisabled(DropdownMenuAction a) { }

	// RVA: 0x17128D0
	void .ctor(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> actionCallback, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData) { }

	// RVA: 0x1712950
	void UpdateActionStatus(DropdownMenuEventInfo eventInfo) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public Status status; // 0x10

	// Methods

	// RVA: 0x1712BEC
	void .ctor() { }

	// RVA: 0x1713268
	Status <AppendAction>b__0(DropdownMenuAction e) { }

}

// Namespace: UnityEngine.UIElements
public class DropdownMenu 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> m_MenuItems; // 0x10
	private DropdownMenuEventInfo m_DropdownMenuEventInfo; // 0x18

	// Methods

	// RVA: 0x17129C4
	System.Collections.Generic.List<UnityEngine.UIElements.DropdownMenuItem> MenuItems() { }

	// RVA: 0x17129CC
	void AppendAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, System.Func<UnityEngine.UIElements.DropdownMenuAction,UnityEngine.UIElements.DropdownMenuAction.Status> actionStatusCallback, object userData) { }

	// RVA: 0x1712AB4
	void AppendAction(string actionName, System.Action<UnityEngine.UIElements.DropdownMenuAction> action, Status status) { }

	// RVA: 0x1712BF4
	void AppendSeparator(string subMenuPath) { }

	// RVA: 0x1712D30
	void InsertSeparator(string subMenuPath, int atIndex) { }

	// RVA: 0x1712E7C
	void PrepareForDisplay(EventBase e) { }

	// RVA: 0x17131DC
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class DropdownUtility 
{
	// Fields
	internal static System.Func<UnityEngine.UIElements.IGenericMenu> MakeDropdownFunc; // 0x0

	// Methods

	// RVA: 0x1713270
	IGenericMenu CreateDropdown() { }

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

	// RVA: 0x1713320
	void .ctor(EventDispatcher d) { }

	// RVA: 0x17133C0
	void Dispose() { }

	// RVA: 0x171358C
	bool Equals(EventDispatcherGate other) { }

	// RVA: 0x1713598
	bool Equals(object obj) { }

	// RVA: 0x1713624
	int GetHashCode() { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.EventDispatcher.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1715AB8
	void .cctor() { }

	// RVA: 0x1715B24
	void .ctor() { }

	// RVA: 0x1715B2C
	System.Collections.Generic.Queue<UnityEngine.UIElements.EventDispatcher.EventRecord> <.cctor>b__40_0() { }

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

	// RVA: 0x171363C
	PointerDispatchState get_pointerState() { }

	// RVA: 0x1713644
	EventDispatcher CreateForRuntime(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies) { }

	// RVA: 0x17136A8
	void .ctor(System.Collections.Generic.IList<UnityEngine.UIElements.IEventDispatchingStrategy> strategies) { }

	// RVA: 0x17138B4
	bool get_dispatchImmediately() { }

	// RVA: 0x17138D4
	void set_processingEvents(bool value) { }

	// RVA: 0x17138DC
	void Dispatch(EventBase evt, IPanel panel, DispatchMode dispatchMode) { }

	// RVA: 0x17147E0
	bool HandleRecursiveState(EventBase evt) { }

	// RVA: 0x17133AC
	void CloseGate() { }

	// RVA: 0x17133DC
	void OpenGate() { }

	// RVA: 0x1714C70
	void ProcessEventQueue() { }

	// RVA: 0x1713BC0
	void ProcessEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x171506C
	void ApplyDispatchingStrategies(EventBase evt, IPanel panel, bool imguiEventIsInitiallyUsed) { }

	// RVA: 0x17155D8
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal interface IPointerCaptureEventInternal 
{
	// Methods

	// RVA: 0x2FE32D4
	int get_pointerId() { }

}

// Namespace: UnityEngine.UIElements
public abstract class PointerCaptureEventBase<T0> 
{
	// Fields
	private IEventHandler <relatedTarget>k__BackingField; // 0x0
	private int <pointerId>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void set_relatedTarget(IEventHandler value) { }

	// RVA: 0x2FE32D4
	int get_pointerId() { }

	// RVA: 0x2FE42A4
	void set_pointerId(int value) { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x309AF8C
	T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerCaptureOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1715CE4
	void .cctor() { }

	// RVA: 0x1715D50
	void .ctor() { }

	// RVA: 0x1715D58
	PointerCaptureOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class PointerCaptureOutEvent 
{
	// Methods

	// RVA: 0x1715BA0
	void .cctor() { }

	// RVA: 0x1715C90
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerCaptureEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1715F28
	void .cctor() { }

	// RVA: 0x1715F94
	void .ctor() { }

	// RVA: 0x1715F9C
	PointerCaptureEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class PointerCaptureEvent 
{
	// Methods

	// RVA: 0x1715DE4
	void .cctor() { }

	// RVA: 0x1715ED4
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class MouseCaptureEventBase<T0> 
{
	// Methods

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseCaptureOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171616C
	void .cctor() { }

	// RVA: 0x17161D8
	void .ctor() { }

	// RVA: 0x17161E0
	MouseCaptureOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseCaptureOutEvent 
{
	// Methods

	// RVA: 0x1716028
	void .cctor() { }

	// RVA: 0x1716118
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseCaptureEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17163B0
	void .cctor() { }

	// RVA: 0x171641C
	void .ctor() { }

	// RVA: 0x1716424
	MouseCaptureEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseCaptureEvent 
{
	// Methods

	// RVA: 0x171626C
	void .cctor() { }

	// RVA: 0x171635C
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.ChangeEvent.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE360C
	UnityEngine.UIElements.ChangeEvent<T> <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ChangeEvent<T0> 
{
	// Fields
	private T <previousValue>k__BackingField; // 0x0
	private T <newValue>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x309AF8C
	T get_previousValue() { }

	// RVA: 0x309AF8C
	void set_previousValue(T value) { }

	// RVA: 0x309AF8C
	T get_newValue() { }

	// RVA: 0x309AF8C
	void set_newValue(T value) { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.ChangeEvent<T> GetPooled(T previousValue, T newValue) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class CommandEventDispatchingStrategy 
{
	// Methods

	// RVA: 0x17164B0
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1716510
	void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x1715AA0
	void .ctor() { }

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

	// RVA: 0x2FE360C
	string get_commandName() { }

	// RVA: 0x2FE4574
	void set_commandName(string value) { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x309AF8C
	T GetPooled(Event systemEvent) { }

	// RVA: 0x309AF8C
	T GetPooled(string commandName) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.ValidateCommandEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17170B8
	void .cctor() { }

	// RVA: 0x1717124
	void .ctor() { }

	// RVA: 0x171712C
	ValidateCommandEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ValidateCommandEvent 
{
	// Methods

	// RVA: 0x1716F74
	void .cctor() { }

	// RVA: 0x1717064
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.ExecuteCommandEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17172FC
	void .cctor() { }

	// RVA: 0x1717368
	void .ctor() { }

	// RVA: 0x1717370
	ExecuteCommandEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ExecuteCommandEvent 
{
	// Methods

	// RVA: 0x17171B8
	void .cctor() { }

	// RVA: 0x17172A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultDispatchingStrategy 
{
	// Methods

	// RVA: 0x17173FC
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1717480
	void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x1715AB0
	void .ctor() { }

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

	// RVA: 0x17176A4
	VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	// RVA: 0x171771C
	VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x1717750
	void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos) { }

	// RVA: 0x1717910
	Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0x1717AFC
	void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	// RVA: 0x1717DAC
	void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	// RVA: 0x1717B04
	void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary) { }

	// RVA: 0x1717DB4
	void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType) { }

	// RVA: 0x1718BF4
	void .ctor() { }

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

	// RVA: 0x1718DA4
	Int64 RegisterEventType() { }

	// RVA: 0x1718DF8
	Int64 get_eventTypeId() { }

	// RVA: 0x1718E00
	EventCategory get_eventCategory() { }

	// RVA: 0x1718E08
	Int64 get_timestamp() { }

	// RVA: 0x1718E10
	void set_timestamp(Int64 value) { }

	// RVA: 0x1718E18
	UInt64 get_eventId() { }

	// RVA: 0x1718E20
	void set_eventId(UInt64 value) { }

	// RVA: 0x1718E28
	void set_triggerEventId(UInt64 value) { }

	// RVA: 0x1718E30
	void SetTriggerEventId(UInt64 id) { }

	// RVA: 0x1718E38
	EventPropagation get_propagation() { }

	// RVA: 0x1718E40
	void set_propagation(EventPropagation value) { }

	// RVA: 0x1718E48
	PropagationPaths get_path() { }

	// RVA: 0x1718E50
	void set_path(PropagationPaths value) { }

	// RVA: 0x1718E58
	LifeCycleStatus get_lifeCycleStatus() { }

	// RVA: 0x1718E60
	void set_lifeCycleStatus(LifeCycleStatus value) { }

	// RVA: 0x1718E68
	void PreDispatch() { }

	// RVA: 0x1718E6C
	void PreDispatch(IPanel panel) { }

	// RVA: 0x1718E78
	void PostDispatch() { }

	// RVA: 0x1718E7C
	void PostDispatch(IPanel panel) { }

	// RVA: 0x1718ED0
	bool get_bubbles() { }

	// RVA: 0x1718EDC
	bool get_tricklesDown() { }

	// RVA: 0x17153FC
	bool get_bubblesOrTricklesDown() { }

	// RVA: 0x1718EE8
	bool get_skipDisabledElements() { }

	// RVA: 0x1718EF4
	void set_skipDisabledElements(bool value) { }

	// RVA: 0x1718F14
	bool get_ignoreCompositeRoots() { }

	// RVA: 0x1718F20
	void set_ignoreCompositeRoots(bool value) { }

	// RVA: 0x1718F40
	IEventHandler get_leafTarget() { }

	// RVA: 0x1718F48
	void set_leafTarget(IEventHandler value) { }

	// RVA: 0x17155D0
	IEventHandler get_target() { }

	// RVA: 0x1715410
	void set_target(IEventHandler value) { }

	// RVA: 0x1718F50
	System.Collections.Generic.List<UnityEngine.UIElements.IEventHandler> get_skipElements() { }

	// RVA: 0x1716820
	bool Skip(IEventHandler h) { }

	// RVA: 0x1715060
	bool get_isPropagationStopped() { }

	// RVA: 0x1718F58
	void set_isPropagationStopped(bool value) { }

	// RVA: 0x1709134
	void StopPropagation() { }

	// RVA: 0x1718F6C
	bool get_isImmediatePropagationStopped() { }

	// RVA: 0x1718F78
	void set_isImmediatePropagationStopped(bool value) { }

	// RVA: 0x1718F98
	void StopImmediatePropagation() { }

	// RVA: 0x1718FA8
	bool get_isDefaultPrevented() { }

	// RVA: 0x1718FB4
	void set_isDefaultPrevented(bool value) { }

	// RVA: 0x1716884
	void PreventDefault() { }

	// RVA: 0x1718FD4
	PropagationPhase get_propagationPhase() { }

	// RVA: 0x1718FDC
	void set_propagationPhase(PropagationPhase value) { }

	// RVA: 0x1718FE4
	IEventHandler get_currentTarget() { }

	// RVA: 0x1718FEC
	void set_currentTarget(IEventHandler value) { }

	// RVA: 0x17190F4
	bool get_dispatch() { }

	// RVA: 0x1719100
	void set_dispatch(bool value) { }

	// RVA: 0x1713B14
	void MarkReceivedByDispatcher() { }

	// RVA: 0x1719140
	bool get_dispatched() { }

	// RVA: 0x1719120
	void set_dispatched(bool value) { }

	// RVA: 0x171914C
	bool get_processed() { }

	// RVA: 0x1718EB0
	void set_processed(bool value) { }

	// RVA: 0x1719158
	bool get_processedByFocusController() { }

	// RVA: 0x1719164
	void set_processedByFocusController(bool value) { }

	// RVA: 0x1715054
	bool get_stopDispatch() { }

	// RVA: 0x1716F54
	void set_stopDispatch(bool value) { }

	// RVA: 0x171689C
	bool get_propagateToIMGUI() { }

	// RVA: 0x1716F34
	void set_propagateToIMGUI(bool value) { }

	// RVA: 0x1719184
	bool get_imguiEventIsValid() { }

	// RVA: 0x1719190
	void set_imguiEventIsValid(bool value) { }

	// RVA: 0x1713BA8
	Event get_imguiEvent() { }

	// RVA: 0x17191B0
	void set_imguiEvent(Event value) { }

	// RVA: 0x1719294
	Vector2 get_originalMousePosition() { }

	// RVA: 0x171929C
	void set_originalMousePosition(Vector2 value) { }

	// RVA: 0x17192A4
	void Init() { }

	// RVA: 0x17192A8
	void LocalInit() { }

	// RVA: 0x171949C
	void .ctor(EventCategory category) { }

	// RVA: 0x1719550
	bool get_pooled() { }

	// RVA: 0x171947C
	void set_pooled(bool value) { }

	// RVA: 0x2FE41A8
	void Acquire() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.EventBase.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	T <.cctor>b__15_0() { }

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

	// RVA: 0x2FE9A04
	void SetCreateFunction(System.Func<T> createMethod) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE69E4
	Int64 TypeId() { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x309AF8C
	T GetPooled() { }

	// RVA: 0x309AF8C
	T GetPooled(EventBase e) { }

	// RVA: 0x309AF8C
	void ReleasePooled(T evt) { }

	// RVA: 0x2FE41A8
	void Acquire() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE34E0
	Int64 get_eventTypeId() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public sealed class EventCallback<T0> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(TEventType evt) { }

}

// Namespace: UnityEngine.UIElements
public sealed class EventCallback<T0, T1> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(TEventType evt, TCallbackArgs userArgs) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class EventCallbackFunctorBase 
{
	// Fields
	private readonly CallbackPhase <phase>k__BackingField; // 0x10
	private readonly InvokePolicy <invokePolicy>k__BackingField; // 0x14

	// Methods

	// RVA: 0x171955C
	CallbackPhase get_phase() { }

	// RVA: 0x1719564
	InvokePolicy get_invokePolicy() { }

	// RVA: 0x171956C
	void .ctor(CallbackPhase phase, InvokePolicy invokePolicy) { }

	// RVA: 0x2FE45DC
	void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: -1
	bool IsEquivalentTo(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x17195A4
	bool PhaseMatches(PropagationPhase propagationPhase) { }

}

// Namespace: UnityEngine.UIElements
internal class EventCallbackFunctor<T0> 
{
	// Fields
	private readonly UnityEngine.UIElements.EventCallback<TEventType> m_Callback; // 0x0
	private readonly Int64 m_EventTypeId; // 0x0

	// Methods

	// RVA: -1
	void .ctor(UnityEngine.UIElements.EventCallback<TEventType> callback, CallbackPhase phase, InvokePolicy invokePolicy) { }

	// RVA: 0x2FE45DC
	void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: -1
	bool IsEquivalentTo(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

}

// Namespace: UnityEngine.UIElements
internal class EventCallbackFunctor<T0, T1> 
{
	// Fields
	private readonly UnityEngine.UIElements.EventCallback<TEventType,TCallbackArgs> m_Callback; // 0x0
	private readonly Int64 m_EventTypeId; // 0x0
	private TCallbackArgs <userArgs>k__BackingField; // 0x0

	// Methods

	// RVA: 0x309AF8C
	TCallbackArgs get_userArgs() { }

	// RVA: 0x309AF8C
	void set_userArgs(TCallbackArgs value) { }

	// RVA: 0x309AF8C
	void .ctor(UnityEngine.UIElements.EventCallback<TEventType,TCallbackArgs> callback, TCallbackArgs userArgs, CallbackPhase phase, InvokePolicy invokePolicy) { }

	// RVA: 0x2FE45DC
	void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: -1
	bool IsEquivalentTo(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

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

	// RVA: 0x17195E0
	EventCallbackList Get(EventCallbackList initializer) { }

	// RVA: 0x1719AB4
	void Release(EventCallbackList element) { }

	// RVA: 0x1719C48
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class EventCallbackList 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.EventCallbackFunctorBase> m_List; // 0x10
	private int <trickleDownCallbackCount>k__BackingField; // 0x18
	private int <bubbleUpCallbackCount>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x1719CD4
	int get_trickleDownCallbackCount() { }

	// RVA: 0x1719CDC
	void set_trickleDownCallbackCount(int value) { }

	// RVA: 0x1719CE4
	int get_bubbleUpCallbackCount() { }

	// RVA: 0x1719CEC
	void set_bubbleUpCallbackCount(int value) { }

	// RVA: 0x17197FC
	void .ctor() { }

	// RVA: 0x1719754
	void .ctor(EventCallbackList source) { }

	// RVA: 0x1719CF4
	bool Contains(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x1719D10
	EventCallbackFunctorBase Find(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x1719E1C
	bool Remove(Int64 eventTypeId, Delegate callback, CallbackPhase phase) { }

	// RVA: 0x1719F54
	void Add(EventCallbackFunctorBase item) { }

	// RVA: 0x1719890
	void AddRange(EventCallbackList list) { }

	// RVA: 0x1719FFC
	int get_Count() { }

	// RVA: 0x171A048
	EventCallbackFunctorBase get_Item(int i) { }

	// RVA: 0x1719B9C
	void Clear() { }

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

	// RVA: 0x171A0C0
	EventCallbackList GetCallbackList(EventCallbackList initializer) { }

	// RVA: 0x171A14C
	void ReleaseCallbackList(EventCallbackList toRelease) { }

	// RVA: 0x171A1D8
	void .ctor() { }

	// RVA: 0x171A200
	EventCallbackList GetCallbackListForWriting() { }

	// RVA: 0x171A458
	EventCallbackList GetCallbackListForReading() { }

	// RVA: 0x171A474
	bool UnregisterCallback(Int64 eventTypeId, Delegate callback, TrickleDown useTrickleDown) { }

	// RVA: -1
	void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown, InvokePolicy invokePolicy) { }

	// RVA: 0x309AF8C
	void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType,TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown, InvokePolicy invokePolicy) { }

	// RVA: 0x2FE31E0
	bool UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown) { }

	// RVA: 0x171A4D8
	void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase) { }

	// RVA: 0x171A874
	bool HasTrickleDownHandlers() { }

	// RVA: 0x171A894
	bool HasBubbleHandlers() { }

	// RVA: 0x171A8B4
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogCall 
{
	// Methods

	// RVA: 0x171A9A8
	void .ctor(Delegate callback, EventBase evt) { }

	// RVA: 0x171A9AC
	void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogIMGUICall 
{
	// Methods

	// RVA: 0x171A9B0
	void .ctor(EventBase evt) { }

	// RVA: 0x171A9B4
	void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal struct EventDebuggerLogExecuteDefaultAction 
{
	// Methods

	// RVA: 0x171A9B8
	void .ctor(EventBase evt) { }

	// RVA: 0x171A9BC
	void Dispose() { }

}

// Namespace: UnityEngine.UIElements
internal class EventDebugger 
{
	// Methods

	// RVA: 0x171540C
	void LogPropagationPaths(EventBase evt, PropagationPaths paths) { }

}

// Namespace: UnityEngine.UIElements
public interface IEventHandler 
{
	// Methods

	// RVA: 0x2FE4574
	void SendEvent(EventBase e) { }

	// RVA: 0x2FE4574
	void HandleEvent(EventBase evt) { }

}

// Namespace: UnityEngine.UIElements
public abstract class CallbackEventHandler 
{
	// Fields
	internal bool isIMGUIContainer; // 0x10
	private EventCallbackRegistry m_CallbackRegistry; // 0x18
	internal const string ExecuteDefaultActionName = 5714747632;
	internal const string ExecuteDefaultActionAtTargetName = 5710472704;

	// Methods

	// RVA: 0x2FE45DC
	void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown) { }

	// RVA: 0x2FE41A8
	void AddEventCategories() { }

	// RVA: 0x309AF8C
	void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType,TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown) { }

	// RVA: -1
	void RegisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown) { }

	// RVA: 0x2FE45DC
	void UnregisterCallback(UnityEngine.UIElements.EventCallback<TEventType> callback, TrickleDown useTrickleDown) { }

	// RVA: 0x2FE4574
	void SendEvent(EventBase e) { }

	// RVA: 0x2FE45DC
	void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: 0x171A9C0
	void HandleEventAtTargetPhase(EventBase evt) { }

	// RVA: 0x171AA3C
	void HandleEventAtTargetAndDefaultPhase(EventBase evt) { }

	// RVA: 0x171AA30
	void HandleEventAtCurrentTargetAndPhase(EventBase evt) { }

	// RVA: 0x171AAC8
	void UnityEngine.UIElements.IEventHandler.HandleEvent(EventBase evt) { }

	// RVA: 0x171AAD4
	void HandleEvent(EventBase evt) { }

	// RVA: 0x171AD88
	bool HasTrickleDownHandlers() { }

	// RVA: 0x171ADB0
	bool HasBubbleUpHandlers() { }

	// RVA: 0x171ADD8
	void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x171ADDC
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x171ADE0
	void ExecuteDefaultActionDisabledAtTarget(EventBase evt) { }

	// RVA: 0x171ADE4
	void ExecuteDefaultActionDisabled(EventBase evt) { }

	// RVA: 0x171ADE8
	void .ctor() { }

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

	// RVA: 0x2FE360C
	Focusable get_relatedTarget() { }

	// RVA: 0x2FE4574
	void set_relatedTarget(Focusable value) { }

	// RVA: 0x2FE360C
	FocusChangeDirection get_direction() { }

	// RVA: 0x2FE4574
	void set_direction(FocusChangeDirection value) { }

	// RVA: 0x2FE360C
	FocusController get_focusController() { }

	// RVA: 0x2FE4574
	void set_focusController(FocusController value) { }

	// RVA: 0x2FE3054
	bool get_IsFocusDelegated() { }

	// RVA: 0x2FE4234
	void set_IsFocusDelegated(bool value) { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x309AF8C
	T GetPooled(IEventHandler target, Focusable relatedTarget, FocusChangeDirection direction, FocusController focusController, bool bIsFocusDelegated) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.FocusOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171AFB0
	void .cctor() { }

	// RVA: 0x171B01C
	void .ctor() { }

	// RVA: 0x171B024
	FocusOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class FocusOutEvent 
{
	// Methods

	// RVA: 0x171ADF4
	void .cctor() { }

	// RVA: 0x171AEE4
	void Init() { }

	// RVA: 0x171AF44
	void LocalInit() { }

	// RVA: 0x171AF50
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.BlurEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171B27C
	void .cctor() { }

	// RVA: 0x171B2E8
	void .ctor() { }

	// RVA: 0x171B2F0
	BlurEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class BlurEvent 
{
	// Methods

	// RVA: 0x171B0B8
	void .cctor() { }

	// RVA: 0x171B1A8
	void PreDispatch(IPanel panel) { }

	// RVA: 0x171B228
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.FocusInEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171B538
	void .cctor() { }

	// RVA: 0x171B5A4
	void .ctor() { }

	// RVA: 0x171B5AC
	FocusInEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class FocusInEvent 
{
	// Methods

	// RVA: 0x171B37C
	void .cctor() { }

	// RVA: 0x171B46C
	void Init() { }

	// RVA: 0x171B4CC
	void LocalInit() { }

	// RVA: 0x171B4D8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.FocusEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171B83C
	void .cctor() { }

	// RVA: 0x171B8A8
	void .ctor() { }

	// RVA: 0x171B8B0
	FocusEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class FocusEvent 
{
	// Methods

	// RVA: 0x171B640
	void .cctor() { }

	// RVA: 0x171B730
	void PreDispatch(IPanel panel) { }

	// RVA: 0x171B7E8
	void .ctor() { }

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

	// RVA: 0x2FE3174
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x2FE47D4
	void DispatchEvent(EventBase evt, IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal static class EventDispatchUtilities 
{
	// Methods

	// RVA: 0x1716DA8
	void PropagateEvent(EventBase evt) { }

	// RVA: 0x171B93C
	void HandleEventAcrossPropagationPath(EventBase evt) { }

	// RVA: 0x17168A8
	void PropagateToIMGUIContainer(VisualElement root, EventBase evt) { }

	// RVA: 0x1715458
	void ExecuteDefaultAction(EventBase evt) { }

}

// Namespace: UnityEngine.UIElements
internal class IMGUIEventDispatchingStrategy 
{
	// Methods

	// RVA: 0x171C3F4
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x171C478
	void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x1715AA8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.InputEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171C864
	void .cctor() { }

	// RVA: 0x171C8D0
	void .ctor() { }

	// RVA: 0x171C8D8
	InputEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class InputEvent 
{
	// Fields
	private string <previousData>k__BackingField; // 0x88
	private string <newData>k__BackingField; // 0x90

	// Methods

	// RVA: 0x171C544
	void .cctor() { }

	// RVA: 0x171C634
	void set_previousData(string value) { }

	// RVA: 0x171C63C
	void set_newData(string value) { }

	// RVA: 0x171C644
	void Init() { }

	// RVA: 0x171C6C0
	void LocalInit() { }

	// RVA: 0x171C6FC
	InputEvent GetPooled(string previousData, string newData) { }

	// RVA: 0x171C7C4
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class KeyboardEventDispatchingStrategy 
{
	// Methods

	// RVA: 0x171C9B0
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x171CA10
	void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x1715A90
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IKeyboardEvent 
{
	// Methods

	// RVA: 0x2FE32D4
	EventModifiers get_modifiers() { }

	// RVA: -1
	Char get_character() { }

	// RVA: 0x2FE32D4
	KeyCode get_keyCode() { }

}

// Namespace: UnityEngine.UIElements
public abstract class KeyboardEventBase<T0> 
{
	// Fields
	private EventModifiers <modifiers>k__BackingField; // 0x0
	private Char <character>k__BackingField; // 0x0
	private KeyCode <keyCode>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE32D4
	EventModifiers get_modifiers() { }

	// RVA: 0x2FE42A4
	void set_modifiers(EventModifiers value) { }

	// RVA: -1
	Char get_character() { }

	// RVA: -1
	void set_character(Char value) { }

	// RVA: 0x2FE32D4
	KeyCode get_keyCode() { }

	// RVA: 0x2FE42A4
	void set_keyCode(KeyCode value) { }

	// RVA: 0x2FE3054
	bool get_shiftKey() { }

	// RVA: 0x2FE3054
	bool get_ctrlKey() { }

	// RVA: 0x2FE3054
	bool get_commandKey() { }

	// RVA: 0x2FE3054
	bool get_altKey() { }

	// RVA: 0x2FE3054
	bool get_functionKey() { }

	// RVA: 0x2FE3054
	bool get_actionKey() { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x309AF8C
	T GetPooled(Event systemEvent) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.KeyDownEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171D9AC
	void .cctor() { }

	// RVA: 0x171DA18
	void .ctor() { }

	// RVA: 0x171DA20
	KeyDownEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class KeyDownEvent 
{
	// Methods

	// RVA: 0x171CD28
	void .cctor() { }

	// RVA: 0x171CE18
	void GetEquivalentImguiEvent(Event outImguiEvent) { }

	// RVA: 0x171CEE8
	void PostDispatch(IPanel panel) { }

	// RVA: 0x171D00C
	void SendEquivalentNavigationEventIfAny(IPanel panel) { }

	// RVA: 0x171D958
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class KeyboardEventExtensions 
{
	// Methods

	// RVA: 0x171D7D0
	bool ShouldSendNavigationMoveEvent(KeyDownEvent e) { }

	// RVA: 0x171DAAC
	bool ShouldSendNavigationMoveEventRuntime(Event e) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.KeyUpEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171DC48
	void .cctor() { }

	// RVA: 0x171DCB4
	void .ctor() { }

	// RVA: 0x171DCBC
	KeyUpEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class KeyUpEvent 
{
	// Methods

	// RVA: 0x171DB04
	void .cctor() { }

	// RVA: 0x171DBF4
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.GeometryChangedEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171E0B8
	void .cctor() { }

	// RVA: 0x171E124
	void .ctor() { }

	// RVA: 0x171E12C
	GeometryChangedEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class GeometryChangedEvent 
{
	// Fields
	private Rect <oldRect>k__BackingField; // 0x84
	private Rect <newRect>k__BackingField; // 0x94
	private int <layoutPass>k__BackingField; // 0xA4

	// Methods

	// RVA: 0x171DD48
	void .cctor() { }

	// RVA: 0x171DE38
	GeometryChangedEvent GetPooled(Rect oldRect, Rect newRect) { }

	// RVA: 0x171DF1C
	void Init() { }

	// RVA: 0x171DF98
	void LocalInit() { }

	// RVA: 0x171DFD8
	Rect get_oldRect() { }

	// RVA: 0x171DFE4
	void set_oldRect(Rect value) { }

	// RVA: 0x171DFF0
	Rect get_newRect() { }

	// RVA: 0x171DFFC
	void set_newRect(Rect value) { }

	// RVA: 0x171E008
	int get_layoutPass() { }

	// RVA: 0x171E010
	void set_layoutPass(int value) { }

	// RVA: 0x171E018
	void .ctor() { }

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

	// RVA: 0x171E180
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x171E220
	void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x1715A88
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class MouseEventDispatchingStrategy 
{
	// Methods

	// RVA: 0x171E7EC
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x171E84C
	void DispatchEvent(EventBase evt, IPanel iPanel) { }

	// RVA: 0x171EA8C
	bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x171EACC
	bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x171EBC8
	bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x171E988
	void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel) { }

	// RVA: 0x171EE04
	void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse) { }

	// RVA: 0x171EDB0
	bool IsDone(EventBase evt) { }

	// RVA: 0x1715A98
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IMouseEvent 
{
	// Methods

	// RVA: 0x2FE32D4
	EventModifiers get_modifiers() { }

	// RVA: -1
	Vector2 get_mousePosition() { }

	// RVA: -1
	Vector2 get_localMousePosition() { }

	// RVA: -1
	Vector2 get_mouseDelta() { }

	// RVA: 0x2FE32D4
	int get_clickCount() { }

	// RVA: 0x2FE32D4
	int get_button() { }

	// RVA: 0x2FE32D4
	int get_pressedButtons() { }

	// RVA: 0x2FE3054
	bool get_shiftKey() { }

	// RVA: 0x2FE3054
	bool get_ctrlKey() { }

	// RVA: 0x2FE3054
	bool get_commandKey() { }

	// RVA: 0x2FE3054
	bool get_altKey() { }

}

// Namespace: UnityEngine.UIElements
internal interface IMouseEventInternal 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_triggeredByOS() { }

	// RVA: 0x2FE4234
	void set_triggeredByOS(bool value) { }

	// RVA: 0x2FE3054
	bool get_recomputeTopElementUnderMouse() { }

	// RVA: 0x2FE4234
	void set_recomputeTopElementUnderMouse(bool value) { }

	// RVA: 0x2FE360C
	IPointerEvent get_sourcePointerEvent() { }

	// RVA: 0x2FE4574
	void set_sourcePointerEvent(IPointerEvent value) { }

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

	// RVA: 0x2FE32D4
	EventModifiers get_modifiers() { }

	// RVA: 0x2FE42A4
	void set_modifiers(EventModifiers value) { }

	// RVA: -1
	Vector2 get_mousePosition() { }

	// RVA: -1
	void set_mousePosition(Vector2 value) { }

	// RVA: -1
	Vector2 get_localMousePosition() { }

	// RVA: -1
	void set_localMousePosition(Vector2 value) { }

	// RVA: -1
	Vector2 get_mouseDelta() { }

	// RVA: -1
	void set_mouseDelta(Vector2 value) { }

	// RVA: 0x2FE32D4
	int get_clickCount() { }

	// RVA: 0x2FE42A4
	void set_clickCount(int value) { }

	// RVA: 0x2FE32D4
	int get_button() { }

	// RVA: 0x2FE42A4
	void set_button(int value) { }

	// RVA: 0x2FE32D4
	int get_pressedButtons() { }

	// RVA: 0x2FE42A4
	void set_pressedButtons(int value) { }

	// RVA: 0x2FE3054
	bool get_shiftKey() { }

	// RVA: 0x2FE3054
	bool get_ctrlKey() { }

	// RVA: 0x2FE3054
	bool get_commandKey() { }

	// RVA: 0x2FE3054
	bool get_altKey() { }

	// RVA: 0x2FE3054
	bool UnityEngine.UIElements.IMouseEventInternal.get_triggeredByOS() { }

	// RVA: 0x2FE4234
	void UnityEngine.UIElements.IMouseEventInternal.set_triggeredByOS(bool value) { }

	// RVA: 0x2FE3054
	bool UnityEngine.UIElements.IMouseEventInternal.get_recomputeTopElementUnderMouse() { }

	// RVA: 0x2FE4234
	void UnityEngine.UIElements.IMouseEventInternal.set_recomputeTopElementUnderMouse(bool value) { }

	// RVA: 0x2FE360C
	IPointerEvent UnityEngine.UIElements.IMouseEventInternal.get_sourcePointerEvent() { }

	// RVA: 0x2FE4574
	void UnityEngine.UIElements.IMouseEventInternal.set_sourcePointerEvent(IPointerEvent value) { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x2FE360C
	IEventHandler get_currentTarget() { }

	// RVA: 0x2FE4574
	void set_currentTarget(IEventHandler value) { }

	// RVA: 0x2FE4574
	void PreDispatch(IPanel panel) { }

	// RVA: 0x2FE4574
	void PostDispatch(IPanel panel) { }

	// RVA: 0x309AF8C
	T GetPooled(Event systemEvent) { }

	// RVA: 0x309AF8C
	T GetPooled(IMouseEvent triggerEvent, Vector2 mousePosition, bool recomputeTopElementUnderMouse) { }

	// RVA: 0x309AF8C
	T GetPooled(IMouseEvent triggerEvent) { }

	// RVA: 0x309AF8C
	T GetPooled(IPointerEvent pointerEvent) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseDownEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171F5E4
	void .cctor() { }

	// RVA: 0x171F650
	void .ctor() { }

	// RVA: 0x171F658
	MouseDownEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseDownEvent 
{
	// Methods

	// RVA: 0x171F158
	void .cctor() { }

	// RVA: 0x171F248
	void Init() { }

	// RVA: 0x171F2A8
	void LocalInit() { }

	// RVA: 0x171F2B4
	void .ctor() { }

	// RVA: 0x171F314
	MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

	// RVA: 0x171F4E4
	MouseDownEvent GetPooled(PointerDownEvent pointerEvent) { }

	// RVA: 0x171F564
	MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseUpEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171FBF8
	void .cctor() { }

	// RVA: 0x171FC64
	void .ctor() { }

	// RVA: 0x171FC6C
	MouseUpEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseUpEvent 
{
	// Methods

	// RVA: 0x171F6EC
	void .cctor() { }

	// RVA: 0x171F7DC
	void Init() { }

	// RVA: 0x171F83C
	void LocalInit() { }

	// RVA: 0x171F848
	void .ctor() { }

	// RVA: 0x171F8A8
	MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

	// RVA: 0x171FA78
	MouseUpEvent GetPooled(PointerUpEvent pointerEvent) { }

	// RVA: 0x171FAF8
	MouseUpEvent GetPooled(PointerMoveEvent pointerEvent) { }

	// RVA: 0x171FB78
	MouseUpEvent GetPooled(PointerCancelEvent pointerEvent) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseMoveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x171FF10
	void .cctor() { }

	// RVA: 0x171FF7C
	void .ctor() { }

	// RVA: 0x171FF84
	MouseMoveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseMoveEvent 
{
	// Methods

	// RVA: 0x171FD00
	void .cctor() { }

	// RVA: 0x171FDF0
	void Init() { }

	// RVA: 0x171FE50
	void LocalInit() { }

	// RVA: 0x171FE5C
	void .ctor() { }

	// RVA: 0x171FEBC
	MouseMoveEvent GetPooled(PointerMoveEvent pointerEvent) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.ContextClickEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172015C
	void .cctor() { }

	// RVA: 0x17201C8
	void .ctor() { }

	// RVA: 0x17201D0
	ContextClickEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ContextClickEvent 
{
	// Methods

	// RVA: 0x1720018
	void .cctor() { }

	// RVA: 0x1720108
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.WheelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1720614
	void .cctor() { }

	// RVA: 0x1720680
	void .ctor() { }

	// RVA: 0x1720688
	WheelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class WheelEvent 
{
	// Fields
	private Vector3 <delta>k__BackingField; // 0xB8

	// Methods

	// RVA: 0x172025C
	void .cctor() { }

	// RVA: 0x172034C
	Vector3 get_delta() { }

	// RVA: 0x1720358
	void set_delta(Vector3 value) { }

	// RVA: 0x1720364
	WheelEvent GetPooled(Event systemEvent) { }

	// RVA: 0x1706450
	WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition, EventModifiers modifiers) { }

	// RVA: 0x17203EC
	WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent) { }

	// RVA: 0x1720470
	void Init() { }

	// RVA: 0x1720510
	void LocalInit() { }

	// RVA: 0x1720574
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseEnterEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1720918
	void .cctor() { }

	// RVA: 0x1720984
	void .ctor() { }

	// RVA: 0x172098C
	MouseEnterEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseEnterEvent 
{
	// Methods

	// RVA: 0x172075C
	void .cctor() { }

	// RVA: 0x172084C
	void Init() { }

	// RVA: 0x17208AC
	void LocalInit() { }

	// RVA: 0x17208B8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseLeaveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1720BDC
	void .cctor() { }

	// RVA: 0x1720C48
	void .ctor() { }

	// RVA: 0x1720C50
	MouseLeaveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseLeaveEvent 
{
	// Methods

	// RVA: 0x1720A20
	void .cctor() { }

	// RVA: 0x1720B10
	void Init() { }

	// RVA: 0x1720B70
	void LocalInit() { }

	// RVA: 0x1720B7C
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseEnterWindowEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1721018
	void .cctor() { }

	// RVA: 0x1721084
	void .ctor() { }

	// RVA: 0x172108C
	MouseEnterWindowEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseEnterWindowEvent 
{
	// Methods

	// RVA: 0x1720CE4
	void .cctor() { }

	// RVA: 0x1720DD4
	void Init() { }

	// RVA: 0x1720E34
	void LocalInit() { }

	// RVA: 0x1720E40
	void .ctor() { }

	// RVA: 0x1720EA0
	void PostDispatch(IPanel panel) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseLeaveWindowEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17216D0
	void .cctor() { }

	// RVA: 0x172173C
	void .ctor() { }

	// RVA: 0x1721744
	MouseLeaveWindowEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseLeaveWindowEvent 
{
	// Methods

	// RVA: 0x1721120
	void .cctor() { }

	// RVA: 0x1721210
	void Init() { }

	// RVA: 0x17212F4
	void LocalInit() { }

	// RVA: 0x17213A4
	void .ctor() { }

	// RVA: 0x1721488
	MouseLeaveWindowEvent GetPooled(Event systemEvent) { }

	// RVA: 0x1721558
	void PostDispatch(IPanel panel) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseOverEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17218E0
	void .cctor() { }

	// RVA: 0x172194C
	void .ctor() { }

	// RVA: 0x1721954
	MouseOverEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseOverEvent 
{
	// Methods

	// RVA: 0x172179C
	void .cctor() { }

	// RVA: 0x172188C
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.MouseOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1721B24
	void .cctor() { }

	// RVA: 0x1721B90
	void .ctor() { }

	// RVA: 0x1721B98
	MouseOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class MouseOutEvent 
{
	// Methods

	// RVA: 0x17219E0
	void .cctor() { }

	// RVA: 0x1721AD0
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.ContextualMenuPopulateEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1722760
	void .cctor() { }

	// RVA: 0x17227CC
	void .ctor() { }

	// RVA: 0x17227D4
	ContextualMenuPopulateEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class ContextualMenuPopulateEvent 
{
	// Fields
	private DropdownMenu <menu>k__BackingField; // 0xB8
	private EventBase <triggerEvent>k__BackingField; // 0xC0
	private ContextualMenuManager m_ContextualMenuManager; // 0xC8

	// Methods

	// RVA: 0x1721C24
	void .cctor() { }

	// RVA: 0x1721D14
	DropdownMenu get_menu() { }

	// RVA: 0x1721D1C
	void set_menu(DropdownMenu value) { }

	// RVA: 0x1721D24
	EventBase get_triggerEvent() { }

	// RVA: 0x1721D2C
	void set_triggerEvent(EventBase value) { }

	// RVA: 0x1721D34
	ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager) { }

	// RVA: 0x17224FC
	void Init() { }

	// RVA: 0x17225A8
	void LocalInit() { }

	// RVA: 0x1722610
	void .ctor() { }

	// RVA: 0x17226BC
	void PostDispatch(IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal static class MouseEventsHelper 
{
	// Methods

	// RVA: 0x309AF8C
	void SendEnterLeave(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

	// RVA: 0x17228AC
	void SendMouseOverMouseOut(VisualElement previousTopElementUnderMouse, VisualElement currentTopElementUnderMouse, IMouseEvent triggerEvent, Vector2 mousePosition) { }

}

// Namespace: UnityEngine.UIElements
internal static class PointerEventsHelper 
{
	// Methods

	// RVA: 0x309AF8C
	void SendEnterLeave(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	// RVA: 0x1722B98
	void SendOverOut(VisualElement previousTopElementUnderPointer, VisualElement currentTopElementUnderPointer, IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

}

// Namespace: UnityEngine.UIElements
internal class NavigationEventDispatchingStrategy 
{
	// Methods

	// RVA: 0x1722E88
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1722EE8
	void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x17231C4
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface INavigationEvent 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_shiftKey() { }

	// RVA: 0x2FE3054
	bool get_altKey() { }

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

	// RVA: 0x2FE32D4
	EventModifiers get_modifiers() { }

	// RVA: 0x2FE42A4
	void set_modifiers(EventModifiers value) { }

	// RVA: 0x2FE3054
	bool get_shiftKey() { }

	// RVA: 0x2FE3054
	bool get_altKey() { }

	// RVA: 0x2FE32D4
	NavigationDeviceType get_deviceType() { }

	// RVA: 0x2FE42A4
	void set_deviceType(NavigationDeviceType value) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x309AF8C
	T GetPooled(EventModifiers modifiers) { }

	// RVA: 0x309AF8C
	T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers) { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.NavigationMoveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17237FC
	void .cctor() { }

	// RVA: 0x1723868
	void .ctor() { }

	// RVA: 0x1723870
	NavigationMoveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class NavigationMoveEvent 
{
	// Fields
	private Direction <direction>k__BackingField; // 0x8C
	private Vector2 <move>k__BackingField; // 0x90

	// Methods

	// RVA: 0x17231CC
	void .cctor() { }

	// RVA: 0x17232BC
	Direction DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x172330C
	Direction get_direction() { }

	// RVA: 0x1723314
	void set_direction(Direction value) { }

	// RVA: 0x172331C
	void set_move(Vector2 value) { }

	// RVA: 0x1723324
	NavigationMoveEvent GetPooled(Vector2 moveVector, EventModifiers modifiers) { }

	// RVA: 0x1723418
	NavigationMoveEvent GetPooled(Vector2 moveVector, NavigationDeviceType deviceType, EventModifiers modifiers) { }

	// RVA: 0x1723518
	NavigationMoveEvent GetPooled(Direction direction, EventModifiers modifiers) { }

	// RVA: 0x17235C4
	NavigationMoveEvent GetPooled(Direction direction, NavigationDeviceType deviceType, EventModifiers modifiers) { }

	// RVA: 0x172367C
	void Init() { }

	// RVA: 0x1723768
	void .ctor() { }

	// RVA: 0x1723710
	void LocalInit() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.NavigationCancelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1723A7C
	void .cctor() { }

	// RVA: 0x1723AE8
	void .ctor() { }

	// RVA: 0x1723AF0
	NavigationCancelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class NavigationCancelEvent 
{
	// Methods

	// RVA: 0x1723938
	void .cctor() { }

	// RVA: 0x1723A28
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.NavigationSubmitEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1723CC0
	void .cctor() { }

	// RVA: 0x1723D2C
	void .ctor() { }

	// RVA: 0x1723D34
	NavigationSubmitEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class NavigationSubmitEvent 
{
	// Methods

	// RVA: 0x1723B7C
	void .cctor() { }

	// RVA: 0x1723C6C
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class PanelChangedEventBase<T0> 
{
	// Fields
	private IPanel <originPanel>k__BackingField; // 0x0
	private IPanel <destinationPanel>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE360C
	IPanel get_originPanel() { }

	// RVA: 0x2FE4574
	void set_originPanel(IPanel value) { }

	// RVA: 0x2FE360C
	IPanel get_destinationPanel() { }

	// RVA: 0x2FE4574
	void set_destinationPanel(IPanel value) { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x309AF8C
	T GetPooled(IPanel originPanel, IPanel destinationPanel) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.AttachToPanelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1723F04
	void .cctor() { }

	// RVA: 0x1723F70
	void .ctor() { }

	// RVA: 0x1723F78
	AttachToPanelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class AttachToPanelEvent 
{
	// Methods

	// RVA: 0x1723DC0
	void .cctor() { }

	// RVA: 0x1723EB0
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.DetachFromPanelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1724148
	void .cctor() { }

	// RVA: 0x17241B4
	void .ctor() { }

	// RVA: 0x17241BC
	DetachFromPanelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class DetachFromPanelEvent 
{
	// Methods

	// RVA: 0x1724004
	void .cctor() { }

	// RVA: 0x17240F4
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class PointerCaptureDispatchingStrategy 
{
	// Methods

	// RVA: 0x1724248
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x17242A8
	void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x1724968
	void .ctor() { }

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

	// RVA: 0x17255C4
	Vector2 get_Position() { }

	// RVA: 0x17255CC
	void set_Position(Vector2 value) { }

	// RVA: 0x17255D4
	IPanel get_Panel() { }

	// RVA: 0x17255DC
	void set_Panel(IPanel value) { }

	// RVA: 0x17255E4
	LocationFlag get_Flags() { }

	// RVA: 0x17255EC
	void set_Flags(LocationFlag value) { }

	// RVA: 0x1724B98
	void SetLocation(Vector2 position, IPanel panel) { }

}

// Namespace: UnityEngine.UIElements
internal static class PointerDeviceState 
{
	// Fields
	private static PointerLocation[] s_PlayerPointerLocations; // 0x0
	private static int[] s_PressedButtons; // 0x8
	private static readonly IPanel[] s_PlayerPanelWithSoftPointerCapture; // 0x10

	// Methods

	// RVA: 0x1724970
	void RemovePanelData(IPanel panel) { }

	// RVA: 0x1724CB0
	void SavePointerPosition(int pointerId, Vector2 position, IPanel panel, ContextType contextType) { }

	// RVA: 0x1724D74
	void PressButton(int pointerId, int buttonId) { }

	// RVA: 0x1724E54
	void ReleaseButton(int pointerId, int buttonId) { }

	// RVA: 0x1724F34
	void ReleaseAllButtons(int pointerId) { }

	// RVA: 0x1724FD4
	Vector2 GetPointerPosition(int pointerId, ContextType contextType) { }

	// RVA: 0x1725078
	IPanel GetPanel(int pointerId, ContextType contextType) { }

	// RVA: 0x172511C
	bool HasFlagFast(LocationFlag flagSet, LocationFlag flag) { }

	// RVA: 0x1725128
	bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag) { }

	// RVA: 0x17251D8
	int GetPressedButtons(int pointerId) { }

	// RVA: 0x1725278
	bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId) { }

	// RVA: 0x172532C
	void SetPlayerPanelWithSoftPointerCapture(int pointerId, IPanel panel) { }

	// RVA: 0x17253F8
	IPanel GetPlayerPanelWithSoftPointerCapture(int pointerId) { }

	// RVA: 0x1725498
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class PointerEventDispatchingStrategy 
{
	// Methods

	// RVA: 0x17255F4
	bool CanDispatchEvent(EventBase evt) { }

	// RVA: 0x1725654
	void DispatchEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x17259A8
	void SendEventToTarget(EventBase evt, IPanel panel) { }

	// RVA: 0x172571C
	void SetBestTargetForEvent(EventBase evt, IPanel panel) { }

	// RVA: 0x1725A64
	void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer) { }

	// RVA: 0x1725D78
	void .ctor() { }

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

	// RVA: 0x1725D80
	string GetPointerType(int pointerId) { }

	// RVA: 0x1725EB4
	bool IsDirectManipulationDevice(string pointerType) { }

	// RVA: 0x1725F74
	void .cctor() { }

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

	// RVA: 0x172606C
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IPointerEvent 
{
	// Methods

	// RVA: 0x2FE32D4
	int get_pointerId() { }

	// RVA: 0x2FE360C
	string get_pointerType() { }

	// RVA: 0x2FE3054
	bool get_isPrimary() { }

	// RVA: 0x2FE32D4
	int get_button() { }

	// RVA: 0x2FE32D4
	int get_pressedButtons() { }

	// RVA: -1
	Vector3 get_position() { }

	// RVA: -1
	Vector3 get_localPosition() { }

	// RVA: -1
	Vector3 get_deltaPosition() { }

	// RVA: -1
	float get_deltaTime() { }

	// RVA: 0x2FE32D4
	int get_clickCount() { }

	// RVA: -1
	float get_pressure() { }

	// RVA: -1
	float get_tangentialPressure() { }

	// RVA: -1
	float get_altitudeAngle() { }

	// RVA: -1
	float get_azimuthAngle() { }

	// RVA: -1
	float get_twist() { }

	// RVA: -1
	Vector2 get_tilt() { }

	// RVA: 0x2FE32D4
	PenStatus get_penStatus() { }

	// RVA: -1
	Vector2 get_radius() { }

	// RVA: -1
	Vector2 get_radiusVariance() { }

	// RVA: 0x2FE32D4
	EventModifiers get_modifiers() { }

	// RVA: 0x2FE3054
	bool get_shiftKey() { }

	// RVA: 0x2FE3054
	bool get_ctrlKey() { }

	// RVA: 0x2FE3054
	bool get_commandKey() { }

	// RVA: 0x2FE3054
	bool get_altKey() { }

	// RVA: 0x2FE3054
	bool get_actionKey() { }

}

// Namespace: UnityEngine.UIElements
internal interface IPointerEventInternal 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_triggeredByOS() { }

	// RVA: 0x2FE4234
	void set_triggeredByOS(bool value) { }

	// RVA: 0x2FE3054
	bool get_recomputeTopElementUnderPointer() { }

	// RVA: 0x2FE4234
	void set_recomputeTopElementUnderPointer(bool value) { }

}

// Namespace: UnityEngine.UIElements
internal static class PointerEventHelper 
{
	// Methods

	// RVA: 0x1726128
	EventBase GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers) { }

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

	// RVA: 0x2FE32D4
	int get_pointerId() { }

	// RVA: 0x2FE42A4
	void set_pointerId(int value) { }

	// RVA: 0x2FE360C
	string get_pointerType() { }

	// RVA: 0x2FE4574
	void set_pointerType(string value) { }

	// RVA: 0x2FE3054
	bool get_isPrimary() { }

	// RVA: 0x2FE4234
	void set_isPrimary(bool value) { }

	// RVA: 0x2FE32D4
	int get_button() { }

	// RVA: 0x2FE42A4
	void set_button(int value) { }

	// RVA: 0x2FE32D4
	int get_pressedButtons() { }

	// RVA: 0x2FE42A4
	void set_pressedButtons(int value) { }

	// RVA: -1
	Vector3 get_position() { }

	// RVA: -1
	void set_position(Vector3 value) { }

	// RVA: -1
	Vector3 get_localPosition() { }

	// RVA: -1
	void set_localPosition(Vector3 value) { }

	// RVA: -1
	Vector3 get_deltaPosition() { }

	// RVA: -1
	void set_deltaPosition(Vector3 value) { }

	// RVA: -1
	float get_deltaTime() { }

	// RVA: -1
	void set_deltaTime(float value) { }

	// RVA: 0x2FE32D4
	int get_clickCount() { }

	// RVA: 0x2FE42A4
	void set_clickCount(int value) { }

	// RVA: -1
	float get_pressure() { }

	// RVA: -1
	void set_pressure(float value) { }

	// RVA: -1
	float get_tangentialPressure() { }

	// RVA: -1
	void set_tangentialPressure(float value) { }

	// RVA: -1
	float get_altitudeAngle() { }

	// RVA: -1
	void set_altitudeAngle(float value) { }

	// RVA: -1
	float get_azimuthAngle() { }

	// RVA: -1
	void set_azimuthAngle(float value) { }

	// RVA: -1
	float get_twist() { }

	// RVA: -1
	void set_twist(float value) { }

	// RVA: -1
	Vector2 get_tilt() { }

	// RVA: -1
	void set_tilt(Vector2 value) { }

	// RVA: 0x2FE32D4
	PenStatus get_penStatus() { }

	// RVA: 0x2FE42A4
	void set_penStatus(PenStatus value) { }

	// RVA: -1
	Vector2 get_radius() { }

	// RVA: -1
	void set_radius(Vector2 value) { }

	// RVA: -1
	Vector2 get_radiusVariance() { }

	// RVA: -1
	void set_radiusVariance(Vector2 value) { }

	// RVA: 0x2FE32D4
	EventModifiers get_modifiers() { }

	// RVA: 0x2FE42A4
	void set_modifiers(EventModifiers value) { }

	// RVA: 0x2FE3054
	bool get_shiftKey() { }

	// RVA: 0x2FE3054
	bool get_ctrlKey() { }

	// RVA: 0x2FE3054
	bool get_commandKey() { }

	// RVA: 0x2FE3054
	bool get_altKey() { }

	// RVA: 0x2FE3054
	bool get_actionKey() { }

	// RVA: 0x2FE3054
	bool UnityEngine.UIElements.IPointerEventInternal.get_triggeredByOS() { }

	// RVA: 0x2FE4234
	void UnityEngine.UIElements.IPointerEventInternal.set_triggeredByOS(bool value) { }

	// RVA: 0x2FE3054
	bool UnityEngine.UIElements.IPointerEventInternal.get_recomputeTopElementUnderPointer() { }

	// RVA: 0x2FE4234
	void UnityEngine.UIElements.IPointerEventInternal.set_recomputeTopElementUnderPointer(bool value) { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x2FE360C
	IEventHandler get_currentTarget() { }

	// RVA: 0x2FE4574
	void set_currentTarget(IEventHandler value) { }

	// RVA: 0x2FE5724
	bool IsMouse(Event systemEvent) { }

	// RVA: 0x2FE5724
	bool IsTouch(Event systemEvent) { }

	// RVA: 0x309AF8C
	float TiltToAzimuth(Vector2 tilt) { }

	// RVA: 0x309AF8C
	Vector2 AzimuthAndAlitutudeToTilt(float altitude, float azimuth) { }

	// RVA: 0x309AF8C
	float TiltToAltitude(Vector2 tilt) { }

	// RVA: 0x309AF8C
	T GetPooled(Event systemEvent) { }

	// RVA: 0x309AF8C
	T GetPooled(EventType eventType, Vector3 mousePosition, Vector2 delta, int button, int clickCount, EventModifiers modifiers) { }

	// RVA: 0x309AF8C
	T GetPooled(Touch touch, EventModifiers modifiers) { }

	// RVA: 0x309AF8C
	T GetPooled(PenData pen, EventModifiers modifiers) { }

	// RVA: 0x309AF8C
	T GetPooled(IPointerEvent triggerEvent, Vector2 position, int pointerId) { }

	// RVA: 0x309AF8C
	T GetPooled(IPointerEvent triggerEvent) { }

	// RVA: 0x2FE4574
	void PreDispatch(IPanel panel) { }

	// RVA: 0x2FE4574
	void PostDispatch(IPanel panel) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerDownEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1726920
	void .cctor() { }

	// RVA: 0x172698C
	void .ctor() { }

	// RVA: 0x1726994
	PointerDownEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerDownEvent 
{
	// Methods

	// RVA: 0x17263D8
	void .cctor() { }

	// RVA: 0x17264C8
	void Init() { }

	// RVA: 0x1726524
	void LocalInit() { }

	// RVA: 0x1726634
	void .ctor() { }

	// RVA: 0x1726690
	void PostDispatch(IPanel panel) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerMoveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172738C
	void .cctor() { }

	// RVA: 0x17273F8
	void .ctor() { }

	// RVA: 0x1727400
	PointerMoveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerMoveEvent 
{
	// Fields
	private bool <isHandledByDraggable>k__BackingField; // 0x106

	// Methods

	// RVA: 0x1726A28
	void .cctor() { }

	// RVA: 0x1726B18
	bool get_isHandledByDraggable() { }

	// RVA: 0x1726B20
	void set_isHandledByDraggable(bool value) { }

	// RVA: 0x1726B28
	void Init() { }

	// RVA: 0x1726B84
	void LocalInit() { }

	// RVA: 0x1726C9C
	void .ctor() { }

	// RVA: 0x1726CF8
	void PostDispatch(IPanel panel) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerStationaryEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172774C
	void .cctor() { }

	// RVA: 0x17277B8
	void .ctor() { }

	// RVA: 0x17277C0
	PointerStationaryEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerStationaryEvent 
{
	// Methods

	// RVA: 0x1727494
	void .cctor() { }

	// RVA: 0x1727584
	void Init() { }

	// RVA: 0x17275E0
	void LocalInit() { }

	// RVA: 0x17276F0
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerUpEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1727F44
	void .cctor() { }

	// RVA: 0x1727FB0
	void .ctor() { }

	// RVA: 0x1727FB8
	PointerUpEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerUpEvent 
{
	// Methods

	// RVA: 0x1727854
	void .cctor() { }

	// RVA: 0x1727944
	void Init() { }

	// RVA: 0x17279A0
	void LocalInit() { }

	// RVA: 0x1727AB0
	void .ctor() { }

	// RVA: 0x1727B0C
	void PostDispatch(IPanel panel) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerCancelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1728700
	void .cctor() { }

	// RVA: 0x172876C
	void .ctor() { }

	// RVA: 0x1728774
	PointerCancelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerCancelEvent 
{
	// Methods

	// RVA: 0x172804C
	void .cctor() { }

	// RVA: 0x172813C
	void Init() { }

	// RVA: 0x1728198
	void LocalInit() { }

	// RVA: 0x17282A8
	void .ctor() { }

	// RVA: 0x1728304
	void PostDispatch(IPanel panel) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.ClickEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1728A38
	void .cctor() { }

	// RVA: 0x1728AA4
	void .ctor() { }

	// RVA: 0x1728AAC
	ClickEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class ClickEvent 
{
	// Methods

	// RVA: 0x1728808
	void .cctor() { }

	// RVA: 0x17288F8
	void Init() { }

	// RVA: 0x1728958
	void LocalInit() { }

	// RVA: 0x1728964
	void .ctor() { }

	// RVA: 0x17289C4
	ClickEvent GetPooled(PointerUpEvent pointerEvent, int clickCount) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerEnterEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1728CFC
	void .cctor() { }

	// RVA: 0x1728D68
	void .ctor() { }

	// RVA: 0x1728D70
	PointerEnterEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerEnterEvent 
{
	// Methods

	// RVA: 0x1728B40
	void .cctor() { }

	// RVA: 0x1728C30
	void Init() { }

	// RVA: 0x1728C90
	void LocalInit() { }

	// RVA: 0x1728C9C
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerLeaveEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1728FC0
	void .cctor() { }

	// RVA: 0x172902C
	void .ctor() { }

	// RVA: 0x1729034
	PointerLeaveEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerLeaveEvent 
{
	// Methods

	// RVA: 0x1728E04
	void .cctor() { }

	// RVA: 0x1728EF4
	void Init() { }

	// RVA: 0x1728F54
	void LocalInit() { }

	// RVA: 0x1728F60
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerOverEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172920C
	void .cctor() { }

	// RVA: 0x1729278
	void .ctor() { }

	// RVA: 0x1729280
	PointerOverEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerOverEvent 
{
	// Methods

	// RVA: 0x17290C8
	void .cctor() { }

	// RVA: 0x17291B8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PointerOutEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1729450
	void .cctor() { }

	// RVA: 0x17294BC
	void .ctor() { }

	// RVA: 0x17294C4
	PointerOutEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class PointerOutEvent 
{
	// Methods

	// RVA: 0x172930C
	void .cctor() { }

	// RVA: 0x17293FC
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.PropagationPaths.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1729B08
	void .cctor() { }

	// RVA: 0x1729B74
	void .ctor() { }

	// RVA: 0x1729B7C
	PropagationPaths <.cctor>b__12_0() { }

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

	// RVA: 0x1729550
	void .ctor() { }

	// RVA: 0x1729630
	PropagationPaths Build(VisualElement elem, EventBase evt) { }

	// RVA: 0x1729838
	void Release() { }

	// RVA: 0x17299E8
	void .cctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.CustomStyleResolvedEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1729DF8
	void .cctor() { }

	// RVA: 0x1729E64
	void .ctor() { }

	// RVA: 0x1729E6C
	CustomStyleResolvedEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class CustomStyleResolvedEvent 
{
	// Methods

	// RVA: 0x1729BD0
	void .cctor() { }

	// RVA: 0x1729CC0
	ICustomStyle get_customStyle() { }

	// RVA: 0x1729D54
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.TooltipEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172A220
	void .cctor() { }

	// RVA: 0x172A28C
	void .ctor() { }

	// RVA: 0x172A294
	TooltipEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class TooltipEvent 
{
	// Fields
	private string <tooltip>k__BackingField; // 0x88
	private Rect <rect>k__BackingField; // 0x90

	// Methods

	// RVA: 0x1729F1C
	void .cctor() { }

	// RVA: 0x172A00C
	void set_tooltip(string value) { }

	// RVA: 0x172A014
	void set_rect(Rect value) { }

	// RVA: 0x172A020
	void Init() { }

	// RVA: 0x172A0D0
	void LocalInit() { }

	// RVA: 0x172A14C
	void .ctor() { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private Enumerator m_Enumerator; // 0x10

	// Methods

	// RVA: 0x172A380
	void .ctor(Enumerator enumerator) { }

	// RVA: 0x172A520
	bool MoveNext() { }

	// RVA: 0x172A574
	StylePropertyName get_Current() { }

	// RVA: 0x172A648
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x172A784
	void Reset() { }

	// RVA: 0x172A788
	void Dispose() { }

}

// Namespace: UnityEngine.UIElements
public struct StylePropertyNameCollection 
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> propertiesList; // 0x10

	// Methods

	// RVA: 0x172A2E8
	void .ctor(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list) { }

	// RVA: 0x172A2F0
	Enumerator GetEnumerator() { }

	// RVA: 0x172A390
	System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StylePropertyName> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StylePropertyName>.GetEnumerator() { }

	// RVA: 0x172A458
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.UIElements
public abstract class TransitionEventBase<T0> 
{
	// Fields
	private readonly StylePropertyNameCollection <stylePropertyNames>k__BackingField; // 0x0
	private Double <elapsedTime>k__BackingField; // 0x0

	// Methods

	// RVA: 0x309AF8C
	StylePropertyNameCollection get_stylePropertyNames() { }

	// RVA: -1
	void set_elapsedTime(Double value) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void Init() { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x309AF8C
	T GetPooled(StylePropertyName stylePropertyName, Double elapsedTime) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionRunEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172A920
	void .cctor() { }

	// RVA: 0x172A98C
	void .ctor() { }

	// RVA: 0x172A994
	TransitionRunEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionRunEvent 
{
	// Methods

	// RVA: 0x172A7DC
	void .cctor() { }

	// RVA: 0x172A8CC
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionStartEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172AB64
	void .cctor() { }

	// RVA: 0x172ABD0
	void .ctor() { }

	// RVA: 0x172ABD8
	TransitionStartEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionStartEvent 
{
	// Methods

	// RVA: 0x172AA20
	void .cctor() { }

	// RVA: 0x172AB10
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionEndEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172ADA8
	void .cctor() { }

	// RVA: 0x172AE14
	void .ctor() { }

	// RVA: 0x172AE1C
	TransitionEndEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionEndEvent 
{
	// Methods

	// RVA: 0x172AC64
	void .cctor() { }

	// RVA: 0x172AD54
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.TransitionCancelEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172AFEC
	void .cctor() { }

	// RVA: 0x172B058
	void .ctor() { }

	// RVA: 0x172B060
	TransitionCancelEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public sealed class TransitionCancelEvent 
{
	// Methods

	// RVA: 0x172AEA8
	void .cctor() { }

	// RVA: 0x172AF98
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.IMGUIEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x172B380
	void .cctor() { }

	// RVA: 0x172B3EC
	void .ctor() { }

	// RVA: 0x172B3F4
	IMGUIEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements
public class IMGUIEvent 
{
	// Methods

	// RVA: 0x172B0EC
	void .cctor() { }

	// RVA: 0x172B1DC
	IMGUIEvent GetPooled(Event systemEvent) { }

	// RVA: 0x172B290
	void Init() { }

	// RVA: 0x172B2F0
	void LocalInit() { }

	// RVA: 0x172B2FC
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseFieldMouseDragger 
{
	// Methods

	// RVA: 0x172B4AC
	void SetDragZone(VisualElement dragElement) { }

	// RVA: -1
	void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	// RVA: 0x172B4C8
	void .ctor() { }

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

	// RVA: 0x2FE4574
	void .ctor(UnityEngine.UIElements.IValueField<T> drivenField) { }

	// RVA: 0x2FE3054
	bool get_dragging() { }

	// RVA: 0x2FE4234
	void set_dragging(bool value) { }

	// RVA: 0x309AF8C
	T get_startValue() { }

	// RVA: 0x309AF8C
	void set_startValue(T value) { }

	// RVA: -1
	void SetDragZone(VisualElement dragElement, Rect hotZone) { }

	// RVA: 0x309AF8C
	bool CanStartDrag(int button, Vector2 localPosition) { }

	// RVA: 0x2FE4574
	void UpdateValueOnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x2FE4574
	void ProcessDownEvent(EventBase evt) { }

	// RVA: 0x2FE4574
	void UpdateValueOnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x309AF8C
	void ProcessMoveEvent(bool shiftKey, bool altKey, Vector2 deltaPosition) { }

	// RVA: 0x2FE4574
	void UpdateValueOnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x2FE45DC
	void ProcessUpEvent(EventBase evt, int pointerId) { }

	// RVA: 0x2FE4574
	void UpdateValueOnKeyDown(KeyDownEvent evt) { }

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

	// RVA: 0x172B4D0
	void .ctor() { }

	// RVA: 0x2FE360C
	FocusController get_focusController() { }

	// RVA: 0x172B500
	bool get_focusable() { }

	// RVA: 0x172B508
	void set_focusable(bool value) { }

	// RVA: 0x172B510
	int get_tabIndex() { }

	// RVA: 0x172B518
	void set_tabIndex(int value) { }

	// RVA: 0x172B520
	bool get_delegatesFocus() { }

	// RVA: 0x172B528
	void set_delegatesFocus(bool value) { }

	// RVA: 0x172B530
	bool get_excludeFromFocusRing() { }

	// RVA: 0x172B538
	void set_excludeFromFocusRing(bool value) { }

	// RVA: 0x172B620
	bool get_canGrabFocus() { }

	// RVA: 0x172B628
	void Focus() { }

	// RVA: 0x172BA58
	void Blur() { }

	// RVA: 0x172BC58
	void BlurImmediately() { }

	// RVA: 0x172B8D0
	Focusable GetFocusDelegate() { }

	// RVA: 0x172BCA0
	Focusable GetFirstFocusableChild(VisualElement ve) { }

	// RVA: 0x172BDDC
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x172BEAC
	void ExecuteDefaultActionDisabled(EventBase evt) { }

	// RVA: 0x172BE48
	void ProcessEvent(EventBase evt) { }

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

	// RVA: 0x172C218
	FocusChangeDirection get_unspecified() { }

	// RVA: 0x172C294
	FocusChangeDirection get_none() { }

	// RVA: 0x172C310
	FocusChangeDirection get_lastValue() { }

	// RVA: 0x172C38C
	void .ctor(int value) { }

	// RVA: 0x172C3B8
	int op_Implicit(FocusChangeDirection fcd) { }

	// RVA: 0x172C3C4
	void System.IDisposable.Dispose() { }

	// RVA: 0x172C3D0
	void Dispose() { }

	// RVA: 0x172C3D4
	void ApplyTo(FocusController focusController, Focusable f) { }

	// RVA: 0x172C73C
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IFocusRing 
{
	// Methods

	// RVA: 0x2FE37A0
	FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x2FE37A0
	Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

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

	// RVA: 0x172C844
	void .ctor(IFocusRing focusRing) { }

	// RVA: 0x172C8F8
	IFocusRing get_focusRing() { }

	// RVA: 0x172C900
	void set_selectedTextElement(TextElement value) { }

	// RVA: 0x172C9EC
	Focusable get_focusedElement() { }

	// RVA: 0x172CD44
	bool IsFocused(Focusable f) { }

	// RVA: 0x172CA34
	Focusable GetRetargetedFocusedElement(VisualElement retargetAgainst) { }

	// RVA: 0x17230F0
	Focusable GetLeafFocusedElement() { }

	// RVA: 0x172CCEC
	bool IsLocalElement(Focusable f) { }

	// RVA: 0x172CF60
	bool IsPendingFocus(Focusable f) { }

	// RVA: 0x172D04C
	void SetFocusToLastFocusedElement() { }

	// RVA: 0x172D0D8
	void BlurLastFocusedElement() { }

	// RVA: 0x172D184
	void DoFocusChange(Focusable f) { }

	// RVA: 0x172D338
	void ProcessPendingFocusChange(Focusable f) { }

	// RVA: 0x172D394
	Focusable FocusNextInDirection(FocusChangeDirection direction) { }

	// RVA: 0x172D53C
	void AboutToReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x172D6CC
	void ReleaseFocus(Focusable focusable, Focusable willGiveFocusTo, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x172D85C
	void AboutToGrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, DispatchMode dispatchMode) { }

	// RVA: 0x172D9EC
	void GrabFocus(Focusable focusable, Focusable willTakeFocusFrom, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x172BAA0
	void Blur(Focusable focusable, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x172B974
	void SwitchFocus(Focusable newFocusedElement, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x172C400
	void SwitchFocus(Focusable newFocusedElement, FocusChangeDirection direction, bool bIsFocusDelegated, DispatchMode dispatchMode) { }

	// RVA: 0x172BF18
	void SwitchFocusOnEvent(EventBase e) { }

	// RVA: 0x172DB80
	void ReevaluateFocus() { }

	// RVA: 0x172DC58
	bool GetFocusableParentForPointerEvent(Focusable target, out Focusable effectiveTarget) { }

	// RVA: 0x172DDB0
	int get_imguiKeyboardControl() { }

	// RVA: 0x172DDB8
	void set_imguiKeyboardControl(int value) { }

	// RVA: 0x172DDC0
	void SyncIMGUIFocus(int imguiKeyboardControlID, Focusable imguiContainerHavingKeyboardControl, bool forceSwitch) { }

}

// Namespace: UnityEngine.UIElements
public class DynamicAtlasSettings 
{
	// Fields
	private int m_MinAtlasSize; // 0x10
	private int m_MaxAtlasSize; // 0x14
	private int m_MaxSubTextureSize; // 0x18
	private DynamicAtlasFilters m_ActiveFilters; // 0x1C
	private DynamicAtlasCustomFilter m_CustomFilter; // 0x20

	// Methods

	// RVA: 0x172DEF0
	int get_minAtlasSize() { }

	// RVA: 0x172DEF8
	void set_minAtlasSize(int value) { }

	// RVA: 0x172DF00
	int get_maxAtlasSize() { }

	// RVA: 0x172DF08
	void set_maxAtlasSize(int value) { }

	// RVA: 0x172DF10
	int get_maxSubTextureSize() { }

	// RVA: 0x172DF18
	void set_maxSubTextureSize(int value) { }

	// RVA: 0x172DF20
	DynamicAtlasFilters get_activeFilters() { }

	// RVA: 0x172DF28
	void set_activeFilters(DynamicAtlasFilters value) { }

	// RVA: 0x172DF30
	DynamicAtlasFilters get_defaultFilters() { }

	// RVA: 0x172DF38
	DynamicAtlasCustomFilter get_customFilter() { }

	// RVA: 0x172DF40
	void set_customFilter(DynamicAtlasCustomFilter value) { }

	// RVA: 0x172DF48
	DynamicAtlasSettings get_defaults() { }

	// RVA: 0x172DFD8
	void .ctor() { }

}

// Namespace: 
public class ChangeDirection 
{
	// Methods

	// RVA: 0x172F0CC
	void .ctor(int i) { }

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

	// RVA: 0x172F13C
	bool ValidateHierarchyTraversal(VisualElement v) { }

	// RVA: 0x172F228
	bool ValidateElement(VisualElement v) { }

	// RVA: 0x172F334
	int Order(VisualElement a, VisualElement b) { }

	// RVA: 0x172F7D8
	int StrictOrder(VisualElement a, VisualElement b) { }

	// RVA: 0x172F4AC
	int StrictOrder(Rect ra, Rect rb) { }

	// RVA: 0x172F6D4
	int TieBreaker(Rect ra, Rect rb) { }

	// RVA: 0x172EB34
	VisualElement GetBestOverall(VisualElement candidate, VisualElement bestSoFar) { }

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

	// RVA: 0x172DFE0
	FocusController get_focusController() { }

	// RVA: 0x172E008
	void .ctor(VisualElement root) { }

	// RVA: 0x172E09C
	FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x172E4F0
	Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	// RVA: 0x172E6A0
	Focusable GetNextFocusable2D(Focusable currentFocusable, ChangeDirection direction) { }

	// RVA: 0x172EC94
	bool IsActive(VisualElement v) { }

	// RVA: 0x172ED80
	bool IsNavigable(Focusable focusable) { }

	// RVA: 0x172EDF4
	void .cctor() { }

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

	// RVA: 0x1730090
	void .ctor(PanelSettings settings) { }

	// RVA: 0x172FF08
	bool get_isInitialized() { }

	// RVA: 0x172FD40
	BaseRuntimePanel get_panel() { }

	// RVA: 0x1730504
	void DisposePanel() { }

	// RVA: 0x172FAAC
	void SetTargetTexture() { }

	// RVA: 0x172FC38
	void SetSortingPriority() { }

	// RVA: 0x172FCB0
	void SetTargetDisplay() { }

	// RVA: 0x1731918
	BaseRuntimePanel CreateRelatedRuntimePanel() { }

	// RVA: 0x1731A34
	void DisposeRelatedPanel() { }

	// RVA: 0x1731888
	void MarkPotentiallyEmpty() { }

}

// Namespace: UnityEngine.UIElements
public class PanelSettings 
{
	// Fields
	private const int k_DefaultSortingOrder = 0;
	private const float k_DefaultScaleValue = 1065353216;
	internal const string k_DefaultStyleSheetPath = 5419616896;
	private ThemeStyleSheet themeUss; // 0x18
	private RenderTexture m_TargetTexture; // 0x20
	private PanelScaleMode m_ScaleMode; // 0x28
	private float m_ReferenceSpritePixelsPerUnit; // 0x2C
	private float m_Scale; // 0x30
	private const float DefaultDpi = 1119879168;
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

	// RVA: 0x172F860
	ThemeStyleSheet get_themeStyleSheet() { }

	// RVA: 0x172F868
	void set_themeStyleSheet(ThemeStyleSheet value) { }

	// RVA: 0x172FA48
	RenderTexture get_targetTexture() { }

	// RVA: 0x172FA50
	void set_targetTexture(RenderTexture value) { }

	// RVA: 0x172FAE4
	PanelScaleMode get_scaleMode() { }

	// RVA: 0x172FAEC
	void set_scaleMode(PanelScaleMode value) { }

	// RVA: 0x172FAF4
	float get_referenceSpritePixelsPerUnit() { }

	// RVA: 0x172FAFC
	void set_referenceSpritePixelsPerUnit(float value) { }

	// RVA: 0x172FB04
	float get_scale() { }

	// RVA: 0x172FB0C
	void set_scale(float value) { }

	// RVA: 0x172FB14
	float get_referenceDpi() { }

	// RVA: 0x172FB1C
	void set_referenceDpi(float value) { }

	// RVA: 0x172FB4C
	float get_fallbackDpi() { }

	// RVA: 0x172FB54
	void set_fallbackDpi(float value) { }

	// RVA: 0x172FB84
	Vector2Int get_referenceResolution() { }

	// RVA: 0x172FB8C
	void set_referenceResolution(Vector2Int value) { }

	// RVA: 0x172FB94
	PanelScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x172FB9C
	void set_screenMatchMode(PanelScreenMatchMode value) { }

	// RVA: 0x172FBA4
	float get_match() { }

	// RVA: 0x172FBAC
	void set_match(float value) { }

	// RVA: 0x172FBB4
	float get_sortingOrder() { }

	// RVA: 0x172FBBC
	void set_sortingOrder(float value) { }

	// RVA: 0x172FBFC
	void ApplySortingOrder() { }

	// RVA: 0x172FC70
	int get_targetDisplay() { }

	// RVA: 0x172FC78
	void set_targetDisplay(int value) { }

	// RVA: 0x172FCDC
	bool get_clearDepthStencil() { }

	// RVA: 0x172FCE4
	void set_clearDepthStencil(bool value) { }

	// RVA: 0x172FCEC
	float get_depthClearValue() { }

	// RVA: 0x172FCFC
	bool get_clearColor() { }

	// RVA: 0x172FD04
	void set_clearColor(bool value) { }

	// RVA: 0x172FD0C
	Color get_colorClearValue() { }

	// RVA: 0x172FD18
	void set_colorClearValue(Color value) { }

	// RVA: 0x172FD24
	BaseRuntimePanel get_panel() { }

	// RVA: 0x172FEE8
	bool get_isInitialized() { }

	// RVA: 0x172FF18
	VisualElement get_visualTree() { }

	// RVA: 0x172FF48
	DynamicAtlasSettings get_dynamicAtlasSettings() { }

	// RVA: 0x172FF50
	void set_dynamicAtlasSettings(DynamicAtlasSettings value) { }

	// RVA: 0x172FF58
	void .ctor() { }

	// RVA: 0x17300C4
	void Reset() { }

	// RVA: 0x17300C8
	void OnEnable() { }

	// RVA: 0x1730468
	void OnDisable() { }

	// RVA: 0x1730598
	void DisposePanel() { }

	// RVA: 0x1730634
	float get_ScreenDPI() { }

	// RVA: 0x173063C
	void set_ScreenDPI(float value) { }

	// RVA: 0x17301F4
	void UpdateScreenDPI() { }

	// RVA: 0x172F894
	void ApplyThemeStyleSheet(VisualElement root) { }

	// RVA: 0x173021C
	void InitializeShaders() { }

	// RVA: 0x1730644
	void ApplyPanelSettings() { }

	// RVA: 0x1731088
	void SetScreenToPanelSpaceFunction(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> screentoPanelSpaceFunction) { }

	// RVA: 0x1730E7C
	float ResolveScale(Rect targetRect, float screenDpi) { }

	// RVA: 0x1730D5C
	Rect GetDisplayRect() { }

	// RVA: 0x17310CC
	void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) { }

	// RVA: 0x1731748
	void DetachUIDocument(UIDocument uiDocument) { }

}

// Namespace: UnityEngine.UIElements
internal static class RuntimeEventDispatcher 
{
	// Methods

	// RVA: 0x1731AC4
	EventDispatcher Create() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.RuntimePanel.<>c <>9; // 0x0
	public static UnityEngine.UIElements.EventCallback<UnityEngine.UIElements.FocusEvent,UnityEngine.UIElements.RuntimePanel> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x1732470
	void .cctor() { }

	// RVA: 0x17324DC
	void .ctor() { }

	// RVA: 0x17324E4
	void <.ctor>b__5_0(FocusEvent e, RuntimePanel p) { }

}

// Namespace: UnityEngine.UIElements
internal class RuntimePanel 
{
	// Fields
	internal static readonly EventDispatcher s_EventDispatcher; // 0x0
	private readonly PanelSettings m_PanelSettings; // 0x1E8

	// Methods

	// RVA: 0x1731D1C
	PanelSettings get_panelSettings() { }

	// RVA: 0x1731D24
	RuntimePanel Create(ScriptableObject ownerObject) { }

	// RVA: 0x1731D88
	void .ctor(ScriptableObject ownerObject) { }

	// RVA: 0x17321B4
	void Update() { }

	// RVA: 0x1732380
	void OnElementFocus(FocusEvent evt) { }

	// RVA: 0x1732414
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UIDocumentList 
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.UIDocument> m_AttachedUIDocuments; // 0x10

	// Methods

	// RVA: 0x17312DC
	void RemoveFromListAndFromVisualTree(UIDocument uiDocument) { }

	// RVA: 0x1731364
	void AddToListAndToVisualTree(UIDocument uiDocument, VisualElement visualTree, int firstInsertIndex) { }

	// RVA: 0x1731250
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public sealed class UIDocument 
{
	// Fields
	internal const string k_RootStyleClassName = 5714747472;
	internal const string k_VisualElementNameSuffix = 5731171952;
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

	// RVA: 0x1732584
	PanelSettings get_panelSettings() { }

	// RVA: 0x173258C
	void set_panelSettings(PanelSettings value) { }

	// RVA: 0x1732980
	UIDocument get_parentUI() { }

	// RVA: 0x1732988
	void set_parentUI(UIDocument value) { }

	// RVA: 0x1732990
	VisualTreeAsset get_visualTreeAsset() { }

	// RVA: 0x1732998
	void set_visualTreeAsset(VisualTreeAsset value) { }

	// RVA: 0x173257C
	VisualElement get_rootVisualElement() { }

	// RVA: 0x1732F34
	int get_firstChildInserIndex() { }

	// RVA: 0x1732F3C
	float get_sortingOrder() { }

	// RVA: 0x1732F44
	void set_sortingOrder(float value) { }

	// RVA: 0x1732F5C
	void ApplySortingOrder() { }

	// RVA: 0x1733070
	void .ctor() { }

	// RVA: 0x1733114
	void Awake() { }

	// RVA: 0x1733230
	void OnEnable() { }

	// RVA: 0x1733118
	void SetupFromHierarchy() { }

	// RVA: 0x17333DC
	UIDocument FindUIDocumentParent() { }

	// RVA: 0x17334B4
	void Reset() { }

	// RVA: 0x1733644
	void AddChildAndInsertContentToVisualTree(UIDocument child) { }

	// RVA: 0x1733350
	void RemoveChild(UIDocument child) { }

	// RVA: 0x17329C0
	void RecreateUI() { }

	// RVA: 0x1733900
	void SetupRootClassList() { }

	// RVA: 0x1732F60
	void AddRootVisualElementToTree() { }

	// RVA: 0x17337A4
	void RemoveFromHierarchy() { }

	// RVA: 0x17339AC
	void OnDisable() { }

	// RVA: 0x17339F0
	void OnTransformChildrenChanged() { }

	// RVA: 0x1733E34
	void OnTransformParentChanged() { }

	// RVA: 0x1733CD0
	void ReactToHierarchyChanged() { }

}

// Namespace: UnityEngine.UIElements
internal static class GroupBoxUtility 
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBox,UnityEngine.UIElements.IGroupManager> s_GroupManagers; // 0x0
	private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.IGroupBoxOption,UnityEngine.UIElements.IGroupManager> s_GroupOptionManagerCache; // 0x8
	private static readonly Type k_GenericGroupBoxType; // 0x10

	// Methods

	// RVA: 0x309AF8C
	void RegisterGroupBoxOption(T option) { }

	// RVA: 0x309AF8C
	void UnregisterGroupBoxOption(T option) { }

	// RVA: 0x309AF8C
	void OnOptionSelected(T selectedOption) { }

	// RVA: 0x1733E38
	IGroupManager FindOrCreateGroupManager(IGroupBox groupBox) { }

	// RVA: 0x173452C
	void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x1734600
	void OnPanelDestroyed(BaseVisualElementPanel panel) { }

	// RVA: 0x173482C
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class IEnumerableExtensions 
{
	// Methods

	// RVA: 0x1734984
	bool HasValues(System.Collections.Generic.IEnumerable<System.String> collection) { }

}

// Namespace: UnityEngine.UIElements
internal interface IGroupBoxOption 
{
	// Methods

	// RVA: 0x2FE4234
	void SetSelected(bool selected) { }

}

// Namespace: UnityEngine.UIElements
internal interface IGroupBox 
{
	// Methods

	// RVA: 0x2FE4574
	void OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x2FE4574
	void OnOptionRemoved(IGroupBoxOption option) { }

}

// Namespace: UnityEngine.UIElements
internal interface IGroupBox<T0> 
{}

// Namespace: UnityEngine.UIElements
internal interface IGroupManager 
{
	// Methods

	// RVA: 0x2FE4574
	void Init(IGroupBox groupBox) { }

	// RVA: 0x2FE4574
	void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	// RVA: 0x2FE4574
	void RegisterOption(IGroupBoxOption option) { }

	// RVA: 0x2FE4574
	void UnregisterOption(IGroupBoxOption option) { }

}

// Namespace: UnityEngine.UIElements
internal class DefaultGroupManager 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.IGroupBoxOption> m_GroupOptions; // 0x10
	private IGroupBoxOption m_SelectedOption; // 0x18
	private IGroupBox m_GroupBox; // 0x20

	// Methods

	// RVA: 0x1734C5C
	void Init(IGroupBox groupBox) { }

	// RVA: 0x1734C64
	void OnOptionSelectionChanged(IGroupBoxOption selectedOption) { }

	// RVA: 0x1734EDC
	void RegisterOption(IGroupBoxOption option) { }

	// RVA: 0x1734FF4
	void UnregisterOption(IGroupBoxOption option) { }

	// RVA: 0x17343EC
	void .ctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x1738EC4
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Methods

	// RVA: 0x1738F18
	void .ctor() { }

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

	// RVA: 0x17350D4
	Action get_onGUIHandler() { }

	// RVA: 0x17350DC
	void set_onGUIHandler(Action value) { }

	// RVA: 0x1735144
	ObjectGUIState get_guiState() { }

	// RVA: 0x1735234
	Rect get_lastWorldClip() { }

	// RVA: 0x1735248
	void set_lastWorldClip(Rect value) { }

	// RVA: 0x173525C
	bool get_cullingEnabled() { }

	// RVA: 0x1735264
	LayoutCache get_cache() { }

	// RVA: 0x17352F4
	float get_layoutMeasuredWidth() { }

	// RVA: 0x1735388
	float get_layoutMeasuredHeight() { }

	// RVA: 0x173541C
	ContextType get_contextType() { }

	// RVA: 0x1735424
	void set_contextType(ContextType value) { }

	// RVA: 0x173542C
	bool get_focusOnlyIfHasFocusableControls() { }

	// RVA: 0x1735434
	bool get_canGrabFocus() { }

	// RVA: 0x1735454
	void .cctor() { }

	// RVA: 0x17357E0
	void .ctor() { }

	// RVA: 0x17357E8
	void .ctor(Action onGUIHandler) { }

	// RVA: 0x1735ABC
	void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x1735BF0
	void SaveGlobals() { }

	// RVA: 0x1735CFC
	void RestoreGlobals() { }

	// RVA: 0x1735E18
	void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x1736D04
	void MarkDirtyLayout() { }

	// RVA: 0x1736D18
	void ProcessEvent(EventBase evt) { }

	// RVA: 0x17371B8
	void DoIMGUIRepaint() { }

	// RVA: 0x1736F04
	bool SendEventToIMGUI(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	// RVA: 0x1737934
	bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds) { }

	// RVA: 0x1737B10
	bool VerifyBounds(EventBase evt) { }

	// RVA: 0x1737C8C
	bool IsContainerCapturingTheMouse() { }

	// RVA: 0x1737DB8
	bool IsLocalEvent(EventBase evt) { }

	// RVA: 0x1738078
	bool IsEventInsideLocalWindow(EventBase evt) { }

	// RVA: 0x1738270
	bool IsDockAreaMouseUp(EventBase evt) { }

	// RVA: 0x1737BC4
	bool HandleIMGUIEvent(Event e, bool canAffectFocus) { }

	// RVA: 0x1738428
	bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x1737498
	bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus) { }

	// RVA: 0x17386E8
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x1738A20
	void SetFoldoutDepthClass() { }

	// RVA: 0x1738BC8
	Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x17383E8
	Rect GetCurrentClipRect() { }

	// RVA: 0x17384F0
	void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect) { }

	// RVA: 0x1738E0C
	void Dispose() { }

	// RVA: 0x1738EA0
	void Dispose(bool disposeManaged) { }

	// RVA: 0x1738EB8
	void <DoOnGUI>b__56_0() { }

}

// Namespace: UnityEngine.UIElements
internal class ImmediateModeException 
{
	// Methods

	// RVA: 0x1738FBC
	void .ctor(Exception inner) { }

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

	// RVA: 0x309AF8C
	void Set(string key, T value) { }

	// RVA: 0x309AF8C
	T Get(string key) { }

	// RVA: 0x2FE47D4
	void Overwrite(object obj, string key) { }

	// RVA: 0x2FE3174
	bool ContainsKey(string key) { }

}

// Namespace: UnityEngine.UIElements
public interface ITransform 
{
	// Methods

	// RVA: -1
	Vector3 get_position() { }

	// RVA: -1
	void set_position(Vector3 value) { }

	// RVA: -1
	Vector3 get_scale() { }

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

	// RVA: 0x1739040
	void .ctor(System.Action<UnityEngine.UIElements.KeyboardNavigationOperation,UnityEngine.UIElements.EventBase> action) { }

	// RVA: 0x173907C
	void RegisterCallbacksOnTarget() { }

	// RVA: 0x1739294
	void UnregisterCallbacksFromTarget() { }

	// RVA: 0x17394A4
	void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x1739638
	void OnNavigationCancel(NavigationCancelEvent evt) { }

	// RVA: 0x1739678
	void OnNavigationSubmit(NavigationSubmitEvent evt) { }

	// RVA: 0x17396B8
	void OnNavigationMove(NavigationMoveEvent evt) { }

	// RVA: 0x1739600
	void Invoke(KeyboardNavigationOperation operation, EventBase evt) { }

	// RVA: 0x1739504
	KeyboardNavigationOperation <OnKeyDown>g__GetOperation|4_0(ref UnityEngine.UIElements.KeyboardNavigationManipulator.<>c__DisplayClass4_0& ) { }

}

// Namespace: UnityEngine.UIElements
public struct ManipulatorActivationFilter 
{
	// Fields
	private MouseButton <button>k__BackingField; // 0x10
	private EventModifiers <modifiers>k__BackingField; // 0x14
	private int <clickCount>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1739758
	MouseButton get_button() { }

	// RVA: 0x1739760
	void set_button(MouseButton value) { }

	// RVA: 0x1739768
	EventModifiers get_modifiers() { }

	// RVA: 0x1739770
	void set_modifiers(EventModifiers value) { }

	// RVA: 0x1739778
	int get_clickCount() { }

	// RVA: 0x1739780
	bool Equals(object obj) { }

	// RVA: 0x1739830
	bool Equals(ManipulatorActivationFilter other) { }

	// RVA: 0x1739864
	int GetHashCode() { }

	// RVA: 0x17398F0
	bool Matches(IMouseEvent e) { }

	// RVA: 0x1739A94
	bool HasModifiers(IMouseEvent e) { }

	// RVA: 0x1739D20
	bool Matches(IPointerEvent e) { }

	// RVA: 0x1739EC4
	bool HasModifiers(IPointerEvent e) { }

	// RVA: 0x1739CCC
	bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command) { }

}

// Namespace: UnityEngine.UIElements
public interface IManipulator 
{
	// Methods

	// RVA: 0x2FE4574
	void set_target(VisualElement value) { }

}

// Namespace: UnityEngine.UIElements
public abstract class Manipulator 
{
	// Fields
	private VisualElement m_Target; // 0x10

	// Methods

	// RVA: 0x2FE41A8
	void RegisterCallbacksOnTarget() { }

	// RVA: 0x2FE41A8
	void UnregisterCallbacksFromTarget() { }

	// RVA: 0x173928C
	VisualElement get_target() { }

	// RVA: 0x173A0FC
	void set_target(VisualElement value) { }

	// RVA: 0x1739074
	void .ctor() { }

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

	// RVA: 0x1738628
	bool HasMouseCapture(IEventHandler handler) { }

	// RVA: 0x173A174
	void CaptureMouse(IEventHandler handler) { }

	// RVA: 0x173A24C
	void ReleaseMouse(IEventHandler handler) { }

}

// Namespace: UnityEngine.UIElements
public abstract class MouseManipulator 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> <activators>k__BackingField; // 0x18
	private ManipulatorActivationFilter m_currentActivator; // 0x20

	// Methods

	// RVA: 0x173A324
	System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> get_activators() { }

	// RVA: 0x173A32C
	void set_activators(System.Collections.Generic.List<UnityEngine.UIElements.ManipulatorActivationFilter> value) { }

	// RVA: 0x173A334
	void .ctor() { }

	// RVA: 0x173A3C0
	bool CanStartManipulation(IMouseEvent e) { }

	// RVA: 0x173A5D8
	bool CanStopManipulation(IMouseEvent e) { }

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

	// RVA: 0x173A6A8
	IntPtr Create(bool computeBBox) { }

	// RVA: 0x173A6F8
	void Destroy(IntPtr handle) { }

	// RVA: 0x173A748
	void Reset(IntPtr handle) { }

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

	// RVA: 0x173A798
	MeshWriteDataInterface MakeBorder(NativeBorderParams borderParams, float posZ) { }

	// RVA: 0x173A87C
	MeshWriteDataInterface MakeSolidRect(NativeRectParams rectParams, float posZ) { }

	// RVA: 0x173A960
	MeshWriteDataInterface MakeTexturedRect(NativeRectParams rectParams, float posZ) { }

	// RVA: 0x173AA44
	MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount) { }

	// RVA: 0x173ABF4
	MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage, int settingIndexOffset) { }

	// RVA: 0x173A81C
	void MakeBorder_Injected(ref NativeBorderParams borderParams, float posZ, out MeshWriteDataInterface ret) { }

	// RVA: 0x173A900
	void MakeSolidRect_Injected(ref NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret) { }

	// RVA: 0x173A9E4
	void MakeTexturedRect_Injected(ref NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret) { }

	// RVA: 0x173AB28
	void MakeVectorGraphicsStretchBackground_Injected(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Rect sourceUV, ScaleMode scaleMode, ref Color tint, ref NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount, out MeshWriteDataInterface ret) { }

	// RVA: 0x173ACB8
	void MakeVectorGraphics9SliceBackground_Injected(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Vector4 sliceLTRB, ref Color tint, ref NativeColorPage colorPage, int settingIndexOffset, out MeshWriteDataInterface ret) { }

}

// Namespace: UnityEngine.UIElements
internal static class UIElementsRuntimeUtilityNative 
{
	// Fields
	internal static Action RepaintOverlayPanelsCallback; // 0x0
	internal static Action UpdateRuntimePanelsCallback; // 0x8
	internal static Action RepaintOffscreenPanelsCallback; // 0x10

	// Methods

	// RVA: 0x173AD68
	void RepaintOverlayPanels() { }

	// RVA: 0x173ADD0
	void UpdateRuntimePanels() { }

	// RVA: 0x173AE38
	void RepaintOffscreenPanels() { }

	// RVA: 0x173AEA0
	void RegisterPlayerloopCallback() { }

	// RVA: 0x173AEE0
	void UnregisterPlayerloopCallback() { }

	// RVA: 0x173AF20
	void VisualElementCreation() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.ObjectPool.<>c<T> <>9; // 0x0
	public static System.Func<T> <>9__6_0; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	T <.ctor>b__6_0() { }

}

// Namespace: UnityEngine.UIElements
internal class ObjectPool<T0> 
{
	// Fields
	private readonly System.Collections.Generic.Stack<T> m_Stack; // 0x0
	private int m_MaxSize; // 0x0
	internal System.Func<T> CreateFunc; // 0x0

	// Methods

	// RVA: 0x2FE32D4
	int get_maxSize() { }

	// RVA: 0x2FE42A4
	void set_maxSize(int value) { }

	// RVA: 0x2FE45DC
	void .ctor(System.Func<T> CreateFunc, int maxSize) { }

	// RVA: 0x2FE32D4
	int Size() { }

	// RVA: 0x309AF8C
	T Get() { }

	// RVA: 0x309AF8C
	void Release(T element) { }

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

	// RVA: 0x173AF60
	Matrix4x4 get_currentOffset() { }

	// RVA: 0x173AF74
	Rect get_currentWorldClip() { }

	// RVA: 0x173AF80
	Event get_repaintEvent() { }

	// RVA: 0x173AF88
	void set_repaintEvent(Event value) { }

	// RVA: 0x173AF90
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class HierarchyEvent 
{
	// Methods

	// RVA: 0x173AFF4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x173B118
	internal void Invoke(VisualElement ve, HierarchyChangeType changeType) { }

}

// Namespace: UnityEngine.UIElements
public interface IPanel 
{
	// Methods

	// RVA: 0x2FE360C
	VisualElement get_visualTree() { }

	// RVA: 0x2FE360C
	EventDispatcher get_dispatcher() { }

	// RVA: 0x2FE32D4
	ContextType get_contextType() { }

	// RVA: 0x2FE360C
	FocusController get_focusController() { }

	// RVA: -1
	VisualElement Pick(Vector2 point) { }

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
	EventInterests get_IMGUIEventInterests() { }

	// RVA: -1
	void set_IMGUIEventInterests(EventInterests value) { }

	// RVA: 0x2FE360C
	ScriptableObject get_ownerObject() { }

	// RVA: 0x2FE4574
	void set_ownerObject(ScriptableObject value) { }

	// RVA: 0x2FE360C
	SavePersistentViewData get_saveViewData() { }

	// RVA: 0x2FE360C
	GetViewDataDictionary get_getViewDataDictionary() { }

	// RVA: 0x2FE32D4
	int get_IMGUIContainersCount() { }

	// RVA: 0x2FE42A4
	void set_IMGUIContainersCount(int value) { }

	// RVA: 0x2FE360C
	FocusController get_focusController() { }

	// RVA: 0x2FE4574
	void set_focusController(FocusController value) { }

	// RVA: 0x2FE360C
	IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0x1734478
	void add_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x1734778
	void remove_panelDisposed(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x173B12C
	UIElementsBridge get_uiElementsBridge() { }

	// RVA: 0x173B194
	void .ctor() { }

	// RVA: 0x173B2EC
	void Dispose() { }

	// RVA: 0x173B380
	void Dispose(bool disposing) { }

	// RVA: 0x2FE4574
	void Repaint(Event e) { }

	// RVA: 0x2FE41A8
	void ValidateFocus() { }

	// RVA: 0x2FE41A8
	void ValidateLayout() { }

	// RVA: 0x2FE41A8
	void UpdateAnimations() { }

	// RVA: 0x2FE41A8
	void UpdateBindings() { }

	// RVA: 0x2FE41A8
	void ApplyStyles() { }

	// RVA: 0x173B50C
	float get_scale() { }

	// RVA: 0x1730F74
	void set_scale(float value) { }

	// RVA: 0x173B524
	void set_pixelsPerPoint(float value) { }

	// RVA: 0x173B514
	float get_scaledPixelsPerPoint() { }

	// RVA: 0x173B638
	float get_referenceSpritePixelsPerUnit() { }

	// RVA: 0x173B640
	void set_referenceSpritePixelsPerUnit(float value) { }

	// RVA: 0x173B648
	PanelClearSettings get_clearSettings() { }

	// RVA: 0x173B65C
	void set_clearSettings(PanelClearSettings value) { }

	// RVA: 0x173B670
	bool get_duringLayoutPhase() { }

	// RVA: 0x173B678
	void set_duringLayoutPhase(bool value) { }

	// RVA: -1
	UInt32 get_version() { }

	// RVA: -1
	UInt32 get_hierarchyVersion() { }

	// RVA: 0x2FE45DC
	void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	// RVA: 0x173B680
	RepaintData get_repaintData() { }

	// RVA: 0x173B688
	void set_repaintData(RepaintData value) { }

	// RVA: 0x173B690
	ICursorManager get_cursorManager() { }

	// RVA: 0x173B698
	void set_cursorManager(ICursorManager value) { }

	// RVA: 0x173B6A0
	ContextualMenuManager get_contextualMenuManager() { }

	// RVA: 0x173B6A8
	void set_contextualMenuManager(ContextualMenuManager value) { }

	// RVA: 0x2FE360C
	VisualElement get_visualTree() { }

	// RVA: 0x2FE360C
	EventDispatcher get_dispatcher() { }

	// RVA: 0x2FE4574
	void set_dispatcher(EventDispatcher value) { }

	// RVA: 0x173B6B0
	void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: 0x2FE360C
	IScheduler get_scheduler() { }

	// RVA: 0x2FE360C
	IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	// RVA: 0x2FE4574
	void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	// RVA: 0x2FE32D4
	ContextType get_contextType() { }

	// RVA: 0x2FE42A4
	void set_contextType(ContextType value) { }

	// RVA: -1
	VisualElement Pick(Vector2 point) { }

	// RVA: -1
	VisualElement PickAll(Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked) { }

	// RVA: 0x173B780
	bool get_disposed() { }

	// RVA: 0x173B788
	void set_disposed(bool value) { }

	// RVA: -1
	IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x1725D58
	VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x1724754
	VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) { }

	// RVA: 0x1727F18
	void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) { }

	// RVA: 0x173B790
	void CommitElementUnderPointers() { }

	// RVA: 0x2FE360C
	Shader get_standardShader() { }

	// RVA: 0x173B7F8
	Shader get_standardWorldSpaceShader() { }

	// RVA: 0x173B800
	void add_standardShaderChanged(Action value) { }

	// RVA: 0x173B8A4
	void remove_standardShaderChanged(Action value) { }

	// RVA: 0x173B948
	void add_standardWorldSpaceShaderChanged(Action value) { }

	// RVA: 0x173B9EC
	void remove_standardWorldSpaceShaderChanged(Action value) { }

	// RVA: 0x173BA90
	void add_atlasChanged(Action value) { }

	// RVA: 0x173BB34
	void remove_atlasChanged(Action value) { }

	// RVA: 0x173BBD8
	void InvokeAtlasChanged() { }

	// RVA: 0x2FE360C
	AtlasBase get_atlas() { }

	// RVA: 0x2FE4574
	void set_atlas(AtlasBase value) { }

	// RVA: 0x173BBF4
	void InvokeUpdateMaterial(Material mat) { }

	// RVA: 0x173BC10
	void add_hierarchyChanged(HierarchyEvent value) { }

	// RVA: 0x173BCB4
	void remove_hierarchyChanged(HierarchyEvent value) { }

	// RVA: 0x173BD58
	void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	// RVA: 0x173BD74
	void InvokeBeforeUpdate() { }

	// RVA: 0x173BD94
	void UpdateElementUnderPointers() { }

	// RVA: 0x173C11C
	void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	// RVA: 0x173C120
	void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	// RVA: 0x1732274
	void Update() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class LoadResourceFunction 
{
	// Methods

	// RVA: 0x173C124
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x173C1E0
	internal object Invoke(string pathName, Type type, float dpiScaling) { }

}

// Namespace: UnityEngine.UIElements
internal sealed class TimeMsFunction 
{
	// Methods

	// RVA: 0x173C1F4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x173C294
	internal Int64 Invoke() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class GetViewDataDictionary 
{
	// Methods

	// RVA: 0x173C2A8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x173C348
	internal ISerializableJsonDictionary Invoke() { }

}

// Namespace: UnityEngine.UIElements
internal sealed class SavePersistentViewData 
{
	// Methods

	// RVA: 0x173C35C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x173C3FC
	internal void Invoke() { }

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

	// RVA: 0x173C410
	VisualElement get_visualTree() { }

	// RVA: 0x173C418
	EventDispatcher get_dispatcher() { }

	// RVA: 0x173C420
	void set_dispatcher(EventDispatcher value) { }

	// RVA: 0x173C430
	TimerEventScheduler get_timerEventScheduler() { }

	// RVA: 0x173C4C0
	IScheduler get_scheduler() { }

	// RVA: 0x173C550
	IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	// RVA: 0x173C558
	void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	// RVA: 0x173C630
	ScriptableObject get_ownerObject() { }

	// RVA: 0x173C638
	void set_ownerObject(ScriptableObject value) { }

	// RVA: 0x173C648
	ContextType get_contextType() { }

	// RVA: 0x173C650
	void set_contextType(ContextType value) { }

	// RVA: 0x173C658
	SavePersistentViewData get_saveViewData() { }

	// RVA: 0x173C660
	GetViewDataDictionary get_getViewDataDictionary() { }

	// RVA: 0x173C668
	FocusController get_focusController() { }

	// RVA: 0x173C670
	void set_focusController(FocusController value) { }

	// RVA: 0x173C680
	EventInterests get_IMGUIEventInterests() { }

	// RVA: 0x173C690
	void set_IMGUIEventInterests(EventInterests value) { }

	// RVA: 0x173C6A0
	LoadResourceFunction get_loadResourceFunc() { }

	// RVA: 0x173C71C
	object LoadResource(string pathName, Type type, float dpiScaling) { }

	// RVA: 0x173C89C
	void Focus() { }

	// RVA: 0x173C8A8
	void Blur() { }

	// RVA: 0x173C968
	void ValidateFocus() { }

	// RVA: 0x173CA14
	string get_name() { }

	// RVA: 0x173218C
	void set_name(string value) { }

	// RVA: 0x173CA1C
	void CreateMarkers() { }

	// RVA: 0x173CC74
	TimeMsFunction get_TimeSinceStartup() { }

	// RVA: 0x173CCF0
	int get_IMGUIContainersCount() { }

	// RVA: 0x173CCF8
	void set_IMGUIContainersCount(int value) { }

	// RVA: 0x173CD00
	IMGUIContainer get_rootIMGUIContainer() { }

	// RVA: 0x173CD08
	UInt32 get_version() { }

	// RVA: 0x173CD10
	UInt32 get_hierarchyVersion() { }

	// RVA: 0x173CD18
	Shader get_standardShader() { }

	// RVA: 0x173CD20
	AtlasBase get_atlas() { }

	// RVA: 0x173CD28
	void set_atlas(AtlasBase value) { }

	// RVA: 0x173CDB8
	void .ctor(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) { }

	// RVA: 0x173D1C0
	void Dispose(bool disposing) { }

	// RVA: 0x173D22C
	Int64 TimeSinceStartupMs() { }

	// RVA: 0x173D33C
	Int64 DefaultTimeSinceStartupMs() { }

	// RVA: 0x173D378
	VisualElement PickAll(VisualElement root, Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked, bool includeIgnoredElement) { }

	// RVA: 0x173D43C
	VisualElement PerformPick(VisualElement root, Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked, bool includeIgnoredElement) { }

	// RVA: 0x173D758
	VisualElement PickAll(Vector2 point, System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> picked) { }

	// RVA: 0x173D8EC
	VisualElement Pick(Vector2 point) { }

	// RVA: 0x173DD10
	void ValidateLayout() { }

	// RVA: 0x173DDA4
	void UpdateAnimations() { }

	// RVA: 0x173DDEC
	void UpdateBindings() { }

	// RVA: 0x173DE34
	void ApplyStyles() { }

	// RVA: 0x173DE58
	void UpdateForRepaint() { }

	// RVA: 0x173DED8
	void Repaint(Event e) { }

	// RVA: 0x173E1B4
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x173E204
	IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x173E224
	void .cctor() { }

	// RVA: 0x173DC24
	Vector2Int <Pick>g__PixelOf|101_0(Vector2 p) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.BaseRuntimePanel.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1759040
	void .cctor() { }

	// RVA: 0x17590AC
	void .ctor() { }

	// RVA: 0x17590B4
	Vector2 <.cctor>b__47_0(Vector2 p) { }

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

	// RVA: 0x1757B94
	GameObject get_selectableGameObject() { }

	// RVA: 0x1757B9C
	void set_selectableGameObject(GameObject value) { }

	// RVA: 0x1758040
	float get_sortingPriority() { }

	// RVA: 0x1758048
	void set_sortingPriority(float value) { }

	// RVA: 0x1758160
	void add_destroyed(Action value) { }

	// RVA: 0x1758208
	void remove_destroyed(Action value) { }

	// RVA: 0x17582B0
	void .ctor(ScriptableObject ownerObject, EventDispatcher dispatcher) { }

	// RVA: 0x17583E4
	void Dispose(bool disposing) { }

	// RVA: 0x1758440
	Shader get_standardWorldSpaceShader() { }

	// RVA: 0x1758448
	bool get_drawToCameras() { }

	// RVA: 0x1758450
	void set_drawToCameras(bool value) { }

	// RVA: 0x17585C4
	int get_targetDisplay() { }

	// RVA: 0x17585CC
	void set_targetDisplay(int value) { }

	// RVA: 0x17585D4
	int get_screenRenderingWidth() { }

	// RVA: 0x1758720
	int get_screenRenderingHeight() { }

	// RVA: 0x17587A8
	int getScreenRenderingHeight(int display) { }

	// RVA: 0x175865C
	int getScreenRenderingWidth(int display) { }

	// RVA: 0x175886C
	void Repaint(Event e) { }

	// RVA: 0x1758B2C
	System.Func<UnityEngine.Vector2,UnityEngine.Vector2> get_screenToPanelSpace() { }

	// RVA: 0x1758B34
	void set_screenToPanelSpace(System.Func<UnityEngine.Vector2,UnityEngine.Vector2> value) { }

	// RVA: 0x1758BD0
	Vector2 ScreenToPanel(Vector2 screen) { }

	// RVA: 0x1758C40
	bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside) { }

	// RVA: 0x1757C70
	void AssignPanelToComponents(BaseRuntimePanel panel) { }

	// RVA: 0x1758E08
	void PointerLeavesPanel(int pointerId, Vector2 position) { }

	// RVA: 0x1758EC8
	void PointerEntersPanel(int pointerId, Vector2 position) { }

	// RVA: 0x1758F68
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal interface IRuntimePanelComponent 
{
	// Methods

	// RVA: 0x2FE4574
	void set_panel(IPanel value) { }

}

// Namespace: UnityEngine.UIElements
public static class PointerCaptureHelper 
{
	// Methods

	// RVA: 0x17590B8
	PointerDispatchState GetStateFor(IEventHandler handler) { }

	// RVA: 0x17591E8
	bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0x1759278
	void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x1759410
	void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x17594DC
	IEventHandler GetCapturingElement(IPanel panel, int pointerId) { }

	// RVA: 0x1759620
	void ReleasePointer(IPanel panel, int pointerId) { }

	// RVA: 0x1759758
	void ActivateCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	// RVA: 0x1759890
	void PreventCompatibilityMouseEvents(IPanel panel, int pointerId) { }

	// RVA: 0x17599C0
	bool ShouldSendCompatibilityMouseEvents(IPanel panel, IPointerEvent evt) { }

	// RVA: 0x1759D34
	void ProcessPointerCapture(IPanel panel, int pointerId) { }

}

// Namespace: UnityEngine.UIElements
internal class PointerDispatchState 
{
	// Fields
	private IEventHandler[] m_PendingPointerCapture; // 0x10
	private IEventHandler[] m_PointerCapture; // 0x18
	private bool[] m_ShouldSendCompatibilityMouseEvents; // 0x20

	// Methods

	// RVA: 0x175A6EC
	void .ctor() { }

	// RVA: 0x175A7EC
	void Reset() { }

	// RVA: 0x17595EC
	IEventHandler GetCapturingElement(int pointerId) { }

	// RVA: 0x175923C
	bool HasPointerCapture(IEventHandler handler, int pointerId) { }

	// RVA: 0x17592B4
	void CapturePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x1759720
	void ReleasePointer(int pointerId) { }

	// RVA: 0x1759484
	void ReleasePointer(IEventHandler handler, int pointerId) { }

	// RVA: 0x1759E14
	void ProcessPointerCapture(int pointerId) { }

	// RVA: 0x1759858
	void ActivateCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x175998C
	void PreventCompatibilityMouseEvents(int pointerId) { }

	// RVA: 0x1759BD4
	bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt) { }

}

// Namespace: UnityEngine.UIElements
public abstract class PointerManipulator 
{
	// Fields
	private int m_CurrentPointerId; // 0x2C

	// Methods

	// RVA: 0x175A8B4
	bool CanStartManipulation(IPointerEvent e) { }

	// RVA: 0x175AB44
	bool CanStopManipulation(IPointerEvent e) { }

	// RVA: 0x175AC10
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class ProjectionUtils 
{
	// Methods

	// RVA: 0x175AC18
	Matrix4x4 Ortho(float left, float right, float bottom, float top, float near, float far) { }

}

// Namespace: UnityEngine.UIElements
internal struct SafeHandleAccess 
{
	// Fields
	private IntPtr m_Handle; // 0x10

	// Methods

	// RVA: 0x175AC88
	void .ctor(IntPtr ptr) { }

	// RVA: 0x175AC90
	bool IsNull() { }

	// RVA: 0x175ACA0
	IntPtr op_Implicit(SafeHandleAccess a) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIRAtlasAllocator.Row.<>c <>9; // 0x0

	// Methods

	// RVA: 0x175C144
	void .cctor() { }

	// RVA: 0x175C1B0
	void .ctor() { }

	// RVA: 0x175C1B8
	Row <.cctor>b__21_0() { }

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

	// RVA: 0x175BFE4
	int get_offsetX() { }

	// RVA: 0x175BFEC
	void set_offsetX(int value) { }

	// RVA: 0x175BFF4
	int get_offsetY() { }

	// RVA: 0x175BFFC
	void set_offsetY(int value) { }

	// RVA: 0x175C004
	int get_width() { }

	// RVA: 0x175C00C
	void set_width(int value) { }

	// RVA: 0x175C014
	void set_height(int value) { }

	// RVA: 0x175BD2C
	Row Acquire(int offsetX, int offsetY, int width, int height) { }

	// RVA: 0x175AFB8
	void Release() { }

	// RVA: 0x175C01C
	void .ctor() { }

	// RVA: 0x175C024
	void .cctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIRAtlasAllocator.AreaNode.<>c <>9; // 0x0

	// Methods

	// RVA: 0x175C338
	void .cctor() { }

	// RVA: 0x175C3A4
	void .ctor() { }

	// RVA: 0x175C3AC
	AreaNode <.cctor>b__9_0() { }

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

	// RVA: 0x175B444
	AreaNode Acquire(RectInt rect) { }

	// RVA: 0x175B06C
	void Release() { }

	// RVA: 0x175BE08
	void RemoveFromChain() { }

	// RVA: 0x175BE6C
	void AddAfter(AreaNode previous) { }

	// RVA: 0x175C210
	void .ctor() { }

	// RVA: 0x175C218
	void .cctor() { }

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

	// RVA: 0x175AD04
	int get_maxAtlasSize() { }

	// RVA: 0x175AD0C
	int get_maxImageWidth() { }

	// RVA: 0x175AD14
	int get_maxImageHeight() { }

	// RVA: 0x175AD1C
	int get_virtualWidth() { }

	// RVA: 0x175AD24
	void set_virtualWidth(int value) { }

	// RVA: 0x175AD2C
	int get_virtualHeight() { }

	// RVA: 0x175AD34
	void set_virtualHeight(int value) { }

	// RVA: 0x175AD3C
	int get_physicalWidth() { }

	// RVA: 0x175AD44
	void set_physicalWidth(int value) { }

	// RVA: 0x175AD4C
	int get_physicalHeight() { }

	// RVA: 0x175AD54
	void set_physicalHeight(int value) { }

	// RVA: 0x175AD5C
	bool get_disposed() { }

	// RVA: 0x175AD64
	void set_disposed(bool value) { }

	// RVA: 0x175AD6C
	void Dispose() { }

	// RVA: 0x175ADFC
	void Dispose(bool disposing) { }

	// RVA: 0x175B110
	int GetLog2OfNextPower(int n) { }

	// RVA: 0x175B294
	void .ctor(int initialAtlasSize, int maxAtlasSize, int sidePadding) { }

	// RVA: 0x175B630
	bool TryAllocate(int width, int height, out RectInt location) { }

	// RVA: 0x175BA50
	bool TryPartitionArea(AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) { }

	// RVA: 0x175B52C
	void BuildAreas() { }

	// RVA: 0x175BF64
	void .cctor() { }

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

	// RVA: 0x175C404
	TextureId get_textureId() { }

	// RVA: 0x175C40C
	void set_textureId(TextureId value) { }

	// RVA: 0x175C414
	RenderTexture get_atlas() { }

	// RVA: 0x175C41C
	void set_atlas(RenderTexture value) { }

	// RVA: 0x175C424
	RenderTextureFormat get_format() { }

	// RVA: 0x175C42C
	FilterMode get_filterMode() { }

	// RVA: 0x175C434
	void .ctor(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize) { }

	// RVA: 0x175C5D4
	bool get_disposed() { }

	// RVA: 0x175C5DC
	void set_disposed(bool value) { }

	// RVA: 0x175C5E4
	void Dispose() { }

	// RVA: 0x175C674
	void Dispose(bool disposing) { }

	// RVA: 0x175CD38
	bool TryAdd(Texture2D image, out Alloc2D alloc, out RectInt rect) { }

	// RVA: 0x175D080
	void Update(Texture2D image, RectInt rect) { }

	// RVA: 0x175D1CC
	void Remove(Alloc2D alloc) { }

	// RVA: 0x175D2C0
	void Commit() { }

	// RVA: 0x175D314
	void UpdateAtlasTexture() { }

	// RVA: 0x175D724
	RenderTexture CreateAtlasTexture() { }

}

// Namespace: UnityEngine.UIElements
internal class UIRLayoutUpdater 
{
	// Fields
	private static readonly string s_Description; // 0x0
	private static readonly ProfilerMarker s_ProfilerMarker; // 0x8
	private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEventsList; // 0x20

	// Methods

	// RVA: 0x175D858
	ProfilerMarker get_profilerMarker() { }

	// RVA: 0x175D8D4
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x175D92C
	void Update() { }

	// RVA: 0x175DC54
	void UpdateSubTree(VisualElement ve, bool isDisplayed, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents) { }

	// RVA: 0x175E398
	void DispatchChangeEvents(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.Rect,UnityEngine.UIElements.VisualElement>> changeEvents, int currentLayoutPass) { }

	// RVA: 0x175E864
	void .ctor() { }

	// RVA: 0x175E8F0
	void .cctor() { }

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

	// RVA: 0x175E998
	void .ctor() { }

	// RVA: 0x175E9A0
	int get_vertexCount() { }

	// RVA: 0x175E9F4
	int get_indexCount() { }

	// RVA: 0x175EA48
	Rect get_uvRegion() { }

	// RVA: 0x175EA54
	void SetNextVertex(Vertex vertex) { }

	// RVA: 0x175EAD8
	void SetNextIndex(UInt16 index) { }

	// RVA: 0x175EB50
	void SetAllVertices(Vertex[] vertices) { }

	// RVA: 0x175EC28
	void SetAllIndices(UInt16[] indices) { }

	// RVA: 0x175ED00
	void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices) { }

	// RVA: 0x175ED1C
	void Reset(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, Rect uvRegion) { }

}

// Namespace: UnityEngine.UIElements
internal struct ColorPage 
{
	// Fields
	public bool isValid; // 0x10
	public Color32 pageAndID; // 0x14

	// Methods

	// RVA: 0x175ED34
	ColorPage Init(RenderChain renderChain, BMPAlloc alloc) { }

	// RVA: 0x175EE2C
	NativeColorPage ToNativeColorPage() { }

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

	// RVA: 0x175F758
	NativeBorderParams ToNativeParams() { }

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

	// RVA: 0x175F7C8
	void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

	// RVA: 0x175F970
	void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

	// RVA: 0x175FCAC
	Rect RectIntersection(Rect a, Rect b) { }

	// RVA: 0x175FD88
	Rect ComputeGeomRect(Sprite sprite) { }

	// RVA: 0x175FE38
	Rect ComputeUVRect(Sprite sprite) { }

	// RVA: 0x175FEE8
	Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation) { }

	// RVA: 0x175FF40
	RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, ContextType panelContext) { }

	// RVA: 0x176011C
	RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, ContextType panelContext, bool hasRadius, ref Vector4 slices, bool useForRepeat) { }

	// RVA: 0x1760B68
	RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, ContextType panelContext) { }

	// RVA: 0x1760CF8
	bool HasRadius(float epsilon) { }

	// RVA: 0x1760D7C
	bool HasSlices(float epsilon) { }

	// RVA: 0x1760DC8
	NativeRectParams ToNativeParams(Rect uvRegion) { }

}

// Namespace: UnityEngine.UIElements
internal static class MeshGenerationContextUtils 
{
	// Methods

	// RVA: 0x175EE3C
	void Rectangle(MeshGenerationContext mgc, RectangleParams rectParams) { }

	// RVA: 0x175EF30
	void Text(MeshGenerationContext mgc, TextElement te) { }

	// RVA: 0x175F008
	Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) { }

	// RVA: 0x175F044
	void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight) { }

	// RVA: 0x175F2CC
	void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams) { }

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

	// RVA: 0x1760E4C
	Painter2D get_painter2D() { }

	// RVA: 0x1760F84
	bool get_hasPainter2D() { }

	// RVA: 0x1760F94
	void .ctor(IStylePainter painter) { }

	// RVA: 0x1760FC8
	void .cctor() { }

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

	// RVA: 0x1760EE8
	void .ctor(MeshGenerationContext ctx) { }

	// RVA: 0x1761080
	void Reset() { }

	// RVA: 0x17610EC
	void Dispose() { }

	// RVA: 0x176118C
	void Dispose(bool disposing) { }

	// RVA: 0x1761248
	void set_isPainterActive(bool value) { }

	// RVA: 0x17612D4
	void .cctor() { }

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

	// RVA: 0x176139C
	void .ctor() { }

	// RVA: 0x1761430
	ProfilerMarker get_profilerMarker() { }

	// RVA: 0x17614AC
	bool get_drawStats() { }

	// RVA: 0x17614B4
	bool get_breakBatches() { }

	// RVA: 0x17614BC
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x17615B8
	void Update() { }

	// RVA: 0x1761750
	RenderChain CreateRenderChain() { }

	// RVA: 0x17617C8
	void .cctor() { }

	// RVA: 0x17618E8
	void OnGraphicsResourcesRecreate(bool recreate) { }

	// RVA: 0x1761D70
	void OnPanelChanged(BaseVisualElementPanel obj) { }

	// RVA: 0x1761F94
	void AttachToPanel() { }

	// RVA: 0x1761D94
	void DetachFromPanel() { }

	// RVA: 0x1761684
	void InitRenderChain() { }

	// RVA: 0x1758554
	void DestroyRenderChain() { }

	// RVA: 0x17625BC
	void OnPanelAtlasChanged() { }

	// RVA: 0x176262C
	void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType) { }

	// RVA: 0x1762198
	void OnPanelStandardShaderChanged() { }

	// RVA: 0x176234C
	void OnPanelStandardWorldSpaceShaderChanged() { }

	// RVA: 0x1762500
	void ResetAllElementsDataRecursive(VisualElement ve) { }

	// RVA: 0x1762664
	bool get_disposed() { }

	// RVA: 0x176266C
	void set_disposed(bool value) { }

	// RVA: 0x1762674
	void Dispose(bool disposing) { }

}

// Namespace: UnityEngine.UIElements
internal struct TextureId 
{
	// Fields
	private readonly int m_Index; // 0x10
	public static readonly TextureId invalid; // 0x0

	// Methods

	// RVA: 0x17626B8
	void .ctor(int index) { }

	// RVA: 0x17626C4
	int get_index() { }

	// RVA: 0x17626D0
	float ConvertToGpu() { }

	// RVA: 0x1762738
	bool Equals(object obj) { }

	// RVA: 0x1762808
	int GetHashCode() { }

	// RVA: 0x1762810
	bool op_Equality(TextureId left, TextureId right) { }

	// RVA: 0x176281C
	bool op_Inequality(TextureId left, TextureId right) { }

	// RVA: 0x17628A8
	void .cctor() { }

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

	// RVA: 0x17628F4
	TextureRegistry get_instance() { }

	// RVA: 0x1762970
	Texture GetTexture(TextureId id) { }

	// RVA: 0x175C5C8
	TextureId AllocAndAcquireDynamic() { }

	// RVA: 0x1762E18
	void UpdateDynamic(TextureId id, Texture texture) { }

	// RVA: 0x1762B88
	TextureId AllocAndAcquire(Texture texture, bool dynamic) { }

	// RVA: 0x17630C0
	TextureId Acquire(Texture tex) { }

	// RVA: 0x175CA58
	void Release(TextureId id) { }

	// RVA: 0x1763244
	void .ctor() { }

	// RVA: 0x1763380
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIRUtility 
{
	// Fields
	public static readonly string k_DefaultShaderName; // 0x0
	public static readonly string k_DefaultWorldSpaceShaderName; // 0x8

	// Methods

	// RVA: 0x17633E8
	bool ShapeWindingIsClockwise(int maskDepth, int stencilRef) { }

	// RVA: 0x1763468
	bool IsRoundRect(VisualElement ve) { }

	// RVA: 0x1763698
	bool IsVectorImageBackground(VisualElement ve) { }

	// RVA: 0x1763730
	bool IsElementSelfHidden(VisualElement ve) { }

	// RVA: 0x175C904
	void Destroy(object obj) { }

	// RVA: 0x17637F4
	int GetPrevPow2(int n) { }

	// RVA: 0x175D064
	int GetNextPow2(int n) { }

	// RVA: 0x1763834
	int GetNextPow2Exp(int n) { }

	// RVA: 0x1763864
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public struct TimerState 
{
	// Fields
	private Int64 <start>k__BackingField; // 0x10
	private Int64 <now>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1763904
	Int64 get_start() { }

	// RVA: 0x176390C
	void set_start(Int64 value) { }

	// RVA: 0x1763914
	Int64 get_now() { }

	// RVA: 0x176391C
	void set_now(Int64 value) { }

	// RVA: 0x1763924
	Int64 get_deltaTime() { }

	// RVA: 0x1763930
	bool Equals(object obj) { }

	// RVA: 0x17639D0
	bool Equals(TimerState other) { }

	// RVA: 0x17639F4
	int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal interface IScheduler 
{
	// Methods

	// RVA: 0x2FE4574
	void Unschedule(ScheduledItem item) { }

	// RVA: 0x2FE4574
	void Schedule(ScheduledItem item) { }

	// RVA: 0x2FE41A8
	void UpdateScheduledEvents() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.ScheduledItem.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1763D9C
	void .cctor() { }

	// RVA: 0x1763E08
	void .ctor() { }

	// RVA: 0x1763E10
	bool <.cctor>b__25_0() { }

	// RVA: 0x1763E18
	bool <.cctor>b__25_1() { }

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

	// RVA: 0x1763A84
	Int64 get_startMs() { }

	// RVA: 0x1763A8C
	void set_startMs(Int64 value) { }

	// RVA: 0x1763A94
	Int64 get_delayMs() { }

	// RVA: 0x1763A9C
	void set_delayMs(Int64 value) { }

	// RVA: 0x1763AA4
	Int64 get_intervalMs() { }

	// RVA: 0x1763AAC
	void set_intervalMs(Int64 value) { }

	// RVA: 0x1763AB4
	Int64 get_endTimeMs() { }

	// RVA: 0x1763ABC
	void .ctor() { }

	// RVA: 0x1763BAC
	void ResetStartTime() { }

	// RVA: -1
	void PerformTimerUpdate(TimerState state) { }

	// RVA: 0x1763C14
	void OnItemUnscheduled() { }

	// RVA: 0x1763C18
	bool ShouldUnschedule() { }

	// RVA: 0x1763C68
	void .cctor() { }

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

	// RVA: 0x1763E20
	void Schedule(ScheduledItem item) { }

	// RVA: 0x1763FA8
	bool RemovedScheduledItemAt(int index) { }

	// RVA: 0x1764030
	void Unschedule(ScheduledItem item) { }

	// RVA: 0x17641D0
	bool PrivateUnSchedule(ScheduledItem sItem) { }

	// RVA: 0x17642D4
	void UpdateScheduledEvents() { }

	// RVA: 0x17645F0
	void .ctor() { }

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

	// RVA: 0x1764700
	float get_horizontal() { }

	// RVA: 0x1764710
	float get_vertical() { }

	// RVA: 0x1764720
	void .ctor(float left, float top, float right, float bottom) { }

	// RVA: 0x176472C
	Rect op_Subtraction(Rect r, Spacing a) { }

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

	// RVA: 0x176475C
	Angle None() { }

	// RVA: 0x1764770
	float get_value() { }

	// RVA: 0x1764778
	void .ctor(float value, AngleUnit unit) { }

	// RVA: 0x1764764
	void .ctor(float value, Unit unit) { }

	// RVA: 0x1764784
	float ToDegrees() { }

	// RVA: 0x1764810
	Angle op_Implicit(float value) { }

	// RVA: 0x1764818
	bool op_Equality(Angle lhs, Angle rhs) { }

	// RVA: 0x1764838
	bool Equals(Angle other) { }

	// RVA: 0x1764858
	bool Equals(object obj) { }

	// RVA: 0x17648F4
	int GetHashCode() { }

	// RVA: 0x1764928
	string ToString() { }

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

	// RVA: 0x1764B28
	Texture2D get_texture() { }

	// RVA: 0x1764B30
	void set_texture(Texture2D value) { }

	// RVA: 0x1764C18
	Sprite get_sprite() { }

	// RVA: 0x1764C20
	void set_sprite(Sprite value) { }

	// RVA: 0x1764D1C
	RenderTexture get_renderTexture() { }

	// RVA: 0x1764D24
	void set_renderTexture(RenderTexture value) { }

	// RVA: 0x1763728
	VectorImage get_vectorImage() { }

	// RVA: 0x1764E20
	void set_vectorImage(VectorImage value) { }

	// RVA: 0x1764F1C
	Background FromTexture2D(Texture2D t) { }

	// RVA: 0x1764F5C
	Background FromRenderTexture(RenderTexture rt) { }

	// RVA: 0x1764F9C
	Background FromSprite(Sprite s) { }

	// RVA: 0x1764FDC
	Background FromVectorImage(VectorImage vi) { }

	// RVA: 0x176501C
	Background FromObject(object obj) { }

	// RVA: 0x17652E4
	bool op_Equality(Background lhs, Background rhs) { }

	// RVA: 0x1765454
	bool op_Inequality(Background lhs, Background rhs) { }

	// RVA: 0x176548C
	bool Equals(Background other) { }

	// RVA: 0x17654C0
	bool Equals(object obj) { }

	// RVA: 0x1765568
	int GetHashCode() { }

	// RVA: 0x176561C
	string ToString() { }

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

	// RVA: 0x173E2A4
	int get_customPropertiesCount() { }

	// RVA: 0x173E300
	bool get_hasTransition() { }

	// RVA: 0x173E320
	void FinalizeApply(ref ComputedStyle parentStyle) { }

	// RVA: 0x173E548
	void SyncWithLayout(YogaNode targetNode) { }

	// RVA: 0x173FAB8
	bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	// RVA: 0x173FC90
	bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle) { }

	// RVA: 0x1741EC4
	void RemoveCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x1741F7C
	void ApplyCustomStyleProperty(StylePropertyReader reader) { }

	// RVA: 0x1742084
	void ApplyAllPropertyInitial() { }

	// RVA: 0x1742258
	void ResetComputedTransitions() { }

	// RVA: 0x1742264
	bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x173F8EC
	Align get_alignContent() { }

	// RVA: 0x173F948
	Align get_alignItems() { }

	// RVA: 0x173F6C4
	Align get_alignSelf() { }

	// RVA: 0x174246C
	Color get_backgroundColor() { }

	// RVA: 0x17424CC
	Background get_backgroundImage() { }

	// RVA: 0x1742530
	BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x1742594
	BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x17425F8
	BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x1742654
	BackgroundSize get_backgroundSize() { }

	// RVA: 0x17426C0
	Color get_borderBottomColor() { }

	// RVA: 0x1742720
	Length get_borderBottomLeftRadius() { }

	// RVA: 0x174277C
	Length get_borderBottomRightRadius() { }

	// RVA: 0x173F4F8
	float get_borderBottomWidth() { }

	// RVA: 0x17427D8
	Color get_borderLeftColor() { }

	// RVA: 0x173F3E4
	float get_borderLeftWidth() { }

	// RVA: 0x1742838
	Color get_borderRightColor() { }

	// RVA: 0x173F49C
	float get_borderRightWidth() { }

	// RVA: 0x1742898
	Color get_borderTopColor() { }

	// RVA: 0x17428F8
	Length get_borderTopLeftRadius() { }

	// RVA: 0x1742954
	Length get_borderTopRightRadius() { }

	// RVA: 0x173F440
	float get_borderTopWidth() { }

	// RVA: 0x173F0A8
	Length get_bottom() { }

	// RVA: 0x17429B0
	Color get_color() { }

	// RVA: 0x1742A10
	Cursor get_cursor() { }

	// RVA: 0x173FA5C
	DisplayStyle get_display() { }

	// RVA: 0x173EF38
	Length get_flexBasis() { }

	// RVA: 0x173F890
	FlexDirection get_flexDirection() { }

	// RVA: 0x173EE80
	float get_flexGrow() { }

	// RVA: 0x173EEDC
	float get_flexShrink() { }

	// RVA: 0x173FA00
	Wrap get_flexWrap() { }

	// RVA: 0x173E4EC
	Length get_fontSize() { }

	// RVA: 0x173F5B0
	Length get_height() { }

	// RVA: 0x173F9A4
	Justify get_justifyContent() { }

	// RVA: 0x173EF94
	Length get_left() { }

	// RVA: 0x1742A7C
	Length get_letterSpacing() { }

	// RVA: 0x173F218
	Length get_marginBottom() { }

	// RVA: 0x173F104
	Length get_marginLeft() { }

	// RVA: 0x173F1BC
	Length get_marginRight() { }

	// RVA: 0x173F160
	Length get_marginTop() { }

	// RVA: 0x173F77C
	Length get_maxHeight() { }

	// RVA: 0x173F720
	Length get_maxWidth() { }

	// RVA: 0x173F834
	Length get_minHeight() { }

	// RVA: 0x173F7D8
	Length get_minWidth() { }

	// RVA: 0x1742AD8
	float get_opacity() { }

	// RVA: 0x173F668
	OverflowInternal get_overflow() { }

	// RVA: 0x173F388
	Length get_paddingBottom() { }

	// RVA: 0x173F274
	Length get_paddingLeft() { }

	// RVA: 0x173F32C
	Length get_paddingRight() { }

	// RVA: 0x173F2D0
	Length get_paddingTop() { }

	// RVA: 0x173F60C
	Position get_position() { }

	// RVA: 0x173F04C
	Length get_right() { }

	// RVA: 0x1742B34
	Rotate get_rotate() { }

	// RVA: 0x1742BA0
	Scale get_scale() { }

	// RVA: 0x1742C00
	TextOverflow get_textOverflow() { }

	// RVA: 0x1742C5C
	TextShadow get_textShadow() { }

	// RVA: 0x173EFF0
	Length get_top() { }

	// RVA: 0x1742CC8
	TransformOrigin get_transformOrigin() { }

	// RVA: 0x1742D34
	System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay() { }

	// RVA: 0x1742D90
	System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration() { }

	// RVA: 0x1742DEC
	System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty() { }

	// RVA: 0x1742E48
	System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x1742EA4
	Translate get_translate() { }

	// RVA: 0x1742F10
	Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x1742F70
	Font get_unityFont() { }

	// RVA: 0x1742FCC
	FontDefinition get_unityFontDefinition() { }

	// RVA: 0x174302C
	FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x1743088
	OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x17430E4
	Length get_unityParagraphSpacing() { }

	// RVA: 0x1743140
	int get_unitySliceBottom() { }

	// RVA: 0x174319C
	int get_unitySliceLeft() { }

	// RVA: 0x17431F8
	int get_unitySliceRight() { }

	// RVA: 0x1743254
	float get_unitySliceScale() { }

	// RVA: 0x17432B0
	int get_unitySliceTop() { }

	// RVA: 0x174330C
	TextAnchor get_unityTextAlign() { }

	// RVA: 0x1743368
	Color get_unityTextOutlineColor() { }

	// RVA: 0x17433C8
	float get_unityTextOutlineWidth() { }

	// RVA: 0x1743424
	TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x1743480
	Visibility get_visibility() { }

	// RVA: 0x17434DC
	WhiteSpace get_whiteSpace() { }

	// RVA: 0x173F554
	Length get_width() { }

	// RVA: 0x1743538
	Length get_wordSpacing() { }

	// RVA: 0x1743594
	ComputedStyle Create(ref ComputedStyle parentStyle) { }

	// RVA: 0x174379C
	ComputedStyle CreateInitial() { }

	// RVA: 0x1743958
	ComputedStyle Acquire() { }

	// RVA: 0x1743A8C
	void Release() { }

	// RVA: 0x17420F0
	void CopyFrom(ref ComputedStyle other) { }

	// RVA: 0x1743B90
	void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	// RVA: 0x1744F90
	void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle) { }

	// RVA: 0x1745E00
	void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle) { }

	// RVA: 0x1746274
	void ApplyStyleCursor(Cursor cursor) { }

	// RVA: 0x17462E4
	void ApplyStyleTextShadow(TextShadow st) { }

	// RVA: 0x1746358
	void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other) { }

	// RVA: 0x1747BE0
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue) { }

	// RVA: 0x17483BC
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue) { }

	// RVA: 0x1748710
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue) { }

	// RVA: 0x1748F14
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue) { }

	// RVA: 0x1749124
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue) { }

	// RVA: 0x17492B8
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue) { }

	// RVA: 0x1749408
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue) { }

	// RVA: 0x17496C0
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue) { }

	// RVA: 0x1749864
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue) { }

	// RVA: 0x1749A38
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue) { }

	// RVA: 0x1749BDC
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue) { }

	// RVA: 0x1749D34
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue) { }

	// RVA: 0x1749E84
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue) { }

	// RVA: 0x1749FD4
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue) { }

	// RVA: 0x174A11C
	void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue) { }

	// RVA: 0x174A264
	bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x174E234
	bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x17521AC
	bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x17553B0
	void ApplyStyleTransformOrigin(TransformOrigin st) { }

	// RVA: 0x175541C
	void ApplyStyleTranslate(Translate translateValue) { }

	// RVA: 0x1755488
	void ApplyStyleRotate(Rotate rotateValue) { }

	// RVA: 0x17554F4
	void ApplyStyleScale(Scale scaleValue) { }

	// RVA: 0x1755560
	void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue) { }

	// RVA: 0x173FBB0
	void ApplyInitialValue(StylePropertyReader reader) { }

	// RVA: 0x173FCC0
	void ApplyInitialValue(StylePropertyId id) { }

	// RVA: 0x173FC60
	void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle) { }

	// RVA: 0x17555CC
	void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle) { }

	// RVA: 0x1755BD8
	VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y) { }

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

	// RVA: 0x176784C
	void .cctor() { }

	// RVA: 0x17678B8
	void .ctor() { }

	// RVA: 0x17678C0
	float <ConvertTransitionFunction>b__12_0(float t) { }

	// RVA: 0x17678FC
	float <ConvertTransitionFunction>b__12_1(float t) { }

	// RVA: 0x1767904
	float <ConvertTransitionFunction>b__12_2(float t) { }

	// RVA: 0x176790C
	float <ConvertTransitionFunction>b__12_3(float t) { }

	// RVA: 0x1767914
	float <ConvertTransitionFunction>b__12_4(float t) { }

	// RVA: 0x176791C
	float <ConvertTransitionFunction>b__12_5(float t) { }

	// RVA: 0x1767924
	float <ConvertTransitionFunction>b__12_6(float t) { }

	// RVA: 0x176792C
	float <ConvertTransitionFunction>b__12_7(float t) { }

	// RVA: 0x1767934
	float <ConvertTransitionFunction>b__12_8(float t) { }

	// RVA: 0x176793C
	float <ConvertTransitionFunction>b__12_9(float t) { }

	// RVA: 0x1767944
	float <ConvertTransitionFunction>b__12_10(float t) { }

	// RVA: 0x176794C
	float <ConvertTransitionFunction>b__12_11(float t) { }

	// RVA: 0x1767954
	float <ConvertTransitionFunction>b__12_12(float t) { }

	// RVA: 0x176795C
	float <ConvertTransitionFunction>b__12_13(float t) { }

	// RVA: 0x1767964
	float <ConvertTransitionFunction>b__12_14(float t) { }

	// RVA: 0x176796C
	float <ConvertTransitionFunction>b__12_15(float t) { }

	// RVA: 0x1767974
	float <ConvertTransitionFunction>b__12_16(float t) { }

	// RVA: 0x176797C
	float <ConvertTransitionFunction>b__12_17(float t) { }

	// RVA: 0x1767984
	float <ConvertTransitionFunction>b__12_18(float t) { }

	// RVA: 0x176798C
	float <ConvertTransitionFunction>b__12_19(float t) { }

	// RVA: 0x1767994
	float <ConvertTransitionFunction>b__12_20(float t) { }

	// RVA: 0x176799C
	float <ConvertTransitionFunction>b__12_21(float t) { }

	// RVA: 0x17679A4
	float <ConvertTransitionFunction>b__12_22(float t) { }

}

// Namespace: UnityEngine.UIElements
internal static class ComputedTransitionUtils 
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> s_ComputedTransitionsBuffer; // 0x0

	// Methods

	// RVA: 0x17657C4
	void UpdateComputedTransitions(ref ComputedStyle computedStyle) { }

	// RVA: 0x1765A8C
	bool HasTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id) { }

	// RVA: 0x1765B64
	bool GetTransitionProperty(ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result) { }

	// RVA: 0x1765844
	ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle) { }

	// RVA: 0x1765CBC
	int GetTransitionHashCode(ref ComputedStyle cs) { }

	// RVA: 0x1766620
	bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y) { }

	// RVA: 0x1766794
	bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> a, System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> b) { }

	// RVA: 0x17668A0
	bool SameTransitionProperty(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> a, System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> b) { }

	// RVA: 0x1766340
	void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, System.Collections.Generic.List<UnityEngine.UIElements.ComputedTransitionProperty> outData) { }

	// RVA: 0x309AF8C
	T GetWrappingTransitionData(System.Collections.Generic.List<T> list, int i, T defaultValue) { }

	// RVA: 0x17669C8
	int ConvertTransitionTime(TimeValue time) { }

	// RVA: 0x1766AFC
	System.Func<System.Single,System.Single> ConvertTransitionFunction(EasingMode mode) { }

	// RVA: 0x17677B0
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public struct CustomStyleProperty<T0> 
{
	// Fields
	private string <name>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE360C
	string get_name() { }

	// RVA: 0x2FE4574
	void set_name(string value) { }

	// RVA: 0x2FE4574
	void .ctor(string propertyName) { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x309AF8C
	bool Equals(UnityEngine.UIElements.CustomStyleProperty<T> other) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public interface ICustomStyle 
{
	// Methods

	// RVA: -1
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, out float value) { }

	// RVA: -1
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, out int value) { }

	// RVA: -1
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, out Color value) { }

	// RVA: -1
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, out Texture2D value) { }

	// RVA: -1
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, out Sprite value) { }

	// RVA: -1
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, out VectorImage value) { }

	// RVA: -1
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, out string value) { }

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

	// RVA: 0x17679AC
	EasingMode get_mode() { }

	// RVA: 0x17679B4
	void .ctor(EasingMode mode) { }

	// RVA: 0x1766AF8
	EasingFunction op_Implicit(EasingMode easingMode) { }

	// RVA: 0x17679BC
	bool op_Equality(EasingFunction lhs, EasingFunction rhs) { }

	// RVA: 0x17679C8
	bool Equals(EasingFunction other) { }

	// RVA: 0x17679D8
	bool Equals(object obj) { }

	// RVA: 0x1767A68
	string ToString() { }

	// RVA: 0x1766618
	int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public struct FontDefinition 
{
	// Fields
	private Font m_Font; // 0x10
	private FontAsset m_FontAsset; // 0x18

	// Methods

	// RVA: 0x1767ADC
	Font get_font() { }

	// RVA: 0x1767AE4
	FontAsset get_fontAsset() { }

	// RVA: 0x1767AEC
	FontDefinition FromFont(Font f) { }

	// RVA: 0x1767B18
	FontDefinition FromSDFFont(FontAsset f) { }

	// RVA: 0x1767B48
	FontDefinition FromObject(object obj) { }

	// RVA: 0x1767CBC
	bool IsEmpty() { }

	// RVA: 0x1767D84
	string ToString() { }

	// RVA: 0x1767E20
	bool Equals(FontDefinition other) { }

	// RVA: 0x1767E68
	bool Equals(object obj) { }

	// RVA: 0x1767F08
	int GetHashCode() { }

	// RVA: 0x1768040
	bool op_Equality(FontDefinition left, FontDefinition right) { }

	// RVA: 0x1768088
	bool op_Inequality(FontDefinition left, FontDefinition right) { }

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

	// RVA: 0x17680DC
	void UnityEngine.UIElements.IStyle.set_backgroundColor(StyleColor value) { }

	// RVA: 0x1768300
	void UnityEngine.UIElements.IStyle.set_borderBottomColor(StyleColor value) { }

	// RVA: 0x1768360
	void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(StyleLength value) { }

	// RVA: 0x1768554
	void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(StyleLength value) { }

	// RVA: 0x17685AC
	void UnityEngine.UIElements.IStyle.set_borderBottomWidth(StyleFloat value) { }

	// RVA: 0x17687A8
	void UnityEngine.UIElements.IStyle.set_borderLeftColor(StyleColor value) { }

	// RVA: 0x1768808
	void UnityEngine.UIElements.IStyle.set_borderLeftWidth(StyleFloat value) { }

	// RVA: 0x1768884
	void UnityEngine.UIElements.IStyle.set_borderRightColor(StyleColor value) { }

	// RVA: 0x17688E4
	void UnityEngine.UIElements.IStyle.set_borderRightWidth(StyleFloat value) { }

	// RVA: 0x1768960
	void UnityEngine.UIElements.IStyle.set_borderTopColor(StyleColor value) { }

	// RVA: 0x17689C0
	void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(StyleLength value) { }

	// RVA: 0x1768A18
	void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(StyleLength value) { }

	// RVA: 0x1768A70
	void UnityEngine.UIElements.IStyle.set_borderTopWidth(StyleFloat value) { }

	// RVA: 0x1768AEC
	void UnityEngine.UIElements.IStyle.set_bottom(StyleLength value) { }

	// RVA: 0x1768B7C
	void UnityEngine.UIElements.IStyle.set_color(StyleColor value) { }

	// RVA: 0x1768BD8
	UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> UnityEngine.UIElements.IStyle.get_display() { }

	// RVA: 0x1768C80
	void UnityEngine.UIElements.IStyle.set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value) { }

	// RVA: 0x1768D40
	void UnityEngine.UIElements.IStyle.set_flexBasis(StyleLength value) { }

	// RVA: 0x1768DD0
	void UnityEngine.UIElements.IStyle.set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value) { }

	// RVA: 0x1768E90
	void UnityEngine.UIElements.IStyle.set_flexGrow(StyleFloat value) { }

	// RVA: 0x1768F0C
	void UnityEngine.UIElements.IStyle.set_flexShrink(StyleFloat value) { }

	// RVA: 0x1768F88
	void UnityEngine.UIElements.IStyle.set_fontSize(StyleLength value) { }

	// RVA: 0x1768FDC
	void UnityEngine.UIElements.IStyle.set_height(StyleLength value) { }

	// RVA: 0x176906C
	void UnityEngine.UIElements.IStyle.set_left(StyleLength value) { }

	// RVA: 0x17690FC
	void UnityEngine.UIElements.IStyle.set_marginBottom(StyleLength value) { }

	// RVA: 0x176918C
	void UnityEngine.UIElements.IStyle.set_marginLeft(StyleLength value) { }

	// RVA: 0x176921C
	void UnityEngine.UIElements.IStyle.set_marginRight(StyleLength value) { }

	// RVA: 0x17692AC
	void UnityEngine.UIElements.IStyle.set_marginTop(StyleLength value) { }

	// RVA: 0x176933C
	void UnityEngine.UIElements.IStyle.set_maxHeight(StyleLength value) { }

	// RVA: 0x17693CC
	void UnityEngine.UIElements.IStyle.set_maxWidth(StyleLength value) { }

	// RVA: 0x176945C
	void UnityEngine.UIElements.IStyle.set_minWidth(StyleLength value) { }

	// RVA: 0x17694EC
	void UnityEngine.UIElements.IStyle.set_opacity(StyleFloat value) { }

	// RVA: 0x176953C
	void UnityEngine.UIElements.IStyle.set_overflow(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Overflow> value) { }

	// RVA: 0x1769680
	void UnityEngine.UIElements.IStyle.set_paddingBottom(StyleLength value) { }

	// RVA: 0x1769710
	void UnityEngine.UIElements.IStyle.set_paddingLeft(StyleLength value) { }

	// RVA: 0x17697A0
	void UnityEngine.UIElements.IStyle.set_paddingRight(StyleLength value) { }

	// RVA: 0x1769830
	StyleLength UnityEngine.UIElements.IStyle.get_paddingTop() { }

	// RVA: 0x1769854
	void UnityEngine.UIElements.IStyle.set_paddingTop(StyleLength value) { }

	// RVA: 0x17698E4
	void UnityEngine.UIElements.IStyle.set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value) { }

	// RVA: 0x17699A4
	void UnityEngine.UIElements.IStyle.set_right(StyleLength value) { }

	// RVA: 0x1769A34
	void UnityEngine.UIElements.IStyle.set_top(StyleLength value) { }

	// RVA: 0x1769AC4
	void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(StyleColor value) { }

	// RVA: 0x1769B24
	void UnityEngine.UIElements.IStyle.set_unityFont(StyleFont value) { }

	// RVA: 0x1769E04
	void UnityEngine.UIElements.IStyle.set_unityFontDefinition(StyleFontDefinition value) { }

	// RVA: 0x176A1E8
	void UnityEngine.UIElements.IStyle.set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value) { }

	// RVA: 0x176A27C
	StyleLength UnityEngine.UIElements.IStyle.get_width() { }

	// RVA: 0x176A2A0
	void UnityEngine.UIElements.IStyle.set_width(StyleLength value) { }

	// RVA: 0x176A330
	VisualElement get_ve() { }

	// RVA: 0x176A338
	void set_ve(VisualElement value) { }

	// RVA: 0x176A340
	void .ctor(VisualElement ve) { }

	// RVA: 0x176A374
	void Finalize() { }

	// RVA: 0x176A4DC
	void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x176B1F8
	bool IsValueSet(StylePropertyId id) { }

	// RVA: 0x176A5A0
	void ApplyInlineStyles(ref ComputedStyle computedStyle) { }

	// RVA: 0x176B64C
	StyleCursor UnityEngine.UIElements.IStyle.get_cursor() { }

	// RVA: 0x176B708
	StyleTextShadow UnityEngine.UIElements.IStyle.get_textShadow() { }

	// RVA: 0x176B798
	StyleBackgroundSize UnityEngine.UIElements.IStyle.get_backgroundSize() { }

	// RVA: 0x176B824
	StyleTransformOrigin UnityEngine.UIElements.IStyle.get_transformOrigin() { }

	// RVA: 0x176B8B0
	StyleTranslate UnityEngine.UIElements.IStyle.get_translate() { }

	// RVA: 0x176B948
	void UnityEngine.UIElements.IStyle.set_translate(StyleTranslate value) { }

	// RVA: 0x176BB18
	StyleRotate UnityEngine.UIElements.IStyle.get_rotate() { }

	// RVA: 0x176BBB0
	StyleScale UnityEngine.UIElements.IStyle.get_scale() { }

	// RVA: 0x17683B4
	bool SetStyleValue(StylePropertyId id, StyleLength inlineValue) { }

	// RVA: 0x1768628
	bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue) { }

	// RVA: 0x1768138
	bool SetStyleValue(StylePropertyId id, StyleColor inlineValue) { }

	// RVA: 0x309AF8C
	bool SetStyleValue(StylePropertyId id, UnityEngine.UIElements.StyleEnum<T> inlineValue) { }

	// RVA: 0x1769E64
	bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue) { }

	// RVA: 0x1769B78
	bool SetStyleValue(StylePropertyId id, StyleFont inlineValue) { }

	// RVA: 0x176B9A0
	bool SetInlineTranslate(StyleTranslate inlineValue) { }

	// RVA: 0x176C0E4
	void ApplyStyleTranslate(StyleTranslate translate) { }

	// RVA: 0x176BD58
	void ApplyStyleValue(StyleValue value) { }

	// RVA: 0x176BC3C
	bool RemoveInlineStyle(StylePropertyId id) { }

	// RVA: 0x176C3A0
	void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle) { }

	// RVA: 0x176B6CC
	bool TryGetInlineCursor(ref StyleCursor value) { }

	// RVA: 0x176B778
	bool TryGetInlineTextShadow(ref StyleTextShadow value) { }

	// RVA: 0x176B88C
	bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value) { }

	// RVA: 0x176B91C
	bool TryGetInlineTranslate(ref StyleTranslate value) { }

	// RVA: 0x176BB84
	bool TryGetInlineRotate(ref StyleRotate value) { }

	// RVA: 0x176BC18
	bool TryGetInlineScale(ref StyleScale value) { }

	// RVA: 0x176B800
	bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value) { }

	// RVA: 0x176C680
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IResolvedStyle 
{
	// Methods

	// RVA: -1
	Color get_backgroundColor() { }

	// RVA: -1
	Color get_borderBottomColor() { }

	// RVA: -1
	float get_borderBottomLeftRadius() { }

	// RVA: -1
	float get_borderBottomRightRadius() { }

	// RVA: -1
	float get_borderBottomWidth() { }

	// RVA: -1
	Color get_borderLeftColor() { }

	// RVA: -1
	float get_borderLeftWidth() { }

	// RVA: -1
	Color get_borderRightColor() { }

	// RVA: -1
	float get_borderRightWidth() { }

	// RVA: -1
	Color get_borderTopColor() { }

	// RVA: -1
	float get_borderTopLeftRadius() { }

	// RVA: -1
	float get_borderTopRightRadius() { }

	// RVA: -1
	float get_borderTopWidth() { }

	// RVA: -1
	float get_bottom() { }

	// RVA: -1
	Color get_color() { }

	// RVA: 0x2FE32D4
	DisplayStyle get_display() { }

	// RVA: 0x2FE32D4
	FlexDirection get_flexDirection() { }

	// RVA: -1
	float get_flexGrow() { }

	// RVA: -1
	float get_flexShrink() { }

	// RVA: -1
	float get_height() { }

	// RVA: -1
	float get_left() { }

	// RVA: -1
	float get_marginBottom() { }

	// RVA: -1
	float get_marginLeft() { }

	// RVA: -1
	float get_marginRight() { }

	// RVA: -1
	float get_marginTop() { }

	// RVA: -1
	StyleFloat get_minHeight() { }

	// RVA: -1
	StyleFloat get_minWidth() { }

	// RVA: -1
	float get_opacity() { }

	// RVA: -1
	float get_paddingBottom() { }

	// RVA: -1
	float get_paddingLeft() { }

	// RVA: -1
	float get_paddingRight() { }

	// RVA: -1
	float get_paddingTop() { }

	// RVA: -1
	float get_right() { }

	// RVA: -1
	Scale get_scale() { }

	// RVA: -1
	float get_top() { }

	// RVA: -1
	Vector3 get_transformOrigin() { }

	// RVA: -1
	Vector3 get_translate() { }

	// RVA: -1
	Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x2FE32D4
	int get_unitySliceLeft() { }

	// RVA: 0x2FE32D4
	int get_unitySliceRight() { }

	// RVA: -1
	float get_unitySliceScale() { }

	// RVA: -1
	Color get_unityTextOutlineColor() { }

	// RVA: -1
	float get_unityTextOutlineWidth() { }

	// RVA: 0x2FE32D4
	Visibility get_visibility() { }

	// RVA: -1
	float get_width() { }

}

// Namespace: UnityEngine.UIElements
public interface IStyle 
{
	// Methods

	// RVA: -1
	void set_backgroundColor(StyleColor value) { }

	// RVA: -1
	StyleBackgroundSize get_backgroundSize() { }

	// RVA: -1
	void set_borderBottomColor(StyleColor value) { }

	// RVA: -1
	void set_borderBottomLeftRadius(StyleLength value) { }

	// RVA: -1
	void set_borderBottomRightRadius(StyleLength value) { }

	// RVA: -1
	void set_borderBottomWidth(StyleFloat value) { }

	// RVA: -1
	void set_borderLeftColor(StyleColor value) { }

	// RVA: -1
	void set_borderLeftWidth(StyleFloat value) { }

	// RVA: -1
	void set_borderRightColor(StyleColor value) { }

	// RVA: -1
	void set_borderRightWidth(StyleFloat value) { }

	// RVA: -1
	void set_borderTopColor(StyleColor value) { }

	// RVA: -1
	void set_borderTopLeftRadius(StyleLength value) { }

	// RVA: -1
	void set_borderTopRightRadius(StyleLength value) { }

	// RVA: -1
	void set_borderTopWidth(StyleFloat value) { }

	// RVA: -1
	void set_bottom(StyleLength value) { }

	// RVA: -1
	void set_color(StyleColor value) { }

	// RVA: -1
	StyleCursor get_cursor() { }

	// RVA: -1
	UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> get_display() { }

	// RVA: -1
	void set_display(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.DisplayStyle> value) { }

	// RVA: -1
	void set_flexBasis(StyleLength value) { }

	// RVA: -1
	void set_flexDirection(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.FlexDirection> value) { }

	// RVA: -1
	void set_flexGrow(StyleFloat value) { }

	// RVA: -1
	void set_flexShrink(StyleFloat value) { }

	// RVA: -1
	void set_fontSize(StyleLength value) { }

	// RVA: -1
	void set_height(StyleLength value) { }

	// RVA: -1
	void set_left(StyleLength value) { }

	// RVA: -1
	void set_marginBottom(StyleLength value) { }

	// RVA: -1
	void set_marginLeft(StyleLength value) { }

	// RVA: -1
	void set_marginRight(StyleLength value) { }

	// RVA: -1
	void set_marginTop(StyleLength value) { }

	// RVA: -1
	void set_maxHeight(StyleLength value) { }

	// RVA: -1
	void set_maxWidth(StyleLength value) { }

	// RVA: -1
	void set_minWidth(StyleLength value) { }

	// RVA: -1
	void set_opacity(StyleFloat value) { }

	// RVA: -1
	void set_overflow(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Overflow> value) { }

	// RVA: -1
	void set_paddingBottom(StyleLength value) { }

	// RVA: -1
	void set_paddingLeft(StyleLength value) { }

	// RVA: -1
	void set_paddingRight(StyleLength value) { }

	// RVA: -1
	StyleLength get_paddingTop() { }

	// RVA: -1
	void set_paddingTop(StyleLength value) { }

	// RVA: -1
	void set_position(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Position> value) { }

	// RVA: -1
	void set_right(StyleLength value) { }

	// RVA: -1
	StyleRotate get_rotate() { }

	// RVA: -1
	StyleScale get_scale() { }

	// RVA: -1
	StyleTextShadow get_textShadow() { }

	// RVA: -1
	void set_top(StyleLength value) { }

	// RVA: -1
	StyleTransformOrigin get_transformOrigin() { }

	// RVA: -1
	StyleTranslate get_translate() { }

	// RVA: -1
	void set_translate(StyleTranslate value) { }

	// RVA: -1
	void set_unityBackgroundImageTintColor(StyleColor value) { }

	// RVA: -1
	void set_unityFont(StyleFont value) { }

	// RVA: -1
	void set_unityFontDefinition(StyleFontDefinition value) { }

	// RVA: -1
	void set_visibility(UnityEngine.UIElements.StyleEnum<UnityEngine.UIElements.Visibility> value) { }

	// RVA: -1
	StyleLength get_width() { }

	// RVA: -1
	void set_width(StyleLength value) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x177EF70
	void .ctor() { }

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

	// RVA: 0x177EFC4
	UxmlIntAttributeDescription get_focusIndex() { }

	// RVA: 0x177EFCC
	UxmlBoolAttributeDescription get_focusable() { }

	// RVA: 0x177EFD4
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x177F2D0
	void .ctor() { }

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
	private const string k_InvalidHierarchyChangeMsg = 5475812128;
	private readonly VisualElement m_Owner; // 0x10

	// Methods

	// RVA: 0x176F5B4
	VisualElement get_parent() { }

	// RVA: 0x177F890
	System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> get_children() { }

	// RVA: 0x17745A0
	void .ctor(VisualElement element) { }

	// RVA: 0x177BB0C
	void Add(VisualElement child) { }

	// RVA: 0x177BC60
	void Insert(int index, VisualElement child) { }

	// RVA: 0x177D318
	void Remove(VisualElement child) { }

	// RVA: 0x177FACC
	void RemoveAt(int index) { }

	// RVA: 0x177C0A0
	void Clear() { }

	// RVA: 0x177CEA0
	void BringToFront(VisualElement child) { }

	// RVA: 0x177CFF4
	void SendToBack(VisualElement child) { }

	// RVA: 0x177D1C4
	void PlaceBehind(VisualElement child, VisualElement over) { }

	// RVA: 0x177FF84
	void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) { }

	// RVA: 0x177C790
	int get_childCount() { }

	// RVA: 0x177C678
	VisualElement get_Item(int key) { }

	// RVA: 0x177C89C
	int IndexOf(VisualElement element) { }

	// RVA: 0x1780098
	VisualElement ElementAt(int index) { }

	// RVA: 0x177CE40
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children() { }

	// RVA: 0x177F9EC
	void SetParent(VisualElement value) { }

	// RVA: 0x177F8B0
	void PutChildAtIndex(VisualElement child, int index) { }

	// RVA: 0x177FDCC
	void RemoveChildAtIndex(int index) { }

	// RVA: 0x177FE54
	void ReleaseChildList() { }

	// RVA: 0x1780118
	bool Equals(Hierarchy other) { }

	// RVA: 0x1780134
	bool Equals(object obj) { }

	// RVA: 0x17801C4
	int GetHashCode() { }

	// RVA: 0x1780128
	bool op_Equality(Hierarchy x, Hierarchy y) { }

}

// Namespace: 
private abstract class BaseVisualElementScheduledItem 
{
	// Fields
	private VisualElement <element>k__BackingField; // 0x38
	public bool isScheduled; // 0x40
	private VisualElementPanelActivator m_Activator; // 0x48

	// Methods

	// RVA: 0x17801DC
	VisualElement get_element() { }

	// RVA: 0x17801E4
	void set_element(VisualElement value) { }

	// RVA: 0x17801EC
	bool get_isActive() { }

	// RVA: 0x178020C
	void .ctor(VisualElement handler) { }

	// RVA: 0x17802C4
	IVisualElementScheduledItem StartingIn(Int64 delayMs) { }

	// RVA: 0x17802CC
	IVisualElementScheduledItem Every(Int64 intervalMs) { }

	// RVA: 0x17803D0
	void OnItemUnscheduled() { }

	// RVA: 0x177E348
	void Resume() { }

	// RVA: 0x1780420
	void Pause() { }

	// RVA: 0x1780444
	void ExecuteLater(Int64 delayMs) { }

	// RVA: 0x1780494
	void OnPanelActivate() { }

	// RVA: 0x178059C
	void OnPanelDeactivate() { }

	// RVA: 0x1780690
	bool CanBeActivated() { }

}

// Namespace: 
private abstract class VisualElementScheduledItem<T0> 
{
	// Fields
	public ActionType updateEvent; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(VisualElement handler, ActionType upEvent) { }

}

// Namespace: 
private class TimerStateScheduledItem 
{
	// Methods

	// RVA: 0x177E2DC
	void .ctor(VisualElement handler, System.Action<UnityEngine.UIElements.TimerState> updateEvent) { }

	// RVA: 0x17806D4
	void PerformTimerUpdate(TimerState state) { }

}

// Namespace: 
private class SimpleScheduledItem 
{
	// Methods

	// RVA: 0x177E46C
	void .ctor(VisualElement handler, Action updateEvent) { }

	// RVA: 0x1780718
	void PerformTimerUpdate(TimerState state) { }

}

// Namespace: 
internal class CustomStyleAccess 
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_CustomProperties; // 0x10
	private float m_DpiScaling; // 0x18

	// Methods

	// RVA: 0x177E58C
	void SetContext(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.StyleSheets.StylePropertyValue> customProperties, float dpiScaling) { }

	// RVA: 0x1780750
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Single> property, out float value) { }

	// RVA: 0x1780948
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.Int32> property, out int value) { }

	// RVA: 0x1780AB4
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Color> property, out Color value) { }

	// RVA: 0x1780D18
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Texture2D> property, out Texture2D value) { }

	// RVA: 0x1780E2C
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.Sprite> property, out Sprite value) { }

	// RVA: 0x1780F40
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<UnityEngine.UIElements.VectorImage> property, out VectorImage value) { }

	// RVA: 0x1781054
	bool TryGetValue(UnityEngine.UIElements.CustomStyleProperty<System.String> property, out string value) { }

	// RVA: 0x1780874
	bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp) { }

	// RVA: 0x1780C14
	void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

	// RVA: 0x177EF64
	void .ctor() { }

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

	// RVA: 0x1781128
	Type get_type() { }

	// RVA: 0x177EBE8
	void .ctor(Type type) { }

	// RVA: 0x177405C
	string get_fullTypeName() { }

	// RVA: 0x17740D8
	string get_typeName() { }

	// RVA: 0x1781130
	string get_typeNamespace() { }

}

// Namespace: 
private sealed class <>c__DisplayClass492_0 
{
	// Fields
	public VisualElement <>4__this; // 0x10
	public StyleValues to; // 0x18

	// Methods

	// RVA: 0x177B1AC
	void .ctor() { }

	// RVA: 0x1781190
	StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(VisualElement e) { }

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
	internal const string k_RootVisualContainerName = 5714771872;
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

	// RVA: 0x176C708
	IResolvedStyle get_resolvedStyle() { }

	// RVA: 0x176C70C
	Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }

	// RVA: 0x176C720
	Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }

	// RVA: 0x176C72C
	float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }

	// RVA: 0x176C74C
	float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }

	// RVA: 0x176C76C
	float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }

	// RVA: 0x176C78C
	Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }

	// RVA: 0x176C798
	float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }

	// RVA: 0x176C7B8
	Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }

	// RVA: 0x176C7C4
	float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }

	// RVA: 0x176C7E4
	Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }

	// RVA: 0x176C7F0
	float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }

	// RVA: 0x176C810
	float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }

	// RVA: 0x176C830
	float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }

	// RVA: 0x176C850
	float UnityEngine.UIElements.IResolvedStyle.get_bottom() { }

	// RVA: 0x176C870
	Color UnityEngine.UIElements.IResolvedStyle.get_color() { }

	// RVA: 0x176C87C
	DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0x176C888
	FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }

	// RVA: 0x176C894
	float UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }

	// RVA: 0x176C8A0
	float UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }

	// RVA: 0x176C8AC
	float UnityEngine.UIElements.IResolvedStyle.get_height() { }

	// RVA: 0x176C8CC
	float UnityEngine.UIElements.IResolvedStyle.get_left() { }

	// RVA: 0x176C8EC
	float UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }

	// RVA: 0x176C90C
	float UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }

	// RVA: 0x176C92C
	float UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }

	// RVA: 0x176C94C
	float UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }

	// RVA: 0x176C96C
	StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }

	// RVA: 0x176CB64
	StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }

	// RVA: 0x176CB98
	float UnityEngine.UIElements.IResolvedStyle.get_opacity() { }

	// RVA: 0x176CBA4
	float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }

	// RVA: 0x176CBC4
	float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }

	// RVA: 0x176CBE4
	float UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }

	// RVA: 0x176CC04
	float UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }

	// RVA: 0x176CC24
	float UnityEngine.UIElements.IResolvedStyle.get_right() { }

	// RVA: 0x176CC44
	Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }

	// RVA: 0x176CC50
	float UnityEngine.UIElements.IResolvedStyle.get_top() { }

	// RVA: 0x176CC70
	Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }

	// RVA: 0x176CF78
	Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }

	// RVA: 0x176D174
	Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }

	// RVA: 0x176D180
	int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }

	// RVA: 0x176D18C
	int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }

	// RVA: 0x176D198
	float UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale() { }

	// RVA: 0x176D1A4
	Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }

	// RVA: 0x176D1B0
	float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }

	// RVA: 0x176D1BC
	Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0x176D1C8
	float UnityEngine.UIElements.IResolvedStyle.get_width() { }

	// RVA: 0x176D1E8
	bool get_hasRunningAnimations() { }

	// RVA: 0x176D29C
	bool get_hasCompletedAnimations() { }

	// RVA: 0x176D34C
	int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }

	// RVA: 0x176D354
	void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value) { }

	// RVA: 0x176D35C
	int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }

	// RVA: 0x176D364
	void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value) { }

	// RVA: 0x176D36C
	IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }

	// RVA: 0x176D298
	IStylePropertyAnimations get_styleAnimation() { }

	// RVA: 0x176D388
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176D490
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176D5AC
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176D6C8
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176D81C
	bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176D938
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176DA78
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176DBA8
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176DCC4
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176DE24
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176DF54
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176E0B4
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176E214
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176E374
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176E4A4
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176E5C0
	bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x176E720
	void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(StylePropertyId id) { }

	// RVA: 0x176E800
	void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }

	// RVA: 0x176EA28
	void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) { }

	// RVA: 0x176EAFC
	void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: 0x176ED2C
	bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex) { }

	// RVA: 0x176F3C4
	bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to) { }

	// RVA: 0x176F44C
	bool TryConvertTranslateUnits(ref Translate from, ref Translate to) { }

	// RVA: 0x176F4D4
	bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to) { }

	// RVA: 0x176F090
	System.Nullable<System.Single> GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex) { }

	// RVA: 0x176F5D4
	bool get_isCompositeRoot() { }

	// RVA: 0x176F5E0
	void set_isCompositeRoot(bool value) { }

	// RVA: 0x176F7A8
	bool get_isHierarchyDisplayed() { }

	// RVA: 0x176F7B4
	void set_isHierarchyDisplayed(bool value) { }

	// RVA: 0x176F7D4
	string get_viewDataKey() { }

	// RVA: 0x176F7DC
	void set_viewDataKey(string value) { }

	// RVA: 0x176F888
	bool get_enableViewDataPersistence() { }

	// RVA: 0x176F894
	void set_enableViewDataPersistence(bool value) { }

	// RVA: 0x176F8B4
	object get_userData() { }

	// RVA: 0x176FB74
	void set_userData(object value) { }

	// RVA: 0x176FEC4
	bool get_canGrabFocus() { }

	// RVA: 0x1770138
	FocusController get_focusController() { }

	// RVA: 0x1770204
	UsageHints get_usageHints() { }

	// RVA: 0x1770224
	void set_usageHints(UsageHints value) { }

	// RVA: 0x177021C
	RenderHints get_renderHints() { }

	// RVA: 0x17703BC
	void set_renderHints(RenderHints value) { }

	// RVA: 0x1770404
	void MarkRenderHintsClean() { }

	// RVA: 0x1770414
	ITransform get_transform() { }

	// RVA: 0x1770418
	Vector3 UnityEngine.UIElements.ITransform.get_position() { }

	// RVA: 0x17704CC
	void UnityEngine.UIElements.ITransform.set_position(Vector3 value) { }

	// RVA: 0x1770738
	Vector3 UnityEngine.UIElements.ITransform.get_scale() { }

	// RVA: 0x17707F0
	bool get_isLayoutManual() { }

	// RVA: 0x17707FC
	void set_isLayoutManual(bool value) { }

	// RVA: 0x177081C
	float get_scaledPixelsPerPoint() { }

	// RVA: 0x177089C
	Rect get_layout() { }

	// RVA: 0x1770940
	void set_layout(Rect value) { }

	// RVA: 0x17711C8
	void ClearManualLayout() { }

	// RVA: 0x1771828
	Rect get_contentRect() { }

	// RVA: 0x1771A40
	Rect get_paddingRect() { }

	// RVA: 0x1771C7C
	bool get_isBoundingBoxDirty() { }

	// RVA: 0x1771C88
	void set_isBoundingBoxDirty(bool value) { }

	// RVA: 0x1771CA8
	void set_isWorldBoundingBoxDirty(bool value) { }

	// RVA: 0x1771CC8
	bool get_isWorldBoundingBoxOrDependenciesDirty() { }

	// RVA: 0x1771CDC
	Rect get_boundingBox() { }

	// RVA: 0x1771F84
	Rect get_worldBoundingBox() { }

	// RVA: 0x1772110
	Rect get_boundingBoxInParentSpace() { }

	// RVA: 0x1771D24
	void UpdateBoundingBox() { }

	// RVA: 0x1771FD4
	void UpdateWorldBoundingBox() { }

	// RVA: 0x177236C
	Rect get_worldBound() { }

	// RVA: 0x177245C
	Rect get_localBound() { }

	// RVA: 0x1771C60
	Rect get_rect() { }

	// RVA: 0x17724A4
	bool get_isWorldTransformDirty() { }

	// RVA: 0x17724B0
	void set_isWorldTransformDirty(bool value) { }

	// RVA: 0x17724C4
	void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0x17724E4
	bool get_isWorldTransformInverseOrDependenciesDirty() { }

	// RVA: 0x17724F4
	Matrix4x4 get_worldTransform() { }

	// RVA: 0x177233C
	ref Matrix4x4 get_worldTransformRef() { }

	// RVA: 0x177283C
	ref Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0x1772534
	void UpdateWorldTransform() { }

	// RVA: 0x17728A8
	void UpdateWorldTransformInverse() { }

	// RVA: 0x1772DAC
	bool get_isWorldClipDirty() { }

	// RVA: 0x1772DB8
	void set_isWorldClipDirty(bool value) { }

	// RVA: 0x1772DD8
	Rect get_worldClip() { }

	// RVA: 0x1773150
	Rect get_worldClipMinusGroup() { }

	// RVA: 0x1773198
	bool get_worldClipIsInfinite() { }

	// RVA: 0x17731D4
	void EnsureWorldTransformAndClipUpToDate() { }

	// RVA: 0x1772E20
	void UpdateWorldClip() { }

	// RVA: 0x17737D8
	Rect CombineClipRects(Rect rect, Rect parentRect) { }

	// RVA: 0x177322C
	Rect SubstractBorderPadding(Rect worldRect) { }

	// RVA: 0x1773828
	Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) { }

	// RVA: 0x1773948
	PseudoStates get_pseudoStates() { }

	// RVA: 0x1773950
	void set_pseudoStates(PseudoStates value) { }

	// RVA: 0x17739D8
	int get_containedPointerIds() { }

	// RVA: 0x17739E0
	void set_containedPointerIds(int value) { }

	// RVA: 0x17739E8
	void UpdateHoverPseudoState() { }

	// RVA: 0x1773BE4
	bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement) { }

	// RVA: 0x1773CF0
	PickingMode get_pickingMode() { }

	// RVA: 0x1773CF8
	void set_pickingMode(PickingMode value) { }

	// RVA: 0x1773D30
	string get_name() { }

	// RVA: 0x1773D38
	void set_name(string value) { }

	// RVA: 0x1773DB0
	System.Collections.Generic.List<System.String> get_classList() { }

	// RVA: 0x1773EAC
	string get_fullTypeName() { }

	// RVA: 0x17740BC
	string get_typeName() { }

	// RVA: 0x1774198
	YogaNode get_yogaNode() { }

	// RVA: 0x17741A0
	void set_yogaNode(YogaNode value) { }

	// RVA: 0x176C718
	ref ComputedStyle get_computedStyle() { }

	// RVA: 0x17741B0
	bool get_hasInlineStyle() { }

	// RVA: 0x17741C0
	bool get_styleInitialized() { }

	// RVA: 0x17741CC
	void set_styleInitialized(bool value) { }

	// RVA: 0x17741EC
	void ChangeIMGUIContainerCount(int delta) { }

	// RVA: 0x1774220
	void .ctor() { }

	// RVA: 0x17745C8
	void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x1775238
	Rect GetTooltipRect() { }

	// RVA: 0x177514C
	void SetTooltip(TooltipEvent e) { }

	// RVA: 0x1775360
	void Focus() { }

	// RVA: 0x17753C4
	void SetPanel(BaseVisualElementPanel p) { }

	// RVA: 0x1775FB4
	void WillChangePanel(BaseVisualElementPanel destinationPanel) { }

	// RVA: 0x17761A8
	void HasChangedPanel(BaseVisualElementPanel prevPanel) { }

	// RVA: 0x1776710
	void SendEvent(EventBase e) { }

	// RVA: 0x1776728
	void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: 0x176F864
	void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0x177673C
	void InvokeHierarchyChanged(HierarchyChangeType changeType) { }

	// RVA: 0x1776758
	bool SetEnabledFromHierarchyPrivate(bool state) { }

	// RVA: 0x1776B40
	bool get_isParentEnabledInHierarchy() { }

	// RVA: 0x1770128
	bool get_enabledInHierarchy() { }

	// RVA: 0x1776EBC
	bool get_enabledSelf() { }

	// RVA: 0x1776EC4
	void set_enabledSelf(bool value) { }

	// RVA: 0x17745A8
	void SetEnabled(bool value) { }

	// RVA: 0x1776ECC
	void PropagateEnabledToChildren(bool value) { }

	// RVA: 0x1776F98
	LanguageDirection get_languageDirection() { }

	// RVA: 0x1776FA0
	LanguageDirection get_localLanguageDirection() { }

	// RVA: 0x1776FA8
	void set_localLanguageDirection(LanguageDirection value) { }

	// RVA: 0x1770078
	bool get_visible() { }

	// RVA: 0x17770B8
	void set_visible(bool value) { }

	// RVA: 0x1777230
	void MarkDirtyRepaint() { }

	// RVA: 0x1777254
	System.Action<UnityEngine.UIElements.MeshGenerationContext> get_generateVisualContent() { }

	// RVA: 0x177725C
	void set_generateVisualContent(System.Action<UnityEngine.UIElements.MeshGenerationContext> value) { }

	// RVA: 0x177726C
	void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x177746C
	void GetFullHierarchicalViewDataKey(StringBuilder key) { }

	// RVA: 0x1777510
	string GetFullHierarchicalViewDataKey() { }

	// RVA: 0x309AF8C
	T GetOrCreateViewData(object existing, string key) { }

	// RVA: 0x1777590
	void OverwriteFromViewData(object obj, string key) { }

	// RVA: 0x17778D0
	void SaveViewData() { }

	// RVA: 0x177795C
	bool IsViewDataPersitenceSupportedOnChildren(bool existingState) { }

	// RVA: 0x1777A08
	void OnViewDataReady(bool enablePersistence) { }

	// RVA: 0x1777A34
	void OnViewDataReady() { }

	// RVA: 0x1777A38
	bool ContainsPoint(Vector2 localPoint) { }

	// RVA: 0x1777A8C
	bool get_requireMeasureFunction() { }

	// RVA: 0x1777A98
	void set_requireMeasureFunction(bool value) { }

	// RVA: 0x1777BA8
	void AssignMeasureFunction() { }

	// RVA: 0x1777C3C
	void RemoveMeasureFunction() { }

	// RVA: 0x1777C60
	Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x1777C70
	YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x1777DF4
	void FinalizeLayout() { }

	// RVA: 0x1777EEC
	void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x1777F94
	void SetComputedStyle(ref ComputedStyle newStyle) { }

	// RVA: 0x1778158
	string ToString() { }

	// RVA: 0x1778338
	System.Collections.Generic.List<System.String> GetClassesForIteration() { }

	// RVA: 0x1776CBC
	void AddToClassList(string className) { }

	// RVA: 0x1776B7C
	void RemoveFromClassList(string className) { }

	// RVA: 0x1776EB0
	void EnableInClassList(string className, bool enable) { }

	// RVA: 0x1778340
	bool ClassListContains(string cls) { }

	// RVA: 0x1778408
	object GetProperty(PropertyName key) { }

	// RVA: 0x17785FC
	void SetProperty(PropertyName key, object value) { }

	// RVA: 0x1778680
	bool HasProperty(PropertyName key) { }

	// RVA: 0x176F938
	bool TryGetPropertyInternal(PropertyName key, out object value) { }

	// RVA: 0x1778494
	void CheckUserKeyArgument(PropertyName key) { }

	// RVA: 0x176FBE8
	void SetPropertyInternal(PropertyName key, object value) { }

	// RVA: 0x1774CC0
	void UpdateCursorStyle(Int64 eventType) { }

	// RVA: 0x1778708
	RenderTargetMode get_subRenderTargetMode() { }

	// RVA: 0x1778710
	Material get_defaultMaterial() { }

	// RVA: 0x1778718
	VisualElementAnimationSystem GetAnimationSystem() { }

	// RVA: 0x17787B8
	void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x1778904
	void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x17764C0
	void UnregisterRunningAnimations() { }

	// RVA: 0x1776638
	void RegisterRunningAnimations() { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.Experimental.ValueAnimation<T> StartAnimation(UnityEngine.UIElements.Experimental.ValueAnimation<T> anim, System.Func<UnityEngine.UIElements.VisualElement,T> fromValueGetter, T to, int durationMs, System.Action<UnityEngine.UIElements.VisualElement,T> onValueChanged) { }

	// RVA: 0x17789F4
	void AssignStyleValues(VisualElement ve, StyleValues src) { }

	// RVA: 0x177A104
	StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) { }

	// RVA: 0x177B0A0
	UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(StyleValues to, int durationMs) { }

	// RVA: 0x177B1B4
	UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(System.Func<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.Experimental.StyleValues> fromValueGetter, StyleValues to, int durationMs) { }

	// RVA: 0x177B344
	void DirtyNextParentWithEventCallback() { }

	// RVA: 0x176F6E0
	void SetAsNextParentWithEventCallback() { }

	// RVA: 0x177B3C8
	bool GetCachedNextParentWithEventCallback(out VisualElement nextParent) { }

	// RVA: 0x177B420
	VisualElement get_nextParentWithEventCallback() { }

	// RVA: 0x177B5A4
	void PropagateCachedNextParentWithEventCallback(VisualElement nextParent, VisualElement stopParent) { }

	// RVA: 0x177B628
	int get_eventCallbackCategories() { }

	// RVA: 0x177B630
	void set_eventCallbackCategories(int value) { }

	// RVA: 0x177B740
	int get_eventCallbackParentCategories() { }

	// RVA: 0x177B794
	bool get_isEventCallbackParentCategoriesDirty() { }

	// RVA: 0x177B884
	void set_isEventCallbackParentCategoriesDirty(bool value) { }

	// RVA: 0x177B7A0
	void UpdateCallbackParentCategories() { }

	// RVA: 0x177B8A4
	bool HasEventCallbacks(EventCategory eventCategory) { }

	// RVA: 0x177B8B4
	bool HasParentEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x1776618
	bool HasEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x177B924
	bool HasParentEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x177B98C
	bool HasEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x177B9A4
	bool HasDefaultAction(EventCategory eventCategory) { }

	// RVA: 0x177B9B4
	IExperimentalFeatures get_experimental() { }

	// RVA: 0x177B9B8
	ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }

	// RVA: 0x177B9BC
	Hierarchy get_hierarchy() { }

	// RVA: 0x177B9C4
	void set_hierarchy(Hierarchy value) { }

	// RVA: 0x177B9D8
	bool get_isRootVisualContainer() { }

	// RVA: 0x177B9E0
	void set_isRootVisualContainer(bool value) { }

	// RVA: 0x177B9E8
	bool get_disableClipping() { }

	// RVA: 0x177B9F4
	void set_disableClipping(bool value) { }

	// RVA: 0x1772304
	bool ShouldClip() { }

	// RVA: 0x1770070
	VisualElement get_parent() { }

	// RVA: 0x177BA14
	BaseVisualElementPanel get_elementPanel() { }

	// RVA: 0x177BA1C
	void set_elementPanel(BaseVisualElementPanel value) { }

	// RVA: 0x17701FC
	IPanel get_panel() { }

	// RVA: 0x177BA2C
	VisualElement get_contentContainer() { }

	// RVA: 0x177BA30
	void set_visualTreeAssetSource(VisualTreeAsset value) { }

	// RVA: 0x177BA40
	void Add(VisualElement child) { }

	// RVA: 0x177BBC0
	void Insert(int index, VisualElement element) { }

	// RVA: 0x177C02C
	void Clear() { }

	// RVA: 0x177C4E0
	VisualElement ElementAt(int index) { }

	// RVA: 0x177C5AC
	VisualElement get_Item(int key) { }

	// RVA: 0x177C6F8
	int get_childCount() { }

	// RVA: 0x177C7E4
	int IndexOf(VisualElement element) { }

	// RVA: 0x177C908
	VisualElement ElementAtTreePath(System.Collections.Generic.List<System.Int32> childIndexes) { }

	// RVA: 0x177CBC0
	bool FindElementInTree(VisualElement element, System.Collections.Generic.List<System.Int32> outChildIndexes) { }

	// RVA: 0x177CD78
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualElement> Children() { }

	// RVA: 0x177CE60
	void BringToFront() { }

	// RVA: 0x177CFB4
	void SendToBack() { }

	// RVA: 0x177D0D0
	void PlaceBehind(VisualElement sibling) { }

	// RVA: 0x177D2D8
	void RemoveFromHierarchy() { }

	// RVA: 0x309AF8C
	T GetFirstOfType() { }

	// RVA: 0x309AF8C
	T GetFirstAncestorOfType() { }

	// RVA: 0x177D410
	VisualElement GetFirstAncestorWhere(System.Predicate<UnityEngine.UIElements.VisualElement> predicate) { }

	// RVA: 0x1773CB8
	bool Contains(VisualElement child) { }

	// RVA: 0x1775EC8
	void GatherAllChildren(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x177D474
	VisualElement FindCommonAncestor(VisualElement other) { }

	// RVA: 0x177D5A4
	VisualElement GetRoot() { }

	// RVA: 0x177D66C
	VisualElement GetRootVisualContainer() { }

	// RVA: 0x177D6A8
	VisualElement GetNextElementDepthFirst() { }

	// RVA: 0x177D7CC
	VisualElement GetPreviousElementDepthFirst() { }

	// RVA: 0x177D8DC
	VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0x1772908
	Vector3 get_positionWithLayout() { }

	// RVA: 0x177295C
	void GetPivotedMatrixWithLayout(out Matrix4x4 result) { }

	// RVA: 0x177DA7C
	bool get_hasDefaultRotationAndScale() { }

	// RVA: 0x177DB70
	float Min(float a, float b, float c, float d) { }

	// RVA: 0x177DB8C
	float Max(float a, float b, float c, float d) { }

	// RVA: 0x177DBA8
	void TransformAlignedRectToParentSpace(ref Rect rect) { }

	// RVA: 0x177DD3C
	Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect) { }

	// RVA: 0x177DFB4
	void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect) { }

	// RVA: 0x177DF60
	void OrderMinMaxRect(ref Rect rect) { }

	// RVA: 0x177E04C
	Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0x177E070
	Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector) { }

	// RVA: 0x1772BF0
	void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res) { }

	// RVA: 0x177E08C
	void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res) { }

	// RVA: 0x177E17C
	void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs) { }

	// RVA: 0x177E1D8
	IVisualElementScheduler get_schedule() { }

	// RVA: 0x177E1DC
	IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent) { }

	// RVA: 0x177E36C
	IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action updateEvent) { }

	// RVA: 0x177069C
	IStyle get_style() { }

	// RVA: 0x177E4D8
	ICustomStyle get_customStyle() { }

	// RVA: 0x177E5C4
	VisualElementStyleSheetSet get_styleSheets() { }

	// RVA: 0x177E5F4
	void AddStyleSheetPath(string sheetPath) { }

	// RVA: 0x176C9A0
	StyleFloat ResolveLengthValue(Length length, bool isRow) { }

	// RVA: 0x176CF7C
	Vector3 ResolveTranslate() { }

	// RVA: 0x176CC74
	Vector3 ResolveTransformOrigin() { }

	// RVA: 0x177D948
	Quaternion ResolveRotation() { }

	// RVA: 0x177D9DC
	Vector3 ResolveScale() { }

	// RVA: 0x177523C
	string get_tooltip() { }

	// RVA: 0x177E8BC
	void set_tooltip(string value) { }

	// RVA: 0x177EAB0
	TypeData GetOrCreateTypeData(Type t) { }

	// RVA: 0x1773F14
	TypeData get_typeData() { }

	// RVA: 0x177EC98
	void .cctor() { }

	// RVA: 0x177EF6C
	YogaSize <AssignMeasureFunction>b__432_0(YogaNode node, float f, YogaMeasureMode mode, float f1, YogaMeasureMode heightMode) { }

}

// Namespace: UnityEngine.UIElements
internal interface IStyleDataGroup<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	T Copy() { }

	// RVA: 0x2FE4574
	void CopyFrom(ref T other) { }

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

	// RVA: 0x17811B0
	InheritedData Copy() { }

	// RVA: 0x17811DC
	void CopyFrom(ref InheritedData other) { }

	// RVA: 0x1781208
	bool op_Equality(InheritedData lhs, InheritedData rhs) { }

	// RVA: 0x1781480
	bool Equals(InheritedData other) { }

	// RVA: 0x17814FC
	bool Equals(object obj) { }

	// RVA: 0x17815E4
	int GetHashCode() { }

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

	// RVA: 0x1781848
	LayoutData Copy() { }

	// RVA: 0x1781884
	void CopyFrom(ref LayoutData other) { }

	// RVA: 0x178188C
	bool op_Equality(LayoutData lhs, LayoutData rhs) { }

	// RVA: 0x1781C40
	bool Equals(LayoutData other) { }

	// RVA: 0x1781CDC
	bool Equals(object obj) { }

	// RVA: 0x1781DE4
	int GetHashCode() { }

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

	// RVA: 0x178215C
	RareData Copy() { }

	// RVA: 0x1782178
	void CopyFrom(ref RareData other) { }

	// RVA: 0x17821A4
	bool op_Equality(RareData lhs, RareData rhs) { }

	// RVA: 0x17822F0
	bool Equals(RareData other) { }

	// RVA: 0x1782428
	bool Equals(object obj) { }

	// RVA: 0x17825BC
	int GetHashCode() { }

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

	// RVA: 0x17826C8
	TransformData Copy() { }

	// RVA: 0x17826EC
	void CopyFrom(ref TransformData other) { }

	// RVA: 0x17826F4
	bool op_Equality(TransformData lhs, TransformData rhs) { }

	// RVA: 0x1782A84
	bool Equals(TransformData other) { }

	// RVA: 0x1782AE8
	bool Equals(object obj) { }

	// RVA: 0x1782BC0
	int GetHashCode() { }

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

	// RVA: 0x1782F30
	TransitionData Copy() { }

	// RVA: 0x17830CC
	void CopyFrom(ref TransitionData other) { }

	// RVA: 0x178336C
	bool op_Equality(TransitionData lhs, TransitionData rhs) { }

	// RVA: 0x17833C8
	bool Equals(TransitionData other) { }

	// RVA: 0x1783404
	bool Equals(object obj) { }

	// RVA: 0x17834B4
	int GetHashCode() { }

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

	// RVA: 0x1783554
	VisualData Copy() { }

	// RVA: 0x1783590
	void CopyFrom(ref VisualData other) { }

	// RVA: 0x17835BC
	bool op_Equality(VisualData lhs, VisualData rhs) { }

	// RVA: 0x17839A0
	bool Equals(VisualData other) { }

	// RVA: 0x1783A3C
	bool Equals(object obj) { }

	// RVA: 0x1783B44
	int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
internal class StyleValueCollection 
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StyleValue> m_Values; // 0x10

	// Methods

	// RVA: 0x1783E50
	StyleLength GetStyleLength(StylePropertyId id) { }

	// RVA: 0x1784158
	StyleFloat GetStyleFloat(StylePropertyId id) { }

	// RVA: 0x17841D4
	StyleInt GetStyleInt(StylePropertyId id) { }

	// RVA: 0x1783ECC
	bool TryGetStyleValue(StylePropertyId id, ref StyleValue value) { }

	// RVA: 0x1784268
	void SetStyleValue(StyleValue value) { }

	// RVA: 0x17843EC
	void .ctor() { }

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
public struct Length 
{
	// Fields
	internal const float k_MaxValue = 1258291200;
	private float m_Value; // 0x10
	private Unit m_Unit; // 0x14

	// Methods

	// RVA: 0x1784478
	Length Percent(float value) { }

	// RVA: 0x17844C0
	Length Auto() { }

	// RVA: 0x17844EC
	Length None() { }

	// RVA: 0x17844F4
	float get_value() { }

	// RVA: 0x17844FC
	void set_value(float value) { }

	// RVA: 0x178451C
	LengthUnit get_unit() { }

	// RVA: 0x1784524
	bool IsAuto() { }

	// RVA: 0x1784534
	bool IsNone() { }

	// RVA: 0x1784544
	void .ctor(float value) { }

	// RVA: 0x178449C
	void .ctor(float value, LengthUnit unit) { }

	// RVA: 0x17844C8
	void .ctor(float value, Unit unit) { }

	// RVA: 0x1784568
	Length op_Implicit(float value) { }

	// RVA: 0x1781C20
	bool op_Equality(Length lhs, Length rhs) { }

	// RVA: 0x1784588
	bool op_Inequality(Length lhs, Length rhs) { }

	// RVA: 0x17845A8
	bool Equals(Length other) { }

	// RVA: 0x17845C8
	bool Equals(object obj) { }

	// RVA: 0x1782128
	int GetHashCode() { }

	// RVA: 0x1784664
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct Rotate 
{
	// Fields
	private Angle m_Angle; // 0x10
	private Vector3 m_Axis; // 0x18
	private bool m_IsNone; // 0x24

	// Methods

	// RVA: 0x178484C
	void .ctor(Angle angle) { }

	// RVA: 0x17848B0
	Rotate Initial() { }

	// RVA: 0x178492C
	Rotate None() { }

	// RVA: 0x17849B4
	Angle get_angle() { }

	// RVA: 0x17849BC
	void set_angle(Angle value) { }

	// RVA: 0x17849C4
	Vector3 get_axis() { }

	// RVA: 0x17828D4
	bool op_Equality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x17849D0
	bool op_Inequality(Rotate lhs, Rotate rhs) { }

	// RVA: 0x1784A78
	bool Equals(Rotate other) { }

	// RVA: 0x1784B24
	bool Equals(object obj) { }

	// RVA: 0x1782CFC
	int GetHashCode() { }

	// RVA: 0x1784C44
	string ToString() { }

	// RVA: 0x1784CC4
	Quaternion ToQuaternion() { }

}

// Namespace: UnityEngine.UIElements
public struct Scale 
{
	// Fields
	private Vector3 m_Scale; // 0x10
	private bool m_IsNone; // 0x1C

	// Methods

	// RVA: 0x1784CF4
	void .ctor(Vector3 scale) { }

	// RVA: 0x1784E0C
	Scale Initial() { }

	// RVA: 0x1784E74
	Scale None() { }

	// RVA: 0x1784EE4
	Vector3 get_value() { }

	// RVA: 0x1782968
	bool op_Equality(Scale lhs, Scale rhs) { }

	// RVA: 0x1784EF0
	bool op_Inequality(Scale lhs, Scale rhs) { }

	// RVA: 0x1784F48
	bool Equals(Scale other) { }

	// RVA: 0x1784F98
	bool Equals(object obj) { }

	// RVA: 0x1782DD4
	int GetHashCode() { }

	// RVA: 0x1785064
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleBackgroundSize 
{
	// Fields
	private BackgroundSize m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x24

	// Methods

	// RVA: 0x1785074
	BackgroundSize get_value() { }

	// RVA: 0x17850C4
	StyleKeyword get_keyword() { }

	// RVA: 0x17850CC
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x17850D8
	void .ctor(BackgroundSize v, StyleKeyword keyword) { }

	// RVA: 0x17850F0
	bool op_Equality(StyleBackgroundSize lhs, StyleBackgroundSize rhs) { }

	// RVA: 0x1785158
	StyleBackgroundSize op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x1785164
	bool Equals(StyleBackgroundSize other) { }

	// RVA: 0x17851CC
	bool Equals(object obj) { }

	// RVA: 0x17852A4
	int GetHashCode() { }

	// RVA: 0x17852D8
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleColor 
{
	// Fields
	private Color m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x20

	// Methods

	// RVA: 0x1785364
	Color get_value() { }

	// RVA: 0x178538C
	StyleKeyword get_keyword() { }

	// RVA: 0x1785394
	void .ctor(Color v) { }

	// RVA: 0x17853A4
	void .ctor(Color v, StyleKeyword keyword) { }

	// RVA: 0x17853B4
	bool op_Equality(StyleColor lhs, StyleColor rhs) { }

	// RVA: 0x1785410
	StyleColor op_Implicit(Color v) { }

	// RVA: 0x1785420
	bool Equals(StyleColor other) { }

	// RVA: 0x178547C
	bool Equals(object obj) { }

	// RVA: 0x178554C
	int GetHashCode() { }

	// RVA: 0x17855F0
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleCursor 
{
	// Fields
	private Cursor m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x28

	// Methods

	// RVA: 0x178567C
	Cursor get_value() { }

	// RVA: 0x17856C8
	StyleKeyword get_keyword() { }

	// RVA: 0x17856D0
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x17856E4
	void .ctor(Cursor v, StyleKeyword keyword) { }

	// RVA: 0x1785700
	bool op_Equality(StyleCursor lhs, StyleCursor rhs) { }

	// RVA: 0x1785768
	StyleCursor op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x17857AC
	bool Equals(StyleCursor other) { }

	// RVA: 0x1785814
	bool Equals(object obj) { }

	// RVA: 0x17858F0
	int GetHashCode() { }

	// RVA: 0x1785924
	string ToString() { }

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

	// RVA: 0x2FE32D4
	int get_refCount() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void Acquire() { }

	// RVA: 0x2FE41A8
	void Release() { }

	// RVA: 0x2FE360C
	RefCounted Copy() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct StyleDataRef<T0> 
{
	// Fields
	private RefCounted m_Ref; // 0x0

	// Methods

	// RVA: 0x309AF8C
	UnityEngine.UIElements.StyleDataRef<T> Acquire() { }

	// RVA: 0x2FE41A8
	void Release() { }

	// RVA: 0x309AF8C
	void CopyFrom(UnityEngine.UIElements.StyleDataRef<T> other) { }

	// RVA: 0x2FE360C
	ref T Read() { }

	// RVA: 0x2FE360C
	ref T Write() { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.StyleDataRef<T> Create() { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

	// RVA: 0x309AF8C
	bool op_Equality(UnityEngine.UIElements.StyleDataRef<T> lhs, UnityEngine.UIElements.StyleDataRef<T> rhs) { }

	// RVA: 0x309AF8C
	bool Equals(UnityEngine.UIElements.StyleDataRef<T> other) { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x309AF8C
	bool ReferenceEquals(UnityEngine.UIElements.StyleDataRef<T> other) { }

}

// Namespace: UnityEngine.UIElements
public struct StyleEnum<T0> 
{
	// Fields
	private T m_Value; // 0x0
	private StyleKeyword m_Keyword; // 0x0

	// Methods

	// RVA: 0x309AF8C
	T get_value() { }

	// RVA: 0x2FE32D4
	StyleKeyword get_keyword() { }

	// RVA: 0x309AF8C
	void .ctor(T v) { }

	// RVA: 0x2FE42A4
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x309AF8C
	void .ctor(T v, StyleKeyword keyword) { }

	// RVA: 0x309AF8C
	bool op_Equality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs) { }

	// RVA: 0x309AF8C
	bool op_Inequality(UnityEngine.UIElements.StyleEnum<T> lhs, UnityEngine.UIElements.StyleEnum<T> rhs) { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.StyleEnum<T> op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.StyleEnum<T> op_Implicit(T v) { }

	// RVA: 0x309AF8C
	bool Equals(UnityEngine.UIElements.StyleEnum<T> other) { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

	// RVA: 0x2FE360C
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFloat 
{
	// Fields
	private float m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x14

	// Methods

	// RVA: 0x17859A8
	float get_value() { }

	// RVA: 0x17859C0
	StyleKeyword get_keyword() { }

	// RVA: 0x17859C8
	void .ctor(float v) { }

	// RVA: 0x17859D4
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x17841C0
	void .ctor(float v, StyleKeyword keyword) { }

	// RVA: 0x17859DC
	bool op_Equality(StyleFloat lhs, StyleFloat rhs) { }

	// RVA: 0x17841CC
	StyleFloat op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x17859FC
	StyleFloat op_Implicit(float v) { }

	// RVA: 0x1785A04
	bool Equals(StyleFloat other) { }

	// RVA: 0x1785A24
	bool Equals(object obj) { }

	// RVA: 0x1785AC0
	int GetHashCode() { }

	// RVA: 0x1785AF4
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFont 
{
	// Fields
	private Font m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x18

	// Methods

	// RVA: 0x1785B78
	Font get_value() { }

	// RVA: 0x1785B90
	StyleKeyword get_keyword() { }

	// RVA: 0x1785B98
	void .ctor(Font v) { }

	// RVA: 0x1785BA4
	void .ctor(Font v, StyleKeyword keyword) { }

	// RVA: 0x1785BB0
	bool op_Equality(StyleFont lhs, StyleFont rhs) { }

	// RVA: 0x1785C54
	StyleFont op_Implicit(Font v) { }

	// RVA: 0x1785C80
	bool Equals(StyleFont other) { }

	// RVA: 0x1785D24
	bool Equals(object obj) { }

	// RVA: 0x1785E0C
	int GetHashCode() { }

	// RVA: 0x1785EE8
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleFontDefinition 
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private FontDefinition m_Value; // 0x18

	// Methods

	// RVA: 0x1785F6C
	FontDefinition get_value() { }

	// RVA: 0x1785F88
	StyleKeyword get_keyword() { }

	// RVA: 0x1785F90
	void .ctor(FontDefinition f) { }

	// RVA: 0x1785FA4
	void .ctor(FontDefinition f, StyleKeyword keyword) { }

	// RVA: 0x1785FB8
	StyleFontDefinition op_Implicit(FontDefinition f) { }

	// RVA: 0x1786008
	bool Equals(StyleFontDefinition other) { }

	// RVA: 0x1786034
	bool Equals(object obj) { }

	// RVA: 0x17860D0
	int GetHashCode() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleInt 
{
	// Fields
	private int m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x14

	// Methods

	// RVA: 0x1786100
	int get_value() { }

	// RVA: 0x1786118
	StyleKeyword get_keyword() { }

	// RVA: 0x1786120
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x1784258
	void .ctor(int v, StyleKeyword keyword) { }

	// RVA: 0x1786128
	bool op_Equality(StyleInt lhs, StyleInt rhs) { }

	// RVA: 0x1784260
	StyleInt op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x1786134
	bool Equals(StyleInt other) { }

	// RVA: 0x1786144
	bool Equals(object obj) { }

	// RVA: 0x17861D4
	int GetHashCode() { }

	// RVA: 0x17861E8
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleLength 
{
	// Fields
	private Length m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x18

	// Methods

	// RVA: 0x178626C
	Length get_value() { }

	// RVA: 0x1786294
	StyleKeyword get_keyword() { }

	// RVA: 0x178629C
	void .ctor(float v) { }

	// RVA: 0x17862C4
	void .ctor(Length v) { }

	// RVA: 0x17862E4
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x178412C
	void .ctor(Length v, StyleKeyword keyword) { }

	// RVA: 0x17862F0
	bool op_Equality(StyleLength lhs, StyleLength rhs) { }

	// RVA: 0x178414C
	StyleLength op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x1786318
	StyleLength op_Implicit(float v) { }

	// RVA: 0x178633C
	StyleLength op_Implicit(Length v) { }

	// RVA: 0x1786350
	bool Equals(StyleLength other) { }

	// RVA: 0x1786384
	bool Equals(object obj) { }

	// RVA: 0x1786430
	int GetHashCode() { }

	// RVA: 0x178646C
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleRotate 
{
	// Fields
	private Rotate m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x28

	// Methods

	// RVA: 0x17864F8
	Rotate get_value() { }

	// RVA: 0x178664C
	StyleKeyword get_keyword() { }

	// RVA: 0x1786654
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x1786664
	void .ctor(Rotate v, StyleKeyword keyword) { }

	// RVA: 0x178667C
	bool op_Equality(StyleRotate lhs, StyleRotate rhs) { }

	// RVA: 0x1786738
	StyleRotate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x1786748
	bool Equals(StyleRotate other) { }

	// RVA: 0x1786800
	bool Equals(object obj) { }

	// RVA: 0x1786928
	int GetHashCode() { }

	// RVA: 0x1786958
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleScale 
{
	// Fields
	private Scale m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x20

	// Methods

	// RVA: 0x17869E4
	Scale get_value() { }

	// RVA: 0x1786B20
	StyleKeyword get_keyword() { }

	// RVA: 0x1786B28
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x1786B34
	void .ctor(Scale v, StyleKeyword keyword) { }

	// RVA: 0x1786B40
	bool op_Equality(StyleScale lhs, StyleScale rhs) { }

	// RVA: 0x1786BA8
	StyleScale op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x1786BB4
	bool Equals(StyleScale other) { }

	// RVA: 0x1786C1C
	bool Equals(object obj) { }

	// RVA: 0x1786CF8
	int GetHashCode() { }

	// RVA: 0x1786D60
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleTranslate 
{
	// Fields
	private Translate m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x28

	// Methods

	// RVA: 0x1786DEC
	Translate get_value() { }

	// RVA: 0x1786EE0
	StyleKeyword get_keyword() { }

	// RVA: 0x1786EE8
	void .ctor(Translate v) { }

	// RVA: 0x1786F24
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x1786F0C
	void .ctor(Translate v, StyleKeyword keyword) { }

	// RVA: 0x1786F34
	bool op_Equality(StyleTranslate lhs, StyleTranslate rhs) { }

	// RVA: 0x1786FA8
	StyleTranslate op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x1786FB8
	StyleTranslate op_Implicit(Translate v) { }

	// RVA: 0x1786FD0
	bool Equals(StyleTranslate other) { }

	// RVA: 0x178704C
	bool Equals(object obj) { }

	// RVA: 0x178713C
	int GetHashCode() { }

	// RVA: 0x17871C8
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleTextShadow 
{
	// Fields
	private StyleKeyword m_Keyword; // 0x10
	private TextShadow m_Value; // 0x14

	// Methods

	// RVA: 0x1787254
	TextShadow get_value() { }

	// RVA: 0x17872AC
	StyleKeyword get_keyword() { }

	// RVA: 0x17872B4
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x17872CC
	void .ctor(TextShadow v, StyleKeyword keyword) { }

	// RVA: 0x17872EC
	bool op_Equality(StyleTextShadow lhs, StyleTextShadow rhs) { }

	// RVA: 0x178735C
	StyleTextShadow op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x1787374
	bool Equals(StyleTextShadow other) { }

	// RVA: 0x17873DC
	bool Equals(object obj) { }

	// RVA: 0x17874B8
	int GetHashCode() { }

	// RVA: 0x1787504
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct StyleTransformOrigin 
{
	// Fields
	private TransformOrigin m_Value; // 0x10
	private StyleKeyword m_Keyword; // 0x24

	// Methods

	// RVA: 0x1787588
	TransformOrigin get_value() { }

	// RVA: 0x1787638
	StyleKeyword get_keyword() { }

	// RVA: 0x1787640
	void .ctor(StyleKeyword keyword) { }

	// RVA: 0x178764C
	void .ctor(TransformOrigin v, StyleKeyword keyword) { }

	// RVA: 0x1787664
	bool op_Equality(StyleTransformOrigin lhs, StyleTransformOrigin rhs) { }

	// RVA: 0x17876C8
	StyleTransformOrigin op_Implicit(StyleKeyword keyword) { }

	// RVA: 0x17876D4
	bool Equals(StyleTransformOrigin other) { }

	// RVA: 0x1787740
	bool Equals(object obj) { }

	// RVA: 0x1787820
	int GetHashCode() { }

	// RVA: 0x17878AC
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
internal interface IStyleValue<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	T get_value() { }

	// RVA: 0x2FE32D4
	StyleKeyword get_keyword() { }

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

	// RVA: 0x2FE7084
	string DebugString(UnityEngine.UIElements.IStyleValue<T> styleValue) { }

	// RVA: 0x1787938
	YogaValue ToYogaValue(Length length) { }

	// RVA: 0x1787A98
	Length ToLength(StyleKeyword keyword) { }

	// RVA: 0x1787BAC
	Rotate ToRotate(StyleKeyword keyword) { }

	// RVA: 0x1787D20
	Scale ToScale(StyleKeyword keyword) { }

	// RVA: 0x1787E7C
	Translate ToTranslate(StyleKeyword keyword) { }

	// RVA: 0x1787FC8
	Length ToLength(StyleLength styleLength) { }

	// RVA: 0x2FEAB7C
	void CopyFrom(System.Collections.Generic.List<T> list, System.Collections.Generic.List<T> other) { }

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

	// RVA: 0x1787FF8
	float get_value() { }

	// RVA: 0x1788000
	TimeUnit get_unit() { }

	// RVA: 0x1788008
	void .ctor(float value) { }

	// RVA: 0x1788014
	void .ctor(float value, TimeUnit unit) { }

	// RVA: 0x1788020
	TimeValue op_Implicit(float value) { }

	// RVA: 0x1788028
	bool op_Equality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x1788048
	bool op_Inequality(TimeValue lhs, TimeValue rhs) { }

	// RVA: 0x1788068
	bool Equals(TimeValue other) { }

	// RVA: 0x1788088
	bool Equals(object obj) { }

	// RVA: 0x1788124
	int GetHashCode() { }

	// RVA: 0x1788158
	string ToString() { }

}

// Namespace: UnityEngine.UIElements
public struct TransformOrigin 
{
	// Fields
	private Length m_X; // 0x10
	private Length m_Y; // 0x18
	private float m_Z; // 0x20

	// Methods

	// RVA: 0x1788278
	void .ctor(Length x, Length y, float z) { }

	// RVA: 0x1787620
	TransformOrigin Initial() { }

	// RVA: 0x1788284
	Length get_x() { }

	// RVA: 0x178828C
	void set_x(Length value) { }

	// RVA: 0x1788294
	Length get_y() { }

	// RVA: 0x178829C
	void set_y(Length value) { }

	// RVA: 0x17882A4
	float get_z() { }

	// RVA: 0x17829C0
	bool op_Equality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x17882AC
	bool op_Inequality(TransformOrigin lhs, TransformOrigin rhs) { }

	// RVA: 0x1788300
	bool Equals(TransformOrigin other) { }

	// RVA: 0x1788354
	bool Equals(object obj) { }

	// RVA: 0x1782E30
	int GetHashCode() { }

	// RVA: 0x178841C
	string ToString() { }

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

	// RVA: 0x17885C4
	void .ctor(Length x, Length y, float z) { }

	// RVA: 0x1786EC4
	Translate None() { }

	// RVA: 0x17885D4
	Length get_x() { }

	// RVA: 0x17885DC
	void set_x(Length value) { }

	// RVA: 0x17885E4
	Length get_y() { }

	// RVA: 0x17885EC
	void set_y(Length value) { }

	// RVA: 0x17885F4
	float get_z() { }

	// RVA: 0x1782A1C
	bool op_Equality(Translate lhs, Translate rhs) { }

	// RVA: 0x17885FC
	bool op_Inequality(Translate lhs, Translate rhs) { }

	// RVA: 0x1788664
	bool Equals(Translate other) { }

	// RVA: 0x17886D0
	bool Equals(object obj) { }

	// RVA: 0x1782EB0
	int GetHashCode() { }

	// RVA: 0x17887A8
	string ToString() { }

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

	// RVA: 0x2FE4574
	void DrawText(TextElement te) { }

	// RVA: -1
	void DrawRectangle(RectangleParams rectParams) { }

	// RVA: -1
	void DrawImmediate(Action callback, bool cullingEnabled) { }

}

// Namespace: UnityEngine.UIElements
internal interface IStylePropertyAnimations 
{
	// Methods

	// RVA: -1
	bool Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x2FE42A4
	void UpdateAnimation(StylePropertyId id) { }

	// RVA: 0x2FE4574
	void GetAllAnimations(System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: 0x2FE42A4
	void CancelAnimation(StylePropertyId id) { }

	// RVA: 0x2FE41A8
	void CancelAllAnimations() { }

	// RVA: 0x2FE32D4
	int get_runningAnimationCount() { }

	// RVA: 0x2FE42A4
	void set_runningAnimationCount(int value) { }

	// RVA: 0x2FE32D4
	int get_completedAnimationCount() { }

	// RVA: 0x2FE42A4
	void set_completedAnimationCount(int value) { }

}

// Namespace: UnityEngine.UIElements
internal interface IStylePropertyAnimationSystem 
{
	// Methods

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: -1
	bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x2FE41A8
	void CancelAllAnimations() { }

	// RVA: 0x2FE4574
	void CancelAllAnimations(VisualElement owner) { }

	// RVA: 0x2FE45DC
	void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x2FE45DC
	void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x2FE47D4
	void GetAllAnimations(VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds) { }

	// RVA: 0x2FE41A8
	void Update() { }

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

	// RVA: 0x2FE32D4
	int get_capacity() { }

	// RVA: 0x2FE42A4
	void set_capacity(int value) { }

	// RVA: 0x2FE41A8
	void LocalInit() { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.StylePropertyAnimationSystem.AnimationDataSet<TTimingData,TStyleData> Create() { }

	// RVA: -1
	bool IndexOf(VisualElement ve, StylePropertyId prop, out int index) { }

	// RVA: 0x309AF8C
	void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) { }

	// RVA: 0x2FE42A4
	void Remove(int cancelledIndex) { }

	// RVA: 0x309AF8C
	void Replace(int index, TTimingData timingData, TStyleData styleData) { }

	// RVA: 0x2FE4574
	void RemoveAll(VisualElement ve) { }

	// RVA: 0x2FE41A8
	void RemoveAll() { }

	// RVA: 0x2FE47D4
	void GetActivePropertiesForElement(VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outProperties) { }

}

// Namespace: 
private class EqualityComparer 
{
	// Methods

	// RVA: 0x178A394
	bool Equals(ElementPropertyPair x, ElementPropertyPair y) { }

	// RVA: 0x178A3A4
	int GetHashCode(ElementPropertyPair obj) { }

	// RVA: 0x178A38C
	void .ctor() { }

}

// Namespace: 
private struct ElementPropertyPair 
{
	// Fields
	public static readonly System.Collections.Generic.IEqualityComparer<UnityEngine.UIElements.StylePropertyAnimationSystem.ElementPropertyPair> Comparer; // 0x0
	public readonly VisualElement element; // 0x10
	public readonly StylePropertyId property; // 0x18

	// Methods

	// RVA: 0x178A2D8
	void .ctor(VisualElement element, StylePropertyId property) { }

	// RVA: 0x178A304
	void .cctor() { }

}

// Namespace: 
private abstract class Values 
{
	// Methods

	// RVA: 0x2FE41A8
	void CancelAllAnimations() { }

	// RVA: 0x2FE4574
	void CancelAllAnimations(VisualElement ve) { }

	// RVA: 0x2FE45DC
	void CancelAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: 0x2FE45DC
	void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: 0x2FE47D4
	void GetAllAnimations(VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: -1
	void Update(Int64 currentTimeMs) { }

	// RVA: 0x2FE41A8
	void UpdateValues() { }

	// RVA: 0x2FE41A8
	void UpdateComputedStyle() { }

	// RVA: 0x2FE42A4
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178A3E8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.StylePropertyAnimationSystem.Values.TransitionEventsFrameState.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> <.cctor>b__11_0() { }

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

	// RVA: 0x2FE704C
	System.Collections.Generic.Queue<UnityEngine.UIElements.EventBase> GetPooledQueue() { }

	// RVA: 0x2FE41A8
	void RegisterChange() { }

	// RVA: 0x2FE41A8
	void UnregisterChange() { }

	// RVA: 0x2FE3054
	bool StateChanged() { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

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

	// RVA: 0x2FE8AB8
	void .cctor() { }

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

	// RVA: 0x2FE3054
	bool get_isEmpty() { }

	// RVA: 0x2FE360C
	System.Func<T,T,System.Boolean> get_SameFunc() { }

	// RVA: -1
	bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref T a, ref T b) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void SwapFrameStates() { }

	// RVA: 0x309AF8C
	void QueueEvent(EventBase evt, ElementPropertyPair epp) { }

	// RVA: 0x309AF8C
	void ClearEventQueue(ElementPropertyPair epp) { }

	// RVA: 0x2FE45DC
	void QueueTransitionRunEvent(VisualElement ve, int runningIndex) { }

	// RVA: 0x2FE45DC
	void QueueTransitionStartEvent(VisualElement ve, int runningIndex) { }

	// RVA: 0x2FE45DC
	void QueueTransitionEndEvent(VisualElement ve, int runningIndex) { }

	// RVA: 0x309AF8C
	void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, Int64 panelElapsedMs) { }

	// RVA: 0x309AF8C
	void SendTransitionCancelEvent(VisualElement ve, int runningIndex, Int64 panelElapsedMs) { }

	// RVA: 0x2FE41A8
	void CancelAllAnimations() { }

	// RVA: 0x2FE4574
	void CancelAllAnimations(VisualElement ve) { }

	// RVA: 0x2FE45DC
	void CancelAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: 0x2FE45DC
	void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

	// RVA: 0x2FE47D4
	void GetAllAnimations(VisualElement ve, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> outPropertyIds) { }

	// RVA: -1
	float ComputeReversingShorteningFactor(int oldIndex) { }

	// RVA: 0x309AF8C
	int ComputeReversingDuration(int newTransitionDurationMs, float newReversingShorteningFactor) { }

	// RVA: 0x309AF8C
	int ComputeReversingDelay(int delayMs, float newReversingShorteningFactor) { }

	// RVA: 0x309AF8C
	bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve, Int64 currentTimeMs) { }

	// RVA: 0x2FE42A4
	void ForceComputedStyleEndValue(int runningIndex) { }

	// RVA: -1
	void Update(Int64 currentTimeMs) { }

	// RVA: 0x2FE41A8
	void ProcessEventQueue() { }

	// RVA: -1
	void UpdateProgress(Int64 currentTimeMs) { }

}

// Namespace: 
private class ValuesFloat 
{
	// Fields
	private readonly System.Func<System.Single,System.Single,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178A3F0
	System.Func<System.Single,System.Single,System.Boolean> get_SameFunc() { }

	// RVA: 0x178A3F8
	bool IsSame(float a, float b) { }

	// RVA: 0x178A490
	float Lerp(float a, float b, float t) { }

	// RVA: 0x178A4A0
	void UpdateValues() { }

	// RVA: 0x178A524
	void UpdateComputedStyle() { }

	// RVA: 0x178A5F4
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178A6A8
	void .ctor() { }

}

// Namespace: 
private class ValuesInt 
{
	// Fields
	private readonly System.Func<System.Int32,System.Int32,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178A758
	System.Func<System.Int32,System.Int32,System.Boolean> get_SameFunc() { }

	// RVA: 0x178A760
	bool IsSame(int a, int b) { }

	// RVA: 0x178A76C
	int Lerp(int a, int b, float t) { }

	// RVA: 0x178A898
	void UpdateValues() { }

	// RVA: 0x178A934
	void UpdateComputedStyle() { }

	// RVA: 0x178AA04
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178AAB8
	void .ctor() { }

}

// Namespace: 
private class ValuesLength 
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178AB68
	System.Func<UnityEngine.UIElements.Length,UnityEngine.UIElements.Length,System.Boolean> get_SameFunc() { }

	// RVA: 0x178AB70
	bool IsSame(Length a, Length b) { }

	// RVA: 0x178AC20
	bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b) { }

	// RVA: 0x178AC4C
	Length Lerp(Length a, Length b, float t) { }

	// RVA: 0x178AC88
	void UpdateValues() { }

	// RVA: 0x178AD3C
	void UpdateComputedStyle() { }

	// RVA: 0x178AE0C
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178AEC0
	void .ctor() { }

}

// Namespace: 
private class ValuesColor 
{
	// Fields
	private readonly System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178AF70
	System.Func<UnityEngine.Color,UnityEngine.Color,System.Boolean> get_SameFunc() { }

	// RVA: 0x178AF78
	bool IsSame(Color c, Color d) { }

	// RVA: 0x178B0CC
	Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x178B104
	void UpdateValues() { }

	// RVA: 0x178B188
	void UpdateComputedStyle() { }

	// RVA: 0x178B260
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178B318
	void .ctor() { }

}

// Namespace: 
private abstract class ValuesDiscrete<T0> 
{
	// Fields
	private readonly System.Func<T,T,System.Boolean> <SameFunc>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE360C
	System.Func<T,T,System.Boolean> get_SameFunc() { }

	// RVA: 0x309AF8C
	bool IsSame(T a, T b) { }

	// RVA: 0x309AF8C
	T Lerp(T a, T b, float t) { }

	// RVA: 0x2FE41A8
	void UpdateValues() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private class ValuesBackground 
{
	// Methods

	// RVA: 0x178B3C8
	void UpdateComputedStyle() { }

	// RVA: 0x178B4AC
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178B574
	void .ctor() { }

}

// Namespace: 
private class ValuesFontDefinition 
{
	// Methods

	// RVA: 0x178B5C8
	void UpdateComputedStyle() { }

	// RVA: 0x178B69C
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178B750
	void .ctor() { }

}

// Namespace: 
private class ValuesFont 
{
	// Methods

	// RVA: 0x178B7A4
	void UpdateComputedStyle() { }

	// RVA: 0x178B874
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178B928
	void .ctor() { }

}

// Namespace: 
private class ValuesTextShadow 
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178B97C
	System.Func<UnityEngine.UIElements.TextShadow,UnityEngine.UIElements.TextShadow,System.Boolean> get_SameFunc() { }

	// RVA: 0x178B984
	bool IsSame(TextShadow a, TextShadow b) { }

	// RVA: 0x178B9CC
	TextShadow Lerp(TextShadow a, TextShadow b, float t) { }

	// RVA: 0x178BA34
	void UpdateValues() { }

	// RVA: 0x178BB30
	void UpdateComputedStyle() { }

	// RVA: 0x178BC24
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178BD00
	void .ctor() { }

}

// Namespace: 
private class ValuesScale 
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178BDB0
	System.Func<UnityEngine.UIElements.Scale,UnityEngine.UIElements.Scale,System.Boolean> get_SameFunc() { }

	// RVA: 0x178BDB8
	bool IsSame(Scale a, Scale b) { }

	// RVA: 0x178BE10
	void UpdateComputedStyle() { }

	// RVA: 0x178BEE4
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178BF98
	Scale Lerp(Scale a, Scale b, float t) { }

	// RVA: 0x178C008
	void UpdateValues() { }

	// RVA: 0x178C0E8
	void .ctor() { }

}

// Namespace: 
private class ValuesRotate 
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178C198
	System.Func<UnityEngine.UIElements.Rotate,UnityEngine.UIElements.Rotate,System.Boolean> get_SameFunc() { }

	// RVA: 0x178C1A0
	bool IsSame(Rotate a, Rotate b) { }

	// RVA: 0x178C24C
	void UpdateComputedStyle() { }

	// RVA: 0x178C338
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178C40C
	Rotate Lerp(Rotate a, Rotate b, float t) { }

	// RVA: 0x178C4CC
	void UpdateValues() { }

	// RVA: 0x178C60C
	void .ctor() { }

}

// Namespace: 
private class ValuesTranslate 
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178C6BC
	System.Func<UnityEngine.UIElements.Translate,UnityEngine.UIElements.Translate,System.Boolean> get_SameFunc() { }

	// RVA: 0x178C6C4
	bool IsSame(Translate a, Translate b) { }

	// RVA: 0x178C730
	bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b) { }

	// RVA: 0x178C754
	void UpdateComputedStyle() { }

	// RVA: 0x178C840
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178C914
	Translate Lerp(Translate a, Translate b, float t) { }

	// RVA: 0x178C994
	void UpdateValues() { }

	// RVA: 0x178CA8C
	void .ctor() { }

}

// Namespace: 
private class ValuesTransformOrigin 
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178CB3C
	System.Func<UnityEngine.UIElements.TransformOrigin,UnityEngine.UIElements.TransformOrigin,System.Boolean> get_SameFunc() { }

	// RVA: 0x178CB44
	bool IsSame(TransformOrigin a, TransformOrigin b) { }

	// RVA: 0x178CB98
	bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b) { }

	// RVA: 0x178CBBC
	void UpdateComputedStyle() { }

	// RVA: 0x178CCA8
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178CD7C
	TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) { }

	// RVA: 0x178CDF8
	void UpdateValues() { }

	// RVA: 0x178CEE4
	void .ctor() { }

}

// Namespace: 
private class ValuesBackgroundPosition 
{
	// Methods

	// RVA: 0x178CF94
	void UpdateComputedStyle() { }

	// RVA: 0x178D080
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178D13C
	void .ctor() { }

}

// Namespace: 
private class ValuesBackgroundRepeat 
{
	// Methods

	// RVA: 0x178D190
	void UpdateComputedStyle() { }

	// RVA: 0x178D260
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178D314
	void .ctor() { }

}

// Namespace: 
private class ValuesBackgroundSize 
{
	// Fields
	private readonly System.Func<UnityEngine.UIElements.BackgroundSize,UnityEngine.UIElements.BackgroundSize,System.Boolean> <SameFunc>k__BackingField; // 0x88

	// Methods

	// RVA: 0x178D368
	System.Func<UnityEngine.UIElements.BackgroundSize,UnityEngine.UIElements.BackgroundSize,System.Boolean> get_SameFunc() { }

	// RVA: 0x178D370
	bool IsSame(BackgroundSize a, BackgroundSize b) { }

	// RVA: 0x178D3B8
	bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref BackgroundSize a, ref BackgroundSize b) { }

	// RVA: 0x178D3DC
	void UpdateComputedStyle() { }

	// RVA: 0x178D4C8
	void UpdateComputedStyle(int i) { }

	// RVA: 0x178D59C
	BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t) { }

	// RVA: 0x178D68C
	void UpdateValues() { }

	// RVA: 0x178D844
	void .ctor() { }

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

	// RVA: 0x1788950
	void .ctor() { }

	// RVA: 0x309AF8C
	T GetOrCreate(ref T values) { }

	// RVA: 0x309AF8C
	bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve, UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values) { }

	// RVA: 0x1788A70
	bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1788B60
	bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1788C48
	bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1788D2C
	bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1788E54
	bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1788F54
	bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x178904C
	bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x178912C
	bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x178924C
	bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1789344
	bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1789464
	bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1789584
	bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x17896A4
	bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x17897A4
	bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x1789888
	bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, System.Func<System.Single,System.Single> easingCurve) { }

	// RVA: 0x17899A8
	void CancelAllAnimations() { }

	// RVA: 0x1789B6C
	void CancelAllAnimations(VisualElement owner) { }

	// RVA: 0x1789EA0
	void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x1789F40
	void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	// RVA: 0x1789FE0
	void GetAllAnimations(VisualElement owner, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyId> propertyIds) { }

	// RVA: 0x2FE4574
	void UpdateTracking(UnityEngine.UIElements.StylePropertyAnimationSystem.Values<T> values) { }

	// RVA: 0x178A1C4
	Int64 CurrentTimeMs() { }

	// RVA: 0x178A1CC
	void Update() { }

}

// Namespace: UnityEngine.UIElements
public struct StylePropertyName 
{
	// Fields
	private readonly StylePropertyId <id>k__BackingField; // 0x10
	private readonly string <name>k__BackingField; // 0x18

	// Methods

	// RVA: 0x178D8F4
	StylePropertyId get_id() { }

	// RVA: 0x178D8FC
	string get_name() { }

	// RVA: 0x178D904
	StylePropertyId StylePropertyIdFromString(string name) { }

	// RVA: 0x178D9CC
	void .ctor(StylePropertyId stylePropertyId) { }

	// RVA: 0x178DA9C
	void .ctor(string name) { }

	// RVA: 0x178DB98
	bool op_Equality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x178DBA4
	bool op_Inequality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x178DBB0
	StylePropertyName op_Implicit(string name) { }

	// RVA: 0x178DBDC
	int GetHashCode() { }

	// RVA: 0x178DBE4
	bool Equals(object other) { }

	// RVA: 0x178DC74
	bool Equals(StylePropertyName other) { }

	// RVA: 0x178DC84
	string ToString() { }

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

	// RVA: 0x178E284
	void .ctor(PseudoStates state, bool negate) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.StyleComplexSelector.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.StyleSelector,System.String> <>9__24_0; // 0x8
	public static System.Predicate<UnityEngine.UIElements.StyleSelectorPart> <>9__27_0; // 0x10

	// Methods

	// RVA: 0x178EA64
	void .cctor() { }

	// RVA: 0x178EAD0
	void .ctor() { }

	// RVA: 0x178EAD8
	string <ToString>b__24_0(StyleSelector x) { }

	// RVA: 0x178EB00
	bool <CalculateHashes>b__27_0(StyleSelectorPart p) { }

}

// Namespace: UnityEngine.UIElements
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

	// RVA: 0x178DC8C
	int get_specificity() { }

	// RVA: 0x178DC94
	StyleRule get_rule() { }

	// RVA: 0x178DC9C
	void set_rule(StyleRule value) { }

	// RVA: 0x178DCA4
	bool get_isSimple() { }

	// RVA: 0x178DCAC
	StyleSelector[] get_selectors() { }

	// RVA: 0x178DCB4
	void set_selectors(StyleSelector[] value) { }

	// RVA: 0x178DCFC
	void OnBeforeSerialize() { }

	// RVA: 0x178DD00
	void OnAfterDeserialize() { }

	// RVA: 0x178DD2C
	void CachePseudoStateMasks() { }

	// RVA: 0x178E2A8
	string ToString() { }

	// RVA: 0x178E424
	int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	// RVA: 0x178E478
	void CalculateHashes() { }

	// RVA: 0x178E9C8
	void .ctor() { }

	// RVA: 0x178E9D0
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal class StyleProperty 
{
	// Fields
	private string m_Name; // 0x10
	private int m_Line; // 0x18
	private StyleValueHandle[] m_Values; // 0x20
	internal bool isCustomProperty; // 0x28
	internal bool requireVariableResolve; // 0x29

	// Methods

	// RVA: 0x178EB18
	string get_name() { }

	// RVA: 0x178EB20
	StyleValueHandle[] get_values() { }

	// RVA: 0x178EB28
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class StyleRule 
{
	// Fields
	private StyleProperty[] m_Properties; // 0x10
	internal int line; // 0x18
	internal int customPropertiesCount; // 0x1C

	// Methods

	// RVA: 0x178EB30
	StyleProperty[] get_properties() { }

	// RVA: 0x178EB38
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.StyleSelector.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.StyleSelectorPart,System.String> <>9__10_0; // 0x8

	// Methods

	// RVA: 0x178ECBC
	void .cctor() { }

	// RVA: 0x178ED28
	void .ctor() { }

	// RVA: 0x178ED30
	string <ToString>b__10_0(StyleSelectorPart p) { }

}

// Namespace: UnityEngine.UIElements
internal class StyleSelector 
{
	// Fields
	private StyleSelectorPart[] m_Parts; // 0x10
	private StyleSelectorRelationship m_PreviousRelationship; // 0x18
	internal int pseudoStateMask; // 0x1C
	internal int negatedPseudoStateMask; // 0x20

	// Methods

	// RVA: 0x178E290
	StyleSelectorPart[] get_parts() { }

	// RVA: 0x178EB40
	void set_parts(StyleSelectorPart[] value) { }

	// RVA: 0x178EB48
	StyleSelectorRelationship get_previousRelationship() { }

	// RVA: 0x178EB50
	void set_previousRelationship(StyleSelectorRelationship value) { }

	// RVA: 0x178EB58
	string ToString() { }

	// RVA: 0x178ECAC
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct StyleSelectorPart 
{
	// Fields
	private string m_Value; // 0x10
	private StyleSelectorType m_Type; // 0x18
	internal object tempData; // 0x20

	// Methods

	// RVA: 0x178E2A0
	string get_value() { }

	// RVA: 0x178E298
	StyleSelectorType get_type() { }

	// RVA: 0x178EE6C
	void set_type(StyleSelectorType value) { }

	// RVA: 0x178ED38
	string ToString() { }

	// RVA: 0x178EE74
	StyleSelectorPart CreateClass(string className) { }

	// RVA: 0x178EEC4
	StyleSelectorPart CreateId(string Id) { }

	// RVA: 0x178EF14
	StyleSelectorPart CreatePredicate(object predicate) { }

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
internal struct ImportStruct 
{
	// Fields
	public StyleSheet styleSheet; // 0x10
	public string[] mediaQueries; // 0x18
}

// Namespace: UnityEngine.UIElements
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

	// RVA: 0x178EF68
	bool get_importedWithErrors() { }

	// RVA: 0x178EF70
	void set_importedWithErrors(bool value) { }

	// RVA: 0x178EF78
	bool get_importedWithWarnings() { }

	// RVA: 0x178EF80
	void set_importedWithWarnings(bool value) { }

	// RVA: 0x178EF88
	StyleRule[] get_rules() { }

	// RVA: 0x178EF90
	void set_rules(StyleRule[] value) { }

	// RVA: 0x178F608
	StyleComplexSelector[] get_complexSelectors() { }

	// RVA: 0x178F610
	void set_complexSelectors(StyleComplexSelector[] value) { }

	// RVA: 0x178F638
	System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_flattenedRecursiveImports() { }

	// RVA: 0x178F640
	int get_contentHash() { }

	// RVA: 0x178F648
	void set_contentHash(int value) { }

	// RVA: 0x178F650
	bool get_isDefaultStyleSheet() { }

	// RVA: 0x178F658
	void set_isDefaultStyleSheet(bool value) { }

	// RVA: 0x309AF8C
	bool TryCheckAccess(T[] list, StyleValueType type, StyleValueHandle handle, out T value) { }

	// RVA: 0x309AF8C
	T CheckAccess(T[] list, StyleValueType type, StyleValueHandle handle) { }

	// RVA: 0x178F82C
	void OnEnable() { }

	// RVA: 0x178F830
	void FlattenImportedStyleSheetsRecursive() { }

	// RVA: 0x178F8BC
	void FlattenImportedStyleSheetsRecursive(StyleSheet sheet) { }

	// RVA: 0x178EFB8
	void SetupReferences() { }

	// RVA: 0x178FAB0
	StyleValueKeyword ReadKeyword(StyleValueHandle handle) { }

	// RVA: 0x178FAB8
	float ReadFloat(StyleValueHandle handle) { }

	// RVA: 0x178FB88
	bool TryReadFloat(StyleValueHandle handle, out float value) { }

	// RVA: 0x178FC64
	Dimension ReadDimension(StyleValueHandle handle) { }

	// RVA: 0x178FD44
	bool TryReadDimension(StyleValueHandle handle, out Dimension value) { }

	// RVA: 0x178FE2C
	Color ReadColor(StyleValueHandle handle) { }

	// RVA: 0x178FEA8
	bool TryReadColor(StyleValueHandle handle, out Color value) { }

	// RVA: 0x178FF1C
	string ReadString(StyleValueHandle handle) { }

	// RVA: 0x178FF94
	bool TryReadString(StyleValueHandle handle, out string value) { }

	// RVA: 0x1790008
	string ReadEnum(StyleValueHandle handle) { }

	// RVA: 0x1790080
	bool TryReadEnum(StyleValueHandle handle, out string value) { }

	// RVA: 0x17900F4
	string ReadVariable(StyleValueHandle handle) { }

	// RVA: 0x179016C
	bool TryReadVariable(StyleValueHandle handle, out string value) { }

	// RVA: 0x17901E0
	string ReadResourcePath(StyleValueHandle handle) { }

	// RVA: 0x1790258
	bool TryReadResourcePath(StyleValueHandle handle, out string value) { }

	// RVA: 0x17902CC
	object ReadAssetReference(StyleValueHandle handle) { }

	// RVA: 0x1790344
	string ReadMissingAssetReferenceUrl(StyleValueHandle handle) { }

	// RVA: 0x17903BC
	bool TryReadAssetReference(StyleValueHandle handle, out object value) { }

	// RVA: 0x1790430
	StyleValueFunction ReadFunction(StyleValueHandle handle) { }

	// RVA: 0x1790438
	string ReadFunctionName(StyleValueHandle handle) { }

	// RVA: 0x17906F4
	ScalableImage ReadScalableImage(StyleValueHandle handle) { }

	// RVA: 0x178F9DC
	bool CustomStartsWith(string originalString, string pattern) { }

	// RVA: 0x179076C
	void .ctor() { }

	// RVA: 0x1790774
	void .cctor() { }

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

	// RVA: 0x17905F8
	string ToUssString(StyleValueFunction svf) { }

}

// Namespace: UnityEngine.UIElements
internal struct StyleValueHandle 
{
	// Fields
	private StyleValueType m_ValueType; // 0x10
	internal int valueIndex; // 0x14

	// Methods

	// RVA: 0x178FB80
	StyleValueType get_valueType() { }

	// RVA: 0x17907EC
	void set_valueType(StyleValueType value) { }

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

	// RVA: 0x17907F4
	string ToUssString(StyleValueKeyword svk) { }

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

	// RVA: 0x179091C
	void .ctor(string name, StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x179096C
	int GetHashCode() { }

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

	// RVA: 0x17909E4
	void Add(StyleVariable sv) { }

	// RVA: 0x1790CBC
	void AddInitialRange(StyleVariableContext other) { }

	// RVA: 0x1790DD8
	void Clear() { }

	// RVA: 0x1790F5C
	void .ctor() { }

	// RVA: 0x1791064
	void .ctor(StyleVariableContext other) { }

	// RVA: 0x179119C
	bool TryFindVariable(string name, out StyleVariable v) { }

	// RVA: 0x1791298
	int GetVariableHash() { }

	// RVA: 0x17912A0
	void .cctor() { }

	// RVA: 0x1790CB0
	int <Add>g__ComputeOrderSensitiveHash|7_0(int index, ref UnityEngine.UIElements.StyleVariableContext.<>c__DisplayClass7_0& ) { }

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

	// RVA: 0x1791308
	StyleSheet get_currentSheet() { }

	// RVA: 0x1791310
	StyleValueHandle[] get_currentHandles() { }

	// RVA: 0x1791318
	System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> get_resolvedValues() { }

	// RVA: 0x1791320
	StyleVariableContext get_variableContext() { }

	// RVA: 0x1791328
	void set_variableContext(StyleVariableContext value) { }

	// RVA: 0x1791330
	void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x1791428
	void PushContext(StyleSheet sheet, StyleValueHandle[] handles) { }

	// RVA: 0x17914E4
	void PopContext() { }

	// RVA: 0x1791584
	void AddValue(StyleValueHandle handle) { }

	// RVA: 0x1791614
	bool ResolveVarFunction(ref int index) { }

	// RVA: 0x1791880
	Result ResolveVarFunction(ref int index, int argc, string varName) { }

	// RVA: 0x1791ED4
	bool ValidateResolvedValues() { }

	// RVA: 0x1791A10
	Result ResolveVariable(string variableName) { }

	// RVA: 0x1791C74
	Result ResolveFallback(ref int index) { }

	// RVA: 0x17916EC
	void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName) { }

	// RVA: 0x1792064
	void .ctor() { }

	// RVA: 0x17921D8
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public class ThemeStyleSheet 
{
	// Methods

	// RVA: 0x1792260
	void OnEnable() { }

	// RVA: 0x1792288
	void .ctor() { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x17923D4
	string get_uxmlName() { }

	// RVA: 0x1792418
	string get_uxmlQualifiedName() { }

	// RVA: 0x1792498
	void .ctor() { }

}

// Namespace: 
public class UxmlTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Template; // 0x78

	// Methods

	// RVA: 0x17924EC
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1792964
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class TemplateContainer 
{
	// Fields
	private string <templateId>k__BackingField; // 0x3D8
	private VisualElement m_ContentContainer; // 0x3E0
	private VisualTreeAsset m_TemplateSource; // 0x3E8

	// Methods

	// RVA: 0x1792310
	string get_templateId() { }

	// RVA: 0x1792318
	void set_templateId(string value) { }

	// RVA: 0x1792328
	void set_templateSource(VisualTreeAsset value) { }

	// RVA: 0x1792338
	void .ctor() { }

	// RVA: 0x1792378
	void .ctor(string templateId) { }

	// RVA: 0x17923BC
	VisualElement get_contentContainer() { }

	// RVA: 0x17923C4
	void SetContentContainer(VisualElement content) { }

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

	// RVA: 0x1792A10
	PanelTextSettings get_defaultPanelTextSettings() { }

	// RVA: 0x1792BE0
	void UpdateLocalizationFontAsset() { }

	// RVA: 0x1793274
	FontAsset GetCachedFontAsset(Font font) { }

	// RVA: 0x179327C
	void .ctor() { }

	// RVA: 0x1793284
	void .cctor() { }

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

	// RVA: 0x17932F0
	bool get_touchScreenTextFieldChanged() { }

	// RVA: 0x1793490
	void .ctor(TextElement textElement) { }

	// RVA: 0x1793580
	void InitTextEditorEventHandler() { }

	// RVA: 0x1793654
	void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x17937E8
	void OnFocusInEvent(FocusInEvent _) { }

	// RVA: 0x1793AE4
	void OnFocusOutEvent(FocusOutEvent _) { }

	// RVA: 0x1793B9C
	void <OnFocusInEvent>b__10_0() { }

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

	// RVA: 0x1793BEC
	bool get_isClicking() { }

	// RVA: 0x1793BF4
	void set_isClicking(bool value) { }

	// RVA: 0x1793C08
	void .ctor(TextElement textElement) { }

	// RVA: 0x1793ED0
	int get_cursorIndex() { }

	// RVA: 0x1793EE8
	void set_cursorIndex(int value) { }

	// RVA: 0x1793F08
	int get_selectIndex() { }

	// RVA: 0x1793F20
	void set_selectIndex(int value) { }

	// RVA: 0x1793F40
	void OnRevealCursor() { }

	// RVA: 0x1793F64
	void OnSelectIndexChange() { }

	// RVA: 0x17940F4
	void OnCursorIndexChange() { }

	// RVA: 0x1794264
	bool RevealCursor() { }

	// RVA: 0x17940D4
	bool HasSelection() { }

	// RVA: 0x1794284
	bool HasFocus() { }

	// RVA: 0x17942A4
	void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x179451C
	void OnFocusEvent(FocusEvent evt) { }

	// RVA: 0x17947D8
	void OnBlurEvent(BlurEvent evt) { }

	// RVA: 0x1794D04
	void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x1794898
	void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x1794D7C
	void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x1794FD0
	void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x179509C
	void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	// RVA: 0x1795230
	void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	// RVA: 0x1795370
	bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current) { }

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

	// RVA: 0x1795394
	void .ctor(TextElement te) { }

	// RVA: 0x179541C
	Vector2 get_MeasuredSizes() { }

	// RVA: 0x1795424
	void set_MeasuredSizes(Vector2 value) { }

	// RVA: 0x179542C
	Vector2 get_RoundedSizes() { }

	// RVA: 0x1795434
	void set_RoundedSizes(Vector2 value) { }

	// RVA: 0x179543C
	float ComputeTextWidth(string textToMeasure, bool wordWrap, float width, float height) { }

	// RVA: 0x1795890
	float ComputeTextHeight(string textToMeasure, float width, float height) { }

	// RVA: 0x1795954
	TextInfo Update() { }

	// RVA: 0x17963E4
	void ATagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x1796578
	void ATagOnPointerOver(PointerOverEvent _) { }

	// RVA: 0x1796580
	void ATagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x1796834
	void ATagOnPointerOut(PointerOutEvent _) { }

	// RVA: 0x179683C
	void LinkTagOnPointerDown(PointerDownEvent pde) { }

	// RVA: 0x1796AD8
	void LinkTagOnPointerUp(PointerUpEvent pue) { }

	// RVA: 0x1796D74
	void LinkTagOnPointerMove(PointerMoveEvent pme) { }

	// RVA: 0x17972C8
	void LinkTagOnPointerOut(PointerOutEvent poe) { }

	// RVA: 0x1795FD0
	void HandleLinkTag() { }

	// RVA: 0x1795A60
	void HandleATag() { }

	// RVA: 0x17974A0
	TextOverflowMode GetTextOverflowMode() { }

	// RVA: 0x1795510
	void ConvertUssToTextGenerationSettings(TextGenerationSettings tgs) { }

	// RVA: 0x1797564
	bool TextLibraryCanElide() { }

	// RVA: 0x1797598
	float GetTextEffectPadding(FontAsset fontAsset) { }

	// RVA: 0x1797744
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class TextUtilities 
{
	// Methods

	// RVA: 0x1656614
	Vector2 MeasureVisualElementTextSize(TextElement te, string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	// RVA: 0x1656874
	FontAsset GetFontAsset(VisualElement ve) { }

	// RVA: 0x1656788
	bool IsFontAssigned(VisualElement ve) { }

	// RVA: 0x1656A48
	PanelTextSettings GetTextSettingsFrom(VisualElement ve) { }

	// RVA: 0x1656B24
	float ConvertPixelUnitsToTextCoreRelativeUnits(VisualElement ve, FontAsset fontAsset) { }

	// RVA: 0x1656BE0
	TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve) { }

}

// Namespace: 
public class UxmlFactory 
{
	// Methods

	// RVA: 0x165BCD8
	void .ctor() { }

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

	// RVA: 0x165BD2C
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x165BF08
	void .ctor() { }

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

	// RVA: 0x1656FEC
	void .ctor() { }

	// RVA: 0x1657240
	UITKTextHandle get_uitkTextHandle() { }

	// RVA: 0x1657248
	void set_uitkTextHandle(UITKTextHandle value) { }

	// RVA: 0x1657258
	void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x16573B4
	string get_text() { }

	// RVA: 0x1657468
	void set_text(string value) { }

	// RVA: 0x1657514
	bool get_enableRichText() { }

	// RVA: 0x165751C
	void set_enableRichText(bool value) { }

	// RVA: 0x1657538
	bool get_parseEscapeSequences() { }

	// RVA: 0x1657540
	void set_parseEscapeSequences(bool value) { }

	// RVA: 0x165755C
	bool get_displayTooltipWhenElided() { }

	// RVA: 0x1657564
	void set_displayTooltipWhenElided(bool value) { }

	// RVA: 0x16575A8
	bool get_isElided() { }

	// RVA: 0x16575B0
	void set_isElided(bool value) { }

	// RVA: 0x16575B8
	void OnGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x16589A0
	string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition) { }

	// RVA: 0x16579C0
	void UpdateTooltip() { }

	// RVA: 0x165725C
	void UpdateVisibleText() { }

	// RVA: 0x1657960
	bool ShouldElide() { }

	// RVA: 0x1658EB0
	bool get_hasFocus() { }

	// RVA: 0x1658EAC
	Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode) { }

	// RVA: 0x1658EF8
	Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	// RVA: 0x1659178
	string UnityEngine.UIElements.INotifyValueChanged<System.String>.get_value() { }

	// RVA: 0x16591E4
	void UnityEngine.UIElements.INotifyValueChanged<System.String>.set_value(string value) { }

	// RVA: 0x16594AC
	void UnityEngine.UIElements.INotifyValueChanged<System.String>.SetValueWithoutNotify(string newValue) { }

	// RVA: 0x16585AC
	ITextEdition get_edition() { }

	// RVA: 0x16596A0
	bool UnityEngine.UIElements.ITextEdition.get_multiline() { }

	// RVA: 0x16596A8
	void UnityEngine.UIElements.ITextEdition.set_multiline(bool value) { }

	// RVA: 0x1659790
	TouchScreenKeyboardType UnityEngine.UIElements.ITextEdition.get_keyboardType() { }

	// RVA: 0x1659798
	void UnityEngine.UIElements.ITextEdition.set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x16597A0
	bool UnityEngine.UIElements.ITextEdition.get_hideMobileInput() { }

	// RVA: 0x165986C
	void UnityEngine.UIElements.ITextEdition.set_hideMobileInput(bool value) { }

	// RVA: 0x1659934
	bool UnityEngine.UIElements.ITextEdition.get_isReadOnly() { }

	// RVA: 0x1659964
	void UnityEngine.UIElements.ITextEdition.set_isReadOnly(bool value) { }

	// RVA: 0x1659A14
	void ProcessMenuCommand(string command) { }

	// RVA: 0x1659B84
	void Cut(DropdownMenuAction a) { }

	// RVA: 0x1659BD8
	void Copy(DropdownMenuAction a) { }

	// RVA: 0x1659C2C
	void Paste(DropdownMenuAction a) { }

	// RVA: 0x1659C80
	void BuildContextualMenu(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x165A010
	Status CutActionStatus(DropdownMenuAction a) { }

	// RVA: 0x165A164
	Status CopyActionStatus(DropdownMenuAction a) { }

	// RVA: 0x165A2BC
	Status PasteActionStatus(DropdownMenuAction a) { }

	// RVA: 0x165A31C
	void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x165A7F4
	int UnityEngine.UIElements.ITextEdition.get_maxLength() { }

	// RVA: 0x165A7FC
	void UnityEngine.UIElements.ITextEdition.set_maxLength(int value) { }

	// RVA: 0x165A8DC
	bool UnityEngine.UIElements.ITextEdition.get_isDelayed() { }

	// RVA: 0x165A8E4
	void UnityEngine.UIElements.ITextEdition.set_isDelayed(bool value) { }

	// RVA: 0x165A8EC
	void UnityEngine.UIElements.ITextEdition.SaveValueAndText() { }

	// RVA: 0x165A924
	void UnityEngine.UIElements.ITextEdition.RestoreValueAndText() { }

	// RVA: 0x165A938
	System.Func<System.Char,System.Boolean> UnityEngine.UIElements.ITextEdition.get_AcceptCharacter() { }

	// RVA: 0x165A940
	void UnityEngine.UIElements.ITextEdition.set_AcceptCharacter(System.Func<System.Char,System.Boolean> value) { }

	// RVA: 0x165A950
	System.Action<System.Boolean> UnityEngine.UIElements.ITextEdition.get_UpdateScrollOffset() { }

	// RVA: 0x165A958
	void UnityEngine.UIElements.ITextEdition.set_UpdateScrollOffset(System.Action<System.Boolean> value) { }

	// RVA: 0x165A968
	Action UnityEngine.UIElements.ITextEdition.get_UpdateValueFromText() { }

	// RVA: 0x165A970
	void UnityEngine.UIElements.ITextEdition.set_UpdateValueFromText(Action value) { }

	// RVA: 0x165A980
	Action UnityEngine.UIElements.ITextEdition.get_UpdateTextFromValue() { }

	// RVA: 0x165A988
	void UnityEngine.UIElements.ITextEdition.set_UpdateTextFromValue(Action value) { }

	// RVA: 0x165A998
	Action UnityEngine.UIElements.ITextEdition.get_MoveFocusToCompositeRoot() { }

	// RVA: 0x165A9A0
	void UnityEngine.UIElements.ITextEdition.set_MoveFocusToCompositeRoot(Action value) { }

	// RVA: 0x165A9B0
	void UnityEngine.UIElements.ITextEdition.UpdateText(string value) { }

	// RVA: 0x165AC48
	string UnityEngine.UIElements.ITextEdition.CullString(string s) { }

	// RVA: 0x165AD44
	void UnityEngine.UIElements.ITextEdition.set_maskChar(Char value) { }

	// RVA: 0x165AE2C
	Char get_effectiveMaskChar() { }

	// RVA: 0x165AEEC
	bool UnityEngine.UIElements.ITextEdition.get_isPassword() { }

	// RVA: 0x165AEF4
	void UnityEngine.UIElements.ITextEdition.set_isPassword(bool value) { }

	// RVA: 0x165AF14
	bool UnityEngine.UIElements.ITextEdition.get_autoCorrection() { }

	// RVA: 0x165AF1C
	void UnityEngine.UIElements.ITextEdition.set_autoCorrection(bool value) { }

	// RVA: 0x1658F50
	string get_renderedText() { }

	// RVA: 0x1659634
	void set_renderedText(string value) { }

	// RVA: 0x165AF24
	string get_originalText() { }

	// RVA: 0x1657A40
	ITextSelection get_selection() { }

	// RVA: 0x165AF2C
	bool UnityEngine.UIElements.ITextSelection.get_isSelectable() { }

	// RVA: 0x165AF4C
	void UnityEngine.UIElements.ITextSelection.set_isSelectable(bool value) { }

	// RVA: 0x165AF64
	int UnityEngine.UIElements.ITextSelection.get_cursorIndex() { }

	// RVA: 0x165B09C
	void UnityEngine.UIElements.ITextSelection.set_cursorIndex(int value) { }

	// RVA: 0x165B1D8
	int UnityEngine.UIElements.ITextSelection.get_selectIndex() { }

	// RVA: 0x165B310
	void UnityEngine.UIElements.ITextSelection.set_selectIndex(int value) { }

	// RVA: 0x165B44C
	void UnityEngine.UIElements.ITextSelection.SelectAll() { }

	// RVA: 0x165B584
	void UnityEngine.UIElements.ITextSelection.SelectNone() { }

	// RVA: 0x165B6BC
	bool UnityEngine.UIElements.ITextSelection.HasSelection() { }

	// RVA: 0x165B7F0
	bool UnityEngine.UIElements.ITextSelection.get_doubleClickSelectsWord() { }

	// RVA: 0x165B7F8
	bool UnityEngine.UIElements.ITextSelection.get_tripleClickSelectsLine() { }

	// RVA: 0x165B800
	bool UnityEngine.UIElements.ITextSelection.get_selectAllOnFocus() { }

	// RVA: 0x165B808
	void UnityEngine.UIElements.ITextSelection.set_selectAllOnFocus(bool value) { }

	// RVA: 0x165B810
	bool UnityEngine.UIElements.ITextSelection.get_selectAllOnMouseUp() { }

	// RVA: 0x165B818
	void UnityEngine.UIElements.ITextSelection.set_selectAllOnMouseUp(bool value) { }

	// RVA: 0x165B820
	Vector2 UnityEngine.UIElements.ITextSelection.get_cursorPosition() { }

	// RVA: 0x165B91C
	float UnityEngine.UIElements.ITextSelection.get_lineHeightAtCursorPosition() { }

	// RVA: 0x165B9E8
	Color UnityEngine.UIElements.ITextSelection.get_selectionColor() { }

	// RVA: 0x165B9FC
	void UnityEngine.UIElements.ITextSelection.set_selectionColor(Color value) { }

	// RVA: 0x165BA68
	Color UnityEngine.UIElements.ITextSelection.get_cursorColor() { }

	// RVA: 0x165BA7C
	void UnityEngine.UIElements.ITextSelection.set_cursorColor(Color value) { }

	// RVA: 0x165BAE8
	float UnityEngine.UIElements.ITextSelection.get_cursorWidth() { }

	// RVA: 0x1657A44
	TextSelectingManipulator get_selectingManipulator() { }

	// RVA: 0x1657AE4
	void DrawHighlighting(MeshGenerationContext mgc) { }

	// RVA: 0x16585B0
	void DrawCaret(MeshGenerationContext mgc) { }

	// RVA: 0x165BAF0
	int GetLastCharacterAt(int lineIndex) { }

	// RVA: 0x165BC38
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface ITextEdition 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_multiline() { }

	// RVA: 0x2FE4234
	void set_multiline(bool value) { }

	// RVA: 0x2FE3054
	bool get_isReadOnly() { }

	// RVA: 0x2FE4234
	void set_isReadOnly(bool value) { }

	// RVA: 0x2FE32D4
	int get_maxLength() { }

	// RVA: 0x2FE42A4
	void set_maxLength(int value) { }

	// RVA: 0x2FE3054
	bool get_isDelayed() { }

	// RVA: 0x2FE4234
	void set_isDelayed(bool value) { }

	// RVA: 0x2FE41A8
	void SaveValueAndText() { }

	// RVA: 0x2FE41A8
	void RestoreValueAndText() { }

	// RVA: 0x2FE360C
	System.Func<System.Char,System.Boolean> get_AcceptCharacter() { }

	// RVA: 0x2FE4574
	void set_AcceptCharacter(System.Func<System.Char,System.Boolean> value) { }

	// RVA: 0x2FE360C
	System.Action<System.Boolean> get_UpdateScrollOffset() { }

	// RVA: 0x2FE4574
	void set_UpdateScrollOffset(System.Action<System.Boolean> value) { }

	// RVA: 0x2FE360C
	Action get_UpdateValueFromText() { }

	// RVA: 0x2FE4574
	void set_UpdateValueFromText(Action value) { }

	// RVA: 0x2FE360C
	Action get_UpdateTextFromValue() { }

	// RVA: 0x2FE4574
	void set_UpdateTextFromValue(Action value) { }

	// RVA: 0x2FE360C
	Action get_MoveFocusToCompositeRoot() { }

	// RVA: 0x2FE4574
	void set_MoveFocusToCompositeRoot(Action value) { }

	// RVA: 0x2FE4574
	void UpdateText(string value) { }

	// RVA: 0x2FE36BC
	string CullString(string s) { }

	// RVA: -1
	void set_maskChar(Char value) { }

	// RVA: 0x2FE3054
	bool get_isPassword() { }

	// RVA: 0x2FE4234
	void set_isPassword(bool value) { }

	// RVA: 0x165C29C
	bool get_autoCorrection() { }

	// RVA: 0x165C368
	void set_autoCorrection(bool value) { }

	// RVA: 0x165C444
	bool get_hideMobileInput() { }

	// RVA: 0x165C510
	void set_hideMobileInput(bool value) { }

	// RVA: 0x165C5EC
	TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x165C6B8
	void set_keyboardType(TouchScreenKeyboardType value) { }

}

// Namespace: UnityEngine.UIElements
public interface ITextSelection 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_isSelectable() { }

	// RVA: 0x2FE4234
	void set_isSelectable(bool value) { }

	// RVA: -1
	Color get_cursorColor() { }

	// RVA: -1
	void set_cursorColor(Color value) { }

	// RVA: 0x2FE32D4
	int get_cursorIndex() { }

	// RVA: 0x2FE42A4
	void set_cursorIndex(int value) { }

	// RVA: 0x2FE3054
	bool get_doubleClickSelectsWord() { }

	// RVA: 0x2FE32D4
	int get_selectIndex() { }

	// RVA: 0x2FE42A4
	void set_selectIndex(int value) { }

	// RVA: -1
	Color get_selectionColor() { }

	// RVA: -1
	void set_selectionColor(Color value) { }

	// RVA: 0x2FE3054
	bool get_tripleClickSelectsLine() { }

	// RVA: 0x2FE3054
	bool HasSelection() { }

	// RVA: 0x2FE41A8
	void SelectAll() { }

	// RVA: 0x2FE41A8
	void SelectNone() { }

	// RVA: 0x2FE3054
	bool get_selectAllOnFocus() { }

	// RVA: 0x2FE4234
	void set_selectAllOnFocus(bool value) { }

	// RVA: 0x2FE3054
	bool get_selectAllOnMouseUp() { }

	// RVA: 0x2FE4234
	void set_selectAllOnMouseUp(bool value) { }

	// RVA: -1
	Vector2 get_cursorPosition() { }

	// RVA: -1
	float get_lineHeightAtCursorPosition() { }

	// RVA: -1
	float get_cursorWidth() { }

}

// Namespace: UnityEngine.UIElements
public struct TextShadow 
{
	// Fields
	public Vector2 offset; // 0x10
	public float blurRadius; // 0x18
	public Color color; // 0x1C

	// Methods

	// RVA: 0x165C794
	bool Equals(object obj) { }

	// RVA: 0x165C88C
	bool Equals(TextShadow other) { }

	// RVA: 0x165C910
	int GetHashCode() { }

	// RVA: 0x165C9EC
	bool op_Equality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x165CA70
	bool op_Inequality(TextShadow style1, TextShadow style2) { }

	// RVA: 0x165CAF0
	string ToString() { }

	// RVA: 0x165CBE4
	TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class UIElementsBridge 
{
	// Methods

	// RVA: 0x2FE42A4
	void SetWantsMouseJumping(int value) { }

	// RVA: 0x165CC34
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class RuntimeUIElementsBridge 
{
	// Methods

	// RVA: 0x165CC3C
	void SetWantsMouseJumping(int value) { }

	// RVA: 0x165CC40
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIElementsPackageUtility 
{
	// Fields
	private static bool <IsUIEPackageLoaded>k__BackingField; // 0x0
	private static string <EditorResourcesBasePath>k__BackingField; // 0x8

	// Methods

	// RVA: 0x165CC48
	bool get_IsUIEPackageLoaded() { }

	// RVA: 0x165CCC4
	void set_IsUIEPackageLoaded(bool value) { }

	// RVA: 0x165CD50
	string get_EditorResourcesBasePath() { }

	// RVA: 0x165CDCC
	void set_EditorResourcesBasePath(string value) { }

	// RVA: 0x165CE38
	void .cctor() { }

	// RVA: 0x165CE3C
	void Refresh() { }

}

// Namespace: 
public sealed class CreateRuntimePanelDelegate 
{
	// Methods

	// RVA: 0x1660600
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1660720
	internal BaseRuntimePanel Invoke(ScriptableObject ownerObject) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIElementsRuntimeUtility.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.UIElements.Panel> <>9__48_0; // 0x8

	// Methods

	// RVA: 0x1660734
	void .cctor() { }

	// RVA: 0x16607A0
	void .ctor() { }

	// RVA: 0x16607A8
	void <.cctor>b__9_0() { }

	// RVA: 0x16607AC
	void <.cctor>b__9_1(int displayIndex, int sortOrder) { }

	// RVA: 0x1660838
	int <SortPanels>b__48_0(Panel a, Panel b) { }

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

	// RVA: 0x165CF84
	void add_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value) { }

	// RVA: 0x165D094
	void remove_onCreatePanel(System.Action<UnityEngine.UIElements.BaseRuntimePanel> value) { }

	// RVA: 0x165D1A4
	void .cctor() { }

	// RVA: 0x165D570
	EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x165D9A8
	BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate) { }

	// RVA: 0x165E0E0
	void DisposeRuntimePanel(ScriptableObject ownerObject) { }

	// RVA: 0x165DEFC
	void RegisterCachedPanelInternal(int instanceID, IPanel panel) { }

	// RVA: 0x165DC90
	void RemoveCachedPanelInternal(int instanceID) { }

	// RVA: 0x165E894
	void RepaintOffscreenPanels() { }

	// RVA: 0x165EC28
	void RepaintOverlayPanel(BaseRuntimePanel panel) { }

	// RVA: 0x165EDA8
	void BeginRenderOverlays(int displayIndex) { }

	// RVA: 0x165EE24
	void RenderOverlaysBeforePriority(int displayIndex, float maxPriority) { }

	// RVA: 0x165F024
	void EndRenderOverlays(int displayIndex) { }

	// RVA: 0x165F0A0
	object get_activeEventSystem() { }

	// RVA: 0x165F11C
	void set_activeEventSystem(object value) { }

	// RVA: 0x165F188
	bool get_useDefaultEventSystem() { }

	// RVA: 0x165F29C
	void RegisterEventSystem(object eventSystem) { }

	// RVA: 0x165F570
	void UnregisterEventSystem(object eventSystem) { }

	// RVA: 0x165F710
	DefaultEventSystem get_defaultEventSystem() { }

	// RVA: 0x165F7E8
	void UpdateRuntimePanels() { }

	// RVA: 0x165FDC4
	void MarkPotentiallyEmpty(PanelSettings settings) { }

	// RVA: 0x165FAE8
	void RemoveUnusedPanels() { }

	// RVA: 0x165E2FC
	void RegisterPlayerloopCallback() { }

	// RVA: 0x165E83C
	void UnregisterPlayerloopCallback() { }

	// RVA: 0x165FEC0
	void SetPanelOrderingDirty() { }

	// RVA: 0x165EB54
	System.Collections.Generic.List<UnityEngine.UIElements.Panel> GetSortedPlayerPanels() { }

	// RVA: 0x165FF44
	void SortPanels() { }

	// RVA: 0x166026C
	Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out System.Nullable<System.Int32>& targetDisplay) { }

	// RVA: 0x1660394
	Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out System.Nullable<System.Int32>& targetDisplay) { }

	// RVA: 0x1660508
	Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay) { }

	// RVA: 0x16605F8
	Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta) { }

}

// Namespace: UnityEngine.UIElements
internal interface IUIElementsUtility 
{
	// Methods

	// RVA: 0x2FE3054
	bool TakeCapture() { }

	// RVA: 0x2FE3054
	bool ReleaseCapture() { }

	// RVA: -1
	bool ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	// RVA: 0x2FE3054
	bool CleanupRoots() { }

	// RVA: 0x2FE3174
	bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x2FE3054
	bool MakeCurrentIMGUIContainerDirty() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIEventRegistration.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1661F40
	void .cctor() { }

	// RVA: 0x1661FAC
	void .ctor() { }

	// RVA: 0x1661FB4
	void <.cctor>b__1_0() { }

	// RVA: 0x166201C
	void <.cctor>b__1_1() { }

	// RVA: 0x1662084
	bool <.cctor>b__1_2(int i, IntPtr ptr) { }

	// RVA: 0x1662110
	void <.cctor>b__1_3() { }

	// RVA: 0x1662178
	bool <.cctor>b__1_4(Exception exception) { }

	// RVA: 0x16621F8
	void <.cctor>b__1_5() { }

}

// Namespace: UnityEngine.UIElements
internal static class UIEventRegistration 
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.IUIElementsUtility> s_Utilities; // 0x0

	// Methods

	// RVA: 0x16609CC
	void .cctor() { }

	// RVA: 0x1660EF8
	void RegisterUIElementSystem(IUIElementsUtility utility) { }

	// RVA: 0x1660FA0
	void TakeCapture() { }

	// RVA: 0x166121C
	void ReleaseCapture() { }

	// RVA: 0x166149C
	bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x1661778
	bool ProcessEvent(int instanceID, IntPtr nativeEventPtr) { }

	// RVA: 0x1661A40
	void CleanupRoots() { }

	// RVA: 0x1661CC0
	void MakeCurrentIMGUIContainerDirty() { }

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

	// RVA: 0x1662260
	void .ctor() { }

	// RVA: 0x1662368
	bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }

	// RVA: 0x1662460
	bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }

	// RVA: 0x1662554
	bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }

	// RVA: 0x166255C
	bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	// RVA: 0x1662CB8
	bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }

	// RVA: 0x1662D50
	bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x165E240
	void RegisterCachedPanel(int instanceID, Panel panel) { }

	// RVA: 0x165E3A0
	void RemoveCachedPanel(int instanceID) { }

	// RVA: 0x165DBD4
	bool TryGetPanel(int instanceID, out Panel panel) { }

	// RVA: 0x1662E80
	void BeginContainerGUI(LayoutCache cache, Event evt, IMGUIContainer container) { }

	// RVA: 0x166310C
	void EndContainerGUI(Event evt, Rect layoutSize) { }

	// RVA: 0x1663384
	EventBase CreateEvent(Event systemEvent) { }

	// RVA: 0x165D604
	EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	// RVA: 0x166267C
	bool DoDispatch(BaseVisualElementPanel panel) { }

	// RVA: 0x165E454
	void GetAllPanels(System.Collections.Generic.List<UnityEngine.UIElements.Panel> panels, ContextType contextType) { }

	// RVA: 0x1663418
	Enumerator GetPanelsIterator() { }

	// RVA: 0x16634F0
	float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) { }

	// RVA: 0x16635E4
	string ParseMenuName(string menuName) { }

	// RVA: 0x1663738
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
internal struct RuleMatcher 
{
	// Fields
	public StyleSheet sheet; // 0x10
	public StyleComplexSelector complexSelector; // 0x18

	// Methods

	// RVA: 0x16639F8
	string ToString() { }

}

// Namespace: 
internal interface IVisualPredicateWrapper 
{
	// Methods

	// RVA: 0x2FE3174
	bool Predicate(object e) { }

}

// Namespace: 
internal class IsOfType<T0> 
{
	// Fields
	public static UnityEngine.UIElements.UQuery.IsOfType<T> s_Instance; // 0x0

	// Methods

	// RVA: 0x2FE3174
	bool Predicate(object e) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UQuery.UQueryMatcher.<>c <>9; // 0x0
	public static System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x1663C8C
	void .cctor() { }

	// RVA: 0x1663CF8
	void .ctor() { }

	// RVA: 0x1663D00
	void <TraverseRecursive>b__5_0(VisualElement e, MatchResultInfo i) { }

}

// Namespace: 
internal abstract class UQueryMatcher 
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> m_Matchers; // 0x10

	// Methods

	// RVA: 0x1663A1C
	void .ctor() { }

	// RVA: 0x1663A24
	void Traverse(VisualElement element) { }

	// RVA: 0x1663A2C
	bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x1663A34
	void NoProcessResult(VisualElement e, MatchResultInfo i) { }

	// RVA: 0x1663A38
	void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x1663C50
	void Run(VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

}

// Namespace: 
internal abstract class SingleQueryMatcher 
{
	// Fields
	private VisualElement <match>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1663D04
	VisualElement get_match() { }

	// RVA: 0x1663D0C
	void set_match(VisualElement value) { }

	// RVA: 0x1663D14
	void Run(VisualElement root, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

	// RVA: 0x1663D80
	bool IsInUse() { }

	// RVA: 0x2FE360C
	SingleQueryMatcher CreateNew() { }

	// RVA: 0x1663D90
	void .ctor() { }

}

// Namespace: 
internal class FirstQueryMatcher 
{
	// Fields
	public static readonly FirstQueryMatcher Instance; // 0x0

	// Methods

	// RVA: 0x1663D98
	bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x1663DCC
	SingleQueryMatcher CreateNew() { }

	// RVA: 0x1663E24
	void .ctor() { }

	// RVA: 0x1663E2C
	void .cctor() { }

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

	// RVA: 0x2FE360C
	System.Collections.Generic.List<TElement> get_matches() { }

	// RVA: 0x2FE4574
	void set_matches(System.Collections.Generic.List<TElement> value) { }

	// RVA: -1
	bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private class ActionQueryMatcher 
{
	// Fields
	private System.Action<T> <callBack>k__BackingField; // 0x0

	// Methods

	// RVA: 0x2FE360C
	System.Action<T> get_callBack() { }

	// RVA: -1
	bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> iterationList; // 0x0
	private int currentIndex; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(UnityEngine.UIElements.UQueryState<T> queryState) { }

	// RVA: 0x309AF8C
	T get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

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

	// RVA: 0x2FE47D4
	void .ctor(VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.RuleMatcher> matchers) { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.UQueryState<T> RebuildOn(VisualElement element) { }

	// RVA: 0x309AF8C
	T Single(SingleQueryMatcher matcher) { }

	// RVA: 0x309AF8C
	T First() { }

	// RVA: 0x309AF8C
	Enumerator GetEnumerator() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	bool Equals(UnityEngine.UIElements.UQueryState<T> other) { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

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

	// RVA: 0x2FE360C
	System.Collections.Generic.List<UnityEngine.UIElements.StyleSelector> get_styleSelectors() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.List<UnityEngine.UIElements.StyleSelectorPart> get_parts() { }

	// RVA: 0x2FE4574
	void .ctor(VisualElement visualElement) { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.UQueryBuilder<T> Class(string classname) { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.UQueryBuilder<T> Name(string id) { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.UQueryBuilder<T> SingleBaseType() { }

	// RVA: 0x2FE4574
	void AddClass(string c) { }

	// RVA: 0x2FE4574
	void AddName(string id) { }

	// RVA: 0x2FE41A8
	void AddPseudoStatesRuleIfNecessasy() { }

	// RVA: 0x2FE41A8
	void FinishSelector() { }

	// RVA: 0x2FE3054
	bool CurrentSelectorEmpty() { }

	// RVA: 0x2FE41A8
	void FinishCurrentSelector() { }

	// RVA: 0x309AF8C
	UnityEngine.UIElements.UQueryState<T> Build() { }

	// RVA: 0x309AF8C
	bool Equals(UnityEngine.UIElements.UQueryBuilder<T> other) { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

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

	// RVA: 0x309AF8C
	T Q(VisualElement e, string name, string className) { }

	// RVA: 0x1663E98
	VisualElement Q(VisualElement e, string name, string className) { }

	// RVA: 0x1664338
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IUxmlAttributes 
{
	// Methods

	// RVA: -1
	bool TryGetAttributeValue(string attributeName, out string value) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlRootElementFactory 
{
	// Methods

	// RVA: 0x1664898
	string get_uxmlName() { }

	// RVA: 0x16648DC
	string get_uxmlQualifiedName() { }

	// RVA: 0x166495C
	VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1664964
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlRootElementTraits 
{
	// Fields
	protected UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Class; // 0x20

	// Methods

	// RVA: 0x16649B8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlStyleFactory 
{
	// Methods

	// RVA: 0x1664AD8
	string get_uxmlName() { }

	// RVA: 0x1664B1C
	string get_uxmlQualifiedName() { }

	// RVA: 0x1664B9C
	VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1664BA4
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlStyleTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Path; // 0x20
	private UxmlStringAttributeDescription m_Src; // 0x28

	// Methods

	// RVA: 0x1664BF8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlTemplateFactory 
{
	// Methods

	// RVA: 0x1664D34
	string get_uxmlName() { }

	// RVA: 0x1664D78
	string get_uxmlQualifiedName() { }

	// RVA: 0x1664DF8
	VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1664E00
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlTemplateTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_Name; // 0x18
	private UxmlStringAttributeDescription m_Path; // 0x20
	private UxmlStringAttributeDescription m_Src; // 0x28

	// Methods

	// RVA: 0x1664E54
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlAttributeOverridesFactory 
{
	// Methods

	// RVA: 0x1664F98
	string get_uxmlName() { }

	// RVA: 0x1664FDC
	string get_uxmlQualifiedName() { }

	// RVA: 0x166505C
	VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1665064
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlAttributeOverridesTraits 
{
	// Fields
	private UxmlStringAttributeDescription m_ElementName; // 0x18

	// Methods

	// RVA: 0x16650B8
	void .ctor() { }

}

// Namespace: 
public struct AttributeOverride 
{
	// Fields
	public string m_ElementName; // 0x10
	public string m_AttributeName; // 0x18
	public string m_Value; // 0x20
}

// Namespace: UnityEngine.UIElements
internal class TemplateAsset 
{
	// Fields
	private string m_TemplateAlias; // 0x70
	private System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> m_AttributeOverrides; // 0x78
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> m_SlotUsages; // 0x80

	// Methods

	// RVA: 0x166516C
	System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	// RVA: 0x166520C
	System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotUsageEntry> get_slotUsages() { }

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

	// RVA: 0x1665214
	void .ctor() { }

	// RVA: 0x166524C
	string get_name() { }

	// RVA: 0x1665254
	void set_name(string value) { }

	// RVA: 0x166525C
	void set_obsoleteNames(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x16652C4
	void set_type(string value) { }

	// RVA: 0x16652CC
	void set_typeNamespace(string value) { }

	// RVA: 0x16652D4
	void set_use(Use value) { }

	// RVA: 0x16652DC
	void set_restriction(UxmlTypeRestriction value) { }

	// RVA: 0x16652E4
	bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value) { }

	// RVA: 0x309AF8C
	bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue, ref T value) { }

	// RVA: 0x309AF8C
	T GetValueFromBag(IUxmlAttributes bag, CreationContext cc, System.Func<System.String,T,T> converterFunc, T defaultValue) { }

}

// Namespace: UnityEngine.UIElements
public abstract class TypedUxmlAttributeDescription<T0> 
{
	// Fields
	private T <defaultValue>k__BackingField; // 0x0

	// Methods

	// RVA: 0x309AF8C
	T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x309AF8C
	T get_defaultValue() { }

	// RVA: 0x309AF8C
	void set_defaultValue(T value) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlStringAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.String,System.String> <>9__3_0; // 0x8
	public static System.Func<System.String,System.String,System.String> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x1665BF0
	void .cctor() { }

	// RVA: 0x1665C5C
	void .ctor() { }

	// RVA: 0x1665C64
	string <GetValueFromBag>b__3_0(string s, string t) { }

	// RVA: 0x1665C6C
	string <TryGetValueFromBag>b__4_0(string s, string t) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlStringAttributeDescription 
{
	// Methods

	// RVA: 0x165C0E0
	void .ctor() { }

	// RVA: 0x1665858
	string GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1665A20
	bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlFloatAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Single,System.Single> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1665FBC
	void .cctor() { }

	// RVA: 0x1666028
	void .ctor() { }

	// RVA: 0x1666030
	float <GetValueFromBag>b__3_0(string s, float f) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlFloatAttributeDescription 
{
	// Methods

	// RVA: 0x1665C74
	void .ctor() { }

	// RVA: 0x1665D4C
	float GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1665F1C
	float ConvertValueToFloat(string v, float defaultValue) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlDoubleAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Double,System.Double> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1666418
	void .cctor() { }

	// RVA: 0x1666484
	void .ctor() { }

	// RVA: 0x166648C
	Double <GetValueFromBag>b__3_0(string s, Double d) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlDoubleAttributeDescription 
{
	// Methods

	// RVA: 0x16660D0
	void .ctor() { }

	// RVA: 0x16661A8
	Double GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1666378
	Double ConvertValueToDouble(string v, Double defaultValue) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlIntAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Int32,System.Int32> <>9__3_0; // 0x8
	public static System.Func<System.String,System.Int32,System.Int32> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x16669F4
	void .cctor() { }

	// RVA: 0x1666A60
	void .ctor() { }

	// RVA: 0x1666A68
	int <GetValueFromBag>b__3_0(string s, int i) { }

	// RVA: 0x1666AB4
	int <TryGetValueFromBag>b__4_0(string s, int i) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlIntAttributeDescription 
{
	// Methods

	// RVA: 0x166652C
	void .ctor() { }

	// RVA: 0x1666604
	int GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16667D4
	bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value) { }

	// RVA: 0x16669AC
	int ConvertValueToInt(string v, int defaultValue) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlUnsignedIntAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.UInt32,System.UInt32> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1666DF0
	void .cctor() { }

	// RVA: 0x1666E5C
	void .ctor() { }

	// RVA: 0x1666E64
	UInt32 <GetValueFromBag>b__3_0(string s, UInt32 i) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlUnsignedIntAttributeDescription 
{
	// Methods

	// RVA: 0x1666B00
	void .ctor() { }

	// RVA: 0x1666BD8
	UInt32 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1666DA8
	UInt32 ConvertValueToUInt(string v, UInt32 defaultValue) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlUnsignedLongAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.UInt64,System.UInt64> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x16671A0
	void .cctor() { }

	// RVA: 0x166720C
	void .ctor() { }

	// RVA: 0x1667214
	UInt64 <GetValueFromBag>b__3_0(string s, UInt64 l) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlUnsignedLongAttributeDescription 
{
	// Methods

	// RVA: 0x1666EB0
	void .ctor() { }

	// RVA: 0x1666F88
	UInt64 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1667158
	UInt64 ConvertValueToUlong(string v, UInt64 defaultValue) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlLongAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Int64,System.Int64> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1667550
	void .cctor() { }

	// RVA: 0x16675BC
	void .ctor() { }

	// RVA: 0x16675C4
	Int64 <GetValueFromBag>b__3_0(string s, Int64 l) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlLongAttributeDescription 
{
	// Methods

	// RVA: 0x1667260
	void .ctor() { }

	// RVA: 0x1667338
	Int64 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1667508
	Int64 ConvertValueToLong(string v, Int64 defaultValue) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlBoolAttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,System.Boolean,System.Boolean> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x166788C
	void .cctor() { }

	// RVA: 0x16678F8
	void .ctor() { }

	// RVA: 0x1667900
	bool <GetValueFromBag>b__3_0(string s, bool b) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlBoolAttributeDescription 
{
	// Methods

	// RVA: 0x165C1C4
	void .ctor() { }

	// RVA: 0x1667610
	bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x16677E0
	bool ConvertValueToBool(string v, bool defaultValue) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlTypeAttributeDescription<T0> 
{
	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: -1
	Type GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE37A0
	Type ConvertValueToType(string v, Type defaultValue) { }

	// RVA: 0x2FE37A0
	Type <GetValueFromBag>b__3_0(string s, Type type1) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlEnumAttributeDescription.<>c<T> <>9; // 0x0
	public static System.Func<System.String,T,T> <>9__3_0; // 0x0
	public static System.Func<System.String,T,T> <>9__4_0; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	T <GetValueFromBag>b__3_0(string s, T convertible) { }

	// RVA: 0x309AF8C
	T <TryGetValueFromBag>b__4_0(string s, T convertible) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlEnumAttributeDescription<T0> 
{
	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x309AF8C
	bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref T value) { }

	// RVA: 0x309AF8C
	U ConvertValueToEnum(string v, U defaultValue) { }

	// RVA: 0x2FE7164
	string GetEnumNameErrorMessage(string v, Type enumType) { }

	// RVA: 0x2FE7164
	string GetEnumRangeErrorMessage(string v, Type enumType) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UxmlHash128AttributeDescription.<>c <>9; // 0x0
	public static System.Func<System.String,UnityEngine.Hash128,UnityEngine.Hash128> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1667C54
	void .cctor() { }

	// RVA: 0x1667CC0
	void .ctor() { }

	// RVA: 0x1667CC8
	Hash128 <GetValueFromBag>b__3_0(string s, Hash128 i) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlHash128AttributeDescription 
{
	// Methods

	// RVA: 0x16679AC
	void .ctor() { }

	// RVA: 0x1667A84
	Hash128 GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectAttributeDescription<T0> 
{
	// Fields
	private T <defaultValue>k__BackingField; // 0x0

	// Methods

	// RVA: 0x309AF8C
	T get_defaultValue() { }

	// RVA: 0x309AF8C
	T GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectListAttributeDescription<T0> 
{
	// Methods

	// RVA: -1
	System.Collections.Generic.List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseUxmlTraits 
{
	// Fields
	private bool <canHaveAnyAttribute>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1667CD4
	void .ctor() { }

	// RVA: 0x1667D00
	void set_canHaveAnyAttribute(bool value) { }

}

// Namespace: UnityEngine.UIElements
public abstract class UxmlTraits 
{
	// Methods

	// RVA: 0x1667D08
	void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x1664AAC
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal abstract class UxmlObjectTraits<T0> 
{
	// Methods

	// RVA: -1
	void Init(ref T obj, IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public interface IBaseUxmlFactory 
{
	// Methods

	// RVA: 0x2FE360C
	string get_uxmlQualifiedName() { }

	// RVA: 0x2FE360C
	Type get_uxmlType() { }

	// RVA: -1
	bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
public interface IUxmlFactory 
{
	// Methods

	// RVA: -1
	VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
internal interface IBaseUxmlObjectFactory 
{}

// Namespace: UnityEngine.UIElements
internal interface IUxmlObjectFactory<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	T CreateObject(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
public abstract class BaseUxmlFactory<T0, T1> 
{
	// Fields
	internal TTraits m_Traits; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE360C
	string get_uxmlName() { }

	// RVA: 0x2FE360C
	string get_uxmlNamespace() { }

	// RVA: 0x2FE360C
	string get_uxmlQualifiedName() { }

	// RVA: 0x2FE360C
	Type get_uxmlType() { }

	// RVA: -1
	bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc) { }

}

// Namespace: UnityEngine.UIElements
public class UxmlFactory<T0, T1> 
{
	// Methods

	// RVA: -1
	VisualElement Create(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectFactory<T0, T1> 
{
	// Methods

	// RVA: 0x309AF8C
	TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlFactory<T0> 
{
	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal class UxmlAsset 
{
	// Fields
	private string m_FullTypeName; // 0x10
	private int m_Id; // 0x18
	private int m_OrderInDocument; // 0x1C
	private int m_ParentId; // 0x20
	protected System.Collections.Generic.List<System.String> m_Properties; // 0x28

	// Methods

	// RVA: 0x1667D0C
	string get_fullTypeName() { }

	// RVA: 0x1667D14
	int get_id() { }

	// RVA: 0x1667D1C
	int get_orderInDocument() { }

	// RVA: 0x1667D24
	int get_parentId() { }

	// RVA: 0x1667D2C
	bool TryGetAttributeValue(string propertyName, out string value) { }

	// RVA: 0x1667E44
	void SetAttribute(string name, string value) { }

	// RVA: 0x1667E48
	void SetOrAddProperty(string propertyName, string propertyValue) { }

}

// Namespace: UnityEngine.UIElements
internal sealed class UxmlObjectAsset 
{}

// Namespace: UnityEngine.UIElements
internal class UxmlObjectFactoryRegistry 
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>> s_Factories; // 0x0

	// Methods

	// RVA: 0x1667FD4
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>> get_factories() { }

	// RVA: 0x1668604
	void RegisterFactory(IBaseUxmlObjectFactory factory) { }

	// RVA: 0x1668AD4
	bool TryGetFactories(string fullTypeName, out System.Collections.Generic.List<UnityEngine.UIElements.IBaseUxmlObjectFactory>& factoryList) { }

	// RVA: 0x16680AC
	void RegisterEngineFactories() { }

	// RVA: 0x1668308
	void RegisterUserFactories() { }

}

// Namespace: UnityEngine.UIElements
public abstract class UxmlTypeRestriction 
{
	// Methods

	// RVA: 0x1668B3C
	bool Equals(UxmlTypeRestriction other) { }

	// RVA: 0x1668B48
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class UxmlEnumeration 
{
	// Fields
	private System.Collections.Generic.List<System.String> m_Values; // 0x10

	// Methods

	// RVA: 0x1668B50
	System.Collections.Generic.IEnumerable<System.String> get_values() { }

	// RVA: 0x1668B58
	void set_values(System.Collections.Generic.IEnumerable<System.String> value) { }

	// RVA: 0x1668BC0
	bool Equals(UxmlTypeRestriction other) { }

	// RVA: 0x1668D24
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
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

	// RVA: 0x1668DB0
	int get_ruleIndex() { }

	// RVA: 0x1668DB8
	string[] get_classes() { }

	// RVA: 0x1668DC0
	System.Collections.Generic.List<System.String> get_stylesheetPaths() { }

	// RVA: 0x1668E60
	bool get_hasStylesheetPaths() { }

	// RVA: 0x1668E70
	System.Collections.Generic.List<UnityEngine.UIElements.StyleSheet> get_stylesheets() { }

	// RVA: 0x1668F10
	bool get_hasStylesheets() { }

	// RVA: 0x1668F20
	bool get_skipClone() { }

	// RVA: 0x1668F28
	void OnBeforeSerialize() { }

	// RVA: 0x1668F2C
	void OnAfterDeserialize() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualElementFactoryRegistry 
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> s_Factories; // 0x0
	private static System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> s_MovedTypesFactories; // 0x8

	// Methods

	// RVA: 0x16690C0
	string GetMovedUIControlTypeName(Type type, MovedFromAttribute attr) { }

	// RVA: 0x1669244
	System.Collections.Generic.Dictionary<System.String,System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>> get_factories() { }

	// RVA: 0x166AA88
	void RegisterFactory(IUxmlFactory factory) { }

	// RVA: 0x166B09C
	bool TryGetValue(string fullTypeName, out System.Collections.Generic.List<UnityEngine.UIElements.IUxmlFactory>& factoryList) { }

	// RVA: 0x1669368
	void RegisterEngineFactories() { }

	// RVA: 0x166A78C
	void RegisterUserFactories() { }

}

// Namespace: 
internal struct UsingEntry 
{
	// Fields
	internal static readonly System.Collections.Generic.IComparer<UnityEngine.UIElements.VisualTreeAsset.UsingEntry> comparer; // 0x0
	public string alias; // 0x10
	public string path; // 0x18
	public VisualTreeAsset asset; // 0x20

	// Methods

	// RVA: 0x166E940
	void .ctor(string alias, string path) { }

	// RVA: 0x166EBCC
	void .cctor() { }

}

// Namespace: 
private class UsingEntryComparer 
{
	// Methods

	// RVA: 0x166EC5C
	int Compare(UsingEntry x, UsingEntry y) { }

	// RVA: 0x166EC54
	void .ctor() { }

}

// Namespace: 
internal struct SlotDefinition 
{
	// Fields
	public string name; // 0x10
	public int insertionPointId; // 0x18
}

// Namespace: 
internal struct SlotUsageEntry 
{
	// Fields
	public string slotName; // 0x10
	public int assetId; // 0x18
}

// Namespace: 
internal struct UxmlObjectEntry 
{
	// Fields
	public int parentId; // 0x10
	public System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset> uxmlObjectAssets; // 0x18

	// Methods

	// RVA: 0x166B7C8
	void .ctor(int parentId, System.Collections.Generic.List<UnityEngine.UIElements.UxmlObjectAsset> uxmlObjectAssets) { }

}

// Namespace: 
private struct AssetEntry 
{
	// Fields
	public string path; // 0x10
	public string typeFullName; // 0x18
	public object asset; // 0x20
	private Type m_CachedType; // 0x28

	// Methods

	// RVA: 0x166BA50
	Type get_type() { }

	// RVA: 0x166BC6C
	void .ctor(string path, Type type, object asset) { }

}

// Namespace: 
private sealed class <>c__DisplayClass61_0 
{
	// Fields
	public VisualElementAsset childVea; // 0x10

	// Methods

	// RVA: 0x166E608
	void .ctor() { }

	// RVA: 0x166EC6C
	bool <CloneSetupRecursively>b__0(SlotUsageEntry u) { }

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

	// RVA: 0x166B338
	void .ctor(int <>1__state) { }

	// RVA: 0x166EC94
	void System.IDisposable.Dispose() { }

	// RVA: 0x166EE48
	bool MoveNext() { }

	// RVA: 0x166F934
	void <>m__Finally1() { }

	// RVA: 0x166F87C
	void <>m__Finally2() { }

	// RVA: 0x166F8D8
	void <>m__Finally3() { }

	// RVA: 0x166F990
	StyleSheet System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet>.get_Current() { }

	// RVA: 0x166F998
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x166F9D8
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x166F9E0
	System.Collections.Generic.IEnumerator<UnityEngine.UIElements.StyleSheet> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet>.GetEnumerator() { }

	// RVA: 0x166FA94
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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

	// RVA: 0x166B278
	void .ctor(int <>1__state) { }

	// RVA: 0x166FA98
	void System.IDisposable.Dispose() { }

	// RVA: 0x166FB28
	bool MoveNext() { }

	// RVA: 0x16701B0
	void <>m__Finally1() { }

	// RVA: 0x167020C
	VisualTreeAsset System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset>.get_Current() { }

	// RVA: 0x1670214
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1670254
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x167025C
	System.Collections.Generic.IEnumerator<UnityEngine.UIElements.VisualTreeAsset> System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset>.GetEnumerator() { }

	// RVA: 0x1670310
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.UIElements
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

	// RVA: 0x166B150
	bool get_importedWithErrors() { }

	// RVA: 0x166B158
	void set_importedWithErrors(bool value) { }

	// RVA: 0x166B160
	bool get_importedWithWarnings() { }

	// RVA: 0x166B168
	void set_importedWithWarnings(bool value) { }

	// RVA: 0x166B170
	int GetNextChildSerialNumber() { }

	// RVA: 0x166B1F0
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.VisualTreeAsset> get_templateDependencies() { }

	// RVA: 0x166B2B0
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.StyleSheet> get_stylesheets() { }

	// RVA: 0x166B370
	System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> get_visualElementAssets() { }

	// RVA: 0x166B378
	void set_visualElementAssets(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset> value) { }

	// RVA: 0x166B380
	System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> get_templateAssets() { }

	// RVA: 0x166B388
	void set_templateAssets(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset> value) { }

	// RVA: 0x166B390
	System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.UxmlObjectEntry> get_uxmlObjectEntries() { }

	// RVA: 0x166B398
	System.Collections.Generic.List<System.Int32> get_uxmlObjectIds() { }

	// RVA: 0x166B3A0
	void RegisterUxmlObject(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: -1
	System.Collections.Generic.List<T> GetUxmlObjects(IUxmlAttributes asset, CreationContext cc) { }

	// RVA: 0x166B7D8
	bool AssetEntryExists(string path, Type type) { }

	// RVA: 0x166BB2C
	void RegisterAssetEntry(string path, Type type, object asset) { }

	// RVA: 0x309AF8C
	T GetAsset(string path) { }

	// RVA: 0x166B5DC
	UxmlObjectEntry GetUxmlObjectEntry(int id) { }

	// RVA: 0x166BCE8
	IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset) { }

	// RVA: 0x166C234
	System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> get_slots() { }

	// RVA: 0x166C23C
	void set_slots(System.Collections.Generic.List<UnityEngine.UIElements.VisualTreeAsset.SlotDefinition> value) { }

	// RVA: 0x166C244
	int get_contentContainerId() { }

	// RVA: 0x166C24C
	void set_contentContainerId(int value) { }

	// RVA: 0x166C254
	TemplateContainer Instantiate() { }

	// RVA: 0x166CBDC
	TemplateContainer Instantiate(string bindingPath) { }

	// RVA: 0x166CC1C
	TemplateContainer CloneTree() { }

	// RVA: 0x166CC20
	TemplateContainer CloneTree(string bindingPath) { }

	// RVA: 0x166CC60
	void CloneTree(VisualElement target) { }

	// RVA: 0x166CC8C
	void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount) { }

	// RVA: 0x166C3A8
	void CloneTree(VisualElement target, System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides) { }

	// RVA: 0x166D2F0
	VisualElement CloneSetupRecursively(VisualElementAsset root, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.UIElements.VisualElementAsset>> idToChildren, CreationContext context) { }

	// RVA: 0x166E610
	int CompareForOrder(VisualElementAsset a, VisualElementAsset b) { }

	// RVA: 0x166E514
	bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName) { }

	// RVA: 0x166E64C
	VisualTreeAsset ResolveTemplate(string templateName) { }

	// RVA: 0x166DE90
	VisualElement Create(VisualElementAsset asset, CreationContext ctx) { }

	// RVA: 0x166CE54
	void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x166CECC
	void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element) { }

	// RVA: 0x166EAE4
	int get_contentHash() { }

	// RVA: 0x166EAEC
	void set_contentHash(int value) { }

	// RVA: 0x166EAF4
	void .ctor() { }

	// RVA: 0x166EAFC
	void .cctor() { }

	// RVA: 0x166E984
	VisualElement <Create>g__CreateError|65_0(ref UnityEngine.UIElements.VisualTreeAsset.<>c__DisplayClass65_0& ) { }

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

	// RVA: 0x1670314
	VisualElement get_target() { }

	// RVA: 0x167031C
	void set_target(VisualElement value) { }

	// RVA: 0x1670324
	VisualTreeAsset get_visualTreeAsset() { }

	// RVA: 0x167032C
	void set_visualTreeAsset(VisualTreeAsset value) { }

	// RVA: 0x1670334
	System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> get_slotInsertionPoints() { }

	// RVA: 0x167033C
	void set_slotInsertionPoints(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> value) { }

	// RVA: 0x1670344
	System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> get_attributeOverrides() { }

	// RVA: 0x167034C
	void set_attributeOverrides(System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> value) { }

	// RVA: 0x166C130
	void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x166D238
	void .ctor(System.Collections.Generic.Dictionary<System.String,UnityEngine.UIElements.VisualElement> slotInsertionPoints, System.Collections.Generic.List<UnityEngine.UIElements.TemplateAsset.AttributeOverride> attributeOverrides, VisualTreeAsset vta, VisualElement target) { }

	// RVA: 0x1670354
	bool Equals(object obj) { }

	// RVA: 0x1670434
	bool Equals(CreationContext other) { }

	// RVA: 0x16705B0
	int GetHashCode() { }

	// RVA: 0x16706F0
	void .cctor() { }

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
internal struct GradientSettings 
{
	// Fields
	public GradientType gradientType; // 0x10
	public AddressMode addressMode; // 0x14
	public Vector2 radialFocus; // 0x18
	public RectInt location; // 0x20
}

// Namespace: UnityEngine.UIElements
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

	// RVA: 0x1670740
	float get_width() { }

	// RVA: 0x1670748
	float get_height() { }

	// RVA: 0x1670750
	void .ctor() { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.VisualElementListPool.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1670C00
	void .cctor() { }

	// RVA: 0x1670C6C
	void .ctor() { }

	// RVA: 0x1670C74
	System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> <.cctor>b__4_0() { }

}

// Namespace: UnityEngine.UIElements
internal static class VisualElementListPool 
{
	// Fields
	private static UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<UnityEngine.UIElements.VisualElement>> pool; // 0x0

	// Methods

	// RVA: 0x16707EC
	System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Copy(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x16708D0
	System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> Get(int initialCapacity) { }

	// RVA: 0x16709E4
	void Release(System.Collections.Generic.List<UnityEngine.UIElements.VisualElement> elements) { }

	// RVA: 0x1670AE0
	void .cctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.ObjectListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.List<T> <.cctor>b__4_0() { }

}

// Namespace: UnityEngine.UIElements
internal class ObjectListPool<T0> 
{
	// Fields
	private static UnityEngine.UIElements.ObjectPool<System.Collections.Generic.List<T>> pool; // 0x0

	// Methods

	// RVA: 0x2FE704C
	System.Collections.Generic.List<T> Get() { }

	// RVA: 0x2FE9A04
	void Release(System.Collections.Generic.List<T> elements) { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements
public static class VisualElementExtensions 
{
	// Methods

	// RVA: 0x1670CE8
	void StretchToParentSize(VisualElement elem) { }

	// RVA: 0x167101C
	void AddManipulator(VisualElement ele, IManipulator manipulator) { }

	// RVA: 0x16710D8
	void RemoveManipulator(VisualElement ele, IManipulator manipulator) { }

	// RVA: 0x1671198
	Vector2 WorldToLocal(VisualElement ele, Vector2 p) { }

	// RVA: 0x1671280
	Vector2 LocalToWorld(VisualElement ele, Vector2 p) { }

	// RVA: 0x1671368
	Rect WorldToLocal(VisualElement ele, Rect r) { }

	// RVA: 0x1671450
	Vector2 ChangeCoordinatesTo(VisualElement src, VisualElement dest, Vector2 point) { }

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

	// RVA: 0x1671474
	void GetDefaultEventInterests(Type elementType, out int defaultActionCategories, out int defaultActionAtTargetCategories) { }

	// RVA: 0x16716EC
	int ComputeDefaultEventInterests(Type elementType, string methodName) { }

	// RVA: 0x16718E4
	EventCategory GetEventCategory(Type eventType) { }

	// RVA: 0x1671B20
	void .cctor() { }

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

	// RVA: 0x1671C14
	void .ctor(Type[] eventTypes) { }

	// RVA: 0x1671C4C
	void .ctor(EventInterestOptions interests) { }

}

// Namespace: UnityEngine.UIElements
internal class EventCategoryAttribute 
{
	// Fields
	internal EventCategory category; // 0x10

	// Methods

	// RVA: 0x1671C7C
	void .ctor(EventCategory category) { }

}

// Namespace: UnityEngine.UIElements
public interface IExperimentalFeatures 
{
	// Methods

	// RVA: 0x2FE360C
	ITransitionAnimations get_animation() { }

}

// Namespace: UnityEngine.UIElements
public class VisualElementFocusChangeDirection 
{
	// Fields
	private static readonly VisualElementFocusChangeDirection s_Left; // 0x0
	private static readonly VisualElementFocusChangeDirection s_Right; // 0x8

	// Methods

	// RVA: 0x1671CA8
	FocusChangeDirection get_left() { }

	// RVA: 0x1671D24
	FocusChangeDirection get_right() { }

	// RVA: 0x1671DA0
	void .ctor(int value) { }

	// RVA: 0x1671E0C
	void .cctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.VisualElementFocusChangeTarget.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16723C8
	void .cctor() { }

	// RVA: 0x1672434
	void .ctor() { }

	// RVA: 0x167243C
	VisualElementFocusChangeTarget <.cctor>b__9_0() { }

}

// Namespace: UnityEngine.UIElements
internal class VisualElementFocusChangeTarget 
{
	// Fields
	private static readonly UnityEngine.UIElements.ObjectPool<UnityEngine.UIElements.VisualElementFocusChangeTarget> Pool; // 0x0
	private Focusable <target>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1672010
	VisualElementFocusChangeTarget GetPooled(Focusable target) { }

	// RVA: 0x16720E0
	void Dispose() { }

	// RVA: 0x167217C
	void ApplyTo(FocusController focusController, Focusable f) { }

	// RVA: 0x16721C4
	void .ctor() { }

	// RVA: 0x1672298
	Focusable get_target() { }

	// RVA: 0x16722A0
	void set_target(Focusable value) { }

	// RVA: 0x16722A8
	void .cctor() { }

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

	// RVA: 0x1673C98
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
public class VisualElementFocusRing 
{
	// Fields
	private readonly VisualElement root; // 0x10
	private DefaultFocusOrder <defaultFocusOrder>k__BackingField; // 0x18
	private System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> m_FocusRing; // 0x20

	// Methods

	// RVA: 0x1672490
	void .ctor(VisualElement root, DefaultFocusOrder dfo) { }

	// RVA: 0x1672540
	FocusController get_focusController() { }

	// RVA: 0x1672568
	DefaultFocusOrder get_defaultFocusOrder() { }

	// RVA: 0x1672570
	void set_defaultFocusOrder(DefaultFocusOrder value) { }

	// RVA: 0x1672578
	int FocusRingAutoIndexSort(FocusRingRecord a, FocusRingRecord b) { }

	// RVA: 0x16728B8
	int FocusRingSort(FocusRingRecord a, FocusRingRecord b) { }

	// RVA: 0x16729C4
	void DoUpdate() { }

	// RVA: 0x1672AEC
	void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> scopeList) { }

	// RVA: 0x1672DA4
	void SortAndFlattenScopeLists(System.Collections.Generic.List<UnityEngine.UIElements.VisualElementFocusRing.FocusRingRecord> rootScopeList) { }

	// RVA: 0x16730C4
	int GetFocusableInternalIndex(Focusable f) { }

	// RVA: 0x1673180
	FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e) { }

	// RVA: 0x16735C8
	Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction) { }

	// RVA: 0x1673AD4
	Focusable GetNextFocusableInTree(VisualElement currentFocusable) { }

	// RVA: 0x1673B90
	Focusable GetPreviousFocusableInTree(VisualElement currentFocusable) { }

}

// Namespace: UnityEngine.UIElements
public interface IVisualElementScheduledItem 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_isActive() { }

	// RVA: 0x2FE41A8
	void Resume() { }

	// RVA: 0x2FE41A8
	void Pause() { }

	// RVA: -1
	void ExecuteLater(Int64 delayMs) { }

	// RVA: -1
	IVisualElementScheduledItem StartingIn(Int64 delayMs) { }

	// RVA: -1
	IVisualElementScheduledItem Every(Int64 intervalMs) { }

}

// Namespace: UnityEngine.UIElements
public interface IVisualElementScheduler 
{
	// Methods

	// RVA: 0x2FE36BC
	IVisualElementScheduledItem Execute(System.Action<UnityEngine.UIElements.TimerState> timerUpdateEvent) { }

	// RVA: 0x2FE36BC
	IVisualElementScheduledItem Execute(Action updateEvent) { }

}

// Namespace: UnityEngine.UIElements
internal interface IVisualElementPanelActivatable 
{
	// Methods

	// RVA: 0x2FE360C
	VisualElement get_element() { }

	// RVA: 0x2FE3054
	bool CanBeActivated() { }

	// RVA: 0x2FE41A8
	void OnPanelActivate() { }

	// RVA: 0x2FE41A8
	void OnPanelDeactivate() { }

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

	// RVA: 0x1673CA0
	bool get_isActive() { }

	// RVA: 0x1673CA8
	void set_isActive(bool value) { }

	// RVA: 0x1673CB0
	bool get_isDetaching() { }

	// RVA: 0x1673CB8
	void set_isDetaching(bool value) { }

	// RVA: 0x1673CC0
	void .ctor(IVisualElementPanelActivatable activatable) { }

	// RVA: 0x1673DCC
	void SetActive(bool action) { }

	// RVA: 0x16740C8
	void SendActivation() { }

	// RVA: 0x1674210
	void SendDeactivation() { }

	// RVA: 0x1674358
	void OnEnter(AttachToPanelEvent evt) { }

	// RVA: 0x1674368
	void OnLeave(DetachFromPanelEvent evt) { }

}

// Namespace: UnityEngine.UIElements
public struct VisualElementStyleSheetSet 
{
	// Fields
	private readonly VisualElement m_Element; // 0x10

	// Methods

	// RVA: 0x16743E4
	void .ctor(VisualElement element) { }

	// RVA: 0x16743EC
	void Add(StyleSheet styleSheet) { }

	// RVA: 0x16745A0
	bool Remove(StyleSheet styleSheet) { }

	// RVA: 0x1674700
	bool Equals(VisualElementStyleSheetSet other) { }

	// RVA: 0x167470C
	bool Equals(object obj) { }

	// RVA: 0x1674798
	int GetHashCode() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.VisualElementUtils.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.UIElements.VisualElement> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x1674C2C
	void .cctor() { }

	// RVA: 0x1674C98
	void .ctor() { }

	// RVA: 0x1674CA0
	bool <AssignInspectorStyleIfNecessary>b__5_0(VisualElement i) { }

}

// Namespace: UnityEngine.UIElements
internal static class VisualElementUtils 
{
	// Fields
	private static readonly System.Collections.Generic.HashSet<System.String> s_usedNames; // 0x0
	private static readonly Type s_FoldoutType; // 0x8
	private static readonly string s_InspectorElementUssClassName; // 0x10

	// Methods

	// RVA: 0x16747B0
	string GetUniqueName(string nameBase) { }

	// RVA: 0x16748E0
	int GetFoldoutDepth(VisualElement element) { }

	// RVA: 0x16749D4
	void AssignInspectorStyleIfNecessary(VisualElement element, string classNameToEnable) { }

	// RVA: 0x1674B04
	void .cctor() { }

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

	// RVA: 0x1674D28
	ProfilerMarker get_profilerMarker() { }

	// RVA: 0x1674DA4
	ProfilerMarker get_stylePropertyAnimationProfilerMarker() { }

	// RVA: 0x1674E20
	void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x1674E90
	void UnregisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims) { }

	// RVA: 0x167508C
	void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x16750FC
	void RegisterAnimations(System.Collections.Generic.List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims) { }

	// RVA: 0x16752F8
	void Update() { }

	// RVA: 0x16757CC
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x16757D0
	void .ctor() { }

	// RVA: 0x16758BC
	void .cctor() { }

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

	// RVA: 0x16759B4
	ProfilerMarker get_profilerMarker() { }

	// RVA: 0x1675A30
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x1675B18
	void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags) { }

	// RVA: 0x1675C14
	void DirtyBoundingBoxHierarchy(VisualElement ve) { }

	// RVA: 0x1675CC4
	void Update() { }

	// RVA: 0x1675D30
	void .ctor() { }

	// RVA: 0x1675D3C
	void .cctor() { }

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

	// RVA: 0x2FE45DC
	void OnHierarchyChange(VisualElement ve, HierarchyChangeType type) { }

	// RVA: 0x1675DE4
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x167617C
	void Update() { }

	// RVA: 0x1675F6C
	void ProcessNewChange(VisualElement ve) { }

	// RVA: 0x16760C0
	void ProcessAddOrMove(VisualElement ve) { }

	// RVA: 0x1676024
	void ProcessRemove(VisualElement ve) { }

	// RVA: 0x1676234
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements
internal static class StyleCache 
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int64,UnityEngine.UIElements.ComputedStyle> s_ComputedStyleCache; // 0x0
	private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.StyleVariableContext> s_StyleVariableContextCache; // 0x8
	private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.UIElements.ComputedTransitionProperty[]> s_ComputedTransitionsCache; // 0x10

	// Methods

	// RVA: 0x1676240
	bool TryGetValue(Int64 hash, out ComputedStyle data) { }

	// RVA: 0x16762FC
	void SetValue(Int64 hash, ref ComputedStyle data) { }

	// RVA: 0x16763D8
	bool TryGetValue(int hash, out StyleVariableContext data) { }

	// RVA: 0x1676494
	void SetValue(int hash, StyleVariableContext data) { }

	// RVA: 0x1676550
	bool TryGetValue(int hash, out ComputedTransitionProperty[] data) { }

	// RVA: 0x167660C
	void SetValue(int hash, ComputedTransitionProperty[] data) { }

	// RVA: 0x16766C8
	void .cctor() { }

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

	// RVA: 0x1676814
	ProfilerMarker get_profilerMarker() { }

	// RVA: 0x1676890
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x1676A3C
	void Update() { }

	// RVA: 0x167742C
	bool get_disposed() { }

	// RVA: 0x1677434
	void set_disposed(bool value) { }

	// RVA: 0x167743C
	void Dispose(bool disposing) { }

	// RVA: 0x1676EB4
	void ApplyStyles() { }

	// RVA: 0x16774B8
	void .ctor() { }

	// RVA: 0x1677800
	void .cctor() { }

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

	// RVA: 0x16778A8
	int get_styleSheetCount() { }

	// RVA: 0x16778F4
	void .ctor(System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult) { }

	// RVA: 0x1677A28
	void AddStyleSheet(StyleSheet sheet) { }

	// RVA: 0x1677AF4
	void RemoveStyleSheetRange(int index, int count) { }

	// RVA: 0x1677B60
	StyleSheet GetStyleSheetAt(int index) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.VisualTreeStyleUpdaterTraversal.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> <>9__24_0; // 0x8

	// Methods

	// RVA: 0x1679860
	void .cctor() { }

	// RVA: 0x16798CC
	void .ctor() { }

	// RVA: 0x16798D4
	int <ProcessMatchedRules>b__24_0(SelectorMatchRecord a, SelectorMatchRecord b) { }

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

	// RVA: 0x1677BD8
	float get_currentPixelsPerPoint() { }

	// RVA: 0x1677BE0
	void set_currentPixelsPerPoint(float value) { }

	// RVA: 0x16774B0
	void PrepareTraversal(float pixelsPerPoint) { }

	// RVA: 0x16769B8
	void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x1676FA8
	void Clear() { }

	// RVA: 0x1677BE8
	void PropagateToChildren(VisualElement ve) { }

	// RVA: 0x1677CC8
	void PropagateToParents(VisualElement ve) { }

	// RVA: 0x1677D78
	void OnProcessMatchResult(VisualElement current, MatchResultInfo info) { }

	// RVA: 0x1677DAC
	void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x16792F4
	void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle) { }

	// RVA: 0x16793E8
	void ForceUpdateTransitions(VisualElement element) { }

	// RVA: 0x167707C
	void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle) { }

	// RVA: 0x1678674
	bool ShouldSkipElement(VisualElement element) { }

	// RVA: 0x167870C
	ComputedStyle ProcessMatchedRules(VisualElement element, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchingSelectors) { }

	// RVA: 0x167976C
	void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x16775AC
	void .ctor() { }

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

	// RVA: 0x16799F8
	void .ctor() { }

	// RVA: 0x167A050
	void set_Item(VisualTreeUpdatePhase phase, IVisualTreeUpdater value) { }

	// RVA: 0x1679ED8
	IVisualTreeUpdater get_Item(VisualTreeUpdatePhase phase) { }

	// RVA: 0x1679CB0
	IVisualTreeUpdater get_Item(int index) { }

}

// Namespace: UnityEngine.UIElements
internal sealed class VisualTreeUpdater 
{
	// Fields
	private BaseVisualElementPanel m_Panel; // 0x10
	private UpdaterArray m_UpdaterArray; // 0x18

	// Methods

	// RVA: 0x167991C
	void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x1679BB0
	void Dispose() { }

	// RVA: 0x1679CE4
	void UpdateVisualTreePhase(VisualTreeUpdatePhase phase) { }

	// RVA: 0x1679F0C
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x2FE42A4
	void SetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x167A014
	IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	// RVA: 0x1679A68
	void SetDefaultUpdaters() { }

}

// Namespace: UnityEngine.UIElements
internal interface IVisualTreeUpdater 
{
	// Methods

	// RVA: 0x2FE4574
	void set_panel(BaseVisualElementPanel value) { }

	// RVA: -1
	ProfilerMarker get_profilerMarker() { }

	// RVA: 0x2FE41A8
	void Update() { }

	// RVA: 0x2FE45DC
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

}

// Namespace: UnityEngine.UIElements
internal abstract class BaseVisualTreeUpdater 
{
	// Fields
	private System.Action<UnityEngine.UIElements.BaseVisualElementPanel> panelChanged; // 0x10
	private BaseVisualElementPanel m_Panel; // 0x18

	// Methods

	// RVA: 0x167A0C4
	void add_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x167A178
	void remove_panelChanged(System.Action<UnityEngine.UIElements.BaseVisualElementPanel> value) { }

	// RVA: 0x16757C4
	BaseVisualElementPanel get_panel() { }

	// RVA: 0x167A22C
	void set_panel(BaseVisualElementPanel value) { }

	// RVA: 0x1677488
	VisualElement get_visualTree() { }

	// RVA: -1
	ProfilerMarker get_profilerMarker() { }

	// RVA: 0x167A27C
	void Dispose() { }

	// RVA: 0x167A30C
	void Dispose(bool disposing) { }

	// RVA: 0x2FE41A8
	void Update() { }

	// RVA: 0x2FE45DC
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x16758B4
	void .ctor() { }

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

	// RVA: 0x167A310
	ProfilerMarker get_profilerMarker() { }

	// RVA: 0x167A38C
	void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	// RVA: 0x167A4D0
	void Update() { }

	// RVA: 0x167A71C
	void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence) { }

	// RVA: 0x167A420
	void PropagateToParents(VisualElement ve) { }

	// RVA: 0x167A878
	void .ctor() { }

	// RVA: 0x167A92C
	void .cctor() { }

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

	// RVA: 0x2FE4314
	void .ctor(int elementCount, GPUBufferType type) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x309AF8C
	void UpdateRanges(Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.GfxUpdateBufferRange> ranges, int rangesMin, int rangesMax) { }

	// RVA: 0x2FE32D4
	int get_ElementStride() { }

	// RVA: -1
	IntPtr get_BufferPointer() { }

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

	// RVA: 0x309AF8C
	void SetVectorArray(MaterialPropertyBlock props, int name, Unity.Collections.NativeSlice<T> vector4s) { }

	// RVA: 0x167A9D4
	void add_GraphicsResourcesRecreate(System.Action<System.Boolean> value) { }

	// RVA: 0x167AAE4
	void remove_GraphicsResourcesRecreate(System.Action<System.Boolean> value) { }

	// RVA: 0x167ABF4
	void add_EngineUpdate(Action value) { }

	// RVA: 0x167ACE4
	void remove_EngineUpdate(Action value) { }

	// RVA: 0x167ADD4
	void add_FlushPendingResources(Action value) { }

	// RVA: 0x167AEC4
	void remove_FlushPendingResources(Action value) { }

	// RVA: 0x167AFB4
	void add_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x167B0C8
	void remove_RegisterIntermediateRenderers(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x167B1DC
	void add_RenderNodeExecute(System.Action<System.IntPtr> value) { }

	// RVA: 0x167B2F0
	void remove_RenderNodeExecute(System.Action<System.IntPtr> value) { }

	// RVA: 0x167B404
	void RaiseGraphicsResourcesRecreate(bool recreate) { }

	// RVA: 0x167B4AC
	void RaiseEngineUpdate() { }

	// RVA: 0x167B584
	void RaiseFlushPendingResources() { }

	// RVA: 0x167B614
	void RaiseRegisterIntermediateRenderers(Camera camera) { }

	// RVA: 0x167B6B8
	void RaiseRenderNodeAdd(IntPtr userData) { }

	// RVA: 0x167B760
	void RaiseRenderNodeExecute(IntPtr userData) { }

	// RVA: 0x167B808
	void RaiseRenderNodeCleanup(IntPtr userData) { }

	// RVA: 0x167B8B0
	IntPtr AllocateBuffer(int elementCount, int elementStride, bool vertexBuffer) { }

	// RVA: 0x167B908
	void FreeBuffer(IntPtr buffer) { }

	// RVA: 0x167B958
	void UpdateBufferRanges(IntPtr buffer, IntPtr ranges, int rangeCount, int writeRangeStart, int writeRangeEnd) { }

	// RVA: 0x167B9C8
	void SetVectorArray(MaterialPropertyBlock props, int name, IntPtr vector4s, int count) { }

	// RVA: 0x167BA30
	IntPtr GetVertexDeclaration(VertexAttributeDescriptor[] vertexAttributes) { }

	// RVA: 0x167BA80
	void RegisterIntermediateRenderer(Camera camera, Material material, Matrix4x4 transform, Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, UInt64 sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	// RVA: 0x167BC40
	void DrawRanges(IntPtr ib, IntPtr* vertexStreams, int streamCount, IntPtr ranges, int rangeCount, IntPtr vertexDecl) { }

	// RVA: 0x167BCC0
	void SetPropertyBlock(MaterialPropertyBlock props) { }

	// RVA: 0x167BD10
	void SetScissorRect(RectInt scissorRect) { }

	// RVA: 0x167BE14
	void DisableScissor() { }

	// RVA: 0x167BE54
	IntPtr CreateStencilState(StencilState stencilState) { }

	// RVA: 0x167BF5C
	void SetStencilState(IntPtr stencilState, int stencilRef) { }

	// RVA: 0x167BFC4
	bool HasMappedBufferRange() { }

	// RVA: 0x167C004
	UInt32 InsertCPUFence() { }

	// RVA: 0x167C044
	bool CPUFencePassed(UInt32 fence) { }

	// RVA: 0x167C094
	void WaitForCPUFencePassed(UInt32 fence) { }

	// RVA: 0x167C0E4
	void SyncRenderThread() { }

	// RVA: 0x167C124
	RectInt GetActiveViewport() { }

	// RVA: 0x167C21C
	void ProfileDrawChainBegin() { }

	// RVA: 0x167C25C
	void ProfileDrawChainEnd() { }

	// RVA: 0x167C29C
	void NotifyOfUIREvents(bool subscribe) { }

	// RVA: 0x167C2EC
	Matrix4x4 GetUnityProjectionMatrix() { }

	// RVA: 0x167C40C
	void .cctor() { }

	// RVA: 0x167BB84
	void RegisterIntermediateRenderer_Injected(Camera camera, Material material, ref Matrix4x4 transform, ref Bounds aabb, int renderLayer, int shadowCasting, bool receiveShadows, int sameDistanceSortPriority, UInt64 sceneCullingMask, int rendererCallbackFlags, IntPtr userData, int userDataSize) { }

	// RVA: 0x167BDC4
	void SetScissorRect_Injected(ref RectInt scissorRect) { }

	// RVA: 0x167BF0C
	IntPtr CreateStencilState_Injected(ref StencilState stencilState) { }

	// RVA: 0x167C1CC
	void GetActiveViewport_Injected(out RectInt ret) { }

	// RVA: 0x167C3BC
	void GetUnityProjectionMatrix_Injected(out Matrix4x4 ret) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal static class JobProcessor 
{
	// Methods

	// RVA: 0x167C48C
	JobHandle ScheduleNudgeJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x167C54C
	JobHandle ScheduleConvertMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x167C60C
	JobHandle ScheduleCopyClosingMeshJobs(IntPtr buffer, int jobCount) { }

	// RVA: 0x167C4F4
	void ScheduleNudgeJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	// RVA: 0x167C5B4
	void ScheduleConvertMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

	// RVA: 0x167C674
	void ScheduleCopyClosingMeshJobs_Injected(IntPtr buffer, int jobCount, out JobHandle ret) { }

}

// Namespace: 
public class Area 
{
	// Fields
	public RectInt rect; // 0x10
	public BestFitAllocator allocator; // 0x20

	// Methods

	// RVA: 0x167DBA4
	void .ctor(RectInt rect) { }

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

	// RVA: 0x167DC34
	Row Create() { }

	// RVA: 0x167DD14
	void Reset(Row row) { }

	// RVA: 0x167DCC0
	void .ctor() { }

	// RVA: 0x167DD6C
	void .cctor() { }

}

// Namespace: 
public struct Alloc2D 
{
	// Fields
	public RectInt rect; // 0x10
	public Row row; // 0x20
	public Alloc alloc; // 0x28

	// Methods

	// RVA: 0x167D4C4
	void .ctor(Row row, Alloc alloc, int width, int height) { }

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

	// RVA: 0x167C6CC
	void .ctor(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias) { }

	// RVA: 0x167CDB8
	bool TryAllocate(int width, int height, out Alloc2D alloc2D) { }

	// RVA: 0x167D6E0
	void Free(Alloc2D alloc2D) { }

	// RVA: 0x167C9A4
	void BuildAreas(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, Vector2Int minSize, Vector2Int maxSize) { }

	// RVA: 0x167CC10
	Vector2Int ComputeMaxAllocSize(System.Collections.Generic.List<UnityEngine.UIElements.UIR.Allocator2D.Area> areas, int rowHeightBias) { }

	// RVA: 0x167CD30
	Row[] BuildRowArray(int maxRowHeight, int rowHeightBias) { }

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

	// RVA: 0x167DEAC
	void Dispose() { }

	// RVA: 0x167DFB4
	void Dispose(bool disposing) { }

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

	// RVA: 0x167E060
	void .ctor() { }

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

	// RVA: 0x1680030
	void Dispose() { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.UIRenderDevice.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.UIR.MeshHandle> <>9__50_0; // 0x8
	public static System.Action<UnityEngine.UIElements.UIR.MeshHandle> <>9__50_1; // 0x10

	// Methods

	// RVA: 0x168624C
	void .cctor() { }

	// RVA: 0x16862B8
	void .ctor() { }

	// RVA: 0x16862C0
	MeshHandle <.ctor>b__50_0() { }

	// RVA: 0x168634C
	void <.ctor>b__50_1(MeshHandle mh) { }

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

	// RVA: 0x167E0B4
	UInt32 get_maxVerticesPerPage() { }

	// RVA: 0x167E0BC
	bool get_breakBatches() { }

	// RVA: 0x167E0C4
	void set_breakBatches(bool value) { }

	// RVA: 0x167E0CC
	void .cctor() { }

	// RVA: 0x167E3FC
	void .ctor(UInt32 initialVertexCapacity, UInt32 initialIndexCapacity) { }

	// RVA: 0x167E404
	void .ctor(UInt32 initialVertexCapacity, UInt32 initialIndexCapacity, bool mockDevice) { }

	// RVA: 0x167EC7C
	Texture2D get_defaultShaderInfoTexFloat() { }

	// RVA: 0x167F064
	Texture2D get_defaultShaderInfoTexARGB8() { }

	// RVA: 0x167F394
	bool get_vertexTexturingIsAvailable() { }

	// RVA: 0x167F5D0
	bool get_shaderModelIs35() { }

	// RVA: 0x167F80C
	void InitVertexDeclaration() { }

	// RVA: 0x167FAE0
	void CompleteCreation() { }

	// RVA: 0x167FD30
	bool get_fullyCreated() { }

	// RVA: 0x167FD40
	bool get_disposed() { }

	// RVA: 0x167FD48
	void set_disposed(bool value) { }

	// RVA: 0x167FD50
	void Dispose() { }

	// RVA: 0x167FDE0
	void Dispose(bool disposing) { }

	// RVA: 0x1680724
	MeshHandle Allocate(UInt32 vertexCount, UInt32 indexCount, out Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, out Unity.Collections.NativeSlice<System.UInt16>& indexData, out UInt16 indexOffset) { }

	// RVA: 0x1680F5C
	void Update(MeshHandle mesh, UInt32 vertexCount, out Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData) { }

	// RVA: 0x168176C
	void Update(MeshHandle mesh, UInt32 vertexCount, UInt32 indexCount, out Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, out Unity.Collections.NativeSlice<System.UInt16>& indexData, out UInt16 indexOffset) { }

	// RVA: 0x168191C
	void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices) { }

	// RVA: 0x1681A84
	System.Collections.Generic.List<UnityEngine.UIElements.UIR.UIRenderDevice.AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh) { }

	// RVA: 0x1681B18
	bool TryAllocFromPage(Page page, UInt32 vertexCount, UInt32 indexCount, ref Alloc va, ref Alloc ia, bool shortLived) { }

	// RVA: 0x16807F0
	void Allocate(MeshHandle meshHandle, UInt32 vertexCount, UInt32 indexCount, out Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, out Unity.Collections.NativeSlice<System.UInt16>& indexData, bool shortLived) { }

	// RVA: 0x1681154
	void UpdateAfterGPUUsedData(MeshHandle mesh, UInt32 vertexCount, UInt32 indexCount, out Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& vertexData, out Unity.Collections.NativeSlice<System.UInt16>& indexData, out UInt16 indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices) { }

	// RVA: 0x1682088
	void Free(MeshHandle mesh) { }

	// RVA: 0x168267C
	void OnFrameRenderingBegin() { }

	// RVA: 0x309AF8C
	Unity.Collections.NativeSlice<T> PtrToSlice(Void* p, int count) { }

	// RVA: 0x16833C4
	void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref EvaluationState st) { }

	// RVA: 0x16835B4
	void ApplyBatchState(ref EvaluationState st, bool allowMaterialChange) { }

	// RVA: 0x16837BC
	void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> transforms, Unity.Collections.NativeSlice<UnityEngine.Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException) { }

	// RVA: 0x1685988
	void UpdateFenceValue() { }

	// RVA: 0x16848D0
	void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage) { }

	// RVA: 0x309AF8C
	void DrawRanges(UnityEngine.UIElements.UIR.Utility.GPUBuffer<I> ib, UnityEngine.UIElements.UIR.Utility.GPUBuffer<T> vb, Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.DrawBufferRange> ranges) { }

	// RVA: 0x1685A8C
	void WaitOnCpuFence(UInt32 fence) { }

	// RVA: 0x16827A0
	void AdvanceFrame() { }

	// RVA: 0x1685BD0
	void PruneUnusedPages() { }

	// RVA: 0x1685E10
	void PrepareForGfxDeviceRecreate() { }

	// RVA: 0x1686014
	void WrapUpGfxDeviceRecreate() { }

	// RVA: 0x1686078
	void FlushAllPendingDeviceDisposes() { }

	// RVA: 0x1686148
	DrawStatistics GatherDrawStatistics() { }

	// RVA: 0x16800EC
	void ProcessDeviceFreeQueue() { }

	// RVA: 0x1686160
	void OnEngineUpdateGlobal() { }

	// RVA: 0x16861C8
	void OnFlushPendingResources() { }

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

	// RVA: 0x1686738
	Block CreateBlock() { }

	// RVA: 0x1686818
	void ResetBlock(Block block) { }

	// RVA: 0x1686350
	void .ctor() { }

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

	// RVA: 0x1686494
	UInt32 get_size() { }

	// RVA: 0x16867C4
	void .ctor() { }

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

	// RVA: 0x167D600
	void .ctor(UInt32 size) { }

	// RVA: 0x1686448
	UInt32 get_totalSize() { }

	// RVA: 0x167DB9C
	UInt32 get_highWatermark() { }

	// RVA: 0x167D2A4
	Alloc Allocate(UInt32 size) { }

	// RVA: 0x167D8F8
	void Free(Alloc alloc) { }

	// RVA: 0x1686610
	Block CoalesceBlockWithPrevious(Block block) { }

	// RVA: 0x1686450
	Block BestFitFindAvailableBlock(UInt32 size) { }

	// RVA: 0x16864A0
	void SplitBlock(Block block, UInt32 size) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class GPUBufferAllocator 
{
	// Fields
	private BestFitAllocator m_Low; // 0x10
	private BestFitAllocator m_High; // 0x18

	// Methods

	// RVA: 0x168681C
	void .ctor(UInt32 maxSize) { }

	// RVA: 0x1681C94
	Alloc Allocate(UInt32 size, bool shortLived) { }

	// RVA: 0x1681E08
	void Free(Alloc alloc) { }

	// RVA: 0x16868F8
	bool get_isEmpty() { }

	// RVA: 0x16868BC
	bool HighLowCollide() { }

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

	// RVA: 0x309AF8C
	void .ctor(GPUBufferType bufferType, UInt32 totalCount, UInt32 maxQueuedFrameCount, UInt32 updateRangePoolSize, bool mockBuffer) { }

	// RVA: 0x2FE3054
	bool get_disposed() { }

	// RVA: 0x2FE4234
	void set_disposed(bool value) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE4234
	void Dispose(bool disposing) { }

	// RVA: 0x309AF8C
	void RegisterUpdate(UInt32 start, UInt32 size) { }

	// RVA: 0x2FE3054
	bool HasMappedBufferRange() { }

	// RVA: 0x2FE41A8
	void SendUpdates() { }

	// RVA: 0x2FE41A8
	void SendFullRange() { }

	// RVA: 0x2FE41A8
	void SendPartialRanges() { }

	// RVA: 0x2FE41A8
	void ResetUpdateState() { }

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

	// RVA: 0x1681E8C
	void .ctor(UInt32 vertexMaxCount, UInt32 indexMaxCount, UInt32 maxQueuedFrameCount, bool mockPage) { }

	// RVA: 0x168693C
	bool get_disposed() { }

	// RVA: 0x1686944
	void set_disposed(bool value) { }

	// RVA: 0x1685D80
	void Dispose() { }

	// RVA: 0x168694C
	void Dispose(bool disposing) { }

	// RVA: 0x1681FEC
	bool get_isEmpty() { }

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

	// RVA: 0x16844A8
	void Reset() { }

	// RVA: 0x167EAE4
	void .ctor() { }

	// RVA: 0x16869F8
	void .cctor() { }

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

	// RVA: 0x1686A54
	void Reset() { }

	// RVA: 0x1684B28
	void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) { }

	// RVA: 0x16870C0
	void Blit(Texture source, RenderTexture destination, float depth) { }

	// RVA: 0x1686FAC
	Rect CombineScissorRects(Rect r0, Rect r1) { }

	// RVA: 0x1686ACC
	RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	// RVA: 0x1687238
	void .ctor() { }

	// RVA: 0x168728C
	void .cctor() { }

}

// Namespace: 
private struct RawTexture 
{
	// Fields
	public Color32[] rgba; // 0x10
	public int width; // 0x18
	public int height; // 0x1C

	// Methods

	// RVA: 0x1687C9C
	void WriteRawInt2Packed(int v0, int v1, int destX, int destY) { }

	// RVA: 0x1687BDC
	void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY) { }

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

	// RVA: 0x1687338
	int get_length() { }

	// RVA: 0x1687340
	bool get_disposed() { }

	// RVA: 0x1687348
	void set_disposed(bool value) { }

	// RVA: 0x1687350
	void Dispose() { }

	// RVA: 0x16873E0
	void Dispose(bool disposing) { }

	// RVA: 0x168747C
	void .ctor(int length) { }

	// RVA: 0x16874B0
	void Reset() { }

	// RVA: 0x1687584
	Texture2D get_atlas() { }

	// RVA: 0x168758C
	Alloc Add(int count) { }

	// RVA: 0x168769C
	void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) { }

	// RVA: 0x1687D20
	bool get_MustCommit() { }

	// RVA: 0x1687D28
	void set_MustCommit(bool value) { }

	// RVA: 0x1687D30
	void Commit() { }

	// RVA: 0x1687E04
	void PrepareAtlas() { }

	// RVA: 0x1687FB4
	void .cctor() { }

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

	// RVA: 0x168806C
	void Add(ref NudgeJobData job) { }

	// RVA: 0x16880D0
	void Add(ref ConvertMeshJobData job) { }

	// RVA: 0x1688134
	void Add(ref CopyClosingMeshJobData job) { }

	// RVA: 0x1688198
	void CompleteNudgeJobs() { }

	// RVA: 0x1688664
	void CompleteConvertMeshJobs() { }

	// RVA: 0x1688A08
	void CompleteClosingMeshJobs() { }

	// RVA: 0x1688DAC
	bool get_disposed() { }

	// RVA: 0x1688DB4
	void set_disposed(bool value) { }

	// RVA: 0x1688DBC
	void Dispose() { }

	// RVA: 0x1688E5C
	void Dispose(bool disposing) { }

	// RVA: 0x16890C4
	void .ctor() { }

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

	// RVA: 0x1689244
	void .ctor(int capacity) { }

	// RVA: 0x168853C
	void Add(JobHandle job) { }

	// RVA: 0x16885C0
	JobHandle MergeAndReset() { }

	// RVA: 0x1689300
	bool get_disposed() { }

	// RVA: 0x1689308
	void set_disposed(bool value) { }

	// RVA: 0x1688FE8
	void Dispose() { }

	// RVA: 0x1689310
	void Dispose(bool disposing) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class LinkedPoolItem<T0> 
{
	// Fields
	internal T poolNext; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

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

	// RVA: 0x2FE4840
	void .ctor(System.Func<T> createFunc, System.Action<T> resetAction, int limit) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE42A4
	void set_Count(int value) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	T Get() { }

	// RVA: 0x309AF8C
	void Return(T item) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNode<T0> 
{
	// Fields
	public UnityEngine.UIElements.UIR.BasicNode<T> next; // 0x0
	public T data; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void InsertFirst(ref UnityEngine.UIElements.UIR.BasicNode<T>& first) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class BasicNodePool<T0> 
{
	// Methods

	// RVA: 0x2FE9A04
	void Reset(UnityEngine.UIElements.UIR.BasicNode<T> node) { }

	// RVA: 0x2FE704C
	UnityEngine.UIElements.UIR.BasicNode<T> Create() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: 
internal sealed class Allocator 
{
	// Methods

	// RVA: 0x1689CA4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1689D48
	internal MeshWriteData Invoke(UInt32 vertexCount, UInt32 indexCount, ref AllocMeshData allocatorData) { }

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

	// RVA: 0x1689B40
	MeshWriteData Allocate(UInt32 vertexCount, UInt32 indexCount) { }

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

	// RVA: 0x1689398
	Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags, bool isDynamicColor) { }

	// RVA: 0x1689480
	int LimitTextVertices(int vertexCount, bool logTruncation) { }

	// RVA: 0x16895E8
	void MakeText(MeshInfo meshInfo, Vector2 offset, AllocMeshData meshAlloc, VertexFlags flags, bool isDynamicColor) { }

	// RVA: 0x1689B6C
	void .cctor() { }

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

	// RVA: 0x2FE42A4
	void .ctor(int poolCapacity) { }

	// RVA: 0x2FE4574
	void Add(ref T data) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.List<Unity.Collections.NativeSlice<T>> GetPages() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x2FE3054
	bool get_disposed() { }

	// RVA: 0x2FE4234
	void set_disposed(bool value) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE4234
	void Dispose(bool disposing) { }

}

// Namespace: 
private struct OpacityIdUpdateJob 
{
	// Fields
	public Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> oldVerts; // 0x10
	public Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> newVerts; // 0x20
	public Color32 opacityData; // 0x30

	// Methods

	// RVA: 0x168A0A4
	void Execute(int i) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class OpacityIdAccelerator 
{
	// Fields
	private Unity.Collections.NativeArray<Unity.Jobs.JobHandle> m_Jobs; // 0x10
	private int m_NextJobIndex; // 0x20
	private bool <disposed>k__BackingField; // 0x24

	// Methods

	// RVA: 0x1689D5C
	void CreateJob(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> oldVerts, Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> newVerts, Color32 opacityData, int vertexCount) { }

	// RVA: 0x1689E5C
	void CompleteJobs() { }

	// RVA: 0x1689EF8
	bool get_disposed() { }

	// RVA: 0x1689F00
	void set_disposed(bool value) { }

	// RVA: 0x1689F08
	void Dispose() { }

	// RVA: 0x1689F98
	void Dispose(bool disposing) { }

	// RVA: 0x168A020
	void .ctor() { }

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

	// RVA: 0x168E93C
	void EnsureFits(int maxDepth) { }

	// RVA: 0x168E9D8
	void RegisterDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypes, RenderDataDirtyTypeClasses dirtyTypeClass) { }

	// RVA: 0x168EBFC
	void ClearDirty(VisualElement ve, RenderDataDirtyTypes dirtyTypesInverse) { }

	// RVA: 0x168EDE4
	void Reset() { }

}

// Namespace: 
private struct RenderChainStaticIndexAllocator 
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.UIElements.UIR.RenderChain> renderChains; // 0x0

	// Methods

	// RVA: 0x168EECC
	int AllocateIndex(RenderChain renderChain) { }

	// RVA: 0x168F024
	void FreeIndex(int index) { }

	// RVA: 0x168F0CC
	RenderChain AccessIndex(int index) { }

	// RVA: 0x168F184
	void .cctor() { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.RenderChain.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.UIR.RenderChainCommand> <>9__34_0; // 0x8
	public static System.Action<UnityEngine.UIElements.UIR.RenderChainCommand> <>9__34_1; // 0x10

	// Methods

	// RVA: 0x168F224
	void .cctor() { }

	// RVA: 0x168F290
	void .ctor() { }

	// RVA: 0x168F298
	RenderChainCommand <.ctor>b__34_0() { }

	// RVA: 0x168F2F0
	void <.ctor>b__34_1(RenderChainCommand cmd) { }

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

	// RVA: 0x168A180
	OpacityIdAccelerator get_opacityIdAccelerator() { }

	// RVA: 0x168A188
	void set_opacityIdAccelerator(OpacityIdAccelerator value) { }

	// RVA: 0x168A190
	void .cctor() { }

	// RVA: 0x168A440
	void .ctor(BaseVisualElementPanel panel) { }

	// RVA: 0x168A82C
	void Constructor(BaseVisualElementPanel panelObj, UIRenderDevice deviceObj, AtlasBase atlas, VectorImageManager vectorImageMan) { }

	// RVA: 0x168AD0C
	void Destructor() { }

	// RVA: 0x168B3A0
	bool get_disposed() { }

	// RVA: 0x168B3A8
	void set_disposed(bool value) { }

	// RVA: 0x168B3B0
	void Dispose() { }

	// RVA: 0x168B454
	void Dispose(bool disposing) { }

	// RVA: 0x168B498
	void ProcessChanges() { }

	// RVA: 0x168BC74
	void Render() { }

	// RVA: 0x168CB14
	void UIEOnChildAdded(VisualElement ve) { }

	// RVA: 0x168CED4
	void UIEOnChildrenReordered(VisualElement ve) { }

	// RVA: 0x168D098
	void UIEOnChildRemoving(VisualElement ve) { }

	// RVA: 0x168D1A0
	void UIEOnRenderHintsChanged(VisualElement ve) { }

	// RVA: 0x168CCF4
	void UIEOnClippingChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x168CD94
	void UIEOnOpacityChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x168D288
	void UIEOnColorChanged(VisualElement ve) { }

	// RVA: 0x168D31C
	void UIEOnTransformOrSizeChanged(VisualElement ve, bool transformChanged, bool clipRectSizeChanged) { }

	// RVA: 0x168CE34
	void UIEOnVisualsChanged(VisualElement ve, bool hierarchical) { }

	// RVA: 0x168D3BC
	void UIEOnOpacityIdChanged(VisualElement ve) { }

	// RVA: 0x168D450
	BaseVisualElementPanel get_panel() { }

	// RVA: 0x168D458
	void set_panel(BaseVisualElementPanel value) { }

	// RVA: 0x168D468
	UIRenderDevice get_device() { }

	// RVA: 0x168D470
	void set_device(UIRenderDevice value) { }

	// RVA: 0x168D480
	AtlasBase get_atlas() { }

	// RVA: 0x168D488
	void set_atlas(AtlasBase value) { }

	// RVA: 0x168D498
	VectorImageManager get_vectorImageManager() { }

	// RVA: 0x168D4A0
	void set_vectorImageManager(VectorImageManager value) { }

	// RVA: 0x168D4B0
	UnityEngine.UIElements.UIR.TempAllocator<UnityEngine.UIElements.Vertex> get_vertsPool() { }

	// RVA: 0x168D4B8
	void set_vertsPool(UnityEngine.UIElements.UIR.TempAllocator<UnityEngine.UIElements.Vertex> value) { }

	// RVA: 0x168D4C8
	UnityEngine.UIElements.UIR.TempAllocator<System.UInt16> get_indicesPool() { }

	// RVA: 0x168D4D0
	void set_indicesPool(UnityEngine.UIElements.UIR.TempAllocator<System.UInt16> value) { }

	// RVA: 0x168D4E0
	JobManager get_jobManager() { }

	// RVA: 0x168D4E8
	void set_jobManager(JobManager value) { }

	// RVA: 0x168D4F8
	UIRStylePainter get_painter() { }

	// RVA: 0x168D500
	void set_painter(UIRStylePainter value) { }

	// RVA: 0x168D510
	bool get_drawStats() { }

	// RVA: 0x168D518
	void set_drawStats(bool value) { }

	// RVA: 0x168D520
	bool get_drawInCameras() { }

	// RVA: 0x168D528
	void set_drawInCameras(bool value) { }

	// RVA: 0x168D530
	void set_defaultShader(Shader value) { }

	// RVA: 0x168D640
	void set_defaultWorldSpaceShader(Shader value) { }

	// RVA: 0x168BFB0
	Material GetStandardMaterial() { }

	// RVA: 0x168D750
	Material GetStandardWorldSpaceMaterial() { }

	// RVA: 0x168D8B0
	void EnsureFitsDepth(int depth) { }

	// RVA: 0x168D8BC
	void ChildWillBeRemoved(VisualElement ve) { }

	// RVA: 0x168D98C
	RenderChainCommand AllocCommand() { }

	// RVA: 0x168DA50
	void FreeCommand(RenderChainCommand cmd) { }

	// RVA: 0x168DB7C
	void OnRenderCommandAdded(RenderChainCommand command) { }

	// RVA: 0x168DC54
	void OnRenderCommandsRemoved(RenderChainCommand firstCommand, RenderChainCommand lastCommand) { }

	// RVA: 0x168DC88
	RenderNodeData AccessRenderNodeData(IntPtr obj) { }

	// RVA: 0x168DD5C
	void OnRenderNodeExecute(IntPtr obj) { }

	// RVA: 0x168DE0C
	void OnRegisterIntermediateRenderers(Camera camera) { }

	// RVA: 0x168E43C
	void OnRegisterIntermediateRendererMat(BaseRuntimePanel rtp, RenderChain renderChain, ref RenderNodeData rnd, Camera camera, int sameDistanceSortPriority) { }

	// RVA: 0x168E798
	void RepaintTexturedElements() { }

	// RVA: 0x168E87C
	void InsertTexture(VisualElement ve, Texture src, TextureId id, bool isAtlas) { }

	// RVA: 0x168B12C
	void ResetTextures(VisualElement ve) { }

	// RVA: 0x168C110
	void DrawStats() { }

	// RVA: 0x168B10C
	VisualElement GetFirstElementInPanel(VisualElement ve) { }

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

	// RVA: 0x168F2F4
	RenderChainCommand get_lastClosingOrLastCommand() { }

	// RVA: 0x168F30C
	bool AllocatesID(BMPAlloc alloc) { }

	// RVA: 0x168F3A0
	bool InheritsID(BMPAlloc alloc) { }

	// RVA: 0x168F41C
	bool get_isIgnoringDynamicColorHint() { }

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

	// RVA: 0x2FE360C
	Texture2D get_texture() { }

	// RVA: -1
	bool AllocateRect(int width, int height, out RectInt uvs) { }

	// RVA: -1
	void SetTexel(int x, int y, Color color) { }

	// RVA: 0x2FE41A8
	void UpdateTexture() { }

	// RVA: 0x168F428
	bool get_disposed() { }

	// RVA: 0x168F430
	void set_disposed(bool value) { }

	// RVA: 0x168F438
	void Dispose() { }

	// RVA: 0x168F4C8
	void Dispose(bool disposing) { }

	// RVA: 0x168F4E0
	void .ctor() { }

	// RVA: 0x168F4E8
	void .cctor() { }

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
	void .ctor(TextureFormat format, System.Func<UnityEngine.Color,T> convert, int initialSize, int maxSize) { }

	// RVA: 0x2FE4234
	void Dispose(bool disposing) { }

	// RVA: 0x2FE360C
	Texture2D get_texture() { }

	// RVA: -1
	bool AllocateRect(int width, int height, out RectInt uvs) { }

	// RVA: -1
	void SetTexel(int x, int y, Color color) { }

	// RVA: 0x2FE41A8
	void UpdateTexture() { }

	// RVA: 0x2FE41A8
	void CreateOrExpandTexture() { }

	// RVA: 0x309AF8C
	void CpuBlit(Unity.Collections.NativeArray<T> src, int srcWidth, int srcHeight, Unity.Collections.NativeArray<T> dst, int dstWidth, int dstHeight) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.ShaderInfoStorageRGBA32.<>c <>9; // 0x0

	// Methods

	// RVA: 0x168F754
	void .cctor() { }

	// RVA: 0x168F7C0
	void .ctor() { }

	// RVA: 0x168F7C8
	Color32 <.cctor>b__2_0(Color c) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorageRGBA32 
{
	// Fields
	private static readonly System.Func<UnityEngine.Color,UnityEngine.Color32> s_Convert; // 0x0

	// Methods

	// RVA: 0x168F5E0
	void .ctor(int initialSize, int maxSize) { }

	// RVA: 0x168F680
	void .cctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.ShaderInfoStorageRGBAFloat.<>c <>9; // 0x0

	// Methods

	// RVA: 0x168F944
	void .cctor() { }

	// RVA: 0x168F9B0
	void .ctor() { }

	// RVA: 0x168F9B8
	Color <.cctor>b__2_0(Color c) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class ShaderInfoStorageRGBAFloat 
{
	// Fields
	private static readonly System.Func<UnityEngine.Color,UnityEngine.Color> s_Convert; // 0x0

	// Methods

	// RVA: 0x168F7D0
	void .ctor(int initialSize, int maxSize) { }

	// RVA: 0x168F870
	void .cctor() { }

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

	// RVA: 0x168F9BC
	void .cctor() { }

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
	void .ctor(int poolCapacity, int excessMinCapacity, int excessMaxCapacity) { }

	// RVA: 0x2FE3054
	bool get_disposed() { }

	// RVA: 0x2FE4234
	void set_disposed(bool value) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE4234
	void Dispose(bool disposing) { }

	// RVA: 0x309AF8C
	Unity.Collections.NativeSlice<T> Alloc(int count) { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x2FE41A8
	void ReleaseExcess() { }

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

	// RVA: 0x168FC90
	bool Equals(object obj) { }

	// RVA: 0x168FD38
	bool Equals(TextCoreSettings other) { }

	// RVA: 0x168FE3C
	int GetHashCode() { }

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

	// RVA: 0x168FFD8
	bool get_disposed() { }

	// RVA: 0x168FFE0
	void set_disposed(bool value) { }

	// RVA: 0x168FFE8
	void Dispose() { }

	// RVA: 0x1690078
	void Dispose(bool disposing) { }

	// RVA: 0x1690128
	void .cctor() { }

	// RVA: 0x169026C
	void .ctor(int capacity) { }

	// RVA: 0x1690338
	void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x169046C
	void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	// RVA: 0x1690F08
	void Commit(RenderTexture dst) { }

	// RVA: 0x1690604
	void BeginBlit(RenderTexture dst) { }

	// RVA: 0x1690880
	void DoBlit(System.Collections.Generic.IList<UnityEngine.UIElements.UIR.TextureBlitter.BlitInfo> blitInfos, int startIndex) { }

	// RVA: 0x1690E80
	void EndBlit() { }

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

	// RVA: 0x16910F4
	void .cctor() { }

	// RVA: 0x16912A4
	void .ctor() { }

	// RVA: 0x169147C
	void Reset() { }

	// RVA: 0x1691710
	void StartNewBatch() { }

	// RVA: 0x1691788
	int IndexOf(TextureId id) { }

	// RVA: 0x1691898
	void MarkUsed(int slotIndex) { }

	// RVA: 0x16918F4
	int get_FreeSlots() { }

	// RVA: 0x16918FC
	void set_FreeSlots(int value) { }

	// RVA: 0x1691904
	int FindOldestSlot() { }

	// RVA: 0x1691A54
	void Bind(TextureId id, float sdfScale, int slot, MaterialPropertyBlock mat) { }

	// RVA: 0x16915A0
	void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.VectorImageRenderInfoPool.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.UIR.VectorImageRenderInfo> <>9__0_0; // 0x8
	public static System.Action<UnityEngine.UIElements.UIR.VectorImageRenderInfo> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x1691E2C
	void .cctor() { }

	// RVA: 0x1691E98
	void .ctor() { }

	// RVA: 0x1691EA0
	VectorImageRenderInfo <.ctor>b__0_0() { }

	// RVA: 0x1691F80
	void <.ctor>b__0_1(VectorImageRenderInfo vectorImageInfo) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageRenderInfoPool 
{
	// Methods

	// RVA: 0x1691C58
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class VectorImageRenderInfo 
{
	// Fields
	public int useCount; // 0x18
	public GradientRemap firstGradientRemap; // 0x20
	public Alloc gradientSettingsAlloc; // 0x28

	// Methods

	// RVA: 0x1691FC0
	void Reset() { }

	// RVA: 0x1691F2C
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.UIR.GradientRemapPool.<>c <>9; // 0x0
	public static System.Func<UnityEngine.UIElements.UIR.GradientRemap> <>9__0_0; // 0x8
	public static System.Action<UnityEngine.UIElements.UIR.GradientRemap> <>9__0_1; // 0x10

	// Methods

	// RVA: 0x16921CC
	void .cctor() { }

	// RVA: 0x1692238
	void .ctor() { }

	// RVA: 0x1692240
	GradientRemap <.ctor>b__0_0() { }

	// RVA: 0x1692320
	void <.ctor>b__0_1(GradientRemap gradientRemap) { }

}

// Namespace: UnityEngine.UIElements.UIR
internal class GradientRemapPool 
{
	// Methods

	// RVA: 0x1691FF8
	void .ctor() { }

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

	// RVA: 0x169239C
	void Reset() { }

	// RVA: 0x16922CC
	void .ctor() { }

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

	// RVA: 0x1692410
	Texture2D get_atlas() { }

	// RVA: 0x1692424
	void .ctor(AtlasBase atlas) { }

	// RVA: 0x16925F8
	bool get_disposed() { }

	// RVA: 0x1692600
	void set_disposed(bool value) { }

	// RVA: 0x1692608
	void Dispose() { }

	// RVA: 0x1692698
	void Dispose(bool disposing) { }

	// RVA: 0x16927CC
	void Commit() { }

	// RVA: 0x1692800
	GradientRemap AddUser(VectorImage vi, VisualElement context) { }

	// RVA: 0x1692934
	VectorImageRenderInfo Register(VectorImage vi, VisualElement context) { }

	// RVA: 0x1692E28
	void .cctor() { }

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

	// RVA: 0x1692F44
	bool Equals(BMPAlloc other) { }

	// RVA: 0x168F390
	bool IsValid() { }

	// RVA: 0x1692F7C
	string ToString() { }

	// RVA: 0x1693070
	void .cctor() { }

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

	// RVA: 0x16930C0
	void Construct(int pageHeight, int entryWidth, int entryHeight) { }

	// RVA: 0x16931F0
	void ForceFirstAlloc(UInt16 firstPageX, UInt16 firstPageY) { }

	// RVA: 0x16932F4
	BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	// RVA: 0x16937C8
	void Free(BMPAlloc alloc) { }

	// RVA: 0x1693938
	int get_entryWidth() { }

	// RVA: 0x1693940
	int get_entryHeight() { }

	// RVA: 0x1693948
	void GetAllocPageAtlasLocation(int page, out UInt16 x, out UInt16 y) { }

	// RVA: 0x1693764
	Byte CountTrailingZeroes(UInt32 val) { }

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

	// RVA: 0x16939DC
	int get_pageWidth() { }

	// RVA: 0x16939E4
	int get_pageHeight() { }

	// RVA: 0x16939EC
	Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) { }

	// RVA: 0x1693A84
	int AllocToConstantBufferIndex(BMPAlloc alloc) { }

	// RVA: 0x1693AF0
	bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	// RVA: 0x1693D04
	Unity.Collections.NativeSlice<UnityEngine.UIElements.UIR.Transform3x4> get_transformConstants() { }

	// RVA: 0x1693D58
	Unity.Collections.NativeSlice<UnityEngine.Vector4> get_clipRectConstants() { }

	// RVA: 0x1693DAC
	Texture get_atlas() { }

	// RVA: 0x1693E6C
	void Construct() { }

	// RVA: 0x169415C
	void ReallyCreateStorage() { }

	// RVA: 0x1695268
	void Dispose() { }

	// RVA: 0x169537C
	void IssuePendingStorageChanges() { }

	// RVA: 0x1695394
	BMPAlloc AllocTransform() { }

	// RVA: 0x169552C
	BMPAlloc AllocClipRect() { }

	// RVA: 0x16956C4
	BMPAlloc AllocOpacity() { }

	// RVA: 0x169574C
	BMPAlloc AllocColor() { }

	// RVA: 0x16957D4
	BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	// RVA: 0x1694630
	void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	// RVA: 0x1694940
	void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	// RVA: 0x1694B6C
	void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	// RVA: 0x1694D04
	void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext) { }

	// RVA: 0x1694F0C
	void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext) { }

	// RVA: 0x169585C
	void FreeTransform(BMPAlloc alloc) { }

	// RVA: 0x169591C
	void FreeClipRect(BMPAlloc alloc) { }

	// RVA: 0x16959DC
	void FreeOpacity(BMPAlloc alloc) { }

	// RVA: 0x1695A9C
	void FreeColor(BMPAlloc alloc) { }

	// RVA: 0x1695B5C
	void FreeTextCoreSettings(BMPAlloc alloc) { }

	// RVA: 0x1695C1C
	Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x1695D80
	Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x1695EE4
	Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x1696018
	Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	// RVA: 0x169614C
	Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	// RVA: 0x1696280
	void .cctor() { }

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

	// RVA: 0x1696434
	void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform) { }

	// RVA: 0x16965FC
	void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result) { }

	// RVA: 0x1696810
	bool IsParentOrAncestorOf(VisualElement ve, VisualElement child) { }

	// RVA: 0x16968A8
	ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats) { }

	// RVA: 0x169AA0C
	void InvokeGenerateVisualContent(VisualElement ve, MeshGenerationContext ctx) { }

	// RVA: 0x169BBAC
	Material CreateBlitShader(float colorConversion) { }

	// RVA: 0x169B664
	Material GetBlitMaterial(RenderTargetMode mode) { }

	// RVA: 0x169BE18
	void ClosePaintElement(VisualElement ve, ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats) { }

	// RVA: 0x169AC28
	void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex>& verts, out Unity.Collections.NativeSlice<System.UInt16>& indices, out UInt16 indexOffset, ref ChainBuilderStats stats) { }

	// RVA: 0x169C04C
	void UpdateOpacityId(VisualElement ve, RenderChain renderChain) { }

	// RVA: 0x169C158
	void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh) { }

	// RVA: 0x169C278
	bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device) { }

	// RVA: 0x169C648
	void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count) { }

	// RVA: 0x169B070
	RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x169B9EC
	RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x169AD20
	void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	// RVA: 0x169B2C0
	void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	// RVA: 0x169B1A8
	void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) { }

	// RVA: 0x169B504
	void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) { }

	// RVA: 0x1697E78
	void ResetCommands(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x169C764
	void .cctor() { }

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

	// RVA: 0x169C90C
	void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x169D198
	void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x169D76C
	void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x169DA4C
	void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x169E018
	void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x169E728
	Matrix4x4 GetTransformIDTransformInfo(VisualElement ve) { }

	// RVA: 0x169E8C0
	Vector4 GetClipRectIDClipInfo(VisualElement ve) { }

	// RVA: 0x169EADC
	UInt32 DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState) { }

	// RVA: 0x16A05C8
	UInt32 DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x169CA00
	void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, UInt32 dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats) { }

	// RVA: 0x169D2A0
	void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, UInt32 dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration) { }

	// RVA: 0x169D7F8
	void OnColorChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, ref ChainBuilderStats stats) { }

	// RVA: 0x169DB14
	void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, UInt32 dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats) { }

	// RVA: 0x169E1F4
	void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, UInt32 dirtyID, bool parentHierarchyHidden, bool hierarchical, ref ChainBuilderStats stats) { }

	// RVA: 0x16A1584
	bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x169E130
	bool IsElementHierarchyHidden(VisualElement ve) { }

	// RVA: 0x169F3C8
	VisualElement GetLastDeepestChild(VisualElement ve) { }

	// RVA: 0x16A144C
	ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x169F258
	bool UpdateLocalFlipsWinding(VisualElement ve) { }

	// RVA: 0x16A1C24
	void UpdateWorldFlipsWinding(VisualElement ve) { }

	// RVA: 0x16A1A4C
	void UpdateZeroScaling(VisualElement ve) { }

	// RVA: 0x169F450
	bool NeedsTransformID(VisualElement ve) { }

	// RVA: 0x169F4A0
	bool NeedsColorID(VisualElement ve) { }

	// RVA: 0x16A1C84
	bool NeedsTextCoreSettings(VisualElement ve) { }

	// RVA: 0x169F4C4
	bool InitColorIDs(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x169FE64
	void SetColorValues(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x16A1D4C
	void .cctor() { }

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

	// RVA: 0x16A1DA0
	MeshWriteData GetPooledMeshWriteData() { }

	// RVA: 0x16A1E98
	MeshWriteData AllocRawVertsIndices(UInt32 vertexCount, UInt32 indexCount, ref AllocMeshData allocatorData) { }

	// RVA: 0x16A1F58
	MeshWriteData AllocThroughDrawMesh(UInt32 vertexCount, UInt32 indexCount, ref AllocMeshData allocatorData) { }

	// RVA: 0x16A23F0
	void .ctor(RenderChain renderChain) { }

	// RVA: 0x16A26F8
	MeshGenerationContext get_meshGenerationContext() { }

	// RVA: 0x16A2700
	VisualElement get_currentElement() { }

	// RVA: 0x16A2708
	void set_currentElement(VisualElement value) { }

	// RVA: 0x169AC20
	System.Collections.Generic.List<UnityEngine.UIElements.UIR.Implementation.UIRStylePainter.Entry> get_entries() { }

	// RVA: 0x169B2A4
	ClosingInfo get_closingInfo() { }

	// RVA: 0x16A2718
	int get_totalVertices() { }

	// RVA: 0x16A2720
	void set_totalVertices(int value) { }

	// RVA: 0x16A2728
	int get_totalIndices() { }

	// RVA: 0x16A2730
	void set_totalIndices(int value) { }

	// RVA: 0x16981EC
	void Begin(VisualElement ve) { }

	// RVA: 0x169BB2C
	void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd) { }

	// RVA: 0x169AFD0
	void LandClipRegisterMesh(Unity.Collections.NativeSlice<UnityEngine.UIElements.Vertex> vertices, Unity.Collections.NativeSlice<System.UInt16> indices, int indexOffset) { }

	// RVA: 0x16A1F6C
	MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshFlags flags) { }

	// RVA: 0x16A2738
	void TryAtlasTexture(Texture texture, MeshFlags flags, out Rect outUVRegion, out bool outIsAtlas, out TextureId outTextureId, out VertexFlags outAddFlags) { }

	// RVA: 0x16A294C
	void BuildEntryFromNativeMesh(MeshWriteDataInterface meshData, Texture texture, TextureId textureId, bool isAtlas, Material material, MeshFlags flags, Rect uvRegion, VertexFlags addFlags) { }

	// RVA: 0x16A2D54
	void BuildGradientEntryFromNativeMesh(MeshWriteDataInterface meshData, TextureId svgTextureId) { }

	// RVA: 0x16A30A0
	void BuildRawEntryFromNativeMesh(MeshWriteDataInterface meshData) { }

	// RVA: 0x16A3274
	void DrawText(TextElement te) { }

	// RVA: 0x16A3310
	void DrawTextInfo(TextInfo textInfo, Vector2 offset, bool useHints) { }

	// RVA: 0x16A39A4
	void DrawRectangle(RectangleParams rectParams) { }

	// RVA: 0x16A46E0
	void DrawBorder(BorderParams borderParams) { }

	// RVA: 0x16A4784
	void DrawImmediate(Action callback, bool cullingEnabled) { }

	// RVA: 0x16A487C
	VisualElement get_visualElement() { }

	// RVA: 0x16985D8
	void DrawVisualElementBackground() { }

	// RVA: 0x16A499C
	void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	// RVA: 0x16A6088
	void StampRectangleWithSubRect(RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV) { }

	// RVA: 0x1699CD0
	void DrawVisualElementBorder() { }

	// RVA: 0x169A818
	void ApplyVisualElementClipping() { }

	// RVA: 0x16A6FE4
	UInt16[] AdjustSpriteWinding(Vector2[] vertices, UInt16[] indices) { }

	// RVA: 0x16A40E4
	void DrawSprite(RectangleParams rectParams) { }

	// RVA: 0x16A4480
	void ApplyInset(ref NativeRectParams rectParams, Texture tex) { }

	// RVA: 0x16A3CE4
	void DrawVectorImage(RectangleParams rectParams) { }

	// RVA: 0x16A7318
	void MakeVectorGraphics(RectangleParams rectParams, bool isUsingGradients, TextureId svgTexture, int settingIndexOffset, out int finalVertexCount, out int finalIndexCount) { }

	// RVA: 0x169AB54
	void Reset() { }

	// RVA: 0x16A7718
	void ValidateMeshWriteData() { }

	// RVA: 0x16A6664
	void GenerateStencilClipEntryForRoundedRectBackground() { }

	// RVA: 0x16A635C
	void GenerateStencilClipEntryForSVGBackground() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal abstract class HierarchyTraversal 
{
	// Methods

	// RVA: 0x16A7C0C
	void Traverse(VisualElement element) { }

	// RVA: 0x2FE45DC
	void TraverseRecursive(VisualElement element, int depth) { }

	// RVA: 0x16A7C1C
	void Recurse(VisualElement element, int depth) { }

	// RVA: 0x16A7CF4
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class InitialStyle 
{
	// Fields
	private static ComputedStyle s_InitialStyle; // 0x0

	// Methods

	// RVA: 0x16A7CFC
	ref ComputedStyle Get() { }

	// RVA: 0x16A7D70
	ComputedStyle Acquire() { }

	// RVA: 0x16A7E1C
	void .cctor() { }

	// RVA: 0x16A8B4C
	Align get_alignContent() { }

	// RVA: 0x16A8BC8
	Align get_alignItems() { }

	// RVA: 0x16A8C44
	Align get_alignSelf() { }

	// RVA: 0x16A8CC0
	Color get_backgroundColor() { }

	// RVA: 0x16A8D40
	Background get_backgroundImage() { }

	// RVA: 0x16A8DCC
	BackgroundPosition get_backgroundPositionX() { }

	// RVA: 0x16A8E50
	BackgroundPosition get_backgroundPositionY() { }

	// RVA: 0x16A8ED4
	BackgroundRepeat get_backgroundRepeat() { }

	// RVA: 0x16A8F50
	BackgroundSize get_backgroundSize() { }

	// RVA: 0x16A8FE4
	Color get_borderBottomColor() { }

	// RVA: 0x16A9064
	Length get_borderBottomLeftRadius() { }

	// RVA: 0x16A90E0
	Length get_borderBottomRightRadius() { }

	// RVA: 0x16A915C
	float get_borderBottomWidth() { }

	// RVA: 0x16A91D8
	Color get_borderLeftColor() { }

	// RVA: 0x16A9258
	float get_borderLeftWidth() { }

	// RVA: 0x16A92D4
	Color get_borderRightColor() { }

	// RVA: 0x16A9354
	float get_borderRightWidth() { }

	// RVA: 0x16A93D0
	Color get_borderTopColor() { }

	// RVA: 0x16A9450
	Length get_borderTopLeftRadius() { }

	// RVA: 0x16A94CC
	Length get_borderTopRightRadius() { }

	// RVA: 0x16A9548
	float get_borderTopWidth() { }

	// RVA: 0x16A95C4
	Length get_bottom() { }

	// RVA: 0x16A9640
	Color get_color() { }

	// RVA: 0x16A96BC
	Cursor get_cursor() { }

	// RVA: 0x16A9750
	DisplayStyle get_display() { }

	// RVA: 0x16A97CC
	Length get_flexBasis() { }

	// RVA: 0x16A9848
	FlexDirection get_flexDirection() { }

	// RVA: 0x16A98C4
	float get_flexGrow() { }

	// RVA: 0x16A9940
	float get_flexShrink() { }

	// RVA: 0x16A99BC
	Wrap get_flexWrap() { }

	// RVA: 0x16A9A38
	Length get_fontSize() { }

	// RVA: 0x16A9AB0
	Length get_height() { }

	// RVA: 0x16A9B2C
	Justify get_justifyContent() { }

	// RVA: 0x16A9BA8
	Length get_left() { }

	// RVA: 0x16A9C24
	Length get_letterSpacing() { }

	// RVA: 0x16A9C9C
	Length get_marginBottom() { }

	// RVA: 0x16A9D18
	Length get_marginLeft() { }

	// RVA: 0x16A9D94
	Length get_marginRight() { }

	// RVA: 0x16A9E10
	Length get_marginTop() { }

	// RVA: 0x16A9E8C
	Length get_maxHeight() { }

	// RVA: 0x16A9F08
	Length get_maxWidth() { }

	// RVA: 0x16A9F84
	Length get_minHeight() { }

	// RVA: 0x16AA000
	Length get_minWidth() { }

	// RVA: 0x16AA07C
	float get_opacity() { }

	// RVA: 0x16AA0F8
	OverflowInternal get_overflow() { }

	// RVA: 0x16AA174
	Length get_paddingBottom() { }

	// RVA: 0x16AA1F0
	Length get_paddingLeft() { }

	// RVA: 0x16AA26C
	Length get_paddingRight() { }

	// RVA: 0x16AA2E8
	Length get_paddingTop() { }

	// RVA: 0x16AA364
	Position get_position() { }

	// RVA: 0x16AA3E0
	Length get_right() { }

	// RVA: 0x16AA45C
	Rotate get_rotate() { }

	// RVA: 0x16AA4F0
	Scale get_scale() { }

	// RVA: 0x16AA570
	TextOverflow get_textOverflow() { }

	// RVA: 0x16AA5EC
	TextShadow get_textShadow() { }

	// RVA: 0x16AA67C
	Length get_top() { }

	// RVA: 0x16AA6F8
	TransformOrigin get_transformOrigin() { }

	// RVA: 0x16AA78C
	System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDelay() { }

	// RVA: 0x16AA808
	System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> get_transitionDuration() { }

	// RVA: 0x16AA884
	System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> get_transitionProperty() { }

	// RVA: 0x16AA900
	System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> get_transitionTimingFunction() { }

	// RVA: 0x16AA97C
	Translate get_translate() { }

	// RVA: 0x16AAA10
	Color get_unityBackgroundImageTintColor() { }

	// RVA: 0x16AAA90
	Font get_unityFont() { }

	// RVA: 0x16AAB08
	FontDefinition get_unityFontDefinition() { }

	// RVA: 0x16AAB84
	FontStyle get_unityFontStyleAndWeight() { }

	// RVA: 0x16AABFC
	OverflowClipBox get_unityOverflowClipBox() { }

	// RVA: 0x16AAC78
	Length get_unityParagraphSpacing() { }

	// RVA: 0x16AACF0
	int get_unitySliceBottom() { }

	// RVA: 0x16AAD6C
	int get_unitySliceLeft() { }

	// RVA: 0x16AADE8
	int get_unitySliceRight() { }

	// RVA: 0x16AAE64
	float get_unitySliceScale() { }

	// RVA: 0x16AAEE0
	int get_unitySliceTop() { }

	// RVA: 0x16AAF5C
	TextAnchor get_unityTextAlign() { }

	// RVA: 0x16AAFD4
	Color get_unityTextOutlineColor() { }

	// RVA: 0x16AB050
	float get_unityTextOutlineWidth() { }

	// RVA: 0x16AB0C8
	TextOverflowPosition get_unityTextOverflowPosition() { }

	// RVA: 0x16AB144
	Visibility get_visibility() { }

	// RVA: 0x16AB1BC
	WhiteSpace get_whiteSpace() { }

	// RVA: 0x16AB234
	Length get_width() { }

	// RVA: 0x16AB2B0
	Length get_wordSpacing() { }

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

	// RVA: 0x16AB328
	void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16ABB88
	void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16ABE14
	void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16AC058
	void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16AC268
	void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16AC714
	void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16AC9A0
	void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16ACA90
	void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16AD7A4
	void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16AD9B4
	void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle) { }

	// RVA: 0x16AC33C
	bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis) { }

	// RVA: 0x16ABF04
	void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	// RVA: 0x16AB400
	void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY) { }

	// RVA: 0x16AD908
	void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize) { }

	// RVA: 0x16AC804
	void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left) { }

	// RVA: 0x16AC1A4
	void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left) { }

	// RVA: 0x16ABC80
	void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left) { }

	// RVA: 0x16ADA70
	void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth) { }

	// RVA: 0x16ACBEC
	void CompileTransition(StylePropertyReader reader, out System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDelay, out System.Collections.Generic.List<UnityEngine.UIElements.TimeValue>& outDuration, out System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName>& outProperty, out System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction>& outTimingFunction) { }

	// RVA: 0x16AF628
	void .cctor() { }

	// RVA: 0x16AE130
	void <CompileBackgroundPosition>g__SwapKeyword|16_0(ref BackgroundPositionKeyword a, ref BackgroundPositionKeyword b) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StylePropertyCache 
{
	// Fields
	internal static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_PropertySyntaxCache; // 0x0
	internal static readonly System.Collections.Generic.Dictionary<System.String,System.String> s_NonTerminalValues; // 0x8

	// Methods

	// RVA: 0x16AF79C
	bool TryGetSyntax(string name, out string syntax) { }

	// RVA: 0x16AF848
	bool TryGetNonTerminalValue(string name, out string syntax) { }

	// RVA: 0x16AF8F4
	void .cctor() { }

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

	// RVA: 0x16AE398
	bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue) { }

	// RVA: 0x16B0D40
	bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) { }

	// RVA: 0x16B0ED8
	bool IsAnimatable(StylePropertyId id) { }

	// RVA: 0x16B0F8C
	void .cctor() { }

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
internal struct Dimension 
{
	// Fields
	public Unit unit; // 0x10
	public float value; // 0x14

	// Methods

	// RVA: 0x16B3AE4
	void .ctor(float value, Unit unit) { }

	// RVA: 0x16AE0F4
	Length ToLength() { }

	// RVA: 0x16B3AF0
	TimeValue ToTime() { }

	// RVA: 0x16B3B2C
	Angle ToAngle() { }

	// RVA: 0x16B3C00
	bool op_Equality(Dimension lhs, Dimension rhs) { }

	// RVA: 0x16B3C20
	bool Equals(Dimension other) { }

	// RVA: 0x16B3C40
	bool Equals(object obj) { }

	// RVA: 0x16B3CDC
	int GetHashCode() { }

	// RVA: 0x16B3D28
	string ToString() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct ScalableImage 
{
	// Fields
	public Texture2D normalImage; // 0x10
	public Texture2D highResolutionImage; // 0x18

	// Methods

	// RVA: 0x16B3E60
	string ToString() { }

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

	// RVA: 0x16B3FF0
	bool IsNull() { }

}

// Namespace: 
internal sealed class GetCursorIdFunction 
{
	// Methods

	// RVA: 0x16B8504
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x16B8628
	internal int Invoke(StyleSheet sheet, StyleValueHandle handle) { }

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

	// RVA: 0x16B413C
	StyleProperty get_property() { }

	// RVA: 0x16B4144
	void set_property(StyleProperty value) { }

	// RVA: 0x16B414C
	StylePropertyId get_propertyId() { }

	// RVA: 0x16B4154
	void set_propertyId(StylePropertyId value) { }

	// RVA: 0x16B415C
	int get_valueCount() { }

	// RVA: 0x16B4164
	void set_valueCount(int value) { }

	// RVA: 0x16B416C
	float get_dpiScaling() { }

	// RVA: 0x16B4174
	void set_dpiScaling(float value) { }

	// RVA: 0x16B417C
	void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling) { }

	// RVA: 0x16B4670
	void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling) { }

	// RVA: 0x16B46D8
	StylePropertyId MoveNextProperty() { }

	// RVA: 0x16ADF54
	StylePropertyValue GetValue(int index) { }

	// RVA: 0x16ADD04
	StyleValueType GetValueType(int index) { }

	// RVA: 0x16ADBC4
	bool IsValueType(int index, StyleValueType type) { }

	// RVA: 0x16ADC60
	bool IsKeyword(int index, StyleValueKeyword keyword) { }

	// RVA: 0x16AE314
	string ReadAsString(int index) { }

	// RVA: 0x16ADD94
	Length ReadLength(int index) { }

	// RVA: 0x16AE264
	TimeValue ReadTimeValue(int index) { }

	// RVA: 0x16B481C
	Translate ReadTranslate(int index) { }

	// RVA: 0x16B4BF0
	TransformOrigin ReadTransformOrigin(int index) { }

	// RVA: 0x16B4EDC
	Rotate ReadRotate(int index) { }

	// RVA: 0x16B5134
	Scale ReadScale(int index) { }

	// RVA: 0x16ADEC8
	float ReadFloat(int index) { }

	// RVA: 0x16B5450
	int ReadInt(int index) { }

	// RVA: 0x16AE144
	Color ReadColor(int index) { }

	// RVA: 0x16ADFD0
	int ReadEnum(StyleEnumType enumType, int index) { }

	// RVA: 0x16B54F4
	FontDefinition ReadFontDefinition(int index) { }

	// RVA: 0x16B5A9C
	Font ReadFont(int index) { }

	// RVA: 0x16B5E20
	Background ReadBackground(int index) { }

	// RVA: 0x16B6A0C
	Cursor ReadCursor(int index) { }

	// RVA: 0x16B6DF8
	TextShadow ReadTextShadow(int index) { }

	// RVA: 0x16B7294
	BackgroundPosition ReadBackgroundPositionX(int index) { }

	// RVA: 0x16B738C
	BackgroundPosition ReadBackgroundPositionY(int index) { }

	// RVA: 0x16B72B0
	BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword) { }

	// RVA: 0x16B7530
	BackgroundRepeat ReadBackgroundRepeat(int index) { }

	// RVA: 0x16B7754
	BackgroundSize ReadBackgroundSize(int index) { }

	// RVA: 0x16B7A7C
	void ReadListEasingFunction(System.Collections.Generic.List<UnityEngine.UIElements.EasingFunction> list, int index) { }

	// RVA: 0x16B7C84
	void ReadListTimeValue(System.Collections.Generic.List<UnityEngine.UIElements.TimeValue> list, int index) { }

	// RVA: 0x16B7E48
	void ReadListStylePropertyName(System.Collections.Generic.List<UnityEngine.UIElements.StylePropertyName> list, int index) { }

	// RVA: 0x16B4274
	void LoadProperties() { }

	// RVA: 0x16B4714
	void SetCurrentProperty() { }

	// RVA: 0x16B4D28
	TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue) { }

	// RVA: 0x16B7FF8
	Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal) { }

	// RVA: 0x16B4954
	Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x16B524C
	Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3) { }

	// RVA: 0x16B5014
	Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4) { }

	// RVA: 0x16B82F0
	bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, out int intValue) { }

	// RVA: 0x16B8174
	int ReadEnum(StyleEnumType enumType, StylePropertyValue value) { }

	// RVA: 0x16B8264
	Angle ReadAngle(StylePropertyValue value) { }

	// RVA: 0x16B73A8
	BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword) { }

	// RVA: 0x16B768C
	BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x16B7844
	BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2) { }

	// RVA: 0x16B60F4
	bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source) { }

	// RVA: 0x16B83E4
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct MatchResultInfo 
{
	// Fields
	public readonly bool success; // 0x10
	public readonly PseudoStates triggerPseudoMask; // 0x14
	public readonly PseudoStates dependencyPseudoMask; // 0x18

	// Methods

	// RVA: 0x16B863C
	void .ctor(bool success, PseudoStates triggerPseudoMask, PseudoStates dependencyPseudoMask) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal struct SelectorMatchRecord 
{
	// Fields
	public StyleSheet sheet; // 0x10
	public int styleSheetIndexInStack; // 0x18
	public StyleComplexSelector complexSelector; // 0x20

	// Methods

	// RVA: 0x16B8648
	void .ctor(StyleSheet sheet, int styleSheetIndexInStack) { }

	// RVA: 0x16B8678
	int Compare(SelectorMatchRecord a, SelectorMatchRecord b) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSelectorHelper 
{
	// Methods

	// RVA: 0x16B8774
	MatchResultInfo MatchesSelector(VisualElement element, StyleSelector selector) { }

	// RVA: 0x16B8A5C
	bool MatchRightToLeft(VisualElement element, StyleComplexSelector complexSelector, System.Action<UnityEngine.UIElements.VisualElement,UnityEngine.UIElements.StyleSheets.MatchResultInfo> processResult) { }

	// RVA: 0x16B8CB0
	void FastLookup(System.Collections.Generic.IDictionary<System.String,UnityEngine.UIElements.StyleComplexSelector> table, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, StyleMatchingContext context, string input, ref SelectorMatchRecord record) { }

	// RVA: 0x16B8EA4
	void FindMatches(StyleMatchingContext context, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchedSelectors, int parentSheetIndex) { }

}

// Namespace: 
private struct SheetHandleKey 
{
	// Fields
	public readonly int sheetInstanceID; // 0x10
	public readonly int index; // 0x14

	// Methods

	// RVA: 0x16B960C
	void .ctor(StyleSheet sheet, int index) { }

}

// Namespace: 
private class SheetHandleKeyComparer 
{
	// Methods

	// RVA: 0x16B9930
	bool Equals(SheetHandleKey x, SheetHandleKey y) { }

	// RVA: 0x16B993C
	int GetHashCode(SheetHandleKey key) { }

	// RVA: 0x16B9928
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetCache 
{
	// Fields
	private static SheetHandleKeyComparer s_Comparer; // 0x0
	private static System.Collections.Generic.Dictionary<UnityEngine.UIElements.StyleSheets.StyleSheetCache.SheetHandleKey,UnityEngine.UIElements.StyleSheets.StylePropertyId[]> s_RulePropertyIdsCache; // 0x8

	// Methods

	// RVA: 0x16B9440
	StylePropertyId[] GetPropertyIds(StyleSheet sheet, int ruleIndex) { }

	// RVA: 0x16B974C
	StylePropertyId[] GetPropertyIds(StyleRule rule) { }

	// RVA: 0x16B9644
	StylePropertyId GetPropertyId(StyleRule rule, int index) { }

	// RVA: 0x16B9838
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetColor 
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.Color32> s_NameToColor; // 0x0

	// Methods

	// RVA: 0x16B9984
	bool TryGetColor(string name, out Color color) { }

	// RVA: 0x16B9A98
	Color32 HexToColor32(UInt32 color) { }

	// RVA: 0x16B9AAC
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal static class StyleSheetExtensions 
{
	// Methods

	// RVA: 0x16BB91C
	string ReadAsString(StyleSheet sheet, StyleValueHandle handle) { }

	// RVA: 0x16BBC84
	bool IsVarFunction(StyleValueHandle handle) { }

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

	// RVA: 0x16BBCBC
	bool get_success() { }

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

	// RVA: 0x2FE3174
	bool MatchKeyword(string keyword) { }

	// RVA: 0x2FE3054
	bool MatchNumber() { }

	// RVA: 0x2FE3054
	bool MatchInteger() { }

	// RVA: 0x2FE3054
	bool MatchLength() { }

	// RVA: 0x2FE3054
	bool MatchPercentage() { }

	// RVA: 0x2FE3054
	bool MatchColor() { }

	// RVA: 0x2FE3054
	bool MatchResource() { }

	// RVA: 0x2FE3054
	bool MatchUrl() { }

	// RVA: 0x2FE3054
	bool MatchTime() { }

	// RVA: 0x2FE3054
	bool MatchAngle() { }

	// RVA: 0x2FE3054
	bool MatchCustomIdent() { }

	// RVA: 0x2FE32D4
	int get_valueCount() { }

	// RVA: 0x2FE3054
	bool get_isCurrentVariable() { }

	// RVA: 0x2FE3054
	bool get_isCurrentComma() { }

	// RVA: 0x16BBCCC
	bool get_hasCurrent() { }

	// RVA: 0x16BBD00
	int get_currentIndex() { }

	// RVA: 0x16BBD08
	void set_currentIndex(int value) { }

	// RVA: 0x16BBD10
	int get_matchedVariableCount() { }

	// RVA: 0x16BBD18
	void set_matchedVariableCount(int value) { }

	// RVA: 0x16BBD20
	void Initialize() { }

	// RVA: 0x16BBD78
	void MoveNext() { }

	// RVA: 0x16BBDC0
	void SaveContext() { }

	// RVA: 0x16BBE2C
	void RestoreContext() { }

	// RVA: 0x16BBE98
	void DropContext() { }

	// RVA: 0x16BBEFC
	bool Match(Expression exp) { }

	// RVA: 0x16BBFBC
	bool MatchExpression(Expression exp) { }

	// RVA: 0x16BC204
	bool MatchExpressionWithMultiplier(Expression exp) { }

	// RVA: 0x16BC6A4
	bool MatchGroup(Expression exp) { }

	// RVA: 0x16BC3A0
	bool MatchCombinator(Expression exp) { }

	// RVA: 0x16BC75C
	bool MatchOr(Expression exp) { }

	// RVA: 0x16BC8CC
	bool MatchOrOr(Expression exp) { }

	// RVA: 0x16BC8E8
	bool MatchAndAnd(Expression exp) { }

	// RVA: 0x16BC990
	int MatchMany(Expression exp) { }

	// RVA: 0x16BCD38
	int MatchManyByOrder(Expression exp, Int32* matchOrder) { }

	// RVA: 0x16BC924
	bool MatchJuxtaposition(Expression exp) { }

	// RVA: 0x16BC574
	bool MatchDataType(Expression exp) { }

	// RVA: 0x16BCEF0
	void .ctor() { }

	// RVA: 0x16BCF7C
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements.StyleSheets
internal class StylePropertyValueMatcher 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> m_Values; // 0x20

	// Methods

	// RVA: 0x16BD020
	StylePropertyValue get_current() { }

	// RVA: 0x16BD0C4
	int get_valueCount() { }

	// RVA: 0x16BD110
	bool get_isCurrentVariable() { }

	// RVA: 0x16BD118
	bool get_isCurrentComma() { }

	// RVA: 0x16BD1D4
	MatchResult Match(Expression exp, System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.StylePropertyValue> values) { }

	// RVA: 0x16BD4F0
	bool MatchKeyword(string keyword) { }

	// RVA: 0x16BD624
	bool MatchNumber() { }

	// RVA: 0x16BD6D0
	bool MatchInteger() { }

	// RVA: 0x16BD77C
	bool MatchLength() { }

	// RVA: 0x16BD908
	bool MatchPercentage() { }

	// RVA: 0x16BDA94
	bool MatchColor() { }

	// RVA: 0x16BDBF4
	bool MatchResource() { }

	// RVA: 0x16BDCA0
	bool MatchUrl() { }

	// RVA: 0x16BDD50
	bool MatchTime() { }

	// RVA: 0x16BDE30
	bool MatchCustomIdent() { }

	// RVA: 0x16BDF78
	bool MatchAngle() { }

	// RVA: 0x16BE10C
	void .ctor() { }

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

	// RVA: 0x16BE1D0
	void .ctor(ExpressionType type) { }

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

	// RVA: 0x16BBFB4
	ExpressionMultiplierType get_type() { }

	// RVA: 0x16BE28C
	void set_type(ExpressionMultiplierType value) { }

	// RVA: 0x16BE230
	void .ctor(ExpressionMultiplierType type) { }

	// RVA: 0x16BE2E8
	void SetType(ExpressionMultiplierType value) { }

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

	// RVA: 0x16BE344
	Expression Parse(string syntax) { }

	// RVA: 0x16BF114
	Expression ParseExpression(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x16BFD20
	void ProcessCombinatorStack() { }

	// RVA: 0x16BF59C
	Expression ParseTerm(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x16BFB4C
	ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x16BF7C8
	Expression ParseGroup(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x16C000C
	Expression ParseDataType(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x16C0AE8
	Expression ParseNonTerminalValue(string syntax) { }

	// RVA: 0x16C0C88
	Expression ParseProperty(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x16C0780
	void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier) { }

	// RVA: 0x16C105C
	void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max) { }

	// RVA: 0x16C0A04
	void EatSpace(StyleSyntaxTokenizer tokenizer) { }

	// RVA: 0x16BFFF8
	bool IsExpressionEnd(StyleSyntaxToken token) { }

	// RVA: 0x16C09F0
	bool IsCombinator(StyleSyntaxToken token) { }

	// RVA: 0x16C1044
	bool IsMultiplier(StyleSyntaxToken token) { }

	// RVA: 0x16C1200
	void .ctor() { }

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

	// RVA: 0x16C1388
	void .ctor(StyleSyntaxTokenType t) { }

	// RVA: 0x16C13B8
	void .ctor(StyleSyntaxTokenType type, string text) { }

	// RVA: 0x16C13E8
	void .ctor(StyleSyntaxTokenType type, int number) { }

}

// Namespace: UnityEngine.UIElements.StyleSheets.Syntax
internal class StyleSyntaxTokenizer 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.UIElements.StyleSheets.Syntax.StyleSyntaxToken> m_Tokens; // 0x10
	private int m_CurrentTokenIndex; // 0x18

	// Methods

	// RVA: 0x16BF4C4
	StyleSyntaxToken get_current() { }

	// RVA: 0x16C0548
	StyleSyntaxToken MoveNext() { }

	// RVA: 0x16C0914
	StyleSyntaxToken PeekNext() { }

	// RVA: 0x16BE5F4
	void Tokenize(string syntax) { }

	// RVA: 0x16C1480
	bool IsNextCharacter(string s, int index, Char c) { }

	// RVA: 0x16C1590
	bool IsNextLetterOrDash(string s, int index) { }

	// RVA: 0x16C14D4
	bool IsNextNumber(string s, int index) { }

	// RVA: 0x16C141C
	int GlobCharacter(string s, int index, Char c) { }

	// RVA: 0x16BE560
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public static class Easing 
{
	// Methods

	// RVA: 0x16C167C
	float Linear(float t) { }

	// RVA: 0x16C1680
	float InSine(float t) { }

	// RVA: 0x16C16B4
	float OutSine(float t) { }

	// RVA: 0x16C16C8
	float InOutSine(float t) { }

	// RVA: 0x16C1704
	float InQuad(float t) { }

	// RVA: 0x16C170C
	float OutQuad(float t) { }

	// RVA: 0x16C171C
	float InOutQuad(float t) { }

	// RVA: 0x16C175C
	float InCubic(float t) { }

	// RVA: 0x16C176C
	float OutCubic(float t) { }

	// RVA: 0x16C17D0
	float InOutCubic(float t) { }

	// RVA: 0x16C1764
	float InPower(float t, int power) { }

	// RVA: 0x16C1794
	float OutPower(float t, int power) { }

	// RVA: 0x16C1828
	float InOutPower(float t, int power) { }

	// RVA: 0x16C18A4
	float InBounce(float t) { }

	// RVA: 0x16C19A4
	float OutBounce(float t) { }

	// RVA: 0x16C1A7C
	float InOutBounce(float t) { }

	// RVA: 0x16C1CC0
	float InElastic(float t) { }

	// RVA: 0x16C1D4C
	float OutElastic(float t) { }

	// RVA: 0x16C1DDC
	float InOutElastic(float t) { }

	// RVA: 0x16C1F10
	float InBack(float t) { }

	// RVA: 0x16C1F3C
	float OutBack(float t) { }

	// RVA: 0x16C1F74
	float InOutBack(float t) { }

	// RVA: 0x16C1FFC
	float InCirc(float t) { }

	// RVA: 0x16C201C
	float OutCirc(float t) { }

	// RVA: 0x16C2038
	float InOutCirc(float t) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerOverLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16C22F4
	void .cctor() { }

	// RVA: 0x16C2360
	void .ctor() { }

	// RVA: 0x16C2368
	PointerOverLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerOverLinkTagEvent 
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x16C2080
	void .cctor() { }

	// RVA: 0x16C2170
	void set_linkID(string value) { }

	// RVA: 0x16C2180
	void set_linkText(string value) { }

	// RVA: 0x16C2190
	void Init() { }

	// RVA: 0x16C21F0
	void LocalInit() { }

	// RVA: 0x16C21FC
	PointerOverLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x16C2294
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerMoveLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16C2670
	void .cctor() { }

	// RVA: 0x16C26DC
	void .ctor() { }

	// RVA: 0x16C26E4
	PointerMoveLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerMoveLinkTagEvent 
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x16C23FC
	void .cctor() { }

	// RVA: 0x16C24EC
	void set_linkID(string value) { }

	// RVA: 0x16C24FC
	void set_linkText(string value) { }

	// RVA: 0x16C250C
	void Init() { }

	// RVA: 0x16C256C
	void LocalInit() { }

	// RVA: 0x16C2578
	PointerMoveLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x16C2610
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerOutLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16C2988
	void .cctor() { }

	// RVA: 0x16C29F4
	void .ctor() { }

	// RVA: 0x16C29FC
	PointerOutLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerOutLinkTagEvent 
{
	// Methods

	// RVA: 0x16C2778
	void .cctor() { }

	// RVA: 0x16C2868
	void Init() { }

	// RVA: 0x16C28C8
	void LocalInit() { }

	// RVA: 0x16C28D4
	PointerOutLinkTagEvent GetPooled(IPointerEvent evt, string linkID) { }

	// RVA: 0x16C2928
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerDownLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16C2D04
	void .cctor() { }

	// RVA: 0x16C2D70
	void .ctor() { }

	// RVA: 0x16C2D78
	PointerDownLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public sealed class PointerDownLinkTagEvent 
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x16C2A90
	void .cctor() { }

	// RVA: 0x16C2B80
	void set_linkID(string value) { }

	// RVA: 0x16C2B90
	void set_linkText(string value) { }

	// RVA: 0x16C2BA0
	void Init() { }

	// RVA: 0x16C2C00
	void LocalInit() { }

	// RVA: 0x16C2C0C
	PointerDownLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x16C2CA4
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.PointerUpLinkTagEvent.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16C3080
	void .cctor() { }

	// RVA: 0x16C30EC
	void .ctor() { }

	// RVA: 0x16C30F4
	PointerUpLinkTagEvent <.cctor>b__0_0() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public class PointerUpLinkTagEvent 
{
	// Fields
	private string <linkID>k__BackingField; // 0x108
	private string <linkText>k__BackingField; // 0x110

	// Methods

	// RVA: 0x16C2E0C
	void .cctor() { }

	// RVA: 0x16C2EFC
	void set_linkID(string value) { }

	// RVA: 0x16C2F0C
	void set_linkText(string value) { }

	// RVA: 0x16C2F1C
	void Init() { }

	// RVA: 0x16C2F7C
	void LocalInit() { }

	// RVA: 0x16C2F88
	PointerUpLinkTagEvent GetPooled(IPointerEvent evt, string linkID, string linkText) { }

	// RVA: 0x16C3020
	void .ctor() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public struct StyleValues 
{
	// Fields
	internal StyleValueCollection m_StyleValues; // 0x10

	// Methods

	// RVA: 0x16C3188
	void set_top(float value) { }

	// RVA: 0x16C3294
	void set_left(float value) { }

	// RVA: 0x16C32A0
	void set_width(float value) { }

	// RVA: 0x16C32AC
	void set_height(float value) { }

	// RVA: 0x16C32B8
	void set_right(float value) { }

	// RVA: 0x16C32C4
	void set_bottom(float value) { }

	// RVA: 0x16C32D0
	void set_color(Color value) { }

	// RVA: 0x16C33CC
	void set_backgroundColor(Color value) { }

	// RVA: 0x16C33D4
	void set_unityBackgroundImageTintColor(Color value) { }

	// RVA: 0x16C33E0
	void set_borderColor(Color value) { }

	// RVA: 0x16C33EC
	void set_marginLeft(float value) { }

	// RVA: 0x16C33F8
	void set_marginTop(float value) { }

	// RVA: 0x16C3404
	void set_marginRight(float value) { }

	// RVA: 0x16C3410
	void set_marginBottom(float value) { }

	// RVA: 0x16C341C
	void set_paddingLeft(float value) { }

	// RVA: 0x16C3428
	float get_paddingTop() { }

	// RVA: 0x16C3554
	void set_paddingTop(float value) { }

	// RVA: 0x16C3560
	void set_paddingRight(float value) { }

	// RVA: 0x16C356C
	void set_paddingBottom(float value) { }

	// RVA: 0x16C3578
	void set_borderLeftWidth(float value) { }

	// RVA: 0x16C3584
	void set_borderRightWidth(float value) { }

	// RVA: 0x16C3590
	void set_borderTopWidth(float value) { }

	// RVA: 0x16C359C
	void set_borderBottomWidth(float value) { }

	// RVA: 0x16C35A8
	void set_borderTopLeftRadius(float value) { }

	// RVA: 0x16C35B4
	void set_borderTopRightRadius(float value) { }

	// RVA: 0x16C35C0
	void set_borderBottomLeftRadius(float value) { }

	// RVA: 0x16C35C8
	void set_borderBottomRightRadius(float value) { }

	// RVA: 0x16C35D4
	void set_opacity(float value) { }

	// RVA: 0x16C35E0
	void set_flexGrow(float value) { }

	// RVA: 0x16C35EC
	void set_flexShrink(float value) { }

	// RVA: 0x16C3194
	void SetValue(StylePropertyId id, float value) { }

	// RVA: 0x16C32D8
	void SetValue(StylePropertyId id, Color value) { }

	// RVA: 0x16C34CC
	StyleValueCollection Values() { }

}

// Namespace: UnityEngine.UIElements.Experimental
public interface ITransitionAnimations 
{
	// Methods

	// RVA: -1
	UnityEngine.UIElements.Experimental.ValueAnimation<UnityEngine.UIElements.Experimental.StyleValues> Start(StyleValues to, int durationMs) { }

}

// Namespace: UnityEngine.UIElements.Experimental
internal static class Lerp 
{
	// Methods

	// RVA: 0x16C35F8
	float Interpolate(float start, float end, float ratio) { }

	// RVA: 0x16C3608
	Color Interpolate(Color start, Color end, float ratio) { }

	// RVA: 0x16C3640
	StyleValues Interpolate(StyleValues start, StyleValues end, float ratio) { }

}

// Namespace: UnityEngine.UIElements.Experimental
internal interface IValueAnimationUpdate 
{
	// Methods

	// RVA: -1
	void Tick(Int64 currentTimeMs) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.UIElements.Experimental.ValueAnimation.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE360C
	UnityEngine.UIElements.Experimental.ValueAnimation<T> <.cctor>b__67_0() { }

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

	// RVA: 0x2FE32D4
	int get_durationMs() { }

	// RVA: 0x2FE42A4
	void set_durationMs(int value) { }

	// RVA: 0x2FE360C
	System.Func<System.Single,System.Single> get_easingCurve() { }

	// RVA: 0x2FE4574
	void set_easingCurve(System.Func<System.Single,System.Single> value) { }

	// RVA: 0x2FE3054
	bool get_isRunning() { }

	// RVA: 0x2FE4234
	void set_isRunning(bool value) { }

	// RVA: 0x2FE360C
	Action get_onAnimationCompleted() { }

	// RVA: 0x2FE4574
	void set_onAnimationCompleted(Action value) { }

	// RVA: 0x2FE3054
	bool get_autoRecycle() { }

	// RVA: 0x2FE4234
	void set_autoRecycle(bool value) { }

	// RVA: 0x2FE3054
	bool get_recycled() { }

	// RVA: 0x2FE4234
	void set_recycled(bool value) { }

	// RVA: 0x2FE360C
	VisualElement get_owner() { }

	// RVA: 0x2FE4574
	void set_owner(VisualElement value) { }

	// RVA: 0x2FE360C
	System.Action<UnityEngine.UIElements.VisualElement,T> get_valueUpdated() { }

	// RVA: 0x2FE4574
	void set_valueUpdated(System.Action<UnityEngine.UIElements.VisualElement,T> value) { }

	// RVA: 0x2FE360C
	System.Func<UnityEngine.UIElements.VisualElement,T> get_initialValue() { }

	// RVA: 0x2FE4574
	void set_initialValue(System.Func<UnityEngine.UIElements.VisualElement,T> value) { }

	// RVA: 0x2FE360C
	System.Func<T,T,System.Single,T> get_interpolator() { }

	// RVA: 0x2FE4574
	void set_interpolator(System.Func<T,T,System.Single,T> value) { }

	// RVA: 0x309AF8C
	T get_from() { }

	// RVA: 0x309AF8C
	void set_from(T value) { }

	// RVA: 0x309AF8C
	T get_to() { }

	// RVA: 0x309AF8C
	void set_to(T value) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE41A8
	void Start() { }

	// RVA: 0x2FE41A8
	void Stop() { }

	// RVA: 0x2FE41A8
	void Recycle() { }

	// RVA: -1
	void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(Int64 currentTimeMs) { }

	// RVA: 0x2FE41A8
	void SetDefaultValues() { }

	// RVA: 0x2FE41A8
	void Unregister() { }

	// RVA: 0x2FE41A8
	void Register() { }

	// RVA: 0x2FE4574
	void SetOwner(VisualElement e) { }

	// RVA: 0x2FE41A8
	void CheckNotRecycled() { }

	// RVA: 0x2FE7164
	UnityEngine.UIElements.Experimental.ValueAnimation<T> Create(VisualElement e, System.Func<T,T,System.Single,T> interpolator) { }

	// RVA: 0x2FE360C
	UnityEngine.UIElements.Experimental.ValueAnimation<T> KeepAlive() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMovePreview 
{
	// Fields
	public static readonly string ussClassName; // 0x0

	// Methods

	// RVA: 0x16C3B08
	void .ctor() { }

	// RVA: 0x16C3BE8
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnMoveLocationPreview 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x16C3C98
	void .ctor() { }

	// RVA: 0x16C3DCC
	void .cctor() { }

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

	// RVA: 0x16C3EBC
	ColumnLayout get_columnLayout() { }

	// RVA: 0x16C3EC4
	void set_columnLayout(ColumnLayout value) { }

	// RVA: 0x16C3ECC
	bool get_active() { }

	// RVA: 0x16C3ED4
	void set_active(bool value) { }

	// RVA: 0x16C3F08
	bool get_moving() { }

	// RVA: 0x16C3F10
	void set_moving(bool value) { }

	// RVA: 0x16C3F44
	void add_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x16C3FF8
	void remove_activeChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x16C40AC
	void add_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x16C4160
	void remove_movingChanged(System.Action<UnityEngine.UIElements.Internal.ColumnMover> value) { }

	// RVA: 0x16C4214
	void .ctor() { }

	// RVA: 0x16C428C
	void RegisterCallbacksOnTarget() { }

	// RVA: 0x16C47CC
	void UnregisterCallbacksFromTarget() { }

	// RVA: 0x16C4D0C
	void OnMouseDown(MouseDownEvent evt) { }

	// RVA: 0x16C4FD8
	void OnMouseMove(MouseMoveEvent evt) { }

	// RVA: 0x16C5174
	void OnMouseUp(MouseUpEvent evt) { }

	// RVA: 0x16C5350
	void OnMouseCaptureOut(MouseCaptureOutEvent evt) { }

	// RVA: 0x16C54C8
	void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x16C5604
	void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x16C5730
	void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x16C5870
	void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x16C59E0
	void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x16C5970
	bool IsNotMouseEvent(int pointerId) { }

	// RVA: 0x16C53DC
	void ProcessCancelEvent(EventBase evt, int pointerId) { }

	// RVA: 0x16C5C24
	void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x16C4DD0
	void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x16C504C
	void ProcessMoveEvent(EventBase e, Vector2 localPosition) { }

	// RVA: 0x16C5228
	void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId) { }

	// RVA: 0x16C5CA0
	void BeginDragMove(float pos) { }

	// RVA: 0x16C6130
	void DragMove(float pos) { }

	// RVA: 0x16C64B4
	void UpdatePreviewPosition() { }

	// RVA: 0x16C6138
	void UpdateMoveLocation() { }

	// RVA: 0x16C5ACC
	void EndDragMove(bool cancelled) { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnResizePreview 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string visualUssClassName; // 0x8

	// Methods

	// RVA: 0x16C6730
	void .ctor() { }

	// RVA: 0x16C6864
	void .cctor() { }

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

	// RVA: 0x16C6954
	ColumnLayout get_columnLayout() { }

	// RVA: 0x16C695C
	void set_columnLayout(ColumnLayout value) { }

	// RVA: 0x16C6964
	bool get_preview() { }

	// RVA: 0x16C696C
	void set_preview(bool value) { }

	// RVA: 0x16C6974
	void .ctor(Column column) { }

	// RVA: 0x16C6A10
	void RegisterCallbacksOnTarget() { }

	// RVA: 0x16C6C50
	void UnregisterCallbacksFromTarget() { }

	// RVA: 0x16C6E90
	void OnKeyDown(KeyDownEvent e) { }

	// RVA: 0x16C6FB4
	void OnPointerDown(PointerDownEvent e) { }

	// RVA: 0x16C7284
	void OnPointerMove(PointerMoveEvent e) { }

	// RVA: 0x16C7430
	void OnPointerUp(PointerUpEvent e) { }

	// RVA: 0x16C722C
	void BeginDragResize(float pos) { }

	// RVA: 0x16C73E0
	void DragResize(float pos) { }

	// RVA: 0x16C75B4
	void UpdatePreviewPosition() { }

	// RVA: 0x16C6F3C
	void EndDragResize(float pos, bool cancelled) { }

}

// Namespace: 
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
private class ViewState 
{
	// Fields
	private bool m_HasPersistedData; // 0x10
	private System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> m_SortDescriptions; // 0x18
	private System.Collections.Generic.List<UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ViewState.ColumnState> m_OrderedColumnStates; // 0x20

	// Methods

	// RVA: 0x16CC9D0
	void Save(MultiColumnCollectionHeader header) { }

	// RVA: 0x16CC5EC
	void Apply(MultiColumnCollectionHeader header) { }

	// RVA: 0x16CD608
	void .ctor() { }

}

// Namespace: 
internal class ColumnData 
{
	// Fields
	private MultiColumnHeaderColumn <control>k__BackingField; // 0x10
	private MultiColumnHeaderColumnResizeHandle <resizeHandle>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16CD6E8
	MultiColumnHeaderColumn get_control() { }

	// RVA: 0x16CD6F0
	void set_control(MultiColumnHeaderColumn value) { }

	// RVA: 0x16CD6F8
	MultiColumnHeaderColumnResizeHandle get_resizeHandle() { }

	// RVA: 0x16CD700
	void set_resizeHandle(MultiColumnHeaderColumnResizeHandle value) { }

	// RVA: 0x16CA1D8
	void .ctor() { }

}

// Namespace: 
private struct SortedColumnState 
{
	// Fields
	public SortColumnDescription columnDesc; // 0x10
	public SortDirection direction; // 0x18

	// Methods

	// RVA: 0x16C9920
	void .ctor(SortColumnDescription desc, SortDirection dir) { }

}

// Namespace: 
private sealed class <>c__DisplayClass65_0 
{
	// Fields
	public Column column; // 0x10
	public MultiColumnCollectionHeader <>4__this; // 0x18

	// Methods

	// RVA: 0x16CB8F0
	void .ctor() { }

	// RVA: 0x16CD708
	void <OnContextualMenuManipulator>b__1(DropdownMenuAction a) { }

	// RVA: 0x16CD734
	Status <OnContextualMenuManipulator>b__2(DropdownMenuAction a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass71_0 
{
	// Fields
	public Column column; // 0x10

	// Methods

	// RVA: 0x16CC308
	void .ctor() { }

	// RVA: 0x16CD7C8
	bool <UpdateSortColumnDescriptionsOnClick>b__0(SortColumnDescription d) { }

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

	// RVA: 0x16C76C4
	bool get_isApplyingViewState() { }

	// RVA: 0x16C76CC
	System.Collections.Generic.Dictionary<UnityEngine.UIElements.Column,UnityEngine.UIElements.Internal.MultiColumnCollectionHeader.ColumnData> get_columnDataMap() { }

	// RVA: 0x16C76D4
	ColumnLayout get_columnLayout() { }

	// RVA: 0x16C76DC
	VisualElement get_columnContainer() { }

	// RVA: 0x16C76E4
	VisualElement get_resizeHandleContainer() { }

	// RVA: 0x16C76EC
	System.Collections.Generic.IEnumerable<UnityEngine.UIElements.SortColumnDescription> get_sortedColumns() { }

	// RVA: 0x16C76F4
	SortColumnDescriptions get_sortDescriptions() { }

	// RVA: 0x16C76FC
	void set_sortDescriptions(SortColumnDescriptions value) { }

	// RVA: 0x16C7F34
	Columns get_columns() { }

	// RVA: 0x16C7F3C
	bool get_sortingEnabled() { }

	// RVA: 0x16C7F44
	void set_sortingEnabled(bool value) { }

	// RVA: 0x16C85C4
	void add_columnResized(System.Action<System.Int32,System.Single> value) { }

	// RVA: 0x16C867C
	void remove_columnResized(System.Action<System.Int32,System.Single> value) { }

	// RVA: 0x16C8734
	void add_columnSortingChanged(Action value) { }

	// RVA: 0x16C87DC
	void remove_columnSortingChanged(Action value) { }

	// RVA: 0x16C8884
	void add_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16C893C
	void remove_contextMenuPopulateEvent(System.Action<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> value) { }

	// RVA: 0x16C89F4
	void add_viewDataRestored(Action value) { }

	// RVA: 0x16C8A9C
	void remove_viewDataRestored(Action value) { }

	// RVA: 0x16C8B44
	void .ctor(Columns columns, SortColumnDescriptions sortDescriptions, System.Collections.Generic.List<UnityEngine.UIElements.SortColumnDescription> sortedColumns) { }

	// RVA: 0x16C97C0
	void ScheduleDoLayout() { }

	// RVA: 0x16C98E8
	void ResizeToFit() { }

	// RVA: 0x16C77B4
	void UpdateSortedColumns() { }

	// RVA: 0x16C99DC
	void UpdateColumnControls() { }

	// RVA: 0x16CA1D4
	void OnColumnAdded(Column column, int index) { }

	// RVA: 0x16C9388
	void OnColumnAdded(Column column) { }

	// RVA: 0x16CA1E0
	void OnColumnRemoved(Column column) { }

	// RVA: 0x16CA4F8
	void OnColumnChanged(Column column, ColumnDataType type) { }

	// RVA: 0x16CAE1C
	void OnColumnReordered(Column column, int from, int to) { }

	// RVA: 0x16CAFE0
	void OnColumnResized(Column column) { }

	// RVA: 0x16CB028
	void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt) { }

	// RVA: 0x16CB8F8
	void OnMoveManipulatorActivated(ColumnMover mover) { }

	// RVA: 0x16CBA00
	void OnGeometryChanged(GeometryChangedEvent e) { }

	// RVA: 0x16CBAA0
	void DoLayout() { }

	// RVA: 0x16CBAE4
	void OnColumnControlGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x16CBE54
	void OnColumnClicked(EventBase evt) { }

	// RVA: 0x16CC080
	void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers) { }

	// RVA: 0x16CC310
	void ScrollHorizontally(float horizontalOffset) { }

	// RVA: 0x16CBD4C
	void RaiseColumnResized(int columnIndex) { }

	// RVA: 0x16C9994
	void RaiseColumnSortingChanged() { }

	// RVA: 0x16CA5A0
	void ApplyColumnSorting() { }

	// RVA: 0x16C7F84
	void UpdateSortingStatus() { }

	// RVA: 0x16CC4D8
	void OnViewDataReady() { }

	// RVA: 0x16C994C
	void SaveViewState() { }

	// RVA: 0x16CA2D0
	void CleanupColumnData(ColumnData data) { }

	// RVA: 0x16CD030
	void Dispose() { }

	// RVA: 0x16CD490
	void .cctor() { }

	// RVA: 0x16CD5D0
	void <OnContextualMenuManipulator>b__65_0(DropdownMenuAction a) { }

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

	// RVA: 0x16CD85C
	void set_sortOrderLabel(string value) { }

	// RVA: 0x16CD884
	void .ctor() { }

	// RVA: 0x16CDA30
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnIcon 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	private bool <isImageInline>k__BackingField; // 0x40B

	// Methods

	// RVA: 0x16CDB68
	bool get_isImageInline() { }

	// RVA: 0x16CDB70
	void set_isImageInline(bool value) { }

	// RVA: 0x16CDB78
	void .ctor() { }

	// RVA: 0x16CDC8C
	void UpdateClassList() { }

	// RVA: 0x16CDE30
	void .cctor() { }

	// RVA: 0x16CDEE0
	void <.ctor>b__5_0(CustomStyleResolvedEvent evt) { }

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

	// RVA: 0x16CDEE4
	Clickable get_clickable() { }

	// RVA: 0x16CDEEC
	void set_clickable(Clickable value) { }

	// RVA: 0x16CDEFC
	ColumnMover get_mover() { }

	// RVA: 0x16CDF04
	void set_mover(ColumnMover value) { }

	// RVA: 0x16CDF14
	void set_sortOrderLabel(string value) { }

	// RVA: 0x16CDF34
	Column get_column() { }

	// RVA: 0x16CDF3C
	void set_column(Column value) { }

	// RVA: 0x16CDF4C
	VisualElement get_content() { }

	// RVA: 0x16CDF54
	void set_content(VisualElement value) { }

	// RVA: 0x16CE218
	bool get_isContentBound() { }

	// RVA: 0x16CE2F0
	void set_isContentBound(bool value) { }

	// RVA: 0x16CE3B0
	void .ctor(Column column) { }

	// RVA: 0x16CF0B8
	void OnColumnChanged(Column c, ColumnDataType role) { }

	// RVA: 0x16CF2EC
	void OnColumnResized(Column c) { }

	// RVA: 0x16CEED8
	void InitManipulators() { }

	// RVA: 0x16CF2F0
	void OnMoverChanged(ColumnMover mv) { }

	// RVA: 0x16CF2A4
	void UpdateDataFromColumn() { }

	// RVA: 0x16CF47C
	void BindHeaderContent() { }

	// RVA: 0x16CF394
	void UnbindHeaderContent() { }

	// RVA: 0x16CE050
	void DestroyHeaderContent() { }

	// RVA: 0x16CF564
	VisualElement CreateDefaultHeaderContent() { }

	// RVA: 0x16CF6F8
	void DefaultBindHeaderContent(VisualElement ve) { }

	// RVA: 0x16CEBB4
	void UpdateHeaderTemplate() { }

	// RVA: 0x16CEDC8
	void UpdateGeometryFromColumn() { }

	// RVA: 0x16CFA74
	void Dispose() { }

	// RVA: 0x16CFC1C
	void .cctor() { }

}

// Namespace: UnityEngine.UIElements.Internal
internal class MultiColumnHeaderColumnResizeHandle 
{
	// Fields
	public static readonly string ussClassName; // 0x0
	public static readonly string dragAreaUssClassName; // 0x8
	private readonly VisualElement <dragArea>k__BackingField; // 0x3C8

	// Methods

	// RVA: 0x16D0054
	VisualElement get_dragArea() { }

	// RVA: 0x16D005C
	void .ctor() { }

	// RVA: 0x16D018C
	void .cctor() { }

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


