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

	// RVA: 0x159DED4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x159DED8
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x159DEDC
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x159DEE0
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x159DEE4
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x159DEE8
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x159DEEC
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x159DEF0
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x159DEF4
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x159DEF8
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x159DEFC
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x159DF00
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x159DF04
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x159DF08
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x159DF0C
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

	// RVA: 0x159F0D8
	internal void .ctor(Animation outer) { }

	// RVA: 0x159F6B0
	public object get_Current() { }

	// RVA: 0x159F720
	public bool MoveNext() { }

	// RVA: 0x159F78C
	public void Reset() { }

}

// Namespace: UnityEngine
public sealed class Animation
{
	// Methods

	// RVA: 0x159DF14
	public AnimationClip get_clip() { }

	// RVA: 0x159DF64
	public void set_clip(AnimationClip value) { }

	// RVA: 0x159DFCC
	public bool get_playAutomatically() { }

	// RVA: 0x159E01C
	public void set_playAutomatically(bool value) { }

	// RVA: 0x159E084
	public WrapMode get_wrapMode() { }

	// RVA: 0x159E0D4
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x159E13C
	public void Stop() { }

	// RVA: 0x159E18C
	public void Stop(string name) { }

	// RVA: 0x159E1F4
	private void StopNamed(string name) { }

	// RVA: 0x159E25C
	public void Rewind() { }

	// RVA: 0x159E2AC
	public void Rewind(string name) { }

	// RVA: 0x159E314
	private void RewindNamed(string name) { }

	// RVA: 0x159E37C
	public void Sample() { }

	// RVA: 0x159E3CC
	public bool get_isPlaying() { }

	// RVA: 0x159E41C
	public bool IsPlaying(string name) { }

	// RVA: 0x159E484
	public AnimationState get_Item(string name) { }

	// RVA: 0x159E554
	public bool Play() { }

	// RVA: 0x159E5AC
	public bool Play(PlayMode mode) { }

	// RVA: 0x159E614
	private bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x159E67C
	public bool Play(string animation) { }

	// RVA: 0x159E6D0
	public bool Play(string animation, PlayMode mode) { }

	// RVA: 0x159E728
	public void CrossFade(string animation) { }

	// RVA: 0x159E788
	public void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x159E7EC
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	// RVA: 0x159E854
	public void Blend(string animation) { }

	// RVA: 0x159E8B4
	public void Blend(string animation, float targetWeight) { }

	// RVA: 0x159E920
	public void Blend(string animation, float targetWeight, float fadeLength) { }

	// RVA: 0x159E988
	public AnimationState CrossFadeQueued(string animation) { }

	// RVA: 0x159E9EC
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	// RVA: 0x159EA54
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	// RVA: 0x159EAC0
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	// RVA: 0x159EB38
	public AnimationState PlayQueued(string animation) { }

	// RVA: 0x159EB90
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	// RVA: 0x159EBEC
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0x159EC54
	public void AddClip(AnimationClip clip, string newName) { }

	// RVA: 0x159ECB8
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	// RVA: 0x159ED2C
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x159EDAC
	public void RemoveClip(AnimationClip clip) { }

	// RVA: 0x159EE14
	public void RemoveClip(string clipName) { }

	// RVA: 0x159EE7C
	private void RemoveClipNamed(string clipName) { }

	// RVA: 0x159EEE4
	public int GetClipCount() { }

	// RVA: 0x159EF34
	public bool Play(AnimationPlayMode mode) { }

	// RVA: 0x159EF9C
	public bool Play(string animation, AnimationPlayMode mode) { }

	// RVA: 0x159EFF4
	public void SyncLayer(int layer) { }

	// RVA: 0x159F05C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x159E4EC
	internal AnimationState GetState(string name) { }

	// RVA: 0x159F114
	internal AnimationState GetStateAtIndex(int index) { }

	// RVA: 0x159F17C
	internal int GetStateCount() { }

	// RVA: 0x159F1CC
	public AnimationClip GetClip(string name) { }

	// RVA: 0x159F2D4
	public bool get_animatePhysics() { }

