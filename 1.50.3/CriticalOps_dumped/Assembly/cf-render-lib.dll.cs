// Namespace: 
internal class <Module>
{}

// Namespace: CFRenderLib.Core
public static class HFQueries
{
	// Methods

	// RVA: 0x58C374
	public static void WorldToVoxelSpace(HeightField heightField, Single* position, Int32* coord) { }

	// RVA: 0x58C4AC
	public static void VoxelToWorldSpace(HeightField heightField, Single* position, Int32* coord) { }

	// RVA: 0x58C550
	public static Float3 SpanIndexToWorldPosition(HeightField heightField, int index) { }

	// RVA: 0x58C714
	public static bool FieldAABB(HeightField heightField, Int32* coord) { }

	// RVA: 0x58C780
	public static void ClampFieldAABB(HeightField heightField, Int32* coord) { }

	// RVA: 0x58C808
	public static bool TryFindSpanInCoord(HeightField heightField, Int32* coord, int spanIndex) { }

	// RVA: 0x58C8FC
	public static bool TryGetSpanPositionAtWorldPosition(HeightField heightField, Float3 position, Float3 spanPos) { }

}

// Namespace: CFRenderLib.Core
public static class HFSerialization
{
	// Methods

	// RVA: 0x58CA40
	public static void Deserialize(string data, HeightField heightField) { }

	// RVA: 0x58DA44
	public static void Deserialize(string data, HeightField heightField, GlobalIlluminationData gi) { }

	// RVA: 0x58EB60
	public static string BytesToString(UInt64 bytes, UInt32 decimalPlaces) { }

	// RVA: 0x58DA04
	public static bool IsValid(HeightField heightField) { }

	// RVA: 0x58EE70
	public static bool IsValid(GlobalIlluminationData gi) { }

	// RVA: 0x58EAD0
	public static bool IsValid(GlobalIlluminationData gi, HeightField heightField) { }

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

	// RVA: 0x58EEB8
	public static float HorizontalToVerticalFoV(float horizontalFoV, float aspect) { }

	// RVA: 0x58EF58
	public static float VerticalToHorizontalFoV(float verticalFoV, float aspect) { }

	// RVA: 0x58EFF8
	public static bool Approximately(float actual, float expected) { }

	// RVA: 0x58F01C
	public static int Clamp(int x, int min, int max) { }

	// RVA: 0x58F030
	public static float Clamp(float x, float min, float max) { }

	// RVA: 0x58F050
	public static UInt32 Max(UInt32 x, UInt32 y) { }

	// RVA: 0x58F05C
	public static float Max(float x, float y) { }

	// RVA: 0x58F068
	public static float Sqrt(float x) { }

	// RVA: 0x58F0E8
	public static float Abs(float x) { }

	// RVA: 0x58F0F8
	public static float Dot(Float3 v1, Float3 v2) { }

	// RVA: 0x58F120
	public static Float3 Cross(Float3 v1, Float3 v2) { }

	// RVA: 0x58F158
	public static Float3 Subtract(Float3 p1, Float3 p2) { }

	// RVA: 0x58F178
	public static Float3 Multiply(Float3 v, float d) { }

	// RVA: 0x58F194
	public static Float3 Normalize(Float3 v) { }

	// RVA: 0x58F244
	public static float Distance(Float3 p1, Float3 p2) { }

	// RVA: 0x58F2E8
	public static Plane CreatePlane(Float3 p1, Float3 p2, Float3 p3) { }

	// RVA: 0x58F424
	public static float PlaneDistanceToPoint(Plane plane, Float3 point) { }

	// RVA: 0x58F454
	public static Float3 Center(BoundingBox bounds) { }

	// RVA: 0x58F484
	public static int AsInt(float x) { }

	// RVA: 0x58F48C
	public static SnormHalf4 EncodeFloat3SnormHalf4(Float3 v, float encodeFactor) { }

	// RVA: 0x58F614
	public static SnormByte4 EncodeFloat3SnormByte4(Float3 v, float encodeFactor) { }

	// RVA: 0x58F798
	public static bool IntersectPlanesAABB(Plane[] planes, int planeCount, BoundingBox aabb) { }

	// RVA: 0x58F864
	public static bool IntersectConvexPoint(Plane[] planes, Float3 point, float epsilon) { }

	// RVA: 0x58F92C
	public static float ConvexDistanceToPoint(Plane[] planes, Float3 point) { }

	// RVA: 0x58F9A8
	public static float CalcSizePerDepth(float fov) { }

