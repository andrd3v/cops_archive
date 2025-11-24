// Namespace: 
internal class <Module> 
{}

// Namespace: CFRenderLib.Core
public static class HFQueries 
{
	// Methods

	// RVA: 0x575AD4
	void WorldToVoxelSpace(HeightField heightField, Single* position, Int32* coord) { }

	// RVA: 0x575C0C
	void VoxelToWorldSpace(HeightField heightField, Single* position, Int32* coord) { }

	// RVA: 0x575CB0
	Float3 SpanIndexToWorldPosition(HeightField heightField, int index) { }

	// RVA: 0x575E74
	bool FieldAABB(HeightField heightField, Int32* coord) { }

	// RVA: 0x575EE0
	void ClampFieldAABB(HeightField heightField, Int32* coord) { }

	// RVA: 0x575F68
	bool TryFindSpanInCoord(HeightField heightField, Int32* coord, out UInt16 index) { }

	// RVA: 0x576060
	bool TryGetSpanPositionAtWorldPosition(HeightField heightField, in Float3 position, out Float3 spanPos) { }

}

// Namespace: CFRenderLib.Core
public static class HFSerialization 
{
	// Methods

	// RVA: 0x5761A4
	void Deserialize(string data, out HeightField heightField) { }

	// RVA: 0x5771A8
	void Deserialize(string data, out HeightField heightField, out GlobalIlluminationData gi) { }

	// RVA: 0x5782C4
	string BytesToString(UInt64 bytes, UInt32 decimalPlaces) { }

	// RVA: 0x577168
	bool IsValid(HeightField heightField) { }

	// RVA: 0x5785D4
	bool IsValid(GlobalIlluminationData gi) { }

	// RVA: 0x578234
	bool IsValid(GlobalIlluminationData gi, HeightField heightField) { }

}

// Namespace: 
internal struct IntFloatUnion 
{
	// Fields
	public int intValue; // 0x10
	public float floatValue; // 0x10
}

// Namespace: CFRenderLib.Core
public static class Math 
{
	// Methods

	// RVA: 0x57861C
	float HorizontalToVerticalFoV(float horizontalFoV, float aspect) { }

	// RVA: 0x5786BC
	float VerticalToHorizontalFoV(float verticalFoV, float aspect) { }

	// RVA: 0x57875C
	bool Approximately(float actual, float expected) { }

	// RVA: 0x578780
	float Clamp(float x, float min, float max) { }

	// RVA: 0x5787A0
	UInt32 Max(UInt32 x, UInt32 y) { }

	// RVA: 0x5787AC
	float Max(float x, float y) { }

	// RVA: 0x5787B8
	float Sqrt(float x) { }

	// RVA: 0x578838
	float Abs(float x) { }

	// RVA: 0x578848
	float Dot(in Float3 v1, in Float3 v2) { }

	// RVA: 0x578870
	Float3 Cross(in Float3 v1, in Float3 v2) { }

	// RVA: 0x5788A8
	Float3 Subtract(in Float3 p1, in Float3 p2) { }

	// RVA: 0x5788C8
	Float3 Multiply(in Float3 v, float d) { }

	// RVA: 0x5788E4
	Float3 Normalize(in Float3 v) { }

	// RVA: 0x578994
	float Distance(in Float3 p1, in Float3 p2) { }

	// RVA: 0x578A38
	Plane CreatePlane(in Float3 p1, in Float3 p2, in Float3 p3) { }

	// RVA: 0x578B74
	float PlaneDistanceToPoint(in Plane plane, in Float3 point) { }

	// RVA: 0x578BA4
	Float3 Center(in BoundingBox bounds) { }

	// RVA: 0x578BD4
	int AsInt(float x) { }

	// RVA: 0x578BDC
	SnormHalf4 EncodeFloat3SnormHalf4(Float3 v, float encodeFactor) { }

