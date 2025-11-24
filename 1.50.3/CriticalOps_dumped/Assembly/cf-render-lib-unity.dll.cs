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

	// RVA: 0x56B3F4
	private static MonoScriptData Get() { }

	// RVA: 0x56B4F8
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity
public enum AtlasClearColor
{
	// Fields
	public int value__; // 0x10
	public const AtlasClearColor Black = 0;
	public const AtlasClearColor Grey = 1;
}

// Namespace: CFRenderLib.Unity
public enum BlitTarget
{
	// Fields
	public Byte value__; // 0x10
	public const BlitTarget Offscreen = 0;
	public const BlitTarget Override = 1;
	public const BlitTarget Screen = 2;
}

// Namespace: CFRenderLib.Unity
public enum CFCommandBufferEvent
{
	// Fields
	public Byte value__; // 0x10
	public const CFCommandBufferEvent BeforeScene = 0;
	public const CFCommandBufferEvent AfterScene = 1;
	public const CFCommandBufferEvent BeforeUI = 2;
	public const CFCommandBufferEvent AfterUI = 3;
	public const CFCommandBufferEvent BeforeRender = 4;
	public const CFCommandBufferEvent AfterRender = 5;
}

// Namespace: CFRenderLib.Unity
public enum CFRenderEvent
{
	// Fields
	public Byte value__; // 0x10
	public const CFRenderEvent FrameSetup = 0;
	public const CFRenderEvent BeforeFrame = 1;
	public const CFRenderEvent AfterFrame = 2;
	public const CFRenderEvent BeforeRender = 3;
	public const CFRenderEvent AfterRender = 4;
	public const CFRenderEvent BeforeCull = 5;
	public const CFRenderEvent AfterCull = 6;
	public const CFRenderEvent BeforeGatherCommands = 7;
	public const CFRenderEvent AfterGatherCommands = 8;
	public const CFRenderEvent AfterScene = 9;
}

// Namespace: CFRenderLib.Unity
public enum DynamicCullingState
{
	// Fields
	public Byte value__; // 0x10
	public const DynamicCullingState Culled = 0;
	public const DynamicCullingState Undetermined = 1;
	public const DynamicCullingState Visible = 2;
}

// Namespace: CFRenderLib.Unity
internal enum RenderEventType
{
	// Fields
	public int value__; // 0x10
	public const RenderEventType SetIndices = 0;
	public const RenderEventType DrawIndexRanges = 1;
}

// Namespace: CFRenderLib.Unity
public static class Extensions
{
	// Methods

	// RVA: 0x56B500
	public static Vector3 ToUnity(Float3 v) { }

	// RVA: 0x56B504
	public static Float3 FromUnity(Vector3 v) { }

	// RVA: 0x56B508
	public static Plane ToUnity(Plane v) { }

	// RVA: 0x56B61C
	public static Plane FromUnity(Plane v) { }

	// RVA: 0x56B620
	public static SphericalHarmonicsL2 ToUnity(SphericalHarmonicsL2 sh) { }

	// RVA: 0x56B7FC
	public static SphericalHarmonicsL2 FromUnity(SphericalHarmonicsL2 unitysh) { }

	// RVA: 0x56BA04
	public static Bounds ToUnity(BoundingBox b) { }

	// RVA: 0x56BA4C
	public static BoundingBox FromUnity(Bounds v) { }

	// RVA: 0x56BA94
	public static Float4 FromUnity(Quaternion q) { }

	// RVA: 0x56BAC4
	public static Float4 FromUnityRGBA(Color c) { }

	// RVA: 0x56BAF4
	public static Float3 FromUnityRGB(Color c) { }

}

// Namespace: CFRenderLib.Unity
public class GameObjectFactory
{
	// Methods

	// RVA: 0x56BB28
	public GameObject Create(string name) { }

	// RVA: 0x56BB90
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity
public interface IGameObjectFactory
{
	// Methods

	// RVA: -1
	public abstract GameObject Create(string name) { }

}

// Namespace: CFRenderLib.Unity.TextureCompression
public static class TextureCompression
{
	// Methods

	// RVA: 0x56BB98
	public static void Clear(TextureCompressionInfo tc, RawTextureData data, AtlasClearColor clearColor) { }

	// RVA: 0x56BED0
	public static void CopyTexture(TextureCompressionInfo tc, RawTextureData source, RawTextureData target, int targetX, int targetY, int targetWidth, int targetHeight) { }

	// RVA: 0x56C608
	public static int GetBlockStartIndex(TextureCompressionInfo tc, RawTextureData tex, int mipmap, int blockX, int blockY) { }

	// RVA: 0x56C76C
	private static void ClearBlock(TextureCompressionInfo tc, RawTextureData data, int x, int y, int mipmap, Byte[] clearBlock) { }

	// RVA: 0x56BCE0
	private static void ClearMipmap(TextureCompressionInfo tc, RawTextureData data, int mipmap, Byte[] clearBlock) { }

	// RVA: 0x56C818
	private static void CopyBlock(TextureCompressionInfo tc, RawTextureData source, int sourceX, int sourceY, RawTextureData target, int targetX, int targetY, int sourceMipmap, int targetMipmap) { }

	// RVA: 0x56C3E8
	private static void CopyMipmap(TextureCompressionInfo tc, RawTextureData source, RawTextureData target, int targetX, int targetY, int sourceMipmap, int targetMipmap) { }

	// RVA: 0x56C6FC
	private static int MortonEncode(int x, int y) { }

}

// Namespace: CFRenderLib.Unity.TextureCompression
public class TextureCompressionInfo
{
	// Fields
	public int bitsPerPixel; // 0x10
	public int blockWidth; // 0x14
	public int bytesPerBlock; // 0x18
	public int minWidth; // 0x1C
	public bool blocksInMortonOrder; // 0x20
	public Byte[] Black; // 0x28
	public Byte[] Grey; // 0x30

	// Methods

	// RVA: 0x56BC14
	public Byte[] GetColor(AtlasClearColor color) { }

	// RVA: 0x56C8F8
	public static TextureCompressionInfo Get(Texture2D tex) { }

	// RVA: 0x56CF34
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct AreaRendererData
{
	// Fields
	public int[] Renderers; // 0x10
}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct AtlasedMaterial
{
	// Fields
	public Material baseMaterial; // 0x10
	public Byte atlasPackingIndex; // 0x18
	public AtlasedTexture[] textures; // 0x20
	public Material atlasMaterial; // 0x28
}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct AtlasedTexture
{
	// Fields
	public string propertyName; // 0x10
	public UInt16 atlasIndex; // 0x18
}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct AtlasParameters
{
	// Fields
	public int sizeDivider; // 0x10
	public AtlasClearColor clearColor; // 0x14
}

// Namespace: CFRenderLib.Unity.Structs
public struct BatchedMeshInstance
{
	// Fields
	public UInt16 batchIndex; // 0x10
	public UInt16 submeshIndex; // 0x12
}

// Namespace: CFRenderLib.Unity.Structs
public class CullingResults
{
	// Fields
	public bool ChangedThisFrame; // 0x10
	public int[] VisibleDynamicObjects; // 0x18
	public int VisibleDynamicObjectsCount; // 0x20
	public int[] VisibleStaticObjects; // 0x28
	public int VisibleStaticObjectsCount; // 0x30
	public Byte[] VisibleOcclusionAreas; // 0x38
	public int VisibleOcclusionAreasCount; // 0x40

	// Methods

	// RVA: 0x56CF3C
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct CustomCommandBufferPass
{
	// Fields
	public readonly int RenderQueue; // 0x10
	public readonly System.Action<UnityEngine.Rendering.CommandBuffer> Callback; // 0x18

	// Methods

	// RVA: 0x56CF44
	public void .ctor(int renderQueue, System.Action<UnityEngine.Rendering.CommandBuffer> callback) { }

	// RVA: 0x56CF54
	public bool Equals(CustomCommandBufferPass other) { }

}

// Namespace: CFRenderLib.Unity.Structs
internal struct DataIndex
{
	// Fields
	public UInt16 version; // 0x10
	public UInt16 dataIndex; // 0x12
	public UInt16 nextFreeIndex; // 0x12
}

// Namespace: CFRenderLib.Unity.Structs
public struct DrawCall
{
	// Fields
	private const Byte FLAG_LIGHTPROBES = 1;
	private const Byte FLAG_REFLECTIONS = 2;
	public Mesh mesh; // 0x10
	public Renderer renderer; // 0x18
	public Material material; // 0x20
	public MaterialPropertyBlock materialPropertyBlock; // 0x28
	public Matrix4x4 matrix; // 0x30
	public SphericalHarmonicsL2 sh; // 0x70
	public Vector4 lightmapST; // 0xDC
	public Byte submeshIndex; // 0xEC
	public Byte lightmapIndex; // 0xED
	public Byte reflectionProbeIndex; // 0xEE
	private Byte flags; // 0xEF
	public int shaderPass; // 0xF0

	// Methods

	// RVA: 0x56CF94
	public bool get_enableLightProbes() { }

	// RVA: 0x56CFA0
	public void set_enableLightProbes(bool value) { }

	// RVA: 0x56CFB4
	public bool get_enableReflectionProbes() { }

	// RVA: 0x56CFC0
	public void set_enableReflectionProbes(bool value) { }

}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct FloatRect
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float width; // 0x18
	public float height; // 0x1C

	// Methods

	// RVA: 0x56CFE0
	public void .ctor(float x, float y, float w, float h) { }

