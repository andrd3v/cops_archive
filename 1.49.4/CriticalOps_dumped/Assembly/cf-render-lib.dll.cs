// Namespace: 
internal class <Module>
{}

// Namespace: CFRenderLib.Core
public static class HFQueries
{
	// Methods

	// RVA: 0x578F5C
	public static void WorldToVoxelSpace(HeightField heightField, Single* position, Int32* coord) { }

	// RVA: 0x579094
	public static void VoxelToWorldSpace(HeightField heightField, Single* position, Int32* coord) { }

	// RVA: 0x579138
	public static Float3 SpanIndexToWorldPosition(HeightField heightField, int index) { }

	// RVA: 0x5792FC
	public static bool FieldAABB(HeightField heightField, Int32* coord) { }

	// RVA: 0x579368
	public static void ClampFieldAABB(HeightField heightField, Int32* coord) { }

	// RVA: 0x5793F0
	public static bool TryFindSpanInCoord(HeightField heightField, Int32* coord, int spanIndex) { }

	// RVA: 0x5794E4
	public static bool TryGetSpanPositionAtWorldPosition(HeightField heightField, Float3 position, Float3 spanPos) { }

}

// Namespace: CFRenderLib.Core
public static class HFSerialization
{
	// Methods

	// RVA: 0x579628
	public static void Deserialize(string data, HeightField heightField) { }

	// RVA: 0x57A62C
	public static void Deserialize(string data, HeightField heightField, GlobalIlluminationData gi) { }

	// RVA: 0x57B748
	public static string BytesToString(UInt64 bytes, UInt32 decimalPlaces) { }

	// RVA: 0x57A5EC
	public static bool IsValid(HeightField heightField) { }

	// RVA: 0x57BA58
	public static bool IsValid(GlobalIlluminationData gi) { }

	// RVA: 0x57B6B8
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

	// RVA: 0x57BAA0
	public static float HorizontalToVerticalFoV(float horizontalFoV, float aspect) { }

	// RVA: 0x57BB40
	public static float VerticalToHorizontalFoV(float verticalFoV, float aspect) { }

	// RVA: 0x57BBE0
	public static bool Approximately(float actual, float expected) { }

	// RVA: 0x57BC04
	public static int Clamp(int x, int min, int max) { }

	// RVA: 0x57BC18
	public static float Clamp(float x, float min, float max) { }

	// RVA: 0x57BC38
	public static UInt32 Max(UInt32 x, UInt32 y) { }

	// RVA: 0x57BC44
	public static float Max(float x, float y) { }

	// RVA: 0x57BC50
	public static float Sqrt(float x) { }

	// RVA: 0x57BCD0
	public static float Abs(float x) { }

	// RVA: 0x57BCE0
	public static float Dot(Float3 v1, Float3 v2) { }

	// RVA: 0x57BD08
	public static Float3 Cross(Float3 v1, Float3 v2) { }

	// RVA: 0x57BD40
	public static Float3 Subtract(Float3 p1, Float3 p2) { }

	// RVA: 0x57BD60
	public static Float3 Multiply(Float3 v, float d) { }

	// RVA: 0x57BD7C
	public static Float3 Normalize(Float3 v) { }

	// RVA: 0x57BE2C
	public static float Distance(Float3 p1, Float3 p2) { }

	// RVA: 0x57BED0
	public static Plane CreatePlane(Float3 p1, Float3 p2, Float3 p3) { }

	// RVA: 0x57C00C
	public static float PlaneDistanceToPoint(Plane plane, Float3 point) { }

	// RVA: 0x57C03C
	public static Float3 Center(BoundingBox bounds) { }

	// RVA: 0x57C06C
	public static int AsInt(float x) { }

	// RVA: 0x57C074
	public static SnormHalf4 EncodeFloat3SnormHalf4(Float3 v, float encodeFactor) { }

	// RVA: 0x57C1FC
	public static SnormByte4 EncodeFloat3SnormByte4(Float3 v, float encodeFactor) { }

	// RVA: 0x57C380
	public static bool IntersectPlanesAABB(Plane[] planes, int planeCount, BoundingBox aabb) { }

	// RVA: 0x57C44C
	public static bool IntersectConvexPoint(Plane[] planes, Float3 point, float epsilon) { }

	// RVA: 0x57C514
	public static float ConvexDistanceToPoint(Plane[] planes, Float3 point) { }

	// RVA: 0x57C590
	public static float CalcSizePerDepth(float fov) { }

	// RVA: 0x57C610
	public static float SizeOnScreen(float depth, float sizePerDepth, float radius) { }

	// RVA: 0x57C61C
	public static bool ClipPolygon(Plane plane, Float3* points, int pointsLength, int numPoints, bool keepOn, float epsilon) { }

	// RVA: 0x57CA08
	public static bool ClipFrustrum(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane> frustum, CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane> newFrustum, Float3 origin, Float3[] points, int pointCount) { }

	// RVA: 0x57CC1C
	public static bool ClipFrustrum(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane> frustum, Float3[] newPoints, Float3 origin, Float3[] points, int pointCount) { }

}

