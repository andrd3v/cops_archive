// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public sealed class SharedBetweenAnimatorsAttribute
{}

// Namespace: UnityEngine
public abstract class StateMachineBehaviour
{
	// Methods

	// RVA: 0x15C109C
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x15C10A0
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x15C10A4
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x15C10A8
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x15C10AC
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x15C10B0
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x15C10B4
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x15C10B8
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x15C10BC
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x15C10C0
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x15C10C4
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x15C10C8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x15C10CC
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x15C10D0
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x15C10D4
	protected void .ctor() { }

}

// Namespace: UnityEngine
public enum PlayMode
{
	// Fields
	public int value__; // 0x10
	public const PlayMode StopSameLayer = 0;
	public const PlayMode StopAll = 4;
}

// Namespace: UnityEngine
public enum QueueMode
{
	// Fields
	public int value__; // 0x10
	public const QueueMode CompleteOthers = 0;
	public const QueueMode PlayNow = 2;
}

// Namespace: UnityEngine
public enum AnimationBlendMode
{
	// Fields
	public int value__; // 0x10
	public const AnimationBlendMode Blend = 0;
	public const AnimationBlendMode Additive = 1;
}

// Namespace: UnityEngine
public enum AnimationPlayMode
{
	// Fields
	public int value__; // 0x10
	public const AnimationPlayMode Stop = 0;
	public const AnimationPlayMode Queue = 1;
	public const AnimationPlayMode Mix = 2;
}

// Namespace: UnityEngine
public enum AnimationCullingType
{
	// Fields
	public int value__; // 0x10
	public const AnimationCullingType AlwaysAnimate = 0;
	public const AnimationCullingType BasedOnRenderers = 1;
	public const AnimationCullingType BasedOnClipBounds = 2;
	public const AnimationCullingType BasedOnUserBounds = 3;
}

// Namespace: UnityEngine
internal enum AnimationEventSource
{
	// Fields
	public int value__; // 0x10
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;
}

// Namespace: 
private sealed class Enumerator
{
	// Fields
	private Animation m_Outer; // 0x10
	private int m_CurrentIndex; // 0x18

	// Methods

	// RVA: 0x15C22A0
	internal void .ctor(Animation outer) { }

	// RVA: 0x15C2878
	public object get_Current() { }

	// RVA: 0x15C28E8
	public bool MoveNext() { }

	// RVA: 0x15C2954
	public void Reset() { }

}

// Namespace: UnityEngine
public sealed class Animation
{
	// Methods

	// RVA: 0x15C10DC
	public AnimationClip get_clip() { }

	// RVA: 0x15C112C
	public void set_clip(AnimationClip value) { }

	// RVA: 0x15C1194
	public bool get_playAutomatically() { }

	// RVA: 0x15C11E4
	public void set_playAutomatically(bool value) { }

	// RVA: 0x15C124C
	public WrapMode get_wrapMode() { }

	// RVA: 0x15C129C
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x15C1304
	public void Stop() { }

	// RVA: 0x15C1354
	public void Stop(string name) { }

	// RVA: 0x15C13BC
	private void StopNamed(string name) { }

	// RVA: 0x15C1424
	public void Rewind() { }

	// RVA: 0x15C1474
	public void Rewind(string name) { }

	// RVA: 0x15C14DC
	private void RewindNamed(string name) { }

	// RVA: 0x15C1544
	public void Sample() { }

	// RVA: 0x15C1594
	public bool get_isPlaying() { }

	// RVA: 0x15C15E4
	public bool IsPlaying(string name) { }

	// RVA: 0x15C164C
	public AnimationState get_Item(string name) { }

	// RVA: 0x15C171C
	public bool Play() { }

	// RVA: 0x15C1774
	public bool Play(PlayMode mode) { }

	// RVA: 0x15C17DC
	private bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x15C1844
	public bool Play(string animation) { }

	// RVA: 0x15C1898
	public bool Play(string animation, PlayMode mode) { }

	// RVA: 0x15C18F0
	public void CrossFade(string animation) { }

	// RVA: 0x15C1950
	public void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x15C19B4
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	// RVA: 0x15C1A1C
	public void Blend(string animation) { }

	// RVA: 0x15C1A7C
	public void Blend(string animation, float targetWeight) { }

	// RVA: 0x15C1AE8
	public void Blend(string animation, float targetWeight, float fadeLength) { }

	// RVA: 0x15C1B50
	public AnimationState CrossFadeQueued(string animation) { }

	// RVA: 0x15C1BB4
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	// RVA: 0x15C1C1C
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	// RVA: 0x15C1C88
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	// RVA: 0x15C1D00
	public AnimationState PlayQueued(string animation) { }

	// RVA: 0x15C1D58
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	// RVA: 0x15C1DB4
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0x15C1E1C
	public void AddClip(AnimationClip clip, string newName) { }

	// RVA: 0x15C1E80
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	// RVA: 0x15C1EF4
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x15C1F74
	public void RemoveClip(AnimationClip clip) { }

	// RVA: 0x15C1FDC
	public void RemoveClip(string clipName) { }

