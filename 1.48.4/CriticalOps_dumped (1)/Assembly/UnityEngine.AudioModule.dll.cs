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

	// RVA: 0x14B822C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B82D0
	internal void Invoke(bool deviceWasChanged) { }

}

// Namespace: 
public static class Mobile 
{
	// Fields
	private static bool <muteState>k__BackingField; // 0x0
	private static bool _stopAudioOutputOnMute; // 0x1
	private static System.Action<System.Boolean> OnMuteStateChanged; // 0x8

	// Methods

	// RVA: 0x14B82E4
	bool get_muteState() { }

	// RVA: 0x14B8330
	void set_muteState(bool value) { }

	// RVA: 0x14B8388
	bool get_stopAudioOutputOnMute() { }

	// RVA: 0x14B83D4
	void InvokeOnMuteStateChanged(bool mute) { }

	// RVA: 0x14B8628
	bool InvokeIsStopAudioOutputOnMuteEnabled() { }

	// RVA: 0x14B85E8
	void StartAudioOutput() { }

	// RVA: 0x14B85A8
	void StopAudioOutput() { }

}

// Namespace: UnityEngine
public sealed class AudioSettings 
{
	// Fields
	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	private static Action OnAudioSystemShuttingDown; // 0x8
	private static Action OnAudioSystemStartedUp; // 0x10

	// Methods

	// RVA: 0x14B8060
	void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	// RVA: 0x14B80DC
	void InvokeOnAudioSystemShuttingDown() { }

	// RVA: 0x14B8144
	void InvokeOnAudioSystemStartedUp() { }

	// RVA: 0x14B81AC
	bool StartAudioOutput() { }

	// RVA: 0x14B81EC
	bool StopAudioOutput() { }

}

// Namespace: 
public sealed class PCMReaderCallback 
{
	// Methods

	// RVA: 0x14B8798
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B884C
	internal void Invoke(float[] data) { }

}

// Namespace: 
public sealed class PCMSetPositionCallback 
{
	// Methods

	// RVA: 0x14B8860
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14B8904
	internal void Invoke(int position) { }

}

// Namespace: UnityEngine
public sealed class AudioClip 
{
	// Fields
	private PCMReaderCallback m_PCMReaderCallback; // 0x18
	private PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Methods

	// RVA: 0x14B8674
	void .ctor() { }

	// RVA: 0x14B8710
	float get_length() { }

	// RVA: 0x14B8760
	void InvokePCMReaderCallback_Internal(float[] data) { }

	// RVA: 0x14B877C
	void InvokePCMSetPositionCallback_Internal(int position) { }

}

// Namespace: UnityEngine
public class AudioBehaviour 
{
	// Methods

