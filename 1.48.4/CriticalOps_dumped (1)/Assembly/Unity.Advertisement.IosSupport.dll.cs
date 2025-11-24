// Namespace: 
internal class <Module> 
{}

// Namespace: 
public sealed class RequestAuthorizationTrackingCompleteHandler 
{
	// Methods

	// RVA: 0x1342E08
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x1342F38
	internal void Invoke(int status) { }

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

	// RVA: 0x1342C24
	void InterfaceTrackingAuthorizationRequest(RequestAuthorizationTrackingCompleteHandler callback) { }

	// RVA: 0x1342C38
	int InterfaceGetTrackingAuthorizationStatus() { }

	// RVA: 0x1342C3C
	void RequestAuthorizationTracking(RequestAuthorizationTrackingCompleteHandler callback) { }

	// RVA: 0x1342EAC
	AuthorizationTrackingStatus GetAuthorizationTrackingStatus() { }

	// RVA: 0x1342B9C
	void AppTransparencyTrackingRequestCompleted(int status) { }

}


