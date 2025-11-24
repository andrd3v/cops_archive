// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine
public enum FontStyle 
{
	// Fields
	public int value__; // 0x10
	public const FontStyle Normal = 0;
	public const FontStyle Bold = 1;
	public const FontStyle Italic = 2;
	public const FontStyle BoldAndItalic = 3;
}

// Namespace: UnityEngine
internal enum TextGenerationError 
{
	// Fields
	public int value__; // 0x10
	public const TextGenerationError None = 0;
	public const TextGenerationError CustomSizeOnNonDynamicFont = 1;
	public const TextGenerationError CustomStyleOnNonDynamicFont = 2;
	public const TextGenerationError NoFont = 4;
}

// Namespace: UnityEngine
public struct TextGenerationSettings 
{
	// Fields
	public Font font; // 0x10
	public Color color; // 0x18
	public int fontSize; // 0x28
	public float lineSpacing; // 0x2C
	public bool richText; // 0x30
	public float scaleFactor; // 0x34
	public FontStyle fontStyle; // 0x38
	public TextAnchor textAnchor; // 0x3C
	public bool alignByGeometry; // 0x40
	public bool resizeTextForBestFit; // 0x41
	public int resizeTextMinSize; // 0x44
	public int resizeTextMaxSize; // 0x48
	public bool updateBounds; // 0x4C
	public VerticalWrapMode verticalOverflow; // 0x50
	public HorizontalWrapMode horizontalOverflow; // 0x54
	public Vector2 generationExtents; // 0x58
	public Vector2 pivot; // 0x60
	public bool generateOutOfBounds; // 0x68

	// Methods

	// RVA: 0x15FF08C
	bool CompareColors(Color left, Color right) { }

	// RVA: 0x15FF1E0
	bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x15FF2CC
	bool Equals(TextGenerationSettings other) { }

}

// Namespace: UnityEngine
public sealed class TextGenerator 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly System.Collections.Generic.List<UnityEngine.UIVertex> m_Verts; // 0x88
	private readonly System.Collections.Generic.List<UnityEngine.UICharInfo> m_Characters; // 0x90
	private readonly System.Collections.Generic.List<UnityEngine.UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Methods

	// RVA: 0x15FF5B8
	void .ctor() { }

	// RVA: 0x15FF5C0
	void .ctor(int initialCapacity) { }

	// RVA: 0x15FF774
	void Finalize() { }

	// RVA: 0x15FF88C
	void System.IDisposable.Dispose() { }

	// RVA: 0x15FF944
	int get_characterCountVisible() { }

	// RVA: 0x15FF9F4
	TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x15FFD68
	void Invalidate() { }

	// RVA: 0x15FFD70
	void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters) { }

	// RVA: 0x15FFE40
	void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines) { }

	// RVA: 0x15FFF10
	void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }

	// RVA: 0x15FFFE0
	float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x1600200
	float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x16002F8
	bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x16000DC
	bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x1600544
	TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x1600600
	TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x1600A1C
	System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts() { }

	// RVA: 0x1600A98
	System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters() { }

	// RVA: 0x1600B14
	System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines() { }

	// RVA: 0x16001A4
	Rect get_rectExtents() { }

	// RVA: 0x15FF9A4
	int get_characterCount() { }

	// RVA: 0x1600BF8
	int get_lineCount() { }

	// RVA: 0x15FF734
	IntPtr Internal_Create() { }

	// RVA: 0x15FF8F4
	void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1600C48
	bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out UInt32 error) { }

	// RVA: 0x1600844
	bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	// RVA: 0x15FFF78
	void GetVerticesInternal(object vertices) { }

	// RVA: 0x15FFDD8
	void GetCharactersInternal(object characters) { }

	// RVA: 0x15FFEA8
	void GetLinesInternal(object lines) { }

	// RVA: 0x1600B90
	void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x1600D88
	bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out UInt32 error) { }

}

// Namespace: UnityEngine
public enum TextAlignment 
{
	// Fields
	public int value__; // 0x10
	public const TextAlignment Left = 0;
	public const TextAlignment Center = 1;
	public const TextAlignment Right = 2;
}

