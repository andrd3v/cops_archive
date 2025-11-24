// Namespace: 
internal class <Module>
{}

// Namespace: 
public struct MainModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BB48
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x17158D4
	public float get_duration() { }

	// RVA: 0x17155A4
	public bool get_loop() { }

	// RVA: 0x171565C
	public void set_loop(bool value) { }

	// RVA: 0x171BFA4
	public void set_startDelay(MinMaxCurve value) { }

	// RVA: 0x171C040
	private void set_startDelayBlittable(MinMaxCurveBlittable value) { }

	// RVA: 0x1715404
	public float get_startDelayMultiplier() { }

	// RVA: 0x17154C4
	public void set_startDelayMultiplier(float value) { }

	// RVA: 0x1716C04
	public float get_startLifetimeMultiplier() { }

	// RVA: 0x1716CC4
	public void set_startLifetimeMultiplier(float value) { }

	// RVA: 0x1715F70
	public float get_startSpeedMultiplier() { }

	// RVA: 0x1716030
	public void set_startSpeedMultiplier(float value) { }

	// RVA: 0x1716110
	public float get_startSizeMultiplier() { }

	// RVA: 0x17161D0
	public void set_startSizeMultiplier(float value) { }

	// RVA: 0x1716630
	public float get_startRotationMultiplier() { }

	// RVA: 0x17166F0
	public void set_startRotationMultiplier(float value) { }

	// RVA: 0x1716858
	public float get_startRotationXMultiplier() { }

	// RVA: 0x1716A54
	public void set_startRotationXMultiplier(float value) { }

	// RVA: 0x17168A8
	public float get_startRotationYMultiplier() { }

	// RVA: 0x1716ABC
	public void set_startRotationYMultiplier(float value) { }

	// RVA: 0x17168F8
	public float get_startRotationZMultiplier() { }

	// RVA: 0x1716B24
	public void set_startRotationZMultiplier(float value) { }

	// RVA: 0x17162D8
	public MinMaxGradient get_startColor() { }

	// RVA: 0x1716534
	public void set_startColor(MinMaxGradient value) { }

	// RVA: 0x171C110
	private MinMaxGradientBlittable get_startColorBlittable() { }

	// RVA: 0x171C220
	private void set_startColorBlittable(MinMaxGradientBlittable value) { }

	// RVA: 0x1716DA4
	public float get_gravityModifierMultiplier() { }

	// RVA: 0x1716E64
	public void set_gravityModifierMultiplier(float value) { }

	// RVA: 0x17170DC
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	// RVA: 0x1717194
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x171C358
	public void set_customSimulationSpace(Transform value) { }

	// RVA: 0x171599C
	public float get_simulationSpeed() { }

	// RVA: 0x1715A5C
	public void set_simulationSpeed(float value) { }

	// RVA: 0x1717274
	public ParticleSystemScalingMode get_scalingMode() { }

	// RVA: 0x171732C
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x171573C
	public bool get_playOnAwake() { }

	// RVA: 0x17157F4
	public void set_playOnAwake(bool value) { }

	// RVA: 0x1716F44
	public int get_maxParticles() { }

	// RVA: 0x1716FFC
	public void set_maxParticles(int value) { }

	// RVA: 0x171C47C
	public void set_cullingMode(ParticleSystemCullingMode value) { }

	// RVA: 0x171C0A8
	private static void set_startDelayBlittable_Injected(MainModule _unity_self, MinMaxCurveBlittable value) { }

	// RVA: 0x171C288
	private static void get_startColorBlittable_Injected(MainModule _unity_self, MinMaxGradientBlittable ret) { }

	// RVA: 0x171C2F0
	private static void set_startColorBlittable_Injected(MainModule _unity_self, MinMaxGradientBlittable value) { }

	// RVA: 0x171C414
	private static void set_customSimulationSpace_Injected(MainModule _unity_self, IntPtr value) { }

}

// Namespace: 
public struct EmissionModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BB50
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x1715B68
	public bool get_enabled() { }

	// RVA: 0x1715C20
	public void set_enabled(bool value) { }

	// RVA: 0x171C4E4
	public MinMaxCurve get_rateOverTime() { }

	// RVA: 0x1715E84
	public void set_rateOverTime(MinMaxCurve value) { }

	// RVA: 0x171C564
	private MinMaxCurveBlittable get_rateOverTimeBlittable() { }

	// RVA: 0x171C604
	private void set_rateOverTimeBlittable(MinMaxCurveBlittable value) { }

	// RVA: 0x1715D00
	public float get_rateOverTimeMultiplier() { }

	// RVA: 0x171C73C
	public int GetBursts(Burst[] bursts) { }

	// RVA: 0x171C910
	public Burst GetBurst(int index) { }

	// RVA: 0x171C8C0
	public int get_burstCount() { }

	// RVA: 0x171C66C
	private static void get_rateOverTimeBlittable_Injected(EmissionModule _unity_self, MinMaxCurveBlittable ret) { }

	// RVA: 0x171C6D4
	private static void set_rateOverTimeBlittable_Injected(EmissionModule _unity_self, MinMaxCurveBlittable value) { }

	// RVA: 0x171C99C
	private static void GetBurst_Injected(EmissionModule _unity_self, int index, Burst ret) { }

}

// Namespace: 
public struct ShapeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BB84
	internal void .ctor(ParticleSystem particleSystem) { }

	// RVA: 0x171C9F4
	public ParticleSystemShapeType get_shapeType() { }

	// RVA: 0x171CA44
	public MeshRenderer get_meshRenderer() { }

	// RVA: 0x171CB0C
	public void set_meshRenderer(MeshRenderer value) { }

	// RVA: 0x171CC30
	public Vector3 get_position() { }

	// RVA: 0x171CCF8
	public Vector3 get_scale() { }

	// RVA: 0x171CABC
	private static IntPtr get_meshRenderer_Injected(ShapeModule _unity_self) { }

	// RVA: 0x171CBC8
	private static void set_meshRenderer_Injected(ShapeModule _unity_self, IntPtr value) { }

	// RVA: 0x171CC90
	private static void get_position_Injected(ShapeModule _unity_self, Vector3 ret) { }

	// RVA: 0x171CD58
	private static void get_scale_Injected(ShapeModule _unity_self, Vector3 ret) { }

}

