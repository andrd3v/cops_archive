// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine
public enum TouchPhase 
{
	// Fields
	public int value__; // 0x10
	public const TouchPhase Began = 0;
	public const TouchPhase Moved = 1;
	public const TouchPhase Stationary = 2;
	public const TouchPhase Ended = 3;
	public const TouchPhase Canceled = 4;
}

// Namespace: UnityEngine
public enum IMECompositionMode 
{
	// Fields
	public int value__; // 0x10
	public const IMECompositionMode Auto = 0;
	public const IMECompositionMode On = 1;
	public const IMECompositionMode Off = 2;
}

// Namespace: UnityEngine
public enum TouchType 
{
	// Fields
	public int value__; // 0x10
	public const TouchType Direct = 0;
	public const TouchType Indirect = 1;
	public const TouchType Stylus = 2;
}

// Namespace: UnityEngine
public struct Touch 
{
	// Fields
	private int m_FingerId; // 0x10
	private Vector2 m_Position; // 0x14
	private Vector2 m_RawPosition; // 0x1C
	private Vector2 m_PositionDelta; // 0x24
	private float m_TimeDelta; // 0x2C
	private int m_TapCount; // 0x30
	private TouchPhase m_Phase; // 0x34
	private TouchType m_Type; // 0x38
	private float m_Pressure; // 0x3C
	private float m_maximumPossiblePressure; // 0x40
	private float m_Radius; // 0x44
	private float m_RadiusVariance; // 0x48
	private float m_AltitudeAngle; // 0x4C
	private float m_AzimuthAngle; // 0x50

	// Methods

	// RVA: 0x1563F98
	int get_fingerId() { }

	// RVA: 0x1563FA0
	Vector2 get_position() { }

	// RVA: 0x1563FA8
	void set_position(Vector2 value) { }

	// RVA: 0x1563FB0
	Vector2 get_rawPosition() { }

	// RVA: 0x1563FB8
	void set_rawPosition(Vector2 value) { }

	// RVA: 0x1563FC0
	Vector2 get_deltaPosition() { }

	// RVA: 0x1563FC8
	void set_deltaPosition(Vector2 value) { }

	// RVA: 0x1563FD0
	float get_deltaTime() { }

	// RVA: 0x1563FD8
	int get_tapCount() { }

	// RVA: 0x1563FE0
	TouchPhase get_phase() { }

	// RVA: 0x1563FE8
	float get_pressure() { }

	// RVA: 0x1563FF0
	float get_maximumPossiblePressure() { }

	// RVA: 0x1563FF8
	TouchType get_type() { }

	// RVA: 0x1564000
	float get_altitudeAngle() { }

	// RVA: 0x1564008
	float get_azimuthAngle() { }

	// RVA: 0x1564010
	float get_radius() { }

	// RVA: 0x1564018
	float get_radiusVariance() { }

}

// Namespace: UnityEngine
public enum PenStatus 
{
	// Fields
	public int value__; // 0x10
	public const PenStatus None = 0;
	public const PenStatus Contact = 1;
	public const PenStatus Barrel = 2;
	public const PenStatus Inverted = 4;
	public const PenStatus Eraser = 8;
}

// Namespace: UnityEngine
public enum PenEventType 
{
	// Fields
	public int value__; // 0x10
	public const PenEventType NoContact = 0;
	public const PenEventType PenDown = 1;
	public const PenEventType PenUp = 2;
}

// Namespace: UnityEngine
public struct PenData 
{
	// Fields
	public Vector2 position; // 0x10
	public Vector2 tilt; // 0x18
	public PenStatus penStatus; // 0x20
	public float twist; // 0x24
	public float pressure; // 0x28
	public PenEventType contactType; // 0x2C
	public Vector2 deltaPos; // 0x30
}

// Namespace: UnityEngine
public class Gyroscope 
{
	// Fields
	private int m_GyroIndex; // 0x10

	// Methods

	// RVA: 0x1564020
	void .ctor(int index) { }

	// RVA: 0x156404C
	Vector3 rotationRateUnbiased_Internal(int idx) { }

	// RVA: 0x1564114
	bool getEnabled_Internal(int idx) { }

	// RVA: 0x1564164
	void setEnabled_Internal(int idx, bool enabled) { }

	// RVA: 0x15641CC
	Vector3 get_rotationRateUnbiased() { }

	// RVA: 0x156422C
	bool get_enabled() { }

	// RVA: 0x156427C
	void set_enabled(bool value) { }

	// RVA: 0x15640AC
	void rotationRateUnbiased_Internal_Injected(int idx, out Vector3 ret) { }

}

// Namespace: UnityEngine
internal class CameraRaycastHelper 
{
	// Methods

