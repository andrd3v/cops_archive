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

	// RVA: 0x16078FC
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1607900
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1607904
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1607908
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x160790C
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1607910
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x1607914
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x1607918
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x160791C
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1607920
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1607924
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1607928
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x160792C
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x1607930
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x1607934
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
public enum AnimationUpdateMode
{
	// Fields
	public int value__; // 0x10
	public const AnimationUpdateMode Normal = 0;
	public const AnimationUpdateMode Fixed = 1;
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

	// RVA: 0x160A3DC
	internal void .ctor(Animation outer) { }

	// RVA: 0x160B24C
	public object get_Current() { }

	// RVA: 0x160B304
	public bool MoveNext() { }

	// RVA: 0x160B3BC
	public void Reset() { }

}

// Namespace: UnityEngine
public sealed class Animation
{
	// Methods

	// RVA: 0x160793C
	public AnimationClip get_clip() { }

	// RVA: 0x1607A44
	public void set_clip(AnimationClip value) { }

	// RVA: 0x1607B90
	public bool get_playAutomatically() { }

	// RVA: 0x1607C78
	public void set_playAutomatically(bool value) { }

	// RVA: 0x1607D90
	public WrapMode get_wrapMode() { }

	// RVA: 0x1607E78
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x1607F90
	public void Stop() { }

	// RVA: 0x1608078
	public void Stop(string name) { }

	// RVA: 0x160807C
	private void StopNamed(string name) { }

	// RVA: 0x16082A0
	public void Rewind() { }

	// RVA: 0x1608388
	public void Rewind(string name) { }

	// RVA: 0x160838C
	private void RewindNamed(string name) { }

	// RVA: 0x16085B0
	public void Sample() { }

	// RVA: 0x1608698
	public bool get_isPlaying() { }

	// RVA: 0x1608780
	public bool IsPlaying(string name) { }

	// RVA: 0x16089C0
	public AnimationState get_Item(string name) { }

	// RVA: 0x1608B9C
	public bool Play() { }

	// RVA: 0x1608C3C
	public bool Play(PlayMode mode) { }

	// RVA: 0x1608CEC
	private bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x1608E04
	public bool Play(string animation) { }

	// RVA: 0x1608E0C
	public bool Play(string animation, PlayMode mode) { }

	// RVA: 0x1609044
	public void CrossFade(string animation) { }

	// RVA: 0x1609058
	public void CrossFade(string animation, float fadeLength) { }

	// RVA: 0x1609060
	public void CrossFade(string animation, float fadeLength, PlayMode mode) { }

	// RVA: 0x16092A0
	public void Blend(string animation) { }

	// RVA: 0x16092B4
	public void Blend(string animation, float targetWeight) { }

	// RVA: 0x16092C4
	public void Blend(string animation, float targetWeight, float fadeLength) { }

	// RVA: 0x1609504
	public AnimationState CrossFadeQueued(string animation) { }

	// RVA: 0x160951C
	public AnimationState CrossFadeQueued(string animation, float fadeLength) { }