	// RVA: 0x159F324
	public void set_animatePhysics(bool value) { }

	// RVA: 0x159F38C
	public bool get_animateOnlyIfVisible() { }

	// RVA: 0x159F3DC
	public void set_animateOnlyIfVisible(bool value) { }

	// RVA: 0x159F444
	public AnimationCullingType get_cullingType() { }

	// RVA: 0x159F494
	public void set_cullingType(AnimationCullingType value) { }

	// RVA: 0x159F4FC
	public Bounds get_localBounds() { }

	// RVA: 0x159F5D8
	public void set_localBounds(Bounds value) { }

	// RVA: 0x159F6A8
	public void .ctor() { }

	// RVA: 0x159F570
	private void get_localBounds_Injected(Bounds ret) { }

	// RVA: 0x159F640
	private void set_localBounds_Injected(Bounds value) { }

}

// Namespace: UnityEngine
public sealed class AnimationState
{
	// Methods

	// RVA: 0x159F798
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x159F800
	public void set_time(float value) { }

	// RVA: 0x159F868
	public void set_speed(float value) { }

	// RVA: 0x159F8D0
	public float get_length() { }

	// RVA: 0x159F920
	public void set_layer(int value) { }

	// RVA: 0x159F284
	public AnimationClip get_clip() { }

	// RVA: 0x159F988
	public string get_name() { }

	// RVA: 0x159F9D8
	public void set_blendMode(AnimationBlendMode value) { }

	// RVA: 0x159FA40
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

	// RVA: 0x159FA48
	public void .ctor() { }

	// RVA: 0x159FAE4
	public string get_stringParameter() { }

}

// Namespace: UnityEngine
public sealed class AnimationClip
{
	// Methods

	// RVA: 0x159FAEC
	public void .ctor() { }

	// RVA: 0x159FC38
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x159FC88
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

	// RVA: 0x159FCD8
	public int get_shortNameHash() { }

	// RVA: 0x159FCE0
	public float get_normalizedTime() { }

	// RVA: 0x159FCE8
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

	// RVA: 0x159FCF8
	public bool get_isOptimizable() { }

	// RVA: 0x159FD48
	public bool get_isHuman() { }

	// RVA: 0x159FD98
	public bool get_hasRootMotion() { }

	// RVA: 0x159FDE8
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0x159FE38
	public float get_humanScale() { }

	// RVA: 0x159FE88
	public bool get_isInitialized() { }

	// RVA: 0x159FED8
	public float GetFloat(string name) { }

	// RVA: 0x159FFA8
	public float GetFloat(int id) { }

	// RVA: 0x15A0078
	public void SetFloat(string name, float value) { }

	// RVA: 0x15A0138
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x15A0228
	public void SetFloat(int id, float value) { }

	// RVA: 0x15A02E8
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x15A03D8
	public bool GetBool(string name) { }

	// RVA: 0x15A04A8
	public bool GetBool(int id) { }

	// RVA: 0x15A0578
	public void SetBool(string name, bool value) { }

	// RVA: 0x15A0628
	public void SetBool(int id, bool value) { }

	// RVA: 0x15A06D8
	public int GetInteger(string name) { }

	// RVA: 0x15A07A8
	public int GetInteger(int id) { }

	// RVA: 0x15A0878
	public void SetInteger(string name, int value) { }

	// RVA: 0x15A0928
	public void SetInteger(int id, int value) { }

	// RVA: 0x15A09D8
	public void SetTrigger(string name) { }

	// RVA: 0x15A0AA8
	public void SetTrigger(int id) { }

	// RVA: 0x15A0B78
	public void ResetTrigger(string name) { }

	// RVA: 0x15A0C48
	public void ResetTrigger(int id) { }

	// RVA: 0x15A0D18
	public bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x15A0DE8
	public bool IsParameterControlledByCurve(int id) { }

	// RVA: 0x15A0EB8
	public Vector3 get_deltaPosition() { }

	// RVA: 0x15A0F80
	public Quaternion get_deltaRotation() { }

