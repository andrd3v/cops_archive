// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.TextCore
[Serializable]
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

	// RVA: 0x16DDA9C
	internal int get_faceIndex() { }

	// RVA: 0x16DDAA4
	public string get_familyName() { }

	// RVA: 0x16DDAAC
	public string get_styleName() { }

	// RVA: 0x16DDAB4
	public int get_pointSize() { }

	// RVA: 0x16DDABC
	public float get_scale() { }

	// RVA: 0x16DDAC4
	public void set_scale(float value) { }

	// RVA: 0x16DDACC
	public float get_lineHeight() { }

	// RVA: 0x16DDAD4
	public float get_ascentLine() { }

	// RVA: 0x16DDADC
	public float get_capLine() { }

	// RVA: 0x16DDAE4
	public void set_capLine(float value) { }

	// RVA: 0x16DDAEC
	public float get_meanLine() { }

	// RVA: 0x16DDAF4
	public void set_meanLine(float value) { }

	// RVA: 0x16DDAFC
	public float get_baseline() { }

	// RVA: 0x16DDB04
	public float get_descentLine() { }

	// RVA: 0x16DDB0C
	public float get_superscriptOffset() { }

	// RVA: 0x16DDB14
	public float get_superscriptSize() { }

	// RVA: 0x16DDB1C
	public float get_subscriptOffset() { }

	// RVA: 0x16DDB24
	public float get_subscriptSize() { }

	// RVA: 0x16DDB2C
	public float get_underlineOffset() { }

	// RVA: 0x16DDB34
	public float get_underlineThickness() { }

	// RVA: 0x16DDB3C
	public float get_strikethroughOffset() { }

	// RVA: 0x16DDB44
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x16DDB4C
	public float get_tabWidth() { }

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
[Serializable]
public struct GlyphRect
{
	// Fields
	private int m_X; // 0x10
	private int m_Y; // 0x14
	private int m_Width; // 0x18
	private int m_Height; // 0x1C
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Methods

	// RVA: 0x16DDB54
	public int get_x() { }

	// RVA: 0x16DDB5C
	public int get_y() { }

	// RVA: 0x16DDB64
	public int get_width() { }

	// RVA: 0x16DDB6C
	public int get_height() { }

	// RVA: 0x16DDB74
	public static GlyphRect get_zero() { }

	// RVA: 0x16DDBF0
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x16DDBFC
	public override int GetHashCode() { }

	// RVA: 0x16DDC6C
	public override bool Equals(object obj) { }

	// RVA: 0x16DDCE4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x16DDD80
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore
[Serializable]
public struct GlyphMetrics
{
	// Fields
	private float m_Width; // 0x10
	private float m_Height; // 0x14
	private float m_HorizontalBearingX; // 0x18
	private float m_HorizontalBearingY; // 0x1C
	private float m_HorizontalAdvance; // 0x20

	// Methods

	// RVA: 0x16DDDCC
	public float get_width() { }

	// RVA: 0x16DDDD4
	public float get_height() { }

	// RVA: 0x16DDDDC
	public float get_horizontalBearingX() { }

	// RVA: 0x16DDDE4
	public float get_horizontalBearingY() { }

	// RVA: 0x16DDDEC
	public float get_horizontalAdvance() { }

	// RVA: 0x16DDDF4
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x16DDE04
	public override int GetHashCode() { }

	// RVA: 0x16DDE7C
	public override bool Equals(object obj) { }

	// RVA: 0x16DDEFC
	public bool Equals(GlyphMetrics other) { }

}

// Namespace: UnityEngine.TextCore
[Serializable]
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

	// RVA: 0x16DDFA0
	public UInt32 get_index() { }

	// RVA: 0x16DDFA8
	public GlyphMetrics get_metrics() { }

	// RVA: 0x16DDFBC
	public GlyphRect get_glyphRect() { }

	// RVA: 0x16DDFC8
	public float get_scale() { }

	// RVA: 0x16DDFD0
	public int get_atlasIndex() { }

