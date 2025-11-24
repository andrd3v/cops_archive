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

	// RVA: 0x556CE8
	MonoScriptData Get() { }

	// RVA: 0x556DE8
	void .ctor() { }

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
	public const CFRenderEvent BeforeFrame = 0;
	public const CFRenderEvent AfterFrame = 1;
	public const CFRenderEvent BeforeRender = 2;
	public const CFRenderEvent AfterRender = 3;
	public const CFRenderEvent BeforeCull = 4;
	public const CFRenderEvent AfterCull = 5;
	public const CFRenderEvent BeforeGatherCommands = 6;
	public const CFRenderEvent AfterGatherCommands = 7;
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

	// RVA: 0x556DF0
	Vector3 ToUnity(Float3 v) { }

	// RVA: 0x556DF4
	Float3 FromUnity(Vector3 v) { }

	// RVA: 0x556DF8
	Plane ToUnity(Plane v) { }

	// RVA: 0x556F0C
	Plane FromUnity(Plane v) { }

	// RVA: 0x556F10
	SphericalHarmonicsL2 ToUnity(SphericalHarmonicsL2 sh) { }

	// RVA: 0x5570EC
	SphericalHarmonicsL2 FromUnity(SphericalHarmonicsL2 unitysh) { }

	// RVA: 0x5572F4
	Bounds ToUnity(BoundingBox b) { }

	// RVA: 0x55733C
	BoundingBox FromUnity(Bounds v) { }

	// RVA: 0x557384
	Float4 FromUnity(Quaternion q) { }

	// RVA: 0x5573B4
	Float4 FromUnityRGBA(Color c) { }

	// RVA: 0x5573E4
	Float3 FromUnityRGB(Color c) { }

}

// Namespace: CFRenderLib.Unity
public class GameObjectFactory 
{
	// Methods

	// RVA: 0x557418
	GameObject Create(string name) { }

	// RVA: 0x557480
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity
public interface IGameObjectFactory 
{
	// Methods

	// RVA: 0x2FE36BC
	GameObject Create(string name) { }

}

// Namespace: CFRenderLib.Unity.TextureCompression
public static class TextureCompression 
{
	// Methods

	// RVA: 0x557488
	void Clear(TextureCompressionInfo tc, RawTextureData data, AtlasClearColor clearColor) { }

	// RVA: 0x5577C0
	void CopyTexture(TextureCompressionInfo tc, RawTextureData source, RawTextureData target, int targetX, int targetY, int targetWidth, int targetHeight) { }

	// RVA: 0x557EF8
	int GetBlockStartIndex(TextureCompressionInfo tc, RawTextureData tex, int mipmap, int blockX, int blockY) { }

	// RVA: 0x55805C
	void ClearBlock(TextureCompressionInfo tc, RawTextureData data, int x, int y, int mipmap, Byte[] clearBlock) { }

	// RVA: 0x5575D0
	void ClearMipmap(TextureCompressionInfo tc, RawTextureData data, int mipmap, Byte[] clearBlock) { }

	// RVA: 0x558108
	void CopyBlock(TextureCompressionInfo tc, RawTextureData source, int sourceX, int sourceY, RawTextureData target, int targetX, int targetY, int sourceMipmap, int targetMipmap) { }

	// RVA: 0x557CD8
	void CopyMipmap(TextureCompressionInfo tc, RawTextureData source, RawTextureData target, int targetX, int targetY, int sourceMipmap, int targetMipmap) { }

	// RVA: 0x557FEC
	int MortonEncode(int x, int y) { }

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

	// RVA: 0x557504
	Byte[] GetColor(AtlasClearColor color) { }

	// RVA: 0x5581E8
	TextureCompressionInfo Get(Texture2D tex) { }

	// RVA: 0x558824
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct AreaRendererData 
{
	// Fields
	public int[] Renderers; // 0x10
}

// Namespace: CFRenderLib.Unity.Structs
public struct AtlasedMaterial 
{
	// Fields
	public Material baseMaterial; // 0x10
	public Byte atlasPackingIndex; // 0x18
	public AtlasedTexture[] textures; // 0x20
	public Material atlasMaterial; // 0x28
}

// Namespace: CFRenderLib.Unity.Structs
public struct AtlasedTexture 
{
	// Fields
	public string propertyName; // 0x10
	public UInt16 atlasIndex; // 0x18
}

// Namespace: CFRenderLib.Unity.Structs
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

	// RVA: 0x55882C
	void .ctor() { }

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

	// RVA: 0x558834
	bool get_enableLightProbes() { }

	// RVA: 0x558840
	void set_enableLightProbes(bool value) { }

	// RVA: 0x558854
	bool get_enableReflectionProbes() { }