// Namespace: UnityEngine
public enum TextAnchor 
{
	// Fields
	public int value__; // 0x10
	public const TextAnchor UpperLeft = 0;
	public const TextAnchor UpperCenter = 1;
	public const TextAnchor UpperRight = 2;
	public const TextAnchor MiddleLeft = 3;
	public const TextAnchor MiddleCenter = 4;
	public const TextAnchor MiddleRight = 5;
	public const TextAnchor LowerLeft = 6;
	public const TextAnchor LowerCenter = 7;
	public const TextAnchor LowerRight = 8;
}

// Namespace: UnityEngine
public enum HorizontalWrapMode 
{
	// Fields
	public int value__; // 0x10
	public const HorizontalWrapMode Wrap = 0;
	public const HorizontalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
public enum VerticalWrapMode 
{
	// Fields
	public int value__; // 0x10
	public const VerticalWrapMode Truncate = 0;
	public const VerticalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
public sealed class TextMesh 
{
	// Methods

	// RVA: 0x1600E8C
	void set_text(string value) { }

}

// Namespace: UnityEngine
public struct CharacterInfo 
{
	// Fields
	public int index; // 0x10
	public Rect uv; // 0x14
	public Rect vert; // 0x24
	public float width; // 0x34
	public int size; // 0x38
	public FontStyle style; // 0x3C
	public bool flipped; // 0x40

	// Methods

	// RVA: 0x1600EF4
	int get_advance() { }

	// RVA: 0x1600FE4
	int get_glyphWidth() { }

	// RVA: 0x1601004
	int get_glyphHeight() { }

	// RVA: 0x1601028
	int get_minY() { }

	// RVA: 0x1601050
	int get_minX() { }

	// RVA: 0x1601070
	Vector2 get_uvBottomLeftUnFlipped() { }

	// RVA: 0x1601078
	Vector2 get_uvTopRightUnFlipped() { }

	// RVA: 0x160108C
	Vector2 get_uvBottomLeft() { }

	// RVA: 0x1601094
	Vector2 get_uvTopRight() { }

}

// Namespace: UnityEngine
public struct UICharInfo 
{
	// Fields
	public Vector2 cursorPos; // 0x10
	public float charWidth; // 0x18
}

// Namespace: UnityEngine
public struct UILineInfo 
{
	// Fields
	public int startCharIdx; // 0x10
	public int height; // 0x14
	public float topY; // 0x18
	public float leading; // 0x1C
}

// Namespace: UnityEngine
public struct UIVertex 
{
	// Fields
	public Vector3 position; // 0x10
	public Vector3 normal; // 0x1C
	public Vector4 tangent; // 0x28
	public Color32 color; // 0x38
	public Vector4 uv0; // 0x3C
	public Vector4 uv1; // 0x4C
	public Vector4 uv2; // 0x5C
	public Vector4 uv3; // 0x6C
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Methods

	// RVA: 0x16010A8
	void .cctor() { }

}

// Namespace: 
public sealed class FontTextureRebuildCallback 
{
	// Methods

	// RVA: 0x16018A0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1601940
	internal void Invoke() { }

}

// Namespace: UnityEngine
public sealed class Font 
{
	// Fields
	private static System.Action<UnityEngine.Font> textureRebuilt; // 0x0
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Methods

	// RVA: 0x1601220
	void add_textureRebuilt(System.Action<UnityEngine.Font> value) { }

	// RVA: 0x16012F0
	void remove_textureRebuilt(System.Action<UnityEngine.Font> value) { }

	// RVA: 0x16013C0
	Material get_material() { }

	// RVA: 0x15FFD18
	bool get_dynamic() { }

	// RVA: 0x1601410
	int get_fontSize() { }

	// RVA: 0x1601460
	void .ctor() { }

	// RVA: 0x1601594
	void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x1601630
	bool HasCharacter(Char c) { }

	// RVA: 0x1601698
	bool HasCharacter(int c) { }

	// RVA: 0x160152C
	void Internal_CreateFont(Font self, string name) { }

	// RVA: 0x1601700
	bool GetCharacterInfo(Char ch, out CharacterInfo info, int size, FontStyle style) { }

	// RVA: 0x1601770
	bool GetCharacterInfo(Char ch, out CharacterInfo info, int size) { }

	// RVA: 0x16017DC
	void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	// RVA: 0x1601844
	void RequestCharactersInTexture(string characters, int size) { }

}


