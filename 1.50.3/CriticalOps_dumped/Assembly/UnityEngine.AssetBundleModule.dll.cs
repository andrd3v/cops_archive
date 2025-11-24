// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public class AssetBundle
{
	// Methods

	// RVA: 0x15CCCB8
	private void .ctor() { }

	// RVA: 0x15CCD40
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x15CCD98
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	// RVA: 0x15CCDF8
	internal static AssetBundle LoadFromFile_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x15CCE50
	public static AssetBundle LoadFromFile(string path) { }

	// RVA: 0x318DB98
	public T LoadAsset(string name) { }

	// RVA: 0x15CCEB0
	public object LoadAsset(string name, Type type) { }

	// RVA: 0x15CD010
	private object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x30D3DA0
	public AssetBundleRequest LoadAssetAsync(string name) { }

	// RVA: 0x15CD068
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: 0x30D77E4
	internal static T[] ConvertObjects(object[] rawObjects) { }

	// RVA: 0x15CD220
	public object[] LoadAllAssets() { }

	// RVA: 0x30D3CF0
	public T[] LoadAllAssets() { }

	// RVA: 0x15CD2A8
	public object[] LoadAllAssets(Type type) { }

	// RVA: 0x30D3CF0
	public AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: 0x15CD420
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	// RVA: 0x15CD1C8
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	// RVA: 0x15CD598
	public void Unload(bool unloadAllLoadedObjects) { }

	// RVA: 0x15CD600
	public string[] GetAllScenePaths() { }

	// RVA: 0x15CD3C8
	internal object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

	// RVA: 0x15CD540
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }

}

// Namespace: UnityEngine
public class AssetBundleCreateRequest
{
	// Methods

	// RVA: 0x15CD650
	public AssetBundle get_assetBundle() { }

	// RVA: 0x15CD6A0
	public void .ctor() { }

}

// Namespace: UnityEngine
public class AssetBundleManifest
{
	// Methods

	// RVA: 0x15CD6A8
	public string[] GetAllAssetBundles() { }

	// RVA: 0x15CD6F8
	public Hash128 GetAssetBundleHash(string assetBundleName) { }

	// RVA: 0x15CD7B8
	public string[] GetDirectDependencies(string assetBundleName) { }

	// RVA: 0x15CD760
	private void GetAssetBundleHash_Injected(string assetBundleName, Hash128 ret) { }

}

// Namespace: UnityEngine
public class AssetBundleRecompressOperation
{}

// Namespace: UnityEngine
public class AssetBundleRequest
{
	// Methods

	// RVA: 0x15CD820
	protected override object GetResult() { }

	// RVA: 0x15CD870
	public object get_asset() { }

	// RVA: 0x15CD87C
	public object[] get_allAssets() { }

	// RVA: 0x15CD8CC
	public void .ctor() { }

}

// Namespace: UnityEngine
public class AssetBundleUnloadOperation
{}


