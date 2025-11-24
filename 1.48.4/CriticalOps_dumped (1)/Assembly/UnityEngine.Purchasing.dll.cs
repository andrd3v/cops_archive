// Namespace: 
internal class <Module> 
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute 
{
	// Methods

	// RVA: 0x1580CB0
	void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute 
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1580CB8
	void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute 
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x1580D44
	void .ctor(Byte ) { }

}

// Namespace: Uniject
internal interface IUtil 
{
	// Methods

	// RVA: 0x2FE36BC
	object InitiateCoroutine(IEnumerator start) { }

	// RVA: 0x2FE45DC
	void InitiateCoroutine(IEnumerator start, int delayInSeconds) { }

	// RVA: 0x2FE4574
	void RunOnMainThread(Action runnable) { }

	// RVA: 0x2FE4574
	void AddPauseListener(System.Action<System.Boolean> runnable) { }

	// RVA: -1
	bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant) { }

}

// Namespace: UnityEngine.Purchasing
internal class AnalyticsClient 
{
	// Fields
	private readonly IAnalyticsAdapter m_Analytics; // 0x10
	private readonly IAnalyticsAdapter m_LegacyAnalytics; // 0x18

	// Methods

	// RVA: 0x1580D70
	void .ctor(IAnalyticsAdapter analytics, IAnalyticsAdapter legacyAnalytics) { }

	// RVA: 0x1580DC0
	void OnPurchaseSucceeded(Product product) { }

	// RVA: 0x1580F10
	void OnPurchaseFailed(Product product, PurchaseFailureDescription description) { }

}

// Namespace: UnityEngine.Purchasing
internal class EmptyAnalyticsAdapter 
{
	// Methods

	// RVA: 0x1581044
	void SendTransactionEvent(Product product) { }

	// RVA: 0x1581048
	void SendTransactionFailedEvent(Product product, PurchaseFailureDescription reason) { }

