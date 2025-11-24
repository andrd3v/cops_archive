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

	// RVA: 0x159B5A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x159B64C
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

	// RVA: 0x159B660
	public static bool get_muteState() { }

	// RVA: 0x159B6AC
	private static void set_muteState(bool value) { }

	// RVA: 0x159B704
	public static bool get_stopAudioOutputOnMute() { }

	// RVA: 0x159B750
	internal static void InvokeOnMuteStateChanged(bool mute) { }

	// RVA: 0x159B9A4
	internal static bool InvokeIsStopAudioOutputOnMuteEnabled() { }

	// RVA: 0x159B964
	public static void StartAudioOutput() { }

	// RVA: 0x159B924
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

	// RVA: 0x159B3DC
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	// RVA: 0x159B458
	internal static void InvokeOnAudioSystemShuttingDown() { }

	// RVA: 0x159B4C0
	internal static void InvokeOnAudioSystemStartedUp() { }

	// RVA: 0x159B528
	internal static bool StartAudioOutput() { }

	// RVA: 0x159B568
	internal static bool StopAudioOutput() { }

}

// Namespace: 
public sealed class PCMReaderCallback
{
	// Methods

	// RVA: 0x159BB14
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x159BBC8
	public virtual void Invoke(float[] data) { }

}

// Namespace: 
public sealed class PCMSetPositionCallback
{
	// Methods

	// RVA: 0x159BBDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x159BC80
	public virtual void Invoke(int position) { }

}

// Namespace: UnityEngine
public sealed class AudioClip
{
	// Fields
	private PCMReaderCallback m_PCMReaderCallback; // 0x18
	private PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Methods

	// RVA: 0x159B9F0
	private void .ctor() { }

	// RVA: 0x159BA8C
	public float get_length() { }

	// RVA: 0x159BADC
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	// RVA: 0x159BAF8
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

// Namespace: UnityEngine
public class AudioBehaviour
{
	// Methods

