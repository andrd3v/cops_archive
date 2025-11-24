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

	// RVA: 0x1570300
	Component get_body() { }

	// RVA: 0x157054C
	Collider get_collider() { }

	// RVA: 0x1570780
	GameObject get_gameObject() { }

	// RVA: 0x1570848
	void set_Flipped(bool value) { }

	// RVA: 0x1570850
	ContactPoint[] get_contacts() { }

	// RVA: 0x1570988
	void .ctor() { }

	// RVA: 0x15709E4
	void .ctor(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x1570ADC
	void Reuse(in ContactPairHeader header, in ContactPair pair) { }

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

	// RVA: 0x1570B2C
	void .ctor() { }

}

// Namespace: 
public sealed class ContactEventDelegate 
{
	// Methods

	// RVA: 0x1577354
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x15773F8
	internal void Invoke(PhysicsScene scene, ReadOnly headerArray) { }

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

	// RVA: 0x1570B34
	void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	// RVA: 0x1570C54
	Vector3 get_gravity() { }

	// RVA: 0x1570D58
	bool get_invokeCollisionCallbacks() { }

	// RVA: 0x1570D98
	PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x1570E90
	bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157120C
	bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x1571374
	bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x15714D0
	bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x1571624
	bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x15719C4
	bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1571B34
	bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1571CA0
	bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x1571E04
	bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1571F40
	bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x1572070
	bool Raycast(Ray ray, float maxDistance) { }

	// RVA: 0x157219C
	bool Raycast(Ray ray) { }

	// RVA: 0x15722C0
	bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1572404
	bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x15724C8
	bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x15725FC
	bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x1572728
	bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x15728EC
	bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	// RVA: 0x1572998
	bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1572B38
	bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1572EF8
	bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1572FC4
	bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1573094
	RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x15731E4
	RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1573540
	RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x15735FC
	RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x15736AC
	RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x1573754
	RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1573814
	RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x15738C8
	RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	// RVA: 0x1573978
	RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x1573A20
	int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1573DF0
	int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x1573F30
	int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x1574064
	int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x1574190
	int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157430C
	int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x157447C
	int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x15745E8
	int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0x157474C
	Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x15748AC
	Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1574A84
	Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1574BD0
	Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1574D80
	Collider[] OverlapSphere(Vector3 position, float radius) { }

	// RVA: 0x1574E08
	bool get_reuseCollisionCallbacks() { }

	// RVA: 0x1574E48
	bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x1574FE0
	bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) { }

	// RVA: 0x157519C
	int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157539C
	int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x1575438
	bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1575584
	bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1575734
	bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x15757C8
	bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1575928
	bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1575B00
	bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	// RVA: 0x1575BBC
	int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1575DF0
	int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x1575EB4
	Collider GetColliderByInstanceID(int instanceID) { }

	// RVA: 0x1575F04
	Component GetBodyByInstanceID(int instanceID) { }

	// RVA: 0x1575F54
	void SendOnCollisionEnter(Component component, Collision collision) { }

	// RVA: 0x1575FBC
	void SendOnCollisionStay(Component component, Collision collision) { }

	// RVA: 0x1576024
	void SendOnCollisionExit(Component component, Collision collision) { }

	// RVA: 0x157608C
	void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x1576368
	void ReportContacts(ReadOnly array) { }

	// RVA: 0x1577118
	Collision GetCollisionToReport(in ContactPairHeader header, in ContactPair pair, bool flipped) { }

	// RVA: 0x1577298
	void .cctor() { }

	// RVA: 0x1570D08
	void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x1570E40
	void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x157316C
	RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157482C
	Collider[] OverlapCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1574B58
	Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1574F48
	bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x157550C
	bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x15758A8
	bool CheckCapsule_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 start, ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

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

	// RVA: 0x1577410
	void .ctor() { }

	// RVA: 0x15774D0
	void Internal_CreateDynamicsMaterial(PhysicMaterial mat, string name) { }

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

	// RVA: 0x1577538
	Collider get_collider() { }

	// RVA: 0x157762C
	Vector3 get_point() { }

	// RVA: 0x1577638
	Vector3 get_normal() { }

	// RVA: 0x1577644
	float get_distance() { }

}

// Namespace: UnityEngine
public class Rigidbody 
{
	// Methods