	// RVA: 0x158104C
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal interface IAnalyticsAdapter 
{
	// Methods

	// RVA: 0x2FE4574
	void SendTransactionEvent(Product product) { }

	// RVA: 0x2FE47D4
	void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IAnalyticsClient 
{
	// Methods

	// RVA: 0x2FE4574
	void OnPurchaseSucceeded(Product product) { }

	// RVA: 0x2FE47D4
	void OnPurchaseFailed(Product product, PurchaseFailureDescription purchaseFailureDescription) { }

}

// Namespace: UnityEngine.Purchasing
internal interface ILegacyUnityAnalytics 
{
	// Methods

	// RVA: -1
	void SendTransactionEvent(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: 0x2FE47D4
	void SendCustomEvent(string name, System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

}

// Namespace: UnityEngine.Purchasing
internal class LegacyAnalyticsAdapter 
{
	// Fields
	private readonly ILegacyUnityAnalytics m_LegacyAnalytics; // 0x10

	// Methods

	// RVA: 0x1581054
	void .ctor(ILegacyUnityAnalytics legacyAnalytics) { }

	// RVA: 0x1581088
	void SendTransactionEvent(Product product) { }

	// RVA: 0x158117C
	void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

}

// Namespace: UnityEngine.Purchasing
internal class LegacyAnalyticsWrapper 
{
	// Fields
	private bool m_Enabled; // 0x10
	private IAnalyticsAdapter m_LegacyAdapter; // 0x18
	private IAnalyticsAdapter m_EmptyAdapter; // 0x20

	// Methods

	// RVA: 0x15813F8
	void .ctor(IAnalyticsAdapter legacyAdapter, IAnalyticsAdapter emptyAdapter) { }

	// RVA: 0x15816A4
	void SendTransactionEvent(Product product) { }

	// RVA: 0x1581788
	void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

	// RVA: 0x158185C
	void OnUpdatedCoreServicesEnvironment(string currentEnvironment) { }

	// RVA: 0x158176C
	IAnalyticsAdapter get_m_AnalyticsAdapter() { }

}

// Namespace: UnityEngine.Purchasing
internal class LegacyUnityAnalytics 
{
	// Methods

	// RVA: 0x1581924
	void SendTransactionEvent(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: 0x1581944
	void SendCustomEvent(string name, System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

	// RVA: 0x1581954
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class IDs 
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.String,System.String> m_Dic; // 0x10

	// Methods

	// RVA: 0x158195C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15819F4
	string SpecificIDForStore(string store, string defaultValue) { }

	// RVA: 0x1581AA0
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> GetEnumerator() { }

}

// Namespace: UnityEngine.Purchasing
public class ConfigurationBuilder 
{
	// Fields
	private bool <useCatalogProvider>k__BackingField; // 0x10
	private bool <logUnavailableProducts>k__BackingField; // 0x11
	private readonly System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> <products>k__BackingField; // 0x18
	private readonly PurchasingFactory <factory>k__BackingField; // 0x20

	// Methods

	// RVA: 0x1581B38
	void .ctor(PurchasingFactory factory) { }

	// RVA: 0x1581BE8
	bool get_useCatalogProvider() { }

	// RVA: 0x1581BF0
	bool get_logUnavailableProducts() { }

	// RVA: 0x1581BF8
	System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> get_products() { }

	// RVA: 0x1581C00
	PurchasingFactory get_factory() { }

	// RVA: 0x309AF8C
	T Configure() { }

	// RVA: 0x1581C08
	ConfigurationBuilder Instance(IPurchasingModule first, IPurchasingModule[] rest) { }

	// RVA: 0x1581EB8
	ConfigurationBuilder AddProduct(string id, ProductType type) { }

	// RVA: 0x1581EC4
	ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs) { }

	// RVA: 0x1581ECC
	ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts) { }

}

// Namespace: UnityEngine.Purchasing
internal class CoreServicesEnvironmentSubject 
{
	// Fields
	private static CoreServicesEnvironmentSubject s_Instance; // 0x0
	private string m_LastKnownEnvironment; // 0x10
	private System.Collections.Generic.List<UnityEngine.Purchasing.ICoreServicesEnvironmentObserver> m_Observers; // 0x18

	// Methods

	// RVA: 0x1581464
	CoreServicesEnvironmentSubject Instance() { }

	// RVA: 0x158158C
	void SubscribeToUpdatesAndGetCurrent(ICoreServicesEnvironmentObserver newObserver) { }

	// RVA: 0x15821A4
	void UpdateCurrentEnvironment(string currentEnvironment) { }

	// RVA: 0x15821CC
	void NotifyObservers() { }

	// RVA: 0x15818CC
	bool IsDefaultLiveEnvironment(string environment) { }

	// RVA: 0x1582118
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal interface ICoreServicesEnvironmentObserver 
{
	// Methods

	// RVA: 0x2FE4574
	void OnUpdatedCoreServicesEnvironment(string currentEnvironment) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IUnityServicesInitializationChecker 
{
	// Methods

	// RVA: 0x2FE41A8
	void CheckAndLogWarning() { }

}

// Namespace: UnityEngine.Purchasing
internal class UnityServicesInitializationChecker 
{
	// Fields
	private readonly ILogger m_Logger; // 0x10

	// Methods

	// RVA: 0x158241C
	void .ctor(ILogger logger) { }

	// RVA: 0x1582450
	void CheckAndLogWarning() { }

	// RVA: 0x15824BC
	bool IsUninitialized() { }

	// RVA: 0x15825F8
	void LogWarning() { }

}

// Namespace: UnityEngine.Purchasing
public interface IStoreExtension 
{}

// Namespace: UnityEngine.Purchasing
public interface IDetailedStoreListener 
{
	// Methods

	// RVA: 0x2FE47D4
	void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription) { }

}

// Namespace: UnityEngine.Purchasing
public interface IExtensionProvider 
{
	// Methods

	// RVA: 0x309AF8C
	T GetExtension() { }

}

// Namespace: UnityEngine.Purchasing
internal interface IInternalStoreListener 
{
	// Methods

	// RVA: 0x2FE440C
	void OnInitializeFailed(InitializationFailureReason error, string message) { }

	// RVA: 0x2FE3404
	PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e) { }

	// RVA: 0x2FE47D4
	void OnPurchaseFailed(Product i, PurchaseFailureDescription p) { }

	// RVA: 0x2FE4574
	void OnInitialized(IStoreController controller) { }

	// RVA: 0x2FE4574
	void SendTransactionEvent(Product product) { }

}

// Namespace: UnityEngine.Purchasing
public enum InitializationFailureReason 
{
	// Fields
	public int value__; // 0x10
	public const InitializationFailureReason PurchasingUnavailable = 0;
	public const InitializationFailureReason NoProductsAvailable = 1;
	public const InitializationFailureReason AppNotKnown = 2;
}

// Namespace: UnityEngine.Purchasing
public interface IStoreController 
{
	// Methods

	// RVA: 0x2FE360C
	ProductCollection get_products() { }

	// RVA: 0x2FE47D4
	void InitiatePurchase(Product product, string payload) { }

	// RVA: 0x2FE4574
	void ConfirmPendingPurchase(Product product) { }

}

// Namespace: UnityEngine.Purchasing
public interface IStoreListener 
{
	// Methods

	// RVA: 0x2FE440C
	void OnInitializeFailed(InitializationFailureReason error, string message) { }

	// RVA: 0x2FE3404
	PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent) { }

	// RVA: 0x2FE45DC
	void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason) { }

	// RVA: 0x2FE47D4
	void OnInitialized(IStoreController controller, IExtensionProvider extensions) { }

}

// Namespace: UnityEngine.Purchasing
public class PayoutDefinition 
{
	// Fields
	private string m_Subtype; // 0x10
	private Double m_Quantity; // 0x18
	private string m_Data; // 0x20

	// Methods

	// RVA: 0x158271C
	Double get_quantity() { }

	// RVA: 0x1582724
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class Product 
{
	// Fields
	private ProductDefinition <definition>k__BackingField; // 0x10
	private ProductMetadata <metadata>k__BackingField; // 0x18
	private bool <availableToPurchase>k__BackingField; // 0x20
	private string <transactionID>k__BackingField; // 0x28
	private string <appleOriginalTransactionID>k__BackingField; // 0x30
	private bool <appleProductIsRestored>k__BackingField; // 0x38
	private string <receipt>k__BackingField; // 0x40

	// Methods

	// RVA: 0x15827A8
	void .ctor(ProductDefinition definition, ProductMetadata metadata, string receipt) { }

	// RVA: 0x158280C
	void .ctor(ProductDefinition definition, ProductMetadata metadata) { }

	// RVA: 0x158286C
	ProductDefinition get_definition() { }

	// RVA: 0x1582874
	void set_definition(ProductDefinition value) { }

	// RVA: 0x158287C
	ProductMetadata get_metadata() { }

	// RVA: 0x1582884
	void set_metadata(ProductMetadata value) { }

	// RVA: 0x158288C
	bool get_availableToPurchase() { }

	// RVA: 0x1582894
	void set_availableToPurchase(bool value) { }

	// RVA: 0x158289C
	string get_transactionID() { }

	// RVA: 0x15828A4
	void set_transactionID(string value) { }

	// RVA: 0x15828AC
	void set_appleOriginalTransactionID(string value) { }

	// RVA: 0x15828B4
	bool get_appleProductIsRestored() { }

	// RVA: 0x15828BC
	void set_appleProductIsRestored(bool value) { }

	// RVA: 0x15828C4
	bool get_hasReceipt() { }

	// RVA: 0x15828E4
	string get_receipt() { }

	// RVA: 0x15828EC
	void set_receipt(string value) { }

	// RVA: 0x15828F4
	bool Equals(object obj) { }

	// RVA: 0x15829A0
	int GetHashCode() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.ProductCollection.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.Product,System.String> <>9__3_0; // 0x8
	public static System.Func<UnityEngine.Purchasing.Product,System.String> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x1582DE4
	void .cctor() { }

	// RVA: 0x1582E50
	void .ctor() { }

	// RVA: 0x1582E58
	string <AddProducts>b__3_0(Product x) { }

	// RVA: 0x1582E7C
	string <AddProducts>b__3_1(Product x) { }

}

// Namespace: UnityEngine.Purchasing
public class ProductCollection 
{
	// Fields
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.Purchasing.Product> m_IdToProduct; // 0x10
	private System.Collections.Generic.Dictionary<System.String,UnityEngine.Purchasing.Product> m_StoreSpecificIdToProduct; // 0x18
	private readonly System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> <set>k__BackingField; // 0x20
	private Product[] <all>k__BackingField; // 0x28

	// Methods

	// RVA: 0x15829C4
	void .ctor(Product[] products) { }

	// RVA: 0x1582A68
	void AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products) { }

	// RVA: 0x1582CB8
	System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> get_set() { }

	// RVA: 0x1582CC0
	Product[] get_all() { }

	// RVA: 0x1582CC8
	void set_all(Product[] value) { }

	// RVA: 0x1582CD0
	Product WithID(string id) { }

	// RVA: 0x1582D4C
	Product WithStoreSpecificID(string id) { }

}

// Namespace: UnityEngine.Purchasing
public class ProductDefinition 
{
	// Fields
	private string <id>k__BackingField; // 0x10
	private string <storeSpecificId>k__BackingField; // 0x18
	private ProductType <type>k__BackingField; // 0x20
	private bool <enabled>k__BackingField; // 0x24
	private readonly System.Collections.Generic.List<UnityEngine.Purchasing.PayoutDefinition> m_Payouts; // 0x28

	// Methods

	// RVA: 0x158202C
	void .ctor(string id, string storeSpecificId, ProductType type) { }

	// RVA: 0x1582EA0
	void .ctor(string id, string storeSpecificId, ProductType type, bool enabled) { }

	// RVA: 0x1582EA8
	void .ctor(string id, string storeSpecificId, ProductType type, bool enabled, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts) { }

	// RVA: 0x1582F94
	void .ctor(string id, ProductType type) { }

	// RVA: 0x1582FA8
	string get_id() { }

	// RVA: 0x1582FB0
	void set_id(string value) { }

	// RVA: 0x1582FB8
	string get_storeSpecificId() { }

	// RVA: 0x1582FC0
	void set_storeSpecificId(string value) { }

	// RVA: 0x1582FC8
	ProductType get_type() { }

	// RVA: 0x1582FD0
	void set_type(ProductType value) { }

	// RVA: 0x1582FD8
	bool get_enabled() { }

	// RVA: 0x1582FE0
	void set_enabled(bool value) { }

	// RVA: 0x1582FE8
	bool Equals(object obj) { }

	// RVA: 0x1583088
	int GetHashCode() { }

	// RVA: 0x15830AC
	System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> get_payouts() { }

	// RVA: 0x15830B4
	PayoutDefinition get_payout() { }

	// RVA: 0x1582038
	void SetPayouts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> newPayouts) { }

}

// Namespace: UnityEngine.Purchasing
public class ProductMetadata 
{
	// Fields
	private string <localizedPriceString>k__BackingField; // 0x10
	private string <localizedTitle>k__BackingField; // 0x18
	private string <localizedDescription>k__BackingField; // 0x20
	private string <isoCurrencyCode>k__BackingField; // 0x28
	private Decimal <localizedPrice>k__BackingField; // 0x30

