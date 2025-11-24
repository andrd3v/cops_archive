// Namespace: 
internal class <Module> 
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute 
{
	// Methods

	// RVA: 0x14BC6E8
	void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsUnmanagedAttribute 
{
	// Methods

	// RVA: 0x14BC6F0
	void .ctor() { }

}

// Namespace: AOT
public class MonoPInvokeCallbackAttribute 
{
	// Methods

	// RVA: 0x14BC6F8
	void .ctor(Type type) { }

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

	// RVA: 0x14BC700
	void .cctor() { }

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
public class TypeInferenceRuleAttribute 
{
	// Fields
	private readonly string _rule; // 0x10

	// Methods

	// RVA: 0x14BC76C
	void .ctor(TypeInferenceRules rule) { }

	// RVA: 0x14BC800
	void .ctor(string rule) { }

	// RVA: 0x14BC834
	string ToString() { }

}

// Namespace: UnityEngineInternal
public class GenericStack 
{
	// Methods

	// RVA: 0x14BC83C
	void .ctor() { }

}

// Namespace: Unity.Jobs
public interface IJob 
{
	// Methods

	// RVA: 0x2FE41A8
	void Execute() { }

}

// Namespace: 
internal sealed class ExecuteJobFunction 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: -1
	internal void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

}

// Namespace: 
internal struct JobStruct<T0> 
{
	// Fields
	internal static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr> jobReflectionData; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void Initialize() { }

	// RVA: 0x2FEA854
	void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: Unity.Jobs
public static class IJobExtensions 
{
	// Methods

	// RVA: 0x2FE8AB8
	void EarlyJobInit() { }

}

// Namespace: Unity.Jobs
public interface IJobParallelFor 
{
	// Methods

	// RVA: 0x2FE42A4
	void Execute(int index) { }

}

// Namespace: 
public sealed class ExecuteJobFunction 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: -1
	internal void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

}

// Namespace: 
internal struct ParallelForJobStruct<T0> 
{
	// Fields
	internal static readonly Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<System.IntPtr> jobReflectionData; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void Initialize() { }

	// RVA: 0x2FEA854
	void Execute(ref T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: Unity.Jobs
public static class IJobParallelForExtensions 
{
	// Methods

	// RVA: 0x2FE6BF4
	IntPtr GetReflectionData() { }

	// RVA: 0x309AF8C
	JobHandle Schedule(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }

}

// Namespace: Unity.Jobs
public struct JobHandle 
{
	// Fields
	internal UInt64 jobGroup; // 0x10
	internal int version; // 0x18

	// Methods

	// RVA: 0x14BC844
	void Complete() { }

	// RVA: 0x14BC8F8
	void ScheduleBatchedJobs() { }

	// RVA: 0x14BC8A8
	void ScheduleBatchedJobsAndComplete(ref JobHandle job) { }

	// RVA: 0x14BC938
	JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs) { }

	// RVA: 0x14BCA44
	JobHandle CombineDependencies(Unity.Collections.NativeSlice<Unity.Jobs.JobHandle> jobs) { }

	// RVA: 0x14BC9DC
	JobHandle CombineDependenciesInternalPtr(Void* jobs, int count) { }

	// RVA: 0x14BCB70
	bool Equals(JobHandle other) { }

	// RVA: 0x14BCB18
	void CombineDependenciesInternalPtr_Injected(Void* jobs, int count, out JobHandle ret) { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public sealed class JobProducerTypeAttribute 
{
	// Fields
	private readonly Type <ProducerType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x14BCB80
	void .ctor(Type producerType) { }

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

	// RVA: 0x14BCE38
	void .ctor(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

// Namespace: 
internal sealed class PanicFunction_ 
{
	// Methods

	// RVA: 0x14BCE7C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BCF1C
	internal void Invoke() { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public static class JobsUtility 
{
	// Fields
	internal static PanicFunction_ PanicFunction; // 0x0

	// Methods

	// RVA: 0x14BCBB4
	bool GetWorkStealingRange(ref JobRanges ranges, int jobIndex, out int beginIndex, out int endIndex) { }

	// RVA: 0x14BCC1C
	JobHandle ScheduleParallelFor(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	// RVA: 0x14BCCF4
	IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x14BCD64
	IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x14BCDD0
	void InvokePanicFunction() { }

	// RVA: 0x14BCC8C
	void ScheduleParallelFor_Injected(ref JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, out JobHandle ret) { }

}

// Namespace: Unity.IL2CPP.CompilerServices
internal class Il2CppEagerStaticClassConstructionAttribute 
{
	// Methods

	// RVA: 0x14BCF30
	void .ctor() { }

}

// Namespace: Unity.Profiling
public sealed class IgnoredByDeepProfilerAttribute 
{
	// Methods

	// RVA: 0x14BCF38
	void .ctor() { }

}

// Namespace: Unity.Profiling
public struct ProfilerCategory 
{
	// Fields
	private readonly UInt16 m_CategoryId; // 0x10

	// Methods

	// RVA: 0x14BCF40
	void .ctor(UInt16 category) { }

	// RVA: 0x14BCF48
	string get_Name() { }

	// RVA: 0x14BD164
	string ToString() { }

	// RVA: 0x14BD1F4
	ProfilerCategory get_Scripts() { }

	// RVA: 0x14BD1FC
	UInt16 op_Implicit(ProfilerCategory category) { }

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

	// RVA: 0x14BD4CC
	void .ctor(IntPtr markerPtr) { }

	// RVA: 0x14BD540
	void Dispose() { }

}

// Namespace: Unity.Profiling
public struct ProfilerMarker 
{
	// Fields
	internal readonly IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x14BD204
	void .ctor(string name) { }

	// RVA: 0x14BD2CC
	void .ctor(ProfilerCategory category, string name) { }

	// RVA: 0x14BD330
	void Begin() { }

	// RVA: 0x14BD3D0
	void End() { }

	// RVA: 0x14BD470
	AutoScope Auto() { }

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

	// RVA: 0x14BD5B4
	void set_RawImageDataReference(Unity.Collections.NativeArray<System.Byte> value) { }

	// RVA: 0x14BD5BC
	void set_ImageFormat(TextureFormat value) { }

	// RVA: 0x14BD5C4
	void set_Width(int value) { }

	// RVA: 0x14BD5CC
	void set_Height(int value) { }

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

	// RVA: 0x14BD5D4
	UInt16 CreateCategory__Unmanaged(Byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	// RVA: 0x14BCFD8
	ProfilerCategoryDescription GetCategoryDescription(UInt16 categoryId) { }

	// RVA: 0x14BD264
	IntPtr CreateMarker(string name, UInt16 categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x14BD694
	IntPtr CreateMarker__Unmanaged(Byte* name, int nameLen, UInt16 categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x14BD704
	void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, Byte* name, int nameLen, Byte type, Byte unit) { }

	// RVA: 0x14BD380
	void BeginSample(IntPtr markerPtr) { }

	// RVA: 0x14BD420
	void EndSample(IntPtr markerPtr) { }

	// RVA: 0x14BD784
	Void* CreateCounterValue__Unmanaged(out IntPtr counterPtr, Byte* name, int nameLen, UInt16 categoryId, MarkerFlags flags, Byte dataType, Byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	// RVA: 0x14BD078
	string Utf8ToString(Byte* chars, int charsLen) { }

	// RVA: 0x14BD62C
	void GetCategoryDescription_Injected(UInt16 categoryId, out ProfilerCategoryDescription ret) { }

}

// Namespace: Unity.Profiling.Memory
public class MemorySnapshotMetadata 
{
	// Fields
	private string <Description>k__BackingField; // 0x10
	private Byte[] <Data>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14BD824
	string get_Description() { }

	// RVA: 0x14BD82C
	void set_Description(string value) { }

	// RVA: 0x14BD834
	Byte[] get_Data() { }

	// RVA: 0x14BD83C
	void .ctor() { }

}

// Namespace: Unity.Profiling.Memory
public static class MemoryProfiler 
{
	// Fields
	private static System.Action<System.String,System.Boolean> m_SnapshotFinished; // 0x0
	private static System.Action<System.String,System.Boolean,Unity.Profiling.DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	private static System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> CreatingMetadata; // 0x10

	// Methods

	// RVA: 0x14BD844
	Byte[] PrepareMetadata() { }

	// RVA: 0x14BDB44
	int WriteIntToByteArray(Byte[] array, int offset, int value) { }

	// RVA: 0x14BDBDC
	int WriteStringToByteArray(Byte[] array, int offset, string value) { }

	// RVA: 0x14BDCE0
	void FinalizeSnapshot(string path, bool result) { }

	// RVA: 0x14BDD78
	void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

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

	// RVA: 0x2FE4574
	void .ctor(ref Unity.Collections.NativeArray<T>& array) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x309AF8C
	T get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private ReadOnly m_Array; // 0x0
	private int m_Index; // 0x0
	private T value; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(in ReadOnly array) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x309AF8C
	T get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct ReadOnly 
{
	// Fields
	internal Void* m_Buffer; // 0x0
	internal int m_Length; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(Void* buffer, int length) { }

	// RVA: 0x2FE32D4
	int get_Length() { }

	// RVA: 0x309AF8C
	T get_Item(int index) { }

	// RVA: 0x309AF8C
	Enumerator GetEnumerator() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

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
	void .ctor(int length, Allocator allocator, NativeArrayOptions options) { }

	// RVA: 0x2FE45DC
	void .ctor(T[] array, Allocator allocator) { }

	// RVA: -1
	void Allocate(int length, Allocator allocator, out Unity.Collections.NativeArray<T>& array) { }

	// RVA: 0x2FE32D4
	int get_Length() { }

	// RVA: 0x309AF8C
	T get_Item(int index) { }

	// RVA: 0x309AF8C
	void set_Item(int index, T value) { }

	// RVA: 0x2FE3054
	bool get_IsCreated() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x309AF8C
	void CopyFrom(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x2FE360C
	T[] ToArray() { }

	// RVA: 0x309AF8C
	Enumerator GetEnumerator() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	bool Equals(Unity.Collections.NativeArray<T> other) { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

	// RVA: 0x309AF8C
	void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst) { }

	// RVA: 0x309AF8C
	void Copy(T[] src, Unity.Collections.NativeArray<T> dst) { }

	// RVA: 0x309AF8C
	void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length) { }

	// RVA: 0x309AF8C
	void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x309AF8C
	void Copy(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x309AF8C
	void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x309AF8C
	void CopySafe(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x309AF8C
	void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	// RVA: 0x309AF8C
	ReadOnly AsReadOnly() { }

}

// Namespace: Unity.Collections
internal struct NativeArrayDispose 
{
	// Fields
	internal Void* m_Buffer; // 0x10
	internal Allocator m_AllocatorLabel; // 0x18

	// Methods

	// RVA: 0x14BDE88
	void Dispose() { }

}

// Namespace: Unity.Collections
internal struct NativeArrayDisposeJob 
{
	// Fields
	internal NativeArrayDispose Data; // 0x10

	// Methods

	// RVA: 0x14BDF58
	void Execute() { }

	// RVA: 0x14BDFC0
	void RegisterNativeArrayDisposeJobReflectionData() { }

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

	// RVA: 0x309AF8C
	Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeArray<T> thisArray, int start, int length) { }

	// RVA: 0x309AF8C
	Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeSlice<T> thisSlice, int start, int length) { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private Unity.Collections.NativeSlice<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(ref Unity.Collections.NativeSlice<T>& array) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void Reset() { }

	// RVA: 0x309AF8C
	T get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: Unity.Collections
public struct NativeSlice<T0> 
{
	// Fields
	internal Byte* m_Buffer; // 0x0
	internal int m_Stride; // 0x0
	internal int m_Length; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(Unity.Collections.NativeSlice<T> slice, int start, int length) { }

	// RVA: 0x309AF8C
	void .ctor(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x309AF8C
	Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x309AF8C
	void .ctor(Unity.Collections.NativeArray<T> array, int start, int length) { }

	// RVA: 0x309AF8C
	T get_Item(int index) { }

	// RVA: 0x309AF8C
	void set_Item(int index, T value) { }

	// RVA: 0x309AF8C
	void CopyFrom(Unity.Collections.NativeSlice<T> slice) { }

	// RVA: 0x2FE4574
	void CopyFrom(T[] array) { }

	// RVA: 0x2FE32D4
	int get_Stride() { }

	// RVA: 0x2FE32D4
	int get_Length() { }

	// RVA: 0x309AF8C
	Enumerator GetEnumerator() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	bool Equals(Unity.Collections.NativeSlice<T> other) { }

	// RVA: 0x2FE3174
	bool Equals(object obj) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

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

	// RVA: 0x309AF8C
	void .ctor(Void* buffer) { }

	// RVA: 0x2FE360C
	ref T get_Data() { }

	// RVA: 0x309AF8C
	Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate(UInt32 alignment) { }

}

// Namespace: 
internal static class SharedStatic 
{
	// Methods

	// RVA: 0x14BE004
	Void* GetOrCreateSharedStaticInternal(Int64 getHashCode64, Int64 getSubHashCode64, UInt32 sizeOf, UInt32 alignment) { }

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

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstRuntime 
{
	// Methods

	// RVA: 0x2FE69E4
	Int64 GetHashCode64() { }

	// RVA: 0x14BE0DC
	Int64 HashStringWithFNV1A64(string text) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerAttribute 
{
	// Methods

	// RVA: 0x14BE16C
	void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsReadOnlyAttribute 
{
	// Methods

	// RVA: 0x14BE174
	void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsAtomicWriteOnlyAttribute 
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute 
{
	// Methods

	// RVA: 0x14BE17C
	void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute 
{
	// Methods

	// RVA: 0x14BE184
	void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeferredConvertListToArray 
{
	// Methods

	// RVA: 0x14BE18C
	void .ctor() { }

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

	// RVA: 0x14BE194
	void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableUnsafePtrRestrictionAttribute 
{
	// Methods

	// RVA: 0x14BE19C
	void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableContainerSafetyRestrictionAttribute 
{
	// Methods

	// RVA: 0x14BE1A4
	void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeSetClassTypeToNullOnScheduleAttribute 
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeArrayUnsafeUtility 
{
	// Methods

	// RVA: 0x309AF8C
	Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, Allocator allocator) { }

	// RVA: 0x309AF8C
	Void* GetUnsafePtr(Unity.Collections.NativeArray<T> nativeArray) { }

	// RVA: 0x309AF8C
	Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeArray<T> nativeArray) { }

	// RVA: 0x309AF8C
	Void* GetUnsafeBufferPointerWithoutChecks(Unity.Collections.NativeArray<T> nativeArray) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeSliceUnsafeUtility 
{
	// Methods

	// RVA: 0x309AF8C
	Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice(Void* dataPointer, int stride, int length) { }

	// RVA: 0x309AF8C
	Void* GetUnsafePtr(Unity.Collections.NativeSlice<T> nativeSlice) { }

	// RVA: 0x309AF8C
	Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeSlice<T> nativeSlice) { }

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

	// RVA: 0x14BE1AC
	Void* MallocTracked(Int64 size, int alignment, Allocator allocator, int callstacksToSkip) { }

	// RVA: 0x14BDEF0
	void FreeTracked(Void* memory, Allocator allocator) { }

	// RVA: 0x14BE214
	Void* Malloc(Int64 size, int alignment, Allocator allocator) { }

	// RVA: 0x14BE26C
	void Free(Void* memory, Allocator allocator) { }

	// RVA: 0x14BDC88
	void MemCpy(Void* destination, Void* source, Int64 size) { }

	// RVA: 0x14BE2D4
	void MemCpyStride(Void* destination, int destinationStride, Void* source, int sourceStride, int elementSize, int count) { }

	// RVA: 0x14BE354
	void MemMove(Void* destination, Void* source, Int64 size) { }

	// RVA: 0x14BE3AC
	void MemSet(Void* destination, Byte value, Int64 size) { }

	// RVA: 0x14BE404
	void MemClear(Void* destination, Int64 size) { }

	// RVA: 0x14BE458
	int MemCmp(Void* ptr1, Void* ptr2, Int64 size) { }

	// RVA: 0x14BE4B0
	bool IsBlittable(Type type) { }

	// RVA: 0x14BE500
	bool IsBlittableValueType(Type t) { }

	// RVA: 0x14BE570
	string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x14BE78C
	bool IsArrayBlittable(Array arr) { }

	// RVA: 0x14BE81C
	string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: 0x2FE5D84
	int AlignOf() { }

	// RVA: 0x309AF8C
	T ReadArrayElement(Void* source, int index) { }

	// RVA: 0x309AF8C
	T ReadArrayElementWithStride(Void* source, int index, int stride) { }

	// RVA: 0x309AF8C
	void WriteArrayElement(Void* destination, int index, T value) { }

	// RVA: 0x309AF8C
	void WriteArrayElementWithStride(Void* destination, int index, int stride, T value) { }

	// RVA: 0x309AF8C
	Void* AddressOf(ref T output) { }

	// RVA: 0x2FE5D84
	int SizeOf() { }

	// RVA: 0x2FE7084
	ref T As(ref U from) { }

	// RVA: 0x309AF8C
	ref T AsRef(Void* ptr) { }

	// RVA: 0x309AF8C
	int EnumToInt(T enumValue) { }

	// RVA: 0x2FEAB7C
	void InternalEnumToInt(ref T enumValue, ref int intValue) { }

	// RVA: 0x309AF8C
	bool EnumEquals(T lhs, T rhs) { }

}

// Namespace: Unity.Burst
public class BurstDiscardAttribute 
{
	// Methods

	// RVA: 0x14BE874
	void .ctor() { }

}

// Namespace: Unity.Burst.LowLevel
internal static class BurstCompilerService 
{
	// Methods

	// RVA: 0x14BE084
	Void* GetOrCreateSharedMemory(ref Hash128 key, UInt32 size_of, UInt32 alignment) { }

}

// Namespace: JetBrains.Annotations
public sealed class CanBeNullAttribute 
{
	// Methods

	// RVA: 0x14BE87C
	void .ctor() { }

}

// Namespace: JetBrains.Annotations
public sealed class NotNullAttribute 
{
	// Methods

	// RVA: 0x14BE884
	void .ctor() { }

}

// Namespace: JetBrains.Annotations
public sealed class PureAttribute 
{
	// Methods

	// RVA: 0x14BE88C
	void .ctor() { }

}

// Namespace: UnityEngine
public struct SortingLayer 
{
	// Fields
	private int m_Id; // 0x10

	// Methods

	// RVA: 0x14BE894
	int GetLayerValueFromID(int id) { }

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

	// RVA: 0x14BE8E4
	void .ctor(float time, float value) { }

	// RVA: 0x14BE8F4
	void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x14BE908
	float get_time() { }

	// RVA: 0x14BE910
	float get_value() { }

	// RVA: 0x14BE918
	void set_value(float value) { }

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

	// RVA: 0x14BE920
	void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x14BE970
	IntPtr Internal_Create(Keyframe[] keys) { }

	// RVA: 0x14BE9C0
	bool Internal_Equals(IntPtr other) { }

	// RVA: 0x14BEA28
	void Finalize() { }

	// RVA: 0x14BEAE0
	float Evaluate(float time) { }

	// RVA: 0x14BEB48
	Keyframe[] get_keys() { }

	// RVA: 0x14BEB98
	Keyframe[] GetKeys() { }

	// RVA: 0x14BEBE8
	int GetHashCode() { }

	// RVA: 0x14BEC38
	AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	// RVA: 0x14BEC48
	AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x14BEDF0
	AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x14BED94
	void .ctor(Keyframe[] keys) { }

	// RVA: 0x14BEF28
	void .ctor() { }

	// RVA: 0x14BEF90
	bool Equals(object o) { }

	// RVA: 0x14BF15C
	bool Equals(AnimationCurve other) { }

}

// Namespace: 
public sealed class LowMemoryCallback 
{
	// Methods

	// RVA: 0x14C1278
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14C1318
	internal void Invoke() { }

}

// Namespace: 
public sealed class MemoryUsageChangedCallback 
{
	// Methods

	// RVA: 0x14C132C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14C13E0
	internal void Invoke(in ApplicationMemoryUsageChange usage) { }

}

// Namespace: 
public sealed class LogCallback 
{
	// Methods

	// RVA: 0x14C13F4
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14C14B0
	internal void Invoke(string condition, string stackTrace, LogType type) { }

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

	// RVA: 0x14BF24C
	void Quit(int exitCode) { }

	// RVA: 0x14BF29C
	void Quit() { }

	// RVA: 0x14BF338
	bool get_isPlaying() { }

	// RVA: 0x14BF378
	bool get_isFocused() { }

	// RVA: 0x14BF3B8
	string get_buildGUID() { }

	// RVA: 0x14BF3F8
	bool get_runInBackground() { }

	// RVA: 0x14BF438
	bool get_isBatchMode() { }

	// RVA: 0x14BF478
	string get_dataPath() { }

	// RVA: 0x14BF4B8
	string get_streamingAssetsPath() { }

	// RVA: 0x14BF4F8
	string get_persistentDataPath() { }

	// RVA: 0x14BF538
	string get_temporaryCachePath() { }

	// RVA: 0x14BF578
	string get_unityVersion() { }

	// RVA: 0x14BF5B8
	string get_version() { }

	// RVA: 0x14BF5F8
	string get_installerName() { }

	// RVA: 0x14BF638
	string get_identifier() { }

	// RVA: 0x14BF678
	ApplicationInstallMode get_installMode() { }

	// RVA: 0x14BF6B8
	ApplicationSandboxType get_sandboxType() { }

	// RVA: 0x14BF6F8
	string get_cloudProjectId() { }

	// RVA: 0x14BF738
	void OpenURL(string url) { }

	// RVA: 0x14BF788
	int get_targetFrameRate() { }

	// RVA: 0x14BF7C8
	void set_targetFrameRate(int value) { }

	// RVA: 0x14BF818
	void SetLogCallbackDefined(bool defined) { }

	// RVA: 0x14BF868
	StackTraceLogType GetStackTraceLogType(LogType logType) { }

	// RVA: 0x14BF8B8
	RuntimePlatform get_platform() { }

	// RVA: 0x14BF8F8
	SystemLanguage get_systemLanguage() { }

	// RVA: 0x14BF938
	NetworkReachability get_internetReachability() { }

	// RVA: 0x14BF978
	void add_lowMemory(LowMemoryCallback value) { }

	// RVA: 0x14BFA64
	void remove_lowMemory(LowMemoryCallback value) { }

	// RVA: 0x14BFB50
	void CallLowMemory(ApplicationMemoryUsage usage) { }

	// RVA: 0x14BFCB4
	bool HasLogCallback() { }

	// RVA: 0x14BFD74
	void add_logMessageReceived(LogCallback value) { }

	// RVA: 0x14BFE94
	void remove_logMessageReceived(LogCallback value) { }

	// RVA: 0x14BFF78
	void add_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0x14C0098
	void remove_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0x14C017C
	void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	// RVA: 0x14C0284
	void add_focusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x14C0398
	void remove_focusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x14C04AC
	void add_quitting(Action value) { }

	// RVA: 0x14C059C
	void remove_quitting(Action value) { }

	// RVA: 0x14C068C
	bool Internal_ApplicationWantsToQuit() { }

	// RVA: 0x14C0A10
	void Internal_ApplicationInit() { }

	// RVA: 0x14C0AA0
	void Internal_ApplicationQuit() { }

	// RVA: 0x14C0B6C
	void Internal_ApplicationUnload() { }

	// RVA: 0x14C0C1C
	void InvokeOnBeforeRender() { }

	// RVA: 0x14C0E54
	void InvokeFocusChanged(bool focus) { }

	// RVA: 0x14C0F2C
	void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x14C0FF0
	void RegisterLogCallback(LogCallback handler) { }

	// RVA: 0x14C1078
	void RegisterLogCallback(LogCallback handler, bool threaded) { }

	// RVA: 0x14C11F0
	bool get_isEditor() { }

	// RVA: 0x14C11F8
	void .cctor() { }

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

	// RVA: 0x14C14C4
	void set_memoryUsage(ApplicationMemoryUsage value) { }

	// RVA: 0x14BFCAC
	void .ctor(ApplicationMemoryUsage usage) { }

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
public enum ApplicationSandboxType 
{
	// Fields
	public int value__; // 0x10
	public const ApplicationSandboxType Unknown = 0;
	public const ApplicationSandboxType NotSandboxed = 1;
	public const ApplicationSandboxType Sandboxed = 2;
	public const ApplicationSandboxType SandboxBroken = 3;
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

	// RVA: 0x14C14CC
	BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

	// RVA: 0x14C1530
	void .ctor(IntPtr nativeHandle) { }

}

// Namespace: UnityEngine
public sealed class Caching 
{
	// Methods

	// RVA: 0x14C15B8
	bool get_ready() { }

	// RVA: 0x14C15F8
	void set_maximumAvailableDiskSpace(Int64 value) { }

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

	// RVA: 0x14C7F6C
	GateFitMode get_mode() { }

	// RVA: 0x14C7F74
	float get_aspect() { }

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

	// RVA: 0x14C7F7C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14C8030
	internal void Invoke(Camera cam) { }

}

// Namespace: UnityEngine
public sealed class Camera 
{
	// Fields
	public const float kMinAperture = 1060320051;
	public const float kMaxAperture = 1107296256;
	public const int kMinBladeCount = 3;
	public const int kMaxBladeCount = 11;
	public static CameraCallback onPreCull; // 0x0
	public static CameraCallback onPreRender; // 0x8
	public static CameraCallback onPostRender; // 0x10

	// Methods

	// RVA: 0x14C1648
	void .ctor() { }

	// RVA: 0x14C1650
	float get_nearClipPlane() { }

	// RVA: 0x14C16A0
	void set_nearClipPlane(float value) { }

	// RVA: 0x14C1708
	float get_farClipPlane() { }

	// RVA: 0x14C1758
	void set_farClipPlane(float value) { }

	// RVA: 0x14C17C0
	float get_fieldOfView() { }

	// RVA: 0x14C1810
	void set_fieldOfView(float value) { }

	// RVA: 0x14C1878
	RenderingPath get_renderingPath() { }

	// RVA: 0x14C18C8
	void set_renderingPath(RenderingPath value) { }

	// RVA: 0x14C1930
	RenderingPath get_actualRenderingPath() { }

	// RVA: 0x14C1980
	void Reset() { }

	// RVA: 0x14C19D0
	bool get_allowHDR() { }

	// RVA: 0x14C1A20
	void set_allowHDR(bool value) { }

	// RVA: 0x14C1A88
	bool get_allowMSAA() { }

	// RVA: 0x14C1AD8
	void set_allowMSAA(bool value) { }

	// RVA: 0x14C1B40
	bool get_allowDynamicResolution() { }

	// RVA: 0x14C1B90
	void set_allowDynamicResolution(bool value) { }

	// RVA: 0x14C1BF8
	bool get_forceIntoRenderTexture() { }

	// RVA: 0x14C1C48
	void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x14C1CB0
	float get_orthographicSize() { }

	// RVA: 0x14C1D00
	void set_orthographicSize(float value) { }

	// RVA: 0x14C1D68
	bool get_orthographic() { }

	// RVA: 0x14C1DB8
	void set_orthographic(bool value) { }

	// RVA: 0x14C1E20
	OpaqueSortMode get_opaqueSortMode() { }

	// RVA: 0x14C1E70
	void set_opaqueSortMode(OpaqueSortMode value) { }

	// RVA: 0x14C1ED8
	TransparencySortMode get_transparencySortMode() { }

	// RVA: 0x14C1F28
	void set_transparencySortMode(TransparencySortMode value) { }

	// RVA: 0x14C1F90
	Vector3 get_transparencySortAxis() { }

	// RVA: 0x14C2058
	void set_transparencySortAxis(Vector3 value) { }

	// RVA: 0x14C2118
	void ResetTransparencySortSettings() { }

	// RVA: 0x14C2168
	float get_depth() { }

	// RVA: 0x14C21B8
	void set_depth(float value) { }

	// RVA: 0x14C2220
	float get_aspect() { }

	// RVA: 0x14C2270
	void set_aspect(float value) { }

	// RVA: 0x14C22D8
	void ResetAspect() { }

	// RVA: 0x14C2328
	Vector3 get_velocity() { }

	// RVA: 0x14C23F0
	int get_cullingMask() { }

	// RVA: 0x14C2440
	void set_cullingMask(int value) { }

	// RVA: 0x14C24A8
	int get_eventMask() { }

	// RVA: 0x14C24F8
	void set_eventMask(int value) { }

	// RVA: 0x14C2560
	bool get_layerCullSpherical() { }

	// RVA: 0x14C25B0
	void set_layerCullSpherical(bool value) { }

	// RVA: 0x14C2618
	CameraType get_cameraType() { }

	// RVA: 0x14C2668
	void set_cameraType(CameraType value) { }

	// RVA: 0x14C26D0
	Material get_skyboxMaterial() { }

	// RVA: 0x14C2720
	UInt64 get_overrideSceneCullingMask() { }

	// RVA: 0x14C2770
	void set_overrideSceneCullingMask(UInt64 value) { }

	// RVA: 0x14C27D8
	UInt64 get_sceneCullingMask() { }

	// RVA: 0x14C2828
	float[] GetLayerCullDistances() { }

	// RVA: 0x14C2878
	void SetLayerCullDistances(float[] d) { }

	// RVA: 0x14C28E0
	float[] get_layerCullDistances() { }

	// RVA: 0x14C2930
	void set_layerCullDistances(float[] value) { }

	// RVA: 0x14C29F4
	int get_PreviewCullingLayer() { }

	// RVA: 0x14C29FC
	bool get_useOcclusionCulling() { }

	// RVA: 0x14C2A4C
	void set_useOcclusionCulling(bool value) { }

	// RVA: 0x14C2AB4
	Matrix4x4 get_cullingMatrix() { }

	// RVA: 0x14C2B94
	void set_cullingMatrix(Matrix4x4 value) { }

	// RVA: 0x14C2C64
	void ResetCullingMatrix() { }

	// RVA: 0x14C2CB4
	Color get_backgroundColor() { }

	// RVA: 0x14C2D78
	void set_backgroundColor(Color value) { }

	// RVA: 0x14C2E38
	CameraClearFlags get_clearFlags() { }

	// RVA: 0x14C2E88
	void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x14C2EF0
	DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x14C2F40
	void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x14C2FA8
	bool get_clearStencilAfterLightingPass() { }

	// RVA: 0x14C2FF8
	void set_clearStencilAfterLightingPass(bool value) { }

	// RVA: 0x14C3060
	void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x14C30B8
	void ResetReplacementShader() { }

	// RVA: 0x14C3108
	ProjectionMatrixMode get_projectionMatrixMode() { }

	// RVA: 0x14C3158
	bool get_usePhysicalProperties() { }

	// RVA: 0x14C31A8
	void set_usePhysicalProperties(bool value) { }

	// RVA: 0x14C3210
	int get_iso() { }

	// RVA: 0x14C3260
	void set_iso(int value) { }

	// RVA: 0x14C32C8
	float get_shutterSpeed() { }

	// RVA: 0x14C3318
	void set_shutterSpeed(float value) { }

	// RVA: 0x14C3380
	float get_aperture() { }

	// RVA: 0x14C33D0
	void set_aperture(float value) { }

	// RVA: 0x14C3438
	float get_focusDistance() { }

	// RVA: 0x14C3488
	void set_focusDistance(float value) { }

	// RVA: 0x14C34F0
	float get_focalLength() { }

	// RVA: 0x14C3540
	void set_focalLength(float value) { }

	// RVA: 0x14C35A8
	int get_bladeCount() { }

	// RVA: 0x14C35F8
	void set_bladeCount(int value) { }

	// RVA: 0x14C3660
	Vector2 get_curvature() { }

	// RVA: 0x14C3720
	void set_curvature(Vector2 value) { }

	// RVA: 0x14C37DC
	float get_barrelClipping() { }

	// RVA: 0x14C382C
	void set_barrelClipping(float value) { }

	// RVA: 0x14C3894
	float get_anamorphism() { }

	// RVA: 0x14C38E4
	void set_anamorphism(float value) { }

	// RVA: 0x14C394C
	Vector2 get_sensorSize() { }

	// RVA: 0x14C3A0C
	void set_sensorSize(Vector2 value) { }

	// RVA: 0x14C3AC8
	Vector2 get_lensShift() { }

	// RVA: 0x14C3B88
	void set_lensShift(Vector2 value) { }

	// RVA: 0x14C3C44
	GateFitMode get_gateFit() { }

	// RVA: 0x14C3C94
	void set_gateFit(GateFitMode value) { }

	// RVA: 0x14C3CFC
	float GetGateFittedFieldOfView() { }

	// RVA: 0x14C3D4C
	Vector2 GetGateFittedLensShift() { }

	// RVA: 0x14C3E0C
	Vector3 GetLocalSpaceAim() { }

	// RVA: 0x14C3ED4
	Rect get_rect() { }

	// RVA: 0x14C3F98
	void set_rect(Rect value) { }

	// RVA: 0x14C4058
	Rect get_pixelRect() { }

	// RVA: 0x14C411C
	void set_pixelRect(Rect value) { }

	// RVA: 0x14C41DC
	int get_pixelWidth() { }

	// RVA: 0x14C422C
	int get_pixelHeight() { }

	// RVA: 0x14C427C
	int get_scaledPixelWidth() { }

	// RVA: 0x14C42CC
	int get_scaledPixelHeight() { }

	// RVA: 0x14C431C
	RenderTexture get_targetTexture() { }

	// RVA: 0x14C436C
	void set_targetTexture(RenderTexture value) { }

	// RVA: 0x14C43D4
	RenderTexture get_activeTexture() { }

	// RVA: 0x14C4424
	int get_targetDisplay() { }

	// RVA: 0x14C4474
	void set_targetDisplay(int value) { }

	// RVA: 0x14C44DC
	void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x14C4590
	void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x14C45EC
	void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0x14C46A8
	void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x14C470C
	string[] GetCameraBufferWarnings() { }

	// RVA: 0x14C475C
	Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0x14C483C
	Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x14C491C
	void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0x14C49EC
	Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x14C4ACC
	void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x14C4B9C
	Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x14C4C7C
	void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x14C4D4C
	bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	// RVA: 0x14C4D9C
	void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x14C4E04
	Matrix4x4 get_previousViewProjectionMatrix() { }

	// RVA: 0x14C4EE4
	void ResetWorldToCameraMatrix() { }

	// RVA: 0x14C4F34
	void ResetProjectionMatrix() { }

	// RVA: 0x14C4F84
	Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0x14C5060
	Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x14C5144
	Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x14C5228
	Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x14C530C
	Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x14C53F0
	Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x14C5460
	Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x14C54D0
	Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x14C5540
	Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x14C55B0
	Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x14C5674
	Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x14C5738
	Vector2 GetFrustumPlaneSizeAt(float distance) { }

	// RVA: 0x14C5800
	Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x14C58EC
	Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x14C5978
	Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x14C5A00
	Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x14C5AEC
	Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x14C5B78
	Ray ScreenPointToRay(Vector3 pos) { }

	// RVA: 0x14C5C00
	void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x14C5CF8
	void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0x14C5E2C
	void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0x14C5F60
	void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters) { }

	// RVA: 0x14C5FFC
	float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	// RVA: 0x14C6060
	float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	// RVA: 0x14C60C4
	float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	// RVA: 0x14C6128
	float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	// RVA: 0x14C618C
	Camera get_main() { }

	// RVA: 0x14C61CC
	Camera get_current() { }

	// RVA: 0x14C620C
	Scene get_scene() { }

	// RVA: 0x14C62CC
	void set_scene(Scene value) { }

	// RVA: 0x14C6388
	bool get_stereoEnabled() { }

	// RVA: 0x14C63D8
	float get_stereoSeparation() { }

	// RVA: 0x14C6428
	void set_stereoSeparation(float value) { }

	// RVA: 0x14C6490
	float get_stereoConvergence() { }

	// RVA: 0x14C64E0
	void set_stereoConvergence(float value) { }

	// RVA: 0x14C6548
	bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	// RVA: 0x14C6598
	StereoTargetEyeMask get_stereoTargetEye() { }

	// RVA: 0x14C65E8
	void set_stereoTargetEye(StereoTargetEyeMask value) { }

	// RVA: 0x14C6650
	MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x14C66A0
	Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0x14C6778
	Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	// RVA: 0x14C6850
	void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	// RVA: 0x14C68B8
	Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0x14C6990
	void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x14C6A40
	void ResetStereoProjectionMatrices() { }

	// RVA: 0x14C6A90
	void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x14C6B40
	void ResetStereoViewMatrices() { }

	// RVA: 0x14C6B90
	int GetAllCamerasCount() { }

	// RVA: 0x14C6BD0
	int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x14C6C20
	int get_allCamerasCount() { }

	// RVA: 0x14C6C60
	Camera[] get_allCameras() { }

	// RVA: 0x14C6D14
	int GetAllCameras(Camera[] cameras) { }

	// RVA: 0x14C6E10
	bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	// RVA: 0x14C6E68
	bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	// RVA: 0x14C6EC0
	bool RenderToCubemap(Cubemap cubemap) { }

	// RVA: 0x14C6F14
	bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	// RVA: 0x14C6F6C
	bool RenderToCubemap(RenderTexture cubemap) { }

	// RVA: 0x14C6FC0
	int GetFilterMode() { }

	// RVA: 0x14C7010
	SceneViewFilterMode get_sceneViewFilterMode() { }

	// RVA: 0x14C7060
	bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x14C70C8
	bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x14C7130
	void Render() { }

	// RVA: 0x14C7180
	void RenderWithShader(Shader shader, string replacementTag) { }

	// RVA: 0x14C71D8
	void RenderDontRestore() { }

	// RVA: 0x14C7228
	void SubmitRenderRequests(System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests) { }

	// RVA: 0x309AF8C
	void SubmitRenderRequest(RequestData renderRequest) { }

	// RVA: 0x14C74EC
	void SubmitRenderRequestsInternal(object requests) { }

	// RVA: 0x14C7554
	object[] SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x14C75C4
	void SetupCurrent(Camera cur) { }

	// RVA: 0x14C7614
	void CopyFrom(Camera other) { }

	// RVA: 0x14C767C
	int get_commandBufferCount() { }

	// RVA: 0x14C76CC
	void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x14C7734
	void RemoveAllCommandBuffers() { }

	// RVA: 0x14C7784
	void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x14C77DC
	void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x14C7844
	void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x14C789C
	void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x14C79DC
	void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x14C7B2C
	void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x14C7C6C
	CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	// RVA: 0x14C7CD4
	void FireOnPreCull(Camera cam) { }

	// RVA: 0x14C7D50
	void FireOnPreRender(Camera cam) { }

	// RVA: 0x14C7DCC
	void FireOnPostRender(Camera cam) { }

	// RVA: 0x14C7E48
	void OnlyUsedForTesting1() { }

	// RVA: 0x14C7E4C
	void OnlyUsedForTesting2() { }

	// RVA: 0x14C7E50
	bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x14C7F10
	bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x14C7EA8
	bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	// RVA: 0x14C1FF0
	void get_transparencySortAxis_Injected(out Vector3 ret) { }

	// RVA: 0x14C20B0
	void set_transparencySortAxis_Injected(ref Vector3 value) { }

	// RVA: 0x14C2388
	void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x14C2B2C
	void get_cullingMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x14C2BFC
	void set_cullingMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x14C2D10
	void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x14C2DD0
	void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x14C36B8
	void get_curvature_Injected(out Vector2 ret) { }

	// RVA: 0x14C3774
	void set_curvature_Injected(ref Vector2 value) { }

	// RVA: 0x14C39A4
	void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0x14C3A60
	void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0x14C3B20
	void get_lensShift_Injected(out Vector2 ret) { }

	// RVA: 0x14C3BDC
	void set_lensShift_Injected(ref Vector2 value) { }

	// RVA: 0x14C3DA4
	void GetGateFittedLensShift_Injected(out Vector2 ret) { }

	// RVA: 0x14C3E6C
	void GetLocalSpaceAim_Injected(out Vector3 ret) { }

	// RVA: 0x14C3F30
	void get_rect_Injected(out Rect ret) { }

	// RVA: 0x14C3FF0
	void set_rect_Injected(ref Rect value) { }

	// RVA: 0x14C40B4
	void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x14C4174
	void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0x14C4538
	void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth) { }

	// RVA: 0x14C4650
	void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, ref RenderBuffer depth) { }

	// RVA: 0x14C47D4
	void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x14C48B4
	void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x14C4984
	void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x14C4A64
	void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x14C4B34
	void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x14C4C14
	void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x14C4CE4
	void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x14C4E7C
	void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x14C5008
	void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) { }

	// RVA: 0x14C50DC
	void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x14C51C0
	void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x14C52A4
	void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x14C5388
	void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x14C561C
	void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x14C56E0
	void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x14C57A0
	void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret) { }

	// RVA: 0x14C5884
	void ViewportPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x14C5A84
	void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x14C5C80
	void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x14C5EC8
	void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0x14C6264
	void get_scene_Injected(out Scene ret) { }

	// RVA: 0x14C6320
	void set_scene_Injected(ref Scene value) { }

	// RVA: 0x14C6720
	void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x14C67F8
	void GetStereoViewMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x14C6938
	void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x14C69E8
	void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

	// RVA: 0x14C6AE8
	void SetStereoViewMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

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

	// RVA: 0x14C80AC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14C8150
	internal void Invoke(CullingGroupEvent sphere) { }

}

// Namespace: UnityEngine
public class CullingGroup 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private StateChanged m_OnStateChanged; // 0x18

	// Methods

	// RVA: 0x14C8044
	void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }

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

	// RVA: 0x14C8164
	void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	// RVA: 0x14C8214
	void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x14C843C
	void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class DebugLogHandler 
{
	// Methods

	// RVA: 0x14C8528
	void Internal_Log(LogType level, LogOption options, string msg, object obj) { }

	// RVA: 0x14C8590
	void Internal_LogException(Exception ex, object obj) { }

	// RVA: 0x14C85F8
	void LogFormat(LogType logType, object context, string format, object[] args) { }

	// RVA: 0x14C8664
	void LogFormat(LogType logType, LogOption logOptions, object context, string format, object[] args) { }

	// RVA: 0x14C86DC
	void LogException(Exception exception, object context) { }

	// RVA: 0x14C8790
	void .ctor() { }

}

// Namespace: UnityEngine
public class Debug 
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Methods

	// RVA: 0x14C8798
	ILogger get_unityLogger() { }

	// RVA: 0x14C8814
	int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x14C886C
	void Log(object message) { }

	// RVA: 0x14C8A34
	void LogFormat(LogType logType, LogOption logOptions, object context, string format, object[] args) { }

	// RVA: 0x14C8E18
	void LogError(object message) { }

	// RVA: 0x14C8F5C
	void LogError(object message, object context) { }

	// RVA: 0x14C90A8
	void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x14C91F4
	void LogErrorFormat(object context, string format, object[] args) { }

	// RVA: 0x14C08CC
	void LogException(Exception exception) { }

	// RVA: 0x14C934C
	void LogException(Exception exception, object context) { }

	// RVA: 0x14C73A8
	void LogWarning(object message) { }

	// RVA: 0x14C9494
	void LogWarning(object message, object context) { }

	// RVA: 0x14C95E0
	void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x14C972C
	void LogWarningFormat(object context, string format, object[] args) { }

	// RVA: 0x14C9884
	void Assert(bool condition) { }

	// RVA: 0x14C99DC
	void Assert(bool condition, string message) { }

	// RVA: 0x14C9B2C
	void LogAssertion(object message) { }

	// RVA: 0x14C9C70
	void LogAssertionFormat(string format, object[] args) { }

	// RVA: 0x14C9DBC
	bool get_isDebugBuild() { }

	// RVA: 0x14C9DFC
	bool CallOverridenDebugHandler(Exception exception, object obj) { }

	// RVA: 0x14CA1AC
	bool IsLoggingEnabled() { }

	// RVA: 0x14CA44C
	void .cctor() { }

}

// Namespace: 
internal class Expression 
{
	// Fields
	internal readonly string[] rpnTokens; // 0x10
	internal readonly bool hasVariables; // 0x18

	// Methods

	// RVA: 0x14CC938
	void .ctor(string expression) { }

	// RVA: -1
	bool Evaluate(ref T value, int index, int count) { }

}

// Namespace: 
private struct PcgRandom 
{
	// Fields
	private readonly UInt64 increment; // 0x10
	private UInt64 state; // 0x18

	// Methods

	// RVA: 0x14CC8C4
	void .ctor(UInt64 state, UInt64 sequence) { }

	// RVA: 0x14CC318
	UInt32 GetUInt() { }

	// RVA: 0x14CCA00
	UInt32 RotateRight(UInt32 v, int rot) { }

	// RVA: 0x14CC9E8
	UInt32 XshRr(UInt64 s) { }

	// RVA: 0x14CC9C8
	void Step() { }

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

	// RVA: 0x14CC8EC
	void .ctor(Op op, int precedence, int inputs, Associativity associativity) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.ExpressionEvaluator.<>c <>9; // 0x0
	public static System.Func<System.String,System.Boolean> <>9__14_0; // 0x8

	// Methods

	// RVA: 0x14CCA08
	void .cctor() { }

	// RVA: 0x14CCA74
	void .ctor() { }

	// RVA: 0x14CCA7C
	bool <ExpressionToTokens>b__14_0(string f) { }

}

// Namespace: UnityEngine
public class ExpressionEvaluator 
{
	// Fields
	private static PcgRandom s_Random; // 0x0
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.ExpressionEvaluator.Operator> s_Operators; // 0x10

	// Methods

	// RVA: 0x2FE5B20
	bool Evaluate(string expression, out T value, out Expression delayed) { }

	// RVA: 0x309AF8C
	bool EvaluateTokens(string[] tokens, ref T value, int index, int count) { }

	// RVA: 0x14CA548
	bool EvaluateDouble(string[] tokens, ref Double value, int index, int count) { }

	// RVA: 0x14CB2A8
	string[] InfixToRPN(string[] tokens) { }

	// RVA: 0x14CB9F0
	bool NeedToPop(System.Collections.Generic.Stack<System.String> operatorStack, Operator newOperator) { }

	// RVA: 0x14CBBA8
	string[] ExpressionToTokens(string expression, out bool hasVariables) { }

	// RVA: 0x14CADA8
	bool IsCommand(string token) { }

	// RVA: 0x14CB248
	bool IsVariable(string token) { }

	// RVA: 0x14CB8B4
	bool IsDelayedFunction(string token) { }

	// RVA: 0x14CAC3C
	bool IsOperator(string token) { }

	// RVA: 0x14CACE0
	Operator TokenToOperator(string token) { }

	// RVA: 0x14CBF34
	string PreFormatExpression(string expression) { }

	// RVA: 0x14CC178
	string[] FixUnaryOperators(string[] tokens) { }

	// RVA: 0x14CAEDC
	Double EvaluateOp(Double[] values, Op op, int index, int count) { }

	// RVA: 0x2FE59C8
	bool TryParse(string expression, out T result) { }

	// RVA: 0x14CC34C
	void .cctor() { }

}

// Namespace: UnityEngine
public struct Bounds 
{
	// Fields
	private Vector3 m_Center; // 0x10
	private Vector3 m_Extents; // 0x1C

	// Methods

	// RVA: 0x14CCB74
	void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x14CCB94
	int GetHashCode() { }

	// RVA: 0x14CCC68
	bool Equals(object other) { }

	// RVA: 0x14CCD30
	bool Equals(Bounds other) { }

	// RVA: 0x14CCD84
	Vector3 get_center() { }

	// RVA: 0x14CCD90
	void set_center(Vector3 value) { }

	// RVA: 0x14CCD9C
	Vector3 get_size() { }

	// RVA: 0x14CCDB4
	void set_size(Vector3 value) { }

	// RVA: 0x14CCDD0
	Vector3 get_extents() { }

	// RVA: 0x14CCDDC
	void set_extents(Vector3 value) { }

	// RVA: 0x14CCDE8
	Vector3 get_min() { }

	// RVA: 0x14CCE04
	void set_min(Vector3 value) { }

	// RVA: 0x14CCE54
	Vector3 get_max() { }

	// RVA: 0x14CCE70
	void set_max(Vector3 value) { }

	// RVA: 0x14CCEC0
	bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x14CCF3C
	bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x14CCFBC
	void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x14CCFF4
	void Encapsulate(Vector3 point) { }

	// RVA: 0x14CD06C
	void Encapsulate(Bounds bounds) { }

	// RVA: 0x14CD168
	bool Intersects(Bounds bounds) { }

	// RVA: 0x14CD204
	bool IntersectRay(Ray ray) { }

	// RVA: 0x14CD2D0
	string ToString() { }

	// RVA: 0x14CD48C
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14CD638
	bool Contains(Vector3 point) { }

	// RVA: 0x14CD6F8
	float SqrDistance(Vector3 point) { }

	// RVA: 0x14CD278
	bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist) { }

	// RVA: 0x14CD690
	bool Contains_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x14CD750
	float SqrDistance_Injected(ref Bounds _unity_self, ref Vector3 point) { }

	// RVA: 0x14CD7B8
	bool IntersectRayAABB_Injected(ref Ray ray, ref Bounds bounds, out float dist) { }

}

// Namespace: UnityEngine
public struct BoundsInt 
{
	// Fields
	private Vector3Int m_Position; // 0x10
	private Vector3Int m_Size; // 0x1C

	// Methods

	// RVA: 0x14CD810
	Vector3Int get_position() { }

	// RVA: 0x14CD820
	void set_position(Vector3Int value) { }

	// RVA: 0x14CD82C
	Vector3Int get_size() { }

	// RVA: 0x14CD83C
	void set_size(Vector3Int value) { }

	// RVA: 0x14CD848
	void .ctor(Vector3Int position, Vector3Int size) { }

	// RVA: 0x14CD85C
	string ToString() { }

	// RVA: 0x14CD9F4
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14CDD6C
	bool Equals(object other) { }

	// RVA: 0x14CDE44
	bool Equals(BoundsInt other) { }

	// RVA: 0x14CDEA8
	int GetHashCode() { }

}

// Namespace: UnityEngine
public sealed class GeometryUtility 
{
	// Methods

	// RVA: 0x14CDF88
	Plane[] CalculateFrustumPlanes(Camera camera) { }

	// RVA: 0x14CDFF4
	void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	// RVA: 0x14CE0FC
	void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	// RVA: 0x14CE278
	bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	// RVA: 0x14CE210
	void Internal_ExtractPlanes([Out] Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	// RVA: 0x14CE2E0
	bool TestPlanesAABB_Injected(Plane[] planes, ref Bounds bounds) { }

	// RVA: 0x14CE348
	void Internal_ExtractPlanes_Injected([Out] Plane[] planes, ref Matrix4x4 worldToProjectionMatrix) { }

}

// Namespace: UnityEngine
public struct Plane 
{
	// Fields
	private Vector3 m_Normal; // 0x10
	private float m_Distance; // 0x1C

	// Methods

	// RVA: 0x14CE3B0
	Vector3 get_normal() { }

	// RVA: 0x14CE3BC
	float get_distance() { }

	// RVA: 0x14CE3C4
	void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x14CE4F4
	void .ctor(Vector3 inNormal, float d) { }

	// RVA: 0x14CE5FC
	void .ctor(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0x14CE770
	bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x14CE87C
	string ToString() { }

	// RVA: 0x14CEA38
	string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public struct Ray 
{
	// Fields
	private Vector3 m_Origin; // 0x10
	private Vector3 m_Direction; // 0x1C

	// Methods

	// RVA: 0x14CEBE4
	void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x14CECF0
	Vector3 get_origin() { }

	// RVA: 0x14CECFC
	void set_origin(Vector3 value) { }

	// RVA: 0x14CED08
	Vector3 get_direction() { }

	// RVA: 0x14CED14
	void set_direction(Vector3 value) { }

	// RVA: 0x14CEE18
	Vector3 GetPoint(float distance) { }

	// RVA: 0x14CEE40
	string ToString() { }

	// RVA: 0x14CEFFC
	string ToString(string format, IFormatProvider formatProvider) { }

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

	// RVA: 0x14CF1A8
	void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x14CF1B4
	void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x14CF1C0
	void .ctor(Rect source) { }

	// RVA: 0x14CF1CC
	Rect get_zero() { }

	// RVA: 0x14CF1E0
	Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x14CF1EC
	float get_x() { }

	// RVA: 0x14CF1F4
	void set_x(float value) { }

	// RVA: 0x14CF1FC
	float get_y() { }

	// RVA: 0x14CF204
	void set_y(float value) { }

	// RVA: 0x14CF20C
	Vector2 get_position() { }

	// RVA: 0x14CF214
	void set_position(Vector2 value) { }

	// RVA: 0x14CF21C
	Vector2 get_center() { }

	// RVA: 0x14CF234
	void set_center(Vector2 value) { }

	// RVA: 0x14CF250
	Vector2 get_min() { }

	// RVA: 0x14CF258
	void set_min(Vector2 value) { }

	// RVA: 0x14CF274
	Vector2 get_max() { }

	// RVA: 0x14CF288
	void set_max(Vector2 value) { }

	// RVA: 0x14CF29C
	float get_width() { }

	// RVA: 0x14CF2A4
	void set_width(float value) { }

	// RVA: 0x14CF2AC
	float get_height() { }

	// RVA: 0x14CF2B4
	void set_height(float value) { }

	// RVA: 0x14CF2BC
	Vector2 get_size() { }

	// RVA: 0x14CF2C4
	void set_size(Vector2 value) { }

	// RVA: 0x14CF2CC
	float get_xMin() { }

	// RVA: 0x14CF2D4
	void set_xMin(float value) { }

	// RVA: 0x14CF2F0
	float get_yMin() { }

	// RVA: 0x14CF2F8
	void set_yMin(float value) { }

	// RVA: 0x14CF314
	float get_xMax() { }

	// RVA: 0x14CF324
	void set_xMax(float value) { }

	// RVA: 0x14CF334
	float get_yMax() { }

	// RVA: 0x14CF344
	void set_yMax(float value) { }

	// RVA: 0x14CF354
	bool Contains(Vector2 point) { }

	// RVA: 0x14CF398
	bool Contains(Vector3 point) { }

	// RVA: 0x14CF3DC
	Rect OrderMinMax(Rect rect) { }

	// RVA: 0x14CF408
	bool Overlaps(Rect other) { }

	// RVA: 0x14CF454
	bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x14CF4E4
	Vector2 PointToNormalized(Rect rectangle, Vector2 point) { }

	// RVA: 0x14CF558
	bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x14CF57C
	bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x14CF5A0
	int GetHashCode() { }

	// RVA: 0x14CF634
	bool Equals(object other) { }

	// RVA: 0x14CF834
	bool Equals(Rect other) { }

	// RVA: 0x14CF8DC
	string ToString() { }

	// RVA: 0x14CF8E8
	string ToString(string format, IFormatProvider formatProvider) { }

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

	// RVA: 0x14CFB58
	int get_x() { }

	// RVA: 0x14CFB60
	void set_x(int value) { }

	// RVA: 0x14CFB68
	int get_y() { }

	// RVA: 0x14CFB70
	void set_y(int value) { }

	// RVA: 0x14CFB78
	int get_width() { }

	// RVA: 0x14CFB80
	void set_width(int value) { }

	// RVA: 0x14CFB88
	int get_height() { }

	// RVA: 0x14CFB90
	void set_height(int value) { }

	// RVA: 0x14CFB98
	int get_xMin() { }

	// RVA: 0x14CFC08
	int get_yMin() { }

	// RVA: 0x14CFC78
	int get_xMax() { }

	// RVA: 0x14CFCE8
	int get_yMax() { }

	// RVA: 0x14CFD58
	void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x14CFD64
	bool Overlaps(RectInt other) { }

	// RVA: 0x14D0484
	string ToString() { }

	// RVA: 0x14D06E0
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14D0924
	bool Equals(RectInt other) { }

}

// Namespace: UnityEngine
public class RectOffset 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Methods

	// RVA: 0x14D0968
	void .ctor() { }

	// RVA: 0x14D0A04
	void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x14D0A4C
	void Finalize() { }

	// RVA: 0x14D0B98
	void .ctor(int left, int right, int top, int bottom) { }

	// RVA: 0x14D0EAC
	string ToString() { }

	// RVA: 0x14D1198
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14D0B30
	void Destroy() { }

	// RVA: 0x14D09C4
	IntPtr InternalCreate() { }

	// RVA: 0x14D15AC
	void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x14D146C
	int get_left() { }

	// RVA: 0x14D0D0C
	void set_left(int value) { }

	// RVA: 0x14D14BC
	int get_right() { }

	// RVA: 0x14D0D74
	void set_right(int value) { }

	// RVA: 0x14D150C
	int get_top() { }

	// RVA: 0x14D0DDC
	void set_top(int value) { }

	// RVA: 0x14D155C
	int get_bottom() { }

	// RVA: 0x14D0E44
	void set_bottom(int value) { }

	// RVA: 0x14D15FC
	int get_horizontal() { }

	// RVA: 0x14D164C
	int get_vertical() { }

	// RVA: 0x14D169C
	Rect Remove(Rect rect) { }

	// RVA: 0x14D1704
	void Remove_Injected(ref Rect rect, out Rect ret) { }

}

// Namespace: UnityEngine
public sealed class LightingSettings 
{
	// Methods

	// RVA: 0x14D175C
	void LightingSettingsDontStripMe() { }

}

// Namespace: UnityEngine
public sealed class Gizmos 
{
	// Methods

	// RVA: 0x14D1760
	void DrawLine(Vector3 from, Vector3 to) { }

	// RVA: 0x14D1824
	void DrawWireSphere(Vector3 center, float radius) { }

	// RVA: 0x14D18EC
	void DrawSphere(Vector3 center, float radius) { }

	// RVA: 0x14D19B4
	void DrawWireCube(Vector3 center, Vector3 size) { }

	// RVA: 0x14D1A78
	void DrawCube(Vector3 center, Vector3 size) { }

	// RVA: 0x14D1B3C
	void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x14D1C34
	void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x14D1D2C
	void set_color(Color value) { }

	// RVA: 0x14D1DE4
	void set_matrix(Matrix4x4 value) { }

	// RVA: 0x14D1E84
	void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	// RVA: 0x14D1F74
	void DrawRay(Vector3 from, Vector3 direction) { }

	// RVA: 0x14D1FDC
	void DrawMesh(Mesh mesh) { }

	// RVA: 0x14D2100
	void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x14D217C
	void DrawWireMesh(Mesh mesh) { }

	// RVA: 0x14D22A0
	void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x14D17BC
	void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	// RVA: 0x14D1884
	void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x14D194C
	void DrawSphere_Injected(ref Vector3 center, float radius) { }

	// RVA: 0x14D1A10
	void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x14D1AD4
	void DrawCube_Injected(ref Vector3 center, ref Vector3 size) { }

	// RVA: 0x14D1BC4
	void DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x14D1CBC
	void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale) { }

	// RVA: 0x14D1D94
	void set_color_Injected(ref Color value) { }

	// RVA: 0x14D1E34
	void set_matrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x14D1F04
	void DrawFrustum_Injected(ref Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

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

	// RVA: 0x14C0C84
	void Invoke() { }

	// RVA: 0x14D231C
	void .cctor() { }

}

// Namespace: UnityEngine
public static class CustomRenderTextureManager 
{
	// Fields
	private static System.Action<UnityEngine.CustomRenderTexture> textureLoaded; // 0x0
	private static System.Action<UnityEngine.CustomRenderTexture> textureUnloaded; // 0x8

	// Methods

	// RVA: 0x14D23B8
	void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	// RVA: 0x14D2434
	void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }

}

// Namespace: 
public sealed class DisplaysUpdatedDelegate 
{
	// Methods

	// RVA: 0x14D2E4C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14D2EEC
	internal void Invoke() { }

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

	// RVA: 0x14D24B0
	void .ctor() { }

	// RVA: 0x14D24F8
	void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x14D2524
	int get_renderingWidth() { }

	// RVA: 0x14D2640
	int get_renderingHeight() { }

	// RVA: 0x14D2704
	int get_systemWidth() { }

	// RVA: 0x14D2820
	int get_systemHeight() { }

	// RVA: 0x14D28E4
	Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x14D2A3C
	Display get_main() { }

	// RVA: 0x14D2AB8
	void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	// RVA: 0x14D2C58
	void FireDisplaysUpdated() { }

	// RVA: 0x14D27C8
	void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	// RVA: 0x14D25E8
	void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	// RVA: 0x14D29D4
	int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x14D2D08
	void .cctor() { }

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

	// RVA: 0x14D2F00
	Double get_value() { }

	// RVA: 0x14D2F14
	bool Equals(RefreshRate other) { }

	// RVA: 0x14D2F54
	int CompareTo(RefreshRate other) { }

	// RVA: 0x14D2FC0
	string ToString() { }

}

// Namespace: UnityEngine
public sealed class Screen 
{
	// Methods

	// RVA: 0x14D3068
	int get_width() { }

	// RVA: 0x14D30A8
	int get_height() { }

	// RVA: 0x14D30E8
	float get_dpi() { }

	// RVA: 0x14D3128
	ScreenOrientation GetScreenOrientation() { }

	// RVA: 0x14D3168
	ScreenOrientation get_orientation() { }

	// RVA: 0x14D31A8
	void set_sleepTimeout(int value) { }

	// RVA: 0x14D31F8
	Resolution get_currentResolution() { }

	// RVA: 0x14D3298
	bool get_fullScreen() { }

	// RVA: 0x14D32D8
	Rect get_safeArea() { }

	// RVA: 0x14D337C
	void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	// RVA: 0x14D3450
	void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	// RVA: 0x14D34CC
	void SetResolution(int width, int height, bool fullscreen) { }

	// RVA: 0x14D3544
	Resolution[] get_resolutions() { }

	// RVA: 0x14D3248
	void get_currentResolution_Injected(out Resolution ret) { }

	// RVA: 0x14D332C
	void get_safeArea_Injected(out Rect ret) { }

	// RVA: 0x14D33E8
	void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate) { }

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

	// RVA: 0x14D3584
	int Internal_GetMaxDrawMeshInstanceCount() { }

	// RVA: 0x14D35C4
	void Internal_SetNullRT() { }

	// RVA: 0x14D3604
	void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x14D3744
	void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	// RVA: 0x14D3850
	void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	// RVA: 0x14D38A0
	void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	// RVA: 0x14D3910
	void Blit2(Texture source, RenderTexture dest) { }

	// RVA: 0x14D3978
	void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0x14D39C8
	void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x14D3B08
	void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x14D3D78
	void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x14D3DF8
	void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x14D3EA0
	void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x14D4050
	void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x14D40E8
	void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x14D41A0
	void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x14D4260
	void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x14D4364
	void Blit(Texture source, Material mat, int pass) { }

	// RVA: 0x14D4420
	void Blit(Texture source, Material mat) { }

	// RVA: 0x14D4518
	void SetRenderTarget(RenderTexture rt) { }

	// RVA: 0x14D45DC
	void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

	// RVA: 0x14D46CC
	void .cctor() { }

	// RVA: 0x14D36D4
	void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x14D37F8
	void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, ref Matrix4x4 matrix) { }

}

// Namespace: UnityEngine
public sealed class GL 
{
	// Methods

	// RVA: 0x14D478C
	void Vertex3(float x, float y, float z) { }

	// RVA: 0x14D47E8
	void Vertex(Vector3 v) { }

	// RVA: 0x14D4844
	void TexCoord3(float x, float y, float z) { }

	// RVA: 0x14D48A0
	void TexCoord2(float x, float y) { }

	// RVA: 0x14D48F0
	void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x14D4954
	void Color(Color c) { }

	// RVA: 0x14D49B8
	void Flush() { }

	// RVA: 0x14D49F8
	void SetViewMatrix(Matrix4x4 m) { }

	// RVA: 0x14D4A98
	void set_modelview(Matrix4x4 value) { }

	// RVA: 0x14D4B08
	void PushMatrix() { }

	// RVA: 0x14D4B48
	void PopMatrix() { }

	// RVA: 0x14D4B88
	void LoadOrtho() { }

	// RVA: 0x14D4BC8
	void LoadPixelMatrix() { }

	// RVA: 0x14D4C08
	void LoadProjectionMatrix(Matrix4x4 mat) { }

	// RVA: 0x14D4CA8
	Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	// RVA: 0x14D4D80
	void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x14D4DE4
	void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	// RVA: 0x14D4E48
	void Begin(int mode) { }

	// RVA: 0x14D4E98
	void End() { }

	// RVA: 0x14D4ED8
	void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x14D4FB8
	void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x14D5030
	void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x14D509C
	void Viewport(Rect pixelRect) { }

	// RVA: 0x14D4A48
	void SetViewMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x14D4C58
	void LoadProjectionMatrix_Injected(ref Matrix4x4 mat) { }

	// RVA: 0x14D4D28
	void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }

	// RVA: 0x14D4F50
	void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	// RVA: 0x14D5104
	void Viewport_Injected(ref Rect pixelRect) { }

}

// Namespace: UnityEngine
public sealed class LightmapSettings 
{
	// Methods

	// RVA: 0x14D5154
	void set_lightProbes(LightProbes value) { }

}

// Namespace: UnityEngine
public sealed class LightProbes 
{
	// Fields
	private static Action lightProbesUpdated; // 0x0
	private static Action tetrahedralizationCompleted; // 0x8
	private static Action needsRetetrahedralization; // 0x10

	// Methods

	// RVA: 0x14D51A4
	void Internal_CallLightProbesUpdatedFunction() { }

	// RVA: 0x14D520C
	void Internal_CallTetrahedralizationCompletedFunction() { }

	// RVA: 0x14D5274
	void Internal_CallNeedsRetetrahedralizationFunction() { }

	// RVA: 0x14D52DC
	void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }

	// RVA: 0x14D5344
	void GetInterpolatedProbe_Injected(ref Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe) { }

}

// Namespace: UnityEngine
public struct Resolution 
{
	// Fields
	private int m_Width; // 0x10
	private int m_Height; // 0x14
	private RefreshRate m_RefreshRate; // 0x18

	// Methods

	// RVA: 0x14D539C
	int get_width() { }

	// RVA: 0x14D53A4
	int get_height() { }

	// RVA: 0x14D53AC
	RefreshRate get_refreshRateRatio() { }

	// RVA: 0x14D53B4
	int get_refreshRate() { }

	// RVA: 0x14D54C8
	string ToString() { }

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

	// RVA: 0x14D5670
	void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	// RVA: 0x14D56F4
	float get_lodBias() { }

	// RVA: 0x14D5734
	void set_lodBias(float value) { }

	// RVA: 0x14D578C
	void set_anisotropicFiltering(AnisotropicFiltering value) { }

	// RVA: 0x14D57DC
	int get_globalTextureMipmapLimit() { }

	// RVA: 0x14D581C
	void set_globalTextureMipmapLimit(int value) { }

	// RVA: 0x14D586C
	void set_maximumLODLevel(int value) { }

	// RVA: 0x14D58BC
	int get_vSyncCount() { }

	// RVA: 0x14D58FC
	void set_vSyncCount(int value) { }

	// RVA: 0x14D594C
	void set_antiAliasing(int value) { }

	// RVA: 0x14D599C
	void SetTextureMipmapLimitSettings(string groupName, TextureMipmapLimitSettings textureMipmapLimitSettings) { }

	// RVA: 0x14D5A58
	TextureMipmapLimitSettings GetTextureMipmapLimitSettings(string groupName) { }

	// RVA: 0x14D5B18
	ColorSpace get_activeColorSpace() { }

	// RVA: 0x14D59F0
	void SetTextureMipmapLimitSettings_Injected(string groupName, ref TextureMipmapLimitSettings textureMipmapLimitSettings) { }

	// RVA: 0x14D5AB0
	void GetTextureMipmapLimitSettings_Injected(string groupName, out TextureMipmapLimitSettings ret) { }

}

// Namespace: UnityEngine
public sealed class TrailRenderer 
{
	// Methods

	// RVA: 0x14D5B58
	void set_startColor(Color value) { }

	// RVA: 0x14D5C18
	void set_endColor(Color value) { }

	// RVA: 0x14D5CD8
	int get_positionCount() { }

	// RVA: 0x14D5D28
	void Clear() { }

	// RVA: 0x14D5BB0
	void set_startColor_Injected(ref Color value) { }

	// RVA: 0x14D5C70
	void set_endColor_Injected(ref Color value) { }

}

// Namespace: UnityEngine
public sealed class MaterialPropertyBlock 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x14D5D78
	void SetFloatImpl(int name, float value) { }

	// RVA: 0x14D5DD8
	void SetVectorImpl(int name, Vector4 value) { }

	// RVA: 0x14D5E98
	void SetColorImpl(int name, Color value) { }

	// RVA: 0x14D5F58
	void SetMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x14D6008
	void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x14D6060
	void SetFloatArrayImpl(int name, float[] values, int count) { }

	// RVA: 0x14D60C8
	void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x14D6130
	IntPtr CreateImpl() { }

	// RVA: 0x14D6170
	void DestroyImpl(IntPtr mpb) { }

	// RVA: 0x14D61C0
	void Clear(bool keepMemory) { }

	// RVA: 0x14D6228
	void Clear() { }

	// RVA: 0x14D6280
	void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x14D63AC
	void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x14D64D8
	void .ctor() { }

	// RVA: 0x14D6534
	void Finalize() { }

	// RVA: 0x14D6654
	void Dispose() { }

	// RVA: 0x14D6720
	void SetFloat(string name, float value) { }

	// RVA: 0x14D6818
	void SetFloat(int nameID, float value) { }

	// RVA: 0x14D6878
	void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x14D68E0
	void SetColor(int nameID, Color value) { }

	// RVA: 0x14D6948
	void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x14D69E8
	void SetTexture(int nameID, Texture value) { }

	// RVA: 0x14D6A40
	void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x14D6A5C
	void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x14D5E40
	void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x14D5F00
	void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x14D5FB0
	void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

// Namespace: UnityEngine
public class Renderer 
{
	// Methods

	// RVA: 0x14D6A78
	Bounds get_bounds() { }

	// RVA: 0x14D6B54
	void SetStaticLightmapST(Vector4 st) { }

	// RVA: 0x14D6C14
	Material GetMaterial() { }

	// RVA: 0x14D6C64
	Material GetSharedMaterial() { }

	// RVA: 0x14D6CB4
	void SetMaterial(Material m) { }

	// RVA: 0x14D6D1C
	Material[] GetMaterialArray() { }

	// RVA: 0x14D6D6C
	void CopySharedMaterialArray([Out] Material[] m) { }

	// RVA: 0x14D6DD4
	void SetMaterialArray(Material[] m, int length) { }

	// RVA: 0x14D6E2C
	void SetMaterialArray(Material[] m) { }

	// RVA: 0x14D6E98
	void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x14D6F00
	void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	// RVA: 0x14D6F68
	void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x14D6FD0
	void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x14D7038
	bool get_enabled() { }

	// RVA: 0x14D7088
	void set_enabled(bool value) { }

	// RVA: 0x14D70F0
	void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x14D7158
	void set_receiveShadows(bool value) { }

	// RVA: 0x14D71C0
	LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x14D7210
	void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x14D7278
	void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x14D72E0
	void set_allowOcclusionWhenDynamic(bool value) { }

	// RVA: 0x14D7348
	Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x14D7428
	void set_probeAnchor(Transform value) { }

	// RVA: 0x14D7490
	int GetLightmapIndex(LightmapType lt) { }

	// RVA: 0x14D74F8
	void SetLightmapIndex(int index, LightmapType lt) { }

	// RVA: 0x14D7550
	Vector4 GetLightmapST(LightmapType lt) { }

	// RVA: 0x14D7614
	int get_lightmapIndex() { }

	// RVA: 0x14D766C
	void set_lightmapIndex(int value) { }

	// RVA: 0x14D76C0
	Vector4 get_lightmapScaleOffset() { }

	// RVA: 0x14D7720
	void set_lightmapScaleOffset(Vector4 value) { }

	// RVA: 0x14D7778
	int GetMaterialCount() { }

	// RVA: 0x14D77C8
	Material[] GetSharedMaterialArray() { }

	// RVA: 0x14D7818
	Material[] get_materials() { }

	// RVA: 0x14D7868
	void set_materials(Material[] value) { }

	// RVA: 0x14D78D4
	Material get_material() { }

	// RVA: 0x14D7924
	Material get_sharedMaterial() { }

	// RVA: 0x14D7974
	void set_sharedMaterial(Material value) { }

	// RVA: 0x14D79DC
	Material[] get_sharedMaterials() { }

	// RVA: 0x14D7A2C
	void set_sharedMaterials(Material[] value) { }

	// RVA: 0x14D7A98
	void GetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material> m) { }

	// RVA: 0x14D7BD4
	void .ctor() { }

	// RVA: 0x14D6AEC
	void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x14D6BAC
	void SetStaticLightmapST_Injected(ref Vector4 st) { }

	// RVA: 0x14D73C0
	void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x14D75BC
	void GetLightmapST_Injected(LightmapType lt, out Vector4 ret) { }

}

// Namespace: UnityEngine
public sealed class RenderSettings 
{}

// Namespace: UnityEngine
public sealed class Shader 
{
	// Methods

	// RVA: 0x14D7BDC
	Shader Find(string name) { }

	// RVA: 0x14D7C6C
	int get_globalMaximumLOD() { }

	// RVA: 0x14D7CAC
	void set_globalMaximumLOD(int value) { }

	// RVA: 0x14D7CFC
	void EnableKeyword(string keyword) { }

	// RVA: 0x14D7D4C
	void DisableKeyword(string keyword) { }

	// RVA: 0x14D7D9C
	int get_renderQueue() { }

	// RVA: 0x14D7DEC
	void WarmupAllShaders() { }

	// RVA: 0x14D7E2C
	int TagToID(string name) { }

	// RVA: 0x14D67C8
	int PropertyToID(string name) { }

	// RVA: 0x14D7E7C
	void SetGlobalFloatImpl(int name, float value) { }

	// RVA: 0x14D7EE4
	void SetGlobalVectorImpl(int name, Vector4 value) { }

	// RVA: 0x14D7FA4
	void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x14D8074
	void SetGlobalTextureImpl(int name, Texture value) { }

	// RVA: 0x14D80DC
	Vector4 GetGlobalVectorImpl(int name) { }

	// RVA: 0x14D81A0
	void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x14D8208
	void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x14D82AC
	void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x14D8304
	void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x14D835C
	void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x14D83BC
	void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x14D8424
	Vector4 GetGlobalVector(int nameID) { }

	// RVA: 0x14D8480
	void .ctor() { }

	// RVA: 0x14D7F3C
	void SetGlobalVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x14D800C
	void SetGlobalMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x14D8138
	void GetGlobalVectorImpl_Injected(int name, out Vector4 ret) { }

}

// Namespace: UnityEngine
public class Material 
{
	// Methods

	// RVA: 0x14D8508
	void CreateWithShader(Material self, Shader shader) { }

	// RVA: 0x14D8570
	void CreateWithMaterial(Material self, Material source) { }

	// RVA: 0x14D85D8
	void CreateWithString(Material self) { }

	// RVA: 0x14D8628
	void .ctor(Shader shader) { }

	// RVA: 0x14D86F8
	void .ctor(Material source) { }

	// RVA: 0x14D87C8
	void .ctor(string contents) { }

	// RVA: 0x14D888C
	Shader get_shader() { }

	// RVA: 0x14D88DC
	void set_shader(Shader value) { }

	// RVA: 0x14D8944
	Color get_color() { }

	// RVA: 0x14D8BD4
	Texture get_mainTexture() { }

	// RVA: 0x14D8E00
	void set_mainTexture(Texture value) { }

	// RVA: 0x14D8A68
	int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	// RVA: 0x14D9004
	bool HasProperty(int nameID) { }

	// RVA: 0x14D906C
	bool HasProperty(string name) { }

	// RVA: 0x14D9118
	int get_renderQueue() { }

	// RVA: 0x14D9168
	void EnableKeyword(string keyword) { }

	// RVA: 0x14D91D0
	void DisableKeyword(string keyword) { }

	// RVA: 0x14D9238
	bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x14D92A0
	string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x14D9308
	string GetTag(string tag, bool searchFallbacks) { }

	// RVA: 0x14D9398
	bool SetPass(int pass) { }

	// RVA: 0x14D9400
	void CopyPropertiesFromMaterial(Material mat) { }

	// RVA: 0x14D9468
	string[] GetShaderKeywords() { }

	// RVA: 0x14D94B8
	void SetShaderKeywords(string[] names) { }

	// RVA: 0x14D9520
	string[] get_shaderKeywords() { }

	// RVA: 0x14D9570
	void set_shaderKeywords(string[] value) { }

	// RVA: 0x14D95D8
	int ComputeCRC() { }

	// RVA: 0x14D9628
	void SetFloatImpl(int name, float value) { }

	// RVA: 0x14D9688
	void SetColorImpl(int name, Color value) { }

	// RVA: 0x14D9748
	void SetMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x14D97F8
	void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x14D9850
	float GetFloatImpl(int name) { }

	// RVA: 0x14D98B8
	Color GetColorImpl(int name) { }

	// RVA: 0x14D997C
	Texture GetTextureImpl(int name) { }

	// RVA: 0x14D99E4
	void SetColorArrayImpl(int name, Color[] values, int count) { }

	// RVA: 0x14D9A4C
	void SetColorArray(int name, Color[] values, int count) { }

	// RVA: 0x14D9B78
	void SetInt(string name, int value) { }

	// RVA: 0x14D9C18
	void SetFloat(string name, float value) { }

	// RVA: 0x14D9CC0
	void SetFloat(int nameID, float value) { }

	// RVA: 0x14D9D20
	void SetColor(string name, Color value) { }

	// RVA: 0x14D9DD4
	void SetColor(int nameID, Color value) { }

	// RVA: 0x14D9E3C
	void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x14D9EA4
	void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x14D8F64
	void SetTexture(string name, Texture value) { }

	// RVA: 0x14D8F0C
	void SetTexture(int nameID, Texture value) { }

	// RVA: 0x14D9F14
	void SetColorArray(int nameID, Color[] values) { }

	// RVA: 0x14D9F30
	float GetFloat(int nameID) { }

	// RVA: 0x14D8B3C
	Color GetColor(string name) { }

	// RVA: 0x14D8AD0
	Color GetColor(int nameID) { }

	// RVA: 0x14D8D54
	Texture GetTexture(string name) { }

	// RVA: 0x14D8CEC
	Texture GetTexture(int nameID) { }

	// RVA: 0x14D96F0
	void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x14D97A0
	void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x14D9924
	void GetColorImpl_Injected(int name, out Color ret) { }

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

	// RVA: 0x14D9F98
	LightType get_type() { }

	// RVA: 0x14D9FE8
	float get_spotAngle() { }

	// RVA: 0x14DA038
	Color get_color() { }

	// RVA: 0x14DA0FC
	float get_colorTemperature() { }

	// RVA: 0x14DA14C
	bool get_useColorTemperature() { }

	// RVA: 0x14DA19C
	float get_intensity() { }

	// RVA: 0x14DA1EC
	float get_bounceIntensity() { }

	// RVA: 0x14DA23C
	float get_range() { }

	// RVA: 0x14DA28C
	LightBakingOutput get_bakingOutput() { }

	// RVA: 0x14DA368
	LightShadows get_shadows() { }

	// RVA: 0x14DA3B8
	float get_cookieSize() { }

	// RVA: 0x14DA408
	Texture get_cookie() { }

	// RVA: 0x14DA094
	void get_color_Injected(out Color ret) { }

	// RVA: 0x14DA300
	void get_bakingOutput_Injected(out LightBakingOutput ret) { }

}

// Namespace: UnityEngine
public sealed class MeshFilter 
{
	// Methods

	// RVA: 0x14DA458
	void DontStripMeshFilter() { }

	// RVA: 0x14DA45C
	Mesh get_sharedMesh() { }

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

	// RVA: 0x14DA4AC
	void set_limitBiasMode(TextureMipmapLimitBiasMode value) { }

	// RVA: 0x14DA4B4
	void set_limitBias(int value) { }

}

// Namespace: UnityEngine
public class SkinnedMeshRenderer 
{
	// Methods

	// RVA: 0x14DA4BC
	void set_quality(SkinQuality value) { }

	// RVA: 0x14DA524
	void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x14DA58C
	void set_forceMatrixRecalculationPerRender(bool value) { }

	// RVA: 0x14DA5F4
	Transform get_rootBone() { }

	// RVA: 0x14DA644
	void set_rootBone(Transform value) { }

	// RVA: 0x14DA6AC
	Transform[] get_bones() { }

	// RVA: 0x14DA6FC
	void set_bones(Transform[] value) { }

	// RVA: 0x14DA764
	Mesh get_sharedMesh() { }

	// RVA: 0x14DA7B4
	void set_sharedMesh(Mesh value) { }

}

// Namespace: UnityEngine
public class MeshRenderer 
{
	// Methods

	// RVA: 0x14DA81C
	void DontStripMeshRenderer() { }

}

// Namespace: UnityEngine
public sealed class LightProbeGroup 
{
	// Methods

	// RVA: 0x14DA820
	Vector3[] get_probePositions() { }

	// RVA: 0x14DA828
	void .ctor() { }

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

	// RVA: 0x14DA830
	void Internal_Create(Mesh mono) { }

	// RVA: 0x14DA880
	void .ctor() { }

	// RVA: 0x14DA944
	void set_indexFormat(IndexFormat value) { }

	// RVA: 0x14DA9AC
	void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	// RVA: 0x14DAA04
	void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x14DAA8C
	void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x14DAAE4
	void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x14DAB7C
	UInt32 GetBaseVertexImpl(int submesh) { }

	// RVA: 0x14DABE4
	int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	// RVA: 0x14DAC3C
	int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	// RVA: 0x14DAC94
	void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	// RVA: 0x14DAD34
	void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	// RVA: 0x14DAD9C
	bool HasVertexAttribute(VertexAttribute attr) { }

	// RVA: 0x14DAE04
	void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x14DAEA4
	Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: 0x14DAF0C
	void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	// RVA: 0x14DAF7C
	IntPtr GetNativeIndexBufferPtr() { }

	// RVA: 0x14DAFCC
	BoneWeight[] GetBoneWeightsImpl() { }

	// RVA: 0x14DB01C
	void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x14DB084
	Matrix4x4[] get_bindposes() { }

	// RVA: 0x14DB0D4
	void set_bindposes(Matrix4x4[] value) { }

	// RVA: 0x14DB13C
	bool get_isReadable() { }

	// RVA: 0x14DB18C
	bool get_canAccess() { }

	// RVA: 0x14DB1DC
	int get_vertexCount() { }

	// RVA: 0x14DB22C
	int get_subMeshCount() { }

	// RVA: 0x14DB27C
	void set_subMeshCount(int value) { }

	// RVA: 0x14DB2E4
	void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0x14DB3B4
	void SetAllSubMeshesAtOnceFromArray(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags) { }

	// RVA: 0x14DB424
	Bounds get_bounds() { }

	// RVA: 0x14DB500
	void set_bounds(Bounds value) { }

	// RVA: 0x14DB5D0
	void ClearImpl(bool keepVertexLayout) { }

	// RVA: 0x14DB638
	void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	// RVA: 0x14DB6A0
	void MarkDynamicImpl() { }

	// RVA: 0x14DB6F0
	void UploadMeshDataImpl(bool markNoLongerReadable) { }

	// RVA: 0x14DB758
	MeshTopology GetTopologyImpl(int submesh) { }

	// RVA: 0x14DB7C0
	VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x14DB838
	int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1
	T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: -1
	T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	// RVA: 0x14DB8D8
	void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x309AF8C
	void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags) { }

	// RVA: 0x309AF8C
	void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x309AF8C
	void SetListForChannel(VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1
	void GetListForChannel(System.Collections.Generic.List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	// RVA: 0x309AF8C
	void GetListForChannel(System.Collections.Generic.List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	// RVA: 0x14DBB88
	Vector3[] get_vertices() { }

	// RVA: 0x14DBBE0
	void set_vertices(Vector3[] value) { }

	// RVA: 0x14DBC44
	Vector3[] get_normals() { }

	// RVA: 0x14DBC9C
	void set_normals(Vector3[] value) { }

	// RVA: 0x14DBD00
	Vector4[] get_tangents() { }

	// RVA: 0x14DBD58
	void set_tangents(Vector4[] value) { }

	// RVA: 0x14DBDBC
	Vector2[] get_uv() { }

	// RVA: 0x14DBE14
	void set_uv(Vector2[] value) { }

	// RVA: 0x14DBE78
	Vector2[] get_uv2() { }

	// RVA: 0x14DBED0
	void set_uv2(Vector2[] value) { }

	// RVA: 0x14DBF34
	Color[] get_colors() { }

	// RVA: 0x14DBF8C
	void set_colors(Color[] value) { }

	// RVA: 0x14DBFF0
	Color32[] get_colors32() { }

	// RVA: 0x14DC050
	void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices) { }

	// RVA: 0x14DC0FC
	void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length) { }

	// RVA: 0x14DC178
	void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x14DC200
	void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals) { }

	// RVA: 0x14DC2AC
	void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length) { }

	// RVA: 0x14DC328
	void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x14DC3B0
	void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents) { }

	// RVA: 0x14DC45C
	void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length) { }

	// RVA: 0x14DC4D8
	void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x14DC560
	void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors) { }

	// RVA: 0x14DC624
	void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length) { }

	// RVA: 0x14DC6B8
	void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x309AF8C
	void SetUvsImpl(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x14DC758
	void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x14DC80C
	void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length) { }

	// RVA: 0x14DC898
	void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x309AF8C
	void GetUVsImpl(int uvIndex, System.Collections.Generic.List<T> uvs, int dim) { }

	// RVA: 0x14DC928
	void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x14DC998
	void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x309AF8C
	void SetVertexBufferData(T[] data, int dataStart, int meshBufferStart, int count, int stream, MeshUpdateFlags flags) { }

	// RVA: 0x14DC9F0
	void PrintErrorCantAccessIndices() { }

	// RVA: 0x14DCA98
	bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x14DCC98
	bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x14DCCA0
	bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x14DCCA8
	int[] get_triangles() { }

	// RVA: 0x14DCDF0
	void set_triangles(int[] value) { }

	// RVA: 0x14DD018
	int[] GetTriangles(int submesh) { }

	// RVA: 0x14DD0D4
	int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	// RVA: 0x14DD194
	int[] GetIndices(int submesh) { }

	// RVA: 0x14DD250
	int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x309AF8C
	void SetIndexBufferData(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags) { }

	// RVA: 0x14DD310
	UInt32 GetBaseVertex(int submesh) { }

	// RVA: 0x14DD3F4
	void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x14DCF6C
	void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	// RVA: 0x14DD59C
	void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int submesh) { }

	// RVA: 0x14DD620
	void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x14DD6B4
	void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x14DD7C0
	void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x14DD894
	void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x14DD96C
	void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x14DDA50
	void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x14DDB34
	void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags) { }

	// RVA: 0x14DDE30
	BoneWeight[] get_boneWeights() { }

	// RVA: 0x14DDE80
	void set_boneWeights(BoneWeight[] value) { }

	// RVA: 0x14DDEE8
	void Clear() { }

	// RVA: 0x14DDF40
	void RecalculateBounds() { }

	// RVA: 0x14DDF48
	void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x14DE088
	void MarkDynamic() { }

	// RVA: 0x14DE11C
	void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x14DE1CC
	MeshTopology GetTopology(int submesh) { }

	// RVA: 0x14DB34C
	void SetSubMesh_Injected(int index, ref SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0x14DB498
	void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x14DB568
	void set_bounds_Injected(ref Bounds value) { }

}

// Namespace: UnityEngine
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

	// RVA: 0x14DE2E4
	float get_weight0() { }

	// RVA: 0x14DE2EC
	float get_weight1() { }

	// RVA: 0x14DE2F4
	float get_weight2() { }

	// RVA: 0x14DE2FC
	float get_weight3() { }

	// RVA: 0x14DE304
	int get_boneIndex0() { }

	// RVA: 0x14DE30C
	int get_boneIndex1() { }

	// RVA: 0x14DE314
	int get_boneIndex2() { }

	// RVA: 0x14DE31C
	int get_boneIndex3() { }

	// RVA: 0x14DE324
	int GetHashCode() { }

	// RVA: 0x14DE438
	bool Equals(object other) { }

	// RVA: 0x14DE4D8
	bool Equals(BoneWeight other) { }

}

// Namespace: UnityEngine
public class Texture 
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Methods

	// RVA: 0x14DE5B4
	void .ctor() { }

	// RVA: 0x14DE63C
	int get_mipmapCount() { }

	// RVA: 0x14DE68C
	void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	// RVA: 0x14DE6F4
	int GetDataWidth() { }

	// RVA: 0x14DE744
	int GetDataHeight() { }

	// RVA: 0x14DE794
	int get_width() { }

	// RVA: 0x14DE7E4
	void set_width(int value) { }

	// RVA: 0x14DE824
	int get_height() { }

	// RVA: 0x14DE874
	void set_height(int value) { }

	// RVA: 0x14DE8B4
	bool get_isReadable() { }

	// RVA: 0x14DE904
	TextureWrapMode get_wrapMode() { }

	// RVA: 0x14DE954
	void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x14DE9BC
	FilterMode get_filterMode() { }

	// RVA: 0x14DEA0C
	void set_filterMode(FilterMode value) { }

	// RVA: 0x14DEA74
	void set_mipMapBias(float value) { }

	// RVA: 0x14DEADC
	Vector2 get_texelSize() { }

	// RVA: 0x14DEB9C
	int Internal_GetActiveTextureColorSpace() { }

	// RVA: 0x14DEBEC
	ColorSpace get_activeTextureColorSpace() { }

	// RVA: 0x14DEC38
	TextureColorSpace GetTextureColorSpace(bool linear) { }

	// RVA: 0x14DEC40
	TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	// RVA: 0x14DECA8
	bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x14DEE9C
	bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x14DF06C
	UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x14DF110
	UnityException CreateNativeArrayLengthOverflowException() { }

	// RVA: 0x14DF188
	void .cctor() { }

	// RVA: 0x14DEB34
	void get_texelSize_Injected(out Vector2 ret) { }

}

// Namespace: UnityEngine
public sealed class Texture2D 
{
	// Fields
	internal const int streamingMipmapsPriorityMin = 4294967168;
	internal const int streamingMipmapsPriorityMax = 127;

	// Methods

	// RVA: 0x14DF1D8
	TextureFormat get_format() { }

	// RVA: 0x14DF228
	Texture2D get_whiteTexture() { }

	// RVA: 0x14DF268
	void Compress(bool highQuality) { }

	// RVA: 0x14DF2D0
	bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x14DF370
	void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x14DF468
	bool get_isReadable() { }

	// RVA: 0x14DF4B8
	void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x14DF510
	bool ReinitializeImpl(int width, int height) { }

	// RVA: 0x14DF568
	void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	// RVA: 0x14DF670
	Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	// RVA: 0x14DF77C
	bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	// RVA: 0x14DF7EC
	void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x14DF8DC
	void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	// RVA: 0x14DF974
	IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x14DF9DC
	UInt64 GetRawImageDataSize() { }

	// RVA: 0x14DFA2C
	void SetAllPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x14DFA84
	bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x14DFB68
	bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x14DFCB4
	void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x14DFE78
	void .ctor(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14DFF34
	void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14DFFE4
	void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x14E0204
	void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x14E0230
	void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x14E02F0
	void .ctor(int width, int height) { }

	// RVA: 0x14E0398
	void SetPixel(int x, int y, Color color) { }

	// RVA: 0x14E0464
	void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x14E0524
	void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	// RVA: 0x14E05E0
	Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x309AF8C
	Unity.Collections.NativeArray<T> GetRawTextureData() { }

	// RVA: 0x14E0690
	void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x14E071C
	void Apply() { }

	// RVA: 0x14E07B0
	bool Reinitialize(int width, int height) { }

	// RVA: 0x14E083C
	bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x14E08AC
	void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x14E0980
	void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x14E0A48
	void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x14E0AA0
	void SetPixels32(Color32[] colors) { }

	// RVA: 0x14DF5F0
	void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }

	// RVA: 0x14DF6FC
	void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret) { }

	// RVA: 0x14DF86C
	void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

// Namespace: UnityEngine
public sealed class Cubemap 
{
	// Methods

	// RVA: 0x14E0AF4
	bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x14E0B7C
	void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x14E0C54
	bool get_isReadable() { }

	// RVA: 0x14E0CA4
	bool ValidateFormat(TextureFormat format, int width) { }

	// RVA: 0x14E0D7C
	bool ValidateFormat(GraphicsFormat format, int width) { }

	// RVA: 0x14E0EB4
	void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14E0FD8
	void .ctor(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x14E0F4C
	void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14E1028
	void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x14E1280
	void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x14E149C
	void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x14E153C
	void .ctor(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x14E15E0
	void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x14E15EC
	void .ctor(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	// RVA: 0x14E1224
	void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public sealed class Texture3D 
{
	// Methods

	// RVA: 0x14E15F8
	bool get_isReadable() { }

	// RVA: 0x14E1648
	bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x14E16E8
	void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x14E17E0
	void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14E1934
	void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x14E1890
	void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14E199C
	void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x14E1C00
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x14E1C24
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x14E1C44
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x14E1E78
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x14E1F3C
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x14E2004
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x14E1BA4
	void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public sealed class Texture2DArray 
{
	// Methods

	// RVA: 0x14E20CC
	int get_allSlices() { }

	// RVA: 0x14E210C
	bool get_isReadable() { }

	// RVA: 0x14E215C
	bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x14E21F4
	void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x14E22DC
	bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x14E23C0
	bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x14E250C
	void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14E2660
	void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x14E25BC
	void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14E28B8
	void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x14E2AC0
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x14E2D08
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x14E2D28
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x14E2DF0
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x14E2EB8
	void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x14E285C
	void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public sealed class CubemapArray 
{
	// Methods

	// RVA: 0x14E2F7C
	bool get_isReadable() { }

	// RVA: 0x14E2FCC
	bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x14E3054
	void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x14E312C
	void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14E3270
	void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x14E31D4
	void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x14E32D0
	void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x14E3538
	void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x14E3760
	void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x14E3768
	void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x14E3820
	void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x14E38D4
	void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x14E34DC
	void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public class RenderTexture 
{
	// Methods

	// RVA: 0x14E397C
	int get_width() { }

	// RVA: 0x14E39CC
	void set_width(int value) { }

	// RVA: 0x14E3A34
	int get_height() { }

	// RVA: 0x14E3A84
	void set_height(int value) { }

	// RVA: 0x14E3AEC
	GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	// RVA: 0x14E3B54
	void SetColorFormat(GraphicsFormat format) { }

	// RVA: 0x14E3BBC
	GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x14E3C14
	void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x14E3C7C
	void set_useMipMap(bool value) { }

	// RVA: 0x14E3CE4
	RenderTextureFormat get_format() { }

	// RVA: 0x14E3EAC
	GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x14E3EFC
	void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x14E3F64
	void set_autoGenerateMips(bool value) { }

	// RVA: 0x14E3FCC
	RenderTexture GetActive() { }

	// RVA: 0x14E400C
	void SetActive(RenderTexture rt) { }

	// RVA: 0x14E405C
	RenderTexture get_active() { }

	// RVA: 0x14E409C
	void set_active(RenderTexture value) { }

	// RVA: 0x14E40EC
	RenderBuffer GetColorBuffer() { }

	// RVA: 0x14E41AC
	RenderBuffer GetDepthBuffer() { }

	// RVA: 0x14E426C
	void SetMipMapCount(int count) { }

	// RVA: 0x14D3CC8
	RenderBuffer get_colorBuffer() { }

	// RVA: 0x14D3D20
	RenderBuffer get_depthBuffer() { }

	// RVA: 0x14E42D4
	void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x14E432C
	void DiscardContents() { }

	// RVA: 0x14E438C
	bool Create() { }

	// RVA: 0x14E43DC
	void Release() { }

	// RVA: 0x14E442C
	bool IsCreated() { }

	// RVA: 0x14E447C
	void SetSRGBReadWrite(bool srgb) { }

	// RVA: 0x14E44E4
	void Internal_Create(RenderTexture rt) { }

	// RVA: 0x14E4534
	void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	// RVA: 0x14E3E28
	RenderTextureDescriptor GetDescriptor() { }

	// RVA: 0x14E466C
	RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	// RVA: 0x14E470C
	void ReleaseTemporary(RenderTexture temp) { }

	// RVA: 0x14E475C
	int get_depth() { }

	// RVA: 0x14E47AC
	void .ctor() { }

	// RVA: 0x14E488C
	void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x14E4E5C
	void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x14E5170
	void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x14E5638
	void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x14E56D4
	void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x14E5344
	void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x14E5ADC
	void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x14E5B78
	void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x14E5F54
	void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	// RVA: 0x14E6100
	void .ctor(int width, int height, int depth) { }

	// RVA: 0x14E5FF0
	void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x14E5C98
	void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	// RVA: 0x14E5A20
	GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	// RVA: 0x14E62DC
	GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	// RVA: 0x14E644C
	GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	// RVA: 0x14E6398
	GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	// RVA: 0x14E50E0
	RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x14E49F4
	void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x14E524C
	GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	// RVA: 0x14E5274
	GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	// RVA: 0x14E6190
	GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x14E6508
	RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x14E65B4
	RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	// RVA: 0x14E66B4
	RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	// RVA: 0x14E6864
	RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	// RVA: 0x14E6884
	RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x14E68A8
	RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x14E68D0
	RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x14E68FC
	RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x14E692C
	RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	// RVA: 0x14E6960
	RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x14E4144
	void GetColorBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x14E4204
	void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	// RVA: 0x14E459C
	void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x14E4604
	void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	// RVA: 0x14E46BC
	RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

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

	// RVA: 0x14E6998
	int get_width() { }

	// RVA: 0x14E69A0
	void set_width(int value) { }

	// RVA: 0x14E69A8
	int get_height() { }

	// RVA: 0x14E69B0
	void set_height(int value) { }

	// RVA: 0x14E69B8
	int get_msaaSamples() { }

	// RVA: 0x14E69C0
	void set_msaaSamples(int value) { }

	// RVA: 0x14E69C8
	int get_volumeDepth() { }

	// RVA: 0x14E69D0
	void set_volumeDepth(int value) { }

	// RVA: 0x14E69D8
	void set_mipCount(int value) { }

	// RVA: 0x14E69E0
	GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x14E69E8
	void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x14E6BA4
	void set_stencilFormat(GraphicsFormat value) { }

	// RVA: 0x14E6BAC
	GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x14E6BB4
	void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x14E6BBC
	RenderTextureFormat get_colorFormat() { }

	// RVA: 0x14E6C50
	void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x14E6D40
	bool get_sRGB() { }

	// RVA: 0x14E6DD0
	void set_sRGB(bool value) { }

	// RVA: 0x14E6AE0
	int get_depthBufferBits() { }

	// RVA: 0x14E6B70
	void set_depthBufferBits(int value) { }

	// RVA: 0x14E6F40
	TextureDimension get_dimension() { }

	// RVA: 0x14E6F48
	void set_dimension(TextureDimension value) { }

	// RVA: 0x14E6F50
	ShadowSamplingMode get_shadowSamplingMode() { }

	// RVA: 0x14E6F58
	void set_shadowSamplingMode(ShadowSamplingMode value) { }

	// RVA: 0x14E6F60
	void set_vrUsage(VRTextureUsage value) { }

	// RVA: 0x14E6F68
	void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x14E6F70
	void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x14E7038
	void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x14E6AC4
	void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x14E70A0
	void set_useMipMap(bool value) { }

	// RVA: 0x14E70B4
	void set_autoGenerateMips(bool value) { }

	// RVA: 0x14E70D4
	void set_enableRandomWrite(bool value) { }

	// RVA: 0x14E70F4
	void set_bindMS(bool value) { }

	// RVA: 0x14E7114
	void set_createdFromScript(bool value) { }

	// RVA: 0x14E7134
	void set_useDynamicScale(bool value) { }

}

// Namespace: UnityEngine
public class Handheld 
{
	// Methods

	// RVA: 0x14E7154
	void Vibrate() { }

}

// Namespace: UnityEngine
public struct Hash128 
{
	// Fields
	internal UInt64 u64_0; // 0x10
	internal UInt64 u64_1; // 0x18

	// Methods

	// RVA: 0x14E7194
	void .ctor(UInt64 u64_0, UInt64 u64_1) { }

	// RVA: 0x14E719C
	int CompareTo(Hash128 rhs) { }

	// RVA: 0x14E7228
	string ToString() { }

	// RVA: 0x14E72F4
	Hash128 Parse(string hashString) { }

	// RVA: 0x14E7290
	string Hash128ToStringImpl(Hash128 hash) { }

	// RVA: 0x14E7404
	bool Equals(object obj) { }

	// RVA: 0x14E74A8
	bool Equals(Hash128 obj) { }

	// RVA: 0x14E74BC
	int GetHashCode() { }

	// RVA: 0x14E74F4
	int CompareTo(object obj) { }

	// RVA: 0x14E7498
	bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x14E71E8
	bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x14E7200
	bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x14E734C
	void Parse_Injected(string hashString, out Hash128 ret) { }

	// RVA: 0x14E73B4
	string Hash128ToStringImpl_Injected(ref Hash128 hash) { }

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

	// RVA: 0x14E75CC
	void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x14E7688
	void set_visible(bool value) { }

	// RVA: 0x14E76D8
	CursorLockMode get_lockState() { }

	// RVA: 0x14E7718
	void set_lockState(CursorLockMode value) { }

	// RVA: 0x14E7630
	void SetCursor_Injected(Texture2D texture, ref Vector2 hotspot, CursorMode cursorMode) { }

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

	// RVA: 0x2FE360C
	ILogHandler get_logHandler() { }

	// RVA: 0x2FE3054
	bool get_logEnabled() { }

	// RVA: 0x2FE3088
	bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x2FE440C
	void Log(LogType logType, object message) { }

	// RVA: -1
	void Log(LogType logType, object message, object context) { }

	// RVA: -1
	void Log(LogType logType, string tag, object message) { }

	// RVA: 0x2FE47D4
	void Log(string tag, object message) { }

	// RVA: 0x2FE47D4
	void LogWarning(string tag, object message) { }

	// RVA: 0x2FE47D4
	void LogError(string tag, object message) { }

	// RVA: -1
	void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x2FE4574
	void LogException(Exception exception) { }

}

// Namespace: UnityEngine
public interface ILogHandler 
{
	// Methods

	// RVA: -1
	void LogFormat(LogType logType, object context, string format, object[] args) { }

	// RVA: 0x2FE47D4
	void LogException(Exception exception, object context) { }

}

// Namespace: UnityEngine
public class Logger 
{
	// Fields
	private ILogHandler <logHandler>k__BackingField; // 0x10
	private bool <logEnabled>k__BackingField; // 0x18
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x14E7768
	void .ctor(ILogHandler logHandler) { }

	// RVA: 0x14E77B0
	ILogHandler get_logHandler() { }

	// RVA: 0x14E77B8
	void set_logHandler(ILogHandler value) { }

	// RVA: 0x14E77C0
	bool get_logEnabled() { }

	// RVA: 0x14E77C8
	void set_logEnabled(bool value) { }

	// RVA: 0x14E77D0
	LogType get_filterLogType() { }

	// RVA: 0x14E77D8
	void set_filterLogType(LogType value) { }

	// RVA: 0x14E77E0
	bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x14E7814
	string GetString(object message) { }

	// RVA: 0x14E7948
	void Log(LogType logType, object message) { }

	// RVA: 0x14E7AC8
	void Log(LogType logType, object message, object context) { }

	// RVA: 0x14E7C58
	void Log(LogType logType, string tag, object message) { }

	// RVA: 0x14E7E1C
	void Log(string tag, object message) { }

	// RVA: 0x14E7FC8
	void LogWarning(string tag, object message) { }

	// RVA: 0x14E8174
	void LogError(string tag, object message) { }

	// RVA: 0x14E8320
	void LogException(Exception exception) { }

	// RVA: 0x14E83F4
	void LogException(Exception exception, object context) { }

	// RVA: 0x14E84CC
	void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x14E85D0
	void LogFormat(LogType logType, object context, string format, object[] args) { }

}

// Namespace: UnityEngine
internal class UnityLogWriter 
{
	// Methods

	// RVA: 0x14E86D8
	void WriteStringToUnityLog(string s) { }

	// RVA: 0x14E8730
	void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x14E8780
	void Init() { }

	// RVA: 0x14E8910
	Encoding get_Encoding() { }

	// RVA: 0x14E8918
	void Write(Char value) { }

	// RVA: 0x14E89F4
	void Write(string s) { }

	// RVA: 0x14E8A4C
	void Write(Char[] buffer, int index, int count) { }

	// RVA: 0x14E8888
	void .ctor() { }

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

	// RVA: 0x14E8AA8
	void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x14E8AB4
	void .ctor(float r, float g, float b) { }

	// RVA: 0x14E8AC8
	string ToString() { }

	// RVA: 0x14E8D1C
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14E8F60
	int GetHashCode() { }

	// RVA: 0x14E8FE8
	bool Equals(object other) { }

	// RVA: 0x14E90CC
	bool Equals(Color other) { }

	// RVA: 0x14E915C
	Color op_Addition(Color a, Color b) { }

	// RVA: 0x14E9170
	Color op_Multiply(Color a, Color b) { }

	// RVA: 0x14E9184
	Color op_Multiply(Color a, float b) { }

	// RVA: 0x14E9198
	bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x14E91DC
	bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x14E9220
	Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x14E9270
	Color LerpUnclamped(Color a, Color b, float t) { }

	// RVA: 0x14E92A8
	Color RGBMultiplied(float multiplier) { }

	// RVA: 0x14E92C4
	Color get_red() { }

	// RVA: 0x14E92D8
	Color get_green() { }

	// RVA: 0x14E92EC
	Color get_blue() { }

	// RVA: 0x14E9300
	Color get_white() { }

	// RVA: 0x14E9314
	Color get_black() { }

	// RVA: 0x14E9328
	Color get_yellow() { }

	// RVA: 0x14E934C
	Color get_cyan() { }

	// RVA: 0x14E9360
	Color get_magenta() { }

	// RVA: 0x14E9374
	Color get_gray() { }

	// RVA: 0x14E9388
	Color get_clear() { }

	// RVA: 0x14E939C
	Color get_linear() { }

	// RVA: 0x14E94DC
	Color get_gamma() { }

	// RVA: 0x14E961C
	float get_maxColorComponent() { }

	// RVA: 0x14E9638
	Vector4 op_Implicit(Color c) { }

	// RVA: 0x14E963C
	Color op_Implicit(Vector4 v) { }

	// RVA: 0x14E9640
	void RGBToHSV(Color rgbColor, out float H, out float S, out float V) { }

	// RVA: 0x14E9784
	void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, out float H, out float S, out float V) { }

	// RVA: 0x14E97F4
	Color HSVToRGB(float H, float S, float V) { }

	// RVA: 0x14E992C
	Color HSVToRGB(float H, float S, float V, bool hdr) { }

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

	// RVA: 0x14E9A98
	void .ctor(Byte r, Byte g, Byte b, Byte a) { }

	// RVA: 0x14E9AAC
	Color32 op_Implicit(Color c) { }

	// RVA: 0x14E9DA4
	Color op_Implicit(Color32 c) { }

	// RVA: 0x14E9DE0
	string ToString() { }

	// RVA: 0x14EA010
	string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public class ColorUtility 
{
	// Methods

	// RVA: 0x14EA228
	bool DoTryParseHtmlColor(string htmlString, out Color32 color) { }

	// RVA: 0x14EA290
	bool TryParseHtmlString(string htmlString, out Color color) { }

	// RVA: 0x14EA344
	string ToHtmlStringRGB(Color color) { }

	// RVA: 0x14EA7CC
	string ToHtmlStringRGBA(Color color) { }

}

// Namespace: UnityEngine
public class Gradient 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x14EAD9C
	IntPtr Init() { }

	// RVA: 0x14EADDC
	void Cleanup() { }

	// RVA: 0x14EAE2C
	bool Internal_Equals(IntPtr other) { }

	// RVA: 0x14EAE94
	void .ctor() { }

	// RVA: 0x14EAEF0
	void Finalize() { }

	// RVA: 0x14EAFA8
	Color Evaluate(float time) { }

	// RVA: 0x14EB074
	bool Equals(object o) { }

	// RVA: 0x14EB22C
	bool Equals(Gradient other) { }

	// RVA: 0x14EB31C
	int GetHashCode() { }

	// RVA: 0x14EB014
	void Evaluate_Injected(float time, out Color ret) { }

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

	// RVA: 0x14EB328
	Quaternion GetRotation() { }

	// RVA: 0x14EB3EC
	Vector3 GetLossyScale() { }

	// RVA: 0x14EB4B4
	float GetDeterminant() { }

	// RVA: 0x14EB554
	Quaternion get_rotation() { }

	// RVA: 0x14EB5B0
	Vector3 get_lossyScale() { }

	// RVA: 0x14EB610
	float get_determinant() { }

	// RVA: 0x14EB660
	Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x14EB75C
	bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result) { }

	// RVA: 0x14EB82C
	Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x14EB90C
	Matrix4x4 get_inverse() { }

	// RVA: 0x14EB990
	Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0x14EBA70
	Matrix4x4 get_transpose() { }

	// RVA: 0x14EBAF4
	Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x14EBC2C
	Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	// RVA: 0x14EBD34
	void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x14EBD50
	float get_Item(int row, int column) { }

	// RVA: 0x14EBEC4
	void set_Item(int row, int column, float value) { }

	// RVA: 0x14EBD58
	float get_Item(int index) { }

	// RVA: 0x14EBECC
	void set_Item(int index, float value) { }

	// RVA: 0x14EC038
	int GetHashCode() { }

	// RVA: 0x14EC474
	bool Equals(object other) { }

	// RVA: 0x14EC700
	bool Equals(Matrix4x4 other) { }

	// RVA: 0x14EC7AC
	Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x14EC850
	Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x14EC1E8
	Vector4 GetColumn(int index) { }

	// RVA: 0x14EC884
	Vector4 GetRow(int index) { }

	// RVA: 0x14EC960
	void SetColumn(int index, Vector4 column) { }

	// RVA: 0x14EC9DC
	Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x14ECA5C
	Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x14ECAB8
	Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x14ECB04
	Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x14ECB30
	Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x14ECB64
	Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x14ECBFC
	Matrix4x4 get_identity() { }

	// RVA: 0x14ECC60
	string ToString() { }

	// RVA: 0x14ED244
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14ED818
	void .cctor() { }

	// RVA: 0x14EB384
	void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret) { }

	// RVA: 0x14EB44C
	void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret) { }

	// RVA: 0x14EB504
	float GetDeterminant_Injected(ref Matrix4x4 _unity_self) { }

	// RVA: 0x14EB6F4
	void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x14EB7C4
	bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result) { }

	// RVA: 0x14EB8A4
	void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x14EBA08
	void Transpose_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }

	// RVA: 0x14EBBA4
	void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret) { }

	// RVA: 0x14EBCC4
	void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret) { }

}

// Namespace: UnityEngine
public struct Vector3 
{
	// Fields
	public const float kEpsilon = 925353388;
	public const float kEpsilonNormalSqrt = 646978941;
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

	// RVA: 0x14ED894
	Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x14ED97C
	Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x14ED9BC
	Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x14ED9E4
	Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	// RVA: 0x14EDB04
	float get_Item(int index) { }

	// RVA: 0x14EDB90
	void set_Item(int index, float value) { }

	// RVA: 0x14EDC1C
	void .ctor(float x, float y, float z) { }

	// RVA: 0x14EDC28
	void .ctor(float x, float y) { }

	// RVA: 0x14EDC34
	void Set(float newX, float newY, float newZ) { }

	// RVA: 0x14EDC40
	Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x14EDC50
	Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x14EDC80
	int GetHashCode() { }

	// RVA: 0x14EDCD4
	bool Equals(object other) { }

	// RVA: 0x14EDD84
	bool Equals(Vector3 other) { }

	// RVA: 0x14EDDB4
	Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x14EDDEC
	Vector3 Normalize(Vector3 value) { }

	// RVA: 0x14EDEF4
	void Normalize() { }

	// RVA: 0x14EDFFC
	Vector3 get_normalized() { }

	// RVA: 0x14EE100
	float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x14EE118
	Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x14EE22C
	Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x14EE308
	float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x14EE434
	float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x14EE4D8
	Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x14EE598
	float Magnitude(Vector3 vector) { }

	// RVA: 0x14EE61C
	float get_magnitude() { }

	// RVA: 0x14EE6A8
	float get_sqrMagnitude() { }

	// RVA: 0x14EE6C8
	Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x14EE6E4
	Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x14EE700
	Vector3 get_zero() { }

	// RVA: 0x14EE750
	Vector3 get_one() { }

	// RVA: 0x14EE7A0
	Vector3 get_forward() { }

	// RVA: 0x14EE7F0
	Vector3 get_back() { }

	// RVA: 0x14EE840
	Vector3 get_up() { }

	// RVA: 0x14EE890
	Vector3 get_down() { }

	// RVA: 0x14EE8E0
	Vector3 get_left() { }

	// RVA: 0x14EE930
	Vector3 get_right() { }

	// RVA: 0x14EE980
	Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x14EE990
	Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x14EE9A0
	Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x14EE9B0
	Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x14EE9C0
	Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x14EE9D4
	Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x14EE9E4
	bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x14EEA1C
	bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x14EEA54
	string ToString() { }

	// RVA: 0x14EEA64
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14EEC5C
	void .cctor() { }

	// RVA: 0x14ED914
	void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }

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
	public const float kEpsilon = 897988541;

	// Methods

	// RVA: 0x14EECEC
	Quaternion Inverse(Quaternion rotation) { }

	// RVA: 0x14EEDB4
	Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x14EEE98
	Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x14EEF7C
	Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x14EF060
	Quaternion Internal_FromEulerRad(Vector3 euler) { }

	// RVA: 0x14EF128
	Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	// RVA: 0x14EF1F4
	Quaternion AngleAxis(float angle, Vector3 axis) { }

	// RVA: 0x14EF2C4
	Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	// RVA: 0x14EF388
	Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x14EF448
	void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x14EF454
	Quaternion get_identity() { }

	// RVA: 0x14EF4A4
	Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x14EF524
	Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x14EF5C8
	bool IsEqualUsingDot(float dot) { }

	// RVA: 0x14EF5E0
	bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x14EF614
	bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x14EF648
	float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x14EF668
	float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x14EF6D4
	Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x14EF794
	Vector3 get_eulerAngles() { }

	// RVA: 0x14EF8CC
	void set_eulerAngles(Vector3 value) { }

	// RVA: 0x14EF948
	Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x14EF9C0
	Quaternion Euler(Vector3 euler) { }

	// RVA: 0x14EFA38
	Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x14EFB6C
	Quaternion Normalize(Quaternion q) { }

	// RVA: 0x14EFC5C
	Quaternion get_normalized() { }

	// RVA: 0x14EFD44
	int GetHashCode() { }

	// RVA: 0x14EFDAC
	bool Equals(object other) { }

	// RVA: 0x14EFE90
	bool Equals(Quaternion other) { }

	// RVA: 0x14EFF20
	string ToString() { }

	// RVA: 0x14EFF30
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14F0174
	void .cctor() { }

	// RVA: 0x14EED4C
	void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x14EEE30
	void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x14EEF14
	void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x14EEFF8
	void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x14EF0C0
	void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x14EF18C
	void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x14EF264
	void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x14EF330
	void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }

}

