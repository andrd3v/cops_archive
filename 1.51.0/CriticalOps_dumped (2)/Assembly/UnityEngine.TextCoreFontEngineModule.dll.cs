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
	private float m_PointSize; // 0x28
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

	// RVA: 0x1790230
	internal int get_faceIndex() { }

	// RVA: 0x1790238
	public string get_familyName() { }

	// RVA: 0x1790240
	public string get_styleName() { }

	// RVA: 0x1790248
	public float get_pointSize() { }

	// RVA: 0x1790250
	public float get_scale() { }

	// RVA: 0x1790258
	public void set_scale(float value) { }

	// RVA: 0x1790260
	internal int get_unitsPerEM() { }

	// RVA: 0x1790268
	internal void set_unitsPerEM(int value) { }

	// RVA: 0x1790270
	public float get_lineHeight() { }

	// RVA: 0x1790278
	public float get_ascentLine() { }

	// RVA: 0x1790280
	public float get_capLine() { }

	// RVA: 0x1790288
	public void set_capLine(float value) { }

	// RVA: 0x1790290
	public float get_meanLine() { }

	// RVA: 0x1790298
	public void set_meanLine(float value) { }

	// RVA: 0x17902A0
	public float get_baseline() { }

	// RVA: 0x17902A8
	public float get_descentLine() { }

	// RVA: 0x17902B0
	public float get_superscriptOffset() { }

	// RVA: 0x17902B8
	public float get_superscriptSize() { }

	// RVA: 0x17902C0
	public float get_subscriptOffset() { }

	// RVA: 0x17902C8
	public float get_subscriptSize() { }

	// RVA: 0x17902D0
	public float get_underlineOffset() { }

	// RVA: 0x17902D8
	public float get_underlineThickness() { }

	// RVA: 0x17902E0
	public float get_strikethroughOffset() { }

	// RVA: 0x17902E8
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x17902F0
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

	// RVA: 0x17902F8
	public int get_x() { }

	// RVA: 0x1790300
	public int get_y() { }

	// RVA: 0x1790308
	public int get_width() { }

	// RVA: 0x1790310
	public int get_height() { }

	// RVA: 0x1790318
	public static GlyphRect get_zero() { }

	// RVA: 0x1790394
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x17903A0
	public override int GetHashCode() { }

	// RVA: 0x1790410
	public override bool Equals(object obj) { }

	// RVA: 0x1790488
	public bool Equals(GlyphRect other) { }

	// RVA: 0x1790524
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

	// RVA: 0x1790570
	public float get_width() { }

	// RVA: 0x1790578
	public float get_height() { }

	// RVA: 0x1790580
	public float get_horizontalBearingX() { }

	// RVA: 0x1790588
	public float get_horizontalBearingY() { }

	// RVA: 0x1790590
	public float get_horizontalAdvance() { }

	// RVA: 0x1790598
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x17905A8
	public override int GetHashCode() { }

	// RVA: 0x1790620
	public override bool Equals(object obj) { }

	// RVA: 0x17906A0
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

	// RVA: 0x1790744
	public UInt32 get_index() { }

	// RVA: 0x179074C
	public GlyphMetrics get_metrics() { }

	// RVA: 0x1790760
	public GlyphRect get_glyphRect() { }

	// RVA: 0x179076C
	public float get_scale() { }

	// RVA: 0x1790774
	public int get_atlasIndex() { }

	// RVA: 0x179077C
	public void set_atlasIndex(int value) { }

	// RVA: 0x1790784
	public void .ctor() { }

	// RVA: 0x17907B8
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1790838
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
	public const GlyphRenderMode DEFAULT = 0;
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
	private static LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray; // 0x30
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x38
	private static MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray; // 0x40
	private static MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray; // 0x48
	private static System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> s_GlyphLookupDictionary; // 0x50

	// Methods

	// RVA: 0x17908AC
	public static FontEngineError LoadFontFace(string filePath, float pointSize, int faceIndex) { }

	// RVA: 0x17909DC
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x1790C08
	public static FontEngineError LoadFontFace(Font font, float pointSize, int faceIndex) { }

	// RVA: 0x1790DF4
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x1790F3C
	public static FontEngineError LoadFontFace(string familyName, string styleName, float pointSize) { }

	// RVA: 0x179106C
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x1791360
	internal static bool IsColorFontFace() { }

	// RVA: 0x17913A0
	internal static bool TryGetSystemFontReference(string familyName, string styleName, FontReference fontRef) { }

	// RVA: 0x1791418
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, FontReference fontRef) { }

	// RVA: 0x179170C
	public static FaceInfo GetFaceInfo() { }

	// RVA: 0x17917D0
	private static int GetFaceInfo_Internal(FaceInfo faceInfo) { }

	// RVA: 0x1791820
	internal static UInt32 GetVariantGlyphIndex(UInt32 unicode, UInt32 variantSelectorUnicode) { }

	// RVA: 0x1791888
	internal static UInt32 GetGlyphIndex(UInt32 unicode) { }

	// RVA: 0x17918D8
	public static bool TryGetGlyphWithUnicodeValue(UInt32 unicode, GlyphLoadFlags flags, Glyph glyph) { }

	// RVA: 0x1791A58
	private static bool TryGetGlyphWithUnicodeValue_Internal(UInt32 unicode, GlyphLoadFlags loadFlags, GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1791AB0
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	// RVA: 0x1791B00
	internal static bool TryAddGlyphToTexture(UInt32 glyphIndex, int padding, GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, Glyph glyph) { }

	// RVA: 0x1792034
	private static bool TryAddGlyphToTexture_Internal(UInt32 glyphIndex, int padding, GlyphPackingMode packingMode, GlyphRect[] freeGlyphRects, int freeGlyphRectCount, GlyphRect[] usedGlyphRects, int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, GlyphMarshallingStruct glyph) { }

	// RVA: 0x1792328
	internal static bool TryAddGlyphsToTexture(System.Collections.Generic.List<System.UInt32> glyphIndexes, int padding, GlyphPackingMode packingMode, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> freeGlyphRects, System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, Glyph[] glyphs) { }

	// RVA: 0x1792CD8
	private static bool TryAddGlyphsToTexture_Internal(UInt32[] glyphIndex, int padding, GlyphPackingMode packingMode, GlyphRect[] freeGlyphRects, int freeGlyphRectCount, GlyphRect[] usedGlyphRects, int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, GlyphMarshallingStruct[] glyphs, int glyphCount) { }

	// RVA: 0x17930D8
	internal static LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords() { }

	// RVA: 0x1793118
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(UInt32 glyphIndex) { }

	// RVA: 0x17933A0
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes) { }

	// RVA: 0x179323C
	private static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(UInt32[] glyphIndexes) { }

	// RVA: 0x1793438
	private static int PopulateLigatureSubstitutionRecordMarshallingArray(UInt32[] glyphIndexes, int recordCount) { }

	// RVA: 0x1793550
	private static int GetLigatureSubstitutionRecordsFromMarshallingArray(LigatureSubstitutionRecord[] ligatureSubstitutionRecords) { }

	// RVA: 0x1793608
	internal static GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords() { }

	// RVA: 0x179378C
	internal static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes) { }

	// RVA: 0x1793824
	private static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(UInt32[] glyphIndexes) { }

	// RVA: 0x179398C
	private static int PopulatePairAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, int recordCount) { }

	// RVA: 0x1793AA4
	private static int GetPairAdjustmentRecordsFromMarshallingArray(System.Span<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords) { }

	// RVA: 0x1793C4C
	internal static MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords() { }

	// RVA: 0x1793DD0
	internal static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes) { }

	// RVA: 0x1793E68
	private static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(UInt32[] glyphIndexes) { }

	// RVA: 0x1793FCC
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, int recordCount) { }

	// RVA: 0x17940E4
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(System.Span<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> adjustmentRecords) { }

	// RVA: 0x179428C
	internal static MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords() { }

	// RVA: 0x1794410
	internal static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes) { }

	// RVA: 0x179449C
	private static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(UInt32[] glyphIndexes) { }

	// RVA: 0x1794608
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, int recordCount) { }

	// RVA: 0x1794720
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(System.Span<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> adjustmentRecords) { }

	// RVA: 0x1793194
	private static void GlyphIndexToMarshallingArray(UInt32 glyphIndex, UInt32[] dstArray) { }

	// RVA: 0x352CF50
	private static void GenericListToMarshallingArray(System.Collections.Generic.List<T>& srcList, T[] dstArray) { }

	// RVA: 0x352C064
	private static void SetMarshallingArraySize(T[] marshallingArray, int recordCount) { }

	// RVA: 0x17948C8
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x1794A00
	private static void .cctor() { }

	// RVA: 0x1790BB0
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(ManagedSpanWrapper filePath, int pointSize, int faceIndex) { }

	// RVA: 0x1790EE4
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(IntPtr font, int pointSize, int faceIndex) { }

	// RVA: 0x1791308
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(ManagedSpanWrapper familyName, ManagedSpanWrapper styleName, int pointSize) { }

	// RVA: 0x17916B4
	private static bool TryGetSystemFontReference_Internal_Injected(ManagedSpanWrapper familyName, ManagedSpanWrapper styleName, FontReference fontRef) { }

	// RVA: 0x1792284
	private static bool TryAddGlyphToTexture_Internal_Injected(UInt32 glyphIndex, int padding, GlyphPackingMode packingMode, BlittableArrayWrapper freeGlyphRects, int freeGlyphRectCount, BlittableArrayWrapper usedGlyphRects, int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, GlyphMarshallingStruct glyph) { }

	// RVA: 0x1793024
	private static bool TryAddGlyphsToTexture_Internal_Injected(ManagedSpanWrapper glyphIndex, int padding, GlyphPackingMode packingMode, BlittableArrayWrapper freeGlyphRects, int freeGlyphRectCount, BlittableArrayWrapper usedGlyphRects, int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, BlittableArrayWrapper glyphs, int glyphCount) { }

	// RVA: 0x17935A0
	private static int PopulateLigatureSubstitutionRecordMarshallingArray_Injected(ManagedSpanWrapper glyphIndexes, int recordCount) { }

	// RVA: 0x179373C
	private static void GetAllPairAdjustmentRecords_Injected(BlittableArrayWrapper ret) { }

	// RVA: 0x1793B94
	private static int PopulatePairAdjustmentRecordMarshallingArray_Injected(ManagedSpanWrapper glyphIndexes, int recordCount) { }

	// RVA: 0x1793BFC
	private static int GetPairAdjustmentRecordsFromMarshallingArray_Injected(ManagedSpanWrapper glyphPairAdjustmentRecords) { }

	// RVA: 0x1793D80
	private static void GetAllMarkToBaseAdjustmentRecords_Injected(BlittableArrayWrapper ret) { }

	// RVA: 0x17941D4
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(ManagedSpanWrapper glyphIndexes, int recordCount) { }

	// RVA: 0x179423C
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(ManagedSpanWrapper adjustmentRecords) { }

	// RVA: 0x17943C0
	private static void GetAllMarkToMarkAdjustmentRecords_Injected(BlittableArrayWrapper ret) { }

	// RVA: 0x1794810
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(ManagedSpanWrapper glyphIndexes, int recordCount) { }

	// RVA: 0x1794878
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(ManagedSpanWrapper adjustmentRecords) { }

	// RVA: 0x17949B0
	private static void ResetAtlasTexture_Injected(IntPtr texture) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontEngineUtilities
{
	// Methods

	// RVA: 0x1792CC4
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

	// RVA: 0x1794B88
	public float get_xPlacement() { }

	// RVA: 0x1794B90
	public void set_xPlacement(float value) { }

	// RVA: 0x1794B98
	public float get_yPlacement() { }

	// RVA: 0x1794BA0
	public void set_yPlacement(float value) { }

	// RVA: 0x1794BA8
	public float get_xAdvance() { }

	// RVA: 0x1794BB0
	public void set_xAdvance(float value) { }

	// RVA: 0x1794BB8
	public float get_yAdvance() { }

	// RVA: 0x1794BC0
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	// RVA: 0x1794BD4
	public override int GetHashCode() { }

	// RVA: 0x1794C44
	public override bool Equals(object obj) { }

	// RVA: 0x1794CBC
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

	// RVA: 0x1794D6C
	public UInt32 get_glyphIndex() { }

	// RVA: 0x1794D74
	public GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x1794D80
	public void .ctor(UInt32 glyphIndex, GlyphValueRecord glyphValueRecord) { }

	// RVA: 0x1794D90
	public override int GetHashCode() { }

	// RVA: 0x1794E08
	public override bool Equals(object obj) { }

	// RVA: 0x1794E88
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

	// RVA: 0x1794F2C
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x1794F40
	public void set_firstAdjustmentRecord(GlyphAdjustmentRecord value) { }

	// RVA: 0x1794F54
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x1794F68
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x1794F70
	public override int GetHashCode() { }

	// RVA: 0x1794FE8
	public override bool Equals(object obj) { }

	// RVA: 0x1795068
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

	// RVA: 0x179510C
	public float get_xCoordinate() { }

	// RVA: 0x1795114
	public void set_xCoordinate(float value) { }

	// RVA: 0x179511C
	public float get_yCoordinate() { }

	// RVA: 0x1795124
	public void set_yCoordinate(float value) { }

}

