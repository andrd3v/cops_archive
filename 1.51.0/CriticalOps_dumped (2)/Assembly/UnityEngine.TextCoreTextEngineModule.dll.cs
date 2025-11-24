// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x17953B8
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x17953C0
	public void .ctor(Byte ) { }

	// RVA: 0x179544C
	public void .ctor(Byte[] ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x1795480
	public void .ctor(Byte ) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.TextCore.NativeTextGenerationSettings.<>c <>9; // 0x0
	public static System.Predicate<UnityEngine.TextCore.TextSpan> <>9__20_0; // 0x8

	// Methods

	// RVA: 0x17963F0
	private static void .cctor() { }

	// RVA: 0x179645C
	public void .ctor() { }

	// RVA: 0x1796464
	internal bool <get_hasLink>b__20_0(TextSpan span) { }

}

// Namespace: UnityEngine.TextCore
internal struct NativeTextGenerationSettings
{
	// Fields
	public IntPtr fontAsset; // 0x10
	public IntPtr textSettings; // 0x18
	public string text; // 0x20
	public int screenWidth; // 0x28
	public int screenHeight; // 0x2C
	public WhiteSpace wordWrap; // 0x30
	public TextOverflow overflow; // 0x34
	public LanguageDirection languageDirection; // 0x38
	public int vertexPadding; // 0x3C
	internal HorizontalAlignment horizontalAlignment; // 0x40
	internal VerticalAlignment verticalAlignment; // 0x44
	public int fontSize; // 0x48
	public FontStyles fontStyle; // 0x4C
	public TextFontWeight fontWeight; // 0x50
	public TextSpan[] textSpans; // 0x58
	public Color32 color; // 0x60
	public int characterSpacing; // 0x64
	public int wordSpacing; // 0x68
	public int paragraphSpacing; // 0x6C

	// Methods

	// RVA: 0x17954AC
	public bool get_hasLink() { }

	// RVA: 0x17955E8
	public TextSpan CreateTextSpan() { }

	// RVA: 0x179560C
	public static NativeTextGenerationSettings get_Default() { }

	// RVA: 0x1795664
	public override string ToString() { }

}

// Namespace: UnityEngine.TextCore
internal struct TextSpan
{
	// Fields
	public int startIndex; // 0x10
	public int length; // 0x14
	public IntPtr fontAsset; // 0x18
	public int fontSize; // 0x20
	public Color32 color; // 0x24
	public FontStyles fontStyle; // 0x28
	public TextFontWeight fontWeight; // 0x2C
	public int linkID; // 0x30

	// Methods

	// RVA: 0x1796020
	public override string ToString() { }

}

// Namespace: UnityEngine.TextCore
internal enum HorizontalAlignment
{
	// Fields
	public int value__; // 0x10
	public const HorizontalAlignment Left = 0;
	public const HorizontalAlignment Center = 1;
	public const HorizontalAlignment Right = 2;
	public const HorizontalAlignment Justified = 3;
}

// Namespace: UnityEngine.TextCore
internal enum VerticalAlignment
{
	// Fields
	public int value__; // 0x10
	public const VerticalAlignment Top = 0;
	public const VerticalAlignment Middle = 1;
	public const VerticalAlignment Bottom = 2;
}

// Namespace: UnityEngine.TextCore
internal enum LanguageDirection
{
	// Fields
	public int value__; // 0x10
	public const LanguageDirection LTR = 0;
	public const LanguageDirection RTL = 1;
}

// Namespace: UnityEngine.TextCore
internal enum WhiteSpace
{
	// Fields
	public int value__; // 0x10
	public const WhiteSpace Normal = 0;
	public const WhiteSpace NoWrap = 1;
	public const WhiteSpace Pre = 2;
	public const WhiteSpace PreWrap = 3;
}

// Namespace: UnityEngine.TextCore
internal enum TextOverflow
{
	// Fields
	public int value__; // 0x10
	public const TextOverflow Clip = 0;
	public const TextOverflow Ellipsis = 1;
}

// Namespace: 
public enum TagType
{
	// Fields
	public int value__; // 0x10
	public const TagType Hyperlink = 0;
	public const TagType Align = 1;
	public const TagType AllCaps = 2;
	public const TagType Alpha = 3;
	public const TagType Bold = 4;
	public const TagType Br = 5;
	public const TagType Color = 6;
	public const TagType CSpace = 7;
	public const TagType Font = 8;
	public const TagType FontWeight = 9;
	public const TagType Italic = 10;
	public const TagType Indent = 11;
	public const TagType LineHeight = 12;
	public const TagType LineIndent = 13;
	public const TagType Link = 14;
	public const TagType Lowercase = 15;
	public const TagType Mark = 16;
	public const TagType Mspace = 17;
	public const TagType NoBr = 18;
	public const TagType NoParse = 19;
	public const TagType Strikethrough = 20;
	public const TagType Size = 21;
	public const TagType SmallCaps = 22;
	public const TagType Space = 23;
	public const TagType Sprite = 24;
	public const TagType Style = 25;
	public const TagType Subscript = 26;
	public const TagType Superscript = 27;
	public const TagType Underline = 28;
	public const TagType Uppercase = 29;
	public const TagType Unknown = 30;
}

// Namespace: 
internal class TagTypeInfo
{
	// Fields
	public TagType TagType; // 0x10
	public string name; // 0x18
	public TagValueType valueType; // 0x20
	public TagUnitType unitType; // 0x24

	// Methods

	// RVA: 0x1799EA8
	protected virtual Type get_EqualityContract() { }

	// RVA: 0x1799E4C
	internal void .ctor(TagType tagType, string name, TagValueType valueType, TagUnitType unitType) { }

	// RVA: 0x1799F38
	public override string ToString() { }

	// RVA: 0x179A02C
	protected virtual bool PrintMembers(StringBuilder builder) { }

	// RVA: 0x179A1F8
	public override int GetHashCode() { }

	// RVA: 0x179A36C
	public override bool Equals(object obj) { }

	// RVA: 0x179A400
	public virtual bool Equals(TagTypeInfo other) { }

}

// Namespace: 
internal enum TagValueType
{
	// Fields
	public int value__; // 0x10
	public const TagValueType None = 0;
	public const TagValueType NumericalValue = 1;
	public const TagValueType StringValue = 2;
	public const TagValueType ColorValue = 4;
}

// Namespace: 
internal enum TagUnitType
{
	// Fields
	public int value__; // 0x10
	public const TagUnitType Pixels = 0;
	public const TagUnitType FontUnits = 1;
	public const TagUnitType Percentage = 2;
}

// Namespace: 
internal class TagValue
{
	// Fields
	internal TagValueType type; // 0x10
	private string m_stringValue; // 0x18
	private float m_numericalValue; // 0x20
	private Color m_colorValue; // 0x24

	// Methods

	// RVA: 0x179A5C4
	protected virtual Type get_EqualityContract() { }

	// RVA: 0x17973B0
	internal void .ctor(Color value) { }

	// RVA: 0x1797404
	internal void .ctor(string value) { }

	// RVA: 0x1798C2C
	internal string get_StringValue() { }

	// RVA: 0x1798BB8
	internal Color get_ColorValue() { }

	// RVA: 0x179A654
	public override string ToString() { }

	// RVA: 0x179A748
	protected virtual bool PrintMembers(StringBuilder builder) { }

	// RVA: 0x179A750
	public override int GetHashCode() { }

	// RVA: 0x179A8C8
	public override bool Equals(object obj) { }

	// RVA: 0x179A95C
	public virtual bool Equals(TagValue other) { }

}

// Namespace: 
internal struct Tag
{
	// Fields
	public TagType tagType; // 0x10
	public bool isClosing; // 0x14
	public int start; // 0x18
	public int end; // 0x1C
	public TagValue value; // 0x20
}

// Namespace: 
public struct Segment
{
	// Fields
	public System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> tags; // 0x10
	public int start; // 0x18
	public int end; // 0x1C
}

// Namespace: 
internal class ParseError
{
	// Fields
	public readonly int position; // 0x10
	public readonly string message; // 0x18

	// Methods

	// RVA: 0x179AB28
	protected virtual Type get_EqualityContract() { }

	// RVA: 0x1797368
	internal void .ctor(string message, int position) { }

	// RVA: 0x179ABB8
	public override string ToString() { }

	// RVA: 0x179ACAC
	protected virtual bool PrintMembers(StringBuilder builder) { }

	// RVA: 0x179AD70
	public override int GetHashCode() { }

	// RVA: 0x179AE6C
	public override bool Equals(object obj) { }

	// RVA: 0x179AF00
	public virtual bool Equals(ParseError other) { }

}

// Namespace: UnityEngine.TextCore
internal static class RichTextTagParser
{
	// Fields
	internal static readonly TagTypeInfo[] TagsInfo; // 0x0

	// Methods

	// RVA: 0x1796474
	private static bool tagMatch(System.ReadOnlySpan<System.Char> tagCandidate, string tagName) { }

	// RVA: 0x1796600
	private static bool SpanToEnum(System.ReadOnlySpan<System.Char> tagCandidate, TagType tagType, string error, System.ReadOnlySpan<System.Char>& attribute) { }

	// RVA: 0x17968B8
	internal static System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> FindTags(string inputStr, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.ParseError> errors) { }

	// RVA: 0x1797440
	internal static System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> PickResultingTags(System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> allTags, string input, int atPosition, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> applicableTags) { }

	// RVA: 0x1798140
	internal static Segment[] GenerateSegments(string input, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> tags) { }

	// RVA: 0x1798430
	internal static void ApplyStateToSegment(string input, System.Collections.Generic.List<UnityEngine.TextCore.RichTextTagParser.Tag> tags, Segment[] segments) { }

	// RVA: 0x1798510
	private static int AddLink(TagType type, string value, System.Collections.Generic.List<System.ValueTuple<System.Int32,UnityEngine.TextCore.RichTextTagParser.TagType,System.String>> links) { }

	// RVA: 0x179878C
	private static TextSpan CreateTextSpan(Segment segment, NativeTextGenerationSettings tgs, System.Collections.Generic.List<System.ValueTuple<System.Int32,UnityEngine.TextCore.RichTextTagParser.TagType,System.String>> links, Color hyperlinkColor) { }

	// RVA: 0x1798C9C
	internal static void CreateTextGenerationSettingsArray(NativeTextGenerationSettings tgs, System.Collections.Generic.List<System.ValueTuple<System.Int32,UnityEngine.TextCore.RichTextTagParser.TagType,System.String>> links, Color hyperlinkColor) { }

