// Namespace: 
internal class <Module>
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

	// RVA: 0x1722F5C
	public Vector3 get_point() { }

	// RVA: 0x1722F68
	public Vector3 get_normal() { }

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

	// RVA: 0x1722F74
	public Component get_body() { }

	// RVA: 0x17231A8
	public Collider get_collider() { }

	// RVA: 0x17233EC
	public GameObject get_gameObject() { }

	// RVA: 0x17234E4
	internal void set_Flipped(bool value) { }

	// RVA: 0x17234EC
	public ContactPoint[] get_contacts() { }

	// RVA: 0x1723724
	public void .ctor() { }

	// RVA: 0x1723780
	internal void .ctor(ContactPairHeader header, ContactPair pair, bool flipped) { }

	// RVA: 0x1723854
	internal void Reuse(ContactPairHeader header, ContactPair pair) { }

}

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
public class ArticulationBody
{}

// Namespace: UnityEngine
public class BoxCollider
{
	// Methods

	// RVA: 0x17238A4
	public Vector3 get_center() { }

	// RVA: 0x17239B8
	public Vector3 get_size() { }

	// RVA: 0x1723ACC
	public void set_size(Vector3 value) { }

	// RVA: 0x1723BD8
	public void .ctor() { }

	// RVA: 0x1723950
	private static void get_center_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1723A64
	private static void get_size_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1723B70
	private static void set_size_Injected(IntPtr _unity_self, Vector3 value) { }

}

// Namespace: UnityEngine
public class CapsuleCollider
{
	// Methods

	// RVA: 0x1723BE8
	public Vector3 get_center() { }

	// RVA: 0x1723CFC
	public void set_center(Vector3 value) { }

	// RVA: 0x1723E08
	public float get_radius() { }

	// RVA: 0x1723EF0
	public float get_height() { }

	// RVA: 0x1723FD8
	public void set_height(float value) { }

	// RVA: 0x17240F0
	public void .ctor() { }

	// RVA: 0x1723C94
	private static void get_center_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1723DA0
	private static void set_center_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x1723EA0
	private static float get_radius_Injected(IntPtr _unity_self) { }

	// RVA: 0x1723F88
	private static float get_height_Injected(IntPtr _unity_self) { }

	// RVA: 0x1724088
	private static void set_height_Injected(IntPtr _unity_self, float value) { }

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
public class CharacterController
{}

// Namespace: UnityEngine
public class CharacterJoint
{}

// Namespace: UnityEngine
public class Collider
{
	// Methods

	// RVA: 0x17240F8
	public bool get_enabled() { }

	// RVA: 0x17241E0
	public void set_enabled(bool value) { }

	// RVA: 0x17242F8
	public Rigidbody get_attachedRigidbody() { }

	// RVA: 0x1724400
	public ArticulationBody get_attachedArticulationBody() { }

	// RVA: 0x1724508
	public bool get_isTrigger() { }

	// RVA: 0x17245F0
	public void set_isTrigger(bool value) { }

	// RVA: 0x1724708
	public float get_contactOffset() { }

	// RVA: 0x17247F0
	public void set_contactOffset(float value) { }

	// RVA: 0x1724908
	public Vector3 ClosestPoint(Vector3 position) { }

	// RVA: 0x1724A18
	public Bounds get_bounds() { }

	// RVA: 0x1724B40
	public bool get_hasModifiableContacts() { }

	// RVA: 0x1724C28
	public void set_hasModifiableContacts(bool value) { }

	// RVA: 0x1724D40
	public bool get_providesContacts() { }

	// RVA: 0x1724E28
	public void set_providesContacts(bool value) { }

	// RVA: 0x1724F40
	public int get_layerOverridePriority() { }

	// RVA: 0x1725028
	public void set_layerOverridePriority(int value) { }

	// RVA: 0x1725140
	public LayerMask get_excludeLayers() { }

	// RVA: 0x172524C
	public void set_excludeLayers(LayerMask value) { }

	// RVA: 0x1725354
	public LayerMask get_includeLayers() { }

	// RVA: 0x1725460
	public void set_includeLayers(LayerMask value) { }

	// RVA: 0x1725568
	public GeometryHolder get_GeometryHolder() { }

	// RVA: 0x26AD93C
	public T GetGeometry() { }

	// RVA: 0x17256C0
	public PhysicsMaterial get_sharedMaterial() { }

	// RVA: 0x17257C8
	public void set_sharedMaterial(PhysicsMaterial value) { }

	// RVA: 0x1725914
	public PhysicsMaterial get_material() { }

