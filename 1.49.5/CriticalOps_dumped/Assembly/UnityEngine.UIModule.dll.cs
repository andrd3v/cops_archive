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

	// RVA: 0x188B9E8
	public float get_alpha() { }

	// RVA: 0x188BA38
	public void set_alpha(float value) { }

	// RVA: 0x188BAA0
	public bool get_interactable() { }

	// RVA: 0x188BAF0
	public void set_interactable(bool value) { }

	// RVA: 0x188BB58
	public bool get_blocksRaycasts() { }

	// RVA: 0x188BBA8
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x188BC10
	public bool get_ignoreParentGroups() { }

	// RVA: 0x188BC60
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x188BCC8
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Namespace: UnityEngine
public sealed class CanvasRenderer
{
	// Fields
	private bool <isMask>k__BackingField; // 0x18

	// Methods

	// RVA: 0x188BD18
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x188BD80
	public int get_materialCount() { }

	// RVA: 0x188BDD0
	public void set_materialCount(int value) { }

	// RVA: 0x188BE38
	public void set_popMaterialCount(int value) { }

	// RVA: 0x188BEA0
	public int get_absoluteDepth() { }

	// RVA: 0x188BEF0
	public bool get_hasMoved() { }

	// RVA: 0x188BF40
	public bool get_cull() { }

	// RVA: 0x188BF90
	public void set_cull(bool value) { }

	// RVA: 0x188BFF8
	public void SetColor(Color color) { }

	// RVA: 0x188C0B8
	public Color GetColor() { }

	// RVA: 0x188C17C
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x188C23C
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x188C2F8
	public void DisableRectClipping() { }

	// RVA: 0x188C348
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x188C3A0
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x188C3F8
	public void SetTexture(Texture texture) { }

	// RVA: 0x188C460
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x188C4C8
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x188C530
	public void Clear() { }