	// RVA: 0x578D64
	SnormByte4 EncodeFloat3SnormByte4(Float3 v, float encodeFactor) { }

	// RVA: 0x578EE8
	bool IntersectPlanesAABB(Plane[] planes, int planeCount, in BoundingBox aabb) { }

	// RVA: 0x578FB4
	bool IntersectConvexPoint(Plane[] planes, in Float3 point, float epsilon) { }

	// RVA: 0x57907C
	float ConvexDistanceToPoint(Plane[] planes, in Float3 point) { }

	// RVA: 0x5790F8
	float CalcSizePerDepth(float fov) { }

	// RVA: 0x579178
	float SizeOnScreen(float depth, float sizePerDepth, float radius) { }

	// RVA: 0x579184
	bool ClipPolygon(in Plane plane, Float3* points, int pointsLength, ref int numPoints, bool keepOn, float epsilon) { }

	// RVA: 0x579570
	bool ClipFrustrum(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane> frustum, CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane> newFrustum, in Float3 origin, Float3[] points, int pointCount) { }

	// RVA: 0x579784
	bool ClipFrustrum(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane> frustum, Float3[] newPoints, in Float3 origin, Float3[] points, int pointCount) { }

}

// Namespace: 
public sealed class CreateSceneDelegate 
{
	// Methods

	// RVA: 0x5799D0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x579A70
	internal IntPtr Invoke() { }

}

// Namespace: 
public sealed class DeleteSceneDelegate 
{
	// Methods

	// RVA: 0x579A84
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x579B28
	internal void Invoke(IntPtr scene) { }

}

// Namespace: 
public sealed class SetRendererCountDelegate 
{
	// Methods

	// RVA: 0x579B3C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x579BE0
	internal void Invoke(IntPtr scene, int count) { }

}

// Namespace: 
public sealed class SetRendererBoundsDelegate 
{
	// Methods

	// RVA: 0x579BF4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x579C98
	internal void Invoke(IntPtr scene, int index, BoundingBox bounds) { }

}

// Namespace: 
public sealed class SetAreaCountDelegate 
{
	// Methods

	// RVA: 0x579CD8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x579D7C
	internal void Invoke(IntPtr scene, int count) { }

}

// Namespace: 
public sealed class SetAreaPlaneCountDelegate 
{
	// Methods

	// RVA: 0x579D90
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x579E34
	internal void Invoke(IntPtr scene, int areaIndex, int count) { }

}

// Namespace: 
public sealed class SetAreaPlaneDelegate 
{
	// Methods

	// RVA: 0x579E48
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x579EEC
	internal void Invoke(IntPtr scene, int areaIndex, int planeIndex, Plane plane) { }

}

// Namespace: 
public sealed class SetAreaPortalCountDelegate 
{
	// Methods

	// RVA: 0x579F00
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x579FA4
	internal void Invoke(IntPtr scene, int areaIndex, int count) { }

}

// Namespace: 
public sealed class SetAreaPortalDelegate 
{
	// Methods

	// RVA: 0x579FB8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x57A05C
	internal void Invoke(IntPtr scene, int areaIndex, int portalIndex, Float3[] points, int pointCount, int nextAreaIndex, int planeIndex) { }

}

// Namespace: 
public sealed class SetAreaRendererCountDelegate 
{
	// Methods

	// RVA: 0x57A074
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x57A118
	internal void Invoke(IntPtr scene, int areaIndex, int rendererCount) { }

}

// Namespace: 
public sealed class SetAreaRendererDelegate 
{
	// Methods

	// RVA: 0x57A12C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x57A1D0
	internal void Invoke(IntPtr scene, int areaIndex, int areaRendererIndex, int renderer) { }

}

// Namespace: 
public sealed class UpdateDelegate 
{
	// Methods

	// RVA: 0x57A1E4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x57A288
	internal void Invoke(IntPtr scene, Float3 origin, Frustum frustum, int areaIndex, ref CullingResultsNative results) { }

}

