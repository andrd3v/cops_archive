// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerTexture 
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_NativeData; // 0x18
	private bool mNonReadable; // 0x28

	// Methods

	// RVA: 0x17E81B0
	IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x17E8218
	void InternalCreateTexture(bool readable) { }

	// RVA: 0x17E8270
	void .ctor(bool readable) { }

	// RVA: 0x17E82D8
	Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x17E82E4
	void Dispose() { }

	// RVA: 0x17E8314
	Texture2D get_texture() { }

	// RVA: 0x17E8364
	Texture2D InternalGetTextureNative() { }

}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestTexture 
{
	// Methods

	// RVA: 0x17E83B4
	UnityWebRequest GetTexture(string uri) { }

	// RVA: 0x17E83BC
	UnityWebRequest GetTexture(string uri, bool nonReadable) { }

}


