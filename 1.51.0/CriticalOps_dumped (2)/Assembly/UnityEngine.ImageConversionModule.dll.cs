// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine
public static class ImageConversion
{
	// Methods

	// RVA: 0x16CC750
	public static Byte[] EncodeToJPG(Texture2D tex, int quality) { }

	// RVA: 0x16CC90C
	public static Byte[] EncodeToJPG(Texture2D tex) { }

	// RVA: 0x16CC914
	public static bool LoadImage(Texture2D tex, System.ReadOnlySpan<System.Byte> data, bool markNonReadable) { }

	// RVA: 0x16CCA90
	public static bool LoadImage(Texture2D tex, Byte[] data) { }

	// RVA: 0x16CC8B4
	private static void EncodeToJPG_Injected(IntPtr tex, int quality, BlittableArrayWrapper ret) { }

	// RVA: 0x16CCA38
	private static bool LoadImage_Injected(IntPtr tex, ManagedSpanWrapper data, bool markNonReadable) { }

}