	// RVA: 0x58FA28
	public static float SizeOnScreen(float depth, float sizePerDepth, float radius) { }

	// RVA: 0x58FA34
	public static bool ClipPolygon(Plane plane, Float3* points, int pointsLength, int numPoints, bool keepOn, float epsilon) { }

	// RVA: 0x58FE20
	public static bool ClipFrustrum(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane> frustum, CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane> newFrustum, Float3 origin, Float3[] points, int pointCount) { }

	// RVA: 0x590034
	public static bool ClipFrustrum(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane> frustum, Float3[] newPoints, Float3 origin, Float3[] points, int pointCount) { }

}

// Namespace: 
public sealed class CreateSceneDelegate
{
	// Methods

	// RVA: 0x590280
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x590320
	public virtual IntPtr Invoke() { }

}

// Namespace: 
public sealed class DeleteSceneDelegate
{
	// Methods

	// RVA: 0x590334
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5903D8
	public virtual void Invoke(IntPtr scene) { }

}

// Namespace: 
public sealed class SetRendererCountDelegate
{
	// Methods

	// RVA: 0x5903EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x590490
	public virtual void Invoke(IntPtr scene, int count) { }

}

// Namespace: 
public sealed class SetRendererBoundsDelegate
{
	// Methods

	// RVA: 0x5904A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x590548
	public virtual void Invoke(IntPtr scene, int index, BoundingBox bounds) { }

}

// Namespace: 
public sealed class SetAreaCountDelegate
{
	// Methods

	// RVA: 0x590588
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x59062C
	public virtual void Invoke(IntPtr scene, int count) { }

}

// Namespace: 
public sealed class SetAreaPlaneCountDelegate
{
	// Methods

	// RVA: 0x590640
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5906E4
	public virtual void Invoke(IntPtr scene, int areaIndex, int count) { }

}

// Namespace: 
public sealed class SetAreaPlaneDelegate
{
	// Methods

	// RVA: 0x5906F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x59079C
	public virtual void Invoke(IntPtr scene, int areaIndex, int planeIndex, Plane plane) { }

}

// Namespace: 
public sealed class SetAreaPortalCountDelegate
{
	// Methods

	// RVA: 0x5907B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x590854
	public virtual void Invoke(IntPtr scene, int areaIndex, int count) { }

}

// Namespace: 
public sealed class SetAreaPortalDelegate
{
	// Methods

	// RVA: 0x590868
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x59090C
	public virtual void Invoke(IntPtr scene, int areaIndex, int portalIndex, Float3[] points, int pointCount, int nextAreaIndex, int planeIndex) { }

}

// Namespace: 
public sealed class SetAreaRendererCountDelegate
{
	// Methods

	// RVA: 0x590924
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x5909C8
	public virtual void Invoke(IntPtr scene, int areaIndex, int rendererCount) { }

}

// Namespace: 
public sealed class SetAreaRendererDelegate
{
	// Methods

	// RVA: 0x5909DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x590A80
	public virtual void Invoke(IntPtr scene, int areaIndex, int areaRendererIndex, int renderer) { }

}

// Namespace: 
public sealed class UpdateDelegate
{
	// Methods

	// RVA: 0x590A94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x590B38
	public virtual void Invoke(IntPtr scene, Float3 origin, Frustum frustum, int areaIndex, CullingResultsNative results) { }

}

// Namespace: 
public sealed class CullDynamicDelegate
{
	// Methods

	// RVA: 0x590B78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x590C1C
	public virtual void Invoke(IntPtr scene, Frustum frustum, DynamicCullingDataNative dynamic, int occlusion) { }

}

// Namespace: 
public sealed class GetRenderEventFuncDelegate
{
	// Methods

	// RVA: 0x590C5C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x590CFC
	public virtual IntPtr Invoke() { }

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

	// RVA: 0x5901E4
	public static IntPtr get_RenderEventFunc() { }

}

// Namespace: CFRenderLib.Core
public static class NativeLoader
{
	// Methods

	// RVA: 0x590D10
	public static extern IntPtr CreateScene() { }

	// RVA: 0x590D14
	public static extern void DeleteScene(IntPtr scene) { }

	// RVA: 0x590D18
	public static extern void SetRendererCount(IntPtr scene, int count) { }

	// RVA: 0x590D1C
	public static extern void SetRendererBounds(IntPtr scene, int index, BoundingBox bounds) { }

	// RVA: 0x590D4C
	public static extern void SetAreaCount(IntPtr scene, int count) { }