	// RVA: 0x157764C
	Vector3 get_velocity() { }

	// RVA: 0x1577714
	void set_velocity(Vector3 value) { }

	// RVA: 0x15777D4
	Vector3 get_angularVelocity() { }

	// RVA: 0x157789C
	void set_angularVelocity(Vector3 value) { }

	// RVA: 0x157795C
	void SetDensity(float density) { }

	// RVA: 0x15779C4
	void set_useGravity(bool value) { }

	// RVA: 0x1577A2C
	bool get_isKinematic() { }

	// RVA: 0x1577A7C
	void set_isKinematic(bool value) { }

	// RVA: 0x1577AE4
	Vector3 get_position() { }

	// RVA: 0x1577BAC
	void set_position(Vector3 value) { }

	// RVA: 0x1577C6C
	Quaternion get_rotation() { }

	// RVA: 0x1577D30
	void set_rotation(Quaternion value) { }

	// RVA: 0x1577DF0
	void ResetCenterOfMass() { }

	// RVA: 0x1577E40
	void ResetInertiaTensor() { }

	// RVA: 0x1577E90
	void AddRelativeForce(Vector3 force, ForceMode mode) { }

	// RVA: 0x1577F50
	void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	// RVA: 0x1578060
	void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	// RVA: 0x15780E4
	void .ctor() { }

	// RVA: 0x15776AC
	void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x157776C
	void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x1577834
	void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x15778F4
	void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x1577B44
	void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x1577C04
	void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x1577CC8
	void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x1577D88
	void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x1577EF8
	void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x1577FE0
	void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

}

// Namespace: UnityEngine
public class Collider 
{
	// Methods

	// RVA: 0x15780EC
	bool get_enabled() { }

	// RVA: 0x157813C
	void set_enabled(bool value) { }

	// RVA: 0x15781A4
	Rigidbody get_attachedRigidbody() { }

	// RVA: 0x15781F4
	ArticulationBody get_attachedArticulationBody() { }

	// RVA: 0x1578244
	bool get_isTrigger() { }

	// RVA: 0x1578294
	void set_isTrigger(bool value) { }

	// RVA: 0x15782FC
	float get_contactOffset() { }

	// RVA: 0x157834C
	void set_contactOffset(float value) { }

	// RVA: 0x15783B4
	Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x1578478
	Bounds get_bounds() { }

	// RVA: 0x1578554
	bool get_hasModifiableContacts() { }

	// RVA: 0x15785A4
	void set_hasModifiableContacts(bool value) { }

	// RVA: 0x157860C
	bool get_providesContacts() { }

	// RVA: 0x157865C
	void set_providesContacts(bool value) { }

	// RVA: 0x15786C4
	int get_layerOverridePriority() { }

	// RVA: 0x1578714
	void set_layerOverridePriority(int value) { }

	// RVA: 0x157877C
	LayerMask get_excludeLayers() { }

	// RVA: 0x157883C
	void set_excludeLayers(LayerMask value) { }

	// RVA: 0x15788F8
	LayerMask get_includeLayers() { }

	// RVA: 0x15789B8
	void set_includeLayers(LayerMask value) { }

	// RVA: 0x1578A74
	PhysicMaterial get_sharedMaterial() { }

	// RVA: 0x1578AC4
	void set_sharedMaterial(PhysicMaterial value) { }

	// RVA: 0x1578B2C
	PhysicMaterial get_material() { }

	// RVA: 0x1578B7C
	void set_material(PhysicMaterial value) { }

	// RVA: 0x1578BE4
	RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	// RVA: 0x1578CFC
	bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1578DB4
	void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance) { }

	// RVA: 0x1578E8C
	Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x1578F54
	void .ctor() { }

	// RVA: 0x1578420
	void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x15784EC
	void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x15787D4
	void get_excludeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x1578890
	void set_excludeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x1578950
	void get_includeLayers_Injected(out LayerMask ret) { }

	// RVA: 0x1578A0C
	void set_includeLayers_Injected(ref LayerMask value) { }

	// RVA: 0x1578C84
	void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	// RVA: 0x1578E24
	void Internal_ClosestPointOnBounds_Injected(ref Vector3 point, ref Vector3 outPos, ref float distance) { }

}

