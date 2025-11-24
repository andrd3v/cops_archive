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

	// RVA: 0x1664484
	public Component get_body() { }

	// RVA: 0x16646D0
	public Collider get_collider() { }

	// RVA: 0x1664904
	public GameObject get_gameObject() { }

	// RVA: 0x16649CC
	internal void set_Flipped(bool value) { }

	// RVA: 0x16649D4
	public ContactPoint[] get_contacts() { }

	// RVA: 0x1664B0C
	public void .ctor() { }

	// RVA: 0x1664B68
	internal void .ctor(ContactPairHeader header, ContactPair pair, bool flipped) { }

	// RVA: 0x1664C60
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

	// RVA: 0x1664CB0
	public void .ctor() { }

}

// Namespace: 
public sealed class ContactEventDelegate
{
	// Methods

	// RVA: 0x166B4D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x166B57C
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

	// RVA: 0x1664CB8
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	// RVA: 0x1664DD8
	public static Vector3 get_gravity() { }

	// RVA: 0x1664EDC
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x1664F1C
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x1665014
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1665390
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x16654F8
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x1665654
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x16657A8
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1665B48
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1665CB8
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1665E24
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo) { }

	// RVA: 0x1665F88
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16660C4
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x16661F4
	public static bool Raycast(Ray ray, float maxDistance) { }

	// RVA: 0x1666320
	public static bool Raycast(Ray ray) { }

	// RVA: 0x1666444
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1666588
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x166664C
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1666780
	public static bool Raycast(Ray ray, RaycastHit hitInfo) { }

	// RVA: 0x16668AC
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1666A70
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	// RVA: 0x1666B1C
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1666CBC
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166707C
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1667148
	public static bool SphereCast(Ray ray, float radius, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1667218
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1667368
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16676C4
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x1667780
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x1667830
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x16678D8
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1667998
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x1667A4C
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	// RVA: 0x1667AFC
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x1667BA4
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1667F74
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x16680B4
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x16681E8
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x1668314
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1668490
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x1668600
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x166876C
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0x16688D0
	private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1668A30
	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1668C08
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1668D54
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1668F04
	public static Collider[] OverlapSphere(Vector3 position, float radius) { }

	// RVA: 0x1668F8C
	public static bool get_reuseCollisionCallbacks() { }

	// RVA: 0x1668FCC
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x1669164
	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x1669320
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1669520
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x16695BC
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1669708
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16698B8
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x166994C
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1669AAC
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1669C84
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	// RVA: 0x1669D40
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1669F74
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x166A038
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	// RVA: 0x166A088
	internal static Component GetBodyByInstanceID(int instanceID) { }

	// RVA: 0x166A0D8
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	// RVA: 0x166A140
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	// RVA: 0x166A1A8
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	// RVA: 0x166A210
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x166A4EC
	private static void ReportContacts(ReadOnly array) { }

	// RVA: 0x166B29C
	private static Collision GetCollisionToReport(ContactPairHeader header, ContactPair pair, bool flipped) { }

	// RVA: 0x166B41C
	private static void .cctor() { }

	// RVA: 0x1664E8C
	private static void get_gravity_Injected(Vector3 ret) { }

	// RVA: 0x1664FC4
	private static void get_defaultPhysicsScene_Injected(PhysicsScene ret) { }

	// RVA: 0x16672F0
	private static RaycastHit[] Internal_RaycastAll_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16689B0
	private static Collider[] OverlapCapsule_Internal_Injected(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1668CDC
	private static Collider[] OverlapSphere_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16690CC
	private static bool Query_ComputePenetration_Injected(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x1669690
	private static bool CheckSphere_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1669A2C
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

	// RVA: 0x166B594
	public void .ctor() { }

	// RVA: 0x166B654
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

	// RVA: 0x166B6BC
	public Collider get_collider() { }

	// RVA: 0x166B7B0
	public Vector3 get_point() { }

	// RVA: 0x166B7BC
	public Vector3 get_normal() { }

	// RVA: 0x166B7C8
	public float get_distance() { }

}

// Namespace: UnityEngine
public class Rigidbody
{
	// Methods

	// RVA: 0x166B7D0
	public Vector3 get_velocity() { }

	// RVA: 0x166B898
	public void set_velocity(Vector3 value) { }

	// RVA: 0x166B958
	public Vector3 get_angularVelocity() { }

	// RVA: 0x166BA20
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x166BAE0
	public void SetDensity(float density) { }

	// RVA: 0x166BB48
	public void set_useGravity(bool value) { }

	// RVA: 0x166BBB0
	public bool get_isKinematic() { }

	// RVA: 0x166BC00
	public void set_isKinematic(bool value) { }

	// RVA: 0x166BC68
	public Vector3 get_position() { }

	// RVA: 0x166BD30
	public void set_position(Vector3 value) { }

	// RVA: 0x166BDF0
	public Quaternion get_rotation() { }

	// RVA: 0x166BEB4
	public void set_rotation(Quaternion value) { }

	// RVA: 0x166BF74
	public void ResetCenterOfMass() { }

	// RVA: 0x166BFC4
	public void ResetInertiaTensor() { }

	// RVA: 0x166C014
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	// RVA: 0x166C0D4
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	// RVA: 0x166C1E4
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	// RVA: 0x166C268
	public void .ctor() { }

	// RVA: 0x166B830
	private void get_velocity_Injected(Vector3 ret) { }

	// RVA: 0x166B8F0
	private void set_velocity_Injected(Vector3 value) { }

	// RVA: 0x166B9B8
	private void get_angularVelocity_Injected(Vector3 ret) { }

	// RVA: 0x166BA78
	private void set_angularVelocity_Injected(Vector3 value) { }

	// RVA: 0x166BCC8
	private void get_position_Injected(Vector3 ret) { }

	// RVA: 0x166BD88
	private void set_position_Injected(Vector3 value) { }

	// RVA: 0x166BE4C
	private void get_rotation_Injected(Quaternion ret) { }

	// RVA: 0x166BF0C
	private void set_rotation_Injected(Quaternion value) { }

	// RVA: 0x166C07C
	private void AddRelativeForce_Injected(Vector3 force, ForceMode mode) { }

	// RVA: 0x166C164
	private void AddExplosionForce_Injected(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

}

// Namespace: UnityEngine
public class Collider
{
	// Methods

	// RVA: 0x166C270
	public bool get_enabled() { }

	// RVA: 0x166C2C0
	public void set_enabled(bool value) { }

	// RVA: 0x166C328
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x166C378
	public ArticulationBody get_attachedArticulationBody() { }

	// RVA: 0x166C3C8
	public bool get_isTrigger() { }

	// RVA: 0x166C418
	public void set_isTrigger(bool value) { }

	// RVA: 0x166C480
	public float get_contactOffset() { }

	// RVA: 0x166C4D0
	public void set_contactOffset(float value) { }

	// RVA: 0x166C538
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x166C5FC
	public Bounds get_bounds() { }

	// RVA: 0x166C6D8
	public bool get_hasModifiableContacts() { }

	// RVA: 0x166C728
	public void set_hasModifiableContacts(bool value) { }

	// RVA: 0x166C790
	public bool get_providesContacts() { }

	// RVA: 0x166C7E0
	public void set_providesContacts(bool value) { }

	// RVA: 0x166C848
	public int get_layerOverridePriority() { }

	// RVA: 0x166C898
	public void set_layerOverridePriority(int value) { }

	// RVA: 0x166C900
	public LayerMask get_excludeLayers() { }

	// RVA: 0x166C9C0
	public void set_excludeLayers(LayerMask value) { }

	// RVA: 0x166CA7C
	public LayerMask get_includeLayers() { }

	// RVA: 0x166CB3C
	public void set_includeLayers(LayerMask value) { }

	// RVA: 0x166CBF8
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x166CC48
	public void set_sharedMaterial(PhysicMaterial value) { }

	// RVA: 0x166CCB0
	public PhysicMaterial get_material() { }

	// RVA: 0x166CD00
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x166CD68
	private RaycastHit Raycast(Ray ray, float maxDistance, bool hasHit) { }

	// RVA: 0x166CE80
	public bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x166CF38
	private void Internal_ClosestPointOnBounds(Vector3 point, Vector3 outPos, float distance) { }

	// RVA: 0x166D010
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x166D0D8
	public void .ctor() { }

	// RVA: 0x166C5A4
	private void ClosestPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x166C670
	private void get_bounds_Injected(Bounds ret) { }

	// RVA: 0x166C958
	private void get_excludeLayers_Injected(LayerMask ret) { }

	// RVA: 0x166CA14
	private void set_excludeLayers_Injected(LayerMask value) { }

	// RVA: 0x166CAD4
	private void get_includeLayers_Injected(LayerMask ret) { }

	// RVA: 0x166CB90
	private void set_includeLayers_Injected(LayerMask value) { }

	// RVA: 0x166CE08
	private void Raycast_Injected(Ray ray, float maxDistance, bool hasHit, RaycastHit ret) { }

	// RVA: 0x166CFA8
	private void Internal_ClosestPointOnBounds_Injected(Vector3 point, Vector3 outPos, float distance) { }

}

// Namespace: UnityEngine
public class CharacterController
{}

// Namespace: UnityEngine
public class MeshCollider
{
	// Methods

	// RVA: 0x166D0E0
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x166D148
	public void set_convex(bool value) { }

}

// Namespace: UnityEngine
public class CapsuleCollider
{
	// Methods

	// RVA: 0x166D1B0
	public Vector3 get_center() { }

	// RVA: 0x166D278
	public void set_center(Vector3 value) { }

	// RVA: 0x166D338
	public float get_radius() { }

	// RVA: 0x166D388
	public float get_height() { }

	// RVA: 0x166D3D8
	public void set_height(float value) { }

	// RVA: 0x166D210
	private void get_center_Injected(Vector3 ret) { }

	// RVA: 0x166D2D0
	private void set_center_Injected(Vector3 value) { }

}

// Namespace: UnityEngine
public class BoxCollider
{
	// Methods

	// RVA: 0x166D440
	public Vector3 get_center() { }

	// RVA: 0x166D508
	public Vector3 get_size() { }

	// RVA: 0x166D5D0
	public void set_size(Vector3 value) { }

	// RVA: 0x166D4A0
	private void get_center_Injected(Vector3 ret) { }

	// RVA: 0x166D568
	private void get_size_Injected(Vector3 ret) { }

	// RVA: 0x166D628
	private void set_size_Injected(Vector3 value) { }

}

// Namespace: UnityEngine
public class SphereCollider
{
	// Methods

	// RVA: 0x166D690
	public Vector3 get_center() { }

	// RVA: 0x166D758
	public float get_radius() { }

	// RVA: 0x166D7A8
	public void set_radius(float value) { }

	// RVA: 0x166D6F0
	private void get_center_Injected(Vector3 ret) { }

}

// Namespace: UnityEngine
public class Joint
{
	// Methods

	// RVA: 0x166D810
	public Rigidbody get_connectedBody() { }

	// RVA: 0x166D860
	public Vector3 get_anchor() { }

	// RVA: 0x166D928
	public Vector3 get_connectedAnchor() { }

	// RVA: 0x166D9F0
	public void set_autoConfigureConnectedAnchor(bool value) { }

	// RVA: 0x166D8C0
	private void get_anchor_Injected(Vector3 ret) { }

	// RVA: 0x166D988
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

	// RVA: 0x166DA58
	public Vector3 get_point() { }

	// RVA: 0x166DA64
	public Vector3 get_normal() { }

}

// Namespace: UnityEngine
public struct PhysicsScene
{
	// Fields
	private int m_Handle; // 0x10

	// Methods

	// RVA: 0x166DA70
	public override string ToString() { }

	// RVA: 0x166DB6C
	public override int GetHashCode() { }

	// RVA: 0x166DB74
	public override bool Equals(object other) { }

	// RVA: 0x166DC04
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x1665180
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166DC14
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1665924
	public bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166DD08
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1667CE8
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166DE14
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166DF20
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166E06C
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1666CA0
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166E210
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1669EDC
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166E334
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166E468
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1666F0C
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166E5D8
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1669494
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166DC90
	private static bool Internal_RaycastTest_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166DD94
	private static bool Internal_Raycast_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166DEA0
	private static int Internal_RaycastNonAlloc_Injected(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166DFCC
	private static bool Query_CapsuleCast_Injected(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166E2A4
	private static int OverlapCapsuleNonAlloc_Internal_Injected(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166E3D0
	private static bool Query_SphereCast_Injected(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x166E660
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

	// RVA: 0x166461C
	public Component get_Body() { }

	// RVA: 0x1664568
	public Component get_OtherBody() { }

	// RVA: 0x166B26C
	internal bool get_HasRemovedBody() { }

	// RVA: 0x166B27C
	public ContactPair GetContactPair(int index) { }

	// RVA: 0x166E6E0
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

	// RVA: 0x1664858
	public Collider get_Collider() { }

	// RVA: 0x16647AC
	public Collider get_OtherCollider() { }

	// RVA: 0x166B290
	public bool get_IsCollisionEnter() { }

	// RVA: 0x166B410
	public bool get_IsCollisionExit() { }

	// RVA: 0x166B404
	public bool get_IsCollisionStay() { }

	// RVA: 0x166B280
	internal bool get_HasRemovedCollider() { }

	// RVA: 0x1664AB4
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x166E76C
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


