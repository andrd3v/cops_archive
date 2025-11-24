// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public enum ForceMode
{
	// Fields
	public int value__; // 0x10
	public const ForceMode Force = 0;
	public const ForceMode Acceleration = 5;
	public const ForceMode Impulse = 1;
	public const ForceMode VelocityChange = 2;
}

// Namespace: UnityEngine
public class ControllerColliderHit
{
	// Fields
	internal CharacterController m_Controller; // 0x10
	internal Collider m_Collider; // 0x18
	internal Vector3 m_Point; // 0x20
	internal Vector3 m_Normal; // 0x2C
	internal Vector3 m_MoveDirection; // 0x38
	internal float m_MoveLength; // 0x44
	internal int m_Push; // 0x48
}

// Namespace: UnityEngine
public class Collision
{
	// Fields
	private ContactPairHeader m_Header; // 0x10
	private ContactPair m_Pair; // 0x38
	private bool m_Flipped; // 0x60
	private ContactPoint[] m_LegacyContacts; // 0x68

	// Methods

	// RVA: 0x1655214
	public Component get_body() { }

	// RVA: 0x1655460
	public Collider get_collider() { }

	// RVA: 0x1655694
	public GameObject get_gameObject() { }

	// RVA: 0x165575C
	internal void set_Flipped(bool value) { }

	// RVA: 0x1655764
	public ContactPoint[] get_contacts() { }

	// RVA: 0x165589C
	public void .ctor() { }

	// RVA: 0x16558F8
	internal void .ctor(ContactPairHeader header, ContactPair pair, bool flipped) { }

	// RVA: 0x16559F0
	internal void Reuse(ContactPairHeader header, ContactPair pair) { }

}

// Namespace: UnityEngine
public enum QueryTriggerInteraction
{
	// Fields
	public int value__; // 0x10
	public const QueryTriggerInteraction UseGlobal = 0;
	public const QueryTriggerInteraction Ignore = 1;
	public const QueryTriggerInteraction Collide = 2;
}

// Namespace: UnityEngine
public class ArticulationBody
{
	// Methods

	// RVA: 0x1655A40
	public void .ctor() { }

}

// Namespace: 
public sealed class ContactEventDelegate
{
	// Methods

	// RVA: 0x165C268
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x165C30C
	public virtual void Invoke(PhysicsScene scene, ReadOnly headerArray) { }

}

// Namespace: UnityEngine
public class Physics
{
	// Fields
	private static System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent; // 0x0
	private static System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD; // 0x8
	private static ContactEventDelegate ContactEvent; // 0x10
	private static readonly Collision s_ReusableCollision; // 0x18

	// Methods

	// RVA: 0x1655A48
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	// RVA: 0x1655B68
	public static Vector3 get_gravity() { }