	// RVA: 0x15A1044
	public Vector3 get_velocity() { }

	// RVA: 0x15A110C
	public Vector3 get_angularVelocity() { }

	// RVA: 0x15A11D4
	public Vector3 get_rootPosition() { }

	// RVA: 0x15A129C
	public void set_rootPosition(Vector3 value) { }

	// RVA: 0x15A135C
	public Quaternion get_rootRotation() { }

	// RVA: 0x15A1420
	public void set_rootRotation(Quaternion value) { }

	// RVA: 0x15A14E0
	public bool get_applyRootMotion() { }

	// RVA: 0x15A1530
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x15A1598
	public bool get_linearVelocityBlending() { }

	// RVA: 0x15A15E8
	public void set_linearVelocityBlending(bool value) { }

	// RVA: 0x15A1650
	public bool get_animatePhysics() { }

	// RVA: 0x15A16EC
	public void set_animatePhysics(bool value) { }

	// RVA: 0x15A169C
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x15A175C
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x15A17C4
	public bool get_hasTransformHierarchy() { }

	// RVA: 0x15A1814
	internal bool get_allowConstantClipSamplingOptimization() { }

	// RVA: 0x15A1864
	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	// RVA: 0x15A18CC
	public float get_gravityWeight() { }

	// RVA: 0x15A191C
	public Vector3 get_bodyPosition() { }

	// RVA: 0x15A1ADC
	public void set_bodyPosition(Vector3 value) { }

	// RVA: 0x15A1A7C
	internal Vector3 get_bodyPositionInternal() { }

	// RVA: 0x15A1B54
	internal void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0x15A1C7C
	public Quaternion get_bodyRotation() { }

	// RVA: 0x15A1D38
	public void set_bodyRotation(Quaternion value) { }

	// RVA: 0x15A1CDC
	internal Quaternion get_bodyRotationInternal() { }

	// RVA: 0x15A1DB4
	internal void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0x15A1EDC
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x15A1F50
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0x15A2018
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x15A20A0
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x15A2160
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x15A21D0
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0x15A2294
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x15A2320
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x15A23E0
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x15A244C
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x15A24B4
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x15A2518
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x15A2578
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x15A25E4
	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0x15A264C
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x15A26B0
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x15A2710
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0x15A2784
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0x15A284C
	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x15A28D4
	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x15A2994
	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0x15A2A00
	private float GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0x15A2A68
	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	// RVA: 0x15A2ACC
	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	// RVA: 0x15A2B2C
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	// RVA: 0x15A2BA4
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x15A2C64
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x15A2D48
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x15A2DB0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x15A2E24
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x15A2E9C
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x15A2CC8
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x15A2F20
	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	// RVA: 0x15A3028
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x15A30E8
	private ScriptableObject GetBehaviour(Type type) { }

	// RVA: 0x316B894
	public T GetBehaviour() { }

	// RVA: 0x30B57C8
	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	// RVA: 0x30B1CD4
	public T[] GetBehaviours() { }

	// RVA: 0x15A3150
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0x15A31B8
	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	// RVA: 0x15A3298
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x15A3300
	public bool get_stabilizeFeet() { }

	// RVA: 0x15A3350
	public void set_stabilizeFeet(bool value) { }

	// RVA: 0x15A33B8
	public int get_layerCount() { }

	// RVA: 0x15A3408
	public string GetLayerName(int layerIndex) { }

