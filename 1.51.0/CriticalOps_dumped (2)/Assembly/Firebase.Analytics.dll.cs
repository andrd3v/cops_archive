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

	// RVA: 0x7C90DC
	public static void LogEvent(string name, string parameterName, string parameterValue) { }

	// RVA: 0x7C9270
	public static void LogEvent(string name, Parameter[] parameters) { }

	// RVA: 0x7C94F8
	public static void SetAnalyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x7C9674
	public static void SetConsent(System.Collections.Generic.IDictionary<Firebase.Analytics.ConsentType,Firebase.Analytics.ConsentStatus> consentSettings) { }

	// RVA: 0x7C9CF4
	private static void .cctor() { }

}

// Namespace: Firebase.Analytics
public class Parameter
{
	// Fields
	private string <Name>k__BackingField; // 0x10
	private object <Value>k__BackingField; // 0x18

	// Methods

	// RVA: 0x7CAF14
	internal string get_Name() { }

	// RVA: 0x7CAF1C
	internal void set_Name(string value) { }

	// RVA: 0x7CAF24
	internal object get_Value() { }

	// RVA: 0x7CAF2C
	internal void set_Value(object value) { }

	// RVA: 0x7CAF34
	public void .ctor(string parameterName, string parameterValue) { }

	// RVA: 0x7CAF84
	public void .ctor(string parameterName, Double parameterValue) { }

	// RVA: 0x7CAFF8
	public void Dispose() { }

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

	// RVA: 0x7CCC84
	public void .ctor(IntIntMap collection) { }

	// RVA: 0x7CBFE8
	public System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> get_Current() { }

	// RVA: 0x7CCF7C
	private object global::System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x7CC0FC
	public bool MoveNext() { }

	// RVA: 0x7CCFE8
	public void Reset() { }

	// RVA: 0x7CD084
	public void Dispose() { }

}

// Namespace: Firebase.Analytics
internal class IntIntMap
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Methods

	// RVA: 0x7CAFFC
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x7CB068
	internal static HandleRef getCPtr(IntIntMap obj) { }

	// RVA: 0x7CB0B8
	protected override void Finalize() { }

	// RVA: 0x7CB158
	public void Dispose() { }

	// RVA: 0x7CB1EC
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x7CB3A4
	public int get_Item(int key) { }

	// RVA: 0x7C9BD8
	public void set_Item(int key, int value) { }

	// RVA: 0x7CB568
	public bool TryGetValue(int key, int value) { }

	// RVA: 0x7CB694
	public int get_Count() { }

	// RVA: 0x7CB7A8
	public bool get_IsReadOnly() { }

	// RVA: 0x7CB7B0
	public System.Collections.Generic.ICollection<System.Int32> get_Keys() { }

	// RVA: 0x7CBC10
	public System.Collections.Generic.ICollection<System.Int32> get_Values() { }

	// RVA: 0x7CC290
	public void Add(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> item) { }

	// RVA: 0x7CC4F0
	public bool Remove(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> item) { }

	// RVA: 0x7CC604
	public bool Contains(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32> item) { }

	// RVA: 0x7CC868
	public void CopyTo(System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>[] array, int arrayIndex) { }

	// RVA: 0x7CCC20
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Int32,System.Int32>>.GetEnumerator() { }

	// RVA: 0x7CCD6C
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x7CBF84
	public IntIntMapEnumerator GetEnumerator() { }

	// RVA: 0x7C9AC8
	public void .ctor() { }

	// RVA: 0x7CB698
	private UInt32 size() { }

	// RVA: 0x7CCDDC
	public void Clear() { }

	// RVA: 0x7CB3A8
	private int getitem(int key) { }

	// RVA: 0x7CB484
	private void setitem(int key, int x) { }

	// RVA: 0x7CB5B4
	public bool ContainsKey(int key) { }

	// RVA: 0x7CC40C
	public void Add(int key, int value) { }

	// RVA: 0x7CC788
	public bool Remove(int key) { }

	// RVA: 0x7CB914
	private IntPtr create_iterator_begin() { }

	// RVA: 0x7CBA24
	private int get_next_key(IntPtr swigiterator) { }

	// RVA: 0x7CBB00
	private void destroy_iterator(IntPtr swigiterator) { }

}

// Namespace: 
public sealed class ExceptionDelegate
{
	// Methods

	// RVA: 0x7CEAFC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7CEC6C
	public virtual void Invoke(string message) { }

}

// Namespace: 
public sealed class ExceptionArgumentDelegate
{
	// Methods

	// RVA: 0x7CEBB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7CEC80
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

	// RVA: 0x7CDB94
	internal static extern void SWIGRegisterExceptionCallbacks_FirebaseAnalyticsInternal(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate) { }

	// RVA: 0x7CDC9C
	internal static extern void SWIGRegisterExceptionCallbacksArgument_FirebaseAnalyticsInternal(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate) { }

	// RVA: 0x7CD224
	private static void SetPendingApplicationException(string message) { }

	// RVA: 0x7CD2BC
	private static void SetPendingArithmeticException(string message) { }