// Namespace: 
public sealed class CullDynamicDelegate 
{
	// Methods

	// RVA: 0x57A2C8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x57A36C
	internal void Invoke(IntPtr scene, Frustum frustum, ref DynamicCullingDataNative dynamic, int occlusion) { }

}

// Namespace: 
public sealed class GetRenderEventFuncDelegate 
{
	// Methods

	// RVA: 0x57A3AC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x57A44C
	internal IntPtr Invoke() { }

}

// Namespace: CFRenderLib.Core
public static class Native 
{
	// Fields
	public static CreateSceneDelegate CreateScene; // 0x0
	public static DeleteSceneDelegate DeleteScene; // 0x8
	public static SetRendererCountDelegate SetRendererCount; // 0x10
	public static SetRendererBoundsDelegate SetRendererBounds; // 0x18
	public static SetAreaCountDelegate SetAreaCount; // 0x20
	public static SetAreaPlaneCountDelegate SetAreaPlaneCount; // 0x28
	public static SetAreaPlaneDelegate SetAreaPlane; // 0x30
	public static SetAreaPortalCountDelegate SetAreaPortalCount; // 0x38
	public static SetAreaPortalDelegate SetAreaPortal; // 0x40
	public static SetAreaRendererCountDelegate SetAreaRendererCount; // 0x48
	public static SetAreaRendererDelegate SetAreaRenderer; // 0x50
	public static UpdateDelegate Update; // 0x58
	public static CullDynamicDelegate CullDynamic; // 0x60
	public static GetRenderEventFuncDelegate GetRenderEventFunc; // 0x68
	private static IntPtr m_renderEventFunc; // 0x70

	// Methods

	// RVA: 0x579934
	IntPtr get_RenderEventFunc() { }

}

// Namespace: CFRenderLib.Core
public static class NativeLoader 
{
	// Methods

	// RVA: 0x57A460
	IntPtr CreateScene() { }

	// RVA: 0x57A464
	void DeleteScene(IntPtr scene) { }

	// RVA: 0x57A468
	void SetRendererCount(IntPtr scene, int count) { }

	// RVA: 0x57A46C
	void SetRendererBounds(IntPtr scene, int index, BoundingBox bounds) { }

	// RVA: 0x57A49C
	void SetAreaCount(IntPtr scene, int count) { }

	// RVA: 0x57A4A0
	void SetAreaPlaneCount(IntPtr scene, int areaIndex, int count) { }

	// RVA: 0x57A4A4
	void SetAreaPlane(IntPtr scene, int areaIndex, int planeIndex, Plane plane) { }

	// RVA: 0x57A4A8
	void SetAreaPortalCount(IntPtr scene, int areaIndex, int count) { }

	// RVA: 0x57A4AC
	void SetAreaPortal(IntPtr scene, int areaIndex, int portalIndex, Float3[] points, int pointCount, int nextAreaIndex, int planeIndex) { }

	// RVA: 0x57A4BC
	void SetAreaRendererCount(IntPtr scene, int areaIndex, int rendererCount) { }

	// RVA: 0x57A4C0
	void SetAreaRenderer(IntPtr scene, int areaIndex, int areaRendererIndex, int renderer) { }

	// RVA: 0x57A4C4
	void Update(IntPtr scene, Float3 origin, Frustum frustum, int areaIndex, ref CullingResultsNative results) { }

	// RVA: 0x57A4F4
	void CullDynamic(IntPtr scene, Frustum frustum, ref DynamicCullingDataNative dynamic, int occlusion) { }

	// RVA: 0x57A524
	IntPtr GetRenderEventFunc() { }

	// RVA: 0x57A528
	void Init() { }

}

// Namespace: CFRenderLib.Core
public static class SphericalHarmonics 
{
	// Fields
	public static float[] COSINE_LOBE; // 0x0
	public static float[] UNIFORM_LOBE; // 0x8