	// Methods

	// RVA: 0x158314C
	void .ctor(string priceString, string title, string description, string currencyCode, Decimal localizedPrice) { }

	// RVA: 0x15831E4
	void .ctor(ProductMetadata productMetadata) { }

	// RVA: 0x158325C
	void .ctor() { }

	// RVA: 0x1583264
	string get_localizedPriceString() { }

	// RVA: 0x158326C
	void set_localizedPriceString(string value) { }

	// RVA: 0x1583274
	string get_localizedTitle() { }

	// RVA: 0x158327C
	void set_localizedTitle(string value) { }

	// RVA: 0x1583284
	string get_localizedDescription() { }

	// RVA: 0x158328C
	void set_localizedDescription(string value) { }

	// RVA: 0x1583294
	string get_isoCurrencyCode() { }

	// RVA: 0x158329C
	void set_isoCurrencyCode(string value) { }

	// RVA: 0x15832A4
	Decimal get_localizedPrice() { }

	// RVA: 0x15832B0
	void set_localizedPrice(Decimal value) { }

}

// Namespace: UnityEngine.Purchasing
public enum ProductType 
{
	// Fields
	public int value__; // 0x10
	public const ProductType Consumable = 0;
	public const ProductType NonConsumable = 1;
	public const ProductType Subscription = 2;
}

// Namespace: UnityEngine.Purchasing
public class PurchaseEventArgs 
{
	// Fields
	private Product <purchasedProduct>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15832B8
	void .ctor(Product purchasedProduct) { }