	// RVA: 0x159BC94
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioListener
{
	// Methods

	// RVA: 0x159BC9C
	private static void GetOutputDataHelper(float[] samples, int channel) { }

	// RVA: 0x159BD04
	private static void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x159BD5C
	public static float get_volume() { }

	// RVA: 0x159BD9C
	public static void set_volume(float value) { }

	// RVA: 0x159BDF4
	public static bool get_pause() { }

	// RVA: 0x159BE34
	public static void set_pause(bool value) { }

	// RVA: 0x159BE84
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x159BED4
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x159BF3C
	public static float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x159BFCC
	public static void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x159C034
	public static float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x159C0D4
	public static void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x159C12C
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioSource
{
	// Methods

	// RVA: 0x159C134
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x159C184
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x159C1EC
	private static void PlayHelper(AudioSource source, UInt64 delay) { }

	// RVA: 0x159C254
	private void Play(Double delay) { }

	// RVA: 0x159C2BC
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x159C31C
	private void Stop(bool stopOneShots) { }

	// RVA: 0x159C384
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x159C3DC
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x159C444
	private static void GetOutputDataHelper(AudioSource source, float[] samples, int channel) { }

	// RVA: 0x159C49C
	private static void GetSpectrumDataHelper(AudioSource source, float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x159C504
	public float get_volume() { }

	// RVA: 0x159C554
	public void set_volume(float value) { }

	// RVA: 0x159C5BC
	public float get_pitch() { }

	// RVA: 0x159C60C
	public void set_pitch(float value) { }

	// RVA: 0x159C674
	public float get_time() { }

	// RVA: 0x159C6C4
	public void set_time(float value) { }

	// RVA: 0x159C72C
	public int get_timeSamples() { }

	// RVA: 0x159C77C
	public void set_timeSamples(int value) { }

	// RVA: 0x159C7E4
	public AudioClip get_clip() { }

	// RVA: 0x159C834
	public void set_clip(AudioClip value) { }

	// RVA: 0x159C89C
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x159C8EC
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	// RVA: 0x159C954
	public void Play() { }

	// RVA: 0x159C9AC
	public void Play(UInt64 delay) { }

	// RVA: 0x159CA14
	public void PlayDelayed(float delay) { }

	// RVA: 0x159CA7C
	public void PlayScheduled(Double time) { }

	// RVA: 0x159CADC
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x159CAE4
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x159CC04
	public void SetScheduledStartTime(Double time) { }

	// RVA: 0x159CC6C
	public void SetScheduledEndTime(Double time) { }

	// RVA: 0x159CCD4
	public void Stop() { }

	// RVA: 0x159CD2C
	public void Pause() { }

	// RVA: 0x159CD7C
	public void UnPause() { }

	// RVA: 0x159CDCC
	public bool get_isPlaying() { }

	// RVA: 0x159CE1C
	public bool get_isVirtual() { }

	// RVA: 0x159CE6C
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x159CE74
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x159D1BC
	public bool get_loop() { }

	// RVA: 0x159D20C
	public void set_loop(bool value) { }

	// RVA: 0x159D274
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x159D2C4
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x159D32C
	public bool get_playOnAwake() { }

	// RVA: 0x159D37C
	public void set_playOnAwake(bool value) { }

	// RVA: 0x159D3E4
	public bool get_ignoreListenerPause() { }

	// RVA: 0x159D434
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x159D49C
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x159D4EC
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x159D554
	public float get_panStereo() { }

	// RVA: 0x159D5A4
	public void set_panStereo(float value) { }

	// RVA: 0x159D60C
	public float get_spatialBlend() { }

	// RVA: 0x159D154
	public void set_spatialBlend(float value) { }

	// RVA: 0x159D65C
	public bool get_spatialize() { }

	// RVA: 0x159D6AC
	public void set_spatialize(bool value) { }

	// RVA: 0x159D714
	public bool get_spatializePostEffects() { }

	// RVA: 0x159D764
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x159D7CC
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x159D824
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x159D88C
	public float get_reverbZoneMix() { }

	// RVA: 0x159D8DC
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x159D944
	public bool get_bypassEffects() { }

	// RVA: 0x159D994
	public void set_bypassEffects(bool value) { }

	// RVA: 0x159D9FC
	public bool get_bypassListenerEffects() { }

	// RVA: 0x159DA4C
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x159DAB4
	public bool get_bypassReverbZones() { }

	// RVA: 0x159DB04
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x159DB6C
	public float get_dopplerLevel() { }

	// RVA: 0x159DBBC
	public void set_dopplerLevel(float value) { }

	// RVA: 0x159DC24
	public float get_spread() { }

	// RVA: 0x159DC74
	public void set_spread(float value) { }

	// RVA: 0x159DCDC
	public int get_priority() { }

	// RVA: 0x159DD2C
	public void set_priority(int value) { }

	// RVA: 0x159DD94
	public bool get_mute() { }

	// RVA: 0x159DDE4
	public void set_mute(bool value) { }

	// RVA: 0x159DE4C
	public float get_minDistance() { }

	// RVA: 0x159DE9C
	public void set_minDistance(float value) { }

	// RVA: 0x159DF04
	public float get_maxDistance() { }

	// RVA: 0x159DF54
	public void set_maxDistance(float value) { }

	// RVA: 0x159DFBC
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x159E00C
	public void set_rolloffMode(AudioRolloffMode value) { }

	// RVA: 0x159E074
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x159E114
	public void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x159E16C
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x159E214
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x159E27C
	public float get_minVolume() { }

	// RVA: 0x159E2F0
	public void set_minVolume(float value) { }

	// RVA: 0x159E384
	public float get_maxVolume() { }

	// RVA: 0x159E3F8
	public void set_maxVolume(float value) { }

	// RVA: 0x159E48C
	public float get_rolloffFactor() { }

	// RVA: 0x159E500
	public void set_rolloffFactor(float value) { }

	// RVA: 0x159E594
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x159E5F4
	public bool GetSpatializerFloat(int index, float value) { }

	// RVA: 0x159E64C
	public bool GetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x159E6A4
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x159E704
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioReverbZone
{
	// Methods

	// RVA: 0x159E70C
	public float get_minDistance() { }

	// RVA: 0x159E75C
	public void set_minDistance(float value) { }

	// RVA: 0x159E7C4
	public float get_maxDistance() { }

	// RVA: 0x159E814
	public void set_maxDistance(float value) { }

	// RVA: 0x159E87C
	public AudioReverbPreset get_reverbPreset() { }

	// RVA: 0x159E8CC
	public void set_reverbPreset(AudioReverbPreset value) { }

	// RVA: 0x159E934
	public int get_room() { }

	// RVA: 0x159E984
	public void set_room(int value) { }

	// RVA: 0x159E9EC
	public int get_roomHF() { }

	// RVA: 0x159EA3C
	public void set_roomHF(int value) { }

	// RVA: 0x159EAA4
	public int get_roomLF() { }

	// RVA: 0x159EAF4
	public void set_roomLF(int value) { }

	// RVA: 0x159EB5C
	public float get_decayTime() { }

	// RVA: 0x159EBAC
	public void set_decayTime(float value) { }

	// RVA: 0x159EC14
	public float get_decayHFRatio() { }

	// RVA: 0x159EC64
	public void set_decayHFRatio(float value) { }

	// RVA: 0x159ECCC
	public int get_reflections() { }

	// RVA: 0x159ED1C
	public void set_reflections(int value) { }

	// RVA: 0x159ED84
	public float get_reflectionsDelay() { }

	// RVA: 0x159EDD4
	public void set_reflectionsDelay(float value) { }

	// RVA: 0x159EE3C
	public int get_reverb() { }

	// RVA: 0x159EE8C
	public void set_reverb(int value) { }

	// RVA: 0x159EEF4
	public float get_reverbDelay() { }

	// RVA: 0x159EF44
	public void set_reverbDelay(float value) { }

	// RVA: 0x159EFAC
	public float get_HFReference() { }

	// RVA: 0x159EFFC
	public void set_HFReference(float value) { }

	// RVA: 0x159F064
	public float get_LFReference() { }

	// RVA: 0x159F0B4
	public void set_LFReference(float value) { }

	// RVA: 0x159F11C
	public float get_roomRolloffFactor() { }

	// RVA: 0x159F190
	public void set_roomRolloffFactor(float value) { }

	// RVA: 0x159F224
	public float get_diffusion() { }

	// RVA: 0x159F274
	public void set_diffusion(float value) { }

	// RVA: 0x159F2DC
	public float get_density() { }

	// RVA: 0x159F32C
	public void set_density(float value) { }

	// RVA: 0x159F394
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioLowPassFilter
{
	// Methods

	// RVA: 0x159F39C
	private AnimationCurve GetCustomLowpassLevelCurveCopy() { }

	// RVA: 0x159F3EC
	private static void SetCustomLowpassLevelCurveHelper(AudioLowPassFilter source, AnimationCurve curve) { }

	// RVA: 0x159F454
	public AnimationCurve get_customCutoffCurve() { }

	// RVA: 0x159F4A4
	public void set_customCutoffCurve(AnimationCurve value) { }

	// RVA: 0x159F50C
	public float get_cutoffFrequency() { }

	// RVA: 0x159F55C
	public void set_cutoffFrequency(float value) { }

	// RVA: 0x159F5C4
	public float get_lowpassResonanceQ() { }

	// RVA: 0x159F614
	public void set_lowpassResonanceQ(float value) { }

	// RVA: 0x159F67C
	public void .ctor() { }

}

// Namespace: 
public sealed class SampleFramesHandler
{
	// Methods

	// RVA: 0x159F6CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x159F7F0
	public virtual void Invoke(AudioSampleProvider provider, UInt32 sampleFrameCount) { }

}

// Namespace: UnityEngine.Experimental.Audio
public class AudioSampleProvider
{
	// Fields
	private SampleFramesHandler sampleFramesAvailable; // 0x10
	private SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	// RVA: 0x159F684
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	// RVA: 0x159F6A8
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

// Namespace: UnityEngine.Audio
public struct AudioClipPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x159F804
	public PlayableHandle GetHandle() { }

	// RVA: 0x159F810
	public bool Equals(AudioClipPlayable other) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixer
{
	// Methods

	// RVA: 0x159F894
	public bool SetFloat(string name, float value) { }

	// RVA: 0x159F8F4
	public bool GetFloat(string name, float value) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixerGroup
{
	// Methods

	// RVA: 0x159F94C
	internal void .ctor() { }

}

// Namespace: UnityEngine.Audio
public struct AudioMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x159F9D4
	public PlayableHandle GetHandle() { }

	// RVA: 0x159F9E0
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


