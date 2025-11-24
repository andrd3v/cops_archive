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

	// RVA: 0x15040A4
	private static MonoScriptData Get() { }

	// RVA: 0x15041A8
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

	// RVA: 0x15041B0
	public Status get_status() { }

	// RVA: 0x15041B8
	private void set_status(Status value) { }

	// RVA: 0x15041C0
	public string get_notification() { }

	// RVA: 0x15041C8
	private void set_notification(string value) { }

	// RVA: 0x15041D0
	public void .ctor(Status status, string notification) { }

	// RVA: 0x1504214
	public static bool op_Implicit(ActionResult res) { }

	// RVA: 0x1504228
	public bool ToBool() { }

	// RVA: 0x1504238
	public static bool FromBool(bool success) { }

	// RVA: 0x150432C
	public static ActionResult get_Success() { }

	// RVA: 0x15043B8
	public static ActionResult get_NoSelection() { }

	// RVA: 0x1504448
	public static ActionResult get_UserCanceled() { }

}

// Namespace: 
private struct SearchRange
{
	// Fields
	public int begin; // 0x10
	public int end; // 0x14

	// Methods

	// RVA: 0x15044D8
	public void .ctor(int begin, int end) { }

	// RVA: 0x15044E0
	public bool Valid() { }

	// RVA: 0x15044F4
	public int Center() { }

