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

	// RVA: 0x14AB828
	void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x14AB82C
	void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x14AB830
	void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x14AB834
	void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x14AB838
	void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x14AB83C
	void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x14AB840
	void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x14AB844
	void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x14AB848
	void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x14AB84C
	void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x14AB850
	void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x14AB854
	void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x14AB858
	void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x14AB85C
	void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x14AB860
	void .ctor() { }

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

	// RVA: 0x14ACA2C
	void .ctor(Animation outer) { }

	// RVA: 0x14AD004
	object get_Current() { }

	// RVA: 0x14AD074
	bool MoveNext() { }

	// RVA: 0x14AD0E0
	void Reset() { }

}

// Namespace: UnityEngine
public sealed class Animation 
{
	// Methods

	// RVA: 0x14AB868
	AnimationClip get_clip() { }

	// RVA: 0x14AB8B8
	void set_clip(AnimationClip value) { }

	// RVA: 0x14AB920
	bool get_playAutomatically() { }

	// RVA: 0x14AB970
	void set_playAutomatically(bool value) { }

	// RVA: 0x14AB9D8
	WrapMode get_wrapMode() { }

	// RVA: 0x14ABA28
	void set_wrapMode(WrapMode value) { }

	// RVA: 0x14ABA90
	void Stop() { }

	// RVA: 0x14ABAE0
	void Stop(string name) { }

	// RVA: 0x14ABB48
	void StopNamed(string name) { }

	// RVA: 0x14ABBB0
	void Rewind() { }

	// RVA: 0x14ABC00
	void Rewind(string name) { }

	// RVA: 0x14ABC68
	void RewindNamed(string name) { }

	// RVA: 0x14ABCD0
	void Sample() { }

	// RVA: 0x14ABD20
	bool get_isPlaying() { }

	// RVA: 0x14ABD70
	bool IsPlaying(string name) { }

	// RVA: 0x14ABDD8
	AnimationState get_Item(string name) { }

	// RVA: 0x14ABEA8
	bool Play() { }

	// RVA: 0x14ABF00
	bool Play(PlayMode mode) { }

	// RVA: 0x14ABF68
	bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x14ABFD0
	bool Play(string animation) { }

	// RVA: 0x14AC024
	bool Play(string animation, PlayMode mode) { }

	// RVA: 0x14AC07C
	void CrossFade(string animation) { }

	// RVA: 0x14AC0DC
	void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x14AC140
	void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	// RVA: 0x14AC1A8
	void Blend(string animation) { }

	// RVA: 0x14AC208
	void Blend(string animation, float targetWeight) { }

	// RVA: 0x14AC274
	void Blend(string animation, float targetWeight, float fadeLength) { }

	// RVA: 0x14AC2DC
	AnimationState CrossFadeQueued(string animation) { }

	// RVA: 0x14AC340
	AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	// RVA: 0x14AC3A8
	AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	// RVA: 0x14AC414
	AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	// RVA: 0x14AC48C
	AnimationState PlayQueued(string animation) { }

	// RVA: 0x14AC4E4
	AnimationState PlayQueued(string animation, QueueMode queue) { }

	// RVA: 0x14AC540
	AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0x14AC5A8
	void AddClip(AnimationClip clip, string newName) { }

	// RVA: 0x14AC60C
	void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	// RVA: 0x14AC680
	void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x14AC700
	void RemoveClip(AnimationClip clip) { }

	// RVA: 0x14AC768
	void RemoveClip(string clipName) { }

	// RVA: 0x14AC7D0
	void RemoveClipNamed(string clipName) { }

	// RVA: 0x14AC838
	int GetClipCount() { }

	// RVA: 0x14AC888
	bool Play(AnimationPlayMode mode) { }

	// RVA: 0x14AC8F0
	bool Play(string animation, AnimationPlayMode mode) { }

	// RVA: 0x14AC948
	void SyncLayer(int layer) { }

	// RVA: 0x14AC9B0
	IEnumerator GetEnumerator() { }

	// RVA: 0x14ABE40
	AnimationState GetState(string name) { }

	// RVA: 0x14ACA68
	AnimationState GetStateAtIndex(int index) { }

	// RVA: 0x14ACAD0
	int GetStateCount() { }

	// RVA: 0x14ACB20
	AnimationClip GetClip(string name) { }

	// RVA: 0x14ACC28
	bool get_animatePhysics() { }

