// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x1665C94
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1665C9C
	public void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x1665D28
	public void .ctor(Byte ) { }

}

// Namespace: Uniject
internal interface IUtil
{
	// Methods

	// RVA: -1
	public abstract object InitiateCoroutine(IEnumerator start) { }

	// RVA: -1
	public abstract void InitiateCoroutine(IEnumerator start, int delayInSeconds) { }

	// RVA: -1
	public abstract void RunOnMainThread(Action runnable) { }

	// RVA: -1
	public abstract void AddPauseListener(System.Action<System.Boolean> runnable) { }

	// RVA: -1
	public abstract bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant) { }

}

// Namespace: UnityEngine.Purchasing
internal class AnalyticsClient
{
	// Fields
	private readonly IAnalyticsAdapter m_Analytics; // 0x10
	private readonly IAnalyticsAdapter m_LegacyAnalytics; // 0x18

	// Methods

	// RVA: 0x1665D54
	public void .ctor(IAnalyticsAdapter analytics, IAnalyticsAdapter legacyAnalytics) { }

	// RVA: 0x1665DA4
	public void OnPurchaseSucceeded(Product product) { }

	// RVA: 0x1665EF4
	public void OnPurchaseFailed(Product product, PurchaseFailureDescription description) { }

}

// Namespace: UnityEngine.Purchasing
internal class EmptyAnalyticsAdapter
{
	// Methods