	// RVA: 0x590D50
	public static extern void SetAreaPlaneCount(IntPtr scene, int areaIndex, int count) { }

	// RVA: 0x590D54
	public static extern void SetAreaPlane(IntPtr scene, int areaIndex, int planeIndex, Plane plane) { }

	// RVA: 0x590D58
	public static extern void SetAreaPortalCount(IntPtr scene, int areaIndex, int count) { }

	// RVA: 0x590D5C
	public static extern void SetAreaPortal(IntPtr scene, int areaIndex, int portalIndex, Float3[] points, int pointCount, int nextAreaIndex, int planeIndex) { }

	// RVA: 0x590D6C
	public static extern void SetAreaRendererCount(IntPtr scene, int areaIndex, int rendererCount) { }

	// RVA: 0x590D70
	public static extern void SetAreaRenderer(IntPtr scene, int areaIndex, int areaRendererIndex, int renderer) { }

	// RVA: 0x590D74
	public static extern void Update(IntPtr scene, Float3 origin, Frustum frustum, int areaIndex, CullingResultsNative results) { }

	// RVA: 0x590DA4
	public static extern void CullDynamic(IntPtr scene, Frustum frustum, DynamicCullingDataNative dynamic, int occlusion) { }

	// RVA: 0x590DD4
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x590DD8
	public static void Init() { }

}

// Namespace: CFRenderLib.Core
public static class SphericalHarmonics
{
	// Fields
	public static float[] COSINE_LOBE; // 0x0
	public static float[] UNIFORM_LOBE; // 0x8

	// Methods

	// RVA: 0x59176C
	public static void ProjectLobe(SphericalHarmonicsL2 sh, float[] lobeCoeffs, Float4 quaternion, Float3 color) { }

	// RVA: 0x592854
	public static void ComputeUVWCoeff(int m, int n, float u, float v, float w) { }

	// RVA: 0x592F90
	public static float KroneckerDelta(int i, int j) { }

	// RVA: 0x592FA4
	public static float P(int i, int a, int b, SHRotationMatrix r) { }

	// RVA: 0x592AC0
	public static float U(int m, int n, SHRotationMatrix r) { }

	// RVA: 0x592B3C
	public static float V(int m, int n, SHRotationMatrix r) { }

	// RVA: 0x592D6C
	public static float W(int m, int n, SHRotationMatrix r) { }

	// RVA: 0x59316C
	private static void .cctor() { }

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

	// RVA: 0x59324C
	public bool get_Item(int bitIndex) { }

	// RVA: 0x5932EC
	public void set_Item(int bitIndex, bool value) { }

	// RVA: 0x5933A4
	public override string ToString() { }

}

// Namespace: CFRenderLib.Core.Structs
[Serializable]
public struct BoundingBox
{
	// Fields
	public Float3 min; // 0x10
	public Float3 max; // 0x1C
}

// Namespace: CFRenderLib.Core.Structs
[Serializable]
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

	// RVA: 0x59345C
	public void .ctor(Byte x, Byte y, Byte z, Byte w) { }

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

	// RVA: 0x58C700
	public int get_index() { }

	// RVA: 0x58C70C
	public Byte get_count() { }

	// RVA: 0x593470
	private void .ctor(UInt32 value) { }

	// RVA: 0x593478
	public static Cell get_Invalid() { }

	// RVA: 0x58C6F0
	public bool get_IsValid() { }

}

// Namespace: CFRenderLib.Core.Structs
public struct CullingResultsNative
{
	// Fields
	public IntPtr VisibleStaticObjects; // 0x10
	public int VisibleStaticObjectsCount; // 0x18
	public IntPtr VisibleOcclusionAreas; // 0x1C
	public int VisibleOcclusionAreasCount; // 0x24
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
[Serializable]
public struct Float3
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x593480
	public void .ctor(float x, float y, float z) { }

}

// Namespace: CFRenderLib.Core.Structs
[Serializable]
public struct Float4
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18
	public float w; // 0x1C

	// Methods

	// RVA: 0x59348C
	public void .ctor(float x, float y, float z, float w) { }

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

	// RVA: 0x593498
	public static Half op_Implicit(float v) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct Half2
{
	// Fields
	public Half x; // 0x10
	public Half y; // 0x12

	// Methods

	// RVA: 0x5934E0
	public void .ctor(Half x, Half y) { }

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

	// RVA: 0x5934EC
	public void .ctor(Half x, Half y, Half z, Half w) { }

}