	// RVA: 0x15A3470
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x15A34D8
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x15A3540
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x15A35A0
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, AnimatorStateInfo info) { }

	// RVA: 0x15A3608
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x15A368C
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x15A3710
	private void GetAnimatorTransitionInfo(int layerIndex, AnimatorTransitionInfo info) { }

	// RVA: 0x15A3768
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x15A37DC
	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	// RVA: 0x15A3834
	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x15A3888
	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x15A38DC
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x15A3944
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x15A39AC
	public void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x15A3A54
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x15A3ABC
	public void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x15A3B64
	public bool IsInTransition(int layerIndex) { }

	// RVA: 0x15A3BCC
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x15A3C1C
	public int get_parameterCount() { }

	// RVA: 0x15A3C6C
	private AnimatorControllerParameter GetParameterInternal(int index) { }

	// RVA: 0x15A3CD4
	public AnimatorControllerParameter GetParameter(int index) { }

	// RVA: 0x15A3DB0
	public float get_feetPivotActive() { }

	// RVA: 0x15A3E00
	public void set_feetPivotActive(float value) { }

	// RVA: 0x15A3E68
	public float get_pivotWeight() { }

	// RVA: 0x15A3EB8
	public Vector3 get_pivotPosition() { }

	// RVA: 0x15A3F80
	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x15A40B4
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	// RVA: 0x15A414C
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	// RVA: 0x15A41E4
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x15A4280
	public void InterruptMatchTarget() { }

	// RVA: 0x15A42D8
	public void InterruptMatchTarget(bool completeMatch) { }

	// RVA: 0x15A4340
	public bool get_isMatchingTarget() { }

	// RVA: 0x15A4390
	public float get_speed() { }

	// RVA: 0x15A43E0
	public void set_speed(float value) { }

	// RVA: 0x15A4448
	public void ForceStateNormalizedTime(float normalizedTime) { }

	// RVA: 0x15A4508
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	// RVA: 0x15A468C
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x15A4744
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x15A4800
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x15A48C8
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x15A493C
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x15A49AC
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	// RVA: 0x15A460C
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x15A4A18
	public void WriteDefaultValues() { }

	// RVA: 0x15A4A68
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x15A4BEC
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x15A4CA8
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x15A4B24
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x15A4D60
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x15A4DE0
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x15A4E54
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x15A4EC8
	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	// RVA: 0x15A4F38
	public void PlayInFixedTime(string stateName, int layer) { }

	// RVA: 0x15A5090
	public void PlayInFixedTime(string stateName) { }

	// RVA: 0x15A4FE0
	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	// RVA: 0x15A5134
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x15A519C
	public void PlayInFixedTime(int stateNameHash, int layer) { }

	// RVA: 0x15A51FC
	public void PlayInFixedTime(int stateNameHash) { }

	// RVA: 0x15A5258
	public void Play(string stateName, int layer) { }

	// RVA: 0x15A53B0
	public void Play(string stateName) { }

	// RVA: 0x15A5300
	public void Play(string stateName, int layer, float normalizedTime) { }

	// RVA: 0x15A44A0
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x15A5454
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x15A54B4
	public void Play(int stateNameHash) { }

	// RVA: 0x15A5510
	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x15A5570
	public Vector3 get_targetPosition() { }

	// RVA: 0x15A5638
	public Quaternion get_targetRotation() { }

	// RVA: 0x15A56FC
	public bool IsControlled(Transform transform) { }

	// RVA: 0x15A5704
	internal bool IsBoneTransform(Transform transform) { }

	// RVA: 0x15A576C
	public Transform get_avatarRoot() { }

	// RVA: 0x15A57BC
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	// RVA: 0x15A5BD0
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x15A5C38
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x15A5C88
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x15A5CF0
	public void StartPlayback() { }

	// RVA: 0x15A5D40
	public void StopPlayback() { }

	// RVA: 0x15A5D90
	public float get_playbackTime() { }

	// RVA: 0x15A5DE0
	public void set_playbackTime(float value) { }

	// RVA: 0x15A5E48
	public void StartRecording(int frameCount) { }

	// RVA: 0x15A5EB0
	public void StopRecording() { }

	// RVA: 0x15A5F00
	public float get_recorderStartTime() { }

	// RVA: 0x15A5FA0
	public void set_recorderStartTime(float value) { }

	// RVA: 0x15A5F50
	private float GetRecorderStartTime() { }

	// RVA: 0x15A5FA4
	public float get_recorderStopTime() { }

	// RVA: 0x15A6044
	public void set_recorderStopTime(float value) { }

	// RVA: 0x15A5FF4
	private float GetRecorderStopTime() { }

	// RVA: 0x15A6048
	public AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0x15A6098
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x15A60E8
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x15A6150
	public bool get_hasBoundPlayables() { }

	// RVA: 0x15A61A0
	internal void ClearInternalControllerPlayable() { }

	// RVA: 0x15A61F0
	public bool HasState(int layerIndex, int stateID) { }

	// RVA: 0x15A45BC
	public static int StringToHash(string name) { }

	// RVA: 0x15A5AE0
	public Avatar get_avatar() { }

	// RVA: 0x15A6248
	public void set_avatar(Avatar value) { }

	// RVA: 0x15A62B0
	internal string GetStats() { }

	// RVA: 0x15A6300
	public PlayableGraph get_playableGraph() { }

	// RVA: 0x15A6358
	private void GetCurrentGraph(PlayableGraph graph) { }

	// RVA: 0x15A1980
	private void CheckIfInIKPass() { }

	// RVA: 0x15A6410
	private bool IsInIKPass() { }

	// RVA: 0x15A00D8
	private void SetFloatString(string name, float value) { }

	// RVA: 0x15A0288
	private void SetFloatID(int id, float value) { }

	// RVA: 0x159FF40
	private float GetFloatString(string name) { }

	// RVA: 0x15A0010
	private float GetFloatID(int id) { }

	// RVA: 0x15A05D0
	private void SetBoolString(string name, bool value) { }

	// RVA: 0x15A0680
	private void SetBoolID(int id, bool value) { }

	// RVA: 0x15A0440
	private bool GetBoolString(string name) { }

	// RVA: 0x15A0510
	private bool GetBoolID(int id) { }

	// RVA: 0x15A08D0
	private void SetIntegerString(string name, int value) { }

	// RVA: 0x15A0980
	private void SetIntegerID(int id, int value) { }

	// RVA: 0x15A0740
	private int GetIntegerString(string name) { }

	// RVA: 0x15A0810
	private int GetIntegerID(int id) { }

	// RVA: 0x15A0A40
	private void SetTriggerString(string name) { }

	// RVA: 0x15A0B10
	private void SetTriggerID(int id) { }

	// RVA: 0x15A0BE0
	private void ResetTriggerString(string name) { }

	// RVA: 0x15A0CB0
	private void ResetTriggerID(int id) { }

	// RVA: 0x15A0D80
	private bool IsParameterControlledByCurveString(string name) { }

	// RVA: 0x15A0E50
	private bool IsParameterControlledByCurveID(int id) { }

	// RVA: 0x15A01B0
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x15A0360
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x15A6460
	public bool get_layersAffectMassCenter() { }

	// RVA: 0x15A64B0
	public void set_layersAffectMassCenter(bool value) { }

	// RVA: 0x15A6518
	public float get_leftFeetBottomHeight() { }

	// RVA: 0x15A6568
	public float get_rightFeetBottomHeight() { }

	// RVA: 0x15A65B8
	internal bool get_supportsOnAnimatorMove() { }

	// RVA: 0x15A6608
	internal void OnUpdateModeChanged() { }

	// RVA: 0x15A6658
	internal void OnCullingModeChanged() { }

	// RVA: 0x15A66A8
	internal void WriteDefaultPose() { }

	// RVA: 0x15A66F8
	public void Update(float deltaTime) { }

	// RVA: 0x15A6760
	public void Rebind() { }

	// RVA: 0x15A67B8
	private void Rebind(bool writeDefaultValues) { }

	// RVA: 0x15A6820
	public void ApplyBuiltinRootMotion() { }

	// RVA: 0x15A6870
	internal void EvaluateController() { }

	// RVA: 0x15A68C8
	private void EvaluateController(float deltaTime) { }

	// RVA: 0x15A6930
	internal string GetCurrentStateName(int layerIndex) { }

	// RVA: 0x15A69DC
	internal string GetNextStateName(int layerIndex) { }

	// RVA: 0x15A6984
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	// RVA: 0x15A6A30
	internal string ResolveHash(int hash) { }

	// RVA: 0x15A63C0
	public bool get_logWarnings() { }

	// RVA: 0x15A6A98
	public void set_logWarnings(bool value) { }

	// RVA: 0x15A6B00
	public bool get_fireEvents() { }

	// RVA: 0x15A6B50
	public void set_fireEvents(bool value) { }

	// RVA: 0x15A6BB8
	public bool get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0x15A6C58
	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	// RVA: 0x15A6C08
	public bool get_keepAnimatorStateOnDisable() { }

	// RVA: 0x15A6CC0
	public void set_keepAnimatorStateOnDisable(bool value) { }

	// RVA: 0x15A6D28
	public bool get_writeDefaultValuesOnDisable() { }

	// RVA: 0x15A6D78
	public void set_writeDefaultValuesOnDisable(bool value) { }

	// RVA: 0x15A6DE0
	public Vector3 GetVector(string name) { }

	// RVA: 0x15A6E30
	public Vector3 GetVector(int id) { }

	// RVA: 0x15A6E80
	public void SetVector(string name, Vector3 value) { }

	// RVA: 0x15A6E84
	public void SetVector(int id, Vector3 value) { }

	// RVA: 0x15A6E88
	public Quaternion GetQuaternion(string name) { }

	// RVA: 0x15A6ED8
	public Quaternion GetQuaternion(int id) { }

	// RVA: 0x15A6F28
	public void SetQuaternion(string name, Quaternion value) { }

	// RVA: 0x15A6F2C
	public void SetQuaternion(int id, Quaternion value) { }

	// RVA: 0x15A6F30
	public void .ctor() { }

	// RVA: 0x15A0F18
	private void get_deltaPosition_Injected(Vector3 ret) { }

	// RVA: 0x15A0FDC
	private void get_deltaRotation_Injected(Quaternion ret) { }

	// RVA: 0x15A10A4
	private void get_velocity_Injected(Vector3 ret) { }

	// RVA: 0x15A116C
	private void get_angularVelocity_Injected(Vector3 ret) { }

	// RVA: 0x15A1234
	private void get_rootPosition_Injected(Vector3 ret) { }

	// RVA: 0x15A12F4
	private void set_rootPosition_Injected(Vector3 value) { }

	// RVA: 0x15A13B8
	private void get_rootRotation_Injected(Quaternion ret) { }

	// RVA: 0x15A1478
	private void set_rootRotation_Injected(Quaternion value) { }

	// RVA: 0x15A1BAC
	private void get_bodyPositionInternal_Injected(Vector3 ret) { }

	// RVA: 0x15A1C14
	private void set_bodyPositionInternal_Injected(Vector3 value) { }

	// RVA: 0x15A1E0C
	private void get_bodyRotationInternal_Injected(Quaternion ret) { }

	// RVA: 0x15A1E74
	private void set_bodyRotationInternal_Injected(Quaternion value) { }

	// RVA: 0x15A1FC0
	private void GetGoalPosition_Injected(AvatarIKGoal goal, Vector3 ret) { }

	// RVA: 0x15A2108
	private void SetGoalPosition_Injected(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x15A223C
	private void GetGoalRotation_Injected(AvatarIKGoal goal, Quaternion ret) { }

	// RVA: 0x15A2388
	private void SetGoalRotation_Injected(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x15A27F4
	private void GetHintPosition_Injected(AvatarIKHint hint, Vector3 ret) { }

	// RVA: 0x15A293C
	private void SetHintPosition_Injected(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x15A2BFC
	private void SetLookAtPositionInternal_Injected(Vector3 lookAtPosition) { }

	// RVA: 0x15A3090
	private void SetBoneLocalRotationInternal_Injected(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x15A3F18
	private void get_pivotPosition_Injected(Vector3 ret) { }

	// RVA: 0x15A401C
	private void MatchTarget_Injected(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x15A55D0
	private void get_targetPosition_Injected(Vector3 ret) { }

	// RVA: 0x15A5694
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

	// RVA: 0x15A6F38
	public string get_name() { }

	// RVA: 0x15A6F40
	public override bool Equals(object o) { }

	// RVA: 0x15A703C
	public override int GetHashCode() { }

	// RVA: 0x15A7060
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

	// RVA: 0x15A70C4
	public void .ctor() { }

}

// Namespace: 
internal sealed class OnOverrideControllerDirtyCallback
{
	// Methods

	// RVA: 0x15A81A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15A8244
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public class AnimatorOverrideController
{
	// Fields
	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Methods

	// RVA: 0x15A70CC
	public void .ctor() { }

	// RVA: 0x15A7284
	public void .ctor(RuntimeAnimatorController controller) { }

	// RVA: 0x15A721C
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	// RVA: 0x15A7350
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x15A73A0
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x15A7408
	public AnimationClip get_Item(string name) { }

	// RVA: 0x15A74B4
	public void set_Item(string name, AnimationClip value) { }

	// RVA: 0x15A745C
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	// RVA: 0x15A750C
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	// RVA: 0x15A7564
	public AnimationClip get_Item(AnimationClip clip) { }

	// RVA: 0x15A7610
	public void set_Item(AnimationClip clip, AnimationClip value) { }

	// RVA: 0x15A75B8
	private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	// RVA: 0x15A766C
	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

	// RVA: 0x15A76D4
	private void SendNotification() { }

	// RVA: 0x15A7724
	private AnimationClip GetOriginalClip(int index) { }

	// RVA: 0x15A778C
	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	// RVA: 0x15A77F4
	public int get_overridesCount() { }

	// RVA: 0x15A7844
	public void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x15A7AB8
	public void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x15A7E50
	public AnimationClipPair[] get_clips() { }

	// RVA: 0x15A804C
	public void set_clips(AnimationClipPair[] value) { }

	// RVA: 0x15A8120
	internal void PerformOverrideClipListCleanup() { }

	// RVA: 0x15A8170
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

	// RVA: 0x15A8258
	private void .ctor() { }

	// RVA: 0x15A5B30
	public bool get_isValid() { }

	// RVA: 0x15A5B80
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

	// RVA: 0x15A2FD8
	internal static int GetBoneIndexFromMono(int humanId) { }

}

// Namespace: UnityEngine
public class Motion
{
	// Fields
	private readonly bool <isAnimatorMotion>k__BackingField; // 0x18

	// Methods

	// RVA: 0x159FBB0
	protected void .ctor() { }

}

// Namespace: UnityEngine
public class RuntimeAnimatorController
{
	// Methods

	// RVA: 0x15A7194
	protected void .ctor() { }

	// RVA: 0x15A82E0
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

	// RVA: 0x15A8330
	public PlayableHandle GetHandle() { }

	// RVA: 0x15A833C
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

	// RVA: 0x15A83C0
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization) { }

	// RVA: 0x15A85A8
	public PlayableHandle GetHandle() { }

	// RVA: 0x15A85B4
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x15A8540
	private static void SetSingleLayerOptimizationInternal(PlayableHandle handle, bool value) { }

	// RVA: 0x15A8684
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15A8728
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15A8844
	public PlayableHandle GetHandle() { }

	// RVA: 0x15A8850
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x15A8920
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationMotionXToDeltaPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15A89C0
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x15A8ADC
	public PlayableHandle GetHandle() { }

	// RVA: 0x15A8AE8
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x15A8BB8
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationOffsetPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15A8C58
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15A8D74
	public PlayableHandle GetHandle() { }

	// RVA: 0x15A8D80
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x15A8E3C
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

	// RVA: 0x15A8EDC
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15A8FF8
	public PlayableHandle GetHandle() { }

	// RVA: 0x15A9004
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x15A90C0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationRemoveScalePlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15A9160
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15A927C
	public PlayableHandle GetHandle() { }

	// RVA: 0x15A9288
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x15A9344
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationScriptPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x15A93E4
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15A9500
	public PlayableHandle GetHandle() { }

	// RVA: 0x15A950C
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x15A95DC
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

	// RVA: 0x15A967C
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x15A98E8
	public PlayableHandle GetHandle() { }

	// RVA: 0x15A9754
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x15A98F4
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x15A99C4
	private static void .cctor() { }

}