	// RVA: 0x1666028
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x166602C
	public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription reason) { }

	// RVA: 0x1666030
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal interface IAnalyticsAdapter
{
	// Methods

	// RVA: -1
	public abstract void SendTransactionEvent(Product product) { }

	// RVA: -1
	public abstract void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IAnalyticsClient
{
	// Methods

	// RVA: -1
	public abstract void OnPurchaseSucceeded(Product product) { }

	// RVA: -1
	public abstract void OnPurchaseFailed(Product product, PurchaseFailureDescription purchaseFailureDescription) { }

}

// Namespace: UnityEngine.Purchasing
internal interface ILegacyUnityAnalytics
{
	// Methods

	// RVA: -1
	public abstract void SendTransactionEvent(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: -1
	public abstract void SendCustomEvent(string name, System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

}

// Namespace: UnityEngine.Purchasing
internal class LegacyAnalyticsAdapter
{
	// Fields
	private readonly ILegacyUnityAnalytics m_LegacyAnalytics; // 0x10

	// Methods

	// RVA: 0x1666038
	public void .ctor(ILegacyUnityAnalytics legacyAnalytics) { }

	// RVA: 0x166606C
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x1666160
	public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

}

// Namespace: UnityEngine.Purchasing
internal class LegacyAnalyticsWrapper
{
	// Fields
	private bool m_Enabled; // 0x10
	private IAnalyticsAdapter m_LegacyAdapter; // 0x18
	private IAnalyticsAdapter m_EmptyAdapter; // 0x20

	// Methods

	// RVA: 0x16663DC
	internal void .ctor(IAnalyticsAdapter legacyAdapter, IAnalyticsAdapter emptyAdapter) { }

	// RVA: 0x1666688
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x166676C
	public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

	// RVA: 0x1666840
	public void OnUpdatedCoreServicesEnvironment(string currentEnvironment) { }

	// RVA: 0x1666750
	private IAnalyticsAdapter get_m_AnalyticsAdapter() { }

}

// Namespace: UnityEngine.Purchasing
internal class LegacyUnityAnalytics
{
	// Methods

	// RVA: 0x1666908
	public void SendTransactionEvent(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: 0x1666928
	public void SendCustomEvent(string name, System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

	// RVA: 0x1666938
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class IDs
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.String,System.String> m_Dic; // 0x10

	// Methods

	// RVA: 0x1666940
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x16669D8
	internal string SpecificIDForStore(string store, string defaultValue) { }

	// RVA: 0x1666A84
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>> GetEnumerator() { }

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

	// RVA: 0x1666B1C
	internal void .ctor(PurchasingFactory factory) { }

	// RVA: 0x1666BCC
	public bool get_useCatalogProvider() { }

	// RVA: 0x1666BD4
	public bool get_logUnavailableProducts() { }

	// RVA: 0x1666BDC
	public System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> get_products() { }

	// RVA: 0x1666BE4
	internal PurchasingFactory get_factory() { }

	// RVA: 0x315B3A8
	public T Configure() { }

	// RVA: 0x1666BEC
	public static ConfigurationBuilder Instance(IPurchasingModule first, IPurchasingModule[] rest) { }

	// RVA: 0x1666E9C
	public ConfigurationBuilder AddProduct(string id, ProductType type) { }

	// RVA: 0x1666EA8
	public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs) { }

	// RVA: 0x1666EB0
	public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts) { }

}

// Namespace: UnityEngine.Purchasing
internal class CoreServicesEnvironmentSubject
{
	// Fields
	private static CoreServicesEnvironmentSubject s_Instance; // 0x0
	private string m_LastKnownEnvironment; // 0x10
	private System.Collections.Generic.List<UnityEngine.Purchasing.ICoreServicesEnvironmentObserver> m_Observers; // 0x18

	// Methods

	// RVA: 0x1666448
	internal static CoreServicesEnvironmentSubject Instance() { }

	// RVA: 0x1666570
	public void SubscribeToUpdatesAndGetCurrent(ICoreServicesEnvironmentObserver newObserver) { }

	// RVA: 0x1667188
	internal void UpdateCurrentEnvironment(string currentEnvironment) { }

	// RVA: 0x16671B0
	private void NotifyObservers() { }

	// RVA: 0x16668B0
	internal bool IsDefaultLiveEnvironment(string environment) { }

	// RVA: 0x16670FC
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal interface ICoreServicesEnvironmentObserver
{
	// Methods

	// RVA: -1
	public abstract void OnUpdatedCoreServicesEnvironment(string currentEnvironment) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IUnityServicesInitializationChecker
{
	// Methods

	// RVA: -1
	public abstract void CheckAndLogWarning() { }

}

// Namespace: UnityEngine.Purchasing
internal class UnityServicesInitializationChecker
{
	// Fields
	private readonly ILogger m_Logger; // 0x10

	// Methods

	// RVA: 0x1667400
	public void .ctor(ILogger logger) { }

	// RVA: 0x1667434
	public void CheckAndLogWarning() { }

	// RVA: 0x16674A0
	private bool IsUninitialized() { }

	// RVA: 0x16675DC
	private void LogWarning() { }

}

// Namespace: UnityEngine.Purchasing
public interface IStoreExtension
{}

// Namespace: UnityEngine.Purchasing
public interface IDetailedStoreListener
{
	// Methods

	// RVA: -1
	public abstract void OnPurchaseFailed(Product product, PurchaseFailureDescription failureDescription) { }

}

// Namespace: UnityEngine.Purchasing
public interface IExtensionProvider
{
	// Methods

	// RVA: -1
	public abstract T GetExtension() { }

}

// Namespace: UnityEngine.Purchasing
internal interface IInternalStoreListener
{
	// Methods

	// RVA: -1
	public abstract void OnInitializeFailed(InitializationFailureReason error, string message) { }

	// RVA: -1
	public abstract PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e) { }

	// RVA: -1
	public abstract void OnPurchaseFailed(Product i, PurchaseFailureDescription p) { }

	// RVA: -1
	public abstract void OnInitialized(IStoreController controller) { }

	// RVA: -1
	public abstract void SendTransactionEvent(Product product) { }

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

	// RVA: -1
	public abstract ProductCollection get_products() { }

	// RVA: -1
	public abstract void InitiatePurchase(Product product, string payload) { }

	// RVA: -1
	public abstract void ConfirmPendingPurchase(Product product) { }

}

// Namespace: UnityEngine.Purchasing
public interface IStoreListener
{
	// Methods

	// RVA: -1
	public abstract void OnInitializeFailed(InitializationFailureReason error, string message) { }

	// RVA: -1
	public abstract PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent) { }

	// RVA: -1
	public abstract void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason) { }

	// RVA: -1
	public abstract void OnInitialized(IStoreController controller, IExtensionProvider extensions) { }

}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class PayoutDefinition
{
	// Fields
	private string m_Subtype; // 0x10
	private Double m_Quantity; // 0x18
	private string m_Data; // 0x20

	// Methods

	// RVA: 0x1667700
	public Double get_quantity() { }

	// RVA: 0x1667708
	public void .ctor() { }

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

	// RVA: 0x166778C
	internal void .ctor(ProductDefinition definition, ProductMetadata metadata, string receipt) { }

	// RVA: 0x16677F0
	internal void .ctor(ProductDefinition definition, ProductMetadata metadata) { }

	// RVA: 0x1667850
	public ProductDefinition get_definition() { }

	// RVA: 0x1667858
	private void set_definition(ProductDefinition value) { }

	// RVA: 0x1667860
	public ProductMetadata get_metadata() { }

	// RVA: 0x1667868
	internal void set_metadata(ProductMetadata value) { }

	// RVA: 0x1667870
	public bool get_availableToPurchase() { }

	// RVA: 0x1667878
	internal void set_availableToPurchase(bool value) { }

	// RVA: 0x1667880
	public string get_transactionID() { }

	// RVA: 0x1667888
	internal void set_transactionID(string value) { }

	// RVA: 0x1667890
	internal void set_appleOriginalTransactionID(string value) { }

	// RVA: 0x1667898
	public bool get_appleProductIsRestored() { }

	// RVA: 0x16678A0
	internal void set_appleProductIsRestored(bool value) { }

	// RVA: 0x16678A8
	public bool get_hasReceipt() { }

	// RVA: 0x16678C8
	public string get_receipt() { }

	// RVA: 0x16678D0
	internal void set_receipt(string value) { }

	// RVA: 0x16678D8
	public override bool Equals(object obj) { }

	// RVA: 0x1667984
	public override int GetHashCode() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.ProductCollection.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.Product,System.String> <>9__3_0; // 0x8
	public static System.Func<UnityEngine.Purchasing.Product,System.String> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x1667DC8
	private static void .cctor() { }

	// RVA: 0x1667E34
	public void .ctor() { }

	// RVA: 0x1667E3C
	internal string <AddProducts>b__3_0(Product x) { }

	// RVA: 0x1667E60
	internal string <AddProducts>b__3_1(Product x) { }

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

	// RVA: 0x16679A8
	internal void .ctor(Product[] products) { }

	// RVA: 0x1667A4C
	internal void AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products) { }

	// RVA: 0x1667C9C
	public System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> get_set() { }

	// RVA: 0x1667CA4
	public Product[] get_all() { }

	// RVA: 0x1667CAC
	private void set_all(Product[] value) { }

	// RVA: 0x1667CB4
	public Product WithID(string id) { }

	// RVA: 0x1667D30
	public Product WithStoreSpecificID(string id) { }

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

	// RVA: 0x1667010
	public void .ctor(string id, string storeSpecificId, ProductType type) { }

	// RVA: 0x1667E84
	public void .ctor(string id, string storeSpecificId, ProductType type, bool enabled) { }

	// RVA: 0x1667E8C
	public void .ctor(string id, string storeSpecificId, ProductType type, bool enabled, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts) { }

	// RVA: 0x1667F78
	public void .ctor(string id, ProductType type) { }

	// RVA: 0x1667F8C
	public string get_id() { }

	// RVA: 0x1667F94
	private void set_id(string value) { }

	// RVA: 0x1667F9C
	public string get_storeSpecificId() { }

	// RVA: 0x1667FA4
	private void set_storeSpecificId(string value) { }

	// RVA: 0x1667FAC
	public ProductType get_type() { }

	// RVA: 0x1667FB4
	private void set_type(ProductType value) { }

	// RVA: 0x1667FBC
	public bool get_enabled() { }

	// RVA: 0x1667FC4
	private void set_enabled(bool value) { }

	// RVA: 0x1667FCC
	public override bool Equals(object obj) { }

	// RVA: 0x166806C
	public override int GetHashCode() { }

	// RVA: 0x1668090
	public System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> get_payouts() { }

	// RVA: 0x1668098
	public PayoutDefinition get_payout() { }

	// RVA: 0x166701C
	internal void SetPayouts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> newPayouts) { }

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

	// RVA: 0x1668130
	public void .ctor(string priceString, string title, string description, string currencyCode, Decimal localizedPrice) { }

	// RVA: 0x16681C8
	public void .ctor(ProductMetadata productMetadata) { }

	// RVA: 0x1668240
	public void .ctor() { }

	// RVA: 0x1668248
	public string get_localizedPriceString() { }

	// RVA: 0x1668250
	internal void set_localizedPriceString(string value) { }

	// RVA: 0x1668258
	public string get_localizedTitle() { }

	// RVA: 0x1668260
	internal void set_localizedTitle(string value) { }

	// RVA: 0x1668268
	public string get_localizedDescription() { }

	// RVA: 0x1668270
	internal void set_localizedDescription(string value) { }

	// RVA: 0x1668278
	public string get_isoCurrencyCode() { }

	// RVA: 0x1668280
	internal void set_isoCurrencyCode(string value) { }

	// RVA: 0x1668288
	public Decimal get_localizedPrice() { }

	// RVA: 0x1668294
	internal void set_localizedPrice(Decimal value) { }

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

	// RVA: 0x166829C
	internal void .ctor(Product purchasedProduct) { }

	// RVA: 0x16682D0
	public Product get_purchasedProduct() { }

	// RVA: 0x16682D8
	private void set_purchasedProduct(Product value) { }

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

	// RVA: 0x1666C88
	public void .ctor(IPurchasingModule first, IPurchasingModule[] remainingModules) { }

	// RVA: 0x16682E0
	public string get_storeName() { }

	// RVA: 0x16682E8
	private void set_storeName(string value) { }

	// RVA: 0x16682F0
	public IStore get_service() { }

	// RVA: 0x1668358
	public void set_service(IStore value) { }

	// RVA: 0x1668360
	public void RegisterStore(string name, IStore s) { }

	// RVA: 0x315B3A8
	public void RegisterExtension(T instance) { }

	// RVA: 0x315B3A8
	public void RegisterConfiguration(T instance) { }

	// RVA: 0x315B3A8
	public T GetConfig() { }

	// RVA: 0x315B3A8
	public T GetExtension() { }

	// RVA: 0x16683C0
	internal ICatalogProvider GetCatalogProvider() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.PurchasingManager.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Product> <>9__45_0; // 0x8

	// Methods

	// RVA: 0x166AA44
	private static void .cctor() { }

	// RVA: 0x166AAB0
	public void .ctor() { }

	// RVA: 0x166AAB8
	internal Product <Initialize>b__45_0(ProductDefinition x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass27_0
{
	// Fields
	public Product product; // 0x10

	// Methods

	// RVA: 0x1669248
	public void .ctor() { }

	// RVA: 0x166AB74
	internal bool <OnAllPurchasesRetrieved>b__0(Product firstPurchasedProduct) { }

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

	// RVA: 0x16683C8
	public bool get_useTransactionLog() { }

	// RVA: 0x16683D0
	public void set_useTransactionLog(bool value) { }

	// RVA: 0x16683D8
	internal void .ctor(TransactionLog tDb, ILogger logger, IStore store, string storeName, IUnityServicesInitializationChecker unityServicesInitializationChecker, bool logUnavailableProducts) { }

	// RVA: 0x16684F0
	public void InitiatePurchase(Product product, string developerPayload) { }

	// RVA: 0x16687E8
	public void ConfirmPendingPurchase(Product product) { }

	// RVA: 0x1668BFC
	public ProductCollection get_products() { }

	// RVA: 0x1668C04
	private void set_products(ProductCollection value) { }

	// RVA: 0x1668C0C
	public void OnPurchaseSucceeded(string id, string receipt, string transactionId) { }

	// RVA: 0x1668DB8
	private void UpdateProductReceiptAndTransactionID(Product product, string receipt, string transactionId) { }

	// RVA: 0x1669020
	public void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts) { }

	// RVA: 0x166935C
	internal static void OnEntitlementRevoked(Product revokedProduct) { }

	// RVA: 0x1669250
	private void HandlePurchaseRetrieved(Product product, Product purchasedProduct) { }

	// RVA: 0x1669398
	private bool WasPurchaseAlreadyProcessed(string transactionId) { }

	// RVA: 0x1669320
	private static void ClearProductReceipt(Product product) { }

	// RVA: 0x16693FC
	public void OnSetupFailed(InitializationFailureReason reason, string message) { }

	// RVA: 0x1669520
	public void OnPurchaseFailed(PurchaseFailureDescription description) { }

	// RVA: 0x16699DC
	public void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x166900C
	private string CreateUnifiedReceipt(string rawReceipt, string transactionId) { }

	// RVA: 0x1669FE4
	private void ProcessPurchaseOnStart() { }

	// RVA: 0x1668E10
	private void ProcessPurchaseIfNew(Product product) { }

	// RVA: 0x166A2A0
	private bool HasRecordedTransaction(string transactionId) { }

	// RVA: 0x1669E28
	private void CheckForInitialization(int productCount) { }

	// RVA: 0x166A388
	private bool HasAvailableProductsToPurchase() { }

	// RVA: 0x166A754
	public void Initialize(IInternalStoreListener listener, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> products) { }

}

// Namespace: UnityEngine.Purchasing
internal class StoreListenerProxy
{
	// Fields
	private readonly IAnalyticsClient m_Analytics; // 0x10
	private readonly IStoreListener m_ForwardTo; // 0x18
	private readonly IExtensionProvider m_Extensions; // 0x20

	// Methods

	// RVA: 0x166ABB0
	public void .ctor(IStoreListener forwardTo, IAnalyticsClient analytics, IExtensionProvider extensions) { }

	// RVA: 0x166AC14
	public void OnInitialized(IStoreController controller) { }

	// RVA: 0x166ACD4
	public void OnInitializeFailed(InitializationFailureReason error, string message) { }

	// RVA: 0x166AD90
	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e) { }

	// RVA: 0x166AE48
	public void OnPurchaseFailed(Product i, PurchaseFailureDescription p) { }

	// RVA: 0x166B030
	public void SendTransactionEvent(Product product) { }

}