// Namespace: 
public struct CollisionModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BE5C
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct TriggerModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BE90
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct SubEmittersModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BEC4
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct TextureSheetAnimationModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BEF8
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct Particle
{
	// Fields
	private Vector3 m_Position; // 0x10
	private Vector3 m_Velocity; // 0x1C
	private Vector3 m_AnimatedVelocity; // 0x28
	private Vector3 m_InitialVelocity; // 0x34
	private Vector3 m_AxisOfRotation; // 0x40
	private Vector3 m_Rotation; // 0x4C
	private Vector3 m_AngularVelocity; // 0x58
	private Vector3 m_StartSize; // 0x64
	private Color32 m_StartColor; // 0x70
	private UInt32 m_RandomSeed; // 0x74
	private UInt32 m_ParentRandomSeed; // 0x78
	private float m_Lifetime; // 0x7C
	private float m_StartLifetime; // 0x80
	private int m_MeshIndex; // 0x84
	private float m_EmitAccumulator0; // 0x88
	private float m_EmitAccumulator1; // 0x8C
	private UInt32 m_Flags; // 0x90

	// Methods

	// RVA: 0x1715174
	public void set_lifetime(float value) { }

	// RVA: 0x171CDC8
	public Vector3 get_position() { }

	// RVA: 0x171515C
	public void set_position(Vector3 value) { }

	// RVA: 0x1715168
	public void set_velocity(Vector3 value) { }

	// RVA: 0x171CDC0
	public void set_remainingLifetime(float value) { }

	// RVA: 0x171517C
	public void set_startLifetime(float value) { }

	// RVA: 0x17151F0
	public void set_startColor(Color32 value) { }

	// RVA: 0x17151F8
	public void set_randomSeed(UInt32 value) { }

	// RVA: 0x1715184
	public void set_startSize(float value) { }

	// RVA: 0x1715190
	public void set_rotation3D(Vector3 value) { }

	// RVA: 0x17151C0
	public void set_angularVelocity3D(Vector3 value) { }

}

// Namespace: 
public struct Burst
{
	// Fields
	private float m_Time; // 0x10
	private MinMaxCurveBlittable m_Count; // 0x18
	private int m_RepeatCount; // 0x38
	private float m_RepeatInterval; // 0x3C
	private float m_InvProbability; // 0x40

	// Methods

	// RVA: 0x171CDD4
	public float get_time() { }

	// RVA: 0x171CDDC
	public MinMaxCurve get_count() { }

}

// Namespace: 
[Serializable]
public struct MinMaxCurve
{
	// Fields
	internal ParticleSystemCurveMode m_Mode; // 0x10
	internal float m_CurveMultiplier; // 0x14
	internal AnimationCurve m_CurveMin; // 0x18
	internal AnimationCurve m_CurveMax; // 0x20
	internal float m_ConstantMin; // 0x28
	internal float m_ConstantMax; // 0x2C

	// Methods

	// RVA: 0x171CF0C
	public void .ctor(float constant) { }

	// RVA: 0x171CF5C
	public float get_constant() { }

	// RVA: 0x1715E18
	public static MinMaxCurve op_Implicit(float constant) { }

}

// Namespace: 
[Serializable]
internal struct MinMaxCurveBlittable
{
	// Fields
	private ParticleSystemCurveMode m_Mode; // 0x10
	private float m_CurveMultiplier; // 0x14
	private IntPtr m_CurveMin; // 0x18
	private IntPtr m_CurveMax; // 0x20
	internal float m_ConstantMin; // 0x28
	internal float m_ConstantMax; // 0x2C

	// Methods

	// RVA: 0x171C5D0
	public static MinMaxCurve op_Implicit(MinMaxCurveBlittable minMaxCurveBlittable) { }

	// RVA: 0x171C018
	public static MinMaxCurveBlittable op_Implicit(MinMaxCurve minMaxCurve) { }

	// RVA: 0x171CF64
	internal static MinMaxCurveBlittable FromMixMaxCurve(MinMaxCurve minMaxCurve) { }

	// RVA: 0x171CE14
	internal static MinMaxCurve ToMinMaxCurve(MinMaxCurveBlittable minMaxCurveBlittable) { }

}

// Namespace: 
[Serializable]
public struct MinMaxGradient
{
	// Fields
	internal ParticleSystemGradientMode m_Mode; // 0x10
	internal Gradient m_GradientMin; // 0x18
	internal Gradient m_GradientMax; // 0x20
	internal Color m_ColorMin; // 0x28
	internal Color m_ColorMax; // 0x38

	// Methods

	// RVA: 0x171CF8C
	public void .ctor(Color color) { }

	// RVA: 0x1716380
	public Color get_color() { }

	// RVA: 0x1716490
	public static MinMaxGradient op_Implicit(Color color) { }

}

// Namespace: 
[Serializable]
internal struct MinMaxGradientBlittable
{
	// Fields
	private ParticleSystemGradientMode m_Mode; // 0x10
	private IntPtr m_GradientMin; // 0x18
	private IntPtr m_GradientMax; // 0x20
	private Color m_ColorMin; // 0x28
	private Color m_ColorMax; // 0x38

	// Methods

	// RVA: 0x171C194
	public static MinMaxGradient op_Implicit(MinMaxGradientBlittable minMaxGradientBlittable) { }

	// RVA: 0x171C1DC
	public static MinMaxGradientBlittable op_Implicit(MinMaxGradient minMaxGradient) { }

	// RVA: 0x171D104
	internal static MinMaxGradientBlittable FromMixMaxGradient(MinMaxGradient minMaxGradient) { }

	// RVA: 0x171CFFC
	internal static MinMaxGradient ToMinMaxGradient(MinMaxGradientBlittable minMaxGradientBlittable) { }

}

// Namespace: 
public struct EmitParams
{
	// Fields
	private Particle m_Particle; // 0x10
	private bool m_PositionSet; // 0x94
	private bool m_VelocitySet; // 0x95
	private bool m_AxisOfRotationSet; // 0x96
	private bool m_RotationSet; // 0x97
	private bool m_AngularVelocitySet; // 0x98
	private bool m_StartSizeSet; // 0x99
	private bool m_StartColorSet; // 0x9A
	private bool m_RandomSeedSet; // 0x9B
	private bool m_StartLifetimeSet; // 0x9C
	private bool m_MeshIndexSet; // 0x9D
	private bool m_ApplyShapeToPosition; // 0x9E

	// Methods

	// RVA: 0x171D148
	public Vector3 get_position() { }

	// RVA: 0x171D154
	public void set_position(Vector3 value) { }

	// RVA: 0x171D168
	public void set_velocity(Vector3 value) { }

	// RVA: 0x171D17C
	public void set_startLifetime(float value) { }

	// RVA: 0x171D18C
	public void set_startSize(float value) { }

	// RVA: 0x171D1A0
	public void set_startColor(Color32 value) { }

	// RVA: 0x171D1B0
	public void set_randomSeed(UInt32 value) { }

}

// Namespace: 
internal struct Seed
{
	// Fields
	public UInt32 x; // 0x10
	public UInt32 y; // 0x14
	public UInt32 z; // 0x18
	public UInt32 w; // 0x1C
}

// Namespace: 
internal struct Seed4
{
	// Fields
	public Seed x; // 0x10
	public Seed y; // 0x20
	public Seed z; // 0x30
	public Seed w; // 0x40
}

// Namespace: 
internal struct Emission
{
	// Fields
	public float m_ParticleSpacing; // 0x10
	public float m_ToEmitAccumulator; // 0x14
	public Seed m_Random; // 0x18
}

// Namespace: 
internal struct Initial
{
	// Fields
	public Seed4 m_Random; // 0x10
}

// Namespace: 
internal struct Shape
{
	// Fields
	public Seed4 m_Random; // 0x10
	public float m_RadiusTimer; // 0x50
	public float m_RadiusTimerPrev; // 0x54
	public float m_ArcTimer; // 0x58
	public float m_ArcTimerPrev; // 0x5C
	public float m_MeshSpawnTimer; // 0x60
	public float m_MeshSpawnTimerPrev; // 0x64
	public int m_OrderedMeshVertexIndex; // 0x68
}