	// RVA: 0x15832EC
	Product get_purchasedProduct() { }

	// RVA: 0x15832F4
	void set_purchasedProduct(Product value) { }

}

// Namespace: UnityEngine.Purchasing
public enum PurchaseFailureReason 
{
	// Fields
	public int value__; // 0x10
	public const PurchaseFailureReason PurchasingUnavailable = 0;
	public const PurchaseFailureReason ExistingPurchasePending = 1;
	public const PurchaseFailureReason ProductUnavailable = 2;
	public const PurchaseFailureReason SignatureInvalid = 3;
	public const PurchaseFailureReason UserCancelled = 4;
	public const PurchaseFailureReason PaymentDeclined = 5;
	public const PurchaseFailureReason DuplicateTransaction = 6;
	public const PurchaseFailureReason Unknown = 7;
}

// Namespace: UnityEngine.Purchasing
public enum PurchaseProcessingResult 
{
	// Fields
	public int value__; // 0x10
	public const PurchaseProcessingResult Complete = 0;
	public const PurchaseProcessingResult Pending = 1;
}

// Namespace: UnityEngine.Purchasing
internal class PurchasingFactory 
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration> m_ConfigMap; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.Type,UnityEngine.Purchasing.IStoreExtension> m_ExtensionMap; // 0x18
	private IStore m_Store; // 0x20
	private ICatalogProvider m_CatalogProvider; // 0x28
	private string <storeName>k__BackingField; // 0x30

	// Methods

	// RVA: 0x1581CA4
	void .ctor(IPurchasingModule first, IPurchasingModule[] remainingModules) { }

	// RVA: 0x15832FC
	string get_storeName() { }

	// RVA: 0x1583304
	void set_storeName(string value) { }

	// RVA: 0x158330C
	IStore get_service() { }

	// RVA: 0x1583374
	void set_service(IStore value) { }

	// RVA: 0x158337C
	void RegisterStore(string name, IStore s) { }

	// RVA: 0x309AF8C
	void RegisterExtension(T instance) { }

	// RVA: 0x309AF8C
	void RegisterConfiguration(T instance) { }

	// RVA: 0x309AF8C
	T GetConfig() { }

	// RVA: 0x309AF8C
	T GetExtension() { }

	// RVA: 0x15833DC
	ICatalogProvider GetCatalogProvider() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.PurchasingManager.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product> <>9__45_0; // 0x8

	// Methods

	// RVA: 0x1585A60
	void .cctor() { }

	// RVA: 0x1585ACC
	void .ctor() { }

