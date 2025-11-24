// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Networking
public enum DownloadedTextureFlags
{
	// Fields
	public UInt32 value__; // 0x10
	public const DownloadedTextureFlags None = 0;
	public const DownloadedTextureFlags Readable = 1;
	public const DownloadedTextureFlags MipmapChain = 2;
	public const DownloadedTextureFlags LinearColorSpace = 4;
}

// Namespace: UnityEngine.Networking
public struct DownloadedTextureParams
{
	// Fields
	public DownloadedTextureFlags flags; // 0x10
	public int mipmapCount; // 0x14

	// Methods

	// RVA: 0x1A5F784
	public static DownloadedTextureParams get_Default() { }

	// RVA: 0x1A5F78C
	public void set_readable(bool value) { }

	// RVA: 0x1A5F7A0
	private void SetFlags(DownloadedTextureFlags flgs, bool add) { }

}

// Namespace: 
internal static class BindingsMarshaller
{
	// Methods

	// RVA: 0x1A5FB24
	public static IntPtr ConvertToNative(DownloadHandlerTexture handler) { }

}

// Namespace: UnityEngine.Networking
public sealed class DownloadHandlerTexture
{
	// Fields
	private Unity.Collections.NativeArray<System.Byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x1A5F7BC
	private static IntPtr Create(DownloadHandlerTexture obj, DownloadedTextureParams parameters) { }

	// RVA: 0x1A5F878
	private void InternalCreateTexture(DownloadedTextureParams parameters) { }

	// RVA: 0x1A5F8D0
	public void .ctor(bool readable) { }

	// RVA: 0x1A5F940
	protected override Unity.Collections.NativeArray<System.Byte> GetNativeData() { }

	// RVA: 0x1A5F94C
	public override void Dispose() { }

	// RVA: 0x1A5F97C
	public Texture2D get_texture() { }

	// RVA: 0x1A5FA28
	private Texture2D InternalGetTextureNative() { }

	// RVA: 0x1A5F810
	private static IntPtr Create_Injected(DownloadHandlerTexture obj, DownloadedTextureParams parameters) { }

	// RVA: 0x1A5FAD4
	private static IntPtr InternalGetTextureNative_Injected(IntPtr _unity_self) { }

}

// Namespace: UnityEngine.Networking
public static class UnityWebRequestTexture
{
	// Methods

	// RVA: 0x1A5FB40
	public static UnityWebRequest GetTexture(string uri) { }

	// RVA: 0x1A5FB48
	public static UnityWebRequest GetTexture(string uri, bool nonReadable) { }

}