// Namespace: 
public sealed class CreateSceneDelegate
{
	// Methods

	// RVA: 0x57CE68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57CF08
	public virtual IntPtr Invoke() { }

}

// Namespace: 
public sealed class DeleteSceneDelegate
{
	// Methods

	// RVA: 0x57CF1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57CFC0
	public virtual void Invoke(IntPtr scene) { }

}

// Namespace: 
public sealed class SetRendererCountDelegate
{
	// Methods

	// RVA: 0x57CFD4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D078
	public virtual void Invoke(IntPtr scene, int count) { }

}

// Namespace: 
public sealed class SetRendererBoundsDelegate
{
	// Methods

	// RVA: 0x57D08C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D130
	public virtual void Invoke(IntPtr scene, int index, BoundingBox bounds) { }

}

// Namespace: 
public sealed class SetAreaCountDelegate
{
	// Methods

	// RVA: 0x57D170
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D214
	public virtual void Invoke(IntPtr scene, int count) { }

}

// Namespace: 
public sealed class SetAreaPlaneCountDelegate
{
	// Methods

	// RVA: 0x57D228
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D2CC
	public virtual void Invoke(IntPtr scene, int areaIndex, int count) { }

}

// Namespace: 
public sealed class SetAreaPlaneDelegate
{
	// Methods

	// RVA: 0x57D2E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D384
	public virtual void Invoke(IntPtr scene, int areaIndex, int planeIndex, Plane plane) { }

}

// Namespace: 
public sealed class SetAreaPortalCountDelegate
{
	// Methods

	// RVA: 0x57D398
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D43C
	public virtual void Invoke(IntPtr scene, int areaIndex, int count) { }

}

// Namespace: 
public sealed class SetAreaPortalDelegate
{
	// Methods

	// RVA: 0x57D450
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D4F4
	public virtual void Invoke(IntPtr scene, int areaIndex, int portalIndex, Float3[] points, int pointCount, int nextAreaIndex, int planeIndex) { }

}

// Namespace: 
public sealed class SetAreaRendererCountDelegate
{
	// Methods

	// RVA: 0x57D50C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D5B0
	public virtual void Invoke(IntPtr scene, int areaIndex, int rendererCount) { }

}

// Namespace: 
public sealed class SetAreaRendererDelegate
{
	// Methods

	// RVA: 0x57D5C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D668
	public virtual void Invoke(IntPtr scene, int areaIndex, int areaRendererIndex, int renderer) { }

}

// Namespace: 
public sealed class UpdateDelegate
{
	// Methods

	// RVA: 0x57D67C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D720
	public virtual void Invoke(IntPtr scene, Float3 origin, Frustum frustum, int areaIndex, CullingResultsNative results) { }

}

// Namespace: 
public sealed class CullDynamicDelegate
{
	// Methods

	// RVA: 0x57D760
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D804
	public virtual void Invoke(IntPtr scene, Frustum frustum, DynamicCullingDataNative dynamic, int occlusion) { }

}

// Namespace: 
public sealed class GetRenderEventFuncDelegate
{
	// Methods

	// RVA: 0x57D844
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x57D8E4
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

	// RVA: 0x57CDCC
	public static IntPtr get_RenderEventFunc() { }

}

// Namespace: CFRenderLib.Core
public static class NativeLoader
{
	// Methods

	// RVA: 0x57D8F8
	public static extern IntPtr CreateScene() { }

	// RVA: 0x57D8FC
	public static extern void DeleteScene(IntPtr scene) { }

	// RVA: 0x57D900
	public static extern void SetRendererCount(IntPtr scene, int count) { }

	// RVA: 0x57D904
	public static extern void SetRendererBounds(IntPtr scene, int index, BoundingBox bounds) { }

	// RVA: 0x57D934
	public static extern void SetAreaCount(IntPtr scene, int count) { }

	// RVA: 0x57D938
	public static extern void SetAreaPlaneCount(IntPtr scene, int areaIndex, int count) { }

	// RVA: 0x57D93C
	public static extern void SetAreaPlane(IntPtr scene, int areaIndex, int planeIndex, Plane plane) { }

	// RVA: 0x57D940
	public static extern void SetAreaPortalCount(IntPtr scene, int areaIndex, int count) { }

	// RVA: 0x57D944
	public static extern void SetAreaPortal(IntPtr scene, int areaIndex, int portalIndex, Float3[] points, int pointCount, int nextAreaIndex, int planeIndex) { }

	// RVA: 0x57D954
	public static extern void SetAreaRendererCount(IntPtr scene, int areaIndex, int rendererCount) { }

	// RVA: 0x57D958
	public static extern void SetAreaRenderer(IntPtr scene, int areaIndex, int areaRendererIndex, int renderer) { }

	// RVA: 0x57D95C
	public static extern void Update(IntPtr scene, Float3 origin, Frustum frustum, int areaIndex, CullingResultsNative results) { }

	// RVA: 0x57D98C
	public static extern void CullDynamic(IntPtr scene, Frustum frustum, DynamicCullingDataNative dynamic, int occlusion) { }

