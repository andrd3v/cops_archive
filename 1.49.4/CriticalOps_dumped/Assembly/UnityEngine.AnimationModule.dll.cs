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

	// RVA: 0x158EBA4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x158EBA8
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x158EBAC
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x158EBB0
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x158EBB4
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x158EBB8
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x158EBBC
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x158EBC0
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x158EBC4
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x158EBC8
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x158EBCC
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x158EBD0
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x158EBD4
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x158EBD8
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x158EBDC
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

	// RVA: 0x158FDA8
	internal void .ctor(Animation outer) { }

	// RVA: 0x1590380
	public object get_Current() { }

	// RVA: 0x15903F0
	public bool MoveNext() { }

	// RVA: 0x159045C
	public void Reset() { }

}

// Namespace: UnityEngine
public sealed class Animation
{
	// Methods

	// RVA: 0x158EBE4
	public AnimationClip get_clip() { }

	// RVA: 0x158EC34
	public void set_clip(AnimationClip value) { }

	// RVA: 0x158EC9C
	public bool get_playAutomatically() { }

	// RVA: 0x158ECEC
	public void set_playAutomatically(bool value) { }

	// RVA: 0x158ED54
	public WrapMode get_wrapMode() { }

	// RVA: 0x158EDA4
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x158EE0C
	public void Stop() { }

	// RVA: 0x158EE5C
	public void Stop(string name) { }

	// RVA: 0x158EEC4
	private void StopNamed(string name) { }

	// RVA: 0x158EF2C
	public void Rewind() { }

	// RVA: 0x158EF7C
	public void Rewind(string name) { }

	// RVA: 0x158EFE4
	private void RewindNamed(string name) { }

	// RVA: 0x158F04C
	public void Sample() { }

	// RVA: 0x158F09C
	public bool get_isPlaying() { }

	// RVA: 0x158F0EC
	public bool IsPlaying(string name) { }

	// RVA: 0x158F154
	public AnimationState get_Item(string name) { }

	// RVA: 0x158F224
	public bool Play() { }

	// RVA: 0x158F27C
	public bool Play(PlayMode mode) { }

	// RVA: 0x158F2E4
	private bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x158F34C
	public bool Play(string animation) { }

	// RVA: 0x158F3A0
	public bool Play(string animation, PlayMode mode) { }

	// RVA: 0x158F3F8
	public void CrossFade(string animation) { }

	// RVA: 0x158F458
	public void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x158F4BC
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	// RVA: 0x158F524
	public void Blend(string animation) { }

	// RVA: 0x158F584
	public void Blend(string animation, float targetWeight) { }

	// RVA: 0x158F5F0
	public void Blend(string animation, float targetWeight, float fadeLength) { }

	// RVA: 0x158F658
	public AnimationState CrossFadeQueued(string animation) { }

	// RVA: 0x158F6BC
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	// RVA: 0x158F724
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	// RVA: 0x158F790
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	// RVA: 0x158F808
	public AnimationState PlayQueued(string animation) { }

	// RVA: 0x158F860
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	// RVA: 0x158F8BC
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0x158F924
	public void AddClip(AnimationClip clip, string newName) { }

	// RVA: 0x158F988
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	// RVA: 0x158F9FC
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x158FA7C
	public void RemoveClip(AnimationClip clip) { }

	// RVA: 0x158FAE4
	public void RemoveClip(string clipName) { }

	// RVA: 0x158FB4C
	private void RemoveClipNamed(string clipName) { }

	// RVA: 0x158FBB4
	public int GetClipCount() { }

	// RVA: 0x158FC04
	public bool Play(AnimationPlayMode mode) { }

	// RVA: 0x158FC6C
	public bool Play(string animation, AnimationPlayMode mode) { }

	// RVA: 0x158FCC4
	public void SyncLayer(int layer) { }

	// RVA: 0x158FD2C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x158F1BC
	internal AnimationState GetState(string name) { }