// Namespace: UnityEngine
public struct Mathf 
{
	// Fields
	public static readonly float Epsilon; // 0x0

	// Methods

	// RVA: 0x14F01C8
	int ClosestPowerOfTwo(int value) { }

	// RVA: 0x14F0218
	bool IsPowerOfTwo(int value) { }

	// RVA: 0x14F0268
	int NextPowerOfTwo(int value) { }

	// RVA: 0x14E9484
	float GammaToLinearSpace(float value) { }

	// RVA: 0x14E95C4
	float LinearToGammaSpace(float value) { }

	// RVA: 0x14F02B8
	Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	// RVA: 0x14F0384
	float Sin(float f) { }

	// RVA: 0x14F03EC
	float Cos(float f) { }

	// RVA: 0x14F0454
	float Tan(float f) { }

	// RVA: 0x14F04BC
	float Asin(float f) { }

	// RVA: 0x14F0524
	float Acos(float f) { }

	// RVA: 0x14F058C
	float Atan(float f) { }

	// RVA: 0x14F05F4
	float Atan2(float y, float x) { }

	// RVA: 0x14F0664
	float Sqrt(float f) { }

	// RVA: 0x14F06E4
	float Abs(float f) { }

	// RVA: 0x14F0764
	int Abs(int value) { }

