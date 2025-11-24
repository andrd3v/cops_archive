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

	// RVA: 0x1547054
	private static MonoScriptData Get() { }

	// RVA: 0x1547158
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

	// RVA: 0x1547160
	public Status get_status() { }

	// RVA: 0x1547168
	private void set_status(Status value) { }

	// RVA: 0x1547170
	public string get_notification() { }

	// RVA: 0x1547178
	private void set_notification(string value) { }

	// RVA: 0x1547180
	public void .ctor(Status status, string notification) { }

	// RVA: 0x15471C4
	public static bool op_Implicit(ActionResult res) { }

	// RVA: 0x15471D8
	public bool ToBool() { }

	// RVA: 0x15471E8
	public static bool FromBool(bool success) { }

	// RVA: 0x15472DC
	public static ActionResult get_Success() { }

	// RVA: 0x1547368
	public static ActionResult get_NoSelection() { }

	// RVA: 0x15473F8
	public static ActionResult get_UserCanceled() { }

}

// Namespace: 
private struct SearchRange
{
	// Fields
	public int begin; // 0x10
	public int end; // 0x14

	// Methods

	// RVA: 0x1547488
	public void .ctor(int begin, int end) { }

	// RVA: 0x1547490
	public bool Valid() { }

	// RVA: 0x15474A4
	public int Center() { }