	// RVA: 0x188C580
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x188C6FC
	public static void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x188C8E0
	public static void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x188CA28
	public static void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents) { }

	// RVA: 0x188C878
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	// RVA: 0x188C7D8
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	// RVA: 0x188C984
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x188C050
	private void SetColor_Injected(Color color) { }

	// RVA: 0x188C114
	private void GetColor_Injected(Color ret) { }

	// RVA: 0x188C1D4
	private void EnableRectClipping_Injected(Rect rect) { }

	// RVA: 0x188C290
	private void set_clippingSoftness_Injected(Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class RectTransformUtility
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x188CAC8
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x188CBF8
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x188CD14
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x188CE40
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x188CF18
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x188D060
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, Vector3 worldPoint) { }

	// RVA: 0x188D6B8
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, Vector2 localPoint) { }

	// RVA: 0x188D4B8
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x188D7C0
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x188D8A0
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x188DBC4
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x188DE64
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x188DE74
	private static void .cctor() { }

	// RVA: 0x188CB90
	private static void PixelAdjustPoint_Injected(Vector2 point, Transform elementTransform, Canvas canvas, Vector2 ret) { }

	// RVA: 0x188CCBC
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, Rect ret) { }

	// RVA: 0x188CDD8
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

	// RVA: 0x188F7A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x188F848
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

	// RVA: 0x188DEF4
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x188DFB4
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x188E074
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x188E138
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x188E1FC
	public RenderMode get_renderMode() { }

	// RVA: 0x188E24C
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x188E2B4
	public bool get_isRootCanvas() { }

	// RVA: 0x188E304
	public Rect get_pixelRect() { }

	// RVA: 0x188E3C8
	public float get_scaleFactor() { }

	// RVA: 0x188E418
	public void set_scaleFactor(float value) { }

	// RVA: 0x188E480
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x188E4D0
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x188E538
	public bool get_overridePixelPerfect() { }

	// RVA: 0x188E588
	public void set_overridePixelPerfect(bool value) { }

	// RVA: 0x188E5F0
	public bool get_vertexColorAlwaysGammaSpace() { }

	// RVA: 0x188E640
	public void set_vertexColorAlwaysGammaSpace(bool value) { }

	// RVA: 0x188E6A8
	public bool get_pixelPerfect() { }

	// RVA: 0x188E6F8
	public void set_pixelPerfect(bool value) { }

	// RVA: 0x188E760
	public float get_planeDistance() { }

	// RVA: 0x188E7B0
	public void set_planeDistance(float value) { }

	// RVA: 0x188E818
	public int get_renderOrder() { }

	// RVA: 0x188E868
	public bool get_overrideSorting() { }

	// RVA: 0x188E8B8
	public void set_overrideSorting(bool value) { }

	// RVA: 0x188E920
	public int get_sortingOrder() { }

	// RVA: 0x188E970
	public void set_sortingOrder(int value) { }

	// RVA: 0x188E9D8
	public int get_targetDisplay() { }

	// RVA: 0x188EA28
	public void set_targetDisplay(int value) { }

	// RVA: 0x188EA90
	public int get_sortingLayerID() { }

	// RVA: 0x188EAE0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x188EB48
	public int get_cachedSortingLayerValue() { }

	// RVA: 0x188EB98
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x188EBE8
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x188EC50
	public string get_sortingLayerName() { }

	// RVA: 0x188ECA0
	public void set_sortingLayerName(string value) { }

	// RVA: 0x188ED08
	public Canvas get_rootCanvas() { }

	// RVA: 0x188ED58
	public Vector2 get_renderingDisplaySize() { }

	// RVA: 0x188EE18
	public StandaloneRenderResize get_updateRectTransformForStandalone() { }

	// RVA: 0x188EE68
	public void set_updateRectTransformForStandalone(StandaloneRenderResize value) { }

	// RVA: 0x188EED0
	internal static System.Action<System.Int32> get_externBeginRenderOverlays() { }

	// RVA: 0x188EF1C
	internal static void set_externBeginRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x188EF78
	internal static System.Action<System.Int32,System.Int32> get_externRenderOverlaysBefore() { }

	// RVA: 0x188EFC4
	internal static void set_externRenderOverlaysBefore(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x188F020
	internal static System.Action<System.Int32> get_externEndRenderOverlays() { }

	// RVA: 0x188F06C
	internal static void set_externEndRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x188F0C8
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x188F118
	public Camera get_worldCamera() { }

	// RVA: 0x188F168
	public void set_worldCamera(Camera value) { }

	// RVA: 0x188F1D0
	public float get_normalizedSortingGridSize() { }

	// RVA: 0x188F220
	public void set_normalizedSortingGridSize(float value) { }

	// RVA: 0x188F288
	public int get_sortingGridNormalizedSize() { }

	// RVA: 0x188F2D8
	public void set_sortingGridNormalizedSize(int value) { }

	// RVA: 0x188F340
	public static Material GetDefaultCanvasTextMaterial() { }

	// RVA: 0x188F380
	public static Material GetDefaultCanvasMaterial() { }

	// RVA: 0x188F3C0
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x188F400
	internal void UpdateCanvasRectTransform(bool alignWithCamera) { }

	// RVA: 0x188F468
	public static void ForceUpdateCanvases() { }

	// RVA: 0x188F510
	private static void SendPreWillRenderCanvases() { }

	// RVA: 0x188F578
	private static void SendWillRenderCanvases() { }

	// RVA: 0x188F5E0
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x188F670
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	// RVA: 0x188F710
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x188F7A0
	public void .ctor() { }

	// RVA: 0x188E360
	private void get_pixelRect_Injected(Rect ret) { }

	// RVA: 0x188EDB0
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

	// RVA: 0x188F85C
	public static void BeginSample(SampleType type) { }

	// RVA: 0x188F8AC
	public static void EndSample(SampleType type) { }

	// RVA: 0x188F8FC
	public static void AddMarker(string name, object obj) { }

}


