// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public class AssetBundle
{
	// Methods

	// RVA: 0x161E9A4
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x161EC80
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	// RVA: 0x161EC8C
	internal static AssetBundle LoadFromFile_Internal(string path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x161EF00
	public static AssetBundle LoadFromFile(string path) { }

	// RVA: 0x26AD93C
	public T LoadAsset(string name) { }

	// RVA: 0x161EF0C
	public object LoadAsset(string name, Type type) { }

	// RVA: 0x161F02C
	private object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x35258B4
	public AssetBundleRequest LoadAssetAsync(string name) { }

	// RVA: 0x161F2C0
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: 0x35293EC
	internal static T[] ConvertObjects(object[] rawObjects) { }

	// RVA: 0x161F67C
	public object[] LoadAllAssets() { }

	// RVA: 0x3525804
	public T[] LoadAllAssets() { }

	// RVA: 0x161F6F8
	public object[] LoadAllAssets(Type type) { }

	// RVA: 0x3525804
	public AssetBundleRequest LoadAllAssetsAsync() { }

	// RVA: 0x161F9D0
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	// RVA: 0x161F3E0
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	// RVA: 0x161FDBC
	public void Unload(bool unloadAllLoadedObjects) { }

	// RVA: 0x161FED4
	public string[] GetAllScenePaths() { }

	// RVA: 0x161F7F0
	internal object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

	// RVA: 0x161FAC8
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }

	// RVA: 0x161EC28
	private static IntPtr LoadFromFileAsync_Internal_Injected(ManagedSpanWrapper path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x161EEA8
	private static IntPtr LoadFromFile_Internal_Injected(ManagedSpanWrapper path, UInt32 crc, UInt64 offset) { }

	// RVA: 0x161F268
	private static IntPtr LoadAsset_Internal_Injected(IntPtr _unity_self, ManagedSpanWrapper name, Type type) { }

	// RVA: 0x161FD64
	private static IntPtr LoadAssetAsync_Internal_Injected(IntPtr _unity_self, ManagedSpanWrapper name, Type type) { }

	// RVA: 0x161FE6C
	private static void Unload_Injected(IntPtr _unity_self, bool unloadAllLoadedObjects) { }

	// RVA: 0x161FF6C
	private static string[] GetAllScenePaths_Injected(IntPtr _unity_self) { }

	// RVA: 0x161FFBC
	private static object[] LoadAssetWithSubAssets_Internal_Injected(IntPtr _unity_self, ManagedSpanWrapper name, Type type) { }

	// RVA: 0x1620014
	private static IntPtr LoadAssetWithSubAssetsAsync_Internal_Injected(IntPtr _unity_self, ManagedSpanWrapper name, Type type) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1620170
	public static AssetBundleCreateRequest ConvertToManaged(IntPtr ptr) { }

	// RVA: 0x16201D8
	public static IntPtr ConvertToNative(AssetBundleCreateRequest assetBundleCreateRequest) { }

}

// Namespace: UnityEngine
public class AssetBundleCreateRequest
{
	// Methods

	// RVA: 0x162006C
	public AssetBundle get_assetBundle() { }

	// RVA: 0x1620168
	private void .ctor(IntPtr ptr) { }

	// RVA: 0x1620118
	private static IntPtr get_assetBundle_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public class AssetBundleManifest
{
	// Methods

	// RVA: 0x16201F4
	public string[] GetAllAssetBundles() { }

	// RVA: 0x16202DC
	public Hash128 GetAssetBundleHash(string assetBundleName) { }

	// RVA: 0x16204FC
	public string[] GetDirectDependencies(string assetBundleName) { }

	// RVA: 0x162028C
	private static string[] GetAllAssetBundles_Injected(IntPtr _unity_self) { }

	// RVA: 0x16204A4
	private static void GetAssetBundleHash_Injected(IntPtr _unity_self, ManagedSpanWrapper assetBundleName, Hash128 ret) { }

	// RVA: 0x16206D4
	private static string[] GetDirectDependencies_Injected(IntPtr _unity_self, ManagedSpanWrapper assetBundleName) { }

}

// Namespace: UnityEngine
public class AssetBundleRecompressOperation
{}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x162090C
	public static AssetBundleRequest ConvertToManaged(IntPtr ptr) { }

	// RVA: 0x1620974
	public static IntPtr ConvertToNative(AssetBundleRequest request) { }

}

// Namespace: UnityEngine
public class AssetBundleRequest
{
	// Methods

	// RVA: 0x162073C
	protected override object GetResult() { }

	// RVA: 0x1620838
	public object get_asset() { }

	// RVA: 0x1620844
	public object[] get_allAssets() { }

	// RVA: 0x1620904
	private void .ctor(IntPtr ptr) { }

	// RVA: 0x16207E8
	private static IntPtr GetResult_Injected(IntPtr _unity_self) { }

	// RVA: 0x16208B4
	private static object[] get_allAssets_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public class AssetBundleUnloadOperation
{}