	// RVA: 0x14B8918
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioListener 
{
	// Methods

	// RVA: 0x14B8920
	void GetOutputDataHelper([Out] float[] samples, int channel) { }

	// RVA: 0x14B8988
	void GetSpectrumDataHelper([Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x14B89E0
	float get_volume() { }

	// RVA: 0x14B8A20
	void set_volume(float value) { }

	// RVA: 0x14B8A78
	bool get_pause() { }

	// RVA: 0x14B8AB8
	void set_pause(bool value) { }

	// RVA: 0x14B8B08
	AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x14B8B58
	void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x14B8BC0
	float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x14B8C50
	void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x14B8CB8
	float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x14B8D58
	void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x14B8DB0
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioSource 
{
	// Methods

	// RVA: 0x14B8DB8
	float GetPitch(AudioSource source) { }

	// RVA: 0x14B8E08
	void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x14B8E70
	void PlayHelper(AudioSource source, UInt64 delay) { }

	// RVA: 0x14B8ED8
	void Play(Double delay) { }

	// RVA: 0x14B8F40
	void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x14B8FA0
	void Stop(bool stopOneShots) { }

	// RVA: 0x14B9008
	void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x14B9060
	AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type) { }

	// RVA: 0x14B90C8
	void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	// RVA: 0x14B9120
	void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x14B9188
	float get_volume() { }

	// RVA: 0x14B91D8
	void set_volume(float value) { }

	// RVA: 0x14B9240
	float get_pitch() { }

	// RVA: 0x14B9290
	void set_pitch(float value) { }

	// RVA: 0x14B92F8
	float get_time() { }

	// RVA: 0x14B9348
	void set_time(float value) { }

	// RVA: 0x14B93B0
	int get_timeSamples() { }

	// RVA: 0x14B9400
	void set_timeSamples(int value) { }

	// RVA: 0x14B9468
	AudioClip get_clip() { }

	// RVA: 0x14B94B8
	void set_clip(AudioClip value) { }

	// RVA: 0x14B9520
	AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x14B9570
	void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	// RVA: 0x14B95D8
	void Play() { }

	// RVA: 0x14B9630
	void Play(UInt64 delay) { }

	// RVA: 0x14B9698
	void PlayDelayed(float delay) { }

	// RVA: 0x14B9700
	void PlayScheduled(Double time) { }

	// RVA: 0x14B9760
	void PlayOneShot(AudioClip clip) { }

	// RVA: 0x14B9768
	void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x14B9888
	void SetScheduledStartTime(Double time) { }

	// RVA: 0x14B98F0
	void SetScheduledEndTime(Double time) { }

	// RVA: 0x14B9958
	void Stop() { }

	// RVA: 0x14B99B0
	void Pause() { }

	// RVA: 0x14B9A00
	void UnPause() { }

	// RVA: 0x14B9A50
	bool get_isPlaying() { }

	// RVA: 0x14B9AA0
	bool get_isVirtual() { }

	// RVA: 0x14B9AF0
	void PlayClipAtPoint(AudioClip clip, Vector3 position) { }

	// RVA: 0x14B9AF8
	void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x14B9E40
	bool get_loop() { }

	// RVA: 0x14B9E90
	void set_loop(bool value) { }

	// RVA: 0x14B9EF8
	bool get_ignoreListenerVolume() { }

	// RVA: 0x14B9F48
	void set_ignoreListenerVolume(bool value) { }

	// RVA: 0x14B9FB0
	bool get_playOnAwake() { }

	// RVA: 0x14BA000
	void set_playOnAwake(bool value) { }

	// RVA: 0x14BA068
	bool get_ignoreListenerPause() { }

	// RVA: 0x14BA0B8
	void set_ignoreListenerPause(bool value) { }

	// RVA: 0x14BA120
	AudioVelocityUpdateMode get_velocityUpdateMode() { }

	// RVA: 0x14BA170
	void set_velocityUpdateMode(AudioVelocityUpdateMode value) { }

	// RVA: 0x14BA1D8
	float get_panStereo() { }

	// RVA: 0x14BA228
	void set_panStereo(float value) { }

	// RVA: 0x14BA290
	float get_spatialBlend() { }

	// RVA: 0x14B9DD8
	void set_spatialBlend(float value) { }

	// RVA: 0x14BA2E0
	bool get_spatialize() { }

	// RVA: 0x14BA330
	void set_spatialize(bool value) { }

	// RVA: 0x14BA398
	bool get_spatializePostEffects() { }

	// RVA: 0x14BA3E8
	void set_spatializePostEffects(bool value) { }

	// RVA: 0x14BA450
	void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x14BA4A8
	AnimationCurve GetCustomCurve(AudioSourceCurveType type) { }

	// RVA: 0x14BA510
	float get_reverbZoneMix() { }

	// RVA: 0x14BA560
	void set_reverbZoneMix(float value) { }

	// RVA: 0x14BA5C8
	bool get_bypassEffects() { }

	// RVA: 0x14BA618
	void set_bypassEffects(bool value) { }

	// RVA: 0x14BA680
	bool get_bypassListenerEffects() { }

	// RVA: 0x14BA6D0
	void set_bypassListenerEffects(bool value) { }

	// RVA: 0x14BA738
	bool get_bypassReverbZones() { }

	// RVA: 0x14BA788
	void set_bypassReverbZones(bool value) { }

	// RVA: 0x14BA7F0
	float get_dopplerLevel() { }

	// RVA: 0x14BA840
	void set_dopplerLevel(float value) { }

	// RVA: 0x14BA8A8
	float get_spread() { }

	// RVA: 0x14BA8F8
	void set_spread(float value) { }

	// RVA: 0x14BA960
	int get_priority() { }

	// RVA: 0x14BA9B0
	void set_priority(int value) { }

	// RVA: 0x14BAA18
	bool get_mute() { }

	// RVA: 0x14BAA68
	void set_mute(bool value) { }

	// RVA: 0x14BAAD0
	float get_minDistance() { }

	// RVA: 0x14BAB20
	void set_minDistance(float value) { }

	// RVA: 0x14BAB88
	float get_maxDistance() { }

	// RVA: 0x14BABD8
	void set_maxDistance(float value) { }

	// RVA: 0x14BAC40
	AudioRolloffMode get_rolloffMode() { }

	// RVA: 0x14BAC90
	void set_rolloffMode(AudioRolloffMode value) { }

	// RVA: 0x14BACF8
	float[] GetOutputData(int numSamples, int channel) { }

	// RVA: 0x14BAD98
	void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x14BADF0
	float[] GetSpectrumData(int numSamples, int channel, FFTWindow window) { }

	// RVA: 0x14BAE98
	void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x14BAF00
	float get_minVolume() { }

	// RVA: 0x14BAF74
	void set_minVolume(float value) { }

	// RVA: 0x14BB008
	float get_maxVolume() { }

	// RVA: 0x14BB07C
	void set_maxVolume(float value) { }

	// RVA: 0x14BB110
	float get_rolloffFactor() { }

	// RVA: 0x14BB184
	void set_rolloffFactor(float value) { }

	// RVA: 0x14BB218
	bool SetSpatializerFloat(int index, float value) { }

	// RVA: 0x14BB278
	bool GetSpatializerFloat(int index, out float value) { }

	// RVA: 0x14BB2D0
	bool GetAmbisonicDecoderFloat(int index, out float value) { }

	// RVA: 0x14BB328
	bool SetAmbisonicDecoderFloat(int index, float value) { }

	// RVA: 0x14BB388
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioReverbZone 
{
	// Methods

	// RVA: 0x14BB390
	float get_minDistance() { }

	// RVA: 0x14BB3E0
	void set_minDistance(float value) { }

	// RVA: 0x14BB448
	float get_maxDistance() { }

	// RVA: 0x14BB498
	void set_maxDistance(float value) { }

	// RVA: 0x14BB500
	AudioReverbPreset get_reverbPreset() { }

	// RVA: 0x14BB550
	void set_reverbPreset(AudioReverbPreset value) { }

	// RVA: 0x14BB5B8
	int get_room() { }

	// RVA: 0x14BB608
	void set_room(int value) { }

	// RVA: 0x14BB670
	int get_roomHF() { }

	// RVA: 0x14BB6C0
	void set_roomHF(int value) { }

	// RVA: 0x14BB728
	int get_roomLF() { }

	// RVA: 0x14BB778
	void set_roomLF(int value) { }

	// RVA: 0x14BB7E0
	float get_decayTime() { }

	// RVA: 0x14BB830
	void set_decayTime(float value) { }

	// RVA: 0x14BB898
	float get_decayHFRatio() { }

	// RVA: 0x14BB8E8
	void set_decayHFRatio(float value) { }

	// RVA: 0x14BB950
	int get_reflections() { }

	// RVA: 0x14BB9A0
	void set_reflections(int value) { }

	// RVA: 0x14BBA08
	float get_reflectionsDelay() { }

	// RVA: 0x14BBA58
	void set_reflectionsDelay(float value) { }

	// RVA: 0x14BBAC0
	int get_reverb() { }

	// RVA: 0x14BBB10
	void set_reverb(int value) { }

	// RVA: 0x14BBB78
	float get_reverbDelay() { }

	// RVA: 0x14BBBC8
	void set_reverbDelay(float value) { }

	// RVA: 0x14BBC30
	float get_HFReference() { }

	// RVA: 0x14BBC80
	void set_HFReference(float value) { }

	// RVA: 0x14BBCE8
	float get_LFReference() { }

	// RVA: 0x14BBD38
	void set_LFReference(float value) { }

	// RVA: 0x14BBDA0
	float get_roomRolloffFactor() { }

	// RVA: 0x14BBE14
	void set_roomRolloffFactor(float value) { }

	// RVA: 0x14BBEA8
	float get_diffusion() { }

	// RVA: 0x14BBEF8
	void set_diffusion(float value) { }

	// RVA: 0x14BBF60
	float get_density() { }

	// RVA: 0x14BBFB0
	void set_density(float value) { }

	// RVA: 0x14BC018
	void .ctor() { }

}

// Namespace: UnityEngine
public sealed class AudioLowPassFilter 
{
	// Methods

	// RVA: 0x14BC020
	AnimationCurve GetCustomLowpassLevelCurveCopy() { }

	// RVA: 0x14BC070
	void SetCustomLowpassLevelCurveHelper(AudioLowPassFilter source, AnimationCurve curve) { }

	// RVA: 0x14BC0D8
	AnimationCurve get_customCutoffCurve() { }

	// RVA: 0x14BC128
	void set_customCutoffCurve(AnimationCurve value) { }

	// RVA: 0x14BC190
	float get_cutoffFrequency() { }

	// RVA: 0x14BC1E0
	void set_cutoffFrequency(float value) { }

	// RVA: 0x14BC248
	float get_lowpassResonanceQ() { }

	// RVA: 0x14BC298
	void set_lowpassResonanceQ(float value) { }

	// RVA: 0x14BC300
	void .ctor() { }

}

// Namespace: 
public sealed class SampleFramesHandler 
{
	// Methods

	// RVA: 0x14BC350
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x14BC474
	internal void Invoke(AudioSampleProvider provider, UInt32 sampleFrameCount) { }

}

// Namespace: UnityEngine.Experimental.Audio
public class AudioSampleProvider 
{
	// Fields
	private SampleFramesHandler sampleFramesAvailable; // 0x10
	private SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	// RVA: 0x14BC308
	void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	// RVA: 0x14BC32C
	void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

// Namespace: UnityEngine.Audio
public struct AudioClipPlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x14BC488
	PlayableHandle GetHandle() { }

	// RVA: 0x14BC494
	bool Equals(AudioClipPlayable other) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixer 
{
	// Methods

	// RVA: 0x14BC518
	bool SetFloat(string name, float value) { }

	// RVA: 0x14BC578
	bool GetFloat(string name, out float value) { }

}

// Namespace: UnityEngine.Audio
public class AudioMixerGroup 
{
	// Methods

	// RVA: 0x14BC5D0
	void .ctor() { }

}

// Namespace: UnityEngine.Audio
public struct AudioMixerPlayable 
{
	// Fields
	private PlayableHandle m_Handle; // 0x10

	// Methods

	// RVA: 0x14BC658
	PlayableHandle GetHandle() { }

	// RVA: 0x14BC664
	bool Equals(AudioMixerPlayable other) { }

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