	// RVA: 0x1585AD4
	Product <Initialize>b__45_0(ProductDefinition x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass27_0 
{
	// Fields
	public Product product; // 0x10

	// Methods

	// RVA: 0x1584264
	void .ctor() { }

	// RVA: 0x1585B90
	bool <OnAllPurchasesRetrieved>b__0(Product firstPurchasedProduct) { }

}

// Namespace: UnityEngine.Purchasing
internal class PurchasingManager 
{
	// Fields
	private readonly IStore m_Store; // 0x10
	private IInternalStoreListener m_Listener; // 0x18
	private readonly ILogger m_Logger; // 0x20
	private readonly TransactionLog m_TransactionLog; // 0x28
	private readonly string m_StoreName; // 0x30
	private readonly bool m_logUnavailableProducts; // 0x38
	private readonly IUnityServicesInitializationChecker m_UnityServicesInitializationChecker; // 0x40
	private Action m_AdditionalProductsCallback; // 0x48
	private System.Action<UnityEngine.Purchasing.InitializationFailureReason> m_AdditionalProductsFailCallback; // 0x50
	private System.Action<UnityEngine.Purchasing.InitializationFailureReason,System.String> m_AdditionalProductsDetailedFailCallback; // 0x58
	private readonly System.Collections.Generic.HashSet<System.String> purchasesProcessedInSession; // 0x60
	private bool <useTransactionLog>k__BackingField; // 0x68
	private ProductCollection <products>k__BackingField; // 0x70
	private bool initialized; // 0x78

	// Methods

	// RVA: 0x15833E4
	bool get_useTransactionLog() { }

	// RVA: 0x15833EC
	void set_useTransactionLog(bool value) { }

	// RVA: 0x15833F4
	void .ctor(TransactionLog tDb, ILogger logger, IStore store, string storeName, IUnityServicesInitializationChecker unityServicesInitializationChecker, bool logUnavailableProducts) { }

	// RVA: 0x158350C
	void InitiatePurchase(Product product, string developerPayload) { }

	// RVA: 0x1583804
	void ConfirmPendingPurchase(Product product) { }

	// RVA: 0x1583C18
	ProductCollection get_products() { }

	// RVA: 0x1583C20
	void set_products(ProductCollection value) { }

	// RVA: 0x1583C28
	void OnPurchaseSucceeded(string id, string receipt, string transactionId) { }

	// RVA: 0x1583DD4
	void UpdateProductReceiptAndTransactionID(Product product, string receipt, string transactionId) { }

	// RVA: 0x158403C
	void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts) { }

	// RVA: 0x1584378
	void OnEntitlementRevoked(Product revokedProduct) { }

	// RVA: 0x158426C
	void HandlePurchaseRetrieved(Product product, Product purchasedProduct) { }

	// RVA: 0x15843B4
	bool WasPurchaseAlreadyProcessed(string transactionId) { }

	// RVA: 0x158433C
	void ClearProductReceipt(Product product) { }

	// RVA: 0x1584418
	void OnSetupFailed(InitializationFailureReason reason, string message) { }

	// RVA: 0x158453C
	void OnPurchaseFailed(PurchaseFailureDescription description) { }

	// RVA: 0x15849F8
	void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x1584028
	string CreateUnifiedReceipt(string rawReceipt, string transactionId) { }

	// RVA: 0x1585000
	void ProcessPurchaseOnStart() { }

	// RVA: 0x1583E2C
	void ProcessPurchaseIfNew(Product product) { }

	// RVA: 0x15852BC
	bool HasRecordedTransaction(string transactionId) { }

	// RVA: 0x1584E44
	void CheckForInitialization(int productCount) { }

	// RVA: 0x15853A4
	bool HasAvailableProductsToPurchase() { }

	// RVA: 0x1585770
	void Initialize(IInternalStoreListener listener, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products) { }

}

// Namespace: UnityEngine.Purchasing
internal class StoreListenerProxy 
{
	// Fields
	private readonly IAnalyticsClient m_Analytics; // 0x10
	private readonly IStoreListener m_ForwardTo; // 0x18
	private readonly IExtensionProvider m_Extensions; // 0x20

	// Methods

	// RVA: 0x1585BCC
	void .ctor(IStoreListener forwardTo, IAnalyticsClient analytics, IExtensionProvider extensions) { }

	// RVA: 0x1585C30
	void OnInitialized(IStoreController controller) { }

	// RVA: 0x1585CF0
	void OnInitializeFailed(InitializationFailureReason error, string message) { }

	// RVA: 0x1585DAC
	PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e) { }

	// RVA: 0x1585E64
	void OnPurchaseFailed(Product i, PurchaseFailureDescription p) { }

	// RVA: 0x158604C
	void SendTransactionEvent(Product product) { }

}

// Namespace: UnityEngine.Purchasing
internal class TransactionLog 
{
	// Fields
	private readonly ILogger logger; // 0x10
	private readonly string persistentDataPath; // 0x18

	// Methods

	// RVA: 0x1586100
	void .ctor(ILogger logger, string persistentDataPath) { }

	// RVA: 0x15852EC
	bool HasRecordOf(string transactionID) { }

	// RVA: 0x1583AC4
	void Record(string transactionID) { }

	// RVA: 0x15861F0
	string GetRecordPath(string transactionID) { }

