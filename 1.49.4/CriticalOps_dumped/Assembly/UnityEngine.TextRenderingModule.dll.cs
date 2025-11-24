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

	// RVA: 0x16E4070
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x16E41C4
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x16E42B0
	public bool Equals(TextGenerationSettings other) { }

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

	// RVA: 0x16E459C
	public void .ctor() { }

	// RVA: 0x16E45A4
	public void .ctor(int initialCapacity) { }

	// RVA: 0x16E4758
	protected override void Finalize() { }

	// RVA: 0x16E4870
	private void System.IDisposable.Dispose() { }

	// RVA: 0x16E4928
	public int get_characterCountVisible() { }

	// RVA: 0x16E49D8
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x16E4D4C
	public void Invalidate() { }

	// RVA: 0x16E4D54
	public void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters) { }

	// RVA: 0x16E4E24
	public void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines) { }

	// RVA: 0x16E4EF4
	public void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }

	// RVA: 0x16E4FC4
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x16E51E4
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x16E52DC
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x16E50C0
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x16E5528
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x16E55E4
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x16E5A00
	public System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts() { }

	// RVA: 0x16E5A7C
	public System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters() { }

	// RVA: 0x16E5AF8
	public System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines() { }

	// RVA: 0x16E5188
	public Rect get_rectExtents() { }

	// RVA: 0x16E4988
	public int get_characterCount() { }

	// RVA: 0x16E5BDC
	public int get_lineCount() { }

	// RVA: 0x16E4718
	private static IntPtr Internal_Create() { }

	// RVA: 0x16E48D8
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x16E5C2C
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, UInt32 error) { }

	// RVA: 0x16E5828
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, TextGenerationError error) { }

	// RVA: 0x16E4F5C
	private void GetVerticesInternal(object vertices) { }

	// RVA: 0x16E4DBC
	private void GetCharactersInternal(object characters) { }

	// RVA: 0x16E4E8C
	private void GetLinesInternal(object lines) { }

	// RVA: 0x16E5B74
	private void get_rectExtents_Injected(Rect ret) { }

	// RVA: 0x16E5D6C
	private bool Populate_Internal_Injected(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, UInt32 error) { }

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

	// RVA: 0x16E5E70
	public void set_text(string value) { }

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

	// RVA: 0x16E5ED8
	public int get_advance() { }

	// RVA: 0x16E5FC8
	public int get_glyphWidth() { }

	// RVA: 0x16E5FE8
	public int get_glyphHeight() { }

	// RVA: 0x16E600C
	public int get_minY() { }

	// RVA: 0x16E6034
	public int get_minX() { }

	// RVA: 0x16E6054
	internal Vector2 get_uvBottomLeftUnFlipped() { }

	// RVA: 0x16E605C
	internal Vector2 get_uvTopRightUnFlipped() { }

	// RVA: 0x16E6070
	public Vector2 get_uvBottomLeft() { }

	// RVA: 0x16E6078
	public Vector2 get_uvTopRight() { }

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

	// RVA: 0x16E608C
	private static void .cctor() { }

}

// Namespace: 
public sealed class FontTextureRebuildCallback
{
	// Methods

	// RVA: 0x16E6884
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16E6924
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public sealed class Font
{
	// Fields
	private static System.Action<UnityEngine.Font> textureRebuilt; // 0x0
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Methods

	// RVA: 0x16E6204
	public static void add_textureRebuilt(System.Action<UnityEngine.Font> value) { }

	// RVA: 0x16E62D4
	public static void remove_textureRebuilt(System.Action<UnityEngine.Font> value) { }

	// RVA: 0x16E63A4
	public Material get_material() { }

	// RVA: 0x16E4CFC
	public bool get_dynamic() { }

	// RVA: 0x16E63F4
	public int get_fontSize() { }

	// RVA: 0x16E6444
	public void .ctor() { }

	// RVA: 0x16E6578
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x16E6614
	public bool HasCharacter(Char c) { }

	// RVA: 0x16E667C
	private bool HasCharacter(int c) { }

	// RVA: 0x16E6510
	private static void Internal_CreateFont(Font self, string name) { }

	// RVA: 0x16E66E4
	public bool GetCharacterInfo(Char ch, CharacterInfo info, int size, FontStyle style) { }

	// RVA: 0x16E6754
	public bool GetCharacterInfo(Char ch, CharacterInfo info, int size) { }

	// RVA: 0x16E67C0
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	// RVA: 0x16E6828
	public void RequestCharactersInTexture(string characters, int size) { }

}


