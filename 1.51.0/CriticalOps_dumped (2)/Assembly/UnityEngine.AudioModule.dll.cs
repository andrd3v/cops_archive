// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public enum AudioVelocityUpdateMode
{
	// Fields
	public int value__; // 0x10
	public const AudioVelocityUpdateMode Auto = 0;
	public const AudioVelocityUpdateMode Fixed = 1;
	public const AudioVelocityUpdateMode Dynamic = 2;
}

// Namespace: UnityEngine
public enum FFTWindow
{
	// Fields
	public int value__; // 0x10
	public const FFTWindow Rectangular = 0;
	public const FFTWindow Triangle = 1;
	public const FFTWindow Hamming = 2;
	public const FFTWindow Hanning = 3;
	public const FFTWindow Blackman = 4;
	public const FFTWindow BlackmanHarris = 5;
}

// Namespace: UnityEngine
public enum AudioRolloffMode
{
	// Fields
	public int value__; // 0x10
	public const AudioRolloffMode Logarithmic = 0;
	public const AudioRolloffMode Linear = 1;
	public const AudioRolloffMode Custom = 2;
}

// Namespace: UnityEngine
public enum AudioSourceCurveType
{
	// Fields
	public int value__; // 0x10
	public const AudioSourceCurveType CustomRolloff = 0;
	public const AudioSourceCurveType SpatialBlend = 1;
	public const AudioSourceCurveType ReverbZoneMix = 2;
	public const AudioSourceCurveType Spread = 3;
}

// Namespace: UnityEngine
public enum AudioReverbPreset
{
	// Fields
	public int value__; // 0x10
	public const AudioReverbPreset Off = 0;
	public const AudioReverbPreset Generic = 1;
	public const AudioReverbPreset PaddedCell = 2;
	public const AudioReverbPreset Room = 3;
	public const AudioReverbPreset Bathroom = 4;
	public const AudioReverbPreset Livingroom = 5;
	public const AudioReverbPreset Stoneroom = 6;
	public const AudioReverbPreset Auditorium = 7;
	public const AudioReverbPreset Concerthall = 8;
	public const AudioReverbPreset Cave = 9;
	public const AudioReverbPreset Arena = 10;
	public const AudioReverbPreset Hangar = 11;
	public const AudioReverbPreset CarpetedHallway = 12;
	public const AudioReverbPreset Hallway = 13;
	public const AudioReverbPreset StoneCorridor = 14;
	public const AudioReverbPreset Alley = 15;
	public const AudioReverbPreset Forest = 16;
	public const AudioReverbPreset City = 17;
	public const AudioReverbPreset Mountains = 18;
	public const AudioReverbPreset Quarry = 19;
	public const AudioReverbPreset Plain = 20;
	public const AudioReverbPreset ParkingLot = 21;
	public const AudioReverbPreset SewerPipe = 22;
	public const AudioReverbPreset Underwater = 23;
	public const AudioReverbPreset Drugged = 24;
	public const AudioReverbPreset Dizzy = 25;
	public const AudioReverbPreset Psychotic = 26;
	public const AudioReverbPreset User = 27;
}

// Namespace: UnityEngine
internal struct PlayableSettings
{
	// Fields
	private readonly AudioContainerElement <element>k__BackingField; // 0x10
	private readonly Double <scheduledTime>k__BackingField; // 0x18
	private readonly float <pitchOffset>k__BackingField; // 0x20
	private readonly float <volumeOffset>k__BackingField; // 0x24
	private readonly Double <triggerTimeOffset>k__BackingField; // 0x28
}

// Namespace: UnityEngine
internal struct ActivePlayable
{
	// Fields
	private readonly PlayableSettings <settings>k__BackingField; // 0x10
	private readonly PlayableHandle <clipPlayableHandle>k__BackingField; // 0x30
}

// Namespace: 
public sealed class AudioConfigurationChangeHandler
{
	// Methods

	// RVA: 0x1620B5C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1620C00
	public virtual void Invoke(bool deviceWasChanged) { }

}

// Namespace: 
public static class Mobile
{
	// Fields
	private static bool <muteState>k__BackingField; // 0x0
	private static bool _stopAudioOutputOnMute; // 0x1
	private static System.Action<System.Boolean> OnMuteStateChanged; // 0x8

