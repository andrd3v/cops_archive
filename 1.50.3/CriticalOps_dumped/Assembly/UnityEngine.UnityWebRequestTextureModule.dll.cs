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

	// RVA: 0x18FF6B4
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x18FF71C
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x18FF774
	public void .ctor(bool readable) { }

	// RVA: 0x18FF7DC
	protected override Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x18FF7E8
	public override void Dispose() { }

	// RVA: 0x18FF818
	public Texture2D get_texture() { }

	// RVA: 0x18FF868
	private Texture2D InternalGetTextureNative() { }

}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestTexture
{
	// Methods

	// RVA: 0x18FF8B8
	public static UnityWebRequest GetTexture(string uri) { }

	// RVA: 0x18FF8C0
	public static UnityWebRequest GetTexture(string uri, bool nonReadable) { }

}