	// RVA: 0x1609528
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue) { }

	// RVA: 0x1609530
	public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	// RVA: 0x1609798
	public AnimationState PlayQueued(string animation) { }

	// RVA: 0x16097A4
	public AnimationState PlayQueued(string animation, QueueMode queue) { }

	// RVA: 0x16097AC
	public AnimationState PlayQueued(string animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0x1609A08
	public void AddClip(AnimationClip clip, string newName) { }

	// RVA: 0x1609A18
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	// RVA: 0x1609A20
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x1609D08
	public void RemoveClip(AnimationClip clip) { }

	// RVA: 0x1609E84
	public void RemoveClip(string clipName) { }

	// RVA: 0x1609E88
	private void RemoveClipNamed(string clipName) { }

	// RVA: 0x160A0AC
	public int GetClipCount() { }

	// RVA: 0x160A194
	public bool Play(AnimationPlayMode mode) { }

	// RVA: 0x160A244
	public bool Play(string animation, AnimationPlayMode mode) { }

	// RVA: 0x160A248
	public void SyncLayer(int layer) { }

	// RVA: 0x160A360
	public IEnumerator GetEnumerator() { }

	// RVA: 0x16089C4
	internal AnimationState GetState(string name) { }

	// RVA: 0x160A480
	internal AnimationState GetStateAtIndex(int index) { }

	// RVA: 0x160A598
	internal int GetStateCount() { }

	// RVA: 0x160A680
	public AnimationClip GetClip(string name) { }

	// RVA: 0x160A804
	public bool get_animatePhysics() { }

	// RVA: 0x160A8EC
	public void set_animatePhysics(bool value) { }

	// RVA: 0x160AA04
	public AnimationUpdateMode get_updateMode() { }

	// RVA: 0x160AAEC
	public void set_updateMode(AnimationUpdateMode value) { }

	// RVA: 0x160AC04
	public bool get_animateOnlyIfVisible() { }

	// RVA: 0x160ACEC
	public void set_animateOnlyIfVisible(bool value) { }

	// RVA: 0x160AE04
	public AnimationCullingType get_cullingType() { }

	// RVA: 0x160AEEC
	public void set_cullingType(AnimationCullingType value) { }

	// RVA: 0x160B004
	public Bounds get_localBounds() { }

	// RVA: 0x160B12C
	public void set_localBounds(Bounds value) { }

	// RVA: 0x160B244
	public void .ctor() { }

	// RVA: 0x16079F4
	private static IntPtr get_clip_Injected(IntPtr _unity_self) { }

	// RVA: 0x1607B28
	private static void set_clip_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1607C28
	private static bool get_playAutomatically_Injected(IntPtr _unity_self) { }

	// RVA: 0x1607D28
	private static void set_playAutomatically_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1607E28
	private static WrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1607F28
	private static void set_wrapMode_Injected(IntPtr _unity_self, WrapMode value) { }

	// RVA: 0x1608028
	private static void Stop_Injected(IntPtr _unity_self) { }

	// RVA: 0x1608238
	private static void StopNamed_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x1608338
	private static void Rewind_Injected(IntPtr _unity_self) { }

	// RVA: 0x1608548
	private static void RewindNamed_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x1608648
	private static void Sample_Injected(IntPtr _unity_self) { }

	// RVA: 0x1608730
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	// RVA: 0x1608958
	private static bool IsPlaying_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x1608D9C
	private static bool PlayDefaultAnimation_Injected(IntPtr _unity_self, PlayMode mode) { }

	// RVA: 0x1608FEC
	private static bool Play_Injected(IntPtr _unity_self, ManagedSpanWrapper animation, PlayMode mode) { }

	// RVA: 0x1609238
	private static void CrossFade_Injected(IntPtr _unity_self, ManagedSpanWrapper animation, float fadeLength, PlayMode mode) { }

	// RVA: 0x160949C
	private static void Blend_Injected(IntPtr _unity_self, ManagedSpanWrapper animation, float targetWeight, float fadeLength) { }

	// RVA: 0x1609720
	private static AnimationState CrossFadeQueued_Injected(IntPtr _unity_self, ManagedSpanWrapper animation, float fadeLength, QueueMode queue, PlayMode mode) { }

	// RVA: 0x16099A0
	private static AnimationState PlayQueued_Injected(IntPtr _unity_self, ManagedSpanWrapper animation, QueueMode queue, PlayMode mode) { }

	// RVA: 0x1609C88
	private static void AddClip_Injected(IntPtr _unity_self, IntPtr clip, ManagedSpanWrapper newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	// RVA: 0x1609E1C
	private static void RemoveClip_Injected(IntPtr _unity_self, IntPtr clip) { }

	// RVA: 0x160A044
	private static void RemoveClipNamed_Injected(IntPtr _unity_self, ManagedSpanWrapper clipName) { }

	// RVA: 0x160A144
	private static int GetClipCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x160A2F8
	private static void SyncLayer_Injected(IntPtr _unity_self, int layer) { }

	// RVA: 0x160A418
	private static AnimationState GetState_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x160A530
	private static AnimationState GetStateAtIndex_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x160A630
	private static int GetStateCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x160A89C
	private static bool get_animatePhysics_Injected(IntPtr _unity_self) { }

	// RVA: 0x160A99C
	private static void set_animatePhysics_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x160AA9C
	private static AnimationUpdateMode get_updateMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x160AB9C
	private static void set_updateMode_Injected(IntPtr _unity_self, AnimationUpdateMode value) { }

	// RVA: 0x160AC9C
	private static bool get_animateOnlyIfVisible_Injected(IntPtr _unity_self) { }

	// RVA: 0x160AD9C
	private static void set_animateOnlyIfVisible_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x160AE9C
	private static AnimationCullingType get_cullingType_Injected(IntPtr _unity_self) { }

	// RVA: 0x160AF9C
	private static void set_cullingType_Injected(IntPtr _unity_self, AnimationCullingType value) { }

	// RVA: 0x160B0C4
	private static void get_localBounds_Injected(IntPtr _unity_self, Bounds ret) { }

	// RVA: 0x160B1DC
	private static void set_localBounds_Injected(IntPtr _unity_self, Bounds value) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x160BB10
	public static IntPtr ConvertToNative(AnimationState animationState) { }

}

// Namespace: UnityEngine
public sealed class AnimationState
{
	// Methods

	// RVA: 0x160B3C8
	public void set_wrapMode(WrapMode value) { }

	// RVA: 0x160B4B8
	public void set_time(float value) { }

	// RVA: 0x160B5A8
	public void set_speed(float value) { }

	// RVA: 0x160B698
	public float get_length() { }

	// RVA: 0x160B758
	public void set_layer(int value) { }

	// RVA: 0x160A758
	public AnimationClip get_clip() { }

	// RVA: 0x160B898
	public string get_name() { }

	// RVA: 0x160BA18
	public void set_blendMode(AnimationBlendMode value) { }

	// RVA: 0x160BB08
	public void .ctor() { }

	// RVA: 0x160B450
	private static void set_wrapMode_Injected(IntPtr _unity_self, WrapMode value) { }

	// RVA: 0x160B540
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x160B630
	private static void set_speed_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x160B708
	private static float get_length_Injected(IntPtr _unity_self) { }

	// RVA: 0x160B7E0
	private static void set_layer_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x160B848
	private static IntPtr get_clip_Injected(IntPtr _unity_self) { }

	// RVA: 0x160B9B0
	private static void get_name_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x160BAA0
	private static void set_blendMode_Injected(IntPtr _unity_self, AnimationBlendMode value) { }

}

// Namespace: UnityEngine
[Serializable]
internal struct AnimationEventBlittable
{
	// Fields
	internal float m_Time; // 0x10
	internal IntPtr m_FunctionName; // 0x18
	internal IntPtr m_StringParameter; // 0x20
	internal IntPtr m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal IntPtr m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C
	private static GCHandlePool s_handlePool; // 0xFFFFFFFF

	// Methods

	// RVA: 0x160BB2C
	internal static AnimationEvent PointerToAnimationEvent(IntPtr animationEventBlittable) { }

	// RVA: 0x160BB74
	internal static AnimationEvent ToAnimationEvent(AnimationEventBlittable animationEventBlittable) { }

	// RVA: 0x160BF3C
	public void Dispose() { }

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

	// RVA: 0x160BEA0
	public void .ctor() { }

	// RVA: 0x160C260
	public string get_stringParameter() { }

}

// Namespace: UnityEngine
public sealed class AnimationClip
{
	// Methods

	// RVA: 0x160C268
	public void .ctor() { }

	// RVA: 0x160C3B4
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x160C404
	public float get_length() { }

	// RVA: 0x160C49C
	private static float get_length_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
internal class GCHandlePool
{
	// Fields
	private GCHandle[] m_handles; // 0x10
	private int m_current; // 0x18

	// Methods

	// RVA: 0x160C0E4
	public void .ctor() { }

	// RVA: 0x160C154
	public void Free(GCHandle h) { }

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
	public const AnimatorUpdateMode Fixed = 1;
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

	// RVA: 0x160C4EC
	public int get_shortNameHash() { }

	// RVA: 0x160C4F4
	public float get_normalizedTime() { }

	// RVA: 0x160C4FC
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

	// RVA: 0x160C50C
	public bool get_isOptimizable() { }

	// RVA: 0x160C5F4
	public bool get_isHuman() { }

	// RVA: 0x160C6DC
	public bool get_hasRootMotion() { }

	// RVA: 0x160C7C4
	internal bool get_isRootPositionOrRotationControlledByCurves() { }

	// RVA: 0x160C8AC
	public float get_humanScale() { }

	// RVA: 0x160C994
	public bool get_isInitialized() { }

	// RVA: 0x160CA7C
	public float GetFloat(string name) { }

	// RVA: 0x160CC44
	public float GetFloat(int id) { }

	// RVA: 0x160CDA4
	public void SetFloat(string name, float value) { }

	// RVA: 0x160CF78
	public void SetFloat(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x160D164
	public void SetFloat(int id, float value) { }

	// RVA: 0x160D2BC
	public void SetFloat(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x160D444
	public bool GetBool(string name) { }

	// RVA: 0x160D620
	public bool GetBool(int id) { }

	// RVA: 0x160D780
	public void SetBool(string name, bool value) { }

	// RVA: 0x160D94C
	public void SetBool(int id, bool value) { }

	// RVA: 0x160DA94
	public int GetInteger(string name) { }

	// RVA: 0x160DC70
	public int GetInteger(int id) { }

	// RVA: 0x160DDD0
	public void SetInteger(string name, int value) { }

	// RVA: 0x160DF9C
	public void SetInteger(int id, int value) { }

	// RVA: 0x160E0E4
	public void SetTrigger(string name) { }

	// RVA: 0x160E2A4
	public void SetTrigger(int id) { }

	// RVA: 0x160E404
	public void ResetTrigger(string name) { }

	// RVA: 0x160E5C4
	public void ResetTrigger(int id) { }

	// RVA: 0x160E724
	public bool IsParameterControlledByCurve(string name) { }

	// RVA: 0x160E900
	public bool IsParameterControlledByCurve(int id) { }

	// RVA: 0x160EA60
	public Vector3 get_deltaPosition() { }

	// RVA: 0x160EB74
	public Quaternion get_deltaRotation() { }

	// RVA: 0x160EC84
	public Vector3 get_velocity() { }

	// RVA: 0x160ED98
	public Vector3 get_angularVelocity() { }

	// RVA: 0x160EEAC
	public Vector3 get_rootPosition() { }

	// RVA: 0x160EFC0
	public void set_rootPosition(Vector3 value) { }

	// RVA: 0x160F0CC
	public Quaternion get_rootRotation() { }

	// RVA: 0x160F1DC
	public void set_rootRotation(Quaternion value) { }

	// RVA: 0x160F2E8
	public bool get_applyRootMotion() { }

	// RVA: 0x160F3D0
	public void set_applyRootMotion(bool value) { }

	// RVA: 0x160F4E8
	public bool get_linearVelocityBlending() { }

	// RVA: 0x160F5D0
	public void set_linearVelocityBlending(bool value) { }

	// RVA: 0x160F6E8
	public bool get_animatePhysics() { }

	// RVA: 0x160F7D0
	public void set_animatePhysics(bool value) { }

	// RVA: 0x160F8E8
	public AnimatorUpdateMode get_updateMode() { }

	// RVA: 0x160F9D0
	public void set_updateMode(AnimatorUpdateMode value) { }

	// RVA: 0x160FAE8
	public bool get_hasTransformHierarchy() { }

	// RVA: 0x160FBD0
	internal bool get_allowConstantClipSamplingOptimization() { }

	// RVA: 0x160FCB8
	internal void set_allowConstantClipSamplingOptimization(bool value) { }

	// RVA: 0x160FDD0
	public float get_gravityWeight() { }

	// RVA: 0x160FEB8
	public Vector3 get_bodyPosition() { }

	// RVA: 0x16101B0
	public void set_bodyPosition(Vector3 value) { }

	// RVA: 0x1610104
	internal Vector3 get_bodyPositionInternal() { }

	// RVA: 0x1610274
	internal void set_bodyPositionInternal(Vector3 value) { }

	// RVA: 0x16103E8
	public Quaternion get_bodyRotation() { }

	// RVA: 0x161053C
	public void set_bodyRotation(Quaternion value) { }

	// RVA: 0x1610494
	internal Quaternion get_bodyRotationInternal() { }

	// RVA: 0x1610604
	internal void set_bodyRotationInternal(Quaternion value) { }

	// RVA: 0x1610778
	public Vector3 GetIKPosition(AvatarIKGoal goal) { }

	// RVA: 0x1610838
	private Vector3 GetGoalPosition(AvatarIKGoal goal) { }

	// RVA: 0x161094C
	public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x1610A20
	private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x1610B2C
	public Quaternion GetIKRotation(AvatarIKGoal goal) { }

	// RVA: 0x1610BE8
	private Quaternion GetGoalRotation(AvatarIKGoal goal) { }

	// RVA: 0x1610CF8
	public void SetIKRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x1610DD0
	private void SetGoalRotation(AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x1610EDC
	public float GetIKPositionWeight(AvatarIKGoal goal) { }

	// RVA: 0x1610F90
	private float GetGoalWeightPosition(AvatarIKGoal goal) { }

	// RVA: 0x16110A8
	public void SetIKPositionWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x1611158
	private void SetGoalWeightPosition(AvatarIKGoal goal, float value) { }

	// RVA: 0x1611264
	public float GetIKRotationWeight(AvatarIKGoal goal) { }

	// RVA: 0x1611318
	private float GetGoalWeightRotation(AvatarIKGoal goal) { }

	// RVA: 0x1611430
	public void SetIKRotationWeight(AvatarIKGoal goal, float value) { }

	// RVA: 0x16114E0
	private void SetGoalWeightRotation(AvatarIKGoal goal, float value) { }

	// RVA: 0x16115EC
	public Vector3 GetIKHintPosition(AvatarIKHint hint) { }

	// RVA: 0x16116AC
	private Vector3 GetHintPosition(AvatarIKHint hint) { }

	// RVA: 0x16117C0
	public void SetIKHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x1611894
	private void SetHintPosition(AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x16119A0
	public float GetIKHintPositionWeight(AvatarIKHint hint) { }

	// RVA: 0x1611A54
	private float GetHintWeightPosition(AvatarIKHint hint) { }

	// RVA: 0x1611B6C
	public void SetIKHintPositionWeight(AvatarIKHint hint, float value) { }

	// RVA: 0x1611C1C
	private void SetHintWeightPosition(AvatarIKHint hint, float value) { }

	// RVA: 0x1611D28
	public void SetLookAtPosition(Vector3 lookAtPosition) { }

	// RVA: 0x1611DEC
	private void SetLookAtPositionInternal(Vector3 lookAtPosition) { }

	// RVA: 0x1611EF8
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x1612074
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x1612128
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x16121E8
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x16122AC
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x1611FA8
	private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x16123FC
	public void SetBoneLocalRotation(HumanBodyBones humanBoneId, Quaternion rotation) { }

	// RVA: 0x1612550
	private void SetBoneLocalRotationInternal(int humanBoneId, Quaternion rotation) { }

	// RVA: 0x161265C
	private ScriptableObject GetBehaviour(Type type) { }

	// RVA: 0x26AD93C
	public T GetBehaviour() { }

	// RVA: 0x35293EC
	private static T[] ConvertStateMachineBehaviour(ScriptableObject[] rawObjects) { }

	// RVA: 0x3525804
	public T[] GetBehaviours() { }

	// RVA: 0x16127B4
	internal ScriptableObject[] InternalGetBehaviours(Type type) { }

	// RVA: 0x16128FC
	public StateMachineBehaviour[] GetBehaviours(int fullPathHash, int layerIndex) { }

	// RVA: 0x16129AC
	internal ScriptableObject[] InternalGetBehavioursByKey(int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x1612AF8
	public bool get_stabilizeFeet() { }

	// RVA: 0x1612BE0
	public void set_stabilizeFeet(bool value) { }

	// RVA: 0x1612CF8
	public int get_layerCount() { }

	// RVA: 0x1612DE0
	public string GetLayerName(int layerIndex) { }

	// RVA: 0x1612F84
	public int GetLayerIndex(string layerName) { }

	// RVA: 0x16131C4
	public float GetLayerWeight(int layerIndex) { }

	// RVA: 0x16132DC
	public void SetLayerWeight(int layerIndex, float weight) { }

	// RVA: 0x16133E8
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, AnimatorStateInfo info) { }

	// RVA: 0x1613504
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x16135D4
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	// RVA: 0x16136A4
	private void GetAnimatorTransitionInfo(int layerIndex, AnimatorTransitionInfo info) { }

	// RVA: 0x16137A0
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	// RVA: 0x1613860
	internal int GetAnimatorClipInfoCount(int layerIndex, bool current) { }

	// RVA: 0x161395C
	public int GetCurrentAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x16139FC
	public int GetNextAnimatorClipInfoCount(int layerIndex) { }

	// RVA: 0x1613A9C
	public AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x1613BB4
	public AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex) { }

	// RVA: 0x1613CCC
	public void GetCurrentAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x1613DC0
	private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x1613EDC
	public void GetNextAnimatorClipInfo(int layerIndex, System.Collections.Generic.List<UnityEngine.AnimatorClipInfo> clips) { }

	// RVA: 0x1613FD0
	public bool IsInTransition(int layerIndex) { }

	// RVA: 0x16140E8
	public AnimatorControllerParameter[] get_parameters() { }

	// RVA: 0x16141D0
	public int get_parameterCount() { }

	// RVA: 0x16142B8
	private AnimatorControllerParameter GetParameterInternal(int index) { }

	// RVA: 0x16143D0
	public AnimatorControllerParameter GetParameter(int index) { }

	// RVA: 0x1614500
	public float get_feetPivotActive() { }

	// RVA: 0x16145E8
	public void set_feetPivotActive(float value) { }

	// RVA: 0x1614700
	public float get_pivotWeight() { }

	// RVA: 0x16147E8
	public Vector3 get_pivotPosition() { }

	// RVA: 0x16148FC
	private void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x1614A80
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime) { }

	// RVA: 0x1614B68
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime) { }

	// RVA: 0x1614C50
	public void MatchTarget(Vector3 matchPosition, Quaternion matchRotation, AvatarTarget targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x1614D3C
	public void InterruptMatchTarget() { }

	// RVA: 0x1614DDC
	public void InterruptMatchTarget(bool completeMatch) { }

	// RVA: 0x1614EF4
	public bool get_isMatchingTarget() { }

	// RVA: 0x1614FDC
	public float get_speed() { }

	// RVA: 0x16150C4
	public void set_speed(float value) { }

	// RVA: 0x16151DC
	public void ForceStateNormalizedTime(float normalizedTime) { }

	// RVA: 0x1615334
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration) { }

	// RVA: 0x1615648
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x161570C
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x16157D4
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x16158A8
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset) { }

	// RVA: 0x1615968
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer) { }

	// RVA: 0x1615A24
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration) { }

	// RVA: 0x161557C
	public void CrossFadeInFixedTime(int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x1615B5C
	public void WriteDefaultValues() { }

	// RVA: 0x1615C44
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x1615DE0
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x1615EA8
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	// RVA: 0x1615D0C
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x1615F6C
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x16160B8
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset) { }

	// RVA: 0x1616178
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer) { }

	// RVA: 0x1616238
	public void CrossFade(int stateHashName, float normalizedTransitionDuration) { }

	// RVA: 0x16162F4
	public void PlayInFixedTime(string stateName, int layer) { }

	// RVA: 0x1616464
	public void PlayInFixedTime(string stateName) { }

	// RVA: 0x16163A8
	public void PlayInFixedTime(string stateName, int layer, float fixedTime) { }

	// RVA: 0x1616514
	public void PlayInFixedTime(int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x1616630
	public void PlayInFixedTime(int stateNameHash, int layer) { }

	// RVA: 0x16166DC
	public void PlayInFixedTime(int stateNameHash) { }

	// RVA: 0x1616784
	public void Play(string stateName, int layer) { }

	// RVA: 0x16168F4
	public void Play(string stateName) { }

	// RVA: 0x1616838
	public void Play(string stateName, int layer, float normalizedTime) { }

	// RVA: 0x1615280
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x1616A0C
	public void Play(int stateNameHash, int layer) { }

	// RVA: 0x1616AB8
	public void Play(int stateNameHash) { }

	// RVA: 0x1616B60
	public void SetTarget(AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x1616C6C
	public Vector3 get_targetPosition() { }

	// RVA: 0x1616D80
	public Quaternion get_targetRotation() { }

	// RVA: 0x1616E90
	public bool IsControlled(Transform transform) { }

	// RVA: 0x1616E98
	internal bool IsBoneTransform(Transform transform) { }

	// RVA: 0x1616FE4
	public Transform get_avatarRoot() { }

	// RVA: 0x16170EC
	public Transform GetBoneTransform(HumanBodyBones humanBoneId) { }

	// RVA: 0x16175EC
	internal Transform GetBoneTransformInternal(int humanBoneId) { }

	// RVA: 0x1617714
	public AnimatorCullingMode get_cullingMode() { }

	// RVA: 0x16177FC
	public void set_cullingMode(AnimatorCullingMode value) { }

	// RVA: 0x1617914
	public void StartPlayback() { }

	// RVA: 0x16179FC
	public void StopPlayback() { }

	// RVA: 0x1617AE4
	public float get_playbackTime() { }

	// RVA: 0x1617BCC
	public void set_playbackTime(float value) { }

	// RVA: 0x1617CE4
	public void StartRecording(int frameCount) { }

	// RVA: 0x1617DFC
	public void StopRecording() { }

	// RVA: 0x1617EE4
	public float get_recorderStartTime() { }

	// RVA: 0x1618014
	public void set_recorderStartTime(float value) { }

	// RVA: 0x1617F7C
	private float GetRecorderStartTime() { }

	// RVA: 0x1618068
	public float get_recorderStopTime() { }

	// RVA: 0x1618198
	public void set_recorderStopTime(float value) { }

	// RVA: 0x1618100
	private float GetRecorderStopTime() { }

	// RVA: 0x16181EC
	public AnimatorRecorderMode get_recorderMode() { }

	// RVA: 0x16182D4
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x16183DC
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x1618528
	public bool get_hasBoundPlayables() { }

	// RVA: 0x1618610
	internal void ClearInternalControllerPlayable() { }

	// RVA: 0x16186F8
	public bool HasState(int layerIndex, int stateID) { }

	// RVA: 0x16153F4
	public static int StringToHash(string name) { }

	// RVA: 0x1617404
	public Avatar get_avatar() { }

	// RVA: 0x1618894
	public void set_avatar(Avatar value) { }

	// RVA: 0x16189E0
	internal string GetStats() { }

	// RVA: 0x1618B88
	public PlayableGraph get_playableGraph() { }

	// RVA: 0x1618C2C
	private void GetCurrentGraph(PlayableGraph graph) { }

	// RVA: 0x160FF68
	private void CheckIfInIKPass() { }

	// RVA: 0x1618DDC
	private bool IsInIKPass() { }

	// RVA: 0x160CDA8
	private void SetFloatString(string name, float value) { }

	// RVA: 0x160D210
	private void SetFloatID(int id, float value) { }

	// RVA: 0x160CA80
	private float GetFloatString(string name) { }

	// RVA: 0x160CCF4
	private float GetFloatID(int id) { }

	// RVA: 0x160D784
	private void SetBoolString(string name, bool value) { }

	// RVA: 0x160D9F0
	private void SetBoolID(int id, bool value) { }

	// RVA: 0x160D448
	private bool GetBoolString(string name) { }

	// RVA: 0x160D6D0
	private bool GetBoolID(int id) { }

	// RVA: 0x160DDD4
	private void SetIntegerString(string name, int value) { }

	// RVA: 0x160E040
	private void SetIntegerID(int id, int value) { }

	// RVA: 0x160DA98
	private int GetIntegerString(string name) { }

	// RVA: 0x160DD20
	private int GetIntegerID(int id) { }

	// RVA: 0x160E0E8
	private void SetTriggerString(string name) { }

	// RVA: 0x160E354
	private void SetTriggerID(int id) { }

	// RVA: 0x160E408
	private void ResetTriggerString(string name) { }

	// RVA: 0x160E674
	private void ResetTriggerID(int id) { }

	// RVA: 0x160E728
	private bool IsParameterControlledByCurveString(string name) { }

	// RVA: 0x160E9B0
	private bool IsParameterControlledByCurveID(int id) { }

	// RVA: 0x160CF7C
	private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x160D380
	private void SetFloatIDDamp(int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x16196B4
	public bool get_layersAffectMassCenter() { }

	// RVA: 0x161979C
	public void set_layersAffectMassCenter(bool value) { }

	// RVA: 0x16198B4
	public float get_leftFeetBottomHeight() { }

	// RVA: 0x161999C
	public float get_rightFeetBottomHeight() { }

	// RVA: 0x1619A84
	internal bool get_supportsOnAnimatorMove() { }

	// RVA: 0x1619B6C
	internal void OnUpdateModeChanged() { }

	// RVA: 0x1619C54
	internal void OnCullingModeChanged() { }

	// RVA: 0x1619D3C
	internal void WriteDefaultPose() { }

	// RVA: 0x1619E24
	public void Update(float deltaTime) { }

	// RVA: 0x1619F3C
	public void Rebind() { }

	// RVA: 0x1619FDC
	private void Rebind(bool writeDefaultValues) { }

	// RVA: 0x161A0F4
	public void ApplyBuiltinRootMotion() { }

	// RVA: 0x161A1DC
	internal void EvaluateController() { }

	// RVA: 0x161A27C
	private void EvaluateController(float deltaTime) { }

	// RVA: 0x161A394
	internal string GetCurrentStateName(int layerIndex) { }

	// RVA: 0x161A4F0
	internal string GetNextStateName(int layerIndex) { }

	// RVA: 0x161A39C
	private string GetAnimatorStateName(int layerIndex, bool current) { }

	// RVA: 0x161A560
	internal string ResolveHash(int hash) { }

	// RVA: 0x1618D44
	public bool get_logWarnings() { }

	// RVA: 0x161A754
	public void set_logWarnings(bool value) { }

	// RVA: 0x161A86C
	public bool get_fireEvents() { }

	// RVA: 0x161A954
	public void set_fireEvents(bool value) { }

	// RVA: 0x161AA6C
	public bool get_keepAnimatorControllerStateOnDisable() { }

	// RVA: 0x161AB9C
	public void set_keepAnimatorControllerStateOnDisable(bool value) { }

	// RVA: 0x161AB04
	public bool get_keepAnimatorStateOnDisable() { }

	// RVA: 0x161AC4C
	public void set_keepAnimatorStateOnDisable(bool value) { }

	// RVA: 0x161ADB4
	public bool get_writeDefaultValuesOnDisable() { }

	// RVA: 0x161AE9C
	public void set_writeDefaultValuesOnDisable(bool value) { }

	// RVA: 0x161AFB4
	public Vector3 GetVector(string name) { }

	// RVA: 0x161B004
	public Vector3 GetVector(int id) { }

	// RVA: 0x161B054
	public void SetVector(string name, Vector3 value) { }

	// RVA: 0x161B058
	public void SetVector(int id, Vector3 value) { }

	// RVA: 0x161B05C
	public Quaternion GetQuaternion(string name) { }

	// RVA: 0x161B0AC
	public Quaternion GetQuaternion(int id) { }

	// RVA: 0x161B0FC
	public void SetQuaternion(string name, Quaternion value) { }

	// RVA: 0x161B100
	public void SetQuaternion(int id, Quaternion value) { }

	// RVA: 0x161B104
	public void .ctor() { }

	// RVA: 0x160C5A4
	private static bool get_isOptimizable_Injected(IntPtr _unity_self) { }

	// RVA: 0x160C68C
	private static bool get_isHuman_Injected(IntPtr _unity_self) { }

	// RVA: 0x160C774
	private static bool get_hasRootMotion_Injected(IntPtr _unity_self) { }

	// RVA: 0x160C85C
	private static bool get_isRootPositionOrRotationControlledByCurves_Injected(IntPtr _unity_self) { }

	// RVA: 0x160C944
	private static float get_humanScale_Injected(IntPtr _unity_self) { }

	// RVA: 0x160CA2C
	private static bool get_isInitialized_Injected(IntPtr _unity_self) { }

	// RVA: 0x160EB0C
	private static void get_deltaPosition_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x160EC1C
	private static void get_deltaRotation_Injected(IntPtr _unity_self, Quaternion ret) { }

	// RVA: 0x160ED30
	private static void get_velocity_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x160EE44
	private static void get_angularVelocity_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x160EF58
	private static void get_rootPosition_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x160F064
	private static void set_rootPosition_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x160F174
	private static void get_rootRotation_Injected(IntPtr _unity_self, Quaternion ret) { }

	// RVA: 0x160F280
	private static void set_rootRotation_Injected(IntPtr _unity_self, Quaternion value) { }

	// RVA: 0x160F380
	private static bool get_applyRootMotion_Injected(IntPtr _unity_self) { }

	// RVA: 0x160F480
	private static void set_applyRootMotion_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x160F580
	private static bool get_linearVelocityBlending_Injected(IntPtr _unity_self) { }

	// RVA: 0x160F680
	private static void set_linearVelocityBlending_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x160F780
	private static bool get_animatePhysics_Injected(IntPtr _unity_self) { }

	// RVA: 0x160F880
	private static void set_animatePhysics_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x160F980
	private static AnimatorUpdateMode get_updateMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x160FA80
	private static void set_updateMode_Injected(IntPtr _unity_self, AnimatorUpdateMode value) { }

	// RVA: 0x160FB80
	private static bool get_hasTransformHierarchy_Injected(IntPtr _unity_self) { }

	// RVA: 0x160FC68
	private static bool get_allowConstantClipSamplingOptimization_Injected(IntPtr _unity_self) { }

	// RVA: 0x160FD68
	private static void set_allowConstantClipSamplingOptimization_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x160FE68
	private static float get_gravityWeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x1610318
	private static void get_bodyPositionInternal_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1610380
	private static void set_bodyPositionInternal_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x16106A8
	private static void get_bodyRotationInternal_Injected(IntPtr _unity_self, Quaternion ret) { }

	// RVA: 0x1610710
	private static void set_bodyRotationInternal_Injected(IntPtr _unity_self, Quaternion value) { }

	// RVA: 0x16108F4
	private static void GetGoalPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, Vector3 ret) { }

	// RVA: 0x1610AD4
	private static void SetGoalPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, Vector3 goalPosition) { }

	// RVA: 0x1610CA0
	private static void GetGoalRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal, Quaternion ret) { }

	// RVA: 0x1610E84
	private static void SetGoalRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal, Quaternion goalRotation) { }

	// RVA: 0x1611040
	private static float GetGoalWeightPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal) { }

	// RVA: 0x1611204
	private static void SetGoalWeightPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, float value) { }

	// RVA: 0x16113C8
	private static float GetGoalWeightRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal) { }

	// RVA: 0x161158C
	private static void SetGoalWeightRotation_Injected(IntPtr _unity_self, AvatarIKGoal goal, float value) { }

	// RVA: 0x1611768
	private static void GetHintPosition_Injected(IntPtr _unity_self, AvatarIKHint hint, Vector3 ret) { }

	// RVA: 0x1611948
	private static void SetHintPosition_Injected(IntPtr _unity_self, AvatarIKHint hint, Vector3 hintPosition) { }

	// RVA: 0x1611B04
	private static float GetHintWeightPosition_Injected(IntPtr _unity_self, AvatarIKHint hint) { }

	// RVA: 0x1611CC8
	private static void SetHintWeightPosition_Injected(IntPtr _unity_self, AvatarIKHint hint, float value) { }

	// RVA: 0x1611E90
	private static void SetLookAtPositionInternal_Injected(IntPtr _unity_self, Vector3 lookAtPosition) { }

	// RVA: 0x161237C
	private static void SetLookAtWeightInternal_Injected(IntPtr _unity_self, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x1612604
	private static void SetBoneLocalRotationInternal_Injected(IntPtr _unity_self, int humanBoneId, Quaternion rotation) { }

	// RVA: 0x161274C
	private static IntPtr GetBehaviour_Injected(IntPtr _unity_self, Type type) { }

	// RVA: 0x1612894
	private static ScriptableObject[] InternalGetBehaviours_Injected(IntPtr _unity_self, Type type) { }

	// RVA: 0x1612A90
	private static ScriptableObject[] InternalGetBehavioursByKey_Injected(IntPtr _unity_self, int fullPathHash, int layerIndex, Type type) { }

	// RVA: 0x1612B90
	private static bool get_stabilizeFeet_Injected(IntPtr _unity_self) { }

	// RVA: 0x1612C90
	private static void set_stabilizeFeet_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1612D90
	private static int get_layerCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1612F2C
	private static void GetLayerName_Injected(IntPtr _unity_self, int layerIndex, ManagedSpanWrapper ret) { }

	// RVA: 0x161315C
	private static int GetLayerIndex_Injected(IntPtr _unity_self, ManagedSpanWrapper layerName) { }

	// RVA: 0x1613274
	private static float GetLayerWeight_Injected(IntPtr _unity_self, int layerIndex) { }

	// RVA: 0x1613388
	private static void SetLayerWeight_Injected(IntPtr _unity_self, int layerIndex, float weight) { }

	// RVA: 0x161349C
	private static void GetAnimatorStateInfo_Injected(IntPtr _unity_self, int layerIndex, StateInfoIndex stateInfoIndex, AnimatorStateInfo info) { }

	// RVA: 0x1613748
	private static void GetAnimatorTransitionInfo_Injected(IntPtr _unity_self, int layerIndex, AnimatorTransitionInfo info) { }

	// RVA: 0x1613904
	private static int GetAnimatorClipInfoCount_Injected(IntPtr _unity_self, int layerIndex, bool current) { }

	// RVA: 0x1613B4C
	private static AnimatorClipInfo[] GetCurrentAnimatorClipInfo_Injected(IntPtr _unity_self, int layerIndex) { }

	// RVA: 0x1613C64
	private static AnimatorClipInfo[] GetNextAnimatorClipInfo_Injected(IntPtr _unity_self, int layerIndex) { }

	// RVA: 0x1613E74
	private static void GetAnimatorClipInfoInternal_Injected(IntPtr _unity_self, int layerIndex, bool isCurrent, object clips) { }

	// RVA: 0x1614080
	private static bool IsInTransition_Injected(IntPtr _unity_self, int layerIndex) { }

	// RVA: 0x1614180
	private static AnimatorControllerParameter[] get_parameters_Injected(IntPtr _unity_self) { }

	// RVA: 0x1614268
	private static int get_parameterCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1614368
	private static AnimatorControllerParameter GetParameterInternal_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x1614598
	private static float get_feetPivotActive_Injected(IntPtr _unity_self) { }

	// RVA: 0x1614698
	private static void set_feetPivotActive_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1614798
	private static float get_pivotWeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x1614894
	private static void get_pivotPosition_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x16149E8
	private static void MatchTarget_Injected(IntPtr _unity_self, Vector3 matchPosition, Quaternion matchRotation, int targetBodyPart, MatchTargetWeightMask weightMask, float startNormalizedTime, float targetNormalizedTime, bool completeMatch) { }

	// RVA: 0x1614E8C
	private static void InterruptMatchTarget_Injected(IntPtr _unity_self, bool completeMatch) { }

	// RVA: 0x1614F8C
	private static bool get_isMatchingTarget_Injected(IntPtr _unity_self) { }

	// RVA: 0x1615074
	private static float get_speed_Injected(IntPtr _unity_self) { }

	// RVA: 0x1615174
	private static void set_speed_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1615ADC
	private static void CrossFadeInFixedTime_Injected(IntPtr _unity_self, int stateHashName, float fixedTransitionDuration, int layer, float fixedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x1615BF4
	private static void WriteDefaultValues_Injected(IntPtr _unity_self) { }

	// RVA: 0x1616038
	private static void CrossFade_Injected(IntPtr _unity_self, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	// RVA: 0x16165C8
	private static void PlayInFixedTime_Injected(IntPtr _unity_self, int stateNameHash, int layer, float fixedTime) { }

	// RVA: 0x16169A4
	private static void Play_Injected(IntPtr _unity_self, int stateNameHash, int layer, float normalizedTime) { }

	// RVA: 0x1616C0C
	private static void SetTarget_Injected(IntPtr _unity_self, AvatarTarget targetIndex, float targetNormalizedTime) { }

	// RVA: 0x1616D18
	private static void get_targetPosition_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1616E28
	private static void get_targetRotation_Injected(IntPtr _unity_self, Quaternion ret) { }

	// RVA: 0x1616F7C
	private static bool IsBoneTransform_Injected(IntPtr _unity_self, IntPtr transform) { }

	// RVA: 0x161709C
	private static IntPtr get_avatarRoot_Injected(IntPtr _unity_self) { }

	// RVA: 0x16176AC
	private static IntPtr GetBoneTransformInternal_Injected(IntPtr _unity_self, int humanBoneId) { }

	// RVA: 0x16177AC
	private static AnimatorCullingMode get_cullingMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x16178AC
	private static void set_cullingMode_Injected(IntPtr _unity_self, AnimatorCullingMode value) { }

	// RVA: 0x16179AC
	private static void StartPlayback_Injected(IntPtr _unity_self) { }

	// RVA: 0x1617A94
	private static void StopPlayback_Injected(IntPtr _unity_self) { }

	// RVA: 0x1617B7C
	private static float get_playbackTime_Injected(IntPtr _unity_self) { }

	// RVA: 0x1617C7C
	private static void set_playbackTime_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1617D94
	private static void StartRecording_Injected(IntPtr _unity_self, int frameCount) { }

	// RVA: 0x1617E94
	private static void StopRecording_Injected(IntPtr _unity_self) { }

	// RVA: 0x1618018
	private static float GetRecorderStartTime_Injected(IntPtr _unity_self) { }

	// RVA: 0x161819C
	private static float GetRecorderStopTime_Injected(IntPtr _unity_self) { }

	// RVA: 0x1618284
	private static AnimatorRecorderMode get_recorderMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x161838C
	private static IntPtr get_runtimeAnimatorController_Injected(IntPtr _unity_self) { }

	// RVA: 0x16184C0
	private static void set_runtimeAnimatorController_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x16185C0
	private static bool get_hasBoundPlayables_Injected(IntPtr _unity_self) { }

	// RVA: 0x16186A8
	private static void ClearInternalControllerPlayable_Injected(IntPtr _unity_self) { }

	// RVA: 0x161879C
	private static bool HasState_Injected(IntPtr _unity_self, int layerIndex, int stateID) { }

	// RVA: 0x16187F4
	private static int StringToHash_Injected(ManagedSpanWrapper name) { }

	// RVA: 0x1618844
	private static IntPtr get_avatar_Injected(IntPtr _unity_self) { }

	// RVA: 0x1618978
	private static void set_avatar_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1618B20
	private static void GetStats_Injected(IntPtr _unity_self, ManagedSpanWrapper ret) { }

	// RVA: 0x1618CDC
	private static void GetCurrentGraph_Injected(IntPtr _unity_self, PlayableGraph graph) { }

	// RVA: 0x1618E74
	private static bool IsInIKPass_Injected(IntPtr _unity_self) { }

	// RVA: 0x1618EC4
	private static void SetFloatString_Injected(IntPtr _unity_self, ManagedSpanWrapper name, float value) { }

	// RVA: 0x1618F24
	private static void SetFloatID_Injected(IntPtr _unity_self, int id, float value) { }

	// RVA: 0x1618F84
	private static float GetFloatString_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x1618FEC
	private static float GetFloatID_Injected(IntPtr _unity_self, int id) { }

	// RVA: 0x1619054
	private static void SetBoolString_Injected(IntPtr _unity_self, ManagedSpanWrapper name, bool value) { }

	// RVA: 0x16190AC
	private static void SetBoolID_Injected(IntPtr _unity_self, int id, bool value) { }

	// RVA: 0x1619104
	private static bool GetBoolString_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x161916C
	private static bool GetBoolID_Injected(IntPtr _unity_self, int id) { }

	// RVA: 0x16191D4
	private static void SetIntegerString_Injected(IntPtr _unity_self, ManagedSpanWrapper name, int value) { }

	// RVA: 0x161922C
	private static void SetIntegerID_Injected(IntPtr _unity_self, int id, int value) { }

	// RVA: 0x1619284
	private static int GetIntegerString_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x16192EC
	private static int GetIntegerID_Injected(IntPtr _unity_self, int id) { }

	// RVA: 0x1619354
	private static void SetTriggerString_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x16193BC
	private static void SetTriggerID_Injected(IntPtr _unity_self, int id) { }

	// RVA: 0x1619424
	private static void ResetTriggerString_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x161948C
	private static void ResetTriggerID_Injected(IntPtr _unity_self, int id) { }

	// RVA: 0x16194F4
	private static bool IsParameterControlledByCurveString_Injected(IntPtr _unity_self, ManagedSpanWrapper name) { }

	// RVA: 0x161955C
	private static bool IsParameterControlledByCurveID_Injected(IntPtr _unity_self, int id) { }

	// RVA: 0x16195C4
	private static void SetFloatStringDamp_Injected(IntPtr _unity_self, ManagedSpanWrapper name, float value, float dampTime, float deltaTime) { }

	// RVA: 0x161963C
	private static void SetFloatIDDamp_Injected(IntPtr _unity_self, int id, float value, float dampTime, float deltaTime) { }

	// RVA: 0x161974C
	private static bool get_layersAffectMassCenter_Injected(IntPtr _unity_self) { }

	// RVA: 0x161984C
	private static void set_layersAffectMassCenter_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x161994C
	private static float get_leftFeetBottomHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x1619A34
	private static float get_rightFeetBottomHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x1619B1C
	private static bool get_supportsOnAnimatorMove_Injected(IntPtr _unity_self) { }

	// RVA: 0x1619C04
	private static void OnUpdateModeChanged_Injected(IntPtr _unity_self) { }

	// RVA: 0x1619CEC
	private static void OnCullingModeChanged_Injected(IntPtr _unity_self) { }

	// RVA: 0x1619DD4
	private static void WriteDefaultPose_Injected(IntPtr _unity_self) { }

	// RVA: 0x1619ED4
	private static void Update_Injected(IntPtr _unity_self, float deltaTime) { }

	// RVA: 0x161A08C
	private static void Rebind_Injected(IntPtr _unity_self, bool writeDefaultValues) { }

	// RVA: 0x161A18C
	private static void ApplyBuiltinRootMotion_Injected(IntPtr _unity_self) { }

	// RVA: 0x161A32C
	private static void EvaluateController_Injected(IntPtr _unity_self, float deltaTime) { }

	// RVA: 0x161A4F8
	private static void GetAnimatorStateName_Injected(IntPtr _unity_self, int layerIndex, bool current, ManagedSpanWrapper ret) { }

	// RVA: 0x161A6AC
	private static void ResolveHash_Injected(IntPtr _unity_self, int hash, ManagedSpanWrapper ret) { }

	// RVA: 0x161A704
	private static bool get_logWarnings_Injected(IntPtr _unity_self) { }

	// RVA: 0x161A804
	private static void set_logWarnings_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x161A904
	private static bool get_fireEvents_Injected(IntPtr _unity_self) { }

	// RVA: 0x161AA04
	private static void set_fireEvents_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x161ACFC
	private static bool get_keepAnimatorStateOnDisable_Injected(IntPtr _unity_self) { }

	// RVA: 0x161AD4C
	private static void set_keepAnimatorStateOnDisable_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x161AE4C
	private static bool get_writeDefaultValuesOnDisable_Injected(IntPtr _unity_self) { }

	// RVA: 0x161AF4C
	private static void set_writeDefaultValuesOnDisable_Injected(IntPtr _unity_self, bool value) { }

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

	// RVA: 0x161B10C
	public string get_name() { }

	// RVA: 0x161B114
	public override bool Equals(object o) { }

	// RVA: 0x161B210
	public override int GetHashCode() { }

	// RVA: 0x161B234
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

	// RVA: 0x161B298
	public void .ctor() { }

}

// Namespace: 
internal sealed class OnOverrideControllerDirtyCallback
{
	// Methods

	// RVA: 0x161CEB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x161CF50
	public virtual void Invoke() { }

}

// Namespace: UnityEngine
public class AnimatorOverrideController
{
	// Fields
	internal OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Methods

	// RVA: 0x161B2A0
	public void .ctor() { }

	// RVA: 0x161B4D8
	public void .ctor(RuntimeAnimatorController controller) { }

	// RVA: 0x161B41C
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	// RVA: 0x161B638
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	// RVA: 0x161B740
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x161B88C
	public AnimationClip get_Item(string name) { }

	// RVA: 0x161BAD0
	public void set_Item(string name, AnimationClip value) { }

	// RVA: 0x161B894
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	// RVA: 0x161BAD4
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	// RVA: 0x161BD80
	public AnimationClip get_Item(AnimationClip clip) { }

	// RVA: 0x161BE80
	public void set_Item(AnimationClip clip, AnimationClip value) { }

	// RVA: 0x161BD88
	private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	// RVA: 0x161BE88
	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

	// RVA: 0x161C044
	private void SendNotification() { }

	// RVA: 0x161C12C
	private AnimationClip GetOriginalClip(int index) { }

	// RVA: 0x161C254
	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	// RVA: 0x161C3A4
	public int get_overridesCount() { }

	// RVA: 0x161C48C
	public void GetOverrides(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x161C6E4
	public void ApplyOverrides(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<UnityEngine.AnimationClip,UnityEngine.AnimationClip>> overrides) { }

	// RVA: 0x161CAA4
	public AnimationClipPair[] get_clips() { }

	// RVA: 0x161CCAC
	public void set_clips(AnimationClipPair[] value) { }

	// RVA: 0x161CD94
	internal void PerformOverrideClipListCleanup() { }

	// RVA: 0x161CE7C
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }

	// RVA: 0x161B5D0
	private static void Internal_Create_Injected(AnimatorOverrideController self, IntPtr controller) { }

	// RVA: 0x161B6F0
	private static IntPtr get_runtimeAnimatorController_Injected(IntPtr _unity_self) { }

	// RVA: 0x161B824
	private static void set_runtimeAnimatorController_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x161BCD0
	private static IntPtr Internal_GetClipByName_Injected(IntPtr _unity_self, ManagedSpanWrapper name, bool returnEffectiveClip) { }

	// RVA: 0x161BD28
	private static void Internal_SetClipByName_Injected(IntPtr _unity_self, ManagedSpanWrapper name, IntPtr clip) { }

	// RVA: 0x161BF84
	private static IntPtr GetClip_Injected(IntPtr _unity_self, IntPtr originalClip, bool returnEffectiveClip) { }

	// RVA: 0x161BFDC
	private static void SetClip_Injected(IntPtr _unity_self, IntPtr originalClip, IntPtr overrideClip, bool notify) { }

	// RVA: 0x161C0DC
	private static void SendNotification_Injected(IntPtr _unity_self) { }

	// RVA: 0x161C1EC
	private static IntPtr GetOriginalClip_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x161C33C
	private static IntPtr GetOverrideClip_Injected(IntPtr _unity_self, IntPtr originalClip) { }

	// RVA: 0x161C43C
	private static int get_overridesCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x161CE2C
	private static void PerformOverrideClipListCleanup_Injected(IntPtr _unity_self) { }

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

	// RVA: 0x16174BC
	public bool get_isValid() { }

	// RVA: 0x1617554
	public bool get_isHuman() { }

	// RVA: 0x161CF64
	private static bool get_isValid_Injected(IntPtr _unity_self) { }

	// RVA: 0x161CFB4
	private static bool get_isHuman_Injected(IntPtr _unity_self) { }

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

	// RVA: 0x1612500
	internal static int GetBoneIndexFromMono(int humanId) { }

}

// Namespace: UnityEngine
public class Motion
{
	// Fields
	private readonly bool <isAnimatorMotion>k__BackingField; // 0x18

	// Methods

	// RVA: 0x160C32C
	protected void .ctor() { }

}

// Namespace: UnityEngine
public class RuntimeAnimatorController
{
	// Methods

	// RVA: 0x161B394
	protected void .ctor() { }

	// RVA: 0x161D004
	public AnimationClip[] get_animationClips() { }

	// RVA: 0x161D09C
	private static AnimationClip[] get_animationClips_Injected(IntPtr _unity_self) { }

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

	// RVA: 0x161D0EC
	public PlayableHandle GetHandle() { }

	// RVA: 0x161D0F8
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

	// RVA: 0x161D17C
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization) { }

	// RVA: 0x161D364
	public PlayableHandle GetHandle() { }

	// RVA: 0x161D370
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x161D2FC
	private static void SetSingleLayerOptimizationInternal(PlayableHandle handle, bool value) { }

	// RVA: 0x161D440
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x161D4E4
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x161D600
	public PlayableHandle GetHandle() { }

	// RVA: 0x161D60C
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x161D6DC
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationMotionXToDeltaPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x161D77C
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x161D898
	public PlayableHandle GetHandle() { }

	// RVA: 0x161D8A4
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x161D974
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationOffsetPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x161DA14
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x161DB30
	public PlayableHandle GetHandle() { }

	// RVA: 0x161DB3C
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x161DBF8
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

	// RVA: 0x161DC98
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x161DDB4
	public PlayableHandle GetHandle() { }

	// RVA: 0x161DDC0
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x161DE7C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
internal struct AnimationRemoveScalePlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x161DF1C
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x161E038
	public PlayableHandle GetHandle() { }

	// RVA: 0x161E044
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x161E100
	private static void .cctor() { }

}

// Namespace: UnityEngine.Animations
public struct AnimationScriptPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x161E1A0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x161E2BC
	public PlayableHandle GetHandle() { }

	// RVA: 0x161E2C8
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x161E398
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

	// RVA: 0x161E438
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x161E6A4
	public PlayableHandle GetHandle() { }

	// RVA: 0x161E510
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x161E6B0
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x161E780
	private static void .cctor() { }

}