	// Methods

	// RVA: 0x57AEBC
	void ProjectLobe(ref SphericalHarmonicsL2 sh, float[] lobeCoeffs, in Float4 quaternion, in Float3 color) { }

	// RVA: 0x57BFA4
	void ComputeUVWCoeff(int m, int n, out float u, out float v, out float w) { }

	// RVA: 0x57C6E0
	float KroneckerDelta(int i, int j) { }

	// RVA: 0x57C6F4
	float P(int i, int a, int b, ref SHRotationMatrix r) { }

	// RVA: 0x57C210
	float U(int m, int n, ref SHRotationMatrix r) { }

	// RVA: 0x57C28C
	float V(int m, int n, ref SHRotationMatrix r) { }

	// RVA: 0x57C4BC
	float W(int m, int n, ref SHRotationMatrix r) { }

	// RVA: 0x57C8BC
	void .cctor() { }

}

// Namespace: 
public struct <values>e__FixedBuffer 
{
	// Fields
	public UInt32 FixedElementField; // 0x10
}

// Namespace: CFRenderLib.Core.Structs
public struct BitVector256 
{
	// Fields
	public CFRenderLib.Core.Structs.BitVector256.<values>e__FixedBuffer values; // 0x10

	// Methods

	// RVA: 0x57C99C
	bool get_Item(int bitIndex) { }

	// RVA: 0x57CA3C
	void set_Item(int bitIndex, bool value) { }

	// RVA: 0x57CAF4
	string ToString() { }

}

// Namespace: CFRenderLib.Core.Structs
public struct BoundingBox 
{
	// Fields
	public Float3 min; // 0x10
	public Float3 max; // 0x1C
}

// Namespace: CFRenderLib.Core.Structs
public struct BoundingSphere 
{
	// Fields
	public Float3 position; // 0x10
	public float radius; // 0x1C
}

// Namespace: CFRenderLib.Core.Structs
public struct Byte4 
{
	// Fields
	public Byte x; // 0x10
	public Byte y; // 0x11
	public Byte z; // 0x12
	public Byte w; // 0x13

	// Methods

	// RVA: 0x57CBAC
	void .ctor(Byte x, Byte y, Byte z, Byte w) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct Cell 
{
	// Fields
	private const UInt32 IndexMask = 16777215;
	private const UInt32 InvalidValue = 4294967295;
	private const int CountShift = 24;
	public readonly UInt32 value; // 0x10

	// Methods

	// RVA: 0x575E60
	int get_index() { }

	// RVA: 0x575E6C
	Byte get_count() { }

	// RVA: 0x57CBC0
	void .ctor(UInt32 value) { }

	// RVA: 0x57CBC8
	Cell get_Invalid() { }

	// RVA: 0x575E50
	bool get_IsValid() { }

}

// Namespace: CFRenderLib.Core.Structs
public struct CullingResultsNative 
{
	// Fields
	public IntPtr VisibleStaticObjects; // 0x10
	public int VisibleStaticObjectsCount; // 0x18
}

// Namespace: CFRenderLib.Core.Structs
public struct DynamicCullingDataNative 
{
	// Fields
	public IntPtr objectBounds; // 0x10
	public IntPtr objectArea; // 0x18
	public int objectCount; // 0x20
	public IntPtr VisibleDynamicObjects; // 0x24
	public int VisibleDynamicObjectsCount; // 0x2C
}

// Namespace: CFRenderLib.Core.Structs
public struct Float3 
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x57CBD0
	void .ctor(float x, float y, float z) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct Float4 
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18
	public float w; // 0x1C

	// Methods

	// RVA: 0x57CBDC
	void .ctor(float x, float y, float z, float w) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct Frustum 
{
	// Fields
	public Plane x1; // 0x10
	public Plane x2; // 0x20
	public Plane y1; // 0x30
	public Plane y2; // 0x40
}

// Namespace: CFRenderLib.Core.Structs
public struct Half 
{
	// Fields
	private Int16 value; // 0x10