	// RVA: 0x15C2044
	private void RemoveClipNamed(string clipName) { }

	// RVA: 0x15C20AC
	public int GetClipCount() { }

	// RVA: 0x15C20FC
	public bool Play(AnimationPlayMode mode) { }

	// RVA: 0x15C2164
	public bool Play(string animation, AnimationPlayMode mode) { }

	// RVA: 0x15C21BC
	public void SyncLayer(int layer) { }

	// RVA: 0x15C2224
	public IEnumerator GetEnumerator() { }

	// RVA: 0x15C16B4
	internal AnimationState GetState(string name) { }

	// RVA: 0x15C22DC
	internal AnimationState GetStateAtIndex(int index) { }

	// RVA: 0x15C2344
	internal int GetStateCount() { }

	// RVA: 0x15C2394
	public AnimationClip GetClip(string name) { }

	// RVA: 0x15C249C
	public bool get_animatePhysics() { }

	// RVA: 0x15C24EC
	public void set_animatePhysics(bool value) { }

	// RVA: 0x15C2554
	public bool get_animateOnlyIfVisible() { }

	// RVA: 0x15C25A4
	public void set_animateOnlyIfVisible(bool value) { }

	// RVA: 0x15C260C
	public AnimationCullingType get_cullingType() { }

	// RVA: 0x15C265C
	public void set_cullingType(AnimationCullingType value) { }

	// RVA: 0x15C26C4
	public Bounds get_localBounds() { }

	// RVA: 0x15C27A0
	public void set_localBounds(Bounds value) { }

	// RVA: 0x15C2870
	public void .ctor() { }

	// RVA: 0x15C2738
	private void get_localBounds_Injected(Bounds ret) { }

	// RVA: 0x15C2808
	private void set_localBounds_Injected(Bounds value) { }

}

// Namespace: UnityEngine
public sealed class AnimationState
{
	// Methods

	// RVA: 0x15C2960
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x15C29C8
	public void set_time(float value) { }

	// RVA: 0x15C2A30
	public void set_speed(float value) { }

	// RVA: 0x15C2A98
	public float get_length() { }

	// RVA: 0x15C2AE8
	public void set_layer(int value) { }

	// RVA: 0x15C244C
	public AnimationClip get_clip() { }

	// RVA: 0x15C2B50
	public string get_name() { }

	// RVA: 0x15C2BA0
	public void set_blendMode(AnimationBlendMode value) { }

	// RVA: 0x15C2C08
	public void .ctor() { }

}

// Namespace: UnityEngine
[Serializable]
public sealed class AnimationEvent
{
	// Fields
	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Methods

	// RVA: 0x15C2C10
	public void .ctor() { }

	// RVA: 0x15C2CAC
	public string get_stringParameter() { }

}

// Namespace: UnityEngine
public sealed class AnimationClip
{
	// Methods

	// RVA: 0x15C2CB4
	public void .ctor() { }

	// RVA: 0x15C2E00
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x15C2E50
	public float get_length() { }

}

// Namespace: UnityEngine
public enum AvatarTarget
{
	// Fields
	public int value__; // 0x10
	public const AvatarTarget Root = 0;
	public const AvatarTarget Body = 1;
	public const AvatarTarget LeftFoot = 2;
	public const AvatarTarget RightFoot = 3;
	public const AvatarTarget LeftHand = 4;
	public const AvatarTarget RightHand = 5;
}

// Namespace: UnityEngine
public enum AvatarIKGoal
{
	// Fields
	public int value__; // 0x10
	public const AvatarIKGoal LeftFoot = 0;
	public const AvatarIKGoal RightFoot = 1;
	public const AvatarIKGoal LeftHand = 2;
	public const AvatarIKGoal RightHand = 3;
}

// Namespace: UnityEngine
public enum AvatarIKHint
{
	// Fields
	public int value__; // 0x10
	public const AvatarIKHint LeftKnee = 0;
	public const AvatarIKHint RightKnee = 1;
	public const AvatarIKHint LeftElbow = 2;
	public const AvatarIKHint RightElbow = 3;
}

// Namespace: UnityEngine
public enum AnimatorControllerParameterType
{
	// Fields
	public int value__; // 0x10
	public const AnimatorControllerParameterType Float = 1;
	public const AnimatorControllerParameterType Int = 3;
	public const AnimatorControllerParameterType Bool = 4;
	public const AnimatorControllerParameterType Trigger = 9;
}

// Namespace: UnityEngine
internal enum StateInfoIndex
{
	// Fields
	public int value__; // 0x10
	public const StateInfoIndex CurrentState = 0;
	public const StateInfoIndex NextState = 1;
	public const StateInfoIndex ExitState = 2;
	public const StateInfoIndex InterruptedState = 3;
}

// Namespace: UnityEngine
public enum AnimatorRecorderMode
{
	// Fields
	public int value__; // 0x10
	public const AnimatorRecorderMode Offline = 0;
	public const AnimatorRecorderMode Playback = 1;
	public const AnimatorRecorderMode Record = 2;
}