// Namespace: UnityEngine.Purchasing
internal class TransactionLog
{
	// Fields
	private readonly ILogger logger; // 0x10
	private readonly string persistentDataPath; // 0x18

	// Methods

	// RVA: 0x166B0E4
	public void .ctor(ILogger logger, string persistentDataPath) { }

	// RVA: 0x166A2D0
	public bool HasRecordOf(string transactionID) { }

	// RVA: 0x1668AA8
	public void Record(string transactionID) { }

	// RVA: 0x166B1D4
	private string GetRecordPath(string transactionID) { }

	// RVA: 0x166B250
	internal static string ComputeHash(string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class UnifiedReceipt
{
	// Fields
	public string Payload; // 0x10
	public string Store; // 0x18
	public string TransactionID; // 0x20

	// Methods

	// RVA: 0x166B3E4
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public PurchasingManager manager; // 0x10
	public StoreListenerProxy proxy; // 0x18

	// Methods

	// RVA: 0x166BA48
	public void .ctor() { }

	// RVA: 0x166BBE0
	internal void <Initialize>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> response) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet; // 0x10
	public System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback; // 0x18

	// Methods

	// RVA: 0x166BBD8
	public void .ctor() { }

	// RVA: 0x166BC08
	internal void <FetchAndMergeProducts>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> cloudProducts) { }

}

