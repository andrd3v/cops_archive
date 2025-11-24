// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public class AssetBundle
{
	// Methods

	// RVA: 0x159A7C0
	private void .ctor() { }

	// RVA: 0x159A848
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x159A8A0
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	// RVA: 0x159A900
	internal static AssetBundle LoadFromFile_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x159A958
	public static AssetBundle LoadFromFile(string path) { }

	// RVA: 0x315B3A8
	public T LoadAsset(string name) { }

	// RVA: 0x159A9B8
	public object LoadAsset(string name, Type type) { }

	// RVA: 0x159AB18
	private object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x30A188C
	public AssetBundleRequest LoadAssetAsync(string name) { }

	// RVA: 0x159AB70
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: 0x30A52D0
	internal static T[] ConvertObjects(object[] rawObjects) { }

	// RVA: 0x159AD28
	public object[] LoadAllAssets() { }

	// RVA: 0x30A17DC
	public T[] LoadAllAssets() { }

	// RVA: 0x159ADB0
	public object[] LoadAllAssets(Type type) { }

	// RVA: 0x30A17DC
	public AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: 0x159AF28
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	// RVA: 0x159ACD0
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	// RVA: 0x159B0A0
	public void Unload(bool unloadAllLoadedObjects) { }

	// RVA: 0x159B108
	public string[] GetAllScenePaths() { }

	// RVA: 0x159AED0
	internal object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

	// RVA: 0x159B048
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }

}

// Namespace: UnityEngine
public class AssetBundleCreateRequest
{
	// Methods

	// RVA: 0x159B158
	public AssetBundle get_assetBundle() { }

	// RVA: 0x159B1A8
	public void .ctor() { }

}

// Namespace: UnityEngine
public class AssetBundleManifest
{
	// Methods

	// RVA: 0x159B1B0
	public string[] GetAllAssetBundles() { }

	// RVA: 0x159B200
	public Hash128 GetAssetBundleHash(string assetBundleName) { }

	// RVA: 0x159B2C0
	public string[] GetDirectDependencies(string assetBundleName) { }

	// RVA: 0x159B268
	private void GetAssetBundleHash_Injected(string assetBundleName, Hash128 ret) { }

}

// Namespace: UnityEngine
public class AssetBundleRecompressOperation
{}

// Namespace: UnityEngine
public class AssetBundleRequest
{
	// Methods

	// RVA: 0x159B328
	protected override object GetResult() { }

	// RVA: 0x159B378
	public object get_asset() { }

	// RVA: 0x159B384
	public object[] get_allAssets() { }

	// RVA: 0x159B3D4
	public void .ctor() { }

}

// Namespace: UnityEngine
public class AssetBundleUnloadOperation
{}


