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

	// RVA: 0x18CD270
	private static IntPtr Create(DownloadHandlerTexture obj, bool readable) { }

	// RVA: 0x18CD2D8
	private void InternalCreateTexture(bool readable) { }

	// RVA: 0x18CD330
	public void .ctor(bool readable) { }

	// RVA: 0x18CD398
	protected override Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x18CD3A4
	public override void Dispose() { }

	// RVA: 0x18CD3D4
	public Texture2D get_texture() { }

	// RVA: 0x18CD424
	private Texture2D InternalGetTextureNative() { }

}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestTexture
{
	// Methods

	// RVA: 0x18CD474
	public static UnityWebRequest GetTexture(string uri) { }

	// RVA: 0x18CD47C
	public static UnityWebRequest GetTexture(string uri, bool nonReadable) { }

}