	// RVA: 0x1655C6C
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x1655CAC
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x1655DA4
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1656120
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x1656288
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x16563E4
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x1656538
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16568D8
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1656A48
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1656BB4
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo) { }

	// RVA: 0x1656D18
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1656E54
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x1656F84
	public static bool Raycast(Ray ray, float maxDistance) { }

	// RVA: 0x16570B0
	public static bool Raycast(Ray ray) { }

	// RVA: 0x16571D4
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1657318
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x16573DC
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1657510
	public static bool Raycast(Ray ray, RaycastHit hitInfo) { }

	// RVA: 0x165763C
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1657800
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	// RVA: 0x16578AC
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1657A4C
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1657E0C
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1657ED8
	public static bool SphereCast(Ray ray, float radius, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1657FA8
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16580F8
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1658454
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x1658510
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x16585C0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x1658668
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1658728
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x16587DC
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	// RVA: 0x165888C
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x1658934
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1658D04
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x1658E44
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x1658F78
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x16590A4
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1659220
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x1659390
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x16594FC
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0x1659660
	private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16597C0
	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1659998
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1659AE4
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1659C94
	public static Collider[] OverlapSphere(Vector3 position, float radius) { }

	// RVA: 0x1659D1C
	public static bool get_reuseCollisionCallbacks() { }

	// RVA: 0x1659D5C
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x1659EF4
	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x165A0B0
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165A2B0
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x165A34C
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165A498
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165A648
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x165A6DC
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165A83C
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165AA14
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	// RVA: 0x165AAD0
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165AD04
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x165ADC8
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	// RVA: 0x165AE18
	internal static Component GetBodyByInstanceID(int instanceID) { }

	// RVA: 0x165AE68
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	// RVA: 0x165AED0
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	// RVA: 0x165AF38
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	// RVA: 0x165AFA0
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x165B27C
	private static void ReportContacts(ReadOnly array) { }

	// RVA: 0x165C02C
	private static Collision GetCollisionToReport(ContactPairHeader header, ContactPair pair, bool flipped) { }

	// RVA: 0x165C1AC
	private static void .cctor() { }

	// RVA: 0x1655C1C
	private static void get_gravity_Injected(Vector3 ret) { }

	// RVA: 0x1655D54
	private static void get_defaultPhysicsScene_Injected(PhysicsScene ret) { }

	// RVA: 0x1658080
	private static RaycastHit[] Internal_RaycastAll_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1659740
	private static Collider[] OverlapCapsule_Internal_Injected(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1659A6C
	private static Collider[] OverlapSphere_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1659E5C
	private static bool Query_ComputePenetration_Injected(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x165A420
	private static bool CheckSphere_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165A7BC
	private static bool CheckCapsule_Internal_Injected(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}

// Namespace: UnityEngine
public struct ModifiableContactPair
{
	// Fields
	private IntPtr actor; // 0x10
	private IntPtr otherActor; // 0x18
	private IntPtr shape; // 0x20
	private IntPtr otherShape; // 0x28
	public Quaternion rotation; // 0x30
	public Vector3 position; // 0x40
	public Quaternion otherRotation; // 0x4C
	public Vector3 otherPosition; // 0x5C
	private int numContacts; // 0x68
	private IntPtr contacts; // 0x70
}

// Namespace: UnityEngine
public class PhysicMaterial
{
	// Methods

	// RVA: 0x165C324
	public void .ctor() { }

	// RVA: 0x165C3E4
	private static void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name) { }

}

// Namespace: UnityEngine
public struct RaycastHit
{
	// Fields
	internal Vector3 m_Point; // 0x10
	internal Vector3 m_Normal; // 0x1C
	internal UInt32 m_FaceID; // 0x28
	internal float m_Distance; // 0x2C
	internal Vector2 m_UV; // 0x30
	internal int m_Collider; // 0x38

	// Methods

	// RVA: 0x165C44C
	public Collider get_collider() { }

	// RVA: 0x165C540
	public Vector3 get_point() { }

	// RVA: 0x165C54C
	public Vector3 get_normal() { }

	// RVA: 0x165C558
	public float get_distance() { }

}

// Namespace: UnityEngine
public class Rigidbody
{
	// Methods

	// RVA: 0x165C560
	public Vector3 get_velocity() { }

	// RVA: 0x165C628
	public void set_velocity(Vector3 value) { }

	// RVA: 0x165C6E8
	public Vector3 get_angularVelocity() { }

	// RVA: 0x165C7B0
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x165C870
	public void SetDensity(float density) { }

	// RVA: 0x165C8D8
	public void set_useGravity(bool value) { }

	// RVA: 0x165C940
	public bool get_isKinematic() { }

	// RVA: 0x165C990
	public void set_isKinematic(bool value) { }

	// RVA: 0x165C9F8
	public Vector3 get_position() { }

	// RVA: 0x165CAC0
	public void set_position(Vector3 value) { }

	// RVA: 0x165CB80
	public Quaternion get_rotation() { }

	// RVA: 0x165CC44
	public void set_rotation(Quaternion value) { }

	// RVA: 0x165CD04
	public void ResetCenterOfMass() { }

	// RVA: 0x165CD54
	public void ResetInertiaTensor() { }

	// RVA: 0x165CDA4
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	// RVA: 0x165CE64
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	// RVA: 0x165CF74
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	// RVA: 0x165CFF8
	public void .ctor() { }

	// RVA: 0x165C5C0
	private void get_velocity_Injected(Vector3 ret) { }

	// RVA: 0x165C680
	private void set_velocity_Injected(Vector3 value) { }

	// RVA: 0x165C748
	private void get_angularVelocity_Injected(Vector3 ret) { }

	// RVA: 0x165C808
	private void set_angularVelocity_Injected(Vector3 value) { }

	// RVA: 0x165CA58
	private void get_position_Injected(Vector3 ret) { }

	// RVA: 0x165CB18
	private void set_position_Injected(Vector3 value) { }

	// RVA: 0x165CBDC
	private void get_rotation_Injected(Quaternion ret) { }

	// RVA: 0x165CC9C
	private void set_rotation_Injected(Quaternion value) { }

	// RVA: 0x165CE0C
	private void AddRelativeForce_Injected(Vector3 force, ForceMode mode) { }

	// RVA: 0x165CEF4
	private void AddExplosionForce_Injected(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

}

// Namespace: UnityEngine
public class Collider
{
	// Methods

	// RVA: 0x165D000
	public bool get_enabled() { }

	// RVA: 0x165D050
	public void set_enabled(bool value) { }

	// RVA: 0x165D0B8
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x165D108
	public ArticulationBody get_attachedArticulationBody() { }

	// RVA: 0x165D158
	public bool get_isTrigger() { }

	// RVA: 0x165D1A8
	public void set_isTrigger(bool value) { }

	// RVA: 0x165D210
	public float get_contactOffset() { }

	// RVA: 0x165D260
	public void set_contactOffset(float value) { }

	// RVA: 0x165D2C8
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x165D38C
	public Bounds get_bounds() { }

	// RVA: 0x165D468
	public bool get_hasModifiableContacts() { }

	// RVA: 0x165D4B8
	public void set_hasModifiableContacts(bool value) { }

	// RVA: 0x165D520
	public bool get_providesContacts() { }

	// RVA: 0x165D570
	public void set_providesContacts(bool value) { }

	// RVA: 0x165D5D8
	public int get_layerOverridePriority() { }

	// RVA: 0x165D628
	public void set_layerOverridePriority(int value) { }

	// RVA: 0x165D690
	public LayerMask get_excludeLayers() { }

	// RVA: 0x165D750
	public void set_excludeLayers(LayerMask value) { }

	// RVA: 0x165D80C
	public LayerMask get_includeLayers() { }

	// RVA: 0x165D8CC
	public void set_includeLayers(LayerMask value) { }

	// RVA: 0x165D988
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x165D9D8
	public void set_sharedMaterial(PhysicMaterial value) { }

	// RVA: 0x165DA40
	public PhysicMaterial get_material() { }

	// RVA: 0x165DA90
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x165DAF8
	private RaycastHit Raycast(Ray ray, float maxDistance, bool hasHit) { }

	// RVA: 0x165DC10
	public bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x165DCC8
	private void Internal_ClosestPointOnBounds(Vector3 point, Vector3 outPos, float distance) { }

	// RVA: 0x165DDA0
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x165DE68
	public void .ctor() { }

	// RVA: 0x165D334
	private void ClosestPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x165D400
	private void get_bounds_Injected(Bounds ret) { }

	// RVA: 0x165D6E8
	private void get_excludeLayers_Injected(LayerMask ret) { }

	// RVA: 0x165D7A4
	private void set_excludeLayers_Injected(LayerMask value) { }

	// RVA: 0x165D864
	private void get_includeLayers_Injected(LayerMask ret) { }

	// RVA: 0x165D920
	private void set_includeLayers_Injected(LayerMask value) { }

	// RVA: 0x165DB98
	private void Raycast_Injected(Ray ray, float maxDistance, bool hasHit, RaycastHit ret) { }

	// RVA: 0x165DD38
	private void Internal_ClosestPointOnBounds_Injected(Vector3 point, Vector3 outPos, float distance) { }

}

// Namespace: UnityEngine
public class CharacterController
{}

// Namespace: UnityEngine
public class MeshCollider
{
	// Methods

	// RVA: 0x165DE70
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x165DED8
	public void set_convex(bool value) { }

}

// Namespace: UnityEngine
public class CapsuleCollider
{
	// Methods

	// RVA: 0x165DF40
	public Vector3 get_center() { }

	// RVA: 0x165E008
	public void set_center(Vector3 value) { }

	// RVA: 0x165E0C8
	public float get_radius() { }

	// RVA: 0x165E118
	public float get_height() { }

	// RVA: 0x165E168
	public void set_height(float value) { }

	// RVA: 0x165DFA0
	private void get_center_Injected(Vector3 ret) { }

	// RVA: 0x165E060
	private void set_center_Injected(Vector3 value) { }

}

// Namespace: UnityEngine
public class BoxCollider
{
	// Methods

	// RVA: 0x165E1D0
	public Vector3 get_center() { }

	// RVA: 0x165E298
	public Vector3 get_size() { }

	// RVA: 0x165E360
	public void set_size(Vector3 value) { }

	// RVA: 0x165E230
	private void get_center_Injected(Vector3 ret) { }

	// RVA: 0x165E2F8
	private void get_size_Injected(Vector3 ret) { }

	// RVA: 0x165E3B8
	private void set_size_Injected(Vector3 value) { }

}

// Namespace: UnityEngine
public class SphereCollider
{
	// Methods

	// RVA: 0x165E420
	public Vector3 get_center() { }

	// RVA: 0x165E4E8
	public float get_radius() { }

	// RVA: 0x165E538
	public void set_radius(float value) { }

	// RVA: 0x165E480
	private void get_center_Injected(Vector3 ret) { }

}

// Namespace: UnityEngine
public class Joint
{
	// Methods

	// RVA: 0x165E5A0
	public Rigidbody get_connectedBody() { }

	// RVA: 0x165E5F0
	public Vector3 get_anchor() { }

	// RVA: 0x165E6B8
	public Vector3 get_connectedAnchor() { }

	// RVA: 0x165E780
	public void set_autoConfigureConnectedAnchor(bool value) { }

	// RVA: 0x165E650
	private void get_anchor_Injected(Vector3 ret) { }

	// RVA: 0x165E718
	private void get_connectedAnchor_Injected(Vector3 ret) { }

}

// Namespace: UnityEngine
public class CharacterJoint
{}

// Namespace: UnityEngine
public struct ContactPoint
{
	// Fields
	internal Vector3 m_Point; // 0x10
	internal Vector3 m_Normal; // 0x1C
	internal Vector3 m_Impulse; // 0x28
	internal int m_ThisColliderInstanceID; // 0x34
	internal int m_OtherColliderInstanceID; // 0x38
	internal float m_Separation; // 0x3C

	// Methods

	// RVA: 0x165E7E8
	public Vector3 get_point() { }

	// RVA: 0x165E7F4
	public Vector3 get_normal() { }

}

// Namespace: UnityEngine
public struct PhysicsScene
{
	// Fields
	private int m_Handle; // 0x10

	// Methods

	// RVA: 0x165E800
	public override string ToString() { }

	// RVA: 0x165E8FC
	public override int GetHashCode() { }

	// RVA: 0x165E904
	public override bool Equals(object other) { }

	// RVA: 0x165E994
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x1655F10
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165E9A4
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16566B4
	public bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165EA98
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1658A78
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165EBA4
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165ECB0
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165EDFC
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1657A30
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165EFA0
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165AC6C
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165F0C4
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165F1F8
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1657C9C
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165F368
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165A224
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165EA20
	private static bool Internal_RaycastTest_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165EB24
	private static bool Internal_Raycast_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165EC30
	private static int Internal_RaycastNonAlloc_Injected(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165ED5C
	private static bool Query_CapsuleCast_Injected(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165F034
	private static int OverlapCapsuleNonAlloc_Internal_Injected(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165F160
	private static bool Query_SphereCast_Injected(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x165F3F0
	private static int OverlapSphereNonAlloc_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

}

// Namespace: UnityEngine
public struct ContactPairHeader
{
	// Fields
	internal readonly int m_BodyID; // 0x10
	internal readonly int m_OtherBodyID; // 0x14
	internal readonly IntPtr m_StartPtr; // 0x18
	internal readonly UInt32 m_NbPairs; // 0x20
	internal readonly CollisionPairHeaderFlags m_Flags; // 0x24
	internal readonly Vector3 m_RelativeVelocity; // 0x28

	// Methods

	// RVA: 0x16553AC
	public Component get_Body() { }

	// RVA: 0x16552F8
	public Component get_OtherBody() { }

	// RVA: 0x165BFFC
	internal bool get_HasRemovedBody() { }

	// RVA: 0x165C00C
	public ContactPair GetContactPair(int index) { }

	// RVA: 0x165F470
	internal ContactPair* GetContactPair_Internal(int index) { }

}

// Namespace: UnityEngine
public struct ContactPair
{
	// Fields
	internal readonly int m_ColliderID; // 0x10
	internal readonly int m_OtherColliderID; // 0x14
	internal readonly IntPtr m_StartPtr; // 0x18
	internal readonly UInt32 m_NbPoints; // 0x20
	internal readonly CollisionPairFlags m_Flags; // 0x24
	internal readonly CollisionPairEventFlags m_Events; // 0x26
	internal readonly Vector3 m_ImpulseSum; // 0x28

	// Methods

	// RVA: 0x16555E8
	public Collider get_Collider() { }

	// RVA: 0x165553C
	public Collider get_OtherCollider() { }

	// RVA: 0x165C020
	public bool get_IsCollisionEnter() { }

	// RVA: 0x165C1A0
	public bool get_IsCollisionExit() { }

	// RVA: 0x165C194
	public bool get_IsCollisionStay() { }

	// RVA: 0x165C010
	internal bool get_HasRemovedCollider() { }

	// RVA: 0x1655844
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x165F4FC
	private static int ExtractContactsArray_Injected(ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped) { }

}

// Namespace: UnityEngine
internal enum CollisionPairHeaderFlags
{
	// Fields
	public UInt16 value__; // 0x10
	public const CollisionPairHeaderFlags RemovedActor = 1;
	public const CollisionPairHeaderFlags RemovedOtherActor = 2;
}

// Namespace: UnityEngine
internal enum CollisionPairFlags
{
	// Fields
	public UInt16 value__; // 0x10
	public const CollisionPairFlags RemovedShape = 1;
	public const CollisionPairFlags RemovedOtherShape = 2;
	public const CollisionPairFlags ActorPairHasFirstTouch = 4;
	public const CollisionPairFlags ActorPairLostTouch = 8;
	public const CollisionPairFlags InternalHasImpulses = 16;
	public const CollisionPairFlags InternalContactsAreFlipped = 32;
}

// Namespace: UnityEngine
internal enum CollisionPairEventFlags
{
	// Fields
	public UInt16 value__; // 0x10
	public const CollisionPairEventFlags SolveContacts = 1;
	public const CollisionPairEventFlags ModifyContacts = 2;
	public const CollisionPairEventFlags NotifyTouchFound = 4;
	public const CollisionPairEventFlags NotifyTouchPersists = 8;
	public const CollisionPairEventFlags NotifyTouchLost = 16;
	public const CollisionPairEventFlags NotifyTouchCCD = 32;
	public const CollisionPairEventFlags NotifyThresholdForceFound = 64;
	public const CollisionPairEventFlags NotifyThresholdForcePersists = 128;
	public const CollisionPairEventFlags NotifyThresholdForceLost = 256;
	public const CollisionPairEventFlags NotifyContactPoint = 512;
	public const CollisionPairEventFlags DetectDiscreteContact = 1024;
	public const CollisionPairEventFlags DetectCCDContact = 2048;
	public const CollisionPairEventFlags PreSolverVelocity = 4096;
	public const CollisionPairEventFlags PostSolverVelocity = 8192;
	public const CollisionPairEventFlags ContactEventPose = 16384;
	public const CollisionPairEventFlags NextFree = 32768;
	public const CollisionPairEventFlags ContactDefault = 1025;
	public const CollisionPairEventFlags TriggerDefault = 1044;
}


