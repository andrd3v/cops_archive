// Namespace: 
internal class <Module>
{}

// Namespace: AppleAuth
public struct AppleAuthLoginArgs
{
	// Fields
	public readonly LoginOptions Options; // 0x10
	public readonly string Nonce; // 0x18
	public readonly string State; // 0x20

	// Methods

	// RVA: 0x816C
	public void .ctor(LoginOptions options, string nonce, string state) { }

}

// Namespace: 
private class Entry
{
	// Fields
	public readonly bool IsSingleUseCallback; // 0x10
	public readonly System.Action<System.String> MessageCallback; // 0x18

	// Methods

	// RVA: 0x8F94
	public void .ctor(bool isSingleUseCallback, System.Action<System.String> messageCallback) { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Fields
	public string payload; // 0x10
	public System.Action<System.String> callback; // 0x18

	// Methods

	// RVA: 0x8ED4
	public void .ctor() { }

	// RVA: 0x9134
	internal void <ScheduleCallback>b__0() { }

}

// Namespace: 
private static class CallbackHandler
{
	// Fields
	private static readonly object SyncLock; // 0x0
	private static readonly System.Collections.Generic.Dictionary<System.UInt32,AppleAuth.AppleAuthManager.CallbackHandler.Entry> CallbackDictionary; // 0x8
	private static readonly System.Collections.Generic.List<System.Action> ScheduledActions; // 0x10
	private static UInt32 _callbackId; // 0x18
	private static bool _initialized; // 0x1C
	private static UInt32 _credentialsRevokedCallbackId; // 0x20
	private static System.Action<System.String> _nativeCredentialsRevoked; // 0x28

	// Methods

	// RVA: 0x8BE8
	public static void ScheduleCallback(UInt32 requestId, string payload) { }

	// RVA: 0x89F4
	public static void ExecutePendingCallbacks() { }

	// RVA: 0x8404
	public static UInt32 AddMessageCallback(bool isSingleUse, System.Action<System.String> messageCallback) { }

	// RVA: 0x8FD8
	private static void .cctor() { }

}

// Namespace: 
public sealed class NativeMessageHandlerCallbackDelegate
{
	// Methods

	// RVA: 0x8EDC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x9334
	public virtual void Invoke(UInt32 requestId, string payload) { }

}

// Namespace: 
private static class PInvoke
{
	// Methods

	// RVA: 0x9160
	public static void NativeMessageHandlerCallback(UInt32 requestId, string payload) { }

	// RVA: 0x8240
	public static extern bool AppleAuth_IsCurrentPlatformSupported() { }

	// RVA: 0x8F80
	public static extern void AppleAuth_SetupNativeMessageHandlerCallback(NativeMessageHandlerCallbackDelegate callback) { }

	// RVA: 0x8954
	public static extern void AppleAuth_GetCredentialState(UInt32 requestId, string userId) { }

	// RVA: 0x87A0
	public static extern void AppleAuth_LoginWithAppleId(UInt32 requestId, int loginOptions, string nonceCStr, string stateCStr) { }

	// RVA: 0x81FC
	public static extern void AppleAuth_LogMessage(string messageCStr) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public AppleAuthManager <>4__this; // 0x10
	public System.Action<AppleAuth.Interfaces.IAppleError> errorCallback; // 0x18
	public System.Action<AppleAuth.Enums.CredentialState> successCallback; // 0x20

	// Methods

	// RVA: 0x894C
	public void .ctor() { }

	// RVA: 0x9348
	internal void <GetCredentialState>b__0(string payload) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public AppleAuthManager <>4__this; // 0x10
	public System.Action<AppleAuth.Interfaces.IAppleError> errorCallback; // 0x18
	public System.Action<AppleAuth.Interfaces.ICredential> successCallback; // 0x20

	// Methods

	// RVA: 0x83FC
	public void .ctor() { }

	// RVA: 0x95B4
	internal void <LoginWithAppleId>b__0(string payload) { }

}

// Namespace: AppleAuth
public class AppleAuthManager
{
	// Fields
	private readonly IPayloadDeserializer _payloadDeserializer; // 0x10

	// Methods

	// RVA: 0x81A8
	private static void .cctor() { }

	// RVA: 0x8224
	public static bool get_IsCurrentPlatformSupported() { }

