// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngineInternal.Input
internal sealed class NativeUpdateCallback 
{
	// Methods

	// RVA: 0x1566E38
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1566EDC
	internal void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

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

	// RVA: 0x1566EF0
	System.Action<System.Int32,System.String> get_onDeviceDiscovered() { }

	// RVA: 0x1566F6C
	void set_onDeviceDiscovered(System.Action<System.Int32,System.String> value) { }

	// RVA: 0x1567078
	void .cctor() { }

	// RVA: 0x15670C4
	void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	// RVA: 0x156716C
	void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	// RVA: 0x1567224
	void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	// RVA: 0x15672D4
	void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x1567028
	void set_hasDeviceDiscoveredCallback(bool value) { }

	// RVA: 0x15673A4
	Double get_currentTime() { }

	// RVA: 0x15673E4
	Double get_currentTimeOffsetToRealtimeSinceStartup() { }

	// RVA: 0x1567424
	int AllocateDeviceId() { }

	// RVA: 0x1567464
	void QueueInputEvent(IntPtr inputEvent) { }

	// RVA: 0x15674B4
	Int64 IOCTL(int deviceId, int code, IntPtr data, int sizeInBytes) { }

	// RVA: 0x156751C
	void SetPollingFrequency(float hertz) { }

	// RVA: 0x1567574
	void Update(NativeInputUpdateType updateType) { }

}