	// RVA: 0x1725A1C
	public void set_material(PhysicsMaterial value) { }

	// RVA: 0x1725B68
	private RaycastHit Raycast(Ray ray, float maxDistance, bool hasHit) { }

	// RVA: 0x1725CCC
	public bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1725DD0
	private void Internal_ClosestPointOnBounds(Vector3 point, Vector3 outPos, float distance) { }

	// RVA: 0x1725EF4
	public Vector3 ClosestPointOnBounds(Vector3 position) { }

	// RVA: 0x1723BE0
	public void .ctor() { }

	// RVA: 0x1724190
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x1724290
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x17243B0
	private static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self) { }

	// RVA: 0x17244B8
	private static IntPtr get_attachedArticulationBody_Injected(IntPtr _unity_self) { }

	// RVA: 0x17245A0
	private static bool get_isTrigger_Injected(IntPtr _unity_self) { }

	// RVA: 0x17246A0
	private static void set_isTrigger_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x17247A0
	private static float get_contactOffset_Injected(IntPtr _unity_self) { }

	// RVA: 0x17248A0
	private static void set_contactOffset_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x17249C0
	private static void ClosestPoint_Injected(IntPtr _unity_self, Vector3 position, Vector3 ret) { }

	// RVA: 0x1724AD8
	private static void get_bounds_Injected(IntPtr _unity_self, Bounds ret) { }

	// RVA: 0x1724BD8
	private static bool get_hasModifiableContacts_Injected(IntPtr _unity_self) { }

	// RVA: 0x1724CD8
	private static void set_hasModifiableContacts_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1724DD8
	private static bool get_providesContacts_Injected(IntPtr _unity_self) { }

	// RVA: 0x1724ED8
	private static void set_providesContacts_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1724FD8
	private static int get_layerOverridePriority_Injected(IntPtr _unity_self) { }

	// RVA: 0x17250D8
	private static void set_layerOverridePriority_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x17251E4
	private static void get_excludeLayers_Injected(IntPtr _unity_self, LayerMask ret) { }

	// RVA: 0x17252EC
	private static void set_excludeLayers_Injected(IntPtr _unity_self, LayerMask value) { }

	// RVA: 0x17253F8
	private static void get_includeLayers_Injected(IntPtr _unity_self, LayerMask ret) { }

	// RVA: 0x1725500
	private static void set_includeLayers_Injected(IntPtr _unity_self, LayerMask value) { }

	// RVA: 0x1725658
	private static void get_GeometryHolder_Injected(IntPtr _unity_self, GeometryHolder ret) { }

	// RVA: 0x1725778
	private static IntPtr get_sharedMaterial_Injected(IntPtr _unity_self) { }

	// RVA: 0x17258AC
	private static void set_sharedMaterial_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x17259CC
	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	// RVA: 0x1725B00
	private static void set_material_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1725C54
	private static void Raycast_Injected(IntPtr _unity_self, Ray ray, float maxDistance, bool hasHit, RaycastHit ret) { }

	// RVA: 0x1725E8C
	private static void Internal_ClosestPointOnBounds_Injected(IntPtr _unity_self, Vector3 point, Vector3 outPos, float distance) { }

}

// Namespace: 
public sealed class ContactEventDelegate
{
	// Methods

	// RVA: 0x172BCE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x172BD84
	public virtual void Invoke(PhysicsScene scene, ReadOnly headerArray) { }

}

// Namespace: UnityEngine
public class Physics
{
	// Fields
	private static System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEvent; // 0x0
	private static System.Action<UnityEngine.PhysicsScene,Unity.Collections.NativeArray<UnityEngine.ModifiableContactPair>> ContactModifyEventCCD; // 0x8
	private static System.Action<UnityEngine.PhysicsScene,System.IntPtr,System.Int32,System.Boolean> GenericContactModifyEvent; // 0x10
	private static ContactEventDelegate ContactEvent; // 0x18
	private static readonly Collision s_ReusableCollision; // 0x20

	// Methods

	// RVA: 0x1726008
	private static void OnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	// RVA: 0x17260D8
	private static void PhysXOnSceneContactModify(PhysicsScene scene, IntPtr buffer, int count, bool isCCD) { }

	// RVA: 0x17261F8
	public static Vector3 get_gravity() { }

	// RVA: 0x17262FC
	public static bool get_invokeCollisionCallbacks() { }

