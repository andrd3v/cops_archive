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

// Namespace: 
public sealed class AudioConfigurationChangeHandler
{
	// Methods

	// RVA: 0x15AA8D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15AA97C
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

	// RVA: 0x15AA990
	public static bool get_muteState() { }

	// RVA: 0x15AA9DC
	private static void set_muteState(bool value) { }

	// RVA: 0x15AAA34
	public static bool get_stopAudioOutputOnMute() { }

	// RVA: 0x15AAA80
	internal static void InvokeOnMuteStateChanged(bool mute) { }

	// RVA: 0x15AACD4
	internal static bool InvokeIsStopAudioOutputOnMuteEnabled() { }

	// RVA: 0x15AAC94
	public static void StartAudioOutput() { }

	// RVA: 0x15AAC54
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

	// RVA: 0x15AA70C
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	// RVA: 0x15AA788
	internal static void InvokeOnAudioSystemShuttingDown() { }

	// RVA: 0x15AA7F0
	internal static void InvokeOnAudioSystemStartedUp() { }

	// RVA: 0x15AA858
	internal static bool StartAudioOutput() { }

	// RVA: 0x15AA898
	internal static bool StopAudioOutput() { }

}

// Namespace: 
public sealed class PCMReaderCallback
{
	// Methods

	// RVA: 0x15AAE44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15AAEF8
	public virtual void Invoke(float[] data) { }

}

// Namespace: 
public sealed class PCMSetPositionCallback
{
	// Methods

	// RVA: 0x15AAF0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15AAFB0
	public virtual void Invoke(int position) { }

}

// Namespace: UnityEngine
public sealed class AudioClip
{
	// Fields
	private PCMReaderCallback m_PCMReaderCallback; // 0x18
	private PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Methods

	// RVA: 0x15AAD20
	private void .ctor() { }

	// RVA: 0x15AADBC
	public float get_length() { }

	// RVA: 0x15AAE0C
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	// RVA: 0x15AAE28
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

// Namespace: UnityEngine
public class AudioBehaviour
{
	// Methods

