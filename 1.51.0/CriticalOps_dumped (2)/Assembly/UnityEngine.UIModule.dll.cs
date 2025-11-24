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

	// RVA: 0x1A0687C
	public float get_alpha() { }

	// RVA: 0x1A06964
	public void set_alpha(float value) { }

	// RVA: 0x1A06A7C
	public bool get_interactable() { }

	// RVA: 0x1A06B64
	public void set_interactable(bool value) { }

	// RVA: 0x1A06C7C
	public bool get_blocksRaycasts() { }

	// RVA: 0x1A06D64
	public void set_blocksRaycasts(bool value) { }

	// RVA: 0x1A06E7C
	public bool get_ignoreParentGroups() { }

	// RVA: 0x1A06F64
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x1A0707C
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1A07114
	public void .ctor() { }

	// RVA: 0x1A06914
	private static float get_alpha_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A06A14
	private static void set_alpha_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1A06B14
	private static bool get_interactable_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A06C14
	private static void set_interactable_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1A06D14
	private static bool get_blocksRaycasts_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A06E14
	private static void set_blocksRaycasts_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1A06F14
	private static bool get_ignoreParentGroups_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A07014
	private static void set_ignoreParentGroups_Injected(IntPtr _unity_self, bool value) { }

}

// Namespace: UnityEngine
public sealed class CanvasRenderer
{
	// Fields
	private bool <isMask>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1A0711C
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x1A07234
	public int get_materialCount() { }

	// RVA: 0x1A0731C
	public void set_materialCount(int value) { }

	// RVA: 0x1A07434
	public void set_popMaterialCount(int value) { }

	// RVA: 0x1A0754C
	public int get_absoluteDepth() { }

	// RVA: 0x1A07634
	public bool get_hasMoved() { }

	// RVA: 0x1A0771C
	public bool get_cull() { }

	// RVA: 0x1A07804
	public void set_cull(bool value) { }

	// RVA: 0x1A0791C
	public void SetColor(Color color) { }

	// RVA: 0x1A07A28
	public Color GetColor() { }

	// RVA: 0x1A07B38
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x1A07C44
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x1A07D4C
	public void DisableRectClipping() { }

	// RVA: 0x1A07E34
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x1A07F68
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x1A0809C
	public void SetTexture(Texture texture) { }

	// RVA: 0x1A081E8
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x1A08334
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x1A08480
	public void Clear() { }