	// RVA: 0x15474BC
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

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal string <ToString>b__23_0(T x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0<T0, T1>
{
	// Fields
	public System.Collections.Generic.HashSet<TKey> knownKeys; // 0x0
	public System.Func<TSource,TKey> keySelector; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal bool <DistinctBy>b__0(TSource x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ArrayUtility
{
	// Methods

	// RVA: 0x35294CC
	public static T[] ValuesWithIndexes(T[] arr, int[] indexes) { }

	// RVA: 0x35294CC
	public static System.Collections.Generic.List<T> ValuesWithIndexes(System.Collections.Generic.List<T> arr, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x35294CC
	public static System.Collections.Generic.IEnumerable<System.Int32> AllIndexesOf(System.Collections.Generic.IList<T> list, System.Func<T,System.Boolean> lambda) { }

	// RVA: 0x26AD93C
	public static T[] Add(T[] arr, T val) { }

	// RVA: 0x35294CC
	public static T[] AddRange(T[] arr, T[] val) { }

	// RVA: 0x26AD93C
	public static T[] Remove(T[] arr, T val) { }

	// RVA: 0x35294CC
	public static T[] Remove(T[] arr, System.Collections.Generic.IEnumerable<T> val) { }

	// RVA: -1
	public static T[] RemoveAt(T[] arr, int index) { }

	// RVA: 0x35294CC
	public static T[] RemoveAt(System.Collections.Generic.IList<T> list, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x35294CC
	public static T[] SortedRemoveAt(System.Collections.Generic.IList<T> list, System.Collections.Generic.IList<System.Int32> sorted) { }

	// RVA: 0x26AD93C
	public static int NearestIndexPriorToValue(System.Collections.Generic.IList<T> sorted_list, T value) { }

	// RVA: -1
	public static System.Collections.Generic.List<T> Fill(System.Func<System.Int32,T> ctor, int length) { }

	// RVA: 0x26AD93C
	public static T[] Fill(T val, int length) { }

	// RVA: 0x3527C54
	public static bool ContainsMatch(T[] a, T[] b) { }

	// RVA: -1
	public static bool ContainsMatch(T[] a, T[] b, int index_a, int index_b) { }

	// RVA: 0x35294CC
	public static T[] Concat(T[] x, T[] y) { }

	// RVA: 0x26AD93C
	public static int IndexOf(System.Collections.Generic.List<System.Collections.Generic.List<T>> InList, T InValue) { }

	// RVA: -1
	public static T[] Fill(int count, System.Func<System.Int32,T> ctor) { }

	// RVA: 0x26AD93C
	public static void AddOrAppend(System.Collections.Generic.Dictionary<T,System.Collections.Generic.List<K>> dictionary, T key, K value) { }

	// RVA: 0x26AD93C
	public static void AddOrAppendRange(System.Collections.Generic.Dictionary<T,System.Collections.Generic.List<K>> dictionary, T key, System.Collections.Generic.List<K> value) { }

	// RVA: 0x35294CC
	public static System.Collections.Generic.IEnumerable<TSource> DistinctBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector) { }

	// RVA: 0x35293EC
	public static string ToString(System.Collections.Generic.Dictionary<TKey,TValue> dict) { }

	// RVA: 0x35294CC
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

	// RVA: 0x1547668
	public static AutoUnwrapSettings get_defaultAutoUnwrapSettings() { }

	// RVA: 0x1547698
	public bool get_useWorldSpace() { }

	// RVA: 0x15476A0
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x15476A8
	public bool get_flipU() { }

	// RVA: 0x15476B0
	public void set_flipU(bool value) { }

	// RVA: 0x15476B8
	public bool get_flipV() { }

	// RVA: 0x15476C0
	public void set_flipV(bool value) { }

	// RVA: 0x15476C8
	public bool get_swapUV() { }

	// RVA: 0x15476D0
	public void set_swapUV(bool value) { }

	// RVA: 0x15476D8
	public Fill get_fill() { }

	// RVA: 0x15476E0
	public void set_fill(Fill value) { }

	// RVA: 0x15476E8
	public Vector2 get_scale() { }

	// RVA: 0x15476F0
	public void set_scale(Vector2 value) { }

	// RVA: 0x15476F8
	public Vector2 get_offset() { }

	// RVA: 0x1547700
	public void set_offset(Vector2 value) { }

	// RVA: 0x1547708
	public float get_rotation() { }

	// RVA: 0x1547710
	public void set_rotation(float value) { }

	// RVA: 0x1547718
	public Anchor get_anchor() { }

	// RVA: 0x1547720
	public void set_anchor(Anchor value) { }

	// RVA: 0x1547728
	public void .ctor(AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1547784
	public static AutoUnwrapSettings get_tile() { }

	// RVA: 0x154779C
	public static AutoUnwrapSettings get_fit() { }

	// RVA: 0x15477B4
	public static AutoUnwrapSettings get_stretch() { }

	// RVA: 0x1547680
	public void Reset() { }

	// RVA: 0x15477CC
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

	// RVA: 0x1547C54
	public void .ctor(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation) { }

	// RVA: 0x1547C7C
	public void EnforceTangentMode(BezierTangentDirection master, BezierTangentMode mode) { }

	// RVA: 0x1547F8C
	public void SetPosition(Vector3 position) { }

	// RVA: 0x1547FDC
	public void SetTangentIn(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x1547FF0
	public void SetTangentOut(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x1548004
	public static Vector3 QuadraticPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x1548064
	public static Vector3 CubicPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x1548108
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

	// RVA: 0x1548AE4
	public bool get_isEditing() { }

	// RVA: 0x1548AEC
	public void set_isEditing(bool value) { }

	// RVA: 0x1548AF4
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x1548BEC
	public void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x1548BF4
	public void Init() { }

	// RVA: 0x1548D64
	public void Refresh() { }

	// RVA: 0x1548E34
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

	// RVA: 0x1548EDC
	public Vector2 get_size() { }

	// RVA: 0x1548EE4
	public void set_size(Vector2 value) { }

	// RVA: 0x1548EFC
	public Vector2 get_extents() { }

	// RVA: 0x1548F04
	public Vector2[] get_corners() { }

	// RVA: 0x1548FD8
	public void .ctor() { }

	// RVA: 0x1549044
	public void .ctor(Vector2 center, Vector2 size) { }

	// RVA: 0x15490EC
	public void .ctor(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x1549480
	public void .ctor(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1549A9C
	internal void .ctor(Vector3[] points, Edge[] edges) { }

	// RVA: 0x1549BF8
	public void .ctor(Vector2[] points, int length) { }

	// RVA: 0x1549D04
	public bool ContainsPoint(Vector2 point) { }

	// RVA: 0x1549D54
	public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x1549FC4
	public bool Intersects(Bounds2D bounds) { }

	// RVA: 0x154A004
	public bool Intersects(Rect rect) { }

	// RVA: 0x1549170
	public void SetWithPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x154950C
	public void SetWithPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x154A040
	public static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x154A2FC
	public static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x154A774
	public static Vector2 Size(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x154ABE0
	internal static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector4> points, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x154B0E4
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

	// RVA: 0x154B26C
	private static void Init() { }

	// RVA: 0x154BF40
	public static bool get_geometryShadersSupported() { }

	// RVA: 0x154BFA0
	public static Material get_defaultMaterial() { }

	// RVA: 0x154C000
	internal static Shader get_selectionPickerShader() { }

	// RVA: 0x154C060
	internal static Material get_facePickerMaterial() { }

	// RVA: 0x154C0C0
	internal static Material get_vertexPickerMaterial() { }

	// RVA: 0x154C120
	internal static Material get_edgePickerMaterial() { }

	// RVA: 0x154C180
	internal static Material get_triggerMaterial() { }

	// RVA: 0x154C284
	internal static Material get_colliderMaterial() { }

	// RVA: 0x154C388
	internal static Material get_noDrawMaterial() { }

	// RVA: 0x154C48C
	internal static Material GetLegacyDiffuse() { }

	// RVA: 0x154BBD0
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x154C7B0
	internal static Material get_unlitVertexColor() { }

	// RVA: 0x154C810
	internal static Material get_ShapePreviewMaterial() { }

	// RVA: 0x154C870
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

	// RVA: 0x154C9C0
	public SemVer get_versionInfo() { }

	// RVA: 0x154C9C8
	public string get_releaseNotes() { }

	// RVA: 0x154C9D0
	public void .ctor(SemVer version, string releaseNotes) { }

	// RVA: 0x154CA20
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

	// RVA: 0x154CA88
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.ChangelogEntry> get_entries() { }

	// RVA: 0x154CB08
	public void .ctor(string log) { }

	// RVA: 0x154CDA4
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

	// RVA: 0x154CF2C
	private static OutCode ComputeOutCode(Rect rect, float x, float y) { }

	// RVA: 0x154CF68
	internal static bool RectContainsLineSegment(Rect rect, float x0, float y0, float x1, float y1) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ColliderBehaviour
{
	// Methods

	// RVA: 0x154D164
	public override void Initialize() { }

	// RVA: 0x154D3B0
	public override void OnEnterPlayMode() { }

	// RVA: 0x154D490
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x154D570
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

	// RVA: 0x154D590
	public Color get_current() { }

	// RVA: 0x154D59C
	public void set_current(Color value) { }

	// RVA: 0x154D5A8
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Color> get_colors() { }

	// RVA: 0x154D628
	public void SetColors(System.Collections.Generic.IEnumerable<UnityEngine.Color> colors) { }

	// RVA: 0x154D6DC
	public void SetDefaultValues() { }

	// RVA: 0x154D944
	public Color get_Item(int i) { }

	// RVA: 0x154D9C0
	public void set_Item(int i, Color value) { }

	// RVA: 0x154DA5C
	public int get_Count() { }

	// RVA: 0x154DAA8
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

	// RVA: 0x154DAB0
	public void .ctor(float h, float s, float v) { }

	// RVA: 0x154DAF8
	public void .ctor(float h, float s, float v, float sv_modifier) { }

	// RVA: 0x154DB4C
	public static HSVColor FromRGB(Color col) { }

	// RVA: 0x154DDB8
	public override string ToString() { }

	// RVA: 0x154DE78
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

	// RVA: 0x154DEC4
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x154DF0C
	public static XYZColor FromRGB(Color col) { }

	// RVA: 0x154E054
	public static XYZColor FromRGB(float R, float G, float B) { }

	// RVA: 0x154E30C
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

	// RVA: 0x154E3CC
	public void .ctor(float L, float a, float b) { }

	// RVA: 0x154E414
	public static CIELabColor FromXYZ(XYZColor xyz) { }

	// RVA: 0x154E674
	public static CIELabColor FromRGB(Color col) { }

	// RVA: 0x154E7AC
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ColorUtility
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.ProBuilder.CIELabColor> ColorNameLookup; // 0x0

	// Methods

	// RVA: 0x154E86C
	private static bool approx(float lhs, float rhs) { }

	// RVA: 0x154E8D4
	public static Color GetColor(Vector3 vec) { }

	// RVA: 0x154DFDC
	public static XYZColor RGBToXYZ(Color col) { }

	// RVA: 0x154E0CC
	public static XYZColor RGBToXYZ(float r, float g, float b) { }

	// RVA: 0x154E494
	public static CIELabColor XYZToCIE_Lab(XYZColor xyz) { }

	// RVA: 0x154E9DC
	public static float DeltaE(CIELabColor lhs, CIELabColor rhs) { }

	// RVA: 0x154EA24
	public static Color HSVtoRGB(HSVColor hsv) { }

	// RVA: 0x154EBD0
	public static Color HSVtoRGB(float h, float s, float v) { }

	// RVA: 0x154DBCC
	public static HSVColor RGBtoHSV(Color color) { }

	// RVA: 0x154ECE4
	public static string GetColorName(Color InColor) { }

	// RVA: 0x154F0E0
	private static CIELabColor CIELabFromRGB(float R, float G, float B, float Scale) { }

	// RVA: 0x152A140
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

	// RVA: 0x154F1B0
	public void .ctor(int a, int b) { }

	// RVA: 0x154F1B8
	public bool IsValid() { }

	// RVA: 0x154F1DC
	public override string ToString() { }

	// RVA: 0x154F338
	public bool Equals(Edge other) { }

	// RVA: 0x154F37C
	public override bool Equals(object obj) { }

	// RVA: 0x154F480
	public override int GetHashCode() { }

	// RVA: 0x154F4A4
	public static Edge op_Addition(Edge a, Edge b) { }

	// RVA: 0x154F4BC
	public static Edge op_Subtraction(Edge a, Edge b) { }

	// RVA: 0x154F4D4
	public static Edge op_Addition(Edge a, int b) { }

	// RVA: 0x154F4E8
	public static Edge op_Subtraction(Edge a, int b) { }

	// RVA: 0x154F4FC
	public static bool op_Equality(Edge a, Edge b) { }

	// RVA: 0x154F5B4
	public static bool op_Inequality(Edge a, Edge b) { }

	// RVA: 0x154F6B4
	public static Edge Add(Edge a, Edge b) { }

	// RVA: 0x154F728
	public static Edge Subtract(Edge a, Edge b) { }

	// RVA: 0x154F79C
	public bool Equals(Edge other, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x154F934
	public bool Contains(int index) { }

	// RVA: 0x154F958
	public bool Contains(Edge other) { }

	// RVA: 0x154F984
	internal bool Contains(int index, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x154FA6C
	internal static void GetIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x154FDC8
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_0
{
	// Fields
	public System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup; // 0x10

	// Methods

	// RVA: 0x1550480
	public void .ctor() { }

	// RVA: 0x1550820
	internal EdgeLookup <GetEdgeLookup>b__0(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder
public struct EdgeLookup
{
	// Fields
	private Edge m_Local; // 0x10
	private Edge m_Common; // 0x18

	// Methods

	// RVA: 0x154FE18
	public Edge get_local() { }

	// RVA: 0x154FE20
	public void set_local(Edge value) { }

	// RVA: 0x154FE28
	public Edge get_common() { }

	// RVA: 0x154FE30
	public void set_common(Edge value) { }

	// RVA: 0x154FE38
	public void .ctor(Edge common, Edge local) { }

	// RVA: 0x154FE40
	public void .ctor(int cx, int cy, int x, int y) { }

	// RVA: 0x154FE58
	public bool Equals(EdgeLookup other) { }

	// RVA: 0x154FEE0
	public override bool Equals(object obj) { }

	// RVA: 0x1550008
	public override int GetHashCode() { }

	// RVA: 0x1550088
	public static bool op_Equality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x1550124
	public static bool op_Inequality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x15501C4
	public override string ToString() { }

	// RVA: 0x1550398
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.EdgeLookup> GetEdgeLookup(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x1550488
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> GetEdgeLookupHashSet(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x15509B0
	public void .ctor() { }

	// RVA: 0x1551630
	internal Edge <GetSharedVertexHandleEdges>b__0(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class EdgeUtility
{
	// Methods

	// RVA: 0x15508C8
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetSharedVertexHandleEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15509B8
	public static Edge GetSharedVertexHandleEdge(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x1550A70
	internal static Edge GetEdgeWithSharedVertexHandles(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x1550B10
	public static bool ValidateEdge(ProBuilderMesh mesh, Edge edge, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Edge>& validEdge) { }

	// RVA: 0x1551014
	internal static bool Contains(Edge[] edges, Edge edge) { }

	// RVA: 0x1551170
	internal static bool Contains(Edge[] edges, int x, int y) { }

	// RVA: 0x155120C
	internal static int IndexOf(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, Edge edge) { }

	// RVA: 0x15513F0
	internal static int[] AllTriangles(Edge[] edges) { }

	// RVA: 0x15514B0
	internal static Face GetFace(ProBuilderMesh mesh, Edge edge) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class Entity
{
	// Fields
	private EntityType m_EntityType; // 0x20

	// Methods

	// RVA: 0x1551638
	public EntityType get_entityType() { }

	// RVA: 0x1551640
	public void Awake() { }

	// RVA: 0x1551730
	public void SetEntity(EntityType t) { }

	// RVA: 0x1551738
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

	// RVA: 0x154D29C
	protected void SetMaterial(Material material) { }

	// RVA: 0x154D580
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

	// RVA: 0x1551740
	public bool get_manualUV() { }

	// RVA: 0x1551748
	public void set_manualUV(bool value) { }

	// RVA: 0x1551750
	public int get_textureGroup() { }

	// RVA: 0x1551758
	public void set_textureGroup(int value) { }

	// RVA: 0x1551760
	internal int[] get_indexesInternal() { }

	// RVA: 0x1551768
	internal void set_indexesInternal(int[] value) { }

	// RVA: 0x1551898
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_indexes() { }

	// RVA: 0x1551918
	public void SetIndexes(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1550F78
	internal int[] get_distinctIndexesInternal() { }

	// RVA: 0x1551B4C
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_distinctIndexes() { }

	// RVA: 0x155161C
	internal Edge[] get_edgesInternal() { }

	// RVA: 0x1551F68
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.Edge> get_edges() { }

	// RVA: 0x1551FF8
	public int get_smoothingGroup() { }

	// RVA: 0x1552000
	public void set_smoothingGroup(int value) { }

	// RVA: 0x1552008
	public Material get_material() { }

	// RVA: 0x1552010
	public void set_material(Material value) { }

	// RVA: 0x1552018
	public int get_submeshIndex() { }

	// RVA: 0x1552020
	public void set_submeshIndex(int value) { }

	// RVA: 0x1552028
	public AutoUnwrapSettings get_uv() { }

	// RVA: 0x1552038
	public void set_uv(AutoUnwrapSettings value) { }

	// RVA: 0x1552048
	public int get_Item(int i) { }

	// RVA: 0x155207C
	public void .ctor() { }

	// RVA: 0x15520A4
	public void .ctor(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x15521AC
	internal void .ctor(int[] triangles, Material m, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x1552264
	internal void .ctor(System.Collections.Generic.IEnumerable<System.Int32> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x155230C
	public void .ctor(Face other) { }

	// RVA: 0x155233C
	public void CopyFrom(Face other) { }

	// RVA: 0x1551864
	internal void InvalidateCache() { }

	// RVA: 0x1551C58
	private Edge[] CacheEdges() { }

	// RVA: 0x1551A60
	private int[] CacheDistinctIndexes() { }

	// RVA: 0x155249C
	public bool Contains(int a, int b, int c) { }

	// RVA: 0x155253C
	public bool IsQuad() { }

	// RVA: 0x1552590
	public int[] ToQuad() { }

	// RVA: 0x1552980
	public override string ToString() { }

	// RVA: 0x1552B6C
	public void ShiftIndexes(int offset) { }

	// RVA: 0x1552C24
	private int SmallestIndexValue() { }

	// RVA: 0x1552CD4
	public void ShiftIndexesToZero() { }

	// RVA: 0x1552E18
	public void Reverse() { }

	// RVA: 0x1552E8C
	internal static void GetIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x1553258
	internal static void GetDistinctIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x15536E4
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

	// RVA: 0x15538F8
	public int Offset() { }

	// RVA: 0x1553900
	public override string ToString() { }

	// RVA: 0x15539C4
	public static void Apply(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.FaceRebuildData> newFaces, ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1553B40
	public static void Apply(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.FaceRebuildData> newFaces, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVertexLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedTextureLookup) { }

	// RVA: 0x15540D8
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

	// RVA: 0x15540E0
	public void .ctor(int x, int y) { }

	// RVA: 0x1554118
	public HandleConstraint2D Inverse() { }

	// RVA: 0x1554198
	public Vector2 Mask(Vector2 v) { }

	// RVA: 0x15541B0
	public Vector2 InverseMask(Vector2 v) { }

	// RVA: 0x15541D4
	public static bool op_Equality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x155421C
	public static bool op_Inequality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x1554264
	public override int GetHashCode() { }

	// RVA: 0x155426C
	public override bool Equals(object o) { }

	// RVA: 0x1554304
	public override string ToString() { }

	// RVA: 0x1554460
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

	// RVA: 0x15544D4
	internal static Vector3 ScreenToGuiPoint(Camera camera, Vector3 point, float pixelsPerPoint) { }

	// RVA: 0x1554528
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, RaycastHit hit, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x1554568
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, RaycastHit hit, float distance, CullingMode cullingMode, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x1554F88
	internal static bool FaceRaycastBothCullModes(Ray worldRay, ProBuilderMesh mesh, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.Vector3>& back, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.Vector3>& front) { }

	// RVA: 0x1555890
	internal static bool FaceRaycast(Ray InWorldRay, ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.RaycastHit>& hits, CullingMode cullingMode, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x1556038
	internal static Ray InverseTransformRay(Transform transform, Ray InWorldRay) { }

	// RVA: 0x155620C
	internal static bool MeshRaycast(Ray InWorldRay, GameObject gameObject, RaycastHit hit, float distance) { }

	// RVA: 0x15563C4
	internal static bool MeshRaycast(Ray InRay, Vector3[] mesh, int[] triangles, RaycastHit hit, float distance) { }

	// RVA: 0x1556890
	internal static bool PointIsOccluded(Camera cam, ProBuilderMesh pb, Vector3 worldPoint) { }

	// RVA: 0x1556B6C
	public static Quaternion GetRotation(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1557268
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15573D8
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1557AD4
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1557C44
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x1557D34
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x1557E84
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x1557FCC
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15586DC
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15587D4
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

	// RVA: 0x1558E74
	public void .ctor() { }

	// RVA: 0x1558E7C
	internal bool <TryParseColor>b__0(Char c) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class InternalUtility
{
	// Methods

	// RVA: 0x35293EC
	public static T[] GetComponents(GameObject go) { }

	// RVA: 0x35293EC
	public static T[] GetComponents(System.Collections.Generic.IEnumerable<UnityEngine.Transform> transforms) { }

	// RVA: 0x1558890
	public static GameObject EmptyGameObjectWithTransform(Transform t) { }

	// RVA: 0x1558984
	public static GameObject MeshGameObjectWithTransform(string name, Transform t, Mesh mesh, Material mat, bool inheritParent) { }

	// RVA: 0x26AD93C
	public static T NextEnumValue(T current) { }

	// RVA: 0x1558AAC
	public static string ControlKeyString(Char character) { }

	// RVA: 0x1558BF4
	public static bool TryParseColor(string value, Color col) { }

	// RVA: 0x26AD93C
	public static T DemandComponent(Component component) { }

	// RVA: 0x26AD93C
	public static T DemandComponent(GameObject gameObject) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec2
{
	// Fields
	public Vector2 value; // 0x10

	// Methods

	// RVA: 0x1558E9C
	public float get_x() { }

	// RVA: 0x1558EA4
	public float get_y() { }

	// RVA: 0x1558EAC
	public void .ctor(Vector2 vector) { }

	// RVA: 0x1558EB4
	public override string ToString() { }

	// RVA: 0x1558F50
	public static bool op_Equality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x1559100
	public static bool op_Inequality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x1558F7C
	public bool Equals(IntVec2 p) { }

	// RVA: 0x155919C
	public bool Equals(Vector2 p) { }

	// RVA: 0x1559320
	public override bool Equals(object b) { }

	// RVA: 0x155940C
	public override int GetHashCode() { }

	// RVA: 0x1559130
	private static int round(float v) { }

	// RVA: 0x1559418
	public static Vector2 op_Implicit(IntVec2 p) { }

	// RVA: 0x155941C
	public static IntVec2 op_Implicit(Vector2 p) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec3
{
	// Fields
	public Vector3 value; // 0x10

	// Methods

	// RVA: 0x1559420
	public float get_x() { }

	// RVA: 0x1559428
	public float get_y() { }

	// RVA: 0x1559430
	public float get_z() { }

	// RVA: 0x1559438
	public void .ctor(Vector3 vector) { }

	// RVA: 0x1559444
	public override string ToString() { }

	// RVA: 0x1559504
	public static bool op_Equality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x1559750
	public static bool op_Inequality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x1559538
	public bool Equals(IntVec3 p) { }

	// RVA: 0x15597F4
	public bool Equals(Vector3 p) { }

	// RVA: 0x1559A0C
	public override bool Equals(object b) { }

	// RVA: 0x1559B00
	public override int GetHashCode() { }

	// RVA: 0x1559788
	private static int round(float v) { }

	// RVA: 0x1559B10
	public static Vector3 op_Implicit(IntVec3 p) { }

	// RVA: 0x1559B14
	public static IntVec3 op_Implicit(Vector3 p) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec4
{
	// Fields
	public Vector4 value; // 0x10

	// Methods

	// RVA: 0x1559B18
	public float get_x() { }

	// RVA: 0x1559B20
	public float get_y() { }

	// RVA: 0x1559B28
	public float get_z() { }

	// RVA: 0x1559B30
	public float get_w() { }

	// RVA: 0x1559B38
	public void .ctor(Vector4 vector) { }

	// RVA: 0x1559B44
	public override string ToString() { }

	// RVA: 0x1559D18
	public static bool op_Equality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x1559FF0
	public static bool op_Inequality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x1559D50
	public bool Equals(IntVec4 p) { }

	// RVA: 0x155A098
	public bool Equals(Vector4 p) { }

	// RVA: 0x155A338
	public override bool Equals(object b) { }

	// RVA: 0x155A42C
	public override int GetHashCode() { }

	// RVA: 0x155A02C
	private static int round(float v) { }

	// RVA: 0x155A43C
	public static Vector4 op_Implicit(IntVec4 p) { }

	// RVA: 0x155A440
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

	// RVA: 0x155A444
	public static void PushLogLevel(LogLevel level) { }

	// RVA: 0x155A508
	public static void PopLogLevel() { }

	// RVA: 0x155A5BC
	public static void SetLogLevel(LogLevel level) { }

	// RVA: 0x155A648
	public static void SetOutput(LogOutput output) { }

	// RVA: 0x155A6D4
	public static void SetLogFile(string path) { }

	// RVA: 0x26AD93C
	public static void Debug(T value) { }

	// RVA: 0x155A740
	public static void Debug(string message) { }

	// RVA: 0x155A8E0
	public static void Debug(string format, object[] values) { }

	// RVA: 0x155A8E4
	public static void Info(string format, object[] values) { }

	// RVA: 0x155A9F8
	public static void Info(string message) { }

	// RVA: 0x155AAB8
	public static void Warning(string format, object[] values) { }

	// RVA: 0x155ABCC
	public static void Warning(string message) { }

	// RVA: 0x155AC8C
	public static void Error(string format, object[] values) { }

	// RVA: 0x154BE80
	public static void Error(string message) { }

	// RVA: 0x26AD93C
	internal static void Watch(T key, K value) { }

	// RVA: 0x155A7C8
	private static void DoPrint(string message, LogType type) { }

	// RVA: 0x155AEE4
	private static void PrintToFile(string message, string path) { }

	// RVA: 0x155B2E8
	public static void ClearLogFile() { }

	// RVA: 0x155ADA0
	private static void PrintToConsole(string message, LogType type) { }

	// RVA: 0x26AD93C
	internal static void NotNull(T obj, string message) { }

	// RVA: 0x155B3B4
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class MaterialUtility
{
	// Fields
	internal static System.Collections.Generic.List<UnityEngine.Material> s_MaterialArray; // 0x0

	// Methods

	// RVA: 0x155B48C
	internal static int GetMaterialCount(Renderer renderer) { }

	// RVA: 0x155B5B4
	internal static Material GetSharedMaterial(Renderer renderer, int index) { }

	// RVA: 0x155B770
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

	// RVA: 0x155B80C
	internal static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin) { }

	// RVA: 0x155B860
	internal static Vector2 PointInEllipseCircumference(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, Vector2 tangent) { }

	// RVA: 0x155B9A0
	internal static Vector2 PointInEllipseCircumferenceWithConstantAngle(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, Vector2 tangent) { }

	// RVA: 0x155BB24
	internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle) { }

	// RVA: 0x155BB90
	internal static float SignedAngle(Vector2 a, Vector2 b) { }

	// RVA: 0x155BCAC
	public static float SqrDistance(Vector3 a, Vector3 b) { }

	// RVA: 0x155BCD0
	public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z) { }

	// RVA: 0x155BD84
	internal static float PolygonArea(Vector3[] vertices, int[] indexes) { }

	// RVA: 0x155C030
	internal static Vector2 RotateAroundPoint(Vector2 v, Vector2 origin, float theta) { }

	// RVA: 0x155C09C
	public static Vector2 ScaleAroundPoint(Vector2 v, Vector2 origin, Vector2 scale) { }

	// RVA: 0x155C0B8
	internal static Vector2 Perpendicular(Vector2 value) { }

	// RVA: 0x155C0C8
	public static Vector2 ReflectPoint(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x155C274
	internal static float SqrDistanceRayPoint(Ray ray, Vector3 point) { }

	// RVA: 0x155C2C8
	public static float DistancePointLineSegment(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x155C4A4
	public static float DistancePointLineSegment(Vector3 point, Vector3 lineStart, Vector3 lineEnd) { }

	// RVA: 0x155C750
	public static Vector3 GetNearestPointRayRay(Ray a, Ray b) { }

	// RVA: 0x155C798
	internal static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd) { }

	// RVA: 0x155C904
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 intersect) { }

	// RVA: 0x1549F54
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

	// RVA: 0x155CA1C
	internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, int[] indexes) { }

	// RVA: 0x155CDD4
	internal static bool PointInPolygon(Vector2[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x155D09C
	internal static bool PointInPolygon(Vector3[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x155D480
	internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b) { }

	// RVA: 0x155D484
	internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b) { }

	// RVA: 0x1554CE4
	public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, float OutDistance, Vector3 OutPoint) { }

	// RVA: 0x1556650
	internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, float distance, Vector3 normal) { }

	// RVA: 0x155D4D8
	public static float Secant(float x) { }

	// RVA: 0x155D4F4
	public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0x155D6D8
	internal static Vector3 Normal(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x155DF84
	public static Vector3 Normal(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1557678
	public static Normal NormalTangentBitangent(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x155E210
	internal static bool IsCardinalAxis(Vector3 v, float epsilon) { }

	// RVA: 0x155E4B8
	internal static Vector2 DivideBy(Vector2 v, Vector2 o) { }

	// RVA: 0x155E4C4
	internal static Vector3 DivideBy(Vector3 v, Vector3 o) { }

	// RVA: 0x26AD93C
	internal static T Max(T[] array) { }

	// RVA: 0x26AD93C
	internal static T Min(T[] array) { }

	// RVA: 0x155E4D4
	internal static float LargestValue(Vector3 v) { }

	// RVA: 0x155E4F0
	internal static float LargestValue(Vector2 v) { }

	// RVA: 0x155E4FC
	internal static Vector2 SmallestVector2(Vector2[] v) { }

	// RVA: 0x155E54C
	internal static Vector2 SmallestVector2(Vector2[] v, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x155E8A8
	internal static Vector2 LargestVector2(Vector2[] v) { }

	// RVA: 0x155E8F8
	internal static Vector2 LargestVector2(Vector2[] v, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1558104
	internal static Bounds GetBounds(Vector3[] positions, System.Collections.Generic.IList<System.Int32> indices) { }

	// RVA: 0x155EC54
	public static Vector2 Average(System.Collections.Generic.IList<UnityEngine.Vector2> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x155EFDC
	public static Vector3 Average(System.Collections.Generic.IList<UnityEngine.Vector3> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x155F5A4
	public static Vector4 Average(System.Collections.Generic.IList<UnityEngine.Vector4> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x155FB74
	internal static Vector3 InvertScaleVector(Vector3 scaleVector) { }

	// RVA: 0x155FBA4
	internal static bool Approx2(Vector2 a, Vector2 b, float delta) { }

	// RVA: 0x155FBC0
	internal static bool Approx3(Vector3 a, Vector3 b, float delta) { }

	// RVA: 0x155FBF0
	internal static bool Approx4(Vector4 a, Vector4 b, float delta) { }

	// RVA: 0x155FC30
	internal static bool ApproxC(Color a, Color b, float delta) { }

	// RVA: 0x155FC70
	internal static bool Approx(float a, float b, float delta) { }

	// RVA: 0x155B75C
	public static int Clamp(int value, int lowerBound, int upperBound) { }

	// RVA: 0x155FC84
	internal static Vector3 Abs(Vector3 v) { }

	// RVA: 0x155FC94
	internal static Vector3 Sign(Vector3 v) { }

	// RVA: 0x155FCB8
	internal static float Sum(Vector3 v) { }

	// RVA: 0x155D4A4
	internal static void Cross(Vector3 a, Vector3 b, Vector3 res) { }

	// RVA: 0x155D48C
	internal static void Subtract(Vector3 a, Vector3 b, Vector3 res) { }

	// RVA: 0x155FCD0
	internal static bool IsNumber(float value) { }

	// RVA: 0x155FCE4
	internal static bool IsNumber(Vector2 value) { }

	// RVA: 0x155FD04
	internal static bool IsNumber(Vector3 value) { }

	// RVA: 0x155FD30
	internal static bool IsNumber(Vector4 value) { }

	// RVA: 0x155FD68
	internal static float MakeNonZero(float value, float min) { }

	// RVA: 0x155FD98
	internal static Vector4 FixNaN(Vector4 value) { }

	// RVA: 0x155FDD4
	internal static Vector2 EnsureUnitVector(Vector2 value) { }

	// RVA: 0x155FF38
	internal static Vector3 EnsureUnitVector(Vector3 value) { }

	// RVA: 0x15600B4
	internal static Vector4 EnsureUnitVector(Vector4 value) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class MeshHandle
{
	// Fields
	private Transform m_Transform; // 0x10
	private Mesh m_Mesh; // 0x18

	// Methods

	// RVA: 0x1560110
	public Mesh get_mesh() { }

	// RVA: 0x1560118
	public void .ctor(Transform transform, Mesh mesh) { }

	// RVA: 0x1560168
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

	// RVA: 0x1563280
	private static void .cctor() { }

	// RVA: 0x15632EC
	public void .ctor() { }

	// RVA: 0x15632F4
	internal System.Collections.Generic.IEnumerable<System.Int32> <CreateFaceMesh>b__9_0(Face x) { }

	// RVA: 0x1563310
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

	// RVA: 0x15602C4
	internal static void CreateFaceMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x1560438
	internal static void CreateFaceMeshFromFaces(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, Mesh target) { }

	// RVA: 0x15605A0
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x156095C
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target, Edge[] edges) { }

	// RVA: 0x1560C08
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x1560E0C
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1560F58
	private static void CreatePointMesh(Vector3[] positions, System.Collections.Generic.IList<System.Int32> indexes, Mesh target) { }

	// RVA: 0x1561974
	internal static void CreatePointBillboardMesh(System.Collections.Generic.IList<UnityEngine.Vector3> positions, Mesh target) { }

	// RVA: 0x1561110
	private static void CreatePointBillboardMesh(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Mesh target) { }

	// RVA: 0x15620D8
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x156275C
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target, System.Collections.Generic.ICollection<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15630C0
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

	// RVA: 0x1567C50
	private static void .cctor() { }

	// RVA: 0x1567CBC
	public void .ctor() { }

	// RVA: 0x1567CC4
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Vertex> <CollapseSharedVertices>b__11_0(System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Vertex,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder
public static class MeshUtility
{
	// Methods

	// RVA: 0x156332C
	internal static Vertex[] GeneratePerTriangleMesh(Mesh mesh) { }

	// RVA: 0x1563DE4
	public static void GenerateTangent(Mesh mesh) { }

	// RVA: 0x15643A4
	public static Mesh DeepCopy(Mesh source) { }

	// RVA: 0x1564414
	public static void CopyTo(Mesh source, Mesh destination) { }

	// RVA: 0x26AD93C
	internal static T GetMeshChannel(GameObject gameObject, System.Func<UnityEngine.Mesh,T> attributeGetter) { }

	// RVA: 0x352D75C
	private static void PrintAttribute(StringBuilder sb, string title, System.Collections.Generic.IEnumerable<T> attrib, string fmt) { }

	// RVA: 0x15648B8
	public static string Print(Mesh mesh) { }

	// RVA: 0x1565488
	public static UInt32 GetIndexCount(Mesh mesh) { }

	// RVA: 0x1565584
	public static UInt32 GetPrimitiveCount(Mesh mesh) { }

	// RVA: 0x15656E0
	public static void Compile(ProBuilderMesh probuilderMesh, Mesh targetMesh, MeshTopology preferredTopology) { }

	// RVA: 0x15637D4
	public static Vertex[] GetVertices(Mesh mesh) { }

	// RVA: 0x1566384
	public static void CollapseSharedVertices(Mesh mesh, Vertex[] vertices) { }

	// RVA: 0x15669EC
	public static void FitToSize(ProBuilderMesh mesh, Bounds currentSize, Vector3 sizeToFit) { }

	// RVA: 0x1566DE0
	internal static string SanityCheck(ProBuilderMesh mesh) { }

	// RVA: 0x1565474
	internal static string SanityCheck(Mesh mesh) { }

	// RVA: 0x15674D8
	internal static string SanityCheck(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x1567790
	internal static bool IsUsedInParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x1567960
	internal static void RestoreParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x1567A44
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

	// RVA: 0x1567D18
	public Vector3 get_normal() { }

	// RVA: 0x1567D24
	public void set_normal(Vector3 value) { }

	// RVA: 0x1567D30
	public Vector4 get_tangent() { }

	// RVA: 0x1567D3C
	public void set_tangent(Vector4 value) { }

	// RVA: 0x1567D48
	public Vector3 get_bitangent() { }

	// RVA: 0x1567D54
	public void set_bitangent(Vector3 value) { }

	// RVA: 0x1567D60
	public override bool Equals(object obj) { }

	// RVA: 0x1567EA8
	public override int GetHashCode() { }

	// RVA: 0x1567E08
	public bool Equals(Normal other) { }

	// RVA: 0x1567F18
	public static bool op_Equality(Normal a, Normal b) { }

	// RVA: 0x1567F48
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

	// RVA: 0x1568028
	private static void ClearIntArray(int count) { }

	// RVA: 0x156814C
	public static void CalculateTangents(ProBuilderMesh mesh) { }

	// RVA: 0x15687BC
	private static void CalculateHardNormals(ProBuilderMesh mesh) { }

	// RVA: 0x1568DC4
	public static void CalculateNormals(ProBuilderMesh mesh) { }

	// RVA: 0x15693C8
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

	// RVA: 0x26AD93C
	public void .ctor(int initialSize, int desiredSize, System.Func<T> constructor, System.Action<T> destructor, bool lazyInitialization) { }

	// RVA: 0x26AD93C
	public T Dequeue() { }

	// RVA: 0x26AD93C
	public void Enqueue(T obj) { }

	// RVA: 0x35263A0
	public void Empty() { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x352642C
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

	// RVA: 0x15694B8
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Vector3> get_controlPoints() { }

	// RVA: 0x1569538
	public void SetControlPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }

	// RVA: 0x15695A0
	public float get_extrude() { }

	// RVA: 0x15695A8
	public void set_extrude(float value) { }

	// RVA: 0x15695B0
	internal PolyEditMode get_polyEditMode() { }

	// RVA: 0x15695B8
	internal void set_polyEditMode(PolyEditMode value) { }

	// RVA: 0x15695C0
	public bool get_flipNormals() { }

	// RVA: 0x15695C8
	public void set_flipNormals(bool value) { }

	// RVA: 0x15695D0
	internal ProBuilderMesh get_mesh() { }

	// RVA: 0x15696C8
	internal void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x15696D0
	private bool IsSnapEnabled() { }

	// RVA: 0x15696D8
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

	// RVA: 0x156976C
	public void OnBeforeSerialize() { }

	// RVA: 0x1569B18
	public void OnAfterDeserialize() { }

	// RVA: 0x1569F2C
	public void SetDefaultValues() { }

	// RVA: 0x156A034
	public bool HasKey(string key) { }

	// RVA: 0x35252FC
	public bool HasKey(string key) { }

	// RVA: 0x156A188
	public void DeleteKey(string key) { }

	// RVA: 0x26AD93C
	public T Get(string key, T fallback) { }

	// RVA: 0x26AD93C
	public void Set(string key, T value) { }

	// RVA: 0x156A3CC
	public bool GetBool(string key, bool fallback) { }

	// RVA: 0x156A45C
	public int GetInt(string key, int fallback) { }

	// RVA: 0x156A4E4
	public float GetFloat(string key, float fallback) { }

	// RVA: 0x156A574
	public string GetString(string key, string fallback) { }

	// RVA: 0x156A5FC
	public Color GetColor(string key, Color fallback) { }

	// RVA: 0x156A6B0
	public Material GetMaterial(string key, Material fallback) { }

	// RVA: 0x156A738
	public void SetBool(string key, bool value) { }

	// RVA: 0x156A7B4
	public void SetInt(string key, int value) { }

	// RVA: 0x156A830
	public void SetFloat(string key, float value) { }

	// RVA: 0x156A8B4
	public void SetString(string key, string value) { }

	// RVA: 0x156A920
	public void SetColor(string key, Color value) { }

	// RVA: 0x156A9BC
	public void SetMaterial(string key, Material value) { }

	// RVA: 0x156AA28
	public System.Collections.Generic.Dictionary<System.String,System.Boolean> GetBoolDictionary() { }

	// RVA: 0x156AA30
	public System.Collections.Generic.Dictionary<System.String,System.Int32> GetIntDictionary() { }

	// RVA: 0x156AA38
	public System.Collections.Generic.Dictionary<System.String,System.Single> GetFloatDictionary() { }

	// RVA: 0x156AA40
	public System.Collections.Generic.Dictionary<System.String,System.String> GetStringDictionary() { }

	// RVA: 0x156AA48
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.Color> GetColorDictionary() { }

	// RVA: 0x156AA50
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> GetMaterialDictionary() { }

	// RVA: 0x156AA58
	public void Clear() { }

	// RVA: 0x156AB3C
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

	// RVA: 0x156AD5C
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

	// RVA: 0x156EC60
	public void .ctor(ProBuilderMesh mesh) { }

	// RVA: 0x1574E38
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

	// RVA: 0x1574E5C
	private static void .cctor() { }

	// RVA: 0x1574EC8
	public void .ctor() { }

	// RVA: 0x1574ED0
	internal Vector2 <SetUVs>b__118_0(Vector4 x) { }

	// RVA: 0x1574ED4
	internal Vector2 <SetUVs>b__118_1(Vector4 x) { }

	// RVA: 0x1574ED8
	internal int <get_indexCount>b__126_0(Face x) { }

	// RVA: 0x1574EFC
	internal int <get_triangleCount>b__128_0(Face x) { }

	// RVA: 0x1574F20
	internal Face <CopyFrom>b__171_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass174_0
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x157122C
	public void .ctor() { }

	// RVA: 0x1574F88
	internal bool <GetUnusedTextureGroup>b__0(Face element) { }

}

// Namespace: 
private sealed class <>c__DisplayClass176_0
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x157133C
	public void .ctor() { }

	// RVA: 0x1574FB0
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

	// RVA: 0x156ADC4
	public bool get_userCollisions() { }

	// RVA: 0x156ADCC
	public void set_userCollisions(bool value) { }

	// RVA: 0x156ADD4
	public UnwrapParameters get_unwrapParameters() { }

	// RVA: 0x156ADDC
	public void set_unwrapParameters(UnwrapParameters value) { }

	// RVA: 0x15678E0
	internal MeshRenderer get_renderer() { }

	// RVA: 0x156ADE4
	internal MeshFilter get_filter() { }

	// RVA: 0x156AED8
	internal UInt16 get_versionIndex() { }

	// RVA: 0x156AEE0
	internal UInt16 get_nonSerializedVersionIndex() { }

	// RVA: 0x156AEE8
	public bool get_preserveMeshAssetOnDestroy() { }

	// RVA: 0x156AEF0
	public void set_preserveMeshAssetOnDestroy(bool value) { }

	// RVA: 0x1565AD8
	public bool HasArrays(MeshArrays channels) { }

	// RVA: 0x156AEF8
	internal Face[] get_facesInternal() { }

	// RVA: 0x156AF00
	internal void set_facesInternal(Face[] value) { }

	// RVA: 0x156AF08
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> get_faces() { }

	// RVA: 0x156AF88
	public void set_faces(System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> value) { }

	// RVA: 0x156B03C
	internal void InvalidateSharedVertexLookup() { }

	// RVA: 0x156B100
	internal void InvalidateSharedTextureLookup() { }

	// RVA: 0x156B1C4
	internal void InvalidateFaces() { }

	// RVA: 0x156B524
	internal void InvalidateCaches() { }

	// RVA: 0x156B55C
	internal SharedVertex[] get_sharedVerticesInternal() { }

	// RVA: 0x156B564
	internal void set_sharedVerticesInternal(SharedVertex[] value) { }

	// RVA: 0x156B58C
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> get_sharedVertices() { }

	// RVA: 0x156B60C
	public void set_sharedVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> value) { }

	// RVA: 0x156B83C
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_sharedVertexLookup() { }

	// RVA: 0x156B910
	internal void SetSharedVertices(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> indexes) { }

	// RVA: 0x156B998
	internal SharedVertex[] get_sharedTextures() { }

	// RVA: 0x156B9A0
	internal void set_sharedTextures(SharedVertex[] value) { }

	// RVA: 0x156B9C8
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_sharedTextureLookup() { }

	// RVA: 0x156BA98
	internal void SetSharedTextures(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> indexes) { }

	// RVA: 0x156BB20
	internal Vector3[] get_positionsInternal() { }

	// RVA: 0x156BB28
	internal void set_positionsInternal(Vector3[] value) { }

	// RVA: 0x156BB30
	public System.Collections.Generic.IList<UnityEngine.Vector3> get_positions() { }

	// RVA: 0x156BBB0
	public void set_positions(System.Collections.Generic.IList<UnityEngine.Vector3> value) { }

	// RVA: 0x1566E00
	public Vertex[] GetVertices(System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x156BC64
	internal void GetVerticesInList(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x156C59C
	public void SetVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, bool applyMesh) { }

	// RVA: 0x156CA78
	public System.Collections.Generic.IList<UnityEngine.Vector3> get_normals() { }

	// RVA: 0x156CB14
	internal Vector3[] get_normalsInternal() { }

	// RVA: 0x156CB1C
	internal void set_normalsInternal(Vector3[] value) { }

	// RVA: 0x1566048
	public Vector3[] GetNormals() { }

	// RVA: 0x156CB24
	internal Color[] get_colorsInternal() { }

	// RVA: 0x156CB2C
	internal void set_colorsInternal(Color[] value) { }

	// RVA: 0x156CB34
	public System.Collections.Generic.IList<UnityEngine.Color> get_colors() { }

	// RVA: 0x156CBD0
	public void set_colors(System.Collections.Generic.IList<UnityEngine.Color> value) { }

	// RVA: 0x156CDB0
	public Color[] GetColors() { }

	// RVA: 0x156CF2C
	public System.Collections.Generic.IList<UnityEngine.Vector4> get_tangents() { }

	// RVA: 0x156CFD4
	public void set_tangents(System.Collections.Generic.IList<UnityEngine.Vector4> value) { }

	// RVA: 0x156D14C
	internal Vector4[] get_tangentsInternal() { }

	// RVA: 0x156D154
	internal void set_tangentsInternal(Vector4[] value) { }

	// RVA: 0x15661D8
	public Vector4[] GetTangents() { }

	// RVA: 0x156D15C
	internal Vector2[] get_texturesInternal() { }

	// RVA: 0x156D164
	internal void set_texturesInternal(Vector2[] value) { }

	// RVA: 0x156D16C
	internal System.Collections.Generic.List<UnityEngine.Vector4> get_textures2Internal() { }

	// RVA: 0x156D174
	internal void set_textures2Internal(System.Collections.Generic.List<UnityEngine.Vector4> value) { }

	// RVA: 0x156D17C
	internal System.Collections.Generic.List<UnityEngine.Vector4> get_textures3Internal() { }

	// RVA: 0x156D184
	internal void set_textures3Internal(System.Collections.Generic.List<UnityEngine.Vector4> value) { }

	// RVA: 0x156D18C
	public System.Collections.Generic.IList<UnityEngine.Vector2> get_textures() { }

	// RVA: 0x156D228
	public void set_textures(System.Collections.Generic.IList<UnityEngine.Vector2> value) { }

	// RVA: 0x1565D40
	public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x156D38C
	internal System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Vector2> GetUVs(int channel) { }

	// RVA: 0x156D4B8
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x15693B0
	public int get_faceCount() { }

	// RVA: 0x1566D9C
	public int get_vertexCount() { }

	// RVA: 0x156D7EC
	public int get_edgeCount() { }

	// RVA: 0x156D890
	public int get_indexCount() { }

	// RVA: 0x156D9CC
	public int get_triangleCount() { }

	// RVA: 0x156DB24
	public static void add_meshWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x156DC34
	public static void remove_meshWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x156DD44
	internal static void add_meshWasInitialized(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x156DE58
	internal static void remove_meshWasInitialized(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x156DF6C
	internal static void add_componentWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x156E080
	internal static void remove_componentWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x156E194
	internal static void add_componentHasBeenReset(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x156E2A8
	internal static void remove_componentHasBeenReset(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x156E3BC
	public static void add_elementSelectionChanged(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x156E4D0
	public static void remove_elementSelectionChanged(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x1567B28
	internal Mesh get_mesh() { }

	// RVA: 0x156E5E4
	internal void set_mesh(Mesh value) { }

	// RVA: 0x156E5EC
	internal int get_id() { }

	// RVA: 0x156E610
	public MeshSyncState get_meshSyncState() { }

	// RVA: 0x156E718
	internal int get_meshFormatVersion() { }

	// RVA: 0x156E720
	private void Awake() { }

	// RVA: 0x156EC98
	private void Reset() { }

	// RVA: 0x156ED68
	private void OnDestroy() { }

	// RVA: 0x156EF60
	internal void DestroyUnityMesh() { }

	// RVA: 0x156CA58
	private void IncrementVersionIndex() { }

	// RVA: 0x156C8C4
	public void Clear() { }

	// RVA: 0x156E8B0
	internal void EnsureMeshFilterIsAssigned() { }

	// RVA: 0x156F0A8
	internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions) { }

	// RVA: 0x156F414
	public static ProBuilderMesh Create() { }

	// RVA: 0x156F4A8
	public static ProBuilderMesh Create(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> positions, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x156F6C4
	public static ProBuilderMesh Create(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedTextures, System.Collections.Generic.IList<UnityEngine.Material> materials) { }

	// RVA: 0x156F1D0
	internal void GeometryWithPoints(Vector3[] points) { }

	// RVA: 0x156F584
	public void RebuildWithPositionsAndFaces(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> vertices, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1566DB4
	internal void Rebuild() { }

	// RVA: 0x156F8C4
	public void ToMesh(MeshTopology preferredTopology) { }

	// RVA: 0x1570258
	private void FinalizeToMesh(bool usedInParticleSystem) { }

	// RVA: 0x15702A4
	public void MakeUnique() { }

	// RVA: 0x1570498
	public void CopyFrom(ProBuilderMesh other) { }

	// RVA: 0x157001C
	public void Refresh(RefreshMask mask) { }

	// RVA: 0x156EA80
	internal void EnsureMeshColliderIsAssigned() { }

	// RVA: 0x1571130
	internal int GetUnusedTextureGroup(int i) { }

	// RVA: 0x1571234
	private static bool IsValidTextureGroup(int group) { }

	// RVA: 0x1571240
	internal int UnusedElementGroup(int i) { }

	// RVA: 0x1570980
	public void RefreshUV(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> facesToRefresh) { }

	// RVA: 0x1571344
	internal void SetGroupUV(AutoUnwrapSettings settings, int group) { }

	// RVA: 0x1570FBC
	private void RefreshColors() { }

	// RVA: 0x1571428
	public void SetFaceColor(Face face, Color color) { }

	// RVA: 0x15717D0
	public void SetMaterial(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, Material material) { }

	// RVA: 0x1570FF8
	private void RefreshNormals() { }

	// RVA: 0x1571094
	private void RefreshTangents() { }

	// RVA: 0x1571E40
	internal int GetSharedVertexHandle(int vertex) { }

	// RVA: 0x1571FB0
	internal System.Collections.Generic.HashSet<System.Int32> GetSharedVertexHandles(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x1572334
	public System.Collections.Generic.List<System.Int32> GetCoincidentVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x1572964
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x1572F7C
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x157240C
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x1573644
	public void GetCoincidentVertices(int vertex, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x15737F0
	public void SetVerticesCoincident(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x15738B0
	internal void SetTexturesCoincident(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x15738FC
	internal void AddToSharedVertex(int sharedVertexHandle, int vertex) { }

	// RVA: 0x1573998
	internal void AddSharedVertex(SharedVertex vertex) { }

	// RVA: 0x1573A5C
	public bool get_selectable() { }

	// RVA: 0x1573A64
	public void set_selectable(bool value) { }

	// RVA: 0x1573A6C
	public int get_selectedFaceCount() { }

	// RVA: 0x1573A8C
	public int get_selectedVertexCount() { }

	// RVA: 0x1573AAC
	public int get_selectedEdgeCount() { }

	// RVA: 0x1573ACC
	internal int get_selectedSharedVerticesCount() { }

	// RVA: 0x1573EA8
	internal int get_selectedCoincidentVertexCount() { }

	// RVA: 0x1573ECC
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedSharedVertices() { }

	// RVA: 0x1573EF0
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedCoincidentVertices() { }

	// RVA: 0x1573AF0
	private void CacheSelection() { }

	// RVA: 0x1573F14
	public Face[] GetSelectedFaces() { }

	// RVA: 0x1574038
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_selectedFaceIndexes() { }

	// RVA: 0x15740B8
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_selectedVertices() { }

	// RVA: 0x1574138
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.Edge> get_selectedEdges() { }

	// RVA: 0x15741B8
	internal Face[] get_selectedFacesInternal() { }

	// RVA: 0x15741BC
	internal void set_selectedFacesInternal(Face[] value) { }

	// RVA: 0x1574298
	internal int[] get_selectedFaceIndicesInternal() { }

	// RVA: 0x15742A0
	internal void set_selectedFaceIndicesInternal(int[] value) { }

	// RVA: 0x15742A8
	internal Edge[] get_selectedEdgesInternal() { }

	// RVA: 0x15742B0
	internal void set_selectedEdgesInternal(Edge[] value) { }

	// RVA: 0x15742B8
	internal int[] get_selectedIndexesInternal() { }

	// RVA: 0x15742C0
	internal void set_selectedIndexesInternal(int[] value) { }

	// RVA: 0x15742C8
	internal Face GetActiveFace() { }

	// RVA: 0x1574328
	internal Edge GetActiveEdge() { }

	// RVA: 0x15743CC
	internal int GetActiveVertex() { }

	// RVA: 0x157440C
	internal void AddToFaceSelection(int index) { }

	// RVA: 0x15746E0
	public void SetSelectedFaces(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> selected) { }

	// RVA: 0x1574488
	internal void SetSelectedFaces(System.Collections.Generic.IEnumerable<System.Int32> selected) { }

	// RVA: 0x15747A8
	public void SetSelectedEdges(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x157490C
	public void SetSelectedVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x1574AA0
	internal void RemoveFromFaceSelectionAtIndex(int index) { }

	// RVA: 0x156EBA4
	public void ClearSelection() { }

	// RVA: 0x1574B08
	public void .ctor() { }

	// RVA: 0x1574C74
	private static void .cctor() { }

	// RVA: 0x1574D08
	private int <set_selectedFacesInternal>b__231_0(Face x) { }

	// RVA: 0x1574D64
	private int <SetSelectedFaces>b__245_0(Face x) { }

	// RVA: 0x1574DC0
	private System.Collections.Generic.IEnumerable<System.Int32> <SetSelectedFaces>b__246_0(int x) { }

	// RVA: 0x1574DFC
	private System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <SetSelectedFaces>b__246_1(int x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ProBuilderSnapping
{
	// Fields
	private const float k_MaxRaySnapDistance = inf;

	// Methods

	// RVA: 0x1574FD8
	internal static bool IsCardinalDirection(Vector3 direction) { }

	// RVA: 0x1575258
	public static float Snap(float val, float snap) { }

	// RVA: 0x157532C
	public static Vector3 Snap(Vector3 val, Vector3 snap) { }

	// RVA: 0x157556C
	public static void SnapVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, Vector3 snap) { }

	// RVA: 0x1575914
	internal static Vector3 GetSnappingMaskBasedOnNormalVector(Vector3 normal) { }

	// RVA: 0x15759F4
	internal static Vector3 SnapValueOnRay(Ray ray, float distance, float snap, Vector3Mask mask) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ProGridsNoSnapAttribute
{
	// Methods

	// RVA: 0x157617C
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ProGridsConditionalSnapAttribute
{
	// Methods

	// RVA: 0x1576184
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

	// RVA: 0x1579338
	private static void .cctor() { }

	// RVA: 0x15793A4
	public void .ctor() { }

	// RVA: 0x15793AC
	internal int <Sort>b__6_0(UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> a, UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> b) { }

	// RVA: 0x1579510
	internal Vector2 <Sort>b__6_1(UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> x) { }

}

// Namespace: UnityEngine.ProBuilder
public static class Projection
{
	// Methods

	// RVA: 0x157618C
	public static Vector2[] PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1576B58
	public static Vector2[] PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Vector3 direction) { }

	// RVA: 0x1576D20
	internal static void PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Vector3 direction, System.Collections.Generic.List<UnityEngine.Vector2> results) { }

	// RVA: 0x15776D8
	internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1577DB4
	internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x15782AC
	internal static Vector2[] SphericalProject(System.Collections.Generic.IList<UnityEngine.Vector3> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1578710
	internal static System.Collections.Generic.IList<UnityEngine.Vector2> Sort(System.Collections.Generic.IList<UnityEngine.Vector2> verts, SortMethod method) { }

	// RVA: 0x1577604
	internal static Vector3 GetTangentToAxis(ProjectionAxis axis) { }

	// RVA: 0x1578BC4
	internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis) { }

	// RVA: 0x15774B4
	internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction) { }

	// RVA: 0x15761B8
	public static Plane FindBestPlane(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1578DBC
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

	// RVA: 0x15795E0
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

	// RVA: 0x1579658
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<System.Int32>> PickVerticesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x157ADA0
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> PickFacesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x157C904
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Edge>> PickEdgesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x157E00C
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

	// RVA: 0x157E0B8
	public bool get_depthTest() { }

	// RVA: 0x157E0C0
	public void set_depthTest(bool value) { }

	// RVA: 0x157E0C8
	public RectSelectMode get_rectSelectMode() { }

	// RVA: 0x157E0D0
	public void set_rectSelectMode(RectSelectMode value) { }

	// RVA: 0x157E0D8
	public static PickerOptions get_Default() { }

	// RVA: 0x157E154
	public override bool Equals(object obj) { }

	// RVA: 0x157E284
	public bool Equals(PickerOptions other) { }

	// RVA: 0x157E334
	public override int GetHashCode() { }

	// RVA: 0x157E3D4
	public static bool op_Equality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x157E504
	public static bool op_Inequality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x157E634
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

	// RVA: 0x1580DC4
	public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

	// RVA: 0x1580DCC
	public void .ctor() { }

}

// Namespace: 
internal class SelectionPickerRendererStandard
{
	// Methods

	// RVA: 0x1580DD4
	public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

	// RVA: 0x15811C0
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

	// RVA: 0x15811C8
	private static void .cctor() { }

	// RVA: 0x1581234
	public void .ctor() { }

	// RVA: 0x158123C
	internal System.Collections.Generic.IEnumerable<System.Int32> <GenerateFacePickingObjects>b__24_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass19_0
{
	// Fields
	public Vector3[] positions; // 0x10
	public SharedVertex[] sharedVertices; // 0x18

	// Methods

	// RVA: 0x1581258
	public void .ctor() { }

	// RVA: 0x1581260
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

	// RVA: 0x157E684
	private static RenderTextureFormat get_renderTextureFormat() { }

	// RVA: 0x157E7FC
	private static TextureFormat get_textureFormat() { }

	// RVA: 0x157E804
	private static ISelectionPickerRenderer get_pickerRenderer() { }

	// RVA: 0x157BFB4
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> PickFacesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x1579D1C
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<System.Int32>> PickVerticesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x157D2D4
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x157E920
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Face>>& map, int width, int height) { }

	// RVA: 0x157EB90
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>>& map, int width, int height) { }

	// RVA: 0x157EE8C
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>>& map, int width, int height) { }

	// RVA: 0x157F188
	private static GameObject[] GenerateFacePickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Face>>& map) { }

	// RVA: 0x157F754
	private static void GenerateVertexPickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>>& map, GameObject[] depthObjects, GameObject[] pickerObjects) { }

	// RVA: 0x157FBE4
	private static void GenerateEdgePickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>>& map, GameObject[] depthObjects, GameObject[] pickerObjects) { }

	// RVA: 0x1580088
	private static Mesh BuildVertexMesh(ProBuilderMesh pb, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>> map, UInt32 index) { }

	// RVA: 0x1580818
	private static Mesh BuildEdgeMesh(ProBuilderMesh pb, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>> map, UInt32 index) { }

	// RVA: 0x157EB7C
	public static UInt32 DecodeRGBA(Color32 color) { }

	// RVA: 0x1580074
	public static Color32 EncodeRGBA(UInt32 hash) { }

	// RVA: 0x157E918
	private static bool ShouldUseHDRP() { }

	// RVA: 0x1580CF4
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

	// RVA: 0x1581458
	public System.Collections.Generic.List<System.Int32> get_vertexes() { }

	// RVA: 0x1581460
	public void set_vertexes(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x1581468
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> get_edges() { }

	// RVA: 0x1581470
	public void set_edges(System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> value) { }

	// RVA: 0x1581478
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Face> get_faces() { }

	// RVA: 0x1581480
	public void set_faces(System.Collections.Generic.List<UnityEngine.ProBuilder.Face> value) { }

	// RVA: 0x1581488
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x15815D8
	public void .ctor(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x158182C
	public void .ctor(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x1581A80
	public void .ctor(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15816A4
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> vertexes) { }

	// RVA: 0x15818F8
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1581B3C
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1581CC4
	public void SetSingleFace(Face face) { }

	// RVA: 0x1581D90
	public void SetSingleVertex(int vertex) { }

	// RVA: 0x1581E6C
	public void SetSingleEdge(Edge edge) { }

	// RVA: 0x1581F48
	public void Clear() { }

	// RVA: 0x15820DC
	public void CopyTo(SceneSelection dst) { }

	// RVA: 0x15822F0
	public override string ToString() { }

	// RVA: 0x1582584
	public bool Equals(SceneSelection other) { }

	// RVA: 0x158268C
	public override bool Equals(object obj) { }

	// RVA: 0x15827AC
	public override int GetHashCode() { }

	// RVA: 0x1582964
	public static bool op_Equality(SceneSelection left, SceneSelection right) { }

	// RVA: 0x158296C
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

	// RVA: 0x1582988
	public static System.Collections.Generic.List<System.Int32> GetPath(ProBuilderMesh mesh, int start, int end) { }

	// RVA: 0x1582DFC
	private static int[] Dijkstra(ProBuilderMesh mesh, int start) { }

	// RVA: 0x15835AC
	private static float GetWeight(int face1, int face2, ProBuilderMesh mesh) { }

	// RVA: 0x1582CBC
	private static System.Collections.Generic.List<System.Int32> GetMinimalPath(int[] predecessors, int start, int end) { }

	// RVA: 0x1583A04
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

	// RVA: 0x1583A98
	public int get_major() { }

	// RVA: 0x1583AA0
	public int get_minor() { }

	// RVA: 0x1583AA8
	public int get_patch() { }

	// RVA: 0x1583AB0
	public int get_build() { }

	// RVA: 0x1583AB8
	public string get_type() { }

	// RVA: 0x1583B14
	public string get_metadata() { }

	// RVA: 0x1583B70
	public string get_date() { }

	// RVA: 0x1583BCC
	public SemVer get_MajorMinorPatch() { }

	// RVA: 0x1583D18
	public void .ctor() { }

	// RVA: 0x1583D7C
	public void .ctor(string formatted, string date) { }

	// RVA: 0x1583C84
	public void .ctor(int major, int minor, int patch, int build, string type, string date, string metadata) { }

	// RVA: 0x15842EC
	public bool IsValid() { }

	// RVA: 0x158431C
	public override bool Equals(object o) { }

	// RVA: 0x15845EC
	public override int GetHashCode() { }

	// RVA: 0x158439C
	public bool Equals(SemVer version) { }

	// RVA: 0x15847D8
	public int CompareTo(object obj) { }

	// RVA: 0x1584A34
	private static int WrapNoValue(int value) { }

	// RVA: 0x1584858
	public int CompareTo(SemVer version) { }

	// RVA: 0x1584A44
	public static bool op_Equality(SemVer left, SemVer right) { }

	// RVA: 0x1584A58
	public static bool op_Inequality(SemVer left, SemVer right) { }

	// RVA: 0x1584A84
	public static bool op_LessThan(SemVer left, SemVer right) { }

	// RVA: 0x1584AAC
	public static bool op_GreaterThan(SemVer left, SemVer right) { }

	// RVA: 0x1584ACC
	public static bool op_LessThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x1584B20
	public static bool op_GreaterThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x1584B88
	public string ToString(string format) { }

	// RVA: 0x1584D6C
	public override string ToString() { }

	// RVA: 0x1583E68
	public static bool TryGetVersionInfo(string input, SemVer version) { }

	// RVA: 0x1584FA8
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

	// RVA: 0x15850B4
	public static ProBuilderMesh Instantiate(Type shapeType, PivotLocation pivotType) { }

	// RVA: 0x1585384
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

	// RVA: 0x15855D8
	public static ProBuilderMesh CreateShape(ShapeType shape, PivotLocation pivotType) { }

	// RVA: 0x1585F40
	public static ProBuilderMesh GenerateStair(PivotLocation pivotType, Vector3 size, int steps, bool buildSides) { }

	// RVA: 0x15869FC
	public static ProBuilderMesh GenerateCurvedStair(PivotLocation pivotType, float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides) { }

	// RVA: 0x158C94C
	internal static ProBuilderMesh GenerateStair(PivotLocation pivotType, int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly) { }

	// RVA: 0x1585C48
	public static ProBuilderMesh GenerateCube(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x1587E44
	public static ProBuilderMesh GenerateCylinder(PivotLocation pivotType, int axisDivisions, float radius, float height, int heightCuts, int smoothing) { }

	// RVA: 0x1587858
	public static ProBuilderMesh GeneratePrism(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x1589198
	public static ProBuilderMesh GenerateDoor(PivotLocation pivotType, float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth) { }

	// RVA: 0x1588800
	public static ProBuilderMesh GeneratePlane(PivotLocation pivotType, float width, float height, int widthCuts, int heightCuts, Axis axis) { }

	// RVA: 0x1589DA0
	public static ProBuilderMesh GeneratePipe(PivotLocation pivotType, float radius, float height, float thickness, int subdivAxis, int subdivHeight) { }

	// RVA: 0x158A624
	public static ProBuilderMesh GenerateCone(PivotLocation pivotType, float radius, float height, int subdivAxis) { }

	// RVA: 0x158AEE0
	public static ProBuilderMesh GenerateArch(PivotLocation pivotType, float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps) { }

	// RVA: 0x158B774
	public static ProBuilderMesh GenerateIcosahedron(PivotLocation pivotType, float radius, int subdivisions, bool weldVertices, bool manualUvs) { }

	// RVA: 0x158CF78
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x158DBE4
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x158C2D0
	public static ProBuilderMesh GenerateTorus(PivotLocation pivotType, int rows, int columns, float innerRadius, float outerRadius, bool smooth, float horizontalCircumference, float verticalCircumference, bool manualUvs) { }

	// RVA: 0x158DFC4
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

	// RVA: 0x1590020
	private static void .cctor() { }

	// RVA: 0x159008C
	public void .ctor() { }

	// RVA: 0x1590094
	internal bool <SortedRemoveAndShift>b__26_0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class SharedVertex
{
	// Fields
	private int[] m_Vertices; // 0x10

	// Methods

	// RVA: 0x158E2E4
	internal int[] get_arrayInternal() { }

	// RVA: 0x158D4B4
	public void .ctor(System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x158E2EC
	public void .ctor(SharedVertex sharedVertex) { }

	// RVA: 0x1581378
	public int get_Item(int i) { }

	// RVA: 0x158E3F0
	public void set_Item(int i, int value) { }

	// RVA: 0x158E424
	public System.Collections.Generic.IEnumerator<System.Int32> GetEnumerator() { }

	// RVA: 0x158E4D8
	public override string ToString() { }

	// RVA: 0x158E544
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x158E5F8
	public void Add(int item) { }

	// RVA: 0x158E674
	public void Clear() { }

	// RVA: 0x158E6D8
	public bool Contains(int item) { }

	// RVA: 0x158E74C
	public void CopyTo(int[] array, int arrayIndex) { }

	// RVA: 0x158E76C
	public bool Remove(int item) { }

	// RVA: 0x158E3D0
	public int get_Count() { }

	// RVA: 0x158E81C
	public bool get_IsReadOnly() { }

	// RVA: 0x158E83C
	public static void GetSharedVertexLookup(System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x158ECF8
	internal void ShiftIndexes(int offset) { }

	// RVA: 0x158ED88
	internal static SharedVertex[] ToSharedVertices(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> lookup) { }

	// RVA: 0x158F660
	private static SharedVertex[] ToSharedVertices(System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> list) { }

	// RVA: 0x158D574
	public static SharedVertex[] GetSharedVerticesWithPositions(System.Collections.Generic.IList<UnityEngine.Vector3> positions) { }

	// RVA: 0x158F7E0
	internal static SharedVertex[] RemoveAndShift(System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup, System.Collections.Generic.IEnumerable<System.Int32> remove) { }

	// RVA: 0x158F894
	internal static SharedVertex[] SortedRemoveAndShift(System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup, System.Collections.Generic.List<System.Int32> remove) { }

	// RVA: 0x158FD04
	internal static void SetCoincident(System.Collections.Generic.Dictionary<System.Int32,System.Int32>& lookup, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

}

// Namespace: UnityEngine.ProBuilder
public struct SimpleTuple<T0, T1>
{
	// Fields
	private T1 m_Item1; // 0x0
	private T2 m_Item2; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public T1 get_item1() { }

	// RVA: 0x26AD93C
	public void set_item1(T1 value) { }

	// RVA: 0x26AD93C
	public T2 get_item2() { }

	// RVA: 0x26AD93C
	public void set_item2(T2 value) { }

	// RVA: 0x26AD93C
	public void .ctor(T1 item1, T2 item2) { }

	// RVA: 0x3525804
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

	// RVA: 0x26AD93C
	public T1 get_item1() { }

	// RVA: 0x26AD93C
	public void set_item1(T1 value) { }

	// RVA: 0x26AD93C
	public T2 get_item2() { }

	// RVA: 0x26AD93C
	public void set_item2(T2 value) { }

	// RVA: 0x26AD93C
	public T3 get_item3() { }

	// RVA: 0x26AD93C
	public void set_item3(T3 value) { }

	// RVA: 0x26AD93C
	public void .ctor(T1 item1, T2 item2, T3 item3) { }

	// RVA: 0x3525804
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

	// RVA: 0x15916EC
	private static void .cctor() { }

	// RVA: 0x1591758
	public void .ctor() { }

	// RVA: 0x1591760
	internal int <GetUnusedSmoothingGroup>b__5_0(Face x) { }

	// RVA: 0x159177C
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

	// RVA: 0x1590168
	public static int GetUnusedSmoothingGroup(ProBuilderMesh mesh) { }

	// RVA: 0x15903F4
	private static int GetNextUnusedSmoothingGroup(int start, System.Collections.Generic.HashSet<System.Int32> used) { }

	// RVA: 0x15904C0
	public static bool IsSmooth(int index) { }

	// RVA: 0x15904D4
	public static void ApplySmoothingGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float angleThreshold) { }

	// RVA: 0x15904DC
	internal static void ApplySmoothingGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float angleThreshold, Vector3[] normals) { }

	// RVA: 0x1590F38
	private static bool FindSoftEdgesRecursive(Vector3[] normals, WingedEdge wing, float angleThreshold, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> processed) { }

	// RVA: 0x15912AC
	private static bool IsSoftEdge(Vector3[] normals, EdgeLookup left, EdgeLookup right, float threshold) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class Spline
{
	// Methods

	// RVA: 0x1591798
	internal static ProBuilderMesh Extrude(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> points, float radius, int columns, int rows, bool closeLoop, bool smooth) { }

	// RVA: 0x1591878
	internal static void Extrude(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ProBuilderMesh target) { }

	// RVA: 0x1591950
	internal static System.Collections.Generic.List<UnityEngine.Vector3> GetControlPoints(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, System.Collections.Generic.List<UnityEngine.Quaternion> rotations) { }

	// RVA: 0x1591E14
	internal static void Extrude(System.Collections.Generic.IList<UnityEngine.Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ProBuilderMesh target, System.Collections.Generic.IList<UnityEngine.Quaternion> pointRotations) { }

	// RVA: 0x1592898
	private static Quaternion GetRingRotation(System.Collections.Generic.IList<UnityEngine.Vector3> points, int i, bool closeLoop, float secant) { }

	// RVA: 0x159317C
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

	// RVA: 0x1593360
	public System.Collections.Generic.IEnumerable<System.Int32> get_indexes() { }

	// RVA: 0x15933E0
	public void set_indexes(System.Collections.Generic.IEnumerable<System.Int32> value) { }

	// RVA: 0x1593448
	public MeshTopology get_topology() { }

	// RVA: 0x1593450
	public void set_topology(MeshTopology value) { }

	// RVA: 0x1593458
	public int get_submeshIndex() { }

	// RVA: 0x1593460
	public void set_submeshIndex(int value) { }

	// RVA: 0x1593468
	public void .ctor(int submeshIndex, MeshTopology topology, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x1593540
	public void .ctor(Mesh mesh, int subMeshIndex) { }

	// RVA: 0x159367C
	public override string ToString() { }

	// RVA: 0x159377C
	internal static int GetSubmeshCount(ProBuilderMesh mesh) { }

	// RVA: 0x15937E0
	public static Submesh[] GetSubmeshes(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, int submeshCount, MeshTopology preferredTopology) { }

	// RVA: 0x159426C
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

	// RVA: 0x15943C8
	public void .ctor(Vector2 position, float rotation, Vector2 scale) { }

	// RVA: 0x1594424
	public Vector2 TransformPoint(Vector2 p) { }

	// RVA: 0x1594494
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
public static class TransformUtility
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]> s_ChildStack; // 0x0

	// Methods

	// RVA: 0x1594648
	internal static void UnparentChildren(Transform t) { }

	// RVA: 0x15947C8
	internal static void ReparentChildren(Transform t) { }

	// RVA: 0x1594918
	public static Vertex TransformVertex(Transform transform, Vertex vertex) { }

	// RVA: 0x1594B1C
	public static Vertex InverseTransformVertex(Transform transform, Vertex vertex) { }

	// RVA: 0x1594D18
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

	// RVA: 0x1594DB4
	public int get_a() { }

	// RVA: 0x1594DBC
	public int get_b() { }

	// RVA: 0x1594DC4
	public int get_c() { }

	// RVA: 0x1594DCC
	public System.Collections.Generic.IEnumerable<System.Int32> get_indices() { }

	// RVA: 0x1594E60
	public void .ctor(int a, int b, int c) { }

	// RVA: 0x1594E6C
	public bool Equals(Triangle other) { }

	// RVA: 0x1594EA0
	public override bool Equals(object obj) { }

	// RVA: 0x1594F50
	public override int GetHashCode() { }

	// RVA: 0x1594F70
	public bool IsAdjacent(Triangle other) { }

	// RVA: 0x159502C
	private bool ContainsEdge(Edge edge) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class TriggerBehaviour
{
	// Methods

	// RVA: 0x1595184
	public override void Initialize() { }

	// RVA: 0x1595364
	public override void OnEnterPlayMode() { }

	// RVA: 0x15953E8
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x159546C
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

	// RVA: 0x1595474
	public float get_hardAngle() { }

	// RVA: 0x159547C
	public void set_hardAngle(float value) { }

	// RVA: 0x1595484
	public float get_packMargin() { }

	// RVA: 0x159548C
	public void set_packMargin(float value) { }

	// RVA: 0x1595494
	public float get_angleError() { }

	// RVA: 0x159549C
	public void set_angleError(float value) { }

	// RVA: 0x15954A4
	public float get_areaError() { }

	// RVA: 0x15954AC
	public void set_areaError(float value) { }

	// RVA: 0x158CD0C
	public void .ctor() { }

	// RVA: 0x15954C4
	public void .ctor(UnwrapParameters other) { }

	// RVA: 0x15954B4
	public void Reset() { }

	// RVA: 0x159554C
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

	// RVA: 0x1597D50
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

	// RVA: 0x1597EBC
	private static void .cctor() { }

	// RVA: 0x1597F28
	public void .ctor() { }

	// RVA: 0x1597F30
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

	// RVA: 0x1595720
	internal static void SetAutoUV(ProBuilderMesh mesh, Face[] faces, bool auto) { }

	// RVA: 0x15958C4
	internal static void SetAutoAndAlignUnwrapParamsToUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> facesToConvert) { }

	// RVA: 0x1596134
	internal static AutoUnwrapSettings GetAutoUnwrapSettings(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x159623C
	internal static UVTransform GetUVTransform(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1596348
	private static int GetIndex(System.Collections.Generic.IList<System.Int32> collection, int index) { }

	// RVA: 0x1595AA8
	internal static UVTransform CalculateDelta(System.Collections.Generic.IList<UnityEngine.Vector2> src, System.Collections.Generic.IList<System.Int32> srcIndices, System.Collections.Generic.IList<UnityEngine.Vector2> dst, System.Collections.Generic.IList<System.Int32> dstIndices) { }

	// RVA: 0x1596408
	private static Vector2 GetRotatedSize(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indices, Vector2 center, float rotation) { }

	// RVA: 0x158CD50
	internal static void Unwrap(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x158CE9C
	internal static void CopyUVs(ProBuilderMesh mesh, Face source, Face dest) { }

	// RVA: 0x1597274
	internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1596850
	private static void ApplyUVSettings(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, AutoUnwrapSettings uvSettings) { }

	// RVA: 0x1597458
	private static void ScaleUVs(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, Vector2 scale, Bounds2D bounds) { }

	// RVA: 0x15976B0
	private static void ApplyUVAnchor(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, Anchor anchor) { }

	// RVA: 0x1597AE8
	internal static void UpgradeAutoUVScaleOffset(ProBuilderMesh mesh) { }

	// RVA: 0x1597C14
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class VectorHash
{
	// Fields
	public const float FltCompareResolution = 1000;

	// Methods

	// RVA: 0x1597F4C
	private static int HashFloat(float f) { }

	// RVA: 0x1597F8C
	public static int GetHashCode(Vector2 v) { }

	// RVA: 0x15813AC
	public static int GetHashCode(Vector3 v) { }

	// RVA: 0x1598008
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

	// RVA: 0x15980E8
	public float get_x() { }

	// RVA: 0x1598100
	public float get_y() { }

	// RVA: 0x1598118
	public void .ctor(Vector3 v, float epsilon) { }

	// RVA: 0x159813C
	public void .ctor(Byte mask) { }

	// RVA: 0x1598144
	public static Vector2 op_Implicit(Vector2Mask mask) { }

	// RVA: 0x15981B8
	public static Vector2Mask op_Implicit(Vector2 v) { }

	// RVA: 0x15981E0
	public static Vector2Mask op_BitwiseOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x15981E8
	public static Vector2Mask op_BitwiseAnd(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x15981F0
	public static Vector2Mask op_ExclusiveOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x15981F8
	public static Vector2 op_Multiply(Vector2Mask mask, float value) { }

	// RVA: 0x1598280
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

	// RVA: 0x15982D0
	public float get_x() { }

	// RVA: 0x15982E8
	public float get_y() { }

	// RVA: 0x1598300
	public float get_z() { }

	// RVA: 0x1598318
	public void .ctor(Vector3 v, float epsilon) { }

	// RVA: 0x159834C
	public void .ctor(Byte mask) { }

	// RVA: 0x1598354
	public override string ToString() { }

	// RVA: 0x1598460
	public int get_active() { }

	// RVA: 0x159847C
	public static Vector3 op_Implicit(Vector3Mask mask) { }

	// RVA: 0x15984F8
	public static Vector3Mask op_Explicit(Vector3 v) { }

	// RVA: 0x1598530
	public static Vector3Mask op_BitwiseOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1598538
	public static Vector3Mask op_BitwiseAnd(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1598540
	public static Vector3Mask op_ExclusiveOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1598548
	public static Vector3 op_Multiply(Vector3Mask mask, float value) { }

	// RVA: 0x15985DC
	public static Vector3 op_Multiply(Vector3Mask mask, Vector3 value) { }

	// RVA: 0x1598680
	public static Vector3 op_Multiply(Quaternion rotation, Vector3Mask mask) { }

	// RVA: 0x1598898
	public static bool op_Equality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x15988A8
	public static bool op_Inequality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1598914
	public float get_Item(int i) { }

	// RVA: 0x1598978
	public void set_Item(int i, float value) { }

	// RVA: 0x15989F0
	public bool Equals(Vector3Mask other) { }

	// RVA: 0x1598A00
	public override bool Equals(object obj) { }

	// RVA: 0x1598AD0
	public override int GetHashCode() { }

	// RVA: 0x1598AD8
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

	// RVA: 0x1598B28
	public Vector3 get_position() { }

	// RVA: 0x1598B34
	public void set_position(Vector3 value) { }

	// RVA: 0x1598B60
	public Color get_color() { }

	// RVA: 0x1598B6C
	public void set_color(Color value) { }

	// RVA: 0x1598BA4
	public Vector3 get_normal() { }

	// RVA: 0x1598BB0
	public void set_normal(Vector3 value) { }

	// RVA: 0x1598BE8
	public Vector4 get_tangent() { }

	// RVA: 0x1598BF4
	public void set_tangent(Vector4 value) { }

	// RVA: 0x1598C2C
	public Vector2 get_uv0() { }

	// RVA: 0x1598C34
	public void set_uv0(Vector2 value) { }

	// RVA: 0x1598C68
	public Vector2 get_uv2() { }

	// RVA: 0x1598C70
	public void set_uv2(Vector2 value) { }

	// RVA: 0x1598CA4
	public Vector4 get_uv3() { }

	// RVA: 0x1598CB0
	public void set_uv3(Vector4 value) { }

	// RVA: 0x1598CE8
	public Vector4 get_uv4() { }

	// RVA: 0x1598CF4
	public void set_uv4(Vector4 value) { }

	// RVA: 0x1598D2C
	internal MeshArrays get_attributes() { }

	// RVA: 0x1598D34
	public bool HasArrays(MeshArrays attribute) { }

	// RVA: 0x1598D44
	private bool get_hasPosition() { }

	// RVA: 0x1598B4C
	private void set_hasPosition(bool value) { }

	// RVA: 0x1598D50
	private bool get_hasColor() { }

	// RVA: 0x1598B84
	private void set_hasColor(bool value) { }

	// RVA: 0x1598D5C
	private bool get_hasNormal() { }

	// RVA: 0x1598BC8
	private void set_hasNormal(bool value) { }

	// RVA: 0x1598D68
	private bool get_hasTangent() { }

	// RVA: 0x1598C0C
	private void set_hasTangent(bool value) { }

	// RVA: 0x1598D74
	private bool get_hasUV0() { }

	// RVA: 0x1598C48
	private void set_hasUV0(bool value) { }

	// RVA: 0x1598D80
	private bool get_hasUV2() { }

	// RVA: 0x1598C84
	private void set_hasUV2(bool value) { }

	// RVA: 0x1598D8C
	private bool get_hasUV3() { }

	// RVA: 0x1598CC8
	private void set_hasUV3(bool value) { }

	// RVA: 0x1598D98
	private bool get_hasUV4() { }

	// RVA: 0x1598D0C
	private void set_hasUV4(bool value) { }

	// RVA: 0x1598DA4
	public void .ctor() { }

	// RVA: 0x1598DAC
	public override bool Equals(object obj) { }

	// RVA: 0x1598E2C
	public bool Equals(Vertex other) { }

	// RVA: 0x1598F7C
	public bool Equals(Vertex other, MeshArrays mask) { }

	// RVA: 0x1599130
	public override int GetHashCode() { }

	// RVA: 0x15991A0
	public void .ctor(Vertex vertex) { }

	// RVA: 0x15992E4
	public static bool op_Equality(Vertex a, Vertex b) { }

	// RVA: 0x159930C
	public static bool op_Inequality(Vertex a, Vertex b) { }

	// RVA: 0x1599348
	public static Vertex op_Addition(Vertex a, Vertex b) { }

	// RVA: 0x15993C4
	public static Vertex Add(Vertex a, Vertex b) { }

	// RVA: 0x1599440
	public void Add(Vertex b) { }

	// RVA: 0x1599540
	public static Vertex op_Subtraction(Vertex a, Vertex b) { }

	// RVA: 0x15995BC
	public static Vertex Subtract(Vertex a, Vertex b) { }

	// RVA: 0x1599638
	public void Subtract(Vertex b) { }

	// RVA: 0x1599738
	public static Vertex op_Multiply(Vertex a, float value) { }

	// RVA: 0x159973C
	public static Vertex Multiply(Vertex a, float value) { }

	// RVA: 0x15997F8
	public void Multiply(float value) { }

	// RVA: 0x159983C
	public static Vertex op_Division(Vertex a, float value) { }

	// RVA: 0x1599840
	public static Vertex Divide(Vertex a, float value) { }

	// RVA: 0x15998FC
	public void Divide(float value) { }

	// RVA: 0x1599940
	public void Normalize() { }

	// RVA: 0x1599F74
	public string ToString(string args) { }

	// RVA: 0x159A290
	public static void GetArrays(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, Vector3[] position, Color[] color, Vector2[] uv0, Vector3[] normal, Vector4[] tangent, Vector2[] uv2, System.Collections.Generic.List<UnityEngine.Vector4>& uv3, System.Collections.Generic.List<UnityEngine.Vector4>& uv4) { }

	// RVA: 0x159A2BC
	public static void GetArrays(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, Vector3[] position, Color[] color, Vector2[] uv0, Vector3[] normal, Vector4[] tangent, Vector2[] uv2, System.Collections.Generic.List<UnityEngine.Vector4>& uv3, System.Collections.Generic.List<UnityEngine.Vector4>& uv4, MeshArrays attributes) { }

	// RVA: 0x159AD04
	public static void SetMesh(Mesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x159AFFC
	public static Vertex Average(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x159BCF8
	public static Vertex Mix(Vertex x, Vertex y, float weight) { }

}

// Namespace: UnityEngine.ProBuilder
public static class VertexPositioning
{
	// Fields
	private static System.Collections.Generic.List<System.Int32> s_CoincidentVertices; // 0x0

	// Methods

	// RVA: 0x159C028
	public static Vector3[] VerticesInWorldSpace(ProBuilderMesh mesh) { }

	// RVA: 0x159C204
	public static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset) { }

	// RVA: 0x159C33C
	internal static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset, float snapValue, bool snapAxisOnly) { }

	// RVA: 0x159C90C
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, Vector3 offset) { }

	// RVA: 0x159CC04
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Vector3 offset) { }

	// RVA: 0x159CD54
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, Vector3 offset) { }

	// RVA: 0x159CA5C
	private static void TranslateVerticesInternal(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indices, Vector3 offset) { }

	// RVA: 0x159CEA4
	public static void SetSharedVertexPosition(ProBuilderMesh mesh, int sharedVertexHandle, Vector3 position) { }

	// RVA: 0x159D258
	internal static void SetSharedVertexValues(ProBuilderMesh mesh, int sharedVertexHandle, Vertex vertex) { }

	// RVA: 0x159D53C
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

	// RVA: 0x159F860
	private static void .cctor() { }

	// RVA: 0x159F8CC
	public void .ctor() { }

	// RVA: 0x159F8D4
	internal Edge <SortCommonIndexesByAdjacency>b__32_1(WingedEdge y) { }

	// RVA: 0x159F8F0
	internal int <SortCommonIndexesByAdjacency>b__32_2(Edge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public System.Collections.Generic.HashSet<System.Int32> common; // 0x10

	// Methods

	// RVA: 0x159ED3C
	public void .ctor() { }

	// RVA: 0x159F8F8
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

	// RVA: 0x159D5D8
	public EdgeLookup get_edge() { }

	// RVA: 0x159D5E4
	private void set_edge(EdgeLookup value) { }

	// RVA: 0x159D5EC
	public Face get_face() { }

	// RVA: 0x159D5F4
	private void set_face(Face value) { }

	// RVA: 0x159D5FC
	public WingedEdge get_next() { }

	// RVA: 0x159D604
	private void set_next(WingedEdge value) { }

	// RVA: 0x159D60C
	public WingedEdge get_previous() { }

	// RVA: 0x159D614
	private void set_previous(WingedEdge value) { }

	// RVA: 0x159D61C
	public WingedEdge get_opposite() { }

	// RVA: 0x159D624
	private void set_opposite(WingedEdge value) { }

	// RVA: 0x159D62C
	private void .ctor() { }

	// RVA: 0x159D634
	public bool Equals(WingedEdge other) { }

	// RVA: 0x159D6D4
	public override bool Equals(object obj) { }

	// RVA: 0x159D884
	public override int GetHashCode() { }

	// RVA: 0x159D8FC
	public int Count() { }

	// RVA: 0x159D934
	public override string ToString() { }

	// RVA: 0x159DB54
	internal static int[] MakeQuad(WingedEdge left, WingedEdge right) { }

	// RVA: 0x159E2A8
	public WingedEdge GetAdjacentEdgeWithCommonIndex(int common) { }

	// RVA: 0x159E398
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> SortEdgesByAdjacency(Face face) { }

	// RVA: 0x159E4B4
	public static void SortEdgesByAdjacency(System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x159E688
	public static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge>> GetSpokes(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings) { }

	// RVA: 0x159EA08
	internal static System.Collections.Generic.List<System.Int32> SortCommonIndexesByAdjacency(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, System.Collections.Generic.HashSet<System.Int32> common) { }

	// RVA: 0x159ED44
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetWingedEdges(ProBuilderMesh mesh, bool oneWingPerFace) { }

	// RVA: 0x159EE5C
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetWingedEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool oneWingPerFace) { }

	// RVA: 0x159F7C4
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
public sealed class WingedEdgeEnumerator
{
	// Fields
	private WingedEdge m_Start; // 0x10
	private WingedEdge m_Current; // 0x18

	// Methods

	// RVA: 0x159F994
	public void .ctor(WingedEdge start) { }

	// RVA: 0x159F9D8
	public bool MoveNext() { }

	// RVA: 0x159FA60
	public void Reset() { }

	// RVA: 0x159FA6C
	public WingedEdge get_Current() { }

	// RVA: 0x159FA74
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x159FA7C
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

	// RVA: 0x159FA80
	public override void CopyShape(Shape shape) { }

	// RVA: 0x159FB30
	private Vector3[] GetFace(Vector2 vertex1, Vector2 vertex2, float depth) { }

	// RVA: 0x159FBF8
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A0804
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

	// RVA: 0x15A0834
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A08DC
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x15A0A54
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A1650
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Cube
{
	// Fields
	private static readonly Vector3[] k_CubeVertices; // 0x0
	private static readonly int[] k_CubeTriangles; // 0x8

	// Methods

	// RVA: 0x15A1668
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A166C
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A1890
	public void .ctor() { }

	// RVA: 0x15A1898
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

	// RVA: 0x15A1A28
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A1B18
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x15A1B44
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A26C8
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Door
{
	// Fields
	private float m_DoorHeight; // 0x10
	private float m_LegWidth; // 0x14

	// Methods

	// RVA: 0x15A26E0
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A27A8
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A3704
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

	// RVA: 0x15A3718
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A37C0
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x15A37EC
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A4388
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Plane
{
	// Fields
	private int m_HeightSegments; // 0x10
	private int m_WidthSegments; // 0x14

	// Methods

	// RVA: 0x15A43A4
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A446C
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A4764
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Prism
{
	// Methods

	// RVA: 0x15A4774
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A4778
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A4EBC
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

	// RVA: 0x15A4EC4
	public Shape get_shape() { }

	// RVA: 0x15A4ECC
	public void set_shape(Shape value) { }

	// RVA: 0x15A4ED4
	public PivotLocation get_pivotLocation() { }

	// RVA: 0x15A4EDC
	public void set_pivotLocation(PivotLocation value) { }

	// RVA: 0x15A4EE4
	public Vector3 get_pivotLocalPosition() { }

	// RVA: 0x15A4EF0
	public void set_pivotLocalPosition(Vector3 value) { }

	// RVA: 0x15A4EFC
	public Vector3 get_pivotGlobalPosition() { }

	// RVA: 0x15A50C0
	public void set_pivotGlobalPosition(Vector3 value) { }

	// RVA: 0x15A512C
	public Vector3 get_size() { }

	// RVA: 0x15A5138
	public void set_size(Vector3 value) { }

	// RVA: 0x15A5244
	public Quaternion get_rotation() { }

	// RVA: 0x15A5250
	public void set_rotation(Quaternion value) { }

	// RVA: 0x15A525C
	public Bounds get_editionBounds() { }

	// RVA: 0x15A5318
	public Bounds get_shapeBox() { }

	// RVA: 0x15A532C
	public bool get_isEditable() { }

	// RVA: 0x15A4F3C
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x15A5360
	private void OnValidate() { }

	// RVA: 0x15A5460
	internal void UpdateComponent() { }

	// RVA: 0x15A5888
	internal void UpdateBounds(Bounds bounds) { }

	// RVA: 0x15A59F4
	internal void Rebuild(Bounds bounds, Quaternion rotation, Vector3 cornerPivot) { }

	// RVA: 0x15A56D0
	private void Rebuild() { }

	// RVA: 0x15A5E0C
	internal void SetShape(Shape shape, PivotLocation location) { }

	// RVA: 0x15A5F9C
	internal void RotateInsideBounds(Quaternion deltaRotation) { }

	// RVA: 0x15A54A0
	private void ResetPivot(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A5BBC
	internal void RebuildPivot(Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A607C
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
[Serializable]
public abstract class Shape
{
	// Methods

	// RVA: 0x15A616C
	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: -1
	public abstract Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: -1
	public abstract void CopyShape(Shape shape) { }

	// RVA: 0x15A082C
	protected void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class ShapeAttribute
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x15A61C4
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

	// RVA: 0x15A61F8
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A6298
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x15A62FC
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A6D24
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x15A7260
	public void .ctor() { }

	// RVA: 0x15A7278
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Sprite
{
	// Methods

	// RVA: 0x15A747C
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A7480
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A7838
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

	// RVA: 0x15A7840
	public bool get_sides() { }

	// RVA: 0x15A7848
	public void set_sides(bool value) { }

	// RVA: 0x15A7850
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A7918
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A99E0
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x15A8A2C
	private Bounds BuildStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A7970
	private Bounds BuildCurvedStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15A9B40
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

	// RVA: 0x15A9B6C
	public override void CopyShape(Shape shape) { }

	// RVA: 0x15A9C14
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x15A9C98
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15AA690
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x15AA9C8
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x15AAC3C
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

	// RVA: 0x15B6140
	private static void .cctor() { }

	// RVA: 0x15B61AC
	public void .ctor() { }

	// RVA: 0x15B61B4
	internal int <CreateShapeFromPolygon>b__8_0(Vector3[] arr) { }

	// RVA: 0x15B61D0
	internal Vector3 <FaceWithVerticesAndHole>b__10_0(Vertex v) { }

	// RVA: 0x15B61F0
	internal Vector3 <FaceWithVerticesAndHole>b__10_1(Vertex v) { }

	// RVA: 0x15B6210
	internal Face <InsertVertexInFace>b__18_0(FaceRebuildData f) { }

}

// Namespace: 
private sealed class <>c__DisplayClass17_0
{
	// Fields
	public int delCount; // 0x10

	// Methods

	// RVA: 0x15B36D8
	public void .ctor() { }

	// RVA: 0x15B622C
	internal Edge <AppendVerticesToEdge>b__0(EdgeLookup x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class AppendElements
{
	// Methods

	// RVA: 0x15AB0F0
	internal static Face AppendFace(ProBuilderMesh mesh, Vector3[] positions, Color[] colors, Vector2[] uv0s, Vector4[] uv2s, Vector4[] uv3s, Face face, int[] common) { }

	// RVA: 0x15AB998
	public static Face[] AppendFaces(ProBuilderMesh mesh, Vector3[][] positions, Color[][] colors, Vector2[][] uvs, Face[] faces, Int32[][] shared) { }

	// RVA: 0x15ABFCC
	public static Face CreatePolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes, bool unordered) { }

	// RVA: 0x15AC7B4
	public static Face CreatePolygonWithHole(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes, System.Collections.Generic.IList<System.Collections.Generic.IList<System.Int32>> holes) { }

	// RVA: 0x15AD8A0
	public static ActionResult CreateShapeFromPolygon(PolyShape poly) { }

	// RVA: 0x15AD8E4
	internal static void ClearAndRefreshMesh(ProBuilderMesh mesh) { }

	// RVA: 0x15AD8DC
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals) { }

	// RVA: 0x15AE6AC
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals, Vector3 cameraLookAt, System.Collections.Generic.IList<System.Collections.Generic.IList<UnityEngine.Vector3>> holePoints) { }

	// RVA: 0x15AD92C
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals, System.Collections.Generic.IList<System.Collections.Generic.IList<UnityEngine.Vector3>> holePoints) { }

	// RVA: 0x15AC6C8
	internal static FaceRebuildData FaceWithVertices(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, bool unordered) { }

	// RVA: 0x15AD360
	internal static FaceRebuildData FaceWithVerticesAndHole(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> borderVertices, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>> holes) { }

	// RVA: 0x15AED38
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> TentCapWithVertices(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> path) { }

	// RVA: 0x15AE6B4
	public static void DuplicateAndFlip(ProBuilderMesh mesh, Face[] faces) { }

	// RVA: 0x15AEFD4
	public static Face Bridge(ProBuilderMesh mesh, Edge a, Edge b, bool allowNonManifoldGeometry) { }

	// RVA: 0x15B0720
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points) { }

	// RVA: 0x15B0728
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points, bool insertOnEdge) { }

	// RVA: 0x15B15E0
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> AppendVerticesToEdge(ProBuilderMesh mesh, Edge edge, int count) { }

	// RVA: 0x15B166C
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> AppendVerticesToEdge(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, int count) { }

	// RVA: 0x15B3BB0
	public static Face[] InsertVertexInFace(ProBuilderMesh mesh, Face face, Vector3 point) { }

	// RVA: 0x15B48A4
	public static Vertex InsertVertexOnEdge(ProBuilderMesh mesh, Edge originalEdge, Vector3 point) { }

	// RVA: 0x15B5D80
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

	// RVA: 0x15BA23C
	private static void .cctor() { }

	// RVA: 0x15BA2A8
	public void .ctor() { }

	// RVA: 0x15BA2B0
	internal Face <BevelEdges>b__0_0(FaceRebuildData x) { }

	// RVA: 0x15BA2CC
	internal int <BevelEdges>b__0_6(UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.FaceRebuildData,System.Collections.Generic.List<System.Int32>> x) { }

	// RVA: 0x15BA3B0
	internal Face <BevelEdges>b__0_1(FaceRebuildData x) { }

	// RVA: 0x15BA3CC
	internal Face <BevelEdges>b__0_2(FaceRebuildData x) { }

	// RVA: 0x15BA3E8
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

	// RVA: 0x15B94AC
	public void .ctor() { }

	// RVA: 0x15BA404
	internal int <BevelEdges>b__7(int x) { }

	// RVA: 0x15BA444
	internal int <BevelEdges>b__8(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_1
{
	// Fields
	public EdgeLookup lup; // 0x10

	// Methods

	// RVA: 0x15B94B4
	public void .ctor() { }

	// RVA: 0x15BA484
	internal bool <BevelEdges>b__4(WingedEdge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_2
{
	// Fields
	public int c; // 0x10
	public UnityEngine.ProBuilder.MeshOperations.Bevel.<>c__DisplayClass0_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x15B9F68
	public void .ctor() { }

	// RVA: 0x15BA4BC
	internal bool <BevelEdges>b__5(WingedEdge x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class Bevel
{
	// Fields
	private static readonly int[] k_BridgeIndexesTri; // 0x0

	// Methods

	// RVA: 0x15B629C
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> BevelEdges(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, float amount) { }

	// RVA: 0x15B98E8
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> GetBridgeFaces(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, WingedEdge left, WingedEdge right, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.FaceRebuildData,System.Collections.Generic.List<System.Int32>>>> holes) { }

	// RVA: 0x15B94BC
	private static void SlideEdge(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, WingedEdge we, float amount) { }

	// RVA: 0x15BA090
	private static Edge GetLeadingEdge(WingedEdge wing, int common) { }

	// RVA: 0x15BA198
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

	// RVA: 0x15BD6F8
	private static void .cctor() { }

	// RVA: 0x15BD764
	public void .ctor() { }

	// RVA: 0x15BD76C
	internal int <SplitByMaxVertexCount>b__5_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class CombineMeshes
{
	// Methods

	// RVA: 0x15BA628
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> Combine(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes) { }

	// RVA: 0x15BAC04
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> Combine(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes, ProBuilderMesh meshTarget) { }

	// RVA: 0x15BA62C
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> CombineToNewMeshes(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes) { }

	// RVA: 0x15BB67C
	private static void AccumulateMeshesInfo(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes, int offset, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>& vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face>& faces, System.Collections.Generic.List<UnityEngine.ProBuilder.Face>& autoUvFaces, System.Collections.Generic.List<UnityEngine.ProBuilder.SharedVertex>& sharedVertices, System.Collections.Generic.List<UnityEngine.ProBuilder.SharedVertex>& sharedTextures, System.Collections.Generic.List<UnityEngine.Material>& materialMap, Transform targetTransform) { }

	// RVA: 0x15BCDC8
	private static ProBuilderMesh CreateMeshFromSplit(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVertexLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedTextureLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> remap, Material[] materials) { }

	// RVA: 0x15BC1A4
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> SplitByMaxVertexCount(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedTextures, UInt32 maxVertexCount) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal sealed class ConnectFaceRebuildData
{
	// Fields
	public FaceRebuildData faceRebuildData; // 0x10
	public System.Collections.Generic.List<System.Int32> newVertexIndexes; // 0x18

	// Methods

	// RVA: 0x15BD788
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

	// RVA: 0x15C37A8
	private static void .cctor() { }

	// RVA: 0x15C3814
	public void .ctor() { }

	// RVA: 0x15C381C
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <Connect>b__0_0(Face x) { }

	// RVA: 0x15C3838
	internal int <Connect>b__2_1(Face x) { }

	// RVA: 0x15C3854
	internal FaceRebuildData <Connect>b__2_2(ConnectFaceRebuildData x) { }

	// RVA: 0x15C3870
	internal int <Connect>b__3_0(Face x) { }

	// RVA: 0x15C388C
	internal FaceRebuildData <Connect>b__3_1(ConnectFaceRebuildData x) { }

	// RVA: 0x15C38A8
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <Connect>b__3_2(ConnectFaceRebuildData x) { }

	// RVA: 0x15C38D4
	internal Edge <Connect>b__3_4(EdgeLookup x) { }

	// RVA: 0x15C38DC
	internal System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> <ConnectEdgesInFace>b__5_0(int x) { }

	// RVA: 0x15C3950
	internal System.Collections.Generic.List<System.Int32> <ConnectEdgesInFace>b__5_1(int x) { }

	// RVA: 0x15C39C4
	internal Edge <ConnectEdgesInFace>b__5_2(WingedEdge x) { }

	// RVA: 0x15C39E0
	internal Edge <InsertVertices>b__6_0(WingedEdge x) { }

	// RVA: 0x15C39FC
	internal System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> <ConnectIndexesPerFace>b__8_0(int x) { }

	// RVA: 0x15C3A70
	internal System.Collections.Generic.List<System.Int32> <ConnectIndexesPerFace>b__8_1(int x) { }

	// RVA: 0x15C3AE4
	internal System.Collections.Generic.List<System.Int32> <ConnectIndexesPerFace>b__8_2(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup; // 0x10
	public ProBuilderMesh mesh; // 0x18

	// Methods

	// RVA: 0x15C0C28
	public void .ctor() { }

	// RVA: 0x15C3B58
	internal int <Connect>b__0(int x) { }

	// RVA: 0x15C3BD4
	internal int <Connect>b__3(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public System.Collections.Generic.HashSet<System.Int32> appended; // 0x10

	// Methods

	// RVA: 0x15C37A0
	public void .ctor() { }

	// RVA: 0x15C3C1C
	internal bool <Connect>b__3(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ConnectElements
{
	// Methods

	// RVA: 0x15BD7D8
	public static Face[] Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15BF79C
	public static UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face[],UnityEngine.ProBuilder.Edge[]> Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15BF830
	public static int[] Connect(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x15BDBBC
	internal static ActionResult Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Face[] addedFaces, Edge[] connections, bool returnFaces, bool returnEdges, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> faceMask) { }

	// RVA: 0x15C2F78
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectEdgesInFace(Face face, WingedEdge a, WingedEdge b, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x15C2510
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectEdgesInFace(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> edges, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x15C1EB8
	private static bool InsertVertices(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> edges, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, ConnectFaceRebuildData data) { }

	// RVA: 0x15C16E0
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, int a, int b, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x15C0C30
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

	// RVA: 0x15C44D0
	private static void .cctor() { }

	// RVA: 0x15C453C
	public void .ctor() { }

	// RVA: 0x15C4544
	internal System.Collections.Generic.IEnumerable<System.Int32> <DeleteFaces>b__3_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public System.Collections.Generic.List<System.Int32> sorted; // 0x10
	public int[] offset; // 0x18

	// Methods

	// RVA: 0x15C3CB0
	public void .ctor() { }

	// RVA: 0x15C4560
	internal bool <DeleteVertices>b__0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

	// RVA: 0x15C466C
	internal System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> <DeleteVertices>b__1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

	// RVA: 0x15C48B4
	internal bool <DeleteVertices>b__2(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

	// RVA: 0x15C49C0
	internal System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> <DeleteVertices>b__3(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x15C3CB8
	public void .ctor() { }

	// RVA: 0x15C4C08
	internal int <DeleteFaces>b__0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class DeleteElements
{
	// Methods

	// RVA: 0x15B36E0
	public static void DeleteVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> distinctIndexes) { }

	// RVA: 0x15B1554
	public static int[] DeleteFace(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15B9F70
	public static int[] DeleteFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15C3CC0
	public static int[] DeleteFaces(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> faceIndexes) { }

	// RVA: 0x15C4380
	public static int[] RemoveDegenerateTriangles(ProBuilderMesh mesh) { }

	// RVA: 0x15C4428
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

	// RVA: 0x15CB390
	private static void .cctor() { }

	// RVA: 0x15CB3FC
	public void .ctor() { }

	// RVA: 0x15CB404
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <GetPerimeterEdges>b__5_0(Face x) { }

	// RVA: 0x15CB420
	internal bool <GetPerimeterEdges>b__5_1(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> x) { }

	// RVA: 0x15CB50C
	internal Edge <GetPerimeterEdges>b__5_2(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> x) { }

	// RVA: 0x15CB608
	internal bool <GetPerimeterFaces>b__7_0(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>> x) { }

	// RVA: 0x15CB6F4
	internal Face <GetPerimeterFaces>b__7_1(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>> x) { }

	// RVA: 0x15CB7F0
	internal Edge <GetEdgeRing>b__10_0(EdgeLookup x) { }

	// RVA: 0x15CB7F8
	internal Edge <GetEdgeRingIterative>b__11_0(EdgeLookup x) { }

	// RVA: 0x15CB800
	internal Edge <GetEdgeLoop>b__12_0(EdgeLookup x) { }

	// RVA: 0x15CB808
	internal Edge <GetEdgeLoopIterative>b__13_0(EdgeLookup x) { }

	// RVA: 0x15CB810
	internal Edge <GetEdgeLoopInternal>b__14_0(WingedEdge x) { }

	// RVA: 0x15CB82C
	internal Edge <GetEdgeLoopInternalIterative>b__15_0(WingedEdge x) { }

	// RVA: 0x15CB848
	internal Edge <GetEdgeLoopInternalIterative>b__15_1(WingedEdge x) { }

	// RVA: 0x15CB864
	internal Edge <FindHoles>b__26_0(WingedEdge x) { }

	// RVA: 0x15CB880
	internal int <FindHoles>b__27_0(UnityEngine.ProBuilder.SimpleTuple<System.Int32,System.Int32> x, UnityEngine.ProBuilder.SimpleTuple<System.Int32,System.Int32> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0
{
	// Fields
	public Face face; // 0x10

	// Methods

	// RVA: 0x15CB9D4
	public void .ctor() { }

	// RVA: 0x15CB9DC
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

	// RVA: 0x15CBA04
	public void .ctor() { }

	// RVA: 0x15CBA0C
	internal bool <FindHoles>b__1(WingedEdge w) { }

	// RVA: 0x15CBA88
	internal bool <FindHoles>b__2(WingedEdge w) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ElementSelection
{
	// Fields
	private const int k_MaxHoleIterations = 2048;
	private static readonly Vector3 Vector3_Zero; // 0x0

	// Methods

	// RVA: 0x15C4C70
	public static void GetNeighborFaces(ProBuilderMesh mesh, Edge edge, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> neighborFaces) { }

	// RVA: 0x15B0418
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Edge>> GetNeighborFaces(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x15C4EEC
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> GetNeighborFaces(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x15C5240
	internal static Edge[] GetConnectedEdges(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x15C58B8
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetPerimeterEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15C5F90
	internal static int[] GetPerimeterEdges(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15C63C4
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> GetPerimeterFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15C6B40
	internal static int[] GetPerimeterVertices(ProBuilderMesh mesh, int[] indexes, Edge[] universal_edges_all) { }

	// RVA: 0x15C6F38
	private static WingedEdge EdgeRingNext(WingedEdge edge) { }

	// RVA: 0x15C6FBC
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetEdgeRing(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15C769C
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetEdgeRingIterative(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15C7D34
	internal static bool GetEdgeLoop(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Edge[] loop) { }

	// RVA: 0x15C8450
	internal static bool GetEdgeLoopIterative(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Edge[] loop) { }

	// RVA: 0x15C81D0
	private static bool GetEdgeLoopInternal(WingedEdge start, int startIndex, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> used) { }

	// RVA: 0x15C87C0
	private static void GetEdgeLoopInternalIterative(WingedEdge start, Edge edge, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> used) { }

	// RVA: 0x15C8E98
	private static WingedEdge NextSpoke(WingedEdge wing, int pivot, bool opp) { }

	// RVA: 0x15C8B80
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetSpokes(WingedEdge wing, int sharedIndex, bool allowHoles) { }

	// RVA: 0x15C8FA0
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GrowSelection(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float maxAngleDiff) { }

	// RVA: 0x15C9560
	internal static void Flood(WingedEdge wing, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> selection) { }

	// RVA: 0x15C95E0
	internal static void Flood(ProBuilderMesh pb, WingedEdge wing, Vector3 wingNrm, float maxAngle, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> selection) { }

	// RVA: 0x15C991C
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> FloodSelection(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, float maxAngleDiff) { }

	// RVA: 0x15C9CC0
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceLoop(ProBuilderMesh mesh, Face[] faces, bool ring) { }

	// RVA: 0x15CA130
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceRingAndLoop(ProBuilderMesh mesh, Face[] faces) { }

	// RVA: 0x15C9F08
	private static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceLoop(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, Face face, bool ring) { }

	// RVA: 0x15CA38C
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> FindHoles(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x15CA760
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge>> FindHoles(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, System.Collections.Generic.HashSet<System.Int32> common) { }

	// RVA: 0x15CB2BC
	private static WingedEdge FindNextEdgeInHole(WingedEdge wing, int common) { }

	// RVA: 0x15CB340
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

	// RVA: 0x15D1764
	private static void .cctor() { }

	// RVA: 0x15D17D0
	public void .ctor() { }

	// RVA: 0x15D17D8
	internal Face <DetachFaces>b__3_0(FaceRebuildData x) { }

	// RVA: 0x15D17F4
	internal int <ExtrudePerFace>b__4_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ExtrudeElements
{
	// Methods

	// RVA: 0x15CBB04
	public static Face[] Extrude(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, ExtrudeMethod method, float distance) { }

	// RVA: 0x15CEE84
	public static Edge[] Extrude(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, float distance, bool extrudeAsGroup, bool enableManifoldExtrude) { }

	// RVA: 0x15D0048
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> DetachFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15D0050
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> DetachFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool deleteSourceFaces) { }

	// RVA: 0x15CBB18
	private static Face[] ExtrudePerFace(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float distance) { }

	// RVA: 0x15CC6D0
	private static Face[] ExtrudeAsGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool compensateAngleVertexDistance, float distance) { }

	// RVA: 0x15D0B74
	private static System.Collections.Generic.List<System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> GetFaceGroups(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings) { }

	// RVA: 0x15D1118
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

	// RVA: 0x15D3F68
	private static void .cctor() { }

	// RVA: 0x15D3FD4
	public void .ctor() { }

	// RVA: 0x15D3FDC
	internal Vector3[] <CreateMeshWithTransform>b__1_0(Mesh x) { }

	// RVA: 0x15D3FF8
	internal Color[] <CreateMeshWithTransform>b__1_1(Mesh x) { }

	// RVA: 0x15D4014
	internal Vector2[] <CreateMeshWithTransform>b__1_2(Mesh x) { }

	// RVA: 0x15D4030
	internal Vector3[] <ResetPbObjectWithMeshFilter>b__2_0(Mesh x) { }

	// RVA: 0x15D404C
	internal Color[] <ResetPbObjectWithMeshFilter>b__2_1(Mesh x) { }

	// RVA: 0x15D4068
	internal Vector2[] <ResetPbObjectWithMeshFilter>b__2_2(Mesh x) { }

	// RVA: 0x15D4084
	internal bool <FilterUnusedSubmeshIndexes>b__3_0(bool x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class InternalMeshUtility
{
	// Methods

	// RVA: 0x15CFE54
	internal static Vector3 AverageNormalWithIndexes(SharedVertex shared, int[] all, System.Collections.Generic.IList<UnityEngine.Vector3> norm) { }

	// RVA: 0x15D1854
	public static ProBuilderMesh CreateMeshWithTransform(Transform t, bool preserveFaces) { }

	// RVA: 0x15D2A48
	public static bool ResetPbObjectWithMeshFilter(ProBuilderMesh pb, bool preserveFaces) { }

	// RVA: 0x15D3A20
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

	// RVA: 0x15D54B8
	private static void .cctor() { }

	// RVA: 0x15D5524
	public void .ctor() { }

	// RVA: 0x15D552C
	internal System.Collections.Generic.IEnumerable<System.Int32> <Merge>b__1_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> remove; // 0x10

	// Methods

	// RVA: 0x15D47E4
	public void .ctor() { }

	// RVA: 0x15D5548
	internal bool <MergePairs>b__0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MergeElements
{
	// Methods

	// RVA: 0x15D408C
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> MergePairs(ProBuilderMesh target, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Face>> pairs, bool collapseCoincidentVertices) { }

	// RVA: 0x15D4CC0
	public static Face Merge(ProBuilderMesh target, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15D47EC
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

	// RVA: 0x15D55B4
	public bool get_quads() { }

	// RVA: 0x15D55BC
	public void set_quads(bool value) { }

	// RVA: 0x15D55C4
	public bool get_smoothing() { }

	// RVA: 0x15D55CC
	public void set_smoothing(bool value) { }

	// RVA: 0x15D55D4
	public float get_smoothingAngle() { }

	// RVA: 0x15D55DC
	public void set_smoothingAngle(float value) { }

	// RVA: 0x15D55E4
	public override string ToString() { }

	// RVA: 0x15D56A4
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

	// RVA: 0x15D6F20
	private static void .cctor() { }

	// RVA: 0x15D6F8C
	public void .ctor() { }

	// RVA: 0x15D6F94
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

	// RVA: 0x15D56BC
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x15D5870
	public void .ctor(Mesh sourceMesh, Material[] sourceMaterials, ProBuilderMesh destination) { }

	// RVA: 0x15D59E4
	public void .ctor(ProBuilderMesh destination) { }

	// RVA: 0x15D5A18
	public bool Import(GameObject go, MeshImportSettings importSettings) { }

	// RVA: 0x15D5BF8
	public void Import(MeshImportSettings importSettings) { }

	// RVA: 0x15D6E80
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MeshTransform
{
	// Methods

	// RVA: 0x15D6FB4
	internal static void SetPivot(ProBuilderMesh mesh, PivotLocation pivotLocation) { }

	// RVA: 0x15D2758
	public static void CenterPivot(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x15D7054
	public static void SetPivot(ProBuilderMesh mesh, Vector3 worldPosition) { }

	// RVA: 0x15D7210
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

	// RVA: 0x15DA294
	private static void .cctor() { }

	// RVA: 0x15DA300
	public void .ctor() { }

	// RVA: 0x15DA308
	internal System.Collections.Generic.IEnumerable<System.Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_0(Triangle x) { }

	// RVA: 0x15DA334
	internal System.Collections.Generic.IEnumerable<System.Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_1(Triangle x) { }

	// RVA: 0x15DA360
	internal System.Collections.Generic.IEnumerable<System.Int32> <RemoveUnusedVertices>b__7_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x15D9980
	public void .ctor() { }

	// RVA: 0x15DA37C
	internal bool <RebuildSelectionIndexes>b__0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public Triangle triangle; // 0x10
	public System.Func<UnityEngine.ProBuilder.Triangle,System.Boolean> <>9__0; // 0x20

	// Methods

	// RVA: 0x15D84BC
	public void .ctor() { }

	// RVA: 0x15DA3E4
	internal bool <CollectFaceGroups>b__0(Triangle x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MeshValidation
{
	// Methods

	// RVA: 0x15D7384
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh) { }

	// RVA: 0x15D73A0
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15D77F0
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15D7964
	public static bool ContainsNonContiguousTriangles(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15D7A98
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> EnsureFacesAreComposedOfContiguousTriangles(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15D8134
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Triangle>> CollectFaceGroups(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15D84C4
	public static bool RemoveDegenerateTriangles(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x15D5104
	public static bool RemoveUnusedVertices(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x15D8F3C
	internal static System.Collections.Generic.List<System.Int32> RebuildIndexes(System.Collections.Generic.IEnumerable<System.Int32> indices, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x15D9310
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> RebuildEdges(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x15D975C
	internal static void RebuildSelectionIndexes(ProBuilderMesh mesh, Face[] faces, Edge[] edges, int[] indices, System.Collections.Generic.IEnumerable<System.Int32> removed) { }

	// RVA: 0x15D9988
	internal static bool EnsureMeshIsValid(ProBuilderMesh mesh, int removedVertices) { }

	// RVA: 0x15D9CF0
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector2> attribute) { }

	// RVA: 0x15D9EC8
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector3> attribute) { }

	// RVA: 0x15DA0AC
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector4> attribute) { }

	// RVA: 0x26AD93C
	private static void EnsureArraySize(T[] attribute, int expectedVertexCount, AttributeValidationStrategy strategy, T fill) { }

	// RVA: 0x26AD93C
	private static void EnsureListSize(System.Collections.Generic.List<T>& attribute, int expectedVertexCount, AttributeValidationStrategy strategy, T fill) { }

	// RVA: 0x15D9B04
	private static void EnsureValidAttributes(ProBuilderMesh mesh) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class QuadUtility
{
	// Methods

	// RVA: 0x15D6448
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> ToQuads(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, bool smoothing) { }

	// RVA: 0x15DAB18
	private static Face GetBestQuadConnection(WingedEdge wing, System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.EdgeLookup,System.Single> connections) { }

	// RVA: 0x15DA418
	private static float GetQuadScore(ProBuilderMesh mesh, WingedEdge left, WingedEdge right, float normalThreshold) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class Subdivision
{
	// Methods

	// RVA: 0x15DADE4
	public static ActionResult Subdivide(ProBuilderMesh pb) { }

	// RVA: 0x15DAE9C
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

	// RVA: 0x15DCF1C
	private static void .cctor() { }

	// RVA: 0x15DCF88
	public void .ctor() { }

	// RVA: 0x15DCF90
	internal Face <ToTriangles>b__0_0(FaceRebuildData x) { }

	// RVA: 0x15DCFAC
	internal Vector3 <GetWindingOrder>b__3_0(Vertex x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class SurfaceTopology
{
	// Methods

	// RVA: 0x15DAEA4
	public static Face[] ToTriangles(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15DB440
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> BreakFaceIntoTris(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x15DB8C8
	public static WindingOrder GetWindingOrder(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15DBBC4
	private static WindingOrder GetWindingOrder(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x15DB90C
	public static WindingOrder GetWindingOrder(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x15DBD70
	public static bool FlipEdge(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15DC1C4
	public static ActionResult ConformNormals(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15DC98C
	private static void GetWindingFlags(WingedEdge edge, bool flag, System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Face,System.Boolean> flags) { }

	// RVA: 0x15DCC18
	internal static ActionResult ConformOppositeNormal(WingedEdge source) { }

	// RVA: 0x15DCA94
	private static Edge GetCommonEdgeInWindingOrder(WingedEdge wing) { }

	// RVA: 0x15DCD34
	internal static void MatchNormal(Face source, Face target, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public int index; // 0x10

	// Methods

	// RVA: 0x15DF328
	public void .ctor() { }

	// RVA: 0x15DF338
	internal TriangulationPoint <Triangulate>b__0(Vector2 x) { }

	// RVA: 0x15DF3C4
	internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public int index; // 0x10
	public System.Func<UnityEngine.Vector2,UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> <>9__1; // 0x18

	// Methods

	// RVA: 0x15DF330
	public void .ctor() { }

	// RVA: 0x15DF450
	internal PolygonPoint <Triangulate>b__0(Vector2 x) { }

	// RVA: 0x15DF4DC
	internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class Triangulation
{
	// Fields
	private static TriangulationContext s_TriangulationContext; // 0x0

	// Methods

	// RVA: 0x15DCFCC
	private static TriangulationContext get_triangulationContext() { }

	// RVA: 0x15DD088
	public static bool SortAndTriangulate(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.List<System.Int32>& indexes, bool convex) { }

	// RVA: 0x15DE090
	public static bool TriangulateVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<System.Int32>& triangles, bool unordered, bool convex) { }

	// RVA: 0x15DE454
	public static bool TriangulateVertices(Vector3[] vertices, System.Collections.Generic.List<System.Int32>& triangles, Vector3[][] holes) { }

	// RVA: 0x15DE2D8
	public static bool TriangulateVertices(Vector3[] vertices, System.Collections.Generic.List<System.Int32>& triangles, bool unordered, bool convex) { }

	// RVA: 0x15DD42C
	public static bool Triangulate(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.List<System.Int32>& indexes, bool convex) { }

	// RVA: 0x15DE604
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

	// RVA: 0x15E2DA0
	private static void .cctor() { }

	// RVA: 0x15E2E0C
	public void .ctor() { }

	// RVA: 0x15E2E14
	internal Vector2 <GetUVs>b__2_0(Vector4 x) { }

	// RVA: 0x15E2E18
	internal int <SewUVs>b__4_1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

	// RVA: 0x15E2EE0
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesAuto>b__8_0(Face x) { }

	// RVA: 0x15E2EFC
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesAuto>b__8_1(Face x) { }

	// RVA: 0x15E2F18
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesBox>b__9_0(Face x) { }

	// RVA: 0x15E2F34
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesBox>b__11_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public Face f1; // 0x10
	public Face f2; // 0x18

	// Methods

	// RVA: 0x15DF838
	public void .ctor() { }

	// RVA: 0x15E2F50
	internal bool <AutoStitch>b__0(WingedEdge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public int b; // 0x10

	// Methods

	// RVA: 0x15E1224
	public void .ctor() { }

	// RVA: 0x15E2F9C
	internal bool <SewUVs>b__0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class UVEditing
{
	// Methods

	// RVA: 0x15DF568
	public static bool AutoStitch(ProBuilderMesh mesh, Face f1, Face f2, int channel) { }

	// RVA: 0x15DF840
	private static bool AlignEdges(ProBuilderMesh mesh, Face faceToMove, Edge edgeToAlignTo, Edge edgeToBeAligned, int channel) { }

	// RVA: 0x15E02D0
	internal static Vector2[] GetUVs(ProBuilderMesh mesh, int channel) { }

	// RVA: 0x15E08AC
	internal static void ApplyUVs(ProBuilderMesh mesh, Vector2[] uvs, int channel, bool applyToMesh) { }

	// RVA: 0x15E0C14
	public static void SewUVs(ProBuilderMesh mesh, int[] indexes, float delta) { }

	// RVA: 0x15E122C
	public static void CollapseUVs(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x15E053C
	public static void SplitUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x15E12F8
	internal static void SplitUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15E16E8
	internal static void ProjectFacesAuto(ProBuilderMesh mesh, Face[] faces, int channel) { }

	// RVA: 0x15E1AAC
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, int channel) { }

	// RVA: 0x15E21D0
	internal static Vector2 FindMinimalUV(Vector2[] uvs, int[] indices, float xMin, float yMin) { }

	// RVA: 0x15E2330
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, Vector2 lowerLeftAnchor, int channel) { }

	// RVA: 0x15E2A9C
	public static void ProjectFacesSphere(ProBuilderMesh pb, int[] indexes, int channel) { }

	// RVA: 0x15E2C28
	public static Vector2[] FitUVs(Vector2[] uvs) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class VertexEditing
{
	// Methods

	// RVA: 0x15E3080
	public static int MergeVertices(ProBuilderMesh mesh, int[] indexes, bool collapseToFirst) { }

	// RVA: 0x15E33E0
	public static void SplitVertices(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x15E346C
	public static void SplitVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x15E3870
	public static int[] WeldVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, float neighborRadius) { }

	// RVA: 0x15E4BB4
	internal static FaceRebuildData ExplodeVertex(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.WingedEdge,System.Int32>> edgeAndCommonIndex, float distance, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>>& appendedVertices) { }

	// RVA: 0x15E5B20
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
private struct __StaticArrayInitTypeSize=9865
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=24 00F6DEA1AEF89C31C3CD9B4F106BE9C4A57AB06704FBB4E465E49F5995E8325F; // 0x0
	internal static readonly __StaticArrayInitTypeSize=24 0A4F8EB7DD356436EE50F5460F2446D4D347703D265BF738112C63EF44D4D64C; // 0x18
	internal static readonly __StaticArrayInitTypeSize=5473 301D78C6901E0EC2B1F7B0EA205B98C9AEB422A97D3C1AA0DCAAEB0E308C8C51; // 0x30
	internal static readonly __StaticArrayInitTypeSize=96 52001E42B1D28A34563B51E0064A9E699E3880245FC794CD0DCD4F58D5D3CA83; // 0x1591
	internal static readonly __StaticArrayInitTypeSize=24 A55571C9DB30026E44AC0BDD7674D9C597D8254732FEB18418F3AAF8A5B4F418; // 0x15F1
	internal static readonly __StaticArrayInitTypeSize=24 A649149D1AE401596717C72AC8EBA8A7ABC0B52F782827AF6A40111A56D46F00; // 0x1609
	internal static readonly __StaticArrayInitTypeSize=12 CEC68AFEB3572A44829F6FC20DCF9C73A9DFCD19E604F8D9D4721656AF2CEB67; // 0x1621
	internal static readonly __StaticArrayInitTypeSize=240 DCBEA4AF8FCA3574A40E0078B6F6F21226FA3AA4D9B1062ACDF0409F822D7375; // 0x162D
	internal static readonly __StaticArrayInitTypeSize=24 EAB01B625D5C3788D47FF175375AB898118BCCAA359E7440C33488D029F10954; // 0x171D
	internal static readonly __StaticArrayInitTypeSize=9865 ED19A5E9A2382113F60A89E9A7CF85BA61F296C50CAB967F713107B78FEDCF4A; // 0x1735
}