	// RVA: 0x158626C
	string ComputeHash(string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
public class UnifiedReceipt 
{
	// Fields
	public string Payload; // 0x10
	public string Store; // 0x18
	public string TransactionID; // 0x20

	// Methods

	// RVA: 0x1586400
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public PurchasingManager manager; // 0x10
	public StoreListenerProxy proxy; // 0x18

	// Methods

	// RVA: 0x1586A64
	void .ctor() { }

	// RVA: 0x1586BFC
	void <Initialize>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> response) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet; // 0x10
	public System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback; // 0x18

	// Methods

	// RVA: 0x1586BF4
	void .ctor() { }

	// RVA: 0x1586C24
	void <FetchAndMergeProducts>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> cloudProducts) { }

}

// Namespace: UnityEngine.Purchasing
public abstract class UnityPurchasing 
{
	// Methods

	// RVA: 0x1586408
	void Initialize(IDetailedStoreListener listener, ConfigurationBuilder builder) { }

	// RVA: 0x1586704
	IAnalyticsAdapter GenerateUnityAnalytics(ILogger logger) { }

	// RVA: 0x158666C
	IAnalyticsAdapter GenerateLegacyUnityAnalytics() { }

	// RVA: 0x158675C
	void Initialize(IStoreListener listener, ConfigurationBuilder builder, ILogger logger, string persistentDatapath, IAnalyticsAdapter ugsAnalytics, IAnalyticsAdapter legacyAnalytics, ICatalogProvider catalog, IUnityServicesInitializationChecker unityServicesInitializationChecker) { }

	// RVA: 0x1586A6C
	void FetchAndMergeProducts(bool useCatalog, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet, ICatalogProvider catalog, System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback) { }

}

// Namespace: UnityEngine.Purchasing
internal static class LoggerExtensions 
{
	// Methods

	// RVA: 0x158264C
	void LogIAPWarning(ILogger logger, string message) { }

	// RVA: 0x15839F4
	void LogIAPError(ILogger logger, string message) { }

}

// Namespace: UnityEngine.Purchasing
internal static class ProductPurchaseUpdater 
{
	// Methods

	// RVA: 0x1586F18
	void UpdateProductReceiptAndTransactionID(Product product, string receipt, string transactionId, string storeName) { }

}

// Namespace: UnityEngine.Purchasing
internal static class UnifiedReceiptFormatter 
{
	// Methods

