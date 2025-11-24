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

	// RVA: 0x16F32E0
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x16F3434
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x16F3520
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

	// RVA: 0x16F380C
	public void .ctor() { }

	// RVA: 0x16F3814
	public void .ctor(int initialCapacity) { }

	// RVA: 0x16F39C8
	protected override void Finalize() { }

	// RVA: 0x16F3AE0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x16F3B98
	public int get_characterCountVisible() { }

	// RVA: 0x16F3C48
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x16F3FBC
	public void Invalidate() { }

	// RVA: 0x16F3FC4
	public void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters) { }

	// RVA: 0x16F4094
	public void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines) { }

	// RVA: 0x16F4164
	public void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }

	// RVA: 0x16F4234
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x16F4454
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x16F454C
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x16F4330
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x16F4798
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x16F4854
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x16F4C70
	public System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts() { }

	// RVA: 0x16F4CEC
	public System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters() { }

	// RVA: 0x16F4D68
	public System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines() { }

	// RVA: 0x16F43F8
	public Rect get_rectExtents() { }

	// RVA: 0x16F3BF8
	public int get_characterCount() { }

	// RVA: 0x16F4E4C
	public int get_lineCount() { }

	// RVA: 0x16F3988
	private static IntPtr Internal_Create() { }

	// RVA: 0x16F3B48
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x16F4E9C
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, UInt32 error) { }

	// RVA: 0x16F4A98
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, TextGenerationError error) { }

	// RVA: 0x16F41CC
	private void GetVerticesInternal(object vertices) { }

	// RVA: 0x16F402C
	private void GetCharactersInternal(object characters) { }

	// RVA: 0x16F40FC
	private void GetLinesInternal(object lines) { }

	// RVA: 0x16F4DE4
	private void get_rectExtents_Injected(Rect ret) { }

	// RVA: 0x16F4FDC
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

	// RVA: 0x16F50E0
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

	// RVA: 0x16F5148
	public int get_advance() { }

	// RVA: 0x16F5238
	public int get_glyphWidth() { }

	// RVA: 0x16F5258
	public int get_glyphHeight() { }

	// RVA: 0x16F527C
	public int get_minY() { }

	// RVA: 0x16F52A4
	public int get_minX() { }

	// RVA: 0x16F52C4
	internal Vector2 get_uvBottomLeftUnFlipped() { }

	// RVA: 0x16F52CC
	internal Vector2 get_uvTopRightUnFlipped() { }

	// RVA: 0x16F52E0
	public Vector2 get_uvBottomLeft() { }

	// RVA: 0x16F52E8
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

	// RVA: 0x16F52FC
	private static void .cctor() { }

}

// Namespace: 
public sealed class FontTextureRebuildCallback
{
	// Methods

	// RVA: 0x16F5AF4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F5B94
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public sealed class Font
{
	// Fields
	private static System.Action<UnityEngine.Font> textureRebuilt; // 0x0
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Methods

	// RVA: 0x16F5474
	public static void add_textureRebuilt(System.Action<UnityEngine.Font> value) { }

	// RVA: 0x16F5544
	public static void remove_textureRebuilt(System.Action<UnityEngine.Font> value) { }

	// RVA: 0x16F5614
	public Material get_material() { }

	// RVA: 0x16F3F6C
	public bool get_dynamic() { }

	// RVA: 0x16F5664
	public int get_fontSize() { }

	// RVA: 0x16F56B4
	public void .ctor() { }

	// RVA: 0x16F57E8
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x16F5884
	public bool HasCharacter(Char c) { }

	// RVA: 0x16F58EC
	private bool HasCharacter(int c) { }

	// RVA: 0x16F5780
	private static void Internal_CreateFont(Font self, string name) { }

	// RVA: 0x16F5954
	public bool GetCharacterInfo(Char ch, CharacterInfo info, int size, FontStyle style) { }

	// RVA: 0x16F59C4
	public bool GetCharacterInfo(Char ch, CharacterInfo info, int size) { }

	// RVA: 0x16F5A30
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	// RVA: 0x16F5A98
	public void RequestCharactersInTexture(string characters, int size) { }

}