	// RVA: 0x15642E4
	GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x15643B4
	GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x156434C
	GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	// RVA: 0x156441C
	GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

}

// Namespace: UnityEngine
public class Input 
{
	// Fields
	private static Gyroscope s_MainGyro; // 0x0

	// Methods

	// RVA: 0x1564484
	float GetAxis(string axisName) { }

	// RVA: 0x1564524
	float GetAxisRaw(string axisName) { }

	// RVA: 0x15645C4
	bool GetButtonDown(string buttonName) { }

	// RVA: 0x1564664
	bool GetKeyInt(KeyCode key) { }

	// RVA: 0x15646B4
	bool GetKeyDownInt(KeyCode key) { }

	// RVA: 0x1564704
	bool GetMouseButton(int button) { }

	// RVA: 0x1564754
	bool GetMouseButtonDown(int button) { }

	// RVA: 0x15647A4
	bool GetMouseButtonUp(int button) { }

	// RVA: 0x15647F4
	Touch GetTouch(int index) { }

	// RVA: 0x15648E0
	PenData GetLastPenContactEvent() { }

	// RVA: 0x1564998
	void ClearLastPenContactEvent() { }

	// RVA: 0x15649D8
	bool GetKey(KeyCode key) { }

	// RVA: 0x1564A28
	bool GetKeyDown(KeyCode key) { }

	// RVA: 0x1564A78
	bool get_anyKey() { }

	// RVA: 0x1564AB8
	Vector3 get_mousePosition() { }

	// RVA: 0x1564B60
	Vector2 get_mouseScrollDelta() { }

	// RVA: 0x1564C00
	IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x1564C40
	void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1564C90
	string get_compositionString() { }

	// RVA: 0x1564CD0
	Vector2 get_compositionCursorPos() { }

	// RVA: 0x1564D70
	void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1564E24
	bool get_mousePresent() { }

	// RVA: 0x1564E64
	int get_touchCount() { }

	// RVA: 0x1564EA4
	bool get_touchPressureSupported() { }

	// RVA: 0x1564EE4
	bool get_touchSupported() { }

	// RVA: 0x1564F24
	int GetGyroInternal() { }

	// RVA: 0x1564F64
	Gyroscope get_gyro() { }

	// RVA: 0x1565054
	bool CheckDisabled() { }

	// RVA: 0x1564878
	void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x1564948
	void GetLastPenContactEvent_Injected(out PenData ret) { }

	// RVA: 0x1564B10
	void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x1564BB0
	void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x1564D20
	void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x1564DD4
	void set_compositionCursorPos_Injected(ref Vector2 value) { }

}

// Namespace: 
private struct HitInfo 
{
	// Fields
	public GameObject target; // 0x10
	public Camera camera; // 0x18

	// Methods

	// RVA: 0x1566938
	void SendMessage(string name) { }

	// RVA: 0x1566878
	bool op_Implicit(HitInfo exists) { }

	// RVA: 0x1566960
	bool Compare(HitInfo lhs, HitInfo rhs) { }

}

// Namespace: UnityEngine
internal class SendMouseEvents 
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly HitInfo[] m_LastHit; // 0x8
	private static readonly HitInfo[] m_MouseDownHit; // 0x10
	private static readonly HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20
	public static System.Func<System.Collections.Generic.KeyValuePair<System.Int32,UnityEngine.Vector2>> s_GetMouseState; // 0x28
	private static Vector2 s_MousePosition; // 0x30
	private static bool s_MouseButtonPressedThisFrame; // 0x38
	private static bool s_MouseButtonIsPressed; // 0x39

	// Methods

	// RVA: 0x1565094
	void UpdateMouse() { }

	// RVA: 0x15654AC
	void SetMouseMoved() { }

	// RVA: 0x1565530
	void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x1565F1C
	void SendEvents(int i, HitInfo hit) { }

	// RVA: 0x1566A34
	void .cctor() { }

}

// Namespace: UnityEngine.Internal
internal static class InputUnsafeUtility 
{
	// Methods

	// RVA: 0x1566AF8
	bool GetKeyString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x1566B60
	bool GetKeyUpString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x1566BC8
	bool GetKeyDownString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x15644D4
	float GetAxis(string axisName) { }

	// RVA: 0x1566C30
	float GetAxis__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x1564574
	float GetAxisRaw(string axisName) { }

	// RVA: 0x1566C98
	float GetAxisRaw__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x1566D00
	bool GetButton__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x1564614
	bool GetButtonDown(string buttonName) { }

	// RVA: 0x1566D68
	Byte GetButtonDown__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x1566DD0
	bool GetButtonUp__Unmanaged(Byte* buttonName, int buttonNameLen) { }

}