	// RVA: 0x14ACC78
	void set_animatePhysics(bool value) { }

	// RVA: 0x14ACCE0
	bool get_animateOnlyIfVisible() { }

	// RVA: 0x14ACD30
	void set_animateOnlyIfVisible(bool value) { }

	// RVA: 0x14ACD98
	AnimationCullingType get_cullingType() { }

	// RVA: 0x14ACDE8
	void set_cullingType(AnimationCullingType value) { }

	// RVA: 0x14ACE50
	Bounds get_localBounds() { }

	// RVA: 0x14ACF2C
	void set_localBounds(Bounds value) { }

	// RVA: 0x14ACFFC
	void .ctor() { }

	// RVA: 0x14ACEC4
	void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x14ACF94
	void set_localBounds_Injected(ref Bounds value) { }

}

// Namespace: UnityEngine
public sealed class AnimationState 
{
	// Methods

	// RVA: 0x14AD0EC
	void set_wrapMode(WrapMode value) { }

	// RVA: 0x14AD154
	void set_time(float value) { }

	// RVA: 0x14AD1BC
	void set_speed(float value) { }

	// RVA: 0x14AD224
	float get_length() { }

	// RVA: 0x14AD274
	void set_layer(int value) { }

	// RVA: 0x14ACBD8
	AnimationClip get_clip() { }

	// RVA: 0x14AD2DC
	string get_name() { }

	// RVA: 0x14AD32C
	void set_blendMode(AnimationBlendMode value) { }

	// RVA: 0x14AD394
	void .ctor() { }

}

// Namespace: UnityEngine
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

	// RVA: 0x14AD39C
	void .ctor() { }

	// RVA: 0x14AD438
	string get_stringParameter() { }

}

// Namespace: UnityEngine
public sealed class AnimationClip 
{
	// Methods

	// RVA: 0x14AD440
	void .ctor() { }

	// RVA: 0x14AD58C
	void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x14AD5DC
	float get_length() { }

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

	// RVA: 0x14AD62C
	int get_shortNameHash() { }

	// RVA: 0x14AD634
	float get_normalizedTime() { }

	// RVA: 0x14AD63C
	bool get_loop() { }

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

	// RVA: 0x14AD64C
	bool get_isOptimizable() { }

	// RVA: 0x14AD69C
	bool get_isHuman() { }

	// RVA: 0x14AD6EC
	bool get_hasRootMotion() { }

	// RVA: 0x14AD73C
	bool get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0x14AD78C
	float get_humanScale() { }

	// RVA: 0x14AD7DC
	bool get_isInitialized() { }

	// RVA: 0x14AD82C
	float GetFloat(string name) { }

	// RVA: 0x14AD8FC
	float GetFloat(int id) { }

	// RVA: 0x14AD9CC
	void SetFloat(string name, float value) { }

	// RVA: 0x14ADA8C
	void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x14ADB7C
	void SetFloat(int id, float value) { }

	// RVA: 0x14ADC3C
	void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x14ADD2C
	bool GetBool(string name) { }

	// RVA: 0x14ADDFC
	bool GetBool(int id) { }

	// RVA: 0x14ADECC
	void SetBool(string name, bool value) { }

	// RVA: 0x14ADF7C
	void SetBool(int id, bool value) { }

	// RVA: 0x14AE02C
	int GetInteger(string name) { }

	// RVA: 0x14AE0FC
	int GetInteger(int id) { }

	// RVA: 0x14AE1CC
	void SetInteger(string name, int value) { }

	// RVA: 0x14AE27C
	void SetInteger(int id, int value) { }

	// RVA: 0x14AE32C
	void SetTrigger(string name) { }

	// RVA: 0x14AE3FC
	void SetTrigger(int id) { }

	// RVA: 0x14AE4CC
	void ResetTrigger(string name) { }

	// RVA: 0x14AE59C
	void ResetTrigger(int id) { }

	// RVA: 0x14AE66C
	bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x14AE73C
	bool IsParameterControlledByCurve(int id) { }

	// RVA: 0x14AE80C
	Vector3 get_deltaPosition() { }

	// RVA: 0x14AE8D4
	Quaternion get_deltaRotation() { }

	// RVA: 0x14AE998
	Vector3 get_velocity() { }

	// RVA: 0x14AEA60
	Vector3 get_angularVelocity() { }

	// RVA: 0x14AEB28
	Vector3 get_rootPosition() { }

