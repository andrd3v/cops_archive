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

	// RVA: 0x1648704
	public int get_fingerId() { }

	// RVA: 0x164870C
	public Vector2 get_position() { }

	// RVA: 0x1648714
	public void set_position(Vector2 value) { }

	// RVA: 0x164871C
	public Vector2 get_rawPosition() { }

	// RVA: 0x1648724
	public void set_rawPosition(Vector2 value) { }

	// RVA: 0x164872C
	public Vector2 get_deltaPosition() { }

	// RVA: 0x1648734
	public void set_deltaPosition(Vector2 value) { }

	// RVA: 0x164873C
	public float get_deltaTime() { }

	// RVA: 0x1648744
	public int get_tapCount() { }

	// RVA: 0x164874C
	public TouchPhase get_phase() { }

	// RVA: 0x1648754
	public float get_pressure() { }

	// RVA: 0x164875C
	public float get_maximumPossiblePressure() { }

	// RVA: 0x1648764
	public TouchType get_type() { }

	// RVA: 0x164876C
	public float get_altitudeAngle() { }

	// RVA: 0x1648774
	public float get_azimuthAngle() { }

	// RVA: 0x164877C
	public float get_radius() { }

	// RVA: 0x1648784
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

	// RVA: 0x164878C
	internal void .ctor(int index) { }

	// RVA: 0x16487B8
	private static Vector3 rotationRateUnbiased_Internal(int idx) { }

	// RVA: 0x1648880
	private static bool getEnabled_Internal(int idx) { }

	// RVA: 0x16488D0
	private static void setEnabled_Internal(int idx, bool enabled) { }

	// RVA: 0x1648938
	public Vector3 get_rotationRateUnbiased() { }

	// RVA: 0x1648998
	public bool get_enabled() { }

	// RVA: 0x16489E8
	public void set_enabled(bool value) { }

	// RVA: 0x1648818
	private static void rotationRateUnbiased_Internal_Injected(int idx, Vector3 ret) { }

}

// Namespace: UnityEngine
internal class CameraRaycastHelper
{
	// Methods

	// RVA: 0x1648A50
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1648B20
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1648AB8
	private static GameObject RaycastTry_Injected(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1648B88
	private static GameObject RaycastTry2D_Injected(Camera cam, Ray ray, float distance, int layerMask) { }

}

// Namespace: UnityEngine
public class Input
{
	// Fields
	private static Gyroscope s_MainGyro; // 0x0

	// Methods

	// RVA: 0x1648BF0
	public static float GetAxis(string axisName) { }

	// RVA: 0x1648C90
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x1648D30
	public static bool GetButtonDown(string buttonName) { }

	// RVA: 0x1648DD0
	private static bool GetKeyInt(KeyCode key) { }

	// RVA: 0x1648E20
	private static bool GetKeyDownInt(KeyCode key) { }

	// RVA: 0x1648E70
	public static bool GetMouseButton(int button) { }

	// RVA: 0x1648EC0
	public static bool GetMouseButtonDown(int button) { }

	// RVA: 0x1648F10
	public static bool GetMouseButtonUp(int button) { }

	// RVA: 0x1648F60
	public static Touch GetTouch(int index) { }

	// RVA: 0x164904C
	public static PenData GetLastPenContactEvent() { }

	// RVA: 0x1649104
	public static void ClearLastPenContactEvent() { }

	// RVA: 0x1649144
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x1649194
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x16491E4
	public static bool get_anyKey() { }

	// RVA: 0x1649224
	public static Vector3 get_mousePosition() { }

	// RVA: 0x16492CC
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x164936C
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x16493AC
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x16493FC
	public static string get_compositionString() { }

	// RVA: 0x164943C
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x16494DC
	public static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1649590
	public static bool get_mousePresent() { }

	// RVA: 0x16495D0
	public static int get_touchCount() { }

	// RVA: 0x1649610
	public static bool get_touchPressureSupported() { }

	// RVA: 0x1649650
	public static bool get_touchSupported() { }

	// RVA: 0x1649690
	private static int GetGyroInternal() { }

	// RVA: 0x16496D0
	public static Gyroscope get_gyro() { }

	// RVA: 0x16497C0
	internal static bool CheckDisabled() { }

	// RVA: 0x1648FE4
	private static void GetTouch_Injected(int index, Touch ret) { }

	// RVA: 0x16490B4
	private static void GetLastPenContactEvent_Injected(PenData ret) { }

	// RVA: 0x164927C
	private static void get_mousePosition_Injected(Vector3 ret) { }

	// RVA: 0x164931C
	private static void get_mouseScrollDelta_Injected(Vector2 ret) { }

	// RVA: 0x164948C
	private static void get_compositionCursorPos_Injected(Vector2 ret) { }

	// RVA: 0x1649540
	private static void set_compositionCursorPos_Injected(Vector2 value) { }

}

// Namespace: 
private struct HitInfo
{
	// Fields
	public GameObject target; // 0x10
	public Camera camera; // 0x18

	// Methods

	// RVA: 0x164B0A4
	public void SendMessage(string name) { }

	// RVA: 0x164AFE4
	public static bool op_Implicit(HitInfo exists) { }

	// RVA: 0x164B0CC
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

	// RVA: 0x1649800
	private static void UpdateMouse() { }

	// RVA: 0x1649C18
	private static void SetMouseMoved() { }

	// RVA: 0x1649C9C
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x164A688
	private static void SendEvents(int i, HitInfo hit) { }

	// RVA: 0x164B1A0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Internal
internal static class InputUnsafeUtility
{
	// Methods

	// RVA: 0x164B264
	internal static bool GetKeyString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x164B2CC
	internal static bool GetKeyUpString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x164B334
	internal static bool GetKeyDownString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x1648C40
	internal static float GetAxis(string axisName) { }

	// RVA: 0x164B39C
	internal static float GetAxis__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x1648CE0
	internal static float GetAxisRaw(string axisName) { }

	// RVA: 0x164B404
	internal static float GetAxisRaw__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x164B46C
	internal static bool GetButton__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x1648D80
	internal static bool GetButtonDown(string buttonName) { }

	// RVA: 0x164B4D4
	internal static Byte GetButtonDown__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x164B53C
	internal static bool GetButtonUp__Unmanaged(Byte* buttonName, int buttonNameLen) { }

}


