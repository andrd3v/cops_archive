// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public interface ICanvasRaycastFilter
{
	// Methods

	// RVA: -1
	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Namespace: UnityEngine
public sealed class CanvasGroup
{
	// Methods

	// RVA: 0x18AEBBC
	public float get_alpha() { }

	// RVA: 0x18AEC0C
	public void set_alpha(float value) { }

	// RVA: 0x18AEC74
	public bool get_interactable() { }

	// RVA: 0x18AECC4
	public void set_interactable(bool value) { }

	// RVA: 0x18AED2C
	public bool get_blocksRaycasts() { }

	// RVA: 0x18AED7C
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x18AEDE4
	public bool get_ignoreParentGroups() { }

	// RVA: 0x18AEE34
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x18AEE9C
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Namespace: UnityEngine
public sealed class CanvasRenderer
{
	// Fields
	private bool <isMask>k__BackingField; // 0x18

	// Methods

	// RVA: 0x18AEEEC
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x18AEF54
	public int get_materialCount() { }

	// RVA: 0x18AEFA4
	public void set_materialCount(int value) { }

	// RVA: 0x18AF00C
	public void set_popMaterialCount(int value) { }

	// RVA: 0x18AF074
	public int get_absoluteDepth() { }

	// RVA: 0x18AF0C4
	public bool get_hasMoved() { }

	// RVA: 0x18AF114
	public bool get_cull() { }

	// RVA: 0x18AF164
	public void set_cull(bool value) { }

	// RVA: 0x18AF1CC
	public void SetColor(Color color) { }

	// RVA: 0x18AF28C
	public Color GetColor() { }

	// RVA: 0x18AF350
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x18AF410
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x18AF4CC
	public void DisableRectClipping() { }

	// RVA: 0x18AF51C
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x18AF574
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x18AF5CC
	public void SetTexture(Texture texture) { }

	// RVA: 0x18AF634
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x18AF69C
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x18AF704
	public void Clear() { }

	// RVA: 0x18AF754
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x18AF8D0
	public static void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x18AFAB4
	public static void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x18AFBFC
	public static void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents) { }

	// RVA: 0x18AFA4C
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	// RVA: 0x18AF9AC
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	// RVA: 0x18AFB58
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x18AF224
	private void SetColor_Injected(Color color) { }

	// RVA: 0x18AF2E8
	private void GetColor_Injected(Color ret) { }

	// RVA: 0x18AF3A8
	private void EnableRectClipping_Injected(Rect rect) { }

	// RVA: 0x18AF464
	private void set_clippingSoftness_Injected(Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class RectTransformUtility
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x18AFC9C
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x18AFDCC
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x18AFEE8
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x18B0014
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x18B00EC
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x18B0234
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, Vector3 worldPoint) { }

	// RVA: 0x18B088C
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, Vector2 localPoint) { }

	// RVA: 0x18B068C
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x18B0994
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x18B0A74
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x18B0D98
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x18B1038
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x18B1048
	private static void .cctor() { }

	// RVA: 0x18AFD64
	private static void PixelAdjustPoint_Injected(Vector2 point, Transform elementTransform, Canvas canvas, Vector2 ret) { }

	// RVA: 0x18AFE90
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, Rect ret) { }

	// RVA: 0x18AFFAC
	private static bool PointInRectangle_Injected(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

}

// Namespace: UnityEngine
public enum RenderMode
{
	// Fields
	public int value__; // 0x10
	public const RenderMode ScreenSpaceOverlay = 0;
	public const RenderMode ScreenSpaceCamera = 1;
	public const RenderMode WorldSpace = 2;
}

// Namespace: UnityEngine
public enum StandaloneRenderResize
{
	// Fields
	public int value__; // 0x10
	public const StandaloneRenderResize Enabled = 0;
	public const StandaloneRenderResize Disabled = 1;
}

// Namespace: UnityEngine
public enum AdditionalCanvasShaderChannels
{
	// Fields
	public int value__; // 0x10
	public const AdditionalCanvasShaderChannels None = 0;
	public const AdditionalCanvasShaderChannels TexCoord1 = 1;
	public const AdditionalCanvasShaderChannels TexCoord2 = 2;
	public const AdditionalCanvasShaderChannels TexCoord3 = 4;
	public const AdditionalCanvasShaderChannels Normal = 8;
	public const AdditionalCanvasShaderChannels Tangent = 16;
}

// Namespace: 
public sealed class WillRenderCanvases
{
	// Methods

