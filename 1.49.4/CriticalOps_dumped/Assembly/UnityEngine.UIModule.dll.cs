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

	// RVA: 0x187C778
	public float get_alpha() { }

	// RVA: 0x187C7C8
	public void set_alpha(float value) { }

	// RVA: 0x187C830
	public bool get_interactable() { }

	// RVA: 0x187C880
	public void set_interactable(bool value) { }

	// RVA: 0x187C8E8
	public bool get_blocksRaycasts() { }

	// RVA: 0x187C938
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x187C9A0
	public bool get_ignoreParentGroups() { }

	// RVA: 0x187C9F0
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x187CA58
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Namespace: UnityEngine
public sealed class CanvasRenderer
{
	// Fields
	private bool <isMask>k__BackingField; // 0x18

	// Methods

	// RVA: 0x187CAA8
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x187CB10
	public int get_materialCount() { }

	// RVA: 0x187CB60
	public void set_materialCount(int value) { }

	// RVA: 0x187CBC8
	public void set_popMaterialCount(int value) { }

	// RVA: 0x187CC30
	public int get_absoluteDepth() { }

	// RVA: 0x187CC80
	public bool get_hasMoved() { }

	// RVA: 0x187CCD0
	public bool get_cull() { }

	// RVA: 0x187CD20
	public void set_cull(bool value) { }

	// RVA: 0x187CD88
	public void SetColor(Color color) { }

	// RVA: 0x187CE48
	public Color GetColor() { }

	// RVA: 0x187CF0C
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x187CFCC
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x187D088
	public void DisableRectClipping() { }

	// RVA: 0x187D0D8
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x187D130
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x187D188
	public void SetTexture(Texture texture) { }

	// RVA: 0x187D1F0
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x187D258
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x187D2C0
	public void Clear() { }