	// RVA: 0x172633C
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x1726344
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172662C
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x1726700
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x17267C8
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x1726888
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1726B94
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1726C70
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1726D48
	public static bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo) { }

	// RVA: 0x1726E18
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1726EC0
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x1726F5C
	public static bool Raycast(Ray ray, float maxDistance) { }

	// RVA: 0x1726FF4
	public static bool Raycast(Ray ray) { }

	// RVA: 0x1727084
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1727134
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1727274
	public static bool Raycast(Ray ray, RaycastHit hitInfo, float maxDistance) { }

	// RVA: 0x1727314
	public static bool Raycast(Ray ray, RaycastHit hitInfo) { }

	// RVA: 0x17273AC
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x17274FC
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	// RVA: 0x17275A8
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x17276F8
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1727A28
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x1727AF4
	public static bool SphereCast(Ray ray, float radius, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1727BC4
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1727DB0
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172801C
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	// RVA: 0x17280D8
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	// RVA: 0x1728188
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x1728230
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x17282F0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	// RVA: 0x17283A4
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	// RVA: 0x1728454
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x17284FC
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1728810
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x17288BC
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x172895C
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x17289F4
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1728ADC
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	// RVA: 0x1728BB8
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	// RVA: 0x1728C90
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	// RVA: 0x1728D60
	private static Collider[] OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1728EC0
	public static Collider[] OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1729004
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1729150
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172926C
	public static Collider[] OverlapSphere(Vector3 position, float radius) { }

	// RVA: 0x17292F4
	public static bool get_reuseCollisionCallbacks() { }

	// RVA: 0x1729334
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x1729584
	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x17296B0
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172981C
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x1729948
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1729A94
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1729BB0
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x1729C44
	private static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1729DA4
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1729EE8
	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask) { }

	// RVA: 0x1729FA4
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172A144
	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask) { }

	// RVA: 0x172A298
	internal static Collider GetColliderByInstanceID(int instanceID) { }

	// RVA: 0x172A3A8
	internal static Component GetBodyByInstanceID(int instanceID) { }

	// RVA: 0x172A4B8
	private static void SendOnCollisionEnter(Component component, Collision collision) { }

	// RVA: 0x172A614
	private static void SendOnCollisionStay(Component component, Collision collision) { }

	// RVA: 0x172A770
	private static void SendOnCollisionExit(Component component, Collision collision) { }

	// RVA: 0x172A8CC
	private static void OnSceneContact(PhysicsScene scene, IntPtr buffer, int count) { }

	// RVA: 0x172ABA8
	private static void ReportContacts(ReadOnly array) { }

	// RVA: 0x172BA44
	private static Collision GetCollisionToReport(ContactPairHeader header, ContactPair pair, bool flipped) { }

	// RVA: 0x172BBC4
	private static void .cctor() { }

	// RVA: 0x17262AC
	private static void get_gravity_Injected(Vector3 ret) { }

	// RVA: 0x1727D30
	private static void Internal_RaycastAll_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, BlittableArrayWrapper ret) { }

	// RVA: 0x1728E40
	private static Collider[] OverlapCapsule_Internal_Injected(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x17290D8
	private static Collider[] OverlapSphere_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x17294EC
	private static bool Query_ComputePenetration_Injected(IntPtr colliderA, Vector3 positionA, Quaternion rotationA, IntPtr colliderB, Vector3 positionB, Quaternion rotationB, Vector3 direction, float distance) { }

	// RVA: 0x1729A1C
	private static bool CheckSphere_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1729D24
	private static bool CheckCapsule_Internal_Injected(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172A358
	private static IntPtr GetColliderByInstanceID_Injected(int instanceID) { }

	// RVA: 0x172A468
	private static IntPtr GetBodyByInstanceID_Injected(int instanceID) { }

	// RVA: 0x172A5AC
	private static void SendOnCollisionEnter_Injected(IntPtr component, Collision collision) { }

	// RVA: 0x172A708
	private static void SendOnCollisionStay_Injected(IntPtr component, Collision collision) { }

	// RVA: 0x172A864
	private static void SendOnCollisionExit_Injected(IntPtr component, Collision collision) { }

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
public class Joint
{
	// Methods

	// RVA: 0x172BD98
	public Rigidbody get_connectedBody() { }

	// RVA: 0x172BEA0
	public Vector3 get_anchor() { }

	// RVA: 0x172BFB4
	public Vector3 get_connectedAnchor() { }

	// RVA: 0x172C0C8
	public void set_autoConfigureConnectedAnchor(bool value) { }

	// RVA: 0x172BE50
	private static IntPtr get_connectedBody_Injected(IntPtr _unity_self) { }

	// RVA: 0x172BF4C
	private static void get_anchor_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x172C060
	private static void get_connectedAnchor_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x172C178
	private static void set_autoConfigureConnectedAnchor_Injected(IntPtr _unity_self, bool value) { }

}

// Namespace: UnityEngine
public class MeshCollider
{
	// Methods

	// RVA: 0x172C1E0
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x172C32C
	public void set_convex(bool value) { }

	// RVA: 0x172C2C4
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x172C3DC
	private static void set_convex_Injected(IntPtr _unity_self, bool value) { }

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

	// RVA: 0x1723098
	public Component get_body() { }

	// RVA: 0x1722F88
	public Component get_otherBody() { }

	// RVA: 0x172BA14
	internal bool get_hasRemovedBody() { }

	// RVA: 0x172BA24
	public ContactPair GetContactPair(int index) { }

	// RVA: 0x172C444
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

	// RVA: 0x17232D4
	public Collider get_collider() { }

	// RVA: 0x17231BC
	public Collider get_otherCollider() { }

	// RVA: 0x172BA38
	public bool get_isCollisionEnter() { }

	// RVA: 0x172BBB8
	public bool get_isCollisionExit() { }

	// RVA: 0x172BBAC
	public bool get_isCollisionStay() { }

	// RVA: 0x172BA28
	internal bool get_hasRemovedCollider() { }

	// RVA: 0x1723594
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x172C4D0
	public ContactPairPoint GetContactPoint(int index) { }

	// RVA: 0x172C4D4
	internal ContactPairPoint* GetContactPoint_Internal(int index) { }

}

// Namespace: UnityEngine
public struct ContactPairPoint
{
	// Fields
	internal readonly Vector3 m_Position; // 0x10
	internal readonly float m_Separation; // 0x1C
	internal readonly Vector3 m_Normal; // 0x20
	internal readonly UInt32 m_InternalFaceIndex0; // 0x2C
	internal readonly Vector3 m_Impulse; // 0x30
	internal readonly UInt32 m_InternalFaceIndex1; // 0x3C

	// Methods

	// RVA: 0x172C560
	public Vector3 get_position() { }

	// RVA: 0x172C56C
	public float get_separation() { }

	// RVA: 0x172C574
	public Vector3 get_normal() { }

	// RVA: 0x172C580
	public Vector3 get_impulse() { }

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

// Namespace: UnityEngine
public class PhysicsMaterial
{
	// Methods

	// RVA: 0x172C58C
	public void .ctor() { }

	// RVA: 0x172C610
	private static void Internal_CreateDynamicsMaterial(PhysicsMaterial mat, string name) { }

	// RVA: 0x172C794
	private static void Internal_CreateDynamicsMaterial_Injected(PhysicsMaterial mat, ManagedSpanWrapper name) { }

}

// Namespace: UnityEngine
public struct PhysicsScene
{
	// Fields
	private int m_index; // 0x10
	private int m_version; // 0x14

	// Methods

	// RVA: 0x172C7FC
	public override string ToString() { }

	// RVA: 0x172C898
	public static bool op_Equality(PhysicsScene lhs, PhysicsScene rhs) { }

	// RVA: 0x172C8A4
	public override int GetHashCode() { }

	// RVA: 0x172C934
	public override bool Equals(object other) { }

	// RVA: 0x172C9C4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x172C9D4
	internal static PhysicsScene GetDefaultScene() { }

	// RVA: 0x172641C
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172C9DC
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1726970
	public bool Raycast(Vector3 origin, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172CAD0
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x17285AC
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172CBDC
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172CD70
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172CEBC
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x17276DC
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172D060
	private static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172A0AC
	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172D184
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172D2B8
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x17278B8
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172D428
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x1729790
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172CA58
	private static bool Internal_RaycastTest_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172CB5C
	private static bool Internal_Raycast_Injected(PhysicsScene physicsScene, Ray ray, float maxDistance, RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172CCF0
	private static int Internal_RaycastNonAlloc_Injected(PhysicsScene physicsScene, Ray ray, ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172CE1C
	private static bool Query_CapsuleCast_Injected(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172D0F4
	private static int OverlapCapsuleNonAlloc_Internal_Injected(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172D220
	private static bool Query_SphereCast_Injected(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x172D4B0
	private static int OverlapSphereNonAlloc_Internal_Injected(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

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

	// RVA: 0x172D530
	public Collider get_collider() { }

	// RVA: 0x172D624
	public Vector3 get_point() { }

	// RVA: 0x172D630
	public Vector3 get_normal() { }

	// RVA: 0x172D63C
	public float get_distance() { }

}

// Namespace: UnityEngine
public class Rigidbody
{
	// Methods

	// RVA: 0x172D644
	public Vector3 get_linearVelocity() { }

	// RVA: 0x172D758
	public void set_linearVelocity(Vector3 value) { }

	// RVA: 0x172D864
	public Vector3 get_angularVelocity() { }

	// RVA: 0x172D978
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x172DA84
	public void SetDensity(float density) { }

	// RVA: 0x172DB9C
	public void set_useGravity(bool value) { }

	// RVA: 0x172DCB4
	public bool get_isKinematic() { }

	// RVA: 0x172DD9C
	public void set_isKinematic(bool value) { }

	// RVA: 0x172DEB4
	public Vector3 get_position() { }

	// RVA: 0x172DFC8
	public void set_position(Vector3 value) { }

	// RVA: 0x172E0D4
	public Quaternion get_rotation() { }

	// RVA: 0x172E1E4
	public void set_rotation(Quaternion value) { }

	// RVA: 0x172E2F0
	public void ResetCenterOfMass() { }

	// RVA: 0x172E3D8
	public void ResetInertiaTensor() { }

	// RVA: 0x172E4C0
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	// RVA: 0x172E5CC
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

	// RVA: 0x172E728
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier) { }

	// RVA: 0x172E7F8
	public void .ctor() { }

	// RVA: 0x172D6F0
	private static void get_linearVelocity_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x172D7FC
	private static void set_linearVelocity_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x172D910
	private static void get_angularVelocity_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x172DA1C
	private static void set_angularVelocity_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x172DB34
	private static void SetDensity_Injected(IntPtr _unity_self, float density) { }

	// RVA: 0x172DC4C
	private static void set_useGravity_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x172DD4C
	private static bool get_isKinematic_Injected(IntPtr _unity_self) { }

	// RVA: 0x172DE4C
	private static void set_isKinematic_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x172DF60
	private static void get_position_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x172E06C
	private static void set_position_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x172E17C
	private static void get_rotation_Injected(IntPtr _unity_self, Quaternion ret) { }

	// RVA: 0x172E288
	private static void set_rotation_Injected(IntPtr _unity_self, Quaternion value) { }

	// RVA: 0x172E388
	private static void ResetCenterOfMass_Injected(IntPtr _unity_self) { }

	// RVA: 0x172E470
	private static void ResetInertiaTensor_Injected(IntPtr _unity_self) { }

	// RVA: 0x172E574
	private static void AddRelativeForce_Injected(IntPtr _unity_self, Vector3 force, ForceMode mode) { }

	// RVA: 0x172E6A8
	private static void AddExplosionForce_Injected(IntPtr _unity_self, float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode) { }

}

// Namespace: UnityEngine
public class SphereCollider
{
	// Methods

	// RVA: 0x172E800
	public Vector3 get_center() { }

	// RVA: 0x172E914
	public float get_radius() { }

	// RVA: 0x172E9FC
	public void set_radius(float value) { }

	// RVA: 0x172E8AC
	private static void get_center_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x172E9AC
	private static float get_radius_Injected(IntPtr _unity_self) { }

	// RVA: 0x172EAAC
	private static void set_radius_Injected(IntPtr _unity_self, float value) { }

}

// Namespace: UnityEngine.LowLevelPhysics
public interface IGeometry
{
	// Methods

	// RVA: -1
	public abstract GeometryType get_GeometryType() { }

}

// Namespace: UnityEngine.LowLevelPhysics
public enum GeometryType
{
	// Fields
	public int value__; // 0x10
	public const GeometryType Sphere = 0;
	public const GeometryType Capsule = 2;
	public const GeometryType Box = 3;
	public const GeometryType ConvexMesh = 4;
	public const GeometryType TriangleMesh = 5;
	public const GeometryType Terrain = 6;
	public const GeometryType Invalid = 4294967295;
}

// Namespace: 
public struct <m_Blob>e__FixedBuffer
{
	// Fields
	public UInt32 FixedElementField; // 0x10
}

// Namespace: UnityEngine.LowLevelPhysics
public struct GeometryHolder
{
	// Fields
	private int m_Type; // 0x10
	private UInt32 m_DataStart; // 0x14
	private IntPtr m_FakePointer0; // 0x18
	private IntPtr m_FakePointer1; // 0x20
	private UnityEngine.LowLevelPhysics.GeometryHolder.<m_Blob>e__FixedBuffer m_Blob; // 0x28

	// Methods

	// RVA: 0x26AD93C
	public T As() { }

}