	// RVA: 0x1A08568
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x1A08720
	public static void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x1A08904
	public static void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x1A08A4C
	public static void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents) { }

	// RVA: 0x1A0889C
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	// RVA: 0x1A087FC
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	// RVA: 0x1A089A8
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x1A08AEC
	public void .ctor() { }

	// RVA: 0x1A071CC
	private static void set_hasPopInstruction_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1A072CC
	private static int get_materialCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A073CC
	private static void set_materialCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1A074E4
	private static void set_popMaterialCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1A075E4
	private static int get_absoluteDepth_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A076CC
	private static bool get_hasMoved_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A077B4
	private static bool get_cull_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A078B4
	private static void set_cull_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1A079C0
	private static void SetColor_Injected(IntPtr _unity_self, Color color) { }

	// RVA: 0x1A07AD0
	private static void GetColor_Injected(IntPtr _unity_self, Color ret) { }

	// RVA: 0x1A07BDC
	private static void EnableRectClipping_Injected(IntPtr _unity_self, Rect rect) { }

	// RVA: 0x1A07CE4
	private static void set_clippingSoftness_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x1A07DE4
	private static void DisableRectClipping_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A07F10
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	// RVA: 0x1A08044
	private static void SetPopMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	// RVA: 0x1A08180
	private static void SetTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	// RVA: 0x1A082CC
	private static void SetAlphaTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	// RVA: 0x1A08418
	private static void SetMesh_Injected(IntPtr _unity_self, IntPtr mesh) { }

	// RVA: 0x1A08518
	private static void Clear_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public sealed class RectTransformUtility
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x1A08AF4
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x1A08C9C
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x1A08E30
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x1A08FD4
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x1A090F8
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x1A091A8
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, Vector3 worldPoint) { }

	// RVA: 0x1A09800
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, Vector2 localPoint) { }

	// RVA: 0x1A09600
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x1A09908
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x1A099E8
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x1A09D0C
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x1A09FAC
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x1A09FBC
	private static void .cctor() { }

	// RVA: 0x1A08C34
	private static void PixelAdjustPoint_Injected(Vector2 point, IntPtr elementTransform, IntPtr canvas, Vector2 ret) { }

	// RVA: 0x1A08DD8
	private static void PixelAdjustRect_Injected(IntPtr rectTransform, IntPtr canvas, Rect ret) { }

	// RVA: 0x1A08F6C
	private static bool PointInRectangle_Injected(Vector2 screenPoint, IntPtr rect, IntPtr cam, Vector4 offset) { }

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

	// RVA: 0x1A0D644
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A0D6E4
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

	// RVA: 0x1A0A03C
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x1A0A0FC
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x1A0A1BC
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x1A0A280
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x1A0A344
	public RenderMode get_renderMode() { }

	// RVA: 0x1A0A42C
	public void set_renderMode(RenderMode value) { }

	// RVA: 0x1A0A544
	public bool get_isRootCanvas() { }

	// RVA: 0x1A0A62C
	public Rect get_pixelRect() { }

	// RVA: 0x1A0A73C
	public float get_scaleFactor() { }

	// RVA: 0x1A0A824
	public void set_scaleFactor(float value) { }

	// RVA: 0x1A0A93C
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x1A0AA24
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x1A0AB3C
	public bool get_overridePixelPerfect() { }

	// RVA: 0x1A0AC24
	public void set_overridePixelPerfect(bool value) { }

	// RVA: 0x1A0AD3C
	public bool get_vertexColorAlwaysGammaSpace() { }

	// RVA: 0x1A0AE24
	public void set_vertexColorAlwaysGammaSpace(bool value) { }

	// RVA: 0x1A0AF3C
	public bool get_pixelPerfect() { }

	// RVA: 0x1A0B024
	public void set_pixelPerfect(bool value) { }

	// RVA: 0x1A0B13C
	public float get_planeDistance() { }

	// RVA: 0x1A0B224
	public void set_planeDistance(float value) { }

	// RVA: 0x1A0B33C
	public int get_renderOrder() { }

	// RVA: 0x1A0B424
	public bool get_overrideSorting() { }

	// RVA: 0x1A0B50C
	public void set_overrideSorting(bool value) { }

	// RVA: 0x1A0B624
	public int get_sortingOrder() { }

	// RVA: 0x1A0B70C
	public void set_sortingOrder(int value) { }

	// RVA: 0x1A0B824
	public int get_targetDisplay() { }

	// RVA: 0x1A0B90C
	public void set_targetDisplay(int value) { }

	// RVA: 0x1A0BA24
	public int get_sortingLayerID() { }

	// RVA: 0x1A0BB0C
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1A0BC24
	public int get_cachedSortingLayerValue() { }

	// RVA: 0x1A0BD0C
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x1A0BDF4
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x1A0BF0C
	public string get_sortingLayerName() { }

	// RVA: 0x1A0C0B4
	public void set_sortingLayerName(string value) { }

	// RVA: 0x1A0C2D8
	public Canvas get_rootCanvas() { }

	// RVA: 0x1A0C3E0
	public Vector2 get_renderingDisplaySize() { }

	// RVA: 0x1A0C4EC
	public StandaloneRenderResize get_updateRectTransformForStandalone() { }

	// RVA: 0x1A0C5D4
	public void set_updateRectTransformForStandalone(StandaloneRenderResize value) { }

	// RVA: 0x1A0C6EC
	internal static System.Action<System.Int32> get_externBeginRenderOverlays() { }

	// RVA: 0x1A0C738
	internal static void set_externBeginRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x1A0C794
	internal static System.Action<System.Int32,System.Int32> get_externRenderOverlaysBefore() { }

	// RVA: 0x1A0C7E0
	internal static void set_externRenderOverlaysBefore(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x1A0C83C
	internal static System.Action<System.Int32> get_externEndRenderOverlays() { }

	// RVA: 0x1A0C888
	internal static void set_externEndRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x1A0C8E4
	internal static void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x1A0C934
	public Camera get_worldCamera() { }

	// RVA: 0x1A0CA3C
	public void set_worldCamera(Camera value) { }

	// RVA: 0x1A0CB88
	public float get_normalizedSortingGridSize() { }

	// RVA: 0x1A0CC70
	public void set_normalizedSortingGridSize(float value) { }

	// RVA: 0x1A0CD88
	public int get_sortingGridNormalizedSize() { }

	// RVA: 0x1A0CE70
	public void set_sortingGridNormalizedSize(int value) { }

	// RVA: 0x1A0CF88
	public static Material GetDefaultCanvasTextMaterial() { }

	// RVA: 0x1A0D054
	public static Material GetDefaultCanvasMaterial() { }

	// RVA: 0x1A0D120
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x1A0D1EC
	internal void UpdateCanvasRectTransform(bool alignWithCamera) { }

	// RVA: 0x1A0D304
	public static void ForceUpdateCanvases() { }

	// RVA: 0x1A0D3AC
	private static void SendPreWillRenderCanvases() { }

	// RVA: 0x1A0D414
	private static void SendWillRenderCanvases() { }

	// RVA: 0x1A0D47C
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x1A0D50C
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	// RVA: 0x1A0D5AC
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x1A0D63C
	public void .ctor() { }

	// RVA: 0x1A0A3DC
	private static RenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0A4DC
	private static void set_renderMode_Injected(IntPtr _unity_self, RenderMode value) { }

	// RVA: 0x1A0A5DC
	private static bool get_isRootCanvas_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0A6D4
	private static void get_pixelRect_Injected(IntPtr _unity_self, Rect ret) { }

	// RVA: 0x1A0A7D4
	private static float get_scaleFactor_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0A8D4
	private static void set_scaleFactor_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1A0A9D4
	private static float get_referencePixelsPerUnit_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0AAD4
	private static void set_referencePixelsPerUnit_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1A0ABD4
	private static bool get_overridePixelPerfect_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0ACD4
	private static void set_overridePixelPerfect_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1A0ADD4
	private static bool get_vertexColorAlwaysGammaSpace_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0AED4
	private static void set_vertexColorAlwaysGammaSpace_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1A0AFD4
	private static bool get_pixelPerfect_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0B0D4
	private static void set_pixelPerfect_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1A0B1D4
	private static float get_planeDistance_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0B2D4
	private static void set_planeDistance_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1A0B3D4
	private static int get_renderOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0B4BC
	private static bool get_overrideSorting_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0B5BC
	private static void set_overrideSorting_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1A0B6BC
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0B7BC
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1A0B8BC
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0B9BC
	private static void set_targetDisplay_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1A0BABC
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0BBBC
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1A0BCBC
	private static int get_cachedSortingLayerValue_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0BDA4
	private static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0BEA4
	private static void set_additionalShaderChannels_Injected(IntPtr _unity_self, AdditionalCanvasShaderChannels value) { }

	// RVA: 0x1A0C04C
	private static void get_sortingLayerName_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x1A0C270
	private static void set_sortingLayerName_Injected(IntPtr _unity_self, ManagedSpanWrapper value) { }

	// RVA: 0x1A0C390
	private static IntPtr get_rootCanvas_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0C484
	private static void get_renderingDisplaySize_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x1A0C584
	private static StandaloneRenderResize get_updateRectTransformForStandalone_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0C684
	private static void set_updateRectTransformForStandalone_Injected(IntPtr _unity_self, StandaloneRenderResize value) { }

	// RVA: 0x1A0C9EC
	private static IntPtr get_worldCamera_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0CB20
	private static void set_worldCamera_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1A0CC20
	private static float get_normalizedSortingGridSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0CD20
	private static void set_normalizedSortingGridSize_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1A0CE20
	private static int get_sortingGridNormalizedSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1A0CF20
	private static void set_sortingGridNormalizedSize_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1A0D014
	private static IntPtr GetDefaultCanvasTextMaterial_Injected() { }

	// RVA: 0x1A0D0E0
	private static IntPtr GetDefaultCanvasMaterial_Injected() { }

	// RVA: 0x1A0D1AC
	private static IntPtr GetETC1SupportedCanvasMaterial_Injected() { }

	// RVA: 0x1A0D29C
	private static void UpdateCanvasRectTransform_Injected(IntPtr _unity_self, bool alignWithCamera) { }

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

	// RVA: 0x1A0D6F8
	public static void BeginSample(SampleType type) { }

	// RVA: 0x1A0D748
	public static void EndSample(SampleType type) { }

	// RVA: 0x1A0D798
	public static void AddMarker(string name, object obj) { }

	// RVA: 0x1A0D950
	private static void AddMarker_Injected(ManagedSpanWrapper name, IntPtr obj) { }

}