	// RVA: 0x558860
	void set_enableReflectionProbes(bool value) { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct FloatRect 
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float width; // 0x18
	public float height; // 0x1C

	// Methods

	// RVA: 0x558880
	void .ctor(float x, float y, float w, float h) { }

	// RVA: 0x55888C
	Rect ToUnityRect() { }

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
public struct IntRect 
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public int width; // 0x18
	public int height; // 0x1C

	// Methods

	// RVA: 0x558898
	IntRect MinMax(int xMin, int yMin, int xMax, int yMax) { }

	// RVA: 0x5588B4
	void .ctor(int x, int y, int w, int h) { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct LightmapObject 
{
	// Fields
	public Transform transform; // 0x10
	public int lightmapIndex; // 0x18
	public Vector4 lightmapST; // 0x1C
}

// Namespace: CFRenderLib.Unity.Structs
public struct LightmapRect 
{
	// Fields
	public Vector4 lightmapScaleOffset; // 0x10
	public Byte lightmapIndex; // 0x20
}

// Namespace: CFRenderLib.Unity.Structs
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

	// RVA: 0x5588C0
	bool Equals(MeshChannelData m) { }

	// RVA: 0x55890C
	void .ctor(MeshData mesh) { }

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
public class Point 
{
	// Fields
	public Float3 pos; // 0x10

	// Methods

	// RVA: 0x558984
	void .ctor() { }

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

	// RVA: 0x55898C
	SceneRasterizationConfiguration get_Default() { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct SHLight 
{
	// Fields
	public Vector3 position; // 0x10
	public Color startColor; // 0x1C
	public Color endColor; // 0x2C
	public float squareRadius; // 0x3C
	public float duration; // 0x40
	public float killTime; // 0x44
}

// Namespace: CFRenderLib.Unity.Structs
public class StaticMeshInstance 
{
	// Fields
	public UInt32 lightmapRectIndex; // 0x10
	public UInt16 materialIndex; // 0x14
	public Matrix4x4 matrix; // 0x18
	public Mesh mesh; // 0x58
	public UInt16 submeshIndex; // 0x60

	// Methods

	// RVA: 0x558A24
	void .ctor() { }

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

	// RVA: 0x558A2C
	int get_vertexCount() { }

	// RVA: 0x558A34
	int get_size() { }

	// RVA: 0x558A40
	void .ctor(UInt32 capacity) { }

	// RVA: 0x558B54
	void SetAttributes(MeshChannelData channels, bool useHalfPrecision) { }

	// RVA: 0x558EE4
	void SetFloat3(VertexAttribute attribute, in Float3 value) { }

	// RVA: 0x558F5C
	void SetColor32(VertexAttribute attribute, in Color32 value) { }

	// RVA: 0x558FD4
	void SetSnormByte4(VertexAttribute attribute, in SnormByte4 value) { }

	// RVA: 0x55904C
	void SetHalf2(VertexAttribute attribute, in Half2 value) { }

	// RVA: 0x5590C4
	void SetHalf4(VertexAttribute attribute, in Half4 value) { }

	// RVA: 0x55913C
	void SetUnormHalf2(VertexAttribute attribute, in UnormHalf2 value) { }

	// RVA: 0x5591B4
	void SetUnormHalf4(VertexAttribute attribute, in UnormHalf4 value) { }

	// RVA: 0x55922C
	void SetSnormHalf4(VertexAttribute attribute, in SnormHalf4 value) { }

	// RVA: 0x5592A4
	void SubmitVertex() { }

}

// Namespace: CFRenderLib.Unity.Structs
public struct TextureAtlasPacking 
{
	// Fields
	public TextureAtlasRect[] rects; // 0x10
	public int atlasWidth; // 0x18
	public int atlasHeight; // 0x1C
}

// Namespace: CFRenderLib.Unity.Structs
public struct TextureAtlasRect 
{
	// Fields
	public const float AtlasUVPaddingPixels = 1073741824;
	public IntRect pixelRect; // 0x10
	public FloatRect uvRect; // 0x20
	public bool rotated; // 0x30

	// Methods

	// RVA: 0x559334
	Vector2 AdjustUV(Vector2 uv) { }

}

// Namespace: CFRenderLib.Unity.Services
public interface ISceneReflectionProbesUtilityService 
{
	// Methods

	// RVA: 0x2FE4234
	void ApplyOffset(Byte index) { }

	// RVA: -1
	void ApplyOffset(Byte index, CommandBuffer commandBuffer) { }

}

// Namespace: CFRenderLib.Unity.Services
public class SceneReflectionProbesUtility 
{
	// Methods

	// RVA: 0x559408
	void ApplyOffset(Byte index) { }

	// RVA: 0x559478
	void ApplyOffset(Byte index, CommandBuffer commandBuffer) { }

	// RVA: 0x559508
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal class ApplicationWrapper 
{
	// Methods

	// RVA: 0x559510
	string get_DataPath() { }

	// RVA: 0x559580
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IApplicationService 
{
	// Methods

	// RVA: 0x2FE360C
	string get_DataPath() { }

}

// Namespace: CFRenderLib.Unity.Services
internal class DebugWrapper 
{
	// Methods

	// RVA: 0x559588
	void LogError(string message) { }

	// RVA: 0x559610
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IDebugService 
{
	// Methods

	// RVA: 0x2FE4574
	void LogError(string message) { }

}

// Namespace: CFRenderLib.Unity.Services
public class DynamicLightingUtilityWrapper 
{
	// Methods

	// RVA: 0x559618
	void SetReflectionMaps(in RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x559770
	void SetReflectionMaps(in Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

	// RVA: 0x559A54
	void .ctor() { }

	// RVA: 0x559A5C
	void CFRenderLib.Unity.Services.IDynamicLightingUtilityService.SetReflectionMaps(in RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x559B08
	void CFRenderLib.Unity.Services.IDynamicLightingUtilityService.SetReflectionMaps(in Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

}

// Namespace: CFRenderLib.Unity.Services
public interface IDynamicLightingUtilityService 
{
	// Methods

	// RVA: 0x2FE47D4
	void SetReflectionMaps(in RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x2FE47D4
	void SetReflectionMaps(in Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class GLWrapper 
{
	// Methods

	// RVA: 0x559B14
	void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x559B24
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IGLService 
{
	// Methods

	// RVA: 0x309AF8C
	void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

}

// Namespace: CFRenderLib.Unity.Services
public class GraphicsWrapper 
{
	// Methods

	// RVA: 0x559B2C
	void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x559BA8
	void Blit(Texture source, Material sourceMaterial) { }

	// RVA: 0x559C14
	void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

	// RVA: 0x559CA8
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
public interface IGraphicsService 
{
	// Methods

	// RVA: 0x2FE49A8
	void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x2FE47D4
	void Blit(Texture source, Material sourceMaterial) { }

	// RVA: 0x309AF8C
	void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class GUILayoutWrapper 
{
	// Methods

	// RVA: 0x559CB0
	bool Button(string label, GUILayoutOption[] options) { }

	// RVA: 0x559CC0
	void FlexibleSpace() { }

	// RVA: 0x559CC8
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IGUILayoutService 
{
	// Methods

	// RVA: -1
	bool Button(string label, GUILayoutOption[] options) { }

	// RVA: 0x2FE41A8
	void FlexibleSpace() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IMathfService 
{
	// Methods

	// RVA: 0x2FE3088
	bool IsPowerOfTwo(int value) { }

	// RVA: -1
	int ClosestPowerOfTwo(int value) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class MathfWrapper 
{
	// Methods

	// RVA: 0x559CD0
	int ClosestPowerOfTwo(int value) { }

	// RVA: 0x559CDC
	bool IsPowerOfTwo(int value) { }

	// RVA: 0x559CE8
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IRenderTextureService 
{
	// Methods

	// RVA: 0x2FE360C
	RenderTexture get_Active() { }

	// RVA: 0x2FE4574
	void set_Active(RenderTexture value) { }

	// RVA: -1
	RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x2FE4574
	void ReleaseTemporary(RenderTexture renderTexture) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class RenderTextureWrapper 
{
	// Methods

	// RVA: 0x559CF0
	RenderTexture get_Active() { }

	// RVA: 0x559CF8
	void set_Active(RenderTexture value) { }

	// RVA: 0x559D04
	RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x559D1C
	void ReleaseTemporary(RenderTexture renderTexture) { }

	// RVA: 0x559D28
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface ISceneManagerService 
{
	// Methods

	// RVA: 0x309AF8C
	Scene GetActiveScene() { }

}

// Namespace: CFRenderLib.Unity.Services
internal class SceneManagerWrapper 
{
	// Methods

	// RVA: 0x559D30
	Scene GetActiveScene() { }

	// RVA: 0x559DA0
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Services
internal interface IShaderService 
{
	// Methods

	// RVA: 0x2FE4574
	void DisableKeyword(string keyword) { }

	// RVA: 0x2FE4574
	void EnableKeyword(string keyword) { }

}

// Namespace: CFRenderLib.Unity.Services
internal class ShaderWrapper 
{
	// Methods

	// RVA: 0x559DA8
	void DisableKeyword(string keyword) { }

	// RVA: 0x559DB4
	void EnableKeyword(string keyword) { }

	// RVA: 0x559DC0
	void .ctor() { }

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

	// RVA: 0x559DC8
	void .ctor() { }

	// RVA: 0x55A1F0
	Material get_NullMaterial() { }

	// RVA: 0x55A33C
	void CFRenderLib.Unity.Interfaces.IRenderer.Draw(ref DrawCall drawCall) { }

	// RVA: 0x55A6F4
	void CFRenderLib.Unity.Interfaces.IRenderer.Render(RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer) { }

	// RVA: 0x55AA14
	void CFRenderLib.Unity.Interfaces.IRenderer.BeginRecordDrawCalls() { }

	// RVA: 0x55AA70
	bool CFRenderLib.Unity.Interfaces.IRenderer.EndRecordDrawCalls(out CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Unity.Structs.DrawCall>& recordedDrawCalls) { }

	// RVA: 0x55AABC
	void CleanUp() { }

	// RVA: 0x55A70C
	void Render(StaticBatcher staticBatcher, RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer) { }

	// RVA: 0x55A4FC
	UInt16 GetRenderQueueIndex(Material material) { }

	// RVA: 0x55B0FC
	void SortInstancesToQueueAndBatches(StaticBatcher staticBatcher, int[] instances, int instanceCount) { }

	// RVA: 0x55B6BC
	void UpdateIndexRanges(StaticBatch batch) { }

	// RVA: 0x55B90C
	void UpdateIndexBuffer(StaticBatch batch) { }

	// RVA: 0x55AAC0
	void ClearDrawCalls() { }

	// RVA: 0x55AB68
	void SortDynamicToQueue(RenderableData[] renderableDatas, int renderableCount, CullingResults cullingResults) { }

	// RVA: 0x55B66C
	void ExecuteRenderPass(RenderPass pass, StaticBatcher staticBatcher) { }

	// RVA: 0x55C24C
	void RenderStatic(RenderPass pass, StaticBatcher staticBatcher) { }

	// RVA: 0x55BF3C
	void RenderDynamic(RenderPass pass) { }

	// RVA: 0x55D234
	void RenderDrawCall(ref DrawCall dc, RenderTargetIdentifier[] lightmapTextures, int lightmapCount) { }

	// RVA: 0x55E0F0
	void .cctor() { }

	// RVA: 0x55E1E4
	int <GetRenderQueueIndex>b__21_0(int q1, int q2) { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public class CFRenderPipeline 
{
	// Fields
	private static readonly CFRenderLib.Core.Collections.GrowArray<System.Action<UnityEngine.Camera>>[] RenderEvents; // 0x0
	private static readonly CFRenderLib.Core.Collections.GrowArray<UnityEngine.Rendering.CommandBuffer>[] CustomCommandBuffers; // 0x8
	private static System.Action<System.Exception> CaughtExceptionCallback; // 0x10
	private static readonly UInt32 UILayerMask; // 0x18
	private static RenderTexture m_currentFrameOverrideTarget; // 0x20
	private readonly CommandBuffer m_commandBuffer; // 0x18
	private Culling m_culling; // 0x20
	private CullingResults m_cullingResults; // 0x28
	private DynamicCullingData m_cullingDynamic; // 0x30
	private CFRenderer m_renderer; // 0x38
	private StaticBatcher m_staticBatcher; // 0x40
	private Scene m_currentScene; // 0x48
	private StaticSceneData m_sceneData; // 0x50
	private OcclusionComponent m_occlusionComponent; // 0x58
	private static System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> <ActRenderPrefab>k__BackingField; // 0x28
	private static System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> <ActRenderPreview>k__BackingField; // 0x30
	private static System.Action<UnityEngine.Camera> <ActRenderUI>k__BackingField; // 0x38

	// Methods

	// RVA: 0x55E23C
	System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> get_ActRenderPrefab() { }

	// RVA: 0x55E2B8
	void set_ActRenderPrefab(System.Func<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera,System.Boolean> value) { }

	// RVA: 0x55E324
	System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> get_ActRenderPreview() { }

	// RVA: 0x55E3A0
	void set_ActRenderPreview(System.Action<UnityEngine.Rendering.ScriptableRenderContext,UnityEngine.Rendering.CommandBuffer,UnityEngine.Camera> value) { }

	// RVA: 0x55E40C
	System.Action<UnityEngine.Camera> get_ActRenderUI() { }

	// RVA: 0x55E488
	void set_ActRenderUI(System.Action<UnityEngine.Camera> value) { }

	// RVA: 0x55E4F4
	void Render(ScriptableRenderContext renderContext, Camera[] cameras) { }

	// RVA: 0x55EE2C
	void Dispose(bool disposing) { }

	// RVA: 0x55E804
	void Render(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x55F098
	void GatherCommands(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x55F368
	void RenderUI(ref ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x55F7B4
	void SetOverrideRenderTarget(RenderTexture renderTexture) { }

	// RVA: 0x55F820
	void RegisterCommandBuffer(CFCommandBufferEvent commandBufferEvent, CommandBuffer commandBuffer) { }

	// RVA: 0x55FA68
	void UnRegisterCommandBuffer(CFCommandBufferEvent commandBufferEvent, CommandBuffer commandBuffer) { }

	// RVA: 0x55FB78
	void RegisterRenderEvent(CFRenderEvent renderEvent, System.Action<UnityEngine.Camera> action) { }

	// RVA: 0x55FDC0
	void UnRegisterRenderEvent(CFRenderEvent renderEvent, System.Action<UnityEngine.Camera> action) { }

	// RVA: 0x55FED0
	void SetCaughtExceptionCallback(System.Action<System.Exception> action) { }

	// RVA: 0x557E34
	void CaughtException(Exception ex) { }

	// RVA: 0x55F5F0
	void RenderCustom(Camera camera, bool disableCulling) { }

	// RVA: 0x55FF3C
	void UpdateCulling(Camera camera, bool disableCulling) { }

	// RVA: 0x560190
	void UpdateDynamicObjectBounds() { }

	// RVA: 0x55E72C
	void CheckSceneInitialization() { }

	// RVA: 0x5606B4
	void InitializeScene() { }

	// RVA: 0x560AD8
	void InitializeCulling() { }

	// RVA: 0x55EE30
	void CleanUpSceneData() { }

	// RVA: 0x55E624
	void InvokeRenderEvent(CFRenderEvent renderEvent, Camera camera) { }

	// RVA: 0x55EF68
	void InvokeCommandBuffers(CFCommandBufferEvent commandBufferEvent, ScriptableRenderContext context) { }

	// RVA: 0x560E58
	void .ctor() { }

	// RVA: 0x560EFC
	void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public class CFRenderPipelineAsset 
{
	// Methods

	// RVA: 0x5610BC
	RenderPipeline CreatePipeline() { }

	// RVA: 0x561110
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class DynamicLightingUtility 
{
	// Methods

	// RVA: 0x561118
	void GetFullDynamicLight(Vector3 position, ref SphericalHarmonicsL2 cachedProbe, ref DrawCall drawCall, ref MaterialPropertyBlock propertyBlock) { }

	// RVA: 0x5614F4
	Color ShadeSH9(in SphericalHarmonicsL2 sh, in Vector3 normal) { }

	// RVA: 0x561DA8
	void GetDominantSHLight(in SphericalHarmonicsL2 sh, float upBias, out Vector3 direction, out Color color) { }

	// RVA: 0x562170
	Color GetAmbientSHLight(in SphericalHarmonicsL2 sh) { }

	// RVA: 0x56227C
	Color GetReflectionFallBackColor(in SphericalHarmonicsL2 sh) { }

	// RVA: 0x5623D0
	void SetEnviromentImage(CFEnvironmentImage image) { }

	// RVA: 0x5631DC
	void SetEnviromentImage(CFEnvironmentImage image, CommandBuffer commandBuffer) { }

	// RVA: 0x563558
	void SetEnviromentImage(CFEnvironmentImage image, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x564400
	void SetEnviromentImage(CFEnvironmentImage image, Material material) { }

	// RVA: 0x5652A8
	void GetSHCoefficients(in Vector3 position, out SphericalHarmonicsL2 probe) { }

	// RVA: 0x561290
	void GetSHCoefficients(in Vector3 position, ref SphericalHarmonicsL2 probe, float accumulation) { }

	// RVA: 0x565874
	void SetSHCoefficients(in Vector3 position) { }

	// RVA: 0x56592C
	void SetSHCoefficients(in Vector3 position, CommandBuffer commandBuffer) { }

	// RVA: 0x5659EC
	void SetSHCoefficients(in Vector3 position, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x565AAC
	void SetSHCoefficients(in Vector3 position, Material material) { }

	// RVA: 0x56263C
	void SetSHCoefficients(in SphericalHarmonicsL2 sh) { }

	// RVA: 0x55D6BC
	void SetSHCoefficients(in SphericalHarmonicsL2 sh, CommandBuffer commandBuffer) { }

	// RVA: 0x5637EC
	void SetSHCoefficients(in SphericalHarmonicsL2 sh, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x564694
	void SetSHCoefficients(in SphericalHarmonicsL2 sh, Material material) { }

	// RVA: 0x562F60
	void SetReflectionMaps(in Texture[] atlases) { }

	// RVA: 0x565B6C
	void SetReflectionMaps(in Texture2DArray atlas, CommandBuffer commandBuffer) { }

	// RVA: 0x55977C
	void SetReflectionMaps(in Texture2DArray[] atlases, CommandBuffer commandBuffer) { }

	// RVA: 0x564134
	void SetReflectionMaps(in Texture[] atlases, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x564FDC
	void SetReflectionMaps(in Texture[] atlases, Material material) { }

	// RVA: 0x5596C4
	void SetReflectionMaps(in RenderTexture atlas, MaterialPropertyBlock materialPropertyBlock) { }

	// RVA: 0x565C94
	void SetDynamicLight(in SphericalHarmonicsL2 sh, in float upBias) { }

	// RVA: 0x565E58
	void SetDynamicLight(in SphericalHarmonicsL2 sh, in float upBias, CommandBuffer commandBuffer) { }

	// RVA: 0x561320
	void SetDynamicLight(in SphericalHarmonicsL2 sh, in float upBias, MaterialPropertyBlock materialProbertyBlock) { }

	// RVA: 0x56602C
	void SetDynamicLight(in SphericalHarmonicsL2 sh, in float upBias, Material material) { }

	// RVA: 0x56311C
	void SetDynamicLight(in Vector3 direction, in Color color, in Color reflectionFallBackColor) { }

	// RVA: 0x563470
	void SetDynamicLight(in Vector3 direction, in Color color, in Color reflectionFallBackColor, CommandBuffer commandBuffer) { }

	// RVA: 0x564318
	void SetDynamicLight(in Vector3 direction, in Color color, in Color reflectionFallBackColor, MaterialPropertyBlock materialProbertyBlock) { }

	// RVA: 0x5651C0
	void SetDynamicLight(in Vector3 direction, in Color color, in Color reflectionFallBackColor, Material material) { }

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

	// RVA: 0x566200
	bool get_HasValidData() { }

	// RVA: 0x566284
	void TryLoadData(string data) { }

	// RVA: 0x5665C4
	void FreeData() { }

	// RVA: 0x566670
	void SampleGIInterpolation(Vector3 position, Int32* indices, Single* weights) { }

	// RVA: 0x5672B0
	void SampleGI(Vector3 position, in Vector3 normal, out Color color) { }

	// RVA: 0x565334
	void SampleGI(in Vector3 position, out SphericalHarmonicsL2 sh) { }

	// RVA: 0x567774
	void SampleGI(Vector3 position, ref SphericalHarmonicsL2 sh) { }

	// RVA: 0x5655D4
	void SampleGI(Vector3 position, ref SphericalHarmonicsL2 sh, float accumulation) { }

	// RVA: 0x567C5C
	void SampleGISingle(Vector3 position, ref SphericalHarmonicsL2 sh) { }

	// RVA: 0x567548
	void InterpolateSH9(Int32* indices, Single* weights, ref SphericalHarmonicsL2 sh) { }

	// RVA: 0x567A00
	void InterpolateSH9(Int32* indices, Single* weights, float accumulation, ref SphericalHarmonicsL2 sh) { }

	// RVA: 0x566794
	bool TryGatherInterpolators(Single* position, Int32* indices, Single* weights) { }

	// RVA: 0x567FB4
	bool TryFindSpanInCoord(Int32* coord, Int32* indices) { }

	// RVA: 0x5674D8
	void CopyDefaultProbe(ref SphericalHarmonicsL2 sh) { }

	// RVA: 0x568190
	void .cctor() { }

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

	// RVA: 0x55CF78
	void DrawIndexRanges(CommandBuffer cb, Mesh mesh, Matrix4x4 matrix, Material material, IndexRange[] indexes, UInt32 count, IntPtr nativeIndexBuffer) { }

	// RVA: 0x55EC94
	void Reset() { }

	// RVA: 0x55BCA8
	void SetIndices(CommandBuffer cb, IntPtr nativeIndexBufferPtr, UInt16[] indices, UInt32 count) { }

	// RVA: 0x56878C
	void .cctor() { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class ProjectionContextUtility 
{
	// Methods

	// RVA: 0x568838
	void SetupViewProjectionMatrices(CommandBuffer commandBuffer, in Matrix4x4 view, in Matrix4x4 projection) { }

	// RVA: 0x568910
	void SetupPerspective(CommandBuffer commandBuffer, in Vector3 position, in Quaternion rotation, float fieldOfView, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x568BF4
	void SetupOrthographic(CommandBuffer commandBuffer, in Vector3 position, in Quaternion rotation, float sizeX, float sizeY, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x568B60
	Matrix4x4 GetGPUPerspectiveProjectionMatrix(float fieldOfView, float near, float far, int width, int height, bool isRenderTexture) { }

	// RVA: 0x568EC4
	Matrix4x4 GetGPUPerspectiveProjectionMatrix(float fieldOfView, float near, float far, float aspect, bool isRenderTexture) { }

	// RVA: 0x568E3C
	Matrix4x4 GetGPUOrthographicProjectionMatrix(float near, float far, float width, float height, bool isRenderTexture) { }

	// RVA: 0x568F3C
	void ContentSizeFitPerspective(Camera camera, in BoundingSphere bounds, in Quaternion rotation) { }

	// RVA: 0x5690B4
	void ContentSizeFitPerspective(in BoundingSphere bounds, in Quaternion rotation, float fieldOfView, out float far, out Vector3 position) { }

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

	// RVA: 0x55A094
	void .ctor() { }

	// RVA: 0x5691BC
	void .ctor(ISceneReflectionProbesUtilityService sceneReflectionProbesUtility) { }

	// RVA: 0x55CB38
	void SetLightmapEnabled(bool enabled) { }

	// RVA: 0x55CEA8
	void SetLightmapIndex(Byte lightmapIndex, RenderTargetIdentifier[] lightmaps) { }

	// RVA: 0x55CBD0
	void SetLightmapST(Vector4 lightmapST) { }

	// RVA: 0x55CD38
	void SetPositionEncodeFactor(float offset, float value) { }

	// RVA: 0x55CE08
	void SetHDREncodeFactor(float factor) { }

	// RVA: 0x55CAA0
	void SetLightProbeEnabled(bool enabled) { }

	// RVA: 0x5691F8
	void SetReflectionProbeStatic() { }

	// RVA: 0x55E004
	void SetReflectionProbe(Byte reflectionProbeIndex) { }

	// RVA: 0x55B5D4
	void SetReflectionProbeCount(Byte count) { }

	// RVA: 0x55CA08
	void SetStatic(bool enabled) { }

	// RVA: 0x55CC90
	void SetInvertCulling(bool invert) { }

	// RVA: 0x55B3EC
	void Reset() { }

	// RVA: 0x55A114
	void SetLightmapDecodeFormat(TextureFormat format) { }

}

// Namespace: CFRenderLib.Unity.RenderPipeline
public static class ShaderConstants 
{
	// Fields
	public static readonly float[] OEMRoughnessLevels; // 0x0
	public const string LightmapsEnabled = 5730922496;
	public const string LightProbesEnabled = 5730942912;
	public const string ReflectionsEnabled = 5730942848;
	public const string Static = 5731171856;
	public const string MetaAlbedo = 5730942784;
	public const string MetaEmission = 5730942720;
	public static readonly int _WorldSpaceCameraPos; // 0x8
	public static readonly int _ZBufferParams; // 0xC
	public static readonly int _ScreenParams; // 0x10
	public static readonly int unity_OrthoParams; // 0x14
	public static readonly int _CF_DynamicLightDirection; // 0x18
	public static readonly int _CF_DynamicLightColor; // 0x1C
	public static readonly int _CF_ReflectionFallbackColor; // 0x20
	public static readonly int _CFLightmap; // 0x24
	public static readonly int _CFLightmapST; // 0x28
	public static readonly int _CF_EnvProbeBlend; // 0x2C
	public static readonly int _CF_EnvSlice; // 0x30
	public static readonly int _CF_PrevEnvSlice; // 0x34
	public static readonly int _CF_BlendSourceScaleOffset; // 0x38
	public static readonly int _CF_BlendDestinationScaleOffset; // 0x3C
	public static readonly int _CF_PosEncodeFactor; // 0x40
	public static readonly int _CF_HDREncodeFactor; // 0x44
	public static readonly int _CF_Env0; // 0x48
	public static readonly int _CF_Env1; // 0x4C
	public static readonly int _CF_Env2; // 0x50
	public static readonly int _CF_Env3; // 0x54
	public static readonly int _CF_Env4; // 0x58
	public static readonly int[] LightProbeSHA; // 0x60
	public static readonly int[] LightProbeSHB; // 0x68
	public static readonly int LightProbeSHC; // 0x70

	// Methods

	// RVA: 0x5692AC
	void .cctor() { }

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

	// RVA: 0x5698B8
	BatchedMeshInstance[] get_BatchedMeshes() { }

	// RVA: 0x5698C0
	void set_BatchedMeshes(BatchedMeshInstance[] value) { }

	// RVA: 0x5698C8
	StaticBatch[] get_Batches() { }

	// RVA: 0x5698D0
	void set_Batches(StaticBatch[] value) { }

	// RVA: 0x5698D8
	bool get_UsesHalfPrecision() { }

	// RVA: 0x55CD04
	float get_PositionEncodeRange() { }

	// RVA: 0x55CDE8
	float get_HDREncodeFactor() { }

	// RVA: 0x55CCD4
	float get_PositionEncodeOffset() { }

	// RVA: 0x560D6C
	void CleanUp() { }

	// RVA: 0x560A4C
	void Initialize(StaticSceneData sceneData, OcclusionComponent occlusion) { }

	// RVA: 0x569FA4
	void CreateBatch(int batchIndex, StaticBatch batch, System.Collections.Generic.List<System.Int32> instances, TemporaryMeshData temporary, bool useHalfPrecision, MeshDataCache meshCache) { }

	// RVA: 0x5698F8
	void CreateBatches() { }

	// RVA: 0x560A44
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interop
internal class DrawIndexRangesDataNative 
{
	// Fields
	public IntPtr indexes; // 0x10
	public UInt32 count; // 0x18
	public IntPtr nativeIndexBuffer; // 0x1C

	// Methods

	// RVA: 0x56B234
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interop
internal class DrawIndexRangesHandle 
{
	// Fields
	private readonly DrawIndexRangesDataNative m_nativeData; // 0x10
	private GCHandle indexesHandle; // 0x18
	private GCHandle nativeDataHandle; // 0x20

	// Methods

	// RVA: 0x56865C
	void Free() { }

	// RVA: 0x5685A4
	IntPtr GetPtr(IndexRange[] indexes, UInt32 count, IntPtr nativeIndexBuffer) { }

	// RVA: 0x56852C
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interop
internal class SetIndicesDataNative 
{
	// Fields
	public IntPtr indexBuffer; // 0x10
	public IntPtr indices; // 0x18
	public UInt32 indexCount; // 0x20

	// Methods

	// RVA: 0x56B23C
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interop
internal class SetIndicesHandle 
{
	// Fields
	private readonly SetIndicesDataNative m_nativeData; // 0x10
	private GCHandle indicesHandle; // 0x18
	private GCHandle nativeDataHandle; // 0x20

	// Methods

	// RVA: 0x56862C
	void Free() { }

	// RVA: 0x568704
	IntPtr GetPtr(IntPtr nativeIndexBufferPtr, UInt16[] indices, UInt32 count) { }

	// RVA: 0x56868C
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Interfaces
public interface ILightmapIndexable 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_HasCFLightMapRect() { }

	// RVA: 0x2FE4234
	void set_HasCFLightMapRect(bool value) { }

	// RVA: 0x309AF8C
	LightmapRect get_CFLightmapRect() { }

	// RVA: 0x309AF8C
	void set_CFLightmapRect(LightmapRect value) { }

}

// Namespace: CFRenderLib.Unity.Interfaces
public interface IRenderable 
{
	// Methods

	// RVA: 0x2FE4574
	void PreCull(ref RenderableData data) { }

	// RVA: 0x2FE47D4
	void Render(IRenderer renderer, ref RenderableData data) { }

	// RVA: 0x2FE4574
	void BecameVisible(ref RenderableData data) { }

	// RVA: 0x2FE4574
	void BecameInvisible(ref RenderableData data) { }

}

// Namespace: CFRenderLib.Unity.Interfaces
public interface IRenderer 
{
	// Methods

	// RVA: 0x2FE4574
	void Draw(ref DrawCall drawCall) { }

	// RVA: -1
	void Render(RenderableData[] renderables, int renderableCount, CullingResults cullingResults, CommandBuffer commandBuffer) { }

	// RVA: 0x2FE41A8
	void BeginRecordDrawCalls() { }

	// RVA: 0x2FE3174
	bool EndRecordDrawCalls(out CFRenderLib.Core.Collections.GrowArray<CFRenderLib.Unity.Structs.DrawCall>& recordedDrawCalls) { }

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

	// RVA: 0x560D60
	void CleanUp() { }

	// RVA: 0x560D1C
	void Init(OcclusionData occlusionData, StaticSceneData sceneData) { }

	// RVA: 0x560414
	void Update(Camera camera, DynamicCullingData dynamicData, CullingResults results, bool disableCulling) { }

	// RVA: 0x2FE41A8
	void CleanUpCulling() { }

	// RVA: 0x2FE49A8
	void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x2FE47D4
	void CullStatic(Camera camera, CullingResults results) { }

	// RVA: 0x2FE41A8
	void InitCulling() { }

	// RVA: 0x56B518
	void SetAllDynamicVisible(DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x56B444
	void SetAllStaticVisible(CullingResults results) { }

	// RVA: 0x56B244
	void UpdateFrustum(Camera camera, CullingResults results) { }

	// RVA: 0x56B578
	void .ctor() { }

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

	// RVA: 0x56B5E8
	void CleanUpCulling() { }

	// RVA: 0x56B5EC
	void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x56B664
	void CullStatic(Camera camera, CullingResults results) { }

	// RVA: 0x56C000
	void InitCulling() { }

	// RVA: 0x56BA48
	void UpdateOcclusionRecursive(Float3 origin, int clipStackDepth, int areaIndex, BitVector256 visitedAreas, CullingResults results) { }

	// RVA: 0x56C004
	void .ctor() { }

	// RVA: 0x56C0B8
	void .cctor() { }

}

// Namespace: CFRenderLib.Unity.Culling
internal class CullingNative 
{
	// Fields
	private int m_areaIndex; // 0x68
	private IntPtr m_nativeScene; // 0x70

	// Methods

	// RVA: 0x56C150
	void CleanUpCulling() { }

	// RVA: 0x56C1D4
	void CullDynamic(Camera camera, DynamicCullingData dynamicData, CullingResults results) { }

	// RVA: 0x56C3E8
	void CullStatic(Camera camera, CullingResults results) { }

	// RVA: 0x56C524
	void InitCulling() { }

	// RVA: 0x56C568
	IntPtr LoadScene(OcclusionData occlusionData, StaticSceneData sceneData) { }

	// RVA: 0x560CAC
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Culling.Components
public class OcclusionComponent 
{
	// Fields
	public OcclusionData occlusionData; // 0x20

	// Methods

	// RVA: 0x56C990
	void .ctor() { }

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

	// RVA: 0x56C998
	void OnEnable() { }

	// RVA: 0x56CA74
	void OnDisable() { }

	// RVA: 0x56CB04
	void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(ref RenderableData data) { }

	// RVA: 0x56CCC4
	void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, ref RenderableData data) { }

	// RVA: 0x56D05C
	void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(ref RenderableData data) { }

	// RVA: 0x56D060
	void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(ref RenderableData data) { }

	// RVA: 0x56D064
	void OnDrawGizmos() { }

	// RVA: 0x56D1E0
	void OnDrawGizmosSelected() { }

	// RVA: 0x56D448
	void ConvertToStaticMesh() { }

	// RVA: 0x56D518
	void .ctor() { }

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

	// RVA: 0x56D594
	void OnEnable() { }

	// RVA: 0x56D60C
	void OnDisable() { }

	// RVA: 0x56D69C
	void Update() { }

	// RVA: 0x56D778
	void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(ref RenderableData data) { }

	// RVA: 0x56D7B0
	void UpdateBounds() { }

	// RVA: 0x56D990
	void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, ref RenderableData data) { }

	// RVA: 0x56DC5C
	void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(ref RenderableData data) { }

	// RVA: 0x56DC60
	void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(ref RenderableData data) { }

	// RVA: 0x56DC64
	void OnDrawGizmos() { }

	// RVA: 0x56DE64
	void OnDrawGizmosSelected() { }

	// RVA: 0x56DF34
	void OnValidate() { }

	// RVA: 0x56DD68
	void CheckMesh() { }

	// RVA: 0x56DF44
	void ConvertToMeshRenderer() { }

	// RVA: 0x56E014
	void .ctor() { }

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

	// RVA: 0x56E028
	void OnEnable() { }

	// RVA: 0x56E1D0
	void OnDisable() { }

	// RVA: 0x56E2A0
	void OnDestroy() { }

	// RVA: 0x56E3E8
	void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(ref RenderableData data) { }

	// RVA: 0x56E738
	void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, ref RenderableData data) { }

	// RVA: 0x56EB24
	void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(ref RenderableData data) { }

	// RVA: 0x56EC90
	void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(ref RenderableData data) { }

	// RVA: 0x56EC98
	void OnDrawGizmosSelected() { }

	// RVA: 0x56EB2C
	void SetCullingMode(ParticleSystemCullingMode mode) { }

	// RVA: 0x56E09C
	void FindParticleSystems() { }

	// RVA: 0x56F06C
	void .ctor() { }

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

	// RVA: 0x56F144
	bool get_IsVisible() { }

	// RVA: 0x56F430
	bool get_HasCFLightMapRect() { }

	// RVA: 0x56F438
	void set_HasCFLightMapRect(bool value) { }

	// RVA: 0x56F440
	LightmapRect get_CFLightmapRect() { }

	// RVA: 0x56F454
	void set_CFLightmapRect(LightmapRect value) { }

	// RVA: 0x56F468
	void CFRenderLib.Unity.Interfaces.IRenderable.BecameInvisible(ref RenderableData data) { }

	// RVA: 0x56F5D4
	void CFRenderLib.Unity.Interfaces.IRenderable.BecameVisible(ref RenderableData data) { }

	// RVA: 0x56F750
	void CFRenderLib.Unity.Interfaces.IRenderable.PreCull(ref RenderableData data) { }

	// RVA: 0x56F910
	void CFRenderLib.Unity.Interfaces.IRenderable.Render(IRenderer renderer, ref RenderableData data) { }

	// RVA: 0x56FCE8
	void OnEnable() { }

	// RVA: 0x56FF24
	void OnDisable() { }

	// RVA: 0x57016C
	void OnDestroy() { }

	// RVA: 0x56F77C
	void UpdateBounds() { }

	// RVA: 0x570378
	void .ctor() { }

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

	// RVA: 0x570448
	Texture2D CreateAtlas(Texture2D[] sourceTextures, TextureAtlasPacking packing, AtlasParameters parameters) { }

	// RVA: 0x570890
	int FindMipmapCount(int blockWidth, TextureAtlasPacking packing) { }

	// RVA: 0x5709B0
	void PackAtlas() { }

	// RVA: 0x570C28
	void Start() { }

	// RVA: 0x570C5C
	void .ctor() { }

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

	// RVA: 0x570C64
	void Update() { }

	// RVA: 0x57114C
	void OnDrawGizmos() { }

	// RVA: 0x571064
	Vector3Int WorldToVoxelSpace(Vector3 world) { }

	// RVA: 0x571684
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
internal class PreviewRenderable 
{
	// Fields
	public GameObject original; // 0x20

	// Methods

	// RVA: 0x57168C
	void .ctor() { }

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

	// RVA: 0x571694
	Color get_GlobalTint() { }

	// RVA: 0x5716A0
	Vector3 get_CCMin() { }

	// RVA: 0x5716AC
	Vector3 get_CCMax() { }

	// RVA: 0x5716B8
	SceneGraphicsParameters get_Instance() { }

	// RVA: 0x571704
	void set_Instance(SceneGraphicsParameters value) { }

	// RVA: 0x571768
	void OnEnable() { }

	// RVA: 0x5718AC
	void OnValidate() { }

	// RVA: 0x5717CC
	void Apply() { }

	// RVA: 0x5718B0
	void Disable() { }

	// RVA: 0x571990
	void .ctor() { }

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

	// RVA: 0x571A38
	RenderTargetIdentifier[] get_LightmapRenderTargetIdentifiers() { }

	// RVA: 0x571A40
	void set_LightmapRenderTargetIdentifiers(RenderTargetIdentifier[] value) { }

	// RVA: 0x571A48
	SceneLightmapData get_Instance() { }

	// RVA: 0x571A94
	void set_Instance(SceneLightmapData value) { }

	// RVA: 0x571AF8
	void Add(Transform t, int lightmapIndex, Vector4 lightmapST) { }

	// RVA: 0x571BE8
	void Apply() { }

	// RVA: 0x571F6C
	bool TryGet(Transform t, out LightmapObject obj) { }

	// RVA: 0x572068
	void OnEnable() { }

	// RVA: 0x5720CC
	void OnDestroy() { }

	// RVA: 0x571E60
	void CreateRenderTargets() { }

	// RVA: 0x57220C
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public sealed class SceneRasterizationConfigurationHolder 
{
	// Fields
	private SceneRasterizationConfiguration m_bakeConfig; // 0x20
	private static SceneRasterizationConfigurationHolder <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x572214
	SceneRasterizationConfigurationHolder get_Instance() { }

	// RVA: 0x572260
	void set_Instance(SceneRasterizationConfigurationHolder value) { }

	// RVA: 0x5722C4
	SceneRasterizationConfiguration get_BakeConfig() { }

	// RVA: 0x5722E8
	void OnEnable() { }

	// RVA: 0x572344
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Components
public class StaticSceneData 
{
	// Fields
	private const float BoundsExpand = 1056964608;
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

	// RVA: 0x5723A8
	void SortInstances() { }

	// RVA: 0x572450
	void AddRenderersToAreas(OcclusionData occlusionData) { }

	// RVA: 0x5726DC
	bool AddRendererToAreas(OcclusionData occlusionData, int rendererIndex, System.Collections.Generic.List<System.Int32>[] areaRenderers) { }

	// RVA: 0x57287C
	void CalculateRendererBounds() { }

	// RVA: 0x572BCC
	void CreateAtlasedMaterials() { }

	// RVA: 0x5730F8
	void DestroyAtlasedMaterials() { }

	// RVA: 0x5732D8
	Material GetMaterial(UInt16 materialIndex) { }

	// RVA: 0x573344
	int GetReflectionProbeIndex(OcclusionData occlusionData, int instanceIndex) { }

	// RVA: 0x57348C
	void .ctor() { }

	// RVA: 0x5734A0
	int <SortInstances>b__12_0(StaticMeshInstance r1, StaticMeshInstance r2) { }

}

// Namespace: CFRenderLib.Unity.Components
public class UnityLightProbesHolder 
{
	// Fields
	public LightProbes lightProbes; // 0x20
	public LightProbeGroup lightProbeGroup; // 0x28
	private static UnityLightProbesHolder <Instance>k__BackingField; // 0x0

	// Methods

	// RVA: 0x5737A0
	UnityLightProbesHolder get_Instance() { }

	// RVA: 0x5737EC
	void set_Instance(UnityLightProbesHolder value) { }

	// RVA: 0x573850
	void OnEnable() { }

	// RVA: 0x573A4C
	UnityLightProbesHolder ForceGetInstance() { }

	// RVA: 0x573CE4
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public class Area 
{
	// Fields
	public int[] points; // 0x10
	public float yMin; // 0x18
	public float yMax; // 0x1C
	public Portal[] portals; // 0x20

	// Methods

	// RVA: 0x573CEC
	void .ctor() { }

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

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE360C
	T[] get_Data() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	CFRenderLib.Unity.Structs.Handle<T> Add(T data) { }

	// RVA: 0x309AF8C
	bool Exists(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x309AF8C
	CFRenderLib.Unity.Structs.Handle<T> GetHandleFromData(int dataIndex) { }

	// RVA: 0x309AF8C
	ref T GetRef(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x309AF8C
	void Remove(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x309AF8C
	UInt16 AddData(T data) { }

	// RVA: 0x2FE4314
	void InitFreeList(int min, int max) { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class DynamicCullingData 
{
	// Fields
	public Byte[] objectArea; // 0x10
	public BoundingSphere[] objectBounds; // 0x18
	public int objectCount; // 0x20

	// Methods

	// RVA: 0x573CF4
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public class DynamicGI 
{
	// Fields
	private readonly SHLight[] m_lights; // 0x10
	private UInt16 m_lightCount; // 0x18
	private float m_currentTime; // 0x1C

	// Methods

	// RVA: 0x573CFC
	void PruneLights(float currentTime) { }

	// RVA: 0x573DBC
	void AddLight(in Vector3 position, Color startColor, Color endColor, float radius, float duration) { }

	// RVA: 0x573E38
	void SampleLights(ref SphericalHarmonicsL2 sh, in Vector3 position) { }

	// RVA: 0x574030
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public class DynamicReflectionProbe 
{
	// Fields
	public const float BlendTimeMultiplier = 1092616192;
	private int m_currentAreaIndex; // 0x10
	private int m_previousAreaIndex; // 0x14
	private float m_interpolant; // 0x18

	// Methods

	// RVA: 0x5740A0
	void Update(MaterialPropertyBlock materialPropertyBlock, int areaIndex, float deltaTime) { }

	// RVA: 0x5741C8
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class IndexPriorityQueue 
{
	// Fields
	public UInt16 count; // 0x10
	public UInt16[] indexes; // 0x18
	public UInt16[] values; // 0x20

	// Methods

	// RVA: 0x5741E0
	void .ctor(int initialSize) { }

	// RVA: 0x574270
	void Add(UInt16 value) { }

	// RVA: 0x5743FC
	void Clear() { }

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

	// RVA: 0x574404
	void .ctor(Mesh mesh) { }

	// RVA: 0x574500
	void .ctor(MeshData meshData, Mesh mesh, int submeshIndex) { }

	// RVA: 0x574974
	int GetVertexCount(int[] subMeshIndices, int baseVertex) { }

}

// Namespace: CFRenderLib.Unity.Collections
internal class MeshDataCache 
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Int32,CFRenderLib.Unity.Collections.MeshData> m_meshDatas; // 0x10
	private readonly System.Collections.Generic.List<CFRenderLib.Unity.Structs.SubmeshData> m_subMeshDatas; // 0x18

	// Methods

	// RVA: 0x574A20
	MeshData Get(Mesh mesh, int submeshIndex) { }

	// RVA: 0x574C50
	MeshData Get(Mesh mesh) { }

	// RVA: 0x574D48
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public class RawTextureData 
{
	// Fields
	public Texture2D texture; // 0x10
	public Unity.Collections.NativeArray<System.Byte> rawData; // 0x18
	public MipmapData[] mipmaps; // 0x28

	// Methods

	// RVA: 0x570920
	void .ctor(Texture2D texture, TextureCompressionInfo tc) { }

	// RVA: 0x574E28
	void FindMipmaps(TextureCompressionInfo tc) { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class RenderableCache 
{
	// Fields
	internal static CFRenderLib.Unity.Collections.DataCache<CFRenderLib.Unity.Structs.RenderableData> Roots; // 0x0

	// Methods

	// RVA: 0x56FE5C
	CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> Add(IRenderable renderable) { }

	// RVA: 0x5700C8
	void Remove(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x56F38C
	ref RenderableData GetRef(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x56F2E8
	bool Exists(CFRenderLib.Unity.Structs.Handle<CFRenderLib.Unity.Structs.RenderableData> handle) { }

	// RVA: 0x575174
	void .cctor() { }

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

	// RVA: 0x575210
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class RenderStats 
{
	// Fields
	public static UInt32 indexCount; // 0x0
	public static UInt32 vertexCount; // 0x4

	// Methods

	// RVA: 0x57539C
	void Clear() { }

}

// Namespace: CFRenderLib.Unity.Collections
public class SceneReflectionProbes 
{
	// Fields
	private readonly IDynamicLightingUtilityService m_dynamicLightingUtility; // 0x10
	private readonly ISceneReflectionProbesUtilityService m_sceneReflectionProbesUtility; // 0x18
	public Texture2DArray[] Atlases; // 0x20
	public int ProbeCount; // 0x28

	// Methods

	// RVA: 0x5753E8
	void .ctor() { }

	// RVA: 0x5754D0
	void .ctor(IDynamicLightingUtilityService dynamicLightingUtility, ISceneReflectionProbesUtilityService sceneReflectionProbesUtility) { }

	// RVA: 0x575570
	void ApplyEnvMaps(CommandBuffer commandBuffer) { }

}

// Namespace: CFRenderLib.Unity.Collections
public class SceneTextureAtlas 
{
	// Fields
	public Texture2D atlasTexture; // 0x10
	public Byte packingIndex; // 0x18
	public AtlasParameters parameters; // 0x1C
	public Texture2D[] textures; // 0x28

	// Methods

	// RVA: 0x57562C
	UInt16 GetTextureIndex(Texture2D texture) { }

	// RVA: 0x575754
	void .ctor() { }

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

	// RVA: 0x57575C
	void .ctor() { }

}

// Namespace: CFRenderLib.Unity.Collections
public static class StaticDataCache<T0> 
{
	// Fields
	internal static CFRenderLib.Unity.Collections.DataCache<T> Cache; // 0x0

	// Methods

	// RVA: 0x309AF8C
	CFRenderLib.Unity.Structs.Handle<T> Add(T t) { }

	// RVA: 0x309AF8C
	ref T GetRef(CFRenderLib.Unity.Structs.Handle<T> handle) { }

	// RVA: 0x309AF8C
	void Remove(CFRenderLib.Unity.Structs.Handle<T> renderable) { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

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

	// RVA: 0x575764
	Vector3 get_DominantLightDirection() { }

	// RVA: 0x575868
	Color get_DominantLightColor() { }

	// RVA: 0x575874
	float get_HDREncodeFactor() { }

	// RVA: 0x57587C
	ref SphericalHarmonicsL2 get_SH() { }

	// RVA: 0x575884
	int get_ProbeSize() { }

	// RVA: 0x575940
	int get_Slice() { }

	// RVA: 0x575948
	Texture2DArray[] get_ReflectionSamples() { }

	// RVA: 0x575A4C
	void .ctor() { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=16 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=20 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=5108 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=11697 
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
	internal static readonly __StaticArrayInitTypeSize=16 8DF28E51E6285370840F0C8FD6BC27E3EF1CA52BD070712EDA60F9274B182AFC; // 0x38
	internal static readonly Int64 9655D519C47A0B433D9B4ABC6335BE754440D271D1AD594C96DC11F672EAA4A4; // 0x48
	internal static readonly __StaticArrayInitTypeSize=5108 986F6F53160FD3F20EA9FA112C86DD40E51B5EED5E68E9FDC6FD6CAF1CC45E7C; // 0x50
	internal static readonly Int64 DCBC8A96B332D7B2B126D401D47D72C1DAF86DDD7102704C197EE0A8AC66D034; // 0x1448
	internal static readonly __StaticArrayInitTypeSize=11697 F0FB0D98B7005576718E6CB0D2ED7BC5D152E6FB50F352F4712C63C3DB2E8C8E; // 0x1450
	internal static readonly __StaticArrayInitTypeSize=20 F955B65874DC572B213A30BA1E58039C6A27841C2AE5ADF62AD5ED45ADA54F6D; // 0x4201
}