	// RVA: 0x56CFEC
	public Rect ToUnityRect() { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct Handle<T0>
{
	// Fields
	public UInt16 index; // 0x0
	public UInt16 version; // 0x0
}

// Namespace: CFRenderLib.Unity.Structs
public struct IndexRange
{
	// Fields
	public UInt32 indexStart; // 0x10
	public UInt32 indexCount; // 0x14
}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct IntRect
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public int width; // 0x18
	public int height; // 0x1C

	// Methods

	// RVA: 0x56CFF8
	public static IntRect MinMax(int xMin, int yMin, int xMax, int yMax) { }

	// RVA: 0x56D014
	public void .ctor(int x, int y, int w, int h) { }

}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct LightmapObject
{
	// Fields
	public Transform transform; // 0x10
	public int lightmapIndex; // 0x18
	public Vector4 lightmapST; // 0x1C
}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct LightmapRect
{
	// Fields
	public Vector4 lightmapScaleOffset; // 0x10
	public Byte lightmapIndex; // 0x20
}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct MaterialInfo
{
	// Fields
	public Material material; // 0x10
	public UInt16 atlasRectIndex; // 0x18
	public UInt16 atlasedMaterialIndex; // 0x1A
}

// Namespace: CFRenderLib.Unity.Structs
public struct MeshChannelData
{
	// Fields
	public bool hasUv1; // 0x10
	public bool hasUv2; // 0x11
	public bool hasNormals; // 0x12
	public bool hasColors; // 0x13

	// Methods

	// RVA: 0x56D020
	public bool Equals(MeshChannelData m) { }