	// RVA: 0x158FDE4
	internal AnimationState GetStateAtIndex(int index) { }

	// RVA: 0x158FE4C
	internal int GetStateCount() { }

	// RVA: 0x158FE9C
	public AnimationClip GetClip(string name) { }

	// RVA: 0x158FFA4
	public bool get_animatePhysics() { }

	// RVA: 0x158FFF4
	public void set_animatePhysics(bool value) { }

	// RVA: 0x159005C
	public bool get_animateOnlyIfVisible() { }

	// RVA: 0x15900AC
	public void set_animateOnlyIfVisible(bool value) { }

	// RVA: 0x1590114
	public AnimationCullingType get_cullingType() { }

	// RVA: 0x1590164
	public void set_cullingType(AnimationCullingType value) { }

	// RVA: 0x15901CC
	public Bounds get_localBounds() { }

	// RVA: 0x15902A8
	public void set_localBounds(Bounds value) { }

	// RVA: 0x1590378
	public void .ctor() { }

	// RVA: 0x1590240
	private void get_localBounds_Injected(Bounds ret) { }

	// RVA: 0x1590310
	private void set_localBounds_Injected(Bounds value) { }

}

// Namespace: UnityEngine
public sealed class AnimationState
{
	// Methods

	// RVA: 0x1590468
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x15904D0
	public void set_time(float value) { }

	// RVA: 0x1590538
	public void set_speed(float value) { }

	// RVA: 0x15905A0
	public float get_length() { }

	// RVA: 0x15905F0
	public void set_layer(int value) { }

	// RVA: 0x158FF54
	public AnimationClip get_clip() { }

	// RVA: 0x1590658
	public string get_name() { }

	// RVA: 0x15906A8
	public void set_blendMode(AnimationBlendMode value) { }

	// RVA: 0x1590710
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

	// RVA: 0x1590718
	public void .ctor() { }

	// RVA: 0x15907B4
	public string get_stringParameter() { }

}

// Namespace: UnityEngine
public sealed class AnimationClip
{
	// Methods

	// RVA: 0x15907BC
	public void .ctor() { }

	// RVA: 0x1590908
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x1590958
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

	// RVA: 0x15909A8
	public int get_shortNameHash() { }

	// RVA: 0x15909B0
	public float get_normalizedTime() { }

	// RVA: 0x15909B8
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

	// RVA: 0x15909C8
	public bool get_isOptimizable() { }

	// RVA: 0x1590A18
	public bool get_isHuman() { }

	// RVA: 0x1590A68
	public bool get_hasRootMotion() { }

	// RVA: 0x1590AB8
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0x1590B08
	public float get_humanScale() { }

	// RVA: 0x1590B58
	public bool get_isInitialized() { }

	// RVA: 0x1590BA8
	public float GetFloat(string name) { }

	// RVA: 0x1590C78
	public float GetFloat(int id) { }

	// RVA: 0x1590D48
	public void SetFloat(string name, float value) { }

	// RVA: 0x1590E08
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x1590EF8
	public void SetFloat(int id, float value) { }

	// RVA: 0x1590FB8
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x15910A8
	public bool GetBool(string name) { }

	// RVA: 0x1591178
	public bool GetBool(int id) { }

	// RVA: 0x1591248
	public void SetBool(string name, bool value) { }

	// RVA: 0x15912F8
	public void SetBool(int id, bool value) { }

	// RVA: 0x15913A8
	public int GetInteger(string name) { }

	// RVA: 0x1591478
	public int GetInteger(int id) { }

	// RVA: 0x1591548
	public void SetInteger(string name, int value) { }

	// RVA: 0x15915F8
	public void SetInteger(int id, int value) { }

	// RVA: 0x15916A8
	public void SetTrigger(string name) { }

	// RVA: 0x1591778
	public void SetTrigger(int id) { }

	// RVA: 0x1591848
	public void ResetTrigger(string name) { }

	// RVA: 0x1591918
	public void ResetTrigger(int id) { }