// Namespace: UnityEngine.Purchasing
public abstract class UnityPurchasing
{
	// Methods

	// RVA: 0x166B3EC
	public static void Initialize(IDetailedStoreListener listener, ConfigurationBuilder builder) { }

	// RVA: 0x166B6E8
	private static IAnalyticsAdapter GenerateUnityAnalytics(ILogger logger) { }

	// RVA: 0x166B650
	private static IAnalyticsAdapter GenerateLegacyUnityAnalytics() { }

	// RVA: 0x166B740
	internal static void Initialize(IStoreListener listener, ConfigurationBuilder builder, ILogger logger, string persistentDatapath, IAnalyticsAdapter ugsAnalytics, IAnalyticsAdapter legacyAnalytics, ICatalogProvider catalog, IUnityServicesInitializationChecker unityServicesInitializationChecker) { }

	// RVA: 0x166BA50
	internal static void FetchAndMergeProducts(bool useCatalog, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet, ICatalogProvider catalog, System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback) { }

}

// Namespace: UnityEngine.Purchasing
internal static class LoggerExtensions
{
	// Methods

	// RVA: 0x1667630
	public static void LogIAPWarning(ILogger logger, string message) { }

	// RVA: 0x16689D8
	public static void LogIAPError(ILogger logger, string message) { }

}

