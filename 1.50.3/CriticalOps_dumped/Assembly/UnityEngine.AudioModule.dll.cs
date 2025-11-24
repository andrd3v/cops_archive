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

	// RVA: 0x15CDAA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15CDB44
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

	// RVA: 0x15CDB58
	public static bool get_muteState() { }

	// RVA: 0x15CDBA4
	private static void set_muteState(bool value) { }

	// RVA: 0x15CDBFC
	public static bool get_stopAudioOutputOnMute() { }

	// RVA: 0x15CDC48
	internal static void InvokeOnMuteStateChanged(bool mute) { }

	// RVA: 0x15CDE9C
	internal static bool InvokeIsStopAudioOutputOnMuteEnabled() { }

	// RVA: 0x15CDE5C
	public static void StartAudioOutput() { }

	// RVA: 0x15CDE1C
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

	// RVA: 0x15CD8D4
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	// RVA: 0x15CD950
	internal static void InvokeOnAudioSystemShuttingDown() { }

	// RVA: 0x15CD9B8
	internal static void InvokeOnAudioSystemStartedUp() { }

	// RVA: 0x15CDA20
	internal static bool StartAudioOutput() { }

	// RVA: 0x15CDA60
	internal static bool StopAudioOutput() { }

}

// Namespace: 
public sealed class PCMReaderCallback
{
	// Methods

	// RVA: 0x15CE00C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15CE0C0
	public virtual void Invoke(float[] data) { }

}

// Namespace: 
public sealed class PCMSetPositionCallback
{
	// Methods

	// RVA: 0x15CE0D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15CE178
	public virtual void Invoke(int position) { }

}

// Namespace: UnityEngine
public sealed class AudioClip
{
	// Fields
	private PCMReaderCallback m_PCMReaderCallback; // 0x18
	private PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Methods

	// RVA: 0x15CDEE8
	private void .ctor() { }

	// RVA: 0x15CDF84
	public float get_length() { }

	// RVA: 0x15CDFD4
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	// RVA: 0x15CDFF0
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

// Namespace: UnityEngine
public class AudioBehaviour
{
	// Methods