	// RVA: 0x14F07EC
	float Min(float a, float b) { }

	// RVA: 0x14F07F8
	int Min(int a, int b) { }

	// RVA: 0x14F0804
	float Max(float a, float b) { }

	// RVA: 0x14F0810
	float Max(float[] values) { }

	// RVA: 0x14F0868
	int Max(int a, int b) { }

	// RVA: 0x14F0874
	float Pow(float f, float p) { }

	// RVA: 0x14F08E8
	float Exp(float power) { }

	// RVA: 0x14F0950
	float Log(float f, float p) { }

	// RVA: 0x14F09C4
	float Log(float f) { }

	// RVA: 0x14F0A2C
	float Log10(float f) { }

	// RVA: 0x14F0A94
	float Ceil(float f) { }

	// RVA: 0x14F0B14
	float Floor(float f) { }

	// RVA: 0x14F0B94
	float Round(float f) { }

	// RVA: 0x14F0CB8
	int CeilToInt(float f) { }

	// RVA: 0x14F0D30
	int FloorToInt(float f) { }

	// RVA: 0x14F0DA8
	int RoundToInt(float f) { }

	// RVA: 0x14F0EB8
	float Sign(float f) { }

	// RVA: 0x14F0ECC
	float Clamp(float value, float min, float max) { }