	// RVA: 0x56D06C
	public void .ctor(MeshData mesh) { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct MipmapData
{
	// Fields
	public int startIndex; // 0x10
	public int blocksX; // 0x14
	public int blocksY; // 0x18
}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public class Point
{
	// Fields
	public Float3 pos; // 0x10

	// Methods

	// RVA: 0x56D0E4
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct Portal
{
	// Fields
	public int left; // 0x10
	public int right; // 0x14
	public Byte areaIndex; // 0x18
}

// Namespace: CFRenderLib.Unity.Structs
public struct PortalClip
{
	// Fields
	public Float3[] points; // 0x10
}

// Namespace: CFRenderLib.Unity.Structs
public struct RenderableData
{
	// Fields
	public IRenderable renderable; // 0x10
	public BoundingSphere bounds; // 0x18
	public Byte areaIndex; // 0x28
	public DynamicCullingState cullingState; // 0x29
	public float lodSize; // 0x2C
	public float depth; // 0x30
}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct SceneRasterizationConfiguration
{
	// Fields
	public LayerMask walkableMask; // 0x10
	public LayerMask occlusionMask; // 0x14
	public LayerMask jumpableMask; // 0x18
	public Vector3 boundsMin; // 0x1C
	public Vector3 boundsMax; // 0x28
	public Vector3 walkablePosition; // 0x34
	public int flagMergeThresold; // 0x40
	public float cellSize; // 0x44
	public float cellHeight; // 0x48
	public float angleThreshold; // 0x4C
	public float minCharacterHeight; // 0x50
	public float maxJumpHeight; // 0x54
	public float maxCharacterDrop; // 0x58
	public float probeHeight; // 0x5C
	public Byte probeSampleStride; // 0x60
	public float probeMergeThreshold; // 0x64

	// Methods

	// RVA: 0x56D0EC
	public static SceneRasterizationConfiguration get_Default() { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct SHLight
{
	// Fields
	public readonly Vector3 Position; // 0x10
	public readonly Color StartColor; // 0x1C
	public readonly Color EndColor; // 0x2C
	public readonly float SquareRadius; // 0x3C
	public readonly float Duration; // 0x40
	public readonly float FadeTime; // 0x44
	public float EndTime; // 0x48

	// Methods

	// RVA: 0x56D184
	public void .ctor(Vector3 position, Color startColor, Color endColor, float radius, float duration, float fadeTime) { }

	// RVA: 0x56D1B8
	public override int GetHashCode() { }

	// RVA: 0x56D22C
	public override bool Equals(object other) { }

}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public class StaticMeshInstance
{
	// Fields
	public UInt32 lightmapRectIndex; // 0x10
	public UInt16 materialIndex; // 0x14
	public Matrix4x4 matrix; // 0x18
	public Mesh mesh; // 0x58
	public UInt16 submeshIndex; // 0x60

	// Methods

	// RVA: 0x56D2C8
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct SubmeshData
{
	// Fields
	public Mesh mesh; // 0x10
	public int submeshIndex; // 0x18
	public MeshData meshData; // 0x20
}

// Namespace: CFRenderLib.Unity.Structs
public class TemporaryMeshData
{
	// Fields
	private readonly UInt32 capacity; // 0x10
	public Byte[] buffer; // 0x18
	public VertexAttributeDescriptor[] attributes; // 0x20
	public int[] offsets; // 0x28
	public int stride; // 0x30
	private int index; // 0x34

	// Methods

	// RVA: 0x56D2D0
	public int get_vertexCount() { }

	// RVA: 0x56D2D8
	public int get_size() { }

	// RVA: 0x56D2E4
	public void .ctor(UInt32 capacity) { }

	// RVA: 0x56D3F8
	public void SetAttributes(MeshChannelData channels, bool useHalfPrecision) { }

	// RVA: 0x56D788
	public void SetFloat3(VertexAttribute attribute, Float3 value) { }

	// RVA: 0x56D800
	public void SetColor32(VertexAttribute attribute, Color32 value) { }

	// RVA: 0x56D878
	public void SetSnormByte4(VertexAttribute attribute, SnormByte4 value) { }

	// RVA: 0x56D8F0
	public void SetHalf2(VertexAttribute attribute, Half2 value) { }

	// RVA: 0x56D968
	public void SetHalf4(VertexAttribute attribute, Half4 value) { }

	// RVA: 0x56D9E0
	public void SetUnormHalf2(VertexAttribute attribute, UnormHalf2 value) { }

	// RVA: 0x56DA58
	public void SetUnormHalf4(VertexAttribute attribute, UnormHalf4 value) { }

	// RVA: 0x56DAD0
	public void SetSnormHalf4(VertexAttribute attribute, SnormHalf4 value) { }

	// RVA: 0x56DB48
	public void SubmitVertex() { }

}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct TextureAtlasPacking
{
	// Fields
	public TextureAtlasRect[] rects; // 0x10
	public int atlasWidth; // 0x18
	public int atlasHeight; // 0x1C
}

// Namespace: CFRenderLib.Unity.Structs
[Serializable]
public struct TextureAtlasRect
{
	// Fields
	public const float AtlasUVPaddingPixels = 2;
	public IntRect pixelRect; // 0x10
	public FloatRect uvRect; // 0x20
	public bool rotated; // 0x30

	// Methods

	// RVA: 0x56DBD8
	public Vector2 AdjustUV(Vector2 uv) { }

}

// Namespace: CFRenderLib.Unity.Services
public interface ISceneReflectionProbesUtilityService
{
	// Methods

	// RVA: -1
	public abstract void ApplyOffset(Byte index) { }

	// RVA: -1
	public abstract void ApplyOffset(Byte index, CommandBuffer commandBuffer) { }

}

// Namespace: CFRenderLib.Unity.Services
public class SceneReflectionProbesUtility
{
	// Methods

	// RVA: 0x56DCAC
	public void ApplyOffset(Byte index) { }

	// RVA: 0x56DD1C
	public void ApplyOffset(Byte index, CommandBuffer commandBuffer) { }

	// RVA: 0x56DDAC
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal class ApplicationWrapper
{
	// Methods

	// RVA: 0x56DDB4
	public string get_DataPath() { }

	// RVA: 0x56DE24
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IApplicationService
{
	// Methods

	// RVA: -1
	public abstract string get_DataPath() { }

}

// Namespace: CFRenderLib.Unity.Services
internal class DebugWrapper
{
	// Methods

	// RVA: 0x56DE2C
	public void LogError(string message) { }

	// RVA: 0x56DEB4
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IDebugService
{
	// Methods

	// RVA: -1
	public abstract void LogError(string message) { }

}

// Namespace: CFRenderLib.Unity.Services
public class DynamicLightingUtilityWrapper
{
	// Methods

	// RVA: 0x56DEBC
	public void SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x56E014
	public void SetReflectionMaps(Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

	// RVA: 0x56E2F8
	public void .ctor() { }

	// RVA: 0x56E300
	private void CFRenderLib.Unity.Services.IDynamicLightingUtilityService.SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x56E3AC
	private void CFRenderLib.Unity.Services.IDynamicLightingUtilityService.SetReflectionMaps(Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

}

// Namespace: CFRenderLib.Unity.Services
public interface IDynamicLightingUtilityService
{
	// Methods

	// RVA: -1
	public abstract void SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: -1
	public abstract void SetReflectionMaps(Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class GLWrapper
{
	// Methods

	// RVA: 0x56E3B8
	public void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x56E3C8
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IGLService
{
	// Methods

	// RVA: -1
	public abstract void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

}

// Namespace: CFRenderLib.Unity.Services
public class GraphicsWrapper
{
	// Methods

	// RVA: 0x56E3D0
	public void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x56E44C
	public void Blit(Texture source, Material sourceMaterial) { }

	// RVA: 0x56E4B8
	public void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

	// RVA: 0x56E54C
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
public interface IGraphicsService
{
	// Methods

	// RVA: -1
	public abstract void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: -1
	public abstract void Blit(Texture source, Material sourceMaterial) { }

	// RVA: -1
	public abstract void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class GUILayoutWrapper
{
	// Methods

	// RVA: 0x56E554
	public bool Button(string label, GUILayoutOption[] options) { }

	// RVA: 0x56E564
	public void FlexibleSpace() { }

	// RVA: 0x56E56C
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IGUILayoutService
{
	// Methods

	// RVA: -1
	public abstract bool Button(string label, GUILayoutOption[] options) { }

	// RVA: -1
	public abstract void FlexibleSpace() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IMathfService
{
	// Methods

	// RVA: -1
	public abstract bool IsPowerOfTwo(int value) { }

	// RVA: -1
	public abstract int ClosestPowerOfTwo(int value) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class MathfWrapper
{
	// Methods

	// RVA: 0x56E574
	public int ClosestPowerOfTwo(int value) { }

	// RVA: 0x56E580
	public bool IsPowerOfTwo(int value) { }

	// RVA: 0x56E58C
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IRenderTextureService
{
	// Methods

	// RVA: -1
	public abstract RenderTexture get_Active() { }

	// RVA: -1
	public abstract void set_Active(RenderTexture value) { }

	// RVA: -1
	public abstract RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: -1
	public abstract void ReleaseTemporary(RenderTexture renderTexture) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class RenderTextureWrapper
{
	// Methods

	// RVA: 0x56E594
	public RenderTexture get_Active() { }

	// RVA: 0x56E59C
	public void set_Active(RenderTexture value) { }

	// RVA: 0x56E5A8
	public RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x56E5C0
	public void ReleaseTemporary(RenderTexture renderTexture) { }

	// RVA: 0x56E5CC
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface ISceneManagerService
{
	// Methods

	// RVA: -1
	public abstract Scene GetActiveScene() { }

}

// Namespace: CFRenderLib.Unity.Services
internal class SceneManagerWrapper
{
	// Methods

	// RVA: 0x56E5D4
	public Scene GetActiveScene() { }

	// RVA: 0x56E644
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IShaderService
{
	// Methods

	// RVA: -1
	public abstract void DisableKeyword(string keyword) { }

	// RVA: -1
	public abstract void EnableKeyword(string keyword) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class ShaderWrapper
{
	// Methods

	// RVA: 0x56E64C
	public void DisableKeyword(string keyword) { }

	// RVA: 0x56E658
	public void EnableKeyword(string keyword) { }

	// RVA: 0x56E664
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
internal class CFRenderer
{
	// Fields
	private RenderPass[] m_renderQueue; // 0x10
	private int[] m_renderQueueOrder; // 0x18
	private int m_renderFrame; // 0x20
	private RenderState m_renderState; // 0x28
	private Material m_nullMaterial; // 0x30
	private UInt16 m_currentDepth; // 0x38
	private bool m_recordDrawCalls; // 0x3A
	private readonly CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Unity.Structs.DrawCall> m_recordedDrawCalls; // 0x40
	public SceneLightmapData sceneLightingData; // 0x48
	public static readonly bool UseDrawIndexRanges; // 0x0
	public static readonly bool UseSetIndices; // 0x1
	private static readonly int TransparentQueueMin; // 0x4

	// Methods

	// RVA: 0x56E66C
	public void .ctor() { }

	// RVA: 0x56EA94
	private Material get_NullMaterial() { }

	// RVA: 0x56EBE0
	private void CFRenderLib.Unity.Interfaces.IRenderer.Draw(DrawCall drawCall) { }

	// RVA: 0x56EF98
	private void CFRenderLib.Unity.Interfaces.IRenderer.Render(RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer) { }

	// RVA: 0x56FB0C
	private void CFRenderLib.Unity.Interfaces.IRenderer.BeginRecordDrawCalls() { }

	// RVA: 0x56FB68
	private bool CFRenderLib.Unity.Interfaces.IRenderer.EndRecordDrawCalls(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Unity.Structs.DrawCall>& recordedDrawCalls) { }

	// RVA: 0x56FBB4
	public void CleanUp() { }

	// RVA: 0x56F164
	public void Render(StaticBatcher staticBatcher, RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer, System.Collections.Generic.IReadOnlyList<System.Int32> copyDepthPasses, RenderTexture copyDepthSource, System.Collections.Generic.IReadOnlyList<CFRenderLib.Unity.Structs.CustomCommandBufferPass> customCommandBufferPasses) { }

	// RVA: 0x56EDA0
	private UInt16 GetRenderQueueIndex(Material material) { }

	// RVA: 0x5701F4
	private void SortInstancesToQueueAndBatches(StaticBatcher staticBatcher, int[] instances, int instanceCount) { }

	// RVA: 0x5707B4
	private void UpdateIndexRanges(StaticBatch batch) { }

	// RVA: 0x570A04
	private void UpdateIndexBuffer(StaticBatch batch) { }

	// RVA: 0x56FBB8
	private void ClearDrawCalls() { }

	// RVA: 0x56FC60
	private void SortDynamicToQueue(RenderableData[] renderableDatas, int renderableCount, CullingResults cullingResults) { }

	// RVA: 0x570764
	private void ExecuteRenderPass(RenderPass pass, StaticBatcher staticBatcher) { }

	// RVA: 0x571344
	private void RenderStatic(RenderPass pass, StaticBatcher staticBatcher) { }

	// RVA: 0x571034
	private void RenderDynamic(RenderPass pass) { }

	// RVA: 0x57232C
	private void RenderDrawCall(DrawCall dc, RenderTargetIdentifier[] lightmapTextures, int lightmapCount) { }

	// RVA: 0x572C8C
	private static void .cctor() { }

	// RVA: 0x572D80
	private int <GetRenderQueueIndex>b__21_0(int q1, int q2) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly CFRenderLib.Unity.RenderPipeline.CFRenderPipeline.<>c <>9; // 0x0
	public static System.Comparison<CFRenderLib.Unity.Structs.CustomCommandBufferPass> <>9__37_0; // 0x8

	// Methods

	// RVA: 0x577B40
	private static void .cctor() { }

	// RVA: 0x577BAC
	public void .ctor() { }

	// RVA: 0x577BB4
	internal int <Render>b__37_0(CustomCommandBufferPass a, CustomCommandBufferPass b) { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public class CFRenderPipeline
{
	// Fields
	private const int DepthBufferBits = 24;
	private static readonly CFRenderLib.Core.Collections.GrowArray<System.Action<UnityEngine.Camera,System.Boolean>>[] RenderEvents; // 0x0
	private static readonly CFRenderLib.Core.Collections.GrowArray<UnityEngine.Rendering.CommandBuffer>[] CustomCommandBuffers; // 0x8
	private static readonly System.Collections.Generic.List<System.Int32> DepthCopyPasses; // 0x10
	private static readonly System.Collections.Generic.List<CFRenderLib.Unity.Structs.CustomCommandBufferPass> CustomCommandBufferPasses; // 0x18
	private static System.Action<System.Exception> CaughtExceptionCallback; // 0x20
	private static readonly UInt32 UILayerMask; // 0x28
	private static RenderTexture m_currentFrameOverrideTarget; // 0x30
	private static BlitTarget m_blitTarget; // 0x38
	private static bool m_allowHDR; // 0x39
	private static ScriptableRenderContext m_frameContext; // 0x40
	private static Material m_blitAlphaBlendMaterial; // 0x48
	private static Material m_blitDepthMinMaterial; // 0x50
	private static bool m_hasLowResColor; // 0x58
	private static bool m_hasLowResDepth; // 0x59
	private readonly CommandBuffer m_commandBuffer; // 0x18
	private static Culling m_culling; // 0x60
	private static CullingResults m_cullingResults; // 0x68
	private DynamicCullingData m_cullingDynamic; // 0x20
	private CFRenderer m_renderer; // 0x28
	private StaticBatcher m_staticBatcher; // 0x30
	private Scene m_currentScene; // 0x38
	private StaticSceneData m_sceneData; // 0x40
	private OcclusionComponent m_occlusionComponent; // 0x48
	private static System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> <ActRenderPrefab>k__BackingField; // 0x70
	private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> <ActRenderPreview>k__BackingField; // 0x78
	private static System.Action<UnityEngine.Camera> <ActRenderUI>k__BackingField; // 0x80

	// Methods

	// RVA: 0x572DD8
	internal static System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> get_ActRenderPrefab() { }

	// RVA: 0x572E54
	internal static void set_ActRenderPrefab(System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> value) { }

	// RVA: 0x572EC0
	internal static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> get_ActRenderPreview() { }

	// RVA: 0x572F3C
	internal static void set_ActRenderPreview(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> value) { }

	// RVA: 0x572FA8
	internal static System.Action<UnityEngine.Camera> get_ActRenderUI() { }

	// RVA: 0x573024
	internal static void set_ActRenderUI(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x573090
	protected override void Render(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x573094
	protected override void Render(ScriptableRenderContext renderContext, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x5744D8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x5738D8
	private void Render(ScriptableRenderContext context, Camera camera, bool copyDepth, bool isUICamera) { }

	// RVA: 0x5747BC
	private void GatherCommands(ScriptableRenderContext context, Camera camera, bool copyDepth) { }

	// RVA: 0x574A94
	private void RenderUI(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x574F38
	public static void SetOverrideRenderTarget(RenderTexture renderTexture) { }

	// RVA: 0x574FA4
	public static void RegisterCommandBuffer(CFCommandBufferEvent commandBufferEvent, CommandBuffer commandBuffer) { }

	// RVA: 0x5751EC
	public static void UnRegisterCommandBuffer(CFCommandBufferEvent commandBufferEvent, CommandBuffer commandBuffer) { }

	// RVA: 0x5752FC
	public static void RegisterRenderEvent(CFRenderEvent renderEvent, System.Action<UnityEngine.Camera,System.Boolean> action) { }

	// RVA: 0x575544
	public static void UnRegisterRenderEvent(CFRenderEvent renderEvent, System.Action<UnityEngine.Camera,System.Boolean> action) { }

	// RVA: 0x575654
	public static void AddDepthCopyPass(int renderQueue) { }

	// RVA: 0x575754
	public static void AddCustomCommandBufferPass(int renderQueue, System.Action<UnityEngine.Rendering.CommandBuffer> callback) { }

	// RVA: 0x57585C
	public static void StartLowResPass(CommandBuffer commandBuffer, int width, int height) { }

	// RVA: 0x575A58
	public static void EndLowResPass(CommandBuffer commandBuffer, bool blitColor, bool blitDepth) { }

	// RVA: 0x5761D0
	public static int GetOcclusionAreaIndex(Vector3 position) { }

	// RVA: 0x5762D4
	public static int GetVisibleOcclusionAreaCount() { }

	// RVA: 0x576380
	public static bool IsOcclusionAreaVisible(int index) { }

	// RVA: 0x5764E0
	public static void SetCaughtExceptionCallback(System.Action<System.Exception> action) { }

	// RVA: 0x56C544
	internal static void CaughtException(Exception ex) { }

	// RVA: 0x574D1C
	private void RenderCustom(Camera camera, bool disableCulling, bool copyDepth) { }

	// RVA: 0x57654C
	private void UpdateCulling(Camera camera, bool disableCulling, bool copyDepth) { }

	// RVA: 0x57685C
	private void UpdateDynamicObjectBounds() { }

	// RVA: 0x573800
	private void CheckSceneInitialization() { }

	// RVA: 0x576E40
	private void InitializeScene() { }

	// RVA: 0x57745C
	private void InitializeCulling() { }

	// RVA: 0x5744DC
	private void CleanUpSceneData() { }

	// RVA: 0x5736DC
	private void InvokeRenderEvent(CFRenderEvent renderEvent, Camera camera, bool renderIntoTexture) { }

	// RVA: 0x57468C
	private void InvokeCommandBuffers(CFCommandBufferEvent commandBufferEvent, ScriptableRenderContext context) { }

	// RVA: 0x57781C
	public void .ctor() { }

	// RVA: 0x5778C0
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public class CFRenderPipelineAsset
{
	// Methods

	// RVA: 0x577BBC
	protected override RenderPipeline CreatePipeline() { }

	// RVA: 0x577C10
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class DynamicLightingUtility
{
	// Methods

	// RVA: 0x577C18
	public static void GetFullDynamicLight(Vector3 position, SphericalHarmonicsL2 cachedProbe, DrawCall drawCall, MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x577FF4
	public static Color ShadeSH9(SphericalHarmonicsL2 sh, Vector3 normal) { }

	// RVA: 0x5788A8
	public static void GetDominantSHLight(SphericalHarmonicsL2 sh, float upBias, Vector3 direction, Color color) { }

	// RVA: 0x578C70
	public static Color GetAmbientSHLight(SphericalHarmonicsL2 sh) { }

	// RVA: 0x578D7C
	public static Color GetReflectionFallBackColor(SphericalHarmonicsL2 sh) { }

	// RVA: 0x578ED0
	public static void SetEnviromentImage(CFEnvironmentImage image) { }

	// RVA: 0x579754
	public static void SetEnviromentImage(CFEnvironmentImage image, CommandBuffer commandBuffer) { }

	// RVA: 0x579AE4
	public static void SetEnviromentImage(CFEnvironmentImage image, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x57A444
	public static void SetEnviromentImage(CFEnvironmentImage image, Material material) { }

	// RVA: 0x57ADA4
	public static void GetSHCoefficients(Vector3 position, SphericalHarmonicsL2 probe) { }

	// RVA: 0x577D90
	public static void GetSHCoefficients(Vector3 position, SphericalHarmonicsL2 probe, float accumulation) { }

	// RVA: 0x57B370
	public static void SetSHCoefficients(Vector3 position) { }

	// RVA: 0x57B428
	public static void SetSHCoefficients(Vector3 position, CommandBuffer commandBuffer) { }

	// RVA: 0x57B4E8
	public static void SetSHCoefficients(Vector3 position, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x57B5A8
	public static void SetSHCoefficients(Vector3 position, Material material) { }

	// RVA: 0x579150
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh) { }

	// RVA: 0x5727B4
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh, CommandBuffer commandBuffer) { }

	// RVA: 0x579D8C
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x57A6EC
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh, Material material) { }

	// RVA: 0x5794D8
	public static void SetReflectionMaps(Texture[] atlases) { }

	// RVA: 0x57B668
	public static void SetReflectionMaps(Texture2DArray atlas, CommandBuffer commandBuffer) { }

	// RVA: 0x56E020
	public static void SetReflectionMaps(Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

	// RVA: 0x57A178
	public static void SetReflectionMaps(Texture[] atlases, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x57AAD8
	public static void SetReflectionMaps(Texture[] atlases, Material material) { }

	// RVA: 0x56DF68
	public static void SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x57B790
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias) { }

	// RVA: 0x57B954
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias, CommandBuffer commandBuffer) { }

	// RVA: 0x577E20
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias, MaterialPropertyBlock materialProbertyBlock) { }

	// RVA: 0x57BB28
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias, Material material) { }

	// RVA: 0x579694
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor) { }

	// RVA: 0x5799FC
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor, CommandBuffer commandBuffer) { }

	// RVA: 0x57A35C
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor, MaterialPropertyBlock materialProbertyBlock) { }

	// RVA: 0x57ACBC
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor, Material material) { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class GlobalIllumination
{
	// Fields
	private static readonly SphericalHarmonicsL2 WhiteProbe; // 0x0
	public static SphericalHarmonicsL2 DefaultProbe; // 0x6C
	public static HeightField HeightField; // 0xD8
	public static GlobalIlluminationData GI; // 0xE0
	public static DynamicGI DynamicGI; // 0xE8

	// Methods

	// RVA: 0x57BCFC
	public static bool get_HasValidData() { }

	// RVA: 0x57BD80
	public static void TryLoadData(string data) { }

	// RVA: 0x57C0C0
	public static void FreeData() { }

	// RVA: 0x57C16C
	public static void SampleGIInterpolation(Vector3 position, Int32* indices, Single* weights) { }

	// RVA: 0x57CDAC
	public static void SampleGI(Vector3 position, Vector3 normal, Color color) { }

	// RVA: 0x57AE30
	public static void SampleGI(Vector3 position, SphericalHarmonicsL2 sh) { }

	// RVA: 0x57D270
	public static void SampleGI(Vector3 position, SphericalHarmonicsL2 sh) { }

	// RVA: 0x57B0D0
	public static void SampleGI(Vector3 position, SphericalHarmonicsL2 sh, float accumulation) { }

	// RVA: 0x57D758
	public static void SampleGISingle(Vector3 position, SphericalHarmonicsL2 sh) { }

	// RVA: 0x57D044
	private static void InterpolateSH9(Int32* indices, Single* weights, SphericalHarmonicsL2 sh) { }

	// RVA: 0x57D4FC
	private static void InterpolateSH9(Int32* indices, Single* weights, float accumulation, SphericalHarmonicsL2 sh) { }

	// RVA: 0x57C290
	private static bool TryGatherInterpolators(Single* position, Int32* indices, Single* weights) { }

	// RVA: 0x57DAB0
	private static bool TryFindSpanInCoord(Int32* coord, Int32* indices) { }

	// RVA: 0x57CFD4
	private static void CopyDefaultProbe(SphericalHarmonicsL2 sh) { }

	// RVA: 0x57DC8C
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class NativeRenderAPI
{
	// Fields
	private static int m_drawIndexRangesHandleCount; // 0x0
	private static DrawIndexRangesHandle[] m_drawIndexRangesHandles; // 0x8
	private static int m_setIndicesHandleCount; // 0x10
	private static SetIndicesHandle[] m_setIndicesHandles; // 0x18

	// Methods

	// RVA: 0x572070
	public static void DrawIndexRanges(CommandBuffer cb, Mesh mesh, Matrix4x4 matrix, Material material, IndexRange[] indexes, UInt32 count, IntPtr nativeIndexBuffer) { }

	// RVA: 0x574340
	public static void Reset() { }

	// RVA: 0x570DA0
	public static void SetIndices(CommandBuffer cb, IntPtr nativeIndexBufferPtr, UInt16[] indices, UInt32 count) { }

	// RVA: 0x57E288
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class ProjectionContextUtility
{
	// Methods

	// RVA: 0x57E334
	public static void SetupViewProjectionMatrices(CommandBuffer commandBuffer, Matrix4x4 view, Matrix4x4 projection) { }

	// RVA: 0x57E40C
	public static void SetupPerspective(CommandBuffer commandBuffer, Vector3 position, Quaternion rotation, float fieldOfView, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x57E6F0
	public static void SetupOrthographic(CommandBuffer commandBuffer, Vector3 position, Quaternion rotation, float sizeX, float sizeY, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x57E65C
	public static Matrix4x4 GetGPUPerspectiveProjectionMatrix(float fieldOfView, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x57E9C0
	public static Matrix4x4 GetGPUPerspectiveProjectionMatrix(float fieldOfView, float near, float far, float aspect, bool isRenderTexture) { }

	// RVA: 0x57E938
	public static Matrix4x4 GetGPUOrthographicProjectionMatrix(float near, float far, float width, float height, bool isRenderTexture) { }

	// RVA: 0x57EA38
	public static void ContentSizeFitPerspective(Camera camera, BoundingSphere bounds, Quaternion rotation) { }

	// RVA: 0x57EBB0
	public static void ContentSizeFitPerspective(BoundingSphere bounds, Quaternion rotation, float fieldOfView, float far, Vector3 position) { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
internal class RenderState
{
	// Fields
	private bool m_lightmapsEnabled; // 0x10
	private Byte m_lightmapIndex; // 0x11
	private bool m_lightProbesEnabled; // 0x12
	private Byte m_reflectionProbeCount; // 0x13
	private Byte m_reflectionProbeIndex; // 0x14
	private bool m_static; // 0x15
	private bool m_invertCulling; // 0x16
	private TextureFormat m_lightmapTextureFormat; // 0x18
	private readonly ISceneReflectionProbesUtilityService m_sceneReflectionProbesUtility; // 0x20
	public CommandBuffer cb; // 0x28

	// Methods

	// RVA: 0x56E938
	public void .ctor() { }

	// RVA: 0x57ECB8
	public void .ctor(ISceneReflectionProbesUtilityService sceneReflectionProbesUtility) { }

	// RVA: 0x571C30
	public void SetLightmapEnabled(bool enabled) { }

	// RVA: 0x571FA0
	public void SetLightmapIndex(Byte lightmapIndex, RenderTargetIdentifier[] lightmaps) { }

	// RVA: 0x571CC8
	public void SetLightmapST(Vector4 lightmapST) { }

	// RVA: 0x571E30
	public void SetPositionEncodeFactor(float offset, float value) { }

	// RVA: 0x571F00
	public void SetHDREncodeFactor(float factor) { }

	// RVA: 0x571B98
	public void SetLightProbeEnabled(bool enabled) { }

	// RVA: 0x57ECF4
	public void SetReflectionProbeStatic() { }

	// RVA: 0x572BA0
	public void SetReflectionProbe(Byte reflectionProbeIndex) { }

	// RVA: 0x5706CC
	public void SetReflectionProbeCount(Byte count) { }

	// RVA: 0x571B00
	public void SetStatic(bool enabled) { }

	// RVA: 0x571D88
	public void SetInvertCulling(bool invert) { }

	// RVA: 0x5704E4
	public void Reset() { }

	// RVA: 0x56E9B8
	public void SetLightmapDecodeFormat(TextureFormat format) { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class ShaderConstants
{
	// Fields
	public static readonly float[] OEMRoughnessLevels; // 0x0
	public const string LightmapsEnabled = "CF_LIGHTMAPS";
	public const string LightProbesEnabled = "CF_LIGHTPROBES";
	public const string ReflectionsEnabled = "CF_REFLECTIONS";
	public const string Static = "CF_STATIC";
	public const string MetaAlbedo = "CF_META_ALBEDO";
	public const string MetaEmission = "CF_META_EMISSION";
	public static readonly int _WorldSpaceCameraPos; // 0x8
	public static readonly int _ZBufferParams; // 0xC
	public static readonly int _ScreenParams; // 0x10
	public static readonly int unity_OrthoParams; // 0x14
	public static readonly int _CameraDepthTexture; // 0x18
	public static readonly int _MainTex; // 0x1C
	public static readonly int _CF_TemporaryColorTexture; // 0x20
	public static readonly int _CF_TemporaryDepthTexture; // 0x24
	public static readonly int _CF_LowResColorTexture; // 0x28
	public static readonly int _CF_LowResDepthTexture; // 0x2C
	public static readonly int _CF_DynamicLightDirection; // 0x30
	public static readonly int _CF_DynamicLightColor; // 0x34
	public static readonly int _CF_ReflectionFallbackColor; // 0x38
	public static readonly int _CFLightmap; // 0x3C
	public static readonly int _CFLightmapST; // 0x40
	public static readonly int _CF_EnvProbeBlend; // 0x44
	public static readonly int _CF_EnvSlice; // 0x48
	public static readonly int _CF_PrevEnvSlice; // 0x4C
	public static readonly int _CF_BlendSourceScaleOffset; // 0x50
	public static readonly int _CF_BlendDestinationScaleOffset; // 0x54
	public static readonly int _CF_PosEncodeFactor; // 0x58
	public static readonly int _CF_HDREncodeFactor; // 0x5C
	public static readonly int _CF_Env0; // 0x60
	public static readonly int _CF_Env1; // 0x64
	public static readonly int _CF_Env2; // 0x68
	public static readonly int _CF_Env3; // 0x6C
	public static readonly int _CF_Env4; // 0x70
	public static readonly int[] LightProbeSHA; // 0x78
	public static readonly int[] LightProbeSHB; // 0x80
	public static readonly int LightProbeSHC; // 0x88

	// Methods

	// RVA: 0x57EDA8
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
internal class StaticBatcher
{
	// Fields
	private OcclusionComponent m_occlusion; // 0x10
	private StaticSceneData m_sceneData; // 0x18
	private BatchedMeshInstance[] <BatchedMeshes>k__BackingField; // 0x20
	private StaticBatch[] <Batches>k__BackingField; // 0x28

	// Methods

	// RVA: 0x57F4BC
	public BatchedMeshInstance[] get_BatchedMeshes() { }

	// RVA: 0x57F4C4
	private void set_BatchedMeshes(BatchedMeshInstance[] value) { }

	// RVA: 0x57F4CC
	public StaticBatch[] get_Batches() { }

	// RVA: 0x57F4D4
	private void set_Batches(StaticBatch[] value) { }

	// RVA: 0x57F4DC
	public bool get_UsesHalfPrecision() { }

	// RVA: 0x571DFC
	public float get_PositionEncodeRange() { }

	// RVA: 0x571EE0
	public float get_HDREncodeFactor() { }

	// RVA: 0x571DCC
	public float get_PositionEncodeOffset() { }

	// RVA: 0x577730
	public void CleanUp() { }

	// RVA: 0x5773D0
	public void Initialize(StaticSceneData sceneData, OcclusionComponent occlusion) { }

	// RVA: 0x57FBA8
	private void CreateBatch(int batchIndex, StaticBatch batch, System.Collections.Generic.List<System.Int32> instances, TemporaryMeshData temporary, bool useHalfPrecision, MeshDataCache meshCache) { }

	// RVA: 0x57F4FC
	private void CreateBatches() { }

	// RVA: 0x5773C8
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interop
internal class DrawIndexRangesDataNative
{
	// Fields
	public IntPtr indexes; // 0x10
	public UInt32 count; // 0x18
	public IntPtr nativeIndexBuffer; // 0x1C

	// Methods

	// RVA: 0x580E38
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interop
internal class DrawIndexRangesHandle
{
	// Fields
	private readonly DrawIndexRangesDataNative m_nativeData; // 0x10
	private GCHandle indexesHandle; // 0x18
	private GCHandle nativeDataHandle; // 0x20

	// Methods

	// RVA: 0x57E158
	public void Free() { }

	// RVA: 0x57E0A0
	public IntPtr GetPtr(IndexRange[] indexes, UInt32 count, IntPtr nativeIndexBuffer) { }

	// RVA: 0x57E028
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interop
internal class SetIndicesDataNative
{
	// Fields
	public IntPtr indexBuffer; // 0x10
	public IntPtr indices; // 0x18
	public UInt32 indexCount; // 0x20

	// Methods

	// RVA: 0x580E40
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interop
internal class SetIndicesHandle
{
	// Fields
	private readonly SetIndicesDataNative m_nativeData; // 0x10
	private GCHandle indicesHandle; // 0x18
	private GCHandle nativeDataHandle; // 0x20

	// Methods

	// RVA: 0x57E128
	public void Free() { }

	// RVA: 0x57E200
	public IntPtr GetPtr(IntPtr nativeIndexBufferPtr, UInt16[] indices, UInt32 count) { }

	// RVA: 0x57E188
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interfaces
public interface ILightmapIndexable
{
	// Methods

	// RVA: -1
	public abstract bool get_HasCFLightMapRect() { }

	// RVA: -1
	public abstract void set_HasCFLightMapRect(bool value) { }

	// RVA: -1
	public abstract LightmapRect get_CFLightmapRect() { }

	// RVA: -1
	public abstract void set_CFLightmapRect(LightmapRect value) { }

}

// Namespace: CFRenderLib.Unity.Interfaces
public interface IRenderable
{
	// Methods

	// RVA: -1
	public abstract void PreCull(RenderableData data) { }

	// RVA: -1
	public abstract void Render(IRenderer renderer, RenderableData data) { }

	// RVA: -1
	public abstract void BecameVisible(RenderableData data) { }

	// RVA: -1
	public abstract void BecameInvisible(RenderableData data) { }

}

// Namespace: CFRenderLib.Unity.Interfaces
public interface IRenderer
{
	// Methods

	// RVA: -1
	public abstract void Draw(DrawCall drawCall) { }

	// RVA: -1
	public abstract void Render(RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer) { }

	// RVA: -1
	public abstract void BeginRecordDrawCalls() { }

	// RVA: -1
	public abstract bool EndRecordDrawCalls(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Unity.Structs.DrawCall>& recordedDrawCalls) { }

}

// Namespace: CFRenderLib.Unity.Culling
internal abstract class Culling
{
	// Fields
	protected Frustum m_frustum; // 0x10
	protected OcclusionData m_occlusionData; // 0x50
	protected StaticSceneData m_sceneData; // 0x58
	private readonly Plane[] m_frustumPlanes; // 0x60

	// Methods

	// RVA: 0x577724
	internal void CleanUp() { }

	// RVA: 0x5776E0
	internal void Init(OcclusionData occlusionData, StaticSceneData sceneData) { }

	// RVA: 0x576AE0
	internal void Update(Camera camera, DynamicCullingData dynamicData, CullingResults results, bool disableCulling) { }

	// RVA: 0x5762B4
	internal int GetOcclusionAreaIndex(Vector3 position) { }

	// RVA: 0x5764B8
	internal int GetOcclusionAreaCount() { }

	// RVA: -1
	protected abstract void CleanUpCulling() { }

	// RVA: -1
	protected abstract void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: -1
	protected abstract void CullStatic(Camera camera, CullingResults results) { }

	// RVA: -1
	protected abstract void InitCulling() { }

	// RVA: 0x581190
	protected void SetAllDynamicVisible(DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x581048
	protected void SetAllStaticVisible(CullingResults results) { }

	// RVA: 0x580E48
	private void UpdateFrustum(Camera camera, CullingResults results) { }

	// RVA: 0x5811F0
	protected void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Culling
internal class CullingCSharp
{
	// Fields
	public static bool debug; // 0x0
	public static CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Unity.Structs.PortalClip> debugPortals; // 0x8
	private readonly CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Core.Structs.Plane>[] m_clipStack; // 0x68
	private bool[] m_rendererVisible; // 0x70

	// Methods

	// RVA: 0x581260
	protected override void CleanUpCulling() { }

	// RVA: 0x581264
	protected override void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x5812DC
	protected override void CullStatic(Camera camera, CullingResults results) { }

	// RVA: 0x581CAC
	protected override void InitCulling() { }

	// RVA: 0x5816C0
	private void UpdateOcclusionRecursive(Float3 origin, int clipStackDepth, int areaIndex, BitVector256 visitedAreas, CullingResults results) { }

	// RVA: 0x581CB0
	public void .ctor() { }

	// RVA: 0x581D64
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.Culling
internal class CullingNative
{
	// Fields
	private int m_areaIndex; // 0x68
	private IntPtr m_nativeScene; // 0x70

	// Methods

	// RVA: 0x581DFC
	protected override void CleanUpCulling() { }

	// RVA: 0x581E80
	protected override void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x582094
	protected override void CullStatic(Camera camera, CullingResults results) { }

	// RVA: 0x582208
	protected override void InitCulling() { }

	// RVA: 0x58224C
	private static IntPtr LoadScene(OcclusionData occlusionData, StaticSceneData sceneData) { }

	// RVA: 0x577670
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Culling.Components
public class OcclusionComponent
{
	// Fields
	public OcclusionData occlusionData; // 0x20

	// Methods

	// RVA: 0x582674
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public sealed class CFMeshRenderer
{
	// Fields
	public Mesh mesh; // 0x20
	public Material[] materials; // 0x28
	public bool DisableDynamicLights; // 0x30
	private CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> m_renderHandle; // 0x32
	private Matrix4x4 m_localToWorldMatrix; // 0x38
	private SphericalHarmonicsL2 m_cachedProbe; // 0x78
	private MaterialPropertyBlock m_cachedMaterialProps; // 0xE8

	// Methods

	// RVA: 0x58267C
	private void OnEnable() { }

	// RVA: 0x582758
	private void OnDisable() { }

	// RVA: 0x5827E8
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x5829A8
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x582D40
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x582D44
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x582D48
	private void OnDrawGizmos() { }

	// RVA: 0x582EC4
	private void OnDrawGizmosSelected() { }

	// RVA: 0x58312C
	private void ConvertToStaticMesh() { }

	// RVA: 0x5831FC
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public sealed class CFStaticMesh
{
	// Fields
	private bool m_meshDirty; // 0x20
	private bool m_validMesh; // 0x21
	private bool m_boundsDirty; // 0x22
	private CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> m_renderHandle; // 0x24
	private BoundingSphere m_bounds; // 0x28
	private Matrix4x4 m_localToWorldMatrix; // 0x38
	public Mesh mesh; // 0x78
	public Material[] materials; // 0x80
	public float lightmapScale; // 0x88
	public int lightmapIndex; // 0x8C
	public Vector4 lightmapST; // 0x90

	// Methods

	// RVA: 0x583278
	private void OnEnable() { }

	// RVA: 0x5833B4
	private void OnDisable() { }

	// RVA: 0x58354C
	private void Update() { }

	// RVA: 0x583628
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x583660
	private void UpdateBounds() { }

	// RVA: 0x583848
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x583B24
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x583B28
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x583B2C
	private void OnDrawGizmos() { }

	// RVA: 0x583D2C
	private void OnDrawGizmosSelected() { }

	// RVA: 0x583DFC
	private void OnValidate() { }

	// RVA: 0x583C30
	private void CheckMesh() { }

	// RVA: 0x583E0C
	private void ConvertToMeshRenderer() { }

	// RVA: 0x583EDC
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public class CFUnityParticleSystemRenderer
{
	// Fields
	private bool m_enableCulling; // 0x20
	private Vector3 m_cullPivotWorldOffset; // 0x24
	private readonly System.Collections.Generic.List<UnityEngine.Material> m_materialsToRender; // 0x30
	private CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> m_renderHandle; // 0x38
	private ParticleSystemRenderer[] m_renderers; // 0x40
	private ParticleSystem[] m_systems; // 0x48

	// Methods

	// RVA: 0x583EF0
	private void OnEnable() { }

	// RVA: 0x584094
	private void OnDisable() { }

	// RVA: 0x5842EC
	private void OnDestroy() { }

	// RVA: 0x584518
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x584870
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x584CB8
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x584E24
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x584E2C
	private void OnDrawGizmosSelected() { }

	// RVA: 0x584CC0
	private void SetCullingMode(ParticleSystemCullingMode mode) { }

	// RVA: 0x583F60
	private void FindParticleSystems() { }

	// RVA: 0x585200
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public class CFUnityRenderer
{
	// Fields
	public Animator animator; // 0x20
	public bool disableCulling; // 0x28
	public Renderer unityRenderer; // 0x30
	private BoundingSphere m_bounds; // 0x38
	private readonly System.Collections.Generic.List<UnityEngine.Material> m_materialsToRender; // 0x48
	private CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> m_renderHandle; // 0x50
	private MaterialPropertyBlock m_propertyBlock; // 0x58
	private SphericalHarmonicsL2 m_cachedProbeLighting; // 0x60
	private bool m_hasCFLightmapRect; // 0xCC
	private LightmapRect m_cfLightmapRect; // 0xD0

	// Methods

	// RVA: 0x5852D8
	public bool get_IsVisible() { }

	// RVA: 0x585520
	public bool get_HasCFLightMapRect() { }

	// RVA: 0x585528
	public void set_HasCFLightMapRect(bool value) { }

	// RVA: 0x585530
	public LightmapRect get_CFLightmapRect() { }

	// RVA: 0x585544
	public void set_CFLightmapRect(LightmapRect value) { }

	// RVA: 0x585558
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x5856C4
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x585840
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x585A00
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x585DD8
	private void OnEnable() { }

	// RVA: 0x585F4C
	private void OnDisable() { }

	// RVA: 0x5860F0
	private void OnDestroy() { }

	// RVA: 0x58586C
	private void UpdateBounds() { }

	// RVA: 0x5862FC
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public class CompressedAtlas
{
	// Fields
	public int atlasHeight; // 0x20
	public int atlasIndex; // 0x24
	public int atlasWidth; // 0x28
	public AtlasClearColor clearColor; // 0x2C
	public Texture2D output; // 0x30
	public IntRect[] rects; // 0x38
	public StaticSceneData sceneData; // 0x40
	public int sizeDivider; // 0x48
	public Material testMaterial; // 0x50
	public Texture2D[] textures; // 0x58

	// Methods

	// RVA: 0x5863CC
	public static Texture2D CreateAtlas(Texture2D[] sourceTextures, TextureAtlasPacking packing, AtlasParameters parameters) { }

	// RVA: 0x586814
	private static int FindMipmapCount(int blockWidth, TextureAtlasPacking packing) { }

	// RVA: 0x586934
	private void PackAtlas() { }

	// RVA: 0x586BAC
	private void Start() { }

	// RVA: 0x586BE0
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public class MapDataDebugger
{
	// Fields
	public bool HasUnityData; // 0x20
	public SphericalHarmonicsL2 UnityProbe; // 0x24
	public SphericalHarmonicsL2 ConvertedUnityProbe; // 0x90
	public Color UnityAmbient; // 0xFC
	public Color UnityDominant; // 0x10C
	public Vector3 UnityDirection; // 0x11C
	public bool HasCfData; // 0x128
	public Vector3Int CfVoxel; // 0x12C
	public Cell CfCell; // 0x138
	public SphericalHarmonicsL2 CfProbe; // 0x13C
	public Color CfAmbient; // 0x1A8
	public Color CfDominant; // 0x1B8
	public Vector3 CfDirection; // 0x1C8
	public SphericalHarmonicsL2 CfInterpProbe; // 0x1D4
	public Color CfInterpAmbient; // 0x240
	public Color CfInterpDominant; // 0x250
	public Vector3 CfInterpDirection; // 0x260

	// Methods

	// RVA: 0x586BE8
	protected void Update() { }

	// RVA: 0x5870D0
	protected void OnDrawGizmos() { }

	// RVA: 0x586FE8
	private Vector3Int WorldToVoxelSpace(Vector3 world) { }

	// RVA: 0x587608
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
internal class PreviewRenderable
{
	// Fields
	public GameObject original; // 0x20

	// Methods

	// RVA: 0x587610
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public class SceneGraphicsParameters
{
	// Fields
	private Color m_globalTint; // 0x20
	private Vector3 m_ccMin; // 0x30
	private Vector3 m_ccMax; // 0x3C
	private static SceneGraphicsParameters <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x587618
	public Color get_GlobalTint() { }

	// RVA: 0x587624
	public Vector3 get_CCMin() { }

	// RVA: 0x587630
	public Vector3 get_CCMax() { }

	// RVA: 0x58763C
	public static SceneGraphicsParameters get_Instance() { }

	// RVA: 0x587688
	private static void set_Instance(SceneGraphicsParameters value) { }

	// RVA: 0x5876EC
	private void OnEnable() { }

	// RVA: 0x587830
	private void OnValidate() { }

	// RVA: 0x587750
	public void Apply() { }

	// RVA: 0x587834
	public static void Disable() { }

	// RVA: 0x587914
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public class SceneLightmapData
{
	// Fields
	public LightmapObject[] lightmapObjects; // 0x20
	public Texture2D[] lightmapTextures; // 0x28
	public SceneReflectionProbes reflectionProbes; // 0x30
	public string serializedVoxelData; // 0x38
	private RenderTargetIdentifier[] m_lightmapRenderTargetIdentifiers; // 0x40
	private static SceneLightmapData <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x5879BC
	public RenderTargetIdentifier[] get_LightmapRenderTargetIdentifiers() { }

	// RVA: 0x5879C4
	private void set_LightmapRenderTargetIdentifiers(RenderTargetIdentifier[] value) { }

	// RVA: 0x5879CC
	public static SceneLightmapData get_Instance() { }

	// RVA: 0x587A18
	private static void set_Instance(SceneLightmapData value) { }

	// RVA: 0x587A7C
	public void Add(Transform t, int lightmapIndex, Vector4 lightmapST) { }

	// RVA: 0x587B6C
	public void Apply() { }

	// RVA: 0x587EF0
	public bool TryGet(Transform t, LightmapObject obj) { }

	// RVA: 0x587FEC
	private void OnEnable() { }

	// RVA: 0x588050
	private void OnDestroy() { }

	// RVA: 0x587DE4
	private void CreateRenderTargets() { }

	// RVA: 0x588190
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public sealed class SceneRasterizationConfigurationHolder
{
	// Fields
	private SceneRasterizationConfiguration m_bakeConfig; // 0x20
	private static SceneRasterizationConfigurationHolder <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x588198
	public static SceneRasterizationConfigurationHolder get_Instance() { }

	// RVA: 0x5881E4
	private static void set_Instance(SceneRasterizationConfigurationHolder value) { }

	// RVA: 0x588248
	public SceneRasterizationConfiguration get_BakeConfig() { }

	// RVA: 0x58826C
	private void OnEnable() { }

	// RVA: 0x5882C8
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public class StaticSceneData
{
	// Fields
	private const float BoundsExpand = 0.5;
	public AreaRendererData[] AreaRenderers; // 0x20
	public bool UseHalfPrecision; // 0x28
	public float HalfPrecisionEncodeRange; // 0x2C
	public float ReflectionHDREncodeFactor; // 0x30
	public AtlasedMaterial[] AtlasedMaterials; // 0x38
	public SceneTextureAtlas[] Atlases; // 0x40
	public TextureAtlasPacking[] AtlasPacking; // 0x48
	public StaticMeshInstance[] Instances; // 0x50
	public LightmapRect[] LightmapRects; // 0x58
	public MaterialInfo[] Materials; // 0x60
	public BoundingBox[] RendererBounds; // 0x68

	// Methods

	// RVA: 0x58832C
	public void SortInstances() { }

	// RVA: 0x5883D4
	internal void AddRenderersToAreas(OcclusionData occlusionData) { }

	// RVA: 0x588660
	internal bool AddRendererToAreas(OcclusionData occlusionData, int rendererIndex, System.Collections.Generic.List<System.Int32>[] areaRenderers) { }

	// RVA: 0x588800
	internal void CalculateRendererBounds() { }

	// RVA: 0x588B50
	internal void CreateAtlasedMaterials() { }

	// RVA: 0x58907C
	internal void DestroyAtlasedMaterials() { }

	// RVA: 0x58925C
	internal Material GetMaterial(UInt16 materialIndex) { }

	// RVA: 0x5892C8
	internal int GetReflectionProbeIndex(OcclusionData occlusionData, int instanceIndex) { }

	// RVA: 0x589410
	public void .ctor() { }

	// RVA: 0x589424
	private int <SortInstances>b__12_0(StaticMeshInstance r1, StaticMeshInstance r2) { }

}

// Namespace: CFRenderLib.Unity.Components
public class UnityLightProbesHolder
{
	// Fields
	public LightProbes lightProbes; // 0x20
	public LightProbeGroup lightProbeGroup; // 0x28
	private static UnityLightProbesHolder <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x589724
	public static UnityLightProbesHolder get_Instance() { }

	// RVA: 0x589770
	private static void set_Instance(UnityLightProbesHolder value) { }

	// RVA: 0x5897D4
	private void OnEnable() { }

	// RVA: 0x5899D0
	public static UnityLightProbesHolder ForceGetInstance() { }

	// RVA: 0x589C68
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
[Serializable]
public class Area
{
	// Fields
	public int[] points; // 0x10
	public float yMin; // 0x18
	public float yMax; // 0x1C
	public Portal[] portals; // 0x20

	// Methods

	// RVA: 0x589C70
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public class DataCache<T0>
{
	// Fields
	private T[] m_data; // 0x0
	private UInt16 m_dataCount; // 0x0
	private DataIndex[] m_indexArray; // 0x0
	private UInt16 m_nextFreeIndex; // 0x0
	private UInt16[] m_reverseIndex; // 0x0

	// Methods

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3CF0
	public T[] get_Data() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	public CFRenderLib.Unity.Structs.Handle<T> Add(T data) { }

	// RVA: 0x318DB98
	public bool Exists(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x318DB98
	public CFRenderLib.Unity.Structs.Handle<T> GetHandleFromData(int dataIndex) { }

	// RVA: 0x318DB98
	public T GetRef(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x318DB98
	public void Remove(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x318DB98
	private UInt16 AddData(T data) { }

	// RVA: 0x30D4A74
	private void InitFreeList(int min, int max) { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class DynamicCullingData
{
	// Fields
	public Byte[] objectArea; // 0x10
	public BoundingSphere[] objectBounds; // 0x18
	public int objectCount; // 0x20

	// Methods

	// RVA: 0x589C78
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public float currentTime; // 0x10

	// Methods

	// RVA: 0x589D68
	public void .ctor() { }

	// RVA: 0x58A4E4
	internal bool <PruneLights>b__0(SHLight light) { }

}

// Namespace: CFRenderLib.Unity.Collections
public class DynamicGI
{
	// Fields
	private const int MaxLights = 128;
	private const int MaxSamples = 32;
	private int m_lightLimit; // 0x10
	private int m_sampleLimit; // 0x14
	private System.Collections.Generic.HashSet<CFRenderLib.Unity.Structs.SHLight> m_lights; // 0x18
	private float m_currentTime; // 0x20

	// Methods

	// RVA: 0x589C80
	internal void PruneLights(float currentTime) { }

	// RVA: 0x589D70
	public void SetLightLimits(int lightLimit, int sampleLimit) { }

	// RVA: 0x589E24
	public bool AddLight(SHLight light) { }

	// RVA: 0x589EF0
	public void RemoveLight(SHLight light) { }

	// RVA: 0x589F78
	public void FadeOutLight(SHLight light) { }

	// RVA: 0x58A0BC
	public void SampleLights(SphericalHarmonicsL2 sh, Vector3 position) { }

	// RVA: 0x58A448
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public class DynamicReflectionProbe
{
	// Fields
	public const float BlendTimeMultiplier = 10;
	private int m_currentAreaIndex; // 0x10
	private int m_previousAreaIndex; // 0x14
	private float m_interpolant; // 0x18

	// Methods

	// RVA: 0x58A4F8
	public void Update(MaterialPropertyBlock materialPropertyBlock, int areaIndex, float deltaTime) { }

	// RVA: 0x58A620
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class IndexPriorityQueue
{
	// Fields
	public UInt16 count; // 0x10
	public UInt16[] indexes; // 0x18
	public UInt16[] values; // 0x20

	// Methods

	// RVA: 0x58A638
	public void .ctor(int initialSize) { }

	// RVA: 0x58A6C8
	public void Add(UInt16 value) { }

	// RVA: 0x58A854
	public void Clear() { }

}

// Namespace: CFRenderLib.Unity.Collections
public class MeshData
{
	// Fields
	public MeshChannelData channels; // 0x10
	public Color[] colors; // 0x18
	public int[] indices; // 0x20
	public Vector3[] normals; // 0x28
	public Vector2[] uv1; // 0x30
	public Vector2[] uv2; // 0x38
	public Vector3[] vertices; // 0x40

	// Methods

	// RVA: 0x58A85C
	public void .ctor(Mesh mesh) { }

	// RVA: 0x58A958
	public void .ctor(MeshData meshData, Mesh mesh, int submeshIndex) { }

	// RVA: 0x58ADCC
	private static int GetVertexCount(int[] subMeshIndices, int baseVertex) { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class MeshDataCache
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Int32,CFRenderLib.Unity.Collections.MeshData> m_meshDatas; // 0x10
	private readonly System.Collections.Generic.List<CFRenderLib.Unity.Structs.SubmeshData> m_subMeshDatas; // 0x18

	// Methods

	// RVA: 0x58AE78
	public MeshData Get(Mesh mesh, int submeshIndex) { }

	// RVA: 0x58B0A8
	private MeshData Get(Mesh mesh) { }

	// RVA: 0x58B1A0
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public class RawTextureData
{
	// Fields
	public Texture2D texture; // 0x10
	public Unity.Collections.NativeArray<System.Byte> rawData; // 0x18
	public MipmapData[] mipmaps; // 0x28

	// Methods

	// RVA: 0x5868A4
	public void .ctor(Texture2D texture, TextureCompressionInfo tc) { }

	// RVA: 0x58B280
	private void FindMipmaps(TextureCompressionInfo tc) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class RenderableCache
{
	// Fields
	internal static CFRenderLib.Unity.Collections.DataCache<CFRenderLib.Unity.Structs.RenderableData> Roots; // 0x0

	// Methods

	// RVA: 0x5832EC
	public static CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> Add(IRenderable renderable) { }

	// RVA: 0x5834A8
	public static void Remove(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x58547C
	public static RenderableData GetRef(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x584248
	public static bool Exists(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x58B5CC
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class RenderPass
{
	// Fields
	public int renderQueueNumber; // 0x10
	public CFRenderLib.Core.Collections.GrowArray<System.Int32> staticBatches; // 0x18
	public CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Unity.Structs.DrawCall> drawCalls; // 0x20
	public IndexPriorityQueue drawcallIndexes; // 0x28

	// Methods

	// RVA: 0x58B668
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class RenderStats
{
	// Fields
	public static UInt32 indexCount; // 0x0
	public static UInt32 vertexCount; // 0x4

	// Methods

	// RVA: 0x58B7F4
	public static void Clear() { }

}

// Namespace: CFRenderLib.Unity.Collections
[Serializable]
public class SceneReflectionProbes
{
	// Fields
	private readonly IDynamicLightingUtilityService m_dynamicLightingUtility; // 0x10
	private readonly ISceneReflectionProbesUtilityService m_sceneReflectionProbesUtility; // 0x18
	public Texture2DArray[] Atlases; // 0x20
	public int ProbeCount; // 0x28

	// Methods

	// RVA: 0x58B840
	public void .ctor() { }

	// RVA: 0x58B928
	public void .ctor(IDynamicLightingUtilityService dynamicLightingUtility, ISceneReflectionProbesUtilityService sceneReflectionProbesUtility) { }

	// RVA: 0x58B9C8
	public void ApplyEnvMaps(CommandBuffer commandBuffer) { }

}

// Namespace: CFRenderLib.Unity.Collections
[Serializable]
public class SceneTextureAtlas
{
	// Fields
	public Texture2D atlasTexture; // 0x10
	public Byte packingIndex; // 0x18
	public AtlasParameters parameters; // 0x1C
	public Texture2D[] textures; // 0x28

	// Methods

	// RVA: 0x58BA84
	public UInt16 GetTextureIndex(Texture2D texture) { }

	// RVA: 0x58BBAC
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class StaticBatch
{
	// Fields
	public Mesh mesh; // 0x10
	public Material material; // 0x18
	public Byte lightmapIndex; // 0x20
	public UInt32 totalVertexCount; // 0x24
	public UInt32 totalIndexCount; // 0x28
	public int submeshCount; // 0x2C
	public MeshChannelData channels; // 0x30
	public UInt16 renderQueueIndex; // 0x34
	public bool[] submeshActive; // 0x38
	public IndexRange[] indexRanges; // 0x40
	public IndexRange[] activeIndexRanges; // 0x48
	public UInt32 activeIndexRangeCount; // 0x50
	public IntPtr nativeIndexBuffer; // 0x58
	public UInt16[] allIndices; // 0x60
	public UInt16[] activeIndices; // 0x68
	public UInt32 activeIndexCount; // 0x70
	public UInt32 activeVertexCount; // 0x74
	public UInt16[] submeshVertexCounts; // 0x78
	public int hash; // 0x80
	public int newHash; // 0x84
	public int renderFrame; // 0x88

	// Methods

	// RVA: 0x58BBB4
	public void .ctor() { }

}

// Namespace: 
public struct MeshInfo
{
	// Fields
	public string Name; // 0x10
	public int VertexCount; // 0x18
	public int WantedBatchIndex; // 0x1C
}

// Namespace: 
public class BatchInfo
{
	// Fields
	public int Index; // 0x10
	public System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.MeshInfo> Meshes; // 0x18
	public int VertexCount; // 0x20
	public string Material; // 0x28
	public int LightmapIndex; // 0x30
	public MeshChannelData Channels; // 0x34
	public bool HasOverflow; // 0x38

	// Methods

	// RVA: 0x58BFD4
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public int batchIndex; // 0x10

	// Methods

	// RVA: 0x58BFCC
	public void .ctor() { }

	// RVA: 0x58BFDC
	internal bool <AddMesh>b__0(BatchInfo b) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class StaticBatchInfo
{
	// Fields
	private static System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.BatchInfo> <Batches>k__BackingField; // 0x0

	// Methods

	// RVA: 0x58BBBC
	public static System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.BatchInfo> get_Batches() { }

	// RVA: 0x58BC08
	private static void set_Batches(System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.BatchInfo> value) { }

	// RVA: 0x58BC6C
	public static void Clear() { }

	// RVA: 0x58BD1C
	public static void AddMesh(string name, int vertexCount, string material, int lightmapIndex, MeshChannelData channels, int wantedBatchIndex, int batchIndex) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class StaticDataCache<T0>
{
	// Fields
	internal static CFRenderLib.Unity.Collections.DataCache<T> Cache; // 0x0

	// Methods

	// RVA: 0x318DB98
	public static CFRenderLib.Unity.Structs.Handle<T> Add(T t) { }

	// RVA: 0x318DB98
	public static T GetRef(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x318DB98
	public static void Remove(CFRenderLib.Unity.Structs.Handle<T> renderable) { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.Assets
public class CFEnvironmentImage
{
	// Fields
	private Vector3 m_dominantLightDirection; // 0x18
	private Color m_dominantLightColor; // 0x24
	private float m_HDREncodeFactor; // 0x34
	private Texture2DArray m_reflectionSample; // 0x38
	private Texture2DArray m_reflection1; // 0x40
	private Texture2DArray m_reflection2; // 0x48
	private Texture2DArray m_reflection3; // 0x50
	private Texture2DArray m_reflection4; // 0x58
	private int m_slice; // 0x60
	private SphericalHarmonicsL2 m_sphericalHarmonics; // 0x64
	private bool m_computeHarmonics; // 0xD0
	private float m_computeHarmonicsMultiplier; // 0xD4
	private Color m_ambientColor; // 0xD8
	private Vector2[] m_lightRotations; // 0xE8
	private Color[] m_lightColors; // 0xF0

	// Methods

	// RVA: 0x58C004
	public Vector3 get_DominantLightDirection() { }

	// RVA: 0x58C108
	public Color get_DominantLightColor() { }

	// RVA: 0x58C114
	public float get_HDREncodeFactor() { }

	// RVA: 0x58C11C
	public SphericalHarmonicsL2 get_SH() { }

	// RVA: 0x58C124
	public int get_ProbeSize() { }

	// RVA: 0x58C1E0
	public int get_Slice() { }

	// RVA: 0x58C1E8
	public Texture2DArray[] get_ReflectionSamples() { }

	// RVA: 0x58C2EC
	public void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=16
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=20
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=5331
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=14594
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly Int64 068459927F79051BE2A933FB2972B0AF185AFB5F1FDED6FFF258D61D5FB97084; // 0x0
	internal static readonly Int64 1ADB804EE85BAED94D5AC12322EB370A22BB71F9CA1DA2C40032C253780BD470; // 0x8
	internal static readonly __StaticArrayInitTypeSize=16 2ABD4BAF60452C683925A01754D5ABBE44CBC73682248428546AB2D512B96E65; // 0x10
	internal static readonly __StaticArrayInitTypeSize=16 4038348AF6E5B77BF25F510FD5FF230D3A611D61EF9FB6CA62313C860F128C1C; // 0x20
	internal static readonly Int64 7D0A0F0DDA8BF523E6E10685083859543EDB68FFF579376B60C8920CFA7B5DEF; // 0x30
	internal static readonly __StaticArrayInitTypeSize=14594 8BCE67754ADDA96C66E652786335473E73C9A32C927F1A43335C9F9FC878774B; // 0x38
	internal static readonly __StaticArrayInitTypeSize=16 8DF28E51E6285370840F0C8FD6BC27E3EF1CA52BD070712EDA60F9274B182AFC; // 0x393A
	internal static readonly Int64 9655D519C47A0B433D9B4ABC6335BE754440D271D1AD594C96DC11F672EAA4A4; // 0x3950
	internal static readonly __StaticArrayInitTypeSize=5331 9C07B08ECB0F51B70B65FFBC91549D4BBA6F08F3A762C8867C8681F7250762FF; // 0x3958
	internal static readonly Int64 DCBC8A96B332D7B2B126D401D47D72C1DAF86DDD7102704C197EE0A8AC66D034; // 0x4E30
	internal static readonly __StaticArrayInitTypeSize=20 F955B65874DC572B213A30BA1E58039C6A27841C2AE5ADF62AD5ED45ADA54F6D; // 0x4E38
}