	// RVA: 0x825C
	public void .ctor(IPayloadDeserializer payloadDeserializer) { }

	// RVA: 0x8290
	public void LoginWithAppleId(AppleAuthLoginArgs loginArgs, System.Action<AppleAuth.Interfaces.ICredential> successCallback, System.Action<AppleAuth.Interfaces.IAppleError> errorCallback) { }

	// RVA: 0x8804
	public void GetCredentialState(string userId, System.Action<AppleAuth.Enums.CredentialState> successCallback, System.Action<AppleAuth.Interfaces.IAppleError> errorCallback) { }

	// RVA: 0x898C
	public void Update() { }

}

// Namespace: AppleAuth
public interface IAppleAuthManager
{
	// Methods

	// RVA: -1
	public abstract void LoginWithAppleId(AppleAuthLoginArgs loginArgs, System.Action<AppleAuth.Interfaces.ICredential> successCallback, System.Action<AppleAuth.Interfaces.IAppleError> errorCallback) { }

	// RVA: -1
	public abstract void GetCredentialState(string userId, System.Action<AppleAuth.Enums.CredentialState> successCallback, System.Action<AppleAuth.Interfaces.IAppleError> errorCallback) { }

	// RVA: -1
	public abstract void Update() { }

}

// Namespace: AppleAuth.Native
[Serializable]
internal class AppleError
{
	// Fields
	public int _code; // 0x10
	public string _domain; // 0x18
	public string _localizedDescription; // 0x20
	public string[] _localizedRecoveryOptions; // 0x28
	public string _localizedRecoverySuggestion; // 0x30
	public string _localizedFailureReason; // 0x38

	// Methods

	// RVA: 0x97D8
	public void OnBeforeSerialize() { }

	// RVA: 0x97DC
	public void OnAfterDeserialize() { }

	// RVA: 0x9944
	public override string ToString() { }

	// RVA: 0x99D0
	public void .ctor() { }

}

// Namespace: AppleAuth.Native
[Serializable]
internal class AppleIDCredential
{
	// Fields
	public string _base64IdentityToken; // 0x10
	public string _base64AuthorizationCode; // 0x18
	public string _state; // 0x20
	public string _user; // 0x28
	public string[] _authorizedScopes; // 0x30
	public bool _hasFullName; // 0x38
	public FullPersonName _fullName; // 0x40
	public string _email; // 0x48
	private Byte[] _identityToken; // 0x50
	private Byte[] _authorizationCode; // 0x58

	// Methods

	// RVA: 0x99D8
	public Byte[] get_IdentityToken() { }

	// RVA: 0x99E0
	public string get_User() { }

	// RVA: 0x99E8
	public void OnBeforeSerialize() { }

	// RVA: 0x99EC
	public void OnAfterDeserialize() { }

	// RVA: 0x9D74
	public void .ctor() { }

}

// Namespace: AppleAuth.Native
[Serializable]
internal class CredentialStateResponse
{
	// Fields
	public bool _hasCredentialState; // 0x10
	public bool _hasError; // 0x11
	public int _credentialState; // 0x14
	public AppleError _error; // 0x18

	// Methods

	// RVA: 0x9D7C
	public CredentialState get_CredentialState() { }

	// RVA: 0x9D84
	public IAppleError get_Error() { }

	// RVA: 0x9D8C
	public void OnBeforeSerialize() { }

	// RVA: 0x9D90
	public void OnAfterDeserialize() { }

	// RVA: 0x9E0C
	public void .ctor() { }

}

// Namespace: AppleAuth.Native
[Serializable]
internal class FullPersonName
{
	// Fields
	public bool _hasPhoneticRepresentation; // 0x40
	public PersonName _phoneticRepresentation; // 0x48

	// Methods

	// RVA: 0x9E14
	public override void OnAfterDeserialize() { }

	// RVA: 0x9FCC
	public void .ctor() { }

}

// Namespace: AppleAuth.Native
[Serializable]
internal class LoginWithAppleIdResponse
{
	// Fields
	public bool _hasAppleIdCredential; // 0x10
	public bool _hasPasswordCredential; // 0x11
	public bool _hasError; // 0x12
	public AppleIDCredential _appleIdCredential; // 0x18
	public PasswordCredential _passwordCredential; // 0x20
	public AppleError _error; // 0x28