// Namespace: 
internal struct Force
{
	// Fields
	public Seed4 m_Random; // 0x10
}

// Namespace: 
internal struct Collision
{
	// Fields
	public Seed4 m_Random; // 0x10
}

// Namespace: 
internal struct Noise
{
	// Fields
	public float m_ScrollOffset; // 0x10
}

// Namespace: 
internal struct Lights
{
	// Fields
	public Seed m_Random; // 0x10
	public float m_ParticleEmissionCounter; // 0x20
}

// Namespace: 
internal struct Trail
{
	// Fields
	public float m_Timer; // 0x10
}

// Namespace: 
public struct PlaybackState
{
	// Fields
	internal float m_AccumulatedDt; // 0x10
	internal float m_StartDelay; // 0x14
	internal float m_PlaybackTime; // 0x18
	internal int m_RingBufferIndex; // 0x1C
	internal Emission m_Emission; // 0x20
	internal Initial m_Initial; // 0x38
	internal Shape m_Shape; // 0x78
	internal Force m_Force; // 0xD4
	internal Collision m_Collision; // 0x114
	internal Noise m_Noise; // 0x154
	internal Lights m_Lights; // 0x158
	internal Trail m_Trail; // 0x16C
}

// Namespace: 
public struct Trails
{
	// Fields
	internal System.Collections.Generic.List<UnityEngine.Vector4> positions; // 0x10
	internal System.Collections.Generic.List<System.Int32> frontPositions; // 0x18
	internal System.Collections.Generic.List<System.Int32> backPositions; // 0x20
	internal System.Collections.Generic.List<System.Int32> positionCounts; // 0x28
	internal System.Collections.Generic.List<System.Single> textureOffsets; // 0x30
	internal int maxTrailCount; // 0x38
	internal int maxPositionsPerTrailCount; // 0x3C

	// Methods

	// RVA: 0x171971C
	internal void Allocate() { }

}

// Namespace: 
public struct VelocityOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BBB8
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct LimitVelocityOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BBEC
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct InheritVelocityModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BC20
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct LifetimeByEmitterSpeedModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BC54
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct ForceOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BC88
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct ColorOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BCBC
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct ColorBySpeedModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BCF0
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct SizeOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BD24
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct SizeBySpeedModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BD58
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct RotationOverLifetimeModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BD8C
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct RotationBySpeedModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BDC0
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct ExternalForcesModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BDF4
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct NoiseModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BE28
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct LightsModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BF2C
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct TrailModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BF60
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: 
public struct CustomDataModule
{
	// Fields
	internal ParticleSystem m_ParticleSystem; // 0x10

	// Methods

	// RVA: 0x171BF94
	internal void .ctor(ParticleSystem particleSystem) { }

}

// Namespace: UnityEngine
public sealed class ParticleSystem
{
	// Methods

	// RVA: 0x171500C
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	// RVA: 0x17152B0
	public void Emit(Particle particle) { }

	// RVA: 0x1715360
	public float get_startDelay() { }

	// RVA: 0x1715454
	public void set_startDelay(float value) { }

	// RVA: 0x171552C
	public bool get_loop() { }

	// RVA: 0x17155F4
	public void set_loop(bool value) { }

	// RVA: 0x17156C4
	public bool get_playOnAwake() { }

	// RVA: 0x171578C
	public void set_playOnAwake(bool value) { }

	// RVA: 0x171585C
	public float get_duration() { }

	// RVA: 0x1715924
	public float get_playbackSpeed() { }

	// RVA: 0x17159EC
	public void set_playbackSpeed(float value) { }

	// RVA: 0x1715AC4
	public bool get_enableEmission() { }

	// RVA: 0x1715BB8
	public void set_enableEmission(bool value) { }

	// RVA: 0x1715C88
	public float get_emissionRate() { }

	// RVA: 0x1715D50
	public void set_emissionRate(float value) { }

	// RVA: 0x1715EF8
	public float get_startSpeed() { }

	// RVA: 0x1715FC0
	public void set_startSpeed(float value) { }

	// RVA: 0x1716098
	public float get_startSize() { }

	// RVA: 0x1716160
	public void set_startSize(float value) { }

	// RVA: 0x1716238
	public Color get_startColor() { }

	// RVA: 0x171638C
	public void set_startColor(Color value) { }

	// RVA: 0x17165B8
	public float get_startRotation() { }

	// RVA: 0x1716680
	public void set_startRotation(float value) { }

	// RVA: 0x1716758
	public Vector3 get_startRotation3D() { }

	// RVA: 0x1716948
	public void set_startRotation3D(Vector3 value) { }

	// RVA: 0x1716B8C
	public float get_startLifetime() { }

	// RVA: 0x1716C54
	public void set_startLifetime(float value) { }

	// RVA: 0x1716D2C
	public float get_gravityModifier() { }

	// RVA: 0x1716DF4
	public void set_gravityModifier(float value) { }

	// RVA: 0x1716ECC
	public int get_maxParticles() { }

	// RVA: 0x1716F94
	public void set_maxParticles(int value) { }

	// RVA: 0x1717064
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	// RVA: 0x171712C
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	// RVA: 0x17171FC
	public ParticleSystemScalingMode get_scalingMode() { }

	// RVA: 0x17172C4
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	// RVA: 0x1717394
	public bool get_automaticCullingEnabled() { }

	// RVA: 0x17174C4
	public bool get_isPlaying() { }

	// RVA: 0x17175AC
	public bool get_isEmitting() { }

	// RVA: 0x1717694
	public bool get_isStopped() { }

	// RVA: 0x171777C
	public bool get_isPaused() { }

	// RVA: 0x1717864
	public int get_particleCount() { }

	// RVA: 0x171794C
	public float get_time() { }

	// RVA: 0x1717A34
	public void set_time(float value) { }

	// RVA: 0x1717B4C
	public float get_totalTime() { }

	// RVA: 0x1717C34
	public UInt32 get_randomSeed() { }

	// RVA: 0x1717D1C
	public void set_randomSeed(UInt32 value) { }

	// RVA: 0x1717E34
	public bool get_useAutoRandomSeed() { }

	// RVA: 0x1717F1C
	public void set_useAutoRandomSeed(bool value) { }

	// RVA: 0x171742C
	public bool get_proceduralSimulationSupported() { }

	// RVA: 0x1718084
	internal float GetParticleCurrentSize(Particle particle) { }

	// RVA: 0x171819C
	internal Vector3 GetParticleCurrentSize3D(Particle particle) { }

	// RVA: 0x17182B0
	internal Color32 GetParticleCurrentColor(Particle particle) { }

	// RVA: 0x17183BC
	internal int GetParticleMeshIndex(Particle particle) { }

	// RVA: 0x17184D4
	public void SetParticles(Particle[] particles, int size, int offset) { }

	// RVA: 0x17186AC
	public void SetParticles(Particle[] particles, int size) { }

