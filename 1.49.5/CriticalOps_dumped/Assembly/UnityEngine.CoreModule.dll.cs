// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x15AED94
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsUnmanagedAttribute
{
	// Methods

	// RVA: 0x15AED9C
	public void .ctor() { }

}

// Namespace: AOT
public class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0x15AEDA4
	public void .ctor(Type type) { }

}

// Namespace: UnityEngineInternal
internal enum LightmapType
{
	// Fields
	public int value__; // 0x10
	public const LightmapType NoLightmap = 4294967295;
	public const LightmapType StaticLightmap = 0;
	public const LightmapType DynamicLightmap = 1;
}

// Namespace: UnityEngineInternal
public struct MathfInternal
{
	// Fields
	public static float FloatMinNormal; // 0x0
	public static float FloatMinDenormal; // 0x4
	public static bool IsFlushToZeroEnabled; // 0x8

	// Methods

	// RVA: 0x15AEDAC
	private static void .cctor() { }

}

// Namespace: UnityEngineInternal
public enum TypeInferenceRules
{
	// Fields
	public int value__; // 0x10
	public const TypeInferenceRules TypeReferencedByFirstArgument = 0;
	public const TypeInferenceRules TypeReferencedBySecondArgument = 1;
	public const TypeInferenceRules ArrayOfTypeReferencedByFirstArgument = 2;
	public const TypeInferenceRules TypeOfFirstArgument = 3;
}

// Namespace: UnityEngineInternal
[Serializable]
public class TypeInferenceRuleAttribute
{
	// Fields
	private readonly string _rule; // 0x10

	// Methods

	// RVA: 0x15AEE18
	public void .ctor(TypeInferenceRules rule) { }

	// RVA: 0x15AEEAC
	public void .ctor(string rule) { }

	// RVA: 0x15AEEE0
	public override string ToString() { }

}

// Namespace: UnityEngineInternal
public class GenericStack
{
	// Methods

	// RVA: 0x15AEEE8
	public void .ctor() { }

}

// Namespace: Unity.Jobs
public interface IJob
{
	// Methods

	// RVA: -1
	public abstract void Execute() { }

}

// Namespace: 
internal sealed class ExecuteJobFunction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: -1
	public virtual void Invoke(T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex) { }

}

// Namespace: 
internal struct JobStruct<T0>
{
	// Fields
	internal static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr> jobReflectionData; // 0x0

	// Methods

	// RVA: 0x30B71FC
	internal static void Initialize() { }

	// RVA: 0x30B9014
	public static void Execute(T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex) { }

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: Unity.Jobs
public static class IJobExtensions
{
	// Methods

	// RVA: 0x30B71FC
	public static void EarlyJobInit() { }

}

// Namespace: Unity.Jobs
public interface IJobParallelFor
{
	// Methods

	// RVA: -1
	public abstract void Execute(int index) { }

}

// Namespace: 
public sealed class ExecuteJobFunction
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: -1
	public virtual void Invoke(T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex) { }

}

// Namespace: 
internal struct ParallelForJobStruct<T0>
{
	// Fields
	internal static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr> jobReflectionData; // 0x0

	// Methods

	// RVA: 0x30B71FC
	internal static void Initialize() { }

	// RVA: 0x30B9014
	public static void Execute(T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex) { }

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: Unity.Jobs
public static class IJobParallelForExtensions
{
	// Methods

	// RVA: 0x30B5338
	private static IntPtr GetReflectionData() { }

	// RVA: 0x316B894
	public static JobHandle Schedule(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }

}

// Namespace: Unity.Jobs
public struct JobHandle
{
	// Fields
	internal UInt64 jobGroup; // 0x10
	internal int version; // 0x18

	// Methods

	// RVA: 0x15AEEF0
	public void Complete() { }

	// RVA: 0x15AEFA4
	public static void ScheduleBatchedJobs() { }

	// RVA: 0x15AEF54
	private static void ScheduleBatchedJobsAndComplete(JobHandle job) { }

	// RVA: 0x15AEFE4
	public static JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs) { }

	// RVA: 0x15AF0F0
	public static JobHandle CombineDependencies(Unity.Collections.NativeSlice<Unity.Jobs.JobHandle> jobs) { }

	// RVA: 0x15AF088
	internal static JobHandle CombineDependenciesInternalPtr(Void* jobs, int count) { }

	// RVA: 0x15AF21C
	public bool Equals(JobHandle other) { }

	// RVA: 0x15AF1C4
	private static void CombineDependenciesInternalPtr_Injected(Void* jobs, int count, JobHandle ret) { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public sealed class JobProducerTypeAttribute
{
	// Fields
	private readonly Type <ProducerType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15AF22C
	public void .ctor(Type producerType) { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public struct JobRanges
{
	// Fields
	internal int BatchSize; // 0x10
	internal int NumJobs; // 0x14
	public int TotalIterationCount; // 0x18
	internal IntPtr StartEndIndex; // 0x20
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public enum ScheduleMode
{
	// Fields
	public int value__; // 0x10
	public const ScheduleMode Run = 0;
	public const ScheduleMode Batched = 1;
	public const ScheduleMode Parallel = 1;
	public const ScheduleMode Single = 2;
}

// Namespace: 
public struct JobScheduleParameters
{
	// Fields
	public JobHandle Dependency; // 0x10
	public int ScheduleMode; // 0x20
	public IntPtr ReflectionData; // 0x28
	public IntPtr JobDataPtr; // 0x30

	// Methods

	// RVA: 0x15AF4E4
	public void .ctor(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

// Namespace: 
internal sealed class PanicFunction_
{
	// Methods

	// RVA: 0x15AF528
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15AF5C8
	public virtual void Invoke() { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public static class JobsUtility
{
	// Fields
	internal static PanicFunction_ PanicFunction; // 0x0

	// Methods

	// RVA: 0x15AF260
	public static bool GetWorkStealingRange(JobRanges ranges, int jobIndex, int beginIndex, int endIndex) { }

	// RVA: 0x15AF2C8
	public static JobHandle ScheduleParallelFor(JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	// RVA: 0x15AF3A0
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x15AF410
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x15AF47C
	private static void InvokePanicFunction() { }

	// RVA: 0x15AF338
	private static void ScheduleParallelFor_Injected(JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, JobHandle ret) { }

}

// Namespace: Unity.IL2CPP.CompilerServices
internal class Il2CppEagerStaticClassConstructionAttribute
{
	// Methods

	// RVA: 0x15AF5DC
	public void .ctor() { }

}

// Namespace: Unity.Profiling
public sealed class IgnoredByDeepProfilerAttribute
{
	// Methods

	// RVA: 0x15AF5E4
	public void .ctor() { }

}

// Namespace: Unity.Profiling
public struct ProfilerCategory
{
	// Fields
	private readonly UInt16 m_CategoryId; // 0x10

	// Methods

	// RVA: 0x15AF5EC
	internal void .ctor(UInt16 category) { }

	// RVA: 0x15AF5F4
	public string get_Name() { }

	// RVA: 0x15AF810
	public override string ToString() { }

	// RVA: 0x15AF8A0
	public static ProfilerCategory get_Scripts() { }

	// RVA: 0x15AF8A8
	public static UInt16 op_Implicit(ProfilerCategory category) { }

}

// Namespace: Unity.Profiling
public enum ProfilerCategoryColor
{
	// Fields
	public UInt16 value__; // 0x10
	public const ProfilerCategoryColor Render = 0;
	public const ProfilerCategoryColor Scripts = 1;
	public const ProfilerCategoryColor BurstJobs = 2;
	public const ProfilerCategoryColor Other = 3;
	public const ProfilerCategoryColor Physics = 4;
	public const ProfilerCategoryColor Animation = 5;
	public const ProfilerCategoryColor Audio = 6;
	public const ProfilerCategoryColor AudioJob = 7;
	public const ProfilerCategoryColor AudioUpdateJob = 8;
	public const ProfilerCategoryColor Lighting = 9;
	public const ProfilerCategoryColor GC = 10;
	public const ProfilerCategoryColor VSync = 11;
	public const ProfilerCategoryColor Memory = 12;
	public const ProfilerCategoryColor Internal = 13;
	public const ProfilerCategoryColor UI = 14;
	public const ProfilerCategoryColor Build = 15;
	public const ProfilerCategoryColor Input = 16;
}

// Namespace: 
public struct AutoScope
{
	// Fields
	internal readonly IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15AFB78
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x15AFBEC
	public void Dispose() { }

}

// Namespace: Unity.Profiling
public struct ProfilerMarker
{
	// Fields
	internal readonly IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15AF8B0
	public void .ctor(string name) { }

	// RVA: 0x15AF978
	public void .ctor(ProfilerCategory category, string name) { }

	// RVA: 0x15AF9DC
	public void Begin() { }

	// RVA: 0x15AFA7C
	public void End() { }

	// RVA: 0x15AFB1C
	public AutoScope Auto() { }

}

// Namespace: Unity.Profiling
public enum ProfilerCounterOptions
{
	// Fields
	public UInt16 value__; // 0x10
	public const ProfilerCounterOptions None = 0;
	public const ProfilerCounterOptions FlushOnEndOfFrame = 2;
	public const ProfilerCounterOptions ResetToZeroOnFlush = 4;
}

// Namespace: Unity.Profiling
public struct DebugScreenCapture
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> <RawImageDataReference>k__BackingField; // 0x10
	private TextureFormat <ImageFormat>k__BackingField; // 0x20
	private int <Width>k__BackingField; // 0x24
	private int <Height>k__BackingField; // 0x28

	// Methods

	// RVA: 0x15AFC60
	public void set_RawImageDataReference(Unity.Collections.NativeArray<System.Byte> value) { }

	// RVA: 0x15AFC68
	public void set_ImageFormat(TextureFormat value) { }

	// RVA: 0x15AFC70
	public void set_Width(int value) { }

	// RVA: 0x15AFC78
	public void set_Height(int value) { }

}

// Namespace: Unity.Profiling.LowLevel
public enum MarkerFlags
{
	// Fields
	public UInt16 value__; // 0x10
	public const MarkerFlags Default = 0;
	public const MarkerFlags Script = 2;
	public const MarkerFlags ScriptInvoke = 32;
	public const MarkerFlags ScriptDeepProfiler = 64;
	public const MarkerFlags AvailabilityEditor = 4;
	public const MarkerFlags AvailabilityNonDevelopment = 8;
	public const MarkerFlags Warning = 16;
	public const MarkerFlags Counter = 128;
	public const MarkerFlags SampleGPU = 256;
}

// Namespace: Unity.Profiling.LowLevel.Unsafe
public struct ProfilerCategoryDescription
{
	// Fields
	public readonly UInt16 Id; // 0x10
	public readonly UInt16 Flags; // 0x12
	public readonly Color32 Color; // 0x14
	private readonly int reserved0; // 0x18
	public readonly int NameUtf8Len; // 0x1C
	public readonly Byte* NameUtf8; // 0x20
}

// Namespace: Unity.Profiling.LowLevel.Unsafe
public static class ProfilerUnsafeUtility
{
	// Methods

	// RVA: 0x15AFC80
	internal static UInt16 CreateCategory__Unmanaged(Byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	// RVA: 0x15AF684
	public static ProfilerCategoryDescription GetCategoryDescription(UInt16 categoryId) { }

	// RVA: 0x15AF910
	public static IntPtr CreateMarker(string name, UInt16 categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x15AFD40
	internal static IntPtr CreateMarker__Unmanaged(Byte* name, int nameLen, UInt16 categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x15AFDB0
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, Byte* name, int nameLen, Byte type, Byte unit) { }

	// RVA: 0x15AFA2C
	public static void BeginSample(IntPtr markerPtr) { }

	// RVA: 0x15AFACC
	public static void EndSample(IntPtr markerPtr) { }

	// RVA: 0x15AFE30
	internal static Void* CreateCounterValue__Unmanaged(IntPtr counterPtr, Byte* name, int nameLen, UInt16 categoryId, MarkerFlags flags, Byte dataType, Byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	// RVA: 0x15AF724
	internal static string Utf8ToString(Byte* chars, int charsLen) { }

	// RVA: 0x15AFCD8
	private static void GetCategoryDescription_Injected(UInt16 categoryId, ProfilerCategoryDescription ret) { }

}

// Namespace: Unity.Profiling.Memory
public class MemorySnapshotMetadata
{
	// Fields
	private string <Description>k__BackingField; // 0x10
	private Byte[] <Data>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15AFED0
	public string get_Description() { }

	// RVA: 0x15AFED8
	public void set_Description(string value) { }

	// RVA: 0x15AFEE0
	internal Byte[] get_Data() { }

	// RVA: 0x15AFEE8
	public void .ctor() { }

}

// Namespace: Unity.Profiling.Memory
public static class MemoryProfiler
{
	// Fields
	private static System.Action<System.String,System.Boolean> m_SnapshotFinished; // 0x0
	private static System.Action<System.String,System.Boolean,Unity.Profiling.DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	private static System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> CreatingMetadata; // 0x10

	// Methods

	// RVA: 0x15AFEF0
	private static Byte[] PrepareMetadata() { }

	// RVA: 0x15B01F0
	internal static int WriteIntToByteArray(Byte[] array, int offset, int value) { }

	// RVA: 0x15B0288
	internal static int WriteStringToByteArray(Byte[] array, int offset, string value) { }

	// RVA: 0x15B038C
	private static void FinalizeSnapshot(string path, bool result) { }

	// RVA: 0x15B0424
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum FileState
{
	// Fields
	public int value__; // 0x10
	public const FileState Absent = 0;
	public const FileState Exists = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum AssetLoadingSubsystem
{
	// Fields
	public int value__; // 0x10
	public const AssetLoadingSubsystem Other = 0;
	public const AssetLoadingSubsystem Texture = 1;
	public const AssetLoadingSubsystem VirtualTexture = 2;
	public const AssetLoadingSubsystem Mesh = 3;
	public const AssetLoadingSubsystem Audio = 4;
	public const AssetLoadingSubsystem Scripts = 5;
	public const AssetLoadingSubsystem EntitiesScene = 6;
	public const AssetLoadingSubsystem EntitiesStreamBinaryReader = 7;
	public const AssetLoadingSubsystem FileInfo = 8;
	public const AssetLoadingSubsystem ContentLoading = 9;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum Priority
{
	// Fields
	public int value__; // 0x10
	public const Priority PriorityLow = 0;
	public const Priority PriorityHigh = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum ProcessingState
{
	// Fields
	public int value__; // 0x10
	public const ProcessingState Unknown = 0;
	public const ProcessingState InQueue = 1;
	public const ProcessingState Reading = 2;
	public const ProcessingState Completed = 3;
	public const ProcessingState Failed = 4;
	public const ProcessingState Canceled = 5;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum FileReadType
{
	// Fields
	public int value__; // 0x10
	public const FileReadType Sync = 0;
	public const FileReadType Async = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public struct AsyncReadManagerRequestMetric
{
	// Fields
	private readonly string <AssetName>k__BackingField; // 0x10
	private readonly string <FileName>k__BackingField; // 0x18
	private readonly UInt64 <OffsetBytes>k__BackingField; // 0x20
	private readonly UInt64 <SizeBytes>k__BackingField; // 0x28
	private readonly UInt64 <AssetTypeId>k__BackingField; // 0x30
	private readonly UInt64 <CurrentBytesRead>k__BackingField; // 0x38
	private readonly UInt32 <BatchReadCount>k__BackingField; // 0x40
	private readonly bool <IsBatchRead>k__BackingField; // 0x44
	private readonly ProcessingState <State>k__BackingField; // 0x48
	private readonly FileReadType <ReadType>k__BackingField; // 0x4C
	private readonly Priority <PriorityLevel>k__BackingField; // 0x50
	private readonly AssetLoadingSubsystem <Subsystem>k__BackingField; // 0x54
	private readonly Double <RequestTimeMicroseconds>k__BackingField; // 0x58
	private readonly Double <TimeInQueueMicroseconds>k__BackingField; // 0x60
	private readonly Double <TotalTimeMicroseconds>k__BackingField; // 0x68
}

// Namespace: Unity.IO.LowLevel.Unsafe
public class AsyncReadManagerMetricsFilters
{
	// Fields
	internal UInt64[] TypeIDs; // 0x10
	internal ProcessingState[] States; // 0x18
	internal FileReadType[] ReadTypes; // 0x20
	internal Priority[] PriorityLevels; // 0x28
	internal AssetLoadingSubsystem[] Subsystems; // 0x30
}

// Namespace: Unity.IO.Archive
public enum ArchiveStatus
{
	// Fields
	public int value__; // 0x10
	public const ArchiveStatus InProgress = 0;
	public const ArchiveStatus Complete = 1;
	public const ArchiveStatus Failed = 2;
}

// Namespace: Unity.IO.Archive
public struct ArchiveFileInfo
{
	// Fields
	public string Filename; // 0x10
	public UInt64 FileSize; // 0x18
}

// Namespace: Unity.IO.Archive
public struct ArchiveHandle
{
	// Fields
	internal UInt64 Handle; // 0x10
}

// Namespace: Unity.IO.Archive
public static class ArchiveFileInterface
{}

// Namespace: Unity.Collections
public sealed class ReadOnlyAttribute
{}

// Namespace: Unity.Collections
public sealed class WriteOnlyAttribute
{}

// Namespace: Unity.Collections
public sealed class DeallocateOnJobCompletionAttribute
{}

// Namespace: Unity.Collections
public sealed class NativeFixedLengthAttribute
{}

// Namespace: Unity.Collections
public sealed class NativeMatchesParallelForLengthAttribute
{}

// Namespace: Unity.Collections
public sealed class NativeDisableParallelForRestrictionAttribute
{}

// Namespace: Unity.Collections
public enum Allocator
{
	// Fields
	public int value__; // 0x10
	public const Allocator Invalid = 0;
	public const Allocator None = 1;
	public const Allocator Temp = 2;
	public const Allocator TempJob = 3;
	public const Allocator Persistent = 4;
	public const Allocator AudioKernel = 5;
	public const Allocator FirstUserIndex = 64;
}

// Namespace: Unity.Collections
public enum NativeArrayOptions
{
	// Fields
	public int value__; // 0x10
	public const NativeArrayOptions UninitializedMemory = 0;
	public const NativeArrayOptions ClearMemory = 1;
}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Unity.Collections.NativeArray<T> m_Array; // 0x0
	private int m_Index; // 0x0
	private T value; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(Unity.Collections.NativeArray<T>& array) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Reset() { }

	// RVA: 0x316B894
	public T get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private ReadOnly m_Array; // 0x0
	private int m_Index; // 0x0
	private T value; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(ReadOnly array) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Reset() { }

	// RVA: 0x316B894
	public T get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct ReadOnly
{
	// Fields
	internal Void* m_Buffer; // 0x0
	internal int m_Length; // 0x0

	// Methods

	// RVA: 0x316B894
	internal void .ctor(Void* buffer, int length) { }

	// RVA: 0x30B199C
	public int get_Length() { }

	// RVA: 0x316B894
	public T get_Item(int index) { }

	// RVA: 0x316B894
	public Enumerator GetEnumerator() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	public System.ReadOnlySpan<T> AsReadOnlySpan() { }

}

// Namespace: Unity.Collections
public struct NativeArray<T0>
{
	// Fields
	internal Void* m_Buffer; // 0x0
	internal int m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Methods

	// RVA: -1
	public void .ctor(int length, Allocator allocator, NativeArrayOptions options) { }

	// RVA: 0x30B2D20
	public void .ctor(T[] array, Allocator allocator) { }

	// RVA: -1
	private static void Allocate(int length, Allocator allocator, Unity.Collections.NativeArray<T>& array) { }

	// RVA: 0x30B199C
	public int get_Length() { }

	// RVA: 0x316B894
	public T get_Item(int index) { }

	// RVA: 0x316B894
	public void set_Item(int index, T value) { }

	// RVA: 0x30B171C
	public bool get_IsCreated() { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x316B894
	public void CopyFrom(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x30B1CD4
	public T[] ToArray() { }

	// RVA: 0x316B894
	public Enumerator GetEnumerator() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	public bool Equals(Unity.Collections.NativeArray<T> other) { }

	// RVA: 0x30B183C
	public override bool Equals(object obj) { }

	// RVA: 0x30B199C
	public override int GetHashCode() { }

	// RVA: 0x316B894
	public static void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst) { }

	// RVA: 0x316B894
	public static void Copy(T[] src, Unity.Collections.NativeArray<T> dst) { }

	// RVA: 0x316B894
	public static void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length) { }

	// RVA: 0x316B894
	public static void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x316B894
	public static void Copy(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x316B894
	private static void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x316B894
	private static void CopySafe(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x316B894
	private static void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	// RVA: 0x316B894
	public ReadOnly AsReadOnly() { }

}

// Namespace: Unity.Collections
internal struct NativeArrayDispose
{
	// Fields
	internal Void* m_Buffer; // 0x10
	internal Allocator m_AllocatorLabel; // 0x18

	// Methods

	// RVA: 0x15B0534
	public void Dispose() { }

}

// Namespace: Unity.Collections
internal struct NativeArrayDisposeJob
{
	// Fields
	internal NativeArrayDispose Data; // 0x10

	// Methods

	// RVA: 0x15B0604
	public void Execute() { }

	// RVA: 0x15B066C
	internal static void RegisterNativeArrayDisposeJobReflectionData() { }

}

// Namespace: Unity.Collections
internal sealed class NativeArrayDebugView<T0>
{}

// Namespace: Unity.Collections
internal sealed class NativeArrayReadOnlyDebugView<T0>
{}

// Namespace: Unity.Collections
public static class NativeSliceExtensions
{
	// Methods

	// RVA: 0x316B894
	public static Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeArray<T> thisArray, int start, int length) { }

	// RVA: 0x316B894
	public static Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeSlice<T> thisSlice, int start, int length) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Unity.Collections.NativeSlice<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(Unity.Collections.NativeSlice<T>& array) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x30B2870
	public void Reset() { }

	// RVA: 0x316B894
	public T get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Unity.Collections
public struct NativeSlice<T0>
{
	// Fields
	internal Byte* m_Buffer; // 0x0
	internal int m_Stride; // 0x0
	internal int m_Length; // 0x0

	// Methods

	// RVA: 0x316B894
	public void .ctor(Unity.Collections.NativeSlice<T> slice, int start, int length) { }

	// RVA: 0x316B894
	public void .ctor(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x316B894
	public static Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x316B894
	public void .ctor(Unity.Collections.NativeArray<T> array, int start, int length) { }

	// RVA: 0x316B894
	public T get_Item(int index) { }

	// RVA: 0x316B894
	public void set_Item(int index, T value) { }

	// RVA: 0x316B894
	public void CopyFrom(Unity.Collections.NativeSlice<T> slice) { }

	// RVA: 0x30B2CB8
	public void CopyFrom(T[] array) { }

	// RVA: 0x30B199C
	public int get_Stride() { }

	// RVA: 0x30B199C
	public int get_Length() { }

	// RVA: 0x316B894
	public Enumerator GetEnumerator() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	public bool Equals(Unity.Collections.NativeSlice<T> other) { }

	// RVA: 0x30B183C
	public override bool Equals(object obj) { }

	// RVA: 0x30B199C
	public override int GetHashCode() { }

}

// Namespace: Unity.Collections
internal sealed class NativeSliceDebugView<T0>
{}

// Namespace: 
internal struct SharedStatic<T0>
{
	// Fields
	private readonly Void* _buffer; // 0x0

	// Methods

	// RVA: 0x316B894
	private void .ctor(Void* buffer) { }

	// RVA: 0x30B1CD4
	public T get_Data() { }

	// RVA: 0x316B894
	public static Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate(UInt32 alignment) { }

}

// Namespace: 
internal static class SharedStatic
{
	// Methods

	// RVA: 0x15B06B0
	public static Void* GetOrCreateSharedStaticInternal(Int64 getHashCode64, Int64 getSubHashCode64, UInt32 sizeOf, UInt32 alignment) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstLike
{}

// Namespace: 
private struct HashCode64<T0>
{
	// Fields
	public static readonly Int64 Value; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstRuntime
{
	// Methods

	// RVA: 0x30B5128
	public static Int64 GetHashCode64() { }

	// RVA: 0x15B0788
	internal static Int64 HashStringWithFNV1A64(string text) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerAttribute
{
	// Methods

	// RVA: 0x15B0818
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsReadOnlyAttribute
{
	// Methods

	// RVA: 0x15B0820
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsAtomicWriteOnlyAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute
{
	// Methods

	// RVA: 0x15B0828
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute
{
	// Methods

	// RVA: 0x15B0830
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeferredConvertListToArray
{
	// Methods

	// RVA: 0x15B0838
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeSetThreadIndexAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerNeedsThreadIndexAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public class WriteAccessRequiredAttribute
{
	// Methods

	// RVA: 0x15B0840
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableUnsafePtrRestrictionAttribute
{
	// Methods

	// RVA: 0x15B0848
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableContainerSafetyRestrictionAttribute
{
	// Methods

	// RVA: 0x15B0850
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeSetClassTypeToNullOnScheduleAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeArrayUnsafeUtility
{
	// Methods

	// RVA: 0x316B894
	public static Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, Allocator allocator) { }

	// RVA: 0x316B894
	public static Void* GetUnsafePtr(Unity.Collections.NativeArray<T> nativeArray) { }

	// RVA: 0x316B894
	public static Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeArray<T> nativeArray) { }

	// RVA: 0x316B894
	public static Void* GetUnsafeBufferPointerWithoutChecks(Unity.Collections.NativeArray<T> nativeArray) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeSliceUnsafeUtility
{
	// Methods

	// RVA: 0x316B894
	public static Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice(Void* dataPointer, int stride, int length) { }

	// RVA: 0x316B894
	public static Void* GetUnsafePtr(Unity.Collections.NativeSlice<T> nativeSlice) { }

	// RVA: 0x316B894
	public static Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeSlice<T> nativeSlice) { }

}

// Namespace: 
private struct AlignOfHelper<T0>
{
	// Fields
	public Byte dummy; // 0x0
	public T data; // 0x0
}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class UnsafeUtility
{
	// Methods

	// RVA: 0x15B0858
	public static Void* MallocTracked(Int64 size, int alignment, Allocator allocator, int callstacksToSkip) { }

	// RVA: 0x15B059C
	public static void FreeTracked(Void* memory, Allocator allocator) { }

	// RVA: 0x15B08C0
	public static Void* Malloc(Int64 size, int alignment, Allocator allocator) { }

	// RVA: 0x15B0918
	public static void Free(Void* memory, Allocator allocator) { }

	// RVA: 0x15B0334
	public static void MemCpy(Void* destination, Void* source, Int64 size) { }

	// RVA: 0x15B0980
	public static void MemCpyStride(Void* destination, int destinationStride, Void* source, int sourceStride, int elementSize, int count) { }

	// RVA: 0x15B0A00
	public static void MemMove(Void* destination, Void* source, Int64 size) { }

	// RVA: 0x15B0A58
	public static void MemSet(Void* destination, Byte value, Int64 size) { }

	// RVA: 0x15B0AB0
	public static void MemClear(Void* destination, Int64 size) { }

	// RVA: 0x15B0B04
	public static int MemCmp(Void* ptr1, Void* ptr2, Int64 size) { }

	// RVA: 0x15B0B5C
	public static bool IsBlittable(Type type) { }

	// RVA: 0x15B0BAC
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x15B0C1C
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x15B0E38
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: 0x15B0EC8
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: 0x30B44C8
	public static int AlignOf() { }

	// RVA: 0x316B894
	public static T ReadArrayElement(Void* source, int index) { }

	// RVA: 0x316B894
	public static T ReadArrayElementWithStride(Void* source, int index, int stride) { }

	// RVA: 0x316B894
	public static void WriteArrayElement(Void* destination, int index, T value) { }

	// RVA: 0x316B894
	public static void WriteArrayElementWithStride(Void* destination, int index, int stride, T value) { }

	// RVA: 0x316B894
	public static Void* AddressOf(T output) { }

	// RVA: 0x30B44C8
	public static int SizeOf() { }

	// RVA: 0x30B57C8
	public static T As(U from) { }

	// RVA: 0x316B894
	public static T AsRef(Void* ptr) { }

	// RVA: 0x316B894
	public static int EnumToInt(T enumValue) { }

	// RVA: 0x30B933C
	private static void InternalEnumToInt(T enumValue, int intValue) { }

	// RVA: 0x316B894
	public static bool EnumEquals(T lhs, T rhs) { }

}

// Namespace: Unity.Burst
public class BurstDiscardAttribute
{
	// Methods

	// RVA: 0x15B0F20
	public void .ctor() { }

}

// Namespace: Unity.Burst.LowLevel
internal static class BurstCompilerService
{
	// Methods

	// RVA: 0x15B0730
	public static Void* GetOrCreateSharedMemory(Hash128 key, UInt32 size_of, UInt32 alignment) { }

}

// Namespace: JetBrains.Annotations
public sealed class CanBeNullAttribute
{
	// Methods

	// RVA: 0x15B0F28
	public void .ctor() { }

}

// Namespace: JetBrains.Annotations
public sealed class NotNullAttribute
{
	// Methods

	// RVA: 0x15B0F30
	public void .ctor() { }

}

// Namespace: JetBrains.Annotations
public sealed class PureAttribute
{
	// Methods

	// RVA: 0x15B0F38
	public void .ctor() { }

}

// Namespace: UnityEngine
public struct SortingLayer
{
	// Fields
	private int m_Id; // 0x10

	// Methods

	// RVA: 0x15B0F40
	public static int GetLayerValueFromID(int id) { }

}

// Namespace: UnityEngine
public struct Keyframe
{
	// Fields
	private float m_Time; // 0x10
	private float m_Value; // 0x14
	private float m_InTangent; // 0x18
	private float m_OutTangent; // 0x1C
	private int m_WeightedMode; // 0x20
	private float m_InWeight; // 0x24
	private float m_OutWeight; // 0x28

	// Methods

	// RVA: 0x15B0F90
	public void .ctor(float time, float value) { }

	// RVA: 0x15B0FA0
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x15B0FB4
	public float get_time() { }

	// RVA: 0x15B0FBC
	public float get_value() { }

	// RVA: 0x15B0FC4
	public void set_value(float value) { }

}

// Namespace: UnityEngine
public enum WrapMode
{
	// Fields
	public int value__; // 0x10
	public const WrapMode Once = 1;
	public const WrapMode Loop = 2;
	public const WrapMode PingPong = 4;
	public const WrapMode Default = 0;
	public const WrapMode ClampForever = 8;
	public const WrapMode Clamp = 1;
}

// Namespace: UnityEngine
public class AnimationCurve
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15B0FCC
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x15B101C
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	// RVA: 0x15B106C
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x15B10D4
	protected override void Finalize() { }

	// RVA: 0x15B118C
	public float Evaluate(float time) { }

	// RVA: 0x15B11F4
	public Keyframe[] get_keys() { }

	// RVA: 0x15B1244
	private Keyframe[] GetKeys() { }

	// RVA: 0x15B1294
	public override int GetHashCode() { }

	// RVA: 0x15B12E4
	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	// RVA: 0x15B12F4
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x15B149C
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x15B1440
	public void .ctor(Keyframe[] keys) { }

	// RVA: 0x15B15D4
	public void .ctor() { }

	// RVA: 0x15B163C
	public override bool Equals(object o) { }

	// RVA: 0x15B1808
	public bool Equals(AnimationCurve other) { }

}

// Namespace: 
public sealed class LowMemoryCallback
{
	// Methods

	// RVA: 0x15B3864
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15B3904
	public virtual void Invoke() { }

}

// Namespace: 
public sealed class MemoryUsageChangedCallback
{
	// Methods

	// RVA: 0x15B3918
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15B39CC
	public virtual void Invoke(ApplicationMemoryUsageChange usage) { }

}

// Namespace: 
public sealed class LogCallback
{
	// Methods

	// RVA: 0x15B39E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15B3A9C
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }

}

// Namespace: UnityEngine
public class Application
{
	// Fields
	private static LowMemoryCallback lowMemory; // 0x0
	private static MemoryUsageChangedCallback memoryUsageChanged; // 0x8
	private static LogCallback s_LogCallbackHandler; // 0x10
	private static LogCallback s_LogCallbackHandlerThreaded; // 0x18
	private static System.Action<System.Boolean> focusChanged; // 0x20
	private static System.Action<System.String> deepLinkActivated; // 0x28
	private static System.Func<System.Boolean> wantsToQuit; // 0x30
	private static Action quitting; // 0x38
	private static Action unloading; // 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; // 0x48
	private static LogCallback s_RegisterLogCallbackDeprecated; // 0x50

	// Methods

	// RVA: 0x15B18F8
	public static void Quit(int exitCode) { }

	// RVA: 0x15B1948
	public static void Quit() { }

	// RVA: 0x15B19E4
	public static bool get_isPlaying() { }

	// RVA: 0x15B1A24
	public static bool get_isFocused() { }

	// RVA: 0x15B1A64
	public static bool get_runInBackground() { }

	// RVA: 0x15B1AA4
	public static bool get_isBatchMode() { }

	// RVA: 0x15B1AE4
	public static string get_dataPath() { }

	// RVA: 0x15B1B24
	public static string get_streamingAssetsPath() { }

	// RVA: 0x15B1B64
	public static string get_persistentDataPath() { }

	// RVA: 0x15B1BA4
	public static string get_temporaryCachePath() { }

	// RVA: 0x15B1BE4
	public static string get_unityVersion() { }

	// RVA: 0x15B1C24
	public static string get_version() { }

	// RVA: 0x15B1C64
	public static string get_identifier() { }

	// RVA: 0x15B1CA4
	public static ApplicationInstallMode get_installMode() { }

	// RVA: 0x15B1CE4
	public static string get_cloudProjectId() { }

	// RVA: 0x15B1D24
	public static void OpenURL(string url) { }

	// RVA: 0x15B1D74
	public static int get_targetFrameRate() { }

	// RVA: 0x15B1DB4
	public static void set_targetFrameRate(int value) { }

	// RVA: 0x15B1E04
	private static void SetLogCallbackDefined(bool defined) { }

	// RVA: 0x15B1E54
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	// RVA: 0x15B1EA4
	public static RuntimePlatform get_platform() { }

	// RVA: 0x15B1EE4
	public static SystemLanguage get_systemLanguage() { }

	// RVA: 0x15B1F24
	public static NetworkReachability get_internetReachability() { }

	// RVA: 0x15B1F64
	public static void add_lowMemory(LowMemoryCallback value) { }

	// RVA: 0x15B2050
	public static void remove_lowMemory(LowMemoryCallback value) { }

	// RVA: 0x15B213C
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	// RVA: 0x15B22A0
	internal static bool HasLogCallback() { }

	// RVA: 0x15B2360
	public static void add_logMessageReceived(LogCallback value) { }

	// RVA: 0x15B2480
	public static void remove_logMessageReceived(LogCallback value) { }

	// RVA: 0x15B2564
	public static void add_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0x15B2684
	public static void remove_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0x15B2768
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	// RVA: 0x15B2870
	public static void add_focusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x15B2984
	public static void remove_focusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x15B2A98
	public static void add_quitting(Action value) { }

	// RVA: 0x15B2B88
	public static void remove_quitting(Action value) { }

	// RVA: 0x15B2C78
	private static bool Internal_ApplicationWantsToQuit() { }

	// RVA: 0x15B2FFC
	private static void Internal_ApplicationInit() { }

	// RVA: 0x15B308C
	private static void Internal_ApplicationQuit() { }

	// RVA: 0x15B3158
	private static void Internal_ApplicationUnload() { }

	// RVA: 0x15B3208
	internal static void InvokeOnBeforeRender() { }

	// RVA: 0x15B3440
	internal static void InvokeFocusChanged(bool focus) { }

	// RVA: 0x15B3518
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x15B35DC
	public static void RegisterLogCallback(LogCallback handler) { }

	// RVA: 0x15B3664
	private static void RegisterLogCallback(LogCallback handler, bool threaded) { }

	// RVA: 0x15B37DC
	public static bool get_isEditor() { }

	// RVA: 0x15B37E4
	private static void .cctor() { }

}

// Namespace: UnityEngine
public enum ApplicationMemoryUsage
{
	// Fields
	public int value__; // 0x10
	public const ApplicationMemoryUsage Unknown = 0;
	public const ApplicationMemoryUsage Low = 1;
	public const ApplicationMemoryUsage Medium = 2;
	public const ApplicationMemoryUsage High = 3;
	public const ApplicationMemoryUsage Critical = 4;
}

// Namespace: UnityEngine
public struct ApplicationMemoryUsageChange
{
	// Fields
	private ApplicationMemoryUsage <memoryUsage>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15B3AB0
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

	// RVA: 0x15B2298
	public void .ctor(ApplicationMemoryUsage usage) { }

}

// Namespace: UnityEngine
public enum StackTraceLogType
{
	// Fields
	public int value__; // 0x10
	public const StackTraceLogType None = 0;
	public const StackTraceLogType ScriptOnly = 1;
	public const StackTraceLogType Full = 2;
}

// Namespace: UnityEngine
public enum NetworkReachability
{
	// Fields
	public int value__; // 0x10
	public const NetworkReachability NotReachable = 0;
	public const NetworkReachability ReachableViaCarrierDataNetwork = 1;
	public const NetworkReachability ReachableViaLocalAreaNetwork = 2;
}

// Namespace: UnityEngine
public enum ApplicationInstallMode
{
	// Fields
	public int value__; // 0x10
	public const ApplicationInstallMode Unknown = 0;
	public const ApplicationInstallMode Store = 1;
	public const ApplicationInstallMode DeveloperBuild = 2;
	public const ApplicationInstallMode Adhoc = 3;
	public const ApplicationInstallMode Enterprise = 4;
	public const ApplicationInstallMode Editor = 5;
}

// Namespace: UnityEngine
public enum SendMessageOptions
{
	// Fields
	public int value__; // 0x10
	public const SendMessageOptions RequireReceiver = 0;
	public const SendMessageOptions DontRequireReceiver = 1;
}

// Namespace: UnityEngine
public enum PrimitiveType
{
	// Fields
	public int value__; // 0x10
	public const PrimitiveType Sphere = 0;
	public const PrimitiveType Capsule = 1;
	public const PrimitiveType Cylinder = 2;
	public const PrimitiveType Cube = 3;
	public const PrimitiveType Plane = 4;
	public const PrimitiveType Quad = 5;
}

// Namespace: UnityEngine
public enum Space
{
	// Fields
	public int value__; // 0x10
	public const Space World = 0;
	public const Space Self = 1;
}

// Namespace: UnityEngine
public enum RuntimePlatform
{
	// Fields
	public int value__; // 0x10
	public const RuntimePlatform OSXEditor = 0;
	public const RuntimePlatform OSXPlayer = 1;
	public const RuntimePlatform WindowsPlayer = 2;
	public const RuntimePlatform OSXWebPlayer = 3;
	public const RuntimePlatform OSXDashboardPlayer = 4;
	public const RuntimePlatform WindowsWebPlayer = 5;
	public const RuntimePlatform WindowsEditor = 7;
	public const RuntimePlatform IPhonePlayer = 8;
	public const RuntimePlatform XBOX360 = 10;
	public const RuntimePlatform PS3 = 9;
	public const RuntimePlatform Android = 11;
	public const RuntimePlatform NaCl = 12;
	public const RuntimePlatform FlashPlayer = 15;
	public const RuntimePlatform LinuxPlayer = 13;
	public const RuntimePlatform LinuxEditor = 16;
	public const RuntimePlatform WebGLPlayer = 17;
	public const RuntimePlatform MetroPlayerX86 = 18;
	public const RuntimePlatform WSAPlayerX86 = 18;
	public const RuntimePlatform MetroPlayerX64 = 19;
	public const RuntimePlatform WSAPlayerX64 = 19;
	public const RuntimePlatform MetroPlayerARM = 20;
	public const RuntimePlatform WSAPlayerARM = 20;
	public const RuntimePlatform WP8Player = 21;
	public const RuntimePlatform BlackBerryPlayer = 22;
	public const RuntimePlatform TizenPlayer = 23;
	public const RuntimePlatform PSP2 = 24;
	public const RuntimePlatform PS4 = 25;
	public const RuntimePlatform PSM = 26;
	public const RuntimePlatform XboxOne = 27;
	public const RuntimePlatform SamsungTVPlayer = 28;
	public const RuntimePlatform WiiU = 30;
	public const RuntimePlatform tvOS = 31;
	public const RuntimePlatform Switch = 32;
	public const RuntimePlatform Lumin = 33;
	public const RuntimePlatform Stadia = 34;
	public const RuntimePlatform CloudRendering = 35;
	public const RuntimePlatform GameCoreScarlett = 4294967295;
	public const RuntimePlatform GameCoreXboxSeries = 36;
	public const RuntimePlatform GameCoreXboxOne = 37;
	public const RuntimePlatform PS5 = 38;
	public const RuntimePlatform EmbeddedLinuxArm64 = 39;
	public const RuntimePlatform EmbeddedLinuxArm32 = 40;
	public const RuntimePlatform EmbeddedLinuxX64 = 41;
	public const RuntimePlatform EmbeddedLinuxX86 = 42;
	public const RuntimePlatform LinuxServer = 43;
	public const RuntimePlatform WindowsServer = 44;
	public const RuntimePlatform OSXServer = 45;
	public const RuntimePlatform QNXArm32 = 46;
	public const RuntimePlatform QNXArm64 = 47;
	public const RuntimePlatform QNXX64 = 48;
	public const RuntimePlatform QNXX86 = 49;
	public const RuntimePlatform VisionOS = 50;
}

// Namespace: UnityEngine
public enum SystemLanguage
{
	// Fields
	public int value__; // 0x10
	public const SystemLanguage Afrikaans = 0;
	public const SystemLanguage Arabic = 1;
	public const SystemLanguage Basque = 2;
	public const SystemLanguage Belarusian = 3;
	public const SystemLanguage Bulgarian = 4;
	public const SystemLanguage Catalan = 5;
	public const SystemLanguage Chinese = 6;
	public const SystemLanguage Czech = 7;
	public const SystemLanguage Danish = 8;
	public const SystemLanguage Dutch = 9;
	public const SystemLanguage English = 10;
	public const SystemLanguage Estonian = 11;
	public const SystemLanguage Faroese = 12;
	public const SystemLanguage Finnish = 13;
	public const SystemLanguage French = 14;
	public const SystemLanguage German = 15;
	public const SystemLanguage Greek = 16;
	public const SystemLanguage Hebrew = 17;
	public const SystemLanguage Icelandic = 19;
	public const SystemLanguage Indonesian = 20;
	public const SystemLanguage Italian = 21;
	public const SystemLanguage Japanese = 22;
	public const SystemLanguage Korean = 23;
	public const SystemLanguage Latvian = 24;
	public const SystemLanguage Lithuanian = 25;
	public const SystemLanguage Norwegian = 26;
	public const SystemLanguage Polish = 27;
	public const SystemLanguage Portuguese = 28;
	public const SystemLanguage Romanian = 29;
	public const SystemLanguage Russian = 30;
	public const SystemLanguage SerboCroatian = 31;
	public const SystemLanguage Slovak = 32;
	public const SystemLanguage Slovenian = 33;
	public const SystemLanguage Spanish = 34;
	public const SystemLanguage Swedish = 35;
	public const SystemLanguage Thai = 36;
	public const SystemLanguage Turkish = 37;
	public const SystemLanguage Ukrainian = 38;
	public const SystemLanguage Vietnamese = 39;
	public const SystemLanguage ChineseSimplified = 40;
	public const SystemLanguage ChineseTraditional = 41;
	public const SystemLanguage Hindi = 42;
	public const SystemLanguage Unknown = 43;
	public const SystemLanguage Hungarian = 18;
}

// Namespace: UnityEngine
public enum LogType
{
	// Fields
	public int value__; // 0x10
	public const LogType Error = 0;
	public const LogType Assert = 1;
	public const LogType Warning = 2;
	public const LogType Log = 3;
	public const LogType Exception = 4;
}

// Namespace: UnityEngine
public enum LogOption
{
	// Fields
	public int value__; // 0x10
	public const LogOption None = 0;
	public const LogOption NoStacktrace = 1;
}

// Namespace: UnityEngine
internal class BootConfigData
{
	// Fields
	private IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15B3AB8
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

	// RVA: 0x15B3B1C
	private void .ctor(IntPtr nativeHandle) { }

}

// Namespace: UnityEngine
public sealed class Caching
{
	// Methods

	// RVA: 0x15B3BA4
	public static bool get_ready() { }

	// RVA: 0x15B3BE4
	public static void set_maximumAvailableDiskSpace(Int64 value) { }

}

// Namespace: 
internal enum ProjectionMatrixMode
{
	// Fields
	public int value__; // 0x10
	public const ProjectionMatrixMode Explicit = 0;
	public const ProjectionMatrixMode Implicit = 1;
	public const ProjectionMatrixMode PhysicalPropertiesBased = 2;
}

// Namespace: 
public enum GateFitMode
{
	// Fields
	public int value__; // 0x10
	public const GateFitMode Vertical = 1;
	public const GateFitMode Horizontal = 2;
	public const GateFitMode Fill = 3;
	public const GateFitMode Overscan = 4;
	public const GateFitMode None = 0;
}

// Namespace: 
public struct GateFitParameters
{
	// Fields
	private GateFitMode <mode>k__BackingField; // 0x10
	private float <aspect>k__BackingField; // 0x14

	// Methods

	// RVA: 0x15BA558
	public GateFitMode get_mode() { }

	// RVA: 0x15BA560
	public float get_aspect() { }

}

// Namespace: 
public enum StereoscopicEye
{
	// Fields
	public int value__; // 0x10
	public const StereoscopicEye Left = 0;
	public const StereoscopicEye Right = 1;
}

// Namespace: 
public enum MonoOrStereoscopicEye
{
	// Fields
	public int value__; // 0x10
	public const MonoOrStereoscopicEye Left = 0;
	public const MonoOrStereoscopicEye Right = 1;
	public const MonoOrStereoscopicEye Mono = 2;
}

// Namespace: 
public enum SceneViewFilterMode
{
	// Fields
	public int value__; // 0x10
	public const SceneViewFilterMode Off = 0;
	public const SceneViewFilterMode ShowFiltered = 1;
}

// Namespace: 
public enum RenderRequestMode
{
	// Fields
	public int value__; // 0x10
	public const RenderRequestMode None = 0;
	public const RenderRequestMode ObjectId = 1;
	public const RenderRequestMode Depth = 2;
	public const RenderRequestMode VertexNormal = 3;
	public const RenderRequestMode WorldPosition = 4;
	public const RenderRequestMode EntityId = 5;
	public const RenderRequestMode BaseColor = 6;
	public const RenderRequestMode SpecularColor = 7;
	public const RenderRequestMode Metallic = 8;
	public const RenderRequestMode Emission = 9;
	public const RenderRequestMode Normal = 10;
	public const RenderRequestMode Smoothness = 11;
	public const RenderRequestMode Occlusion = 12;
	public const RenderRequestMode DiffuseColor = 13;
}

// Namespace: 
public enum RenderRequestOutputSpace
{
	// Fields
	public int value__; // 0x10
	public const RenderRequestOutputSpace ScreenSpace = 4294967295;
	public const RenderRequestOutputSpace UV0 = 0;
	public const RenderRequestOutputSpace UV1 = 1;
	public const RenderRequestOutputSpace UV2 = 2;
	public const RenderRequestOutputSpace UV3 = 3;
	public const RenderRequestOutputSpace UV4 = 4;
	public const RenderRequestOutputSpace UV5 = 5;
	public const RenderRequestOutputSpace UV6 = 6;
	public const RenderRequestOutputSpace UV7 = 7;
	public const RenderRequestOutputSpace UV8 = 8;
}

// Namespace: 
public struct RenderRequest
{
	// Fields
	private readonly RenderRequestMode m_CameraRenderMode; // 0x10
	private readonly RenderTexture m_ResultRT; // 0x18
	private readonly RenderRequestOutputSpace m_OutputSpace; // 0x20
}

// Namespace: 
public sealed class CameraCallback
{
	// Methods

	// RVA: 0x15BA568
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15BA61C
	public virtual void Invoke(Camera cam) { }

}

// Namespace: UnityEngine
public sealed class Camera
{
	// Fields
	public const float kMinAperture = 0.7;
	public const float kMaxAperture = 32;
	public const int kMinBladeCount = 3;
	public const int kMaxBladeCount = 11;
	public static CameraCallback onPreCull; // 0x0
	public static CameraCallback onPreRender; // 0x8
	public static CameraCallback onPostRender; // 0x10

	// Methods

	// RVA: 0x15B3C34
	public void .ctor() { }

	// RVA: 0x15B3C3C
	public float get_nearClipPlane() { }

	// RVA: 0x15B3C8C
	public void set_nearClipPlane(float value) { }

	// RVA: 0x15B3CF4
	public float get_farClipPlane() { }

	// RVA: 0x15B3D44
	public void set_farClipPlane(float value) { }

	// RVA: 0x15B3DAC
	public float get_fieldOfView() { }

	// RVA: 0x15B3DFC
	public void set_fieldOfView(float value) { }

	// RVA: 0x15B3E64
	public RenderingPath get_renderingPath() { }

	// RVA: 0x15B3EB4
	public void set_renderingPath(RenderingPath value) { }

	// RVA: 0x15B3F1C
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x15B3F6C
	public void Reset() { }

	// RVA: 0x15B3FBC
	public bool get_allowHDR() { }

	// RVA: 0x15B400C
	public void set_allowHDR(bool value) { }

	// RVA: 0x15B4074
	public bool get_allowMSAA() { }

	// RVA: 0x15B40C4
	public void set_allowMSAA(bool value) { }

	// RVA: 0x15B412C
	public bool get_allowDynamicResolution() { }

	// RVA: 0x15B417C
	public void set_allowDynamicResolution(bool value) { }

	// RVA: 0x15B41E4
	public bool get_forceIntoRenderTexture() { }

	// RVA: 0x15B4234
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x15B429C
	public float get_orthographicSize() { }

	// RVA: 0x15B42EC
	public void set_orthographicSize(float value) { }

	// RVA: 0x15B4354
	public bool get_orthographic() { }

	// RVA: 0x15B43A4
	public void set_orthographic(bool value) { }

	// RVA: 0x15B440C
	public OpaqueSortMode get_opaqueSortMode() { }

	// RVA: 0x15B445C
	public void set_opaqueSortMode(OpaqueSortMode value) { }

	// RVA: 0x15B44C4
	public TransparencySortMode get_transparencySortMode() { }

	// RVA: 0x15B4514
	public void set_transparencySortMode(TransparencySortMode value) { }

	// RVA: 0x15B457C
	public Vector3 get_transparencySortAxis() { }

	// RVA: 0x15B4644
	public void set_transparencySortAxis(Vector3 value) { }

	// RVA: 0x15B4704
	public void ResetTransparencySortSettings() { }

	// RVA: 0x15B4754
	public float get_depth() { }

	// RVA: 0x15B47A4
	public void set_depth(float value) { }

	// RVA: 0x15B480C
	public float get_aspect() { }

	// RVA: 0x15B485C
	public void set_aspect(float value) { }

	// RVA: 0x15B48C4
	public void ResetAspect() { }

	// RVA: 0x15B4914
	public Vector3 get_velocity() { }

	// RVA: 0x15B49DC
	public int get_cullingMask() { }

	// RVA: 0x15B4A2C
	public void set_cullingMask(int value) { }

	// RVA: 0x15B4A94
	public int get_eventMask() { }

	// RVA: 0x15B4AE4
	public void set_eventMask(int value) { }

	// RVA: 0x15B4B4C
	public bool get_layerCullSpherical() { }

	// RVA: 0x15B4B9C
	public void set_layerCullSpherical(bool value) { }

	// RVA: 0x15B4C04
	public CameraType get_cameraType() { }

	// RVA: 0x15B4C54
	public void set_cameraType(CameraType value) { }

	// RVA: 0x15B4CBC
	internal Material get_skyboxMaterial() { }

	// RVA: 0x15B4D0C
	public UInt64 get_overrideSceneCullingMask() { }

	// RVA: 0x15B4D5C
	public void set_overrideSceneCullingMask(UInt64 value) { }

	// RVA: 0x15B4DC4
	internal UInt64 get_sceneCullingMask() { }

	// RVA: 0x15B4E14
	private float[] GetLayerCullDistances() { }

	// RVA: 0x15B4E64
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x15B4ECC
	public float[] get_layerCullDistances() { }

	// RVA: 0x15B4F1C
	public void set_layerCullDistances(float[] value) { }

	// RVA: 0x15B4FE0
	internal static int get_PreviewCullingLayer() { }

	// RVA: 0x15B4FE8
	public bool get_useOcclusionCulling() { }

	// RVA: 0x15B5038
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x15B50A0
	public Matrix4x4 get_cullingMatrix() { }

	// RVA: 0x15B5180
	public void set_cullingMatrix(Matrix4x4 value) { }

	// RVA: 0x15B5250
	public void ResetCullingMatrix() { }

	// RVA: 0x15B52A0
	public Color get_backgroundColor() { }

	// RVA: 0x15B5364
	public void set_backgroundColor(Color value) { }

	// RVA: 0x15B5424
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x15B5474
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x15B54DC
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x15B552C
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x15B5594
	public bool get_clearStencilAfterLightingPass() { }

	// RVA: 0x15B55E4
	public void set_clearStencilAfterLightingPass(bool value) { }

	// RVA: 0x15B564C
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x15B56A4
	public void ResetReplacementShader() { }

	// RVA: 0x15B56F4
	internal ProjectionMatrixMode get_projectionMatrixMode() { }

	// RVA: 0x15B5744
	public bool get_usePhysicalProperties() { }

	// RVA: 0x15B5794
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x15B57FC
	public int get_iso() { }

	// RVA: 0x15B584C
	public void set_iso(int value) { }

	// RVA: 0x15B58B4
	public float get_shutterSpeed() { }

	// RVA: 0x15B5904
	public void set_shutterSpeed(float value) { }

	// RVA: 0x15B596C
	public float get_aperture() { }

	// RVA: 0x15B59BC
	public void set_aperture(float value) { }

	// RVA: 0x15B5A24
	public float get_focusDistance() { }

	// RVA: 0x15B5A74
	public void set_focusDistance(float value) { }

	// RVA: 0x15B5ADC
	public float get_focalLength() { }

	// RVA: 0x15B5B2C
	public void set_focalLength(float value) { }

	// RVA: 0x15B5B94
	public int get_bladeCount() { }

	// RVA: 0x15B5BE4
	public void set_bladeCount(int value) { }

	// RVA: 0x15B5C4C
	public Vector2 get_curvature() { }

	// RVA: 0x15B5D0C
	public void set_curvature(Vector2 value) { }

	// RVA: 0x15B5DC8
	public float get_barrelClipping() { }

	// RVA: 0x15B5E18
	public void set_barrelClipping(float value) { }

	// RVA: 0x15B5E80
	public float get_anamorphism() { }

	// RVA: 0x15B5ED0
	public void set_anamorphism(float value) { }

	// RVA: 0x15B5F38
	public Vector2 get_sensorSize() { }

	// RVA: 0x15B5FF8
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x15B60B4
	public Vector2 get_lensShift() { }

	// RVA: 0x15B6174
	public void set_lensShift(Vector2 value) { }

	// RVA: 0x15B6230
	public GateFitMode get_gateFit() { }

	// RVA: 0x15B6280
	public void set_gateFit(GateFitMode value) { }

	// RVA: 0x15B62E8
	public float GetGateFittedFieldOfView() { }

	// RVA: 0x15B6338
	public Vector2 GetGateFittedLensShift() { }

	// RVA: 0x15B63F8
	internal Vector3 GetLocalSpaceAim() { }

	// RVA: 0x15B64C0
	public Rect get_rect() { }

	// RVA: 0x15B6584
	public void set_rect(Rect value) { }

	// RVA: 0x15B6644
	public Rect get_pixelRect() { }

	// RVA: 0x15B6708
	public void set_pixelRect(Rect value) { }

	// RVA: 0x15B67C8
	public int get_pixelWidth() { }

	// RVA: 0x15B6818
	public int get_pixelHeight() { }

	// RVA: 0x15B6868
	public int get_scaledPixelWidth() { }

	// RVA: 0x15B68B8
	public int get_scaledPixelHeight() { }

	// RVA: 0x15B6908
	public RenderTexture get_targetTexture() { }

	// RVA: 0x15B6958
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x15B69C0
	public RenderTexture get_activeTexture() { }

	// RVA: 0x15B6A10
	public int get_targetDisplay() { }

	// RVA: 0x15B6A60
	public void set_targetDisplay(int value) { }

	// RVA: 0x15B6AC8
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x15B6B7C
	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x15B6BD8
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0x15B6C94
	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x15B6CF8
	internal string[] GetCameraBufferWarnings() { }

	// RVA: 0x15B6D48
	public Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0x15B6E28
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x15B6F08
	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0x15B6FD8
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x15B70B8
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x15B7188
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x15B7268
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x15B7338
	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	// RVA: 0x15B7388
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x15B73F0
	public Matrix4x4 get_previousViewProjectionMatrix() { }

	// RVA: 0x15B74D0
	public void ResetWorldToCameraMatrix() { }

	// RVA: 0x15B7520
	public void ResetProjectionMatrix() { }

	// RVA: 0x15B7570
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0x15B764C
	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15B7730
	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15B7814
	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15B78F8
	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15B79DC
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x15B7A4C
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x15B7ABC
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x15B7B2C
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x15B7B9C
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x15B7C60
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x15B7D24
	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	// RVA: 0x15B7DEC
	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15B7ED8
	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15B7F64
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x15B7FEC
	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15B80D8
	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15B8164
	public Ray ScreenPointToRay(Vector3 pos) { }

	// RVA: 0x15B81EC
	private void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0x15B82E4
	public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0x15B8418
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0x15B854C
	public static void CalculateProjectionMatrixFromPhysicalProperties(Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters) { }

	// RVA: 0x15B85E8
	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	// RVA: 0x15B864C
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	// RVA: 0x15B86B0
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	// RVA: 0x15B8714
	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	// RVA: 0x15B8778
	public static Camera get_main() { }

	// RVA: 0x15B87B8
	public static Camera get_current() { }

	// RVA: 0x15B87F8
	public Scene get_scene() { }

	// RVA: 0x15B88B8
	public void set_scene(Scene value) { }

	// RVA: 0x15B8974
	public bool get_stereoEnabled() { }

	// RVA: 0x15B89C4
	public float get_stereoSeparation() { }

	// RVA: 0x15B8A14
	public void set_stereoSeparation(float value) { }

	// RVA: 0x15B8A7C
	public float get_stereoConvergence() { }

	// RVA: 0x15B8ACC
	public void set_stereoConvergence(float value) { }

	// RVA: 0x15B8B34
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	// RVA: 0x15B8B84
	public StereoTargetEyeMask get_stereoTargetEye() { }

	// RVA: 0x15B8BD4
	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	// RVA: 0x15B8C3C
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x15B8C8C
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0x15B8D64
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	// RVA: 0x15B8E3C
	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	// RVA: 0x15B8EA4
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0x15B8F7C
	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x15B902C
	public void ResetStereoProjectionMatrices() { }

	// RVA: 0x15B907C
	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x15B912C
	public void ResetStereoViewMatrices() { }

	// RVA: 0x15B917C
	private static int GetAllCamerasCount() { }

	// RVA: 0x15B91BC
	private static int GetAllCamerasImpl(Camera[] cam) { }

	// RVA: 0x15B920C
	public static int get_allCamerasCount() { }

	// RVA: 0x15B924C
	public static Camera[] get_allCameras() { }

	// RVA: 0x15B9300
	public static int GetAllCameras(Camera[] cameras) { }

	// RVA: 0x15B93FC
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	// RVA: 0x15B9454
	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	// RVA: 0x15B94AC
	public bool RenderToCubemap(Cubemap cubemap) { }

	// RVA: 0x15B9500
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	// RVA: 0x15B9558
	public bool RenderToCubemap(RenderTexture cubemap) { }

	// RVA: 0x15B95AC
	private int GetFilterMode() { }

	// RVA: 0x15B95FC
	public SceneViewFilterMode get_sceneViewFilterMode() { }

	// RVA: 0x15B964C
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x15B96B4
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x15B971C
	public void Render() { }

	// RVA: 0x15B976C
	public void RenderWithShader(Shader shader, string replacementTag) { }

	// RVA: 0x15B97C4
	public void RenderDontRestore() { }

	// RVA: 0x15B9814
	public void SubmitRenderRequests(System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests) { }

	// RVA: 0x316B894
	public void SubmitRenderRequest(RequestData renderRequest) { }

	// RVA: 0x15B9AD8
	private void SubmitRenderRequestsInternal(object requests) { }

	// RVA: 0x15B9B40
	private object[] SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x15B9BB0
	public static void SetupCurrent(Camera cur) { }

	// RVA: 0x15B9C00
	public void CopyFrom(Camera other) { }

	// RVA: 0x15B9C68
	public int get_commandBufferCount() { }

	// RVA: 0x15B9CB8
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x15B9D20
	public void RemoveAllCommandBuffers() { }

	// RVA: 0x15B9D70
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x15B9DC8
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x15B9E30
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x15B9E88
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x15B9FC8
	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x15BA118
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x15BA258
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	// RVA: 0x15BA2C0
	private static void FireOnPreCull(Camera cam) { }

	// RVA: 0x15BA33C
	private static void FireOnPreRender(Camera cam) { }

	// RVA: 0x15BA3B8
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x15BA434
	internal void OnlyUsedForTesting1() { }

	// RVA: 0x15BA438
	internal void OnlyUsedForTesting2() { }

	// RVA: 0x15BA43C
	public bool TryGetCullingParameters(ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x15BA4FC
	public bool TryGetCullingParameters(bool stereoAware, ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x15BA494
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	// RVA: 0x15B45DC
	private void get_transparencySortAxis_Injected(Vector3 ret) { }

	// RVA: 0x15B469C
	private void set_transparencySortAxis_Injected(Vector3 value) { }

	// RVA: 0x15B4974
	private void get_velocity_Injected(Vector3 ret) { }

	// RVA: 0x15B5118
	private void get_cullingMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15B51E8
	private void set_cullingMatrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15B52FC
	private void get_backgroundColor_Injected(Color ret) { }

	// RVA: 0x15B53BC
	private void set_backgroundColor_Injected(Color value) { }

	// RVA: 0x15B5CA4
	private void get_curvature_Injected(Vector2 ret) { }

	// RVA: 0x15B5D60
	private void set_curvature_Injected(Vector2 value) { }

	// RVA: 0x15B5F90
	private void get_sensorSize_Injected(Vector2 ret) { }

	// RVA: 0x15B604C
	private void set_sensorSize_Injected(Vector2 value) { }

	// RVA: 0x15B610C
	private void get_lensShift_Injected(Vector2 ret) { }

	// RVA: 0x15B61C8
	private void set_lensShift_Injected(Vector2 value) { }

	// RVA: 0x15B6390
	private void GetGateFittedLensShift_Injected(Vector2 ret) { }

	// RVA: 0x15B6458
	private void GetLocalSpaceAim_Injected(Vector3 ret) { }

	// RVA: 0x15B651C
	private void get_rect_Injected(Rect ret) { }

	// RVA: 0x15B65DC
	private void set_rect_Injected(Rect value) { }

	// RVA: 0x15B66A0
	private void get_pixelRect_Injected(Rect ret) { }

	// RVA: 0x15B6760
	private void set_pixelRect_Injected(Rect value) { }

	// RVA: 0x15B6B24
	private void SetTargetBuffersImpl_Injected(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x15B6C3C
	private void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0x15B6DC0
	private void get_cameraToWorldMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15B6EA0
	private void get_worldToCameraMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15B6F70
	private void set_worldToCameraMatrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15B7050
	private void get_projectionMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15B7120
	private void set_projectionMatrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15B7200
	private void get_nonJitteredProjectionMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15B72D0
	private void set_nonJitteredProjectionMatrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15B7468
	private void get_previousViewProjectionMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15B75F4
	private void CalculateObliqueMatrix_Injected(Vector4 clipPlane, Matrix4x4 ret) { }

	// RVA: 0x15B76C8
	private void WorldToScreenPoint_Injected(Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x15B77AC
	private void WorldToViewportPoint_Injected(Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x15B7890
	private void ViewportToWorldPoint_Injected(Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x15B7974
	private void ScreenToWorldPoint_Injected(Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x15B7C08
	private void ScreenToViewportPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x15B7CCC
	private void ViewportToScreenPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x15B7D8C
	private void GetFrustumPlaneSizeAt_Injected(float distance, Vector2 ret) { }

	// RVA: 0x15B7E70
	private void ViewportPointToRay_Injected(Vector2 pos, MonoOrStereoscopicEye eye, Ray ret) { }

	// RVA: 0x15B8070
	private void ScreenPointToRay_Injected(Vector2 pos, MonoOrStereoscopicEye eye, Ray ret) { }

	// RVA: 0x15B826C
	private void CalculateFrustumCornersInternal_Injected(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0x15B84B4
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0x15B8850
	private void get_scene_Injected(Scene ret) { }

	// RVA: 0x15B890C
	private void set_scene_Injected(Scene value) { }

	// RVA: 0x15B8D0C
	private void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, Matrix4x4 ret) { }

	// RVA: 0x15B8DE4
	private void GetStereoViewMatrix_Injected(StereoscopicEye eye, Matrix4x4 ret) { }

	// RVA: 0x15B8F24
	private void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, Matrix4x4 ret) { }

	// RVA: 0x15B8FD4
	private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x15B90D4
	private void SetStereoViewMatrix_Injected(StereoscopicEye eye, Matrix4x4 matrix) { }

}

// Namespace: UnityEngine
public struct BoundingSphere
{
	// Fields
	public Vector3 position; // 0x10
	public float radius; // 0x1C
}

// Namespace: UnityEngine
public struct CullingGroupEvent
{
	// Fields
	private int m_Index; // 0x10
	private Byte m_PrevState; // 0x14
	private Byte m_ThisState; // 0x15
}

// Namespace: 
public sealed class StateChanged
{
	// Methods

	// RVA: 0x15BA698
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15BA73C
	public virtual void Invoke(CullingGroupEvent sphere) { }

}

// Namespace: UnityEngine
public class CullingGroup
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private StateChanged m_OnStateChanged; // 0x18

	// Methods

	// RVA: 0x15BA630
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

}

// Namespace: UnityEngine
public class FlareLayer
{}

// Namespace: 
public enum ReflectionProbeEvent
{
	// Fields
	public int value__; // 0x10
	public const ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbeEvent ReflectionProbeRemoved = 1;
}

// Namespace: UnityEngine
public sealed class ReflectionProbe
{
	// Fields
	private static System.Action<UnityEngine.ReflectionProbe,UnityEngine.ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	private static System.Collections.Generic.Dictionary<System.Int32,System.Action<UnityEngine.Texture>> registeredDefaultReflectionSetActions; // 0x8
	private static System.Collections.Generic.List<System.Action<UnityEngine.Texture>> registeredDefaultReflectionTextureActions; // 0x10

	// Methods

	// RVA: 0x15BA750
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	// RVA: 0x15BA800
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x15BAA28
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class DebugLogHandler
{
	// Methods

	// RVA: 0x15BAB14
	internal static void Internal_Log(LogType level, LogOption options, string msg, object obj) { }

	// RVA: 0x15BAB7C
	internal static void Internal_LogException(Exception ex, object obj) { }

	// RVA: 0x15BABE4
	public void LogFormat(LogType logType, object context, string format, object[] args) { }

	// RVA: 0x15BAC50
	public void LogFormat(LogType logType, LogOption logOptions, object context, string format, object[] args) { }

	// RVA: 0x15BACC8
	public void LogException(Exception exception, object context) { }

	// RVA: 0x15BAD7C
	public void .ctor() { }

}

// Namespace: UnityEngine
public class Debug
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Methods

	// RVA: 0x15BAD84
	public static ILogger get_unityLogger() { }

	// RVA: 0x15BAE00
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x15BAE58
	public static void Log(object message) { }

	// RVA: 0x15BB020
	public static void LogFormat(LogType logType, LogOption logOptions, object context, string format, object[] args) { }

	// RVA: 0x15BB404
	public static void LogError(object message) { }

	// RVA: 0x15BB548
	public static void LogError(object message, object context) { }

	// RVA: 0x15BB694
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x15BB7E0
	public static void LogErrorFormat(object context, string format, object[] args) { }

	// RVA: 0x15B2EB8
	public static void LogException(Exception exception) { }

	// RVA: 0x15BB938
	public static void LogException(Exception exception, object context) { }

	// RVA: 0x15B9994
	public static void LogWarning(object message) { }

	// RVA: 0x15BBA80
	public static void LogWarning(object message, object context) { }

	// RVA: 0x15BBBCC
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x15BBD18
	public static void LogWarningFormat(object context, string format, object[] args) { }

	// RVA: 0x15BBE70
	public static void Assert(bool condition) { }

	// RVA: 0x15BBFC8
	public static void Assert(bool condition, string message) { }

	// RVA: 0x15BC118
	public static void LogAssertion(object message) { }

	// RVA: 0x15BC25C
	public static void LogAssertionFormat(string format, object[] args) { }

	// RVA: 0x15BC3A8
	public static bool get_isDebugBuild() { }

	// RVA: 0x15BC3E8
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	// RVA: 0x15BC798
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x15BCA38
	private static void .cctor() { }

}

// Namespace: 
internal class Expression
{
	// Fields
	internal readonly string[] rpnTokens; // 0x10
	internal readonly bool hasVariables; // 0x18

	// Methods

	// RVA: 0x15BEF24
	internal void .ctor(string expression) { }

	// RVA: -1
	public bool Evaluate(T value, int index, int count) { }

}

// Namespace: 
private struct PcgRandom
{
	// Fields
	private readonly UInt64 increment; // 0x10
	private UInt64 state; // 0x18

	// Methods

	// RVA: 0x15BEEB0
	public void .ctor(UInt64 state, UInt64 sequence) { }

	// RVA: 0x15BE904
	public UInt32 GetUInt() { }

	// RVA: 0x15BEFEC
	private static UInt32 RotateRight(UInt32 v, int rot) { }

	// RVA: 0x15BEFD4
	private static UInt32 XshRr(UInt64 s) { }

	// RVA: 0x15BEFB4
	private void Step() { }

}

// Namespace: 
private enum Op
{
	// Fields
	public int value__; // 0x10
	public const Op Add = 0;
	public const Op Sub = 1;
	public const Op Mul = 2;
	public const Op Div = 3;
	public const Op Mod = 4;
	public const Op Neg = 5;
	public const Op Pow = 6;
	public const Op Sqrt = 7;
	public const Op Sin = 8;
	public const Op Cos = 9;
	public const Op Tan = 10;
	public const Op Floor = 11;
	public const Op Ceil = 12;
	public const Op Round = 13;
	public const Op Rand = 14;
	public const Op Linear = 15;
}

// Namespace: 
private enum Associativity
{
	// Fields
	public int value__; // 0x10
	public const Associativity Left = 0;
	public const Associativity Right = 1;
}

// Namespace: 
private class Operator
{
	// Fields
	public readonly Op op; // 0x10
	public readonly int precedence; // 0x14
	public readonly Associativity associativity; // 0x18
	public readonly int inputs; // 0x1C

	// Methods

	// RVA: 0x15BEED8
	public void .ctor(Op op, int precedence, int inputs, Associativity associativity) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ExpressionEvaluator.<>c <>9; // 0x0
	public static System.Func<System.String,System.Boolean> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x15BEFF4
	private static void .cctor() { }

	// RVA: 0x15BF060
	public void .ctor() { }

	// RVA: 0x15BF068
	internal bool <ExpressionToTokens>b__14_0(string f) { }

}

// Namespace: UnityEngine
public class ExpressionEvaluator
{
	// Fields
	private static PcgRandom s_Random; // 0x0
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.ExpressionEvaluator.Operator> s_Operators; // 0x10

	// Methods

	// RVA: 0x30B4264
	internal static bool Evaluate(string expression, T value, Expression delayed) { }

	// RVA: 0x316B894
	private static bool EvaluateTokens(string[] tokens, T value, int index, int count) { }

	// RVA: 0x15BCB34
	private static bool EvaluateDouble(string[] tokens, Double value, int index, int count) { }

	// RVA: 0x15BD894
	private static string[] InfixToRPN(string[] tokens) { }

	// RVA: 0x15BDFDC
	private static bool NeedToPop(System.Collections.Generic.Stack<System.String> operatorStack, Operator newOperator) { }

	// RVA: 0x15BE194
	private static string[] ExpressionToTokens(string expression, bool hasVariables) { }

	// RVA: 0x15BD394
	private static bool IsCommand(string token) { }

	// RVA: 0x15BD834
	private static bool IsVariable(string token) { }

	// RVA: 0x15BDEA0
	private static bool IsDelayedFunction(string token) { }

	// RVA: 0x15BD228
	private static bool IsOperator(string token) { }

	// RVA: 0x15BD2CC
	private static Operator TokenToOperator(string token) { }

	// RVA: 0x15BE520
	private static string PreFormatExpression(string expression) { }

	// RVA: 0x15BE764
	private static string[] FixUnaryOperators(string[] tokens) { }

	// RVA: 0x15BD4C8
	private static Double EvaluateOp(Double[] values, Op op, int index, int count) { }

	// RVA: 0x30B410C
	private static bool TryParse(string expression, T result) { }

	// RVA: 0x15BE938
	private static void .cctor() { }

}

// Namespace: UnityEngine
public struct Bounds
{
	// Fields
	private Vector3 m_Center; // 0x10
	private Vector3 m_Extents; // 0x1C

	// Methods

	// RVA: 0x15BF160
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x15BF180
	public override int GetHashCode() { }

	// RVA: 0x15BF254
	public override bool Equals(object other) { }

	// RVA: 0x15BF31C
	public bool Equals(Bounds other) { }

	// RVA: 0x15BF370
	public Vector3 get_center() { }

	// RVA: 0x15BF37C
	public void set_center(Vector3 value) { }

	// RVA: 0x15BF388
	public Vector3 get_size() { }

	// RVA: 0x15BF3A0
	public void set_size(Vector3 value) { }

	// RVA: 0x15BF3BC
	public Vector3 get_extents() { }

	// RVA: 0x15BF3C8
	public void set_extents(Vector3 value) { }

	// RVA: 0x15BF3D4
	public Vector3 get_min() { }

	// RVA: 0x15BF3F0
	public void set_min(Vector3 value) { }

	// RVA: 0x15BF440
	public Vector3 get_max() { }

	// RVA: 0x15BF45C
	public void set_max(Vector3 value) { }

	// RVA: 0x15BF4AC
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x15BF528
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x15BF5A8
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x15BF5E0
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x15BF658
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x15BF754
	public bool Intersects(Bounds bounds) { }

	// RVA: 0x15BF7F0
	public bool IntersectRay(Ray ray) { }

	// RVA: 0x15BF8BC
	public override string ToString() { }

	// RVA: 0x15BFA78
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15BFC24
	public bool Contains(Vector3 point) { }

	// RVA: 0x15BFCE4
	public float SqrDistance(Vector3 point) { }

	// RVA: 0x15BF864
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, float dist) { }

	// RVA: 0x15BFC7C
	private static bool Contains_Injected(Bounds _unity_self, Vector3 point) { }

	// RVA: 0x15BFD3C
	private static float SqrDistance_Injected(Bounds _unity_self, Vector3 point) { }

	// RVA: 0x15BFDA4
	private static bool IntersectRayAABB_Injected(Ray ray, Bounds bounds, float dist) { }

}

// Namespace: UnityEngine
public struct BoundsInt
{
	// Fields
	private Vector3Int m_Position; // 0x10
	private Vector3Int m_Size; // 0x1C

	// Methods

	// RVA: 0x15BFDFC
	public Vector3Int get_position() { }

	// RVA: 0x15BFE0C
	public void set_position(Vector3Int value) { }

	// RVA: 0x15BFE18
	public Vector3Int get_size() { }

	// RVA: 0x15BFE28
	public void set_size(Vector3Int value) { }

	// RVA: 0x15BFE34
	public void .ctor(Vector3Int position, Vector3Int size) { }

	// RVA: 0x15BFE48
	public override string ToString() { }

	// RVA: 0x15BFFE0
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15C0358
	public override bool Equals(object other) { }

	// RVA: 0x15C0430
	public bool Equals(BoundsInt other) { }

	// RVA: 0x15C0494
	public override int GetHashCode() { }

}

// Namespace: UnityEngine
public sealed class GeometryUtility
{
	// Methods

	// RVA: 0x15C0574
	public static Plane[] CalculateFrustumPlanes(Camera camera) { }

	// RVA: 0x15C05E0
	public static void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	// RVA: 0x15C06E8
	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	// RVA: 0x15C0864
	public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	// RVA: 0x15C07FC
	private static void Internal_ExtractPlanes(Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	// RVA: 0x15C08CC
	private static bool TestPlanesAABB_Injected(Plane[] planes, Bounds bounds) { }

	// RVA: 0x15C0934
	private static void Internal_ExtractPlanes_Injected(Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

}

// Namespace: UnityEngine
public struct Plane
{
	// Fields
	private Vector3 m_Normal; // 0x10
	private float m_Distance; // 0x1C

	// Methods

	// RVA: 0x15C099C
	public Vector3 get_normal() { }

	// RVA: 0x15C09A8
	public float get_distance() { }

	// RVA: 0x15C09B0
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x15C0AE0
	public void .ctor(Vector3 inNormal, float d) { }

	// RVA: 0x15C0BE8
	public void .ctor(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0x15C0D5C
	public float GetDistanceToPoint(Vector3 point) { }

	// RVA: 0x15C0D80
	public bool Raycast(Ray ray, float enter) { }

	// RVA: 0x15C0E8C
	public override string ToString() { }

	// RVA: 0x15C1048
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public struct Ray
{
	// Fields
	private Vector3 m_Origin; // 0x10
	private Vector3 m_Direction; // 0x1C

	// Methods

	// RVA: 0x15C11F4
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x15C1300
	public Vector3 get_origin() { }

	// RVA: 0x15C130C
	public void set_origin(Vector3 value) { }

	// RVA: 0x15C1318
	public Vector3 get_direction() { }

	// RVA: 0x15C1324
	public void set_direction(Vector3 value) { }

	// RVA: 0x15C1428
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x15C1450
	public override string ToString() { }

	// RVA: 0x15C160C
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public struct Rect
{
	// Fields
	private float m_XMin; // 0x10
	private float m_YMin; // 0x14
	private float m_Width; // 0x18
	private float m_Height; // 0x1C

	// Methods

	// RVA: 0x15C17B8
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x15C17C4
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x15C17D0
	public void .ctor(Rect source) { }

	// RVA: 0x15C17DC
	public static Rect get_zero() { }

	// RVA: 0x15C17F0
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x15C17FC
	public float get_x() { }

	// RVA: 0x15C1804
	public void set_x(float value) { }

	// RVA: 0x15C180C
	public float get_y() { }

	// RVA: 0x15C1814
	public void set_y(float value) { }

	// RVA: 0x15C181C
	public Vector2 get_position() { }

	// RVA: 0x15C1824
	public void set_position(Vector2 value) { }

	// RVA: 0x15C182C
	public Vector2 get_center() { }

	// RVA: 0x15C1844
	public void set_center(Vector2 value) { }

	// RVA: 0x15C1860
	public Vector2 get_min() { }

	// RVA: 0x15C1868
	public void set_min(Vector2 value) { }

	// RVA: 0x15C1884
	public Vector2 get_max() { }

	// RVA: 0x15C1898
	public void set_max(Vector2 value) { }

	// RVA: 0x15C18AC
	public float get_width() { }

	// RVA: 0x15C18B4
	public void set_width(float value) { }

	// RVA: 0x15C18BC
	public float get_height() { }

	// RVA: 0x15C18C4
	public void set_height(float value) { }

	// RVA: 0x15C18CC
	public Vector2 get_size() { }

	// RVA: 0x15C18D4
	public void set_size(Vector2 value) { }

	// RVA: 0x15C18DC
	public float get_xMin() { }

	// RVA: 0x15C18E4
	public void set_xMin(float value) { }

	// RVA: 0x15C1900
	public float get_yMin() { }

	// RVA: 0x15C1908
	public void set_yMin(float value) { }

	// RVA: 0x15C1924
	public float get_xMax() { }

	// RVA: 0x15C1934
	public void set_xMax(float value) { }

	// RVA: 0x15C1944
	public float get_yMax() { }

	// RVA: 0x15C1954
	public void set_yMax(float value) { }

	// RVA: 0x15C1964
	public bool Contains(Vector2 point) { }

	// RVA: 0x15C19A8
	public bool Contains(Vector3 point) { }

	// RVA: 0x15C19EC
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x15C1A18
	public bool Overlaps(Rect other) { }

	// RVA: 0x15C1A64
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x15C1AF4
	public static Vector2 PointToNormalized(Rect rectangle, Vector2 point) { }

	// RVA: 0x15C1B68
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x15C1B8C
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x15C1BB0
	public override int GetHashCode() { }

	// RVA: 0x15C1C44
	public override bool Equals(object other) { }

	// RVA: 0x15C1E44
	public bool Equals(Rect other) { }

	// RVA: 0x15C1EEC
	public override string ToString() { }

	// RVA: 0x15C1EF8
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public struct RectInt
{
	// Fields
	private int m_XMin; // 0x10
	private int m_YMin; // 0x14
	private int m_Width; // 0x18
	private int m_Height; // 0x1C

	// Methods

	// RVA: 0x15C2168
	public int get_x() { }

	// RVA: 0x15C2170
	public void set_x(int value) { }

	// RVA: 0x15C2178
	public int get_y() { }

	// RVA: 0x15C2180
	public void set_y(int value) { }

	// RVA: 0x15C2188
	public int get_width() { }

	// RVA: 0x15C2190
	public void set_width(int value) { }

	// RVA: 0x15C2198
	public int get_height() { }

	// RVA: 0x15C21A0
	public void set_height(int value) { }

	// RVA: 0x15C21A8
	public int get_xMin() { }

	// RVA: 0x15C2218
	public int get_yMin() { }

	// RVA: 0x15C2288
	public int get_xMax() { }

	// RVA: 0x15C22F8
	public int get_yMax() { }

	// RVA: 0x15C2368
	public void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x15C2374
	public bool Overlaps(RectInt other) { }

	// RVA: 0x15C2A94
	public override string ToString() { }

	// RVA: 0x15C2CF0
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15C2F34
	public bool Equals(RectInt other) { }

}

// Namespace: UnityEngine
[Serializable]
public class RectOffset
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Methods

	// RVA: 0x15C2F78
	public void .ctor() { }

	// RVA: 0x15C3014
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x15C305C
	protected override void Finalize() { }

	// RVA: 0x15C31A8
	public void .ctor(int left, int right, int top, int bottom) { }

	// RVA: 0x15C34BC
	public override string ToString() { }

	// RVA: 0x15C37A8
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15C3140
	private void Destroy() { }

	// RVA: 0x15C2FD4
	private static IntPtr InternalCreate() { }

	// RVA: 0x15C3BBC
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x15C3A7C
	public int get_left() { }

	// RVA: 0x15C331C
	public void set_left(int value) { }

	// RVA: 0x15C3ACC
	public int get_right() { }

	// RVA: 0x15C3384
	public void set_right(int value) { }

	// RVA: 0x15C3B1C
	public int get_top() { }

	// RVA: 0x15C33EC
	public void set_top(int value) { }

	// RVA: 0x15C3B6C
	public int get_bottom() { }

	// RVA: 0x15C3454
	public void set_bottom(int value) { }

	// RVA: 0x15C3C0C
	public int get_horizontal() { }

	// RVA: 0x15C3C5C
	public int get_vertical() { }

	// RVA: 0x15C3CAC
	public Rect Remove(Rect rect) { }

	// RVA: 0x15C3D14
	private void Remove_Injected(Rect rect, Rect ret) { }

}

// Namespace: UnityEngine
public sealed class LightingSettings
{
	// Methods

	// RVA: 0x15C3D6C
	internal void LightingSettingsDontStripMe() { }

}

// Namespace: UnityEngine
public sealed class Gizmos
{
	// Methods

	// RVA: 0x15C3D70
	public static void DrawLine(Vector3 from, Vector3 to) { }

	// RVA: 0x15C3E34
	public static void DrawWireSphere(Vector3 center, float radius) { }

	// RVA: 0x15C3EFC
	public static void DrawSphere(Vector3 center, float radius) { }

	// RVA: 0x15C3FC4
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	// RVA: 0x15C4088
	public static void DrawCube(Vector3 center, Vector3 size) { }

	// RVA: 0x15C414C
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15C4244
	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15C433C
	public static void set_color(Color value) { }

	// RVA: 0x15C43F4
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x15C4494
	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	// RVA: 0x15C4584
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	// RVA: 0x15C45EC
	public static void DrawMesh(Mesh mesh) { }

	// RVA: 0x15C4710
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15C478C
	public static void DrawWireMesh(Mesh mesh) { }

	// RVA: 0x15C48B0
	public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15C3DCC
	private static void DrawLine_Injected(Vector3 from, Vector3 to) { }

	// RVA: 0x15C3E94
	private static void DrawWireSphere_Injected(Vector3 center, float radius) { }

	// RVA: 0x15C3F5C
	private static void DrawSphere_Injected(Vector3 center, float radius) { }

	// RVA: 0x15C4020
	private static void DrawWireCube_Injected(Vector3 center, Vector3 size) { }

	// RVA: 0x15C40E4
	private static void DrawCube_Injected(Vector3 center, Vector3 size) { }

	// RVA: 0x15C41D4
	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15C42CC
	private static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15C43A4
	private static void set_color_Injected(Color value) { }

	// RVA: 0x15C4444
	private static void set_matrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15C4514
	private static void DrawFrustum_Injected(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

}

// Namespace: 
private struct OrderBlock
{
	// Fields
	internal int order; // 0x10
	internal UnityAction callback; // 0x18
}

// Namespace: UnityEngine
internal static class BeforeRenderHelper
{
	// Fields
	private static System.Collections.Generic.List<UnityEngine.BeforeRenderHelper.OrderBlock> s_OrderBlocks; // 0x0

	// Methods

	// RVA: 0x15B3270
	public static void Invoke() { }

	// RVA: 0x15C492C
	private static void .cctor() { }

}

// Namespace: UnityEngine
public static class CustomRenderTextureManager
{
	// Fields
	private static System.Action<UnityEngine.CustomRenderTexture> textureLoaded; // 0x0
	private static System.Action<UnityEngine.CustomRenderTexture> textureUnloaded; // 0x8

	// Methods

	// RVA: 0x15C49C8
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	// RVA: 0x15C4A44
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }

}

// Namespace: 
public sealed class DisplaysUpdatedDelegate
{
	// Methods

	// RVA: 0x15C545C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15C54FC
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public class Display
{
	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	private static int m_ActiveEditorGameViewTarget; // 0x10
	private static DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18

	// Methods

	// RVA: 0x15C4AC0
	internal void .ctor() { }

	// RVA: 0x15C4B08
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x15C4B34
	public int get_renderingWidth() { }

	// RVA: 0x15C4C50
	public int get_renderingHeight() { }

	// RVA: 0x15C4D14
	public int get_systemWidth() { }

	// RVA: 0x15C4E30
	public int get_systemHeight() { }

	// RVA: 0x15C4EF4
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x15C504C
	public static Display get_main() { }

	// RVA: 0x15C50C8
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	// RVA: 0x15C5268
	internal static void FireDisplaysUpdated() { }

	// RVA: 0x15C4DD8
	private static void GetSystemExtImpl(IntPtr nativeDisplay, int w, int h) { }

	// RVA: 0x15C4BF8
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, int w, int h) { }

	// RVA: 0x15C4FE4
	private static int RelativeMouseAtImpl(int x, int y, int rx, int ry) { }

	// RVA: 0x15C5318
	private static void .cctor() { }

}

// Namespace: UnityEngine
public enum FullScreenMode
{
	// Fields
	public int value__; // 0x10
	public const FullScreenMode ExclusiveFullScreen = 0;
	public const FullScreenMode FullScreenWindow = 1;
	public const FullScreenMode MaximizedWindow = 2;
	public const FullScreenMode Windowed = 3;
}

// Namespace: UnityEngine
public struct RefreshRate
{
	// Fields
	public UInt32 numerator; // 0x10
	public UInt32 denominator; // 0x14

	// Methods

	// RVA: 0x15C5510
	public Double get_value() { }

	// RVA: 0x15C5524
	public bool Equals(RefreshRate other) { }

	// RVA: 0x15C5564
	public int CompareTo(RefreshRate other) { }

	// RVA: 0x15C55D0
	public override string ToString() { }

}

// Namespace: UnityEngine
public sealed class Screen
{
	// Methods

	// RVA: 0x15C5678
	public static int get_width() { }

	// RVA: 0x15C56B8
	public static int get_height() { }

	// RVA: 0x15C56F8
	public static float get_dpi() { }

	// RVA: 0x15C5738
	private static ScreenOrientation GetScreenOrientation() { }

	// RVA: 0x15C5778
	public static ScreenOrientation get_orientation() { }

	// RVA: 0x15C57B8
	public static void set_sleepTimeout(int value) { }

	// RVA: 0x15C5808
	public static Resolution get_currentResolution() { }

	// RVA: 0x15C58A8
	public static bool get_fullScreen() { }

	// RVA: 0x15C58E8
	public static Rect get_safeArea() { }

	// RVA: 0x15C598C
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	// RVA: 0x15C5A60
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	// RVA: 0x15C5ADC
	public static void SetResolution(int width, int height, bool fullscreen) { }

	// RVA: 0x15C5B54
	public static Resolution[] get_resolutions() { }

	// RVA: 0x15C5858
	private static void get_currentResolution_Injected(Resolution ret) { }

	// RVA: 0x15C593C
	private static void get_safeArea_Injected(Rect ret) { }

	// RVA: 0x15C59F8
	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

}

// Namespace: UnityEngine
public struct RenderBuffer
{
	// Fields
	internal int m_RenderTextureInstanceID; // 0x10
	internal IntPtr m_BufferPtr; // 0x18
}

// Namespace: UnityEngine
public class Graphics
{
	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x0
	internal static System.Collections.Generic.Dictionary<System.Int32,UnityEngine.RenderInstancedDataLayout> s_RenderInstancedDataLayouts; // 0x8

	// Methods

	// RVA: 0x15C5B94
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	// RVA: 0x15C5BD4
	private static void Internal_SetNullRT() { }

	// RVA: 0x15C5C14
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x15C5D54
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	// RVA: 0x15C5E60
	internal static void Internal_DrawTexture(Internal_DrawTextureArguments args) { }

	// RVA: 0x15C5EB0
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	// RVA: 0x15C5F20
	private static void Blit2(Texture source, RenderTexture dest) { }

	// RVA: 0x15C5F88
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0x15C5FD8
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x15C6118
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x15C6388
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x15C6408
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x15C64B0
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x15C6660
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x15C66F8
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x15C67B0
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x15C6870
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x15C6974
	public static void Blit(Texture source, Material mat, int pass) { }

	// RVA: 0x15C6A30
	public static void Blit(Texture source, Material mat) { }

	// RVA: 0x15C6B28
	public static void SetRenderTarget(RenderTexture rt) { }

	// RVA: 0x15C6BEC
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

	// RVA: 0x15C6CDC
	private static void .cctor() { }

	// RVA: 0x15C5CE4
	private static void Internal_SetRTSimple_Injected(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x15C5E08
	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

}

// Namespace: UnityEngine
public sealed class GL
{
	// Methods

	// RVA: 0x15C6D9C
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x15C6DF8
	public static void Vertex(Vector3 v) { }

	// RVA: 0x15C6E54
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x15C6EB0
	public static void TexCoord2(float x, float y) { }

	// RVA: 0x15C6F00
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x15C6F64
	public static void Color(Color c) { }

	// RVA: 0x15C6FC8
	public static void Flush() { }

	// RVA: 0x15C7008
	private static void SetViewMatrix(Matrix4x4 m) { }

	// RVA: 0x15C70A8
	public static void set_modelview(Matrix4x4 value) { }

	// RVA: 0x15C7118
	public static void PushMatrix() { }

	// RVA: 0x15C7158
	public static void PopMatrix() { }

	// RVA: 0x15C7198
	public static void LoadOrtho() { }

	// RVA: 0x15C71D8
	public static void LoadPixelMatrix() { }

	// RVA: 0x15C7218
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	// RVA: 0x15C72B8
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	// RVA: 0x15C7390
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x15C73F4
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	// RVA: 0x15C7458
	public static void Begin(int mode) { }

	// RVA: 0x15C74A8
	public static void End() { }

	// RVA: 0x15C74E8
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x15C75C8
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x15C7640
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x15C76AC
	public static void Viewport(Rect pixelRect) { }

	// RVA: 0x15C7058
	private static void SetViewMatrix_Injected(Matrix4x4 m) { }

	// RVA: 0x15C7268
	private static void LoadProjectionMatrix_Injected(Matrix4x4 mat) { }

	// RVA: 0x15C7338
	private static void GetGPUProjectionMatrix_Injected(Matrix4x4 proj, bool renderIntoTexture, Matrix4x4 ret) { }

	// RVA: 0x15C7560
	private static void GLClear_Injected(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x15C7714
	private static void Viewport_Injected(Rect pixelRect) { }

}

// Namespace: UnityEngine
public sealed class LightmapSettings
{
	// Methods

	// RVA: 0x15C7764
	public static void set_lightProbes(LightProbes value) { }

}

// Namespace: UnityEngine
public sealed class LightProbes
{
	// Fields
	private static Action lightProbesUpdated; // 0x0
	private static Action tetrahedralizationCompleted; // 0x8
	private static Action needsRetetrahedralization; // 0x10

	// Methods

	// RVA: 0x15C77B4
	private static void Internal_CallLightProbesUpdatedFunction() { }

	// RVA: 0x15C781C
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	// RVA: 0x15C7884
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

	// RVA: 0x15C78EC
	public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, SphericalHarmonicsL2 probe) { }

	// RVA: 0x15C7954
	private static void GetInterpolatedProbe_Injected(Vector3 position, Renderer renderer, SphericalHarmonicsL2 probe) { }

}

// Namespace: UnityEngine
public struct Resolution
{
	// Fields
	private int m_Width; // 0x10
	private int m_Height; // 0x14
	private RefreshRate m_RefreshRate; // 0x18

	// Methods

	// RVA: 0x15C79AC
	public int get_width() { }

	// RVA: 0x15C79B4
	public int get_height() { }

	// RVA: 0x15C79BC
	public RefreshRate get_refreshRateRatio() { }

	// RVA: 0x15C79C4
	public int get_refreshRate() { }

	// RVA: 0x15C7AD8
	public override string ToString() { }

}

// Namespace: UnityEngine
internal struct RenderInstancedDataLayout
{
	// Fields
	private readonly int <size>k__BackingField; // 0x10
	private readonly int <offsetObjectToWorld>k__BackingField; // 0x14
	private readonly int <offsetPrevObjectToWorld>k__BackingField; // 0x18
	private readonly int <offsetRenderingLayerMask>k__BackingField; // 0x1C
}

// Namespace: UnityEngine
internal struct Internal_DrawTextureArguments
{
	// Fields
	public Rect screenRect; // 0x10
	public Rect sourceRect; // 0x20
	public int leftBorder; // 0x30
	public int rightBorder; // 0x34
	public int topBorder; // 0x38
	public int bottomBorder; // 0x3C
	public Color leftBorderColor; // 0x40
	public Color rightBorderColor; // 0x50
	public Color topBorderColor; // 0x60
	public Color bottomBorderColor; // 0x70
	public Color color; // 0x80
	public Vector4 borderWidths; // 0x90
	public Vector4 cornerRadiuses; // 0xA0
	public bool smoothCorners; // 0xB0
	public int pass; // 0xB4
	public Texture texture; // 0xB8
	public Material mat; // 0xC0
}

// Namespace: UnityEngine
public sealed class QualitySettings
{
	// Fields
	private static System.Action<System.Int32,System.Int32> activeQualityLevelChanged; // 0x0

	// Methods

	// RVA: 0x15C7C80
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	// RVA: 0x15C7D04
	public static float get_lodBias() { }

	// RVA: 0x15C7D44
	public static void set_lodBias(float value) { }

	// RVA: 0x15C7D9C
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	// RVA: 0x15C7DEC
	public static int get_globalTextureMipmapLimit() { }

	// RVA: 0x15C7E2C
	public static void set_globalTextureMipmapLimit(int value) { }

	// RVA: 0x15C7E7C
	public static void set_maximumLODLevel(int value) { }

	// RVA: 0x15C7ECC
	public static int get_vSyncCount() { }

	// RVA: 0x15C7F0C
	public static void set_vSyncCount(int value) { }

	// RVA: 0x15C7F5C
	public static void set_antiAliasing(int value) { }

	// RVA: 0x15C7FAC
	public static void SetTextureMipmapLimitSettings(string groupName, TextureMipmapLimitSettings textureMipmapLimitSettings) { }

	// RVA: 0x15C8068
	public static TextureMipmapLimitSettings GetTextureMipmapLimitSettings(string groupName) { }

	// RVA: 0x15C8128
	private static ScriptableObject get_INTERNAL_renderPipeline() { }

	// RVA: 0x15C8168
	private static void set_INTERNAL_renderPipeline(ScriptableObject value) { }

	// RVA: 0x15C81B8
	public static RenderPipelineAsset get_renderPipeline() { }

	// RVA: 0x15C8278
	public static void set_renderPipeline(RenderPipelineAsset value) { }

	// RVA: 0x15C82C8
	public static ColorSpace get_activeColorSpace() { }

	// RVA: 0x15C8000
	private static void SetTextureMipmapLimitSettings_Injected(string groupName, TextureMipmapLimitSettings textureMipmapLimitSettings) { }

	// RVA: 0x15C80C0
	private static void GetTextureMipmapLimitSettings_Injected(string groupName, TextureMipmapLimitSettings ret) { }

}

// Namespace: UnityEngine
public sealed class TrailRenderer
{
	// Methods

	// RVA: 0x15C8308
	public void set_startColor(Color value) { }

	// RVA: 0x15C83C8
	public void set_endColor(Color value) { }

	// RVA: 0x15C8488
	public int get_positionCount() { }

	// RVA: 0x15C84D8
	public void Clear() { }

	// RVA: 0x15C8360
	private void set_startColor_Injected(Color value) { }

	// RVA: 0x15C8420
	private void set_endColor_Injected(Color value) { }

}

// Namespace: UnityEngine
public sealed class MaterialPropertyBlock
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15C8528
	private void SetFloatImpl(int name, float value) { }

	// RVA: 0x15C8588
	private void SetVectorImpl(int name, Vector4 value) { }

	// RVA: 0x15C8648
	private void SetColorImpl(int name, Color value) { }

	// RVA: 0x15C8708
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x15C87B8
	private void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x15C8810
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	// RVA: 0x15C8878
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x15C88E0
	private static IntPtr CreateImpl() { }

	// RVA: 0x15C8920
	private static void DestroyImpl(IntPtr mpb) { }

	// RVA: 0x15C8970
	private void Clear(bool keepMemory) { }

	// RVA: 0x15C89D8
	public void Clear() { }

	// RVA: 0x15C8A30
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x15C8B5C
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x15C8C88
	public void .ctor() { }

	// RVA: 0x15C8CE4
	protected override void Finalize() { }

	// RVA: 0x15C8E04
	private void Dispose() { }

	// RVA: 0x15C8ED0
	public void SetFloat(string name, float value) { }

	// RVA: 0x15C8FC8
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x15C9028
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x15C9090
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x15C90F8
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x15C9198
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x15C91F0
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x15C920C
	public void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x15C85F0
	private void SetVectorImpl_Injected(int name, Vector4 value) { }

	// RVA: 0x15C86B0
	private void SetColorImpl_Injected(int name, Color value) { }

	// RVA: 0x15C8760
	private void SetMatrixImpl_Injected(int name, Matrix4x4 value) { }

}

// Namespace: UnityEngine
public class Renderer
{
	// Methods

	// RVA: 0x15C9228
	public Bounds get_bounds() { }

	// RVA: 0x15C9304
	public void set_bounds(Bounds value) { }

	// RVA: 0x15C93D4
	private void SetStaticLightmapST(Vector4 st) { }

	// RVA: 0x15C9494
	private Material GetSharedMaterial() { }

	// RVA: 0x15C94E4
	private void SetMaterial(Material m) { }

	// RVA: 0x15C954C
	private Material[] GetMaterialArray() { }

	// RVA: 0x15C959C
	private void CopySharedMaterialArray(Material[] m) { }

	// RVA: 0x15C9604
	private void SetMaterialArray(Material[] m, int length) { }

	// RVA: 0x15C965C
	private void SetMaterialArray(Material[] m) { }

	// RVA: 0x15C96C8
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x15C9730
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	// RVA: 0x15C9798
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x15C9800
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x15C9868
	public bool get_enabled() { }

	// RVA: 0x15C98B8
	public void set_enabled(bool value) { }

	// RVA: 0x15C9920
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x15C9988
	public void set_receiveShadows(bool value) { }

	// RVA: 0x15C99F0
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x15C9A40
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x15C9AA8
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x15C9B10
	public void set_allowOcclusionWhenDynamic(bool value) { }

	// RVA: 0x15C9B78
	public bool get_isPartOfStaticBatch() { }

	// RVA: 0x15C9BC8
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x15C9CA8
	public void set_probeAnchor(Transform value) { }

	// RVA: 0x15C9D10
	private int GetLightmapIndex(LightmapType lt) { }

	// RVA: 0x15C9D78
	private void SetLightmapIndex(int index, LightmapType lt) { }

	// RVA: 0x15C9DD0
	private Vector4 GetLightmapST(LightmapType lt) { }

	// RVA: 0x15C9E94
	public int get_lightmapIndex() { }

	// RVA: 0x15C9EEC
	public void set_lightmapIndex(int value) { }

	// RVA: 0x15C9F40
	public Vector4 get_lightmapScaleOffset() { }

	// RVA: 0x15C9FA0
	public void set_lightmapScaleOffset(Vector4 value) { }

	// RVA: 0x15C9FF8
	private int GetMaterialCount() { }

	// RVA: 0x15CA048
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x15CA098
	public Material[] get_materials() { }

	// RVA: 0x15CA0E8
	public void set_materials(Material[] value) { }

	// RVA: 0x15CA154
	public Material get_sharedMaterial() { }

	// RVA: 0x15CA1A4
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x15CA20C
	public Material[] get_sharedMaterials() { }

	// RVA: 0x15CA25C
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x15CA2C8
	public void GetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material> m) { }

	// RVA: 0x15CA404
	public void .ctor() { }

	// RVA: 0x15C929C
	private void get_bounds_Injected(Bounds ret) { }

	// RVA: 0x15C936C
	private void set_bounds_Injected(Bounds value) { }

	// RVA: 0x15C942C
	private void SetStaticLightmapST_Injected(Vector4 st) { }

	// RVA: 0x15C9C40
	private void get_localToWorldMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15C9E3C
	private void GetLightmapST_Injected(LightmapType lt, Vector4 ret) { }

}

// Namespace: UnityEngine
public sealed class RenderSettings
{}

// Namespace: UnityEngine
public sealed class Shader
{
	// Methods

	// RVA: 0x15CA40C
	public static Shader Find(string name) { }

	// RVA: 0x15CA49C
	public static int get_globalMaximumLOD() { }

	// RVA: 0x15CA4DC
	public static void set_globalMaximumLOD(int value) { }

	// RVA: 0x15CA52C
	public bool get_isSupported() { }

	// RVA: 0x15CA57C
	public static void EnableKeyword(string keyword) { }

	// RVA: 0x15CA5CC
	public static void DisableKeyword(string keyword) { }

	// RVA: 0x15CA61C
	public int get_renderQueue() { }

	// RVA: 0x15CA66C
	public static void WarmupAllShaders() { }

	// RVA: 0x15CA6AC
	internal static int TagToID(string name) { }

	// RVA: 0x15C8F78
	public static int PropertyToID(string name) { }

	// RVA: 0x15CA6FC
	private static void SetGlobalFloatImpl(int name, float value) { }

	// RVA: 0x15CA764
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	// RVA: 0x15CA824
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x15CA8F4
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	// RVA: 0x15CA95C
	private static Vector4 GetGlobalVectorImpl(int name) { }

	// RVA: 0x15CAA20
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x15CAA88
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x15CAB2C
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x15CAB84
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x15CABDC
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x15CAC3C
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x15CACA4
	public static Vector4 GetGlobalVector(int nameID) { }

	// RVA: 0x15CAD00
	private void .ctor() { }

	// RVA: 0x15CA7BC
	private static void SetGlobalVectorImpl_Injected(int name, Vector4 value) { }

	// RVA: 0x15CA88C
	private static void SetGlobalMatrixImpl_Injected(int name, Matrix4x4 value) { }

	// RVA: 0x15CA9B8
	private static void GetGlobalVectorImpl_Injected(int name, Vector4 ret) { }

}

// Namespace: UnityEngine
public class Material
{
	// Methods

	// RVA: 0x15CAD88
	private static void CreateWithShader(Material self, Shader shader) { }

	// RVA: 0x15CADF0
	private static void CreateWithMaterial(Material self, Material source) { }

	// RVA: 0x15CAE58
	private static void CreateWithString(Material self) { }

	// RVA: 0x15CAEA8
	public void .ctor(Shader shader) { }

	// RVA: 0x15CAF78
	public void .ctor(Material source) { }

	// RVA: 0x15CB048
	public void .ctor(string contents) { }

	// RVA: 0x15CB10C
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x15CB14C
	public Shader get_shader() { }

	// RVA: 0x15CB19C
	public void set_shader(Shader value) { }

	// RVA: 0x15CB204
	public Color get_color() { }

	// RVA: 0x15CB494
	public Texture get_mainTexture() { }

	// RVA: 0x15CB6C0
	public void set_mainTexture(Texture value) { }

	// RVA: 0x15CB328
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	// RVA: 0x15CB8C4
	public bool HasProperty(int nameID) { }

	// RVA: 0x15CB92C
	public bool HasProperty(string name) { }

	// RVA: 0x15CB9D8
	public int get_renderQueue() { }

	// RVA: 0x15CBA28
	public void EnableKeyword(string keyword) { }

	// RVA: 0x15CBA90
	public void DisableKeyword(string keyword) { }

	// RVA: 0x15CBAF8
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x15CBB60
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x15CBBC8
	public string GetTag(string tag, bool searchFallbacks) { }

	// RVA: 0x15CBC58
	public bool SetPass(int pass) { }

	// RVA: 0x15CBCC0
	public void CopyPropertiesFromMaterial(Material mat) { }

	// RVA: 0x15CBD28
	private string[] GetShaderKeywords() { }

	// RVA: 0x15CBD78
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x15CBDE0
	public string[] get_shaderKeywords() { }

	// RVA: 0x15CBE30
	public void set_shaderKeywords(string[] value) { }

	// RVA: 0x15CBE98
	public int ComputeCRC() { }

	// RVA: 0x15CBEE8
	private void SetFloatImpl(int name, float value) { }

	// RVA: 0x15CBF48
	private void SetColorImpl(int name, Color value) { }

	// RVA: 0x15CC008
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x15CC0B8
	private void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x15CC110
	private float GetFloatImpl(int name) { }

	// RVA: 0x15CC178
	private Color GetColorImpl(int name) { }

	// RVA: 0x15CC23C
	private Texture GetTextureImpl(int name) { }

	// RVA: 0x15CC2A4
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	// RVA: 0x15CC30C
	private void SetColorArray(int name, Color[] values, int count) { }

	// RVA: 0x15CC438
	public void SetInt(string name, int value) { }

	// RVA: 0x15CC4D8
	public void SetFloat(string name, float value) { }

	// RVA: 0x15CC580
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x15CC5E0
	public void SetColor(string name, Color value) { }

	// RVA: 0x15CC694
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x15CC6FC
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x15CC764
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x15CB824
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x15CB7CC
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x15CC7D4
	public void SetColorArray(int nameID, Color[] values) { }

	// RVA: 0x15CC7F0
	public float GetFloat(int nameID) { }

	// RVA: 0x15CB3FC
	public Color GetColor(string name) { }

	// RVA: 0x15CB390
	public Color GetColor(int nameID) { }

	// RVA: 0x15CB614
	public Texture GetTexture(string name) { }

	// RVA: 0x15CB5AC
	public Texture GetTexture(int nameID) { }

	// RVA: 0x15CBFB0
	private void SetColorImpl_Injected(int name, Color value) { }

	// RVA: 0x15CC060
	private void SetMatrixImpl_Injected(int name, Matrix4x4 value) { }

	// RVA: 0x15CC1E4
	private void GetColorImpl_Injected(int name, Color ret) { }

}

// Namespace: UnityEngine
public struct LightBakingOutput
{
	// Fields
	public int probeOcclusionLightIndex; // 0x10
	public int occlusionMaskChannel; // 0x14
	public LightmapBakeType lightmapBakeType; // 0x18
	public MixedLightingMode mixedLightingMode; // 0x1C
	public bool isBaked; // 0x20
}

// Namespace: UnityEngine
public sealed class Light
{
	// Fields
	private int m_BakedIndex; // 0x18

	// Methods

	// RVA: 0x15CC858
	public LightType get_type() { }

	// RVA: 0x15CC8A8
	public float get_spotAngle() { }

	// RVA: 0x15CC8F8
	public Color get_color() { }

	// RVA: 0x15CC9BC
	public float get_colorTemperature() { }

	// RVA: 0x15CCA0C
	public bool get_useColorTemperature() { }

	// RVA: 0x15CCA5C
	public float get_intensity() { }

	// RVA: 0x15CCAAC
	public float get_bounceIntensity() { }

	// RVA: 0x15CCAFC
	public float get_range() { }

	// RVA: 0x15CCB4C
	public LightBakingOutput get_bakingOutput() { }

	// RVA: 0x15CCC28
	public LightShadows get_shadows() { }

	// RVA: 0x15CCC78
	public float get_cookieSize() { }

	// RVA: 0x15CCCC8
	public Texture get_cookie() { }

	// RVA: 0x15CC954
	private void get_color_Injected(Color ret) { }

	// RVA: 0x15CCBC0
	private void get_bakingOutput_Injected(LightBakingOutput ret) { }

}

// Namespace: UnityEngine
public sealed class MeshFilter
{
	// Methods

	// RVA: 0x15CCD18
	private void DontStripMeshFilter() { }

	// RVA: 0x15CCD1C
	public Mesh get_sharedMesh() { }

	// RVA: 0x15CCD6C
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x15CCDD4
	public void set_mesh(Mesh value) { }

}

// Namespace: UnityEngine
public enum RenderingPath
{
	// Fields
	public int value__; // 0x10
	public const RenderingPath UsePlayerSettings = 4294967295;
	public const RenderingPath VertexLit = 0;
	public const RenderingPath Forward = 1;
	public const RenderingPath DeferredLighting = 2;
	public const RenderingPath DeferredShading = 3;
}

// Namespace: UnityEngine
public enum TransparencySortMode
{
	// Fields
	public int value__; // 0x10
	public const TransparencySortMode Default = 0;
	public const TransparencySortMode Perspective = 1;
	public const TransparencySortMode Orthographic = 2;
	public const TransparencySortMode CustomAxis = 3;
}

// Namespace: UnityEngine
public enum StereoTargetEyeMask
{
	// Fields
	public int value__; // 0x10
	public const StereoTargetEyeMask None = 0;
	public const StereoTargetEyeMask Left = 1;
	public const StereoTargetEyeMask Right = 2;
	public const StereoTargetEyeMask Both = 3;
}

// Namespace: UnityEngine
public enum CameraType
{
	// Fields
	public int value__; // 0x10
	public const CameraType Game = 1;
	public const CameraType SceneView = 2;
	public const CameraType Preview = 4;
	public const CameraType VR = 8;
	public const CameraType Reflection = 16;
}

// Namespace: UnityEngine
public enum LightType
{
	// Fields
	public int value__; // 0x10
	public const LightType Spot = 0;
	public const LightType Directional = 1;
	public const LightType Point = 2;
	public const LightType Area = 3;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
}

// Namespace: UnityEngine
public enum LightShadows
{
	// Fields
	public int value__; // 0x10
	public const LightShadows None = 0;
	public const LightShadows Hard = 1;
	public const LightShadows Soft = 2;
}

// Namespace: UnityEngine
public enum LightmapBakeType
{
	// Fields
	public int value__; // 0x10
	public const LightmapBakeType Realtime = 4;
	public const LightmapBakeType Baked = 2;
	public const LightmapBakeType Mixed = 1;
}

// Namespace: UnityEngine
public enum MixedLightingMode
{
	// Fields
	public int value__; // 0x10
	public const MixedLightingMode IndirectOnly = 0;
	public const MixedLightingMode Shadowmask = 2;
	public const MixedLightingMode Subtractive = 1;
}

// Namespace: UnityEngine
public enum CameraClearFlags
{
	// Fields
	public int value__; // 0x10
	public const CameraClearFlags Skybox = 1;
	public const CameraClearFlags Color = 2;
	public const CameraClearFlags SolidColor = 2;
	public const CameraClearFlags Depth = 3;
	public const CameraClearFlags Nothing = 4;
}

// Namespace: UnityEngine
public enum DepthTextureMode
{
	// Fields
	public int value__; // 0x10
	public const DepthTextureMode None = 0;
	public const DepthTextureMode Depth = 1;
	public const DepthTextureMode DepthNormals = 2;
	public const DepthTextureMode MotionVectors = 4;
}

// Namespace: UnityEngine
public enum AnisotropicFiltering
{
	// Fields
	public int value__; // 0x10
	public const AnisotropicFiltering Disable = 0;
	public const AnisotropicFiltering Enable = 1;
	public const AnisotropicFiltering ForceEnable = 2;
}

// Namespace: UnityEngine
public enum MeshTopology
{
	// Fields
	public int value__; // 0x10
	public const MeshTopology Triangles = 0;
	public const MeshTopology Quads = 2;
	public const MeshTopology Lines = 3;
	public const MeshTopology LineStrip = 4;
	public const MeshTopology Points = 5;
}

// Namespace: UnityEngine
public enum SkinQuality
{
	// Fields
	public int value__; // 0x10
	public const SkinQuality Auto = 0;
	public const SkinQuality Bone1 = 1;
	public const SkinQuality Bone2 = 2;
	public const SkinQuality Bone4 = 4;
}

// Namespace: UnityEngine
public enum ColorSpace
{
	// Fields
	public int value__; // 0x10
	public const ColorSpace Uninitialized = 4294967295;
	public const ColorSpace Gamma = 0;
	public const ColorSpace Linear = 1;
}

// Namespace: UnityEngine
public enum ScreenOrientation
{
	// Fields
	public int value__; // 0x10
	public const ScreenOrientation Portrait = 1;
	public const ScreenOrientation PortraitUpsideDown = 2;
	public const ScreenOrientation LandscapeLeft = 3;
	public const ScreenOrientation LandscapeRight = 4;
	public const ScreenOrientation AutoRotation = 5;
	public const ScreenOrientation Unknown = 0;
	public const ScreenOrientation Landscape = 3;
}

// Namespace: UnityEngine
public enum FilterMode
{
	// Fields
	public int value__; // 0x10
	public const FilterMode Point = 0;
	public const FilterMode Bilinear = 1;
	public const FilterMode Trilinear = 2;
}

// Namespace: UnityEngine
public enum TextureWrapMode
{
	// Fields
	public int value__; // 0x10
	public const TextureWrapMode Repeat = 0;
	public const TextureWrapMode Clamp = 1;
	public const TextureWrapMode Mirror = 2;
	public const TextureWrapMode MirrorOnce = 3;
}

// Namespace: UnityEngine
public enum NPOTSupport
{
	// Fields
	public int value__; // 0x10
	public const NPOTSupport None = 0;
	public const NPOTSupport Restricted = 1;
	public const NPOTSupport Full = 2;
}

// Namespace: UnityEngine
public enum TextureFormat
{
	// Fields
	public int value__; // 0x10
	public const TextureFormat Alpha8 = 1;
	public const TextureFormat ARGB4444 = 2;
	public const TextureFormat RGB24 = 3;
	public const TextureFormat RGBA32 = 4;
	public const TextureFormat ARGB32 = 5;
	public const TextureFormat RGB565 = 7;
	public const TextureFormat R16 = 9;
	public const TextureFormat DXT1 = 10;
	public const TextureFormat DXT5 = 12;
	public const TextureFormat RGBA4444 = 13;
	public const TextureFormat BGRA32 = 14;
	public const TextureFormat RHalf = 15;
	public const TextureFormat RGHalf = 16;
	public const TextureFormat RGBAHalf = 17;
	public const TextureFormat RFloat = 18;
	public const TextureFormat RGFloat = 19;
	public const TextureFormat RGBAFloat = 20;
	public const TextureFormat YUY2 = 21;
	public const TextureFormat RGB9e5Float = 22;
	public const TextureFormat BC4 = 26;
	public const TextureFormat BC5 = 27;
	public const TextureFormat BC6H = 24;
	public const TextureFormat BC7 = 25;
	public const TextureFormat DXT1Crunched = 28;
	public const TextureFormat DXT5Crunched = 29;
	public const TextureFormat PVRTC_RGB2 = 30;
	public const TextureFormat PVRTC_RGBA2 = 31;
	public const TextureFormat PVRTC_RGB4 = 32;
	public const TextureFormat PVRTC_RGBA4 = 33;
	public const TextureFormat ETC_RGB4 = 34;
	public const TextureFormat EAC_R = 41;
	public const TextureFormat EAC_R_SIGNED = 42;
	public const TextureFormat EAC_RG = 43;
	public const TextureFormat EAC_RG_SIGNED = 44;
	public const TextureFormat ETC2_RGB = 45;
	public const TextureFormat ETC2_RGBA1 = 46;
	public const TextureFormat ETC2_RGBA8 = 47;
	public const TextureFormat ASTC_4x4 = 48;
	public const TextureFormat ASTC_5x5 = 49;
	public const TextureFormat ASTC_6x6 = 50;
	public const TextureFormat ASTC_8x8 = 51;
	public const TextureFormat ASTC_10x10 = 52;
	public const TextureFormat ASTC_12x12 = 53;
	public const TextureFormat ETC_RGB4_3DS = 60;
	public const TextureFormat ETC_RGBA8_3DS = 61;
	public const TextureFormat RG16 = 62;
	public const TextureFormat R8 = 63;
	public const TextureFormat ETC_RGB4Crunched = 64;
	public const TextureFormat ETC2_RGBA8Crunched = 65;
	public const TextureFormat ASTC_HDR_4x4 = 66;
	public const TextureFormat ASTC_HDR_5x5 = 67;
	public const TextureFormat ASTC_HDR_6x6 = 68;
	public const TextureFormat ASTC_HDR_8x8 = 69;
	public const TextureFormat ASTC_HDR_10x10 = 70;
	public const TextureFormat ASTC_HDR_12x12 = 71;
	public const TextureFormat RG32 = 72;
	public const TextureFormat RGB48 = 73;
	public const TextureFormat RGBA64 = 74;
	public const TextureFormat ASTC_RGB_4x4 = 48;
	public const TextureFormat ASTC_RGB_5x5 = 49;
	public const TextureFormat ASTC_RGB_6x6 = 50;
	public const TextureFormat ASTC_RGB_8x8 = 51;
	public const TextureFormat ASTC_RGB_10x10 = 52;
	public const TextureFormat ASTC_RGB_12x12 = 53;
	public const TextureFormat ASTC_RGBA_4x4 = 54;
	public const TextureFormat ASTC_RGBA_5x5 = 55;
	public const TextureFormat ASTC_RGBA_6x6 = 56;
	public const TextureFormat ASTC_RGBA_8x8 = 57;
	public const TextureFormat ASTC_RGBA_10x10 = 58;
	public const TextureFormat ASTC_RGBA_12x12 = 59;
}

// Namespace: UnityEngine
internal enum TextureColorSpace
{
	// Fields
	public int value__; // 0x10
	public const TextureColorSpace Linear = 0;
	public const TextureColorSpace sRGB = 1;
}

// Namespace: UnityEngine
public enum CubemapFace
{
	// Fields
	public int value__; // 0x10
	public const CubemapFace Unknown = 4294967295;
	public const CubemapFace PositiveX = 0;
	public const CubemapFace NegativeX = 1;
	public const CubemapFace PositiveY = 2;
	public const CubemapFace NegativeY = 3;
	public const CubemapFace PositiveZ = 4;
	public const CubemapFace NegativeZ = 5;
}

// Namespace: UnityEngine
public enum RenderTextureFormat
{
	// Fields
	public int value__; // 0x10
	public const RenderTextureFormat ARGB32 = 0;
	public const RenderTextureFormat Depth = 1;
	public const RenderTextureFormat ARGBHalf = 2;
	public const RenderTextureFormat Shadowmap = 3;
	public const RenderTextureFormat RGB565 = 4;
	public const RenderTextureFormat ARGB4444 = 5;
	public const RenderTextureFormat ARGB1555 = 6;
	public const RenderTextureFormat Default = 7;
	public const RenderTextureFormat ARGB2101010 = 8;
	public const RenderTextureFormat DefaultHDR = 9;
	public const RenderTextureFormat ARGB64 = 10;
	public const RenderTextureFormat ARGBFloat = 11;
	public const RenderTextureFormat RGFloat = 12;
	public const RenderTextureFormat RGHalf = 13;
	public const RenderTextureFormat RFloat = 14;
	public const RenderTextureFormat RHalf = 15;
	public const RenderTextureFormat R8 = 16;
	public const RenderTextureFormat ARGBInt = 17;
	public const RenderTextureFormat RGInt = 18;
	public const RenderTextureFormat RInt = 19;
	public const RenderTextureFormat BGRA32 = 20;
	public const RenderTextureFormat RGB111110Float = 22;
	public const RenderTextureFormat RG32 = 23;
	public const RenderTextureFormat RGBAUShort = 24;
	public const RenderTextureFormat RG16 = 25;
	public const RenderTextureFormat BGRA10101010_XR = 26;
	public const RenderTextureFormat BGR101010_XR = 27;
	public const RenderTextureFormat R16 = 28;
}

// Namespace: UnityEngine
public enum VRTextureUsage
{
	// Fields
	public int value__; // 0x10
	public const VRTextureUsage None = 0;
	public const VRTextureUsage OneEye = 1;
	public const VRTextureUsage TwoEyes = 2;
	public const VRTextureUsage DeviceSpecific = 3;
}

// Namespace: UnityEngine
public enum RenderTextureCreationFlags
{
	// Fields
	public int value__; // 0x10
	public const RenderTextureCreationFlags MipMap = 1;
	public const RenderTextureCreationFlags AutoGenerateMips = 2;
	public const RenderTextureCreationFlags SRGB = 4;
	public const RenderTextureCreationFlags EyeTexture = 8;
	public const RenderTextureCreationFlags EnableRandomWrite = 16;
	public const RenderTextureCreationFlags CreatedFromScript = 32;
	public const RenderTextureCreationFlags AllowVerticalFlip = 128;
	public const RenderTextureCreationFlags NoResolvedColorSurface = 256;
	public const RenderTextureCreationFlags DynamicallyScalable = 1024;
	public const RenderTextureCreationFlags BindMS = 2048;
}

// Namespace: UnityEngine
public enum RenderTextureReadWrite
{
	// Fields
	public int value__; // 0x10
	public const RenderTextureReadWrite Default = 0;
	public const RenderTextureReadWrite Linear = 1;
	public const RenderTextureReadWrite sRGB = 2;
}

// Namespace: UnityEngine
public enum RenderTextureMemoryless
{
	// Fields
	public int value__; // 0x10
	public const RenderTextureMemoryless None = 0;
	public const RenderTextureMemoryless Color = 1;
	public const RenderTextureMemoryless Depth = 2;
	public const RenderTextureMemoryless MSAA = 4;
}

// Namespace: UnityEngine
public enum LightmapsMode
{
	// Fields
	public int value__; // 0x10
	public const LightmapsMode NonDirectional = 0;
	public const LightmapsMode CombinedDirectional = 1;
}

// Namespace: UnityEngine
public enum TextureMipmapLimitBiasMode
{
	// Fields
	public int value__; // 0x10
	public const TextureMipmapLimitBiasMode OffsetGlobalLimit = 0;
	public const TextureMipmapLimitBiasMode OverrideGlobalLimit = 1;
}

// Namespace: UnityEngine
public struct TextureMipmapLimitSettings
{
	// Fields
	private TextureMipmapLimitBiasMode <limitBiasMode>k__BackingField; // 0x10
	private int <limitBias>k__BackingField; // 0x14

	// Methods

	// RVA: 0x15CCE3C
	public void set_limitBiasMode(TextureMipmapLimitBiasMode value) { }

	// RVA: 0x15CCE44
	public void set_limitBias(int value) { }

}

// Namespace: UnityEngine
public class SkinnedMeshRenderer
{
	// Methods

	// RVA: 0x15CCE4C
	public void set_quality(SkinQuality value) { }

	// RVA: 0x15CCEB4
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x15CCF1C
	public void set_forceMatrixRecalculationPerRender(bool value) { }

	// RVA: 0x15CCF84
	public Transform get_rootBone() { }

	// RVA: 0x15CCFD4
	public void set_rootBone(Transform value) { }

	// RVA: 0x15CD03C
	public Transform[] get_bones() { }

	// RVA: 0x15CD08C
	public void set_bones(Transform[] value) { }

	// RVA: 0x15CD0F4
	public Mesh get_sharedMesh() { }

	// RVA: 0x15CD144
	public void set_sharedMesh(Mesh value) { }

}

// Namespace: UnityEngine
public class MeshRenderer
{
	// Methods

	// RVA: 0x15CD1AC
	private void DontStripMeshRenderer() { }

	// RVA: 0x15CD1B0
	public Mesh get_additionalVertexStreams() { }

	// RVA: 0x15CD200
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class LightProbeGroup
{
	// Methods

	// RVA: 0x15CD208
	public Vector3[] get_probePositions() { }

	// RVA: 0x15CD210
	public void .ctor() { }

}

// Namespace: 
public struct MeshData
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
}

// Namespace: UnityEngine
public sealed class Mesh
{
	// Methods

	// RVA: 0x15CD218
	private static void Internal_Create(Mesh mono) { }

	// RVA: 0x15CD268
	public void .ctor() { }

	// RVA: 0x15CD32C
	public void set_indexFormat(IndexFormat value) { }

	// RVA: 0x15CD394
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	// RVA: 0x15CD3EC
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x15CD474
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x15CD4CC
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x15CD564
	private UInt32 GetIndexCountImpl(int submesh) { }

	// RVA: 0x15CD5CC
	private UInt32 GetBaseVertexImpl(int submesh) { }

	// RVA: 0x15CD634
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	// RVA: 0x15CD68C
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	// RVA: 0x15CD6E4
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15CD784
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	// RVA: 0x15CD7EC
	public bool HasVertexAttribute(VertexAttribute attr) { }

	// RVA: 0x15CD854
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x15CD8F4
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: 0x15CD95C
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	// RVA: 0x15CD9CC
	public IntPtr GetNativeIndexBufferPtr() { }

	// RVA: 0x15CDA1C
	private BoneWeight[] GetBoneWeightsImpl() { }

	// RVA: 0x15CDA6C
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x15CDAD4
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x15CDB24
	public void set_bindposes(Matrix4x4[] value) { }

	// RVA: 0x15CDB8C
	public bool get_isReadable() { }

	// RVA: 0x15CDBDC
	internal bool get_canAccess() { }

	// RVA: 0x15CDC2C
	public int get_vertexCount() { }

	// RVA: 0x15CDC7C
	public int get_subMeshCount() { }

	// RVA: 0x15CDCCC
	public void set_subMeshCount(int value) { }

	// RVA: 0x15CDD34
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0x15CDE04
	private void SetAllSubMeshesAtOnceFromArray(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags) { }

	// RVA: 0x15CDE74
	public Bounds get_bounds() { }

	// RVA: 0x15CDF50
	public void set_bounds(Bounds value) { }

	// RVA: 0x15CE020
	private void ClearImpl(bool keepVertexLayout) { }

	// RVA: 0x15CE088
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	// RVA: 0x15CE0F0
	private void MarkDynamicImpl() { }

	// RVA: 0x15CE140
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	// RVA: 0x15CE1A8
	private MeshTopology GetTopologyImpl(int submesh) { }

	// RVA: 0x15CE210
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x15CE288
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1
	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: -1
	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	// RVA: 0x15CE328
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x316B894
	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags) { }

	// RVA: 0x316B894
	private void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags) { }

	// RVA: 0x316B894
	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x316B894
	private void SetListForChannel(VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1
	private void GetListForChannel(System.Collections.Generic.List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	// RVA: 0x316B894
	private void GetListForChannel(System.Collections.Generic.List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	// RVA: 0x15CE5D8
	public Vector3[] get_vertices() { }

	// RVA: 0x15CE630
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x15CE694
	public Vector3[] get_normals() { }

	// RVA: 0x15CE6EC
	public void set_normals(Vector3[] value) { }

	// RVA: 0x15CE750
	public Vector4[] get_tangents() { }

	// RVA: 0x15CE7A8
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x15CE80C
	public Vector2[] get_uv() { }

	// RVA: 0x15CE864
	public void set_uv(Vector2[] value) { }

	// RVA: 0x15CE8C8
	public Vector2[] get_uv2() { }

	// RVA: 0x15CE920
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x15CE984
	public Color[] get_colors() { }

	// RVA: 0x15CE9DC
	public void set_colors(Color[] value) { }

	// RVA: 0x15CEA40
	public Color32[] get_colors32() { }

	// RVA: 0x15CEAA0
	public void set_colors32(Color32[] value) { }

	// RVA: 0x15CEB0C
	public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices) { }

	// RVA: 0x15CEBB8
	public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length) { }

	// RVA: 0x15CEC34
	public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15CECBC
	public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals) { }

	// RVA: 0x15CED68
	public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length) { }

	// RVA: 0x15CEDE4
	public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15CEE6C
	public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents) { }

	// RVA: 0x15CEF18
	public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length) { }

	// RVA: 0x15CEF94
	public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15CF01C
	public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors) { }

	// RVA: 0x15CF0E0
	public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length) { }

	// RVA: 0x15CF174
	public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x316B894
	private void SetUvsImpl(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15CF214
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs) { }

	// RVA: 0x15CF354
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x15CF2C8
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length) { }

	// RVA: 0x15CF494
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15CF408
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length) { }

	// RVA: 0x15CF524
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x316B894
	private void GetUVsImpl(int uvIndex, System.Collections.Generic.List<T> uvs, int dim) { }

	// RVA: 0x15CF5B4
	public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x15CF624
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x316B894
	public void SetVertexBufferData(T[] data, int dataStart, int meshBufferStart, int count, int stream, MeshUpdateFlags flags) { }

	// RVA: 0x15CF67C
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x15CF724
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x15CF924
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x15CF92C
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x15CF934
	public int[] get_triangles() { }

	// RVA: 0x15CFA7C
	public void set_triangles(int[] value) { }

	// RVA: 0x15CFCA4
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x15CFD60
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	// RVA: 0x15CFE20
	public int[] GetIndices(int submesh) { }

	// RVA: 0x15CFEDC
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x316B894
	public void SetIndexBufferData(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags) { }

	// RVA: 0x15CFF9C
	public UInt32 GetIndexCount(int submesh) { }

	// RVA: 0x15D0080
	public UInt32 GetBaseVertex(int submesh) { }

	// RVA: 0x15D0164
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x15CFBF8
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D030C
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x15D03D0
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D04A4
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D056C
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int submesh) { }

	// RVA: 0x15D05F0
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D0684
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D0790
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	// RVA: 0x15D0930
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x15D0858
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D0A04
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D0AE8
	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D0BCC
	public void SetIndices(System.Collections.Generic.List<System.Int32> indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D0C74
	public void SetIndices(System.Collections.Generic.List<System.Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15D0DA8
	public void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags) { }

	// RVA: 0x15D10A4
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x15D10F4
	public void set_boneWeights(BoneWeight[] value) { }

	// RVA: 0x15D115C
	public void Clear() { }

	// RVA: 0x15D11B4
	public void RecalculateBounds() { }

	// RVA: 0x15D11BC
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x15D12FC
	public void MarkDynamic() { }

	// RVA: 0x15D1390
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x15D1440
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x15CDD9C
	private void SetSubMesh_Injected(int index, SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0x15CDEE8
	private void get_bounds_Injected(Bounds ret) { }

	// RVA: 0x15CDFB8
	private void set_bounds_Injected(Bounds value) { }

}

// Namespace: UnityEngine
[Serializable]
public struct BoneWeight
{
	// Fields
	private float m_Weight0; // 0x10
	private float m_Weight1; // 0x14
	private float m_Weight2; // 0x18
	private float m_Weight3; // 0x1C
	private int m_BoneIndex0; // 0x20
	private int m_BoneIndex1; // 0x24
	private int m_BoneIndex2; // 0x28
	private int m_BoneIndex3; // 0x2C

	// Methods

	// RVA: 0x15D1558
	public float get_weight0() { }

	// RVA: 0x15D1560
	public float get_weight1() { }

	// RVA: 0x15D1568
	public float get_weight2() { }

	// RVA: 0x15D1570
	public float get_weight3() { }

	// RVA: 0x15D1578
	public int get_boneIndex0() { }

	// RVA: 0x15D1580
	public int get_boneIndex1() { }

	// RVA: 0x15D1588
	public int get_boneIndex2() { }

	// RVA: 0x15D1590
	public int get_boneIndex3() { }

	// RVA: 0x15D1598
	public override int GetHashCode() { }

	// RVA: 0x15D16AC
	public override bool Equals(object other) { }

	// RVA: 0x15D174C
	public bool Equals(BoneWeight other) { }

}

// Namespace: UnityEngine
public class Texture
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Methods

	// RVA: 0x15D1828
	protected void .ctor() { }

	// RVA: 0x15D18B0
	public int get_mipmapCount() { }

	// RVA: 0x15D1900
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	// RVA: 0x15D1968
	private int GetDataWidth() { }

	// RVA: 0x15D19B8
	private int GetDataHeight() { }

	// RVA: 0x15D1A08
	public virtual int get_width() { }

	// RVA: 0x15D1A58
	public virtual void set_width(int value) { }

	// RVA: 0x15D1A98
	public virtual int get_height() { }

	// RVA: 0x15D1AE8
	public virtual void set_height(int value) { }

	// RVA: 0x15D1B28
	public virtual bool get_isReadable() { }

	// RVA: 0x15D1B78
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x15D1BC8
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x15D1C30
	public FilterMode get_filterMode() { }

	// RVA: 0x15D1C80
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x15D1CE8
	public void set_mipMapBias(float value) { }

	// RVA: 0x15D1D50
	public Vector2 get_texelSize() { }

	// RVA: 0x15D1E10
	private int Internal_GetActiveTextureColorSpace() { }

	// RVA: 0x15D1E60
	internal ColorSpace get_activeTextureColorSpace() { }

	// RVA: 0x15D1EAC
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	// RVA: 0x15D1EB4
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	// RVA: 0x15D1F1C
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x15D2110
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x15D22E0
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x15D2384
	internal UnityException CreateNativeArrayLengthOverflowException() { }

	// RVA: 0x15D23FC
	private static void .cctor() { }

	// RVA: 0x15D1DA8
	private void get_texelSize_Injected(Vector2 ret) { }

}

// Namespace: UnityEngine
public sealed class Texture2D
{
	// Fields
	internal const int streamingMipmapsPriorityMin = 4294967168;
	internal const int streamingMipmapsPriorityMax = 127;

	// Methods

	// RVA: 0x15D244C
	public TextureFormat get_format() { }

	// RVA: 0x15D249C
	public void set_ignoreMipmapLimit(bool value) { }

	// RVA: 0x15D2504
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x15D2544
	public void Compress(bool highQuality) { }

	// RVA: 0x15D25AC
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x15D264C
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x15D2744
	public override bool get_isReadable() { }

	// RVA: 0x15D2794
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x15D27EC
	private bool ReinitializeImpl(int width, int height) { }

	// RVA: 0x15D2844
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	// RVA: 0x15D294C
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	// RVA: 0x15D2A58
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	// RVA: 0x15D2AC8
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x15D2BB8
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	// RVA: 0x15D2C50
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x15D2CB8
	private UInt64 GetRawImageDataSize() { }

	// RVA: 0x15D2D08
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x15D2D60
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x15D2DC8
	public Color32[] GetPixels32() { }

	// RVA: 0x15D2E20
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x15D2F04
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x15D3050
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x15D3214
	public void .ctor(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D32D0
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D3380
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x15D35A0
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x15D35CC
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x15D3698
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15D3758
	public void .ctor(int width, int height) { }

	// RVA: 0x15D3800
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x15D38CC
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x15D398C
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	// RVA: 0x15D3A48
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x316B894
	public Unity.Collections.NativeArray<T> GetRawTextureData() { }

	// RVA: 0x15D3AF8
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x15D3B84
	public void Apply() { }

	// RVA: 0x15D3C18
	public bool Reinitialize(int width, int height) { }

	// RVA: 0x15D3CA4
	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x15D3D14
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x15D3DE8
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x15D3EB0
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x15D3F08
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x15D28CC
	private void SetPixelImpl_Injected(int image, int mip, int x, int y, Color color) { }

	// RVA: 0x15D29D8
	private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, Color ret) { }

	// RVA: 0x15D2B48
	private void ReadPixelsImpl_Injected(Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

// Namespace: UnityEngine
public sealed class Cubemap
{
	// Methods

	// RVA: 0x15D3F5C
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x15D3FE4
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x15D40BC
	public override bool get_isReadable() { }

	// RVA: 0x15D410C
	internal bool ValidateFormat(TextureFormat format, int width) { }

	// RVA: 0x15D41E4
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	// RVA: 0x15D431C
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D4440
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15D43B4
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D4490
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15D46E8
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x15D4904
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15D49A4
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x15D4A48
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x15D4A54
	public void .ctor(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	// RVA: 0x15D468C
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public sealed class Texture3D
{
	// Methods

	// RVA: 0x15D4A60
	public override bool get_isReadable() { }

	// RVA: 0x15D4AB0
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x15D4B50
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x15D4C48
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D4D9C
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15D4CF8
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D4E04
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15D5068
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x15D508C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x15D50AC
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x15D52E0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15D53A4
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x15D546C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x15D500C
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public sealed class Texture2DArray
{
	// Methods

	// RVA: 0x15D5534
	public static int get_allSlices() { }

	// RVA: 0x15D5574
	public override bool get_isReadable() { }

	// RVA: 0x15D55C4
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x15D565C
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x15D5744
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x15D5828
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x15D5974
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D5AC8
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15D5A24
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D5D20
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15D5F28
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x15D6170
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x15D6190
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x15D6258
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x15D6320
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15D5CC4
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public sealed class CubemapArray
{
	// Methods

	// RVA: 0x15D63E4
	public override bool get_isReadable() { }

	// RVA: 0x15D6434
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x15D64BC
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x15D6594
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D66D8
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15D663C
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15D6738
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15D69A0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x15D6BC8
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x15D6BD0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x15D6C88
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x15D6D3C
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15D6944
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public class RenderTexture
{
	// Methods

	// RVA: 0x15D6DE4
	public override int get_width() { }

	// RVA: 0x15D6E34
	public override void set_width(int value) { }

	// RVA: 0x15D6E9C
	public override int get_height() { }

	// RVA: 0x15D6EEC
	public override void set_height(int value) { }

	// RVA: 0x15D6F54
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	// RVA: 0x15D6FBC
	private void SetColorFormat(GraphicsFormat format) { }

	// RVA: 0x15D7024
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x15D707C
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x15D70E4
	public void set_useMipMap(bool value) { }

	// RVA: 0x15D714C
	public RenderTextureFormat get_format() { }

	// RVA: 0x15D7314
	public GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x15D7364
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x15D73CC
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x15D7434
	private static RenderTexture GetActive() { }

	// RVA: 0x15D7474
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x15D74C4
	public static RenderTexture get_active() { }

	// RVA: 0x15D7504
	public static void set_active(RenderTexture value) { }

	// RVA: 0x15D7554
	private RenderBuffer GetColorBuffer() { }

	// RVA: 0x15D7614
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x15D76D4
	private void SetMipMapCount(int count) { }

	// RVA: 0x15C62D8
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x15C6330
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x15D773C
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x15D7794
	public void DiscardContents() { }

	// RVA: 0x15D77F4
	public bool Create() { }

	// RVA: 0x15D7844
	public void Release() { }

	// RVA: 0x15D7894
	public bool IsCreated() { }

	// RVA: 0x15D78E4
	internal void SetSRGBReadWrite(bool srgb) { }

	// RVA: 0x15D794C
	private static void Internal_Create(RenderTexture rt) { }

	// RVA: 0x15D799C
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	// RVA: 0x15D7290
	private RenderTextureDescriptor GetDescriptor() { }

	// RVA: 0x15D7AD4
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	// RVA: 0x15D7B74
	public static void ReleaseTemporary(RenderTexture temp) { }

	// RVA: 0x15D7BC4
	public int get_depth() { }

	// RVA: 0x15D7C14
	protected internal void .ctor() { }

	// RVA: 0x15D7CF4
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x15D82C4
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x15D85D8
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x15D8AA0
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x15D8B3C
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x15D87AC
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x15D8F44
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x15D8FE0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x15D93BC
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	// RVA: 0x15D9568
	public void .ctor(int width, int height, int depth) { }

	// RVA: 0x15D9458
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x15D9100
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	// RVA: 0x15D8E88
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	// RVA: 0x15D9744
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	// RVA: 0x15D98B4
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	// RVA: 0x15D9800
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	// RVA: 0x15D8548
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x15D7E5C
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x15D86B4
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	// RVA: 0x15D86DC
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	// RVA: 0x15D95F8
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x15D9970
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x15D9A1C
	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	// RVA: 0x15D9B1C
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	// RVA: 0x15D9CCC
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	// RVA: 0x15D9CEC
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x15D9D10
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x15D9D38
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x15D9D64
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x15D9D94
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	// RVA: 0x15D9DC8
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x15D75AC
	private void GetColorBuffer_Injected(RenderBuffer ret) { }

	// RVA: 0x15D766C
	private void GetDepthBuffer_Injected(RenderBuffer ret) { }

	// RVA: 0x15D7A04
	private void SetRenderTextureDescriptor_Injected(RenderTextureDescriptor desc) { }

	// RVA: 0x15D7A6C
	private void GetDescriptor_Injected(RenderTextureDescriptor ret) { }

	// RVA: 0x15D7B24
	private static RenderTexture GetTemporary_Internal_Injected(RenderTextureDescriptor desc) { }

}

// Namespace: UnityEngine
public sealed class CustomRenderTexture
{}

// Namespace: UnityEngine
public struct RenderTextureDescriptor
{
	// Fields
	private int <width>k__BackingField; // 0x10
	private int <height>k__BackingField; // 0x14
	private int <msaaSamples>k__BackingField; // 0x18
	private int <volumeDepth>k__BackingField; // 0x1C
	private int <mipCount>k__BackingField; // 0x20
	private GraphicsFormat _graphicsFormat; // 0x24
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x28
	private GraphicsFormat <depthStencilFormat>k__BackingField; // 0x2C
	private TextureDimension <dimension>k__BackingField; // 0x30
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x34
	private VRTextureUsage <vrUsage>k__BackingField; // 0x38
	private RenderTextureCreationFlags _flags; // 0x3C
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x40

	// Methods

	// RVA: 0x15D9E00
	public int get_width() { }

	// RVA: 0x15D9E08
	public void set_width(int value) { }

	// RVA: 0x15D9E10
	public int get_height() { }

	// RVA: 0x15D9E18
	public void set_height(int value) { }

	// RVA: 0x15D9E20
	public int get_msaaSamples() { }

	// RVA: 0x15D9E28
	public void set_msaaSamples(int value) { }

	// RVA: 0x15D9E30
	public int get_volumeDepth() { }

	// RVA: 0x15D9E38
	public void set_volumeDepth(int value) { }

	// RVA: 0x15D9E40
	public void set_mipCount(int value) { }

	// RVA: 0x15D9E48
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x15D9E50
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x15DA00C
	public void set_stencilFormat(GraphicsFormat value) { }

	// RVA: 0x15DA014
	public GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x15DA01C
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x15DA024
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x15DA0B8
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x15DA1A8
	public bool get_sRGB() { }

	// RVA: 0x15DA238
	public void set_sRGB(bool value) { }

	// RVA: 0x15D9F48
	public int get_depthBufferBits() { }

	// RVA: 0x15D9FD8
	public void set_depthBufferBits(int value) { }

	// RVA: 0x15DA3A8
	public TextureDimension get_dimension() { }

	// RVA: 0x15DA3B0
	public void set_dimension(TextureDimension value) { }

	// RVA: 0x15DA3B8
	public ShadowSamplingMode get_shadowSamplingMode() { }

	// RVA: 0x15DA3C0
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	// RVA: 0x15DA3C8
	public void set_vrUsage(VRTextureUsage value) { }

	// RVA: 0x15DA3D0
	public void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x15DA3D8
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x15DA4A0
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x15D9F2C
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x15DA508
	public void set_useMipMap(bool value) { }

	// RVA: 0x15DA51C
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x15DA53C
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x15DA55C
	public void set_bindMS(bool value) { }

	// RVA: 0x15DA57C
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x15DA59C
	public void set_useDynamicScale(bool value) { }

}

// Namespace: UnityEngine
public class Handheld
{
	// Methods

	// RVA: 0x15DA5BC
	public static void Vibrate() { }

}

// Namespace: UnityEngine
[Serializable]
public struct Hash128
{
	// Fields
	internal UInt64 u64_0; // 0x10
	internal UInt64 u64_1; // 0x18

	// Methods

	// RVA: 0x15DA5FC
	public void .ctor(UInt64 u64_0, UInt64 u64_1) { }

	// RVA: 0x15DA604
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x15DA690
	public override string ToString() { }

	// RVA: 0x15DA75C
	public static Hash128 Parse(string hashString) { }

	// RVA: 0x15DA6F8
	private static string Hash128ToStringImpl(Hash128 hash) { }

	// RVA: 0x15DA86C
	public override bool Equals(object obj) { }

	// RVA: 0x15DA910
	public bool Equals(Hash128 obj) { }

	// RVA: 0x15DA924
	public override int GetHashCode() { }

	// RVA: 0x15DA95C
	public int CompareTo(object obj) { }

	// RVA: 0x15DA900
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x15DA650
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x15DA668
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x15DA7B4
	private static void Parse_Injected(string hashString, Hash128 ret) { }

	// RVA: 0x15DA81C
	private static string Hash128ToStringImpl_Injected(Hash128 hash) { }

}

// Namespace: UnityEngine
public enum CursorMode
{
	// Fields
	public int value__; // 0x10
	public const CursorMode Auto = 0;
	public const CursorMode ForceSoftware = 1;
}

// Namespace: UnityEngine
public enum CursorLockMode
{
	// Fields
	public int value__; // 0x10
	public const CursorLockMode None = 0;
	public const CursorLockMode Locked = 1;
	public const CursorLockMode Confined = 2;
}

// Namespace: UnityEngine
public class Cursor
{
	// Methods

	// RVA: 0x15DAA34
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x15DAAF0
	public static void set_visible(bool value) { }

	// RVA: 0x15DAB40
	public static CursorLockMode get_lockState() { }

	// RVA: 0x15DAB80
	public static void set_lockState(CursorLockMode value) { }

	// RVA: 0x15DAA98
	private static void SetCursor_Injected(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

}

// Namespace: UnityEngine
public enum KeyCode
{
	// Fields
	public int value__; // 0x10
	public const KeyCode None = 0;
	public const KeyCode Backspace = 8;
	public const KeyCode Delete = 127;
	public const KeyCode Tab = 9;
	public const KeyCode Clear = 12;
	public const KeyCode Return = 13;
	public const KeyCode Pause = 19;
	public const KeyCode Escape = 27;
	public const KeyCode Space = 32;
	public const KeyCode Keypad0 = 256;
	public const KeyCode Keypad1 = 257;
	public const KeyCode Keypad2 = 258;
	public const KeyCode Keypad3 = 259;
	public const KeyCode Keypad4 = 260;
	public const KeyCode Keypad5 = 261;
	public const KeyCode Keypad6 = 262;
	public const KeyCode Keypad7 = 263;
	public const KeyCode Keypad8 = 264;
	public const KeyCode Keypad9 = 265;
	public const KeyCode KeypadPeriod = 266;
	public const KeyCode KeypadDivide = 267;
	public const KeyCode KeypadMultiply = 268;
	public const KeyCode KeypadMinus = 269;
	public const KeyCode KeypadPlus = 270;
	public const KeyCode KeypadEnter = 271;
	public const KeyCode KeypadEquals = 272;
	public const KeyCode UpArrow = 273;
	public const KeyCode DownArrow = 274;
	public const KeyCode RightArrow = 275;
	public const KeyCode LeftArrow = 276;
	public const KeyCode Insert = 277;
	public const KeyCode Home = 278;
	public const KeyCode End = 279;
	public const KeyCode PageUp = 280;
	public const KeyCode PageDown = 281;
	public const KeyCode F1 = 282;
	public const KeyCode F2 = 283;
	public const KeyCode F3 = 284;
	public const KeyCode F4 = 285;
	public const KeyCode F5 = 286;
	public const KeyCode F6 = 287;
	public const KeyCode F7 = 288;
	public const KeyCode F8 = 289;
	public const KeyCode F9 = 290;
	public const KeyCode F10 = 291;
	public const KeyCode F11 = 292;
	public const KeyCode F12 = 293;
	public const KeyCode F13 = 294;
	public const KeyCode F14 = 295;
	public const KeyCode F15 = 296;
	public const KeyCode Alpha0 = 48;
	public const KeyCode Alpha1 = 49;
	public const KeyCode Alpha2 = 50;
	public const KeyCode Alpha3 = 51;
	public const KeyCode Alpha4 = 52;
	public const KeyCode Alpha5 = 53;
	public const KeyCode Alpha6 = 54;
	public const KeyCode Alpha7 = 55;
	public const KeyCode Alpha8 = 56;
	public const KeyCode Alpha9 = 57;
	public const KeyCode Exclaim = 33;
	public const KeyCode DoubleQuote = 34;
	public const KeyCode Hash = 35;
	public const KeyCode Dollar = 36;
	public const KeyCode Percent = 37;
	public const KeyCode Ampersand = 38;
	public const KeyCode Quote = 39;
	public const KeyCode LeftParen = 40;
	public const KeyCode RightParen = 41;
	public const KeyCode Asterisk = 42;
	public const KeyCode Plus = 43;
	public const KeyCode Comma = 44;
	public const KeyCode Minus = 45;
	public const KeyCode Period = 46;
	public const KeyCode Slash = 47;
	public const KeyCode Colon = 58;
	public const KeyCode Semicolon = 59;
	public const KeyCode Less = 60;
	public const KeyCode Equals = 61;
	public const KeyCode Greater = 62;
	public const KeyCode Question = 63;
	public const KeyCode At = 64;
	public const KeyCode LeftBracket = 91;
	public const KeyCode Backslash = 92;
	public const KeyCode RightBracket = 93;
	public const KeyCode Caret = 94;
	public const KeyCode Underscore = 95;
	public const KeyCode BackQuote = 96;
	public const KeyCode A = 97;
	public const KeyCode B = 98;
	public const KeyCode C = 99;
	public const KeyCode D = 100;
	public const KeyCode E = 101;
	public const KeyCode F = 102;
	public const KeyCode G = 103;
	public const KeyCode H = 104;
	public const KeyCode I = 105;
	public const KeyCode J = 106;
	public const KeyCode K = 107;
	public const KeyCode L = 108;
	public const KeyCode M = 109;
	public const KeyCode N = 110;
	public const KeyCode O = 111;
	public const KeyCode P = 112;
	public const KeyCode Q = 113;
	public const KeyCode R = 114;
	public const KeyCode S = 115;
	public const KeyCode T = 116;
	public const KeyCode U = 117;
	public const KeyCode V = 118;
	public const KeyCode W = 119;
	public const KeyCode X = 120;
	public const KeyCode Y = 121;
	public const KeyCode Z = 122;
	public const KeyCode LeftCurlyBracket = 123;
	public const KeyCode Pipe = 124;
	public const KeyCode RightCurlyBracket = 125;
	public const KeyCode Tilde = 126;
	public const KeyCode Numlock = 300;
	public const KeyCode CapsLock = 301;
	public const KeyCode ScrollLock = 302;
	public const KeyCode RightShift = 303;
	public const KeyCode LeftShift = 304;
	public const KeyCode RightControl = 305;
	public const KeyCode LeftControl = 306;
	public const KeyCode RightAlt = 307;
	public const KeyCode LeftAlt = 308;
	public const KeyCode LeftMeta = 310;
	public const KeyCode LeftCommand = 310;
	public const KeyCode LeftApple = 310;
	public const KeyCode LeftWindows = 311;
	public const KeyCode RightMeta = 309;
	public const KeyCode RightCommand = 309;
	public const KeyCode RightApple = 309;
	public const KeyCode RightWindows = 312;
	public const KeyCode AltGr = 313;
	public const KeyCode Help = 315;
	public const KeyCode Print = 316;
	public const KeyCode SysReq = 317;
	public const KeyCode Break = 318;
	public const KeyCode Menu = 319;
	public const KeyCode Mouse0 = 323;
	public const KeyCode Mouse1 = 324;
	public const KeyCode Mouse2 = 325;
	public const KeyCode Mouse3 = 326;
	public const KeyCode Mouse4 = 327;
	public const KeyCode Mouse5 = 328;
	public const KeyCode Mouse6 = 329;
	public const KeyCode JoystickButton0 = 330;
	public const KeyCode JoystickButton1 = 331;
	public const KeyCode JoystickButton2 = 332;
	public const KeyCode JoystickButton3 = 333;
	public const KeyCode JoystickButton4 = 334;
	public const KeyCode JoystickButton5 = 335;
	public const KeyCode JoystickButton6 = 336;
	public const KeyCode JoystickButton7 = 337;
	public const KeyCode JoystickButton8 = 338;
	public const KeyCode JoystickButton9 = 339;
	public const KeyCode JoystickButton10 = 340;
	public const KeyCode JoystickButton11 = 341;
	public const KeyCode JoystickButton12 = 342;
	public const KeyCode JoystickButton13 = 343;
	public const KeyCode JoystickButton14 = 344;
	public const KeyCode JoystickButton15 = 345;
	public const KeyCode JoystickButton16 = 346;
	public const KeyCode JoystickButton17 = 347;
	public const KeyCode JoystickButton18 = 348;
	public const KeyCode JoystickButton19 = 349;
	public const KeyCode Joystick1Button0 = 350;
	public const KeyCode Joystick1Button1 = 351;
	public const KeyCode Joystick1Button2 = 352;
	public const KeyCode Joystick1Button3 = 353;
	public const KeyCode Joystick1Button4 = 354;
	public const KeyCode Joystick1Button5 = 355;
	public const KeyCode Joystick1Button6 = 356;
	public const KeyCode Joystick1Button7 = 357;
	public const KeyCode Joystick1Button8 = 358;
	public const KeyCode Joystick1Button9 = 359;
	public const KeyCode Joystick1Button10 = 360;
	public const KeyCode Joystick1Button11 = 361;
	public const KeyCode Joystick1Button12 = 362;
	public const KeyCode Joystick1Button13 = 363;
	public const KeyCode Joystick1Button14 = 364;
	public const KeyCode Joystick1Button15 = 365;
	public const KeyCode Joystick1Button16 = 366;
	public const KeyCode Joystick1Button17 = 367;
	public const KeyCode Joystick1Button18 = 368;
	public const KeyCode Joystick1Button19 = 369;
	public const KeyCode Joystick2Button0 = 370;
	public const KeyCode Joystick2Button1 = 371;
	public const KeyCode Joystick2Button2 = 372;
	public const KeyCode Joystick2Button3 = 373;
	public const KeyCode Joystick2Button4 = 374;
	public const KeyCode Joystick2Button5 = 375;
	public const KeyCode Joystick2Button6 = 376;
	public const KeyCode Joystick2Button7 = 377;
	public const KeyCode Joystick2Button8 = 378;
	public const KeyCode Joystick2Button9 = 379;
	public const KeyCode Joystick2Button10 = 380;
	public const KeyCode Joystick2Button11 = 381;
	public const KeyCode Joystick2Button12 = 382;
	public const KeyCode Joystick2Button13 = 383;
	public const KeyCode Joystick2Button14 = 384;
	public const KeyCode Joystick2Button15 = 385;
	public const KeyCode Joystick2Button16 = 386;
	public const KeyCode Joystick2Button17 = 387;
	public const KeyCode Joystick2Button18 = 388;
	public const KeyCode Joystick2Button19 = 389;
	public const KeyCode Joystick3Button0 = 390;
	public const KeyCode Joystick3Button1 = 391;
	public const KeyCode Joystick3Button2 = 392;
	public const KeyCode Joystick3Button3 = 393;
	public const KeyCode Joystick3Button4 = 394;
	public const KeyCode Joystick3Button5 = 395;
	public const KeyCode Joystick3Button6 = 396;
	public const KeyCode Joystick3Button7 = 397;
	public const KeyCode Joystick3Button8 = 398;
	public const KeyCode Joystick3Button9 = 399;
	public const KeyCode Joystick3Button10 = 400;
	public const KeyCode Joystick3Button11 = 401;
	public const KeyCode Joystick3Button12 = 402;
	public const KeyCode Joystick3Button13 = 403;
	public const KeyCode Joystick3Button14 = 404;
	public const KeyCode Joystick3Button15 = 405;
	public const KeyCode Joystick3Button16 = 406;
	public const KeyCode Joystick3Button17 = 407;
	public const KeyCode Joystick3Button18 = 408;
	public const KeyCode Joystick3Button19 = 409;
	public const KeyCode Joystick4Button0 = 410;
	public const KeyCode Joystick4Button1 = 411;
	public const KeyCode Joystick4Button2 = 412;
	public const KeyCode Joystick4Button3 = 413;
	public const KeyCode Joystick4Button4 = 414;
	public const KeyCode Joystick4Button5 = 415;
	public const KeyCode Joystick4Button6 = 416;
	public const KeyCode Joystick4Button7 = 417;
	public const KeyCode Joystick4Button8 = 418;
	public const KeyCode Joystick4Button9 = 419;
	public const KeyCode Joystick4Button10 = 420;
	public const KeyCode Joystick4Button11 = 421;
	public const KeyCode Joystick4Button12 = 422;
	public const KeyCode Joystick4Button13 = 423;
	public const KeyCode Joystick4Button14 = 424;
	public const KeyCode Joystick4Button15 = 425;
	public const KeyCode Joystick4Button16 = 426;
	public const KeyCode Joystick4Button17 = 427;
	public const KeyCode Joystick4Button18 = 428;
	public const KeyCode Joystick4Button19 = 429;
	public const KeyCode Joystick5Button0 = 430;
	public const KeyCode Joystick5Button1 = 431;
	public const KeyCode Joystick5Button2 = 432;
	public const KeyCode Joystick5Button3 = 433;
	public const KeyCode Joystick5Button4 = 434;
	public const KeyCode Joystick5Button5 = 435;
	public const KeyCode Joystick5Button6 = 436;
	public const KeyCode Joystick5Button7 = 437;
	public const KeyCode Joystick5Button8 = 438;
	public const KeyCode Joystick5Button9 = 439;
	public const KeyCode Joystick5Button10 = 440;
	public const KeyCode Joystick5Button11 = 441;
	public const KeyCode Joystick5Button12 = 442;
	public const KeyCode Joystick5Button13 = 443;
	public const KeyCode Joystick5Button14 = 444;
	public const KeyCode Joystick5Button15 = 445;
	public const KeyCode Joystick5Button16 = 446;
	public const KeyCode Joystick5Button17 = 447;
	public const KeyCode Joystick5Button18 = 448;
	public const KeyCode Joystick5Button19 = 449;
	public const KeyCode Joystick6Button0 = 450;
	public const KeyCode Joystick6Button1 = 451;
	public const KeyCode Joystick6Button2 = 452;
	public const KeyCode Joystick6Button3 = 453;
	public const KeyCode Joystick6Button4 = 454;
	public const KeyCode Joystick6Button5 = 455;
	public const KeyCode Joystick6Button6 = 456;
	public const KeyCode Joystick6Button7 = 457;
	public const KeyCode Joystick6Button8 = 458;
	public const KeyCode Joystick6Button9 = 459;
	public const KeyCode Joystick6Button10 = 460;
	public const KeyCode Joystick6Button11 = 461;
	public const KeyCode Joystick6Button12 = 462;
	public const KeyCode Joystick6Button13 = 463;
	public const KeyCode Joystick6Button14 = 464;
	public const KeyCode Joystick6Button15 = 465;
	public const KeyCode Joystick6Button16 = 466;
	public const KeyCode Joystick6Button17 = 467;
	public const KeyCode Joystick6Button18 = 468;
	public const KeyCode Joystick6Button19 = 469;
	public const KeyCode Joystick7Button0 = 470;
	public const KeyCode Joystick7Button1 = 471;
	public const KeyCode Joystick7Button2 = 472;
	public const KeyCode Joystick7Button3 = 473;
	public const KeyCode Joystick7Button4 = 474;
	public const KeyCode Joystick7Button5 = 475;
	public const KeyCode Joystick7Button6 = 476;
	public const KeyCode Joystick7Button7 = 477;
	public const KeyCode Joystick7Button8 = 478;
	public const KeyCode Joystick7Button9 = 479;
	public const KeyCode Joystick7Button10 = 480;
	public const KeyCode Joystick7Button11 = 481;
	public const KeyCode Joystick7Button12 = 482;
	public const KeyCode Joystick7Button13 = 483;
	public const KeyCode Joystick7Button14 = 484;
	public const KeyCode Joystick7Button15 = 485;
	public const KeyCode Joystick7Button16 = 486;
	public const KeyCode Joystick7Button17 = 487;
	public const KeyCode Joystick7Button18 = 488;
	public const KeyCode Joystick7Button19 = 489;
	public const KeyCode Joystick8Button0 = 490;
	public const KeyCode Joystick8Button1 = 491;
	public const KeyCode Joystick8Button2 = 492;
	public const KeyCode Joystick8Button3 = 493;
	public const KeyCode Joystick8Button4 = 494;
	public const KeyCode Joystick8Button5 = 495;
	public const KeyCode Joystick8Button6 = 496;
	public const KeyCode Joystick8Button7 = 497;
	public const KeyCode Joystick8Button8 = 498;
	public const KeyCode Joystick8Button9 = 499;
	public const KeyCode Joystick8Button10 = 500;
	public const KeyCode Joystick8Button11 = 501;
	public const KeyCode Joystick8Button12 = 502;
	public const KeyCode Joystick8Button13 = 503;
	public const KeyCode Joystick8Button14 = 504;
	public const KeyCode Joystick8Button15 = 505;
	public const KeyCode Joystick8Button16 = 506;
	public const KeyCode Joystick8Button17 = 507;
	public const KeyCode Joystick8Button18 = 508;
	public const KeyCode Joystick8Button19 = 509;
}

// Namespace: UnityEngine
public interface ILogger
{
	// Methods

	// RVA: -1
	public abstract ILogHandler get_logHandler() { }

	// RVA: -1
	public abstract bool get_logEnabled() { }

	// RVA: -1
	public abstract bool IsLogTypeAllowed(LogType logType) { }

	// RVA: -1
	public abstract void Log(LogType logType, object message) { }

	// RVA: -1
	public abstract void Log(LogType logType, object message, object context) { }

	// RVA: -1
	public abstract void Log(LogType logType, string tag, object message) { }

	// RVA: -1
	public abstract void Log(string tag, object message) { }

	// RVA: -1
	public abstract void LogWarning(string tag, object message) { }

	// RVA: -1
	public abstract void LogError(string tag, object message) { }

	// RVA: -1
	public abstract void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: -1
	public abstract void LogException(Exception exception) { }

}

// Namespace: UnityEngine
public interface ILogHandler
{
	// Methods

	// RVA: -1
	public abstract void LogFormat(LogType logType, object context, string format, object[] args) { }

	// RVA: -1
	public abstract void LogException(Exception exception, object context) { }

}

// Namespace: UnityEngine
public class Logger
{
	// Fields
	private ILogHandler <logHandler>k__BackingField; // 0x10
	private bool <logEnabled>k__BackingField; // 0x18
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x15DABD0
	public void .ctor(ILogHandler logHandler) { }

	// RVA: 0x15DAC18
	public ILogHandler get_logHandler() { }

	// RVA: 0x15DAC20
	public void set_logHandler(ILogHandler value) { }

	// RVA: 0x15DAC28
	public bool get_logEnabled() { }

	// RVA: 0x15DAC30
	public void set_logEnabled(bool value) { }

	// RVA: 0x15DAC38
	public LogType get_filterLogType() { }

	// RVA: 0x15DAC40
	public void set_filterLogType(LogType value) { }

	// RVA: 0x15DAC48
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x15DAC7C
	private static string GetString(object message) { }

	// RVA: 0x15DADB0
	public void Log(LogType logType, object message) { }

	// RVA: 0x15DAF30
	public void Log(LogType logType, object message, object context) { }

	// RVA: 0x15DB0C0
	public void Log(LogType logType, string tag, object message) { }

	// RVA: 0x15DB284
	public void Log(string tag, object message) { }

	// RVA: 0x15DB430
	public void LogWarning(string tag, object message) { }

	// RVA: 0x15DB5DC
	public void LogError(string tag, object message) { }

	// RVA: 0x15DB788
	public void LogException(Exception exception) { }

	// RVA: 0x15DB85C
	public void LogException(Exception exception, object context) { }

	// RVA: 0x15DB934
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x15DBA38
	public void LogFormat(LogType logType, object context, string format, object[] args) { }

}

// Namespace: UnityEngine
internal class UnityLogWriter
{
	// Methods

	// RVA: 0x15DBB40
	public static void WriteStringToUnityLog(string s) { }

	// RVA: 0x15DBB98
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x15DBBE8
	public static void Init() { }

	// RVA: 0x15DBD78
	public override Encoding get_Encoding() { }

	// RVA: 0x15DBD80
	public override void Write(Char value) { }

	// RVA: 0x15DBE5C
	public override void Write(string s) { }

	// RVA: 0x15DBEB4
	public override void Write(Char[] buffer, int index, int count) { }

	// RVA: 0x15DBCF0
	public void .ctor() { }

}

// Namespace: UnityEngine
public struct Color
{
	// Fields
	public float r; // 0x10
	public float g; // 0x14
	public float b; // 0x18
	public float a; // 0x1C

	// Methods

	// RVA: 0x15DBF10
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x15DBF1C
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x15DBF30
	public override string ToString() { }

	// RVA: 0x15DBF40
	public string ToString(string format) { }

	// RVA: 0x15DBF4C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15DC190
	public override int GetHashCode() { }

	// RVA: 0x15DC218
	public override bool Equals(object other) { }

	// RVA: 0x15DC2FC
	public bool Equals(Color other) { }

	// RVA: 0x15DC38C
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x15DC3A0
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x15DC3B4
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x15DC3C8
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x15DC3DC
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x15DC3F0
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x15DC434
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x15DC478
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x15DC4C8
	public static Color LerpUnclamped(Color a, Color b, float t) { }

	// RVA: 0x15DC500
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x15DC51C
	public static Color get_red() { }

	// RVA: 0x15DC530
	public static Color get_green() { }

	// RVA: 0x15DC544
	public static Color get_blue() { }

	// RVA: 0x15DC558
	public static Color get_white() { }

	// RVA: 0x15DC56C
	public static Color get_black() { }

	// RVA: 0x15DC580
	public static Color get_yellow() { }

	// RVA: 0x15DC5A4
	public static Color get_cyan() { }

	// RVA: 0x15DC5B8
	public static Color get_magenta() { }

	// RVA: 0x15DC5CC
	public static Color get_gray() { }

	// RVA: 0x15DC5E0
	public static Color get_clear() { }

	// RVA: 0x15DC5F4
	public Color get_linear() { }

	// RVA: 0x15DC734
	public Color get_gamma() { }

	// RVA: 0x15DC874
	public float get_maxColorComponent() { }

	// RVA: 0x15DC890
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x15DC894
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x15DC898
	public static void RGBToHSV(Color rgbColor, float H, float S, float V) { }

	// RVA: 0x15DC9DC
	private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, float H, float S, float V) { }

	// RVA: 0x15DCA4C
	public static Color HSVToRGB(float H, float S, float V) { }

	// RVA: 0x15DCB84
	public static Color HSVToRGB(float H, float S, float V, bool hdr) { }

}

// Namespace: UnityEngine
public struct Color32
{
	// Fields
	private int rgba; // 0x10
	public Byte r; // 0x10
	public Byte g; // 0x11
	public Byte b; // 0x12
	public Byte a; // 0x13

	// Methods

	// RVA: 0x15DCCF0
	public void .ctor(Byte r, Byte g, Byte b, Byte a) { }

	// RVA: 0x15DCD04
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x15DCFFC
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x15DD038
	public override string ToString() { }

	// RVA: 0x15DD268
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public class ColorUtility
{
	// Methods

	// RVA: 0x15DD480
	internal static bool DoTryParseHtmlColor(string htmlString, Color32 color) { }

	// RVA: 0x15DD4E8
	public static bool TryParseHtmlString(string htmlString, Color color) { }

	// RVA: 0x15DD59C
	public static string ToHtmlStringRGB(Color color) { }

	// RVA: 0x15DDA24
	public static string ToHtmlStringRGBA(Color color) { }

}

// Namespace: UnityEngine
public class Gradient
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15DDFF4
	private static IntPtr Init() { }

	// RVA: 0x15DE034
	private void Cleanup() { }

	// RVA: 0x15DE084
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x15DE0EC
	public void .ctor() { }

	// RVA: 0x15DE148
	protected override void Finalize() { }

	// RVA: 0x15DE200
	public Color Evaluate(float time) { }

	// RVA: 0x15DE2CC
	public override bool Equals(object o) { }

	// RVA: 0x15DE484
	public bool Equals(Gradient other) { }

	// RVA: 0x15DE574
	public override int GetHashCode() { }

	// RVA: 0x15DE26C
	private void Evaluate_Injected(float time, Color ret) { }

}

// Namespace: UnityEngine
public struct Matrix4x4
{
	// Fields
	public float m00; // 0x10
	public float m10; // 0x14
	public float m20; // 0x18
	public float m30; // 0x1C
	public float m01; // 0x20
	public float m11; // 0x24
	public float m21; // 0x28
	public float m31; // 0x2C
	public float m02; // 0x30
	public float m12; // 0x34
	public float m22; // 0x38
	public float m32; // 0x3C
	public float m03; // 0x40
	public float m13; // 0x44
	public float m23; // 0x48
	public float m33; // 0x4C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Methods

	// RVA: 0x15DE580
	private Quaternion GetRotation() { }

	// RVA: 0x15DE644
	private Vector3 GetLossyScale() { }

	// RVA: 0x15DE70C
	private float GetDeterminant() { }

	// RVA: 0x15DE7AC
	public Quaternion get_rotation() { }

	// RVA: 0x15DE808
	public Vector3 get_lossyScale() { }

	// RVA: 0x15DE868
	public float get_determinant() { }

	// RVA: 0x15DE8B8
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x15DE9B4
	public static bool Inverse3DAffine(Matrix4x4 input, Matrix4x4 result) { }

	// RVA: 0x15DEA84
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x15DEB64
	public Matrix4x4 get_inverse() { }

	// RVA: 0x15DEBE8
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0x15DECC8
	public Matrix4x4 get_transpose() { }

	// RVA: 0x15DED4C
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x15DEE84
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	// RVA: 0x15DEF8C
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x15DEFA8
	public float get_Item(int row, int column) { }

	// RVA: 0x15DF11C
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x15DEFB0
	public float get_Item(int index) { }

	// RVA: 0x15DF124
	public void set_Item(int index, float value) { }

	// RVA: 0x15DF290
	public override int GetHashCode() { }

	// RVA: 0x15DF6CC
	public override bool Equals(object other) { }

	// RVA: 0x15DF958
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x15DFA04
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x15DFAA8
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x15DF440
	public Vector4 GetColumn(int index) { }

	// RVA: 0x15DFADC
	public Vector4 GetRow(int index) { }

	// RVA: 0x15DFBB8
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x15DFC34
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x15DFCB4
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x15DFD10
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x15DFD5C
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x15DFD88
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x15DFDBC
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x15DFE54
	public static Matrix4x4 get_identity() { }

	// RVA: 0x15DFEB8
	public override string ToString() { }

	// RVA: 0x15E049C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15E0A70
	private static void .cctor() { }

	// RVA: 0x15DE5DC
	private static void GetRotation_Injected(Matrix4x4 _unity_self, Quaternion ret) { }

	// RVA: 0x15DE6A4
	private static void GetLossyScale_Injected(Matrix4x4 _unity_self, Vector3 ret) { }

	// RVA: 0x15DE75C
	private static float GetDeterminant_Injected(Matrix4x4 _unity_self) { }

	// RVA: 0x15DE94C
	private static void TRS_Injected(Vector3 pos, Quaternion q, Vector3 s, Matrix4x4 ret) { }

	// RVA: 0x15DEA1C
	private static bool Inverse3DAffine_Injected(Matrix4x4 input, Matrix4x4 result) { }

	// RVA: 0x15DEAFC
	private static void Inverse_Injected(Matrix4x4 m, Matrix4x4 ret) { }

	// RVA: 0x15DEC60
	private static void Transpose_Injected(Matrix4x4 m, Matrix4x4 ret) { }

	// RVA: 0x15DEDFC
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, Matrix4x4 ret) { }

	// RVA: 0x15DEF1C
	private static void Perspective_Injected(float fov, float aspect, float zNear, float zFar, Matrix4x4 ret) { }

}

// Namespace: UnityEngine
public struct Vector3
{
	// Fields
	public const float kEpsilon = 1e-05;
	public const float kEpsilonNormalSqrt = 1e-15;
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Methods

	// RVA: 0x15E0AEC
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x15E0BD4
	private static void OrthoNormalize2(Vector3 a, Vector3 b) { }

	// RVA: 0x15E0C3C
	public static void OrthoNormalize(Vector3 normal, Vector3 tangent) { }

	// RVA: 0x15E0CA4
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x15E0CE4
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x15E0D0C
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	// RVA: 0x15E0E2C
	public float get_Item(int index) { }

	// RVA: 0x15E0EB8
	public void set_Item(int index, float value) { }

	// RVA: 0x15E0F44
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x15E0F50
	public void .ctor(float x, float y) { }

	// RVA: 0x15E0F5C
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x15E0F68
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x15E0F78
	public void Scale(Vector3 scale) { }

	// RVA: 0x15E0F98
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15E0FC8
	public override int GetHashCode() { }

	// RVA: 0x15E101C
	public override bool Equals(object other) { }

	// RVA: 0x15E10CC
	public bool Equals(Vector3 other) { }

	// RVA: 0x15E10FC
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x15E1134
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x15E123C
	public void Normalize() { }

	// RVA: 0x15E1344
	public Vector3 get_normalized() { }

	// RVA: 0x15E1448
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15E1460
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x15E1574
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x15E1650
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x15E177C
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x15E1820
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x15E18E0
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x15E1964
	public float get_magnitude() { }

	// RVA: 0x15E19F0
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x15E1A08
	public float get_sqrMagnitude() { }

	// RVA: 0x15E1A28
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15E1A44
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15E1A60
	public static Vector3 get_zero() { }

	// RVA: 0x15E1AB0
	public static Vector3 get_one() { }

	// RVA: 0x15E1B00
	public static Vector3 get_forward() { }

	// RVA: 0x15E1B50
	public static Vector3 get_back() { }

	// RVA: 0x15E1BA0
	public static Vector3 get_up() { }

	// RVA: 0x15E1BF0
	public static Vector3 get_down() { }

	// RVA: 0x15E1C40
	public static Vector3 get_left() { }

	// RVA: 0x15E1C90
	public static Vector3 get_right() { }

	// RVA: 0x15E1CE0
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x15E1D30
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x15E1D40
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x15E1D50
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x15E1D60
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x15E1D70
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x15E1D84
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x15E1D94
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15E1DCC
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15E1E04
	public override string ToString() { }

	// RVA: 0x15E1E14
	public string ToString(string format) { }

	// RVA: 0x15E1E20
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15E2018
	private static void .cctor() { }

	// RVA: 0x15E0B6C
	private static void Slerp_Injected(Vector3 a, Vector3 b, float t, Vector3 ret) { }

}

// Namespace: UnityEngine
public struct Quaternion
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18
	public float w; // 0x1C
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Methods

	// RVA: 0x15E20A8
	public static Quaternion Inverse(Quaternion rotation) { }

	// RVA: 0x15E2170
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x15E2254
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x15E2338
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x15E241C
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	// RVA: 0x15E24E4
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	// RVA: 0x15E25B0
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	// RVA: 0x15E2680
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	// RVA: 0x15E2744
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x15E2804
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x15E2810
	public static Quaternion get_identity() { }

	// RVA: 0x15E2860
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x15E28E0
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x15E2984
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x15E299C
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x15E29D0
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x15E2A04
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x15E2A24
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x15E2A90
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x15E2B50
	public Vector3 get_eulerAngles() { }

	// RVA: 0x15E2C88
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x15E2D04
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x15E2D7C
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x15E2DF4
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x15E2F28
	public static Quaternion Normalize(Quaternion q) { }

	// RVA: 0x15E3018
	public Quaternion get_normalized() { }

	// RVA: 0x15E3100
	public override int GetHashCode() { }

	// RVA: 0x15E3168
	public override bool Equals(object other) { }

	// RVA: 0x15E324C
	public bool Equals(Quaternion other) { }

	// RVA: 0x15E32DC
	public override string ToString() { }

	// RVA: 0x15E32EC
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15E3530
	private static void .cctor() { }

	// RVA: 0x15E2108
	private static void Inverse_Injected(Quaternion rotation, Quaternion ret) { }

	// RVA: 0x15E21EC
	private static void Slerp_Injected(Quaternion a, Quaternion b, float t, Quaternion ret) { }

	// RVA: 0x15E22D0
	private static void SlerpUnclamped_Injected(Quaternion a, Quaternion b, float t, Quaternion ret) { }

	// RVA: 0x15E23B4
	private static void Lerp_Injected(Quaternion a, Quaternion b, float t, Quaternion ret) { }

	// RVA: 0x15E247C
	private static void Internal_FromEulerRad_Injected(Vector3 euler, Quaternion ret) { }

	// RVA: 0x15E2548
	private static void Internal_ToEulerRad_Injected(Quaternion rotation, Vector3 ret) { }

	// RVA: 0x15E2620
	private static void AngleAxis_Injected(float angle, Vector3 axis, Quaternion ret) { }

	// RVA: 0x15E26EC
	private static void LookRotation_Injected(Vector3 forward, Vector3 upwards, Quaternion ret) { }

}

// Namespace: UnityEngine
public struct Mathf
{
	// Fields
	public static readonly float Epsilon; // 0x0

	// Methods

	// RVA: 0x15E3584
	public static int ClosestPowerOfTwo(int value) { }

	// RVA: 0x15E35D4
	public static bool IsPowerOfTwo(int value) { }

	// RVA: 0x15E3624
	public static int NextPowerOfTwo(int value) { }

	// RVA: 0x15DC6DC
	public static float GammaToLinearSpace(float value) { }

	// RVA: 0x15DC81C
	public static float LinearToGammaSpace(float value) { }

	// RVA: 0x15E3674
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	// RVA: 0x15E3740
	public static float Sin(float f) { }

	// RVA: 0x15E37A8
	public static float Cos(float f) { }

	// RVA: 0x15E3810
	public static float Tan(float f) { }

	// RVA: 0x15E3878
	public static float Asin(float f) { }

	// RVA: 0x15E38E0
	public static float Acos(float f) { }

	// RVA: 0x15E3948
	public static float Atan(float f) { }

	// RVA: 0x15E39B0
	public static float Atan2(float y, float x) { }

	// RVA: 0x15E3A20
	public static float Sqrt(float f) { }

	// RVA: 0x15E3AA0
	public static float Abs(float f) { }

	// RVA: 0x15E3B20
	public static int Abs(int value) { }

	// RVA: 0x15E3BA8
	public static float Min(float a, float b) { }

	// RVA: 0x15E3BB4
	public static int Min(int a, int b) { }

	// RVA: 0x15E3BC0
	public static float Max(float a, float b) { }

	// RVA: 0x15E3BCC
	public static float Max(float[] values) { }

	// RVA: 0x15E3C24
	public static int Max(int a, int b) { }

	// RVA: 0x15E3C30
	public static float Pow(float f, float p) { }

	// RVA: 0x15E3CA4
	public static float Exp(float power) { }

	// RVA: 0x15E3D0C
	public static float Log(float f, float p) { }

	// RVA: 0x15E3D80
	public static float Log(float f) { }

	// RVA: 0x15E3DE8
	public static float Log10(float f) { }

	// RVA: 0x15E3E50
	public static float Ceil(float f) { }

	// RVA: 0x15E3ED0
	public static float Floor(float f) { }

	// RVA: 0x15E3F50
	public static float Round(float f) { }

	// RVA: 0x15E4074
	public static int CeilToInt(float f) { }

	// RVA: 0x15E40EC
	public static int FloorToInt(float f) { }

	// RVA: 0x15E4164
	public static int RoundToInt(float f) { }

	// RVA: 0x15E4274
	public static float Sign(float f) { }

	// RVA: 0x15E4288
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x15E429C
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x15E42B0
	public static float Clamp01(float value) { }

	// RVA: 0x15E42CC
	public static float Lerp(float a, float b, float t) { }

	// RVA: 0x15E42F4
	public static float LerpUnclamped(float a, float b, float t) { }

	// RVA: 0x15E4304
	public static float LerpAngle(float a, float b, float t) { }

	// RVA: 0x15E4370
	public static float MoveTowards(float current, float target, float maxDelta) { }

	// RVA: 0x15E4394
	public static float SmoothStep(float from, float to, float t) { }

	// RVA: 0x15E43DC
	public static bool Approximately(float a, float b) { }

	// RVA: 0x15E4474
	public static float SmoothDamp(float current, float target, float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x15E4558
	public static float Repeat(float t, float length) { }

	// RVA: 0x15E4580
	public static float InverseLerp(float a, float b, float value) { }

	// RVA: 0x15E45B8
	public static float DeltaAngle(float current, float target) { }

	// RVA: 0x15E4608
	internal static float ClampToFloat(Double value) { }

	// RVA: 0x15E4688
	internal static int ClampToInt(Int64 value) { }

	// RVA: 0x15E46A4
	internal static UInt32 ClampToUInt(Int64 value) { }

	// RVA: 0x15E46BC
	internal static int GetNumberOfDecimalsForMinimumDifference(Double minDifference) { }

	// RVA: 0x15E474C
	internal static Double RoundBasedOnMinimumDifference(Double valueToRound, Double minDifference) { }

	// RVA: 0x15E483C
	internal static Double DiscardLeastSignificantDecimal(Double v) { }

	// RVA: 0x15E49C8
	private static void .cctor() { }

	// RVA: 0x15E36D8
	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, Color ret) { }

}

// Namespace: UnityEngine
public struct Vector2
{
	// Fields
	public float x; // 0x10
	public float y; // 0x14
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Methods

	// RVA: 0x15E4A54
	public float get_Item(int index) { }

	// RVA: 0x15E4AC8
	public void set_Item(int index, float value) { }

	// RVA: 0x15E4B3C
	public void .ctor(float x, float y) { }

	// RVA: 0x15E4B44
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x15E4B78
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x15E4B94
	public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) { }

	// RVA: 0x15E4C68
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x15E4C74
	public void Normalize() { }

	// RVA: 0x15E4D6C
	public Vector2 get_normalized() { }

	// RVA: 0x15E4E50
	public override string ToString() { }

	// RVA: 0x15E4E60
	public string ToString(string format) { }

	// RVA: 0x15E4E6C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15E5018
	public override int GetHashCode() { }

	// RVA: 0x15E5050
	public override bool Equals(object other) { }

	// RVA: 0x15E50F0
	public bool Equals(Vector2 other) { }

	// RVA: 0x15E5114
	public static Vector2 Perpendicular(Vector2 inDirection) { }

	// RVA: 0x15E5124
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15E5134
	public float get_magnitude() { }

	// RVA: 0x15E51AC
	public float get_sqrMagnitude() { }

	// RVA: 0x15E51C0
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x15E52C4
	public static float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x15E53E0
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x15E5468
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	// RVA: 0x15E5508
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15E551C
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15E5530
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x15E553C
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x15E5548
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x15E5554
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x15E5560
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x15E556C
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x15E5578
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x15E5588
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x15E5594
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15E55C0
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15E55EC
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x15E55F0
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x15E55F8
	public static Vector2 get_zero() { }

	// RVA: 0x15E5644
	public static Vector2 get_one() { }

	// RVA: 0x15E5690
	public static Vector2 get_up() { }

	// RVA: 0x15E56DC
	public static Vector2 get_down() { }

	// RVA: 0x15E5728
	public static Vector2 get_left() { }

	// RVA: 0x15E5774
	public static Vector2 get_right() { }

	// RVA: 0x15E57C0
	public static Vector2 get_negativeInfinity() { }

	// RVA: 0x15E580C
	private static void .cctor() { }

}

// Namespace: UnityEngine
public struct Vector2Int
{
	// Fields
	private int m_X; // 0x10
	private int m_Y; // 0x14
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Methods

	// RVA: 0x15E587C
	public int get_x() { }

	// RVA: 0x15E5884
	public void set_x(int value) { }

	// RVA: 0x15E588C
	public int get_y() { }

	// RVA: 0x15E5894
	public void set_y(int value) { }

	// RVA: 0x15E589C
	public void .ctor(int x, int y) { }

	// RVA: 0x15E58A4
	public float get_magnitude() { }

	// RVA: 0x15E58BC
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x15E58CC
	public static Vector2Int FloorToInt(Vector2 v) { }

	// RVA: 0x15E59B8
	public static Vector2Int op_Subtraction(Vector2Int a, Vector2Int b) { }

	// RVA: 0x15E59D0
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x15E59DC
	public static bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x15E59E8
	public override bool Equals(object other) { }

	// RVA: 0x15E5A88
	public bool Equals(Vector2Int other) { }

	// RVA: 0x15E5AB0
	public override int GetHashCode() { }

	// RVA: 0x15E5B04
	public override string ToString() { }

	// RVA: 0x15E5CB8
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15E5E54
	public static Vector2Int get_zero() { }

	// RVA: 0x15E5EA0
	private static void .cctor() { }

}

// Namespace: UnityEngine
public struct Vector3Int
{
	// Fields
	private int m_X; // 0x10
	private int m_Y; // 0x14
	private int m_Z; // 0x18
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C
	private static readonly Vector3Int s_Forward; // 0x48
	private static readonly Vector3Int s_Back; // 0x54

	// Methods

	// RVA: 0x15E5F2C
	public int get_x() { }

	// RVA: 0x15E5F34
	public void set_x(int value) { }

	// RVA: 0x15E5F3C
	public int get_y() { }

	// RVA: 0x15E5F44
	public void set_y(int value) { }

	// RVA: 0x15E5F4C
	public int get_z() { }

	// RVA: 0x15E5F54
	public void set_z(int value) { }

	// RVA: 0x15E5F5C
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x15E5F68
	public static Vector3 op_Implicit(Vector3Int v) { }

	// RVA: 0x15E5F7C
	public static Vector3Int op_Subtraction(Vector3Int a, Vector3Int b) { }

	// RVA: 0x15E5F98
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x15E5FB8
	public override bool Equals(object other) { }

	// RVA: 0x15E6064
	public bool Equals(Vector3Int other) { }

	// RVA: 0x15E6094
	public override int GetHashCode() { }

	// RVA: 0x15E6118
	public override string ToString() { }

	// RVA: 0x15E6128
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15E6318
	public static Vector3Int get_zero() { }

	// RVA: 0x15E6368
	private static void .cctor() { }

}

// Namespace: UnityEngine
public struct Vector4
{
	// Fields
	public const float kEpsilon = 1e-05;
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18
	public float w; // 0x1C
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Methods

	// RVA: 0x15E63E8
	public float get_Item(int index) { }

	// RVA: 0x15E6494
	public void set_Item(int index, float value) { }

	// RVA: 0x15E6540
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x15E654C
	public void .ctor(float x, float y) { }

	// RVA: 0x15E6558
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x15E65A8
	public override int GetHashCode() { }

	// RVA: 0x15E6610
	public override bool Equals(object other) { }

	// RVA: 0x15E66D0
	public bool Equals(Vector4 other) { }

	// RVA: 0x15E670C
	public void Normalize() { }

	// RVA: 0x15E6820
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x15E6840
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x15E68D0
	public float get_sqrMagnitude() { }

	// RVA: 0x15E68F8
	public static Vector4 get_zero() { }

	// RVA: 0x15E6948
	public static Vector4 get_one() { }

	// RVA: 0x15E6998
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x15E69AC
	public static Vector4 op_Subtraction(Vector4 a, Vector4 b) { }

	// RVA: 0x15E69C0
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x15E69D4
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x15E69E8
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x15E6A2C
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x15E6A70
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x15E6A78
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x15E6A7C
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x15E6A88
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x15E6A8C
	public override string ToString() { }

	// RVA: 0x15E6A9C
	public string ToString(string format) { }

	// RVA: 0x15E6AA8
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15E6CEC
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal struct TypeDispatchData
{
	// Fields
	public object[] changed; // 0x10
	public Unity.Collections.NativeArray<System.Int32> changedID; // 0x18
	public Unity.Collections.NativeArray<System.Int32> destroyedID; // 0x28

	// Methods

	// RVA: 0x15E6D50
	public void Dispose() { }

}

// Namespace: UnityEngine
internal struct TransformDispatchData
{
	// Fields
	public Unity.Collections.NativeArray<System.Int32> transformedID; // 0x10
	public Unity.Collections.NativeArray<System.Int32> parentID; // 0x20
	public Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices; // 0x30
	public Unity.Collections.NativeArray<UnityEngine.Vector3> positions; // 0x40
	public Unity.Collections.NativeArray<UnityEngine.Quaternion> rotations; // 0x50
	public Unity.Collections.NativeArray<UnityEngine.Vector3> scales; // 0x60

	// Methods

	// RVA: 0x15E6DC4
	public void Dispose() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ObjectDispatcher.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15E6FE0
	private static void .cctor() { }

	// RVA: 0x15E704C
	public void .ctor() { }

	// RVA: 0x15E7054
	internal void <.cctor>b__54_0(object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, System.Action<UnityEngine.TypeDispatchData> callback) { }

	// RVA: 0x15E7154
	internal void <.cctor>b__54_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, System.Action<UnityEngine.TransformDispatchData> callback) { }

}

// Namespace: UnityEngine
internal sealed class ObjectDispatcher
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private static System.Action<UnityEngine.Object[],System.IntPtr,System.IntPtr,System.Int32,System.Int32,System.Action<UnityEngine.TypeDispatchData>> s_TypeDispatch; // 0x0
	private static System.Action<System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.Int32,System.Action<UnityEngine.TransformDispatchData>> s_TransformDispatch; // 0x8

	// Methods

	// RVA: 0x15E6E98
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal class NumericFieldDraggerUtility
{
	// Fields
	private static bool s_UseYSign; // 0x0

	// Methods

	// RVA: 0x15E7350
	internal static float Acceleration(bool shiftPressed, bool altPressed) { }

	// RVA: 0x15E7374
	internal static float NiceDelta(Vector2 deviceDelta, float acceleration) { }

	// RVA: 0x15E7524
	internal static Double CalculateFloatDragSensitivity(Double value) { }

	// RVA: 0x15E75E4
	internal static Double CalculateFloatDragSensitivity(Double value, Double minValue, Double maxValue) { }

	// RVA: 0x15E76A8
	internal static Int64 CalculateIntDragSensitivity(Int64 value) { }

	// RVA: 0x15E77C8
	internal static UInt64 CalculateIntDragSensitivity(UInt64 value) { }

	// RVA: 0x15E7748
	private static Double CalculateIntDragSensitivity(Double value) { }

	// RVA: 0x15E785C
	internal static Int64 CalculateIntDragSensitivity(Int64 value, Int64 minValue, Int64 maxValue) { }

}

// Namespace: UnityEngine
internal interface IPlayerEditorConnectionNative
{
	// Methods

	// RVA: -1
	public abstract void Initialize() { }

	// RVA: -1
	public abstract void DisconnectAll() { }

	// RVA: -1
	public abstract void SendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: -1
	public abstract bool TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: -1
	public abstract void Poll() { }

	// RVA: -1
	public abstract void RegisterInternal(Guid messageId) { }

	// RVA: -1
	public abstract void UnregisterInternal(Guid messageId) { }

	// RVA: -1
	public abstract bool IsConnected() { }

}

// Namespace: UnityEngine
internal class PlayerConnectionInternal
{
	// Methods

	// RVA: 0x15E7904
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x15E7A88
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x15E7C0C
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x15E7C8C
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x15E7D7C
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x15E7E6C
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x15E7EEC
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x15E7F6C
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	// RVA: 0x15E7F2C
	private static bool IsConnected() { }

	// RVA: 0x15E7EAC
	private static void Initialize() { }

	// RVA: 0x15E7D2C
	private static void RegisterInternal(string messageId) { }

	// RVA: 0x15E7E1C
	private static void UnregisterInternal(string messageId) { }

	// RVA: 0x15E7A30
	private static void SendMessage(string messageId, Byte[] data, int playerId) { }

	// RVA: 0x15E7BB4
	private static bool TrySendMessage(string messageId, Byte[] data, int playerId) { }

	// RVA: 0x15E7C4C
	private static void PollInternal() { }

	// RVA: 0x15E7FAC
	private static void DisconnectAll() { }

	// RVA: 0x15E7FEC
	public void .ctor() { }

}

// Namespace: UnityEngine
public class PlayerPrefsException
{
	// Methods

	// RVA: 0x15E7FF4
	public void .ctor(string error) { }

}

// Namespace: UnityEngine
public class PlayerPrefs
{
	// Methods

	// RVA: 0x15E8060
	private static bool TrySetInt(string key, int value) { }

	// RVA: 0x15E80C8
	private static bool TrySetFloat(string key, float value) { }

	// RVA: 0x15E8130
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x15E8198
	public static void SetInt(string key, int value) { }

	// RVA: 0x15E8234
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x15E829C
	public static int GetInt(string key) { }

	// RVA: 0x15E82F4
	public static void SetFloat(string key, float value) { }

	// RVA: 0x15E8390
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x15E83F8
	public static void SetString(string key, string value) { }

	// RVA: 0x15E8494
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x15E84FC
	public static string GetString(string key) { }

	// RVA: 0x15E859C
	public static bool HasKey(string key) { }

	// RVA: 0x15E85EC
	public static void DeleteKey(string key) { }

	// RVA: 0x15E863C
	public static void DeleteAll() { }

	// RVA: 0x15E867C
	public static void Save() { }

}

// Namespace: UnityEngine
public abstract class PropertyAttribute
{
	// Fields
	private int <order>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15E86BC
	public void set_order(int value) { }

	// RVA: 0x15E86C4
	protected void .ctor() { }

}

// Namespace: UnityEngine
public class InspectorNameAttribute
{
	// Fields
	public readonly string displayName; // 0x18
}

// Namespace: UnityEngine
public class TooltipAttribute
{
	// Fields
	public readonly string tooltip; // 0x18

	// Methods

	// RVA: 0x15E86CC
	public void .ctor(string tooltip) { }

}

// Namespace: UnityEngine
public class SpaceAttribute
{
	// Fields
	public readonly float height; // 0x14

	// Methods

	// RVA: 0x15E8700
	public void .ctor() { }

	// RVA: 0x15E872C
	public void .ctor(float height) { }

}

// Namespace: UnityEngine
public class HeaderAttribute
{
	// Fields
	public readonly string header; // 0x18

	// Methods

	// RVA: 0x15E8760
	public void .ctor(string header) { }

}

// Namespace: UnityEngine
public sealed class RangeAttribute
{
	// Fields
	public readonly float min; // 0x14
	public readonly float max; // 0x18

	// Methods

	// RVA: 0x15E8794
	public void .ctor(float min, float max) { }

}

// Namespace: UnityEngine
public sealed class MinAttribute
{
	// Fields
	public readonly float min; // 0x14

	// Methods

	// RVA: 0x15E87CC
	public void .ctor(float min) { }

}

// Namespace: UnityEngine
public sealed class MultilineAttribute
{
	// Fields
	public readonly int lines; // 0x14

	// Methods

	// RVA: 0x15E8800
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class TextAreaAttribute
{
	// Fields
	public readonly int minLines; // 0x14
	public readonly int maxLines; // 0x18

	// Methods

	// RVA: 0x15E882C
	public void .ctor(int minLines, int maxLines) { }

}

// Namespace: UnityEngine
public sealed class ColorUsageAttribute
{
	// Fields
	public readonly bool showAlpha; // 0x14
	public readonly bool hdr; // 0x15
	public readonly float minBrightness; // 0x18
	public readonly float maxBrightness; // 0x1C
	public readonly float minExposureValue; // 0x20
	public readonly float maxExposureValue; // 0x24

	// Methods

	// RVA: 0x15E8864
	public void .ctor(bool showAlpha, bool hdr) { }

}

// Namespace: UnityEngine
public sealed class GradientUsageAttribute
{
	// Fields
	public readonly bool hdr; // 0x14
	public readonly ColorSpace colorSpace; // 0x18

	// Methods

	// RVA: 0x15E88B4
	public void .ctor(bool hdr) { }

}

// Namespace: UnityEngine
internal class PropertyNameUtils
{
	// Methods

	// RVA: 0x15E88EC
	public static PropertyName PropertyNameFromString(string name) { }

	// RVA: 0x15E8944
	private static void PropertyNameFromString_Injected(string name, PropertyName ret) { }

}

// Namespace: UnityEngine
public struct PropertyName
{
	// Fields
	internal int id; // 0x10

	// Methods

	// RVA: 0x15E89AC
	public void .ctor(string name) { }

	// RVA: 0x15E8A14
	public void .ctor(PropertyName other) { }

	// RVA: 0x15E8A1C
	public static bool IsNullOrEmpty(PropertyName prop) { }

	// RVA: 0x15E8A28
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	// RVA: 0x15E8A34
	public override int GetHashCode() { }

	// RVA: 0x15E8A3C
	public override bool Equals(object other) { }

	// RVA: 0x15E8ACC
	public bool Equals(PropertyName other) { }

	// RVA: 0x15E8ADC
	public static PropertyName op_Implicit(string name) { }

	// RVA: 0x15E8B34
	public override string ToString() { }

}

// Namespace: UnityEngine
public static class Random
{
	// Methods

	// RVA: 0x15E8BC0
	public static float Range(float minInclusive, float maxInclusive) { }

	// RVA: 0x15E8C24
	public static int Range(int minInclusive, int maxExclusive) { }

	// RVA: 0x15E8C8C
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	// RVA: 0x15E8CF4
	public static float get_value() { }

	// RVA: 0x15E8D34
	public static Vector3 get_insideUnitSphere() { }

	// RVA: 0x15E8DDC
	public static Vector3 get_onUnitSphere() { }

	// RVA: 0x15E8D8C
	private static void get_insideUnitSphere_Injected(Vector3 ret) { }

	// RVA: 0x15E8E34
	private static void get_onUnitSphere_Injected(Vector3 ret) { }

}

// Namespace: UnityEngine
public class ResourceRequest
{
	// Fields
	internal string m_Path; // 0x20
	internal Type m_Type; // 0x28

	// Methods

	// RVA: 0x15E8E84
	protected virtual object GetResult() { }

	// RVA: 0x15E8FA0
	public void .ctor() { }

}

// Namespace: UnityEngine
internal static class ResourcesAPIInternal
{
	// Methods

	// RVA: 0x15E8FB0
	public static object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x15E9000
	public static Shader FindShaderByName(string name) { }

	// RVA: 0x15E9050
	public static object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x15E90B8
	public static void UnloadAsset(object assetToUnload) { }

}

// Namespace: UnityEngine
public class ResourcesAPI
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Methods

	// RVA: 0x15E9108
	internal static ResourcesAPI get_ActiveAPI() { }

	// RVA: 0x15E9208
	public static ResourcesAPI get_overrideAPI() { }

	// RVA: 0x15E9284
	protected internal void .ctor() { }

	// RVA: 0x15E928C
	protected internal virtual object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x15E92DC
	protected internal virtual Shader FindShaderByName(string name) { }

	// RVA: 0x15E932C
	protected internal virtual object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x15E9394
	protected internal virtual void UnloadAsset(object assetToUnload) { }

	// RVA: 0x15E93E4
	private static void .cctor() { }

}

// Namespace: UnityEngine
public sealed class Resources
{
	// Methods

	// RVA: 0x30B57C8
	internal static T[] ConvertObjects(object[] rawObjects) { }

	// RVA: 0x15E9450
	public static object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x30B5790
	public static T[] FindObjectsOfTypeAll() { }

	// RVA: 0x15E94D8
	public static object Load(string path) { }

	// RVA: 0x316B894
	public static T Load(string path) { }

	// RVA: 0x15E8F10
	public static object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x15E95C4
	public static object GetBuiltinResource(Type type, string path) { }

	// RVA: 0x316B894
	public static T GetBuiltinResource(string path) { }

	// RVA: 0x15E962C
	public static void UnloadAsset(object assetToUnload) { }

	// RVA: 0x15E96B4
	public static AsyncOperation UnloadUnusedAssets() { }

}

// Namespace: UnityEngine
public class AsyncInstantiateOperation
{
	// Fields
	internal object[] m_Result; // 0x20
}

// Namespace: UnityEngine
internal class AsyncInstantiateOperationHelper
{
	// Methods

	// RVA: 0x15E96F4
	public static void SetAsyncInstantiateOperationResult(AsyncInstantiateOperation op, object[] result) { }

}

// Namespace: UnityEngine
public class AsyncOperation
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private System.Action<UnityEngine.AsyncOperation> m_completeCallback; // 0x18

	// Methods

	// RVA: 0x15E9710
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x15E9760
	public bool get_isDone() { }

	// RVA: 0x15E97B0
	public float get_progress() { }

	// RVA: 0x15E9800
	protected override void Finalize() { }

	// RVA: 0x15E98B8
	internal void InvokeCompletionEvent() { }

	// RVA: 0x15E8FA8
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class AttributeHelperEngine
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	// RVA: 0x15E990C
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	// RVA: 0x15E9A50
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x15E9F08
	private static int GetExecuteMode(Type klass) { }

	// RVA: 0x15EA050
	private static int CheckIsEditorScript(Type klass) { }

	// RVA: 0x15EA1A0
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: 0x316B894
	private static T GetCustomAttributeOfType(Type klass) { }

	// RVA: 0x15EA254
	private static void .cctor() { }

}

// Namespace: UnityEngine
public sealed class DisallowMultipleComponent
{
	// Methods

	// RVA: 0x15EA344
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class RequireComponent
{
	// Fields
	public Type m_Type0; // 0x10
	public Type m_Type1; // 0x18
	public Type m_Type2; // 0x20

	// Methods

	// RVA: 0x15EA34C
	public void .ctor(Type requiredComponent) { }

	// RVA: 0x15EA380
	public void .ctor(Type requiredComponent, Type requiredComponent2) { }

}

// Namespace: UnityEngine
public sealed class AddComponentMenu
{
	// Fields
	private string m_AddComponentMenu; // 0x10
	private int m_Ordering; // 0x18

	// Methods

	// RVA: 0x15EA3D0
	public void .ctor(string menuName) { }

	// RVA: 0x15EA40C
	public void .ctor(string menuName, int order) { }

}

// Namespace: UnityEngine
public sealed class CreateAssetMenuAttribute
{
	// Fields
	private string <menuName>k__BackingField; // 0x10
	private string <fileName>k__BackingField; // 0x18
	private int <order>k__BackingField; // 0x20

	// Methods

	// RVA: 0x15EA454
	public void set_menuName(string value) { }

	// RVA: 0x15EA45C
	public void set_fileName(string value) { }

	// RVA: 0x15EA464
	public void set_order(int value) { }

	// RVA: 0x15EA46C
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ContextMenu
{
	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x15EA474
	public void .ctor(string itemName) { }

	// RVA: 0x15EA4BC
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x15EA510
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

// Namespace: UnityEngine
public sealed class ExecuteInEditMode
{
	// Methods

	// RVA: 0x15EA560
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ExecuteAlways
{
	// Methods

	// RVA: 0x15EA568
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class HideInInspector
{
	// Methods

	// RVA: 0x15EA570
	public void .ctor() { }

}

// Namespace: UnityEngine
public class HelpURLAttribute
{
	// Fields
	internal readonly string m_Url; // 0x10
	internal readonly bool m_Dispatcher; // 0x18
	internal readonly string m_DispatchingFieldName; // 0x20

	// Methods

	// RVA: 0x15EA578
	public void .ctor(string url) { }

}

// Namespace: UnityEngine
public class DefaultExecutionOrder
{
	// Fields
	private int m_Order; // 0x10

	// Methods

	// RVA: 0x15EA5F8
	public void .ctor(int order) { }

	// RVA: 0x15EA24C
	public int get_order() { }

}

// Namespace: UnityEngine
public class AssemblyIsEditorAssembly
{}

// Namespace: UnityEngine
public class ExcludeFromPresetAttribute
{
	// Methods

	// RVA: 0x15EA624
	public void .ctor() { }

}

// Namespace: UnityEngine
public class Behaviour
{
	// Methods

	// RVA: 0x15EA62C
	public bool get_enabled() { }

	// RVA: 0x15EA67C
	public void set_enabled(bool value) { }

	// RVA: 0x15EA6E4
	public bool get_isActiveAndEnabled() { }

	// RVA: 0x15EA734
	public void .ctor() { }

}

// Namespace: UnityEngine
internal struct CastHelper<T0>
{
	// Fields
	public T t; // 0x0
	public IntPtr onePointerFurtherThanT; // 0x0
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ClassLibraryInitializer.<>c <>9; // 0x0
	public static ResolveEventHandler <>9__2_0; // 0x8

	// Methods

	// RVA: 0x15EAAB8
	private static void .cctor() { }

	// RVA: 0x15EAB24
	public void .ctor() { }

	// RVA: 0x15EAB2C
	internal Assembly <InitAssemblyRedirections>b__2_0(object _, ResolveEventArgs args) { }

}

// Namespace: UnityEngine
internal static class ClassLibraryInitializer
{
	// Methods

	// RVA: 0x15EA844
	private static void Init() { }

	// RVA: 0x15EA848
	private static void InitStdErrWithHandle(IntPtr fileHandle) { }

	// RVA: 0x15EA998
	private static void InitAssemblyRedirections() { }

}

// Namespace: UnityEngine
internal struct AssemblyVersion
{
	// Fields
	public UInt16 major; // 0x10
	public UInt16 minor; // 0x12
	public UInt16 build; // 0x14
	public UInt16 revision; // 0x16

	// Methods

	// RVA: 0x15EAC4C
	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	// RVA: 0x15EAC70
	public override string ToString() { }

	// RVA: 0x15EAE50
	public override bool Equals(object other) { }

	// RVA: 0x15EAF10
	public override int GetHashCode() { }

}

// Namespace: UnityEngine
internal struct AssemblyFullName
{
	// Fields
	public string Name; // 0x10
	public AssemblyVersion Version; // 0x18
	public string PublicKeyToken; // 0x20
	public string Culture; // 0x28

	// Methods

	// RVA: 0x15EAFC8
	public override bool Equals(object other) { }

	// RVA: 0x15EB0A4
	public override int GetHashCode() { }

	// RVA: 0x15EB148
	public override string ToString() { }

}

// Namespace: UnityEngine
public class Component
{
	// Methods

	// RVA: 0x15EB324
	public Transform get_transform() { }

	// RVA: 0x15EB374
	public GameObject get_gameObject() { }

	// RVA: 0x15EB3C4
	public Component GetComponent(Type type) { }

	// RVA: 0x15EB4C8
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x316B894
	public T GetComponent() { }

	// RVA: 0x15EB520
	public bool TryGetComponent(Type type, Component component) { }

	// RVA: 0x30B183C
	public bool TryGetComponent(T component) { }

	// RVA: 0x15EB6C4
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: 0x316B894
	public T GetComponentInChildren(bool includeInactive) { }

	// RVA: 0x316B894
	public T GetComponentInChildren() { }

	// RVA: -1
	public T[] GetComponentsInChildren(bool includeInactive) { }

	// RVA: -1
	public void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> result) { }

	// RVA: 0x30B1CD4
	public T[] GetComponentsInChildren() { }

	// RVA: 0x30B2CB8
	public void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }

	// RVA: 0x15EB7A8
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	// RVA: 0x316B894
	public T GetComponentInParent() { }

	// RVA: -1
	public T[] GetComponentsInParent(bool includeInactive) { }

	// RVA: -1
	public void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: 0x30B1CD4
	public T[] GetComponentsInParent() { }

	// RVA: 0x15EB88C
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x15EB8E4
	public void GetComponents(Type type, System.Collections.Generic.List<UnityEngine.Component> results) { }

	// RVA: 0x30B2CB8
	public void GetComponents(System.Collections.Generic.List<T> results) { }

	// RVA: 0x30B1CD4
	public T[] GetComponents() { }

	// RVA: 0x15EB93C
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x15EB9A4
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	// RVA: 0x15EA7BC
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class Coroutine
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15EBA0C
	private void .ctor() { }

	// RVA: 0x15EBA14
	protected override void Finalize() { }

	// RVA: 0x15EBACC
	private static void ReleaseCoroutine(IntPtr ptr) { }

}

// Namespace: UnityEngine
internal class SetupCoroutine
{
	// Methods

	// RVA: 0x15EBB1C
	public static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) { }

	// RVA: 0x15EBC50
	public static object InvokeMember(object behaviour, string name, object variable) { }

}

// Namespace: UnityEngine
public abstract class CustomYieldInstruction
{
	// Methods

	// RVA: -1
	public abstract bool get_keepWaiting() { }

	// RVA: 0x15EBD54
	public object get_Current() { }

	// RVA: 0x15EBD5C
	public bool MoveNext() { }

	// RVA: 0x15EBD68
	public virtual void Reset() { }

	// RVA: 0x15EBD6C
	protected void .ctor() { }

}

// Namespace: UnityEngine
internal struct EnumData
{
	// Fields
	public Enum[] values; // 0x10
	public int[] flagValues; // 0x18
	public string[] displayNames; // 0x20
	public string[] names; // 0x28
	public string[] tooltip; // 0x30
	public bool flags; // 0x38
	public Type underlyingType; // 0x40
	public bool unsigned; // 0x48
	public bool serializable; // 0x49
}

// Namespace: 
public enum CachedType
{
	// Fields
	public int value__; // 0x10
	public const CachedType ExcludeObsolete = 0;
	public const CachedType IncludeObsoleteExceptErrors = 1;
	public const CachedType IncludeAllObsolete = 2;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.EnumDataUtility.<>c <>9; // 0x0
	public static System.Func<System.Reflection.FieldInfo,System.Int32> <>9__2_5; // 0x8
	public static System.Func<System.Reflection.FieldInfo,System.String> <>9__2_1; // 0x10
	public static System.Func<System.Reflection.FieldInfo,System.Enum> <>9__2_2; // 0x18
	public static System.Func<System.Enum,System.Int32> <>9__2_3; // 0x20
	public static System.Func<System.Enum,System.Int32> <>9__2_4; // 0x28

	// Methods

	// RVA: 0x15EDBF8
	private static void .cctor() { }

	// RVA: 0x15EDC64
	public void .ctor() { }

	// RVA: 0x15EDC6C
	internal int <GetCachedEnumData>b__2_5(FieldInfo f) { }

	// RVA: 0x15EDC98
	internal string <GetCachedEnumData>b__2_1(FieldInfo f) { }

	// RVA: 0x15EDD18
	internal Enum <GetCachedEnumData>b__2_2(FieldInfo f) { }

	// RVA: 0x15EDDB0
	internal int <GetCachedEnumData>b__2_3(Enum v) { }

	// RVA: 0x15EDE18
	internal int <GetCachedEnumData>b__2_4(Enum v) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public System.Func<System.String,System.String> nicifyName; // 0x10

	// Methods

	// RVA: 0x15ECE7C
	public void .ctor() { }

	// RVA: 0x15EDE80
	internal string <GetCachedEnumData>b__0(FieldInfo f) { }

}

// Namespace: 
private struct <>c__DisplayClass8_0
{
	// Fields
	public System.Func<System.String,System.String> nicifyName; // 0x10
	public FieldInfo field; // 0x18
}

// Namespace: UnityEngine
internal static class EnumDataUtility
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.ValueTuple<UnityEngine.EnumDataUtility.CachedType,System.Type>,UnityEngine.EnumData> s_EnumData; // 0x0

	// Methods

	// RVA: 0x15EBD74
	public static EnumData GetCachedEnumData(Type enumType, CachedType cachedType, System.Func<System.String,System.String> nicifyName) { }

	// RVA: 0x15ED00C
	internal static void HandleInspectorOrderAttribute(Type enumType, EnumData enumData) { }

	// RVA: 0x15ECE84
	private static bool CheckObsoleteAddition(FieldInfo field, CachedType cachedType) { }

	// RVA: 0x15ED678
	private static string EnumTooltipFromEnumField(FieldInfo field) { }

	// RVA: 0x15ED7FC
	private static string EnumNameFromEnumField(FieldInfo field, System.Func<System.String,System.String> nicifyName) { }

	// RVA: 0x15EDB5C
	private static void .cctor() { }

	// RVA: 0x15EDAE8
	internal static string <EnumNameFromEnumField>g__NicifyName|8_0(UnityEngine.EnumDataUtility.<>c__DisplayClass8_0& ) { }

}

// Namespace: UnityEngine
public class ExcludeFromObjectFactoryAttribute
{
	// Methods

	// RVA: 0x15EDF14
	public void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class ExtensionOfNativeClassAttribute
{
	// Methods

	// RVA: 0x15EDF1C
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class FailedToLoadScriptObject
{}

// Namespace: UnityEngine
public sealed class GameObject
{
	// Methods

	// RVA: 0x15EDF24
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: 0x316B894
	public T GetComponent() { }

	// RVA: 0x15EB460
	public Component GetComponent(Type type) { }

	// RVA: 0x15EDF74
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x15EB750
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	// RVA: 0x316B894
	public T GetComponentInChildren() { }

	// RVA: 0x316B894
	public T GetComponentInChildren(bool includeInactive) { }

	// RVA: 0x15EB834
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	// RVA: 0x316B894
	public T GetComponentInParent() { }

	// RVA: 0x316B894
	public T GetComponentInParent(bool includeInactive) { }

	// RVA: 0x15EDFCC
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x30B1CD4
	public T[] GetComponents() { }

	// RVA: 0x30B2CB8
	public void GetComponents(System.Collections.Generic.List<T> results) { }

	// RVA: -1
	public T[] GetComponentsInChildren(bool includeInactive) { }

	// RVA: -1
	public void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: 0x30B1CD4
	public T[] GetComponentsInChildren() { }

	// RVA: 0x30B2CB8
	public void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }

	// RVA: -1
	public void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: -1
	public T[] GetComponentsInParent(bool includeInactive) { }

	// RVA: 0x30B183C
	public bool TryGetComponent(T component) { }

	// RVA: 0x15EB60C
	public bool TryGetComponent(Type type, Component component) { }

	// RVA: 0x15EE054
	internal Component TryGetComponentInternal(Type type) { }

	// RVA: 0x15EE0BC
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x15EE114
	private Component Internal_AddComponentWithType(Type componentType) { }

	// RVA: 0x15EE17C
	public Component AddComponent(Type componentType) { }

	// RVA: 0x316B894
	public T AddComponent() { }

	// RVA: 0x15EE1E4
	public Transform get_transform() { }

	// RVA: 0x15EE234
	public int get_layer() { }

	// RVA: 0x15EE284
	public void set_layer(int value) { }

	// RVA: 0x15EE2EC
	public void SetActive(bool value) { }

	// RVA: 0x15EE354
	public bool get_activeSelf() { }

	// RVA: 0x15EE3A4
	public bool get_activeInHierarchy() { }

	// RVA: 0x15EE3F4
	public bool get_isStatic() { }

	// RVA: 0x15EE444
	public void set_tag(string value) { }

	// RVA: 0x15EE4AC
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x15EE514
	public void .ctor(string name) { }

	// RVA: 0x15EE64C
	public void .ctor() { }

	// RVA: 0x15EE718
	public void .ctor(string name, Type[] components) { }

	// RVA: 0x15EE5E4
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	// RVA: 0x15EE860
	public static GameObject Find(string name) { }

	// RVA: 0x15EE8B0
	public Scene get_scene() { }

	// RVA: 0x15EE970
	public GameObject get_gameObject() { }

	// RVA: 0x15EE908
	private void get_scene_Injected(Scene ret) { }

}

// Namespace: UnityEngine
public sealed class InspectorOrderAttribute
{
	// Fields
	private InspectorSort <m_inspectorSort>k__BackingField; // 0x14
	private InspectorSortDirection <m_sortDirection>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15EE974
	internal InspectorSort get_m_inspectorSort() { }

	// RVA: 0x15EE97C
	internal InspectorSortDirection get_m_sortDirection() { }

}

// Namespace: UnityEngine
public enum InspectorSort
{
	// Fields
	public int value__; // 0x10
	public const InspectorSort ByName = 0;
	public const InspectorSort ByValue = 1;
}

// Namespace: UnityEngine
public enum InspectorSortDirection
{
	// Fields
	public int value__; // 0x10
	public const InspectorSortDirection Ascending = 0;
	public const InspectorSortDirection Descending = 1;
}

// Namespace: UnityEngine
public struct LayerMask
{
	// Fields
	private int m_Mask; // 0x10

	// Methods

	// RVA: 0x15EE984
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x15EE988
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x15EE98C
	public static int NameToLayer(string layerName) { }

}

// Namespace: UnityEngine
[Serializable]
public struct LazyLoadReference<T0>
{
	// Fields
	private int m_InstanceID; // 0x0
}

// Namespace: UnityEngine
internal static class ManagedStreamHelpers
{
	// Methods

	// RVA: 0x15EE9DC
	internal static void ValidateLoadFromStream(Stream stream) { }

	// RVA: 0x15EEAF8
	internal static void ManagedStreamRead(Byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0x15EEBE8
	internal static void ManagedStreamSeek(Int64 offset, UInt32 origin, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0x15EECC8
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

}

// Namespace: UnityEngine
public class MonoBehaviour
{
	// Fields
	private CancellationTokenSource m_CancellationTokenSource; // 0x18

	// Methods

	// RVA: 0x15EED8C
	public CancellationToken get_destroyCancellationToken() { }

	// RVA: 0x15EF0B0
	private void RaiseCancellation() { }

	// RVA: 0x15EF0C4
	public bool IsInvoking() { }

	// RVA: 0x15EF164
	public void CancelInvoke() { }

	// RVA: 0x15EF204
	public void Invoke(string methodName, float time) { }

	// RVA: 0x15EF2D0
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x15EF414
	public void CancelInvoke(string methodName) { }

	// RVA: 0x15EF4E4
	public bool IsInvoking(string methodName) { }

	// RVA: 0x15EF5B4
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x15EF5BC
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x15EF788
	public Coroutine StartCoroutine(IEnumerator routine) { }

	// RVA: 0x15EF918
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x15EF91C
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x15EFAAC
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x15EFC3C
	public void StopCoroutine(string methodName) { }

	// RVA: 0x15EFCA4
	public void StopAllCoroutines() { }

	// RVA: 0x15EFCF4
	public bool get_useGUILayout() { }

	// RVA: 0x15EFD44
	public void set_useGUILayout(bool value) { }

	// RVA: 0x15EFDAC
	public static void print(object message) { }

	// RVA: 0x15EF1B4
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	// RVA: 0x15EF114
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	// RVA: 0x15EF268
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	// RVA: 0x15EF47C
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	// RVA: 0x15EF54C
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	// RVA: 0x15EF6E0
	private static bool IsObjectMonoBehaviour(object obj) { }

	// RVA: 0x15EF730
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x15EF8B0
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x15EFBD4
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x15EFA44
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x15EFE34
	internal string GetScriptClassName() { }

	// RVA: 0x15EF060
	private void OnCancellationTokenCreated() { }

	// RVA: 0x15EFE84
	public void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NoAllocHelpers
{
	// Methods

	// RVA: 0x30B8450
	public static void ResizeList(System.Collections.Generic.List<T> list, int size) { }

	// RVA: 0x30B8450
	public static void EnsureListElemCount(System.Collections.Generic.List<T> list, int count) { }

	// RVA: 0x15EFE8C
	public static int SafeLength(Array values) { }

	// RVA: 0x30B4880
	public static int SafeLength(System.Collections.Generic.List<T> values) { }

	// RVA: 0x30B57C8
	public static T[] ExtractArrayFromListT(System.Collections.Generic.List<T> list) { }

	// RVA: 0x15EFE9C
	internal static void Internal_ResizeList(object list, int size) { }

	// RVA: 0x15EFF04
	public static Array ExtractArrayFromList(object list) { }

}

// Namespace: UnityEngine
public struct RangeInt
{
	// Fields
	public int start; // 0x10
	public int length; // 0x14

	// Methods

	// RVA: 0x15EFF54
	public int get_end() { }

	// RVA: 0x15EFF60
	public void .ctor(int start, int length) { }

}

// Namespace: UnityEngine
public enum RuntimeInitializeLoadType
{
	// Fields
	public int value__; // 0x10
	public const RuntimeInitializeLoadType AfterSceneLoad = 0;
	public const RuntimeInitializeLoadType BeforeSceneLoad = 1;
	public const RuntimeInitializeLoadType AfterAssembliesLoaded = 2;
	public const RuntimeInitializeLoadType BeforeSplashScreen = 3;
	public const RuntimeInitializeLoadType SubsystemRegistration = 4;
}

// Namespace: UnityEngine
public class RuntimeInitializeOnLoadMethodAttribute
{
	// Fields
	private RuntimeInitializeLoadType m_LoadType; // 0x10

	// Methods

	// RVA: 0x15EFF68
	public void .ctor() { }

	// RVA: 0x15EFFA0
	public void .ctor(RuntimeInitializeLoadType loadType) { }

	// RVA: 0x15EFF98
	private void set_loadType(RuntimeInitializeLoadType value) { }

}

// Namespace: UnityEngine
public class ScriptableObject
{
	// Methods

	// RVA: 0x15EFFCC
	public void .ctor() { }

	// RVA: 0x15F00E8
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: 0x316B894
	public static T CreateInstance() { }

	// RVA: 0x15F0098
	private static void CreateScriptableObject(ScriptableObject self) { }

	// RVA: 0x15F0140
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

// Namespace: UnityEngine
internal class ScriptingRuntime
{
	// Methods

	// RVA: 0x15F01A8
	public static string[] GetAllUserAssemblies() { }

}

// Namespace: 
private struct TestClass
{
	// Fields
	public int value; // 0x10
}

// Namespace: UnityEngine
internal class ScriptingUtility
{
	// Methods

	// RVA: 0x15F01E8
	private static bool IsManagedCodeWorking() { }

}

// Namespace: UnityEngine
public class SelectionBaseAttribute
{
	// Methods

	// RVA: 0x15F01F0
	public void .ctor() { }

}

// Namespace: UnityEngine
public static class StackTraceUtility
{
	// Fields
	private static string projectFolder; // 0x0

	// Methods

	// RVA: 0x15F01F8
	internal static void SetProjectFolder(string folder) { }

	// RVA: 0x15F030C
	public static string ExtractStackTrace() { }

	// RVA: 0x15F0C18
	internal static void ExtractStringFromExceptionInternal(object exceptiono, string message, string stackTrace) { }

	// RVA: 0x15F0498
	internal static string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	// RVA: 0x15F0FA4
	private static void .cctor() { }

}

// Namespace: UnityEngine
[Serializable]
public class UnityException
{
	// Methods

	// RVA: 0x15F101C
	public void .ctor() { }

	// RVA: 0x15EF398
	public void .ctor(string message) { }

	// RVA: 0x15F10A8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: UnityEngine
[Serializable]
public class MissingComponentException
{
	// Methods

	// RVA: 0x15F112C
	public void .ctor() { }

	// RVA: 0x15F11B8
	public void .ctor(string message) { }

	// RVA: 0x15F1234
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: UnityEngine
[Serializable]
public class MissingReferenceException
{
	// Methods

	// RVA: 0x15F12B8
	public void .ctor() { }

	// RVA: 0x15EEFE4
	public void .ctor(string message) { }

	// RVA: 0x15F1344
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
private static class EncodingUtility
{
	// Fields
	internal static readonly System.Collections.Generic.KeyValuePair<System.Byte[],System.Text.Encoding>[] encodingLookup; // 0x0
	internal static readonly Encoding targetEncoding; // 0x8

	// Methods

	// RVA: 0x15F196C
	private static void .cctor() { }

}

// Namespace: UnityEngine
public class TextAsset
{
	// Methods

	// RVA: 0x15F13C8
	public Byte[] get_bytes() { }

	// RVA: 0x15F1418
	public string get_text() { }

	// RVA: 0x15F18C0
	public override string ToString() { }

	// RVA: 0x15F14C4
	internal static string DecodeString(Byte[] bytes) { }

}

// Namespace: UnityEngine
public class TrackedReference
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15F1D38
	protected void .ctor() { }

	// RVA: 0x15F1D40
	public static bool op_Equality(TrackedReference x, TrackedReference y) { }

	// RVA: 0x15F1DAC
	public static bool op_Inequality(TrackedReference x, TrackedReference y) { }

	// RVA: 0x15F1E30
	public override bool Equals(object o) { }

	// RVA: 0x15F1F2C
	public override int GetHashCode() { }

	// RVA: 0x15F1F38
	public static bool op_Implicit(TrackedReference exists) { }

}

// Namespace: UnityEngine
internal sealed class UnhandledExceptionHandler
{
	// Methods

	// RVA: 0x15F1F60
	private static void RegisterUECatcher() { }

	// RVA: 0x15F1FF8
	private static void HandleUnhandledException(object sender, UnhandledExceptionEventArgs args) { }

	// RVA: 0x15F21C0
	private static void PrintException(string title, Exception e) { }

	// RVA: 0x15F226C
	private static void iOSNativeUnhandledExceptionHandler(string managedExceptionType, string managedExceptionMessage, string managedExceptionStack) { }

}

// Namespace: UnityEngine
public enum HideFlags
{
	// Fields
	public int value__; // 0x10
	public const HideFlags None = 0;
	public const HideFlags HideInHierarchy = 1;
	public const HideFlags HideInInspector = 2;
	public const HideFlags DontSaveInEditor = 4;
	public const HideFlags NotEditable = 8;
	public const HideFlags DontSaveInBuild = 16;
	public const HideFlags DontUnloadUnusedAsset = 32;
	public const HideFlags DontSave = 52;
	public const HideFlags HideAndDontSave = 61;
}

// Namespace: UnityEngine
public enum FindObjectsSortMode
{
	// Fields
	public int value__; // 0x10
	public const FindObjectsSortMode None = 0;
	public const FindObjectsSortMode InstanceID = 1;
}

// Namespace: UnityEngine
public enum FindObjectsInactive
{
	// Fields
	public int value__; // 0x10
	public const FindObjectsInactive Exclude = 0;
	public const FindObjectsInactive Include = 1;
}

// Namespace: UnityEngine
public class Object
{
	// Fields
	private IntPtr m_CachedPtr; // 0x10
	internal static int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Methods

	// RVA: 0x15F22C4
	public int GetInstanceID() { }

	// RVA: 0x15F2454
	public override int GetHashCode() { }

	// RVA: 0x15F245C
	public override bool Equals(object other) { }

	// RVA: 0x15F26E4
	public static bool op_Implicit(object exists) { }

	// RVA: 0x15F260C
	private static bool CompareBaseObjects(object lhs, object rhs) { }

	// RVA: 0x15F27B0
	private static bool IsNativeObjectAlive(object o) { }

	// RVA: 0x15F27D4
	private IntPtr GetCachedPtr() { }

	// RVA: 0x15F27DC
	public string get_name() { }

	// RVA: 0x15F28D8
	public void set_name(string value) { }

	// RVA: 0x15F29F8
	public static object Instantiate(object original, Vector3 position, Quaternion rotation) { }

	// RVA: 0x15F2E14
	public static object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x15F3260
	public static object Instantiate(object original) { }

	// RVA: 0x15F3494
	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x316B894
	public static T Instantiate(T original) { }

	// RVA: 0x316B894
	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	// RVA: 0x316B894
	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x316B894
	public static T Instantiate(T original, Transform parent) { }

	// RVA: 0x316B894
	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	// RVA: 0x15F37AC
	public static void Destroy(object obj, float t) { }

	// RVA: 0x15F3814
	public static void Destroy(object obj) { }

	// RVA: 0x15F38C8
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	// RVA: 0x15F3930
	public static void DestroyImmediate(object obj) { }

	// RVA: 0x15F39E4
	public static object[] FindObjectsOfType(Type type) { }

	// RVA: 0x15F3A98
	public static object[] FindObjectsOfType(Type type, bool includeInactive) { }

	// RVA: 0x15F3B00
	public static object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	// RVA: 0x15F3B58
	public static void DontDestroyOnLoad(object target) { }

	// RVA: 0x15F3BA8
	public HideFlags get_hideFlags() { }

	// RVA: 0x15F3BF8
	public void set_hideFlags(HideFlags value) { }

	// RVA: 0x30B5790
	public static T[] FindObjectsOfType() { }

	// RVA: -1
	public static T[] FindObjectsByType(FindObjectsSortMode sortMode) { }

	// RVA: 0x316B894
	public static T FindObjectOfType() { }

	// RVA: 0x316B894
	public static T FindFirstObjectByType() { }

	// RVA: 0x15F2D04
	private static void CheckNullArgument(object arg, string message) { }

	// RVA: 0x15F3C60
	public static object FindObjectOfType(Type type) { }

	// RVA: 0x15F3D38
	public static object FindObjectOfType(Type type, bool includeInactive) { }

	// RVA: 0x15F3E14
	public static object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	// RVA: 0x15F3F00
	public override string ToString() { }

	// RVA: 0x15EEF58
	public static bool op_Equality(object x, object y) { }

	// RVA: 0x15F3FFC
	public static bool op_Inequality(object x, object y) { }

	// RVA: 0x15F2414
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	// RVA: 0x15F3444
	private static object Internal_CloneSingle(object data) { }

	// RVA: 0x15F3754
	private static object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	// RVA: 0x15F2D54
	private static object Internal_InstantiateSingle(object data, Vector3 pos, Quaternion rot) { }

	// RVA: 0x15F3198
	private static object Internal_InstantiateSingleWithParent(object data, Transform parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0x15F3FAC
	private static string ToString(object obj) { }

	// RVA: 0x15F2888
	private static string GetName(object obj) { }

	// RVA: 0x15F2990
	private static void SetName(object obj, string name) { }

	// RVA: 0x15F412C
	internal static object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x15F0090
	public void .ctor() { }

	// RVA: 0x15F417C
	private static void .cctor() { }

	// RVA: 0x15F406C
	private static object Internal_InstantiateSingle_Injected(object data, Vector3 pos, Quaternion rot) { }

	// RVA: 0x15F40C4
	private static object Internal_InstantiateSingleWithParent_Injected(object data, Transform parent, Vector3 pos, Quaternion rot) { }

}

// Namespace: 
private struct WorkRequest
{
	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x10
	private readonly object m_DelagateState; // 0x18
	private readonly ManualResetEvent m_WaitHandle; // 0x20

	// Methods

	// RVA: 0x15F463C
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x15F4AA8
	public void Invoke() { }

}

// Namespace: UnityEngine
internal sealed class UnitySynchronizationContext
{
	// Fields
	private readonly System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Methods

	// RVA: 0x15F41CC
	private void .ctor(int mainThreadID) { }

	// RVA: 0x15F429C
	private void .ctor(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x15F4358
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x15F468C
	public override void OperationStarted() { }

	// RVA: 0x15F4698
	public override void OperationCompleted() { }

	// RVA: 0x15F46A4
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x15F480C
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x15F487C
	public void Exec() { }

	// RVA: 0x15F4B8C
	private bool HasPendingTasks() { }

	// RVA: 0x15F4BF8
	private static void InitializeSynchronizationContext() { }

	// RVA: 0x15F4C70
	private static void ExecuteTasks() { }

	// RVA: 0x15F4CD8
	private static bool ExecutePendingTasks(Int64 millisecondsTimeout) { }

}

// Namespace: UnityEngine
public sealed class WaitForEndOfFrame
{
	// Methods

	// RVA: 0x15F4E60
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForFixedUpdate
{
	// Methods

	// RVA: 0x15F4E70
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForSeconds
{
	// Fields
	internal float m_Seconds; // 0x10

	// Methods

	// RVA: 0x15F4E78
	public void .ctor(float seconds) { }

}

// Namespace: UnityEngine
public class WaitForSecondsRealtime
{
	// Fields
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Methods

	// RVA: 0x15F4EAC
	public float get_waitTime() { }

	// RVA: 0x15F4EB4
	public void set_waitTime(float value) { }

	// RVA: 0x15F4EBC
	public override bool get_keepWaiting() { }

	// RVA: 0x15F4FD0
	public void .ctor(float time) { }

	// RVA: 0x15F500C
	public override void Reset() { }

}

// Namespace: UnityEngine
public class YieldInstruction
{
	// Methods

	// RVA: 0x15F4E68
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializeField
{
	// Methods

	// RVA: 0x15F5018
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializeReference
{
	// Methods

	// RVA: 0x15F5020
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class PreferBinarySerialization
{}

// Namespace: UnityEngine
public interface ISerializationCallbackReceiver
{
	// Methods

	// RVA: -1
	public abstract void OnBeforeSerialize() { }

	// RVA: -1
	public abstract void OnAfterDeserialize() { }

}

// Namespace: UnityEngine
public sealed class ComputeShader
{
	// Methods

	// RVA: 0x15F5028
	public int FindKernel(string name) { }

}

// Namespace: UnityEngine
public sealed class ShaderVariantCollection
{
	// Methods

	// RVA: 0x15F5090
	public void WarmUp() { }

}

// Namespace: UnityEngine
internal class LowerResBlitTexture
{
	// Methods

	// RVA: 0x15F50E0
	internal void LowerResBlitTextureDontStripMe() { }

}

// Namespace: UnityEngine
internal class PreloadData
{
	// Methods

	// RVA: 0x15F50E4
	internal void PreloadDataDontStripMe() { }

}

// Namespace: UnityEngine
public enum BatteryStatus
{
	// Fields
	public int value__; // 0x10
	public const BatteryStatus Unknown = 0;
	public const BatteryStatus Charging = 1;
	public const BatteryStatus Discharging = 2;
	public const BatteryStatus NotCharging = 3;
	public const BatteryStatus Full = 4;
}

// Namespace: UnityEngine
public enum OperatingSystemFamily
{
	// Fields
	public int value__; // 0x10
	public const OperatingSystemFamily Other = 0;
	public const OperatingSystemFamily MacOSX = 1;
	public const OperatingSystemFamily Windows = 2;
	public const OperatingSystemFamily Linux = 3;
}

// Namespace: UnityEngine
public enum DeviceType
{
	// Fields
	public int value__; // 0x10
	public const DeviceType Unknown = 0;
	public const DeviceType Handheld = 1;
	public const DeviceType Console = 2;
	public const DeviceType Desktop = 3;
}

// Namespace: UnityEngine
public sealed class SystemInfo
{
	// Methods

	// RVA: 0x15F50E8
	public static float get_batteryLevel() { }

	// RVA: 0x15F5168
	public static BatteryStatus get_batteryStatus() { }

	// RVA: 0x15F51E8
	public static string get_operatingSystem() { }

	// RVA: 0x15F5268
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x15F52E8
	public static string get_processorType() { }

	// RVA: 0x15F5368
	public static int get_processorFrequency() { }

	// RVA: 0x15F53E8
	public static int get_processorCount() { }

	// RVA: 0x15F5468
	public static int get_systemMemorySize() { }

	// RVA: 0x15F54E8
	public static string get_deviceUniqueIdentifier() { }

	// RVA: 0x15F5568
	public static string get_deviceName() { }

	// RVA: 0x15F55E8
	public static string get_deviceModel() { }

	// RVA: 0x15F5668
	public static bool get_supportsAccelerometer() { }

	// RVA: 0x15F56E8
	public static bool get_supportsGyroscope() { }

	// RVA: 0x15F5768
	public static bool get_supportsLocationService() { }

	// RVA: 0x15F57E8
	public static bool get_supportsVibration() { }

	// RVA: 0x15F5868
	public static bool get_supportsAudio() { }

	// RVA: 0x15F58E8
	public static DeviceType get_deviceType() { }

	// RVA: 0x15F5968
	public static int get_graphicsMemorySize() { }

	// RVA: 0x15F59E8
	public static string get_graphicsDeviceName() { }

	// RVA: 0x15F5A68
	public static string get_graphicsDeviceVendor() { }

	// RVA: 0x15F5AE8
	public static int get_graphicsDeviceID() { }

	// RVA: 0x15F5B68
	public static int get_graphicsDeviceVendorID() { }

	// RVA: 0x15F5BE8
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	// RVA: 0x15F5C68
	public static string get_graphicsDeviceVersion() { }

	// RVA: 0x15F5CE8
	public static int get_graphicsShaderLevel() { }

	// RVA: 0x15F5D68
	public static bool get_graphicsMultiThreaded() { }

	// RVA: 0x15F5DE8
	public static bool get_supportsShadows() { }

	// RVA: 0x15F5E68
	public static bool get_supportsRawShadowDepthSampling() { }

	// RVA: 0x15F5EE8
	public static bool get_supports3DTextures() { }

	// RVA: 0x15F5F68
	public static bool get_supports2DArrayTextures() { }

	// RVA: 0x15F5FE8
	public static bool get_supports3DRenderTextures() { }

	// RVA: 0x15F6068
	public static bool get_supportsCubemapArrayTextures() { }

	// RVA: 0x15F60E8
	public static CopyTextureSupport get_copyTextureSupport() { }

	// RVA: 0x15F6168
	public static bool get_supportsComputeShaders() { }

	// RVA: 0x15F61E8
	public static bool get_supportsInstancing() { }

	// RVA: 0x15F6268
	public static bool get_supports32bitsIndexBuffer() { }

	// RVA: 0x15F62E8
	public static bool get_supportsSparseTextures() { }

	// RVA: 0x15F6368
	public static int get_supportedRenderTargetCount() { }

	// RVA: 0x15F63E8
	private static bool IsValidEnumValue(Enum value) { }

	// RVA: 0x15F6468
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x15F65F4
	public static bool SupportsTextureFormat(TextureFormat format) { }

	// RVA: 0x15F6780
	public static NPOTSupport get_npotSupport() { }

	// RVA: 0x15F6800
	public static int get_maxTextureSize() { }

	// RVA: 0x15F6880
	internal static int get_maxRenderTextureSize() { }

	// RVA: 0x15F5128
	private static float GetBatteryLevel() { }

	// RVA: 0x15F51A8
	private static BatteryStatus GetBatteryStatus() { }

	// RVA: 0x15F5228
	private static string GetOperatingSystem() { }

	// RVA: 0x15F52A8
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	// RVA: 0x15F5328
	private static string GetProcessorType() { }

	// RVA: 0x15F53A8
	private static int GetProcessorFrequencyMHz() { }

	// RVA: 0x15F5428
	private static int GetProcessorCount() { }

	// RVA: 0x15F54A8
	private static int GetPhysicalMemoryMB() { }

	// RVA: 0x15F5528
	private static string GetDeviceUniqueIdentifier() { }

	// RVA: 0x15F55A8
	private static string GetDeviceName() { }

	// RVA: 0x15F5628
	private static string GetDeviceModel() { }

	// RVA: 0x15F56A8
	private static bool SupportsAccelerometer() { }

	// RVA: 0x15F5728
	private static bool IsGyroAvailable() { }

	// RVA: 0x15F57A8
	private static bool SupportsLocationService() { }

	// RVA: 0x15F5828
	private static bool SupportsVibration() { }

	// RVA: 0x15F58A8
	private static bool SupportsAudio() { }

	// RVA: 0x15F5928
	private static DeviceType GetDeviceType() { }

	// RVA: 0x15F59A8
	private static int GetGraphicsMemorySize() { }

	// RVA: 0x15F5A28
	private static string GetGraphicsDeviceName() { }

	// RVA: 0x15F5AA8
	private static string GetGraphicsDeviceVendor() { }

	// RVA: 0x15F5B28
	private static int GetGraphicsDeviceID() { }

	// RVA: 0x15F5BA8
	private static int GetGraphicsDeviceVendorID() { }

	// RVA: 0x15F5C28
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	// RVA: 0x15F5CA8
	private static string GetGraphicsDeviceVersion() { }

	// RVA: 0x15F5D28
	private static int GetGraphicsShaderLevel() { }

	// RVA: 0x15F5DA8
	private static bool GetGraphicsMultiThreaded() { }

	// RVA: 0x15F5E28
	private static bool SupportsShadows() { }

	// RVA: 0x15F5EA8
	private static bool SupportsRawShadowDepthSampling() { }

	// RVA: 0x15F5F28
	private static bool Supports3DTextures() { }

	// RVA: 0x15F5FA8
	private static bool Supports2DArrayTextures() { }

	// RVA: 0x15F6028
	private static bool Supports3DRenderTextures() { }

	// RVA: 0x15F60A8
	private static bool SupportsCubemapArrayTextures() { }

	// RVA: 0x15F6128
	private static CopyTextureSupport GetCopyTextureSupport() { }

	// RVA: 0x15F61A8
	private static bool SupportsComputeShaders() { }

	// RVA: 0x15F6228
	private static bool SupportsInstancing() { }

	// RVA: 0x15F62A8
	private static bool Supports32bitsIndexBuffer() { }

	// RVA: 0x15F6328
	private static bool SupportsSparseTextures() { }

	// RVA: 0x15F63A8
	private static int SupportedRenderTargetCount() { }

	// RVA: 0x15F65A4
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	// RVA: 0x15F6730
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	// RVA: 0x15F67C0
	private static NPOTSupport GetNPOTSupport() { }

	// RVA: 0x15F6840
	private static int GetMaxTextureSize() { }

	// RVA: 0x15F68C0
	private static int GetMaxRenderTextureSize() { }

	// RVA: 0x15F6900
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x15F6968
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x15F69D0
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

}

// Namespace: UnityEngine
internal class SystemClock
{
	// Fields
	private static readonly DateTime s_Epoch; // 0x0

	// Methods

	// RVA: 0x15F6A20
	public static DateTime get_now() { }

	// RVA: 0x15F6A90
	private static void .cctor() { }

}

// Namespace: UnityEngine
public class Time
{
	// Methods

	// RVA: 0x15F6B10
	public static float get_time() { }

	// RVA: 0x15F6B50
	public static float get_timeSinceLevelLoad() { }

	// RVA: 0x15F6B90
	public static float get_deltaTime() { }

	// RVA: 0x15F6BD0
	public static float get_unscaledTime() { }

	// RVA: 0x15F6C10
	public static float get_fixedUnscaledTime() { }

	// RVA: 0x15F6C50
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x15F6C90
	public static float get_fixedDeltaTime() { }

	// RVA: 0x15F6CD0
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x15F6D28
	public static float get_timeScale() { }

	// RVA: 0x15F6D68
	public static void set_timeScale(float value) { }

	// RVA: 0x15F6DC0
	public static int get_frameCount() { }

	// RVA: 0x15F6E00
	public static int get_renderedFrameCount() { }

	// RVA: 0x15F4F90
	public static float get_realtimeSinceStartup() { }

}

// Namespace: UnityEngine
internal struct TouchScreenKeyboard_InternalConstructorHelperArguments
{
	// Fields
	public UInt32 keyboardType; // 0x10
	public UInt32 autocorrection; // 0x14
	public UInt32 multiline; // 0x18
	public UInt32 secure; // 0x1C
	public UInt32 alert; // 0x20
	public int characterLimit; // 0x24
}

// Namespace: 
public enum Status
{
	// Fields
	public int value__; // 0x10
	public const Status Visible = 0;
	public const Status Done = 1;
	public const Status Canceled = 2;
	public const Status LostFocus = 3;
}

// Namespace: UnityEngine
public class TouchScreenKeyboard
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static bool <disableInPlaceEditing>k__BackingField; // 0x0

	// Methods

	// RVA: 0x15F6E40
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x15F6E90
	private void Destroy() { }

	// RVA: 0x15F6F5C
	protected override void Finalize() { }

	// RVA: 0x15F707C
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	// RVA: 0x15F71D8
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x15F7230
	public static bool get_isSupported() { }

	// RVA: 0x15F7314
	internal static bool get_disableInPlaceEditing() { }

	// RVA: 0x15F7360
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x15F73AC
	internal static bool get_isRequiredToForceOpen() { }

	// RVA: 0x15F73EC
	private static bool IsRequiredToForceOpen() { }

	// RVA: 0x15F742C
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	// RVA: 0x15F74E8
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	// RVA: 0x15F75BC
	public string get_text() { }

	// RVA: 0x15F760C
	public void set_text(string value) { }

	// RVA: 0x15F7674
	public static void set_hideInput(bool value) { }

	// RVA: 0x15F76C4
	public bool get_active() { }

	// RVA: 0x15F7714
	public void set_active(bool value) { }

	// RVA: 0x15F777C
	public Status get_status() { }

	// RVA: 0x15F77CC
	public void set_characterLimit(int value) { }

	// RVA: 0x15F7834
	public bool get_canGetSelection() { }

	// RVA: 0x15F7884
	public bool get_canSetSelection() { }

	// RVA: 0x15F78D4
	public RangeInt get_selection() { }

	// RVA: 0x15F7994
	public void set_selection(RangeInt value) { }

	// RVA: 0x15F792C
	private static void GetSelection(int start, int length) { }

	// RVA: 0x15F7AA4
	private static void SetSelection(int start, int length) { }

}

// Namespace: UnityEngine
public enum TouchScreenKeyboardType
{
	// Fields
	public int value__; // 0x10
	public const TouchScreenKeyboardType Default = 0;
	public const TouchScreenKeyboardType ASCIICapable = 1;
	public const TouchScreenKeyboardType NumbersAndPunctuation = 2;
	public const TouchScreenKeyboardType URL = 3;
	public const TouchScreenKeyboardType NumberPad = 4;
	public const TouchScreenKeyboardType PhonePad = 5;
	public const TouchScreenKeyboardType NamePhonePad = 6;
	public const TouchScreenKeyboardType EmailAddress = 7;
	public const TouchScreenKeyboardType NintendoNetworkAccount = 8;
	public const TouchScreenKeyboardType Social = 9;
	public const TouchScreenKeyboardType Search = 10;
	public const TouchScreenKeyboardType DecimalPad = 11;
	public const TouchScreenKeyboardType OneTimeCode = 12;
}

// Namespace: UnityEngine
internal static class UINumericFieldsUtils
{
	// Fields
	public static readonly string k_AllowedCharactersForFloat; // 0x0
	public static readonly string k_AllowedCharactersForInt; // 0x8
	public static readonly string k_DoubleFieldFormatString; // 0x10
	public static readonly string k_FloatFieldFormatString; // 0x18
	public static readonly string k_IntFieldFormatString; // 0x20

	// Methods

	// RVA: 0x15F7B0C
	public static bool TryConvertStringToDouble(string str, Double value, Expression expr) { }

	// RVA: 0x15F7CB8
	public static bool TryConvertStringToDouble(string str, string initialValueAsString, Double value) { }

	// RVA: 0x15F7E1C
	public static bool TryConvertStringToFloat(string str, string initialValueAsString, float value) { }

	// RVA: 0x15F7EBC
	public static bool TryConvertStringToLong(string str, Int64 value, Expression expr) { }

	// RVA: 0x15F7F4C
	public static bool TryConvertStringToLong(string str, string initialValueAsString, Int64 value) { }

	// RVA: 0x15F8174
	public static bool TryConvertStringToULong(string str, UInt64 value, Expression expr) { }

	// RVA: 0x15F8204
	public static bool TryConvertStringToULong(string str, string initialValueAsString, UInt64 value) { }

	// RVA: 0x15F842C
	public static bool TryConvertStringToInt(string str, string initialValueAsString, int value) { }

	// RVA: 0x15F84CC
	public static bool TryConvertStringToUInt(string str, string initialValueAsString, UInt32 value) { }

	// RVA: 0x15F856C
	private static void .cctor() { }

}

// Namespace: UnityEngine
public enum DrivenTransformProperties
{
	// Fields
	public int value__; // 0x10
	public const DrivenTransformProperties None = 0;
	public const DrivenTransformProperties All = 4294967295;
	public const DrivenTransformProperties AnchoredPositionX = 2;
	public const DrivenTransformProperties AnchoredPositionY = 4;
	public const DrivenTransformProperties AnchoredPositionZ = 8;
	public const DrivenTransformProperties Rotation = 16;
	public const DrivenTransformProperties ScaleX = 32;
	public const DrivenTransformProperties ScaleY = 64;
	public const DrivenTransformProperties ScaleZ = 128;
	public const DrivenTransformProperties AnchorMinX = 256;
	public const DrivenTransformProperties AnchorMinY = 512;
	public const DrivenTransformProperties AnchorMaxX = 1024;
	public const DrivenTransformProperties AnchorMaxY = 2048;
	public const DrivenTransformProperties SizeDeltaX = 4096;
	public const DrivenTransformProperties SizeDeltaY = 8192;
	public const DrivenTransformProperties PivotX = 16384;
	public const DrivenTransformProperties PivotY = 32768;
	public const DrivenTransformProperties AnchoredPosition = 6;
	public const DrivenTransformProperties AnchoredPosition3D = 14;
	public const DrivenTransformProperties Scale = 224;
	public const DrivenTransformProperties AnchorMin = 768;
	public const DrivenTransformProperties AnchorMax = 3072;
	public const DrivenTransformProperties Anchors = 3840;
	public const DrivenTransformProperties SizeDelta = 12288;
	public const DrivenTransformProperties Pivot = 49152;
}

// Namespace: UnityEngine
public struct DrivenRectTransformTracker
{
	// Methods

	// RVA: 0x15F8694
	public void Add(object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) { }

	// RVA: 0x15F8698
	public void Clear() { }

}

// Namespace: 
public enum Axis
{
	// Fields
	public int value__; // 0x10
	public const Axis Horizontal = 0;
	public const Axis Vertical = 1;
}

// Namespace: 
public sealed class ReapplyDrivenProperties
{
	// Methods

	// RVA: 0x15FA094
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15FA148
	public virtual void Invoke(RectTransform driven) { }

}

// Namespace: UnityEngine
public sealed class RectTransform
{
	// Fields
	private static ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Methods

	// RVA: 0x15F869C
	public static void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0x15F875C
	public static void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0x15F881C
	public Rect get_rect() { }

	// RVA: 0x15F88E0
	public Vector2 get_anchorMin() { }

	// RVA: 0x15F89A0
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x15F8A5C
	public Vector2 get_anchorMax() { }

	// RVA: 0x15F8B1C
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x15F8BD8
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x15F8C98
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x15F8D54
	public Vector2 get_sizeDelta() { }

	// RVA: 0x15F8E14
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x15F8ED0
	public Vector2 get_pivot() { }

	// RVA: 0x15F8F90
	public void set_pivot(Vector2 value) { }

	// RVA: 0x15F904C
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x15F91D0
	public Vector2 get_offsetMin() { }

	// RVA: 0x15F92A4
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x15F94E8
	public Vector2 get_offsetMax() { }

	// RVA: 0x15F95FC
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x15F9840
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x15F996C
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x15F9BB8
	public void SetSizeWithCurrentAnchors(Axis axis, float size) { }

	// RVA: 0x15F9FC8
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x15F9DB8
	private Vector2 GetParentSize() { }

	// RVA: 0x15F8878
	private void get_rect_Injected(Rect ret) { }

	// RVA: 0x15F8938
	private void get_anchorMin_Injected(Vector2 ret) { }

	// RVA: 0x15F89F4
	private void set_anchorMin_Injected(Vector2 value) { }

	// RVA: 0x15F8AB4
	private void get_anchorMax_Injected(Vector2 ret) { }

	// RVA: 0x15F8B70
	private void set_anchorMax_Injected(Vector2 value) { }

	// RVA: 0x15F8C30
	private void get_anchoredPosition_Injected(Vector2 ret) { }

	// RVA: 0x15F8CEC
	private void set_anchoredPosition_Injected(Vector2 value) { }

	// RVA: 0x15F8DAC
	private void get_sizeDelta_Injected(Vector2 ret) { }

	// RVA: 0x15F8E68
	private void set_sizeDelta_Injected(Vector2 value) { }

	// RVA: 0x15F8F28
	private void get_pivot_Injected(Vector2 ret) { }

	// RVA: 0x15F8FE4
	private void set_pivot_Injected(Vector2 value) { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Methods

	// RVA: 0x15FC35C
	internal void .ctor(Transform outer) { }

	// RVA: 0x15FC400
	public object get_Current() { }

	// RVA: 0x15FC470
	public bool MoveNext() { }

	// RVA: 0x15FC4DC
	public void Reset() { }

}

// Namespace: UnityEngine
public class Transform
{
	// Methods

	// RVA: 0x15FA15C
	protected void .ctor() { }

	// RVA: 0x15FA164
	public Vector3 get_position() { }

	// RVA: 0x15FA22C
	public void set_position(Vector3 value) { }

	// RVA: 0x15F9118
	public Vector3 get_localPosition() { }

	// RVA: 0x15F9178
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x15FA3BC
	public Vector3 get_eulerAngles() { }

	// RVA: 0x15FA49C
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x15FA57C
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x15FA64C
	public Vector3 get_right() { }

	// RVA: 0x15FA708
	public Vector3 get_up() { }

	// RVA: 0x15FA7C4
	public Vector3 get_forward() { }

	// RVA: 0x15FA440
	public Quaternion get_rotation() { }

	// RVA: 0x15FA8E8
	public void set_rotation(Quaternion value) { }

	// RVA: 0x15FA520
	public Quaternion get_localRotation() { }

	// RVA: 0x15FA5F4
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x15FAA78
	public Vector3 get_localScale() { }

	// RVA: 0x15FAB40
	public void set_localScale(Vector3 value) { }

	// RVA: 0x15FA044
	public Transform get_parent() { }

	// RVA: 0x15FAC50
	public void set_parent(Transform value) { }

	// RVA: 0x15FAC00
	internal Transform get_parentInternal() { }

	// RVA: 0x15FAD38
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x15FAD8C
	private Transform GetParent() { }

	// RVA: 0x15FADDC
	public void SetParent(Transform p) { }

	// RVA: 0x15FAE30
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x15FAE88
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x15F9B40
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x15FAFD0
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x15FB08C
	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0x15FB148
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x15FB320
	public void Translate(float x, float y, float z) { }

	// RVA: 0x15FB328
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x15FB6B0
	public void Rotate(Vector3 eulers) { }

	// RVA: 0x15FB6B8
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	// RVA: 0x15FB6C0
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x15FB788
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x15FB8AC
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x15FB2B4
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x15FB90C
	public Vector3 TransformDirection(float x, float y, float z) { }

	// RVA: 0x15FB978
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x15FBA3C
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x15FBB00
	public Vector3 TransformVector(float x, float y, float z) { }

	// RVA: 0x15FBB6C
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x15FBC30
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x15FBCF4
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x15FBDB8
	public Transform get_root() { }

	// RVA: 0x15FBE08
	private Transform GetRoot() { }

	// RVA: 0x15FBE58
	public int get_childCount() { }

	// RVA: 0x15FBEA8
	public void SetAsFirstSibling() { }

	// RVA: 0x15FBEF8
	public void SetAsLastSibling() { }

	// RVA: 0x15FBF48
	public void SetSiblingIndex(int index) { }

	// RVA: 0x15FBFB0
	public int GetSiblingIndex() { }

	// RVA: 0x15FC000
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x15FC058
	public Transform Find(string n) { }

	// RVA: 0x15FC0F8
	public Vector3 get_lossyScale() { }

	// RVA: 0x15FC1C0
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x15FC228
	public bool get_hasChanged() { }

	// RVA: 0x15FC278
	public void set_hasChanged(bool value) { }

	// RVA: 0x15FC2E0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x15FC398
	public Transform GetChild(int index) { }

	// RVA: 0x15FA1C4
	private void get_position_Injected(Vector3 ret) { }

	// RVA: 0x15FA284
	private void set_position_Injected(Vector3 value) { }

	// RVA: 0x15FA2EC
	private void get_localPosition_Injected(Vector3 ret) { }

	// RVA: 0x15FA354
	private void set_localPosition_Injected(Vector3 value) { }

	// RVA: 0x15FA880
	private void get_rotation_Injected(Quaternion ret) { }

	// RVA: 0x15FA940
	private void set_rotation_Injected(Quaternion value) { }

	// RVA: 0x15FA9A8
	private void get_localRotation_Injected(Quaternion ret) { }

	// RVA: 0x15FAA10
	private void set_localRotation_Injected(Quaternion value) { }

	// RVA: 0x15FAAD8
	private void get_localScale_Injected(Vector3 ret) { }

	// RVA: 0x15FAB98
	private void set_localScale_Injected(Vector3 value) { }

	// RVA: 0x15FAF00
	private void get_worldToLocalMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15FAF68
	private void get_localToWorldMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15FB034
	private void SetPositionAndRotation_Injected(Vector3 position, Quaternion rotation) { }

	// RVA: 0x15FB0F0
	private void SetLocalPositionAndRotation_Injected(Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0x15FB728
	private void RotateAroundInternal_Injected(Vector3 axis, float angle) { }

	// RVA: 0x15FB8B4
	private void TransformDirection_Injected(Vector3 direction, Vector3 ret) { }

	// RVA: 0x15FB9E4
	private void InverseTransformDirection_Injected(Vector3 direction, Vector3 ret) { }

	// RVA: 0x15FBAA8
	private void TransformVector_Injected(Vector3 vector, Vector3 ret) { }

	// RVA: 0x15FBBD8
	private void InverseTransformVector_Injected(Vector3 vector, Vector3 ret) { }

	// RVA: 0x15FBC9C
	private void TransformPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x15FBD60
	private void InverseTransformPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x15FC158
	private void get_lossyScale_Injected(Vector3 ret) { }

}

// Namespace: UnityEngine
public enum SpriteMaskInteraction
{
	// Fields
	public int value__; // 0x10
	public const SpriteMaskInteraction None = 0;
	public const SpriteMaskInteraction VisibleInsideMask = 1;
	public const SpriteMaskInteraction VisibleOutsideMask = 2;
}

// Namespace: UnityEngine
public sealed class SpriteRenderer
{
	// Fields
	private UnityEngine.Events.UnityEvent<UnityEngine.SpriteRenderer> m_SpriteChangeEvent; // 0x18

	// Methods

	// RVA: 0x15FC4E8
	private void InvokeSpriteChanged() { }

	// RVA: 0x15FC5E4
	public void set_sprite(Sprite value) { }

	// RVA: 0x15FC64C
	public void set_color(Color value) { }

	// RVA: 0x15FC6A4
	private void set_color_Injected(Color value) { }

}

// Namespace: UnityEngine
public enum SpriteMeshType
{
	// Fields
	public int value__; // 0x10
	public const SpriteMeshType FullRect = 0;
	public const SpriteMeshType Tight = 1;
}

// Namespace: UnityEngine
public enum SpritePackingRotation
{
	// Fields
	public int value__; // 0x10
	public const SpritePackingRotation None = 0;
	public const SpritePackingRotation FlipHorizontal = 1;
	public const SpritePackingRotation FlipVertical = 2;
	public const SpritePackingRotation Rotate180 = 3;
	public const SpritePackingRotation Any = 15;
}

// Namespace: UnityEngine
[Serializable]
public struct SecondarySpriteTexture
{
	// Fields
	public string name; // 0x10
	public Texture2D texture; // 0x18
}

// Namespace: UnityEngine
public sealed class Sprite
{
	// Methods

	// RVA: 0x15FC70C
	private void .ctor() { }

	// RVA: 0x15FC794
	internal int GetPackingRotation() { }

	// RVA: 0x15FC7E4
	internal int GetPacked() { }

	// RVA: 0x15FC834
	internal Rect GetTextureRect() { }

	// RVA: 0x15FC8F8
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x15FC9BC
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x15FCA80
	internal Vector4 GetPadding() { }

	// RVA: 0x15FCB44
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x15FCC98
	public Bounds get_bounds() { }

	// RVA: 0x15FCD74
	public Rect get_rect() { }

	// RVA: 0x15FCE38
	public Vector4 get_border() { }

	// RVA: 0x15FCEFC
	public Texture2D get_texture() { }

	// RVA: 0x15FCF4C
	public float get_pixelsPerUnit() { }

	// RVA: 0x15FCF9C
	public Texture2D get_associatedAlphaSplitTexture() { }

	// RVA: 0x15FCFEC
	public Vector2 get_pivot() { }

	// RVA: 0x15FD0AC
	public bool get_packed() { }

	// RVA: 0x15FD0F8
	public SpritePackingRotation get_packingRotation() { }

	// RVA: 0x15FD148
	public Rect get_textureRect() { }

	// RVA: 0x15FD1A4
	public Vector2[] get_vertices() { }

	// RVA: 0x15FD1F4
	public UInt16[] get_triangles() { }

	// RVA: 0x15FD244
	public Vector2[] get_uv() { }

	// RVA: 0x15FD294
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x15FD2A4
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	// RVA: 0x15FD7EC
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x15FD800
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType) { }

	// RVA: 0x15FD8EC
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude) { }

	// RVA: 0x15FD9D4
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x15FDAB0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x15FC890
	private void GetTextureRect_Injected(Rect ret) { }

	// RVA: 0x15FC954
	private void GetInnerUVs_Injected(Vector4 ret) { }

	// RVA: 0x15FCA18
	private void GetOuterUVs_Injected(Vector4 ret) { }

	// RVA: 0x15FCADC
	private void GetPadding_Injected(Vector4 ret) { }

	// RVA: 0x15FCBF0
	private static Sprite CreateSprite_Injected(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x15FCD0C
	private void get_bounds_Injected(Bounds ret) { }

	// RVA: 0x15FCDD0
	private void get_rect_Injected(Rect ret) { }

	// RVA: 0x15FCE94
	private void get_border_Injected(Vector4 ret) { }

	// RVA: 0x15FD044
	private void get_pivot_Injected(Vector2 ret) { }

}

// Namespace: UnityEngine._Scripting.APIUpdating
internal class APIUpdaterRuntimeHelpers
{
	// Methods

	// RVA: 0x15FDB84
	internal static bool GetMovedFromAttributeDataForType(Type sourceType, string assembly, string nsp, string klass) { }

	// RVA: 0x15FDD0C
	internal static bool GetObsoleteTypeRedirection(Type sourceType, string assemblyName, string nsp, string className) { }

}

// Namespace: UnityEngine.Sprites
public sealed class DataUtility
{
	// Methods

	// RVA: 0x15FE080
	public static Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0x15FE0E4
	public static Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0x15FE148
	public static Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0x15FE1AC
	public static Vector2 GetMinSize(Sprite sprite) { }

}

// Namespace: UnityEngine.U2D
[Serializable]
public struct SpriteBone
{
	// Fields
	private string m_Name; // 0x10
	private string m_Guid; // 0x18
	private Vector3 m_Position; // 0x20
	private Quaternion m_Rotation; // 0x2C
	private float m_Length; // 0x3C
	private int m_ParentId; // 0x40
	private Color32 m_Color; // 0x44
}

// Namespace: UnityEngine.U2D
public class SpriteAtlasManager
{
	// Fields
	private static System.Action<System.String,System.Action<UnityEngine.U2D.SpriteAtlas>> atlasRequested; // 0x0
	private static System.Action<UnityEngine.U2D.SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	// RVA: 0x15FE2B8
	private static bool RequestAtlas(string tag) { }

	// RVA: 0x15FE378
	public static void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }

	// RVA: 0x15FE44C
	public static void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }

	// RVA: 0x15FE520
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x15FE59C
	internal static void Register(SpriteAtlas spriteAtlas) { }

}

// Namespace: UnityEngine.U2D
public class SpriteAtlas
{
	// Methods

	// RVA: 0x15FE5EC
	public bool CanBindTo(Sprite sprite) { }

}

// Namespace: UnityEngine.Profiling
public sealed class Profiler
{
	// Methods

	// RVA: 0x15FE654
	public static void BeginSample(string name) { }

	// RVA: 0x15FE77C
	private static void ValidateArguments(string name) { }

	// RVA: 0x15FE714
	private static void BeginSampleImpl(string name, object targetObject) { }

	// RVA: 0x15FE7FC
	public static void EndSample() { }

	// RVA: 0x15FE83C
	public static Int64 GetRuntimeMemorySizeLong(object o) { }

	// RVA: 0x15FE88C
	public static Int64 GetMonoHeapSizeLong() { }

	// RVA: 0x15FE8CC
	public static Int64 GetMonoUsedSizeLong() { }

	// RVA: 0x15FE90C
	public static Int64 GetTotalAllocatedMemoryLong() { }

	// RVA: 0x15FE94C
	public static Int64 GetTotalUnusedReservedMemoryLong() { }

	// RVA: 0x15FE98C
	public static Int64 GetTotalReservedMemoryLong() { }

}

// Namespace: UnityEngine.Events
[Serializable]
public enum PersistentListenerMode
{
	// Fields
	public int value__; // 0x10
	public const PersistentListenerMode EventDefined = 0;
	public const PersistentListenerMode Void = 1;
	public const PersistentListenerMode Object = 2;
	public const PersistentListenerMode Int = 3;
	public const PersistentListenerMode Float = 4;
	public const PersistentListenerMode String = 5;
	public const PersistentListenerMode Bool = 6;
}

// Namespace: UnityEngine.Events
internal class UnityEventTools
{
	// Methods

	// RVA: 0x15FE9CC
	internal static string TidyAssemblyTypeName(string assemblyTypeName) { }

}

// Namespace: UnityEngine.Events
[Serializable]
internal class ArgumentCache
{
	// Fields
	private object m_ObjectArgument; // 0x10
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	private int m_IntArgument; // 0x20
	private float m_FloatArgument; // 0x24
	private string m_StringArgument; // 0x28
	private bool m_BoolArgument; // 0x30

	// Methods

	// RVA: 0x15FEC08
	public object get_unityObjectArgument() { }

	// RVA: 0x15FEC10
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x15FEC18
	public int get_intArgument() { }

	// RVA: 0x15FEC20
	public float get_floatArgument() { }

	// RVA: 0x15FEC28
	public string get_stringArgument() { }

	// RVA: 0x15FEC30
	public bool get_boolArgument() { }

	// RVA: 0x15FEC38
	public void OnBeforeSerialize() { }

	// RVA: 0x15FEC68
	public void OnAfterDeserialize() { }

	// RVA: 0x15FEC98
	public void .ctor() { }

}

// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall
{
	// Methods

	// RVA: 0x15FECA0
	protected void .ctor() { }

	// RVA: 0x15FECA8
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1
	public abstract void Invoke(object[] args) { }

	// RVA: 0x30B8148
	protected static void ThrowOnInvalidArg(object arg) { }

	// RVA: 0x15FEDB4
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1
	public abstract bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall
{
	// Fields
	private UnityAction Delegate; // 0x10

	// Methods

	// RVA: 0x15FEEFC
	private void add_Delegate(UnityAction value) { }

	// RVA: 0x15FEFA0
	private void remove_Delegate(UnityAction value) { }

	// RVA: 0x15FF044
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x15FF19C
	public void .ctor(UnityAction action) { }

	// RVA: 0x15FF248
	public override void Invoke(object[] args) { }

	// RVA: 0x15FF294
	public void Invoke() { }

	// RVA: 0x15FF2E0
	public override bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0>
{
	// Fields
	private UnityEngine.Events.UnityAction<T1> Delegate; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	protected void add_Delegate(UnityEngine.Events.UnityAction<T1> value) { }

	// RVA: 0x30B2CB8
	protected void remove_Delegate(UnityEngine.Events.UnityAction<T1> value) { }

	// RVA: 0x30B2F18
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x30B2CB8
	public void .ctor(UnityEngine.Events.UnityAction<T1> action) { }

	// RVA: 0x30B2CB8
	public override void Invoke(object[] args) { }

	// RVA: 0x316B894
	public virtual void Invoke(T1 args0) { }

	// RVA: -1
	public override bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0, T1>
{
	// Fields
	private UnityEngine.Events.UnityAction<T1,T2> Delegate; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x30B2CB8
	public override void Invoke(object[] args) { }

	// RVA: 0x316B894
	public void Invoke(T1 args0, T2 args1) { }

	// RVA: -1
	public override bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0, T1, T2>
{
	// Fields
	private UnityEngine.Events.UnityAction<T1,T2,T3> Delegate; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x30B2CB8
	public override void Invoke(object[] args) { }

	// RVA: -1
	public override bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0, T1, T2, T3>
{
	// Fields
	private UnityEngine.Events.UnityAction<T1,T2,T3,T4> Delegate; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x30B2CB8
	public override void Invoke(object[] args) { }

	// RVA: -1
	public override bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class CachedInvokableCall<T0>
{
	// Fields
	private readonly T m_Arg1; // 0x0

	// Methods

	// RVA: 0x316B894
	public void .ctor(object target, MethodInfo theFunction, T argument) { }

	// RVA: 0x30B2CB8
	public override void Invoke(object[] args) { }

	// RVA: 0x316B894
	public override void Invoke(T arg0) { }

}

// Namespace: UnityEngine.Events
public enum UnityEventCallState
{
	// Fields
	public int value__; // 0x10
	public const UnityEventCallState Off = 0;
	public const UnityEventCallState EditorAndRuntime = 1;
	public const UnityEventCallState RuntimeOnly = 2;
}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCall
{
	// Fields
	private object m_Target; // 0x10
	private string m_TargetAssemblyTypeName; // 0x18
	private string m_MethodName; // 0x20
	private PersistentListenerMode m_Mode; // 0x28
	private ArgumentCache m_Arguments; // 0x30
	private UnityEventCallState m_CallState; // 0x38

	// Methods

	// RVA: 0x15FF33C
	public object get_target() { }

	// RVA: 0x15FF344
	public string get_targetAssemblyTypeName() { }

	// RVA: 0x15FF4B8
	public string get_methodName() { }

	// RVA: 0x15FF4C0
	public PersistentListenerMode get_mode() { }

	// RVA: 0x15FF4C8
	public ArgumentCache get_arguments() { }

	// RVA: 0x15FF4D0
	public bool IsValid() { }

	// RVA: 0x15FF51C
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x15FFB64
	private static BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x16000D4
	public void OnBeforeSerialize() { }

	// RVA: 0x1600104
	public void OnAfterDeserialize() { }

	// RVA: 0x1600134
	public void .ctor() { }

}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCallGroup
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls; // 0x10

	// Methods

	// RVA: 0x16001B8
	public void .ctor() { }

	// RVA: 0x1600244
	public int get_Count() { }

	// RVA: 0x1600290
	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCallList
{
	// Fields
	private readonly System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_RuntimeCalls; // 0x18
	private System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x1600504
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x1600574
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x16005E4
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x1600898
	public void Clear() { }

	// RVA: 0x1600994
	public void ClearPersistent() { }

	// RVA: 0x1600A90
	public System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x1600B78
	public void .ctor() { }

}

// Namespace: UnityEngine.Events
[Serializable]
public abstract class UnityEventBase
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x1600C54
	protected void .ctor() { }

	// RVA: 0x1600D70
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1600DD8
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: -1
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x15FF8AC
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x1600E0C
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x160132C
	public int GetPersistentEventCount() { }

	// RVA: 0x1600DA4
	private void DirtyPersistentCalls() { }

	// RVA: 0x160137C
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x16013BC
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x1601430
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x160144C
	public void RemoveAllListeners() { }

	// RVA: 0x1601468
	internal System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x16014B0
	public override string ToString() { }

	// RVA: 0x1601140
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction
{
	// Methods

	// RVA: 0x1601538
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16015D8
	public virtual void Invoke() { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	// RVA: 0x16015EC
	public void .ctor() { }

	// RVA: 0x1601618
	public void AddListener(UnityAction call) { }

	// RVA: 0x1601784
	public void RemoveListener(UnityAction call) { }

	// RVA: 0x16017C8
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x1601830
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x1601698
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x160189C
	public void Invoke() { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T0 arg0) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2CB8
	public void AddListener(UnityEngine.Events.UnityAction<T0> call) { }

	// RVA: 0x30B2CB8
	public void RemoveListener(UnityEngine.Events.UnityAction<T0> call) { }

	// RVA: 0x30B1E68
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x30B1E68
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x30B57C8
	private static BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action) { }

	// RVA: 0x316B894
	public void Invoke(T0 arg0) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T0 arg0, T1 arg1) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1E68
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x30B1E68
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x316B894
	public void Invoke(T0 arg0, T1 arg1) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1E68
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x30B1E68
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2, T3>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B1E68
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x30B1E68
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

// Namespace: UnityEngine.Serialization
public class FormerlySerializedAsAttribute
{
	// Fields
	private string m_oldName; // 0x10

	// Methods

	// RVA: 0x1601AA4
	public void .ctor(string oldName) { }

}

// Namespace: UnityEngine.Scripting
public class AlwaysLinkAssemblyAttribute
{
	// Methods

	// RVA: 0x1601AD8
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
public static class GarbageCollector
{
	// Methods

	// RVA: 0x1601AE0
	public static bool get_isIncremental() { }

	// RVA: 0x1601B20
	public static UInt64 get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x1601B60
	public static bool CollectIncremental(UInt64 nanoseconds) { }

}

// Namespace: UnityEngine.Scripting
public class PreserveAttribute
{
	// Methods

	// RVA: 0x15EFF90
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
public class RequireImplementorsAttribute
{
	// Methods

	// RVA: 0x1601BB0
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting.APIUpdating
internal struct MovedFromAttributeData
{
	// Fields
	public string className; // 0x10
	public string nameSpace; // 0x18
	public string assembly; // 0x20
	public bool classHasChanged; // 0x28
	public bool nameSpaceHasChanged; // 0x29
	public bool assemblyHasChanged; // 0x2A
	public bool autoUdpateAPI; // 0x2B

	// Methods

	// RVA: 0x1601BB8
	public void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

}

// Namespace: UnityEngine.Scripting.APIUpdating
public class MovedFromAttribute
{
	// Fields
	internal MovedFromAttributeData data; // 0x10

	// Methods

	// RVA: 0x1601C54
	public void .ctor(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

	// RVA: 0x1601D04
	public void .ctor(string sourceNamespace) { }

}

// Namespace: UnityEngine.SceneManagement
[Serializable]
public struct Scene
{
	// Fields
	private int m_Handle; // 0x10

	// Methods

	// RVA: 0x1601DA4
	private static bool IsValidInternal(int sceneHandle) { }

	// RVA: 0x1601DF4
	private static string GetPathInternal(int sceneHandle) { }

	// RVA: 0x1601E44
	private static string GetNameInternal(int sceneHandle) { }

	// RVA: 0x1601E94
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	// RVA: 0x1601EE4
	private static int GetBuildIndexInternal(int sceneHandle) { }

	// RVA: 0x1601F34
	private static int GetRootCountInternal(int sceneHandle) { }

	// RVA: 0x1601F84
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x1601FEC
	public int get_handle() { }

	// RVA: 0x1601FF4
	public bool IsValid() { }

	// RVA: 0x1602044
	public string get_path() { }

	// RVA: 0x1602094
	public string get_name() { }

	// RVA: 0x16020E4
	public bool get_isLoaded() { }

	// RVA: 0x1602134
	public int get_buildIndex() { }

	// RVA: 0x1602184
	public int get_rootCount() { }

	// RVA: 0x16021D4
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x16022B4
	public void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects) { }

	// RVA: 0x16025B8
	public static bool op_Equality(Scene lhs, Scene rhs) { }

	// RVA: 0x16025C4
	public override int GetHashCode() { }

	// RVA: 0x16025CC
	public override bool Equals(object other) { }

}

// Namespace: UnityEngine.SceneManagement
internal static class SceneManagerAPIInternal
{
	// Methods

	// RVA: 0x160265C
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x1602730
	public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

	// RVA: 0x16026C8
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

}

// Namespace: UnityEngine.SceneManagement
public class SceneManagerAPI
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Methods

	// RVA: 0x16027A0
	internal static SceneManagerAPI get_ActiveAPI() { }

	// RVA: 0x16028A0
	public static SceneManagerAPI get_overrideAPI() { }

	// RVA: 0x160291C
	protected internal void .ctor() { }

	// RVA: 0x1602924
	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x1602990
	protected internal virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

	// RVA: 0x1602A00
	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x1602A08
	private static void .cctor() { }

}

// Namespace: UnityEngine.SceneManagement
public class SceneManager
{
	// Fields
	internal static bool s_AllowLoadScene; // 0x0
	private static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> sceneLoaded; // 0x8
	private static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> sceneUnloaded; // 0x10
	private static UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> activeSceneChanged; // 0x18

	// Methods

	// RVA: 0x1602A74
	public static int get_sceneCount() { }

	// RVA: 0x1602AB4
	public static Scene GetActiveScene() { }

	// RVA: 0x1602BAC
	public static bool SetActiveScene(Scene scene) { }

	// RVA: 0x1602CB0
	public static Scene GetSceneByName(string name) { }

	// RVA: 0x1602DD0
	public static Scene GetSceneAt(int index) { }

	// RVA: 0x1602EF0
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x1602FE8
	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

	// RVA: 0x16030F8
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	// RVA: 0x1603180
	public static void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }

	// RVA: 0x1603294
	public static void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }

	// RVA: 0x16033A8
	public static void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x16034BC
	public static void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x16035D0
	public static void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x16036E4
	public static void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x16037F8
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x16038C8
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x1603938
	public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options) { }

	// RVA: 0x16039BC
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x1603A9C
	private static void Internal_SceneUnloaded(Scene scene) { }

	// RVA: 0x1603B74
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x1603C54
	private static void .cctor() { }

	// RVA: 0x1602B5C
	private static void GetActiveScene_Injected(Scene ret) { }

	// RVA: 0x1602C60
	private static bool SetActiveScene_Injected(Scene scene) { }

	// RVA: 0x1602D68
	private static void GetSceneByName_Injected(string name, Scene ret) { }

	// RVA: 0x1602E88
	private static void GetSceneAt_Injected(int index, Scene ret) { }

}

// Namespace: UnityEngine.SceneManagement
public enum LoadSceneMode
{
	// Fields
	public int value__; // 0x10
	public const LoadSceneMode Single = 0;
	public const LoadSceneMode Additive = 1;
}

// Namespace: UnityEngine.SceneManagement
public enum LocalPhysicsMode
{
	// Fields
	public int value__; // 0x10
	public const LocalPhysicsMode None = 0;
	public const LocalPhysicsMode Physics2D = 1;
	public const LocalPhysicsMode Physics3D = 2;
}

// Namespace: UnityEngine.SceneManagement
[Serializable]
public struct LoadSceneParameters
{
	// Fields
	private LoadSceneMode m_LoadSceneMode; // 0x10
	private LocalPhysicsMode m_LocalPhysicsMode; // 0x14

	// Methods

	// RVA: 0x16038C0
	public void .ctor(LoadSceneMode mode) { }

}

// Namespace: UnityEngine.SceneManagement
public enum UnloadSceneOptions
{
	// Fields
	public int value__; // 0x10
	public const UnloadSceneOptions None = 0;
	public const UnloadSceneOptions UnloadAllEmbeddedSceneObjects = 1;
}

// Namespace: UnityEngine.LowLevel
internal struct PlayerLoopSystemInternal
{
	// Fields
	public Type type; // 0x10
	public UpdateFunction updateDelegate; // 0x18
	public IntPtr updateFunction; // 0x20
	public IntPtr loopConditionFunction; // 0x28
	public int numSubSystems; // 0x30
}

// Namespace: 
public sealed class UpdateFunction
{
	// Methods

	// RVA: 0x1603CC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1603D68
	public virtual void Invoke() { }

}

// Namespace: UnityEngine.LowLevel
public struct PlayerLoopSystem
{
	// Fields
	public Type type; // 0x10
	public PlayerLoopSystem[] subSystemList; // 0x18
	public UpdateFunction updateDelegate; // 0x20
	public IntPtr updateFunction; // 0x28
	public IntPtr loopConditionFunction; // 0x30

	// Methods

	// RVA: 0x1603CA4
	public override string ToString() { }

}

// Namespace: UnityEngine.LowLevel
public class PlayerLoop
{
	// Methods

	// RVA: 0x1603D7C
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	// RVA: 0x16040A0
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	// RVA: 0x16041A0
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal>& internalSys) { }

	// RVA: 0x1603E2C
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, int offset) { }

	// RVA: 0x1603DEC
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	// RVA: 0x160432C
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }

}

// Namespace: 
public struct WaitForLastPresentationAndUpdateTime
{}

// Namespace: UnityEngine.PlayerLoop
public struct TimeUpdate
{}

// Namespace: 
public struct ProfilerStartFrame
{}

// Namespace: 
public struct UpdateCameraMotionVectors
{}

// Namespace: 
public struct DirectorSampleTime
{}

// Namespace: 
public struct AsyncUploadTimeSlicedUpdate
{}

// Namespace: 
public struct SynchronizeState
{}

// Namespace: 
public struct SynchronizeInputs
{}

// Namespace: 
public struct XREarlyUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct Initialization
{}

// Namespace: 
public struct PollPlayerConnection
{}

// Namespace: 
public struct PollHtcsPlayerConnection
{}

// Namespace: 
public struct GpuTimestamp
{}

// Namespace: 
public struct AnalyticsCoreStatsUpdate
{}

// Namespace: 
public struct UnityWebRequestUpdate
{}

// Namespace: 
public struct UpdateStreamingManager
{}

// Namespace: 
public struct ExecuteMainThreadJobs
{}

// Namespace: 
public struct ProcessMouseInWindow
{}

// Namespace: 
public struct ClearIntermediateRenderers
{}

// Namespace: 
public struct ClearLines
{}

// Namespace: 
public struct PresentBeforeUpdate
{}

// Namespace: 
public struct ResetFrameStatsAfterPresent
{}

// Namespace: 
public struct UpdateAsyncReadbackManager
{}

// Namespace: 
public struct UpdateTextureStreamingManager
{}

// Namespace: 
public struct UpdatePreloading
{}

// Namespace: 
public struct UpdateContentLoading
{}

// Namespace: 
public struct UpdateAsyncInstantiate
{}

// Namespace: 
public struct RendererNotifyInvisible
{}

// Namespace: 
public struct PlayerCleanupCachedData
{}

// Namespace: 
public struct UpdateMainGameViewRect
{}

// Namespace: 
public struct UpdateCanvasRectTransform
{}

// Namespace: 
public struct UpdateInputManager
{}

// Namespace: 
public struct ProcessRemoteInput
{}

// Namespace: 
public struct XRUpdate
{}

// Namespace: 
public struct ScriptRunDelayedStartupFrame
{}

// Namespace: 
public struct UpdateKinect
{}

// Namespace: 
public struct DeliverIosPlatformEvents
{}

// Namespace: 
public struct DispatchEventQueueEvents
{}

// Namespace: 
public struct Physics2DEarlyUpdate
{}

// Namespace: 
public struct PhysicsResetInterpolatedTransformPosition
{}

// Namespace: 
public struct SpriteAtlasManagerUpdate
{}

// Namespace: 
public struct TangoUpdate
{}

// Namespace: 
public struct ARCoreUpdate
{}

// Namespace: 
public struct PerformanceAnalyticsUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct EarlyUpdate
{}

// Namespace: 
public struct ClearLines
{}

// Namespace: 
public struct DirectorFixedSampleTime
{}

// Namespace: 
public struct AudioFixedUpdate
{}

// Namespace: 
public struct ScriptRunBehaviourFixedUpdate
{}

// Namespace: 
public struct DirectorFixedUpdate
{}

// Namespace: 
public struct LegacyFixedAnimationUpdate
{}

// Namespace: 
public struct XRFixedUpdate
{}

// Namespace: 
public struct PhysicsFixedUpdate
{}

// Namespace: 
public struct Physics2DFixedUpdate
{}

// Namespace: 
private struct PhysicsClothFixedUpdate
{}

// Namespace: 
public struct DirectorFixedUpdatePostPhysics
{}

// Namespace: 
public struct ScriptRunDelayedFixedFrameRate
{}

// Namespace: 
public struct NewInputFixedUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct FixedUpdate
{}

// Namespace: 
public struct PhysicsUpdate
{}

// Namespace: 
public struct Physics2DUpdate
{}

// Namespace: 
internal struct PhysicsClothUpdate
{}

// Namespace: 
public struct CheckTexFieldInput
{}

// Namespace: 
public struct IMGUISendQueuedEvents
{}

// Namespace: 
public struct SendMouseEvents
{}

// Namespace: 
public struct AIUpdate
{}

// Namespace: 
public struct WindUpdate
{}

// Namespace: 
public struct UpdateVideo
{}

// Namespace: 
public struct NewInputUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct PreUpdate
{}

// Namespace: 
public struct ScriptRunBehaviourUpdate
{}

// Namespace: 
public struct DirectorUpdate
{}

// Namespace: 
public struct ScriptRunDelayedDynamicFrameRate
{}

// Namespace: 
public struct ScriptRunDelayedTasks
{}

// Namespace: UnityEngine.PlayerLoop
public struct Update
{}

// Namespace: 
public struct Physics2DLateUpdate
{}

// Namespace: 
public struct PhysicsLateUpdate
{}

// Namespace: 
public struct AIUpdatePostScript
{}

// Namespace: 
public struct DirectorUpdateAnimationBegin
{}

// Namespace: 
public struct LegacyAnimationUpdate
{}

// Namespace: 
public struct DirectorUpdateAnimationEnd
{}

// Namespace: 
public struct DirectorDeferredEvaluate
{}

// Namespace: 
public struct UIElementsUpdatePanels
{}

// Namespace: 
public struct UpdateNetworkManager
{}

// Namespace: 
public struct UpdateMasterServerInterface
{}

// Namespace: 
public struct EndGraphicsJobsAfterScriptUpdate
{}

// Namespace: 
public struct ParticleSystemBeginUpdateAll
{}

// Namespace: 
public struct ScriptRunBehaviourLateUpdate
{}

// Namespace: 
public struct ConstraintManagerUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct PreLateUpdate
{}

// Namespace: 
public struct PlayerSendFrameStarted
{}

// Namespace: 
public struct UpdateRectTransform
{}

// Namespace: 
public struct UpdateCanvasRectTransform
{}

// Namespace: 
public struct PlayerUpdateCanvases
{}

// Namespace: 
public struct UpdateAudio
{}

// Namespace: 
public struct UpdateVideo
{}

// Namespace: 
public struct DirectorLateUpdate
{}

// Namespace: 
public struct ScriptRunDelayedDynamicFrameRate
{}

// Namespace: 
public struct VFXUpdate
{}

// Namespace: 
public struct ParticleSystemEndUpdateAll
{}

// Namespace: 
public struct EndGraphicsJobsAfterScriptLateUpdate
{}

// Namespace: 
public struct UpdateSubstance
{}

// Namespace: 
public struct UpdateCustomRenderTextures
{}

// Namespace: 
public struct XRPostLateUpdate
{}

// Namespace: 
public struct UpdateAllRenderers
{}

// Namespace: 
public struct UpdateLightProbeProxyVolumes
{}

// Namespace: 
public struct EnlightenRuntimeUpdate
{}

// Namespace: 
public struct UpdateAllSkinnedMeshes
{}

// Namespace: 
public struct ProcessWebSendMessages
{}

// Namespace: 
public struct SortingGroupsUpdate
{}

// Namespace: 
public struct UpdateVideoTextures
{}

// Namespace: 
public struct DirectorRenderImage
{}

// Namespace: 
public struct PlayerEmitCanvasGeometry
{}

// Namespace: 
internal struct PlayerRenderUIEBatchModeOffscreen
{}

// Namespace: 
public struct FinishFrameRendering
{}

// Namespace: 
public struct BatchModeUpdate
{}

// Namespace: 
public struct PlayerSendFrameComplete
{}

// Namespace: 
public struct UpdateCaptureScreenshot
{}

// Namespace: 
public struct PresentAfterDraw
{}

// Namespace: 
public struct ClearImmediateRenderers
{}

// Namespace: 
public struct XRPostPresent
{}

// Namespace: 
public struct UpdateResolution
{}

// Namespace: 
public struct InputEndFrame
{}

// Namespace: 
public struct GUIClearEvents
{}

// Namespace: 
public struct ShaderHandleErrors
{}

// Namespace: 
public struct ResetInputAxis
{}

// Namespace: 
public struct ThreadedLoadingDebug
{}

// Namespace: 
public struct ProfilerSynchronizeStats
{}

// Namespace: 
public struct MemoryFrameMaintenance
{}

// Namespace: 
public struct ExecuteGameCenterCallbacks
{}

// Namespace: 
public struct XRPreEndFrame
{}

// Namespace: 
public struct ProfilerEndFrame
{}

// Namespace: 
public struct GraphicsWarmupPreloadedShaders
{}

// Namespace: 
public struct PlayerSendFramePostPresent
{}

// Namespace: 
public struct PhysicsSkinnedClothBeginUpdate
{}

// Namespace: 
public struct PhysicsSkinnedClothFinishUpdate
{}

// Namespace: 
public struct TriggerEndOfFrameCallbacks
{}

// Namespace: 
public struct ObjectDispatcherPostLateUpdate
{}

// Namespace: UnityEngine.PlayerLoop
public struct PostLateUpdate
{}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Pool.CollectionPool.<>c<TCollection,TItem> <>9; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal TCollection <.cctor>b__5_0() { }

	// RVA: 0x316B894
	internal void <.cctor>b__5_1(TCollection l) { }

}

// Namespace: UnityEngine.Pool
public class CollectionPool<T0, T1>
{
	// Fields
	internal static readonly UnityEngine.Pool.ObjectPool<TCollection> s_Pool; // 0x0

	// Methods

	// RVA: 0x316B894
	public static TCollection Get() { }

	// RVA: 0x316B894
	public static UnityEngine.Pool.PooledObject<TCollection> Get(TCollection value) { }

	// RVA: 0x316B894
	public static void Release(TCollection toRelease) { }

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: UnityEngine.Pool
public interface IObjectPool<T0>
{
	// Methods

	// RVA: -1
	public abstract void Release(T element) { }

}

// Namespace: UnityEngine.Pool
public class ObjectPool<T0>
{
	// Fields
	internal readonly System.Collections.Generic.List<T> m_List; // 0x0
	private readonly System.Func<T> m_CreateFunc; // 0x0
	private readonly System.Action<T> m_ActionOnGet; // 0x0
	private readonly System.Action<T> m_ActionOnRelease; // 0x0
	private readonly System.Action<T> m_ActionOnDestroy; // 0x0
	private readonly int m_MaxSize; // 0x0
	internal bool m_CollectionCheck; // 0x0
	private int <CountAll>k__BackingField; // 0x0

	// Methods

	// RVA: 0x30B199C
	public int get_CountAll() { }

	// RVA: 0x30B29E8
	private void set_CountAll(int value) { }

	// RVA: 0x30B199C
	public int get_CountInactive() { }

	// RVA: 0x316B894
	public void .ctor(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, bool collectionCheck, int defaultCapacity, int maxSize) { }

	// RVA: 0x316B894
	public T Get() { }

	// RVA: 0x316B894
	public UnityEngine.Pool.PooledObject<T> Get(T v) { }

	// RVA: 0x316B894
	public void Release(T element) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x30B2870
	public void Dispose() { }

}

// Namespace: UnityEngine.Pool
public struct PooledObject<T0>
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly UnityEngine.Pool.IObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: 0x316B894
	public void .ctor(T value, UnityEngine.Pool.IObjectPool<T> pool) { }

	// RVA: 0x30B2870
	private void System.IDisposable.Dispose() { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class MessageEventArgs
{
	// Fields
	public int playerId; // 0x10
	public Byte[] data; // 0x18

	// Methods

	// RVA: 0x160437C
	public void .ctor() { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
public interface IEditorPlayerConnection
{
	// Methods

	// RVA: -1
	public abstract void Register(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: -1
	public abstract void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: -1
	public abstract void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: -1
	public abstract void Send(Guid messageId, Byte[] data) { }

}

// Namespace: 
private sealed class <>c__DisplayClass12_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1604B58
	public void .ctor() { }

	// RVA: 0x16065FC
	internal bool <Register>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1604FBC
	public void .ctor() { }

	// RVA: 0x160667C
	internal bool <Unregister>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x1605B10
	public void .ctor() { }

	// RVA: 0x16066CC
	internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class PlayerConnection
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	private System.Collections.Generic.List<System.Int32> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Methods

	// RVA: 0x1604384
	public static PlayerConnection get_instance() { }

	// RVA: 0x16045AC
	public bool get_isConnected() { }

	// RVA: 0x16044E8
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x1604780
	public void OnEnable() { }

	// RVA: 0x16046E4
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x16048B8
	public void Register(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x1604DBC
	public void Unregister(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x1605134
	public void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x16053C4
	public void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x1605430
	public void UnregisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x160549C
	public void UnregisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x1605508
	public void Send(Guid messageId, Byte[] data) { }

	// RVA: 0x16056C4
	public bool TrySend(Guid messageId, Byte[] data) { }

	// RVA: 0x1605880
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x1605B18
	public void DisconnectAll() { }

	// RVA: 0x1605C50
	private static void MessageCallbackInternal(IntPtr data, UInt64 size, UInt64 guid, string messageId) { }

	// RVA: 0x1606204
	private static void ConnectedCallbackInternal(int playerId) { }

	// RVA: 0x16062B0
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x160635C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class MessageEvent
{
	// Methods

	// RVA: 0x16067D4
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ConnectionChangeEvent
{
	// Methods

	// RVA: 0x1606830
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class MessageTypeSubscribers
{
	// Fields
	private string m_messageTypeId; // 0x10
	public int subscriberCount; // 0x18
	public MessageEvent messageCallback; // 0x20

	// Methods

	// RVA: 0x160664C
	public Guid get_MessageTypeId() { }

	// RVA: 0x1606790
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x16066E8
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x16066D8
	public void .ctor() { }

	// RVA: 0x1606884
	internal bool <InvokeMessageIdSubscribers>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x16066E0
	public void .ctor() { }

	// RVA: 0x16068D4
	internal bool <AddAndCreate>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1606828
	public void .ctor() { }

	// RVA: 0x1606924
	internal bool <UnregisterManagedCallback>b__0(MessageTypeSubscribers x) { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
internal class PlayerEditorConnectionEvents
{
	// Fields
	public System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	public ConnectionChangeEvent connectionEvent; // 0x18
	public ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0x1605D78
	public void InvokeMessageIdSubscribers(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x1604B60
	public UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x1604FC4
	public void UnregisterManagedCallback(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x16064C0
	public void .ctor() { }

}

// Namespace: UnityEngine.iOS
public sealed class Device
{
	// Methods

	// RVA: 0x1606974
	public static string get_systemVersion() { }

	// RVA: 0x16069B4
	public static string get_vendorIdentifier() { }

	// RVA: 0x16069F4
	public static bool RequestStoreReview() { }

}

// Namespace: UnityEngine.iOS
public sealed class OnDemandResourcesRequest
{
	// Methods

	// RVA: 0x1606A34
	public string get_error() { }

	// RVA: 0x1606A84
	private static void DestroyFromScript(IntPtr ptr) { }

	// RVA: 0x1606AD4
	public void Dispose() { }

	// RVA: 0x1606BA0
	internal void .ctor() { }

	// RVA: 0x1606BA8
	protected override void Finalize() { }

}

// Namespace: UnityEngine.iOS
public static class OnDemandResources
{
	// Methods

	// RVA: 0x1606CC8
	public static bool get_enabled() { }

	// RVA: 0x1606D08
	private static OnDemandResourcesRequest PreloadAsyncImpl(string[] tags) { }

	// RVA: 0x1606D58
	public static OnDemandResourcesRequest PreloadAsync(string[] tags) { }

}

// Namespace: UnityEngine.Internal
[Serializable]
public class DefaultValueAttribute
{
	// Fields
	private object DefaultValue; // 0x10

	// Methods

	// RVA: 0x1606DA8
	public void .ctor(string value) { }

	// RVA: 0x1606DDC
	public object get_Value() { }

	// RVA: 0x1606DE4
	public override bool Equals(object obj) { }

	// RVA: 0x1606EA4
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Internal
[Serializable]
public class ExcludeFromDocsAttribute
{
	// Methods

	// RVA: 0x1606EC8
	public void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public enum IndexFormat
{
	// Fields
	public int value__; // 0x10
	public const IndexFormat UInt16 = 0;
	public const IndexFormat UInt32 = 1;
}

// Namespace: UnityEngine.Rendering
public enum MeshUpdateFlags
{
	// Fields
	public int value__; // 0x10
	public const MeshUpdateFlags Default = 0;
	public const MeshUpdateFlags DontValidateIndices = 1;
	public const MeshUpdateFlags DontResetBoneBounds = 2;
	public const MeshUpdateFlags DontNotifyMeshUsers = 4;
	public const MeshUpdateFlags DontRecalculateBounds = 8;
}

// Namespace: UnityEngine.Rendering
public enum VertexAttributeFormat
{
	// Fields
	public int value__; // 0x10
	public const VertexAttributeFormat Float32 = 0;
	public const VertexAttributeFormat Float16 = 1;
	public const VertexAttributeFormat UNorm8 = 2;
	public const VertexAttributeFormat SNorm8 = 3;
	public const VertexAttributeFormat UNorm16 = 4;
	public const VertexAttributeFormat SNorm16 = 5;
	public const VertexAttributeFormat UInt8 = 6;
	public const VertexAttributeFormat SInt8 = 7;
	public const VertexAttributeFormat UInt16 = 8;
	public const VertexAttributeFormat SInt16 = 9;
	public const VertexAttributeFormat UInt32 = 10;
	public const VertexAttributeFormat SInt32 = 11;
}

// Namespace: UnityEngine.Rendering
public enum VertexAttribute
{
	// Fields
	public int value__; // 0x10
	public const VertexAttribute Position = 0;
	public const VertexAttribute Normal = 1;
	public const VertexAttribute Tangent = 2;
	public const VertexAttribute Color = 3;
	public const VertexAttribute TexCoord0 = 4;
	public const VertexAttribute TexCoord1 = 5;
	public const VertexAttribute TexCoord2 = 6;
	public const VertexAttribute TexCoord3 = 7;
	public const VertexAttribute TexCoord4 = 8;
	public const VertexAttribute TexCoord5 = 9;
	public const VertexAttribute TexCoord6 = 10;
	public const VertexAttribute TexCoord7 = 11;
	public const VertexAttribute BlendWeight = 12;
	public const VertexAttribute BlendIndices = 13;
}

// Namespace: UnityEngine.Rendering
public enum OpaqueSortMode
{
	// Fields
	public int value__; // 0x10
	public const OpaqueSortMode Default = 0;
	public const OpaqueSortMode FrontToBack = 1;
	public const OpaqueSortMode NoDistanceSort = 2;
}

// Namespace: UnityEngine.Rendering
public enum RenderBufferLoadAction
{
	// Fields
	public int value__; // 0x10
	public const RenderBufferLoadAction Load = 0;
	public const RenderBufferLoadAction Clear = 1;
	public const RenderBufferLoadAction DontCare = 2;
}

// Namespace: UnityEngine.Rendering
public enum RenderBufferStoreAction
{
	// Fields
	public int value__; // 0x10
	public const RenderBufferStoreAction Store = 0;
	public const RenderBufferStoreAction Resolve = 1;
	public const RenderBufferStoreAction StoreAndResolve = 2;
	public const RenderBufferStoreAction DontCare = 3;
}

// Namespace: UnityEngine.Rendering
public enum CompareFunction
{
	// Fields
	public int value__; // 0x10
	public const CompareFunction Disabled = 0;
	public const CompareFunction Never = 1;
	public const CompareFunction Less = 2;
	public const CompareFunction Equal = 3;
	public const CompareFunction LessEqual = 4;
	public const CompareFunction Greater = 5;
	public const CompareFunction NotEqual = 6;
	public const CompareFunction GreaterEqual = 7;
	public const CompareFunction Always = 8;
}

// Namespace: UnityEngine.Rendering
public enum ColorWriteMask
{
	// Fields
	public int value__; // 0x10
	public const ColorWriteMask Alpha = 1;
	public const ColorWriteMask Blue = 2;
	public const ColorWriteMask Green = 4;
	public const ColorWriteMask Red = 8;
	public const ColorWriteMask All = 15;
}

// Namespace: UnityEngine.Rendering
public enum StencilOp
{
	// Fields
	public int value__; // 0x10
	public const StencilOp Keep = 0;
	public const StencilOp Zero = 1;
	public const StencilOp Replace = 2;
	public const StencilOp IncrementSaturate = 3;
	public const StencilOp DecrementSaturate = 4;
	public const StencilOp Invert = 5;
	public const StencilOp IncrementWrap = 6;
	public const StencilOp DecrementWrap = 7;
}

// Namespace: UnityEngine.Rendering
public enum CameraEvent
{
	// Fields
	public int value__; // 0x10
	public const CameraEvent BeforeDepthTexture = 0;
	public const CameraEvent AfterDepthTexture = 1;
	public const CameraEvent BeforeDepthNormalsTexture = 2;
	public const CameraEvent AfterDepthNormalsTexture = 3;
	public const CameraEvent BeforeGBuffer = 4;
	public const CameraEvent AfterGBuffer = 5;
	public const CameraEvent BeforeLighting = 6;
	public const CameraEvent AfterLighting = 7;
	public const CameraEvent BeforeFinalPass = 8;
	public const CameraEvent AfterFinalPass = 9;
	public const CameraEvent BeforeForwardOpaque = 10;
	public const CameraEvent AfterForwardOpaque = 11;
	public const CameraEvent BeforeImageEffectsOpaque = 12;
	public const CameraEvent AfterImageEffectsOpaque = 13;
	public const CameraEvent BeforeSkybox = 14;
	public const CameraEvent AfterSkybox = 15;
	public const CameraEvent BeforeForwardAlpha = 16;
	public const CameraEvent AfterForwardAlpha = 17;
	public const CameraEvent BeforeImageEffects = 18;
	public const CameraEvent AfterImageEffects = 19;
	public const CameraEvent AfterEverything = 20;
	public const CameraEvent BeforeReflections = 21;
	public const CameraEvent AfterReflections = 22;
	public const CameraEvent BeforeHaloAndLensFlares = 23;
	public const CameraEvent AfterHaloAndLensFlares = 24;
}

// Namespace: UnityEngine.Rendering
internal static class CameraEventUtils
{
	// Methods

	// RVA: 0x1606ED0
	public static bool IsValid(CameraEvent value) { }

}

// Namespace: UnityEngine.Rendering
public enum BuiltinRenderTextureType
{
	// Fields
	public int value__; // 0x10
	public const BuiltinRenderTextureType PropertyName = 4294967292;
	public const BuiltinRenderTextureType BufferPtr = 4294967293;
	public const BuiltinRenderTextureType RenderTexture = 4294967294;
	public const BuiltinRenderTextureType BindableTexture = 4294967295;
	public const BuiltinRenderTextureType None = 0;
	public const BuiltinRenderTextureType CurrentActive = 1;
	public const BuiltinRenderTextureType CameraTarget = 2;
	public const BuiltinRenderTextureType Depth = 3;
	public const BuiltinRenderTextureType DepthNormals = 4;
	public const BuiltinRenderTextureType ResolvedDepth = 5;
	public const BuiltinRenderTextureType PrepassNormalsSpec = 7;
	public const BuiltinRenderTextureType PrepassLight = 8;
	public const BuiltinRenderTextureType PrepassLightSpec = 9;
	public const BuiltinRenderTextureType GBuffer0 = 10;
	public const BuiltinRenderTextureType GBuffer1 = 11;
	public const BuiltinRenderTextureType GBuffer2 = 12;
	public const BuiltinRenderTextureType GBuffer3 = 13;
	public const BuiltinRenderTextureType Reflections = 14;
	public const BuiltinRenderTextureType MotionVectors = 15;
	public const BuiltinRenderTextureType GBuffer4 = 16;
	public const BuiltinRenderTextureType GBuffer5 = 17;
	public const BuiltinRenderTextureType GBuffer6 = 18;
	public const BuiltinRenderTextureType GBuffer7 = 19;
}

// Namespace: UnityEngine.Rendering
public enum ShadowCastingMode
{
	// Fields
	public int value__; // 0x10
	public const ShadowCastingMode Off = 0;
	public const ShadowCastingMode On = 1;
	public const ShadowCastingMode TwoSided = 2;
	public const ShadowCastingMode ShadowsOnly = 3;
}

// Namespace: UnityEngine.Rendering
public enum GraphicsDeviceType
{
	// Fields
	public int value__; // 0x10
	public const GraphicsDeviceType OpenGL2 = 0;
	public const GraphicsDeviceType Direct3D9 = 1;
	public const GraphicsDeviceType Direct3D11 = 2;
	public const GraphicsDeviceType PlayStation3 = 3;
	public const GraphicsDeviceType Null = 4;
	public const GraphicsDeviceType Xbox360 = 6;
	public const GraphicsDeviceType OpenGLES2 = 8;
	public const GraphicsDeviceType OpenGLES3 = 11;
	public const GraphicsDeviceType PlayStationVita = 12;
	public const GraphicsDeviceType PlayStation4 = 13;
	public const GraphicsDeviceType XboxOne = 14;
	public const GraphicsDeviceType PlayStationMobile = 15;
	public const GraphicsDeviceType Metal = 16;
	public const GraphicsDeviceType OpenGLCore = 17;
	public const GraphicsDeviceType Direct3D12 = 18;
	public const GraphicsDeviceType N3DS = 19;
	public const GraphicsDeviceType Vulkan = 21;
	public const GraphicsDeviceType Switch = 22;
	public const GraphicsDeviceType XboxOneD3D12 = 23;
	public const GraphicsDeviceType GameCoreXboxOne = 24;
	public const GraphicsDeviceType GameCoreScarlett = 4294967295;
	public const GraphicsDeviceType GameCoreXboxSeries = 25;
	public const GraphicsDeviceType PlayStation5 = 26;
	public const GraphicsDeviceType PlayStation5NGGC = 27;
}

// Namespace: UnityEngine.Rendering
public struct SubMeshDescriptor
{
	// Fields
	private Bounds <bounds>k__BackingField; // 0x10
	private MeshTopology <topology>k__BackingField; // 0x28
	private int <indexStart>k__BackingField; // 0x2C
	private int <indexCount>k__BackingField; // 0x30
	private int <baseVertex>k__BackingField; // 0x34
	private int <firstVertex>k__BackingField; // 0x38
	private int <vertexCount>k__BackingField; // 0x3C

	// Methods

	// RVA: 0x1606EDC
	public void .ctor(int indexStart, int indexCount, MeshTopology topology) { }

	// RVA: 0x1606EF4
	public Bounds get_bounds() { }

	// RVA: 0x1606F08
	public void set_bounds(Bounds value) { }

	// RVA: 0x1606F1C
	public MeshTopology get_topology() { }

	// RVA: 0x1606F24
	public void set_topology(MeshTopology value) { }

	// RVA: 0x1606F2C
	public int get_indexStart() { }

	// RVA: 0x1606F34
	public void set_indexStart(int value) { }

	// RVA: 0x1606F3C
	public int get_indexCount() { }

	// RVA: 0x1606F44
	public void set_indexCount(int value) { }

	// RVA: 0x1606F4C
	public int get_baseVertex() { }

	// RVA: 0x1606F54
	public void set_baseVertex(int value) { }

	// RVA: 0x1606F5C
	public int get_firstVertex() { }

	// RVA: 0x1606F64
	public void set_firstVertex(int value) { }

	// RVA: 0x1606F6C
	public int get_vertexCount() { }

	// RVA: 0x1606F74
	public void set_vertexCount(int value) { }

	// RVA: 0x1606F7C
	public override string ToString() { }

}

// Namespace: UnityEngine.Rendering
public struct VertexAttributeDescriptor
{
	// Fields
	private VertexAttribute <attribute>k__BackingField; // 0x10
	private VertexAttributeFormat <format>k__BackingField; // 0x14
	private int <dimension>k__BackingField; // 0x18
	private int <stream>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x1607270
	public VertexAttribute get_attribute() { }

	// RVA: 0x1607278
	public void set_attribute(VertexAttribute value) { }

	// RVA: 0x1607280
	public VertexAttributeFormat get_format() { }

	// RVA: 0x1607288
	public void set_format(VertexAttributeFormat value) { }

	// RVA: 0x1607290
	public int get_dimension() { }

	// RVA: 0x1607298
	public void set_dimension(int value) { }

	// RVA: 0x16072A0
	public int get_stream() { }

	// RVA: 0x16072A8
	public void set_stream(int value) { }

	// RVA: 0x16072B0
	public void .ctor(VertexAttribute attribute, VertexAttributeFormat format, int dimension, int stream) { }

	// RVA: 0x16072BC
	public override string ToString() { }

	// RVA: 0x16074C4
	public override int GetHashCode() { }

	// RVA: 0x16074E8
	public override bool Equals(object other) { }

	// RVA: 0x16075A8
	public bool Equals(VertexAttributeDescriptor other) { }

}

// Namespace: UnityEngine.Rendering
public struct RenderTargetIdentifier
{
	// Fields
	public const int AllDepthSlices = 4294967295;
	private BuiltinRenderTextureType m_Type; // 0x10
	private int m_NameID; // 0x14
	private int m_InstanceID; // 0x18
	private IntPtr m_BufferPointer; // 0x20
	private int m_MipLevel; // 0x28
	private CubemapFace m_CubeFace; // 0x2C
	private int m_DepthSlice; // 0x30

	// Methods

	// RVA: 0x16075EC
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x160760C
	public void .ctor(int nameID) { }

	// RVA: 0x160762C
	public void .ctor(Texture tex) { }

	// RVA: 0x16078C4
	public void .ctor(RenderBuffer buf, int mipLevel, CubemapFace cubeFace, int depthSlice) { }

	// RVA: 0x16078E4
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x1607904
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x1607924
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x1607970
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x1607994
	public override string ToString() { }

	// RVA: 0x1607C9C
	public override int GetHashCode() { }

	// RVA: 0x1607CF4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x1607DA8
	public override bool Equals(object obj) { }

}

// Namespace: UnityEngine.Rendering
public enum RenderTargetFlags
{
	// Fields
	public int value__; // 0x10
	public const RenderTargetFlags None = 0;
	public const RenderTargetFlags ReadOnlyDepth = 1;
	public const RenderTargetFlags ReadOnlyStencil = 2;
	public const RenderTargetFlags ReadOnlyDepthStencil = 3;
}

// Namespace: UnityEngine.Rendering
public enum ReflectionProbeUsage
{
	// Fields
	public int value__; // 0x10
	public const ReflectionProbeUsage Off = 0;
	public const ReflectionProbeUsage BlendProbes = 1;
	public const ReflectionProbeUsage BlendProbesAndSkybox = 2;
	public const ReflectionProbeUsage Simple = 3;
}

// Namespace: UnityEngine.Rendering
public enum ShadowSamplingMode
{
	// Fields
	public int value__; // 0x10
	public const ShadowSamplingMode CompareDepths = 0;
	public const ShadowSamplingMode RawDepth = 1;
	public const ShadowSamplingMode None = 2;
}

// Namespace: UnityEngine.Rendering
public enum LightProbeUsage
{
	// Fields
	public int value__; // 0x10
	public const LightProbeUsage Off = 0;
	public const LightProbeUsage BlendProbes = 1;
	public const LightProbeUsage UseProxyVolume = 2;
	public const LightProbeUsage CustomProvided = 4;
}

// Namespace: UnityEngine.Rendering
public enum TextureDimension
{
	// Fields
	public int value__; // 0x10
	public const TextureDimension Unknown = 4294967295;
	public const TextureDimension None = 0;
	public const TextureDimension Any = 1;
	public const TextureDimension Tex2D = 2;
	public const TextureDimension Tex3D = 3;
	public const TextureDimension Cube = 4;
	public const TextureDimension Tex2DArray = 5;
	public const TextureDimension CubeArray = 6;
}

// Namespace: UnityEngine.Rendering
public enum CopyTextureSupport
{
	// Fields
	public int value__; // 0x10
	public const CopyTextureSupport None = 0;
	public const CopyTextureSupport Basic = 1;
	public const CopyTextureSupport Copy3D = 2;
	public const CopyTextureSupport DifferentTypes = 4;
	public const CopyTextureSupport TextureToRT = 8;
	public const CopyTextureSupport RTToTexture = 16;
}

// Namespace: UnityEngine.Rendering
public enum ComputeQueueType
{
	// Fields
	public int value__; // 0x10
	public const ComputeQueueType Default = 0;
	public const ComputeQueueType Background = 1;
	public const ComputeQueueType Urgent = 2;
}

// Namespace: UnityEngine.Rendering
public enum CommandBufferExecutionFlags
{
	// Fields
	public int value__; // 0x10
	public const CommandBufferExecutionFlags None = 0;
	public const CommandBufferExecutionFlags AsyncCompute = 2;
}

// Namespace: UnityEngine.Rendering
public enum RTClearFlags
{
	// Fields
	public int value__; // 0x10
	public const RTClearFlags None = 0;
	public const RTClearFlags Color = 1;
	public const RTClearFlags Depth = 2;
	public const RTClearFlags Stencil = 4;
	public const RTClearFlags All = 7;
	public const RTClearFlags DepthStencil = 6;
	public const RTClearFlags ColorDepth = 3;
	public const RTClearFlags ColorStencil = 5;
}

// Namespace: UnityEngine.Rendering
public enum RenderTextureSubElement
{
	// Fields
	public int value__; // 0x10
	public const RenderTextureSubElement Color = 0;
	public const RenderTextureSubElement Depth = 1;
	public const RenderTextureSubElement Stencil = 2;
	public const RenderTextureSubElement Default = 3;
}

// Namespace: UnityEngine.Rendering
public sealed class GraphicsSettings
{
	// Methods

	// RVA: 0x1607EAC
	public static bool get_lightsUseLinearIntensity() { }

	// RVA: 0x1607EEC
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	// RVA: 0x1607F2C
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	// RVA: 0x1607FEC
	public static RenderPipelineAsset get_renderPipelineAsset() { }

	// RVA: 0x160816C
	public static void set_renderPipelineAsset(RenderPipelineAsset value) { }

	// RVA: 0x160820C
	private static ScriptableObject get_INTERNAL_defaultRenderPipeline() { }

	// RVA: 0x160824C
	private static void set_INTERNAL_defaultRenderPipeline(ScriptableObject value) { }

	// RVA: 0x16080AC
	public static RenderPipelineAsset get_defaultRenderPipeline() { }

	// RVA: 0x16081BC
	public static void set_defaultRenderPipeline(RenderPipelineAsset value) { }

}

// Namespace: UnityEngine.Rendering
public class OnDemandRendering
{
	// Fields
	private static int m_RenderFrameInterval; // 0x0

	// Methods

	// RVA: 0x160829C
	public static int get_renderFrameInterval() { }

	// RVA: 0x1608318
	internal static void GetRenderFrameInterval(int frameInterval) { }

	// RVA: 0x16083DC
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public class CommandBuffer
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x160842C
	public void SetInvertCulling(bool invertCulling) { }

	// RVA: 0x1608494
	private static IntPtr InitBuffer() { }

	// RVA: 0x16084D4
	private void ReleaseBuffer() { }

	// RVA: 0x1608524
	public void set_name(string value) { }

	// RVA: 0x160858C
	public void Clear() { }

	// RVA: 0x16085DC
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x16086EC
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x160875C
	private void CopyTexture_Internal(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	// RVA: 0x1608810
	private void Blit_Texture(Texture source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x1608954
	private void Blit_Identifier(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x1608A98
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x1608B54
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x1608C04
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	// RVA: 0x1608CB4
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0x1608D58
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x1608E50
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x1608F20
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x1608FA0
	public void ReleaseTemporaryRT(int nameID) { }

	// RVA: 0x1609008
	public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, UInt32 stencil) { }

	// RVA: 0x1609100
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x1609230
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x1609314
	public void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x1609374
	public void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x1609434
	public void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x16094F4
	public void EnableShaderKeyword(string keyword) { }

	// RVA: 0x160955C
	private void EnableGlobalKeyword(GlobalKeyword keyword) { }

	// RVA: 0x1609618
	public void EnableKeyword(GlobalKeyword keyword) { }

	// RVA: 0x1609670
	public void DisableShaderKeyword(string keyword) { }

	// RVA: 0x16096D8
	private void DisableGlobalKeyword(GlobalKeyword keyword) { }

	// RVA: 0x1609794
	public void DisableKeyword(GlobalKeyword keyword) { }

	// RVA: 0x16097EC
	public void SetViewMatrix(Matrix4x4 view) { }

	// RVA: 0x16098BC
	public void SetProjectionMatrix(Matrix4x4 proj) { }

	// RVA: 0x160998C
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	// RVA: 0x16091D8
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	// RVA: 0x1609A3C
	private void SetGlobalTexture_Impl(int nameID, RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	// RVA: 0x1609AA4
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x1609B0C
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x1609C38
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x1609D98
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x1609BB8
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x1609D00
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x1609FF0
	protected override void Finalize() { }

	// RVA: 0x160A10C
	public void Dispose() { }

	// RVA: 0x160A0AC
	private void Dispose(bool disposing) { }

	// RVA: 0x160A1E0
	public void .ctor() { }

	// RVA: 0x160A23C
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x160A5F0
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x160A624
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x160A65C
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	// RVA: 0x160A698
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x160A9EC
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x160A9F4
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x160AA00
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x160AA8C
	public void Blit(Texture source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset) { }

	// RVA: 0x160AB74
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x160AC44
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x160AD20
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x160ADEC
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x160AEBC
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x160AF98
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x160B02C
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x160B088
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x1608664
	private void Internal_DrawMesh_Injected(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x16088B4
	private void Blit_Texture_Injected(Texture source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x16089F8
	private void Blit_Identifier_Injected(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x1608EB8
	private void GetTemporaryRTWithDescriptor_Injected(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x1609088
	private void ClearRenderTarget_Injected(RTClearFlags clearFlags, Color backgroundColor, float depth, UInt32 stencil) { }

	// RVA: 0x16093DC
	private void SetGlobalVector_Injected(int nameID, Vector4 value) { }

	// RVA: 0x160949C
	private void SetGlobalColor_Injected(int nameID, Color value) { }

	// RVA: 0x16095B0
	private void EnableGlobalKeyword_Injected(GlobalKeyword keyword) { }

	// RVA: 0x160972C
	private void DisableGlobalKeyword_Injected(GlobalKeyword keyword) { }

	// RVA: 0x1609854
	private void SetViewMatrix_Injected(Matrix4x4 view) { }

	// RVA: 0x1609924
	private void SetProjectionMatrix_Injected(Matrix4x4 proj) { }

	// RVA: 0x16099E4
	private void SetViewProjectionMatrices_Injected(Matrix4x4 view, Matrix4x4 proj) { }

	// RVA: 0x1609ED8
	private void SetRenderTargetSingle_Internal_Injected(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x1609F58
	private void SetRenderTargetColorDepth_Internal_Injected(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

}

// Namespace: UnityEngine.Rendering
public struct SphericalHarmonicsL2
{
	// Fields
	private float shr0; // 0x10
	private float shr1; // 0x14
	private float shr2; // 0x18
	private float shr3; // 0x1C
	private float shr4; // 0x20
	private float shr5; // 0x24
	private float shr6; // 0x28
	private float shr7; // 0x2C
	private float shr8; // 0x30
	private float shg0; // 0x34
	private float shg1; // 0x38
	private float shg2; // 0x3C
	private float shg3; // 0x40
	private float shg4; // 0x44
	private float shg5; // 0x48
	private float shg6; // 0x4C
	private float shg7; // 0x50
	private float shg8; // 0x54
	private float shb0; // 0x58
	private float shb1; // 0x5C
	private float shb2; // 0x60
	private float shb3; // 0x64
	private float shb4; // 0x68
	private float shb5; // 0x6C
	private float shb6; // 0x70
	private float shb7; // 0x74
	private float shb8; // 0x78

	// Methods

	// RVA: 0x160B17C
	public float get_Item(int rgb, int coefficient) { }

	// RVA: 0x160B39C
	public void set_Item(int rgb, int coefficient, float value) { }

	// RVA: 0x160B5BC
	public override int GetHashCode() { }

	// RVA: 0x160B79C
	public override bool Equals(object other) { }

	// RVA: 0x160B854
	public bool Equals(SphericalHarmonicsL2 other) { }

	// RVA: 0x160B918
	public static bool op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

}

// Namespace: UnityEngine.Rendering
public struct BatchID
{
	// Fields
	public static readonly BatchID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x160BAD4
	public override int GetHashCode() { }

	// RVA: 0x160BADC
	public override bool Equals(object obj) { }

	// RVA: 0x160BBAC
	public bool Equals(BatchID other) { }

	// RVA: 0x160BBBC
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct BatchMaterialID
{
	// Fields
	public static readonly BatchMaterialID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x160BC08
	public override int GetHashCode() { }

	// RVA: 0x160BC10
	public override bool Equals(object obj) { }

	// RVA: 0x160BCE0
	public bool Equals(BatchMaterialID other) { }

	// RVA: 0x160BCF0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct BatchMeshID
{
	// Fields
	public static readonly BatchMeshID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x160BD3C
	public override int GetHashCode() { }

	// RVA: 0x160BD44
	public override bool Equals(object obj) { }

	// RVA: 0x160BE14
	public bool Equals(BatchMeshID other) { }

	// RVA: 0x160BE24
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public enum BatchDrawCommandFlags
{
	// Fields
	public int value__; // 0x10
	public const BatchDrawCommandFlags None = 0;
	public const BatchDrawCommandFlags FlipWinding = 1;
	public const BatchDrawCommandFlags HasMotion = 2;
	public const BatchDrawCommandFlags IsLightMapped = 4;
	public const BatchDrawCommandFlags HasSortingPosition = 8;
	public const BatchDrawCommandFlags LODCrossFade = 16;
}

// Namespace: UnityEngine.Rendering
public enum BatchCullingFlags
{
	// Fields
	public int value__; // 0x10
	public const BatchCullingFlags None = 0;
	public const BatchCullingFlags CullLightmappedShadowCasters = 1;
}

// Namespace: UnityEngine.Rendering
public enum BatchCullingViewType
{
	// Fields
	public int value__; // 0x10
	public const BatchCullingViewType Unknown = 0;
	public const BatchCullingViewType Camera = 1;
	public const BatchCullingViewType Light = 2;
	public const BatchCullingViewType Picking = 3;
	public const BatchCullingViewType SelectionOutline = 4;
}

// Namespace: UnityEngine.Rendering
public enum BatchCullingProjectionType
{
	// Fields
	public int value__; // 0x10
	public const BatchCullingProjectionType Unknown = 0;
	public const BatchCullingProjectionType Perspective = 1;
	public const BatchCullingProjectionType Orthographic = 2;
}

// Namespace: UnityEngine.Rendering
public struct BatchPackedCullingViewID
{
	// Fields
	internal UInt64 handle; // 0x10

	// Methods

	// RVA: 0x160BE70
	public override int GetHashCode() { }

	// RVA: 0x160BE78
	public bool Equals(BatchPackedCullingViewID other) { }

	// RVA: 0x160BE88
	public override bool Equals(object obj) { }

}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommand
{
	// Fields
	public UInt32 visibleOffset; // 0x10
	public UInt32 visibleCount; // 0x14
	public BatchID batchID; // 0x18
	public BatchMaterialID materialID; // 0x1C
	public BatchMeshID meshID; // 0x20
	public UInt16 submeshIndex; // 0x24
	public UInt16 splitVisibilityMask; // 0x26
	public BatchDrawCommandFlags flags; // 0x28
	public int sortingPosition; // 0x2C
}

// Namespace: UnityEngine.Rendering
public struct BatchFilterSettings
{
	// Fields
	public UInt32 renderingLayerMask; // 0x10
	public Byte layer; // 0x14
	private Byte m_motionMode; // 0x15
	private Byte m_shadowMode; // 0x16
	private Byte m_receiveShadows; // 0x17
	private Byte m_staticShadowCaster; // 0x18
	private Byte m_allDepthSorted; // 0x19
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawRange
{
	// Fields
	public UInt32 drawCommandsBegin; // 0x10
	public UInt32 drawCommandsCount; // 0x14
	public BatchFilterSettings filterSettings; // 0x18
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutputDrawCommands
{
	// Fields
	public BatchDrawCommand* drawCommands; // 0x10
	public Int32* visibleInstances; // 0x18
	public BatchDrawRange* drawRanges; // 0x20
	public Single* instanceSortingPositions; // 0x28
	public Int32* drawCommandPickingInstanceIDs; // 0x30
	public int drawCommandCount; // 0x38
	public int visibleInstanceCount; // 0x3C
	public int drawRangeCount; // 0x40
	public int instanceSortingPositionFloatCount; // 0x44
}

// Namespace: UnityEngine.Rendering
public struct CullingSplit
{
	// Fields
	public Vector3 sphereCenter; // 0x10
	public float sphereRadius; // 0x1C
	public int cullingPlaneOffset; // 0x20
	public int cullingPlaneCount; // 0x24
	public float cascadeBlendCullingFactor; // 0x28
	public float nearPlane; // 0x2C
	public Matrix4x4 cullingMatrix; // 0x30
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingContext
{
	// Fields
	public readonly Unity.Collections.NativeArray<UnityEngine.Plane> cullingPlanes; // 0x10
	public readonly Unity.Collections.NativeArray<UnityEngine.Rendering.CullingSplit> cullingSplits; // 0x20
	public readonly LODParameters lodParameters; // 0x30
	public readonly Matrix4x4 localToWorldMatrix; // 0x4C
	public readonly BatchCullingViewType viewType; // 0x8C
	public readonly BatchCullingProjectionType projectionType; // 0x90
	public readonly BatchCullingFlags cullingFlags; // 0x94
	public readonly BatchPackedCullingViewID viewID; // 0x98
	public readonly UInt32 cullingLayerMask; // 0xA0
	public readonly UInt64 sceneCullingMask; // 0xA8
	public readonly Byte isOrthographic; // 0xB0
	public readonly int receiverPlaneOffset; // 0xB4
	public readonly int receiverPlaneCount; // 0xB8

	// Methods

	// RVA: 0x160BF18
	internal void .ctor(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, UInt64 inViewID, UInt32 inCullingLayerMask, UInt64 inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount) { }

}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutput
{
	// Fields
	public Unity.Collections.NativeArray<UnityEngine.Rendering.BatchCullingOutputDrawCommands> drawCommands; // 0x10
}

// Namespace: UnityEngine.Rendering
internal struct BatchRendererCullingOutput
{
	// Fields
	public JobHandle cullingJobsFence; // 0x10
	public Matrix4x4 localToWorldMatrix; // 0x20
	public Plane* cullingPlanes; // 0x60
	public int cullingPlaneCount; // 0x68
	public int receiverPlaneOffset; // 0x6C
	public int receiverPlaneCount; // 0x70
	public CullingSplit* cullingSplits; // 0x78
	public int cullingSplitCount; // 0x80
	public BatchCullingViewType viewType; // 0x84
	public BatchCullingProjectionType projectionType; // 0x88
	public BatchCullingFlags cullingFlags; // 0x8C
	public UInt64 viewID; // 0x90
	public UInt32 cullingLayerMask; // 0x98
	public UInt64 sceneCullingMask; // 0xA0
	public BatchCullingOutputDrawCommands* drawCommands; // 0xA8
}

// Namespace: 
public sealed class OnPerformCulling
{
	// Methods

	// RVA: 0x160C180
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x160C2A4
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }

}

// Namespace: UnityEngine.Rendering
public class BatchRendererGroup
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	// RVA: 0x160BF84
	private static void InvokeOnPerformCulling(BatchRendererGroup group, BatchRendererCullingOutput context, LODParameters lodParameters, IntPtr userContext) { }

}

// Namespace: UnityEngine.Rendering
internal struct CoreCameraValues
{
	// Fields
	private int filterMode; // 0x10
	private UInt32 cullingMask; // 0x14
	private int instanceID; // 0x18

	// Methods

	// RVA: 0x160C304
	public bool Equals(CoreCameraValues other) { }

	// RVA: 0x160C338
	public override bool Equals(object obj) { }

	// RVA: 0x160C3E8
	public override int GetHashCode() { }

}

// Namespace: 
public struct <layerCullDistances>e__FixedBuffer
{
	// Fields
	public float FixedElementField; // 0x10
}

// Namespace: 
public struct <m_CameraCullPlanes>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
public struct <m_ShadowCullPlanes>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.Rendering
public struct CameraProperties
{
	// Fields
	private Rect screenRect; // 0x10
	private Vector3 viewDir; // 0x20
	private float projectionNear; // 0x2C
	private float projectionFar; // 0x30
	private float cameraNear; // 0x34
	private float cameraFar; // 0x38
	private float cameraAspect; // 0x3C
	private Matrix4x4 cameraToWorld; // 0x40
	private Matrix4x4 actualWorldToClip; // 0x80
	private Matrix4x4 cameraClipToWorld; // 0xC0
	private Matrix4x4 cameraWorldToClip; // 0x100
	private Matrix4x4 implicitProjection; // 0x140
	private Matrix4x4 stereoWorldToClipLeft; // 0x180
	private Matrix4x4 stereoWorldToClipRight; // 0x1C0
	private Matrix4x4 worldToCamera; // 0x200
	private Vector3 up; // 0x240
	private Vector3 right; // 0x24C
	private Vector3 transformDirection; // 0x258
	private Vector3 cameraEuler; // 0x264
	private Vector3 velocity; // 0x270
	private float farPlaneWorldSpaceLength; // 0x27C
	private UInt32 rendererCount; // 0x280
	internal UnityEngine.Rendering.CameraProperties.<m_ShadowCullPlanes>e__FixedBuffer m_ShadowCullPlanes; // 0x284
	internal UnityEngine.Rendering.CameraProperties.<m_CameraCullPlanes>e__FixedBuffer m_CameraCullPlanes; // 0x2E4
	private float baseFarDistance; // 0x344
	private Vector3 shadowCullCenter; // 0x348
	internal UnityEngine.Rendering.CameraProperties.<layerCullDistances>e__FixedBuffer layerCullDistances; // 0x354
	private int layerCullSpherical; // 0x3D4
	private CoreCameraValues coreCameraValues; // 0x3D8
	private UInt32 cameraType; // 0x3E4
	private int projectionIsOblique; // 0x3E8
	private int isImplicitProjectionMatrix; // 0x3EC

	// Methods

	// RVA: 0x160C408
	public Plane GetShadowCullingPlane(int index) { }

	// RVA: 0x160C4F8
	public Plane GetCameraCullingPlane(int index) { }

	// RVA: 0x160C5E8
	public bool Equals(CameraProperties other) { }

	// RVA: 0x160D424
	public override bool Equals(object obj) { }

	// RVA: 0x160D4FC
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public enum CullingOptions
{
	// Fields
	public int value__; // 0x10
	public const CullingOptions None = 0;
	public const CullingOptions ForceEvenIfCameraIsNotActive = 1;
	public const CullingOptions OcclusionCull = 2;
	public const CullingOptions NeedsLighting = 4;
	public const CullingOptions NeedsReflectionProbes = 8;
	public const CullingOptions Stereo = 16;
	public const CullingOptions DisablePerObjectCulling = 32;
	public const CullingOptions ShadowCasters = 64;
}

// Namespace: 
public struct <m_CullingPlanes>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: 
public struct <m_LayerFarCullDistances>e__FixedBuffer
{
	// Fields
	public float FixedElementField; // 0x10
}

// Namespace: UnityEngine.Rendering
public struct ScriptableCullingParameters
{
	// Fields
	private int m_IsOrthographic; // 0x10
	private LODParameters m_LODParameters; // 0x14
	public static readonly int maximumCullingPlaneCount; // 0x0
	internal UnityEngine.Rendering.ScriptableCullingParameters.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x30
	private int m_CullingPlaneCount; // 0xD0
	private UInt32 m_CullingMask; // 0xD4
	private UInt64 m_SceneMask; // 0xD8
	private UInt64 m_ViewID; // 0xE0
	public static readonly int layerCount; // 0x4
	internal UnityEngine.Rendering.ScriptableCullingParameters.<m_LayerFarCullDistances>e__FixedBuffer m_LayerFarCullDistances; // 0xE8
	private int m_LayerCull; // 0x168
	private Matrix4x4 m_CullingMatrix; // 0x16C
	private Vector3 m_Origin; // 0x1AC
	private float m_ShadowDistance; // 0x1B8
	private float m_ShadowNearPlaneOffset; // 0x1BC
	private CullingOptions m_CullingOptions; // 0x1C0
	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria; // 0x1C4
	private CameraProperties m_CameraProperties; // 0x1C8
	private float m_AccurateOcclusionThreshold; // 0x5A8
	private int m_MaximumPortalCullingJobs; // 0x5AC
	private Matrix4x4 m_StereoViewMatrix; // 0x5B0
	private Matrix4x4 m_StereoProjectionMatrix; // 0x5F0
	private float m_StereoSeparationDistance; // 0x630
	private int m_maximumVisibleLights; // 0x634
	private bool m_ConservativeEnclosingSphere; // 0x638
	private int m_NumIterationsEnclosingSphere; // 0x63C

	// Methods

	// RVA: 0x160DD60
	public int get_cullingPlaneCount() { }

	// RVA: 0x160DD68
	public void set_cullingMask(UInt32 value) { }

	// RVA: 0x160DD70
	public void set_cullingOptions(CullingOptions value) { }

	// RVA: 0x160DD78
	public float GetLayerCullingDistance(int layerIndex) { }

	// RVA: 0x160DE5C
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x160DF9C
	public bool Equals(ScriptableCullingParameters other) { }

	// RVA: 0x160E3C0
	public override bool Equals(object obj) { }

	// RVA: 0x160E4D8
	public override int GetHashCode() { }

	// RVA: 0x160E768
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct CullingResults
{
	// Fields
	internal IntPtr ptr; // 0x10
	private CullingAllocationInfo* m_AllocationInfo; // 0x18

	// Methods

	// RVA: 0x160E7BC
	public bool Equals(CullingResults other) { }

	// RVA: 0x160E850
	public override bool Equals(object obj) { }

	// RVA: 0x160E960
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
internal struct CullingAllocationInfo
{
	// Fields
	public VisibleLight* visibleLightsPtr; // 0x10
	public VisibleLight* visibleOffscreenVertexLightsPtr; // 0x18
	public VisibleReflectionProbe* visibleReflectionProbesPtr; // 0x20
	public int visibleLightCount; // 0x28
	public int visibleOffscreenVertexLightCount; // 0x2C
	public int visibleReflectionProbeCount; // 0x30
}

// Namespace: 
public struct <shaderPassNames>e__FixedBuffer
{
	// Fields
	public int FixedElementField; // 0x10
}

// Namespace: UnityEngine.Rendering
public struct DrawingSettings
{
	// Fields
	public static readonly int maxShaderPasses; // 0x0
	private SortingSettings m_SortingSettings; // 0x10
	internal UnityEngine.Rendering.DrawingSettings.<shaderPassNames>e__FixedBuffer shaderPassNames; // 0x70
	private PerObjectData m_PerObjectData; // 0xB0
	private DrawRendererFlags m_Flags; // 0xB4
	private int m_OverrideShaderID; // 0xB8
	private int m_OverrideShaderPassIndex; // 0xBC
	private int m_OverrideMaterialInstanceId; // 0xC0
	private int m_OverrideMaterialPassIndex; // 0xC4
	private int m_fallbackMaterialInstanceId; // 0xC8
	private int m_MainLightIndex; // 0xCC
	private int m_UseSrpBatcher; // 0xD0

	// Methods

	// RVA: 0x160E994
	public void .ctor(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	// RVA: 0x160EA6C
	public ShaderTagId GetShaderPassName(int index) { }

	// RVA: 0x160EBD8
	public bool Equals(DrawingSettings other) { }

	// RVA: 0x160EEB0
	public override bool Equals(object obj) { }

	// RVA: 0x160EFF8
	public override int GetHashCode() { }

	// RVA: 0x160F1C8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
internal enum DrawRendererFlags
{
	// Fields
	public int value__; // 0x10
	public const DrawRendererFlags None = 0;
	public const DrawRendererFlags EnableDynamicBatching = 1;
	public const DrawRendererFlags EnableInstancing = 2;
}

// Namespace: UnityEngine.Rendering
public struct FilteringSettings
{
	// Fields
	private RenderQueueRange m_RenderQueueRange; // 0x10
	private int m_LayerMask; // 0x18
	private UInt32 m_RenderingLayerMask; // 0x1C
	private int m_ExcludeMotionVectorObjects; // 0x20
	private SortingLayerRange m_SortingLayerRange; // 0x24

	// Methods

	// RVA: 0x160F218
	public static FilteringSettings get_defaultValue() { }

	// RVA: 0x160F2DC
	public void .ctor(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, int layerMask, UInt32 renderingLayerMask, int excludeMotionVectorObjects) { }

	// RVA: 0x160F474
	public bool Equals(FilteringSettings other) { }

	// RVA: 0x160F580
	public override bool Equals(object obj) { }

	// RVA: 0x160F6B8
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public enum GizmoSubset
{
	// Fields
	public int value__; // 0x10
	public const GizmoSubset PreImageEffects = 0;
	public const GizmoSubset PostImageEffects = 1;
}

// Namespace: UnityEngine.Rendering
public struct LODParameters
{
	// Fields
	private int m_IsOrthographic; // 0x10
	private Vector3 m_CameraPosition; // 0x14
	private float m_FieldOfView; // 0x20
	private float m_OrthoSize; // 0x24
	private int m_CameraPixelHeight; // 0x28

	// Methods

	// RVA: 0x160F758
	public bool Equals(LODParameters other) { }

	// RVA: 0x160F800
	public override bool Equals(object obj) { }

	// RVA: 0x160F920
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public class ObjectIdRequest
{
	// Fields
	private RenderTexture <destination>k__BackingField; // 0x10

	// Methods

	// RVA: 0x160F9C0
	public RenderTexture get_destination() { }

}

// Namespace: UnityEngine.Rendering
public enum PerObjectData
{
	// Fields
	public int value__; // 0x10
	public const PerObjectData None = 0;
	public const PerObjectData LightProbe = 1;
	public const PerObjectData ReflectionProbes = 2;
	public const PerObjectData LightProbeProxyVolume = 4;
	public const PerObjectData Lightmaps = 8;
	public const PerObjectData LightData = 16;
	public const PerObjectData MotionVectors = 32;
	public const PerObjectData LightIndices = 64;
	public const PerObjectData ReflectionProbeData = 128;
	public const PerObjectData OcclusionProbe = 256;
	public const PerObjectData OcclusionProbeProxyVolume = 512;
	public const PerObjectData ShadowMask = 1024;
}

// Namespace: UnityEngine.Rendering
public enum ReflectionProbeSortingCriteria
{
	// Fields
	public int value__; // 0x10
	public const ReflectionProbeSortingCriteria None = 0;
	public const ReflectionProbeSortingCriteria Importance = 1;
	public const ReflectionProbeSortingCriteria Size = 2;
	public const ReflectionProbeSortingCriteria ImportanceThenSize = 3;
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipeline
{
	// Fields
	private bool <disposed>k__BackingField; // 0x10

	// Methods

	// RVA: -1
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x316B894
	protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	// RVA: 0x316B894
	protected internal virtual bool IsRenderRequestSupported(Camera camera, RequestData data) { }

	// RVA: 0x160F9C8
	protected virtual void Render(ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x160FA44
	internal void InternalRender(ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x316B894
	internal void InternalProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	// RVA: 0x160FAC8
	public bool get_disposed() { }

	// RVA: 0x160FAD0
	private void set_disposed(bool value) { }

	// RVA: 0x160FAD8
	internal void Dispose() { }

	// RVA: 0x160FB5C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x160FB60
	protected void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset
{
	// Methods

	// RVA: 0x160FB68
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x160FD70
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x160FD78
	public virtual string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x160FD80
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x160FD88
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x160FD90
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x160FD98
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x160FDA0
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x160FDA8
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x160FDB0
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x160FDB8
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x160FDC0
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x160FDC8
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x160FDD0
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x160FDD8
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x160FDE0
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x160FDE8
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x160FDF0
	public virtual Material get_default2DMaskMaterial() { }

	// RVA: 0x160FDF8
	public virtual Shader get_defaultShader() { }

	// RVA: 0x160FE00
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x160FE08
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: 0x160FE10
	public virtual string get_renderPipelineShaderTag() { }

	// RVA: -1
	protected abstract RenderPipeline CreatePipeline() { }

	// RVA: 0x160FEA8
	protected virtual void OnValidate() { }

	// RVA: 0x1610518
	protected virtual void OnDisable() { }

	// RVA: 0x1610580
	protected void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public static class RenderPipelineManager
{
	// Fields
	internal static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static System.Collections.Generic.List<UnityEngine.Camera> s_Cameras; // 0x8
	private static string s_CurrentPipelineType; // 0x10
	private static RenderPipeline s_CurrentPipeline; // 0x18
	private static Action activeRenderPipelineTypeChanged; // 0x20
	private static System.Action<UnityEngine.Rendering.RenderPipelineAsset,UnityEngine.Rendering.RenderPipelineAsset> activeRenderPipelineAssetChanged; // 0x28
	private static Action activeRenderPipelineCreated; // 0x30
	private static Action activeRenderPipelineDisposed; // 0x38

	// Methods

	// RVA: 0x1610588
	public static RenderPipeline get_currentPipeline() { }

	// RVA: 0x1610604
	private static void set_currentPipeline(RenderPipeline value) { }

	// RVA: 0x16106DC
	internal static void OnActiveRenderPipelineTypeChanged() { }

	// RVA: 0x161076C
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	// RVA: 0x1610894
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x160FFC4
	internal static void CleanupRenderPipeline() { }

	// RVA: 0x1610A68
	private static string GetCurrentPipelineAssetType() { }

	// RVA: 0x1610AE4
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, object renderRequest) { }

	// RVA: 0x16103AC
	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x161101C
	private static bool IsPipelineRequireCreation() { }

	// RVA: 0x1611204
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct RenderQueueRange
{
	// Fields
	private int m_LowerBound; // 0x10
	private int m_UpperBound; // 0x14
	public static readonly int minimumBound; // 0x0
	public static readonly int maximumBound; // 0x4

	// Methods

	// RVA: 0x160F2D4
	public static RenderQueueRange get_all() { }

	// RVA: 0x16112DC
	public static RenderQueueRange get_transparent() { }

	// RVA: 0x16112E8
	public int get_lowerBound() { }

	// RVA: 0x160F558
	public bool Equals(RenderQueueRange other) { }

	// RVA: 0x16112F0
	public override bool Equals(object obj) { }

	// RVA: 0x160F744
	public override int GetHashCode() { }

	// RVA: 0x16113D0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct ScriptableRenderContext
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1611424
	private static void Internal_Cull(ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x1611534
	internal static void InitializeSortSettings(Camera camera, SortingSettings sortingSettings) { }

	// RVA: 0x161159C
	private void Submit_Internal() { }

	// RVA: 0x1611698
	private void GetCameras_Internal(Type listType, object resultList) { }

	// RVA: 0x16117A4
	private void DrawRenderers_Internal(IntPtr cullResults, DrawingSettings drawingSettings, FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x1611948
	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	// RVA: 0x1611A68
	private void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x1611B8C
	private void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset) { }

	// RVA: 0x1610EDC
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1611C98
	public void Submit() { }

	// RVA: 0x1610EE4
	internal void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results) { }

	// RVA: 0x1611D8C
	public void DrawRenderers(CullingResults cullingResults, DrawingSettings drawingSettings, FilteringSettings filteringSettings) { }

	// RVA: 0x1611EEC
	public void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	// RVA: 0x1612088
	public void SetupCameraProperties(Camera camera, bool stereoSetup) { }

	// RVA: 0x16121D0
	public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x16122D4
	public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset) { }

	// RVA: 0x16123D0
	public CullingResults Cull(ScriptableCullingParameters parameters) { }

	// RVA: 0x16124E4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x161255C
	public override bool Equals(object obj) { }

	// RVA: 0x1612674
	public override int GetHashCode() { }

	// RVA: 0x161267C
	private static void .cctor() { }

	// RVA: 0x16114DC
	private static void Internal_Cull_Injected(ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x1611648
	private static void Submit_Internal_Injected(ScriptableRenderContext _unity_self) { }

	// RVA: 0x161174C
	private static void GetCameras_Internal_Injected(ScriptableRenderContext _unity_self, Type listType, object resultList) { }

	// RVA: 0x16118A8
	private static void DrawRenderers_Internal_Injected(ScriptableRenderContext _unity_self, IntPtr cullResults, DrawingSettings drawingSettings, FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x1611A00
	private static void ExecuteCommandBuffer_Internal_Injected(ScriptableRenderContext _unity_self, CommandBuffer commandBuffer) { }

	// RVA: 0x1611B24
	private static void SetupCameraProperties_Internal_Injected(ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x1611C40
	private static void DrawGizmos_Internal_Injected(ScriptableRenderContext _unity_self, Camera camera, GizmoSubset gizmoSubset) { }

}

// Namespace: UnityEngine.Rendering
public struct ShaderTagId
{
	// Fields
	public static readonly ShaderTagId none; // 0x0
	private int m_Id; // 0x10

	// Methods

	// RVA: 0x16126F0
	public void .ctor(string name) { }

	// RVA: 0x160EA64
	internal int get_id() { }

	// RVA: 0x160EBD0
	internal void set_id(int value) { }

	// RVA: 0x161271C
	public override bool Equals(object obj) { }

	// RVA: 0x160EDB0
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x16127AC
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public enum SortingCriteria
{
	// Fields
	public int value__; // 0x10
	public const SortingCriteria None = 0;
	public const SortingCriteria SortingLayer = 1;
	public const SortingCriteria RenderQueue = 2;
	public const SortingCriteria BackToFront = 4;
	public const SortingCriteria QuantizedFrontToBack = 8;
	public const SortingCriteria OptimizeStateChanges = 16;
	public const SortingCriteria CanvasOrder = 32;
	public const SortingCriteria RendererPriority = 64;
	public const SortingCriteria CommonOpaque = 59;
	public const SortingCriteria CommonTransparent = 23;
}

// Namespace: UnityEngine.Rendering
public struct SortingLayerRange
{
	// Fields
	private Int16 m_LowerBound; // 0x10
	private Int16 m_UpperBound; // 0x12

	// Methods

	// RVA: 0x160F46C
	public static SortingLayerRange get_all() { }

	// RVA: 0x16127D0
	public bool Equals(SortingLayerRange other) { }

	// RVA: 0x16127F4
	public override bool Equals(object obj) { }

	// RVA: 0x1612890
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public enum DistanceMetric
{
	// Fields
	public int value__; // 0x10
	public const DistanceMetric Perspective = 0;
	public const DistanceMetric Orthographic = 1;
	public const DistanceMetric CustomAxis = 2;
}

// Namespace: UnityEngine.Rendering
public struct SortingSettings
{
	// Fields
	private Matrix4x4 m_WorldToCameraMatrix; // 0x10
	private Vector3 m_CameraPosition; // 0x50
	private Vector3 m_CustomAxis; // 0x5C
	private SortingCriteria m_Criteria; // 0x68
	private DistanceMetric m_DistanceMetric; // 0x6C

	// Methods

	// RVA: 0x1612898
	public void .ctor(Camera camera) { }

	// RVA: 0x1612950
	public SortingCriteria get_criteria() { }

	// RVA: 0x1612958
	public void set_criteria(SortingCriteria value) { }

	// RVA: 0x160EDC0
	public bool Equals(SortingSettings other) { }

	// RVA: 0x1612960
	public override bool Equals(object obj) { }

	// RVA: 0x160F100
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public struct StencilState
{
	// Fields
	private Byte m_Enabled; // 0x10
	private Byte m_ReadMask; // 0x11
	private Byte m_WriteMask; // 0x12
	private Byte m_Padding; // 0x13
	private Byte m_CompareFunctionFront; // 0x14
	private Byte m_PassOperationFront; // 0x15
	private Byte m_FailOperationFront; // 0x16
	private Byte m_ZFailOperationFront; // 0x17
	private Byte m_CompareFunctionBack; // 0x18
	private Byte m_PassOperationBack; // 0x19
	private Byte m_FailOperationBack; // 0x1A
	private Byte m_ZFailOperationBack; // 0x1B

	// Methods

	// RVA: 0x1612A98
	public void set_enabled(bool value) { }

	// RVA: 0x1612B08
	public void set_readMask(Byte value) { }

	// RVA: 0x1612B10
	public void set_writeMask(Byte value) { }

	// RVA: 0x1612B18
	public void set_compareFunctionFront(CompareFunction value) { }

	// RVA: 0x1612B20
	public void set_passOperationFront(StencilOp value) { }

	// RVA: 0x1612B28
	public void set_failOperationFront(StencilOp value) { }

	// RVA: 0x1612B30
	public void set_zFailOperationFront(StencilOp value) { }

	// RVA: 0x1612B38
	public void set_compareFunctionBack(CompareFunction value) { }

	// RVA: 0x1612B40
	public void set_passOperationBack(StencilOp value) { }

	// RVA: 0x1612B48
	public void set_failOperationBack(StencilOp value) { }

	// RVA: 0x1612B50
	public void set_zFailOperationBack(StencilOp value) { }

	// RVA: 0x1612B58
	public bool Equals(StencilState other) { }

	// RVA: 0x1612C08
	public override bool Equals(object obj) { }

	// RVA: 0x1612D34
	public override int GetHashCode() { }

}

// Namespace: 
public enum ReflectionProbeModes
{
	// Fields
	public int value__; // 0x10
	public const ReflectionProbeModes None = 0;
	public const ReflectionProbeModes Rotation = 1;
}

// Namespace: 
public enum LightmapMixedBakeModes
{
	// Fields
	public int value__; // 0x10
	public const LightmapMixedBakeModes None = 0;
	public const LightmapMixedBakeModes IndirectOnly = 1;
	public const LightmapMixedBakeModes Subtractive = 2;
	public const LightmapMixedBakeModes Shadowmask = 4;
}

// Namespace: UnityEngine.Rendering
public class SupportedRenderingFeatures
{
	// Fields
	private static SupportedRenderingFeatures s_Active; // 0x0
	private ReflectionProbeModes <reflectionProbeModes>k__BackingField; // 0x10
	private LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; // 0x14
	private LightmapMixedBakeModes <mixedLightingModes>k__BackingField; // 0x18
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; // 0x1C
	private LightmapsMode <lightmapsModes>k__BackingField; // 0x20
	private bool <enlightenLightmapper>k__BackingField; // 0x24
	private bool <enlighten>k__BackingField; // 0x25
	private bool <lightProbeProxyVolumes>k__BackingField; // 0x26
	private bool <motionVectors>k__BackingField; // 0x27
	private bool <receiveShadows>k__BackingField; // 0x28
	private bool <reflectionProbes>k__BackingField; // 0x29
	private bool <reflectionProbesBlendDistance>k__BackingField; // 0x2A
	private bool <rendererPriority>k__BackingField; // 0x2B
	private bool <rendersUIOverlay>k__BackingField; // 0x2C
	private bool <overridesEnvironmentLighting>k__BackingField; // 0x2D
	private bool <overridesFog>k__BackingField; // 0x2E
	private bool <overridesRealtimeReflectionProbes>k__BackingField; // 0x2F
	private bool <overridesOtherLightingSettings>k__BackingField; // 0x30
	private bool <editableMaterialRenderQueue>k__BackingField; // 0x31
	private bool <overridesLODBias>k__BackingField; // 0x32
	private bool <overridesMaximumLODLevel>k__BackingField; // 0x33
	private bool <overridesEnableLODCrossFade>k__BackingField; // 0x34
	private bool <rendererProbes>k__BackingField; // 0x35
	private bool <particleSystemInstancing>k__BackingField; // 0x36
	private bool <autoAmbientProbeBaking>k__BackingField; // 0x37
	private bool <autoDefaultReflectionProbeBaking>k__BackingField; // 0x38
	private bool <overridesShadowmask>k__BackingField; // 0x39
	private bool <overridesLightProbeSystem>k__BackingField; // 0x3A
	private bool <supportsHDR>k__BackingField; // 0x3B
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; // 0x40

	// Methods

	// RVA: 0x1612E30
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0x16109F4
	public static void set_active(SupportedRenderingFeatures value) { }

	// RVA: 0x1612F9C
	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	// RVA: 0x1612FA4
	public LightmapMixedBakeModes get_mixedLightingModes() { }

	// RVA: 0x1612FAC
	public LightmapBakeType get_lightmapBakeTypes() { }

	// RVA: 0x1612FB4
	public LightmapsMode get_lightmapsModes() { }

	// RVA: 0x1612FBC
	public bool get_enlightenLightmapper() { }

	// RVA: 0x1612FC4
	public bool get_enlighten() { }

	// RVA: 0x1612FCC
	public bool get_rendersUIOverlay() { }

	// RVA: 0x1612FD4
	public bool get_autoAmbientProbeBaking() { }

	// RVA: 0x1612FDC
	public bool get_autoDefaultReflectionProbeBaking() { }

	// RVA: 0x1612FE4
	public bool get_overridesLightProbeSystem() { }

	// RVA: 0x1612FEC
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x1613200
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	// RVA: 0x1613278
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x1613434
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	// RVA: 0x16134AC
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	// RVA: 0x1613678
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	// RVA: 0x1613704
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	// RVA: 0x16137A4
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	// RVA: 0x1613824
	internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0x16138A4
	internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0x1613924
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	// RVA: 0x16139A4
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x1610958
	public void .ctor() { }

	// RVA: 0x16139C4
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct VisibleLight
{
	// Fields
	private LightType m_LightType; // 0x10
	private Color m_FinalColor; // 0x14
	private Rect m_ScreenRect; // 0x24
	private Matrix4x4 m_LocalToWorldMatrix; // 0x34
	private float m_Range; // 0x74
	private float m_SpotAngle; // 0x78
	private int m_InstanceId; // 0x7C
	private VisibleLightFlags m_Flags; // 0x80

	// Methods

	// RVA: 0x1613AAC
	public bool Equals(VisibleLight other) { }

	// RVA: 0x1613C6C
	public override bool Equals(object obj) { }

	// RVA: 0x1613D2C
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
internal enum VisibleLightFlags
{
	// Fields
	public int value__; // 0x10
	public const VisibleLightFlags IntersectsNearPlane = 1;
	public const VisibleLightFlags IntersectsFarPlane = 2;
}

// Namespace: UnityEngine.Rendering
public struct VisibleReflectionProbe
{
	// Fields
	private Bounds m_Bounds; // 0x10
	private Matrix4x4 m_LocalToWorldMatrix; // 0x28
	private Vector4 m_HdrData; // 0x68
	private Vector3 m_Center; // 0x78
	private float m_BlendDistance; // 0x84
	private int m_Importance; // 0x88
	private int m_BoxProjection; // 0x8C
	private int m_InstanceId; // 0x90
	private int m_TextureId; // 0x94

	// Methods

	// RVA: 0x1613E34
	public bool Equals(VisibleReflectionProbe other) { }

	// RVA: 0x1613FDC
	public override bool Equals(object obj) { }

	// RVA: 0x161409C
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public struct GlobalKeyword
{
	// Fields
	internal readonly string m_Name; // 0x10
	internal readonly UInt32 m_Index; // 0x18

	// Methods

	// RVA: 0x1614258
	private static UInt32 GetGlobalKeywordCount() { }

	// RVA: 0x1614298
	private static UInt32 GetGlobalKeywordIndex(string keyword) { }

	// RVA: 0x16142E8
	public void .ctor(string name) { }

	// RVA: 0x1614458
	public override string ToString() { }

}

// Namespace: UnityEngine.Rendering
public struct ShaderKeyword
{
	// Fields
	internal string m_Name; // 0x10
	internal UInt32 m_Index; // 0x18
	internal bool m_IsLocal; // 0x1C
	internal bool m_IsCompute; // 0x1D
	internal bool m_IsValid; // 0x1E

	// Methods

	// RVA: 0x1614460
	internal static UInt32 GetGlobalKeywordCount() { }

	// RVA: 0x16144A0
	internal static UInt32 GetGlobalKeywordIndex(string keyword) { }

	// RVA: 0x16144F0
	internal static void CreateGlobalKeyword(string keyword) { }

	// RVA: 0x1614540
	public void .ctor(string keywordName) { }

	// RVA: 0x1614650
	public override string ToString() { }

}

// Namespace: UnityEngine.Rendering
public enum ShaderPropertyFlags
{
	// Fields
	public int value__; // 0x10
	public const ShaderPropertyFlags None = 0;
	public const ShaderPropertyFlags HideInInspector = 1;
	public const ShaderPropertyFlags PerRendererData = 2;
	public const ShaderPropertyFlags NoScaleOffset = 4;
	public const ShaderPropertyFlags Normal = 8;
	public const ShaderPropertyFlags HDR = 16;
	public const ShaderPropertyFlags Gamma = 32;
	public const ShaderPropertyFlags NonModifiableTextureData = 64;
	public const ShaderPropertyFlags MainTexture = 128;
	public const ShaderPropertyFlags MainColor = 256;
}

// Namespace: 
internal enum Flags
{
	// Fields
	public int value__; // 0x10
	public const Flags Evaluate = 1;
	public const Flags SeekOccured = 2;
	public const Flags Loop = 4;
	public const Flags Hold = 8;
	public const Flags EffectivePlayStateDelayed = 16;
	public const Flags EffectivePlayStatePlaying = 32;
}

// Namespace: UnityEngine.Playables
public struct FrameData
{
	// Fields
	internal UInt64 m_FrameID; // 0x10
	internal Double m_DeltaTime; // 0x18
	internal float m_Weight; // 0x20
	internal float m_EffectiveWeight; // 0x24
	internal Double m_EffectiveParentDelay; // 0x28
	internal float m_EffectiveParentSpeed; // 0x30
	internal float m_EffectiveSpeed; // 0x34
	internal Flags m_Flags; // 0x38
	internal PlayableOutput m_Output; // 0x40
}

// Namespace: UnityEngine.Playables
public interface INotification
{}

// Namespace: UnityEngine.Playables
public interface INotificationReceiver
{
	// Methods

	// RVA: -1
	public abstract void OnNotify(Playable origin, INotification notification, object context) { }

}

// Namespace: UnityEngine.Playables
public interface IPlayableBehaviour
{
	// Methods

	// RVA: -1
	public abstract void OnGraphStart(Playable playable) { }

	// RVA: -1
	public abstract void OnGraphStop(Playable playable) { }

	// RVA: -1
	public abstract void OnPlayableCreate(Playable playable) { }

	// RVA: -1
	public abstract void OnPlayableDestroy(Playable playable) { }

	// RVA: -1
	public abstract void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: -1
	public abstract void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: -1
	public abstract void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: -1
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

// Namespace: UnityEngine.Playables
public struct Playable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly Playable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1614658
	public static Playable get_Null() { }

	// RVA: 0x16146D4
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x16146DC
	public PlayableHandle GetHandle() { }

	// RVA: 0x16146E8
	public bool Equals(Playable other) { }

	// RVA: 0x161488C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Playables
[Serializable]
public abstract class PlayableAsset
{
	// Methods

	// RVA: -1
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x16149E4
	public virtual Double get_duration() { }

	// RVA: 0x1614A60
	public virtual System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }

	// RVA: 0x1614ADC
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	// RVA: 0x1614C34
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x1614C68
	protected void .ctor() { }

}

// Namespace: UnityEngine.Playables
[Serializable]
public abstract class PlayableBehaviour
{
	// Methods

	// RVA: 0x1614C70
	public void .ctor() { }

	// RVA: 0x1614C78
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x1614C7C
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x1614C80
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x1614C84
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x1614C88
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1614C8C
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1614C90
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1614C94
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1614C98
	public virtual object Clone() { }

}

// Namespace: 
internal sealed class CreateOutputMethod
{
	// Methods

	// RVA: 0x1614D34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1614DD8
	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }

}

// Namespace: UnityEngine.Playables
public struct PlayableBinding
{
	// Fields
	private string m_StreamName; // 0x10
	private object m_SourceObject; // 0x18
	private Type m_SourceBindingType; // 0x20
	private CreateOutputMethod m_CreateOutputMethod; // 0x28
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly Double DefaultDuration; // 0x8

	// Methods

	// RVA: 0x1614CA0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Playables
public struct PlayableGraph
{
	// Fields
	internal IntPtr m_Handle; // 0x10
	internal UInt32 m_Version; // 0x18
}

// Namespace: UnityEngine.Playables
public struct PlayableHandle
{
	// Fields
	internal IntPtr m_Handle; // 0x10
	internal UInt32 m_Version; // 0x18
	private static readonly PlayableHandle m_Null; // 0x0

	// Methods

	// RVA: 0x30B171C
	internal bool IsPlayableOfType() { }

	// RVA: 0x1614968
	public static PlayableHandle get_Null() { }

	// RVA: 0x1614804
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x1614E20
	public override bool Equals(object p) { }

	// RVA: 0x1614F3C
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x1614FC4
	public override int GetHashCode() { }

	// RVA: 0x1614DEC
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	// RVA: 0x1614FFC
	internal bool IsValid() { }

	// RVA: 0x16150F8
	internal Type GetPlayableType() { }

	// RVA: 0x16151F4
	private static void .cctor() { }

	// RVA: 0x16150A8
	private static bool IsValid_Injected(PlayableHandle _unity_self) { }

	// RVA: 0x16151A4
	private static Type GetPlayableType_Injected(PlayableHandle _unity_self) { }

}

// Namespace: UnityEngine.Playables
public struct PlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Methods

	// RVA: 0x1615240
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x1615248
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x1615254
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x16153F8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Playables
public struct PlayableOutputHandle
{
	// Fields
	internal IntPtr m_Handle; // 0x10
	internal UInt32 m_Version; // 0x18
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Methods

	// RVA: 0x16154D4
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x1615550
	public override int GetHashCode() { }

	// RVA: 0x1615370
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x16155BC
	public override bool Equals(object p) { }

	// RVA: 0x16156D8
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x1615588
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x1615760
	private static void .cctor() { }

}

// Namespace: UnityEngine.Playables
public struct ScriptPlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
}

// Namespace: UnityEngine.Experimental.U2D
internal struct SpriteIntermediateRendererInfo
{
	// Fields
	public int SpriteID; // 0x10
	public int TextureID; // 0x14
	public int MaterialID; // 0x18
	public Color Color; // 0x1C
	public Matrix4x4 Transform; // 0x2C
	public Bounds Bounds; // 0x6C
	public int Layer; // 0x84
	public int SortingLayer; // 0x88
	public int SortingOrder; // 0x8C
	public UInt64 SceneCullingMask; // 0x90
	public IntPtr IndexData; // 0x98
	public IntPtr VertexData; // 0xA0
	public int IndexCount; // 0xA8
	public int VertexCount; // 0xAC
	public int ShaderChannelMask; // 0xB0
}

// Namespace: UnityEngine.Experimental.U2D
internal class SpriteRendererGroup
{}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightType
{
	// Fields
	public Byte value__; // 0x10
	public const LightType Directional = 0;
	public const LightType Point = 1;
	public const LightType Spot = 2;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
	public const LightType SpotPyramidShape = 5;
	public const LightType SpotBoxShape = 6;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightMode
{
	// Fields
	public Byte value__; // 0x10
	public const LightMode Realtime = 0;
	public const LightMode Mixed = 1;
	public const LightMode Baked = 2;
	public const LightMode Unknown = 3;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum FalloffType
{
	// Fields
	public Byte value__; // 0x10
	public const FalloffType InverseSquared = 0;
	public const FalloffType InverseSquaredNoRangeAttenuation = 1;
	public const FalloffType Linear = 2;
	public const FalloffType Legacy = 3;
	public const FalloffType Undefined = 4;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum AngularFalloffType
{
	// Fields
	public Byte value__; // 0x10
	public const AngularFalloffType LUT = 0;
	public const AngularFalloffType AnalyticAndInnerAngle = 1;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct LinearColor
{
	// Fields
	private float m_red; // 0x10
	private float m_green; // 0x14
	private float m_blue; // 0x18
	private float m_intensity; // 0x1C

	// Methods

	// RVA: 0x16157AC
	public float get_red() { }

	// RVA: 0x16157B4
	public void set_red(float value) { }

	// RVA: 0x1615868
	public float get_green() { }

	// RVA: 0x1615870
	public void set_green(float value) { }

	// RVA: 0x1615924
	public float get_blue() { }

	// RVA: 0x161592C
	public void set_blue(float value) { }

	// RVA: 0x16159E0
	public static LinearColor Convert(Color color, float intensity) { }

	// RVA: 0x1615C90
	public static LinearColor Black() { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DirectionalLight
{
	// Fields
	public int instanceID; // 0x10
	public bool shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 position; // 0x18
	public Quaternion orientation; // 0x24
	public LinearColor color; // 0x34
	public LinearColor indirectColor; // 0x44
	public float penumbraWidthRadian; // 0x54
	public Vector3 direction; // 0x58
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct PointLight
{
	// Fields
	public int instanceID; // 0x10
	public bool shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 position; // 0x18
	public Quaternion orientation; // 0x24
	public LinearColor color; // 0x34
	public LinearColor indirectColor; // 0x44
	public float range; // 0x54
	public float sphereRadius; // 0x58
	public FalloffType falloff; // 0x5C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct SpotLight
{
	// Fields
	public int instanceID; // 0x10
	public bool shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 position; // 0x18
	public Quaternion orientation; // 0x24
	public LinearColor color; // 0x34
	public LinearColor indirectColor; // 0x44
	public float range; // 0x54
	public float sphereRadius; // 0x58
	public float coneAngle; // 0x5C
	public float innerConeAngle; // 0x60
	public FalloffType falloff; // 0x64
	public AngularFalloffType angularFalloff; // 0x65
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct RectangleLight
{
	// Fields
	public int instanceID; // 0x10
	public bool shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 position; // 0x18
	public Quaternion orientation; // 0x24
	public LinearColor color; // 0x34
	public LinearColor indirectColor; // 0x44
	public float range; // 0x54
	public float width; // 0x58
	public float height; // 0x5C
	public FalloffType falloff; // 0x60
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DiscLight
{
	// Fields
	public int instanceID; // 0x10
	public bool shadow; // 0x14
	public LightMode mode; // 0x15
	public Vector3 position; // 0x18
	public Quaternion orientation; // 0x24
	public LinearColor color; // 0x34
	public LinearColor indirectColor; // 0x44
	public float range; // 0x54
	public float radius; // 0x58
	public FalloffType falloff; // 0x5C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct Cookie
{
	// Fields
	public int instanceID; // 0x10
	public float scale; // 0x14
	public Vector2 sizes; // 0x18
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct LightDataGI
{
	// Fields
	public int instanceID; // 0x10
	public int cookieID; // 0x14
	public float cookieScale; // 0x18
	public LinearColor color; // 0x1C
	public LinearColor indirectColor; // 0x2C
	public Quaternion orientation; // 0x3C
	public Vector3 position; // 0x4C
	public float range; // 0x58
	public float coneAngle; // 0x5C
	public float innerConeAngle; // 0x60
	public float shape0; // 0x64
	public float shape1; // 0x68
	public LightType type; // 0x6C
	public LightMode mode; // 0x6D
	public Byte shadow; // 0x6E
	public FalloffType falloff; // 0x6F

	// Methods

	// RVA: 0x1615CA4
	public void Init(DirectionalLight light, Cookie cookie) { }

	// RVA: 0x1615D14
	public void Init(PointLight light, Cookie cookie) { }

	// RVA: 0x1615D8C
	public void Init(SpotLight light, Cookie cookie) { }

	// RVA: 0x1615E08
	public void Init(RectangleLight light, Cookie cookie) { }

	// RVA: 0x1615E7C
	public void Init(DiscLight light, Cookie cookie) { }

	// RVA: 0x1615EF4
	public void InitNoBake(int lightInstanceID) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils
{
	// Methods

	// RVA: 0x1615F04
	public static LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x1615F1C
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x1615FA0
	public static float ExtractInnerCone(Light l) { }

	// RVA: 0x1615FFC
	private static Color ExtractColorTemperature(Light l) { }

	// RVA: 0x161608C
	private static void ApplyColorTemperature(Color cct, LinearColor lightColor) { }

	// RVA: 0x16160E0
	public static void Extract(Light l, DirectionalLight dir) { }

	// RVA: 0x1616334
	public static void Extract(Light l, PointLight point) { }

	// RVA: 0x16165A0
	public static void Extract(Light l, SpotLight spot) { }

	// RVA: 0x161686C
	public static void Extract(Light l, RectangleLight rect) { }

	// RVA: 0x1616AD8
	public static void Extract(Light l, DiscLight disc) { }

	// RVA: 0x1616D44
	public static void Extract(Light l, Cookie cookie) { }

}

// Namespace: 
public sealed class RequestLightsDelegate
{
	// Methods

	// RVA: 0x1617290
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x161734C
	public virtual void Invoke(Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1617360
	private static void .cctor() { }

	// RVA: 0x16173CC
	public void .ctor() { }

	// RVA: 0x16173D4
	internal void <.cctor>b__7_0(Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping
{
	// Fields
	private static readonly RequestLightsDelegate s_DefaultDelegate; // 0x0
	private static RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	// RVA: 0x1616EA0
	public static void SetDelegate(RequestLightsDelegate del) { }

	// RVA: 0x1616F50
	public static RequestLightsDelegate GetDelegate() { }

	// RVA: 0x1616FCC
	public static void ResetDelegate() { }

	// RVA: 0x1617050
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x1617120
	private static void .cctor() { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct CameraPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x1617870
	public PlayableHandle GetHandle() { }

	// RVA: 0x161787C
	public bool Equals(CameraPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct MaterialEffectPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x1617960
	public PlayableHandle GetHandle() { }

	// RVA: 0x161796C
	public bool Equals(MaterialEffectPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct TextureMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x1617A50
	public PlayableHandle GetHandle() { }

	// RVA: 0x1617A5C
	public bool Equals(TextureMixerPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct TexturePlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
}

// Namespace: UnityEngine.Experimental.Rendering
internal class BuiltinRuntimeReflectionSystem
{
	// Methods

	// RVA: 0x1617B40
	public bool TickRealtimeProbes() { }

	// RVA: 0x1617BC0
	public void Dispose() { }

	// RVA: 0x1617BC4
	private void Dispose(bool disposing) { }

	// RVA: 0x1617B80
	private static bool BuiltinUpdate() { }

	// RVA: 0x1617BC8
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	// RVA: 0x1617C20
	public void .ctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
public interface IScriptableRuntimeReflectionSystem
{
	// Methods

	// RVA: -1
	public abstract bool TickRealtimeProbes() { }

}

// Namespace: UnityEngine.Experimental.Rendering
public static class ScriptableRuntimeReflectionSystemSettings
{
	// Fields
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; // 0x0

	// Methods

	// RVA: 0x1617C28
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0x1617D9C
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	// RVA: 0x1617E18
	private static void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0x1617E58
	private static void .cctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
internal class ScriptableRuntimeReflectionSystemWrapper
{
	// Fields
	private IScriptableRuntimeReflectionSystem <implementation>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1617EE8
	internal IScriptableRuntimeReflectionSystem get_implementation() { }

	// RVA: 0x1617EF0
	internal void set_implementation(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0x1617EF8
	private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(bool result) { }

	// RVA: 0x1617EE0
	public void .ctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
public enum TextureCreationFlags
{
	// Fields
	public int value__; // 0x10
	public const TextureCreationFlags None = 0;
	public const TextureCreationFlags MipChain = 1;
	public const TextureCreationFlags DontInitializePixels = 4;
	public const TextureCreationFlags Crunch = 64;
	public const TextureCreationFlags DontUploadUponCreate = 1024;
	public const TextureCreationFlags IgnoreMipmapLimit = 2048;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum FormatUsage
{
	// Fields
	public int value__; // 0x10
	public const FormatUsage Sample = 0;
	public const FormatUsage Linear = 1;
	public const FormatUsage Sparse = 2;
	public const FormatUsage Render = 4;
	public const FormatUsage Blend = 5;
	public const FormatUsage GetPixels = 6;
	public const FormatUsage SetPixels = 7;
	public const FormatUsage SetPixels32 = 8;
	public const FormatUsage ReadPixels = 9;
	public const FormatUsage LoadStore = 10;
	public const FormatUsage MSAA2x = 11;
	public const FormatUsage MSAA4x = 12;
	public const FormatUsage MSAA8x = 13;
	public const FormatUsage StencilSampling = 16;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum DefaultFormat
{
	// Fields
	public int value__; // 0x10
	public const DefaultFormat LDR = 0;
	public const DefaultFormat HDR = 1;
	public const DefaultFormat DepthStencil = 2;
	public const DefaultFormat Shadow = 3;
	public const DefaultFormat Video = 4;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum GraphicsFormat
{
	// Fields
	public int value__; // 0x10
	public const GraphicsFormat None = 0;
	public const GraphicsFormat R8_SRGB = 1;
	public const GraphicsFormat R8G8_SRGB = 2;
	public const GraphicsFormat R8G8B8_SRGB = 3;
	public const GraphicsFormat R8G8B8A8_SRGB = 4;
	public const GraphicsFormat R8_UNorm = 5;
	public const GraphicsFormat R8G8_UNorm = 6;
	public const GraphicsFormat R8G8B8_UNorm = 7;
	public const GraphicsFormat R8G8B8A8_UNorm = 8;
	public const GraphicsFormat R8_SNorm = 9;
	public const GraphicsFormat R8G8_SNorm = 10;
	public const GraphicsFormat R8G8B8_SNorm = 11;
	public const GraphicsFormat R8G8B8A8_SNorm = 12;
	public const GraphicsFormat R8_UInt = 13;
	public const GraphicsFormat R8G8_UInt = 14;
	public const GraphicsFormat R8G8B8_UInt = 15;
	public const GraphicsFormat R8G8B8A8_UInt = 16;
	public const GraphicsFormat R8_SInt = 17;
	public const GraphicsFormat R8G8_SInt = 18;
	public const GraphicsFormat R8G8B8_SInt = 19;
	public const GraphicsFormat R8G8B8A8_SInt = 20;
	public const GraphicsFormat R16_UNorm = 21;
	public const GraphicsFormat R16G16_UNorm = 22;
	public const GraphicsFormat R16G16B16_UNorm = 23;
	public const GraphicsFormat R16G16B16A16_UNorm = 24;
	public const GraphicsFormat R16_SNorm = 25;
	public const GraphicsFormat R16G16_SNorm = 26;
	public const GraphicsFormat R16G16B16_SNorm = 27;
	public const GraphicsFormat R16G16B16A16_SNorm = 28;
	public const GraphicsFormat R16_UInt = 29;
	public const GraphicsFormat R16G16_UInt = 30;
	public const GraphicsFormat R16G16B16_UInt = 31;
	public const GraphicsFormat R16G16B16A16_UInt = 32;
	public const GraphicsFormat R16_SInt = 33;
	public const GraphicsFormat R16G16_SInt = 34;
	public const GraphicsFormat R16G16B16_SInt = 35;
	public const GraphicsFormat R16G16B16A16_SInt = 36;
	public const GraphicsFormat R32_UInt = 37;
	public const GraphicsFormat R32G32_UInt = 38;
	public const GraphicsFormat R32G32B32_UInt = 39;
	public const GraphicsFormat R32G32B32A32_UInt = 40;
	public const GraphicsFormat R32_SInt = 41;
	public const GraphicsFormat R32G32_SInt = 42;
	public const GraphicsFormat R32G32B32_SInt = 43;
	public const GraphicsFormat R32G32B32A32_SInt = 44;
	public const GraphicsFormat R16_SFloat = 45;
	public const GraphicsFormat R16G16_SFloat = 46;
	public const GraphicsFormat R16G16B16_SFloat = 47;
	public const GraphicsFormat R16G16B16A16_SFloat = 48;
	public const GraphicsFormat R32_SFloat = 49;
	public const GraphicsFormat R32G32_SFloat = 50;
	public const GraphicsFormat R32G32B32_SFloat = 51;
	public const GraphicsFormat R32G32B32A32_SFloat = 52;
	public const GraphicsFormat B8G8R8_SRGB = 56;
	public const GraphicsFormat B8G8R8A8_SRGB = 57;
	public const GraphicsFormat B8G8R8_UNorm = 58;
	public const GraphicsFormat B8G8R8A8_UNorm = 59;
	public const GraphicsFormat B8G8R8_SNorm = 60;
	public const GraphicsFormat B8G8R8A8_SNorm = 61;
	public const GraphicsFormat B8G8R8_UInt = 62;
	public const GraphicsFormat B8G8R8A8_UInt = 63;
	public const GraphicsFormat B8G8R8_SInt = 64;
	public const GraphicsFormat B8G8R8A8_SInt = 65;
	public const GraphicsFormat R4G4B4A4_UNormPack16 = 66;
	public const GraphicsFormat B4G4R4A4_UNormPack16 = 67;
	public const GraphicsFormat R5G6B5_UNormPack16 = 68;
	public const GraphicsFormat B5G6R5_UNormPack16 = 69;
	public const GraphicsFormat R5G5B5A1_UNormPack16 = 70;
	public const GraphicsFormat B5G5R5A1_UNormPack16 = 71;
	public const GraphicsFormat A1R5G5B5_UNormPack16 = 72;
	public const GraphicsFormat E5B9G9R9_UFloatPack32 = 73;
	public const GraphicsFormat B10G11R11_UFloatPack32 = 74;
	public const GraphicsFormat A2B10G10R10_UNormPack32 = 75;
	public const GraphicsFormat A2B10G10R10_UIntPack32 = 76;
	public const GraphicsFormat A2B10G10R10_SIntPack32 = 77;
	public const GraphicsFormat A2R10G10B10_UNormPack32 = 78;
	public const GraphicsFormat A2R10G10B10_UIntPack32 = 79;
	public const GraphicsFormat A2R10G10B10_SIntPack32 = 80;
	public const GraphicsFormat A2R10G10B10_XRSRGBPack32 = 81;
	public const GraphicsFormat A2R10G10B10_XRUNormPack32 = 82;
	public const GraphicsFormat R10G10B10_XRSRGBPack32 = 83;
	public const GraphicsFormat R10G10B10_XRUNormPack32 = 84;
	public const GraphicsFormat A10R10G10B10_XRSRGBPack32 = 85;
	public const GraphicsFormat A10R10G10B10_XRUNormPack32 = 86;
	public const GraphicsFormat D16_UNorm = 90;
	public const GraphicsFormat D24_UNorm = 91;
	public const GraphicsFormat D24_UNorm_S8_UInt = 92;
	public const GraphicsFormat D32_SFloat = 93;
	public const GraphicsFormat D32_SFloat_S8_UInt = 94;
	public const GraphicsFormat S8_UInt = 95;
	public const GraphicsFormat RGB_DXT1_SRGB = 96;
	public const GraphicsFormat RGBA_DXT1_SRGB = 96;
	public const GraphicsFormat RGB_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT3_SRGB = 98;
	public const GraphicsFormat RGBA_DXT3_UNorm = 99;
	public const GraphicsFormat RGBA_DXT5_SRGB = 100;
	public const GraphicsFormat RGBA_DXT5_UNorm = 101;
	public const GraphicsFormat R_BC4_UNorm = 102;
	public const GraphicsFormat R_BC4_SNorm = 103;
	public const GraphicsFormat RG_BC5_UNorm = 104;
	public const GraphicsFormat RG_BC5_SNorm = 105;
	public const GraphicsFormat RGB_BC6H_UFloat = 106;
	public const GraphicsFormat RGB_BC6H_SFloat = 107;
	public const GraphicsFormat RGBA_BC7_SRGB = 108;
	public const GraphicsFormat RGBA_BC7_UNorm = 109;
	public const GraphicsFormat RGB_PVRTC_2Bpp_SRGB = 110;
	public const GraphicsFormat RGB_PVRTC_2Bpp_UNorm = 111;
	public const GraphicsFormat RGB_PVRTC_4Bpp_SRGB = 112;
	public const GraphicsFormat RGB_PVRTC_4Bpp_UNorm = 113;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_SRGB = 114;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_UNorm = 115;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_SRGB = 116;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_UNorm = 117;
	public const GraphicsFormat RGB_ETC_UNorm = 118;
	public const GraphicsFormat RGB_ETC2_SRGB = 119;
	public const GraphicsFormat RGB_ETC2_UNorm = 120;
	public const GraphicsFormat RGB_A1_ETC2_SRGB = 121;
	public const GraphicsFormat RGB_A1_ETC2_UNorm = 122;
	public const GraphicsFormat RGBA_ETC2_SRGB = 123;
	public const GraphicsFormat RGBA_ETC2_UNorm = 124;
	public const GraphicsFormat R_EAC_UNorm = 125;
	public const GraphicsFormat R_EAC_SNorm = 126;
	public const GraphicsFormat RG_EAC_UNorm = 127;
	public const GraphicsFormat RG_EAC_SNorm = 128;
	public const GraphicsFormat RGBA_ASTC4X4_SRGB = 129;
	public const GraphicsFormat RGBA_ASTC4X4_UNorm = 130;
	public const GraphicsFormat RGBA_ASTC5X5_SRGB = 131;
	public const GraphicsFormat RGBA_ASTC5X5_UNorm = 132;
	public const GraphicsFormat RGBA_ASTC6X6_SRGB = 133;
	public const GraphicsFormat RGBA_ASTC6X6_UNorm = 134;
	public const GraphicsFormat RGBA_ASTC8X8_SRGB = 135;
	public const GraphicsFormat RGBA_ASTC8X8_UNorm = 136;
	public const GraphicsFormat RGBA_ASTC10X10_SRGB = 137;
	public const GraphicsFormat RGBA_ASTC10X10_UNorm = 138;
	public const GraphicsFormat RGBA_ASTC12X12_SRGB = 139;
	public const GraphicsFormat RGBA_ASTC12X12_UNorm = 140;
	public const GraphicsFormat YUV2 = 141;
	public const GraphicsFormat DepthAuto = 142;
	public const GraphicsFormat ShadowAuto = 143;
	public const GraphicsFormat VideoAuto = 144;
	public const GraphicsFormat RGBA_ASTC4X4_UFloat = 145;
	public const GraphicsFormat RGBA_ASTC5X5_UFloat = 146;
	public const GraphicsFormat RGBA_ASTC6X6_UFloat = 147;
	public const GraphicsFormat RGBA_ASTC8X8_UFloat = 148;
	public const GraphicsFormat RGBA_ASTC10X10_UFloat = 149;
	public const GraphicsFormat RGBA_ASTC12X12_UFloat = 150;
	public const GraphicsFormat D16_UNorm_S8_UInt = 151;
}

// Namespace: UnityEngine.Experimental.Rendering
public class GraphicsFormatUtility
{
	// Fields
	private static readonly GraphicsFormat[] tableNoStencil; // 0x0
	private static readonly GraphicsFormat[] tableStencil; // 0x8

	// Methods

	// RVA: 0x1617FCC
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x1618084
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x16180EC
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x16181A4
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x161820C
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x161832C
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	// RVA: 0x161837C
	internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits) { }

	// RVA: 0x1618428
	public static int GetDepthBits(GraphicsFormat format) { }

	// RVA: 0x1618478
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	// RVA: 0x16186A8
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	// RVA: 0x16186F8
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	// RVA: 0x1618748
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	// RVA: 0x1618798
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	// RVA: 0x16187E8
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	// RVA: 0x1618838
	public static bool IsCompressedFormat(TextureFormat format) { }

	// RVA: 0x16188E4
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	// RVA: 0x161894C
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	// RVA: 0x1618A00
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	// RVA: 0x1618A50
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	// RVA: 0x1618AA0
	public static bool IsCrunchFormat(TextureFormat format) { }

	// RVA: 0x1618AF0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Assertions
public static class Assert
{
	// Fields
	public static bool raiseExceptions; // 0x0

	// Methods

	// RVA: 0x1618BE0
	private static void Fail(string message, string userMessage) { }

	// RVA: 0x1618DBC
	public static void IsTrue(bool condition) { }

	// RVA: 0x1618EA0
	public static void IsTrue(bool condition, string message) { }

	// RVA: 0x1619000
	public static void IsFalse(bool condition, string message) { }

	// RVA: 0x316B894
	public static void AreEqual(T expected, T actual) { }

	// RVA: 0x316B894
	public static void AreEqual(T expected, T actual, string message) { }

	// RVA: 0x316B894
	public static void AreEqual(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer) { }

	// RVA: 0x16190A4
	public static void AreEqual(object expected, object actual, string message) { }

	// RVA: 0x316B894
	public static void IsNull(T value) { }

	// RVA: 0x316B894
	public static void IsNull(T value, string message) { }

	// RVA: 0x16193C4
	public static void IsNull(object value, string message) { }

	// RVA: 0x316B894
	public static void IsNotNull(T value) { }

	// RVA: 0x316B894
	public static void IsNotNull(T value, string message) { }

	// RVA: 0x1619638
	public static void IsNotNull(object value, string message) { }

	// RVA: 0x161972C
	public static void AreEqual(int expected, int actual) { }

	// RVA: 0x16197E4
	private static void .cctor() { }

}

// Namespace: UnityEngine.Assertions
public class AssertionException
{
	// Fields
	private string m_UserMessage; // 0x90

	// Methods

	// RVA: 0x1618D34
	public void .ctor(string message, string userMessage) { }

	// RVA: 0x1619834
	public override string get_Message() { }

}

// Namespace: UnityEngine.Assertions
internal class AssertionMessageUtil
{
	// Methods

	// RVA: 0x16198A8
	public static string GetMessage(string failureMessage) { }

	// RVA: 0x16199B4
	public static string GetMessage(string failureMessage, string expected) { }

	// RVA: 0x1619198
	public static string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	// RVA: 0x16194B8
	public static string NullFailureMessage(object value, bool expectNull) { }

	// RVA: 0x1618F44
	public static string BooleanFailureMessage(bool expected) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=6
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=20
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=6 0EBBFED81071BF15F38AA1387D6D74E5788591B4AA6E85C7B739CF903789D438; // 0x0
	internal static readonly __StaticArrayInitTypeSize=20 39D974909C7E64675317DD1A8583B8D8DE92E68B180532FADD22B482AD93DC83; // 0x6
	internal static readonly __StaticArrayInitTypeSize=20 C77A066B9EC0272B121AD30CBAEDA4AD20F986D49CC6D0007EBF45888D8B09BF; // 0x1A
}


