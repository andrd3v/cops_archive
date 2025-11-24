// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine.TextCore
public struct FaceInfo 
{
	// Fields
	private int m_FaceIndex; // 0x10
	private string m_FamilyName; // 0x18
	private string m_StyleName; // 0x20
	private int m_PointSize; // 0x28
	private float m_Scale; // 0x2C
	private int m_UnitsPerEM; // 0x30
	private float m_LineHeight; // 0x34
	private float m_AscentLine; // 0x38
	private float m_CapLine; // 0x3C
	private float m_MeanLine; // 0x40
	private float m_Baseline; // 0x44
	private float m_DescentLine; // 0x48
	private float m_SuperscriptOffset; // 0x4C
	private float m_SuperscriptSize; // 0x50
	private float m_SubscriptOffset; // 0x54
	private float m_SubscriptSize; // 0x58
	private float m_UnderlineOffset; // 0x5C
	private float m_UnderlineThickness; // 0x60
	private float m_StrikethroughOffset; // 0x64
	private float m_StrikethroughThickness; // 0x68
	private float m_TabWidth; // 0x6C

	// Methods

	// RVA: 0x15C66C4
	int get_faceIndex() { }

	// RVA: 0x15C66CC
	string get_familyName() { }

	// RVA: 0x15C66D4
	string get_styleName() { }

	// RVA: 0x15C66DC
	int get_pointSize() { }

	// RVA: 0x15C66E4
	float get_scale() { }

	// RVA: 0x15C66EC
	void set_scale(float value) { }

	// RVA: 0x15C66F4
	float get_lineHeight() { }

	// RVA: 0x15C66FC
	float get_ascentLine() { }

	// RVA: 0x15C6704
	float get_capLine() { }

	// RVA: 0x15C670C
	void set_capLine(float value) { }

	// RVA: 0x15C6714
	float get_meanLine() { }

	// RVA: 0x15C671C
	void set_meanLine(float value) { }

	// RVA: 0x15C6724
	float get_baseline() { }

	// RVA: 0x15C672C
	float get_descentLine() { }

	// RVA: 0x15C6734
	float get_superscriptOffset() { }

	// RVA: 0x15C673C
	float get_superscriptSize() { }

	// RVA: 0x15C6744
	float get_subscriptOffset() { }

	// RVA: 0x15C674C
	float get_subscriptSize() { }

	// RVA: 0x15C6754
	float get_underlineOffset() { }

	// RVA: 0x15C675C
	float get_underlineThickness() { }

	// RVA: 0x15C6764
	float get_strikethroughOffset() { }

	// RVA: 0x15C676C
	void set_strikethroughOffset(float value) { }

	// RVA: 0x15C6774
	float get_tabWidth() { }

}

// Namespace: UnityEngine.TextCore
public enum GlyphClassDefinitionType 
{
	// Fields
	public int value__; // 0x10
	public const GlyphClassDefinitionType Undefined = 0;
	public const GlyphClassDefinitionType Base = 1;
	public const GlyphClassDefinitionType Ligature = 2;
	public const GlyphClassDefinitionType Mark = 3;
	public const GlyphClassDefinitionType Component = 4;
}

// Namespace: UnityEngine.TextCore
public struct GlyphRect 
{
	// Fields
	private int m_X; // 0x10
	private int m_Y; // 0x14
	private int m_Width; // 0x18
	private int m_Height; // 0x1C
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Methods

	// RVA: 0x15C677C
	int get_x() { }

	// RVA: 0x15C6784
	int get_y() { }

	// RVA: 0x15C678C
	int get_width() { }

	// RVA: 0x15C6794
	int get_height() { }

	// RVA: 0x15C679C
	GlyphRect get_zero() { }

	// RVA: 0x15C6818
	void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x15C6824
	int GetHashCode() { }

	// RVA: 0x15C6894
	bool Equals(object obj) { }

	// RVA: 0x15C690C
	bool Equals(GlyphRect other) { }

	// RVA: 0x15C69A8
	void .cctor() { }

}

// Namespace: UnityEngine.TextCore
public struct GlyphMetrics 
{
	// Fields
	private float m_Width; // 0x10
	private float m_Height; // 0x14
	private float m_HorizontalBearingX; // 0x18
	private float m_HorizontalBearingY; // 0x1C
	private float m_HorizontalAdvance; // 0x20

