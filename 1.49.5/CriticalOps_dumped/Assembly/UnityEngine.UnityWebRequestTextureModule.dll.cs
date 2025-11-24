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

	// RVA: 0x18DC4E0
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x18DC548
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x18DC5A0
	public void .ctor(bool readable) { }

	// RVA: 0x18DC608
	protected override Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x18DC614
	public override void Dispose() { }

	// RVA: 0x18DC644
	public Texture2D get_texture() { }

	// RVA: 0x18DC694
	private Texture2D InternalGetTextureNative() { }

}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestTexture
{
	// Methods

	// RVA: 0x18DC6E4
	public static UnityWebRequest GetTexture(string uri) { }

	// RVA: 0x18DC6EC
	public static UnityWebRequest GetTexture(string uri, bool nonReadable) { }

}