	// RVA: 0x158520C
	string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryDiagnostics 
{
	// Methods

	// RVA: 0x2FE47D4
	void SendDiagnostic(string diagnosticName, Exception e) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryDiagnosticsInstanceWrapper 
{
	// Methods

	// RVA: 0x2FE4574
	void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance) { }

	// RVA: 0x2FE47D4
	void SendDiagnostic(string diagnosticName, string diagnosticException) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal struct TelemetryDiagnosticParams 
{
	// Fields
	internal string name; // 0x10
	internal string exception; // 0x18

	// Methods

	// RVA: 0x1586F6C
	void .ctor(string diagnosticName, string diagnosticException) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryDiagnostics 
{
	// Fields
	private readonly ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper; // 0x10

	// Methods

	// RVA: 0x1586FA0
	void .ctor(ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper) { }

	// RVA: 0x1586FD4
	void SendDiagnostic(string diagnosticName, Exception e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public TelemetryDiagnosticsInstanceWrapper <>4__this; // 0x10
	public TelemetryDiagnosticParams diagnosticParams; // 0x18

	// Methods

	// RVA: 0x1587544
	void .ctor() { }

	// RVA: 0x15876F4
	void <SendDiagnosticOnMainThread>b__0() { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryDiagnosticsInstanceWrapper 
{
	// Fields
	private IDiagnostics m_Instance; // 0x10
	private ILogger m_Logger; // 0x18
	private IUtil m_Util; // 0x20
	private readonly UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams> m_Queue; // 0x28

	// Methods

	// RVA: 0x15871A4
	void .ctor(ILogger logger, IUtil util) { }

	// RVA: 0x15872B0
	void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance) { }

	// RVA: 0x1587320
	void SendDiagnostic(string diagnosticName, string diagnosticException) { }

	// RVA: 0x15873EC
	void SendDiagnosticOnMainThread(TelemetryDiagnosticParams diagnosticParams) { }

	// RVA: 0x158754C
	void SendDiagnosticAndCatchExceptions(TelemetryDiagnosticParams diagnosticParams) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class IapTelemetryException 
{
	// Methods

	// RVA: 0x1587718
	void .ctor(string message) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryMetricEvent 
{
	// Methods

	// RVA: 0x2FE41A8
	void StartMetric() { }

	// RVA: 0x2FE41A8
	void StopAndSendMetric() { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryMetricsInstanceWrapper 
{
	// Methods

	// RVA: 0x2FE4574
	void SetMetricsInstance(IMetrics metricsInstance) { }

	// RVA: -1
	void SendMetric(TelemetryMetricTypes telemetryMetricTypes, string metricName, Double metricTimeSeconds) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryMetricsService 
{
	// Methods

	// RVA: -1
	void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal struct TelemetryMetricDefinition 
{
	// Fields
	private readonly TelemetryMetricTypes <MetricType>k__BackingField; // 0x10
	private readonly string <MetricName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1587784
	TelemetryMetricTypes get_MetricType() { }

	// RVA: 0x158778C
	string get_MetricName() { }

	// RVA: 0x1587794
	void .ctor(string metricName, TelemetryMetricTypes metricType) { }

	// RVA: 0x15877C0
	TelemetryMetricDefinition op_Implicit(string name) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal static class TelemetryMetricDefinitions 
{
	// Fields
	internal static readonly TelemetryMetricDefinition confirmSubscriptionPriceChangeName; // 0x0
	internal static readonly TelemetryMetricDefinition continuePromotionalPurchasesName; // 0x10
	internal static readonly TelemetryMetricDefinition dequeueQueryProductsTimeName; // 0x20
	internal static readonly TelemetryMetricDefinition dequeueQueryPurchasesTimeName; // 0x30
	internal static readonly TelemetryMetricDefinition fetchStorePromotionOrderName; // 0x40
	internal static readonly TelemetryMetricDefinition fetchStorePromotionVisibilityName; // 0x50
	internal static readonly TelemetryMetricDefinition initPurchaseName; // 0x60
	internal static readonly TelemetryMetricDefinition packageInitTimeName; // 0x70
	internal static readonly TelemetryMetricDefinition presentCodeRedemptionSheetName; // 0x80
	internal static readonly TelemetryMetricDefinition refreshAppReceiptName; // 0x90
	internal static readonly TelemetryMetricDefinition restoreTransactionName; // 0xA0
	internal static readonly TelemetryMetricDefinition retrieveProductsName; // 0xB0
	internal static readonly TelemetryMetricDefinition setStorePromotionOrderName; // 0xC0
	internal static readonly TelemetryMetricDefinition setStorePromotionVisibilityName; // 0xD0
	internal static readonly TelemetryMetricDefinition upgradeDowngradeSubscriptionName; // 0xE0

	// Methods

	// RVA: 0x15877F8
	void .cctor() { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryMetricEvent 
{
	// Fields
	private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; // 0x10
	private readonly TelemetryMetricTypes m_MetricType; // 0x18
	private readonly string m_MetricName; // 0x20
	private Stopwatch m_Stopwatch; // 0x28

	// Methods

	// RVA: 0x1587CA8
	void .ctor(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, TelemetryMetricTypes metricType, string metricName) { }

	// RVA: 0x1587D58
	void StartMetric() { }

	// RVA: 0x1587DE8
	void StopAndSendMetric() { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal struct TelemetryMetricParams 
{
	// Fields
	internal TelemetryMetricTypes type; // 0x10
	internal string name; // 0x18
	internal Double timeSeconds; // 0x20

	// Methods

	// RVA: 0x1587F68
	void .ctor(TelemetryMetricTypes metricType, string metricName, Double metricTimeSeconds) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public TelemetryMetricsInstanceWrapper <>4__this; // 0x10
	public TelemetryMetricParams metricParams; // 0x18

	// Methods

	// RVA: 0x1588384
	void .ctor() { }

	// RVA: 0x1588688
	void <SendMetricOnMainThread>b__0() { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryMetricsInstanceWrapper 
{
	// Fields
	private IMetrics m_Instance; // 0x10
	private ILogger m_Logger; // 0x18
	private IUtil m_Util; // 0x20
	private readonly UnityEngine.Purchasing.Telemetry.TelemetryQueue<UnityEngine.Purchasing.Telemetry.TelemetryMetricParams> m_Queue; // 0x28

	// Methods

	// RVA: 0x1587FA4
	void .ctor(ILogger logger, IUtil util) { }

	// RVA: 0x15880B0
	void SetMetricsInstance(IMetrics metricsInstance) { }

	// RVA: 0x158813C
	void SendMetric(TelemetryMetricTypes metricType, string metricName, Double metricTimeSeconds) { }

	// RVA: 0x1588228
	void SendMetricOnMainThread(TelemetryMetricParams metricParams) { }

	// RVA: 0x158838C
	void SendMetricByTypeAndCatchExceptions(TelemetryMetricParams metricParams) { }

	// RVA: 0x15884CC
	void SendMetricByType(TelemetryMetricParams metricParams) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryMetricsService 
{
	// Fields
	private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; // 0x10

	// Methods

	// RVA: 0x15886C8
	void .ctor(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	// RVA: 0x15886FC
	void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition) { }

	// RVA: 0x15888D4
	ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal enum TelemetryMetricTypes 
{
	// Fields
	public int value__; // 0x10
	public const TelemetryMetricTypes Gauge = 0;
	public const TelemetryMetricTypes Sum = 1;
	public const TelemetryMetricTypes Histogram = 2;
}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryQueue<T0> 
{
	// Fields
	private readonly System.Action<TTelemetryEventParams> m_SendTelemetryEvent; // 0x0
	private System.Collections.Concurrent.ConcurrentQueue<TTelemetryEventParams> m_Queue; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(System.Action<TTelemetryEventParams> sendTelemetryEvent) { }

	// RVA: 0x309AF8C
	void QueueEvent(TTelemetryEventParams telemetryEvent) { }

	// RVA: 0x2FE41A8
	void SendQueuedEvents() { }

}

// Namespace: UnityEngine.Purchasing.Extension
public abstract class AbstractPurchasingModule 
{
	// Fields
	protected IPurchasingBinder m_Binder; // 0x10

	// Methods

	// RVA: 0x1588B10
	void Configure(IPurchasingBinder binder) { }

	// RVA: 0x1588B40
	void RegisterStore(string name, IStore store) { }

	// RVA: 0x309AF8C
	void BindExtension(T instance) { }

	// RVA: 0x309AF8C
	void BindConfiguration(T instance) { }

	// RVA: 0x2FE41A8
	void Configure() { }

	// RVA: 0x1588BFC
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Extension
public abstract class AbstractStore 
{
	// Methods

	// RVA: 0x2FE4574
	void Initialize(IStoreCallback callback) { }

	// RVA: 0x2FE4574
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x2FE47D4
	void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x2FE47D4
	void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x1588C04
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface ICatalogProvider 
{
	// Methods

	// RVA: 0x2FE4574
	void FetchProducts(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface IPurchasingBinder 
{
	// Methods

	// RVA: 0x2FE47D4
	void RegisterStore(string name, IStore store) { }

	// RVA: 0x309AF8C
	void RegisterExtension(T instance) { }

	// RVA: 0x309AF8C
	void RegisterConfiguration(T instance) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface IPurchasingModule 
{
	// Methods

	// RVA: 0x2FE4574
	void Configure(IPurchasingBinder binder) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface IStore 
{
	// Methods

	// RVA: 0x2FE4574
	void Initialize(IStoreCallback callback) { }

	// RVA: 0x2FE4574
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x2FE47D4
	void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x2FE47D4
	void FinishTransaction(ProductDefinition product, string transactionId) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface IStoreCallback 
{
	// Methods

	// RVA: 0x2FE360C
	ProductCollection get_products() { }

	// RVA: 0x2FE440C
	void OnSetupFailed(InitializationFailureReason reason, string message) { }

	// RVA: 0x2FE4574
	void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x2FE49A8
	void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier) { }

	// RVA: 0x2FE4574
	void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts) { }

	// RVA: 0x2FE4574
	void OnPurchaseFailed(PurchaseFailureDescription desc) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface IStoreConfiguration 
{}

// Namespace: UnityEngine.Purchasing.Extension
public class ProductDescription 
{
	// Fields
	private string <storeSpecificId>k__BackingField; // 0x10
	public ProductType type; // 0x18
	private ProductMetadata <metadata>k__BackingField; // 0x20
	private string <receipt>k__BackingField; // 0x28
	private string <transactionId>k__BackingField; // 0x30

	// Methods

	// RVA: 0x1588C0C
	void .ctor(string id, ProductMetadata metadata, string receipt, string transactionId) { }

	// RVA: 0x1588C8C
	void .ctor(string id, ProductMetadata metadata, string receipt, string transactionId, ProductType type) { }

	// RVA: 0x1588D18
	void .ctor(string id, ProductMetadata metadata) { }

	// RVA: 0x1588D88
	string get_storeSpecificId() { }

	// RVA: 0x1588D90
	void set_storeSpecificId(string value) { }

	// RVA: 0x1588D98
	ProductMetadata get_metadata() { }

	// RVA: 0x1588DA0
	void set_metadata(ProductMetadata value) { }

	// RVA: 0x1588DA8
	string get_receipt() { }

	// RVA: 0x1588DB0
	void set_receipt(string value) { }

	// RVA: 0x1588DB8
	string get_transactionId() { }

	// RVA: 0x1588DC0
	void set_transactionId(string value) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public class PurchaseFailureDescription 
{
	// Fields
	private string <productId>k__BackingField; // 0x10
	private PurchaseFailureReason <reason>k__BackingField; // 0x18
	private string <message>k__BackingField; // 0x20

	// Methods

	// RVA: 0x15837AC
	void .ctor(string productId, PurchaseFailureReason reason, string message) { }

	// RVA: 0x1588DC8
	string get_productId() { }

	// RVA: 0x1588DD0
	void set_productId(string value) { }

	// RVA: 0x1588DD8
	PurchaseFailureReason get_reason() { }

	// RVA: 0x1588DE0
	void set_reason(PurchaseFailureReason value) { }

	// RVA: 0x1588DE8
	string get_message() { }

	// RVA: 0x1588DF0
	void set_message(string value) { }

}