	// RVA: 0x17186B4
	public void SetParticles(Particle[] particles) { }

	// RVA: 0x17186C0
	private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x17187EC
	public void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x17188F4
	public void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x17188FC
	public void SetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles) { }

	// RVA: 0x1718908
	public int GetParticles(Particle[] particles, int size, int offset) { }

	// RVA: 0x1718B20
	public int GetParticles(Particle[] particles, int size) { }

	// RVA: 0x1718B28
	public int GetParticles(Particle[] particles) { }

	// RVA: 0x1718B34
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x1718C60
	public int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size, int offset) { }

	// RVA: 0x1718D68
	public int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles, int size) { }

	// RVA: 0x1718D70
	public int GetParticles(Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> particles) { }

	// RVA: 0x1718D7C
	public void SetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0x1719020
	public int GetCustomParticleData(System.Collections.Generic.List<UnityEngine.Vector4> customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0x17192D0
	public PlaybackState GetPlaybackState() { }

	// RVA: 0x1719420
	public void SetPlaybackState(PlaybackState playbackState) { }

	// RVA: 0x1719538
	private void GetTrailDataInternal(Trails trailData) { }

	// RVA: 0x1719650
	public Trails GetTrails() { }

	// RVA: 0x1719914
	public int GetTrails(Trails trailData) { }

	// RVA: 0x1719A14
	public void SetTrails(Trails trailData) { }

	// RVA: 0x1719B2C
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x1719C68
	public void Simulate(float t, bool withChildren, bool restart) { }

	// RVA: 0x1719D20
	public void Simulate(float t, bool withChildren) { }

	// RVA: 0x1719DD4
	public void Simulate(float t) { }

	// RVA: 0x1719E7C
	public void Play(bool withChildren) { }

	// RVA: 0x1719F94
	public void Play() { }

	// RVA: 0x171A034
	public void Pause(bool withChildren) { }

	// RVA: 0x171A14C
	public void Pause() { }

	// RVA: 0x171A1EC
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x171A2E8
	public void Stop(bool withChildren) { }

	// RVA: 0x171A388
	public void Stop() { }

	// RVA: 0x171A430
	public void Clear(bool withChildren) { }

	// RVA: 0x171A548
	public void Clear() { }

	// RVA: 0x171A5E8
	public bool IsAlive(bool withChildren) { }

	// RVA: 0x171A700
	public bool IsAlive() { }

	// RVA: 0x171A7A0
	public void Emit(int count) { }

	// RVA: 0x171A850
	private void Emit_Internal(int count) { }

	// RVA: 0x171A968
	public void Emit(EmitParams emitParams, int count) { }

	// RVA: 0x1715200
	private void EmitOld_Internal(Particle particle) { }

	// RVA: 0x171AACC
	public void TriggerSubEmitter(int subEmitterIndex) { }

	// RVA: 0x171AC2C
	public void TriggerSubEmitter(int subEmitterIndex, Particle particle) { }

	// RVA: 0x171ADA4
	public void TriggerSubEmitter(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles) { }

	// RVA: 0x171AD00
	internal void TriggerSubEmitterForParticle(int subEmitterIndex, Particle particle) { }

	// RVA: 0x171AE70
	private void TriggerSubEmitterForParticles(int subEmitterIndex, System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> particles) { }

	// RVA: 0x171AB7C
	private void TriggerSubEmitterForAllParticles(int subEmitterIndex) { }

	// RVA: 0x171B184
	public static void ResetPreMappedBufferMemory() { }

	// RVA: 0x171B1C4
	public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) { }

	// RVA: 0x171B22C
	public void AllocateAxisOfRotationAttribute() { }

	// RVA: 0x171B314
	public void AllocateMeshIndexAttribute() { }

	// RVA: 0x171B3FC
	public void AllocateCustomDataAttribute(ParticleSystemCustomData stream) { }

	// RVA: 0x171B514
	public bool get_has3DParticleRotations() { }

	// RVA: 0x171B5FC
	public bool get_hasNonUniformParticleSizes() { }

	// RVA: 0x171B6E4
	internal Void* GetManagedJobData() { }

	// RVA: 0x171B7CC
	internal JobHandle GetManagedJobHandle() { }

	// RVA: 0x171B8D8
	internal void SetManagedJobHandle(JobHandle handle) { }

	// RVA: 0x171B9E0
	internal static JobHandle ScheduleManagedJob(JobScheduleParameters parameters, Void* additionalData) { }

	// RVA: 0x171BAA0
	internal static void CopyManagedJobData(Void* systemPtr, NativeParticleData particleData) { }

	// RVA: 0x171BB08
	internal static bool UserJobCanBeScheduled() { }

	// RVA: 0x17153D8
	public MainModule get_main() { }

	// RVA: 0x1715B3C
	public EmissionModule get_emission() { }

	// RVA: 0x171BB58
	public ShapeModule get_shape() { }

	// RVA: 0x171BB8C
	public VelocityOverLifetimeModule get_velocityOverLifetime() { }

	// RVA: 0x171BBC0
	public LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	// RVA: 0x171BBF4
	public InheritVelocityModule get_inheritVelocity() { }

	// RVA: 0x171BC28
	public LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed() { }

	// RVA: 0x171BC5C
	public ForceOverLifetimeModule get_forceOverLifetime() { }

	// RVA: 0x171BC90
	public ColorOverLifetimeModule get_colorOverLifetime() { }

	// RVA: 0x171BCC4
	public ColorBySpeedModule get_colorBySpeed() { }

	// RVA: 0x171BCF8
	public SizeOverLifetimeModule get_sizeOverLifetime() { }

	// RVA: 0x171BD2C
	public SizeBySpeedModule get_sizeBySpeed() { }

	// RVA: 0x171BD60
	public RotationOverLifetimeModule get_rotationOverLifetime() { }

	// RVA: 0x171BD94
	public RotationBySpeedModule get_rotationBySpeed() { }

	// RVA: 0x171BDC8
	public ExternalForcesModule get_externalForces() { }

	// RVA: 0x171BDFC
	public NoiseModule get_noise() { }

	// RVA: 0x171BE30
	public CollisionModule get_collision() { }

	// RVA: 0x171BE64
	public TriggerModule get_trigger() { }

	// RVA: 0x171BE98
	public SubEmittersModule get_subEmitters() { }

	// RVA: 0x171BECC
	public TextureSheetAnimationModule get_textureSheetAnimation() { }

	// RVA: 0x171BF00
	public LightsModule get_lights() { }

	// RVA: 0x171BF34
	public TrailModule get_trails() { }

	// RVA: 0x171BF68
	public CustomDataModule get_customData() { }

	// RVA: 0x171BF9C
	public void .ctor() { }

	// RVA: 0x171755C
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	// RVA: 0x1717644
	private static bool get_isEmitting_Injected(IntPtr _unity_self) { }

	// RVA: 0x171772C
	private static bool get_isStopped_Injected(IntPtr _unity_self) { }

	// RVA: 0x1717814
	private static bool get_isPaused_Injected(IntPtr _unity_self) { }

	// RVA: 0x17178FC
	private static int get_particleCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x17179E4
	private static float get_time_Injected(IntPtr _unity_self) { }

	// RVA: 0x1717AE4
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1717BE4
	private static float get_totalTime_Injected(IntPtr _unity_self) { }

	// RVA: 0x1717CCC
	private static UInt32 get_randomSeed_Injected(IntPtr _unity_self) { }

	// RVA: 0x1717DCC
	private static void set_randomSeed_Injected(IntPtr _unity_self, UInt32 value) { }

	// RVA: 0x1717ECC
	private static bool get_useAutoRandomSeed_Injected(IntPtr _unity_self) { }

	// RVA: 0x1717FCC
	private static void set_useAutoRandomSeed_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1718034
	private static bool get_proceduralSimulationSupported_Injected(IntPtr _unity_self) { }

	// RVA: 0x1718134
	private static float GetParticleCurrentSize_Injected(IntPtr _unity_self, Particle particle) { }

	// RVA: 0x1718258
	private static void GetParticleCurrentSize3D_Injected(IntPtr _unity_self, Particle particle, Vector3 ret) { }

	// RVA: 0x1718364
	private static void GetParticleCurrentColor_Injected(IntPtr _unity_self, Particle particle, Color32 ret) { }

	// RVA: 0x171846C
	private static int GetParticleMeshIndex_Injected(IntPtr _unity_self, Particle particle) { }

	// RVA: 0x1718644
	private static void SetParticles_Injected(IntPtr _unity_self, BlittableArrayWrapper particles, int size, int offset) { }

	// RVA: 0x171877C
	private static void SetParticlesWithNativeArray_Injected(IntPtr _unity_self, IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x1718AB8
	private static int GetParticles_Injected(IntPtr _unity_self, BlittableArrayWrapper particles, int size, int offset) { }

	// RVA: 0x1718BF0
	private static int GetParticlesWithNativeArray_Injected(IntPtr _unity_self, IntPtr particles, int particlesLength, int size, int offset) { }

	// RVA: 0x1718FC8
	private static void SetCustomParticleData_Injected(IntPtr _unity_self, BlittableListWrapper customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0x1719278
	private static int GetCustomParticleData_Injected(IntPtr _unity_self, BlittableListWrapper customData, ParticleSystemCustomData streamIndex) { }

	// RVA: 0x17193B8
	private static void GetPlaybackState_Injected(IntPtr _unity_self, PlaybackState ret) { }

	// RVA: 0x17194D0
	private static void SetPlaybackState_Injected(IntPtr _unity_self, PlaybackState playbackState) { }

	// RVA: 0x17195E8
	private static void GetTrailDataInternal_Injected(IntPtr _unity_self, Trails trailData) { }

	// RVA: 0x1719AC4
	private static void SetTrails_Injected(IntPtr _unity_self, Trails trailData) { }

	// RVA: 0x1719BF0
	private static void Simulate_Injected(IntPtr _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	// RVA: 0x1719F2C
	private static void Play_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x171A0E4
	private static void Pause_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x171A290
	private static void Stop_Injected(IntPtr _unity_self, bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	// RVA: 0x171A4E0
	private static void Clear_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x171A698
	private static bool IsAlive_Injected(IntPtr _unity_self, bool withChildren) { }

	// RVA: 0x171A900
	private static void Emit_Internal_Injected(IntPtr _unity_self, int count) { }

	// RVA: 0x171AA0C
	private static void Emit_Injected(IntPtr _unity_self, EmitParams emitParams, int count) { }

	// RVA: 0x171AA64
	private static void EmitOld_Internal_Injected(IntPtr _unity_self, Particle particle) { }

	// RVA: 0x171B06C
	private static void TriggerSubEmitterForParticle_Injected(IntPtr _unity_self, int subEmitterIndex, Particle particle) { }

	// RVA: 0x171B0C4
	private static void TriggerSubEmitterForParticles_Injected(IntPtr _unity_self, int subEmitterIndex, BlittableListWrapper particles) { }

	// RVA: 0x171B11C
	private static void TriggerSubEmitterForAllParticles_Injected(IntPtr _unity_self, int subEmitterIndex) { }

	// RVA: 0x171B2C4
	private static void AllocateAxisOfRotationAttribute_Injected(IntPtr _unity_self) { }

	// RVA: 0x171B3AC
	private static void AllocateMeshIndexAttribute_Injected(IntPtr _unity_self) { }

	// RVA: 0x171B4AC
	private static void AllocateCustomDataAttribute_Injected(IntPtr _unity_self, ParticleSystemCustomData stream) { }

	// RVA: 0x171B5AC
	private static bool get_has3DParticleRotations_Injected(IntPtr _unity_self) { }

	// RVA: 0x171B694
	private static bool get_hasNonUniformParticleSizes_Injected(IntPtr _unity_self) { }

	// RVA: 0x171B77C
	private static Void* GetManagedJobData_Injected(IntPtr _unity_self) { }

	// RVA: 0x171B870
	private static void GetManagedJobHandle_Injected(IntPtr _unity_self, JobHandle ret) { }

	// RVA: 0x171B978
	private static void SetManagedJobHandle_Injected(IntPtr _unity_self, JobHandle handle) { }

	// RVA: 0x171BA48
	private static void ScheduleManagedJob_Injected(JobScheduleParameters parameters, Void* additionalData, JobHandle ret) { }

}

// Namespace: UnityEngine
public enum ParticleSystemRenderMode
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemRenderMode Billboard = 0;
	public const ParticleSystemRenderMode Stretch = 1;
	public const ParticleSystemRenderMode HorizontalBillboard = 2;
	public const ParticleSystemRenderMode VerticalBillboard = 3;
	public const ParticleSystemRenderMode Mesh = 4;
	public const ParticleSystemRenderMode None = 5;
}

// Namespace: UnityEngine
public enum ParticleSystemMeshDistribution
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemMeshDistribution UniformRandom = 0;
	public const ParticleSystemMeshDistribution NonUniformRandom = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemSortMode
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemSortMode None = 0;
	public const ParticleSystemSortMode Distance = 1;
	public const ParticleSystemSortMode OldestInFront = 2;
	public const ParticleSystemSortMode YoungestInFront = 3;
	public const ParticleSystemSortMode Depth = 4;
	public const ParticleSystemSortMode DistanceReverse = 5;
	public const ParticleSystemSortMode DepthReverse = 6;
}

// Namespace: UnityEngine
public enum ParticleSystemRenderSpace
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemRenderSpace View = 0;
	public const ParticleSystemRenderSpace World = 1;
	public const ParticleSystemRenderSpace Local = 2;
	public const ParticleSystemRenderSpace Facing = 3;
	public const ParticleSystemRenderSpace Velocity = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemCurveMode
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemCurveMode Constant = 0;
	public const ParticleSystemCurveMode Curve = 1;
	public const ParticleSystemCurveMode TwoCurves = 2;
	public const ParticleSystemCurveMode TwoConstants = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemGradientMode
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemGradientMode Color = 0;
	public const ParticleSystemGradientMode Gradient = 1;
	public const ParticleSystemGradientMode TwoColors = 2;
	public const ParticleSystemGradientMode TwoGradients = 3;
	public const ParticleSystemGradientMode RandomColor = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemShapeType
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemShapeType Sphere = 0;
	public const ParticleSystemShapeType SphereShell = 1;
	public const ParticleSystemShapeType Hemisphere = 2;
	public const ParticleSystemShapeType HemisphereShell = 3;
	public const ParticleSystemShapeType Cone = 4;
	public const ParticleSystemShapeType Box = 5;
	public const ParticleSystemShapeType Mesh = 6;
	public const ParticleSystemShapeType ConeShell = 7;
	public const ParticleSystemShapeType ConeVolume = 8;
	public const ParticleSystemShapeType ConeVolumeShell = 9;
	public const ParticleSystemShapeType Circle = 10;
	public const ParticleSystemShapeType CircleEdge = 11;
	public const ParticleSystemShapeType SingleSidedEdge = 12;
	public const ParticleSystemShapeType MeshRenderer = 13;
	public const ParticleSystemShapeType SkinnedMeshRenderer = 14;
	public const ParticleSystemShapeType BoxShell = 15;
	public const ParticleSystemShapeType BoxEdge = 16;
	public const ParticleSystemShapeType Donut = 17;
	public const ParticleSystemShapeType Rectangle = 18;
	public const ParticleSystemShapeType Sprite = 19;
	public const ParticleSystemShapeType SpriteRenderer = 20;
}

