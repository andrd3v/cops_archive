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

	// RVA: 0x17DBB7C
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x17DBCD0
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x17DBDBC
	public bool Equals(TextGenerationSettings other) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x17DDF18
	public static IntPtr ConvertToNative(TextGenerator textGenerator) { }

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

	// RVA: 0x17DC0A8
	public void .ctor() { }

	// RVA: 0x17DC0B0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x17DC264
	protected override void Finalize() { }

	// RVA: 0x17DC37C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x17DC424
	public int get_characterCountVisible() { }

	// RVA: 0x17DC514
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x17DC918
	public void Invalidate() { }

	// RVA: 0x17DC920
	public void GetCharacters(System.Collections.Generic.List<UnityEngine.UICharInfo> characters) { }

	// RVA: 0x17DCA30
	public void GetLines(System.Collections.Generic.List<UnityEngine.UILineInfo> lines) { }

	// RVA: 0x17DCB40
	public void GetVertices(System.Collections.Generic.List<UnityEngine.UIVertex> vertices) { }

	// RVA: 0x17DCC50
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x17DCEC4
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x17DCFEC
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x17DCD7C
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x17DD238
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x17DD2F4
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x17DD6D4
	public System.Collections.Generic.IList<UnityEngine.UIVertex> get_verts() { }

	// RVA: 0x17DD774
	public System.Collections.Generic.IList<UnityEngine.UICharInfo> get_characters() { }

	// RVA: 0x17DD814
	public System.Collections.Generic.IList<UnityEngine.UILineInfo> get_lines() { }

	// RVA: 0x17DCE44
	public Rect get_rectExtents() { }

	// RVA: 0x17DC4A4
	public int get_characterCount() { }

	// RVA: 0x17DD96C
	public int get_lineCount() { }

	// RVA: 0x17DC224
	private static IntPtr Internal_Create() { }

	// RVA: 0x17DC3D4
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x17DDA2C
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, UInt32 error) { }

	// RVA: 0x17DD524
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, TextGenerationError error) { }

	// RVA: 0x17DCBC8
	private void GetVerticesInternal(object vertices) { }

	// RVA: 0x17DC9A8
	private void GetCharactersInternal(object characters) { }

	// RVA: 0x17DCAB8
	private void GetLinesInternal(object lines) { }

	// RVA: 0x17DD8B4
	private static void get_rectExtents_Injected(IntPtr _unity_self, Rect ret) { }

	// RVA: 0x17DD91C
	private static int get_characterCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x17DD9DC
	private static int get_lineCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x17DDCDC
	private static bool Populate_Internal_Injected(IntPtr _unity_self, ManagedSpanWrapper str, IntPtr font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, UInt32 error) { }

	// RVA: 0x17DDDE0
	private static void GetVerticesInternal_Injected(IntPtr _unity_self, object vertices) { }

	// RVA: 0x17DDE48
	private static void GetCharactersInternal_Injected(IntPtr _unity_self, object characters) { }

	// RVA: 0x17DDEB0
	private static void GetLinesInternal_Injected(IntPtr _unity_self, object lines) { }

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
public enum TextGeneratorType
{
	// Fields
	public int value__; // 0x10
	public const TextGeneratorType Standard = 0;
	public const TextGeneratorType Advanced = 1;
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

	// RVA: 0x17DDF34
	public void set_text(string value) { }

	// RVA: 0x17DE158
	public void .ctor() { }

	// RVA: 0x17DE0F0
	private static void set_text_Injected(IntPtr _unity_self, ManagedSpanWrapper value) { }

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

	// RVA: 0x17DE160
	public int get_advance() { }

	// RVA: 0x17DE250
	public int get_glyphWidth() { }

	// RVA: 0x17DE270
	public int get_glyphHeight() { }

	// RVA: 0x17DE294
	public int get_minY() { }

	// RVA: 0x17DE2BC
	public int get_minX() { }

	// RVA: 0x17DE2DC
	internal Vector2 get_uvBottomLeftUnFlipped() { }

	// RVA: 0x17DE2E4
	internal Vector2 get_uvTopRightUnFlipped() { }

	// RVA: 0x17DE2F8
	public Vector2 get_uvBottomLeft() { }

	// RVA: 0x17DE300
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

	// RVA: 0x17DE314
	private static void .cctor() { }

}

// Namespace: 
public sealed class FontTextureRebuildCallback
{
	// Methods

	// RVA: 0x17DF198
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17DF238
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public sealed class Font
{
	// Fields
	private static System.Action<UnityEngine.Font> textureRebuilt; // 0x0
	private FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Methods

	// RVA: 0x17DE48C
	public static void add_textureRebuilt(System.Action<UnityEngine.Font> value) { }

	// RVA: 0x17DE55C
	public static void remove_textureRebuilt(System.Action<UnityEngine.Font> value) { }

	// RVA: 0x17DE62C
	public Material get_material() { }

	// RVA: 0x17DC880
	public bool get_dynamic() { }

	// RVA: 0x17DE784
	public int get_fontSize() { }

	// RVA: 0x17DE86C
	public void .ctor() { }

	// RVA: 0x17DEA60
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x17DEAFC
	public bool HasCharacter(Char c) { }

	// RVA: 0x17DEBAC
	private bool HasCharacter(int c) { }

	// RVA: 0x17DECC4
	internal static string[] GetOSFallbacks() { }

	// RVA: 0x17DE8DC
	private static void Internal_CreateFont(Font self, string name) { }

	// RVA: 0x17DED6C
	public bool GetCharacterInfo(Char ch, CharacterInfo info, int size, FontStyle style) { }

	// RVA: 0x17DEE98
	public bool GetCharacterInfo(Char ch, CharacterInfo info, int size) { }

	// RVA: 0x17DEF50
	public void RequestCharactersInTexture(string characters, int size, FontStyle style) { }

	// RVA: 0x17DF190
	public void RequestCharactersInTexture(string characters, int size) { }

	// RVA: 0x17DE6E4
	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	// RVA: 0x17DE734
	private static bool get_dynamic_Injected(IntPtr _unity_self) { }

	// RVA: 0x17DE81C
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x17DEC5C
	private static bool HasCharacter_Injected(IntPtr _unity_self, int c) { }

	// RVA: 0x17DED04
	private static void Internal_CreateFont_Injected(Font self, ManagedSpanWrapper name) { }

	// RVA: 0x17DEE28
	private static bool GetCharacterInfo_Injected(IntPtr _unity_self, Char ch, CharacterInfo info, int size, FontStyle style) { }

	// RVA: 0x17DF128
	private static void RequestCharactersInTexture_Injected(IntPtr _unity_self, ManagedSpanWrapper characters, int size, FontStyle style) { }

}