	// RVA: 0x150450C
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal string <ToString>b__23_0(T x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0<T0, T1>
{
	// Fields
	public System.Collections.Generic.HashSet<TKey> knownKeys; // 0x0
	public System.Func<TSource,TKey> keySelector; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal bool <DistinctBy>b__0(TSource x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ArrayUtility
{
	// Methods

	// RVA: 0x30D78C4
	public static T[] ValuesWithIndexes(T[] arr, int[] indexes) { }

	// RVA: 0x30D78C4
	public static System.Collections.Generic.List<T> ValuesWithIndexes(System.Collections.Generic.List<T> arr, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x30D78C4
	public static System.Collections.Generic.IEnumerable<System.Int32> AllIndexesOf(System.Collections.Generic.IList<T> list, System.Func<T,System.Boolean> lambda) { }

	// RVA: 0x318DB98
	public static T[] Add(T[] arr, T val) { }

	// RVA: 0x30D78C4
	public static T[] AddRange(T[] arr, T[] val) { }

	// RVA: 0x318DB98
	public static T[] Remove(T[] arr, T val) { }

	// RVA: 0x30D78C4
	public static T[] Remove(T[] arr, System.Collections.Generic.IEnumerable<T> val) { }

	// RVA: -1
	public static T[] RemoveAt(T[] arr, int index) { }

	// RVA: 0x30D78C4
	public static T[] RemoveAt(System.Collections.Generic.IList<T> list, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x30D78C4
	public static T[] SortedRemoveAt(System.Collections.Generic.IList<T> list, System.Collections.Generic.IList<System.Int32> sorted) { }

	// RVA: 0x318DB98
	public static int NearestIndexPriorToValue(System.Collections.Generic.IList<T> sorted_list, T value) { }

	// RVA: -1
	public static System.Collections.Generic.List<T> Fill(System.Func<System.Int32,T> ctor, int length) { }

	// RVA: 0x318DB98
	public static T[] Fill(T val, int length) { }

	// RVA: 0x30D6128
	public static bool ContainsMatch(T[] a, T[] b) { }

	// RVA: -1
	public static bool ContainsMatch(T[] a, T[] b, int index_a, int index_b) { }

	// RVA: 0x30D78C4
	public static T[] Concat(T[] x, T[] y) { }

	// RVA: 0x318DB98
	public static int IndexOf(System.Collections.Generic.List<System.Collections.Generic.List<T>> InList, T InValue) { }

	// RVA: -1
	public static T[] Fill(int count, System.Func<System.Int32,T> ctor) { }

	// RVA: 0x318DB98
	public static void AddOrAppend(System.Collections.Generic.Dictionary<T,System.Collections.Generic.List<K>> dictionary, T key, K value) { }

	// RVA: 0x318DB98
	public static void AddOrAppendRange(System.Collections.Generic.Dictionary<T,System.Collections.Generic.List<K>> dictionary, T key, System.Collections.Generic.List<K> value) { }

	// RVA: 0x30D78C4
	public static System.Collections.Generic.IEnumerable<TSource> DistinctBy(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource,TKey> keySelector) { }

	// RVA: 0x30D77E4
	public static string ToString(System.Collections.Generic.Dictionary<TKey,TValue> dict) { }

	// RVA: 0x30D78C4
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

	// RVA: 0x15046B8
	public static AutoUnwrapSettings get_defaultAutoUnwrapSettings() { }

	// RVA: 0x15046E8
	public bool get_useWorldSpace() { }

	// RVA: 0x15046F0
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x15046F8
	public bool get_flipU() { }

	// RVA: 0x1504700
	public void set_flipU(bool value) { }

	// RVA: 0x1504708
	public bool get_flipV() { }

	// RVA: 0x1504710
	public void set_flipV(bool value) { }

	// RVA: 0x1504718
	public bool get_swapUV() { }

	// RVA: 0x1504720
	public void set_swapUV(bool value) { }

	// RVA: 0x1504728
	public Fill get_fill() { }

	// RVA: 0x1504730
	public void set_fill(Fill value) { }

	// RVA: 0x1504738
	public Vector2 get_scale() { }

	// RVA: 0x1504740
	public void set_scale(Vector2 value) { }

	// RVA: 0x1504748
	public Vector2 get_offset() { }

	// RVA: 0x1504750
	public void set_offset(Vector2 value) { }

	// RVA: 0x1504758
	public float get_rotation() { }

	// RVA: 0x1504760
	public void set_rotation(float value) { }

	// RVA: 0x1504768
	public Anchor get_anchor() { }

	// RVA: 0x1504770
	public void set_anchor(Anchor value) { }

	// RVA: 0x1504778
	public void .ctor(AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x15047D4
	public static AutoUnwrapSettings get_tile() { }

	// RVA: 0x15047EC
	public static AutoUnwrapSettings get_fit() { }

	// RVA: 0x1504804
	public static AutoUnwrapSettings get_stretch() { }

	// RVA: 0x15046D0
	public void Reset() { }

	// RVA: 0x150481C
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

	// RVA: 0x1504CB0
	public void .ctor(Vector3 position, Vector3 tangentIn, Vector3 tangentOut, Quaternion rotation) { }

	// RVA: 0x1504CD8
	public void EnforceTangentMode(BezierTangentDirection master, BezierTangentMode mode) { }

	// RVA: 0x1504FE8
	public void SetPosition(Vector3 position) { }

	// RVA: 0x1505038
	public void SetTangentIn(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x150504C
	public void SetTangentOut(Vector3 tangent, BezierTangentMode mode) { }

	// RVA: 0x1505060
	public static Vector3 QuadraticPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x15050C0
	public static Vector3 CubicPosition(BezierPoint a, BezierPoint b, float t) { }

	// RVA: 0x1505164
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

	// RVA: 0x1505B40
	public bool get_isEditing() { }

	// RVA: 0x1505B48
	public void set_isEditing(bool value) { }

	// RVA: 0x1505B50
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x1505C48
	public void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x1505C50
	public void Init() { }

	// RVA: 0x1505DC0
	public void Refresh() { }

	// RVA: 0x1505E90
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

	// RVA: 0x1505F38
	public Vector2 get_size() { }

	// RVA: 0x1505F40
	public void set_size(Vector2 value) { }

	// RVA: 0x1505F58
	public Vector2 get_extents() { }

	// RVA: 0x1505F60
	public Vector2[] get_corners() { }

	// RVA: 0x1506034
	public void .ctor() { }

	// RVA: 0x15060A0
	public void .ctor(Vector2 center, Vector2 size) { }

	// RVA: 0x1506148
	public void .ctor(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x15064DC
	public void .ctor(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1506AF8
	internal void .ctor(Vector3[] points, Edge[] edges) { }

	// RVA: 0x1506C54
	public void .ctor(Vector2[] points, int length) { }

	// RVA: 0x1506D60
	public bool ContainsPoint(Vector2 point) { }

	// RVA: 0x1506DB0
	public bool IntersectsLineSegment(Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x1507020
	public bool Intersects(Bounds2D bounds) { }

	// RVA: 0x1507060
	public bool Intersects(Rect rect) { }

	// RVA: 0x15061CC
	public void SetWithPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x1506568
	public void SetWithPoints(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x150709C
	public static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x1507358
	public static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x15077D0
	public static Vector2 Size(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1507C3C
	internal static Vector2 Center(System.Collections.Generic.IList<UnityEngine.Vector4> points, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x1508140
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

	// RVA: 0x15082C8
	private static void Init() { }

	// RVA: 0x1508F5C
	public static bool get_geometryShadersSupported() { }

	// RVA: 0x1508FBC
	public static Material get_defaultMaterial() { }

	// RVA: 0x150901C
	internal static Shader get_selectionPickerShader() { }

	// RVA: 0x150907C
	internal static Material get_facePickerMaterial() { }

	// RVA: 0x15090DC
	internal static Material get_vertexPickerMaterial() { }

	// RVA: 0x150913C
	internal static Material get_edgePickerMaterial() { }

	// RVA: 0x150919C
	internal static Material get_triggerMaterial() { }

	// RVA: 0x15092AC
	internal static Material get_colliderMaterial() { }

	// RVA: 0x15093BC
	internal static Material get_noDrawMaterial() { }

	// RVA: 0x15094CC
	internal static Material GetLegacyDiffuse() { }

	// RVA: 0x1508C38
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x15097FC
	internal static Material get_unlitVertexColor() { }

	// RVA: 0x150985C
	internal static Material get_ShapePreviewMaterial() { }

	// RVA: 0x15098BC
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

	// RVA: 0x1509A0C
	public SemVer get_versionInfo() { }

	// RVA: 0x1509A14
	public string get_releaseNotes() { }

	// RVA: 0x1509A1C
	public void .ctor(SemVer version, string releaseNotes) { }

	// RVA: 0x1509A6C
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

	// RVA: 0x1509AD4
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.ChangelogEntry> get_entries() { }

	// RVA: 0x1509B54
	public void .ctor(string log) { }

	// RVA: 0x1509DFC
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

	// RVA: 0x1509F84
	private static OutCode ComputeOutCode(Rect rect, float x, float y) { }

	// RVA: 0x1509FC0
	internal static bool RectContainsLineSegment(Rect rect, float x0, float y0, float x1, float y1) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ColliderBehaviour
{
	// Methods

	// RVA: 0x150A1BC
	public override void Initialize() { }

	// RVA: 0x150A408
	public override void OnEnterPlayMode() { }

	// RVA: 0x150A4E8
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x150A5C8
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

	// RVA: 0x150A5E8
	public Color get_current() { }

	// RVA: 0x150A5F4
	public void set_current(Color value) { }

	// RVA: 0x150A600
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Color> get_colors() { }

	// RVA: 0x150A680
	public void SetColors(System.Collections.Generic.IEnumerable<UnityEngine.Color> colors) { }

	// RVA: 0x150A734
	public void SetDefaultValues() { }

	// RVA: 0x150A99C
	public Color get_Item(int i) { }

	// RVA: 0x150AA18
	public void set_Item(int i, Color value) { }

	// RVA: 0x150AAB4
	public int get_Count() { }

	// RVA: 0x150AB00
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

	// RVA: 0x150AB08
	public void .ctor(float h, float s, float v) { }

	// RVA: 0x150AB50
	public void .ctor(float h, float s, float v, float sv_modifier) { }

	// RVA: 0x150ABA4
	public static HSVColor FromRGB(Color col) { }

	// RVA: 0x150AE10
	public override string ToString() { }

	// RVA: 0x150AEDC
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

	// RVA: 0x150AF28
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x150AF70
	public static XYZColor FromRGB(Color col) { }

	// RVA: 0x150B0B8
	public static XYZColor FromRGB(float R, float G, float B) { }

	// RVA: 0x150B370
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

	// RVA: 0x150B43C
	public void .ctor(float L, float a, float b) { }

	// RVA: 0x150B484
	public static CIELabColor FromXYZ(XYZColor xyz) { }

	// RVA: 0x150B6E4
	public static CIELabColor FromRGB(Color col) { }

	// RVA: 0x150B81C
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ColorUtility
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.ProBuilder.CIELabColor> ColorNameLookup; // 0x0

	// Methods

	// RVA: 0x150B8E8
	private static bool approx(float lhs, float rhs) { }

	// RVA: 0x150B950
	public static Color GetColor(Vector3 vec) { }

	// RVA: 0x150B040
	public static XYZColor RGBToXYZ(Color col) { }

	// RVA: 0x150B130
	public static XYZColor RGBToXYZ(float r, float g, float b) { }

	// RVA: 0x150B504
	public static CIELabColor XYZToCIE_Lab(XYZColor xyz) { }

	// RVA: 0x150BA58
	public static float DeltaE(CIELabColor lhs, CIELabColor rhs) { }

	// RVA: 0x150BAA0
	public static Color HSVtoRGB(HSVColor hsv) { }

	// RVA: 0x150BC4C
	public static Color HSVtoRGB(float h, float s, float v) { }

	// RVA: 0x150AC24
	public static HSVColor RGBtoHSV(Color color) { }

	// RVA: 0x150BD60
	public static string GetColorName(Color InColor) { }

	// RVA: 0x150C15C
	private static CIELabColor CIELabFromRGB(float R, float G, float B, float Scale) { }

	// RVA: 0x14E715C
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

	// RVA: 0x150C22C
	public void .ctor(int a, int b) { }

	// RVA: 0x150C234
	public bool IsValid() { }

	// RVA: 0x150C258
	public override string ToString() { }

	// RVA: 0x150C3B4
	public bool Equals(Edge other) { }

	// RVA: 0x150C3F8
	public override bool Equals(object obj) { }

	// RVA: 0x150C4FC
	public override int GetHashCode() { }

	// RVA: 0x150C520
	public static Edge op_Addition(Edge a, Edge b) { }

	// RVA: 0x150C538
	public static Edge op_Subtraction(Edge a, Edge b) { }

	// RVA: 0x150C550
	public static Edge op_Addition(Edge a, int b) { }

	// RVA: 0x150C564
	public static Edge op_Subtraction(Edge a, int b) { }

	// RVA: 0x150C578
	public static bool op_Equality(Edge a, Edge b) { }

	// RVA: 0x150C630
	public static bool op_Inequality(Edge a, Edge b) { }

	// RVA: 0x150C730
	public static Edge Add(Edge a, Edge b) { }

	// RVA: 0x150C7A4
	public static Edge Subtract(Edge a, Edge b) { }

	// RVA: 0x150C818
	public bool Equals(Edge other, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x150C9B0
	public bool Contains(int index) { }

	// RVA: 0x150C9D4
	public bool Contains(Edge other) { }

	// RVA: 0x150CA00
	internal bool Contains(int index, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x150CAE8
	internal static void GetIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x150CE44
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass16_0
{
	// Fields
	public System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup; // 0x10

	// Methods

	// RVA: 0x150D508
	public void .ctor() { }

	// RVA: 0x150D8A8
	internal EdgeLookup <GetEdgeLookup>b__0(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder
public struct EdgeLookup
{
	// Fields
	private Edge m_Local; // 0x10
	private Edge m_Common; // 0x18

	// Methods

	// RVA: 0x150CE94
	public Edge get_local() { }

	// RVA: 0x150CE9C
	public void set_local(Edge value) { }

	// RVA: 0x150CEA4
	public Edge get_common() { }

	// RVA: 0x150CEAC
	public void set_common(Edge value) { }

	// RVA: 0x150CEB4
	public void .ctor(Edge common, Edge local) { }

	// RVA: 0x150CEBC
	public void .ctor(int cx, int cy, int x, int y) { }

	// RVA: 0x150CED4
	public bool Equals(EdgeLookup other) { }

	// RVA: 0x150CF5C
	public override bool Equals(object obj) { }

	// RVA: 0x150D084
	public override int GetHashCode() { }

	// RVA: 0x150D104
	public static bool op_Equality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x150D1A0
	public static bool op_Inequality(EdgeLookup a, EdgeLookup b) { }

	// RVA: 0x150D240
	public override string ToString() { }

	// RVA: 0x150D420
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.EdgeLookup> GetEdgeLookup(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x150D510
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> GetEdgeLookupHashSet(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x150DA38
	public void .ctor() { }

	// RVA: 0x150E6B8
	internal Edge <GetSharedVertexHandleEdges>b__0(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class EdgeUtility
{
	// Methods

	// RVA: 0x150D950
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetSharedVertexHandleEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x150DA40
	public static Edge GetSharedVertexHandleEdge(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x150DAF8
	internal static Edge GetEdgeWithSharedVertexHandles(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x150DB98
	public static bool ValidateEdge(ProBuilderMesh mesh, Edge edge, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Edge>& validEdge) { }

	// RVA: 0x150E09C
	internal static bool Contains(Edge[] edges, Edge edge) { }

	// RVA: 0x150E1F8
	internal static bool Contains(Edge[] edges, int x, int y) { }

	// RVA: 0x150E294
	internal static int IndexOf(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, Edge edge) { }

	// RVA: 0x150E478
	internal static int[] AllTriangles(Edge[] edges) { }

	// RVA: 0x150E538
	internal static Face GetFace(ProBuilderMesh mesh, Edge edge) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class Entity
{
	// Fields
	private EntityType m_EntityType; // 0x20

	// Methods

	// RVA: 0x150E6C0
	public EntityType get_entityType() { }

	// RVA: 0x150E6C8
	public void Awake() { }

	// RVA: 0x150E7B8
	public void SetEntity(EntityType t) { }

	// RVA: 0x150E7C0
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

	// RVA: 0x150A2F4
	protected void SetMaterial(Material material) { }

	// RVA: 0x150A5D8
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

	// RVA: 0x150E7C8
	public bool get_manualUV() { }

	// RVA: 0x150E7D0
	public void set_manualUV(bool value) { }

	// RVA: 0x150E7D8
	public int get_textureGroup() { }

	// RVA: 0x150E7E0
	public void set_textureGroup(int value) { }

	// RVA: 0x150E7E8
	internal int[] get_indexesInternal() { }

	// RVA: 0x150E7F0
	internal void set_indexesInternal(int[] value) { }

	// RVA: 0x150E920
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_indexes() { }

	// RVA: 0x150E9A0
	public void SetIndexes(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x150E000
	internal int[] get_distinctIndexesInternal() { }

	// RVA: 0x150EBD4
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_distinctIndexes() { }

	// RVA: 0x150E6A4
	internal Edge[] get_edgesInternal() { }

	// RVA: 0x150EFF0
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.Edge> get_edges() { }

	// RVA: 0x150F080
	public int get_smoothingGroup() { }

	// RVA: 0x150F088
	public void set_smoothingGroup(int value) { }

	// RVA: 0x150F090
	public Material get_material() { }

	// RVA: 0x150F098
	public void set_material(Material value) { }

	// RVA: 0x150F0A0
	public int get_submeshIndex() { }

	// RVA: 0x150F0A8
	public void set_submeshIndex(int value) { }

	// RVA: 0x150F0B0
	public AutoUnwrapSettings get_uv() { }

	// RVA: 0x150F0C0
	public void set_uv(AutoUnwrapSettings value) { }

	// RVA: 0x150F0D0
	public int get_Item(int i) { }

	// RVA: 0x150F104
	public void .ctor() { }

	// RVA: 0x150F12C
	public void .ctor(System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x150F234
	internal void .ctor(int[] triangles, Material m, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x150F2EC
	internal void .ctor(System.Collections.Generic.IEnumerable<System.Int32> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	// RVA: 0x150F394
	public void .ctor(Face other) { }

	// RVA: 0x150F3C4
	public void CopyFrom(Face other) { }

	// RVA: 0x150E8EC
	internal void InvalidateCache() { }

	// RVA: 0x150ECE0
	private Edge[] CacheEdges() { }

	// RVA: 0x150EAE8
	private int[] CacheDistinctIndexes() { }

	// RVA: 0x150F524
	public bool Contains(int a, int b, int c) { }

	// RVA: 0x150F5C4
	public bool IsQuad() { }

	// RVA: 0x150F618
	public int[] ToQuad() { }

	// RVA: 0x150FA08
	public override string ToString() { }

	// RVA: 0x150FBF4
	public void ShiftIndexes(int offset) { }

	// RVA: 0x150FCAC
	private int SmallestIndexValue() { }

	// RVA: 0x150FD5C
	public void ShiftIndexesToZero() { }

	// RVA: 0x150FEA0
	public void Reverse() { }

	// RVA: 0x150FF14
	internal static void GetIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x15102E0
	internal static void GetDistinctIndices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x151076C
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

	// RVA: 0x1510980
	public int Offset() { }

	// RVA: 0x1510988
	public override string ToString() { }

	// RVA: 0x1510A4C
	public static void Apply(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.FaceRebuildData> newFaces, ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1510BC8
	public static void Apply(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.FaceRebuildData> newFaces, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVertexLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedTextureLookup) { }

	// RVA: 0x1511160
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

	// RVA: 0x1511168
	public void .ctor(int x, int y) { }

	// RVA: 0x15111A0
	public HandleConstraint2D Inverse() { }

	// RVA: 0x1511220
	public Vector2 Mask(Vector2 v) { }

	// RVA: 0x1511238
	public Vector2 InverseMask(Vector2 v) { }

	// RVA: 0x151125C
	public static bool op_Equality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x15112A4
	public static bool op_Inequality(HandleConstraint2D a, HandleConstraint2D b) { }

	// RVA: 0x15112EC
	public override int GetHashCode() { }

	// RVA: 0x15112F4
	public override bool Equals(object o) { }

	// RVA: 0x151138C
	public override string ToString() { }

	// RVA: 0x15114E8
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

	// RVA: 0x151155C
	internal static Vector3 ScreenToGuiPoint(Camera camera, Vector3 point, float pixelsPerPoint) { }

	// RVA: 0x15115B0
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, RaycastHit hit, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x15115F0
	internal static bool FaceRaycast(Ray worldRay, ProBuilderMesh mesh, RaycastHit hit, float distance, CullingMode cullingMode, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x151201C
	internal static bool FaceRaycastBothCullModes(Ray worldRay, ProBuilderMesh mesh, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.Vector3>& back, UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.Vector3>& front) { }

	// RVA: 0x1512938
	internal static bool FaceRaycast(Ray InWorldRay, ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.RaycastHit>& hits, CullingMode cullingMode, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> ignore) { }

	// RVA: 0x15130E0
	internal static Ray InverseTransformRay(Transform transform, Ray InWorldRay) { }

	// RVA: 0x15132B4
	internal static bool MeshRaycast(Ray InWorldRay, GameObject gameObject, RaycastHit hit, float distance) { }

	// RVA: 0x151346C
	internal static bool MeshRaycast(Ray InRay, Vector3[] mesh, int[] triangles, RaycastHit hit, float distance) { }

	// RVA: 0x1513938
	internal static bool PointIsOccluded(Camera cam, ProBuilderMesh pb, Vector3 worldPoint) { }

	// RVA: 0x1513C14
	public static Quaternion GetRotation(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indices) { }

	// RVA: 0x1514310
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1514480
	public static Quaternion GetFaceRotation(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1514B7C
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1514CEC
	public static Quaternion GetEdgeRotation(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x1514DDC
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, HandleOrientation orientation, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x1514F2C
	public static Quaternion GetVertexRotation(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x1515074
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1515784
	internal static Vector3 GetActiveElementPosition(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x151587C
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

	// RVA: 0x1515F28
	public void .ctor() { }

	// RVA: 0x1515F30
	internal bool <TryParseColor>b__0(Char c) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class InternalUtility
{
	// Methods

	// RVA: 0x30D77E4
	public static T[] GetComponents(GameObject go) { }

	// RVA: 0x30D77E4
	public static T[] GetComponents(System.Collections.Generic.IEnumerable<UnityEngine.Transform> transforms) { }

	// RVA: 0x1515938
	public static GameObject EmptyGameObjectWithTransform(Transform t) { }

	// RVA: 0x1515A2C
	public static GameObject MeshGameObjectWithTransform(string name, Transform t, Mesh mesh, Material mat, bool inheritParent) { }

	// RVA: 0x318DB98
	public static T NextEnumValue(T current) { }

	// RVA: 0x1515B54
	public static string ControlKeyString(Char character) { }

	// RVA: 0x1515CA8
	public static bool TryParseColor(string value, Color col) { }

	// RVA: 0x318DB98
	public static T DemandComponent(Component component) { }

	// RVA: 0x318DB98
	public static T DemandComponent(GameObject gameObject) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec2
{
	// Fields
	public Vector2 value; // 0x10

	// Methods

	// RVA: 0x1515F50
	public float get_x() { }

	// RVA: 0x1515F58
	public float get_y() { }

	// RVA: 0x1515F60
	public void .ctor(Vector2 vector) { }

	// RVA: 0x1515F68
	public override string ToString() { }

	// RVA: 0x1516010
	public static bool op_Equality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x15161C0
	public static bool op_Inequality(IntVec2 a, IntVec2 b) { }

	// RVA: 0x151603C
	public bool Equals(IntVec2 p) { }

	// RVA: 0x151625C
	public bool Equals(Vector2 p) { }

	// RVA: 0x15163E0
	public override bool Equals(object b) { }

	// RVA: 0x15164CC
	public override int GetHashCode() { }

	// RVA: 0x15161F0
	private static int round(float v) { }

	// RVA: 0x15164D8
	public static Vector2 op_Implicit(IntVec2 p) { }

	// RVA: 0x15164DC
	public static IntVec2 op_Implicit(Vector2 p) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec3
{
	// Fields
	public Vector3 value; // 0x10

	// Methods

	// RVA: 0x15164E0
	public float get_x() { }

	// RVA: 0x15164E8
	public float get_y() { }

	// RVA: 0x15164F0
	public float get_z() { }

	// RVA: 0x15164F8
	public void .ctor(Vector3 vector) { }

	// RVA: 0x1516504
	public override string ToString() { }

	// RVA: 0x15165D0
	public static bool op_Equality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x151681C
	public static bool op_Inequality(IntVec3 a, IntVec3 b) { }

	// RVA: 0x1516604
	public bool Equals(IntVec3 p) { }

	// RVA: 0x15168C0
	public bool Equals(Vector3 p) { }

	// RVA: 0x1516AD8
	public override bool Equals(object b) { }

	// RVA: 0x1516BCC
	public override int GetHashCode() { }

	// RVA: 0x1516854
	private static int round(float v) { }

	// RVA: 0x1516BDC
	public static Vector3 op_Implicit(IntVec3 p) { }

	// RVA: 0x1516BE0
	public static IntVec3 op_Implicit(Vector3 p) { }

}

// Namespace: UnityEngine.ProBuilder
internal struct IntVec4
{
	// Fields
	public Vector4 value; // 0x10

	// Methods

	// RVA: 0x1516BE4
	public float get_x() { }

	// RVA: 0x1516BEC
	public float get_y() { }

	// RVA: 0x1516BF4
	public float get_z() { }

	// RVA: 0x1516BFC
	public float get_w() { }

	// RVA: 0x1516C04
	public void .ctor(Vector4 vector) { }

	// RVA: 0x1516C10
	public override string ToString() { }

	// RVA: 0x1516DF0
	public static bool op_Equality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x15170C8
	public static bool op_Inequality(IntVec4 a, IntVec4 b) { }

	// RVA: 0x1516E28
	public bool Equals(IntVec4 p) { }

	// RVA: 0x1517170
	public bool Equals(Vector4 p) { }

	// RVA: 0x1517410
	public override bool Equals(object b) { }

	// RVA: 0x1517504
	public override int GetHashCode() { }

	// RVA: 0x1517104
	private static int round(float v) { }

	// RVA: 0x1517514
	public static Vector4 op_Implicit(IntVec4 p) { }

	// RVA: 0x1517518
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

	// RVA: 0x151751C
	public static void PushLogLevel(LogLevel level) { }

	// RVA: 0x15175E0
	public static void PopLogLevel() { }

	// RVA: 0x1517694
	public static void SetLogLevel(LogLevel level) { }

	// RVA: 0x1517720
	public static void SetOutput(LogOutput output) { }

	// RVA: 0x15177AC
	public static void SetLogFile(string path) { }

	// RVA: 0x318DB98
	public static void Debug(T value) { }

	// RVA: 0x1517818
	public static void Debug(string message) { }

	// RVA: 0x15179B8
	public static void Debug(string format, object[] values) { }

	// RVA: 0x15179BC
	public static void Info(string format, object[] values) { }

	// RVA: 0x1517AD0
	public static void Info(string message) { }

	// RVA: 0x1517B90
	public static void Warning(string format, object[] values) { }

	// RVA: 0x1517CA4
	public static void Warning(string message) { }

	// RVA: 0x1517D64
	public static void Error(string format, object[] values) { }

	// RVA: 0x1508E9C
	public static void Error(string message) { }

	// RVA: 0x318DB98
	internal static void Watch(T key, K value) { }

	// RVA: 0x15178A0
	private static void DoPrint(string message, LogType type) { }

	// RVA: 0x1517FBC
	private static void PrintToFile(string message, string path) { }

	// RVA: 0x15183C0
	public static void ClearLogFile() { }

	// RVA: 0x1517E78
	private static void PrintToConsole(string message, LogType type) { }

	// RVA: 0x318DB98
	internal static void NotNull(T obj, string message) { }

	// RVA: 0x151848C
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class MaterialUtility
{
	// Fields
	internal static System.Collections.Generic.List<UnityEngine.Material> s_MaterialArray; // 0x0

	// Methods

	// RVA: 0x1518564
	internal static int GetMaterialCount(Renderer renderer) { }

	// RVA: 0x151868C
	internal static Material GetSharedMaterial(Renderer renderer, int index) { }

	// RVA: 0x1518848
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

	// RVA: 0x15188E4
	internal static Vector2 PointInCircumference(float radius, float angleInDegrees, Vector2 origin) { }

	// RVA: 0x1518938
	internal static Vector2 PointInEllipseCircumference(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, Vector2 tangent) { }

	// RVA: 0x1518A78
	internal static Vector2 PointInEllipseCircumferenceWithConstantAngle(float xRadius, float yRadius, float angleInDegrees, Vector2 origin, Vector2 tangent) { }

	// RVA: 0x1518BFC
	internal static Vector3 PointInSphere(float radius, float latitudeAngle, float longitudeAngle) { }

	// RVA: 0x1518C68
	internal static float SignedAngle(Vector2 a, Vector2 b) { }

	// RVA: 0x1518D84
	public static float SqrDistance(Vector3 a, Vector3 b) { }

	// RVA: 0x1518DA8
	public static float TriangleArea(Vector3 x, Vector3 y, Vector3 z) { }

	// RVA: 0x1518E5C
	internal static float PolygonArea(Vector3[] vertices, int[] indexes) { }

	// RVA: 0x1519108
	internal static Vector2 RotateAroundPoint(Vector2 v, Vector2 origin, float theta) { }

	// RVA: 0x1519174
	public static Vector2 ScaleAroundPoint(Vector2 v, Vector2 origin, Vector2 scale) { }

	// RVA: 0x1519190
	internal static Vector2 Perpendicular(Vector2 value) { }

	// RVA: 0x15191A0
	public static Vector2 ReflectPoint(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x151934C
	internal static float SqrDistanceRayPoint(Ray ray, Vector3 point) { }

	// RVA: 0x15193A0
	public static float DistancePointLineSegment(Vector2 point, Vector2 lineStart, Vector2 lineEnd) { }

	// RVA: 0x151957C
	public static float DistancePointLineSegment(Vector3 point, Vector3 lineStart, Vector3 lineEnd) { }

	// RVA: 0x1519828
	public static Vector3 GetNearestPointRayRay(Ray a, Ray b) { }

	// RVA: 0x1519870
	internal static Vector3 GetNearestPointRayRay(Vector3 ao, Vector3 ad, Vector3 bo, Vector3 bd) { }

	// RVA: 0x15199DC
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 intersect) { }

	// RVA: 0x1506FB0
	internal static bool GetLineSegmentIntersect(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

	// RVA: 0x1519AF4
	internal static bool PointInPolygon(Vector2[] polygon, Vector2 point, int[] indexes) { }

	// RVA: 0x1519EAC
	internal static bool PointInPolygon(Vector2[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x151A174
	internal static bool PointInPolygon(Vector3[] positions, Bounds2D polyBounds, Edge[] edges, Vector2 point) { }

	// RVA: 0x151A558
	internal static bool RectIntersectsLineSegment(Rect rect, Vector2 a, Vector2 b) { }

	// RVA: 0x151A55C
	internal static bool RectIntersectsLineSegment(Rect rect, Vector3 a, Vector3 b) { }

	// RVA: 0x1511D78
	public static bool RayIntersectsTriangle(Ray InRay, Vector3 InTriangleA, Vector3 InTriangleB, Vector3 InTriangleC, float OutDistance, Vector3 OutPoint) { }

	// RVA: 0x15136F8
	internal static bool RayIntersectsTriangle2(Vector3 origin, Vector3 dir, Vector3 vert0, Vector3 vert1, Vector3 vert2, float distance, Vector3 normal) { }

	// RVA: 0x151A5B0
	public static float Secant(float x) { }

	// RVA: 0x151A5CC
	public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2) { }

	// RVA: 0x151A7B0
	internal static Vector3 Normal(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x151B05C
	public static Vector3 Normal(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1514720
	public static Normal NormalTangentBitangent(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x151B2E8
	internal static bool IsCardinalAxis(Vector3 v, float epsilon) { }

	// RVA: 0x151B590
	internal static Vector2 DivideBy(Vector2 v, Vector2 o) { }

	// RVA: 0x151B59C
	internal static Vector3 DivideBy(Vector3 v, Vector3 o) { }

	// RVA: 0x318DB98
	internal static T Max(T[] array) { }

	// RVA: 0x318DB98
	internal static T Min(T[] array) { }

	// RVA: 0x151B5AC
	internal static float LargestValue(Vector3 v) { }

	// RVA: 0x151B5C8
	internal static float LargestValue(Vector2 v) { }

	// RVA: 0x151B5D4
	internal static Vector2 SmallestVector2(Vector2[] v) { }

	// RVA: 0x151B624
	internal static Vector2 SmallestVector2(Vector2[] v, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x151B980
	internal static Vector2 LargestVector2(Vector2[] v) { }

	// RVA: 0x151B9D0
	internal static Vector2 LargestVector2(Vector2[] v, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x15151AC
	internal static Bounds GetBounds(Vector3[] positions, System.Collections.Generic.IList<System.Int32> indices) { }

	// RVA: 0x151BD2C
	public static Vector2 Average(System.Collections.Generic.IList<UnityEngine.Vector2> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x151C0B4
	public static Vector3 Average(System.Collections.Generic.IList<UnityEngine.Vector3> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x151C67C
	public static Vector4 Average(System.Collections.Generic.IList<UnityEngine.Vector4> array, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x151CC4C
	internal static Vector3 InvertScaleVector(Vector3 scaleVector) { }

	// RVA: 0x151CC7C
	internal static bool Approx2(Vector2 a, Vector2 b, float delta) { }

	// RVA: 0x151CC98
	internal static bool Approx3(Vector3 a, Vector3 b, float delta) { }

	// RVA: 0x151CCC8
	internal static bool Approx4(Vector4 a, Vector4 b, float delta) { }

	// RVA: 0x151CD08
	internal static bool ApproxC(Color a, Color b, float delta) { }

	// RVA: 0x151CD48
	internal static bool Approx(float a, float b, float delta) { }

	// RVA: 0x1518834
	public static int Clamp(int value, int lowerBound, int upperBound) { }

	// RVA: 0x151CD5C
	internal static Vector3 Abs(Vector3 v) { }

	// RVA: 0x151CD6C
	internal static Vector3 Sign(Vector3 v) { }

	// RVA: 0x151CD90
	internal static float Sum(Vector3 v) { }

	// RVA: 0x151A57C
	internal static void Cross(Vector3 a, Vector3 b, Vector3 res) { }

	// RVA: 0x151A564
	internal static void Subtract(Vector3 a, Vector3 b, Vector3 res) { }

	// RVA: 0x151CDA8
	internal static bool IsNumber(float value) { }

	// RVA: 0x151CDBC
	internal static bool IsNumber(Vector2 value) { }

	// RVA: 0x151CDDC
	internal static bool IsNumber(Vector3 value) { }

	// RVA: 0x151CE08
	internal static bool IsNumber(Vector4 value) { }

	// RVA: 0x151CE40
	internal static float MakeNonZero(float value, float min) { }

	// RVA: 0x151CE70
	internal static Vector4 FixNaN(Vector4 value) { }

	// RVA: 0x151CEAC
	internal static Vector2 EnsureUnitVector(Vector2 value) { }

	// RVA: 0x151D010
	internal static Vector3 EnsureUnitVector(Vector3 value) { }

	// RVA: 0x151D18C
	internal static Vector4 EnsureUnitVector(Vector4 value) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class MeshHandle
{
	// Fields
	private Transform m_Transform; // 0x10
	private Mesh m_Mesh; // 0x18

	// Methods

	// RVA: 0x151D1E8
	public Mesh get_mesh() { }

	// RVA: 0x151D1F0
	public void .ctor(Transform transform, Mesh mesh) { }

	// RVA: 0x151D240
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

	// RVA: 0x1520358
	private static void .cctor() { }

	// RVA: 0x15203C4
	public void .ctor() { }

	// RVA: 0x15203CC
	internal System.Collections.Generic.IEnumerable<System.Int32> <CreateFaceMesh>b__9_0(Face x) { }

	// RVA: 0x15203E8
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

	// RVA: 0x151D39C
	internal static void CreateFaceMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x151D510
	internal static void CreateFaceMeshFromFaces(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, Mesh target) { }

	// RVA: 0x151D678
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x151DA34
	internal static void CreateEdgeMesh(ProBuilderMesh mesh, Mesh target, Edge[] edges) { }

	// RVA: 0x151DCE0
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x151DEE4
	internal static void CreateVertexMesh(ProBuilderMesh mesh, Mesh target, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x151E030
	private static void CreatePointMesh(Vector3[] positions, System.Collections.Generic.IList<System.Int32> indexes, Mesh target) { }

	// RVA: 0x151EA4C
	internal static void CreatePointBillboardMesh(System.Collections.Generic.IList<UnityEngine.Vector3> positions, Mesh target) { }

	// RVA: 0x151E1E8
	private static void CreatePointBillboardMesh(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Mesh target) { }

	// RVA: 0x151F1B0
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target) { }

	// RVA: 0x151F834
	internal static void CreateEdgeBillboardMesh(ProBuilderMesh mesh, Mesh target, System.Collections.Generic.ICollection<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1520198
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

	// RVA: 0x1524D44
	private static void .cctor() { }

	// RVA: 0x1524DB0
	public void .ctor() { }

	// RVA: 0x1524DB8
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Vertex> <CollapseSharedVertices>b__11_0(System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Vertex,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder
public static class MeshUtility
{
	// Methods

	// RVA: 0x1520404
	internal static Vertex[] GeneratePerTriangleMesh(Mesh mesh) { }

	// RVA: 0x1520EBC
	public static void GenerateTangent(Mesh mesh) { }

	// RVA: 0x152147C
	public static Mesh DeepCopy(Mesh source) { }

	// RVA: 0x15214EC
	public static void CopyTo(Mesh source, Mesh destination) { }

	// RVA: 0x318DB98
	internal static T GetMeshChannel(GameObject gameObject, System.Func<UnityEngine.Mesh,T> attributeGetter) { }

	// RVA: 0x30DBBD8
	private static void PrintAttribute(StringBuilder sb, string title, System.Collections.Generic.IEnumerable<T> attrib, string fmt) { }

	// RVA: 0x1521994
	public static string Print(Mesh mesh) { }

	// RVA: 0x1522570
	public static UInt32 GetIndexCount(Mesh mesh) { }

	// RVA: 0x152266C
	public static UInt32 GetPrimitiveCount(Mesh mesh) { }

	// RVA: 0x15227C8
	public static void Compile(ProBuilderMesh probuilderMesh, Mesh targetMesh, MeshTopology preferredTopology) { }

	// RVA: 0x15208AC
	public static Vertex[] GetVertices(Mesh mesh) { }

	// RVA: 0x152346C
	public static void CollapseSharedVertices(Mesh mesh, Vertex[] vertices) { }

	// RVA: 0x1523AD4
	public static void FitToSize(ProBuilderMesh mesh, Bounds currentSize, Vector3 sizeToFit) { }

	// RVA: 0x1523EC8
	internal static string SanityCheck(ProBuilderMesh mesh) { }

	// RVA: 0x152255C
	internal static string SanityCheck(Mesh mesh) { }

	// RVA: 0x15245C0
	internal static string SanityCheck(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x1524884
	internal static bool IsUsedInParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x1524A54
	internal static void RestoreParticleSystem(ProBuilderMesh pbmesh) { }

	// RVA: 0x1524B38
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

	// RVA: 0x1524E0C
	public Vector3 get_normal() { }

	// RVA: 0x1524E18
	public void set_normal(Vector3 value) { }

	// RVA: 0x1524E24
	public Vector4 get_tangent() { }

	// RVA: 0x1524E30
	public void set_tangent(Vector4 value) { }

	// RVA: 0x1524E3C
	public Vector3 get_bitangent() { }

	// RVA: 0x1524E48
	public void set_bitangent(Vector3 value) { }

	// RVA: 0x1524E54
	public override bool Equals(object obj) { }

	// RVA: 0x1524F9C
	public override int GetHashCode() { }

	// RVA: 0x1524EFC
	public bool Equals(Normal other) { }

	// RVA: 0x152500C
	public static bool op_Equality(Normal a, Normal b) { }

	// RVA: 0x152503C
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

	// RVA: 0x152511C
	private static void ClearIntArray(int count) { }

	// RVA: 0x1525240
	public static void CalculateTangents(ProBuilderMesh mesh) { }

	// RVA: 0x15258B8
	private static void CalculateHardNormals(ProBuilderMesh mesh) { }

	// RVA: 0x1525EC0
	public static void CalculateNormals(ProBuilderMesh mesh) { }

	// RVA: 0x15264C4
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

	// RVA: 0x318DB98
	public void .ctor(int initialSize, int desiredSize, System.Func<T> constructor, System.Action<T> destructor, bool lazyInitialization) { }

	// RVA: 0x318DB98
	public T Dequeue() { }

	// RVA: 0x318DB98
	public void Enqueue(T obj) { }

	// RVA: 0x30D488C
	public void Empty() { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D4918
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

	// RVA: 0x15265B4
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Vector3> get_controlPoints() { }

	// RVA: 0x1526634
	public void SetControlPoints(System.Collections.Generic.IList<UnityEngine.Vector3> points) { }

	// RVA: 0x152669C
	public float get_extrude() { }

	// RVA: 0x15266A4
	public void set_extrude(float value) { }

	// RVA: 0x15266AC
	internal PolyEditMode get_polyEditMode() { }

	// RVA: 0x15266B4
	internal void set_polyEditMode(PolyEditMode value) { }

	// RVA: 0x15266BC
	public bool get_flipNormals() { }

	// RVA: 0x15266C4
	public void set_flipNormals(bool value) { }

	// RVA: 0x15266CC
	internal ProBuilderMesh get_mesh() { }

	// RVA: 0x15267C4
	internal void set_mesh(ProBuilderMesh value) { }

	// RVA: 0x15267CC
	private bool IsSnapEnabled() { }

	// RVA: 0x15267D4
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

	// RVA: 0x1526868
	public void OnBeforeSerialize() { }

	// RVA: 0x1526C14
	public void OnAfterDeserialize() { }

	// RVA: 0x1527028
	public void SetDefaultValues() { }

	// RVA: 0x1527130
	public bool HasKey(string key) { }

	// RVA: 0x30D3858
	public bool HasKey(string key) { }

	// RVA: 0x1527284
	public void DeleteKey(string key) { }

	// RVA: 0x318DB98
	public T Get(string key, T fallback) { }

	// RVA: 0x318DB98
	public void Set(string key, T value) { }

	// RVA: 0x15274C8
	public bool GetBool(string key, bool fallback) { }

	// RVA: 0x1527558
	public int GetInt(string key, int fallback) { }

	// RVA: 0x15275E0
	public float GetFloat(string key, float fallback) { }

	// RVA: 0x1527670
	public string GetString(string key, string fallback) { }

	// RVA: 0x15276F8
	public Color GetColor(string key, Color fallback) { }

	// RVA: 0x15277AC
	public Material GetMaterial(string key, Material fallback) { }

	// RVA: 0x1527834
	public void SetBool(string key, bool value) { }

	// RVA: 0x15278B0
	public void SetInt(string key, int value) { }

	// RVA: 0x152792C
	public void SetFloat(string key, float value) { }

	// RVA: 0x15279B0
	public void SetString(string key, string value) { }

	// RVA: 0x1527A1C
	public void SetColor(string key, Color value) { }

	// RVA: 0x1527AB8
	public void SetMaterial(string key, Material value) { }

	// RVA: 0x1527B24
	public System.Collections.Generic.Dictionary<System.String,System.Boolean> GetBoolDictionary() { }

	// RVA: 0x1527B2C
	public System.Collections.Generic.Dictionary<System.String,System.Int32> GetIntDictionary() { }

	// RVA: 0x1527B34
	public System.Collections.Generic.Dictionary<System.String,System.Single> GetFloatDictionary() { }

	// RVA: 0x1527B3C
	public System.Collections.Generic.Dictionary<System.String,System.String> GetStringDictionary() { }

	// RVA: 0x1527B44
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.Color> GetColorDictionary() { }

	// RVA: 0x1527B4C
	public System.Collections.Generic.Dictionary<System.String,UnityEngine.Material> GetMaterialDictionary() { }

	// RVA: 0x1527B54
	public void Clear() { }

	// RVA: 0x1527C38
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

	// RVA: 0x1527E58
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

	// RVA: 0x152BD5C
	public void .ctor(ProBuilderMesh mesh) { }

	// RVA: 0x1531F44
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

	// RVA: 0x1531F68
	private static void .cctor() { }

	// RVA: 0x1531FD4
	public void .ctor() { }

	// RVA: 0x1531FDC
	internal Vector2 <SetUVs>b__118_0(Vector4 x) { }

	// RVA: 0x1531FE0
	internal Vector2 <SetUVs>b__118_1(Vector4 x) { }

	// RVA: 0x1531FE4
	internal int <get_indexCount>b__126_0(Face x) { }

	// RVA: 0x1532008
	internal int <get_triangleCount>b__128_0(Face x) { }

	// RVA: 0x153202C
	internal Face <CopyFrom>b__171_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass174_0
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x152E340
	public void .ctor() { }

	// RVA: 0x1532094
	internal bool <GetUnusedTextureGroup>b__0(Face element) { }

}

// Namespace: 
private sealed class <>c__DisplayClass176_0
{
	// Fields
	public int i; // 0x10

	// Methods

	// RVA: 0x152E450
	public void .ctor() { }

	// RVA: 0x15320BC
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

	// RVA: 0x1527EC0
	public bool get_userCollisions() { }

	// RVA: 0x1527EC8
	public void set_userCollisions(bool value) { }

	// RVA: 0x1527ED0
	public UnwrapParameters get_unwrapParameters() { }

	// RVA: 0x1527ED8
	public void set_unwrapParameters(UnwrapParameters value) { }

	// RVA: 0x15249D4
	internal MeshRenderer get_renderer() { }

	// RVA: 0x1527EE0
	internal MeshFilter get_filter() { }

	// RVA: 0x1527FD4
	internal UInt16 get_versionIndex() { }

	// RVA: 0x1527FDC
	internal UInt16 get_nonSerializedVersionIndex() { }

	// RVA: 0x1527FE4
	public bool get_preserveMeshAssetOnDestroy() { }

	// RVA: 0x1527FEC
	public void set_preserveMeshAssetOnDestroy(bool value) { }

	// RVA: 0x1522BC0
	public bool HasArrays(MeshArrays channels) { }

	// RVA: 0x1527FF4
	internal Face[] get_facesInternal() { }

	// RVA: 0x1527FFC
	internal void set_facesInternal(Face[] value) { }

	// RVA: 0x1528004
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> get_faces() { }

	// RVA: 0x1528084
	public void set_faces(System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> value) { }

	// RVA: 0x1528138
	internal void InvalidateSharedVertexLookup() { }

	// RVA: 0x15281FC
	internal void InvalidateSharedTextureLookup() { }

	// RVA: 0x15282C0
	internal void InvalidateFaces() { }

	// RVA: 0x1528620
	internal void InvalidateCaches() { }

	// RVA: 0x1528658
	internal SharedVertex[] get_sharedVerticesInternal() { }

	// RVA: 0x1528660
	internal void set_sharedVerticesInternal(SharedVertex[] value) { }

	// RVA: 0x1528688
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> get_sharedVertices() { }

	// RVA: 0x1528708
	public void set_sharedVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> value) { }

	// RVA: 0x1528938
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_sharedVertexLookup() { }

	// RVA: 0x1528A0C
	internal void SetSharedVertices(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> indexes) { }

	// RVA: 0x1528A94
	internal SharedVertex[] get_sharedTextures() { }

	// RVA: 0x1528A9C
	internal void set_sharedTextures(SharedVertex[] value) { }

	// RVA: 0x1528AC4
	internal System.Collections.Generic.Dictionary<System.Int32,System.Int32> get_sharedTextureLookup() { }

	// RVA: 0x1528B94
	internal void SetSharedTextures(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> indexes) { }

	// RVA: 0x1528C1C
	internal Vector3[] get_positionsInternal() { }

	// RVA: 0x1528C24
	internal void set_positionsInternal(Vector3[] value) { }

	// RVA: 0x1528C2C
	public System.Collections.Generic.IList<UnityEngine.Vector3> get_positions() { }

	// RVA: 0x1528CAC
	public void set_positions(System.Collections.Generic.IList<UnityEngine.Vector3> value) { }

	// RVA: 0x1523EE8
	public Vertex[] GetVertices(System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1528D60
	internal void GetVerticesInList(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x1529698
	public void SetVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, bool applyMesh) { }

	// RVA: 0x1529B74
	public System.Collections.Generic.IList<UnityEngine.Vector3> get_normals() { }

	// RVA: 0x1529C10
	internal Vector3[] get_normalsInternal() { }

	// RVA: 0x1529C18
	internal void set_normalsInternal(Vector3[] value) { }

	// RVA: 0x1523130
	public Vector3[] GetNormals() { }

	// RVA: 0x1529C20
	internal Color[] get_colorsInternal() { }

	// RVA: 0x1529C28
	internal void set_colorsInternal(Color[] value) { }

	// RVA: 0x1529C30
	public System.Collections.Generic.IList<UnityEngine.Color> get_colors() { }

	// RVA: 0x1529CCC
	public void set_colors(System.Collections.Generic.IList<UnityEngine.Color> value) { }

	// RVA: 0x1529EAC
	public Color[] GetColors() { }

	// RVA: 0x152A028
	public System.Collections.Generic.IList<UnityEngine.Vector4> get_tangents() { }

	// RVA: 0x152A0D0
	public void set_tangents(System.Collections.Generic.IList<UnityEngine.Vector4> value) { }

	// RVA: 0x152A248
	internal Vector4[] get_tangentsInternal() { }

	// RVA: 0x152A250
	internal void set_tangentsInternal(Vector4[] value) { }

	// RVA: 0x15232C0
	public Vector4[] GetTangents() { }

	// RVA: 0x152A258
	internal Vector2[] get_texturesInternal() { }

	// RVA: 0x152A260
	internal void set_texturesInternal(Vector2[] value) { }

	// RVA: 0x152A268
	internal System.Collections.Generic.List<UnityEngine.Vector4> get_textures2Internal() { }

	// RVA: 0x152A270
	internal void set_textures2Internal(System.Collections.Generic.List<UnityEngine.Vector4> value) { }

	// RVA: 0x152A278
	internal System.Collections.Generic.List<UnityEngine.Vector4> get_textures3Internal() { }

	// RVA: 0x152A280
	internal void set_textures3Internal(System.Collections.Generic.List<UnityEngine.Vector4> value) { }

	// RVA: 0x152A288
	public System.Collections.Generic.IList<UnityEngine.Vector2> get_textures() { }

	// RVA: 0x152A324
	public void set_textures(System.Collections.Generic.IList<UnityEngine.Vector2> value) { }

	// RVA: 0x1522E28
	public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x152A488
	internal System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Vector2> GetUVs(int channel) { }

	// RVA: 0x152A5B4
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x15264AC
	public int get_faceCount() { }

	// RVA: 0x1523E84
	public int get_vertexCount() { }

	// RVA: 0x152A8E8
	public int get_edgeCount() { }

	// RVA: 0x152A98C
	public int get_indexCount() { }

	// RVA: 0x152AAC8
	public int get_triangleCount() { }

	// RVA: 0x152AC20
	public static void add_meshWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x152AD30
	public static void remove_meshWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x152AE40
	internal static void add_meshWasInitialized(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x152AF54
	internal static void remove_meshWasInitialized(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x152B068
	internal static void add_componentWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x152B17C
	internal static void remove_componentWillBeDestroyed(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x152B290
	internal static void add_componentHasBeenReset(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x152B3A4
	internal static void remove_componentHasBeenReset(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x152B4B8
	public static void add_elementSelectionChanged(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x152B5CC
	public static void remove_elementSelectionChanged(System.Action<UnityEngine.ProBuilder.ProBuilderMesh> value) { }

	// RVA: 0x1524C1C
	internal Mesh get_mesh() { }

	// RVA: 0x152B6E0
	internal void set_mesh(Mesh value) { }

	// RVA: 0x152B6E8
	internal int get_id() { }

	// RVA: 0x152B70C
	public MeshSyncState get_meshSyncState() { }

	// RVA: 0x152B814
	internal int get_meshFormatVersion() { }

	// RVA: 0x152B81C
	private void Awake() { }

	// RVA: 0x152BD94
	private void Reset() { }

	// RVA: 0x152BE64
	private void OnDestroy() { }

	// RVA: 0x152C05C
	internal void DestroyUnityMesh() { }

	// RVA: 0x1529B54
	private void IncrementVersionIndex() { }

	// RVA: 0x15299C0
	public void Clear() { }

	// RVA: 0x152B9AC
	internal void EnsureMeshFilterIsAssigned() { }

	// RVA: 0x152C1A4
	internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions) { }

	// RVA: 0x152C510
	public static ProBuilderMesh Create() { }

	// RVA: 0x152C5A4
	public static ProBuilderMesh Create(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> positions, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x152C7C0
	public static ProBuilderMesh Create(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedTextures, System.Collections.Generic.IList<UnityEngine.Material> materials) { }

	// RVA: 0x152C2CC
	internal void GeometryWithPoints(Vector3[] points) { }

	// RVA: 0x152C680
	public void RebuildWithPositionsAndFaces(System.Collections.Generic.IEnumerable<UnityEngine.Vector3> vertices, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1523E9C
	internal void Rebuild() { }

	// RVA: 0x152C9C0
	public void ToMesh(MeshTopology preferredTopology) { }

	// RVA: 0x152D360
	private void FinalizeToMesh(bool usedInParticleSystem) { }

	// RVA: 0x152D3AC
	public void MakeUnique() { }

	// RVA: 0x152D5AC
	public void CopyFrom(ProBuilderMesh other) { }

	// RVA: 0x152D124
	public void Refresh(RefreshMask mask) { }

	// RVA: 0x152BB7C
	internal void EnsureMeshColliderIsAssigned() { }

	// RVA: 0x152E244
	internal int GetUnusedTextureGroup(int i) { }

	// RVA: 0x152E348
	private static bool IsValidTextureGroup(int group) { }

	// RVA: 0x152E354
	internal int UnusedElementGroup(int i) { }

	// RVA: 0x152DA94
	public void RefreshUV(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> facesToRefresh) { }

	// RVA: 0x152E458
	internal void SetGroupUV(AutoUnwrapSettings settings, int group) { }

	// RVA: 0x152E0D0
	private void RefreshColors() { }

	// RVA: 0x152E53C
	public void SetFaceColor(Face face, Color color) { }

	// RVA: 0x152E8E4
	public void SetMaterial(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, Material material) { }

	// RVA: 0x152E10C
	private void RefreshNormals() { }

	// RVA: 0x152E1A8
	private void RefreshTangents() { }

	// RVA: 0x152EF54
	internal int GetSharedVertexHandle(int vertex) { }

	// RVA: 0x152F0C4
	internal System.Collections.Generic.HashSet<System.Int32> GetSharedVertexHandles(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x152F448
	public System.Collections.Generic.List<System.Int32> GetCoincidentVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x152FA78
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x1530090
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x152F520
	public void GetCoincidentVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x1530758
	public void GetCoincidentVertices(int vertex, System.Collections.Generic.List<System.Int32> coincident) { }

	// RVA: 0x1530904
	public void SetVerticesCoincident(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x15309C4
	internal void SetTexturesCoincident(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x1530A10
	internal void AddToSharedVertex(int sharedVertexHandle, int vertex) { }

	// RVA: 0x1530AAC
	internal void AddSharedVertex(SharedVertex vertex) { }

	// RVA: 0x1530B70
	public bool get_selectable() { }

	// RVA: 0x1530B78
	public void set_selectable(bool value) { }

	// RVA: 0x1530B80
	public int get_selectedFaceCount() { }

	// RVA: 0x1530BA0
	public int get_selectedVertexCount() { }

	// RVA: 0x1530BC0
	public int get_selectedEdgeCount() { }

	// RVA: 0x1530BE0
	internal int get_selectedSharedVerticesCount() { }

	// RVA: 0x1530FBC
	internal int get_selectedCoincidentVertexCount() { }

	// RVA: 0x1530FE0
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedSharedVertices() { }

	// RVA: 0x1531004
	internal System.Collections.Generic.IEnumerable<System.Int32> get_selectedCoincidentVertices() { }

	// RVA: 0x1530C04
	private void CacheSelection() { }

	// RVA: 0x1531028
	public Face[] GetSelectedFaces() { }

	// RVA: 0x1531144
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_selectedFaceIndexes() { }

	// RVA: 0x15311C4
	public System.Collections.ObjectModel.ReadOnlyCollection<System.Int32> get_selectedVertices() { }

	// RVA: 0x1531244
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.ProBuilder.Edge> get_selectedEdges() { }

	// RVA: 0x15312C4
	internal Face[] get_selectedFacesInternal() { }

	// RVA: 0x15312C8
	internal void set_selectedFacesInternal(Face[] value) { }

	// RVA: 0x15313A4
	internal int[] get_selectedFaceIndicesInternal() { }

	// RVA: 0x15313AC
	internal void set_selectedFaceIndicesInternal(int[] value) { }

	// RVA: 0x15313B4
	internal Edge[] get_selectedEdgesInternal() { }

	// RVA: 0x15313BC
	internal void set_selectedEdgesInternal(Edge[] value) { }

	// RVA: 0x15313C4
	internal int[] get_selectedIndexesInternal() { }

	// RVA: 0x15313CC
	internal void set_selectedIndexesInternal(int[] value) { }

	// RVA: 0x15313D4
	internal Face GetActiveFace() { }

	// RVA: 0x1531434
	internal Edge GetActiveEdge() { }

	// RVA: 0x15314D8
	internal int GetActiveVertex() { }

	// RVA: 0x1531518
	internal void AddToFaceSelection(int index) { }

	// RVA: 0x15317EC
	public void SetSelectedFaces(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> selected) { }

	// RVA: 0x1531594
	internal void SetSelectedFaces(System.Collections.Generic.IEnumerable<System.Int32> selected) { }

	// RVA: 0x15318B4
	public void SetSelectedEdges(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1531A18
	public void SetSelectedVertices(System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x1531BAC
	internal void RemoveFromFaceSelectionAtIndex(int index) { }

	// RVA: 0x152BCA0
	public void ClearSelection() { }

	// RVA: 0x1531C14
	public void .ctor() { }

	// RVA: 0x1531D80
	private static void .cctor() { }

	// RVA: 0x1531E14
	private int <set_selectedFacesInternal>b__231_0(Face x) { }

	// RVA: 0x1531E70
	private int <SetSelectedFaces>b__245_0(Face x) { }

	// RVA: 0x1531ECC
	private System.Collections.Generic.IEnumerable<System.Int32> <SetSelectedFaces>b__246_0(int x) { }

	// RVA: 0x1531F08
	private System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <SetSelectedFaces>b__246_1(int x) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class ProBuilderSnapping
{
	// Fields
	private const float k_MaxRaySnapDistance = inf;

	// Methods

	// RVA: 0x15320E4
	internal static bool IsCardinalDirection(Vector3 direction) { }

	// RVA: 0x1532364
	public static float Snap(float val, float snap) { }

	// RVA: 0x1532438
	public static Vector3 Snap(Vector3 val, Vector3 snap) { }

	// RVA: 0x1532678
	public static void SnapVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, Vector3 snap) { }

	// RVA: 0x1532A20
	internal static Vector3 GetSnappingMaskBasedOnNormalVector(Vector3 normal) { }

	// RVA: 0x1532B00
	internal static Vector3 SnapValueOnRay(Ray ray, float distance, float snap, Vector3Mask mask) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ProGridsNoSnapAttribute
{
	// Methods

	// RVA: 0x1533288
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class ProGridsConditionalSnapAttribute
{
	// Methods

	// RVA: 0x1533290
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

	// RVA: 0x1536444
	private static void .cctor() { }

	// RVA: 0x15364B0
	public void .ctor() { }

	// RVA: 0x15364B8
	internal int <Sort>b__6_0(UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> a, UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> b) { }

	// RVA: 0x153661C
	internal Vector2 <Sort>b__6_1(UnityEngine.ProBuilder.SimpleTuple<System.Single,UnityEngine.Vector2> x) { }

}

// Namespace: UnityEngine.ProBuilder
public static class Projection
{
	// Methods

	// RVA: 0x1533298
	public static Vector2[] PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1533C64
	public static Vector2[] PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Vector3 direction) { }

	// RVA: 0x1533E2C
	internal static void PlanarProject(System.Collections.Generic.IList<UnityEngine.Vector3> positions, System.Collections.Generic.IList<System.Int32> indexes, Vector3 direction, System.Collections.Generic.List<UnityEngine.Vector2> results) { }

	// RVA: 0x15347E4
	internal static void PlanarProject(ProBuilderMesh mesh, int textureGroup, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1534EC0
	internal static void PlanarProject(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x15353B8
	internal static Vector2[] SphericalProject(System.Collections.Generic.IList<UnityEngine.Vector3> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x153581C
	internal static System.Collections.Generic.IList<UnityEngine.Vector2> Sort(System.Collections.Generic.IList<UnityEngine.Vector2> verts, SortMethod method) { }

	// RVA: 0x1534710
	internal static Vector3 GetTangentToAxis(ProjectionAxis axis) { }

	// RVA: 0x1535CD0
	internal static Vector3 ProjectionAxisToVector(ProjectionAxis axis) { }

	// RVA: 0x15345C0
	internal static ProjectionAxis VectorToProjectionAxis(Vector3 direction) { }

	// RVA: 0x15332C4
	public static Plane FindBestPlane(System.Collections.Generic.IList<UnityEngine.Vector3> points, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1535EC8
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

	// RVA: 0x15366EC
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

	// RVA: 0x1536764
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<System.Int32>> PickVerticesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x1537EAC
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> PickFacesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x1539A10
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Edge>> PickEdgesInRect(Camera cam, Rect rect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selectable, PickerOptions options, float pixelsPerPoint) { }

	// RVA: 0x153B118
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

	// RVA: 0x153B1C4
	public bool get_depthTest() { }

	// RVA: 0x153B1CC
	public void set_depthTest(bool value) { }

	// RVA: 0x153B1D4
	public RectSelectMode get_rectSelectMode() { }

	// RVA: 0x153B1DC
	public void set_rectSelectMode(RectSelectMode value) { }

	// RVA: 0x153B1E4
	public static PickerOptions get_Default() { }

	// RVA: 0x153B260
	public override bool Equals(object obj) { }

	// RVA: 0x153B390
	public bool Equals(PickerOptions other) { }

	// RVA: 0x153B440
	public override int GetHashCode() { }

	// RVA: 0x153B518
	public static bool op_Equality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x153B648
	public static bool op_Inequality(PickerOptions a, PickerOptions b) { }

	// RVA: 0x153B778
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

	// RVA: 0x153DF54
	public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

	// RVA: 0x153DF5C
	public void .ctor() { }

}

// Namespace: 
internal class SelectionPickerRendererStandard
{
	// Methods

	// RVA: 0x153DF64
	public Texture2D RenderLookupTexture(Camera camera, Shader shader, string tag, int width, int height) { }

	// RVA: 0x153E328
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

	// RVA: 0x153E330
	private static void .cctor() { }

	// RVA: 0x153E39C
	public void .ctor() { }

	// RVA: 0x153E3A4
	internal System.Collections.Generic.IEnumerable<System.Int32> <GenerateFacePickingObjects>b__24_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass19_0
{
	// Fields
	public Vector3[] positions; // 0x10
	public SharedVertex[] sharedVertices; // 0x18

	// Methods

	// RVA: 0x153E3C0
	public void .ctor() { }

	// RVA: 0x153E3C8
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

	// RVA: 0x153B7C8
	private static RenderTextureFormat get_renderTextureFormat() { }

	// RVA: 0x153B950
	private static TextureFormat get_textureFormat() { }

	// RVA: 0x153B958
	private static ISelectionPickerRenderer get_pickerRenderer() { }

	// RVA: 0x15390C0
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> PickFacesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x1536E28
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<System.Int32>> PickVerticesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x153A3E0
	public static System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.ProBuilderMesh,System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Edge>> PickEdgesInRect(Camera camera, Rect pickerRect, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, int renderTextureWidth, int renderTextureHeight) { }

	// RVA: 0x153BA74
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Face>>& map, int width, int height) { }

	// RVA: 0x153BCE4
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>>& map, int width, int height) { }

	// RVA: 0x153BFE0
	internal static Texture2D RenderSelectionPickerTexture(Camera camera, System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>>& map, int width, int height) { }

	// RVA: 0x153C2DC
	private static GameObject[] GenerateFacePickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Face>>& map) { }

	// RVA: 0x153C8A8
	private static void GenerateVertexPickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>>& map, GameObject[] depthObjects, GameObject[] pickerObjects) { }

	// RVA: 0x153CD38
	private static void GenerateEdgePickingObjects(System.Collections.Generic.IList<UnityEngine.ProBuilder.ProBuilderMesh> selection, bool doDepthTest, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>>& map, GameObject[] depthObjects, GameObject[] pickerObjects) { }

	// RVA: 0x153D1DC
	private static Mesh BuildVertexMesh(ProBuilderMesh pb, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,System.Int32>> map, UInt32 index) { }

	// RVA: 0x153D9A8
	private static Mesh BuildEdgeMesh(ProBuilderMesh pb, System.Collections.Generic.Dictionary<System.UInt32,UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.ProBuilderMesh,UnityEngine.ProBuilder.Edge>> map, UInt32 index) { }

	// RVA: 0x153BCD0
	public static UInt32 DecodeRGBA(Color32 color) { }

	// RVA: 0x153D1C8
	public static Color32 EncodeRGBA(UInt32 hash) { }

	// RVA: 0x153BA6C
	private static bool ShouldUseHDRP() { }

	// RVA: 0x153DE84
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

	// RVA: 0x153E5C0
	public System.Collections.Generic.List<System.Int32> get_vertexes() { }

	// RVA: 0x153E5C8
	public void set_vertexes(System.Collections.Generic.List<System.Int32> value) { }

	// RVA: 0x153E5D0
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> get_edges() { }

	// RVA: 0x153E5D8
	public void set_edges(System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> value) { }

	// RVA: 0x153E5E0
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Face> get_faces() { }

	// RVA: 0x153E5E8
	public void set_faces(System.Collections.Generic.List<UnityEngine.ProBuilder.Face> value) { }

	// RVA: 0x153E5F0
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x153E740
	public void .ctor(ProBuilderMesh mesh, int vertex) { }

	// RVA: 0x153E994
	public void .ctor(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x153EBE8
	public void .ctor(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x153E80C
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> vertexes) { }

	// RVA: 0x153EA60
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x153ECA4
	internal void .ctor(ProBuilderMesh mesh, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x153EE2C
	public void SetSingleFace(Face face) { }

	// RVA: 0x153EEF8
	public void SetSingleVertex(int vertex) { }

	// RVA: 0x153EFD4
	public void SetSingleEdge(Edge edge) { }

	// RVA: 0x153F0B0
	public void Clear() { }

	// RVA: 0x153F244
	public void CopyTo(SceneSelection dst) { }

	// RVA: 0x153F458
	public override string ToString() { }

	// RVA: 0x153F6EC
	public bool Equals(SceneSelection other) { }

	// RVA: 0x153F7F4
	public override bool Equals(object obj) { }

	// RVA: 0x153F920
	public override int GetHashCode() { }

	// RVA: 0x153FAD8
	public static bool op_Equality(SceneSelection left, SceneSelection right) { }

	// RVA: 0x153FAE0
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

	// RVA: 0x153FAFC
	public static System.Collections.Generic.List<System.Int32> GetPath(ProBuilderMesh mesh, int start, int end) { }

	// RVA: 0x153FF70
	private static int[] Dijkstra(ProBuilderMesh mesh, int start) { }

	// RVA: 0x1540720
	private static float GetWeight(int face1, int face2, ProBuilderMesh mesh) { }

	// RVA: 0x153FE30
	private static System.Collections.Generic.List<System.Int32> GetMinimalPath(int[] predecessors, int start, int end) { }

	// RVA: 0x1540B78
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

	// RVA: 0x1540C0C
	public int get_major() { }

	// RVA: 0x1540C14
	public int get_minor() { }

	// RVA: 0x1540C1C
	public int get_patch() { }

	// RVA: 0x1540C24
	public int get_build() { }

	// RVA: 0x1540C2C
	public string get_type() { }

	// RVA: 0x1540C88
	public string get_metadata() { }

	// RVA: 0x1540CE4
	public string get_date() { }

	// RVA: 0x1540D40
	public SemVer get_MajorMinorPatch() { }

	// RVA: 0x1540E8C
	public void .ctor() { }

	// RVA: 0x1540EF0
	public void .ctor(string formatted, string date) { }

	// RVA: 0x1540DF8
	public void .ctor(int major, int minor, int patch, int build, string type, string date, string metadata) { }

	// RVA: 0x1541460
	public bool IsValid() { }

	// RVA: 0x1541490
	public override bool Equals(object o) { }

	// RVA: 0x1541760
	public override int GetHashCode() { }

	// RVA: 0x1541510
	public bool Equals(SemVer version) { }

	// RVA: 0x154194C
	public int CompareTo(object obj) { }

	// RVA: 0x1541BA8
	private static int WrapNoValue(int value) { }

	// RVA: 0x15419CC
	public int CompareTo(SemVer version) { }

	// RVA: 0x1541BB8
	public static bool op_Equality(SemVer left, SemVer right) { }

	// RVA: 0x1541BCC
	public static bool op_Inequality(SemVer left, SemVer right) { }

	// RVA: 0x1541BF8
	public static bool op_LessThan(SemVer left, SemVer right) { }

	// RVA: 0x1541C20
	public static bool op_GreaterThan(SemVer left, SemVer right) { }

	// RVA: 0x1541C40
	public static bool op_LessThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x1541C94
	public static bool op_GreaterThanOrEqual(SemVer left, SemVer right) { }

	// RVA: 0x1541CFC
	public string ToString(string format) { }

	// RVA: 0x1541EE0
	public override string ToString() { }

	// RVA: 0x1540FDC
	public static bool TryGetVersionInfo(string input, SemVer version) { }

	// RVA: 0x154211C
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

	// RVA: 0x1542228
	public static ProBuilderMesh Instantiate(Type shapeType, PivotLocation pivotType) { }

	// RVA: 0x15424FC
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

	// RVA: 0x1542768
	public static ProBuilderMesh CreateShape(ShapeType shape, PivotLocation pivotType) { }

	// RVA: 0x15430D0
	public static ProBuilderMesh GenerateStair(PivotLocation pivotType, Vector3 size, int steps, bool buildSides) { }

	// RVA: 0x1543B98
	public static ProBuilderMesh GenerateCurvedStair(PivotLocation pivotType, float stairWidth, float height, float innerRadius, float circumference, int steps, bool buildSides) { }

	// RVA: 0x1549AE0
	internal static ProBuilderMesh GenerateStair(PivotLocation pivotType, int steps, float width, float height, float depth, bool sidesGoToFloor, bool generateBack, bool platformsOnly) { }

	// RVA: 0x1542DD8
	public static ProBuilderMesh GenerateCube(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x1545018
	public static ProBuilderMesh GenerateCylinder(PivotLocation pivotType, int axisDivisions, float radius, float height, int heightCuts, int smoothing) { }

	// RVA: 0x1544A2C
	public static ProBuilderMesh GeneratePrism(PivotLocation pivotType, Vector3 size) { }

	// RVA: 0x1546358
	public static ProBuilderMesh GenerateDoor(PivotLocation pivotType, float totalWidth, float totalHeight, float ledgeHeight, float legWidth, float depth) { }

	// RVA: 0x15459CC
	public static ProBuilderMesh GeneratePlane(PivotLocation pivotType, float width, float height, int widthCuts, int heightCuts, Axis axis) { }

	// RVA: 0x1546F60
	public static ProBuilderMesh GeneratePipe(PivotLocation pivotType, float radius, float height, float thickness, int subdivAxis, int subdivHeight) { }

	// RVA: 0x15477D0
	public static ProBuilderMesh GenerateCone(PivotLocation pivotType, float radius, float height, int subdivAxis) { }

	// RVA: 0x1548088
	public static ProBuilderMesh GenerateArch(PivotLocation pivotType, float angle, float radius, float width, float depth, int radialCuts, bool insideFaces, bool outsideFaces, bool frontFaces, bool backFaces, bool endCaps) { }

	// RVA: 0x154891C
	public static ProBuilderMesh GenerateIcosahedron(PivotLocation pivotType, float radius, int subdivisions, bool weldVertices, bool manualUvs) { }

	// RVA: 0x154A10C
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x154AD9C
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x1549464
	public static ProBuilderMesh GenerateTorus(PivotLocation pivotType, int rows, int columns, float innerRadius, float outerRadius, bool smooth, float horizontalCircumference, float verticalCircumference, bool manualUvs) { }

	// RVA: 0x154B17C
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

	// RVA: 0x154D1D0
	private static void .cctor() { }

	// RVA: 0x154D23C
	public void .ctor() { }

	// RVA: 0x154D244
	internal bool <SortedRemoveAndShift>b__26_0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder
[Serializable]
public sealed class SharedVertex
{
	// Fields
	private int[] m_Vertices; // 0x10

	// Methods

	// RVA: 0x154B49C
	internal int[] get_arrayInternal() { }

	// RVA: 0x154A66C
	public void .ctor(System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x154B4A4
	public void .ctor(SharedVertex sharedVertex) { }

	// RVA: 0x153E4E0
	public int get_Item(int i) { }

	// RVA: 0x154B5A8
	public void set_Item(int i, int value) { }

	// RVA: 0x154B5DC
	public System.Collections.Generic.IEnumerator<System.Int32> GetEnumerator() { }

	// RVA: 0x154B690
	public override string ToString() { }

	// RVA: 0x154B6FC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x154B7B0
	public void Add(int item) { }

	// RVA: 0x154B82C
	public void Clear() { }

	// RVA: 0x154B890
	public bool Contains(int item) { }

	// RVA: 0x154B904
	public void CopyTo(int[] array, int arrayIndex) { }

	// RVA: 0x154B924
	public bool Remove(int item) { }

	// RVA: 0x154B588
	public int get_Count() { }

	// RVA: 0x154B9D4
	public bool get_IsReadOnly() { }

	// RVA: 0x154B9F4
	public static void GetSharedVertexLookup(System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x154BEB0
	internal void ShiftIndexes(int offset) { }

	// RVA: 0x154BF40
	internal static SharedVertex[] ToSharedVertices(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> lookup) { }

	// RVA: 0x154C818
	private static SharedVertex[] ToSharedVertices(System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> list) { }

	// RVA: 0x154A72C
	public static SharedVertex[] GetSharedVerticesWithPositions(System.Collections.Generic.IList<UnityEngine.Vector3> positions) { }

	// RVA: 0x154C990
	internal static SharedVertex[] RemoveAndShift(System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup, System.Collections.Generic.IEnumerable<System.Int32> remove) { }

	// RVA: 0x154CA44
	internal static SharedVertex[] SortedRemoveAndShift(System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup, System.Collections.Generic.List<System.Int32> remove) { }

	// RVA: 0x154CEB4
	internal static void SetCoincident(System.Collections.Generic.Dictionary<System.Int32,System.Int32>& lookup, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

}

// Namespace: UnityEngine.ProBuilder
public struct SimpleTuple<T0, T1>
{
	// Fields
	private T1 m_Item1; // 0x0
	private T2 m_Item2; // 0x0

	// Methods

	// RVA: 0x318DB98
	public T1 get_item1() { }

	// RVA: 0x318DB98
	public void set_item1(T1 value) { }

	// RVA: 0x318DB98
	public T2 get_item2() { }

	// RVA: 0x318DB98
	public void set_item2(T2 value) { }

	// RVA: 0x318DB98
	public void .ctor(T1 item1, T2 item2) { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x318DB98
	public T1 get_item1() { }

	// RVA: 0x318DB98
	public void set_item1(T1 value) { }

	// RVA: 0x318DB98
	public T2 get_item2() { }

	// RVA: 0x318DB98
	public void set_item2(T2 value) { }

	// RVA: 0x318DB98
	public T3 get_item3() { }

	// RVA: 0x318DB98
	public void set_item3(T3 value) { }

	// RVA: 0x318DB98
	public void .ctor(T1 item1, T2 item2, T3 item3) { }

	// RVA: 0x30D3CF0
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

	// RVA: 0x154E89C
	private static void .cctor() { }

	// RVA: 0x154E908
	public void .ctor() { }

	// RVA: 0x154E910
	internal int <GetUnusedSmoothingGroup>b__5_0(Face x) { }

	// RVA: 0x154E92C
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

	// RVA: 0x154D318
	public static int GetUnusedSmoothingGroup(ProBuilderMesh mesh) { }

	// RVA: 0x154D5A4
	private static int GetNextUnusedSmoothingGroup(int start, System.Collections.Generic.HashSet<System.Int32> used) { }

	// RVA: 0x154D670
	public static bool IsSmooth(int index) { }

	// RVA: 0x154D684
	public static void ApplySmoothingGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float angleThreshold) { }

	// RVA: 0x154D68C
	internal static void ApplySmoothingGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float angleThreshold, Vector3[] normals) { }

	// RVA: 0x154E0E8
	private static bool FindSoftEdgesRecursive(Vector3[] normals, WingedEdge wing, float angleThreshold, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> processed) { }

	// RVA: 0x154E45C
	private static bool IsSoftEdge(Vector3[] normals, EdgeLookup left, EdgeLookup right, float threshold) { }

}

// Namespace: UnityEngine.ProBuilder
internal static class Spline
{
	// Methods

	// RVA: 0x154E948
	internal static ProBuilderMesh Extrude(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> points, float radius, int columns, int rows, bool closeLoop, bool smooth) { }

	// RVA: 0x154EA28
	internal static void Extrude(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> bezierPoints, float radius, int columns, int rows, bool closeLoop, bool smooth, ProBuilderMesh target) { }

	// RVA: 0x154EB00
	internal static System.Collections.Generic.List<UnityEngine.Vector3> GetControlPoints(System.Collections.Generic.IList<UnityEngine.ProBuilder.BezierPoint> bezierPoints, int subdivisionsPerSegment, bool closeLoop, System.Collections.Generic.List<UnityEngine.Quaternion> rotations) { }

	// RVA: 0x154EFC4
	internal static void Extrude(System.Collections.Generic.IList<UnityEngine.Vector3> points, float radius, int radiusRows, bool closeLoop, bool smooth, ProBuilderMesh target, System.Collections.Generic.IList<UnityEngine.Quaternion> pointRotations) { }

	// RVA: 0x154FA48
	private static Quaternion GetRingRotation(System.Collections.Generic.IList<UnityEngine.Vector3> points, int i, bool closeLoop, float secant) { }

	// RVA: 0x155032C
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

	// RVA: 0x1550510
	public System.Collections.Generic.IEnumerable<System.Int32> get_indexes() { }

	// RVA: 0x1550590
	public void set_indexes(System.Collections.Generic.IEnumerable<System.Int32> value) { }

	// RVA: 0x15505F8
	public MeshTopology get_topology() { }

	// RVA: 0x1550600
	public void set_topology(MeshTopology value) { }

	// RVA: 0x1550608
	public int get_submeshIndex() { }

	// RVA: 0x1550610
	public void set_submeshIndex(int value) { }

	// RVA: 0x1550618
	public void .ctor(int submeshIndex, MeshTopology topology, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x15506F0
	public void .ctor(Mesh mesh, int subMeshIndex) { }

	// RVA: 0x155082C
	public override string ToString() { }

	// RVA: 0x1550940
	internal static int GetSubmeshCount(ProBuilderMesh mesh) { }

	// RVA: 0x15509A4
	public static Submesh[] GetSubmeshes(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, int submeshCount, MeshTopology preferredTopology) { }

	// RVA: 0x1551430
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

	// RVA: 0x155158C
	public void .ctor(Vector2 position, float rotation, Vector2 scale) { }

	// RVA: 0x15515E8
	public Vector2 TransformPoint(Vector2 p) { }

	// RVA: 0x1551658
	public override string ToString() { }

}

// Namespace: UnityEngine.ProBuilder
public static class TransformUtility
{
	// Fields
	private static System.Collections.Generic.Dictionary<UnityEngine.Transform,UnityEngine.Transform[]> s_ChildStack; // 0x0

	// Methods

	// RVA: 0x155180C
	internal static void UnparentChildren(Transform t) { }

	// RVA: 0x155198C
	internal static void ReparentChildren(Transform t) { }

	// RVA: 0x1551ADC
	public static Vertex TransformVertex(Transform transform, Vertex vertex) { }

	// RVA: 0x1551CE0
	public static Vertex InverseTransformVertex(Transform transform, Vertex vertex) { }

	// RVA: 0x1551EDC
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

	// RVA: 0x1551F78
	public int get_a() { }

	// RVA: 0x1551F80
	public int get_b() { }

	// RVA: 0x1551F88
	public int get_c() { }

	// RVA: 0x1551F90
	public System.Collections.Generic.IEnumerable<System.Int32> get_indices() { }

	// RVA: 0x1552024
	public void .ctor(int a, int b, int c) { }

	// RVA: 0x1552030
	public bool Equals(Triangle other) { }

	// RVA: 0x1552064
	public override bool Equals(object obj) { }

	// RVA: 0x1552114
	public override int GetHashCode() { }

	// RVA: 0x1552134
	public bool IsAdjacent(Triangle other) { }

	// RVA: 0x15521F0
	private bool ContainsEdge(Edge edge) { }

}

// Namespace: UnityEngine.ProBuilder
internal sealed class TriggerBehaviour
{
	// Methods

	// RVA: 0x1552348
	public override void Initialize() { }

	// RVA: 0x1552528
	public override void OnEnterPlayMode() { }

	// RVA: 0x15525AC
	public override void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x1552630
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

	// RVA: 0x1552638
	public float get_hardAngle() { }

	// RVA: 0x1552640
	public void set_hardAngle(float value) { }

	// RVA: 0x1552648
	public float get_packMargin() { }

	// RVA: 0x1552650
	public void set_packMargin(float value) { }

	// RVA: 0x1552658
	public float get_angleError() { }

	// RVA: 0x1552660
	public void set_angleError(float value) { }

	// RVA: 0x1552668
	public float get_areaError() { }

	// RVA: 0x1552670
	public void set_areaError(float value) { }

	// RVA: 0x1549EA0
	public void .ctor() { }

	// RVA: 0x1552688
	public void .ctor(UnwrapParameters other) { }

	// RVA: 0x1552678
	public void Reset() { }

	// RVA: 0x1552710
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

	// RVA: 0x1554F20
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

	// RVA: 0x155508C
	private static void .cctor() { }

	// RVA: 0x15550F8
	public void .ctor() { }

	// RVA: 0x1555100
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

	// RVA: 0x15528F0
	internal static void SetAutoUV(ProBuilderMesh mesh, Face[] faces, bool auto) { }

	// RVA: 0x1552A94
	internal static void SetAutoAndAlignUnwrapParamsToUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> facesToConvert) { }

	// RVA: 0x1553304
	internal static AutoUnwrapSettings GetAutoUnwrapSettings(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x155340C
	internal static UVTransform GetUVTransform(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1553518
	private static int GetIndex(System.Collections.Generic.IList<System.Int32> collection, int index) { }

	// RVA: 0x1552C78
	internal static UVTransform CalculateDelta(System.Collections.Generic.IList<UnityEngine.Vector2> src, System.Collections.Generic.IList<System.Int32> srcIndices, System.Collections.Generic.IList<UnityEngine.Vector2> dst, System.Collections.Generic.IList<System.Int32> dstIndices) { }

	// RVA: 0x15535D8
	private static Vector2 GetRotatedSize(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.IList<System.Int32> indices, Vector2 center, float rotation) { }

	// RVA: 0x1549EE4
	internal static void Unwrap(ProBuilderMesh mesh, Face face, Vector3 projection) { }

	// RVA: 0x154A030
	internal static void CopyUVs(ProBuilderMesh mesh, Face source, Face dest) { }

	// RVA: 0x1554444
	internal static void ProjectTextureGroup(ProBuilderMesh mesh, int group, AutoUnwrapSettings unwrapSettings) { }

	// RVA: 0x1553A20
	private static void ApplyUVSettings(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, AutoUnwrapSettings uvSettings) { }

	// RVA: 0x1554628
	private static void ScaleUVs(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, Vector2 scale, Bounds2D bounds) { }

	// RVA: 0x1554880
	private static void ApplyUVAnchor(Vector2[] uvs, System.Collections.Generic.IList<System.Int32> indexes, Anchor anchor) { }

	// RVA: 0x1554CB8
	internal static void UpgradeAutoUVScaleOffset(ProBuilderMesh mesh) { }

	// RVA: 0x1554DE4
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
internal static class VectorHash
{
	// Fields
	public const float FltCompareResolution = 1000;

	// Methods

	// RVA: 0x155511C
	private static int HashFloat(float f) { }

	// RVA: 0x155515C
	public static int GetHashCode(Vector2 v) { }

	// RVA: 0x153E514
	public static int GetHashCode(Vector3 v) { }

	// RVA: 0x15551D8
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

	// RVA: 0x15552B8
	public float get_x() { }

	// RVA: 0x15552D0
	public float get_y() { }

	// RVA: 0x15552E8
	public void .ctor(Vector3 v, float epsilon) { }

	// RVA: 0x155530C
	public void .ctor(Byte mask) { }

	// RVA: 0x1555314
	public static Vector2 op_Implicit(Vector2Mask mask) { }

	// RVA: 0x1555388
	public static Vector2Mask op_Implicit(Vector2 v) { }

	// RVA: 0x15553B0
	public static Vector2Mask op_BitwiseOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x15553B8
	public static Vector2Mask op_BitwiseAnd(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x15553C0
	public static Vector2Mask op_ExclusiveOr(Vector2Mask left, Vector2Mask right) { }

	// RVA: 0x15553C8
	public static Vector2 op_Multiply(Vector2Mask mask, float value) { }

	// RVA: 0x1555450
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

	// RVA: 0x15554A0
	public float get_x() { }

	// RVA: 0x15554B8
	public float get_y() { }

	// RVA: 0x15554D0
	public float get_z() { }

	// RVA: 0x15554E8
	public void .ctor(Vector3 v, float epsilon) { }

	// RVA: 0x155551C
	public void .ctor(Byte mask) { }

	// RVA: 0x1555524
	public override string ToString() { }

	// RVA: 0x155563C
	public int get_active() { }

	// RVA: 0x1555658
	public static Vector3 op_Implicit(Vector3Mask mask) { }

	// RVA: 0x15556D4
	public static Vector3Mask op_Explicit(Vector3 v) { }

	// RVA: 0x155570C
	public static Vector3Mask op_BitwiseOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1555714
	public static Vector3Mask op_BitwiseAnd(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x155571C
	public static Vector3Mask op_ExclusiveOr(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1555724
	public static Vector3 op_Multiply(Vector3Mask mask, float value) { }

	// RVA: 0x15557B8
	public static Vector3 op_Multiply(Vector3Mask mask, Vector3 value) { }

	// RVA: 0x155585C
	public static Vector3 op_Multiply(Quaternion rotation, Vector3Mask mask) { }

	// RVA: 0x1555A74
	public static bool op_Equality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1555A84
	public static bool op_Inequality(Vector3Mask left, Vector3Mask right) { }

	// RVA: 0x1555AF0
	public float get_Item(int i) { }

	// RVA: 0x1555B54
	public void set_Item(int i, float value) { }

	// RVA: 0x1555BCC
	public bool Equals(Vector3Mask other) { }

	// RVA: 0x1555BDC
	public override bool Equals(object obj) { }

	// RVA: 0x1555CAC
	public override int GetHashCode() { }

	// RVA: 0x1555CB4
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

	// RVA: 0x1555D04
	public Vector3 get_position() { }

	// RVA: 0x1555D10
	public void set_position(Vector3 value) { }

	// RVA: 0x1555D3C
	public Color get_color() { }

	// RVA: 0x1555D48
	public void set_color(Color value) { }

	// RVA: 0x1555D80
	public Vector3 get_normal() { }

	// RVA: 0x1555D8C
	public void set_normal(Vector3 value) { }

	// RVA: 0x1555DC4
	public Vector4 get_tangent() { }

	// RVA: 0x1555DD0
	public void set_tangent(Vector4 value) { }

	// RVA: 0x1555E08
	public Vector2 get_uv0() { }

	// RVA: 0x1555E10
	public void set_uv0(Vector2 value) { }

	// RVA: 0x1555E44
	public Vector2 get_uv2() { }

	// RVA: 0x1555E4C
	public void set_uv2(Vector2 value) { }

	// RVA: 0x1555E80
	public Vector4 get_uv3() { }

	// RVA: 0x1555E8C
	public void set_uv3(Vector4 value) { }

	// RVA: 0x1555EC4
	public Vector4 get_uv4() { }

	// RVA: 0x1555ED0
	public void set_uv4(Vector4 value) { }

	// RVA: 0x1555F08
	internal MeshArrays get_attributes() { }

	// RVA: 0x1555F10
	public bool HasArrays(MeshArrays attribute) { }

	// RVA: 0x1555F20
	private bool get_hasPosition() { }

	// RVA: 0x1555D28
	private void set_hasPosition(bool value) { }

	// RVA: 0x1555F2C
	private bool get_hasColor() { }

	// RVA: 0x1555D60
	private void set_hasColor(bool value) { }

	// RVA: 0x1555F38
	private bool get_hasNormal() { }

	// RVA: 0x1555DA4
	private void set_hasNormal(bool value) { }

	// RVA: 0x1555F44
	private bool get_hasTangent() { }

	// RVA: 0x1555DE8
	private void set_hasTangent(bool value) { }

	// RVA: 0x1555F50
	private bool get_hasUV0() { }

	// RVA: 0x1555E24
	private void set_hasUV0(bool value) { }

	// RVA: 0x1555F5C
	private bool get_hasUV2() { }

	// RVA: 0x1555E60
	private void set_hasUV2(bool value) { }

	// RVA: 0x1555F68
	private bool get_hasUV3() { }

	// RVA: 0x1555EA4
	private void set_hasUV3(bool value) { }

	// RVA: 0x1555F74
	private bool get_hasUV4() { }

	// RVA: 0x1555EE8
	private void set_hasUV4(bool value) { }

	// RVA: 0x1555F80
	public void .ctor() { }

	// RVA: 0x1555F88
	public override bool Equals(object obj) { }

	// RVA: 0x1556008
	public bool Equals(Vertex other) { }

	// RVA: 0x1556158
	public bool Equals(Vertex other, MeshArrays mask) { }

	// RVA: 0x155630C
	public override int GetHashCode() { }

	// RVA: 0x155637C
	public void .ctor(Vertex vertex) { }

	// RVA: 0x15564C0
	public static bool op_Equality(Vertex a, Vertex b) { }

	// RVA: 0x15564E8
	public static bool op_Inequality(Vertex a, Vertex b) { }

	// RVA: 0x1556524
	public static Vertex op_Addition(Vertex a, Vertex b) { }

	// RVA: 0x15565A0
	public static Vertex Add(Vertex a, Vertex b) { }

	// RVA: 0x155661C
	public void Add(Vertex b) { }

	// RVA: 0x155671C
	public static Vertex op_Subtraction(Vertex a, Vertex b) { }

	// RVA: 0x1556798
	public static Vertex Subtract(Vertex a, Vertex b) { }

	// RVA: 0x1556814
	public void Subtract(Vertex b) { }

	// RVA: 0x1556914
	public static Vertex op_Multiply(Vertex a, float value) { }

	// RVA: 0x1556918
	public static Vertex Multiply(Vertex a, float value) { }

	// RVA: 0x15569D4
	public void Multiply(float value) { }

	// RVA: 0x1556A18
	public static Vertex op_Division(Vertex a, float value) { }

	// RVA: 0x1556A1C
	public static Vertex Divide(Vertex a, float value) { }

	// RVA: 0x1556AD8
	public void Divide(float value) { }

	// RVA: 0x1556B1C
	public void Normalize() { }

	// RVA: 0x1557150
	public string ToString(string args) { }

	// RVA: 0x155746C
	public static void GetArrays(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, Vector3[] position, Color[] color, Vector2[] uv0, Vector3[] normal, Vector4[] tangent, Vector2[] uv2, System.Collections.Generic.List<UnityEngine.Vector4>& uv3, System.Collections.Generic.List<UnityEngine.Vector4>& uv4) { }

	// RVA: 0x1557498
	public static void GetArrays(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, Vector3[] position, Color[] color, Vector2[] uv0, Vector3[] normal, Vector4[] tangent, Vector2[] uv2, System.Collections.Generic.List<UnityEngine.Vector4>& uv3, System.Collections.Generic.List<UnityEngine.Vector4>& uv4, MeshArrays attributes) { }

	// RVA: 0x1557EE0
	public static void SetMesh(Mesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x15581D8
	public static Vertex Average(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1558ED4
	public static Vertex Mix(Vertex x, Vertex y, float weight) { }

}

// Namespace: UnityEngine.ProBuilder
public static class VertexPositioning
{
	// Fields
	private static System.Collections.Generic.List<System.Int32> s_CoincidentVertices; // 0x0

	// Methods

	// RVA: 0x1559204
	public static Vector3[] VerticesInWorldSpace(ProBuilderMesh mesh) { }

	// RVA: 0x15593E0
	public static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset) { }

	// RVA: 0x1559518
	internal static void TranslateVerticesInWorldSpace(ProBuilderMesh mesh, int[] indexes, Vector3 offset, float snapValue, bool snapAxisOnly) { }

	// RVA: 0x1559AE8
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, Vector3 offset) { }

	// RVA: 0x1559DE0
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Vector3 offset) { }

	// RVA: 0x1559F30
	public static void TranslateVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, Vector3 offset) { }

	// RVA: 0x1559C38
	private static void TranslateVerticesInternal(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indices, Vector3 offset) { }

	// RVA: 0x155A080
	public static void SetSharedVertexPosition(ProBuilderMesh mesh, int sharedVertexHandle, Vector3 position) { }

	// RVA: 0x155A434
	internal static void SetSharedVertexValues(ProBuilderMesh mesh, int sharedVertexHandle, Vertex vertex) { }

	// RVA: 0x155A718
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

	// RVA: 0x155CA3C
	private static void .cctor() { }

	// RVA: 0x155CAA8
	public void .ctor() { }

	// RVA: 0x155CAB0
	internal Edge <SortCommonIndexesByAdjacency>b__32_1(WingedEdge y) { }

	// RVA: 0x155CACC
	internal int <SortCommonIndexesByAdjacency>b__32_2(Edge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public System.Collections.Generic.HashSet<System.Int32> common; // 0x10

	// Methods

	// RVA: 0x155BF18
	public void .ctor() { }

	// RVA: 0x155CAD4
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

	// RVA: 0x155A7B4
	public EdgeLookup get_edge() { }

	// RVA: 0x155A7C0
	private void set_edge(EdgeLookup value) { }

	// RVA: 0x155A7C8
	public Face get_face() { }

	// RVA: 0x155A7D0
	private void set_face(Face value) { }

	// RVA: 0x155A7D8
	public WingedEdge get_next() { }

	// RVA: 0x155A7E0
	private void set_next(WingedEdge value) { }

	// RVA: 0x155A7E8
	public WingedEdge get_previous() { }

	// RVA: 0x155A7F0
	private void set_previous(WingedEdge value) { }

	// RVA: 0x155A7F8
	public WingedEdge get_opposite() { }

	// RVA: 0x155A800
	private void set_opposite(WingedEdge value) { }

	// RVA: 0x155A808
	private void .ctor() { }

	// RVA: 0x155A810
	public bool Equals(WingedEdge other) { }

	// RVA: 0x155A8B0
	public override bool Equals(object obj) { }

	// RVA: 0x155AA60
	public override int GetHashCode() { }

	// RVA: 0x155AAD8
	public int Count() { }

	// RVA: 0x155AB10
	public override string ToString() { }

	// RVA: 0x155AD30
	internal static int[] MakeQuad(WingedEdge left, WingedEdge right) { }

	// RVA: 0x155B484
	public WingedEdge GetAdjacentEdgeWithCommonIndex(int common) { }

	// RVA: 0x155B574
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> SortEdgesByAdjacency(Face face) { }

	// RVA: 0x155B690
	public static void SortEdgesByAdjacency(System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x155B864
	public static System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge>> GetSpokes(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings) { }

	// RVA: 0x155BBE4
	internal static System.Collections.Generic.List<System.Int32> SortCommonIndexesByAdjacency(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, System.Collections.Generic.HashSet<System.Int32> common) { }

	// RVA: 0x155BF20
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetWingedEdges(ProBuilderMesh mesh, bool oneWingPerFace) { }

	// RVA: 0x155C038
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetWingedEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool oneWingPerFace) { }

	// RVA: 0x155C9A0
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder
public sealed class WingedEdgeEnumerator
{
	// Fields
	private WingedEdge m_Start; // 0x10
	private WingedEdge m_Current; // 0x18

	// Methods

	// RVA: 0x155CB70
	public void .ctor(WingedEdge start) { }

	// RVA: 0x155CBB4
	public bool MoveNext() { }

	// RVA: 0x155CC3C
	public void Reset() { }

	// RVA: 0x155CC48
	public WingedEdge get_Current() { }

	// RVA: 0x155CC50
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x155CC58
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

	// RVA: 0x155CC5C
	public override void CopyShape(Shape shape) { }

	// RVA: 0x155CD0C
	private Vector3[] GetFace(Vector2 vertex1, Vector2 vertex2, float depth) { }

	// RVA: 0x155CDD4
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x155D9E0
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

	// RVA: 0x155DA10
	public override void CopyShape(Shape shape) { }

	// RVA: 0x155DAB8
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x155DC30
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x155E81C
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Cube
{
	// Fields
	private static readonly Vector3[] k_CubeVertices; // 0x0
	private static readonly int[] k_CubeTriangles; // 0x8

	// Methods

	// RVA: 0x155E834
	public override void CopyShape(Shape shape) { }

	// RVA: 0x155E838
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x155EA5C
	public void .ctor() { }

	// RVA: 0x155EA64
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

	// RVA: 0x155EBF4
	public override void CopyShape(Shape shape) { }

	// RVA: 0x155ECE4
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x155ED10
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x155F894
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Door
{
	// Fields
	private float m_DoorHeight; // 0x10
	private float m_LegWidth; // 0x14

	// Methods

	// RVA: 0x155F8AC
	public override void CopyShape(Shape shape) { }

	// RVA: 0x155F974
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15608D0
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

	// RVA: 0x15608E4
	public override void CopyShape(Shape shape) { }

	// RVA: 0x156098C
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x15609B8
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1561554
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Plane
{
	// Fields
	private int m_HeightSegments; // 0x10
	private int m_WidthSegments; // 0x14

	// Methods

	// RVA: 0x1561570
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1561638
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1561930
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Prism
{
	// Methods

	// RVA: 0x1561940
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1561944
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1562088
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

	// RVA: 0x1562090
	public Shape get_shape() { }

	// RVA: 0x1562098
	public void set_shape(Shape value) { }

	// RVA: 0x15620A0
	public PivotLocation get_pivotLocation() { }

	// RVA: 0x15620A8
	public void set_pivotLocation(PivotLocation value) { }

	// RVA: 0x15620B0
	public Vector3 get_pivotLocalPosition() { }

	// RVA: 0x15620BC
	public void set_pivotLocalPosition(Vector3 value) { }

	// RVA: 0x15620C8
	public Vector3 get_pivotGlobalPosition() { }

	// RVA: 0x156228C
	public void set_pivotGlobalPosition(Vector3 value) { }

	// RVA: 0x15622F8
	public Vector3 get_size() { }

	// RVA: 0x1562304
	public void set_size(Vector3 value) { }

	// RVA: 0x1562410
	public Quaternion get_rotation() { }

	// RVA: 0x156241C
	public void set_rotation(Quaternion value) { }

	// RVA: 0x1562428
	public Bounds get_editionBounds() { }

	// RVA: 0x15624E4
	public Bounds get_shapeBox() { }

	// RVA: 0x15624F8
	public bool get_isEditable() { }

	// RVA: 0x1562108
	public ProBuilderMesh get_mesh() { }

	// RVA: 0x156252C
	private void OnValidate() { }

	// RVA: 0x156262C
	internal void UpdateComponent() { }

	// RVA: 0x1562A54
	internal void UpdateBounds(Bounds bounds) { }

	// RVA: 0x1562BC0
	internal void Rebuild(Bounds bounds, Quaternion rotation, Vector3 cornerPivot) { }

	// RVA: 0x156289C
	private void Rebuild() { }

	// RVA: 0x1562FD8
	internal void SetShape(Shape shape, PivotLocation location) { }

	// RVA: 0x1563168
	internal void RotateInsideBounds(Quaternion deltaRotation) { }

	// RVA: 0x156266C
	private void ResetPivot(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1562D88
	internal void RebuildPivot(Vector3 size, Quaternion rotation) { }

	// RVA: 0x1563248
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
[Serializable]
public abstract class Shape
{
	// Methods

	// RVA: 0x1563338
	public virtual Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: -1
	public abstract Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: -1
	public abstract void CopyShape(Shape shape) { }

	// RVA: 0x155DA08
	protected void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class ShapeAttribute
{
	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x1563390
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

	// RVA: 0x15633C4
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1563464
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x15634C8
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1563EDC
	private static Vector3[] SubdivideIcosahedron(Vector3[] vertices, float radius) { }

	// RVA: 0x156443C
	public void .ctor() { }

	// RVA: 0x1564454
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder.Shapes
public class Sprite
{
	// Methods

	// RVA: 0x1564658
	public override void CopyShape(Shape shape) { }

	// RVA: 0x156465C
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1564A14
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

	// RVA: 0x1564A1C
	public bool get_sides() { }

	// RVA: 0x1564A24
	public void set_sides(bool value) { }

	// RVA: 0x1564A2C
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1564AF4
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1566BFC
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x1565C40
	private Bounds BuildStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1564B4C
	private Bounds BuildCurvedStairs(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x1566D5C
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

	// RVA: 0x1566D88
	public override void CopyShape(Shape shape) { }

	// RVA: 0x1566E30
	public override Bounds UpdateBounds(ProBuilderMesh mesh, Vector3 size, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x1566EB4
	public override Bounds RebuildMesh(ProBuilderMesh mesh, Vector3 size, Quaternion rotation) { }

	// RVA: 0x15678AC
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, float offset) { }

	// RVA: 0x1567BE4
	private static Vector3[] GetCirclePoints(int segments, float radius, float circumference, Quaternion rotation, Vector3 offset) { }

	// RVA: 0x1567E58
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

	// RVA: 0x157335C
	private static void .cctor() { }

	// RVA: 0x15733C8
	public void .ctor() { }

	// RVA: 0x15733D0
	internal int <CreateShapeFromPolygon>b__8_0(Vector3[] arr) { }

	// RVA: 0x15733EC
	internal Vector3 <FaceWithVerticesAndHole>b__10_0(Vertex v) { }

	// RVA: 0x157340C
	internal Vector3 <FaceWithVerticesAndHole>b__10_1(Vertex v) { }

	// RVA: 0x157342C
	internal Face <InsertVertexInFace>b__18_0(FaceRebuildData f) { }

}

// Namespace: 
private sealed class <>c__DisplayClass17_0
{
	// Fields
	public int delCount; // 0x10

	// Methods

	// RVA: 0x15708F4
	public void .ctor() { }

	// RVA: 0x1573448
	internal Edge <AppendVerticesToEdge>b__0(EdgeLookup x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class AppendElements
{
	// Methods

	// RVA: 0x156830C
	internal static Face AppendFace(ProBuilderMesh mesh, Vector3[] positions, Color[] colors, Vector2[] uv0s, Vector4[] uv2s, Vector4[] uv3s, Face face, int[] common) { }

	// RVA: 0x1568BB4
	public static Face[] AppendFaces(ProBuilderMesh mesh, Vector3[][] positions, Color[][] colors, Vector2[][] uvs, Face[] faces, Int32[][] shared) { }

	// RVA: 0x15691E8
	public static Face CreatePolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes, bool unordered) { }

	// RVA: 0x15699D0
	public static Face CreatePolygonWithHole(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes, System.Collections.Generic.IList<System.Collections.Generic.IList<System.Int32>> holes) { }

	// RVA: 0x156AABC
	public static ActionResult CreateShapeFromPolygon(PolyShape poly) { }

	// RVA: 0x156AB00
	internal static void ClearAndRefreshMesh(ProBuilderMesh mesh) { }

	// RVA: 0x156AAF8
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals) { }

	// RVA: 0x156B8C8
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals, Vector3 cameraLookAt, System.Collections.Generic.IList<System.Collections.Generic.IList<UnityEngine.Vector3>> holePoints) { }

	// RVA: 0x156AB48
	public static ActionResult CreateShapeFromPolygon(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.Vector3> points, float extrude, bool flipNormals, System.Collections.Generic.IList<System.Collections.Generic.IList<UnityEngine.Vector3>> holePoints) { }

	// RVA: 0x15698E4
	internal static FaceRebuildData FaceWithVertices(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, bool unordered) { }

	// RVA: 0x156A57C
	internal static FaceRebuildData FaceWithVerticesAndHole(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> borderVertices, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>> holes) { }

	// RVA: 0x156BF54
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> TentCapWithVertices(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> path) { }

	// RVA: 0x156B8D0
	public static void DuplicateAndFlip(ProBuilderMesh mesh, Face[] faces) { }

	// RVA: 0x156C1F0
	public static Face Bridge(ProBuilderMesh mesh, Edge a, Edge b, bool allowNonManifoldGeometry) { }

	// RVA: 0x156D93C
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points) { }

	// RVA: 0x156D944
	public static Face AppendVerticesToFace(ProBuilderMesh mesh, Face face, Vector3[] points, bool insertOnEdge) { }

	// RVA: 0x156E7FC
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> AppendVerticesToEdge(ProBuilderMesh mesh, Edge edge, int count) { }

	// RVA: 0x156E888
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> AppendVerticesToEdge(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, int count) { }

	// RVA: 0x1570DCC
	public static Face[] InsertVertexInFace(ProBuilderMesh mesh, Face face, Vector3 point) { }

	// RVA: 0x1571AC0
	public static Vertex InsertVertexOnEdge(ProBuilderMesh mesh, Edge originalEdge, Vector3 point) { }

	// RVA: 0x1572F9C
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

	// RVA: 0x1577458
	private static void .cctor() { }

	// RVA: 0x15774C4
	public void .ctor() { }

	// RVA: 0x15774CC
	internal Face <BevelEdges>b__0_0(FaceRebuildData x) { }

	// RVA: 0x15774E8
	internal int <BevelEdges>b__0_6(UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.FaceRebuildData,System.Collections.Generic.List<System.Int32>> x) { }

	// RVA: 0x15775CC
	internal Face <BevelEdges>b__0_1(FaceRebuildData x) { }

	// RVA: 0x15775E8
	internal Face <BevelEdges>b__0_2(FaceRebuildData x) { }

	// RVA: 0x1577604
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

	// RVA: 0x15766C8
	public void .ctor() { }

	// RVA: 0x1577620
	internal int <BevelEdges>b__7(int x) { }

	// RVA: 0x1577660
	internal int <BevelEdges>b__8(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_1
{
	// Fields
	public EdgeLookup lup; // 0x10

	// Methods

	// RVA: 0x15766D0
	public void .ctor() { }

	// RVA: 0x15776A0
	internal bool <BevelEdges>b__4(WingedEdge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_2
{
	// Fields
	public int c; // 0x10
	public UnityEngine.ProBuilder.MeshOperations.Bevel.<>c__DisplayClass0_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x1577184
	public void .ctor() { }

	// RVA: 0x15776D8
	internal bool <BevelEdges>b__5(WingedEdge x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class Bevel
{
	// Fields
	private static readonly int[] k_BridgeIndexesTri; // 0x0

	// Methods

	// RVA: 0x15734B8
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> BevelEdges(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges, float amount) { }

	// RVA: 0x1576B04
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> GetBridgeFaces(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, WingedEdge left, WingedEdge right, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.FaceRebuildData,System.Collections.Generic.List<System.Int32>>>> holes) { }

	// RVA: 0x15766D8
	private static void SlideEdge(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, WingedEdge we, float amount) { }

	// RVA: 0x15772AC
	private static Edge GetLeadingEdge(WingedEdge wing, int common) { }

	// RVA: 0x15773B4
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

	// RVA: 0x157A914
	private static void .cctor() { }

	// RVA: 0x157A980
	public void .ctor() { }

	// RVA: 0x157A988
	internal int <SplitByMaxVertexCount>b__5_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class CombineMeshes
{
	// Methods

	// RVA: 0x1577844
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> Combine(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes) { }

	// RVA: 0x1577E20
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> Combine(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes, ProBuilderMesh meshTarget) { }

	// RVA: 0x1577848
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> CombineToNewMeshes(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes) { }

	// RVA: 0x1578898
	private static void AccumulateMeshesInfo(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.ProBuilderMesh> meshes, int offset, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex>& vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face>& faces, System.Collections.Generic.List<UnityEngine.ProBuilder.Face>& autoUvFaces, System.Collections.Generic.List<UnityEngine.ProBuilder.SharedVertex>& sharedVertices, System.Collections.Generic.List<UnityEngine.ProBuilder.SharedVertex>& sharedTextures, System.Collections.Generic.List<UnityEngine.Material>& materialMap, Transform targetTransform) { }

	// RVA: 0x1579FE4
	private static ProBuilderMesh CreateMeshFromSplit(System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedVertexLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> sharedTextureLookup, System.Collections.Generic.Dictionary<System.Int32,System.Int32> remap, Material[] materials) { }

	// RVA: 0x15793C0
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.ProBuilderMesh> SplitByMaxVertexCount(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedVertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SharedVertex> sharedTextures, UInt32 maxVertexCount) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal sealed class ConnectFaceRebuildData
{
	// Fields
	public FaceRebuildData faceRebuildData; // 0x10
	public System.Collections.Generic.List<System.Int32> newVertexIndexes; // 0x18

	// Methods

	// RVA: 0x157A9A4
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

	// RVA: 0x15809D0
	private static void .cctor() { }

	// RVA: 0x1580A3C
	public void .ctor() { }

	// RVA: 0x1580A44
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <Connect>b__0_0(Face x) { }

	// RVA: 0x1580A60
	internal int <Connect>b__2_1(Face x) { }

	// RVA: 0x1580A7C
	internal FaceRebuildData <Connect>b__2_2(ConnectFaceRebuildData x) { }

	// RVA: 0x1580A98
	internal int <Connect>b__3_0(Face x) { }

	// RVA: 0x1580AB4
	internal FaceRebuildData <Connect>b__3_1(ConnectFaceRebuildData x) { }

	// RVA: 0x1580AD0
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <Connect>b__3_2(ConnectFaceRebuildData x) { }

	// RVA: 0x1580AFC
	internal Edge <Connect>b__3_4(EdgeLookup x) { }

	// RVA: 0x1580B04
	internal System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> <ConnectEdgesInFace>b__5_0(int x) { }

	// RVA: 0x1580B78
	internal System.Collections.Generic.List<System.Int32> <ConnectEdgesInFace>b__5_1(int x) { }

	// RVA: 0x1580BEC
	internal Edge <ConnectEdgesInFace>b__5_2(WingedEdge x) { }

	// RVA: 0x1580C08
	internal Edge <InsertVertices>b__6_0(WingedEdge x) { }

	// RVA: 0x1580C24
	internal System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> <ConnectIndexesPerFace>b__8_0(int x) { }

	// RVA: 0x1580C98
	internal System.Collections.Generic.List<System.Int32> <ConnectIndexesPerFace>b__8_1(int x) { }

	// RVA: 0x1580D0C
	internal System.Collections.Generic.List<System.Int32> <ConnectIndexesPerFace>b__8_2(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup; // 0x10
	public ProBuilderMesh mesh; // 0x18

	// Methods

	// RVA: 0x157DE50
	public void .ctor() { }

	// RVA: 0x1580D80
	internal int <Connect>b__0(int x) { }

	// RVA: 0x1580DFC
	internal int <Connect>b__3(int x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public System.Collections.Generic.HashSet<System.Int32> appended; // 0x10

	// Methods

	// RVA: 0x15809C8
	public void .ctor() { }

	// RVA: 0x1580E44
	internal bool <Connect>b__3(Edge x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ConnectElements
{
	// Methods

	// RVA: 0x157A9F4
	public static Face[] Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x157C9C4
	public static UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face[],UnityEngine.ProBuilder.Edge[]> Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x157CA58
	public static int[] Connect(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x157ADD8
	internal static ActionResult Connect(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Face[] addedFaces, Edge[] connections, bool returnFaces, bool returnEdges, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> faceMask) { }

	// RVA: 0x15801A0
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectEdgesInFace(Face face, WingedEdge a, WingedEdge b, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x157F738
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectEdgesInFace(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> edges, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices) { }

	// RVA: 0x157F0E0
	private static bool InsertVertices(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> edges, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, ConnectFaceRebuildData data) { }

	// RVA: 0x157E908
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.MeshOperations.ConnectFaceRebuildData> ConnectIndexesPerFace(Face face, int a, int b, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x157DE58
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

	// RVA: 0x15816F8
	private static void .cctor() { }

	// RVA: 0x1581764
	public void .ctor() { }

	// RVA: 0x158176C
	internal System.Collections.Generic.IEnumerable<System.Int32> <DeleteFaces>b__3_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public System.Collections.Generic.List<System.Int32> sorted; // 0x10
	public int[] offset; // 0x18

	// Methods

	// RVA: 0x1580ED8
	public void .ctor() { }

	// RVA: 0x1581788
	internal bool <DeleteVertices>b__0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

	// RVA: 0x1581894
	internal System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> <DeleteVertices>b__1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

	// RVA: 0x1581ADC
	internal bool <DeleteVertices>b__2(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

	// RVA: 0x1581BE8
	internal System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> <DeleteVertices>b__3(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x1580EE0
	public void .ctor() { }

	// RVA: 0x1581E30
	internal int <DeleteFaces>b__0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class DeleteElements
{
	// Methods

	// RVA: 0x15708FC
	public static void DeleteVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> distinctIndexes) { }

	// RVA: 0x156E770
	public static int[] DeleteFace(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x157718C
	public static int[] DeleteFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1580EE8
	public static int[] DeleteFaces(ProBuilderMesh mesh, System.Collections.Generic.IList<System.Int32> faceIndexes) { }

	// RVA: 0x15815A8
	public static int[] RemoveDegenerateTriangles(ProBuilderMesh mesh) { }

	// RVA: 0x1581650
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

	// RVA: 0x15885B8
	private static void .cctor() { }

	// RVA: 0x1588624
	public void .ctor() { }

	// RVA: 0x158862C
	internal System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> <GetPerimeterEdges>b__5_0(Face x) { }

	// RVA: 0x1588648
	internal bool <GetPerimeterEdges>b__5_1(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> x) { }

	// RVA: 0x1588734
	internal Edge <GetPerimeterEdges>b__5_2(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> x) { }

	// RVA: 0x1588830
	internal bool <GetPerimeterFaces>b__7_0(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>> x) { }

	// RVA: 0x158891C
	internal Face <GetPerimeterFaces>b__7_1(System.Collections.Generic.KeyValuePair<UnityEngine.ProBuilder.Edge,System.Collections.Generic.List<UnityEngine.ProBuilder.Face>> x) { }

	// RVA: 0x1588A18
	internal Edge <GetEdgeRing>b__10_0(EdgeLookup x) { }

	// RVA: 0x1588A20
	internal Edge <GetEdgeRingIterative>b__11_0(EdgeLookup x) { }

	// RVA: 0x1588A28
	internal Edge <GetEdgeLoop>b__12_0(EdgeLookup x) { }

	// RVA: 0x1588A30
	internal Edge <GetEdgeLoopIterative>b__13_0(EdgeLookup x) { }

	// RVA: 0x1588A38
	internal Edge <GetEdgeLoopInternal>b__14_0(WingedEdge x) { }

	// RVA: 0x1588A54
	internal Edge <GetEdgeLoopInternalIterative>b__15_0(WingedEdge x) { }

	// RVA: 0x1588A70
	internal Edge <GetEdgeLoopInternalIterative>b__15_1(WingedEdge x) { }

	// RVA: 0x1588A8C
	internal Edge <FindHoles>b__26_0(WingedEdge x) { }

	// RVA: 0x1588AA8
	internal int <FindHoles>b__27_0(UnityEngine.ProBuilder.SimpleTuple<System.Int32,System.Int32> x, UnityEngine.ProBuilder.SimpleTuple<System.Int32,System.Int32> y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass25_0
{
	// Fields
	public Face face; // 0x10

	// Methods

	// RVA: 0x1588BFC
	public void .ctor() { }

	// RVA: 0x1588C04
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

	// RVA: 0x1588C2C
	public void .ctor() { }

	// RVA: 0x1588C34
	internal bool <FindHoles>b__1(WingedEdge w) { }

	// RVA: 0x1588CB0
	internal bool <FindHoles>b__2(WingedEdge w) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ElementSelection
{
	// Fields
	private const int k_MaxHoleIterations = 2048;
	private static readonly Vector3 Vector3_Zero; // 0x0

	// Methods

	// RVA: 0x1581E98
	public static void GetNeighborFaces(ProBuilderMesh mesh, Edge edge, System.Collections.Generic.List<UnityEngine.ProBuilder.Face> neighborFaces) { }

	// RVA: 0x156D634
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Edge>> GetNeighborFaces(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x1582114
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> GetNeighborFaces(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x1582468
	internal static Edge[] GetConnectedEdges(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x1582AE0
	public static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetPerimeterEdges(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x15831B8
	internal static int[] GetPerimeterEdges(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15835EC
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> GetPerimeterFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1583D68
	internal static int[] GetPerimeterVertices(ProBuilderMesh mesh, int[] indexes, Edge[] universal_edges_all) { }

	// RVA: 0x1584160
	private static WingedEdge EdgeRingNext(WingedEdge edge) { }

	// RVA: 0x15841E4
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetEdgeRing(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x15848C4
	internal static System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> GetEdgeRingIterative(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges) { }

	// RVA: 0x1584F5C
	internal static bool GetEdgeLoop(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Edge[] loop) { }

	// RVA: 0x1585678
	internal static bool GetEdgeLoopIterative(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, Edge[] loop) { }

	// RVA: 0x15853F8
	private static bool GetEdgeLoopInternal(WingedEdge start, int startIndex, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> used) { }

	// RVA: 0x15859E8
	private static void GetEdgeLoopInternalIterative(WingedEdge start, Edge edge, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.EdgeLookup> used) { }

	// RVA: 0x15860C0
	private static WingedEdge NextSpoke(WingedEdge wing, int pivot, bool opp) { }

	// RVA: 0x1585DA8
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> GetSpokes(WingedEdge wing, int sharedIndex, bool allowHoles) { }

	// RVA: 0x15861C8
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GrowSelection(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float maxAngleDiff) { }

	// RVA: 0x1586788
	internal static void Flood(WingedEdge wing, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> selection) { }

	// RVA: 0x1586808
	internal static void Flood(ProBuilderMesh pb, WingedEdge wing, Vector3 wingNrm, float maxAngle, System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> selection) { }

	// RVA: 0x1586B44
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> FloodSelection(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, float maxAngleDiff) { }

	// RVA: 0x1586EE8
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceLoop(ProBuilderMesh mesh, Face[] faces, bool ring) { }

	// RVA: 0x1587358
	public static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceRingAndLoop(ProBuilderMesh mesh, Face[] faces) { }

	// RVA: 0x1587130
	private static System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> GetFaceLoop(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, Face face, bool ring) { }

	// RVA: 0x15875B4
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Edge>> FindHoles(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x1587988
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge>> FindHoles(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings, System.Collections.Generic.HashSet<System.Int32> common) { }

	// RVA: 0x15884E4
	private static WingedEdge FindNextEdgeInHole(WingedEdge wing, int common) { }

	// RVA: 0x1588568
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

	// RVA: 0x158E98C
	private static void .cctor() { }

	// RVA: 0x158E9F8
	public void .ctor() { }

	// RVA: 0x158EA00
	internal Face <DetachFaces>b__3_0(FaceRebuildData x) { }

	// RVA: 0x158EA1C
	internal int <ExtrudePerFace>b__4_0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class ExtrudeElements
{
	// Methods

	// RVA: 0x1588D2C
	public static Face[] Extrude(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, ExtrudeMethod method, float distance) { }

	// RVA: 0x158C0AC
	public static Edge[] Extrude(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, float distance, bool extrudeAsGroup, bool enableManifoldExtrude) { }

	// RVA: 0x158D270
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> DetachFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x158D278
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> DetachFaces(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool deleteSourceFaces) { }

	// RVA: 0x1588D40
	private static Face[] ExtrudePerFace(ProBuilderMesh pb, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, float distance) { }

	// RVA: 0x15898F8
	private static Face[] ExtrudeAsGroups(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces, bool compensateAngleVertexDistance, float distance) { }

	// RVA: 0x158DD9C
	private static System.Collections.Generic.List<System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face>> GetFaceGroups(System.Collections.Generic.List<UnityEngine.ProBuilder.WingedEdge> wings) { }

	// RVA: 0x158E340
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

	// RVA: 0x1591190
	private static void .cctor() { }

	// RVA: 0x15911FC
	public void .ctor() { }

	// RVA: 0x1591204
	internal Vector3[] <CreateMeshWithTransform>b__1_0(Mesh x) { }

	// RVA: 0x1591220
	internal Color[] <CreateMeshWithTransform>b__1_1(Mesh x) { }

	// RVA: 0x159123C
	internal Vector2[] <CreateMeshWithTransform>b__1_2(Mesh x) { }

	// RVA: 0x1591258
	internal Vector3[] <ResetPbObjectWithMeshFilter>b__2_0(Mesh x) { }

	// RVA: 0x1591274
	internal Color[] <ResetPbObjectWithMeshFilter>b__2_1(Mesh x) { }

	// RVA: 0x1591290
	internal Vector2[] <ResetPbObjectWithMeshFilter>b__2_2(Mesh x) { }

	// RVA: 0x15912AC
	internal bool <FilterUnusedSubmeshIndexes>b__3_0(bool x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class InternalMeshUtility
{
	// Methods

	// RVA: 0x158D07C
	internal static Vector3 AverageNormalWithIndexes(SharedVertex shared, int[] all, System.Collections.Generic.IList<UnityEngine.Vector3> norm) { }

	// RVA: 0x158EA7C
	public static ProBuilderMesh CreateMeshWithTransform(Transform t, bool preserveFaces) { }

	// RVA: 0x158FC70
	public static bool ResetPbObjectWithMeshFilter(ProBuilderMesh pb, bool preserveFaces) { }

	// RVA: 0x1590C48
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

	// RVA: 0x15926E0
	private static void .cctor() { }

	// RVA: 0x159274C
	public void .ctor() { }

	// RVA: 0x1592754
	internal System.Collections.Generic.IEnumerable<System.Int32> <Merge>b__1_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public System.Collections.Generic.HashSet<UnityEngine.ProBuilder.Face> remove; // 0x10

	// Methods

	// RVA: 0x1591A0C
	public void .ctor() { }

	// RVA: 0x1592770
	internal bool <MergePairs>b__0(Face x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MergeElements
{
	// Methods

	// RVA: 0x15912B4
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> MergePairs(ProBuilderMesh target, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.Face,UnityEngine.ProBuilder.Face>> pairs, bool collapseCoincidentVertices) { }

	// RVA: 0x1591EE8
	public static Face Merge(ProBuilderMesh target, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1591A14
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

	// RVA: 0x15927DC
	public bool get_quads() { }

	// RVA: 0x15927E4
	public void set_quads(bool value) { }

	// RVA: 0x15927EC
	public bool get_smoothing() { }

	// RVA: 0x15927F4
	public void set_smoothing(bool value) { }

	// RVA: 0x15927FC
	public float get_smoothingAngle() { }

	// RVA: 0x1592804
	public void set_smoothingAngle(float value) { }

	// RVA: 0x159280C
	public override string ToString() { }

	// RVA: 0x15928EC
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

	// RVA: 0x1594168
	private static void .cctor() { }

	// RVA: 0x15941D4
	public void .ctor() { }

	// RVA: 0x15941DC
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

	// RVA: 0x1592904
	public void .ctor(GameObject gameObject) { }

	// RVA: 0x1592AB8
	public void .ctor(Mesh sourceMesh, Material[] sourceMaterials, ProBuilderMesh destination) { }

	// RVA: 0x1592C2C
	public void .ctor(ProBuilderMesh destination) { }

	// RVA: 0x1592C60
	public bool Import(GameObject go, MeshImportSettings importSettings) { }

	// RVA: 0x1592E40
	public void Import(MeshImportSettings importSettings) { }

	// RVA: 0x15940C8
	private static void .cctor() { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MeshTransform
{
	// Methods

	// RVA: 0x15941FC
	internal static void SetPivot(ProBuilderMesh mesh, PivotLocation pivotLocation) { }

	// RVA: 0x158F980
	public static void CenterPivot(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x159429C
	public static void SetPivot(ProBuilderMesh mesh, Vector3 worldPosition) { }

	// RVA: 0x1594458
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

	// RVA: 0x15974DC
	private static void .cctor() { }

	// RVA: 0x1597548
	public void .ctor() { }

	// RVA: 0x1597550
	internal System.Collections.Generic.IEnumerable<System.Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_0(Triangle x) { }

	// RVA: 0x159757C
	internal System.Collections.Generic.IEnumerable<System.Int32> <EnsureFacesAreComposedOfContiguousTriangles>b__4_1(Triangle x) { }

	// RVA: 0x15975A8
	internal System.Collections.Generic.IEnumerable<System.Int32> <RemoveUnusedVertices>b__7_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public ProBuilderMesh mesh; // 0x10

	// Methods

	// RVA: 0x1596BC8
	public void .ctor() { }

	// RVA: 0x15975C4
	internal bool <RebuildSelectionIndexes>b__0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public Triangle triangle; // 0x10
	public System.Func<UnityEngine.ProBuilder.Triangle,System.Boolean> <>9__0; // 0x20

	// Methods

	// RVA: 0x1595704
	public void .ctor() { }

	// RVA: 0x159762C
	internal bool <CollectFaceGroups>b__0(Triangle x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class MeshValidation
{
	// Methods

	// RVA: 0x15945CC
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh) { }

	// RVA: 0x15945E8
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1594A38
	public static bool ContainsDegenerateTriangles(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1594BAC
	public static bool ContainsNonContiguousTriangles(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1594CE0
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> EnsureFacesAreComposedOfContiguousTriangles(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x159537C
	internal static System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.ProBuilder.Triangle>> CollectFaceGroups(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x159570C
	public static bool RemoveDegenerateTriangles(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x159232C
	public static bool RemoveUnusedVertices(ProBuilderMesh mesh, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x1596184
	internal static System.Collections.Generic.List<System.Int32> RebuildIndexes(System.Collections.Generic.IEnumerable<System.Int32> indices, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x1596558
	internal static System.Collections.Generic.List<UnityEngine.ProBuilder.Edge> RebuildEdges(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Edge> edges, System.Collections.Generic.List<System.Int32> removed) { }

	// RVA: 0x15969A4
	internal static void RebuildSelectionIndexes(ProBuilderMesh mesh, Face[] faces, Edge[] edges, int[] indices, System.Collections.Generic.IEnumerable<System.Int32> removed) { }

	// RVA: 0x1596BD0
	internal static bool EnsureMeshIsValid(ProBuilderMesh mesh, int removedVertices) { }

	// RVA: 0x1596F38
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector2> attribute) { }

	// RVA: 0x1597110
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector3> attribute) { }

	// RVA: 0x15972F4
	private static void EnsureRealNumbers(System.Collections.Generic.IList<UnityEngine.Vector4> attribute) { }

	// RVA: 0x318DB98
	private static void EnsureArraySize(T[] attribute, int expectedVertexCount, AttributeValidationStrategy strategy, T fill) { }

	// RVA: 0x318DB98
	private static void EnsureListSize(System.Collections.Generic.List<T>& attribute, int expectedVertexCount, AttributeValidationStrategy strategy, T fill) { }

	// RVA: 0x1596D4C
	private static void EnsureValidAttributes(ProBuilderMesh mesh) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class QuadUtility
{
	// Methods

	// RVA: 0x1593690
	public static System.Collections.Generic.List<UnityEngine.ProBuilder.Face> ToQuads(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces, bool smoothing) { }

	// RVA: 0x1597D60
	private static Face GetBestQuadConnection(WingedEdge wing, System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.EdgeLookup,System.Single> connections) { }

	// RVA: 0x1597660
	private static float GetQuadScore(ProBuilderMesh mesh, WingedEdge left, WingedEdge right, float normalThreshold) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class Subdivision
{
	// Methods

	// RVA: 0x159802C
	public static ActionResult Subdivide(ProBuilderMesh pb) { }

	// RVA: 0x15980E4
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

	// RVA: 0x159A1AC
	private static void .cctor() { }

	// RVA: 0x159A218
	public void .ctor() { }

	// RVA: 0x159A220
	internal Face <ToTriangles>b__0_0(FaceRebuildData x) { }

	// RVA: 0x159A23C
	internal Vector3 <GetWindingOrder>b__3_0(Vertex x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class SurfaceTopology
{
	// Methods

	// RVA: 0x15980EC
	public static Face[] ToTriangles(ProBuilderMesh mesh, System.Collections.Generic.IList<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1598688
	private static System.Collections.Generic.List<UnityEngine.ProBuilder.FaceRebuildData> BreakFaceIntoTris(Face face, System.Collections.Generic.List<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

	// RVA: 0x1598B2C
	public static WindingOrder GetWindingOrder(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x1598E28
	private static WindingOrder GetWindingOrder(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<System.Int32> indexes) { }

	// RVA: 0x1598B70
	public static WindingOrder GetWindingOrder(System.Collections.Generic.IList<UnityEngine.Vector2> points) { }

	// RVA: 0x1598FD4
	public static bool FlipEdge(ProBuilderMesh mesh, Face face) { }

	// RVA: 0x159943C
	public static ActionResult ConformNormals(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x1599C10
	private static void GetWindingFlags(WingedEdge edge, bool flag, System.Collections.Generic.Dictionary<UnityEngine.ProBuilder.Face,System.Boolean> flags) { }

	// RVA: 0x1599EA8
	internal static ActionResult ConformOppositeNormal(WingedEdge source) { }

	// RVA: 0x1599D18
	private static Edge GetCommonEdgeInWindingOrder(WingedEdge wing) { }

	// RVA: 0x1599FC4
	internal static void MatchNormal(Face source, Face target, System.Collections.Generic.Dictionary<System.Int32,System.Int32> lookup) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public int index; // 0x10

	// Methods

	// RVA: 0x159C5CC
	public void .ctor() { }

	// RVA: 0x159C5DC
	internal TriangulationPoint <Triangulate>b__0(Vector2 x) { }

	// RVA: 0x159C668
	internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public int index; // 0x10
	public System.Func<UnityEngine.Vector2,UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> <>9__1; // 0x18

	// Methods

	// RVA: 0x159C5D4
	public void .ctor() { }

	// RVA: 0x159C6F4
	internal PolygonPoint <Triangulate>b__0(Vector2 x) { }

	// RVA: 0x159C780
	internal PolygonPoint <Triangulate>b__1(Vector2 x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class Triangulation
{
	// Fields
	private static TriangulationContext s_TriangulationContext; // 0x0

	// Methods

	// RVA: 0x159A25C
	private static TriangulationContext get_triangulationContext() { }

	// RVA: 0x159A318
	public static bool SortAndTriangulate(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.List<System.Int32>& indexes, bool convex) { }

	// RVA: 0x159B320
	public static bool TriangulateVertices(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.List<System.Int32>& triangles, bool unordered, bool convex) { }

	// RVA: 0x159B6E4
	public static bool TriangulateVertices(Vector3[] vertices, System.Collections.Generic.List<System.Int32>& triangles, Vector3[][] holes) { }

	// RVA: 0x159B568
	public static bool TriangulateVertices(Vector3[] vertices, System.Collections.Generic.List<System.Int32>& triangles, bool unordered, bool convex) { }

	// RVA: 0x159A6BC
	public static bool Triangulate(System.Collections.Generic.IList<UnityEngine.Vector2> points, System.Collections.Generic.List<System.Int32>& indexes, bool convex) { }

	// RVA: 0x159B8A8
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

	// RVA: 0x15A0044
	private static void .cctor() { }

	// RVA: 0x15A00B0
	public void .ctor() { }

	// RVA: 0x15A00B8
	internal Vector2 <GetUVs>b__2_0(Vector4 x) { }

	// RVA: 0x15A00BC
	internal int <SewUVs>b__4_1(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> y) { }

	// RVA: 0x15A0184
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesAuto>b__8_0(Face x) { }

	// RVA: 0x15A01A0
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesAuto>b__8_1(Face x) { }

	// RVA: 0x15A01BC
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesBox>b__9_0(Face x) { }

	// RVA: 0x15A01D8
	internal System.Collections.Generic.IEnumerable<System.Int32> <ProjectFacesBox>b__11_0(Face x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0
{
	// Fields
	public Face f1; // 0x10
	public Face f2; // 0x18

	// Methods

	// RVA: 0x159CADC
	public void .ctor() { }

	// RVA: 0x15A01F4
	internal bool <AutoStitch>b__0(WingedEdge x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public int b; // 0x10

	// Methods

	// RVA: 0x159E4C8
	public void .ctor() { }

	// RVA: 0x15A0240
	internal bool <SewUVs>b__0(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> x) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
internal static class UVEditing
{
	// Methods

	// RVA: 0x159C80C
	public static bool AutoStitch(ProBuilderMesh mesh, Face f1, Face f2, int channel) { }

	// RVA: 0x159CAE4
	private static bool AlignEdges(ProBuilderMesh mesh, Face faceToMove, Edge edgeToAlignTo, Edge edgeToBeAligned, int channel) { }

	// RVA: 0x159D574
	internal static Vector2[] GetUVs(ProBuilderMesh mesh, int channel) { }

	// RVA: 0x159DB50
	internal static void ApplyUVs(ProBuilderMesh mesh, Vector2[] uvs, int channel, bool applyToMesh) { }

	// RVA: 0x159DEB8
	public static void SewUVs(ProBuilderMesh mesh, int[] indexes, float delta) { }

	// RVA: 0x159E4D0
	public static void CollapseUVs(ProBuilderMesh mesh, int[] indexes) { }

	// RVA: 0x159D7E0
	public static void SplitUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes) { }

	// RVA: 0x159E59C
	internal static void SplitUVs(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Face> faces) { }

	// RVA: 0x159E98C
	internal static void ProjectFacesAuto(ProBuilderMesh mesh, Face[] faces, int channel) { }

	// RVA: 0x159ED50
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, int channel) { }

	// RVA: 0x159F474
	internal static Vector2 FindMinimalUV(Vector2[] uvs, int[] indices, float xMin, float yMin) { }

	// RVA: 0x159F5D4
	public static void ProjectFacesBox(ProBuilderMesh mesh, Face[] faces, Vector2 lowerLeftAnchor, int channel) { }

	// RVA: 0x159FD40
	public static void ProjectFacesSphere(ProBuilderMesh pb, int[] indexes, int channel) { }

	// RVA: 0x159FECC
	public static Vector2[] FitUVs(Vector2[] uvs) { }

}

// Namespace: UnityEngine.ProBuilder.MeshOperations
public static class VertexEditing
{
	// Methods

	// RVA: 0x15A0324
	public static int MergeVertices(ProBuilderMesh mesh, int[] indexes, bool collapseToFirst) { }

	// RVA: 0x15A0684
	public static void SplitVertices(ProBuilderMesh mesh, Edge edge) { }

	// RVA: 0x15A0710
	public static void SplitVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> vertices) { }

	// RVA: 0x15A0B14
	public static int[] WeldVertices(ProBuilderMesh mesh, System.Collections.Generic.IEnumerable<System.Int32> indexes, float neighborRadius) { }

	// RVA: 0x15A1E58
	internal static FaceRebuildData ExplodeVertex(System.Collections.Generic.IList<UnityEngine.ProBuilder.Vertex> vertices, System.Collections.Generic.IList<UnityEngine.ProBuilder.SimpleTuple<UnityEngine.ProBuilder.WingedEdge,System.Int32>> edgeAndCommonIndex, float distance, System.Collections.Generic.Dictionary<System.Int32,System.Collections.Generic.List<System.Int32>>& appendedVertices) { }

	// RVA: 0x15A2DC4
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