	// RVA: 0x18B297C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18B2A1C
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public sealed class Canvas
{
	// Fields
	private static WillRenderCanvases preWillRenderCanvases; // 0x0
	private static WillRenderCanvases willRenderCanvases; // 0x8
	private static System.Action<System.Int32> <externBeginRenderOverlays>k__BackingField; // 0x10
	private static System.Action<System.Int32,System.Int32> <externRenderOverlaysBefore>k__BackingField; // 0x18
	private static System.Action<System.Int32> <externEndRenderOverlays>k__BackingField; // 0x20

	// Methods

	// RVA: 0x18B10C8
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x18B1188
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x18B1248
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x18B130C
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x18B13D0
	public RenderMode get_renderMode() { }

	// RVA: 0x18B1420
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x18B1488
	public bool get_isRootCanvas() { }

	// RVA: 0x18B14D8
	public Rect get_pixelRect() { }

	// RVA: 0x18B159C
	public float get_scaleFactor() { }

	// RVA: 0x18B15EC
	public void set_scaleFactor(float value) { }

	// RVA: 0x18B1654
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x18B16A4
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x18B170C
	public bool get_overridePixelPerfect() { }

	// RVA: 0x18B175C
	public void set_overridePixelPerfect(bool value) { }

	// RVA: 0x18B17C4
	public bool get_vertexColorAlwaysGammaSpace() { }

	// RVA: 0x18B1814
	public void set_vertexColorAlwaysGammaSpace(bool value) { }

	// RVA: 0x18B187C
	public bool get_pixelPerfect() { }

	// RVA: 0x18B18CC
	public void set_pixelPerfect(bool value) { }

	// RVA: 0x18B1934
	public float get_planeDistance() { }

	// RVA: 0x18B1984
	public void set_planeDistance(float value) { }

	// RVA: 0x18B19EC
	public int get_renderOrder() { }

	// RVA: 0x18B1A3C
	public bool get_overrideSorting() { }

	// RVA: 0x18B1A8C
	public void set_overrideSorting(bool value) { }

	// RVA: 0x18B1AF4
	public int get_sortingOrder() { }

	// RVA: 0x18B1B44
	public void set_sortingOrder(int value) { }

	// RVA: 0x18B1BAC
	public int get_targetDisplay() { }

	// RVA: 0x18B1BFC
	public void set_targetDisplay(int value) { }

	// RVA: 0x18B1C64
	public int get_sortingLayerID() { }

	// RVA: 0x18B1CB4
	public void set_sortingLayerID(int value) { }

	// RVA: 0x18B1D1C
	public int get_cachedSortingLayerValue() { }

	// RVA: 0x18B1D6C
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x18B1DBC
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x18B1E24
	public string get_sortingLayerName() { }

	// RVA: 0x18B1E74
	public void set_sortingLayerName(string value) { }

	// RVA: 0x18B1EDC
	public Canvas get_rootCanvas() { }

	// RVA: 0x18B1F2C
	public Vector2 get_renderingDisplaySize() { }

	// RVA: 0x18B1FEC
	public StandaloneRenderResize get_updateRectTransformForStandalone() { }

	// RVA: 0x18B203C
	public void set_updateRectTransformForStandalone(StandaloneRenderResize value) { }

	// RVA: 0x18B20A4
	internal static System.Action<System.Int32> get_externBeginRenderOverlays() { }

	// RVA: 0x18B20F0
	internal static void set_externBeginRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x18B214C
	internal static System.Action<System.Int32,System.Int32> get_externRenderOverlaysBefore() { }

	// RVA: 0x18B2198
	internal static void set_externRenderOverlaysBefore(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x18B21F4
	internal static System.Action<System.Int32> get_externEndRenderOverlays() { }

	// RVA: 0x18B2240
	internal static void set_externEndRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x18B229C
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x18B22EC
	public Camera get_worldCamera() { }

	// RVA: 0x18B233C
	public void set_worldCamera(Camera value) { }

	// RVA: 0x18B23A4
	public float get_normalizedSortingGridSize() { }

	// RVA: 0x18B23F4
	public void set_normalizedSortingGridSize(float value) { }

	// RVA: 0x18B245C
	public int get_sortingGridNormalizedSize() { }

	// RVA: 0x18B24AC
	public void set_sortingGridNormalizedSize(int value) { }

	// RVA: 0x18B2514
	public static Material GetDefaultCanvasTextMaterial() { }

	// RVA: 0x18B2554
	public static Material GetDefaultCanvasMaterial() { }

	// RVA: 0x18B2594
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x18B25D4
	internal void UpdateCanvasRectTransform(bool alignWithCamera) { }

	// RVA: 0x18B263C
	public static void ForceUpdateCanvases() { }

	// RVA: 0x18B26E4
	private static void SendPreWillRenderCanvases() { }

	// RVA: 0x18B274C
	private static void SendWillRenderCanvases() { }

	// RVA: 0x18B27B4
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x18B2844
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	// RVA: 0x18B28E4
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x18B2974
	public void .ctor() { }

	// RVA: 0x18B1534
	private void get_pixelRect_Injected(Rect ret) { }

	// RVA: 0x18B1F84
	private void get_renderingDisplaySize_Injected(Vector2 ret) { }

}

// Namespace: 
public enum SampleType
{
	// Fields
	public int value__; // 0x10
	public const SampleType Layout = 0;
	public const SampleType Render = 1;
}

// Namespace: UnityEngine
public static class UISystemProfilerApi
{
	// Methods

	// RVA: 0x18B2A30
	public static void BeginSample(SampleType type) { }

	// RVA: 0x18B2A80
	public static void EndSample(SampleType type) { }

	// RVA: 0x18B2AD0
	public static void AddMarker(string name, object obj) { }

}