// Namespace: UnityEngine
public enum ParticleSystemSimulationSpace
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemSimulationSpace Local = 0;
	public const ParticleSystemSimulationSpace World = 1;
	public const ParticleSystemSimulationSpace Custom = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemStopBehavior
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemStopBehavior StopEmittingAndClear = 0;
	public const ParticleSystemStopBehavior StopEmitting = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemScalingMode
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemScalingMode Hierarchy = 0;
	public const ParticleSystemScalingMode Local = 1;
	public const ParticleSystemScalingMode Shape = 2;
}

// Namespace: UnityEngine
public enum ParticleSystemCullingMode
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemCullingMode Automatic = 0;
	public const ParticleSystemCullingMode PauseAndCatchup = 1;
	public const ParticleSystemCullingMode Pause = 2;
	public const ParticleSystemCullingMode AlwaysSimulate = 3;
}

// Namespace: UnityEngine
public enum ParticleSystemVertexStream
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemVertexStream Position = 0;
	public const ParticleSystemVertexStream Normal = 1;
	public const ParticleSystemVertexStream Tangent = 2;
	public const ParticleSystemVertexStream Color = 3;
	public const ParticleSystemVertexStream UV = 4;
	public const ParticleSystemVertexStream UV2 = 5;
	public const ParticleSystemVertexStream UV3 = 6;
	public const ParticleSystemVertexStream UV4 = 7;
	public const ParticleSystemVertexStream AnimBlend = 8;
	public const ParticleSystemVertexStream AnimFrame = 9;
	public const ParticleSystemVertexStream Center = 10;
	public const ParticleSystemVertexStream VertexID = 11;
	public const ParticleSystemVertexStream SizeX = 12;
	public const ParticleSystemVertexStream SizeXY = 13;
	public const ParticleSystemVertexStream SizeXYZ = 14;
	public const ParticleSystemVertexStream Rotation = 15;
	public const ParticleSystemVertexStream Rotation3D = 16;
	public const ParticleSystemVertexStream RotationSpeed = 17;
	public const ParticleSystemVertexStream RotationSpeed3D = 18;
	public const ParticleSystemVertexStream Velocity = 19;
	public const ParticleSystemVertexStream Speed = 20;
	public const ParticleSystemVertexStream AgePercent = 21;
	public const ParticleSystemVertexStream InvStartLifetime = 22;
	public const ParticleSystemVertexStream StableRandomX = 23;
	public const ParticleSystemVertexStream StableRandomXY = 24;
	public const ParticleSystemVertexStream StableRandomXYZ = 25;
	public const ParticleSystemVertexStream StableRandomXYZW = 26;
	public const ParticleSystemVertexStream VaryingRandomX = 27;
	public const ParticleSystemVertexStream VaryingRandomXY = 28;
	public const ParticleSystemVertexStream VaryingRandomXYZ = 29;
	public const ParticleSystemVertexStream VaryingRandomXYZW = 30;
	public const ParticleSystemVertexStream Custom1X = 31;
	public const ParticleSystemVertexStream Custom1XY = 32;
	public const ParticleSystemVertexStream Custom1XYZ = 33;
	public const ParticleSystemVertexStream Custom1XYZW = 34;
	public const ParticleSystemVertexStream Custom2X = 35;
	public const ParticleSystemVertexStream Custom2XY = 36;
	public const ParticleSystemVertexStream Custom2XYZ = 37;
	public const ParticleSystemVertexStream Custom2XYZW = 38;
	public const ParticleSystemVertexStream NoiseSumX = 39;
	public const ParticleSystemVertexStream NoiseSumXY = 40;
	public const ParticleSystemVertexStream NoiseSumXYZ = 41;
	public const ParticleSystemVertexStream NoiseImpulseX = 42;
	public const ParticleSystemVertexStream NoiseImpulseXY = 43;
	public const ParticleSystemVertexStream NoiseImpulseXYZ = 44;
	public const ParticleSystemVertexStream MeshIndex = 45;
	public const ParticleSystemVertexStream ParticleIndex = 46;
	public const ParticleSystemVertexStream ColorPackedAsTwoFloats = 47;
	public const ParticleSystemVertexStream MeshAxisOfRotation = 48;
	public const ParticleSystemVertexStream NextTrailCenter = 49;
	public const ParticleSystemVertexStream PreviousTrailCenter = 50;
	public const ParticleSystemVertexStream PercentageAlongTrail = 51;
	public const ParticleSystemVertexStream TrailWidth = 52;
}