	// RVA: 0x14AEBF0
	void set_rootPosition(Vector3 value) { }

	// RVA: 0x14AECB0
	Quaternion get_rootRotation() { }

	// RVA: 0x14AED74
	void set_rootRotation(Quaternion value) { }

	// RVA: 0x14AEE34
	bool get_applyRootMotion() { }

	// RVA: 0x14AEE84
	void set_applyRootMotion(bool value) { }

	// RVA: 0x14AEEEC
	bool get_linearVelocityBlending() { }

	// RVA: 0x14AEF3C
	void set_linearVelocityBlending(bool value) { }

	// RVA: 0x14AEFA4
	bool get_animatePhysics() { }

	// RVA: 0x14AF040
	void set_animatePhysics(bool value) { }

	// RVA: 0x14AEFF0
	AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x14AF0B0
	void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x14AF118
	bool get_hasTransformHierarchy() { }

	// RVA: 0x14AF168
	bool get_allowConstantClipSamplingOptimization() { }

	// RVA: 0x14AF1B8
	void set_allowConstantClipSamplingOptimization(bool value) { }

	// RVA: 0x14AF220
	float get_gravityWeight() { }

	// RVA: 0x14AF270
	Vector3 get_bodyPosition() { }

	// RVA: 0x14AF430
	void set_bodyPosition(Vector3 value) { }

	// RVA: 0x14AF3D0
	Vector3 get_bodyPositionInternal() { }

	// RVA: 0x14AF4A8
	void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0x14AF5D0
	Quaternion get_bodyRotation() { }

	// RVA: 0x14AF68C
	void set_bodyRotation(Quaternion value) { }

	// RVA: 0x14AF630
	Quaternion get_bodyRotationInternal() { }

	// RVA: 0x14AF708
	void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0x14AF830
	Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x14AF8A4
	Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0x14AF96C
	void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x14AF9F4
	void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x14AFAB4
	Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x14AFB24
	Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0x14AFBE8
	void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x14AFC74
	void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x14AFD34
	float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x14AFDA0
	float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x14AFE08
	void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x14AFE6C
	void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x14AFECC
	float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x14AFF38
	float GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0x14AFFA0
	void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x14B0004
	void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x14B0064
	Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0x14B00D8
	Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0x14B01A0
	void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x14B0228
	void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x14B02E8
	float GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0x14B0354
	float GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0x14B03BC
	void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	// RVA: 0x14B0420
	void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	// RVA: 0x14B0480
	void SetLookAtPosition(Vector3 lookAtPosition) { }

	// RVA: 0x14B04F8
	void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x14B05B8
	void SetLookAtWeight(float weight) { }

	// RVA: 0x14B069C
	void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x14B0704
	void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x14B0778
	void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x14B07F0
	void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x14B061C
	void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x14B0874
	void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	// RVA: 0x14B097C
	void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x14B0A3C
	ScriptableObject GetBehaviour(Type type) { }

	// RVA: 0x309AF8C
	T GetBehaviour() { }

	// RVA: 0x2FE7084
	T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	// RVA: 0x2FE360C
	T[] GetBehaviours() { }

	// RVA: 0x14B0AA4
	ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0x14B0B0C
	StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	// RVA: 0x14B0BEC
	ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x14B0C54
	bool get_stabilizeFeet() { }

	// RVA: 0x14B0CA4
	void set_stabilizeFeet(bool value) { }

	// RVA: 0x14B0D0C
	int get_layerCount() { }

	// RVA: 0x14B0D5C
	string GetLayerName(int layerIndex) { }

	// RVA: 0x14B0DC4
	int GetLayerIndex(string layerName) { }

	// RVA: 0x14B0E2C
	float GetLayerWeight(int layerIndex) { }

	// RVA: 0x14B0E94
	void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x14B0EF4
	void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	// RVA: 0x14B0F5C
	AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x14B0FE0
	AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x14B1064
	void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	// RVA: 0x14B10BC
	AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x14B1130
	int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	// RVA: 0x14B1188
	int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x14B11DC
	int GetNextAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x14B1230
	AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x14B1298
	AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x14B1300
	void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x14B13A8
	void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x14B1410
	void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x14B14B8
	bool IsInTransition(int layerIndex) { }

	// RVA: 0x14B1520
	AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x14B1570
	int get_parameterCount() { }

	// RVA: 0x14B15C0
	AnimatorControllerParameter GetParameterInternal(int index) { }