	// RVA: 0x57D9BC
	public static extern IntPtr GetRenderEventFunc() { }

	// RVA: 0x57D9C0
	public static void Init() { }

}

// Namespace: CFRenderLib.Core
public static class SphericalHarmonics
{
	// Fields
	public static float[] COSINE_LOBE; // 0x0
	public static float[] UNIFORM_LOBE; // 0x8

	// Methods

	// RVA: 0x57E354
	public static void ProjectLobe(SphericalHarmonicsL2 sh, float[] lobeCoeffs, Float4 quaternion, Float3 color) { }

	// RVA: 0x57F43C
	public static void ComputeUVWCoeff(int m, int n, float u, float v, float w) { }

	// RVA: 0x57FB78
	public static float KroneckerDelta(int i, int j) { }

	// RVA: 0x57FB8C
	public static float P(int i, int a, int b, SHRotationMatrix r) { }

	// RVA: 0x57F6A8
	public static float U(int m, int n, SHRotationMatrix r) { }

	// RVA: 0x57F724
	public static float V(int m, int n, SHRotationMatrix r) { }

	// RVA: 0x57F954
	public static float W(int m, int n, SHRotationMatrix r) { }

	// RVA: 0x57FD54
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

	// RVA: 0x57FE34
	public bool get_Item(int bitIndex) { }

	// RVA: 0x57FED4
	public void set_Item(int bitIndex, bool value) { }

	// RVA: 0x57FF8C
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

	// RVA: 0x580044
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

	// RVA: 0x5792E8
	public int get_index() { }

	// RVA: 0x5792F4
	public Byte get_count() { }

	// RVA: 0x580058
	private void .ctor(UInt32 value) { }

	// RVA: 0x580060
	public static Cell get_Invalid() { }

	// RVA: 0x5792D8
	public bool get_IsValid() { }

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
[Serializable]
public struct Float3
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x580068
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

	// RVA: 0x580074
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

	// RVA: 0x580080
	public static Half op_Implicit(float v) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct Half2
{
	// Fields
	public Half x; // 0x10
	public Half y; // 0x12

	// Methods

	// RVA: 0x5800C8
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

	// RVA: 0x5800D4
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

	// RVA: 0x5800E8
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

	// RVA: 0x5800F0
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

	// RVA: 0x57FA74
	public float get_Item(int order, int row, int column) { }

	// RVA: 0x57F34C
	public void set_Item(int order, int row, int column, float value) { }

	// RVA: 0x5800F8
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

	// RVA: 0x57C340
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

	// RVA: 0x57C1BC
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

	// RVA: 0x5801EC
	public float get_Item(int i) { }

	// RVA: 0x5801F4
	public void set_Item(int i, float value) { }

	// RVA: 0x57FB58
	public float get_Item(int rgb, int coef) { }

	// RVA: 0x57FB68
	public void set_Item(int rgb, int coef, float value) { }

	// RVA: 0x5801FC
	public System.ReadOnlySpan<System.Single> getComponent(int rgb) { }

}

// Namespace: CFRenderLib.Core.Structs
public struct UnormHalf2
{
	// Fields
	public UInt16 x; // 0x10
	public UInt16 y; // 0x12

	// Methods

	// RVA: 0x58031C
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

	// RVA: 0x580354
	public void .ctor(float x, float y, float z, float w) { }

}

// Namespace: CFRenderLib.Core.Collections
public class GlobalIlluminationData
{
	// Fields
	public UInt16[] probemap; // 0x10
	public float[] probes; // 0x18

	// Methods

	// RVA: 0x58039C
	public override string ToString() { }

	// RVA: 0x57B6B0
	public void .ctor() { }

}

// Namespace: CFRenderLib.Core.Collections
public class GrowArray<T0>
{
	// Fields
	public int count; // 0x0
	public T[] items; // 0x0

	// Methods

	// RVA: 0x30A24F0
	public void .ctor(int initialSize) { }

	// RVA: 0x315B3A8
	public void Add(T t) { }

	// RVA: 0x30A27C0
	public void Add(T t) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x315B3A8
	public void UnorderedRemove(T item) { }

	// RVA: 0x30A24F0
	public void UnorderedRemoveAt(int index) { }

	// RVA: 0x30A8040
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

	// RVA: 0x57A33C
	public void .ctor(int width, int height, float cellsize, float cellheight, float[] boundsmin, float[] boundsmax, int spanCount) { }

	// RVA: 0x5805E8
	public override string ToString() { }

	// RVA: 0x580908
	public static int OffsetX(int dir) { }

	// RVA: 0x5809AC
	public static int OffsetY(int dir) { }

	// RVA: 0x580A50
	public static int GetConnection(int con, int dir) { }

	// RVA: 0x580A64
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Core.Collections
[Serializable]
public class OcclusionData
{
	// Fields
	public OcclusionArea[] areas; // 0x10

	// Methods

	// RVA: 0x580C0C
	public int GetAreaIndex(Float3 pos) { }

	// RVA: 0x580D00
	public int GetAreaIndexCached(Float3 pos, int areaIndex) { }

	// RVA: 0x580ED0
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


