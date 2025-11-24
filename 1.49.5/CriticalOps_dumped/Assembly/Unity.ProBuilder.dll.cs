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

	// RVA: 0x14E0EDC
	private static MonoScriptData Get() { }

	// RVA: 0x14E0FE0
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

	// RVA: 0x14E0FE8
	public Status get_status() { }

	// RVA: 0x14E0FF0
	private void set_status(Status value) { }

	// RVA: 0x14E0FF8
	public string get_notification() { }

	// RVA: 0x14E1000
	private void set_notification(string value) { }

	// RVA: 0x14E1008
	public void .ctor(Status status, string notification) { }

	// RVA: 0x14E104C
	public static bool op_Implicit(ActionResult res) { }

	// RVA: 0x14E1060
	public bool ToBool() { }

	// RVA: 0x14E1070
	public static bool FromBool(bool success) { }

	// RVA: 0x14E1164
	public static ActionResult get_Success() { }

	// RVA: 0x14E11F0
	public static ActionResult get_NoSelection() { }

	// RVA: 0x14E1280
	public static ActionResult get_UserCanceled() { }

}

// Namespace: 
private struct SearchRange
{
	// Fields
	public int begin; // 0x10
	public int end; // 0x14

	// Methods

	// RVA: 0x14E1310
	public void .ctor(int begin, int end) { }

	// RVA: 0x14E1318
	public bool Valid() { }

	// RVA: 0x14E132C
	public int Center() { }