	// RVA: 0x14B1628
	AnimatorControllerParameter GetParameter(int index) { }

	// RVA: 0x14B1704
	float get_feetPivotActive() { }

	// RVA: 0x14B1754
	void set_feetPivotActive(float value) { }

	// RVA: 0x14B17BC
	float get_pivotWeight() { }

	// RVA: 0x14B180C
	Vector3 get_pivotPosition() { }

	// RVA: 0x14B18D4
	void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x14B1A08
	void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	// RVA: 0x14B1AA0
	void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	// RVA: 0x14B1B38
	void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x14B1BD4
	void InterruptMatchTarget() { }

	// RVA: 0x14B1C2C
	void InterruptMatchTarget(bool completeMatch) { }

	// RVA: 0x14B1C94
	bool get_isMatchingTarget() { }

	// RVA: 0x14B1CE4
	float get_speed() { }

	// RVA: 0x14B1D34
	void set_speed(float value) { }

	// RVA: 0x14B1D9C
	void ForceStateNormalizedTime(float normalizedTime) { }

	// RVA: 0x14B1E5C
	void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	// RVA: 0x14B1FE0
	void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x14B2098
	void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x14B2154
	void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x14B221C
	void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x14B2290
	void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x14B2300
	void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	// RVA: 0x14B1F60
	void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x14B236C
	void WriteDefaultValues() { }

	// RVA: 0x14B23BC
	void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x14B2540
	void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x14B25FC
	void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x14B2478
	void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x14B26B4
	void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x14B2734
	void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x14B27A8
	void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x14B281C
	void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	// RVA: 0x14B288C
	void PlayInFixedTime(string stateName, int layer) { }

	// RVA: 0x14B29E4
	void PlayInFixedTime(string stateName) { }

	// RVA: 0x14B2934
	void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	// RVA: 0x14B2A88
	void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x14B2AF0
	void PlayInFixedTime(int stateNameHash, int layer) { }

	// RVA: 0x14B2B50
	void PlayInFixedTime(int stateNameHash) { }

	// RVA: 0x14B2BAC
	void Play(string stateName, int layer) { }

	// RVA: 0x14B2D04
	void Play(string stateName) { }

	// RVA: 0x14B2C54
	void Play(string stateName, int layer, float normalizedTime) { }

	// RVA: 0x14B1DF4
	void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x14B2DA8
	void Play(int stateNameHash, int layer) { }

	// RVA: 0x14B2E08
	void Play(int stateNameHash) { }

	// RVA: 0x14B2E64
	void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x14B2EC4
	Vector3 get_targetPosition() { }

	// RVA: 0x14B2F8C
	Quaternion get_targetRotation() { }

	// RVA: 0x14B3050
	bool IsControlled(Transform transform) { }

	// RVA: 0x14B3058
	bool IsBoneTransform(Transform transform) { }

	// RVA: 0x14B30C0
	Transform get_avatarRoot() { }

	// RVA: 0x14B3110
	Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	// RVA: 0x14B3524
	Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x14B358C
	AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x14B35DC
	void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x14B3644
	void StartPlayback() { }

	// RVA: 0x14B3694
	void StopPlayback() { }

	// RVA: 0x14B36E4
	float get_playbackTime() { }

	// RVA: 0x14B3734
	void set_playbackTime(float value) { }

	// RVA: 0x14B379C
	void StartRecording(int frameCount) { }

	// RVA: 0x14B3804
	void StopRecording() { }

	// RVA: 0x14B3854
	float get_recorderStartTime() { }

	// RVA: 0x14B38F4
	void set_recorderStartTime(float value) { }

	// RVA: 0x14B38A4
	float GetRecorderStartTime() { }

	// RVA: 0x14B38F8
	float get_recorderStopTime() { }

	// RVA: 0x14B3998
	void set_recorderStopTime(float value) { }

	// RVA: 0x14B3948
	float GetRecorderStopTime() { }

	// RVA: 0x14B399C
	AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0x14B39EC
	RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x14B3A3C
	void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x14B3AA4
	bool get_hasBoundPlayables() { }

	// RVA: 0x14B3AF4
	void ClearInternalControllerPlayable() { }

	// RVA: 0x14B3B44
	bool HasState(int layerIndex, int stateID) { }

	// RVA: 0x14B1F10
	int StringToHash(string name) { }

	// RVA: 0x14B3434
	Avatar get_avatar() { }