// Namespace: CFRenderLib.Core.Structs
[Serializable]
public class OcclusionArea
{
	// Fields
	public Plane[] planes; // 0x10
	public OcclusionPortal[] portals; // 0x18
	public Float3 pivot; // 0x20
	public bool usesCustomPivot; // 0x2C
	public bool closed; // 0x2D

	// Methods

	// RVA: 0x593500
	public void .ctor() { }

}

// Namespace: CFRenderLib.Core.Structs
[Serializable]
public class OcclusionPortal
{
	// Fields
	public Float3[] points; // 0x10
	public int planeIndex; // 0x18
	public int nextAreaIndex; // 0x1C

	// Methods

	// RVA: 0x593508
	public void .ctor() { }

}

// Namespace: CFRenderLib.Core.Structs
[Serializable]
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

	// RVA: 0x592E8C
	public float get_Item(int order, int row, int column) { }

	// RVA: 0x592764
	public void set_Item(int order, int row, int column, float value) { }

	// RVA: 0x593510
	private static void .cctor() { }

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

	// RVA: 0x58F758
	public void .ctor(float x, float y, float z, float w) { }

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

	// RVA: 0x58F5D4
	public void .ctor(float x, float y, float z, float w) { }

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
[Serializable]
public struct SphericalHarmonicsL2
{
	// Fields
	public CFRenderLib.Core.Structs.SphericalHarmonicsL2.<coefficients>e__FixedBuffer coefficients; // 0x10

	// Methods

	// RVA: 0x593604
	public float get_Item(int i) { }

	// RVA: 0x59360C
	public void set_Item(int i, float value) { }

	// RVA: 0x592F70
	public float get_Item(int rgb, int coef) { }

	// RVA: 0x592F80
	public void set_Item(int rgb, int coef, float value) { }

	// RVA: 0x593614
	public System.ReadOnlySpan<System.Single> getComponent(int rgb) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct UnormHalf2
{
	// Fields
	public UInt16 x; // 0x10
	public UInt16 y; // 0x12

	// Methods

	// RVA: 0x593734
	public void .ctor(float x, float y) { }

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

	// RVA: 0x59376C
	public void .ctor(float x, float y, float z, float w) { }

}

// Namespace: CFRenderLib.Core.Collections
public class GlobalIlluminationData
{
	// Fields
	public UInt16[] probemap; // 0x10
	public float[] probes; // 0x18

	// Methods

	// RVA: 0x5937B4
	public override string ToString() { }

	// RVA: 0x58EAC8
	public void .ctor() { }

}

// Namespace: CFRenderLib.Core.Collections
public class GrowArray<T0>
{
	// Fields
	public int count; // 0x0
	public T[] items; // 0x0

	// Methods

	// RVA: 0x30D4A04
	public void .ctor(int initialSize) { }

	// RVA: 0x318DB98
	public void Add(T t) { }

	// RVA: 0x30D4CD4
	public void Add(T t) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x318DB98
	public void UnorderedRemove(T item) { }

	// RVA: 0x30D4A04
	public void UnorderedRemoveAt(int index) { }

	// RVA: 0x30DA554
	public static void ValidateBufferSize(T[] buffer, int count, int newCount) { }

}

// Namespace: CFRenderLib.Core.Collections
public class HeightField
{
	// Fields
	public const int AREA_INVALID = 0;
	public const int AREA_WALKABLE = 1;
	public const int AREA_JUMPABLE = 2;
	public const int AREA_OCCLUSION = 3;
	public const int NO_CONNECTION = 63;
	public const UInt16 MAX_HEIGHT = 32767;
	public const int SPAN_HEIGHT_BITS = 13;
	public const int SPAN_MAX_HEIGHT = 8191;
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

	// RVA: 0x58D754
	public void .ctor(int width, int height, float cellsize, float cellheight, float[] boundsmin, float[] boundsmax, int spanCount) { }

	// RVA: 0x593A00
	public override string ToString() { }

	// RVA: 0x593D20
	public static int OffsetX(int dir) { }

	// RVA: 0x593DC4
	public static int OffsetY(int dir) { }

	// RVA: 0x593E68
	public static int GetConnection(int con, int dir) { }

	// RVA: 0x593E7C
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Core.Collections
[Serializable]
public class OcclusionData
{
	// Fields
	public OcclusionArea[] areas; // 0x10

	// Methods

	// RVA: 0x594024
	public int GetAreaIndex(Float3 pos) { }

	// RVA: 0x594118
	public int GetAreaIndexCached(Float3 pos, int areaIndex) { }

	// RVA: 0x5942E8
	public void .ctor() { }

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


