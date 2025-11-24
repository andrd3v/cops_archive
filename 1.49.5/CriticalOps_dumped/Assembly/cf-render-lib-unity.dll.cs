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

	// RVA: 0x55D050
	private static MonoScriptData Get() { }

	// RVA: 0x55D154
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

	// RVA: 0x55D15C
	public static Vector3 ToUnity(Float3 v) { }

	// RVA: 0x55D160
	public static Float3 FromUnity(Vector3 v) { }

	// RVA: 0x55D164
	public static Plane ToUnity(Plane v) { }

	// RVA: 0x55D278
	public static Plane FromUnity(Plane v) { }

	// RVA: 0x55D27C
	public static SphericalHarmonicsL2 ToUnity(SphericalHarmonicsL2 sh) { }

	// RVA: 0x55D458
	public static SphericalHarmonicsL2 FromUnity(SphericalHarmonicsL2 unitysh) { }

	// RVA: 0x55D660
	public static Bounds ToUnity(BoundingBox b) { }

	// RVA: 0x55D6A8
	public static BoundingBox FromUnity(Bounds v) { }

	// RVA: 0x55D6F0
	public static Float4 FromUnity(Quaternion q) { }

	// RVA: 0x55D720
	public static Float4 FromUnityRGBA(Color c) { }

	// RVA: 0x55D750
	public static Float3 FromUnityRGB(Color c) { }

}

// Namespace: CFRenderLib.Unity
public class GameObjectFactory
{
	// Methods

	// RVA: 0x55D784
	public GameObject Create(string name) { }

	// RVA: 0x55D7EC
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

	// RVA: 0x55D7F4
	public static void Clear(TextureCompressionInfo tc, RawTextureData data, AtlasClearColor clearColor) { }

	// RVA: 0x55DB2C
	public static void CopyTexture(TextureCompressionInfo tc, RawTextureData source, RawTextureData target, int targetX, int targetY, int targetWidth, int targetHeight) { }

	// RVA: 0x55E264
	public static int GetBlockStartIndex(TextureCompressionInfo tc, RawTextureData tex, int mipmap, int blockX, int blockY) { }

	// RVA: 0x55E3C8
	private static void ClearBlock(TextureCompressionInfo tc, RawTextureData data, int x, int y, int mipmap, Byte[] clearBlock) { }

	// RVA: 0x55D93C
	private static void ClearMipmap(TextureCompressionInfo tc, RawTextureData data, int mipmap, Byte[] clearBlock) { }

	// RVA: 0x55E474
	private static void CopyBlock(TextureCompressionInfo tc, RawTextureData source, int sourceX, int sourceY, RawTextureData target, int targetX, int targetY, int sourceMipmap, int targetMipmap) { }

	// RVA: 0x55E044
	private static void CopyMipmap(TextureCompressionInfo tc, RawTextureData source, RawTextureData target, int targetX, int targetY, int sourceMipmap, int targetMipmap) { }

	// RVA: 0x55E358
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

	// RVA: 0x55D870
	public Byte[] GetColor(AtlasClearColor color) { }

	// RVA: 0x55E554
	public static TextureCompressionInfo Get(Texture2D tex) { }

	// RVA: 0x55EB90
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

	// Methods

	// RVA: 0x55EB98
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

	// RVA: 0x55EBA0
	public void .ctor(int renderQueue, System.Action<UnityEngine.Rendering.CommandBuffer> callback) { }

	// RVA: 0x55EBB0
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

	// RVA: 0x55EBF0
	public bool get_enableLightProbes() { }

	// RVA: 0x55EBFC
	public void set_enableLightProbes(bool value) { }

	// RVA: 0x55EC10
	public bool get_enableReflectionProbes() { }

	// RVA: 0x55EC1C
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

	// RVA: 0x55EC3C
	public void .ctor(float x, float y, float w, float h) { }

	// RVA: 0x55EC48
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

	// RVA: 0x55EC54
	public static IntRect MinMax(int xMin, int yMin, int xMax, int yMax) { }

	// RVA: 0x55EC70
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

	// RVA: 0x55EC7C
	public bool Equals(MeshChannelData m) { }

	// RVA: 0x55ECC8
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

	// RVA: 0x55ED40
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

	// RVA: 0x55ED48
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

	// RVA: 0x55EDE0
	public void .ctor(Vector3 position, Color startColor, Color endColor, float radius, float duration, float fadeTime) { }

	// RVA: 0x55EE14
	public override int GetHashCode() { }

	// RVA: 0x55EE88
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

	// RVA: 0x55EF24
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

	// RVA: 0x55EF2C
	public int get_vertexCount() { }

	// RVA: 0x55EF34
	public int get_size() { }

	// RVA: 0x55EF40
	public void .ctor(UInt32 capacity) { }

	// RVA: 0x55F054
	public void SetAttributes(MeshChannelData channels, bool useHalfPrecision) { }

	// RVA: 0x55F3E4
	public void SetFloat3(VertexAttribute attribute, Float3 value) { }

	// RVA: 0x55F45C
	public void SetColor32(VertexAttribute attribute, Color32 value) { }

	// RVA: 0x55F4D4
	public void SetSnormByte4(VertexAttribute attribute, SnormByte4 value) { }

	// RVA: 0x55F54C
	public void SetHalf2(VertexAttribute attribute, Half2 value) { }

