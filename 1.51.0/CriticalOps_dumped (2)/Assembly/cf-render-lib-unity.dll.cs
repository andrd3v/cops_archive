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

	// RVA: 0x5871D8
	private static MonoScriptData Get() { }

	// RVA: 0x5872DC
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

	// RVA: 0x5872E4
	public static Vector3 ToUnity(Float3 v) { }

	// RVA: 0x5872E8
	public static Float3 FromUnity(Vector3 v) { }

	// RVA: 0x5872EC
	public static Plane ToUnity(Plane v) { }

	// RVA: 0x587400
	public static Plane FromUnity(Plane v) { }

	// RVA: 0x587404
	public static SphericalHarmonicsL2 ToUnity(SphericalHarmonicsL2 sh) { }

	// RVA: 0x5875E0
	public static SphericalHarmonicsL2 FromUnity(SphericalHarmonicsL2 unitysh) { }

	// RVA: 0x5877E8
	public static Bounds ToUnity(BoundingBox b) { }

	// RVA: 0x587830
	public static BoundingBox FromUnity(Bounds v) { }

	// RVA: 0x587878
	public static Float4 FromUnity(Quaternion q) { }

	// RVA: 0x5878A8
	public static Float4 FromUnityRGBA(Color c) { }

	// RVA: 0x5878D8
	public static Float3 FromUnityRGB(Color c) { }

}

// Namespace: CFRenderLib.Unity
public class GameObjectFactory
{
	// Methods

	// RVA: 0x58790C
	public GameObject Create(string name) { }

	// RVA: 0x587974
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

	// RVA: 0x58797C
	public static void Clear(TextureCompressionInfo tc, RawTextureData data, AtlasClearColor clearColor) { }

	// RVA: 0x587CB4
	public static void CopyTexture(TextureCompressionInfo tc, RawTextureData source, RawTextureData target, int targetX, int targetY, int targetWidth, int targetHeight) { }

	// RVA: 0x5883EC
	public static int GetBlockStartIndex(TextureCompressionInfo tc, RawTextureData tex, int mipmap, int blockX, int blockY) { }

	// RVA: 0x588550
	private static void ClearBlock(TextureCompressionInfo tc, RawTextureData data, int x, int y, int mipmap, Byte[] clearBlock) { }

	// RVA: 0x587AC4
	private static void ClearMipmap(TextureCompressionInfo tc, RawTextureData data, int mipmap, Byte[] clearBlock) { }

	// RVA: 0x5885FC
	private static void CopyBlock(TextureCompressionInfo tc, RawTextureData source, int sourceX, int sourceY, RawTextureData target, int targetX, int targetY, int sourceMipmap, int targetMipmap) { }

	// RVA: 0x5881CC
	private static void CopyMipmap(TextureCompressionInfo tc, RawTextureData source, RawTextureData target, int targetX, int targetY, int sourceMipmap, int targetMipmap) { }

	// RVA: 0x5884E0
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

	// RVA: 0x5879F8
	public Byte[] GetColor(AtlasClearColor color) { }

	// RVA: 0x5886DC
	public static TextureCompressionInfo Get(Texture2D tex) { }

	// RVA: 0x588D0C
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

	// RVA: 0x588D14
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

	// RVA: 0x588D1C
	public void .ctor(int renderQueue, System.Action<UnityEngine.Rendering.CommandBuffer> callback) { }

	// RVA: 0x588D2C
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

	// RVA: 0x588D6C
	public bool get_enableLightProbes() { }

	// RVA: 0x588D78
	public void set_enableLightProbes(bool value) { }

	// RVA: 0x588D8C
	public bool get_enableReflectionProbes() { }

	// RVA: 0x588D98
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

	// RVA: 0x588DB8
	public void .ctor(float x, float y, float w, float h) { }

	// RVA: 0x588DC4
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

	// RVA: 0x588DD0
	public static IntRect MinMax(int xMin, int yMin, int xMax, int yMax) { }

	// RVA: 0x588DEC
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

	// RVA: 0x588DF8
	public bool Equals(MeshChannelData m) { }

	// RVA: 0x588E44
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

	// RVA: 0x588EBC
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

	// RVA: 0x588EC4
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

	// RVA: 0x588F5C
	public void .ctor(Vector3 position, Color startColor, Color endColor, float radius, float duration, float fadeTime) { }

	// RVA: 0x588F90
	public override int GetHashCode() { }

	// RVA: 0x589004
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

	// RVA: 0x5890A0
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

	// RVA: 0x5890A8
	public int get_vertexCount() { }

	// RVA: 0x5890B0
	public int get_size() { }

	// RVA: 0x5890BC
	public void .ctor(UInt32 capacity) { }

	// RVA: 0x5891A8
	public void SetAttributes(MeshChannelData channels, bool useHalfPrecision) { }

	// RVA: 0x589538
	public void SetFloat3(VertexAttribute attribute, Float3 value) { }

	// RVA: 0x5895B0
	public void SetColor32(VertexAttribute attribute, Color32 value) { }

	// RVA: 0x589628
	public void SetSnormByte4(VertexAttribute attribute, SnormByte4 value) { }

	// RVA: 0x5896A0
	public void SetHalf2(VertexAttribute attribute, Half2 value) { }

	// RVA: 0x589718
	public void SetHalf4(VertexAttribute attribute, Half4 value) { }

	// RVA: 0x589790
	public void SetUnormHalf2(VertexAttribute attribute, UnormHalf2 value) { }

	// RVA: 0x589808
	public void SetUnormHalf4(VertexAttribute attribute, UnormHalf4 value) { }

