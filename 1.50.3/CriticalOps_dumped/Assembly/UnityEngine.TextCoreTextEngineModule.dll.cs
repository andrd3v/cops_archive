// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class Character
{
	// Methods

	// RVA: 0x16E06B8
	public void .ctor() { }

	// RVA: 0x16E06FC
	public void .ctor(UInt32 unicode, FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x16E079C
	internal void .ctor(UInt32 unicode, UInt32 glyphIndex) { }

}

// Namespace: UnityEngine.TextCore.Text
internal static class ColorUtilities
{
	// Methods

	// RVA: 0x16E0804
	internal static bool CompareColors(Color32 a, Color32 b) { }

	// RVA: 0x16E0814
	internal static Color32 MultiplyColors(Color32 c1, Color32 c2) { }

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
	public int pointSize; // 0x20
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
	public static System.Func<UnityEngine.TextCore.Text.Character,System.UInt32> <>9__151_0; // 0x8
	public static System.Func<UnityEngine.TextCore.Glyph,System.UInt32> <>9__152_0; // 0x10

	// Methods

	// RVA: 0x16EAD64
	private static void .cctor() { }

	// RVA: 0x16EADD0
	public void .ctor() { }

	// RVA: 0x16EADD8
	internal UInt32 <SortCharacterTable>b__151_0(Character c) { }

	// RVA: 0x16EADF4
	internal UInt32 <SortGlyphTable>b__152_0(Glyph c) { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class FontAsset
{
	// Fields
	internal string m_SourceFontFileGUID; // 0x38
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x40
	private Font m_SourceFontFile; // 0x98
	private string m_SourceFontFilePath; // 0xA0
	private AtlasPopulationMode m_AtlasPopulationMode; // 0xA8
	internal bool InternalDynamicOS; // 0xAC
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
	private bool m_ClearDynamicDataOnBuild; // 0x14D
	internal int m_AtlasWidth; // 0x150
	internal int m_AtlasHeight; // 0x154
	internal int m_AtlasPadding; // 0x158
	internal GlyphRenderMode m_AtlasRenderMode; // 0x15C
	private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_UsedGlyphRects; // 0x160
	private System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> m_FreeGlyphRects; // 0x168
	internal FontFeatureTable m_FontFeatureTable; // 0x170
	internal System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> m_FallbackFontAssetTable; // 0x178
	private FontWeightPair[] m_FontWeightTable; // 0x180
	internal float m_RegularStyleWeight; // 0x188
	internal float m_RegularStyleSpacing; // 0x18C
	internal float m_BoldStyleWeight; // 0x190
	internal float m_BoldStyleSpacing; // 0x194
	internal Byte m_ItalicStyleSlant; // 0x198
	internal Byte m_TabMultiple; // 0x199
	internal bool IsFontAssetLookupTablesDirty; // 0x19A
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x10
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x28
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x30
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x38
	private static ProfilerMarker k_TryAddGlyphMarker; // 0x40
	private static string s_DefaultMaterialSuffix; // 0x48
	private static System.Collections.Generic.HashSet<System.Int32> k_SearchedFontAssetLookup; // 0x50
	private static System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x58
	private static System.Collections.Generic.HashSet<System.Int32> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x60
	private static System.Collections.Generic.List<UnityEngine.Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x68
	private static System.Collections.Generic.HashSet<System.Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x70
	private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsToRender; // 0x1A0
	private System.Collections.Generic.List<UnityEngine.TextCore.Glyph> m_GlyphsRendered; // 0x1A8
	private System.Collections.Generic.List<System.UInt32> m_GlyphIndexList; // 0x1B0
	private System.Collections.Generic.List<System.UInt32> m_GlyphIndexListNewlyAdded; // 0x1B8
	internal System.Collections.Generic.List<System.UInt32> m_GlyphsToAdd; // 0x1C0
	internal System.Collections.Generic.HashSet<System.UInt32> m_GlyphsToAddLookup; // 0x1C8
	internal System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> m_CharactersToAdd; // 0x1D0
	internal System.Collections.Generic.HashSet<System.UInt32> m_CharactersToAddLookup; // 0x1D8
	internal System.Collections.Generic.List<System.UInt32> s_MissingCharacterList; // 0x1E0
	internal System.Collections.Generic.HashSet<System.UInt32> m_MissingUnicodesFromFontFile; // 0x1E8
	internal static UInt32[] k_GlyphIndexArray; // 0x78

	// Methods

	// RVA: 0x16E08F8
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	// RVA: 0x16E091C
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	// RVA: 0x16E094C
	public Font get_sourceFontFile() { }

	// RVA: 0x16E0954
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x16E095C
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x16E0964
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x16E096C
	public FaceInfo get_faceInfo() { }

	// RVA: 0x16E0988
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x16E09B8
	internal int get_familyNameHashCode() { }

	// RVA: 0x16E0A00
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x16E0A08
	internal int get_styleNameHashCode() { }

	// RVA: 0x16E0A50
	internal void set_styleNameHashCode(int value) { }

	// RVA: 0x16E0A58
	public System.Collections.Generic.List<UnityEngine.TextCore.Glyph> get_glyphTable() { }

	// RVA: 0x16E0A60
	internal void set_glyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Glyph> value) { }

	// RVA: 0x16E0A70
	public System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Glyph> get_glyphLookupTable() { }

	// RVA: 0x16E0EFC
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> get_characterTable() { }

	// RVA: 0x16E0F04
	internal void set_characterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.Character> value) { }

	// RVA: 0x16E0F14
	public System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.Character> get_characterLookupTable() { }

	// RVA: 0x16E0F50
	public Texture2D get_atlasTexture() { }

	// RVA: 0x16E1030
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x16E1038
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x16E1048
	public int get_atlasTextureCount() { }

	// RVA: 0x16E1054
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x16E105C
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x16E1064
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x16E106C
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x16E1074
	public int get_atlasWidth() { }

	// RVA: 0x16E107C
	internal void set_atlasWidth(int value) { }

	// RVA: 0x16E1084
	public int get_atlasHeight() { }

	// RVA: 0x16E108C
	internal void set_atlasHeight(int value) { }

	// RVA: 0x16E1094
	public int get_atlasPadding() { }

	// RVA: 0x16E109C
	internal void set_atlasPadding(int value) { }

	// RVA: 0x16E10A4
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x16E10AC
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x16E10B4
	internal System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x16E10BC
	internal void set_usedGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value) { }

	// RVA: 0x16E10CC
	internal System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x16E10D4
	internal void set_freeGlyphRects(System.Collections.Generic.List<UnityEngine.TextCore.GlyphRect> value) { }

	// RVA: 0x16E10E4
	public FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x16E10EC
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	// RVA: 0x16E10FC
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x16E1104
	public void set_fallbackFontAssetTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value) { }

	// RVA: 0x16E1114
	public FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x16E111C
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	// RVA: 0x16E112C
	public float get_regularStyleWeight() { }

	// RVA: 0x16E1134
	public void set_regularStyleWeight(float value) { }

	// RVA: 0x16E113C
	public float get_regularStyleSpacing() { }

	// RVA: 0x16E1144
	public void set_regularStyleSpacing(float value) { }

	// RVA: 0x16E114C
	public float get_boldStyleWeight() { }

	// RVA: 0x16E1154
	public void set_boldStyleWeight(float value) { }

	// RVA: 0x16E115C
	public float get_boldStyleSpacing() { }

	// RVA: 0x16E1164
	public void set_boldStyleSpacing(float value) { }

	// RVA: 0x16E116C
	public Byte get_italicStyleSlant() { }

	// RVA: 0x16E1174
	public void set_italicStyleSlant(Byte value) { }

	// RVA: 0x16E117C
	public Byte get_tabMultiple() { }

	// RVA: 0x16E1184
	public void set_tabMultiple(Byte value) { }

	// RVA: 0x16E118C
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize) { }

	// RVA: 0x16E15AC
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x16E1404
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x16E1B1C
	public static FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x16E1C04
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x16E1CC4
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x16E166C
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x16E1F24
	private void Awake() { }

	// RVA: 0x16E1F28
	private void OnDestroy() { }

	// RVA: 0x16E0AAC
	public void ReadFontAssetDefinition() { }

	// RVA: 0x16E20A4
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x16E2320
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x16E2674
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x16E286C
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x16E2B44
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x16E2D9C
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x16E2F98
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x16E20E8
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x16E334C
	private void AddSynthesizedCharacter(UInt32 unicode, bool isFontFaceLoaded, bool addImmediately) { }

	// RVA: 0x16E3638
	internal void AddCharacterToLookupCache(UInt32 unicode, Character character) { }

	// RVA: 0x16E319C
	private FontEngineError LoadFontFace() { }

	// RVA: 0x16E36B4
	internal void SortCharacterTable() { }

	// RVA: 0x16E3830
	internal void SortGlyphTable() { }

	// RVA: 0x16E39AC
	internal void SortFontFeatureTable() { }

	// RVA: 0x16E4094
	internal void SortAllTables() { }

	// RVA: 0x16E40E0
	public bool HasCharacter(int character) { }

	// RVA: 0x16E4150
	public bool HasCharacter(Char character, bool searchFallbacks, bool tryAddCharacter) { }

	// RVA: 0x16E4154
	public bool HasCharacter(UInt32 character, bool searchFallbacks, bool tryAddCharacter) { }

	// RVA: 0x16E4E2C
	private bool HasCharacter_Internal(UInt32 character, bool searchFallbacks, bool tryAddCharacter) { }

	// RVA: 0x16E506C
	public bool HasCharacters(string text, System.Collections.Generic.List<System.Char>& missingCharacters) { }

	// RVA: 0x16E5204
	public bool HasCharacters(string text, UInt32[] missingCharacters, bool searchFallbacks, bool tryAddCharacter) { }

	// RVA: 0x16E57B8
	public bool HasCharacters(string text) { }

	// RVA: 0x16E58B0
	public static string GetCharacters(FontAsset fontAsset) { }

	// RVA: 0x16E59D8
	public static int[] GetCharactersArray(FontAsset fontAsset) { }

	// RVA: 0x16E5AF8
	internal UInt32 GetGlyphIndex(UInt32 unicode) { }

	// RVA: 0x16E5C14
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	// RVA: 0x16E5D70
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x16E5FD4
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x16E60C8
	internal static void UpdateAtlasTexturesInQueue() { }

	// RVA: 0x16E6290
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x16E6300
	public bool TryAddCharacters(UInt32[] unicodes, bool includeFontFeatures) { }

	// RVA: 0x16E6328
	public bool TryAddCharacters(UInt32[] unicodes, UInt32[] missingUnicodes, bool includeFontFeatures) { }

	// RVA: 0x16E7318
	public bool TryAddCharacters(string characters, bool includeFontFeatures) { }

	// RVA: 0x16E7340
	public bool TryAddCharacters(string characters, string missingCharacters, bool includeFontFeatures) { }

	// RVA: 0x16E7F40
	internal bool TryAddGlyphInternal(UInt32 glyphIndex, Glyph glyph) { }

	// RVA: 0x16E44B0
	internal bool TryAddCharacterInternal(UInt32 unicode, Character character, bool shouldGetFontFeatures) { }

	// RVA: 0x16E8AB4
	internal bool TryGetCharacter_and_QueueRenderToTexture(UInt32 unicode, Character character, bool shouldGetFontFeatures) { }

	// RVA: 0x16E8FC8
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x16E6F70
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x16E8838
	private void SetupNewAtlasTexture() { }

	// RVA: 0x16E5F2C
	private void UpdateAllFontFeatures() { }

	// RVA: 0x16E8FCC
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x16E9758
	internal void UpdateGlyphAdjustmentRecords(UInt32[] glyphIndexes) { }

	// RVA: 0x16E9BB0
	internal void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> glyphIndexes) { }

	// RVA: 0x16E9BB4
	internal void UpdateGlyphAdjustmentRecords(System.Collections.Generic.List<System.UInt32> newGlyphIndexes, System.Collections.Generic.List<System.UInt32> allGlyphIndexes) { }

	// RVA: 0x30D4F34
	private void CopyListDataToArray(System.Collections.Generic.List<T> srcList, T[] dstArray) { }

	// RVA: 0x16E9BB8
	public void ClearFontAssetData(bool setAtlasSizeToZero) { }

	// RVA: 0x16EA410
	internal void ClearFontAssetDataInternal(bool clearFontFeatures) { }

	// RVA: 0x16EA438
	internal void UpdateFontAssetData() { }

	// RVA: 0x16E9D04
	internal void ClearFontAssetTables(bool clearFontFeatures) { }

	// RVA: 0x16EA1F0
	internal void ClearAtlasTextures(bool setAtlasSizeToZero) { }

	// RVA: 0x16E1FC8
	private void DestroyAtlasTextures() { }

	// RVA: 0x16EA6A8
	public void .ctor() { }

	// RVA: 0x16EA9D4
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal static class FontAssetUtilities
{
	// Fields
	private static System.Collections.Generic.HashSet<System.Int32> k_SearchedAssets; // 0x0

	// Methods

	// RVA: 0x16EAE10
	internal static Character GetCharacterFromFontAsset(UInt32 unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, bool isAlternativeTypeface) { }

	// RVA: 0x16EAF24
	private static Character GetCharacterFromFontAsset_Internal(UInt32 unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, bool isAlternativeTypeface) { }

	// RVA: 0x16EB430
	public static Character GetCharacterFromFontAssets(UInt32 unicode, FontAsset sourceFontAsset, System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, bool isAlternativeTypeface) { }

	// RVA: 0x16EB61C
	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(UInt32 unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x16EB954
	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(UInt32 unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.TextCore.Text.FontFeatureTable.<>c <>9; // 0x0
	public static System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord,System.UInt32> <>9__25_0; // 0x8
	public static System.Func<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord,System.UInt32> <>9__25_1; // 0x10
	public static System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord,System.UInt32> <>9__26_0; // 0x18
	public static System.Func<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord,System.UInt32> <>9__26_1; // 0x20
	public static System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord,System.UInt32> <>9__27_0; // 0x28
	public static System.Func<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord,System.UInt32> <>9__27_1; // 0x30

	// Methods

	// RVA: 0x16EBB4C
	private static void .cctor() { }

	// RVA: 0x16EBBB8
	public void .ctor() { }

	// RVA: 0x16EBBC0
	internal UInt32 <SortGlyphPairAdjustmentRecords>b__25_0(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x16EBC04
	internal UInt32 <SortGlyphPairAdjustmentRecords>b__25_1(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x16EBC48
	internal UInt32 <SortMarkToBaseAdjustmentRecords>b__26_0(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x16EBC54
	internal UInt32 <SortMarkToBaseAdjustmentRecords>b__26_1(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x16EBC60
	internal UInt32 <SortMarkToMarkAdjustmentRecords>b__27_0(MarkToMarkAdjustmentRecord s) { }

	// RVA: 0x16EBC6C
	internal UInt32 <SortMarkToMarkAdjustmentRecords>b__27_1(MarkToMarkAdjustmentRecord s) { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class FontFeatureTable
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; // 0x10
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; // 0x18
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x20
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; // 0x28
	internal System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; // 0x30
	internal System.Collections.Generic.Dictionary<System.UInt32,System.Collections.Generic.List<UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; // 0x38
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x40
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; // 0x48
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; // 0x50

	// Methods

	// RVA: 0x16E94A0
	internal void .ctor() { }

	// RVA: 0x16E39EC
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x16E3C24
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x16E3E5C
	public void SortMarkToMarkAdjustmentRecords() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct Extents
{
	// Fields
	public Vector2 min; // 0x10
	public Vector2 max; // 0x18

	// Methods

	// RVA: 0x16EBC78
	public override string ToString() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct LineInfo
{
	// Fields
	internal int controlCharacterCount; // 0x10
	public int characterCount; // 0x14
	public int visibleCharacterCount; // 0x18
	public int spaceCount; // 0x1C
	public int visibleSpaceCount; // 0x20
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

	// RVA: 0x16EBEAC
	internal void SetLinkId(Char[] text, int startIndex, int length) { }

	// RVA: 0x16EBFD0
	public string GetLinkText(TextInfo textInfo) { }

	// RVA: 0x16EC0E8
	public string GetLinkId() { }

}

// Namespace: UnityEngine.TextCore.Text
internal static class MaterialManager
{
	// Fields
	private static System.Collections.Generic.Dictionary<System.Int64,UnityEngine.Material> s_FallbackMaterials; // 0x0

	// Methods

	// RVA: 0x16EC144
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x16EC7E4
	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x16EC544
	private static void CopyMaterialPresetProperties(Material source, Material destination) { }

	// RVA: 0x16ECA10
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
	public bool isDefaultMaterial; // 0x30
	public bool isFallbackMaterial; // 0x31
	public Material fallbackMaterial; // 0x38
	public float padding; // 0x40
	public int referenceCount; // 0x44

	// Methods

	// RVA: 0x16ECAAC
	public void .ctor(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x16ECB6C
	public static int AddMaterialReference(Material material, FontAsset fontAsset, MaterialReference[] materialReferences, System.Collections.Generic.Dictionary<System.Int32,System.Int32> materialReferenceIndexLookup) { }

	// RVA: 0x16ECDB4
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

	// RVA: 0x16ECFC4
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x16ED1F4
	public static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x16ED294
	private void AddFontAssetInternal(FontAsset fontAsset) { }

	// RVA: 0x16ED4D0
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x16ED578
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x16ED658
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x16ED740
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x16ED7BC
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x16ED864
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x16ED910
	public static bool TryGetFontAsset(int hashCode, FontAsset fontAsset) { }

	// RVA: 0x16EDA08
	private bool TryGetFontAssetInternal(int hashCode, FontAsset fontAsset) { }

	// RVA: 0x16EDA94
	public static bool TryGetSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x16EDB8C
	private bool TryGetSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x16EDC18
	public static bool TryGetColorGradientPreset(int hashCode, TextColorGradient gradientPreset) { }

	// RVA: 0x16EDD10
	private bool TryGetColorGradientPresetInternal(int hashCode, TextColorGradient gradientPreset) { }

	// RVA: 0x16EDD9C
	public static bool TryGetMaterial(int hashCode, Material material) { }

	// RVA: 0x16EDE94
	private bool TryGetMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x16ED06C
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal enum VertexSortingOrder
{
	// Fields
	public int value__; // 0x10
	public const VertexSortingOrder Normal = 0;
	public const VertexSortingOrder Reverse = 1;
}

// Namespace: UnityEngine.TextCore.Text
internal struct MeshInfo
{
	// Fields
	private static readonly Color32 k_DefaultColor; // 0x0
	private static readonly Vector3 k_DefaultNormal; // 0x4
	private static readonly Vector4 k_DefaultTangent; // 0x10
	public int vertexCount; // 0x10
	public Vector3[] vertices; // 0x18
	public Vector3[] normals; // 0x20
	public Vector4[] tangents; // 0x28
	public Vector4[] uvs0; // 0x30
	public Vector2[] uvs2; // 0x38
	public Color32[] colors32; // 0x40
	public int[] triangles; // 0x48
	public Material material; // 0x50
	internal GlyphRenderMode glyphRenderMode; // 0x58

	// Methods

	// RVA: 0x16EDF20
	public void .ctor(int size) { }

	// RVA: 0x16EE3C8
	internal void ResizeMeshInfo(int size) { }

	// RVA: 0x16EE5CC
	internal void Clear(bool uploadChanges) { }

	// RVA: 0x16EE604
	internal void ClearUnusedVertices() { }

	// RVA: 0x16EE644
	internal void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x16EE70C
	internal void SwapVertexData(int src, int dst) { }

	// RVA: 0x16EEB10
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.TextCore.Text.SpriteAsset.<>c <>9; // 0x0
	public static System.Func<UnityEngine.TextCore.Text.SpriteGlyph,System.UInt32> <>9__37_0; // 0x8
	public static System.Func<UnityEngine.TextCore.Text.SpriteCharacter,System.UInt32> <>9__38_0; // 0x10

	// Methods

	// RVA: 0x16F047C
	private static void .cctor() { }

	// RVA: 0x16F04E8
	public void .ctor() { }

	// RVA: 0x16F04F0
	internal UInt32 <SortGlyphTable>b__37_0(SpriteGlyph item) { }

	// RVA: 0x16F050C
	internal UInt32 <SortCharacterTable>b__38_0(SpriteCharacter c) { }

}

// Namespace: UnityEngine.TextCore.Text
public class SpriteAsset
{
	// Fields
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_NameLookup; // 0x38
	internal System.Collections.Generic.Dictionary<System.UInt32,System.Int32> m_GlyphIndexLookup; // 0x40
	internal FaceInfo m_FaceInfo; // 0x48
	internal Texture m_SpriteAtlasTexture; // 0xA8
	private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterTable; // 0xB0
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
	private System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphTable; // 0xC0
	internal System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> fallbackSpriteAssets; // 0xD0
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xD8
	private static System.Collections.Generic.HashSet<System.Int32> k_searchedSpriteAssets; // 0x0

	// Methods

	// RVA: 0x16EEB80
	public FaceInfo get_faceInfo() { }

	// RVA: 0x16EEBA8
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x16EEBD8
	public Texture get_spriteSheet() { }

	// RVA: 0x16EEBE0
	internal void set_spriteSheet(Texture value) { }

	// RVA: 0x16EEBE8
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x16EF1B0
	internal void set_spriteCharacterTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteCharacter> value) { }

	// RVA: 0x16EB918
	public System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x16EF1B8
	internal void set_spriteCharacterLookupTable(System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.TextCore.Text.SpriteCharacter> value) { }

	// RVA: 0x16EF1C0
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x16EF1C8
	internal void set_spriteGlyphTable(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteGlyph> value) { }

	// RVA: 0x16EF1D0
	private void Awake() { }

	// RVA: 0x16EEC28
	public void UpdateLookupTables() { }

	// RVA: 0x16EF1DC
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x16EF274
	public int GetSpriteIndexFromUnicode(UInt32 unicode) { }

	// RVA: 0x16EF328
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x16EF3E0
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, UInt32 unicode, bool includeFallbacks, int spriteIndex) { }

	// RVA: 0x16EF658
	private static SpriteAsset SearchForSpriteByUnicodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, UInt32 unicode, bool includeFallbacks, int spriteIndex) { }

	// RVA: 0x16EF820
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, UInt32 unicode, bool includeFallbacks, int spriteIndex) { }

	// RVA: 0x16EF94C
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, int spriteIndex, TextSettings textSettings) { }

	// RVA: 0x16EFDA4
	private static SpriteAsset SearchForSpriteByHashCodeInternal(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, int spriteIndex) { }

	// RVA: 0x16EFF78
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, int spriteIndex) { }

	// RVA: 0x16F0090
	public void SortGlyphTable() { }

	// RVA: 0x16F0200
	internal void SortCharacterTable() { }

	// RVA: 0x16F0374
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x16F0398
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteCharacter
{
	// Fields
	private string m_Name; // 0x30

	// Methods

	// RVA: 0x16EF1D4
	public string get_name() { }

	// RVA: 0x16F0528
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteGlyph
{
	// Fields
	public Sprite sprite; // 0x48

	// Methods

	// RVA: 0x16F0554
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

	// RVA: 0x16F055C
	public string get_version() { }

	// RVA: 0x16F0564
	internal void set_version(string value) { }

	// RVA: 0x16E5D30
	public int get_instanceID() { }

	// RVA: 0x16ED3C4
	public int get_hashCode() { }

	// RVA: 0x16F056C
	public void set_hashCode(int value) { }

	// RVA: 0x16F0574
	public Material get_material() { }

	// RVA: 0x16F057C
	public void set_material(Material value) { }

	// RVA: 0x16ED40C
	public int get_materialHashCode() { }

	// RVA: 0x16F0584
	public void set_materialHashCode(int value) { }

	// RVA: 0x16EA9CC
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

	// RVA: 0x16F058C
	public void .ctor() { }

	// RVA: 0x16F0634
	public void .ctor(Color color) { }

	// RVA: 0x16F06A4
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x16F074C
	private static void .cctor() { }

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

	// RVA: 0x16F079C
	public TextElementType get_elementType() { }

	// RVA: 0x16E3194
	public UInt32 get_unicode() { }

	// RVA: 0x16E077C
	public void set_unicode(UInt32 value) { }

	// RVA: 0x16EB428
	public TextAsset get_textAsset() { }

	// RVA: 0x16E0784
	public void set_textAsset(TextAsset value) { }

	// RVA: 0x16F07A4
	public Glyph get_glyph() { }

	// RVA: 0x16E078C
	public void set_glyph(Glyph value) { }

	// RVA: 0x16E2318
	public UInt32 get_glyphIndex() { }

	// RVA: 0x16E0794
	public void set_glyphIndex(UInt32 value) { }

	// RVA: 0x16F07AC
	public float get_scale() { }

	// RVA: 0x16E06F4
	public void set_scale(float value) { }

	// RVA: 0x16E06EC
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
	public Char character; // 0x10
	public int index; // 0x14
	public TextElementType elementType; // 0x18
	public int stringLength; // 0x1C
	public TextElement textElement; // 0x20
	public Glyph alternativeGlyph; // 0x28
	public FontAsset fontAsset; // 0x30
	public SpriteAsset spriteAsset; // 0x38
	public int spriteIndex; // 0x40
	public Material material; // 0x48
	public int materialReferenceIndex; // 0x50
	public bool isUsingAlternateTypeface; // 0x54
	public float pointSize; // 0x58
	public int lineNumber; // 0x5C
	public int pageNumber; // 0x60
	public int vertexIndex; // 0x64
	public TextVertex vertexTopLeft; // 0x68
	public TextVertex vertexBottomLeft; // 0x90
	public TextVertex vertexTopRight; // 0xB8
	public TextVertex vertexBottomRight; // 0xE0
	public Vector3 topLeft; // 0x108
	public Vector3 bottomLeft; // 0x114
	public Vector3 topRight; // 0x120
	public Vector3 bottomRight; // 0x12C
	public float origin; // 0x138
	public float ascender; // 0x13C
	public float baseLine; // 0x140
	public float descender; // 0x144
	internal float adjustedAscender; // 0x148
	internal float adjustedDescender; // 0x14C
	internal float adjustedHorizontalAdvance; // 0x150
	public float xAdvance; // 0x154
	public float aspectRatio; // 0x158
	public float scale; // 0x15C
	public Color32 color; // 0x160
	public Color32 underlineColor; // 0x164
	public int underlineVertexIndex; // 0x168
	public Color32 strikethroughColor; // 0x16C
	public int strikethroughVertexIndex; // 0x170
	public Color32 highlightColor; // 0x174
	public HighlightState highlightState; // 0x178
	public FontStyles style; // 0x18C
	public bool isVisible; // 0x190

	// Methods

	// RVA: 0x16F07B4
	public override string ToString() { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextGenerationSettings
{
	// Fields
	public string text; // 0x10
	public Rect screenRect; // 0x18
	public Vector4 margins; // 0x28
	public float scale; // 0x38
	public FontAsset fontAsset; // 0x40
	public Material material; // 0x48
	public SpriteAsset spriteAsset; // 0x50
	public TextStyleSheet styleSheet; // 0x58
	public FontStyles fontStyle; // 0x60
	public TextSettings textSettings; // 0x68
	public TextAlignment textAlignment; // 0x70
	public TextOverflowMode overflowMode; // 0x74
	public bool wordWrap; // 0x78
	public float wordWrappingRatio; // 0x7C
	public Color color; // 0x80
	public TextColorGradient fontColorGradient; // 0x90
	public TextColorGradient fontColorGradientPreset; // 0x98
	public bool tintSprites; // 0xA0
	public bool overrideRichTextColors; // 0xA1
	public bool shouldConvertToLinearSpace; // 0xA2
	public float fontSize; // 0xA4
	public bool autoSize; // 0xA8
	public float fontSizeMin; // 0xAC
	public float fontSizeMax; // 0xB0
	public bool enableKerning; // 0xB4
	public bool richText; // 0xB5
	public bool isRightToLeft; // 0xB6
	public float extraPadding; // 0xB8
	public bool parseControlCharacters; // 0xBC
	public bool isOrthographic; // 0xBD
	public bool tagNoParsing; // 0xBE
	public float characterSpacing; // 0xC0
	public float wordSpacing; // 0xC4
	public float lineSpacing; // 0xC8
	public float paragraphSpacing; // 0xCC
	public float lineSpacingMax; // 0xD0
	public TextWrappingMode textWrappingMode; // 0xD4
	public int maxVisibleCharacters; // 0xD8
	public int maxVisibleWords; // 0xDC
	public int maxVisibleLines; // 0xE0
	public int firstVisibleCharacter; // 0xE4
	public bool useMaxVisibleDescender; // 0xE8
	public TextFontWeight fontWeight; // 0xEC
	public int pageToDisplay; // 0xF0
	public TextureMapping horizontalMapping; // 0xF4
	public TextureMapping verticalMapping; // 0xF8
	public float uvLineOffset; // 0xFC
	public VertexSortingOrder geometrySortingOrder; // 0x100
	public bool inverseYAxis; // 0x104
	public float charWidthMaxAdj; // 0x108
	internal TextInputSource inputSource; // 0x10C

	// Methods

	// RVA: 0x16F2208
	public bool Equals(TextGenerationSettings other) { }

	// RVA: 0x16F2738
	public override bool Equals(object obj) { }

	// RVA: 0x16F2864
	public override int GetHashCode() { }

	// RVA: 0x16F2E8C
	public static bool op_Equality(TextGenerationSettings left, TextGenerationSettings right) { }

	// RVA: 0x16F2E94
	public override string ToString() { }

	// RVA: 0x16F4D40
	public void .ctor() { }

}

// Namespace: 
public sealed class MissingCharacterEventCallback
{
	// Methods

	// RVA: 0x170AE94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x170AF38
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

	// RVA: 0x170AF4C
	public void .ctor(Character character, int materialIndex) { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextGenerator
{
	// Fields
	private static TextGenerator s_TextGenerator; // 0x0
	private TextBackingContainer m_TextBackingArray; // 0x10
	internal TextProcessingElement[] m_TextProcessingArray; // 0x20
	internal int m_InternalTextProcessingArraySize; // 0x28
	protected bool m_VertexBufferAutoSizeReduction; // 0x2C
	private Char[] m_HtmlTag; // 0x30
	internal HighlightState m_HighlightState; // 0x38
	protected bool m_IsIgnoringAlignment; // 0x4C
	protected static bool m_IsTextTruncated; // 0x8
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
	private float m_XAdvance; // 0x2F4
	private float m_TagLineIndent; // 0x2F8
	private float m_TagIndent; // 0x2FC
	private UnityEngine.TextCore.Text.TextProcessingStack<System.Single> m_IndentStack; // 0x300
	private bool m_TagNoParsing; // 0x320
	private int m_CharacterCount; // 0x324
	private int m_FirstCharacterOfLine; // 0x328
	private int m_LastCharacterOfLine; // 0x32C
	private int m_FirstVisibleCharacterOfLine; // 0x330
	private int m_LastVisibleCharacterOfLine; // 0x334
	private float m_MaxLineAscender; // 0x338
	private float m_MaxLineDescender; // 0x33C
	private int m_LineNumber; // 0x340
	private int m_LineVisibleCharacterCount; // 0x344
	private int m_LineVisibleSpaceCount; // 0x348
	private int m_FirstOverflowCharacterIndex; // 0x34C
	private int m_PageNumber; // 0x350
	private float m_MarginLeft; // 0x354
	private float m_MarginRight; // 0x358
	private float m_Width; // 0x35C
	private Extents m_MeshExtents; // 0x360
	private float m_MaxCapHeight; // 0x370
	private float m_MaxAscender; // 0x374
	private float m_MaxDescender; // 0x378
	private bool m_IsNewPage; // 0x37C
	private bool m_IsNonBreakingSpace; // 0x37D
	private WordWrapState m_SavedWordWrapState; // 0x380
	private WordWrapState m_SavedLineState; // 0x718
	private WordWrapState m_SavedEllipsisState; // 0xAB0
	private WordWrapState m_SavedLastValidState; // 0xE48
	private WordWrapState m_SavedSoftLineBreakState; // 0x11E0
	private TextElementType m_TextElementType; // 0x1578
	private bool m_isTextLayoutPhase; // 0x1579
	private int m_SpriteIndex; // 0x157C
	private Color32 m_SpriteColor; // 0x1580
	private TextElement m_CachedTextElement; // 0x1588
	private Color32 m_HighlightColor; // 0x1590
	private float m_CharWidthAdjDelta; // 0x1594
	private float m_MaxFontSize; // 0x1598
	private float m_MinFontSize; // 0x159C
	private int m_AutoSizeIterationCount; // 0x15A0
	private int m_AutoSizeMaxIterationCount; // 0x15A4
	private bool m_IsAutoSizePointSizeSet; // 0x15A8
	private float m_StartOfLineAscender; // 0x15AC
	private float m_LineSpacingDelta; // 0x15B0
	private MaterialReference[] m_MaterialReferences; // 0x15B8
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
	private SpriteAsset m_DefaultSpriteAsset; // 0x19F0
	private bool m_TintSprite; // 0x19F8
	protected SpecialCharacter m_Ellipsis; // 0x1A00
	protected SpecialCharacter m_Underline; // 0x1A20
	private TextElementInfo[] m_InternalTextElementInfo; // 0x1A40

	// Methods

	// RVA: 0x16FC6A4
	private static TextGenerator GetTextGenerator() { }

	// RVA: 0x16FCEE8
	public static void GenerateText(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x16FD378
	public static Vector2 GetPreferredValues(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x16FD6FC
	public static bool get_isTextTruncated() { }

	// RVA: 0x16FD17C
	private void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x16F4DBC
	private void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x16FFC8C
	private void SaveWordWrappingState(WordWrapState state, int index, int count, TextInfo textInfo) { }

	// RVA: 0x16FFFF8
	protected int RestoreWordWrappingState(WordWrapState state, TextInfo textInfo) { }

	// RVA: 0x170034C
	protected bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1704D20
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17058B8
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x17060A0
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1706F38
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x170748C
	private static void ClearMesh(bool updateMesh, TextInfo textInfo) { }

	// RVA: 0x16FE538
	internal int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1707668
	internal TextElement GetTextElement(TextGenerationSettings generationSettings, UInt32 unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, bool isUsingAlternativeTypeface) { }

	// RVA: 0x16FD774
	private void ComputeMarginSize(Rect rect, Vector4 margins) { }

	// RVA: 0x16FD748
	protected void GetSpecialCharacters(TextGenerationSettings generationSettings) { }

	// RVA: 0x17074B0
	protected void GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x1706E98
	protected void GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x16FD5A0
	private Vector2 GetPreferredValuesInternal(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1707A24
	protected virtual Vector2 CalculatePreferredValues(float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingMode textWrapMode, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x16FD7E0
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x170A8A0
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x16FD7FC
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings) { }

	// RVA: 0x170A9C0
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, bool isMaxVisibleDescenderSet, float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1707984
	protected void DoMissingGlyphCallback(UInt32 unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo) { }

	// RVA: 0x1704C18
	private void ClearMarkupTagAttributes() { }

	// RVA: 0x16FC74C
	public void .ctor() { }

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
	public const TextOverflowMode Page = 5;
	public const TextOverflowMode Linked = 6;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextureMapping
{
	// Fields
	public int value__; // 0x10
	public const TextureMapping Character = 0;
	public const TextureMapping Line = 1;
	public const TextureMapping Paragraph = 2;
	public const TextureMapping MatchAspect = 3;
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

// Namespace: UnityEngine.TextCore.Text
internal enum TextInputSource
{
	// Fields
	public int value__; // 0x10
	public const TextInputSource TextInputBox = 0;
	public const TextInputSource SetText = 1;
	public const TextInputSource SetTextArray = 2;
	public const TextInputSource TextString = 3;
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

	// RVA: 0x170B108
	public int get_Capacity() { }

	// RVA: 0x170B128
	public int get_Count() { }

	// RVA: 0x170B130
	public void set_Count(int value) { }

	// RVA: 0x170B138
	public UInt32 get_Item(int index) { }

	// RVA: 0x170B16C
	public void set_Item(int index, UInt32 value) { }

	// RVA: 0x170B284
	public void .ctor(int size) { }

	// RVA: 0x170B21C
	public void Resize(int size) { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct CharacterSubstitution
{
	// Fields
	public int index; // 0x10
	public UInt32 unicode; // 0x14

	// Methods

	// RVA: 0x170B2F4
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

	// RVA: 0x170B2FC
	public float get_left() { }

	// RVA: 0x170B304
	public float get_right() { }

	// RVA: 0x170B30C
	public float get_top() { }

	// RVA: 0x170B314
	public float get_bottom() { }

	// RVA: 0x170B31C
	public static Offset get_zero() { }

	// RVA: 0x170B3A0
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x170B3AC
	public static bool op_Equality(Offset lhs, Offset rhs) { }

	// RVA: 0x170B3D4
	public static Offset op_Multiply(Offset a, float b) { }

	// RVA: 0x170B3E8
	public override int GetHashCode() { }

	// RVA: 0x170B458
	public override bool Equals(object obj) { }

	// RVA: 0x170B4D0
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct HighlightState
{
	// Fields
	public Color32 color; // 0x10
	public Offset padding; // 0x14

	// Methods

	// RVA: 0x170B51C
	public void .ctor(Color32 color, Offset padding) { }

	// RVA: 0x170B52C
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x170B628
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x170B710
	public override int GetHashCode() { }

	// RVA: 0x170B788
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

	// Methods

	// RVA: 0x170B808
	public static bool Approximately(float a, float b) { }

	// RVA: 0x170B83C
	public static Color32 HexCharsToColor(Char[] hexChars, int tagCount) { }

	// RVA: 0x170BE60
	public static Color32 HexCharsToColor(Char[] hexChars, int startIndex, int length) { }

	// RVA: 0x170BE38
	public static UInt32 HexToInt(Char hex) { }

	// RVA: 0x170C0EC
	public static float ConvertToFloat(Char[] chars, int startIndex, int length) { }

	// RVA: 0x170C174
	public static float ConvertToFloat(Char[] chars, int startIndex, int length, int lastIndex) { }

	// RVA: 0x170C2F4
	public static Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x30DA164
	public static void ResizeInternalArray(T[] array) { }

	// RVA: 0x30DA46C
	public static void ResizeInternalArray(T[] array, int size) { }

	// RVA: 0x170C350
	internal static void InsertOpeningTextStyle(TextStyle style, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x170C9C8
	internal static void InsertClosingTextStyle(TextStyle style, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x170CAE4
	public static bool ReplaceOpeningStyleTag(TextBackingContainer sourceText, int srcIndex, int srcOffset, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x170CF44
	private static bool ReplaceOpeningStyleTag(UInt32[] sourceText, int srcIndex, int srcOffset, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x170D1EC
	public static void ReplaceClosingStyleTag(TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x170D320
	internal static void InsertOpeningStyleTag(TextStyle style, TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x170D414
	internal static void InsertClosingStyleTag(TextProcessingElement[] charBuffer, int writeIndex, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x170C474
	private static void InsertTextStyleInTextProcessingArray(TextProcessingElement[] charBuffer, int writeIndex, UInt32[] styleDefinition, int textStyleStackDepth, UnityEngine.TextCore.Text.TextProcessingStack<System.Int32>[]& textStyleStacks, TextGenerationSettings generationSettings) { }

	// RVA: 0x170CD8C
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	// RVA: 0x170D0AC
	public static int GetStyleHashCode(UInt32[] text, int index, int closeIndex) { }

	// RVA: 0x170CC4C
	public static int GetStyleHashCode(TextBackingContainer text, int index, int closeIndex) { }

	// RVA: 0x170D50C
	public static UInt32 GetUTF16(UInt32[] text, int i) { }

	// RVA: 0x170DA0C
	public static UInt32 GetUTF16(TextBackingContainer text, int i) { }

	// RVA: 0x170D604
	public static UInt32 GetUTF32(UInt32[] text, int i) { }

	// RVA: 0x170DB04
	public static UInt32 GetUTF32(TextBackingContainer text, int i) { }

	// RVA: 0x170DC8C
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x170E600
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x170EC30
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	// RVA: 0x170ED20
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	// RVA: 0x170EED4
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	// RVA: 0x170EEE4
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	// RVA: 0x170EF08
	public static UInt32 ConvertToUTF32(UInt32 highSurrogate, UInt32 lowSurrogate) { }

	// RVA: 0x170EF1C
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x170D78C
	public static int GetMarkupTagHashCode(UInt32[] styleDefinition, int readIndex) { }

	// RVA: 0x170D988
	public static Char ToUpperASCIIFast(Char c) { }

	// RVA: 0x170F080
	public static UInt32 ToUpperASCIIFast(UInt32 c) { }

	// RVA: 0x170F100
	public static Char ToUpperFast(Char c) { }

	// RVA: 0x170F184
	public static int GetAttributeParameters(Char[] chars, int startIndex, int length, float[] parameters) { }

	// RVA: 0x170F27C
	public static bool IsBitmapRendering(GlyphRenderMode glyphRenderMode) { }

	// RVA: 0x170F2B0
	public static bool IsBaseGlyph(UInt32 c) { }

	// RVA: 0x170F3E8
	public static Color MinAlpha(Color c1, Color c2) { }

	// RVA: 0x170E394
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x170F3F4
	private static Byte GammaToLinear(Byte value) { }

	// RVA: 0x170F4B4
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	// RVA: 0x170F594
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	// RVA: 0x170F734
	internal static bool IsHangul(UInt32 c) { }

	// RVA: 0x170F790
	internal static bool IsCJK(UInt32 c) { }

	// RVA: 0x170F848
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal class TextHandle
{
	// Fields
	private Vector2 m_PreferredSize; // 0x10
	private TextInfo m_TextInfo; // 0x18
	private static TextInfo m_LayoutTextInfo; // 0x0
	private int m_PreviousGenerationSettingsHash; // 0x20
	protected TextGenerationSettings textGenerationSettings; // 0x28
	protected static TextGenerationSettings s_LayoutSettings; // 0x8
	private bool isDirty; // 0x30

	// Methods

	// RVA: 0x170F89C
	public void .ctor() { }

	// RVA: 0x170F914
	internal TextInfo get_textInfo() { }

	// RVA: 0x170FB1C
	internal static TextInfo get_layoutTextInfo() { }

	// RVA: 0x170FC1C
	public bool IsDirty() { }

	// RVA: 0x170FC80
	public Vector2 GetCursorPositionFromStringIndexUsingCharacterHeight(int index, bool inverseYAxis) { }

	// RVA: 0x170FF60
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance, bool inverseYAxis) { }

	// RVA: 0x17102C0
	public int GetCursorIndexFromPosition(Vector2 position, bool inverseYAxis) { }

	// RVA: 0x1710C30
	public int LineDownCharacterPosition(int originalPos) { }

	// RVA: 0x171100C
	public int LineUpCharacterPosition(int originalPos) { }

	// RVA: 0x1710484
	public int FindNearestLine(Vector2 position) { }

	// RVA: 0x17105EC
	public int FindNearestCharacterOnLine(Vector2 position, int line, bool visibleOnly) { }

	// RVA: 0x17114E0
	public int FindIntersectingLink(Vector3 position, bool inverseYAxis) { }

	// RVA: 0x171134C
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x1711404
	private static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x17119C8
	public int GetLineNumber(int index) { }

	// RVA: 0x1711B74
	public float GetLineHeight(int lineNumber) { }

	// RVA: 0x1711D20
	public float GetLineHeightFromCharacterIndex(int index) { }

	// RVA: 0x1711ED4
	public float GetCharacterHeightFromIndex(int index) { }

	// RVA: 0x1712088
	public bool IsElided() { }

	// RVA: 0x171218C
	public string Substring(int startIndex, int length) { }

	// RVA: 0x17123D4
	public int IndexOf(Char value, int startIndex) { }

	// RVA: 0x1712590
	public int LastIndexOf(Char value, int startIndex) { }

	// RVA: 0x1712708
	protected float ComputeTextWidth(TextGenerationSettings tgs) { }

	// RVA: 0x17127F8
	protected float ComputeTextHeight(TextGenerationSettings tgs) { }

	// RVA: 0x1712780
	protected void UpdatePreferredValues(TextGenerationSettings tgs) { }

	// RVA: 0x1712874
	protected TextInfo Update(TextGenerationSettings tgs) { }

	// RVA: 0x1712A38
	private static void .cctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal struct PageInfo
{
	// Fields
	public int firstCharacterIndex; // 0x10
	public int lastCharacterIndex; // 0x14
	public float ascender; // 0x18
	public float baseLine; // 0x1C
	public float descender; // 0x20
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
	public int pageCount; // 0x28
	public int materialCount; // 0x2C
	public TextElementInfo[] textElementInfo; // 0x30
	public WordInfo[] wordInfo; // 0x38
	public LinkInfo[] linkInfo; // 0x40
	public LineInfo[] lineInfo; // 0x48
	public PageInfo[] pageInfo; // 0x50
	public MeshInfo[] meshInfo; // 0x58
	public bool isDirty; // 0x60
	public bool hasMultipleColors; // 0x61

	// Methods

	// RVA: 0x170F998
	public void .ctor() { }

	// RVA: 0x1712AB8
	internal void Clear() { }

	// RVA: 0x1712B44
	internal void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x1712C08
	internal void ClearLineInfo() { }

	// RVA: 0x1712D80
	internal void ClearPageInfo() { }

	// RVA: 0x30DA46C
	internal static void Resize(T[] array, int size) { }

	// RVA: 0x30DA4D8
	internal static void Resize(T[] array, int size, bool isBlockAllocated) { }

	// RVA: 0x1712E8C
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
	public const MarkupTag RED = 91635;
	public const MarkupTag GREEN = 87065851;
	public const MarkupTag BLUE = 2457214;
	public const MarkupTag YELLOW = 3412522628;
	public const MarkupTag ORANGE = 3186379376;
	public const MarkupTag BLACK = 81074727;
	public const MarkupTag WHITE = 105680263;
	public const MarkupTag PURPLE = 3044745166;
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

	// RVA: 0x1712EE0
	public void Clear() { }

	// RVA: 0x1712EEC
	public Byte Add(FontStyles style) { }

	// RVA: 0x1713000
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

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(T[] stack) { }

	// RVA: 0x30D4A04
	public void .ctor(int capacity) { }

	// RVA: 0x30D4A74
	public void .ctor(int capacity, int rolloverSize) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x318DB98
	public T get_current() { }

	// RVA: 0x318DB98
	internal static void SetDefault(UnityEngine.TextCore.Text.TextProcessingStack<T>[] stack, T item) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public void SetDefault(T item) { }

	// RVA: 0x318DB98
	public void Add(T item) { }

	// RVA: 0x318DB98
	public T Remove() { }

	// RVA: 0x318DB98
	public void Push(T item) { }

	// RVA: 0x318DB98
	public T Pop() { }

	// RVA: 0x318DB98
	public T Peek() { }

	// RVA: 0x318DB98
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

	// RVA: 0x17136A8
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

	// RVA: 0x1713138
	internal static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x17136D0
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private struct FontReferenceMap
{
	// Fields
	public Font font; // 0x10
	public FontAsset fontAsset; // 0x18

	// Methods

	// RVA: 0x1714434
	public void .ctor(Font font, FontAsset fontAsset) { }

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
	protected bool m_MatchMaterialPreset; // 0x38
	protected int m_MissingCharacterUnicode; // 0x3C
	protected bool m_ClearDynamicDataOnBuild; // 0x40
	protected SpriteAsset m_DefaultSpriteAsset; // 0x48
	protected string m_DefaultSpriteAssetPath; // 0x50
	protected System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> m_FallbackSpriteAssets; // 0x58
	protected UInt32 m_MissingSpriteCharacterUnicode; // 0x60
	protected TextStyleSheet m_DefaultStyleSheet; // 0x68
	protected string m_StyleSheetsResourcePath; // 0x70
	protected string m_DefaultColorGradientPresetsPath; // 0x78
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x80
	private bool m_UseModernHangulLineBreakingRules; // 0x88
	protected bool m_DisplayWarnings; // 0x89
	internal System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.FontAsset> m_FontLookup; // 0x90
	private System.Collections.Generic.List<UnityEngine.TextCore.Text.TextSettings.FontReferenceMap> m_FontReferences; // 0x98

	// Methods

	// RVA: 0x171397C
	public string get_version() { }

	// RVA: 0x1713984
	internal void set_version(string value) { }

	// RVA: 0x171398C
	public FontAsset get_defaultFontAsset() { }

	// RVA: 0x1713994
	public void set_defaultFontAsset(FontAsset value) { }

	// RVA: 0x171399C
	public string get_defaultFontAssetPath() { }

	// RVA: 0x17139A4
	public void set_defaultFontAssetPath(string value) { }

	// RVA: 0x17139AC
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x17139B4
	public void set_fallbackFontAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.FontAsset> value) { }

	// RVA: 0x17139BC
	public bool get_matchMaterialPreset() { }

	// RVA: 0x17139C4
	public void set_matchMaterialPreset(bool value) { }

	// RVA: 0x17139CC
	public int get_missingCharacterUnicode() { }

	// RVA: 0x17139D4
	public void set_missingCharacterUnicode(int value) { }

	// RVA: 0x17139DC
	public bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x17139E4
	public void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x17139EC
	public SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x17139F4
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	// RVA: 0x17139FC
	public string get_defaultSpriteAssetPath() { }

	// RVA: 0x1713A04
	public void set_defaultSpriteAssetPath(string value) { }

	// RVA: 0x1713A0C
	public System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> get_fallbackSpriteAssets() { }

	// RVA: 0x1713A14
	public void set_fallbackSpriteAssets(System.Collections.Generic.List<UnityEngine.TextCore.Text.SpriteAsset> value) { }

	// RVA: 0x1713A1C
	public UInt32 get_missingSpriteCharacterUnicode() { }

	// RVA: 0x1713A24
	public void set_missingSpriteCharacterUnicode(UInt32 value) { }

	// RVA: 0x1713A2C
	public TextStyleSheet get_defaultStyleSheet() { }

	// RVA: 0x1713A34
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	// RVA: 0x1713A3C
	public string get_styleSheetsResourcePath() { }

	// RVA: 0x1713A44
	public void set_styleSheetsResourcePath(string value) { }

	// RVA: 0x1713A4C
	public string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x1713A54
	public void set_defaultColorGradientPresetsPath(string value) { }

	// RVA: 0x1713A5C
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	// RVA: 0x1713D98
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	// RVA: 0x1713DA0
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x1713DA8
	public void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x1713DB0
	public bool get_displayWarnings() { }

	// RVA: 0x1713DB8
	public void set_displayWarnings(bool value) { }

	// RVA: 0x1713DC0
	private void OnEnable() { }

	// RVA: 0x1713E48
	protected void InitializeFontReferenceLookup() { }

	// RVA: 0x17140C8
	protected FontAsset GetCachedFontAssetInternal(Font font) { }

	// RVA: 0x1714468
	public void .ctor() { }

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
	private static Shader k_ShaderRef_MobileSDF; // 0x148
	private static Shader k_ShaderRef_MobileBitmap; // 0x150

	// Methods

	// RVA: 0x17145A0
	internal static Shader get_ShaderRef_MobileSDF() { }

	// RVA: 0x1714858
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x1714B10
	private static void .cctor() { }

	// RVA: 0x1714D34
	internal static void GetShaderPropertyIDs() { }

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

	// RVA: 0x170C464
	public int get_hashCode() { }

	// RVA: 0x170C46C
	public UInt32[] get_styleOpeningTagArray() { }

	// RVA: 0x170CADC
	public UInt32[] get_styleClosingTagArray() { }

	// RVA: 0x1715824
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x171589C
	public void RefreshStyle() { }

}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class TextStyleSheet
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> m_StyleList; // 0x18
	private System.Collections.Generic.Dictionary<System.Int32,UnityEngine.TextCore.Text.TextStyle> m_StyleLookupDictionary; // 0x20

	// Methods

	// RVA: 0x1715A7C
	internal System.Collections.Generic.List<UnityEngine.TextCore.Text.TextStyle> get_styles() { }

	// RVA: 0x1715A84
	private void Reset() { }

	// RVA: 0x170D8F0
	public TextStyle GetStyle(int hashCode) { }

	// RVA: 0x1715DA4
	public TextStyle GetStyle(string name) { }

	// RVA: 0x1715E68
	public void RefreshStyles() { }

	// RVA: 0x1715A88
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x1715E6C
	public void .ctor() { }

}

// Namespace: UnityEngine.TextCore.Text
internal static class TextUtilities
{
	// Methods

	// RVA: 0x1715EFC
	internal static Char ToUpperFast(Char c) { }

	// RVA: 0x17138A4
	public static int GetHashCodeCaseInSensitive(string s) { }

	// RVA: 0x1715F80
	internal static string UintToString(System.Collections.Generic.List<System.UInt32> unicodes) { }

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

	// RVA: 0x1716090
	public TextAsset get_leadingCharacters() { }

	// RVA: 0x1716098
	public TextAsset get_followingCharacters() { }

	// RVA: 0x17160A0
	internal System.Collections.Generic.HashSet<System.UInt32> get_leadingCharactersLookup() { }

	// RVA: 0x1716354
	internal System.Collections.Generic.HashSet<System.UInt32> get_followingCharactersLookup() { }

	// RVA: 0x1716398
	public bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x1713AF4
	internal void LoadLineBreakingRules() { }

	// RVA: 0x17160E0
	internal void LoadLineBreakingRules(TextAsset leadingRules, TextAsset followingRules) { }

	// RVA: 0x17163A0
	private static System.Collections.Generic.HashSet<System.UInt32> GetCharacters(TextAsset file) { }

	// RVA: 0x1713AEC
	public void .ctor() { }

}