// Namespace: UnityEngine.TextCore.LowLevel
[Serializable]
internal struct MarkPositionAdjustment
{
	// Fields
	private float m_XPositionAdjustment; // 0x10
	private float m_YPositionAdjustment; // 0x14

	// Methods

	// RVA: 0x179512C
	public float get_xPositionAdjustment() { }

	// RVA: 0x1795134
	public void set_xPositionAdjustment(float value) { }

	// RVA: 0x179513C
	public float get_yPositionAdjustment() { }

	// RVA: 0x1795144
	public void set_yPositionAdjustment(float value) { }

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

	// RVA: 0x179514C
	public UInt32 get_baseGlyphID() { }

	// RVA: 0x1795154
	public void set_baseGlyphID(UInt32 value) { }

	// RVA: 0x179515C
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x1795164
	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x179516C
	public UInt32 get_markGlyphID() { }

	// RVA: 0x1795174
	public void set_markGlyphID(UInt32 value) { }

	// RVA: 0x179517C
	public MarkPositionAdjustment get_markPositionAdjustment() { }

	// RVA: 0x1795184
	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }

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

	// RVA: 0x179518C
	public UInt32 get_baseMarkGlyphID() { }

	// RVA: 0x1795194
	public void set_baseMarkGlyphID(UInt32 value) { }

	// RVA: 0x179519C
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x17951A4
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x17951AC
	public UInt32 get_combiningMarkGlyphID() { }

	// RVA: 0x17951B4
	public void set_combiningMarkGlyphID(UInt32 value) { }

	// RVA: 0x17951BC
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	// RVA: 0x17951C4
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }

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

	// RVA: 0x17951CC
	public UInt32[] get_componentGlyphIDs() { }

	// RVA: 0x17951D4
	public void set_componentGlyphIDs(UInt32[] value) { }

	// RVA: 0x17951DC
	public UInt32 get_ligatureGlyphID() { }

	// RVA: 0x17951E4
	public void set_ligatureGlyphID(UInt32 value) { }

	// RVA: 0x17951EC
	public bool Equals(LigatureSubstitutionRecord other) { }

	// RVA: 0x17952B0
	public override bool Equals(object obj) { }

	// RVA: 0x1795394
	public override int GetHashCode() { }

	// RVA: 0x1795254
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

}