	// Methods

	// RVA: 0x15C69F4
	float get_width() { }

	// RVA: 0x15C69FC
	float get_height() { }

	// RVA: 0x15C6A04
	float get_horizontalBearingX() { }

	// RVA: 0x15C6A0C
	float get_horizontalBearingY() { }

	// RVA: 0x15C6A14
	float get_horizontalAdvance() { }

	// RVA: 0x15C6A1C
	void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x15C6A2C
	int GetHashCode() { }

	// RVA: 0x15C6AA4
	bool Equals(object obj) { }

	// RVA: 0x15C6B24
	bool Equals(GlyphMetrics other) { }

}

// Namespace: UnityEngine.TextCore
public class Glyph 
{
	// Fields
	private UInt32 m_Index; // 0x10
	private GlyphMetrics m_Metrics; // 0x14
	private GlyphRect m_GlyphRect; // 0x28
	private float m_Scale; // 0x38
	private int m_AtlasIndex; // 0x3C
	private GlyphClassDefinitionType m_ClassDefinitionType; // 0x40

	// Methods

	// RVA: 0x15C6BC8
	UInt32 get_index() { }

	// RVA: 0x15C6BD0
	GlyphMetrics get_metrics() { }

	// RVA: 0x15C6BE4
	GlyphRect get_glyphRect() { }

	// RVA: 0x15C6BF0
	float get_scale() { }

	// RVA: 0x15C6BF8
	int get_atlasIndex() { }

	// RVA: 0x15C6C00
	void set_atlasIndex(int value) { }

	// RVA: 0x15C6C08
	void .ctor() { }

