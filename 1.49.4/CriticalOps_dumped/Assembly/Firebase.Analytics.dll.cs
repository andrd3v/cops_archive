// Namespace: 
internal class <Module>
{}

// Namespace: Firebase.Analytics
public enum ConsentType
{
	// Fields
	public int value__; // 0x10
	public const ConsentType AdStorage = 0;
	public const ConsentType AnalyticsStorage = 1;
	public const ConsentType AdUserData = 2;
	public const ConsentType AdPersonalization = 3;
}

// Namespace: Firebase.Analytics
public enum ConsentStatus
{
	// Fields
	public int value__; // 0x10
	public const ConsentStatus Granted = 0;
	public const ConsentStatus Denied = 1;
}

// Namespace: Firebase.Analytics
public static class FirebaseAnalytics
{
	// Fields
	public static string EventAdImpression; // 0x0
	public static string EventAddPaymentInfo; // 0x8
	public static string EventAddShippingInfo; // 0x10
	public static string EventAddToCart; // 0x18
	public static string EventAddToWishlist; // 0x20
	public static string EventAppOpen; // 0x28
	public static string EventBeginCheckout; // 0x30
	public static string EventCampaignDetails; // 0x38
	public static string EventEarnVirtualCurrency; // 0x40
	public static string EventGenerateLead; // 0x48
	public static string EventJoinGroup; // 0x50
	public static string EventLevelEnd; // 0x58
	public static string EventLevelStart; // 0x60
	public static string EventLevelUp; // 0x68
	public static string EventLogin; // 0x70
	public static string EventPostScore; // 0x78
	public static string EventPurchase; // 0x80
	public static string EventRefund; // 0x88
	public static string EventRemoveFromCart; // 0x90
	public static string EventScreenView; // 0x98
	public static string EventSearch; // 0xA0
	public static string EventSelectContent; // 0xA8
	public static string EventSelectItem; // 0xB0
	public static string EventSelectPromotion; // 0xB8
	public static string EventShare; // 0xC0
	public static string EventSignUp; // 0xC8
	public static string EventSpendVirtualCurrency; // 0xD0
	public static string EventTutorialBegin; // 0xD8
	public static string EventTutorialComplete; // 0xE0
	public static string EventUnlockAchievement; // 0xE8
	public static string EventViewCart; // 0xF0
	public static string EventViewItem; // 0xF8
	public static string EventViewItemList; // 0x100
	public static string EventViewPromotion; // 0x108
	public static string EventViewSearchResults; // 0x110
	public static string ParameterAchievementID; // 0x118
	public static string ParameterAdFormat; // 0x120
	public static string ParameterAdNetworkClickID; // 0x128
	public static string ParameterAdPlatform; // 0x130
	public static string ParameterAdSource; // 0x138
	public static string ParameterAdUnitName; // 0x140
	public static string ParameterAffiliation; // 0x148
	public static string ParameterCP1; // 0x150
	public static string ParameterCampaign; // 0x158
	public static string ParameterCampaignID; // 0x160
	public static string ParameterCharacter; // 0x168
	public static string ParameterContent; // 0x170
	public static string ParameterContentType; // 0x178
	public static string ParameterCoupon; // 0x180
	public static string ParameterCreativeFormat; // 0x188
	public static string ParameterCreativeName; // 0x190
	public static string ParameterCreativeSlot; // 0x198
	public static string ParameterCurrency; // 0x1A0
	public static string ParameterDestination; // 0x1A8
	public static string ParameterDiscount; // 0x1B0
	public static string ParameterEndDate; // 0x1B8
	public static string ParameterExtendSession; // 0x1C0
	public static string ParameterFlightNumber; // 0x1C8
	public static string ParameterGroupID; // 0x1D0
	public static string ParameterIndex; // 0x1D8
	public static string ParameterItemBrand; // 0x1E0
	public static string ParameterItemCategory; // 0x1E8
	public static string ParameterItemCategory2; // 0x1F0
	public static string ParameterItemCategory3; // 0x1F8
	public static string ParameterItemCategory4; // 0x200
	public static string ParameterItemCategory5; // 0x208
	public static string ParameterItemID; // 0x210
	public static string ParameterItemListID; // 0x218
	public static string ParameterItemListName; // 0x220
	public static string ParameterItemName; // 0x228
	public static string ParameterItemVariant; // 0x230
	public static string ParameterItems; // 0x238
	public static string ParameterLevel; // 0x240
	public static string ParameterLevelName; // 0x248
	public static string ParameterLocation; // 0x250
	public static string ParameterLocationID; // 0x258
	public static string ParameterMarketingTactic; // 0x260
	public static string ParameterMedium; // 0x268
	public static string ParameterMethod; // 0x270
	public static string ParameterNumberOfNights; // 0x278
	public static string ParameterNumberOfPassengers; // 0x280
	public static string ParameterNumberOfRooms; // 0x288
	public static string ParameterOrigin; // 0x290
	public static string ParameterPaymentType; // 0x298
	public static string ParameterPrice; // 0x2A0
	public static string ParameterPromotionID; // 0x2A8
	public static string ParameterPromotionName; // 0x2B0
	public static string ParameterQuantity; // 0x2B8
	public static string ParameterScore; // 0x2C0
	public static string ParameterScreenClass; // 0x2C8
	public static string ParameterScreenName; // 0x2D0
	public static string ParameterSearchTerm; // 0x2D8
	public static string ParameterShipping; // 0x2E0
	public static string ParameterShippingTier; // 0x2E8
	public static string ParameterSource; // 0x2F0
	public static string ParameterSourcePlatform; // 0x2F8
	public static string ParameterStartDate; // 0x300
	public static string ParameterSuccess; // 0x308
	public static string ParameterTax; // 0x310
	public static string ParameterTerm; // 0x318
	public static string ParameterTransactionID; // 0x320
	public static string ParameterTravelClass; // 0x328
	public static string ParameterValue; // 0x330
	public static string ParameterVirtualCurrencyName; // 0x338
	public static string UserPropertyAllowAdPersonalizationSignals; // 0x340
	public static string UserPropertySignUpMethod; // 0x348