// Namespace: UnityEngine
public enum AnimatorCullingMode
{
	// Fields
	public int value__; // 0x10
	public const AnimatorCullingMode AlwaysAnimate = 0;
	public const AnimatorCullingMode CullUpdateTransforms = 1;
	public const AnimatorCullingMode CullCompletely = 2;
}

// Namespace: UnityEngine
public enum AnimatorUpdateMode
{
	// Fields
	public int value__; // 0x10
	public const AnimatorUpdateMode Normal = 0;
	public const AnimatorUpdateMode AnimatePhysics = 1;
	public const AnimatorUpdateMode UnscaledTime = 2;
}

// Namespace: UnityEngine
public struct AnimatorClipInfo
{
	// Fields
	private int m_ClipInstanceID; // 0x10
	private float m_Weight; // 0x14
}

// Namespace: UnityEngine
public struct AnimatorStateInfo
{
	// Fields
	private int m_Name; // 0x10
	private int m_Path; // 0x14
	private int m_FullPath; // 0x18
	private float m_NormalizedTime; // 0x1C
	private float m_Length; // 0x20
	private float m_Speed; // 0x24
	private float m_SpeedMultiplier; // 0x28
	private int m_Tag; // 0x2C
	private int m_Loop; // 0x30

	// Methods

	// RVA: 0x15C2EA0
	public int get_shortNameHash() { }

	// RVA: 0x15C2EA8
	public float get_normalizedTime() { }

	// RVA: 0x15C2EB0
	public bool get_loop() { }

}

// Namespace: UnityEngine
public struct AnimatorTransitionInfo
{
	// Fields
	private int m_FullPath; // 0x10
	private int m_UserName; // 0x14
	private int m_Name; // 0x18
	private bool m_HasFixedDuration; // 0x1C
	private float m_Duration; // 0x20
	private float m_NormalizedTime; // 0x24
	private bool m_AnyState; // 0x28
	private int m_TransitionType; // 0x2C
}

// Namespace: UnityEngine
public struct MatchTargetWeightMask
{
	// Fields
	private Vector3 m_PositionXYZWeight; // 0x10
	private float m_RotationWeight; // 0x1C
}

// Namespace: UnityEngine
public class Animator
{
	// Methods

	// RVA: 0x15C2EC0
	public bool get_isOptimizable() { }

	// RVA: 0x15C2F10
	public bool get_isHuman() { }

	// RVA: 0x15C2F60
	public bool get_hasRootMotion() { }

	// RVA: 0x15C2FB0
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0x15C3000
	public float get_humanScale() { }

	// RVA: 0x15C3050
	public bool get_isInitialized() { }

	// RVA: 0x15C30A0
	public float GetFloat(string name) { }

	// RVA: 0x15C3170
	public float GetFloat(int id) { }

	// RVA: 0x15C3240
	public void SetFloat(string name, float value) { }

	// RVA: 0x15C3300
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x15C33F0
	public void SetFloat(int id, float value) { }

	// RVA: 0x15C34B0
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x15C35A0
	public bool GetBool(string name) { }

	// RVA: 0x15C3670
	public bool GetBool(int id) { }

	// RVA: 0x15C3740
	public void SetBool(string name, bool value) { }

	// RVA: 0x15C37F0
	public void SetBool(int id, bool value) { }

	// RVA: 0x15C38A0
	public int GetInteger(string name) { }

	// RVA: 0x15C3970
	public int GetInteger(int id) { }

	// RVA: 0x15C3A40
	public void SetInteger(string name, int value) { }

	// RVA: 0x15C3AF0
	public void SetInteger(int id, int value) { }

	// RVA: 0x15C3BA0
	public void SetTrigger(string name) { }

	// RVA: 0x15C3C70
	public void SetTrigger(int id) { }

	// RVA: 0x15C3D40
	public void ResetTrigger(string name) { }

	// RVA: 0x15C3E10
	public void ResetTrigger(int id) { }

	// RVA: 0x15C3EE0
	public bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x15C3FB0
	public bool IsParameterControlledByCurve(int id) { }

	// RVA: 0x15C4080
	public Vector3 get_deltaPosition() { }

	// RVA: 0x15C4148
	public Quaternion get_deltaRotation() { }

	// RVA: 0x15C420C
	public Vector3 get_velocity() { }

	// RVA: 0x15C42D4
	public Vector3 get_angularVelocity() { }

	// RVA: 0x15C439C
	public Vector3 get_rootPosition() { }

	// RVA: 0x15C4464
	public void set_rootPosition(Vector3 value) { }

	// RVA: 0x15C4524
	public Quaternion get_rootRotation() { }

	// RVA: 0x15C45E8
	public void set_rootRotation(Quaternion value) { }

	// RVA: 0x15C46A8
	public bool get_applyRootMotion() { }

	// RVA: 0x15C46F8
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x15C4760
	public bool get_linearVelocityBlending() { }

	// RVA: 0x15C47B0
	public void set_linearVelocityBlending(bool value) { }

	// RVA: 0x15C4818
	public bool get_animatePhysics() { }

	// RVA: 0x15C48B4
	public void set_animatePhysics(bool value) { }

