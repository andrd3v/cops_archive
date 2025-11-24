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

	// RVA: 0x1687608
	public Component get_body() { }

	// RVA: 0x1687854
	public Collider get_collider() { }

	// RVA: 0x1687A88
	public GameObject get_gameObject() { }

	// RVA: 0x1687B50
	internal void set_Flipped(bool value) { }

	// RVA: 0x1687B58
	public ContactPoint[] get_contacts() { }

	// RVA: 0x1687C90
	public void .ctor() { }

	// RVA: 0x1687CEC
	internal void .ctor(ContactPairHeader header, ContactPair pair, bool flipped) { }

	// RVA: 0x1687DE4
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

	// RVA: 0x1687E34
	public void .ctor() { }

}

// Namespace: 
public sealed class ContactEventDelegate
{
	// Methods

	// RVA: 0x168E65C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x168E700
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

	// RVA: 0x1687E3C
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	// RVA: 0x1687F5C
	public static Vector3 get_gravity() { }

	// RVA: 0x1688060
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x16880A0
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x1688198
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1688514
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x168867C
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x16887D8
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x168892C
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1688CCC
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1688E3C
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1688FA8
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo) { }

	// RVA: 0x168910C
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1689248
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x1689378
	public static bool Raycast(Ray ray, float maxDistance) { }

	// RVA: 0x16894A4
	public static bool Raycast(Ray ray) { }

	// RVA: 0x16895C8
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168970C
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x16897D0
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1689904
	public static bool Raycast(Ray ray, RaycastHit hitInfo) { }

	// RVA: 0x1689A30
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1689BF4
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	// RVA: 0x1689CA0
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1689E40
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168A200
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x168A2CC
	public static bool SphereCast(Ray ray, float radius, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168A39C
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168A4EC
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168A848
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x168A904
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x168A9B4
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x168AA5C
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168AB1C
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x168ABD0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	// RVA: 0x168AC80
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x168AD28
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168B0F8
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x168B238
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x168B36C
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x168B498
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168B614
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x168B784
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x168B8F0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0x168BA54
	private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168BBB4
	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168BD8C
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168BED8
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168C088
	public static Collider[] OverlapSphere(Vector3 position, float radius) { }

	// RVA: 0x168C110
	public static bool get_reuseCollisionCallbacks() { }

	// RVA: 0x168C150
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x168C2E8
	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x168C4A4
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168C6A4
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x168C740
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168C88C
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168CA3C
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x168CAD0
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168CC30
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168CE08
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	// RVA: 0x168CEC4
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168D0F8
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x168D1BC
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	// RVA: 0x168D20C
	internal static Component GetBodyByInstanceID(int instanceID) { }

	// RVA: 0x168D25C
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	// RVA: 0x168D2C4
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	// RVA: 0x168D32C
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	// RVA: 0x168D394
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x168D670
	private static void ReportContacts(ReadOnly array) { }

	// RVA: 0x168E420
	private static Collision GetCollisionToReport(ContactPairHeader header, ContactPair pair, bool flipped) { }

	// RVA: 0x168E5A0
	private static void .cctor() { }

	// RVA: 0x1688010
	private static void get_gravity_Injected(Vector3 ret) { }

	// RVA: 0x1688148
	private static void get_defaultPhysicsScene_Injected(PhysicsScene ret) { }

	// RVA: 0x168A474
	private static RaycastHit[] Internal_RaycastAll_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168BB34
	private static Collider[] OverlapCapsule_Internal_Injected(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168BE60
	private static Collider[] OverlapSphere_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168C250
	private static bool Query_ComputePenetration_Injected(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x168C814
	private static bool CheckSphere_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168CBB0
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

	// RVA: 0x168E718
	public void .ctor() { }

	// RVA: 0x168E7D8
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

	// RVA: 0x168E840
	public Collider get_collider() { }

	// RVA: 0x168E934
	public Vector3 get_point() { }

	// RVA: 0x168E940
	public Vector3 get_normal() { }

	// RVA: 0x168E94C
	public float get_distance() { }

}

// Namespace: UnityEngine
public class Rigidbody
{
	// Methods

	// RVA: 0x168E954
	public Vector3 get_velocity() { }

	// RVA: 0x168EA1C
	public void set_velocity(Vector3 value) { }

	// RVA: 0x168EADC
	public Vector3 get_angularVelocity() { }

	// RVA: 0x168EBA4
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x168EC64
	public void SetDensity(float density) { }

	// RVA: 0x168ECCC
	public void set_useGravity(bool value) { }

	// RVA: 0x168ED34
	public bool get_isKinematic() { }

	// RVA: 0x168ED84
	public void set_isKinematic(bool value) { }

	// RVA: 0x168EDEC
	public Vector3 get_position() { }

	// RVA: 0x168EEB4
	public void set_position(Vector3 value) { }

	// RVA: 0x168EF74
	public Quaternion get_rotation() { }

	// RVA: 0x168F038
	public void set_rotation(Quaternion value) { }

	// RVA: 0x168F0F8
	public void ResetCenterOfMass() { }

	// RVA: 0x168F148
	public void ResetInertiaTensor() { }

	// RVA: 0x168F198
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	// RVA: 0x168F258
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	// RVA: 0x168F368
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	// RVA: 0x168F3EC
	public void .ctor() { }

	// RVA: 0x168E9B4
	private void get_velocity_Injected(Vector3 ret) { }

	// RVA: 0x168EA74
	private void set_velocity_Injected(Vector3 value) { }

	// RVA: 0x168EB3C
	private void get_angularVelocity_Injected(Vector3 ret) { }

	// RVA: 0x168EBFC
	private void set_angularVelocity_Injected(Vector3 value) { }

	// RVA: 0x168EE4C
	private void get_position_Injected(Vector3 ret) { }

	// RVA: 0x168EF0C
	private void set_position_Injected(Vector3 value) { }

	// RVA: 0x168EFD0
	private void get_rotation_Injected(Quaternion ret) { }

	// RVA: 0x168F090
	private void set_rotation_Injected(Quaternion value) { }

	// RVA: 0x168F200
	private void AddRelativeForce_Injected(Vector3 force, ForceMode mode) { }

	// RVA: 0x168F2E8
	private void AddExplosionForce_Injected(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

}

// Namespace: UnityEngine
public class Collider
{
	// Methods

	// RVA: 0x168F3F4
	public bool get_enabled() { }

	// RVA: 0x168F444
	public void set_enabled(bool value) { }

	// RVA: 0x168F4AC
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x168F4FC
	public ArticulationBody get_attachedArticulationBody() { }

	// RVA: 0x168F54C
	public bool get_isTrigger() { }

	// RVA: 0x168F59C
	public void set_isTrigger(bool value) { }

	// RVA: 0x168F604
	public float get_contactOffset() { }

	// RVA: 0x168F654
	public void set_contactOffset(float value) { }

	// RVA: 0x168F6BC
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x168F780
	public Bounds get_bounds() { }

	// RVA: 0x168F85C
	public bool get_hasModifiableContacts() { }

	// RVA: 0x168F8AC
	public void set_hasModifiableContacts(bool value) { }

	// RVA: 0x168F914
	public bool get_providesContacts() { }

	// RVA: 0x168F964
	public void set_providesContacts(bool value) { }

	// RVA: 0x168F9CC
	public int get_layerOverridePriority() { }

	// RVA: 0x168FA1C
	public void set_layerOverridePriority(int value) { }

	// RVA: 0x168FA84
	public LayerMask get_excludeLayers() { }

	// RVA: 0x168FB44
	public void set_excludeLayers(LayerMask value) { }

	// RVA: 0x168FC00
	public LayerMask get_includeLayers() { }

	// RVA: 0x168FCC0
	public void set_includeLayers(LayerMask value) { }

	// RVA: 0x168FD7C
	public PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x168FDCC
	public void set_sharedMaterial(PhysicMaterial value) { }

	// RVA: 0x168FE34
	public PhysicMaterial get_material() { }

	// RVA: 0x168FE84
	public void set_material(PhysicMaterial value) { }

	// RVA: 0x168FEEC
	private RaycastHit Raycast(Ray ray, float maxDistance, bool hasHit) { }

	// RVA: 0x1690004
	public bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x16900BC
	private void Internal_ClosestPointOnBounds(Vector3 point, Vector3 outPos, float distance) { }

	// RVA: 0x1690194
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x169025C
	public void .ctor() { }

	// RVA: 0x168F728
	private void ClosestPoint_Injected(Vector3 position, Vector3 ret) { }

	// RVA: 0x168F7F4
	private void get_bounds_Injected(Bounds ret) { }

	// RVA: 0x168FADC
	private void get_excludeLayers_Injected(LayerMask ret) { }

	// RVA: 0x168FB98
	private void set_excludeLayers_Injected(LayerMask value) { }

	// RVA: 0x168FC58
	private void get_includeLayers_Injected(LayerMask ret) { }

	// RVA: 0x168FD14
	private void set_includeLayers_Injected(LayerMask value) { }

	// RVA: 0x168FF8C
	private void Raycast_Injected(Ray ray, float maxDistance, bool hasHit, RaycastHit ret) { }

	// RVA: 0x169012C
	private void Internal_ClosestPointOnBounds_Injected(Vector3 point, Vector3 outPos, float distance) { }

}

// Namespace: UnityEngine
public class CharacterController
{}

// Namespace: UnityEngine
public class MeshCollider
{
	// Methods

	// RVA: 0x1690264
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x16902CC
	public void set_convex(bool value) { }

}

// Namespace: UnityEngine
public class CapsuleCollider
{
	// Methods

	// RVA: 0x1690334
	public Vector3 get_center() { }

	// RVA: 0x16903FC
	public void set_center(Vector3 value) { }

	// RVA: 0x16904BC
	public float get_radius() { }

	// RVA: 0x169050C
	public float get_height() { }

	// RVA: 0x169055C
	public void set_height(float value) { }

	// RVA: 0x1690394
	private void get_center_Injected(Vector3 ret) { }

	// RVA: 0x1690454
	private void set_center_Injected(Vector3 value) { }

}

// Namespace: UnityEngine
public class BoxCollider
{
	// Methods

	// RVA: 0x16905C4
	public Vector3 get_center() { }

	// RVA: 0x169068C
	public Vector3 get_size() { }

	// RVA: 0x1690754
	public void set_size(Vector3 value) { }

	// RVA: 0x1690624
	private void get_center_Injected(Vector3 ret) { }

	// RVA: 0x16906EC
	private void get_size_Injected(Vector3 ret) { }

	// RVA: 0x16907AC
	private void set_size_Injected(Vector3 value) { }

}

// Namespace: UnityEngine
public class SphereCollider
{
	// Methods

	// RVA: 0x1690814
	public Vector3 get_center() { }

	// RVA: 0x16908DC
	public float get_radius() { }

	// RVA: 0x169092C
	public void set_radius(float value) { }

	// RVA: 0x1690874
	private void get_center_Injected(Vector3 ret) { }

}

// Namespace: UnityEngine
public class Joint
{
	// Methods

	// RVA: 0x1690994
	public Rigidbody get_connectedBody() { }

	// RVA: 0x16909E4
	public Vector3 get_anchor() { }

	// RVA: 0x1690AAC
	public Vector3 get_connectedAnchor() { }

	// RVA: 0x1690B74
	public void set_autoConfigureConnectedAnchor(bool value) { }

	// RVA: 0x1690A44
	private void get_anchor_Injected(Vector3 ret) { }

	// RVA: 0x1690B0C
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

	// RVA: 0x1690BDC
	public Vector3 get_point() { }

	// RVA: 0x1690BE8
	public Vector3 get_normal() { }

}

// Namespace: UnityEngine
public struct PhysicsScene
{
	// Fields
	private int m_Handle; // 0x10

	// Methods

	// RVA: 0x1690BF4
	public override string ToString() { }

	// RVA: 0x1690CF0
	public override int GetHashCode() { }

	// RVA: 0x1690CF8
	public override bool Equals(object other) { }

	// RVA: 0x1690D88
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x1688304
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1690D98
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1688AA8
	public bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1690E8C
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168AE6C
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1690F98
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16910A4
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16911F0
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1689E24
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1691394
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168D060
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16914B8
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16915EC
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168A090
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x169175C
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x168C618
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1690E14
	private static bool Internal_RaycastTest_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1690F18
	private static bool Internal_Raycast_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1691024
	private static int Internal_RaycastNonAlloc_Injected(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1691150
	private static bool Query_CapsuleCast_Injected(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1691428
	private static int OverlapCapsuleNonAlloc_Internal_Injected(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1691554
	private static bool Query_SphereCast_Injected(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x16917E4
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

	// RVA: 0x16877A0
	public Component get_Body() { }

	// RVA: 0x16876EC
	public Component get_OtherBody() { }

	// RVA: 0x168E3F0
	internal bool get_HasRemovedBody() { }

	// RVA: 0x168E400
	public ContactPair GetContactPair(int index) { }

	// RVA: 0x1691864
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

	// RVA: 0x16879DC
	public Collider get_Collider() { }

	// RVA: 0x1687930
	public Collider get_OtherCollider() { }

	// RVA: 0x168E414
	public bool get_IsCollisionEnter() { }

	// RVA: 0x168E594
	public bool get_IsCollisionExit() { }

	// RVA: 0x168E588
	public bool get_IsCollisionStay() { }

	// RVA: 0x168E404
	internal bool get_HasRemovedCollider() { }

	// RVA: 0x1687C38
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x16918F0
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