	// RVA: 0x589880
	public void SetSnormHalf4(VertexAttribute attribute, SnormHalf4 value) { }

	// RVA: 0x5898F8
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

	// RVA: 0x589988
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

	// RVA: 0x589A5C
	public void ApplyOffset(Byte index) { }

	// RVA: 0x589ACC
	public void ApplyOffset(Byte index, CommandBuffer commandBuffer) { }

	// RVA: 0x589B5C
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal class ApplicationWrapper
{
	// Methods

	// RVA: 0x589B64
	public string get_DataPath() { }

	// RVA: 0x589BD4
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

	// RVA: 0x589BDC
	public void LogError(string message) { }

	// RVA: 0x589C64
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

	// RVA: 0x589C6C
	public void SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x589DC4
	public void SetReflectionMaps(Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

	// RVA: 0x58A0A8
	public void .ctor() { }

	// RVA: 0x58A0B0
	private void CFRenderLib.Unity.Services.IDynamicLightingUtilityService.SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x58A15C
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

	// RVA: 0x58A168
	public void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x58A178
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

	// RVA: 0x58A180
	public void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x58A1FC
	public void Blit(Texture source, Material sourceMaterial) { }

	// RVA: 0x58A268
	public void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

	// RVA: 0x58A2FC
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

	// RVA: 0x58A304
	public bool Button(string label, GUILayoutOption[] options) { }

	// RVA: 0x58A314
	public void FlexibleSpace() { }

	// RVA: 0x58A31C
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

	// RVA: 0x58A324
	public int ClosestPowerOfTwo(int value) { }

	// RVA: 0x58A358
	public bool IsPowerOfTwo(int value) { }

	// RVA: 0x58A368
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

	// RVA: 0x58A370
	public RenderTexture get_Active() { }

	// RVA: 0x58A378
	public void set_Active(RenderTexture value) { }

	// RVA: 0x58A384
	public RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x58A39C
	public void ReleaseTemporary(RenderTexture renderTexture) { }

	// RVA: 0x58A3A8
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

	// RVA: 0x58A3B0
	public Scene GetActiveScene() { }

	// RVA: 0x58A420
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

	// RVA: 0x58A428
	public void DisableKeyword(string keyword) { }

	// RVA: 0x58A434
	public void EnableKeyword(string keyword) { }

	// RVA: 0x58A440
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

	// RVA: 0x58A448
	public void .ctor() { }

	// RVA: 0x58A810
	private Material get_NullMaterial() { }

	// RVA: 0x58A95C
	private void CFRenderLib.Unity.Interfaces.IRenderer.Draw(DrawCall drawCall) { }

	// RVA: 0x58AD14
	private void CFRenderLib.Unity.Interfaces.IRenderer.Render(RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer) { }

	// RVA: 0x58B888
	private void CFRenderLib.Unity.Interfaces.IRenderer.BeginRecordDrawCalls() { }

	// RVA: 0x58B8E4
	private bool CFRenderLib.Unity.Interfaces.IRenderer.EndRecordDrawCalls(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Unity.Structs.DrawCall>& recordedDrawCalls) { }

	// RVA: 0x58B930
	public void CleanUp() { }

	// RVA: 0x58AEE0
	public void Render(StaticBatcher staticBatcher, RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer, System.Collections.Generic.IReadOnlyList<System.Int32> copyDepthPasses, RenderTexture copyDepthSource, System.Collections.Generic.IReadOnlyList<CFRenderLib.Unity.Structs.CustomCommandBufferPass> customCommandBufferPasses) { }

	// RVA: 0x58AB1C
	private UInt16 GetRenderQueueIndex(Material material) { }

	// RVA: 0x58BF70
	private void SortInstancesToQueueAndBatches(StaticBatcher staticBatcher, int[] instances, int instanceCount) { }

	// RVA: 0x58C43C
	private void UpdateIndexRanges(StaticBatch batch) { }

	// RVA: 0x58C68C
	private void UpdateIndexBuffer(StaticBatch batch) { }

	// RVA: 0x58B934
	private void ClearDrawCalls() { }

	// RVA: 0x58B9DC
	private void SortDynamicToQueue(RenderableData[] renderableDatas, int renderableCount, CullingResults cullingResults) { }

	// RVA: 0x58C3EC
	private void ExecuteRenderPass(RenderPass pass, StaticBatcher staticBatcher) { }

	// RVA: 0x58CFCC
	private void RenderStatic(RenderPass pass, StaticBatcher staticBatcher) { }

	// RVA: 0x58CCBC
	private void RenderDynamic(RenderPass pass) { }

	// RVA: 0x58DFB4
	private void RenderDrawCall(DrawCall dc, RenderTargetIdentifier[] lightmapTextures, int lightmapCount) { }

	// RVA: 0x58E914
	private static void .cctor() { }

	// RVA: 0x58EA08
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

	// RVA: 0x593848
	private static void .cctor() { }

	// RVA: 0x5938B4
	public void .ctor() { }

	// RVA: 0x5938BC
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

	// RVA: 0x58EA60
	internal static System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> get_ActRenderPrefab() { }

	// RVA: 0x58EADC
	internal static void set_ActRenderPrefab(System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> value) { }

	// RVA: 0x58EB48
	internal static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> get_ActRenderPreview() { }

	// RVA: 0x58EBC4
	internal static void set_ActRenderPreview(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> value) { }

	// RVA: 0x58EC30
	internal static System.Action<UnityEngine.Camera> get_ActRenderUI() { }

	// RVA: 0x58ECAC
	internal static void set_ActRenderUI(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x58ED18
	protected override void Render(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x58ED1C
	protected override void Render(ScriptableRenderContext renderContext, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x590168
	protected override void Dispose(bool disposing) { }

	// RVA: 0x58F560
	private void Render(ScriptableRenderContext context, Camera camera, bool copyDepth, bool isUICamera) { }

	// RVA: 0x590458
	private void GatherCommands(ScriptableRenderContext context, Camera camera, bool copyDepth) { }

	// RVA: 0x590730
	private void RenderUI(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x590C60
	public static void SetOverrideRenderTarget(RenderTexture renderTexture) { }

	// RVA: 0x590CCC
	public static void RegisterCommandBuffer(CFCommandBufferEvent commandBufferEvent, CommandBuffer commandBuffer) { }

	// RVA: 0x590F14
	public static void UnRegisterCommandBuffer(CFCommandBufferEvent commandBufferEvent, CommandBuffer commandBuffer) { }

	// RVA: 0x591024
	public static void RegisterRenderEvent(CFRenderEvent renderEvent, System.Action<UnityEngine.Camera,System.Boolean> action) { }

	// RVA: 0x59126C
	public static void UnRegisterRenderEvent(CFRenderEvent renderEvent, System.Action<UnityEngine.Camera,System.Boolean> action) { }

	// RVA: 0x59137C
	public static void AddDepthCopyPass(int renderQueue) { }

	// RVA: 0x59147C
	public static void AddCustomCommandBufferPass(int renderQueue, System.Action<UnityEngine.Rendering.CommandBuffer> callback) { }

	// RVA: 0x591584
	public static void StartLowResPass(CommandBuffer commandBuffer, int width, int height) { }

	// RVA: 0x591780
	public static void EndLowResPass(CommandBuffer commandBuffer, bool blitColor, bool blitDepth) { }

	// RVA: 0x591EF8
	public static int GetOcclusionAreaIndex(Vector3 position) { }

	// RVA: 0x591FFC
	public static int GetVisibleOcclusionAreaCount() { }

	// RVA: 0x5920A8
	public static bool IsOcclusionAreaVisible(int index) { }

	// RVA: 0x592208
	public static void SetCaughtExceptionCallback(System.Action<System.Exception> action) { }

	// RVA: 0x588328
	internal static void CaughtException(Exception ex) { }

	// RVA: 0x590A44
	private void RenderCustom(Camera camera, bool disableCulling, bool copyDepth) { }

	// RVA: 0x592274
	private void UpdateCulling(Camera camera, bool disableCulling, bool copyDepth) { }

	// RVA: 0x592584
	private void UpdateDynamicObjectBounds() { }

	// RVA: 0x58F488
	private void CheckSceneInitialization() { }

	// RVA: 0x592B68
	private void InitializeScene() { }

	// RVA: 0x593184
	private void InitializeCulling() { }

	// RVA: 0x59016C
	private void CleanUpSceneData() { }

	// RVA: 0x58F364
	private void InvokeRenderEvent(CFRenderEvent renderEvent, Camera camera, bool renderIntoTexture) { }

	// RVA: 0x59031C
	private void InvokeCommandBuffers(CFCommandBufferEvent commandBufferEvent, ScriptableRenderContext context) { }

	// RVA: 0x593544
	public void .ctor() { }

	// RVA: 0x5935E8
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public class CFRenderPipelineAsset
{
	// Methods

	// RVA: 0x5938C4
	protected override RenderPipeline CreatePipeline() { }

	// RVA: 0x593918
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class DynamicLightingUtility
{
	// Methods

	// RVA: 0x593920
	public static void GetFullDynamicLight(Vector3 position, SphericalHarmonicsL2 cachedProbe, DrawCall drawCall, MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x593CFC
	public static Color ShadeSH9(SphericalHarmonicsL2 sh, Vector3 normal) { }

	// RVA: 0x5945B0
	public static void GetDominantSHLight(SphericalHarmonicsL2 sh, float upBias, Vector3 direction, Color color) { }

	// RVA: 0x594978
	public static Color GetAmbientSHLight(SphericalHarmonicsL2 sh) { }

	// RVA: 0x594A84
	public static Color GetReflectionFallBackColor(SphericalHarmonicsL2 sh) { }

	// RVA: 0x594BD8
	public static void SetEnviromentImage(CFEnvironmentImage image) { }

	// RVA: 0x59545C
	public static void SetEnviromentImage(CFEnvironmentImage image, CommandBuffer commandBuffer) { }

	// RVA: 0x5957EC
	public static void SetEnviromentImage(CFEnvironmentImage image, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x59614C
	public static void SetEnviromentImage(CFEnvironmentImage image, Material material) { }

	// RVA: 0x596AAC
	public static void GetSHCoefficients(Vector3 position, SphericalHarmonicsL2 probe) { }

	// RVA: 0x593A98
	public static void GetSHCoefficients(Vector3 position, SphericalHarmonicsL2 probe, float accumulation) { }

	// RVA: 0x597078
	public static void SetSHCoefficients(Vector3 position) { }

	// RVA: 0x597130
	public static void SetSHCoefficients(Vector3 position, CommandBuffer commandBuffer) { }

	// RVA: 0x5971F0
	public static void SetSHCoefficients(Vector3 position, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x5972B0
	public static void SetSHCoefficients(Vector3 position, Material material) { }

	// RVA: 0x594E58
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh) { }

	// RVA: 0x58E43C
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh, CommandBuffer commandBuffer) { }

	// RVA: 0x595A94
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x5963F4
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh, Material material) { }

	// RVA: 0x5951E0
	public static void SetReflectionMaps(Texture[] atlases) { }

	// RVA: 0x597370
	public static void SetReflectionMaps(Texture2DArray atlas, CommandBuffer commandBuffer) { }

	// RVA: 0x589DD0
	public static void SetReflectionMaps(Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

	// RVA: 0x595E80
	public static void SetReflectionMaps(Texture[] atlases, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x5967E0
	public static void SetReflectionMaps(Texture[] atlases, Material material) { }

	// RVA: 0x589D18
	public static void SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x597498
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias) { }

	// RVA: 0x59765C
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias, CommandBuffer commandBuffer) { }

	// RVA: 0x593B28
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias, MaterialPropertyBlock materialProbertyBlock) { }

	// RVA: 0x597830
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias, Material material) { }

	// RVA: 0x59539C
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor) { }

	// RVA: 0x595704
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor, CommandBuffer commandBuffer) { }

	// RVA: 0x596064
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor, MaterialPropertyBlock materialProbertyBlock) { }

	// RVA: 0x5969C4
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

	// RVA: 0x597A04
	public static bool get_HasValidData() { }

	// RVA: 0x597A88
	public static void TryLoadData(string data) { }

	// RVA: 0x597DDC
	public static void FreeData() { }

	// RVA: 0x597E88
	public static void SampleGIInterpolation(Vector3 position, Int32* indices, Single* weights) { }

	// RVA: 0x598ABC
	public static void SampleGI(Vector3 position, Vector3 normal, Color color) { }

	// RVA: 0x596B38
	public static void SampleGI(Vector3 position, SphericalHarmonicsL2 sh) { }

	// RVA: 0x598F80
	public static void SampleGI(Vector3 position, SphericalHarmonicsL2 sh) { }

	// RVA: 0x596DD8
	public static void SampleGI(Vector3 position, SphericalHarmonicsL2 sh, float accumulation) { }

	// RVA: 0x599468
	public static void SampleGISingle(Vector3 position, SphericalHarmonicsL2 sh) { }

	// RVA: 0x598D54
	private static void InterpolateSH9(Int32* indices, Single* weights, SphericalHarmonicsL2 sh) { }

	// RVA: 0x59920C
	private static void InterpolateSH9(Int32* indices, Single* weights, float accumulation, SphericalHarmonicsL2 sh) { }

	// RVA: 0x597FAC
	private static bool TryGatherInterpolators(Single* position, Int32* indices, Single* weights) { }

	// RVA: 0x5997C0
	private static bool TryFindSpanInCoord(Int32* coord, Int32* indices) { }

	// RVA: 0x598CE4
	private static void CopyDefaultProbe(SphericalHarmonicsL2 sh) { }

	// RVA: 0x59999C
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

	// RVA: 0x58DCF8
	public static void DrawIndexRanges(CommandBuffer cb, Mesh mesh, Matrix4x4 matrix, Material material, IndexRange[] indexes, UInt32 count, IntPtr nativeIndexBuffer) { }

	// RVA: 0x58FFD0
	public static void Reset() { }

	// RVA: 0x58CA28
	public static void SetIndices(CommandBuffer cb, IntPtr nativeIndexBufferPtr, UInt16[] indices, UInt32 count) { }

	// RVA: 0x599F98
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class ProjectionContextUtility
{
	// Methods

	// RVA: 0x59A044
	public static void SetupViewProjectionMatrices(CommandBuffer commandBuffer, Matrix4x4 view, Matrix4x4 projection) { }

	// RVA: 0x59A11C
	public static void SetupPerspective(CommandBuffer commandBuffer, Vector3 position, Quaternion rotation, float fieldOfView, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x59A400
	public static void SetupOrthographic(CommandBuffer commandBuffer, Vector3 position, Quaternion rotation, float sizeX, float sizeY, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x59A36C
	public static Matrix4x4 GetGPUPerspectiveProjectionMatrix(float fieldOfView, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x59A6D0
	public static Matrix4x4 GetGPUPerspectiveProjectionMatrix(float fieldOfView, float near, float far, float aspect, bool isRenderTexture) { }

	// RVA: 0x59A648
	public static Matrix4x4 GetGPUOrthographicProjectionMatrix(float near, float far, float width, float height, bool isRenderTexture) { }

	// RVA: 0x59A748
	public static void ContentSizeFitPerspective(Camera camera, BoundingSphere bounds, Quaternion rotation) { }

	// RVA: 0x59A8C0
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
	private bool m_lightmapSRGB; // 0x1C
	private readonly ISceneReflectionProbesUtilityService m_sceneReflectionProbesUtility; // 0x20
	public CommandBuffer cb; // 0x28

	// Methods

	// RVA: 0x58A694
	public void .ctor() { }

	// RVA: 0x59A9C8
	public void .ctor(ISceneReflectionProbesUtilityService sceneReflectionProbesUtility) { }

	// RVA: 0x58D8B8
	public void SetLightmapEnabled(bool enabled) { }

	// RVA: 0x58DC28
	public void SetLightmapIndex(Byte lightmapIndex, RenderTargetIdentifier[] lightmaps) { }

	// RVA: 0x58D950
	public void SetLightmapST(Vector4 lightmapST) { }

	// RVA: 0x58DAB8
	public void SetPositionEncodeFactor(float offset, float value) { }

	// RVA: 0x58DB88
	public void SetHDREncodeFactor(float factor) { }

	// RVA: 0x58D820
	public void SetLightProbeEnabled(bool enabled) { }

	// RVA: 0x59AA04
	public void SetReflectionProbeStatic() { }

	// RVA: 0x58E828
	public void SetReflectionProbe(Byte reflectionProbeIndex) { }

	// RVA: 0x58C354
	public void SetReflectionProbeCount(Byte count) { }

	// RVA: 0x58D788
	public void SetStatic(bool enabled) { }

	// RVA: 0x58DA10
	public void SetInvertCulling(bool invert) { }

	// RVA: 0x58C260
	public void Reset() { }

	// RVA: 0x58A714
	public void SetLightmapDecodeFormat(TextureFormat format, bool sRGB) { }

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

	// RVA: 0x59AAB8
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

	// RVA: 0x59B1CC
	public BatchedMeshInstance[] get_BatchedMeshes() { }

	// RVA: 0x59B1D4
	private void set_BatchedMeshes(BatchedMeshInstance[] value) { }

	// RVA: 0x59B1DC
	public StaticBatch[] get_Batches() { }

	// RVA: 0x59B1E4
	private void set_Batches(StaticBatch[] value) { }

	// RVA: 0x59B1EC
	public bool get_UsesHalfPrecision() { }

	// RVA: 0x58DA84
	public float get_PositionEncodeRange() { }

	// RVA: 0x58DB68
	public float get_HDREncodeFactor() { }

	// RVA: 0x58DA54
	public float get_PositionEncodeOffset() { }

	// RVA: 0x593458
	public void CleanUp() { }

	// RVA: 0x5930F8
	public void Initialize(StaticSceneData sceneData, OcclusionComponent occlusion) { }

	// RVA: 0x59B8B8
	private void CreateBatch(int batchIndex, StaticBatch batch, System.Collections.Generic.List<System.Int32> instances, TemporaryMeshData temporary, bool useHalfPrecision, MeshDataCache meshCache) { }

	// RVA: 0x59B20C
	private void CreateBatches() { }

	// RVA: 0x5930F0
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

	// RVA: 0x59CB44
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

	// RVA: 0x599E68
	public void Free() { }

	// RVA: 0x599DB0
	public IntPtr GetPtr(IndexRange[] indexes, UInt32 count, IntPtr nativeIndexBuffer) { }

	// RVA: 0x599D38
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

	// RVA: 0x59CB4C
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

	// RVA: 0x599E38
	public void Free() { }

	// RVA: 0x599F10
	public IntPtr GetPtr(IntPtr nativeIndexBufferPtr, UInt16[] indices, UInt32 count) { }

	// RVA: 0x599E98
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

	// RVA: 0x59344C
	internal void CleanUp() { }

	// RVA: 0x593408
	internal void Init(OcclusionData occlusionData, StaticSceneData sceneData) { }

	// RVA: 0x592808
	internal void Update(Camera camera, DynamicCullingData dynamicData, CullingResults results, bool disableCulling) { }

	// RVA: 0x591FDC
	internal int GetOcclusionAreaIndex(Vector3 position) { }

	// RVA: 0x5921E0
	internal int GetOcclusionAreaCount() { }

	// RVA: -1
	protected abstract void CleanUpCulling() { }

	// RVA: -1
	protected abstract void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: -1
	protected abstract void CullStatic(Camera camera, CullingResults results) { }

	// RVA: -1
	protected abstract void InitCulling() { }

	// RVA: 0x59CE9C
	protected void SetAllDynamicVisible(DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x59CD54
	protected void SetAllStaticVisible(CullingResults results) { }

	// RVA: 0x59CB54
	private void UpdateFrustum(Camera camera, CullingResults results) { }

	// RVA: 0x59CEFC
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

	// RVA: 0x59CF6C
	protected override void CleanUpCulling() { }

	// RVA: 0x59CF70
	protected override void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x59CFE8
	protected override void CullStatic(Camera camera, CullingResults results) { }

	// RVA: 0x59D9B8
	protected override void InitCulling() { }

	// RVA: 0x59D3CC
	private void UpdateOcclusionRecursive(Float3 origin, int clipStackDepth, int areaIndex, BitVector256 visitedAreas, CullingResults results) { }

	// RVA: 0x59D9BC
	public void .ctor() { }

	// RVA: 0x59DA70
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.Culling
internal class CullingNative
{
	// Fields
	private int m_areaIndex; // 0x68
	private IntPtr m_nativeScene; // 0x70

	// Methods

	// RVA: 0x59DB08
	protected override void CleanUpCulling() { }

	// RVA: 0x59DB7C
	protected override void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x59DD90
	protected override void CullStatic(Camera camera, CullingResults results) { }

	// RVA: 0x59DF04
	protected override void InitCulling() { }

	// RVA: 0x59DF48
	private static IntPtr LoadScene(OcclusionData occlusionData, StaticSceneData sceneData) { }

	// RVA: 0x593398
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Culling.Components
public class OcclusionComponent
{
	// Fields
	public OcclusionData occlusionData; // 0x20

	// Methods

	// RVA: 0x59E370
	public void .ctor() { }

}

// Namespace: 
public enum MeshLightMode
{
	// Fields
	public int value__; // 0x10
	public const MeshLightMode Full = 0;
	public const MeshLightMode ProbesOnly = 1;
	public const MeshLightMode Off = 2;
}

// Namespace: CFRenderLib.Unity.Components
public sealed class CFMeshRenderer
{
	// Fields
	public Mesh mesh; // 0x20
	public Material[] materials; // 0x28
	public MeshLightMode LightMode; // 0x30
	private CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> m_renderHandle; // 0x34
	private Matrix4x4 m_localToWorldMatrix; // 0x38
	private SphericalHarmonicsL2 m_cachedProbe; // 0x78
	private MaterialPropertyBlock m_cachedMaterialProps; // 0xE8

	// Methods

	// RVA: 0x59E378
	private void OnEnable() { }

	// RVA: 0x59E454
	private void OnDisable() { }

	// RVA: 0x59E4E4
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x59E6A4
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x59EA00
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x59EA04
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x59EA08
	private void OnDrawGizmos() { }

	// RVA: 0x59EB84
	private void OnDrawGizmosSelected() { }

	// RVA: 0x59EDEC
	private void ConvertToStaticMesh() { }

	// RVA: 0x59EEBC
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

	// RVA: 0x59EF38
	private void OnEnable() { }

	// RVA: 0x59F074
	private void OnDisable() { }

	// RVA: 0x59F20C
	private void Update() { }

	// RVA: 0x59F2E8
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x59F320
	private void UpdateBounds() { }

	// RVA: 0x59F508
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x59F7E4
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x59F7E8
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x59F7EC
	private void OnDrawGizmos() { }

	// RVA: 0x59F9EC
	private void OnDrawGizmosSelected() { }

	// RVA: 0x59FABC
	private void OnValidate() { }

	// RVA: 0x59F8F0
	private void CheckMesh() { }

	// RVA: 0x59FACC
	private void ConvertToMeshRenderer() { }

	// RVA: 0x59FB9C
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

	// RVA: 0x59FBB0
	private void OnEnable() { }

	// RVA: 0x59FD54
	private void OnDisable() { }

	// RVA: 0x59FFAC
	private void OnDestroy() { }

	// RVA: 0x5A01D8
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x5A0530
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x5A0978
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x5A0AE4
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x5A0AEC
	private void OnDrawGizmosSelected() { }

	// RVA: 0x5A0980
	private void SetCullingMode(ParticleSystemCullingMode mode) { }

	// RVA: 0x59FC20
	private void FindParticleSystems() { }

	// RVA: 0x5A0EC0
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

	// RVA: 0x5A0F98
	public bool get_IsVisible() { }

	// RVA: 0x5A11E0
	public bool get_HasCFLightMapRect() { }

	// RVA: 0x5A11E8
	public void set_HasCFLightMapRect(bool value) { }

	// RVA: 0x5A11F0
	public LightmapRect get_CFLightmapRect() { }

	// RVA: 0x5A1204
	public void set_CFLightmapRect(LightmapRect value) { }

	// RVA: 0x5A1218
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x5A1384
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x5A1500
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x5A16C0
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x5A1A98
	private void OnEnable() { }

	// RVA: 0x5A1C0C
	private void OnDisable() { }

	// RVA: 0x5A1DB0
	private void OnDestroy() { }

	// RVA: 0x5A152C
	private void UpdateBounds() { }

	// RVA: 0x5A1FBC
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

	// RVA: 0x5A208C
	public static Texture2D CreateAtlas(Texture2D[] sourceTextures, TextureAtlasPacking packing, AtlasParameters parameters) { }

	// RVA: 0x5A2514
	private static int FindMipmapCount(int blockWidth, TextureAtlasPacking packing) { }

	// RVA: 0x5A2634
	private void PackAtlas() { }

	// RVA: 0x5A28A0
	private void Start() { }

	// RVA: 0x5A28D4
	public void .ctor() { }

}

// Namespace: 
public struct SpanConnection
{
	// Fields
	public Vector3Int Position; // 0x10
	public int SpanIndex; // 0x1C
	public bool Valid; // 0x20
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
	public int CfSpanIndex; // 0x13C
	public Vector3 CfSpanStart; // 0x140
	public Vector3 CfSpanEnd; // 0x14C
	public System.Collections.Generic.List<CFRenderLib.Unity.Components.MapDataDebugger.SpanConnection> CfSpanConnections; // 0x158
	public SphericalHarmonicsL2 CfProbe; // 0x160
	public Color CfAmbient; // 0x1CC
	public Color CfDominant; // 0x1DC
	public Vector3 CfDirection; // 0x1EC
	public SphericalHarmonicsL2 CfInterpProbe; // 0x1F8
	public Color CfInterpAmbient; // 0x264
	public Color CfInterpDominant; // 0x274
	public Vector3 CfInterpDirection; // 0x284

	// Methods

	// RVA: 0x5A28DC
	protected void Update() { }

	// RVA: 0x5A356C
	protected void OnDrawGizmos() { }

	// RVA: 0x5A3B54
	private bool IsInAABB(Vector3Int voxel) { }

	// RVA: 0x5A2EFC
	private Vector3Int WorldToVoxelSpace(Vector3 world) { }

	// RVA: 0x5A2FE4
	private Vector3 VoxelToWorldSpace(Vector3Int voxel) { }

	// RVA: 0x5A3124
	private System.Collections.Generic.List<CFRenderLib.Unity.Components.MapDataDebugger.SpanConnection> GetConnections(Vector3Int cell, int spanIdx) { }

	// RVA: 0x5A3C30
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
internal class PreviewRenderable
{
	// Fields
	public GameObject original; // 0x20

	// Methods

	// RVA: 0x5A3C38
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

	// RVA: 0x5A3C40
	public Color get_GlobalTint() { }

	// RVA: 0x5A3C4C
	public Vector3 get_CCMin() { }

	// RVA: 0x5A3C58
	public Vector3 get_CCMax() { }

	// RVA: 0x5A3C64
	public static SceneGraphicsParameters get_Instance() { }

	// RVA: 0x5A3CB0
	private static void set_Instance(SceneGraphicsParameters value) { }

	// RVA: 0x5A3D14
	private void OnEnable() { }

	// RVA: 0x5A3E58
	private void OnValidate() { }

	// RVA: 0x5A3D78
	public void Apply() { }

	// RVA: 0x5A3E5C
	public static void Disable() { }

	// RVA: 0x5A3F3C
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

	// RVA: 0x5A3FE4
	public RenderTargetIdentifier[] get_LightmapRenderTargetIdentifiers() { }

	// RVA: 0x5A3FEC
	private void set_LightmapRenderTargetIdentifiers(RenderTargetIdentifier[] value) { }

	// RVA: 0x5A3FF4
	public static SceneLightmapData get_Instance() { }

	// RVA: 0x5A4040
	private static void set_Instance(SceneLightmapData value) { }

	// RVA: 0x5A40A4
	public void Add(Transform t, int lightmapIndex, Vector4 lightmapST) { }

	// RVA: 0x5A4194
	public void Apply() { }

	// RVA: 0x5A4518
	public bool TryGet(Transform t, LightmapObject obj) { }

	// RVA: 0x5A4614
	private void OnEnable() { }

	// RVA: 0x5A4678
	private void OnDestroy() { }

	// RVA: 0x5A440C
	private void CreateRenderTargets() { }

	// RVA: 0x5A47B8
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public sealed class SceneRasterizationConfigurationHolder
{
	// Fields
	private SceneRasterizationConfiguration m_bakeConfig; // 0x20
	private static SceneRasterizationConfigurationHolder <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x5A47C0
	public static SceneRasterizationConfigurationHolder get_Instance() { }

	// RVA: 0x5A480C
	private static void set_Instance(SceneRasterizationConfigurationHolder value) { }

	// RVA: 0x5A4870
	public SceneRasterizationConfiguration get_BakeConfig() { }

	// RVA: 0x5A4894
	private void OnEnable() { }

	// RVA: 0x5A48F0
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

	// RVA: 0x5A4954
	public void SortInstances() { }

	// RVA: 0x5A49FC
	internal void AddRenderersToAreas(OcclusionData occlusionData) { }

	// RVA: 0x5A4C88
	internal bool AddRendererToAreas(OcclusionData occlusionData, int rendererIndex, System.Collections.Generic.List<System.Int32>[] areaRenderers) { }

	// RVA: 0x5A4E28
	internal void CalculateRendererBounds() { }

	// RVA: 0x5A5174
	internal void CreateAtlasedMaterials() { }

	// RVA: 0x5A56A0
	internal void DestroyAtlasedMaterials() { }

	// RVA: 0x5A5880
	internal Material GetMaterial(UInt16 materialIndex) { }

	// RVA: 0x5A58EC
	internal int GetReflectionProbeIndex(OcclusionData occlusionData, int instanceIndex) { }

	// RVA: 0x5A5A34
	public void .ctor() { }

	// RVA: 0x5A5A48
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

	// RVA: 0x5A5D48
	public static UnityLightProbesHolder get_Instance() { }

	// RVA: 0x5A5D94
	private static void set_Instance(UnityLightProbesHolder value) { }

	// RVA: 0x5A5DF8
	private void OnEnable() { }

	// RVA: 0x5A5FF4
	public static UnityLightProbesHolder ForceGetInstance() { }

	// RVA: 0x5A6294
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

	// RVA: 0x5A629C
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

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x3525804
	public T[] get_Data() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	public CFRenderLib.Unity.Structs.Handle<T> Add(T data) { }

	// RVA: 0x26AD93C
	public bool Exists(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x26AD93C
	public CFRenderLib.Unity.Structs.Handle<T> GetHandleFromData(int dataIndex) { }

	// RVA: 0x26AD93C
	public T GetRef(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x26AD93C
	public void Remove(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x26AD93C
	private UInt16 AddData(T data) { }

	// RVA: 0x3526588
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

	// RVA: 0x5A62A4
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public float currentTime; // 0x10

	// Methods

	// RVA: 0x5A6394
	public void .ctor() { }

	// RVA: 0x5A6B10
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

	// RVA: 0x5A62AC
	internal void PruneLights(float currentTime) { }

	// RVA: 0x5A639C
	public void SetLightLimits(int lightLimit, int sampleLimit) { }

	// RVA: 0x5A6450
	public bool AddLight(SHLight light) { }

	// RVA: 0x5A651C
	public void RemoveLight(SHLight light) { }

	// RVA: 0x5A65A4
	public void FadeOutLight(SHLight light) { }

	// RVA: 0x5A66E8
	public void SampleLights(SphericalHarmonicsL2 sh, Vector3 position) { }

	// RVA: 0x5A6A74
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

	// RVA: 0x5A6B24
	public void Update(MaterialPropertyBlock materialPropertyBlock, int areaIndex, float deltaTime) { }

	// RVA: 0x5A6C4C
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

	// RVA: 0x5A6C64
	public void .ctor(int initialSize) { }

	// RVA: 0x5A6CF4
	public void Add(UInt16 value) { }

	// RVA: 0x5A6E80
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

	// RVA: 0x5A6E88
	public void .ctor(Mesh mesh) { }

	// RVA: 0x5A6F84
	public void .ctor(MeshData meshData, Mesh mesh, int submeshIndex) { }

	// RVA: 0x5A73F8
	private static int GetVertexCount(int[] subMeshIndices, int baseVertex) { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class MeshDataCache
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Int32,CFRenderLib.Unity.Collections.MeshData> m_meshDatas; // 0x10
	private readonly System.Collections.Generic.List<CFRenderLib.Unity.Structs.SubmeshData> m_subMeshDatas; // 0x18

	// Methods

	// RVA: 0x5A74A4
	public MeshData Get(Mesh mesh, int submeshIndex) { }

	// RVA: 0x5A76D4
	private MeshData Get(Mesh mesh) { }

	// RVA: 0x5A77CC
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

	// RVA: 0x5A25A4
	public void .ctor(Texture2D texture, TextureCompressionInfo tc) { }

	// RVA: 0x5A78AC
	private void FindMipmaps(TextureCompressionInfo tc) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class RenderableCache
{
	// Fields
	internal static CFRenderLib.Unity.Collections.DataCache<CFRenderLib.Unity.Structs.RenderableData> Roots; // 0x0

	// Methods

	// RVA: 0x59EFAC
	public static CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> Add(IRenderable renderable) { }

	// RVA: 0x59F168
	public static void Remove(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x5A113C
	public static RenderableData GetRef(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x59FF08
	public static bool Exists(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x5A7BE8
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

	// RVA: 0x5A7C84
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class RenderStats
{
	// Fields
	public static UInt32 indexCount; // 0x0
	public static UInt32 vertexCount; // 0x4

	// Methods

	// RVA: 0x5A7E10
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

	// RVA: 0x5A7E5C
	public void .ctor() { }

	// RVA: 0x5A7F44
	public void .ctor(IDynamicLightingUtilityService dynamicLightingUtility, ISceneReflectionProbesUtilityService sceneReflectionProbesUtility) { }

	// RVA: 0x5A7FE4
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

	// RVA: 0x5A80A0
	public UInt16 GetTextureIndex(Texture2D texture) { }

	// RVA: 0x5A81C8
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

	// RVA: 0x5A81D0
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

	// RVA: 0x5A85F0
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public int batchIndex; // 0x10

	// Methods

	// RVA: 0x5A85E8
	public void .ctor() { }

	// RVA: 0x5A85F8
	internal bool <AddMesh>b__0(BatchInfo b) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class StaticBatchInfo
{
	// Fields
	private static System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.BatchInfo> <Batches>k__BackingField; // 0x0

	// Methods

	// RVA: 0x5A81D8
	public static System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.BatchInfo> get_Batches() { }

	// RVA: 0x5A8224
	private static void set_Batches(System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.BatchInfo> value) { }

	// RVA: 0x5A8288
	public static void Clear() { }

	// RVA: 0x5A8338
	public static void AddMesh(string name, int vertexCount, string material, int lightmapIndex, MeshChannelData channels, int wantedBatchIndex, int batchIndex) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class StaticDataCache<T0>
{
	// Fields
	internal static CFRenderLib.Unity.Collections.DataCache<T> Cache; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public static CFRenderLib.Unity.Structs.Handle<T> Add(T t) { }

	// RVA: 0x26AD93C
	public static T GetRef(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x26AD93C
	public static void Remove(CFRenderLib.Unity.Structs.Handle<T> renderable) { }

	// RVA: 0x352AE04
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

	// RVA: 0x5A8620
	public Vector3 get_DominantLightDirection() { }

	// RVA: 0x5A8724
	public Color get_DominantLightColor() { }

	// RVA: 0x5A8730
	public float get_HDREncodeFactor() { }

	// RVA: 0x5A8738
	public SphericalHarmonicsL2 get_SH() { }

	// RVA: 0x5A8740
	public int get_ProbeSize() { }

	// RVA: 0x5A87FC
	public int get_Slice() { }

	// RVA: 0x5A8804
	public Texture2DArray[] get_ReflectionSamples() { }

	// RVA: 0x5A8908
	public void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=16
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=20
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=5395
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=12561
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly Int64 068459927F79051BE2A933FB2972B0AF185AFB5F1FDED6FFF258D61D5FB97084; // 0x0
	internal static readonly Int64 1ADB804EE85BAED94D5AC12322EB370A22BB71F9CA1DA2C40032C253780BD470; // 0x8
	internal static readonly __StaticArrayInitTypeSize=16 2ABD4BAF60452C683925A01754D5ABBE44CBC73682248428546AB2D512B96E65; // 0x10
	internal static readonly __StaticArrayInitTypeSize=16 4038348AF6E5B77BF25F510FD5FF230D3A611D61EF9FB6CA62313C860F128C1C; // 0x20
	internal static readonly __StaticArrayInitTypeSize=12561 51AB0A43ED179AB32E2B9A201B211CF916CB417F4E9422586FEA997B86AFE11A; // 0x30
	internal static readonly Int64 7D0A0F0DDA8BF523E6E10685083859543EDB68FFF579376B60C8920CFA7B5DEF; // 0x3148
	internal static readonly __StaticArrayInitTypeSize=16 8DF28E51E6285370840F0C8FD6BC27E3EF1CA52BD070712EDA60F9274B182AFC; // 0x3150
	internal static readonly Int64 9655D519C47A0B433D9B4ABC6335BE754440D271D1AD594C96DC11F672EAA4A4; // 0x3160
	internal static readonly __StaticArrayInitTypeSize=5395 B0C1B639B99CC9B4D81526ADA33FCBB8572A0B337B489FAD2D1DBB89D7BF393A; // 0x3168
	internal static readonly Int64 DCBC8A96B332D7B2B126D401D47D72C1DAF86DDD7102704C197EE0A8AC66D034; // 0x4680
	internal static readonly __StaticArrayInitTypeSize=20 F955B65874DC572B213A30BA1E58039C6A27841C2AE5ADF62AD5ED45ADA54F6D; // 0x4688
}