	// Methods

	// RVA: 0x57CBE8
	Half op_Implicit(float v) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct Half2 
{
	// Fields
	public Half x; // 0x10
	public Half y; // 0x12

	// Methods

	// RVA: 0x57CC30
	void .ctor(Half x, Half y) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct Half4 
{
	// Fields
	public Half x; // 0x10
	public Half y; // 0x12
	public Half z; // 0x14
	public Half w; // 0x16

	// Methods

	// RVA: 0x57CC3C
	void .ctor(Half x, Half y, Half z, Half w) { }

}

// Namespace: CFRenderLib.Core.Structs
public class OcclusionArea 
{
	// Fields
	public Plane[] planes; // 0x10
	public OcclusionPortal[] portals; // 0x18
	public Float3 pivot; // 0x20
	public bool usesCustomPivot; // 0x2C
	public bool closed; // 0x2D

	// Methods

	// RVA: 0x57CC50
	void .ctor() { }

}

// Namespace: CFRenderLib.Core.Structs
public class OcclusionPortal 
{
	// Fields
	public Float3[] points; // 0x10
	public int planeIndex; // 0x18
	public int nextAreaIndex; // 0x1C

	// Methods

	// RVA: 0x57CC58
	void .ctor() { }

}

// Namespace: CFRenderLib.Core.Structs
public struct Plane 
{
	// Fields
	public Float3 normal; // 0x10
	public float distance; // 0x1C
}

// Namespace: 
public struct <coefficients>e__FixedBuffer 
{
	// Fields
	public float FixedElementField; // 0x10
}

// Namespace: CFRenderLib.Core.Structs
public struct SHRotationMatrix 
{
	// Fields
	public static readonly int[] DIMENSIONS; // 0x0
	public static readonly int[] OFFSETS; // 0x8
	private CFRenderLib.Core.Structs.SHRotationMatrix.<coefficients>e__FixedBuffer coefficients; // 0x10

	// Methods

	// RVA: 0x57C5DC
	float get_Item(int order, int row, int column) { }

	// RVA: 0x57BEB4
	void set_Item(int order, int row, int column, float value) { }

	// RVA: 0x57CC60
	void .cctor() { }

}

// Namespace: CFRenderLib.Core.Structs
public struct SnormByte4 
{
	// Fields
	public SByte x; // 0x10
	public SByte y; // 0x11
	public SByte z; // 0x12
	public SByte w; // 0x13

	// Methods

	// RVA: 0x578EA8
	void .ctor(float x, float y, float z, float w) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct SnormHalf4 
{
	// Fields
	public Int16 x; // 0x10
	public Int16 y; // 0x12
	public Int16 z; // 0x14
	public Int16 w; // 0x16

	// Methods

	// RVA: 0x578D24
	void .ctor(float x, float y, float z, float w) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct Span 
{
	// Fields
	public UInt16 start; // 0x10
	public UInt16 height; // 0x12
	public int connections; // 0x14
}

// Namespace: 
public struct <coefficients>e__FixedBuffer 
{
	// Fields
	public float FixedElementField; // 0x10
}

// Namespace: CFRenderLib.Core.Structs
public struct SphericalHarmonicsL2 
{
	// Fields
	public CFRenderLib.Core.Structs.SphericalHarmonicsL2.<coefficients>e__FixedBuffer coefficients; // 0x10

	// Methods

	// RVA: 0x57CD54
	float get_Item(int i) { }

	// RVA: 0x57CD5C
	void set_Item(int i, float value) { }

	// RVA: 0x57C6C0
	float get_Item(int rgb, int coef) { }

	// RVA: 0x57C6D0
	void set_Item(int rgb, int coef, float value) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct UnormHalf2 
{
	// Fields
	public UInt16 x; // 0x10
	public UInt16 y; // 0x12

	// Methods

	// RVA: 0x57CD64
	void .ctor(float x, float y) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct UnormHalf4 
{
	// Fields
	public UInt16 x; // 0x10
	public UInt16 y; // 0x12
	public UInt16 z; // 0x14
	public UInt16 w; // 0x16

	// Methods

	// RVA: 0x57CD9C
	void .ctor(float x, float y, float z, float w) { }

}

// Namespace: CFRenderLib.Core.Collections
public class GlobalIlluminationData 
{
	// Fields
	public UInt16[] probemap; // 0x10
	public float[] probes; // 0x18

	// Methods

	// RVA: 0x57CDE4
	string ToString() { }

	// RVA: 0x57822C
	void .ctor() { }

}

// Namespace: CFRenderLib.Core.Collections
public class GrowArray<T0> 
{
	// Fields
	public int count; // 0x0
	public T[] items; // 0x0

	// Methods

	// RVA: 0x2FE42A4
	void .ctor(int initialSize) { }

	// RVA: 0x309AF8C
	void Add(T t) { }

	// RVA: 0x2FE4574
	void Add(ref T t) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x309AF8C
	void UnorderedRemove(T item) { }

	// RVA: 0x2FE42A4
	void UnorderedRemoveAt(int index) { }

	// RVA: 0x2FE9D78
	void ValidateBufferSize(ref T[] buffer, int count, int newCount) { }

}

// Namespace: CFRenderLib.Core.Collections
public class HeightField 
{
	// Fields
	public static readonly int[] OFFSET_X; // 0x0
	public static readonly int[] OFFSET_Y; // 0x8
	public static readonly Byte[] COORD_TO_DIR_X; // 0x10
	public static readonly Byte[] COORD_TO_DIR_Y; // 0x18
	public static readonly int DIR_POS_X; // 0x20
	public static readonly int DIR_NEG_X; // 0x24
	public static readonly int DIR_POS_Y; // 0x28
	public static readonly int DIR_NEG_Y; // 0x2C
	public int width; // 0x10
	public int height; // 0x14
	public float cellsize; // 0x18
	public float cellheight; // 0x1C
	public float[] boundsmin; // 0x20
	public float[] boundsmax; // 0x28
	public Cell[,] cells; // 0x30
	public Span[] spans; // 0x38
	public int[] flags; // 0x40

	// Methods

	// RVA: 0x576EB8
	void .ctor(int width, int height, float cellsize, float cellheight, float[] boundsmin, float[] boundsmax, int spanCount) { }

	// RVA: 0x57D030
	string ToString() { }

	// RVA: 0x57D350
	int OffsetX(int dir) { }

	// RVA: 0x57D3F4
	int OffsetY(int dir) { }

	// RVA: 0x57D498
	int GetConnection(int con, int dir) { }

	// RVA: 0x57D4AC
	void .cctor() { }

}

// Namespace: CFRenderLib.Core.Collections
public class OcclusionData 
{
	// Fields
	public OcclusionArea[] areas; // 0x10

	// Methods

	// RVA: 0x57D654
	int GetAreaIndex(Float3 pos) { }

	// RVA: 0x57D748
	int GetAreaIndexCached(Float3 pos, int areaIndex) { }

	// RVA: 0x57D918
	void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=12 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=36 
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Fields
	internal static readonly int 411CF028E0B24CC8093FAAEB58CF728F165BFDA8BCE53E5063664BBC6B66CE71; // 0x0
	internal static readonly __StaticArrayInitTypeSize=36 7F37560C2B9B7B25379410E246BAA5A0C0DB3D50144BA866BEED3F578F62A2F2; // 0x4
	internal static readonly __StaticArrayInitTypeSize=12 A0D673A85CA2CEE9AFDD1A9BAC40D741D2F8F94C97C59385CDD5B8891D35F237; // 0x28
}


