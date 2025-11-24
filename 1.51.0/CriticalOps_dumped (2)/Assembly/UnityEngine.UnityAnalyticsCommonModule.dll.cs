// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Analytics
[Serializable]
public class SubsystemsAnalyticBase
{
	// Fields
	public string subsystem; // 0x30

	// Methods

	// RVA: 0x1A522E0
	public void .ctor(string eventName) { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
public class SubsystemsAnalyticStart
{
	// Methods

	// RVA: 0x1A52348
	public void .ctor() { }

	// RVA: 0x1A523D8
	internal static SubsystemsAnalyticStart CreateSubsystemsAnalyticStart() { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
public class SubsystemsAnalyticStop
{
	// Methods

	// RVA: 0x1A524A0
	public void .ctor() { }

	// RVA: 0x1A52530
	internal static SubsystemsAnalyticStop CreateSubsystemsAnalyticStop() { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
public class SubsystemsAnalyticInfo
{
	// Fields
	private string id; // 0x38
	private string plugin_name; // 0x40
	private string version; // 0x48
	private string library_name; // 0x50

	// Methods

	// RVA: 0x1A525F8
	public void .ctor() { }

	// RVA: 0x1A52688
	internal static SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo() { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
public class VRDeviceAnalyticBase
{
	// Methods

	// RVA: 0x1A52750
	public void .ctor() { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
public class VRDeviceAnalyticAspect
{
	// Fields
	public float vr_aspect_ratio; // 0x2C

	// Methods

	// RVA: 0x1A527C8
	internal static VRDeviceAnalyticAspect CreateVRDeviceAnalyticAspect() { }

	// RVA: 0x1A52878
	public void .ctor() { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
public class VRDeviceMirrorAnalytic
{
	// Fields
	public bool vr_device_mirror_mode; // 0x2C

	// Methods

	// RVA: 0x1A528F0
	internal static VRDeviceMirrorAnalytic CreateVRDeviceMirrorAnalytic() { }

	// RVA: 0x1A529A0
	public void .ctor() { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
public class VRDeviceUserAnalytic
{
	// Fields
	public int vr_user_presence; // 0x2C

	// Methods

	// RVA: 0x1A52A18
	internal static VRDeviceUserAnalytic CreateVRDeviceUserAnalytic() { }

	// RVA: 0x1A52AC8
	public void .ctor() { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
public class VRDeviceActiveControllersAnalytic
{
	// Fields
	public string[] vr_active_controllers; // 0x30

	// Methods

	// RVA: 0x1A52B40
	internal static VRDeviceActiveControllersAnalytic CreateVRDeviceActiveControllersAnalytic() { }

	// RVA: 0x1A52BF0
	public void .ctor() { }

}

// Namespace: UnityEngine.Analytics
public enum AnalyticsResult
{
	// Fields
	public int value__; // 0x10
	public const AnalyticsResult Ok = 0;
	public const AnalyticsResult NotInitialized = 1;
	public const AnalyticsResult AnalyticsDisabled = 2;
	public const AnalyticsResult TooManyItems = 3;
	public const AnalyticsResult SizeLimitReached = 4;
	public const AnalyticsResult TooManyRequests = 5;
	public const AnalyticsResult InvalidData = 6;
	public const AnalyticsResult UnsupportedPlatform = 7;
}

// Namespace: UnityEditor.Analytics
[Serializable]
public class AssetDatabaseRefreshAnalytic
{
	// Fields
	public bool isV2; // 0x2C
	public Int64 Imports_Imported; // 0x30
	public Int64 Imports_ImportedInProcess; // 0x38
	public Int64 Imports_ImportedOutOfProcess; // 0x40
	public Int64 Imports_Refresh; // 0x48
	public Int64 Imports_DomainReload; // 0x50
	public Int64 CacheServer_MetadataRequested; // 0x58
	public Int64 CacheServer_MetadataDownloaded; // 0x60
	public Int64 CacheServer_MetadataFailedToDownload; // 0x68
	public Int64 CacheServer_MetadataUploaded; // 0x70
	public Int64 CacheServer_ArtifactsFailedToUpload; // 0x78
	public Int64 CacheServer_MetadataVersionsDownloaded; // 0x80
	public Int64 CacheServer_MetadataMatched; // 0x88
	public Int64 CacheServer_ArtifactsDownloaded; // 0x90
	public Int64 CacheServer_ArtifactFilesDownloaded; // 0x98
	public Int64 CacheServer_ArtifactFilesFailedToDownload; // 0xA0
	public Int64 CacheServer_ArtifactsUploaded; // 0xA8
	public Int64 CacheServer_ArtifactFilesUploaded; // 0xB0
	public Int64 CacheServer_ArtifactFilesFailedToUpload; // 0xB8
	public Int64 CacheServer_Connects; // 0xC0
	public Int64 CacheServer_Disconnects; // 0xC8

	// Methods

	// RVA: 0x1A52C68
	public void .ctor() { }

	// RVA: 0x1A52CE0
	internal static AssetDatabaseRefreshAnalytic CreateAssetDatabaseRefreshAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class BuildAssetBundleAnalytic
{
	// Fields
	public bool success; // 0x2C
	public string error; // 0x30

	// Methods

	// RVA: 0x1A52D90
	public void .ctor() { }

	// RVA: 0x1A52E08
	internal static BuildAssetBundleAnalytic CreateBuildAssetBundleAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class CollabOperationAnalytic
{
	// Fields
	public string category; // 0x30
	public string operation; // 0x38
	public string result; // 0x40
	public Int64 start_ts; // 0x48
	public Int64 duration; // 0x50

	// Methods

	// RVA: 0x1A52EB8
	public void .ctor() { }

	// RVA: 0x1A52F30
	internal static CollabOperationAnalytic CreateCollabOperationAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class LicensingErrorAnalytic
{
	// Fields
	public string licensingErrorType; // 0x30
	public string additionalData; // 0x38
	public string errorMessage; // 0x40
	public string correlationId; // 0x48
	public string sessionId; // 0x50

	// Methods

	// RVA: 0x1A52FE0
	public void .ctor() { }

	// RVA: 0x1A53058
	internal static LicensingErrorAnalytic CreateLicensingErrorAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class LicensingInitAnalytic
{
	// Fields
	public string licensingProtocolVersion; // 0x30
	public string licensingClientVersion; // 0x38
	public string channelType; // 0x40
	public Double initTime; // 0x48
	public bool isLegacy; // 0x50
	public string sessionId; // 0x58
	public string correlationId; // 0x60

	// Methods

	// RVA: 0x1A53108
	public void .ctor() { }

	// RVA: 0x1A53180
	internal static LicensingInitAnalytic CreateLicensingInitAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class MetalPatchShaderComputeBufferAnalytic
{
	// Methods

	// RVA: 0x1A53230
	public void .ctor() { }

	// RVA: 0x1A532A8
	internal static MetalPatchShaderComputeBufferAnalytic CreateMetalPatchShaderComputeBufferAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class NavmeshBakingAnalytic
{
	// Fields
	private bool new_nav_api; // 0x2C
	private bool bake_at_runtime; // 0x2D
	private int height_meshes_count; // 0x30
	private int offmesh_links_count; // 0x34

	// Methods

	// RVA: 0x1A53358
	public void .ctor() { }

	// RVA: 0x1A533D0
	internal static NavmeshBakingAnalytic CreateNavmeshBakingAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class ProjectSettingsInformationAnalytic
{
	// Fields
	private int agent_types_count; // 0x2C
	private int areas_count; // 0x30

	// Methods

	// RVA: 0x1A53480
	public void .ctor() { }

	// RVA: 0x1A534F8
	internal static ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class SendGameBuildAnalytic
{
	// Fields
	private int navmesh_count; // 0x2C

	// Methods

	// RVA: 0x1A535A8
	public void .ctor() { }

	// RVA: 0x1A53620
	internal static SendGameBuildAnalytic CreateSendGameBuildAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class PackageManagerBaseAnalytic
{
	// Fields
	public Int64 start_ts; // 0x30
	public Int64 duration; // 0x38
	public bool blocking; // 0x40
	public string package_id; // 0x48
	public int status_code; // 0x50
	public string error_message; // 0x58

	// Methods

	// RVA: 0x1A536D0
	public void .ctor(string eventName) { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class PackageManagerAddPackageAnalytic
{
	// Methods

	// RVA: 0x1A53738
	public void .ctor() { }

	// RVA: 0x1A537C8
	internal static PackageManagerAddPackageAnalytic CreatePackageManagerAddPackageAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class PackageManagerTestAnalytic
{
	// Methods

	// RVA: 0x1A53890
	public void .ctor() { }

	// RVA: 0x1A53920
	internal static PackageManagerTestAnalytic CreatePackageManagerTestAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class PackageManagerRemovePackageAnalytic
{
	// Methods

	// RVA: 0x1A539E8
	public void .ctor() { }

	// RVA: 0x1A53A78
	internal static PackageManagerRemovePackageAnalytic CreatePackageManagerRemovePackageAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class PackageManagerResolvePackageAnalytic
{
	// Fields
	public string[] packages; // 0x60
	public string[] package_registries; // 0x68
	public string[] package_signatures; // 0x70
	public string[] package_sources; // 0x78
	public string[] package_types; // 0x80
	public string[] package_compliance_statuses; // 0x88

	// Methods

	// RVA: 0x1A53B40
	public void .ctor() { }

	// RVA: 0x1A53BD0
	internal static PackageManagerResolvePackageAnalytic CreatePackageManagerResolvePackageAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class PackageManagerEmbedPackageAnalytic
{
	// Methods

	// RVA: 0x1A53C98
	public void .ctor() { }

	// RVA: 0x1A53D28
	internal static PackageManagerEmbedPackageAnalytic CreatePackageManagerEmbedPackageAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class PackageManagerResetPackageAnalytic
{
	// Methods

	// RVA: 0x1A53DF0
	public void .ctor() { }

	// RVA: 0x1A53E80
	internal static PackageManagerResetPackageAnalytic CreatePackageManagerResetPackageAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class PackageManagerResolveErrorPackageAnalytic
{
	// Fields
	public string reason; // 0x60
	public string action; // 0x68

	// Methods

	// RVA: 0x1A53F48
	public void .ctor() { }

	// RVA: 0x1A53FD8
	internal static PackageManagerResolveErrorPackageAnalytic CreatePackageManagerResolveErrorPackageAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class PackageManagerStartServerPackageAnalytic
{
	// Methods

	// RVA: 0x1A540A0
	public void .ctor() { }

	// RVA: 0x1A54130
	internal static PackageManagerStartServerPackageAnalytic CreatePackageManagerStartServerPackageAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
internal class AssetImportStatusAnalytic
{
	// Fields
	public string package_name; // 0x30
	public int package_items_count; // 0x38
	public int package_import_status; // 0x3C
	public string error_message; // 0x40
	public int project_assets_count; // 0x48
	public int unselected_assets_count; // 0x4C
	public int selected_new_assets_count; // 0x50
	public int selected_changed_assets_count; // 0x54
	public int unchanged_assets_count; // 0x58
	public string[] selected_asset_extensions; // 0x60

	// Methods

	// RVA: 0x1A541F8
	public void .ctor() { }

	// RVA: 0x1A54270
	public static AssetImportStatusAnalytic CreateAssetImportStatusAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
internal class AssetImportAnalytic
{
	// Fields
	public string package_name; // 0x30
	public int package_import_choice; // 0x38

	// Methods

	// RVA: 0x1A54320
	public void .ctor() { }

	// RVA: 0x1A54398
	public static AssetImportAnalytic CreateAssetImportAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
internal class AssetExportAnalytic
{
	// Fields
	public string package_name; // 0x30
	public string error_message; // 0x38
	public int items_count; // 0x40
	public string[] asset_extensions; // 0x48
	public bool include_upm_dependencies; // 0x50

	// Methods

	// RVA: 0x1A54448
	public void .ctor() { }

	// RVA: 0x1A544C0
	public static AssetExportAnalytic CreateAssetExportAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class StallSummaryAnalytic
{
	// Fields
	public Double Duration; // 0x30

	// Methods

	// RVA: 0x1A54570
	public void .ctor() { }

	// RVA: 0x1A545E8
	internal static StallSummaryAnalytic CreateStallSummaryAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
internal class StallMarkerAnalytic
{
	// Fields
	public string Name; // 0x30
	public bool HasProgressMarkup; // 0x38
	public Double Duration; // 0x40

	// Methods

	// RVA: 0x1A54698
	public void .ctor() { }

	// RVA: 0x1A54710
	internal static StallMarkerAnalytic CreateStallMarkerAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
internal class TestAnalytic
{
	// Fields
	public int param; // 0x2C

	// Methods

	// RVA: 0x1A547C0
	public void .ctor() { }

	// RVA: 0x1A54838
	public static TestAnalytic CreateTestAnalytic() { }

}

// Namespace: UnityEditor.Analytics
[Serializable]
public class VCProviderAnalytics
{
	// Fields
	public string Mode; // 0x30

	// Methods

	// RVA: 0x1A548E8
	public void .ctor() { }

	// RVA: 0x1A54960
	internal static VCProviderAnalytics CreateVCProviderAnalytics() { }

}


