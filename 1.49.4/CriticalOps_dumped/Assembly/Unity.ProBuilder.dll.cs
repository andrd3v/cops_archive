// Namespace: 
internal class <Module>
{}

// Namespace: 
private struct MonoScriptData
{
	// Fields
	public Byte[] FilePathsData; // 0x10
	public Byte[] TypesData; // 0x18
	public int TotalTypes; // 0x20
	public int TotalFiles; // 0x24
	public bool IsEditorOnly; // 0x28
}

// Namespace: 
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	// Methods

	// RVA: 0x14D1BAC
	private static MonoScriptData Get() { }

	// RVA: 0x14D1CB0
	public void .ctor() { }

}

// Namespace: 
public enum Status
{
	// Fields
	public int value__; // 0x10
	public const Status Success = 0;
	public const Status Failure = 1;
	public const Status Canceled = 2;
	public const Status NoChange = 3;
}

// Namespace: UnityEngine.ProBuilder
public sealed class ActionResult
{
	// Fields
	private Status <status>k__BackingField; // 0x10
	private string <notification>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14D1CB8
	public Status get_status() { }

	// RVA: 0x14D1CC0
	private void set_status(Status value) { }

	// RVA: 0x14D1CC8
	public string get_notification() { }

	// RVA: 0x14D1CD0
	private void set_notification(string value) { }

	// RVA: 0x14D1CD8
	public void .ctor(Status status, string notification) { }

	// RVA: 0x14D1D1C
	public static bool op_Implicit(ActionResult res) { }

	// RVA: 0x14D1D30
	public bool ToBool() { }

	// RVA: 0x14D1D40
	public static bool FromBool(bool success) { }

	// RVA: 0x14D1E34
	public static ActionResult get_Success() { }

	// RVA: 0x14D1EC0
	public static ActionResult get_NoSelection() { }

	// RVA: 0x14D1F50
	public static ActionResult get_UserCanceled() { }

}

// Namespace: 
private struct SearchRange
{
	// Fields
	public int begin; // 0x10
	public int end; // 0x14

	// Methods

	// RVA: 0x14D1FE0
	public void .ctor(int begin, int end) { }

	// RVA: 0x14D1FE8
	public bool Valid() { }

	// RVA: 0x14D1FFC
	public int Center() { }

	// RVA: 0x14D2014
	public override string ToString() { }

}

// Namespace: 
[Serializable]
private sealed class <>c__23<T0>
{
	// Fields
	public static readonly UnityEngine.ProBuilder.ArrayUtility.<>c__23<T> <>9; // 0x0
	public static System.Func<T,System.String> <>9__23_0; // 0x0