// Namespace: UnityEngine
public enum ParticleSystemCustomData
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemCustomData Custom1 = 0;
	public const ParticleSystemCustomData Custom2 = 1;
}

// Namespace: UnityEngine
public enum ParticleSystemBakeMeshOptions
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemBakeMeshOptions BakeRotationAndScale = 1;
	public const ParticleSystemBakeMeshOptions BakePosition = 2;
	public const ParticleSystemBakeMeshOptions Default = 0;
}

// Namespace: UnityEngine
public enum ParticleSystemBakeTextureOptions
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemBakeTextureOptions BakeRotationAndScale = 1;
	public const ParticleSystemBakeTextureOptions BakePosition = 2;
	public const ParticleSystemBakeTextureOptions PerVertex = 4;
	public const ParticleSystemBakeTextureOptions PerParticle = 8;
	public const ParticleSystemBakeTextureOptions IncludeParticleIndices = 16;
	public const ParticleSystemBakeTextureOptions Default = 4;
}

// Namespace: UnityEngine
public enum ParticleSystemVertexStreams
{
	// Fields
	public int value__; // 0x10
	public const ParticleSystemVertexStreams Position = 1;
	public const ParticleSystemVertexStreams Normal = 2;
	public const ParticleSystemVertexStreams Tangent = 4;
	public const ParticleSystemVertexStreams Color = 8;
	public const ParticleSystemVertexStreams UV = 16;
	public const ParticleSystemVertexStreams UV2BlendAndFrame = 32;
	public const ParticleSystemVertexStreams CenterAndVertexID = 64;
	public const ParticleSystemVertexStreams Size = 128;
	public const ParticleSystemVertexStreams Rotation = 256;
	public const ParticleSystemVertexStreams Velocity = 512;
	public const ParticleSystemVertexStreams Lifetime = 1024;
	public const ParticleSystemVertexStreams Custom1 = 2048;
	public const ParticleSystemVertexStreams Custom2 = 4096;
	public const ParticleSystemVertexStreams Random = 8192;
	public const ParticleSystemVertexStreams None = 0;
	public const ParticleSystemVertexStreams All = 2147483647;
}