	// RVA: 0x15C6C3C
	void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x15C6CBC
	void .ctor(UInt32 index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
public enum GlyphLoadFlags 
{
	// Fields
	public int value__; // 0x10
	public const GlyphLoadFlags LOAD_DEFAULT = 0;
	public const GlyphLoadFlags LOAD_NO_SCALE = 1;
	public const GlyphLoadFlags LOAD_NO_HINTING = 2;
	public const GlyphLoadFlags LOAD_RENDER = 4;
	public const GlyphLoadFlags LOAD_NO_BITMAP = 8;
	public const GlyphLoadFlags LOAD_FORCE_AUTOHINT = 32;
	public const GlyphLoadFlags LOAD_MONOCHROME = 4096;
	public const GlyphLoadFlags LOAD_NO_AUTOHINT = 32768;
	public const GlyphLoadFlags LOAD_COLOR = 1048576;
	public const GlyphLoadFlags LOAD_COMPUTE_METRICS = 2097152;
	public const GlyphLoadFlags LOAD_BITMAP_METRICS_ONLY = 4194304;
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum FontEngineError 
{
	// Fields
	public int value__; // 0x10
	public const FontEngineError Success = 0;
	public const FontEngineError Invalid_File_Path = 1;
	public const FontEngineError Invalid_File_Format = 2;
	public const FontEngineError Invalid_File_Structure = 3;
	public const FontEngineError Invalid_File = 4;
	public const FontEngineError Invalid_Table = 8;
	public const FontEngineError Invalid_Glyph_Index = 16;
	public const FontEngineError Invalid_Character_Code = 17;
	public const FontEngineError Invalid_Pixel_Size = 23;
	public const FontEngineError Invalid_Library = 33;
	public const FontEngineError Invalid_Face = 35;
	public const FontEngineError Invalid_Library_or_Face = 41;
	public const FontEngineError Atlas_Generation_Cancelled = 100;
	public const FontEngineError Invalid_SharedTextureData = 101;
	public const FontEngineError OpenTypeLayoutLookup_Mismatch = 116;
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum GlyphRenderMode 
{
	// Fields
	public int value__; // 0x10
	public const GlyphRenderMode SMOOTH_HINTED = 4121;
	public const GlyphRenderMode SMOOTH = 4117;
	public const GlyphRenderMode COLOR_HINTED = 69656;
	public const GlyphRenderMode COLOR = 69652;
	public const GlyphRenderMode RASTER_HINTED = 4122;
	public const GlyphRenderMode RASTER = 4118;
	public const GlyphRenderMode SDF = 4134;
	public const GlyphRenderMode SDF8 = 8230;
	public const GlyphRenderMode SDF16 = 16422;
	public const GlyphRenderMode SDF32 = 32806;
	public const GlyphRenderMode SDFAA_HINTED = 4169;
	public const GlyphRenderMode SDFAA = 4165;
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum GlyphPackingMode 
{
	// Fields
	public int value__; // 0x10
	public const GlyphPackingMode BestShortSideFit = 0;
	public const GlyphPackingMode BestLongSideFit = 1;
	public const GlyphPackingMode BestAreaFit = 2;
	public const GlyphPackingMode BottomLeftRule = 3;
	public const GlyphPackingMode ContactPointRule = 4;
}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontReference 
{
	// Fields
	public string familyName; // 0x10
	public string styleName; // 0x18
	public int faceIndex; // 0x20
	public string filePath; // 0x28
}

// Namespace: UnityEngine.TextCore.LowLevel
public sealed class FontEngine 
{
	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static UInt32[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
	private static System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary; // 0x38

	// Methods

	// RVA: 0x15C6D30
	FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x15C6DE4
	int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x15C6E3C
	FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x15C6EF0
	int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x15C6F48
	FontEngineError LoadFontFace(string familyName, string styleName, int pointSize) { }

	// RVA: 0x15C6FFC
	int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x15C7054
	bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	// RVA: 0x15C7108
	bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef) { }

	// RVA: 0x15C7160
	FaceInfo GetFaceInfo() { }

	// RVA: 0x15C7224
	int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	// RVA: 0x15C7274
	UInt32 GetGlyphIndex(UInt32 unicode) { }

	// RVA: 0x15C72C4
	bool TryGetGlyphWithUnicodeValue(UInt32 unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	// RVA: 0x15C7444
	bool TryGetGlyphWithUnicodeValue_Internal(UInt32 unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x15C749C
	bool TryGetGlyphWithIndexValue(UInt32 glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	// RVA: 0x15C761C
	bool TryGetGlyphWithIndexValue_Internal(UInt32 glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x15C7674
	void SetTextureUploadMode(bool shouldUploadImmediately) { }

	// RVA: 0x15C76C4
	bool TryAddGlyphToTexture(UInt32 glyphIndex, int padding, GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	// RVA: 0x15C7C24
	bool TryAddGlyphToTexture_Internal(UInt32 glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x15C7CC8
	bool TryAddGlyphsToTexture(System.Collections.Generic.List<System.UInt32> glyphIndexes, int padding, GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	// RVA: 0x15C8680
	bool TryAddGlyphsToTexture_Internal(UInt32[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x15C8734
	GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(UInt32[] glyphIndexes) { }

	// RVA: 0x15C8988
	GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes, out int recordCount) { }

	// RVA: 0x15C88D0
	int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(UInt32[] glyphIndexes, out int recordCount) { }

	// RVA: 0x15C8938
	int GetPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: 0x2FEAB7C
	void GenericListToMarshallingArray(ref System.Collections.Generic.List<T>& srcList, ref T[] dstArray) { }

	// RVA: 0x2FE9C90
	void SetMarshallingArraySize(ref T[] marshallingArray, int recordCount) { }

	// RVA: 0x15C8B40
	void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x15C8B90
	void .cctor() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontEngineUtilities 
{
	// Methods

	// RVA: 0x15C866C
	int MaxValue(int a, int b, int c) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct GlyphMarshallingStruct 
{
	// Fields
	public UInt32 index; // 0x10
	public GlyphMetrics metrics; // 0x14
	public GlyphRect glyphRect; // 0x28
	public float scale; // 0x38
	public int atlasIndex; // 0x3C
	public GlyphClassDefinitionType classDefinitionType; // 0x40
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum FontFeatureLookupFlags 
{
	// Fields
	public int value__; // 0x10
	public const FontFeatureLookupFlags None = 0;
	public const FontFeatureLookupFlags IgnoreLigatures = 4;
	public const FontFeatureLookupFlags IgnoreSpacingAdjustments = 256;
}

// Namespace: UnityEngine.TextCore.LowLevel
public struct GlyphValueRecord 
{
	// Fields
	private float m_XPlacement; // 0x10
	private float m_YPlacement; // 0x14
	private float m_XAdvance; // 0x18
	private float m_YAdvance; // 0x1C

	// Methods

	// RVA: 0x15C8D18
	float get_xPlacement() { }

	// RVA: 0x15C8D20
	void set_xPlacement(float value) { }

	// RVA: 0x15C8D28
	float get_yPlacement() { }

	// RVA: 0x15C8D30
	void set_yPlacement(float value) { }

	// RVA: 0x15C8D38
	float get_xAdvance() { }

	// RVA: 0x15C8D40
	float get_yAdvance() { }

	// RVA: 0x15C8D48
	GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	// RVA: 0x15C8D5C
	int GetHashCode() { }

	// RVA: 0x15C8DCC
	bool Equals(object obj) { }

	// RVA: 0x15C8E44
	bool Equals(GlyphValueRecord other) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
public struct GlyphAdjustmentRecord 
{
	// Fields
	private UInt32 m_GlyphIndex; // 0x10
	private GlyphValueRecord m_GlyphValueRecord; // 0x14

	// Methods

	// RVA: 0x15C8EF4
	UInt32 get_glyphIndex() { }

	// RVA: 0x15C8EFC
	GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x15C8F08
	int GetHashCode() { }

	// RVA: 0x15C8F80
	bool Equals(object obj) { }

	// RVA: 0x15C9000
	bool Equals(GlyphAdjustmentRecord other) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
public struct GlyphPairAdjustmentRecord 
{
	// Fields
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Methods

	// RVA: 0x15C90A4
	GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x15C90B8
	GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x15C90CC
	FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x15C90D4
	int GetHashCode() { }

	// RVA: 0x15C914C
	bool Equals(object obj) { }

	// RVA: 0x15C91CC
	bool Equals(GlyphPairAdjustmentRecord other) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct GlyphAnchorPoint 
{
	// Fields
	private float m_XCoordinate; // 0x10
	private float m_YCoordinate; // 0x14

	// Methods

	// RVA: 0x15C9270
	float get_xCoordinate() { }

	// RVA: 0x15C9278
	float get_yCoordinate() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct MarkPositionAdjustment 
{
	// Fields
	private float m_XPositionAdjustment; // 0x10
	private float m_YPositionAdjustment; // 0x14

	// Methods

	// RVA: 0x15C9280
	float get_xPositionAdjustment() { }

	// RVA: 0x15C9288
	float get_yPositionAdjustment() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct MarkToBaseAdjustmentRecord 
{
	// Fields
	private UInt32 m_BaseGlyphID; // 0x10
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x14
	private UInt32 m_MarkGlyphID; // 0x1C
	private MarkPositionAdjustment m_MarkPositionAdjustment; // 0x20

	// Methods

	// RVA: 0x15C9290
	UInt32 get_baseGlyphID() { }

	// RVA: 0x15C9298
	GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x15C92A0
	UInt32 get_markGlyphID() { }

	// RVA: 0x15C92A8
	MarkPositionAdjustment get_markPositionAdjustment() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct MarkToMarkAdjustmentRecord 
{
	// Fields
	private UInt32 m_BaseMarkGlyphID; // 0x10
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x14
	private UInt32 m_CombiningMarkGlyphID; // 0x1C
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x20

	// Methods

	// RVA: 0x15C92B0
	UInt32 get_baseMarkGlyphID() { }

	// RVA: 0x15C92B8
	GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x15C92C0
	UInt32 get_combiningMarkGlyphID() { }

	// RVA: 0x15C92C8
	MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct MultipleSubstitutionRecord 
{
	// Fields
	private UInt32 m_TargetGlyphID; // 0x10
	private UInt32[] m_SubstituteGlyphIDs; // 0x18
}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct LigatureSubstitutionRecord 
{
	// Fields
	private UInt32[] m_ComponentGlyphIDs; // 0x10
	private UInt32 m_LigatureGlyphID; // 0x18

	// Methods

	// RVA: 0x15C92D0
	UInt32[] get_componentGlyphIDs() { }

	// RVA: 0x15C92D8
	UInt32 get_ligatureGlyphID() { }

}