	// Methods

	// RVA: 0x1620C14
	public static bool get_muteState() { }

	// RVA: 0x1620C60
	private static void set_muteState(bool value) { }

	// RVA: 0x1620CB8
	public static bool get_stopAudioOutputOnMute() { }

	// RVA: 0x1620D04
	internal static void InvokeOnMuteStateChanged(bool mute) { }

	// RVA: 0x1620F58
	internal static bool InvokeIsStopAudioOutputOnMuteEnabled() { }

	// RVA: 0x1620F18
	public static void StartAudioOutput() { }

	// RVA: 0x1620ED8
	public static void StopAudioOutput() { }

}

// Namespace: UnityEngine
public sealed class AudioSettings
{
	// Fields
	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	private static Action OnAudioSystemShuttingDown; // 0x8
	private static Action OnAudioSystemStartedUp; // 0x10

	// Methods

	// RVA: 0x1620990
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	// RVA: 0x1620A0C
	internal static void InvokeOnAudioSystemShuttingDown() { }

	// RVA: 0x1620A74
	internal static void InvokeOnAudioSystemStartedUp() { }

	// RVA: 0x1620ADC
	internal static bool StartAudioOutput() { }

	// RVA: 0x1620B1C
	internal static bool StopAudioOutput() { }

}

// Namespace: 
public sealed class PCMReaderCallback
{
	// Methods

	// RVA: 0x16211F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16212A4
	public virtual void Invoke(float[] data) { }

}

// Namespace: 
public sealed class PCMSetPositionCallback
{
	// Methods

	// RVA: 0x16212B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x162135C
	public virtual void Invoke(int position) { }

}

// Namespace: UnityEngine
public sealed class AudioClip
{
	// Fields
	private PCMReaderCallback m_PCMReaderCallback; // 0x18
	private PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Methods

	// RVA: 0x1620FA4
	private void .ctor() { }

	// RVA: 0x16210D0
	public float get_length() { }

	// RVA: 0x16211B8
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	// RVA: 0x16211D4
	private void InvokePCMSetPositionCallback_Internal(int position) { }