	// Methods

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal string <ToString>b__23_0(T x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0<T0, T1>
{
	// Fields
	public System.Collections.Generic.HashSet<TKey> knownKeys; // 0x0
	public System.Func<TSource,TKey> keySelector; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal bool <DistinctBy>b__0(TSource x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ArrayUtility
{
	// Methods

	// RVA: 0x30A53B0
	public static T[] ValuesWithIndexes(T[] arr, int[] indexes) { }

	// RVA: 0x30A53B0
	public static System.Collections.Generic.List<T> ValuesWithIndexes(System.Collections.Generic.List<T> arr, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x30A53B0
	public static System.Collections.Generic.IEnumerable<System.Int32> AllIndexesOf(System.Collections.Generic.IList<T> list, System.Func<T,System.Boolean> lambda) { }

	// RVA: 0x315B3A8
	public static T[] Add(T[] arr, T val) { }

	// RVA: 0x30A53B0
	public static T[] AddRange(T[] arr, T[] val) { }

	// RVA: 0x315B3A8
	public static T[] Remove(T[] arr, T val) { }

	// RVA: 0x30A53B0
	public static T[] Remove(T[] arr, System.Collections.Generic.IEnumerable<T> val) { }

	// RVA: -1
	public static T[] RemoveAt(T[] arr, int index) { }

	// RVA: 0x30A53B0
	public static T[] RemoveAt(System.Collections.Generic.IList<T> list, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x30A53B0
	public static T[] SortedRemoveAt(System.Collections.Generic.IList<T> list, System.Collections.Generic.IList<System.Int32> sorted) { }

	// RVA: 0x315B3A8
	public static int NearestIndexPriorToValue(System.Collections.Generic.IList<T> sorted_list, T value) { }

	// RVA: -1
	public static System.Collections.Generic.List<T> Fill(System.Func<System.Int32,T> ctor, int length) { }

	// RVA: 0x315B3A8
	public static T[] Fill(T val, int length) { }

	// RVA: 0x30A3C14
	public static bool ContainsMatch(T[] a, T[] b) { }

	// RVA: -1
	public static bool ContainsMatch(T[] a, T[] b, int index_a, int index_b) { }

	// RVA: 0x30A53B0
	public static T[] Concat(T[] x, T[] y) { }

	// RVA: 0x315B3A8
	public static int IndexOf(System.Collections.Generic.List<System.Collections.Generic.List<T>> InList, T InValue) { }

	// RVA: -1
	public static T[] Fill(int count, System.Func<System.Int32,T> ctor) { }

	// RVA: 0x315B3A8
	public static void AddOrAppend(System.Collections.Generic.Dictionary<T,System.Collections.Generic.List<K>> dictionary, T key, K value) { }

	// RVA: 0x315B3A8
	public static void AddOrAppendRange(System.Collections.Generic.Dictionary<T,System.Collections.Generic.List<K>> dictionary, T key, System.Collections.Generic.List<K> value) { }

	// RVA: 0x30A53B0
	public static System.Collections.Generic.IEnumerable<TSource> DistinctBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector) { }

	// RVA: 0x30A52D0
	public static string ToString(System.Collections.Generic.Dictionary<TKey,TValue> dict) { }

	// RVA: 0x30A53B0
	public static string ToString(System.Collections.Generic.IEnumerable<T> arr, string separator) { }

}

// Namespace: 
public enum Anchor
{
	// Fields
	public int value__; // 0x10
	public const Anchor UpperLeft = 0;
	public const Anchor UpperCenter = 1;
	public const Anchor UpperRight = 2;
	public const Anchor MiddleLeft = 3;
	public const Anchor MiddleCenter = 4;
	public const Anchor MiddleRight = 5;
	public const Anchor LowerLeft = 6;
	public const Anchor LowerCenter = 7;
	public const Anchor LowerRight = 8;
	public const Anchor None = 9;
}

// Namespace: 
public enum Fill
{
	// Fields
	public int value__; // 0x10
	public const Fill Fit = 0;
	public const Fill Tile = 1;
	public const Fill Stretch = 2;
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public struct AutoUnwrapSettings
{
	// Fields
	private bool m_UseWorldSpace; // 0x10
	private bool m_FlipU; // 0x11
	private bool m_FlipV; // 0x12
	private bool m_SwapUV; // 0x13
	private Fill m_Fill; // 0x14
	private Vector2 m_Scale; // 0x18
	private Vector2 m_Offset; // 0x20
	private float m_Rotation; // 0x28
	private Anchor m_Anchor; // 0x2C

	// Methods

	// RVA: 0x14D21C0
	public static AutoUnwrapSettings get_defaultAutoUnwrapSettings() { }

	// RVA: 0x14D21F0
	public bool get_useWorldSpace() { }

	// RVA: 0x14D21F8
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x14D2200
	public bool get_flipU() { }

	// RVA: 0x14D2208
	public void set_flipU(bool value) { }

	// RVA: 0x14D2210
	public bool get_flipV() { }

	// RVA: 0x14D2218
	public void set_flipV(bool value) { }

	// RVA: 0x14D2220
	public bool get_swapUV() { }

	// RVA: 0x14D2228
	public void set_swapUV(bool value) { }

	// RVA: 0x14D2230
	public Fill get_fill() { }

	// RVA: 0x14D2238
	public void set_fill(Fill value) { }

	// RVA: 0x14D2240
	public Vector2 get_scale() { }

	// RVA: 0x14D2248
	public void set_scale(Vector2 value) { }

	// RVA: 0x14D2250
	public Vector2 get_offset() { }

	// RVA: 0x14D2258
	public void set_offset(Vector2 value) { }

	// RVA: 0x14D2260
	public float get_rotation() { }

	// RVA: 0x14D2268
	public void set_rotation(float value) { }

	// RVA: 0x14D2270
	public Anchor get_anchor() { }

	// RVA: 0x14D2278
	public void set_anchor(Anchor value) { }

	// RVA: 0x14D2280
	public void .ctor(AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x14D22DC
	public static AutoUnwrapSettings get_tile() { }

	// RVA: 0x14D22F4
	public static AutoUnwrapSettings get_fit() { }

	// RVA: 0x14D230C
	public static AutoUnwrapSettings get_stretch() { }

	// RVA: 0x14D21D8
	public void Reset() { }

	// RVA: 0x14D2324
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
internal enum BezierTangentMode
{
	// Fields
	public int value__; // 0x10
	public const BezierTangentMode Free = 0;
	public const BezierTangentMode Aligned = 1;
	public const BezierTangentMode Mirrored = 2;
}

// Namespace: UnityEngine.ProBuilder
internal enum BezierTangentDirection
{
	// Fields
	public int value__; // 0x10
	public const BezierTangentDirection In = 0;
	public const BezierTangentDirection Out = 1;
}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal struct BezierPoint
{
	// Fields
	public Vector3 position; // 0x10
	public Vector3 tangentIn; // 0x1C
	public Vector3 tangentOut; // 0x28
	public Quaternion rotation; // 0x34

	// Methods

	// RVA: 0x14D27B8
	public void .ctor(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation) { }

	// RVA: 0x14D27E0
	public void EnforceTangentMode(BezierTangentDirection master, BezierTangentMode mode) { }

	// RVA: 0x14D2AF0
	public void SetPosition(Vector3 position) { }

	// RVA: 0x14D2B40
	public void SetTangentIn(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x14D2B54
	public void SetTangentOut(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x14D2B68
	public static Vector3 QuadraticPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x14D2BC8
	public static Vector3 CubicPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x14D2C6C
	public static Vector3 GetLookDirection(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> points, int index, int previous, int next) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class BezierShape
{
	// Fields
	public System.Collections.Generic.List<UnityEngine.ProBuilder.BezierPoint> points; // 0x20
	public bool closeLoop; // 0x28
	public float radius; // 0x2C
	public int rows; // 0x30
	public int columns; // 0x34
	public bool smooth; // 0x38
	private bool m_IsEditing; // 0x39
	private ProBuilderMesh m_Mesh; // 0x40

	// Methods

	// RVA: 0x14D3648
	public bool get_isEditing() { }

	// RVA: 0x14D3650
	public void set_isEditing(bool value) { }

	// RVA: 0x14D3658
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x14D3750
	public void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x14D3758
	public void Init() { }

	// RVA: 0x14D38C8
	public void Refresh() { }

	// RVA: 0x14D3998
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class Bounds2D
{
	// Fields
	public Vector2 center; // 0x10
	private Vector2 m_Size; // 0x18
	private Vector2 m_Extents; // 0x20

	// Methods

	// RVA: 0x14D3A40
	public Vector2 get_size() { }

	// RVA: 0x14D3A48
	public void set_size(Vector2 value) { }

	// RVA: 0x14D3A60
	public Vector2 get_extents() { }

	// RVA: 0x14D3A68
	public Vector2[] get_corners() { }

	// RVA: 0x14D3B3C
	public void .ctor() { }

	// RVA: 0x14D3BA8
	public void .ctor(Vector2 center, Vector2 size) { }

	// RVA: 0x14D3C50
	public void .ctor(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x14D3FE4
	public void .ctor(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14D4600
	internal void .ctor(Vector3[] points, Edge[] edges) { }

	// RVA: 0x14D475C
	public void .ctor(Vector2[] points, int length) { }

	// RVA: 0x14D4868
	public bool ContainsPoint(Vector2 point) { }

	// RVA: 0x14D48B8
	public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x14D4B28
	public bool Intersects(Bounds2D bounds) { }

	// RVA: 0x14D4B68
	public bool Intersects(Rect rect) { }

	// RVA: 0x14D3CD4
	public void SetWithPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x14D4070
	public void SetWithPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14D4BA4
	public static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x14D4E60
	public static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14D52D8
	public static Vector2 Size(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14D5744
	internal static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector4> points, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x14D5C48
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
public static class BuiltinMaterials
{
	// Fields
	private static bool s_IsInitialized; // 0x0
	public const string faceShader = "Hidden/ProBuilder/FaceHighlight";
	public const string lineShader = "Hidden/ProBuilder/LineBillboard";
	public const string lineShaderMetal = "Hidden/ProBuilder/LineBillboardMetal";
	public const string pointShader = "Hidden/ProBuilder/PointBillboard";
	public const string wireShader = "Hidden/ProBuilder/FaceHighlight";
	public const string dotShader = "Hidden/ProBuilder/VertexShader";
	internal static readonly Color previewColor; // 0x4
	private static Shader s_SelectionPickerShader; // 0x18
	private static bool s_GeometryShadersSupported; // 0x20
	private static Material s_DefaultMaterial; // 0x28
	private static Material s_FacePickerMaterial; // 0x30
	private static Material s_VertexPickerMaterial; // 0x38
	private static Material s_EdgePickerMaterial; // 0x40
	private static Material s_UnityDefaultDiffuse; // 0x48
	private static Material s_UnlitVertexColorMaterial; // 0x50
	private static Material s_ShapePreviewMaterial; // 0x58
	private static string k_EdgePickerMaterial; // 0x60
	private static string k_FacePickerMaterial; // 0x68
	private static string k_VertexPickerMaterial; // 0x70
	private static string k_EdgePickerShader; // 0x78
	private static string k_FacePickerShader; // 0x80
	private static string k_VertexPickerShader; // 0x88

	// Methods

	// RVA: 0x14D5DD0
	private static void Init() { }

	// RVA: 0x14D6A64
	public static bool get_geometryShadersSupported() { }

	// RVA: 0x14D6AC4
	public static Material get_defaultMaterial() { }

	// RVA: 0x14D6B24
	internal static Shader get_selectionPickerShader() { }

	// RVA: 0x14D6B84
	internal static Material get_facePickerMaterial() { }

	// RVA: 0x14D6BE4
	internal static Material get_vertexPickerMaterial() { }

	// RVA: 0x14D6C44
	internal static Material get_edgePickerMaterial() { }

	// RVA: 0x14D6CA4
	internal static Material get_triggerMaterial() { }

	// RVA: 0x14D6DB4
	internal static Material get_colliderMaterial() { }

	// RVA: 0x14D6EC4
	internal static Material get_noDrawMaterial() { }

	// RVA: 0x14D6FD4
	internal static Material GetLegacyDiffuse() { }

	// RVA: 0x14D6740
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x14D7304
	internal static Material get_unlitVertexColor() { }

	// RVA: 0x14D7364
	internal static Material get_ShapePreviewMaterial() { }

	// RVA: 0x14D73C4
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal class ChangelogEntry
{
	// Fields
	private SemVer m_VersionInfo; // 0x10
	private string m_ReleaseNotes; // 0x18

	// Methods

	// RVA: 0x14D7514
	public SemVer get_versionInfo() { }

	// RVA: 0x14D751C
	public string get_releaseNotes() { }

	// RVA: 0x14D7524
	public void .ctor(SemVer version, string releaseNotes) { }

	// RVA: 0x14D7574
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal class Changelog
{
	// Fields
	private const string k_ChangelogEntryPattern = "(##\s\[[0-9]+\.[0-9]+\.[0-9]+(\-[a-zA-Z]+(\.[0-9]+)*)*\])";
	private const string k_VersionInfoPattern = "(?<=##\s\[).*(?=\])";
	private const string k_VersionDatePattern = "(?<=##\s\[.*\]\s-\s)[0-9-]*";
	private System.Collections.Generic.List<UnityEngine.ProBuilder.ChangelogEntry> m_Entries; // 0x10

	// Methods

	// RVA: 0x14D75DC
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.ChangelogEntry> get_entries() { }

	// RVA: 0x14D765C
	public void .ctor(string log) { }

	// RVA: 0x14D7904
	private ChangelogEntry CreateEntry(string version, string contents) { }

}

// Namespace: 
private enum OutCode
{
	// Fields
	public int value__; // 0x10
	public const OutCode Inside = 0;
	public const OutCode Left = 1;
	public const OutCode Right = 2;
	public const OutCode Bottom = 4;
	public const OutCode Top = 8;
}

// Namespace: UnityEngine.ProBuilder
internal static class Clipping
{
	// Methods

	// RVA: 0x14D7A8C
	private static OutCode ComputeOutCode(Rect rect, float x, float y) { }

	// RVA: 0x14D7AC8
	internal static bool RectContainsLineSegment(Rect rect, float x0, float y0, float x1, float y1) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ColliderBehaviour
{
	// Methods

	// RVA: 0x14D7CC4
	public override void Initialize() { }

	// RVA: 0x14D7F10
	public override void OnEnterPlayMode() { }

	// RVA: 0x14D7FF0
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x14D80D0
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal sealed class ColorPalette
{
	// Fields
	private Color <current>k__BackingField; // 0x18
	private System.Collections.Generic.List<UnityEngine.Color> m_Colors; // 0x28

	// Methods

	// RVA: 0x14D80F0
	public Color get_current() { }

	// RVA: 0x14D80FC
	public void set_current(Color value) { }

	// RVA: 0x14D8108
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Color> get_colors() { }

	// RVA: 0x14D8188
	public void SetColors(System.Collections.Generic.IEnumerable<UnityEngine.Color> colors) { }

	// RVA: 0x14D823C
	public void SetDefaultValues() { }

	// RVA: 0x14D84A4
	public Color get_Item(int i) { }

	// RVA: 0x14D8520
	public void set_Item(int i, Color value) { }

	// RVA: 0x14D85BC
	public int get_Count() { }

	// RVA: 0x14D8608
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class HSVColor
{
	// Fields
	public float h; // 0x10
	public float s; // 0x14
	public float v; // 0x18

	// Methods

	// RVA: 0x14D8610
	public void .ctor(float h, float s, float v) { }

	// RVA: 0x14D8658
	public void .ctor(float h, float s, float v, float sv_modifier) { }

	// RVA: 0x14D86AC
	public static HSVColor FromRGB(Color col) { }

	// RVA: 0x14D8918
	public override string ToString() { }

	// RVA: 0x14D89E4
	public float SqrDistance(HSVColor InColor) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class XYZColor
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x14D8A30
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x14D8A78
	public static XYZColor FromRGB(Color col) { }

	// RVA: 0x14D8BC0
	public static XYZColor FromRGB(float R, float G, float B) { }

	// RVA: 0x14D8E78
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class CIELabColor
{
	// Fields
	public float L; // 0x10
	public float a; // 0x14
	public float b; // 0x18

	// Methods

	// RVA: 0x14D8F44
	public void .ctor(float L, float a, float b) { }

	// RVA: 0x14D8F8C
	public static CIELabColor FromXYZ(XYZColor xyz) { }

	// RVA: 0x14D91EC
	public static CIELabColor FromRGB(Color col) { }

	// RVA: 0x14D9324
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ColorUtility
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.ProBuilder.CIELabColor> ColorNameLookup; // 0x0

	// Methods

	// RVA: 0x14D93F0
	private static bool approx(float lhs, float rhs) { }

	// RVA: 0x14D9458
	public static Color GetColor(Vector3 vec) { }

	// RVA: 0x14D8B48
	public static XYZColor RGBToXYZ(Color col) { }

	// RVA: 0x14D8C38
	public static XYZColor RGBToXYZ(float r, float g, float b) { }

	// RVA: 0x14D900C
	public static CIELabColor XYZToCIE_Lab(XYZColor xyz) { }

	// RVA: 0x14D9560
	public static float DeltaE(CIELabColor lhs, CIELabColor rhs) { }

	// RVA: 0x14D95A8
	public static Color HSVtoRGB(HSVColor hsv) { }

	// RVA: 0x14D9754
	public static Color HSVtoRGB(float h, float s, float v) { }

	// RVA: 0x14D872C
	public static HSVColor RGBtoHSV(Color color) { }

	// RVA: 0x14D9868
	public static string GetColorName(Color InColor) { }

	// RVA: 0x14D9C64
	private static CIELabColor CIELabFromRGB(float R, float G, float B, float Scale) { }

	// RVA: 0x14B4C64
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public struct Edge
{
	// Fields
	public int a; // 0x10
	public int b; // 0x14
	public static readonly Edge Empty; // 0x0

	// Methods

	// RVA: 0x14D9D34
	public void .ctor(int a, int b) { }

	// RVA: 0x14D9D3C
	public bool IsValid() { }

	// RVA: 0x14D9D60
	public override string ToString() { }

	// RVA: 0x14D9EBC
	public bool Equals(Edge other) { }

	// RVA: 0x14D9F00
	public override bool Equals(object obj) { }

	// RVA: 0x14DA004
	public override int GetHashCode() { }

	// RVA: 0x14DA028
	public static Edge op_Addition(Edge a, Edge b) { }

	// RVA: 0x14DA040
	public static Edge op_Subtraction(Edge a, Edge b) { }

	// RVA: 0x14DA058
	public static Edge op_Addition(Edge a, int b) { }

	// RVA: 0x14DA06C
	public static Edge op_Subtraction(Edge a, int b) { }

	// RVA: 0x14DA080
	public static bool op_Equality(Edge a, Edge b) { }

	// RVA: 0x14DA138
	public static bool op_Inequality(Edge a, Edge b) { }

	// RVA: 0x14DA238
	public static Edge Add(Edge a, Edge b) { }

	// RVA: 0x14DA2AC
	public static Edge Subtract(Edge a, Edge b) { }

	// RVA: 0x14DA320
	public bool Equals(Edge other, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x14DA4B8
	public bool Contains(int index) { }

	// RVA: 0x14DA4DC
	public bool Contains(Edge other) { }

	// RVA: 0x14DA508
	internal bool Contains(int index, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x14DA5F0
	internal static void GetIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x14DA94C
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_0
{
	// Fields
	public System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup; // 0x10

	// Methods

	// RVA: 0x14DB010
	public void .ctor() { }

	// RVA: 0x14DB3B0
	internal EdgeLookup <GetEdgeLookup>b__0(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder
public struct EdgeLookup
{
	// Fields
	private Edge m_Local; // 0x10
	private Edge m_Common; // 0x18

	// Methods

	// RVA: 0x14DA99C
	public Edge get_local() { }

	// RVA: 0x14DA9A4
	public void set_local(Edge value) { }

	// RVA: 0x14DA9AC
	public Edge get_common() { }

	// RVA: 0x14DA9B4
	public void set_common(Edge value) { }

	// RVA: 0x14DA9BC
	public void .ctor(Edge common, Edge local) { }

	// RVA: 0x14DA9C4
	public void .ctor(int cx, int cy, int x, int y) { }

	// RVA: 0x14DA9DC
	public bool Equals(EdgeLookup other) { }

	// RVA: 0x14DAA64
	public override bool Equals(object obj) { }

	// RVA: 0x14DAB8C
	public override int GetHashCode() { }

	// RVA: 0x14DAC0C
	public static bool op_Equality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x14DACA8
	public static bool op_Inequality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x14DAD48
	public override string ToString() { }

	// RVA: 0x14DAF28
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.EdgeLookup> GetEdgeLookup(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x14DB018
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> GetEdgeLookupHashSet(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x14DB540
	public void .ctor() { }

	// RVA: 0x14DC1C0
	internal Edge <GetSharedVertexHandleEdges>b__0(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class EdgeUtility
{
	// Methods

	// RVA: 0x14DB458
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetSharedVertexHandleEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x14DB548
	public static Edge GetSharedVertexHandleEdge(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x14DB600
	internal static Edge GetEdgeWithSharedVertexHandles(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x14DB6A0
	public static bool ValidateEdge(ProBuilderMesh mesh, Edge edge, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Edge>& validEdge) { }

	// RVA: 0x14DBBA4
	internal static bool Contains(Edge[] edges, Edge edge) { }

	// RVA: 0x14DBD00
	internal static bool Contains(Edge[] edges, int x, int y) { }

	// RVA: 0x14DBD9C
	internal static int IndexOf(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, Edge edge) { }

	// RVA: 0x14DBF80
	internal static int[] AllTriangles(Edge[] edges) { }

	// RVA: 0x14DC040
	internal static Face GetFace(ProBuilderMesh mesh, Edge edge) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class Entity
{
	// Fields
	private EntityType m_EntityType; // 0x20

	// Methods

	// RVA: 0x14DC1C8
	public EntityType get_entityType() { }

	// RVA: 0x14DC1D0
	public void Awake() { }

	// RVA: 0x14DC2C0
	public void SetEntity(EntityType t) { }

	// RVA: 0x14DC2C8
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal abstract class EntityBehaviour
{
	// Fields
	public bool manageVisibility; // 0x20

	// Methods

	// RVA: -1
	public abstract void Initialize() { }

	// RVA: -1
	public abstract void OnEnterPlayMode() { }

	// RVA: -1
	public abstract void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x14D7DFC
	protected void SetMaterial(Material material) { }

	// RVA: 0x14D80E0
	protected void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class Face
{
	// Fields
	private int[] m_Indexes; // 0x10
	private int m_SmoothingGroup; // 0x18
	private AutoUnwrapSettings m_Uv; // 0x1C
	private Material m_Material; // 0x40
	private int m_SubmeshIndex; // 0x48
	private bool m_ManualUV; // 0x4C
	internal int elementGroup; // 0x50
	private int m_TextureGroup; // 0x54
	private int[] m_DistinctIndexes; // 0x58
	private Edge[] m_Edges; // 0x60

	// Methods

	// RVA: 0x14DC2D0
	public bool get_manualUV() { }

	// RVA: 0x14DC2D8
	public void set_manualUV(bool value) { }

	// RVA: 0x14DC2E0
	public int get_textureGroup() { }

	// RVA: 0x14DC2E8
	public void set_textureGroup(int value) { }

	// RVA: 0x14DC2F0
	internal int[] get_indexesInternal() { }

	// RVA: 0x14DC2F8
	internal void set_indexesInternal(int[] value) { }

	// RVA: 0x14DC428
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_indexes() { }

	// RVA: 0x14DC4A8
	public void SetIndexes(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x14DBB08
	internal int[] get_distinctIndexesInternal() { }

	// RVA: 0x14DC6DC
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_distinctIndexes() { }

	// RVA: 0x14DC1AC
	internal Edge[] get_edgesInternal() { }

	// RVA: 0x14DCAF8
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.Edge> get_edges() { }

	// RVA: 0x14DCB88
	public int get_smoothingGroup() { }

	// RVA: 0x14DCB90
	public void set_smoothingGroup(int value) { }

	// RVA: 0x14DCB98
	public Material get_material() { }

	// RVA: 0x14DCBA0
	public void set_material(Material value) { }

	// RVA: 0x14DCBA8
	public int get_submeshIndex() { }

	// RVA: 0x14DCBB0
	public void set_submeshIndex(int value) { }

	// RVA: 0x14DCBB8
	public AutoUnwrapSettings get_uv() { }

	// RVA: 0x14DCBC8
	public void set_uv(AutoUnwrapSettings value) { }

	// RVA: 0x14DCBD8
	public int get_Item(int i) { }

	// RVA: 0x14DCC0C
	public void .ctor() { }

	// RVA: 0x14DCC34
	public void .ctor(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x14DCD3C
	internal void .ctor(int[] triangles, Material m, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x14DCDF4
	internal void .ctor(System.Collections.Generic.IEnumerable<System.Int32> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x14DCE9C
	public void .ctor(Face other) { }

	// RVA: 0x14DCECC
	public void CopyFrom(Face other) { }

	// RVA: 0x14DC3F4
	internal void InvalidateCache() { }

	// RVA: 0x14DC7E8
	private Edge[] CacheEdges() { }

	// RVA: 0x14DC5F0
	private int[] CacheDistinctIndexes() { }

	// RVA: 0x14DD02C
	public bool Contains(int a, int b, int c) { }

	// RVA: 0x14DD0CC
	public bool IsQuad() { }

	// RVA: 0x14DD120
	public int[] ToQuad() { }

	// RVA: 0x14DD510
	public override string ToString() { }

	// RVA: 0x14DD6FC
	public void ShiftIndexes(int offset) { }

	// RVA: 0x14DD7B4
	private int SmallestIndexValue() { }

	// RVA: 0x14DD864
	public void ShiftIndexesToZero() { }

	// RVA: 0x14DD9A8
	public void Reverse() { }

	// RVA: 0x14DDA1C
	internal static void GetIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x14DDDE8
	internal static void GetDistinctIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x14DE274
	internal bool TryGetNextEdge(Edge source, int index, Edge nextEdge, int nextIndex) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class FaceRebuildData
{
	// Fields
	public Face face; // 0x10
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices; // 0x18
	public System.Collections.Generic.List<System.Int32> sharedIndexes; // 0x20
	public System.Collections.Generic.List<System.Int32> sharedIndexesUV; // 0x28
	private int _appliedOffset; // 0x30

	// Methods

	// RVA: 0x14DE488
	public int Offset() { }

	// RVA: 0x14DE490
	public override string ToString() { }

	// RVA: 0x14DE554
	public static void Apply(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.FaceRebuildData> newFaces, ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x14DE6D0
	public static void Apply(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.FaceRebuildData> newFaces, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVertexLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedTextureLookup) { }

	// RVA: 0x14DEC68
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class HandleConstraint2D
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public static readonly HandleConstraint2D None; // 0x0

	// Methods

	// RVA: 0x14DEC70
	public void .ctor(int x, int y) { }

	// RVA: 0x14DECA8
	public HandleConstraint2D Inverse() { }

	// RVA: 0x14DED28
	public Vector2 Mask(Vector2 v) { }

	// RVA: 0x14DED40
	public Vector2 InverseMask(Vector2 v) { }

	// RVA: 0x14DED64
	public static bool op_Equality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x14DEDAC
	public static bool op_Inequality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x14DEDF4
	public override int GetHashCode() { }

	// RVA: 0x14DEDFC
	public override bool Equals(object o) { }

	// RVA: 0x14DEE94
	public override string ToString() { }

	// RVA: 0x14DEFF0
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
public enum HandleOrientation
{
	// Fields
	public int value__; // 0x10
	public const HandleOrientation World = 0;
	public const HandleOrientation ActiveObject = 1;
	public const HandleOrientation ActiveElement = 2;
}

// Namespace: UnityEngine.ProBuilder
public static class HandleUtility
{
	// Methods

	// RVA: 0x14DF064
	internal static Vector3 ScreenToGuiPoint(Camera camera, Vector3 point, float pixelsPerPoint) { }

	// RVA: 0x14DF0B8
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, RaycastHit hit, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x14DF0F8
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, RaycastHit hit, float distance, CullingMode cullingMode, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x14DFB24
	internal static bool FaceRaycastBothCullModes(Ray worldRay, ProBuilderMesh mesh, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.Vector3>& back, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.Vector3>& front) { }

	// RVA: 0x14E0440
	internal static bool FaceRaycast(Ray InWorldRay, ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.RaycastHit>& hits, CullingMode cullingMode, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x14E0BE8
	internal static Ray InverseTransformRay(Transform transform, Ray InWorldRay) { }

	// RVA: 0x14E0DBC
	internal static bool MeshRaycast(Ray InWorldRay, GameObject gameObject, RaycastHit hit, float distance) { }

	// RVA: 0x14E0F74
	internal static bool MeshRaycast(Ray InRay, Vector3[] mesh, int[] triangles, RaycastHit hit, float distance) { }

	// RVA: 0x14E1440
	internal static bool PointIsOccluded(Camera cam, ProBuilderMesh pb, Vector3 worldPoint) { }

	// RVA: 0x14E171C
	public static Quaternion GetRotation(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x14E1E18
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x14E1F88
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x14E2684
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x14E27F4
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x14E28E4
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x14E2A34
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x14E2B7C
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x14E328C
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x14E3384
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

}

// Namespace: UnityEngine.ProBuilder
internal interface IHasDefault
{
	// Methods

	// RVA: -1
	public abstract void SetDefaultValues() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public string valid; // 0x10

	// Methods

	// RVA: 0x14E3A30
	public void .ctor() { }

	// RVA: 0x14E3A38
	internal bool <TryParseColor>b__0(Char c) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class InternalUtility
{
	// Methods

	// RVA: 0x30A52D0
	public static T[] GetComponents(GameObject go) { }

	// RVA: 0x30A52D0
	public static T[] GetComponents(System.Collections.Generic.IEnumerable<UnityEngine.Transform> transforms) { }

	// RVA: 0x14E3440
	public static GameObject EmptyGameObjectWithTransform(Transform t) { }

	// RVA: 0x14E3534
	public static GameObject MeshGameObjectWithTransform(string name, Transform t, Mesh mesh, Material mat, bool inheritParent) { }

	// RVA: 0x315B3A8
	public static T NextEnumValue(T current) { }

	// RVA: 0x14E365C
	public static string ControlKeyString(Char character) { }

	// RVA: 0x14E37B0
	public static bool TryParseColor(string value, Color col) { }

	// RVA: 0x315B3A8
	public static T DemandComponent(Component component) { }

	// RVA: 0x315B3A8
	public static T DemandComponent(GameObject gameObject) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec2
{
	// Fields
	public Vector2 value; // 0x10

	// Methods

	// RVA: 0x14E3A58
	public float get_x() { }

	// RVA: 0x14E3A60
	public float get_y() { }

	// RVA: 0x14E3A68
	public void .ctor(Vector2 vector) { }

	// RVA: 0x14E3A70
	public override string ToString() { }

	// RVA: 0x14E3B18
	public static bool op_Equality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x14E3CC8
	public static bool op_Inequality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x14E3B44
	public bool Equals(IntVec2 p) { }

	// RVA: 0x14E3D64
	public bool Equals(Vector2 p) { }

	// RVA: 0x14E3EE8
	public override bool Equals(object b) { }

	// RVA: 0x14E3FD4
	public override int GetHashCode() { }

	// RVA: 0x14E3CF8
	private static int round(float v) { }

	// RVA: 0x14E3FE0
	public static Vector2 op_Implicit(IntVec2 p) { }

	// RVA: 0x14E3FE4
	public static IntVec2 op_Implicit(Vector2 p) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec3
{
	// Fields
	public Vector3 value; // 0x10

	// Methods

	// RVA: 0x14E3FE8
	public float get_x() { }

	// RVA: 0x14E3FF0
	public float get_y() { }

	// RVA: 0x14E3FF8
	public float get_z() { }

	// RVA: 0x14E4000
	public void .ctor(Vector3 vector) { }

	// RVA: 0x14E400C
	public override string ToString() { }

	// RVA: 0x14E40D8
	public static bool op_Equality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x14E4324
	public static bool op_Inequality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x14E410C
	public bool Equals(IntVec3 p) { }

	// RVA: 0x14E43C8
	public bool Equals(Vector3 p) { }

	// RVA: 0x14E45E0
	public override bool Equals(object b) { }

	// RVA: 0x14E46D4
	public override int GetHashCode() { }

	// RVA: 0x14E435C
	private static int round(float v) { }

	// RVA: 0x14E46E4
	public static Vector3 op_Implicit(IntVec3 p) { }

	// RVA: 0x14E46E8
	public static IntVec3 op_Implicit(Vector3 p) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec4
{
	// Fields
	public Vector4 value; // 0x10

	// Methods

	// RVA: 0x14E46EC
	public float get_x() { }

	// RVA: 0x14E46F4
	public float get_y() { }

	// RVA: 0x14E46FC
	public float get_z() { }

	// RVA: 0x14E4704
	public float get_w() { }

	// RVA: 0x14E470C
	public void .ctor(Vector4 vector) { }

	// RVA: 0x14E4718
	public override string ToString() { }

	// RVA: 0x14E48F8
	public static bool op_Equality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x14E4BD0
	public static bool op_Inequality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x14E4930
	public bool Equals(IntVec4 p) { }

	// RVA: 0x14E4C78
	public bool Equals(Vector4 p) { }

	// RVA: 0x14E4F18
	public override bool Equals(object b) { }

	// RVA: 0x14E500C
	public override int GetHashCode() { }

	// RVA: 0x14E4C0C
	private static int round(float v) { }

	// RVA: 0x14E501C
	public static Vector4 op_Implicit(IntVec4 p) { }

	// RVA: 0x14E5020
	public static IntVec4 op_Implicit(Vector4 p) { }

}

// Namespace: UnityEngine.ProBuilder
internal enum LogLevel
{
	// Fields
	public int value__; // 0x10
	public const LogLevel None = 0;
	public const LogLevel Error = 1;
	public const LogLevel Warning = 2;
	public const LogLevel Info = 4;
	public const LogLevel Default = 3;
	public const LogLevel All = 255;
}

// Namespace: UnityEngine.ProBuilder
internal enum LogOutput
{
	// Fields
	public int value__; // 0x10
	public const LogOutput None = 0;
	public const LogOutput Console = 1;
	public const LogOutput File = 2;
}

// Namespace: UnityEngine.ProBuilder
internal static class Log
{
	// Fields
	public const string k_ProBuilderLogFileName = "ProBuilderLog.txt";
	private static System.Collections.Generic.Stack<UnityEngine.ProBuilder.LogLevel> s_logStack; // 0x0
	private static LogLevel s_LogLevel; // 0x8
	private static LogOutput s_Output; // 0xC
	private static string s_LogFilePath; // 0x10

	// Methods

	// RVA: 0x14E5024
	public static void PushLogLevel(LogLevel level) { }

	// RVA: 0x14E50E8
	public static void PopLogLevel() { }

	// RVA: 0x14E519C
	public static void SetLogLevel(LogLevel level) { }

	// RVA: 0x14E5228
	public static void SetOutput(LogOutput output) { }

	// RVA: 0x14E52B4
	public static void SetLogFile(string path) { }

	// RVA: 0x315B3A8
	public static void Debug(T value) { }

	// RVA: 0x14E5320
	public static void Debug(string message) { }

	// RVA: 0x14E54C0
	public static void Debug(string format, object[] values) { }

	// RVA: 0x14E54C4
	public static void Info(string format, object[] values) { }

	// RVA: 0x14E55D8
	public static void Info(string message) { }

	// RVA: 0x14E5698
	public static void Warning(string format, object[] values) { }

	// RVA: 0x14E57AC
	public static void Warning(string message) { }

	// RVA: 0x14E586C
	public static void Error(string format, object[] values) { }

	// RVA: 0x14D69A4
	public static void Error(string message) { }

	// RVA: 0x315B3A8
	internal static void Watch(T key, K value) { }

	// RVA: 0x14E53A8
	private static void DoPrint(string message, LogType type) { }

	// RVA: 0x14E5AC4
	private static void PrintToFile(string message, string path) { }

	// RVA: 0x14E5EC8
	public static void ClearLogFile() { }

	// RVA: 0x14E5980
	private static void PrintToConsole(string message, LogType type) { }

	// RVA: 0x315B3A8
	internal static void NotNull(T obj, string message) { }

	// RVA: 0x14E5F94
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class MaterialUtility
{
	// Fields
	internal static System.Collections.Generic.List<UnityEngine.Material> s_MaterialArray; // 0x0

	// Methods

	// RVA: 0x14E606C
	internal static int GetMaterialCount(Renderer renderer) { }

	// RVA: 0x14E6194
	internal static Material GetSharedMaterial(Renderer renderer, int index) { }

	// RVA: 0x14E6350
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
public static class Math
{
	// Fields
	public const float phi = 1.61803;
	private const float k_FltEpsilon = 1.4013e-45;
	private const float k_FltCompareEpsilon = 0.0001;
	internal const float handleEpsilon = 0.0001;
	private static Vector3 tv1; // 0x0
	private static Vector3 tv2; // 0xC
	private static Vector3 tv3; // 0x18
	private static Vector3 tv4; // 0x24

	// Methods

	// RVA: 0x14E63EC
	internal static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin) { }

	// RVA: 0x14E6440
	internal static Vector2 PointInEllipseCircumference(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, Vector2 tangent) { }

	// RVA: 0x14E6580
	internal static Vector2 PointInEllipseCircumferenceWithConstantAngle(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, Vector2 tangent) { }

	// RVA: 0x14E6704
	internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle) { }

	// RVA: 0x14E6770
	internal static float SignedAngle(Vector2 a, Vector2 b) { }

	// RVA: 0x14E688C
	public static float SqrDistance(Vector3 a, Vector3 b) { }

	// RVA: 0x14E68B0
	public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z) { }

	// RVA: 0x14E6964
	internal static float PolygonArea(Vector3[] vertices, int[] indexes) { }

	// RVA: 0x14E6C10
	internal static Vector2 RotateAroundPoint(Vector2 v, Vector2 origin, float theta) { }

	// RVA: 0x14E6C7C
	public static Vector2 ScaleAroundPoint(Vector2 v, Vector2 origin, Vector2 scale) { }

	// RVA: 0x14E6C98
	internal static Vector2 Perpendicular(Vector2 value) { }

	// RVA: 0x14E6CA8
	public static Vector2 ReflectPoint(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x14E6E54
	internal static float SqrDistanceRayPoint(Ray ray, Vector3 point) { }

	// RVA: 0x14E6EA8
	public static float DistancePointLineSegment(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x14E7084
	public static float DistancePointLineSegment(Vector3 point, Vector3 lineStart, Vector3 lineEnd) { }

	// RVA: 0x14E7330
	public static Vector3 GetNearestPointRayRay(Ray a, Ray b) { }

	// RVA: 0x14E7378
	internal static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd) { }

	// RVA: 0x14E74E4
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 intersect) { }

	// RVA: 0x14D4AB8
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

	// RVA: 0x14E75FC
	internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, int[] indexes) { }

	// RVA: 0x14E79B4
	internal static bool PointInPolygon(Vector2[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x14E7C7C
	internal static bool PointInPolygon(Vector3[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x14E8060
	internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b) { }

	// RVA: 0x14E8064
	internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b) { }

	// RVA: 0x14DF880
	public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, float OutDistance, Vector3 OutPoint) { }

	// RVA: 0x14E1200
	internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, float distance, Vector3 normal) { }

	// RVA: 0x14E80B8
	public static float Secant(float x) { }

	// RVA: 0x14E80D4
	public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0x14E82B8
	internal static Vector3 Normal(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14E8B64
	public static Vector3 Normal(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x14E2228
	public static Normal NormalTangentBitangent(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x14E8DF0
	internal static bool IsCardinalAxis(Vector3 v, float epsilon) { }

	// RVA: 0x14E9098
	internal static Vector2 DivideBy(Vector2 v, Vector2 o) { }

	// RVA: 0x14E90A4
	internal static Vector3 DivideBy(Vector3 v, Vector3 o) { }

	// RVA: 0x315B3A8
	internal static T Max(T[] array) { }

	// RVA: 0x315B3A8
	internal static T Min(T[] array) { }

	// RVA: 0x14E90B4
	internal static float LargestValue(Vector3 v) { }

	// RVA: 0x14E90D0
	internal static float LargestValue(Vector2 v) { }

	// RVA: 0x14E90DC
	internal static Vector2 SmallestVector2(Vector2[] v) { }

	// RVA: 0x14E912C
	internal static Vector2 SmallestVector2(Vector2[] v, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14E9488
	internal static Vector2 LargestVector2(Vector2[] v) { }

	// RVA: 0x14E94D8
	internal static Vector2 LargestVector2(Vector2[] v, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14E2CB4
	internal static Bounds GetBounds(Vector3[] positions, System.Collections.Generic.IList<System.Int32> indices) { }

	// RVA: 0x14E9834
	public static Vector2 Average(System.Collections.Generic.IList<UnityEngine.Vector2> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14E9BBC
	public static Vector3 Average(System.Collections.Generic.IList<UnityEngine.Vector3> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14EA184
	public static Vector4 Average(System.Collections.Generic.IList<UnityEngine.Vector4> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14EA754
	internal static Vector3 InvertScaleVector(Vector3 scaleVector) { }

	// RVA: 0x14EA784
	internal static bool Approx2(Vector2 a, Vector2 b, float delta) { }

	// RVA: 0x14EA7A0
	internal static bool Approx3(Vector3 a, Vector3 b, float delta) { }

	// RVA: 0x14EA7D0
	internal static bool Approx4(Vector4 a, Vector4 b, float delta) { }

	// RVA: 0x14EA810
	internal static bool ApproxC(Color a, Color b, float delta) { }

	// RVA: 0x14EA850
	internal static bool Approx(float a, float b, float delta) { }

	// RVA: 0x14E633C
	public static int Clamp(int value, int lowerBound, int upperBound) { }

	// RVA: 0x14EA864
	internal static Vector3 Abs(Vector3 v) { }

	// RVA: 0x14EA874
	internal static Vector3 Sign(Vector3 v) { }

	// RVA: 0x14EA898
	internal static float Sum(Vector3 v) { }

	// RVA: 0x14E8084
	internal static void Cross(Vector3 a, Vector3 b, Vector3 res) { }

	// RVA: 0x14E806C
	internal static void Subtract(Vector3 a, Vector3 b, Vector3 res) { }

	// RVA: 0x14EA8B0
	internal static bool IsNumber(float value) { }

	// RVA: 0x14EA8C4
	internal static bool IsNumber(Vector2 value) { }

	// RVA: 0x14EA8E4
	internal static bool IsNumber(Vector3 value) { }

	// RVA: 0x14EA910
	internal static bool IsNumber(Vector4 value) { }

	// RVA: 0x14EA948
	internal static float MakeNonZero(float value, float min) { }

	// RVA: 0x14EA978
	internal static Vector4 FixNaN(Vector4 value) { }

	// RVA: 0x14EA9B4
	internal static Vector2 EnsureUnitVector(Vector2 value) { }

	// RVA: 0x14EAB18
	internal static Vector3 EnsureUnitVector(Vector3 value) { }

	// RVA: 0x14EAC94
	internal static Vector4 EnsureUnitVector(Vector4 value) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class MeshHandle
{
	// Fields
	private Transform m_Transform; // 0x10
	private Mesh m_Mesh; // 0x18

	// Methods

	// RVA: 0x14EACF0
	public Mesh get_mesh() { }

	// RVA: 0x14EACF8
	public void .ctor(Transform transform, Mesh mesh) { }

	// RVA: 0x14EAD48
	public void DrawMeshNow(int submeshIndex) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshHandles.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__9_0; // 0x8
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__10_0; // 0x10

	// Methods

	// RVA: 0x14EDE60
	private static void .cctor() { }

	// RVA: 0x14EDECC
	public void .ctor() { }

	// RVA: 0x14EDED4
	internal System.Collections.Generic.IEnumerable<System.Int32> <CreateFaceMesh>b__9_0(Face x) { }

	// RVA: 0x14EDEF0
	internal System.Collections.Generic.IEnumerable<System.Int32> <CreateFaceMeshFromFaces>b__10_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class MeshHandles
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.Vector3> s_Vector2List; // 0x0
	private static System.Collections.Generic.List<UnityEngine.Vector3> s_Vector3List; // 0x8
	private static System.Collections.Generic.List<UnityEngine.Vector4> s_Vector4List; // 0x10
	private static System.Collections.Generic.List<System.Int32> s_IndexList; // 0x18
	private static System.Collections.Generic.List<System.Int32> s_SharedVertexIndexList; // 0x20
	private static readonly Vector2 k_Billboard0; // 0x28
	private static readonly Vector2 k_Billboard1; // 0x30
	private static readonly Vector2 k_Billboard2; // 0x38
	private static readonly Vector2 k_Billboard3; // 0x40

	// Methods

	// RVA: 0x14EAEA4
	internal static void CreateFaceMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x14EB018
	internal static void CreateFaceMeshFromFaces(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, Mesh target) { }

	// RVA: 0x14EB180
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x14EB53C
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target, Edge[] edges) { }

	// RVA: 0x14EB7E8
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x14EB9EC
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14EBB38
	private static void CreatePointMesh(Vector3[] positions, System.Collections.Generic.IList<System.Int32> indexes, Mesh target) { }

	// RVA: 0x14EC554
	internal static void CreatePointBillboardMesh(System.Collections.Generic.IList<UnityEngine.Vector3> positions, Mesh target) { }

	// RVA: 0x14EBCF0
	private static void CreatePointBillboardMesh(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Mesh target) { }

	// RVA: 0x14ECCB8
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x14ED33C
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target, System.Collections.Generic.ICollection<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x14EDCA0
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshUtility.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Vertex,System.Int32>,System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Vertex>> <>9__11_0; // 0x8

	// Methods

	// RVA: 0x14F284C
	private static void .cctor() { }

	// RVA: 0x14F28B8
	public void .ctor() { }

	// RVA: 0x14F28C0
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Vertex> <CollapseSharedVertices>b__11_0(System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Vertex,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder
public static class MeshUtility
{
	// Methods

	// RVA: 0x14EDF0C
	internal static Vertex[] GeneratePerTriangleMesh(Mesh mesh) { }

	// RVA: 0x14EE9C4
	public static void GenerateTangent(Mesh mesh) { }

	// RVA: 0x14EEF84
	public static Mesh DeepCopy(Mesh source) { }

	// RVA: 0x14EEFF4
	public static void CopyTo(Mesh source, Mesh destination) { }

	// RVA: 0x315B3A8
	internal static T GetMeshChannel(GameObject gameObject, System.Func<UnityEngine.Mesh,T> attributeGetter) { }

	// RVA: 0x30A96C4
	private static void PrintAttribute(StringBuilder sb, string title, System.Collections.Generic.IEnumerable<T> attrib, string fmt) { }

	// RVA: 0x14EF49C
	public static string Print(Mesh mesh) { }

	// RVA: 0x14F0078
	public static UInt32 GetIndexCount(Mesh mesh) { }

	// RVA: 0x14F0174
	public static UInt32 GetPrimitiveCount(Mesh mesh) { }

	// RVA: 0x14F02D0
	public static void Compile(ProBuilderMesh probuilderMesh, Mesh targetMesh, MeshTopology preferredTopology) { }

	// RVA: 0x14EE3B4
	public static Vertex[] GetVertices(Mesh mesh) { }

	// RVA: 0x14F0F74
	public static void CollapseSharedVertices(Mesh mesh, Vertex[] vertices) { }

	// RVA: 0x14F15DC
	public static void FitToSize(ProBuilderMesh mesh, Bounds currentSize, Vector3 sizeToFit) { }

	// RVA: 0x14F19D0
	internal static string SanityCheck(ProBuilderMesh mesh) { }

	// RVA: 0x14F0064
	internal static string SanityCheck(Mesh mesh) { }

	// RVA: 0x14F20C8
	internal static string SanityCheck(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x14F238C
	internal static bool IsUsedInParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x14F255C
	internal static void RestoreParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x14F2640
	internal static Bounds GetBounds(ProBuilderMesh mesh) { }

}

// Namespace: UnityEngine.ProBuilder
public struct Normal
{
	// Fields
	private Vector3 <normal>k__BackingField; // 0x10
	private Vector4 <tangent>k__BackingField; // 0x1C
	private Vector3 <bitangent>k__BackingField; // 0x2C

	// Methods

	// RVA: 0x14F2914
	public Vector3 get_normal() { }

	// RVA: 0x14F2920
	public void set_normal(Vector3 value) { }

	// RVA: 0x14F292C
	public Vector4 get_tangent() { }

	// RVA: 0x14F2938
	public void set_tangent(Vector4 value) { }

	// RVA: 0x14F2944
	public Vector3 get_bitangent() { }

	// RVA: 0x14F2950
	public void set_bitangent(Vector3 value) { }

	// RVA: 0x14F295C
	public override bool Equals(object obj) { }

	// RVA: 0x14F2AA4
	public override int GetHashCode() { }

	// RVA: 0x14F2A04
	public bool Equals(Normal other) { }

	// RVA: 0x14F2B14
	public static bool op_Equality(Normal a, Normal b) { }

	// RVA: 0x14F2B44
	public static bool op_Inequality(Normal a, Normal b) { }

}

// Namespace: UnityEngine.ProBuilder
public static class Normals
{
	// Fields
	private static Vector3[] s_SmoothAvg; // 0x0
	private static float[] s_SmoothAvgCount; // 0x8
	private static int[] s_CachedIntArray; // 0x10

	// Methods

	// RVA: 0x14F2C24
	private static void ClearIntArray(int count) { }

	// RVA: 0x14F2D48
	public static void CalculateTangents(ProBuilderMesh mesh) { }

	// RVA: 0x14F33C0
	private static void CalculateHardNormals(ProBuilderMesh mesh) { }

	// RVA: 0x14F39C8
	public static void CalculateNormals(ProBuilderMesh mesh) { }

	// RVA: 0x14F3FCC
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ObjectPool<T0>
{
	// Fields
	private bool m_IsDisposed; // 0x0
	private System.Collections.Generic.Queue<T> m_Pool; // 0x0
	public int desiredSize; // 0x0
	public System.Func<T> constructor; // 0x0
	public System.Action<T> destructor; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public void .ctor(int initialSize, int desiredSize, System.Func<T> constructor, System.Action<T> destructor, bool lazyInitialization) { }

	// RVA: 0x315B3A8
	public T Dequeue() { }

	// RVA: 0x315B3A8
	public void Enqueue(T obj) { }

	// RVA: 0x30A2378
	public void Empty() { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A2404
	private void Dispose(bool disposing) { }

}

// Namespace: UnityEngine.ProBuilder
public enum PivotPoint
{
	// Fields
	public int value__; // 0x10
	public const PivotPoint Center = 0;
	public const PivotPoint IndividualOrigins = 1;
	public const PivotPoint ActiveElement = 2;
}

// Namespace: 
internal enum PolyEditMode
{
	// Fields
	public int value__; // 0x10
	public const PolyEditMode None = 0;
	public const PolyEditMode Path = 1;
	public const PolyEditMode Height = 2;
	public const PolyEditMode Edit = 3;
}

// Namespace: UnityEngine.ProBuilder
public sealed class PolyShape
{
	// Fields
	private ProBuilderMesh m_Mesh; // 0x20
	internal System.Collections.Generic.List<UnityEngine.Vector3> m_Points; // 0x28
	private float m_Extrude; // 0x30
	private PolyEditMode m_EditMode; // 0x34
	private bool m_FlipNormals; // 0x38
	internal bool isOnGrid; // 0x39

	// Methods

	// RVA: 0x14F40BC
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Vector3> get_controlPoints() { }

	// RVA: 0x14F413C
	public void SetControlPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }

	// RVA: 0x14F41A4
	public float get_extrude() { }

	// RVA: 0x14F41AC
	public void set_extrude(float value) { }

	// RVA: 0x14F41B4
	internal PolyEditMode get_polyEditMode() { }

	// RVA: 0x14F41BC
	internal void set_polyEditMode(PolyEditMode value) { }

	// RVA: 0x14F41C4
	public bool get_flipNormals() { }

	// RVA: 0x14F41CC
	public void set_flipNormals(bool value) { }

	// RVA: 0x14F41D4
	internal ProBuilderMesh get_mesh() { }

	// RVA: 0x14F42CC
	internal void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x14F42D4
	private bool IsSnapEnabled() { }

	// RVA: 0x14F42DC
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class PreferenceDictionary
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,System.Boolean> m_Bool; // 0x18
	private System.Collections.Generic.Dictionary<System.String,System.Int32> m_Int; // 0x20
	private System.Collections.Generic.Dictionary<System.String,System.Single> m_Float; // 0x28
	private System.Collections.Generic.Dictionary<System.String,System.String> m_String; // 0x30
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.Color> m_Color; // 0x38
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> m_Material; // 0x40
	private System.Collections.Generic.List<System.String> m_Bool_keys; // 0x48
	private System.Collections.Generic.List<System.String> m_Int_keys; // 0x50
	private System.Collections.Generic.List<System.String> m_Float_keys; // 0x58
	private System.Collections.Generic.List<System.String> m_String_keys; // 0x60
	private System.Collections.Generic.List<System.String> m_Color_keys; // 0x68
	private System.Collections.Generic.List<System.String> m_Material_keys; // 0x70
	private System.Collections.Generic.List<System.Boolean> m_Bool_values; // 0x78
	private System.Collections.Generic.List<System.Int32> m_Int_values; // 0x80
	private System.Collections.Generic.List<System.Single> m_Float_values; // 0x88
	private System.Collections.Generic.List<System.String> m_String_values; // 0x90
	private System.Collections.Generic.List<UnityEngine.Color> m_Color_values; // 0x98
	private System.Collections.Generic.List<UnityEngine.Material> m_Material_values; // 0xA0

	// Methods

	// RVA: 0x14F4370
	public void OnBeforeSerialize() { }

	// RVA: 0x14F471C
	public void OnAfterDeserialize() { }

	// RVA: 0x14F4B30
	public void SetDefaultValues() { }

	// RVA: 0x14F4C38
	public bool HasKey(string key) { }

	// RVA: 0x30A1344
	public bool HasKey(string key) { }

	// RVA: 0x14F4D8C
	public void DeleteKey(string key) { }

	// RVA: 0x315B3A8
	public T Get(string key, T fallback) { }

	// RVA: 0x315B3A8
	public void Set(string key, T value) { }

	// RVA: 0x14F4FD0
	public bool GetBool(string key, bool fallback) { }

	// RVA: 0x14F5060
	public int GetInt(string key, int fallback) { }

	// RVA: 0x14F50E8
	public float GetFloat(string key, float fallback) { }

	// RVA: 0x14F5178
	public string GetString(string key, string fallback) { }

	// RVA: 0x14F5200
	public Color GetColor(string key, Color fallback) { }

	// RVA: 0x14F52B4
	public Material GetMaterial(string key, Material fallback) { }

	// RVA: 0x14F533C
	public void SetBool(string key, bool value) { }

	// RVA: 0x14F53B8
	public void SetInt(string key, int value) { }

	// RVA: 0x14F5434
	public void SetFloat(string key, float value) { }

	// RVA: 0x14F54B8
	public void SetString(string key, string value) { }

	// RVA: 0x14F5524
	public void SetColor(string key, Color value) { }

	// RVA: 0x14F55C0
	public void SetMaterial(string key, Material value) { }

	// RVA: 0x14F562C
	public System.Collections.Generic.Dictionary<System.String,System.Boolean> GetBoolDictionary() { }

	// RVA: 0x14F5634
	public System.Collections.Generic.Dictionary<System.String,System.Int32> GetIntDictionary() { }

	// RVA: 0x14F563C
	public System.Collections.Generic.Dictionary<System.String,System.Single> GetFloatDictionary() { }

	// RVA: 0x14F5644
	public System.Collections.Generic.Dictionary<System.String,System.String> GetStringDictionary() { }

	// RVA: 0x14F564C
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.Color> GetColorDictionary() { }

	// RVA: 0x14F5654
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> GetMaterialDictionary() { }

	// RVA: 0x14F565C
	public void Clear() { }

	// RVA: 0x14F5740
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class PreferenceKeys
{
	// Fields
	public const string pluginTitle = "ProBuilder";
	internal const float k_MaxPointDistanceFromControl = 20;
	internal const Char DEGREE_SYMBOL = 176;
	internal const Char CMD_SUPER = 8984;
	internal const Char CMD_SHIFT = 8679;
	internal const Char CMD_OPTION = 8997;
	internal const Char CMD_ALT = 9095;
	internal const Char CMD_DELETE = 9003;
	internal static readonly Color proBuilderBlue; // 0x0
	internal static readonly Color proBuilderLightGray; // 0x10
	internal static readonly Color proBuilderDarkGray; // 0x20
	public const int menuEditor = 100;
	public const int menuSelection = 200;
	public const int menuGeometry = 200;
	public const int menuActions = 300;
	public const int menuMaterialColors = 400;
	public const int menuVertexColors = 400;
	public const int menuRepair = 600;
	public const int menuMisc = 600;
	public const int menuExport = 800;
	internal const string pbDefaultEditLevel = "pbDefaultEditLevel";
	internal const string pbDefaultSelectionMode = "pbDefaultSelectionMode";
	internal const string pbHandleAlignment = "pbHandleAlignment";
	internal const string pbVertexColorTool = "pbVertexColorTool";
	internal const string pbToolbarLocation = "pbToolbarLocation";
	internal const string pbDefaultEntity = "pbDefaultEntity";
	internal const string pbExtrudeMethod = "pbExtrudeMethod";
	internal const string pbDefaultStaticFlags = "pbDefaultStaticFlags";
	internal const string pbSelectedFaceColor = "pbDefaultFaceColor";
	internal const string pbWireframeColor = "pbDefaultEdgeColor";
	internal const string pbUnselectedEdgeColor = "pbUnselectedEdgeColor";
	internal const string pbSelectedEdgeColor = "pbSelectedEdgeColor";
	internal const string pbSelectedVertexColor = "pbDefaultSelectedVertexColor";
	internal const string pbUnselectedVertexColor = "pbDefaultVertexColor";
	internal const string pbPreselectionColor = "pbPreselectionColor";
	internal const string pbDefaultOpenInDockableWindow = "pbDefaultOpenInDockableWindow";
	internal const string pbEditorPrefVersion = "pbEditorPrefVersion";
	internal const string pbEditorShortcutsVersion = "pbEditorShortcutsVersion";
	internal const string pbDefaultCollider = "pbDefaultCollider";
	internal const string pbForceConvex = "pbForceConvex";
	internal const string pbVertexColorPrefs = "pbVertexColorPrefs";
	internal const string pbShowEditorNotifications = "pbShowEditorNotifications";
	internal const string pbDragCheckLimit = "pbDragCheckLimit";
	internal const string pbForceVertexPivot = "pbForceVertexPivot";
	internal const string pbForceGridPivot = "pbForceGridPivot";
	internal const string pbManifoldEdgeExtrusion = "pbManifoldEdgeExtrusion";
	internal const string pbPerimeterEdgeBridgeOnly = "pbPerimeterEdgeBridgeOnly";
	internal const string pbPBOSelectionOnly = "pbPBOSelectionOnly";
	internal const string pbCloseShapeWindow = "pbCloseShapeWindow";
	internal const string pbUVEditorFloating = "pbUVEditorFloating";
	internal const string pbUVMaterialPreview = "pbUVMaterialPreview";
	internal const string pbShowSceneToolbar = "pbShowSceneToolbar";
	internal const string pbNormalizeUVsOnPlanarProjection = "pbNormalizeUVsOnPlanarProjection";
	internal const string pbStripProBuilderOnBuild = "pbStripProBuilderOnBuild";
	internal const string pbDisableAutoUV2Generation = "pbDisableAutoUV2Generation";
	internal const string pbShowSceneInfo = "pbShowSceneInfo";
	internal const string pbEnableBackfaceSelection = "pbEnableBackfaceSelection";
	internal const string pbVertexPaletteDockable = "pbVertexPaletteDockable";
	internal const string pbExtrudeAsGroup = "pbExtrudeAsGroup";
	internal const string pbUniqueModeShortcuts = "pbUniqueModeShortcuts";
	internal const string pbMaterialEditorFloating = "pbMaterialEditorFloating";
	internal const string pbShapeWindowFloating = "pbShapeWindowFloating";
	internal const string pbIconGUI = "pbIconGUI";
	internal const string pbShiftOnlyTooltips = "pbShiftOnlyTooltips";
	internal const string pbDrawAxisLines = "pbDrawAxisLines";
	internal const string pbCollapseVertexToFirst = "pbCollapseVertexToFirst";
	internal const string pbMeshesAreAssets = "pbMeshesAreAssets";
	internal const string pbElementSelectIsHamFisted = "pbElementSelectIsHamFisted";
	internal const string pbFillHoleSelectsEntirePath = "pbFillHoleSelectsEntirePath";
	internal const string pbDetachToNewObject = "pbDetachToNewObject";
	internal const string pbPreserveFaces = "pbPreserveFaces";
	internal const string pbDragSelectWholeElement = "pbDragSelectWholeElement";
	internal const string pbShowPreselectionHighlight = "pbShowPreselectionHighlight";
	internal const string pbRectSelectMode = "pbRectSelectMode";
	internal const string pbDragSelectMode = "pbDragSelectMode";
	internal const string pbShadowCastingMode = "pbShadowCastingMode";
	internal const string pbEnableExperimental = "pbEnableExperimental";
	internal const string pbCheckForProBuilderUpdates = "pbCheckForProBuilderUpdates";
	internal const string pbManageLightmappingStaticFlag = "pbManageLightmappingStaticFlag";
	internal const string pbShowMissingLightmapUvWarning = "pb_Lightmapping::showMissingLightmapUvWarning";
	internal const string pbSelectedFaceDither = "pbSelectedFaceDither";
	internal const string pbUseUnityColors = "pbUseUnityColors";
	internal const string pbVertexHandleSize = "pbVertexHandleSize";
	internal const string pbUVGridSnapValue = "pbUVGridSnapValue";
	internal const string pbUVWeldDistance = "pbUVWeldDistance";
	internal const string pbLineHandleSize = "pbLineHandleSize";
	internal const string pbWireframeSize = "pbWireframeSize";
	internal const string pbWeldDistance = "pbWeldDistance";
	internal const string pbExtrudeDistance = "pbExtrudeDistance";
	internal const string pbBevelAmount = "pbBevelAmount";
	internal const string pbEdgeSubdivisions = "pbEdgeSubdivisions";
	internal const string pbDefaultShortcuts = "pbDefaultShortcuts";
	internal const string pbDefaultMaterial = "pbDefaultMaterial";
	internal const string pbCurrentMaterialPalette = "pbCurrentMaterialPalette";
	internal const string pbGrowSelectionUsingAngle = "pbGrowSelectionUsingAngle";
	internal const string pbGrowSelectionAngle = "pbGrowSelectionAngle";
	internal const string pbGrowSelectionAngleIterative = "pbGrowSelectionAngleIterative";
	internal const string pbShowDetail = "pbShowDetail";
	internal const string pbShowOccluder = "pbShowOccluder";
	internal const string pbShowMover = "pbShowMover";
	internal const string pbShowCollider = "pbShowCollider";
	internal const string pbShowTrigger = "pbShowTrigger";
	internal const string pbShowNoDraw = "pbShowNoDraw";
	internal const string defaultUnwrapParameters = "pbDefaultUnwrapParameters";

	// Methods

	// RVA: 0x14F5960
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
public enum SelectMode
{
	// Fields
	public int value__; // 0x10
	public const SelectMode None = 0;
	public const SelectMode Object = 1;
	public const SelectMode Vertex = 2;
	public const SelectMode Edge = 4;
	public const SelectMode Face = 8;
	public const SelectMode TextureFace = 16;
	public const SelectMode TextureEdge = 32;
	public const SelectMode TextureVertex = 64;
	public const SelectMode InputTool = 128;
	public const SelectMode Any = 65535;
}

// Namespace: UnityEngine.ProBuilder
internal enum ComponentMode
{
	// Fields
	public int value__; // 0x10
	public const ComponentMode Vertex = 0;
	public const ComponentMode Edge = 1;
	public const ComponentMode Face = 2;
}

// Namespace: UnityEngine.ProBuilder
internal enum EditLevel
{
	// Fields
	public int value__; // 0x10
	public const EditLevel Top = 0;
	public const EditLevel Geometry = 1;
	public const EditLevel Texture = 2;
	public const EditLevel Plugin = 3;
}

// Namespace: UnityEngine.ProBuilder
internal enum EntityType
{
	// Fields
	public int value__; // 0x10
	public const EntityType Detail = 0;
	public const EntityType Occluder = 1;
	public const EntityType Trigger = 2;
	public const EntityType Collider = 3;
	public const EntityType Mover = 4;
}

// Namespace: UnityEngine.ProBuilder
internal enum ColliderType
{
	// Fields
	public int value__; // 0x10
	public const ColliderType None = 0;
	public const ColliderType BoxCollider = 1;
	public const ColliderType MeshCollider = 2;
}

// Namespace: UnityEngine.ProBuilder
public enum ProjectionAxis
{
	// Fields
	public int value__; // 0x10
	public const ProjectionAxis X = 0;
	public const ProjectionAxis Y = 1;
	public const ProjectionAxis Z = 2;
	public const ProjectionAxis XNegative = 3;
	public const ProjectionAxis YNegative = 4;
	public const ProjectionAxis ZNegative = 5;
}

// Namespace: UnityEngine.ProBuilder
internal enum HandleAxis
{
	// Fields
	public int value__; // 0x10
	public const HandleAxis X = 1;
	public const HandleAxis Y = 2;
	public const HandleAxis Z = 4;
	public const HandleAxis Free = 8;
}

// Namespace: UnityEngine.ProBuilder
public enum Axis
{
	// Fields
	public int value__; // 0x10
	public const Axis Right = 0;
	public const Axis Left = 1;
	public const Axis Up = 2;
	public const Axis Down = 3;
	public const Axis Forward = 4;
	public const Axis Backward = 5;
}

// Namespace: UnityEngine.ProBuilder
public enum WindingOrder
{
	// Fields
	public int value__; // 0x10
	public const WindingOrder Unknown = 0;
	public const WindingOrder Clockwise = 1;
	public const WindingOrder CounterClockwise = 2;
}

// Namespace: UnityEngine.ProBuilder
public enum SortMethod
{
	// Fields
	public int value__; // 0x10
	public const SortMethod Clockwise = 0;
	public const SortMethod CounterClockwise = 1;
}

// Namespace: UnityEngine.ProBuilder
public enum CullingMode
{
	// Fields
	public int value__; // 0x10
	public const CullingMode None = 0;
	public const CullingMode Back = 1;
	public const CullingMode Front = 2;
	public const CullingMode FrontBack = 3;
}

// Namespace: UnityEngine.ProBuilder
public enum RectSelectMode
{
	// Fields
	public int value__; // 0x10
	public const RectSelectMode Partial = 0;
	public const RectSelectMode Complete = 1;
}

// Namespace: UnityEngine.ProBuilder
public enum MeshSyncState
{
	// Fields
	public int value__; // 0x10
	public const MeshSyncState Null = 0;
	public const MeshSyncState InstanceIDMismatch = 1;
	public const MeshSyncState Lightmap = 2;
	public const MeshSyncState InSync = 3;
	public const MeshSyncState NeedsRebuild = 4;
}

// Namespace: UnityEngine.ProBuilder
public enum MeshArrays
{
	// Fields
	public int value__; // 0x10
	public const MeshArrays Position = 1;
	public const MeshArrays Texture0 = 2;
	public const MeshArrays Texture1 = 4;
	public const MeshArrays Lightmap = 4;
	public const MeshArrays Texture2 = 8;
	public const MeshArrays Texture3 = 16;
	public const MeshArrays Color = 32;
	public const MeshArrays Normal = 64;
	public const MeshArrays Tangent = 128;
	public const MeshArrays All = 255;
}

// Namespace: UnityEngine.ProBuilder
internal enum IndexFormat
{
	// Fields
	public int value__; // 0x10
	public const IndexFormat Local = 0;
	public const IndexFormat Common = 1;
	public const IndexFormat Both = 2;
}

// Namespace: UnityEngine.ProBuilder
public enum RefreshMask
{
	// Fields
	public int value__; // 0x10
	public const RefreshMask UV = 1;
	public const RefreshMask Colors = 2;
	public const RefreshMask Normals = 4;
	public const RefreshMask Tangents = 8;
	public const RefreshMask Collisions = 16;
	public const RefreshMask Bounds = 22;
	public const RefreshMask All = 31;
}

// Namespace: UnityEngine.ProBuilder
public enum ExtrudeMethod
{
	// Fields
	public int value__; // 0x10
	public const ExtrudeMethod IndividualFaces = 0;
	public const ExtrudeMethod VertexNormal = 1;
	public const ExtrudeMethod FaceNormal = 2;
}

// Namespace: 
private enum CacheValidState
{
	// Fields
	public Byte value__; // 0x10
	public const CacheValidState SharedVertex = 1;
	public const CacheValidState SharedTexture = 2;
}

// Namespace: 
internal struct NonVersionedEditScope
{
	// Fields
	private readonly ProBuilderMesh m_Mesh; // 0x10
	private readonly UInt16 m_VersionIndex; // 0x18
	private readonly UInt16 m_InstanceVersionIndex; // 0x1A

	// Methods

	// RVA: 0x14F9864
	public void .ctor(ProBuilderMesh mesh) { }

	// RVA: 0x14FFA4C
	public void Dispose() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.ProBuilderMesh.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector4,UnityEngine.Vector2> <>9__118_0; // 0x8
	public static System.Func<UnityEngine.Vector4,UnityEngine.Vector2> <>9__118_1; // 0x10
	public static System.Func<UnityEngine.ProBuilder.Face,System.Int32> <>9__126_0; // 0x18
	public static System.Func<UnityEngine.ProBuilder.Face,System.Int32> <>9__128_0; // 0x20
	public static System.Func<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Face> <>9__171_0; // 0x28

	// Methods

	// RVA: 0x14FFA70
	private static void .cctor() { }

	// RVA: 0x14FFADC
	public void .ctor() { }

	// RVA: 0x14FFAE4
	internal Vector2 <SetUVs>b__118_0(Vector4 x) { }

	// RVA: 0x14FFAE8
	internal Vector2 <SetUVs>b__118_1(Vector4 x) { }

	// RVA: 0x14FFAEC
	internal int <get_indexCount>b__126_0(Face x) { }

	// RVA: 0x14FFB10
	internal int <get_triangleCount>b__128_0(Face x) { }

	// RVA: 0x14FFB34
	internal Face <CopyFrom>b__171_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass174_0
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x14FBE48
	public void .ctor() { }

	// RVA: 0x14FFB9C
	internal bool <GetUnusedTextureGroup>b__0(Face element) { }

}

// Namespace: 
private sealed class <>c__DisplayClass176_0
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x14FBF58
	public void .ctor() { }

	// RVA: 0x14FFBC4
	internal bool <UnusedElementGroup>b__0(Face element) { }

}

// Namespace: UnityEngine.ProBuilder
public sealed class ProBuilderMesh
{
	// Fields
	internal const HideFlags k_MeshFilterHideFlags = 10;
	private const int k_UVChannelCount = 4;
	internal const int k_MeshFormatVersion = 2;
	internal const int k_MeshFormatVersionSubmeshMaterialRefactor = 1;
	internal const int k_MeshFormatVersionAutoUVScaleOffset = 2;
	public const UInt32 maxVertexCount = 65535;
	private int m_MeshFormatVersion; // 0x20
	private Face[] m_Faces; // 0x28
	private SharedVertex[] m_SharedVertices; // 0x30
	private CacheValidState m_CacheValid; // 0x38
	private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_SharedVertexLookup; // 0x40
	private SharedVertex[] m_SharedTextures; // 0x48
	private System.Collections.Generic.Dictionary<System.Int32,System.Int32> m_SharedTextureLookup; // 0x50
	private Vector3[] m_Positions; // 0x58
	private Vector2[] m_Textures0; // 0x60
	private System.Collections.Generic.List<UnityEngine.Vector4> m_Textures2; // 0x68
	private System.Collections.Generic.List<UnityEngine.Vector4> m_Textures3; // 0x70
	private Vector4[] m_Tangents; // 0x78
	private Vector3[] m_Normals; // 0x80
	private Color[] m_Colors; // 0x88
	private bool <userCollisions>k__BackingField; // 0x90
	private UnwrapParameters m_UnwrapParameters; // 0x98
	private bool m_PreserveMeshAssetOnDestroy; // 0xA0
	internal string assetGuid; // 0xA8
	private Mesh m_Mesh; // 0xB0
	private MeshRenderer m_MeshRenderer; // 0xB8
	private MeshFilter m_MeshFilter; // 0xC0
	internal const UInt16 k_UnitializedVersionIndex = 0;
	private UInt16 m_VersionIndex; // 0xC8
	private UInt16 m_InstanceVersionIndex; // 0xCA
	private static System.Action<UnityEngine.ProBuilder.ProBuilderMesh> meshWillBeDestroyed; // 0x0
	private static System.Action<UnityEngine.ProBuilder.ProBuilderMesh> meshWasInitialized; // 0x8
	private static System.Action<UnityEngine.ProBuilder.ProBuilderMesh> componentWillBeDestroyed; // 0x10
	private static System.Action<UnityEngine.ProBuilder.ProBuilderMesh> componentHasBeenReset; // 0x18
	private static System.Action<UnityEngine.ProBuilder.ProBuilderMesh> elementSelectionChanged; // 0x20
	private static System.Collections.Generic.HashSet<System.Int32> s_CachedHashSet; // 0x28
	private bool m_IsSelectable; // 0xCC
	private int[] m_SelectedFaces; // 0xD0
	private Edge[] m_SelectedEdges; // 0xD8
	private int[] m_SelectedVertices; // 0xE0
	private bool m_SelectedCacheDirty; // 0xE8
	private int m_SelectedSharedVerticesCount; // 0xEC
	private int m_SelectedCoincidentVertexCount; // 0xF0
	private System.Collections.Generic.HashSet<System.Int32> m_SelectedSharedVertices; // 0xF8
	private System.Collections.Generic.List<System.Int32> m_SelectedCoincidentVertices; // 0x100

	// Methods

	// RVA: 0x14F59C8
	public bool get_userCollisions() { }

	// RVA: 0x14F59D0
	public void set_userCollisions(bool value) { }

	// RVA: 0x14F59D8
	public UnwrapParameters get_unwrapParameters() { }

	// RVA: 0x14F59E0
	public void set_unwrapParameters(UnwrapParameters value) { }

	// RVA: 0x14F24DC
	internal MeshRenderer get_renderer() { }

	// RVA: 0x14F59E8
	internal MeshFilter get_filter() { }

	// RVA: 0x14F5ADC
	internal UInt16 get_versionIndex() { }

	// RVA: 0x14F5AE4
	internal UInt16 get_nonSerializedVersionIndex() { }

	// RVA: 0x14F5AEC
	public bool get_preserveMeshAssetOnDestroy() { }

	// RVA: 0x14F5AF4
	public void set_preserveMeshAssetOnDestroy(bool value) { }

	// RVA: 0x14F06C8
	public bool HasArrays(MeshArrays channels) { }

	// RVA: 0x14F5AFC
	internal Face[] get_facesInternal() { }

	// RVA: 0x14F5B04
	internal void set_facesInternal(Face[] value) { }

	// RVA: 0x14F5B0C
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> get_faces() { }

	// RVA: 0x14F5B8C
	public void set_faces(System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> value) { }

	// RVA: 0x14F5C40
	internal void InvalidateSharedVertexLookup() { }

	// RVA: 0x14F5D04
	internal void InvalidateSharedTextureLookup() { }

	// RVA: 0x14F5DC8
	internal void InvalidateFaces() { }

	// RVA: 0x14F6128
	internal void InvalidateCaches() { }

	// RVA: 0x14F6160
	internal SharedVertex[] get_sharedVerticesInternal() { }

	// RVA: 0x14F6168
	internal void set_sharedVerticesInternal(SharedVertex[] value) { }

	// RVA: 0x14F6190
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> get_sharedVertices() { }

	// RVA: 0x14F6210
	public void set_sharedVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> value) { }

	// RVA: 0x14F6440
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_sharedVertexLookup() { }

	// RVA: 0x14F6514
	internal void SetSharedVertices(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> indexes) { }

	// RVA: 0x14F659C
	internal SharedVertex[] get_sharedTextures() { }

	// RVA: 0x14F65A4
	internal void set_sharedTextures(SharedVertex[] value) { }

	// RVA: 0x14F65CC
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_sharedTextureLookup() { }

	// RVA: 0x14F669C
	internal void SetSharedTextures(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> indexes) { }

	// RVA: 0x14F6724
	internal Vector3[] get_positionsInternal() { }

	// RVA: 0x14F672C
	internal void set_positionsInternal(Vector3[] value) { }

	// RVA: 0x14F6734
	public System.Collections.Generic.IList<UnityEngine.Vector3> get_positions() { }

	// RVA: 0x14F67B4
	public void set_positions(System.Collections.Generic.IList<UnityEngine.Vector3> value) { }

	// RVA: 0x14F19F0
	public Vertex[] GetVertices(System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14F6868
	internal void GetVerticesInList(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x14F71A0
	public void SetVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, bool applyMesh) { }

	// RVA: 0x14F767C
	public System.Collections.Generic.IList<UnityEngine.Vector3> get_normals() { }

	// RVA: 0x14F7718
	internal Vector3[] get_normalsInternal() { }

	// RVA: 0x14F7720
	internal void set_normalsInternal(Vector3[] value) { }

	// RVA: 0x14F0C38
	public Vector3[] GetNormals() { }

	// RVA: 0x14F7728
	internal Color[] get_colorsInternal() { }

	// RVA: 0x14F7730
	internal void set_colorsInternal(Color[] value) { }

	// RVA: 0x14F7738
	public System.Collections.Generic.IList<UnityEngine.Color> get_colors() { }

	// RVA: 0x14F77D4
	public void set_colors(System.Collections.Generic.IList<UnityEngine.Color> value) { }

	// RVA: 0x14F79B4
	public Color[] GetColors() { }

	// RVA: 0x14F7B30
	public System.Collections.Generic.IList<UnityEngine.Vector4> get_tangents() { }

	// RVA: 0x14F7BD8
	public void set_tangents(System.Collections.Generic.IList<UnityEngine.Vector4> value) { }

	// RVA: 0x14F7D50
	internal Vector4[] get_tangentsInternal() { }

	// RVA: 0x14F7D58
	internal void set_tangentsInternal(Vector4[] value) { }

	// RVA: 0x14F0DC8
	public Vector4[] GetTangents() { }

	// RVA: 0x14F7D60
	internal Vector2[] get_texturesInternal() { }

	// RVA: 0x14F7D68
	internal void set_texturesInternal(Vector2[] value) { }

	// RVA: 0x14F7D70
	internal System.Collections.Generic.List<UnityEngine.Vector4> get_textures2Internal() { }

	// RVA: 0x14F7D78
	internal void set_textures2Internal(System.Collections.Generic.List<UnityEngine.Vector4> value) { }

	// RVA: 0x14F7D80
	internal System.Collections.Generic.List<UnityEngine.Vector4> get_textures3Internal() { }

	// RVA: 0x14F7D88
	internal void set_textures3Internal(System.Collections.Generic.List<UnityEngine.Vector4> value) { }

	// RVA: 0x14F7D90
	public System.Collections.Generic.IList<UnityEngine.Vector2> get_textures() { }

	// RVA: 0x14F7E2C
	public void set_textures(System.Collections.Generic.IList<UnityEngine.Vector2> value) { }

	// RVA: 0x14F0930
	public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x14F7F90
	internal System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Vector2> GetUVs(int channel) { }

	// RVA: 0x14F80BC
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x14F3FB4
	public int get_faceCount() { }

	// RVA: 0x14F198C
	public int get_vertexCount() { }

	// RVA: 0x14F83F0
	public int get_edgeCount() { }

	// RVA: 0x14F8494
	public int get_indexCount() { }

	// RVA: 0x14F85D0
	public int get_triangleCount() { }

	// RVA: 0x14F8728
	public static void add_meshWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F8838
	public static void remove_meshWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F8948
	internal static void add_meshWasInitialized(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F8A5C
	internal static void remove_meshWasInitialized(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F8B70
	internal static void add_componentWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F8C84
	internal static void remove_componentWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F8D98
	internal static void add_componentHasBeenReset(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F8EAC
	internal static void remove_componentHasBeenReset(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F8FC0
	public static void add_elementSelectionChanged(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F90D4
	public static void remove_elementSelectionChanged(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x14F2724
	internal Mesh get_mesh() { }

	// RVA: 0x14F91E8
	internal void set_mesh(Mesh value) { }

	// RVA: 0x14F91F0
	internal int get_id() { }

	// RVA: 0x14F9214
	public MeshSyncState get_meshSyncState() { }

	// RVA: 0x14F931C
	internal int get_meshFormatVersion() { }

	// RVA: 0x14F9324
	private void Awake() { }

	// RVA: 0x14F989C
	private void Reset() { }

	// RVA: 0x14F996C
	private void OnDestroy() { }

	// RVA: 0x14F9B64
	internal void DestroyUnityMesh() { }

	// RVA: 0x14F765C
	private void IncrementVersionIndex() { }

	// RVA: 0x14F74C8
	public void Clear() { }

	// RVA: 0x14F94B4
	internal void EnsureMeshFilterIsAssigned() { }

	// RVA: 0x14F9CAC
	internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions) { }

	// RVA: 0x14FA018
	public static ProBuilderMesh Create() { }

	// RVA: 0x14FA0AC
	public static ProBuilderMesh Create(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> positions, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x14FA2C8
	public static ProBuilderMesh Create(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedTextures, System.Collections.Generic.IList<UnityEngine.Material> materials) { }

	// RVA: 0x14F9DD4
	internal void GeometryWithPoints(Vector3[] points) { }

	// RVA: 0x14FA188
	public void RebuildWithPositionsAndFaces(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> vertices, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x14F19A4
	internal void Rebuild() { }

	// RVA: 0x14FA4C8
	public void ToMesh(MeshTopology preferredTopology) { }

	// RVA: 0x14FAE68
	private void FinalizeToMesh(bool usedInParticleSystem) { }

	// RVA: 0x14FAEB4
	public void MakeUnique() { }

	// RVA: 0x14FB0B4
	public void CopyFrom(ProBuilderMesh other) { }

	// RVA: 0x14FAC2C
	public void Refresh(RefreshMask mask) { }

	// RVA: 0x14F9684
	internal void EnsureMeshColliderIsAssigned() { }

	// RVA: 0x14FBD4C
	internal int GetUnusedTextureGroup(int i) { }

	// RVA: 0x14FBE50
	private static bool IsValidTextureGroup(int group) { }

	// RVA: 0x14FBE5C
	internal int UnusedElementGroup(int i) { }

	// RVA: 0x14FB59C
	public void RefreshUV(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> facesToRefresh) { }

	// RVA: 0x14FBF60
	internal void SetGroupUV(AutoUnwrapSettings settings, int group) { }

	// RVA: 0x14FBBD8
	private void RefreshColors() { }

	// RVA: 0x14FC044
	public void SetFaceColor(Face face, Color color) { }

	// RVA: 0x14FC3EC
	public void SetMaterial(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, Material material) { }

	// RVA: 0x14FBC14
	private void RefreshNormals() { }

	// RVA: 0x14FBCB0
	private void RefreshTangents() { }

	// RVA: 0x14FCA5C
	internal int GetSharedVertexHandle(int vertex) { }

	// RVA: 0x14FCBCC
	internal System.Collections.Generic.HashSet<System.Int32> GetSharedVertexHandles(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x14FCF50
	public System.Collections.Generic.List<System.Int32> GetCoincidentVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x14FD580
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x14FDB98
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x14FD028
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x14FE260
	public void GetCoincidentVertices(int vertex, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x14FE40C
	public void SetVerticesCoincident(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x14FE4CC
	internal void SetTexturesCoincident(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x14FE518
	internal void AddToSharedVertex(int sharedVertexHandle, int vertex) { }

	// RVA: 0x14FE5B4
	internal void AddSharedVertex(SharedVertex vertex) { }

	// RVA: 0x14FE678
	public bool get_selectable() { }

	// RVA: 0x14FE680
	public void set_selectable(bool value) { }

	// RVA: 0x14FE688
	public int get_selectedFaceCount() { }

	// RVA: 0x14FE6A8
	public int get_selectedVertexCount() { }

	// RVA: 0x14FE6C8
	public int get_selectedEdgeCount() { }

	// RVA: 0x14FE6E8
	internal int get_selectedSharedVerticesCount() { }

	// RVA: 0x14FEAC4
	internal int get_selectedCoincidentVertexCount() { }

	// RVA: 0x14FEAE8
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedSharedVertices() { }

	// RVA: 0x14FEB0C
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedCoincidentVertices() { }

	// RVA: 0x14FE70C
	private void CacheSelection() { }

	// RVA: 0x14FEB30
	public Face[] GetSelectedFaces() { }

	// RVA: 0x14FEC4C
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_selectedFaceIndexes() { }

	// RVA: 0x14FECCC
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_selectedVertices() { }

	// RVA: 0x14FED4C
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.Edge> get_selectedEdges() { }

	// RVA: 0x14FEDCC
	internal Face[] get_selectedFacesInternal() { }

	// RVA: 0x14FEDD0
	internal void set_selectedFacesInternal(Face[] value) { }

	// RVA: 0x14FEEAC
	internal int[] get_selectedFaceIndicesInternal() { }

	// RVA: 0x14FEEB4
	internal void set_selectedFaceIndicesInternal(int[] value) { }

	// RVA: 0x14FEEBC
	internal Edge[] get_selectedEdgesInternal() { }

	// RVA: 0x14FEEC4
	internal void set_selectedEdgesInternal(Edge[] value) { }

	// RVA: 0x14FEECC
	internal int[] get_selectedIndexesInternal() { }

	// RVA: 0x14FEED4
	internal void set_selectedIndexesInternal(int[] value) { }

	// RVA: 0x14FEEDC
	internal Face GetActiveFace() { }

	// RVA: 0x14FEF3C
	internal Edge GetActiveEdge() { }

	// RVA: 0x14FEFE0
	internal int GetActiveVertex() { }

	// RVA: 0x14FF020
	internal void AddToFaceSelection(int index) { }

	// RVA: 0x14FF2F4
	public void SetSelectedFaces(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> selected) { }

	// RVA: 0x14FF09C
	internal void SetSelectedFaces(System.Collections.Generic.IEnumerable<System.Int32> selected) { }

	// RVA: 0x14FF3BC
	public void SetSelectedEdges(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x14FF520
	public void SetSelectedVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x14FF6B4
	internal void RemoveFromFaceSelectionAtIndex(int index) { }

	// RVA: 0x14F97A8
	public void ClearSelection() { }

	// RVA: 0x14FF71C
	public void .ctor() { }

	// RVA: 0x14FF888
	private static void .cctor() { }

	// RVA: 0x14FF91C
	private int <set_selectedFacesInternal>b__231_0(Face x) { }

	// RVA: 0x14FF978
	private int <SetSelectedFaces>b__245_0(Face x) { }

	// RVA: 0x14FF9D4
	private System.Collections.Generic.IEnumerable<System.Int32> <SetSelectedFaces>b__246_0(int x) { }

	// RVA: 0x14FFA10
	private System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <SetSelectedFaces>b__246_1(int x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ProBuilderSnapping
{
	// Fields
	private const float k_MaxRaySnapDistance = inf;

	// Methods

	// RVA: 0x14FFBEC
	internal static bool IsCardinalDirection(Vector3 direction) { }

	// RVA: 0x14FFE6C
	public static float Snap(float val, float snap) { }

	// RVA: 0x14FFF40
	public static Vector3 Snap(Vector3 val, Vector3 snap) { }

	// RVA: 0x1500180
	public static void SnapVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, Vector3 snap) { }

	// RVA: 0x1500528
	internal static Vector3 GetSnappingMaskBasedOnNormalVector(Vector3 normal) { }

	// RVA: 0x1500608
	internal static Vector3 SnapValueOnRay(Ray ray, float distance, float snap, Vector3Mask mask) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ProGridsNoSnapAttribute
{
	// Methods

	// RVA: 0x1500D90
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ProGridsConditionalSnapAttribute
{
	// Methods

	// RVA: 0x1500D98
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.Projection.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2>> <>9__6_0; // 0x8
	public static System.Func<UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2>,UnityEngine.Vector2> <>9__6_1; // 0x10

	// Methods

	// RVA: 0x1503F4C
	private static void .cctor() { }

	// RVA: 0x1503FB8
	public void .ctor() { }

	// RVA: 0x1503FC0
	internal int <Sort>b__6_0(UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> a, UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> b) { }

	// RVA: 0x1504124
	internal Vector2 <Sort>b__6_1(UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> x) { }

}

// Namespace: UnityEngine.ProBuilder
public static class Projection
{
	// Methods

	// RVA: 0x1500DA0
	public static Vector2[] PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x150176C
	public static Vector2[] PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Vector3 direction) { }

	// RVA: 0x1501934
	internal static void PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Vector3 direction, System.Collections.Generic.List<UnityEngine.Vector2> results) { }

	// RVA: 0x15022EC
	internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x15029C8
	internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x1502EC0
	internal static Vector2[] SphericalProject(System.Collections.Generic.IList<UnityEngine.Vector3> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1503324
	internal static System.Collections.Generic.IList<UnityEngine.Vector2> Sort(System.Collections.Generic.IList<UnityEngine.Vector2> verts, SortMethod method) { }

	// RVA: 0x1502218
	internal static Vector3 GetTangentToAxis(ProjectionAxis axis) { }

	// RVA: 0x15037D8
	internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis) { }

	// RVA: 0x15020C8
	internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction) { }

	// RVA: 0x1500DCC
	public static Plane FindBestPlane(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x15039D0
	internal static Plane FindBestPlane(ProBuilderMesh mesh, int textureGroup) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class RaycastHit
{
	// Fields
	public float distance; // 0x10
	public Vector3 point; // 0x14
	public Vector3 normal; // 0x20
	public int face; // 0x2C

	// Methods

	// RVA: 0x15041F4
	public void .ctor(float distance, Vector3 point, Vector3 normal, int face) { }

}

// Namespace: UnityEngine.ProBuilder
public enum SelectionModifierBehavior
{
	// Fields
	public int value__; // 0x10
	public const SelectionModifierBehavior Add = 0;
	public const SelectionModifierBehavior Subtract = 1;
	public const SelectionModifierBehavior Difference = 2;
}

// Namespace: UnityEngine.ProBuilder
public static class SelectionPicker
{
	// Methods

	// RVA: 0x150426C
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<System.Int32>> PickVerticesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x15059B4
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> PickFacesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x1507518
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Edge>> PickEdgesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x1508C20
	public static Face PickFace(Camera camera, Vector3 mousePosition, ProBuilderMesh pickable) { }

}

// Namespace: UnityEngine.ProBuilder
public struct PickerOptions
{
	// Fields
	private bool <depthTest>k__BackingField; // 0x10
	private RectSelectMode <rectSelectMode>k__BackingField; // 0x14
	private static readonly PickerOptions k_Default; // 0x0

	// Methods

	// RVA: 0x1508CCC
	public bool get_depthTest() { }

	// RVA: 0x1508CD4
	public void set_depthTest(bool value) { }

	// RVA: 0x1508CDC
	public RectSelectMode get_rectSelectMode() { }

	// RVA: 0x1508CE4
	public void set_rectSelectMode(RectSelectMode value) { }

	// RVA: 0x1508CEC
	public static PickerOptions get_Default() { }

	// RVA: 0x1508D68
	public override bool Equals(object obj) { }

	// RVA: 0x1508E98
	public bool Equals(PickerOptions other) { }

	// RVA: 0x1508F48
	public override int GetHashCode() { }

	// RVA: 0x1509020
	public static bool op_Equality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x1509150
	public static bool op_Inequality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x1509280
	private static void .cctor() { }

}

// Namespace: 
internal interface ISelectionPickerRenderer
{
	// Methods

	// RVA: -1
	public abstract Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

}

// Namespace: 
internal class SelectionPickerRendererHDRP
{
	// Methods

	// RVA: 0x150BA5C
	public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

	// RVA: 0x150BA64
	public void .ctor() { }

}

// Namespace: 
internal class SelectionPickerRendererStandard
{
	// Methods

	// RVA: 0x150BA6C
	public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

	// RVA: 0x150BE30
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.SelectionPickerRenderer.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__24_0; // 0x8

	// Methods

	// RVA: 0x150BE38
	private static void .cctor() { }

	// RVA: 0x150BEA4
	public void .ctor() { }

	// RVA: 0x150BEAC
	internal System.Collections.Generic.IEnumerable<System.Int32> <GenerateFacePickingObjects>b__24_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass19_0
{
	// Fields
	public Vector3[] positions; // 0x10
	public SharedVertex[] sharedVertices; // 0x18

	// Methods

	// RVA: 0x150BEC8
	public void .ctor() { }

	// RVA: 0x150BED0
	internal int <PickVerticesInRect>b__0(int x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class SelectionPickerRenderer
{
	// Fields
	private const string k_FacePickerOcclusionTintUniform = "_Tint";
	private static readonly Color k_Blackf; // 0x0
	private static readonly Color k_Whitef; // 0x10
	private const UInt32 k_PickerHashNone = 0;
	private const UInt32 k_PickerHashMin = 1;
	private const UInt32 k_PickerHashMax = 16777215;
	private const UInt32 k_MinEdgePixelsForValidSelection = 1;
	private static bool s_Initialized; // 0x20
	private static ISelectionPickerRenderer s_PickerRenderer; // 0x28
	private static RenderTextureFormat s_RenderTextureFormat; // 0x30
	private static RenderTextureFormat[] s_PreferredFormats; // 0x38

	// Methods

	// RVA: 0x15092D0
	private static RenderTextureFormat get_renderTextureFormat() { }

	// RVA: 0x1509458
	private static TextureFormat get_textureFormat() { }

	// RVA: 0x1509460
	private static ISelectionPickerRenderer get_pickerRenderer() { }

	// RVA: 0x1506BC8
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> PickFacesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x1504930
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<System.Int32>> PickVerticesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x1507EE8
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x150957C
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Face>>& map, int width, int height) { }

	// RVA: 0x15097EC
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>>& map, int width, int height) { }

	// RVA: 0x1509AE8
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>>& map, int width, int height) { }

	// RVA: 0x1509DE4
	private static GameObject[] GenerateFacePickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Face>>& map) { }

	// RVA: 0x150A3B0
	private static void GenerateVertexPickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>>& map, GameObject[] depthObjects, GameObject[] pickerObjects) { }

	// RVA: 0x150A840
	private static void GenerateEdgePickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>>& map, GameObject[] depthObjects, GameObject[] pickerObjects) { }

	// RVA: 0x150ACE4
	private static Mesh BuildVertexMesh(ProBuilderMesh pb, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>> map, UInt32 index) { }

	// RVA: 0x150B4B0
	private static Mesh BuildEdgeMesh(ProBuilderMesh pb, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>> map, UInt32 index) { }

	// RVA: 0x15097D8
	public static UInt32 DecodeRGBA(Color32 color) { }

	// RVA: 0x150ACD0
	public static Color32 EncodeRGBA(UInt32 hash) { }

	// RVA: 0x1509574
	private static bool ShouldUseHDRP() { }

	// RVA: 0x150B98C
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
public class SceneSelection
{
	// Fields
	public GameObject gameObject; // 0x10
	public ProBuilderMesh mesh; // 0x18
	private System.Collections.Generic.List<System.Int32> m_Vertices; // 0x20
	private System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> m_Edges; // 0x28
	private System.Collections.Generic.List<UnityEngine.ProBuilder.Face> m_Faces; // 0x30
	public int vertex; // 0x38
	public Edge edge; // 0x3C
	public Face face; // 0x48

	// Methods

	// RVA: 0x150C0C8
	public System.Collections.Generic.List<System.Int32> get_vertexes() { }

	// RVA: 0x150C0D0
	public void set_vertexes(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x150C0D8
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> get_edges() { }

	// RVA: 0x150C0E0
	public void set_edges(System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> value) { }

	// RVA: 0x150C0E8
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Face> get_faces() { }

	// RVA: 0x150C0F0
	public void set_faces(System.Collections.Generic.List<UnityEngine.ProBuilder.Face> value) { }

	// RVA: 0x150C0F8
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x150C248
	public void .ctor(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x150C49C
	public void .ctor(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x150C6F0
	public void .ctor(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x150C314
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> vertexes) { }

	// RVA: 0x150C568
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x150C7AC
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x150C934
	public void SetSingleFace(Face face) { }

	// RVA: 0x150CA00
	public void SetSingleVertex(int vertex) { }

	// RVA: 0x150CADC
	public void SetSingleEdge(Edge edge) { }

	// RVA: 0x150CBB8
	public void Clear() { }

	// RVA: 0x150CD4C
	public void CopyTo(SceneSelection dst) { }

	// RVA: 0x150CF60
	public override string ToString() { }

	// RVA: 0x150D1F4
	public bool Equals(SceneSelection other) { }

	// RVA: 0x150D2FC
	public override bool Equals(object obj) { }

	// RVA: 0x150D428
	public override int GetHashCode() { }

	// RVA: 0x150D5E0
	public static bool op_Equality(SceneSelection left, SceneSelection right) { }

	// RVA: 0x150D5E8
	public static bool op_Inequality(SceneSelection left, SceneSelection right) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct VertexPickerEntry
{
	// Fields
	public ProBuilderMesh mesh; // 0x10
	public int vertex; // 0x18
	public float screenDistance; // 0x1C
	public Vector3 worldPosition; // 0x20
}

// Namespace: UnityEngine.ProBuilder
internal static class SelectPathFaces
{
	// Fields
	private static int[] s_cachedPredecessors; // 0x0
	private static int s_cachedStart; // 0x8
	private static ProBuilderMesh s_cachedMesh; // 0x10
	private static int s_cachedFacesCount; // 0x18
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> s_cachedWings; // 0x20
	private static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Face,System.Int32> s_cachedFacesIndex; // 0x28

	// Methods

	// RVA: 0x150D604
	public static System.Collections.Generic.List<System.Int32> GetPath(ProBuilderMesh mesh, int start, int end) { }

	// RVA: 0x150DA78
	private static int[] Dijkstra(ProBuilderMesh mesh, int start) { }

	// RVA: 0x150E228
	private static float GetWeight(int face1, int face2, ProBuilderMesh mesh) { }

	// RVA: 0x150D938
	private static System.Collections.Generic.List<System.Int32> GetMinimalPath(int[] predecessors, int start, int end) { }

	// RVA: 0x150E680
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal sealed class SemVer
{
	// Fields
	private int m_Major; // 0x10
	private int m_Minor; // 0x14
	private int m_Patch; // 0x18
	private int m_Build; // 0x1C
	private string m_Type; // 0x20
	private string m_Metadata; // 0x28
	private string m_Date; // 0x30
	public const string DefaultStringFormat = "M.m.p-t.b";

	// Methods

	// RVA: 0x150E714
	public int get_major() { }

	// RVA: 0x150E71C
	public int get_minor() { }

	// RVA: 0x150E724
	public int get_patch() { }

	// RVA: 0x150E72C
	public int get_build() { }

	// RVA: 0x150E734
	public string get_type() { }

	// RVA: 0x150E790
	public string get_metadata() { }

	// RVA: 0x150E7EC
	public string get_date() { }

	// RVA: 0x150E848
	public SemVer get_MajorMinorPatch() { }

	// RVA: 0x150E994
	public void .ctor() { }

	// RVA: 0x150E9F8
	public void .ctor(string formatted, string date) { }

	// RVA: 0x150E900
	public void .ctor(int major, int minor, int patch, int build, string type, string date, string metadata) { }

	// RVA: 0x150EF68
	public bool IsValid() { }

	// RVA: 0x150EF98
	public override bool Equals(object o) { }

	// RVA: 0x150F268
	public override int GetHashCode() { }

	// RVA: 0x150F018
	public bool Equals(SemVer version) { }

	// RVA: 0x150F454
	public int CompareTo(object obj) { }

	// RVA: 0x150F6B0
	private static int WrapNoValue(int value) { }

	// RVA: 0x150F4D4
	public int CompareTo(SemVer version) { }

	// RVA: 0x150F6C0
	public static bool op_Equality(SemVer left, SemVer right) { }

	// RVA: 0x150F6D4
	public static bool op_Inequality(SemVer left, SemVer right) { }

	// RVA: 0x150F700
	public static bool op_LessThan(SemVer left, SemVer right) { }

	// RVA: 0x150F728
	public static bool op_GreaterThan(SemVer left, SemVer right) { }

	// RVA: 0x150F748
	public static bool op_LessThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x150F79C
	public static bool op_GreaterThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x150F804
	public string ToString(string format) { }

	// RVA: 0x150F9E8
	public override string ToString() { }

	// RVA: 0x150EAE4
	public static bool TryGetVersionInfo(string input, SemVer version) { }

	// RVA: 0x150FC24
	private static int GetBuildNumber(string input) { }

}

// Namespace: UnityEngine.ProBuilder
public enum PivotLocation
{
	// Fields
	public int value__; // 0x10
	public const PivotLocation Center = 0;
	public const PivotLocation FirstCorner = 1;
}

// Namespace: UnityEngine.ProBuilder
public static class ShapeFactory
{
	// Methods

	// RVA: -1
	public static ProBuilderMesh Instantiate(PivotLocation pivotType) { }

	// RVA: 0x150FD30
	public static ProBuilderMesh Instantiate(Type shapeType, PivotLocation pivotType) { }

	// RVA: 0x1510004
	public static ProBuilderMesh Instantiate(Shape shape, PivotLocation pivotType) { }

}

// Namespace: UnityEngine.ProBuilder
public enum ShapeType
{
	// Fields
	public int value__; // 0x10
	public const ShapeType Cube = 0;
	public const ShapeType Stair = 1;
	public const ShapeType CurvedStair = 2;
	public const ShapeType Prism = 3;
	public const ShapeType Cylinder = 4;
	public const ShapeType Plane = 5;
	public const ShapeType Door = 6;
	public const ShapeType Pipe = 7;
	public const ShapeType Cone = 8;
	public const ShapeType Sprite = 9;
	public const ShapeType Arch = 10;
	public const ShapeType Sphere = 11;
	public const ShapeType Torus = 12;
}

// Namespace: UnityEngine.ProBuilder
public static class ShapeGenerator
{
	// Fields
	private static readonly Vector3[] k_IcosphereVertices; // 0x0
	private static readonly int[] k_IcosphereTriangles; // 0x8
	private static readonly Vector3[] k_CubeVertices; // 0x10
	private static readonly int[] k_CubeTriangles; // 0x18

	// Methods

	// RVA: 0x1510270
	public static ProBuilderMesh CreateShape(ShapeType shape, PivotLocation pivotType) { }

	// RVA: 0x1510BD8
	public static ProBuilderMesh GenerateStair(PivotLocation pivotType, Vector3 size, int steps, bool buildSides) { }

	// RVA: 0x15116A0
	public static ProBuilderMesh GenerateCurvedStair(PivotLocation pivotType, float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides) { }

	// RVA: 0x15175E8
	internal static ProBuilderMesh GenerateStair(PivotLocation pivotType, int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly) { }

	// RVA: 0x15108E0
	public static ProBuilderMesh GenerateCube(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x1512B20
	public static ProBuilderMesh GenerateCylinder(PivotLocation pivotType, int axisDivisions, float radius, float height, int heightCuts, int smoothing) { }

	// RVA: 0x1512534
	public static ProBuilderMesh GeneratePrism(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x1513E60
	public static ProBuilderMesh GenerateDoor(PivotLocation pivotType, float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth) { }

	// RVA: 0x15134D4
	public static ProBuilderMesh GeneratePlane(PivotLocation pivotType, float width, float height, int widthCuts, int heightCuts, Axis axis) { }

	// RVA: 0x1514A68
	public static ProBuilderMesh GeneratePipe(PivotLocation pivotType, float radius, float height, float thickness, int subdivAxis, int subdivHeight) { }

	// RVA: 0x15152D8
	public static ProBuilderMesh GenerateCone(PivotLocation pivotType, float radius, float height, int subdivAxis) { }

	// RVA: 0x1515B90
	public static ProBuilderMesh GenerateArch(PivotLocation pivotType, float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps) { }

	// RVA: 0x1516424
	public static ProBuilderMesh GenerateIcosahedron(PivotLocation pivotType, float radius, int subdivisions, bool weldVertices, bool manualUvs) { }

	// RVA: 0x1517C14
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x15188A4
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x1516F6C
	public static ProBuilderMesh GenerateTorus(PivotLocation pivotType, int rows, int columns, float innerRadius, float outerRadius, bool smooth, float horizontalCircumference, float verticalCircumference, bool manualUvs) { }

	// RVA: 0x1518C84
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.SharedVertex.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>,System.Boolean> <>9__26_0; // 0x8

	// Methods

	// RVA: 0x151ACD8
	private static void .cctor() { }

	// RVA: 0x151AD44
	public void .ctor() { }

	// RVA: 0x151AD4C
	internal bool <SortedRemoveAndShift>b__26_0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class SharedVertex
{
	// Fields
	private int[] m_Vertices; // 0x10

	// Methods

	// RVA: 0x1518FA4
	internal int[] get_arrayInternal() { }

	// RVA: 0x1518174
	public void .ctor(System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x1518FAC
	public void .ctor(SharedVertex sharedVertex) { }

	// RVA: 0x150BFE8
	public int get_Item(int i) { }

	// RVA: 0x15190B0
	public void set_Item(int i, int value) { }

	// RVA: 0x15190E4
	public System.Collections.Generic.IEnumerator<System.Int32> GetEnumerator() { }

	// RVA: 0x1519198
	public override string ToString() { }

	// RVA: 0x1519204
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15192B8
	public void Add(int item) { }

	// RVA: 0x1519334
	public void Clear() { }

	// RVA: 0x1519398
	public bool Contains(int item) { }

	// RVA: 0x151940C
	public void CopyTo(int[] array, int arrayIndex) { }

	// RVA: 0x151942C
	public bool Remove(int item) { }

	// RVA: 0x1519090
	public int get_Count() { }

	// RVA: 0x15194DC
	public bool get_IsReadOnly() { }

	// RVA: 0x15194FC
	public static void GetSharedVertexLookup(System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x15199B8
	internal void ShiftIndexes(int offset) { }

	// RVA: 0x1519A48
	internal static SharedVertex[] ToSharedVertices(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> lookup) { }

	// RVA: 0x151A320
	private static SharedVertex[] ToSharedVertices(System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> list) { }

	// RVA: 0x1518234
	public static SharedVertex[] GetSharedVerticesWithPositions(System.Collections.Generic.IList<UnityEngine.Vector3> positions) { }

	// RVA: 0x151A498
	internal static SharedVertex[] RemoveAndShift(System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup, System.Collections.Generic.IEnumerable<System.Int32> remove) { }

	// RVA: 0x151A54C
	internal static SharedVertex[] SortedRemoveAndShift(System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup, System.Collections.Generic.List<System.Int32> remove) { }

	// RVA: 0x151A9BC
	internal static void SetCoincident(System.Collections.Generic.Dictionary<System.Int32,System.Int32>& lookup, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

}

// Namespace: UnityEngine.ProBuilder
public struct SimpleTuple<T0, T1>
{
	// Fields
	private T1 m_Item1; // 0x0
	private T2 m_Item2; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public T1 get_item1() { }

	// RVA: 0x315B3A8
	public void set_item1(T1 value) { }

	// RVA: 0x315B3A8
	public T2 get_item2() { }

	// RVA: 0x315B3A8
	public void set_item2(T2 value) { }

	// RVA: 0x315B3A8
	public void .ctor(T1 item1, T2 item2) { }

	// RVA: 0x30A17DC
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
internal struct SimpleTuple<T0, T1, T2>
{
	// Fields
	private T1 m_Item1; // 0x0
	private T2 m_Item2; // 0x0
	private T3 m_Item3; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public T1 get_item1() { }

	// RVA: 0x315B3A8
	public void set_item1(T1 value) { }

	// RVA: 0x315B3A8
	public T2 get_item2() { }

	// RVA: 0x315B3A8
	public void set_item2(T2 value) { }

	// RVA: 0x315B3A8
	public T3 get_item3() { }

	// RVA: 0x315B3A8
	public void set_item3(T3 value) { }

	// RVA: 0x315B3A8
	public void .ctor(T1 item1, T2 item2, T3 item3) { }

	// RVA: 0x30A17DC
	public override string ToString() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.Smoothing.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Face,System.Int32> <>9__5_0; // 0x8
	public static System.Func<UnityEngine.ProBuilder.Face,System.Int32> <>9__9_0; // 0x10

	// Methods

	// RVA: 0x151C3A4
	private static void .cctor() { }

	// RVA: 0x151C410
	public void .ctor() { }

	// RVA: 0x151C418
	internal int <GetUnusedSmoothingGroup>b__5_0(Face x) { }

	// RVA: 0x151C434
	internal int <ApplySmoothingGroups>b__9_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder
public static class Smoothing
{
	// Fields
	internal const int smoothingGroupNone = 0;
	internal const int smoothRangeMin = 1;
	internal const int smoothRangeMax = 24;
	internal const int hardRangeMin = 25;
	internal const int hardRangeMax = 42;

	// Methods

	// RVA: 0x151AE20
	public static int GetUnusedSmoothingGroup(ProBuilderMesh mesh) { }

	// RVA: 0x151B0AC
	private static int GetNextUnusedSmoothingGroup(int start, System.Collections.Generic.HashSet<System.Int32> used) { }

	// RVA: 0x151B178
	public static bool IsSmooth(int index) { }

	// RVA: 0x151B18C
	public static void ApplySmoothingGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float angleThreshold) { }

	// RVA: 0x151B194
	internal static void ApplySmoothingGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float angleThreshold, Vector3[] normals) { }

	// RVA: 0x151BBF0
	private static bool FindSoftEdgesRecursive(Vector3[] normals, WingedEdge wing, float angleThreshold, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> processed) { }

	// RVA: 0x151BF64
	private static bool IsSoftEdge(Vector3[] normals, EdgeLookup left, EdgeLookup right, float threshold) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class Spline
{
	// Methods

	// RVA: 0x151C450
	internal static ProBuilderMesh Extrude(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> points, float radius, int columns, int rows, bool closeLoop, bool smooth) { }

	// RVA: 0x151C530
	internal static void Extrude(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ProBuilderMesh target) { }

	// RVA: 0x151C608
	internal static System.Collections.Generic.List<UnityEngine.Vector3> GetControlPoints(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, System.Collections.Generic.List<UnityEngine.Quaternion> rotations) { }

	// RVA: 0x151CACC
	internal static void Extrude(System.Collections.Generic.IList<UnityEngine.Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ProBuilderMesh target, System.Collections.Generic.IList<UnityEngine.Quaternion> pointRotations) { }

	// RVA: 0x151D550
	private static Quaternion GetRingRotation(System.Collections.Generic.IList<UnityEngine.Vector3> points, int i, bool closeLoop, float secant) { }

	// RVA: 0x151DE34
	private static Vector3[] VertexRing(Quaternion orientation, Vector3 offset, float radius, int segments) { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class Submesh
{
	// Fields
	internal int[] m_Indexes; // 0x10
	internal MeshTopology m_Topology; // 0x18
	internal int m_SubmeshIndex; // 0x1C

	// Methods

	// RVA: 0x151E018
	public System.Collections.Generic.IEnumerable<System.Int32> get_indexes() { }

	// RVA: 0x151E098
	public void set_indexes(System.Collections.Generic.IEnumerable<System.Int32> value) { }

	// RVA: 0x151E100
	public MeshTopology get_topology() { }

	// RVA: 0x151E108
	public void set_topology(MeshTopology value) { }

	// RVA: 0x151E110
	public int get_submeshIndex() { }

	// RVA: 0x151E118
	public void set_submeshIndex(int value) { }

	// RVA: 0x151E120
	public void .ctor(int submeshIndex, MeshTopology topology, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x151E1F8
	public void .ctor(Mesh mesh, int subMeshIndex) { }

	// RVA: 0x151E334
	public override string ToString() { }

	// RVA: 0x151E448
	internal static int GetSubmeshCount(ProBuilderMesh mesh) { }

	// RVA: 0x151E4AC
	public static Submesh[] GetSubmeshes(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, int submeshCount, MeshTopology preferredTopology) { }

	// RVA: 0x151EF38
	internal static void MapFaceMaterialsToSubmeshIndex(ProBuilderMesh mesh) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class Transform2D
{
	// Fields
	public Vector2 position; // 0x10
	public float rotation; // 0x18
	public Vector2 scale; // 0x1C

	// Methods

	// RVA: 0x151F094
	public void .ctor(Vector2 position, float rotation, Vector2 scale) { }

	// RVA: 0x151F0F0
	public Vector2 TransformPoint(Vector2 p) { }

	// RVA: 0x151F160
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
public static class TransformUtility
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]> s_ChildStack; // 0x0

	// Methods

	// RVA: 0x151F314
	internal static void UnparentChildren(Transform t) { }

	// RVA: 0x151F494
	internal static void ReparentChildren(Transform t) { }

	// RVA: 0x151F5E4
	public static Vertex TransformVertex(Transform transform, Vertex vertex) { }

	// RVA: 0x151F7E8
	public static Vertex InverseTransformVertex(Transform transform, Vertex vertex) { }

	// RVA: 0x151F9E4
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
internal struct Triangle
{
	// Fields
	private int m_A; // 0x10
	private int m_B; // 0x14
	private int m_C; // 0x18

	// Methods

	// RVA: 0x151FA80
	public int get_a() { }

	// RVA: 0x151FA88
	public int get_b() { }

	// RVA: 0x151FA90
	public int get_c() { }

	// RVA: 0x151FA98
	public System.Collections.Generic.IEnumerable<System.Int32> get_indices() { }

	// RVA: 0x151FB2C
	public void .ctor(int a, int b, int c) { }

	// RVA: 0x151FB38
	public bool Equals(Triangle other) { }

	// RVA: 0x151FB6C
	public override bool Equals(object obj) { }

	// RVA: 0x151FC1C
	public override int GetHashCode() { }

	// RVA: 0x151FC3C
	public bool IsAdjacent(Triangle other) { }

	// RVA: 0x151FCF8
	private bool ContainsEdge(Edge edge) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class TriggerBehaviour
{
	// Methods

	// RVA: 0x151FE50
	public override void Initialize() { }

	// RVA: 0x1520030
	public override void OnEnterPlayMode() { }

	// RVA: 0x15200B4
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x1520138
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class UnwrapParameters
{
	// Fields
	internal const float k_HardAngle = 88;
	internal const float k_PackMargin = 20;
	internal const float k_AngleError = 8;
	internal const float k_AreaError = 15;
	private float m_HardAngle; // 0x10
	private float m_PackMargin; // 0x14
	private float m_AngleError; // 0x18
	private float m_AreaError; // 0x1C

	// Methods

	// RVA: 0x1520140
	public float get_hardAngle() { }

	// RVA: 0x1520148
	public void set_hardAngle(float value) { }

	// RVA: 0x1520150
	public float get_packMargin() { }

	// RVA: 0x1520158
	public void set_packMargin(float value) { }

	// RVA: 0x1520160
	public float get_angleError() { }

	// RVA: 0x1520168
	public void set_angleError(float value) { }

	// RVA: 0x1520170
	public float get_areaError() { }

	// RVA: 0x1520178
	public void set_areaError(float value) { }

	// RVA: 0x15179A8
	public void .ctor() { }

	// RVA: 0x1520190
	public void .ctor(UnwrapParameters other) { }

	// RVA: 0x1520180
	public void Reset() { }

	// RVA: 0x1520218
	public override string ToString() { }

}

// Namespace: 
internal struct UVTransform
{
	// Fields
	public Vector2 translation; // 0x10
	public float rotation; // 0x18
	public Vector2 scale; // 0x1C

	// Methods

	// RVA: 0x1522A28
	public override string ToString() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.UvUnwrapping.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Face,System.Boolean> <>9__0_0; // 0x8

	// Methods

	// RVA: 0x1522B94
	private static void .cctor() { }

	// RVA: 0x1522C00
	public void .ctor() { }

	// RVA: 0x1522C08
	internal bool <SetAutoUV>b__0_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class UvUnwrapping
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.Vector2> s_UVTransformProjectionBuffer; // 0x0
	private static Vector2 s_TempVector2; // 0x8
	private static readonly System.Collections.Generic.List<System.Int32> s_IndexBuffer; // 0x10

	// Methods

	// RVA: 0x15203F8
	internal static void SetAutoUV(ProBuilderMesh mesh, Face[] faces, bool auto) { }

	// RVA: 0x152059C
	internal static void SetAutoAndAlignUnwrapParamsToUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> facesToConvert) { }

	// RVA: 0x1520E0C
	internal static AutoUnwrapSettings GetAutoUnwrapSettings(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1520F14
	internal static UVTransform GetUVTransform(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1521020
	private static int GetIndex(System.Collections.Generic.IList<System.Int32> collection, int index) { }

	// RVA: 0x1520780
	internal static UVTransform CalculateDelta(System.Collections.Generic.IList<UnityEngine.Vector2> src, System.Collections.Generic.IList<System.Int32> srcIndices, System.Collections.Generic.IList<UnityEngine.Vector2> dst, System.Collections.Generic.IList<System.Int32> dstIndices) { }

	// RVA: 0x15210E0
	private static Vector2 GetRotatedSize(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indices, Vector2 center, float rotation) { }

	// RVA: 0x15179EC
	internal static void Unwrap(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x1517B38
	internal static void CopyUVs(ProBuilderMesh mesh, Face source, Face dest) { }

	// RVA: 0x1521F4C
	internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1521528
	private static void ApplyUVSettings(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, AutoUnwrapSettings uvSettings) { }

	// RVA: 0x1522130
	private static void ScaleUVs(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, Vector2 scale, Bounds2D bounds) { }

	// RVA: 0x1522388
	private static void ApplyUVAnchor(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, Anchor anchor) { }

	// RVA: 0x15227C0
	internal static void UpgradeAutoUVScaleOffset(ProBuilderMesh mesh) { }

	// RVA: 0x15228EC
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class VectorHash
{
	// Fields
	public const float FltCompareResolution = 1000;

	// Methods

	// RVA: 0x1522C24
	private static int HashFloat(float f) { }

	// RVA: 0x1522C64
	public static int GetHashCode(Vector2 v) { }

	// RVA: 0x150C01C
	public static int GetHashCode(Vector3 v) { }

	// RVA: 0x1522CE0
	public static int GetHashCode(Vector4 v) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct Vector2Mask
{
	// Fields
	private const Byte X = 1;
	private const Byte Y = 2;
	public static readonly Vector2Mask XY; // 0x0
	private Byte m_Mask; // 0x10

	// Methods

	// RVA: 0x1522DC0
	public float get_x() { }

	// RVA: 0x1522DD8
	public float get_y() { }

	// RVA: 0x1522DF0
	public void .ctor(Vector3 v, float epsilon) { }

	// RVA: 0x1522E14
	public void .ctor(Byte mask) { }

	// RVA: 0x1522E1C
	public static Vector2 op_Implicit(Vector2Mask mask) { }

	// RVA: 0x1522E90
	public static Vector2Mask op_Implicit(Vector2 v) { }

	// RVA: 0x1522EB8
	public static Vector2Mask op_BitwiseOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x1522EC0
	public static Vector2Mask op_BitwiseAnd(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x1522EC8
	public static Vector2Mask op_ExclusiveOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x1522ED0
	public static Vector2 op_Multiply(Vector2Mask mask, float value) { }

	// RVA: 0x1522F58
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal struct Vector3Mask
{
	// Fields
	private const Byte X = 1;
	private const Byte Y = 2;
	private const Byte Z = 4;
	public static readonly Vector3Mask XYZ; // 0x0
	private Byte m_Mask; // 0x10

	// Methods

	// RVA: 0x1522FA8
	public float get_x() { }

	// RVA: 0x1522FC0
	public float get_y() { }

	// RVA: 0x1522FD8
	public float get_z() { }

	// RVA: 0x1522FF0
	public void .ctor(Vector3 v, float epsilon) { }

	// RVA: 0x1523024
	public void .ctor(Byte mask) { }

	// RVA: 0x152302C
	public override string ToString() { }

	// RVA: 0x1523144
	public int get_active() { }

	// RVA: 0x1523160
	public static Vector3 op_Implicit(Vector3Mask mask) { }

	// RVA: 0x15231DC
	public static Vector3Mask op_Explicit(Vector3 v) { }

	// RVA: 0x1523214
	public static Vector3Mask op_BitwiseOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x152321C
	public static Vector3Mask op_BitwiseAnd(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1523224
	public static Vector3Mask op_ExclusiveOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x152322C
	public static Vector3 op_Multiply(Vector3Mask mask, float value) { }

	// RVA: 0x15232C0
	public static Vector3 op_Multiply(Vector3Mask mask, Vector3 value) { }

	// RVA: 0x1523364
	public static Vector3 op_Multiply(Quaternion rotation, Vector3Mask mask) { }

	// RVA: 0x152357C
	public static bool op_Equality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x152358C
	public static bool op_Inequality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x15235F8
	public float get_Item(int i) { }

	// RVA: 0x152365C
	public void set_Item(int i, float value) { }

	// RVA: 0x15236D4
	public bool Equals(Vector3Mask other) { }

	// RVA: 0x15236E4
	public override bool Equals(object obj) { }

	// RVA: 0x15237B4
	public override int GetHashCode() { }

	// RVA: 0x15237BC
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class Vertex
{
	// Fields
	private Vector3 m_Position; // 0x10
	private Color m_Color; // 0x1C
	private Vector3 m_Normal; // 0x2C
	private Vector4 m_Tangent; // 0x38
	private Vector2 m_UV0; // 0x48
	private Vector2 m_UV2; // 0x50
	private Vector4 m_UV3; // 0x58
	private Vector4 m_UV4; // 0x68
	private MeshArrays m_Attributes; // 0x78

	// Methods

	// RVA: 0x152380C
	public Vector3 get_position() { }

	// RVA: 0x1523818
	public void set_position(Vector3 value) { }

	// RVA: 0x1523844
	public Color get_color() { }

	// RVA: 0x1523850
	public void set_color(Color value) { }

	// RVA: 0x1523888
	public Vector3 get_normal() { }

	// RVA: 0x1523894
	public void set_normal(Vector3 value) { }

	// RVA: 0x15238CC
	public Vector4 get_tangent() { }

	// RVA: 0x15238D8
	public void set_tangent(Vector4 value) { }

	// RVA: 0x1523910
	public Vector2 get_uv0() { }

	// RVA: 0x1523918
	public void set_uv0(Vector2 value) { }

	// RVA: 0x152394C
	public Vector2 get_uv2() { }

	// RVA: 0x1523954
	public void set_uv2(Vector2 value) { }

	// RVA: 0x1523988
	public Vector4 get_uv3() { }

	// RVA: 0x1523994
	public void set_uv3(Vector4 value) { }

	// RVA: 0x15239CC
	public Vector4 get_uv4() { }

	// RVA: 0x15239D8
	public void set_uv4(Vector4 value) { }

	// RVA: 0x1523A10
	internal MeshArrays get_attributes() { }

	// RVA: 0x1523A18
	public bool HasArrays(MeshArrays attribute) { }

	// RVA: 0x1523A28
	private bool get_hasPosition() { }

	// RVA: 0x1523830
	private void set_hasPosition(bool value) { }

	// RVA: 0x1523A34
	private bool get_hasColor() { }

	// RVA: 0x1523868
	private void set_hasColor(bool value) { }

	// RVA: 0x1523A40
	private bool get_hasNormal() { }

	// RVA: 0x15238AC
	private void set_hasNormal(bool value) { }

	// RVA: 0x1523A4C
	private bool get_hasTangent() { }

	// RVA: 0x15238F0
	private void set_hasTangent(bool value) { }

	// RVA: 0x1523A58
	private bool get_hasUV0() { }

	// RVA: 0x152392C
	private void set_hasUV0(bool value) { }

	// RVA: 0x1523A64
	private bool get_hasUV2() { }

	// RVA: 0x1523968
	private void set_hasUV2(bool value) { }

	// RVA: 0x1523A70
	private bool get_hasUV3() { }

	// RVA: 0x15239AC
	private void set_hasUV3(bool value) { }

	// RVA: 0x1523A7C
	private bool get_hasUV4() { }

	// RVA: 0x15239F0
	private void set_hasUV4(bool value) { }

	// RVA: 0x1523A88
	public void .ctor() { }

	// RVA: 0x1523A90
	public override bool Equals(object obj) { }

	// RVA: 0x1523B10
	public bool Equals(Vertex other) { }

	// RVA: 0x1523C60
	public bool Equals(Vertex other, MeshArrays mask) { }

	// RVA: 0x1523E14
	public override int GetHashCode() { }

	// RVA: 0x1523E84
	public void .ctor(Vertex vertex) { }

	// RVA: 0x1523FC8
	public static bool op_Equality(Vertex a, Vertex b) { }

	// RVA: 0x1523FF0
	public static bool op_Inequality(Vertex a, Vertex b) { }

	// RVA: 0x152402C
	public static Vertex op_Addition(Vertex a, Vertex b) { }

	// RVA: 0x15240A8
	public static Vertex Add(Vertex a, Vertex b) { }

	// RVA: 0x1524124
	public void Add(Vertex b) { }

	// RVA: 0x1524224
	public static Vertex op_Subtraction(Vertex a, Vertex b) { }

	// RVA: 0x15242A0
	public static Vertex Subtract(Vertex a, Vertex b) { }

	// RVA: 0x152431C
	public void Subtract(Vertex b) { }

	// RVA: 0x152441C
	public static Vertex op_Multiply(Vertex a, float value) { }

	// RVA: 0x1524420
	public static Vertex Multiply(Vertex a, float value) { }

	// RVA: 0x15244DC
	public void Multiply(float value) { }

	// RVA: 0x1524520
	public static Vertex op_Division(Vertex a, float value) { }

	// RVA: 0x1524524
	public static Vertex Divide(Vertex a, float value) { }

	// RVA: 0x15245E0
	public void Divide(float value) { }

	// RVA: 0x1524624
	public void Normalize() { }

	// RVA: 0x1524C58
	public string ToString(string args) { }

	// RVA: 0x1524F74
	public static void GetArrays(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, Vector3[] position, Color[] color, Vector2[] uv0, Vector3[] normal, Vector4[] tangent, Vector2[] uv2, System.Collections.Generic.List<UnityEngine.Vector4>& uv3, System.Collections.Generic.List<UnityEngine.Vector4>& uv4) { }

	// RVA: 0x1524FA0
	public static void GetArrays(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, Vector3[] position, Color[] color, Vector2[] uv0, Vector3[] normal, Vector4[] tangent, Vector2[] uv2, System.Collections.Generic.List<UnityEngine.Vector4>& uv3, System.Collections.Generic.List<UnityEngine.Vector4>& uv4, MeshArrays attributes) { }

	// RVA: 0x15259E8
	public static void SetMesh(Mesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x1525CE0
	public static Vertex Average(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x15269DC
	public static Vertex Mix(Vertex x, Vertex y, float weight) { }

}

// Namespace: UnityEngine.ProBuilder
public static class VertexPositioning
{
	// Fields
	private static System.Collections.Generic.List<System.Int32> s_CoincidentVertices; // 0x0

	// Methods

	// RVA: 0x1526D0C
	public static Vector3[] VerticesInWorldSpace(ProBuilderMesh mesh) { }

	// RVA: 0x1526EE8
	public static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset) { }

	// RVA: 0x1527020
	internal static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset, float snapValue, bool snapAxisOnly) { }

	// RVA: 0x15275F0
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, Vector3 offset) { }

	// RVA: 0x15278E8
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Vector3 offset) { }

	// RVA: 0x1527A38
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, Vector3 offset) { }

	// RVA: 0x1527740
	private static void TranslateVerticesInternal(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indices, Vector3 offset) { }

	// RVA: 0x1527B88
	public static void SetSharedVertexPosition(ProBuilderMesh mesh, int sharedVertexHandle, Vector3 position) { }

	// RVA: 0x1527F3C
	internal static void SetSharedVertexValues(ProBuilderMesh mesh, int sharedVertexHandle, Vertex vertex) { }

	// RVA: 0x1528220
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.WingedEdge.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.WingedEdge,UnityEngine.ProBuilder.Edge> <>9__32_1; // 0x8
	public static System.Converter<UnityEngine.ProBuilder.Edge,System.Int32> <>9__32_2; // 0x10

	// Methods

	// RVA: 0x152A544
	private static void .cctor() { }

	// RVA: 0x152A5B0
	public void .ctor() { }

	// RVA: 0x152A5B8
	internal Edge <SortCommonIndexesByAdjacency>b__32_1(WingedEdge y) { }

	// RVA: 0x152A5D4
	internal int <SortCommonIndexesByAdjacency>b__32_2(Edge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public System.Collections.Generic.HashSet<System.Int32> common; // 0x10

	// Methods

	// RVA: 0x1529A20
	public void .ctor() { }

	// RVA: 0x152A5DC
	internal bool <SortCommonIndexesByAdjacency>b__0(WingedEdge x) { }

}

// Namespace: UnityEngine.ProBuilder
public sealed class WingedEdge
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Edge,UnityEngine.ProBuilder.WingedEdge> k_OppositeEdgeDictionary; // 0x0
	private EdgeLookup <edge>k__BackingField; // 0x10
	private Face <face>k__BackingField; // 0x20
	private WingedEdge <next>k__BackingField; // 0x28
	private WingedEdge <previous>k__BackingField; // 0x30
	private WingedEdge <opposite>k__BackingField; // 0x38

	// Methods

	// RVA: 0x15282BC
	public EdgeLookup get_edge() { }

	// RVA: 0x15282C8
	private void set_edge(EdgeLookup value) { }

	// RVA: 0x15282D0
	public Face get_face() { }

	// RVA: 0x15282D8
	private void set_face(Face value) { }

	// RVA: 0x15282E0
	public WingedEdge get_next() { }

	// RVA: 0x15282E8
	private void set_next(WingedEdge value) { }

	// RVA: 0x15282F0
	public WingedEdge get_previous() { }

	// RVA: 0x15282F8
	private void set_previous(WingedEdge value) { }

	// RVA: 0x1528300
	public WingedEdge get_opposite() { }

	// RVA: 0x1528308
	private void set_opposite(WingedEdge value) { }

	// RVA: 0x1528310
	private void .ctor() { }

	// RVA: 0x1528318
	public bool Equals(WingedEdge other) { }

	// RVA: 0x15283B8
	public override bool Equals(object obj) { }

	// RVA: 0x1528568
	public override int GetHashCode() { }

	// RVA: 0x15285E0
	public int Count() { }

	// RVA: 0x1528618
	public override string ToString() { }

	// RVA: 0x1528838
	internal static int[] MakeQuad(WingedEdge left, WingedEdge right) { }

	// RVA: 0x1528F8C
	public WingedEdge GetAdjacentEdgeWithCommonIndex(int common) { }

	// RVA: 0x152907C
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> SortEdgesByAdjacency(Face face) { }

	// RVA: 0x1529198
	public static void SortEdgesByAdjacency(System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x152936C
	public static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge>> GetSpokes(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings) { }

	// RVA: 0x15296EC
	internal static System.Collections.Generic.List<System.Int32> SortCommonIndexesByAdjacency(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, System.Collections.Generic.HashSet<System.Int32> common) { }

	// RVA: 0x1529A28
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetWingedEdges(ProBuilderMesh mesh, bool oneWingPerFace) { }

	// RVA: 0x1529B40
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetWingedEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool oneWingPerFace) { }

	// RVA: 0x152A4A8
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
public sealed class WingedEdgeEnumerator
{
	// Fields
	private WingedEdge m_Start; // 0x10
	private WingedEdge m_Current; // 0x18

	// Methods

	// RVA: 0x152A678
	public void .ctor(WingedEdge start) { }

	// RVA: 0x152A6BC
	public bool MoveNext() { }

	// RVA: 0x152A744
	public void Reset() { }

	// RVA: 0x152A750
	public WingedEdge get_Current() { }

	// RVA: 0x152A758
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x152A760
	public void Dispose() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Arch
{
	// Fields
	private float m_Thickness; // 0x10
	private int m_NumberOfSides; // 0x14
	private float m_ArchDegrees; // 0x18
	private bool m_EndCaps; // 0x1C
	private bool m_Smooth; // 0x1D

	// Methods

	// RVA: 0x152A764
	public override void CopyShape(Shape shape) { }

	// RVA: 0x152A814
	private Vector3[] GetFace(Vector2 vertex1, Vector2 vertex2, float depth) { }

	// RVA: 0x152A8DC
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x152B4E8
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Cone
{
	// Fields
	internal int m_NumberOfSides; // 0x10
	private float m_Radius; // 0x14
	private bool m_Smooth; // 0x18

	// Methods

	// RVA: 0x152B518
	public override void CopyShape(Shape shape) { }

	// RVA: 0x152B5C0
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x152B738
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x152C324
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Cube
{
	// Fields
	private static readonly Vector3[] k_CubeVertices; // 0x0
	private static readonly int[] k_CubeTriangles; // 0x8

	// Methods

	// RVA: 0x152C33C
	public override void CopyShape(Shape shape) { }

	// RVA: 0x152C340
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x152C564
	public void .ctor() { }

	// RVA: 0x152C56C
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Cylinder
{
	// Fields
	private int m_AxisDivisions; // 0x10
	private int m_HeightCuts; // 0x14
	private bool m_Smooth; // 0x18

	// Methods

	// RVA: 0x152C6FC
	public override void CopyShape(Shape shape) { }

	// RVA: 0x152C7EC
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x152C818
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x152D39C
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Door
{
	// Fields
	private float m_DoorHeight; // 0x10
	private float m_LegWidth; // 0x14

	// Methods

	// RVA: 0x152D3B4
	public override void CopyShape(Shape shape) { }

	// RVA: 0x152D47C
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x152E3D8
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Pipe
{
	// Fields
	private float m_Thickness; // 0x10
	private int m_NumberOfSides; // 0x14
	private int m_HeightCuts; // 0x18
	private bool m_Smooth; // 0x1C

	// Methods

	// RVA: 0x152E3EC
	public override void CopyShape(Shape shape) { }

	// RVA: 0x152E494
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x152E4C0
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x152F05C
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Plane
{
	// Fields
	private int m_HeightSegments; // 0x10
	private int m_WidthSegments; // 0x14

	// Methods

	// RVA: 0x152F078
	public override void CopyShape(Shape shape) { }

	// RVA: 0x152F140
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x152F438
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Prism
{
	// Methods

	// RVA: 0x152F448
	public override void CopyShape(Shape shape) { }

	// RVA: 0x152F44C
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x152FB90
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
internal sealed class ProBuilderShape
{
	// Fields
	private Shape m_Shape; // 0x20
	private Vector3 m_Size; // 0x28
	private Quaternion m_Rotation; // 0x34
	private ProBuilderMesh m_Mesh; // 0x48
	private PivotLocation m_PivotLocation; // 0x50
	private Vector3 m_PivotPosition; // 0x54
	internal UInt16 m_UnmodifiedMeshVersion; // 0x60
	private Bounds m_EditionBounds; // 0x64
	private Bounds m_ShapeBox; // 0x7C

	// Methods

	// RVA: 0x152FB98
	public Shape get_shape() { }

	// RVA: 0x152FBA0
	public void set_shape(Shape value) { }

	// RVA: 0x152FBA8
	public PivotLocation get_pivotLocation() { }

	// RVA: 0x152FBB0
	public void set_pivotLocation(PivotLocation value) { }

	// RVA: 0x152FBB8
	public Vector3 get_pivotLocalPosition() { }

	// RVA: 0x152FBC4
	public void set_pivotLocalPosition(Vector3 value) { }

	// RVA: 0x152FBD0
	public Vector3 get_pivotGlobalPosition() { }

	// RVA: 0x152FD94
	public void set_pivotGlobalPosition(Vector3 value) { }

	// RVA: 0x152FE00
	public Vector3 get_size() { }

	// RVA: 0x152FE0C
	public void set_size(Vector3 value) { }

	// RVA: 0x152FF18
	public Quaternion get_rotation() { }

	// RVA: 0x152FF24
	public void set_rotation(Quaternion value) { }

	// RVA: 0x152FF30
	public Bounds get_editionBounds() { }

	// RVA: 0x152FFEC
	public Bounds get_shapeBox() { }

	// RVA: 0x1530000
	public bool get_isEditable() { }

	// RVA: 0x152FC10
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x1530034
	private void OnValidate() { }

	// RVA: 0x1530134
	internal void UpdateComponent() { }

	// RVA: 0x153055C
	internal void UpdateBounds(Bounds bounds) { }

	// RVA: 0x15306C8
	internal void Rebuild(Bounds bounds, Quaternion rotation, Vector3 cornerPivot) { }

	// RVA: 0x15303A4
	private void Rebuild() { }

	// RVA: 0x1530AE0
	internal void SetShape(Shape shape, PivotLocation location) { }

	// RVA: 0x1530C70
	internal void RotateInsideBounds(Quaternion deltaRotation) { }

	// RVA: 0x1530174
	private void ResetPivot(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1530890
	internal void RebuildPivot(Vector3 size, Quaternion rotation) { }

	// RVA: 0x1530D50
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
[Serializable]
public abstract class Shape
{
	// Methods

	// RVA: 0x1530E40
	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: -1
	public abstract Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: -1
	public abstract void CopyShape(Shape shape) { }

	// RVA: 0x152B510
	protected void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class ShapeAttribute
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x1530E98
	public void .ctor(string n) { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Sphere
{
	// Fields
	private static readonly Vector3[] k_IcosphereVertices; // 0x0
	private static readonly int[] k_IcosphereTriangles; // 0x8
	private int m_Subdivisions; // 0x10
	private int m_BottomMostVertexIndex; // 0x14
	private bool m_Smooth; // 0x18

	// Methods

	// RVA: 0x1530ECC
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1530F6C
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x1530FD0
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15319E4
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x1531F44
	public void .ctor() { }

	// RVA: 0x1531F5C
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Sprite
{
	// Methods

	// RVA: 0x1532160
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1532164
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153251C
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
internal enum StepGenerationType
{
	// Fields
	public int value__; // 0x10
	public const StepGenerationType Height = 0;
	public const StepGenerationType Count = 1;
}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Stairs
{
	// Fields
	private StepGenerationType m_StepGenerationType; // 0x10
	private float m_StepsHeight; // 0x14
	private int m_StepsCount; // 0x18
	private bool m_HomogeneousSteps; // 0x1C
	private float m_Circumference; // 0x20
	private bool m_Sides; // 0x24
	private float m_InnerRadius; // 0x28

	// Methods

	// RVA: 0x1532524
	public bool get_sides() { }

	// RVA: 0x153252C
	public void set_sides(bool value) { }

	// RVA: 0x1532534
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15325FC
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1534704
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x1533748
	private Bounds BuildStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1532654
	private Bounds BuildCurvedStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1534864
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Torus
{
	// Fields
	private int m_Rows; // 0x10
	private int m_Columns; // 0x14
	private float m_TubeRadius; // 0x18
	private float m_HorizontalCircumference; // 0x1C
	private float m_VerticalCircumference; // 0x20
	private bool m_Smooth; // 0x24

	// Methods

	// RVA: 0x1534890
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1534938
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x15349BC
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15353B4
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x15356EC
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x1535960
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.AppendElements.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector3[],System.Int32> <>9__8_0; // 0x8
	public static System.Func<UnityEngine.ProBuilder.Vertex,UnityEngine.Vector3> <>9__10_0; // 0x10
	public static System.Func<UnityEngine.ProBuilder.Vertex,UnityEngine.Vector3> <>9__10_1; // 0x18
	public static System.Func<UnityEngine.ProBuilder.FaceRebuildData,UnityEngine.ProBuilder.Face> <>9__18_0; // 0x20

	// Methods

	// RVA: 0x1540E64
	private static void .cctor() { }

	// RVA: 0x1540ED0
	public void .ctor() { }

	// RVA: 0x1540ED8
	internal int <CreateShapeFromPolygon>b__8_0(Vector3[] arr) { }

	// RVA: 0x1540EF4
	internal Vector3 <FaceWithVerticesAndHole>b__10_0(Vertex v) { }

	// RVA: 0x1540F14
	internal Vector3 <FaceWithVerticesAndHole>b__10_1(Vertex v) { }

	// RVA: 0x1540F34
	internal Face <InsertVertexInFace>b__18_0(FaceRebuildData f) { }

}

// Namespace: 
private sealed class <>c__DisplayClass17_0
{
	// Fields
	public int delCount; // 0x10

	// Methods

	// RVA: 0x153E3FC
	public void .ctor() { }

	// RVA: 0x1540F50
	internal Edge <AppendVerticesToEdge>b__0(EdgeLookup x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class AppendElements
{
	// Methods

	// RVA: 0x1535E14
	internal static Face AppendFace(ProBuilderMesh mesh, Vector3[] positions, Color[] colors, Vector2[] uv0s, Vector4[] uv2s, Vector4[] uv3s, Face face, int[] common) { }

	// RVA: 0x15366BC
	public static Face[] AppendFaces(ProBuilderMesh mesh, Vector3[][] positions, Color[][] colors, Vector2[][] uvs, Face[] faces, Int32[][] shared) { }

	// RVA: 0x1536CF0
	public static Face CreatePolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes, bool unordered) { }

	// RVA: 0x15374D8
	public static Face CreatePolygonWithHole(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes, System.Collections.Generic.IList<System.Collections.Generic.IList<System.Int32>> holes) { }

	// RVA: 0x15385C4
	public static ActionResult CreateShapeFromPolygon(PolyShape poly) { }

	// RVA: 0x1538608
	internal static void ClearAndRefreshMesh(ProBuilderMesh mesh) { }

	// RVA: 0x1538600
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals) { }

	// RVA: 0x15393D0
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals, Vector3 cameraLookAt, System.Collections.Generic.IList<System.Collections.Generic.IList<UnityEngine.Vector3>> holePoints) { }

	// RVA: 0x1538650
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals, System.Collections.Generic.IList<System.Collections.Generic.IList<UnityEngine.Vector3>> holePoints) { }

	// RVA: 0x15373EC
	internal static FaceRebuildData FaceWithVertices(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, bool unordered) { }

	// RVA: 0x1538084
	internal static FaceRebuildData FaceWithVerticesAndHole(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> borderVertices, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>> holes) { }

	// RVA: 0x1539A5C
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> TentCapWithVertices(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> path) { }

	// RVA: 0x15393D8
	public static void DuplicateAndFlip(ProBuilderMesh mesh, Face[] faces) { }

	// RVA: 0x1539CF8
	public static Face Bridge(ProBuilderMesh mesh, Edge a, Edge b, bool allowNonManifoldGeometry) { }

	// RVA: 0x153B444
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points) { }

	// RVA: 0x153B44C
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points, bool insertOnEdge) { }

	// RVA: 0x153C304
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> AppendVerticesToEdge(ProBuilderMesh mesh, Edge edge, int count) { }

	// RVA: 0x153C390
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> AppendVerticesToEdge(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, int count) { }

	// RVA: 0x153E8D4
	public static Face[] InsertVertexInFace(ProBuilderMesh mesh, Face face, Vector3 point) { }

	// RVA: 0x153F5C8
	public static Vertex InsertVertexOnEdge(ProBuilderMesh mesh, Edge originalEdge, Vector3 point) { }

	// RVA: 0x1540AA4
	public static Vertex InsertVertexInMesh(ProBuilderMesh mesh, Vector3 point, Vector3 normal) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.Bevel.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.FaceRebuildData,UnityEngine.ProBuilder.Face> <>9__0_0; // 0x8
	public static System.Func<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.FaceRebuildData,System.Collections.Generic.List<System.Int32>>,System.Int32> <>9__0_6; // 0x10
	public static System.Func<UnityEngine.ProBuilder.FaceRebuildData,UnityEngine.ProBuilder.Face> <>9__0_1; // 0x18
	public static System.Func<UnityEngine.ProBuilder.FaceRebuildData,UnityEngine.ProBuilder.Face> <>9__0_2; // 0x20
	public static System.Func<UnityEngine.ProBuilder.FaceRebuildData,UnityEngine.ProBuilder.Face> <>9__0_3; // 0x28

	// Methods

	// RVA: 0x1544F60
	private static void .cctor() { }

	// RVA: 0x1544FCC
	public void .ctor() { }

	// RVA: 0x1544FD4
	internal Face <BevelEdges>b__0_0(FaceRebuildData x) { }

	// RVA: 0x1544FF0
	internal int <BevelEdges>b__0_6(UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.FaceRebuildData,System.Collections.Generic.List<System.Int32>> x) { }

	// RVA: 0x15450D4
	internal Face <BevelEdges>b__0_1(FaceRebuildData x) { }

	// RVA: 0x15450F0
	internal Face <BevelEdges>b__0_2(FaceRebuildData x) { }

	// RVA: 0x154510C
	internal Face <BevelEdges>b__0_3(FaceRebuildData x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Face,System.Collections.Generic.List<System.Int32>> ignore; // 0x10
	public SharedVertex[] sharedIndexes; // 0x18
	public System.Func<System.Int32,System.Int32> <>9__7; // 0x20
	public System.Func<System.Int32,System.Int32> <>9__8; // 0x28

	// Methods

	// RVA: 0x15441D0
	public void .ctor() { }

	// RVA: 0x1545128
	internal int <BevelEdges>b__7(int x) { }

	// RVA: 0x1545168
	internal int <BevelEdges>b__8(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_1
{
	// Fields
	public EdgeLookup lup; // 0x10

	// Methods

	// RVA: 0x15441D8
	public void .ctor() { }

	// RVA: 0x15451A8
	internal bool <BevelEdges>b__4(WingedEdge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_2
{
	// Fields
	public int c; // 0x10
	public UnityEngine.ProBuilder.MeshOperations.Bevel.<>c__DisplayClass0_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x1544C8C
	public void .ctor() { }

	// RVA: 0x15451E0
	internal bool <BevelEdges>b__5(WingedEdge x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class Bevel
{
	// Fields
	private static readonly int[] k_BridgeIndexesTri; // 0x0

	// Methods

	// RVA: 0x1540FC0
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> BevelEdges(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, float amount) { }

	// RVA: 0x154460C
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> GetBridgeFaces(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, WingedEdge left, WingedEdge right, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.FaceRebuildData,System.Collections.Generic.List<System.Int32>>>> holes) { }

	// RVA: 0x15441E0
	private static void SlideEdge(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, WingedEdge we, float amount) { }

	// RVA: 0x1544DB4
	private static Edge GetLeadingEdge(WingedEdge wing, int common) { }

	// RVA: 0x1544EBC
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.CombineMeshes.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Face,System.Int32> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x154841C
	private static void .cctor() { }

	// RVA: 0x1548488
	public void .ctor() { }

	// RVA: 0x1548490
	internal int <SplitByMaxVertexCount>b__5_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class CombineMeshes
{
	// Methods

	// RVA: 0x154534C
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> Combine(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes) { }

	// RVA: 0x1545928
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> Combine(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes, ProBuilderMesh meshTarget) { }

	// RVA: 0x1545350
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> CombineToNewMeshes(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes) { }

	// RVA: 0x15463A0
	private static void AccumulateMeshesInfo(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes, int offset, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>& vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face>& faces, System.Collections.Generic.List<UnityEngine.ProBuilder.Face>& autoUvFaces, System.Collections.Generic.List<UnityEngine.ProBuilder.SharedVertex>& sharedVertices, System.Collections.Generic.List<UnityEngine.ProBuilder.SharedVertex>& sharedTextures, System.Collections.Generic.List<UnityEngine.Material>& materialMap, Transform targetTransform) { }

	// RVA: 0x1547AEC
	private static ProBuilderMesh CreateMeshFromSplit(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVertexLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedTextureLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> remap, Material[] materials) { }

	// RVA: 0x1546EC8
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> SplitByMaxVertexCount(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedTextures, UInt32 maxVertexCount) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal sealed class ConnectFaceRebuildData
{
	// Fields
	public FaceRebuildData faceRebuildData; // 0x10
	public System.Collections.Generic.List<System.Int32> newVertexIndexes; // 0x18

	// Methods

	// RVA: 0x15484AC
	public void .ctor(FaceRebuildData faceRebuildData, System.Collections.Generic.List<System.Int32> newVertexIndexes) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.ConnectElements.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge>> <>9__0_0; // 0x8
	public static System.Func<UnityEngine.ProBuilder.Face,System.Int32> <>9__2_1; // 0x10
	public static System.Func<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData,UnityEngine.ProBuilder.FaceRebuildData> <>9__2_2; // 0x18
	public static System.Func<UnityEngine.ProBuilder.Face,System.Int32> <>9__3_0; // 0x20
	public static System.Func<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData,UnityEngine.ProBuilder.FaceRebuildData> <>9__3_1; // 0x28
	public static System.Func<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData,System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge>> <>9__3_2; // 0x30
	public static System.Func<UnityEngine.ProBuilder.EdgeLookup,UnityEngine.ProBuilder.Edge> <>9__3_4; // 0x38
	public static System.Func<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>> <>9__5_0; // 0x40
	public static System.Func<System.Int32,System.Collections.Generic.List<System.Int32>> <>9__5_1; // 0x48
	public static System.Func<UnityEngine.ProBuilder.WingedEdge,UnityEngine.ProBuilder.Edge> <>9__5_2; // 0x50
	public static System.Func<UnityEngine.ProBuilder.WingedEdge,UnityEngine.ProBuilder.Edge> <>9__6_0; // 0x58
	public static System.Func<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>> <>9__8_0; // 0x60
	public static System.Func<System.Int32,System.Collections.Generic.List<System.Int32>> <>9__8_1; // 0x68
	public static System.Func<System.Int32,System.Collections.Generic.List<System.Int32>> <>9__8_2; // 0x70

	// Methods

	// RVA: 0x154E4D8
	private static void .cctor() { }

	// RVA: 0x154E544
	public void .ctor() { }

	// RVA: 0x154E54C
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <Connect>b__0_0(Face x) { }

	// RVA: 0x154E568
	internal int <Connect>b__2_1(Face x) { }

	// RVA: 0x154E584
	internal FaceRebuildData <Connect>b__2_2(ConnectFaceRebuildData x) { }

	// RVA: 0x154E5A0
	internal int <Connect>b__3_0(Face x) { }

	// RVA: 0x154E5BC
	internal FaceRebuildData <Connect>b__3_1(ConnectFaceRebuildData x) { }

	// RVA: 0x154E5D8
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <Connect>b__3_2(ConnectFaceRebuildData x) { }

	// RVA: 0x154E604
	internal Edge <Connect>b__3_4(EdgeLookup x) { }

	// RVA: 0x154E60C
	internal System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> <ConnectEdgesInFace>b__5_0(int x) { }

	// RVA: 0x154E680
	internal System.Collections.Generic.List<System.Int32> <ConnectEdgesInFace>b__5_1(int x) { }

	// RVA: 0x154E6F4
	internal Edge <ConnectEdgesInFace>b__5_2(WingedEdge x) { }

	// RVA: 0x154E710
	internal Edge <InsertVertices>b__6_0(WingedEdge x) { }

	// RVA: 0x154E72C
	internal System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> <ConnectIndexesPerFace>b__8_0(int x) { }

	// RVA: 0x154E7A0
	internal System.Collections.Generic.List<System.Int32> <ConnectIndexesPerFace>b__8_1(int x) { }

	// RVA: 0x154E814
	internal System.Collections.Generic.List<System.Int32> <ConnectIndexesPerFace>b__8_2(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup; // 0x10
	public ProBuilderMesh mesh; // 0x18

	// Methods

	// RVA: 0x154B958
	public void .ctor() { }

	// RVA: 0x154E888
	internal int <Connect>b__0(int x) { }

	// RVA: 0x154E904
	internal int <Connect>b__3(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public System.Collections.Generic.HashSet<System.Int32> appended; // 0x10

	// Methods

	// RVA: 0x154E4D0
	public void .ctor() { }

	// RVA: 0x154E94C
	internal bool <Connect>b__3(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ConnectElements
{
	// Methods

	// RVA: 0x15484FC
	public static Face[] Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x154A4CC
	public static UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face[],UnityEngine.ProBuilder.Edge[]> Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x154A560
	public static int[] Connect(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x15488E0
	internal static ActionResult Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Face[] addedFaces, Edge[] connections, bool returnFaces, bool returnEdges, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> faceMask) { }

	// RVA: 0x154DCA8
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectEdgesInFace(Face face, WingedEdge a, WingedEdge b, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x154D240
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectEdgesInFace(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> edges, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x154CBE8
	private static bool InsertVertices(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> edges, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, ConnectFaceRebuildData data) { }

	// RVA: 0x154C410
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, int a, int b, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x154B960
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, System.Collections.Generic.List<System.Int32> indexes, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup, int sharedIndexOffset) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.DeleteElements.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x154F200
	private static void .cctor() { }

	// RVA: 0x154F26C
	public void .ctor() { }

	// RVA: 0x154F274
	internal System.Collections.Generic.IEnumerable<System.Int32> <DeleteFaces>b__3_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public System.Collections.Generic.List<System.Int32> sorted; // 0x10
	public int[] offset; // 0x18

	// Methods

	// RVA: 0x154E9E0
	public void .ctor() { }

	// RVA: 0x154F290
	internal bool <DeleteVertices>b__0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

	// RVA: 0x154F39C
	internal System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> <DeleteVertices>b__1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

	// RVA: 0x154F5E4
	internal bool <DeleteVertices>b__2(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

	// RVA: 0x154F6F0
	internal System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> <DeleteVertices>b__3(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x154E9E8
	public void .ctor() { }

	// RVA: 0x154F938
	internal int <DeleteFaces>b__0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class DeleteElements
{
	// Methods

	// RVA: 0x153E404
	public static void DeleteVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> distinctIndexes) { }

	// RVA: 0x153C278
	public static int[] DeleteFace(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1544C94
	public static int[] DeleteFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x154E9F0
	public static int[] DeleteFaces(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> faceIndexes) { }

	// RVA: 0x154F0B0
	public static int[] RemoveDegenerateTriangles(ProBuilderMesh mesh) { }

	// RVA: 0x154F158
	public static int[] RemoveUnusedVertices(ProBuilderMesh mesh) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.ElementSelection.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge>> <>9__5_0; // 0x8
	public static System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>>,System.Boolean> <>9__5_1; // 0x10
	public static System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>>,UnityEngine.ProBuilder.Edge> <>9__5_2; // 0x18
	public static System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>>,System.Boolean> <>9__7_0; // 0x20
	public static System.Func<System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>>,UnityEngine.ProBuilder.Face> <>9__7_1; // 0x28
	public static System.Func<UnityEngine.ProBuilder.EdgeLookup,UnityEngine.ProBuilder.Edge> <>9__10_0; // 0x30
	public static System.Func<UnityEngine.ProBuilder.EdgeLookup,UnityEngine.ProBuilder.Edge> <>9__11_0; // 0x38
	public static System.Func<UnityEngine.ProBuilder.EdgeLookup,UnityEngine.ProBuilder.Edge> <>9__12_0; // 0x40
	public static System.Func<UnityEngine.ProBuilder.EdgeLookup,UnityEngine.ProBuilder.Edge> <>9__13_0; // 0x48
	public static System.Func<UnityEngine.ProBuilder.WingedEdge,UnityEngine.ProBuilder.Edge> <>9__14_0; // 0x50
	public static System.Func<UnityEngine.ProBuilder.WingedEdge,UnityEngine.ProBuilder.Edge> <>9__15_0; // 0x58
	public static System.Func<UnityEngine.ProBuilder.WingedEdge,UnityEngine.ProBuilder.Edge> <>9__15_1; // 0x60
	public static System.Func<UnityEngine.ProBuilder.WingedEdge,UnityEngine.ProBuilder.Edge> <>9__26_0; // 0x68
	public static System.Comparison<UnityEngine.ProBuilder.SimpleTuple<System.Int32,System.Int32>> <>9__27_0; // 0x70

	// Methods

	// RVA: 0x15560C0
	private static void .cctor() { }

	// RVA: 0x155612C
	public void .ctor() { }

	// RVA: 0x1556134
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <GetPerimeterEdges>b__5_0(Face x) { }

	// RVA: 0x1556150
	internal bool <GetPerimeterEdges>b__5_1(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> x) { }

	// RVA: 0x155623C
	internal Edge <GetPerimeterEdges>b__5_2(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> x) { }

	// RVA: 0x1556338
	internal bool <GetPerimeterFaces>b__7_0(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>> x) { }

	// RVA: 0x1556424
	internal Face <GetPerimeterFaces>b__7_1(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>> x) { }

	// RVA: 0x1556520
	internal Edge <GetEdgeRing>b__10_0(EdgeLookup x) { }

	// RVA: 0x1556528
	internal Edge <GetEdgeRingIterative>b__11_0(EdgeLookup x) { }

	// RVA: 0x1556530
	internal Edge <GetEdgeLoop>b__12_0(EdgeLookup x) { }

	// RVA: 0x1556538
	internal Edge <GetEdgeLoopIterative>b__13_0(EdgeLookup x) { }

	// RVA: 0x1556540
	internal Edge <GetEdgeLoopInternal>b__14_0(WingedEdge x) { }

	// RVA: 0x155655C
	internal Edge <GetEdgeLoopInternalIterative>b__15_0(WingedEdge x) { }

	// RVA: 0x1556578
	internal Edge <GetEdgeLoopInternalIterative>b__15_1(WingedEdge x) { }

	// RVA: 0x1556594
	internal Edge <FindHoles>b__26_0(WingedEdge x) { }

	// RVA: 0x15565B0
	internal int <FindHoles>b__27_0(UnityEngine.ProBuilder.SimpleTuple<System.Int32,System.Int32> x, UnityEngine.ProBuilder.SimpleTuple<System.Int32,System.Int32> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0
{
	// Fields
	public Face face; // 0x10

	// Methods

	// RVA: 0x1556704
	public void .ctor() { }

	// RVA: 0x155670C
	internal bool <GetFaceLoop>b__0(WingedEdge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass27_0
{
	// Fields
	public System.Collections.Generic.HashSet<System.Int32> common; // 0x10
	public System.Func<UnityEngine.ProBuilder.WingedEdge,System.Boolean> <>9__1; // 0x18
	public System.Func<UnityEngine.ProBuilder.WingedEdge,System.Boolean> <>9__2; // 0x20

	// Methods

	// RVA: 0x1556734
	public void .ctor() { }

	// RVA: 0x155673C
	internal bool <FindHoles>b__1(WingedEdge w) { }

	// RVA: 0x15567B8
	internal bool <FindHoles>b__2(WingedEdge w) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ElementSelection
{
	// Fields
	private const int k_MaxHoleIterations = 2048;
	private static readonly Vector3 Vector3_Zero; // 0x0

	// Methods

	// RVA: 0x154F9A0
	public static void GetNeighborFaces(ProBuilderMesh mesh, Edge edge, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> neighborFaces) { }

	// RVA: 0x153B13C
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Edge>> GetNeighborFaces(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x154FC1C
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> GetNeighborFaces(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x154FF70
	internal static Edge[] GetConnectedEdges(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x15505E8
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetPerimeterEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1550CC0
	internal static int[] GetPerimeterEdges(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15510F4
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> GetPerimeterFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1551870
	internal static int[] GetPerimeterVertices(ProBuilderMesh mesh, int[] indexes, Edge[] universal_edges_all) { }

	// RVA: 0x1551C68
	private static WingedEdge EdgeRingNext(WingedEdge edge) { }

	// RVA: 0x1551CEC
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetEdgeRing(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15523CC
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetEdgeRingIterative(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1552A64
	internal static bool GetEdgeLoop(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Edge[] loop) { }

	// RVA: 0x1553180
	internal static bool GetEdgeLoopIterative(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Edge[] loop) { }

	// RVA: 0x1552F00
	private static bool GetEdgeLoopInternal(WingedEdge start, int startIndex, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> used) { }

	// RVA: 0x15534F0
	private static void GetEdgeLoopInternalIterative(WingedEdge start, Edge edge, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> used) { }

	// RVA: 0x1553BC8
	private static WingedEdge NextSpoke(WingedEdge wing, int pivot, bool opp) { }

	// RVA: 0x15538B0
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetSpokes(WingedEdge wing, int sharedIndex, bool allowHoles) { }

	// RVA: 0x1553CD0
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GrowSelection(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float maxAngleDiff) { }

	// RVA: 0x1554290
	internal static void Flood(WingedEdge wing, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> selection) { }

	// RVA: 0x1554310
	internal static void Flood(ProBuilderMesh pb, WingedEdge wing, Vector3 wingNrm, float maxAngle, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> selection) { }

	// RVA: 0x155464C
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> FloodSelection(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, float maxAngleDiff) { }

	// RVA: 0x15549F0
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceLoop(ProBuilderMesh mesh, Face[] faces, bool ring) { }

	// RVA: 0x1554E60
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceRingAndLoop(ProBuilderMesh mesh, Face[] faces) { }

	// RVA: 0x1554C38
	private static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceLoop(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, Face face, bool ring) { }

	// RVA: 0x15550BC
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> FindHoles(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x1555490
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge>> FindHoles(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, System.Collections.Generic.HashSet<System.Int32> common) { }

	// RVA: 0x1555FEC
	private static WingedEdge FindNextEdgeInHole(WingedEdge wing, int common) { }

	// RVA: 0x1556070
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.ExtrudeElements.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.FaceRebuildData,UnityEngine.ProBuilder.Face> <>9__3_0; // 0x8
	public static System.Func<UnityEngine.ProBuilder.Face,System.Int32> <>9__4_0; // 0x10

	// Methods

	// RVA: 0x155C494
	private static void .cctor() { }

	// RVA: 0x155C500
	public void .ctor() { }

	// RVA: 0x155C508
	internal Face <DetachFaces>b__3_0(FaceRebuildData x) { }

	// RVA: 0x155C524
	internal int <ExtrudePerFace>b__4_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ExtrudeElements
{
	// Methods

	// RVA: 0x1556834
	public static Face[] Extrude(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, ExtrudeMethod method, float distance) { }

	// RVA: 0x1559BB4
	public static Edge[] Extrude(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, float distance, bool extrudeAsGroup, bool enableManifoldExtrude) { }

	// RVA: 0x155AD78
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> DetachFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x155AD80
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> DetachFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool deleteSourceFaces) { }

	// RVA: 0x1556848
	private static Face[] ExtrudePerFace(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float distance) { }

	// RVA: 0x1557400
	private static Face[] ExtrudeAsGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool compensateAngleVertexDistance, float distance) { }

	// RVA: 0x155B8A4
	private static System.Collections.Generic.List<System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> GetFaceGroups(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings) { }

	// RVA: 0x155BE48
	private static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.EdgeLookup,UnityEngine.ProBuilder.Face> GetPerimeterEdges(System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.InternalMeshUtility.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Mesh,UnityEngine.Vector3[]> <>9__1_0; // 0x8
	public static System.Func<UnityEngine.Mesh,UnityEngine.Color[]> <>9__1_1; // 0x10
	public static System.Func<UnityEngine.Mesh,UnityEngine.Vector2[]> <>9__1_2; // 0x18
	public static System.Func<UnityEngine.Mesh,UnityEngine.Vector3[]> <>9__2_0; // 0x20
	public static System.Func<UnityEngine.Mesh,UnityEngine.Color[]> <>9__2_1; // 0x28
	public static System.Func<UnityEngine.Mesh,UnityEngine.Vector2[]> <>9__2_2; // 0x30
	public static System.Func<System.Boolean,System.Boolean> <>9__3_0; // 0x38

	// Methods

	// RVA: 0x155EC98
	private static void .cctor() { }

	// RVA: 0x155ED04
	public void .ctor() { }

	// RVA: 0x155ED0C
	internal Vector3[] <CreateMeshWithTransform>b__1_0(Mesh x) { }

	// RVA: 0x155ED28
	internal Color[] <CreateMeshWithTransform>b__1_1(Mesh x) { }

	// RVA: 0x155ED44
	internal Vector2[] <CreateMeshWithTransform>b__1_2(Mesh x) { }

	// RVA: 0x155ED60
	internal Vector3[] <ResetPbObjectWithMeshFilter>b__2_0(Mesh x) { }

	// RVA: 0x155ED7C
	internal Color[] <ResetPbObjectWithMeshFilter>b__2_1(Mesh x) { }

	// RVA: 0x155ED98
	internal Vector2[] <ResetPbObjectWithMeshFilter>b__2_2(Mesh x) { }

	// RVA: 0x155EDB4
	internal bool <FilterUnusedSubmeshIndexes>b__3_0(bool x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class InternalMeshUtility
{
	// Methods

	// RVA: 0x155AB84
	internal static Vector3 AverageNormalWithIndexes(SharedVertex shared, int[] all, System.Collections.Generic.IList<UnityEngine.Vector3> norm) { }

	// RVA: 0x155C584
	public static ProBuilderMesh CreateMeshWithTransform(Transform t, bool preserveFaces) { }

	// RVA: 0x155D778
	public static bool ResetPbObjectWithMeshFilter(ProBuilderMesh pb, bool preserveFaces) { }

	// RVA: 0x155E750
	internal static void FilterUnusedSubmeshIndexes(ProBuilderMesh mesh) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.MergeElements.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x15601E8
	private static void .cctor() { }

	// RVA: 0x1560254
	public void .ctor() { }

	// RVA: 0x156025C
	internal System.Collections.Generic.IEnumerable<System.Int32> <Merge>b__1_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> remove; // 0x10

	// Methods

	// RVA: 0x155F514
	public void .ctor() { }

	// RVA: 0x1560278
	internal bool <MergePairs>b__0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MergeElements
{
	// Methods

	// RVA: 0x155EDBC
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> MergePairs(ProBuilderMesh target, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Face>> pairs, bool collapseCoincidentVertices) { }

	// RVA: 0x155F9F0
	public static Face Merge(ProBuilderMesh target, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x155F51C
	internal static void CollapseCoincidentVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
[Serializable]
public sealed class MeshImportSettings
{
	// Fields
	private bool m_Quads; // 0x10
	private bool m_Smoothing; // 0x11
	private float m_SmoothingThreshold; // 0x14

	// Methods

	// RVA: 0x15602E4
	public bool get_quads() { }

	// RVA: 0x15602EC
	public void set_quads(bool value) { }

	// RVA: 0x15602F4
	public bool get_smoothing() { }

	// RVA: 0x15602FC
	public void set_smoothing(bool value) { }

	// RVA: 0x1560304
	public float get_smoothingAngle() { }

	// RVA: 0x156030C
	public void set_smoothingAngle(float value) { }

	// RVA: 0x1560314
	public override string ToString() { }

	// RVA: 0x15603F4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.MeshImporter.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Vertex,UnityEngine.Vector3> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x1561C70
	private static void .cctor() { }

	// RVA: 0x1561CDC
	public void .ctor() { }

	// RVA: 0x1561CE4
	internal Vector3 <Import>b__9_0(Vertex x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public sealed class MeshImporter
{
	// Fields
	private static readonly MeshImportSettings k_DefaultImportSettings; // 0x0
	private Mesh m_SourceMesh; // 0x10
	private Material[] m_SourceMaterials; // 0x18
	private ProBuilderMesh m_Destination; // 0x20
	private Vertex[] m_Vertices; // 0x28

	// Methods

	// RVA: 0x156040C
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x15605C0
	public void .ctor(Mesh sourceMesh, Material[] sourceMaterials, ProBuilderMesh destination) { }

	// RVA: 0x1560734
	public void .ctor(ProBuilderMesh destination) { }

	// RVA: 0x1560768
	public bool Import(GameObject go, MeshImportSettings importSettings) { }

	// RVA: 0x1560948
	public void Import(MeshImportSettings importSettings) { }

	// RVA: 0x1561BD0
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MeshTransform
{
	// Methods

	// RVA: 0x1561D04
	internal static void SetPivot(ProBuilderMesh mesh, PivotLocation pivotLocation) { }

	// RVA: 0x155D488
	public static void CenterPivot(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x1561DA4
	public static void SetPivot(ProBuilderMesh mesh, Vector3 worldPosition) { }

	// RVA: 0x1561F60
	public static void FreezeScaleTransform(ProBuilderMesh mesh) { }

}

// Namespace: 
private enum AttributeValidationStrategy
{
	// Fields
	public int value__; // 0x10
	public const AttributeValidationStrategy Resize = 0;
	public const AttributeValidationStrategy Nullify = 1;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.MeshValidation.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.Triangle,System.Collections.Generic.IEnumerable<System.Int32>> <>9__4_0; // 0x8
	public static System.Func<UnityEngine.ProBuilder.Triangle,System.Collections.Generic.IEnumerable<System.Int32>> <>9__4_1; // 0x10
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__7_0; // 0x18

	// Methods

	// RVA: 0x1564FE4
	private static void .cctor() { }

	// RVA: 0x1565050
	public void .ctor() { }

	// RVA: 0x1565058
	internal System.Collections.Generic.IEnumerable<System.Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_0(Triangle x) { }

	// RVA: 0x1565084
	internal System.Collections.Generic.IEnumerable<System.Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_1(Triangle x) { }

	// RVA: 0x15650B0
	internal System.Collections.Generic.IEnumerable<System.Int32> <RemoveUnusedVertices>b__7_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x15646D0
	public void .ctor() { }

	// RVA: 0x15650CC
	internal bool <RebuildSelectionIndexes>b__0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public Triangle triangle; // 0x10
	public System.Func<UnityEngine.ProBuilder.Triangle,System.Boolean> <>9__0; // 0x20

	// Methods

	// RVA: 0x156320C
	public void .ctor() { }

	// RVA: 0x1565134
	internal bool <CollectFaceGroups>b__0(Triangle x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MeshValidation
{
	// Methods

	// RVA: 0x15620D4
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh) { }

	// RVA: 0x15620F0
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1562540
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15626B4
	public static bool ContainsNonContiguousTriangles(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15627E8
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> EnsureFacesAreComposedOfContiguousTriangles(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1562E84
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Triangle>> CollectFaceGroups(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1563214
	public static bool RemoveDegenerateTriangles(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x155FE34
	public static bool RemoveUnusedVertices(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x1563C8C
	internal static System.Collections.Generic.List<System.Int32> RebuildIndexes(System.Collections.Generic.IEnumerable<System.Int32> indices, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x1564060
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> RebuildEdges(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x15644AC
	internal static void RebuildSelectionIndexes(ProBuilderMesh mesh, Face[] faces, Edge[] edges, int[] indices, System.Collections.Generic.IEnumerable<System.Int32> removed) { }

	// RVA: 0x15646D8
	internal static bool EnsureMeshIsValid(ProBuilderMesh mesh, int removedVertices) { }

	// RVA: 0x1564A40
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector2> attribute) { }

	// RVA: 0x1564C18
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector3> attribute) { }

	// RVA: 0x1564DFC
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector4> attribute) { }

	// RVA: 0x315B3A8
	private static void EnsureArraySize(T[] attribute, int expectedVertexCount, AttributeValidationStrategy strategy, T fill) { }

	// RVA: 0x315B3A8
	private static void EnsureListSize(System.Collections.Generic.List<T>& attribute, int expectedVertexCount, AttributeValidationStrategy strategy, T fill) { }

	// RVA: 0x1564854
	private static void EnsureValidAttributes(ProBuilderMesh mesh) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class QuadUtility
{
	// Methods

	// RVA: 0x1561198
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> ToQuads(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, bool smoothing) { }

	// RVA: 0x1565868
	private static Face GetBestQuadConnection(WingedEdge wing, System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.EdgeLookup,System.Single> connections) { }

	// RVA: 0x1565168
	private static float GetQuadScore(ProBuilderMesh mesh, WingedEdge left, WingedEdge right, float normalThreshold) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class Subdivision
{
	// Methods

	// RVA: 0x1565B34
	public static ActionResult Subdivide(ProBuilderMesh pb) { }

	// RVA: 0x1565BEC
	public static Face[] Subdivide(ProBuilderMesh pb, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.SurfaceTopology.<>c <>9; // 0x0
	public static System.Func<UnityEngine.ProBuilder.FaceRebuildData,UnityEngine.ProBuilder.Face> <>9__0_0; // 0x8
	public static System.Func<UnityEngine.ProBuilder.Vertex,UnityEngine.Vector3> <>9__3_0; // 0x10

	// Methods

	// RVA: 0x1567CB4
	private static void .cctor() { }

	// RVA: 0x1567D20
	public void .ctor() { }

	// RVA: 0x1567D28
	internal Face <ToTriangles>b__0_0(FaceRebuildData x) { }

	// RVA: 0x1567D44
	internal Vector3 <GetWindingOrder>b__3_0(Vertex x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class SurfaceTopology
{
	// Methods

	// RVA: 0x1565BF4
	public static Face[] ToTriangles(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1566190
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> BreakFaceIntoTris(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x1566634
	public static WindingOrder GetWindingOrder(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1566930
	private static WindingOrder GetWindingOrder(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1566678
	public static WindingOrder GetWindingOrder(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x1566ADC
	public static bool FlipEdge(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1566F44
	public static ActionResult ConformNormals(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1567718
	private static void GetWindingFlags(WingedEdge edge, bool flag, System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Face,System.Boolean> flags) { }

	// RVA: 0x15679B0
	internal static ActionResult ConformOppositeNormal(WingedEdge source) { }

	// RVA: 0x1567820
	private static Edge GetCommonEdgeInWindingOrder(WingedEdge wing) { }

	// RVA: 0x1567ACC
	internal static void MatchNormal(Face source, Face target, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public int index; // 0x10

	// Methods

	// RVA: 0x156A0D4
	public void .ctor() { }

	// RVA: 0x156A0E4
	internal TriangulationPoint <Triangulate>b__0(Vector2 x) { }

	// RVA: 0x156A170
	internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public int index; // 0x10
	public System.Func<UnityEngine.Vector2,UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> <>9__1; // 0x18

	// Methods

	// RVA: 0x156A0DC
	public void .ctor() { }

	// RVA: 0x156A1FC
	internal PolygonPoint <Triangulate>b__0(Vector2 x) { }

	// RVA: 0x156A288
	internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class Triangulation
{
	// Fields
	private static TriangulationContext s_TriangulationContext; // 0x0

	// Methods

	// RVA: 0x1567D64
	private static TriangulationContext get_triangulationContext() { }

	// RVA: 0x1567E20
	public static bool SortAndTriangulate(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.List<System.Int32>& indexes, bool convex) { }

	// RVA: 0x1568E28
	public static bool TriangulateVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<System.Int32>& triangles, bool unordered, bool convex) { }

	// RVA: 0x15691EC
	public static bool TriangulateVertices(Vector3[] vertices, System.Collections.Generic.List<System.Int32>& triangles, Vector3[][] holes) { }

	// RVA: 0x1569070
	public static bool TriangulateVertices(Vector3[] vertices, System.Collections.Generic.List<System.Int32>& triangles, bool unordered, bool convex) { }

	// RVA: 0x15681C4
	public static bool Triangulate(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.List<System.Int32>& indexes, bool convex) { }

	// RVA: 0x15693B0
	public static bool Triangulate(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Collections.Generic.IList<UnityEngine.Vector2>> holes, System.Collections.Generic.List<System.Int32>& indexes) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ProBuilder.MeshOperations.UVEditing.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Vector4,UnityEngine.Vector2> <>9__2_0; // 0x8
	public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>,System.Int32> <>9__4_1; // 0x10
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__8_0; // 0x18
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__8_1; // 0x20
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__9_0; // 0x28
	public static System.Func<UnityEngine.ProBuilder.Face,System.Collections.Generic.IEnumerable<System.Int32>> <>9__11_0; // 0x30

	// Methods

	// RVA: 0x156DB4C
	private static void .cctor() { }

	// RVA: 0x156DBB8
	public void .ctor() { }

	// RVA: 0x156DBC0
	internal Vector2 <GetUVs>b__2_0(Vector4 x) { }

	// RVA: 0x156DBC4
	internal int <SewUVs>b__4_1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

	// RVA: 0x156DC8C
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesAuto>b__8_0(Face x) { }

	// RVA: 0x156DCA8
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesAuto>b__8_1(Face x) { }

	// RVA: 0x156DCC4
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesBox>b__9_0(Face x) { }

	// RVA: 0x156DCE0
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesBox>b__11_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public Face f1; // 0x10
	public Face f2; // 0x18

	// Methods

	// RVA: 0x156A5E4
	public void .ctor() { }

	// RVA: 0x156DCFC
	internal bool <AutoStitch>b__0(WingedEdge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public int b; // 0x10

	// Methods

	// RVA: 0x156BFD0
	public void .ctor() { }

	// RVA: 0x156DD48
	internal bool <SewUVs>b__0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class UVEditing
{
	// Methods

	// RVA: 0x156A314
	public static bool AutoStitch(ProBuilderMesh mesh, Face f1, Face f2, int channel) { }

	// RVA: 0x156A5EC
	private static bool AlignEdges(ProBuilderMesh mesh, Face faceToMove, Edge edgeToAlignTo, Edge edgeToBeAligned, int channel) { }

	// RVA: 0x156B07C
	internal static Vector2[] GetUVs(ProBuilderMesh mesh, int channel) { }

	// RVA: 0x156B658
	internal static void ApplyUVs(ProBuilderMesh mesh, Vector2[] uvs, int channel, bool applyToMesh) { }

	// RVA: 0x156B9C0
	public static void SewUVs(ProBuilderMesh mesh, int[] indexes, float delta) { }

	// RVA: 0x156BFD8
	public static void CollapseUVs(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x156B2E8
	public static void SplitUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x156C0A4
	internal static void SplitUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x156C494
	internal static void ProjectFacesAuto(ProBuilderMesh mesh, Face[] faces, int channel) { }

	// RVA: 0x156C858
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, int channel) { }

	// RVA: 0x156CF7C
	internal static Vector2 FindMinimalUV(Vector2[] uvs, int[] indices, float xMin, float yMin) { }

	// RVA: 0x156D0DC
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, Vector2 lowerLeftAnchor, int channel) { }

	// RVA: 0x156D848
	public static void ProjectFacesSphere(ProBuilderMesh pb, int[] indexes, int channel) { }

	// RVA: 0x156D9D4
	public static Vector2[] FitUVs(Vector2[] uvs) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class VertexEditing
{
	// Methods

	// RVA: 0x156DE2C
	public static int MergeVertices(ProBuilderMesh mesh, int[] indexes, bool collapseToFirst) { }

	// RVA: 0x156E18C
	public static void SplitVertices(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x156E218
	public static void SplitVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x156E61C
	public static int[] WeldVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, float neighborRadius) { }

	// RVA: 0x156F960
	internal static FaceRebuildData ExplodeVertex(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.WingedEdge,System.Int32>> edgeAndCommonIndex, float distance, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>>& appendedVertices) { }

	// RVA: 0x15708CC
	private static Edge AlignEdgeWithDirection(EdgeLookup edge, int commonIndex) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=12
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=24
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=96
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=240
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=5473
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=9130
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=24 00F6DEA1AEF89C31C3CD9B4F106BE9C4A57AB06704FBB4E465E49F5995E8325F; // 0x0
	internal static readonly __StaticArrayInitTypeSize=24 0A4F8EB7DD356436EE50F5460F2446D4D347703D265BF738112C63EF44D4D64C; // 0x18
	internal static readonly __StaticArrayInitTypeSize=5473 301D78C6901E0EC2B1F7B0EA205B98C9AEB422A97D3C1AA0DCAAEB0E308C8C51; // 0x30
	internal static readonly __StaticArrayInitTypeSize=9130 440E8F9B3FBA0252CE46170F1D1359E8B30ABF49D59D1153904269B0C948355F; // 0x1591
	internal static readonly __StaticArrayInitTypeSize=96 52001E42B1D28A34563B51E0064A9E699E3880245FC794CD0DCD4F58D5D3CA83; // 0x393B
	internal static readonly __StaticArrayInitTypeSize=24 A55571C9DB30026E44AC0BDD7674D9C597D8254732FEB18418F3AAF8A5B4F418; // 0x399B
	internal static readonly __StaticArrayInitTypeSize=24 A649149D1AE401596717C72AC8EBA8A7ABC0B52F782827AF6A40111A56D46F00; // 0x39B3
	internal static readonly __StaticArrayInitTypeSize=12 CEC68AFEB3572A44829F6FC20DCF9C73A9DFCD19E604F8D9D4721656AF2CEB67; // 0x39CB
	internal static readonly __StaticArrayInitTypeSize=240 DCBEA4AF8FCA3574A40E0078B6F6F21226FA3AA4D9B1062ACDF0409F822D7375; // 0x39D7
	internal static readonly __StaticArrayInitTypeSize=24 EAB01B625D5C3788D47FF175375AB898118BCCAA359E7440C33488D029F10954; // 0x3AC7
}


