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

	// RVA: 0x167AAF8
	public int get_fingerId() { }

	// RVA: 0x167AB00
	public Vector2 get_position() { }

	// RVA: 0x167AB08
	public void set_position(Vector2 value) { }

	// RVA: 0x167AB10
	public Vector2 get_rawPosition() { }

	// RVA: 0x167AB18
	public void set_rawPosition(Vector2 value) { }

	// RVA: 0x167AB20
	public Vector2 get_deltaPosition() { }

	// RVA: 0x167AB28
	public void set_deltaPosition(Vector2 value) { }

	// RVA: 0x167AB30
	public float get_deltaTime() { }

	// RVA: 0x167AB38
	public int get_tapCount() { }

	// RVA: 0x167AB40
	public TouchPhase get_phase() { }

	// RVA: 0x167AB48
	public float get_pressure() { }

	// RVA: 0x167AB50
	public float get_maximumPossiblePressure() { }

	// RVA: 0x167AB58
	public TouchType get_type() { }

	// RVA: 0x167AB60
	public float get_altitudeAngle() { }

	// RVA: 0x167AB68
	public float get_azimuthAngle() { }

	// RVA: 0x167AB70
	public float get_radius() { }

	// RVA: 0x167AB78
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

	// RVA: 0x167AB80
	internal void .ctor(int index) { }

	// RVA: 0x167ABAC
	private static Vector3 rotationRateUnbiased_Internal(int idx) { }

	// RVA: 0x167AC74
	private static bool getEnabled_Internal(int idx) { }

	// RVA: 0x167ACC4
	private static void setEnabled_Internal(int idx, bool enabled) { }

	// RVA: 0x167AD2C
	public Vector3 get_rotationRateUnbiased() { }

	// RVA: 0x167AD8C
	public bool get_enabled() { }

	// RVA: 0x167ADDC
	public void set_enabled(bool value) { }

	// RVA: 0x167AC0C
	private static void rotationRateUnbiased_Internal_Injected(int idx, Vector3 ret) { }

}

// Namespace: UnityEngine
internal class CameraRaycastHelper
{
	// Methods

	// RVA: 0x167AE44
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x167AF14
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x167AEAC
	private static GameObject RaycastTry_Injected(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x167AF7C
	private static GameObject RaycastTry2D_Injected(Camera cam, Ray ray, float distance, int layerMask) { }

}

// Namespace: UnityEngine
public class Input
{
	// Fields
	private static Gyroscope s_MainGyro; // 0x0

	// Methods

	// RVA: 0x167AFE4
	public static float GetAxis(string axisName) { }

	// RVA: 0x167B084
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x167B124
	public static bool GetButtonDown(string buttonName) { }

	// RVA: 0x167B1C4
	private static bool GetKeyInt(KeyCode key) { }

	// RVA: 0x167B214
	private static bool GetKeyDownInt(KeyCode key) { }

	// RVA: 0x167B264
	public static bool GetMouseButton(int button) { }

	// RVA: 0x167B2B4
	public static bool GetMouseButtonDown(int button) { }

	// RVA: 0x167B304
	public static bool GetMouseButtonUp(int button) { }

	// RVA: 0x167B354
	public static Touch GetTouch(int index) { }

	// RVA: 0x167B440
	public static PenData GetLastPenContactEvent() { }

	// RVA: 0x167B4F8
	public static void ClearLastPenContactEvent() { }

	// RVA: 0x167B538
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x167B588
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x167B5D8
	public static bool get_anyKey() { }

	// RVA: 0x167B618
	public static Vector3 get_mousePosition() { }

	// RVA: 0x167B6C0
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x167B760
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x167B7A0
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x167B7F0
	public static string get_compositionString() { }

	// RVA: 0x167B830
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x167B8D0
	public static void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x167B984
	public static bool get_mousePresent() { }

	// RVA: 0x167B9C4
	public static int get_touchCount() { }

	// RVA: 0x167BA04
	public static bool get_touchPressureSupported() { }

	// RVA: 0x167BA44
	public static bool get_touchSupported() { }

	// RVA: 0x167BA84
	private static int GetGyroInternal() { }

	// RVA: 0x167BAC4
	public static Gyroscope get_gyro() { }

	// RVA: 0x167BBB4
	internal static bool CheckDisabled() { }

	// RVA: 0x167B3D8
	private static void GetTouch_Injected(int index, Touch ret) { }

	// RVA: 0x167B4A8
	private static void GetLastPenContactEvent_Injected(PenData ret) { }

	// RVA: 0x167B670
	private static void get_mousePosition_Injected(Vector3 ret) { }

	// RVA: 0x167B710
	private static void get_mouseScrollDelta_Injected(Vector2 ret) { }

	// RVA: 0x167B880
	private static void get_compositionCursorPos_Injected(Vector2 ret) { }

	// RVA: 0x167B934
	private static void set_compositionCursorPos_Injected(Vector2 value) { }

}

// Namespace: 
private struct HitInfo
{
	// Fields
	public GameObject target; // 0x10
	public Camera camera; // 0x18

	// Methods

	// RVA: 0x167D498
	public void SendMessage(string name) { }

	// RVA: 0x167D3D8
	public static bool op_Implicit(HitInfo exists) { }

	// RVA: 0x167D4C0
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

	// RVA: 0x167BBF4
	private static void UpdateMouse() { }

	// RVA: 0x167C00C
	private static void SetMouseMoved() { }

	// RVA: 0x167C090
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x167CA7C
	private static void SendEvents(int i, HitInfo hit) { }

	// RVA: 0x167D594
	private static void .cctor() { }

}

// Namespace: UnityEngine.Internal
internal static class InputUnsafeUtility
{
	// Methods

	// RVA: 0x167D658
	internal static bool GetKeyString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x167D6C0
	internal static bool GetKeyUpString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x167D728
	internal static bool GetKeyDownString__Unmanaged(Byte* name, int nameLen) { }

	// RVA: 0x167B034
	internal static float GetAxis(string axisName) { }

	// RVA: 0x167D790
	internal static float GetAxis__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x167B0D4
	internal static float GetAxisRaw(string axisName) { }

	// RVA: 0x167D7F8
	internal static float GetAxisRaw__Unmanaged(Byte* axisName, int axisNameLen) { }

	// RVA: 0x167D860
	internal static bool GetButton__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x167B174
	internal static bool GetButtonDown(string buttonName) { }

	// RVA: 0x167D8C8
	internal static Byte GetButtonDown__Unmanaged(Byte* buttonName, int buttonNameLen) { }

	// RVA: 0x167D930
	internal static bool GetButtonUp__Unmanaged(Byte* buttonName, int buttonNameLen) { }

}