	// RVA: 0x1621168
	private static float get_length_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public class AudioBehaviour
{
	// Methods

	// RVA: 0x1621370
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioListener
{
	// Methods

	// RVA: 0x1621378
	private static void GetOutputDataHelper(float[] samples, int channel) { }

	// RVA: 0x1621504
	private static void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1621688
	public static float get_volume() { }

	// RVA: 0x16216C8
	public static void set_volume(float value) { }

	// RVA: 0x1621720
	public static bool get_pause() { }

	// RVA: 0x1621760
	public static void set_pause(bool value) { }

	// RVA: 0x16217B0
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x1621898
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x16219B0
	public static float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x1621A1C
	public static void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x1621A20
	public static float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x1621A9C
	public static void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1621AA0
	public void .ctor() { }

	// RVA: 0x162149C
	private static void GetOutputDataHelper_Injected(BlittableArrayWrapper samples, int channel) { }

	// RVA: 0x1621630
	private static void GetSpectrumDataHelper_Injected(BlittableArrayWrapper samples, int channel, FFTWindow window) { }

	// RVA: 0x1621848
	private static AudioVelocityUpdateMode get_velocityUpdateMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1621948
	private static void set_velocityUpdateMode_Injected(IntPtr _unity_self, AudioVelocityUpdateMode value) { }

}

// Namespace: UnityEngine
public sealed class AudioSource
{
	// Methods

	// RVA: 0x1621AA8
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x1621BC0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x1621D08
	private static void PlayHelper(AudioSource source, UInt64 delay) { }

	// RVA: 0x1621E50
	private void Play(Double delay) { }

	// RVA: 0x1621F68
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x1622110
	private void Stop(bool stopOneShots) { }

	// RVA: 0x1622228
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x162234C
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x16224A8
	private static void GetOutputDataHelper(AudioSource source, float[] samples, int channel) { }

	// RVA: 0x16226AC
	private static void GetSpectrumDataHelper(AudioSource source, float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x16228C8
	public float get_volume() { }

	// RVA: 0x16229B0
	public void set_volume(float value) { }

	// RVA: 0x1622AC8
	public float get_pitch() { }

	// RVA: 0x1622ACC
	public void set_pitch(float value) { }

	// RVA: 0x1622AD0
	public float get_time() { }

	// RVA: 0x1622BB8
	public void set_time(float value) { }

	// RVA: 0x1622CD0
	public int get_timeSamples() { }

	// RVA: 0x1622DB8
	public void set_timeSamples(int value) { }

	// RVA: 0x1622ED0
	public AudioClip get_clip() { }

	// RVA: 0x1622FE8
	public void set_clip(AudioClip value) { }

	// RVA: 0x1622F30
	public AudioResource get_resource() { }

	// RVA: 0x1622FEC
	public void set_resource(AudioResource value) { }

	// RVA: 0x1623188
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x1623290
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	// RVA: 0x16233DC
	public void Play() { }

	// RVA: 0x16233E4
	public void Play(UInt64 delay) { }

	// RVA: 0x16233E8
	public void PlayDelayed(float delay) { }

	// RVA: 0x162349C
	public void PlayScheduled(Double time) { }

	// RVA: 0x1623548
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x1623550
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x1623650
	public void SetScheduledStartTime(Double time) { }

	// RVA: 0x1623768
	public void SetScheduledEndTime(Double time) { }

	// RVA: 0x1623880
	public void Stop() { }

	// RVA: 0x1623920
	public void Pause() { }

	// RVA: 0x1623A08
	public void UnPause() { }

	// RVA: 0x1623AF0
	internal void SkipToNextElementIfHasContainer() { }

	// RVA: 0x1623BD8
	public bool get_isPlaying() { }

	// RVA: 0x1623CC0
	internal bool get_isContainerPlaying() { }

	// RVA: 0x1623DA8
	internal ActivePlayable[] get_containerActivePlayables() { }

	// RVA: 0x1623E90
	public bool get_isVirtual() { }

	// RVA: 0x1623F78
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x1623F80
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x162436C
	public bool get_loop() { }

	// RVA: 0x1624454
	public void set_loop(bool value) { }

	// RVA: 0x162456C
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x1624654
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x162476C
	public bool get_playOnAwake() { }

	// RVA: 0x1624854
	public void set_playOnAwake(bool value) { }

	// RVA: 0x162496C
	public bool get_ignoreListenerPause() { }

	// RVA: 0x1624A54
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x1624B6C
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x1624C54
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x1624D6C
	public float get_panStereo() { }

	// RVA: 0x1624E54
	public void set_panStereo(float value) { }

	// RVA: 0x1624F6C
	public float get_spatialBlend() { }

	// RVA: 0x16242BC
	public void set_spatialBlend(float value) { }

	// RVA: 0x16250BC
	public bool get_spatialize() { }

	// RVA: 0x16251A4
	public void set_spatialize(bool value) { }

	// RVA: 0x16252BC
	public bool get_spatializePostEffects() { }

	// RVA: 0x16253A4
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x16254BC
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x16254C0
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x16254C4
	public float get_reverbZoneMix() { }

	// RVA: 0x16255AC
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x16256C4
	public bool get_bypassEffects() { }

	// RVA: 0x16257AC
	public void set_bypassEffects(bool value) { }

	// RVA: 0x16258C4
	public bool get_bypassListenerEffects() { }

	// RVA: 0x16259AC
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x1625AC4
	public bool get_bypassReverbZones() { }

	// RVA: 0x1625BAC
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x1625CC4
	public float get_dopplerLevel() { }

	// RVA: 0x1625DAC
	public void set_dopplerLevel(float value) { }

	// RVA: 0x1625EC4
	public float get_spread() { }

	// RVA: 0x1625FAC
	public void set_spread(float value) { }

	// RVA: 0x16260C4
	public int get_priority() { }

	// RVA: 0x16261AC
	public void set_priority(int value) { }

	// RVA: 0x16262C4
	public bool get_mute() { }

	// RVA: 0x16263AC
	public void set_mute(bool value) { }

	// RVA: 0x16264C4
	public float get_minDistance() { }

	// RVA: 0x16265AC
	public void set_minDistance(float value) { }

	// RVA: 0x16266C4
	public float get_maxDistance() { }

	// RVA: 0x16267AC
	public void set_maxDistance(float value) { }

	// RVA: 0x16268C4
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x16269AC
	public void set_rolloffMode(AudioRolloffMode value) { }

	// RVA: 0x1626AC4
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x1626B44
	public void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x1626B48
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x1626BD0
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x1626BD4
	public float get_minVolume() { }

	// RVA: 0x1626C48
	public void set_minVolume(float value) { }

	// RVA: 0x1626CDC
	public float get_maxVolume() { }

	// RVA: 0x1626D50
	public void set_maxVolume(float value) { }

	// RVA: 0x1626DE4
	public float get_rolloffFactor() { }

	// RVA: 0x1626E58
	public void set_rolloffFactor(float value) { }

	// RVA: 0x1626EEC
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x1626FF8
	public bool GetSpatializerFloat(int index, float value) { }

	// RVA: 0x16270F4
	public bool GetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x16271F0
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x16272FC
	internal float GetAudioRandomContainerRuntimeMeterValue() { }

	// RVA: 0x16273E4
	public void .ctor() { }

	// RVA: 0x1621B70
	private static float GetPitch_Injected(IntPtr source) { }

	// RVA: 0x1621CA0
	private static void SetPitch_Injected(IntPtr source, float pitch) { }

	// RVA: 0x1621DE8
	private static void PlayHelper_Injected(IntPtr source, UInt64 delay) { }

	// RVA: 0x1621F00
	private static void Play_Injected(IntPtr _unity_self, Double delay) { }

	// RVA: 0x16220B0
	private static void PlayOneShotHelper_Injected(IntPtr source, IntPtr clip, float volumeScale) { }

	// RVA: 0x16221C0
	private static void Stop_Injected(IntPtr _unity_self, bool stopOneShots) { }

	// RVA: 0x16222F4
	private static void SetCustomCurveHelper_Injected(IntPtr source, AudioSourceCurveType type, IntPtr curve) { }

	// RVA: 0x1622440
	private static IntPtr GetCustomCurveHelper_Injected(IntPtr source, AudioSourceCurveType type) { }

	// RVA: 0x1622654
	private static void GetOutputDataHelper_Injected(IntPtr source, BlittableArrayWrapper samples, int channel) { }

	// RVA: 0x1622860
	private static void GetSpectrumDataHelper_Injected(IntPtr source, BlittableArrayWrapper samples, int channel, FFTWindow window) { }

	// RVA: 0x1622960
	private static float get_volume_Injected(IntPtr _unity_self) { }

	// RVA: 0x1622A60
	private static void set_volume_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1622B68
	private static float get_time_Injected(IntPtr _unity_self) { }

	// RVA: 0x1622C68
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1622D68
	private static int get_timeSamples_Injected(IntPtr _unity_self) { }

	// RVA: 0x1622E68
	private static void set_timeSamples_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x16230D0
	private static IntPtr get_resource_Injected(IntPtr _unity_self) { }

	// RVA: 0x1623120
	private static void set_resource_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1623240
	private static IntPtr get_outputAudioMixerGroup_Injected(IntPtr _unity_self) { }

	// RVA: 0x1623374
	private static void set_outputAudioMixerGroup_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1623700
	private static void SetScheduledStartTime_Injected(IntPtr _unity_self, Double time) { }

	// RVA: 0x1623818
	private static void SetScheduledEndTime_Injected(IntPtr _unity_self, Double time) { }

	// RVA: 0x16239B8
	private static void Pause_Injected(IntPtr _unity_self) { }

	// RVA: 0x1623AA0
	private static void UnPause_Injected(IntPtr _unity_self) { }

	// RVA: 0x1623B88
	private static void SkipToNextElementIfHasContainer_Injected(IntPtr _unity_self) { }

	// RVA: 0x1623C70
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	// RVA: 0x1623D58
	private static bool get_isContainerPlaying_Injected(IntPtr _unity_self) { }

	// RVA: 0x1623E40
	private static ActivePlayable[] get_containerActivePlayables_Injected(IntPtr _unity_self) { }

	// RVA: 0x1623F28
	private static bool get_isVirtual_Injected(IntPtr _unity_self) { }

	// RVA: 0x1624404
	private static bool get_loop_Injected(IntPtr _unity_self) { }

	// RVA: 0x1624504
	private static void set_loop_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1624604
	private static bool get_ignoreListenerVolume_Injected(IntPtr _unity_self) { }

	// RVA: 0x1624704
	private static void set_ignoreListenerVolume_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1624804
	private static bool get_playOnAwake_Injected(IntPtr _unity_self) { }

	// RVA: 0x1624904
	private static void set_playOnAwake_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1624A04
	private static bool get_ignoreListenerPause_Injected(IntPtr _unity_self) { }

	// RVA: 0x1624B04
	private static void set_ignoreListenerPause_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1624C04
	private static AudioVelocityUpdateMode get_velocityUpdateMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1624D04
	private static void set_velocityUpdateMode_Injected(IntPtr _unity_self, AudioVelocityUpdateMode value) { }

	// RVA: 0x1624E04
	private static float get_panStereo_Injected(IntPtr _unity_self) { }

	// RVA: 0x1624F04
	private static void set_panStereo_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1625004
	private static float get_spatialBlend_Injected(IntPtr _unity_self) { }

	// RVA: 0x1625054
	private static void set_spatialBlend_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1625154
	private static bool get_spatialize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1625254
	private static void set_spatialize_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1625354
	private static bool get_spatializePostEffects_Injected(IntPtr _unity_self) { }

	// RVA: 0x1625454
	private static void set_spatializePostEffects_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x162555C
	private static float get_reverbZoneMix_Injected(IntPtr _unity_self) { }

	// RVA: 0x162565C
	private static void set_reverbZoneMix_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x162575C
	private static bool get_bypassEffects_Injected(IntPtr _unity_self) { }

	// RVA: 0x162585C
	private static void set_bypassEffects_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x162595C
	private static bool get_bypassListenerEffects_Injected(IntPtr _unity_self) { }

	// RVA: 0x1625A5C
	private static void set_bypassListenerEffects_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1625B5C
	private static bool get_bypassReverbZones_Injected(IntPtr _unity_self) { }

	// RVA: 0x1625C5C
	private static void set_bypassReverbZones_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1625D5C
	private static float get_dopplerLevel_Injected(IntPtr _unity_self) { }

	// RVA: 0x1625E5C
	private static void set_dopplerLevel_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1625F5C
	private static float get_spread_Injected(IntPtr _unity_self) { }

	// RVA: 0x162605C
	private static void set_spread_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x162615C
	private static int get_priority_Injected(IntPtr _unity_self) { }

	// RVA: 0x162625C
	private static void set_priority_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x162635C
	private static bool get_mute_Injected(IntPtr _unity_self) { }

	// RVA: 0x162645C
	private static void set_mute_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x162655C
	private static float get_minDistance_Injected(IntPtr _unity_self) { }

	// RVA: 0x162665C
	private static void set_minDistance_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x162675C
	private static float get_maxDistance_Injected(IntPtr _unity_self) { }

	// RVA: 0x162685C
	private static void set_maxDistance_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x162695C
	private static AudioRolloffMode get_rolloffMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1626A5C
	private static void set_rolloffMode_Injected(IntPtr _unity_self, AudioRolloffMode value) { }

	// RVA: 0x1626F98
	private static bool SetSpatializerFloat_Injected(IntPtr _unity_self, int index, float value) { }

	// RVA: 0x162709C
	private static bool GetSpatializerFloat_Injected(IntPtr _unity_self, int index, float value) { }

	// RVA: 0x1627198
	private static bool GetAmbisonicDecoderFloat_Injected(IntPtr _unity_self, int index, float value) { }

	// RVA: 0x162729C
	private static bool SetAmbisonicDecoderFloat_Injected(IntPtr _unity_self, int index, float value) { }

	// RVA: 0x1627394
	private static float GetAudioRandomContainerRuntimeMeterValue_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine
public sealed class AudioReverbZone
{
	// Methods

	// RVA: 0x16273EC
	public float get_minDistance() { }

	// RVA: 0x16274D4
	public void set_minDistance(float value) { }

	// RVA: 0x16275EC
	public float get_maxDistance() { }

	// RVA: 0x16276D4
	public void set_maxDistance(float value) { }

	// RVA: 0x16277EC
	public AudioReverbPreset get_reverbPreset() { }

	// RVA: 0x16278D4
	public void set_reverbPreset(AudioReverbPreset value) { }

	// RVA: 0x16279EC
	public int get_room() { }

	// RVA: 0x1627AD4
	public void set_room(int value) { }

	// RVA: 0x1627BEC
	public int get_roomHF() { }

	// RVA: 0x1627CD4
	public void set_roomHF(int value) { }

	// RVA: 0x1627DEC
	public int get_roomLF() { }

	// RVA: 0x1627ED4
	public void set_roomLF(int value) { }

	// RVA: 0x1627FEC
	public float get_decayTime() { }

	// RVA: 0x16280D4
	public void set_decayTime(float value) { }

	// RVA: 0x16281EC
	public float get_decayHFRatio() { }

	// RVA: 0x16282D4
	public void set_decayHFRatio(float value) { }

	// RVA: 0x16283EC
	public int get_reflections() { }

	// RVA: 0x16284D4
	public void set_reflections(int value) { }

	// RVA: 0x16285EC
	public float get_reflectionsDelay() { }

	// RVA: 0x16286D4
	public void set_reflectionsDelay(float value) { }

	// RVA: 0x16287EC
	public int get_reverb() { }

	// RVA: 0x16288D4
	public void set_reverb(int value) { }

	// RVA: 0x16289EC
	public float get_reverbDelay() { }

	// RVA: 0x1628AD4
	public void set_reverbDelay(float value) { }

	// RVA: 0x1628BEC
	public float get_HFReference() { }

	// RVA: 0x1628CD4
	public void set_HFReference(float value) { }

	// RVA: 0x1628DEC
	public float get_LFReference() { }

	// RVA: 0x1628ED4
	public void set_LFReference(float value) { }

	// RVA: 0x1628FEC
	public float get_roomRolloffFactor() { }

	// RVA: 0x1629060
	public void set_roomRolloffFactor(float value) { }

	// RVA: 0x16290F4
	public float get_diffusion() { }

	// RVA: 0x16291DC
	public void set_diffusion(float value) { }

	// RVA: 0x16292F4
	public float get_density() { }

	// RVA: 0x16293DC
	public void set_density(float value) { }

	// RVA: 0x16294F4
	public void .ctor() { }

	// RVA: 0x1627484
	private static float get_minDistance_Injected(IntPtr _unity_self) { }

	// RVA: 0x1627584
	private static void set_minDistance_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1627684
	private static float get_maxDistance_Injected(IntPtr _unity_self) { }

	// RVA: 0x1627784
	private static void set_maxDistance_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1627884
	private static AudioReverbPreset get_reverbPreset_Injected(IntPtr _unity_self) { }

	// RVA: 0x1627984
	private static void set_reverbPreset_Injected(IntPtr _unity_self, AudioReverbPreset value) { }

	// RVA: 0x1627A84
	private static int get_room_Injected(IntPtr _unity_self) { }

	// RVA: 0x1627B84
	private static void set_room_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1627C84
	private static int get_roomHF_Injected(IntPtr _unity_self) { }

	// RVA: 0x1627D84
	private static void set_roomHF_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1627E84
	private static int get_roomLF_Injected(IntPtr _unity_self) { }

	// RVA: 0x1627F84
	private static void set_roomLF_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1628084
	private static float get_decayTime_Injected(IntPtr _unity_self) { }

	// RVA: 0x1628184
	private static void set_decayTime_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1628284
	private static float get_decayHFRatio_Injected(IntPtr _unity_self) { }

	// RVA: 0x1628384
	private static void set_decayHFRatio_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1628484
	private static int get_reflections_Injected(IntPtr _unity_self) { }

	// RVA: 0x1628584
	private static void set_reflections_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1628684
	private static float get_reflectionsDelay_Injected(IntPtr _unity_self) { }

	// RVA: 0x1628784
	private static void set_reflectionsDelay_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1628884
	private static int get_reverb_Injected(IntPtr _unity_self) { }

	// RVA: 0x1628984
	private static void set_reverb_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1628A84
	private static float get_reverbDelay_Injected(IntPtr _unity_self) { }

	// RVA: 0x1628B84
	private static void set_reverbDelay_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1628C84
	private static float get_HFReference_Injected(IntPtr _unity_self) { }

	// RVA: 0x1628D84
	private static void set_HFReference_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1628E84
	private static float get_LFReference_Injected(IntPtr _unity_self) { }

	// RVA: 0x1628F84
	private static void set_LFReference_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x162918C
	private static float get_diffusion_Injected(IntPtr _unity_self) { }

	// RVA: 0x162928C
	private static void set_diffusion_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x162938C
	private static float get_density_Injected(IntPtr _unity_self) { }

	// RVA: 0x162948C
	private static void set_density_Injected(IntPtr _unity_self, float value) { }

}

// Namespace: UnityEngine
public sealed class AudioLowPassFilter
{
	// Methods

	// RVA: 0x16294FC
	private AnimationCurve GetCustomLowpassLevelCurveCopy() { }

	// RVA: 0x16295F8
	private static void SetCustomLowpassLevelCurveHelper(AudioLowPassFilter source, AnimationCurve curve) { }

	// RVA: 0x162973C
	public AnimationCurve get_customCutoffCurve() { }

	// RVA: 0x16297E8
	public void set_customCutoffCurve(AnimationCurve value) { }

	// RVA: 0x16297EC
	public float get_cutoffFrequency() { }

	// RVA: 0x16298D4
	public void set_cutoffFrequency(float value) { }

	// RVA: 0x16299EC
	public float get_lowpassResonanceQ() { }

	// RVA: 0x1629AD4
	public void set_lowpassResonanceQ(float value) { }

	// RVA: 0x1629BEC
	public void .ctor() { }

	// RVA: 0x16295A8
	private static IntPtr GetCustomLowpassLevelCurveCopy_Injected(IntPtr _unity_self) { }

	// RVA: 0x16296D4
	private static void SetCustomLowpassLevelCurveHelper_Injected(IntPtr source, IntPtr curve) { }

	// RVA: 0x1629884
	private static float get_cutoffFrequency_Injected(IntPtr _unity_self) { }

	// RVA: 0x1629984
	private static void set_cutoffFrequency_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1629A84
	private static float get_lowpassResonanceQ_Injected(IntPtr _unity_self) { }

	// RVA: 0x1629B84
	private static void set_lowpassResonanceQ_Injected(IntPtr _unity_self, float value) { }

}

// Namespace: 
public sealed class SampleFramesHandler
{
	// Methods

	// RVA: 0x1629C3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1629D60
	public virtual void Invoke(AudioSampleProvider provider, UInt32 sampleFrameCount) { }

}

// Namespace: UnityEngine.Experimental.Audio
public class AudioSampleProvider
{
	// Fields
	private SampleFramesHandler sampleFramesAvailable; // 0x10
	private SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	// RVA: 0x1629BF4
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	// RVA: 0x1629C18
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

// Namespace: UnityEngine.Audio
public abstract class AudioResource
{
	// Methods

	// RVA: 0x1621048
	protected internal void .ctor() { }

}

// Namespace: UnityEngine.Audio
public struct AudioClipPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x1629D74
	public PlayableHandle GetHandle() { }

	// RVA: 0x1629D80
	public bool Equals(AudioClipPlayable other) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixer
{
	// Methods

	// RVA: 0x1629E04
	internal void .ctor() { }

	// RVA: 0x1629E8C
	public bool SetFloat(string name, float value) { }

	// RVA: 0x162A0D8
	public bool GetFloat(string name, float value) { }

	// RVA: 0x162A078
	private static bool SetFloat_Injected(IntPtr _unity_self, ManagedSpanWrapper name, float value) { }

	// RVA: 0x162A2B8
	private static bool GetFloat_Injected(IntPtr _unity_self, ManagedSpanWrapper name, float value) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixerGroup
{
	// Methods

	// RVA: 0x162A310
	internal void .ctor() { }

}

// Namespace: UnityEngine.Audio
public struct AudioMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x162A398
	public PlayableHandle GetHandle() { }

	// RVA: 0x162A3A4
	public bool Equals(AudioMixerPlayable other) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixerSnapshot
{
	// Methods

	// RVA: 0x162A428
	internal void .ctor() { }

}

// Namespace: UnityEngine.Audio
public struct AudioPlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
}

// Namespace: UnityEngine.Audio
internal sealed class AudioContainerElement
{}