	// RVA: 0x55F5C4
	public void SetHalf4(VertexAttribute attribute, Half4 value) { }

	// RVA: 0x55F63C
	public void SetUnormHalf2(VertexAttribute attribute, UnormHalf2 value) { }

	// RVA: 0x55F6B4
	public void SetUnormHalf4(VertexAttribute attribute, UnormHalf4 value) { }

	// RVA: 0x55F72C
	public void SetSnormHalf4(VertexAttribute attribute, SnormHalf4 value) { }

	// RVA: 0x55F7A4
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

	// RVA: 0x55F834
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

	// RVA: 0x55F908
	public void ApplyOffset(Byte index) { }

	// RVA: 0x55F978
	public void ApplyOffset(Byte index, CommandBuffer commandBuffer) { }

	// RVA: 0x55FA08
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal class ApplicationWrapper
{
	// Methods

	// RVA: 0x55FA10
	public string get_DataPath() { }

	// RVA: 0x55FA80
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

	// RVA: 0x55FA88
	public void LogError(string message) { }

	// RVA: 0x55FB10
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

	// RVA: 0x55FB18
	public void SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x55FC70
	public void SetReflectionMaps(Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

	// RVA: 0x55FF54
	public void .ctor() { }

	// RVA: 0x55FF5C
	private void CFRenderLib.Unity.Services.IDynamicLightingUtilityService.SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x560008
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

	// RVA: 0x560014
	public void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x560024
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

	// RVA: 0x56002C
	public void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x5600A8
	public void Blit(Texture source, Material sourceMaterial) { }

	// RVA: 0x560114
	public void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

	// RVA: 0x5601A8
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

	// RVA: 0x5601B0
	public bool Button(string label, GUILayoutOption[] options) { }

	// RVA: 0x5601C0
	public void FlexibleSpace() { }

	// RVA: 0x5601C8
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

	// RVA: 0x5601D0
	public int ClosestPowerOfTwo(int value) { }

	// RVA: 0x5601DC
	public bool IsPowerOfTwo(int value) { }

	// RVA: 0x5601E8
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

	// RVA: 0x5601F0
	public RenderTexture get_Active() { }

	// RVA: 0x5601F8
	public void set_Active(RenderTexture value) { }

	// RVA: 0x560204
	public RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x56021C
	public void ReleaseTemporary(RenderTexture renderTexture) { }

	// RVA: 0x560228
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

	// RVA: 0x560230
	public Scene GetActiveScene() { }

	// RVA: 0x5602A0
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

	// RVA: 0x5602A8
	public void DisableKeyword(string keyword) { }

	// RVA: 0x5602B4
	public void EnableKeyword(string keyword) { }

	// RVA: 0x5602C0
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

	// RVA: 0x5602C8
	public void .ctor() { }

	// RVA: 0x5606F0
	private Material get_NullMaterial() { }

	// RVA: 0x56083C
	private void CFRenderLib.Unity.Interfaces.IRenderer.Draw(DrawCall drawCall) { }

	// RVA: 0x560BF4
	private void CFRenderLib.Unity.Interfaces.IRenderer.Render(RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer) { }

	// RVA: 0x561768
	private void CFRenderLib.Unity.Interfaces.IRenderer.BeginRecordDrawCalls() { }

	// RVA: 0x5617C4
	private bool CFRenderLib.Unity.Interfaces.IRenderer.EndRecordDrawCalls(CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Unity.Structs.DrawCall>& recordedDrawCalls) { }

	// RVA: 0x561810
	public void CleanUp() { }

	// RVA: 0x560DC0
	public void Render(StaticBatcher staticBatcher, RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer, System.Collections.Generic.IReadOnlyList<System.Int32> copyDepthPasses, RenderTexture copyDepthSource, System.Collections.Generic.IReadOnlyList<CFRenderLib.Unity.Structs.CustomCommandBufferPass> customCommandBufferPasses) { }

	// RVA: 0x5609FC
	private UInt16 GetRenderQueueIndex(Material material) { }

	// RVA: 0x561E50
	private void SortInstancesToQueueAndBatches(StaticBatcher staticBatcher, int[] instances, int instanceCount) { }

	// RVA: 0x562410
	private void UpdateIndexRanges(StaticBatch batch) { }

	// RVA: 0x562660
	private void UpdateIndexBuffer(StaticBatch batch) { }

	// RVA: 0x561814
	private void ClearDrawCalls() { }

	// RVA: 0x5618BC
	private void SortDynamicToQueue(RenderableData[] renderableDatas, int renderableCount, CullingResults cullingResults) { }

	// RVA: 0x5623C0
	private void ExecuteRenderPass(RenderPass pass, StaticBatcher staticBatcher) { }

	// RVA: 0x562FA0
	private void RenderStatic(RenderPass pass, StaticBatcher staticBatcher) { }

	// RVA: 0x562C90
	private void RenderDynamic(RenderPass pass) { }

	// RVA: 0x563F88
	private void RenderDrawCall(DrawCall dc, RenderTargetIdentifier[] lightmapTextures, int lightmapCount) { }

	// RVA: 0x5648E8
	private static void .cctor() { }

	// RVA: 0x5649DC
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

	// RVA: 0x56927C
	private static void .cctor() { }

	// RVA: 0x5692E8
	public void .ctor() { }

	// RVA: 0x5692F0
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
	private Culling m_culling; // 0x20
	private CullingResults m_cullingResults; // 0x28
	private DynamicCullingData m_cullingDynamic; // 0x30
	private CFRenderer m_renderer; // 0x38
	private StaticBatcher m_staticBatcher; // 0x40
	private Scene m_currentScene; // 0x48
	private StaticSceneData m_sceneData; // 0x50
	private OcclusionComponent m_occlusionComponent; // 0x58
	private static System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> <ActRenderPrefab>k__BackingField; // 0x60
	private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> <ActRenderPreview>k__BackingField; // 0x68
	private static System.Action<UnityEngine.Camera> <ActRenderUI>k__BackingField; // 0x70

	// Methods

	// RVA: 0x564A34
	internal static System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> get_ActRenderPrefab() { }

	// RVA: 0x564AB0
	internal static void set_ActRenderPrefab(System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> value) { }

	// RVA: 0x564B1C
	internal static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> get_ActRenderPreview() { }

	// RVA: 0x564B98
	internal static void set_ActRenderPreview(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> value) { }

	// RVA: 0x564C04
	internal static System.Action<UnityEngine.Camera> get_ActRenderUI() { }

	// RVA: 0x564C80
	internal static void set_ActRenderUI(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x564CEC
	protected override void Render(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x564CF0
	protected override void Render(ScriptableRenderContext renderContext, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x566134
	protected override void Dispose(bool disposing) { }

	// RVA: 0x565534
	private void Render(ScriptableRenderContext context, Camera camera, bool copyDepth, bool isUICamera) { }

	// RVA: 0x5663A0
	private void GatherCommands(ScriptableRenderContext context, Camera camera, bool copyDepth) { }

	// RVA: 0x566678
	private void RenderUI(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x566B2C
	public static void SetOverrideRenderTarget(RenderTexture renderTexture) { }

	// RVA: 0x566B98
	public static void RegisterCommandBuffer(CFCommandBufferEvent commandBufferEvent, CommandBuffer commandBuffer) { }

	// RVA: 0x566DE0
	public static void UnRegisterCommandBuffer(CFCommandBufferEvent commandBufferEvent, CommandBuffer commandBuffer) { }

	// RVA: 0x566EF0
	public static void RegisterRenderEvent(CFRenderEvent renderEvent, System.Action<UnityEngine.Camera,System.Boolean> action) { }

	// RVA: 0x567138
	public static void UnRegisterRenderEvent(CFRenderEvent renderEvent, System.Action<UnityEngine.Camera,System.Boolean> action) { }

	// RVA: 0x567248
	public static void AddDepthCopyPass(int renderQueue) { }

	// RVA: 0x567348
	public static void AddCustomCommandBufferPass(int renderQueue, System.Action<UnityEngine.Rendering.CommandBuffer> callback) { }

	// RVA: 0x567450
	public static void StartLowResPass(CommandBuffer commandBuffer, int width, int height) { }

	// RVA: 0x56764C
	public static void EndLowResPass(CommandBuffer commandBuffer, bool blitColor, bool blitDepth) { }

	// RVA: 0x567DC4
	public static void SetCaughtExceptionCallback(System.Action<System.Exception> action) { }

	// RVA: 0x55E1A0
	internal static void CaughtException(Exception ex) { }

	// RVA: 0x566900
	private void RenderCustom(Camera camera, bool disableCulling, bool copyDepth) { }

	// RVA: 0x567E30
	private void UpdateCulling(Camera camera, bool disableCulling, bool copyDepth) { }

	// RVA: 0x568098
	private void UpdateDynamicObjectBounds() { }

	// RVA: 0x56545C
	private void CheckSceneInitialization() { }

	// RVA: 0x5685BC
	private void InitializeScene() { }

	// RVA: 0x568BD8
	private void InitializeCulling() { }

	// RVA: 0x566138
	private void CleanUpSceneData() { }

	// RVA: 0x565338
	private void InvokeRenderEvent(CFRenderEvent renderEvent, Camera camera, bool renderIntoTexture) { }

	// RVA: 0x566270
	private void InvokeCommandBuffers(CFCommandBufferEvent commandBufferEvent, ScriptableRenderContext context) { }

	// RVA: 0x568F58
	public void .ctor() { }

	// RVA: 0x568FFC
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public class CFRenderPipelineAsset
{
	// Methods

	// RVA: 0x5692F8
	protected override RenderPipeline CreatePipeline() { }

	// RVA: 0x56934C
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class DynamicLightingUtility
{
	// Methods

	// RVA: 0x569354
	public static void GetFullDynamicLight(Vector3 position, SphericalHarmonicsL2 cachedProbe, DrawCall drawCall, MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x569730
	public static Color ShadeSH9(SphericalHarmonicsL2 sh, Vector3 normal) { }

	// RVA: 0x569FE4
	public static void GetDominantSHLight(SphericalHarmonicsL2 sh, float upBias, Vector3 direction, Color color) { }

	// RVA: 0x56A3AC
	public static Color GetAmbientSHLight(SphericalHarmonicsL2 sh) { }

	// RVA: 0x56A4B8
	public static Color GetReflectionFallBackColor(SphericalHarmonicsL2 sh) { }

	// RVA: 0x56A60C
	public static void SetEnviromentImage(CFEnvironmentImage image) { }

	// RVA: 0x56AE90
	public static void SetEnviromentImage(CFEnvironmentImage image, CommandBuffer commandBuffer) { }

	// RVA: 0x56B220
	public static void SetEnviromentImage(CFEnvironmentImage image, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x56BB80
	public static void SetEnviromentImage(CFEnvironmentImage image, Material material) { }

	// RVA: 0x56C4E0
	public static void GetSHCoefficients(Vector3 position, SphericalHarmonicsL2 probe) { }

	// RVA: 0x5694CC
	public static void GetSHCoefficients(Vector3 position, SphericalHarmonicsL2 probe, float accumulation) { }

	// RVA: 0x56CAAC
	public static void SetSHCoefficients(Vector3 position) { }

	// RVA: 0x56CB64
	public static void SetSHCoefficients(Vector3 position, CommandBuffer commandBuffer) { }

	// RVA: 0x56CC24
	public static void SetSHCoefficients(Vector3 position, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x56CCE4
	public static void SetSHCoefficients(Vector3 position, Material material) { }

	// RVA: 0x56A88C
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh) { }

	// RVA: 0x564410
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh, CommandBuffer commandBuffer) { }

	// RVA: 0x56B4C8
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x56BE28
	public static void SetSHCoefficients(SphericalHarmonicsL2 sh, Material material) { }

	// RVA: 0x56AC14
	public static void SetReflectionMaps(Texture[] atlases) { }

	// RVA: 0x56CDA4
	public static void SetReflectionMaps(Texture2DArray atlas, CommandBuffer commandBuffer) { }

	// RVA: 0x55FC7C
	public static void SetReflectionMaps(Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

	// RVA: 0x56B8B4
	public static void SetReflectionMaps(Texture[] atlases, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x56C214
	public static void SetReflectionMaps(Texture[] atlases, Material material) { }

	// RVA: 0x55FBC4
	public static void SetReflectionMaps(RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x56CECC
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias) { }

	// RVA: 0x56D090
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias, CommandBuffer commandBuffer) { }

	// RVA: 0x56955C
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias, MaterialPropertyBlock materialProbertyBlock) { }

	// RVA: 0x56D264
	public static void SetDynamicLight(SphericalHarmonicsL2 sh, float upBias, Material material) { }

	// RVA: 0x56ADD0
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor) { }

	// RVA: 0x56B138
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor, CommandBuffer commandBuffer) { }

	// RVA: 0x56BA98
	public static void SetDynamicLight(Vector3 direction, Color color, Color reflectionFallBackColor, MaterialPropertyBlock materialProbertyBlock) { }

	// RVA: 0x56C3F8
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

	// RVA: 0x56D438
	public static bool get_HasValidData() { }

	// RVA: 0x56D4BC
	public static void TryLoadData(string data) { }

	// RVA: 0x56D7FC
	public static void FreeData() { }

	// RVA: 0x56D8A8
	public static void SampleGIInterpolation(Vector3 position, Int32* indices, Single* weights) { }

	// RVA: 0x56E4E8
	public static void SampleGI(Vector3 position, Vector3 normal, Color color) { }

	// RVA: 0x56C56C
	public static void SampleGI(Vector3 position, SphericalHarmonicsL2 sh) { }

	// RVA: 0x56E9AC
	public static void SampleGI(Vector3 position, SphericalHarmonicsL2 sh) { }

	// RVA: 0x56C80C
	public static void SampleGI(Vector3 position, SphericalHarmonicsL2 sh, float accumulation) { }

	// RVA: 0x56EE94
	public static void SampleGISingle(Vector3 position, SphericalHarmonicsL2 sh) { }

	// RVA: 0x56E780
	private static void InterpolateSH9(Int32* indices, Single* weights, SphericalHarmonicsL2 sh) { }

	// RVA: 0x56EC38
	private static void InterpolateSH9(Int32* indices, Single* weights, float accumulation, SphericalHarmonicsL2 sh) { }

	// RVA: 0x56D9CC
	private static bool TryGatherInterpolators(Single* position, Int32* indices, Single* weights) { }

	// RVA: 0x56F1EC
	private static bool TryFindSpanInCoord(Int32* coord, Int32* indices) { }

	// RVA: 0x56E710
	private static void CopyDefaultProbe(SphericalHarmonicsL2 sh) { }

	// RVA: 0x56F3C8
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

	// RVA: 0x563CCC
	public static void DrawIndexRanges(CommandBuffer cb, Mesh mesh, Matrix4x4 matrix, Material material, IndexRange[] indexes, UInt32 count, IntPtr nativeIndexBuffer) { }

	// RVA: 0x565F9C
	public static void Reset() { }

	// RVA: 0x5629FC
	public static void SetIndices(CommandBuffer cb, IntPtr nativeIndexBufferPtr, UInt16[] indices, UInt32 count) { }

	// RVA: 0x56F9C4
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class ProjectionContextUtility
{
	// Methods

	// RVA: 0x56FA70
	public static void SetupViewProjectionMatrices(CommandBuffer commandBuffer, Matrix4x4 view, Matrix4x4 projection) { }

	// RVA: 0x56FB48
	public static void SetupPerspective(CommandBuffer commandBuffer, Vector3 position, Quaternion rotation, float fieldOfView, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x56FE2C
	public static void SetupOrthographic(CommandBuffer commandBuffer, Vector3 position, Quaternion rotation, float sizeX, float sizeY, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x56FD98
	public static Matrix4x4 GetGPUPerspectiveProjectionMatrix(float fieldOfView, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x5700FC
	public static Matrix4x4 GetGPUPerspectiveProjectionMatrix(float fieldOfView, float near, float far, float aspect, bool isRenderTexture) { }

	// RVA: 0x570074
	public static Matrix4x4 GetGPUOrthographicProjectionMatrix(float near, float far, float width, float height, bool isRenderTexture) { }

	// RVA: 0x570174
	public static void ContentSizeFitPerspective(Camera camera, BoundingSphere bounds, Quaternion rotation) { }

	// RVA: 0x5702EC
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

	// RVA: 0x560594
	public void .ctor() { }

	// RVA: 0x5703F4
	public void .ctor(ISceneReflectionProbesUtilityService sceneReflectionProbesUtility) { }

	// RVA: 0x56388C
	public void SetLightmapEnabled(bool enabled) { }

	// RVA: 0x563BFC
	public void SetLightmapIndex(Byte lightmapIndex, RenderTargetIdentifier[] lightmaps) { }

	// RVA: 0x563924
	public void SetLightmapST(Vector4 lightmapST) { }

	// RVA: 0x563A8C
	public void SetPositionEncodeFactor(float offset, float value) { }

	// RVA: 0x563B5C
	public void SetHDREncodeFactor(float factor) { }

	// RVA: 0x5637F4
	public void SetLightProbeEnabled(bool enabled) { }

	// RVA: 0x570430
	public void SetReflectionProbeStatic() { }

	// RVA: 0x5647FC
	public void SetReflectionProbe(Byte reflectionProbeIndex) { }

	// RVA: 0x562328
	public void SetReflectionProbeCount(Byte count) { }

	// RVA: 0x56375C
	public void SetStatic(bool enabled) { }

	// RVA: 0x5639E4
	public void SetInvertCulling(bool invert) { }

	// RVA: 0x562140
	public void Reset() { }

	// RVA: 0x560614
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

	// RVA: 0x5704E4
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

	// RVA: 0x570BF8
	public BatchedMeshInstance[] get_BatchedMeshes() { }

	// RVA: 0x570C00
	private void set_BatchedMeshes(BatchedMeshInstance[] value) { }

	// RVA: 0x570C08
	public StaticBatch[] get_Batches() { }

	// RVA: 0x570C10
	private void set_Batches(StaticBatch[] value) { }

	// RVA: 0x570C18
	public bool get_UsesHalfPrecision() { }

	// RVA: 0x563A58
	public float get_PositionEncodeRange() { }

	// RVA: 0x563B3C
	public float get_HDREncodeFactor() { }

	// RVA: 0x563A28
	public float get_PositionEncodeOffset() { }

	// RVA: 0x568E6C
	public void CleanUp() { }

	// RVA: 0x568B4C
	public void Initialize(StaticSceneData sceneData, OcclusionComponent occlusion) { }

	// RVA: 0x5712E4
	private void CreateBatch(int batchIndex, StaticBatch batch, System.Collections.Generic.List<System.Int32> instances, TemporaryMeshData temporary, bool useHalfPrecision, MeshDataCache meshCache) { }

	// RVA: 0x570C38
	private void CreateBatches() { }

	// RVA: 0x568B44
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

	// RVA: 0x572574
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

	// RVA: 0x56F894
	public void Free() { }

	// RVA: 0x56F7DC
	public IntPtr GetPtr(IndexRange[] indexes, UInt32 count, IntPtr nativeIndexBuffer) { }

	// RVA: 0x56F764
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

	// RVA: 0x57257C
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

	// RVA: 0x56F864
	public void Free() { }

	// RVA: 0x56F93C
	public IntPtr GetPtr(IntPtr nativeIndexBufferPtr, UInt16[] indices, UInt32 count) { }

	// RVA: 0x56F8C4
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

	// RVA: 0x568E60
	internal void CleanUp() { }

	// RVA: 0x568E1C
	internal void Init(OcclusionData occlusionData, StaticSceneData sceneData) { }

	// RVA: 0x56831C
	internal void Update(Camera camera, DynamicCullingData dynamicData, CullingResults results, bool disableCulling) { }

	// RVA: -1
	protected abstract void CleanUpCulling() { }

	// RVA: -1
	protected abstract void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: -1
	protected abstract void CullStatic(Camera camera, CullingResults results) { }

	// RVA: -1
	protected abstract void InitCulling() { }

	// RVA: 0x572858
	protected void SetAllDynamicVisible(DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x572784
	protected void SetAllStaticVisible(CullingResults results) { }

	// RVA: 0x572584
	private void UpdateFrustum(Camera camera, CullingResults results) { }

	// RVA: 0x5728B8
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

	// RVA: 0x572928
	protected override void CleanUpCulling() { }

	// RVA: 0x57292C
	protected override void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x5729A4
	protected override void CullStatic(Camera camera, CullingResults results) { }

	// RVA: 0x573340
	protected override void InitCulling() { }

	// RVA: 0x572D88
	private void UpdateOcclusionRecursive(Float3 origin, int clipStackDepth, int areaIndex, BitVector256 visitedAreas, CullingResults results) { }

	// RVA: 0x573344
	public void .ctor() { }

	// RVA: 0x5733F8
	private static void .cctor() { }

}

// Namespace: CFRenderLib.Unity.Culling
internal class CullingNative
{
	// Fields
	private int m_areaIndex; // 0x68
	private IntPtr m_nativeScene; // 0x70

	// Methods

	// RVA: 0x573490
	protected override void CleanUpCulling() { }

	// RVA: 0x573514
	protected override void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x573728
	protected override void CullStatic(Camera camera, CullingResults results) { }

	// RVA: 0x573864
	protected override void InitCulling() { }

	// RVA: 0x5738A8
	private static IntPtr LoadScene(OcclusionData occlusionData, StaticSceneData sceneData) { }

	// RVA: 0x568DAC
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Culling.Components
public class OcclusionComponent
{
	// Fields
	public OcclusionData occlusionData; // 0x20

	// Methods

	// RVA: 0x573CD0
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

	// RVA: 0x573CD8
	private void OnEnable() { }

	// RVA: 0x573DB4
	private void OnDisable() { }

	// RVA: 0x573E44
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x574004
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x57439C
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x5743A0
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x5743A4
	private void OnDrawGizmos() { }

	// RVA: 0x574520
	private void OnDrawGizmosSelected() { }

	// RVA: 0x574788
	private void ConvertToStaticMesh() { }

	// RVA: 0x574858
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

	// RVA: 0x5748D4
	private void OnEnable() { }

	// RVA: 0x574A10
	private void OnDisable() { }

	// RVA: 0x574BA8
	private void Update() { }

	// RVA: 0x574C84
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x574CBC
	private void UpdateBounds() { }

	// RVA: 0x574EA4
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x575180
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x575184
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x575188
	private void OnDrawGizmos() { }

	// RVA: 0x575388
	private void OnDrawGizmosSelected() { }

	// RVA: 0x575458
	private void OnValidate() { }

	// RVA: 0x57528C
	private void CheckMesh() { }

	// RVA: 0x575468
	private void ConvertToMeshRenderer() { }

	// RVA: 0x575538
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

	// RVA: 0x57554C
	private void OnEnable() { }

	// RVA: 0x5756F0
	private void OnDisable() { }

	// RVA: 0x575948
	private void OnDestroy() { }

	// RVA: 0x575B74
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x575ECC
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x576314
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x576480
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x576488
	private void OnDrawGizmosSelected() { }

	// RVA: 0x57631C
	private void SetCullingMode(ParticleSystemCullingMode mode) { }

	// RVA: 0x5755BC
	private void FindParticleSystems() { }

	// RVA: 0x57685C
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

	// RVA: 0x576934
	public bool get_IsVisible() { }

	// RVA: 0x576B7C
	public bool get_HasCFLightMapRect() { }

	// RVA: 0x576B84
	public void set_HasCFLightMapRect(bool value) { }

	// RVA: 0x576B8C
	public LightmapRect get_CFLightmapRect() { }

	// RVA: 0x576BA0
	public void set_CFLightmapRect(LightmapRect value) { }

	// RVA: 0x576BB4
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(RenderableData data) { }

	// RVA: 0x576D20
	private void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(RenderableData data) { }

	// RVA: 0x576E9C
	private void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(RenderableData data) { }

	// RVA: 0x57705C
	private void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, RenderableData data) { }

	// RVA: 0x577434
	private void OnEnable() { }

	// RVA: 0x5775A8
	private void OnDisable() { }

	// RVA: 0x57774C
	private void OnDestroy() { }

	// RVA: 0x576EC8
	private void UpdateBounds() { }

	// RVA: 0x577958
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

	// RVA: 0x577A28
	public static Texture2D CreateAtlas(Texture2D[] sourceTextures, TextureAtlasPacking packing, AtlasParameters parameters) { }

	// RVA: 0x577E70
	private static int FindMipmapCount(int blockWidth, TextureAtlasPacking packing) { }

	// RVA: 0x577F90
	private void PackAtlas() { }

	// RVA: 0x578208
	private void Start() { }

	// RVA: 0x57823C
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

	// RVA: 0x578244
	protected void Update() { }

	// RVA: 0x57872C
	protected void OnDrawGizmos() { }

	// RVA: 0x578644
	private Vector3Int WorldToVoxelSpace(Vector3 world) { }

	// RVA: 0x578C64
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
internal class PreviewRenderable
{
	// Fields
	public GameObject original; // 0x20

	// Methods

	// RVA: 0x578C6C
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

	// RVA: 0x578C74
	public Color get_GlobalTint() { }

	// RVA: 0x578C80
	public Vector3 get_CCMin() { }

	// RVA: 0x578C8C
	public Vector3 get_CCMax() { }

	// RVA: 0x578C98
	public static SceneGraphicsParameters get_Instance() { }

	// RVA: 0x578CE4
	private static void set_Instance(SceneGraphicsParameters value) { }

	// RVA: 0x578D48
	private void OnEnable() { }

	// RVA: 0x578E8C
	private void OnValidate() { }

	// RVA: 0x578DAC
	public void Apply() { }

	// RVA: 0x578E90
	public static void Disable() { }

	// RVA: 0x578F70
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

	// RVA: 0x579018
	public RenderTargetIdentifier[] get_LightmapRenderTargetIdentifiers() { }

	// RVA: 0x579020
	private void set_LightmapRenderTargetIdentifiers(RenderTargetIdentifier[] value) { }

	// RVA: 0x579028
	public static SceneLightmapData get_Instance() { }

	// RVA: 0x579074
	private static void set_Instance(SceneLightmapData value) { }

	// RVA: 0x5790D8
	public void Add(Transform t, int lightmapIndex, Vector4 lightmapST) { }

	// RVA: 0x5791C8
	public void Apply() { }

	// RVA: 0x57954C
	public bool TryGet(Transform t, LightmapObject obj) { }

	// RVA: 0x579648
	private void OnEnable() { }

	// RVA: 0x5796AC
	private void OnDestroy() { }

	// RVA: 0x579440
	private void CreateRenderTargets() { }

	// RVA: 0x5797EC
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public sealed class SceneRasterizationConfigurationHolder
{
	// Fields
	private SceneRasterizationConfiguration m_bakeConfig; // 0x20
	private static SceneRasterizationConfigurationHolder <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x5797F4
	public static SceneRasterizationConfigurationHolder get_Instance() { }

	// RVA: 0x579840
	private static void set_Instance(SceneRasterizationConfigurationHolder value) { }

	// RVA: 0x5798A4
	public SceneRasterizationConfiguration get_BakeConfig() { }

	// RVA: 0x5798C8
	private void OnEnable() { }

	// RVA: 0x579924
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

	// RVA: 0x579988
	public void SortInstances() { }

	// RVA: 0x579A30
	internal void AddRenderersToAreas(OcclusionData occlusionData) { }

	// RVA: 0x579CBC
	internal bool AddRendererToAreas(OcclusionData occlusionData, int rendererIndex, System.Collections.Generic.List<System.Int32>[] areaRenderers) { }

	// RVA: 0x579E5C
	internal void CalculateRendererBounds() { }

	// RVA: 0x57A1AC
	internal void CreateAtlasedMaterials() { }

	// RVA: 0x57A6D8
	internal void DestroyAtlasedMaterials() { }

	// RVA: 0x57A8B8
	internal Material GetMaterial(UInt16 materialIndex) { }

	// RVA: 0x57A924
	internal int GetReflectionProbeIndex(OcclusionData occlusionData, int instanceIndex) { }

	// RVA: 0x57AA6C
	public void .ctor() { }

	// RVA: 0x57AA80
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

	// RVA: 0x57AD80
	public static UnityLightProbesHolder get_Instance() { }

	// RVA: 0x57ADCC
	private static void set_Instance(UnityLightProbesHolder value) { }

	// RVA: 0x57AE30
	private void OnEnable() { }

	// RVA: 0x57B02C
	public static UnityLightProbesHolder ForceGetInstance() { }

	// RVA: 0x57B2C4
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

	// RVA: 0x57B2CC
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

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B1CD4
	public T[] get_Data() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	public CFRenderLib.Unity.Structs.Handle<T> Add(T data) { }

	// RVA: 0x316B894
	public bool Exists(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x316B894
	public CFRenderLib.Unity.Structs.Handle<T> GetHandleFromData(int dataIndex) { }

	// RVA: 0x316B894
	public T GetRef(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x316B894
	public void Remove(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x316B894
	private UInt16 AddData(T data) { }

	// RVA: 0x30B2A58
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

	// RVA: 0x57B2D4
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public float currentTime; // 0x10

	// Methods

	// RVA: 0x57B3C4
	public void .ctor() { }

	// RVA: 0x57BB40
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

	// RVA: 0x57B2DC
	internal void PruneLights(float currentTime) { }

	// RVA: 0x57B3CC
	public void SetLightLimits(int lightLimit, int sampleLimit) { }

	// RVA: 0x57B480
	public bool AddLight(SHLight light) { }

	// RVA: 0x57B54C
	public void RemoveLight(SHLight light) { }

	// RVA: 0x57B5D4
	public void FadeOutLight(SHLight light) { }

	// RVA: 0x57B718
	public void SampleLights(SphericalHarmonicsL2 sh, Vector3 position) { }

	// RVA: 0x57BAA4
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

	// RVA: 0x57BB54
	public void Update(MaterialPropertyBlock materialPropertyBlock, int areaIndex, float deltaTime) { }

	// RVA: 0x57BC7C
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

	// RVA: 0x57BC94
	public void .ctor(int initialSize) { }

	// RVA: 0x57BD24
	public void Add(UInt16 value) { }

	// RVA: 0x57BEB0
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

	// RVA: 0x57BEB8
	public void .ctor(Mesh mesh) { }

	// RVA: 0x57BFB4
	public void .ctor(MeshData meshData, Mesh mesh, int submeshIndex) { }

	// RVA: 0x57C428
	private static int GetVertexCount(int[] subMeshIndices, int baseVertex) { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class MeshDataCache
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Int32,CFRenderLib.Unity.Collections.MeshData> m_meshDatas; // 0x10
	private readonly System.Collections.Generic.List<CFRenderLib.Unity.Structs.SubmeshData> m_subMeshDatas; // 0x18

	// Methods

	// RVA: 0x57C4D4
	public MeshData Get(Mesh mesh, int submeshIndex) { }

	// RVA: 0x57C704
	private MeshData Get(Mesh mesh) { }

	// RVA: 0x57C7FC
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

	// RVA: 0x577F00
	public void .ctor(Texture2D texture, TextureCompressionInfo tc) { }

	// RVA: 0x57C8DC
	private void FindMipmaps(TextureCompressionInfo tc) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class RenderableCache
{
	// Fields
	internal static CFRenderLib.Unity.Collections.DataCache<CFRenderLib.Unity.Structs.RenderableData> Roots; // 0x0

	// Methods

	// RVA: 0x574948
	public static CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> Add(IRenderable renderable) { }

	// RVA: 0x574B04
	public static void Remove(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x576AD8
	public static RenderableData GetRef(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x5758A4
	public static bool Exists(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x57CC28
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

	// RVA: 0x57CCC4
	public void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class RenderStats
{
	// Fields
	public static UInt32 indexCount; // 0x0
	public static UInt32 vertexCount; // 0x4

	// Methods

	// RVA: 0x57CE50
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

	// RVA: 0x57CE9C
	public void .ctor() { }

	// RVA: 0x57CF84
	public void .ctor(IDynamicLightingUtilityService dynamicLightingUtility, ISceneReflectionProbesUtilityService sceneReflectionProbesUtility) { }

	// RVA: 0x57D024
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

	// RVA: 0x57D0E0
	public UInt16 GetTextureIndex(Texture2D texture) { }

	// RVA: 0x57D208
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

	// RVA: 0x57D210
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

	// RVA: 0x57D630
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public int batchIndex; // 0x10

	// Methods

	// RVA: 0x57D628
	public void .ctor() { }

	// RVA: 0x57D638
	internal bool <AddMesh>b__0(BatchInfo b) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class StaticBatchInfo
{
	// Fields
	private static System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.BatchInfo> <Batches>k__BackingField; // 0x0

	// Methods

	// RVA: 0x57D218
	public static System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.BatchInfo> get_Batches() { }

	// RVA: 0x57D264
	private static void set_Batches(System.Collections.Generic.List<CFRenderLib.Unity.Collections.StaticBatchInfo.BatchInfo> value) { }

	// RVA: 0x57D2C8
	public static void Clear() { }

	// RVA: 0x57D378
	public static void AddMesh(string name, int vertexCount, string material, int lightmapIndex, MeshChannelData channels, int wantedBatchIndex, int batchIndex) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class StaticDataCache<T0>
{
	// Fields
	internal static CFRenderLib.Unity.Collections.DataCache<T> Cache; // 0x0

	// Methods

	// RVA: 0x316B894
	public static CFRenderLib.Unity.Structs.Handle<T> Add(T t) { }

	// RVA: 0x316B894
	public static T GetRef(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x316B894
	public static void Remove(CFRenderLib.Unity.Structs.Handle<T> renderable) { }

	// RVA: 0x30B71FC
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

	// RVA: 0x57D660
	public Vector3 get_DominantLightDirection() { }

	// RVA: 0x57D764
	public Color get_DominantLightColor() { }

	// RVA: 0x57D770
	public float get_HDREncodeFactor() { }

	// RVA: 0x57D778
	public SphericalHarmonicsL2 get_SH() { }

	// RVA: 0x57D780
	public int get_ProbeSize() { }

	// RVA: 0x57D83C
	public int get_Slice() { }

	// RVA: 0x57D844
	public Texture2DArray[] get_ReflectionSamples() { }

	// RVA: 0x57D948
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
private struct __StaticArrayInitTypeSize=11919
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly Int64 068459927F79051BE2A933FB2972B0AF185AFB5F1FDED6FFF258D61D5FB97084; // 0x0
	internal static readonly Int64 1ADB804EE85BAED94D5AC12322EB370A22BB71F9CA1DA2C40032C253780BD470; // 0x8
	internal static readonly __StaticArrayInitTypeSize=16 2ABD4BAF60452C683925A01754D5ABBE44CBC73682248428546AB2D512B96E65; // 0x10
	internal static readonly __StaticArrayInitTypeSize=16 4038348AF6E5B77BF25F510FD5FF230D3A611D61EF9FB6CA62313C860F128C1C; // 0x20
	internal static readonly __StaticArrayInitTypeSize=11919 5CEFBAA8EF3E5DB4A80B106C7E9FD9FB2E53E6B903865B0F2E650388CCDFA5DC; // 0x30
	internal static readonly Int64 7D0A0F0DDA8BF523E6E10685083859543EDB68FFF579376B60C8920CFA7B5DEF; // 0x2EC0
	internal static readonly __StaticArrayInitTypeSize=16 8DF28E51E6285370840F0C8FD6BC27E3EF1CA52BD070712EDA60F9274B182AFC; // 0x2EC8
	internal static readonly Int64 9655D519C47A0B433D9B4ABC6335BE754440D271D1AD594C96DC11F672EAA4A4; // 0x2ED8
	internal static readonly __StaticArrayInitTypeSize=5331 9C07B08ECB0F51B70B65FFBC91549D4BBA6F08F3A762C8867C8681F7250762FF; // 0x2EE0
	internal static readonly Int64 DCBC8A96B332D7B2B126D401D47D72C1DAF86DDD7102704C197EE0A8AC66D034; // 0x43B8
	internal static readonly __StaticArrayInitTypeSize=20 F955B65874DC572B213A30BA1E58039C6A27841C2AE5ADF62AD5ED45ADA54F6D; // 0x43C0
}


