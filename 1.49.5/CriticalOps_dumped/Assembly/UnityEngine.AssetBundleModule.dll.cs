// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public class AssetBundle
{
	// Methods

	// RVA: 0x15A9AF0
	private void .ctor() { }

	// RVA: 0x15A9B78
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x15A9BD0
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	// RVA: 0x15A9C30
	internal static AssetBundle LoadFromFile_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x15A9C88
	public static AssetBundle LoadFromFile(string path) { }

	// RVA: 0x316B894
	public T LoadAsset(string name) { }

	// RVA: 0x15A9CE8
	public object LoadAsset(string name, Type type) { }

	// RVA: 0x15A9E48
	private object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x30B1D84
	public AssetBundleRequest LoadAssetAsync(string name) { }

	// RVA: 0x15A9EA0
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: 0x30B57C8
	internal static T[] ConvertObjects(object[] rawObjects) { }

	// RVA: 0x15AA058
	public object[] LoadAllAssets() { }

	// RVA: 0x30B1CD4
	public T[] LoadAllAssets() { }

	// RVA: 0x15AA0E0
	public object[] LoadAllAssets(Type type) { }

	// RVA: 0x30B1CD4
	public AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: 0x15AA258
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	// RVA: 0x15AA000
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	// RVA: 0x15AA3D0
	public void Unload(bool unloadAllLoadedObjects) { }

	// RVA: 0x15AA438
	public string[] GetAllScenePaths() { }

	// RVA: 0x15AA200
	internal object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

	// RVA: 0x15AA378
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }

}

// Namespace: UnityEngine
public class AssetBundleCreateRequest
{
	// Methods

	// RVA: 0x15AA488
	public AssetBundle get_assetBundle() { }

	// RVA: 0x15AA4D8
	public void .ctor() { }

}

// Namespace: UnityEngine
public class AssetBundleManifest
{
	// Methods

	// RVA: 0x15AA4E0
	public string[] GetAllAssetBundles() { }

	// RVA: 0x15AA530
	public Hash128 GetAssetBundleHash(string assetBundleName) { }

	// RVA: 0x15AA5F0
	public string[] GetDirectDependencies(string assetBundleName) { }

	// RVA: 0x15AA598
	private void GetAssetBundleHash_Injected(string assetBundleName, Hash128 ret) { }

}

// Namespace: UnityEngine
public class AssetBundleRecompressOperation
{}

// Namespace: UnityEngine
public class AssetBundleRequest
{
	// Methods

	// RVA: 0x15AA658
	protected override object GetResult() { }

	// RVA: 0x15AA6A8
	public object get_asset() { }

	// RVA: 0x15AA6B4
	public object[] get_allAssets() { }

	// RVA: 0x15AA704
	public void .ctor() { }

}

// Namespace: UnityEngine
public class AssetBundleUnloadOperation
{}