	// RVA: 0x14B3B9C
	void set_avatar(Avatar value) { }

	// RVA: 0x14B3C04
	string GetStats() { }

	// RVA: 0x14B3C54
	PlayableGraph get_playableGraph() { }

	// RVA: 0x14B3CAC
	void GetCurrentGraph(ref PlayableGraph graph) { }

	// RVA: 0x14AF2D4
	void CheckIfInIKPass() { }

	// RVA: 0x14B3D64
	bool IsInIKPass() { }

	// RVA: 0x14ADA2C
	void SetFloatString(string name, float value) { }

	// RVA: 0x14ADBDC
	void SetFloatID(int id, float value) { }

	// RVA: 0x14AD894
	float GetFloatString(string name) { }

	// RVA: 0x14AD964
	float GetFloatID(int id) { }

	// RVA: 0x14ADF24
	void SetBoolString(string name, bool value) { }

	// RVA: 0x14ADFD4
	void SetBoolID(int id, bool value) { }

	// RVA: 0x14ADD94
	bool GetBoolString(string name) { }

	// RVA: 0x14ADE64
	bool GetBoolID(int id) { }

	// RVA: 0x14AE224
	void SetIntegerString(string name, int value) { }

	// RVA: 0x14AE2D4
	void SetIntegerID(int id, int value) { }

	// RVA: 0x14AE094
	int GetIntegerString(string name) { }

	// RVA: 0x14AE164
	int GetIntegerID(int id) { }

	// RVA: 0x14AE394
	void SetTriggerString(string name) { }

	// RVA: 0x14AE464
	void SetTriggerID(int id) { }

	// RVA: 0x14AE534
	void ResetTriggerString(string name) { }

	// RVA: 0x14AE604
	void ResetTriggerID(int id) { }

	// RVA: 0x14AE6D4
	bool IsParameterControlledByCurveString(string name) { }

	// RVA: 0x14AE7A4
	bool IsParameterControlledByCurveID(int id) { }

	// RVA: 0x14ADB04
	void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x14ADCB4
	void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x14B3DB4
	bool get_layersAffectMassCenter() { }

	// RVA: 0x14B3E04
	void set_layersAffectMassCenter(bool value) { }

	// RVA: 0x14B3E6C
	float get_leftFeetBottomHeight() { }

	// RVA: 0x14B3EBC
	float get_rightFeetBottomHeight() { }

	// RVA: 0x14B3F0C
	bool get_supportsOnAnimatorMove() { }

	// RVA: 0x14B3F5C
	void OnUpdateModeChanged() { }

	// RVA: 0x14B3FAC
	void OnCullingModeChanged() { }

	// RVA: 0x14B3FFC
	void WriteDefaultPose() { }

	// RVA: 0x14B404C
	void Update(float deltaTime) { }

	// RVA: 0x14B40B4
	void Rebind() { }

	// RVA: 0x14B410C
	void Rebind(bool writeDefaultValues) { }

	// RVA: 0x14B4174
	void ApplyBuiltinRootMotion() { }

	// RVA: 0x14B41C4
	void EvaluateController() { }

	// RVA: 0x14B421C
	void EvaluateController(float deltaTime) { }

	// RVA: 0x14B4284
	string GetCurrentStateName(int layerIndex) { }

	// RVA: 0x14B4330
	string GetNextStateName(int layerIndex) { }

	// RVA: 0x14B42D8
	string GetAnimatorStateName(int layerIndex, bool current) { }

	// RVA: 0x14B4384
	string ResolveHash(int hash) { }

	// RVA: 0x14B3D14
	bool get_logWarnings() { }

	// RVA: 0x14B43EC
	void set_logWarnings(bool value) { }

	// RVA: 0x14B4454
	bool get_fireEvents() { }

	// RVA: 0x14B44A4
	void set_fireEvents(bool value) { }

	// RVA: 0x14B450C
	bool get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0x14B45AC
	void set_keepAnimatorControllerStateOnDisable(bool value) { }

	// RVA: 0x14B455C
	bool get_keepAnimatorStateOnDisable() { }

	// RVA: 0x14B4614
	void set_keepAnimatorStateOnDisable(bool value) { }

	// RVA: 0x14B467C
	bool get_writeDefaultValuesOnDisable() { }

	// RVA: 0x14B46CC
	void set_writeDefaultValuesOnDisable(bool value) { }

	// RVA: 0x14B4734
	Vector3 GetVector(string name) { }