	// RVA: 0x15C4864
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x15C4924
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x15C498C
	public bool get_hasTransformHierarchy() { }

	// RVA: 0x15C49DC
	internal bool get_allowConstantClipSamplingOptimization() { }

	// RVA: 0x15C4A2C
	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	// RVA: 0x15C4A94
	public float get_gravityWeight() { }

	// RVA: 0x15C4AE4
	public Vector3 get_bodyPosition() { }

	// RVA: 0x15C4CA4
	public void set_bodyPosition(Vector3 value) { }

	// RVA: 0x15C4C44
	internal Vector3 get_bodyPositionInternal() { }

	// RVA: 0x15C4D1C
	internal void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0x15C4E44
	public Quaternion get_bodyRotation() { }

	// RVA: 0x15C4F00
	public void set_bodyRotation(Quaternion value) { }

	// RVA: 0x15C4EA4
	internal Quaternion get_bodyRotationInternal() { }

	// RVA: 0x15C4F7C
	internal void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0x15C50A4
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x15C5118
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0x15C51E0
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x15C5268
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x15C5328
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x15C5398
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0x15C545C
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x15C54E8
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x15C55A8
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x15C5614
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x15C567C
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x15C56E0
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x15C5740
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x15C57AC
	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0x15C5814
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x15C5878
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x15C58D8
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0x15C594C
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0x15C5A14
	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x15C5A9C
	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x15C5B5C
	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0x15C5BC8
	private float GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0x15C5C30
	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	// RVA: 0x15C5C94
	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	// RVA: 0x15C5CF4
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	// RVA: 0x15C5D6C
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x15C5E2C
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x15C5F10
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x15C5F78
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x15C5FEC
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x15C6064
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x15C5E90
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x15C60E8
	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	// RVA: 0x15C61F0
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x15C62B0
	private ScriptableObject GetBehaviour(Type type) { }

	// RVA: 0x318DB98
	public T GetBehaviour() { }

	// RVA: 0x30D77E4
	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	// RVA: 0x30D3CF0
	public T[] GetBehaviours() { }

	// RVA: 0x15C6318
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0x15C6380
	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	// RVA: 0x15C6460
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x15C64C8
	public bool get_stabilizeFeet() { }

	// RVA: 0x15C6518
	public void set_stabilizeFeet(bool value) { }

	// RVA: 0x15C6580
	public int get_layerCount() { }

	// RVA: 0x15C65D0
	public string GetLayerName(int layerIndex) { }