	// Methods

	// RVA: 0x785194
	public static void LogEvent(string name, string parameterName, string parameterValue) { }

	// RVA: 0x785328
	public static void SetAnalyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x7854A4
	public static void SetConsent(System.Collections.Generic.IDictionary<Firebase.Analytics.ConsentType,Firebase.Analytics.ConsentStatus> consentSettings) { }

	// RVA: 0x785B24
	private static void .cctor() { }

}

// Namespace: 
public sealed class IntIntMapEnumerator
{
	// Fields
	private IntIntMap collectionRef; // 0x10
	private System.Collections.Generic.IList<System.Int32> keyCollection; // 0x18
	private int currentIndex; // 0x20
	private object currentObject; // 0x28
	private int currentSize; // 0x30

	// Methods

	// RVA: 0x7889E0
	public void .ctor(IntIntMap collection) { }

	// RVA: 0x787D44
	public System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> get_Current() { }

	// RVA: 0x788CD8
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x787E58
	public bool MoveNext() { }

	// RVA: 0x788D44
	public void Reset() { }

	// RVA: 0x788DE0
	public void Dispose() { }

}

// Namespace: Firebase.Analytics
internal class IntIntMap
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x786D44
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x786DB0
	internal static HandleRef getCPtr(IntIntMap obj) { }

	// RVA: 0x786E00
	protected override void Finalize() { }

	// RVA: 0x786EA0
	public void Dispose() { }

	// RVA: 0x786F34
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x787100
	public int get_Item(int key) { }

	// RVA: 0x785A08
	public void set_Item(int key, int value) { }

	// RVA: 0x7872C4
	public bool TryGetValue(int key, int value) { }

	// RVA: 0x7873F0
	public int get_Count() { }

	// RVA: 0x787504
	public bool get_IsReadOnly() { }

	// RVA: 0x78750C
	public System.Collections.Generic.ICollection<System.Int32> get_Keys() { }

	// RVA: 0x78796C
	public System.Collections.Generic.ICollection<System.Int32> get_Values() { }

	// RVA: 0x787FEC
	public void Add(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> item) { }

	// RVA: 0x78824C
	public bool Remove(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> item) { }

	// RVA: 0x788360
	public bool Contains(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> item) { }

	// RVA: 0x7885C4
	public void CopyTo(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>[] array, int arrayIndex) { }

	// RVA: 0x78897C
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>>.GetEnumerator() { }

	// RVA: 0x788AC8
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x787CE0
	public IntIntMapEnumerator GetEnumerator() { }

	// RVA: 0x7858F8
	public void .ctor() { }

	// RVA: 0x7873F4
	private UInt32 size() { }

	// RVA: 0x788B38
	public void Clear() { }

	// RVA: 0x787104
	private int getitem(int key) { }

	// RVA: 0x7871E0
	private void setitem(int key, int x) { }

	// RVA: 0x787310
	public bool ContainsKey(int key) { }

	// RVA: 0x788168
	public void Add(int key, int value) { }

	// RVA: 0x7884E4
	public bool Remove(int key) { }

	// RVA: 0x787670
	private IntPtr create_iterator_begin() { }

	// RVA: 0x787780
	private int get_next_key(IntPtr swigiterator) { }

	// RVA: 0x78785C
	private void destroy_iterator(IntPtr swigiterator) { }

}

// Namespace: 
public sealed class ExceptionDelegate
{
	// Methods