	// Methods

	// RVA: 0x9FDC
	public IAppleError get_Error() { }

	// RVA: 0x9FE4
	public IAppleIDCredential get_AppleIDCredential() { }

	// RVA: 0x9FEC
	public void OnBeforeSerialize() { }

	// RVA: 0x9FF0
	public void OnAfterDeserialize() { }

	// RVA: 0xA098
	public void .ctor() { }

}

// Namespace: AppleAuth.Native
[Serializable]
internal class PasswordCredential
{
	// Fields
	public string _user; // 0x10
	public string _password; // 0x18

	// Methods

	// RVA: 0xA0A0
	public string get_User() { }

	// RVA: 0xA0A8
	public void OnBeforeSerialize() { }

	// RVA: 0xA0AC
	public void OnAfterDeserialize() { }

	// RVA: 0xA114
	public void .ctor() { }

}

// Namespace: AppleAuth.Native
public class PayloadDeserializer
{
	// Methods

	// RVA: 0xA11C
	public ICredentialStateResponse DeserializeCredentialStateResponse(string payload) { }

	// RVA: 0xA184
	public ILoginWithAppleIdResponse DeserializeLoginWithAppleIdResponse(string payload) { }

	// RVA: 0xA1EC
	public void .ctor() { }

}

// Namespace: AppleAuth.Native
[Serializable]
internal class PersonName
{
	// Fields
	public string _namePrefix; // 0x10
	public string _givenName; // 0x18
	public string _middleName; // 0x20
	public string _familyName; // 0x28
	public string _nameSuffix; // 0x30
	public string _nickname; // 0x38

	// Methods

	// RVA: 0xA1F4
	public void OnBeforeSerialize() { }

	// RVA: 0x9E74
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x9FD4
	public void .ctor() { }

}

// Namespace: AppleAuth.Native
internal static class SerializationTools
{
	// Methods

	// RVA: 0x9900
	internal static void FixSerializationForString(string originalString) { }

	// RVA: 0x352BD5C
	internal static void FixSerializationForArray(T[] originalArray) { }

	// RVA: 0x352BE9C
	internal static void FixSerializationForObject(T originalObject, bool hasOriginalObject) { }

	// RVA: 0x9BD4
	internal static Byte[] GetBytesFromBase64String(string base64String, string fieldName) { }

}

// Namespace: AppleAuth.Interfaces
public interface IAppleError
{}

// Namespace: AppleAuth.Interfaces
public interface IAppleIDCredential
{
	// Methods

	// RVA: -1
	public abstract Byte[] get_IdentityToken() { }

}

// Namespace: AppleAuth.Interfaces
public interface ICredential
{
	// Methods

	// RVA: -1
	public abstract string get_User() { }

}

// Namespace: AppleAuth.Interfaces
public interface ICredentialStateResponse
{
	// Methods

	// RVA: -1
	public abstract CredentialState get_CredentialState() { }

	// RVA: -1
	public abstract IAppleError get_Error() { }

}

// Namespace: AppleAuth.Interfaces
public interface ILoginWithAppleIdResponse
{
	// Methods

	// RVA: -1
	public abstract IAppleError get_Error() { }

	// RVA: -1
	public abstract IAppleIDCredential get_AppleIDCredential() { }

}

// Namespace: AppleAuth.Interfaces
public interface IPayloadDeserializer
{
	// Methods

	// RVA: -1
	public abstract ICredentialStateResponse DeserializeCredentialStateResponse(string payload) { }

	// RVA: -1
	public abstract ILoginWithAppleIdResponse DeserializeLoginWithAppleIdResponse(string payload) { }

}

// Namespace: AppleAuth.Enums
public enum CredentialState
{
	// Fields
	public int value__; // 0x10
	public const CredentialState Revoked = 0;
	public const CredentialState Authorized = 1;
	public const CredentialState NotFound = 2;
	public const CredentialState Transferred = 3;
}

// Namespace: AppleAuth.Enums
public enum LoginOptions
{
	// Fields
	public int value__; // 0x10
	public const LoginOptions None = 0;
	public const LoginOptions IncludeFullName = 1;
	public const LoginOptions IncludeEmail = 2;
}