	// RVA: 0x14B4784
	Vector3 GetVector(int id) { }

	// RVA: 0x14B47D4
	void SetVector(string name, Vector3 value) { }

	// RVA: 0x14B47D8
	void SetVector(int id, Vector3 value) { }

	// RVA: 0x14B47DC
	Quaternion GetQuaternion(string name) { }

	// RVA: 0x14B482C
	Quaternion GetQuaternion(int id) { }

	// RVA: 0x14B487C
	void SetQuaternion(string name, Quaternion value) { }

	// RVA: 0x14B4880
	void SetQuaternion(int id, Quaternion value) { }

	// RVA: 0x14B4884
	void .ctor() { }

	// RVA: 0x14AE86C
	void get_deltaPosition_Injected(out Vector3 ret) { }

	// RVA: 0x14AE930
	void get_deltaRotation_Injected(out Quaternion ret) { }

	// RVA: 0x14AE9F8
	void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x14AEAC0
	void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x14AEB88
	void get_rootPosition_Injected(out Vector3 ret) { }

	// RVA: 0x14AEC48
	void set_rootPosition_Injected(ref Vector3 value) { }

	// RVA: 0x14AED0C
	void get_rootRotation_Injected(out Quaternion ret) { }

	// RVA: 0x14AEDCC
	void set_rootRotation_Injected(ref Quaternion value) { }

	// RVA: 0x14AF500
	void get_bodyPositionInternal_Injected(out Vector3 ret) { }

	// RVA: 0x14AF568
	void set_bodyPositionInternal_Injected(ref Vector3 value) { }

	// RVA: 0x14AF760
	void get_bodyRotationInternal_Injected(out Quaternion ret) { }

	// RVA: 0x14AF7C8
	void set_bodyRotationInternal_Injected(ref Quaternion value) { }

	// RVA: 0x14AF914
	void GetGoalPosition_Injected(AvatarIKGoal goal, out Vector3 ret) { }

	// RVA: 0x14AFA5C
	void SetGoalPosition_Injected(AvatarIKGoal goal, ref Vector3 goalPosition) { }

	// RVA: 0x14AFB90
	void GetGoalRotation_Injected(AvatarIKGoal goal, out Quaternion ret) { }

	// RVA: 0x14AFCDC
	void SetGoalRotation_Injected(AvatarIKGoal goal, ref Quaternion goalRotation) { }

	// RVA: 0x14B0148
	void GetHintPosition_Injected(AvatarIKHint hint, out Vector3 ret) { }

	// RVA: 0x14B0290
	void SetHintPosition_Injected(AvatarIKHint hint, ref Vector3 hintPosition) { }

	// RVA: 0x14B0550
	void SetLookAtPositionInternal_Injected(ref Vector3 lookAtPosition) { }

	// RVA: 0x14B09E4
	void SetBoneLocalRotationInternal_Injected(int humanBoneId, ref Quaternion rotation) { }

	// RVA: 0x14B186C
	void get_pivotPosition_Injected(out Vector3 ret) { }

	// RVA: 0x14B1970
	void MatchTarget_Injected(ref Vector3 matchPosition, ref Quaternion matchRotation, int targetBodyPart, ref MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x14B2F24
	void get_targetPosition_Injected(out Vector3 ret) { }

	// RVA: 0x14B2FE8
	void get_targetRotation_Injected(out Quaternion ret) { }

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

	// RVA: 0x14B488C
	string get_name() { }

	// RVA: 0x14B4894
	bool Equals(object o) { }

	// RVA: 0x14B4990
	int GetHashCode() { }

	// RVA: 0x14B49B4
	void .ctor() { }

}

// Namespace: UnityEngine
public class AnimationClipPair 
{
	// Fields
	public AnimationClip originalClip; // 0x10
	public AnimationClip overrideClip; // 0x18

	// Methods

	// RVA: 0x14B4A18
	void .ctor() { }

}

// Namespace: 
internal sealed class OnOverrideControllerDirtyCallback 
{
	// Methods

	// RVA: 0x14B5AF8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B5B98
	internal void Invoke() { }

}

// Namespace: UnityEngine
public class AnimatorOverrideController 
{
	// Fields
	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Methods

	// RVA: 0x14B4A20
	void .ctor() { }

	// RVA: 0x14B4BD8
	void .ctor(RuntimeAnimatorController controller) { }