	// RVA: 0x78A818
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x78A988
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x78A8CC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x78A99C
	public virtual void Invoke(string message, string paramName) { }

}

// Namespace: 
protected class SWIGExceptionHelper
{
	// Fields
	private static ExceptionDelegate applicationDelegate; // 0x0
	private static ExceptionDelegate arithmeticDelegate; // 0x8
	private static ExceptionDelegate divideByZeroDelegate; // 0x10
	private static ExceptionDelegate indexOutOfRangeDelegate; // 0x18
	private static ExceptionDelegate invalidCastDelegate; // 0x20
	private static ExceptionDelegate invalidOperationDelegate; // 0x28
	private static ExceptionDelegate ioDelegate; // 0x30
	private static ExceptionDelegate nullReferenceDelegate; // 0x38
	private static ExceptionDelegate outOfMemoryDelegate; // 0x40
	private static ExceptionDelegate overflowDelegate; // 0x48
	private static ExceptionDelegate systemDelegate; // 0x50
	private static ExceptionArgumentDelegate argumentDelegate; // 0x58
	private static ExceptionArgumentDelegate argumentNullDelegate; // 0x60
	private static ExceptionArgumentDelegate argumentOutOfRangeDelegate; // 0x68

	// Methods

	// RVA: 0x7898B0
	internal static extern void SWIGRegisterExceptionCallbacks_FirebaseAnalyticsInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x7899B8
	internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalyticsInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x788F40
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x788FD8
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x789070
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x789108
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x7891A0
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x789238
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7892D0
	private static void SetPendingIOException(string message) { }

	// RVA: 0x789368
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x789400
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x789498
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x789530
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x7895C8
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x789668
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x78978C
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x789E00
	private static void .cctor() { }

	// RVA: 0x788EB8
	public void .ctor() { }

}

// Namespace: 
public class SWIGPendingException
{
	// Fields
	private static Exception pendingException; // 0xFFFFFFFF
	private static int numExceptionsPending; // 0x0
	private static object exceptionsLock; // 0x8

	// Methods

	// RVA: 0x789BD8
	public static void Set(Exception e) { }

	// RVA: 0x789A08
	public static Exception Retrieve() { }

	// RVA: 0x78A9B0
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x78ABB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x78AC68
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x78AA68
	internal static extern void SWIGRegisterStringCallback_FirebaseAnalyticsInternal(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x78AA64
	private static string CreateString(string cString) { }

	// RVA: 0x78AA7C
	private static void .cctor() { }

	// RVA: 0x788EC0
	public void .ctor() { }

}

// Namespace: Firebase.Analytics
internal class FirebaseAnalyticsInternalPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x788DF4
	private static void .cctor() { }

	// RVA: 0x788B2C
	public static extern IntPtr new_IntIntMap__SWIG_0() { }

	// RVA: 0x788B30
	public static extern UInt32 IntIntMap_size(HandleRef jarg1) { }

	// RVA: 0x788C3C
	public static extern void IntIntMap_Clear(HandleRef jarg1) { }

	// RVA: 0x788C44
	public static extern int IntIntMap_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x788C50
	public static extern void IntIntMap_setitem(HandleRef jarg1, int jarg2, int jarg3) { }

	// RVA: 0x788C60
	public static extern bool IntIntMap_ContainsKey(HandleRef jarg1, int jarg2) { }

	// RVA: 0x788C84
	public static extern void IntIntMap_Add(HandleRef jarg1, int jarg2, int jarg3) { }

	// RVA: 0x788C94
	public static extern bool IntIntMap_Remove(HandleRef jarg1, int jarg2) { }

	// RVA: 0x788CB8
	public static extern IntPtr IntIntMap_create_iterator_begin(HandleRef jarg1) { }

	// RVA: 0x788CC0
	public static extern int IntIntMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x788CCC
	public static extern void IntIntMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7870F8
	public static extern void delete_IntIntMap(HandleRef jarg1) { }

	// RVA: 0x788EC8
	public static extern void SetAnalyticsCollectionEnabled(bool jarg1) { }

	// RVA: 0x788ECC
	public static extern void LogEvent__SWIG_0(string jarg1, string jarg2, string jarg3) { }

	// RVA: 0x788F38
	public static extern void SetConsentWithInts(HandleRef jarg1) { }

}

// Namespace: Firebase.Analytics
internal static class FirebaseAnalyticsInternal
{
	// Fields
	private static FirebaseApp app; // 0x0

	// Methods

	// RVA: 0x78AC7C
	private static void .cctor() { }

	// RVA: 0x7853A8
	public static void SetAnalyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x78520C
	public static void LogEvent(string name, string parameterName, string parameterValue) { }

	// RVA: 0x785A0C
	public static void SetConsentWithInts(IntIntMap settings) { }

}


