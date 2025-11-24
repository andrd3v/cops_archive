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

	// RVA: 0x16AB6A8
	internal int get_faceIndex() { }

	// RVA: 0x16AB6B0
	public string get_familyName() { }

	// RVA: 0x16AB6B8
	public string get_styleName() { }

	// RVA: 0x16AB6C0
	public int get_pointSize() { }

	// RVA: 0x16AB6C8
	public float get_scale() { }

	// RVA: 0x16AB6D0
	public void set_scale(float value) { }

	// RVA: 0x16AB6D8
	public float get_lineHeight() { }

	// RVA: 0x16AB6E0
	public float get_ascentLine() { }

	// RVA: 0x16AB6E8
	public float get_capLine() { }

	// RVA: 0x16AB6F0
	public void set_capLine(float value) { }

	// RVA: 0x16AB6F8
	public float get_meanLine() { }

	// RVA: 0x16AB700
	public void set_meanLine(float value) { }

	// RVA: 0x16AB708
	public float get_baseline() { }

	// RVA: 0x16AB710
	public float get_descentLine() { }

	// RVA: 0x16AB718
	public float get_superscriptOffset() { }

	// RVA: 0x16AB720
	public float get_superscriptSize() { }

	// RVA: 0x16AB728
	public float get_subscriptOffset() { }

	// RVA: 0x16AB730
	public float get_subscriptSize() { }

	// RVA: 0x16AB738
	public float get_underlineOffset() { }

	// RVA: 0x16AB740
	public float get_underlineThickness() { }

	// RVA: 0x16AB748
	public float get_strikethroughOffset() { }

	// RVA: 0x16AB750
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x16AB758
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

	// RVA: 0x16AB760
	public int get_x() { }

	// RVA: 0x16AB768
	public int get_y() { }

	// RVA: 0x16AB770
	public int get_width() { }

	// RVA: 0x16AB778
	public int get_height() { }

	// RVA: 0x16AB780
	public static GlyphRect get_zero() { }

	// RVA: 0x16AB7FC
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x16AB808
	public override int GetHashCode() { }

	// RVA: 0x16AB878
	public override bool Equals(object obj) { }

	// RVA: 0x16AB8F0
	public bool Equals(GlyphRect other) { }

	// RVA: 0x16AB98C
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

	// RVA: 0x16AB9D8
	public float get_width() { }

	// RVA: 0x16AB9E0
	public float get_height() { }

	// RVA: 0x16AB9E8
	public float get_horizontalBearingX() { }

	// RVA: 0x16AB9F0
	public float get_horizontalBearingY() { }

	// RVA: 0x16AB9F8
	public float get_horizontalAdvance() { }

	// RVA: 0x16ABA00
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x16ABA10
	public override int GetHashCode() { }

	// RVA: 0x16ABA88
	public override bool Equals(object obj) { }

	// RVA: 0x16ABB08
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

	// RVA: 0x16ABBAC
	public UInt32 get_index() { }

	// RVA: 0x16ABBB4
	public GlyphMetrics get_metrics() { }

	// RVA: 0x16ABBC8
	public GlyphRect get_glyphRect() { }

	// RVA: 0x16ABBD4
	public float get_scale() { }

	// RVA: 0x16ABBDC
	public int get_atlasIndex() { }

	// RVA: 0x16ABBE4
	public void set_atlasIndex(int value) { }

	// RVA: 0x16ABBEC
	public void .ctor() { }

	// RVA: 0x16ABC20
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x16ABCA0
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

	// RVA: 0x16ABD14
	public static FontEngineError LoadFontFace(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x16ABDC8
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x16ABE20
	public static FontEngineError LoadFontFace(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x16ABED4
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x16ABF2C
	public static FontEngineError LoadFontFace(string familyName, string styleName, int pointSize) { }

	// RVA: 0x16ABFE0
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x16AC038
	internal static bool TryGetSystemFontReference(string familyName, string styleName, FontReference fontRef) { }

	// RVA: 0x16AC0EC
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, FontReference fontRef) { }

	// RVA: 0x16AC144
	public static FaceInfo GetFaceInfo() { }

	// RVA: 0x16AC208
	private static int GetFaceInfo_Internal(FaceInfo faceInfo) { }

	// RVA: 0x16AC258
	internal static UInt32 GetGlyphIndex(UInt32 unicode) { }

	// RVA: 0x16AC2A8
	public static bool TryGetGlyphWithUnicodeValue(UInt32 unicode, GlyphLoadFlags flags, Glyph glyph) { }

	// RVA: 0x16AC428
	private static bool TryGetGlyphWithUnicodeValue_Internal(UInt32 unicode, GlyphLoadFlags loadFlags, GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x16AC480
	public static bool TryGetGlyphWithIndexValue(UInt32 glyphIndex, GlyphLoadFlags flags, Glyph glyph) { }

	// RVA: 0x16AC600
	private static bool TryGetGlyphWithIndexValue_Internal(UInt32 glyphIndex, GlyphLoadFlags loadFlags, GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x16AC658
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	// RVA: 0x16AC6A8
	internal static bool TryAddGlyphToTexture(UInt32 glyphIndex, int padding, GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, Glyph glyph) { }

	// RVA: 0x16ACC08
	private static bool TryAddGlyphToTexture_Internal(UInt32 glyphIndex, int padding, GlyphPackingMode packingMode, GlyphRect[] freeGlyphRects, int freeGlyphRectCount, GlyphRect[] usedGlyphRects, int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, GlyphMarshallingStruct glyph) { }

	// RVA: 0x16ACCAC
	internal static bool TryAddGlyphsToTexture(System.Collections.Generic.List<System.UInt32> glyphIndexes, int padding, GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, Glyph[] glyphs) { }

	// RVA: 0x16AD664
	private static bool TryAddGlyphsToTexture_Internal(UInt32[] glyphIndex, int padding, GlyphPackingMode packingMode, GlyphRect[] freeGlyphRects, int freeGlyphRectCount, GlyphRect[] usedGlyphRects, int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, GlyphMarshallingStruct[] glyphs, int glyphCount) { }

	// RVA: 0x16AD718
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(UInt32[] glyphIndexes) { }

	// RVA: 0x16AD96C
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes, int recordCount) { }

	// RVA: 0x16AD8B4
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(UInt32[] glyphIndexes, int recordCount) { }

	// RVA: 0x16AD91C
	private static int GetPairAdjustmentRecordsFromMarshallingArray(GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: 0x30A8E44
	private static void GenericListToMarshallingArray(System.Collections.Generic.List<T>& srcList, T[] dstArray) { }

	// RVA: 0x30A7F58
	private static void SetMarshallingArraySize(T[] marshallingArray, int recordCount) { }

	// RVA: 0x16ADB24
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x16ADB74
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontEngineUtilities
{
	// Methods

	// RVA: 0x16AD650
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

	// RVA: 0x16ADCFC
	public float get_xPlacement() { }

	// RVA: 0x16ADD04
	public void set_xPlacement(float value) { }

	// RVA: 0x16ADD0C
	public float get_yPlacement() { }

	// RVA: 0x16ADD14
	public void set_yPlacement(float value) { }

	// RVA: 0x16ADD1C
	public float get_xAdvance() { }

	// RVA: 0x16ADD24
	public float get_yAdvance() { }

	// RVA: 0x16ADD2C
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	// RVA: 0x16ADD40
	public override int GetHashCode() { }

	// RVA: 0x16ADDB0
	public override bool Equals(object obj) { }

	// RVA: 0x16ADE28
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

	// RVA: 0x16ADED8
	public UInt32 get_glyphIndex() { }

	// RVA: 0x16ADEE0
	public GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x16ADEEC
	public override int GetHashCode() { }

	// RVA: 0x16ADF64
	public override bool Equals(object obj) { }

	// RVA: 0x16ADFE4
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

	// RVA: 0x16AE088
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x16AE09C
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x16AE0B0
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x16AE0B8
	public override int GetHashCode() { }

	// RVA: 0x16AE130
	public override bool Equals(object obj) { }

	// RVA: 0x16AE1B0
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

	// RVA: 0x16AE254
	public float get_xCoordinate() { }

	// RVA: 0x16AE25C
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

	// RVA: 0x16AE264
	public float get_xPositionAdjustment() { }

	// RVA: 0x16AE26C
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

	// RVA: 0x16AE274
	public UInt32 get_baseGlyphID() { }

	// RVA: 0x16AE27C
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x16AE284
	public UInt32 get_markGlyphID() { }

	// RVA: 0x16AE28C
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

	// RVA: 0x16AE294
	public UInt32 get_baseMarkGlyphID() { }

	// RVA: 0x16AE29C
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x16AE2A4
	public UInt32 get_combiningMarkGlyphID() { }

	// RVA: 0x16AE2AC
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

	// RVA: 0x16AE2B4
	public UInt32[] get_componentGlyphIDs() { }

	// RVA: 0x16AE2BC
	public UInt32 get_ligatureGlyphID() { }

}


