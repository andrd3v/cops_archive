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

	// RVA: 0x1657974
	public int get_fingerId() { }

	// RVA: 0x165797C
	public Vector2 get_position() { }

	// RVA: 0x1657984
	public void set_position(Vector2 value) { }

	// RVA: 0x165798C
	public Vector2 get_rawPosition() { }

	// RVA: 0x1657994
	public void set_rawPosition(Vector2 value) { }

	// RVA: 0x165799C
	public Vector2 get_deltaPosition() { }

	// RVA: 0x16579A4
	public void set_deltaPosition(Vector2 value) { }

	// RVA: 0x16579AC
	public float get_deltaTime() { }

	// RVA: 0x16579B4
	public int get_tapCount() { }

	// RVA: 0x16579BC
	public TouchPhase get_phase() { }

	// RVA: 0x16579C4
	public float get_pressure() { }

	// RVA: 0x16579CC
	public float get_maximumPossiblePressure() { }

	// RVA: 0x16579D4
	public TouchType get_type() { }

	// RVA: 0x16579DC
	public float get_altitudeAngle() { }

	// RVA: 0x16579E4
	public float get_azimuthAngle() { }

	// RVA: 0x16579EC
	public float get_radius() { }

	// RVA: 0x16579F4
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

	// RVA: 0x16579FC
	internal void .ctor(int index) { }

	// RVA: 0x1657A28
	private static Vector3 rotationRateUnbiased_Internal(int idx) { }

	// RVA: 0x1657AF0
	private static bool getEnabled_Internal(int idx) { }

	// RVA: 0x1657B40
	private static void setEnabled_Internal(int idx, bool enabled) { }

	// RVA: 0x1657BA8
	public Vector3 get_rotationRateUnbiased() { }

	// RVA: 0x1657C08
	public bool get_enabled() { }

	// RVA: 0x1657C58
	public void set_enabled(bool value) { }

	// RVA: 0x1657A88
	private static void rotationRateUnbiased_Internal_Injected(int idx, Vector3 ret) { }

}

// Namespace: UnityEngine
internal class CameraRaycastHelper
{
	// Methods

	// RVA: 0x1657CC0
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1657D90
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1657D28
	private static GameObject RaycastTry_Injected(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1657DF8
	private static GameObject RaycastTry2D_Injected(Camera cam, Ray ray, float distance, int layerMask) { }

}

// Namespace: UnityEngine
public class Input
{
	// Fields
	private static Gyroscope s_MainGyro; // 0x0

	// Methods

	// RVA: 0x1657E60
	public static float GetAxis(string axisName) { }

	// RVA: 0x1657F00
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x1657FA0
	public static bool GetButtonDown(string buttonName) { }

	// RVA: 0x1658040
	private static bool GetKeyInt(KeyCode key) { }

	// RVA: 0x1658090
	private static bool GetKeyDownInt(KeyCode key) { }

	// RVA: 0x16580E0
	public static bool GetMouseButton(int button) { }

	// RVA: 0x1658130
	public static bool GetMouseButtonDown(int button) { }

	// RVA: 0x1658180
	public static bool GetMouseButtonUp(int button) { }

	// RVA: 0x16581D0
	public static Touch GetTouch(int index) { }

	// RVA: 0x16582BC
	public static PenData GetLastPenContactEvent() { }

	// RVA: 0x1658374
	public static void ClearLastPenContactEvent() { }

	// RVA: 0x16583B4
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x1658404
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x1658454
	public static bool get_anyKey() { }

	// RVA: 0x1658494
	public static Vector3 get_mousePosition() { }

	// RVA: 0x165853C
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x16585DC
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x165861C
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x165866C
	public static string get_compositionString() { }

	// RVA: 0x16586AC
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x165874C
	public static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1658800
	public static bool get_mousePresent() { }

	// RVA: 0x1658840
	public static int get_touchCount() { }

	// RVA: 0x1658880
	public static bool get_touchPressureSupported() { }

	// RVA: 0x16588C0
	public static bool get_touchSupported() { }

	// RVA: 0x1658900
	private static int GetGyroInternal() { }

	// RVA: 0x1658940
	public static Gyroscope get_gyro() { }

	// RVA: 0x1658A30
	internal static bool CheckDisabled() { }

	// RVA: 0x1658254
	private static void GetTouch_Injected(int index, Touch ret) { }

	// RVA: 0x1658324
	private static void GetLastPenContactEvent_Injected(PenData ret) { }

	// RVA: 0x16584EC
	private static void get_mousePosition_Injected(Vector3 ret) { }

	// RVA: 0x165858C
	private static void get_mouseScrollDelta_Injected(Vector2 ret) { }

	// RVA: 0x16586FC
	private static void get_compositionCursorPos_Injected(Vector2 ret) { }

	// RVA: 0x16587B0
	private static void set_compositionCursorPos_Injected(Vector2 value) { }

}

// Namespace: 
private struct HitInfo
{
	// Fields
	public GameObject target; // 0x10
	public Camera camera; // 0x18

	// Methods

	// RVA: 0x165A314
	public void SendMessage(string name) { }

	// RVA: 0x165A254
	public static bool op_Implicit(HitInfo exists) { }

	// RVA: 0x165A33C
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

	// RVA: 0x1658A70
	private static void UpdateMouse() { }

	// RVA: 0x1658E88
	private static void SetMouseMoved() { }

	// RVA: 0x1658F0C
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x16598F8
	private static void SendEvents(int i, HitInfo hit) { }

	// RVA: 0x165A410
	private static void .cctor() { }

}

// Namespace: UnityEngine.Internal
internal static class InputUnsafeUtility
{
	// Methods

	// RVA: 0x165A4D4
	internal static bool GetKeyString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x165A53C
	internal static bool GetKeyUpString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x165A5A4
	internal static bool GetKeyDownString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x1657EB0
	internal static float GetAxis(string axisName) { }

	// RVA: 0x165A60C
	internal static float GetAxis__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x1657F50
	internal static float GetAxisRaw(string axisName) { }

	// RVA: 0x165A674
	internal static float GetAxisRaw__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x165A6DC
	internal static bool GetButton__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x1657FF0
	internal static bool GetButtonDown(string buttonName) { }

	// RVA: 0x165A744
	internal static Byte GetButtonDown__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x165A7AC
	internal static bool GetButtonUp__Unmanaged(Byte* buttonName, int buttonNameLen) { }

}