	// RVA: 0x15919E8
	public bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x1591AB8
	public bool IsParameterControlledByCurve(int id) { }

	// RVA: 0x1591B88
	public Vector3 get_deltaPosition() { }

	// RVA: 0x1591C50
	public Quaternion get_deltaRotation() { }

	// RVA: 0x1591D14
	public Vector3 get_velocity() { }

	// RVA: 0x1591DDC
	public Vector3 get_angularVelocity() { }

	// RVA: 0x1591EA4
	public Vector3 get_rootPosition() { }

	// RVA: 0x1591F6C
	public void set_rootPosition(Vector3 value) { }

	// RVA: 0x159202C
	public Quaternion get_rootRotation() { }

	// RVA: 0x15920F0
	public void set_rootRotation(Quaternion value) { }

	// RVA: 0x15921B0
	public bool get_applyRootMotion() { }

	// RVA: 0x1592200
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x1592268
	public bool get_linearVelocityBlending() { }

	// RVA: 0x15922B8
	public void set_linearVelocityBlending(bool value) { }

	// RVA: 0x1592320
	public bool get_animatePhysics() { }

	// RVA: 0x15923BC
	public void set_animatePhysics(bool value) { }

	// RVA: 0x159236C
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x159242C
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x1592494
	public bool get_hasTransformHierarchy() { }

	// RVA: 0x15924E4
	internal bool get_allowConstantClipSamplingOptimization() { }

	// RVA: 0x1592534
	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	// RVA: 0x159259C
	public float get_gravityWeight() { }

	// RVA: 0x15925EC
	public Vector3 get_bodyPosition() { }

	// RVA: 0x15927AC
	public void set_bodyPosition(Vector3 value) { }

	// RVA: 0x159274C
	internal Vector3 get_bodyPositionInternal() { }

	// RVA: 0x1592824
	internal void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0x159294C
	public Quaternion get_bodyRotation() { }

	// RVA: 0x1592A08
	public void set_bodyRotation(Quaternion value) { }

	// RVA: 0x15929AC
	internal Quaternion get_bodyRotationInternal() { }

	// RVA: 0x1592A84
	internal void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0x1592BAC
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x1592C20
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0x1592CE8
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x1592D70
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x1592E30
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x1592EA0
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0x1592F64
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x1592FF0
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x15930B0
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x159311C
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x1593184
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x15931E8
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x1593248
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x15932B4
	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0x159331C
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x1593380
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x15933E0
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0x1593454
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0x159351C
	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x15935A4
	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x1593664
	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0x15936D0
	private float GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0x1593738
	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	// RVA: 0x159379C
	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	// RVA: 0x15937FC
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	// RVA: 0x1593874
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x1593934
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x1593A18
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x1593A80
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x1593AF4
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x1593B6C
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x1593998
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x1593BF0
	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	// RVA: 0x1593CF8
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x1593DB8
	private ScriptableObject GetBehaviour(Type type) { }

	// RVA: 0x315B3A8
	public T GetBehaviour() { }

	// RVA: 0x30A52D0
	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	// RVA: 0x30A17DC
	public T[] GetBehaviours() { }

	// RVA: 0x1593E20
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0x1593E88
	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	// RVA: 0x1593F68
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x1593FD0
	public bool get_stabilizeFeet() { }

	// RVA: 0x1594020
	public void set_stabilizeFeet(bool value) { }

	// RVA: 0x1594088
	public int get_layerCount() { }

	// RVA: 0x15940D8
	public string GetLayerName(int layerIndex) { }