// Namespace: UnityEngine.Purchasing
internal static class ProductPurchaseUpdater
{
	// Methods

	// RVA: 0x166BEFC
	internal static void UpdateProductReceiptAndTransactionID(Product product, string receipt, string transactionId, string storeName) { }

}

// Namespace: UnityEngine.Purchasing
internal static class UnifiedReceiptFormatter
{
	// Methods

	// RVA: 0x166A1F0
	internal static string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryDiagnostics
{
	// Methods

	// RVA: -1
	public abstract void SendDiagnostic(string diagnosticName, Exception e) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryDiagnosticsInstanceWrapper
{
	// Methods

	// RVA: -1
	public abstract void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance) { }

	// RVA: -1
	public abstract void SendDiagnostic(string diagnosticName, string diagnosticException) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal struct TelemetryDiagnosticParams
{
	// Fields
	internal string name; // 0x10
	internal string exception; // 0x18

	// Methods

	// RVA: 0x166BF50
	internal void .ctor(string diagnosticName, string diagnosticException) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryDiagnostics
{
	// Fields
	private readonly ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper; // 0x10

	// Methods

	// RVA: 0x166BF84
	public void .ctor(ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper) { }

	// RVA: 0x166BFB8
	public void SendDiagnostic(string diagnosticName, Exception e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public TelemetryDiagnosticsInstanceWrapper <>4__this; // 0x10
	public TelemetryDiagnosticParams diagnosticParams; // 0x18

	// Methods

	// RVA: 0x166C528
	public void .ctor() { }

	// RVA: 0x166C6D8
	internal void <SendDiagnosticOnMainThread>b__0() { }

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

	// RVA: 0x166C188
	public void .ctor(ILogger logger, IUtil util) { }

	// RVA: 0x166C294
	public void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance) { }

	// RVA: 0x166C304
	public void SendDiagnostic(string diagnosticName, string diagnosticException) { }

	// RVA: 0x166C3D0
	private void SendDiagnosticOnMainThread(TelemetryDiagnosticParams diagnosticParams) { }

	// RVA: 0x166C530
	private void SendDiagnosticAndCatchExceptions(TelemetryDiagnosticParams diagnosticParams) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class IapTelemetryException
{
	// Methods

	// RVA: 0x166C6FC
	public void .ctor(string message) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryMetricEvent
{
	// Methods

	// RVA: -1
	public abstract void StartMetric() { }

	// RVA: -1
	public abstract void StopAndSendMetric() { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryMetricsInstanceWrapper
{
	// Methods

	// RVA: -1
	public abstract void SetMetricsInstance(IMetrics metricsInstance) { }

	// RVA: -1
	public abstract void SendMetric(TelemetryMetricTypes telemetryMetricTypes, string metricName, Double metricTimeSeconds) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal interface ITelemetryMetricsService
{
	// Methods

	// RVA: -1
	public abstract void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal struct TelemetryMetricDefinition
{
	// Fields
	private readonly TelemetryMetricTypes <MetricType>k__BackingField; // 0x10
	private readonly string <MetricName>k__BackingField; // 0x18

	// Methods

	// RVA: 0x166C768
	public TelemetryMetricTypes get_MetricType() { }

	// RVA: 0x166C770
	public string get_MetricName() { }

	// RVA: 0x166C778
	public void .ctor(string metricName, TelemetryMetricTypes metricType) { }

	// RVA: 0x166C7A4
	public static TelemetryMetricDefinition op_Implicit(string name) { }

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

	// RVA: 0x166C7DC
	private static void .cctor() { }

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

	// RVA: 0x166CC8C
	internal void .ctor(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, TelemetryMetricTypes metricType, string metricName) { }

	// RVA: 0x166CD3C
	public void StartMetric() { }

	// RVA: 0x166CDCC
	public void StopAndSendMetric() { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal struct TelemetryMetricParams
{
	// Fields
	internal TelemetryMetricTypes type; // 0x10
	internal string name; // 0x18
	internal Double timeSeconds; // 0x20

	// Methods

	// RVA: 0x166CF4C
	internal void .ctor(TelemetryMetricTypes metricType, string metricName, Double metricTimeSeconds) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public TelemetryMetricsInstanceWrapper <>4__this; // 0x10
	public TelemetryMetricParams metricParams; // 0x18

	// Methods

	// RVA: 0x166D368
	public void .ctor() { }

	// RVA: 0x166D66C
	internal void <SendMetricOnMainThread>b__0() { }

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

	// RVA: 0x166CF88
	public void .ctor(ILogger logger, IUtil util) { }

	// RVA: 0x166D094
	public void SetMetricsInstance(IMetrics metricsInstance) { }

	// RVA: 0x166D120
	public void SendMetric(TelemetryMetricTypes metricType, string metricName, Double metricTimeSeconds) { }

	// RVA: 0x166D20C
	private void SendMetricOnMainThread(TelemetryMetricParams metricParams) { }

	// RVA: 0x166D370
	private void SendMetricByTypeAndCatchExceptions(TelemetryMetricParams metricParams) { }

	// RVA: 0x166D4B0
	private void SendMetricByType(TelemetryMetricParams metricParams) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryMetricsService
{
	// Fields
	private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; // 0x10

	// Methods

	// RVA: 0x166D6AC
	public void .ctor(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	// RVA: 0x166D6E0
	public void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition) { }

	// RVA: 0x166D8B8
	public ITelemetryMetricEvent CreateAndStartMetricEvent(TelemetryMetricDefinition metricDefinition) { }

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

	// RVA: 0x30A27C0
	public void .ctor(System.Action<TTelemetryEventParams> sendTelemetryEvent) { }

	// RVA: 0x315B3A8
	internal void QueueEvent(TTelemetryEventParams telemetryEvent) { }

	// RVA: 0x30A2378
	internal void SendQueuedEvents() { }

}

// Namespace: UnityEngine.Purchasing.Extension
public abstract class AbstractPurchasingModule
{
	// Fields
	protected IPurchasingBinder m_Binder; // 0x10

	// Methods

	// RVA: 0x166DAF4
	public void Configure(IPurchasingBinder binder) { }

	// RVA: 0x166DB24
	protected void RegisterStore(string name, IStore store) { }

	// RVA: 0x315B3A8
	protected void BindExtension(T instance) { }

	// RVA: 0x315B3A8
	protected void BindConfiguration(T instance) { }

	// RVA: -1
	public abstract void Configure() { }

	// RVA: 0x166DBE0
	protected void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Extension
public abstract class AbstractStore
{
	// Methods

	// RVA: -1
	public abstract void Initialize(IStoreCallback callback) { }

	// RVA: -1
	public abstract void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: -1
	public abstract void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: -1
	public abstract void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x166DBE8
	protected void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface ICatalogProvider
{
	// Methods

	// RVA: -1
	public abstract void FetchProducts(System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface IPurchasingBinder
{
	// Methods

	// RVA: -1
	public abstract void RegisterStore(string name, IStore store) { }

	// RVA: -1
	public abstract void RegisterExtension(T instance) { }

	// RVA: -1
	public abstract void RegisterConfiguration(T instance) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface IPurchasingModule
{
	// Methods

	// RVA: -1
	public abstract void Configure(IPurchasingBinder binder) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface IStore
{
	// Methods

	// RVA: -1
	public abstract void Initialize(IStoreCallback callback) { }

	// RVA: -1
	public abstract void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: -1
	public abstract void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: -1
	public abstract void FinishTransaction(ProductDefinition product, string transactionId) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public interface IStoreCallback
{
	// Methods

	// RVA: -1
	public abstract ProductCollection get_products() { }

	// RVA: -1
	public abstract void OnSetupFailed(InitializationFailureReason reason, string message) { }

	// RVA: -1
	public abstract void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: -1
	public abstract void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier) { }

	// RVA: -1
	public abstract void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts) { }

	// RVA: -1
	public abstract void OnPurchaseFailed(PurchaseFailureDescription desc) { }

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

	// RVA: 0x166DBF0
	public void .ctor(string id, ProductMetadata metadata, string receipt, string transactionId) { }

	// RVA: 0x166DC70
	public void .ctor(string id, ProductMetadata metadata, string receipt, string transactionId, ProductType type) { }

	// RVA: 0x166DCFC
	public void .ctor(string id, ProductMetadata metadata) { }

	// RVA: 0x166DD6C
	public string get_storeSpecificId() { }

	// RVA: 0x166DD74
	private void set_storeSpecificId(string value) { }

	// RVA: 0x166DD7C
	public ProductMetadata get_metadata() { }

	// RVA: 0x166DD84
	private void set_metadata(ProductMetadata value) { }

	// RVA: 0x166DD8C
	public string get_receipt() { }

	// RVA: 0x166DD94
	private void set_receipt(string value) { }

	// RVA: 0x166DD9C
	public string get_transactionId() { }

	// RVA: 0x166DDA4
	public void set_transactionId(string value) { }

}

// Namespace: UnityEngine.Purchasing.Extension
public class PurchaseFailureDescription
{
	// Fields
	private string <productId>k__BackingField; // 0x10
	private PurchaseFailureReason <reason>k__BackingField; // 0x18
	private string <message>k__BackingField; // 0x20

	// Methods

	// RVA: 0x1668790
	public void .ctor(string productId, PurchaseFailureReason reason, string message) { }

	// RVA: 0x166DDAC
	public string get_productId() { }

	// RVA: 0x166DDB4
	private void set_productId(string value) { }

	// RVA: 0x166DDBC
	public PurchaseFailureReason get_reason() { }

	// RVA: 0x166DDC4
	private void set_reason(PurchaseFailureReason value) { }

	// RVA: 0x166DDCC
	public string get_message() { }

	// RVA: 0x166DDD4
	private void set_message(string value) { }

}