	// RVA: 0x14E1344
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

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal string <ToString>b__23_0(T x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0<T0, T1>
{
	// Fields
	public System.Collections.Generic.HashSet<TKey> knownKeys; // 0x0
	public System.Func<TSource,TKey> keySelector; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal bool <DistinctBy>b__0(TSource x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ArrayUtility
{
	// Methods

	// RVA: 0x30B58A8
	public static T[] ValuesWithIndexes(T[] arr, int[] indexes) { }

	// RVA: 0x30B58A8
	public static System.Collections.Generic.List<T> ValuesWithIndexes(System.Collections.Generic.List<T> arr, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x30B58A8
	public static System.Collections.Generic.IEnumerable<System.Int32> AllIndexesOf(System.Collections.Generic.IList<T> list, System.Func<T,System.Boolean> lambda) { }

	// RVA: 0x316B894
	public static T[] Add(T[] arr, T val) { }

	// RVA: 0x30B58A8
	public static T[] AddRange(T[] arr, T[] val) { }

	// RVA: 0x316B894
	public static T[] Remove(T[] arr, T val) { }

	// RVA: 0x30B58A8
	public static T[] Remove(T[] arr, System.Collections.Generic.IEnumerable<T> val) { }

	// RVA: -1
	public static T[] RemoveAt(T[] arr, int index) { }

	// RVA: 0x30B58A8
	public static T[] RemoveAt(System.Collections.Generic.IList<T> list, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x30B58A8
	public static T[] SortedRemoveAt(System.Collections.Generic.IList<T> list, System.Collections.Generic.IList<System.Int32> sorted) { }

	// RVA: 0x316B894
	public static int NearestIndexPriorToValue(System.Collections.Generic.IList<T> sorted_list, T value) { }

	// RVA: -1
	public static System.Collections.Generic.List<T> Fill(System.Func<System.Int32,T> ctor, int length) { }

	// RVA: 0x316B894
	public static T[] Fill(T val, int length) { }

	// RVA: 0x30B410C
	public static bool ContainsMatch(T[] a, T[] b) { }

	// RVA: -1
	public static bool ContainsMatch(T[] a, T[] b, int index_a, int index_b) { }

	// RVA: 0x30B58A8
	public static T[] Concat(T[] x, T[] y) { }

	// RVA: 0x316B894
	public static int IndexOf(System.Collections.Generic.List<System.Collections.Generic.List<T>> InList, T InValue) { }

	// RVA: -1
	public static T[] Fill(int count, System.Func<System.Int32,T> ctor) { }

	// RVA: 0x316B894
	public static void AddOrAppend(System.Collections.Generic.Dictionary<T,System.Collections.Generic.List<K>> dictionary, T key, K value) { }

	// RVA: 0x316B894
	public static void AddOrAppendRange(System.Collections.Generic.Dictionary<T,System.Collections.Generic.List<K>> dictionary, T key, System.Collections.Generic.List<K> value) { }

	// RVA: 0x30B58A8
	public static System.Collections.Generic.IEnumerable<TSource> DistinctBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector) { }

	// RVA: 0x30B57C8
	public static string ToString(System.Collections.Generic.Dictionary<TKey,TValue> dict) { }

	// RVA: 0x30B58A8
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

	// RVA: 0x14E14F0
	public static AutoUnwrapSettings get_defaultAutoUnwrapSettings() { }

	// RVA: 0x14E1520
	public bool get_useWorldSpace() { }

	// RVA: 0x14E1528
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x14E1530
	public bool get_flipU() { }

	// RVA: 0x14E1538
	public void set_flipU(bool value) { }

	// RVA: 0x14E1540
	public bool get_flipV() { }

	// RVA: 0x14E1548
	public void set_flipV(bool value) { }

	// RVA: 0x14E1550
	public bool get_swapUV() { }

	// RVA: 0x14E1558
	public void set_swapUV(bool value) { }

	// RVA: 0x14E1560
	public Fill get_fill() { }

	// RVA: 0x14E1568
	public void set_fill(Fill value) { }

	// RVA: 0x14E1570
	public Vector2 get_scale() { }

	// RVA: 0x14E1578
	public void set_scale(Vector2 value) { }

	// RVA: 0x14E1580
	public Vector2 get_offset() { }

	// RVA: 0x14E1588
	public void set_offset(Vector2 value) { }

	// RVA: 0x14E1590
	public float get_rotation() { }

	// RVA: 0x14E1598
	public void set_rotation(float value) { }

	// RVA: 0x14E15A0
	public Anchor get_anchor() { }

	// RVA: 0x14E15A8
	public void set_anchor(Anchor value) { }

	// RVA: 0x14E15B0
	public void .ctor(AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x14E160C
	public static AutoUnwrapSettings get_tile() { }

	// RVA: 0x14E1624
	public static AutoUnwrapSettings get_fit() { }

	// RVA: 0x14E163C
	public static AutoUnwrapSettings get_stretch() { }

	// RVA: 0x14E1508
	public void Reset() { }

	// RVA: 0x14E1654
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

	// RVA: 0x14E1AE8
	public void .ctor(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation) { }

	// RVA: 0x14E1B10
	public void EnforceTangentMode(BezierTangentDirection master, BezierTangentMode mode) { }

	// RVA: 0x14E1E20
	public void SetPosition(Vector3 position) { }

	// RVA: 0x14E1E70
	public void SetTangentIn(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x14E1E84
	public void SetTangentOut(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x14E1E98
	public static Vector3 QuadraticPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x14E1EF8
	public static Vector3 CubicPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x14E1F9C
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

	// RVA: 0x14E2978
	public bool get_isEditing() { }

	// RVA: 0x14E2980
	public void set_isEditing(bool value) { }

	// RVA: 0x14E2988
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x14E2A80
	public void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x14E2A88
	public void Init() { }

	// RVA: 0x14E2BF8
	public void Refresh() { }

	// RVA: 0x14E2CC8
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

	// RVA: 0x14E2D70
	public Vector2 get_size() { }

	// RVA: 0x14E2D78
	public void set_size(Vector2 value) { }

	// RVA: 0x14E2D90
	public Vector2 get_extents() { }

	// RVA: 0x14E2D98
	public Vector2[] get_corners() { }

	// RVA: 0x14E2E6C
	public void .ctor() { }

	// RVA: 0x14E2ED8
	public void .ctor(Vector2 center, Vector2 size) { }

	// RVA: 0x14E2F80
	public void .ctor(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x14E3314
	public void .ctor(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14E3930
	internal void .ctor(Vector3[] points, Edge[] edges) { }

	// RVA: 0x14E3A8C
	public void .ctor(Vector2[] points, int length) { }

	// RVA: 0x14E3B98
	public bool ContainsPoint(Vector2 point) { }

	// RVA: 0x14E3BE8
	public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x14E3E58
	public bool Intersects(Bounds2D bounds) { }

	// RVA: 0x14E3E98
	public bool Intersects(Rect rect) { }

	// RVA: 0x14E3004
	public void SetWithPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x14E33A0
	public void SetWithPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14E3ED4
	public static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x14E4190
	public static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14E4608
	public static Vector2 Size(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14E4A74
	internal static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector4> points, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x14E4F78
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

	// RVA: 0x14E5100
	private static void Init() { }

	// RVA: 0x14E5D94
	public static bool get_geometryShadersSupported() { }

	// RVA: 0x14E5DF4
	public static Material get_defaultMaterial() { }

	// RVA: 0x14E5E54
	internal static Shader get_selectionPickerShader() { }

	// RVA: 0x14E5EB4
	internal static Material get_facePickerMaterial() { }

	// RVA: 0x14E5F14
	internal static Material get_vertexPickerMaterial() { }

	// RVA: 0x14E5F74
	internal static Material get_edgePickerMaterial() { }

	// RVA: 0x14E5FD4
	internal static Material get_triggerMaterial() { }

	// RVA: 0x14E60E4
	internal static Material get_colliderMaterial() { }

	// RVA: 0x14E61F4
	internal static Material get_noDrawMaterial() { }

	// RVA: 0x14E6304
	internal static Material GetLegacyDiffuse() { }

	// RVA: 0x14E5A70
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x14E6634
	internal static Material get_unlitVertexColor() { }

	// RVA: 0x14E6694
	internal static Material get_ShapePreviewMaterial() { }

	// RVA: 0x14E66F4
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

	// RVA: 0x14E6844
	public SemVer get_versionInfo() { }

	// RVA: 0x14E684C
	public string get_releaseNotes() { }

	// RVA: 0x14E6854
	public void .ctor(SemVer version, string releaseNotes) { }

	// RVA: 0x14E68A4
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

	// RVA: 0x14E690C
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.ChangelogEntry> get_entries() { }

	// RVA: 0x14E698C
	public void .ctor(string log) { }

	// RVA: 0x14E6C34
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

	// RVA: 0x14E6DBC
	private static OutCode ComputeOutCode(Rect rect, float x, float y) { }

	// RVA: 0x14E6DF8
	internal static bool RectContainsLineSegment(Rect rect, float x0, float y0, float x1, float y1) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ColliderBehaviour
{
	// Methods

	// RVA: 0x14E6FF4
	public override void Initialize() { }

	// RVA: 0x14E7240
	public override void OnEnterPlayMode() { }

	// RVA: 0x14E7320
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x14E7400
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

	// RVA: 0x14E7420
	public Color get_current() { }

	// RVA: 0x14E742C
	public void set_current(Color value) { }

	// RVA: 0x14E7438
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Color> get_colors() { }

	// RVA: 0x14E74B8
	public void SetColors(System.Collections.Generic.IEnumerable<UnityEngine.Color> colors) { }

	// RVA: 0x14E756C
	public void SetDefaultValues() { }

	// RVA: 0x14E77D4
	public Color get_Item(int i) { }

	// RVA: 0x14E7850
	public void set_Item(int i, Color value) { }

	// RVA: 0x14E78EC
	public int get_Count() { }

	// RVA: 0x14E7938
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

	// RVA: 0x14E7940
	public void .ctor(float h, float s, float v) { }

	// RVA: 0x14E7988
	public void .ctor(float h, float s, float v, float sv_modifier) { }

	// RVA: 0x14E79DC
	public static HSVColor FromRGB(Color col) { }

	// RVA: 0x14E7C48
	public override string ToString() { }

	// RVA: 0x14E7D14
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

	// RVA: 0x14E7D60
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x14E7DA8
	public static XYZColor FromRGB(Color col) { }

	// RVA: 0x14E7EF0
	public static XYZColor FromRGB(float R, float G, float B) { }

	// RVA: 0x14E81A8
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

	// RVA: 0x14E8274
	public void .ctor(float L, float a, float b) { }

	// RVA: 0x14E82BC
	public static CIELabColor FromXYZ(XYZColor xyz) { }

	// RVA: 0x14E851C
	public static CIELabColor FromRGB(Color col) { }

	// RVA: 0x14E8654
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ColorUtility
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.ProBuilder.CIELabColor> ColorNameLookup; // 0x0

	// Methods

	// RVA: 0x14E8720
	private static bool approx(float lhs, float rhs) { }

	// RVA: 0x14E8788
	public static Color GetColor(Vector3 vec) { }

	// RVA: 0x14E7E78
	public static XYZColor RGBToXYZ(Color col) { }

	// RVA: 0x14E7F68
	public static XYZColor RGBToXYZ(float r, float g, float b) { }

	// RVA: 0x14E833C
	public static CIELabColor XYZToCIE_Lab(XYZColor xyz) { }

	// RVA: 0x14E8890
	public static float DeltaE(CIELabColor lhs, CIELabColor rhs) { }

	// RVA: 0x14E88D8
	public static Color HSVtoRGB(HSVColor hsv) { }

	// RVA: 0x14E8A84
	public static Color HSVtoRGB(float h, float s, float v) { }

	// RVA: 0x14E7A5C
	public static HSVColor RGBtoHSV(Color color) { }

	// RVA: 0x14E8B98
	public static string GetColorName(Color InColor) { }

	// RVA: 0x14E8F94
	private static CIELabColor CIELabFromRGB(float R, float G, float B, float Scale) { }

	// RVA: 0x14C3F94
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

	// RVA: 0x14E9064
	public void .ctor(int a, int b) { }

	// RVA: 0x14E906C
	public bool IsValid() { }

	// RVA: 0x14E9090
	public override string ToString() { }

	// RVA: 0x14E91EC
	public bool Equals(Edge other) { }

	// RVA: 0x14E9230
	public override bool Equals(object obj) { }

	// RVA: 0x14E9334
	public override int GetHashCode() { }

	// RVA: 0x14E9358
	public static Edge op_Addition(Edge a, Edge b) { }

	// RVA: 0x14E9370
	public static Edge op_Subtraction(Edge a, Edge b) { }

	// RVA: 0x14E9388
	public static Edge op_Addition(Edge a, int b) { }

	// RVA: 0x14E939C
	public static Edge op_Subtraction(Edge a, int b) { }

	// RVA: 0x14E93B0
	public static bool op_Equality(Edge a, Edge b) { }

	// RVA: 0x14E9468
	public static bool op_Inequality(Edge a, Edge b) { }

	// RVA: 0x14E9568
	public static Edge Add(Edge a, Edge b) { }

	// RVA: 0x14E95DC
	public static Edge Subtract(Edge a, Edge b) { }

	// RVA: 0x14E9650
	public bool Equals(Edge other, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x14E97E8
	public bool Contains(int index) { }

	// RVA: 0x14E980C
	public bool Contains(Edge other) { }

	// RVA: 0x14E9838
	internal bool Contains(int index, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x14E9920
	internal static void GetIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x14E9C7C
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_0
{
	// Fields
	public System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup; // 0x10

	// Methods

	// RVA: 0x14EA340
	public void .ctor() { }

	// RVA: 0x14EA6E0
	internal EdgeLookup <GetEdgeLookup>b__0(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder
public struct EdgeLookup
{
	// Fields
	private Edge m_Local; // 0x10
	private Edge m_Common; // 0x18

	// Methods

	// RVA: 0x14E9CCC
	public Edge get_local() { }

	// RVA: 0x14E9CD4
	public void set_local(Edge value) { }

	// RVA: 0x14E9CDC
	public Edge get_common() { }

	// RVA: 0x14E9CE4
	public void set_common(Edge value) { }

	// RVA: 0x14E9CEC
	public void .ctor(Edge common, Edge local) { }

	// RVA: 0x14E9CF4
	public void .ctor(int cx, int cy, int x, int y) { }

	// RVA: 0x14E9D0C
	public bool Equals(EdgeLookup other) { }

	// RVA: 0x14E9D94
	public override bool Equals(object obj) { }

	// RVA: 0x14E9EBC
	public override int GetHashCode() { }

	// RVA: 0x14E9F3C
	public static bool op_Equality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x14E9FD8
	public static bool op_Inequality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x14EA078
	public override string ToString() { }

	// RVA: 0x14EA258
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.EdgeLookup> GetEdgeLookup(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x14EA348
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> GetEdgeLookupHashSet(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x14EA870
	public void .ctor() { }

	// RVA: 0x14EB4F0
	internal Edge <GetSharedVertexHandleEdges>b__0(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class EdgeUtility
{
	// Methods

	// RVA: 0x14EA788
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetSharedVertexHandleEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x14EA878
	public static Edge GetSharedVertexHandleEdge(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x14EA930
	internal static Edge GetEdgeWithSharedVertexHandles(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x14EA9D0
	public static bool ValidateEdge(ProBuilderMesh mesh, Edge edge, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Edge>& validEdge) { }

	// RVA: 0x14EAED4
	internal static bool Contains(Edge[] edges, Edge edge) { }

	// RVA: 0x14EB030
	internal static bool Contains(Edge[] edges, int x, int y) { }

	// RVA: 0x14EB0CC
	internal static int IndexOf(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, Edge edge) { }

	// RVA: 0x14EB2B0
	internal static int[] AllTriangles(Edge[] edges) { }

	// RVA: 0x14EB370
	internal static Face GetFace(ProBuilderMesh mesh, Edge edge) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class Entity
{
	// Fields
	private EntityType m_EntityType; // 0x20

	// Methods

	// RVA: 0x14EB4F8
	public EntityType get_entityType() { }

	// RVA: 0x14EB500
	public void Awake() { }

	// RVA: 0x14EB5F0
	public void SetEntity(EntityType t) { }

	// RVA: 0x14EB5F8
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

	// RVA: 0x14E712C
	protected void SetMaterial(Material material) { }

	// RVA: 0x14E7410
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

	// RVA: 0x14EB600
	public bool get_manualUV() { }

	// RVA: 0x14EB608
	public void set_manualUV(bool value) { }

	// RVA: 0x14EB610
	public int get_textureGroup() { }

	// RVA: 0x14EB618
	public void set_textureGroup(int value) { }

	// RVA: 0x14EB620
	internal int[] get_indexesInternal() { }

	// RVA: 0x14EB628
	internal void set_indexesInternal(int[] value) { }

	// RVA: 0x14EB758
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_indexes() { }

	// RVA: 0x14EB7D8
	public void SetIndexes(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x14EAE38
	internal int[] get_distinctIndexesInternal() { }

	// RVA: 0x14EBA0C
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_distinctIndexes() { }

	// RVA: 0x14EB4DC
	internal Edge[] get_edgesInternal() { }

	// RVA: 0x14EBE28
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.Edge> get_edges() { }

	// RVA: 0x14EBEB8
	public int get_smoothingGroup() { }

	// RVA: 0x14EBEC0
	public void set_smoothingGroup(int value) { }

	// RVA: 0x14EBEC8
	public Material get_material() { }

	// RVA: 0x14EBED0
	public void set_material(Material value) { }

	// RVA: 0x14EBED8
	public int get_submeshIndex() { }

	// RVA: 0x14EBEE0
	public void set_submeshIndex(int value) { }

	// RVA: 0x14EBEE8
	public AutoUnwrapSettings get_uv() { }

	// RVA: 0x14EBEF8
	public void set_uv(AutoUnwrapSettings value) { }

	// RVA: 0x14EBF08
	public int get_Item(int i) { }

	// RVA: 0x14EBF3C
	public void .ctor() { }

	// RVA: 0x14EBF64
	public void .ctor(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x14EC06C
	internal void .ctor(int[] triangles, Material m, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x14EC124
	internal void .ctor(System.Collections.Generic.IEnumerable<System.Int32> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x14EC1CC
	public void .ctor(Face other) { }

	// RVA: 0x14EC1FC
	public void CopyFrom(Face other) { }

	// RVA: 0x14EB724
	internal void InvalidateCache() { }

	// RVA: 0x14EBB18
	private Edge[] CacheEdges() { }

	// RVA: 0x14EB920
	private int[] CacheDistinctIndexes() { }

	// RVA: 0x14EC35C
	public bool Contains(int a, int b, int c) { }

	// RVA: 0x14EC3FC
	public bool IsQuad() { }

	// RVA: 0x14EC450
	public int[] ToQuad() { }

	// RVA: 0x14EC840
	public override string ToString() { }

	// RVA: 0x14ECA2C
	public void ShiftIndexes(int offset) { }

	// RVA: 0x14ECAE4
	private int SmallestIndexValue() { }

	// RVA: 0x14ECB94
	public void ShiftIndexesToZero() { }

	// RVA: 0x14ECCD8
	public void Reverse() { }

	// RVA: 0x14ECD4C
	internal static void GetIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x14ED118
	internal static void GetDistinctIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x14ED5A4
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

	// RVA: 0x14ED7B8
	public int Offset() { }

	// RVA: 0x14ED7C0
	public override string ToString() { }

	// RVA: 0x14ED884
	public static void Apply(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.FaceRebuildData> newFaces, ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x14EDA00
	public static void Apply(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.FaceRebuildData> newFaces, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVertexLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedTextureLookup) { }

	// RVA: 0x14EDF98
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

	// RVA: 0x14EDFA0
	public void .ctor(int x, int y) { }

	// RVA: 0x14EDFD8
	public HandleConstraint2D Inverse() { }

	// RVA: 0x14EE058
	public Vector2 Mask(Vector2 v) { }

	// RVA: 0x14EE070
	public Vector2 InverseMask(Vector2 v) { }

	// RVA: 0x14EE094
	public static bool op_Equality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x14EE0DC
	public static bool op_Inequality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x14EE124
	public override int GetHashCode() { }

	// RVA: 0x14EE12C
	public override bool Equals(object o) { }

	// RVA: 0x14EE1C4
	public override string ToString() { }

	// RVA: 0x14EE320
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

	// RVA: 0x14EE394
	internal static Vector3 ScreenToGuiPoint(Camera camera, Vector3 point, float pixelsPerPoint) { }

	// RVA: 0x14EE3E8
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, RaycastHit hit, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x14EE428
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, RaycastHit hit, float distance, CullingMode cullingMode, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x14EEE54
	internal static bool FaceRaycastBothCullModes(Ray worldRay, ProBuilderMesh mesh, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.Vector3>& back, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.Vector3>& front) { }

	// RVA: 0x14EF770
	internal static bool FaceRaycast(Ray InWorldRay, ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.RaycastHit>& hits, CullingMode cullingMode, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x14EFF18
	internal static Ray InverseTransformRay(Transform transform, Ray InWorldRay) { }

	// RVA: 0x14F00EC
	internal static bool MeshRaycast(Ray InWorldRay, GameObject gameObject, RaycastHit hit, float distance) { }

	// RVA: 0x14F02A4
	internal static bool MeshRaycast(Ray InRay, Vector3[] mesh, int[] triangles, RaycastHit hit, float distance) { }

	// RVA: 0x14F0770
	internal static bool PointIsOccluded(Camera cam, ProBuilderMesh pb, Vector3 worldPoint) { }

	// RVA: 0x14F0A4C
	public static Quaternion GetRotation(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x14F1148
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x14F12B8
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x14F19B4
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x14F1B24
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x14F1C14
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x14F1D64
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x14F1EAC
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x14F25BC
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x14F26B4
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

	// RVA: 0x14F2D60
	public void .ctor() { }

	// RVA: 0x14F2D68
	internal bool <TryParseColor>b__0(Char c) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class InternalUtility
{
	// Methods

	// RVA: 0x30B57C8
	public static T[] GetComponents(GameObject go) { }

	// RVA: 0x30B57C8
	public static T[] GetComponents(System.Collections.Generic.IEnumerable<UnityEngine.Transform> transforms) { }

	// RVA: 0x14F2770
	public static GameObject EmptyGameObjectWithTransform(Transform t) { }

	// RVA: 0x14F2864
	public static GameObject MeshGameObjectWithTransform(string name, Transform t, Mesh mesh, Material mat, bool inheritParent) { }

	// RVA: 0x316B894
	public static T NextEnumValue(T current) { }

	// RVA: 0x14F298C
	public static string ControlKeyString(Char character) { }

	// RVA: 0x14F2AE0
	public static bool TryParseColor(string value, Color col) { }

	// RVA: 0x316B894
	public static T DemandComponent(Component component) { }

	// RVA: 0x316B894
	public static T DemandComponent(GameObject gameObject) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec2
{
	// Fields
	public Vector2 value; // 0x10

	// Methods

	// RVA: 0x14F2D88
	public float get_x() { }

	// RVA: 0x14F2D90
	public float get_y() { }

	// RVA: 0x14F2D98
	public void .ctor(Vector2 vector) { }

	// RVA: 0x14F2DA0
	public override string ToString() { }

	// RVA: 0x14F2E48
	public static bool op_Equality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x14F2FF8
	public static bool op_Inequality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x14F2E74
	public bool Equals(IntVec2 p) { }

	// RVA: 0x14F3094
	public bool Equals(Vector2 p) { }

	// RVA: 0x14F3218
	public override bool Equals(object b) { }

	// RVA: 0x14F3304
	public override int GetHashCode() { }

	// RVA: 0x14F3028
	private static int round(float v) { }

	// RVA: 0x14F3310
	public static Vector2 op_Implicit(IntVec2 p) { }

	// RVA: 0x14F3314
	public static IntVec2 op_Implicit(Vector2 p) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec3
{
	// Fields
	public Vector3 value; // 0x10

	// Methods

	// RVA: 0x14F3318
	public float get_x() { }

	// RVA: 0x14F3320
	public float get_y() { }

	// RVA: 0x14F3328
	public float get_z() { }

	// RVA: 0x14F3330
	public void .ctor(Vector3 vector) { }

	// RVA: 0x14F333C
	public override string ToString() { }

	// RVA: 0x14F3408
	public static bool op_Equality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x14F3654
	public static bool op_Inequality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x14F343C
	public bool Equals(IntVec3 p) { }

	// RVA: 0x14F36F8
	public bool Equals(Vector3 p) { }

	// RVA: 0x14F3910
	public override bool Equals(object b) { }

	// RVA: 0x14F3A04
	public override int GetHashCode() { }

	// RVA: 0x14F368C
	private static int round(float v) { }

	// RVA: 0x14F3A14
	public static Vector3 op_Implicit(IntVec3 p) { }

	// RVA: 0x14F3A18
	public static IntVec3 op_Implicit(Vector3 p) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec4
{
	// Fields
	public Vector4 value; // 0x10

	// Methods

	// RVA: 0x14F3A1C
	public float get_x() { }

	// RVA: 0x14F3A24
	public float get_y() { }

	// RVA: 0x14F3A2C
	public float get_z() { }

	// RVA: 0x14F3A34
	public float get_w() { }

	// RVA: 0x14F3A3C
	public void .ctor(Vector4 vector) { }

	// RVA: 0x14F3A48
	public override string ToString() { }

	// RVA: 0x14F3C28
	public static bool op_Equality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x14F3F00
	public static bool op_Inequality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x14F3C60
	public bool Equals(IntVec4 p) { }

	// RVA: 0x14F3FA8
	public bool Equals(Vector4 p) { }

	// RVA: 0x14F4248
	public override bool Equals(object b) { }

	// RVA: 0x14F433C
	public override int GetHashCode() { }

	// RVA: 0x14F3F3C
	private static int round(float v) { }

	// RVA: 0x14F434C
	public static Vector4 op_Implicit(IntVec4 p) { }

	// RVA: 0x14F4350
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

	// RVA: 0x14F4354
	public static void PushLogLevel(LogLevel level) { }

	// RVA: 0x14F4418
	public static void PopLogLevel() { }

	// RVA: 0x14F44CC
	public static void SetLogLevel(LogLevel level) { }

	// RVA: 0x14F4558
	public static void SetOutput(LogOutput output) { }

	// RVA: 0x14F45E4
	public static void SetLogFile(string path) { }

	// RVA: 0x316B894
	public static void Debug(T value) { }

	// RVA: 0x14F4650
	public static void Debug(string message) { }

	// RVA: 0x14F47F0
	public static void Debug(string format, object[] values) { }

	// RVA: 0x14F47F4
	public static void Info(string format, object[] values) { }

	// RVA: 0x14F4908
	public static void Info(string message) { }

	// RVA: 0x14F49C8
	public static void Warning(string format, object[] values) { }

	// RVA: 0x14F4ADC
	public static void Warning(string message) { }

	// RVA: 0x14F4B9C
	public static void Error(string format, object[] values) { }

	// RVA: 0x14E5CD4
	public static void Error(string message) { }

	// RVA: 0x316B894
	internal static void Watch(T key, K value) { }

	// RVA: 0x14F46D8
	private static void DoPrint(string message, LogType type) { }

	// RVA: 0x14F4DF4
	private static void PrintToFile(string message, string path) { }

	// RVA: 0x14F51F8
	public static void ClearLogFile() { }

	// RVA: 0x14F4CB0
	private static void PrintToConsole(string message, LogType type) { }

	// RVA: 0x316B894
	internal static void NotNull(T obj, string message) { }

	// RVA: 0x14F52C4
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class MaterialUtility
{
	// Fields
	internal static System.Collections.Generic.List<UnityEngine.Material> s_MaterialArray; // 0x0

	// Methods

	// RVA: 0x14F539C
	internal static int GetMaterialCount(Renderer renderer) { }

	// RVA: 0x14F54C4
	internal static Material GetSharedMaterial(Renderer renderer, int index) { }

	// RVA: 0x14F5680
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

	// RVA: 0x14F571C
	internal static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin) { }

	// RVA: 0x14F5770
	internal static Vector2 PointInEllipseCircumference(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, Vector2 tangent) { }

	// RVA: 0x14F58B0
	internal static Vector2 PointInEllipseCircumferenceWithConstantAngle(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, Vector2 tangent) { }

	// RVA: 0x14F5A34
	internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle) { }

	// RVA: 0x14F5AA0
	internal static float SignedAngle(Vector2 a, Vector2 b) { }

	// RVA: 0x14F5BBC
	public static float SqrDistance(Vector3 a, Vector3 b) { }

	// RVA: 0x14F5BE0
	public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z) { }

	// RVA: 0x14F5C94
	internal static float PolygonArea(Vector3[] vertices, int[] indexes) { }

	// RVA: 0x14F5F40
	internal static Vector2 RotateAroundPoint(Vector2 v, Vector2 origin, float theta) { }

	// RVA: 0x14F5FAC
	public static Vector2 ScaleAroundPoint(Vector2 v, Vector2 origin, Vector2 scale) { }

	// RVA: 0x14F5FC8
	internal static Vector2 Perpendicular(Vector2 value) { }

	// RVA: 0x14F5FD8
	public static Vector2 ReflectPoint(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x14F6184
	internal static float SqrDistanceRayPoint(Ray ray, Vector3 point) { }

	// RVA: 0x14F61D8
	public static float DistancePointLineSegment(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x14F63B4
	public static float DistancePointLineSegment(Vector3 point, Vector3 lineStart, Vector3 lineEnd) { }

	// RVA: 0x14F6660
	public static Vector3 GetNearestPointRayRay(Ray a, Ray b) { }

	// RVA: 0x14F66A8
	internal static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd) { }

	// RVA: 0x14F6814
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 intersect) { }

	// RVA: 0x14E3DE8
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

	// RVA: 0x14F692C
	internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, int[] indexes) { }

	// RVA: 0x14F6CE4
	internal static bool PointInPolygon(Vector2[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x14F6FAC
	internal static bool PointInPolygon(Vector3[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x14F7390
	internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b) { }

	// RVA: 0x14F7394
	internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b) { }

	// RVA: 0x14EEBB0
	public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, float OutDistance, Vector3 OutPoint) { }

	// RVA: 0x14F0530
	internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, float distance, Vector3 normal) { }

	// RVA: 0x14F73E8
	public static float Secant(float x) { }

	// RVA: 0x14F7404
	public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0x14F75E8
	internal static Vector3 Normal(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14F7E94
	public static Vector3 Normal(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x14F1558
	public static Normal NormalTangentBitangent(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x14F8120
	internal static bool IsCardinalAxis(Vector3 v, float epsilon) { }

	// RVA: 0x14F83C8
	internal static Vector2 DivideBy(Vector2 v, Vector2 o) { }

	// RVA: 0x14F83D4
	internal static Vector3 DivideBy(Vector3 v, Vector3 o) { }

	// RVA: 0x316B894
	internal static T Max(T[] array) { }

	// RVA: 0x316B894
	internal static T Min(T[] array) { }

	// RVA: 0x14F83E4
	internal static float LargestValue(Vector3 v) { }

	// RVA: 0x14F8400
	internal static float LargestValue(Vector2 v) { }

	// RVA: 0x14F840C
	internal static Vector2 SmallestVector2(Vector2[] v) { }

	// RVA: 0x14F845C
	internal static Vector2 SmallestVector2(Vector2[] v, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14F87B8
	internal static Vector2 LargestVector2(Vector2[] v) { }

	// RVA: 0x14F8808
	internal static Vector2 LargestVector2(Vector2[] v, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14F1FE4
	internal static Bounds GetBounds(Vector3[] positions, System.Collections.Generic.IList<System.Int32> indices) { }

	// RVA: 0x14F8B64
	public static Vector2 Average(System.Collections.Generic.IList<UnityEngine.Vector2> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14F8EEC
	public static Vector3 Average(System.Collections.Generic.IList<UnityEngine.Vector3> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14F94B4
	public static Vector4 Average(System.Collections.Generic.IList<UnityEngine.Vector4> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14F9A84
	internal static Vector3 InvertScaleVector(Vector3 scaleVector) { }

	// RVA: 0x14F9AB4
	internal static bool Approx2(Vector2 a, Vector2 b, float delta) { }

	// RVA: 0x14F9AD0
	internal static bool Approx3(Vector3 a, Vector3 b, float delta) { }

	// RVA: 0x14F9B00
	internal static bool Approx4(Vector4 a, Vector4 b, float delta) { }

	// RVA: 0x14F9B40
	internal static bool ApproxC(Color a, Color b, float delta) { }

	// RVA: 0x14F9B80
	internal static bool Approx(float a, float b, float delta) { }

	// RVA: 0x14F566C
	public static int Clamp(int value, int lowerBound, int upperBound) { }

	// RVA: 0x14F9B94
	internal static Vector3 Abs(Vector3 v) { }

	// RVA: 0x14F9BA4
	internal static Vector3 Sign(Vector3 v) { }

	// RVA: 0x14F9BC8
	internal static float Sum(Vector3 v) { }

	// RVA: 0x14F73B4
	internal static void Cross(Vector3 a, Vector3 b, Vector3 res) { }

	// RVA: 0x14F739C
	internal static void Subtract(Vector3 a, Vector3 b, Vector3 res) { }

	// RVA: 0x14F9BE0
	internal static bool IsNumber(float value) { }

	// RVA: 0x14F9BF4
	internal static bool IsNumber(Vector2 value) { }

	// RVA: 0x14F9C14
	internal static bool IsNumber(Vector3 value) { }

	// RVA: 0x14F9C40
	internal static bool IsNumber(Vector4 value) { }

	// RVA: 0x14F9C78
	internal static float MakeNonZero(float value, float min) { }

	// RVA: 0x14F9CA8
	internal static Vector4 FixNaN(Vector4 value) { }

	// RVA: 0x14F9CE4
	internal static Vector2 EnsureUnitVector(Vector2 value) { }

	// RVA: 0x14F9E48
	internal static Vector3 EnsureUnitVector(Vector3 value) { }

	// RVA: 0x14F9FC4
	internal static Vector4 EnsureUnitVector(Vector4 value) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class MeshHandle
{
	// Fields
	private Transform m_Transform; // 0x10
	private Mesh m_Mesh; // 0x18

	// Methods

	// RVA: 0x14FA020
	public Mesh get_mesh() { }

	// RVA: 0x14FA028
	public void .ctor(Transform transform, Mesh mesh) { }

	// RVA: 0x14FA078
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

	// RVA: 0x14FD190
	private static void .cctor() { }

	// RVA: 0x14FD1FC
	public void .ctor() { }

	// RVA: 0x14FD204
	internal System.Collections.Generic.IEnumerable<System.Int32> <CreateFaceMesh>b__9_0(Face x) { }

	// RVA: 0x14FD220
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

	// RVA: 0x14FA1D4
	internal static void CreateFaceMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x14FA348
	internal static void CreateFaceMeshFromFaces(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, Mesh target) { }

	// RVA: 0x14FA4B0
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x14FA86C
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target, Edge[] edges) { }

	// RVA: 0x14FAB18
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x14FAD1C
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x14FAE68
	private static void CreatePointMesh(Vector3[] positions, System.Collections.Generic.IList<System.Int32> indexes, Mesh target) { }

	// RVA: 0x14FB884
	internal static void CreatePointBillboardMesh(System.Collections.Generic.IList<UnityEngine.Vector3> positions, Mesh target) { }

	// RVA: 0x14FB020
	private static void CreatePointBillboardMesh(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Mesh target) { }

	// RVA: 0x14FBFE8
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x14FC66C
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target, System.Collections.Generic.ICollection<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x14FCFD0
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

	// RVA: 0x1501B7C
	private static void .cctor() { }

	// RVA: 0x1501BE8
	public void .ctor() { }

	// RVA: 0x1501BF0
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Vertex> <CollapseSharedVertices>b__11_0(System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Vertex,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder
public static class MeshUtility
{
	// Methods

	// RVA: 0x14FD23C
	internal static Vertex[] GeneratePerTriangleMesh(Mesh mesh) { }

	// RVA: 0x14FDCF4
	public static void GenerateTangent(Mesh mesh) { }

	// RVA: 0x14FE2B4
	public static Mesh DeepCopy(Mesh source) { }

	// RVA: 0x14FE324
	public static void CopyTo(Mesh source, Mesh destination) { }

	// RVA: 0x316B894
	internal static T GetMeshChannel(GameObject gameObject, System.Func<UnityEngine.Mesh,T> attributeGetter) { }

	// RVA: 0x30B9BBC
	private static void PrintAttribute(StringBuilder sb, string title, System.Collections.Generic.IEnumerable<T> attrib, string fmt) { }

	// RVA: 0x14FE7CC
	public static string Print(Mesh mesh) { }

	// RVA: 0x14FF3A8
	public static UInt32 GetIndexCount(Mesh mesh) { }

	// RVA: 0x14FF4A4
	public static UInt32 GetPrimitiveCount(Mesh mesh) { }

	// RVA: 0x14FF600
	public static void Compile(ProBuilderMesh probuilderMesh, Mesh targetMesh, MeshTopology preferredTopology) { }

	// RVA: 0x14FD6E4
	public static Vertex[] GetVertices(Mesh mesh) { }

	// RVA: 0x15002A4
	public static void CollapseSharedVertices(Mesh mesh, Vertex[] vertices) { }

	// RVA: 0x150090C
	public static void FitToSize(ProBuilderMesh mesh, Bounds currentSize, Vector3 sizeToFit) { }

	// RVA: 0x1500D00
	internal static string SanityCheck(ProBuilderMesh mesh) { }

	// RVA: 0x14FF394
	internal static string SanityCheck(Mesh mesh) { }

	// RVA: 0x15013F8
	internal static string SanityCheck(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x15016BC
	internal static bool IsUsedInParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x150188C
	internal static void RestoreParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x1501970
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

	// RVA: 0x1501C44
	public Vector3 get_normal() { }

	// RVA: 0x1501C50
	public void set_normal(Vector3 value) { }

	// RVA: 0x1501C5C
	public Vector4 get_tangent() { }

	// RVA: 0x1501C68
	public void set_tangent(Vector4 value) { }

	// RVA: 0x1501C74
	public Vector3 get_bitangent() { }

	// RVA: 0x1501C80
	public void set_bitangent(Vector3 value) { }

	// RVA: 0x1501C8C
	public override bool Equals(object obj) { }

	// RVA: 0x1501DD4
	public override int GetHashCode() { }

	// RVA: 0x1501D34
	public bool Equals(Normal other) { }

	// RVA: 0x1501E44
	public static bool op_Equality(Normal a, Normal b) { }

	// RVA: 0x1501E74
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

	// RVA: 0x1501F54
	private static void ClearIntArray(int count) { }

	// RVA: 0x1502078
	public static void CalculateTangents(ProBuilderMesh mesh) { }

	// RVA: 0x15026F0
	private static void CalculateHardNormals(ProBuilderMesh mesh) { }

	// RVA: 0x1502CF8
	public static void CalculateNormals(ProBuilderMesh mesh) { }

	// RVA: 0x15032FC
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

	// RVA: 0x316B894
	public void .ctor(int initialSize, int desiredSize, System.Func<T> constructor, System.Action<T> destructor, bool lazyInitialization) { }

	// RVA: 0x316B894
	public T Dequeue() { }

	// RVA: 0x316B894
	public void Enqueue(T obj) { }

	// RVA: 0x30B2870
	public void Empty() { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B28FC
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

	// RVA: 0x15033EC
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Vector3> get_controlPoints() { }

	// RVA: 0x150346C
	public void SetControlPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }

	// RVA: 0x15034D4
	public float get_extrude() { }

	// RVA: 0x15034DC
	public void set_extrude(float value) { }

	// RVA: 0x15034E4
	internal PolyEditMode get_polyEditMode() { }

	// RVA: 0x15034EC
	internal void set_polyEditMode(PolyEditMode value) { }

	// RVA: 0x15034F4
	public bool get_flipNormals() { }

	// RVA: 0x15034FC
	public void set_flipNormals(bool value) { }

	// RVA: 0x1503504
	internal ProBuilderMesh get_mesh() { }

	// RVA: 0x15035FC
	internal void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x1503604
	private bool IsSnapEnabled() { }

	// RVA: 0x150360C
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

	// RVA: 0x15036A0
	public void OnBeforeSerialize() { }

	// RVA: 0x1503A4C
	public void OnAfterDeserialize() { }

	// RVA: 0x1503E60
	public void SetDefaultValues() { }

	// RVA: 0x1503F68
	public bool HasKey(string key) { }

	// RVA: 0x30B183C
	public bool HasKey(string key) { }

	// RVA: 0x15040BC
	public void DeleteKey(string key) { }

	// RVA: 0x316B894
	public T Get(string key, T fallback) { }

	// RVA: 0x316B894
	public void Set(string key, T value) { }

	// RVA: 0x1504300
	public bool GetBool(string key, bool fallback) { }

	// RVA: 0x1504390
	public int GetInt(string key, int fallback) { }

	// RVA: 0x1504418
	public float GetFloat(string key, float fallback) { }

	// RVA: 0x15044A8
	public string GetString(string key, string fallback) { }

	// RVA: 0x1504530
	public Color GetColor(string key, Color fallback) { }

	// RVA: 0x15045E4
	public Material GetMaterial(string key, Material fallback) { }

	// RVA: 0x150466C
	public void SetBool(string key, bool value) { }

	// RVA: 0x15046E8
	public void SetInt(string key, int value) { }

	// RVA: 0x1504764
	public void SetFloat(string key, float value) { }

	// RVA: 0x15047E8
	public void SetString(string key, string value) { }

	// RVA: 0x1504854
	public void SetColor(string key, Color value) { }

	// RVA: 0x15048F0
	public void SetMaterial(string key, Material value) { }

	// RVA: 0x150495C
	public System.Collections.Generic.Dictionary<System.String,System.Boolean> GetBoolDictionary() { }

	// RVA: 0x1504964
	public System.Collections.Generic.Dictionary<System.String,System.Int32> GetIntDictionary() { }

	// RVA: 0x150496C
	public System.Collections.Generic.Dictionary<System.String,System.Single> GetFloatDictionary() { }

	// RVA: 0x1504974
	public System.Collections.Generic.Dictionary<System.String,System.String> GetStringDictionary() { }

	// RVA: 0x150497C
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.Color> GetColorDictionary() { }

	// RVA: 0x1504984
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> GetMaterialDictionary() { }

	// RVA: 0x150498C
	public void Clear() { }

	// RVA: 0x1504A70
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

	// RVA: 0x1504C90
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

	// RVA: 0x1508B94
	public void .ctor(ProBuilderMesh mesh) { }

	// RVA: 0x150ED7C
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

	// RVA: 0x150EDA0
	private static void .cctor() { }

	// RVA: 0x150EE0C
	public void .ctor() { }

	// RVA: 0x150EE14
	internal Vector2 <SetUVs>b__118_0(Vector4 x) { }

	// RVA: 0x150EE18
	internal Vector2 <SetUVs>b__118_1(Vector4 x) { }

	// RVA: 0x150EE1C
	internal int <get_indexCount>b__126_0(Face x) { }

	// RVA: 0x150EE40
	internal int <get_triangleCount>b__128_0(Face x) { }

	// RVA: 0x150EE64
	internal Face <CopyFrom>b__171_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass174_0
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x150B178
	public void .ctor() { }

	// RVA: 0x150EECC
	internal bool <GetUnusedTextureGroup>b__0(Face element) { }

}

// Namespace: 
private sealed class <>c__DisplayClass176_0
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x150B288
	public void .ctor() { }

	// RVA: 0x150EEF4
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

	// RVA: 0x1504CF8
	public bool get_userCollisions() { }

	// RVA: 0x1504D00
	public void set_userCollisions(bool value) { }

	// RVA: 0x1504D08
	public UnwrapParameters get_unwrapParameters() { }

	// RVA: 0x1504D10
	public void set_unwrapParameters(UnwrapParameters value) { }

	// RVA: 0x150180C
	internal MeshRenderer get_renderer() { }

	// RVA: 0x1504D18
	internal MeshFilter get_filter() { }

	// RVA: 0x1504E0C
	internal UInt16 get_versionIndex() { }

	// RVA: 0x1504E14
	internal UInt16 get_nonSerializedVersionIndex() { }

	// RVA: 0x1504E1C
	public bool get_preserveMeshAssetOnDestroy() { }

	// RVA: 0x1504E24
	public void set_preserveMeshAssetOnDestroy(bool value) { }

	// RVA: 0x14FF9F8
	public bool HasArrays(MeshArrays channels) { }

	// RVA: 0x1504E2C
	internal Face[] get_facesInternal() { }

	// RVA: 0x1504E34
	internal void set_facesInternal(Face[] value) { }

	// RVA: 0x1504E3C
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> get_faces() { }

	// RVA: 0x1504EBC
	public void set_faces(System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> value) { }

	// RVA: 0x1504F70
	internal void InvalidateSharedVertexLookup() { }

	// RVA: 0x1505034
	internal void InvalidateSharedTextureLookup() { }

	// RVA: 0x15050F8
	internal void InvalidateFaces() { }

	// RVA: 0x1505458
	internal void InvalidateCaches() { }

	// RVA: 0x1505490
	internal SharedVertex[] get_sharedVerticesInternal() { }

	// RVA: 0x1505498
	internal void set_sharedVerticesInternal(SharedVertex[] value) { }

	// RVA: 0x15054C0
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> get_sharedVertices() { }

	// RVA: 0x1505540
	public void set_sharedVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> value) { }

	// RVA: 0x1505770
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_sharedVertexLookup() { }

	// RVA: 0x1505844
	internal void SetSharedVertices(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> indexes) { }

	// RVA: 0x15058CC
	internal SharedVertex[] get_sharedTextures() { }

	// RVA: 0x15058D4
	internal void set_sharedTextures(SharedVertex[] value) { }

	// RVA: 0x15058FC
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_sharedTextureLookup() { }

	// RVA: 0x15059CC
	internal void SetSharedTextures(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> indexes) { }

	// RVA: 0x1505A54
	internal Vector3[] get_positionsInternal() { }

	// RVA: 0x1505A5C
	internal void set_positionsInternal(Vector3[] value) { }

	// RVA: 0x1505A64
	public System.Collections.Generic.IList<UnityEngine.Vector3> get_positions() { }

	// RVA: 0x1505AE4
	public void set_positions(System.Collections.Generic.IList<UnityEngine.Vector3> value) { }

	// RVA: 0x1500D20
	public Vertex[] GetVertices(System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1505B98
	internal void GetVerticesInList(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x15064D0
	public void SetVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, bool applyMesh) { }

	// RVA: 0x15069AC
	public System.Collections.Generic.IList<UnityEngine.Vector3> get_normals() { }

	// RVA: 0x1506A48
	internal Vector3[] get_normalsInternal() { }

	// RVA: 0x1506A50
	internal void set_normalsInternal(Vector3[] value) { }

	// RVA: 0x14FFF68
	public Vector3[] GetNormals() { }

	// RVA: 0x1506A58
	internal Color[] get_colorsInternal() { }

	// RVA: 0x1506A60
	internal void set_colorsInternal(Color[] value) { }

	// RVA: 0x1506A68
	public System.Collections.Generic.IList<UnityEngine.Color> get_colors() { }

	// RVA: 0x1506B04
	public void set_colors(System.Collections.Generic.IList<UnityEngine.Color> value) { }

	// RVA: 0x1506CE4
	public Color[] GetColors() { }

	// RVA: 0x1506E60
	public System.Collections.Generic.IList<UnityEngine.Vector4> get_tangents() { }

	// RVA: 0x1506F08
	public void set_tangents(System.Collections.Generic.IList<UnityEngine.Vector4> value) { }

	// RVA: 0x1507080
	internal Vector4[] get_tangentsInternal() { }

	// RVA: 0x1507088
	internal void set_tangentsInternal(Vector4[] value) { }

	// RVA: 0x15000F8
	public Vector4[] GetTangents() { }

	// RVA: 0x1507090
	internal Vector2[] get_texturesInternal() { }

	// RVA: 0x1507098
	internal void set_texturesInternal(Vector2[] value) { }

	// RVA: 0x15070A0
	internal System.Collections.Generic.List<UnityEngine.Vector4> get_textures2Internal() { }

	// RVA: 0x15070A8
	internal void set_textures2Internal(System.Collections.Generic.List<UnityEngine.Vector4> value) { }

	// RVA: 0x15070B0
	internal System.Collections.Generic.List<UnityEngine.Vector4> get_textures3Internal() { }

	// RVA: 0x15070B8
	internal void set_textures3Internal(System.Collections.Generic.List<UnityEngine.Vector4> value) { }

	// RVA: 0x15070C0
	public System.Collections.Generic.IList<UnityEngine.Vector2> get_textures() { }

	// RVA: 0x150715C
	public void set_textures(System.Collections.Generic.IList<UnityEngine.Vector2> value) { }

	// RVA: 0x14FFC60
	public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x15072C0
	internal System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Vector2> GetUVs(int channel) { }

	// RVA: 0x15073EC
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x15032E4
	public int get_faceCount() { }

	// RVA: 0x1500CBC
	public int get_vertexCount() { }

	// RVA: 0x1507720
	public int get_edgeCount() { }

	// RVA: 0x15077C4
	public int get_indexCount() { }

	// RVA: 0x1507900
	public int get_triangleCount() { }

	// RVA: 0x1507A58
	public static void add_meshWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x1507B68
	public static void remove_meshWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x1507C78
	internal static void add_meshWasInitialized(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x1507D8C
	internal static void remove_meshWasInitialized(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x1507EA0
	internal static void add_componentWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x1507FB4
	internal static void remove_componentWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x15080C8
	internal static void add_componentHasBeenReset(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x15081DC
	internal static void remove_componentHasBeenReset(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x15082F0
	public static void add_elementSelectionChanged(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x1508404
	public static void remove_elementSelectionChanged(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x1501A54
	internal Mesh get_mesh() { }

	// RVA: 0x1508518
	internal void set_mesh(Mesh value) { }

	// RVA: 0x1508520
	internal int get_id() { }

	// RVA: 0x1508544
	public MeshSyncState get_meshSyncState() { }

	// RVA: 0x150864C
	internal int get_meshFormatVersion() { }

	// RVA: 0x1508654
	private void Awake() { }

	// RVA: 0x1508BCC
	private void Reset() { }

	// RVA: 0x1508C9C
	private void OnDestroy() { }

	// RVA: 0x1508E94
	internal void DestroyUnityMesh() { }

	// RVA: 0x150698C
	private void IncrementVersionIndex() { }

	// RVA: 0x15067F8
	public void Clear() { }

	// RVA: 0x15087E4
	internal void EnsureMeshFilterIsAssigned() { }

	// RVA: 0x1508FDC
	internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions) { }

	// RVA: 0x1509348
	public static ProBuilderMesh Create() { }

	// RVA: 0x15093DC
	public static ProBuilderMesh Create(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> positions, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15095F8
	public static ProBuilderMesh Create(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedTextures, System.Collections.Generic.IList<UnityEngine.Material> materials) { }

	// RVA: 0x1509104
	internal void GeometryWithPoints(Vector3[] points) { }

	// RVA: 0x15094B8
	public void RebuildWithPositionsAndFaces(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> vertices, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1500CD4
	internal void Rebuild() { }

	// RVA: 0x15097F8
	public void ToMesh(MeshTopology preferredTopology) { }

	// RVA: 0x150A198
	private void FinalizeToMesh(bool usedInParticleSystem) { }

	// RVA: 0x150A1E4
	public void MakeUnique() { }

	// RVA: 0x150A3E4
	public void CopyFrom(ProBuilderMesh other) { }

	// RVA: 0x1509F5C
	public void Refresh(RefreshMask mask) { }

	// RVA: 0x15089B4
	internal void EnsureMeshColliderIsAssigned() { }

	// RVA: 0x150B07C
	internal int GetUnusedTextureGroup(int i) { }

	// RVA: 0x150B180
	private static bool IsValidTextureGroup(int group) { }

	// RVA: 0x150B18C
	internal int UnusedElementGroup(int i) { }

	// RVA: 0x150A8CC
	public void RefreshUV(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> facesToRefresh) { }

	// RVA: 0x150B290
	internal void SetGroupUV(AutoUnwrapSettings settings, int group) { }

	// RVA: 0x150AF08
	private void RefreshColors() { }

	// RVA: 0x150B374
	public void SetFaceColor(Face face, Color color) { }

	// RVA: 0x150B71C
	public void SetMaterial(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, Material material) { }

	// RVA: 0x150AF44
	private void RefreshNormals() { }

	// RVA: 0x150AFE0
	private void RefreshTangents() { }

	// RVA: 0x150BD8C
	internal int GetSharedVertexHandle(int vertex) { }

	// RVA: 0x150BEFC
	internal System.Collections.Generic.HashSet<System.Int32> GetSharedVertexHandles(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x150C280
	public System.Collections.Generic.List<System.Int32> GetCoincidentVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x150C8B0
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x150CEC8
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x150C358
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x150D590
	public void GetCoincidentVertices(int vertex, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x150D73C
	public void SetVerticesCoincident(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x150D7FC
	internal void SetTexturesCoincident(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x150D848
	internal void AddToSharedVertex(int sharedVertexHandle, int vertex) { }

	// RVA: 0x150D8E4
	internal void AddSharedVertex(SharedVertex vertex) { }

	// RVA: 0x150D9A8
	public bool get_selectable() { }

	// RVA: 0x150D9B0
	public void set_selectable(bool value) { }

	// RVA: 0x150D9B8
	public int get_selectedFaceCount() { }

	// RVA: 0x150D9D8
	public int get_selectedVertexCount() { }

	// RVA: 0x150D9F8
	public int get_selectedEdgeCount() { }

	// RVA: 0x150DA18
	internal int get_selectedSharedVerticesCount() { }

	// RVA: 0x150DDF4
	internal int get_selectedCoincidentVertexCount() { }

	// RVA: 0x150DE18
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedSharedVertices() { }

	// RVA: 0x150DE3C
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedCoincidentVertices() { }

	// RVA: 0x150DA3C
	private void CacheSelection() { }

	// RVA: 0x150DE60
	public Face[] GetSelectedFaces() { }

	// RVA: 0x150DF7C
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_selectedFaceIndexes() { }

	// RVA: 0x150DFFC
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_selectedVertices() { }

	// RVA: 0x150E07C
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.Edge> get_selectedEdges() { }

	// RVA: 0x150E0FC
	internal Face[] get_selectedFacesInternal() { }

	// RVA: 0x150E100
	internal void set_selectedFacesInternal(Face[] value) { }

	// RVA: 0x150E1DC
	internal int[] get_selectedFaceIndicesInternal() { }

	// RVA: 0x150E1E4
	internal void set_selectedFaceIndicesInternal(int[] value) { }

	// RVA: 0x150E1EC
	internal Edge[] get_selectedEdgesInternal() { }

	// RVA: 0x150E1F4
	internal void set_selectedEdgesInternal(Edge[] value) { }

	// RVA: 0x150E1FC
	internal int[] get_selectedIndexesInternal() { }

	// RVA: 0x150E204
	internal void set_selectedIndexesInternal(int[] value) { }

	// RVA: 0x150E20C
	internal Face GetActiveFace() { }

	// RVA: 0x150E26C
	internal Edge GetActiveEdge() { }

	// RVA: 0x150E310
	internal int GetActiveVertex() { }

	// RVA: 0x150E350
	internal void AddToFaceSelection(int index) { }

	// RVA: 0x150E624
	public void SetSelectedFaces(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> selected) { }

	// RVA: 0x150E3CC
	internal void SetSelectedFaces(System.Collections.Generic.IEnumerable<System.Int32> selected) { }

	// RVA: 0x150E6EC
	public void SetSelectedEdges(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x150E850
	public void SetSelectedVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x150E9E4
	internal void RemoveFromFaceSelectionAtIndex(int index) { }

	// RVA: 0x1508AD8
	public void ClearSelection() { }

	// RVA: 0x150EA4C
	public void .ctor() { }

	// RVA: 0x150EBB8
	private static void .cctor() { }

	// RVA: 0x150EC4C
	private int <set_selectedFacesInternal>b__231_0(Face x) { }

	// RVA: 0x150ECA8
	private int <SetSelectedFaces>b__245_0(Face x) { }

	// RVA: 0x150ED04
	private System.Collections.Generic.IEnumerable<System.Int32> <SetSelectedFaces>b__246_0(int x) { }

	// RVA: 0x150ED40
	private System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <SetSelectedFaces>b__246_1(int x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ProBuilderSnapping
{
	// Fields
	private const float k_MaxRaySnapDistance = inf;

	// Methods

	// RVA: 0x150EF1C
	internal static bool IsCardinalDirection(Vector3 direction) { }

	// RVA: 0x150F19C
	public static float Snap(float val, float snap) { }

	// RVA: 0x150F270
	public static Vector3 Snap(Vector3 val, Vector3 snap) { }

	// RVA: 0x150F4B0
	public static void SnapVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, Vector3 snap) { }

	// RVA: 0x150F858
	internal static Vector3 GetSnappingMaskBasedOnNormalVector(Vector3 normal) { }

	// RVA: 0x150F938
	internal static Vector3 SnapValueOnRay(Ray ray, float distance, float snap, Vector3Mask mask) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ProGridsNoSnapAttribute
{
	// Methods

	// RVA: 0x15100C0
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ProGridsConditionalSnapAttribute
{
	// Methods

	// RVA: 0x15100C8
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

	// RVA: 0x151327C
	private static void .cctor() { }

	// RVA: 0x15132E8
	public void .ctor() { }

	// RVA: 0x15132F0
	internal int <Sort>b__6_0(UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> a, UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> b) { }

	// RVA: 0x1513454
	internal Vector2 <Sort>b__6_1(UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> x) { }

}

// Namespace: UnityEngine.ProBuilder
public static class Projection
{
	// Methods

	// RVA: 0x15100D0
	public static Vector2[] PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1510A9C
	public static Vector2[] PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Vector3 direction) { }

	// RVA: 0x1510C64
	internal static void PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Vector3 direction, System.Collections.Generic.List<UnityEngine.Vector2> results) { }

	// RVA: 0x151161C
	internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1511CF8
	internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x15121F0
	internal static Vector2[] SphericalProject(System.Collections.Generic.IList<UnityEngine.Vector3> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1512654
	internal static System.Collections.Generic.IList<UnityEngine.Vector2> Sort(System.Collections.Generic.IList<UnityEngine.Vector2> verts, SortMethod method) { }

	// RVA: 0x1511548
	internal static Vector3 GetTangentToAxis(ProjectionAxis axis) { }

	// RVA: 0x1512B08
	internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis) { }

	// RVA: 0x15113F8
	internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction) { }

	// RVA: 0x15100FC
	public static Plane FindBestPlane(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1512D00
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

	// RVA: 0x1513524
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

	// RVA: 0x151359C
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<System.Int32>> PickVerticesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x1514CE4
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> PickFacesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x1516848
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Edge>> PickEdgesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x1517F50
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

	// RVA: 0x1517FFC
	public bool get_depthTest() { }

	// RVA: 0x1518004
	public void set_depthTest(bool value) { }

	// RVA: 0x151800C
	public RectSelectMode get_rectSelectMode() { }

	// RVA: 0x1518014
	public void set_rectSelectMode(RectSelectMode value) { }

	// RVA: 0x151801C
	public static PickerOptions get_Default() { }

	// RVA: 0x1518098
	public override bool Equals(object obj) { }

	// RVA: 0x15181C8
	public bool Equals(PickerOptions other) { }

	// RVA: 0x1518278
	public override int GetHashCode() { }

	// RVA: 0x1518350
	public static bool op_Equality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x1518480
	public static bool op_Inequality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x15185B0
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

	// RVA: 0x151AD8C
	public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

	// RVA: 0x151AD94
	public void .ctor() { }

}

// Namespace: 
internal class SelectionPickerRendererStandard
{
	// Methods

	// RVA: 0x151AD9C
	public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

	// RVA: 0x151B160
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

	// RVA: 0x151B168
	private static void .cctor() { }

	// RVA: 0x151B1D4
	public void .ctor() { }

	// RVA: 0x151B1DC
	internal System.Collections.Generic.IEnumerable<System.Int32> <GenerateFacePickingObjects>b__24_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass19_0
{
	// Fields
	public Vector3[] positions; // 0x10
	public SharedVertex[] sharedVertices; // 0x18

	// Methods

	// RVA: 0x151B1F8
	public void .ctor() { }

	// RVA: 0x151B200
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

	// RVA: 0x1518600
	private static RenderTextureFormat get_renderTextureFormat() { }

	// RVA: 0x1518788
	private static TextureFormat get_textureFormat() { }

	// RVA: 0x1518790
	private static ISelectionPickerRenderer get_pickerRenderer() { }

	// RVA: 0x1515EF8
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> PickFacesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x1513C60
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<System.Int32>> PickVerticesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x1517218
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x15188AC
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Face>>& map, int width, int height) { }

	// RVA: 0x1518B1C
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>>& map, int width, int height) { }

	// RVA: 0x1518E18
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>>& map, int width, int height) { }

	// RVA: 0x1519114
	private static GameObject[] GenerateFacePickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Face>>& map) { }

	// RVA: 0x15196E0
	private static void GenerateVertexPickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>>& map, GameObject[] depthObjects, GameObject[] pickerObjects) { }

	// RVA: 0x1519B70
	private static void GenerateEdgePickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>>& map, GameObject[] depthObjects, GameObject[] pickerObjects) { }

	// RVA: 0x151A014
	private static Mesh BuildVertexMesh(ProBuilderMesh pb, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>> map, UInt32 index) { }

	// RVA: 0x151A7E0
	private static Mesh BuildEdgeMesh(ProBuilderMesh pb, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>> map, UInt32 index) { }

	// RVA: 0x1518B08
	public static UInt32 DecodeRGBA(Color32 color) { }

	// RVA: 0x151A000
	public static Color32 EncodeRGBA(UInt32 hash) { }

	// RVA: 0x15188A4
	private static bool ShouldUseHDRP() { }

	// RVA: 0x151ACBC
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

	// RVA: 0x151B3F8
	public System.Collections.Generic.List<System.Int32> get_vertexes() { }

	// RVA: 0x151B400
	public void set_vertexes(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x151B408
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> get_edges() { }

	// RVA: 0x151B410
	public void set_edges(System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> value) { }

	// RVA: 0x151B418
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Face> get_faces() { }

	// RVA: 0x151B420
	public void set_faces(System.Collections.Generic.List<UnityEngine.ProBuilder.Face> value) { }

	// RVA: 0x151B428
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x151B578
	public void .ctor(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x151B7CC
	public void .ctor(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x151BA20
	public void .ctor(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x151B644
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> vertexes) { }

	// RVA: 0x151B898
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x151BADC
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x151BC64
	public void SetSingleFace(Face face) { }

	// RVA: 0x151BD30
	public void SetSingleVertex(int vertex) { }

	// RVA: 0x151BE0C
	public void SetSingleEdge(Edge edge) { }

	// RVA: 0x151BEE8
	public void Clear() { }

	// RVA: 0x151C07C
	public void CopyTo(SceneSelection dst) { }

	// RVA: 0x151C290
	public override string ToString() { }

	// RVA: 0x151C524
	public bool Equals(SceneSelection other) { }

	// RVA: 0x151C62C
	public override bool Equals(object obj) { }

	// RVA: 0x151C758
	public override int GetHashCode() { }

	// RVA: 0x151C910
	public static bool op_Equality(SceneSelection left, SceneSelection right) { }

	// RVA: 0x151C918
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

	// RVA: 0x151C934
	public static System.Collections.Generic.List<System.Int32> GetPath(ProBuilderMesh mesh, int start, int end) { }

	// RVA: 0x151CDA8
	private static int[] Dijkstra(ProBuilderMesh mesh, int start) { }

	// RVA: 0x151D558
	private static float GetWeight(int face1, int face2, ProBuilderMesh mesh) { }

	// RVA: 0x151CC68
	private static System.Collections.Generic.List<System.Int32> GetMinimalPath(int[] predecessors, int start, int end) { }

	// RVA: 0x151D9B0
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

	// RVA: 0x151DA44
	public int get_major() { }

	// RVA: 0x151DA4C
	public int get_minor() { }

	// RVA: 0x151DA54
	public int get_patch() { }

	// RVA: 0x151DA5C
	public int get_build() { }

	// RVA: 0x151DA64
	public string get_type() { }

	// RVA: 0x151DAC0
	public string get_metadata() { }

	// RVA: 0x151DB1C
	public string get_date() { }

	// RVA: 0x151DB78
	public SemVer get_MajorMinorPatch() { }

	// RVA: 0x151DCC4
	public void .ctor() { }

	// RVA: 0x151DD28
	public void .ctor(string formatted, string date) { }

	// RVA: 0x151DC30
	public void .ctor(int major, int minor, int patch, int build, string type, string date, string metadata) { }

	// RVA: 0x151E298
	public bool IsValid() { }

	// RVA: 0x151E2C8
	public override bool Equals(object o) { }

	// RVA: 0x151E598
	public override int GetHashCode() { }

	// RVA: 0x151E348
	public bool Equals(SemVer version) { }

	// RVA: 0x151E784
	public int CompareTo(object obj) { }

	// RVA: 0x151E9E0
	private static int WrapNoValue(int value) { }

	// RVA: 0x151E804
	public int CompareTo(SemVer version) { }

	// RVA: 0x151E9F0
	public static bool op_Equality(SemVer left, SemVer right) { }

	// RVA: 0x151EA04
	public static bool op_Inequality(SemVer left, SemVer right) { }

	// RVA: 0x151EA30
	public static bool op_LessThan(SemVer left, SemVer right) { }

	// RVA: 0x151EA58
	public static bool op_GreaterThan(SemVer left, SemVer right) { }

	// RVA: 0x151EA78
	public static bool op_LessThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x151EACC
	public static bool op_GreaterThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x151EB34
	public string ToString(string format) { }

	// RVA: 0x151ED18
	public override string ToString() { }

	// RVA: 0x151DE14
	public static bool TryGetVersionInfo(string input, SemVer version) { }

	// RVA: 0x151EF54
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

	// RVA: 0x151F060
	public static ProBuilderMesh Instantiate(Type shapeType, PivotLocation pivotType) { }

	// RVA: 0x151F334
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

	// RVA: 0x151F5A0
	public static ProBuilderMesh CreateShape(ShapeType shape, PivotLocation pivotType) { }

	// RVA: 0x151FF08
	public static ProBuilderMesh GenerateStair(PivotLocation pivotType, Vector3 size, int steps, bool buildSides) { }

	// RVA: 0x15209D0
	public static ProBuilderMesh GenerateCurvedStair(PivotLocation pivotType, float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides) { }

	// RVA: 0x1526918
	internal static ProBuilderMesh GenerateStair(PivotLocation pivotType, int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly) { }

	// RVA: 0x151FC10
	public static ProBuilderMesh GenerateCube(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x1521E50
	public static ProBuilderMesh GenerateCylinder(PivotLocation pivotType, int axisDivisions, float radius, float height, int heightCuts, int smoothing) { }

	// RVA: 0x1521864
	public static ProBuilderMesh GeneratePrism(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x1523190
	public static ProBuilderMesh GenerateDoor(PivotLocation pivotType, float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth) { }

	// RVA: 0x1522804
	public static ProBuilderMesh GeneratePlane(PivotLocation pivotType, float width, float height, int widthCuts, int heightCuts, Axis axis) { }

	// RVA: 0x1523D98
	public static ProBuilderMesh GeneratePipe(PivotLocation pivotType, float radius, float height, float thickness, int subdivAxis, int subdivHeight) { }

	// RVA: 0x1524608
	public static ProBuilderMesh GenerateCone(PivotLocation pivotType, float radius, float height, int subdivAxis) { }

	// RVA: 0x1524EC0
	public static ProBuilderMesh GenerateArch(PivotLocation pivotType, float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps) { }

	// RVA: 0x1525754
	public static ProBuilderMesh GenerateIcosahedron(PivotLocation pivotType, float radius, int subdivisions, bool weldVertices, bool manualUvs) { }

	// RVA: 0x1526F44
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x1527BD4
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x152629C
	public static ProBuilderMesh GenerateTorus(PivotLocation pivotType, int rows, int columns, float innerRadius, float outerRadius, bool smooth, float horizontalCircumference, float verticalCircumference, bool manualUvs) { }

	// RVA: 0x1527FB4
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

	// RVA: 0x152A008
	private static void .cctor() { }

	// RVA: 0x152A074
	public void .ctor() { }

	// RVA: 0x152A07C
	internal bool <SortedRemoveAndShift>b__26_0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class SharedVertex
{
	// Fields
	private int[] m_Vertices; // 0x10

	// Methods

	// RVA: 0x15282D4
	internal int[] get_arrayInternal() { }

	// RVA: 0x15274A4
	public void .ctor(System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x15282DC
	public void .ctor(SharedVertex sharedVertex) { }

	// RVA: 0x151B318
	public int get_Item(int i) { }

	// RVA: 0x15283E0
	public void set_Item(int i, int value) { }

	// RVA: 0x1528414
	public System.Collections.Generic.IEnumerator<System.Int32> GetEnumerator() { }

	// RVA: 0x15284C8
	public override string ToString() { }

	// RVA: 0x1528534
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15285E8
	public void Add(int item) { }

	// RVA: 0x1528664
	public void Clear() { }

	// RVA: 0x15286C8
	public bool Contains(int item) { }

	// RVA: 0x152873C
	public void CopyTo(int[] array, int arrayIndex) { }

	// RVA: 0x152875C
	public bool Remove(int item) { }

	// RVA: 0x15283C0
	public int get_Count() { }

	// RVA: 0x152880C
	public bool get_IsReadOnly() { }

	// RVA: 0x152882C
	public static void GetSharedVertexLookup(System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x1528CE8
	internal void ShiftIndexes(int offset) { }

	// RVA: 0x1528D78
	internal static SharedVertex[] ToSharedVertices(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> lookup) { }

	// RVA: 0x1529650
	private static SharedVertex[] ToSharedVertices(System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> list) { }

	// RVA: 0x1527564
	public static SharedVertex[] GetSharedVerticesWithPositions(System.Collections.Generic.IList<UnityEngine.Vector3> positions) { }

	// RVA: 0x15297C8
	internal static SharedVertex[] RemoveAndShift(System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup, System.Collections.Generic.IEnumerable<System.Int32> remove) { }

	// RVA: 0x152987C
	internal static SharedVertex[] SortedRemoveAndShift(System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup, System.Collections.Generic.List<System.Int32> remove) { }

	// RVA: 0x1529CEC
	internal static void SetCoincident(System.Collections.Generic.Dictionary<System.Int32,System.Int32>& lookup, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

}

// Namespace: UnityEngine.ProBuilder
public struct SimpleTuple<T0, T1>
{
	// Fields
	private T1 m_Item1; // 0x0
	private T2 m_Item2; // 0x0

	// Methods

	// RVA: 0x316B894
	public T1 get_item1() { }

	// RVA: 0x316B894
	public void set_item1(T1 value) { }

	// RVA: 0x316B894
	public T2 get_item2() { }

	// RVA: 0x316B894
	public void set_item2(T2 value) { }

	// RVA: 0x316B894
	public void .ctor(T1 item1, T2 item2) { }

	// RVA: 0x30B1CD4
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

	// RVA: 0x316B894
	public T1 get_item1() { }

	// RVA: 0x316B894
	public void set_item1(T1 value) { }

	// RVA: 0x316B894
	public T2 get_item2() { }

	// RVA: 0x316B894
	public void set_item2(T2 value) { }

	// RVA: 0x316B894
	public T3 get_item3() { }

	// RVA: 0x316B894
	public void set_item3(T3 value) { }

	// RVA: 0x316B894
	public void .ctor(T1 item1, T2 item2, T3 item3) { }

	// RVA: 0x30B1CD4
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

	// RVA: 0x152B6D4
	private static void .cctor() { }

	// RVA: 0x152B740
	public void .ctor() { }

	// RVA: 0x152B748
	internal int <GetUnusedSmoothingGroup>b__5_0(Face x) { }

	// RVA: 0x152B764
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

	// RVA: 0x152A150
	public static int GetUnusedSmoothingGroup(ProBuilderMesh mesh) { }

	// RVA: 0x152A3DC
	private static int GetNextUnusedSmoothingGroup(int start, System.Collections.Generic.HashSet<System.Int32> used) { }

	// RVA: 0x152A4A8
	public static bool IsSmooth(int index) { }

	// RVA: 0x152A4BC
	public static void ApplySmoothingGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float angleThreshold) { }

	// RVA: 0x152A4C4
	internal static void ApplySmoothingGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float angleThreshold, Vector3[] normals) { }

	// RVA: 0x152AF20
	private static bool FindSoftEdgesRecursive(Vector3[] normals, WingedEdge wing, float angleThreshold, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> processed) { }

	// RVA: 0x152B294
	private static bool IsSoftEdge(Vector3[] normals, EdgeLookup left, EdgeLookup right, float threshold) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class Spline
{
	// Methods

	// RVA: 0x152B780
	internal static ProBuilderMesh Extrude(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> points, float radius, int columns, int rows, bool closeLoop, bool smooth) { }

	// RVA: 0x152B860
	internal static void Extrude(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ProBuilderMesh target) { }

	// RVA: 0x152B938
	internal static System.Collections.Generic.List<UnityEngine.Vector3> GetControlPoints(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, System.Collections.Generic.List<UnityEngine.Quaternion> rotations) { }

	// RVA: 0x152BDFC
	internal static void Extrude(System.Collections.Generic.IList<UnityEngine.Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ProBuilderMesh target, System.Collections.Generic.IList<UnityEngine.Quaternion> pointRotations) { }

	// RVA: 0x152C880
	private static Quaternion GetRingRotation(System.Collections.Generic.IList<UnityEngine.Vector3> points, int i, bool closeLoop, float secant) { }

	// RVA: 0x152D164
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

	// RVA: 0x152D348
	public System.Collections.Generic.IEnumerable<System.Int32> get_indexes() { }

	// RVA: 0x152D3C8
	public void set_indexes(System.Collections.Generic.IEnumerable<System.Int32> value) { }

	// RVA: 0x152D430
	public MeshTopology get_topology() { }

	// RVA: 0x152D438
	public void set_topology(MeshTopology value) { }

	// RVA: 0x152D440
	public int get_submeshIndex() { }

	// RVA: 0x152D448
	public void set_submeshIndex(int value) { }

	// RVA: 0x152D450
	public void .ctor(int submeshIndex, MeshTopology topology, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x152D528
	public void .ctor(Mesh mesh, int subMeshIndex) { }

	// RVA: 0x152D664
	public override string ToString() { }

	// RVA: 0x152D778
	internal static int GetSubmeshCount(ProBuilderMesh mesh) { }

	// RVA: 0x152D7DC
	public static Submesh[] GetSubmeshes(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, int submeshCount, MeshTopology preferredTopology) { }

	// RVA: 0x152E268
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

	// RVA: 0x152E3C4
	public void .ctor(Vector2 position, float rotation, Vector2 scale) { }

	// RVA: 0x152E420
	public Vector2 TransformPoint(Vector2 p) { }

	// RVA: 0x152E490
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
public static class TransformUtility
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]> s_ChildStack; // 0x0

	// Methods

	// RVA: 0x152E644
	internal static void UnparentChildren(Transform t) { }

	// RVA: 0x152E7C4
	internal static void ReparentChildren(Transform t) { }

	// RVA: 0x152E914
	public static Vertex TransformVertex(Transform transform, Vertex vertex) { }

	// RVA: 0x152EB18
	public static Vertex InverseTransformVertex(Transform transform, Vertex vertex) { }

	// RVA: 0x152ED14
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

	// RVA: 0x152EDB0
	public int get_a() { }

	// RVA: 0x152EDB8
	public int get_b() { }

	// RVA: 0x152EDC0
	public int get_c() { }

	// RVA: 0x152EDC8
	public System.Collections.Generic.IEnumerable<System.Int32> get_indices() { }

	// RVA: 0x152EE5C
	public void .ctor(int a, int b, int c) { }

	// RVA: 0x152EE68
	public bool Equals(Triangle other) { }

	// RVA: 0x152EE9C
	public override bool Equals(object obj) { }

	// RVA: 0x152EF4C
	public override int GetHashCode() { }

	// RVA: 0x152EF6C
	public bool IsAdjacent(Triangle other) { }

	// RVA: 0x152F028
	private bool ContainsEdge(Edge edge) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class TriggerBehaviour
{
	// Methods

	// RVA: 0x152F180
	public override void Initialize() { }

	// RVA: 0x152F360
	public override void OnEnterPlayMode() { }

	// RVA: 0x152F3E4
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x152F468
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

	// RVA: 0x152F470
	public float get_hardAngle() { }

	// RVA: 0x152F478
	public void set_hardAngle(float value) { }

	// RVA: 0x152F480
	public float get_packMargin() { }

	// RVA: 0x152F488
	public void set_packMargin(float value) { }

	// RVA: 0x152F490
	public float get_angleError() { }

	// RVA: 0x152F498
	public void set_angleError(float value) { }

	// RVA: 0x152F4A0
	public float get_areaError() { }

	// RVA: 0x152F4A8
	public void set_areaError(float value) { }

	// RVA: 0x1526CD8
	public void .ctor() { }

	// RVA: 0x152F4C0
	public void .ctor(UnwrapParameters other) { }

	// RVA: 0x152F4B0
	public void Reset() { }

	// RVA: 0x152F548
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

	// RVA: 0x1531D58
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

	// RVA: 0x1531EC4
	private static void .cctor() { }

	// RVA: 0x1531F30
	public void .ctor() { }

	// RVA: 0x1531F38
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

	// RVA: 0x152F728
	internal static void SetAutoUV(ProBuilderMesh mesh, Face[] faces, bool auto) { }

	// RVA: 0x152F8CC
	internal static void SetAutoAndAlignUnwrapParamsToUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> facesToConvert) { }

	// RVA: 0x153013C
	internal static AutoUnwrapSettings GetAutoUnwrapSettings(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1530244
	internal static UVTransform GetUVTransform(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1530350
	private static int GetIndex(System.Collections.Generic.IList<System.Int32> collection, int index) { }

	// RVA: 0x152FAB0
	internal static UVTransform CalculateDelta(System.Collections.Generic.IList<UnityEngine.Vector2> src, System.Collections.Generic.IList<System.Int32> srcIndices, System.Collections.Generic.IList<UnityEngine.Vector2> dst, System.Collections.Generic.IList<System.Int32> dstIndices) { }

	// RVA: 0x1530410
	private static Vector2 GetRotatedSize(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indices, Vector2 center, float rotation) { }

	// RVA: 0x1526D1C
	internal static void Unwrap(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x1526E68
	internal static void CopyUVs(ProBuilderMesh mesh, Face source, Face dest) { }

	// RVA: 0x153127C
	internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1530858
	private static void ApplyUVSettings(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, AutoUnwrapSettings uvSettings) { }

	// RVA: 0x1531460
	private static void ScaleUVs(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, Vector2 scale, Bounds2D bounds) { }

	// RVA: 0x15316B8
	private static void ApplyUVAnchor(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, Anchor anchor) { }

	// RVA: 0x1531AF0
	internal static void UpgradeAutoUVScaleOffset(ProBuilderMesh mesh) { }

	// RVA: 0x1531C1C
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class VectorHash
{
	// Fields
	public const float FltCompareResolution = 1000;

	// Methods

	// RVA: 0x1531F54
	private static int HashFloat(float f) { }

	// RVA: 0x1531F94
	public static int GetHashCode(Vector2 v) { }

	// RVA: 0x151B34C
	public static int GetHashCode(Vector3 v) { }

	// RVA: 0x1532010
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

	// RVA: 0x15320F0
	public float get_x() { }

	// RVA: 0x1532108
	public float get_y() { }

	// RVA: 0x1532120
	public void .ctor(Vector3 v, float epsilon) { }

	// RVA: 0x1532144
	public void .ctor(Byte mask) { }

	// RVA: 0x153214C
	public static Vector2 op_Implicit(Vector2Mask mask) { }

	// RVA: 0x15321C0
	public static Vector2Mask op_Implicit(Vector2 v) { }

	// RVA: 0x15321E8
	public static Vector2Mask op_BitwiseOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x15321F0
	public static Vector2Mask op_BitwiseAnd(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x15321F8
	public static Vector2Mask op_ExclusiveOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x1532200
	public static Vector2 op_Multiply(Vector2Mask mask, float value) { }

	// RVA: 0x1532288
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

	// RVA: 0x15322D8
	public float get_x() { }

	// RVA: 0x15322F0
	public float get_y() { }

	// RVA: 0x1532308
	public float get_z() { }

	// RVA: 0x1532320
	public void .ctor(Vector3 v, float epsilon) { }

	// RVA: 0x1532354
	public void .ctor(Byte mask) { }

	// RVA: 0x153235C
	public override string ToString() { }

	// RVA: 0x1532474
	public int get_active() { }

	// RVA: 0x1532490
	public static Vector3 op_Implicit(Vector3Mask mask) { }

	// RVA: 0x153250C
	public static Vector3Mask op_Explicit(Vector3 v) { }

	// RVA: 0x1532544
	public static Vector3Mask op_BitwiseOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x153254C
	public static Vector3Mask op_BitwiseAnd(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1532554
	public static Vector3Mask op_ExclusiveOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x153255C
	public static Vector3 op_Multiply(Vector3Mask mask, float value) { }

	// RVA: 0x15325F0
	public static Vector3 op_Multiply(Vector3Mask mask, Vector3 value) { }

	// RVA: 0x1532694
	public static Vector3 op_Multiply(Quaternion rotation, Vector3Mask mask) { }

	// RVA: 0x15328AC
	public static bool op_Equality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x15328BC
	public static bool op_Inequality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1532928
	public float get_Item(int i) { }

	// RVA: 0x153298C
	public void set_Item(int i, float value) { }

	// RVA: 0x1532A04
	public bool Equals(Vector3Mask other) { }

	// RVA: 0x1532A14
	public override bool Equals(object obj) { }

	// RVA: 0x1532AE4
	public override int GetHashCode() { }

	// RVA: 0x1532AEC
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

	// RVA: 0x1532B3C
	public Vector3 get_position() { }

	// RVA: 0x1532B48
	public void set_position(Vector3 value) { }

	// RVA: 0x1532B74
	public Color get_color() { }

	// RVA: 0x1532B80
	public void set_color(Color value) { }

	// RVA: 0x1532BB8
	public Vector3 get_normal() { }

	// RVA: 0x1532BC4
	public void set_normal(Vector3 value) { }

	// RVA: 0x1532BFC
	public Vector4 get_tangent() { }

	// RVA: 0x1532C08
	public void set_tangent(Vector4 value) { }

	// RVA: 0x1532C40
	public Vector2 get_uv0() { }

	// RVA: 0x1532C48
	public void set_uv0(Vector2 value) { }

	// RVA: 0x1532C7C
	public Vector2 get_uv2() { }

	// RVA: 0x1532C84
	public void set_uv2(Vector2 value) { }

	// RVA: 0x1532CB8
	public Vector4 get_uv3() { }

	// RVA: 0x1532CC4
	public void set_uv3(Vector4 value) { }

	// RVA: 0x1532CFC
	public Vector4 get_uv4() { }

	// RVA: 0x1532D08
	public void set_uv4(Vector4 value) { }

	// RVA: 0x1532D40
	internal MeshArrays get_attributes() { }

	// RVA: 0x1532D48
	public bool HasArrays(MeshArrays attribute) { }

	// RVA: 0x1532D58
	private bool get_hasPosition() { }

	// RVA: 0x1532B60
	private void set_hasPosition(bool value) { }

	// RVA: 0x1532D64
	private bool get_hasColor() { }

	// RVA: 0x1532B98
	private void set_hasColor(bool value) { }

	// RVA: 0x1532D70
	private bool get_hasNormal() { }

	// RVA: 0x1532BDC
	private void set_hasNormal(bool value) { }

	// RVA: 0x1532D7C
	private bool get_hasTangent() { }

	// RVA: 0x1532C20
	private void set_hasTangent(bool value) { }

	// RVA: 0x1532D88
	private bool get_hasUV0() { }

	// RVA: 0x1532C5C
	private void set_hasUV0(bool value) { }

	// RVA: 0x1532D94
	private bool get_hasUV2() { }

	// RVA: 0x1532C98
	private void set_hasUV2(bool value) { }

	// RVA: 0x1532DA0
	private bool get_hasUV3() { }

	// RVA: 0x1532CDC
	private void set_hasUV3(bool value) { }

	// RVA: 0x1532DAC
	private bool get_hasUV4() { }

	// RVA: 0x1532D20
	private void set_hasUV4(bool value) { }

	// RVA: 0x1532DB8
	public void .ctor() { }

	// RVA: 0x1532DC0
	public override bool Equals(object obj) { }

	// RVA: 0x1532E40
	public bool Equals(Vertex other) { }

	// RVA: 0x1532F90
	public bool Equals(Vertex other, MeshArrays mask) { }

	// RVA: 0x1533144
	public override int GetHashCode() { }

	// RVA: 0x15331B4
	public void .ctor(Vertex vertex) { }

	// RVA: 0x15332F8
	public static bool op_Equality(Vertex a, Vertex b) { }

	// RVA: 0x1533320
	public static bool op_Inequality(Vertex a, Vertex b) { }

	// RVA: 0x153335C
	public static Vertex op_Addition(Vertex a, Vertex b) { }

	// RVA: 0x15333D8
	public static Vertex Add(Vertex a, Vertex b) { }

	// RVA: 0x1533454
	public void Add(Vertex b) { }

	// RVA: 0x1533554
	public static Vertex op_Subtraction(Vertex a, Vertex b) { }

	// RVA: 0x15335D0
	public static Vertex Subtract(Vertex a, Vertex b) { }

	// RVA: 0x153364C
	public void Subtract(Vertex b) { }

	// RVA: 0x153374C
	public static Vertex op_Multiply(Vertex a, float value) { }

	// RVA: 0x1533750
	public static Vertex Multiply(Vertex a, float value) { }

	// RVA: 0x153380C
	public void Multiply(float value) { }

	// RVA: 0x1533850
	public static Vertex op_Division(Vertex a, float value) { }

	// RVA: 0x1533854
	public static Vertex Divide(Vertex a, float value) { }

	// RVA: 0x1533910
	public void Divide(float value) { }

	// RVA: 0x1533954
	public void Normalize() { }

	// RVA: 0x1533F88
	public string ToString(string args) { }

	// RVA: 0x15342A4
	public static void GetArrays(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, Vector3[] position, Color[] color, Vector2[] uv0, Vector3[] normal, Vector4[] tangent, Vector2[] uv2, System.Collections.Generic.List<UnityEngine.Vector4>& uv3, System.Collections.Generic.List<UnityEngine.Vector4>& uv4) { }

	// RVA: 0x15342D0
	public static void GetArrays(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, Vector3[] position, Color[] color, Vector2[] uv0, Vector3[] normal, Vector4[] tangent, Vector2[] uv2, System.Collections.Generic.List<UnityEngine.Vector4>& uv3, System.Collections.Generic.List<UnityEngine.Vector4>& uv4, MeshArrays attributes) { }

	// RVA: 0x1534D18
	public static void SetMesh(Mesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x1535010
	public static Vertex Average(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1535D0C
	public static Vertex Mix(Vertex x, Vertex y, float weight) { }

}

// Namespace: UnityEngine.ProBuilder
public static class VertexPositioning
{
	// Fields
	private static System.Collections.Generic.List<System.Int32> s_CoincidentVertices; // 0x0

	// Methods

	// RVA: 0x153603C
	public static Vector3[] VerticesInWorldSpace(ProBuilderMesh mesh) { }

	// RVA: 0x1536218
	public static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset) { }

	// RVA: 0x1536350
	internal static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset, float snapValue, bool snapAxisOnly) { }

	// RVA: 0x1536920
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, Vector3 offset) { }

	// RVA: 0x1536C18
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Vector3 offset) { }

	// RVA: 0x1536D68
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, Vector3 offset) { }

	// RVA: 0x1536A70
	private static void TranslateVerticesInternal(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indices, Vector3 offset) { }

	// RVA: 0x1536EB8
	public static void SetSharedVertexPosition(ProBuilderMesh mesh, int sharedVertexHandle, Vector3 position) { }

	// RVA: 0x153726C
	internal static void SetSharedVertexValues(ProBuilderMesh mesh, int sharedVertexHandle, Vertex vertex) { }

	// RVA: 0x1537550
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

	// RVA: 0x1539874
	private static void .cctor() { }

	// RVA: 0x15398E0
	public void .ctor() { }

	// RVA: 0x15398E8
	internal Edge <SortCommonIndexesByAdjacency>b__32_1(WingedEdge y) { }

	// RVA: 0x1539904
	internal int <SortCommonIndexesByAdjacency>b__32_2(Edge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public System.Collections.Generic.HashSet<System.Int32> common; // 0x10

	// Methods

	// RVA: 0x1538D50
	public void .ctor() { }

	// RVA: 0x153990C
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

	// RVA: 0x15375EC
	public EdgeLookup get_edge() { }

	// RVA: 0x15375F8
	private void set_edge(EdgeLookup value) { }

	// RVA: 0x1537600
	public Face get_face() { }

	// RVA: 0x1537608
	private void set_face(Face value) { }

	// RVA: 0x1537610
	public WingedEdge get_next() { }

	// RVA: 0x1537618
	private void set_next(WingedEdge value) { }

	// RVA: 0x1537620
	public WingedEdge get_previous() { }

	// RVA: 0x1537628
	private void set_previous(WingedEdge value) { }

	// RVA: 0x1537630
	public WingedEdge get_opposite() { }

	// RVA: 0x1537638
	private void set_opposite(WingedEdge value) { }

	// RVA: 0x1537640
	private void .ctor() { }

	// RVA: 0x1537648
	public bool Equals(WingedEdge other) { }

	// RVA: 0x15376E8
	public override bool Equals(object obj) { }

	// RVA: 0x1537898
	public override int GetHashCode() { }

	// RVA: 0x1537910
	public int Count() { }

	// RVA: 0x1537948
	public override string ToString() { }

	// RVA: 0x1537B68
	internal static int[] MakeQuad(WingedEdge left, WingedEdge right) { }

	// RVA: 0x15382BC
	public WingedEdge GetAdjacentEdgeWithCommonIndex(int common) { }

	// RVA: 0x15383AC
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> SortEdgesByAdjacency(Face face) { }

	// RVA: 0x15384C8
	public static void SortEdgesByAdjacency(System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x153869C
	public static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge>> GetSpokes(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings) { }

	// RVA: 0x1538A1C
	internal static System.Collections.Generic.List<System.Int32> SortCommonIndexesByAdjacency(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, System.Collections.Generic.HashSet<System.Int32> common) { }

	// RVA: 0x1538D58
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetWingedEdges(ProBuilderMesh mesh, bool oneWingPerFace) { }

	// RVA: 0x1538E70
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetWingedEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool oneWingPerFace) { }

	// RVA: 0x15397D8
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
public sealed class WingedEdgeEnumerator
{
	// Fields
	private WingedEdge m_Start; // 0x10
	private WingedEdge m_Current; // 0x18

	// Methods

	// RVA: 0x15399A8
	public void .ctor(WingedEdge start) { }

	// RVA: 0x15399EC
	public bool MoveNext() { }

	// RVA: 0x1539A74
	public void Reset() { }

	// RVA: 0x1539A80
	public WingedEdge get_Current() { }

	// RVA: 0x1539A88
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1539A90
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

	// RVA: 0x1539A94
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1539B44
	private Vector3[] GetFace(Vector2 vertex1, Vector2 vertex2, float depth) { }

	// RVA: 0x1539C0C
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153A818
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

	// RVA: 0x153A848
	public override void CopyShape(Shape shape) { }

	// RVA: 0x153A8F0
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x153AA68
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153B654
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Cube
{
	// Fields
	private static readonly Vector3[] k_CubeVertices; // 0x0
	private static readonly int[] k_CubeTriangles; // 0x8

	// Methods

	// RVA: 0x153B66C
	public override void CopyShape(Shape shape) { }

	// RVA: 0x153B670
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153B894
	public void .ctor() { }

	// RVA: 0x153B89C
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

	// RVA: 0x153BA2C
	public override void CopyShape(Shape shape) { }

	// RVA: 0x153BB1C
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x153BB48
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153C6CC
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Door
{
	// Fields
	private float m_DoorHeight; // 0x10
	private float m_LegWidth; // 0x14

	// Methods

	// RVA: 0x153C6E4
	public override void CopyShape(Shape shape) { }

	// RVA: 0x153C7AC
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153D708
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

	// RVA: 0x153D71C
	public override void CopyShape(Shape shape) { }

	// RVA: 0x153D7C4
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x153D7F0
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153E38C
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Plane
{
	// Fields
	private int m_HeightSegments; // 0x10
	private int m_WidthSegments; // 0x14

	// Methods

	// RVA: 0x153E3A8
	public override void CopyShape(Shape shape) { }

	// RVA: 0x153E470
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153E768
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Prism
{
	// Methods

	// RVA: 0x153E778
	public override void CopyShape(Shape shape) { }

	// RVA: 0x153E77C
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153EEC0
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

	// RVA: 0x153EEC8
	public Shape get_shape() { }

	// RVA: 0x153EED0
	public void set_shape(Shape value) { }

	// RVA: 0x153EED8
	public PivotLocation get_pivotLocation() { }

	// RVA: 0x153EEE0
	public void set_pivotLocation(PivotLocation value) { }

	// RVA: 0x153EEE8
	public Vector3 get_pivotLocalPosition() { }

	// RVA: 0x153EEF4
	public void set_pivotLocalPosition(Vector3 value) { }

	// RVA: 0x153EF00
	public Vector3 get_pivotGlobalPosition() { }

	// RVA: 0x153F0C4
	public void set_pivotGlobalPosition(Vector3 value) { }

	// RVA: 0x153F130
	public Vector3 get_size() { }

	// RVA: 0x153F13C
	public void set_size(Vector3 value) { }

	// RVA: 0x153F248
	public Quaternion get_rotation() { }

	// RVA: 0x153F254
	public void set_rotation(Quaternion value) { }

	// RVA: 0x153F260
	public Bounds get_editionBounds() { }

	// RVA: 0x153F31C
	public Bounds get_shapeBox() { }

	// RVA: 0x153F330
	public bool get_isEditable() { }

	// RVA: 0x153EF40
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x153F364
	private void OnValidate() { }

	// RVA: 0x153F464
	internal void UpdateComponent() { }

	// RVA: 0x153F88C
	internal void UpdateBounds(Bounds bounds) { }

	// RVA: 0x153F9F8
	internal void Rebuild(Bounds bounds, Quaternion rotation, Vector3 cornerPivot) { }

	// RVA: 0x153F6D4
	private void Rebuild() { }

	// RVA: 0x153FE10
	internal void SetShape(Shape shape, PivotLocation location) { }

	// RVA: 0x153FFA0
	internal void RotateInsideBounds(Quaternion deltaRotation) { }

	// RVA: 0x153F4A4
	private void ResetPivot(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x153FBC0
	internal void RebuildPivot(Vector3 size, Quaternion rotation) { }

	// RVA: 0x1540080
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
[Serializable]
public abstract class Shape
{
	// Methods

	// RVA: 0x1540170
	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: -1
	public abstract Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: -1
	public abstract void CopyShape(Shape shape) { }

	// RVA: 0x153A840
	protected void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class ShapeAttribute
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x15401C8
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

	// RVA: 0x15401FC
	public override void CopyShape(Shape shape) { }

	// RVA: 0x154029C
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x1540300
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1540D14
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x1541274
	public void .ctor() { }

	// RVA: 0x154128C
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Sprite
{
	// Methods

	// RVA: 0x1541490
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1541494
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x154184C
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

	// RVA: 0x1541854
	public bool get_sides() { }

	// RVA: 0x154185C
	public void set_sides(bool value) { }

	// RVA: 0x1541864
	public override void CopyShape(Shape shape) { }

	// RVA: 0x154192C
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1543A34
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x1542A78
	private Bounds BuildStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1541984
	private Bounds BuildCurvedStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1543B94
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

	// RVA: 0x1543BC0
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1543C68
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x1543CEC
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15446E4
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x1544A1C
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x1544C90
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

	// RVA: 0x1550194
	private static void .cctor() { }

	// RVA: 0x1550200
	public void .ctor() { }

	// RVA: 0x1550208
	internal int <CreateShapeFromPolygon>b__8_0(Vector3[] arr) { }

	// RVA: 0x1550224
	internal Vector3 <FaceWithVerticesAndHole>b__10_0(Vertex v) { }

	// RVA: 0x1550244
	internal Vector3 <FaceWithVerticesAndHole>b__10_1(Vertex v) { }

	// RVA: 0x1550264
	internal Face <InsertVertexInFace>b__18_0(FaceRebuildData f) { }

}

// Namespace: 
private sealed class <>c__DisplayClass17_0
{
	// Fields
	public int delCount; // 0x10

	// Methods

	// RVA: 0x154D72C
	public void .ctor() { }

	// RVA: 0x1550280
	internal Edge <AppendVerticesToEdge>b__0(EdgeLookup x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class AppendElements
{
	// Methods

	// RVA: 0x1545144
	internal static Face AppendFace(ProBuilderMesh mesh, Vector3[] positions, Color[] colors, Vector2[] uv0s, Vector4[] uv2s, Vector4[] uv3s, Face face, int[] common) { }

	// RVA: 0x15459EC
	public static Face[] AppendFaces(ProBuilderMesh mesh, Vector3[][] positions, Color[][] colors, Vector2[][] uvs, Face[] faces, Int32[][] shared) { }

	// RVA: 0x1546020
	public static Face CreatePolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes, bool unordered) { }

	// RVA: 0x1546808
	public static Face CreatePolygonWithHole(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes, System.Collections.Generic.IList<System.Collections.Generic.IList<System.Int32>> holes) { }

	// RVA: 0x15478F4
	public static ActionResult CreateShapeFromPolygon(PolyShape poly) { }

	// RVA: 0x1547938
	internal static void ClearAndRefreshMesh(ProBuilderMesh mesh) { }

	// RVA: 0x1547930
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals) { }

	// RVA: 0x1548700
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals, Vector3 cameraLookAt, System.Collections.Generic.IList<System.Collections.Generic.IList<UnityEngine.Vector3>> holePoints) { }

	// RVA: 0x1547980
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals, System.Collections.Generic.IList<System.Collections.Generic.IList<UnityEngine.Vector3>> holePoints) { }

	// RVA: 0x154671C
	internal static FaceRebuildData FaceWithVertices(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, bool unordered) { }

	// RVA: 0x15473B4
	internal static FaceRebuildData FaceWithVerticesAndHole(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> borderVertices, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>> holes) { }

	// RVA: 0x1548D8C
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> TentCapWithVertices(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> path) { }

	// RVA: 0x1548708
	public static void DuplicateAndFlip(ProBuilderMesh mesh, Face[] faces) { }

	// RVA: 0x1549028
	public static Face Bridge(ProBuilderMesh mesh, Edge a, Edge b, bool allowNonManifoldGeometry) { }

	// RVA: 0x154A774
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points) { }

	// RVA: 0x154A77C
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points, bool insertOnEdge) { }

	// RVA: 0x154B634
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> AppendVerticesToEdge(ProBuilderMesh mesh, Edge edge, int count) { }

	// RVA: 0x154B6C0
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> AppendVerticesToEdge(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, int count) { }

	// RVA: 0x154DC04
	public static Face[] InsertVertexInFace(ProBuilderMesh mesh, Face face, Vector3 point) { }

	// RVA: 0x154E8F8
	public static Vertex InsertVertexOnEdge(ProBuilderMesh mesh, Edge originalEdge, Vector3 point) { }

	// RVA: 0x154FDD4
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

	// RVA: 0x1554290
	private static void .cctor() { }

	// RVA: 0x15542FC
	public void .ctor() { }

	// RVA: 0x1554304
	internal Face <BevelEdges>b__0_0(FaceRebuildData x) { }

	// RVA: 0x1554320
	internal int <BevelEdges>b__0_6(UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.FaceRebuildData,System.Collections.Generic.List<System.Int32>> x) { }

	// RVA: 0x1554404
	internal Face <BevelEdges>b__0_1(FaceRebuildData x) { }

	// RVA: 0x1554420
	internal Face <BevelEdges>b__0_2(FaceRebuildData x) { }

	// RVA: 0x155443C
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

	// RVA: 0x1553500
	public void .ctor() { }

	// RVA: 0x1554458
	internal int <BevelEdges>b__7(int x) { }

	// RVA: 0x1554498
	internal int <BevelEdges>b__8(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_1
{
	// Fields
	public EdgeLookup lup; // 0x10

	// Methods

	// RVA: 0x1553508
	public void .ctor() { }

	// RVA: 0x15544D8
	internal bool <BevelEdges>b__4(WingedEdge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_2
{
	// Fields
	public int c; // 0x10
	public UnityEngine.ProBuilder.MeshOperations.Bevel.<>c__DisplayClass0_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x1553FBC
	public void .ctor() { }

	// RVA: 0x1554510
	internal bool <BevelEdges>b__5(WingedEdge x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class Bevel
{
	// Fields
	private static readonly int[] k_BridgeIndexesTri; // 0x0

	// Methods

	// RVA: 0x15502F0
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> BevelEdges(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, float amount) { }

	// RVA: 0x155393C
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> GetBridgeFaces(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, WingedEdge left, WingedEdge right, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.FaceRebuildData,System.Collections.Generic.List<System.Int32>>>> holes) { }

	// RVA: 0x1553510
	private static void SlideEdge(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, WingedEdge we, float amount) { }

	// RVA: 0x15540E4
	private static Edge GetLeadingEdge(WingedEdge wing, int common) { }

	// RVA: 0x15541EC
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

	// RVA: 0x155774C
	private static void .cctor() { }

	// RVA: 0x15577B8
	public void .ctor() { }

	// RVA: 0x15577C0
	internal int <SplitByMaxVertexCount>b__5_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class CombineMeshes
{
	// Methods

	// RVA: 0x155467C
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> Combine(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes) { }

	// RVA: 0x1554C58
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> Combine(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes, ProBuilderMesh meshTarget) { }

	// RVA: 0x1554680
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> CombineToNewMeshes(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes) { }

	// RVA: 0x15556D0
	private static void AccumulateMeshesInfo(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes, int offset, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>& vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face>& faces, System.Collections.Generic.List<UnityEngine.ProBuilder.Face>& autoUvFaces, System.Collections.Generic.List<UnityEngine.ProBuilder.SharedVertex>& sharedVertices, System.Collections.Generic.List<UnityEngine.ProBuilder.SharedVertex>& sharedTextures, System.Collections.Generic.List<UnityEngine.Material>& materialMap, Transform targetTransform) { }

	// RVA: 0x1556E1C
	private static ProBuilderMesh CreateMeshFromSplit(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVertexLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedTextureLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> remap, Material[] materials) { }

	// RVA: 0x15561F8
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> SplitByMaxVertexCount(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedTextures, UInt32 maxVertexCount) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal sealed class ConnectFaceRebuildData
{
	// Fields
	public FaceRebuildData faceRebuildData; // 0x10
	public System.Collections.Generic.List<System.Int32> newVertexIndexes; // 0x18

	// Methods

	// RVA: 0x15577DC
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

	// RVA: 0x155D808
	private static void .cctor() { }

	// RVA: 0x155D874
	public void .ctor() { }

	// RVA: 0x155D87C
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <Connect>b__0_0(Face x) { }

	// RVA: 0x155D898
	internal int <Connect>b__2_1(Face x) { }

	// RVA: 0x155D8B4
	internal FaceRebuildData <Connect>b__2_2(ConnectFaceRebuildData x) { }

	// RVA: 0x155D8D0
	internal int <Connect>b__3_0(Face x) { }

	// RVA: 0x155D8EC
	internal FaceRebuildData <Connect>b__3_1(ConnectFaceRebuildData x) { }

	// RVA: 0x155D908
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <Connect>b__3_2(ConnectFaceRebuildData x) { }

	// RVA: 0x155D934
	internal Edge <Connect>b__3_4(EdgeLookup x) { }

	// RVA: 0x155D93C
	internal System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> <ConnectEdgesInFace>b__5_0(int x) { }

	// RVA: 0x155D9B0
	internal System.Collections.Generic.List<System.Int32> <ConnectEdgesInFace>b__5_1(int x) { }

	// RVA: 0x155DA24
	internal Edge <ConnectEdgesInFace>b__5_2(WingedEdge x) { }

	// RVA: 0x155DA40
	internal Edge <InsertVertices>b__6_0(WingedEdge x) { }

	// RVA: 0x155DA5C
	internal System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> <ConnectIndexesPerFace>b__8_0(int x) { }

	// RVA: 0x155DAD0
	internal System.Collections.Generic.List<System.Int32> <ConnectIndexesPerFace>b__8_1(int x) { }

	// RVA: 0x155DB44
	internal System.Collections.Generic.List<System.Int32> <ConnectIndexesPerFace>b__8_2(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup; // 0x10
	public ProBuilderMesh mesh; // 0x18

	// Methods

	// RVA: 0x155AC88
	public void .ctor() { }

	// RVA: 0x155DBB8
	internal int <Connect>b__0(int x) { }

	// RVA: 0x155DC34
	internal int <Connect>b__3(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public System.Collections.Generic.HashSet<System.Int32> appended; // 0x10

	// Methods

	// RVA: 0x155D800
	public void .ctor() { }

	// RVA: 0x155DC7C
	internal bool <Connect>b__3(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ConnectElements
{
	// Methods

	// RVA: 0x155782C
	public static Face[] Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15597FC
	public static UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face[],UnityEngine.ProBuilder.Edge[]> Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1559890
	public static int[] Connect(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1557C10
	internal static ActionResult Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Face[] addedFaces, Edge[] connections, bool returnFaces, bool returnEdges, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> faceMask) { }

	// RVA: 0x155CFD8
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectEdgesInFace(Face face, WingedEdge a, WingedEdge b, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x155C570
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectEdgesInFace(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> edges, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x155BF18
	private static bool InsertVertices(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> edges, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, ConnectFaceRebuildData data) { }

	// RVA: 0x155B740
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, int a, int b, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x155AC90
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

	// RVA: 0x155E530
	private static void .cctor() { }

	// RVA: 0x155E59C
	public void .ctor() { }

	// RVA: 0x155E5A4
	internal System.Collections.Generic.IEnumerable<System.Int32> <DeleteFaces>b__3_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public System.Collections.Generic.List<System.Int32> sorted; // 0x10
	public int[] offset; // 0x18

	// Methods

	// RVA: 0x155DD10
	public void .ctor() { }

	// RVA: 0x155E5C0
	internal bool <DeleteVertices>b__0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

	// RVA: 0x155E6CC
	internal System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> <DeleteVertices>b__1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

	// RVA: 0x155E914
	internal bool <DeleteVertices>b__2(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

	// RVA: 0x155EA20
	internal System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> <DeleteVertices>b__3(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x155DD18
	public void .ctor() { }

	// RVA: 0x155EC68
	internal int <DeleteFaces>b__0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class DeleteElements
{
	// Methods

	// RVA: 0x154D734
	public static void DeleteVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> distinctIndexes) { }

	// RVA: 0x154B5A8
	public static int[] DeleteFace(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1553FC4
	public static int[] DeleteFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x155DD20
	public static int[] DeleteFaces(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> faceIndexes) { }

	// RVA: 0x155E3E0
	public static int[] RemoveDegenerateTriangles(ProBuilderMesh mesh) { }

	// RVA: 0x155E488
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

	// RVA: 0x15653F0
	private static void .cctor() { }

	// RVA: 0x156545C
	public void .ctor() { }

	// RVA: 0x1565464
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <GetPerimeterEdges>b__5_0(Face x) { }

	// RVA: 0x1565480
	internal bool <GetPerimeterEdges>b__5_1(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> x) { }

	// RVA: 0x156556C
	internal Edge <GetPerimeterEdges>b__5_2(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> x) { }

	// RVA: 0x1565668
	internal bool <GetPerimeterFaces>b__7_0(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>> x) { }

	// RVA: 0x1565754
	internal Face <GetPerimeterFaces>b__7_1(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>> x) { }

	// RVA: 0x1565850
	internal Edge <GetEdgeRing>b__10_0(EdgeLookup x) { }

	// RVA: 0x1565858
	internal Edge <GetEdgeRingIterative>b__11_0(EdgeLookup x) { }

	// RVA: 0x1565860
	internal Edge <GetEdgeLoop>b__12_0(EdgeLookup x) { }

	// RVA: 0x1565868
	internal Edge <GetEdgeLoopIterative>b__13_0(EdgeLookup x) { }

	// RVA: 0x1565870
	internal Edge <GetEdgeLoopInternal>b__14_0(WingedEdge x) { }

	// RVA: 0x156588C
	internal Edge <GetEdgeLoopInternalIterative>b__15_0(WingedEdge x) { }

	// RVA: 0x15658A8
	internal Edge <GetEdgeLoopInternalIterative>b__15_1(WingedEdge x) { }

	// RVA: 0x15658C4
	internal Edge <FindHoles>b__26_0(WingedEdge x) { }

	// RVA: 0x15658E0
	internal int <FindHoles>b__27_0(UnityEngine.ProBuilder.SimpleTuple<System.Int32,System.Int32> x, UnityEngine.ProBuilder.SimpleTuple<System.Int32,System.Int32> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0
{
	// Fields
	public Face face; // 0x10

	// Methods

	// RVA: 0x1565A34
	public void .ctor() { }

	// RVA: 0x1565A3C
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

	// RVA: 0x1565A64
	public void .ctor() { }

	// RVA: 0x1565A6C
	internal bool <FindHoles>b__1(WingedEdge w) { }

	// RVA: 0x1565AE8
	internal bool <FindHoles>b__2(WingedEdge w) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ElementSelection
{
	// Fields
	private const int k_MaxHoleIterations = 2048;
	private static readonly Vector3 Vector3_Zero; // 0x0

	// Methods

	// RVA: 0x155ECD0
	public static void GetNeighborFaces(ProBuilderMesh mesh, Edge edge, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> neighborFaces) { }

	// RVA: 0x154A46C
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Edge>> GetNeighborFaces(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x155EF4C
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> GetNeighborFaces(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x155F2A0
	internal static Edge[] GetConnectedEdges(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x155F918
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetPerimeterEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x155FFF0
	internal static int[] GetPerimeterEdges(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1560424
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> GetPerimeterFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1560BA0
	internal static int[] GetPerimeterVertices(ProBuilderMesh mesh, int[] indexes, Edge[] universal_edges_all) { }

	// RVA: 0x1560F98
	private static WingedEdge EdgeRingNext(WingedEdge edge) { }

	// RVA: 0x156101C
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetEdgeRing(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15616FC
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetEdgeRingIterative(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1561D94
	internal static bool GetEdgeLoop(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Edge[] loop) { }

	// RVA: 0x15624B0
	internal static bool GetEdgeLoopIterative(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Edge[] loop) { }

	// RVA: 0x1562230
	private static bool GetEdgeLoopInternal(WingedEdge start, int startIndex, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> used) { }

	// RVA: 0x1562820
	private static void GetEdgeLoopInternalIterative(WingedEdge start, Edge edge, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> used) { }

	// RVA: 0x1562EF8
	private static WingedEdge NextSpoke(WingedEdge wing, int pivot, bool opp) { }

	// RVA: 0x1562BE0
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetSpokes(WingedEdge wing, int sharedIndex, bool allowHoles) { }

	// RVA: 0x1563000
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GrowSelection(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float maxAngleDiff) { }

	// RVA: 0x15635C0
	internal static void Flood(WingedEdge wing, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> selection) { }

	// RVA: 0x1563640
	internal static void Flood(ProBuilderMesh pb, WingedEdge wing, Vector3 wingNrm, float maxAngle, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> selection) { }

	// RVA: 0x156397C
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> FloodSelection(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, float maxAngleDiff) { }

	// RVA: 0x1563D20
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceLoop(ProBuilderMesh mesh, Face[] faces, bool ring) { }

	// RVA: 0x1564190
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceRingAndLoop(ProBuilderMesh mesh, Face[] faces) { }

	// RVA: 0x1563F68
	private static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceLoop(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, Face face, bool ring) { }

	// RVA: 0x15643EC
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> FindHoles(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x15647C0
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge>> FindHoles(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, System.Collections.Generic.HashSet<System.Int32> common) { }

	// RVA: 0x156531C
	private static WingedEdge FindNextEdgeInHole(WingedEdge wing, int common) { }

	// RVA: 0x15653A0
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

	// RVA: 0x156B7C4
	private static void .cctor() { }

	// RVA: 0x156B830
	public void .ctor() { }

	// RVA: 0x156B838
	internal Face <DetachFaces>b__3_0(FaceRebuildData x) { }

	// RVA: 0x156B854
	internal int <ExtrudePerFace>b__4_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ExtrudeElements
{
	// Methods

	// RVA: 0x1565B64
	public static Face[] Extrude(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, ExtrudeMethod method, float distance) { }

	// RVA: 0x1568EE4
	public static Edge[] Extrude(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, float distance, bool extrudeAsGroup, bool enableManifoldExtrude) { }

	// RVA: 0x156A0A8
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> DetachFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x156A0B0
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> DetachFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool deleteSourceFaces) { }

	// RVA: 0x1565B78
	private static Face[] ExtrudePerFace(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float distance) { }

	// RVA: 0x1566730
	private static Face[] ExtrudeAsGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool compensateAngleVertexDistance, float distance) { }

	// RVA: 0x156ABD4
	private static System.Collections.Generic.List<System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> GetFaceGroups(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings) { }

	// RVA: 0x156B178
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

	// RVA: 0x156DFC8
	private static void .cctor() { }

	// RVA: 0x156E034
	public void .ctor() { }

	// RVA: 0x156E03C
	internal Vector3[] <CreateMeshWithTransform>b__1_0(Mesh x) { }

	// RVA: 0x156E058
	internal Color[] <CreateMeshWithTransform>b__1_1(Mesh x) { }

	// RVA: 0x156E074
	internal Vector2[] <CreateMeshWithTransform>b__1_2(Mesh x) { }

	// RVA: 0x156E090
	internal Vector3[] <ResetPbObjectWithMeshFilter>b__2_0(Mesh x) { }

	// RVA: 0x156E0AC
	internal Color[] <ResetPbObjectWithMeshFilter>b__2_1(Mesh x) { }

	// RVA: 0x156E0C8
	internal Vector2[] <ResetPbObjectWithMeshFilter>b__2_2(Mesh x) { }

	// RVA: 0x156E0E4
	internal bool <FilterUnusedSubmeshIndexes>b__3_0(bool x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class InternalMeshUtility
{
	// Methods

	// RVA: 0x1569EB4
	internal static Vector3 AverageNormalWithIndexes(SharedVertex shared, int[] all, System.Collections.Generic.IList<UnityEngine.Vector3> norm) { }

	// RVA: 0x156B8B4
	public static ProBuilderMesh CreateMeshWithTransform(Transform t, bool preserveFaces) { }

	// RVA: 0x156CAA8
	public static bool ResetPbObjectWithMeshFilter(ProBuilderMesh pb, bool preserveFaces) { }

	// RVA: 0x156DA80
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

	// RVA: 0x156F518
	private static void .cctor() { }

	// RVA: 0x156F584
	public void .ctor() { }

	// RVA: 0x156F58C
	internal System.Collections.Generic.IEnumerable<System.Int32> <Merge>b__1_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> remove; // 0x10

	// Methods

	// RVA: 0x156E844
	public void .ctor() { }

	// RVA: 0x156F5A8
	internal bool <MergePairs>b__0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MergeElements
{
	// Methods

	// RVA: 0x156E0EC
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> MergePairs(ProBuilderMesh target, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Face>> pairs, bool collapseCoincidentVertices) { }

	// RVA: 0x156ED20
	public static Face Merge(ProBuilderMesh target, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x156E84C
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

	// RVA: 0x156F614
	public bool get_quads() { }

	// RVA: 0x156F61C
	public void set_quads(bool value) { }

	// RVA: 0x156F624
	public bool get_smoothing() { }

	// RVA: 0x156F62C
	public void set_smoothing(bool value) { }

	// RVA: 0x156F634
	public float get_smoothingAngle() { }

	// RVA: 0x156F63C
	public void set_smoothingAngle(float value) { }

	// RVA: 0x156F644
	public override string ToString() { }

	// RVA: 0x156F724
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

	// RVA: 0x1570FA0
	private static void .cctor() { }

	// RVA: 0x157100C
	public void .ctor() { }

	// RVA: 0x1571014
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

	// RVA: 0x156F73C
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x156F8F0
	public void .ctor(Mesh sourceMesh, Material[] sourceMaterials, ProBuilderMesh destination) { }

	// RVA: 0x156FA64
	public void .ctor(ProBuilderMesh destination) { }

	// RVA: 0x156FA98
	public bool Import(GameObject go, MeshImportSettings importSettings) { }

	// RVA: 0x156FC78
	public void Import(MeshImportSettings importSettings) { }

	// RVA: 0x1570F00
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MeshTransform
{
	// Methods

	// RVA: 0x1571034
	internal static void SetPivot(ProBuilderMesh mesh, PivotLocation pivotLocation) { }

	// RVA: 0x156C7B8
	public static void CenterPivot(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x15710D4
	public static void SetPivot(ProBuilderMesh mesh, Vector3 worldPosition) { }

	// RVA: 0x1571290
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

	// RVA: 0x1574314
	private static void .cctor() { }

	// RVA: 0x1574380
	public void .ctor() { }

	// RVA: 0x1574388
	internal System.Collections.Generic.IEnumerable<System.Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_0(Triangle x) { }

	// RVA: 0x15743B4
	internal System.Collections.Generic.IEnumerable<System.Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_1(Triangle x) { }

	// RVA: 0x15743E0
	internal System.Collections.Generic.IEnumerable<System.Int32> <RemoveUnusedVertices>b__7_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x1573A00
	public void .ctor() { }

	// RVA: 0x15743FC
	internal bool <RebuildSelectionIndexes>b__0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public Triangle triangle; // 0x10
	public System.Func<UnityEngine.ProBuilder.Triangle,System.Boolean> <>9__0; // 0x20

	// Methods

	// RVA: 0x157253C
	public void .ctor() { }

	// RVA: 0x1574464
	internal bool <CollectFaceGroups>b__0(Triangle x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MeshValidation
{
	// Methods

	// RVA: 0x1571404
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh) { }

	// RVA: 0x1571420
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1571870
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x15719E4
	public static bool ContainsNonContiguousTriangles(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1571B18
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> EnsureFacesAreComposedOfContiguousTriangles(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15721B4
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Triangle>> CollectFaceGroups(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1572544
	public static bool RemoveDegenerateTriangles(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x156F164
	public static bool RemoveUnusedVertices(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x1572FBC
	internal static System.Collections.Generic.List<System.Int32> RebuildIndexes(System.Collections.Generic.IEnumerable<System.Int32> indices, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x1573390
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> RebuildEdges(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x15737DC
	internal static void RebuildSelectionIndexes(ProBuilderMesh mesh, Face[] faces, Edge[] edges, int[] indices, System.Collections.Generic.IEnumerable<System.Int32> removed) { }

	// RVA: 0x1573A08
	internal static bool EnsureMeshIsValid(ProBuilderMesh mesh, int removedVertices) { }

	// RVA: 0x1573D70
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector2> attribute) { }

	// RVA: 0x1573F48
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector3> attribute) { }

	// RVA: 0x157412C
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector4> attribute) { }

	// RVA: 0x316B894
	private static void EnsureArraySize(T[] attribute, int expectedVertexCount, AttributeValidationStrategy strategy, T fill) { }

	// RVA: 0x316B894
	private static void EnsureListSize(System.Collections.Generic.List<T>& attribute, int expectedVertexCount, AttributeValidationStrategy strategy, T fill) { }

	// RVA: 0x1573B84
	private static void EnsureValidAttributes(ProBuilderMesh mesh) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class QuadUtility
{
	// Methods

	// RVA: 0x15704C8
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> ToQuads(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, bool smoothing) { }

	// RVA: 0x1574B98
	private static Face GetBestQuadConnection(WingedEdge wing, System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.EdgeLookup,System.Single> connections) { }

	// RVA: 0x1574498
	private static float GetQuadScore(ProBuilderMesh mesh, WingedEdge left, WingedEdge right, float normalThreshold) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class Subdivision
{
	// Methods

	// RVA: 0x1574E64
	public static ActionResult Subdivide(ProBuilderMesh pb) { }

	// RVA: 0x1574F1C
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

	// RVA: 0x1576FE4
	private static void .cctor() { }

	// RVA: 0x1577050
	public void .ctor() { }

	// RVA: 0x1577058
	internal Face <ToTriangles>b__0_0(FaceRebuildData x) { }

	// RVA: 0x1577074
	internal Vector3 <GetWindingOrder>b__3_0(Vertex x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class SurfaceTopology
{
	// Methods

	// RVA: 0x1574F24
	public static Face[] ToTriangles(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15754C0
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> BreakFaceIntoTris(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x1575964
	public static WindingOrder GetWindingOrder(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1575C60
	private static WindingOrder GetWindingOrder(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x15759A8
	public static WindingOrder GetWindingOrder(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x1575E0C
	public static bool FlipEdge(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1576274
	public static ActionResult ConformNormals(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1576A48
	private static void GetWindingFlags(WingedEdge edge, bool flag, System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Face,System.Boolean> flags) { }

	// RVA: 0x1576CE0
	internal static ActionResult ConformOppositeNormal(WingedEdge source) { }

	// RVA: 0x1576B50
	private static Edge GetCommonEdgeInWindingOrder(WingedEdge wing) { }

	// RVA: 0x1576DFC
	internal static void MatchNormal(Face source, Face target, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public int index; // 0x10

	// Methods

	// RVA: 0x1579404
	public void .ctor() { }

	// RVA: 0x1579414
	internal TriangulationPoint <Triangulate>b__0(Vector2 x) { }

	// RVA: 0x15794A0
	internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public int index; // 0x10
	public System.Func<UnityEngine.Vector2,UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> <>9__1; // 0x18

	// Methods

	// RVA: 0x157940C
	public void .ctor() { }

	// RVA: 0x157952C
	internal PolygonPoint <Triangulate>b__0(Vector2 x) { }

	// RVA: 0x15795B8
	internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class Triangulation
{
	// Fields
	private static TriangulationContext s_TriangulationContext; // 0x0

	// Methods

	// RVA: 0x1577094
	private static TriangulationContext get_triangulationContext() { }

	// RVA: 0x1577150
	public static bool SortAndTriangulate(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.List<System.Int32>& indexes, bool convex) { }

	// RVA: 0x1578158
	public static bool TriangulateVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<System.Int32>& triangles, bool unordered, bool convex) { }

	// RVA: 0x157851C
	public static bool TriangulateVertices(Vector3[] vertices, System.Collections.Generic.List<System.Int32>& triangles, Vector3[][] holes) { }

	// RVA: 0x15783A0
	public static bool TriangulateVertices(Vector3[] vertices, System.Collections.Generic.List<System.Int32>& triangles, bool unordered, bool convex) { }

	// RVA: 0x15774F4
	public static bool Triangulate(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.List<System.Int32>& indexes, bool convex) { }

	// RVA: 0x15786E0
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

	// RVA: 0x157CE7C
	private static void .cctor() { }

	// RVA: 0x157CEE8
	public void .ctor() { }

	// RVA: 0x157CEF0
	internal Vector2 <GetUVs>b__2_0(Vector4 x) { }

	// RVA: 0x157CEF4
	internal int <SewUVs>b__4_1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

	// RVA: 0x157CFBC
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesAuto>b__8_0(Face x) { }

	// RVA: 0x157CFD8
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesAuto>b__8_1(Face x) { }

	// RVA: 0x157CFF4
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesBox>b__9_0(Face x) { }

	// RVA: 0x157D010
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesBox>b__11_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public Face f1; // 0x10
	public Face f2; // 0x18

	// Methods

	// RVA: 0x1579914
	public void .ctor() { }

	// RVA: 0x157D02C
	internal bool <AutoStitch>b__0(WingedEdge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public int b; // 0x10

	// Methods

	// RVA: 0x157B300
	public void .ctor() { }

	// RVA: 0x157D078
	internal bool <SewUVs>b__0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class UVEditing
{
	// Methods

	// RVA: 0x1579644
	public static bool AutoStitch(ProBuilderMesh mesh, Face f1, Face f2, int channel) { }

	// RVA: 0x157991C
	private static bool AlignEdges(ProBuilderMesh mesh, Face faceToMove, Edge edgeToAlignTo, Edge edgeToBeAligned, int channel) { }

	// RVA: 0x157A3AC
	internal static Vector2[] GetUVs(ProBuilderMesh mesh, int channel) { }

	// RVA: 0x157A988
	internal static void ApplyUVs(ProBuilderMesh mesh, Vector2[] uvs, int channel, bool applyToMesh) { }

	// RVA: 0x157ACF0
	public static void SewUVs(ProBuilderMesh mesh, int[] indexes, float delta) { }

	// RVA: 0x157B308
	public static void CollapseUVs(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x157A618
	public static void SplitUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x157B3D4
	internal static void SplitUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x157B7C4
	internal static void ProjectFacesAuto(ProBuilderMesh mesh, Face[] faces, int channel) { }

	// RVA: 0x157BB88
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, int channel) { }

	// RVA: 0x157C2AC
	internal static Vector2 FindMinimalUV(Vector2[] uvs, int[] indices, float xMin, float yMin) { }

	// RVA: 0x157C40C
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, Vector2 lowerLeftAnchor, int channel) { }

	// RVA: 0x157CB78
	public static void ProjectFacesSphere(ProBuilderMesh pb, int[] indexes, int channel) { }

	// RVA: 0x157CD04
	public static Vector2[] FitUVs(Vector2[] uvs) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class VertexEditing
{
	// Methods

	// RVA: 0x157D15C
	public static int MergeVertices(ProBuilderMesh mesh, int[] indexes, bool collapseToFirst) { }

	// RVA: 0x157D4BC
	public static void SplitVertices(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x157D548
	public static void SplitVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x157D94C
	public static int[] WeldVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, float neighborRadius) { }

	// RVA: 0x157EC90
	internal static FaceRebuildData ExplodeVertex(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.WingedEdge,System.Int32>> edgeAndCommonIndex, float distance, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>>& appendedVertices) { }

	// RVA: 0x157FBFC
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