	// RVA: 0x14B4B70
	void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	// RVA: 0x14B4CA4
	RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x14B4CF4
	void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x14B4D5C
	AnimationClip get_Item(string name) { }

	// RVA: 0x14B4E08
	void set_Item(string name, AnimationClip value) { }

	// RVA: 0x14B4DB0
	AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	// RVA: 0x14B4E60
	void Internal_SetClipByName(string name, AnimationClip clip) { }

	// RVA: 0x14B4EB8
	AnimationClip get_Item(AnimationClip clip) { }

	// RVA: 0x14B4F64
	void set_Item(AnimationClip clip, AnimationClip value) { }

	// RVA: 0x14B4F0C
	AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	// RVA: 0x14B4FC0
	void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

	// RVA: 0x14B5028
	void SendNotification() { }

	// RVA: 0x14B5078
	AnimationClip GetOriginalClip(int index) { }

	// RVA: 0x14B50E0
	AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	// RVA: 0x14B5148
	int get_overridesCount() { }

	// RVA: 0x14B5198
	void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x14B540C
	void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x14B57A4
	AnimationClipPair[] get_clips() { }

	// RVA: 0x14B59A0
	void set_clips(AnimationClipPair[] value) { }

	// RVA: 0x14B5A74
	void PerformOverrideClipListCleanup() { }

	// RVA: 0x14B5AC4
	void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

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

	// RVA: 0x14B5BAC
	void .ctor() { }

	// RVA: 0x14B3484
	bool get_isValid() { }

	// RVA: 0x14B34D4
	bool get_isHuman() { }

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

	// RVA: 0x14B092C
	int GetBoneIndexFromMono(int humanId) { }

}

// Namespace: UnityEngine
public class Motion 
{
	// Fields
	private readonly bool <isAnimatorMotion>k__BackingField; // 0x18

	// Methods

	// RVA: 0x14AD504
	void .ctor() { }

}

// Namespace: UnityEngine
public class RuntimeAnimatorController 
{
	// Methods

	// RVA: 0x14B4AE8
	void .ctor() { }

	// RVA: 0x14B5C34
	AnimationClip[] get_animationClips() { }

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

	// RVA: 0x14B5C84
	PlayableHandle GetHandle() { }

	// RVA: 0x14B5C90
	bool Equals(AnimationClipPlayable other) { }

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

	// RVA: 0x14B5D14
	void .ctor(PlayableHandle handle, bool singleLayerOptimization) { }

	// RVA: 0x14B5EFC
	PlayableHandle GetHandle() { }

	// RVA: 0x14B5F08
	bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x14B5E94
	void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x14B5FD8
	void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationMixerPlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x14B607C
	void .ctor(PlayableHandle handle) { }

	// RVA: 0x14B6198
	PlayableHandle GetHandle() { }

	// RVA: 0x14B61A4
	bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x14B6274
	void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationMotionXToDeltaPlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x14B6314
	void .ctor(PlayableHandle handle) { }

	// RVA: 0x14B6430
	PlayableHandle GetHandle() { }

	// RVA: 0x14B643C
	bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x14B650C
	void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationOffsetPlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x14B65AC
	void .ctor(PlayableHandle handle) { }

	// RVA: 0x14B66C8
	PlayableHandle GetHandle() { }

	// RVA: 0x14B66D4
	bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x14B6790
	void .cctor() { }

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

	// RVA: 0x14B6830
	void .ctor(PlayableHandle handle) { }

	// RVA: 0x14B694C
	PlayableHandle GetHandle() { }

	// RVA: 0x14B6958
	bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x14B6A14
	void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationRemoveScalePlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x14B6AB4
	void .ctor(PlayableHandle handle) { }

	// RVA: 0x14B6BD0
	PlayableHandle GetHandle() { }

	// RVA: 0x14B6BDC
	bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x14B6C98
	void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationScriptPlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x14B6D38
	void .ctor(PlayableHandle handle) { }

	// RVA: 0x14B6E54
	PlayableHandle GetHandle() { }

	// RVA: 0x14B6E60
	bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x14B6F30
	void .cctor() { }

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

	// RVA: 0x14B6FD0
	void .ctor(PlayableHandle handle) { }

	// RVA: 0x14B723C
	PlayableHandle GetHandle() { }

	// RVA: 0x14B70A8
	void SetHandle(PlayableHandle handle) { }

	// RVA: 0x14B7248
	bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x14B7318
	void .cctor() { }

}