	// RVA: 0x14F0EE0
	int Clamp(int value, int min, int max) { }

	// RVA: 0x14F0EF4
	float Clamp01(float value) { }

	// RVA: 0x14F0F10
	float Lerp(float a, float b, float t) { }

	// RVA: 0x14F0F38
	float LerpUnclamped(float a, float b, float t) { }

	// RVA: 0x14F0F48
	float LerpAngle(float a, float b, float t) { }

	// RVA: 0x14F0FB4
	float MoveTowards(float current, float target, float maxDelta) { }

	// RVA: 0x14F0FD8
	float SmoothStep(float from, float to, float t) { }

	// RVA: 0x14F1020
	bool Approximately(float a, float b) { }

	// RVA: 0x14F10B8
	float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x14F119C
	float Repeat(float t, float length) { }

	// RVA: 0x14F11C4
	float InverseLerp(float a, float b, float value) { }

	// RVA: 0x14F11FC
	float DeltaAngle(float current, float target) { }

	// RVA: 0x14F124C
	float ClampToFloat(Double value) { }

	// RVA: 0x14F12CC
	int ClampToInt(Int64 value) { }

	// RVA: 0x14F12E8
	UInt32 ClampToUInt(Int64 value) { }

	// RVA: 0x14F1300
	int GetNumberOfDecimalsForMinimumDifference(Double minDifference) { }

	// RVA: 0x14F1390
	Double RoundBasedOnMinimumDifference(Double valueToRound, Double minDifference) { }

	// RVA: 0x14F1480
	Double DiscardLeastSignificantDecimal(Double v) { }

	// RVA: 0x14F160C
	void .cctor() { }

