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

	// RVA: 0x1710888
	public int get_fingerId() { }

	// RVA: 0x1710890
	public Vector2 get_position() { }

	// RVA: 0x1710898
	public void set_position(Vector2 value) { }

	// RVA: 0x17108A0
	public Vector2 get_rawPosition() { }

	// RVA: 0x17108A8
	public void set_rawPosition(Vector2 value) { }

	// RVA: 0x17108B0
	public Vector2 get_deltaPosition() { }

	// RVA: 0x17108B8
	public void set_deltaPosition(Vector2 value) { }

	// RVA: 0x17108C0
	public float get_deltaTime() { }

	// RVA: 0x17108C8
	public int get_tapCount() { }

	// RVA: 0x17108D0
	public TouchPhase get_phase() { }

	// RVA: 0x17108D8
	public float get_pressure() { }

	// RVA: 0x17108E0
	public float get_maximumPossiblePressure() { }

	// RVA: 0x17108E8
	public TouchType get_type() { }

	// RVA: 0x17108F0
	public float get_altitudeAngle() { }

	// RVA: 0x17108F8
	public float get_azimuthAngle() { }

	// RVA: 0x1710900
	public float get_radius() { }

	// RVA: 0x1710908
	public float get_radiusVariance() { }

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

	// RVA: 0x1710910
	internal void .ctor(int index) { }

	// RVA: 0x171093C
	private static Vector3 rotationRateUnbiased_Internal(int idx) { }

	// RVA: 0x1710A04
	private static bool getEnabled_Internal(int idx) { }

	// RVA: 0x1710A54
	private static void setEnabled_Internal(int idx, bool enabled) { }

	// RVA: 0x1710ABC
	public Vector3 get_rotationRateUnbiased() { }

	// RVA: 0x1710B1C
	public bool get_enabled() { }

	// RVA: 0x1710B6C
	public void set_enabled(bool value) { }

	// RVA: 0x171099C
	private static void rotationRateUnbiased_Internal_Injected(int idx, Vector3 ret) { }

}

// Namespace: UnityEngine
internal class CameraRaycastHelper
{
	// Methods

	// RVA: 0x1710BD4
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1710D1C
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1710CB4
	private static IntPtr RaycastTry_Injected(IntPtr cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1710DFC
	private static IntPtr RaycastTry2D_Injected(IntPtr cam, Ray ray, float distance, int layerMask) { }

}

// Namespace: UnityEngine
public class Input
{
	// Fields
	private static bool <simulateTouchEnabled>k__BackingField; // 0x0
	private static Gyroscope s_MainGyro; // 0x8

	// Methods

	// RVA: 0x1710E64
	public static float GetAxis(string axisName) { }

	// RVA: 0x1710FE0
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x171115C
	public static bool GetButtonDown(string buttonName) { }

	// RVA: 0x17112E8
	private static bool GetKeyInt(KeyCode key) { }

	// RVA: 0x1711338
	private static bool GetKeyDownInt(KeyCode key) { }

	// RVA: 0x1711388
	public static bool GetMouseButton(int button) { }

	// RVA: 0x17113D8
	public static bool GetMouseButtonDown(int button) { }

	// RVA: 0x1711428
	public static bool GetMouseButtonUp(int button) { }

	// RVA: 0x1711478
	public static Touch GetTouch(int index) { }

	// RVA: 0x1711564
	public static PenData GetLastPenContactEvent() { }

	// RVA: 0x171161C
	public static void ClearLastPenContactEvent() { }

	// RVA: 0x171165C
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x17116AC
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x17116FC
	public static bool get_anyKey() { }

	// RVA: 0x171173C
	public static Vector3 get_mousePosition() { }

	// RVA: 0x17117E4
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x1711884
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x17118C4
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1711914
	public static string get_compositionString() { }

	// RVA: 0x1711A44
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x1711AE4
	public static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1711B98
	internal static bool get_simulateTouchEnabled() { }

	// RVA: 0x1711BE4
	private static bool GetMousePresentInternal() { }

	// RVA: 0x1711C24
	private static bool GetTouchSupportedInternal() { }

	// RVA: 0x1711C64
	public static bool get_mousePresent() { }

	// RVA: 0x1711D04
	public static bool get_touchSupported() { }

	// RVA: 0x1711DA4
	public static int get_touchCount() { }

	// RVA: 0x1711DE4
	public static bool get_touchPressureSupported() { }

	// RVA: 0x1711E24
	private static int GetGyroInternal() { }

	// RVA: 0x1711E64
	public static Gyroscope get_gyro() { }

	// RVA: 0x1711F4C
	internal static bool CheckDisabled() { }

	// RVA: 0x17114FC
	private static void GetTouch_Injected(int index, Touch ret) { }

	// RVA: 0x17115CC
	private static void GetLastPenContactEvent_Injected(PenData ret) { }

	// RVA: 0x1711794
	private static void get_mousePosition_Injected(Vector3 ret) { }

	// RVA: 0x1711834
	private static void get_mouseScrollDelta_Injected(Vector2 ret) { }

	// RVA: 0x17119F4
	private static void get_compositionString_Injected(ManagedSpanWrapper ret) { }

	// RVA: 0x1711A94
	private static void get_compositionCursorPos_Injected(Vector2 ret) { }

	// RVA: 0x1711B48
	private static void set_compositionCursorPos_Injected(Vector2 value) { }

}

// Namespace: 
private struct HitInfo
{
	// Fields
	public GameObject target; // 0x10
	public Camera camera; // 0x18

	// Methods

	// RVA: 0x1713940
	public void SendMessage(string name) { }

	// RVA: 0x1713880
	public static bool op_Implicit(HitInfo exists) { }

	// RVA: 0x1713968
	public static bool Compare(HitInfo lhs, HitInfo rhs) { }

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

	// RVA: 0x1711F8C
	private static void UpdateMouse() { }

	// RVA: 0x17123A4
	private static void SetMouseMoved() { }

	// RVA: 0x1712428
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x1712F24
	private static void SendEvents(int i, HitInfo hit) { }

	// RVA: 0x1713A3C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Internal
internal static class InputUnsafeUtility
{
	// Methods

	// RVA: 0x1713B00
	internal static bool GetKeyString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x1713B68
	internal static bool GetKeyUpString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x1713BD0
	internal static bool GetKeyDownString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x1710E68
	internal static float GetAxis(string axisName) { }

	// RVA: 0x1713C88
	internal static float GetAxis__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x1710FE4
	internal static float GetAxisRaw(string axisName) { }

	// RVA: 0x1713D40
	internal static float GetAxisRaw__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x1713DA8
	internal static bool GetButton__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x1711160
	internal static bool GetButtonDown(string buttonName) { }

	// RVA: 0x1713E60
	internal static Byte GetButtonDown__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x1713EC8
	internal static bool GetButtonUp__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x1713C38
	private static float GetAxis_Injected(ManagedSpanWrapper axisName) { }

	// RVA: 0x1713CF0
	private static float GetAxisRaw_Injected(ManagedSpanWrapper axisName) { }

	// RVA: 0x1713E10
	private static bool GetButtonDown_Injected(ManagedSpanWrapper buttonName) { }

}