	// RVA: 0x187D310
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x187D48C
	public static void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x187D670
	public static void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x187D7B8
	public static void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents) { }

	// RVA: 0x187D608
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	// RVA: 0x187D568
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	// RVA: 0x187D714
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x187CDE0
	private void SetColor_Injected(Color color) { }

	// RVA: 0x187CEA4
	private void GetColor_Injected(Color ret) { }

	// RVA: 0x187CF64
	private void EnableRectClipping_Injected(Rect rect) { }

	// RVA: 0x187D020
	private void set_clippingSoftness_Injected(Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class RectTransformUtility
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x187D858
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x187D988
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x187DAA4
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x187DBD0
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x187DCA8
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x187DDF0
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, Vector3 worldPoint) { }

	// RVA: 0x187E448
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, Vector2 localPoint) { }

	// RVA: 0x187E248
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x187E550
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x187E630
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x187E954
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x187EBF4
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x187EC04
	private static void .cctor() { }

	// RVA: 0x187D920
	private static void PixelAdjustPoint_Injected(Vector2 point, Transform elementTransform, Canvas canvas, Vector2 ret) { }

	// RVA: 0x187DA4C
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, Rect ret) { }

	// RVA: 0x187DB68
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

	// RVA: 0x1880538
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18805D8
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

	// RVA: 0x187EC84
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x187ED44
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x187EE04
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x187EEC8
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x187EF8C
	public RenderMode get_renderMode() { }

	// RVA: 0x187EFDC
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x187F044
	public bool get_isRootCanvas() { }

	// RVA: 0x187F094
	public Rect get_pixelRect() { }

	// RVA: 0x187F158
	public float get_scaleFactor() { }

	// RVA: 0x187F1A8
	public void set_scaleFactor(float value) { }

	// RVA: 0x187F210
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x187F260
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x187F2C8
	public bool get_overridePixelPerfect() { }

	// RVA: 0x187F318
	public void set_overridePixelPerfect(bool value) { }

	// RVA: 0x187F380
	public bool get_vertexColorAlwaysGammaSpace() { }

	// RVA: 0x187F3D0
	public void set_vertexColorAlwaysGammaSpace(bool value) { }

	// RVA: 0x187F438
	public bool get_pixelPerfect() { }

	// RVA: 0x187F488
	public void set_pixelPerfect(bool value) { }

	// RVA: 0x187F4F0
	public float get_planeDistance() { }

	// RVA: 0x187F540
	public void set_planeDistance(float value) { }

	// RVA: 0x187F5A8
	public int get_renderOrder() { }

	// RVA: 0x187F5F8
	public bool get_overrideSorting() { }

	// RVA: 0x187F648
	public void set_overrideSorting(bool value) { }

	// RVA: 0x187F6B0
	public int get_sortingOrder() { }

	// RVA: 0x187F700
	public void set_sortingOrder(int value) { }

	// RVA: 0x187F768
	public int get_targetDisplay() { }

	// RVA: 0x187F7B8
	public void set_targetDisplay(int value) { }

	// RVA: 0x187F820
	public int get_sortingLayerID() { }

	// RVA: 0x187F870
	public void set_sortingLayerID(int value) { }

	// RVA: 0x187F8D8
	public int get_cachedSortingLayerValue() { }

	// RVA: 0x187F928
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x187F978
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x187F9E0
	public string get_sortingLayerName() { }

	// RVA: 0x187FA30
	public void set_sortingLayerName(string value) { }

	// RVA: 0x187FA98
	public Canvas get_rootCanvas() { }

	// RVA: 0x187FAE8
	public Vector2 get_renderingDisplaySize() { }

	// RVA: 0x187FBA8
	public StandaloneRenderResize get_updateRectTransformForStandalone() { }

	// RVA: 0x187FBF8
	public void set_updateRectTransformForStandalone(StandaloneRenderResize value) { }

	// RVA: 0x187FC60
	internal static System.Action<System.Int32> get_externBeginRenderOverlays() { }

	// RVA: 0x187FCAC
	internal static void set_externBeginRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x187FD08
	internal static System.Action<System.Int32,System.Int32> get_externRenderOverlaysBefore() { }

	// RVA: 0x187FD54
	internal static void set_externRenderOverlaysBefore(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x187FDB0
	internal static System.Action<System.Int32> get_externEndRenderOverlays() { }

	// RVA: 0x187FDFC
	internal static void set_externEndRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x187FE58
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x187FEA8
	public Camera get_worldCamera() { }

	// RVA: 0x187FEF8
	public void set_worldCamera(Camera value) { }

	// RVA: 0x187FF60
	public float get_normalizedSortingGridSize() { }

	// RVA: 0x187FFB0
	public void set_normalizedSortingGridSize(float value) { }

	// RVA: 0x1880018
	public int get_sortingGridNormalizedSize() { }

	// RVA: 0x1880068
	public void set_sortingGridNormalizedSize(int value) { }

	// RVA: 0x18800D0
	public static Material GetDefaultCanvasTextMaterial() { }

	// RVA: 0x1880110
	public static Material GetDefaultCanvasMaterial() { }

	// RVA: 0x1880150
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x1880190
	internal void UpdateCanvasRectTransform(bool alignWithCamera) { }

	// RVA: 0x18801F8
	public static void ForceUpdateCanvases() { }

	// RVA: 0x18802A0
	private static void SendPreWillRenderCanvases() { }

	// RVA: 0x1880308
	private static void SendWillRenderCanvases() { }

	// RVA: 0x1880370
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x1880400
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	// RVA: 0x18804A0
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x1880530
	public void .ctor() { }

	// RVA: 0x187F0F0
	private void get_pixelRect_Injected(Rect ret) { }

	// RVA: 0x187FB40
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

	// RVA: 0x18805EC
	public static void BeginSample(SampleType type) { }

	// RVA: 0x188063C
	public static void EndSample(SampleType type) { }

	// RVA: 0x188068C
	public static void AddMarker(string name, object obj) { }

}