	// RVA: 0x14F031C
	void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }

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
	public const float kEpsilon = 925353388;
	public const float kEpsilonNormalSqrt = 646978941;

	// Methods

	// RVA: 0x14F1698
	float get_Item(int index) { }

	// RVA: 0x14F170C
	void set_Item(int index, float value) { }

	// RVA: 0x14F1780
	void .ctor(float x, float y) { }

	// RVA: 0x14F1788
	Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x14F17BC
	Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x14F17D8
	Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) { }

	// RVA: 0x14F18AC
	Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x14F18B8
	void Normalize() { }

	// RVA: 0x14F19B0
	Vector2 get_normalized() { }

	// RVA: 0x14F1A94
	string ToString() { }

	// RVA: 0x14F1AA4
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14F1C50
	int GetHashCode() { }

	// RVA: 0x14F1C88
	bool Equals(object other) { }

	// RVA: 0x14F1D28
	bool Equals(Vector2 other) { }

	// RVA: 0x14F1D4C
	float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x14F1D5C
	float get_magnitude() { }

	// RVA: 0x14F1DD4
	float get_sqrMagnitude() { }

	// RVA: 0x14F1DE8
	float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x14F1EEC
	float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x14F2008
	float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x14F2090
	Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	// RVA: 0x14F2130
	Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x14F2144
	Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x14F2158
	Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x14F2164
	Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x14F2170
	Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x14F217C
	Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x14F2188
	Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x14F2194
	Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x14F21A0
	Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x14F21B0
	Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x14F21BC
	bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x14F21E8
	bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x14F2214
	Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x14F2218
	Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x14F2220
	Vector2 get_zero() { }

	// RVA: 0x14F226C
	Vector2 get_one() { }

	// RVA: 0x14F22B8
	Vector2 get_up() { }

	// RVA: 0x14F2304
	Vector2 get_down() { }

	// RVA: 0x14F2350
	Vector2 get_left() { }

	// RVA: 0x14F239C
	Vector2 get_right() { }

	// RVA: 0x14F23E8
	Vector2 get_negativeInfinity() { }

	// RVA: 0x14F2434
	void .cctor() { }

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

	// RVA: 0x14F24A4
	int get_x() { }

	// RVA: 0x14F24AC
	void set_x(int value) { }

	// RVA: 0x14F24B4
	int get_y() { }

	// RVA: 0x14F24BC
	void set_y(int value) { }

	// RVA: 0x14F24C4
	void .ctor(int x, int y) { }

	// RVA: 0x14F24CC
	Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x14F24DC
	Vector2Int FloorToInt(Vector2 v) { }

	// RVA: 0x14F25C8
	bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x14F25D4
	bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x14F25E0
	bool Equals(object other) { }

	// RVA: 0x14F2680
	bool Equals(Vector2Int other) { }

	// RVA: 0x14F26A8
	int GetHashCode() { }

	// RVA: 0x14F26FC
	string ToString() { }

	// RVA: 0x14F28B0
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14F2A4C
	Vector2Int get_zero() { }

	// RVA: 0x14F2A98
	void .cctor() { }

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

	// RVA: 0x14F2B24
	int get_x() { }

	// RVA: 0x14F2B2C
	void set_x(int value) { }

	// RVA: 0x14F2B34
	int get_y() { }

	// RVA: 0x14F2B3C
	void set_y(int value) { }

	// RVA: 0x14F2B44
	int get_z() { }

	// RVA: 0x14F2B4C
	void set_z(int value) { }

	// RVA: 0x14F2B54
	void .ctor(int x, int y, int z) { }

	// RVA: 0x14F2B60
	Vector3 op_Implicit(Vector3Int v) { }

	// RVA: 0x14F2B74
	bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x14F2B94
	bool Equals(object other) { }

	// RVA: 0x14F2C40
	bool Equals(Vector3Int other) { }

	// RVA: 0x14F2C70
	int GetHashCode() { }

	// RVA: 0x14F2CF4
	string ToString() { }

	// RVA: 0x14F2D04
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14F2EF4
	Vector3Int get_zero() { }

	// RVA: 0x14F2F44
	void .cctor() { }

}

// Namespace: UnityEngine
public struct Vector4 
{
	// Fields
	public const float kEpsilon = 925353388;
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18
	public float w; // 0x1C
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Methods

	// RVA: 0x14F2FC4
	float get_Item(int index) { }

	// RVA: 0x14F3070
	void set_Item(int index, float value) { }

	// RVA: 0x14F311C
	void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x14F3128
	void .ctor(float x, float y) { }

	// RVA: 0x14F3134
	Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x14F3184
	int GetHashCode() { }

	// RVA: 0x14F31EC
	bool Equals(object other) { }

	// RVA: 0x14F32AC
	bool Equals(Vector4 other) { }

	// RVA: 0x14F32E8
	float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x14F3308
	float get_sqrMagnitude() { }

	// RVA: 0x14F3330
	Vector4 get_zero() { }

	// RVA: 0x14F3380
	Vector4 get_one() { }

	// RVA: 0x14F33D0
	Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x14F33E4
	Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x14F33F8
	bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x14F343C
	bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x14F3480
	Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x14F3488
	Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x14F348C
	Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x14F3498
	Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x14F349C
	string ToString() { }

	// RVA: 0x14F36F0
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x14F3934
	void .cctor() { }

}

// Namespace: UnityEngine
internal struct TypeDispatchData 
{
	// Fields
	public object[] changed; // 0x10
	public Unity.Collections.NativeArray<System.Int32> changedID; // 0x18
	public Unity.Collections.NativeArray<System.Int32> destroyedID; // 0x28

	// Methods

	// RVA: 0x14F3998
	void Dispose() { }

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

	// RVA: 0x14F3A0C
	void Dispose() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.ObjectDispatcher.<>c <>9; // 0x0

	// Methods

	// RVA: 0x14F3C28
	void .cctor() { }

	// RVA: 0x14F3C94
	void .ctor() { }

	// RVA: 0x14F3C9C
	void <.cctor>b__54_0(object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, System.Action<UnityEngine.TypeDispatchData> callback) { }

	// RVA: 0x14F3D9C
	void <.cctor>b__54_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, System.Action<UnityEngine.TransformDispatchData> callback) { }

}

// Namespace: UnityEngine
internal sealed class ObjectDispatcher 
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private static System.Action<UnityEngine.Object[],System.IntPtr,System.IntPtr,System.Int32,System.Int32,System.Action<UnityEngine.TypeDispatchData>> s_TypeDispatch; // 0x0
	private static System.Action<System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.Int32,System.Action<UnityEngine.TransformDispatchData>> s_TransformDispatch; // 0x8

	// Methods

	// RVA: 0x14F3AE0
	void .cctor() { }

}

// Namespace: UnityEngine
internal class NumericFieldDraggerUtility 
{
	// Fields
	private static bool s_UseYSign; // 0x0

	// Methods

	// RVA: 0x14F3F98
	float Acceleration(bool shiftPressed, bool altPressed) { }

	// RVA: 0x14F3FBC
	float NiceDelta(Vector2 deviceDelta, float acceleration) { }

	// RVA: 0x14F416C
	Double CalculateFloatDragSensitivity(Double value) { }

	// RVA: 0x14F422C
	Double CalculateFloatDragSensitivity(Double value, Double minValue, Double maxValue) { }

	// RVA: 0x14F42F0
	Int64 CalculateIntDragSensitivity(Int64 value) { }

	// RVA: 0x14F4410
	UInt64 CalculateIntDragSensitivity(UInt64 value) { }

	// RVA: 0x14F4390
	Double CalculateIntDragSensitivity(Double value) { }

	// RVA: 0x14F44A4
	Int64 CalculateIntDragSensitivity(Int64 value, Int64 minValue, Int64 maxValue) { }

}

// Namespace: UnityEngine
internal interface IPlayerEditorConnectionNative 
{
	// Methods

	// RVA: 0x2FE41A8
	void Initialize() { }

	// RVA: 0x2FE41A8
	void DisconnectAll() { }

	// RVA: -1
	void SendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: -1
	bool TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x2FE41A8
	void Poll() { }

	// RVA: -1
	void RegisterInternal(Guid messageId) { }

	// RVA: -1
	void UnregisterInternal(Guid messageId) { }

	// RVA: 0x2FE3054
	bool IsConnected() { }

}

// Namespace: UnityEngine
internal class PlayerConnectionInternal 
{
	// Methods

	// RVA: 0x14F454C
	void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x14F46D0
	bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x14F4854
	void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x14F48D4
	void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x14F49C4
	void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x14F4AB4
	void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x14F4B34
	bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x14F4BB4
	void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	// RVA: 0x14F4B74
	bool IsConnected() { }

	// RVA: 0x14F4AF4
	void Initialize() { }

	// RVA: 0x14F4974
	void RegisterInternal(string messageId) { }

	// RVA: 0x14F4A64
	void UnregisterInternal(string messageId) { }

	// RVA: 0x14F4678
	void SendMessage(string messageId, Byte[] data, int playerId) { }

	// RVA: 0x14F47FC
	bool TrySendMessage(string messageId, Byte[] data, int playerId) { }

	// RVA: 0x14F4894
	void PollInternal() { }

	// RVA: 0x14F4BF4
	void DisconnectAll() { }

	// RVA: 0x14F4C34
	void .ctor() { }

}

// Namespace: UnityEngine
public class PlayerPrefsException 
{
	// Methods

	// RVA: 0x14F4C3C
	void .ctor(string error) { }

}

// Namespace: UnityEngine
public class PlayerPrefs 
{
	// Methods

	// RVA: 0x14F4CA8
	bool TrySetInt(string key, int value) { }

	// RVA: 0x14F4D10
	bool TrySetFloat(string key, float value) { }

	// RVA: 0x14F4D78
	bool TrySetSetString(string key, string value) { }

	// RVA: 0x14F4DE0
	void SetInt(string key, int value) { }

	// RVA: 0x14F4E7C
	int GetInt(string key, int defaultValue) { }

	// RVA: 0x14F4EE4
	int GetInt(string key) { }

	// RVA: 0x14F4F3C
	void SetFloat(string key, float value) { }

	// RVA: 0x14F4FD8
	float GetFloat(string key, float defaultValue) { }

	// RVA: 0x14F5040
	void SetString(string key, string value) { }

	// RVA: 0x14F50DC
	string GetString(string key, string defaultValue) { }

	// RVA: 0x14F5144
	string GetString(string key) { }

	// RVA: 0x14F51E4
	bool HasKey(string key) { }

	// RVA: 0x14F5234
	void DeleteKey(string key) { }

	// RVA: 0x14F5284
	void DeleteAll() { }

	// RVA: 0x14F52C4
	void Save() { }

}

// Namespace: UnityEngine
public abstract class PropertyAttribute 
{
	// Fields
	private int <order>k__BackingField; // 0x10

	// Methods

	// RVA: 0x14F5304
	void set_order(int value) { }

	// RVA: 0x14F530C
	void .ctor() { }

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

	// RVA: 0x14F5314
	void .ctor(string tooltip) { }

}

// Namespace: UnityEngine
public class SpaceAttribute 
{
	// Fields
	public readonly float height; // 0x14

	// Methods

	// RVA: 0x14F5348
	void .ctor() { }

	// RVA: 0x14F5374
	void .ctor(float height) { }

}

// Namespace: UnityEngine
public class HeaderAttribute 
{
	// Fields
	public readonly string header; // 0x18

	// Methods

	// RVA: 0x14F53A8
	void .ctor(string header) { }

}

// Namespace: UnityEngine
public sealed class RangeAttribute 
{
	// Fields
	public readonly float min; // 0x14
	public readonly float max; // 0x18

	// Methods

	// RVA: 0x14F53DC
	void .ctor(float min, float max) { }

}

// Namespace: UnityEngine
public sealed class MinAttribute 
{
	// Fields
	public readonly float min; // 0x14

	// Methods

	// RVA: 0x14F5414
	void .ctor(float min) { }

}

// Namespace: UnityEngine
public sealed class MultilineAttribute 
{
	// Fields
	public readonly int lines; // 0x14

	// Methods

	// RVA: 0x14F5448
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class TextAreaAttribute 
{
	// Fields
	public readonly int minLines; // 0x14
	public readonly int maxLines; // 0x18

	// Methods

	// RVA: 0x14F5474
	void .ctor(int minLines, int maxLines) { }

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

	// RVA: 0x14F54AC
	void .ctor(bool showAlpha, bool hdr) { }

}

// Namespace: UnityEngine
public sealed class GradientUsageAttribute 
{
	// Fields
	public readonly bool hdr; // 0x14
	public readonly ColorSpace colorSpace; // 0x18

	// Methods

	// RVA: 0x14F54FC
	void .ctor(bool hdr) { }

}

// Namespace: UnityEngine
internal class PropertyNameUtils 
{
	// Methods

	// RVA: 0x14F5534
	PropertyName PropertyNameFromString(string name) { }

	// RVA: 0x14F558C
	void PropertyNameFromString_Injected(string name, out PropertyName ret) { }

}

// Namespace: UnityEngine
public struct PropertyName 
{
	// Fields
	internal int id; // 0x10

	// Methods

	// RVA: 0x14F55F4
	void .ctor(string name) { }

	// RVA: 0x14F565C
	void .ctor(PropertyName other) { }

	// RVA: 0x14F5664
	bool IsNullOrEmpty(PropertyName prop) { }

	// RVA: 0x14F5670
	bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	// RVA: 0x14F567C
	int GetHashCode() { }

	// RVA: 0x14F5684
	bool Equals(object other) { }

	// RVA: 0x14F5714
	bool Equals(PropertyName other) { }

	// RVA: 0x14F5724
	PropertyName op_Implicit(string name) { }

	// RVA: 0x14F577C
	string ToString() { }

}

// Namespace: UnityEngine
public static class Random 
{
	// Methods

	// RVA: 0x14F5808
	float Range(float minInclusive, float maxInclusive) { }

	// RVA: 0x14F586C
	int Range(int minInclusive, int maxExclusive) { }

	// RVA: 0x14F58D4
	int RandomRangeInt(int minInclusive, int maxExclusive) { }

	// RVA: 0x14F593C
	float get_value() { }

	// RVA: 0x14F597C
	Vector3 get_insideUnitSphere() { }

	// RVA: 0x14F5A24
	Vector3 get_onUnitSphere() { }

	// RVA: 0x14F59D4
	void get_insideUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x14F5A7C
	void get_onUnitSphere_Injected(out Vector3 ret) { }

}

// Namespace: UnityEngine
public class ResourceRequest 
{
	// Fields
	internal string m_Path; // 0x20
	internal Type m_Type; // 0x28

	// Methods

	// RVA: 0x14F5ACC
	object GetResult() { }

	// RVA: 0x14F5BE8
	void .ctor() { }

}

// Namespace: UnityEngine
internal static class ResourcesAPIInternal 
{
	// Methods

	// RVA: 0x14F5BF8
	object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x14F5C48
	Shader FindShaderByName(string name) { }

	// RVA: 0x14F5C98
	object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x14F5D00
	void UnloadAsset(object assetToUnload) { }

}

// Namespace: UnityEngine
public class ResourcesAPI 
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Methods

	// RVA: 0x14F5D50
	ResourcesAPI get_ActiveAPI() { }

	// RVA: 0x14F5E50
	ResourcesAPI get_overrideAPI() { }

	// RVA: 0x14F5ECC
	void .ctor() { }

	// RVA: 0x14F5ED4
	object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x14F5F24
	Shader FindShaderByName(string name) { }

	// RVA: 0x14F5F74
	object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x14F5FDC
	void UnloadAsset(object assetToUnload) { }

	// RVA: 0x14F602C
	void .cctor() { }

}

// Namespace: UnityEngine
public sealed class Resources 
{
	// Methods

	// RVA: 0x2FE7084
	T[] ConvertObjects(object[] rawObjects) { }

	// RVA: 0x14F6098
	object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x2FE704C
	T[] FindObjectsOfTypeAll() { }

	// RVA: 0x14F6120
	object Load(string path) { }

	// RVA: 0x309AF8C
	T Load(string path) { }

	// RVA: 0x14F5B58
	object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x14F620C
	object GetBuiltinResource(Type type, string path) { }

	// RVA: 0x309AF8C
	T GetBuiltinResource(string path) { }

	// RVA: 0x14F6274
	void UnloadAsset(object assetToUnload) { }

	// RVA: 0x14F62FC
	AsyncOperation UnloadUnusedAssets() { }

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

	// RVA: 0x14F633C
	void SetAsyncInstantiateOperationResult(AsyncInstantiateOperation op, object[] result) { }

}

// Namespace: UnityEngine
public class AsyncOperation 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private System.Action<UnityEngine.AsyncOperation> m_completeCallback; // 0x18

	// Methods

	// RVA: 0x14F6358
	void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x14F63A8
	bool get_isDone() { }

	// RVA: 0x14F63F8
	float get_progress() { }

	// RVA: 0x14F6448
	void Finalize() { }

	// RVA: 0x14F6500
	void InvokeCompletionEvent() { }

	// RVA: 0x14F5BF0
	void .ctor() { }

}

// Namespace: UnityEngine
internal class AttributeHelperEngine 
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	// RVA: 0x14F6554
	Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	// RVA: 0x14F6698
	Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x14F6B50
	int GetExecuteMode(Type klass) { }

	// RVA: 0x14F6C98
	int CheckIsEditorScript(Type klass) { }

	// RVA: 0x14F6DE8
	int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: 0x309AF8C
	T GetCustomAttributeOfType(Type klass) { }

	// RVA: 0x14F6E9C
	void .cctor() { }

}

// Namespace: UnityEngine
public sealed class DisallowMultipleComponent 
{
	// Methods

	// RVA: 0x14F6F8C
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class RequireComponent 
{
	// Fields
	public Type m_Type0; // 0x10
	public Type m_Type1; // 0x18
	public Type m_Type2; // 0x20

	// Methods

	// RVA: 0x14F6F94
	void .ctor(Type requiredComponent) { }

	// RVA: 0x14F6FC8
	void .ctor(Type requiredComponent, Type requiredComponent2) { }

}

// Namespace: UnityEngine
public sealed class AddComponentMenu 
{
	// Fields
	private string m_AddComponentMenu; // 0x10
	private int m_Ordering; // 0x18

	// Methods

	// RVA: 0x14F7018
	void .ctor(string menuName) { }

	// RVA: 0x14F7054
	void .ctor(string menuName, int order) { }

}

// Namespace: UnityEngine
public sealed class CreateAssetMenuAttribute 
{
	// Fields
	private string <menuName>k__BackingField; // 0x10
	private string <fileName>k__BackingField; // 0x18
	private int <order>k__BackingField; // 0x20

	// Methods

	// RVA: 0x14F709C
	void set_menuName(string value) { }

	// RVA: 0x14F70A4
	void set_fileName(string value) { }

	// RVA: 0x14F70AC
	void set_order(int value) { }

	// RVA: 0x14F70B4
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ContextMenu 
{
	// Fields
	public readonly string menuItem; // 0x10
	public readonly bool validate; // 0x18
	public readonly int priority; // 0x1C

	// Methods

	// RVA: 0x14F70BC
	void .ctor(string itemName) { }

	// RVA: 0x14F7104
	void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x14F7158
	void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

// Namespace: UnityEngine
public sealed class ExecuteInEditMode 
{
	// Methods

	// RVA: 0x14F71A8
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ExecuteAlways 
{
	// Methods

	// RVA: 0x14F71B0
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class HideInInspector 
{
	// Methods

	// RVA: 0x14F71B8
	void .ctor() { }

}

// Namespace: UnityEngine
public class HelpURLAttribute 
{
	// Fields
	internal readonly string m_Url; // 0x10
	internal readonly bool m_Dispatcher; // 0x18
	internal readonly string m_DispatchingFieldName; // 0x20

	// Methods

	// RVA: 0x14F71C0
	void .ctor(string url) { }

}

// Namespace: UnityEngine
public class DefaultExecutionOrder 
{
	// Fields
	private int m_Order; // 0x10

	// Methods

	// RVA: 0x14F7240
	void .ctor(int order) { }

	// RVA: 0x14F6E94
	int get_order() { }

}

// Namespace: UnityEngine
public class AssemblyIsEditorAssembly 
{}

// Namespace: UnityEngine
public class ExcludeFromPresetAttribute 
{
	// Methods

	// RVA: 0x14F726C
	void .ctor() { }

}

// Namespace: UnityEngine
public class Behaviour 
{
	// Methods

	// RVA: 0x14F7274
	bool get_enabled() { }

	// RVA: 0x14F72C4
	void set_enabled(bool value) { }

	// RVA: 0x14F732C
	bool get_isActiveAndEnabled() { }

	// RVA: 0x14F737C
	void .ctor() { }

}

// Namespace: UnityEngine
internal struct CastHelper<T0> 
{
	// Fields
	public T t; // 0x0
	public IntPtr onePointerFurtherThanT; // 0x0
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.ClassLibraryInitializer.<>c <>9; // 0x0
	public static ResolveEventHandler <>9__2_0; // 0x8

	// Methods

	// RVA: 0x14F7700
	void .cctor() { }

	// RVA: 0x14F776C
	void .ctor() { }

	// RVA: 0x14F7774
	Assembly <InitAssemblyRedirections>b__2_0(object _, ResolveEventArgs args) { }

}

// Namespace: UnityEngine
internal static class ClassLibraryInitializer 
{
	// Methods

	// RVA: 0x14F748C
	void Init() { }

	// RVA: 0x14F7490
	void InitStdErrWithHandle(IntPtr fileHandle) { }

	// RVA: 0x14F75E0
	void InitAssemblyRedirections() { }

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

	// RVA: 0x14F7894
	bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	// RVA: 0x14F78B8
	string ToString() { }

	// RVA: 0x14F7A98
	bool Equals(object other) { }

	// RVA: 0x14F7B58
	int GetHashCode() { }

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

	// RVA: 0x14F7C10
	bool Equals(object other) { }

	// RVA: 0x14F7CEC
	int GetHashCode() { }

	// RVA: 0x14F7D90
	string ToString() { }

}

// Namespace: UnityEngine
public class Component 
{
	// Methods

	// RVA: 0x14F7F6C
	Transform get_transform() { }

	// RVA: 0x14F7FBC
	GameObject get_gameObject() { }

	// RVA: 0x14F800C
	Component GetComponent(Type type) { }

	// RVA: 0x14F8110
	void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x309AF8C
	T GetComponent() { }

	// RVA: 0x14F8168
	bool TryGetComponent(Type type, out Component component) { }

	// RVA: 0x2FE3174
	bool TryGetComponent(out T component) { }

	// RVA: 0x14F830C
	Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: 0x309AF8C
	T GetComponentInChildren(bool includeInactive) { }

	// RVA: 0x309AF8C
	T GetComponentInChildren() { }

	// RVA: -1
	T[] GetComponentsInChildren(bool includeInactive) { }

	// RVA: -1
	void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> result) { }

	// RVA: 0x2FE360C
	T[] GetComponentsInChildren() { }

	// RVA: 0x2FE4574
	void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }

	// RVA: 0x14F83F0
	Component GetComponentInParent(Type t, bool includeInactive) { }

	// RVA: 0x309AF8C
	T GetComponentInParent() { }

	// RVA: -1
	T[] GetComponentsInParent(bool includeInactive) { }

	// RVA: -1
	void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: 0x2FE360C
	T[] GetComponentsInParent() { }

	// RVA: 0x14F84D4
	void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x14F852C
	void GetComponents(Type type, System.Collections.Generic.List<UnityEngine.Component> results) { }

	// RVA: 0x2FE4574
	void GetComponents(System.Collections.Generic.List<T> results) { }

	// RVA: 0x2FE360C
	T[] GetComponents() { }

	// RVA: 0x14F8584
	void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x14F85EC
	void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	// RVA: 0x14F7404
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class Coroutine 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x14F8654
	void .ctor() { }

	// RVA: 0x14F865C
	void Finalize() { }

	// RVA: 0x14F8714
	void ReleaseCoroutine(IntPtr ptr) { }

}

// Namespace: UnityEngine
internal class SetupCoroutine 
{
	// Methods

	// RVA: 0x14F8764
	void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) { }

	// RVA: 0x14F8898
	object InvokeMember(object behaviour, string name, object variable) { }

}

// Namespace: UnityEngine
public abstract class CustomYieldInstruction 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_keepWaiting() { }

	// RVA: 0x14F899C
	object get_Current() { }

	// RVA: 0x14F89A4
	bool MoveNext() { }

	// RVA: 0x14F89B0
	void Reset() { }

	// RVA: 0x14F89B4
	void .ctor() { }

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

	// RVA: 0x14FA840
	void .cctor() { }

	// RVA: 0x14FA8AC
	void .ctor() { }

	// RVA: 0x14FA8B4
	int <GetCachedEnumData>b__2_5(FieldInfo f) { }

	// RVA: 0x14FA8E0
	string <GetCachedEnumData>b__2_1(FieldInfo f) { }

	// RVA: 0x14FA960
	Enum <GetCachedEnumData>b__2_2(FieldInfo f) { }

	// RVA: 0x14FA9F8
	int <GetCachedEnumData>b__2_3(Enum v) { }

	// RVA: 0x14FAA60
	int <GetCachedEnumData>b__2_4(Enum v) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0 
{
	// Fields
	public System.Func<System.String,System.String> nicifyName; // 0x10

	// Methods

	// RVA: 0x14F9AC4
	void .ctor() { }

	// RVA: 0x14FAAC8
	string <GetCachedEnumData>b__0(FieldInfo f) { }

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

	// RVA: 0x14F89BC
	EnumData GetCachedEnumData(Type enumType, CachedType cachedType, System.Func<System.String,System.String> nicifyName) { }

	// RVA: 0x14F9C54
	void HandleInspectorOrderAttribute(Type enumType, ref EnumData enumData) { }

	// RVA: 0x14F9ACC
	bool CheckObsoleteAddition(FieldInfo field, CachedType cachedType) { }

	// RVA: 0x14FA2C0
	string EnumTooltipFromEnumField(FieldInfo field) { }

	// RVA: 0x14FA444
	string EnumNameFromEnumField(FieldInfo field, System.Func<System.String,System.String> nicifyName) { }

	// RVA: 0x14FA7A4
	void .cctor() { }

	// RVA: 0x14FA730
	string <EnumNameFromEnumField>g__NicifyName|8_0(ref UnityEngine.EnumDataUtility.<>c__DisplayClass8_0& ) { }

}

// Namespace: UnityEngine
public class ExcludeFromObjectFactoryAttribute 
{
	// Methods

	// RVA: 0x14FAB5C
	void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class ExtensionOfNativeClassAttribute 
{
	// Methods

	// RVA: 0x14FAB64
	void .ctor() { }

}

// Namespace: UnityEngine
internal class FailedToLoadScriptObject 
{}

// Namespace: UnityEngine
public sealed class GameObject 
{
	// Methods

	// RVA: 0x309AF8C
	T GetComponent() { }

	// RVA: 0x14F80A8
	Component GetComponent(Type type) { }

	// RVA: 0x14FAB6C
	void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x14F8398
	Component GetComponentInChildren(Type type, bool includeInactive) { }

	// RVA: 0x309AF8C
	T GetComponentInChildren() { }

	// RVA: 0x309AF8C
	T GetComponentInChildren(bool includeInactive) { }

	// RVA: 0x14F847C
	Component GetComponentInParent(Type type, bool includeInactive) { }

	// RVA: 0x309AF8C
	T GetComponentInParent() { }

	// RVA: 0x309AF8C
	T GetComponentInParent(bool includeInactive) { }

	// RVA: 0x14FABC4
	Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x2FE360C
	T[] GetComponents() { }

	// RVA: 0x2FE4574
	void GetComponents(System.Collections.Generic.List<T> results) { }

	// RVA: -1
	T[] GetComponentsInChildren(bool includeInactive) { }

	// RVA: -1
	void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: 0x2FE360C
	T[] GetComponentsInChildren() { }

	// RVA: 0x2FE4574
	void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }

	// RVA: -1
	void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: -1
	T[] GetComponentsInParent(bool includeInactive) { }

	// RVA: 0x2FE3174
	bool TryGetComponent(out T component) { }

	// RVA: 0x14F8254
	bool TryGetComponent(Type type, out Component component) { }

	// RVA: 0x14FAC4C
	Component TryGetComponentInternal(Type type) { }

	// RVA: 0x14FACB4
	void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x14FAD0C
	Component Internal_AddComponentWithType(Type componentType) { }

	// RVA: 0x14FAD74
	Component AddComponent(Type componentType) { }

	// RVA: 0x309AF8C
	T AddComponent() { }

	// RVA: 0x14FADDC
	Transform get_transform() { }

	// RVA: 0x14FAE2C
	int get_layer() { }

	// RVA: 0x14FAE7C
	void set_layer(int value) { }

	// RVA: 0x14FAEE4
	void SetActive(bool value) { }

	// RVA: 0x14FAF4C
	bool get_activeSelf() { }

	// RVA: 0x14FAF9C
	bool get_activeInHierarchy() { }

	// RVA: 0x14FAFEC
	bool get_isStatic() { }

	// RVA: 0x14FB03C
	void set_tag(string value) { }

	// RVA: 0x14FB0A4
	void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x14FB10C
	void .ctor(string name) { }

	// RVA: 0x14FB244
	void .ctor() { }

	// RVA: 0x14FB310
	void .ctor(string name, Type[] components) { }

	// RVA: 0x14FB1DC
	void Internal_CreateGameObject(GameObject self, string name) { }

	// RVA: 0x14FB458
	GameObject Find(string name) { }

	// RVA: 0x14FB4A8
	Scene get_scene() { }

	// RVA: 0x14FB568
	GameObject get_gameObject() { }

	// RVA: 0x14FB500
	void get_scene_Injected(out Scene ret) { }

}

// Namespace: UnityEngine
public sealed class InspectorOrderAttribute 
{
	// Fields
	private InspectorSort <m_inspectorSort>k__BackingField; // 0x14
	private InspectorSortDirection <m_sortDirection>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14FB56C
	InspectorSort get_m_inspectorSort() { }

	// RVA: 0x14FB574
	InspectorSortDirection get_m_sortDirection() { }

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

	// RVA: 0x14FB57C
	int op_Implicit(LayerMask mask) { }

	// RVA: 0x14FB580
	LayerMask op_Implicit(int intVal) { }

