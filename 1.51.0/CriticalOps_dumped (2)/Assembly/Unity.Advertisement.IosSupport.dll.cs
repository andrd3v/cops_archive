// Namespace: 
internal class <Module>
{}

// Namespace: 
public sealed class RequestAuthorizationTrackingCompleteHandler
{
	// Methods

	// RVA: 0x13C3024
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13C3154
	public virtual void Invoke(int status) { }

}

// Namespace: 
public enum AuthorizationTrackingStatus
{
	// Fields
	public int value__; // 0x10
	public const AuthorizationTrackingStatus NOT_DETERMINED = 0;
	public const AuthorizationTrackingStatus RESTRICTED = 1;
	public const AuthorizationTrackingStatus DENIED = 2;
	public const AuthorizationTrackingStatus AUTHORIZED = 3;
}

// Namespace: Unity.Advertisement.IosSupport
public class ATTrackingStatusBinding
{
	// Fields
	private static RequestAuthorizationTrackingCompleteHandler _requestAuthorizationTrackingCompleteCallback; // 0x0

	// Methods

	// RVA: 0x13C2E40
	private static extern void InterfaceTrackingAuthorizationRequest(RequestAuthorizationTrackingCompleteHandler callback) { }

	// RVA: 0x13C2E54
	private static extern int InterfaceGetTrackingAuthorizationStatus() { }

	// RVA: 0x13C2E58
	public static void RequestAuthorizationTracking(RequestAuthorizationTrackingCompleteHandler callback) { }

	// RVA: 0x13C30C8
	public static AuthorizationTrackingStatus GetAuthorizationTrackingStatus() { }

	// RVA: 0x13C2DB8
	public static void AppTransparencyTrackingRequestCompleted(int status) { }

}