// Namespace: 
internal struct BakeTextureOutput
{
	// Fields
	internal Texture2D vertices; // 0x10
	internal Texture2D indices; // 0x18
}

// Namespace: UnityEngine
public sealed class ParticleSystemRenderer
{
	// Methods

	// RVA: 0x171D1C0
	public void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0x171DA28
	public void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0x171DA30
	public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	// RVA: 0x171DD74
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0x171D1C8
	internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) { }

	// RVA: 0x171DA58
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	// RVA: 0x171E298
	public void BakeMesh(Mesh mesh, bool useTransform) { }

	// RVA: 0x171E2E4
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform) { }

	// RVA: 0x171E46C
	public void BakeTrailsMesh(Mesh mesh, bool useTransform) { }

	// RVA: 0x171E4B8
	public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform) { }

	// RVA: 0x171E640
	public ParticleSystemRenderSpace get_alignment() { }

	// RVA: 0x171E728
	public void set_alignment(ParticleSystemRenderSpace value) { }

	// RVA: 0x171E840
	public ParticleSystemRenderMode get_renderMode() { }

	// RVA: 0x171E928
	public void set_renderMode(ParticleSystemRenderMode value) { }

	// RVA: 0x171EA40
	public ParticleSystemMeshDistribution get_meshDistribution() { }

	// RVA: 0x171EB28
	public void set_meshDistribution(ParticleSystemMeshDistribution value) { }

	// RVA: 0x171EC40
	public ParticleSystemSortMode get_sortMode() { }

	// RVA: 0x171ED28
	public void set_sortMode(ParticleSystemSortMode value) { }

	// RVA: 0x171EE40
	public float get_lengthScale() { }

	// RVA: 0x171EF28
	public void set_lengthScale(float value) { }

	// RVA: 0x171F040
	public float get_velocityScale() { }

	// RVA: 0x171F128
	public void set_velocityScale(float value) { }

	// RVA: 0x171F240
	public float get_cameraVelocityScale() { }

	// RVA: 0x171F328
	public void set_cameraVelocityScale(float value) { }

	// RVA: 0x171F440
	public float get_normalDirection() { }

	// RVA: 0x171F528
	public void set_normalDirection(float value) { }

	// RVA: 0x171F640
	public float get_shadowBias() { }

	// RVA: 0x171F728
	public void set_shadowBias(float value) { }

	// RVA: 0x171F840
	public float get_sortingFudge() { }

	// RVA: 0x171F928
	public void set_sortingFudge(float value) { }

	// RVA: 0x171FA40
	public float get_minParticleSize() { }

	// RVA: 0x171FB28
	public void set_minParticleSize(float value) { }

	// RVA: 0x171FC40
	public float get_maxParticleSize() { }

	// RVA: 0x171FD28
	public void set_maxParticleSize(float value) { }

	// RVA: 0x171FE40
	public Vector3 get_pivot() { }

	// RVA: 0x171FF54
	public void set_pivot(Vector3 value) { }

	// RVA: 0x1720060
	public Vector3 get_flip() { }

	// RVA: 0x1720174
	public void set_flip(Vector3 value) { }

	// RVA: 0x1720280
	public SpriteMaskInteraction get_maskInteraction() { }

	// RVA: 0x1720368
	public void set_maskInteraction(SpriteMaskInteraction value) { }

	// RVA: 0x1720480
	public Material get_trailMaterial() { }

	// RVA: 0x1720588
	public void set_trailMaterial(Material value) { }

	// RVA: 0x17206D4
	internal void set_oldTrailMaterial(Material value) { }

	// RVA: 0x1720820
	public bool get_enableGPUInstancing() { }

	// RVA: 0x1720908
	public void set_enableGPUInstancing(bool value) { }

	// RVA: 0x1720A20
	public bool get_allowRoll() { }

	// RVA: 0x1720B08
	public void set_allowRoll(bool value) { }

	// RVA: 0x1720C20
	public bool get_freeformStretching() { }

	// RVA: 0x1720D08
	public void set_freeformStretching(bool value) { }

	// RVA: 0x1720E20
	public bool get_rotateWithStretchDirection() { }

	// RVA: 0x1720F08
	public void set_rotateWithStretchDirection(bool value) { }

	// RVA: 0x1721020
	public Mesh get_mesh() { }

	// RVA: 0x1721128
	public void set_mesh(Mesh value) { }

	// RVA: 0x1721274
	public int GetMeshes(Mesh[] meshes) { }

	// RVA: 0x17213BC
	public void SetMeshes(Mesh[] meshes, int size) { }

	// RVA: 0x17214E8
	public void SetMeshes(Mesh[] meshes) { }

	// RVA: 0x1721504
	public int GetMeshWeightings(float[] weightings) { }

	// RVA: 0x1721704
	public void SetMeshWeightings(float[] weightings, int size) { }

	// RVA: 0x17218A8
	public void SetMeshWeightings(float[] weightings) { }

	// RVA: 0x17218C4
	public int get_meshCount() { }

	// RVA: 0x17219AC
	public void BakeMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x171E2F8
	public void BakeMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x1721A58
	public void BakeTrailsMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x171E4CC
	public void BakeTrailsMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x1721B04
	public int BakeTexture(Texture2D verticesTexture, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x1721B48
	public int BakeTexture(Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x1721C88
	private Texture2D BakeTextureNoIndicesInternal(Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options, int indexCount) { }

	// RVA: 0x1721E84
	public int BakeTexture(Texture2D verticesTexture, Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x1721F10
	public int BakeTexture(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x1721F80
	private BakeTextureOutput BakeTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, int indexCount) { }

	// RVA: 0x17221AC
	public int BakeTrailsTexture(Texture2D verticesTexture, Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x1722238
	public int BakeTrailsTexture(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	// RVA: 0x17222A8
	private BakeTextureOutput BakeTrailsTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, int indexCount) { }

	// RVA: 0x171DD78
	public int get_activeVertexStreamsCount() { }

	// RVA: 0x171E054
	public void SetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams) { }

	// RVA: 0x171DE10
	public void GetActiveVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams) { }

	// RVA: 0x17225F4
	public int get_activeTrailVertexStreamsCount() { }

	// RVA: 0x17226DC
	public void SetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams) { }

	// RVA: 0x1722988
	public void GetActiveTrailVertexStreams(System.Collections.Generic.List<UnityEngine.ParticleSystemVertexStream> streams) { }

	// RVA: 0x1722C34
	public void .ctor() { }

	// RVA: 0x171E6D8
	private static ParticleSystemRenderSpace get_alignment_Injected(IntPtr _unity_self) { }

	// RVA: 0x171E7D8
	private static void set_alignment_Injected(IntPtr _unity_self, ParticleSystemRenderSpace value) { }

	// RVA: 0x171E8D8
	private static ParticleSystemRenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x171E9D8
	private static void set_renderMode_Injected(IntPtr _unity_self, ParticleSystemRenderMode value) { }

	// RVA: 0x171EAD8
	private static ParticleSystemMeshDistribution get_meshDistribution_Injected(IntPtr _unity_self) { }

	// RVA: 0x171EBD8
	private static void set_meshDistribution_Injected(IntPtr _unity_self, ParticleSystemMeshDistribution value) { }

	// RVA: 0x171ECD8
	private static ParticleSystemSortMode get_sortMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x171EDD8
	private static void set_sortMode_Injected(IntPtr _unity_self, ParticleSystemSortMode value) { }

	// RVA: 0x171EED8
	private static float get_lengthScale_Injected(IntPtr _unity_self) { }

	// RVA: 0x171EFD8
	private static void set_lengthScale_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x171F0D8
	private static float get_velocityScale_Injected(IntPtr _unity_self) { }

	// RVA: 0x171F1D8
	private static void set_velocityScale_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x171F2D8
	private static float get_cameraVelocityScale_Injected(IntPtr _unity_self) { }

	// RVA: 0x171F3D8
	private static void set_cameraVelocityScale_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x171F4D8
	private static float get_normalDirection_Injected(IntPtr _unity_self) { }

	// RVA: 0x171F5D8
	private static void set_normalDirection_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x171F6D8
	private static float get_shadowBias_Injected(IntPtr _unity_self) { }

	// RVA: 0x171F7D8
	private static void set_shadowBias_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x171F8D8
	private static float get_sortingFudge_Injected(IntPtr _unity_self) { }

	// RVA: 0x171F9D8
	private static void set_sortingFudge_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x171FAD8
	private static float get_minParticleSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x171FBD8
	private static void set_minParticleSize_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x171FCD8
	private static float get_maxParticleSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x171FDD8
	private static void set_maxParticleSize_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x171FEEC
	private static void get_pivot_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x171FFF8
	private static void set_pivot_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x172010C
	private static void get_flip_Injected(IntPtr _unity_self, Vector3 ret) { }

	// RVA: 0x1720218
	private static void set_flip_Injected(IntPtr _unity_self, Vector3 value) { }

	// RVA: 0x1720318
	private static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self) { }

	// RVA: 0x1720418
	private static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value) { }

	// RVA: 0x1720538
	private static IntPtr get_trailMaterial_Injected(IntPtr _unity_self) { }

	// RVA: 0x172066C
	private static void set_trailMaterial_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x17207B8
	private static void set_oldTrailMaterial_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x17208B8
	private static bool get_enableGPUInstancing_Injected(IntPtr _unity_self) { }

	// RVA: 0x17209B8
	private static void set_enableGPUInstancing_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1720AB8
	private static bool get_allowRoll_Injected(IntPtr _unity_self) { }

	// RVA: 0x1720BB8
	private static void set_allowRoll_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1720CB8
	private static bool get_freeformStretching_Injected(IntPtr _unity_self) { }

	// RVA: 0x1720DB8
	private static void set_freeformStretching_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1720EB8
	private static bool get_rotateWithStretchDirection_Injected(IntPtr _unity_self) { }

	// RVA: 0x1720FB8
	private static void set_rotateWithStretchDirection_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x17210D8
	private static IntPtr get_mesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x172120C
	private static void set_mesh_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1721354
	private static int GetMeshes_Injected(IntPtr _unity_self, Mesh[] meshes) { }

	// RVA: 0x1721490
	private static void SetMeshes_Injected(IntPtr _unity_self, Mesh[] meshes, int size) { }

	// RVA: 0x172169C
	private static int GetMeshWeightings_Injected(IntPtr _unity_self, BlittableArrayWrapper weightings) { }

	// RVA: 0x1721850
	private static void SetMeshWeightings_Injected(IntPtr _unity_self, ManagedSpanWrapper weightings, int size) { }

	// RVA: 0x172195C
	private static int get_meshCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x17219F0
	private static void BakeMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x1721A9C
	private static void BakeTrailsMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, ParticleSystemBakeMeshOptions options) { }

	// RVA: 0x1721E14
	private static IntPtr BakeTextureNoIndicesInternal_Injected(IntPtr _unity_self, IntPtr verticesTexture, IntPtr camera, ParticleSystemBakeTextureOptions options, int indexCount) { }

	// RVA: 0x1722124
	private static void BakeTextureInternal_Injected(IntPtr _unity_self, IntPtr verticesTexture, IntPtr indicesTexture, IntPtr camera, ParticleSystemBakeTextureOptions options, int indexCount, BakeTextureOutput ret) { }

	// RVA: 0x172244C
	private static void BakeTrailsTextureInternal_Injected(IntPtr _unity_self, IntPtr verticesTexture, IntPtr indicesTexture, IntPtr camera, ParticleSystemBakeTextureOptions options, int indexCount, BakeTextureOutput ret) { }

	// RVA: 0x17224D4
	private static int get_activeVertexStreamsCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1722524
	private static void SetActiveVertexStreams_Injected(IntPtr _unity_self, BlittableListWrapper streams) { }

	// RVA: 0x172258C
	private static void GetActiveVertexStreams_Injected(IntPtr _unity_self, BlittableListWrapper streams) { }

	// RVA: 0x172268C
	private static int get_activeTrailVertexStreamsCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1722920
	private static void SetActiveTrailVertexStreams_Injected(IntPtr _unity_self, BlittableListWrapper streams) { }

	// RVA: 0x1722BCC
	private static void GetActiveTrailVertexStreams_Injected(IntPtr _unity_self, BlittableListWrapper streams) { }

}

// Namespace: 
internal struct Array3
{
	// Fields
	internal Single* x; // 0x10
	internal Single* y; // 0x18
	internal Single* z; // 0x20
}

// Namespace: 
internal struct Array4
{
	// Fields
	internal Single* x; // 0x10
	internal Single* y; // 0x18
	internal Single* z; // 0x20
	internal Single* w; // 0x28
}

// Namespace: UnityEngine.ParticleSystemJobs
internal struct NativeParticleData
{
	// Fields
	internal int count; // 0x10
	internal Array3 positions; // 0x18
	internal Array3 velocities; // 0x30
	internal Array3 axisOfRotations; // 0x48
	internal Array3 rotations; // 0x60
	internal Array3 rotationalSpeeds; // 0x78
	internal Array3 sizes; // 0x90
	internal Void* startColors; // 0xA8
	internal Void* aliveTimePercent; // 0xB0
	internal Void* inverseStartLifetimes; // 0xB8
	internal Void* randomSeeds; // 0xC0
	internal Array4 customData1; // 0xC8
	internal Array4 customData2; // 0xE8
	internal Void* meshIndices; // 0x108
}