	// RVA: 0x14FB584
	int NameToLayer(string layerName) { }

}

// Namespace: UnityEngine
public struct LazyLoadReference<T0> 
{
	// Fields
	private int m_InstanceID; // 0x0
}

// Namespace: UnityEngine
internal static class ManagedStreamHelpers 
{
	// Methods

	// RVA: 0x14FB5D4
	void ValidateLoadFromStream(Stream stream) { }

	// RVA: 0x14FB6F0
	void ManagedStreamRead(Byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0x14FB7E0
	void ManagedStreamSeek(Int64 offset, UInt32 origin, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0x14FB8C0
	void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

}

// Namespace: UnityEngine
public class MonoBehaviour 
{
	// Fields
	private CancellationTokenSource m_CancellationTokenSource; // 0x18

	// Methods

	// RVA: 0x14FB984
	CancellationToken get_destroyCancellationToken() { }

	// RVA: 0x14FBB28
	void RaiseCancellation() { }

	// RVA: 0x14FBB3C
	bool IsInvoking() { }

	// RVA: 0x14FBBDC
	void CancelInvoke() { }

	// RVA: 0x14FBC7C
	void Invoke(string methodName, float time) { }

	// RVA: 0x14FBD48
	void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x14FBE14
	void CancelInvoke(string methodName) { }

	// RVA: 0x14FBEE4
	bool IsInvoking(string methodName) { }

	// RVA: 0x14FBFB4
	Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x14FBFBC
	Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x14FC188
	Coroutine StartCoroutine(IEnumerator routine) { }

	// RVA: 0x14FC318
	Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x14FC31C
	void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x14FC4AC
	void StopCoroutine(Coroutine routine) { }

	// RVA: 0x14FC63C
	void StopCoroutine(string methodName) { }

	// RVA: 0x14FC6A4
	void StopAllCoroutines() { }

	// RVA: 0x14FC6F4
	bool get_useGUILayout() { }

	// RVA: 0x14FC744
	void set_useGUILayout(bool value) { }

	// RVA: 0x14FC7AC
	void print(object message) { }

	// RVA: 0x14FBC2C
	void Internal_CancelInvokeAll(MonoBehaviour self) { }

	// RVA: 0x14FBB8C
	bool Internal_IsInvokingAll(MonoBehaviour self) { }

	// RVA: 0x14FBCE0
	void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	// RVA: 0x14FBE7C
	void CancelInvoke(MonoBehaviour self, string methodName) { }

	// RVA: 0x14FBF4C
	bool IsInvoking(MonoBehaviour self, string methodName) { }

	// RVA: 0x14FC0E0
	bool IsObjectMonoBehaviour(object obj) { }

	// RVA: 0x14FC130
	Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x14FC2B0
	Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x14FC5D4
	void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x14FC444
	void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x14FC834
	string GetScriptClassName() { }

	// RVA: 0x14FBAD8
	void OnCancellationTokenCreated() { }

	// RVA: 0x14FC884
	void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NoAllocHelpers 
{
	// Methods

	// RVA: 0x2FE9C90
	void ResizeList(System.Collections.Generic.List<T> list, int size) { }

	// RVA: 0x2FE9C90
	void EnsureListElemCount(System.Collections.Generic.List<T> list, int count) { }

	// RVA: 0x14FC90C
	int SafeLength(Array values) { }

	// RVA: 0x2FE613C
	int SafeLength(System.Collections.Generic.List<T> values) { }

	// RVA: 0x2FE7084
	T[] ExtractArrayFromListT(System.Collections.Generic.List<T> list) { }

	// RVA: 0x14FC91C
	void Internal_ResizeList(object list, int size) { }

	// RVA: 0x14FC984
	Array ExtractArrayFromList(object list) { }

}

// Namespace: UnityEngine
public struct RangeInt 
{
	// Fields
	public int start; // 0x10
	public int length; // 0x14

	// Methods

	// RVA: 0x14FC9D4
	int get_end() { }

	// RVA: 0x14FC9E0
	void .ctor(int start, int length) { }

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

	// RVA: 0x14FC9E8
	void .ctor() { }

	// RVA: 0x14FCA20
	void .ctor(RuntimeInitializeLoadType loadType) { }

	// RVA: 0x14FCA18
	void set_loadType(RuntimeInitializeLoadType value) { }

}

// Namespace: UnityEngine
public class ScriptableObject 
{
	// Methods

	// RVA: 0x14FCA4C
	void .ctor() { }

	// RVA: 0x14FCB68
	ScriptableObject CreateInstance(Type type) { }

	// RVA: 0x309AF8C
	T CreateInstance() { }

	// RVA: 0x14FCB18
	void CreateScriptableObject(ScriptableObject self) { }

	// RVA: 0x14FCBC0
	ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

// Namespace: UnityEngine
internal class ScriptingRuntime 
{
	// Methods

	// RVA: 0x14FCC28
	string[] GetAllUserAssemblies() { }

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

	// RVA: 0x14FCC68
	bool IsManagedCodeWorking() { }

}

// Namespace: UnityEngine
public class SelectionBaseAttribute 
{
	// Methods

	// RVA: 0x14FCC70
	void .ctor() { }

}

// Namespace: UnityEngine
public static class StackTraceUtility 
{
	// Fields
	private static string projectFolder; // 0x0

	// Methods

	// RVA: 0x14FCC78
	void SetProjectFolder(string folder) { }

	// RVA: 0x14FCD8C
	string ExtractStackTrace() { }

	// RVA: 0x14FD698
	void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	// RVA: 0x14FCF18
	string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	// RVA: 0x14FDA24
	void .cctor() { }

}

// Namespace: UnityEngine
public class UnityException 
{
	// Methods

	// RVA: 0x14FDA9C
	void .ctor() { }

	// RVA: 0x14FDB28
	void .ctor(string message) { }

	// RVA: 0x14FDBA4
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: UnityEngine
public class MissingComponentException 
{
	// Methods

	// RVA: 0x14FDC28
	void .ctor() { }

	// RVA: 0x14FDCB4
	void .ctor(string message) { }

	// RVA: 0x14FDD30
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: UnityEngine
public class MissingReferenceException 
{
	// Methods

	// RVA: 0x14FDDB4
	void .ctor() { }

	// RVA: 0x14FDE40
	void .ctor(string message) { }

	// RVA: 0x14FDEBC
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
private static class EncodingUtility 
{
	// Fields
	internal static readonly System.Collections.Generic.KeyValuePair<System.Byte[],System.Text.Encoding>[] encodingLookup; // 0x0
	internal static readonly Encoding targetEncoding; // 0x8

	// Methods

	// RVA: 0x14FE4E4
	void .cctor() { }

}

// Namespace: UnityEngine
public class TextAsset 
{
	// Methods

	// RVA: 0x14FDF40
	Byte[] get_bytes() { }

	// RVA: 0x14FDF90
	string get_text() { }

	// RVA: 0x14FE438
	string ToString() { }

	// RVA: 0x14FE03C
	string DecodeString(Byte[] bytes) { }

}

// Namespace: UnityEngine
public class TrackedReference 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x14FE8B0
	void .ctor() { }

	// RVA: 0x14FE8B8
	bool op_Equality(TrackedReference x, TrackedReference y) { }

	// RVA: 0x14FE924
	bool op_Inequality(TrackedReference x, TrackedReference y) { }

	// RVA: 0x14FE9A8
	bool Equals(object o) { }

	// RVA: 0x14FEAA4
	int GetHashCode() { }

	// RVA: 0x14FEAB0
	bool op_Implicit(TrackedReference exists) { }

}

// Namespace: UnityEngine
internal sealed class UnhandledExceptionHandler 
{
	// Methods

	// RVA: 0x14FEAD8
	void RegisterUECatcher() { }

	// RVA: 0x14FEB70
	void HandleUnhandledException(object sender, UnhandledExceptionEventArgs args) { }

	// RVA: 0x14FED38
	void PrintException(string title, Exception e) { }

	// RVA: 0x14FEDE4
	void iOSNativeUnhandledExceptionHandler(string managedExceptionType, string managedExceptionMessage, string managedExceptionStack) { }

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
	private const string objectIsNullMessage = 5708571648;
	private const string cloneDestroyedMessage = 5443957648;

	// Methods

	// RVA: 0x14FEE3C
	int GetInstanceID() { }

	// RVA: 0x14FEFCC
	int GetHashCode() { }

	// RVA: 0x14FEFD4
	bool Equals(object other) { }

	// RVA: 0x14FF2E8
	bool op_Implicit(object exists) { }

	// RVA: 0x14FF210
	bool CompareBaseObjects(object lhs, object rhs) { }

	// RVA: 0x14FF3B4
	bool IsNativeObjectAlive(object o) { }

	// RVA: 0x14FF3D8
	IntPtr GetCachedPtr() { }

	// RVA: 0x14FF3E0
	string get_name() { }

	// RVA: 0x14FF4DC
	void set_name(string value) { }

	// RVA: 0x14FF5FC
	object Instantiate(object original, Vector3 position, Quaternion rotation) { }

	// RVA: 0x14FFA18
	object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x14FFE64
	object Instantiate(object original) { }

	// RVA: 0x1500098
	object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x309AF8C
	T Instantiate(T original) { }

	// RVA: 0x309AF8C
	T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	// RVA: 0x309AF8C
	T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x309AF8C
	T Instantiate(T original, Transform parent) { }

	// RVA: 0x309AF8C
	T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	// RVA: 0x15003B0
	void Destroy(object obj, float t) { }

	// RVA: 0x1500418
	void Destroy(object obj) { }

	// RVA: 0x15004CC
	void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	// RVA: 0x1500534
	void DestroyImmediate(object obj) { }

	// RVA: 0x15005E8
	object[] FindObjectsOfType(Type type) { }

	// RVA: 0x150069C
	object[] FindObjectsOfType(Type type, bool includeInactive) { }

	// RVA: 0x1500704
	object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	// RVA: 0x150075C
	void DontDestroyOnLoad(object target) { }

	// RVA: 0x15007AC
	HideFlags get_hideFlags() { }

	// RVA: 0x15007FC
	void set_hideFlags(HideFlags value) { }

	// RVA: 0x2FE704C
	T[] FindObjectsOfType() { }

	// RVA: -1
	T[] FindObjectsByType(FindObjectsSortMode sortMode) { }

	// RVA: 0x309AF8C
	T FindObjectOfType() { }

	// RVA: 0x309AF8C
	T FindFirstObjectByType() { }

	// RVA: 0x14FF908
	void CheckNullArgument(object arg, string message) { }

	// RVA: 0x1500864
	object FindObjectOfType(Type type) { }

	// RVA: 0x150093C
	object FindObjectOfType(Type type, bool includeInactive) { }

	// RVA: 0x1500A18
	object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	// RVA: 0x1500B04
	string ToString() { }

	// RVA: 0x14FF184
	bool op_Equality(object x, object y) { }

	// RVA: 0x1500C00
	bool op_Inequality(object x, object y) { }

	// RVA: 0x14FEF8C
	int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	// RVA: 0x1500048
	object Internal_CloneSingle(object data) { }

	// RVA: 0x1500358
	object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	// RVA: 0x14FF958
	object Internal_InstantiateSingle(object data, Vector3 pos, Quaternion rot) { }

	// RVA: 0x14FFD9C
	object Internal_InstantiateSingleWithParent(object data, Transform parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0x1500BB0
	string ToString(object obj) { }

	// RVA: 0x14FF48C
	string GetName(object obj) { }

	// RVA: 0x14FF594
	void SetName(object obj, string name) { }

	// RVA: 0x1500D30
	object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x14FCB10
	void .ctor() { }

	// RVA: 0x1500D80
	void .cctor() { }

	// RVA: 0x1500C70
	object Internal_InstantiateSingle_Injected(object data, ref Vector3 pos, ref Quaternion rot) { }

	// RVA: 0x1500CC8
	object Internal_InstantiateSingleWithParent_Injected(object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

}

// Namespace: 
private struct WorkRequest 
{
	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x10
	private readonly object m_DelagateState; // 0x18
	private readonly ManualResetEvent m_WaitHandle; // 0x20

	// Methods

	// RVA: 0x1501240
	void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x15016AC
	void Invoke() { }

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

	// RVA: 0x1500DD0
	void .ctor(int mainThreadID) { }

	// RVA: 0x1500EA0
	void .ctor(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x1500F5C
	void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x1501290
	void OperationStarted() { }

	// RVA: 0x150129C
	void OperationCompleted() { }

	// RVA: 0x15012A8
	void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x1501410
	SynchronizationContext CreateCopy() { }

	// RVA: 0x1501480
	void Exec() { }

	// RVA: 0x1501790
	bool HasPendingTasks() { }

	// RVA: 0x15017FC
	void InitializeSynchronizationContext() { }

	// RVA: 0x1501874
	void ExecuteTasks() { }

	// RVA: 0x15018DC
	bool ExecutePendingTasks(Int64 millisecondsTimeout) { }

}

// Namespace: UnityEngine
public sealed class WaitForEndOfFrame 
{
	// Methods

	// RVA: 0x1501A64
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForFixedUpdate 
{
	// Methods

	// RVA: 0x1501A74
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForSeconds 
{
	// Fields
	internal float m_Seconds; // 0x10

	// Methods

	// RVA: 0x1501A7C
	void .ctor(float seconds) { }

}

// Namespace: UnityEngine
public class WaitForSecondsRealtime 
{
	// Fields
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Methods

	// RVA: 0x1501AB0
	float get_waitTime() { }

	// RVA: 0x1501AB8
	void set_waitTime(float value) { }

	// RVA: 0x1501AC0
	bool get_keepWaiting() { }

	// RVA: 0x1501BD4
	void .ctor(float time) { }

	// RVA: 0x1501C10
	void Reset() { }

}

// Namespace: UnityEngine
public class YieldInstruction 
{
	// Methods

	// RVA: 0x1501A6C
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializeField 
{
	// Methods

	// RVA: 0x1501C1C
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializeReference 
{}

// Namespace: UnityEngine
public sealed class PreferBinarySerialization 
{}

// Namespace: UnityEngine
public interface ISerializationCallbackReceiver 
{
	// Methods

	// RVA: 0x2FE41A8
	void OnBeforeSerialize() { }

	// RVA: 0x2FE41A8
	void OnAfterDeserialize() { }

}

// Namespace: UnityEngine
public sealed class ComputeShader 
{
	// Methods

	// RVA: 0x1501C24
	int FindKernel(string name) { }

}

// Namespace: UnityEngine
public sealed class ShaderVariantCollection 
{
	// Methods

	// RVA: 0x1501C8C
	void WarmUp() { }

}

// Namespace: UnityEngine
internal class LowerResBlitTexture 
{
	// Methods

	// RVA: 0x1501CDC
	void LowerResBlitTextureDontStripMe() { }

}

// Namespace: UnityEngine
internal class PreloadData 
{
	// Methods

	// RVA: 0x1501CE0
	void PreloadDataDontStripMe() { }

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

	// RVA: 0x1501CE4
	float get_batteryLevel() { }

	// RVA: 0x1501D64
	BatteryStatus get_batteryStatus() { }

	// RVA: 0x1501DE4
	string get_operatingSystem() { }

	// RVA: 0x1501E64
	OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x1501EE4
	string get_processorType() { }

	// RVA: 0x1501F64
	int get_processorFrequency() { }

	// RVA: 0x1501FE4
	int get_processorCount() { }

	// RVA: 0x1502064
	int get_systemMemorySize() { }

	// RVA: 0x15020E4
	string get_deviceUniqueIdentifier() { }

	// RVA: 0x1502164
	string get_deviceName() { }

	// RVA: 0x15021E4
	string get_deviceModel() { }

	// RVA: 0x1502264
	bool get_supportsAccelerometer() { }

	// RVA: 0x15022E4
	bool get_supportsGyroscope() { }

	// RVA: 0x1502364
	bool get_supportsLocationService() { }

	// RVA: 0x15023E4
	bool get_supportsVibration() { }

	// RVA: 0x1502464
	bool get_supportsAudio() { }

	// RVA: 0x15024E4
	DeviceType get_deviceType() { }

	// RVA: 0x1502564
	int get_graphicsMemorySize() { }

	// RVA: 0x15025E4
	string get_graphicsDeviceName() { }

	// RVA: 0x1502664
	string get_graphicsDeviceVendor() { }

	// RVA: 0x15026E4
	int get_graphicsDeviceID() { }

	// RVA: 0x1502764
	int get_graphicsDeviceVendorID() { }

	// RVA: 0x15027E4
	GraphicsDeviceType get_graphicsDeviceType() { }

	// RVA: 0x1502864
	string get_graphicsDeviceVersion() { }

	// RVA: 0x15028E4
	int get_graphicsShaderLevel() { }

	// RVA: 0x1502964
	bool get_graphicsMultiThreaded() { }

	// RVA: 0x15029E4
	bool get_supportsShadows() { }

	// RVA: 0x1502A64
	bool get_supportsRawShadowDepthSampling() { }

	// RVA: 0x1502AE4
	bool get_supports3DTextures() { }

	// RVA: 0x1502B64
	bool get_supports2DArrayTextures() { }

	// RVA: 0x1502BE4
	bool get_supports3DRenderTextures() { }

	// RVA: 0x1502C64
	bool get_supportsCubemapArrayTextures() { }

	// RVA: 0x1502CE4
	CopyTextureSupport get_copyTextureSupport() { }

	// RVA: 0x1502D64
	bool get_supportsComputeShaders() { }

	// RVA: 0x1502DE4
	bool get_supportsInstancing() { }

	// RVA: 0x1502E64
	bool get_supports32bitsIndexBuffer() { }

	// RVA: 0x1502EE4
	bool get_supportsSparseTextures() { }

	// RVA: 0x1502F64
	int get_supportedRenderTargetCount() { }

	// RVA: 0x1502FE4
	bool IsValidEnumValue(Enum value) { }

	// RVA: 0x1503064
	bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x15031F0
	bool SupportsTextureFormat(TextureFormat format) { }

	// RVA: 0x150337C
	NPOTSupport get_npotSupport() { }

	// RVA: 0x15033FC
	int get_maxTextureSize() { }

	// RVA: 0x150347C
	int get_maxRenderTextureSize() { }

	// RVA: 0x1501D24
	float GetBatteryLevel() { }

	// RVA: 0x1501DA4
	BatteryStatus GetBatteryStatus() { }

	// RVA: 0x1501E24
	string GetOperatingSystem() { }

	// RVA: 0x1501EA4
	OperatingSystemFamily GetOperatingSystemFamily() { }

	// RVA: 0x1501F24
	string GetProcessorType() { }

	// RVA: 0x1501FA4
	int GetProcessorFrequencyMHz() { }

	// RVA: 0x1502024
	int GetProcessorCount() { }

	// RVA: 0x15020A4
	int GetPhysicalMemoryMB() { }

	// RVA: 0x1502124
	string GetDeviceUniqueIdentifier() { }

	// RVA: 0x15021A4
	string GetDeviceName() { }

	// RVA: 0x1502224
	string GetDeviceModel() { }

	// RVA: 0x15022A4
	bool SupportsAccelerometer() { }

	// RVA: 0x1502324
	bool IsGyroAvailable() { }

	// RVA: 0x15023A4
	bool SupportsLocationService() { }

	// RVA: 0x1502424
	bool SupportsVibration() { }

	// RVA: 0x15024A4
	bool SupportsAudio() { }

	// RVA: 0x1502524
	DeviceType GetDeviceType() { }

	// RVA: 0x15025A4
	int GetGraphicsMemorySize() { }

	// RVA: 0x1502624
	string GetGraphicsDeviceName() { }

	// RVA: 0x15026A4
	string GetGraphicsDeviceVendor() { }

	// RVA: 0x1502724
	int GetGraphicsDeviceID() { }

	// RVA: 0x15027A4
	int GetGraphicsDeviceVendorID() { }

	// RVA: 0x1502824
	GraphicsDeviceType GetGraphicsDeviceType() { }

	// RVA: 0x15028A4
	string GetGraphicsDeviceVersion() { }

	// RVA: 0x1502924
	int GetGraphicsShaderLevel() { }

	// RVA: 0x15029A4
	bool GetGraphicsMultiThreaded() { }

	// RVA: 0x1502A24
	bool SupportsShadows() { }

	// RVA: 0x1502AA4
	bool SupportsRawShadowDepthSampling() { }

	// RVA: 0x1502B24
	bool Supports3DTextures() { }

	// RVA: 0x1502BA4
	bool Supports2DArrayTextures() { }

	// RVA: 0x1502C24
	bool Supports3DRenderTextures() { }

	// RVA: 0x1502CA4
	bool SupportsCubemapArrayTextures() { }

	// RVA: 0x1502D24
	CopyTextureSupport GetCopyTextureSupport() { }

	// RVA: 0x1502DA4
	bool SupportsComputeShaders() { }

	// RVA: 0x1502E24
	bool SupportsInstancing() { }

	// RVA: 0x1502EA4
	bool Supports32bitsIndexBuffer() { }

	// RVA: 0x1502F24
	bool SupportsSparseTextures() { }

	// RVA: 0x1502FA4
	int SupportedRenderTargetCount() { }

	// RVA: 0x15031A0
	bool HasRenderTextureNative(RenderTextureFormat format) { }

	// RVA: 0x150332C
	bool SupportsTextureFormatNative(TextureFormat format) { }

	// RVA: 0x15033BC
	NPOTSupport GetNPOTSupport() { }

	// RVA: 0x150343C
	int GetMaxTextureSize() { }

	// RVA: 0x15034BC
	int GetMaxRenderTextureSize() { }

	// RVA: 0x15034FC
	bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x1503564
	GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x15035CC
	GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

}

// Namespace: UnityEngine
internal class SystemClock 
{
	// Fields
	private static readonly DateTime s_Epoch; // 0x0

	// Methods

	// RVA: 0x150361C
	DateTime get_now() { }

	// RVA: 0x150368C
	void .cctor() { }

}

// Namespace: UnityEngine
public class Time 
{
	// Methods

	// RVA: 0x150370C
	float get_time() { }

	// RVA: 0x150374C
	float get_timeSinceLevelLoad() { }

	// RVA: 0x150378C
	float get_deltaTime() { }

	// RVA: 0x15037CC
	float get_unscaledTime() { }

	// RVA: 0x150380C
	float get_fixedUnscaledTime() { }

	// RVA: 0x150384C
	float get_unscaledDeltaTime() { }

	// RVA: 0x150388C
	float get_fixedDeltaTime() { }

	// RVA: 0x15038CC
	void set_fixedDeltaTime(float value) { }

	// RVA: 0x1503924
	float get_timeScale() { }

	// RVA: 0x1503964
	void set_timeScale(float value) { }

	// RVA: 0x15039BC
	int get_frameCount() { }

	// RVA: 0x15039FC
	int get_renderedFrameCount() { }

	// RVA: 0x1501B94
	float get_realtimeSinceStartup() { }

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

	// RVA: 0x1503A3C
	void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1503A8C
	void Destroy() { }

	// RVA: 0x1503B58
	void Finalize() { }

	// RVA: 0x1503C78
	void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	// RVA: 0x1503DD4
	IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x1503E2C
	bool get_isSupported() { }

	// RVA: 0x1503F10
	bool get_disableInPlaceEditing() { }

	// RVA: 0x1503F5C
	bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x1503FA8
	bool get_isRequiredToForceOpen() { }

	// RVA: 0x1503FE8
	bool IsRequiredToForceOpen() { }

	// RVA: 0x1504028
	TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	// RVA: 0x15040E4
	TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	// RVA: 0x15041B8
	string get_text() { }

	// RVA: 0x1504208
	void set_text(string value) { }

	// RVA: 0x1504270
	void set_hideInput(bool value) { }

	// RVA: 0x15042C0
	bool get_active() { }

	// RVA: 0x1504310
	void set_active(bool value) { }

	// RVA: 0x1504378
	Status get_status() { }

	// RVA: 0x15043C8
	void set_characterLimit(int value) { }

	// RVA: 0x1504430
	bool get_canGetSelection() { }

	// RVA: 0x1504480
	bool get_canSetSelection() { }

	// RVA: 0x15044D0
	RangeInt get_selection() { }

	// RVA: 0x1504590
	void set_selection(RangeInt value) { }

	// RVA: 0x1504528
	void GetSelection(out int start, out int length) { }

	// RVA: 0x15046A0
	void SetSelection(int start, int length) { }

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

	// RVA: 0x1504708
	bool TryConvertStringToDouble(string str, out Double value, out Expression expr) { }

	// RVA: 0x15048B4
	bool TryConvertStringToDouble(string str, string initialValueAsString, out Double value) { }

	// RVA: 0x1504A18
	bool TryConvertStringToFloat(string str, string initialValueAsString, out float value) { }

	// RVA: 0x1504AB8
	bool TryConvertStringToLong(string str, out Int64 value, out Expression expr) { }

	// RVA: 0x1504B48
	bool TryConvertStringToLong(string str, string initialValueAsString, out Int64 value) { }

	// RVA: 0x1504D70
	bool TryConvertStringToULong(string str, out UInt64 value, out Expression expr) { }

	// RVA: 0x1504E00
	bool TryConvertStringToULong(string str, string initialValueAsString, out UInt64 value) { }

	// RVA: 0x1505028
	bool TryConvertStringToInt(string str, string initialValueAsString, out int value) { }

	// RVA: 0x15050C8
	bool TryConvertStringToUInt(string str, string initialValueAsString, out UInt32 value) { }

	// RVA: 0x1505168
	void .cctor() { }

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

	// RVA: 0x1505290
	void Add(object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) { }

	// RVA: 0x1505294
	void Clear() { }

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

	// RVA: 0x1506C90
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1506D44
	internal void Invoke(RectTransform driven) { }

}

// Namespace: UnityEngine
public sealed class RectTransform 
{
	// Fields
	private static ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Methods

	// RVA: 0x1505298
	void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0x1505358
	void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0x1505418
	Rect get_rect() { }

	// RVA: 0x15054DC
	Vector2 get_anchorMin() { }

	// RVA: 0x150559C
	void set_anchorMin(Vector2 value) { }

	// RVA: 0x1505658
	Vector2 get_anchorMax() { }

	// RVA: 0x1505718
	void set_anchorMax(Vector2 value) { }

	// RVA: 0x15057D4
	Vector2 get_anchoredPosition() { }

	// RVA: 0x1505894
	void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x1505950
	Vector2 get_sizeDelta() { }

	// RVA: 0x1505A10
	void set_sizeDelta(Vector2 value) { }

	// RVA: 0x1505ACC
	Vector2 get_pivot() { }

	// RVA: 0x1505B8C
	void set_pivot(Vector2 value) { }

	// RVA: 0x1505C48
	void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x1505DCC
	Vector2 get_offsetMin() { }

	// RVA: 0x1505EA0
	void set_offsetMin(Vector2 value) { }

	// RVA: 0x15060E4
	Vector2 get_offsetMax() { }

	// RVA: 0x15061F8
	void set_offsetMax(Vector2 value) { }

	// RVA: 0x150643C
	void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x1506568
	void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x15067B4
	void SetSizeWithCurrentAnchors(Axis axis, float size) { }

	// RVA: 0x1506BC4
	void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x15069B4
	Vector2 GetParentSize() { }

	// RVA: 0x1505474
	void get_rect_Injected(out Rect ret) { }

	// RVA: 0x1505534
	void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x15055F0
	void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x15056B0
	void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x150576C
	void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x150582C
	void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x15058E8
	void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x15059A8
	void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x1505A64
	void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x1505B24
	void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x1505BE0
	void set_pivot_Injected(ref Vector2 value) { }

}

// Namespace: 
private class Enumerator 
{
	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Methods

	// RVA: 0x1508E94
	void .ctor(Transform outer) { }

	// RVA: 0x1508F38
	object get_Current() { }

	// RVA: 0x1508FA8
	bool MoveNext() { }

	// RVA: 0x1509014
	void Reset() { }

}

// Namespace: UnityEngine
public class Transform 
{
	// Methods

	// RVA: 0x1506D58
	void .ctor() { }

	// RVA: 0x1506D60
	Vector3 get_position() { }

	// RVA: 0x1506E28
	void set_position(Vector3 value) { }

	// RVA: 0x1505D14
	Vector3 get_localPosition() { }

	// RVA: 0x1505D74
	void set_localPosition(Vector3 value) { }

	// RVA: 0x1506FB8
	Vector3 get_eulerAngles() { }

	// RVA: 0x1507098
	Vector3 get_localEulerAngles() { }

	// RVA: 0x1507178
	void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x1507248
	Vector3 get_right() { }

	// RVA: 0x1507304
	Vector3 get_up() { }

	// RVA: 0x15073C0
	Vector3 get_forward() { }

	// RVA: 0x150703C
	Quaternion get_rotation() { }

	// RVA: 0x15074E4
	void set_rotation(Quaternion value) { }

	// RVA: 0x150711C
	Quaternion get_localRotation() { }

	// RVA: 0x15071F0
	void set_localRotation(Quaternion value) { }

	// RVA: 0x1507674
	Vector3 get_localScale() { }

	// RVA: 0x150773C
	void set_localScale(Vector3 value) { }

	// RVA: 0x1506C40
	Transform get_parent() { }

	// RVA: 0x150784C
	void set_parent(Transform value) { }

	// RVA: 0x15077FC
	Transform get_parentInternal() { }

	// RVA: 0x1507934
	void set_parentInternal(Transform value) { }

	// RVA: 0x1507988
	Transform GetParent() { }

	// RVA: 0x15079D8
	void SetParent(Transform p) { }

	// RVA: 0x1507A2C
	void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x1507A84
	Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x150673C
	Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x1507BCC
	void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x1507C88
	void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0x1507D44
	void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x1507F1C
	void Translate(float x, float y, float z) { }

	// RVA: 0x1507F24
	void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x15082AC
	void Rotate(Vector3 eulers) { }

	// RVA: 0x15082B4
	void Rotate(float xAngle, float yAngle, float zAngle) { }

	// RVA: 0x15082BC
	void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x1508384
	void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x15084A8
	void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x1507EB0
	Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x1508508
	Vector3 TransformDirection(float x, float y, float z) { }

	// RVA: 0x1508574
	Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x1508638
	Vector3 TransformVector(float x, float y, float z) { }

	// RVA: 0x15086A4
	Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x1508768
	Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x150882C
	Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x15088F0
	Transform get_root() { }

	// RVA: 0x1508940
	Transform GetRoot() { }

	// RVA: 0x1508990
	int get_childCount() { }

	// RVA: 0x15089E0
	void SetAsFirstSibling() { }

	// RVA: 0x1508A30
	void SetAsLastSibling() { }

	// RVA: 0x1508A80
	void SetSiblingIndex(int index) { }

	// RVA: 0x1508AE8
	int GetSiblingIndex() { }

	// RVA: 0x1508B38
	Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x1508B90
	Transform Find(string n) { }

	// RVA: 0x1508C30
	Vector3 get_lossyScale() { }

	// RVA: 0x1508CF8
	bool IsChildOf(Transform parent) { }

	// RVA: 0x1508D60
	bool get_hasChanged() { }

	// RVA: 0x1508DB0
	void set_hasChanged(bool value) { }

	// RVA: 0x1508E18
	IEnumerator GetEnumerator() { }

	// RVA: 0x1508ED0
	Transform GetChild(int index) { }

	// RVA: 0x1506DC0
	void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x1506E80
	void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x1506EE8
	void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x1506F50
	void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x150747C
	void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x150753C
	void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x15075A4
	void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x150760C
	void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x15076D4
	void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x1507794
	void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x1507AFC
	void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1507B64
	void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1507C30
	void SetPositionAndRotation_Injected(ref Vector3 position, ref Quaternion rotation) { }

	// RVA: 0x1507CEC
	void SetLocalPositionAndRotation_Injected(ref Vector3 localPosition, ref Quaternion localRotation) { }

	// RVA: 0x1508324
	void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x15084B0
	void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x15085E0
	void TransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x1508710
	void InverseTransformVector_Injected(ref Vector3 vector, out Vector3 ret) { }

	// RVA: 0x15087D4
	void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x1508898
	void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x1508C90
	void get_lossyScale_Injected(out Vector3 ret) { }

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

	// RVA: 0x1509020
	void InvokeSpriteChanged() { }

	// RVA: 0x150911C
	void set_sprite(Sprite value) { }

	// RVA: 0x1509184
	void set_color(Color value) { }

	// RVA: 0x15091DC
	void set_color_Injected(ref Color value) { }

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

	// RVA: 0x1509244
	void .ctor() { }

	// RVA: 0x15092CC
	int GetPackingRotation() { }

	// RVA: 0x150931C
	int GetPacked() { }

	// RVA: 0x150936C
	Rect GetTextureRect() { }

	// RVA: 0x1509430
	Vector4 GetInnerUVs() { }

	// RVA: 0x15094F4
	Vector4 GetOuterUVs() { }

	// RVA: 0x15095B8
	Vector4 GetPadding() { }

	// RVA: 0x150967C
	Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x15097D0
	Bounds get_bounds() { }

	// RVA: 0x15098AC
	Rect get_rect() { }

	// RVA: 0x1509970
	Vector4 get_border() { }

	// RVA: 0x1509A34
	Texture2D get_texture() { }

	// RVA: 0x1509A84
	float get_pixelsPerUnit() { }

	// RVA: 0x1509AD4
	Texture2D get_associatedAlphaSplitTexture() { }

	// RVA: 0x1509B24
	Vector2 get_pivot() { }

	// RVA: 0x1509BE4
	bool get_packed() { }

	// RVA: 0x1509C30
	SpritePackingRotation get_packingRotation() { }

	// RVA: 0x1509C80
	Rect get_textureRect() { }

	// RVA: 0x1509CDC
	Vector2[] get_vertices() { }

	// RVA: 0x1509D2C
	UInt16[] get_triangles() { }

	// RVA: 0x1509D7C
	Vector2[] get_uv() { }

	// RVA: 0x1509DCC
	Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x1509DDC
	Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	// RVA: 0x150A324
	Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x150A338
	Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType) { }

	// RVA: 0x150A424
	Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude) { }

	// RVA: 0x150A50C
	Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x150A5E8
	Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x15093C8
	void GetTextureRect_Injected(out Rect ret) { }

	// RVA: 0x150948C
	void GetInnerUVs_Injected(out Vector4 ret) { }

	// RVA: 0x1509550
	void GetOuterUVs_Injected(out Vector4 ret) { }

	// RVA: 0x1509614
	void GetPadding_Injected(out Vector4 ret) { }

	// RVA: 0x1509728
	Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x1509844
	void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x1509908
	void get_rect_Injected(out Rect ret) { }

	// RVA: 0x15099CC
	void get_border_Injected(out Vector4 ret) { }

	// RVA: 0x1509B7C
	void get_pivot_Injected(out Vector2 ret) { }

}

// Namespace: UnityEngine._Scripting.APIUpdating
internal class APIUpdaterRuntimeHelpers 
{
	// Methods

	// RVA: 0x150A6BC
	bool GetMovedFromAttributeDataForType(Type sourceType, out string assembly, out string nsp, out string klass) { }

	// RVA: 0x150A844
	bool GetObsoleteTypeRedirection(Type sourceType, out string assemblyName, out string nsp, out string className) { }

}

// Namespace: UnityEngine.Sprites
public sealed class DataUtility 
{
	// Methods

	// RVA: 0x150ABB8
	Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0x150AC1C
	Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0x150AC80
	Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0x150ACE4
	Vector2 GetMinSize(Sprite sprite) { }

}

// Namespace: UnityEngine.U2D
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

	// RVA: 0x150ADF0
	bool RequestAtlas(string tag) { }

	// RVA: 0x150AEB0
	void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }

	// RVA: 0x150AF84
	void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }

	// RVA: 0x150B058
	void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x150B0D4
	void Register(SpriteAtlas spriteAtlas) { }

}

// Namespace: UnityEngine.U2D
public class SpriteAtlas 
{
	// Methods

	// RVA: 0x150B124
	bool CanBindTo(Sprite sprite) { }

}

// Namespace: UnityEngine.Profiling
public sealed class Profiler 
{
	// Methods

	// RVA: 0x150B18C
	void BeginSample(string name) { }

	// RVA: 0x150B2B4
	void ValidateArguments(string name) { }

	// RVA: 0x150B24C
	void BeginSampleImpl(string name, object targetObject) { }

	// RVA: 0x150B334
	void EndSample() { }

	// RVA: 0x150B374
	Int64 GetRuntimeMemorySizeLong(object o) { }

	// RVA: 0x150B3C4
	Int64 GetMonoHeapSizeLong() { }

	// RVA: 0x150B404
	Int64 GetMonoUsedSizeLong() { }

	// RVA: 0x150B444
	Int64 GetTotalAllocatedMemoryLong() { }

	// RVA: 0x150B484
	Int64 GetTotalUnusedReservedMemoryLong() { }

	// RVA: 0x150B4C4
	Int64 GetTotalReservedMemoryLong() { }

}

// Namespace: UnityEngine.Events
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

	// RVA: 0x150B504
	string TidyAssemblyTypeName(string assemblyTypeName) { }

}

// Namespace: UnityEngine.Events
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

	// RVA: 0x150B740
	object get_unityObjectArgument() { }

	// RVA: 0x150B748
	string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x150B750
	int get_intArgument() { }

	// RVA: 0x150B758
	float get_floatArgument() { }

	// RVA: 0x150B760
	string get_stringArgument() { }

	// RVA: 0x150B768
	bool get_boolArgument() { }

	// RVA: 0x150B770
	void OnBeforeSerialize() { }

	// RVA: 0x150B7A0
	void OnAfterDeserialize() { }

	// RVA: 0x150B7D0
	void .ctor() { }

}

// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall 
{
	// Methods

	// RVA: 0x150B7D8
	void .ctor() { }

	// RVA: 0x150B7E0
	void .ctor(object target, MethodInfo function) { }

	// RVA: 0x2FE4574
	void Invoke(object[] args) { }

	// RVA: 0x2FE9A04
	void ThrowOnInvalidArg(object arg) { }

	// RVA: 0x150B8EC
	bool AllowInvoke(Delegate delegate) { }

	// RVA: -1
	bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall 
{
	// Fields
	private UnityAction Delegate; // 0x10

	// Methods

	// RVA: 0x150BA34
	void add_Delegate(UnityAction value) { }

	// RVA: 0x150BAD8
	void remove_Delegate(UnityAction value) { }

	// RVA: 0x150BB7C
	void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x150BCD4
	void .ctor(UnityAction action) { }

	// RVA: 0x150BD80
	void Invoke(object[] args) { }

	// RVA: 0x150BDCC
	void Invoke() { }

	// RVA: 0x150BE18
	bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0> 
{
	// Fields
	private UnityEngine.Events.UnityAction<T1> Delegate; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void add_Delegate(UnityEngine.Events.UnityAction<T1> value) { }

	// RVA: 0x2FE4574
	void remove_Delegate(UnityEngine.Events.UnityAction<T1> value) { }

	// RVA: 0x2FE47D4
	void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x2FE4574
	void .ctor(UnityEngine.Events.UnityAction<T1> action) { }

	// RVA: 0x2FE4574
	void Invoke(object[] args) { }

	// RVA: 0x309AF8C
	void Invoke(T1 args0) { }

	// RVA: -1
	bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0, T1> 
{
	// Fields
	private UnityEngine.Events.UnityAction<T1,T2> Delegate; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x2FE4574
	void Invoke(object[] args) { }

	// RVA: 0x309AF8C
	void Invoke(T1 args0, T2 args1) { }

	// RVA: -1
	bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0, T1, T2> 
{
	// Fields
	private UnityEngine.Events.UnityAction<T1,T2,T3> Delegate; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x2FE4574
	void Invoke(object[] args) { }

	// RVA: -1
	bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0, T1, T2, T3> 
{
	// Fields
	private UnityEngine.Events.UnityAction<T1,T2,T3,T4> Delegate; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x2FE4574
	void Invoke(object[] args) { }

	// RVA: -1
	bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class CachedInvokableCall<T0> 
{
	// Fields
	private readonly T m_Arg1; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(object target, MethodInfo theFunction, T argument) { }

	// RVA: 0x2FE4574
	void Invoke(object[] args) { }

	// RVA: 0x309AF8C
	void Invoke(T arg0) { }

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

	// RVA: 0x150BE74
	object get_target() { }

	// RVA: 0x150BE7C
	string get_targetAssemblyTypeName() { }

	// RVA: 0x150BFF0
	string get_methodName() { }

	// RVA: 0x150BFF8
	PersistentListenerMode get_mode() { }

	// RVA: 0x150C000
	ArgumentCache get_arguments() { }

	// RVA: 0x150C008
	bool IsValid() { }

	// RVA: 0x150C054
	BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x150C69C
	BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x150CC0C
	void OnBeforeSerialize() { }

	// RVA: 0x150CC3C
	void OnAfterDeserialize() { }

	// RVA: 0x150CC6C
	void .ctor() { }

}

// Namespace: UnityEngine.Events
internal class PersistentCallGroup 
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls; // 0x10

	// Methods

	// RVA: 0x150CCF0
	void .ctor() { }

	// RVA: 0x150CD7C
	int get_Count() { }

	// RVA: 0x150CDC8
	void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }

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

	// RVA: 0x150D03C
	void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x150D0AC
	void AddListener(BaseInvokableCall call) { }

	// RVA: 0x150D11C
	void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x150D3D0
	void Clear() { }

	// RVA: 0x150D4CC
	void ClearPersistent() { }

	// RVA: 0x150D5C8
	System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x150D6B0
	void .ctor() { }

}

// Namespace: UnityEngine.Events
public abstract class UnityEventBase 
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x150D78C
	void .ctor() { }

	// RVA: 0x150D8A8
	void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x150D910
	void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x2FE37A0
	MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x2FE37A0
	BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x150C3E4
	MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x150D944
	MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x150DE64
	int GetPersistentEventCount() { }

	// RVA: 0x150D8DC
	void DirtyPersistentCalls() { }

	// RVA: 0x150DEB4
	void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x150DEF4
	void AddCall(BaseInvokableCall call) { }

	// RVA: 0x150DF68
	void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x150DF84
	void RemoveAllListeners() { }

	// RVA: 0x150DFA0
	System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x150DFE8
	string ToString() { }

	// RVA: 0x150DC78
	MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction 
{
	// Methods

	// RVA: 0x150E070
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x150E110
	internal void Invoke() { }

}

// Namespace: UnityEngine.Events
public class UnityEvent 
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	// RVA: 0x150E124
	void .ctor() { }

	// RVA: 0x150E150
	void AddListener(UnityAction call) { }

	// RVA: 0x150E2BC
	void RemoveListener(UnityAction call) { }

	// RVA: 0x150E300
	MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x150E368
	BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x150E1D0
	BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x150E3D4
	void Invoke() { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T0 arg0) { }

}

// Namespace: UnityEngine.Events
public class UnityEvent<T0> 
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void AddListener(UnityEngine.Events.UnityAction<T0> call) { }

	// RVA: 0x2FE4574
	void RemoveListener(UnityEngine.Events.UnityAction<T0> call) { }

	// RVA: 0x2FE37A0
	MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x2FE37A0
	BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x2FE7084
	BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action) { }

	// RVA: 0x309AF8C
	void Invoke(T0 arg0) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T0 arg0, T1 arg1) { }

}

// Namespace: UnityEngine.Events
public class UnityEvent<T0, T1> 
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE37A0
	MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x2FE37A0
	BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x309AF8C
	void Invoke(T0 arg0, T1 arg1) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

}

// Namespace: UnityEngine.Events
public class UnityEvent<T0, T1, T2> 
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE37A0
	MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x2FE37A0
	BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

}

// Namespace: UnityEngine.Events
public class UnityEvent<T0, T1, T2, T3> 
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE37A0
	MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x2FE37A0
	BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

// Namespace: UnityEngine.Serialization
public class FormerlySerializedAsAttribute 
{
	// Fields
	private string m_oldName; // 0x10

	// Methods

	// RVA: 0x150E5DC
	void .ctor(string oldName) { }

}

// Namespace: UnityEngine.Scripting
public class AlwaysLinkAssemblyAttribute 
{
	// Methods

	// RVA: 0x150E610
	void .ctor() { }

}

// Namespace: UnityEngine.Scripting
public static class GarbageCollector 
{
	// Methods

	// RVA: 0x150E618
	bool get_isIncremental() { }

	// RVA: 0x150E658
	UInt64 get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x150E698
	bool CollectIncremental(UInt64 nanoseconds) { }

}

// Namespace: UnityEngine.Scripting
public class PreserveAttribute 
{
	// Methods

	// RVA: 0x14FCA10
	void .ctor() { }

}

// Namespace: UnityEngine.Scripting
public class RequireImplementorsAttribute 
{
	// Methods

	// RVA: 0x150E6E8
	void .ctor() { }

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

	// RVA: 0x150E6F0
	void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

}

// Namespace: UnityEngine.Scripting.APIUpdating
public class MovedFromAttribute 
{
	// Fields
	internal MovedFromAttributeData data; // 0x10

	// Methods

	// RVA: 0x150E78C
	void .ctor(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

	// RVA: 0x150E83C
	void .ctor(string sourceNamespace) { }

}

// Namespace: UnityEngine.SceneManagement
public struct Scene 
{
	// Fields
	private int m_Handle; // 0x10

	// Methods

	// RVA: 0x150E8DC
	bool IsValidInternal(int sceneHandle) { }

	// RVA: 0x150E92C
	string GetPathInternal(int sceneHandle) { }

	// RVA: 0x150E97C
	string GetNameInternal(int sceneHandle) { }

	// RVA: 0x150E9CC
	bool GetIsLoadedInternal(int sceneHandle) { }

	// RVA: 0x150EA1C
	int GetBuildIndexInternal(int sceneHandle) { }

	// RVA: 0x150EA6C
	int GetRootCountInternal(int sceneHandle) { }

	// RVA: 0x150EABC
	void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x150EB24
	int get_handle() { }

	// RVA: 0x150EB2C
	bool IsValid() { }

	// RVA: 0x150EB7C
	string get_path() { }

	// RVA: 0x150EBCC
	string get_name() { }

	// RVA: 0x150EC1C
	bool get_isLoaded() { }

	// RVA: 0x150EC6C
	int get_buildIndex() { }

	// RVA: 0x150ECBC
	int get_rootCount() { }

	// RVA: 0x150ED0C
	GameObject[] GetRootGameObjects() { }

	// RVA: 0x150EDEC
	void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects) { }

	// RVA: 0x150F0F0
	bool op_Equality(Scene lhs, Scene rhs) { }

	// RVA: 0x150F0FC
	int GetHashCode() { }

	// RVA: 0x150F104
	bool Equals(object other) { }

}

// Namespace: UnityEngine.SceneManagement
internal static class SceneManagerAPIInternal 
{
	// Methods

	// RVA: 0x150F194
	AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x150F268
	AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

	// RVA: 0x150F200
	AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

}

// Namespace: UnityEngine.SceneManagement
public class SceneManagerAPI 
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Methods

	// RVA: 0x150F2D8
	SceneManagerAPI get_ActiveAPI() { }

	// RVA: 0x150F3D8
	SceneManagerAPI get_overrideAPI() { }

	// RVA: 0x150F454
	void .ctor() { }

	// RVA: 0x150F45C
	AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x150F4C8
	AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

	// RVA: 0x150F538
	AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x150F540
	void .cctor() { }

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

	// RVA: 0x150F5AC
	int get_sceneCount() { }

	// RVA: 0x150F5EC
	Scene GetActiveScene() { }

	// RVA: 0x150F6E4
	bool SetActiveScene(Scene scene) { }

	// RVA: 0x150F7E8
	Scene GetSceneByName(string name) { }

	// RVA: 0x150F908
	Scene GetSceneAt(int index) { }

	// RVA: 0x150FA28
	AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x150FB20
	AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess) { }

	// RVA: 0x150FC30
	AsyncOperation LoadFirstScene_Internal(bool async) { }

	// RVA: 0x150FCB8
	void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }

	// RVA: 0x150FDCC
	void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }

