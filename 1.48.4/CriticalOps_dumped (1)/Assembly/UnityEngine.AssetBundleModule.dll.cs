// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine
public class AssetBundle 
{
	// Methods

	// RVA: 0x14B7444
	void .ctor() { }

	// RVA: 0x14B74CC
	AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x14B7524
	AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	// RVA: 0x14B7584
	AssetBundle LoadFromFile_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x14B75DC
	AssetBundle LoadFromFile(string path) { }

	// RVA: 0x309AF8C
	T LoadAsset(string name) { }

	// RVA: 0x14B763C
	object LoadAsset(string name, Type type) { }

	// RVA: 0x14B779C
	object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x2FE36BC
	AssetBundleRequest LoadAssetAsync(string name) { }

	// RVA: 0x14B77F4
	AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: 0x2FE7084
	T[] ConvertObjects(object[] rawObjects) { }

	// RVA: 0x14B79AC
	object[] LoadAllAssets() { }

	// RVA: 0x2FE360C
	T[] LoadAllAssets() { }

	// RVA: 0x14B7A34
	object[] LoadAllAssets(Type type) { }

	// RVA: 0x2FE360C
	AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: 0x14B7BAC
	AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	// RVA: 0x14B7954
	AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	// RVA: 0x14B7D24
	void Unload(bool unloadAllLoadedObjects) { }

	// RVA: 0x14B7D8C
	string[] GetAllScenePaths() { }

	// RVA: 0x14B7B54
	object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

	// RVA: 0x14B7CCC
	AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }

}

// Namespace: UnityEngine
public class AssetBundleCreateRequest 
{
	// Methods

	// RVA: 0x14B7DDC
	AssetBundle get_assetBundle() { }

	// RVA: 0x14B7E2C
	void .ctor() { }

}

// Namespace: UnityEngine
public class AssetBundleManifest 
{
	// Methods

	// RVA: 0x14B7E34
	string[] GetAllAssetBundles() { }

	// RVA: 0x14B7E84
	Hash128 GetAssetBundleHash(string assetBundleName) { }

	// RVA: 0x14B7F44
	string[] GetDirectDependencies(string assetBundleName) { }

	// RVA: 0x14B7EEC
	void GetAssetBundleHash_Injected(string assetBundleName, out Hash128 ret) { }

}

// Namespace: UnityEngine
public class AssetBundleRecompressOperation 
{}

// Namespace: UnityEngine
public class AssetBundleRequest 
{
	// Methods

	// RVA: 0x14B7FAC
	object GetResult() { }

	// RVA: 0x14B7FFC
	object get_asset() { }

	// RVA: 0x14B8008
	object[] get_allAssets() { }

	// RVA: 0x14B8058
	void .ctor() { }

}

// Namespace: UnityEngine
public class AssetBundleUnloadOperation 
{}


