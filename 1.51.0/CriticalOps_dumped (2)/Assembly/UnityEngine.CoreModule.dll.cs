// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x162A4B0
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class IsUnmanagedAttribute
{
	// Methods

	// RVA: 0x162A4B8
	public void .ctor() { }

}

// Namespace: AOT
public class MonoPInvokeCallbackAttribute
{
	// Methods

	// RVA: 0x162A4C0
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

	// RVA: 0x162A4C8
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

	// RVA: 0x162A534
	public void .ctor(TypeInferenceRules rule) { }

	// RVA: 0x162A5C8
	public void .ctor(string rule) { }

	// RVA: 0x162A5FC
	public override string ToString() { }

}

// Namespace: UnityEngineInternal
public class GenericStack
{
	// Methods

	// RVA: 0x162A604
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

	// RVA: 0x352AE04
	internal static void Initialize() { }

	// RVA: 0x352CBB4
	public static void Execute(T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex) { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: Unity.Jobs
public static class IJobExtensions
{
	// Methods

	// RVA: 0x352AE04
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

	// RVA: 0x352AE04
	internal static void Initialize() { }

	// RVA: 0x352CBB4
	public static void Execute(T jobData, IntPtr additionalPtr, IntPtr bufferRangePatchData, JobRanges ranges, int jobIndex) { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: Unity.Jobs
public static class IJobParallelForExtensions
{
	// Methods

	// RVA: 0x3528F68
	private static IntPtr GetReflectionData() { }

	// RVA: 0x26AD93C
	public static JobHandle Schedule(T jobData, int arrayLength, int innerloopBatchCount, JobHandle dependsOn) { }

}

// Namespace: Unity.Jobs
public struct JobHandle
{
	// Fields
	internal UInt64 jobGroup; // 0x10
	internal int version; // 0x18

	// Methods

	// RVA: 0x162A60C
	public void Complete() { }

	// RVA: 0x162A6C0
	public static void ScheduleBatchedJobs() { }

	// RVA: 0x162A670
	private static void ScheduleBatchedJobsAndComplete(JobHandle job) { }

	// RVA: 0x162A700
	public static JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs) { }

	// RVA: 0x162A80C
	public static JobHandle CombineDependencies(Unity.Collections.NativeSlice<Unity.Jobs.JobHandle> jobs) { }

	// RVA: 0x162A7A4
	internal static JobHandle CombineDependenciesInternalPtr(Void* jobs, int count) { }

	// RVA: 0x162A938
	public bool Equals(JobHandle other) { }

	// RVA: 0x162A8E0
	private static void CombineDependenciesInternalPtr_Injected(Void* jobs, int count, JobHandle ret) { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public sealed class JobProducerTypeAttribute
{
	// Fields
	private readonly Type <ProducerType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x162A948
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

	// RVA: 0x162ACC0
	public void .ctor(Void* i_jobData, IntPtr i_reflectionData, JobHandle i_dependency, ScheduleMode i_scheduleMode) { }

}

// Namespace: 
internal sealed class PanicFunction_
{
	// Methods

	// RVA: 0x162AD04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x162ADA4
	public virtual void Invoke() { }

}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public static class JobsUtility
{
	// Fields
	internal static PanicFunction_ PanicFunction; // 0x0

	// Methods

	// RVA: 0x162A97C
	public static bool GetWorkStealingRange(JobRanges ranges, int jobIndex, int beginIndex, int endIndex) { }

	// RVA: 0x162A9E4
	public static JobHandle ScheduleParallelFor(JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount) { }

	// RVA: 0x162AABC
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x162AB2C
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x162AB98
	public static bool get_IsExecutingJob() { }

	// RVA: 0x162ABD8
	public static int get_ThreadIndex() { }

	// RVA: 0x162AC18
	public static int get_ThreadIndexCount() { }

	// RVA: 0x162AC58
	private static void InvokePanicFunction() { }

	// RVA: 0x162AA54
	private static void ScheduleParallelFor_Injected(JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, JobHandle ret) { }

}

// Namespace: Unity.IntegerTime
[Serializable]
public struct DiscreteTime
{
	// Fields
	public Int64 Value; // 0x10
	public static readonly DiscreteTime Zero; // 0x0
	public static readonly DiscreteTime MinValue; // 0x8
	public static readonly DiscreteTime MaxValue; // 0x10
	private static readonly int TicksPerSecondBits; // 0x18
	private static readonly int NonPow2TpsBits; // 0x1C

	// Methods

	// RVA: 0x162ADB8
	public void .ctor(float v) { }

	// RVA: 0x162AEC4
	public void .ctor(Double v) { }

	// RVA: 0x162AFCC
	private void .ctor(Int64 v, int _) { }

	// RVA: 0x162AFD4
	public static DiscreteTime FromTicks(Int64 v) { }

	// RVA: 0x162AFD8
	public static float op_Explicit(DiscreteTime d) { }

	// RVA: 0x162AFF4
	public static Double op_Explicit(DiscreteTime d) { }

	// RVA: 0x162B00C
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x162B018
	public static bool op_GreaterThan(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x162B024
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x162B030
	public static DiscreteTime op_Addition(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x162B0B4
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x162B138
	public bool Equals(DiscreteTime rhs) { }

	// RVA: 0x162B148
	public override bool Equals(object o) { }

	// RVA: 0x162B1F8
	public override int GetHashCode() { }

	// RVA: 0x162B200
	public override string ToString() { }

	// RVA: 0x162B28C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x162B330
	public int CompareTo(DiscreteTime other) { }

	// RVA: 0x162B338
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
public struct TicksPerSecond
{
	// Fields
	private UInt32 m_Numerator; // 0x10
	private UInt32 m_Denominator; // 0x14
	public static readonly TicksPerSecond DefaultTicksPerSecond; // 0x0
	public static readonly TicksPerSecond TicksPerSecond24; // 0x8
	public static readonly TicksPerSecond TicksPerSecond25; // 0x10
	public static readonly TicksPerSecond TicksPerSecond30; // 0x18
	public static readonly TicksPerSecond TicksPerSecond50; // 0x20
	public static readonly TicksPerSecond TicksPerSecond60; // 0x28
	public static readonly TicksPerSecond TicksPerSecond120; // 0x30
	public static readonly TicksPerSecond TicksPerSecond2397; // 0x38
	public static readonly TicksPerSecond TicksPerSecond2425; // 0x40
	public static readonly TicksPerSecond TicksPerSecond2997; // 0x48
	public static readonly TicksPerSecond TicksPerSecond5994; // 0x50
	public static readonly TicksPerSecond TicksPerSecond11988; // 0x58
	internal static readonly TicksPerSecond DiscreteTimeRate; // 0x60

	// Methods

	// RVA: 0x162B610
	public void .ctor(UInt32 num, UInt32 den) { }

	// RVA: 0x162B7DC
	public bool Equals(TicksPerSecond rhs) { }

	// RVA: 0x162B804
	public override bool Equals(object rhs) { }

	// RVA: 0x162B8C0
	public override int GetHashCode() { }

	// RVA: 0x162B730
	private static void Simplify(UInt32 num, UInt32 den) { }

	// RVA: 0x162B950
	private static UInt32 Gcd(UInt32 a, UInt32 b) { }

	// RVA: 0x162B974
	private static void .cctor() { }

}

// Namespace: Unity.IntegerTime
[Serializable]
public struct RationalTime
{
	// Fields
	private Int64 m_Count; // 0x10
	private TicksPerSecond m_TicksPerSecond; // 0x18

	// Methods

	// RVA: 0x162B4B4
	public Int64 get_Count() { }

	// RVA: 0x162B4BC
	public static DiscreteTime op_Explicit(RationalTime t) { }

}

// Namespace: Unity.IntegerTime
public static class RationalTimeExtensions
{
	// Methods

	// RVA: 0x162B5B0
	public static RationalTime Convert(RationalTime time, TicksPerSecond rate) { }

	// RVA: 0x162C154
	private static void Convert_Injected(RationalTime time, TicksPerSecond rate, RationalTime ret) { }

}

// Namespace: Unity.IL2CPP.CompilerServices
internal class Il2CppEagerStaticClassConstructionAttribute
{
	// Methods

	// RVA: 0x162C1AC
	public void .ctor() { }

}

// Namespace: Unity.Profiling
public sealed class IgnoredByDeepProfilerAttribute
{
	// Methods

	// RVA: 0x162C1B4
	public void .ctor() { }

}

// Namespace: Unity.Profiling
public struct ProfilerCategory
{
	// Fields
	private readonly UInt16 m_CategoryId; // 0x10

	// Methods

	// RVA: 0x162C1BC
	internal void .ctor(UInt16 category) { }

	// RVA: 0x162C1C4
	public string get_Name() { }

	// RVA: 0x162C3E0
	public override string ToString() { }

	// RVA: 0x162C470
	public static ProfilerCategory get_Scripts() { }

	// RVA: 0x162C478
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

	// RVA: 0x162C82C
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x162C890
	public void Dispose() { }

}

// Namespace: Unity.Profiling
public struct ProfilerMarker
{
	// Fields
	internal readonly IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x162C480
	public void .ctor(string name) { }

	// RVA: 0x162C66C
	public void .ctor(ProfilerCategory category, string name) { }

	// RVA: 0x162C6A0
	public void Begin() { }

	// RVA: 0x162C740
	public void End() { }

	// RVA: 0x162C7E0
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

	// RVA: 0x162C8F0
	public void set_RawImageDataReference(Unity.Collections.NativeArray<System.Byte> value) { }

	// RVA: 0x162C8F8
	public void set_ImageFormat(TextureFormat value) { }

	// RVA: 0x162C900
	public void set_Width(int value) { }

	// RVA: 0x162C908
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

	// RVA: 0x162C910
	internal static UInt16 CreateCategory__Unmanaged(Byte* name, int nameLen, ProfilerCategoryColor colorIndex) { }

	// RVA: 0x162C254
	public static ProfilerCategoryDescription GetCategoryDescription(UInt16 categoryId) { }

	// RVA: 0x162C4B4
	public static IntPtr CreateMarker(string name, UInt16 categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x162CA38
	internal static IntPtr CreateMarker__Unmanaged(Byte* name, int nameLen, UInt16 categoryId, MarkerFlags flags, int metadataCount) { }

	// RVA: 0x162CAA8
	internal static void SetMarkerMetadata__Unmanaged(IntPtr markerPtr, int index, Byte* name, int nameLen, Byte type, Byte unit) { }

	// RVA: 0x162C6F0
	public static void BeginSample(IntPtr markerPtr) { }

	// RVA: 0x162C790
	public static void EndSample(IntPtr markerPtr) { }

	// RVA: 0x162CB28
	internal static Void* CreateCounterValue__Unmanaged(IntPtr counterPtr, Byte* name, int nameLen, UInt16 categoryId, MarkerFlags flags, Byte dataType, Byte dataUnit, int dataSize, ProfilerCounterOptions counterOptions) { }

	// RVA: 0x162C2F4
	internal static string Utf8ToString(Byte* chars, int charsLen) { }

	// RVA: 0x162C968
	private static void GetCategoryDescription_Injected(UInt16 categoryId, ProfilerCategoryDescription ret) { }

	// RVA: 0x162C9D0
	private static IntPtr CreateMarker_Injected(ManagedSpanWrapper name, UInt16 categoryId, MarkerFlags flags, int metadataCount) { }

}

// Namespace: Unity.Profiling.Memory
public class MemorySnapshotMetadata
{
	// Fields
	private string <Description>k__BackingField; // 0x10
	private Byte[] <Data>k__BackingField; // 0x18

	// Methods

	// RVA: 0x162CBC8
	public string get_Description() { }

	// RVA: 0x162CBD0
	public void set_Description(string value) { }

	// RVA: 0x162CBD8
	internal Byte[] get_Data() { }

	// RVA: 0x162CBE0
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

	// RVA: 0x162CBE8
	private static Byte[] PrepareMetadata() { }

	// RVA: 0x162CEDC
	internal static int WriteIntToByteArray(Byte[] array, int offset, int value) { }

	// RVA: 0x162CF74
	internal static int WriteStringToByteArray(Byte[] array, int offset, string value) { }

	// RVA: 0x162D078
	private static void FinalizeSnapshot(string path, bool result) { }

	// RVA: 0x162D110
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
{
	// Methods

	// RVA: 0x162D220
	public void .ctor() { }

}

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
	public const Allocator Domain = 6;
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

	// RVA: 0x35267E8
	public void .ctor(Unity.Collections.NativeArray<T>& array) { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
	public void Reset() { }

	// RVA: 0x26AD93C
	public T get_Current() { }

	// RVA: 0x3525804
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

	// RVA: 0x35267E8
	public void .ctor(ReadOnly array) { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
	public void Reset() { }

	// RVA: 0x26AD93C
	public T get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: 
public struct ReadOnly
{
	// Fields
	internal Void* m_Buffer; // 0x0
	internal int m_Length; // 0x0

	// Methods

	// RVA: 0x26AD93C
	internal void .ctor(Void* buffer, int length) { }

	// RVA: 0x35254D0
	public int get_Length() { }

	// RVA: 0x26AD93C
	public T get_Item(int index) { }

	// RVA: 0x26AD93C
	public Enumerator GetEnumerator() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26AD93C
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

	// RVA: 0x3526850
	public void .ctor(T[] array, Allocator allocator) { }

	// RVA: -1
	private static void Allocate(int length, Allocator allocator, Unity.Collections.NativeArray<T>& array) { }

	// RVA: 0x35254D0
	public int get_Length() { }

	// RVA: 0x26AD93C
	public T get_Item(int index) { }

	// RVA: 0x26AD93C
	public void set_Item(int index, T value) { }

	// RVA: 0x35251DC
	public bool get_IsCreated() { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x26AD93C
	public void CopyFrom(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x3525804
	public T[] ToArray() { }

	// RVA: 0x26AD93C
	public Enumerator GetEnumerator() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26AD93C
	public bool Equals(Unity.Collections.NativeArray<T> other) { }

	// RVA: 0x35252FC
	public override bool Equals(object obj) { }

	// RVA: 0x35254D0
	public override int GetHashCode() { }

	// RVA: 0x26AD93C
	public static bool op_Equality(Unity.Collections.NativeArray<T> left, Unity.Collections.NativeArray<T> right) { }

	// RVA: 0x26AD93C
	public static void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst) { }

	// RVA: 0x26AD93C
	public static void Copy(T[] src, Unity.Collections.NativeArray<T> dst) { }

	// RVA: 0x26AD93C
	public static void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length) { }

	// RVA: 0x26AD93C
	public static void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x26AD93C
	public static void Copy(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x26AD93C
	private static void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x26AD93C
	private static void CopySafe(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length) { }

	// RVA: 0x26AD93C
	private static void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }

	// RVA: 0x26AD93C
	public ReadOnly AsReadOnly() { }

}

// Namespace: Unity.Collections
internal struct NativeArrayDispose
{
	// Fields
	internal Void* m_Buffer; // 0x10
	internal Allocator m_AllocatorLabel; // 0x18

	// Methods

	// RVA: 0x162D228
	public void Dispose() { }

}

// Namespace: Unity.Collections
internal struct NativeArrayDisposeJob
{
	// Fields
	internal NativeArrayDispose Data; // 0x10

	// Methods

	// RVA: 0x162D2F8
	public void Execute() { }

	// RVA: 0x162D360
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

	// RVA: 0x26AD93C
	public static Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeArray<T> thisArray, int start, int length) { }

	// RVA: 0x26AD93C
	public static Unity.Collections.NativeSlice<T> Slice(Unity.Collections.NativeSlice<T> thisSlice, int start, int length) { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Unity.Collections.NativeSlice<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Methods

	// RVA: 0x35267E8
	public void .ctor(Unity.Collections.NativeSlice<T>& array) { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x35263A0
	public void Reset() { }

	// RVA: 0x26AD93C
	public T get_Current() { }

	// RVA: 0x3525804
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

	// RVA: 0x26AD93C
	public void .ctor(Unity.Collections.NativeSlice<T> slice, int start, int length) { }

	// RVA: 0x26AD93C
	public void .ctor(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x26AD93C
	public static Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array) { }

	// RVA: 0x26AD93C
	public void .ctor(Unity.Collections.NativeArray<T> array, int start, int length) { }

	// RVA: 0x26AD93C
	public T get_Item(int index) { }

	// RVA: 0x26AD93C
	public void set_Item(int index, T value) { }

	// RVA: 0x26AD93C
	public void CopyFrom(Unity.Collections.NativeSlice<T> slice) { }

	// RVA: 0x35254D0
	public int get_Stride() { }

	// RVA: 0x35254D0
	public int get_Length() { }

	// RVA: 0x26AD93C
	public Enumerator GetEnumerator() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26AD93C
	public bool Equals(Unity.Collections.NativeSlice<T> other) { }

	// RVA: 0x35252FC
	public override bool Equals(object obj) { }

	// RVA: 0x35254D0
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

	// RVA: 0x26AD93C
	private void .ctor(Void* buffer) { }

	// RVA: 0x3525804
	public T get_Data() { }

	// RVA: 0x26AD93C
	public static Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate(UInt32 alignment) { }

}

// Namespace: 
internal static class SharedStatic
{
	// Methods

	// RVA: 0x162D3A4
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

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
internal static class BurstRuntime
{
	// Methods

	// RVA: 0x3528D58
	public static Int64 GetHashCode64() { }

	// RVA: 0x162D47C
	internal static Int64 HashStringWithFNV1A64(string text) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerAttribute
{
	// Methods

	// RVA: 0x162D50C
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsReadOnlyAttribute
{
	// Methods

	// RVA: 0x162D514
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerIsAtomicWriteOnlyAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsMinMaxWriteRestrictionAttribute
{
	// Methods

	// RVA: 0x162D51C
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute
{
	// Methods

	// RVA: 0x162D524
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeContainerSupportsDeferredConvertListToArray
{
	// Methods

	// RVA: 0x162D52C
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

	// RVA: 0x162D534
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableUnsafePtrRestrictionAttribute
{
	// Methods

	// RVA: 0x162D53C
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeDisableContainerSafetyRestrictionAttribute
{
	// Methods

	// RVA: 0x162D544
	public void .ctor() { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public sealed class NativeSetClassTypeToNullOnScheduleAttribute
{}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeArrayUnsafeUtility
{
	// Methods

	// RVA: 0x26AD93C
	public static Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray(Void* dataPointer, int length, Allocator allocator) { }

	// RVA: 0x26AD93C
	public static Void* GetUnsafePtr(Unity.Collections.NativeArray<T> nativeArray) { }

	// RVA: 0x26AD93C
	public static Void* GetUnsafeReadOnlyPtr(Unity.Collections.NativeArray<T> nativeArray) { }

	// RVA: 0x26AD93C
	public static Void* GetUnsafeBufferPointerWithoutChecks(Unity.Collections.NativeArray<T> nativeArray) { }

}

// Namespace: Unity.Collections.LowLevel.Unsafe
public static class NativeSliceUnsafeUtility
{
	// Methods

	// RVA: 0x26AD93C
	public static Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice(Void* dataPointer, int stride, int length) { }

	// RVA: 0x26AD93C
	public static Void* GetUnsafePtr(Unity.Collections.NativeSlice<T> nativeSlice) { }

	// RVA: 0x26AD93C
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

	// RVA: 0x162D54C
	public static Void* MallocTracked(Int64 size, int alignment, Allocator allocator, int callstacksToSkip) { }

	// RVA: 0x162D290
	public static void FreeTracked(Void* memory, Allocator allocator) { }

	// RVA: 0x162D5B4
	public static Void* Malloc(Int64 size, int alignment, Allocator allocator) { }

	// RVA: 0x162D60C
	public static void Free(Void* memory, Allocator allocator) { }

	// RVA: 0x162D020
	public static void MemCpy(Void* destination, Void* source, Int64 size) { }

	// RVA: 0x162D674
	public static void MemCpyStride(Void* destination, int destinationStride, Void* source, int sourceStride, int elementSize, int count) { }

	// RVA: 0x162D6F4
	public static void MemMove(Void* destination, Void* source, Int64 size) { }

	// RVA: 0x162D74C
	public static void MemSet(Void* destination, Byte value, Int64 size) { }

	// RVA: 0x162D7A4
	public static void MemClear(Void* destination, Int64 size) { }

	// RVA: 0x162D7F8
	public static int MemCmp(Void* ptr1, Void* ptr2, Int64 size) { }

	// RVA: 0x162D850
	public static bool IsBlittable(Type type) { }

	// RVA: 0x162D8A0
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x162D910
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x162DB2C
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: 0x162DBBC
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: 0x35280F8
	public static int AlignOf() { }

	// RVA: 0x26AD93C
	public static void CopyPtrToStructure(Void* ptr, T output) { }

	// RVA: 0x26AD93C
	private static void InternalCopyPtrToStructure(Void* ptr, T output) { }

	// RVA: 0x26AD93C
	public static T ReadArrayElement(Void* source, int index) { }

	// RVA: 0x26AD93C
	public static T ReadArrayElementWithStride(Void* source, int index, int stride) { }

	// RVA: 0x26AD93C
	public static void WriteArrayElement(Void* destination, int index, T value) { }

	// RVA: 0x26AD93C
	public static void WriteArrayElementWithStride(Void* destination, int index, int stride, T value) { }

	// RVA: 0x26AD93C
	public static Void* AddressOf(T output) { }

	// RVA: 0x35280F8
	public static int SizeOf() { }

	// RVA: 0x35293EC
	public static T As(U from) { }

	// RVA: 0x26AD93C
	internal static T As(object from) { }

	// RVA: 0x26AD93C
	public static T AsRef(Void* ptr) { }

	// RVA: 0x26AD93C
	public static int EnumToInt(T enumValue) { }

	// RVA: 0x352CF50
	private static void InternalEnumToInt(T enumValue, int intValue) { }

	// RVA: 0x26AD93C
	public static bool EnumEquals(T lhs, T rhs) { }

}

// Namespace: Unity.Burst
public class BurstAuthorizedExternalMethodAttribute
{
	// Methods

	// RVA: 0x162DC14
	public void .ctor() { }

}

// Namespace: Unity.Burst
public class BurstDiscardAttribute
{
	// Methods

	// RVA: 0x162DC1C
	public void .ctor() { }

}

// Namespace: Unity.Burst.LowLevel
internal static class BurstCompilerService
{
	// Methods

	// RVA: 0x162D424
	public static Void* GetOrCreateSharedMemory(Hash128 key, UInt32 size_of, UInt32 alignment) { }

}

// Namespace: JetBrains.Annotations
public sealed class CanBeNullAttribute
{
	// Methods

	// RVA: 0x162DC24
	public void .ctor() { }

}

// Namespace: JetBrains.Annotations
public sealed class NotNullAttribute
{
	// Methods

	// RVA: 0x162DC2C
	public void .ctor() { }

}

// Namespace: JetBrains.Annotations
public sealed class PureAttribute
{
	// Methods

	// RVA: 0x162DC34
	public void .ctor() { }

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

	// RVA: 0x162DC3C
	private void InvokeSpriteChanged() { }

	// RVA: 0x162DE7C
	public void set_sprite(Sprite value) { }

	// RVA: 0x162DFC8
	public void set_color(Color value) { }

	// RVA: 0x162E0D4
	public void .ctor() { }

	// RVA: 0x162DF60
	private static void set_sprite_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x162E06C
	private static void set_color_Injected(IntPtr _unity_self, Color value) { }

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

	// RVA: 0x162E0E4
	private void .ctor() { }

	// RVA: 0x162E16C
	internal int GetPackingRotation() { }

	// RVA: 0x162E254
	internal int GetPacked() { }

	// RVA: 0x162E33C
	internal Rect GetTextureRect() { }

	// RVA: 0x162E44C
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x162E55C
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x162E66C
	internal Vector4 GetPadding() { }

	// RVA: 0x162E77C
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x162E948
	public Bounds get_bounds() { }

	// RVA: 0x162EA70
	public Rect get_rect() { }

	// RVA: 0x162EB80
	public Vector4 get_border() { }

	// RVA: 0x162EC90
	public Texture2D get_texture() { }

	// RVA: 0x162ED98
	public float get_pixelsPerUnit() { }

	// RVA: 0x162EE80
	public Texture2D get_associatedAlphaSplitTexture() { }

	// RVA: 0x162EF88
	public Vector2 get_pivot() { }

	// RVA: 0x162F094
	public bool get_packed() { }

	// RVA: 0x162F12C
	public SpritePackingRotation get_packingRotation() { }

	// RVA: 0x162F1C4
	public Rect get_textureRect() { }

	// RVA: 0x162F26C
	public Vector2[] get_vertices() { }

	// RVA: 0x162F354
	public UInt16[] get_triangles() { }

	// RVA: 0x162F43C
	public Vector2[] get_uv() { }

	// RVA: 0x162F524
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x162F534
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	// RVA: 0x162F9AC
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x162F9C0
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType) { }

	// RVA: 0x162FAAC
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude) { }

	// RVA: 0x162FB94
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x162FC70
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x162E204
	private static int GetPackingRotation_Injected(IntPtr _unity_self) { }

	// RVA: 0x162E2EC
	private static int GetPacked_Injected(IntPtr _unity_self) { }

	// RVA: 0x162E3E4
	private static void GetTextureRect_Injected(IntPtr _unity_self, Rect ret) { }

	// RVA: 0x162E4F4
	private static void GetInnerUVs_Injected(IntPtr _unity_self, Vector4 ret) { }

	// RVA: 0x162E604
	private static void GetOuterUVs_Injected(IntPtr _unity_self, Vector4 ret) { }

	// RVA: 0x162E714
	private static void GetPadding_Injected(IntPtr _unity_self, Vector4 ret) { }

	// RVA: 0x162E8A0
	private static IntPtr CreateSprite_Injected(IntPtr texture, Rect rect, Vector2 pivot, float pixelsPerUnit, UInt32 extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x162EA08
	private static void get_bounds_Injected(IntPtr _unity_self, Bounds ret) { }

	// RVA: 0x162EB18
	private static void get_rect_Injected(IntPtr _unity_self, Rect ret) { }

	// RVA: 0x162EC28
	private static void get_border_Injected(IntPtr _unity_self, Vector4 ret) { }

	// RVA: 0x162ED48
	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	// RVA: 0x162EE30
	private static float get_pixelsPerUnit_Injected(IntPtr _unity_self) { }

	// RVA: 0x162EF38
	private static IntPtr get_associatedAlphaSplitTexture_Injected(IntPtr _unity_self) { }

	// RVA: 0x162F02C
	private static void get_pivot_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x162F304
	private static Vector2[] get_vertices_Injected(IntPtr _unity_self) { }

	// RVA: 0x162F3EC
	private static UInt16[] get_triangles_Injected(IntPtr _unity_self) { }

	// RVA: 0x162F4D4
	private static Vector2[] get_uv_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public struct SortingLayer
{
	// Fields
	private int m_Id; // 0x10

	// Methods

	// RVA: 0x162FD44
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

	// RVA: 0x162FD94
	public void .ctor(float time, float value) { }

	// RVA: 0x162FDA4
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x162FDB8
	public float get_time() { }

	// RVA: 0x162FDC0
	public float get_value() { }

	// RVA: 0x162FDC8
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

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1630994
	public static AnimationCurve ConvertToManaged(IntPtr ptr) { }

	// RVA: 0x1630A04
	public static IntPtr ConvertToNative(AnimationCurve animationCurve) { }

}

// Namespace: UnityEngine
public class AnimationCurve
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private bool m_RequiresNativeCleanup; // 0x18

	// Methods

	// RVA: 0x162FDD0
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x162FE20
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	// RVA: 0x162FF44
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x1630034
	protected override void Finalize() { }

	// RVA: 0x16300F4
	public float Evaluate(float time) { }

	// RVA: 0x16301E4
	public Keyframe[] get_keys() { }

	// RVA: 0x16301E8
	private Keyframe[] GetKeys() { }

	// RVA: 0x16303A8
	public override int GetHashCode() { }

	// RVA: 0x1630468
	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	// RVA: 0x1630478
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x16305E0
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x16305A4
	public void .ctor(Keyframe[] keys) { }

	// RVA: 0x16306F4
	public void .ctor() { }

	// RVA: 0x163072C
	internal void .ctor(IntPtr ptr, bool ownMemory) { }

	// RVA: 0x1630768
	public override bool Equals(object o) { }

	// RVA: 0x1630898
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x162FEF4
	private static IntPtr Internal_Create_Injected(ManagedSpanWrapper keys) { }

	// RVA: 0x162FFCC
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	// RVA: 0x163017C
	private static float Evaluate_Injected(IntPtr _unity_self, float time) { }

	// RVA: 0x1630340
	private static void GetKeys_Injected(IntPtr _unity_self, BlittableArrayWrapper ret) { }

	// RVA: 0x1630418
	private static int GetHashCode_Injected(IntPtr _unity_self) { }

}

// Namespace: 
public sealed class LowMemoryCallback
{
	// Methods

	// RVA: 0x1633560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1633600
	public virtual void Invoke() { }

}

// Namespace: 
public sealed class MemoryUsageChangedCallback
{
	// Methods

	// RVA: 0x1633614
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16336C8
	public virtual void Invoke(ApplicationMemoryUsageChange usage) { }

}

// Namespace: 
public sealed class LogCallback
{
	// Methods

	// RVA: 0x16336DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1633798
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

	// RVA: 0x1630A20
	public static void Quit(int exitCode) { }

	// RVA: 0x1630A70
	public static void Quit() { }

	// RVA: 0x1630B0C
	public static bool get_isPlaying() { }

	// RVA: 0x1630B4C
	public static bool get_isFocused() { }

	// RVA: 0x1630B8C
	public static bool get_runInBackground() { }

	// RVA: 0x1630BCC
	public static bool get_isBatchMode() { }

	// RVA: 0x1630C0C
	public static string get_dataPath() { }

	// RVA: 0x1630D74
	public static string get_streamingAssetsPath() { }

	// RVA: 0x1630EDC
	public static string get_persistentDataPath() { }

	// RVA: 0x1631044
	public static string get_temporaryCachePath() { }

	// RVA: 0x16311AC
	public static string get_unityVersion() { }

	// RVA: 0x1631314
	public static string get_version() { }

	// RVA: 0x163147C
	public static string get_identifier() { }

	// RVA: 0x16315E4
	public static ApplicationInstallMode get_installMode() { }

	// RVA: 0x1631624
	public static string get_cloudProjectId() { }

	// RVA: 0x163178C
	public static void OpenURL(string url) { }

	// RVA: 0x163197C
	public static int get_targetFrameRate() { }

	// RVA: 0x16319BC
	public static void set_targetFrameRate(int value) { }

	// RVA: 0x1631A0C
	private static void SetLogCallbackDefined(bool defined) { }

	// RVA: 0x1631A5C
	public static StackTraceLogType GetStackTraceLogType(LogType logType) { }

	// RVA: 0x1631AAC
	public static RuntimePlatform get_platform() { }

	// RVA: 0x1631AEC
	public static SystemLanguage get_systemLanguage() { }

	// RVA: 0x1631B2C
	public static NetworkReachability get_internetReachability() { }

	// RVA: 0x1631B6C
	public static void add_lowMemory(LowMemoryCallback value) { }

	// RVA: 0x1631C58
	public static void remove_lowMemory(LowMemoryCallback value) { }

	// RVA: 0x1631D44
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	// RVA: 0x1631EA8
	internal static bool HasLogCallback() { }

	// RVA: 0x1631F68
	public static void add_logMessageReceived(LogCallback value) { }

	// RVA: 0x1632088
	public static void remove_logMessageReceived(LogCallback value) { }

	// RVA: 0x163216C
	public static void add_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0x163228C
	public static void remove_logMessageReceivedThreaded(LogCallback value) { }

	// RVA: 0x1632370
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	// RVA: 0x1632478
	public static void add_focusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x163258C
	public static void remove_focusChanged(System.Action<System.Boolean> value) { }

	// RVA: 0x16326A0
	public static void add_quitting(Action value) { }

	// RVA: 0x1632790
	public static void remove_quitting(Action value) { }

	// RVA: 0x1632880
	private static bool Internal_ApplicationWantsToQuit() { }

	// RVA: 0x1632C04
	private static void Internal_InitializeExitCancellationToken() { }

	// RVA: 0x1632D1C
	private static void Internal_RaiseExitCancellationToken() { }

	// RVA: 0x1632DA4
	private static void Internal_ApplicationQuit() { }

	// RVA: 0x1632E54
	private static void Internal_ApplicationUnload() { }

	// RVA: 0x1632F04
	internal static void InvokeOnBeforeRender() { }

	// RVA: 0x163313C
	internal static void InvokeFocusChanged(bool focus) { }

	// RVA: 0x1633214
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x16332D8
	public static void RegisterLogCallback(LogCallback handler) { }

	// RVA: 0x1633360
	private static void RegisterLogCallback(LogCallback handler, bool threaded) { }

	// RVA: 0x16334D8
	public static bool get_isEditor() { }

	// RVA: 0x16334E0
	private static void .cctor() { }

	// RVA: 0x1630D24
	private static void get_dataPath_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x1630E8C
	private static void get_streamingAssetsPath_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x1630FF4
	private static void get_persistentDataPath_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x163115C
	private static void get_temporaryCachePath_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16312C4
	private static void get_unityVersion_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x163142C
	private static void get_version_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x1631594
	private static void get_identifier_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x163173C
	private static void get_cloudProjectId_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x163192C
	private static void OpenURL_Injected(ManagedSpanWrapper url) { }

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

	// RVA: 0x16337AC
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

	// RVA: 0x1631EA0
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
	public const RuntimePlatform CloudRendering = 4294967295;
	public const RuntimePlatform LinuxHeadlessSimulation = 35;
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
	public const RuntimePlatform Switch2 = 51;
	public const RuntimePlatform KeplerArm64 = 52;
	public const RuntimePlatform KeplerX64 = 53;
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

	// RVA: 0x16337B4
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

	// RVA: 0x1633868
	private void .ctor(IntPtr nativeHandle) { }

}

// Namespace: UnityEngine
public sealed class Caching
{
	// Methods

	// RVA: 0x16338E0
	public static bool get_ready() { }

	// RVA: 0x1633920
	public static void set_maximumAvailableDiskSpace(Int64 value) { }

}

// Namespace: UnityEngine
[Serializable]
internal class BatchRendererGroupRuntimeAnalytic
{
	// Fields
	private int brgRuntimeStatus; // 0x2C

	// Methods

	// RVA: 0x1633970
	private void .ctor() { }

	// RVA: 0x16339E8
	public static BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic() { }

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

	// RVA: 0x1641BF4
	public GateFitMode get_mode() { }

	// RVA: 0x1641BFC
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

	// RVA: 0x1641C04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1641CB8
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
	internal UInt32 m_NonSerializedVersion; // 0x18
	public static CameraCallback onPreCull; // 0x0
	public static CameraCallback onPreRender; // 0x8
	public static CameraCallback onPostRender; // 0x10

	// Methods

	// RVA: 0x1633A98
	public void .ctor() { }

	// RVA: 0x1633AA0
	public float get_nearClipPlane() { }

	// RVA: 0x1633B88
	public void set_nearClipPlane(float value) { }

	// RVA: 0x1633CA0
	public float get_farClipPlane() { }

	// RVA: 0x1633D88
	public void set_farClipPlane(float value) { }

	// RVA: 0x1633EA0
	public float get_fieldOfView() { }

	// RVA: 0x1633F88
	public void set_fieldOfView(float value) { }

	// RVA: 0x16340A0
	public RenderingPath get_renderingPath() { }

	// RVA: 0x1634188
	public void set_renderingPath(RenderingPath value) { }

	// RVA: 0x16342A0
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x1634388
	public void Reset() { }

	// RVA: 0x1634470
	public bool get_allowHDR() { }

	// RVA: 0x1634558
	public void set_allowHDR(bool value) { }

	// RVA: 0x1634670
	public bool get_allowMSAA() { }

	// RVA: 0x1634758
	public void set_allowMSAA(bool value) { }

	// RVA: 0x1634870
	public bool get_allowDynamicResolution() { }

	// RVA: 0x1634958
	public void set_allowDynamicResolution(bool value) { }

	// RVA: 0x1634A70
	public bool get_forceIntoRenderTexture() { }

	// RVA: 0x1634B58
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x1634C70
	public float get_orthographicSize() { }

	// RVA: 0x1634D58
	public void set_orthographicSize(float value) { }

	// RVA: 0x1634E70
	public bool get_orthographic() { }

	// RVA: 0x1634F58
	public void set_orthographic(bool value) { }

	// RVA: 0x1635070
	public OpaqueSortMode get_opaqueSortMode() { }

	// RVA: 0x1635158
	public void set_opaqueSortMode(OpaqueSortMode value) { }

	// RVA: 0x1635270
	public TransparencySortMode get_transparencySortMode() { }

	// RVA: 0x1635358
	public void set_transparencySortMode(TransparencySortMode value) { }

	// RVA: 0x1635470
	public Vector3 get_transparencySortAxis() { }

	// RVA: 0x1635584
	public void set_transparencySortAxis(Vector3 value) { }

	// RVA: 0x1635690
	public void ResetTransparencySortSettings() { }

	// RVA: 0x1635778
	public float get_depth() { }

	// RVA: 0x1635860
	public void set_depth(float value) { }

	// RVA: 0x1635978
	public float get_aspect() { }

	// RVA: 0x1635A60
	public void set_aspect(float value) { }

	// RVA: 0x1635B78
	public void ResetAspect() { }

	// RVA: 0x1635C60
	public Vector3 get_velocity() { }

	// RVA: 0x1635D74
	public int get_cullingMask() { }

	// RVA: 0x1635E5C
	public void set_cullingMask(int value) { }

	// RVA: 0x1635F74
	public int get_eventMask() { }

	// RVA: 0x163605C
	public void set_eventMask(int value) { }

	// RVA: 0x1636174
	public bool get_layerCullSpherical() { }

	// RVA: 0x16362A4
	public void set_layerCullSpherical(bool value) { }

	// RVA: 0x163620C
	internal bool get_layerCullSphericalInternal() { }

	// RVA: 0x16365A4
	internal void set_layerCullSphericalInternal(bool value) { }

	// RVA: 0x163670C
	public CameraType get_cameraType() { }

	// RVA: 0x16367F4
	public void set_cameraType(CameraType value) { }

	// RVA: 0x163690C
	internal Material get_skyboxMaterial() { }

	// RVA: 0x1636A14
	public UInt64 get_overrideSceneCullingMask() { }

	// RVA: 0x1636AFC
	public void set_overrideSceneCullingMask(UInt64 value) { }

	// RVA: 0x1636C14
	internal UInt64 get_sceneCullingMask() { }

	// RVA: 0x1636CFC
	internal bool get_useInteractiveLightBakingData() { }

	// RVA: 0x1636DE4
	internal void set_useInteractiveLightBakingData(bool value) { }

	// RVA: 0x1636EFC
	private float[] GetLayerCullDistances() { }

	// RVA: 0x16370C8
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x1637274
	public float[] get_layerCullDistances() { }

	// RVA: 0x1637278
	public void set_layerCullDistances(float[] value) { }

	// RVA: 0x16372EC
	internal static int get_PreviewCullingLayer() { }

	// RVA: 0x16372F4
	public bool get_useOcclusionCulling() { }

	// RVA: 0x16373DC
	public void set_useOcclusionCulling(bool value) { }

	// RVA: 0x16374F4
	public Matrix4x4 get_cullingMatrix() { }

	// RVA: 0x1637620
	public void set_cullingMatrix(Matrix4x4 value) { }

	// RVA: 0x1637738
	public void ResetCullingMatrix() { }

	// RVA: 0x1637820
	public Color get_backgroundColor() { }

	// RVA: 0x1637930
	public void set_backgroundColor(Color value) { }

	// RVA: 0x1637A3C
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x1637B24
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x1637C3C
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x1637D24
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x1637E3C
	public bool get_clearStencilAfterLightingPass() { }

	// RVA: 0x1637F24
	public void set_clearStencilAfterLightingPass(bool value) { }

	// RVA: 0x163803C
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x1638288
	public void ResetReplacementShader() { }

	// RVA: 0x1638370
	internal ProjectionMatrixMode get_projectionMatrixMode() { }

	// RVA: 0x1638458
	public bool get_usePhysicalProperties() { }

	// RVA: 0x1638540
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x1638658
	public int get_iso() { }

	// RVA: 0x1638740
	public void set_iso(int value) { }

	// RVA: 0x1638858
	public float get_shutterSpeed() { }

	// RVA: 0x1638940
	public void set_shutterSpeed(float value) { }

	// RVA: 0x1638A58
	public float get_aperture() { }

	// RVA: 0x1638B40
	public void set_aperture(float value) { }

	// RVA: 0x1638C58
	public float get_focusDistance() { }

	// RVA: 0x1638D40
	public void set_focusDistance(float value) { }

	// RVA: 0x1638E58
	public float get_focalLength() { }

	// RVA: 0x1638F40
	public void set_focalLength(float value) { }

	// RVA: 0x1639058
	public int get_bladeCount() { }

	// RVA: 0x1639140
	public void set_bladeCount(int value) { }

	// RVA: 0x1639258
	public Vector2 get_curvature() { }

	// RVA: 0x1639364
	public void set_curvature(Vector2 value) { }

	// RVA: 0x163946C
	public float get_barrelClipping() { }

	// RVA: 0x1639554
	public void set_barrelClipping(float value) { }

	// RVA: 0x163966C
	public float get_anamorphism() { }

	// RVA: 0x1639754
	public void set_anamorphism(float value) { }

	// RVA: 0x163986C
	public Vector2 get_sensorSize() { }

	// RVA: 0x1639978
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x1639A80
	public Vector2 get_lensShift() { }

	// RVA: 0x1639B8C
	public void set_lensShift(Vector2 value) { }

	// RVA: 0x1639C94
	public GateFitMode get_gateFit() { }

	// RVA: 0x1639D7C
	public void set_gateFit(GateFitMode value) { }

	// RVA: 0x1639E94
	public float GetGateFittedFieldOfView() { }

	// RVA: 0x1639F7C
	public Vector2 GetGateFittedLensShift() { }

	// RVA: 0x163A088
	internal Vector3 GetLocalSpaceAim() { }

	// RVA: 0x163A19C
	public Rect get_rect() { }

	// RVA: 0x163A2AC
	public void set_rect(Rect value) { }

	// RVA: 0x163A3B8
	public Rect get_pixelRect() { }

	// RVA: 0x163A4C8
	public void set_pixelRect(Rect value) { }

	// RVA: 0x163A5D4
	public int get_pixelWidth() { }

	// RVA: 0x163A6BC
	public int get_pixelHeight() { }

	// RVA: 0x163A7A4
	public int get_scaledPixelWidth() { }

	// RVA: 0x163A88C
	public int get_scaledPixelHeight() { }

	// RVA: 0x163A974
	public RenderTexture get_targetTexture() { }

	// RVA: 0x163AA7C
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x163ABC8
	public RenderTexture get_activeTexture() { }

	// RVA: 0x163ACD0
	public int get_targetDisplay() { }

	// RVA: 0x163ADB8
	public void set_targetDisplay(int value) { }

	// RVA: 0x163AED0
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x163AFD0
	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x163B078
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	// RVA: 0x163B1E4
	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	// RVA: 0x163B1E8
	internal string[] GetCameraBufferWarnings() { }

	// RVA: 0x163B2D0
	public Matrix4x4 get_cameraToWorldMatrix() { }

	// RVA: 0x163B3FC
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x163B528
	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	// RVA: 0x163B640
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x163B76C
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x163B884
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x163B9B0
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x163BAC8
	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	// RVA: 0x163BBB0
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x163BCC8
	public Matrix4x4 get_previousViewProjectionMatrix() { }

	// RVA: 0x163BDF4
	public void ResetWorldToCameraMatrix() { }

	// RVA: 0x163BEDC
	public void ResetProjectionMatrix() { }

	// RVA: 0x163BFC4
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	// RVA: 0x163C0EC
	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x163C21C
	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x163C34C
	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x163C47C
	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	// RVA: 0x163C5AC
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x163C668
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x163C724
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	// RVA: 0x163C7E0
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x163C89C
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x163C9AC
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x163CABC
	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	// RVA: 0x163CBD0
	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x163CD08
	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x163CDE0
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x163CEBC
	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x163CFF4
	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	// RVA: 0x163D0CC
	public Ray ScreenPointToRay(Vector3 pos) { }

	// RVA: 0x163D1A8
	private void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0x163D3A0
	public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	// RVA: 0x163D46C
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0x163D5A0
	public static void CalculateProjectionMatrixFromPhysicalProperties(Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters) { }

	// RVA: 0x163D63C
	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	// RVA: 0x163D6A0
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	// RVA: 0x163D704
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	// RVA: 0x163D768
	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	// RVA: 0x163D7CC
	public static Camera get_main() { }

	// RVA: 0x163D898
	public static Camera get_current() { }

	// RVA: 0x163D924
	private static Camera get_currentInternal() { }

	// RVA: 0x163D9F0
	public Scene get_scene() { }

	// RVA: 0x163DAFC
	public void set_scene(Scene value) { }

	// RVA: 0x163DC04
	public bool get_stereoEnabled() { }

	// RVA: 0x163DCEC
	public float get_stereoSeparation() { }

	// RVA: 0x163DDD4
	public void set_stereoSeparation(float value) { }

	// RVA: 0x163DEEC
	public float get_stereoConvergence() { }

	// RVA: 0x163DFD4
	public void set_stereoConvergence(float value) { }

	// RVA: 0x163E0EC
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	// RVA: 0x163E1D4
	public StereoTargetEyeMask get_stereoTargetEye() { }

	// RVA: 0x163E304
	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	// RVA: 0x163E26C
	internal StereoTargetEyeMask get_stereoTargetEyeInternal() { }

	// RVA: 0x163E4C0
	internal void set_stereoTargetEyeInternal(StereoTargetEyeMask value) { }

	// RVA: 0x163E628
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x163E710
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0x163E834
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	// RVA: 0x163E958
	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	// RVA: 0x163EA70
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	// RVA: 0x163EB94
	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x163EC90
	public void ResetStereoProjectionMatrices() { }

	// RVA: 0x163ED78
	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x163EE74
	public void ResetStereoViewMatrices() { }

	// RVA: 0x163EF5C
	private static int GetAllCamerasCount() { }

	// RVA: 0x163EF9C
	private static int GetAllCamerasImpl(Camera[] cam) { }

	// RVA: 0x163F088
	public static int get_allCamerasCount() { }

	// RVA: 0x163F0C8
	public static Camera[] get_allCameras() { }

	// RVA: 0x163F1C8
	public static int GetAllCameras(Camera[] cameras) { }

	// RVA: 0x163F2F0
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	// RVA: 0x163F424
	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	// RVA: 0x163F428
	public bool RenderToCubemap(Cubemap cubemap) { }

	// RVA: 0x163F430
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	// RVA: 0x163F434
	public bool RenderToCubemap(RenderTexture cubemap) { }

	// RVA: 0x163F43C
	private int GetFilterMode() { }

	// RVA: 0x163F524
	public SceneViewFilterMode get_sceneViewFilterMode() { }

	// RVA: 0x163F5BC
	public bool get_renderCloudsInSceneView() { }

	// RVA: 0x163F6A4
	public void set_renderCloudsInSceneView(bool value) { }

	// RVA: 0x163F7BC
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x163F908
	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x163F90C
	public void Render() { }

	// RVA: 0x163F9F4
	public void RenderWithShader(Shader shader, string replacementTag) { }

	// RVA: 0x163FC40
	public void RenderDontRestore() { }

	// RVA: 0x163FD28
	public void SubmitRenderRequests(System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests) { }

	// RVA: 0x26AD93C
	public void SubmitRenderRequest(RequestData renderRequest) { }

	// RVA: 0x163FF2C
	private void SubmitRenderRequestsInternal(object requests) { }

	// RVA: 0x1640044
	private object[] SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x16401A8
	public static void SetupCurrent(Camera cur) { }

	// RVA: 0x16402A8
	public void CopyFrom(Camera other) { }

	// RVA: 0x16403F4
	public int get_commandBufferCount() { }

	// RVA: 0x16404DC
	private void RemoveCommandBuffersImpl(CameraEvent evt) { }

	// RVA: 0x16405F4
	private void RemoveAllCommandBuffersImpl() { }

	// RVA: 0x16406DC
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x16408A0
	public void RemoveAllCommandBuffers() { }

	// RVA: 0x1640A58
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x1640BAC
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x1640D20
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x1640E74
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x164109C
	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	// RVA: 0x16412CC
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x16414F4
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	// RVA: 0x16416B4
	internal CommandBuffer[] GetCommandBuffersImpl(CameraEvent evt) { }

	// RVA: 0x16417CC
	private static void FireOnPreCull(Camera cam) { }

	// RVA: 0x1641848
	private static void FireOnPreRender(Camera cam) { }

	// RVA: 0x16418C4
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x1641940
	private static void BumpNonSerializedVersion(Camera cam) { }

	// RVA: 0x1641964
	internal void OnlyUsedForTesting1() { }

	// RVA: 0x1641968
	internal void OnlyUsedForTesting2() { }

	// RVA: 0x164196C
	public bool TryGetCullingParameters(ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x1641AD4
	public bool TryGetCullingParameters(bool stereoAware, ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x1641A18
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	// RVA: 0x1633B38
	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	// RVA: 0x1633C38
	private static void set_nearClipPlane_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1633D38
	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	// RVA: 0x1633E38
	private static void set_farClipPlane_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1633F38
	private static float get_fieldOfView_Injected(IntPtr _unity_self) { }

	// RVA: 0x1634038
	private static void set_fieldOfView_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1634138
	private static RenderingPath get_renderingPath_Injected(IntPtr _unity_self) { }

	// RVA: 0x1634238
	private static void set_renderingPath_Injected(IntPtr _unity_self, RenderingPath value) { }

	// RVA: 0x1634338
	private static RenderingPath get_actualRenderingPath_Injected(IntPtr _unity_self) { }

	// RVA: 0x1634420
	private static void Reset_Injected(IntPtr _unity_self) { }

	// RVA: 0x1634508
	private static bool get_allowHDR_Injected(IntPtr _unity_self) { }

	// RVA: 0x1634608
	private static void set_allowHDR_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1634708
	private static bool get_allowMSAA_Injected(IntPtr _unity_self) { }

	// RVA: 0x1634808
	private static void set_allowMSAA_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1634908
	private static bool get_allowDynamicResolution_Injected(IntPtr _unity_self) { }

	// RVA: 0x1634A08
	private static void set_allowDynamicResolution_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1634B08
	private static bool get_forceIntoRenderTexture_Injected(IntPtr _unity_self) { }

	// RVA: 0x1634C08
	private static void set_forceIntoRenderTexture_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1634D08
	private static float get_orthographicSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1634E08
	private static void set_orthographicSize_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1634F08
	private static bool get_orthographic_Injected(IntPtr _unity_self) { }

	// RVA: 0x1635008
	private static void set_orthographic_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1635108
	private static OpaqueSortMode get_opaqueSortMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1635208
	private static void set_opaqueSortMode_Injected(IntPtr _unity_self, OpaqueSortMode value) { }

	// RVA: 0x1635308
	private static TransparencySortMode get_transparencySortMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1635408
	private static void set_transparencySortMode_Injected(IntPtr _unity_self, TransparencySortMode value) { }

	// RVA: 0x163551C
	private static void get_transparencySortAxis_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1635628
	private static void set_transparencySortAxis_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x1635728
	private static void ResetTransparencySortSettings_Injected(IntPtr _unity_self) { }

	// RVA: 0x1635810
	private static float get_depth_Injected(IntPtr _unity_self) { }

	// RVA: 0x1635910
	private static void set_depth_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1635A10
	private static float get_aspect_Injected(IntPtr _unity_self) { }

	// RVA: 0x1635B10
	private static void set_aspect_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1635C10
	private static void ResetAspect_Injected(IntPtr _unity_self) { }

	// RVA: 0x1635D0C
	private static void get_velocity_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1635E0C
	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	// RVA: 0x1635F0C
	private static void set_cullingMask_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x163600C
	private static int get_eventMask_Injected(IntPtr _unity_self) { }

	// RVA: 0x163610C
	private static void set_eventMask_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1636654
	private static bool get_layerCullSphericalInternal_Injected(IntPtr _unity_self) { }

	// RVA: 0x16366A4
	private static void set_layerCullSphericalInternal_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16367A4
	private static CameraType get_cameraType_Injected(IntPtr _unity_self) { }

	// RVA: 0x16368A4
	private static void set_cameraType_Injected(IntPtr _unity_self, CameraType value) { }

	// RVA: 0x16369C4
	private static IntPtr get_skyboxMaterial_Injected(IntPtr _unity_self) { }

	// RVA: 0x1636AAC
	private static UInt64 get_overrideSceneCullingMask_Injected(IntPtr _unity_self) { }

	// RVA: 0x1636BAC
	private static void set_overrideSceneCullingMask_Injected(IntPtr _unity_self, UInt64 value) { }

	// RVA: 0x1636CAC
	private static UInt64 get_sceneCullingMask_Injected(IntPtr _unity_self) { }

	// RVA: 0x1636D94
	private static bool get_useInteractiveLightBakingData_Injected(IntPtr _unity_self) { }

	// RVA: 0x1636E94
	private static void set_useInteractiveLightBakingData_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1637060
	private static void GetLayerCullDistances_Injected(IntPtr _unity_self, BlittableArrayWrapper ret) { }

	// RVA: 0x163720C
	private static void SetLayerCullDistances_Injected(IntPtr _unity_self, ManagedSpanWrapper d) { }

	// RVA: 0x163738C
	private static bool get_useOcclusionCulling_Injected(IntPtr _unity_self) { }

	// RVA: 0x163748C
	private static void set_useOcclusionCulling_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16375B8
	private static void get_cullingMatrix_Injected(IntPtr _unity_self, Matrix4x4 ret) { }

	// RVA: 0x16376D0
	private static void set_cullingMatrix_Injected(IntPtr _unity_self, Matrix4x4 value) { }

	// RVA: 0x16377D0
	private static void ResetCullingMatrix_Injected(IntPtr _unity_self) { }

	// RVA: 0x16378C8
	private static void get_backgroundColor_Injected(IntPtr _unity_self, Color ret) { }

	// RVA: 0x16379D4
	private static void set_backgroundColor_Injected(IntPtr _unity_self, Color value) { }

	// RVA: 0x1637AD4
	private static CameraClearFlags get_clearFlags_Injected(IntPtr _unity_self) { }

	// RVA: 0x1637BD4
	private static void set_clearFlags_Injected(IntPtr _unity_self, CameraClearFlags value) { }

	// RVA: 0x1637CD4
	private static DepthTextureMode get_depthTextureMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1637DD4
	private static void set_depthTextureMode_Injected(IntPtr _unity_self, DepthTextureMode value) { }

	// RVA: 0x1637ED4
	private static bool get_clearStencilAfterLightingPass_Injected(IntPtr _unity_self) { }

	// RVA: 0x1637FD4
	private static void set_clearStencilAfterLightingPass_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1638230
	private static void SetReplacementShader_Injected(IntPtr _unity_self, IntPtr shader, ManagedSpanWrapper replacementTag) { }

	// RVA: 0x1638320
	private static void ResetReplacementShader_Injected(IntPtr _unity_self) { }

	// RVA: 0x1638408
	private static ProjectionMatrixMode get_projectionMatrixMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x16384F0
	private static bool get_usePhysicalProperties_Injected(IntPtr _unity_self) { }

	// RVA: 0x16385F0
	private static void set_usePhysicalProperties_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16386F0
	private static int get_iso_Injected(IntPtr _unity_self) { }

	// RVA: 0x16387F0
	private static void set_iso_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x16388F0
	private static float get_shutterSpeed_Injected(IntPtr _unity_self) { }

	// RVA: 0x16389F0
	private static void set_shutterSpeed_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1638AF0
	private static float get_aperture_Injected(IntPtr _unity_self) { }

	// RVA: 0x1638BF0
	private static void set_aperture_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1638CF0
	private static float get_focusDistance_Injected(IntPtr _unity_self) { }

	// RVA: 0x1638DF0
	private static void set_focusDistance_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1638EF0
	private static float get_focalLength_Injected(IntPtr _unity_self) { }

	// RVA: 0x1638FF0
	private static void set_focalLength_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x16390F0
	private static int get_bladeCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x16391F0
	private static void set_bladeCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x16392FC
	private static void get_curvature_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x1639404
	private static void set_curvature_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x1639504
	private static float get_barrelClipping_Injected(IntPtr _unity_self) { }

	// RVA: 0x1639604
	private static void set_barrelClipping_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1639704
	private static float get_anamorphism_Injected(IntPtr _unity_self) { }

	// RVA: 0x1639804
	private static void set_anamorphism_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1639910
	private static void get_sensorSize_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x1639A18
	private static void set_sensorSize_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x1639B24
	private static void get_lensShift_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x1639C2C
	private static void set_lensShift_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x1639D2C
	private static GateFitMode get_gateFit_Injected(IntPtr _unity_self) { }

	// RVA: 0x1639E2C
	private static void set_gateFit_Injected(IntPtr _unity_self, GateFitMode value) { }

	// RVA: 0x1639F2C
	private static float GetGateFittedFieldOfView_Injected(IntPtr _unity_self) { }

	// RVA: 0x163A020
	private static void GetGateFittedLensShift_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x163A134
	private static void GetLocalSpaceAim_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x163A244
	private static void get_rect_Injected(IntPtr _unity_self, Rect ret) { }

	// RVA: 0x163A350
	private static void set_rect_Injected(IntPtr _unity_self, Rect value) { }

	// RVA: 0x163A460
	private static void get_pixelRect_Injected(IntPtr _unity_self, Rect ret) { }

	// RVA: 0x163A56C
	private static void set_pixelRect_Injected(IntPtr _unity_self, Rect value) { }

	// RVA: 0x163A66C
	private static int get_pixelWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x163A754
	private static int get_pixelHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x163A83C
	private static int get_scaledPixelWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x163A924
	private static int get_scaledPixelHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x163AA2C
	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	// RVA: 0x163AB60
	private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x163AC80
	private static IntPtr get_activeTexture_Injected(IntPtr _unity_self) { }

	// RVA: 0x163AD68
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	// RVA: 0x163AE68
	private static void set_targetDisplay_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x163AF78
	private static void SetTargetBuffersImpl_Injected(IntPtr _unity_self, RenderBuffer color, RenderBuffer depth) { }

	// RVA: 0x163B18C
	private static void SetTargetBuffersMRTImpl_Injected(IntPtr _unity_self, ManagedSpanWrapper color, RenderBuffer depth) { }

	// RVA: 0x163B280
	private static string[] GetCameraBufferWarnings_Injected(IntPtr _unity_self) { }

	// RVA: 0x163B394
	private static void get_cameraToWorldMatrix_Injected(IntPtr _unity_self, Matrix4x4 ret) { }

	// RVA: 0x163B4C0
	private static void get_worldToCameraMatrix_Injected(IntPtr _unity_self, Matrix4x4 ret) { }

	// RVA: 0x163B5D8
	private static void set_worldToCameraMatrix_Injected(IntPtr _unity_self, Matrix4x4 value) { }

	// RVA: 0x163B704
	private static void get_projectionMatrix_Injected(IntPtr _unity_self, Matrix4x4 ret) { }

	// RVA: 0x163B81C
	private static void set_projectionMatrix_Injected(IntPtr _unity_self, Matrix4x4 value) { }

	// RVA: 0x163B948
	private static void get_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, Matrix4x4 ret) { }

	// RVA: 0x163BA60
	private static void set_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, Matrix4x4 value) { }

	// RVA: 0x163BB60
	private static bool get_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self) { }

	// RVA: 0x163BC60
	private static void set_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x163BD8C
	private static void get_previousViewProjectionMatrix_Injected(IntPtr _unity_self, Matrix4x4 ret) { }

	// RVA: 0x163BE8C
	private static void ResetWorldToCameraMatrix_Injected(IntPtr _unity_self) { }

	// RVA: 0x163BF74
	private static void ResetProjectionMatrix_Injected(IntPtr _unity_self) { }

	// RVA: 0x163C094
	private static void CalculateObliqueMatrix_Injected(IntPtr _unity_self, Vector4 clipPlane, Matrix4x4 ret) { }

	// RVA: 0x163C1B4
	private static void WorldToScreenPoint_Injected(IntPtr _unity_self, Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x163C2E4
	private static void WorldToViewportPoint_Injected(IntPtr _unity_self, Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x163C414
	private static void ViewportToWorldPoint_Injected(IntPtr _unity_self, Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x163C544
	private static void ScreenToWorldPoint_Injected(IntPtr _unity_self, Vector3 position, MonoOrStereoscopicEye eye, Vector3 ret) { }

	// RVA: 0x163C954
	private static void ScreenToViewportPoint_Injected(IntPtr _unity_self, Vector3 position, Vector3 ret) { }

	// RVA: 0x163CA64
	private static void ViewportToScreenPoint_Injected(IntPtr _unity_self, Vector3 position, Vector3 ret) { }

	// RVA: 0x163CB70
	private static void GetFrustumPlaneSizeAt_Injected(IntPtr _unity_self, float distance, Vector2 ret) { }

	// RVA: 0x163CCA0
	private static void ViewportPointToRay_Injected(IntPtr _unity_self, Vector2 pos, MonoOrStereoscopicEye eye, Ray ret) { }

	// RVA: 0x163CF8C
	private static void ScreenPointToRay_Injected(IntPtr _unity_self, Vector2 pos, MonoOrStereoscopicEye eye, Ray ret) { }

	// RVA: 0x163D328
	private static void CalculateFrustumCornersInternal_Injected(IntPtr _unity_self, Rect viewport, float z, MonoOrStereoscopicEye eye, BlittableArrayWrapper outCorners) { }

	// RVA: 0x163D508
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	// RVA: 0x163D858
	private static IntPtr get_main_Injected() { }

	// RVA: 0x163D9B0
	private static IntPtr get_currentInternal_Injected() { }

	// RVA: 0x163DA94
	private static void get_scene_Injected(IntPtr _unity_self, Scene ret) { }

	// RVA: 0x163DB9C
	private static void set_scene_Injected(IntPtr _unity_self, Scene value) { }

	// RVA: 0x163DC9C
	private static bool get_stereoEnabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x163DD84
	private static float get_stereoSeparation_Injected(IntPtr _unity_self) { }

	// RVA: 0x163DE84
	private static void set_stereoSeparation_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x163DF84
	private static float get_stereoConvergence_Injected(IntPtr _unity_self) { }

	// RVA: 0x163E084
	private static void set_stereoConvergence_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x163E184
	private static bool get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected(IntPtr _unity_self) { }

	// RVA: 0x163E570
	private static StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(IntPtr _unity_self) { }

	// RVA: 0x163E5C0
	private static void set_stereoTargetEyeInternal_Injected(IntPtr _unity_self, StereoTargetEyeMask value) { }

	// RVA: 0x163E6C0
	private static MonoOrStereoscopicEye get_stereoActiveEye_Injected(IntPtr _unity_self) { }

	// RVA: 0x163E7DC
	private static void GetStereoNonJitteredProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, Matrix4x4 ret) { }

	// RVA: 0x163E900
	private static void GetStereoViewMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, Matrix4x4 ret) { }

	// RVA: 0x163EA08
	private static void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(IntPtr _unity_self, StereoscopicEye eye) { }

	// RVA: 0x163EB3C
	private static void GetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, Matrix4x4 ret) { }

	// RVA: 0x163EC38
	private static void SetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x163ED28
	private static void ResetStereoProjectionMatrices_Injected(IntPtr _unity_self) { }

	// RVA: 0x163EE1C
	private static void SetStereoViewMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x163EF0C
	private static void ResetStereoViewMatrices_Injected(IntPtr _unity_self) { }

	// RVA: 0x163F038
	private static int GetAllCamerasImpl_Injected(Camera[] cam) { }

	// RVA: 0x163F3CC
	private static bool RenderToCubemapImpl_Injected(IntPtr _unity_self, IntPtr tex, int faceMask) { }

	// RVA: 0x163F4D4
	private static int GetFilterMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x163F654
	private static bool get_renderCloudsInSceneView_Injected(IntPtr _unity_self) { }

	// RVA: 0x163F754
	private static void set_renderCloudsInSceneView_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x163F8A0
	private static bool RenderToCubemapEyeImpl_Injected(IntPtr _unity_self, IntPtr cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	// RVA: 0x163F9A4
	private static void Render_Injected(IntPtr _unity_self) { }

	// RVA: 0x163FBE8
	private static void RenderWithShader_Injected(IntPtr _unity_self, IntPtr shader, ManagedSpanWrapper replacementTag) { }

	// RVA: 0x163FCD8
	private static void RenderDontRestore_Injected(IntPtr _unity_self) { }

	// RVA: 0x163FFDC
	private static void SubmitRenderRequestsInternal_Injected(IntPtr _unity_self, object requests) { }

	// RVA: 0x1640138
	private static object[] SubmitBuiltInObjectIDRenderRequest_Injected(IntPtr _unity_self, IntPtr target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	// RVA: 0x1640258
	private static void SetupCurrent_Injected(IntPtr cur) { }

	// RVA: 0x164038C
	private static void CopyFrom_Injected(IntPtr _unity_self, IntPtr other) { }

	// RVA: 0x164048C
	private static int get_commandBufferCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x164058C
	private static void RemoveCommandBuffersImpl_Injected(IntPtr _unity_self, CameraEvent evt) { }

	// RVA: 0x164068C
	private static void RemoveAllCommandBuffersImpl_Injected(IntPtr _unity_self) { }

	// RVA: 0x1640B54
	private static void AddCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	// RVA: 0x1640CB8
	private static void AddCommandBufferAsyncImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer, ComputeQueueType queueType) { }

	// RVA: 0x1640E1C
	private static void RemoveCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	// RVA: 0x1641764
	private static CommandBuffer[] GetCommandBuffersImpl_Injected(IntPtr _unity_self, CameraEvent evt) { }

	// RVA: 0x1641B8C
	private static bool GetCullingParameters_Internal_Injected(IntPtr camera, bool stereoAware, ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

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

	// RVA: 0x1641D34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1641DD8
	public virtual void Invoke(CullingGroupEvent sphere) { }

}

// Namespace: UnityEngine
public class CullingGroup
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private StateChanged m_OnStateChanged; // 0x18

	// Methods

	// RVA: 0x1641CCC
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

	// RVA: 0x1641DEC
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent) { }

	// RVA: 0x1641E9C
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x16420C4
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class DebugLogHandler
{
	// Methods

	// RVA: 0x16421B0
	internal static void Internal_Log(LogType level, LogOption options, string msg, object obj) { }

	// RVA: 0x16423E8
	internal static void Internal_LogException(Exception ex, object obj) { }

	// RVA: 0x164250C
	public void LogFormat(LogType logType, object context, string format, object[] args) { }

	// RVA: 0x164254C
	public void LogFormat(LogType logType, LogOption logOptions, object context, string format, object[] args) { }

	// RVA: 0x1642598
	public void LogException(Exception exception, object context) { }

	// RVA: 0x16426A0
	public void .ctor() { }

	// RVA: 0x1642380
	private static void Internal_Log_Injected(LogType level, LogOption options, ManagedSpanWrapper msg, IntPtr obj) { }

	// RVA: 0x16424A4
	private static void Internal_LogException_Injected(Exception ex, IntPtr obj) { }

}

// Namespace: UnityEngine
public class Debug
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Methods

	// RVA: 0x16426A8
	public static ILogger get_unityLogger() { }

	// RVA: 0x1642724
	public static int ExtractStackTraceNoAlloc(Byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x1642950
	public static void Log(object message) { }

	// RVA: 0x1642B18
	public static void LogFormat(LogType logType, LogOption logOptions, object context, string format, object[] args) { }

	// RVA: 0x1642ED8
	public static void LogError(object message) { }

	// RVA: 0x164301C
	public static void LogError(object message, object context) { }

	// RVA: 0x1643168
	public static void LogErrorFormat(string format, object[] args) { }

	// RVA: 0x16432B4
	public static void LogErrorFormat(object context, string format, object[] args) { }

	// RVA: 0x1632AC0
	public static void LogException(Exception exception) { }

	// RVA: 0x162DD34
	public static void LogException(Exception exception, object context) { }

	// RVA: 0x1636460
	public static void LogWarning(object message) { }

	// RVA: 0x164340C
	public static void LogWarning(object message, object context) { }

	// RVA: 0x1643558
	public static void LogWarningFormat(string format, object[] args) { }

	// RVA: 0x16436A4
	public static void LogWarningFormat(object context, string format, object[] args) { }

	// RVA: 0x16437FC
	public static void Assert(bool condition) { }

	// RVA: 0x1643954
	public static void Assert(bool condition, string message) { }

	// RVA: 0x1643AA4
	public static void LogAssertion(object message) { }

	// RVA: 0x1643BE8
	public static void LogAssertionFormat(string format, object[] args) { }

	// RVA: 0x1643D34
	public static bool get_isDebugBuild() { }

	// RVA: 0x1643D74
	internal static bool CallOverridenDebugHandler(Exception exception, object obj) { }

	// RVA: 0x1644124
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x16443C4
	private static void .cctor() { }

	// RVA: 0x16428F8
	private static int ExtractStackTraceNoAlloc_Injected(Byte* buffer, int bufferMax, ManagedSpanWrapper projectFolder) { }

}

// Namespace: 
internal class Expression
{
	// Fields
	internal readonly string[] rpnTokens; // 0x10
	internal readonly bool hasVariables; // 0x18

	// Methods

	// RVA: 0x1646898
	internal void .ctor(string expression) { }

	// RVA: -1
	public bool Evaluate(T value, int index, int count) { }

	// RVA: 0x1646928
	public override bool Equals(object obj) { }

	// RVA: 0x16469DC
	public override int GetHashCode() { }

	// RVA: 0x1646A00
	public override string ToString() { }

}

// Namespace: 
private struct PcgRandom
{
	// Fields
	private readonly UInt64 increment; // 0x10
	private UInt64 state; // 0x18

	// Methods

	// RVA: 0x1646824
	public void .ctor(UInt64 state, UInt64 sequence) { }

	// RVA: 0x1646278
	public UInt32 GetUInt() { }

	// RVA: 0x1646A90
	private static UInt32 RotateRight(UInt32 v, int rot) { }

	// RVA: 0x1646A78
	private static UInt32 XshRr(UInt64 s) { }

	// RVA: 0x1646A58
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

	// RVA: 0x164684C
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

	// RVA: 0x1646A98
	private static void .cctor() { }

	// RVA: 0x1646B04
	public void .ctor() { }

	// RVA: 0x1646B0C
	internal bool <ExpressionToTokens>b__14_0(string f) { }

}

// Namespace: UnityEngine
public class ExpressionEvaluator
{
	// Fields
	private static PcgRandom s_Random; // 0x0
	private static System.Collections.Generic.Dictionary<System.String,UnityEngine.ExpressionEvaluator.Operator> s_Operators; // 0x10

	// Methods

	// RVA: 0x3527DAC
	internal static bool Evaluate(string expression, T value, Expression delayed) { }

	// RVA: 0x26AD93C
	private static bool EvaluateTokens(string[] tokens, T value, int index, int count) { }

	// RVA: 0x16444C0
	private static bool EvaluateDouble(string[] tokens, Double value, int index, int count) { }

	// RVA: 0x1645220
	private static string[] InfixToRPN(string[] tokens) { }

	// RVA: 0x1645968
	private static bool NeedToPop(System.Collections.Generic.Stack<System.String> operatorStack, Operator newOperator) { }

	// RVA: 0x1645B20
	private static string[] ExpressionToTokens(string expression, bool hasVariables) { }

	// RVA: 0x1644D20
	private static bool IsCommand(string token) { }

	// RVA: 0x16451C0
	private static bool IsVariable(string token) { }

	// RVA: 0x164582C
	private static bool IsDelayedFunction(string token) { }

	// RVA: 0x1644BB4
	private static bool IsOperator(string token) { }

	// RVA: 0x1644C58
	private static Operator TokenToOperator(string token) { }

	// RVA: 0x1645EA0
	private static string PreFormatExpression(string expression) { }

	// RVA: 0x16460D8
	private static string[] FixUnaryOperators(string[] tokens) { }

	// RVA: 0x1644E54
	private static Double EvaluateOp(Double[] values, Op op, int index, int count) { }

	// RVA: 0x3527C54
	private static bool TryParse(string expression, T result) { }

	// RVA: 0x16462AC
	private static void .cctor() { }

}

// Namespace: UnityEngine
public struct Bounds
{
	// Fields
	private Vector3 m_Center; // 0x10
	private Vector3 m_Extents; // 0x1C

	// Methods

	// RVA: 0x1646C04
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x1646C24
	public override int GetHashCode() { }

	// RVA: 0x1646CF8
	public override bool Equals(object other) { }

	// RVA: 0x1646DC0
	public bool Equals(Bounds other) { }

	// RVA: 0x1646E14
	public Vector3 get_center() { }

	// RVA: 0x1646E20
	public void set_center(Vector3 value) { }

	// RVA: 0x1646E2C
	public Vector3 get_size() { }

	// RVA: 0x1646E44
	public void set_size(Vector3 value) { }

	// RVA: 0x1646E60
	public Vector3 get_extents() { }

	// RVA: 0x1646E6C
	public void set_extents(Vector3 value) { }

	// RVA: 0x1646E78
	public Vector3 get_min() { }

	// RVA: 0x1646E94
	public void set_min(Vector3 value) { }

	// RVA: 0x1646EE4
	public Vector3 get_max() { }

	// RVA: 0x1646F00
	public void set_max(Vector3 value) { }

	// RVA: 0x1646F50
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x1646FCC
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x164704C
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x1647084
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x16470FC
	public void Encapsulate(Bounds bounds) { }

	// RVA: 0x16471F8
	public bool Intersects(Bounds bounds) { }

	// RVA: 0x1647294
	public override string ToString() { }

	// RVA: 0x1647450
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x16475FC
	public bool Contains(Vector3 point) { }

	// RVA: 0x16476BC
	public float SqrDistance(Vector3 point) { }

	// RVA: 0x1647654
	private static bool Contains_Injected(Bounds _unity_self, Vector3 point) { }

	// RVA: 0x1647714
	private static float SqrDistance_Injected(Bounds _unity_self, Vector3 point) { }

}

// Namespace: UnityEngine
public struct BoundsInt
{
	// Fields
	private Vector3Int m_Position; // 0x10
	private Vector3Int m_Size; // 0x1C

	// Methods

	// RVA: 0x164777C
	public Vector3Int get_position() { }

	// RVA: 0x164778C
	public void set_position(Vector3Int value) { }

	// RVA: 0x1647798
	public Vector3Int get_size() { }

	// RVA: 0x16477A8
	public void set_size(Vector3Int value) { }

	// RVA: 0x16477B4
	public void .ctor(Vector3Int position, Vector3Int size) { }

	// RVA: 0x16477C8
	public override string ToString() { }

	// RVA: 0x1647960
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1647CD8
	public override bool Equals(object other) { }

	// RVA: 0x1647DB0
	public bool Equals(BoundsInt other) { }

	// RVA: 0x1647E14
	public override int GetHashCode() { }

}

// Namespace: UnityEngine
public sealed class GeometryUtility
{
	// Methods

	// RVA: 0x1647EF4
	public static Plane[] CalculateFrustumPlanes(Camera camera) { }

	// RVA: 0x1647F60
	public static void CalculateFrustumPlanes(Camera camera, Plane[] planes) { }

	// RVA: 0x1648120
	public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes) { }

	// RVA: 0x1648338
	public static bool TestPlanesAABB(Plane[] planes, Bounds bounds) { }

	// RVA: 0x1648214
	private static void Internal_ExtractPlanes(Plane[] planes, Matrix4x4 worldToProjectionMatrix) { }

	// RVA: 0x164841C
	private static bool TestPlanesAABB_Injected(ManagedSpanWrapper planes, Bounds bounds) { }

	// RVA: 0x1648484
	private static void Internal_ExtractPlanes_Injected(BlittableArrayWrapper planes, Matrix4x4 worldToProjectionMatrix) { }

}

// Namespace: UnityEngine
public struct Plane
{
	// Fields
	private Vector3 m_Normal; // 0x10
	private float m_Distance; // 0x1C

	// Methods

	// RVA: 0x16484EC
	public Vector3 get_normal() { }

	// RVA: 0x16484F8
	public float get_distance() { }

	// RVA: 0x1648500
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x1648630
	public void .ctor(Vector3 inNormal, float d) { }

	// RVA: 0x1648738
	public void .ctor(Vector3 a, Vector3 b, Vector3 c) { }

	// RVA: 0x16488AC
	public float GetDistanceToPoint(Vector3 point) { }

	// RVA: 0x16488D0
	public bool Raycast(Ray ray, float enter) { }

	// RVA: 0x16489DC
	public override string ToString() { }

	// RVA: 0x1648B98
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public struct Ray
{
	// Fields
	private Vector3 m_Origin; // 0x10
	private Vector3 m_Direction; // 0x1C

	// Methods

	// RVA: 0x1648D44
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x1648E50
	public Vector3 get_origin() { }

	// RVA: 0x1648E5C
	public void set_origin(Vector3 value) { }

	// RVA: 0x1648E68
	public Vector3 get_direction() { }

	// RVA: 0x1648E74
	public void set_direction(Vector3 value) { }

	// RVA: 0x1648F78
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x1648FA0
	public override string ToString() { }

	// RVA: 0x164915C
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

	// RVA: 0x1649308
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x1649314
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x1649320
	public void .ctor(Rect source) { }

	// RVA: 0x164932C
	public static Rect get_zero() { }

	// RVA: 0x1649340
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x164934C
	public float get_x() { }

	// RVA: 0x1649354
	public void set_x(float value) { }

	// RVA: 0x164935C
	public float get_y() { }

	// RVA: 0x1649364
	public void set_y(float value) { }

	// RVA: 0x164936C
	public Vector2 get_position() { }

	// RVA: 0x1649374
	public void set_position(Vector2 value) { }

	// RVA: 0x164937C
	public Vector2 get_center() { }

	// RVA: 0x1649394
	public void set_center(Vector2 value) { }

	// RVA: 0x16493B0
	public Vector2 get_min() { }

	// RVA: 0x16493B8
	public void set_min(Vector2 value) { }

	// RVA: 0x16493D4
	public Vector2 get_max() { }

	// RVA: 0x16493E8
	public void set_max(Vector2 value) { }

	// RVA: 0x16493FC
	public float get_width() { }

	// RVA: 0x1649404
	public void set_width(float value) { }

	// RVA: 0x164940C
	public float get_height() { }

	// RVA: 0x1649414
	public void set_height(float value) { }

	// RVA: 0x164941C
	public Vector2 get_size() { }

	// RVA: 0x1649424
	public void set_size(Vector2 value) { }

	// RVA: 0x164942C
	public float get_xMin() { }

	// RVA: 0x1649434
	public void set_xMin(float value) { }

	// RVA: 0x1649450
	public float get_yMin() { }

	// RVA: 0x1649458
	public void set_yMin(float value) { }

	// RVA: 0x1649474
	public float get_xMax() { }

	// RVA: 0x1649484
	public void set_xMax(float value) { }

	// RVA: 0x1649494
	public float get_yMax() { }

	// RVA: 0x16494A4
	public void set_yMax(float value) { }

	// RVA: 0x16494B4
	public bool Contains(Vector2 point) { }

	// RVA: 0x16494F8
	public bool Contains(Vector3 point) { }

	// RVA: 0x164953C
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x1649568
	public bool Overlaps(Rect other) { }

	// RVA: 0x16495B4
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x1649644
	public static Vector2 PointToNormalized(Rect rectangle, Vector2 point) { }

	// RVA: 0x16496B8
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x16496DC
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x1649700
	public override int GetHashCode() { }

	// RVA: 0x1649794
	public override bool Equals(object other) { }

	// RVA: 0x1649994
	public bool Equals(Rect other) { }

	// RVA: 0x1649A3C
	public override string ToString() { }

	// RVA: 0x1649A48
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

	// RVA: 0x1649CB8
	public int get_x() { }

	// RVA: 0x1649CC0
	public void set_x(int value) { }

	// RVA: 0x1649CC8
	public int get_y() { }

	// RVA: 0x1649CD0
	public void set_y(int value) { }

	// RVA: 0x1649CD8
	public int get_width() { }

	// RVA: 0x1649CE0
	public void set_width(int value) { }

	// RVA: 0x1649CE8
	public int get_height() { }

	// RVA: 0x1649CF0
	public void set_height(int value) { }

	// RVA: 0x1649CF8
	public int get_xMin() { }

	// RVA: 0x1649D68
	public int get_yMin() { }

	// RVA: 0x1649DD8
	public int get_xMax() { }

	// RVA: 0x1649E48
	public int get_yMax() { }

	// RVA: 0x1649EB8
	public void .ctor(int xMin, int yMin, int width, int height) { }

	// RVA: 0x1649EC4
	public bool Overlaps(RectInt other) { }

	// RVA: 0x164A5E4
	public override string ToString() { }

	// RVA: 0x164A840
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x164AA84
	public override int GetHashCode() { }

	// RVA: 0x164AB24
	public override bool Equals(object other) { }

	// RVA: 0x164ABE4
	public bool Equals(RectInt other) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x164C098
	public static IntPtr ConvertToNative(RectOffset rectOffset) { }

}

// Namespace: UnityEngine
[Serializable]
public class RectOffset
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Methods

	// RVA: 0x164AC28
	public void .ctor() { }

	// RVA: 0x164ACC4
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x164AD0C
	protected override void Finalize() { }

	// RVA: 0x164AE38
	public void .ctor(int left, int right, int top, int bottom) { }

	// RVA: 0x164B244
	public override string ToString() { }

	// RVA: 0x164B5DC
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x164ADE0
	private void Destroy() { }

	// RVA: 0x164AC84
	private static IntPtr InternalCreate() { }

	// RVA: 0x164BB04
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x164B944
	public int get_left() { }

	// RVA: 0x164B024
	public void set_left(int value) { }

	// RVA: 0x164B9B4
	public int get_right() { }

	// RVA: 0x164B0AC
	public void set_right(int value) { }

	// RVA: 0x164BA24
	public int get_top() { }

	// RVA: 0x164B134
	public void set_top(int value) { }

	// RVA: 0x164BA94
	public int get_bottom() { }

	// RVA: 0x164B1BC
	public void set_bottom(int value) { }

	// RVA: 0x164BE34
	public int get_horizontal() { }

	// RVA: 0x164BEF4
	public int get_vertical() { }

	// RVA: 0x164BFB4
	public Rect Remove(Rect rect) { }

	// RVA: 0x164BB54
	private static int get_left_Injected(IntPtr _unity_self) { }

	// RVA: 0x164BBA4
	private static void set_left_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x164BC0C
	private static int get_right_Injected(IntPtr _unity_self) { }

	// RVA: 0x164BC5C
	private static void set_right_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x164BCC4
	private static int get_top_Injected(IntPtr _unity_self) { }

	// RVA: 0x164BD14
	private static void set_top_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x164BD7C
	private static int get_bottom_Injected(IntPtr _unity_self) { }

	// RVA: 0x164BDCC
	private static void set_bottom_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x164BEA4
	private static int get_horizontal_Injected(IntPtr _unity_self) { }

	// RVA: 0x164BF64
	private static int get_vertical_Injected(IntPtr _unity_self) { }

	// RVA: 0x164C040
	private static void Remove_Injected(IntPtr _unity_self, Rect rect, Rect ret) { }

}

// Namespace: UnityEngine
public sealed class LightingSettings
{
	// Methods

	// RVA: 0x164C0B4
	internal void LightingSettingsDontStripMe() { }

}

// Namespace: UnityEngine
public sealed class Gizmos
{
	// Methods

	// RVA: 0x164C0B8
	public static void DrawLine(Vector3 from, Vector3 to) { }

	// RVA: 0x164C17C
	public static void DrawWireSphere(Vector3 center, float radius) { }

	// RVA: 0x164C244
	public static void DrawSphere(Vector3 center, float radius) { }

	// RVA: 0x164C30C
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	// RVA: 0x164C3D0
	public static void DrawCube(Vector3 center, Vector3 size) { }

	// RVA: 0x164C494
	public static void DrawMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x164C5E0
	public static void DrawWireMesh(Mesh mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x164C72C
	public static void set_color(Color value) { }

	// RVA: 0x164C7E4
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x164C884
	public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect) { }

	// RVA: 0x164C974
	public static void DrawRay(Vector3 from, Vector3 direction) { }

	// RVA: 0x164C9DC
	public static void DrawMesh(Mesh mesh) { }

	// RVA: 0x164CB54
	public static void DrawMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x164CC2C
	public static void DrawWireMesh(Mesh mesh) { }

	// RVA: 0x164CDA4
	public static void DrawWireMesh(Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x164C114
	private static void DrawLine_Injected(Vector3 from, Vector3 to) { }

	// RVA: 0x164C1DC
	private static void DrawWireSphere_Injected(Vector3 center, float radius) { }

	// RVA: 0x164C2A4
	private static void DrawSphere_Injected(Vector3 center, float radius) { }

	// RVA: 0x164C368
	private static void DrawWireCube_Injected(Vector3 center, Vector3 size) { }

	// RVA: 0x164C42C
	private static void DrawCube_Injected(Vector3 center, Vector3 size) { }

	// RVA: 0x164C570
	private static void DrawMesh_Injected(IntPtr mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x164C6BC
	private static void DrawWireMesh_Injected(IntPtr mesh, int submeshIndex, Vector3 position, Quaternion rotation, Vector3 scale) { }

	// RVA: 0x164C794
	private static void set_color_Injected(Color value) { }

	// RVA: 0x164C834
	private static void set_matrix_Injected(Matrix4x4 value) { }

	// RVA: 0x164C904
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

	// RVA: 0x1632F6C
	public static void Invoke() { }

	// RVA: 0x164CE7C
	private static void .cctor() { }

}

// Namespace: UnityEngine
public static class CustomRenderTextureManager
{
	// Fields
	private static System.Action<UnityEngine.CustomRenderTexture> textureLoaded; // 0x0
	private static System.Action<UnityEngine.CustomRenderTexture> textureUnloaded; // 0x8

	// Methods

	// RVA: 0x164CF18
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	// RVA: 0x164CF94
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }

}

// Namespace: 
public sealed class DisplaysUpdatedDelegate
{
	// Methods

	// RVA: 0x164D9BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x164DA5C
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

	// RVA: 0x164D010
	internal void .ctor() { }

	// RVA: 0x164D058
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x164D084
	public int get_renderingWidth() { }

	// RVA: 0x164D1A0
	public int get_renderingHeight() { }

	// RVA: 0x164D264
	public int get_systemWidth() { }

	// RVA: 0x164D380
	public int get_systemHeight() { }

	// RVA: 0x164D444
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x164D59C
	public static Display get_main() { }

	// RVA: 0x164D618
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	// RVA: 0x164D7C8
	internal static void FireDisplaysUpdated() { }

	// RVA: 0x164D328
	private static void GetSystemExtImpl(IntPtr nativeDisplay, int w, int h) { }

	// RVA: 0x164D148
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, int w, int h) { }

	// RVA: 0x164D534
	private static int RelativeMouseAtImpl(int x, int y, int rx, int ry) { }

	// RVA: 0x164D878
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

	// RVA: 0x164DA70
	public Double get_value() { }

	// RVA: 0x164DA84
	public bool Equals(RefreshRate other) { }

	// RVA: 0x164DAC4
	public int CompareTo(RefreshRate other) { }

	// RVA: 0x164DB30
	public override string ToString() { }

}

// Namespace: UnityEngine
public sealed class Screen
{
	// Methods

	// RVA: 0x164DBD8
	public static int get_width() { }

	// RVA: 0x164DC18
	public static int get_height() { }

	// RVA: 0x164DC58
	public static float get_dpi() { }

	// RVA: 0x164DC98
	private static ScreenOrientation GetScreenOrientation() { }

	// RVA: 0x164DCD8
	public static ScreenOrientation get_orientation() { }

	// RVA: 0x164DD18
	public static void set_sleepTimeout(int value) { }

	// RVA: 0x164DD68
	public static Resolution get_currentResolution() { }

	// RVA: 0x164DE08
	public static bool get_fullScreen() { }

	// RVA: 0x164DE48
	public static Rect get_safeArea() { }

	// RVA: 0x164DEEC
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	// RVA: 0x164DFC0
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	// RVA: 0x164E03C
	public static void SetResolution(int width, int height, bool fullscreen) { }

	// RVA: 0x164E0B4
	public static Resolution[] get_resolutions() { }

	// RVA: 0x164DDB8
	private static void get_currentResolution_Injected(Resolution ret) { }

	// RVA: 0x164DE9C
	private static void get_safeArea_Injected(Rect ret) { }

	// RVA: 0x164DF58
	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	// RVA: 0x164E1C4
	private static void get_resolutions_Injected(BlittableArrayWrapper ret) { }

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

	// RVA: 0x164E214
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	// RVA: 0x164E254
	private static void Internal_SetNullRT() { }

	// RVA: 0x164E294
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x164E3D4
	private static void Internal_DrawMeshNow2(Mesh mesh, int subsetIndex, Matrix4x4 matrix) { }

	// RVA: 0x164E538
	internal static void Internal_DrawTexture(Internal_DrawTextureArguments args) { }

	// RVA: 0x164E588
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	// RVA: 0x164E7A0
	private static void Blit2(Texture source, RenderTexture dest) { }

	// RVA: 0x164E938
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	// RVA: 0x164EA80
	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x164EBC0
	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x164ED44
	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x164EDC4
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

	// RVA: 0x164EE6C
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix, int materialIndex) { }

	// RVA: 0x164EFB0
	public static void DrawMeshNow(Mesh mesh, Matrix4x4 matrix) { }

	// RVA: 0x164F048
	public static void Blit(Texture source, RenderTexture dest) { }

	// RVA: 0x164F0D4
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x164F158
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x164F230
	public static void Blit(Texture source, Material mat, int pass) { }

	// RVA: 0x164F2B0
	public static void Blit(Texture source, Material mat) { }

	// RVA: 0x164F37C
	public static void SetRenderTarget(RenderTexture rt) { }

	// RVA: 0x164F440
	public static void SetRenderTarget(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel) { }

	// RVA: 0x164F530
	private static void .cctor() { }

	// RVA: 0x164E364
	private static void Internal_SetRTSimple_Injected(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	// RVA: 0x164E4E0
	private static void Internal_DrawMeshNow2_Injected(IntPtr mesh, int subsetIndex, Matrix4x4 matrix) { }

	// RVA: 0x164E730
	private static void Internal_BlitMaterial5_Injected(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT) { }

	// RVA: 0x164E8D0
	private static void Blit2_Injected(IntPtr source, IntPtr dest) { }

	// RVA: 0x164EA30
	private static void ExecuteCommandBuffer_Injected(IntPtr buffer) { }

}

// Namespace: UnityEngine
public sealed class GL
{
	// Methods

	// RVA: 0x164F5F0
	public static void Vertex3(float x, float y, float z) { }

	// RVA: 0x164F64C
	public static void Vertex(Vector3 v) { }

	// RVA: 0x164F6A8
	public static void TexCoord3(float x, float y, float z) { }

	// RVA: 0x164F704
	public static void TexCoord2(float x, float y) { }

	// RVA: 0x164F754
	private static void ImmediateColor(float r, float g, float b, float a) { }

	// RVA: 0x164F7B8
	public static void Color(Color c) { }

	// RVA: 0x164F81C
	public static void Flush() { }

	// RVA: 0x164F85C
	private static void SetViewMatrix(Matrix4x4 m) { }

	// RVA: 0x164F8FC
	public static void set_modelview(Matrix4x4 value) { }

	// RVA: 0x164F96C
	public static void PushMatrix() { }

	// RVA: 0x164F9AC
	public static void PopMatrix() { }

	// RVA: 0x164F9EC
	public static void LoadOrtho() { }

	// RVA: 0x164FA2C
	public static void LoadPixelMatrix() { }

	// RVA: 0x164FA6C
	public static void LoadProjectionMatrix(Matrix4x4 mat) { }

	// RVA: 0x164FB0C
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	// RVA: 0x164FBE4
	private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top) { }

	// RVA: 0x164FC48
	public static void LoadPixelMatrix(float left, float right, float bottom, float top) { }

	// RVA: 0x164FCAC
	public static void Begin(int mode) { }

	// RVA: 0x164FCFC
	public static void End() { }

	// RVA: 0x164FD3C
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x164FE1C
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x164FE94
	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x164FF00
	public static void Viewport(Rect pixelRect) { }

	// RVA: 0x164F8AC
	private static void SetViewMatrix_Injected(Matrix4x4 m) { }

	// RVA: 0x164FABC
	private static void LoadProjectionMatrix_Injected(Matrix4x4 mat) { }

	// RVA: 0x164FB8C
	private static void GetGPUProjectionMatrix_Injected(Matrix4x4 proj, bool renderIntoTexture, Matrix4x4 ret) { }

	// RVA: 0x164FDB4
	private static void GLClear_Injected(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x164FF68
	private static void Viewport_Injected(Rect pixelRect) { }

}

// Namespace: UnityEngine
public struct FrameTiming
{
	// Fields
	public Double cpuFrameTime; // 0x10
	public Double cpuMainThreadFrameTime; // 0x18
	public Double cpuMainThreadPresentWaitTime; // 0x20
	public Double cpuRenderThreadFrameTime; // 0x28
	public Double gpuFrameTime; // 0x30
	public UInt64 frameStartTimestamp; // 0x38
	public UInt64 firstSubmitTimestamp; // 0x40
	public UInt64 cpuTimePresentCalled; // 0x48
	public UInt64 cpuTimeFrameComplete; // 0x50
	public float heightScale; // 0x58
	public float widthScale; // 0x5C
	public UInt32 syncInterval; // 0x60
}

// Namespace: UnityEngine
public static class FrameTimingManager
{
	// Methods

	// RVA: 0x164FFB8
	public static bool IsFeatureEnabled() { }

	// RVA: 0x164FFF8
	public static void CaptureFrameTimings() { }

	// RVA: 0x1650038
	public static UInt32 GetLatestTimings(UInt32 numFrames, FrameTiming[] timings) { }

	// RVA: 0x165011C
	private static UInt32 GetLatestTimings_Injected(UInt32 numFrames, ManagedSpanWrapper timings) { }

}

// Namespace: UnityEngine
public sealed class LightmapSettings
{
	// Methods

	// RVA: 0x1650184
	public static void set_lightProbes(LightProbes value) { }

	// RVA: 0x1650234
	private static void set_lightProbes_Injected(IntPtr value) { }

}

// Namespace: UnityEngine
public sealed class LightProbes
{
	// Fields
	private static Action lightProbesUpdated; // 0x0
	private static Action tetrahedralizationCompleted; // 0x8
	private static Action needsRetetrahedralization; // 0x10

	// Methods

	// RVA: 0x1650284
	private void .ctor() { }

	// RVA: 0x165030C
	private static void Internal_CallLightProbesUpdatedFunction() { }

	// RVA: 0x1650374
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	// RVA: 0x16503DC
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }

	// RVA: 0x1650444
	public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, SphericalHarmonicsL2 probe) { }

	// RVA: 0x1650500
	private static void GetInterpolatedProbe_Injected(Vector3 position, IntPtr renderer, SphericalHarmonicsL2 probe) { }

}

// Namespace: UnityEngine
public struct Resolution
{
	// Fields
	private int m_Width; // 0x10
	private int m_Height; // 0x14
	private RefreshRate m_RefreshRate; // 0x18

	// Methods

	// RVA: 0x1650558
	public int get_width() { }

	// RVA: 0x1650560
	public int get_height() { }

	// RVA: 0x1650568
	public RefreshRate get_refreshRateRatio() { }

	// RVA: 0x1650570
	public int get_refreshRate() { }

	// RVA: 0x1650684
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

	// RVA: 0x1650820
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	// RVA: 0x16508A4
	public static float get_lodBias() { }

	// RVA: 0x16508E4
	public static void set_lodBias(float value) { }

	// RVA: 0x165093C
	public static void set_anisotropicFiltering(AnisotropicFiltering value) { }

	// RVA: 0x165098C
	public static int get_globalTextureMipmapLimit() { }

	// RVA: 0x16509CC
	public static void set_globalTextureMipmapLimit(int value) { }

	// RVA: 0x1650A1C
	public static void set_maximumLODLevel(int value) { }

	// RVA: 0x1650A6C
	public static int get_vSyncCount() { }

	// RVA: 0x1650AAC
	public static void set_vSyncCount(int value) { }

	// RVA: 0x1650AFC
	public static void set_antiAliasing(int value) { }

	// RVA: 0x1650B4C
	public static void SetTextureMipmapLimitSettings(string groupName, TextureMipmapLimitSettings textureMipmapLimitSettings) { }

	// RVA: 0x1650D30
	public static TextureMipmapLimitSettings GetTextureMipmapLimitSettings(string groupName) { }

	// RVA: 0x1650F20
	private static ScriptableObject get_INTERNAL_renderPipeline() { }

	// RVA: 0x1650FEC
	private static void set_INTERNAL_renderPipeline(ScriptableObject value) { }

	// RVA: 0x16510EC
	public static RenderPipelineAsset get_renderPipeline() { }

	// RVA: 0x16511F8
	public static void set_renderPipeline(RenderPipelineAsset value) { }

	// RVA: 0x16512A8
	public static ColorSpace get_activeColorSpace() { }

	// RVA: 0x1650CC8
	private static void SetTextureMipmapLimitSettings_Injected(ManagedSpanWrapper groupName, TextureMipmapLimitSettings textureMipmapLimitSettings) { }

	// RVA: 0x1650EB8
	private static void GetTextureMipmapLimitSettings_Injected(ManagedSpanWrapper groupName, TextureMipmapLimitSettings ret) { }

	// RVA: 0x1650FAC
	private static IntPtr get_INTERNAL_renderPipeline_Injected() { }

	// RVA: 0x165109C
	private static void set_INTERNAL_renderPipeline_Injected(IntPtr value) { }

}

// Namespace: UnityEngine
public sealed class TrailRenderer
{
	// Methods

	// RVA: 0x16512E8
	public void set_startColor(Color value) { }

	// RVA: 0x16513F4
	public void set_endColor(Color value) { }

	// RVA: 0x1651500
	public int get_positionCount() { }

	// RVA: 0x16515E8
	public void Clear() { }

	// RVA: 0x16516D0
	public void .ctor() { }

	// RVA: 0x165138C
	private static void set_startColor_Injected(IntPtr _unity_self, Color value) { }

	// RVA: 0x1651498
	private static void set_endColor_Injected(IntPtr _unity_self, Color value) { }

	// RVA: 0x1651598
	private static int get_positionCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1651680
	private static void Clear_Injected(IntPtr _unity_self) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1652794
	public static IntPtr ConvertToNative(MaterialPropertyBlock materialPropertyBlock) { }

}

// Namespace: UnityEngine
public sealed class MaterialPropertyBlock
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x16516D8
	private void SetFloatImpl(int name, float value) { }

	// RVA: 0x16517BC
	private void SetVectorImpl(int name, Vector4 value) { }

	// RVA: 0x16518A0
	private void SetColorImpl(int name, Color value) { }

	// RVA: 0x1651984
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x1651A58
	private void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x1651BAC
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	// RVA: 0x1651D2C
	private void SetVectorArrayImpl(int name, Vector4[] values, int count) { }

	// RVA: 0x1651EAC
	private static IntPtr CreateImpl() { }

	// RVA: 0x1651EEC
	private static void DestroyImpl(IntPtr mpb) { }

	// RVA: 0x1651F3C
	private void Clear(bool keepMemory) { }

	// RVA: 0x165202C
	public void Clear() { }

	// RVA: 0x16520A4
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x1652180
	private void SetVectorArray(int name, Vector4[] values, int count) { }

	// RVA: 0x165225C
	public void .ctor() { }

	// RVA: 0x16522B8
	protected override void Finalize() { }

	// RVA: 0x16523C8
	private void Dispose() { }

	// RVA: 0x1652478
	public void SetFloat(string name, float value) { }

	// RVA: 0x1652510
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x1652594
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x1652620
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x16526AC
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x1652758
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x165275C
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x1652778
	public void SetVectorArray(int nameID, Vector4[] values) { }

	// RVA: 0x165175C
	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	// RVA: 0x1651848
	private static void SetVectorImpl_Injected(IntPtr _unity_self, int name, Vector4 value) { }

	// RVA: 0x165192C
	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, Color value) { }

	// RVA: 0x1651A00
	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, Matrix4x4 value) { }

	// RVA: 0x1651B54
	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	// RVA: 0x1651CC4
	private static void SetFloatArrayImpl_Injected(IntPtr _unity_self, int name, ManagedSpanWrapper values, int count) { }

	// RVA: 0x1651E44
	private static void SetVectorArrayImpl_Injected(IntPtr _unity_self, int name, ManagedSpanWrapper values, int count) { }

	// RVA: 0x1651FC4
	private static void Clear_Injected(IntPtr _unity_self, bool keepMemory) { }

}

// Namespace: UnityEngine
public class Renderer
{
	// Methods

	// RVA: 0x16527B0
	public Bounds get_bounds() { }

	// RVA: 0x16528D8
	public void set_bounds(Bounds value) { }

	// RVA: 0x16529F0
	public void set_localBounds(Bounds value) { }

	// RVA: 0x1652B08
	private void SetStaticLightmapST(Vector4 st) { }

	// RVA: 0x1652C14
	private Material GetSharedMaterial() { }

	// RVA: 0x1652D1C
	private void SetMaterial(Material m) { }

	// RVA: 0x1652E68
	private Material[] GetMaterialArray() { }

	// RVA: 0x1652F50
	private void CopySharedMaterialArray(Material[] m) { }

	// RVA: 0x1653068
	private void SetMaterialArray(Material[] m, int length) { }

	// RVA: 0x1653194
	private void SetMaterialArray(Material[] m) { }

	// RVA: 0x16531BC
	internal void Internal_SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x16532D0
	internal void Internal_GetPropertyBlock(MaterialPropertyBlock dest) { }

	// RVA: 0x1653440
	public void SetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x16534EC
	public void GetPropertyBlock(MaterialPropertyBlock properties) { }

	// RVA: 0x16534F0
	public bool get_enabled() { }

	// RVA: 0x16535D8
	public void set_enabled(bool value) { }

	// RVA: 0x16536F0
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x1653808
	public void set_receiveShadows(bool value) { }

	// RVA: 0x1653920
	public LightProbeUsage get_lightProbeUsage() { }

	// RVA: 0x1653A08
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x1653B20
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	// RVA: 0x1653C38
	public void set_allowOcclusionWhenDynamic(bool value) { }

	// RVA: 0x1653D50
	public bool get_isPartOfStaticBatch() { }

	// RVA: 0x1653E38
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x1653F64
	public void set_probeAnchor(Transform value) { }

	// RVA: 0x16540B0
	private int GetLightmapIndex(LightmapType lt) { }

	// RVA: 0x16541C8
	private void SetLightmapIndex(int index, LightmapType lt) { }

	// RVA: 0x16542C4
	private Vector4 GetLightmapST(LightmapType lt) { }

	// RVA: 0x16543D4
	public int get_lightmapIndex() { }

	// RVA: 0x1654474
	public void set_lightmapIndex(int value) { }

	// RVA: 0x1654514
	public Vector4 get_lightmapScaleOffset() { }

	// RVA: 0x16545C0
	public void set_lightmapScaleOffset(Vector4 value) { }

	// RVA: 0x1654664
	private int GetMaterialCount() { }

	// RVA: 0x165474C
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x1654834
	public Material[] get_materials() { }

	// RVA: 0x16548CC
	public void set_materials(Material[] value) { }

	// RVA: 0x16549B0
	public Material get_sharedMaterial() { }

	// RVA: 0x16549B4
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x16549B8
	public Material[] get_sharedMaterials() { }

	// RVA: 0x1654A50
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x1654B34
	public void GetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material> m) { }

	// RVA: 0x162E0DC
	public void .ctor() { }

	// RVA: 0x1652870
	private static void get_bounds_Injected(IntPtr _unity_self, Bounds ret) { }

	// RVA: 0x1652988
	private static void set_bounds_Injected(IntPtr _unity_self, Bounds value) { }

	// RVA: 0x1652AA0
	private static void set_localBounds_Injected(IntPtr _unity_self, Bounds value) { }

	// RVA: 0x1652BAC
	private static void SetStaticLightmapST_Injected(IntPtr _unity_self, Vector4 st) { }

	// RVA: 0x1652CCC
	private static IntPtr GetSharedMaterial_Injected(IntPtr _unity_self) { }

	// RVA: 0x1652E00
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr m) { }

	// RVA: 0x1652F00
	private static Material[] GetMaterialArray_Injected(IntPtr _unity_self) { }

	// RVA: 0x1653000
	private static void CopySharedMaterialArray_Injected(IntPtr _unity_self, Material[] m) { }

	// RVA: 0x165313C
	private static void SetMaterialArray_Injected(IntPtr _unity_self, Material[] m, int length) { }

	// RVA: 0x1653268
	private static void Internal_SetPropertyBlock_Injected(IntPtr _unity_self, IntPtr properties) { }

	// RVA: 0x16533D8
	private static void Internal_GetPropertyBlock_Injected(IntPtr _unity_self, IntPtr dest) { }

	// RVA: 0x1653588
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x1653688
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16537A0
	private static void set_shadowCastingMode_Injected(IntPtr _unity_self, ShadowCastingMode value) { }

	// RVA: 0x16538B8
	private static void set_receiveShadows_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16539B8
	private static LightProbeUsage get_lightProbeUsage_Injected(IntPtr _unity_self) { }

	// RVA: 0x1653AB8
	private static void set_lightProbeUsage_Injected(IntPtr _unity_self, LightProbeUsage value) { }

	// RVA: 0x1653BD0
	private static void set_reflectionProbeUsage_Injected(IntPtr _unity_self, ReflectionProbeUsage value) { }

	// RVA: 0x1653CE8
	private static void set_allowOcclusionWhenDynamic_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1653DE8
	private static bool get_isPartOfStaticBatch_Injected(IntPtr _unity_self) { }

	// RVA: 0x1653EFC
	private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, Matrix4x4 ret) { }

	// RVA: 0x1654048
	private static void set_probeAnchor_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1654160
	private static int GetLightmapIndex_Injected(IntPtr _unity_self, LightmapType lt) { }

	// RVA: 0x165426C
	private static void SetLightmapIndex_Injected(IntPtr _unity_self, int index, LightmapType lt) { }

	// RVA: 0x165437C
	private static void GetLightmapST_Injected(IntPtr _unity_self, LightmapType lt, Vector4 ret) { }

	// RVA: 0x16546FC
	private static int GetMaterialCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x16547E4
	private static Material[] GetSharedMaterialArray_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public sealed class RenderSettings
{}

// Namespace: UnityEngine
public sealed class Shader
{
	// Methods

	// RVA: 0x1654D14
	public static Shader Find(string name) { }

	// RVA: 0x1654DA4
	public static int get_globalMaximumLOD() { }

	// RVA: 0x1654DE4
	public static void set_globalMaximumLOD(int value) { }

	// RVA: 0x1654E34
	public bool get_isSupported() { }

	// RVA: 0x1654F1C
	public static void set_globalRenderPipeline(string value) { }

	// RVA: 0x16550E0
	public static void EnableKeyword(string keyword) { }

	// RVA: 0x16552A4
	public static void DisableKeyword(string keyword) { }

	// RVA: 0x1655468
	public int get_renderQueue() { }

	// RVA: 0x1655550
	public static void WarmupAllShaders() { }

	// RVA: 0x1655590
	internal static int TagToID(string name) { }

	// RVA: 0x1655768
	public static int PropertyToID(string name) { }

	// RVA: 0x1655940
	private static void SetGlobalFloatImpl(int name, float value) { }

	// RVA: 0x16559A8
	private static void SetGlobalVectorImpl(int name, Vector4 value) { }

	// RVA: 0x1655A68
	private static void SetGlobalMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x1655B38
	private static void SetGlobalTextureImpl(int name, Texture value) { }

	// RVA: 0x1655C5C
	private static float GetGlobalFloatImpl(int name) { }

	// RVA: 0x1655CAC
	private static Vector4 GetGlobalVectorImpl(int name) { }

	// RVA: 0x1655D70
	public static void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x1655DD8
	public static void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x1655E54
	public static void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x1655EAC
	public static void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x1655F04
	public static void SetGlobalMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x1655F64
	public static void SetGlobalTexture(int nameID, Texture value) { }

	// RVA: 0x1656020
	public static float GetGlobalFloat(int nameID) { }

	// RVA: 0x1656070
	public static Vector4 GetGlobalVector(int nameID) { }

	// RVA: 0x16560CC
	private void .ctor() { }

	// RVA: 0x1654ECC
	private static bool get_isSupported_Injected(IntPtr _unity_self) { }

	// RVA: 0x1655090
	private static void set_globalRenderPipeline_Injected(ManagedSpanWrapper value) { }

	// RVA: 0x1655254
	private static void EnableKeyword_Injected(ManagedSpanWrapper keyword) { }

	// RVA: 0x1655418
	private static void DisableKeyword_Injected(ManagedSpanWrapper keyword) { }

	// RVA: 0x1655500
	private static int get_renderQueue_Injected(IntPtr _unity_self) { }

	// RVA: 0x1655718
	private static int TagToID_Injected(ManagedSpanWrapper name) { }

	// RVA: 0x16558F0
	private static int PropertyToID_Injected(ManagedSpanWrapper name) { }

	// RVA: 0x1655A00
	private static void SetGlobalVectorImpl_Injected(int name, Vector4 value) { }

	// RVA: 0x1655AD0
	private static void SetGlobalMatrixImpl_Injected(int name, Matrix4x4 value) { }

	// RVA: 0x1655BF4
	private static void SetGlobalTextureImpl_Injected(int name, IntPtr value) { }

	// RVA: 0x1655D08
	private static void GetGlobalVectorImpl_Injected(int name, Vector4 ret) { }

}

// Namespace: UnityEngine
public class Material
{
	// Fields
	private static readonly int k_ColorId; // 0x0
	private static readonly int k_MainTexId; // 0x4

	// Methods

	// RVA: 0x1656154
	private static void CreateWithShader(Material self, Shader shader) { }

	// RVA: 0x16562CC
	private static void CreateWithMaterial(Material self, Material source) { }

	// RVA: 0x1656444
	private static void CreateWithString(Material self) { }

	// RVA: 0x1656494
	public void .ctor(Shader shader) { }

	// RVA: 0x1656570
	public void .ctor(Material source) { }

	// RVA: 0x165664C
	public void .ctor(string contents) { }

	// RVA: 0x1656748
	internal static Material GetDefaultMaterial() { }

	// RVA: 0x1656844
	public Shader get_shader() { }

	// RVA: 0x165697C
	public void set_shader(Shader value) { }

	// RVA: 0x1656B00
	public Color get_color() { }

	// RVA: 0x1656C98
	public Texture get_mainTexture() { }

	// RVA: 0x1656D50
	public void set_mainTexture(Texture value) { }

	// RVA: 0x1656BB4
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	// RVA: 0x1656E70
	public bool HasProperty(int nameID) { }

	// RVA: 0x1656FB8
	public bool HasProperty(string name) { }

	// RVA: 0x1656FE4
	private bool HasFloatImpl(int name) { }

	// RVA: 0x165712C
	public bool HasFloat(int nameID) { }

	// RVA: 0x1657130
	public int get_renderQueue() { }

	// RVA: 0x1657254
	public void EnableKeyword(string keyword) { }

	// RVA: 0x16574A4
	public void DisableKeyword(string keyword) { }

	// RVA: 0x16576F4
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x1657960
	public bool SetPass(int pass) { }

	// RVA: 0x1657AA8
	public void CopyPropertiesFromMaterial(Material mat) { }

	// RVA: 0x1657C2C
	private string[] GetShaderKeywords() { }

	// RVA: 0x1657D50
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x1657E98
	public string[] get_shaderKeywords() { }

	// RVA: 0x1657E9C
	public void set_shaderKeywords(string[] value) { }

	// RVA: 0x1657EA0
	public int ComputeCRC() { }

	// RVA: 0x1657FC4
	private void SetFloatImpl(int name, float value) { }

	// RVA: 0x1658100
	private void SetColorImpl(int name, Color value) { }

	// RVA: 0x165823C
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	// RVA: 0x1658370
	private void SetTextureImpl(int name, Texture value) { }

	// RVA: 0x16584E0
	private float GetFloatImpl(int name) { }

	// RVA: 0x1658628
	private Color GetColorImpl(int name) { }

	// RVA: 0x1658768
	private Texture GetTextureImpl(int name) { }

	// RVA: 0x16588C0
	private void SetColorArrayImpl(int name, Color[] values, int count) { }

	// RVA: 0x1658A80
	private void SetColorArray(int name, Color[] values, int count) { }

	// RVA: 0x1658B5C
	public void SetInt(string name, int value) { }

	// RVA: 0x1658B90
	public void SetFloat(string name, float value) { }

	// RVA: 0x1658BCC
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x1658BD0
	public void SetColor(string name, Color value) { }

	// RVA: 0x1658C2C
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x1658C30
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x1658C34
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x1658C64
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x1656E04
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x1658C98
	public void SetColorArray(int nameID, Color[] values) { }

	// RVA: 0x1658CB4
	public float GetFloat(int nameID) { }

	// RVA: 0x1656C94
	public Color GetColor(int nameID) { }

	// RVA: 0x1658CB8
	public Texture GetTexture(string name) { }

	// RVA: 0x1656D4C
	public Texture GetTexture(int nameID) { }

	// RVA: 0x1658CE4
	private static void .cctor() { }

	// RVA: 0x1656264
	private static void CreateWithShader_Injected(Material self, IntPtr shader) { }

	// RVA: 0x16563DC
	private static void CreateWithMaterial_Injected(Material self, IntPtr source) { }

	// RVA: 0x1656804
	private static IntPtr GetDefaultMaterial_Injected() { }

	// RVA: 0x165692C
	private static IntPtr get_shader_Injected(IntPtr _unity_self) { }

	// RVA: 0x1656A98
	private static void set_shader_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1656E08
	private static int GetFirstPropertyNameIdByAttribute_Injected(IntPtr _unity_self, ShaderPropertyFlags attributeFlag) { }

	// RVA: 0x1656F50
	private static bool HasProperty_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x16570C4
	private static bool HasFloatImpl_Injected(IntPtr _unity_self, int name) { }

	// RVA: 0x1657204
	private static int get_renderQueue_Injected(IntPtr _unity_self) { }

	// RVA: 0x165743C
	private static void EnableKeyword_Injected(IntPtr _unity_self, ManagedSpanWrapper keyword) { }

	// RVA: 0x165768C
	private static void DisableKeyword_Injected(IntPtr _unity_self, ManagedSpanWrapper keyword) { }

	// RVA: 0x16578F8
	private static bool IsKeywordEnabled_Injected(IntPtr _unity_self, ManagedSpanWrapper keyword) { }

	// RVA: 0x1657A40
	private static bool SetPass_Injected(IntPtr _unity_self, int pass) { }

	// RVA: 0x1657BC4
	private static void CopyPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat) { }

	// RVA: 0x1657D00
	private static string[] GetShaderKeywords_Injected(IntPtr _unity_self) { }

	// RVA: 0x1657E30
	private static void SetShaderKeywords_Injected(IntPtr _unity_self, string[] names) { }

	// RVA: 0x1657F74
	private static int ComputeCRC_Injected(IntPtr _unity_self) { }

	// RVA: 0x16580A0
	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	// RVA: 0x16581E4
	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, Color value) { }

	// RVA: 0x1658318
	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, Matrix4x4 value) { }

	// RVA: 0x1658488
	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	// RVA: 0x16585C0
	private static float GetFloatImpl_Injected(IntPtr _unity_self, int name) { }

	// RVA: 0x1658710
	private static void GetColorImpl_Injected(IntPtr _unity_self, int name, Color ret) { }

	// RVA: 0x1658858
	private static IntPtr GetTextureImpl_Injected(IntPtr _unity_self, int name) { }

	// RVA: 0x1658A18
	private static void SetColorArrayImpl_Injected(IntPtr _unity_self, int name, ManagedSpanWrapper values, int count) { }

}

// Namespace: UnityEngine
public struct GraphicsBufferHandle
{
	// Fields
	public readonly UInt32 value; // 0x10

	// Methods

	// RVA: 0x1658D7C
	public override int GetHashCode() { }

	// RVA: 0x1658D84
	public override bool Equals(object obj) { }

	// RVA: 0x1658E14
	public bool Equals(GraphicsBufferHandle other) { }

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
	// Methods

	// RVA: 0x1658E24
	public LightType get_type() { }

	// RVA: 0x1658F0C
	public float get_spotAngle() { }

	// RVA: 0x1658FF4
	public Color get_color() { }

	// RVA: 0x1659104
	public float get_colorTemperature() { }

	// RVA: 0x16591EC
	public bool get_useColorTemperature() { }

	// RVA: 0x16592D4
	public float get_intensity() { }

	// RVA: 0x16593BC
	public float get_bounceIntensity() { }

	// RVA: 0x16594A4
	public float get_range() { }

	// RVA: 0x165958C
	public float get_dilatedRange() { }

	// RVA: 0x1659674
	public LightBakingOutput get_bakingOutput() { }

	// RVA: 0x165979C
	public LightShadows get_shadows() { }

	// RVA: 0x1659884
	public float get_cookieSize() { }

	// RVA: 0x165996C
	public Texture get_cookie() { }

	// RVA: 0x1658EBC
	private static LightType get_type_Injected(IntPtr _unity_self) { }

	// RVA: 0x1658FA4
	private static float get_spotAngle_Injected(IntPtr _unity_self) { }

	// RVA: 0x165909C
	private static void get_color_Injected(IntPtr _unity_self, Color ret) { }

	// RVA: 0x165919C
	private static float get_colorTemperature_Injected(IntPtr _unity_self) { }

	// RVA: 0x1659284
	private static bool get_useColorTemperature_Injected(IntPtr _unity_self) { }

	// RVA: 0x165936C
	private static float get_intensity_Injected(IntPtr _unity_self) { }

	// RVA: 0x1659454
	private static float get_bounceIntensity_Injected(IntPtr _unity_self) { }

	// RVA: 0x165953C
	private static float get_range_Injected(IntPtr _unity_self) { }

	// RVA: 0x1659624
	private static float get_dilatedRange_Injected(IntPtr _unity_self) { }

	// RVA: 0x1659734
	private static void get_bakingOutput_Injected(IntPtr _unity_self, LightBakingOutput ret) { }

	// RVA: 0x1659834
	private static LightShadows get_shadows_Injected(IntPtr _unity_self) { }

	// RVA: 0x165991C
	private static float get_cookieSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1659A24
	private static IntPtr get_cookie_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public sealed class MeshFilter
{
	// Methods

	// RVA: 0x1659A74
	private void DontStripMeshFilter() { }

	// RVA: 0x1659A78
	public Mesh get_sharedMesh() { }

	// RVA: 0x1659B80
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x1659CCC
	public void set_mesh(Mesh value) { }

	// RVA: 0x1659E18
	public void .ctor() { }

	// RVA: 0x1659B30
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x1659C64
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1659DB0
	private static void set_mesh_Injected(IntPtr _unity_self, IntPtr value) { }

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
	public const LightType Pyramid = 5;
	public const LightType Box = 6;
	public const LightType Tube = 7;
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
	public const TextureFormat R8_SIGNED = 75;
	public const TextureFormat RG16_SIGNED = 76;
	public const TextureFormat RGB24_SIGNED = 77;
	public const TextureFormat RGBA32_SIGNED = 78;
	public const TextureFormat R16_SIGNED = 79;
	public const TextureFormat RG32_SIGNED = 80;
	public const TextureFormat RGB48_SIGNED = 81;
	public const TextureFormat RGBA64_SIGNED = 82;
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
	public const RenderTextureCreationFlags DynamicallyScalableExplicit = 131072;
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
public enum MotionVectorGenerationMode
{
	// Fields
	public int value__; // 0x10
	public const MotionVectorGenerationMode Camera = 0;
	public const MotionVectorGenerationMode Object = 1;
	public const MotionVectorGenerationMode ForceNoMotion = 2;
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

	// RVA: 0x1659E20
	public void set_limitBiasMode(TextureMipmapLimitBiasMode value) { }

	// RVA: 0x1659E28
	public void set_limitBias(int value) { }

}

// Namespace: UnityEngine
public class SkinnedMeshRenderer
{
	// Methods

	// RVA: 0x1659E30
	public void set_quality(SkinQuality value) { }

	// RVA: 0x1659F48
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x165A060
	public void set_forceMatrixRecalculationPerRender(bool value) { }

	// RVA: 0x165A178
	public Transform get_rootBone() { }

	// RVA: 0x165A280
	public void set_rootBone(Transform value) { }

	// RVA: 0x165A3CC
	public Transform[] get_bones() { }

	// RVA: 0x165A4B4
	public void set_bones(Transform[] value) { }

	// RVA: 0x165A5CC
	public Mesh get_sharedMesh() { }

	// RVA: 0x165A6D4
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x165A820
	public void .ctor() { }

	// RVA: 0x1659EE0
	private static void set_quality_Injected(IntPtr _unity_self, SkinQuality value) { }

	// RVA: 0x1659FF8
	private static void set_updateWhenOffscreen_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x165A110
	private static void set_forceMatrixRecalculationPerRender_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x165A230
	private static IntPtr get_rootBone_Injected(IntPtr _unity_self) { }

	// RVA: 0x165A364
	private static void set_rootBone_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x165A464
	private static Transform[] get_bones_Injected(IntPtr _unity_self) { }

	// RVA: 0x165A564
	private static void set_bones_Injected(IntPtr _unity_self, Transform[] value) { }

	// RVA: 0x165A684
	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x165A7B8
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

}

// Namespace: UnityEngine
public class MeshRenderer
{
	// Methods

	// RVA: 0x165A828
	private void DontStripMeshRenderer() { }

	// RVA: 0x165A82C
	public Mesh get_additionalVertexStreams() { }

	// RVA: 0x165A934
	public void .ctor() { }

	// RVA: 0x165A8E4
	private static IntPtr get_additionalVertexStreams_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public sealed class LightProbeGroup
{
	// Methods

	// RVA: 0x165A93C
	public Vector3[] get_probePositions() { }

	// RVA: 0x165A944
	public void .ctor() { }

}

// Namespace: UnityEngine
public enum LODFadeMode
{
	// Fields
	public int value__; // 0x10
	public const LODFadeMode None = 0;
	public const LODFadeMode CrossFade = 1;
	public const LODFadeMode SpeedTree = 2;
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

	// RVA: 0x165A94C
	private static void Internal_Create(Mesh mono) { }

	// RVA: 0x165A99C
	public void .ctor() { }

	// RVA: 0x165AA60
	public void set_indexFormat(IndexFormat value) { }

	// RVA: 0x165AB78
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	// RVA: 0x165AC74
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x165ADD0
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x165AF3C
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x165B0B8
	private UInt32 GetIndexCountImpl(int submesh) { }

	// RVA: 0x165B1D0
	private UInt32 GetBaseVertexImpl(int submesh) { }

	// RVA: 0x165B2E8
	private int[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	// RVA: 0x165B4C8
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	// RVA: 0x165B6A8
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	// RVA: 0x165B834
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	// RVA: 0x165B94C
	public bool HasVertexAttribute(VertexAttribute attr) { }

	// RVA: 0x165BA64
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x165BBF0
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: 0x165BD0C
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	// RVA: 0x165BE38
	public IntPtr GetNativeIndexBufferPtr() { }

	// RVA: 0x165BF20
	private BoneWeight[] GetBoneWeightsImpl() { }

	// RVA: 0x165C0EC
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	// RVA: 0x165C260
	public Matrix4x4[] get_bindposes() { }

	// RVA: 0x165C42C
	public void set_bindposes(Matrix4x4[] value) { }

	// RVA: 0x165C5A0
	public bool get_isReadable() { }

	// RVA: 0x165C688
	internal bool get_canAccess() { }

	// RVA: 0x165C770
	public int get_vertexCount() { }

	// RVA: 0x165C858
	public int get_subMeshCount() { }

	// RVA: 0x165C940
	public void set_subMeshCount(int value) { }

	// RVA: 0x165CA58
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0x165CB74
	private void SetAllSubMeshesAtOnceFromArray(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags) { }

	// RVA: 0x165CD10
	public Bounds get_bounds() { }

	// RVA: 0x165CE38
	public void set_bounds(Bounds value) { }

	// RVA: 0x165CF50
	private void ClearImpl(bool keepVertexLayout) { }

	// RVA: 0x165D068
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	// RVA: 0x165D180
	private void MarkDynamicImpl() { }

	// RVA: 0x165D268
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	// RVA: 0x165D380
	private MeshTopology GetTopologyImpl(int submesh) { }

	// RVA: 0x165D498
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x165D510
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1
	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: -1
	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	// RVA: 0x165D5B0
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x26AD93C
	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags) { }

	// RVA: 0x26AD93C
	private void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags) { }

	// RVA: 0x26AD93C
	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x26AD93C
	private void SetListForChannel(VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1
	private void GetListForChannel(System.Collections.Generic.List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	// RVA: 0x26AD93C
	private void GetListForChannel(System.Collections.Generic.List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	// RVA: 0x165D940
	public Vector3[] get_vertices() { }

	// RVA: 0x165D998
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x165D9FC
	public Vector3[] get_normals() { }

	// RVA: 0x165DA54
	public void set_normals(Vector3[] value) { }

	// RVA: 0x165DAB8
	public Vector4[] get_tangents() { }

	// RVA: 0x165DB10
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x165DB74
	public Vector2[] get_uv() { }

	// RVA: 0x165DBCC
	public void set_uv(Vector2[] value) { }

	// RVA: 0x165DC30
	public Vector2[] get_uv2() { }

	// RVA: 0x165DC88
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x165DCEC
	public Color[] get_colors() { }

	// RVA: 0x165DD44
	public void set_colors(Color[] value) { }

	// RVA: 0x165DDA8
	public Color32[] get_colors32() { }

	// RVA: 0x165DE08
	public void set_colors32(Color32[] value) { }

	// RVA: 0x165DE74
	public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices) { }

	// RVA: 0x165DF20
	public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length) { }

	// RVA: 0x165DF9C
	public void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x165E024
	public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals) { }

	// RVA: 0x165E0D0
	public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length) { }

	// RVA: 0x165E14C
	public void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x165E1D4
	public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents) { }

	// RVA: 0x165E280
	public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length) { }

	// RVA: 0x165E2FC
	public void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x165E384
	public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors) { }

	// RVA: 0x165E448
	public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length) { }

	// RVA: 0x165E4DC
	public void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x26AD93C
	private void SetUvsImpl(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x165E57C
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs) { }

	// RVA: 0x165E6BC
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs) { }

	// RVA: 0x165E7FC
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x165E630
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length) { }

	// RVA: 0x165E93C
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x165E770
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length) { }

	// RVA: 0x165E9CC
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x165E8B0
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length) { }

	// RVA: 0x165EA5C
	public void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x26AD93C
	private void GetUVsImpl(int uvIndex, System.Collections.Generic.List<T> uvs, int dim) { }

	// RVA: 0x165EAEC
	public void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs) { }

	// RVA: 0x165EB5C
	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	// RVA: 0x26AD93C
	public void SetVertexBufferData(T[] data, int dataStart, int meshBufferStart, int count, int stream, MeshUpdateFlags flags) { }

	// RVA: 0x165EB60
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x165EC10
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x165EEAC
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x165EEB4
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x165EEBC
	public int[] get_triangles() { }

	// RVA: 0x165F034
	public void set_triangles(int[] value) { }

	// RVA: 0x165F328
	public int[] GetTriangles(int submesh) { }

	// RVA: 0x165F3B0
	public int[] GetTriangles(int submesh, bool applyBaseVertex) { }

	// RVA: 0x165F43C
	public int[] GetIndices(int submesh) { }

	// RVA: 0x165F4C4
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x26AD93C
	public void SetIndexBufferData(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags) { }

	// RVA: 0x165F550
	public UInt32 GetIndexCount(int submesh) { }

	// RVA: 0x165F6D4
	public UInt32 GetBaseVertex(int submesh) { }

	// RVA: 0x165F858
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x165F230
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	// RVA: 0x165FA00
	public void SetTriangles(int[] triangles, int submesh) { }

	// RVA: 0x165FA54
	public void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x165FAB8
	public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x165FBCC
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int submesh) { }

	// RVA: 0x165FCE4
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int submesh, bool calculateBounds) { }

	// RVA: 0x165FC50
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x165FD6C
	public void SetTriangles(System.Collections.Generic.List<System.Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x165FEFC
	public void SetIndices(int[] indices, MeshTopology topology, int submesh) { }

	// RVA: 0x165FFDC
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	// RVA: 0x165FF64
	public void SetIndices(int[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x1660050
	public void SetIndices(int[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x1660180
	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x16602B0
	public void SetIndices(System.Collections.Generic.List<System.Int32> indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x1660358
	public void SetIndices(System.Collections.Generic.List<System.Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x1660504
	public void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags) { }

	// RVA: 0x1660798
	public BoneWeight[] get_boneWeights() { }

	// RVA: 0x166079C
	public void set_boneWeights(BoneWeight[] value) { }

	// RVA: 0x16607A0
	public void Clear() { }

	// RVA: 0x1660840
	public void RecalculateBounds() { }

	// RVA: 0x1660848
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x1660A24
	public void MarkDynamic() { }

	// RVA: 0x1660B58
	public void UploadMeshData(bool markNoLongerReadable) { }

	// RVA: 0x1660C98
	public MeshTopology GetTopology(int submesh) { }

	// RVA: 0x165AB10
	private static void set_indexFormat_Injected(IntPtr _unity_self, IndexFormat value) { }

	// RVA: 0x165AC1C
	private static void SetIndexBufferParams_Injected(IntPtr _unity_self, int indexCount, IndexFormat format) { }

	// RVA: 0x165AD48
	private static void InternalSetIndexBufferDataFromArray_Injected(IntPtr _unity_self, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x165AEE4
	private static void SetVertexBufferParamsFromArray_Injected(IntPtr _unity_self, int vertexCount, ManagedSpanWrapper attributes) { }

	// RVA: 0x165B020
	private static void InternalSetVertexBufferDataFromArray_Injected(IntPtr _unity_self, int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	// RVA: 0x165B168
	private static UInt32 GetIndexCountImpl_Injected(IntPtr _unity_self, int submesh) { }

	// RVA: 0x165B280
	private static UInt32 GetBaseVertexImpl_Injected(IntPtr _unity_self, int submesh) { }

	// RVA: 0x165B460
	private static void GetTrianglesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, BlittableArrayWrapper ret) { }

	// RVA: 0x165B640
	private static void GetIndicesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, BlittableArrayWrapper ret) { }

	// RVA: 0x165B794
	private static void SetIndicesImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	// RVA: 0x165B8E4
	private static void PrintErrorCantAccessChannel_Injected(IntPtr _unity_self, VertexAttribute ch) { }

	// RVA: 0x165B9FC
	private static bool HasVertexAttribute_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	// RVA: 0x165BB50
	private static void SetArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x165BCA4
	private static Array GetAllocArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: 0x165BDC8
	private static void GetArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	// RVA: 0x165BED0
	private static IntPtr GetNativeIndexBufferPtr_Injected(IntPtr _unity_self) { }

	// RVA: 0x165C084
	private static void GetBoneWeightsImpl_Injected(IntPtr _unity_self, BlittableArrayWrapper ret) { }

	// RVA: 0x165C1F8
	private static void SetBoneWeightsImpl_Injected(IntPtr _unity_self, ManagedSpanWrapper weights) { }

	// RVA: 0x165C3C4
	private static void get_bindposes_Injected(IntPtr _unity_self, BlittableArrayWrapper ret) { }

	// RVA: 0x165C538
	private static void set_bindposes_Injected(IntPtr _unity_self, ManagedSpanWrapper value) { }

	// RVA: 0x165C638
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x165C720
	private static bool get_canAccess_Injected(IntPtr _unity_self) { }

	// RVA: 0x165C808
	private static int get_vertexCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x165C8F0
	private static int get_subMeshCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x165C9F0
	private static void set_subMeshCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x165CB0C
	private static void SetSubMesh_Injected(IntPtr _unity_self, int index, SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	// RVA: 0x165CCA0
	private static void SetAllSubMeshesAtOnceFromArray_Injected(IntPtr _unity_self, ManagedSpanWrapper desc, int start, int count, MeshUpdateFlags flags) { }

	// RVA: 0x165CDD0
	private static void get_bounds_Injected(IntPtr _unity_self, Bounds ret) { }

	// RVA: 0x165CEE8
	private static void set_bounds_Injected(IntPtr _unity_self, Bounds value) { }

	// RVA: 0x165D000
	private static void ClearImpl_Injected(IntPtr _unity_self, bool keepVertexLayout) { }

	// RVA: 0x165D118
	private static void RecalculateBoundsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	// RVA: 0x165D218
	private static void MarkDynamicImpl_Injected(IntPtr _unity_self) { }

	// RVA: 0x165D318
	private static void UploadMeshDataImpl_Injected(IntPtr _unity_self, bool markNoLongerReadable) { }

	// RVA: 0x165D430
	private static MeshTopology GetTopologyImpl_Injected(IntPtr _unity_self, int submesh) { }

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

	// RVA: 0x1660E44
	public float get_weight0() { }

	// RVA: 0x1660E4C
	public float get_weight1() { }

	// RVA: 0x1660E54
	public float get_weight2() { }

	// RVA: 0x1660E5C
	public float get_weight3() { }

	// RVA: 0x1660E64
	public int get_boneIndex0() { }

	// RVA: 0x1660E6C
	public int get_boneIndex1() { }

	// RVA: 0x1660E74
	public int get_boneIndex2() { }

	// RVA: 0x1660E7C
	public int get_boneIndex3() { }

	// RVA: 0x1660E84
	public override int GetHashCode() { }

	// RVA: 0x1660F98
	public override bool Equals(object other) { }

	// RVA: 0x1661038
	public bool Equals(BoneWeight other) { }

}

// Namespace: UnityEngine
public class Texture
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Methods

	// RVA: 0x1661114
	protected void .ctor() { }

	// RVA: 0x166119C
	public int get_mipmapCount() { }

	// RVA: 0x16612C0
	public static void SetGlobalAnisotropicFilteringLimits(int forcedMin, int globalMax) { }

	// RVA: 0x1661328
	private int GetDataWidth() { }

	// RVA: 0x166144C
	private int GetDataHeight() { }

	// RVA: 0x1661570
	public virtual int get_width() { }

	// RVA: 0x1661574
	public virtual void set_width(int value) { }

	// RVA: 0x16615B4
	public virtual int get_height() { }

	// RVA: 0x16615B8
	public virtual void set_height(int value) { }

	// RVA: 0x16615F8
	public virtual bool get_isReadable() { }

	// RVA: 0x166171C
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x1661840
	public void set_wrapMode(TextureWrapMode value) { }

	// RVA: 0x1661988
	public FilterMode get_filterMode() { }

	// RVA: 0x1661AAC
	public void set_filterMode(FilterMode value) { }

	// RVA: 0x1661BF4
	public void set_mipMapBias(float value) { }

	// RVA: 0x1661D30
	public Vector2 get_texelSize() { }

	// RVA: 0x1661E74
	private int Internal_GetActiveTextureColorSpace() { }

	// RVA: 0x1661F98
	internal ColorSpace get_activeTextureColorSpace() { }

	// RVA: 0x1661FB4
	private TextureColorSpace Internal_GetStoredColorSpace() { }

	// RVA: 0x16620D8
	public bool get_isDataSRGB() { }

	// RVA: 0x16620F4
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	// RVA: 0x16620FC
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	// RVA: 0x1662164
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x1662360
	internal bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	// RVA: 0x1662494
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x1662538
	internal UnityException IgnoreMipmapLimitCannotBeToggledException(Texture t) { }

	// RVA: 0x16625DC
	internal UnityException CreateNativeArrayLengthOverflowException() { }

	// RVA: 0x1662654
	private static void .cctor() { }

	// RVA: 0x1661270
	private static int get_mipmapCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x16613FC
	private static int GetDataWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x1661520
	private static int GetDataHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x16616CC
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x16617F0
	private static TextureWrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1661920
	private static void set_wrapMode_Injected(IntPtr _unity_self, TextureWrapMode value) { }

	// RVA: 0x1661A5C
	private static FilterMode get_filterMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1661B8C
	private static void set_filterMode_Injected(IntPtr _unity_self, FilterMode value) { }

	// RVA: 0x1661CC8
	private static void set_mipMapBias_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1661E0C
	private static void get_texelSize_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x1661F48
	private static int Internal_GetActiveTextureColorSpace_Injected(IntPtr _unity_self) { }

	// RVA: 0x1662088
	private static TextureColorSpace Internal_GetStoredColorSpace_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public sealed class Texture2D
{
	// Fields
	internal const int streamingMipmapsPriorityMin = 4294967168;
	internal const int streamingMipmapsPriorityMax = 127;

	// Methods

	// RVA: 0x16626A4
	public TextureFormat get_format() { }

	// RVA: 0x166278C
	private void SetIgnoreMipmapLimitAndReload(bool value) { }

	// RVA: 0x16628A4
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x1662970
	public void Compress(bool highQuality) { }

	// RVA: 0x1662A88
	private static bool Internal_CreateEmptyImpl(Texture2D mono) { }

	// RVA: 0x1662AD8
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x1662D6C
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x1662DEC
	public override bool get_isReadable() { }

	// RVA: 0x1662ED4
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x1662FD0
	private bool ReinitializeImpl(int width, int height) { }

	// RVA: 0x16630CC
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	// RVA: 0x1663220
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	// RVA: 0x1663378
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	// RVA: 0x16634A4
	private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x16635E0
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	// RVA: 0x16637C4
	private IntPtr GetWritableImageData(int frame) { }

	// RVA: 0x16638DC
	private UInt64 GetImageDataSize() { }

	// RVA: 0x16639C4
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x1663B30
	public Color32[] GetPixels32(int miplevel) { }

	// RVA: 0x1663C48
	public Color32[] GetPixels32() { }

	// RVA: 0x1663CE8
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x1663DCC
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x1663F20
	internal void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x166414C
	public void .ctor(int width, int height, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1664208
	public void .ctor(int width, int height, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x16642B8
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x1664500
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x1664528
	public void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x166453C
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x1664604
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x16646C0
	public void .ctor(int width, int height) { }

	// RVA: 0x16648D8
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x16649F0
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	// RVA: 0x1664A9C
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	// RVA: 0x1664B3C
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x26AD93C
	public Unity.Collections.NativeArray<T> GetRawTextureData() { }

	// RVA: 0x1664C3C
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x1664D14
	public void Apply() { }

	// RVA: 0x1664D20
	public bool Reinitialize(int width, int height) { }

	// RVA: 0x1664DF8
	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x1664EB4
	public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x1664FD4
	public void ReadPixels(Rect source, int destX, int destY) { }

	// RVA: 0x1664FDC
	public void SetPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x1664FE0
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x1664FE8
	public void set_ignoreMipmapLimit(bool value) { }

	// RVA: 0x166273C
	private static TextureFormat get_format_Injected(IntPtr _unity_self) { }

	// RVA: 0x166283C
	private static void SetIgnoreMipmapLimitAndReload_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1662930
	private static IntPtr get_whiteTexture_Injected() { }

	// RVA: 0x1662A20
	private static void Compress_Injected(IntPtr _unity_self, bool highQuality) { }

	// RVA: 0x1662CC0
	private static bool Internal_CreateImpl_Injected(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, ManagedSpanWrapper mipmapLimitGroupName) { }

	// RVA: 0x1662E84
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x1662F78
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x1663074
	private static bool ReinitializeImpl_Injected(IntPtr _unity_self, int width, int height) { }

	// RVA: 0x16631A0
	private static void SetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, Color color) { }

	// RVA: 0x16632F8
	private static void GetPixelBilinearImpl_Injected(IntPtr _unity_self, int image, int mip, float u, float v, Color ret) { }

	// RVA: 0x1663434
	private static bool ReinitializeWithTextureFormatImpl_Injected(IntPtr _unity_self, int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	// RVA: 0x1663570
	private static void ReadPixelsImpl_Injected(IntPtr _unity_self, Rect source, int destX, int destY, bool recalculateMipMaps) { }

	// RVA: 0x166372C
	private static void SetPixelsImpl_Injected(IntPtr _unity_self, int x, int y, int w, int h, ManagedSpanWrapper pixel, int miplevel, int frame) { }

	// RVA: 0x1663874
	private static IntPtr GetWritableImageData_Injected(IntPtr _unity_self, int frame) { }

	// RVA: 0x1663974
	private static UInt64 GetImageDataSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1663AD8
	private static void SetAllPixels32_Injected(IntPtr _unity_self, ManagedSpanWrapper colors, int miplevel) { }

	// RVA: 0x1663BE0
	private static Color32[] GetPixels32_Injected(IntPtr _unity_self, int miplevel) { }

}

// Namespace: UnityEngine
public sealed class Cubemap
{
	// Methods

	// RVA: 0x16650CC
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1665154
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x166522C
	public override bool get_isReadable() { }

	// RVA: 0x1665314
	internal bool ValidateFormat(TextureFormat format, int width) { }

	// RVA: 0x16653E4
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	// RVA: 0x1665524
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1665648
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x16655BC
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1665698
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x16658F0
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x1665B0C
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x1665BAC
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x1665C50
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x1665C5C
	public void .ctor(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	// RVA: 0x1665894
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x16652C4
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public sealed class Texture3D
{
	// Methods

	// RVA: 0x1665C68
	public override bool get_isReadable() { }

	// RVA: 0x1665D50
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1665DF0
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1665EE8
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x166603C
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1665F98
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x16660A4
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1666308
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x166632C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x166634C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x1666580
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x1666644
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x166670C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x16662AC
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x1665D00
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public sealed class Texture2DArray
{
	// Methods

	// RVA: 0x16667D4
	public static int get_allSlices() { }

	// RVA: 0x1666814
	public override bool get_isReadable() { }

	// RVA: 0x16668FC
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x1666B90
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x1666C10
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x1666CF4
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	// RVA: 0x1666E48
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1666FBC
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1667054
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x1666F08
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1667034
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x16670CC
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x1667394
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x1667624
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x1667644
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x1667668
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x1667740
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x166780C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x1667338
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x16668AC
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x1666AE4
	private static bool Internal_CreateImpl_Injected(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, ManagedSpanWrapper mipmapLimitGroupName) { }

}

// Namespace: UnityEngine
public sealed class CubemapArray
{
	// Methods

	// RVA: 0x16678D4
	public override bool get_isReadable() { }

	// RVA: 0x16679BC
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x1667A44
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x1667B1C
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1667C60
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1667BC4
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	// RVA: 0x1667CC0
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1667F28
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x1668150
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x1668158
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x1668210
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x16682C4
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x1667ECC
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x166796C
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public class RenderTexture
{
	// Methods

	// RVA: 0x166836C
	public override int get_width() { }

	// RVA: 0x1668454
	public override void set_width(int value) { }

	// RVA: 0x166856C
	public override int get_height() { }

	// RVA: 0x1668654
	public override void set_height(int value) { }

	// RVA: 0x166876C
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	// RVA: 0x1668884
	private void SetColorFormat(GraphicsFormat format) { }

	// RVA: 0x166899C
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x1668A3C
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x1668AEC
	public void set_useMipMap(bool value) { }

	// RVA: 0x1668C04
	public RenderTextureFormat get_format() { }

	// RVA: 0x1668F0C
	public GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x1668FF4
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x166910C
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x1669224
	private static RenderTexture GetActive() { }

	// RVA: 0x16692F0
	private static void SetActive(RenderTexture rt) { }

	// RVA: 0x16693F0
	public static RenderTexture get_active() { }

	// RVA: 0x166947C
	public static void set_active(RenderTexture value) { }

	// RVA: 0x166952C
	private RenderBuffer GetColorBuffer() { }

	// RVA: 0x1669638
	private RenderBuffer GetDepthBuffer() { }

	// RVA: 0x1669744
	private void SetMipMapCount(int count) { }

	// RVA: 0x166985C
	internal void SetShadowSamplingMode(ShadowSamplingMode samplingMode) { }

	// RVA: 0x1669974
	public RenderBuffer get_colorBuffer() { }

	// RVA: 0x1669A18
	public RenderBuffer get_depthBuffer() { }

	// RVA: 0x1669ABC
	public void DiscardContents(bool discardColor, bool discardDepth) { }

	// RVA: 0x1669BB8
	public void DiscardContents() { }

	// RVA: 0x1669C60
	public bool Create() { }

	// RVA: 0x1669D48
	public void Release() { }

	// RVA: 0x1669E30
	public bool IsCreated() { }

	// RVA: 0x1669F18
	internal void SetSRGBReadWrite(bool srgb) { }

	// RVA: 0x166A030
	private static void Internal_Create(RenderTexture rt) { }

	// RVA: 0x166A080
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	// RVA: 0x1668E3C
	private RenderTextureDescriptor GetDescriptor() { }

	// RVA: 0x166A200
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	// RVA: 0x166A2C8
	public static void ReleaseTemporary(RenderTexture temp) { }

	// RVA: 0x166A3C8
	public int get_depth() { }

	// RVA: 0x166A4B0
	protected internal void .ctor() { }

	// RVA: 0x166A590
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x166AB64
	public void .ctor(RenderTexture textureToCopy) { }

	// RVA: 0x166AF34
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	// RVA: 0x166B590
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	// RVA: 0x166B62C
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	// RVA: 0x166B14C
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x166BB3C
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x166BBD8
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x166C0FC
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	// RVA: 0x166C2A8
	public void .ctor(int width, int height, int depth) { }

	// RVA: 0x166C198
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x166BCF8
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	// RVA: 0x166BA9C
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	// RVA: 0x166C488
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format, bool disableFallback) { }

	// RVA: 0x166C6C4
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	// RVA: 0x166C6D0
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, ShadowSamplingMode shadowSamplingMode) { }

	// RVA: 0x166C4E0
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	// RVA: 0x166AE58
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x166A72C
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x166B108
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	// RVA: 0x166B124
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	// RVA: 0x166C4D0
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(RenderTextureFormat format) { }

	// RVA: 0x166B580
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(DefaultFormat format) { }

	// RVA: 0x166C600
	internal static void WarnAboutFallbackTo16BitsDepth(RenderTextureFormat format) { }

	// RVA: 0x166C338
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x166C778
	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	// RVA: 0x166C838
	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale, ShadowSamplingMode shadowSamplingMode) { }

	// RVA: 0x166CB28
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	// RVA: 0x166CBEC
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	// RVA: 0x166CCB0
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x166CD70
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x166CE24
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x166CED4
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	// RVA: 0x166CF84
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	// RVA: 0x166D058
	public static RenderTexture GetTemporary(int width, int height) { }

	// RVA: 0x1668404
	private static int get_width_Injected(IntPtr _unity_self) { }

	// RVA: 0x1668504
	private static void set_width_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1668604
	private static int get_height_Injected(IntPtr _unity_self) { }

	// RVA: 0x1668704
	private static void set_height_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x166881C
	private static GraphicsFormat GetColorFormat_Injected(IntPtr _unity_self, bool suppressWarnings) { }

	// RVA: 0x1668934
	private static void SetColorFormat_Injected(IntPtr _unity_self, GraphicsFormat format) { }

	// RVA: 0x1668B9C
	private static void set_useMipMap_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1668FA4
	private static GraphicsFormat get_depthStencilFormat_Injected(IntPtr _unity_self) { }

	// RVA: 0x16690A4
	private static void set_depthStencilFormat_Injected(IntPtr _unity_self, GraphicsFormat value) { }

	// RVA: 0x16691BC
	private static void set_autoGenerateMips_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16692B0
	private static IntPtr GetActive_Injected() { }

	// RVA: 0x16693A0
	private static void SetActive_Injected(IntPtr rt) { }

	// RVA: 0x16695D0
	private static void GetColorBuffer_Injected(IntPtr _unity_self, RenderBuffer ret) { }

	// RVA: 0x16696DC
	private static void GetDepthBuffer_Injected(IntPtr _unity_self, RenderBuffer ret) { }

	// RVA: 0x16697F4
	private static void SetMipMapCount_Injected(IntPtr _unity_self, int count) { }

	// RVA: 0x166990C
	private static void SetShadowSamplingMode_Injected(IntPtr _unity_self, ShadowSamplingMode samplingMode) { }

	// RVA: 0x1669B60
	private static void DiscardContents_Injected(IntPtr _unity_self, bool discardColor, bool discardDepth) { }

	// RVA: 0x1669CF8
	private static bool Create_Injected(IntPtr _unity_self) { }

	// RVA: 0x1669DE0
	private static void Release_Injected(IntPtr _unity_self) { }

	// RVA: 0x1669EC8
	private static bool IsCreated_Injected(IntPtr _unity_self) { }

	// RVA: 0x1669FC8
	private static void SetSRGBReadWrite_Injected(IntPtr _unity_self, bool srgb) { }

	// RVA: 0x166A130
	private static void SetRenderTextureDescriptor_Injected(IntPtr _unity_self, RenderTextureDescriptor desc) { }

	// RVA: 0x166A198
	private static void GetDescriptor_Injected(IntPtr _unity_self, RenderTextureDescriptor ret) { }

	// RVA: 0x166A278
	private static IntPtr GetTemporary_Internal_Injected(RenderTextureDescriptor desc) { }

	// RVA: 0x166A378
	private static void ReleaseTemporary_Injected(IntPtr temp) { }

	// RVA: 0x166A460
	private static int get_depth_Injected(IntPtr _unity_self) { }

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

	// RVA: 0x166D060
	public int get_width() { }

	// RVA: 0x166D068
	public void set_width(int value) { }

	// RVA: 0x166D070
	public int get_height() { }

	// RVA: 0x166D078
	public void set_height(int value) { }

	// RVA: 0x166D080
	public int get_msaaSamples() { }

	// RVA: 0x166D088
	public void set_msaaSamples(int value) { }

	// RVA: 0x166D090
	public int get_volumeDepth() { }

	// RVA: 0x166D098
	public void set_volumeDepth(int value) { }

	// RVA: 0x166D0A0
	public void set_mipCount(int value) { }

	// RVA: 0x166C6DC
	public GraphicsFormat get_graphicsFormat() { }

	// RVA: 0x166D0A8
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x166D150
	public void set_stencilFormat(GraphicsFormat value) { }

	// RVA: 0x166D158
	public GraphicsFormat get_depthStencilFormat() { }

	// RVA: 0x166D160
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x166C6E4
	public RenderTextureFormat get_colorFormat() { }

	// RVA: 0x166D168
	public void set_colorFormat(RenderTextureFormat value) { }

	// RVA: 0x166D2EC
	public bool get_sRGB() { }

	// RVA: 0x166D40C
	public void set_sRGB(bool value) { }

	// RVA: 0x166D37C
	public int get_depthBufferBits() { }

	// RVA: 0x166D524
	public void set_depthBufferBits(int value) { }

	// RVA: 0x166D55C
	public TextureDimension get_dimension() { }

	// RVA: 0x166D564
	public void set_dimension(TextureDimension value) { }

	// RVA: 0x166D56C
	public ShadowSamplingMode get_shadowSamplingMode() { }

	// RVA: 0x166D574
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	// RVA: 0x166D57C
	public void set_vrUsage(VRTextureUsage value) { }

	// RVA: 0x166D584
	public void set_memoryless(RenderTextureMemoryless value) { }

	// RVA: 0x166C9EC
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x166D58C
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	// RVA: 0x166D134
	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

	// RVA: 0x166D658
	public void set_useMipMap(bool value) { }

	// RVA: 0x166D66C
	public void set_autoGenerateMips(bool value) { }

	// RVA: 0x166D68C
	public void set_enableRandomWrite(bool value) { }

	// RVA: 0x166D6AC
	public void set_bindMS(bool value) { }

	// RVA: 0x166C818
	internal void set_createdFromScript(bool value) { }

	// RVA: 0x166CB08
	public void set_useDynamicScale(bool value) { }

}

// Namespace: UnityEngine
public struct MipmapLimitDescriptor
{
	// Fields
	private readonly bool <useMipmapLimit>k__BackingField; // 0x10
	private readonly string <groupName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x166D6CC
	public bool get_useMipmapLimit() { }

	// RVA: 0x166D6D4
	public string get_groupName() { }

	// RVA: 0x166D6DC
	public void .ctor(bool useMipmapLimit, string groupName) { }

}

// Namespace: UnityEngine
public class Handheld
{
	// Methods

	// RVA: 0x166D6EC
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

	// RVA: 0x166D72C
	public void .ctor(UInt64 u64_0, UInt64 u64_1) { }

	// RVA: 0x166D734
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x166D7C0
	public override string ToString() { }

	// RVA: 0x166D8B4
	public static Hash128 Parse(string hashString) { }

	// RVA: 0x166D7CC
	private static string Hash128ToStringImpl(Hash128 hash) { }

	// RVA: 0x166DB0C
	public override bool Equals(object obj) { }

	// RVA: 0x166DBB0
	public bool Equals(Hash128 obj) { }

	// RVA: 0x166DBC4
	public override int GetHashCode() { }

	// RVA: 0x166DBFC
	public int CompareTo(object obj) { }

	// RVA: 0x166DBA0
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x166D780
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x166D798
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x166DA3C
	private static void Parse_Injected(ManagedSpanWrapper hashString, Hash128 ret) { }

	// RVA: 0x166DAA4
	private static void Hash128ToStringImpl_Injected(Hash128 hash, ManagedSpanWrapper ret) { }

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

	// RVA: 0x166DCD4
	public static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode) { }

	// RVA: 0x166DDE4
	public static void set_visible(bool value) { }

	// RVA: 0x166DE34
	public static CursorLockMode get_lockState() { }

	// RVA: 0x166DE74
	public static void set_lockState(CursorLockMode value) { }

	// RVA: 0x166DD8C
	private static void SetCursor_Injected(IntPtr texture, Vector2 hotspot, CursorMode cursorMode) { }

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
	public const KeyCode WheelUp = 321;
	public const KeyCode WheelDown = 322;
	public const KeyCode F16 = 670;
	public const KeyCode F17 = 671;
	public const KeyCode F18 = 672;
	public const KeyCode F19 = 673;
	public const KeyCode F20 = 674;
	public const KeyCode F21 = 675;
	public const KeyCode F22 = 676;
	public const KeyCode F23 = 677;
	public const KeyCode F24 = 678;
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

	// RVA: 0x166DEC4
	public void .ctor(ILogHandler logHandler) { }

	// RVA: 0x166DF0C
	public ILogHandler get_logHandler() { }

	// RVA: 0x166DF14
	public void set_logHandler(ILogHandler value) { }

	// RVA: 0x166DF1C
	public bool get_logEnabled() { }

	// RVA: 0x166DF24
	public void set_logEnabled(bool value) { }

	// RVA: 0x166DF2C
	public LogType get_filterLogType() { }

	// RVA: 0x166DF34
	public void set_filterLogType(LogType value) { }

	// RVA: 0x166DF3C
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x166DF70
	private static string GetString(object message) { }

	// RVA: 0x166E0A4
	public void Log(LogType logType, object message) { }

	// RVA: 0x166E224
	public void Log(LogType logType, object message, object context) { }

	// RVA: 0x166E3B4
	public void Log(LogType logType, string tag, object message) { }

	// RVA: 0x166E578
	public void Log(string tag, object message) { }

	// RVA: 0x166E724
	public void LogWarning(string tag, object message) { }

	// RVA: 0x166E8D0
	public void LogError(string tag, object message) { }

	// RVA: 0x166EA7C
	public void LogException(Exception exception) { }

	// RVA: 0x166EB50
	public void LogException(Exception exception, object context) { }

	// RVA: 0x166EC28
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x166ED2C
	public void LogFormat(LogType logType, object context, string format, object[] args) { }

}

// Namespace: UnityEngine
internal class UnityLogWriter
{
	// Methods

	// RVA: 0x166EE34
	public static void WriteStringToUnityLog(string s) { }

	// RVA: 0x166EE40
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x166F004
	public static void Init() { }

	// RVA: 0x166F188
	public override Encoding get_Encoding() { }

	// RVA: 0x166F190
	public override void Write(Char value) { }

	// RVA: 0x166F1EC
	public override void Write(string s) { }

	// RVA: 0x166F1FC
	public override void Write(Char[] buffer, int index, int count) { }

	// RVA: 0x166F100
	public void .ctor() { }

	// RVA: 0x166EFB4
	private static void WriteStringToUnityLogImpl_Injected(ManagedSpanWrapper s) { }

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

	// RVA: 0x166F218
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x166F224
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x166F238
	public override string ToString() { }

	// RVA: 0x166F248
	public string ToString(string format) { }

	// RVA: 0x166F254
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x166F498
	public override int GetHashCode() { }

	// RVA: 0x166F520
	public override bool Equals(object other) { }

	// RVA: 0x166F604
	public bool Equals(Color other) { }

	// RVA: 0x166F694
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x166F6A8
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x166F6BC
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x166F6D0
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x166F6E4
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x166F6F8
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x166F73C
	public static bool op_Inequality(Color lhs, Color rhs) { }

	// RVA: 0x166F780
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x166F7D0
	public static Color LerpUnclamped(Color a, Color b, float t) { }

	// RVA: 0x166F808
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x166F824
	public static Color get_red() { }

	// RVA: 0x166F838
	public static Color get_green() { }

	// RVA: 0x166F84C
	public static Color get_blue() { }

	// RVA: 0x166F860
	public static Color get_white() { }

	// RVA: 0x166F874
	public static Color get_black() { }

	// RVA: 0x166F888
	public static Color get_yellow() { }

	// RVA: 0x166F8AC
	public static Color get_cyan() { }

	// RVA: 0x166F8C0
	public static Color get_magenta() { }

	// RVA: 0x166F8D4
	public static Color get_gray() { }

	// RVA: 0x166F8E8
	public static Color get_clear() { }

	// RVA: 0x166F8FC
	public Color get_linear() { }

	// RVA: 0x166F95C
	public Color get_gamma() { }

	// RVA: 0x166F9BC
	public float get_maxColorComponent() { }

	// RVA: 0x166F9D8
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x166F9DC
	public static Color op_Implicit(Vector4 v) { }

	// RVA: 0x166F9E0
	public static void RGBToHSV(Color rgbColor, float H, float S, float V) { }

	// RVA: 0x166FB24
	private static void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, float H, float S, float V) { }

	// RVA: 0x166FB94
	public static Color HSVToRGB(float H, float S, float V) { }

	// RVA: 0x166FCCC
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

	// RVA: 0x166FE38
	public void .ctor(Byte r, Byte g, Byte b, Byte a) { }

	// RVA: 0x166FE4C
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x1670144
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x1670180
	public override int GetHashCode() { }

	// RVA: 0x1670188
	public override bool Equals(object other) { }

	// RVA: 0x1670218
	public bool Equals(Color32 other) { }

	// RVA: 0x1670228
	public override string ToString() { }

	// RVA: 0x1670458
	public string ToString(string format, IFormatProvider formatProvider) { }

}

// Namespace: UnityEngine
public class ColorUtility
{
	// Methods

	// RVA: 0x1670670
	internal static bool DoTryParseHtmlColor(string htmlString, Color32 color) { }

	// RVA: 0x1670874
	public static bool TryParseHtmlString(string htmlString, Color color) { }

	// RVA: 0x16708F8
	public static string ToHtmlStringRGB(Color color) { }

	// RVA: 0x1670D74
	public static string ToHtmlStringRGBA(Color color) { }

	// RVA: 0x167080C
	private static bool DoTryParseHtmlColor_Injected(ManagedSpanWrapper htmlString, Color32 color) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1671984
	public static IntPtr ConvertToNative(Gradient graident) { }

}

// Namespace: UnityEngine
public class Gradient
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private bool m_RequiresNativeCleanup; // 0x18

	// Methods

	// RVA: 0x1671330
	private static IntPtr Init() { }

	// RVA: 0x1671370
	private void Cleanup() { }

	// RVA: 0x1671430
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x1671520
	public void .ctor() { }

	// RVA: 0x1671570
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x16715A0
	protected override void Finalize() { }

	// RVA: 0x167166C
	public Color Evaluate(float time) { }

	// RVA: 0x167175C
	public override bool Equals(object o) { }

	// RVA: 0x167187C
	public bool Equals(Gradient other) { }

	// RVA: 0x1671978
	public override int GetHashCode() { }

	// RVA: 0x16713E0
	private static void Cleanup_Injected(IntPtr _unity_self) { }

	// RVA: 0x16714B8
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	// RVA: 0x16716FC
	private static void Evaluate_Injected(IntPtr _unity_self, float time, Color ret) { }

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

	// RVA: 0x16719A0
	private Quaternion GetRotation() { }

	// RVA: 0x1671A64
	private Vector3 GetLossyScale() { }

	// RVA: 0x1671B2C
	private float GetDeterminant() { }

	// RVA: 0x1671B7C
	public Quaternion get_rotation() { }

	// RVA: 0x1671BD8
	public Vector3 get_lossyScale() { }

	// RVA: 0x1671C38
	public float get_determinant() { }

	// RVA: 0x1671C88
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x1671D84
	public static bool Inverse3DAffine(Matrix4x4 input, Matrix4x4 result) { }

	// RVA: 0x1671E54
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x1671F34
	public Matrix4x4 get_inverse() { }

	// RVA: 0x1671FB8
	public static Matrix4x4 Transpose(Matrix4x4 m) { }

	// RVA: 0x1672098
	public Matrix4x4 get_transpose() { }

	// RVA: 0x167211C
	public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar) { }

	// RVA: 0x1672254
	public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar) { }

	// RVA: 0x167235C
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x1672378
	public float get_Item(int row, int column) { }

	// RVA: 0x16724EC
	public void set_Item(int row, int column, float value) { }

	// RVA: 0x1672380
	public float get_Item(int index) { }

	// RVA: 0x16724F4
	public void set_Item(int index, float value) { }

	// RVA: 0x1672660
	public override int GetHashCode() { }

	// RVA: 0x1672A9C
	public override bool Equals(object other) { }

	// RVA: 0x1672D28
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x1672DD4
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x1672E78
	public static Vector4 op_Multiply(Matrix4x4 lhs, Vector4 vector) { }

	// RVA: 0x1672810
	public Vector4 GetColumn(int index) { }

	// RVA: 0x1672EAC
	public Vector4 GetRow(int index) { }

	// RVA: 0x1672F88
	public Vector3 GetPosition() { }

	// RVA: 0x1672F94
	public void SetColumn(int index, Vector4 column) { }

	// RVA: 0x1673010
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x1673090
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x16730EC
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x1673138
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x1673164
	public static Matrix4x4 Translate(Vector3 vector) { }

	// RVA: 0x1673198
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x1673230
	public static Matrix4x4 get_identity() { }

	// RVA: 0x1673294
	public override string ToString() { }

	// RVA: 0x1673878
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1673E4C
	private static void .cctor() { }

	// RVA: 0x16719FC
	private static void GetRotation_Injected(Matrix4x4 _unity_self, Quaternion ret) { }

	// RVA: 0x1671AC4
	private static void GetLossyScale_Injected(Matrix4x4 _unity_self, Vector3 ret) { }

	// RVA: 0x1671D1C
	private static void TRS_Injected(Vector3 pos, Quaternion q, Vector3 s, Matrix4x4 ret) { }

	// RVA: 0x1671DEC
	private static bool Inverse3DAffine_Injected(Matrix4x4 input, Matrix4x4 result) { }

	// RVA: 0x1671ECC
	private static void Inverse_Injected(Matrix4x4 m, Matrix4x4 ret) { }

	// RVA: 0x1672030
	private static void Transpose_Injected(Matrix4x4 m, Matrix4x4 ret) { }

	// RVA: 0x16721CC
	private static void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, Matrix4x4 ret) { }

	// RVA: 0x16722EC
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

	// RVA: 0x1673EC8
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x1673FB0
	private static void OrthoNormalize2(Vector3 a, Vector3 b) { }

	// RVA: 0x1674018
	public static void OrthoNormalize(Vector3 normal, Vector3 tangent) { }

	// RVA: 0x1674080
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x16740C0
	public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x16740E8
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	// RVA: 0x1674208
	public float get_Item(int index) { }

	// RVA: 0x1674294
	public void set_Item(int index, float value) { }

	// RVA: 0x1674320
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x167432C
	public void .ctor(float x, float y) { }

	// RVA: 0x1674338
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x1674344
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x1674354
	public void Scale(Vector3 scale) { }

	// RVA: 0x1674374
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x16743A4
	public override int GetHashCode() { }

	// RVA: 0x16743F8
	public override bool Equals(object other) { }

	// RVA: 0x16744A8
	public bool Equals(Vector3 other) { }

	// RVA: 0x16744D8
	public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal) { }

	// RVA: 0x1674510
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x1674618
	public void Normalize() { }

	// RVA: 0x1674720
	public Vector3 get_normalized() { }

	// RVA: 0x1674824
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x167483C
	public static Vector3 Project(Vector3 vector, Vector3 onNormal) { }

	// RVA: 0x1674950
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x1674A2C
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x1674B58
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x1674BFC
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x1674CBC
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x1674D40
	public float get_magnitude() { }

	// RVA: 0x1674DCC
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x1674DE4
	public float get_sqrMagnitude() { }

	// RVA: 0x1674E04
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1674E20
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1674E3C
	public static Vector3 get_zero() { }

	// RVA: 0x1674E8C
	public static Vector3 get_one() { }

	// RVA: 0x1674EDC
	public static Vector3 get_forward() { }

	// RVA: 0x1674F2C
	public static Vector3 get_back() { }

	// RVA: 0x1674F7C
	public static Vector3 get_up() { }

	// RVA: 0x1674FCC
	public static Vector3 get_down() { }

	// RVA: 0x167501C
	public static Vector3 get_left() { }

	// RVA: 0x167506C
	public static Vector3 get_right() { }

	// RVA: 0x16750BC
	public static Vector3 get_positiveInfinity() { }

	// RVA: 0x167510C
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x167511C
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x167512C
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x167513C
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x167514C
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x1675160
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x1675170
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x16751A8
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x16751E0
	public override string ToString() { }

	// RVA: 0x16751F0
	public string ToString(string format) { }

	// RVA: 0x16751FC
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x16753F4
	private static void .cctor() { }

	// RVA: 0x1673F48
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

	// RVA: 0x1675484
	public static Quaternion Inverse(Quaternion rotation) { }

	// RVA: 0x167554C
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x1675630
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x1675714
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	// RVA: 0x16757F8
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	// RVA: 0x16758C0
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	// RVA: 0x167598C
	private static void Internal_ToAxisAngleRad(Quaternion q, Vector3 axis, float angle) { }

	// RVA: 0x1675A4C
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	// RVA: 0x1675B1C
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	// RVA: 0x1675BE0
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x1675CA0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x1675CAC
	public static Quaternion get_identity() { }

	// RVA: 0x1675CFC
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x1675D7C
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x1675E20
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x1675E38
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x1675E6C
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x1675EA0
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x1675EC0
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x1675F2C
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x1675FEC
	public Vector3 get_eulerAngles() { }

	// RVA: 0x1676124
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x16761A0
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x1676218
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x1676290
	public void ToAngleAxis(float angle, Vector3 axis) { }

	// RVA: 0x1676310
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x1676444
	public static Quaternion Normalize(Quaternion q) { }

	// RVA: 0x1676534
	public Quaternion get_normalized() { }

	// RVA: 0x167661C
	public override int GetHashCode() { }

	// RVA: 0x1676684
	public override bool Equals(object other) { }

	// RVA: 0x1676768
	public bool Equals(Quaternion other) { }

	// RVA: 0x16767F8
	public override string ToString() { }

	// RVA: 0x1676808
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1676A4C
	private static void .cctor() { }

	// RVA: 0x16754E4
	private static void Inverse_Injected(Quaternion rotation, Quaternion ret) { }

	// RVA: 0x16755C8
	private static void Slerp_Injected(Quaternion a, Quaternion b, float t, Quaternion ret) { }

	// RVA: 0x16756AC
	private static void SlerpUnclamped_Injected(Quaternion a, Quaternion b, float t, Quaternion ret) { }

	// RVA: 0x1675790
	private static void Lerp_Injected(Quaternion a, Quaternion b, float t, Quaternion ret) { }

	// RVA: 0x1675858
	private static void Internal_FromEulerRad_Injected(Vector3 euler, Quaternion ret) { }

	// RVA: 0x1675924
	private static void Internal_ToEulerRad_Injected(Quaternion rotation, Vector3 ret) { }

	// RVA: 0x16759F4
	private static void Internal_ToAxisAngleRad_Injected(Quaternion q, Vector3 axis, float angle) { }

	// RVA: 0x1675ABC
	private static void AngleAxis_Injected(float angle, Vector3 axis, Quaternion ret) { }

	// RVA: 0x1675B88
	private static void LookRotation_Injected(Vector3 forward, Vector3 upwards, Quaternion ret) { }

}

// Namespace: UnityEngine
public struct Mathf
{
	// Fields
	public static readonly float Epsilon; // 0x0

	// Methods

	// RVA: 0x1676AA0
	public static float GammaToLinearSpace(float value) { }

	// RVA: 0x1676AF8
	public static float LinearToGammaSpace(float value) { }

	// RVA: 0x1676B50
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	// RVA: 0x1676C1C
	public static float Sin(float f) { }

	// RVA: 0x1676C84
	public static float Cos(float f) { }

	// RVA: 0x1676CEC
	public static float Tan(float f) { }

	// RVA: 0x1676D54
	public static float Asin(float f) { }

	// RVA: 0x1676DBC
	public static float Acos(float f) { }

	// RVA: 0x1676E24
	public static float Atan(float f) { }

	// RVA: 0x1676E8C
	public static float Atan2(float y, float x) { }

	// RVA: 0x1676EFC
	public static float Sqrt(float f) { }

	// RVA: 0x1676F7C
	public static float Abs(float f) { }

	// RVA: 0x1676FFC
	public static int Abs(int value) { }

	// RVA: 0x1677084
	public static float Min(float a, float b) { }

	// RVA: 0x1677090
	public static int Min(int a, int b) { }

	// RVA: 0x167709C
	public static float Max(float a, float b) { }

	// RVA: 0x16770A8
	public static float Max(float[] values) { }

	// RVA: 0x1677100
	public static int Max(int a, int b) { }

	// RVA: 0x167710C
	public static float Pow(float f, float p) { }

	// RVA: 0x1677180
	public static float Exp(float power) { }

	// RVA: 0x16771E8
	public static float Log(float f, float p) { }

	// RVA: 0x167725C
	public static float Log(float f) { }

	// RVA: 0x16772C4
	public static float Log10(float f) { }

	// RVA: 0x167732C
	public static float Ceil(float f) { }

	// RVA: 0x16773AC
	public static float Floor(float f) { }

	// RVA: 0x167742C
	public static float Round(float f) { }

	// RVA: 0x1677550
	public static int CeilToInt(float f) { }

	// RVA: 0x16775C8
	public static int FloorToInt(float f) { }

	// RVA: 0x1677640
	public static int RoundToInt(float f) { }

	// RVA: 0x1677750
	public static float Sign(float f) { }

	// RVA: 0x1677764
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x1677778
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x167778C
	public static float Clamp01(float value) { }

	// RVA: 0x16777A8
	public static float Lerp(float a, float b, float t) { }

	// RVA: 0x16777D0
	public static float LerpUnclamped(float a, float b, float t) { }

	// RVA: 0x16777E0
	public static float LerpAngle(float a, float b, float t) { }

	// RVA: 0x167784C
	public static float MoveTowards(float current, float target, float maxDelta) { }

	// RVA: 0x1677870
	public static float SmoothStep(float from, float to, float t) { }

	// RVA: 0x16778B8
	public static bool Approximately(float a, float b) { }

	// RVA: 0x1677950
	public static float SmoothDamp(float current, float target, float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x1677A34
	public static float Repeat(float t, float length) { }

	// RVA: 0x1677A5C
	public static float InverseLerp(float a, float b, float value) { }

	// RVA: 0x1677A94
	public static float DeltaAngle(float current, float target) { }

	// RVA: 0x1677AE4
	internal static float ClampToFloat(Double value) { }

	// RVA: 0x1677B64
	internal static int ClampToInt(Int64 value) { }

	// RVA: 0x1677B80
	internal static UInt32 ClampToUInt(Int64 value) { }

	// RVA: 0x1677B98
	internal static int GetNumberOfDecimalsForMinimumDifference(Double minDifference) { }

	// RVA: 0x1677C28
	internal static Double RoundBasedOnMinimumDifference(Double valueToRound, Double minDifference) { }

	// RVA: 0x1677D18
	internal static Double DiscardLeastSignificantDecimal(Double v) { }

	// RVA: 0x1677EA4
	public static int NextPowerOfTwo(int value) { }

	// RVA: 0x1677EC4
	public static int ClosestPowerOfTwo(int value) { }

	// RVA: 0x1677EF8
	public static bool IsPowerOfTwo(int value) { }

	// RVA: 0x1677F08
	private static void .cctor() { }

	// RVA: 0x1676BB4
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

	// RVA: 0x1677FE8
	public float get_Item(int index) { }

	// RVA: 0x167805C
	public void set_Item(int index, float value) { }

	// RVA: 0x16780D0
	public void .ctor(float x, float y) { }

	// RVA: 0x16780D8
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x167810C
	public static Vector2 LerpUnclamped(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x1678128
	public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) { }

	// RVA: 0x16781FC
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x1678208
	public void Normalize() { }

	// RVA: 0x1678300
	public Vector2 get_normalized() { }

	// RVA: 0x16783E4
	public override string ToString() { }

	// RVA: 0x16783F4
	public string ToString(string format) { }

	// RVA: 0x1678400
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x16785AC
	public override int GetHashCode() { }

	// RVA: 0x16785E4
	public override bool Equals(object other) { }

	// RVA: 0x1678684
	public bool Equals(Vector2 other) { }

	// RVA: 0x16786A8
	public static Vector2 Perpendicular(Vector2 inDirection) { }

	// RVA: 0x16786B8
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x16786C8
	public float get_magnitude() { }

	// RVA: 0x1678740
	public float get_sqrMagnitude() { }

	// RVA: 0x1678754
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x1678858
	public static float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x1678974
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x16789FC
	public static Vector2 ClampMagnitude(Vector2 vector, float maxLength) { }

	// RVA: 0x1678A9C
	public static Vector2 Min(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1678AB0
	public static Vector2 Max(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1678AC4
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x1678AD0
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x1678ADC
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x1678AE8
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x1678AF4
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x1678B00
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x1678B0C
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x1678B1C
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x1678B28
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1678B54
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1678B80
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x1678B84
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x1678B8C
	public static Vector2 get_zero() { }

	// RVA: 0x1678BD8
	public static Vector2 get_one() { }

	// RVA: 0x1678C24
	public static Vector2 get_up() { }

	// RVA: 0x1678C70
	public static Vector2 get_down() { }

	// RVA: 0x1678CBC
	public static Vector2 get_left() { }

	// RVA: 0x1678D08
	public static Vector2 get_right() { }

	// RVA: 0x1678D54
	public static Vector2 get_negativeInfinity() { }

	// RVA: 0x1678DA0
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

	// RVA: 0x1678E10
	public int get_x() { }

	// RVA: 0x1678E18
	public void set_x(int value) { }

	// RVA: 0x1678E20
	public int get_y() { }

	// RVA: 0x1678E28
	public void set_y(int value) { }

	// RVA: 0x1678E30
	public void .ctor(int x, int y) { }

	// RVA: 0x1678E38
	public float get_magnitude() { }

	// RVA: 0x1678E50
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x1678E60
	public static Vector2Int FloorToInt(Vector2 v) { }

	// RVA: 0x1678F4C
	public static Vector2Int op_Subtraction(Vector2Int a, Vector2Int b) { }

	// RVA: 0x1678F64
	public static bool op_Equality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x1678F70
	public static bool op_Inequality(Vector2Int lhs, Vector2Int rhs) { }

	// RVA: 0x1678F7C
	public override bool Equals(object other) { }

	// RVA: 0x167901C
	public bool Equals(Vector2Int other) { }

	// RVA: 0x1679044
	public override int GetHashCode() { }

	// RVA: 0x1679068
	public override string ToString() { }

	// RVA: 0x167921C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x16793B8
	public static Vector2Int get_zero() { }

	// RVA: 0x1679404
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

	// RVA: 0x1679490
	public int get_x() { }

	// RVA: 0x1679498
	public void set_x(int value) { }

	// RVA: 0x16794A0
	public int get_y() { }

	// RVA: 0x16794A8
	public void set_y(int value) { }

	// RVA: 0x16794B0
	public int get_z() { }

	// RVA: 0x16794B8
	public void set_z(int value) { }

	// RVA: 0x16794C0
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x16794CC
	public static Vector3 op_Implicit(Vector3Int v) { }

	// RVA: 0x16794E0
	public static Vector3Int op_Subtraction(Vector3Int a, Vector3Int b) { }

	// RVA: 0x16794FC
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x167951C
	public override bool Equals(object other) { }

	// RVA: 0x16795C8
	public bool Equals(Vector3Int other) { }

	// RVA: 0x16795F8
	public override int GetHashCode() { }

	// RVA: 0x167967C
	public override string ToString() { }

	// RVA: 0x167968C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x167987C
	public static Vector3Int get_zero() { }

	// RVA: 0x16798CC
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

	// RVA: 0x167994C
	public float get_Item(int index) { }

	// RVA: 0x16799F8
	public void set_Item(int index, float value) { }

	// RVA: 0x1679AA4
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x1679AB0
	public void .ctor(float x, float y) { }

	// RVA: 0x1679ABC
	public static Vector4 Lerp(Vector4 a, Vector4 b, float t) { }

	// RVA: 0x1679B0C
	public override int GetHashCode() { }

	// RVA: 0x1679B74
	public override bool Equals(object other) { }

	// RVA: 0x1679C34
	public bool Equals(Vector4 other) { }

	// RVA: 0x1679C70
	public void Normalize() { }

	// RVA: 0x1679D84
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x1679DA4
	public static float Magnitude(Vector4 a) { }

	// RVA: 0x1679E34
	public float get_sqrMagnitude() { }

	// RVA: 0x1679E5C
	public static Vector4 get_zero() { }

	// RVA: 0x1679EAC
	public static Vector4 get_one() { }

	// RVA: 0x1679EFC
	public static Vector4 op_Addition(Vector4 a, Vector4 b) { }

	// RVA: 0x1679F10
	public static Vector4 op_Subtraction(Vector4 a, Vector4 b) { }

	// RVA: 0x1679F24
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x1679F38
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x1679F4C
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x1679F90
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x1679FD4
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x1679FDC
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x1679FE0
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x1679FEC
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x1679FF0
	public override string ToString() { }

	// RVA: 0x167A000
	public string ToString(string format) { }

	// RVA: 0x167A00C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x167A250
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

	// RVA: 0x167A2B4
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

	// RVA: 0x167A328
	public void Dispose() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.ObjectDispatcher.<>c <>9; // 0x0

	// Methods

	// RVA: 0x167A544
	private static void .cctor() { }

	// RVA: 0x167A5B0
	public void .ctor() { }

	// RVA: 0x167A5B8
	internal void <.cctor>b__64_0(object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, System.Action<UnityEngine.TypeDispatchData> callback) { }

	// RVA: 0x167A6B8
	internal void <.cctor>b__64_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, System.Action<UnityEngine.TransformDispatchData> callback) { }

}

// Namespace: UnityEngine
internal sealed class ObjectDispatcher
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private static System.Action<UnityEngine.Object[],System.IntPtr,System.IntPtr,System.Int32,System.Int32,System.Action<UnityEngine.TypeDispatchData>> s_TypeDispatch; // 0x0
	private static System.Action<System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.IntPtr,System.Int32,System.Action<UnityEngine.TransformDispatchData>> s_TransformDispatch; // 0x8

	// Methods

	// RVA: 0x167A3FC
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal class NumericFieldDraggerUtility
{
	// Fields
	private static bool s_UseYSign; // 0x0

	// Methods

	// RVA: 0x167A864
	public static float Acceleration(bool shiftPressed, bool altPressed) { }

	// RVA: 0x167A888
	public static float NiceDelta(Vector2 deviceDelta, float acceleration) { }

	// RVA: 0x167AA38
	public static Double CalculateFloatDragSensitivity(Double value) { }

	// RVA: 0x167AAF8
	public static Double CalculateFloatDragSensitivity(Double value, Double minValue, Double maxValue) { }

	// RVA: 0x167ABBC
	public static Int64 CalculateIntDragSensitivity(Int64 value) { }

	// RVA: 0x167ACDC
	public static UInt64 CalculateIntDragSensitivity(UInt64 value) { }

	// RVA: 0x167AC5C
	public static Double CalculateIntDragSensitivity(Double value) { }

	// RVA: 0x167AD70
	public static Int64 CalculateIntDragSensitivity(Int64 value, Int64 minValue, Int64 maxValue) { }

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

	// RVA: 0x167AE18
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x167B11C
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x167B438
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x167B4B8
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x167B68C
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x167B860
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x167B8E0
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x167B960
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	// RVA: 0x167B920
	private static bool IsConnected() { }

	// RVA: 0x167B8A0
	private static void Initialize() { }

	// RVA: 0x167B518
	private static void RegisterInternal(string messageId) { }

	// RVA: 0x167B6EC
	private static void UnregisterInternal(string messageId) { }

	// RVA: 0x167AF1C
	private static void SendMessage(string messageId, Byte[] data, int playerId) { }

	// RVA: 0x167B220
	private static bool TrySendMessage(string messageId, Byte[] data, int playerId) { }

	// RVA: 0x167B478
	private static void PollInternal() { }

	// RVA: 0x167B9A0
	private static void DisconnectAll() { }

	// RVA: 0x167BB30
	public void .ctor() { }

	// RVA: 0x167B9E0
	private static void RegisterInternal_Injected(ManagedSpanWrapper messageId) { }

	// RVA: 0x167BA30
	private static void UnregisterInternal_Injected(ManagedSpanWrapper messageId) { }

	// RVA: 0x167BA80
	private static void SendMessage_Injected(ManagedSpanWrapper messageId, ManagedSpanWrapper data, int playerId) { }

	// RVA: 0x167BAD8
	private static bool TrySendMessage_Injected(ManagedSpanWrapper messageId, ManagedSpanWrapper data, int playerId) { }

}

// Namespace: UnityEngine
public class PlayerPrefsException
{
	// Methods

	// RVA: 0x167BB38
	public void .ctor(string error) { }

}

// Namespace: UnityEngine
public class PlayerPrefs
{
	// Methods

	// RVA: 0x167BBA4
	private static bool TrySetInt(string key, int value) { }

	// RVA: 0x167BDA8
	private static bool TrySetFloat(string key, float value) { }

	// RVA: 0x167BFAC
	private static bool TrySetSetString(string key, string value) { }

	// RVA: 0x167C278
	public static void SetInt(string key, int value) { }

	// RVA: 0x167C2DC
	public static int GetInt(string key, int defaultValue) { }

	// RVA: 0x167C4E0
	public static int GetInt(string key) { }

	// RVA: 0x167C4E8
	public static void SetFloat(string key, float value) { }

	// RVA: 0x167C54C
	public static float GetFloat(string key, float defaultValue) { }

	// RVA: 0x167C73C
	public static void SetString(string key, string value) { }

	// RVA: 0x167C7A0
	public static string GetString(string key, string defaultValue) { }

	// RVA: 0x167CAC0
	public static string GetString(string key) { }

	// RVA: 0x167CB14
	public static bool HasKey(string key) { }

	// RVA: 0x167CCEC
	public static void DeleteKey(string key) { }

	// RVA: 0x167CEB0
	public static void DeleteAll() { }

	// RVA: 0x167CEF0
	public static void Save() { }

	// RVA: 0x167BD40
	private static bool TrySetInt_Injected(ManagedSpanWrapper key, int value) { }

	// RVA: 0x167BF44
	private static bool TrySetFloat_Injected(ManagedSpanWrapper key, float value) { }

	// RVA: 0x167C210
	private static bool TrySetSetString_Injected(ManagedSpanWrapper key, ManagedSpanWrapper value) { }

	// RVA: 0x167C478
	private static int GetInt_Injected(ManagedSpanWrapper key, int defaultValue) { }

	// RVA: 0x167C6D4
	private static float GetFloat_Injected(ManagedSpanWrapper key, float defaultValue) { }

	// RVA: 0x167CA68
	private static void GetString_Injected(ManagedSpanWrapper key, ManagedSpanWrapper defaultValue, ManagedSpanWrapper ret) { }

	// RVA: 0x167CC9C
	private static bool HasKey_Injected(ManagedSpanWrapper key) { }

	// RVA: 0x167CE60
	private static void DeleteKey_Injected(ManagedSpanWrapper key) { }

}

// Namespace: UnityEngine
public abstract class PropertyAttribute
{
	// Fields
	private int <order>k__BackingField; // 0x10
	private readonly bool <applyToCollection>k__BackingField; // 0x14

	// Methods

	// RVA: 0x167CF30
	public void set_order(int value) { }

	// RVA: 0x167CF38
	protected void .ctor() { }

	// RVA: 0x167CF60
	protected void .ctor(bool applyToCollection) { }

}

// Namespace: UnityEngine
public class InspectorNameAttribute
{
	// Fields
	public readonly string displayName; // 0x18

	// Methods

	// RVA: 0x167CF8C
	public void .ctor(string displayName) { }

}

// Namespace: UnityEngine
public class TooltipAttribute
{
	// Fields
	public readonly string tooltip; // 0x18

	// Methods

	// RVA: 0x167CFC8
	public void .ctor(string tooltip) { }

}

// Namespace: UnityEngine
public class SpaceAttribute
{
	// Fields
	public readonly float height; // 0x18

	// Methods

	// RVA: 0x167D000
	public void .ctor() { }

	// RVA: 0x167D034
	public void .ctor(float height) { }

}

// Namespace: UnityEngine
public class HeaderAttribute
{
	// Fields
	public readonly string header; // 0x18

	// Methods

	// RVA: 0x167D070
	public void .ctor(string header) { }

}

// Namespace: UnityEngine
public sealed class RangeAttribute
{
	// Fields
	public readonly float min; // 0x18
	public readonly float max; // 0x1C

	// Methods

	// RVA: 0x167D0AC
	public void .ctor(float min, float max) { }

}

// Namespace: UnityEngine
public sealed class MinAttribute
{
	// Fields
	public readonly float min; // 0x18

	// Methods

	// RVA: 0x167D0E8
	public void .ctor(float min) { }

}

// Namespace: UnityEngine
public sealed class MultilineAttribute
{
	// Fields
	public readonly int lines; // 0x18

	// Methods

	// RVA: 0x167D120
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class TextAreaAttribute
{
	// Fields
	public readonly int minLines; // 0x18
	public readonly int maxLines; // 0x1C

	// Methods

	// RVA: 0x167D150
	public void .ctor(int minLines, int maxLines) { }

}

// Namespace: UnityEngine
public sealed class ColorUsageAttribute
{
	// Fields
	public readonly bool showAlpha; // 0x15
	public readonly bool hdr; // 0x16
	public readonly float minBrightness; // 0x18
	public readonly float maxBrightness; // 0x1C
	public readonly float minExposureValue; // 0x20
	public readonly float maxExposureValue; // 0x24

	// Methods

	// RVA: 0x167D18C
	public void .ctor(bool showAlpha, bool hdr) { }

}

// Namespace: UnityEngine
public sealed class GradientUsageAttribute
{
	// Fields
	public readonly bool hdr; // 0x15
	public readonly ColorSpace colorSpace; // 0x18

	// Methods

	// RVA: 0x167D1E0
	public void .ctor(bool hdr) { }

}

// Namespace: UnityEngine
internal class PropertyNameUtils
{
	// Methods

	// RVA: 0x167D21C
	public static PropertyName PropertyNameFromString(string name) { }

	// RVA: 0x167D3A4
	private static void PropertyNameFromString_Injected(ManagedSpanWrapper name, PropertyName ret) { }

}

// Namespace: UnityEngine
public struct PropertyName
{
	// Fields
	internal int id; // 0x10

	// Methods

	// RVA: 0x167D40C
	public void .ctor(string name) { }

	// RVA: 0x167D434
	public void .ctor(PropertyName other) { }

	// RVA: 0x167D43C
	public static bool IsNullOrEmpty(PropertyName prop) { }

	// RVA: 0x167D448
	public static bool op_Equality(PropertyName lhs, PropertyName rhs) { }

	// RVA: 0x167D454
	public override int GetHashCode() { }

	// RVA: 0x167D45C
	public override bool Equals(object other) { }

	// RVA: 0x167D4EC
	public bool Equals(PropertyName other) { }

	// RVA: 0x167D4FC
	public static PropertyName op_Implicit(string name) { }

	// RVA: 0x167D500
	public override string ToString() { }

}

// Namespace: UnityEngine
public static class Random
{
	// Methods

	// RVA: 0x167D580
	public static float Range(float minInclusive, float maxInclusive) { }

	// RVA: 0x167D5E4
	public static int Range(int minInclusive, int maxExclusive) { }

	// RVA: 0x167D64C
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	// RVA: 0x167D6B4
	public static float get_value() { }

	// RVA: 0x167D6F4
	public static Vector3 get_insideUnitSphere() { }

	// RVA: 0x167D79C
	public static Vector3 get_onUnitSphere() { }

	// RVA: 0x167D74C
	private static void get_insideUnitSphere_Injected(Vector3 ret) { }

	// RVA: 0x167D7F4
	private static void get_onUnitSphere_Injected(Vector3 ret) { }

}

// Namespace: UnityEngine
public class ResourceRequest
{
	// Fields
	internal string m_Path; // 0x20
	internal Type m_Type; // 0x28

	// Methods

	// RVA: 0x167D844
	protected virtual object GetResult() { }

	// RVA: 0x167D960
	protected void .ctor(IntPtr ptr) { }

}

// Namespace: UnityEngine
internal static class ResourcesAPIInternal
{
	// Methods

	// RVA: 0x167DA28
	public static object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x167DA78
	public static Shader FindShaderByName(string name) { }

	// RVA: 0x167DCD4
	public static object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x167DF90
	public static void UnloadAsset(object assetToUnload) { }

	// RVA: 0x167DC84
	private static IntPtr FindShaderByName_Injected(ManagedSpanWrapper name) { }

	// RVA: 0x167DF28
	private static IntPtr Load_Injected(ManagedSpanWrapper path, Type systemTypeInstance) { }

	// RVA: 0x167E040
	private static void UnloadAsset_Injected(IntPtr assetToUnload) { }

}

// Namespace: UnityEngine
public class ResourcesAPI
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Methods

	// RVA: 0x167E090
	internal static ResourcesAPI get_ActiveAPI() { }

	// RVA: 0x167E190
	public static ResourcesAPI get_overrideAPI() { }

	// RVA: 0x167E20C
	protected internal void .ctor() { }

	// RVA: 0x167E214
	protected internal virtual object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x167E264
	protected internal virtual Shader FindShaderByName(string name) { }

	// RVA: 0x167E26C
	protected internal virtual object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x167E278
	protected internal virtual void UnloadAsset(object assetToUnload) { }

	// RVA: 0x167E328
	private static void .cctor() { }

}

// Namespace: UnityEngine
public sealed class Resources
{
	// Methods

	// RVA: 0x35293EC
	internal static T[] ConvertObjects(object[] rawObjects) { }

	// RVA: 0x167E394
	public static object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x35293B4
	public static T[] FindObjectsOfTypeAll() { }

	// RVA: 0x167E41C
	public static object Load(string path) { }

	// RVA: 0x26AD93C
	public static T Load(string path) { }

	// RVA: 0x167D8D0
	public static object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x167E4FC
	public static object GetBuiltinResource(Type type, string path) { }

	// RVA: 0x26AD93C
	public static T GetBuiltinResource(string path) { }

	// RVA: 0x167E7B8
	public static void UnloadAsset(object assetToUnload) { }

	// RVA: 0x167E840
	public static AsyncOperation UnloadUnusedAssets() { }

	// RVA: 0x167E750
	private static IntPtr GetBuiltinResource_Injected(Type type, ManagedSpanWrapper path) { }

	// RVA: 0x167E918
	private static IntPtr UnloadUnusedAssets_Injected() { }

}

// Namespace: UnityEngine
public class AsyncInstantiateOperation
{
	// Fields
	internal static CancellationTokenSource s_GlobalCancellation; // 0x0
	internal object[] m_Result; // 0x20
	private CancellationToken m_CancellationToken; // 0x28

	// Methods

	// RVA: 0x167E9F0
	private bool IsCancellationRequested() { }

	// RVA: 0x167EA78
	internal virtual object[] CreateResultArray(int size) { }

	// RVA: 0x167EAE8
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal class AsyncInstantiateOperationHelper
{
	// Methods

	// RVA: 0x167EB70
	public static object[] CreateAsyncInstantiateOperationResultArray(AsyncInstantiateOperation op, int size) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x167E958
	public static AsyncOperation ConvertToManaged(IntPtr ptr) { }

	// RVA: 0x167EEDC
	public static IntPtr ConvertToNative(AsyncOperation asyncOperation) { }

}

// Namespace: UnityEngine
public class AsyncOperation
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private System.Action<UnityEngine.AsyncOperation> m_completeCallback; // 0x18

	// Methods

	// RVA: 0x167EB90
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x167EBE0
	private static void InternalSetManagedObject(IntPtr ptr, AsyncOperation self) { }

	// RVA: 0x167D9C4
	protected void .ctor(IntPtr ptr) { }

	// RVA: 0x167EC50
	public bool get_isDone() { }

	// RVA: 0x167ED10
	public float get_progress() { }

	// RVA: 0x167EDD0
	protected override void Finalize() { }

	// RVA: 0x167EE88
	internal void InvokeCompletionEvent() { }

	// RVA: 0x167ECC0
	private static bool get_isDone_Injected(IntPtr _unity_self) { }

	// RVA: 0x167ED80
	private static float get_progress_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
internal class AttributeHelperEngine
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	// RVA: 0x167EEF8
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	// RVA: 0x167F030
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x167F4E4
	private static int GetExecuteMode(Type klass) { }

	// RVA: 0x167F628
	private static int CheckIsEditorScript(Type klass) { }

	// RVA: 0x167F77C
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: 0x26AD93C
	private static T GetCustomAttributeOfType(Type klass) { }

	// RVA: 0x167F830
	private static void .cctor() { }

}

// Namespace: UnityEngine
public sealed class DisallowMultipleComponent
{
	// Methods

	// RVA: 0x167F920
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

	// RVA: 0x167F928
	public void .ctor(Type requiredComponent) { }

	// RVA: 0x167F95C
	public void .ctor(Type requiredComponent, Type requiredComponent2) { }

}

// Namespace: UnityEngine
public sealed class AddComponentMenu
{
	// Fields
	private string m_AddComponentMenu; // 0x10
	private int m_Ordering; // 0x18

	// Methods

	// RVA: 0x167F9AC
	public void .ctor(string menuName) { }

	// RVA: 0x167F9E8
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

	// RVA: 0x167FA30
	public void set_menuName(string value) { }

	// RVA: 0x167FA38
	public void set_fileName(string value) { }

	// RVA: 0x167FA40
	public void set_order(int value) { }

	// RVA: 0x167FA48
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

	// RVA: 0x167FA50
	public void .ctor(string itemName) { }

	// RVA: 0x167FA98
	public void .ctor(string itemName, bool isValidateFunction) { }

	// RVA: 0x167FAEC
	public void .ctor(string itemName, bool isValidateFunction, int priority) { }

}

// Namespace: UnityEngine
public sealed class ExecuteInEditMode
{
	// Methods

	// RVA: 0x167FB3C
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class ExecuteAlways
{
	// Methods

	// RVA: 0x167FB44
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class HideInInspector
{
	// Methods

	// RVA: 0x167FB4C
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class HideInCallstackAttribute
{}

// Namespace: UnityEngine
public class HelpURLAttribute
{
	// Fields
	internal readonly string m_Url; // 0x10
	internal readonly bool m_Dispatcher; // 0x18
	internal readonly string m_DispatchingFieldName; // 0x20

	// Methods

	// RVA: 0x167FB54
	public void .ctor(string url) { }

}

// Namespace: UnityEngine
public class DefaultExecutionOrder
{
	// Fields
	private int m_Order; // 0x10

	// Methods

	// RVA: 0x167FBD4
	public void .ctor(int order) { }

	// RVA: 0x167F828
	public int get_order() { }

}

// Namespace: UnityEngine
public class AssemblyIsEditorAssembly
{}

// Namespace: UnityEngine
public class ExcludeFromPresetAttribute
{
	// Methods

	// RVA: 0x167FC00
	public void .ctor() { }

}

// Namespace: 
internal enum AwaiterCompletionThreadAffinity
{
	// Fields
	public int value__; // 0x10
	public const AwaiterCompletionThreadAffinity None = 0;
	public const AwaiterCompletionThreadAffinity MainThread = 1;
	public const AwaiterCompletionThreadAffinity BackgroundThread = 2;
}

// Namespace: 
private interface IStateMachineBox
{}

// Namespace: 
public struct AwaitableAsyncMethodBuilder
{
	// Fields
	private IStateMachineBox _stateMachineBox; // 0x10
	private Awaitable _resultingCoroutine; // 0x18
}

// Namespace: 
private struct AwaitableHandle
{
	// Fields
	private readonly IntPtr _handle; // 0x10
	public static AwaitableHandle ManagedHandle; // 0x0
	public static AwaitableHandle NullHandle; // 0x8

	// Methods

	// RVA: 0x1680A50
	public bool get_IsNull() { }

	// RVA: 0x16809DC
	public bool get_IsManaged() { }

	// RVA: 0x1681BBC
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1681BC4
	public static IntPtr op_Implicit(AwaitableHandle handle) { }

	// RVA: 0x1681BC8
	private static void .cctor() { }

}

// Namespace: 
private struct AwaitableAndFrameIndex
{
	// Fields
	private readonly Awaitable <Awaitable>k__BackingField; // 0x10
	private readonly int <FrameIndex>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1681C34
	public Awaitable get_Awaitable() { }

	// RVA: 0x1681C3C
	public int get_FrameIndex() { }

}

// Namespace: 
private class DoubleBufferedAwaitableList
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.Awaitable.AwaitableAndFrameIndex> _awaitables; // 0x10
	private System.Collections.Generic.List<UnityEngine.Awaitable.AwaitableAndFrameIndex> _scratch; // 0x18

	// Methods

	// RVA: 0x16814DC
	public void SwapAndComplete() { }

	// RVA: 0x16813C0
	public void Clear() { }

	// RVA: 0x1681B0C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Awaitable.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Awaitable> <>9__76_1; // 0x8

	// Methods

	// RVA: 0x1681E04
	private static void .cctor() { }

	// RVA: 0x1681E70
	public void .ctor() { }

	// RVA: 0x1681E78
	internal UnityEngine.Pool.ObjectPool<UnityEngine.Awaitable> <.cctor>b__76_0() { }

	// RVA: 0x1681FC0
	internal Awaitable <.cctor>b__76_1() { }

}

// Namespace: UnityEngine
public class Awaitable
{
	// Fields
	private SpinLock _spinLock; // 0x10
	private static readonly System.Threading.ThreadLocal<UnityEngine.Pool.ObjectPool<UnityEngine.Awaitable>> _pool; // 0x0
	private AwaitableHandle _handle; // 0x18
	private ExceptionDispatchInfo _exceptionToRethrow; // 0x20
	private bool _managedAwaitableDone; // 0x28
	private AwaiterCompletionThreadAffinity _completionThreadAffinity; // 0x2C
	private Action _continuation; // 0x30
	private System.Nullable<System.Threading.CancellationTokenRegistration> _cancelTokenRegistration; // 0x38
	private DoubleBufferedAwaitableList _managedCompletionQueue; // 0x58
	private static bool _nextFrameAndEndOfFrameWiredUp; // 0x8
	private static CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration; // 0x10
	private static readonly DoubleBufferedAwaitableList _nextFrameAwaitables; // 0x28
	private static readonly DoubleBufferedAwaitableList _endOfFrameAwaitables; // 0x30
	private static SynchronizationContext _synchronizationContext; // 0x38
	private static int _mainThreadId; // 0x40

	// Methods

	// RVA: 0x167FC08
	private void SetExceptionFromNative(Exception ex) { }

	// RVA: 0x167FD54
	private void RunContinuation() { }

	// RVA: 0x167FEB0
	private static void ReleaseNativeAwaitable(IntPtr nativeAwaitable) { }

	// RVA: 0x167FF00
	private static int IsNativeAwaitableCompleted(IntPtr nativeAwaitable) { }

	// RVA: 0x167FF50
	private void .ctor() { }

	// RVA: 0x167FF5C
	private static bool MatchCompletionThreadAffinity(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity) { }

	// RVA: 0x1680050
	private void RunOrScheduleContinuation(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, Action continuation) { }

	// RVA: 0x16802E8
	private static void DoRunContinuationOnSynchonizationContext(object continuation) { }

	// RVA: 0x1680358
	internal void RaiseManagedCompletion() { }

	// RVA: 0x16804D8
	internal void PropagateExceptionAndRelease() { }

	// RVA: 0x1680A60
	private bool get_IsCompletedNoLock() { }

	// RVA: 0x1680CC8
	public bool get_IsCompleted() { }

	// RVA: 0x1680E08
	internal bool get_IsDettachedOrCompleted() { }

	// RVA: 0x1681128
	private AwaitableHandle CheckPointerValidity() { }

	// RVA: 0x16811EC
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1681220
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1681224
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x168122C
	private static void OnDelayedCallManagerCleared() { }

	// RVA: 0x1681460
	private static void OnUpdate() { }

	// RVA: 0x1681854
	private static void OnEndOfFrame() { }

	// RVA: 0x16818D0
	internal static void SetSynchronizationContext(UnitySynchronizationContext synchronizationContext) { }

	// RVA: 0x1681978
	private static void .cctor() { }

}

// Namespace: UnityEngine
public class Behaviour
{
	// Methods

	// RVA: 0x168201C
	public bool get_enabled() { }

	// RVA: 0x1682104
	public void set_enabled(bool value) { }

	// RVA: 0x168221C
	public bool get_isActiveAndEnabled() { }

	// RVA: 0x1682304
	public void .ctor() { }

	// RVA: 0x16820B4
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x16821B4
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16822B4
	private static bool get_isActiveAndEnabled_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
internal struct CastHelper<T0>
{
	// Fields
	public T t; // 0x0
	public IntPtr onePointerFurtherThanT; // 0x0
}

// Namespace: UnityEngine
internal static class ClassLibraryInitializer
{
	// Methods

	// RVA: 0x1682414
	private static void Init() { }

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

	// RVA: 0x168241C
	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	// RVA: 0x1682440
	public override string ToString() { }

	// RVA: 0x1682614
	public override bool Equals(object other) { }

	// RVA: 0x16826D4
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

	// RVA: 0x168278C
	public override bool Equals(object other) { }

	// RVA: 0x1682868
	public override int GetHashCode() { }

	// RVA: 0x168290C
	public override string ToString() { }

}

// Namespace: UnityEngine
public class Component
{
	// Methods

	// RVA: 0x1682AE8
	public Transform get_transform() { }

	// RVA: 0x1682BF0
	public GameObject get_gameObject() { }

	// RVA: 0x1682CF8
	public Component GetComponent(Type type) { }

	// RVA: 0x1682DE4
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x26AD93C
	public T GetComponent() { }

	// RVA: 0x1682EE0
	public bool TryGetComponent(Type type, Component component) { }

	// RVA: 0x35252FC
	public bool TryGetComponent(T component) { }

	// RVA: 0x1683050
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	// RVA: 0x26AD93C
	public T GetComponentInChildren(bool includeInactive) { }

	// RVA: 0x26AD93C
	public T GetComponentInChildren() { }

	// RVA: -1
	public T[] GetComponentsInChildren(bool includeInactive) { }

	// RVA: -1
	public void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> result) { }

	// RVA: 0x3525804
	public T[] GetComponentsInChildren() { }

	// RVA: 0x35267E8
	public void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }

	// RVA: 0x1683154
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	// RVA: 0x26AD93C
	public T GetComponentInParent() { }

	// RVA: -1
	public T[] GetComponentsInParent(bool includeInactive) { }

	// RVA: -1
	public void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: 0x3525804
	public T[] GetComponentsInParent() { }

	// RVA: 0x1683258
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x1683354
	public void GetComponents(Type type, System.Collections.Generic.List<UnityEngine.Component> results) { }

	// RVA: 0x35267E8
	public void GetComponents(System.Collections.Generic.List<T> results) { }

	// RVA: 0x3525804
	public T[] GetComponents() { }

	// RVA: 0x16833F8
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x1683638
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	// RVA: 0x168238C
	public void .ctor() { }

	// RVA: 0x1682BA0
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	// RVA: 0x1682CA8
	private static IntPtr get_gameObject_Injected(IntPtr _unity_self) { }

	// RVA: 0x1682E88
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x16832FC
	private static void GetComponentsForListInternal_Injected(IntPtr _unity_self, Type searchType, object resultList) { }

	// RVA: 0x16835D0
	private static void SendMessage_Injected(IntPtr _unity_self, ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	// RVA: 0x1683810
	private static void BroadcastMessage_Injected(IntPtr _unity_self, ManagedSpanWrapper methodName, object parameter, SendMessageOptions options) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1683990
	public static IntPtr ConvertToNative(Coroutine coroutine) { }

}

// Namespace: UnityEngine
public sealed class Coroutine
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1683880
	private void .ctor() { }

	// RVA: 0x1683888
	protected override void Finalize() { }

	// RVA: 0x1683940
	private static void ReleaseCoroutine(IntPtr ptr) { }

}

// Namespace: UnityEngine
internal class SetupCoroutine
{
	// Methods

	// RVA: 0x16839AC
	public static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) { }

	// RVA: 0x1683AD0
	public static object InvokeMember(object behaviour, string name, object variable) { }

}

// Namespace: UnityEngine
public abstract class CustomYieldInstruction
{
	// Methods

	// RVA: -1
	public abstract bool get_keepWaiting() { }

	// RVA: 0x1683BD4
	public object get_Current() { }

	// RVA: 0x1683BDC
	public bool MoveNext() { }

	// RVA: 0x1683BE8
	public virtual void Reset() { }

	// RVA: 0x1683BEC
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

	// RVA: 0x1685A34
	private static void .cctor() { }

	// RVA: 0x1685AA0
	public void .ctor() { }

	// RVA: 0x1685AA8
	internal int <GetCachedEnumData>b__2_5(FieldInfo f) { }

	// RVA: 0x1685AD4
	internal string <GetCachedEnumData>b__2_1(FieldInfo f) { }

	// RVA: 0x1685B54
	internal Enum <GetCachedEnumData>b__2_2(FieldInfo f) { }

	// RVA: 0x1685BC0
	internal int <GetCachedEnumData>b__2_3(Enum v) { }

	// RVA: 0x1685C28
	internal int <GetCachedEnumData>b__2_4(Enum v) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public System.Func<System.String,System.String> nicifyName; // 0x10

	// Methods

	// RVA: 0x1684D58
	public void .ctor() { }

	// RVA: 0x1685C90
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

	// RVA: 0x1683BF4
	public static EnumData GetCachedEnumData(Type enumType, CachedType cachedType, System.Func<System.String,System.String> nicifyName) { }

	// RVA: 0x1684ED4
	public static void HandleInspectorOrderAttribute(Type enumType, EnumData enumData) { }

	// RVA: 0x1684D60
	private static bool CheckObsoleteAddition(FieldInfo field, CachedType cachedType) { }

	// RVA: 0x16854EC
	private static string EnumTooltipFromEnumField(FieldInfo field) { }

	// RVA: 0x1685658
	private static string EnumNameFromEnumField(FieldInfo field, System.Func<System.String,System.String> nicifyName) { }

	// RVA: 0x1685998
	private static void .cctor() { }

	// RVA: 0x1685924
	internal static string <EnumNameFromEnumField>g__NicifyName|8_0(UnityEngine.EnumDataUtility.<>c__DisplayClass8_0& ) { }

}

// Namespace: UnityEngine
public class ExcludeFromObjectFactoryAttribute
{
	// Methods

	// RVA: 0x1685D24
	public void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class ExtensionOfNativeClassAttribute
{
	// Methods

	// RVA: 0x1685D2C
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class FailedToLoadScriptObject
{}

// Namespace: UnityEngine
public sealed class GameObject
{
	// Methods

	// RVA: 0x1685D34
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	// RVA: 0x26AD93C
	public T GetComponent() { }

	// RVA: 0x1682D24
	public Component GetComponent(Type type) { }

	// RVA: 0x1685E64
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x1683084
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	// RVA: 0x26AD93C
	public T GetComponentInChildren() { }

	// RVA: 0x26AD93C
	public T GetComponentInChildren(bool includeInactive) { }

	// RVA: 0x1683188
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	// RVA: 0x26AD93C
	public T GetComponentInParent() { }

	// RVA: 0x26AD93C
	public T GetComponentInParent(bool includeInactive) { }

	// RVA: 0x1686010
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x3525804
	public T[] GetComponents() { }

	// RVA: 0x35267E8
	public void GetComponents(System.Collections.Generic.List<T> results) { }

	// RVA: -1
	public T[] GetComponentsInChildren(bool includeInactive) { }

	// RVA: -1
	public void GetComponentsInChildren(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: 0x3525804
	public T[] GetComponentsInChildren() { }

	// RVA: 0x35267E8
	public void GetComponentsInChildren(System.Collections.Generic.List<T> results) { }

	// RVA: -1
	public void GetComponentsInParent(bool includeInactive, System.Collections.Generic.List<T> results) { }

	// RVA: -1
	public T[] GetComponentsInParent(bool includeInactive) { }

	// RVA: 0x35252FC
	public bool TryGetComponent(T component) { }

	// RVA: 0x1682F14
	public bool TryGetComponent(Type type, Component component) { }

	// RVA: 0x168616C
	internal Component TryGetComponentInternal(Type type) { }

	// RVA: 0x16863B8
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x16864B4
	private Component Internal_AddComponentWithType(Type componentType) { }

	// RVA: 0x16865DC
	public Component AddComponent(Type componentType) { }

	// RVA: 0x26AD93C
	public T AddComponent() { }

	// RVA: 0x16865E0
	public Transform get_transform() { }

	// RVA: 0x16866E8
	public int get_layer() { }

	// RVA: 0x16867D0
	public void set_layer(int value) { }

	// RVA: 0x16868E8
	public void SetActive(bool value) { }

	// RVA: 0x1686A00
	public bool get_activeSelf() { }

	// RVA: 0x1686AE8
	public bool get_activeInHierarchy() { }

	// RVA: 0x1686BD0
	public bool get_isStatic() { }

	// RVA: 0x1686CB8
	public void set_tag(string value) { }

	// RVA: 0x1686EDC
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x168711C
	public void .ctor(string name) { }

	// RVA: 0x1687314
	public void .ctor() { }

	// RVA: 0x1687384
	public void .ctor(string name, Type[] components) { }

	// RVA: 0x1687190
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	// RVA: 0x16874A8
	public static GameObject Find(string name) { }

	// RVA: 0x1687704
	public Scene get_scene() { }

	// RVA: 0x1687810
	public GameObject get_gameObject() { }

	// RVA: 0x1685DAC
	private static IntPtr CreatePrimitive_Injected(PrimitiveType type) { }

	// RVA: 0x1685DFC
	private static IntPtr GetComponent_Injected(IntPtr _unity_self, Type type) { }

	// RVA: 0x1685F08
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x1685F60
	private static IntPtr GetComponentInChildren_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	// RVA: 0x1685FB8
	private static IntPtr GetComponentInParent_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	// RVA: 0x16860E4
	private static Array GetComponentsInternal_Injected(IntPtr _unity_self, Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x1686350
	private static IntPtr TryGetComponentInternal_Injected(IntPtr _unity_self, Type type) { }

	// RVA: 0x168645C
	private static void TryGetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x1686574
	private static IntPtr Internal_AddComponentWithType_Injected(IntPtr _unity_self, Type componentType) { }

	// RVA: 0x1686698
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	// RVA: 0x1686780
	private static int get_layer_Injected(IntPtr _unity_self) { }

	// RVA: 0x1686880
	private static void set_layer_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1686998
	private static void SetActive_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1686A98
	private static bool get_activeSelf_Injected(IntPtr _unity_self) { }

	// RVA: 0x1686B80
	private static bool get_activeInHierarchy_Injected(IntPtr _unity_self) { }

	// RVA: 0x1686C68
	private static bool get_isStatic_Injected(IntPtr _unity_self) { }

	// RVA: 0x1686E74
	private static void set_tag_Injected(IntPtr _unity_self, ManagedSpanWrapper value) { }

	// RVA: 0x16870B4
	private static void SendMessage_Injected(IntPtr _unity_self, ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	// RVA: 0x1687440
	private static void Internal_CreateGameObject_Injected(GameObject self, ManagedSpanWrapper name) { }

	// RVA: 0x16876B4
	private static IntPtr Find_Injected(ManagedSpanWrapper name) { }

	// RVA: 0x16877A8
	private static void get_scene_Injected(IntPtr _unity_self, Scene ret) { }

}

// Namespace: UnityEngine
public sealed class InspectorOrderAttribute
{
	// Fields
	private InspectorSort <m_inspectorSort>k__BackingField; // 0x18
	private InspectorSortDirection <m_sortDirection>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x1687814
	internal InspectorSort get_m_inspectorSort() { }

	// RVA: 0x168781C
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

	// RVA: 0x1687824
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x1687828
	public static LayerMask op_Implicit(int intVal) { }

	// RVA: 0x168782C
	public static int NameToLayer(string layerName) { }

	// RVA: 0x16879B4
	private static int NameToLayer_Injected(ManagedSpanWrapper layerName) { }

}

// Namespace: UnityEngine
[Serializable]
public struct LazyLoadReference<T0>
{
	// Fields
	private const int kInstanceID_None = 0;
	private int m_InstanceID; // 0x0

	// Methods

	// RVA: 0x35251DC
	public bool get_isSet() { }

	// RVA: 0x26AD93C
	public T get_asset() { }

	// RVA: 0x26AD93C
	public void set_asset(T value) { }

	// RVA: 0x26AD93C
	public static UnityEngine.LazyLoadReference<T> op_Implicit(T asset) { }

}

// Namespace: UnityEngine
internal static class ManagedStreamHelpers
{
	// Methods

	// RVA: 0x1687A04
	internal static void ValidateLoadFromStream(Stream stream) { }

	// RVA: 0x1687B20
	internal static void ManagedStreamRead(Byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0x1687C00
	internal static void ManagedStreamSeek(Int64 offset, UInt32 origin, Stream stream, IntPtr returnValueAddress) { }

	// RVA: 0x1687CD0
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }

}

// Namespace: UnityEngine
public class MonoBehaviour
{
	// Fields
	private CancellationTokenSource m_CancellationTokenSource; // 0x18

	// Methods

	// RVA: 0x1687D80
	public CancellationToken get_destroyCancellationToken() { }

	// RVA: 0x16881D8
	private void RaiseCancellation() { }

	// RVA: 0x16881EC
	public bool IsInvoking() { }

	// RVA: 0x16882B8
	public void CancelInvoke() { }

	// RVA: 0x1688384
	public void Invoke(string methodName, float time) { }

	// RVA: 0x1688594
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x1688680
	public void CancelInvoke(string methodName) { }

	// RVA: 0x1688874
	public bool IsInvoking(string methodName) { }

	// RVA: 0x1688A80
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x1688A88
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x1688E14
	public Coroutine StartCoroutine(IEnumerator routine) { }

	// RVA: 0x1689010
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x1689014
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x1689210
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x1689410
	public void StopCoroutine(string methodName) { }

	// RVA: 0x1689634
	public void StopAllCoroutines() { }

	// RVA: 0x168971C
	public bool get_useGUILayout() { }

	// RVA: 0x1689804
	public void set_useGUILayout(bool value) { }

	// RVA: 0x168991C
	public bool get_didStart() { }

	// RVA: 0x1689A04
	public bool get_didAwake() { }

	// RVA: 0x1689AEC
	public static void print(object message) { }

	// RVA: 0x16882BC
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	// RVA: 0x16881F0
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	// RVA: 0x168838C
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	// RVA: 0x1688684
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	// RVA: 0x1688878
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	// RVA: 0x1688B6C
	private static bool IsObjectMonoBehaviour(object obj) { }

	// RVA: 0x1688C34
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x1688F60
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x1689364
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x1689160
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x1689F2C
	internal string GetScriptClassName() { }

	// RVA: 0x1688140
	private void OnCancellationTokenCreated() { }

	// RVA: 0x168A124
	public void .ctor() { }

	// RVA: 0x16895CC
	private static void StopCoroutine_Injected(IntPtr _unity_self, ManagedSpanWrapper methodName) { }

	// RVA: 0x16896CC
	private static void StopAllCoroutines_Injected(IntPtr _unity_self) { }

	// RVA: 0x16897B4
	private static bool get_useGUILayout_Injected(IntPtr _unity_self) { }

	// RVA: 0x16898B4
	private static void set_useGUILayout_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x16899B4
	private static bool get_didStart_Injected(IntPtr _unity_self) { }

	// RVA: 0x1689A9C
	private static bool get_didAwake_Injected(IntPtr _unity_self) { }

	// RVA: 0x1689B74
	private static void Internal_CancelInvokeAll_Injected(IntPtr self) { }

	// RVA: 0x1689BC4
	private static bool Internal_IsInvokingAll_Injected(IntPtr self) { }

	// RVA: 0x1689C14
	private static void InvokeDelayed_Injected(IntPtr self, ManagedSpanWrapper methodName, float time, float repeatRate) { }

	// RVA: 0x1689C7C
	private static void CancelInvoke_Injected(IntPtr self, ManagedSpanWrapper methodName) { }

	// RVA: 0x1689CE4
	private static bool IsInvoking_Injected(IntPtr self, ManagedSpanWrapper methodName) { }

	// RVA: 0x1689D4C
	private static bool IsObjectMonoBehaviour_Injected(IntPtr obj) { }

	// RVA: 0x1689D9C
	private static Coroutine StartCoroutineManaged_Injected(IntPtr _unity_self, ManagedSpanWrapper methodName, object value) { }

	// RVA: 0x1689DF4
	private static Coroutine StartCoroutineManaged2_Injected(IntPtr _unity_self, IEnumerator enumerator) { }

	// RVA: 0x1689E5C
	private static void StopCoroutineManaged_Injected(IntPtr _unity_self, IntPtr routine) { }

	// RVA: 0x1689EC4
	private static void StopCoroutineFromEnumeratorManaged_Injected(IntPtr _unity_self, IEnumerator routine) { }

	// RVA: 0x168A06C
	private static void GetScriptClassName_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x168A0D4
	private static void OnCancellationTokenCreated_Injected(IntPtr _unity_self) { }

}

// Namespace: 
private class ListPrivateFieldAccess<T0>
{
	// Fields
	internal T[] _items; // 0x0
	internal int _size; // 0x0
	internal int _version; // 0x0
}

// Namespace: UnityEngine
internal static class NoAllocHelpers
{
	// Methods

	// RVA: 0x352C064
	public static void EnsureListElemCount(System.Collections.Generic.List<T> list, int count) { }

	// RVA: 0x168A1AC
	public static int SafeLength(Array values) { }

	// RVA: 0x35284B0
	public static int SafeLength(System.Collections.Generic.List<T> values) { }

	// RVA: 0x35293EC
	public static T[] ExtractArrayFromList(System.Collections.Generic.List<T> list) { }

	// RVA: 0x26AD93C
	public static void ResetListContents(System.Collections.Generic.List<T> list, System.ReadOnlySpan<T> span) { }

	// RVA: 0x352C064
	public static void ResetListSize(System.Collections.Generic.List<T> list, int size) { }

}

// Namespace: UnityEngine
public struct RangeInt
{
	// Fields
	public int start; // 0x10
	public int length; // 0x14

	// Methods

	// RVA: 0x168A1BC
	public int get_end() { }

	// RVA: 0x168A1C8
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

	// RVA: 0x168A1D0
	public void .ctor() { }

	// RVA: 0x168A200
	public void .ctor(RuntimeInitializeLoadType loadType) { }

	// RVA: 0x168A1F8
	private void set_loadType(RuntimeInitializeLoadType value) { }

}

// Namespace: UnityEngine
public class ScriptableObject
{
	// Methods

	// RVA: 0x168A22C
	public void .ctor() { }

	// RVA: 0x168A340
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: 0x26AD93C
	public static T CreateInstance() { }

	// RVA: 0x168A2F0
	private static void CreateScriptableObject(ScriptableObject self) { }

	// RVA: 0x168A3BC
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

	// RVA: 0x168A43C
	private static IntPtr CreateScriptableObjectInstanceFromType_Injected(Type type, bool applyDefaultsAndReset) { }

}

// Namespace: UnityEngine
internal class ScriptingRuntime
{
	// Methods

	// RVA: 0x168A4A4
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

	// RVA: 0x168A4E4
	private static bool IsManagedCodeWorking() { }

	// RVA: 0x168A4EC
	private static void SetupCallbacks(IntPtr p) { }

}

// Namespace: UnityEngine
public class SelectionBaseAttribute
{
	// Methods

	// RVA: 0x168A4F0
	public void .ctor() { }

}

// Namespace: UnityEngine
public static class StackTraceUtility
{
	// Fields
	private static string projectFolder; // 0x0

	// Methods

	// RVA: 0x168A4F8
	internal static void SetProjectFolder(string folder) { }

	// RVA: 0x168A60C
	public static string ExtractStackTrace() { }

	// RVA: 0x168AF64
	internal static void ExtractStringFromExceptionInternal(object exceptiono, string message, string stackTrace) { }

	// RVA: 0x168A798
	internal static string ExtractFormattedStackTrace(StackTrace stackFrames) { }

	// RVA: 0x168B2F0
	private static void .cctor() { }

}

// Namespace: UnityEngine
[Serializable]
public class UnityException
{
	// Methods

	// RVA: 0x168B368
	public void .ctor() { }

	// RVA: 0x1688604
	public void .ctor(string message) { }

	// RVA: 0x168B3F4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: UnityEngine
[Serializable]
public class MissingComponentException
{
	// Methods

	// RVA: 0x168B478
	public void .ctor() { }

	// RVA: 0x168B504
	public void .ctor(string message) { }

	// RVA: 0x168B580
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: UnityEngine
[Serializable]
public class MissingReferenceException
{
	// Methods

	// RVA: 0x168B604
	public void .ctor() { }

	// RVA: 0x16880C4
	public void .ctor(string message) { }

	// RVA: 0x168B690
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
internal enum CreateOptions
{
	// Fields
	public int value__; // 0x10
	public const CreateOptions None = 0;
	public const CreateOptions CreateNativeObject = 1;
}

// Namespace: 
private static class EncodingUtility
{
	// Fields
	internal static readonly System.Collections.Generic.KeyValuePair<System.Byte[],System.Text.Encoding>[] encodingLookup; // 0x0
	internal static readonly Encoding targetEncoding; // 0x8

	// Methods

	// RVA: 0x168BFC8
	private static void .cctor() { }

}

// Namespace: UnityEngine
public class TextAsset
{
	// Methods

	// RVA: 0x168B714
	public Byte[] get_bytes() { }

	// RVA: 0x168B7FC
	private static void Internal_CreateInstance(TextAsset self, string text) { }

	// RVA: 0x168B9E8
	public string get_text() { }

	// RVA: 0x168BE98
	public override string ToString() { }

	// RVA: 0x168BE9C
	public void .ctor() { }

	// RVA: 0x168BF0C
	internal void .ctor(CreateOptions options, string text) { }

	// RVA: 0x168BAAC
	internal static string DecodeString(Byte[] bytes) { }

	// RVA: 0x168B7AC
	private static Byte[] get_bytes_Injected(IntPtr _unity_self) { }

	// RVA: 0x168B980
	private static void Internal_CreateInstance_Injected(TextAsset self, ManagedSpanWrapper text) { }

}

// Namespace: UnityEngine
public class TrackedReference
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x168C394
	protected void .ctor() { }

	// RVA: 0x168C39C
	public static bool op_Equality(TrackedReference x, TrackedReference y) { }

	// RVA: 0x168C410
	public static bool op_Inequality(TrackedReference x, TrackedReference y) { }

	// RVA: 0x168C484
	public override bool Equals(object o) { }

	// RVA: 0x168C560
	public override int GetHashCode() { }

	// RVA: 0x168C56C
	public static bool op_Implicit(TrackedReference exists) { }

}

// Namespace: UnityEngine
internal sealed class UnhandledExceptionHandler
{
	// Methods

	// RVA: 0x168C580
	private static void RegisterUECatcher() { }

	// RVA: 0x168C618
	private static void HandleUnhandledException(object sender, UnhandledExceptionEventArgs args) { }

	// RVA: 0x168C79C
	private static void PrintException(string title, Exception e) { }

	// RVA: 0x168C848
	private static void iOSNativeUnhandledExceptionHandler(string managedExceptionType, string managedExceptionMessage, string managedExceptionStack) { }

	// RVA: 0x168CB5C
	private static void iOSNativeUnhandledExceptionHandler_Injected(ManagedSpanWrapper managedExceptionType, ManagedSpanWrapper managedExceptionMessage, ManagedSpanWrapper managedExceptionStack) { }

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

// Namespace: 
internal static class MarshalledUnityObject
{
	// Methods

	// RVA: 0x26AD93C
	public static IntPtr Marshal(T obj) { }

	// RVA: 0x26AD93C
	public static IntPtr MarshalNotNull(T obj) { }

	// RVA: 0x168F8F4
	public static void TryThrowEditorNullExceptionObject(object unityObj, string paramterName) { }

}

// Namespace: UnityEngine
public class Object
{
	// Fields
	private const int kInstanceID_None = 0;
	private IntPtr m_CachedPtr; // 0x10
	internal static readonly int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Methods

	// RVA: 0x168CBB4
	public int GetInstanceID() { }

	// RVA: 0x168CC2C
	public override int GetHashCode() { }

	// RVA: 0x168CC34
	public override bool Equals(object other) { }

	// RVA: 0x168CF78
	public static bool op_Implicit(object exists) { }

	// RVA: 0x168CE94
	private static bool CompareBaseObjects(object lhs, object rhs) { }

	// RVA: 0x168D044
	private static bool IsNativeObjectAlive(object o) { }

	// RVA: 0x168D068
	private IntPtr GetCachedPtr() { }

	// RVA: 0x168D070
	public string get_name() { }

	// RVA: 0x168D1D8
	public void set_name(string value) { }

	// RVA: 0x168D3C4
	public static object Instantiate(object original, Vector3 position, Quaternion rotation) { }

	// RVA: 0x168D7E0
	public static object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x168DC8C
	public static object Instantiate(object original) { }

	// RVA: 0x168DF44
	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: 0x26AD93C
	public static T Instantiate(T original) { }

	// RVA: 0x26AD93C
	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	// RVA: 0x26AD93C
	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	// RVA: 0x26AD93C
	public static T Instantiate(T original, Transform parent) { }

	// RVA: 0x26AD93C
	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	// RVA: 0x168E378
	public static void Destroy(object obj, float t) { }

	// RVA: 0x168E4C8
	public static void Destroy(object obj) { }

	// RVA: 0x168E600
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	// RVA: 0x168E75C
	public static void DestroyImmediate(object obj) { }

	// RVA: 0x168E894
	public static object[] FindObjectsOfType(Type type) { }

	// RVA: 0x168E948
	public static object[] FindObjectsOfType(Type type, bool includeInactive) { }

	// RVA: 0x168E9B0
	public static object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	// RVA: 0x168EA08
	public static void DontDestroyOnLoad(object target) { }

	// RVA: 0x168EB5C
	public HideFlags get_hideFlags() { }

	// RVA: 0x168EC80
	public void set_hideFlags(HideFlags value) { }

	// RVA: -1
	public static T[] FindObjectsByType(FindObjectsSortMode sortMode) { }

	// RVA: 0x26AD93C
	public static T FindObjectOfType() { }

	// RVA: 0x26AD93C
	public static T FindFirstObjectByType() { }

	// RVA: 0x168D654
	private static void CheckNullArgument(object arg, string message) { }

	// RVA: 0x168EDC8
	public static object FindObjectOfType(Type type) { }

	// RVA: 0x168EEA0
	public static object FindObjectOfType(Type type, bool includeInactive) { }

	// RVA: 0x168EF7C
	public static object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	// RVA: 0x168F068
	public override string ToString() { }

	// RVA: 0x1687F98
	public static bool op_Equality(object x, object y) { }

	// RVA: 0x168622C
	public static bool op_Inequality(object x, object y) { }

	// RVA: 0x168F234
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	// RVA: 0x168DE2C
	private static object Internal_CloneSingle(object data) { }

	// RVA: 0x168E1DC
	private static object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	// RVA: 0x168D6A4
	private static object Internal_InstantiateSingle(object data, Vector3 pos, Quaternion rot) { }

	// RVA: 0x168DADC
	private static object Internal_InstantiateSingleWithParent(object data, Transform parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0x168F0E8
	private static string ToString(object obj) { }

	// RVA: 0x168D074
	private string GetName() { }

	// RVA: 0x168F4AC
	internal static bool IsPersistent(object obj) { }

	// RVA: 0x168D1DC
	private void SetName(string name) { }

	// RVA: 0x168F668
	internal static object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x168F778
	internal static object ForceLoadFromInstanceID(int instanceID) { }

	// RVA: 0x1683878
	public void .ctor() { }

	// RVA: 0x168F888
	private static void .cctor() { }

	// RVA: 0x168E460
	private static void Destroy_Injected(IntPtr obj, float t) { }

	// RVA: 0x168E6F4
	private static void DestroyImmediate_Injected(IntPtr obj, bool allowDestroyingAssets) { }

	// RVA: 0x168EB0C
	private static void DontDestroyOnLoad_Injected(IntPtr target) { }

	// RVA: 0x168EC30
	private static HideFlags get_hideFlags_Injected(IntPtr _unity_self) { }

	// RVA: 0x168ED60
	private static void set_hideFlags_Injected(IntPtr _unity_self, HideFlags value) { }

	// RVA: 0x168F274
	private static IntPtr Internal_CloneSingle_Injected(IntPtr data) { }

	// RVA: 0x168F2C4
	private static IntPtr Internal_CloneSingleWithParent_Injected(IntPtr data, IntPtr parent, bool worldPositionStays) { }

	// RVA: 0x168F31C
	private static IntPtr Internal_InstantiateSingle_Injected(IntPtr data, Vector3 pos, Quaternion rot) { }

	// RVA: 0x168F374
	private static IntPtr Internal_InstantiateSingleWithParent_Injected(IntPtr data, IntPtr parent, Vector3 pos, Quaternion rot) { }

	// RVA: 0x168F3DC
	private static void ToString_Injected(IntPtr obj, ManagedSpanWrapper ret) { }

	// RVA: 0x168F444
	private static void GetName_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x168F5B0
	private static bool IsPersistent_Injected(IntPtr obj) { }

	// RVA: 0x168F600
	private static void SetName_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x168F728
	private static IntPtr FindObjectFromInstanceID_Injected(int instanceID) { }

	// RVA: 0x168F838
	private static IntPtr ForceLoadFromInstanceID_Injected(int instanceID) { }

}

// Namespace: 
private struct WorkRequest
{
	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x10
	private readonly object m_DelagateState; // 0x18
	private readonly ManualResetEvent m_WaitHandle; // 0x20

	// Methods

	// RVA: 0x168FD70
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x16901DC
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

	// RVA: 0x168F8F8
	internal int get_MainThreadId() { }

	// RVA: 0x168F900
	private void .ctor(int mainThreadID) { }

	// RVA: 0x168F9D0
	private void .ctor(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x168FA8C
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x168FDC0
	public override void OperationStarted() { }

	// RVA: 0x168FDCC
	public override void OperationCompleted() { }

	// RVA: 0x168FDD8
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x168FF40
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x168FFB0
	public void Exec() { }

	// RVA: 0x16902C0
	private bool HasPendingTasks() { }

	// RVA: 0x169032C
	private static void InitializeSynchronizationContext() { }

	// RVA: 0x1690458
	private static void ExecuteTasks() { }

	// RVA: 0x16904C0
	private static bool ExecutePendingTasks(Int64 millisecondsTimeout) { }

}

// Namespace: UnityEngine
public sealed class WaitForEndOfFrame
{
	// Methods

	// RVA: 0x1690648
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForFixedUpdate
{
	// Methods

	// RVA: 0x1690650
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class WaitForSeconds
{
	// Fields
	internal float m_Seconds; // 0x10

	// Methods

	// RVA: 0x1690658
	public void .ctor(float seconds) { }

}

// Namespace: UnityEngine
public class WaitForSecondsRealtime
{
	// Fields
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Methods

	// RVA: 0x169068C
	public float get_waitTime() { }

	// RVA: 0x1690694
	public void set_waitTime(float value) { }

	// RVA: 0x169069C
	public override bool get_keepWaiting() { }

	// RVA: 0x16907B0
	public void .ctor(float time) { }

	// RVA: 0x16907EC
	public override void Reset() { }

}

// Namespace: UnityEngine
public class YieldInstruction
{
	// Methods

	// RVA: 0x167EC48
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializeField
{
	// Methods

	// RVA: 0x16907F8
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class SerializeReference
{
	// Methods

	// RVA: 0x1690800
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

	// RVA: 0x1690808
	public int FindKernel(string name) { }

	// RVA: 0x16909E0
	private static int FindKernel_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

}

// Namespace: UnityEngine
public sealed class ShaderVariantCollection
{
	// Methods

	// RVA: 0x1690A48
	public void WarmUp() { }

	// RVA: 0x1690AE0
	private static void WarmUp_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
internal class LowerResBlitTexture
{
	// Methods

	// RVA: 0x1690B30
	internal void LowerResBlitTextureDontStripMe() { }

}

// Namespace: UnityEngine
internal class PreloadData
{
	// Methods

	// RVA: 0x1690B34
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

	// RVA: 0x1690B38
	public static float get_batteryLevel() { }

	// RVA: 0x1690BB8
	public static BatteryStatus get_batteryStatus() { }

	// RVA: 0x1690C38
	public static string get_operatingSystem() { }

	// RVA: 0x1690D1C
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x1690D9C
	public static string get_processorType() { }

	// RVA: 0x1690E80
	public static int get_processorFrequency() { }

	// RVA: 0x1690F00
	public static int get_processorCount() { }

	// RVA: 0x1690F80
	public static int get_systemMemorySize() { }

	// RVA: 0x1691000
	public static string get_deviceUniqueIdentifier() { }

	// RVA: 0x16910E4
	public static string get_deviceName() { }

	// RVA: 0x16911C8
	public static string get_deviceModel() { }

	// RVA: 0x16912AC
	public static bool get_supportsAccelerometer() { }

	// RVA: 0x169132C
	public static bool get_supportsGyroscope() { }

	// RVA: 0x16913AC
	public static bool get_supportsLocationService() { }

	// RVA: 0x169142C
	public static bool get_supportsVibration() { }

	// RVA: 0x16914AC
	public static bool get_supportsAudio() { }

	// RVA: 0x169152C
	public static DeviceType get_deviceType() { }

	// RVA: 0x16915AC
	public static int get_graphicsMemorySize() { }

	// RVA: 0x169162C
	public static string get_graphicsDeviceName() { }

	// RVA: 0x1691710
	public static string get_graphicsDeviceVendor() { }

	// RVA: 0x16917F4
	public static int get_graphicsDeviceID() { }

	// RVA: 0x1691874
	public static int get_graphicsDeviceVendorID() { }

	// RVA: 0x16918F4
	public static GraphicsDeviceType get_graphicsDeviceType() { }

	// RVA: 0x1691974
	public static string get_graphicsDeviceVersion() { }

	// RVA: 0x1691A58
	public static int get_graphicsShaderLevel() { }

	// RVA: 0x1691AD8
	public static bool get_graphicsMultiThreaded() { }

	// RVA: 0x1691B58
	public static bool get_supportsShadows() { }

	// RVA: 0x1691BD8
	public static bool get_supportsRawShadowDepthSampling() { }

	// RVA: 0x1691C58
	public static bool get_supports3DTextures() { }

	// RVA: 0x1691CD8
	public static bool get_supports2DArrayTextures() { }

	// RVA: 0x1691D58
	public static bool get_supports3DRenderTextures() { }

	// RVA: 0x1691DD8
	public static bool get_supportsCubemapArrayTextures() { }

	// RVA: 0x1691E58
	public static CopyTextureSupport get_copyTextureSupport() { }

	// RVA: 0x1691ED8
	public static bool get_supportsComputeShaders() { }

	// RVA: 0x1691F58
	public static bool get_supportsInstancing() { }

	// RVA: 0x1691FD8
	public static bool get_supports32bitsIndexBuffer() { }

	// RVA: 0x1692058
	public static bool get_supportsSparseTextures() { }

	// RVA: 0x16920D8
	public static int get_supportedRenderTargetCount() { }

	// RVA: 0x1692158
	private static bool IsValidEnumValue(Enum value) { }

	// RVA: 0x16921C4
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x169232C
	public static bool SupportsTextureFormat(TextureFormat format) { }

	// RVA: 0x1692494
	public static NPOTSupport get_npotSupport() { }

	// RVA: 0x1692514
	public static int get_maxTextureSize() { }

	// RVA: 0x1692594
	internal static int get_maxRenderTextureSize() { }

	// RVA: 0x1690B78
	private static float GetBatteryLevel() { }

	// RVA: 0x1690BF8
	private static BatteryStatus GetBatteryStatus() { }

	// RVA: 0x1690C3C
	private static string GetOperatingSystem() { }

	// RVA: 0x1690D5C
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	// RVA: 0x1690DA0
	private static string GetProcessorType() { }

	// RVA: 0x1690EC0
	private static int GetProcessorFrequencyMHz() { }

	// RVA: 0x1690F40
	private static int GetProcessorCount() { }

	// RVA: 0x1690FC0
	private static int GetPhysicalMemoryMB() { }

	// RVA: 0x1691004
	private static string GetDeviceUniqueIdentifier() { }

	// RVA: 0x16910E8
	private static string GetDeviceName() { }

	// RVA: 0x16911CC
	private static string GetDeviceModel() { }

	// RVA: 0x16912EC
	private static bool SupportsAccelerometer() { }

	// RVA: 0x169136C
	private static bool IsGyroAvailable() { }

	// RVA: 0x16913EC
	private static bool SupportsLocationService() { }

	// RVA: 0x169146C
	private static bool SupportsVibration() { }

	// RVA: 0x16914EC
	private static bool SupportsAudio() { }

	// RVA: 0x169156C
	private static DeviceType GetDeviceType() { }

	// RVA: 0x16915EC
	private static int GetGraphicsMemorySize() { }

	// RVA: 0x1691630
	private static string GetGraphicsDeviceName() { }

	// RVA: 0x1691714
	private static string GetGraphicsDeviceVendor() { }

	// RVA: 0x1691834
	private static int GetGraphicsDeviceID() { }

	// RVA: 0x16918B4
	private static int GetGraphicsDeviceVendorID() { }

	// RVA: 0x1691934
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	// RVA: 0x1691978
	private static string GetGraphicsDeviceVersion() { }

	// RVA: 0x1691A98
	private static int GetGraphicsShaderLevel() { }

	// RVA: 0x1691B18
	private static bool GetGraphicsMultiThreaded() { }

	// RVA: 0x1691B98
	private static bool SupportsShadows() { }

	// RVA: 0x1691C18
	private static bool SupportsRawShadowDepthSampling() { }

	// RVA: 0x1691C98
	private static bool Supports3DTextures() { }

	// RVA: 0x1691D18
	private static bool Supports2DArrayTextures() { }

	// RVA: 0x1691D98
	private static bool Supports3DRenderTextures() { }

	// RVA: 0x1691E18
	private static bool SupportsCubemapArrayTextures() { }

	// RVA: 0x1691E98
	private static CopyTextureSupport GetCopyTextureSupport() { }

	// RVA: 0x1691F18
	private static bool SupportsComputeShaders() { }

	// RVA: 0x1691F98
	private static bool SupportsInstancing() { }

	// RVA: 0x1692018
	private static bool Supports32bitsIndexBuffer() { }

	// RVA: 0x1692098
	private static bool SupportsSparseTextures() { }

	// RVA: 0x1692118
	private static int SupportedRenderTargetCount() { }

	// RVA: 0x16922DC
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	// RVA: 0x1692444
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	// RVA: 0x16924D4
	private static NPOTSupport GetNPOTSupport() { }

	// RVA: 0x1692554
	private static int GetMaxTextureSize() { }

	// RVA: 0x16925D4
	private static int GetMaxRenderTextureSize() { }

	// RVA: 0x1692894
	public static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage) { }

	// RVA: 0x16928FC
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	// RVA: 0x1692964
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	// RVA: 0x1692614
	private static void GetOperatingSystem_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x1692664
	private static void GetProcessorType_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16926B4
	private static void GetDeviceUniqueIdentifier_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x1692704
	private static void GetDeviceName_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x1692754
	private static void GetDeviceModel_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16927A4
	private static void GetGraphicsDeviceName_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16927F4
	private static void GetGraphicsDeviceVendor_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x1692844
	private static void GetGraphicsDeviceVersion_Injected(ManagedSpanWrapper ret) { }

}

// Namespace: UnityEngine
internal class SystemClock
{
	// Fields
	private static readonly DateTime s_Epoch; // 0x0

	// Methods

	// RVA: 0x16929B4
	public static DateTime get_now() { }

	// RVA: 0x1692A24
	private static void .cctor() { }

}

// Namespace: UnityEngine
public class Time
{
	// Methods

	// RVA: 0x1692AA4
	public static float get_time() { }

	// RVA: 0x1692AE4
	public static RationalTime get_timeAsRational() { }

	// RVA: 0x1692B84
	public static float get_timeSinceLevelLoad() { }

	// RVA: 0x1692BC4
	public static float get_deltaTime() { }

	// RVA: 0x1692C04
	public static float get_unscaledTime() { }

	// RVA: 0x1692C44
	public static float get_fixedUnscaledTime() { }

	// RVA: 0x1692C84
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x1692CC4
	public static float get_fixedDeltaTime() { }

	// RVA: 0x1692D04
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x1692D5C
	public static float get_timeScale() { }

	// RVA: 0x1692D9C
	public static void set_timeScale(float value) { }

	// RVA: 0x1681C44
	public static int get_frameCount() { }

	// RVA: 0x1692DF4
	public static int get_renderedFrameCount() { }

	// RVA: 0x1690770
	public static float get_realtimeSinceStartup() { }

	// RVA: 0x1692E34
	public static Double get_realtimeSinceStartupAsDouble() { }

	// RVA: 0x1692B34
	private static void get_timeAsRational_Injected(RationalTime ret) { }

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

// Namespace: 
public enum InputFieldAppearance
{
	// Fields
	public int value__; // 0x10
	public const InputFieldAppearance Customizable = 0;
	public const InputFieldAppearance AlwaysVisible = 1;
	public const InputFieldAppearance AlwaysHidden = 2;
}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16943B0
	public static IntPtr ConvertToNative(TouchScreenKeyboard touchScreenKeyboard) { }

}

// Namespace: UnityEngine
public class TouchScreenKeyboard
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static bool <disableInPlaceEditing>k__BackingField; // 0x0

	// Methods

	// RVA: 0x1692E74
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1692EC4
	private void Destroy() { }

	// RVA: 0x1692F74
	protected override void Finalize() { }

	// RVA: 0x1693084
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	// RVA: 0x16931C0
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x1693484
	public static bool get_isSupported() { }

	// RVA: 0x169358C
	internal static bool get_disableInPlaceEditing() { }

	// RVA: 0x16935D8
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x1693678
	private static bool IsInPlaceEditingAllowed() { }

	// RVA: 0x16936B8
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	// RVA: 0x1693774
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	// RVA: 0x1693848
	public string get_text() { }

	// RVA: 0x16939C8
	public void set_text(string value) { }

	// RVA: 0x1693BE0
	public static void set_hideInput(bool value) { }

	// RVA: 0x1693C30
	public static InputFieldAppearance get_inputFieldAppearance() { }

	// RVA: 0x1693C70
	public bool get_active() { }

	// RVA: 0x1693D30
	public void set_active(bool value) { }

	// RVA: 0x1693E20
	public Status get_status() { }

	// RVA: 0x1693EE0
	public void set_characterLimit(int value) { }

	// RVA: 0x1693FD0
	public bool get_canGetSelection() { }

	// RVA: 0x1694090
	public bool get_canSetSelection() { }

	// RVA: 0x1694150
	public RangeInt get_selection() { }

	// RVA: 0x1694210
	public void set_selection(RangeInt value) { }

	// RVA: 0x16941A8
	private static void GetSelection(int start, int length) { }

	// RVA: 0x1694348
	private static void SetSelection(int start, int length) { }

	// RVA: 0x169342C
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper_Injected(TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ManagedSpanWrapper text, ManagedSpanWrapper textPlaceholder) { }

	// RVA: 0x1693960
	private static void get_text_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x1693B78
	private static void set_text_Injected(IntPtr _unity_self, ManagedSpanWrapper value) { }

	// RVA: 0x1693CE0
	private static bool get_active_Injected(IntPtr _unity_self) { }

	// RVA: 0x1693DB8
	private static void set_active_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1693E90
	private static Status get_status_Injected(IntPtr _unity_self) { }

	// RVA: 0x1693F68
	private static void set_characterLimit_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1694040
	private static bool get_canGetSelection_Injected(IntPtr _unity_self) { }

	// RVA: 0x1694100
	private static bool get_canSetSelection_Injected(IntPtr _unity_self) { }

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

	// RVA: 0x16943CC
	public static bool TryConvertStringToDouble(string str, Double value, Expression expr) { }

	// RVA: 0x1694578
	public static bool TryConvertStringToDouble(string str, string initialValueAsString, Double value, Expression expression) { }

	// RVA: 0x16946DC
	public static bool TryConvertStringToFloat(string str, string initialValueAsString, float value, Expression expression) { }

	// RVA: 0x1694784
	public static bool TryConvertStringToLong(string str, Int64 value, Expression expr) { }

	// RVA: 0x1694814
	public static bool TryConvertStringToLong(string str, string initialValueAsString, Int64 value, Expression expression) { }

	// RVA: 0x1694A40
	public static bool TryConvertStringToULong(string str, UInt64 value, Expression expr) { }

	// RVA: 0x1694AD0
	public static bool TryConvertStringToULong(string str, string initialValueAsString, UInt64 value, Expression expression) { }

	// RVA: 0x1694CFC
	public static bool TryConvertStringToInt(string str, string initialValueAsString, int value, Expression expression) { }

	// RVA: 0x1694DA4
	public static bool TryConvertStringToUInt(string str, string initialValueAsString, UInt32 value, Expression expression) { }

	// RVA: 0x1694E4C
	private static void .cctor() { }

}

// Namespace: UnityEngine
internal sealed class NameFormatter
{
	// Methods

	// RVA: 0x1694F74
	public static string FormatVariableName(string name) { }

	// RVA: 0x16951E8
	private static void FormatVariableName_Injected(ManagedSpanWrapper name, ManagedSpanWrapper ret) { }

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

	// RVA: 0x1695250
	public void Add(object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) { }

	// RVA: 0x1695254
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

	// RVA: 0x1697518
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16975CC
	public virtual void Invoke(RectTransform driven) { }

}

// Namespace: UnityEngine
public sealed class RectTransform
{
	// Fields
	private static ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Methods

	// RVA: 0x1695258
	public static void add_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0x1695318
	public static void remove_reapplyDrivenProperties(ReapplyDrivenProperties value) { }

	// RVA: 0x16953D8
	public Rect get_rect() { }

	// RVA: 0x1695560
	public Vector2 get_anchorMin() { }

	// RVA: 0x1695658
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x169574C
	public Vector2 get_anchorMax() { }

	// RVA: 0x1695844
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x1695938
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x1695A30
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x1695B24
	public Vector2 get_sizeDelta() { }

	// RVA: 0x1695C1C
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x1695D10
	public Vector2 get_pivot() { }

	// RVA: 0x1695E08
	public void set_pivot(Vector2 value) { }

	// RVA: 0x1695EFC
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x16961AC
	public Vector2 get_offsetMin() { }

	// RVA: 0x1696310
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x16966D8
	public Vector2 get_offsetMax() { }

	// RVA: 0x169687C
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x1696C6C
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x1696DD0
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x1697074
	public void SetSizeWithCurrentAnchors(Axis axis, float size) { }

	// RVA: 0x1697488
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x169731C
	private Vector2 GetParentSize() { }

	// RVA: 0x1697508
	public void .ctor() { }

	// RVA: 0x16954F8
	private static void get_rect_Injected(IntPtr _unity_self, Rect ret) { }

	// RVA: 0x16955F0
	private static void get_anchorMin_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x16956E4
	private static void set_anchorMin_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x16957DC
	private static void get_anchorMax_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x16958D0
	private static void set_anchorMax_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x16959C8
	private static void get_anchoredPosition_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x1695ABC
	private static void set_anchoredPosition_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x1695BB4
	private static void get_sizeDelta_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x1695CA8
	private static void set_sizeDelta_Injected(IntPtr _unity_self, Vector2 value) { }

	// RVA: 0x1695DA0
	private static void get_pivot_Injected(IntPtr _unity_self, Vector2 ret) { }

	// RVA: 0x1695E94
	private static void set_pivot_Injected(IntPtr _unity_self, Vector2 value) { }

}

// Namespace: 
private class Enumerator
{
	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Methods

	// RVA: 0x169A7C0
	internal void .ctor(Transform outer) { }

	// RVA: 0x169A908
	public object get_Current() { }

	// RVA: 0x169A92C
	public bool MoveNext() { }

	// RVA: 0x169A9C8
	public void Reset() { }

}

// Namespace: UnityEngine
public class Transform
{
	// Methods

	// RVA: 0x1697510
	protected void .ctor() { }

	// RVA: 0x16975E0
	public Vector3 get_position() { }

	// RVA: 0x16976E0
	public void set_position(Vector3 value) { }

	// RVA: 0x1696084
	public Vector3 get_localPosition() { }

	// RVA: 0x169611C
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x16978A8
	public Vector3 get_eulerAngles() { }

	// RVA: 0x16979F8
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x1697B48
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x1697C88
	public Vector3 get_right() { }

	// RVA: 0x1697D7C
	public Vector3 get_up() { }

	// RVA: 0x1697E70
	public Vector3 get_forward() { }

	// RVA: 0x1697964
	public Quaternion get_rotation() { }

	// RVA: 0x1697FCC
	public void set_rotation(Quaternion value) { }

	// RVA: 0x1697AB4
	public Quaternion get_localRotation() { }

	// RVA: 0x1697BF8
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x1698194
	public Vector3 get_localScale() { }

	// RVA: 0x1698294
	public void set_localScale(Vector3 value) { }

	// RVA: 0x1697504
	public Transform get_parent() { }

	// RVA: 0x1698390
	public void set_parent(Transform value) { }

	// RVA: 0x169838C
	internal Transform get_parentInternal() { }

	// RVA: 0x1698448
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x1698450
	private Transform GetParent() { }

	// RVA: 0x16984EC
	public void SetParent(Transform p) { }

	// RVA: 0x1698544
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x1698658
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x1696FC4
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x16987D8
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x16988CC
	public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0x16989C0
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x1698C84
	public void Translate(float x, float y, float z) { }

	// RVA: 0x1698C8C
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x1699128
	public void Rotate(Vector3 eulers) { }

	// RVA: 0x1699130
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	// RVA: 0x1699138
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x1699238
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x16993C4
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x1698BE0
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x1699424
	public Vector3 TransformDirection(float x, float y, float z) { }

	// RVA: 0x16994C8
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x16995C4
	public Vector3 TransformVector(Vector3 vector) { }

	// RVA: 0x16996C0
	public Vector3 TransformVector(float x, float y, float z) { }

	// RVA: 0x1699764
	public Vector3 InverseTransformVector(Vector3 vector) { }

	// RVA: 0x1699860
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x169995C
	public Vector3 InverseTransformPoint(Vector3 position) { }

	// RVA: 0x1699A58
	public Transform get_root() { }

	// RVA: 0x1699A5C
	private Transform GetRoot() { }

	// RVA: 0x1699B48
	public int get_childCount() { }

	// RVA: 0x1699C20
	public void SetAsFirstSibling() { }

	// RVA: 0x1699CF8
	public void SetAsLastSibling() { }

	// RVA: 0x1699DD0
	public void SetSiblingIndex(int index) { }

	// RVA: 0x1699ED8
	public int GetSiblingIndex() { }

	// RVA: 0x1699FB0
	private Transform FindRelativeTransformWithPath(string path, bool isActiveOnly) { }

	// RVA: 0x169A228
	public Transform Find(string n) { }

	// RVA: 0x169A288
	public Vector3 get_lossyScale() { }

	// RVA: 0x169A388
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x169A564
	public bool get_hasChanged() { }

	// RVA: 0x169A63C
	public void set_hasChanged(bool value) { }

	// RVA: 0x169A744
	public IEnumerator GetEnumerator() { }

	// RVA: 0x169A7FC
	public Transform GetChild(int index) { }

	// RVA: 0x1697678
	private static void get_position_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1697770
	private static void set_position_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x16977D8
	private static void get_localPosition_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1697840
	private static void set_localPosition_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x1697F64
	private static void get_rotation_Injected(IntPtr _unity_self, Quaternion ret) { }

	// RVA: 0x169805C
	private static void set_rotation_Injected(IntPtr _unity_self, Quaternion value) { }

	// RVA: 0x16980C4
	private static void get_localRotation_Injected(IntPtr _unity_self, Quaternion ret) { }

	// RVA: 0x169812C
	private static void set_localRotation_Injected(IntPtr _unity_self, Quaternion value) { }

	// RVA: 0x169822C
	private static void get_localScale_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1698324
	private static void set_localScale_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x16984F4
	private static IntPtr GetParent_Injected(IntPtr _unity_self) { }

	// RVA: 0x1698600
	private static void SetParent_Injected(IntPtr _unity_self, IntPtr parent, bool worldPositionStays) { }

	// RVA: 0x1698708
	private static void get_worldToLocalMatrix_Injected(IntPtr _unity_self, Matrix4x4 ret) { }

	// RVA: 0x1698770
	private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, Matrix4x4 ret) { }

	// RVA: 0x1698874
	private static void SetPositionAndRotation_Injected(IntPtr _unity_self, Vector3 position, Quaternion rotation) { }

	// RVA: 0x1698968
	private static void SetLocalPositionAndRotation_Injected(IntPtr _unity_self, Vector3 localPosition, Quaternion localRotation) { }

	// RVA: 0x16991D8
	private static void RotateAroundInternal_Injected(IntPtr _unity_self, Vector3 axis, float angle) { }

	// RVA: 0x16993CC
	private static void TransformDirection_Injected(IntPtr _unity_self, Vector3 direction, Vector3 ret) { }

	// RVA: 0x169956C
	private static void InverseTransformDirection_Injected(IntPtr _unity_self, Vector3 direction, Vector3 ret) { }

	// RVA: 0x1699668
	private static void TransformVector_Injected(IntPtr _unity_self, Vector3 vector, Vector3 ret) { }

	// RVA: 0x1699808
	private static void InverseTransformVector_Injected(IntPtr _unity_self, Vector3 vector, Vector3 ret) { }

	// RVA: 0x1699904
	private static void TransformPoint_Injected(IntPtr _unity_self, Vector3 position, Vector3 ret) { }

	// RVA: 0x1699A00
	private static void InverseTransformPoint_Injected(IntPtr _unity_self, Vector3 position, Vector3 ret) { }

	// RVA: 0x1699AF8
	private static IntPtr GetRoot_Injected(IntPtr _unity_self) { }

	// RVA: 0x1699BD0
	private static int get_childCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1699CA8
	private static void SetAsFirstSibling_Injected(IntPtr _unity_self) { }

	// RVA: 0x1699D80
	private static void SetAsLastSibling_Injected(IntPtr _unity_self) { }

	// RVA: 0x1699E70
	private static void SetSiblingIndex_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x1699F60
	private static int GetSiblingIndex_Injected(IntPtr _unity_self) { }

	// RVA: 0x169A1D0
	private static IntPtr FindRelativeTransformWithPath_Injected(IntPtr _unity_self, ManagedSpanWrapper path, bool isActiveOnly) { }

	// RVA: 0x169A320
	private static void get_lossyScale_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x169A4FC
	private static bool IsChildOf_Injected(IntPtr _unity_self, IntPtr parent) { }

	// RVA: 0x169A5EC
	private static bool get_hasChanged_Injected(IntPtr _unity_self) { }

	// RVA: 0x169A6DC
	private static void set_hasChanged_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x169A8A0
	private static IntPtr GetChild_Injected(IntPtr _unity_self, int index) { }

}

// Namespace: UnityEngine._Scripting.APIUpdating
internal class APIUpdaterRuntimeHelpers
{
	// Methods

	// RVA: 0x169A9D4
	internal static bool GetMovedFromAttributeDataForType(Type sourceType, string assembly, string nsp, string klass) { }

	// RVA: 0x169AB48
	internal static bool GetObsoleteTypeRedirection(Type sourceType, string assemblyName, string nsp, string className) { }

}

// Namespace: UnityEngine.Profiling
public sealed class Profiler
{
	// Methods

	// RVA: 0x169AEAC
	public static void BeginSample(string name) { }

	// RVA: 0x169B0C8
	private static void ValidateArguments(string name) { }

	// RVA: 0x169AF38
	private static void BeginSampleImpl(string name, object targetObject) { }

	// RVA: 0x169B1B0
	public static void EndSample() { }

	// RVA: 0x169B1F0
	public static Int64 GetRuntimeMemorySizeLong(object o) { }

	// RVA: 0x169B2F0
	public static Int64 GetMonoHeapSizeLong() { }

	// RVA: 0x169B330
	public static Int64 GetMonoUsedSizeLong() { }

	// RVA: 0x169B370
	public static Int64 GetTotalAllocatedMemoryLong() { }

	// RVA: 0x169B3B0
	public static Int64 GetTotalUnusedReservedMemoryLong() { }

	// RVA: 0x169B3F0
	public static Int64 GetTotalReservedMemoryLong() { }

	// RVA: 0x169B148
	private static void BeginSampleImpl_Injected(ManagedSpanWrapper name, IntPtr targetObject) { }

	// RVA: 0x169B2A0
	private static Int64 GetRuntimeMemorySizeLong_Injected(IntPtr o) { }

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

	// RVA: 0x169B430
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

	// RVA: 0x169B66C
	public object get_unityObjectArgument() { }

	// RVA: 0x169B674
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x169B67C
	public int get_intArgument() { }

	// RVA: 0x169B684
	public float get_floatArgument() { }

	// RVA: 0x169B68C
	public string get_stringArgument() { }

	// RVA: 0x169B694
	public bool get_boolArgument() { }

	// RVA: 0x169B69C
	public void OnBeforeSerialize() { }

	// RVA: 0x169B6CC
	public void OnAfterDeserialize() { }

	// RVA: 0x169B6FC
	public void .ctor() { }

}

// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall
{
	// Methods

	// RVA: 0x169B704
	protected void .ctor() { }

	// RVA: 0x169B70C
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1
	public abstract void Invoke(object[] args) { }

	// RVA: 0x352BD5C
	protected static void ThrowOnInvalidArg(object arg) { }

	// RVA: 0x169B818
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

	// RVA: 0x169B8D8
	private void add_Delegate(UnityAction value) { }

	// RVA: 0x169B97C
	private void remove_Delegate(UnityAction value) { }

	// RVA: 0x169BA20
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x169BB6C
	public void .ctor(UnityAction action) { }

	// RVA: 0x169BC18
	public override void Invoke(object[] args) { }

	// RVA: 0x169BCFC
	public void Invoke() { }

	// RVA: 0x169BDE0
	public override bool Find(object targetObj, MethodInfo method) { }

}

// Namespace: UnityEngine.Events
internal class InvokableCall<T0>
{
	// Fields
	private UnityEngine.Events.UnityAction<T1> Delegate; // 0x0

	// Methods

	// RVA: 0x35267E8
	protected void add_Delegate(UnityEngine.Events.UnityAction<T1> value) { }

	// RVA: 0x35267E8
	protected void remove_Delegate(UnityEngine.Events.UnityAction<T1> value) { }

	// RVA: 0x35269D4
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x35267E8
	public void .ctor(UnityEngine.Events.UnityAction<T1> action) { }

	// RVA: 0x35267E8
	public override void Invoke(object[] args) { }

	// RVA: 0x26AD93C
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

	// RVA: 0x35269D4
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x35267E8
	public override void Invoke(object[] args) { }

	// RVA: 0x26AD93C
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

	// RVA: 0x35269D4
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x35267E8
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

	// RVA: 0x35269D4
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x35267E8
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

	// RVA: 0x26AD93C
	public void .ctor(object target, MethodInfo theFunction, T argument) { }

	// RVA: 0x35267E8
	public override void Invoke(object[] args) { }

	// RVA: 0x26AD93C
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

	// RVA: 0x169BE3C
	public object get_target() { }

	// RVA: 0x169BE44
	public string get_targetAssemblyTypeName() { }

	// RVA: 0x169BF34
	public string get_methodName() { }

	// RVA: 0x169BF3C
	public PersistentListenerMode get_mode() { }

	// RVA: 0x169BF44
	public ArgumentCache get_arguments() { }

	// RVA: 0x169BF4C
	public bool IsValid() { }

	// RVA: 0x169BF98
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x169C4D4
	private static BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x169C9B4
	public void OnBeforeSerialize() { }

	// RVA: 0x169C9E4
	public void OnAfterDeserialize() { }

	// RVA: 0x169CA14
	public void .ctor() { }

}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCallGroup
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls; // 0x10

	// Methods

	// RVA: 0x169CA98
	public void .ctor() { }

	// RVA: 0x169CB24
	public int get_Count() { }

	// RVA: 0x169CB70
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

	// RVA: 0x169CDE4
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x169CE54
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x169CEC4
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x169D178
	public void Clear() { }

	// RVA: 0x169D274
	public void ClearPersistent() { }

	// RVA: 0x169D370
	public System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x169D458
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

	// RVA: 0x169D534
	protected void .ctor() { }

	// RVA: 0x169D650
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x169D6B8
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: -1
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x169C2B0
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x169D6EC
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x169DB8C
	public int GetPersistentEventCount() { }

	// RVA: 0x169D684
	private void DirtyPersistentCalls() { }

	// RVA: 0x169DBDC
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x169DC1C
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x169DC90
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x169DCAC
	public void RemoveAllListeners() { }

	// RVA: 0x169DCC8
	internal System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x169DD10
	public override string ToString() { }

	// RVA: 0x169D9D4
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction
{
	// Methods

	// RVA: 0x169DD98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x169DE38
	public virtual void Invoke() { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	// RVA: 0x169DE4C
	public void .ctor() { }

	// RVA: 0x169DE78
	public void AddListener(UnityAction call) { }

	// RVA: 0x169DFE4
	public void RemoveListener(UnityAction call) { }

	// RVA: 0x169E028
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x169E090
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x169DEF8
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x169E0FC
	public void Invoke() { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T0 arg0) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
	public void AddListener(UnityEngine.Events.UnityAction<T0> call) { }

	// RVA: 0x35267E8
	public void RemoveListener(UnityEngine.Events.UnityAction<T0> call) { }

	// RVA: 0x3525998
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x3525998
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x35293EC
	private static BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action) { }

	// RVA: 0x26AD93C
	public void Invoke(T0 arg0) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T0 arg0, T1 arg1) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x3525998
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x3525998
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x26AD93C
	public void Invoke(T0 arg0, T1 arg1) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x3525998
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x3525998
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2, T3>
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x3525998
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x3525998
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

// Namespace: UnityEngine.Serialization
public class FormerlySerializedAsAttribute
{
	// Fields
	private string m_oldName; // 0x10

	// Methods

	// RVA: 0x169E2EC
	public void .ctor(string oldName) { }

}

// Namespace: UnityEngine.Bindings
internal struct Unmarshal
{
	// Methods

	// RVA: 0x26AD93C
	public static T UnmarshalUnityObject(IntPtr gcHandlePtr) { }

	// RVA: 0x169E320
	public static GCHandle FromIntPtrUnsafe(IntPtr gcHandle) { }

}

// Namespace: UnityEngine.Bindings
internal static class ThrowHelper
{
	// Methods

	// RVA: 0x169A468
	public static void ThrowArgumentNullException(object obj, string parameterName) { }

	// RVA: 0x169546C
	public static void ThrowNullReferenceException(object obj) { }

}

// Namespace: 
private struct NativeOwnedMemory
{
	// Fields
	public Void* data; // 0x10
}

// Namespace: UnityEngine.Bindings
internal static class BindingsAllocator
{
	// Methods

	// RVA: 0x169E360
	public static void Free(Void* ptr) { }

	// RVA: 0x169E3B0
	public static void FreeNativeOwnedMemory(Void* ptr) { }

	// RVA: 0x169E400
	public static Void* GetNativeOwnedDataPointer(Void* ptr) { }

}

// Namespace: 
internal enum UpdateFlags
{
	// Fields
	public int value__; // 0x10
	public const UpdateFlags NoUpdateNeeded = 0;
	public const UpdateFlags SizeChanged = 1;
	public const UpdateFlags DataIsNativePointer = 2;
	public const UpdateFlags DataIsNativeOwnedMemory = 3;
	public const UpdateFlags DataIsEmpty = 4;
	public const UpdateFlags DataIsNull = 5;
}

// Namespace: UnityEngine.Bindings
internal struct BlittableArrayWrapper
{
	// Fields
	internal Void* data; // 0x10
	internal int size; // 0x18
	internal UpdateFlags updateFlags; // 0x1C

	// Methods

	// RVA: 0x169E41C
	public void .ctor(Void* data, int size) { }

	// RVA: 0x35267E8
	internal void Unmarshal(T[] array) { }

}

// Namespace: UnityEngine.Bindings
internal struct BlittableListWrapper
{
	// Fields
	private BlittableArrayWrapper arrayWrapper; // 0x10
	private int listSize; // 0x20

	// Methods

	// RVA: 0x169E428
	public void .ctor(BlittableArrayWrapper arrayWrapper, int listSize) { }

	// RVA: 0x35267E8
	internal void Unmarshal(System.Collections.Generic.List<T> list) { }

}

// Namespace: UnityEngine.Bindings
internal static class ExceptionMarshaller
{
	// Fields
	private static Exception s_pendingException; // 0xFFFFFFFF

	// Methods

	// RVA: 0x169E434
	private static void SetPendingException(Exception ex) { }

}

// Namespace: UnityEngine.Bindings
internal struct ManagedSpanWrapper
{
	// Fields
	public readonly Void* begin; // 0x10
	public readonly int length; // 0x18

	// Methods

	// RVA: 0x16951DC
	public void .ctor(Void* begin, int length) { }

}

// Namespace: UnityEngine.Bindings
internal static class StringMarshaller
{
	// Methods

	// RVA: 0x169E498
	public static bool TryMarshalEmptyOrNullString(string s, ManagedSpanWrapper managedSpanWrapper) { }

}

// Namespace: UnityEngine.Bindings
internal struct OutStringMarshaller
{
	// Methods

	// RVA: 0x169E50C
	public static string GetStringAndDispose(ManagedSpanWrapper managedSpan) { }

}

// Namespace: UnityEngine.Scripting
public class AlwaysLinkAssemblyAttribute
{
	// Methods

	// RVA: 0x169E5C0
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
public static class GarbageCollector
{
	// Methods

	// RVA: 0x169E5C8
	public static bool get_isIncremental() { }

	// RVA: 0x169E608
	public static UInt64 get_incrementalTimeSliceNanoseconds() { }

	// RVA: 0x169E648
	public static bool CollectIncremental(UInt64 nanoseconds) { }

}

// Namespace: UnityEngine.Scripting
public class PreserveAttribute
{
	// Methods

	// RVA: 0x169E698
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
public class RequiredMemberAttribute
{
	// Methods

	// RVA: 0x169E6A0
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
public class RequireImplementorsAttribute
{
	// Methods

	// RVA: 0x169E6A8
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

	// RVA: 0x169E6B0
	public void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

}

// Namespace: UnityEngine.Scripting.APIUpdating
public class MovedFromAttribute
{
	// Fields
	internal MovedFromAttributeData data; // 0x10

	// Methods

	// RVA: 0x169E74C
	public void .ctor(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName) { }

	// RVA: 0x169E7FC
	public void .ctor(string sourceNamespace) { }

}

// Namespace: UnityEngine.SceneManagement
[Serializable]
public struct Scene
{
	// Fields
	private int m_Handle; // 0x10

	// Methods

	// RVA: 0x169E89C
	private static bool IsValidInternal(int sceneHandle) { }

	// RVA: 0x169E8EC
	private static string GetPathInternal(int sceneHandle) { }

	// RVA: 0x169EAAC
	private static string GetNameInternal(int sceneHandle) { }

	// RVA: 0x169EC6C
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	// RVA: 0x169ECBC
	private static int GetBuildIndexInternal(int sceneHandle) { }

	// RVA: 0x169ED0C
	private static int GetRootCountInternal(int sceneHandle) { }

	// RVA: 0x169ED5C
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	// RVA: 0x169EDC4
	public int get_handle() { }

	// RVA: 0x169EDCC
	public bool IsValid() { }

	// RVA: 0x169EE1C
	public string get_path() { }

	// RVA: 0x169EE24
	public string get_name() { }

	// RVA: 0x169EE2C
	public bool get_isLoaded() { }

	// RVA: 0x169EE7C
	public int get_buildIndex() { }

	// RVA: 0x169EECC
	public int get_rootCount() { }

	// RVA: 0x169EF1C
	public GameObject[] GetRootGameObjects() { }

	// RVA: 0x169EFFC
	public void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects) { }

	// RVA: 0x169F300
	public static bool op_Equality(Scene lhs, Scene rhs) { }

	// RVA: 0x169F30C
	public override int GetHashCode() { }

	// RVA: 0x169F314
	public override bool Equals(object other) { }

	// RVA: 0x169EA44
	private static void GetPathInternal_Injected(int sceneHandle, ManagedSpanWrapper ret) { }

	// RVA: 0x169EC04
	private static void GetNameInternal_Injected(int sceneHandle, ManagedSpanWrapper ret) { }

}

// Namespace: UnityEngine.SceneManagement
internal static class SceneManagerAPIInternal
{
	// Methods

	// RVA: 0x169F3A4
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x169F634
	public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

	// RVA: 0x169F5CC
	private static IntPtr LoadSceneAsyncNameIndexInternal_Injected(ManagedSpanWrapper sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x169F86C
	private static IntPtr UnloadSceneNameIndexInternal_Injected(ManagedSpanWrapper sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

}

// Namespace: UnityEngine.SceneManagement
public class SceneManagerAPI
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Methods

	// RVA: 0x169F8DC
	internal static SceneManagerAPI get_ActiveAPI() { }

	// RVA: 0x169F9DC
	public static SceneManagerAPI get_overrideAPI() { }

	// RVA: 0x169FA58
	protected internal void .ctor() { }

	// RVA: 0x169FA60
	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x169FA74
	protected internal virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

	// RVA: 0x169FA8C
	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x169FA94
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

	// RVA: 0x169FB00
	public static int get_sceneCount() { }

	// RVA: 0x169FB40
	public static Scene GetActiveScene() { }

	// RVA: 0x169FC38
	public static bool SetActiveScene(Scene scene) { }

	// RVA: 0x169FD3C
	public static Scene GetSceneByName(string name) { }

	// RVA: 0x169FF44
	public static Scene GetSceneAt(int index) { }

	// RVA: 0x16A0064
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x16A015C
	private static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, bool outSuccess) { }

	// RVA: 0x16A026C
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	// RVA: 0x16A02F4
	public static void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }

	// RVA: 0x16A0408
	public static void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode> value) { }

	// RVA: 0x16A051C
	public static void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x16A0630
	public static void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x16A0744
	public static void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x16A0858
	public static void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.Scene> value) { }

	// RVA: 0x16A096C
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode) { }

	// RVA: 0x16A0A3C
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	// RVA: 0x16A0AAC
	public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options) { }

	// RVA: 0x16A0B30
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x16A0C10
	private static void Internal_SceneUnloaded(Scene scene) { }

	// RVA: 0x16A0CE8
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x16A0DC8
	private static void .cctor() { }

	// RVA: 0x169FBE8
	private static void GetActiveScene_Injected(Scene ret) { }

	// RVA: 0x169FCEC
	private static bool SetActiveScene_Injected(Scene scene) { }

	// RVA: 0x169FEDC
	private static void GetSceneByName_Injected(ManagedSpanWrapper name, Scene ret) { }

	// RVA: 0x169FFFC
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

	// RVA: 0x16A0A34
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

	// RVA: 0x16A0E3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16A0EDC
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

	// RVA: 0x16A0E18
	public override string ToString() { }

}

// Namespace: UnityEngine.LowLevel
public class PlayerLoop
{
	// Methods

	// RVA: 0x16A0EF0
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	// RVA: 0x16A1214
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	// RVA: 0x16A1314
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal>& internalSys) { }

	// RVA: 0x16A0FA0
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, int offset) { }

	// RVA: 0x16A0F60
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	// RVA: 0x16A14A0
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

// Namespace: 
public struct InputForUIUpdate
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
public struct AccessibilityUpdate
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
internal struct UIElementsRepaintPanels
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
internal struct UIElementsRenderBatchModeOffscreen
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

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal TCollection <.cctor>b__5_0() { }

	// RVA: 0x26AD93C
	internal void <.cctor>b__5_1(TCollection l) { }

}

// Namespace: UnityEngine.Pool
public class CollectionPool<T0, T1>
{
	// Fields
	internal static readonly UnityEngine.Pool.ObjectPool<TCollection> s_Pool; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public static TCollection Get() { }

	// RVA: 0x26AD93C
	public static UnityEngine.Pool.PooledObject<TCollection> Get(TCollection value) { }

	// RVA: 0x26AD93C
	public static void Release(TCollection toRelease) { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Pool.GenericPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal T <.cctor>b__5_0() { }

}

// Namespace: UnityEngine.Pool
public class GenericPool<T0>
{
	// Fields
	internal static readonly UnityEngine.Pool.ObjectPool<T> s_Pool; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public static T Get() { }

	// RVA: 0x26AD93C
	public static void Release(T toRelease) { }

	// RVA: 0x352AE04
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
internal interface IPool
{}

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
	private T m_FreshlyReleased; // 0x0
	private int <CountAll>k__BackingField; // 0x0

	// Methods

	// RVA: 0x35254D0
	public int get_CountAll() { }

	// RVA: 0x3526518
	private void set_CountAll(int value) { }

	// RVA: 0x35254D0
	public int get_CountInactive() { }

	// RVA: 0x26AD93C
	public void .ctor(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, bool collectionCheck, int defaultCapacity, int maxSize) { }

	// RVA: 0x26AD93C
	public T Get() { }

	// RVA: 0x26AD93C
	public UnityEngine.Pool.PooledObject<T> Get(T v) { }

	// RVA: 0x26AD93C
	public void Release(T element) { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x35263A0
	public void Dispose() { }

}

// Namespace: UnityEngine.Pool
public struct PooledObject<T0>
{
	// Fields
	private readonly T m_ToReturn; // 0x0
	private readonly UnityEngine.Pool.IObjectPool<T> m_Pool; // 0x0

	// Methods

	// RVA: 0x26AD93C
	public void .ctor(T value, UnityEngine.Pool.IObjectPool<T> pool) { }

	// RVA: 0x35263A0
	private void System.IDisposable.Dispose() { }

}

// Namespace: UnityEngine.Pool
internal static class PoolManager
{
	// Fields
	private static readonly System.Collections.Generic.List<System.WeakReference<UnityEngine.Pool.IPool>> s_WeakPoolReferences; // 0x0

	// Methods

	// RVA: 0x16A14F0
	public static void Register(IPool pool) { }

	// RVA: 0x16A15C0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class MessageEventArgs
{
	// Fields
	public int playerId; // 0x10
	public Byte[] data; // 0x18

	// Methods

	// RVA: 0x16A165C
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

	// RVA: 0x16A1D88
	public void .ctor() { }

	// RVA: 0x16A3780
	internal bool <Register>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x16A21C4
	public void .ctor() { }

	// RVA: 0x16A3800
	internal bool <Unregister>b__0(MessageTypeSubscribers x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x16A2CF8
	public void .ctor() { }

	// RVA: 0x16A3850
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

	// RVA: 0x16A1664
	public static PlayerConnection get_instance() { }

	// RVA: 0x16A17DC
	public bool get_isConnected() { }

	// RVA: 0x16A1738
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x16A19B0
	public void OnEnable() { }

	// RVA: 0x16A1914
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x16A1AE8
	public void Register(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x16A1FC4
	public void Unregister(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x16A231C
	public void RegisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x16A25AC
	public void RegisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x16A2618
	public void UnregisterConnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x16A2684
	public void UnregisterDisconnection(UnityEngine.Events.UnityAction<System.Int32> callback) { }

	// RVA: 0x16A26F0
	public void Send(Guid messageId, Byte[] data) { }

	// RVA: 0x16A28AC
	public bool TrySend(Guid messageId, Byte[] data) { }

	// RVA: 0x16A2A68
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x16A2D00
	public void DisconnectAll() { }

	// RVA: 0x16A2E38
	private static void MessageCallbackInternal(IntPtr data, UInt64 size, UInt64 guid, string messageId) { }

	// RVA: 0x16A318C
	private static void ConnectedCallbackInternal(int playerId) { }

	// RVA: 0x16A3384
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x16A357C
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class MessageEvent
{
	// Methods

	// RVA: 0x16A3CCC
	public void .ctor() { }

}

// Namespace: 
[Serializable]
public class ConnectionChangeEvent
{
	// Methods

	// RVA: 0x16A3D20
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

	// RVA: 0x16A37D0
	public Guid get_MessageTypeId() { }

	// RVA: 0x16A3C88
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x16A3BE0
	public void .ctor() { }

}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
internal class PlayerEditorConnectionEvents
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> m_MessageTypeSubscribers; // 0x10
	private System.Collections.Generic.Dictionary<System.Guid,UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> m_SubscriberLookup; // 0x18
	public ConnectionChangeEvent connectionEvent; // 0x20
	public ConnectionChangeEvent disconnectionEvent; // 0x28

	// Methods

	// RVA: 0x16A385C
	public System.Collections.Generic.IReadOnlyList<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> get_messageTypeSubscribers() { }

	// RVA: 0x16A3864
	private void BuildLookup() { }

	// RVA: 0x16A3000
	public void InvokeMessageIdSubscribers(Guid messageId, Byte[] data, int playerId) { }

	// RVA: 0x16A1D90
	public UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x16A21CC
	public void UnregisterManagedCallback(Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback) { }

	// RVA: 0x16A3644
	public void .ctor() { }

}

// Namespace: UnityEngine.iOS
public sealed class Device
{
	// Methods

	// RVA: 0x16A3D74
	public static bool RequestStoreReview() { }

	// RVA: 0x16A3DB4
	public static string get_systemVersion() { }

	// RVA: 0x16A3F08
	public static string get_vendorIdentifier() { }

	// RVA: 0x16A405C
	public static bool get_lowPowerModeEnabled() { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16A44EC
	public static OnDemandResourcesRequest ConvertToManaged(IntPtr ptr) { }

	// RVA: 0x16A4554
	public static IntPtr ConvertToNative(OnDemandResourcesRequest request) { }

}

// Namespace: UnityEngine.iOS
public sealed class OnDemandResourcesRequest
{
	// Methods

	// RVA: 0x16A40DC
	public string get_error() { }

	// RVA: 0x16A42D4
	private static void DestroyFromScript(IntPtr ptr) { }

	// RVA: 0x16A4324
	public void Dispose() { }

	// RVA: 0x16A43D4
	private void .ctor(IntPtr ptr) { }

	// RVA: 0x16A43DC
	protected override void Finalize() { }

	// RVA: 0x16A426C
	private static void get_error_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

}

// Namespace: UnityEngine.iOS
public static class OnDemandResources
{
	// Methods

	// RVA: 0x16A4570
	public static bool get_enabled() { }

	// RVA: 0x16A45B0
	private static OnDemandResourcesRequest PreloadAsyncImpl(string[] tags) { }

	// RVA: 0x16A46BC
	public static OnDemandResourcesRequest PreloadAsync(string[] tags) { }

	// RVA: 0x16A466C
	private static IntPtr PreloadAsyncImpl_Injected(string[] tags) { }

}

// Namespace: UnityEngine.Internal
[Serializable]
public class DefaultValueAttribute
{
	// Fields
	private object DefaultValue; // 0x10

	// Methods

	// RVA: 0x16A4778
	public void .ctor(string value) { }

	// RVA: 0x16A47AC
	public object get_Value() { }

	// RVA: 0x16A47B4
	public override bool Equals(object obj) { }

	// RVA: 0x16A4874
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Internal
[Serializable]
public class ExcludeFromDocsAttribute
{
	// Methods

	// RVA: 0x16A4898
	public void .ctor() { }

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

	// RVA: 0x16A48A0
	public static Playable get_Null() { }

	// RVA: 0x16A491C
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x16A4924
	public PlayableHandle GetHandle() { }

	// RVA: 0x16A4930
	public bool Equals(Playable other) { }

	// RVA: 0x16A4ABC
	private static void .cctor() { }

}

// Namespace: UnityEngine.Playables
[Serializable]
public abstract class PlayableAsset
{
	// Methods

	// RVA: -1
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x16A4C14
	public virtual Double get_duration() { }

	// RVA: 0x16A4C90
	public virtual System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs() { }

	// RVA: 0x16A4D0C
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	// RVA: 0x16A4E64
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x16A4E98
	protected void .ctor() { }

}

// Namespace: UnityEngine.Playables
[Serializable]
public abstract class PlayableBehaviour
{
	// Methods

	// RVA: 0x16A4EA0
	public void .ctor() { }

	// RVA: 0x16A4EA8
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x16A4EAC
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x16A4EB0
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x16A4EB4
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x16A4EB8
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x16A4EBC
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x16A4EC0
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x16A4EC4
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x16A4EC8
	public virtual object Clone() { }

}

// Namespace: 
internal sealed class CreateOutputMethod
{
	// Methods

	// RVA: 0x16A4F64
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16A5008
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

	// RVA: 0x16A4ED0
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

	// RVA: 0x35251DC
	internal bool IsPlayableOfType() { }

	// RVA: 0x16A4B98
	public static PlayableHandle get_Null() { }

	// RVA: 0x16A4A40
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x16A502C
	public override bool Equals(object p) { }

	// RVA: 0x16A513C
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x16A51B8
	public override int GetHashCode() { }

	// RVA: 0x16A501C
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	// RVA: 0x16A51F0
	internal bool IsValid() { }

	// RVA: 0x16A5240
	internal Type GetPlayableType() { }

	// RVA: 0x16A5290
	private static void .cctor() { }

}

// Namespace: UnityEngine.Playables
public struct PlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Methods

	// RVA: 0x16A52DC
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x16A52E4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x16A52F0
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x16A547C
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

	// RVA: 0x16A5558
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x16A55D4
	public override int GetHashCode() { }

	// RVA: 0x16A5400
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x16A561C
	public override bool Equals(object p) { }

	// RVA: 0x16A572C
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x16A560C
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x16A57A8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Playables
public struct ScriptPlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
}

// Namespace: UnityEngine.Assertions
public static class Assert
{
	// Fields
	public static bool raiseExceptions; // 0x0

	// Methods

	// RVA: 0x16A57F4
	private static void Fail(string message, string userMessage) { }

	// RVA: 0x16A59D0
	public static void IsTrue(bool condition) { }

	// RVA: 0x16A5AB4
	public static void IsTrue(bool condition, string message) { }

	// RVA: 0x16A5C00
	public static void IsFalse(bool condition) { }

	// RVA: 0x16A5CE4
	public static void IsFalse(bool condition, string message) { }

	// RVA: 0x26AD93C
	public static void AreEqual(T expected, T actual) { }

	// RVA: 0x26AD93C
	public static void AreEqual(T expected, T actual, string message) { }

	// RVA: 0x26AD93C
	public static void AreEqual(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer) { }

	// RVA: 0x16A5D88
	public static void AreEqual(object expected, object actual, string message) { }

	// RVA: 0x26AD93C
	public static void IsNull(T value) { }

	// RVA: 0x26AD93C
	public static void IsNull(T value, string message) { }

	// RVA: 0x16A60A8
	public static void IsNull(object value, string message) { }

	// RVA: 0x26AD93C
	public static void IsNotNull(T value) { }

	// RVA: 0x26AD93C
	public static void IsNotNull(T value, string message) { }

	// RVA: 0x16A631C
	public static void IsNotNull(object value, string message) { }

	// RVA: 0x16A6410
	public static void AreEqual(int expected, int actual) { }

	// RVA: 0x16A64C8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Assertions
public class AssertionException
{
	// Fields
	private string m_UserMessage; // 0x90

	// Methods

	// RVA: 0x16A5948
	public void .ctor(string message, string userMessage) { }

	// RVA: 0x16A6518
	public override string get_Message() { }

}

// Namespace: UnityEngine.Assertions
internal class AssertionMessageUtil
{
	// Methods

	// RVA: 0x16A658C
	public static string GetMessage(string failureMessage) { }

	// RVA: 0x16A6698
	public static string GetMessage(string failureMessage, string expected) { }

	// RVA: 0x16A5E7C
	public static string GetEqualityMessage(object actual, object expected, bool expectEqual) { }

	// RVA: 0x16A619C
	public static string NullFailureMessage(object value, bool expectNull) { }

	// RVA: 0x16A5B58
	public static string BooleanFailureMessage(bool expected) { }

}

// Namespace: UnityEngine.Apple
internal static class Device
{
	// Methods

	// RVA: 0x16A3DB8
	internal static string get_systemVersion() { }

	// RVA: 0x16A3F0C
	internal static string get_vendorIdentifier() { }

	// RVA: 0x16A409C
	internal static bool get_lowPowerModeEnabled() { }

	// RVA: 0x16A6820
	private static void get_systemVersion_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x16A6870
	private static void get_vendorIdentifier_Injected(ManagedSpanWrapper ret) { }

}

// Namespace: UnityEngine.Analytics
public enum SendEventOptions
{
	// Fields
	public int value__; // 0x10
	public const SendEventOptions kAppendNone = 0;
	public const SendEventOptions kAppendBuildGuid = 1;
	public const SendEventOptions kAppendBuildTarget = 2;
}

// Namespace: UnityEngine.Analytics
public class AnalyticsEventBase
{
	// Fields
	private string eventName; // 0x10
	private int eventVersion; // 0x18
	private string eventPrefix; // 0x20
	private SendEventOptions sendEventOptions; // 0x28

	// Methods

	// RVA: 0x16A68C0
	public void .ctor(string eventName, int eventVersion, SendEventOptions sendEventOptions, string eventPrefix) { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
internal class BatchRenderGroupUsageAnalytic
{
	// Fields
	public int maxBRGInstance; // 0x2C
	public int maxMeshCount; // 0x30
	public int maxMaterialCount; // 0x34
	public int maxDrawCommandBatch; // 0x38

	// Methods

	// RVA: 0x16A6928
	public void .ctor() { }

	// RVA: 0x16A69C4
	public static BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic() { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
internal class UaaLApplicationLaunchAnalytic
{
	// Fields
	public int launch_type; // 0x2C
	public int launch_process_type; // 0x30

	// Methods

	// RVA: 0x16A6A98
	public void .ctor() { }

	// RVA: 0x16A6B34
	public static UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic() { }

}

// Namespace: UnityEngine.Analytics
[Serializable]
internal class ShaderRuntimeInfoAnalytic
{
	// Fields
	public Int64 VariantsRequested; // 0x30
	public Int64 VariantsRequestedMissing; // 0x38
	public Int64 VariantsRequestedUnsupported; // 0x40
	public Int64 VariantsRequestedCompiled; // 0x48
	public Int64 VariantsRequestedViaWarmup; // 0x50
	public Int64 VariantsUnused; // 0x58
	public int VariantsCompilationTimeTotal; // 0x60
	public int VariantsCompilationTimeMax; // 0x64
	public int VariantsCompilationTimeMedian; // 0x68
	public int VariantsWarmupTimeTotal; // 0x6C
	public int VariantsWarmupTimeMax; // 0x70
	public int VariantsWarmupTimeMedian; // 0x74
	public bool UseProgressiveWarmup; // 0x78
	public int ShaderChunkSizeMin; // 0x7C
	public int ShaderChunkSizeMax; // 0x80
	public int ShaderChunkSizeAvg; // 0x84
	public int ShaderChunkCountMin; // 0x88
	public int ShaderChunkCountMax; // 0x8C
	public int ShaderChunkCountAvg; // 0x90

	// Methods

	// RVA: 0x16A6C08
	private void .ctor() { }

	// RVA: 0x16A6CC0
	public static ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic() { }

}

// Namespace: UnityEngine.Rendering
public struct AsyncGPUReadbackRequest
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal int m_Version; // 0x18

	// Methods

	// RVA: 0x16A6DB0
	private static void InvokeCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, AsyncGPUReadbackRequest obj) { }

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
public enum CullMode
{
	// Fields
	public int value__; // 0x10
	public const CullMode Off = 0;
	public const CullMode Front = 1;
	public const CullMode Back = 2;
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

	// RVA: 0x16A6DEC
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
	public const GraphicsDeviceType WebGPU = 28;
	public const GraphicsDeviceType Switch2 = 29;
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

	// RVA: 0x16A6DF8
	public void .ctor(int indexStart, int indexCount, MeshTopology topology) { }

	// RVA: 0x16A6E10
	public Bounds get_bounds() { }

	// RVA: 0x16A6E24
	public void set_bounds(Bounds value) { }

	// RVA: 0x16A6E38
	public MeshTopology get_topology() { }

	// RVA: 0x16A6E40
	public void set_topology(MeshTopology value) { }

	// RVA: 0x16A6E48
	public int get_indexStart() { }

	// RVA: 0x16A6E50
	public void set_indexStart(int value) { }

	// RVA: 0x16A6E58
	public int get_indexCount() { }

	// RVA: 0x16A6E60
	public void set_indexCount(int value) { }

	// RVA: 0x16A6E68
	public int get_baseVertex() { }

	// RVA: 0x16A6E70
	public void set_baseVertex(int value) { }

	// RVA: 0x16A6E78
	public int get_firstVertex() { }

	// RVA: 0x16A6E80
	public void set_firstVertex(int value) { }

	// RVA: 0x16A6E88
	public int get_vertexCount() { }

	// RVA: 0x16A6E90
	public void set_vertexCount(int value) { }

	// RVA: 0x16A6E98
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

	// RVA: 0x16A7180
	public VertexAttribute get_attribute() { }

	// RVA: 0x16A7188
	public void set_attribute(VertexAttribute value) { }

	// RVA: 0x16A7190
	public VertexAttributeFormat get_format() { }

	// RVA: 0x16A7198
	public void set_format(VertexAttributeFormat value) { }

	// RVA: 0x16A71A0
	public int get_dimension() { }

	// RVA: 0x16A71A8
	public void set_dimension(int value) { }

	// RVA: 0x16A71B0
	public int get_stream() { }

	// RVA: 0x16A71B8
	public void set_stream(int value) { }

	// RVA: 0x16A71C0
	public void .ctor(VertexAttribute attribute, VertexAttributeFormat format, int dimension, int stream) { }

	// RVA: 0x16A71CC
	public override string ToString() { }

	// RVA: 0x16A73C8
	public override int GetHashCode() { }

	// RVA: 0x16A73EC
	public override bool Equals(object other) { }

	// RVA: 0x16A74AC
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

	// RVA: 0x16A74F0
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x16A7510
	public void .ctor(int nameID) { }

	// RVA: 0x16A7530
	public void .ctor(Texture tex) { }

	// RVA: 0x16A76AC
	public void .ctor(RenderBuffer buf, int mipLevel, CubemapFace cubeFace, int depthSlice) { }

	// RVA: 0x16A76CC
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x16A76EC
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x16A770C
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x16A7758
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x16A777C
	public override string ToString() { }

	// RVA: 0x16A7A64
	public override int GetHashCode() { }

	// RVA: 0x16A7ABC
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x16A7B38
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
internal enum DefaultMaterialType
{
	// Fields
	public int value__; // 0x10
	public const DefaultMaterialType Default = 0;
	public const DefaultMaterialType Particle = 1;
	public const DefaultMaterialType Line = 2;
	public const DefaultMaterialType Terrain = 3;
	public const DefaultMaterialType Sprite = 4;
	public const DefaultMaterialType SpriteMask = 5;
	public const DefaultMaterialType UGUI = 6;
	public const DefaultMaterialType UGUI_Overdraw = 7;
	public const DefaultMaterialType UGUI_ETC1Supported = 8;
}

// Namespace: UnityEngine.Rendering
internal enum DefaultShaderType
{
	// Fields
	public int value__; // 0x10
	public const DefaultShaderType Default = 0;
	public const DefaultShaderType AutodeskInteractive = 1;
	public const DefaultShaderType AutodeskInteractiveTransparent = 2;
	public const DefaultShaderType AutodeskInteractiveMasked = 3;
	public const DefaultShaderType TerrainDetailLit = 4;
	public const DefaultShaderType TerrainDetailGrass = 5;
	public const DefaultShaderType TerrainDetailGrassBillboard = 6;
	public const DefaultShaderType SpeedTree7 = 7;
	public const DefaultShaderType SpeedTree8 = 8;
	public const DefaultShaderType SpeedTree9 = 9;
}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Rendering.GraphicsSettings.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16A8DC4
	private static void .cctor() { }

	// RVA: 0x16A8E30
	public void .ctor() { }

	// RVA: 0x16A8E38
	internal RenderPipelineGlobalSettings <.cctor>b__93_0() { }

}

// Namespace: UnityEngine.Rendering
public sealed class GraphicsSettings
{
	// Fields
	private static System.Lazy<UnityEngine.Rendering.RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings; // 0x0

	// Methods

	// RVA: 0x16A7C28
	public static bool get_lightsUseLinearIntensity() { }

	// RVA: 0x16A7C68
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	// RVA: 0x16A7D64
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	// RVA: 0x16A7EC8
	public static RenderPipelineAsset get_renderPipelineAsset() { }

	// RVA: 0x16A8094
	public static void set_renderPipelineAsset(RenderPipelineAsset value) { }

	// RVA: 0x16A8244
	private static ScriptableObject get_INTERNAL_defaultRenderPipeline() { }

	// RVA: 0x16A8340
	private static void set_INTERNAL_defaultRenderPipeline(ScriptableObject value) { }

	// RVA: 0x16A7F30
	public static RenderPipelineAsset get_defaultRenderPipeline() { }

	// RVA: 0x16A8114
	public static void set_defaultRenderPipeline(RenderPipelineAsset value) { }

	// RVA: 0x16A8478
	internal static Shader GetDefaultShader(DefaultShaderType type) { }

	// RVA: 0x16A86B8
	internal static Material GetDefaultMaterial(DefaultMaterialType type) { }

	// RVA: 0x16A88E4
	private static object Internal_GetSettingsForRenderPipeline(string renderpipelineName) { }

	// RVA: 0x16A8B5C
	private static RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings() { }

	// RVA: 0x16A8CA8
	private static void .cctor() { }

	// RVA: 0x16A7D24
	private static IntPtr get_INTERNAL_currentRenderPipeline_Injected() { }

	// RVA: 0x16A8300
	private static IntPtr get_INTERNAL_defaultRenderPipeline_Injected() { }

	// RVA: 0x16A8428
	private static void set_INTERNAL_defaultRenderPipeline_Injected(IntPtr value) { }

	// RVA: 0x16A8B0C
	private static IntPtr Internal_GetSettingsForRenderPipeline_Injected(ManagedSpanWrapper renderpipelineName) { }

}

// Namespace: UnityEngine.Rendering
public interface IRenderPipelineGraphicsSettings
{}

// Namespace: UnityEngine.Rendering
public class OnDemandRendering
{
	// Fields
	private static int m_RenderFrameInterval; // 0x0

	// Methods

	// RVA: 0x16A8EA0
	public static int get_renderFrameInterval() { }

	// RVA: 0x16A8F1C
	internal static void GetRenderFrameInterval(int frameInterval) { }

	// RVA: 0x16A8FE0
	private static void .cctor() { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x16AC944
	public static IntPtr ConvertToNative(CommandBuffer commandBuffer) { }

}

// Namespace: UnityEngine.Rendering
public class CommandBuffer
{
	// Fields
	public static bool ThrowOnSetRenderTarget; // 0x0
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x16A9030
	public void SetInvertCulling(bool invertCulling) { }

	// RVA: 0x16A9110
	private static IntPtr InitBuffer() { }

	// RVA: 0x16A9150
	private void ReleaseBuffer() { }

	// RVA: 0x16A9200
	public void set_name(string value) { }

	// RVA: 0x16A93E8
	public void Clear() { }

	// RVA: 0x16A9498
	private void Internal_DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x16A9654
	private void Internal_DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x16A97D8
	private void Internal_DrawRendererList(RendererList rendererList) { }

	// RVA: 0x16A98B8
	private void CopyTexture_Internal(RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	// RVA: 0x16A9A2C
	private void Blit_Texture(Texture source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x16A9BF4
	private void Blit_Identifier(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x16A9D90
	private void GetTemporaryRT(int nameID, int width, int height, FilterMode filter, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale, ShadowSamplingMode shadowSamplingMode) { }

	// RVA: 0x16A9F14
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale) { }

	// RVA: 0x16AA05C
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode) { }

	// RVA: 0x16AA07C
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite) { }

	// RVA: 0x16AA0B0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	// RVA: 0x16AA0E0
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x16AA110
	public void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, FilterMode filter, RenderTextureFormat format) { }

	// RVA: 0x16AA144
	private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x16AA224
	public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x16AA2B4
	public void ReleaseTemporaryRT(int nameID) { }

	// RVA: 0x16AA394
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor) { }

	// RVA: 0x16AA4A8
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	// RVA: 0x16AA3A0
	public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth, UInt32 stencil) { }

	// RVA: 0x16AA5A8
	public void SetGlobalFloat(int nameID, float value) { }

	// RVA: 0x16AA678
	public void SetGlobalVector(int nameID, Vector4 value) { }

	// RVA: 0x16AA748
	public void SetGlobalColor(int nameID, Color value) { }

	// RVA: 0x16AA818
	public void EnableShaderKeyword(string keyword) { }

	// RVA: 0x16AAA00
	private void EnableGlobalKeyword(GlobalKeyword keyword) { }

	// RVA: 0x16AAACC
	public void EnableKeyword(GlobalKeyword keyword) { }

	// RVA: 0x16AAB34
	public void DisableShaderKeyword(string keyword) { }

	// RVA: 0x16AAD1C
	private void DisableGlobalKeyword(GlobalKeyword keyword) { }

	// RVA: 0x16AADE8
	public void DisableKeyword(GlobalKeyword keyword) { }

	// RVA: 0x16AAE50
	public void SetViewMatrix(Matrix4x4 view) { }

	// RVA: 0x16AAF30
	public void SetProjectionMatrix(Matrix4x4 proj) { }

	// RVA: 0x16AB010
	public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj) { }

	// RVA: 0x16AA4B0
	private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	// RVA: 0x16AB128
	private void SetGlobalTexture_Impl(int nameID, RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	// RVA: 0x16AB208
	private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x16AB2E8
	private static void CheckThrowOnSetRenderTarget() { }

	// RVA: 0x16AB380
	public void SetRenderTarget(RenderTargetIdentifier rt) { }

	// RVA: 0x16AB4E0
	public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth) { }

	// RVA: 0x16AB67C
	public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x16AA518
	private void ClearRenderTargetSingle_Internal(RTClearFlags clearFlags, Color color, float depth, UInt32 stencil) { }

	// RVA: 0x16AB450
	private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x16AB5D4
	private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

	// RVA: 0x16AB978
	protected override void Finalize() { }

	// RVA: 0x16ABAC4
	public void Dispose() { }

	// RVA: 0x16ABA5C
	private void Dispose(bool disposing) { }

	// RVA: 0x16ABB9C
	public void .ctor() { }

	// RVA: 0x16ABBF8
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties) { }

	// RVA: 0x16ABEA8
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x16ABEDC
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex) { }

	// RVA: 0x16ABF14
	public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material) { }

	// RVA: 0x16ABF50
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass) { }

	// RVA: 0x16AC1A0
	public void DrawRenderer(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x16AC1A8
	public void DrawRenderer(Renderer renderer, Material material) { }

	// RVA: 0x16AC1B4
	public void DrawRendererList(RendererList rendererList) { }

	// RVA: 0x16AC224
	public void CopyTexture(RenderTargetIdentifier src, RenderTargetIdentifier dst) { }

	// RVA: 0x16AC2C0
	public void Blit(Texture source, RenderTargetIdentifier dest, Vector2 scale, Vector2 offset) { }

	// RVA: 0x16AC390
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x16AC444
	public void Blit(Texture source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x16AC504
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest) { }

	// RVA: 0x16AC5B4
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat) { }

	// RVA: 0x16AC668
	public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass) { }

	// RVA: 0x16AC728
	public void SetGlobalVector(string name, Vector4 value) { }

	// RVA: 0x16AC7D4
	public void SetGlobalTexture(int nameID, RenderTargetIdentifier value) { }

	// RVA: 0x16AC840
	public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x16A90A8
	private static void SetInvertCulling_Injected(IntPtr _unity_self, bool invertCulling) { }

	// RVA: 0x16A91B0
	private static void ReleaseBuffer_Injected(IntPtr _unity_self) { }

	// RVA: 0x16A9380
	private static void set_name_Injected(IntPtr _unity_self, ManagedSpanWrapper value) { }

	// RVA: 0x16A9448
	private static void Clear_Injected(IntPtr _unity_self) { }

	// RVA: 0x16A95CC
	private static void Internal_DrawMesh_Injected(IntPtr _unity_self, IntPtr mesh, Matrix4x4 matrix, IntPtr material, int submeshIndex, int shaderPass, IntPtr properties) { }

	// RVA: 0x16A9768
	private static void Internal_DrawRenderer_Injected(IntPtr _unity_self, IntPtr renderer, IntPtr material, int submeshIndex, int shaderPass) { }

	// RVA: 0x16A9850
	private static void Internal_DrawRendererList_Injected(IntPtr _unity_self, RendererList rendererList) { }

	// RVA: 0x16A9978
	private static void CopyTexture_Internal_Injected(IntPtr _unity_self, RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode) { }

	// RVA: 0x16A9B54
	private static void Blit_Texture_Injected(IntPtr _unity_self, IntPtr source, RenderTargetIdentifier dest, IntPtr mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x16A9CF0
	private static void Blit_Identifier_Injected(IntPtr _unity_self, RenderTargetIdentifier source, RenderTargetIdentifier dest, IntPtr mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice) { }

	// RVA: 0x16A9E58
	private static void GetTemporaryRT_Injected(IntPtr _unity_self, int nameID, int width, int height, FilterMode filter, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, RenderTextureMemoryless memorylessMode, bool useDynamicScale, ShadowSamplingMode shadowSamplingMode) { }

	// RVA: 0x16AA1BC
	private static void GetTemporaryRTWithDescriptor_Injected(IntPtr _unity_self, int nameID, RenderTextureDescriptor desc, FilterMode filter) { }

	// RVA: 0x16AA32C
	private static void ReleaseTemporaryRT_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x16AA618
	private static void SetGlobalFloat_Injected(IntPtr _unity_self, int nameID, float value) { }

	// RVA: 0x16AA6F0
	private static void SetGlobalVector_Injected(IntPtr _unity_self, int nameID, Vector4 value) { }

	// RVA: 0x16AA7C0
	private static void SetGlobalColor_Injected(IntPtr _unity_self, int nameID, Color value) { }

	// RVA: 0x16AA998
	private static void EnableShaderKeyword_Injected(IntPtr _unity_self, ManagedSpanWrapper keyword) { }

	// RVA: 0x16AAA64
	private static void EnableGlobalKeyword_Injected(IntPtr _unity_self, GlobalKeyword keyword) { }

	// RVA: 0x16AACB4
	private static void DisableShaderKeyword_Injected(IntPtr _unity_self, ManagedSpanWrapper keyword) { }

	// RVA: 0x16AAD80
	private static void DisableGlobalKeyword_Injected(IntPtr _unity_self, GlobalKeyword keyword) { }

	// RVA: 0x16AAEC8
	private static void SetViewMatrix_Injected(IntPtr _unity_self, Matrix4x4 view) { }

	// RVA: 0x16AAFA8
	private static void SetProjectionMatrix_Injected(IntPtr _unity_self, Matrix4x4 proj) { }

	// RVA: 0x16AB078
	private static void SetViewProjectionMatrices_Injected(IntPtr _unity_self, Matrix4x4 view, Matrix4x4 proj) { }

	// RVA: 0x16AB0D0
	private static bool ValidateAgainstExecutionFlags_Injected(IntPtr _unity_self, CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags) { }

	// RVA: 0x16AB1A0
	private static void SetGlobalTexture_Impl_Injected(IntPtr _unity_self, int nameID, RenderTargetIdentifier rt, RenderTextureSubElement element) { }

	// RVA: 0x16AB280
	private static void IssuePluginEventAndDataInternal_Injected(IntPtr _unity_self, IntPtr callback, int eventID, IntPtr data) { }

	// RVA: 0x16AB7E8
	private static void ClearRenderTargetSingle_Internal_Injected(IntPtr _unity_self, RTClearFlags clearFlags, Color color, float depth, UInt32 stencil) { }

	// RVA: 0x16AB860
	private static void SetRenderTargetSingle_Internal_Injected(IntPtr _unity_self, RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	// RVA: 0x16AB8E0
	private static void SetRenderTargetColorDepth_Internal_Injected(IntPtr _unity_self, RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags) { }

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

	// RVA: 0x16AC960
	public float get_Item(int rgb, int coefficient) { }

	// RVA: 0x16ACB80
	public void set_Item(int rgb, int coefficient, float value) { }

	// RVA: 0x16ACDA0
	public override int GetHashCode() { }

	// RVA: 0x16ACF80
	public override bool Equals(object other) { }

	// RVA: 0x16AD038
	public bool Equals(SphericalHarmonicsL2 other) { }

	// RVA: 0x16AD0FC
	public static bool op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

}

// Namespace: UnityEngine.Rendering
public struct BatchID
{
	// Fields
	public static readonly BatchID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x16AD2B8
	public override int GetHashCode() { }

	// RVA: 0x16AD2C0
	public override bool Equals(object obj) { }

	// RVA: 0x16AD390
	public bool Equals(BatchID other) { }

	// RVA: 0x16AD3A0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct BatchMaterialID
{
	// Fields
	public static readonly BatchMaterialID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x16AD3EC
	public override int GetHashCode() { }

	// RVA: 0x16AD3F4
	public override bool Equals(object obj) { }

	// RVA: 0x16AD4C4
	public bool Equals(BatchMaterialID other) { }

	// RVA: 0x16AD4D4
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct BatchMeshID
{
	// Fields
	public static readonly BatchMeshID Null; // 0x0
	public UInt32 value; // 0x10

	// Methods

	// RVA: 0x16AD520
	public override int GetHashCode() { }

	// RVA: 0x16AD528
	public override bool Equals(object obj) { }

	// RVA: 0x16AD5F8
	public bool Equals(BatchMeshID other) { }

	// RVA: 0x16AD608
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public enum BatchDrawCommandType
{
	// Fields
	public int value__; // 0x10
	public const BatchDrawCommandType Direct = 0;
	public const BatchDrawCommandType Indirect = 1;
	public const BatchDrawCommandType Procedural = 2;
	public const BatchDrawCommandType ProceduralIndirect = 3;
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
	public const BatchDrawCommandFlags LODCrossFadeKeyword = 16;
	public const BatchDrawCommandFlags LODCrossFadeValuePacked = 32;
	public const BatchDrawCommandFlags LODCrossFade = 48;
	public const BatchDrawCommandFlags UseLegacyLightmapsKeyword = 64;
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
	public const BatchCullingViewType Filtering = 5;
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

	// RVA: 0x16AD654
	public override int GetHashCode() { }

	// RVA: 0x16AD65C
	public bool Equals(BatchPackedCullingViewID other) { }

	// RVA: 0x16AD66C
	public override bool Equals(object obj) { }

}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommand
{
	// Fields
	public BatchDrawCommandFlags flags; // 0x10
	public BatchID batchID; // 0x14
	public BatchMaterialID materialID; // 0x18
	public UInt16 splitVisibilityMask; // 0x1C
	public UInt16 lightmapIndex; // 0x1E
	public int sortingPosition; // 0x20
	public UInt32 visibleOffset; // 0x24
	public UInt32 visibleCount; // 0x28
	public BatchMeshID meshID; // 0x2C
	public UInt16 submeshIndex; // 0x30
	private UInt16 unusedPadding2; // 0x32
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommandIndirect
{
	// Fields
	public BatchDrawCommandFlags flags; // 0x10
	public BatchID batchID; // 0x14
	public BatchMaterialID materialID; // 0x18
	public UInt16 splitVisibilityMask; // 0x1C
	public UInt16 lightmapIndex; // 0x1E
	public int sortingPosition; // 0x20
	public UInt32 visibleOffset; // 0x24
	public BatchMeshID meshID; // 0x28
	public MeshTopology topology; // 0x2C
	public GraphicsBufferHandle visibleInstancesBufferHandle; // 0x30
	public UInt32 visibleInstancesBufferWindowOffset; // 0x34
	public UInt32 visibleInstancesBufferWindowSizeBytes; // 0x38
	public GraphicsBufferHandle indirectArgsBufferHandle; // 0x3C
	public UInt32 indirectArgsBufferOffset; // 0x40
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommandProcedural
{
	// Fields
	public BatchDrawCommandFlags flags; // 0x10
	public BatchID batchID; // 0x14
	public BatchMaterialID materialID; // 0x18
	public UInt16 splitVisibilityMask; // 0x1C
	public UInt16 lightmapIndex; // 0x1E
	public int sortingPosition; // 0x20
	public UInt32 visibleOffset; // 0x24
	public UInt32 visibleCount; // 0x28
	public MeshTopology topology; // 0x2C
	public GraphicsBufferHandle indexBufferHandle; // 0x30
	public UInt32 baseVertex; // 0x34
	public UInt32 indexOffsetBytes; // 0x38
	public UInt32 elementCount; // 0x3C
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommandProceduralIndirect
{
	// Fields
	public BatchDrawCommandFlags flags; // 0x10
	public BatchID batchID; // 0x14
	public BatchMaterialID materialID; // 0x18
	public UInt16 splitVisibilityMask; // 0x1C
	public UInt16 lightmapIndex; // 0x1E
	public int sortingPosition; // 0x20
	public UInt32 visibleOffset; // 0x24
	public MeshTopology topology; // 0x28
	public GraphicsBufferHandle indexBufferHandle; // 0x2C
	public GraphicsBufferHandle visibleInstancesBufferHandle; // 0x30
	public UInt32 visibleInstancesBufferWindowOffset; // 0x34
	public UInt32 visibleInstancesBufferWindowSizeBytes; // 0x38
	public GraphicsBufferHandle indirectArgsBufferHandle; // 0x3C
	public UInt32 indirectArgsBufferOffset; // 0x40
}

// Namespace: UnityEngine.Rendering
public struct BatchFilterSettings
{
	// Fields
	public UInt32 renderingLayerMask; // 0x10
	public int rendererPriority; // 0x14
	private UInt64 m_sceneCullingMask; // 0x18
	public Byte layer; // 0x20
	private Byte m_batchLayer; // 0x21
	private Byte m_motionMode; // 0x22
	private Byte m_shadowMode; // 0x23
	private Byte m_receiveShadows; // 0x24
	private Byte m_staticShadowCaster; // 0x25
	private Byte m_allDepthSorted; // 0x26
	private Byte m_isSceneCullingMaskSet; // 0x27
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawRange
{
	// Fields
	public BatchDrawCommandType drawCommandsType; // 0x10
	public UInt32 drawCommandsBegin; // 0x14
	public UInt32 drawCommandsCount; // 0x18
	public BatchFilterSettings filterSettings; // 0x20
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutputDrawCommands
{
	// Fields
	public BatchDrawCommand* drawCommands; // 0x10
	public BatchDrawCommandIndirect* indirectDrawCommands; // 0x18
	public BatchDrawCommandProcedural* proceduralDrawCommands; // 0x20
	public BatchDrawCommandProceduralIndirect* proceduralIndirectDrawCommands; // 0x28
	public Int32* visibleInstances; // 0x30
	public BatchDrawRange* drawRanges; // 0x38
	public Single* instanceSortingPositions; // 0x40
	public Int32* drawCommandPickingInstanceIDs; // 0x48
	public int drawCommandCount; // 0x50
	public int indirectDrawCommandCount; // 0x54
	public int proceduralDrawCommandCount; // 0x58
	public int proceduralIndirectDrawCommandCount; // 0x5C
	public int visibleInstanceCount; // 0x60
	public int drawRangeCount; // 0x64
	public int instanceSortingPositionFloatCount; // 0x68
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
	public readonly UInt16 splitExclusionMask; // 0xB0
	public readonly Byte isOrthographic; // 0xB2
	public readonly int receiverPlaneOffset; // 0xB4
	public readonly int receiverPlaneCount; // 0xB8
	internal readonly IntPtr occlusionBuffer; // 0xC0

	// Methods

	// RVA: 0x16AD6FC
	internal void .ctor(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, UInt64 inViewID, UInt32 inCullingLayerMask, UInt64 inSceneCullingMask, Byte inExclusionSplitMask, int inReceiverPlaneOffset, int inReceiverPlaneCount, IntPtr inOcclusionBuffer) { }

}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutput
{
	// Fields
	public Unity.Collections.NativeArray<UnityEngine.Rendering.BatchCullingOutputDrawCommands> drawCommands; // 0x10
	public Unity.Collections.NativeArray<System.IntPtr> customCullingResult; // 0x20
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
	public Byte splitExclusionMask; // 0x9C
	public UInt64 sceneCullingMask; // 0xA0
	public BatchCullingOutputDrawCommands* drawCommands; // 0xA8
	public UInt32 brgId; // 0xB0
	public IntPtr occlusionBuffer; // 0xB8
	public IntPtr customCullingResult; // 0xC0
}

// Namespace: 
public sealed class OnPerformCulling
{
	// Methods

	// RVA: 0x16ADAB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16ADBD4
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }

}

// Namespace: 
public sealed class OnFinishedCulling
{
	// Methods

	// RVA: 0x16ADC48
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16ADCEC
	public virtual void Invoke(IntPtr customCullingResult) { }

}

// Namespace: UnityEngine.Rendering
public class BatchRendererGroup
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private OnPerformCulling m_PerformCulling; // 0x18
	private OnFinishedCulling m_FinishedCulling; // 0x20

	// Methods

	// RVA: 0x16AD778
	private static void InvokeOnPerformCulling(BatchRendererGroup group, BatchRendererCullingOutput context, LODParameters lodParameters, IntPtr userContext) { }

	// RVA: 0x16AD9D0
	private static void InvokeOnFinishedCulling(BatchRendererGroup group, IntPtr customCullingResult) { }

}

// Namespace: UnityEngine.Rendering
internal sealed class GPUDrivenLODGroupDataCallback
{
	// Methods

	// RVA: 0x16ADD00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16ADDB4
	public virtual void Invoke(GPUDrivenLODGroupData lodGroupData) { }

}

// Namespace: UnityEngine.Rendering
internal sealed class GPUDrivenLODGroupDataNativeCallback
{
	// Methods

	// RVA: 0x16ADDC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16ADE84
	public virtual void Invoke(GPUDrivenLODGroupDataNative lodGroupDataNative, GPUDrivenLODGroupDataCallback callback) { }

}

// Namespace: UnityEngine.Rendering
internal sealed class GPUDrivenRendererDataCallback
{
	// Methods

	// RVA: 0x16ADE98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16ADF54
	public virtual void Invoke(GPUDrivenRendererGroupData rendererData, System.Collections.Generic.IList<UnityEngine.Mesh> meshes, System.Collections.Generic.IList<UnityEngine.Material> materials) { }

}

// Namespace: UnityEngine.Rendering
internal sealed class GPUDrivenRendererDataNativeCallback
{
	// Methods

	// RVA: 0x16ADF68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16AE024
	public virtual void Invoke(GPUDrivenRendererGroupDataNative rendererDataNative, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, GPUDrivenRendererDataCallback callback) { }

}

// Namespace: UnityEngine.Rendering
internal static class GPUDrivenCallbacks
{
	// Methods

	// RVA: 0x16AE038
	public static void InvokeGPUDrivenLODGroupDataNativeCallback(GPUDrivenLODGroupDataNativeCallback callback, GPUDrivenLODGroupDataNative lodGroupDataNative, GPUDrivenLODGroupDataCallback target) { }

	// RVA: 0x16AE060
	public static void InvokeGPUDrivenRendererDataNativeCallback(GPUDrivenRendererDataNativeCallback callback, GPUDrivenRendererGroupDataNative rendererDataNative, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, GPUDrivenRendererDataCallback target) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Rendering.GPUDrivenProcessor.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16AE2C0
	private static void .cctor() { }

	// RVA: 0x16AE32C
	public void .ctor() { }

	// RVA: 0x16AE334
	internal void <.cctor>b__34_0(GPUDrivenRendererGroupDataNative nativeData, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, GPUDrivenRendererDataCallback callback) { }

	// RVA: 0x16AE958
	internal void <.cctor>b__34_1(GPUDrivenLODGroupDataNative nativeData, GPUDrivenLODGroupDataCallback callback) { }

}

// Namespace: UnityEngine.Rendering
internal class GPUDrivenProcessor
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static GPUDrivenRendererDataNativeCallback s_NativeRendererCallback; // 0x0
	private static GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback; // 0x8

	// Methods

	// RVA: 0x16AE088
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
internal struct GPUDrivenRendererEditorData
{
	// Fields
	public UInt64 sceneCullingMask; // 0x10
}

// Namespace: UnityEngine.Rendering
internal struct GPUDrivenRendererGroupDataNative
{
	// Fields
	public Int32* rendererGroupID; // 0x10
	public Bounds* localBounds; // 0x18
	public Vector4* lightmapScaleOffset; // 0x20
	public Int32* gameObjectLayer; // 0x28
	public UInt32* renderingLayerMask; // 0x30
	public Int32* lodGroupID; // 0x38
	public MotionVectorGenerationMode* motionVecGenMode; // 0x40
	public GPUDrivenPackedRendererData* packedRendererData; // 0x48
	public Int32* rendererPriority; // 0x50
	public Int32* meshIndex; // 0x58
	public Int16* subMeshStartIndex; // 0x60
	public Int32* materialsOffset; // 0x68
	public Int16* materialsCount; // 0x70
	public Int32* instancesOffset; // 0x78
	public Int32* instancesCount; // 0x80
	public GPUDrivenRendererEditorData* editorData; // 0x88
	public int rendererGroupCount; // 0x90
	public Int32* invalidRendererGroupID; // 0x98
	public int invalidRendererGroupIDCount; // 0xA0
	public Matrix4x4* localToWorldMatrix; // 0xA8
	public Matrix4x4* prevLocalToWorldMatrix; // 0xB0
	public Int32* rendererGroupIndex; // 0xB8
	public int instanceCount; // 0xC0
	public Int32* meshID; // 0xC8
	public Int16* subMeshCount; // 0xD0
	public Int32* subMeshDescOffset; // 0xD8
	public int meshCount; // 0xE0
	public SubMeshDescriptor* subMeshDesc; // 0xE8
	public int subMeshDescCount; // 0xF0
	public Int32* materialIndex; // 0xF8
	public int materialIndexCount; // 0x100
	public Int32* materialID; // 0x108
	public GPUDrivenPackedMaterialData* packedMaterialData; // 0x110
	public Int32* materialFilterFlags; // 0x118
	public int materialCount; // 0x120
}

// Namespace: UnityEngine.Rendering
internal struct GPUDrivenLODGroupDataNative
{
	// Fields
	public Int32* lodGroupID; // 0x10
	public Int32* lodOffset; // 0x18
	public Int32* lodCount; // 0x20
	public LODFadeMode* fadeMode; // 0x28
	public Vector3* worldSpaceReferencePoint; // 0x30
	public Single* worldSpaceSize; // 0x38
	public Int16* renderersCount; // 0x40
	public Boolean* lastLODIsBillboard; // 0x48
	public Byte* forceLODMask; // 0x50
	public int lodGroupCount; // 0x58
	public Int32* invalidLODGroupID; // 0x60
	public int invalidLODGroupCount; // 0x68
	public Int16* lodRenderersCount; // 0x70
	public Single* lodScreenRelativeTransitionHeight; // 0x78
	public Single* lodFadeTransitionWidth; // 0x80
	public int lodDataCount; // 0x88
}

// Namespace: UnityEngine.Rendering
internal struct GPUDrivenPackedRendererData
{
	// Fields
	private UInt32 data; // 0x10

	// Methods

	// RVA: 0x16AEC00
	public void .ctor() { }

}

// Namespace: UnityEngine.Rendering
internal struct GPUDrivenPackedMaterialData
{
	// Fields
	private UInt32 data; // 0x10

	// Methods

	// RVA: 0x16AEC08
	public void .ctor() { }

}

// Namespace: UnityEngine.Rendering
internal struct GPUDrivenRendererGroupData
{
	// Fields
	public Unity.Collections.NativeArray<System.Int32> rendererGroupID; // 0x10
	public Unity.Collections.NativeArray<UnityEngine.Bounds> localBounds; // 0x20
	public Unity.Collections.NativeArray<UnityEngine.Vector4> lightmapScaleOffset; // 0x30
	public Unity.Collections.NativeArray<System.Int32> gameObjectLayer; // 0x40
	public Unity.Collections.NativeArray<System.UInt32> renderingLayerMask; // 0x50
	public Unity.Collections.NativeArray<System.Int32> lodGroupID; // 0x60
	public Unity.Collections.NativeArray<System.Int32> lightmapIndex; // 0x70
	public Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedRendererData> packedRendererData; // 0x80
	public Unity.Collections.NativeArray<System.Int32> rendererPriority; // 0x90
	public Unity.Collections.NativeArray<System.Int32> meshIndex; // 0xA0
	public Unity.Collections.NativeArray<System.Int16> subMeshStartIndex; // 0xB0
	public Unity.Collections.NativeArray<System.Int32> materialsOffset; // 0xC0
	public Unity.Collections.NativeArray<System.Int16> materialsCount; // 0xD0
	public Unity.Collections.NativeArray<System.Int32> instancesOffset; // 0xE0
	public Unity.Collections.NativeArray<System.Int32> instancesCount; // 0xF0
	public Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenRendererEditorData> editorData; // 0x100
	public Unity.Collections.NativeArray<System.Int32> invalidRendererGroupID; // 0x110
	public Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrix; // 0x120
	public Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrix; // 0x130
	public Unity.Collections.NativeArray<System.Int32> rendererGroupIndex; // 0x140
	public Unity.Collections.NativeArray<System.Int32> meshID; // 0x150
	public Unity.Collections.NativeArray<System.Int16> subMeshCount; // 0x160
	public Unity.Collections.NativeArray<System.Int32> subMeshDescOffset; // 0x170
	public Unity.Collections.NativeArray<UnityEngine.Rendering.SubMeshDescriptor> subMeshDesc; // 0x180
	public Unity.Collections.NativeArray<System.Int32> materialIndex; // 0x190
	public Unity.Collections.NativeArray<System.Int32> materialID; // 0x1A0
	public Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialData; // 0x1B0
	public Unity.Collections.NativeArray<System.Int32> materialFilterFlags; // 0x1C0
}

// Namespace: UnityEngine.Rendering
internal struct GPUDrivenLODGroupData
{
	// Fields
	public Unity.Collections.NativeArray<System.Int32> lodGroupID; // 0x10
	public Unity.Collections.NativeArray<System.Int32> lodOffset; // 0x20
	public Unity.Collections.NativeArray<System.Int32> lodCount; // 0x30
	public Unity.Collections.NativeArray<UnityEngine.LODFadeMode> fadeMode; // 0x40
	public Unity.Collections.NativeArray<UnityEngine.Vector3> worldSpaceReferencePoint; // 0x50
	public Unity.Collections.NativeArray<System.Single> worldSpaceSize; // 0x60
	public Unity.Collections.NativeArray<System.Int16> renderersCount; // 0x70
	public Unity.Collections.NativeArray<System.Boolean> lastLODIsBillboard; // 0x80
	public Unity.Collections.NativeArray<System.Byte> forceLODMask; // 0x90
	public Unity.Collections.NativeArray<System.Int32> invalidLODGroupID; // 0xA0
	public Unity.Collections.NativeArray<System.Int16> lodRenderersCount; // 0xB0
	public Unity.Collections.NativeArray<System.Single> lodScreenRelativeTransitionHeight; // 0xC0
	public Unity.Collections.NativeArray<System.Single> lodFadeTransitionWidth; // 0xD0
}

// Namespace: UnityEngine.Rendering
public struct BlendState
{
	// Fields
	private RenderTargetBlendState m_BlendState0; // 0x10
	private RenderTargetBlendState m_BlendState1; // 0x18
	private RenderTargetBlendState m_BlendState2; // 0x20
	private RenderTargetBlendState m_BlendState3; // 0x28
	private RenderTargetBlendState m_BlendState4; // 0x30
	private RenderTargetBlendState m_BlendState5; // 0x38
	private RenderTargetBlendState m_BlendState6; // 0x40
	private RenderTargetBlendState m_BlendState7; // 0x48
	private Byte m_SeparateMRTBlendStates; // 0x50
	private Byte m_AlphaToMask; // 0x51
	private Int16 m_Padding; // 0x52

	// Methods

	// RVA: 0x16AEC10
	public bool Equals(BlendState other) { }

	// RVA: 0x16AECFC
	public override bool Equals(object obj) { }

	// RVA: 0x16AEDAC
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
internal struct CoreCameraValues
{
	// Fields
	private int filterMode; // 0x10
	private UInt32 cullingMask; // 0x14
	private int instanceID; // 0x18

	// Methods

	// RVA: 0x16AEE94
	public bool Equals(CoreCameraValues other) { }

	// RVA: 0x16AEEC8
	public override bool Equals(object obj) { }

	// RVA: 0x16AEF78
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
	internal bool useInteractiveLightBakingData; // 0x3F0

	// Methods

	// RVA: 0x16AEF98
	public Plane GetShadowCullingPlane(int index) { }

	// RVA: 0x16AF080
	public Plane GetCameraCullingPlane(int index) { }

	// RVA: 0x16AF168
	public bool Equals(CameraProperties other) { }

	// RVA: 0x16AFFA8
	public override bool Equals(object obj) { }

	// RVA: 0x16B0080
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
	private LODParameters m_LODParameters; // 0x10
	public static readonly int maximumCullingPlaneCount; // 0x0
	internal UnityEngine.Rendering.ScriptableCullingParameters.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x2C
	private int m_CullingPlaneCount; // 0xCC
	private UInt32 m_CullingMask; // 0xD0
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
	private float m_AccurateOcclusionThreshold; // 0x5AC
	private int m_MaximumPortalCullingJobs; // 0x5B0
	private Matrix4x4 m_StereoViewMatrix; // 0x5B4
	private Matrix4x4 m_StereoProjectionMatrix; // 0x5F4
	private float m_StereoSeparationDistance; // 0x634
	private int m_maximumVisibleLights; // 0x638
	private bool m_ConservativeEnclosingSphere; // 0x63C
	private int m_NumIterationsEnclosingSphere; // 0x640

	// Methods

	// RVA: 0x16B08E4
	public int get_cullingPlaneCount() { }

	// RVA: 0x16B08EC
	public void set_cullingMask(UInt32 value) { }

	// RVA: 0x16B08F4
	public void set_cullingOptions(CullingOptions value) { }

	// RVA: 0x16B08FC
	public float GetLayerCullingDistance(int layerIndex) { }

	// RVA: 0x16B09D8
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x16B0B10
	public bool Equals(ScriptableCullingParameters other) { }

	// RVA: 0x16B0F08
	public override bool Equals(object obj) { }

	// RVA: 0x16B1020
	public override int GetHashCode() { }

	// RVA: 0x16B1274
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct LightShadowCasterCullingInfo
{
	// Fields
	public RangeInt splitRange; // 0x10
	public BatchCullingProjectionType projectionType; // 0x18
	public UInt16 splitExclusionMask; // 0x1C
}

// Namespace: UnityEngine.Rendering
public struct CullingResults
{
	// Fields
	internal IntPtr ptr; // 0x10
	private CullingAllocationInfo* m_AllocationInfo; // 0x18

	// Methods

	// RVA: 0x16B12C8
	public bool Equals(CullingResults other) { }

	// RVA: 0x16B1328
	public override bool Equals(object obj) { }

	// RVA: 0x16B1408
	public override int GetHashCode() { }

	// RVA: 0x16B143C
	public static bool op_Equality(CullingResults left, CullingResults right) { }

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

// Namespace: UnityEngine.Rendering
public struct DepthState
{
	// Fields
	private Byte m_WriteEnabled; // 0x10
	private SByte m_CompareFunction; // 0x11

	// Methods

	// RVA: 0x16B1498
	public bool Equals(DepthState other) { }

	// RVA: 0x16B14C0
	public override bool Equals(object obj) { }

	// RVA: 0x16B1560
	public override int GetHashCode() { }

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

	// RVA: 0x16B15A0
	public void .ctor(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	// RVA: 0x16B1678
	public ShaderTagId GetShaderPassName(int index) { }

	// RVA: 0x16B17DC
	public bool Equals(DrawingSettings other) { }

	// RVA: 0x16B1AB4
	public override bool Equals(object obj) { }

	// RVA: 0x16B1BFC
	public override int GetHashCode() { }

	// RVA: 0x16B1DCC
	public static bool op_Equality(DrawingSettings left, DrawingSettings right) { }

	// RVA: 0x16B1EE4
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
	private UInt32 m_BatchLayerMask; // 0x20
	private int m_ExcludeMotionVectorObjects; // 0x24
	private int m_ForceAllMotionVectorObjects; // 0x28
	private SortingLayerRange m_SortingLayerRange; // 0x2C

	// Methods

	// RVA: 0x16B1F34
	public static FilteringSettings get_defaultValue() { }

	// RVA: 0x16B1FF8
	public void .ctor(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, int layerMask, UInt32 renderingLayerMask, int excludeMotionVectorObjects) { }

	// RVA: 0x16B219C
	public bool Equals(FilteringSettings other) { }

	// RVA: 0x16B22C8
	public override bool Equals(object obj) { }

	// RVA: 0x16B2410
	public override int GetHashCode() { }

	// RVA: 0x16B24C4
	public static bool op_Equality(FilteringSettings left, FilteringSettings right) { }

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
public class InvalidImportException
{}

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

	// RVA: 0x16B25C4
	public bool Equals(LODParameters other) { }

	// RVA: 0x16B266C
	public override bool Equals(object obj) { }

	// RVA: 0x16B278C
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public class ObjectIdRequest
{
	// Fields
	private RenderTexture <destination>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16B282C
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
public struct RasterState
{
	// Fields
	public static readonly RasterState defaultValue; // 0x0
	private CullMode m_CullingMode; // 0x10
	private int m_OffsetUnits; // 0x14
	private float m_OffsetFactor; // 0x18
	private Byte m_DepthClip; // 0x1C
	private Byte m_Conservative; // 0x1D
	private Byte m_Padding1; // 0x1E
	private Byte m_Padding2; // 0x1F

	// Methods

	// RVA: 0x16B2834
	public void .ctor(CullMode cullingMode, int offsetUnits, float offsetFactor, bool depthClip) { }

	// RVA: 0x16B28DC
	public bool Equals(RasterState other) { }

	// RVA: 0x16B295C
	public override bool Equals(object obj) { }

	// RVA: 0x16B2A88
	public override int GetHashCode() { }

	// RVA: 0x16B2AF4
	private static void .cctor() { }

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
public struct RendererList
{
	// Fields
	internal UIntPtr context; // 0x10
	internal UInt32 index; // 0x18
	internal UInt32 frame; // 0x1C
	internal UInt32 type; // 0x20
	internal UInt32 contextID; // 0x24
	public static readonly RendererList nullRendererList; // 0x0

	// Methods

	// RVA: 0x16B2BD8
	internal void .ctor(UIntPtr ctx, UInt32 indx) { }

	// RVA: 0x16B2BE8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct RendererListParams
{
	// Fields
	public static readonly RendererListParams Invalid; // 0x0
	public CullingResults cullingResults; // 0x10
	public DrawingSettings drawSettings; // 0x20
	public FilteringSettings filteringSettings; // 0xE4
	public ShaderTagId tagName; // 0x104
	public bool isPassTagName; // 0x108
	public System.Nullable<Unity.Collections.NativeArray<UnityEngine.Rendering.ShaderTagId>> tagValues; // 0x110
	public System.Nullable<Unity.Collections.NativeArray<UnityEngine.Rendering.RenderStateBlock>> stateBlocks; // 0x128

	// Methods

	// RVA: 0x16B2C40
	internal int get_numStateBlocks() { }

	// RVA: 0x16B2D0C
	internal IntPtr get_stateBlocksPtr() { }

	// RVA: 0x16B2DFC
	internal IntPtr get_tagsValuePtr() { }

	// RVA: 0x16B2EEC
	internal void Validate() { }

	// RVA: 0x16B34A0
	public bool Equals(RendererListParams other) { }

	// RVA: 0x16B3950
	public override bool Equals(object obj) { }

	// RVA: 0x16B3A68
	public override int GetHashCode() { }

	// RVA: 0x16B3C20
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipeline
{
	// Fields
	private bool <disposed>k__BackingField; // 0x10

	// Methods

	// RVA: -1
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras) { }

	// RVA: 0x26AD93C
	protected virtual void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	// RVA: 0x26AD93C
	protected internal virtual bool IsRenderRequestSupported(Camera camera, RequestData data) { }

	// RVA: 0x16B3C94
	protected virtual void Render(ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x16B3D10
	internal void InternalRender(ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras) { }

	// RVA: 0x26AD93C
	internal void InternalProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	// RVA: 0x16B3D94
	public bool get_disposed() { }

	// RVA: 0x16B3D9C
	private void set_disposed(bool value) { }

	// RVA: 0x16B3DA4
	internal void Dispose() { }

	// RVA: 0x16B3E28
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x16B3E2C
	protected void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset
{
	// Methods

	// RVA: 0x16B3E34
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x16B3F34
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x16B3F3C
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x16B3F44
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x16B3F4C
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x16B3F54
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x16B3F5C
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x16B3F64
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x16B3F6C
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x16B3F74
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x16B3F7C
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x16B3F84
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x16B3F8C
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x16B3F94
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x16B3F9C
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x16B3FA4
	public virtual Material get_default2DMaskMaterial() { }

	// RVA: 0x16B3FAC
	public virtual Shader get_defaultShader() { }

	// RVA: 0x16B3FB4
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x16B3FBC
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: 0x16B3FC4
	public virtual Shader get_defaultSpeedTree9Shader() { }

	// RVA: 0x16B3FCC
	public virtual string get_renderPipelineShaderTag() { }

	// RVA: -1
	protected abstract RenderPipeline CreatePipeline() { }

	// RVA: 0x16B4050
	public virtual Type get_pipelineType() { }

	// RVA: 0x16B40C4
	internal string get_pipelineTypeFullName() { }

	// RVA: 0x16B4118
	protected virtual void EnsureGlobalSettings() { }

	// RVA: 0x16B411C
	protected virtual void OnValidate() { }

	// RVA: 0x16B42A8
	protected virtual void OnDisable() { }

	// RVA: 0x16B4700
	protected internal virtual Type get_renderPipelineType() { }

	// RVA: 0x16B4774
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x16B477C
	public virtual string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x16B4784
	protected void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineGlobalSettings
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Type,System.Int32> <settingsMap>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16B478C
	protected virtual System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList() { }

	// RVA: 0x16B49BC
	private System.Collections.Generic.Dictionary<System.Type,System.Int32> get_settingsMap() { }

	// RVA: 0x16B49C4
	private void RecreateSettingsMap() { }

	// RVA: 0x16B4B14
	protected internal bool TryGet(Type type, IRenderPipelineGraphicsSettings settings) { }

	// RVA: 0x35252FC
	protected internal bool TryGetFirstSettingsImplementingInterface(TSettingsInterfaceType settings) { }

	// RVA: 0x35252FC
	protected internal bool GetSettingsImplementingInterface(System.Collections.Generic.List<TSettingsInterfaceType>& settings) { }

	// RVA: 0x16B4C0C
	protected internal bool Contains(Type type) { }

	// RVA: 0x16B4C94
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x16B4C98
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x16B4C9C
	protected void .ctor() { }

}

// Namespace: UnityEngine.Rendering
public static class RenderPipelineManager
{
	// Fields
	private static bool s_CleanUpPipeline; // 0x0
	private static string s_CurrentPipelineType; // 0x8
	private static RenderPipelineAsset s_CurrentPipelineAsset; // 0x10
	private static RenderPipeline s_CurrentPipeline; // 0x18
	private static Action activeRenderPipelineTypeChanged; // 0x20
	private static System.Action<UnityEngine.Rendering.RenderPipelineAsset,UnityEngine.Rendering.RenderPipelineAsset> activeRenderPipelineAssetChanged; // 0x28
	private static Action activeRenderPipelineCreated; // 0x30
	private static Action activeRenderPipelineDisposed; // 0x38

	// Methods

	// RVA: 0x16B4D28
	public static RenderPipeline get_currentPipeline() { }

	// RVA: 0x16B4DA4
	private static void set_currentPipeline(RenderPipeline value) { }

	// RVA: 0x16B4E7C
	internal static void OnActiveRenderPipelineTypeChanged() { }

	// RVA: 0x16B4F0C
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	// RVA: 0x16B5034
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x16B419C
	internal static void RecreateCurrentPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x16B4310
	internal static void CleanupRenderPipeline() { }

	// RVA: 0x16B5230
	private static string GetCurrentPipelineAssetType() { }

	// RVA: 0x16B52AC
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipelineAsset, IntPtr loopPtr, object renderRequest) { }

	// RVA: 0x16B5640
	internal static bool TryPrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x16B50E0
	private static bool get_isCurrentPipelineValid() { }

	// RVA: 0x16B5874
	private static bool IsPipelineRequireCreation() { }

	// RVA: 0x16B5A5C
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

	// RVA: 0x16B1FF0
	public static RenderQueueRange get_all() { }

	// RVA: 0x16B5AE0
	public static RenderQueueRange get_transparent() { }

	// RVA: 0x16B5AEC
	public int get_lowerBound() { }

	// RVA: 0x16B22A0
	public bool Equals(RenderQueueRange other) { }

	// RVA: 0x16B5AF4
	public override bool Equals(object obj) { }

	// RVA: 0x16B24B0
	public override int GetHashCode() { }

	// RVA: 0x16B5BD4
	private static void .cctor() { }

}

// Namespace: UnityEngine.Rendering
public struct RenderStateBlock
{
	// Fields
	private BlendState m_BlendState; // 0x10
	private RasterState m_RasterState; // 0x54
	private DepthState m_DepthState; // 0x64
	private StencilState m_StencilState; // 0x66
	private int m_StencilReference; // 0x74
	private RenderStateMask m_Mask; // 0x78

	// Methods

	// RVA: 0x16B5C28
	public bool Equals(RenderStateBlock other) { }

	// RVA: 0x16B5EEC
	public override bool Equals(object obj) { }

	// RVA: 0x16B5FA4
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public enum RenderStateMask
{
	// Fields
	public int value__; // 0x10
	public const RenderStateMask Nothing = 0;
	public const RenderStateMask Blend = 1;
	public const RenderStateMask Raster = 2;
	public const RenderStateMask Depth = 4;
	public const RenderStateMask Stencil = 8;
	public const RenderStateMask Everything = 15;
}

// Namespace: UnityEngine.Rendering
public struct RenderTargetBlendState
{
	// Fields
	private Byte m_WriteMask; // 0x10
	private Byte m_SourceColorBlendMode; // 0x11
	private Byte m_DestinationColorBlendMode; // 0x12
	private Byte m_SourceAlphaBlendMode; // 0x13
	private Byte m_DestinationAlphaBlendMode; // 0x14
	private Byte m_ColorBlendOperation; // 0x15
	private Byte m_AlphaBlendOperation; // 0x16
	private Byte m_Padding; // 0x17

	// Methods

	// RVA: 0x16B61B0
	public bool Equals(RenderTargetBlendState other) { }

	// RVA: 0x16B6228
	public override bool Equals(object obj) { }

	// RVA: 0x16B6318
	public override int GetHashCode() { }

}

// Namespace: 
private struct CullShadowCastersContext
{
	// Fields
	public IntPtr cullResults; // 0x10
	public ShadowSplitData* splitBuffer; // 0x18
	public int splitBufferLength; // 0x20
	public LightShadowCasterCullingInfo* perLightInfos; // 0x28
	public int perLightInfoCount; // 0x30
}

// Namespace: UnityEngine.Rendering
public struct ScriptableRenderContext
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x16B63C4
	private static void Internal_Cull(ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x16B64D4
	internal static void InitializeSortSettings(Camera camera, SortingSettings sortingSettings) { }

	// RVA: 0x16B6630
	private void Submit_Internal() { }

	// RVA: 0x16B6680
	private void GetCameras_Internal(Type listType, object resultList) { }

	// RVA: 0x16B66D8
	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer) { }

	// RVA: 0x16B67F4
	private void SetupCameraProperties_Internal(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x16B6970
	private void DrawGizmos_Internal(Camera camera, GizmoSubset gizmoSubset) { }

	// RVA: 0x16B6AD4
	private RendererList CreateRendererList_Internal(IntPtr cullResults, DrawingSettings drawingSettings, FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount) { }

	// RVA: 0x16B5790
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x16B6CB0
	public void Submit() { }

	// RVA: 0x16B5798
	internal void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results) { }

	// RVA: 0x16B6D5C
	public void ExecuteCommandBuffer(CommandBuffer commandBuffer) { }

	// RVA: 0x16B6EF4
	public void SetupCameraProperties(Camera camera, bool stereoSetup) { }

	// RVA: 0x16B6FC8
	public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye) { }

	// RVA: 0x16B7048
	public void DrawGizmos(Camera camera, GizmoSubset gizmoSubset) { }

	// RVA: 0x16B70C0
	public CullingResults Cull(ScriptableCullingParameters parameters) { }

	// RVA: 0x16B71D4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x16B7220
	public override bool Equals(object obj) { }

	// RVA: 0x16B7318
	public override int GetHashCode() { }

	// RVA: 0x16B7320
	public RendererList CreateRendererList(RendererListParams param) { }

	// RVA: 0x16B7564
	private static void .cctor() { }

	// RVA: 0x16B647C
	private static void Internal_Cull_Injected(ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results) { }

	// RVA: 0x16B65C8
	private static void InitializeSortSettings_Injected(IntPtr camera, SortingSettings sortingSettings) { }

	// RVA: 0x16B678C
	private static void ExecuteCommandBuffer_Internal_Injected(ScriptableRenderContext _unity_self, IntPtr commandBuffer) { }

	// RVA: 0x16B6908
	private static void SetupCameraProperties_Internal_Injected(ScriptableRenderContext _unity_self, IntPtr camera, bool stereoSetup, int eye) { }

	// RVA: 0x16B6A7C
	private static void DrawGizmos_Internal_Injected(ScriptableRenderContext _unity_self, IntPtr camera, GizmoSubset gizmoSubset) { }

	// RVA: 0x16B6C04
	private static void CreateRendererList_Internal_Injected(ScriptableRenderContext _unity_self, IntPtr cullResults, DrawingSettings drawingSettings, FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, RendererList ret) { }

}

// Namespace: UnityEngine.Rendering
public struct ShaderTagId
{
	// Fields
	private int m_Id; // 0x10

	// Methods

	// RVA: 0x16B75D8
	public void .ctor(string name) { }

	// RVA: 0x16B1670
	internal int get_id() { }

	// RVA: 0x16B17D4
	internal void set_id(int value) { }

	// RVA: 0x16B7604
	public override bool Equals(object obj) { }

	// RVA: 0x16B19B4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x16B3BFC
	public override int GetHashCode() { }

	// RVA: 0x16B3944
	public static bool op_Equality(ShaderTagId tag1, ShaderTagId tag2) { }

}

// Namespace: 
public struct <m_CullingPlanes>e__FixedBuffer
{
	// Fields
	public Byte FixedElementField; // 0x10
}

// Namespace: UnityEngine.Rendering
public struct ShadowSplitData
{
	// Fields
	public static readonly int maximumCullingPlaneCount; // 0x0
	private int m_CullingPlaneCount; // 0x10
	internal UnityEngine.Rendering.ShadowSplitData.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x14
	private Vector4 m_CullingSphere; // 0xB4
	private float m_ShadowCascadeBlendCullingFactor; // 0xC4
	private float m_CullingNearPlane; // 0xC8
	private Matrix4x4 m_CullingMatrix; // 0xCC

	// Methods

	// RVA: 0x16B7694
	public int get_cullingPlaneCount() { }

	// RVA: 0x16B769C
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x16B77E8
	public bool Equals(ShadowSplitData other) { }

	// RVA: 0x16B7964
	public override bool Equals(object obj) { }

	// RVA: 0x16B7AB4
	public override int GetHashCode() { }

	// RVA: 0x16B7B3C
	private static void .cctor() { }

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

	// RVA: 0x16B2194
	public static SortingLayerRange get_all() { }

	// RVA: 0x16B7B8C
	public bool Equals(SortingLayerRange other) { }

	// RVA: 0x16B7BB0
	public override bool Equals(object obj) { }

	// RVA: 0x16B7C4C
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

	// RVA: 0x16B7C54
	public void .ctor(Camera camera) { }

	// RVA: 0x16B7D84
	public SortingCriteria get_criteria() { }

	// RVA: 0x16B7D8C
	public void set_criteria(SortingCriteria value) { }

	// RVA: 0x16B19C4
	public bool Equals(SortingSettings other) { }

	// RVA: 0x16B7D94
	public override bool Equals(object obj) { }

	// RVA: 0x16B1D04
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

	// RVA: 0x16B7ECC
	public void set_enabled(bool value) { }

	// RVA: 0x16B7F3C
	public void set_readMask(Byte value) { }

	// RVA: 0x16B7F44
	public void set_writeMask(Byte value) { }

	// RVA: 0x16B7F4C
	public void set_compareFunctionFront(CompareFunction value) { }

	// RVA: 0x16B7F54
	public void set_passOperationFront(StencilOp value) { }

	// RVA: 0x16B7F5C
	public void set_failOperationFront(StencilOp value) { }

	// RVA: 0x16B7F64
	public void set_zFailOperationFront(StencilOp value) { }

	// RVA: 0x16B7F6C
	public void set_compareFunctionBack(CompareFunction value) { }

	// RVA: 0x16B7F74
	public void set_passOperationBack(StencilOp value) { }

	// RVA: 0x16B7F7C
	public void set_failOperationBack(StencilOp value) { }

	// RVA: 0x16B7F84
	public void set_zFailOperationBack(StencilOp value) { }

	// RVA: 0x16B5E3C
	public bool Equals(StencilState other) { }

	// RVA: 0x16B7F8C
	public override bool Equals(object obj) { }

	// RVA: 0x16B60B4
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
	private bool <skyOcclusion>k__BackingField; // 0x26
	private bool <lightProbeProxyVolumes>k__BackingField; // 0x27
	private bool <motionVectors>k__BackingField; // 0x28
	private bool <receiveShadows>k__BackingField; // 0x29
	private bool <reflectionProbes>k__BackingField; // 0x2A
	private bool <reflectionProbesBlendDistance>k__BackingField; // 0x2B
	private bool <rendererPriority>k__BackingField; // 0x2C
	private bool <rendersUIOverlay>k__BackingField; // 0x2D
	private bool <overridesEnvironmentLighting>k__BackingField; // 0x2E
	private bool <overridesFog>k__BackingField; // 0x2F
	private bool <overridesRealtimeReflectionProbes>k__BackingField; // 0x30
	private bool <overridesOtherLightingSettings>k__BackingField; // 0x31
	private bool <editableMaterialRenderQueue>k__BackingField; // 0x32
	private bool <overridesLODBias>k__BackingField; // 0x33
	private bool <overridesMaximumLODLevel>k__BackingField; // 0x34
	private bool <overridesEnableLODCrossFade>k__BackingField; // 0x35
	private bool <rendererProbes>k__BackingField; // 0x36
	private bool <particleSystemInstancing>k__BackingField; // 0x37
	private bool <ambientProbeBaking>k__BackingField; // 0x38
	private bool <defaultReflectionProbeBaking>k__BackingField; // 0x39
	private bool <overridesShadowmask>k__BackingField; // 0x3A
	private bool <overridesLightProbeSystem>k__BackingField; // 0x3B
	private bool <supportsHDR>k__BackingField; // 0x3C
	private bool <supportsClouds>k__BackingField; // 0x3D
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; // 0x40

	// Methods

	// RVA: 0x16B80B8
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0x16B51BC
	public static void set_active(SupportedRenderingFeatures value) { }

	// RVA: 0x16B82E0
	public LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	// RVA: 0x16B82E8
	public LightmapMixedBakeModes get_mixedLightingModes() { }

	// RVA: 0x16B82F0
	public LightmapBakeType get_lightmapBakeTypes() { }

	// RVA: 0x16B82F8
	public LightmapsMode get_lightmapsModes() { }

	// RVA: 0x16B8300
	public bool get_enlighten() { }

	// RVA: 0x16B8308
	public bool get_rendersUIOverlay() { }

	// RVA: 0x16B8310
	public bool get_ambientProbeBaking() { }

	// RVA: 0x16B8318
	public bool get_defaultReflectionProbeBaking() { }

	// RVA: 0x16B8320
	public bool get_overridesLightProbeSystem() { }

	// RVA: 0x16B8328
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x16B853C
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	// RVA: 0x16B85B4
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x16B8770
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	// RVA: 0x16B87E8
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	// RVA: 0x16B89B4
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	// RVA: 0x16B8A40
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	// RVA: 0x16B8A74
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	// RVA: 0x16B8AF4
	internal static void IsAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0x16B8B74
	internal static void IsDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	// RVA: 0x16B8BF4
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	// RVA: 0x16B8C74
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x16B8234
	public void .ctor() { }

	// RVA: 0x16B8C94
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

	// RVA: 0x16B8D8C
	public bool Equals(VisibleLight other) { }

	// RVA: 0x16B8F4C
	public override bool Equals(object obj) { }

	// RVA: 0x16B900C
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
internal enum VisibleLightFlags
{
	// Fields
	public int value__; // 0x10
	public const VisibleLightFlags IntersectsNearPlane = 1;
	public const VisibleLightFlags IntersectsFarPlane = 2;
	public const VisibleLightFlags ForcedVisible = 4;
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

	// RVA: 0x16B9114
	public bool Equals(VisibleReflectionProbe other) { }

	// RVA: 0x16B92BC
	public override bool Equals(object obj) { }

	// RVA: 0x16B937C
	public override int GetHashCode() { }

}

// Namespace: UnityEngine.Rendering
public struct GlobalKeyword
{
	// Fields
	internal readonly string m_Name; // 0x10
	internal readonly UInt32 m_Index; // 0x18

	// Methods

	// RVA: 0x16B9538
	private static UInt32 GetGlobalKeywordCount() { }

	// RVA: 0x16B9578
	private static UInt32 GetGlobalKeywordIndex(string keyword) { }

	// RVA: 0x16B9750
	public void .ctor(string name) { }

	// RVA: 0x16B98A0
	public override string ToString() { }

	// RVA: 0x16B9700
	private static UInt32 GetGlobalKeywordIndex_Injected(ManagedSpanWrapper keyword) { }

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

	// RVA: 0x16B98A8
	internal static UInt32 GetGlobalKeywordCount() { }

	// RVA: 0x16B98E8
	internal static UInt32 GetGlobalKeywordIndex(string keyword) { }

	// RVA: 0x16B9AC0
	internal static void CreateGlobalKeyword(string keyword) { }

	// RVA: 0x16B9C84
	public void .ctor(string keywordName) { }

	// RVA: 0x16B9D1C
	public override string ToString() { }

	// RVA: 0x16B9A70
	private static UInt32 GetGlobalKeywordIndex_Injected(ManagedSpanWrapper keyword) { }

	// RVA: 0x16B9C34
	private static void CreateGlobalKeyword_Injected(ManagedSpanWrapper keyword) { }

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

	// RVA: 0x16B9D24
	public float get_red() { }

	// RVA: 0x16B9D2C
	public void set_red(float value) { }

	// RVA: 0x16B9DE0
	public float get_green() { }

	// RVA: 0x16B9DE8
	public void set_green(float value) { }

	// RVA: 0x16B9E9C
	public float get_blue() { }

	// RVA: 0x16B9EA4
	public void set_blue(float value) { }

	// RVA: 0x16B9F58
	public static LinearColor Convert(Color color, float intensity) { }

	// RVA: 0x16BA258
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

	// RVA: 0x16BA26C
	public void Init(DirectionalLight light, Cookie cookie) { }

	// RVA: 0x16BA2DC
	public void Init(PointLight light, Cookie cookie) { }

	// RVA: 0x16BA354
	public void Init(SpotLight light, Cookie cookie) { }

	// RVA: 0x16BA3D0
	public void Init(RectangleLight light, Cookie cookie) { }

	// RVA: 0x16BA444
	public void Init(DiscLight light, Cookie cookie) { }

	// RVA: 0x16BA4BC
	public void InitNoBake(int lightInstanceID) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils
{
	// Methods

	// RVA: 0x16BA4CC
	public static LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x16BA4E4
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x16BA568
	public static float ExtractInnerCone(Light l) { }

	// RVA: 0x16BA5C4
	private static Color ExtractColorTemperature(Light l) { }

	// RVA: 0x16BA6BC
	private static void ApplyColorTemperature(Color cct, LinearColor lightColor) { }

	// RVA: 0x16BA710
	public static void Extract(Light l, DirectionalLight dir) { }

	// RVA: 0x16BA924
	public static void Extract(Light l, PointLight point) { }

	// RVA: 0x16BAB50
	public static void Extract(Light l, SpotLight spot) { }

	// RVA: 0x16BADDC
	public static void Extract(Light l, RectangleLight rect) { }

	// RVA: 0x16BB008
	public static void Extract(Light l, DiscLight disc) { }

	// RVA: 0x16BB234
	public static void Extract(Light l, Cookie cookie) { }

}

// Namespace: 
public sealed class RequestLightsDelegate
{
	// Methods

	// RVA: 0x16BB780
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16BB83C
	public virtual void Invoke(Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16BB850
	private static void .cctor() { }

	// RVA: 0x16BB8BC
	public void .ctor() { }

	// RVA: 0x16BB8C4
	internal void <.cctor>b__7_0(Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput) { }

}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping
{
	// Fields
	private static readonly RequestLightsDelegate s_DefaultDelegate; // 0x0
	private static RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	// RVA: 0x16BB390
	public static void SetDelegate(RequestLightsDelegate del) { }

	// RVA: 0x16BB440
	public static RequestLightsDelegate GetDelegate() { }

	// RVA: 0x16BB4BC
	public static void ResetDelegate() { }

	// RVA: 0x16BB540
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x16BB610
	private static void .cctor() { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct CameraPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x16BBD60
	public PlayableHandle GetHandle() { }

	// RVA: 0x16BBD6C
	public bool Equals(CameraPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct MaterialEffectPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x16BBDF0
	public PlayableHandle GetHandle() { }

	// RVA: 0x16BBDFC
	public bool Equals(MaterialEffectPlayable other) { }

}

// Namespace: UnityEngine.Experimental.Playables
public struct TextureMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x16BBE80
	public PlayableHandle GetHandle() { }

	// RVA: 0x16BBE8C
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

	// RVA: 0x16BBF10
	public bool TickRealtimeProbes() { }

	// RVA: 0x16BBF90
	public void Dispose() { }

	// RVA: 0x16BBF94
	private void Dispose(bool disposing) { }

	// RVA: 0x16BBF50
	private static bool BuiltinUpdate() { }

	// RVA: 0x16BBF98
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	// RVA: 0x16BBFF0
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

	// RVA: 0x16BBFF8
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0x16BC16C
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	// RVA: 0x16BC1E8
	private static void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0x16BC228
	private static void .cctor() { }

}

// Namespace: UnityEngine.Experimental.Rendering
internal class ScriptableRuntimeReflectionSystemWrapper
{
	// Fields
	private IScriptableRuntimeReflectionSystem <implementation>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16BC2B8
	internal IScriptableRuntimeReflectionSystem get_implementation() { }

	// RVA: 0x16BC2C0
	internal void set_implementation(IScriptableRuntimeReflectionSystem value) { }

	// RVA: 0x16BC2C8
	private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(bool result) { }

	// RVA: 0x16BC2B0
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
public enum GraphicsFormatUsage
{
	// Fields
	public int value__; // 0x10
	public const GraphicsFormatUsage None = 0;
	public const GraphicsFormatUsage Sample = 1;
	public const GraphicsFormatUsage Linear = 2;
	public const GraphicsFormatUsage Sparse = 4;
	public const GraphicsFormatUsage Render = 16;
	public const GraphicsFormatUsage Blend = 32;
	public const GraphicsFormatUsage GetPixels = 64;
	public const GraphicsFormatUsage SetPixels = 128;
	public const GraphicsFormatUsage SetPixels32 = 256;
	public const GraphicsFormatUsage ReadPixels = 512;
	public const GraphicsFormatUsage LoadStore = 1024;
	public const GraphicsFormatUsage MSAA2x = 2048;
	public const GraphicsFormatUsage MSAA4x = 4096;
	public const GraphicsFormatUsage MSAA8x = 8192;
	public const GraphicsFormatUsage StencilSampling = 65536;
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

	// RVA: 0x16BC39C
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x16BC454
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x16BC4BC
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x16BC574
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x16BC5DC
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	// RVA: 0x16BC6FC
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	// RVA: 0x16BC74C
	public static GraphicsFormat GetDepthStencilFormat(int depthBits) { }

	// RVA: 0x16BC7F8
	public static int GetDepthBits(GraphicsFormat format) { }

	// RVA: 0x16BC848
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	// RVA: 0x16BCA78
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	// RVA: 0x16BCAC8
	public static GraphicsFormat GetSRGBFormat(GraphicsFormat format) { }

	// RVA: 0x16BCB18
	public static GraphicsFormat GetLinearFormat(GraphicsFormat format) { }

	// RVA: 0x16BCB68
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	// RVA: 0x16BCBB8
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	// RVA: 0x16BCC08
	public static bool IsCompressedFormat(TextureFormat format) { }

	// RVA: 0x16BCCB4
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	// RVA: 0x16BCD1C
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	// RVA: 0x16BCDD0
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	// RVA: 0x16BCE20
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	// RVA: 0x16BCE70
	public static bool IsCrunchFormat(TextureFormat format) { }

	// RVA: 0x16BCEC0
	private static void .cctor() { }

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

// Namespace: UnityEngine.Sprites
public sealed class DataUtility
{
	// Methods

	// RVA: 0x16BCFB0
	public static Vector4 GetInnerUV(Sprite sprite) { }

	// RVA: 0x16BCFC8
	public static Vector4 GetOuterUV(Sprite sprite) { }

	// RVA: 0x16BCFE0
	public static Vector4 GetPadding(Sprite sprite) { }

	// RVA: 0x16BCFF8
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

	// RVA: 0x16BD064
	private static bool RequestAtlas(string tag) { }

	// RVA: 0x16BD124
	public static void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }

	// RVA: 0x16BD1F8
	public static void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value) { }

	// RVA: 0x16BD2CC
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x16BD348
	internal static void Register(SpriteAtlas spriteAtlas) { }

	// RVA: 0x16BD3F8
	private static void Register_Injected(IntPtr spriteAtlas) { }

}

// Namespace: UnityEngine.U2D
public class SpriteAtlas
{
	// Methods

	// RVA: 0x16BD448
	public bool CanBindTo(Sprite sprite) { }

	// RVA: 0x16BD55C
	private static bool CanBindTo_Injected(IntPtr _unity_self, IntPtr sprite) { }

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