	// RVA: 0x15CE18C
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioListener
{
	// Methods

	// RVA: 0x15CE194
	private static void GetOutputDataHelper(float[] samples, int channel) { }

	// RVA: 0x15CE1FC
	private static void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x15CE254
	public static float get_volume() { }

	// RVA: 0x15CE294
	public static void set_volume(float value) { }

	// RVA: 0x15CE2EC
	public static bool get_pause() { }

	// RVA: 0x15CE32C
	public static void set_pause(bool value) { }

	// RVA: 0x15CE37C
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x15CE3CC
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x15CE434
	public static float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x15CE4C4
	public static void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x15CE52C
	public static float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x15CE5CC
	public static void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x15CE624
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioSource
{
	// Methods

	// RVA: 0x15CE62C
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x15CE67C
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x15CE6E4
	private static void PlayHelper(AudioSource source, UInt64 delay) { }

	// RVA: 0x15CE74C
	private void Play(Double delay) { }

	// RVA: 0x15CE7B4
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x15CE814
	private void Stop(bool stopOneShots) { }

	// RVA: 0x15CE87C
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x15CE8D4
	private static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x15CE93C
	private static void GetOutputDataHelper(AudioSource source, float[] samples, int channel) { }

	// RVA: 0x15CE994
	private static void GetSpectrumDataHelper(AudioSource source, float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x15CE9FC
	public float get_volume() { }

	// RVA: 0x15CEA4C
	public void set_volume(float value) { }

	// RVA: 0x15CEAB4
	public float get_pitch() { }

	// RVA: 0x15CEB04
	public void set_pitch(float value) { }

	// RVA: 0x15CEB6C
	public float get_time() { }

	// RVA: 0x15CEBBC
	public void set_time(float value) { }

	// RVA: 0x15CEC24
	public int get_timeSamples() { }

	// RVA: 0x15CEC74
	public void set_timeSamples(int value) { }

	// RVA: 0x15CECDC
	public AudioClip get_clip() { }

	// RVA: 0x15CED2C
	public void set_clip(AudioClip value) { }

	// RVA: 0x15CED94
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x15CEDE4
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	// RVA: 0x15CEE4C
	public void Play() { }

	// RVA: 0x15CEEA4
	public void Play(UInt64 delay) { }

	// RVA: 0x15CEF0C
	public void PlayDelayed(float delay) { }

	// RVA: 0x15CEF74
	public void PlayScheduled(Double time) { }

	// RVA: 0x15CEFD4
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x15CEFDC
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x15CF0FC
	public void SetScheduledStartTime(Double time) { }

	// RVA: 0x15CF164
	public void SetScheduledEndTime(Double time) { }

	// RVA: 0x15CF1CC
	public void Stop() { }

	// RVA: 0x15CF224
	public void Pause() { }

	// RVA: 0x15CF274
	public void UnPause() { }

	// RVA: 0x15CF2C4
	public bool get_isPlaying() { }

	// RVA: 0x15CF314
	public bool get_isVirtual() { }

	// RVA: 0x15CF364
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x15CF36C
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x15CF6B4
	public bool get_loop() { }

	// RVA: 0x15CF704
	public void set_loop(bool value) { }

	// RVA: 0x15CF76C
	public bool get_ignoreListenerVolume() { }

	// RVA: 0x15CF7BC
	public void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x15CF824
	public bool get_playOnAwake() { }

	// RVA: 0x15CF874
	public void set_playOnAwake(bool value) { }

	// RVA: 0x15CF8DC
	public bool get_ignoreListenerPause() { }

	// RVA: 0x15CF92C
	public void set_ignoreListenerPause(bool value) { }

	// RVA: 0x15CF994
	public AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x15CF9E4
	public void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x15CFA4C
	public float get_panStereo() { }

	// RVA: 0x15CFA9C
	public void set_panStereo(float value) { }

	// RVA: 0x15CFB04
	public float get_spatialBlend() { }

	// RVA: 0x15CF64C
	public void set_spatialBlend(float value) { }

	// RVA: 0x15CFB54
	public bool get_spatialize() { }

	// RVA: 0x15CFBA4
	public void set_spatialize(bool value) { }

	// RVA: 0x15CFC0C
	public bool get_spatializePostEffects() { }

	// RVA: 0x15CFC5C
	public void set_spatializePostEffects(bool value) { }

	// RVA: 0x15CFCC4
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x15CFD1C
	public AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x15CFD84
	public float get_reverbZoneMix() { }

	// RVA: 0x15CFDD4
	public void set_reverbZoneMix(float value) { }

	// RVA: 0x15CFE3C
	public bool get_bypassEffects() { }

	// RVA: 0x15CFE8C
	public void set_bypassEffects(bool value) { }

	// RVA: 0x15CFEF4
	public bool get_bypassListenerEffects() { }

	// RVA: 0x15CFF44
	public void set_bypassListenerEffects(bool value) { }

	// RVA: 0x15CFFAC
	public bool get_bypassReverbZones() { }

	// RVA: 0x15CFFFC
	public void set_bypassReverbZones(bool value) { }

	// RVA: 0x15D0064
	public float get_dopplerLevel() { }

	// RVA: 0x15D00B4
	public void set_dopplerLevel(float value) { }

	// RVA: 0x15D011C
	public float get_spread() { }

	// RVA: 0x15D016C
	public void set_spread(float value) { }

	// RVA: 0x15D01D4
	public int get_priority() { }

	// RVA: 0x15D0224
	public void set_priority(int value) { }

	// RVA: 0x15D028C
	public bool get_mute() { }

	// RVA: 0x15D02DC
	public void set_mute(bool value) { }

	// RVA: 0x15D0344
	public float get_minDistance() { }

	// RVA: 0x15D0394
	public void set_minDistance(float value) { }

	// RVA: 0x15D03FC
	public float get_maxDistance() { }

	// RVA: 0x15D044C
	public void set_maxDistance(float value) { }

	// RVA: 0x15D04B4
	public AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x15D0504
	public void set_rolloffMode(AudioRolloffMode value) { }

	// RVA: 0x15D056C
	public float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x15D060C
	public void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x15D0664
	public float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x15D070C
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x15D0774
	public float get_minVolume() { }

	// RVA: 0x15D07E8
	public void set_minVolume(float value) { }

	// RVA: 0x15D087C
	public float get_maxVolume() { }

	// RVA: 0x15D08F0
	public void set_maxVolume(float value) { }

	// RVA: 0x15D0984
	public float get_rolloffFactor() { }

	// RVA: 0x15D09F8
	public void set_rolloffFactor(float value) { }

	// RVA: 0x15D0A8C
	public bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x15D0AEC
	public bool GetSpatializerFloat(int index, float value) { }

	// RVA: 0x15D0B44
	public bool GetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x15D0B9C
	public bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x15D0BFC
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioReverbZone
{
	// Methods

	// RVA: 0x15D0C04
	public float get_minDistance() { }

	// RVA: 0x15D0C54
	public void set_minDistance(float value) { }

	// RVA: 0x15D0CBC
	public float get_maxDistance() { }

	// RVA: 0x15D0D0C
	public void set_maxDistance(float value) { }

	// RVA: 0x15D0D74
	public AudioReverbPreset get_reverbPreset() { }

	// RVA: 0x15D0DC4
	public void set_reverbPreset(AudioReverbPreset value) { }

	// RVA: 0x15D0E2C
	public int get_room() { }

	// RVA: 0x15D0E7C
	public void set_room(int value) { }

	// RVA: 0x15D0EE4
	public int get_roomHF() { }

	// RVA: 0x15D0F34
	public void set_roomHF(int value) { }

	// RVA: 0x15D0F9C
	public int get_roomLF() { }

	// RVA: 0x15D0FEC
	public void set_roomLF(int value) { }

	// RVA: 0x15D1054
	public float get_decayTime() { }

	// RVA: 0x15D10A4
	public void set_decayTime(float value) { }

	// RVA: 0x15D110C
	public float get_decayHFRatio() { }

	// RVA: 0x15D115C
	public void set_decayHFRatio(float value) { }

	// RVA: 0x15D11C4
	public int get_reflections() { }

	// RVA: 0x15D1214
	public void set_reflections(int value) { }

	// RVA: 0x15D127C
	public float get_reflectionsDelay() { }

	// RVA: 0x15D12CC
	public void set_reflectionsDelay(float value) { }

	// RVA: 0x15D1334
	public int get_reverb() { }

	// RVA: 0x15D1384
	public void set_reverb(int value) { }

	// RVA: 0x15D13EC
	public float get_reverbDelay() { }

	// RVA: 0x15D143C
	public void set_reverbDelay(float value) { }

	// RVA: 0x15D14A4
	public float get_HFReference() { }

	// RVA: 0x15D14F4
	public void set_HFReference(float value) { }

	// RVA: 0x15D155C
	public float get_LFReference() { }

	// RVA: 0x15D15AC
	public void set_LFReference(float value) { }

	// RVA: 0x15D1614
	public float get_roomRolloffFactor() { }

	// RVA: 0x15D1688
	public void set_roomRolloffFactor(float value) { }

	// RVA: 0x15D171C
	public float get_diffusion() { }

	// RVA: 0x15D176C
	public void set_diffusion(float value) { }

	// RVA: 0x15D17D4
	public float get_density() { }

	// RVA: 0x15D1824
	public void set_density(float value) { }

	// RVA: 0x15D188C
	public void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioLowPassFilter
{
	// Methods

	// RVA: 0x15D1894
	private AnimationCurve GetCustomLowpassLevelCurveCopy() { }

	// RVA: 0x15D18E4
	private static void SetCustomLowpassLevelCurveHelper(AudioLowPassFilter source, AnimationCurve curve) { }

	// RVA: 0x15D194C
	public AnimationCurve get_customCutoffCurve() { }

	// RVA: 0x15D199C
	public void set_customCutoffCurve(AnimationCurve value) { }

	// RVA: 0x15D1A04
	public float get_cutoffFrequency() { }

	// RVA: 0x15D1A54
	public void set_cutoffFrequency(float value) { }

	// RVA: 0x15D1ABC
	public float get_lowpassResonanceQ() { }

	// RVA: 0x15D1B0C
	public void set_lowpassResonanceQ(float value) { }

	// RVA: 0x15D1B74
	public void .ctor() { }

}

// Namespace: 
public sealed class SampleFramesHandler
{
	// Methods

	// RVA: 0x15D1BC4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15D1CE8
	public virtual void Invoke(AudioSampleProvider provider, UInt32 sampleFrameCount) { }

}

// Namespace: UnityEngine.Experimental.Audio
public class AudioSampleProvider
{
	// Fields
	private SampleFramesHandler sampleFramesAvailable; // 0x10
	private SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	// RVA: 0x15D1B7C
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	// RVA: 0x15D1BA0
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

// Namespace: UnityEngine.Audio
public struct AudioClipPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x15D1CFC
	public PlayableHandle GetHandle() { }

	// RVA: 0x15D1D08
	public bool Equals(AudioClipPlayable other) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixer
{
	// Methods

	// RVA: 0x15D1D8C
	public bool SetFloat(string name, float value) { }

	// RVA: 0x15D1DEC
	public bool GetFloat(string name, float value) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixerGroup
{
	// Methods

	// RVA: 0x15D1E44
	internal void .ctor() { }

}

// Namespace: UnityEngine.Audio
public struct AudioMixerPlayable
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x15D1ECC
	public PlayableHandle GetHandle() { }

	// RVA: 0x15D1ED8
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


