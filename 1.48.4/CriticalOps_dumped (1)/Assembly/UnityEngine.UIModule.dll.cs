// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine
public interface ICanvasRaycastFilter 
{
	// Methods

	// RVA: -1
	bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Namespace: UnityEngine
public sealed class CanvasGroup 
{
	// Methods

	// RVA: 0x1797794
	float get_alpha() { }

	// RVA: 0x17977E4
	void set_alpha(float value) { }

	// RVA: 0x179784C
	bool get_interactable() { }

	// RVA: 0x179789C
	void set_interactable(bool value) { }

	// RVA: 0x1797904
	bool get_blocksRaycasts() { }

	// RVA: 0x1797954
	void set_blocksRaycasts(bool value) { }

	// RVA: 0x17979BC
	bool get_ignoreParentGroups() { }

	// RVA: 0x1797A0C
	void set_ignoreParentGroups(bool value) { }

	// RVA: 0x1797A74
	bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

}

// Namespace: UnityEngine
public sealed class CanvasRenderer 
{
	// Fields
	private bool <isMask>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1797AC4
	void set_hasPopInstruction(bool value) { }

	// RVA: 0x1797B2C
	int get_materialCount() { }

	// RVA: 0x1797B7C
	void set_materialCount(int value) { }

	// RVA: 0x1797BE4
	void set_popMaterialCount(int value) { }

	// RVA: 0x1797C4C
	int get_absoluteDepth() { }

	// RVA: 0x1797C9C
	bool get_hasMoved() { }

	// RVA: 0x1797CEC
	bool get_cull() { }

	// RVA: 0x1797D3C
	void set_cull(bool value) { }

	// RVA: 0x1797DA4
	void SetColor(Color color) { }

	// RVA: 0x1797E64
	Color GetColor() { }

	// RVA: 0x1797F28
	void EnableRectClipping(Rect rect) { }

	// RVA: 0x1797FE8
	void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x17980A4
	void DisableRectClipping() { }

	// RVA: 0x17980F4
	void SetMaterial(Material material, int index) { }

	// RVA: 0x179814C
	void SetPopMaterial(Material material, int index) { }

	// RVA: 0x17981A4
	void SetTexture(Texture texture) { }

	// RVA: 0x179820C
	void SetAlphaTexture(Texture texture) { }

	// RVA: 0x1798274
	void SetMesh(Mesh mesh) { }

	// RVA: 0x17982DC
	void Clear() { }

	// RVA: 0x179832C
	void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x17984A8
	void SplitUIVertexStreams(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x179868C
	void CreateUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<System.Int32> indices) { }

	// RVA: 0x17987D4
	void AddUIVertexStream(System.Collections.Generic.List<UnityEngine.UIVertex> verts, System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Color32> colors, System.Collections.Generic.List<UnityEngine.Vector4> uv0S, System.Collections.Generic.List<UnityEngine.Vector4> uv1S, System.Collections.Generic.List<UnityEngine.Vector4> uv2S, System.Collections.Generic.List<UnityEngine.Vector4> uv3S, System.Collections.Generic.List<UnityEngine.Vector3> normals, System.Collections.Generic.List<UnityEngine.Vector4> tangents) { }

	// RVA: 0x1798624
	void SplitIndicesStreamsInternal(object verts, object indices) { }

	// RVA: 0x1798584
	void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	// RVA: 0x1798730
	void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x1797DFC
	void SetColor_Injected(ref Color color) { }

	// RVA: 0x1797EC0
	void GetColor_Injected(out Color ret) { }

	// RVA: 0x1797F80
	void EnableRectClipping_Injected(ref Rect rect) { }

	// RVA: 0x179803C
	void set_clippingSoftness_Injected(ref Vector2 value) { }

}

// Namespace: UnityEngine
public sealed class RectTransformUtility 
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x1798874
	Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x17989A4
	Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x1798AC0
	bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x1798BEC
	bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x1798CC4
	bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x1798E0C
	bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x1799464
	bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x1799264
	Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x179956C
	Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x179964C
	void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x1799970
	void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x1799C10
	Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x1799C20
	void .cctor() { }