	// RVA: 0x1594140
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x15941A8
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x1594210
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x1594270
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, AnimatorStateInfo info) { }

	// RVA: 0x15942D8
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x159435C
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x15943E0
	private void GetAnimatorTransitionInfo(int layerIndex, AnimatorTransitionInfo info) { }

	// RVA: 0x1594438
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x15944AC
	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	// RVA: 0x1594504
	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x1594558
	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x15945AC
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x1594614
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x159467C
	public void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x1594724
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x159478C
	public void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x1594834
	public bool IsInTransition(int layerIndex) { }

	// RVA: 0x159489C
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x15948EC
	public int get_parameterCount() { }

	// RVA: 0x159493C
	private AnimatorControllerParameter GetParameterInternal(int index) { }

	// RVA: 0x15949A4
	public AnimatorControllerParameter GetParameter(int index) { }

	// RVA: 0x1594A80
	public float get_feetPivotActive() { }

	// RVA: 0x1594AD0
	public void set_feetPivotActive(float value) { }

	// RVA: 0x1594B38
	public float get_pivotWeight() { }

	// RVA: 0x1594B88
	public Vector3 get_pivotPosition() { }

	// RVA: 0x1594C50
	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x1594D84
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	// RVA: 0x1594E1C
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	// RVA: 0x1594EB4
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x1594F50
	public void InterruptMatchTarget() { }

	// RVA: 0x1594FA8
	public void InterruptMatchTarget(bool completeMatch) { }

	// RVA: 0x1595010
	public bool get_isMatchingTarget() { }

	// RVA: 0x1595060
	public float get_speed() { }

	// RVA: 0x15950B0
	public void set_speed(float value) { }

	// RVA: 0x1595118
	public void ForceStateNormalizedTime(float normalizedTime) { }

	// RVA: 0x15951D8
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	// RVA: 0x159535C
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x1595414
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x15954D0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x1595598
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x159560C
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x159567C
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	// RVA: 0x15952DC
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x15956E8
	public void WriteDefaultValues() { }

	// RVA: 0x1595738
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x15958BC
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x1595978
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x15957F4
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x1595A30
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x1595AB0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x1595B24
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x1595B98
	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	// RVA: 0x1595C08
	public void PlayInFixedTime(string stateName, int layer) { }

	// RVA: 0x1595D60
	public void PlayInFixedTime(string stateName) { }

	// RVA: 0x1595CB0
	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	// RVA: 0x1595E04
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x1595E6C
	public void PlayInFixedTime(int stateNameHash, int layer) { }

	// RVA: 0x1595ECC
	public void PlayInFixedTime(int stateNameHash) { }

	// RVA: 0x1595F28
	public void Play(string stateName, int layer) { }

	// RVA: 0x1596080
	public void Play(string stateName) { }

	// RVA: 0x1595FD0
	public void Play(string stateName, int layer, float normalizedTime) { }

	// RVA: 0x1595170
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x1596124
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x1596184
	public void Play(int stateNameHash) { }

	// RVA: 0x15961E0
	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x1596240
	public Vector3 get_targetPosition() { }

	// RVA: 0x1596308
	public Quaternion get_targetRotation() { }

	// RVA: 0x15963CC
	public bool IsControlled(Transform transform) { }

	// RVA: 0x15963D4
	internal bool IsBoneTransform(Transform transform) { }

	// RVA: 0x159643C
	public Transform get_avatarRoot() { }

	// RVA: 0x159648C
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	// RVA: 0x15968A0
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x1596908
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x1596958
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x15969C0
	public void StartPlayback() { }

	// RVA: 0x1596A10
	public void StopPlayback() { }

	// RVA: 0x1596A60
	public float get_playbackTime() { }

	// RVA: 0x1596AB0
	public void set_playbackTime(float value) { }

	// RVA: 0x1596B18
	public void StartRecording(int frameCount) { }

	// RVA: 0x1596B80
	public void StopRecording() { }

	// RVA: 0x1596BD0
	public float get_recorderStartTime() { }

	// RVA: 0x1596C70
	public void set_recorderStartTime(float value) { }

	// RVA: 0x1596C20
	private float GetRecorderStartTime() { }

	// RVA: 0x1596C74
	public float get_recorderStopTime() { }

	// RVA: 0x1596D14
	public void set_recorderStopTime(float value) { }

	// RVA: 0x1596CC4
	private float GetRecorderStopTime() { }

	// RVA: 0x1596D18
	public AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0x1596D68
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x1596DB8
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x1596E20
	public bool get_hasBoundPlayables() { }

	// RVA: 0x1596E70
	internal void ClearInternalControllerPlayable() { }

	// RVA: 0x1596EC0
	public bool HasState(int layerIndex, int stateID) { }

	// RVA: 0x159528C
	public static int StringToHash(string name) { }

	// RVA: 0x15967B0
	public Avatar get_avatar() { }

	// RVA: 0x1596F18
	public void set_avatar(Avatar value) { }

	// RVA: 0x1596F80
	internal string GetStats() { }

	// RVA: 0x1596FD0
	public PlayableGraph get_playableGraph() { }

	// RVA: 0x1597028
	private void GetCurrentGraph(PlayableGraph graph) { }

	// RVA: 0x1592650
	private void CheckIfInIKPass() { }

	// RVA: 0x15970E0
	private bool IsInIKPass() { }

	// RVA: 0x1590DA8
	private void SetFloatString(string name, float value) { }

	// RVA: 0x1590F58
	private void SetFloatID(int id, float value) { }

	// RVA: 0x1590C10
	private float GetFloatString(string name) { }

	// RVA: 0x1590CE0
	private float GetFloatID(int id) { }

	// RVA: 0x15912A0
	private void SetBoolString(string name, bool value) { }

	// RVA: 0x1591350
	private void SetBoolID(int id, bool value) { }

	// RVA: 0x1591110
	private bool GetBoolString(string name) { }

	// RVA: 0x15911E0
	private bool GetBoolID(int id) { }

	// RVA: 0x15915A0
	private void SetIntegerString(string name, int value) { }

	// RVA: 0x1591650
	private void SetIntegerID(int id, int value) { }

	// RVA: 0x1591410
	private int GetIntegerString(string name) { }

	// RVA: 0x15914E0
	private int GetIntegerID(int id) { }

	// RVA: 0x1591710
	private void SetTriggerString(string name) { }

	// RVA: 0x15917E0
	private void SetTriggerID(int id) { }

	// RVA: 0x15918B0
	private void ResetTriggerString(string name) { }

	// RVA: 0x1591980
	private void ResetTriggerID(int id) { }

	// RVA: 0x1591A50
	private bool IsParameterControlledByCurveString(string name) { }

	// RVA: 0x1591B20
	private bool IsParameterControlledByCurveID(int id) { }

	// RVA: 0x1590E80
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x1591030
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x1597130
	public bool get_layersAffectMassCenter() { }

	// RVA: 0x1597180
	public void set_layersAffectMassCenter(bool value) { }

	// RVA: 0x15971E8
	public float get_leftFeetBottomHeight() { }

	// RVA: 0x1597238
	public float get_rightFeetBottomHeight() { }

	// RVA: 0x1597288
	internal bool get_supportsOnAnimatorMove() { }

	// RVA: 0x15972D8
	internal void OnUpdateModeChanged() { }

	// RVA: 0x1597328
	internal void OnCullingModeChanged() { }

	// RVA: 0x1597378
	internal void WriteDefaultPose() { }

	// RVA: 0x15973C8
	public void Update(float deltaTime) { }

	// RVA: 0x1597430
	public void Rebind() { }

	// RVA: 0x1597488
	private void Rebind(bool writeDefaultValues) { }

	// RVA: 0x15974F0
	public void ApplyBuiltinRootMotion() { }

	// RVA: 0x1597540
	internal void EvaluateController() { }

	// RVA: 0x1597598
	private void EvaluateController(float deltaTime) { }

	// RVA: 0x1597600
	internal string GetCurrentStateName(int layerIndex) { }

	// RVA: 0x15976AC
	internal string GetNextStateName(int layerIndex) { }

	// RVA: 0x1597654
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	// RVA: 0x1597700
	internal string ResolveHash(int hash) { }

	// RVA: 0x1597090
	public bool get_logWarnings() { }

	// RVA: 0x1597768
	public void set_logWarnings(bool value) { }

	// RVA: 0x15977D0
	public bool get_fireEvents() { }

	// RVA: 0x1597820
	public void set_fireEvents(bool value) { }

	// RVA: 0x1597888
	public bool get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0x1597928
	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	// RVA: 0x15978D8
	public bool get_keepAnimatorStateOnDisable() { }

	// RVA: 0x1597990
	public void set_keepAnimatorStateOnDisable(bool value) { }

	// RVA: 0x15979F8
	public bool get_writeDefaultValuesOnDisable() { }

	// RVA: 0x1597A48
	public void set_writeDefaultValuesOnDisable(bool value) { }

	// RVA: 0x1597AB0
	public Vector3 GetVector(string name) { }

	// RVA: 0x1597B00
	public Vector3 GetVector(int id) { }

	// RVA: 0x1597B50
	public void SetVector(string name, Vector3 value) { }

	// RVA: 0x1597B54
	public void SetVector(int id, Vector3 value) { }

	// RVA: 0x1597B58
	public Quaternion GetQuaternion(string name) { }

	// RVA: 0x1597BA8
	public Quaternion GetQuaternion(int id) { }

	// RVA: 0x1597BF8
	public void SetQuaternion(string name, Quaternion value) { }

	// RVA: 0x1597BFC
	public void SetQuaternion(int id, Quaternion value) { }

	// RVA: 0x1597C00
	public void .ctor() { }

	// RVA: 0x1591BE8
	private void get_deltaPosition_Injected(Vector3 ret) { }

	// RVA: 0x1591CAC
	private void get_deltaRotation_Injected(Quaternion ret) { }

	// RVA: 0x1591D74
	private void get_velocity_Injected(Vector3 ret) { }

	// RVA: 0x1591E3C
	private void get_angularVelocity_Injected(Vector3 ret) { }

	// RVA: 0x1591F04
	private void get_rootPosition_Injected(Vector3 ret) { }

	// RVA: 0x1591FC4
	private void set_rootPosition_Injected(Vector3 value) { }

	// RVA: 0x1592088
	private void get_rootRotation_Injected(Quaternion ret) { }

	// RVA: 0x1592148
	private void set_rootRotation_Injected(Quaternion value) { }

	// RVA: 0x159287C
	private void get_bodyPositionInternal_Injected(Vector3 ret) { }

	// RVA: 0x15928E4
	private void set_bodyPositionInternal_Injected(Vector3 value) { }

	// RVA: 0x1592ADC
	private void get_bodyRotationInternal_Injected(Quaternion ret) { }

	// RVA: 0x1592B44
	private void set_bodyRotationInternal_Injected(Quaternion value) { }

	// RVA: 0x1592C90
	private void GetGoalPosition_Injected(AvatarIKGoal goal, Vector3 ret) { }

	// RVA: 0x1592DD8
	private void SetGoalPosition_Injected(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x1592F0C
	private void GetGoalRotation_Injected(AvatarIKGoal goal, Quaternion ret) { }

	// RVA: 0x1593058
	private void SetGoalRotation_Injected(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x15934C4
	private void GetHintPosition_Injected(AvatarIKHint hint, Vector3 ret) { }

	// RVA: 0x159360C
	private void SetHintPosition_Injected(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x15938CC
	private void SetLookAtPositionInternal_Injected(Vector3 lookAtPosition) { }

	// RVA: 0x1593D60
	private void SetBoneLocalRotationInternal_Injected(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x1594BE8
	private void get_pivotPosition_Injected(Vector3 ret) { }

	// RVA: 0x1594CEC
	private void MatchTarget_Injected(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x15962A0
	private void get_targetPosition_Injected(Vector3 ret) { }

	// RVA: 0x1596364
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

	// RVA: 0x1597C08
	public string get_name() { }

	// RVA: 0x1597C10
	public override bool Equals(object o) { }

	// RVA: 0x1597D0C
	public override int GetHashCode() { }

	// RVA: 0x1597D30
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

	// RVA: 0x1597D94
	public void .ctor() { }

}

// Namespace: 
internal sealed class OnOverrideControllerDirtyCallback
{
	// Methods

	// RVA: 0x1598E74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1598F14
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public class AnimatorOverrideController
{
	// Fields
	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Methods

	// RVA: 0x1597D9C
	public void .ctor() { }

	// RVA: 0x1597F54
	public void .ctor(RuntimeAnimatorController controller) { }

	// RVA: 0x1597EEC
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	// RVA: 0x1598020
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x1598070
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x15980D8
	public AnimationClip get_Item(string name) { }

	// RVA: 0x1598184
	public void set_Item(string name, AnimationClip value) { }

	// RVA: 0x159812C
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	// RVA: 0x15981DC
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	// RVA: 0x1598234
	public AnimationClip get_Item(AnimationClip clip) { }

	// RVA: 0x15982E0
	public void set_Item(AnimationClip clip, AnimationClip value) { }

	// RVA: 0x1598288
	private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	// RVA: 0x159833C
	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

	// RVA: 0x15983A4
	private void SendNotification() { }

	// RVA: 0x15983F4
	private AnimationClip GetOriginalClip(int index) { }

	// RVA: 0x159845C
	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	// RVA: 0x15984C4
	public int get_overridesCount() { }

	// RVA: 0x1598514
	public void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x1598788
	public void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x1598B20
	public AnimationClipPair[] get_clips() { }

	// RVA: 0x1598D1C
	public void set_clips(AnimationClipPair[] value) { }

	// RVA: 0x1598DF0
	internal void PerformOverrideClipListCleanup() { }

	// RVA: 0x1598E40
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

	// RVA: 0x1598F28
	private void .ctor() { }

	// RVA: 0x1596800
	public bool get_isValid() { }

	// RVA: 0x1596850
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

	// RVA: 0x1593CA8
	internal static int GetBoneIndexFromMono(int humanId) { }

}

// Namespace: UnityEngine
public class Motion
{
	// Fields
	private readonly bool <isAnimatorMotion>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1590880
	protected void .ctor() { }

}

// Namespace: UnityEngine
public class RuntimeAnimatorController
{
	// Methods

	// RVA: 0x1597E64
	protected void .ctor() { }

	// RVA: 0x1598FB0
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

	// RVA: 0x1599000
	public PlayableHandle GetHandle() { }

	// RVA: 0x159900C
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

	// RVA: 0x1599090
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization) { }

	// RVA: 0x1599278
	public PlayableHandle GetHandle() { }

	// RVA: 0x1599284
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x1599210
	private static void SetSingleLayerOptimizationInternal(PlayableHandle handle, bool value) { }

	// RVA: 0x1599354
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15993F8
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1599514
	public PlayableHandle GetHandle() { }

	// RVA: 0x1599520
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x15995F0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationMotionXToDeltaPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1599690
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x15997AC
	public PlayableHandle GetHandle() { }

	// RVA: 0x15997B8
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x1599888
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationOffsetPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1599928
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1599A44
	public PlayableHandle GetHandle() { }

	// RVA: 0x1599A50
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x1599B0C
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

	// RVA: 0x1599BAC
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1599CC8
	public PlayableHandle GetHandle() { }

	// RVA: 0x1599CD4
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x1599D90
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationRemoveScalePlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1599E30
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1599F4C
	public PlayableHandle GetHandle() { }

	// RVA: 0x1599F58
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x159A014
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationScriptPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x159A0B4
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x159A1D0
	public PlayableHandle GetHandle() { }

	// RVA: 0x159A1DC
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x159A2AC
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

	// RVA: 0x159A34C
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x159A5B8
	public PlayableHandle GetHandle() { }

	// RVA: 0x159A424
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x159A5C4
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x159A694
	private static void .cctor() { }

}