	// RVA: 0x15C6638
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x15C66A0
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x15C6708
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x15C6768
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, AnimatorStateInfo info) { }

	// RVA: 0x15C67D0
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x15C6854
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x15C68D8
	private void GetAnimatorTransitionInfo(int layerIndex, AnimatorTransitionInfo info) { }

	// RVA: 0x15C6930
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x15C69A4
	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	// RVA: 0x15C69FC
	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x15C6A50
	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x15C6AA4
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x15C6B0C
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x15C6B74
	public void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x15C6C1C
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x15C6C84
	public void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x15C6D2C
	public bool IsInTransition(int layerIndex) { }

	// RVA: 0x15C6D94
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x15C6DE4
	public int get_parameterCount() { }

	// RVA: 0x15C6E34
	private AnimatorControllerParameter GetParameterInternal(int index) { }

	// RVA: 0x15C6E9C
	public AnimatorControllerParameter GetParameter(int index) { }

	// RVA: 0x15C6F78
	public float get_feetPivotActive() { }

	// RVA: 0x15C6FC8
	public void set_feetPivotActive(float value) { }

	// RVA: 0x15C7030
	public float get_pivotWeight() { }

	// RVA: 0x15C7080
	public Vector3 get_pivotPosition() { }

	// RVA: 0x15C7148
	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x15C727C
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	// RVA: 0x15C7314
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	// RVA: 0x15C73AC
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x15C7448
	public void InterruptMatchTarget() { }

	// RVA: 0x15C74A0
	public void InterruptMatchTarget(bool completeMatch) { }

	// RVA: 0x15C7508
	public bool get_isMatchingTarget() { }

	// RVA: 0x15C7558
	public float get_speed() { }

	// RVA: 0x15C75A8
	public void set_speed(float value) { }

	// RVA: 0x15C7610
	public void ForceStateNormalizedTime(float normalizedTime) { }

	// RVA: 0x15C76D0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	// RVA: 0x15C7854
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x15C790C
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x15C79C8
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x15C7A90
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x15C7B04
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x15C7B74
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	// RVA: 0x15C77D4
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x15C7BE0
	public void WriteDefaultValues() { }

	// RVA: 0x15C7C30
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x15C7DB4
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x15C7E70
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x15C7CEC
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x15C7F28
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x15C7FA8
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x15C801C
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x15C8090
	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	// RVA: 0x15C8100
	public void PlayInFixedTime(string stateName, int layer) { }

	// RVA: 0x15C8258
	public void PlayInFixedTime(string stateName) { }

	// RVA: 0x15C81A8
	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	// RVA: 0x15C82FC
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x15C8364
	public void PlayInFixedTime(int stateNameHash, int layer) { }

	// RVA: 0x15C83C4
	public void PlayInFixedTime(int stateNameHash) { }

	// RVA: 0x15C8420
	public void Play(string stateName, int layer) { }

	// RVA: 0x15C8578
	public void Play(string stateName) { }

	// RVA: 0x15C84C8
	public void Play(string stateName, int layer, float normalizedTime) { }

	// RVA: 0x15C7668
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x15C861C
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x15C867C
	public void Play(int stateNameHash) { }

	// RVA: 0x15C86D8
	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x15C8738
	public Vector3 get_targetPosition() { }

	// RVA: 0x15C8800
	public Quaternion get_targetRotation() { }

	// RVA: 0x15C88C4
	public bool IsControlled(Transform transform) { }

	// RVA: 0x15C88CC
	internal bool IsBoneTransform(Transform transform) { }

	// RVA: 0x15C8934
	public Transform get_avatarRoot() { }

	// RVA: 0x15C8984
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	// RVA: 0x15C8D98
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x15C8E00
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x15C8E50
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x15C8EB8
	public void StartPlayback() { }

	// RVA: 0x15C8F08
	public void StopPlayback() { }

	// RVA: 0x15C8F58
	public float get_playbackTime() { }

	// RVA: 0x15C8FA8
	public void set_playbackTime(float value) { }

	// RVA: 0x15C9010
	public void StartRecording(int frameCount) { }

	// RVA: 0x15C9078
	public void StopRecording() { }

	// RVA: 0x15C90C8
	public float get_recorderStartTime() { }

	// RVA: 0x15C9168
	public void set_recorderStartTime(float value) { }

	// RVA: 0x15C9118
	private float GetRecorderStartTime() { }

	// RVA: 0x15C916C
	public float get_recorderStopTime() { }

	// RVA: 0x15C920C
	public void set_recorderStopTime(float value) { }

	// RVA: 0x15C91BC
	private float GetRecorderStopTime() { }

	// RVA: 0x15C9210
	public AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0x15C9260
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x15C92B0
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x15C9318
	public bool get_hasBoundPlayables() { }

	// RVA: 0x15C9368
	internal void ClearInternalControllerPlayable() { }

	// RVA: 0x15C93B8
	public bool HasState(int layerIndex, int stateID) { }

	// RVA: 0x15C7784
	public static int StringToHash(string name) { }

	// RVA: 0x15C8CA8
	public Avatar get_avatar() { }

	// RVA: 0x15C9410
	public void set_avatar(Avatar value) { }

	// RVA: 0x15C9478
	internal string GetStats() { }

	// RVA: 0x15C94C8
	public PlayableGraph get_playableGraph() { }

	// RVA: 0x15C9520
	private void GetCurrentGraph(PlayableGraph graph) { }

	// RVA: 0x15C4B48
	private void CheckIfInIKPass() { }

	// RVA: 0x15C95D8
	private bool IsInIKPass() { }

	// RVA: 0x15C32A0
	private void SetFloatString(string name, float value) { }

	// RVA: 0x15C3450
	private void SetFloatID(int id, float value) { }

	// RVA: 0x15C3108
	private float GetFloatString(string name) { }

	// RVA: 0x15C31D8
	private float GetFloatID(int id) { }

	// RVA: 0x15C3798
	private void SetBoolString(string name, bool value) { }

	// RVA: 0x15C3848
	private void SetBoolID(int id, bool value) { }

	// RVA: 0x15C3608
	private bool GetBoolString(string name) { }

	// RVA: 0x15C36D8
	private bool GetBoolID(int id) { }

	// RVA: 0x15C3A98
	private void SetIntegerString(string name, int value) { }

	// RVA: 0x15C3B48
	private void SetIntegerID(int id, int value) { }

	// RVA: 0x15C3908
	private int GetIntegerString(string name) { }

	// RVA: 0x15C39D8
	private int GetIntegerID(int id) { }

	// RVA: 0x15C3C08
	private void SetTriggerString(string name) { }

	// RVA: 0x15C3CD8
	private void SetTriggerID(int id) { }

	// RVA: 0x15C3DA8
	private void ResetTriggerString(string name) { }

	// RVA: 0x15C3E78
	private void ResetTriggerID(int id) { }

	// RVA: 0x15C3F48
	private bool IsParameterControlledByCurveString(string name) { }

	// RVA: 0x15C4018
	private bool IsParameterControlledByCurveID(int id) { }

	// RVA: 0x15C3378
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x15C3528
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x15C9628
	public bool get_layersAffectMassCenter() { }

	// RVA: 0x15C9678
	public void set_layersAffectMassCenter(bool value) { }

	// RVA: 0x15C96E0
	public float get_leftFeetBottomHeight() { }

	// RVA: 0x15C9730
	public float get_rightFeetBottomHeight() { }

	// RVA: 0x15C9780
	internal bool get_supportsOnAnimatorMove() { }

	// RVA: 0x15C97D0
	internal void OnUpdateModeChanged() { }

	// RVA: 0x15C9820
	internal void OnCullingModeChanged() { }

	// RVA: 0x15C9870
	internal void WriteDefaultPose() { }

	// RVA: 0x15C98C0
	public void Update(float deltaTime) { }

	// RVA: 0x15C9928
	public void Rebind() { }

	// RVA: 0x15C9980
	private void Rebind(bool writeDefaultValues) { }

	// RVA: 0x15C99E8
	public void ApplyBuiltinRootMotion() { }

	// RVA: 0x15C9A38
	internal void EvaluateController() { }

	// RVA: 0x15C9A90
	private void EvaluateController(float deltaTime) { }

	// RVA: 0x15C9AF8
	internal string GetCurrentStateName(int layerIndex) { }

	// RVA: 0x15C9BA4
	internal string GetNextStateName(int layerIndex) { }

	// RVA: 0x15C9B4C
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	// RVA: 0x15C9BF8
	internal string ResolveHash(int hash) { }

	// RVA: 0x15C9588
	public bool get_logWarnings() { }

	// RVA: 0x15C9C60
	public void set_logWarnings(bool value) { }

	// RVA: 0x15C9CC8
	public bool get_fireEvents() { }

	// RVA: 0x15C9D18
	public void set_fireEvents(bool value) { }

	// RVA: 0x15C9D80
	public bool get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0x15C9E20
	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	// RVA: 0x15C9DD0
	public bool get_keepAnimatorStateOnDisable() { }

	// RVA: 0x15C9E88
	public void set_keepAnimatorStateOnDisable(bool value) { }

	// RVA: 0x15C9EF0
	public bool get_writeDefaultValuesOnDisable() { }

	// RVA: 0x15C9F40
	public void set_writeDefaultValuesOnDisable(bool value) { }

	// RVA: 0x15C9FA8
	public Vector3 GetVector(string name) { }

	// RVA: 0x15C9FF8
	public Vector3 GetVector(int id) { }

	// RVA: 0x15CA048
	public void SetVector(string name, Vector3 value) { }

	// RVA: 0x15CA04C
	public void SetVector(int id, Vector3 value) { }

	// RVA: 0x15CA050
	public Quaternion GetQuaternion(string name) { }

	// RVA: 0x15CA0A0
	public Quaternion GetQuaternion(int id) { }

	// RVA: 0x15CA0F0
	public void SetQuaternion(string name, Quaternion value) { }

	// RVA: 0x15CA0F4
	public void SetQuaternion(int id, Quaternion value) { }

	// RVA: 0x15CA0F8
	public void .ctor() { }

	// RVA: 0x15C40E0
	private void get_deltaPosition_Injected(Vector3 ret) { }

	// RVA: 0x15C41A4
	private void get_deltaRotation_Injected(Quaternion ret) { }

	// RVA: 0x15C426C
	private void get_velocity_Injected(Vector3 ret) { }

	// RVA: 0x15C4334
	private void get_angularVelocity_Injected(Vector3 ret) { }

	// RVA: 0x15C43FC
	private void get_rootPosition_Injected(Vector3 ret) { }

	// RVA: 0x15C44BC
	private void set_rootPosition_Injected(Vector3 value) { }

	// RVA: 0x15C4580
	private void get_rootRotation_Injected(Quaternion ret) { }

	// RVA: 0x15C4640
	private void set_rootRotation_Injected(Quaternion value) { }

	// RVA: 0x15C4D74
	private void get_bodyPositionInternal_Injected(Vector3 ret) { }

	// RVA: 0x15C4DDC
	private void set_bodyPositionInternal_Injected(Vector3 value) { }

	// RVA: 0x15C4FD4
	private void get_bodyRotationInternal_Injected(Quaternion ret) { }

	// RVA: 0x15C503C
	private void set_bodyRotationInternal_Injected(Quaternion value) { }

	// RVA: 0x15C5188
	private void GetGoalPosition_Injected(AvatarIKGoal goal, Vector3 ret) { }

	// RVA: 0x15C52D0
	private void SetGoalPosition_Injected(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x15C5404
	private void GetGoalRotation_Injected(AvatarIKGoal goal, Quaternion ret) { }

	// RVA: 0x15C5550
	private void SetGoalRotation_Injected(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x15C59BC
	private void GetHintPosition_Injected(AvatarIKHint hint, Vector3 ret) { }

	// RVA: 0x15C5B04
	private void SetHintPosition_Injected(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x15C5DC4
	private void SetLookAtPositionInternal_Injected(Vector3 lookAtPosition) { }

	// RVA: 0x15C6258
	private void SetBoneLocalRotationInternal_Injected(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x15C70E0
	private void get_pivotPosition_Injected(Vector3 ret) { }

	// RVA: 0x15C71E4
	private void MatchTarget_Injected(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x15C8798
	private void get_targetPosition_Injected(Vector3 ret) { }

	// RVA: 0x15C885C
	private void get_targetRotation_Injected(Quaternion ret) { }

}

// Namespace: UnityEngine
public class AnimatorControllerParameter
{
	// Fields
	internal string m_Name; // 0x10
	internal AnimatorControllerParameterType m_Type; // 0x18
	internal float m_DefaultFloat; // 0x1C
	internal int m_DefaultInt; // 0x20
	internal bool m_DefaultBool; // 0x24

	// Methods

	// RVA: 0x15CA100
	public string get_name() { }

	// RVA: 0x15CA108
	public override bool Equals(object o) { }

	// RVA: 0x15CA204
	public override int GetHashCode() { }

	// RVA: 0x15CA228
	public void .ctor() { }

}

// Namespace: UnityEngine
[Serializable]
public class AnimationClipPair
{
	// Fields
	public AnimationClip originalClip; // 0x10
	public AnimationClip overrideClip; // 0x18

	// Methods

	// RVA: 0x15CA28C
	public void .ctor() { }

}

// Namespace: 
internal sealed class OnOverrideControllerDirtyCallback
{
	// Methods

	// RVA: 0x15CB36C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15CB40C
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public class AnimatorOverrideController
{
	// Fields
	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Methods

	// RVA: 0x15CA294
	public void .ctor() { }

	// RVA: 0x15CA44C
	public void .ctor(RuntimeAnimatorController controller) { }

	// RVA: 0x15CA3E4
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	// RVA: 0x15CA518
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x15CA568
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x15CA5D0
	public AnimationClip get_Item(string name) { }

	// RVA: 0x15CA67C
	public void set_Item(string name, AnimationClip value) { }

	// RVA: 0x15CA624
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	// RVA: 0x15CA6D4
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	// RVA: 0x15CA72C
	public AnimationClip get_Item(AnimationClip clip) { }

	// RVA: 0x15CA7D8
	public void set_Item(AnimationClip clip, AnimationClip value) { }

	// RVA: 0x15CA780
	private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	// RVA: 0x15CA834
	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

	// RVA: 0x15CA89C
	private void SendNotification() { }

	// RVA: 0x15CA8EC
	private AnimationClip GetOriginalClip(int index) { }

	// RVA: 0x15CA954
	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	// RVA: 0x15CA9BC
	public int get_overridesCount() { }

	// RVA: 0x15CAA0C
	public void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x15CAC80
	public void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x15CB018
	public AnimationClipPair[] get_clips() { }

	// RVA: 0x15CB214
	public void set_clips(AnimationClipPair[] value) { }

	// RVA: 0x15CB2E8
	internal void PerformOverrideClipListCleanup() { }

	// RVA: 0x15CB338
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

}

// Namespace: UnityEngine
public enum HumanBodyBones
{
	// Fields
	public int value__; // 0x10
	public const HumanBodyBones Hips = 0;
	public const HumanBodyBones LeftUpperLeg = 1;
	public const HumanBodyBones RightUpperLeg = 2;
	public const HumanBodyBones LeftLowerLeg = 3;
	public const HumanBodyBones RightLowerLeg = 4;
	public const HumanBodyBones LeftFoot = 5;
	public const HumanBodyBones RightFoot = 6;
	public const HumanBodyBones Spine = 7;
	public const HumanBodyBones Chest = 8;
	public const HumanBodyBones UpperChest = 54;
	public const HumanBodyBones Neck = 9;
	public const HumanBodyBones Head = 10;
	public const HumanBodyBones LeftShoulder = 11;
	public const HumanBodyBones RightShoulder = 12;
	public const HumanBodyBones LeftUpperArm = 13;
	public const HumanBodyBones RightUpperArm = 14;
	public const HumanBodyBones LeftLowerArm = 15;
	public const HumanBodyBones RightLowerArm = 16;
	public const HumanBodyBones LeftHand = 17;
	public const HumanBodyBones RightHand = 18;
	public const HumanBodyBones LeftToes = 19;
	public const HumanBodyBones RightToes = 20;
	public const HumanBodyBones LeftEye = 21;
	public const HumanBodyBones RightEye = 22;
	public const HumanBodyBones Jaw = 23;
	public const HumanBodyBones LeftThumbProximal = 24;
	public const HumanBodyBones LeftThumbIntermediate = 25;
	public const HumanBodyBones LeftThumbDistal = 26;
	public const HumanBodyBones LeftIndexProximal = 27;
	public const HumanBodyBones LeftIndexIntermediate = 28;
	public const HumanBodyBones LeftIndexDistal = 29;
	public const HumanBodyBones LeftMiddleProximal = 30;
	public const HumanBodyBones LeftMiddleIntermediate = 31;
	public const HumanBodyBones LeftMiddleDistal = 32;
	public const HumanBodyBones LeftRingProximal = 33;
	public const HumanBodyBones LeftRingIntermediate = 34;
	public const HumanBodyBones LeftRingDistal = 35;
	public const HumanBodyBones LeftLittleProximal = 36;
	public const HumanBodyBones LeftLittleIntermediate = 37;
	public const HumanBodyBones LeftLittleDistal = 38;
	public const HumanBodyBones RightThumbProximal = 39;
	public const HumanBodyBones RightThumbIntermediate = 40;
	public const HumanBodyBones RightThumbDistal = 41;
	public const HumanBodyBones RightIndexProximal = 42;
	public const HumanBodyBones RightIndexIntermediate = 43;
	public const HumanBodyBones RightIndexDistal = 44;
	public const HumanBodyBones RightMiddleProximal = 45;
	public const HumanBodyBones RightMiddleIntermediate = 46;
	public const HumanBodyBones RightMiddleDistal = 47;
	public const HumanBodyBones RightRingProximal = 48;
	public const HumanBodyBones RightRingIntermediate = 49;
	public const HumanBodyBones RightRingDistal = 50;
	public const HumanBodyBones RightLittleProximal = 51;
	public const HumanBodyBones RightLittleIntermediate = 52;
	public const HumanBodyBones RightLittleDistal = 53;
	public const HumanBodyBones LastBone = 55;
}

// Namespace: UnityEngine
public class Avatar
{
	// Methods

	// RVA: 0x15CB420
	private void .ctor() { }

	// RVA: 0x15C8CF8
	public bool get_isValid() { }

	// RVA: 0x15C8D48
	public bool get_isHuman() { }

}

// Namespace: UnityEngine
public struct SkeletonBone
{
	// Fields
	public string name; // 0x10
	internal string parentName; // 0x18
	public Vector3 position; // 0x20
	public Quaternion rotation; // 0x2C
	public Vector3 scale; // 0x3C
}

// Namespace: UnityEngine
public struct HumanLimit
{
	// Fields
	private Vector3 m_Min; // 0x10
	private Vector3 m_Max; // 0x1C
	private Vector3 m_Center; // 0x28
	private float m_AxisLength; // 0x34
	private int m_UseDefaultValues; // 0x38
}

// Namespace: UnityEngine
public struct HumanBone
{
	// Fields
	private string m_BoneName; // 0x10
	private string m_HumanName; // 0x18
	public HumanLimit limit; // 0x20
}

// Namespace: UnityEngine
public class HumanTrait
{
	// Methods

	// RVA: 0x15C61A0
	internal static int GetBoneIndexFromMono(int humanId) { }

}

// Namespace: UnityEngine
public class Motion
{
	// Fields
	private readonly bool <isAnimatorMotion>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15C2D78
	protected void .ctor() { }

}

// Namespace: UnityEngine
public class RuntimeAnimatorController
{
	// Methods

	// RVA: 0x15CA35C
	protected void .ctor() { }

	// RVA: 0x15CB4A8
	public AnimationClip[] get_animationClips() { }

}

// Namespace: UnityEngine.Animations
public class DiscreteEvaluationAttribute
{}

// Namespace: UnityEngine.Animations
public class NotKeyableAttribute
{}

// Namespace: UnityEngine.Animations
public struct AnimationClipPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x15CB4F8
	public PlayableHandle GetHandle() { }

	// RVA: 0x15CB504
	public bool Equals(AnimationClipPlayable other) { }

}

// Namespace: UnityEngine.Animations
public struct AnimationHumanStream
{
	// Fields
	private IntPtr stream; // 0x10
}

// Namespace: UnityEngine.Animations
public struct AnimationLayerMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15CB588
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization) { }

	// RVA: 0x15CB770
	public PlayableHandle GetHandle() { }

	// RVA: 0x15CB77C
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x15CB708
	private static void SetSingleLayerOptimizationInternal(PlayableHandle handle, bool value) { }

	// RVA: 0x15CB84C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15CB8F0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15CBA0C
	public PlayableHandle GetHandle() { }

	// RVA: 0x15CBA18
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x15CBAE8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationMotionXToDeltaPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15CBB88
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x15CBCA4
	public PlayableHandle GetHandle() { }

	// RVA: 0x15CBCB0
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x15CBD80
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationOffsetPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15CBE20
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15CBF3C
	public PlayableHandle GetHandle() { }

	// RVA: 0x15CBF48
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x15CC004
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationPlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
}

// Namespace: UnityEngine.Animations
internal struct AnimationPosePlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15CC0A4
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15CC1C0
	public PlayableHandle GetHandle() { }

	// RVA: 0x15CC1CC
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x15CC288
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationRemoveScalePlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15CC328
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15CC444
	public PlayableHandle GetHandle() { }

	// RVA: 0x15CC450
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x15CC50C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationScriptPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15CC5AC
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15CC6C8
	public PlayableHandle GetHandle() { }

	// RVA: 0x15CC6D4
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x15CC7A4
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationStream
{
	// Fields
	private UInt32 m_AnimatorBindingsVersion; // 0x10
	private IntPtr constant; // 0x18
	private IntPtr input; // 0x20
	private IntPtr output; // 0x28
	private IntPtr workspace; // 0x30
	private IntPtr inputStreamAccessor; // 0x38
	private IntPtr animationHandleBinder; // 0x40
}

// Namespace: UnityEngine.Animations
public struct AnimatorControllerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15CC844
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15CCAB0
	public PlayableHandle GetHandle() { }

	// RVA: 0x15CC91C
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x15CCABC
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x15CCB8C
	private static void .cctor() { }

}