	// RVA: 0x179893C
	void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x1798A68
	void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x1798B84
	bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset) { }

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

	// RVA: 0x179B554
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x179B5F4
	internal void Invoke() { }

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

	// RVA: 0x1799CA0
	void add_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x1799D60
	void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x1799E20
	void add_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x1799EE4
	void remove_willRenderCanvases(WillRenderCanvases value) { }

	// RVA: 0x1799FA8
	RenderMode get_renderMode() { }

	// RVA: 0x1799FF8
	void set_renderMode(RenderMode value) { }

	// RVA: 0x179A060
	bool get_isRootCanvas() { }

	// RVA: 0x179A0B0
	Rect get_pixelRect() { }

	// RVA: 0x179A174
	float get_scaleFactor() { }

	// RVA: 0x179A1C4
	void set_scaleFactor(float value) { }

	// RVA: 0x179A22C
	float get_referencePixelsPerUnit() { }

	// RVA: 0x179A27C
	void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x179A2E4
	bool get_overridePixelPerfect() { }

	// RVA: 0x179A334
	void set_overridePixelPerfect(bool value) { }

	// RVA: 0x179A39C
	bool get_vertexColorAlwaysGammaSpace() { }

	// RVA: 0x179A3EC
	void set_vertexColorAlwaysGammaSpace(bool value) { }

	// RVA: 0x179A454
	bool get_pixelPerfect() { }

	// RVA: 0x179A4A4
	void set_pixelPerfect(bool value) { }

	// RVA: 0x179A50C
	float get_planeDistance() { }

	// RVA: 0x179A55C
	void set_planeDistance(float value) { }

	// RVA: 0x179A5C4
	int get_renderOrder() { }

	// RVA: 0x179A614
	bool get_overrideSorting() { }

	// RVA: 0x179A664
	void set_overrideSorting(bool value) { }

	// RVA: 0x179A6CC
	int get_sortingOrder() { }

	// RVA: 0x179A71C
	void set_sortingOrder(int value) { }

	// RVA: 0x179A784
	int get_targetDisplay() { }

	// RVA: 0x179A7D4
	void set_targetDisplay(int value) { }

	// RVA: 0x179A83C
	int get_sortingLayerID() { }

	// RVA: 0x179A88C
	void set_sortingLayerID(int value) { }

	// RVA: 0x179A8F4
	int get_cachedSortingLayerValue() { }

	// RVA: 0x179A944
	AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x179A994
	void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x179A9FC
	string get_sortingLayerName() { }

	// RVA: 0x179AA4C
	void set_sortingLayerName(string value) { }

	// RVA: 0x179AAB4
	Canvas get_rootCanvas() { }

	// RVA: 0x179AB04
	Vector2 get_renderingDisplaySize() { }

	// RVA: 0x179ABC4
	StandaloneRenderResize get_updateRectTransformForStandalone() { }

	// RVA: 0x179AC14
	void set_updateRectTransformForStandalone(StandaloneRenderResize value) { }

	// RVA: 0x179AC7C
	System.Action<System.Int32> get_externBeginRenderOverlays() { }

	// RVA: 0x179ACC8
	void set_externBeginRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x179AD24
	System.Action<System.Int32,System.Int32> get_externRenderOverlaysBefore() { }

	// RVA: 0x179AD70
	void set_externRenderOverlaysBefore(System.Action<System.Int32,System.Int32> value) { }

	// RVA: 0x179ADCC
	System.Action<System.Int32> get_externEndRenderOverlays() { }

	// RVA: 0x179AE18
	void set_externEndRenderOverlays(System.Action<System.Int32> value) { }

	// RVA: 0x179AE74
	void SetExternalCanvasEnabled(bool enabled) { }

	// RVA: 0x179AEC4
	Camera get_worldCamera() { }

	// RVA: 0x179AF14
	void set_worldCamera(Camera value) { }

	// RVA: 0x179AF7C
	float get_normalizedSortingGridSize() { }

	// RVA: 0x179AFCC
	void set_normalizedSortingGridSize(float value) { }

	// RVA: 0x179B034
	int get_sortingGridNormalizedSize() { }

	// RVA: 0x179B084
	void set_sortingGridNormalizedSize(int value) { }

	// RVA: 0x179B0EC
	Material GetDefaultCanvasTextMaterial() { }

	// RVA: 0x179B12C
	Material GetDefaultCanvasMaterial() { }

	// RVA: 0x179B16C
	Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x179B1AC
	void UpdateCanvasRectTransform(bool alignWithCamera) { }

	// RVA: 0x179B214
	void ForceUpdateCanvases() { }

	// RVA: 0x179B2BC
	void SendPreWillRenderCanvases() { }

	// RVA: 0x179B324
	void SendWillRenderCanvases() { }

	// RVA: 0x179B38C
	void BeginRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x179B41C
	void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	// RVA: 0x179B4BC
	void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x179B54C
	void .ctor() { }

	// RVA: 0x179A10C
	void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x179AB5C
	void get_renderingDisplaySize_Injected(out Vector2 ret) { }

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

	// RVA: 0x179B608
	void BeginSample(SampleType type) { }

	// RVA: 0x179B658
	void EndSample(SampleType type) { }

	// RVA: 0x179B6A8
	void AddMarker(string name, object obj) { }

}