	// RVA: 0x150FEE0
	void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x150FFF4
	void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x1510108
	void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x151021C
	void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x1510330
	AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x1510400
	AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x1510470
	AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options) { }

	// RVA: 0x15104F4
	void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x15105D4
	void Internal_SceneUnloaded(Scene scene) { }

	// RVA: 0x15106AC
	void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x151078C
	void .cctor() { }

	// RVA: 0x150F694
	void GetActiveScene_Injected(out Scene ret) { }

	// RVA: 0x150F798
	bool SetActiveScene_Injected(ref Scene scene) { }

	// RVA: 0x150F8A0
	void GetSceneByName_Injected(string name, out Scene ret) { }

	// RVA: 0x150F9C0
	void GetSceneAt_Injected(int index, out Scene ret) { }

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
public struct LoadSceneParameters 
{
	// Fields
	private LoadSceneMode m_LoadSceneMode; // 0x10
	private LocalPhysicsMode m_LocalPhysicsMode; // 0x14

	// Methods

	// RVA: 0x15103F8
	void .ctor(LoadSceneMode mode) { }

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

	// RVA: 0x1510800
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x15108A0
	internal void Invoke() { }

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

	// RVA: 0x15107DC
	string ToString() { }

}

// Namespace: UnityEngine.LowLevel
public class PlayerLoop 
{
	// Methods

	// RVA: 0x15108B4
	PlayerLoopSystem GetCurrentPlayerLoop() { }

	// RVA: 0x1510BD8
	void SetPlayerLoop(PlayerLoopSystem loop) { }

	// RVA: 0x1510CD8
	int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal>& internalSys) { }

	// RVA: 0x1510964
	PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	// RVA: 0x1510924
	PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	// RVA: 0x1510E64
	void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }

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
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Pool.CollectionPool.<>c<TCollection,TItem> <>9; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	TCollection <.cctor>b__5_0() { }

	// RVA: 0x309AF8C
	void <.cctor>b__5_1(TCollection l) { }

}

// Namespace: UnityEngine.Pool
public class CollectionPool<T0, T1> 
{
	// Fields
	internal static readonly UnityEngine.Pool.ObjectPool<TCollection> s_Pool; // 0x0

	// Methods

	// RVA: 0x309AF8C
	TCollection Get() { }

	// RVA: 0x309AF8C
	UnityEngine.Pool.PooledObject<TCollection> Get(out TCollection value) { }

	// RVA: 0x309AF8C
	void Release(TCollection toRelease) { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: UnityEngine.Pool
public interface IObjectPool<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	void Release(T element) { }

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

	// RVA: 0x2FE32D4
	int get_CountAll() { }

	// RVA: 0x2FE42A4
	void set_CountAll(int value) { }

	// RVA: 0x2FE32D4
	int get_CountInactive() { }

	// RVA: 0x309AF8C
	void .ctor(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, bool collectionCheck, int defaultCapacity, int maxSize) { }

	// RVA: 0x309AF8C
	T Get() { }

	// RVA: 0x309AF8C
	UnityEngine.Pool.PooledObject<T> Get(out T v) { }

	// RVA: 0x309AF8C
	void Release(T element) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x2FE41A8
	void Dispose() { }

}

// Namespace: UnityEngine.Pool
public struct PooledObject<T0> 
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly UnityEngine.Pool.IObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void .ctor(T value, UnityEngine.Pool.IObjectPool<T> pool) { }