	// RVA: 0x16DDFD8
	public void set_atlasIndex(int value) { }

	// RVA: 0x16DDFE0
	public void .ctor() { }

	// RVA: 0x16DE014
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x16DE094
	public void .ctor(UInt32 index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

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

	// RVA: 0x16DE108
	public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x16DE1BC
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x16DE214
	public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x16DE2C8
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x16DE320
	public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize) { }

	// RVA: 0x16DE3D4
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x16DE42C
	internal static bool TryGetSystemFontReference(string familyName, string styleName, FontReference fontRef) { }

	// RVA: 0x16DE4E0
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, FontReference fontRef) { }

	// RVA: 0x16DE538
	public static FaceInfo GetFaceInfo() { }

	// RVA: 0x16DE5FC
	private static int GetFaceInfo_Internal(FaceInfo faceInfo) { }

	// RVA: 0x16DE64C
	internal static UInt32 GetGlyphIndex(UInt32 unicode) { }

	// RVA: 0x16DE69C
	public static bool TryGetGlyphWithUnicodeValue(UInt32 unicode, GlyphLoadFlags flags, Glyph glyph) { }

	// RVA: 0x16DE81C
	private static bool TryGetGlyphWithUnicodeValue_Internal(UInt32 unicode, GlyphLoadFlags loadFlags, GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x16DE874
	public static bool TryGetGlyphWithIndexValue(UInt32 glyphIndex, GlyphLoadFlags flags, Glyph glyph) { }

	// RVA: 0x16DE9F4
	private static bool TryGetGlyphWithIndexValue_Internal(UInt32 glyphIndex, GlyphLoadFlags loadFlags, GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x16DEA4C
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	// RVA: 0x16DEA9C
	internal static bool TryAddGlyphToTexture(UInt32 glyphIndex, int padding, GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, Glyph glyph) { }

	// RVA: 0x16DEFFC
	private static bool TryAddGlyphToTexture_Internal(UInt32 glyphIndex, int padding, GlyphPackingMode packingMode, GlyphRect[] freeGlyphRects, int freeGlyphRectCount, GlyphRect[] usedGlyphRects, int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, GlyphMarshallingStruct glyph) { }

	// RVA: 0x16DF0A0
	internal static bool TryAddGlyphsToTexture(System.Collections.Generic.List<System.UInt32> glyphIndexes, int padding, GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, Glyph[] glyphs) { }

	// RVA: 0x16DFA58
	private static bool TryAddGlyphsToTexture_Internal(UInt32[] glyphIndex, int padding, GlyphPackingMode packingMode, GlyphRect[] freeGlyphRects, int freeGlyphRectCount, GlyphRect[] usedGlyphRects, int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, GlyphMarshallingStruct[] glyphs, int glyphCount) { }

	// RVA: 0x16DFB0C
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(UInt32[] glyphIndexes) { }

	// RVA: 0x16DFD60
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes, int recordCount) { }

	// RVA: 0x16DFCA8
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(UInt32[] glyphIndexes, int recordCount) { }

	// RVA: 0x16DFD10
	private static int GetPairAdjustmentRecordsFromMarshallingArray(GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: 0x30DB358
	private static void GenericListToMarshallingArray(System.Collections.Generic.List<T>& srcList, T[] dstArray) { }

	// RVA: 0x30DA46C
	private static void SetMarshallingArraySize(T[] marshallingArray, int recordCount) { }

	// RVA: 0x16DFF18
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x16DFF68
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontEngineUtilities
{
	// Methods

	// RVA: 0x16DFA44
	internal static int MaxValue(int a, int b, int c) { }

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
[Serializable]
public struct GlyphValueRecord
{
	// Fields
	private float m_XPlacement; // 0x10
	private float m_YPlacement; // 0x14
	private float m_XAdvance; // 0x18
	private float m_YAdvance; // 0x1C

	// Methods

	// RVA: 0x16E00F0
	public float get_xPlacement() { }

	// RVA: 0x16E00F8
	public void set_xPlacement(float value) { }

	// RVA: 0x16E0100
	public float get_yPlacement() { }

	// RVA: 0x16E0108
	public void set_yPlacement(float value) { }

	// RVA: 0x16E0110
	public float get_xAdvance() { }

	// RVA: 0x16E0118
	public float get_yAdvance() { }

	// RVA: 0x16E0120
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	// RVA: 0x16E0134
	public override int GetHashCode() { }

	// RVA: 0x16E01A4
	public override bool Equals(object obj) { }

	// RVA: 0x16E021C
	public bool Equals(GlyphValueRecord other) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
public struct GlyphAdjustmentRecord
{
	// Fields
	private UInt32 m_GlyphIndex; // 0x10
	private GlyphValueRecord m_GlyphValueRecord; // 0x14

	// Methods

	// RVA: 0x16E02CC
	public UInt32 get_glyphIndex() { }

	// RVA: 0x16E02D4
	public GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x16E02E0
	public override int GetHashCode() { }

	// RVA: 0x16E0358
	public override bool Equals(object obj) { }

	// RVA: 0x16E03D8
	public bool Equals(GlyphAdjustmentRecord other) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
public struct GlyphPairAdjustmentRecord
{
	// Fields
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Methods

	// RVA: 0x16E047C
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x16E0490
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x16E04A4
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x16E04AC
	public override int GetHashCode() { }

	// RVA: 0x16E0524
	public override bool Equals(object obj) { }

	// RVA: 0x16E05A4
	public bool Equals(GlyphPairAdjustmentRecord other) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct GlyphAnchorPoint
{
	// Fields
	private float m_XCoordinate; // 0x10
	private float m_YCoordinate; // 0x14

	// Methods

	// RVA: 0x16E0648
	public float get_xCoordinate() { }

	// RVA: 0x16E0650
	public float get_yCoordinate() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct MarkPositionAdjustment
{
	// Fields
	private float m_XPositionAdjustment; // 0x10
	private float m_YPositionAdjustment; // 0x14

	// Methods

	// RVA: 0x16E0658
	public float get_xPositionAdjustment() { }

	// RVA: 0x16E0660
	public float get_yPositionAdjustment() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct MarkToBaseAdjustmentRecord
{
	// Fields
	private UInt32 m_BaseGlyphID; // 0x10
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x14
	private UInt32 m_MarkGlyphID; // 0x1C
	private MarkPositionAdjustment m_MarkPositionAdjustment; // 0x20

	// Methods

	// RVA: 0x16E0668
	public UInt32 get_baseGlyphID() { }

	// RVA: 0x16E0670
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x16E0678
	public UInt32 get_markGlyphID() { }

	// RVA: 0x16E0680
	public MarkPositionAdjustment get_markPositionAdjustment() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct MarkToMarkAdjustmentRecord
{
	// Fields
	private UInt32 m_BaseMarkGlyphID; // 0x10
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x14
	private UInt32 m_CombiningMarkGlyphID; // 0x1C
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x20

	// Methods

	// RVA: 0x16E0688
	public UInt32 get_baseMarkGlyphID() { }

	// RVA: 0x16E0690
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x16E0698
	public UInt32 get_combiningMarkGlyphID() { }

	// RVA: 0x16E06A0
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct MultipleSubstitutionRecord
{
	// Fields
	private UInt32 m_TargetGlyphID; // 0x10
	private UInt32[] m_SubstituteGlyphIDs; // 0x18
}

// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct LigatureSubstitutionRecord
{
	// Fields
	private UInt32[] m_ComponentGlyphIDs; // 0x10
	private UInt32 m_LigatureGlyphID; // 0x18

	// Methods

	// RVA: 0x16E06A8
	public UInt32[] get_componentGlyphIDs() { }

	// RVA: 0x16E06B0
	public UInt32 get_ligatureGlyphID() { }

}