	// RVA: 0x7CD354
	private static void SetPendingDivideByZeroException(string message) { }

	// RVA: 0x7CD3EC
	private static void SetPendingIndexOutOfRangeException(string message) { }

	// RVA: 0x7CD484
	private static void SetPendingInvalidCastException(string message) { }

	// RVA: 0x7CD51C
	private static void SetPendingInvalidOperationException(string message) { }

	// RVA: 0x7CD5B4
	private static void SetPendingIOException(string message) { }

	// RVA: 0x7CD64C
	private static void SetPendingNullReferenceException(string message) { }

	// RVA: 0x7CD6E4
	private static void SetPendingOutOfMemoryException(string message) { }

	// RVA: 0x7CD77C
	private static void SetPendingOverflowException(string message) { }

	// RVA: 0x7CD814
	private static void SetPendingSystemException(string message) { }

	// RVA: 0x7CD8AC
	private static void SetPendingArgumentException(string message, string paramName) { }

	// RVA: 0x7CD94C
	private static void SetPendingArgumentNullException(string message, string paramName) { }

	// RVA: 0x7CDA70
	private static void SetPendingArgumentOutOfRangeException(string message, string paramName) { }

	// RVA: 0x7CE0E4
	private static void .cctor() { }

	// RVA: 0x7CD15C
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

	// RVA: 0x7CDEBC
	public static void Set(Exception e) { }

	// RVA: 0x7CDCEC
	public static Exception Retrieve() { }

	// RVA: 0x7CEC94
	private static void .cctor() { }

}

// Namespace: 
public sealed class SWIGStringDelegate
{
	// Methods

	// RVA: 0x7CEE98
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x7CEF4C
	public virtual string Invoke(string message) { }

}

// Namespace: 
protected class SWIGStringHelper
{
	// Fields
	private static SWIGStringDelegate stringDelegate; // 0x0

	// Methods

	// RVA: 0x7CED4C
	internal static extern void SWIGRegisterStringCallback_FirebaseAnalyticsInternal(SWIGStringDelegate stringDelegate) { }

	// RVA: 0x7CED48
	private static string CreateString(string cString) { }

	// RVA: 0x7CED60
	private static void .cctor() { }

	// RVA: 0x7CD164
	public void .ctor() { }

}

// Namespace: Firebase.Analytics
internal class FirebaseAnalyticsInternalPINVOKE
{
	// Fields
	protected static SWIGExceptionHelper swigExceptionHelper; // 0x0
	protected static SWIGStringHelper swigStringHelper; // 0x8

	// Methods

	// RVA: 0x7CD098
	private static void .cctor() { }

	// RVA: 0x7CCDD0
	public static extern IntPtr new_IntIntMap__SWIG_0() { }

	// RVA: 0x7CCDD4
	public static extern UInt32 IntIntMap_size(HandleRef jarg1) { }

	// RVA: 0x7CCEE0
	public static extern void IntIntMap_Clear(HandleRef jarg1) { }

	// RVA: 0x7CCEE8
	public static extern int IntIntMap_getitem(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7CCEF4
	public static extern void IntIntMap_setitem(HandleRef jarg1, int jarg2, int jarg3) { }

	// RVA: 0x7CCF04
	public static extern bool IntIntMap_ContainsKey(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7CCF28
	public static extern void IntIntMap_Add(HandleRef jarg1, int jarg2, int jarg3) { }

	// RVA: 0x7CCF38
	public static extern bool IntIntMap_Remove(HandleRef jarg1, int jarg2) { }

	// RVA: 0x7CCF5C
	public static extern IntPtr IntIntMap_create_iterator_begin(HandleRef jarg1) { }

	// RVA: 0x7CCF64
	public static extern int IntIntMap_get_next_key(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7CCF70
	public static extern void IntIntMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2) { }

	// RVA: 0x7CB39C
	public static extern void delete_IntIntMap(HandleRef jarg1) { }

	// RVA: 0x7CD16C
	public static extern void SetAnalyticsCollectionEnabled(bool jarg1) { }

	// RVA: 0x7CD170
	public static extern void LogEvent__SWIG_0(string jarg1, string jarg2, string jarg3) { }

	// RVA: 0x7CD1DC
	public static extern void LogEvent__SWIG_5(string jarg1, HandleRef jarg2, HandleRef jarg3) { }

	// RVA: 0x7CD21C
	public static extern void SetConsentWithInts(HandleRef jarg1) { }

}

// Namespace: Firebase.Analytics
internal static class FirebaseAnalyticsInternal
{
	// Fields
	private static FirebaseApp app; // 0x0

	// Methods

	// RVA: 0x7CEF60
	private static void .cctor() { }

	// RVA: 0x7C9578
	public static void SetAnalyticsCollectionEnabled(bool enabled) { }

	// RVA: 0x7C9154
	public static void LogEvent(string name, string parameterName, string parameterValue) { }

	// RVA: 0x7C93E8
	public static void LogEvent(string name, StringList parameterNames, VariantList parameterValues) { }

	// RVA: 0x7C9BDC
	public static void SetConsentWithInts(IntIntMap settings) { }

}