	// RVA: 0x1798F8C
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct ATGMeshInfo
{
	// Fields
	public NativeTextElementInfo[] textElementInfos; // 0x10
	public int fontAssetId; // 0x18
	public int textElementCount; // 0x1C
	public FontAsset fontAsset; // 0x20
	public System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> textElementInfoIndicesByAtlas; // 0x28
	public bool hasMultipleColors; // 0x30
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class Character
{
	// Methods

	// RVA: 0x179B054
	public void .ctor() { }

	// RVA: 0x179B08C
	public void .ctor(UInt32 unicode, FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x179B12C
	internal void .ctor(UInt32 unicode, UInt32 glyphIndex) { }

}

// Namespace: UnityEngine.TextCore.Text
internal static class ColorUtilities
{
	// Methods

	// RVA: 0x179B1B4
	internal static bool CompareColors(Color32 a, Color32 b) { }

	// RVA: 0x179B1C4
	internal static Color32 MultiplyColors(Color32 c1, Color32 c2) { }

}

// Namespace: UnityEngine.TextCore.Text
public class FastAction
{
	// Fields
	private System.Collections.Generic.LinkedList<System.Action> delegates; // 0x10
	private System.Collections.Generic.Dictionary<System.Action,System.Collections.Generic.LinkedListNode<System.Action>> lookup; // 0x18

	// Methods

	// RVA: 0x179B2A8
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
public class FastAction<T0>
{
	// Fields
	private System.Collections.Generic.LinkedList<System.Action<A>> delegates; // 0x0
	private System.Collections.Generic.Dictionary<System.Action<A>,System.Collections.Generic.LinkedListNode<System.Action<A>>> lookup; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
public class FastAction<T0, T1>
{
	// Fields
	private System.Collections.Generic.LinkedList<System.Action<A,B>> delegates; // 0x0
	private System.Collections.Generic.Dictionary<System.Action<A,B>,System.Collections.Generic.LinkedListNode<System.Action<A,B>>> lookup; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public void Call(A a, B b) { }

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
public class FastAction<T0, T1, T2>
{
	// Fields
	private System.Collections.Generic.LinkedList<System.Action<A,B,C>> delegates; // 0x0
	private System.Collections.Generic.Dictionary<System.Action<A,B,C>,System.Collections.Generic.LinkedListNode<System.Action<A,B,C>>> lookup; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
public enum OTL_FeatureTag
{
	// Fields
	public UInt32 value__; // 0x10
	public const OTL_FeatureTag kern = 1801810542;
	public const OTL_FeatureTag liga = 1818847073;
	public const OTL_FeatureTag mark = 1835102827;
	public const OTL_FeatureTag mkmk = 1835756907;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.TextCore.Text.FontFeatureTable.<>c <>9; // 0x0
	public static System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord,System.UInt32> <>9__24_0; // 0x8
	public static System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord,System.UInt32> <>9__24_1; // 0x10
	public static System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord,System.UInt32> <>9__25_0; // 0x18
	public static System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord,System.UInt32> <>9__25_1; // 0x20
	public static System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord,System.UInt32> <>9__26_0; // 0x28
	public static System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord,System.UInt32> <>9__26_1; // 0x30

	// Methods

	// RVA: 0x179BCFC
	private static void .cctor() { }

	// RVA: 0x179BD68
	public void .ctor() { }

	// RVA: 0x179BD70
	internal UInt32 <SortGlyphPairAdjustmentRecords>b__24_0(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x179BDB4
	internal UInt32 <SortGlyphPairAdjustmentRecords>b__24_1(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x179BDF8
	internal UInt32 <SortMarkToBaseAdjustmentRecords>b__25_0(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x179BE04
	internal UInt32 <SortMarkToBaseAdjustmentRecords>b__25_1(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x179BE10
	internal UInt32 <SortMarkToMarkAdjustmentRecords>b__26_0(MarkToMarkAdjustmentRecord s) { }

	// RVA: 0x179BE1C
	internal UInt32 <SortMarkToMarkAdjustmentRecords>b__26_1(MarkToMarkAdjustmentRecord s) { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class FontFeatureTable
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; // 0x10
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; // 0x18
	private System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x20
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; // 0x28
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; // 0x30
	internal System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; // 0x38
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x40
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; // 0x48
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; // 0x50

	// Methods

	// RVA: 0x179B388
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x179B390
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	// RVA: 0x179B398
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	// RVA: 0x179B3A0
	internal void .ctor() { }

	// RVA: 0x179B658
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x179B88C
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x179BAC4
	public void SortMarkToMarkAdjustmentRecords() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct Extents
{
	// Fields
	public Vector2 min; // 0x10
	public Vector2 max; // 0x18

	// Methods

	// RVA: 0x179BE28
	public override string ToString() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct LineInfo
{
	// Fields
	internal int controlCharacterCount; // 0x10
	public int characterCount; // 0x14
	public int visibleCharacterCount; // 0x18
	public int visibleSpaceCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int firstCharacterIndex; // 0x28
	public int firstVisibleCharacterIndex; // 0x2C
	public int lastCharacterIndex; // 0x30
	public int lastVisibleCharacterIndex; // 0x34
	public float length; // 0x38
	public float lineHeight; // 0x3C
	public float ascender; // 0x40
	public float baseline; // 0x44
	public float descender; // 0x48
	public float maxAdvance; // 0x4C
	public float width; // 0x50
	public float marginLeft; // 0x54
	public float marginRight; // 0x58
	public TextAlignment alignment; // 0x5C
	public Extents lineExtents; // 0x60
}

// Namespace: UnityEngine.TextCore.Text
internal struct LinkInfo
{
	// Fields
	public int hashCode; // 0x10
	public int linkIdFirstCharacterIndex; // 0x14
	public int linkIdLength; // 0x18
	public int linkTextfirstCharacterIndex; // 0x1C
	public int linkTextLength; // 0x20
	internal Char[] linkId; // 0x28
	private string m_LinkIdString; // 0x30
	private string m_LinkTextString; // 0x38

	// Methods

	// RVA: 0x179C05C
	internal void SetLinkId(Char[] text, int startIndex, int length) { }

	// RVA: 0x179C180
	public string GetLinkText(TextInfo textInfo) { }

	// RVA: 0x179C28C
	public string GetLinkId() { }

}

// Namespace: UnityEngine.TextCore.Text
internal static class MaterialManager
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Material> s_FallbackMaterials; // 0x0

	// Methods

	// RVA: 0x179C2E8
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x179C9FC
	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x179C75C
	private static void CopyMaterialPresetProperties(Material source, Material destination) { }

	// RVA: 0x179CC40
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct MaterialReference
{
	// Fields
	public int index; // 0x10
	public FontAsset fontAsset; // 0x18
	public SpriteAsset spriteAsset; // 0x20
	public Material material; // 0x28
	public bool isFallbackMaterial; // 0x30
	public Material fallbackMaterial; // 0x38
	public float padding; // 0x40
	public int referenceCount; // 0x44

	// Methods

	// RVA: 0x179CCDC
	public void .ctor(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x179CD60
	public static int AddMaterialReference(Material material, FontAsset fontAsset, MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup) { }

	// RVA: 0x179CF74
	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup) { }

}

// Namespace: UnityEngine.TextCore.Text
internal class MaterialReferenceManager
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.Material> m_FontMaterialReferenceLookup; // 0x10
	private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset> m_FontAssetReferenceLookup; // 0x18
	private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Methods

	// RVA: 0x179D188
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x179D3B8
	public static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x179D458
	private void AddFontAssetInternal(FontAsset fontAsset) { }

	// RVA: 0x179D564
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x179D60C
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x179D714
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x179D7FC
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x179D878
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x179D920
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x179D9CC
	public static bool TryGetFontAsset(int hashCode, FontAsset fontAsset) { }

	// RVA: 0x179DAC4
	private bool TryGetFontAssetInternal(int hashCode, FontAsset fontAsset) { }

	// RVA: 0x179DB50
	public static bool TryGetSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x179DC48
	private bool TryGetSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x179DCD4
	public static bool TryGetColorGradientPreset(int hashCode, TextColorGradient gradientPreset) { }

	// RVA: 0x179DDCC
	private bool TryGetColorGradientPresetInternal(int hashCode, TextColorGradient gradientPreset) { }

	// RVA: 0x179DE58
	public static bool TryGetMaterial(int hashCode, Material material) { }

	// RVA: 0x179DF50
	private bool TryGetMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x179D230
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct MeshInfoBindings
{
	// Fields
	public TextCoreVertex[] vertexData; // 0x10
	public Material material; // 0x18
	public int vertexCount; // 0x20
}

// Namespace: UnityEngine.TextCore.Text
internal struct MeshInfo
{
	// Fields
	public int vertexCount; // 0x10
	public TextCoreVertex[] vertexData; // 0x18
	public Material material; // 0x20
	public int vertexBufferSize; // 0x28
	public bool applySDF; // 0x2C
	internal GlyphRenderMode glyphRenderMode; // 0x30

	// Methods

	// RVA: 0x179DFDC
	public void .ctor(int size, bool isIMGUI) { }

	// RVA: 0x179E0AC
	internal void ResizeMeshInfo(int size, bool isIMGUI) { }

	// RVA: 0x179E12C
	internal void Clear(bool uploadChanges) { }

	// RVA: 0x179E178
	internal void ClearUnusedVertices() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct NativeTextElementInfo
{
	// Fields
	public int glyphID; // 0x10
	public TextCoreVertex bottomLeft; // 0x14
	public TextCoreVertex topLeft; // 0x34
	public TextCoreVertex topRight; // 0x54
	public TextCoreVertex bottomRight; // 0x74
}

// Namespace: UnityEngine.TextCore.Text
internal struct NativeTextInfo
{
	// Fields
	public ATGMeshInfo[] meshInfos; // 0x10
}

// Namespace: UnityEngine.TextCore.Text
public enum TextFontWeight
{
	// Fields
	public int value__; // 0x10
	public const TextFontWeight Thin = 100;
	public const TextFontWeight ExtraLight = 200;
	public const TextFontWeight Light = 300;
	public const TextFontWeight Regular = 400;
	public const TextFontWeight Medium = 500;
	public const TextFontWeight SemiBold = 600;
	public const TextFontWeight Bold = 700;
	public const TextFontWeight Heavy = 800;
	public const TextFontWeight Black = 900;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public struct FontWeightPair
{
	// Fields
	public FontAsset regularTypeface; // 0x10
	public FontAsset italicTypeface; // 0x18
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public struct FontAssetCreationEditorSettings
{
	// Fields
	public string sourceFontFileGUID; // 0x10
	public int faceIndex; // 0x18
	public int pointSizeSamplingMode; // 0x1C
	public float pointSize; // 0x20
	public int padding; // 0x24
	public int paddingMode; // 0x28
	public int packingMode; // 0x2C
	public int atlasWidth; // 0x30
	public int atlasHeight; // 0x34
	public int characterSetSelectionMode; // 0x38
	public string characterSequence; // 0x40
	public string referencedFontAssetGUID; // 0x48
	public string referencedTextAssetGUID; // 0x50
	public int fontStyle; // 0x58
	public float fontStyleModifier; // 0x5C
	public int renderMode; // 0x60
	public bool includeFontFeatures; // 0x64
}

// Namespace: UnityEngine.TextCore.Text
public enum AtlasPopulationMode
{
	// Fields
	public int value__; // 0x10
	public const AtlasPopulationMode Static = 0;
	public const AtlasPopulationMode Dynamic = 1;
	public const AtlasPopulationMode DynamicOS = 2;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.TextCore.Text.FontAsset.<>c <>9; // 0x0
	public static System.Func<UnityEngine.TextCore.Text.Character,System.UInt32> <>9__189_0; // 0x8
	public static System.Func<UnityEngine.TextCore.Glyph,System.UInt32> <>9__190_0; // 0x10

	// Methods

	// RVA: 0x17AC6AC
	private static void .cctor() { }

	// RVA: 0x17AC718
	public void .ctor() { }

	// RVA: 0x17AC720
	internal UInt32 <SortCharacterTable>b__189_0(Character c) { }

	// RVA: 0x17AC73C
	internal UInt32 <SortGlyphTable>b__190_0(Glyph c) { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class FontAsset
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset> kFontAssetByInstanceId; // 0x0
	internal string m_SourceFontFileGUID; // 0x38
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x40
	private Font m_SourceFontFile; // 0x98
	internal string m_SourceFontFilePath; // 0xA0
	private AtlasPopulationMode m_AtlasPopulationMode; // 0xA8
	internal bool InternalDynamicOS; // 0xAC
	internal bool IsEditorFont; // 0xAD
	internal FaceInfo m_FaceInfo; // 0xB0
	private int m_FamilyNameHashCode; // 0x110
	private int m_StyleNameHashCode; // 0x114
	internal System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphTable; // 0x118
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> m_GlyphLookupDictionary; // 0x120
	internal System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharacterTable; // 0x128
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.Character> m_CharacterLookupDictionary; // 0x130
	internal Texture2D m_AtlasTexture; // 0x138
	internal Texture2D[] m_AtlasTextures; // 0x140
	internal int m_AtlasTextureIndex; // 0x148
	private bool m_IsMultiAtlasTexturesEnabled; // 0x14C
	private bool m_GetFontFeatures; // 0x14D
	private bool m_ClearDynamicDataOnBuild; // 0x14E
	internal int m_AtlasWidth; // 0x150
	internal int m_AtlasHeight; // 0x154
	internal int m_AtlasPadding; // 0x158
	internal GlyphRenderMode m_AtlasRenderMode; // 0x15C
	private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects; // 0x160
	private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects; // 0x168
	internal FontFeatureTable m_FontFeatureTable; // 0x170
	internal bool m_ShouldReimportFontFeatures; // 0x178
	internal System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssetTable; // 0x180
	private FontWeightPair[] m_FontWeightTable; // 0x188
	internal float m_RegularStyleWeight; // 0x190
	internal float m_RegularStyleSpacing; // 0x194
	internal float m_BoldStyleWeight; // 0x198
	internal float m_BoldStyleSpacing; // 0x19C
	internal Byte m_ItalicStyleSlant; // 0x1A0
	internal Byte m_TabMultiple; // 0x1A1
	internal bool IsFontAssetLookupTablesDirty; // 0x1A2
	private IntPtr m_NativeFontAsset; // 0x1A8
	private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender; // 0x1B0
	private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered; // 0x1B8
	private System.Collections.Generic.List<System.UInt32> m_GlyphIndexList; // 0x1C0
	private System.Collections.Generic.List<System.UInt32> m_GlyphIndexListNewlyAdded; // 0x1C8
	internal System.Collections.Generic.List<System.UInt32> m_GlyphsToAdd; // 0x1D0
	internal System.Collections.Generic.HashSet<System.UInt32> m_GlyphsToAddLookup; // 0x1D8
	internal System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharactersToAdd; // 0x1E0
	internal System.Collections.Generic.HashSet<System.UInt32> m_CharactersToAddLookup; // 0x1E8
	internal System.Collections.Generic.List<System.UInt32> s_MissingCharacterList; // 0x1F0
	internal System.Collections.Generic.HashSet<System.UInt32> m_MissingUnicodesFromFontFile; // 0x1F8
	internal System.Collections.Generic.Dictionary<System.ValueTuple<System.UInt32,System.UInt32>,System.UInt32> m_VariantGlyphIndexes; // 0x200
	internal bool m_IsClone; // 0x208
	private static readonly System.Collections.Generic.List<System.WeakReference<UnityEngine.TextCore.Text.FontAsset>> s_CallbackInstances; // 0x8
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x10
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x18
	private static ProfilerMarker k_TryAddGlyphMarker; // 0x20
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x28
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x30
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; // 0x38
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x40
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x48
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x50
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x58
	private static string s_DefaultMaterialSuffix; // 0x60
	private static System.Collections.Generic.HashSet<System.Int32> k_SearchedFontAssetLookup; // 0x68
	private static System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x70
	private static System.Collections.Generic.HashSet<System.Int32> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x78
	private static System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_KerningUpdateQueue; // 0x80
	private static System.Collections.Generic.HashSet<System.Int32> k_FontAssets_KerningUpdateQueueLookup; // 0x88
	private static System.Collections.Generic.List<UnityEngine.Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x90
	private static System.Collections.Generic.HashSet<System.Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x98
	internal static UInt32[] k_GlyphIndexArray; // 0xA0
	private static System.Collections.Generic.HashSet<System.Int32> visitedFontAssets; // 0xA8

	// Methods

	// RVA: 0x352C064
	private static void EnsureAdditionalCapacity(System.Collections.Generic.List<T> container, int additionalCapacity) { }

	// RVA: 0x352C064
	private static void EnsureAdditionalCapacity(System.Collections.Generic.Dictionary<TKey,TValue> container, int additionalCapacity) { }

	// RVA: 0x179E1CC
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	// RVA: 0x179E1F0
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	// RVA: 0x179E220
	public Font get_sourceFontFile() { }

	// RVA: 0x179E228
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x179E230
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x179E238
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x179E240
	public FaceInfo get_faceInfo() { }

	// RVA: 0x179E25C
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x179E3C0
	internal int get_familyNameHashCode() { }

	// RVA: 0x179E408
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x179E410
	internal int get_styleNameHashCode() { }

	// RVA: 0x179E458
	internal void set_styleNameHashCode(int value) { }

	// RVA: 0x179E460
	public System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable() { }

	// RVA: 0x179E468
	internal void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value) { }

	// RVA: 0x179E478
	public System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> get_glyphLookupTable() { }

	// RVA: 0x179EBFC
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> get_characterTable() { }

	// RVA: 0x179EC04
	internal void set_characterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> value) { }

	// RVA: 0x179EC14
	public System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.Character> get_characterLookupTable() { }

	// RVA: 0x179EC50
	public Texture2D get_atlasTexture() { }

	// RVA: 0x179ED30
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x179ED38
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x179ED48
	public int get_atlasTextureCount() { }

	// RVA: 0x179ED54
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x179ED5C
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x179ED64
	public bool get_getFontFeatures() { }

	// RVA: 0x179ED6C
	public void set_getFontFeatures(bool value) { }

	// RVA: 0x179ED74
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x179ED7C
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x179ED84
	public int get_atlasWidth() { }

	// RVA: 0x179ED8C
	internal void set_atlasWidth(int value) { }

	// RVA: 0x179ED94
	public int get_atlasHeight() { }

	// RVA: 0x179ED9C
	internal void set_atlasHeight(int value) { }

	// RVA: 0x179EDA4
	public int get_atlasPadding() { }

	// RVA: 0x179EDAC
	internal void set_atlasPadding(int value) { }

	// RVA: 0x179EDB4
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x179EDBC
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x179EDC4
	internal System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x179EDCC
	internal void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value) { }

	// RVA: 0x179EDDC
	internal System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x179EDE4
	internal void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value) { }

	// RVA: 0x179EDF4
	public FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x179EDFC
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	// RVA: 0x179EE0C
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x179EE14
	public void set_fallbackFontAssetTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value) { }

	// RVA: 0x179EE24
	public FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x179EE2C
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	// RVA: 0x179EE3C
	public float get_regularStyleWeight() { }

	// RVA: 0x179EE44
	public void set_regularStyleWeight(float value) { }

	// RVA: 0x179EE4C
	public float get_regularStyleSpacing() { }

	// RVA: 0x179EE54
	public void set_regularStyleSpacing(float value) { }

	// RVA: 0x179EE5C
	public float get_boldStyleWeight() { }

	// RVA: 0x179EE64
	public void set_boldStyleWeight(float value) { }

	// RVA: 0x179EE6C
	public float get_boldStyleSpacing() { }

	// RVA: 0x179EE74
	public void set_boldStyleSpacing(float value) { }

	// RVA: 0x179EE7C
	public Byte get_italicStyleSlant() { }

	// RVA: 0x179EE84
	public void set_italicStyleSlant(Byte value) { }

	// RVA: 0x179EE8C
	public Byte get_tabMultiple() { }

	// RVA: 0x179EE94
	public void set_tabMultiple(Byte value) { }

	// RVA: 0x179EE9C
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize) { }

	// RVA: 0x179F0CC
	internal static FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x179F3B4
	internal static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize, int padding, GlyphRenderMode renderMode) { }

	// RVA: 0x179F4B8
	internal static System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> CreateFontAssetOSFallbackList(string[] fallbacksFamilyNames, int pointSize) { }

	// RVA: 0x179F810
	internal static FontAsset CreateFontAssetWithOSFallbackList(string[] fallbacksFamilyNames, int pointSize) { }

	// RVA: 0x179F6A4
	private static FontAsset CreateFontAssetFromFamilyName(string familyName, int pointSize) { }

	// RVA: 0x179FAEC
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x179F1C0
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x17A01BC
	public static FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x17A02A4
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x17A0364
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x179FBAC
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x17A06D8
	internal static FontAsset GetFontAssetByID(int id) { }

	// RVA: 0x17A0794
	private void RegisterCallbackInstance(FontAsset instance) { }

	// RVA: 0x17A0A70
	private void OnDestroy() { }

	// RVA: 0x179E4B4
	public void ReadFontAssetDefinition() { }

	// RVA: 0x17A0D9C
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x352D118
	private static void InitializeLookup(ICollection source, System.Collections.Generic.Dictionary<System.UInt32,T>& lookup, int defaultCapacity) { }

	// RVA: 0x352D118
	private static void InitializeList(ICollection source, System.Collections.Generic.List<T>& list, int defaultCapacity) { }

	// RVA: 0x17A1030
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x17A1334
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x17A249C
	internal void ClearFallbackCharacterTable() { }

	// RVA: 0x17A1764
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x17A1B84
	internal void InitializeGlyphPairAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x17A1EBC
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x17A21AC
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x17A0E00
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x17A2BD8
	private void AddSynthesizedCharacter(UInt32 unicode, bool isFontFaceLoaded, bool addImmediately) { }

	// RVA: 0x17A3500
	internal void AddCharacterToLookupCache(UInt32 unicode, Character character) { }

	// RVA: 0x17A358C
	internal void AddCharacterToLookupCache(UInt32 unicode, Character character, FontStyles fontStyle, TextFontWeight fontWeight) { }

	// RVA: 0x17A3678
	internal bool GetCharacterInLookupCache(UInt32 unicode, FontStyles fontStyle, TextFontWeight fontWeight, Character character) { }

	// RVA: 0x17A3764
	internal void RemoveCharacterInLookupCache(UInt32 unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	// RVA: 0x17A3848
	internal bool ContainsCharacterInLookupCache(UInt32 unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	// RVA: 0x17A3490
	private UInt32 CreateCompositeKey(UInt32 unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	// RVA: 0x17A2A14
	internal FontEngineError LoadFontFace() { }

	// RVA: 0x17A392C
	internal void SortCharacterTable() { }

	// RVA: 0x17A3AA8
	internal void SortGlyphTable() { }

	// RVA: 0x17A3C24
	internal void SortFontFeatureTable() { }

	// RVA: 0x17A3C64
	internal void SortAllTables() { }

	// RVA: 0x17A3CB0
	public bool HasCharacter(int character) { }

	// RVA: 0x17A3D30
	public bool HasCharacter(Char character, bool searchFallbacks, bool tryAddCharacter) { }

	// RVA: 0x17A3D34
	public bool HasCharacter(UInt32 character, bool searchFallbacks, bool tryAddCharacter) { }

	// RVA: 0x17A46A8
	private bool HasCharacterWithStyle_Internal(UInt32 character, FontStyles fontStyle, TextFontWeight fontWeight, bool searchFallbacks, bool tryAddCharacter) { }

	// RVA: 0x17A4460
	private bool HasCharacter_Internal(UInt32 character, FontStyles fontStyle, TextFontWeight fontWeight, bool searchFallbacks, bool tryAddCharacter) { }

	// RVA: 0x17A46AC
	public bool HasCharacters(string text, System.Collections.Generic.List<System.Char>& missingCharacters) { }

	// RVA: 0x17A4984
	public bool HasCharacters(string text, UInt32[] missingCharacters, bool searchFallbacks, bool tryAddCharacter) { }

	// RVA: 0x17A4F44
	public bool HasCharacters(string text) { }

	// RVA: 0x17A5040
	public static string GetCharacters(FontAsset fontAsset) { }

	// RVA: 0x17A514C
	public static int[] GetCharactersArray(FontAsset fontAsset) { }

	// RVA: 0x17A527C
	internal UInt32 GetGlyphIndex(UInt32 unicode) { }

	// RVA: 0x17A529C
	internal UInt32 GetGlyphIndex(UInt32 unicode, bool success) { }

	// RVA: 0x17A541C
	internal UInt32 GetGlyphVariantIndex(UInt32 unicode, UInt32 variantSelectorUnicode) { }

	// RVA: 0x17A54AC
	internal void UpdateFontAssetData() { }

	// RVA: 0x17A5DFC
	public void ClearFontAssetData(bool setAtlasSizeToZero) { }

	// RVA: 0x17A60D4
	internal void ClearCharacterAndGlyphTablesInternal() { }

	// RVA: 0x17A56A0
	private void ClearCharacterAndGlyphTables() { }

	// RVA: 0x17A59AC
	private void ClearFontFeaturesTables() { }

	// RVA: 0x17A5BB0
	internal void ClearAtlasTextures(bool setAtlasSizeToZero) { }

	// RVA: 0x17A0C2C
	private void DestroyAtlasTextures() { }

	// RVA: 0x17A6104
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	// RVA: 0x17A61F8
	internal static void RegisterFontAssetForKerningUpdate(FontAsset fontAsset) { }

	// RVA: 0x17A62EC
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x17A6714
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x17A6808
	internal static void UpdateAtlasTexturesInQueue() { }

	// RVA: 0x17A69D0
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x17A5DD4
	public bool TryAddCharacters(UInt32[] unicodes, bool includeFontFeatures) { }

	// RVA: 0x17A6A40
	public bool TryAddCharacters(UInt32[] unicodes, UInt32[] missingUnicodes, bool includeFontFeatures) { }

	// RVA: 0x17A8334
	public bool TryAddCharacters(string characters, bool includeFontFeatures) { }

	// RVA: 0x17A835C
	public bool TryAddCharacters(string characters, string missingCharacters, bool includeFontFeatures) { }

	// RVA: 0x17A850C
	internal bool TryAddGlyphVariantIndexInternal(UInt32 unicode, UInt32 nextCharacter, UInt32 variantGlyphIndex) { }

	// RVA: 0x17A85D0
	internal bool TryGetGlyphVariantIndexInternal(UInt32 unicode, UInt32 nextCharacter, UInt32 variantGlyphIndex) { }

	// RVA: 0x17A8690
	internal bool TryAddGlyphInternal(UInt32 glyphIndex, Glyph glyph) { }

	// RVA: 0x17A8C60
	internal bool TryAddCharacterInternal(UInt32 unicode, Character character) { }

	// RVA: 0x17A40A0
	internal bool TryAddCharacterInternal(UInt32 unicode, FontStyles fontStyle, TextFontWeight fontWeight, Character character, bool populateLigatures) { }

	// RVA: 0x17A8880
	private bool TryAddGlyphToAtlas(UInt32 glyphIndex, Glyph glyph, bool populateLigatures) { }

	// RVA: 0x17A8DE4
	private bool TryAddGlyphToTexture(UInt32 glyphIndex, Glyph glyph, bool populateLigatures) { }

	// RVA: 0x17A7EB0
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x17A90C0
	private void SetupNewAtlasTexture() { }

	// RVA: 0x17A8C74
	private Character CreateCharacterAndAddToCache(UInt32 unicode, Glyph glyph, FontStyles fontStyle, TextFontWeight fontWeight) { }

	// RVA: 0x17A827C
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x17A666C
	private void UpdateGlyphAdjustmentRecordsForNewGlyphs() { }

	// RVA: 0x17A65BC
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x17A1658
	internal void ImportFontFeatures() { }

	// RVA: 0x17A938C
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(UInt32 glyphIndex) { }

	// RVA: 0x17A9430
	internal void UpdateLigatureSubstitutionRecords() { }

	// RVA: 0x17AA0C0
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	// RVA: 0x17A9518
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x17A97A4
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	// RVA: 0x17A9600
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	// RVA: 0x17A9A80
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	// RVA: 0x17A9D98
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	// RVA: 0x17AA5C0
	internal IntPtr get_nativeFontAsset() { }

	// RVA: 0x17AA5E4
	internal void EnsureNativeFontAssetIsCreated() { }

	// RVA: 0x17AB330
	internal void UpdateFallbacks() { }

	// RVA: 0x17AB4DC
	internal void UpdateWeightFallbacks() { }

	// RVA: 0x179E2A8
	internal void UpdateFaceInfo() { }

	// RVA: 0x17AA730
	internal IntPtr[] GetFallbacks() { }

	// RVA: 0x17AB778
	private bool HasRecursion(FontAsset fontAsset) { }

	// RVA: 0x17AB828
	private bool HasRecursionInternal(FontAsset fontAsset) { }

	// RVA: 0x17AABF0
	private System.ValueTuple<System.IntPtr[],System.IntPtr[]> GetWeightFallbacks() { }

	// RVA: 0x17ABC48
	internal static void CreateHbFaceIfNeeded() { }

	// RVA: 0x17AB3C4
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	// RVA: 0x17AB560
	private static void UpdateWeightFallbacks(IntPtr ptr, IntPtr[] regularFallbacks, IntPtr[] italicFallbacks) { }

	// RVA: 0x17AAFF0
	private static IntPtr Create(FaceInfo faceInfo, Font sourceFontFile, Font sourceFont_EditorRef, string sourceFontFilePath, int fontInstanceID, IntPtr[] fallbacks, IntPtr[] weightFallbacks, IntPtr[] italicFallbacks) { }

	// RVA: 0x17AB6C0
	private static void UpdateFaceInfo(IntPtr ptr, FaceInfo faceInfo) { }

	// RVA: 0x17A0D4C
	private static void Destroy(IntPtr ptr) { }

	// RVA: 0x17ABE48
	public void .ctor() { }

	// RVA: 0x17AC1C4
	private static void .cctor() { }

	// RVA: 0x17ABC88
	private static void UpdateFallbacks_Injected(IntPtr ptr, ManagedSpanWrapper fallbacks) { }

	// RVA: 0x17ABCF0
	private static void UpdateWeightFallbacks_Injected(IntPtr ptr, ManagedSpanWrapper regularFallbacks, ManagedSpanWrapper italicFallbacks) { }

	// RVA: 0x17ABD48
	private static IntPtr Create_Injected(FaceInfo faceInfo, IntPtr sourceFontFile, IntPtr sourceFont_EditorRef, ManagedSpanWrapper sourceFontFilePath, int fontInstanceID, ManagedSpanWrapper fallbacks, ManagedSpanWrapper weightFallbacks, ManagedSpanWrapper italicFallbacks) { }

	// RVA: 0x17ABDE0
	private static void UpdateFaceInfo_Injected(IntPtr ptr, FaceInfo faceInfo) { }

}

// Namespace: UnityEngine.TextCore.Text
internal class FontAssetFactory
{
	// Fields
	private static readonly System.Collections.Generic.HashSet<UnityEngine.TextCore.Text.FontAsset> visitedFontAssets; // 0x0

	// Methods

	// RVA: 0x17AC758
	internal static FontAsset ConvertFontToFontAsset(Font font) { }

	// RVA: 0x17AC91C
	internal static void SetupFontAssetSettings(FontAsset fontAsset) { }

	// RVA: 0x179FA04
	public static void SetHideFlags(FontAsset fontAsset) { }

	// RVA: 0x17AC9F4
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal static class FontAssetUtilities
{
	// Fields
	private static System.Collections.Generic.HashSet<System.Int32> k_SearchedAssets; // 0x0

	// Methods

	// RVA: 0x17ACA90
	internal static Character GetCharacterFromFontAsset(UInt32 unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x17ACBB4
	private static Character GetCharacterFromFontAsset_Internal(UInt32 unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x17AD204
	internal static Character GetCharacterFromFontAssetsInternal(UInt32 unicode, FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> OSFallbackList, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x17AD370
	private static Character GetCharacterFromFontAssetsInternal(UInt32 unicode, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x17AD55C
	internal static TextElement GetTextElementFromTextAssets(UInt32 unicode, FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> textAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x17ADA3C
	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(UInt32 unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x17AD854
	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(UInt32 unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x17A4850
	public static UInt32 GetCodePoint(string text, int index) { }

	// RVA: 0x17A7D70
	public static UInt32 GetCodePoint(UInt32[] codesPoints, int index) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.TextCore.Text.SpriteAsset.<>c <>9; // 0x0
	public static System.Func<UnityEngine.TextCore.Text.SpriteGlyph,System.UInt32> <>9__44_0; // 0x8
	public static System.Func<UnityEngine.TextCore.Text.SpriteCharacter,System.UInt32> <>9__45_0; // 0x10

	// Methods

	// RVA: 0x17C64EC
	private static void .cctor() { }

	// RVA: 0x17C6558
	public void .ctor() { }

	// RVA: 0x17C6560
	internal UInt32 <SortGlyphTable>b__44_0(SpriteGlyph item) { }

	// RVA: 0x17C657C
	internal UInt32 <SortCharacterTable>b__45_0(SpriteCharacter c) { }

}

// Namespace: UnityEngine.TextCore.Text
public class SpriteAsset
{
	// Fields
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_NameLookup; // 0x38
	internal System.Collections.Generic.Dictionary<System.UInt32,System.Int32> m_GlyphIndexLookup; // 0x40
	internal FaceInfo m_FaceInfo; // 0x48
	internal Texture m_SpriteAtlasTexture; // 0xA8
	private float <width>k__BackingField; // 0xB0
	private float <height>k__BackingField; // 0xB4
	private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterTable; // 0xB8
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterLookup; // 0xC0
	private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphTable; // 0xC8
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphLookup; // 0xD0
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets; // 0xD8
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0

	// Methods

	// RVA: 0x17C4AD4
	public FaceInfo get_faceInfo() { }

	// RVA: 0x17C4AFC
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x17C4B2C
	public Texture get_spriteSheet() { }

	// RVA: 0x17C4B34
	internal void set_spriteSheet(Texture value) { }

	// RVA: 0x17C4B9C
	internal float get_width() { }

	// RVA: 0x17C4BA4
	private void set_width(float value) { }

	// RVA: 0x17C4BAC
	internal float get_height() { }

	// RVA: 0x17C4BB4
	private void set_height(float value) { }

	// RVA: 0x17C4BBC
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x17C51B8
	internal void set_spriteCharacterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> value) { }

	// RVA: 0x17C51C0
	public System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x17C51FC
	internal void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> value) { }

	// RVA: 0x17C5204
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x17C520C
	internal void set_spriteGlyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> value) { }

	// RVA: 0x17C5214
	private void Awake() { }

	// RVA: 0x17C4BFC
	public void UpdateLookupTables() { }

	// RVA: 0x17C5240
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x17C52D8
	public int GetSpriteIndexFromUnicode(UInt32 unicode) { }

	// RVA: 0x17C538C
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x17C5444
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, UInt32 unicode, bool includeFallbacks, int spriteIndex) { }

	// RVA: 0x17C5640
	private static SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, UInt32 unicode, bool includeFallbacks, System.Collections.Generic.HashSet<System.Int32> searchedSpriteAssets, int spriteIndex) { }

	// RVA: 0x17C5868
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, UInt32 unicode, bool includeFallbacks, System.Collections.Generic.HashSet<System.Int32> searchedSpriteAssets, int spriteIndex) { }

	// RVA: 0x17C599C
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, int spriteIndex, TextSettings textSettings) { }

	// RVA: 0x17C5DA8
	private static SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, System.Collections.Generic.HashSet<System.Int32> searchedSpriteAssets, int spriteIndex) { }

	// RVA: 0x17C5FD8
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, System.Collections.Generic.HashSet<System.Int32> searchedSpriteAssets, int spriteIndex) { }

	// RVA: 0x17C60F8
	public void SortGlyphTable() { }

	// RVA: 0x17C6268
	internal void SortCharacterTable() { }

	// RVA: 0x17C63DC
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x17C6400
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteCharacter
{
	// Fields
	private string m_Name; // 0x30

	// Methods

	// RVA: 0x17C5230
	public string get_name() { }

	// RVA: 0x17C6598
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteGlyph
{
	// Fields
	public Sprite sprite; // 0x48

	// Methods

	// RVA: 0x17C65CC
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public abstract class TextAsset
{
	// Fields
	internal string m_Version; // 0x18
	internal int m_InstanceID; // 0x20
	internal int m_HashCode; // 0x24
	internal Material m_Material; // 0x28
	internal int m_MaterialHashCode; // 0x30

	// Methods

	// RVA: 0x17C65D4
	public string get_version() { }

	// RVA: 0x17C65DC
	internal void set_version(string value) { }

	// RVA: 0x17C65E4
	public int get_instanceID() { }

	// RVA: 0x17C6624
	public int get_hashCode() { }

	// RVA: 0x17C666C
	public void set_hashCode(int value) { }

	// RVA: 0x17C6674
	public Material get_material() { }

	// RVA: 0x17C667C
	public void set_material(Material value) { }

	// RVA: 0x17C6684
	public int get_materialHashCode() { }

	// RVA: 0x17C6748
	public void set_materialHashCode(int value) { }

	// RVA: 0x17C64E4
	protected void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
public enum ColorGradientMode
{
	// Fields
	public int value__; // 0x10
	public const ColorGradientMode Single = 0;
	public const ColorGradientMode HorizontalGradient = 1;
	public const ColorGradientMode VerticalGradient = 2;
	public const ColorGradientMode FourCornersGradient = 3;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class TextColorGradient
{
	// Fields
	public ColorGradientMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorGradientMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x17C6750
	public void .ctor() { }

	// RVA: 0x17C67F8
	public void .ctor(Color color) { }

	// RVA: 0x17C6868
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x17C6910
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
internal struct FontReferenceMap
{
	// Fields
	public Font font; // 0x10
	public FontAsset fontAsset; // 0x18

	// Methods

	// RVA: 0x17C75F8
	public void .ctor(Font font, FontAsset fontAsset) { }

}

// Namespace: 
private sealed class <>c__DisplayClass96_0
{
	// Fields
	public System.Collections.Generic.List<System.IntPtr> globalFontAssetFallbacks; // 0x10

	// Methods

	// RVA: 0x17C7B90
	public void .ctor() { }

	// RVA: 0x17C7CD8
	internal void <GetGlobalFallbacks>b__0(FontAsset fallback) { }

	// RVA: 0x17C7E90
	internal void <GetGlobalFallbacks>b__1(FontAsset fallback) { }

	// RVA: 0x17C8048
	internal void <GetGlobalFallbacks>b__2(TextAsset fallback) { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class TextSettings
{
	// Fields
	protected string m_Version; // 0x18
	protected FontAsset m_DefaultFontAsset; // 0x20
	protected string m_DefaultFontAssetPath; // 0x28
	protected System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssets; // 0x30
	private static System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> s_FallbackOSFontAssetInternal; // 0x0
	protected bool m_MatchMaterialPreset; // 0x38
	protected int m_MissingCharacterUnicode; // 0x3C
	protected bool m_ClearDynamicDataOnBuild; // 0x40
	private bool m_EnableEmojiSupport; // 0x41
	private System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> m_EmojiFallbackTextAssets; // 0x48
	protected SpriteAsset m_DefaultSpriteAsset; // 0x50
	protected string m_DefaultSpriteAssetPath; // 0x58
	protected System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> m_FallbackSpriteAssets; // 0x60
	private static SpriteAsset <s_GlobalSpriteAsset>k__BackingField; // 0x8
	protected UInt32 m_MissingSpriteCharacterUnicode; // 0x68
	protected TextStyleSheet m_DefaultStyleSheet; // 0x70
	protected string m_StyleSheetsResourcePath; // 0x78
	protected string m_DefaultColorGradientPresetsPath; // 0x80
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x88
	protected bool m_DisplayWarnings; // 0x90
	internal System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset> m_FontLookup; // 0x98
	internal System.Collections.Generic.List<UnityEngine.TextCore.Text.TextSettings.FontReferenceMap> m_FontReferences; // 0xA0
	private IntPtr m_NativeTextSettings; // 0xA8
	private bool m_IsNativeTextSettingsDirty; // 0xB0

	// Methods

	// RVA: 0x17C6960
	public string get_version() { }

	// RVA: 0x17C6968
	internal void set_version(string value) { }

	// RVA: 0x17C6970
	public FontAsset get_defaultFontAsset() { }

	// RVA: 0x17C6978
	public void set_defaultFontAsset(FontAsset value) { }

	// RVA: 0x17C6980
	public string get_defaultFontAssetPath() { }

	// RVA: 0x17C6988
	public void set_defaultFontAssetPath(string value) { }

	// RVA: 0x17C6990
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x17C6998
	public void set_fallbackFontAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value) { }

	// RVA: 0x17C69C8
	internal System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackOSFontAssets() { }

	// RVA: 0x17C6B08
	internal virtual System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetStaticFallbackOSFontAsset() { }

	// RVA: 0x17C6B54
	internal virtual void SetStaticFallbackOSFontAsset(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets) { }

	// RVA: 0x17C6BB8
	internal virtual System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetFallbackFontAssets(int textPixelSize) { }

	// RVA: 0x17C6BC0
	public bool get_matchMaterialPreset() { }

	// RVA: 0x17C6BC8
	public void set_matchMaterialPreset(bool value) { }

	// RVA: 0x17C6BD0
	public int get_missingCharacterUnicode() { }

	// RVA: 0x17C6BD8
	public void set_missingCharacterUnicode(int value) { }

	// RVA: 0x17C6BE0
	public bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x17C6BE8
	public void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x17C6BF0
	public bool get_enableEmojiSupport() { }

	// RVA: 0x17C6BF8
	public void set_enableEmojiSupport(bool value) { }

	// RVA: 0x17C6C00
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> get_emojiFallbackTextAssets() { }

	// RVA: 0x17C6C08
	public void set_emojiFallbackTextAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.TextAsset> value) { }

	// RVA: 0x17C6C38
	public SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x17C6C40
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	// RVA: 0x17C6C48
	public string get_defaultSpriteAssetPath() { }

	// RVA: 0x17C6C50
	public void set_defaultSpriteAssetPath(string value) { }

	// RVA: 0x17C6C58
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> get_fallbackSpriteAssets() { }

	// RVA: 0x17C6C60
	public void set_fallbackSpriteAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> value) { }

	// RVA: 0x17C6C68
	private static void set_s_GlobalSpriteAsset(SpriteAsset value) { }

	// RVA: 0x17C6CC4
	internal static SpriteAsset get_s_GlobalSpriteAsset() { }

	// RVA: 0x17C6D10
	public UInt32 get_missingSpriteCharacterUnicode() { }

	// RVA: 0x17C6D18
	public void set_missingSpriteCharacterUnicode(UInt32 value) { }

	// RVA: 0x17C6D20
	public TextStyleSheet get_defaultStyleSheet() { }

	// RVA: 0x17C6D28
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	// RVA: 0x17C6D30
	public string get_styleSheetsResourcePath() { }

	// RVA: 0x17C6D38
	public void set_styleSheetsResourcePath(string value) { }

	// RVA: 0x17C6D40
	public string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x17C6D48
	public void set_defaultColorGradientPresetsPath(string value) { }

	// RVA: 0x17C6D50
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	// RVA: 0x17C6DE4
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	// RVA: 0x17C6DEC
	public bool get_displayWarnings() { }

	// RVA: 0x17C6DF4
	public void set_displayWarnings(bool value) { }

	// RVA: 0x17C6DFC
	private void OnEnable() { }

	// RVA: 0x17C6FD8
	private void OnDestroy() { }

	// RVA: 0x17C7088
	protected void InitializeFontReferenceLookup() { }

	// RVA: 0x17C730C
	internal FontAsset GetCachedFontAsset(Font font) { }

	// RVA: 0x17C6A70
	private System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> GetOSFontAssetList() { }

	// RVA: 0x17C762C
	private static IntPtr CreateNativeObject(IntPtr[] fallbacks) { }

	// RVA: 0x17C7038
	private static void DestroyNativeObject(IntPtr m_NativeTextSettings) { }

	// RVA: 0x17C7750
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	// RVA: 0x17C789C
	internal IntPtr get_nativeTextSettings() { }

	// RVA: 0x17C7978
	private IntPtr[] GetGlobalFallbacks() { }

	// RVA: 0x17C7910
	internal void UpdateNativeTextSettings() { }

	// RVA: 0x17C7B98
	public void .ctor() { }

	// RVA: 0x17C7700
	private static IntPtr CreateNativeObject_Injected(ManagedSpanWrapper fallbacks) { }

	// RVA: 0x17C7834
	private static void UpdateFallbacks_Injected(IntPtr ptr, ManagedSpanWrapper fallbacks) { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class TextStyle
{
	// Fields
	internal static TextStyle k_NormalStyle; // 0x0
	private string m_Name; // 0x10
	private int m_HashCode; // 0x18
	private string m_OpeningDefinition; // 0x20
	private string m_ClosingDefinition; // 0x28
	private UInt32[] m_OpeningTagArray; // 0x30
	private UInt32[] m_ClosingTagArray; // 0x38
	internal UInt32[] m_OpeningTagUnicodeArray; // 0x40
	internal UInt32[] m_ClosingTagUnicodeArray; // 0x48

	// Methods

	// RVA: 0x17C8220
	public int get_hashCode() { }

	// RVA: 0x17C8228
	public UInt32[] get_styleOpeningTagArray() { }

	// RVA: 0x17C8230
	public UInt32[] get_styleClosingTagArray() { }

	// RVA: 0x17C8238
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x17C82B4
	public void RefreshStyle() { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class TextStyleSheet
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> m_StyleList; // 0x18
	private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextStyle> m_StyleLookupDictionary; // 0x20
	private object styleLookupLock; // 0x28

	// Methods

	// RVA: 0x17C8498
	internal System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> get_styles() { }

	// RVA: 0x17C84A0
	private void Reset() { }

	// RVA: 0x17C8804
	public TextStyle GetStyle(int hashCode) { }

	// RVA: 0x17C8944
	public TextStyle GetStyle(string name) { }

	// RVA: 0x17C8A10
	public void RefreshStyles() { }

	// RVA: 0x17C84A4
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x17C8A14
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct TextCoreVertex
{
	// Fields
	public Vector3 position; // 0x10
	public Color32 color; // 0x1C
	public Vector2 uv0; // 0x20
	public Vector2 uv2; // 0x28
}

// Namespace: UnityEngine.TextCore.Text
public enum TextElementType
{
	// Fields
	public Byte value__; // 0x10
	public const TextElementType Character = 1;
	public const TextElementType Sprite = 2;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public abstract class TextElement
{
	// Fields
	protected TextElementType m_ElementType; // 0x10
	internal UInt32 m_Unicode; // 0x14
	internal TextAsset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	internal UInt32 m_GlyphIndex; // 0x28
	internal float m_Scale; // 0x2C

	// Methods

	// RVA: 0x17C8AE4
	public TextElementType get_elementType() { }

	// RVA: 0x17C5238
	public UInt32 get_unicode() { }

	// RVA: 0x17C8AEC
	public void set_unicode(UInt32 value) { }

	// RVA: 0x17C8AF4
	public TextAsset get_textAsset() { }

	// RVA: 0x17C5228
	public void set_textAsset(TextAsset value) { }

	// RVA: 0x17C8AFC
	public Glyph get_glyph() { }

	// RVA: 0x17C5220
	public void set_glyph(Glyph value) { }

	// RVA: 0x17C5218
	public UInt32 get_glyphIndex() { }

	// RVA: 0x17C8B04
	public void set_glyphIndex(UInt32 value) { }

	// RVA: 0x17C8B0C
	public float get_scale() { }

	// RVA: 0x17C8B14
	public void set_scale(float value) { }

	// RVA: 0x17C65C4
	protected void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct TextVertex
{
	// Fields
	public Vector3 position; // 0x10
	public Vector4 uv; // 0x1C
	public Vector2 uv2; // 0x2C
	public Color32 color; // 0x34
}

// Namespace: UnityEngine.TextCore.Text
internal struct TextElementInfo
{
	// Fields
	public UInt32 character; // 0x10
	public int index; // 0x14
	public TextElementType elementType; // 0x18
	public int stringLength; // 0x1C
	public TextElement textElement; // 0x20
	public Glyph alternativeGlyph; // 0x28
	public FontAsset fontAsset; // 0x30
	public SpriteAsset spriteAsset; // 0x38
	public Material material; // 0x40
	public int materialReferenceIndex; // 0x48
	public bool isUsingAlternateTypeface; // 0x4C
	public float pointSize; // 0x50
	public int lineNumber; // 0x54
	public int vertexIndex; // 0x58
	public TextVertex vertexTopLeft; // 0x5C
	public TextVertex vertexBottomLeft; // 0x84
	public TextVertex vertexTopRight; // 0xAC
	public TextVertex vertexBottomRight; // 0xD4
	public Vector3 topLeft; // 0xFC
	public Vector3 bottomLeft; // 0x108
	public Vector3 topRight; // 0x114
	public Vector3 bottomRight; // 0x120
	public float origin; // 0x12C
	public float ascender; // 0x130
	public float baseLine; // 0x134
	public float descender; // 0x138
	internal float adjustedAscender; // 0x13C
	internal float adjustedDescender; // 0x140
	internal float adjustedHorizontalAdvance; // 0x144
	public float xAdvance; // 0x148
	public float aspectRatio; // 0x14C
	public float scale; // 0x150
	public Color32 color; // 0x154
	public Color32 underlineColor; // 0x158
	public int underlineVertexIndex; // 0x15C
	public Color32 strikethroughColor; // 0x160
	public int strikethroughVertexIndex; // 0x164
	public Color32 highlightColor; // 0x168
	public HighlightState highlightState; // 0x16C
	public FontStyles style; // 0x180
	public bool isVisible; // 0x184

	// Methods

	// RVA: 0x17C8B1C
	public override string ToString() { }

}

// Namespace: UnityEngine.TextCore.Text
public static class TextEventManager
{
	// Fields
	public static readonly UnityEngine.TextCore.Text.FastAction<System.Boolean,UnityEngine.Material> MATERIAL_PROPERTY_EVENT; // 0x0
	public static readonly UnityEngine.TextCore.Text.FastAction<System.Boolean,UnityEngine.Object> FONT_PROPERTY_EVENT; // 0x8
	public static readonly UnityEngine.TextCore.Text.FastAction<System.Boolean,UnityEngine.Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x10
	public static readonly UnityEngine.TextCore.Text.FastAction<System.Boolean,UnityEngine.Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x18
	public static readonly UnityEngine.TextCore.Text.FastAction<UnityEngine.GameObject,UnityEngine.Material,UnityEngine.Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x20
	public static readonly UnityEngine.TextCore.Text.FastAction<System.Boolean> TEXT_STYLE_PROPERTY_EVENT; // 0x28
	public static readonly UnityEngine.TextCore.Text.FastAction<UnityEngine.Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x30
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x38
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x40
	public static readonly UnityEngine.TextCore.Text.FastAction<System.Boolean,UnityEngine.Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x48
	public static readonly FastAction OnPreRenderObject_Event; // 0x50
	public static readonly UnityEngine.TextCore.Text.FastAction<UnityEngine.Object> TEXT_CHANGED_EVENT; // 0x58

	// Methods

	// RVA: 0x17CA2D4
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, object font) { }

	// RVA: 0x17CA390
	private static void .cctor() { }

}

// Namespace: 
public sealed class MissingCharacterEventCallback
{
	// Methods

	// RVA: 0x17CA6B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17CA754
	public virtual void Invoke(UInt32 unicode, int stringIndex, TextInfo text, FontAsset fontAsset) { }

}

// Namespace: 
protected struct SpecialCharacter
{
	// Fields
	public Character character; // 0x10
	public FontAsset fontAsset; // 0x18
	public Material material; // 0x20
	public int materialIndex; // 0x28

	// Methods

	// RVA: 0x17CA768
	public void .ctor(Character character, int materialIndex) { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextGenerator
{
	// Fields
	private const int k_Tab = 9;
	private const int k_LineFeed = 10;
	private const int k_VerticalTab = 11;
	private const int k_CarriageReturn = 13;
	private const int k_Space = 32;
	private const int k_DoubleQuotes = 34;
	private const int k_NumberSign = 35;
	private const int k_PercentSign = 37;
	private const int k_SingleQuote = 39;
	private const int k_Plus = 43;
	private const int k_Period = 46;
	private const int k_LesserThan = 60;
	private const int k_Equal = 61;
	private const int k_GreaterThan = 62;
	private const int k_Underline = 95;
	private const int k_NoBreakSpace = 160;
	private const int k_SoftHyphen = 173;
	private const int k_HyphenMinus = 45;
	private const int k_FigureSpace = 8199;
	private const int k_Hyphen = 8208;
	private const int k_NonBreakingHyphen = 8209;
	private const int k_ZeroWidthSpace = 8203;
	private const int k_NarrowNoBreakSpace = 8239;
	private const int k_WordJoiner = 8288;
	private const int k_HorizontalEllipsis = 8230;
	private const int k_LineSeparator = 8232;
	private const int k_ParagraphSeparator = 8233;
	private const int k_RightSingleQuote = 8217;
	private const int k_Square = 9633;
	private const int k_HangulJamoStart = 4352;
	private const int k_HangulJamoEnd = 4607;
	private const int k_CjkStart = 11904;
	private const int k_CjkEnd = 40959;
	private const int k_HangulJameExtendedStart = 43360;
	private const int k_HangulJameExtendedEnd = 43391;
	private const int k_HangulSyllablesStart = 44032;
	private const int k_HangulSyllablesEnd = 55295;
	private const int k_CjkIdeographsStart = 63744;
	private const int k_CjkIdeographsEnd = 64255;
	private const int k_CjkFormsStart = 65072;
	private const int k_CjkFormsEnd = 65103;
	private const int k_CjkHalfwidthStart = 65280;
	private const int k_CjkHalfwidthEnd = 65519;
	private const int k_EndOfText = 3;
	private const float k_FloatUnset = -32767;
	private const int k_MaxCharacters = 8;
	private static TextGenerator s_TextGenerator; // 0x0
	private static bool <IsExecutingJob>k__BackingField; // 0x8
	private TextBackingContainer m_TextBackingArray; // 0x10
	internal TextProcessingElement[] m_TextProcessingArray; // 0x20
	internal int m_InternalTextProcessingArraySize; // 0x28
	protected bool m_VertexBufferAutoSizeReduction; // 0x2C
	private Char[] m_HtmlTag; // 0x30
	internal HighlightState m_HighlightState; // 0x38
	protected bool m_IsIgnoringAlignment; // 0x4C
	protected bool m_IsTextTruncated; // 0x4D
	private static MissingCharacterEventCallback OnMissingCharacter; // 0x10
	private Vector3[] m_RectTransformCorners; // 0x50
	private float m_MarginWidth; // 0x58
	private float m_MarginHeight; // 0x5C
	private float m_PreferredWidth; // 0x60
	private float m_PreferredHeight; // 0x64
	private FontAsset m_CurrentFontAsset; // 0x68
	private Material m_CurrentMaterial; // 0x70
	private int m_CurrentMaterialIndex; // 0x78
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> m_MaterialReferenceStack; // 0x80
	private float m_Padding; // 0xD8
	private SpriteAsset m_CurrentSpriteAsset; // 0xE0
	private int m_TotalCharacterCount; // 0xE8
	private float m_FontSize; // 0xEC
	private float m_FontScaleMultiplier; // 0xF0
	private float m_CurrentFontSize; // 0xF4
	private UnityEngine.TextCore.Text.TextProcessingStack<System.Single> m_SizeStack; // 0xF8
	protected UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[] m_TextStyleStacks; // 0x118
	protected int m_TextStyleStackDepth; // 0x120
	private FontStyles m_FontStyleInternal; // 0x124
	private FontStyleStack m_FontStyleStack; // 0x128
	private TextFontWeight m_FontWeightInternal; // 0x134
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> m_FontWeightStack; // 0x138
	private TextAlignment m_LineJustification; // 0x158
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> m_LineJustificationStack; // 0x160
	private float m_BaselineOffset; // 0x180
	private UnityEngine.TextCore.Text.TextProcessingStack<System.Single> m_BaselineOffsetStack; // 0x188
	private Color32 m_FontColor32; // 0x1A8
	private Color32 m_HtmlColor; // 0x1AC
	private Color32 m_UnderlineColor; // 0x1B0
	private Color32 m_StrikethroughColor; // 0x1B4
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_ColorStack; // 0x1B8
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_UnderlineColorStack; // 0x1D8
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_StrikethroughColorStack; // 0x1F8
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> m_HighlightColorStack; // 0x218
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.HighlightState> m_HighlightStateStack; // 0x238
	private UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> m_ItalicAngleStack; // 0x268
	private TextColorGradient m_ColorGradientPreset; // 0x288
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> m_ColorGradientStack; // 0x290
	private bool m_ColorGradientPresetIsTinted; // 0x2B8
	private UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> m_ActionStack; // 0x2C0
	private float m_LineOffset; // 0x2E0
	private float m_LineHeight; // 0x2E4
	private bool m_IsDrivenLineSpacing; // 0x2E8
	private float m_CSpacing; // 0x2EC
	private float m_MonoSpacing; // 0x2F0
	private bool m_DuoSpace; // 0x2F4
	private float m_XAdvance; // 0x2F8
	private float m_TagLineIndent; // 0x2FC
	private float m_TagIndent; // 0x300
	private UnityEngine.TextCore.Text.TextProcessingStack<System.Single> m_IndentStack; // 0x308
	private bool m_TagNoParsing; // 0x328
	private int m_CharacterCount; // 0x32C
	private int m_FirstCharacterOfLine; // 0x330
	private int m_LastCharacterOfLine; // 0x334
	private int m_FirstVisibleCharacterOfLine; // 0x338
	private int m_LastVisibleCharacterOfLine; // 0x33C
	private float m_MaxLineAscender; // 0x340
	private float m_MaxLineDescender; // 0x344
	private int m_LineNumber; // 0x348
	private int m_LineVisibleCharacterCount; // 0x34C
	private int m_LineVisibleSpaceCount; // 0x350
	private int m_FirstOverflowCharacterIndex; // 0x354
	private float m_MarginLeft; // 0x358
	private float m_MarginRight; // 0x35C
	private float m_Width; // 0x360
	private Extents m_MeshExtents; // 0x364
	private float m_MaxCapHeight; // 0x374
	private float m_MaxAscender; // 0x378
	private float m_MaxDescender; // 0x37C
	private bool m_IsNonBreakingSpace; // 0x380
	private WordWrapState m_SavedWordWrapState; // 0x388
	private WordWrapState m_SavedLineState; // 0x720
	private WordWrapState m_SavedEllipsisState; // 0xAB8
	private WordWrapState m_SavedLastValidState; // 0xE50
	private WordWrapState m_SavedSoftLineBreakState; // 0x11E8
	private TextElementType m_TextElementType; // 0x1580
	private bool m_isTextLayoutPhase; // 0x1581
	private int m_SpriteIndex; // 0x1584
	private Color32 m_SpriteColor; // 0x1588
	private TextElement m_CachedTextElement; // 0x1590
	private Color32 m_HighlightColor; // 0x1598
	private float m_CharWidthAdjDelta; // 0x159C
	private float m_MaxFontSize; // 0x15A0
	private float m_MinFontSize; // 0x15A4
	private int m_AutoSizeIterationCount; // 0x15A8
	private int m_AutoSizeMaxIterationCount; // 0x15AC
	private float m_StartOfLineAscender; // 0x15B0
	private float m_LineSpacingDelta; // 0x15B4
	internal MaterialReference[] m_MaterialReferences; // 0x15B8
	private int m_SpriteCount; // 0x15C0
	private UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> m_StyleStack; // 0x15C8
	private UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.WordWrapState> m_EllipsisInsertionCandidateStack; // 0x15E8
	private int m_SpriteAnimationId; // 0x19A0
	private int m_ItalicAngle; // 0x19A4
	private Vector3 m_FXScale; // 0x19A8
	private Quaternion m_FXRotation; // 0x19B4
	private int m_LastBaseGlyphIndex; // 0x19C4
	private float m_PageAscender; // 0x19C8
	private RichTextTagAttribute[] m_XmlAttribute; // 0x19D0
	private float[] m_AttributeParameterValues; // 0x19D8
	private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_MaterialReferenceIndexLookup; // 0x19E0
	private bool m_IsCalculatingPreferredValues; // 0x19E8
	private bool m_TintSprite; // 0x19E9
	protected SpecialCharacter m_Ellipsis; // 0x19F0
	protected SpecialCharacter m_Underline; // 0x1A10
	private TextElementInfo[] m_InternalTextElementInfo; // 0x1A30

	// Methods

	// RVA: 0x17ADE88
	internal static bool get_IsExecutingJob() { }

	// RVA: 0x17ADED4
	internal static void set_IsExecutingJob(bool value) { }

	// RVA: 0x17ADF2C
	public void GenerateText(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x17AE688
	public bool get_isTextTruncated() { }

	// RVA: 0x17AE3DC
	internal void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17B5104
	private bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo, bool isThreadSuccess) { }

	// RVA: 0x17B9AE4
	internal void CloseLastLinkTag(TextInfo textInfo) { }

	// RVA: 0x17B9C68
	internal void CloseAllLinkTags(TextInfo textInfo) { }

	// RVA: 0x17B9BFC
	private void CloseLinkTag(TextInfo textInfo, int index) { }

	// RVA: 0x17B9A7C
	private void ClearMarkupTagAttributes() { }

	// RVA: 0x17B9CE4
	private void SaveWordWrappingState(WordWrapState state, int index, int count, TextInfo textInfo) { }

	// RVA: 0x17BA058
	private int RestoreWordWrappingState(WordWrapState state, TextInfo textInfo) { }

	// RVA: 0x17BA3B0
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17BABF4
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17BB138
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17BBF40
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17AE690
	private static void ClearMesh(bool updateMesh, TextInfo textInfo) { }

	// RVA: 0x17B2ECC
	public void LayoutPhase(TextInfo textInfo, TextGenerationSettings generationSettings, float maxVisibleDescender) { }

	// RVA: 0x17AE6B4
	public void ParsingPhase(TextInfo textInfo, TextGenerationSettings generationSettings, UInt32 charCode, float maxVisibleDescender) { }

	// RVA: 0x17BC3C4
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, bool isMaxVisibleDescenderSet, float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17BC878
	public Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x17BCA24
	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17BCB64
	protected virtual Vector2 CalculatePreferredValues(float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17AE194
	internal void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17C2638
	internal bool PrepareFontAsset(TextGenerationSettings generationSettings) { }

	// RVA: 0x17C0AAC
	private int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17C3E40
	private TextElement GetTextElement(TextGenerationSettings generationSettings, UInt32 unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, bool isUsingAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x17BFC34
	private void PopulateTextBackingArray(RenderedText sourceText) { }

	// RVA: 0x17BFD18
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings) { }

	// RVA: 0x17C2734
	private bool PopulateFontAsset(TextGenerationSettings generationSettings, TextProcessingElement[] textProcessingArray) { }

	// RVA: 0x17BFBC8
	private void ComputeMarginSize(Rect rect, Vector4 margins) { }

	// RVA: 0x17BFB84
	protected bool GetSpecialCharacters(TextGenerationSettings generationSettings) { }

	// RVA: 0x17C3B38
	protected bool GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x17BBC8C
	protected bool GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x17C4298
	protected void DoMissingGlyphCallback(UInt32 unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo) { }

	// RVA: 0x17C4338
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextGenerationSettings
{
	// Fields
	internal static System.Func<System.Boolean> IsEditorTextRenderingModeBitmap; // 0x0
	private RenderedText m_RenderedText; // 0x10
	private string m_CachedRenderedText; // 0x30
	public Rect screenRect; // 0x38
	public float pixelsPerPoint; // 0x48
	public bool isEditorRenderingModeBitmap; // 0x4C
	public FontAsset fontAsset; // 0x50
	public FontStyles fontStyle; // 0x58
	public TextSettings textSettings; // 0x60
	public TextAlignment textAlignment; // 0x68
	public TextOverflowMode overflowMode; // 0x6C
	public const float wordWrappingRatio = 0.4;
	public Color color; // 0x70
	public bool shouldConvertToLinearSpace; // 0x80
	public float fontSize; // 0x84
	public const bool autoSize = 0;
	public const float fontSizeMin = 0;
	public const float fontSizeMax = 0;
	internal static readonly System.Collections.Generic.List<UnityEngine.TextCore.Text.OTL_FeatureTag> fontFeatures; // 0x8
	public bool emojiFallbackSupport; // 0x88
	public bool richText; // 0x89
	public bool isRightToLeft; // 0x8A
	public float extraPadding; // 0x8C
	public bool parseControlCharacters; // 0x90
	public bool isPlaceholder; // 0x91
	public const bool tagNoParsing = 0;
	public float characterSpacing; // 0x94
	public float wordSpacing; // 0x98
	public const float lineSpacing = 0;
	public float paragraphSpacing; // 0x9C
	public const float lineSpacingMax = 0;
	public TextWrappingMode textWrappingMode; // 0xA0
	public const int maxVisibleCharacters = 99999;
	public const int maxVisibleWords = 99999;
	public const int maxVisibleLines = 99999;
	public const int firstVisibleCharacter = 0;
	public const bool useMaxVisibleDescender = 0;
	public TextFontWeight fontWeight; // 0xA4
	public bool isIMGUI; // 0xA8
	public const float charWidthMaxAdj = 0;

	// Methods

	// RVA: 0x17CA91C
	public RenderedText get_renderedText() { }

	// RVA: 0x17CA928
	public void set_renderedText(RenderedText value) { }

	// RVA: 0x17CA964
	public string get_text() { }

	// RVA: 0x17CAD6C
	public void set_text(string value) { }

	// RVA: 0x17CAF34
	public void .ctor() { }

	// RVA: 0x17CAF8C
	public bool Equals(TextGenerationSettings other) { }

	// RVA: 0x17CB364
	public override bool Equals(object obj) { }

	// RVA: 0x17CB484
	public override int GetHashCode() { }

	// RVA: 0x17CB7BC
	public static bool op_Inequality(TextGenerationSettings left, TextGenerationSettings right) { }

	// RVA: 0x17CB7D8
	public override string ToString() { }

	// RVA: 0x17CC698
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal enum TextAlignment
{
	// Fields
	public int value__; // 0x10
	public const TextAlignment TopLeft = 257;
	public const TextAlignment TopCenter = 258;
	public const TextAlignment TopRight = 260;
	public const TextAlignment TopJustified = 264;
	public const TextAlignment TopFlush = 272;
	public const TextAlignment TopGeoAligned = 288;
	public const TextAlignment MiddleLeft = 513;
	public const TextAlignment MiddleCenter = 514;
	public const TextAlignment MiddleRight = 516;
	public const TextAlignment MiddleJustified = 520;
	public const TextAlignment MiddleFlush = 528;
	public const TextAlignment MiddleGeoAligned = 544;
	public const TextAlignment BottomLeft = 1025;
	public const TextAlignment BottomCenter = 1026;
	public const TextAlignment BottomRight = 1028;
	public const TextAlignment BottomJustified = 1032;
	public const TextAlignment BottomFlush = 1040;
	public const TextAlignment BottomGeoAligned = 1056;
	public const TextAlignment BaselineLeft = 2049;
	public const TextAlignment BaselineCenter = 2050;
	public const TextAlignment BaselineRight = 2052;
	public const TextAlignment BaselineJustified = 2056;
	public const TextAlignment BaselineFlush = 2064;
	public const TextAlignment BaselineGeoAligned = 2080;
	public const TextAlignment MidlineLeft = 4097;
	public const TextAlignment MidlineCenter = 4098;
	public const TextAlignment MidlineRight = 4100;
	public const TextAlignment MidlineJustified = 4104;
	public const TextAlignment MidlineFlush = 4112;
	public const TextAlignment MidlineGeoAligned = 4128;
	public const TextAlignment CaplineLeft = 8193;
	public const TextAlignment CaplineCenter = 8194;
	public const TextAlignment CaplineRight = 8196;
	public const TextAlignment CaplineJustified = 8200;
	public const TextAlignment CaplineFlush = 8208;
	public const TextAlignment CaplineGeoAligned = 8224;
}

// Namespace: UnityEngine.TextCore.Text
public enum FontStyles
{
	// Fields
	public int value__; // 0x10
	public const FontStyles Normal = 0;
	public const FontStyles Bold = 1;
	public const FontStyles Italic = 2;
	public const FontStyles Underline = 4;
	public const FontStyles LowerCase = 8;
	public const FontStyles UpperCase = 16;
	public const FontStyles SmallCaps = 32;
	public const FontStyles Strikethrough = 64;
	public const FontStyles Superscript = 128;
	public const FontStyles Subscript = 256;
	public const FontStyles Highlight = 512;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextOverflowMode
{
	// Fields
	public int value__; // 0x10
	public const TextOverflowMode Overflow = 0;
	public const TextOverflowMode Ellipsis = 1;
	public const TextOverflowMode Masking = 2;
	public const TextOverflowMode Truncate = 3;
	public const TextOverflowMode ScrollRect = 4;
	public const TextOverflowMode Linked = 6;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextWrappingMode
{
	// Fields
	public int value__; // 0x10
	public const TextWrappingMode NoWrap = 0;
	public const TextWrappingMode Normal = 1;
	public const TextWrappingMode PreserveWhitespace = 2;
	public const TextWrappingMode PreserveWhitespaceNoWrap = 3;
}

// Namespace: 
public struct Enumerator
{
	// Fields
	private readonly RenderedText m_Source; // 0x10
	private int m_Stage; // 0x30
	private int m_StageIndex; // 0x34
	private Char m_Current; // 0x38

	// Methods

	// RVA: 0x17CD0B0
	public Char get_Current() { }

	// RVA: 0x17CC9C0
	public void .ctor(RenderedText source) { }

	// RVA: 0x17CC9F4
	public bool MoveNext() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct RenderedText
{
	// Fields
	public readonly string value; // 0x10
	public readonly int valueStart; // 0x18
	public readonly int valueLength; // 0x1C
	public readonly string suffix; // 0x20
	public readonly Char repeat; // 0x28
	public readonly int repeatCount; // 0x2C

	// Methods

	// RVA: 0x17CAE6C
	public void .ctor(string value) { }

	// RVA: 0x17CC83C
	public void .ctor(string value, string suffix) { }

	// RVA: 0x17CC770
	public void .ctor(string value, int start, int length, string suffix) { }

	// RVA: 0x17CC908
	public void .ctor(Char repeat, int repeatCount, string suffix) { }

	// RVA: 0x17CC960
	public int get_CharacterCount() { }

	// RVA: 0x17CC984
	public Enumerator GetEnumerator() { }

	// RVA: 0x17CA9DC
	public string CreateString() { }

	// RVA: 0x17CB23C
	public bool Equals(RenderedText other) { }

	// RVA: 0x17CCB08
	public bool Equals(string other) { }

	// RVA: 0x17CCE84
	public override bool Equals(object obj) { }

	// RVA: 0x17CCFE8
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct RichTextTagAttribute
{
	// Fields
	public int nameHashCode; // 0x10
	public int valueHashCode; // 0x14
	public TagValueType valueType; // 0x18
	public int valueStartIndex; // 0x1C
	public int valueLength; // 0x20
	public TagUnitType unitType; // 0x24
}

// Namespace: UnityEngine.TextCore.Text
internal struct TextProcessingElement
{
	// Fields
	public TextProcessingElementType elementType; // 0x10
	public UInt32 unicode; // 0x14
	public int stringIndex; // 0x18
	public int length; // 0x1C
}

// Namespace: UnityEngine.TextCore.Text
internal struct TextBackingContainer
{
	// Fields
	private UInt32[] m_Array; // 0x10
	private int m_Count; // 0x18

	// Methods

	// RVA: 0x17CD0B8
	public int get_Capacity() { }

	// RVA: 0x17CD0D8
	public int get_Count() { }

	// RVA: 0x17CD0E0
	public void set_Count(int value) { }

	// RVA: 0x17CD0E8
	public UInt32 get_Item(int index) { }

	// RVA: 0x17CD11C
	public void set_Item(int index, UInt32 value) { }

	// RVA: 0x17CD244
	public void .ctor(int size) { }

	// RVA: 0x17CD1D4
	public void Resize(int size) { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct CharacterSubstitution
{
	// Fields
	public int index; // 0x10
	public UInt32 unicode; // 0x14

	// Methods

	// RVA: 0x17CD2B4
	public void .ctor(int index, UInt32 unicode) { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct Offset
{
	// Fields
	private float m_Left; // 0x10
	private float m_Right; // 0x14
	private float m_Top; // 0x18
	private float m_Bottom; // 0x1C
	private static readonly Offset k_ZeroOffset; // 0x0

	// Methods

	// RVA: 0x17CD2BC
	public float get_left() { }

	// RVA: 0x17CD2C4
	public float get_right() { }

	// RVA: 0x17CD2CC
	public float get_top() { }

	// RVA: 0x17CD2D4
	public float get_bottom() { }

	// RVA: 0x17CD2DC
	public static Offset get_zero() { }

	// RVA: 0x17CD360
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x17CD36C
	public static bool op_Equality(Offset lhs, Offset rhs) { }

	// RVA: 0x17CD394
	public static Offset op_Multiply(Offset a, float b) { }

	// RVA: 0x17CD3A8
	public override int GetHashCode() { }

	// RVA: 0x17CD418
	public override bool Equals(object obj) { }

	// RVA: 0x17CD490
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct HighlightState
{
	// Fields
	public Color32 color; // 0x10
	public Offset padding; // 0x14

	// Methods

	// RVA: 0x17CD4DC
	public void .ctor(Color32 color, Offset padding) { }

	// RVA: 0x17CD4EC
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x17CD5E8
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x17CD6D0
	public override int GetHashCode() { }

	// RVA: 0x17CD748
	public override bool Equals(object obj) { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct WordWrapState
{
	// Fields
	public int previousWordBreak; // 0x10
	public int totalCharacterCount; // 0x14
	public int visibleCharacterCount; // 0x18
	public int visibleSpaceCount; // 0x1C
	public int visibleSpriteCount; // 0x20
	public int visibleLinkCount; // 0x24
	public int firstCharacterIndex; // 0x28
	public int firstVisibleCharacterIndex; // 0x2C
	public int lastCharacterIndex; // 0x30
	public int lastVisibleCharIndex; // 0x34
	public int lineNumber; // 0x38
	public float maxCapHeight; // 0x3C
	public float maxAscender; // 0x40
	public float maxDescender; // 0x44
	public float maxLineAscender; // 0x48
	public float maxLineDescender; // 0x4C
	public float startOfLineAscender; // 0x50
	public float xAdvance; // 0x54
	public float preferredWidth; // 0x58
	public float preferredHeight; // 0x5C
	public float previousLineScale; // 0x60
	public float pageAscender; // 0x64
	public int wordCount; // 0x68
	public FontStyles fontStyle; // 0x6C
	public float fontScale; // 0x70
	public float fontScaleMultiplier; // 0x74
	public int italicAngle; // 0x78
	public float currentFontSize; // 0x7C
	public float baselineOffset; // 0x80
	public float lineOffset; // 0x84
	public TextInfo textInfo; // 0x88
	public LineInfo lineInfo; // 0x90
	public Color32 vertexColor; // 0xF0
	public Color32 underlineColor; // 0xF4
	public Color32 strikethroughColor; // 0xF8
	public Color32 highlightColor; // 0xFC
	public HighlightState highlightState; // 0x100
	public FontStyleStack basicStyleStack; // 0x114
	public UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> italicAngleStack; // 0x120
	public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> colorStack; // 0x140
	public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> underlineColorStack; // 0x160
	public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> strikethroughColorStack; // 0x180
	public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.Color32> highlightColorStack; // 0x1A0
	public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.HighlightState> highlightStateStack; // 0x1C0
	public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextColorGradient> colorGradientStack; // 0x1F0
	public UnityEngine.TextCore.Text.TextProcessingStack<System.Single> sizeStack; // 0x218
	public UnityEngine.TextCore.Text.TextProcessingStack<System.Single> indentStack; // 0x238
	public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextFontWeight> fontWeightStack; // 0x258
	public UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> styleStack; // 0x278
	public UnityEngine.TextCore.Text.TextProcessingStack<System.Single> baselineStack; // 0x298
	public UnityEngine.TextCore.Text.TextProcessingStack<System.Int32> actionStack; // 0x2B8
	public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.MaterialReference> materialReferenceStack; // 0x2D8
	public UnityEngine.TextCore.Text.TextProcessingStack<UnityEngine.TextCore.Text.TextAlignment> lineJustificationStack; // 0x330
	public int lastBaseGlyphIndex; // 0x350
	public int spriteAnimationId; // 0x354
	public FontAsset currentFontAsset; // 0x358
	public SpriteAsset currentSpriteAsset; // 0x360
	public Material currentMaterial; // 0x368
	public int currentMaterialIndex; // 0x370
	public Extents meshExtents; // 0x374
	public bool tagNoParsing; // 0x384
	public bool isNonBreakingSpace; // 0x385
	public bool isDrivenLineSpacing; // 0x386
	public Vector3 fxScale; // 0x388
	public Quaternion fxRotation; // 0x394
}

// Namespace: UnityEngine.TextCore.Text
internal static class TextGeneratorUtilities
{
	// Fields
	public static readonly Vector2 largePositiveVector2; // 0x0
	public static readonly Vector2 largeNegativeVector2; // 0x8
	private static readonly System.Collections.Generic.HashSet<System.UInt32> k_EmojiLookup; // 0x10
	private static readonly System.Collections.Generic.HashSet<System.UInt32> k_EmojiPresentationFormLookup; // 0x18

	// Methods

	// RVA: 0x17CD7C8
	public static bool Approximately(float a, float b) { }

	// RVA: 0x17CD7FC
	public static Color32 HexCharsToColor(Char[] hexChars, int startIndex, int tagCount) { }

	// RVA: 0x17CDBFC
	public static UInt32 HexToInt(Char hex) { }

	// RVA: 0x17CDC24
	public static float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	// RVA: 0x17CDCAC
	public static float ConvertToFloat(Char[] chars, int startIndex, int length, int lastIndex) { }

	// RVA: 0x352BD5C
	public static void ResizeInternalArray(T[] array) { }

	// RVA: 0x352C064
	public static void ResizeInternalArray(T[] array, int size) { }

	// RVA: 0x17CDE2C
	internal static void InsertOpeningTextStyle(TextStyle style, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x17CE498
	internal static void InsertClosingTextStyle(TextStyle style, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x17CE5AC
	public static bool ReplaceOpeningStyleTag(TextBackingContainer sourceText, int srcIndex, int srcOffset, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x17CE958
	private static bool ReplaceOpeningStyleTag(UInt32[] sourceText, int srcIndex, int srcOffset, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x17CEC00
	public static void ReplaceClosingStyleTag(TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x17CED34
	internal static void InsertOpeningStyleTag(TextStyle style, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x17CEE28
	internal static void InsertClosingStyleTag(TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x17CDF40
	private static void InsertTextStyleInTextProcessingArray(TextProcessingElement[] charBuffer, int writeIndex, UInt32[] styleDefinition, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x17CE854
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	// RVA: 0x17CEAC0
	public static int GetStyleHashCode(UInt32[] text, int index, int closeIndex) { }

	// RVA: 0x17CE714
	public static int GetStyleHashCode(TextBackingContainer text, int index, int closeIndex) { }

	// RVA: 0x17CEF20
	public static UInt32 GetUTF16(UInt32[] text, int i) { }

	// RVA: 0x17CF388
	public static UInt32 GetUTF16(TextBackingContainer text, int i) { }

	// RVA: 0x17CF018
	public static UInt32 GetUTF32(UInt32[] text, int i) { }

	// RVA: 0x17CF480
	public static UInt32 GetUTF32(TextBackingContainer text, int i) { }

	// RVA: 0x17CF608
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17CFEE0
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17D04DC
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	// RVA: 0x17D05C8
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	// RVA: 0x17D0764
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	// RVA: 0x17D0774
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	// RVA: 0x17D0798
	internal static HorizontalAlignment GetHorizontalAlignment(TextAnchor anchor) { }

	// RVA: 0x17D07BC
	internal static VerticalAlignment GetVerticalAlignment(TextAnchor anchor) { }

	// RVA: 0x17D07E0
	public static UInt32 ConvertToUTF32(UInt32 highSurrogate, UInt32 lowSurrogate) { }

	// RVA: 0x17D07F4
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x17CF1A0
	public static int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	// RVA: 0x17CF304
	public static Char ToUpperASCIIFast(Char c) { }

	// RVA: 0x17D0958
	public static UInt32 ToUpperASCIIFast(UInt32 c) { }

	// RVA: 0x17D09D8
	public static Char ToUpperFast(Char c) { }

	// RVA: 0x17D0A5C
	public static int GetAttributeParameters(Char[] chars, int startIndex, int length, float[] parameters) { }

	// RVA: 0x17D0B54
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	// RVA: 0x17D0B88
	public static bool IsBaseGlyph(UInt32 c) { }

	// RVA: 0x17D0CC0
	public static Color MinAlpha(Color c1, Color c2) { }

	// RVA: 0x17CFC74
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x17D0CCC
	private static Byte GammaToLinear(Byte value) { }

	// RVA: 0x17D0D8C
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	// RVA: 0x17D0E6C
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	// RVA: 0x17D100C
	internal static bool IsEmoji(UInt32 c) { }

	// RVA: 0x17D10C0
	internal static bool IsEmojiPresentationForm(UInt32 c) { }

	// RVA: 0x17D1174
	internal static bool IsHangul(UInt32 c) { }

	// RVA: 0x17D11D0
	internal static bool IsCJK(UInt32 c) { }

	// RVA: 0x17D1288
	private static void .cctor() { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x17D21AC
	public static IntPtr ConvertToNative(TextLib textLib) { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextLib
{
	// Fields
	private readonly IntPtr m_Ptr; // 0x10
	public static System.Func<UnityEngine.TextAsset> GetICUAssetEditorDelegate; // 0x0

	// Methods

	// RVA: 0x17D13E4
	public void .ctor(Byte[] icuData) { }

	// RVA: 0x17D1418
	private static IntPtr GetInstance(Byte[] icuData) { }

	// RVA: 0x17D153C
	public NativeTextInfo GenerateText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	// RVA: 0x17D16D8
	public void ProcessMeshInfos(NativeTextInfo textInfo, NativeTextGenerationSettings settings) { }

	// RVA: 0x17D1644
	private NativeTextInfo GenerateTextInternal(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	// RVA: 0x17D1FF4
	public Vector2 MeasureText(NativeTextGenerationSettings settings, IntPtr textGenerationInfo) { }

	// RVA: 0x17D20F0
	public static int FindIntersectingLink(Vector2 point, IntPtr textGenerationInfo) { }

	// RVA: 0x17D14EC
	private static IntPtr GetInstance_Injected(ManagedSpanWrapper icuData) { }

	// RVA: 0x17D1F8C
	private static void GenerateTextInternal_Injected(IntPtr _unity_self, NativeTextGenerationSettings settings, IntPtr textGenerationInfo, NativeTextInfo ret) { }

	// RVA: 0x17D2088
	private static void MeasureText_Injected(IntPtr _unity_self, NativeTextGenerationSettings settings, IntPtr textGenerationInfo, Vector2 ret) { }

	// RVA: 0x17D2144
	private static int FindIntersectingLink_Injected(Vector2 point, IntPtr textGenerationInfo) { }

}

// Namespace: UnityEngine.TextCore.Text
internal static class TextGenerationInfo
{
	// Methods

	// RVA: 0x17D21C8
	public static IntPtr Create() { }

	// RVA: 0x17D2208
	public static void Destroy(IntPtr ptr) { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextSelectionService
{
	// Methods

	// RVA: 0x17D2258
	internal static string Substring(IntPtr textGenerationInfo, int startIndex, int endIndex) { }

	// RVA: 0x17D23B8
	internal static void SelectCurrentWord(IntPtr textGenerationInfo, int currentIndex, int startIndex, int endIndex) { }

	// RVA: 0x17D2420
	internal static int PreviousCodePointIndex(IntPtr textGenerationInfo, int currentIndex) { }

	// RVA: 0x17D2488
	internal static int NextCodePointIndex(IntPtr textGenerationInfo, int currentIndex) { }

	// RVA: 0x17D24F0
	internal static int GetCursorLogicalIndexFromPosition(IntPtr textGenerationInfo, Vector2 position) { }

	// RVA: 0x17D25AC
	internal static Vector2 GetCursorPositionFromLogicalIndex(IntPtr textGenerationInfo, int logicalIndex) { }

	// RVA: 0x17D266C
	internal static int LineUpCharacterPosition(IntPtr textGenerationInfo, int originalPos) { }

	// RVA: 0x17D26D4
	internal static int LineDownCharacterPosition(IntPtr textGenerationInfo, int originalPos) { }

	// RVA: 0x17D273C
	internal static Rect[] GetHighlightRectangles(IntPtr textGenerationInfo, int cursorIndex, int selectIndex) { }

	// RVA: 0x17D28CC
	internal static float GetCharacterHeightFromIndex(IntPtr textGenerationInfo, int index) { }

	// RVA: 0x17D2934
	internal static int GetStartOfNextWord(IntPtr textGenerationInfo, int currentIndex) { }

	// RVA: 0x17D299C
	internal static int GetEndOfPreviousWord(IntPtr textGenerationInfo, int currentIndex) { }

	// RVA: 0x17D2A04
	internal static int GetFirstCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex) { }

	// RVA: 0x17D2A6C
	internal static int GetLastCharacterIndexOnLine(IntPtr textGenerationInfo, int currentIndex) { }

	// RVA: 0x17D2AD4
	internal static float GetLineHeight(IntPtr textGenerationInfo, int lineIndex) { }

	// RVA: 0x17D2B3C
	internal static int GetLineNumber(IntPtr textGenerationInfo, int logicalIndex) { }

	// RVA: 0x17D2BA4
	internal static void SelectToPreviousParagraph(IntPtr textGenerationInfo, int cursorIndex) { }

	// RVA: 0x17D2C0C
	internal static void SelectToStartOfParagraph(IntPtr textGenerationInfo, int cursorIndex) { }

	// RVA: 0x17D2C74
	internal static void SelectToEndOfParagraph(IntPtr textGenerationInfo, int cursorIndex) { }

	// RVA: 0x17D2CDC
	internal static void SelectToNextParagraph(IntPtr textGenerationInfo, int cursorIndex) { }

	// RVA: 0x17D2D44
	internal static void SelectCurrentParagraph(IntPtr textGenerationInfo, int cursorIndex, int selectIndex) { }

	// RVA: 0x17D2350
	private static void Substring_Injected(IntPtr textGenerationInfo, int startIndex, int endIndex, ManagedSpanWrapper ret) { }

	// RVA: 0x17D2544
	private static int GetCursorLogicalIndexFromPosition_Injected(IntPtr textGenerationInfo, Vector2 position) { }

	// RVA: 0x17D2614
	private static void GetCursorPositionFromLogicalIndex_Injected(IntPtr textGenerationInfo, int logicalIndex, Vector2 ret) { }

	// RVA: 0x17D2864
	private static void GetHighlightRectangles_Injected(IntPtr textGenerationInfo, int cursorIndex, int selectIndex, BlittableArrayWrapper ret) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.TextCore.Text.TextHandle.<>c <>9; // 0x0
	public static System.Func<UnityEngine.TextCore.Text.TextGenerationSettings> <>9__4_0; // 0x8
	public static System.Func<UnityEngine.TextCore.Text.TextGenerator> <>9__4_1; // 0x10
	public static System.Func<UnityEngine.TextCore.Text.TextInfo> <>9__4_2; // 0x18
	public static System.Func<UnityEngine.TextCore.Text.TextGenerationSettings> <>9__7_0; // 0x20
	public static System.Func<UnityEngine.TextCore.Text.TextGenerator> <>9__10_0; // 0x28
	public static System.Func<UnityEngine.TextCore.Text.TextInfo> <>9__13_0; // 0x30

	// Methods

	// RVA: 0x17D8030
	private static void .cctor() { }

	// RVA: 0x17D809C
	public void .ctor() { }

	// RVA: 0x17D80A4
	internal TextGenerationSettings <InitThreadArrays>b__4_0() { }

	// RVA: 0x17D814C
	internal TextGenerator <InitThreadArrays>b__4_1() { }

	// RVA: 0x17D81A4
	internal TextInfo <InitThreadArrays>b__4_2() { }

	// RVA: 0x17D8418
	internal TextGenerationSettings <get_settingsArray>b__7_0() { }

	// RVA: 0x17D84C0
	internal TextGenerator <get_generators>b__10_0() { }

	// RVA: 0x17D8518
	internal TextInfo <get_textInfosCommon>b__13_0() { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextHandle
{
	// Fields
	internal static TextHandleTemporaryCache s_TemporaryCache; // 0x0
	internal static TextHandlePermanentCache s_PermanentCache; // 0x8
	private static TextGenerationSettings[] s_Settings; // 0x10
	private static TextGenerator[] s_Generators; // 0x18
	private static TextInfo[] s_TextInfosCommon; // 0x20
	internal NativeTextGenerationSettings nativeSettings; // 0x10
	private Vector2 <preferredSize>k__BackingField; // 0x70
	private Rect m_ScreenRect; // 0x78
	private float m_LineHeightDefault; // 0x88
	private bool m_IsPlaceholder; // 0x8C
	protected bool m_IsEllided; // 0x8D
	internal IntPtr textGenerationInfo; // 0x90
	private System.Collections.Generic.LinkedListNode<UnityEngine.TextCore.Text.TextInfo> <TextInfoNode>k__BackingField; // 0x98
	private bool <IsCachedPermanent>k__BackingField; // 0xA0
	private bool <IsCachedTemporary>k__BackingField; // 0xA1
	internal int m_PreviousGenerationSettingsHash; // 0xA4
	protected bool isDirty; // 0xA8

	// Methods

	// RVA: 0x17D2D9C
	public void .ctor() { }

	// RVA: 0x17D2E00
	protected override void Finalize() { }

	// RVA: 0x17D3044
	internal static void InitThreadArrays() { }

	// RVA: 0x17D3458
	internal static TextGenerationSettings[] get_settingsArray() { }

	// RVA: 0x17D3634
	internal static TextGenerator[] get_generators() { }

	// RVA: 0x17D3810
	internal static TextInfo[] get_textInfosCommon() { }

	// RVA: 0x352CF50
	private static void InitArray(T[] array, System.Func<T> createInstance) { }

	// RVA: 0x17D39EC
	internal static TextInfo get_textInfoCommon() { }

	// RVA: 0x17D3A8C
	private static TextGenerator get_generator() { }

	// RVA: 0x17D3B2C
	internal static TextGenerationSettings get_settings() { }

	// RVA: 0x17D3BCC
	internal Vector2 get_preferredSize() { }

	// RVA: 0x17D3BD4
	internal void set_preferredSize(Vector2 value) { }

	// RVA: 0x17D3BDC
	internal System.Collections.Generic.LinkedListNode<UnityEngine.TextCore.Text.TextInfo> get_TextInfoNode() { }

	// RVA: 0x17D3BE4
	internal void set_TextInfoNode(System.Collections.Generic.LinkedListNode<UnityEngine.TextCore.Text.TextInfo> value) { }

	// RVA: 0x17D3BEC
	internal bool get_IsCachedPermanent() { }

	// RVA: 0x17D3BF4
	internal void set_IsCachedPermanent(bool value) { }

	// RVA: 0x17D3BFC
	internal bool get_IsCachedTemporary() { }

	// RVA: 0x17D3C04
	internal void set_IsCachedTemporary(bool value) { }

	// RVA: 0x17D3C0C
	internal bool get_useAdvancedText() { }

	// RVA: 0x17D3C18
	internal int get_characterCount() { }

	// RVA: 0x17D3DBC
	public virtual void AddTextInfoToPermanentCache() { }

	// RVA: 0x17D3E8C
	public void AddTextInfoToTemporaryCache(int hashCode) { }

	// RVA: 0x17D2EF8
	public void RemoveTextInfoFromTemporaryCache() { }

	// RVA: 0x17D2F8C
	public void RemoveTextInfoFromPermanentCache() { }

	// RVA: 0x17D45F4
	public static void UpdateCurrentFrame() { }

	// RVA: 0x17D3C74
	internal TextInfo get_textInfo() { }

	// RVA: 0x17D46A4
	public void SetDirty() { }

	// RVA: 0x17D46B0
	public bool IsDirty(int hashCode) { }

	// RVA: 0x17D46EC
	public virtual bool get_IsPlaceholder() { }

	// RVA: 0x17D46F4
	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	// RVA: 0x17D488C
	internal TextInfo Update() { }

	// RVA: 0x17D499C
	internal TextInfo UpdateWithHash(int hashCode) { }

	// RVA: 0x17D512C
	internal bool PrepareFontAsset() { }

	// RVA: 0x17D5494
	internal void UpdatePreferredSize() { }

	// RVA: 0x17D5748
	internal static float ConvertPixelUnitsToTextCoreRelativeUnits(float fontSize, FontAsset fontAsset) { }

	// RVA: 0x17D4FA0
	internal static float GetLineHeightDefault(TextGenerationSettings settings) { }

	// RVA: 0x17D57D0
	public virtual Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis) { }

	// RVA: 0x17D58A0
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance, bool inverseYAxis) { }

	// RVA: 0x17D5ACC
	internal Rect[] GetHighlightRectangles(int cursorIndex, int selectIndex) { }

	// RVA: 0x17D5BB0
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis) { }

	// RVA: 0x17D5D94
	public int LineDownCharacterPosition(int originalLogicalPos) { }

	// RVA: 0x17D5F64
	public int LineUpCharacterPosition(int originalLogicalPos) { }

	// RVA: 0x17D6144
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis) { }

	// RVA: 0x17D64F0
	public int GetCorrespondingStringIndex(int index) { }

	// RVA: 0x17D65D0
	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	// RVA: 0x17D67A0
	public int GetLineNumber(int index) { }

	// RVA: 0x17D68C8
	public float GetLineHeight(int lineNumber) { }

	// RVA: 0x17D69F0
	public float GetLineHeightFromCharacterIndex(int index) { }

	// RVA: 0x17D6B88
	public float GetCharacterHeightFromIndex(int index) { }

	// RVA: 0x17D6CC0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x17D6EB8
	public int PreviousCodePointIndex(int currentIndex) { }

	// RVA: 0x17D6FB8
	public int NextCodePointIndex(int currentIndex) { }

	// RVA: 0x17D70B8
	public int GetStartOfNextWord(int currentIndex) { }

	// RVA: 0x17D71B8
	public int GetEndOfPreviousWord(int currentIndex) { }

	// RVA: 0x17D72B8
	public int GetFirstCharacterIndexOnLine(int currentIndex) { }

	// RVA: 0x17D73B8
	public int GetLastCharacterIndexOnLine(int currentIndex) { }

	// RVA: 0x17D74B8
	public int IndexOf(Char value, int startIndex) { }

	// RVA: 0x17D762C
	public int LastIndexOf(Char value, int startIndex) { }

	// RVA: 0x17D7798
	public void SelectCurrentWord(int index, int cursorIndex, int selectIndex) { }

	// RVA: 0x17D7894
	public void SelectCurrentParagraph(int cursorIndex, int selectIndex) { }

	// RVA: 0x17D7994
	public void SelectToPreviousParagraph(int cursorIndex) { }

	// RVA: 0x17D7AA4
	public void SelectToNextParagraph(int cursorIndex) { }

	// RVA: 0x17D7BB4
	public void SelectToStartOfParagraph(int cursorIndex) { }

	// RVA: 0x17D7CC4
	public void SelectToEndOfParagraph(int cursorIndex) { }

	// RVA: 0x17D7DD4
	internal virtual bool IsAdvancedTextEnabledForElement() { }

	// RVA: 0x17D7DDC
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextHandlePermanentCache
{
	// Fields
	internal System.Collections.Generic.LinkedList<UnityEngine.TextCore.Text.TextInfo> s_TextInfoPool; // 0x10
	private object syncRoot; // 0x18

	// Methods

	// RVA: 0x17D856C
	public virtual void AddTextInfoToCache(TextHandle textHandle) { }

	// RVA: 0x17D4498
	public void RemoveTextInfoFromCache(TextHandle textHandle) { }

	// RVA: 0x17D7F64
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextHandleTemporaryCache
{
	// Fields
	internal System.Collections.Generic.LinkedList<UnityEngine.TextCore.Text.TextInfo> s_TextInfoPool; // 0x10
	internal const int s_MinFramesInCache = 2;
	internal int currentFrame; // 0x18
	private object syncRoot; // 0x20

	// Methods

	// RVA: 0x17D8824
	public void ClearTemporaryCache() { }

	// RVA: 0x17D3F2C
	public void AddTextInfoToCache(TextHandle textHandle, int hashCode) { }

	// RVA: 0x17D8E14
	public virtual void RemoveTextInfoFromCache(TextHandle textHandle) { }

	// RVA: 0x17D8988
	private void RefreshCaching(TextHandle textHandle) { }

	// RVA: 0x17D8AF4
	private void RecycleTextInfoFromCache(TextHandle textHandle) { }

	// RVA: 0x17D467C
	public void UpdateCurrentFrame() { }

	// RVA: 0x17D7E98
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct WordInfo
{
	// Fields
	public int firstCharacterIndex; // 0x10
	public int lastCharacterIndex; // 0x14
	public int characterCount; // 0x18
}

// Namespace: UnityEngine.TextCore.Text
internal class TextInfo
{
	// Fields
	private static Vector2 s_InfinityVectorPositive; // 0x0
	private static Vector2 s_InfinityVectorNegative; // 0x8
	public int characterCount; // 0x10
	public int spriteCount; // 0x14
	public int spaceCount; // 0x18
	public int wordCount; // 0x1C
	public int linkCount; // 0x20
	public int lineCount; // 0x24
	public int materialCount; // 0x28
	public TextElementInfo[] textElementInfo; // 0x30
	public WordInfo[] wordInfo; // 0x38
	public LinkInfo[] linkInfo; // 0x40
	public LineInfo[] lineInfo; // 0x48
	public MeshInfo[] meshInfo; // 0x50
	public Double lastTimeInCache; // 0x58
	public Action removedFromCache; // 0x60
	public bool hasMultipleColors; // 0x68

	// Methods

	// RVA: 0x17D8948
	public void RemoveFromCache() { }

	// RVA: 0x17D81F8
	public void .ctor() { }

	// RVA: 0x17D9064
	internal void Clear() { }

	// RVA: 0x17D90EC
	internal void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x17D9158
	internal void ClearLineInfo() { }

	// RVA: 0x352C064
	internal static void Resize(T[] array, int size) { }

	// RVA: 0x352C0D0
	internal static void Resize(T[] array, int size, bool isBlockAllocated) { }

	// RVA: 0x17D92D4
	public virtual Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, Rect screenRect, float lineHeight, bool inverseYAxis) { }

	// RVA: 0x17D5A14
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, Rect screenRect, float lineHeight, bool useXAdvance, bool inverseYAxis) { }

	// RVA: 0x17D5C64
	public int GetCursorIndexFromPosition(Vector2 position, Rect screenRect, bool inverseYAxis) { }

	// RVA: 0x17D5E34
	public int LineDownCharacterPosition(int originalPos) { }

	// RVA: 0x17D6004
	public int LineUpCharacterPosition(int originalPos) { }

	// RVA: 0x17D9360
	public int FindNearestLine(Vector2 position) { }

	// RVA: 0x17D9404
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	// RVA: 0x17D6238
	public int FindIntersectingLink(Vector3 position, Rect screenRect, bool inverseYAxis) { }

	// RVA: 0x17D657C
	public int GetCorrespondingStringIndex(int index) { }

	// RVA: 0x17D671C
	public LineInfo GetLineInfoFromCharacterIndex(int index) { }

	// RVA: 0x17D968C
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x17D9860
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x17D6878
	public int GetLineNumber(int index) { }

	// RVA: 0x17D69A0
	public float GetLineHeight(int lineNumber) { }

	// RVA: 0x17D6B00
	public float GetLineHeightFromCharacterIndex(int index) { }

	// RVA: 0x17D6C68
	public float GetCharacterHeightFromIndex(int index) { }

	// RVA: 0x17D6D30
	public string Substring(int startIndex, int length) { }

	// RVA: 0x17D757C
	public int IndexOf(Char value, int startIndex) { }

	// RVA: 0x17D76F0
	public int LastIndexOf(Char value, int startIndex) { }

	// RVA: 0x17D9994
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal enum MarkupTag
{
	// Fields
	public int value__; // 0x10
	public const MarkupTag BOLD = 66;
	public const MarkupTag SLASH_BOLD = 1613;
	public const MarkupTag ITALIC = 73;
	public const MarkupTag SLASH_ITALIC = 1606;
	public const MarkupTag UNDERLINE = 85;
	public const MarkupTag SLASH_UNDERLINE = 1626;
	public const MarkupTag STRIKETHROUGH = 83;
	public const MarkupTag SLASH_STRIKETHROUGH = 1628;
	public const MarkupTag MARK = 2699125;
	public const MarkupTag SLASH_MARK = 57644506;
	public const MarkupTag SUBSCRIPT = 92132;
	public const MarkupTag SLASH_SUBSCRIPT = 1770219;
	public const MarkupTag SUPERSCRIPT = 92150;
	public const MarkupTag SLASH_SUPERSCRIPT = 1770233;
	public const MarkupTag COLOR = 81999901;
	public const MarkupTag SLASH_COLOR = 1909026194;
	public const MarkupTag ALPHA = 75165780;
	public const MarkupTag A = 65;
	public const MarkupTag SLASH_A = 1614;
	public const MarkupTag SIZE = 3061285;
	public const MarkupTag SLASH_SIZE = 58429962;
	public const MarkupTag SPRITE = 3303439849;
	public const MarkupTag NO_BREAK = 2856657;
	public const MarkupTag SLASH_NO_BREAK = 57477502;
	public const MarkupTag STYLE = 100252951;
	public const MarkupTag SLASH_STYLE = 1927738392;
	public const MarkupTag FONT = 2586451;
	public const MarkupTag SLASH_FONT = 57747708;
	public const MarkupTag SLASH_MATERIAL = 3194259044;
	public const MarkupTag LINK = 2656128;
	public const MarkupTag SLASH_LINK = 57686191;
	public const MarkupTag FONT_WEIGHT = 2405071134;
	public const MarkupTag SLASH_FONT_WEIGHT = 3536990865;
	public const MarkupTag NO_PARSE = 3886955700;
	public const MarkupTag SLASH_NO_PARSE = 4000871483;
	public const MarkupTag POSITION = 85420;
	public const MarkupTag SLASH_POSITION = 1777699;
	public const MarkupTag VERTICAL_OFFSET = 1952379995;
	public const MarkupTag SLASH_VERTICAL_OFFSET = 4283859348;
	public const MarkupTag SPACE = 100083556;
	public const MarkupTag SLASH_SPACE = 1927873067;
	public const MarkupTag PAGE = 2808691;
	public const MarkupTag SLASH_PAGE = 58683868;
	public const MarkupTag ALIGN = 75138797;
	public const MarkupTag SLASH_ALIGN = 1916026786;
	public const MarkupTag WIDTH = 105793766;
	public const MarkupTag SLASH_WIDTH = 1923459625;
	public const MarkupTag GRADIENT = 2295207398;
	public const MarkupTag SLASH_GRADIENT = 2440475337;
	public const MarkupTag CHARACTER_SPACE = 2710585287;
	public const MarkupTag SLASH_CHARACTER_SPACE = 2900540584;
	public const MarkupTag MONOSPACE = 2954745353;
	public const MarkupTag SLASH_MONOSPACE = 2656101734;
	public const MarkupTag CLASS = 82115566;
	public const MarkupTag INDENT = 2780844220;
	public const MarkupTag SLASH_INDENT = 2798077907;
	public const MarkupTag LINE_INDENT = 3450662175;
	public const MarkupTag SLASH_LINE_INDENT = 93886352;
	public const MarkupTag MARGIN = 2939353246;
	public const MarkupTag SLASH_MARGIN = 2645322993;
	public const MarkupTag MARGIN_LEFT = 4022033640;
	public const MarkupTag MARGIN_RIGHT = 3847550707;
	public const MarkupTag LINE_HEIGHT = 3495885404;
	public const MarkupTag SLASH_LINE_HEIGHT = 200452819;
	public const MarkupTag ACTION = 2467447966;
	public const MarkupTag SLASH_ACTION = 3107749617;
	public const MarkupTag SCALE = 100553336;
	public const MarkupTag SLASH_SCALE = 1928413879;
	public const MarkupTag ROTATE = 3294959513;
	public const MarkupTag SLASH_ROTATE = 3530271734;
	public const MarkupTag TABLE = 226476955;
	public const MarkupTag SLASH_TABLE = 3315849076;
	public const MarkupTag TH = 5862489;
	public const MarkupTag SLASH_TH = 193346070;
	public const MarkupTag TR = 5862467;
	public const MarkupTag SLASH_TR = 193346060;
	public const MarkupTag TD = 5862485;
	public const MarkupTag SLASH_TD = 193346074;
	public const MarkupTag LOWERCASE = 2788067607;
	public const MarkupTag SLASH_LOWERCASE = 2843682712;
	public const MarkupTag ALLCAPS = 218273952;
	public const MarkupTag SLASH_ALLCAPS = 3497529647;
	public const MarkupTag UPPERCASE = 3989557878;
	public const MarkupTag SLASH_UPPERCASE = 3712599097;
	public const MarkupTag SMALLCAPS = 3528905182;
	public const MarkupTag SLASH_SMALLCAPS = 199921873;
	public const MarkupTag LIGA = 2655971;
	public const MarkupTag SLASH_LIGA = 57686604;
	public const MarkupTag FRAC = 2598518;
	public const MarkupTag SLASH_FRAC = 57774681;
	public const MarkupTag NAME = 2875623;
	public const MarkupTag INDEX = 84268030;
	public const MarkupTag TINT = 2960519;
	public const MarkupTag ANIM = 2283339;
	public const MarkupTag MATERIAL = 825491659;
	public const MarkupTag HREF = 2535353;
	public const MarkupTag ANGLE = 75347905;
	public const MarkupTag PADDING = 2150398833;
	public const MarkupTag FAMILYNAME = 704251153;
	public const MarkupTag STYLENAME = 3087885360;
	public const MarkupTag DUOSPACE = 582810522;
	public const MarkupTag RED = 91635;
	public const MarkupTag GREEN = 87065851;
	public const MarkupTag BLUE = 2457214;
	public const MarkupTag YELLOW = 3412522628;
	public const MarkupTag ORANGE = 3186379376;
	public const MarkupTag BLACK = 81074727;
	public const MarkupTag WHITE = 105680263;
	public const MarkupTag PURPLE = 3044745166;
	public const MarkupTag GREY = 2638345;
	public const MarkupTag LIGHTBLUE = 341063360;
	public const MarkupTag TEAL = 2947772;
	public const MarkupTag CYAN = 2504597;
	public const MarkupTag DARKBLUE = 2334657378;
	public const MarkupTag FUCHSIA = 3292251651;
	public const MarkupTag SILVER = 3334637975;
	public const MarkupTag BROWN = 81017702;
	public const MarkupTag MAROON = 2939345360;
	public const MarkupTag OLIVE = 95492953;
	public const MarkupTag NAVY = 2876352;
	public const MarkupTag AQUA = 2284356;
	public const MarkupTag MAGENTA = 2482391189;
	public const MarkupTag TRANSPARENT = 3280181958;
	public const MarkupTag LIME = 2656045;
	public const MarkupTag BR = 2256;
	public const MarkupTag CR = 2289;
	public const MarkupTag ZWSP = 3288238;
	public const MarkupTag ZWJ = 99623;
	public const MarkupTag NBSP = 2869039;
	public const MarkupTag SHY = 92674;
	public const MarkupTag LEFT = 2660507;
	public const MarkupTag RIGHT = 99937376;
	public const MarkupTag CENTER = 2703854027;
	public const MarkupTag JUSTIFIED = 817091359;
	public const MarkupTag FLUSH = 85552164;
	public const MarkupTag NONE = 2857034;
	public const MarkupTag PLUS = 43;
	public const MarkupTag MINUS = 45;
	public const MarkupTag PX = 2568;
	public const MarkupTag PLUS_PX = 49507;
	public const MarkupTag MINUS_PX = 47461;
	public const MarkupTag EM = 2216;
	public const MarkupTag PLUS_EM = 49091;
	public const MarkupTag MINUS_EM = 46789;
	public const MarkupTag PCT = 85031;
	public const MarkupTag PLUS_PCT = 1634348;
	public const MarkupTag MINUS_PCT = 1567082;
	public const MarkupTag PERCENTAGE = 37;
	public const MarkupTag PLUS_PERCENTAGE = 1454;
	public const MarkupTag MINUS_PERCENTAGE = 1512;
	public const MarkupTag TRUE = 2932022;
	public const MarkupTag FALSE = 85422813;
	public const MarkupTag INVALID = 1585415185;
	public const MarkupTag NOTDEF = 612146780;
	public const MarkupTag NORMAL = 3111473395;
	public const MarkupTag DEFAULT = 3673993291;
	public const MarkupTag REGULAR = 1291372090;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TagValueType
{
	// Fields
	public int value__; // 0x10
	public const TagValueType None = 0;
	public const TagValueType NumericalValue = 1;
	public const TagValueType StringValue = 2;
	public const TagValueType ColorValue = 4;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TagUnitType
{
	// Fields
	public int value__; // 0x10
	public const TagUnitType Pixels = 0;
	public const TagUnitType FontUnits = 1;
	public const TagUnitType Percentage = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextProcessingElementType
{
	// Fields
	public int value__; // 0x10
	public const TextProcessingElementType Undefined = 0;
	public const TextProcessingElementType TextCharacterElement = 1;
	public const TextProcessingElementType TextMarkupElement = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal struct FontStyleStack
{
	// Fields
	public Byte bold; // 0x10
	public Byte italic; // 0x11
	public Byte underline; // 0x12
	public Byte strikethrough; // 0x13
	public Byte highlight; // 0x14
	public Byte superscript; // 0x15
	public Byte subscript; // 0x16
	public Byte uppercase; // 0x17
	public Byte lowercase; // 0x18
	public Byte smallcaps; // 0x19

	// Methods

	// RVA: 0x17D99E8
	public void Clear() { }

	// RVA: 0x17D99F4
	public Byte Add(FontStyles style) { }

	// RVA: 0x17D9B08
	public Byte Remove(FontStyles style) { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct TextProcessingStack<T0>
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Methods

	// RVA: 0x35267E8
	public void .ctor(T[] stack) { }

	// RVA: 0x3526518
	public void .ctor(int capacity) { }

	// RVA: 0x3526588
	public void .ctor(int capacity, int rolloverSize) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x26AD93C
	public T get_current() { }

	// RVA: 0x26AD93C
	internal static void SetDefault(UnityEngine.TextCore.Text.TextProcessingStack<T>[] stack, T item) { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x26AD93C
	public void SetDefault(T item) { }

	// RVA: 0x26AD93C
	public void Add(T item) { }

	// RVA: 0x26AD93C
	public T Remove() { }

	// RVA: 0x26AD93C
	public void Push(T item) { }

	// RVA: 0x26AD93C
	public T Pop() { }

	// RVA: 0x26AD93C
	public T Peek() { }

	// RVA: 0x26AD93C
	public T CurrentItem() { }

}

// Namespace: 
private struct FontAssetRef
{
	// Fields
	public int nameHashCode; // 0x10
	public int familyNameHashCode; // 0x14
	public int styleNameHashCode; // 0x18
	public Int64 familyNameAndStyleHashCode; // 0x20
	public readonly FontAsset fontAsset; // 0x28

	// Methods

	// RVA: 0x17DA1B0
	public void .ctor(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset) { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextResourceManager
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextResourceManager.FontAssetRef> s_FontAssetReferences; // 0x0
	private static readonly System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset> s_FontAssetNameReferenceLookup; // 0x8
	private static readonly System.Collections.Generic.Dictionary<System.Int64,UnityEngine.TextCore.Text.FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x10
	private static readonly System.Collections.Generic.List<System.Int32> s_FontAssetRemovalList; // 0x18
	private static readonly int k_RegularStyleHashCode; // 0x20

	// Methods

	// RVA: 0x17D9C40
	internal static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x17DA1D8
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
public static class TextShaderUtilities
{
	// Fields
	public static int ID_MainTex; // 0x0
	public static int ID_FaceTex; // 0x4
	public static int ID_FaceColor; // 0x8
	public static int ID_FaceDilate; // 0xC
	public static int ID_Shininess; // 0x10
	public static int ID_OutlineOffset1; // 0x14
	public static int ID_OutlineOffset2; // 0x18
	public static int ID_OutlineOffset3; // 0x1C
	public static int ID_OutlineMode; // 0x20
	public static int ID_IsoPerimeter; // 0x24
	public static int ID_Softness; // 0x28
	public static int ID_UnderlayColor; // 0x2C
	public static int ID_UnderlayOffsetX; // 0x30
	public static int ID_UnderlayOffsetY; // 0x34
	public static int ID_UnderlayDilate; // 0x38
	public static int ID_UnderlaySoftness; // 0x3C
	public static int ID_UnderlayOffset; // 0x40
	public static int ID_UnderlayIsoPerimeter; // 0x44
	public static int ID_WeightNormal; // 0x48
	public static int ID_WeightBold; // 0x4C
	public static int ID_OutlineTex; // 0x50
	public static int ID_OutlineWidth; // 0x54
	public static int ID_OutlineSoftness; // 0x58
	public static int ID_OutlineColor; // 0x5C
	public static int ID_Outline2Color; // 0x60
	public static int ID_Outline2Width; // 0x64
	public static int ID_Padding; // 0x68
	public static int ID_GradientScale; // 0x6C
	public static int ID_ScaleX; // 0x70
	public static int ID_ScaleY; // 0x74
	public static int ID_PerspectiveFilter; // 0x78
	public static int ID_Sharpness; // 0x7C
	public static int ID_TextureWidth; // 0x80
	public static int ID_TextureHeight; // 0x84
	public static int ID_BevelAmount; // 0x88
	public static int ID_GlowColor; // 0x8C
	public static int ID_GlowOffset; // 0x90
	public static int ID_GlowPower; // 0x94
	public static int ID_GlowOuter; // 0x98
	public static int ID_GlowInner; // 0x9C
	public static int ID_LightAngle; // 0xA0
	public static int ID_EnvMap; // 0xA4
	public static int ID_EnvMatrix; // 0xA8
	public static int ID_EnvMatrixRotation; // 0xAC
	public static int ID_MaskCoord; // 0xB0
	public static int ID_ClipRect; // 0xB4
	public static int ID_MaskSoftnessX; // 0xB8
	public static int ID_MaskSoftnessY; // 0xBC
	public static int ID_VertexOffsetX; // 0xC0
	public static int ID_VertexOffsetY; // 0xC4
	public static int ID_UseClipRect; // 0xC8
	public static int ID_StencilID; // 0xCC
	public static int ID_StencilOp; // 0xD0
	public static int ID_StencilComp; // 0xD4
	public static int ID_StencilReadMask; // 0xD8
	public static int ID_StencilWriteMask; // 0xDC
	public static int ID_ShaderFlags; // 0xE0
	public static int ID_ScaleRatio_A; // 0xE4
	public static int ID_ScaleRatio_B; // 0xE8
	public static int ID_ScaleRatio_C; // 0xEC
	public static string Keyword_Bevel; // 0xF0
	public static string Keyword_Glow; // 0xF8
	public static string Keyword_Underlay; // 0x100
	public static string Keyword_Ratios; // 0x108
	public static string Keyword_MASK_SOFT; // 0x110
	public static string Keyword_MASK_HARD; // 0x118
	public static string Keyword_MASK_TEX; // 0x120
	public static string Keyword_Outline; // 0x128
	public static string ShaderTag_ZTestMode; // 0x130
	public static string ShaderTag_CullMode; // 0x138
	private static float m_clamp; // 0x140
	public static bool isInitialized; // 0x144
	internal static readonly string k_SDFText; // 0x148
	internal static readonly string k_BitmapText; // 0x150
	internal static readonly string k_SpriteText; // 0x158
	private static Shader k_ShaderRef_MobileSDF; // 0x160
	private static Shader k_ShaderRef_MobileBitmap; // 0x168
	private static Shader k_ShaderRef_Sprite; // 0x170

	// Methods

	// RVA: 0x17DA484
	internal static Shader get_ShaderRef_MobileSDF() { }

	// RVA: 0x17DA56C
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x17DA6C0
	internal static Shader get_ShaderRef_Sprite() { }

	// RVA: 0x17DA8A8
	private static void .cctor() { }

	// RVA: 0x17DAB48
	internal static void GetShaderPropertyIDs() { }

}

// Namespace: UnityEngine.TextCore.Text
internal static class TextUtilities
{
	// Methods

	// RVA: 0x17DB638
	internal static Char ToUpperFast(Char c) { }

	// RVA: 0x17DA3AC
	public static int GetHashCodeCaseInSensitive(string s) { }

	// RVA: 0x17DB6BC
	internal static int GetTextFontWeightIndex(TextFontWeight fontWeight) { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class UnicodeLineBreakingRules
{
	// Fields
	private TextAsset m_UnicodeLineBreakingRules; // 0x10
	private TextAsset m_LeadingCharacters; // 0x18
	private TextAsset m_FollowingCharacters; // 0x20
	private bool m_UseModernHangulLineBreakingRules; // 0x28
	private System.Collections.Generic.HashSet<System.UInt32> m_LeadingCharactersLookup; // 0x30
	private System.Collections.Generic.HashSet<System.UInt32> m_FollowingCharactersLookup; // 0x38

	// Methods

	// RVA: 0x17DB738
	internal System.Collections.Generic.HashSet<System.UInt32> get_leadingCharactersLookup() { }

	// RVA: 0x17DBA18
	internal System.Collections.Generic.HashSet<System.UInt32> get_followingCharactersLookup() { }

	// RVA: 0x17DBA58
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x17DB774
	internal void LoadLineBreakingRules() { }

	// RVA: 0x17DBA60
	private static System.Collections.Generic.HashSet<System.UInt32> GetCharacters(TextAsset file) { }

	// RVA: 0x17DBB74
	public void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=4848
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=5724
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=4848 5E4436000B53AC505FD7CB9E80FF70C5BA5B44441C00C6F0B891C673FEE1E7D2; // 0x0
	internal static readonly __StaticArrayInitTypeSize=5724 EC5D648DA3EF6677AD390F11A61371CC7A7A89F9355DDDACC33ADB5AE069596B; // 0x12F0
}


