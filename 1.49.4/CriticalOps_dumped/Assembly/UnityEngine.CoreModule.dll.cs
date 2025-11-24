// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x159FA64
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsUnmanagedAttribute
{
	// Methods

	// RVA: 0x159FA6C
	public void .ctor() { }

}

// Namespace: AOT
public class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0x159FA74
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

	// RVA: 0x159FA7C
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

	// RVA: 0x159FAE8
	public void .ctor(TypeInferenceRules rule) { }

	// RVA: 0x159FB7C
	public void .ctor(string rule) { }

	// RVA: 0x159FBB0
	public override string ToString() { }

}

// Namespace: UnityEngineInternal
public class GenericStack
{
	// Methods

	// RVA: 0x159FBB8
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

	// RVA: 0x30A6D04
	internal static void Initialize() { }

	// RVA: 0x30A8B1C
	public static void Execute(T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex) { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: Unity.Jobs
public static class IJobExtensions
{
	// Methods

	// RVA: 0x30A6D04
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

	// RVA: 0x30A6D04
	internal static void Initialize() { }

	// RVA: 0x30A8B1C
	public static void Execute(T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex) { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: Unity.Jobs
public static class IJobParallelForExtensions
{
	// Methods

	// RVA: 0x30A4E40
	private static IntPtr GetReflectionData() { }

	// RVA: 0x315B3A8
	public static JobHandle Schedule(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }

}

// Namespace: Unity.Jobs
public struct JobHandle
{
	// Fields
	internal UInt64 jobGroup; // 0x10
	internal int version; // 0x18

	// Methods

	// RVA: 0x159FBC0
	public void Complete() { }

	// RVA: 0x159FC74
	public static void ScheduleBatchedJobs() { }

	// RVA: 0x159FC24
	private static void ScheduleBatchedJobsAndComplete(JobHandle job) { }

	// RVA: 0x159FCB4
	public static JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs) { }

	// RVA: 0x159FDC0
	public static JobHandle CombineDependencies(Unity.Collections.NativeSlice<Unity.Jobs.JobHandle> jobs) { }

	// RVA: 0x159FD58
	internal static JobHandle CombineDependenciesInternalPtr(Void* jobs, int count) { }

	// RVA: 0x159FEEC
	public bool Equals(JobHandle other) { }

	// RVA: 0x159FE94
	private static void CombineDependenciesInternalPtr_Injected(Void* jobs, int count, JobHandle ret) { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public sealed class JobProducerTypeAttribute
{
	// Fields
	private readonly Type <ProducerType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x159FEFC
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

	// RVA: 0x15A01B4
	public void .ctor(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

// Namespace: 
internal sealed class PanicFunction_
{
	// Methods

	// RVA: 0x15A01F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15A0298
	public virtual void Invoke() { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public static class JobsUtility
{
	// Fields
	internal static PanicFunction_ PanicFunction; // 0x0

	// Methods

	// RVA: 0x159FF30
	public static bool GetWorkStealingRange(JobRanges ranges, int jobIndex, int beginIndex, int endIndex) { }

	// RVA: 0x159FF98
	public static JobHandle ScheduleParallelFor(JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	// RVA: 0x15A0070
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x15A00E0
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x15A014C
	private static void InvokePanicFunction() { }

	// RVA: 0x15A0008
	private static void ScheduleParallelFor_Injected(JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, JobHandle ret) { }

}

// Namespace: Unity.IL2CPP.CompilerServices
internal class Il2CppEagerStaticClassConstructionAttribute
{
	// Methods

	// RVA: 0x15A02AC
	public void .ctor() { }

}

// Namespace: Unity.Profiling
public sealed class IgnoredByDeepProfilerAttribute
{
	// Methods

	// RVA: 0x15A02B4
	public void .ctor() { }

}

// Namespace: Unity.Profiling
public struct ProfilerCategory
{
	// Fields
	private readonly UInt16 m_CategoryId; // 0x10

	// Methods

	// RVA: 0x15A02BC
	internal void .ctor(UInt16 category) { }

	// RVA: 0x15A02C4
	public string get_Name() { }

	// RVA: 0x15A04E0
	public override string ToString() { }

	// RVA: 0x15A0570
	public static ProfilerCategory get_Scripts() { }

	// RVA: 0x15A0578
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

	// RVA: 0x15A0848
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x15A08BC
	public void Dispose() { }

}

// Namespace: Unity.Profiling
public struct ProfilerMarker
{
	// Fields
	internal readonly IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15A0580
	public void .ctor(string name) { }

	// RVA: 0x15A0648
	public void .ctor(ProfilerCategory category, string name) { }

	// RVA: 0x15A06AC
	public void Begin() { }

	// RVA: 0x15A074C
	public void End() { }

	// RVA: 0x15A07EC
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

	// RVA: 0x15A0930
	public void set_RawImageDataReference(Unity.Collections.NativeArray<System.Byte> value) { }

	// RVA: 0x15A0938
	public void set_ImageFormat(TextureFormat value) { }

	// RVA: 0x15A0940
	public void set_Width(int value) { }

	// RVA: 0x15A0948
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

	// RVA: 0x15A0950
	internal static UInt16 CreateCategory__Unmanaged(Byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	// RVA: 0x15A0354
	public static ProfilerCategoryDescription GetCategoryDescription(UInt16 categoryId) { }

	// RVA: 0x15A05E0
	public static IntPtr CreateMarker(string name, UInt16 categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x15A0A10
	internal static IntPtr CreateMarker__Unmanaged(Byte* name, int nameLen, UInt16 categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x15A0A80
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, Byte* name, int nameLen, Byte type, Byte unit) { }

	// RVA: 0x15A06FC
	public static void BeginSample(IntPtr markerPtr) { }

	// RVA: 0x15A079C
	public static void EndSample(IntPtr markerPtr) { }

	// RVA: 0x15A0B00
	internal static Void* CreateCounterValue__Unmanaged(IntPtr counterPtr, Byte* name, int nameLen, UInt16 categoryId, MarkerFlags flags, Byte dataType, Byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	// RVA: 0x15A03F4
	internal static string Utf8ToString(Byte* chars, int charsLen) { }

	// RVA: 0x15A09A8
	private static void GetCategoryDescription_Injected(UInt16 categoryId, ProfilerCategoryDescription ret) { }

}

// Namespace: Unity.Profiling.Memory
public class MemorySnapshotMetadata
{
	// Fields
	private string <Description>k__BackingField; // 0x10
	private Byte[] <Data>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15A0BA0
	public string get_Description() { }

	// RVA: 0x15A0BA8
	public void set_Description(string value) { }

	// RVA: 0x15A0BB0
	internal Byte[] get_Data() { }

	// RVA: 0x15A0BB8
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

	// RVA: 0x15A0BC0
	private static Byte[] PrepareMetadata() { }

	// RVA: 0x15A0EC0
	internal static int WriteIntToByteArray(Byte[] array, int offset, int value) { }

	// RVA: 0x15A0F58
	internal static int WriteStringToByteArray(Byte[] array, int offset, string value) { }

	// RVA: 0x15A105C
	private static void FinalizeSnapshot(string path, bool result) { }

	// RVA: 0x15A10F4
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

	// RVA: 0x30A27C0
	public void .ctor(Unity.Collections.NativeArray<T>& array) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x315B3A8
	public T get_Current() { }

	// RVA: 0x30A17DC
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

	// RVA: 0x30A27C0
	public void .ctor(ReadOnly array) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x315B3A8
	public T get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct ReadOnly
{
	// Fields
	internal Void* m_Buffer; // 0x0
	internal int m_Length; // 0x0

	// Methods

	// RVA: 0x315B3A8
	internal void .ctor(Void* buffer, int length) { }

	// RVA: 0x30A14A4
	public int get_Length() { }

	// RVA: 0x315B3A8
	public T get_Item(int index) { }

	// RVA: 0x315B3A8
	public Enumerator GetEnumerator() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A2828
	public void .ctor(T[] array, Allocator allocator) { }

	// RVA: -1
	private static void Allocate(int length, Allocator allocator, Unity.Collections.NativeArray<T>& array) { }

	// RVA: 0x30A14A4
	public int get_Length() { }

	// RVA: 0x315B3A8
	public T get_Item(int index) { }

	// RVA: 0x315B3A8
	public void set_Item(int index, T value) { }

	// RVA: 0x30A1224
	public bool get_IsCreated() { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x315B3A8
	public void CopyFrom(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x30A17DC
	public T[] ToArray() { }

	// RVA: 0x315B3A8
	public Enumerator GetEnumerator() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	public bool Equals(Unity.Collections.NativeArray<T> other) { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

	// RVA: 0x315B3A8
	public static void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst) { }

	// RVA: 0x315B3A8
	public static void Copy(T[] src, Unity.Collections.NativeArray<T> dst) { }

	// RVA: 0x315B3A8
	public static void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length) { }

	// RVA: 0x315B3A8
	public static void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x315B3A8
	public static void Copy(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x315B3A8
	private static void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x315B3A8
	private static void CopySafe(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x315B3A8
	private static void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	// RVA: 0x315B3A8
	public ReadOnly AsReadOnly() { }

}

// Namespace: Unity.Collections
internal struct NativeArrayDispose
{
	// Fields
	internal Void* m_Buffer; // 0x10
	internal Allocator m_AllocatorLabel; // 0x18

	// Methods

	// RVA: 0x15A1204
	public void Dispose() { }

}

// Namespace: Unity.Collections
internal struct NativeArrayDisposeJob
{
	// Fields
	internal NativeArrayDispose Data; // 0x10

	// Methods

	// RVA: 0x15A12D4
	public void Execute() { }

	// RVA: 0x15A133C
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

	// RVA: 0x315B3A8
	public static Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeArray<T> thisArray, int start, int length) { }

	// RVA: 0x315B3A8
	public static Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeSlice<T> thisSlice, int start, int length) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Unity.Collections.NativeSlice<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(Unity.Collections.NativeSlice<T>& array) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x30A2378
	public void Reset() { }

	// RVA: 0x315B3A8
	public T get_Current() { }

	// RVA: 0x30A17DC
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

	// RVA: 0x315B3A8
	public void .ctor(Unity.Collections.NativeSlice<T> slice, int start, int length) { }

	// RVA: 0x315B3A8
	public void .ctor(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x315B3A8
	public static Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x315B3A8
	public void .ctor(Unity.Collections.NativeArray<T> array, int start, int length) { }

	// RVA: 0x315B3A8
	public T get_Item(int index) { }

	// RVA: 0x315B3A8
	public void set_Item(int index, T value) { }

	// RVA: 0x315B3A8
	public void CopyFrom(Unity.Collections.NativeSlice<T> slice) { }

	// RVA: 0x30A27C0
	public void CopyFrom(T[] array) { }

	// RVA: 0x30A14A4
	public int get_Stride() { }

	// RVA: 0x30A14A4
	public int get_Length() { }

	// RVA: 0x315B3A8
	public Enumerator GetEnumerator() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	public bool Equals(Unity.Collections.NativeSlice<T> other) { }

	// RVA: 0x30A1344
	public override bool Equals(object obj) { }

	// RVA: 0x30A14A4
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

	// RVA: 0x315B3A8
	private void .ctor(Void* buffer) { }

	// RVA: 0x30A17DC
	public T get_Data() { }

	// RVA: 0x315B3A8
	public static Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate(UInt32 alignment) { }

}

// Namespace: 
internal static class SharedStatic
{
	// Methods

	// RVA: 0x15A1380
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstRuntime
{
	// Methods

	// RVA: 0x30A4C30
	public static Int64 GetHashCode64() { }

	// RVA: 0x15A1458
	internal static Int64 HashStringWithFNV1A64(string text) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerAttribute
{
	// Methods

	// RVA: 0x15A14E8
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsReadOnlyAttribute
{
	// Methods

	// RVA: 0x15A14F0
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsAtomicWriteOnlyAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute
{
	// Methods

	// RVA: 0x15A14F8
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute
{
	// Methods

	// RVA: 0x15A1500
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeferredConvertListToArray
{
	// Methods

	// RVA: 0x15A1508
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

	// RVA: 0x15A1510
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableUnsafePtrRestrictionAttribute
{
	// Methods

	// RVA: 0x15A1518
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableContainerSafetyRestrictionAttribute
{
	// Methods

	// RVA: 0x15A1520
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeSetClassTypeToNullOnScheduleAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeArrayUnsafeUtility
{
	// Methods

	// RVA: 0x315B3A8
	public static Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, Allocator allocator) { }

	// RVA: 0x315B3A8
	public static Void* GetUnsafePtr(Unity.Collections.NativeArray<T> nativeArray) { }

	// RVA: 0x315B3A8
	public static Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeArray<T> nativeArray) { }

	// RVA: 0x315B3A8
	public static Void* GetUnsafeBufferPointerWithoutChecks(Unity.Collections.NativeArray<T> nativeArray) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeSliceUnsafeUtility
{
	// Methods

	// RVA: 0x315B3A8
	public static Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice(Void* dataPointer, int stride, int length) { }

	// RVA: 0x315B3A8
	public static Void* GetUnsafePtr(Unity.Collections.NativeSlice<T> nativeSlice) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x15A1528
	public static Void* MallocTracked(Int64 size, int alignment, Allocator allocator, int callstacksToSkip) { }

	// RVA: 0x15A126C
	public static void FreeTracked(Void* memory, Allocator allocator) { }

	// RVA: 0x15A1590
	public static Void* Malloc(Int64 size, int alignment, Allocator allocator) { }

	// RVA: 0x15A15E8
	public static void Free(Void* memory, Allocator allocator) { }

	// RVA: 0x15A1004
	public static void MemCpy(Void* destination, Void* source, Int64 size) { }

	// RVA: 0x15A1650
	public static void MemCpyStride(Void* destination, int destinationStride, Void* source, int sourceStride, int elementSize, int count) { }

	// RVA: 0x15A16D0
	public static void MemMove(Void* destination, Void* source, Int64 size) { }

	// RVA: 0x15A1728
	public static void MemSet(Void* destination, Byte value, Int64 size) { }

	// RVA: 0x15A1780
	public static void MemClear(Void* destination, Int64 size) { }

	// RVA: 0x15A17D4
	public static int MemCmp(Void* ptr1, Void* ptr2, Int64 size) { }

	// RVA: 0x15A182C
	public static bool IsBlittable(Type type) { }

	// RVA: 0x15A187C
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x15A18EC
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x15A1B08
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: 0x15A1B98
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: 0x30A3FD0
	public static int AlignOf() { }

	// RVA: 0x315B3A8
	public static T ReadArrayElement(Void* source, int index) { }

	// RVA: 0x315B3A8
	public static T ReadArrayElementWithStride(Void* source, int index, int stride) { }

	// RVA: 0x315B3A8
	public static void WriteArrayElement(Void* destination, int index, T value) { }

	// RVA: 0x315B3A8
	public static void WriteArrayElementWithStride(Void* destination, int index, int stride, T value) { }

	// RVA: 0x315B3A8
	public static Void* AddressOf(T output) { }

	// RVA: 0x30A3FD0
	public static int SizeOf() { }

	// RVA: 0x30A52D0
	public static T As(U from) { }

	// RVA: 0x315B3A8
	public static T AsRef(Void* ptr) { }

	// RVA: 0x315B3A8
	public static int EnumToInt(T enumValue) { }

	// RVA: 0x30A8E44
	private static void InternalEnumToInt(T enumValue, int intValue) { }

	// RVA: 0x315B3A8
	public static bool EnumEquals(T lhs, T rhs) { }

}

// Namespace: Unity.Burst
public class BurstDiscardAttribute
{
	// Methods

	// RVA: 0x15A1BF0
	public void .ctor() { }

}

// Namespace: Unity.Burst.LowLevel
internal static class BurstCompilerService
{
	// Methods

	// RVA: 0x15A1400
	public static Void* GetOrCreateSharedMemory(Hash128 key, UInt32 size_of, UInt32 alignment) { }

}

// Namespace: JetBrains.Annotations
public sealed class CanBeNullAttribute
{
	// Methods

	// RVA: 0x15A1BF8
	public void .ctor() { }

}

// Namespace: JetBrains.Annotations
public sealed class NotNullAttribute
{
	// Methods

	// RVA: 0x15A1C00
	public void .ctor() { }

}

// Namespace: JetBrains.Annotations
public sealed class PureAttribute
{
	// Methods

	// RVA: 0x15A1C08
	public void .ctor() { }

}

// Namespace: UnityEngine
public struct SortingLayer
{
	// Fields
	private int m_Id; // 0x10

	// Methods

	// RVA: 0x15A1C10
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

	// RVA: 0x15A1C60
	public void .ctor(float time, float value) { }

	// RVA: 0x15A1C70
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x15A1C84
	public float get_time() { }

	// RVA: 0x15A1C8C
	public float get_value() { }

	// RVA: 0x15A1C94
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

	// RVA: 0x15A1C9C
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x15A1CEC
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	// RVA: 0x15A1D3C
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x15A1DA4
	protected override void Finalize() { }

	// RVA: 0x15A1E5C
	public float Evaluate(float time) { }

	// RVA: 0x15A1EC4
	public Keyframe[] get_keys() { }

	// RVA: 0x15A1F14
	private Keyframe[] GetKeys() { }

	// RVA: 0x15A1F64
	public override int GetHashCode() { }

	// RVA: 0x15A1FB4
	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	// RVA: 0x15A1FC4
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x15A216C
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x15A2110
	public void .ctor(Keyframe[] keys) { }

	// RVA: 0x15A22A4
	public void .ctor() { }

	// RVA: 0x15A230C
	public override bool Equals(object o) { }

	// RVA: 0x15A24D8
	public bool Equals(AnimationCurve other) { }

}

// Namespace: 
public sealed class LowMemoryCallback
{
	// Methods

	// RVA: 0x15A45F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15A4694
	public virtual void Invoke() { }

}

// Namespace: 
public sealed class MemoryUsageChangedCallback
{
	// Methods

	// RVA: 0x15A46A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15A475C
	public virtual void Invoke(ApplicationMemoryUsageChange usage) { }

}

// Namespace: 
public sealed class LogCallback
{
	// Methods

	// RVA: 0x15A4770
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15A482C
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

	// RVA: 0x15A25C8
	public static void Quit(int exitCode) { }

	// RVA: 0x15A2618
	public static void Quit() { }

	// RVA: 0x15A26B4
	public static bool get_isPlaying() { }

	// RVA: 0x15A26F4
	public static bool get_isFocused() { }

	// RVA: 0x15A2734
	public static string get_buildGUID() { }

	// RVA: 0x15A2774
	public static bool get_runInBackground() { }

	// RVA: 0x15A27B4
	public static bool get_isBatchMode() { }

	// RVA: 0x15A27F4
	public static string get_dataPath() { }

	// RVA: 0x15A2834
	public static string get_streamingAssetsPath() { }

	// RVA: 0x15A2874
	public static string get_persistentDataPath() { }

	// RVA: 0x15A28B4
	public static string get_temporaryCachePath() { }

	// RVA: 0x15A28F4
	public static string get_unityVersion() { }

	// RVA: 0x15A2934
	public static string get_version() { }

	// RVA: 0x15A2974
	public static string get_installerName() { }

	// RVA: 0x15A29B4
	public static string get_identifier() { }

	// RVA: 0x15A29F4
	public static ApplicationInstallMode get_installMode() { }

	// RVA: 0x15A2A34
	public static ApplicationSandboxType get_sandboxType() { }

	// RVA: 0x15A2A74
	public static string get_cloudProjectId() { }

	// RVA: 0x15A2AB4
	public static void OpenURL(string url) { }

	// RVA: 0x15A2B04
	public static int get_targetFrameRate() { }

	// RVA: 0x15A2B44
	public static void set_targetFrameRate(int value) { }

	// RVA: 0x15A2B94
	private static void SetLogCallbackDefined(bool defined) { }

	// RVA: 0x15A2BE4
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	// RVA: 0x15A2C34
	public static RuntimePlatform get_platform() { }

	// RVA: 0x15A2C74
	public static SystemLanguage get_systemLanguage() { }

	// RVA: 0x15A2CB4
	public static NetworkReachability get_internetReachability() { }

	// RVA: 0x15A2CF4
	public static void add_lowMemory(LowMemoryCallback value) { }

	// RVA: 0x15A2DE0
	public static void remove_lowMemory(LowMemoryCallback value) { }

	// RVA: 0x15A2ECC
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	// RVA: 0x15A3030
	internal static bool HasLogCallback() { }

	// RVA: 0x15A30F0
	public static void add_logMessageReceived(LogCallback value) { }

	// RVA: 0x15A3210
	public static void remove_logMessageReceived(LogCallback value) { }

	// RVA: 0x15A32F4
	public static void add_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0x15A3414
	public static void remove_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0x15A34F8
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	// RVA: 0x15A3600
	public static void add_focusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x15A3714
	public static void remove_focusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x15A3828
	public static void add_quitting(Action value) { }

	// RVA: 0x15A3918
	public static void remove_quitting(Action value) { }

	// RVA: 0x15A3A08
	private static bool Internal_ApplicationWantsToQuit() { }

	// RVA: 0x15A3D8C
	private static void Internal_ApplicationInit() { }

	// RVA: 0x15A3E1C
	private static void Internal_ApplicationQuit() { }

	// RVA: 0x15A3EE8
	private static void Internal_ApplicationUnload() { }

	// RVA: 0x15A3F98
	internal static void InvokeOnBeforeRender() { }

	// RVA: 0x15A41D0
	internal static void InvokeFocusChanged(bool focus) { }

	// RVA: 0x15A42A8
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x15A436C
	public static void RegisterLogCallback(LogCallback handler) { }

	// RVA: 0x15A43F4
	private static void RegisterLogCallback(LogCallback handler, bool threaded) { }

	// RVA: 0x15A456C
	public static bool get_isEditor() { }

	// RVA: 0x15A4574
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

	// RVA: 0x15A4840
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

	// RVA: 0x15A3028
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

	// RVA: 0x15A4848
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

	// RVA: 0x15A48AC
	private void .ctor(IntPtr nativeHandle) { }

}

// Namespace: UnityEngine
public sealed class Caching
{
	// Methods

	// RVA: 0x15A4934
	public static bool get_ready() { }

	// RVA: 0x15A4974
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

	// RVA: 0x15AB2E8
	public GateFitMode get_mode() { }

	// RVA: 0x15AB2F0
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

	// RVA: 0x15AB2F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15AB3AC
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

	// RVA: 0x15A49C4
	public void .ctor() { }

	// RVA: 0x15A49CC
	public float get_nearClipPlane() { }

	// RVA: 0x15A4A1C
	public void set_nearClipPlane(float value) { }

	// RVA: 0x15A4A84
	public float get_farClipPlane() { }

	// RVA: 0x15A4AD4
	public void set_farClipPlane(float value) { }

	// RVA: 0x15A4B3C
	public float get_fieldOfView() { }

	// RVA: 0x15A4B8C
	public void set_fieldOfView(float value) { }

	// RVA: 0x15A4BF4
	public RenderingPath get_renderingPath() { }

	// RVA: 0x15A4C44
	public void set_renderingPath(RenderingPath value) { }

	// RVA: 0x15A4CAC
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x15A4CFC
	public void Reset() { }

	// RVA: 0x15A4D4C
	public bool get_allowHDR() { }

	// RVA: 0x15A4D9C
	public void set_allowHDR(bool value) { }

	// RVA: 0x15A4E04
	public bool get_allowMSAA() { }

	// RVA: 0x15A4E54
	public void set_allowMSAA(bool value) { }

	// RVA: 0x15A4EBC
	public bool get_allowDynamicResolution() { }

	// RVA: 0x15A4F0C
	public void set_allowDynamicResolution(bool value) { }

	// RVA: 0x15A4F74
	public bool get_forceIntoRenderTexture() { }

	// RVA: 0x15A4FC4
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x15A502C
	public float get_orthographicSize() { }

	// RVA: 0x15A507C
	public void set_orthographicSize(float value) { }

	// RVA: 0x15A50E4
	public bool get_orthographic() { }

	// RVA: 0x15A5134
	public void set_orthographic(bool value) { }

	// RVA: 0x15A519C
	public OpaqueSortMode get_opaqueSortMode() { }

	// RVA: 0x15A51EC
	public void set_opaqueSortMode(OpaqueSortMode value) { }

	// RVA: 0x15A5254
	public TransparencySortMode get_transparencySortMode() { }

	// RVA: 0x15A52A4
	public void set_transparencySortMode(TransparencySortMode value) { }

	// RVA: 0x15A530C
	public Vector3 get_transparencySortAxis() { }

	// RVA: 0x15A53D4
	public void set_transparencySortAxis(Vector3 value) { }

	// RVA: 0x15A5494
	public void ResetTransparencySortSettings() { }

	// RVA: 0x15A54E4
	public float get_depth() { }

	// RVA: 0x15A5534
	public void set_depth(float value) { }

	// RVA: 0x15A559C
	public float get_aspect() { }

	// RVA: 0x15A55EC
	public void set_aspect(float value) { }

	// RVA: 0x15A5654
	public void ResetAspect() { }

	// RVA: 0x15A56A4
	public Vector3 get_velocity() { }

	// RVA: 0x15A576C
	public int get_cullingMask() { }

	// RVA: 0x15A57BC
	public void set_cullingMask(int value) { }

	// RVA: 0x15A5824
	public int get_eventMask() { }

	// RVA: 0x15A5874
	public void set_eventMask(int value) { }

	// RVA: 0x15A58DC
	public bool get_layerCullSpherical() { }

	// RVA: 0x15A592C
	public void set_layerCullSpherical(bool value) { }

	// RVA: 0x15A5994
	public CameraType get_cameraType() { }

	// RVA: 0x15A59E4
	public void set_cameraType(CameraType value) { }

	// RVA: 0x15A5A4C
	internal Material get_skyboxMaterial() { }

	// RVA: 0x15A5A9C
	public UInt64 get_overrideSceneCullingMask() { }

	// RVA: 0x15A5AEC
	public void set_overrideSceneCullingMask(UInt64 value) { }

	// RVA: 0x15A5B54
	internal UInt64 get_sceneCullingMask() { }

	// RVA: 0x15A5BA4
	private float[] GetLayerCullDistances() { }

	// RVA: 0x15A5BF4
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x15A5C5C
	public float[] get_layerCullDistances() { }

	// RVA: 0x15A5CAC
	public void set_layerCullDistances(float[] value) { }

	// RVA: 0x15A5D70
	internal static int get_PreviewCullingLayer() { }

	// RVA: 0x15A5D78
	public bool get_useOcclusionCulling() { }

	// RVA: 0x15A5DC8
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x15A5E30
	public Matrix4x4 get_cullingMatrix() { }

	// RVA: 0x15A5F10
	public void set_cullingMatrix(Matrix4x4 value) { }

	// RVA: 0x15A5FE0
	public void ResetCullingMatrix() { }

	// RVA: 0x15A6030
	public Color get_backgroundColor() { }

	// RVA: 0x15A60F4
	public void set_backgroundColor(Color value) { }

	// RVA: 0x15A61B4
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x15A6204
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x15A626C
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x15A62BC
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x15A6324
	public bool get_clearStencilAfterLightingPass() { }

	// RVA: 0x15A6374
	public void set_clearStencilAfterLightingPass(bool value) { }

	// RVA: 0x15A63DC
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x15A6434
	public void ResetReplacementShader() { }

	// RVA: 0x15A6484
	internal ProjectionMatrixMode get_projectionMatrixMode() { }

	// RVA: 0x15A64D4
	public bool get_usePhysicalProperties() { }

	// RVA: 0x15A6524
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x15A658C
	public int get_iso() { }

	// RVA: 0x15A65DC
	public void set_iso(int value) { }

	// RVA: 0x15A6644
	public float get_shutterSpeed() { }

	// RVA: 0x15A6694
	public void set_shutterSpeed(float value) { }

	// RVA: 0x15A66FC
	public float get_aperture() { }

	// RVA: 0x15A674C
	public void set_aperture(float value) { }

	// RVA: 0x15A67B4
	public float get_focusDistance() { }

	// RVA: 0x15A6804
	public void set_focusDistance(float value) { }

	// RVA: 0x15A686C
	public float get_focalLength() { }

	// RVA: 0x15A68BC
	public void set_focalLength(float value) { }

	// RVA: 0x15A6924
	public int get_bladeCount() { }

	// RVA: 0x15A6974
	public void set_bladeCount(int value) { }

	// RVA: 0x15A69DC
	public Vector2 get_curvature() { }

	// RVA: 0x15A6A9C
	public void set_curvature(Vector2 value) { }

	// RVA: 0x15A6B58
	public float get_barrelClipping() { }

	// RVA: 0x15A6BA8
	public void set_barrelClipping(float value) { }

	// RVA: 0x15A6C10
	public float get_anamorphism() { }

	// RVA: 0x15A6C60
	public void set_anamorphism(float value) { }

	// RVA: 0x15A6CC8
	public Vector2 get_sensorSize() { }

	// RVA: 0x15A6D88
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x15A6E44
	public Vector2 get_lensShift() { }

	// RVA: 0x15A6F04
	public void set_lensShift(Vector2 value) { }

	// RVA: 0x15A6FC0
	public GateFitMode get_gateFit() { }

	// RVA: 0x15A7010
	public void set_gateFit(GateFitMode value) { }

	// RVA: 0x15A7078
	public float GetGateFittedFieldOfView() { }

	// RVA: 0x15A70C8
	public Vector2 GetGateFittedLensShift() { }

	// RVA: 0x15A7188
	internal Vector3 GetLocalSpaceAim() { }

	// RVA: 0x15A7250
	public Rect get_rect() { }

	// RVA: 0x15A7314
	public void set_rect(Rect value) { }

	// RVA: 0x15A73D4
	public Rect get_pixelRect() { }

	// RVA: 0x15A7498
	public void set_pixelRect(Rect value) { }

	// RVA: 0x15A7558
	public int get_pixelWidth() { }

	// RVA: 0x15A75A8
	public int get_pixelHeight() { }

	// RVA: 0x15A75F8
	public int get_scaledPixelWidth() { }

	// RVA: 0x15A7648
	public int get_scaledPixelHeight() { }

	// RVA: 0x15A7698
	public RenderTexture get_targetTexture() { }

	// RVA: 0x15A76E8
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x15A7750
	public RenderTexture get_activeTexture() { }

	// RVA: 0x15A77A0
	public int get_targetDisplay() { }

	// RVA: 0x15A77F0
	public void set_targetDisplay(int value) { }

	// RVA: 0x15A7858
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x15A790C
	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x15A7968
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0x15A7A24
	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x15A7A88
	internal string[] GetCameraBufferWarnings() { }

	// RVA: 0x15A7AD8
	public Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0x15A7BB8
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x15A7C98
	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0x15A7D68
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x15A7E48
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x15A7F18
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x15A7FF8
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x15A80C8
	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	// RVA: 0x15A8118
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x15A8180
	public Matrix4x4 get_previousViewProjectionMatrix() { }

	// RVA: 0x15A8260
	public void ResetWorldToCameraMatrix() { }

	// RVA: 0x15A82B0
	public void ResetProjectionMatrix() { }

	// RVA: 0x15A8300
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0x15A83DC
	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15A84C0
	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15A85A4
	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15A8688
	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15A876C
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x15A87DC
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x15A884C
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x15A88BC
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x15A892C
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x15A89F0
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x15A8AB4
	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	// RVA: 0x15A8B7C
	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15A8C68
	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15A8CF4
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x15A8D7C
	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15A8E68
	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x15A8EF4
	public Ray ScreenPointToRay(Vector3 pos) { }

	// RVA: 0x15A8F7C
	private void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0x15A9074
	public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0x15A91A8
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0x15A92DC
	public static void CalculateProjectionMatrixFromPhysicalProperties(Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters) { }

	// RVA: 0x15A9378
	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	// RVA: 0x15A93DC
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	// RVA: 0x15A9440
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	// RVA: 0x15A94A4
	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	// RVA: 0x15A9508
	public static Camera get_main() { }

	// RVA: 0x15A9548
	public static Camera get_current() { }

	// RVA: 0x15A9588
	public Scene get_scene() { }

	// RVA: 0x15A9648
	public void set_scene(Scene value) { }

	// RVA: 0x15A9704
	public bool get_stereoEnabled() { }

	// RVA: 0x15A9754
	public float get_stereoSeparation() { }

	// RVA: 0x15A97A4
	public void set_stereoSeparation(float value) { }

	// RVA: 0x15A980C
	public float get_stereoConvergence() { }

	// RVA: 0x15A985C
	public void set_stereoConvergence(float value) { }

	// RVA: 0x15A98C4
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	// RVA: 0x15A9914
	public StereoTargetEyeMask get_stereoTargetEye() { }

	// RVA: 0x15A9964
	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	// RVA: 0x15A99CC
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x15A9A1C
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0x15A9AF4
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	// RVA: 0x15A9BCC
	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	// RVA: 0x15A9C34
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0x15A9D0C
	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x15A9DBC
	public void ResetStereoProjectionMatrices() { }

	// RVA: 0x15A9E0C
	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x15A9EBC
	public void ResetStereoViewMatrices() { }

	// RVA: 0x15A9F0C
	private static int GetAllCamerasCount() { }

	// RVA: 0x15A9F4C
	private static int GetAllCamerasImpl(Camera[] cam) { }

	// RVA: 0x15A9F9C
	public static int get_allCamerasCount() { }

	// RVA: 0x15A9FDC
	public static Camera[] get_allCameras() { }

	// RVA: 0x15AA090
	public static int GetAllCameras(Camera[] cameras) { }

	// RVA: 0x15AA18C
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	// RVA: 0x15AA1E4
	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	// RVA: 0x15AA23C
	public bool RenderToCubemap(Cubemap cubemap) { }

	// RVA: 0x15AA290
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	// RVA: 0x15AA2E8
	public bool RenderToCubemap(RenderTexture cubemap) { }

	// RVA: 0x15AA33C
	private int GetFilterMode() { }

	// RVA: 0x15AA38C
	public SceneViewFilterMode get_sceneViewFilterMode() { }

	// RVA: 0x15AA3DC
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x15AA444
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x15AA4AC
	public void Render() { }

	// RVA: 0x15AA4FC
	public void RenderWithShader(Shader shader, string replacementTag) { }

	// RVA: 0x15AA554
	public void RenderDontRestore() { }

	// RVA: 0x15AA5A4
	public void SubmitRenderRequests(System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests) { }

	// RVA: 0x315B3A8
	public void SubmitRenderRequest(RequestData renderRequest) { }

	// RVA: 0x15AA868
	private void SubmitRenderRequestsInternal(object requests) { }

	// RVA: 0x15AA8D0
	private object[] SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x15AA940
	public static void SetupCurrent(Camera cur) { }

	// RVA: 0x15AA990
	public void CopyFrom(Camera other) { }

	// RVA: 0x15AA9F8
	public int get_commandBufferCount() { }

	// RVA: 0x15AAA48
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x15AAAB0
	public void RemoveAllCommandBuffers() { }

	// RVA: 0x15AAB00
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x15AAB58
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x15AABC0
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x15AAC18
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x15AAD58
	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x15AAEA8
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x15AAFE8
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	// RVA: 0x15AB050
	private static void FireOnPreCull(Camera cam) { }

	// RVA: 0x15AB0CC
	private static void FireOnPreRender(Camera cam) { }

	// RVA: 0x15AB148
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x15AB1C4
	internal void OnlyUsedForTesting1() { }

	// RVA: 0x15AB1C8
	internal void OnlyUsedForTesting2() { }

	// RVA: 0x15AB1CC
	public bool TryGetCullingParameters(ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x15AB28C
	public bool TryGetCullingParameters(bool stereoAware, ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x15AB224
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	// RVA: 0x15A536C
	private void get_transparencySortAxis_Injected(Vector3 ret) { }

	// RVA: 0x15A542C
	private void set_transparencySortAxis_Injected(Vector3 value) { }

	// RVA: 0x15A5704
	private void get_velocity_Injected(Vector3 ret) { }

	// RVA: 0x15A5EA8
	private void get_cullingMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15A5F78
	private void set_cullingMatrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15A608C
	private void get_backgroundColor_Injected(Color ret) { }

	// RVA: 0x15A614C
	private void set_backgroundColor_Injected(Color value) { }

	// RVA: 0x15A6A34
	private void get_curvature_Injected(Vector2 ret) { }

	// RVA: 0x15A6AF0
	private void set_curvature_Injected(Vector2 value) { }

	// RVA: 0x15A6D20
	private void get_sensorSize_Injected(Vector2 ret) { }

	// RVA: 0x15A6DDC
	private void set_sensorSize_Injected(Vector2 value) { }

	// RVA: 0x15A6E9C
	private void get_lensShift_Injected(Vector2 ret) { }

	// RVA: 0x15A6F58
	private void set_lensShift_Injected(Vector2 value) { }

	// RVA: 0x15A7120
	private void GetGateFittedLensShift_Injected(Vector2 ret) { }

	// RVA: 0x15A71E8
	private void GetLocalSpaceAim_Injected(Vector3 ret) { }

	// RVA: 0x15A72AC
	private void get_rect_Injected(Rect ret) { }

	// RVA: 0x15A736C
	private void set_rect_Injected(Rect value) { }

	// RVA: 0x15A7430
	private void get_pixelRect_Injected(Rect ret) { }

	// RVA: 0x15A74F0
	private void set_pixelRect_Injected(Rect value) { }

	// RVA: 0x15A78B4
	private void SetTargetBuffersImpl_Injected(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x15A79CC
	private void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0x15A7B50
	private void get_cameraToWorldMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15A7C30
	private void get_worldToCameraMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15A7D00
	private void set_worldToCameraMatrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15A7DE0
	private void get_projectionMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15A7EB0
	private void set_projectionMatrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15A7F90
	private void get_nonJitteredProjectionMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15A8060
	private void set_nonJitteredProjectionMatrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15A81F8
	private void get_previousViewProjectionMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15A8384
	private void CalculateObliqueMatrix_Injected(Vector4 clipPlane, Matrix4x4 ret) { }

	// RVA: 0x15A8458
	private void WorldToScreenPoint_Injected(Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x15A853C
	private void WorldToViewportPoint_Injected(Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x15A8620
	private void ViewportToWorldPoint_Injected(Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x15A8704
	private void ScreenToWorldPoint_Injected(Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x15A8998
	private void ScreenToViewportPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x15A8A5C
	private void ViewportToScreenPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x15A8B1C
	private void GetFrustumPlaneSizeAt_Injected(float distance, Vector2 ret) { }

	// RVA: 0x15A8C00
	private void ViewportPointToRay_Injected(Vector2 pos, MonoOrStereoscopicEye eye, Ray ret) { }

	// RVA: 0x15A8E00
	private void ScreenPointToRay_Injected(Vector2 pos, MonoOrStereoscopicEye eye, Ray ret) { }

	// RVA: 0x15A8FFC
	private void CalculateFrustumCornersInternal_Injected(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0x15A9244
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0x15A95E0
	private void get_scene_Injected(Scene ret) { }

	// RVA: 0x15A969C
	private void set_scene_Injected(Scene value) { }

	// RVA: 0x15A9A9C
	private void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, Matrix4x4 ret) { }

	// RVA: 0x15A9B74
	private void GetStereoViewMatrix_Injected(StereoscopicEye eye, Matrix4x4 ret) { }

	// RVA: 0x15A9CB4
	private void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, Matrix4x4 ret) { }

	// RVA: 0x15A9D64
	private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x15A9E64
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

	// RVA: 0x15AB428
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15AB4CC
	public virtual void Invoke(CullingGroupEvent sphere) { }

}

// Namespace: UnityEngine
public class CullingGroup
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private StateChanged m_OnStateChanged; // 0x18

	// Methods

	// RVA: 0x15AB3C0
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

	// RVA: 0x15AB4E0
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	// RVA: 0x15AB590
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x15AB7B8
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class DebugLogHandler
{
	// Methods

	// RVA: 0x15AB8A4
	internal static void Internal_Log(LogType level, LogOption options, string msg, object obj) { }

	// RVA: 0x15AB90C
	internal static void Internal_LogException(Exception ex, object obj) { }

	// RVA: 0x15AB974
	public void LogFormat(LogType logType, object context, string format, object[] args) { }

	// RVA: 0x15AB9E0
	public void LogFormat(LogType logType, LogOption logOptions, object context, string format, object[] args) { }

	// RVA: 0x15ABA58
	public void LogException(Exception exception, object context) { }

	// RVA: 0x15ABB0C
	public void .ctor() { }

}

// Namespace: UnityEngine
public class Debug
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Methods

	// RVA: 0x15ABB14
	public static ILogger get_unityLogger() { }

	// RVA: 0x15ABB90
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x15ABBE8
	public static void Log(object message) { }

	// RVA: 0x15ABDB0
	public static void LogFormat(LogType logType, LogOption logOptions, object context, string format, object[] args) { }

	// RVA: 0x15AC194
	public static void LogError(object message) { }

	// RVA: 0x15AC2D8
	public static void LogError(object message, object context) { }

	// RVA: 0x15AC424
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x15AC570
	public static void LogErrorFormat(object context, string format, object[] args) { }

	// RVA: 0x15A3C48
	public static void LogException(Exception exception) { }

	// RVA: 0x15AC6C8
	public static void LogException(Exception exception, object context) { }

	// RVA: 0x15AA724
	public static void LogWarning(object message) { }

	// RVA: 0x15AC810
	public static void LogWarning(object message, object context) { }

	// RVA: 0x15AC95C
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x15ACAA8
	public static void LogWarningFormat(object context, string format, object[] args) { }

	// RVA: 0x15ACC00
	public static void Assert(bool condition) { }

	// RVA: 0x15ACD58
	public static void Assert(bool condition, string message) { }

	// RVA: 0x15ACEA8
	public static void LogAssertion(object message) { }

	// RVA: 0x15ACFEC
	public static void LogAssertionFormat(string format, object[] args) { }

	// RVA: 0x15AD138
	public static bool get_isDebugBuild() { }

	// RVA: 0x15AD178
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	// RVA: 0x15AD528
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x15AD7C8
	private static void .cctor() { }

}

// Namespace: 
internal class Expression
{
	// Fields
	internal readonly string[] rpnTokens; // 0x10
	internal readonly bool hasVariables; // 0x18

	// Methods

	// RVA: 0x15AFCB4
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

	// RVA: 0x15AFC40
	public void .ctor(UInt64 state, UInt64 sequence) { }

	// RVA: 0x15AF694
	public UInt32 GetUInt() { }

	// RVA: 0x15AFD7C
	private static UInt32 RotateRight(UInt32 v, int rot) { }

	// RVA: 0x15AFD64
	private static UInt32 XshRr(UInt64 s) { }

	// RVA: 0x15AFD44
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

	// RVA: 0x15AFC68
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

	// RVA: 0x15AFD84
	private static void .cctor() { }

	// RVA: 0x15AFDF0
	public void .ctor() { }

	// RVA: 0x15AFDF8
	internal bool <ExpressionToTokens>b__14_0(string f) { }

}

// Namespace: UnityEngine
public class ExpressionEvaluator
{
	// Fields
	private static PcgRandom s_Random; // 0x0
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.ExpressionEvaluator.Operator> s_Operators; // 0x10

	// Methods

	// RVA: 0x30A3D6C
	internal static bool Evaluate(string expression, T value, Expression delayed) { }

	// RVA: 0x315B3A8
	private static bool EvaluateTokens(string[] tokens, T value, int index, int count) { }

	// RVA: 0x15AD8C4
	private static bool EvaluateDouble(string[] tokens, Double value, int index, int count) { }

	// RVA: 0x15AE624
	private static string[] InfixToRPN(string[] tokens) { }

	// RVA: 0x15AED6C
	private static bool NeedToPop(System.Collections.Generic.Stack<System.String> operatorStack, Operator newOperator) { }

	// RVA: 0x15AEF24
	private static string[] ExpressionToTokens(string expression, bool hasVariables) { }

	// RVA: 0x15AE124
	private static bool IsCommand(string token) { }

	// RVA: 0x15AE5C4
	private static bool IsVariable(string token) { }

	// RVA: 0x15AEC30
	private static bool IsDelayedFunction(string token) { }

	// RVA: 0x15ADFB8
	private static bool IsOperator(string token) { }

	// RVA: 0x15AE05C
	private static Operator TokenToOperator(string token) { }

	// RVA: 0x15AF2B0
	private static string PreFormatExpression(string expression) { }

	// RVA: 0x15AF4F4
	private static string[] FixUnaryOperators(string[] tokens) { }

	// RVA: 0x15AE258
	private static Double EvaluateOp(Double[] values, Op op, int index, int count) { }

	// RVA: 0x30A3C14
	private static bool TryParse(string expression, T result) { }

	// RVA: 0x15AF6C8
	private static void .cctor() { }

}

// Namespace: UnityEngine
public struct Bounds
{
	// Fields
	private Vector3 m_Center; // 0x10
	private Vector3 m_Extents; // 0x1C

	// Methods

	// RVA: 0x15AFEF0
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x15AFF10
	public override int GetHashCode() { }

	// RVA: 0x15AFFE4
	public override bool Equals(object other) { }

	// RVA: 0x15B00AC
	public bool Equals(Bounds other) { }

	// RVA: 0x15B0100
	public Vector3 get_center() { }

	// RVA: 0x15B010C
	public void set_center(Vector3 value) { }

	// RVA: 0x15B0118
	public Vector3 get_size() { }

	// RVA: 0x15B0130
	public void set_size(Vector3 value) { }

	// RVA: 0x15B014C
	public Vector3 get_extents() { }

	// RVA: 0x15B0158
	public void set_extents(Vector3 value) { }

	// RVA: 0x15B0164
	public Vector3 get_min() { }

	// RVA: 0x15B0180
	public void set_min(Vector3 value) { }

	// RVA: 0x15B01D0
	public Vector3 get_max() { }

	// RVA: 0x15B01EC
	public void set_max(Vector3 value) { }

	// RVA: 0x15B023C
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x15B02B8
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x15B0338
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x15B0370
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x15B03E8
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x15B04E4
	public bool Intersects(Bounds bounds) { }

	// RVA: 0x15B0580
	public bool IntersectRay(Ray ray) { }

	// RVA: 0x15B064C
	public override string ToString() { }

	// RVA: 0x15B0808
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15B09B4
	public bool Contains(Vector3 point) { }

	// RVA: 0x15B0A74
	public float SqrDistance(Vector3 point) { }

	// RVA: 0x15B05F4
	private static bool IntersectRayAABB(Ray ray, Bounds bounds, float dist) { }

	// RVA: 0x15B0A0C
	private static bool Contains_Injected(Bounds _unity_self, Vector3 point) { }

	// RVA: 0x15B0ACC
	private static float SqrDistance_Injected(Bounds _unity_self, Vector3 point) { }

	// RVA: 0x15B0B34
	private static bool IntersectRayAABB_Injected(Ray ray, Bounds bounds, float dist) { }

}

// Namespace: UnityEngine
public struct BoundsInt
{
	// Fields
	private Vector3Int m_Position; // 0x10
	private Vector3Int m_Size; // 0x1C

	// Methods

	// RVA: 0x15B0B8C
	public Vector3Int get_position() { }

	// RVA: 0x15B0B9C
	public void set_position(Vector3Int value) { }

	// RVA: 0x15B0BA8
	public Vector3Int get_size() { }

	// RVA: 0x15B0BB8
	public void set_size(Vector3Int value) { }

	// RVA: 0x15B0BC4
	public void .ctor(Vector3Int position, Vector3Int size) { }

	// RVA: 0x15B0BD8
	public override string ToString() { }

	// RVA: 0x15B0D70
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15B10E8
	public override bool Equals(object other) { }

	// RVA: 0x15B11C0
	public bool Equals(BoundsInt other) { }

	// RVA: 0x15B1224
	public override int GetHashCode() { }

}

// Namespace: UnityEngine
public sealed class GeometryUtility
{
	// Methods

	// RVA: 0x15B1304
	public static Plane[] CalculateFrustumPlanes(Camera camera) { }

	// RVA: 0x15B1370
	public static void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	// RVA: 0x15B1478
	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	// RVA: 0x15B15F4
	public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	// RVA: 0x15B158C
	private static void Internal_ExtractPlanes(Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	// RVA: 0x15B165C
	private static bool TestPlanesAABB_Injected(Plane[] planes, Bounds bounds) { }

	// RVA: 0x15B16C4
	private static void Internal_ExtractPlanes_Injected(Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

}

// Namespace: UnityEngine
public struct Plane
{
	// Fields
	private Vector3 m_Normal; // 0x10
	private float m_Distance; // 0x1C

	// Methods

	// RVA: 0x15B172C
	public Vector3 get_normal() { }

	// RVA: 0x15B1738
	public float get_distance() { }

	// RVA: 0x15B1740
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x15B1870
	public void .ctor(Vector3 inNormal, float d) { }

	// RVA: 0x15B1978
	public void .ctor(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0x15B1AEC
	public float GetDistanceToPoint(Vector3 point) { }

	// RVA: 0x15B1B10
	public bool Raycast(Ray ray, float enter) { }

	// RVA: 0x15B1C1C
	public override string ToString() { }

	// RVA: 0x15B1DD8
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public struct Ray
{
	// Fields
	private Vector3 m_Origin; // 0x10
	private Vector3 m_Direction; // 0x1C

	// Methods

	// RVA: 0x15B1F84
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x15B2090
	public Vector3 get_origin() { }

	// RVA: 0x15B209C
	public void set_origin(Vector3 value) { }

	// RVA: 0x15B20A8
	public Vector3 get_direction() { }

	// RVA: 0x15B20B4
	public void set_direction(Vector3 value) { }

	// RVA: 0x15B21B8
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x15B21E0
	public override string ToString() { }

	// RVA: 0x15B239C
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

	// RVA: 0x15B2548
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x15B2554
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x15B2560
	public void .ctor(Rect source) { }

	// RVA: 0x15B256C
	public static Rect get_zero() { }

	// RVA: 0x15B2580
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x15B258C
	public float get_x() { }

	// RVA: 0x15B2594
	public void set_x(float value) { }

	// RVA: 0x15B259C
	public float get_y() { }

	// RVA: 0x15B25A4
	public void set_y(float value) { }

	// RVA: 0x15B25AC
	public Vector2 get_position() { }

	// RVA: 0x15B25B4
	public void set_position(Vector2 value) { }

	// RVA: 0x15B25BC
	public Vector2 get_center() { }

	// RVA: 0x15B25D4
	public void set_center(Vector2 value) { }

	// RVA: 0x15B25F0
	public Vector2 get_min() { }

	// RVA: 0x15B25F8
	public void set_min(Vector2 value) { }

	// RVA: 0x15B2614
	public Vector2 get_max() { }

	// RVA: 0x15B2628
	public void set_max(Vector2 value) { }

	// RVA: 0x15B263C
	public float get_width() { }

	// RVA: 0x15B2644
	public void set_width(float value) { }

	// RVA: 0x15B264C
	public float get_height() { }

	// RVA: 0x15B2654
	public void set_height(float value) { }

	// RVA: 0x15B265C
	public Vector2 get_size() { }

	// RVA: 0x15B2664
	public void set_size(Vector2 value) { }

	// RVA: 0x15B266C
	public float get_xMin() { }

	// RVA: 0x15B2674
	public void set_xMin(float value) { }

	// RVA: 0x15B2690
	public float get_yMin() { }

	// RVA: 0x15B2698
	public void set_yMin(float value) { }

	// RVA: 0x15B26B4
	public float get_xMax() { }

	// RVA: 0x15B26C4
	public void set_xMax(float value) { }

	// RVA: 0x15B26D4
	public float get_yMax() { }

	// RVA: 0x15B26E4
	public void set_yMax(float value) { }

	// RVA: 0x15B26F4
	public bool Contains(Vector2 point) { }

	// RVA: 0x15B2738
	public bool Contains(Vector3 point) { }

	// RVA: 0x15B277C
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x15B27A8
	public bool Overlaps(Rect other) { }

	// RVA: 0x15B27F4
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x15B2884
	public static Vector2 PointToNormalized(Rect rectangle, Vector2 point) { }

	// RVA: 0x15B28F8
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x15B291C
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x15B2940
	public override int GetHashCode() { }

	// RVA: 0x15B29D4
	public override bool Equals(object other) { }

	// RVA: 0x15B2BD4
	public bool Equals(Rect other) { }

	// RVA: 0x15B2C7C
	public override string ToString() { }

	// RVA: 0x15B2C88
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

	// RVA: 0x15B2EF8
	public int get_x() { }

	// RVA: 0x15B2F00
	public void set_x(int value) { }

	// RVA: 0x15B2F08
	public int get_y() { }

	// RVA: 0x15B2F10
	public void set_y(int value) { }

	// RVA: 0x15B2F18
	public int get_width() { }

	// RVA: 0x15B2F20
	public void set_width(int value) { }

	// RVA: 0x15B2F28
	public int get_height() { }

	// RVA: 0x15B2F30
	public void set_height(int value) { }

	// RVA: 0x15B2F38
	public int get_xMin() { }

	// RVA: 0x15B2FA8
	public int get_yMin() { }

	// RVA: 0x15B3018
	public int get_xMax() { }

	// RVA: 0x15B3088
	public int get_yMax() { }

	// RVA: 0x15B30F8
	public void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x15B3104
	public bool Overlaps(RectInt other) { }

	// RVA: 0x15B3824
	public override string ToString() { }

	// RVA: 0x15B3A80
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15B3CC4
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

	// RVA: 0x15B3D08
	public void .ctor() { }

	// RVA: 0x15B3DA4
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x15B3DEC
	protected override void Finalize() { }

	// RVA: 0x15B3F38
	public void .ctor(int left, int right, int top, int bottom) { }

	// RVA: 0x15B424C
	public override string ToString() { }

	// RVA: 0x15B4538
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15B3ED0
	private void Destroy() { }

	// RVA: 0x15B3D64
	private static IntPtr InternalCreate() { }

	// RVA: 0x15B494C
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x15B480C
	public int get_left() { }

	// RVA: 0x15B40AC
	public void set_left(int value) { }

	// RVA: 0x15B485C
	public int get_right() { }

	// RVA: 0x15B4114
	public void set_right(int value) { }

	// RVA: 0x15B48AC
	public int get_top() { }

	// RVA: 0x15B417C
	public void set_top(int value) { }

	// RVA: 0x15B48FC
	public int get_bottom() { }

	// RVA: 0x15B41E4
	public void set_bottom(int value) { }

	// RVA: 0x15B499C
	public int get_horizontal() { }

	// RVA: 0x15B49EC
	public int get_vertical() { }

	// RVA: 0x15B4A3C
	public Rect Remove(Rect rect) { }

	// RVA: 0x15B4AA4
	private void Remove_Injected(Rect rect, Rect ret) { }

}

// Namespace: UnityEngine
public sealed class LightingSettings
{
	// Methods

	// RVA: 0x15B4AFC
	internal void LightingSettingsDontStripMe() { }

}

// Namespace: UnityEngine
public sealed class Gizmos
{
	// Methods

	// RVA: 0x15B4B00
	public static void DrawLine(Vector3 from, Vector3 to) { }

	// RVA: 0x15B4BC4
	public static void DrawWireSphere(Vector3 center, float radius) { }

	// RVA: 0x15B4C8C
	public static void DrawSphere(Vector3 center, float radius) { }

	// RVA: 0x15B4D54
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	// RVA: 0x15B4E18
	public static void DrawCube(Vector3 center, Vector3 size) { }

	// RVA: 0x15B4EDC
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15B4FD4
	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15B50CC
	public static void set_color(Color value) { }

	// RVA: 0x15B5184
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x15B5224
	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	// RVA: 0x15B5314
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	// RVA: 0x15B537C
	public static void DrawMesh(Mesh mesh) { }

	// RVA: 0x15B54A0
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15B551C
	public static void DrawWireMesh(Mesh mesh) { }

	// RVA: 0x15B5640
	public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15B4B5C
	private static void DrawLine_Injected(Vector3 from, Vector3 to) { }

	// RVA: 0x15B4C24
	private static void DrawWireSphere_Injected(Vector3 center, float radius) { }

	// RVA: 0x15B4CEC
	private static void DrawSphere_Injected(Vector3 center, float radius) { }

	// RVA: 0x15B4DB0
	private static void DrawWireCube_Injected(Vector3 center, Vector3 size) { }

	// RVA: 0x15B4E74
	private static void DrawCube_Injected(Vector3 center, Vector3 size) { }

	// RVA: 0x15B4F64
	private static void DrawMesh_Injected(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15B505C
	private static void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x15B5134
	private static void set_color_Injected(Color value) { }

	// RVA: 0x15B51D4
	private static void set_matrix_Injected(Matrix4x4 value) { }

	// RVA: 0x15B52A4
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

	// RVA: 0x15A4000
	public static void Invoke() { }

	// RVA: 0x15B56BC
	private static void .cctor() { }

}

// Namespace: UnityEngine
public static class CustomRenderTextureManager
{
	// Fields
	private static System.Action<UnityEngine.CustomRenderTexture> textureLoaded; // 0x0
	private static System.Action<UnityEngine.CustomRenderTexture> textureUnloaded; // 0x8

	// Methods

	// RVA: 0x15B5758
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	// RVA: 0x15B57D4
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }

}

// Namespace: 
public sealed class DisplaysUpdatedDelegate
{
	// Methods

	// RVA: 0x15B61EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15B628C
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

	// RVA: 0x15B5850
	internal void .ctor() { }

	// RVA: 0x15B5898
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x15B58C4
	public int get_renderingWidth() { }

	// RVA: 0x15B59E0
	public int get_renderingHeight() { }

	// RVA: 0x15B5AA4
	public int get_systemWidth() { }

	// RVA: 0x15B5BC0
	public int get_systemHeight() { }

	// RVA: 0x15B5C84
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x15B5DDC
	public static Display get_main() { }

	// RVA: 0x15B5E58
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	// RVA: 0x15B5FF8
	internal static void FireDisplaysUpdated() { }

	// RVA: 0x15B5B68
	private static void GetSystemExtImpl(IntPtr nativeDisplay, int w, int h) { }

	// RVA: 0x15B5988
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, int w, int h) { }

	// RVA: 0x15B5D74
	private static int RelativeMouseAtImpl(int x, int y, int rx, int ry) { }

	// RVA: 0x15B60A8
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

	// RVA: 0x15B62A0
	public Double get_value() { }

	// RVA: 0x15B62B4
	public bool Equals(RefreshRate other) { }

	// RVA: 0x15B62F4
	public int CompareTo(RefreshRate other) { }

	// RVA: 0x15B6360
	public override string ToString() { }

}

// Namespace: UnityEngine
public sealed class Screen
{
	// Methods

	// RVA: 0x15B6408
	public static int get_width() { }

	// RVA: 0x15B6448
	public static int get_height() { }

	// RVA: 0x15B6488
	public static float get_dpi() { }

	// RVA: 0x15B64C8
	private static ScreenOrientation GetScreenOrientation() { }

	// RVA: 0x15B6508
	public static ScreenOrientation get_orientation() { }

	// RVA: 0x15B6548
	public static void set_sleepTimeout(int value) { }

	// RVA: 0x15B6598
	public static Resolution get_currentResolution() { }

	// RVA: 0x15B6638
	public static bool get_fullScreen() { }

	// RVA: 0x15B6678
	public static Rect get_safeArea() { }

	// RVA: 0x15B671C
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	// RVA: 0x15B67F0
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	// RVA: 0x15B686C
	public static void SetResolution(int width, int height, bool fullscreen) { }

	// RVA: 0x15B68E4
	public static Resolution[] get_resolutions() { }

	// RVA: 0x15B65E8
	private static void get_currentResolution_Injected(Resolution ret) { }

	// RVA: 0x15B66CC
	private static void get_safeArea_Injected(Rect ret) { }

	// RVA: 0x15B6788
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

	// RVA: 0x15B6924
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	// RVA: 0x15B6964
	private static void Internal_SetNullRT() { }

	// RVA: 0x15B69A4
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x15B6AE4
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	// RVA: 0x15B6BF0
	internal static void Internal_DrawTexture(Internal_DrawTextureArguments args) { }

	// RVA: 0x15B6C40
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	// RVA: 0x15B6CB0
	private static void Blit2(Texture source, RenderTexture dest) { }

	// RVA: 0x15B6D18
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0x15B6D68
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x15B6EA8
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x15B7118
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x15B7198
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x15B7240
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x15B73F0
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x15B7488
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x15B7540
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x15B7600
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x15B7704
	public static void Blit(Texture source, Material mat, int pass) { }

	// RVA: 0x15B77C0
	public static void Blit(Texture source, Material mat) { }

	// RVA: 0x15B78B8
	public static void SetRenderTarget(RenderTexture rt) { }

	// RVA: 0x15B797C
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

	// RVA: 0x15B7A6C
	private static void .cctor() { }

	// RVA: 0x15B6A74
	private static void Internal_SetRTSimple_Injected(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x15B6B98
	private static void Internal_DrawMeshNow2_Injected(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

}

// Namespace: UnityEngine
public sealed class GL
{
	// Methods

	// RVA: 0x15B7B2C
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x15B7B88
	public static void Vertex(Vector3 v) { }

	// RVA: 0x15B7BE4
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x15B7C40
	public static void TexCoord2(float x, float y) { }

	// RVA: 0x15B7C90
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x15B7CF4
	public static void Color(Color c) { }

	// RVA: 0x15B7D58
	public static void Flush() { }

	// RVA: 0x15B7D98
	private static void SetViewMatrix(Matrix4x4 m) { }

	// RVA: 0x15B7E38
	public static void set_modelview(Matrix4x4 value) { }

	// RVA: 0x15B7EA8
	public static void PushMatrix() { }

	// RVA: 0x15B7EE8
	public static void PopMatrix() { }

	// RVA: 0x15B7F28
	public static void LoadOrtho() { }

	// RVA: 0x15B7F68
	public static void LoadPixelMatrix() { }

	// RVA: 0x15B7FA8
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	// RVA: 0x15B8048
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	// RVA: 0x15B8120
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x15B8184
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	// RVA: 0x15B81E8
	public static void Begin(int mode) { }

	// RVA: 0x15B8238
	public static void End() { }

	// RVA: 0x15B8278
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x15B8358
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x15B83D0
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x15B843C
	public static void Viewport(Rect pixelRect) { }

	// RVA: 0x15B7DE8
	private static void SetViewMatrix_Injected(Matrix4x4 m) { }

	// RVA: 0x15B7FF8
	private static void LoadProjectionMatrix_Injected(Matrix4x4 mat) { }

	// RVA: 0x15B80C8
	private static void GetGPUProjectionMatrix_Injected(Matrix4x4 proj, bool renderIntoTexture, Matrix4x4 ret) { }

	// RVA: 0x15B82F0
	private static void GLClear_Injected(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x15B84A4
	private static void Viewport_Injected(Rect pixelRect) { }

}

// Namespace: UnityEngine
public sealed class LightmapSettings
{
	// Methods

	// RVA: 0x15B84F4
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

	// RVA: 0x15B8544
	private static void Internal_CallLightProbesUpdatedFunction() { }

	// RVA: 0x15B85AC
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	// RVA: 0x15B8614
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

	// RVA: 0x15B867C
	public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, SphericalHarmonicsL2 probe) { }

	// RVA: 0x15B86E4
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

	// RVA: 0x15B873C
	public int get_width() { }

	// RVA: 0x15B8744
	public int get_height() { }

	// RVA: 0x15B874C
	public RefreshRate get_refreshRateRatio() { }

	// RVA: 0x15B8754
	public int get_refreshRate() { }

	// RVA: 0x15B8868
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

	// RVA: 0x15B8A10
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	// RVA: 0x15B8A94
	public static float get_lodBias() { }

	// RVA: 0x15B8AD4
	public static void set_lodBias(float value) { }

	// RVA: 0x15B8B2C
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	// RVA: 0x15B8B7C
	public static int get_globalTextureMipmapLimit() { }

	// RVA: 0x15B8BBC
	public static void set_globalTextureMipmapLimit(int value) { }

	// RVA: 0x15B8C0C
	public static void set_maximumLODLevel(int value) { }

	// RVA: 0x15B8C5C
	public static int get_vSyncCount() { }

	// RVA: 0x15B8C9C
	public static void set_vSyncCount(int value) { }

	// RVA: 0x15B8CEC
	public static void set_antiAliasing(int value) { }

	// RVA: 0x15B8D3C
	public static void SetTextureMipmapLimitSettings(string groupName, TextureMipmapLimitSettings textureMipmapLimitSettings) { }

	// RVA: 0x15B8DF8
	public static TextureMipmapLimitSettings GetTextureMipmapLimitSettings(string groupName) { }

	// RVA: 0x15B8EB8
	private static ScriptableObject get_INTERNAL_renderPipeline() { }

	// RVA: 0x15B8EF8
	private static void set_INTERNAL_renderPipeline(ScriptableObject value) { }

	// RVA: 0x15B8F48
	public static RenderPipelineAsset get_renderPipeline() { }

	// RVA: 0x15B9008
	public static void set_renderPipeline(RenderPipelineAsset value) { }

	// RVA: 0x15B9058
	public static ColorSpace get_activeColorSpace() { }

	// RVA: 0x15B8D90
	private static void SetTextureMipmapLimitSettings_Injected(string groupName, TextureMipmapLimitSettings textureMipmapLimitSettings) { }

	// RVA: 0x15B8E50
	private static void GetTextureMipmapLimitSettings_Injected(string groupName, TextureMipmapLimitSettings ret) { }

}

// Namespace: UnityEngine
public sealed class TrailRenderer
{
	// Methods

	// RVA: 0x15B9098
	public void set_startColor(Color value) { }

	// RVA: 0x15B9158
	public void set_endColor(Color value) { }

	// RVA: 0x15B9218
	public int get_positionCount() { }

	// RVA: 0x15B9268
	public void Clear() { }

	// RVA: 0x15B90F0
	private void set_startColor_Injected(Color value) { }

	// RVA: 0x15B91B0
	private void set_endColor_Injected(Color value) { }

}

// Namespace: UnityEngine
public sealed class MaterialPropertyBlock
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15B92B8
	private void SetFloatImpl(int name, float value) { }

	// RVA: 0x15B9318
	private void SetVectorImpl(int name, Vector4 value) { }

	// RVA: 0x15B93D8
	private void SetColorImpl(int name, Color value) { }

	// RVA: 0x15B9498
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x15B9548
	private void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x15B95A0
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	// RVA: 0x15B9608
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x15B9670
	private static IntPtr CreateImpl() { }

	// RVA: 0x15B96B0
	private static void DestroyImpl(IntPtr mpb) { }

	// RVA: 0x15B9700
	private void Clear(bool keepMemory) { }

	// RVA: 0x15B9768
	public void Clear() { }

	// RVA: 0x15B97C0
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x15B98EC
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x15B9A18
	public void .ctor() { }

	// RVA: 0x15B9A74
	protected override void Finalize() { }

	// RVA: 0x15B9B94
	private void Dispose() { }

	// RVA: 0x15B9C60
	public void SetFloat(string name, float value) { }

	// RVA: 0x15B9D58
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x15B9DB8
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x15B9E20
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x15B9E88
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x15B9F28
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x15B9F80
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x15B9F9C
	public void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x15B9380
	private void SetVectorImpl_Injected(int name, Vector4 value) { }

	// RVA: 0x15B9440
	private void SetColorImpl_Injected(int name, Color value) { }

	// RVA: 0x15B94F0
	private void SetMatrixImpl_Injected(int name, Matrix4x4 value) { }

}

// Namespace: UnityEngine
public class Renderer
{
	// Methods

	// RVA: 0x15B9FB8
	public Bounds get_bounds() { }

	// RVA: 0x15BA094
	public void set_bounds(Bounds value) { }

	// RVA: 0x15BA164
	private void SetStaticLightmapST(Vector4 st) { }

	// RVA: 0x15BA224
	private Material GetSharedMaterial() { }

	// RVA: 0x15BA274
	private void SetMaterial(Material m) { }

	// RVA: 0x15BA2DC
	private Material[] GetMaterialArray() { }

	// RVA: 0x15BA32C
	private void CopySharedMaterialArray(Material[] m) { }

	// RVA: 0x15BA394
	private void SetMaterialArray(Material[] m, int length) { }

	// RVA: 0x15BA3EC
	private void SetMaterialArray(Material[] m) { }

	// RVA: 0x15BA458
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x15BA4C0
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	// RVA: 0x15BA528
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x15BA590
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x15BA5F8
	public bool get_enabled() { }

	// RVA: 0x15BA648
	public void set_enabled(bool value) { }

	// RVA: 0x15BA6B0
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x15BA718
	public void set_receiveShadows(bool value) { }

	// RVA: 0x15BA780
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x15BA7D0
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x15BA838
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x15BA8A0
	public void set_allowOcclusionWhenDynamic(bool value) { }

	// RVA: 0x15BA908
	public bool get_isPartOfStaticBatch() { }

	// RVA: 0x15BA958
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x15BAA38
	public void set_probeAnchor(Transform value) { }

	// RVA: 0x15BAAA0
	private int GetLightmapIndex(LightmapType lt) { }

	// RVA: 0x15BAB08
	private void SetLightmapIndex(int index, LightmapType lt) { }

	// RVA: 0x15BAB60
	private Vector4 GetLightmapST(LightmapType lt) { }

	// RVA: 0x15BAC24
	public int get_lightmapIndex() { }

	// RVA: 0x15BAC7C
	public void set_lightmapIndex(int value) { }

	// RVA: 0x15BACD0
	public Vector4 get_lightmapScaleOffset() { }

	// RVA: 0x15BAD30
	public void set_lightmapScaleOffset(Vector4 value) { }

	// RVA: 0x15BAD88
	private int GetMaterialCount() { }

	// RVA: 0x15BADD8
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x15BAE28
	public Material[] get_materials() { }

	// RVA: 0x15BAE78
	public void set_materials(Material[] value) { }

	// RVA: 0x15BAEE4
	public Material get_sharedMaterial() { }

	// RVA: 0x15BAF34
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x15BAF9C
	public Material[] get_sharedMaterials() { }

	// RVA: 0x15BAFEC
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x15BB058
	public void GetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material> m) { }

	// RVA: 0x15BB194
	public void .ctor() { }

	// RVA: 0x15BA02C
	private void get_bounds_Injected(Bounds ret) { }

	// RVA: 0x15BA0FC
	private void set_bounds_Injected(Bounds value) { }

	// RVA: 0x15BA1BC
	private void SetStaticLightmapST_Injected(Vector4 st) { }

	// RVA: 0x15BA9D0
	private void get_localToWorldMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15BABCC
	private void GetLightmapST_Injected(LightmapType lt, Vector4 ret) { }

}

// Namespace: UnityEngine
public sealed class RenderSettings
{}

// Namespace: UnityEngine
public sealed class Shader
{
	// Methods

	// RVA: 0x15BB19C
	public static Shader Find(string name) { }

	// RVA: 0x15BB22C
	public static int get_globalMaximumLOD() { }

	// RVA: 0x15BB26C
	public static void set_globalMaximumLOD(int value) { }

	// RVA: 0x15BB2BC
	public bool get_isSupported() { }

	// RVA: 0x15BB30C
	public static void EnableKeyword(string keyword) { }

	// RVA: 0x15BB35C
	public static void DisableKeyword(string keyword) { }

	// RVA: 0x15BB3AC
	public int get_renderQueue() { }

	// RVA: 0x15BB3FC
	public static void WarmupAllShaders() { }

	// RVA: 0x15BB43C
	internal static int TagToID(string name) { }

	// RVA: 0x15B9D08
	public static int PropertyToID(string name) { }

	// RVA: 0x15BB48C
	private static void SetGlobalFloatImpl(int name, float value) { }

	// RVA: 0x15BB4F4
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	// RVA: 0x15BB5B4
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x15BB684
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	// RVA: 0x15BB6EC
	private static Vector4 GetGlobalVectorImpl(int name) { }

	// RVA: 0x15BB7B0
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x15BB818
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x15BB8BC
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x15BB914
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x15BB96C
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x15BB9CC
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x15BBA34
	public static Vector4 GetGlobalVector(int nameID) { }

	// RVA: 0x15BBA90
	private void .ctor() { }

	// RVA: 0x15BB54C
	private static void SetGlobalVectorImpl_Injected(int name, Vector4 value) { }

	// RVA: 0x15BB61C
	private static void SetGlobalMatrixImpl_Injected(int name, Matrix4x4 value) { }

	// RVA: 0x15BB748
	private static void GetGlobalVectorImpl_Injected(int name, Vector4 ret) { }

}

// Namespace: UnityEngine
public class Material
{
	// Methods

	// RVA: 0x15BBB18
	private static void CreateWithShader(Material self, Shader shader) { }

	// RVA: 0x15BBB80
	private static void CreateWithMaterial(Material self, Material source) { }

	// RVA: 0x15BBBE8
	private static void CreateWithString(Material self) { }

	// RVA: 0x15BBC38
	public void .ctor(Shader shader) { }

	// RVA: 0x15BBD08
	public void .ctor(Material source) { }

	// RVA: 0x15BBDD8
	public void .ctor(string contents) { }

	// RVA: 0x15BBE9C
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x15BBEDC
	public Shader get_shader() { }

	// RVA: 0x15BBF2C
	public void set_shader(Shader value) { }

	// RVA: 0x15BBF94
	public Color get_color() { }

	// RVA: 0x15BC224
	public Texture get_mainTexture() { }

	// RVA: 0x15BC450
	public void set_mainTexture(Texture value) { }

	// RVA: 0x15BC0B8
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	// RVA: 0x15BC654
	public bool HasProperty(int nameID) { }

	// RVA: 0x15BC6BC
	public bool HasProperty(string name) { }

	// RVA: 0x15BC768
	public int get_renderQueue() { }

	// RVA: 0x15BC7B8
	public void EnableKeyword(string keyword) { }

	// RVA: 0x15BC820
	public void DisableKeyword(string keyword) { }

	// RVA: 0x15BC888
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x15BC8F0
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x15BC958
	public string GetTag(string tag, bool searchFallbacks) { }

	// RVA: 0x15BC9E8
	public bool SetPass(int pass) { }

	// RVA: 0x15BCA50
	public void CopyPropertiesFromMaterial(Material mat) { }

	// RVA: 0x15BCAB8
	private string[] GetShaderKeywords() { }

	// RVA: 0x15BCB08
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x15BCB70
	public string[] get_shaderKeywords() { }

	// RVA: 0x15BCBC0
	public void set_shaderKeywords(string[] value) { }

	// RVA: 0x15BCC28
	public int ComputeCRC() { }

	// RVA: 0x15BCC78
	private void SetFloatImpl(int name, float value) { }

	// RVA: 0x15BCCD8
	private void SetColorImpl(int name, Color value) { }

	// RVA: 0x15BCD98
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x15BCE48
	private void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x15BCEA0
	private float GetFloatImpl(int name) { }

	// RVA: 0x15BCF08
	private Color GetColorImpl(int name) { }

	// RVA: 0x15BCFCC
	private Texture GetTextureImpl(int name) { }

	// RVA: 0x15BD034
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	// RVA: 0x15BD09C
	private void SetColorArray(int name, Color[] values, int count) { }

	// RVA: 0x15BD1C8
	public void SetInt(string name, int value) { }

	// RVA: 0x15BD268
	public void SetFloat(string name, float value) { }

	// RVA: 0x15BD310
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x15BD370
	public void SetColor(string name, Color value) { }

	// RVA: 0x15BD424
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x15BD48C
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x15BD4F4
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x15BC5B4
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x15BC55C
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x15BD564
	public void SetColorArray(int nameID, Color[] values) { }

	// RVA: 0x15BD580
	public float GetFloat(int nameID) { }

	// RVA: 0x15BC18C
	public Color GetColor(string name) { }

	// RVA: 0x15BC120
	public Color GetColor(int nameID) { }

	// RVA: 0x15BC3A4
	public Texture GetTexture(string name) { }

	// RVA: 0x15BC33C
	public Texture GetTexture(int nameID) { }

	// RVA: 0x15BCD40
	private void SetColorImpl_Injected(int name, Color value) { }

	// RVA: 0x15BCDF0
	private void SetMatrixImpl_Injected(int name, Matrix4x4 value) { }

	// RVA: 0x15BCF74
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

	// RVA: 0x15BD5E8
	public LightType get_type() { }

	// RVA: 0x15BD638
	public float get_spotAngle() { }

	// RVA: 0x15BD688
	public Color get_color() { }

	// RVA: 0x15BD74C
	public float get_colorTemperature() { }

	// RVA: 0x15BD79C
	public bool get_useColorTemperature() { }

	// RVA: 0x15BD7EC
	public float get_intensity() { }

	// RVA: 0x15BD83C
	public float get_bounceIntensity() { }

	// RVA: 0x15BD88C
	public float get_range() { }

	// RVA: 0x15BD8DC
	public LightBakingOutput get_bakingOutput() { }

	// RVA: 0x15BD9B8
	public LightShadows get_shadows() { }

	// RVA: 0x15BDA08
	public float get_cookieSize() { }

	// RVA: 0x15BDA58
	public Texture get_cookie() { }

	// RVA: 0x15BD6E4
	private void get_color_Injected(Color ret) { }

	// RVA: 0x15BD950
	private void get_bakingOutput_Injected(LightBakingOutput ret) { }

}

// Namespace: UnityEngine
public sealed class MeshFilter
{
	// Methods

	// RVA: 0x15BDAA8
	private void DontStripMeshFilter() { }

	// RVA: 0x15BDAAC
	public Mesh get_sharedMesh() { }

	// RVA: 0x15BDAFC
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x15BDB64
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

	// RVA: 0x15BDBCC
	public void set_limitBiasMode(TextureMipmapLimitBiasMode value) { }

	// RVA: 0x15BDBD4
	public void set_limitBias(int value) { }

}

// Namespace: UnityEngine
public class SkinnedMeshRenderer
{
	// Methods

	// RVA: 0x15BDBDC
	public void set_quality(SkinQuality value) { }

	// RVA: 0x15BDC44
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x15BDCAC
	public void set_forceMatrixRecalculationPerRender(bool value) { }

	// RVA: 0x15BDD14
	public Transform get_rootBone() { }

	// RVA: 0x15BDD64
	public void set_rootBone(Transform value) { }

	// RVA: 0x15BDDCC
	public Transform[] get_bones() { }

	// RVA: 0x15BDE1C
	public void set_bones(Transform[] value) { }

	// RVA: 0x15BDE84
	public Mesh get_sharedMesh() { }

	// RVA: 0x15BDED4
	public void set_sharedMesh(Mesh value) { }

}

// Namespace: UnityEngine
public class MeshRenderer
{
	// Methods

	// RVA: 0x15BDF3C
	private void DontStripMeshRenderer() { }

	// RVA: 0x15BDF40
	public Mesh get_additionalVertexStreams() { }

	// RVA: 0x15BDF90
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class LightProbeGroup
{
	// Methods

	// RVA: 0x15BDF98
	public Vector3[] get_probePositions() { }

	// RVA: 0x15BDFA0
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

	// RVA: 0x15BDFA8
	private static void Internal_Create(Mesh mono) { }

	// RVA: 0x15BDFF8
	public void .ctor() { }

	// RVA: 0x15BE0BC
	public void set_indexFormat(IndexFormat value) { }

	// RVA: 0x15BE124
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	// RVA: 0x15BE17C
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x15BE204
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x15BE25C
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x15BE2F4
	private UInt32 GetIndexCountImpl(int submesh) { }

	// RVA: 0x15BE35C
	private UInt32 GetBaseVertexImpl(int submesh) { }

	// RVA: 0x15BE3C4
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	// RVA: 0x15BE41C
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	// RVA: 0x15BE474
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15BE514
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	// RVA: 0x15BE57C
	public bool HasVertexAttribute(VertexAttribute attr) { }

	// RVA: 0x15BE5E4
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x15BE684
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: 0x15BE6EC
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	// RVA: 0x15BE75C
	public IntPtr GetNativeIndexBufferPtr() { }

	// RVA: 0x15BE7AC
	private BoneWeight[] GetBoneWeightsImpl() { }

	// RVA: 0x15BE7FC
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x15BE864
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x15BE8B4
	public void set_bindposes(Matrix4x4[] value) { }

	// RVA: 0x15BE91C
	public bool get_isReadable() { }

	// RVA: 0x15BE96C
	internal bool get_canAccess() { }

	// RVA: 0x15BE9BC
	public int get_vertexCount() { }

	// RVA: 0x15BEA0C
	public int get_subMeshCount() { }

	// RVA: 0x15BEA5C
	public void set_subMeshCount(int value) { }

	// RVA: 0x15BEAC4
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0x15BEB94
	private void SetAllSubMeshesAtOnceFromArray(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags) { }

	// RVA: 0x15BEC04
	public Bounds get_bounds() { }

	// RVA: 0x15BECE0
	public void set_bounds(Bounds value) { }

	// RVA: 0x15BEDB0
	private void ClearImpl(bool keepVertexLayout) { }

	// RVA: 0x15BEE18
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	// RVA: 0x15BEE80
	private void MarkDynamicImpl() { }

	// RVA: 0x15BEED0
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	// RVA: 0x15BEF38
	private MeshTopology GetTopologyImpl(int submesh) { }

	// RVA: 0x15BEFA0
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x15BF018
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1
	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: -1
	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	// RVA: 0x15BF0B8
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x315B3A8
	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags) { }

	// RVA: 0x315B3A8
	private void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags) { }

	// RVA: 0x315B3A8
	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x315B3A8
	private void SetListForChannel(VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1
	private void GetListForChannel(System.Collections.Generic.List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	// RVA: 0x315B3A8
	private void GetListForChannel(System.Collections.Generic.List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	// RVA: 0x15BF368
	public Vector3[] get_vertices() { }

	// RVA: 0x15BF3C0
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x15BF424
	public Vector3[] get_normals() { }

	// RVA: 0x15BF47C
	public void set_normals(Vector3[] value) { }

	// RVA: 0x15BF4E0
	public Vector4[] get_tangents() { }

	// RVA: 0x15BF538
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x15BF59C
	public Vector2[] get_uv() { }

	// RVA: 0x15BF5F4
	public void set_uv(Vector2[] value) { }

	// RVA: 0x15BF658
	public Vector2[] get_uv2() { }

	// RVA: 0x15BF6B0
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x15BF714
	public Color[] get_colors() { }

	// RVA: 0x15BF76C
	public void set_colors(Color[] value) { }

	// RVA: 0x15BF7D0
	public Color32[] get_colors32() { }

	// RVA: 0x15BF830
	public void set_colors32(Color32[] value) { }

	// RVA: 0x15BF89C
	public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices) { }

	// RVA: 0x15BF948
	public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length) { }

	// RVA: 0x15BF9C4
	public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15BFA4C
	public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals) { }

	// RVA: 0x15BFAF8
	public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length) { }

	// RVA: 0x15BFB74
	public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15BFBFC
	public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents) { }

	// RVA: 0x15BFCA8
	public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length) { }

	// RVA: 0x15BFD24
	public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15BFDAC
	public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors) { }

	// RVA: 0x15BFE70
	public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length) { }

	// RVA: 0x15BFF04
	public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x315B3A8
	private void SetUvsImpl(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15BFFA4
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs) { }

	// RVA: 0x15C00E4
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x15C0058
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length) { }

	// RVA: 0x15C0224
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x15C0198
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length) { }

	// RVA: 0x15C02B4
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x315B3A8
	private void GetUVsImpl(int uvIndex, System.Collections.Generic.List<T> uvs, int dim) { }

	// RVA: 0x15C0344
	public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x15C03B4
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x315B3A8
	public void SetVertexBufferData(T[] data, int dataStart, int meshBufferStart, int count, int stream, MeshUpdateFlags flags) { }

	// RVA: 0x15C040C
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x15C04B4
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x15C06B4
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x15C06BC
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x15C06C4
	public int[] get_triangles() { }

	// RVA: 0x15C080C
	public void set_triangles(int[] value) { }

	// RVA: 0x15C0A34
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x15C0AF0
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	// RVA: 0x15C0BB0
	public int[] GetIndices(int submesh) { }

	// RVA: 0x15C0C6C
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x315B3A8
	public void SetIndexBufferData(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags) { }

	// RVA: 0x15C0D2C
	public UInt32 GetIndexCount(int submesh) { }

	// RVA: 0x15C0E10
	public UInt32 GetBaseVertex(int submesh) { }

	// RVA: 0x15C0EF4
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x15C0988
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C109C
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x15C1160
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C1234
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C12FC
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int submesh) { }

	// RVA: 0x15C1380
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C1414
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C1520
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	// RVA: 0x15C16C0
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x15C15E8
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C1794
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C1878
	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C195C
	public void SetIndices(System.Collections.Generic.List<System.Int32> indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C1A04
	public void SetIndices(System.Collections.Generic.List<System.Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x15C1B38
	public void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags) { }

	// RVA: 0x15C1E34
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x15C1E84
	public void set_boneWeights(BoneWeight[] value) { }

	// RVA: 0x15C1EEC
	public void Clear() { }

	// RVA: 0x15C1F44
	public void RecalculateBounds() { }

	// RVA: 0x15C1F4C
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x15C208C
	public void MarkDynamic() { }

	// RVA: 0x15C2120
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x15C21D0
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x15BEB2C
	private void SetSubMesh_Injected(int index, SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0x15BEC78
	private void get_bounds_Injected(Bounds ret) { }

	// RVA: 0x15BED48
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

	// RVA: 0x15C22E8
	public float get_weight0() { }

	// RVA: 0x15C22F0
	public float get_weight1() { }

	// RVA: 0x15C22F8
	public float get_weight2() { }

	// RVA: 0x15C2300
	public float get_weight3() { }

	// RVA: 0x15C2308
	public int get_boneIndex0() { }

	// RVA: 0x15C2310
	public int get_boneIndex1() { }

	// RVA: 0x15C2318
	public int get_boneIndex2() { }

	// RVA: 0x15C2320
	public int get_boneIndex3() { }

	// RVA: 0x15C2328
	public override int GetHashCode() { }

	// RVA: 0x15C243C
	public override bool Equals(object other) { }

	// RVA: 0x15C24DC
	public bool Equals(BoneWeight other) { }

}

// Namespace: UnityEngine
public class Texture
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Methods

	// RVA: 0x15C25B8
	protected void .ctor() { }

	// RVA: 0x15C2640
	public int get_mipmapCount() { }

	// RVA: 0x15C2690
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	// RVA: 0x15C26F8
	private int GetDataWidth() { }

	// RVA: 0x15C2748
	private int GetDataHeight() { }

	// RVA: 0x15C2798
	public virtual int get_width() { }

	// RVA: 0x15C27E8
	public virtual void set_width(int value) { }

	// RVA: 0x15C2828
	public virtual int get_height() { }

	// RVA: 0x15C2878
	public virtual void set_height(int value) { }

	// RVA: 0x15C28B8
	public virtual bool get_isReadable() { }

	// RVA: 0x15C2908
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x15C2958
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x15C29C0
	public FilterMode get_filterMode() { }

	// RVA: 0x15C2A10
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x15C2A78
	public void set_mipMapBias(float value) { }

	// RVA: 0x15C2AE0
	public Vector2 get_texelSize() { }

	// RVA: 0x15C2BA0
	private int Internal_GetActiveTextureColorSpace() { }

	// RVA: 0x15C2BF0
	internal ColorSpace get_activeTextureColorSpace() { }

	// RVA: 0x15C2C3C
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	// RVA: 0x15C2C44
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	// RVA: 0x15C2CAC
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x15C2EA0
	internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x15C3070
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x15C3114
	internal UnityException CreateNativeArrayLengthOverflowException() { }

	// RVA: 0x15C318C
	private static void .cctor() { }

	// RVA: 0x15C2B38
	private void get_texelSize_Injected(Vector2 ret) { }

}

// Namespace: UnityEngine
public sealed class Texture2D
{
	// Fields
	internal const int streamingMipmapsPriorityMin = 4294967168;
	internal const int streamingMipmapsPriorityMax = 127;

	// Methods

	// RVA: 0x15C31DC
	public TextureFormat get_format() { }

	// RVA: 0x15C322C
	public void set_ignoreMipmapLimit(bool value) { }

	// RVA: 0x15C3294
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x15C32D4
	public void Compress(bool highQuality) { }

	// RVA: 0x15C333C
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x15C33DC
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x15C34D4
	public override bool get_isReadable() { }

	// RVA: 0x15C3524
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x15C357C
	private bool ReinitializeImpl(int width, int height) { }

	// RVA: 0x15C35D4
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	// RVA: 0x15C36DC
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	// RVA: 0x15C37E8
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	// RVA: 0x15C3858
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x15C3948
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	// RVA: 0x15C39E0
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x15C3A48
	private UInt64 GetRawImageDataSize() { }

	// RVA: 0x15C3A98
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x15C3AF0
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x15C3B58
	public Color32[] GetPixels32() { }

	// RVA: 0x15C3BB0
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x15C3C94
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x15C3DE0
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x15C3FA4
	public void .ctor(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C4060
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C4110
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x15C4330
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x15C435C
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x15C4428
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15C44E8
	public void .ctor(int width, int height) { }

	// RVA: 0x15C4590
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x15C465C
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x15C471C
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	// RVA: 0x15C47D8
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x315B3A8
	public Unity.Collections.NativeArray<T> GetRawTextureData() { }

	// RVA: 0x15C4888
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x15C4914
	public void Apply() { }

	// RVA: 0x15C49A8
	public bool Reinitialize(int width, int height) { }

	// RVA: 0x15C4A34
	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x15C4AA4
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x15C4B78
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x15C4C40
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x15C4C98
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x15C365C
	private void SetPixelImpl_Injected(int image, int mip, int x, int y, Color color) { }

	// RVA: 0x15C3768
	private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, Color ret) { }

	// RVA: 0x15C38D8
	private void ReadPixelsImpl_Injected(Rect source, int destX, int destY, bool recalculateMipMaps) { }

}

// Namespace: UnityEngine
public sealed class Cubemap
{
	// Methods

	// RVA: 0x15C4CEC
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x15C4D74
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x15C4E4C
	public override bool get_isReadable() { }

	// RVA: 0x15C4E9C
	internal bool ValidateFormat(TextureFormat format, int width) { }

	// RVA: 0x15C4F74
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	// RVA: 0x15C50AC
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C51D0
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15C5144
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C5220
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15C5478
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x15C5694
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15C5734
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x15C57D8
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x15C57E4
	public void .ctor(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	// RVA: 0x15C541C
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public sealed class Texture3D
{
	// Methods

	// RVA: 0x15C57F0
	public override bool get_isReadable() { }

	// RVA: 0x15C5840
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x15C58E0
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x15C59D8
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C5B2C
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15C5A88
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C5B94
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15C5DF8
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x15C5E1C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x15C5E3C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x15C6070
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15C6134
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x15C61FC
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x15C5D9C
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public sealed class Texture2DArray
{
	// Methods

	// RVA: 0x15C62C4
	public static int get_allSlices() { }

	// RVA: 0x15C6304
	public override bool get_isReadable() { }

	// RVA: 0x15C6354
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x15C63EC
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x15C64D4
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x15C65B8
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x15C6704
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C6858
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15C67B4
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C6AB0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15C6CB8
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x15C6F00
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x15C6F20
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x15C6FE8
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x15C70B0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15C6A54
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public sealed class CubemapArray
{
	// Methods

	// RVA: 0x15C7174
	public override bool get_isReadable() { }

	// RVA: 0x15C71C4
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x15C724C
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x15C7324
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C7468
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15C73CC
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x15C74C8
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x15C7730
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x15C7958
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x15C7960
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x15C7A18
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x15C7ACC
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x15C76D4
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

// Namespace: UnityEngine
public class RenderTexture
{
	// Methods

	// RVA: 0x15C7B74
	public override int get_width() { }

	// RVA: 0x15C7BC4
	public override void set_width(int value) { }

	// RVA: 0x15C7C2C
	public override int get_height() { }

	// RVA: 0x15C7C7C
	public override void set_height(int value) { }

	// RVA: 0x15C7CE4
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	// RVA: 0x15C7D4C
	private void SetColorFormat(GraphicsFormat format) { }

	// RVA: 0x15C7DB4
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x15C7E0C
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x15C7E74
	public void set_useMipMap(bool value) { }

	// RVA: 0x15C7EDC
	public RenderTextureFormat get_format() { }

	// RVA: 0x15C80A4
	public GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x15C80F4
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x15C815C
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x15C81C4
	private static RenderTexture GetActive() { }

	// RVA: 0x15C8204
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x15C8254
	public static RenderTexture get_active() { }

	// RVA: 0x15C8294
	public static void set_active(RenderTexture value) { }

	// RVA: 0x15C82E4
	private RenderBuffer GetColorBuffer() { }

	// RVA: 0x15C83A4
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x15C8464
	private void SetMipMapCount(int count) { }

	// RVA: 0x15B7068
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x15B70C0
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x15C84CC
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x15C8524
	public void DiscardContents() { }

	// RVA: 0x15C8584
	public bool Create() { }

	// RVA: 0x15C85D4
	public void Release() { }

	// RVA: 0x15C8624
	public bool IsCreated() { }

	// RVA: 0x15C8674
	internal void SetSRGBReadWrite(bool srgb) { }

	// RVA: 0x15C86DC
	private static void Internal_Create(RenderTexture rt) { }

	// RVA: 0x15C872C
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	// RVA: 0x15C8020
	private RenderTextureDescriptor GetDescriptor() { }

	// RVA: 0x15C8864
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	// RVA: 0x15C8904
	public static void ReleaseTemporary(RenderTexture temp) { }

	// RVA: 0x15C8954
	public int get_depth() { }

	// RVA: 0x15C89A4
	protected internal void .ctor() { }

	// RVA: 0x15C8A84
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x15C9054
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x15C9368
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x15C9830
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x15C98CC
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x15C953C
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x15C9CD4
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x15C9D70
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x15CA14C
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	// RVA: 0x15CA2F8
	public void .ctor(int width, int height, int depth) { }

	// RVA: 0x15CA1E8
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x15C9E90
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	// RVA: 0x15C9C18
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	// RVA: 0x15CA4D4
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	// RVA: 0x15CA644
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	// RVA: 0x15CA590
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	// RVA: 0x15C92D8
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x15C8BEC
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x15C9444
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	// RVA: 0x15C946C
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	// RVA: 0x15CA388
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x15CA700
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x15CA7AC
	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	// RVA: 0x15CA8AC
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	// RVA: 0x15CAA5C
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	// RVA: 0x15CAA7C
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x15CAAA0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x15CAAC8
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x15CAAF4
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x15CAB24
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	// RVA: 0x15CAB58
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x15C833C
	private void GetColorBuffer_Injected(RenderBuffer ret) { }

	// RVA: 0x15C83FC
	private void GetDepthBuffer_Injected(RenderBuffer ret) { }

	// RVA: 0x15C8794
	private void SetRenderTextureDescriptor_Injected(RenderTextureDescriptor desc) { }

	// RVA: 0x15C87FC
	private void GetDescriptor_Injected(RenderTextureDescriptor ret) { }

	// RVA: 0x15C88B4
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

	// RVA: 0x15CAB90
	public int get_width() { }

	// RVA: 0x15CAB98
	public void set_width(int value) { }

	// RVA: 0x15CABA0
	public int get_height() { }

	// RVA: 0x15CABA8
	public void set_height(int value) { }

	// RVA: 0x15CABB0
	public int get_msaaSamples() { }

	// RVA: 0x15CABB8
	public void set_msaaSamples(int value) { }

	// RVA: 0x15CABC0
	public int get_volumeDepth() { }

	// RVA: 0x15CABC8
	public void set_volumeDepth(int value) { }

	// RVA: 0x15CABD0
	public void set_mipCount(int value) { }

	// RVA: 0x15CABD8
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x15CABE0
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x15CAD9C
	public void set_stencilFormat(GraphicsFormat value) { }

	// RVA: 0x15CADA4
	public GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x15CADAC
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x15CADB4
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x15CAE48
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x15CAF38
	public bool get_sRGB() { }

	// RVA: 0x15CAFC8
	public void set_sRGB(bool value) { }

	// RVA: 0x15CACD8
	public int get_depthBufferBits() { }

	// RVA: 0x15CAD68
	public void set_depthBufferBits(int value) { }

	// RVA: 0x15CB138
	public TextureDimension get_dimension() { }

	// RVA: 0x15CB140
	public void set_dimension(TextureDimension value) { }

	// RVA: 0x15CB148
	public ShadowSamplingMode get_shadowSamplingMode() { }

	// RVA: 0x15CB150
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	// RVA: 0x15CB158
	public void set_vrUsage(VRTextureUsage value) { }

	// RVA: 0x15CB160
	public void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x15CB168
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x15CB230
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x15CACBC
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x15CB298
	public void set_useMipMap(bool value) { }

	// RVA: 0x15CB2AC
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x15CB2CC
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x15CB2EC
	public void set_bindMS(bool value) { }

	// RVA: 0x15CB30C
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x15CB32C
	public void set_useDynamicScale(bool value) { }

}

// Namespace: UnityEngine
public class Handheld
{
	// Methods

	// RVA: 0x15CB34C
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

	// RVA: 0x15CB38C
	public void .ctor(UInt64 u64_0, UInt64 u64_1) { }

	// RVA: 0x15CB394
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x15CB420
	public override string ToString() { }

	// RVA: 0x15CB4EC
	public static Hash128 Parse(string hashString) { }

	// RVA: 0x15CB488
	private static string Hash128ToStringImpl(Hash128 hash) { }

	// RVA: 0x15CB5FC
	public override bool Equals(object obj) { }

	// RVA: 0x15CB6A0
	public bool Equals(Hash128 obj) { }

	// RVA: 0x15CB6B4
	public override int GetHashCode() { }

	// RVA: 0x15CB6EC
	public int CompareTo(object obj) { }

	// RVA: 0x15CB690
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x15CB3E0
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x15CB3F8
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x15CB544
	private static void Parse_Injected(string hashString, Hash128 ret) { }

	// RVA: 0x15CB5AC
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

	// RVA: 0x15CB7C4
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x15CB880
	public static void set_visible(bool value) { }

	// RVA: 0x15CB8D0
	public static CursorLockMode get_lockState() { }

	// RVA: 0x15CB910
	public static void set_lockState(CursorLockMode value) { }

	// RVA: 0x15CB828
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

	// RVA: 0x15CB960
	public void .ctor(ILogHandler logHandler) { }

	// RVA: 0x15CB9A8
	public ILogHandler get_logHandler() { }

	// RVA: 0x15CB9B0
	public void set_logHandler(ILogHandler value) { }

	// RVA: 0x15CB9B8
	public bool get_logEnabled() { }

	// RVA: 0x15CB9C0
	public void set_logEnabled(bool value) { }

	// RVA: 0x15CB9C8
	public LogType get_filterLogType() { }

	// RVA: 0x15CB9D0
	public void set_filterLogType(LogType value) { }

	// RVA: 0x15CB9D8
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x15CBA0C
	private static string GetString(object message) { }

	// RVA: 0x15CBB40
	public void Log(LogType logType, object message) { }

	// RVA: 0x15CBCC0
	public void Log(LogType logType, object message, object context) { }

	// RVA: 0x15CBE50
	public void Log(LogType logType, string tag, object message) { }

	// RVA: 0x15CC014
	public void Log(string tag, object message) { }

	// RVA: 0x15CC1C0
	public void LogWarning(string tag, object message) { }

	// RVA: 0x15CC36C
	public void LogError(string tag, object message) { }

	// RVA: 0x15CC518
	public void LogException(Exception exception) { }

	// RVA: 0x15CC5EC
	public void LogException(Exception exception, object context) { }

	// RVA: 0x15CC6C4
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x15CC7C8
	public void LogFormat(LogType logType, object context, string format, object[] args) { }

}

// Namespace: UnityEngine
internal class UnityLogWriter
{
	// Methods

	// RVA: 0x15CC8D0
	public static void WriteStringToUnityLog(string s) { }

	// RVA: 0x15CC928
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x15CC978
	public static void Init() { }

	// RVA: 0x15CCB08
	public override Encoding get_Encoding() { }

	// RVA: 0x15CCB10
	public override void Write(Char value) { }

	// RVA: 0x15CCBEC
	public override void Write(string s) { }

	// RVA: 0x15CCC44
	public override void Write(Char[] buffer, int index, int count) { }

	// RVA: 0x15CCA80
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

	// RVA: 0x15CCCA0
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x15CCCAC
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x15CCCC0
	public override string ToString() { }

	// RVA: 0x15CCCD0
	public string ToString(string format) { }

	// RVA: 0x15CCCDC
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15CCF20
	public override int GetHashCode() { }

	// RVA: 0x15CCFA8
	public override bool Equals(object other) { }

	// RVA: 0x15CD08C
	public bool Equals(Color other) { }

	// RVA: 0x15CD11C
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x15CD130
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x15CD144
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x15CD158
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x15CD16C
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x15CD180
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x15CD1C4
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x15CD208
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x15CD258
	public static Color LerpUnclamped(Color a, Color b, float t) { }

	// RVA: 0x15CD290
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x15CD2AC
	public static Color get_red() { }

	// RVA: 0x15CD2C0
	public static Color get_green() { }

	// RVA: 0x15CD2D4
	public static Color get_blue() { }

	// RVA: 0x15CD2E8
	public static Color get_white() { }

	// RVA: 0x15CD2FC
	public static Color get_black() { }

	// RVA: 0x15CD310
	public static Color get_yellow() { }

	// RVA: 0x15CD334
	public static Color get_cyan() { }

	// RVA: 0x15CD348
	public static Color get_magenta() { }

	// RVA: 0x15CD35C
	public static Color get_gray() { }

	// RVA: 0x15CD370
	public static Color get_clear() { }

	// RVA: 0x15CD384
	public Color get_linear() { }

	// RVA: 0x15CD4C4
	public Color get_gamma() { }

	// RVA: 0x15CD604
	public float get_maxColorComponent() { }

	// RVA: 0x15CD620
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x15CD624
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x15CD628
	public static void RGBToHSV(Color rgbColor, float H, float S, float V) { }

	// RVA: 0x15CD76C
	private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, float H, float S, float V) { }

	// RVA: 0x15CD7DC
	public static Color HSVToRGB(float H, float S, float V) { }

	// RVA: 0x15CD914
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

	// RVA: 0x15CDA80
	public void .ctor(Byte r, Byte g, Byte b, Byte a) { }

	// RVA: 0x15CDA94
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x15CDD8C
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x15CDDC8
	public override string ToString() { }

	// RVA: 0x15CDFF8
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public class ColorUtility
{
	// Methods

	// RVA: 0x15CE210
	internal static bool DoTryParseHtmlColor(string htmlString, Color32 color) { }

	// RVA: 0x15CE278
	public static bool TryParseHtmlString(string htmlString, Color color) { }

	// RVA: 0x15CE32C
	public static string ToHtmlStringRGB(Color color) { }

	// RVA: 0x15CE7B4
	public static string ToHtmlStringRGBA(Color color) { }

}

// Namespace: UnityEngine
public class Gradient
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15CED84
	private static IntPtr Init() { }

	// RVA: 0x15CEDC4
	private void Cleanup() { }

	// RVA: 0x15CEE14
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x15CEE7C
	public void .ctor() { }

	// RVA: 0x15CEED8
	protected override void Finalize() { }

	// RVA: 0x15CEF90
	public Color Evaluate(float time) { }

	// RVA: 0x15CF05C
	public override bool Equals(object o) { }

	// RVA: 0x15CF214
	public bool Equals(Gradient other) { }

	// RVA: 0x15CF304
	public override int GetHashCode() { }

	// RVA: 0x15CEFFC
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

	// RVA: 0x15CF310
	private Quaternion GetRotation() { }

	// RVA: 0x15CF3D4
	private Vector3 GetLossyScale() { }

	// RVA: 0x15CF49C
	private float GetDeterminant() { }

	// RVA: 0x15CF53C
	public Quaternion get_rotation() { }

	// RVA: 0x15CF598
	public Vector3 get_lossyScale() { }

	// RVA: 0x15CF5F8
	public float get_determinant() { }

	// RVA: 0x15CF648
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x15CF744
	public static bool Inverse3DAffine(Matrix4x4 input, Matrix4x4 result) { }

	// RVA: 0x15CF814
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x15CF8F4
	public Matrix4x4 get_inverse() { }

	// RVA: 0x15CF978
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0x15CFA58
	public Matrix4x4 get_transpose() { }

	// RVA: 0x15CFADC
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x15CFC14
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	// RVA: 0x15CFD1C
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x15CFD38
	public float get_Item(int row, int column) { }

	// RVA: 0x15CFEAC
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x15CFD40
	public float get_Item(int index) { }

	// RVA: 0x15CFEB4
	public void set_Item(int index, float value) { }

	// RVA: 0x15D0020
	public override int GetHashCode() { }

	// RVA: 0x15D045C
	public override bool Equals(object other) { }

	// RVA: 0x15D06E8
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x15D0794
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x15D0838
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x15D01D0
	public Vector4 GetColumn(int index) { }

	// RVA: 0x15D086C
	public Vector4 GetRow(int index) { }

	// RVA: 0x15D0948
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x15D09C4
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x15D0A44
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x15D0AA0
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x15D0AEC
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x15D0B18
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x15D0B4C
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x15D0BE4
	public static Matrix4x4 get_identity() { }

	// RVA: 0x15D0C48
	public override string ToString() { }

	// RVA: 0x15D122C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15D1800
	private static void .cctor() { }

	// RVA: 0x15CF36C
	private static void GetRotation_Injected(Matrix4x4 _unity_self, Quaternion ret) { }

	// RVA: 0x15CF434
	private static void GetLossyScale_Injected(Matrix4x4 _unity_self, Vector3 ret) { }

	// RVA: 0x15CF4EC
	private static float GetDeterminant_Injected(Matrix4x4 _unity_self) { }

	// RVA: 0x15CF6DC
	private static void TRS_Injected(Vector3 pos, Quaternion q, Vector3 s, Matrix4x4 ret) { }

	// RVA: 0x15CF7AC
	private static bool Inverse3DAffine_Injected(Matrix4x4 input, Matrix4x4 result) { }

	// RVA: 0x15CF88C
	private static void Inverse_Injected(Matrix4x4 m, Matrix4x4 ret) { }

	// RVA: 0x15CF9F0
	private static void Transpose_Injected(Matrix4x4 m, Matrix4x4 ret) { }

	// RVA: 0x15CFB8C
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, Matrix4x4 ret) { }

	// RVA: 0x15CFCAC
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

	// RVA: 0x15D187C
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x15D1964
	private static void OrthoNormalize2(Vector3 a, Vector3 b) { }

	// RVA: 0x15D19CC
	public static void OrthoNormalize(Vector3 normal, Vector3 tangent) { }

	// RVA: 0x15D1A34
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x15D1A74
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x15D1A9C
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	// RVA: 0x15D1BBC
	public float get_Item(int index) { }

	// RVA: 0x15D1C48
	public void set_Item(int index, float value) { }

	// RVA: 0x15D1CD4
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x15D1CE0
	public void .ctor(float x, float y) { }

	// RVA: 0x15D1CEC
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x15D1CF8
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x15D1D08
	public void Scale(Vector3 scale) { }

	// RVA: 0x15D1D28
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15D1D58
	public override int GetHashCode() { }

	// RVA: 0x15D1DAC
	public override bool Equals(object other) { }

	// RVA: 0x15D1E5C
	public bool Equals(Vector3 other) { }

	// RVA: 0x15D1E8C
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x15D1EC4
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x15D1FCC
	public void Normalize() { }

	// RVA: 0x15D20D4
	public Vector3 get_normalized() { }

	// RVA: 0x15D21D8
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15D21F0
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x15D2304
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x15D23E0
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x15D250C
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x15D25B0
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x15D2670
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x15D26F4
	public float get_magnitude() { }

	// RVA: 0x15D2780
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x15D2798
	public float get_sqrMagnitude() { }

	// RVA: 0x15D27B8
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15D27D4
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15D27F0
	public static Vector3 get_zero() { }

	// RVA: 0x15D2840
	public static Vector3 get_one() { }

	// RVA: 0x15D2890
	public static Vector3 get_forward() { }

	// RVA: 0x15D28E0
	public static Vector3 get_back() { }

	// RVA: 0x15D2930
	public static Vector3 get_up() { }

	// RVA: 0x15D2980
	public static Vector3 get_down() { }

	// RVA: 0x15D29D0
	public static Vector3 get_left() { }

	// RVA: 0x15D2A20
	public static Vector3 get_right() { }

	// RVA: 0x15D2A70
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x15D2AC0
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x15D2AD0
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x15D2AE0
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x15D2AF0
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x15D2B00
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x15D2B14
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x15D2B24
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15D2B5C
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x15D2B94
	public override string ToString() { }

	// RVA: 0x15D2BA4
	public string ToString(string format) { }

	// RVA: 0x15D2BB0
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15D2DA8
	private static void .cctor() { }

	// RVA: 0x15D18FC
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

	// RVA: 0x15D2E38
	public static Quaternion Inverse(Quaternion rotation) { }

	// RVA: 0x15D2F00
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x15D2FE4
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x15D30C8
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x15D31AC
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	// RVA: 0x15D3274
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	// RVA: 0x15D3340
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	// RVA: 0x15D3410
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	// RVA: 0x15D34D4
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x15D3594
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x15D35A0
	public static Quaternion get_identity() { }

	// RVA: 0x15D35F0
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x15D3670
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x15D3714
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x15D372C
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x15D3760
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x15D3794
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x15D37B4
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x15D3820
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x15D38E0
	public Vector3 get_eulerAngles() { }

	// RVA: 0x15D3A18
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x15D3A94
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x15D3B0C
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x15D3B84
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x15D3CB8
	public static Quaternion Normalize(Quaternion q) { }

	// RVA: 0x15D3DA8
	public Quaternion get_normalized() { }

	// RVA: 0x15D3E90
	public override int GetHashCode() { }

	// RVA: 0x15D3EF8
	public override bool Equals(object other) { }

	// RVA: 0x15D3FDC
	public bool Equals(Quaternion other) { }

	// RVA: 0x15D406C
	public override string ToString() { }

	// RVA: 0x15D407C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15D42C0
	private static void .cctor() { }

	// RVA: 0x15D2E98
	private static void Inverse_Injected(Quaternion rotation, Quaternion ret) { }

	// RVA: 0x15D2F7C
	private static void Slerp_Injected(Quaternion a, Quaternion b, float t, Quaternion ret) { }

	// RVA: 0x15D3060
	private static void SlerpUnclamped_Injected(Quaternion a, Quaternion b, float t, Quaternion ret) { }

	// RVA: 0x15D3144
	private static void Lerp_Injected(Quaternion a, Quaternion b, float t, Quaternion ret) { }

	// RVA: 0x15D320C
	private static void Internal_FromEulerRad_Injected(Vector3 euler, Quaternion ret) { }

	// RVA: 0x15D32D8
	private static void Internal_ToEulerRad_Injected(Quaternion rotation, Vector3 ret) { }

	// RVA: 0x15D33B0
	private static void AngleAxis_Injected(float angle, Vector3 axis, Quaternion ret) { }

	// RVA: 0x15D347C
	private static void LookRotation_Injected(Vector3 forward, Vector3 upwards, Quaternion ret) { }

}

// Namespace: UnityEngine
public struct Mathf
{
	// Fields
	public static readonly float Epsilon; // 0x0

	// Methods

	// RVA: 0x15D4314
	public static int ClosestPowerOfTwo(int value) { }

	// RVA: 0x15D4364
	public static bool IsPowerOfTwo(int value) { }

	// RVA: 0x15D43B4
	public static int NextPowerOfTwo(int value) { }

	// RVA: 0x15CD46C
	public static float GammaToLinearSpace(float value) { }

	// RVA: 0x15CD5AC
	public static float LinearToGammaSpace(float value) { }

	// RVA: 0x15D4404
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	// RVA: 0x15D44D0
	public static float Sin(float f) { }

	// RVA: 0x15D4538
	public static float Cos(float f) { }

	// RVA: 0x15D45A0
	public static float Tan(float f) { }

	// RVA: 0x15D4608
	public static float Asin(float f) { }

	// RVA: 0x15D4670
	public static float Acos(float f) { }

	// RVA: 0x15D46D8
	public static float Atan(float f) { }

	// RVA: 0x15D4740
	public static float Atan2(float y, float x) { }

	// RVA: 0x15D47B0
	public static float Sqrt(float f) { }

	// RVA: 0x15D4830
	public static float Abs(float f) { }

	// RVA: 0x15D48B0
	public static int Abs(int value) { }

	// RVA: 0x15D4938
	public static float Min(float a, float b) { }

	// RVA: 0x15D4944
	public static int Min(int a, int b) { }

	// RVA: 0x15D4950
	public static float Max(float a, float b) { }

	// RVA: 0x15D495C
	public static float Max(float[] values) { }

	// RVA: 0x15D49B4
	public static int Max(int a, int b) { }

	// RVA: 0x15D49C0
	public static float Pow(float f, float p) { }

	// RVA: 0x15D4A34
	public static float Exp(float power) { }

	// RVA: 0x15D4A9C
	public static float Log(float f, float p) { }

	// RVA: 0x15D4B10
	public static float Log(float f) { }

	// RVA: 0x15D4B78
	public static float Log10(float f) { }

	// RVA: 0x15D4BE0
	public static float Ceil(float f) { }

	// RVA: 0x15D4C60
	public static float Floor(float f) { }

	// RVA: 0x15D4CE0
	public static float Round(float f) { }

	// RVA: 0x15D4E04
	public static int CeilToInt(float f) { }

	// RVA: 0x15D4E7C
	public static int FloorToInt(float f) { }

	// RVA: 0x15D4EF4
	public static int RoundToInt(float f) { }

	// RVA: 0x15D5004
	public static float Sign(float f) { }

	// RVA: 0x15D5018
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x15D502C
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x15D5040
	public static float Clamp01(float value) { }

	// RVA: 0x15D505C
	public static float Lerp(float a, float b, float t) { }

	// RVA: 0x15D5084
	public static float LerpUnclamped(float a, float b, float t) { }

	// RVA: 0x15D5094
	public static float LerpAngle(float a, float b, float t) { }

	// RVA: 0x15D5100
	public static float MoveTowards(float current, float target, float maxDelta) { }

	// RVA: 0x15D5124
	public static float SmoothStep(float from, float to, float t) { }

	// RVA: 0x15D516C
	public static bool Approximately(float a, float b) { }

	// RVA: 0x15D5204
	public static float SmoothDamp(float current, float target, float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x15D52E8
	public static float Repeat(float t, float length) { }

	// RVA: 0x15D5310
	public static float InverseLerp(float a, float b, float value) { }

	// RVA: 0x15D5348
	public static float DeltaAngle(float current, float target) { }

	// RVA: 0x15D5398
	internal static float ClampToFloat(Double value) { }

	// RVA: 0x15D5418
	internal static int ClampToInt(Int64 value) { }

	// RVA: 0x15D5434
	internal static UInt32 ClampToUInt(Int64 value) { }

	// RVA: 0x15D544C
	internal static int GetNumberOfDecimalsForMinimumDifference(Double minDifference) { }

	// RVA: 0x15D54DC
	internal static Double RoundBasedOnMinimumDifference(Double valueToRound, Double minDifference) { }

	// RVA: 0x15D55CC
	internal static Double DiscardLeastSignificantDecimal(Double v) { }

	// RVA: 0x15D5758
	private static void .cctor() { }

	// RVA: 0x15D4468
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

	// RVA: 0x15D57E4
	public float get_Item(int index) { }

	// RVA: 0x15D5858
	public void set_Item(int index, float value) { }

	// RVA: 0x15D58CC
	public void .ctor(float x, float y) { }

	// RVA: 0x15D58D4
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x15D5908
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x15D5924
	public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) { }

	// RVA: 0x15D59F8
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x15D5A04
	public void Normalize() { }

	// RVA: 0x15D5AFC
	public Vector2 get_normalized() { }

	// RVA: 0x15D5BE0
	public override string ToString() { }

	// RVA: 0x15D5BF0
	public string ToString(string format) { }

	// RVA: 0x15D5BFC
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15D5DA8
	public override int GetHashCode() { }

	// RVA: 0x15D5DE0
	public override bool Equals(object other) { }

	// RVA: 0x15D5E80
	public bool Equals(Vector2 other) { }

	// RVA: 0x15D5EA4
	public static Vector2 Perpendicular(Vector2 inDirection) { }

	// RVA: 0x15D5EB4
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15D5EC4
	public float get_magnitude() { }

	// RVA: 0x15D5F3C
	public float get_sqrMagnitude() { }

	// RVA: 0x15D5F50
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x15D6054
	public static float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x15D6170
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x15D61F8
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	// RVA: 0x15D6298
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15D62AC
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15D62C0
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x15D62CC
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x15D62D8
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x15D62E4
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x15D62F0
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x15D62FC
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x15D6308
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x15D6318
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x15D6324
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15D6350
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x15D637C
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x15D6380
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x15D6388
	public static Vector2 get_zero() { }

	// RVA: 0x15D63D4
	public static Vector2 get_one() { }

	// RVA: 0x15D6420
	public static Vector2 get_up() { }

	// RVA: 0x15D646C
	public static Vector2 get_down() { }

	// RVA: 0x15D64B8
	public static Vector2 get_left() { }

	// RVA: 0x15D6504
	public static Vector2 get_right() { }

	// RVA: 0x15D6550
	public static Vector2 get_negativeInfinity() { }

	// RVA: 0x15D659C
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

	// RVA: 0x15D660C
	public int get_x() { }

	// RVA: 0x15D6614
	public void set_x(int value) { }

	// RVA: 0x15D661C
	public int get_y() { }

	// RVA: 0x15D6624
	public void set_y(int value) { }

	// RVA: 0x15D662C
	public void .ctor(int x, int y) { }

	// RVA: 0x15D6634
	public float get_magnitude() { }

	// RVA: 0x15D664C
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x15D665C
	public static Vector2Int FloorToInt(Vector2 v) { }

	// RVA: 0x15D6748
	public static Vector2Int op_Subtraction(Vector2Int a, Vector2Int b) { }

	// RVA: 0x15D6760
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x15D676C
	public static bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x15D6778
	public override bool Equals(object other) { }

	// RVA: 0x15D6818
	public bool Equals(Vector2Int other) { }

	// RVA: 0x15D6840
	public override int GetHashCode() { }

	// RVA: 0x15D6894
	public override string ToString() { }

	// RVA: 0x15D6A48
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15D6BE4
	public static Vector2Int get_zero() { }

	// RVA: 0x15D6C30
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

	// RVA: 0x15D6CBC
	public int get_x() { }

	// RVA: 0x15D6CC4
	public void set_x(int value) { }

	// RVA: 0x15D6CCC
	public int get_y() { }

	// RVA: 0x15D6CD4
	public void set_y(int value) { }

	// RVA: 0x15D6CDC
	public int get_z() { }

	// RVA: 0x15D6CE4
	public void set_z(int value) { }

	// RVA: 0x15D6CEC
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x15D6CF8
	public static Vector3 op_Implicit(Vector3Int v) { }

	// RVA: 0x15D6D0C
	public static Vector3Int op_Subtraction(Vector3Int a, Vector3Int b) { }

	// RVA: 0x15D6D28
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x15D6D48
	public override bool Equals(object other) { }

	// RVA: 0x15D6DF4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x15D6E24
	public override int GetHashCode() { }

	// RVA: 0x15D6EA8
	public override string ToString() { }

	// RVA: 0x15D6EB8
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15D70A8
	public static Vector3Int get_zero() { }

	// RVA: 0x15D70F8
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

	// RVA: 0x15D7178
	public float get_Item(int index) { }

	// RVA: 0x15D7224
	public void set_Item(int index, float value) { }

	// RVA: 0x15D72D0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x15D72DC
	public void .ctor(float x, float y) { }

	// RVA: 0x15D72E8
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x15D7338
	public override int GetHashCode() { }

	// RVA: 0x15D73A0
	public override bool Equals(object other) { }

	// RVA: 0x15D7460
	public bool Equals(Vector4 other) { }

	// RVA: 0x15D749C
	public void Normalize() { }

	// RVA: 0x15D75B0
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x15D75D0
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x15D7660
	public float get_sqrMagnitude() { }

	// RVA: 0x15D7688
	public static Vector4 get_zero() { }

	// RVA: 0x15D76D8
	public static Vector4 get_one() { }

	// RVA: 0x15D7728
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x15D773C
	public static Vector4 op_Subtraction(Vector4 a, Vector4 b) { }

	// RVA: 0x15D7750
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x15D7764
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x15D7778
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x15D77BC
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x15D7800
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x15D7808
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x15D780C
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x15D7818
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x15D781C
	public override string ToString() { }

	// RVA: 0x15D782C
	public string ToString(string format) { }

	// RVA: 0x15D7838
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x15D7A7C
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

	// RVA: 0x15D7AE0
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

	// RVA: 0x15D7B54
	public void Dispose() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ObjectDispatcher.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15D7D70
	private static void .cctor() { }

	// RVA: 0x15D7DDC
	public void .ctor() { }

	// RVA: 0x15D7DE4
	internal void <.cctor>b__54_0(object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, System.Action<UnityEngine.TypeDispatchData> callback) { }

	// RVA: 0x15D7EE4
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

	// RVA: 0x15D7C28
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal class NumericFieldDraggerUtility
{
	// Fields
	private static bool s_UseYSign; // 0x0

	// Methods

	// RVA: 0x15D80E0
	internal static float Acceleration(bool shiftPressed, bool altPressed) { }

	// RVA: 0x15D8104
	internal static float NiceDelta(Vector2 deviceDelta, float acceleration) { }

	// RVA: 0x15D82B4
	internal static Double CalculateFloatDragSensitivity(Double value) { }

	// RVA: 0x15D8374
	internal static Double CalculateFloatDragSensitivity(Double value, Double minValue, Double maxValue) { }

	// RVA: 0x15D8438
	internal static Int64 CalculateIntDragSensitivity(Int64 value) { }

	// RVA: 0x15D8558
	internal static UInt64 CalculateIntDragSensitivity(UInt64 value) { }

	// RVA: 0x15D84D8
	private static Double CalculateIntDragSensitivity(Double value) { }

	// RVA: 0x15D85EC
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

	// RVA: 0x15D8694
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x15D8818
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x15D899C
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x15D8A1C
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x15D8B0C
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x15D8BFC
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x15D8C7C
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x15D8CFC
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	// RVA: 0x15D8CBC
	private static bool IsConnected() { }

	// RVA: 0x15D8C3C
	private static void Initialize() { }

	// RVA: 0x15D8ABC
	private static void RegisterInternal(string messageId) { }

	// RVA: 0x15D8BAC
	private static void UnregisterInternal(string messageId) { }

	// RVA: 0x15D87C0
	private static void SendMessage(string messageId, Byte[] data, int playerId) { }

	// RVA: 0x15D8944
	private static bool TrySendMessage(string messageId, Byte[] data, int playerId) { }

	// RVA: 0x15D89DC
	private static void PollInternal() { }

	// RVA: 0x15D8D3C
	private static void DisconnectAll() { }

	// RVA: 0x15D8D7C
	public void .ctor() { }

}

// Namespace: UnityEngine
public class PlayerPrefsException
{
	// Methods

	// RVA: 0x15D8D84
	public void .ctor(string error) { }

}

// Namespace: UnityEngine
public class PlayerPrefs
{
	// Methods

	// RVA: 0x15D8DF0
	private static bool TrySetInt(string key, int value) { }

	// RVA: 0x15D8E58
	private static bool TrySetFloat(string key, float value) { }

	// RVA: 0x15D8EC0
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x15D8F28
	public static void SetInt(string key, int value) { }

	// RVA: 0x15D8FC4
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x15D902C
	public static int GetInt(string key) { }

	// RVA: 0x15D9084
	public static void SetFloat(string key, float value) { }

	// RVA: 0x15D9120
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x15D9188
	public static void SetString(string key, string value) { }

	// RVA: 0x15D9224
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x15D928C
	public static string GetString(string key) { }

	// RVA: 0x15D932C
	public static bool HasKey(string key) { }

	// RVA: 0x15D937C
	public static void DeleteKey(string key) { }

	// RVA: 0x15D93CC
	public static void DeleteAll() { }

	// RVA: 0x15D940C
	public static void Save() { }

}

// Namespace: UnityEngine
public abstract class PropertyAttribute
{
	// Fields
	private int <order>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15D944C
	public void set_order(int value) { }

	// RVA: 0x15D9454
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

	// RVA: 0x15D945C
	public void .ctor(string tooltip) { }

}

// Namespace: UnityEngine
public class SpaceAttribute
{
	// Fields
	public readonly float height; // 0x14

	// Methods

	// RVA: 0x15D9490
	public void .ctor() { }

	// RVA: 0x15D94BC
	public void .ctor(float height) { }

}

// Namespace: UnityEngine
public class HeaderAttribute
{
	// Fields
	public readonly string header; // 0x18

	// Methods

	// RVA: 0x15D94F0
	public void .ctor(string header) { }

}

// Namespace: UnityEngine
public sealed class RangeAttribute
{
	// Fields
	public readonly float min; // 0x14
	public readonly float max; // 0x18

	// Methods

	// RVA: 0x15D9524
	public void .ctor(float min, float max) { }

}

// Namespace: UnityEngine
public sealed class MinAttribute
{
	// Fields
	public readonly float min; // 0x14

	// Methods

	// RVA: 0x15D955C
	public void .ctor(float min) { }

}

// Namespace: UnityEngine
public sealed class MultilineAttribute
{
	// Fields
	public readonly int lines; // 0x14

	// Methods

	// RVA: 0x15D9590
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class TextAreaAttribute
{
	// Fields
	public readonly int minLines; // 0x14
	public readonly int maxLines; // 0x18

	// Methods

	// RVA: 0x15D95BC
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

	// RVA: 0x15D95F4
	public void .ctor(bool showAlpha, bool hdr) { }

}

// Namespace: UnityEngine
public sealed class GradientUsageAttribute
{
	// Fields
	public readonly bool hdr; // 0x14
	public readonly ColorSpace colorSpace; // 0x18

	// Methods

	// RVA: 0x15D9644
	public void .ctor(bool hdr) { }

}

// Namespace: UnityEngine
internal class PropertyNameUtils
{
	// Methods

	// RVA: 0x15D967C
	public static PropertyName PropertyNameFromString(string name) { }

	// RVA: 0x15D96D4
	private static void PropertyNameFromString_Injected(string name, PropertyName ret) { }

}

// Namespace: UnityEngine
public struct PropertyName
{
	// Fields
	internal int id; // 0x10

	// Methods

	// RVA: 0x15D973C
	public void .ctor(string name) { }

	// RVA: 0x15D97A4
	public void .ctor(PropertyName other) { }

	// RVA: 0x15D97AC
	public static bool IsNullOrEmpty(PropertyName prop) { }

	// RVA: 0x15D97B8
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	// RVA: 0x15D97C4
	public override int GetHashCode() { }

	// RVA: 0x15D97CC
	public override bool Equals(object other) { }

	// RVA: 0x15D985C
	public bool Equals(PropertyName other) { }

	// RVA: 0x15D986C
	public static PropertyName op_Implicit(string name) { }

	// RVA: 0x15D98C4
	public override string ToString() { }

}

// Namespace: UnityEngine
public static class Random
{
	// Methods

	// RVA: 0x15D9950
	public static float Range(float minInclusive, float maxInclusive) { }

	// RVA: 0x15D99B4
	public static int Range(int minInclusive, int maxExclusive) { }

	// RVA: 0x15D9A1C
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	// RVA: 0x15D9A84
	public static float get_value() { }

	// RVA: 0x15D9AC4
	public static Vector3 get_insideUnitSphere() { }

	// RVA: 0x15D9B6C
	public static Vector3 get_onUnitSphere() { }

	// RVA: 0x15D9B1C
	private static void get_insideUnitSphere_Injected(Vector3 ret) { }

	// RVA: 0x15D9BC4
	private static void get_onUnitSphere_Injected(Vector3 ret) { }

}

// Namespace: UnityEngine
public class ResourceRequest
{
	// Fields
	internal string m_Path; // 0x20
	internal Type m_Type; // 0x28

	// Methods

	// RVA: 0x15D9C14
	protected virtual object GetResult() { }

	// RVA: 0x15D9D30
	public void .ctor() { }

}

// Namespace: UnityEngine
internal static class ResourcesAPIInternal
{
	// Methods

	// RVA: 0x15D9D40
	public static object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x15D9D90
	public static Shader FindShaderByName(string name) { }

	// RVA: 0x15D9DE0
	public static object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x15D9E48
	public static void UnloadAsset(object assetToUnload) { }

}

// Namespace: UnityEngine
public class ResourcesAPI
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Methods

	// RVA: 0x15D9E98
	internal static ResourcesAPI get_ActiveAPI() { }

	// RVA: 0x15D9F98
	public static ResourcesAPI get_overrideAPI() { }

	// RVA: 0x15DA014
	protected internal void .ctor() { }

	// RVA: 0x15DA01C
	protected internal virtual object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x15DA06C
	protected internal virtual Shader FindShaderByName(string name) { }

	// RVA: 0x15DA0BC
	protected internal virtual object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x15DA124
	protected internal virtual void UnloadAsset(object assetToUnload) { }

	// RVA: 0x15DA174
	private static void .cctor() { }

}

// Namespace: UnityEngine
public sealed class Resources
{
	// Methods

	// RVA: 0x30A52D0
	internal static T[] ConvertObjects(object[] rawObjects) { }

	// RVA: 0x15DA1E0
	public static object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x30A5298
	public static T[] FindObjectsOfTypeAll() { }

	// RVA: 0x15DA268
	public static object Load(string path) { }

	// RVA: 0x315B3A8
	public static T Load(string path) { }

	// RVA: 0x15D9CA0
	public static object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x15DA354
	public static object GetBuiltinResource(Type type, string path) { }

	// RVA: 0x315B3A8
	public static T GetBuiltinResource(string path) { }

	// RVA: 0x15DA3BC
	public static void UnloadAsset(object assetToUnload) { }

	// RVA: 0x15DA444
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

	// RVA: 0x15DA484
	public static void SetAsyncInstantiateOperationResult(AsyncInstantiateOperation op, object[] result) { }

}

// Namespace: UnityEngine
public class AsyncOperation
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private System.Action<UnityEngine.AsyncOperation> m_completeCallback; // 0x18

	// Methods

	// RVA: 0x15DA4A0
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x15DA4F0
	public bool get_isDone() { }

	// RVA: 0x15DA540
	public float get_progress() { }

	// RVA: 0x15DA590
	protected override void Finalize() { }

	// RVA: 0x15DA648
	internal void InvokeCompletionEvent() { }

	// RVA: 0x15D9D38
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

	// RVA: 0x15DA69C
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	// RVA: 0x15DA7E0
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x15DAC98
	private static int GetExecuteMode(Type klass) { }

	// RVA: 0x15DADE0
	private static int CheckIsEditorScript(Type klass) { }

	// RVA: 0x15DAF30
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: 0x315B3A8
	private static T GetCustomAttributeOfType(Type klass) { }

	// RVA: 0x15DAFE4
	private static void .cctor() { }

}

// Namespace: UnityEngine
public sealed class DisallowMultipleComponent
{
	// Methods

	// RVA: 0x15DB0D4
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

	// RVA: 0x15DB0DC
	public void .ctor(Type requiredComponent) { }

	// RVA: 0x15DB110
	public void .ctor(Type requiredComponent, Type requiredComponent2) { }

}

// Namespace: UnityEngine
public sealed class AddComponentMenu
{
	// Fields
	private string m_AddComponentMenu; // 0x10
	private int m_Ordering; // 0x18

	// Methods

	// RVA: 0x15DB160
	public void .ctor(string menuName) { }

	// RVA: 0x15DB19C
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

	// RVA: 0x15DB1E4
	public void set_menuName(string value) { }

	// RVA: 0x15DB1EC
	public void set_fileName(string value) { }

	// RVA: 0x15DB1F4
	public void set_order(int value) { }

	// RVA: 0x15DB1FC
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

	// RVA: 0x15DB204
	public void .ctor(string itemName) { }

	// RVA: 0x15DB24C
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x15DB2A0
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

// Namespace: UnityEngine
public sealed class ExecuteInEditMode
{
	// Methods

	// RVA: 0x15DB2F0
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ExecuteAlways
{
	// Methods

	// RVA: 0x15DB2F8
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class HideInInspector
{
	// Methods

	// RVA: 0x15DB300
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

	// RVA: 0x15DB308
	public void .ctor(string url) { }

}

// Namespace: UnityEngine
public class DefaultExecutionOrder
{
	// Fields
	private int m_Order; // 0x10

	// Methods

	// RVA: 0x15DB388
	public void .ctor(int order) { }

	// RVA: 0x15DAFDC
	public int get_order() { }

}

// Namespace: UnityEngine
public class AssemblyIsEditorAssembly
{}

// Namespace: UnityEngine
public class ExcludeFromPresetAttribute
{
	// Methods

	// RVA: 0x15DB3B4
	public void .ctor() { }

}

// Namespace: UnityEngine
public class Behaviour
{
	// Methods

	// RVA: 0x15DB3BC
	public bool get_enabled() { }

	// RVA: 0x15DB40C
	public void set_enabled(bool value) { }

	// RVA: 0x15DB474
	public bool get_isActiveAndEnabled() { }

	// RVA: 0x15DB4C4
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

	// RVA: 0x15DB848
	private static void .cctor() { }

	// RVA: 0x15DB8B4
	public void .ctor() { }

	// RVA: 0x15DB8BC
	internal Assembly <InitAssemblyRedirections>b__2_0(object _, ResolveEventArgs args) { }

}

// Namespace: UnityEngine
internal static class ClassLibraryInitializer
{
	// Methods

	// RVA: 0x15DB5D4
	private static void Init() { }

	// RVA: 0x15DB5D8
	private static void InitStdErrWithHandle(IntPtr fileHandle) { }

	// RVA: 0x15DB728
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

	// RVA: 0x15DB9DC
	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	// RVA: 0x15DBA00
	public override string ToString() { }

	// RVA: 0x15DBBE0
	public override bool Equals(object other) { }

	// RVA: 0x15DBCA0
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

	// RVA: 0x15DBD58
	public override bool Equals(object other) { }

	// RVA: 0x15DBE34
	public override int GetHashCode() { }

	// RVA: 0x15DBED8
	public override string ToString() { }

}

// Namespace: UnityEngine
public class Component
{
	// Methods

	// RVA: 0x15DC0B4
	public Transform get_transform() { }

	// RVA: 0x15DC104
	public GameObject get_gameObject() { }

	// RVA: 0x15DC154
	public Component GetComponent(Type type) { }

	// RVA: 0x15DC258
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x315B3A8
	public T GetComponent() { }

	// RVA: 0x15DC2B0
	public bool TryGetComponent(Type type, Component component) { }

	// RVA: 0x30A1344
	public bool TryGetComponent(T component) { }

	// RVA: 0x15DC454
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: 0x315B3A8
	public T GetComponentInChildren(bool includeInactive) { }

	// RVA: 0x315B3A8
	public T GetComponentInChildren() { }

	// RVA: -1
	public T[] GetComponentsInChildren(bool includeInactive) { }

	// RVA: -1
	public void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> result) { }

	// RVA: 0x30A17DC
	public T[] GetComponentsInChildren() { }

	// RVA: 0x30A27C0
	public void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }

	// RVA: 0x15DC538
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	// RVA: 0x315B3A8
	public T GetComponentInParent() { }

	// RVA: -1
	public T[] GetComponentsInParent(bool includeInactive) { }

	// RVA: -1
	public void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: 0x30A17DC
	public T[] GetComponentsInParent() { }

	// RVA: 0x15DC61C
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x15DC674
	public void GetComponents(Type type, System.Collections.Generic.List<UnityEngine.Component> results) { }

	// RVA: 0x30A27C0
	public void GetComponents(System.Collections.Generic.List<T> results) { }

	// RVA: 0x30A17DC
	public T[] GetComponents() { }

	// RVA: 0x15DC6CC
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x15DC734
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	// RVA: 0x15DB54C
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class Coroutine
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15DC79C
	private void .ctor() { }

	// RVA: 0x15DC7A4
	protected override void Finalize() { }

	// RVA: 0x15DC85C
	private static void ReleaseCoroutine(IntPtr ptr) { }

}

// Namespace: UnityEngine
internal class SetupCoroutine
{
	// Methods

	// RVA: 0x15DC8AC
	public static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) { }

	// RVA: 0x15DC9E0
	public static object InvokeMember(object behaviour, string name, object variable) { }

}

// Namespace: UnityEngine
public abstract class CustomYieldInstruction
{
	// Methods

	// RVA: -1
	public abstract bool get_keepWaiting() { }

	// RVA: 0x15DCAE4
	public object get_Current() { }

	// RVA: 0x15DCAEC
	public bool MoveNext() { }

	// RVA: 0x15DCAF8
	public virtual void Reset() { }

	// RVA: 0x15DCAFC
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

	// RVA: 0x15DE988
	private static void .cctor() { }

	// RVA: 0x15DE9F4
	public void .ctor() { }

	// RVA: 0x15DE9FC
	internal int <GetCachedEnumData>b__2_5(FieldInfo f) { }

	// RVA: 0x15DEA28
	internal string <GetCachedEnumData>b__2_1(FieldInfo f) { }

	// RVA: 0x15DEAA8
	internal Enum <GetCachedEnumData>b__2_2(FieldInfo f) { }

	// RVA: 0x15DEB40
	internal int <GetCachedEnumData>b__2_3(Enum v) { }

	// RVA: 0x15DEBA8
	internal int <GetCachedEnumData>b__2_4(Enum v) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public System.Func<System.String,System.String> nicifyName; // 0x10

	// Methods

	// RVA: 0x15DDC0C
	public void .ctor() { }

	// RVA: 0x15DEC10
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

	// RVA: 0x15DCB04
	public static EnumData GetCachedEnumData(Type enumType, CachedType cachedType, System.Func<System.String,System.String> nicifyName) { }

	// RVA: 0x15DDD9C
	internal static void HandleInspectorOrderAttribute(Type enumType, EnumData enumData) { }

	// RVA: 0x15DDC14
	private static bool CheckObsoleteAddition(FieldInfo field, CachedType cachedType) { }

	// RVA: 0x15DE408
	private static string EnumTooltipFromEnumField(FieldInfo field) { }

	// RVA: 0x15DE58C
	private static string EnumNameFromEnumField(FieldInfo field, System.Func<System.String,System.String> nicifyName) { }

	// RVA: 0x15DE8EC
	private static void .cctor() { }

	// RVA: 0x15DE878
	internal static string <EnumNameFromEnumField>g__NicifyName|8_0(UnityEngine.EnumDataUtility.<>c__DisplayClass8_0& ) { }

}

// Namespace: UnityEngine
public class ExcludeFromObjectFactoryAttribute
{
	// Methods

	// RVA: 0x15DECA4
	public void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class ExtensionOfNativeClassAttribute
{
	// Methods

	// RVA: 0x15DECAC
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class FailedToLoadScriptObject
{}

// Namespace: UnityEngine
public sealed class GameObject
{
	// Methods

	// RVA: 0x15DECB4
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: 0x315B3A8
	public T GetComponent() { }

	// RVA: 0x15DC1F0
	public Component GetComponent(Type type) { }

	// RVA: 0x15DED04
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x15DC4E0
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	// RVA: 0x315B3A8
	public T GetComponentInChildren() { }

	// RVA: 0x315B3A8
	public T GetComponentInChildren(bool includeInactive) { }

	// RVA: 0x15DC5C4
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	// RVA: 0x315B3A8
	public T GetComponentInParent() { }

	// RVA: 0x315B3A8
	public T GetComponentInParent(bool includeInactive) { }

	// RVA: 0x15DED5C
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x30A17DC
	public T[] GetComponents() { }

	// RVA: 0x30A27C0
	public void GetComponents(System.Collections.Generic.List<T> results) { }

	// RVA: -1
	public T[] GetComponentsInChildren(bool includeInactive) { }

	// RVA: -1
	public void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: 0x30A17DC
	public T[] GetComponentsInChildren() { }

	// RVA: 0x30A27C0
	public void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }

	// RVA: -1
	public void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: -1
	public T[] GetComponentsInParent(bool includeInactive) { }

	// RVA: 0x30A1344
	public bool TryGetComponent(T component) { }

	// RVA: 0x15DC39C
	public bool TryGetComponent(Type type, Component component) { }

	// RVA: 0x15DEDE4
	internal Component TryGetComponentInternal(Type type) { }

	// RVA: 0x15DEE4C
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x15DEEA4
	private Component Internal_AddComponentWithType(Type componentType) { }

	// RVA: 0x15DEF0C
	public Component AddComponent(Type componentType) { }

	// RVA: 0x315B3A8
	public T AddComponent() { }

	// RVA: 0x15DEF74
	public Transform get_transform() { }

	// RVA: 0x15DEFC4
	public int get_layer() { }

	// RVA: 0x15DF014
	public void set_layer(int value) { }

	// RVA: 0x15DF07C
	public void SetActive(bool value) { }

	// RVA: 0x15DF0E4
	public bool get_activeSelf() { }

	// RVA: 0x15DF134
	public bool get_activeInHierarchy() { }

	// RVA: 0x15DF184
	public bool get_isStatic() { }

	// RVA: 0x15DF1D4
	public void set_tag(string value) { }

	// RVA: 0x15DF23C
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x15DF2A4
	public void .ctor(string name) { }

	// RVA: 0x15DF3DC
	public void .ctor() { }

	// RVA: 0x15DF4A8
	public void .ctor(string name, Type[] components) { }

	// RVA: 0x15DF374
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	// RVA: 0x15DF5F0
	public static GameObject Find(string name) { }

	// RVA: 0x15DF640
	public Scene get_scene() { }

	// RVA: 0x15DF700
	public GameObject get_gameObject() { }

	// RVA: 0x15DF698
	private void get_scene_Injected(Scene ret) { }

}

// Namespace: UnityEngine
public sealed class InspectorOrderAttribute
{
	// Fields
	private InspectorSort <m_inspectorSort>k__BackingField; // 0x14
	private InspectorSortDirection <m_sortDirection>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15DF704
	internal InspectorSort get_m_inspectorSort() { }

	// RVA: 0x15DF70C
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

	// RVA: 0x15DF714
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x15DF718
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x15DF71C
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

	// RVA: 0x15DF76C
	internal static void ValidateLoadFromStream(Stream stream) { }

	// RVA: 0x15DF888
	internal static void ManagedStreamRead(Byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0x15DF978
	internal static void ManagedStreamSeek(Int64 offset, UInt32 origin, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0x15DFA58
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

}

// Namespace: UnityEngine
public class MonoBehaviour
{
	// Fields
	private CancellationTokenSource m_CancellationTokenSource; // 0x18

	// Methods

	// RVA: 0x15DFB1C
	public CancellationToken get_destroyCancellationToken() { }

	// RVA: 0x15DFE40
	private void RaiseCancellation() { }

	// RVA: 0x15DFE54
	public bool IsInvoking() { }

	// RVA: 0x15DFEF4
	public void CancelInvoke() { }

	// RVA: 0x15DFF94
	public void Invoke(string methodName, float time) { }

	// RVA: 0x15E0060
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x15E01A4
	public void CancelInvoke(string methodName) { }

	// RVA: 0x15E0274
	public bool IsInvoking(string methodName) { }

	// RVA: 0x15E0344
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x15E034C
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x15E0518
	public Coroutine StartCoroutine(IEnumerator routine) { }

	// RVA: 0x15E06A8
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x15E06AC
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x15E083C
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x15E09CC
	public void StopCoroutine(string methodName) { }

	// RVA: 0x15E0A34
	public void StopAllCoroutines() { }

	// RVA: 0x15E0A84
	public bool get_useGUILayout() { }

	// RVA: 0x15E0AD4
	public void set_useGUILayout(bool value) { }

	// RVA: 0x15E0B3C
	public static void print(object message) { }

	// RVA: 0x15DFF44
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	// RVA: 0x15DFEA4
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	// RVA: 0x15DFFF8
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	// RVA: 0x15E020C
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	// RVA: 0x15E02DC
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	// RVA: 0x15E0470
	private static bool IsObjectMonoBehaviour(object obj) { }

	// RVA: 0x15E04C0
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x15E0640
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x15E0964
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x15E07D4
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x15E0BC4
	internal string GetScriptClassName() { }

	// RVA: 0x15DFDF0
	private void OnCancellationTokenCreated() { }

	// RVA: 0x15E0C14
	public void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NoAllocHelpers
{
	// Methods

	// RVA: 0x30A7F58
	public static void ResizeList(System.Collections.Generic.List<T> list, int size) { }

	// RVA: 0x30A7F58
	public static void EnsureListElemCount(System.Collections.Generic.List<T> list, int count) { }

	// RVA: 0x15E0C1C
	public static int SafeLength(Array values) { }

	// RVA: 0x30A4388
	public static int SafeLength(System.Collections.Generic.List<T> values) { }

	// RVA: 0x30A52D0
	public static T[] ExtractArrayFromListT(System.Collections.Generic.List<T> list) { }

	// RVA: 0x15E0C2C
	internal static void Internal_ResizeList(object list, int size) { }

	// RVA: 0x15E0C94
	public static Array ExtractArrayFromList(object list) { }

}

// Namespace: UnityEngine
public struct RangeInt
{
	// Fields
	public int start; // 0x10
	public int length; // 0x14

	// Methods

	// RVA: 0x15E0CE4
	public int get_end() { }

	// RVA: 0x15E0CF0
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

	// RVA: 0x15E0CF8
	public void .ctor() { }

	// RVA: 0x15E0D30
	public void .ctor(RuntimeInitializeLoadType loadType) { }

	// RVA: 0x15E0D28
	private void set_loadType(RuntimeInitializeLoadType value) { }

}

// Namespace: UnityEngine
public class ScriptableObject
{
	// Methods

	// RVA: 0x15E0D5C
	public void .ctor() { }

	// RVA: 0x15E0E78
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: 0x315B3A8
	public static T CreateInstance() { }

	// RVA: 0x15E0E28
	private static void CreateScriptableObject(ScriptableObject self) { }

	// RVA: 0x15E0ED0
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

}

// Namespace: UnityEngine
internal class ScriptingRuntime
{
	// Methods

	// RVA: 0x15E0F38
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

	// RVA: 0x15E0F78
	private static bool IsManagedCodeWorking() { }

}

// Namespace: UnityEngine
public class SelectionBaseAttribute
{
	// Methods

	// RVA: 0x15E0F80
	public void .ctor() { }

}

// Namespace: UnityEngine
public static class StackTraceUtility
{
	// Fields
	private static string projectFolder; // 0x0

	// Methods

	// RVA: 0x15E0F88
	internal static void SetProjectFolder(string folder) { }

	// RVA: 0x15E109C
	public static string ExtractStackTrace() { }

	// RVA: 0x15E19A8
	internal static void ExtractStringFromExceptionInternal(object exceptiono, string message, string stackTrace) { }

	// RVA: 0x15E1228
	internal static string ExtractFormattedStackTrace(StackTrace stackTrace) { }

	// RVA: 0x15E1D34
	private static void .cctor() { }

}

// Namespace: UnityEngine
[Serializable]
public class UnityException
{
	// Methods

	// RVA: 0x15E1DAC
	public void .ctor() { }

	// RVA: 0x15E0128
	public void .ctor(string message) { }

	// RVA: 0x15E1E38
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: UnityEngine
[Serializable]
public class MissingComponentException
{
	// Methods

	// RVA: 0x15E1EBC
	public void .ctor() { }

	// RVA: 0x15E1F48
	public void .ctor(string message) { }

	// RVA: 0x15E1FC4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: UnityEngine
[Serializable]
public class MissingReferenceException
{
	// Methods

	// RVA: 0x15E2048
	public void .ctor() { }

	// RVA: 0x15DFD74
	public void .ctor(string message) { }

	// RVA: 0x15E20D4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
private static class EncodingUtility
{
	// Fields
	internal static readonly System.Collections.Generic.KeyValuePair<System.Byte[],System.Text.Encoding>[] encodingLookup; // 0x0
	internal static readonly Encoding targetEncoding; // 0x8

	// Methods

	// RVA: 0x15E26FC
	private static void .cctor() { }

}

// Namespace: UnityEngine
public class TextAsset
{
	// Methods

	// RVA: 0x15E2158
	public Byte[] get_bytes() { }

	// RVA: 0x15E21A8
	public string get_text() { }

	// RVA: 0x15E2650
	public override string ToString() { }

	// RVA: 0x15E2254
	internal static string DecodeString(Byte[] bytes) { }

}

// Namespace: UnityEngine
public class TrackedReference
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15E2AC8
	protected void .ctor() { }

	// RVA: 0x15E2AD0
	public static bool op_Equality(TrackedReference x, TrackedReference y) { }

	// RVA: 0x15E2B3C
	public static bool op_Inequality(TrackedReference x, TrackedReference y) { }

	// RVA: 0x15E2BC0
	public override bool Equals(object o) { }

	// RVA: 0x15E2CBC
	public override int GetHashCode() { }

	// RVA: 0x15E2CC8
	public static bool op_Implicit(TrackedReference exists) { }

}

// Namespace: UnityEngine
internal sealed class UnhandledExceptionHandler
{
	// Methods

	// RVA: 0x15E2CF0
	private static void RegisterUECatcher() { }

	// RVA: 0x15E2D88
	private static void HandleUnhandledException(object sender, UnhandledExceptionEventArgs args) { }

	// RVA: 0x15E2F50
	private static void PrintException(string title, Exception e) { }

	// RVA: 0x15E2FFC
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

	// RVA: 0x15E3054
	public int GetInstanceID() { }

	// RVA: 0x15E31E4
	public override int GetHashCode() { }

	// RVA: 0x15E31EC
	public override bool Equals(object other) { }

	// RVA: 0x15E3474
	public static bool op_Implicit(object exists) { }

	// RVA: 0x15E339C
	private static bool CompareBaseObjects(object lhs, object rhs) { }

	// RVA: 0x15E3540
	private static bool IsNativeObjectAlive(object o) { }

	// RVA: 0x15E3564
	private IntPtr GetCachedPtr() { }

	// RVA: 0x15E356C
	public string get_name() { }

	// RVA: 0x15E3668
	public void set_name(string value) { }

	// RVA: 0x15E3788
	public static object Instantiate(object original, Vector3 position, Quaternion rotation) { }

	// RVA: 0x15E3BA4
	public static object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x15E3FF0
	public static object Instantiate(object original) { }

	// RVA: 0x15E4224
	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x315B3A8
	public static T Instantiate(T original) { }

	// RVA: 0x315B3A8
	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	// RVA: 0x315B3A8
	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x315B3A8
	public static T Instantiate(T original, Transform parent) { }

	// RVA: 0x315B3A8
	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	// RVA: 0x15E453C
	public static void Destroy(object obj, float t) { }

	// RVA: 0x15E45A4
	public static void Destroy(object obj) { }

	// RVA: 0x15E4658
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	// RVA: 0x15E46C0
	public static void DestroyImmediate(object obj) { }

	// RVA: 0x15E4774
	public static object[] FindObjectsOfType(Type type) { }

	// RVA: 0x15E4828
	public static object[] FindObjectsOfType(Type type, bool includeInactive) { }

	// RVA: 0x15E4890
	public static object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	// RVA: 0x15E48E8
	public static void DontDestroyOnLoad(object target) { }

	// RVA: 0x15E4938
	public HideFlags get_hideFlags() { }

	// RVA: 0x15E4988
	public void set_hideFlags(HideFlags value) { }

	// RVA: 0x30A5298
	public static T[] FindObjectsOfType() { }

	// RVA: -1
	public static T[] FindObjectsByType(FindObjectsSortMode sortMode) { }

	// RVA: 0x315B3A8
	public static T FindObjectOfType() { }

	// RVA: 0x315B3A8
	public static T FindFirstObjectByType() { }

	// RVA: 0x15E3A94
	private static void CheckNullArgument(object arg, string message) { }

	// RVA: 0x15E49F0
	public static object FindObjectOfType(Type type) { }

	// RVA: 0x15E4AC8
	public static object FindObjectOfType(Type type, bool includeInactive) { }

	// RVA: 0x15E4BA4
	public static object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	// RVA: 0x15E4C90
	public override string ToString() { }

	// RVA: 0x15DFCE8
	public static bool op_Equality(object x, object y) { }

	// RVA: 0x15E4D8C
	public static bool op_Inequality(object x, object y) { }

	// RVA: 0x15E31A4
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	// RVA: 0x15E41D4
	private static object Internal_CloneSingle(object data) { }

	// RVA: 0x15E44E4
	private static object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	// RVA: 0x15E3AE4
	private static object Internal_InstantiateSingle(object data, Vector3 pos, Quaternion rot) { }

	// RVA: 0x15E3F28
	private static object Internal_InstantiateSingleWithParent(object data, Transform parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0x15E4D3C
	private static string ToString(object obj) { }

	// RVA: 0x15E3618
	private static string GetName(object obj) { }

	// RVA: 0x15E3720
	private static void SetName(object obj, string name) { }

	// RVA: 0x15E4EBC
	internal static object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x15E0E20
	public void .ctor() { }

	// RVA: 0x15E4F0C
	private static void .cctor() { }

	// RVA: 0x15E4DFC
	private static object Internal_InstantiateSingle_Injected(object data, Vector3 pos, Quaternion rot) { }

	// RVA: 0x15E4E54
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

	// RVA: 0x15E53CC
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x15E5838
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

	// RVA: 0x15E4F5C
	private void .ctor(int mainThreadID) { }

	// RVA: 0x15E502C
	private void .ctor(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x15E50E8
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x15E541C
	public override void OperationStarted() { }

	// RVA: 0x15E5428
	public override void OperationCompleted() { }

	// RVA: 0x15E5434
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x15E559C
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x15E560C
	public void Exec() { }

	// RVA: 0x15E591C
	private bool HasPendingTasks() { }

	// RVA: 0x15E5988
	private static void InitializeSynchronizationContext() { }

	// RVA: 0x15E5A00
	private static void ExecuteTasks() { }

	// RVA: 0x15E5A68
	private static bool ExecutePendingTasks(Int64 millisecondsTimeout) { }

}

// Namespace: UnityEngine
public sealed class WaitForEndOfFrame
{
	// Methods

	// RVA: 0x15E5BF0
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForFixedUpdate
{
	// Methods

	// RVA: 0x15E5C00
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForSeconds
{
	// Fields
	internal float m_Seconds; // 0x10

	// Methods

	// RVA: 0x15E5C08
	public void .ctor(float seconds) { }

}

// Namespace: UnityEngine
public class WaitForSecondsRealtime
{
	// Fields
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Methods

	// RVA: 0x15E5C3C
	public float get_waitTime() { }

	// RVA: 0x15E5C44
	public void set_waitTime(float value) { }

	// RVA: 0x15E5C4C
	public override bool get_keepWaiting() { }

	// RVA: 0x15E5D60
	public void .ctor(float time) { }

	// RVA: 0x15E5D9C
	public override void Reset() { }

}

// Namespace: UnityEngine
public class YieldInstruction
{
	// Methods

	// RVA: 0x15E5BF8
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializeField
{
	// Methods

	// RVA: 0x15E5DA8
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializeReference
{
	// Methods

	// RVA: 0x15E5DB0
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

	// RVA: 0x15E5DB8
	public int FindKernel(string name) { }

}

// Namespace: UnityEngine
public sealed class ShaderVariantCollection
{
	// Methods

	// RVA: 0x15E5E20
	public void WarmUp() { }

}

// Namespace: UnityEngine
internal class LowerResBlitTexture
{
	// Methods

	// RVA: 0x15E5E70
	internal void LowerResBlitTextureDontStripMe() { }

}

// Namespace: UnityEngine
internal class PreloadData
{
	// Methods

	// RVA: 0x15E5E74
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

	// RVA: 0x15E5E78
	public static float get_batteryLevel() { }

	// RVA: 0x15E5EF8
	public static BatteryStatus get_batteryStatus() { }

	// RVA: 0x15E5F78
	public static string get_operatingSystem() { }

	// RVA: 0x15E5FF8
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x15E6078
	public static string get_processorType() { }

	// RVA: 0x15E60F8
	public static int get_processorFrequency() { }

	// RVA: 0x15E6178
	public static int get_processorCount() { }

	// RVA: 0x15E61F8
	public static int get_systemMemorySize() { }

	// RVA: 0x15E6278
	public static string get_deviceUniqueIdentifier() { }

	// RVA: 0x15E62F8
	public static string get_deviceName() { }

	// RVA: 0x15E6378
	public static string get_deviceModel() { }

	// RVA: 0x15E63F8
	public static bool get_supportsAccelerometer() { }

	// RVA: 0x15E6478
	public static bool get_supportsGyroscope() { }

	// RVA: 0x15E64F8
	public static bool get_supportsLocationService() { }

	// RVA: 0x15E6578
	public static bool get_supportsVibration() { }

	// RVA: 0x15E65F8
	public static bool get_supportsAudio() { }

	// RVA: 0x15E6678
	public static DeviceType get_deviceType() { }

	// RVA: 0x15E66F8
	public static int get_graphicsMemorySize() { }

	// RVA: 0x15E6778
	public static string get_graphicsDeviceName() { }

	// RVA: 0x15E67F8
	public static string get_graphicsDeviceVendor() { }

	// RVA: 0x15E6878
	public static int get_graphicsDeviceID() { }

	// RVA: 0x15E68F8
	public static int get_graphicsDeviceVendorID() { }

	// RVA: 0x15E6978
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	// RVA: 0x15E69F8
	public static string get_graphicsDeviceVersion() { }

	// RVA: 0x15E6A78
	public static int get_graphicsShaderLevel() { }

	// RVA: 0x15E6AF8
	public static bool get_graphicsMultiThreaded() { }

	// RVA: 0x15E6B78
	public static bool get_supportsShadows() { }

	// RVA: 0x15E6BF8
	public static bool get_supportsRawShadowDepthSampling() { }

	// RVA: 0x15E6C78
	public static bool get_supports3DTextures() { }

	// RVA: 0x15E6CF8
	public static bool get_supports2DArrayTextures() { }

	// RVA: 0x15E6D78
	public static bool get_supports3DRenderTextures() { }

	// RVA: 0x15E6DF8
	public static bool get_supportsCubemapArrayTextures() { }

	// RVA: 0x15E6E78
	public static CopyTextureSupport get_copyTextureSupport() { }

	// RVA: 0x15E6EF8
	public static bool get_supportsComputeShaders() { }

	// RVA: 0x15E6F78
	public static bool get_supportsInstancing() { }

	// RVA: 0x15E6FF8
	public static bool get_supports32bitsIndexBuffer() { }

	// RVA: 0x15E7078
	public static bool get_supportsSparseTextures() { }

	// RVA: 0x15E70F8
	public static int get_supportedRenderTargetCount() { }

	// RVA: 0x15E7178
	private static bool IsValidEnumValue(Enum value) { }

	// RVA: 0x15E71F8
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x15E7384
	public static bool SupportsTextureFormat(TextureFormat format) { }

	// RVA: 0x15E7510
	public static NPOTSupport get_npotSupport() { }

	// RVA: 0x15E7590
	public static int get_maxTextureSize() { }

	// RVA: 0x15E7610
	internal static int get_maxRenderTextureSize() { }

	// RVA: 0x15E5EB8
	private static float GetBatteryLevel() { }

	// RVA: 0x15E5F38
	private static BatteryStatus GetBatteryStatus() { }

	// RVA: 0x15E5FB8
	private static string GetOperatingSystem() { }

	// RVA: 0x15E6038
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	// RVA: 0x15E60B8
	private static string GetProcessorType() { }

	// RVA: 0x15E6138
	private static int GetProcessorFrequencyMHz() { }

	// RVA: 0x15E61B8
	private static int GetProcessorCount() { }

	// RVA: 0x15E6238
	private static int GetPhysicalMemoryMB() { }

	// RVA: 0x15E62B8
	private static string GetDeviceUniqueIdentifier() { }

	// RVA: 0x15E6338
	private static string GetDeviceName() { }

	// RVA: 0x15E63B8
	private static string GetDeviceModel() { }

	// RVA: 0x15E6438
	private static bool SupportsAccelerometer() { }

	// RVA: 0x15E64B8
	private static bool IsGyroAvailable() { }

	// RVA: 0x15E6538
	private static bool SupportsLocationService() { }

	// RVA: 0x15E65B8
	private static bool SupportsVibration() { }

	// RVA: 0x15E6638
	private static bool SupportsAudio() { }

	// RVA: 0x15E66B8
	private static DeviceType GetDeviceType() { }

	// RVA: 0x15E6738
	private static int GetGraphicsMemorySize() { }

	// RVA: 0x15E67B8
	private static string GetGraphicsDeviceName() { }

	// RVA: 0x15E6838
	private static string GetGraphicsDeviceVendor() { }

	// RVA: 0x15E68B8
	private static int GetGraphicsDeviceID() { }

	// RVA: 0x15E6938
	private static int GetGraphicsDeviceVendorID() { }

	// RVA: 0x15E69B8
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	// RVA: 0x15E6A38
	private static string GetGraphicsDeviceVersion() { }

	// RVA: 0x15E6AB8
	private static int GetGraphicsShaderLevel() { }

	// RVA: 0x15E6B38
	private static bool GetGraphicsMultiThreaded() { }

	// RVA: 0x15E6BB8
	private static bool SupportsShadows() { }

	// RVA: 0x15E6C38
	private static bool SupportsRawShadowDepthSampling() { }

	// RVA: 0x15E6CB8
	private static bool Supports3DTextures() { }

	// RVA: 0x15E6D38
	private static bool Supports2DArrayTextures() { }

	// RVA: 0x15E6DB8
	private static bool Supports3DRenderTextures() { }

	// RVA: 0x15E6E38
	private static bool SupportsCubemapArrayTextures() { }

	// RVA: 0x15E6EB8
	private static CopyTextureSupport GetCopyTextureSupport() { }

	// RVA: 0x15E6F38
	private static bool SupportsComputeShaders() { }

	// RVA: 0x15E6FB8
	private static bool SupportsInstancing() { }

	// RVA: 0x15E7038
	private static bool Supports32bitsIndexBuffer() { }

	// RVA: 0x15E70B8
	private static bool SupportsSparseTextures() { }

	// RVA: 0x15E7138
	private static int SupportedRenderTargetCount() { }

	// RVA: 0x15E7334
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	// RVA: 0x15E74C0
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	// RVA: 0x15E7550
	private static NPOTSupport GetNPOTSupport() { }

	// RVA: 0x15E75D0
	private static int GetMaxTextureSize() { }

	// RVA: 0x15E7650
	private static int GetMaxRenderTextureSize() { }

	// RVA: 0x15E7690
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x15E76F8
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x15E7760
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

}

// Namespace: UnityEngine
internal class SystemClock
{
	// Fields
	private static readonly DateTime s_Epoch; // 0x0

	// Methods

	// RVA: 0x15E77B0
	public static DateTime get_now() { }

	// RVA: 0x15E7820
	private static void .cctor() { }

}

// Namespace: UnityEngine
public class Time
{
	// Methods

	// RVA: 0x15E78A0
	public static float get_time() { }

	// RVA: 0x15E78E0
	public static float get_timeSinceLevelLoad() { }

	// RVA: 0x15E7920
	public static float get_deltaTime() { }

	// RVA: 0x15E7960
	public static float get_unscaledTime() { }

	// RVA: 0x15E79A0
	public static float get_fixedUnscaledTime() { }

	// RVA: 0x15E79E0
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x15E7A20
	public static float get_fixedDeltaTime() { }

	// RVA: 0x15E7A60
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x15E7AB8
	public static float get_timeScale() { }

	// RVA: 0x15E7AF8
	public static void set_timeScale(float value) { }

	// RVA: 0x15E7B50
	public static int get_frameCount() { }

	// RVA: 0x15E7B90
	public static int get_renderedFrameCount() { }

	// RVA: 0x15E5D20
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

	// RVA: 0x15E7BD0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x15E7C20
	private void Destroy() { }

	// RVA: 0x15E7CEC
	protected override void Finalize() { }

	// RVA: 0x15E7E0C
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	// RVA: 0x15E7F68
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x15E7FC0
	public static bool get_isSupported() { }

	// RVA: 0x15E80A4
	internal static bool get_disableInPlaceEditing() { }

	// RVA: 0x15E80F0
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x15E813C
	internal static bool get_isRequiredToForceOpen() { }

	// RVA: 0x15E817C
	private static bool IsRequiredToForceOpen() { }

	// RVA: 0x15E81BC
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	// RVA: 0x15E8278
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	// RVA: 0x15E834C
	public string get_text() { }

	// RVA: 0x15E839C
	public void set_text(string value) { }

	// RVA: 0x15E8404
	public static void set_hideInput(bool value) { }

	// RVA: 0x15E8454
	public bool get_active() { }

	// RVA: 0x15E84A4
	public void set_active(bool value) { }

	// RVA: 0x15E850C
	public Status get_status() { }

	// RVA: 0x15E855C
	public void set_characterLimit(int value) { }

	// RVA: 0x15E85C4
	public bool get_canGetSelection() { }

	// RVA: 0x15E8614
	public bool get_canSetSelection() { }

	// RVA: 0x15E8664
	public RangeInt get_selection() { }

	// RVA: 0x15E8724
	public void set_selection(RangeInt value) { }

	// RVA: 0x15E86BC
	private static void GetSelection(int start, int length) { }

	// RVA: 0x15E8834
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

	// RVA: 0x15E889C
	public static bool TryConvertStringToDouble(string str, Double value, Expression expr) { }

	// RVA: 0x15E8A48
	public static bool TryConvertStringToDouble(string str, string initialValueAsString, Double value) { }

	// RVA: 0x15E8BAC
	public static bool TryConvertStringToFloat(string str, string initialValueAsString, float value) { }

	// RVA: 0x15E8C4C
	public static bool TryConvertStringToLong(string str, Int64 value, Expression expr) { }

	// RVA: 0x15E8CDC
	public static bool TryConvertStringToLong(string str, string initialValueAsString, Int64 value) { }

	// RVA: 0x15E8F04
	public static bool TryConvertStringToULong(string str, UInt64 value, Expression expr) { }

	// RVA: 0x15E8F94
	public static bool TryConvertStringToULong(string str, string initialValueAsString, UInt64 value) { }

	// RVA: 0x15E91BC
	public static bool TryConvertStringToInt(string str, string initialValueAsString, int value) { }

	// RVA: 0x15E925C
	public static bool TryConvertStringToUInt(string str, string initialValueAsString, UInt32 value) { }

	// RVA: 0x15E92FC
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

	// RVA: 0x15E9424
	public void Add(object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) { }

	// RVA: 0x15E9428
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

	// RVA: 0x15EAE24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15EAED8
	public virtual void Invoke(RectTransform driven) { }

}

// Namespace: UnityEngine
public sealed class RectTransform
{
	// Fields
	private static ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Methods

	// RVA: 0x15E942C
	public static void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0x15E94EC
	public static void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0x15E95AC
	public Rect get_rect() { }

	// RVA: 0x15E9670
	public Vector2 get_anchorMin() { }

	// RVA: 0x15E9730
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x15E97EC
	public Vector2 get_anchorMax() { }

	// RVA: 0x15E98AC
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x15E9968
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x15E9A28
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x15E9AE4
	public Vector2 get_sizeDelta() { }

	// RVA: 0x15E9BA4
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x15E9C60
	public Vector2 get_pivot() { }

	// RVA: 0x15E9D20
	public void set_pivot(Vector2 value) { }

	// RVA: 0x15E9DDC
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x15E9F60
	public Vector2 get_offsetMin() { }

	// RVA: 0x15EA034
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x15EA278
	public Vector2 get_offsetMax() { }

	// RVA: 0x15EA38C
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x15EA5D0
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x15EA6FC
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x15EA948
	public void SetSizeWithCurrentAnchors(Axis axis, float size) { }

	// RVA: 0x15EAD58
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x15EAB48
	private Vector2 GetParentSize() { }

	// RVA: 0x15E9608
	private void get_rect_Injected(Rect ret) { }

	// RVA: 0x15E96C8
	private void get_anchorMin_Injected(Vector2 ret) { }

	// RVA: 0x15E9784
	private void set_anchorMin_Injected(Vector2 value) { }

	// RVA: 0x15E9844
	private void get_anchorMax_Injected(Vector2 ret) { }

	// RVA: 0x15E9900
	private void set_anchorMax_Injected(Vector2 value) { }

	// RVA: 0x15E99C0
	private void get_anchoredPosition_Injected(Vector2 ret) { }

	// RVA: 0x15E9A7C
	private void set_anchoredPosition_Injected(Vector2 value) { }

	// RVA: 0x15E9B3C
	private void get_sizeDelta_Injected(Vector2 ret) { }

	// RVA: 0x15E9BF8
	private void set_sizeDelta_Injected(Vector2 value) { }

	// RVA: 0x15E9CB8
	private void get_pivot_Injected(Vector2 ret) { }

	// RVA: 0x15E9D74
	private void set_pivot_Injected(Vector2 value) { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Methods

	// RVA: 0x15ED0EC
	internal void .ctor(Transform outer) { }

	// RVA: 0x15ED190
	public object get_Current() { }

	// RVA: 0x15ED200
	public bool MoveNext() { }

	// RVA: 0x15ED26C
	public void Reset() { }

}

// Namespace: UnityEngine
public class Transform
{
	// Methods

	// RVA: 0x15EAEEC
	protected void .ctor() { }

	// RVA: 0x15EAEF4
	public Vector3 get_position() { }

	// RVA: 0x15EAFBC
	public void set_position(Vector3 value) { }

	// RVA: 0x15E9EA8
	public Vector3 get_localPosition() { }

	// RVA: 0x15E9F08
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x15EB14C
	public Vector3 get_eulerAngles() { }

	// RVA: 0x15EB22C
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x15EB30C
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x15EB3DC
	public Vector3 get_right() { }

	// RVA: 0x15EB498
	public Vector3 get_up() { }

	// RVA: 0x15EB554
	public Vector3 get_forward() { }

	// RVA: 0x15EB1D0
	public Quaternion get_rotation() { }

	// RVA: 0x15EB678
	public void set_rotation(Quaternion value) { }

	// RVA: 0x15EB2B0
	public Quaternion get_localRotation() { }

	// RVA: 0x15EB384
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x15EB808
	public Vector3 get_localScale() { }

	// RVA: 0x15EB8D0
	public void set_localScale(Vector3 value) { }

	// RVA: 0x15EADD4
	public Transform get_parent() { }

	// RVA: 0x15EB9E0
	public void set_parent(Transform value) { }

	// RVA: 0x15EB990
	internal Transform get_parentInternal() { }

	// RVA: 0x15EBAC8
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x15EBB1C
	private Transform GetParent() { }

	// RVA: 0x15EBB6C
	public void SetParent(Transform p) { }

	// RVA: 0x15EBBC0
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x15EBC18
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x15EA8D0
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x15EBD60
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x15EBE1C
	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0x15EBED8
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x15EC0B0
	public void Translate(float x, float y, float z) { }

	// RVA: 0x15EC0B8
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x15EC440
	public void Rotate(Vector3 eulers) { }

	// RVA: 0x15EC448
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	// RVA: 0x15EC450
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x15EC518
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x15EC63C
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x15EC044
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x15EC69C
	public Vector3 TransformDirection(float x, float y, float z) { }

	// RVA: 0x15EC708
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x15EC7CC
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x15EC890
	public Vector3 TransformVector(float x, float y, float z) { }

	// RVA: 0x15EC8FC
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x15EC9C0
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x15ECA84
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x15ECB48
	public Transform get_root() { }

	// RVA: 0x15ECB98
	private Transform GetRoot() { }

	// RVA: 0x15ECBE8
	public int get_childCount() { }

	// RVA: 0x15ECC38
	public void SetAsFirstSibling() { }

	// RVA: 0x15ECC88
	public void SetAsLastSibling() { }

	// RVA: 0x15ECCD8
	public void SetSiblingIndex(int index) { }

	// RVA: 0x15ECD40
	public int GetSiblingIndex() { }

	// RVA: 0x15ECD90
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x15ECDE8
	public Transform Find(string n) { }

	// RVA: 0x15ECE88
	public Vector3 get_lossyScale() { }

	// RVA: 0x15ECF50
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x15ECFB8
	public bool get_hasChanged() { }

	// RVA: 0x15ED008
	public void set_hasChanged(bool value) { }

	// RVA: 0x15ED070
	public IEnumerator GetEnumerator() { }

	// RVA: 0x15ED128
	public Transform GetChild(int index) { }

	// RVA: 0x15EAF54
	private void get_position_Injected(Vector3 ret) { }

	// RVA: 0x15EB014
	private void set_position_Injected(Vector3 value) { }

	// RVA: 0x15EB07C
	private void get_localPosition_Injected(Vector3 ret) { }

	// RVA: 0x15EB0E4
	private void set_localPosition_Injected(Vector3 value) { }

	// RVA: 0x15EB610
	private void get_rotation_Injected(Quaternion ret) { }

	// RVA: 0x15EB6D0
	private void set_rotation_Injected(Quaternion value) { }

	// RVA: 0x15EB738
	private void get_localRotation_Injected(Quaternion ret) { }

	// RVA: 0x15EB7A0
	private void set_localRotation_Injected(Quaternion value) { }

	// RVA: 0x15EB868
	private void get_localScale_Injected(Vector3 ret) { }

	// RVA: 0x15EB928
	private void set_localScale_Injected(Vector3 value) { }

	// RVA: 0x15EBC90
	private void get_worldToLocalMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15EBCF8
	private void get_localToWorldMatrix_Injected(Matrix4x4 ret) { }

	// RVA: 0x15EBDC4
	private void SetPositionAndRotation_Injected(Vector3 position, Quaternion rotation) { }

	// RVA: 0x15EBE80
	private void SetLocalPositionAndRotation_Injected(Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0x15EC4B8
	private void RotateAroundInternal_Injected(Vector3 axis, float angle) { }

	// RVA: 0x15EC644
	private void TransformDirection_Injected(Vector3 direction, Vector3 ret) { }

	// RVA: 0x15EC774
	private void InverseTransformDirection_Injected(Vector3 direction, Vector3 ret) { }

	// RVA: 0x15EC838
	private void TransformVector_Injected(Vector3 vector, Vector3 ret) { }

	// RVA: 0x15EC968
	private void InverseTransformVector_Injected(Vector3 vector, Vector3 ret) { }

	// RVA: 0x15ECA2C
	private void TransformPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x15ECAF0
	private void InverseTransformPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x15ECEE8
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

	// RVA: 0x15ED278
	private void InvokeSpriteChanged() { }

	// RVA: 0x15ED374
	public void set_sprite(Sprite value) { }

	// RVA: 0x15ED3DC
	public void set_color(Color value) { }

	// RVA: 0x15ED434
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

	// RVA: 0x15ED49C
	private void .ctor() { }

	// RVA: 0x15ED524
	internal int GetPackingRotation() { }

	// RVA: 0x15ED574
	internal int GetPacked() { }

	// RVA: 0x15ED5C4
	internal Rect GetTextureRect() { }

	// RVA: 0x15ED688
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x15ED74C
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x15ED810
	internal Vector4 GetPadding() { }

	// RVA: 0x15ED8D4
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x15EDA28
	public Bounds get_bounds() { }

	// RVA: 0x15EDB04
	public Rect get_rect() { }

	// RVA: 0x15EDBC8
	public Vector4 get_border() { }

	// RVA: 0x15EDC8C
	public Texture2D get_texture() { }

	// RVA: 0x15EDCDC
	public float get_pixelsPerUnit() { }

	// RVA: 0x15EDD2C
	public Texture2D get_associatedAlphaSplitTexture() { }

	// RVA: 0x15EDD7C
	public Vector2 get_pivot() { }

	// RVA: 0x15EDE3C
	public bool get_packed() { }

	// RVA: 0x15EDE88
	public SpritePackingRotation get_packingRotation() { }

	// RVA: 0x15EDED8
	public Rect get_textureRect() { }

	// RVA: 0x15EDF34
	public Vector2[] get_vertices() { }

	// RVA: 0x15EDF84
	public UInt16[] get_triangles() { }

	// RVA: 0x15EDFD4
	public Vector2[] get_uv() { }

	// RVA: 0x15EE024
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x15EE034
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	// RVA: 0x15EE57C
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x15EE590
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType) { }

	// RVA: 0x15EE67C
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude) { }

	// RVA: 0x15EE764
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x15EE840
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x15ED620
	private void GetTextureRect_Injected(Rect ret) { }

	// RVA: 0x15ED6E4
	private void GetInnerUVs_Injected(Vector4 ret) { }

	// RVA: 0x15ED7A8
	private void GetOuterUVs_Injected(Vector4 ret) { }

	// RVA: 0x15ED86C
	private void GetPadding_Injected(Vector4 ret) { }

	// RVA: 0x15ED980
	private static Sprite CreateSprite_Injected(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x15EDA9C
	private void get_bounds_Injected(Bounds ret) { }

	// RVA: 0x15EDB60
	private void get_rect_Injected(Rect ret) { }

	// RVA: 0x15EDC24
	private void get_border_Injected(Vector4 ret) { }

	// RVA: 0x15EDDD4
	private void get_pivot_Injected(Vector2 ret) { }

}

// Namespace: UnityEngine._Scripting.APIUpdating
internal class APIUpdaterRuntimeHelpers
{
	// Methods

	// RVA: 0x15EE914
	internal static bool GetMovedFromAttributeDataForType(Type sourceType, string assembly, string nsp, string klass) { }

	// RVA: 0x15EEA9C
	internal static bool GetObsoleteTypeRedirection(Type sourceType, string assemblyName, string nsp, string className) { }

}

// Namespace: UnityEngine.Sprites
public sealed class DataUtility
{
	// Methods

	// RVA: 0x15EEE10
	public static Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0x15EEE74
	public static Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0x15EEED8
	public static Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0x15EEF3C
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

	// RVA: 0x15EF048
	private static bool RequestAtlas(string tag) { }

	// RVA: 0x15EF108
	public static void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }

	// RVA: 0x15EF1DC
	public static void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }

	// RVA: 0x15EF2B0
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x15EF32C
	internal static void Register(SpriteAtlas spriteAtlas) { }

}

// Namespace: UnityEngine.U2D
public class SpriteAtlas
{
	// Methods

	// RVA: 0x15EF37C
	public bool CanBindTo(Sprite sprite) { }

}

// Namespace: UnityEngine.Profiling
public sealed class Profiler
{
	// Methods

	// RVA: 0x15EF3E4
	public static void BeginSample(string name) { }

	// RVA: 0x15EF50C
	private static void ValidateArguments(string name) { }

	// RVA: 0x15EF4A4
	private static void BeginSampleImpl(string name, object targetObject) { }

	// RVA: 0x15EF58C
	public static void EndSample() { }

	// RVA: 0x15EF5CC
	public static Int64 GetRuntimeMemorySizeLong(object o) { }

	// RVA: 0x15EF61C
	public static Int64 GetMonoHeapSizeLong() { }

	// RVA: 0x15EF65C
	public static Int64 GetMonoUsedSizeLong() { }

	// RVA: 0x15EF69C
	public static Int64 GetTotalAllocatedMemoryLong() { }

	// RVA: 0x15EF6DC
	public static Int64 GetTotalUnusedReservedMemoryLong() { }

	// RVA: 0x15EF71C
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

	// RVA: 0x15EF75C
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

	// RVA: 0x15EF998
	public object get_unityObjectArgument() { }

	// RVA: 0x15EF9A0
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x15EF9A8
	public int get_intArgument() { }

	// RVA: 0x15EF9B0
	public float get_floatArgument() { }

	// RVA: 0x15EF9B8
	public string get_stringArgument() { }

	// RVA: 0x15EF9C0
	public bool get_boolArgument() { }

	// RVA: 0x15EF9C8
	public void OnBeforeSerialize() { }

	// RVA: 0x15EF9F8
	public void OnAfterDeserialize() { }

	// RVA: 0x15EFA28
	public void .ctor() { }

}

// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall
{
	// Methods

	// RVA: 0x15EFA30
	protected void .ctor() { }

	// RVA: 0x15EFA38
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1
	public abstract void Invoke(object[] args) { }

	// RVA: 0x30A7C50
	protected static void ThrowOnInvalidArg(object arg) { }

	// RVA: 0x15EFB44
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

	// RVA: 0x15EFC8C
	private void add_Delegate(UnityAction value) { }

	// RVA: 0x15EFD30
	private void remove_Delegate(UnityAction value) { }

	// RVA: 0x15EFDD4
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x15EFF2C
	public void .ctor(UnityAction action) { }

	// RVA: 0x15EFFD8
	public override void Invoke(object[] args) { }

	// RVA: 0x15F0024
	public void Invoke() { }

	// RVA: 0x15F0070
	public override bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0>
{
	// Fields
	private UnityEngine.Events.UnityAction<T1> Delegate; // 0x0

	// Methods

	// RVA: 0x30A27C0
	protected void add_Delegate(UnityEngine.Events.UnityAction<T1> value) { }

	// RVA: 0x30A27C0
	protected void remove_Delegate(UnityEngine.Events.UnityAction<T1> value) { }

	// RVA: 0x30A2A20
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x30A27C0
	public void .ctor(UnityEngine.Events.UnityAction<T1> action) { }

	// RVA: 0x30A27C0
	public override void Invoke(object[] args) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A2A20
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x30A27C0
	public override void Invoke(object[] args) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A2A20
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x30A27C0
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

	// RVA: 0x30A2A20
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x30A27C0
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

	// RVA: 0x315B3A8
	public void .ctor(object target, MethodInfo theFunction, T argument) { }

	// RVA: 0x30A27C0
	public override void Invoke(object[] args) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x15F00CC
	public object get_target() { }

	// RVA: 0x15F00D4
	public string get_targetAssemblyTypeName() { }

	// RVA: 0x15F0248
	public string get_methodName() { }

	// RVA: 0x15F0250
	public PersistentListenerMode get_mode() { }

	// RVA: 0x15F0258
	public ArgumentCache get_arguments() { }

	// RVA: 0x15F0260
	public bool IsValid() { }

	// RVA: 0x15F02AC
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x15F08F4
	private static BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x15F0E64
	public void OnBeforeSerialize() { }

	// RVA: 0x15F0E94
	public void OnAfterDeserialize() { }

	// RVA: 0x15F0EC4
	public void .ctor() { }

}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCallGroup
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls; // 0x10

	// Methods

	// RVA: 0x15F0F48
	public void .ctor() { }

	// RVA: 0x15F0FD4
	public int get_Count() { }

	// RVA: 0x15F1020
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

	// RVA: 0x15F1294
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x15F1304
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x15F1374
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x15F1628
	public void Clear() { }

	// RVA: 0x15F1724
	public void ClearPersistent() { }

	// RVA: 0x15F1820
	public System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x15F1908
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

	// RVA: 0x15F19E4
	protected void .ctor() { }

	// RVA: 0x15F1B00
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x15F1B68
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: -1
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x15F063C
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x15F1B9C
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x15F20BC
	public int GetPersistentEventCount() { }

	// RVA: 0x15F1B34
	private void DirtyPersistentCalls() { }

	// RVA: 0x15F210C
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x15F214C
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x15F21C0
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x15F21DC
	public void RemoveAllListeners() { }

	// RVA: 0x15F21F8
	internal System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x15F2240
	public override string ToString() { }

	// RVA: 0x15F1ED0
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction
{
	// Methods

	// RVA: 0x15F22C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15F2368
	public virtual void Invoke() { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	// RVA: 0x15F237C
	public void .ctor() { }

	// RVA: 0x15F23A8
	public void AddListener(UnityAction call) { }

	// RVA: 0x15F2514
	public void RemoveListener(UnityAction call) { }

	// RVA: 0x15F2558
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x15F25C0
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x15F2428
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x15F262C
	public void Invoke() { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T0 arg0) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
	public void AddListener(UnityEngine.Events.UnityAction<T0> call) { }

	// RVA: 0x30A27C0
	public void RemoveListener(UnityEngine.Events.UnityAction<T0> call) { }

	// RVA: 0x30A1970
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x30A1970
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x30A52D0
	private static BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action) { }

	// RVA: 0x315B3A8
	public void Invoke(T0 arg0) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T0 arg0, T1 arg1) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1970
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x30A1970
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x315B3A8
	public void Invoke(T0 arg0, T1 arg1) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1970
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x30A1970
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2, T3>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1970
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x30A1970
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

// Namespace: UnityEngine.Serialization
public class FormerlySerializedAsAttribute
{
	// Fields
	private string m_oldName; // 0x10

	// Methods

	// RVA: 0x15F2834
	public void .ctor(string oldName) { }

}

// Namespace: UnityEngine.Scripting
public class AlwaysLinkAssemblyAttribute
{
	// Methods

	// RVA: 0x15F2868
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
public static class GarbageCollector
{
	// Methods

	// RVA: 0x15F2870
	public static bool get_isIncremental() { }

	// RVA: 0x15F28B0
	public static UInt64 get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x15F28F0
	public static bool CollectIncremental(UInt64 nanoseconds) { }

}

// Namespace: UnityEngine.Scripting
public class PreserveAttribute
{
	// Methods

	// RVA: 0x15E0D20
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
public class RequireImplementorsAttribute
{
	// Methods

	// RVA: 0x15F2940
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

	// RVA: 0x15F2948
	public void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

}

// Namespace: UnityEngine.Scripting.APIUpdating
public class MovedFromAttribute
{
	// Fields
	internal MovedFromAttributeData data; // 0x10

	// Methods

	// RVA: 0x15F29E4
	public void .ctor(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

	// RVA: 0x15F2A94
	public void .ctor(string sourceNamespace) { }

}

// Namespace: UnityEngine.SceneManagement
[Serializable]
public struct Scene
{
	// Fields
	private int m_Handle; // 0x10

	// Methods

	// RVA: 0x15F2B34
	private static bool IsValidInternal(int sceneHandle) { }

	// RVA: 0x15F2B84
	private static string GetPathInternal(int sceneHandle) { }

	// RVA: 0x15F2BD4
	private static string GetNameInternal(int sceneHandle) { }

	// RVA: 0x15F2C24
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	// RVA: 0x15F2C74
	private static int GetBuildIndexInternal(int sceneHandle) { }

	// RVA: 0x15F2CC4
	private static int GetRootCountInternal(int sceneHandle) { }

	// RVA: 0x15F2D14
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x15F2D7C
	public int get_handle() { }

	// RVA: 0x15F2D84
	public bool IsValid() { }

	// RVA: 0x15F2DD4
	public string get_path() { }

	// RVA: 0x15F2E24
	public string get_name() { }

	// RVA: 0x15F2E74
	public bool get_isLoaded() { }

	// RVA: 0x15F2EC4
	public int get_buildIndex() { }

	// RVA: 0x15F2F14
	public int get_rootCount() { }

	// RVA: 0x15F2F64
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x15F3044
	public void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects) { }

	// RVA: 0x15F3348
	public static bool op_Equality(Scene lhs, Scene rhs) { }

	// RVA: 0x15F3354
	public override int GetHashCode() { }

	// RVA: 0x15F335C
	public override bool Equals(object other) { }

}

// Namespace: UnityEngine.SceneManagement
internal static class SceneManagerAPIInternal
{
	// Methods

	// RVA: 0x15F33EC
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x15F34C0
	public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

	// RVA: 0x15F3458
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

}

// Namespace: UnityEngine.SceneManagement
public class SceneManagerAPI
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Methods

	// RVA: 0x15F3530
	internal static SceneManagerAPI get_ActiveAPI() { }

	// RVA: 0x15F3630
	public static SceneManagerAPI get_overrideAPI() { }

	// RVA: 0x15F36AC
	protected internal void .ctor() { }

	// RVA: 0x15F36B4
	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x15F3720
	protected internal virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

	// RVA: 0x15F3790
	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x15F3798
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

	// RVA: 0x15F3804
	public static int get_sceneCount() { }

	// RVA: 0x15F3844
	public static Scene GetActiveScene() { }

	// RVA: 0x15F393C
	public static bool SetActiveScene(Scene scene) { }

	// RVA: 0x15F3A40
	public static Scene GetSceneByName(string name) { }

	// RVA: 0x15F3B60
	public static Scene GetSceneAt(int index) { }

	// RVA: 0x15F3C80
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x15F3D78
	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

	// RVA: 0x15F3E88
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	// RVA: 0x15F3F10
	public static void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }

	// RVA: 0x15F4024
	public static void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }

	// RVA: 0x15F4138
	public static void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x15F424C
	public static void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x15F4360
	public static void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x15F4474
	public static void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x15F4588
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x15F4658
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x15F46C8
	public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options) { }

	// RVA: 0x15F474C
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x15F482C
	private static void Internal_SceneUnloaded(Scene scene) { }

	// RVA: 0x15F4904
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x15F49E4
	private static void .cctor() { }

	// RVA: 0x15F38EC
	private static void GetActiveScene_Injected(Scene ret) { }

	// RVA: 0x15F39F0
	private static bool SetActiveScene_Injected(Scene scene) { }

	// RVA: 0x15F3AF8
	private static void GetSceneByName_Injected(string name, Scene ret) { }

	// RVA: 0x15F3C18
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

	// RVA: 0x15F4650
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

	// RVA: 0x15F4A58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15F4AF8
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

	// RVA: 0x15F4A34
	public override string ToString() { }

}

// Namespace: UnityEngine.LowLevel
public class PlayerLoop
{
	// Methods

	// RVA: 0x15F4B0C
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	// RVA: 0x15F4E30
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	// RVA: 0x15F4F30
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal>& internalSys) { }

	// RVA: 0x15F4BBC
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, int offset) { }

	// RVA: 0x15F4B7C
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	// RVA: 0x15F50BC
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal TCollection <.cctor>b__5_0() { }

	// RVA: 0x315B3A8
	internal void <.cctor>b__5_1(TCollection l) { }

}

// Namespace: UnityEngine.Pool
public class CollectionPool<T0, T1>
{
	// Fields
	internal static readonly UnityEngine.Pool.ObjectPool<TCollection> s_Pool; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public static TCollection Get() { }

	// RVA: 0x315B3A8
	public static UnityEngine.Pool.PooledObject<TCollection> Get(TCollection value) { }

	// RVA: 0x315B3A8
	public static void Release(TCollection toRelease) { }

	// RVA: 0x30A6D04
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

	// RVA: 0x30A14A4
	public int get_CountAll() { }

	// RVA: 0x30A24F0
	private void set_CountAll(int value) { }

	// RVA: 0x30A14A4
	public int get_CountInactive() { }

	// RVA: 0x315B3A8
	public void .ctor(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, bool collectionCheck, int defaultCapacity, int maxSize) { }

	// RVA: 0x315B3A8
	public T Get() { }

	// RVA: 0x315B3A8
	public UnityEngine.Pool.PooledObject<T> Get(T v) { }

	// RVA: 0x315B3A8
	public void Release(T element) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x30A2378
	public void Dispose() { }

}

// Namespace: UnityEngine.Pool
public struct PooledObject<T0>
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly UnityEngine.Pool.IObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: 0x315B3A8
	public void .ctor(T value, UnityEngine.Pool.IObjectPool<T> pool) { }

	// RVA: 0x30A2378
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

	// RVA: 0x15F510C
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

	// RVA: 0x15F58E8
	public void .ctor() { }

	// RVA: 0x15F738C
	internal bool <Register>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x15F5D4C
	public void .ctor() { }

	// RVA: 0x15F740C
	internal bool <Unregister>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x15F68A0
	public void .ctor() { }

	// RVA: 0x15F745C
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

	// RVA: 0x15F5114
	public static PlayerConnection get_instance() { }

	// RVA: 0x15F533C
	public bool get_isConnected() { }

	// RVA: 0x15F5278
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x15F5510
	public void OnEnable() { }

	// RVA: 0x15F5474
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x15F5648
	public void Register(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x15F5B4C
	public void Unregister(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x15F5EC4
	public void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x15F6154
	public void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x15F61C0
	public void UnregisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x15F622C
	public void UnregisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x15F6298
	public void Send(Guid messageId, Byte[] data) { }

	// RVA: 0x15F6454
	public bool TrySend(Guid messageId, Byte[] data) { }

	// RVA: 0x15F6610
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x15F68A8
	public void DisconnectAll() { }

	// RVA: 0x15F69E0
	private static void MessageCallbackInternal(IntPtr data, UInt64 size, UInt64 guid, string messageId) { }

	// RVA: 0x15F6F94
	private static void ConnectedCallbackInternal(int playerId) { }

	// RVA: 0x15F7040
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x15F70EC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class MessageEvent
{
	// Methods

	// RVA: 0x15F7564
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ConnectionChangeEvent
{
	// Methods

	// RVA: 0x15F75C0
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

	// RVA: 0x15F73DC
	public Guid get_MessageTypeId() { }

	// RVA: 0x15F7520
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x15F7478
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x15F7468
	public void .ctor() { }

	// RVA: 0x15F7614
	internal bool <InvokeMessageIdSubscribers>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x15F7470
	public void .ctor() { }

	// RVA: 0x15F7664
	internal bool <AddAndCreate>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x15F75B8
	public void .ctor() { }

	// RVA: 0x15F76B4
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

	// RVA: 0x15F6B08
	public void InvokeMessageIdSubscribers(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x15F58F0
	public UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x15F5D54
	public void UnregisterManagedCallback(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x15F7250
	public void .ctor() { }

}

// Namespace: UnityEngine.iOS
public sealed class Device
{
	// Methods

	// RVA: 0x15F7704
	public static string get_systemVersion() { }

	// RVA: 0x15F7744
	public static string get_vendorIdentifier() { }

	// RVA: 0x15F7784
	public static bool RequestStoreReview() { }

}

// Namespace: UnityEngine.iOS
public sealed class OnDemandResourcesRequest
{
	// Methods

	// RVA: 0x15F77C4
	public string get_error() { }

	// RVA: 0x15F7814
	private static void DestroyFromScript(IntPtr ptr) { }

	// RVA: 0x15F7864
	public void Dispose() { }

	// RVA: 0x15F7930
	internal void .ctor() { }

	// RVA: 0x15F7938
	protected override void Finalize() { }

}

// Namespace: UnityEngine.iOS
public static class OnDemandResources
{
	// Methods

	// RVA: 0x15F7A58
	public static bool get_enabled() { }

	// RVA: 0x15F7A98
	private static OnDemandResourcesRequest PreloadAsyncImpl(string[] tags) { }

	// RVA: 0x15F7AE8
	public static OnDemandResourcesRequest PreloadAsync(string[] tags) { }

}

// Namespace: UnityEngine.Internal
[Serializable]
public class DefaultValueAttribute
{
	// Fields
	private object DefaultValue; // 0x10

	// Methods

	// RVA: 0x15F7B38
	public void .ctor(string value) { }

	// RVA: 0x15F7B6C
	public object get_Value() { }

	// RVA: 0x15F7B74
	public override bool Equals(object obj) { }

	// RVA: 0x15F7C34
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Internal
[Serializable]
public class ExcludeFromDocsAttribute
{
	// Methods

	// RVA: 0x15F7C58
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

	// RVA: 0x15F7C60
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

	// RVA: 0x15F7C6C
	public void .ctor(int indexStart, int indexCount, MeshTopology topology) { }

	// RVA: 0x15F7C84
	public Bounds get_bounds() { }

	// RVA: 0x15F7C98
	public void set_bounds(Bounds value) { }

	// RVA: 0x15F7CAC
	public MeshTopology get_topology() { }

	// RVA: 0x15F7CB4
	public void set_topology(MeshTopology value) { }

	// RVA: 0x15F7CBC
	public int get_indexStart() { }

	// RVA: 0x15F7CC4
	public void set_indexStart(int value) { }

	// RVA: 0x15F7CCC
	public int get_indexCount() { }

	// RVA: 0x15F7CD4
	public void set_indexCount(int value) { }

	// RVA: 0x15F7CDC
	public int get_baseVertex() { }

	// RVA: 0x15F7CE4
	public void set_baseVertex(int value) { }

	// RVA: 0x15F7CEC
	public int get_firstVertex() { }

	// RVA: 0x15F7CF4
	public void set_firstVertex(int value) { }

	// RVA: 0x15F7CFC
	public int get_vertexCount() { }

	// RVA: 0x15F7D04
	public void set_vertexCount(int value) { }

	// RVA: 0x15F7D0C
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

	// RVA: 0x15F8000
	public VertexAttribute get_attribute() { }

	// RVA: 0x15F8008
	public void set_attribute(VertexAttribute value) { }

	// RVA: 0x15F8010
	public VertexAttributeFormat get_format() { }

	// RVA: 0x15F8018
	public void set_format(VertexAttributeFormat value) { }

	// RVA: 0x15F8020
	public int get_dimension() { }

	// RVA: 0x15F8028
	public void set_dimension(int value) { }

	// RVA: 0x15F8030
	public int get_stream() { }

	// RVA: 0x15F8038
	public void set_stream(int value) { }

	// RVA: 0x15F8040
	public void .ctor(VertexAttribute attribute, VertexAttributeFormat format, int dimension, int stream) { }

	// RVA: 0x15F804C
	public override string ToString() { }

	// RVA: 0x15F8254
	public override int GetHashCode() { }

	// RVA: 0x15F8278
	public override bool Equals(object other) { }

	// RVA: 0x15F8338
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

	// RVA: 0x15F837C
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x15F839C
	public void .ctor(int nameID) { }

	// RVA: 0x15F83BC
	public void .ctor(Texture tex) { }

	// RVA: 0x15F8654
	public void .ctor(RenderBuffer buf, int mipLevel, CubemapFace cubeFace, int depthSlice) { }

	// RVA: 0x15F8674
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x15F8694
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x15F86B4
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x15F8700
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x15F8724
	public override string ToString() { }

	// RVA: 0x15F8A2C
	public override int GetHashCode() { }

	// RVA: 0x15F8A84
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x15F8B38
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

	// RVA: 0x15F8C3C
	public static bool get_lightsUseLinearIntensity() { }

	// RVA: 0x15F8C7C
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	// RVA: 0x15F8CBC
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	// RVA: 0x15F8D7C
	public static RenderPipelineAsset get_renderPipelineAsset() { }

	// RVA: 0x15F8EFC
	public static void set_renderPipelineAsset(RenderPipelineAsset value) { }

	// RVA: 0x15F8F9C
	private static ScriptableObject get_INTERNAL_defaultRenderPipeline() { }

	// RVA: 0x15F8FDC
	private static void set_INTERNAL_defaultRenderPipeline(ScriptableObject value) { }

	// RVA: 0x15F8E3C
	public static RenderPipelineAsset get_defaultRenderPipeline() { }

	// RVA: 0x15F8F4C
	public static void set_defaultRenderPipeline(RenderPipelineAsset value) { }

}

// Namespace: UnityEngine.Rendering
public class OnDemandRendering
{
	// Fields
	private static int m_RenderFrameInterval; // 0x0

	// Methods

	// RVA: 0x15F902C
	public static int get_renderFrameInterval() { }

	// RVA: 0x15F90A8
	internal static void GetRenderFrameInterval(int frameInterval) { }

	// RVA: 0x15F916C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public class CommandBuffer
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x15F91BC
	public void SetInvertCulling(bool invertCulling) { }

	// RVA: 0x15F9224
	private static IntPtr InitBuffer() { }

	// RVA: 0x15F9264
	private void ReleaseBuffer() { }

	// RVA: 0x15F92B4
	public void set_name(string value) { }

	// RVA: 0x15F931C
	public void Clear() { }

	// RVA: 0x15F936C
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x15F947C
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x15F94EC
	private void CopyTexture_Internal(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	// RVA: 0x15F95A0
	private void Blit_Texture(Texture source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x15F96E4
	private void Blit_Identifier(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x15F9828
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x15F98E4
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x15F9994
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format, int antiAliasing) { }

	// RVA: 0x15F9A44
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, GraphicsFormat format) { }

	// RVA: 0x15F9AE8
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x15F9BE0
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x15F9CB0
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x15F9D30
	public void ReleaseTemporaryRT(int nameID) { }

	// RVA: 0x15F9D98
	public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, UInt32 stencil) { }

	// RVA: 0x15F9E90
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x15F9FC0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x15FA0A4
	public void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x15FA104
	public void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x15FA1C4
	public void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x15FA284
	public void EnableShaderKeyword(string keyword) { }

	// RVA: 0x15FA2EC
	private void EnableGlobalKeyword(GlobalKeyword keyword) { }

	// RVA: 0x15FA3A8
	public void EnableKeyword(GlobalKeyword keyword) { }

	// RVA: 0x15FA400
	public void DisableShaderKeyword(string keyword) { }

	// RVA: 0x15FA468
	private void DisableGlobalKeyword(GlobalKeyword keyword) { }

	// RVA: 0x15FA524
	public void DisableKeyword(GlobalKeyword keyword) { }

	// RVA: 0x15FA57C
	public void SetViewMatrix(Matrix4x4 view) { }

	// RVA: 0x15FA64C
	public void SetProjectionMatrix(Matrix4x4 proj) { }

	// RVA: 0x15FA71C
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	// RVA: 0x15F9F68
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	// RVA: 0x15FA7CC
	private void SetGlobalTexture_Impl(int nameID, RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	// RVA: 0x15FA834
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x15FA89C
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x15FA9C8
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x15FAB28
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x15FA948
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x15FAA90
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x15FAD80
	protected override void Finalize() { }

	// RVA: 0x15FAE9C
	public void Dispose() { }

	// RVA: 0x15FAE3C
	private void Dispose(bool disposing) { }

	// RVA: 0x15FAF70
	public void .ctor() { }

	// RVA: 0x15FAFCC
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x15FB380
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x15FB3B4
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x15FB3EC
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	// RVA: 0x15FB428
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x15FB77C
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x15FB784
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x15FB790
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x15FB81C
	public void Blit(Texture source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset) { }

	// RVA: 0x15FB904
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x15FB9D4
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x15FBAB0
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x15FBB7C
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x15FBC4C
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x15FBD28
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x15FBDBC
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x15FBE18
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x15F93F4
	private void Internal_DrawMesh_Injected(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x15F9644
	private void Blit_Texture_Injected(Texture source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x15F9788
	private void Blit_Identifier_Injected(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x15F9C48
	private void GetTemporaryRTWithDescriptor_Injected(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x15F9E18
	private void ClearRenderTarget_Injected(RTClearFlags clearFlags, Color backgroundColor, float depth, UInt32 stencil) { }

	// RVA: 0x15FA16C
	private void SetGlobalVector_Injected(int nameID, Vector4 value) { }

	// RVA: 0x15FA22C
	private void SetGlobalColor_Injected(int nameID, Color value) { }

	// RVA: 0x15FA340
	private void EnableGlobalKeyword_Injected(GlobalKeyword keyword) { }

	// RVA: 0x15FA4BC
	private void DisableGlobalKeyword_Injected(GlobalKeyword keyword) { }

	// RVA: 0x15FA5E4
	private void SetViewMatrix_Injected(Matrix4x4 view) { }

	// RVA: 0x15FA6B4
	private void SetProjectionMatrix_Injected(Matrix4x4 proj) { }

	// RVA: 0x15FA774
	private void SetViewProjectionMatrices_Injected(Matrix4x4 view, Matrix4x4 proj) { }

	// RVA: 0x15FAC68
	private void SetRenderTargetSingle_Internal_Injected(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x15FACE8
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

	// RVA: 0x15FBF0C
	public float get_Item(int rgb, int coefficient) { }

	// RVA: 0x15FC12C
	public void set_Item(int rgb, int coefficient, float value) { }

	// RVA: 0x15FC34C
	public override int GetHashCode() { }

	// RVA: 0x15FC52C
	public override bool Equals(object other) { }

	// RVA: 0x15FC5E4
	public bool Equals(SphericalHarmonicsL2 other) { }

	// RVA: 0x15FC6A8
	public static bool op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

}

// Namespace: UnityEngine.Rendering
public struct BatchID
{
	// Fields
	public static readonly BatchID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x15FC864
	public override int GetHashCode() { }

	// RVA: 0x15FC86C
	public override bool Equals(object obj) { }

	// RVA: 0x15FC93C
	public bool Equals(BatchID other) { }

	// RVA: 0x15FC94C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct BatchMaterialID
{
	// Fields
	public static readonly BatchMaterialID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x15FC998
	public override int GetHashCode() { }

	// RVA: 0x15FC9A0
	public override bool Equals(object obj) { }

	// RVA: 0x15FCA70
	public bool Equals(BatchMaterialID other) { }

	// RVA: 0x15FCA80
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct BatchMeshID
{
	// Fields
	public static readonly BatchMeshID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x15FCACC
	public override int GetHashCode() { }

	// RVA: 0x15FCAD4
	public override bool Equals(object obj) { }

	// RVA: 0x15FCBA4
	public bool Equals(BatchMeshID other) { }

	// RVA: 0x15FCBB4
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

	// RVA: 0x15FCC00
	public override int GetHashCode() { }

	// RVA: 0x15FCC08
	public bool Equals(BatchPackedCullingViewID other) { }

	// RVA: 0x15FCC18
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

	// RVA: 0x15FCCA8
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

	// RVA: 0x15FCF10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15FD034
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }

}

// Namespace: UnityEngine.Rendering
public class BatchRendererGroup
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private OnPerformCulling m_PerformCulling; // 0x18

	// Methods

	// RVA: 0x15FCD14
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

	// RVA: 0x15FD094
	public bool Equals(CoreCameraValues other) { }

	// RVA: 0x15FD0C8
	public override bool Equals(object obj) { }

	// RVA: 0x15FD178
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

	// RVA: 0x15FD198
	public Plane GetShadowCullingPlane(int index) { }

	// RVA: 0x15FD288
	public Plane GetCameraCullingPlane(int index) { }

	// RVA: 0x15FD378
	public bool Equals(CameraProperties other) { }

	// RVA: 0x15FE1B4
	public override bool Equals(object obj) { }

	// RVA: 0x15FE28C
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

	// RVA: 0x15FEAF0
	public int get_cullingPlaneCount() { }

	// RVA: 0x15FEAF8
	public void set_cullingMask(UInt32 value) { }

	// RVA: 0x15FEB00
	public void set_cullingOptions(CullingOptions value) { }

	// RVA: 0x15FEB08
	public float GetLayerCullingDistance(int layerIndex) { }

	// RVA: 0x15FEBEC
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x15FED2C
	public bool Equals(ScriptableCullingParameters other) { }

	// RVA: 0x15FF150
	public override bool Equals(object obj) { }

	// RVA: 0x15FF268
	public override int GetHashCode() { }

	// RVA: 0x15FF4F8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct CullingResults
{
	// Fields
	internal IntPtr ptr; // 0x10
	private CullingAllocationInfo* m_AllocationInfo; // 0x18

	// Methods

	// RVA: 0x15FF54C
	public bool Equals(CullingResults other) { }

	// RVA: 0x15FF5E0
	public override bool Equals(object obj) { }

	// RVA: 0x15FF6F0
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

	// RVA: 0x15FF724
	public void .ctor(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	// RVA: 0x15FF7FC
	public ShaderTagId GetShaderPassName(int index) { }

	// RVA: 0x15FF968
	public bool Equals(DrawingSettings other) { }

	// RVA: 0x15FFC40
	public override bool Equals(object obj) { }

	// RVA: 0x15FFD88
	public override int GetHashCode() { }

	// RVA: 0x15FFF58
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

	// RVA: 0x15FFFA8
	public static FilteringSettings get_defaultValue() { }

	// RVA: 0x160006C
	public void .ctor(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, int layerMask, UInt32 renderingLayerMask, int excludeMotionVectorObjects) { }

	// RVA: 0x1600204
	public bool Equals(FilteringSettings other) { }

	// RVA: 0x1600310
	public override bool Equals(object obj) { }

	// RVA: 0x1600448
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

	// RVA: 0x16004E8
	public bool Equals(LODParameters other) { }

	// RVA: 0x1600590
	public override bool Equals(object obj) { }

	// RVA: 0x16006B0
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public class ObjectIdRequest
{
	// Fields
	private RenderTexture <destination>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1600750
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

	// RVA: 0x315B3A8
	protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	// RVA: 0x315B3A8
	protected internal virtual bool IsRenderRequestSupported(Camera camera, RequestData data) { }

	// RVA: 0x1600758
	protected virtual void Render(ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x16007D4
	internal void InternalRender(ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x315B3A8
	internal void InternalProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	// RVA: 0x1600858
	public bool get_disposed() { }

	// RVA: 0x1600860
	private void set_disposed(bool value) { }

	// RVA: 0x1600868
	internal void Dispose() { }

	// RVA: 0x16008EC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16008F0
	protected void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset
{
	// Methods

	// RVA: 0x16008F8
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x1600B00
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x1600B08
	public virtual string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x1600B10
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x1600B18
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x1600B20
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x1600B28
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x1600B30
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x1600B38
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x1600B40
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x1600B48
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x1600B50
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x1600B58
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x1600B60
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x1600B68
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x1600B70
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x1600B78
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x1600B80
	public virtual Material get_default2DMaskMaterial() { }

	// RVA: 0x1600B88
	public virtual Shader get_defaultShader() { }

	// RVA: 0x1600B90
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x1600B98
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: 0x1600BA0
	public virtual string get_renderPipelineShaderTag() { }

	// RVA: -1
	protected abstract RenderPipeline CreatePipeline() { }

	// RVA: 0x1600C38
	protected virtual void OnValidate() { }

	// RVA: 0x16012A8
	protected virtual void OnDisable() { }

	// RVA: 0x1601310
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

	// RVA: 0x1601318
	public static RenderPipeline get_currentPipeline() { }

	// RVA: 0x1601394
	private static void set_currentPipeline(RenderPipeline value) { }

	// RVA: 0x160146C
	internal static void OnActiveRenderPipelineTypeChanged() { }

	// RVA: 0x16014FC
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	// RVA: 0x1601624
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x1600D54
	internal static void CleanupRenderPipeline() { }

	// RVA: 0x16017F8
	private static string GetCurrentPipelineAssetType() { }

	// RVA: 0x1601874
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, object renderRequest) { }

	// RVA: 0x160113C
	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x1601DAC
	private static bool IsPipelineRequireCreation() { }

	// RVA: 0x1601F94
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

	// RVA: 0x1600064
	public static RenderQueueRange get_all() { }

	// RVA: 0x160206C
	public static RenderQueueRange get_transparent() { }

	// RVA: 0x1602078
	public int get_lowerBound() { }

	// RVA: 0x16002E8
	public bool Equals(RenderQueueRange other) { }

	// RVA: 0x1602080
	public override bool Equals(object obj) { }

	// RVA: 0x16004D4
	public override int GetHashCode() { }

	// RVA: 0x1602160
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct ScriptableRenderContext
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x16021B4
	private static void Internal_Cull(ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x16022C4
	internal static void InitializeSortSettings(Camera camera, SortingSettings sortingSettings) { }

	// RVA: 0x160232C
	private void Submit_Internal() { }

	// RVA: 0x1602428
	private void GetCameras_Internal(Type listType, object resultList) { }

	// RVA: 0x1602534
	private void DrawRenderers_Internal(IntPtr cullResults, DrawingSettings drawingSettings, FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x16026D8
	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	// RVA: 0x16027F8
	private void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x160291C
	private void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset) { }

	// RVA: 0x1601C6C
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1602A28
	public void Submit() { }

	// RVA: 0x1601C74
	internal void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results) { }

	// RVA: 0x1602B1C
	public void DrawRenderers(CullingResults cullingResults, DrawingSettings drawingSettings, FilteringSettings filteringSettings) { }

	// RVA: 0x1602C7C
	public void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	// RVA: 0x1602E18
	public void SetupCameraProperties(Camera camera, bool stereoSetup) { }

	// RVA: 0x1602F60
	public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x1603064
	public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset) { }

	// RVA: 0x1603160
	public CullingResults Cull(ScriptableCullingParameters parameters) { }

	// RVA: 0x1603274
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x16032EC
	public override bool Equals(object obj) { }

	// RVA: 0x1603404
	public override int GetHashCode() { }

	// RVA: 0x160340C
	private static void .cctor() { }

	// RVA: 0x160226C
	private static void Internal_Cull_Injected(ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x16023D8
	private static void Submit_Internal_Injected(ScriptableRenderContext _unity_self) { }

	// RVA: 0x16024DC
	private static void GetCameras_Internal_Injected(ScriptableRenderContext _unity_self, Type listType, object resultList) { }

	// RVA: 0x1602638
	private static void DrawRenderers_Internal_Injected(ScriptableRenderContext _unity_self, IntPtr cullResults, DrawingSettings drawingSettings, FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x1602790
	private static void ExecuteCommandBuffer_Internal_Injected(ScriptableRenderContext _unity_self, CommandBuffer commandBuffer) { }

	// RVA: 0x16028B4
	private static void SetupCameraProperties_Internal_Injected(ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x16029D0
	private static void DrawGizmos_Internal_Injected(ScriptableRenderContext _unity_self, Camera camera, GizmoSubset gizmoSubset) { }

}

// Namespace: UnityEngine.Rendering
public struct ShaderTagId
{
	// Fields
	public static readonly ShaderTagId none; // 0x0
	private int m_Id; // 0x10

	// Methods

	// RVA: 0x1603480
	public void .ctor(string name) { }

	// RVA: 0x15FF7F4
	internal int get_id() { }

	// RVA: 0x15FF960
	internal void set_id(int value) { }

	// RVA: 0x16034AC
	public override bool Equals(object obj) { }

	// RVA: 0x15FFB40
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x160353C
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

	// RVA: 0x16001FC
	public static SortingLayerRange get_all() { }

	// RVA: 0x1603560
	public bool Equals(SortingLayerRange other) { }

	// RVA: 0x1603584
	public override bool Equals(object obj) { }

	// RVA: 0x1603620
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

	// RVA: 0x1603628
	public void .ctor(Camera camera) { }

	// RVA: 0x16036E0
	public SortingCriteria get_criteria() { }

	// RVA: 0x16036E8
	public void set_criteria(SortingCriteria value) { }

	// RVA: 0x15FFB50
	public bool Equals(SortingSettings other) { }

	// RVA: 0x16036F0
	public override bool Equals(object obj) { }

	// RVA: 0x15FFE90
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

	// RVA: 0x1603828
	public void set_enabled(bool value) { }

	// RVA: 0x1603898
	public void set_readMask(Byte value) { }

	// RVA: 0x16038A0
	public void set_writeMask(Byte value) { }

	// RVA: 0x16038A8
	public void set_compareFunctionFront(CompareFunction value) { }

	// RVA: 0x16038B0
	public void set_passOperationFront(StencilOp value) { }

	// RVA: 0x16038B8
	public void set_failOperationFront(StencilOp value) { }

	// RVA: 0x16038C0
	public void set_zFailOperationFront(StencilOp value) { }

	// RVA: 0x16038C8
	public void set_compareFunctionBack(CompareFunction value) { }

	// RVA: 0x16038D0
	public void set_passOperationBack(StencilOp value) { }

	// RVA: 0x16038D8
	public void set_failOperationBack(StencilOp value) { }

	// RVA: 0x16038E0
	public void set_zFailOperationBack(StencilOp value) { }

	// RVA: 0x16038E8
	public bool Equals(StencilState other) { }

	// RVA: 0x1603998
	public override bool Equals(object obj) { }

	// RVA: 0x1603AC4
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

	// RVA: 0x1603BC0
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0x1601784
	public static void set_active(SupportedRenderingFeatures value) { }

	// RVA: 0x1603D2C
	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	// RVA: 0x1603D34
	public LightmapMixedBakeModes get_mixedLightingModes() { }

	// RVA: 0x1603D3C
	public LightmapBakeType get_lightmapBakeTypes() { }

	// RVA: 0x1603D44
	public LightmapsMode get_lightmapsModes() { }

	// RVA: 0x1603D4C
	public bool get_enlightenLightmapper() { }

	// RVA: 0x1603D54
	public bool get_enlighten() { }

	// RVA: 0x1603D5C
	public bool get_rendersUIOverlay() { }

	// RVA: 0x1603D64
	public bool get_autoAmbientProbeBaking() { }

	// RVA: 0x1603D6C
	public bool get_autoDefaultReflectionProbeBaking() { }

	// RVA: 0x1603D74
	public bool get_overridesLightProbeSystem() { }

	// RVA: 0x1603D7C
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x1603F90
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	// RVA: 0x1604008
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x16041C4
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	// RVA: 0x160423C
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	// RVA: 0x1604408
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	// RVA: 0x1604494
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	// RVA: 0x1604534
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	// RVA: 0x16045B4
	internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0x1604634
	internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0x16046B4
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	// RVA: 0x1604734
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x16016E8
	public void .ctor() { }

	// RVA: 0x1604754
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

	// RVA: 0x160483C
	public bool Equals(VisibleLight other) { }

	// RVA: 0x16049FC
	public override bool Equals(object obj) { }

	// RVA: 0x1604ABC
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

	// RVA: 0x1604BC4
	public bool Equals(VisibleReflectionProbe other) { }

	// RVA: 0x1604D6C
	public override bool Equals(object obj) { }

	// RVA: 0x1604E2C
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public struct GlobalKeyword
{
	// Fields
	internal readonly string m_Name; // 0x10
	internal readonly UInt32 m_Index; // 0x18

	// Methods

	// RVA: 0x1604FE8
	private static UInt32 GetGlobalKeywordCount() { }

	// RVA: 0x1605028
	private static UInt32 GetGlobalKeywordIndex(string keyword) { }

	// RVA: 0x1605078
	public void .ctor(string name) { }

	// RVA: 0x16051E8
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

	// RVA: 0x16051F0
	internal static UInt32 GetGlobalKeywordCount() { }

	// RVA: 0x1605230
	internal static UInt32 GetGlobalKeywordIndex(string keyword) { }

	// RVA: 0x1605280
	internal static void CreateGlobalKeyword(string keyword) { }

	// RVA: 0x16052D0
	public void .ctor(string keywordName) { }

	// RVA: 0x16053E0
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

	// RVA: 0x16053E8
	public static Playable get_Null() { }

	// RVA: 0x1605464
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x160546C
	public PlayableHandle GetHandle() { }

	// RVA: 0x1605478
	public bool Equals(Playable other) { }

	// RVA: 0x160561C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Playables
[Serializable]
public abstract class PlayableAsset
{
	// Methods

	// RVA: -1
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1605774
	public virtual Double get_duration() { }

	// RVA: 0x16057F0
	public virtual System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }

	// RVA: 0x160586C
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	// RVA: 0x16059C4
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x16059F8
	protected void .ctor() { }

}

// Namespace: UnityEngine.Playables
[Serializable]
public abstract class PlayableBehaviour
{
	// Methods

	// RVA: 0x1605A00
	public void .ctor() { }

	// RVA: 0x1605A08
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x1605A0C
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x1605A10
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x1605A14
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x1605A18
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1605A1C
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1605A20
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1605A24
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1605A28
	public virtual object Clone() { }

}

// Namespace: 
internal sealed class CreateOutputMethod
{
	// Methods

	// RVA: 0x1605AC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1605B68
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

	// RVA: 0x1605A30
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

	// RVA: 0x30A1224
	internal bool IsPlayableOfType() { }

	// RVA: 0x16056F8
	public static PlayableHandle get_Null() { }

	// RVA: 0x1605594
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x1605BB0
	public override bool Equals(object p) { }

	// RVA: 0x1605CCC
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x1605D54
	public override int GetHashCode() { }

	// RVA: 0x1605B7C
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	// RVA: 0x1605D8C
	internal bool IsValid() { }

	// RVA: 0x1605E88
	internal Type GetPlayableType() { }

	// RVA: 0x1605F84
	private static void .cctor() { }

	// RVA: 0x1605E38
	private static bool IsValid_Injected(PlayableHandle _unity_self) { }

	// RVA: 0x1605F34
	private static Type GetPlayableType_Injected(PlayableHandle _unity_self) { }

}

// Namespace: UnityEngine.Playables
public struct PlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Methods

	// RVA: 0x1605FD0
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x1605FD8
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x1605FE4
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x1606188
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

	// RVA: 0x1606264
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x16062E0
	public override int GetHashCode() { }

	// RVA: 0x1606100
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x160634C
	public override bool Equals(object p) { }

	// RVA: 0x1606468
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x1606318
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x16064F0
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

	// RVA: 0x160653C
	public float get_red() { }

	// RVA: 0x1606544
	public void set_red(float value) { }

	// RVA: 0x16065F8
	public float get_green() { }

	// RVA: 0x1606600
	public void set_green(float value) { }

	// RVA: 0x16066B4
	public float get_blue() { }

	// RVA: 0x16066BC
	public void set_blue(float value) { }

	// RVA: 0x1606770
	public static LinearColor Convert(Color color, float intensity) { }

	// RVA: 0x1606A20
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

	// RVA: 0x1606A34
	public void Init(DirectionalLight light, Cookie cookie) { }

	// RVA: 0x1606AA4
	public void Init(PointLight light, Cookie cookie) { }

	// RVA: 0x1606B1C
	public void Init(SpotLight light, Cookie cookie) { }

	// RVA: 0x1606B98
	public void Init(RectangleLight light, Cookie cookie) { }

	// RVA: 0x1606C0C
	public void Init(DiscLight light, Cookie cookie) { }

	// RVA: 0x1606C84
	public void InitNoBake(int lightInstanceID) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils
{
	// Methods

	// RVA: 0x1606C94
	public static LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x1606CAC
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x1606D30
	public static float ExtractInnerCone(Light l) { }

	// RVA: 0x1606D8C
	private static Color ExtractColorTemperature(Light l) { }

	// RVA: 0x1606E1C
	private static void ApplyColorTemperature(Color cct, LinearColor lightColor) { }

	// RVA: 0x1606E70
	public static void Extract(Light l, DirectionalLight dir) { }

	// RVA: 0x16070C4
	public static void Extract(Light l, PointLight point) { }

	// RVA: 0x1607330
	public static void Extract(Light l, SpotLight spot) { }

	// RVA: 0x16075FC
	public static void Extract(Light l, RectangleLight rect) { }

	// RVA: 0x1607868
	public static void Extract(Light l, DiscLight disc) { }

	// RVA: 0x1607AD4
	public static void Extract(Light l, Cookie cookie) { }

}

// Namespace: 
public sealed class RequestLightsDelegate
{
	// Methods

	// RVA: 0x1608020
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16080DC
	public virtual void Invoke(Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16080F0
	private static void .cctor() { }

	// RVA: 0x160815C
	public void .ctor() { }

	// RVA: 0x1608164
	internal void <.cctor>b__7_0(Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping
{
	// Fields
	private static readonly RequestLightsDelegate s_DefaultDelegate; // 0x0
	private static RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	// RVA: 0x1607C30
	public static void SetDelegate(RequestLightsDelegate del) { }

	// RVA: 0x1607CE0
	public static RequestLightsDelegate GetDelegate() { }

	// RVA: 0x1607D5C
	public static void ResetDelegate() { }

	// RVA: 0x1607DE0
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x1607EB0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct CameraPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x1608600
	public PlayableHandle GetHandle() { }

	// RVA: 0x160860C
	public bool Equals(CameraPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct MaterialEffectPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x16086F0
	public PlayableHandle GetHandle() { }

	// RVA: 0x16086FC
	public bool Equals(MaterialEffectPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct TextureMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x16087E0
	public PlayableHandle GetHandle() { }

	// RVA: 0x16087EC
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

	// RVA: 0x16088D0
	public bool TickRealtimeProbes() { }

	// RVA: 0x1608950
	public void Dispose() { }

	// RVA: 0x1608954
	private void Dispose(bool disposing) { }

	// RVA: 0x1608910
	private static bool BuiltinUpdate() { }

	// RVA: 0x1608958
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	// RVA: 0x16089B0
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

	// RVA: 0x16089B8
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0x1608B2C
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	// RVA: 0x1608BA8
	private static void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0x1608BE8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
internal class ScriptableRuntimeReflectionSystemWrapper
{
	// Fields
	private IScriptableRuntimeReflectionSystem <implementation>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1608C78
	internal IScriptableRuntimeReflectionSystem get_implementation() { }

	// RVA: 0x1608C80
	internal void set_implementation(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0x1608C88
	private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(bool result) { }

	// RVA: 0x1608C70
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

	// RVA: 0x1608D5C
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x1608E14
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x1608E7C
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x1608F34
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x1608F9C
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x16090BC
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	// RVA: 0x160910C
	internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits) { }

	// RVA: 0x16091B8
	public static int GetDepthBits(GraphicsFormat format) { }

	// RVA: 0x1609208
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	// RVA: 0x1609438
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	// RVA: 0x1609488
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	// RVA: 0x16094D8
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	// RVA: 0x1609528
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	// RVA: 0x1609578
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	// RVA: 0x16095C8
	public static bool IsCompressedFormat(TextureFormat format) { }

	// RVA: 0x1609674
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	// RVA: 0x16096DC
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	// RVA: 0x1609790
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	// RVA: 0x16097E0
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	// RVA: 0x1609830
	public static bool IsCrunchFormat(TextureFormat format) { }

	// RVA: 0x1609880
	private static void .cctor() { }

}

// Namespace: UnityEngine.Assertions
public static class Assert
{
	// Fields
	public static bool raiseExceptions; // 0x0

	// Methods

	// RVA: 0x1609970
	private static void Fail(string message, string userMessage) { }

	// RVA: 0x1609B4C
	public static void IsTrue(bool condition) { }

	// RVA: 0x1609C30
	public static void IsTrue(bool condition, string message) { }

	// RVA: 0x1609D90
	public static void IsFalse(bool condition, string message) { }

	// RVA: 0x315B3A8
	public static void AreEqual(T expected, T actual) { }

	// RVA: 0x315B3A8
	public static void AreEqual(T expected, T actual, string message) { }

	// RVA: 0x315B3A8
	public static void AreEqual(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer) { }

	// RVA: 0x1609E34
	public static void AreEqual(object expected, object actual, string message) { }

	// RVA: 0x315B3A8
	public static void IsNull(T value) { }

	// RVA: 0x315B3A8
	public static void IsNull(T value, string message) { }

	// RVA: 0x160A154
	public static void IsNull(object value, string message) { }

	// RVA: 0x315B3A8
	public static void IsNotNull(T value) { }

	// RVA: 0x315B3A8
	public static void IsNotNull(T value, string message) { }

	// RVA: 0x160A3C8
	public static void IsNotNull(object value, string message) { }

	// RVA: 0x160A4BC
	public static void AreEqual(int expected, int actual) { }

	// RVA: 0x160A574
	private static void .cctor() { }

}

// Namespace: UnityEngine.Assertions
public class AssertionException
{
	// Fields
	private string m_UserMessage; // 0x90

	// Methods

	// RVA: 0x1609AC4
	public void .ctor(string message, string userMessage) { }

	// RVA: 0x160A5C4
	public override string get_Message() { }

}

// Namespace: UnityEngine.Assertions
internal class AssertionMessageUtil
{
	// Methods

	// RVA: 0x160A638
	public static string GetMessage(string failureMessage) { }

	// RVA: 0x160A744
	public static string GetMessage(string failureMessage, string expected) { }

	// RVA: 0x1609F28
	public static string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	// RVA: 0x160A248
	public static string NullFailureMessage(object value, bool expectNull) { }

	// RVA: 0x1609CD4
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