	// RVA: 0x15AAFC4
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioListener
{
	// Methods

	// RVA: 0x15AAFCC
	private static void GetOutputDataHelper(float[] samples, int channel) { }

	// RVA: 0x15AB034
	private static void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x15AB08C
	public static float get_volume() { }

	// RVA: 0x15AB0CC
	public static void set_volume(float value) { }

	// RVA: 0x15AB124
	public static bool get_pause() { }

	// RVA: 0x15AB164
	public static void set_pause(bool value) { }

	// RVA: 0x15AB1B4
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x15AB204
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x15AB26C
	public static float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x15AB2FC
	public static void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x15AB364
	public static float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x15AB404
	public static void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x15AB45C
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioSource
{
	// Methods

	// RVA: 0x15AB464
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x15AB4B4
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x15AB51C
	private static void PlayHelper(AudioSource source, UInt64 delay) { }

	// RVA: 0x15AB584
	private void Play(Double delay) { }

	// RVA: 0x15AB5EC
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x15AB64C
	private void Stop(bool stopOneShots) { }

	// RVA: 0x15AB6B4
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x15AB70C
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x15AB774
	private static void GetOutputDataHelper(AudioSource source, float[] samples, int channel) { }

	// RVA: 0x15AB7CC
	private static void GetSpectrumDataHelper(AudioSource source, float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x15AB834
	public float get_volume() { }

	// RVA: 0x15AB884
	public void set_volume(float value) { }

	// RVA: 0x15AB8EC
	public float get_pitch() { }

	// RVA: 0x15AB93C
	public void set_pitch(float value) { }

	// RVA: 0x15AB9A4
	public float get_time() { }

	// RVA: 0x15AB9F4
	public void set_time(float value) { }

	// RVA: 0x15ABA5C
	public int get_timeSamples() { }

	// RVA: 0x15ABAAC
	public void set_timeSamples(int value) { }

	// RVA: 0x15ABB14
	public AudioClip get_clip() { }

	// RVA: 0x15ABB64
	public void set_clip(AudioClip value) { }

	// RVA: 0x15ABBCC
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x15ABC1C
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	// RVA: 0x15ABC84
	public void Play() { }

	// RVA: 0x15ABCDC
	public void Play(UInt64 delay) { }

	// RVA: 0x15ABD44
	public void PlayDelayed(float delay) { }

	// RVA: 0x15ABDAC
	public void PlayScheduled(Double time) { }

	// RVA: 0x15ABE0C
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x15ABE14
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x15ABF34
	public void SetScheduledStartTime(Double time) { }

	// RVA: 0x15ABF9C
	public void SetScheduledEndTime(Double time) { }

	// RVA: 0x15AC004
	public void Stop() { }

	// RVA: 0x15AC05C
	public void Pause() { }

	// RVA: 0x15AC0AC
	public void UnPause() { }

	// RVA: 0x15AC0FC
	public bool get_isPlaying() { }

	// RVA: 0x15AC14C
	public bool get_isVirtual() { }

	// RVA: 0x15AC19C
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x15AC1A4
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x15AC4EC
	public bool get_loop() { }

	// RVA: 0x15AC53C
	public void set_loop(bool value) { }

	// RVA: 0x15AC5A4
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x15AC5F4
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x15AC65C
	public bool get_playOnAwake() { }

	// RVA: 0x15AC6AC
	public void set_playOnAwake(bool value) { }

	// RVA: 0x15AC714
	public bool get_ignoreListenerPause() { }

	// RVA: 0x15AC764
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x15AC7CC
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x15AC81C
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x15AC884
	public float get_panStereo() { }

	// RVA: 0x15AC8D4
	public void set_panStereo(float value) { }

	// RVA: 0x15AC93C
	public float get_spatialBlend() { }

	// RVA: 0x15AC484
	public void set_spatialBlend(float value) { }

	// RVA: 0x15AC98C
	public bool get_spatialize() { }

	// RVA: 0x15AC9DC
	public void set_spatialize(bool value) { }

	// RVA: 0x15ACA44
	public bool get_spatializePostEffects() { }

	// RVA: 0x15ACA94
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x15ACAFC
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x15ACB54
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x15ACBBC
	public float get_reverbZoneMix() { }

	// RVA: 0x15ACC0C
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x15ACC74
	public bool get_bypassEffects() { }

	// RVA: 0x15ACCC4
	public void set_bypassEffects(bool value) { }

	// RVA: 0x15ACD2C
	public bool get_bypassListenerEffects() { }

	// RVA: 0x15ACD7C
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x15ACDE4
	public bool get_bypassReverbZones() { }

	// RVA: 0x15ACE34
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x15ACE9C
	public float get_dopplerLevel() { }

	// RVA: 0x15ACEEC
	public void set_dopplerLevel(float value) { }

	// RVA: 0x15ACF54
	public float get_spread() { }

	// RVA: 0x15ACFA4
	public void set_spread(float value) { }

	// RVA: 0x15AD00C
	public int get_priority() { }

	// RVA: 0x15AD05C
	public void set_priority(int value) { }

	// RVA: 0x15AD0C4
	public bool get_mute() { }

	// RVA: 0x15AD114
	public void set_mute(bool value) { }

	// RVA: 0x15AD17C
	public float get_minDistance() { }

	// RVA: 0x15AD1CC
	public void set_minDistance(float value) { }

	// RVA: 0x15AD234
	public float get_maxDistance() { }

	// RVA: 0x15AD284
	public void set_maxDistance(float value) { }

	// RVA: 0x15AD2EC
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x15AD33C
	public void set_rolloffMode(AudioRolloffMode value) { }

	// RVA: 0x15AD3A4
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x15AD444
	public void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x15AD49C
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x15AD544
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x15AD5AC
	public float get_minVolume() { }

	// RVA: 0x15AD620
	public void set_minVolume(float value) { }

	// RVA: 0x15AD6B4
	public float get_maxVolume() { }

	// RVA: 0x15AD728
	public void set_maxVolume(float value) { }

	// RVA: 0x15AD7BC
	public float get_rolloffFactor() { }

	// RVA: 0x15AD830
	public void set_rolloffFactor(float value) { }

	// RVA: 0x15AD8C4
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x15AD924
	public bool GetSpatializerFloat(int index, float value) { }

	// RVA: 0x15AD97C
	public bool GetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x15AD9D4
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x15ADA34
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioReverbZone
{
	// Methods

	// RVA: 0x15ADA3C
	public float get_minDistance() { }

	// RVA: 0x15ADA8C
	public void set_minDistance(float value) { }

	// RVA: 0x15ADAF4
	public float get_maxDistance() { }

	// RVA: 0x15ADB44
	public void set_maxDistance(float value) { }

	// RVA: 0x15ADBAC
	public AudioReverbPreset get_reverbPreset() { }

	// RVA: 0x15ADBFC
	public void set_reverbPreset(AudioReverbPreset value) { }

	// RVA: 0x15ADC64
	public int get_room() { }

	// RVA: 0x15ADCB4
	public void set_room(int value) { }

	// RVA: 0x15ADD1C
	public int get_roomHF() { }

	// RVA: 0x15ADD6C
	public void set_roomHF(int value) { }

	// RVA: 0x15ADDD4
	public int get_roomLF() { }

	// RVA: 0x15ADE24
	public void set_roomLF(int value) { }

	// RVA: 0x15ADE8C
	public float get_decayTime() { }

	// RVA: 0x15ADEDC
	public void set_decayTime(float value) { }

	// RVA: 0x15ADF44
	public float get_decayHFRatio() { }

	// RVA: 0x15ADF94
	public void set_decayHFRatio(float value) { }

	// RVA: 0x15ADFFC
	public int get_reflections() { }

	// RVA: 0x15AE04C
	public void set_reflections(int value) { }

	// RVA: 0x15AE0B4
	public float get_reflectionsDelay() { }

	// RVA: 0x15AE104
	public void set_reflectionsDelay(float value) { }

	// RVA: 0x15AE16C
	public int get_reverb() { }

	// RVA: 0x15AE1BC
	public void set_reverb(int value) { }

	// RVA: 0x15AE224
	public float get_reverbDelay() { }

	// RVA: 0x15AE274
	public void set_reverbDelay(float value) { }

	// RVA: 0x15AE2DC
	public float get_HFReference() { }

	// RVA: 0x15AE32C
	public void set_HFReference(float value) { }

	// RVA: 0x15AE394
	public float get_LFReference() { }

	// RVA: 0x15AE3E4
	public void set_LFReference(float value) { }

	// RVA: 0x15AE44C
	public float get_roomRolloffFactor() { }

	// RVA: 0x15AE4C0
	public void set_roomRolloffFactor(float value) { }

	// RVA: 0x15AE554
	public float get_diffusion() { }

	// RVA: 0x15AE5A4
	public void set_diffusion(float value) { }

	// RVA: 0x15AE60C
	public float get_density() { }

	// RVA: 0x15AE65C
	public void set_density(float value) { }

	// RVA: 0x15AE6C4
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioLowPassFilter
{
	// Methods

	// RVA: 0x15AE6CC
	private AnimationCurve GetCustomLowpassLevelCurveCopy() { }

	// RVA: 0x15AE71C
	private static void SetCustomLowpassLevelCurveHelper(AudioLowPassFilter source, AnimationCurve curve) { }

	// RVA: 0x15AE784
	public AnimationCurve get_customCutoffCurve() { }

	// RVA: 0x15AE7D4
	public void set_customCutoffCurve(AnimationCurve value) { }

	// RVA: 0x15AE83C
	public float get_cutoffFrequency() { }

	// RVA: 0x15AE88C
	public void set_cutoffFrequency(float value) { }

	// RVA: 0x15AE8F4
	public float get_lowpassResonanceQ() { }

	// RVA: 0x15AE944
	public void set_lowpassResonanceQ(float value) { }

	// RVA: 0x15AE9AC
	public void .ctor() { }

}

// Namespace: 
public sealed class SampleFramesHandler
{
	// Methods

	// RVA: 0x15AE9FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15AEB20
	public virtual void Invoke(AudioSampleProvider provider, UInt32 sampleFrameCount) { }

}

// Namespace: UnityEngine.Experimental.Audio
public class AudioSampleProvider
{
	// Fields
	private SampleFramesHandler sampleFramesAvailable; // 0x10
	private SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	// RVA: 0x15AE9B4
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	// RVA: 0x15AE9D8
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

// Namespace: UnityEngine.Audio
public struct AudioClipPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x15AEB34
	public PlayableHandle GetHandle() { }

	// RVA: 0x15AEB40
	public bool Equals(AudioClipPlayable other) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixer
{
	// Methods

	// RVA: 0x15AEBC4
	public bool SetFloat(string name, float value) { }

	// RVA: 0x15AEC24
	public bool GetFloat(string name, float value) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixerGroup
{
	// Methods

	// RVA: 0x15AEC7C
	internal void .ctor() { }

}

// Namespace: UnityEngine.Audio
public struct AudioMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x15AED04
	public PlayableHandle GetHandle() { }

	// RVA: 0x15AED10
	public bool Equals(AudioMixerPlayable other) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixerSnapshot
{}

// Namespace: UnityEngine.Audio
public struct AudioPlayableOutput
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x10
}


