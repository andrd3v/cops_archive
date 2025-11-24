// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback
{
	// Methods

	// RVA: 0x164B5A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x164B648
	public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

}

// Namespace: UnityEngineInternal.Input
internal enum NativeInputEventType
{
	// Fields
	public int value__; // 0x10
	public const NativeInputEventType DeviceRemoved = 1146242381;
	public const NativeInputEventType DeviceConfigChanged = 1145259591;
	public const NativeInputEventType Text = 1413830740;
	public const NativeInputEventType State = 1398030676;
	public const NativeInputEventType Delta = 1145852993;
}

// Namespace: UnityEngineInternal.Input
internal struct NativeInputEventBuffer
{
	// Fields
	public Void* eventBuffer; // 0x10
	public int eventCount; // 0x18
	public int sizeInBytes; // 0x1C
	public int capacityInBytes; // 0x20
}

// Namespace: UnityEngineInternal.Input
internal struct NativeInputEvent
{
	// Fields
	public const int structSize = 20;
	public NativeInputEventType type; // 0x10
	public UInt16 sizeInBytes; // 0x14
	public UInt16 deviceId; // 0x16
	public Double time; // 0x18
	public int eventId; // 0x20
}

// Namespace: UnityEngineInternal.Input
internal enum NativeInputUpdateType
{
	// Fields
	public int value__; // 0x10
	public const NativeInputUpdateType Dynamic = 1;
	public const NativeInputUpdateType Fixed = 2;
	public const NativeInputUpdateType BeforeRender = 4;
	public const NativeInputUpdateType Editor = 8;
	public const NativeInputUpdateType IgnoreFocus = 2147483648;
}

// Namespace: UnityEngineInternal.Input
internal class NativeInputSystem
{
	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static System.Action<UnityEngineInternal.Input.NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static System.Func<UnityEngineInternal.Input.NativeInputUpdateType,System.Boolean> onShouldRunUpdate; // 0x10
	private static System.Action<System.Int32,System.String> s_OnDeviceDiscoveredCallback; // 0x18

	// Methods

	// RVA: 0x164B65C
	public static System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }

	// RVA: 0x164B6D8
	public static void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }

	// RVA: 0x164B7E4
	private static void .cctor() { }

	// RVA: 0x164B830
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	// RVA: 0x164B8D8
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	// RVA: 0x164B990
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	// RVA: 0x164BA40
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, bool retval) { }

	// RVA: 0x164B794
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }

	// RVA: 0x164BB10
	public static Double get_currentTime() { }

	// RVA: 0x164BB50
	public static Double get_currentTimeOffsetToRealtimeSinceStartup() { }

	// RVA: 0x164BB90
	public static int AllocateDeviceId() { }

	// RVA: 0x164BBD0
	public static void QueueInputEvent(IntPtr inputEvent) { }

	// RVA: 0x164BC20
	public static Int64 IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes) { }

	// RVA: 0x164BC88
	public static void SetPollingFrequency(float hertz) { }

	// RVA: 0x164BCE0
	public static void Update(NativeInputUpdateType updateType) { }

}