	// RVA: 0x2FE41A8
	void System.IDisposable.Dispose() { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
public class MessageEventArgs 
{
	// Fields
	public int playerId; // 0x10
	public Byte[] data; // 0x18

	// Methods

	// RVA: 0x1510EB4
	void .ctor() { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
public interface IEditorPlayerConnection 
{
	// Methods

	// RVA: -1
	void Register(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x2FE4574
	void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x2FE4574
	void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: -1
	void Send(Guid messageId, Byte[] data) { }

}

// Namespace: 
private sealed class <>c__DisplayClass12_0 
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1511690
	void .ctor() { }

	// RVA: 0x1513134
	bool <Register>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0 
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1511AF4
	void .ctor() { }

	// RVA: 0x15131B4
	bool <Unregister>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0 
{
	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x1512648
	void .ctor() { }

	// RVA: 0x1513204
	void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
public class PlayerConnection 
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	private System.Collections.Generic.List<System.Int32> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Methods

	// RVA: 0x1510EBC
	PlayerConnection get_instance() { }

	// RVA: 0x15110E4
	bool get_isConnected() { }

	// RVA: 0x1511020
	PlayerConnection CreateInstance() { }

	// RVA: 0x15112B8
	void OnEnable() { }

	// RVA: 0x151121C
	IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x15113F0
	void Register(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x15118F4
	void Unregister(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x1511C6C
	void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x1511EFC
	void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x1511F68
	void UnregisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x1511FD4
	void UnregisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x1512040
	void Send(Guid messageId, Byte[] data) { }

	// RVA: 0x15121FC
	bool TrySend(Guid messageId, Byte[] data) { }

	// RVA: 0x15123B8
	bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x1512650
	void DisconnectAll() { }

	// RVA: 0x1512788
	void MessageCallbackInternal(IntPtr data, UInt64 size, UInt64 guid, string messageId) { }

	// RVA: 0x1512D3C
	void ConnectedCallbackInternal(int playerId) { }

	// RVA: 0x1512DE8
	void DisconnectedCallback(int playerId) { }

	// RVA: 0x1512E94
	void .ctor() { }

}

// Namespace: 
public class MessageEvent 
{
	// Methods

	// RVA: 0x151330C
	void .ctor() { }

}

// Namespace: 
public class ConnectionChangeEvent 
{
	// Methods

	// RVA: 0x1513368
	void .ctor() { }

}

// Namespace: 
public class MessageTypeSubscribers 
{
	// Fields
	private string m_messageTypeId; // 0x10
	public int subscriberCount; // 0x18
	public MessageEvent messageCallback; // 0x20

	// Methods

	// RVA: 0x1513184
	Guid get_MessageTypeId() { }

	// RVA: 0x15132C8
	void set_MessageTypeId(Guid value) { }

	// RVA: 0x1513220
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1513210
	void .ctor() { }

	// RVA: 0x15133BC
	bool <InvokeMessageIdSubscribers>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1513218
	void .ctor() { }

	// RVA: 0x151340C
	bool <AddAndCreate>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1513360
	void .ctor() { }

	// RVA: 0x151345C
	bool <UnregisterManagedCallback>b__0(MessageTypeSubscribers x) { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
internal class PlayerEditorConnectionEvents 
{
	// Fields
	public System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	public ConnectionChangeEvent connectionEvent; // 0x18
	public ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0x15128B0
	void InvokeMessageIdSubscribers(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x1511698
	UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x1511AFC
	void UnregisterManagedCallback(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x1512FF8
	void .ctor() { }

}

// Namespace: UnityEngine.iOS
public sealed class Device 
{
	// Methods

	// RVA: 0x15134AC
	string get_systemVersion() { }

	// RVA: 0x15134EC
	string get_vendorIdentifier() { }

	// RVA: 0x151352C
	bool RequestStoreReview() { }

}

// Namespace: UnityEngine.iOS
public sealed class OnDemandResourcesRequest 
{
	// Methods

	// RVA: 0x151356C
	string get_error() { }

	// RVA: 0x15135BC
	void DestroyFromScript(IntPtr ptr) { }

	// RVA: 0x151360C
	void Dispose() { }

	// RVA: 0x15136D8
	void .ctor() { }

	// RVA: 0x15136E0
	void Finalize() { }

}

// Namespace: UnityEngine.iOS
public static class OnDemandResources 
{
	// Methods

	// RVA: 0x1513800
	bool get_enabled() { }

	// RVA: 0x1513840
	OnDemandResourcesRequest PreloadAsyncImpl(string[] tags) { }

	// RVA: 0x1513890
	OnDemandResourcesRequest PreloadAsync(string[] tags) { }

}

// Namespace: UnityEngine.Internal
public class DefaultValueAttribute 
{
	// Fields
	private object DefaultValue; // 0x10

	// Methods

	// RVA: 0x15138E0
	void .ctor(string value) { }

	// RVA: 0x1513914
	object get_Value() { }

	// RVA: 0x151391C
	bool Equals(object obj) { }

	// RVA: 0x15139DC
	int GetHashCode() { }

}

// Namespace: UnityEngine.Internal
public class ExcludeFromDocsAttribute 
{
	// Methods

	// RVA: 0x1513A00
	void .ctor() { }

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

	// RVA: 0x1513A08
	bool IsValid(CameraEvent value) { }

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

	// RVA: 0x1513A14
	void .ctor(int indexStart, int indexCount, MeshTopology topology) { }

	// RVA: 0x1513A2C
	Bounds get_bounds() { }

	// RVA: 0x1513A40
	void set_bounds(Bounds value) { }

	// RVA: 0x1513A54
	MeshTopology get_topology() { }

	// RVA: 0x1513A5C
	void set_topology(MeshTopology value) { }

	// RVA: 0x1513A64
	int get_indexStart() { }

	// RVA: 0x1513A6C
	void set_indexStart(int value) { }

	// RVA: 0x1513A74
	int get_indexCount() { }

	// RVA: 0x1513A7C
	void set_indexCount(int value) { }

	// RVA: 0x1513A84
	int get_baseVertex() { }

	// RVA: 0x1513A8C
	void set_baseVertex(int value) { }

	// RVA: 0x1513A94
	int get_firstVertex() { }

	// RVA: 0x1513A9C
	void set_firstVertex(int value) { }

	// RVA: 0x1513AA4
	int get_vertexCount() { }

	// RVA: 0x1513AAC
	void set_vertexCount(int value) { }

	// RVA: 0x1513AB4
	string ToString() { }

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

	// RVA: 0x1513DA8
	VertexAttribute get_attribute() { }

	// RVA: 0x1513DB0
	void set_attribute(VertexAttribute value) { }

	// RVA: 0x1513DB8
	VertexAttributeFormat get_format() { }

	// RVA: 0x1513DC0
	void set_format(VertexAttributeFormat value) { }

	// RVA: 0x1513DC8
	int get_dimension() { }

	// RVA: 0x1513DD0
	void set_dimension(int value) { }

	// RVA: 0x1513DD8
	int get_stream() { }

	// RVA: 0x1513DE0
	void set_stream(int value) { }

	// RVA: 0x1513DE8
	void .ctor(VertexAttribute attribute, VertexAttributeFormat format, int dimension, int stream) { }

	// RVA: 0x1513DF4
	string ToString() { }

	// RVA: 0x1513FFC
	int GetHashCode() { }

	// RVA: 0x1514020
	bool Equals(object other) { }

	// RVA: 0x15140E0
	bool Equals(VertexAttributeDescriptor other) { }

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

	// RVA: 0x1514124
	void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x1514144
	void .ctor(int nameID) { }

	// RVA: 0x1514164
	void .ctor(Texture tex) { }

	// RVA: 0x15143FC
	void .ctor(RenderBuffer buf, int mipLevel, CubemapFace cubeFace, int depthSlice) { }

	// RVA: 0x151441C
	RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x151443C
	RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x151445C
	RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x15144A8
	RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x15144CC
	string ToString() { }

	// RVA: 0x15147D4
	int GetHashCode() { }

	// RVA: 0x151482C
	bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x15148E0
	bool Equals(object obj) { }

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

	// RVA: 0x15149E4
	bool get_lightsUseLinearIntensity() { }

	// RVA: 0x1514A24
	ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	// RVA: 0x1514A64
	RenderPipelineAsset get_currentRenderPipeline() { }

}

// Namespace: UnityEngine.Rendering
public class OnDemandRendering 
{
	// Fields
	private static int m_RenderFrameInterval; // 0x0

	// Methods

	// RVA: 0x1514B24
	int get_renderFrameInterval() { }

	// RVA: 0x1514BA0
	void GetRenderFrameInterval(out int frameInterval) { }

	// RVA: 0x1514C64
	void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public class CommandBuffer 
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1514CB4
	void SetInvertCulling(bool invertCulling) { }

	// RVA: 0x1514D1C
	IntPtr InitBuffer() { }

	// RVA: 0x1514D5C
	void ReleaseBuffer() { }

	// RVA: 0x1514DAC
	void set_name(string value) { }

	// RVA: 0x1514E14
	void Clear() { }

	// RVA: 0x1514E64
	void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x1514F74
	void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x1514FE4
	void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x1515128
	void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x151526C
	void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x1515328
	void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x15153D8
	void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	// RVA: 0x1515488
	void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0x151552C
	void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x1515624
	void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x15156F4
	void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x1515774
	void ReleaseTemporaryRT(int nameID) { }

	// RVA: 0x15157DC
	void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, UInt32 stencil) { }

	// RVA: 0x15158D4
	void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x1515A04
	void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x1515AE8
	void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x1515B48
	void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x1515C08
	void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x1515CC8
	void EnableShaderKeyword(string keyword) { }

	// RVA: 0x1515D30
	void EnableGlobalKeyword(GlobalKeyword keyword) { }

	// RVA: 0x1515DEC
	void EnableKeyword(in GlobalKeyword keyword) { }

	// RVA: 0x1515E44
	void DisableShaderKeyword(string keyword) { }

	// RVA: 0x1515EAC
	void DisableGlobalKeyword(GlobalKeyword keyword) { }

	// RVA: 0x1515F68
	void DisableKeyword(in GlobalKeyword keyword) { }

	// RVA: 0x1515FC0
	void SetViewMatrix(Matrix4x4 view) { }

	// RVA: 0x1516090
	void SetProjectionMatrix(Matrix4x4 proj) { }

	// RVA: 0x1516160
	void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	// RVA: 0x15159AC
	bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	// RVA: 0x1516210
	void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	// RVA: 0x1516278
	void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x15162E0
	void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x151640C
	void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x151638C
	void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x15164D4
	void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x1516684
	void Finalize() { }

	// RVA: 0x15167A0
	void Dispose() { }

	// RVA: 0x1516740
	void Dispose(bool disposing) { }

	// RVA: 0x1516874
	void .ctor() { }

	// RVA: 0x15168D0
	void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x1516C84
	void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x1516CB8
	void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x1516CF0
	void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	// RVA: 0x1516D2C
	void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x1517080
	void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x1517088
	void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x1517094
	void Blit(Texture source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset) { }

	// RVA: 0x151717C
	void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x151724C
	void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x1517328
	void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x15173F4
	void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x15174C4
	void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x15175A0
	void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x1517634
	void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x1517690
	void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x1514EEC
	void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x1515088
	void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x15151CC
	void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x151568C
	void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x151585C
	void ClearRenderTarget_Injected(RTClearFlags clearFlags, ref Color backgroundColor, float depth, UInt32 stencil) { }

	// RVA: 0x1515BB0
	void SetGlobalVector_Injected(int nameID, ref Vector4 value) { }

	// RVA: 0x1515C70
	void SetGlobalColor_Injected(int nameID, ref Color value) { }

	// RVA: 0x1515D84
	void EnableGlobalKeyword_Injected(ref GlobalKeyword keyword) { }

	// RVA: 0x1515F00
	void DisableGlobalKeyword_Injected(ref GlobalKeyword keyword) { }

	// RVA: 0x1516028
	void SetViewMatrix_Injected(ref Matrix4x4 view) { }

	// RVA: 0x15160F8
	void SetProjectionMatrix_Injected(ref Matrix4x4 proj) { }

	// RVA: 0x15161B8
	void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj) { }

	// RVA: 0x151656C
	void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x15165EC
	void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

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

	// RVA: 0x1517784
	float get_Item(int rgb, int coefficient) { }

	// RVA: 0x15179A4
	void set_Item(int rgb, int coefficient, float value) { }

	// RVA: 0x1517BC4
	int GetHashCode() { }

	// RVA: 0x1517DA4
	bool Equals(object other) { }

	// RVA: 0x1517E5C
	bool Equals(SphericalHarmonicsL2 other) { }

	// RVA: 0x1517F20
	bool op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

}

// Namespace: UnityEngine.Rendering
public struct BatchID 
{
	// Fields
	public static readonly BatchID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x15180DC
	int GetHashCode() { }

	// RVA: 0x15180E4
	bool Equals(object obj) { }

	// RVA: 0x15181B4
	bool Equals(BatchID other) { }

	// RVA: 0x15181C4
	void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct BatchMaterialID 
{
	// Fields
	public static readonly BatchMaterialID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x1518210
	int GetHashCode() { }

	// RVA: 0x1518218
	bool Equals(object obj) { }

	// RVA: 0x15182E8
	bool Equals(BatchMaterialID other) { }

	// RVA: 0x15182F8
	void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct BatchMeshID 
{
	// Fields
	public static readonly BatchMeshID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x1518344
	int GetHashCode() { }

	// RVA: 0x151834C
	bool Equals(object obj) { }

	// RVA: 0x151841C
	bool Equals(BatchMeshID other) { }

	// RVA: 0x151842C
	void .cctor() { }

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

	// RVA: 0x1518478
	int GetHashCode() { }

	// RVA: 0x1518480
	bool Equals(BatchPackedCullingViewID other) { }

	// RVA: 0x1518490
	bool Equals(object obj) { }

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

	// RVA: 0x1518520
	void .ctor(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, UInt64 inViewID, UInt32 inCullingLayerMask, UInt64 inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount) { }

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

	// RVA: 0x1518788
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x15188AC
	internal JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }

}

// Namespace: UnityEngine.Rendering
public class BatchRendererGroup 
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	// RVA: 0x151858C
	void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }

}

// Namespace: UnityEngine.Rendering
internal struct CoreCameraValues 
{
	// Fields
	private int filterMode; // 0x10
	private UInt32 cullingMask; // 0x14
	private int instanceID; // 0x18

	// Methods

	// RVA: 0x151890C
	bool Equals(CoreCameraValues other) { }

	// RVA: 0x1518940
	bool Equals(object obj) { }

	// RVA: 0x15189F0
	int GetHashCode() { }

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

	// RVA: 0x1518A10
	Plane GetShadowCullingPlane(int index) { }

	// RVA: 0x1518B00
	Plane GetCameraCullingPlane(int index) { }

	// RVA: 0x1518BF0
	bool Equals(CameraProperties other) { }

	// RVA: 0x1519A2C
	bool Equals(object obj) { }

	// RVA: 0x1519B04
	int GetHashCode() { }

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

	// RVA: 0x151A368
	int get_cullingPlaneCount() { }

	// RVA: 0x151A370
	void set_cullingMask(UInt32 value) { }

	// RVA: 0x151A378
	void set_cullingOptions(CullingOptions value) { }

	// RVA: 0x151A380
	float GetLayerCullingDistance(int layerIndex) { }

	// RVA: 0x151A464
	Plane GetCullingPlane(int index) { }

	// RVA: 0x151A5A4
	bool Equals(ScriptableCullingParameters other) { }

	// RVA: 0x151A9C8
	bool Equals(object obj) { }

	// RVA: 0x151AAE0
	int GetHashCode() { }

	// RVA: 0x151AD70
	void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct CullingResults 
{
	// Fields
	internal IntPtr ptr; // 0x10
	private CullingAllocationInfo* m_AllocationInfo; // 0x18

	// Methods

	// RVA: 0x151ADC4
	bool Equals(CullingResults other) { }

	// RVA: 0x151AE58
	bool Equals(object obj) { }

	// RVA: 0x151AF68
	int GetHashCode() { }

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

	// RVA: 0x151AF9C
	void .ctor(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	// RVA: 0x151B080
	ShaderTagId GetShaderPassName(int index) { }

	// RVA: 0x151B1F8
	bool Equals(DrawingSettings other) { }

	// RVA: 0x151B380
	bool Equals(object obj) { }

	// RVA: 0x151B4C8
	int GetHashCode() { }

	// RVA: 0x151B530
	void .cctor() { }

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

	// RVA: 0x151B580
	FilteringSettings get_defaultValue() { }

	// RVA: 0x151B640
	void .ctor(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, int layerMask, UInt32 renderingLayerMask, int excludeMotionVectorObjects) { }

	// RVA: 0x151B7D4
	bool Equals(FilteringSettings other) { }

	// RVA: 0x151B8C4
	bool Equals(object obj) { }

	// RVA: 0x151BA2C
	int GetHashCode() { }

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

	// RVA: 0x151BAB8
	bool Equals(LODParameters other) { }

	// RVA: 0x151BB60
	bool Equals(object obj) { }

	// RVA: 0x151BC80
	int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public class ObjectIdRequest 
{
	// Fields
	private RenderTexture <destination>k__BackingField; // 0x10

	// Methods

	// RVA: 0x151BD20
	RenderTexture get_destination() { }

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
	void Render(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x309AF8C
	void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	// RVA: 0x309AF8C
	bool IsRenderRequestSupported(Camera camera, RequestData data) { }

	// RVA: 0x151BD28
	void Render(ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x151BDA4
	void InternalRender(ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x309AF8C
	void InternalProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	// RVA: 0x151BE28
	bool get_disposed() { }

	// RVA: 0x151BE30
	void set_disposed(bool value) { }

	// RVA: 0x151BE38
	void Dispose() { }

	// RVA: 0x151BEBC
	void Dispose(bool disposing) { }

	// RVA: 0x151BEC0
	void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset 
{
	// Methods

	// RVA: 0x151BEC8
	RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x151C0D0
	string[] get_renderingLayerMaskNames() { }

	// RVA: 0x151C0D8
	string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x151C0E0
	Material get_defaultMaterial() { }

	// RVA: 0x151C0E8
	Shader get_autodeskInteractiveShader() { }

	// RVA: 0x151C0F0
	Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x151C0F8
	Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x151C100
	Shader get_terrainDetailLitShader() { }

	// RVA: 0x151C108
	Shader get_terrainDetailGrassShader() { }

	// RVA: 0x151C110
	Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x151C118
	Material get_defaultParticleMaterial() { }

	// RVA: 0x151C120
	Material get_defaultLineMaterial() { }

	// RVA: 0x151C128
	Material get_defaultTerrainMaterial() { }

	// RVA: 0x151C130
	Material get_defaultUIMaterial() { }

	// RVA: 0x151C138
	Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x151C140
	Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x151C148
	Material get_default2DMaterial() { }

	// RVA: 0x151C150
	Material get_default2DMaskMaterial() { }

	// RVA: 0x151C158
	Shader get_defaultShader() { }

	// RVA: 0x151C160
	Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x151C168
	Shader get_defaultSpeedTree8Shader() { }

	// RVA: 0x151C170
	string get_renderPipelineShaderTag() { }

	// RVA: 0x2FE360C
	RenderPipeline CreatePipeline() { }

	// RVA: 0x151C208
	void OnValidate() { }

	// RVA: 0x151C878
	void OnDisable() { }

	// RVA: 0x151C8E0
	void .ctor() { }

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

	// RVA: 0x151C8E8
	RenderPipeline get_currentPipeline() { }

	// RVA: 0x151C964
	void set_currentPipeline(RenderPipeline value) { }

	// RVA: 0x151CA3C
	void OnActiveRenderPipelineTypeChanged() { }

	// RVA: 0x151CACC
	void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	// RVA: 0x151CBF4
	void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x151C324
	void CleanupRenderPipeline() { }

	// RVA: 0x151CDC8
	string GetCurrentPipelineAssetType() { }

	// RVA: 0x151CE44
	void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, object renderRequest) { }

	// RVA: 0x151C70C
	void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x151D37C
	bool IsPipelineRequireCreation() { }

	// RVA: 0x151D564
	void .cctor() { }

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

	// RVA: 0x151D63C
	RenderQueueRange get_all() { }

	// RVA: 0x151D644
	RenderQueueRange get_transparent() { }

	// RVA: 0x151D650
	int get_lowerBound() { }

	// RVA: 0x151D658
	bool Equals(RenderQueueRange other) { }

	// RVA: 0x151D680
	bool Equals(object obj) { }

	// RVA: 0x151D760
	int GetHashCode() { }

	// RVA: 0x151D774
	void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct ScriptableRenderContext 
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x151D7C8
	void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x151D8D8
	void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings) { }

	// RVA: 0x151D940
	void Submit_Internal() { }

	// RVA: 0x151DA3C
	void GetCameras_Internal(Type listType, object resultList) { }

	// RVA: 0x151DB48
	void DrawRenderers_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x151DCEC
	void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	// RVA: 0x151DE0C
	void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x151DF30
	void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset) { }

	// RVA: 0x151D23C
	void .ctor(IntPtr ptr) { }

	// RVA: 0x151E03C
	void Submit() { }

	// RVA: 0x151D244
	void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results) { }

	// RVA: 0x151E130
	void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings) { }

	// RVA: 0x151E290
	void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	// RVA: 0x151E42C
	void SetupCameraProperties(Camera camera, bool stereoSetup) { }

	// RVA: 0x151E574
	void SetupCameraProperties(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x151E678
	void DrawGizmos(Camera camera, GizmoSubset gizmoSubset) { }

	// RVA: 0x151E774
	CullingResults Cull(ref ScriptableCullingParameters parameters) { }

	// RVA: 0x151E888
	bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x151E900
	bool Equals(object obj) { }

	// RVA: 0x151EA18
	int GetHashCode() { }

	// RVA: 0x151EA20
	void .cctor() { }

	// RVA: 0x151D880
	void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, ref ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x151D9EC
	void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x151DAF0
	void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList) { }

	// RVA: 0x151DC4C
	void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x151DDA4
	void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer) { }

	// RVA: 0x151DEC8
	void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x151DFE4
	void DrawGizmos_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, GizmoSubset gizmoSubset) { }

}

// Namespace: UnityEngine.Rendering
public struct ShaderTagId 
{
	// Fields
	public static readonly ShaderTagId none; // 0x0
	private int m_Id; // 0x10

	// Methods

	// RVA: 0x151EA94
	void .ctor(string name) { }

	// RVA: 0x151EAC0
	int get_id() { }

	// RVA: 0x151EAC8
	void set_id(int value) { }

	// RVA: 0x151EAD0
	bool Equals(object obj) { }

	// RVA: 0x151EB60
	bool Equals(ShaderTagId other) { }

	// RVA: 0x151EB70
	int GetHashCode() { }

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

	// RVA: 0x151EB94
	SortingLayerRange get_all() { }

	// RVA: 0x151EB9C
	bool Equals(SortingLayerRange other) { }

	// RVA: 0x151EBC0
	bool Equals(object obj) { }

	// RVA: 0x151EC5C
	int GetHashCode() { }

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

	// RVA: 0x151EC64
	void .ctor(Camera camera) { }

	// RVA: 0x151ED1C
	SortingCriteria get_criteria() { }

	// RVA: 0x151ED24
	void set_criteria(SortingCriteria value) { }

	// RVA: 0x151ED2C
	bool Equals(SortingSettings other) { }

	// RVA: 0x151EE1C
	bool Equals(object obj) { }

	// RVA: 0x151EF54
	int GetHashCode() { }

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

	// RVA: 0x151F01C
	void set_enabled(bool value) { }

	// RVA: 0x151F08C
	void set_readMask(Byte value) { }

	// RVA: 0x151F094
	void set_writeMask(Byte value) { }

	// RVA: 0x151F09C
	void set_compareFunctionFront(CompareFunction value) { }

	// RVA: 0x151F0A4
	void set_passOperationFront(StencilOp value) { }

	// RVA: 0x151F0AC
	void set_failOperationFront(StencilOp value) { }

	// RVA: 0x151F0B4
	void set_zFailOperationFront(StencilOp value) { }

	// RVA: 0x151F0BC
	void set_compareFunctionBack(CompareFunction value) { }

	// RVA: 0x151F0C4
	void set_passOperationBack(StencilOp value) { }

	// RVA: 0x151F0CC
	void set_failOperationBack(StencilOp value) { }

	// RVA: 0x151F0D4
	void set_zFailOperationBack(StencilOp value) { }

	// RVA: 0x151F0DC
	bool Equals(StencilState other) { }

	// RVA: 0x151F18C
	bool Equals(object obj) { }

	// RVA: 0x151F2B8
	int GetHashCode() { }

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

	// RVA: 0x151F3B4
	SupportedRenderingFeatures get_active() { }

	// RVA: 0x151CD54
	void set_active(SupportedRenderingFeatures value) { }

	// RVA: 0x151F520
	LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	// RVA: 0x151F528
	LightmapMixedBakeModes get_mixedLightingModes() { }

	// RVA: 0x151F530
	LightmapBakeType get_lightmapBakeTypes() { }

	// RVA: 0x151F538
	LightmapsMode get_lightmapsModes() { }

	// RVA: 0x151F540
	bool get_enlightenLightmapper() { }

	// RVA: 0x151F548
	bool get_enlighten() { }

	// RVA: 0x151F550
	bool get_rendersUIOverlay() { }

	// RVA: 0x151F558
	bool get_autoAmbientProbeBaking() { }

	// RVA: 0x151F560
	bool get_autoDefaultReflectionProbeBaking() { }

	// RVA: 0x151F568
	bool get_overridesLightProbeSystem() { }

	// RVA: 0x151F570
	void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x151F784
	bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	// RVA: 0x151F7FC
	void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x151F9B8
	bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	// RVA: 0x151FA30
	void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	// RVA: 0x151FBFC
	void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	// RVA: 0x151FC88
	void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	// RVA: 0x151FD28
	void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	// RVA: 0x151FDA8
	void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0x151FE28
	void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0x151FEA8
	void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	// RVA: 0x151FF28
	void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x151CCB8
	void .ctor() { }

	// RVA: 0x151FF48
	void .cctor() { }

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

	// RVA: 0x1520030
	bool Equals(VisibleLight other) { }

	// RVA: 0x15201F0
	bool Equals(object obj) { }

	// RVA: 0x15202B0
	int GetHashCode() { }

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

	// RVA: 0x15203B8
	bool Equals(VisibleReflectionProbe other) { }

	// RVA: 0x1520560
	bool Equals(object obj) { }

	// RVA: 0x1520620
	int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public struct GlobalKeyword 
{
	// Fields
	internal readonly string m_Name; // 0x10
	internal readonly UInt32 m_Index; // 0x18

	// Methods

	// RVA: 0x15207DC
	UInt32 GetGlobalKeywordCount() { }

	// RVA: 0x152081C
	UInt32 GetGlobalKeywordIndex(string keyword) { }

	// RVA: 0x152086C
	void .ctor(string name) { }

	// RVA: 0x15209DC
	string ToString() { }

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

	// RVA: 0x15209E4
	UInt32 GetGlobalKeywordCount() { }

	// RVA: 0x1520A24
	UInt32 GetGlobalKeywordIndex(string keyword) { }

	// RVA: 0x1520A74
	void CreateGlobalKeyword(string keyword) { }

	// RVA: 0x1520AC4
	void .ctor(string keywordName) { }

	// RVA: 0x1520BD4
	string ToString() { }

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

	// RVA: 0x309AF8C
	void OnNotify(Playable origin, INotification notification, object context) { }

}

// Namespace: UnityEngine.Playables
public interface IPlayableBehaviour 
{
	// Methods

	// RVA: 0x309AF8C
	void OnGraphStart(Playable playable) { }

	// RVA: 0x309AF8C
	void OnGraphStop(Playable playable) { }

	// RVA: 0x309AF8C
	void OnPlayableCreate(Playable playable) { }

	// RVA: 0x309AF8C
	void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x309AF8C
	void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x309AF8C
	void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x309AF8C
	void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x309AF8C
	void ProcessFrame(Playable playable, FrameData info, object playerData) { }

}

// Namespace: UnityEngine.Playables
public struct Playable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly Playable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1520BDC
	Playable get_Null() { }

	// RVA: 0x1520C58
	void .ctor(PlayableHandle handle) { }

	// RVA: 0x1520C60
	PlayableHandle GetHandle() { }

	// RVA: 0x1520C6C
	bool Equals(Playable other) { }

	// RVA: 0x1520E10
	void .cctor() { }

}

// Namespace: UnityEngine.Playables
public abstract class PlayableAsset 
{
	// Methods

	// RVA: -1
	Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1520F68
	Double get_duration() { }

	// RVA: 0x1520FE4
	System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }

	// RVA: 0x1521060
	void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	// RVA: 0x15211B8
	void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x15211EC
	void .ctor() { }

}

// Namespace: UnityEngine.Playables
public abstract class PlayableBehaviour 
{
	// Methods

	// RVA: 0x15211F4
	void .ctor() { }

	// RVA: 0x15211FC
	void OnGraphStart(Playable playable) { }

	// RVA: 0x1521200
	void OnGraphStop(Playable playable) { }

	// RVA: 0x1521204
	void OnPlayableCreate(Playable playable) { }

	// RVA: 0x1521208
	void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x152120C
	void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1521210
	void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1521214
	void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1521218
	void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x152121C
	object Clone() { }

}

// Namespace: 
internal sealed class CreateOutputMethod 
{
	// Methods

	// RVA: 0x15212B8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x152135C
	internal PlayableOutput Invoke(PlayableGraph graph, string name) { }

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

	// RVA: 0x1521224
	void .cctor() { }

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

	// RVA: 0x2FE3054
	bool IsPlayableOfType() { }

	// RVA: 0x1520EEC
	PlayableHandle get_Null() { }

	// RVA: 0x1520D88
	bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x15213A4
	bool Equals(object p) { }

	// RVA: 0x15214C0
	bool Equals(PlayableHandle other) { }

	// RVA: 0x1521548
	int GetHashCode() { }

	// RVA: 0x1521370
	bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	// RVA: 0x1521580
	bool IsValid() { }

	// RVA: 0x152167C
	Type GetPlayableType() { }

	// RVA: 0x1521778
	void .cctor() { }

	// RVA: 0x152162C
	bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x1521728
	Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

}

// Namespace: UnityEngine.Playables
public struct PlayableOutput 
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Methods

	// RVA: 0x15217C4
	void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x15217CC
	PlayableOutputHandle GetHandle() { }

	// RVA: 0x15217D8
	bool Equals(PlayableOutput other) { }

	// RVA: 0x152197C
	void .cctor() { }

}

// Namespace: UnityEngine.Playables
public struct PlayableOutputHandle 
{
	// Fields
	internal IntPtr m_Handle; // 0x10
	internal UInt32 m_Version; // 0x18
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Methods

	// RVA: 0x1521A58
	PlayableOutputHandle get_Null() { }

	// RVA: 0x1521AD4
	int GetHashCode() { }

	// RVA: 0x15218F4
	bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x1521B40
	bool Equals(object p) { }

	// RVA: 0x1521C5C
	bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x1521B0C
	bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x1521CE4
	void .cctor() { }

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

	// RVA: 0x1521D30
	float get_red() { }

	// RVA: 0x1521D38
	void set_red(float value) { }

	// RVA: 0x1521DEC
	float get_green() { }

	// RVA: 0x1521DF4
	void set_green(float value) { }

	// RVA: 0x1521EA8
	float get_blue() { }

	// RVA: 0x1521EB0
	void set_blue(float value) { }

	// RVA: 0x1521F64
	LinearColor Convert(Color color, float intensity) { }

	// RVA: 0x1522214
	LinearColor Black() { }

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

	// RVA: 0x1522228
	void Init(ref DirectionalLight light, ref Cookie cookie) { }

	// RVA: 0x1522298
	void Init(ref PointLight light, ref Cookie cookie) { }

	// RVA: 0x1522310
	void Init(ref SpotLight light, ref Cookie cookie) { }

	// RVA: 0x152238C
	void Init(ref RectangleLight light, ref Cookie cookie) { }

	// RVA: 0x1522400
	void Init(ref DiscLight light, ref Cookie cookie) { }

	// RVA: 0x1522478
	void InitNoBake(int lightInstanceID) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils 
{
	// Methods

	// RVA: 0x1522488
	LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x15224A0
	LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x1522524
	float ExtractInnerCone(Light l) { }

	// RVA: 0x1522580
	Color ExtractColorTemperature(Light l) { }

	// RVA: 0x1522610
	void ApplyColorTemperature(Color cct, ref LinearColor lightColor) { }

	// RVA: 0x1522664
	void Extract(Light l, ref DirectionalLight dir) { }

	// RVA: 0x15228B8
	void Extract(Light l, ref PointLight point) { }

	// RVA: 0x1522B24
	void Extract(Light l, ref SpotLight spot) { }

	// RVA: 0x1522DF0
	void Extract(Light l, ref RectangleLight rect) { }

	// RVA: 0x152305C
	void Extract(Light l, ref DiscLight disc) { }

	// RVA: 0x15232C8
	void Extract(Light l, out Cookie cookie) { }

}

// Namespace: 
public sealed class RequestLightsDelegate 
{
	// Methods

	// RVA: 0x1523814
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x15238D0
	internal void Invoke(Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15238E4
	void .cctor() { }

	// RVA: 0x1523950
	void .ctor() { }

	// RVA: 0x1523958
	void <.cctor>b__7_0(Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping 
{
	// Fields
	private static readonly RequestLightsDelegate s_DefaultDelegate; // 0x0
	private static RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	// RVA: 0x1523424
	void SetDelegate(RequestLightsDelegate del) { }

	// RVA: 0x15234D4
	RequestLightsDelegate GetDelegate() { }

	// RVA: 0x1523550
	void ResetDelegate() { }

	// RVA: 0x15235D4
	void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x15236A4
	void .cctor() { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct CameraPlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x1523DF4
	PlayableHandle GetHandle() { }

	// RVA: 0x1523E00
	bool Equals(CameraPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct MaterialEffectPlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x1523EE4
	PlayableHandle GetHandle() { }

	// RVA: 0x1523EF0
	bool Equals(MaterialEffectPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct TextureMixerPlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x1523FD4
	PlayableHandle GetHandle() { }

	// RVA: 0x1523FE0
	bool Equals(TextureMixerPlayable other) { }

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

	// RVA: 0x15240C4
	bool TickRealtimeProbes() { }

	// RVA: 0x1524144
	void Dispose() { }

	// RVA: 0x1524148
	void Dispose(bool disposing) { }

	// RVA: 0x1524104
	bool BuiltinUpdate() { }

	// RVA: 0x152414C
	BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	// RVA: 0x15241A4
	void .ctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
public interface IScriptableRuntimeReflectionSystem 
{
	// Methods

	// RVA: 0x2FE3054
	bool TickRealtimeProbes() { }

}

// Namespace: UnityEngine.Experimental.Rendering
public static class ScriptableRuntimeReflectionSystemSettings 
{
	// Fields
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; // 0x0

	// Methods

	// RVA: 0x15241AC
	void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0x1524320
	ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	// RVA: 0x152439C
	void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0x15243DC
	void .cctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
internal class ScriptableRuntimeReflectionSystemWrapper 
{
	// Fields
	private IScriptableRuntimeReflectionSystem <implementation>k__BackingField; // 0x10

	// Methods

	// RVA: 0x152446C
	IScriptableRuntimeReflectionSystem get_implementation() { }

	// RVA: 0x1524474
	void set_implementation(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0x152447C
	void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result) { }

	// RVA: 0x1524464
	void .ctor() { }

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

	// RVA: 0x1524550
	GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x1524608
	GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x1524670
	GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x1524728
	GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x1524790
	GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x15248B0
	GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	// RVA: 0x1524900
	GraphicsFormat GetDepthStencilFormat(int minimumDepthBits) { }

	// RVA: 0x15249AC
	int GetDepthBits(GraphicsFormat format) { }

	// RVA: 0x15249FC
	GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	// RVA: 0x1524C2C
	bool IsSRGBFormat(GraphicsFormat format) { }

	// RVA: 0x1524C7C
	GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	// RVA: 0x1524CCC
	GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	// RVA: 0x1524D1C
	RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	// RVA: 0x1524D6C
	bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	// RVA: 0x1524DBC
	bool IsCompressedFormat(TextureFormat format) { }

	// RVA: 0x1524E68
	bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	// RVA: 0x1524ED0
	bool CanDecompressFormat(GraphicsFormat format) { }

	// RVA: 0x1524F84
	bool IsDepthStencilFormat(GraphicsFormat format) { }

	// RVA: 0x1524FD4
	bool IsPVRTCFormat(GraphicsFormat format) { }

	// RVA: 0x1525024
	bool IsCrunchFormat(TextureFormat format) { }

	// RVA: 0x1525074
	void .cctor() { }

}

// Namespace: UnityEngine.Assertions
public static class Assert 
{
	// Fields
	public static bool raiseExceptions; // 0x0

	// Methods

	// RVA: 0x1525164
	void Fail(string message, string userMessage) { }

	// RVA: 0x1525340
	void IsTrue(bool condition) { }

	// RVA: 0x1525424
	void IsTrue(bool condition, string message) { }

	// RVA: 0x1525584
	void IsFalse(bool condition, string message) { }

	// RVA: 0x309AF8C
	void AreEqual(T expected, T actual) { }

	// RVA: 0x309AF8C
	void AreEqual(T expected, T actual, string message) { }

	// RVA: 0x309AF8C
	void AreEqual(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer) { }

	// RVA: 0x1525628
	void AreEqual(object expected, object actual, string message) { }

	// RVA: 0x309AF8C
	void IsNull(T value) { }

	// RVA: 0x309AF8C
	void IsNull(T value, string message) { }

	// RVA: 0x1525948
	void IsNull(object value, string message) { }

	// RVA: 0x309AF8C
	void IsNotNull(T value) { }

	// RVA: 0x309AF8C
	void IsNotNull(T value, string message) { }

	// RVA: 0x1525BBC
	void IsNotNull(object value, string message) { }

	// RVA: 0x1525CB0
	void AreEqual(int expected, int actual) { }

	// RVA: 0x1525D68
	void .cctor() { }

}

// Namespace: UnityEngine.Assertions
public class AssertionException 
{
	// Fields
	private string m_UserMessage; // 0x90

	// Methods

	// RVA: 0x15252B8
	void .ctor(string message, string userMessage) { }

	// RVA: 0x1525DB8
	string get_Message() { }

}

// Namespace: UnityEngine.Assertions
internal class AssertionMessageUtil 
{
	// Methods

	// RVA: 0x1525E2C
	string GetMessage(string failureMessage) { }

	// RVA: 0x1525F38
	string GetMessage(string failureMessage, string expected) { }

	// RVA: 0x152571C
	string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	// RVA: 0x1525A3C
	string NullFailureMessage(object value, bool expectNull) { }

	// RVA: 0x15254C8
	string BooleanFailureMessage(bool expected) { }

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