// Namespace: UnityEngine
public class CharacterController 
{}

// Namespace: UnityEngine
public class MeshCollider 
{}

// Namespace: UnityEngine
public class CapsuleCollider 
{
	// Methods

	// RVA: 0x1578F5C
	Vector3 get_center() { }

	// RVA: 0x1579024
	void set_center(Vector3 value) { }

	// RVA: 0x15790E4
	float get_radius() { }

	// RVA: 0x1579134
	float get_height() { }

	// RVA: 0x1579184
	void set_height(float value) { }

	// RVA: 0x1578FBC
	void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x157907C
	void set_center_Injected(ref Vector3 value) { }

}

// Namespace: UnityEngine
public class BoxCollider 
{
	// Methods

	// RVA: 0x15791EC
	Vector3 get_center() { }

	// RVA: 0x15792B4
	Vector3 get_size() { }

	// RVA: 0x157937C
	void set_size(Vector3 value) { }

	// RVA: 0x157924C
	void get_center_Injected(out Vector3 ret) { }

	// RVA: 0x1579314
	void get_size_Injected(out Vector3 ret) { }

	// RVA: 0x15793D4
	void set_size_Injected(ref Vector3 value) { }

}

// Namespace: UnityEngine
public class SphereCollider 
{
	// Methods

	// RVA: 0x157943C
	Vector3 get_center() { }

	// RVA: 0x1579504
	float get_radius() { }

	// RVA: 0x1579554
	void set_radius(float value) { }

	// RVA: 0x157949C
	void get_center_Injected(out Vector3 ret) { }

}

// Namespace: UnityEngine
public class Joint 
{
	// Methods

	// RVA: 0x15795BC
	Rigidbody get_connectedBody() { }

	// RVA: 0x157960C
	Vector3 get_anchor() { }

	// RVA: 0x15796D4
	Vector3 get_connectedAnchor() { }

	// RVA: 0x157979C
	void set_autoConfigureConnectedAnchor(bool value) { }

	// RVA: 0x157966C
	void get_anchor_Injected(out Vector3 ret) { }

	// RVA: 0x1579734
	void get_connectedAnchor_Injected(out Vector3 ret) { }

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

	// RVA: 0x1579804
	Vector3 get_point() { }

	// RVA: 0x1579810
	Vector3 get_normal() { }

}

// Namespace: UnityEngine
public struct PhysicsScene 
{
	// Fields
	private int m_Handle; // 0x10

	// Methods

	// RVA: 0x157981C
	string ToString() { }

	// RVA: 0x1579918
	int GetHashCode() { }

	// RVA: 0x1579920
	bool Equals(object other) { }

	// RVA: 0x15799B0
	bool Equals(PhysicsScene other) { }

	// RVA: 0x1570FFC
	bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x15799C0
	bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x15717A0
	bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1579AB4
	bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1573B64
	int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1579BC0
	int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1579CCC
	bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1579E18
	bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1572B1C
	bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1579FBC
	int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1575D58
	int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157A0E0
	bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157A214
	bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1572D88
	bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157A384
	int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1575310
	int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1579A3C
	bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1579B40
	bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1579C4C
	int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1579D78
	bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157A050
	int OverlapCapsuleNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 point0, ref Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157A17C
	bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x157A40C
	int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

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

	// RVA: 0x1570498
	Component get_Body() { }

	// RVA: 0x15703E4
	Component get_OtherBody() { }

	// RVA: 0x15770E8
	bool get_HasRemovedBody() { }

	// RVA: 0x15770F8
	ref ContactPair GetContactPair(int index) { }

	// RVA: 0x157A48C
	ContactPair* GetContactPair_Internal(int index) { }

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

	// RVA: 0x15706D4
	Collider get_Collider() { }

	// RVA: 0x1570628
	Collider get_OtherCollider() { }

	// RVA: 0x157710C
	bool get_IsCollisionEnter() { }

	// RVA: 0x157728C
	bool get_IsCollisionExit() { }

	// RVA: 0x1577280
	bool get_IsCollisionStay() { }

	// RVA: 0x15770FC
	bool get_HasRemovedCollider() { }

	// RVA: 0x1570930
	int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x157A518
	int ExtractContactsArray_Injected(ref ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped) { }

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


