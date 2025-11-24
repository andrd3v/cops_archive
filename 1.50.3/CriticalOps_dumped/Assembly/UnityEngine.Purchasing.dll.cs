// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x1698088
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1698090
	public void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x169811C
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

	// RVA: 0x1698148
	public void .ctor(IAnalyticsAdapter analytics, IAnalyticsAdapter legacyAnalytics) { }

	// RVA: 0x1698198
	public void OnPurchaseSucceeded(Product product) { }

	// RVA: 0x16982E8
	public void OnPurchaseFailed(Product product, PurchaseFailureDescription description) { }

}

// Namespace: UnityEngine.Purchasing
internal class EmptyAnalyticsAdapter
{
	// Methods

	// RVA: 0x169841C
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x1698420
	public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription reason) { }

	// RVA: 0x1698424
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

	// RVA: 0x169842C
	public void .ctor(ILegacyUnityAnalytics legacyAnalytics) { }

	// RVA: 0x1698460
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x1698554
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

	// RVA: 0x16987D0
	internal void .ctor(IAnalyticsAdapter legacyAdapter, IAnalyticsAdapter emptyAdapter) { }

	// RVA: 0x1698A7C
	public void SendTransactionEvent(Product product) { }

	// RVA: 0x1698B60
	public void SendTransactionFailedEvent(Product product, PurchaseFailureDescription description) { }

	// RVA: 0x1698C34
	public void OnUpdatedCoreServicesEnvironment(string currentEnvironment) { }

	// RVA: 0x1698B44
	private IAnalyticsAdapter get_m_AnalyticsAdapter() { }

}

// Namespace: UnityEngine.Purchasing
internal class LegacyUnityAnalytics
{
	// Methods

	// RVA: 0x1698CFC
	public void SendTransactionEvent(string productId, Decimal amount, string currency, string receiptPurchaseData, string signature) { }

	// RVA: 0x1698D1C
	public void SendCustomEvent(string name, System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

	// RVA: 0x1698D2C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class IDs
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.String,System.String> m_Dic; // 0x10

	// Methods

	// RVA: 0x1698D34
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1698DCC
	internal string SpecificIDForStore(string store, string defaultValue) { }

	// RVA: 0x1698E78
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

	// RVA: 0x1698F10
	internal void .ctor(PurchasingFactory factory) { }

	// RVA: 0x1698FC0
	public bool get_useCatalogProvider() { }

	// RVA: 0x1698FC8
	public bool get_logUnavailableProducts() { }

	// RVA: 0x1698FD0
	public System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> get_products() { }

	// RVA: 0x1698FD8
	internal PurchasingFactory get_factory() { }

	// RVA: 0x318DB98
	public T Configure() { }

	// RVA: 0x1698FE0
	public static ConfigurationBuilder Instance(IPurchasingModule first, IPurchasingModule[] rest) { }

	// RVA: 0x1699290
	public ConfigurationBuilder AddProduct(string id, ProductType type) { }

	// RVA: 0x169929C
	public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs) { }

	// RVA: 0x16992A4
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

	// RVA: 0x169883C
	internal static CoreServicesEnvironmentSubject Instance() { }

	// RVA: 0x1698964
	public void SubscribeToUpdatesAndGetCurrent(ICoreServicesEnvironmentObserver newObserver) { }

	// RVA: 0x169957C
	internal void UpdateCurrentEnvironment(string currentEnvironment) { }

	// RVA: 0x16995A4
	private void NotifyObservers() { }

	// RVA: 0x1698CA4
	internal bool IsDefaultLiveEnvironment(string environment) { }

	// RVA: 0x16994F0
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

	// RVA: 0x16997F4
	public void .ctor(ILogger logger) { }

	// RVA: 0x1699828
	public void CheckAndLogWarning() { }

	// RVA: 0x1699894
	private bool IsUninitialized() { }

	// RVA: 0x16999D0
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

	// RVA: 0x1699AF4
	public Double get_quantity() { }

	// RVA: 0x1699AFC
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

	// RVA: 0x1699B80
	internal void .ctor(ProductDefinition definition, ProductMetadata metadata, string receipt) { }

	// RVA: 0x1699BE4
	internal void .ctor(ProductDefinition definition, ProductMetadata metadata) { }

	// RVA: 0x1699C44
	public ProductDefinition get_definition() { }

	// RVA: 0x1699C4C
	private void set_definition(ProductDefinition value) { }

	// RVA: 0x1699C54
	public ProductMetadata get_metadata() { }

	// RVA: 0x1699C5C
	internal void set_metadata(ProductMetadata value) { }

	// RVA: 0x1699C64
	public bool get_availableToPurchase() { }

	// RVA: 0x1699C6C
	internal void set_availableToPurchase(bool value) { }

	// RVA: 0x1699C74
	public string get_transactionID() { }

	// RVA: 0x1699C7C
	internal void set_transactionID(string value) { }

	// RVA: 0x1699C84
	internal void set_appleOriginalTransactionID(string value) { }

	// RVA: 0x1699C8C
	public bool get_appleProductIsRestored() { }

	// RVA: 0x1699C94
	internal void set_appleProductIsRestored(bool value) { }

	// RVA: 0x1699C9C
	public bool get_hasReceipt() { }

	// RVA: 0x1699CBC
	public string get_receipt() { }

	// RVA: 0x1699CC4
	internal void set_receipt(string value) { }

	// RVA: 0x1699CCC
	public override bool Equals(object obj) { }

	// RVA: 0x1699D78
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

	// RVA: 0x169A1BC
	private static void .cctor() { }

	// RVA: 0x169A228
	public void .ctor() { }

	// RVA: 0x169A230
	internal string <AddProducts>b__3_0(Product x) { }

	// RVA: 0x169A254
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

	// RVA: 0x1699D9C
	internal void .ctor(Product[] products) { }

	// RVA: 0x1699E40
	internal void AddProducts(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> products) { }

	// RVA: 0x169A090
	public System.Collections.Generic.HashSet<UnityEngine.Purchasing.Product> get_set() { }

	// RVA: 0x169A098
	public Product[] get_all() { }

	// RVA: 0x169A0A0
	private void set_all(Product[] value) { }

	// RVA: 0x169A0A8
	public Product WithID(string id) { }

	// RVA: 0x169A124
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

	// RVA: 0x1699404
	public void .ctor(string id, string storeSpecificId, ProductType type) { }

	// RVA: 0x169A278
	public void .ctor(string id, string storeSpecificId, ProductType type, bool enabled) { }

	// RVA: 0x169A280
	public void .ctor(string id, string storeSpecificId, ProductType type, bool enabled, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> payouts) { }

	// RVA: 0x169A36C
	public void .ctor(string id, ProductType type) { }

	// RVA: 0x169A380
	public string get_id() { }

	// RVA: 0x169A388
	private void set_id(string value) { }

	// RVA: 0x169A390
	public string get_storeSpecificId() { }

	// RVA: 0x169A398
	private void set_storeSpecificId(string value) { }

	// RVA: 0x169A3A0
	public ProductType get_type() { }

	// RVA: 0x169A3A8
	private void set_type(ProductType value) { }

	// RVA: 0x169A3B0
	public bool get_enabled() { }

	// RVA: 0x169A3B8
	private void set_enabled(bool value) { }

	// RVA: 0x169A3C0
	public override bool Equals(object obj) { }

	// RVA: 0x169A460
	public override int GetHashCode() { }

	// RVA: 0x169A484
	public System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.PayoutDefinition> get_payouts() { }

	// RVA: 0x169A48C
	public PayoutDefinition get_payout() { }

	// RVA: 0x1699410
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

	// RVA: 0x169A524
	public void .ctor(string priceString, string title, string description, string currencyCode, Decimal localizedPrice) { }

	// RVA: 0x169A5BC
	public void .ctor(ProductMetadata productMetadata) { }

	// RVA: 0x169A634
	public void .ctor() { }

	// RVA: 0x169A63C
	public string get_localizedPriceString() { }

	// RVA: 0x169A644
	internal void set_localizedPriceString(string value) { }

	// RVA: 0x169A64C
	public string get_localizedTitle() { }

	// RVA: 0x169A654
	internal void set_localizedTitle(string value) { }

	// RVA: 0x169A65C
	public string get_localizedDescription() { }

	// RVA: 0x169A664
	internal void set_localizedDescription(string value) { }

	// RVA: 0x169A66C
	public string get_isoCurrencyCode() { }

	// RVA: 0x169A674
	internal void set_isoCurrencyCode(string value) { }

	// RVA: 0x169A67C
	public Decimal get_localizedPrice() { }

	// RVA: 0x169A688
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

	// RVA: 0x169A690
	internal void .ctor(Product purchasedProduct) { }

	// RVA: 0x169A6C4
	public Product get_purchasedProduct() { }

	// RVA: 0x169A6CC
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

	// RVA: 0x169907C
	public void .ctor(IPurchasingModule first, IPurchasingModule[] remainingModules) { }

	// RVA: 0x169A6D4
	public string get_storeName() { }

	// RVA: 0x169A6DC
	private void set_storeName(string value) { }

	// RVA: 0x169A6E4
	public IStore get_service() { }

	// RVA: 0x169A74C
	public void set_service(IStore value) { }

	// RVA: 0x169A754
	public void RegisterStore(string name, IStore s) { }

	// RVA: 0x318DB98
	public void RegisterExtension(T instance) { }

	// RVA: 0x318DB98
	public void RegisterConfiguration(T instance) { }

	// RVA: 0x318DB98
	public T GetConfig() { }

	// RVA: 0x318DB98
	public T GetExtension() { }

	// RVA: 0x169A7B4
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

	// RVA: 0x169CE38
	private static void .cctor() { }

	// RVA: 0x169CEA4
	public void .ctor() { }

	// RVA: 0x169CEAC
	internal Product <Initialize>b__45_0(ProductDefinition x) { }

}

// Namespace: 
private sealed class <>c__DisplayClass27_0
{
	// Fields
	public Product product; // 0x10

	// Methods

	// RVA: 0x169B63C
	public void .ctor() { }

	// RVA: 0x169CF68
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

	// RVA: 0x169A7BC
	public bool get_useTransactionLog() { }

	// RVA: 0x169A7C4
	public void set_useTransactionLog(bool value) { }

	// RVA: 0x169A7CC
	internal void .ctor(TransactionLog tDb, ILogger logger, IStore store, string storeName, IUnityServicesInitializationChecker unityServicesInitializationChecker, bool logUnavailableProducts) { }

	// RVA: 0x169A8E4
	public void InitiatePurchase(Product product, string developerPayload) { }

	// RVA: 0x169ABDC
	public void ConfirmPendingPurchase(Product product) { }

	// RVA: 0x169AFF0
	public ProductCollection get_products() { }

	// RVA: 0x169AFF8
	private void set_products(ProductCollection value) { }

	// RVA: 0x169B000
	public void OnPurchaseSucceeded(string id, string receipt, string transactionId) { }

	// RVA: 0x169B1AC
	private void UpdateProductReceiptAndTransactionID(Product product, string receipt, string transactionId) { }

	// RVA: 0x169B414
	public void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts) { }

	// RVA: 0x169B750
	internal static void OnEntitlementRevoked(Product revokedProduct) { }

	// RVA: 0x169B644
	private void HandlePurchaseRetrieved(Product product, Product purchasedProduct) { }

	// RVA: 0x169B78C
	private bool WasPurchaseAlreadyProcessed(string transactionId) { }

	// RVA: 0x169B714
	private static void ClearProductReceipt(Product product) { }

	// RVA: 0x169B7F0
	public void OnSetupFailed(InitializationFailureReason reason, string message) { }

	// RVA: 0x169B914
	public void OnPurchaseFailed(PurchaseFailureDescription description) { }

	// RVA: 0x169BDD0
	public void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x169B400
	private string CreateUnifiedReceipt(string rawReceipt, string transactionId) { }

	// RVA: 0x169C3D8
	private void ProcessPurchaseOnStart() { }

	// RVA: 0x169B204
	private void ProcessPurchaseIfNew(Product product) { }

	// RVA: 0x169C694
	private bool HasRecordedTransaction(string transactionId) { }

	// RVA: 0x169C21C
	private void CheckForInitialization(int productCount) { }

	// RVA: 0x169C77C
	private bool HasAvailableProductsToPurchase() { }

	// RVA: 0x169CB48
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

	// RVA: 0x169CFA4
	public void .ctor(IStoreListener forwardTo, IAnalyticsClient analytics, IExtensionProvider extensions) { }

	// RVA: 0x169D008
	public void OnInitialized(IStoreController controller) { }

	// RVA: 0x169D0C8
	public void OnInitializeFailed(InitializationFailureReason error, string message) { }

	// RVA: 0x169D184
	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e) { }

	// RVA: 0x169D23C
	public void OnPurchaseFailed(Product i, PurchaseFailureDescription p) { }

	// RVA: 0x169D424
	public void SendTransactionEvent(Product product) { }

}

// Namespace: UnityEngine.Purchasing
internal class TransactionLog
{
	// Fields
	private readonly ILogger logger; // 0x10
	private readonly string persistentDataPath; // 0x18

	// Methods

	// RVA: 0x169D4D8
	public void .ctor(ILogger logger, string persistentDataPath) { }

	// RVA: 0x169C6C4
	public bool HasRecordOf(string transactionID) { }

	// RVA: 0x169AE9C
	public void Record(string transactionID) { }

	// RVA: 0x169D5C8
	private string GetRecordPath(string transactionID) { }

	// RVA: 0x169D644
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

	// RVA: 0x169D7D8
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public PurchasingManager manager; // 0x10
	public StoreListenerProxy proxy; // 0x18

	// Methods

	// RVA: 0x169DE3C
	public void .ctor() { }

	// RVA: 0x169DFD4
	internal void <Initialize>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> response) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet; // 0x10
	public System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback; // 0x18

	// Methods

	// RVA: 0x169DFCC
	public void .ctor() { }

	// RVA: 0x169DFFC
	internal void <FetchAndMergeProducts>b__0(System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> cloudProducts) { }

}

// Namespace: UnityEngine.Purchasing
public abstract class UnityPurchasing
{
	// Methods

	// RVA: 0x169D7E0
	public static void Initialize(IDetailedStoreListener listener, ConfigurationBuilder builder) { }

	// RVA: 0x169DADC
	private static IAnalyticsAdapter GenerateUnityAnalytics(ILogger logger) { }

	// RVA: 0x169DA44
	private static IAnalyticsAdapter GenerateLegacyUnityAnalytics() { }

	// RVA: 0x169DB34
	internal static void Initialize(IStoreListener listener, ConfigurationBuilder builder, ILogger logger, string persistentDatapath, IAnalyticsAdapter ugsAnalytics, IAnalyticsAdapter legacyAnalytics, ICatalogProvider catalog, IUnityServicesInitializationChecker unityServicesInitializationChecker) { }

	// RVA: 0x169DE44
	internal static void FetchAndMergeProducts(bool useCatalog, System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition> localProductSet, ICatalogProvider catalog, System.Action<System.Collections.Generic.HashSet<UnityEngine.Purchasing.ProductDefinition>> callback) { }

}

// Namespace: UnityEngine.Purchasing
internal static class LoggerExtensions
{
	// Methods

	// RVA: 0x1699A24
	public static void LogIAPWarning(ILogger logger, string message) { }

	// RVA: 0x169ADCC
	public static void LogIAPError(ILogger logger, string message) { }

}

// Namespace: UnityEngine.Purchasing
internal static class ProductPurchaseUpdater
{
	// Methods

	// RVA: 0x169E2F0
	internal static void UpdateProductReceiptAndTransactionID(Product product, string receipt, string transactionId, string storeName) { }

}

// Namespace: UnityEngine.Purchasing
internal static class UnifiedReceiptFormatter
{
	// Methods

	// RVA: 0x169C5E4
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

	// RVA: 0x169E344
	internal void .ctor(string diagnosticName, string diagnosticException) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryDiagnostics
{
	// Fields
	private readonly ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper; // 0x10

	// Methods

	// RVA: 0x169E378
	public void .ctor(ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper) { }

	// RVA: 0x169E3AC
	public void SendDiagnostic(string diagnosticName, Exception e) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public TelemetryDiagnosticsInstanceWrapper <>4__this; // 0x10
	public TelemetryDiagnosticParams diagnosticParams; // 0x18

	// Methods

	// RVA: 0x169E91C
	public void .ctor() { }

	// RVA: 0x169EACC
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

	// RVA: 0x169E57C
	public void .ctor(ILogger logger, IUtil util) { }

	// RVA: 0x169E688
	public void SetDiagnosticsInstance(IDiagnostics diagnosticsInstance) { }

	// RVA: 0x169E6F8
	public void SendDiagnostic(string diagnosticName, string diagnosticException) { }

	// RVA: 0x169E7C4
	private void SendDiagnosticOnMainThread(TelemetryDiagnosticParams diagnosticParams) { }

	// RVA: 0x169E924
	private void SendDiagnosticAndCatchExceptions(TelemetryDiagnosticParams diagnosticParams) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class IapTelemetryException
{
	// Methods

	// RVA: 0x169EAF0
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

	// RVA: 0x169EB5C
	public TelemetryMetricTypes get_MetricType() { }

	// RVA: 0x169EB64
	public string get_MetricName() { }

	// RVA: 0x169EB6C
	public void .ctor(string metricName, TelemetryMetricTypes metricType) { }

	// RVA: 0x169EB98
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

	// RVA: 0x169EBD0
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

	// RVA: 0x169F080
	internal void .ctor(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper, TelemetryMetricTypes metricType, string metricName) { }

	// RVA: 0x169F130
	public void StartMetric() { }

	// RVA: 0x169F1C0
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

	// RVA: 0x169F340
	internal void .ctor(TelemetryMetricTypes metricType, string metricName, Double metricTimeSeconds) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public TelemetryMetricsInstanceWrapper <>4__this; // 0x10
	public TelemetryMetricParams metricParams; // 0x18

	// Methods

	// RVA: 0x169F75C
	public void .ctor() { }

	// RVA: 0x169FA60
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

	// RVA: 0x169F37C
	public void .ctor(ILogger logger, IUtil util) { }

	// RVA: 0x169F488
	public void SetMetricsInstance(IMetrics metricsInstance) { }

	// RVA: 0x169F514
	public void SendMetric(TelemetryMetricTypes metricType, string metricName, Double metricTimeSeconds) { }

	// RVA: 0x169F600
	private void SendMetricOnMainThread(TelemetryMetricParams metricParams) { }

	// RVA: 0x169F764
	private void SendMetricByTypeAndCatchExceptions(TelemetryMetricParams metricParams) { }

	// RVA: 0x169F8A4
	private void SendMetricByType(TelemetryMetricParams metricParams) { }

}

// Namespace: UnityEngine.Purchasing.Telemetry
internal class TelemetryMetricsService
{
	// Fields
	private readonly ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; // 0x10

	// Methods

	// RVA: 0x169FAA0
	public void .ctor(ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	// RVA: 0x169FAD4
	public void ExecuteTimedAction(Action timedAction, TelemetryMetricDefinition metricDefinition) { }

	// RVA: 0x169FCAC
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

	// RVA: 0x30D4CD4
	public void .ctor(System.Action<TTelemetryEventParams> sendTelemetryEvent) { }

	// RVA: 0x318DB98
	internal void QueueEvent(TTelemetryEventParams telemetryEvent) { }

	// RVA: 0x30D488C
	internal void SendQueuedEvents() { }

}

// Namespace: UnityEngine.Purchasing.Extension
public abstract class AbstractPurchasingModule
{
	// Fields
	protected IPurchasingBinder m_Binder; // 0x10

	// Methods

	// RVA: 0x169FEE8
	public void Configure(IPurchasingBinder binder) { }

	// RVA: 0x169FF18
	protected void RegisterStore(string name, IStore store) { }

	// RVA: 0x318DB98
	protected void BindExtension(T instance) { }

	// RVA: 0x318DB98
	protected void BindConfiguration(T instance) { }

	// RVA: -1
	public abstract void Configure() { }

	// RVA: 0x169FFD4
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

	// RVA: 0x169FFDC
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

	// RVA: 0x169FFE4
	public void .ctor(string id, ProductMetadata metadata, string receipt, string transactionId) { }

	// RVA: 0x16A0064
	public void .ctor(string id, ProductMetadata metadata, string receipt, string transactionId, ProductType type) { }

	// RVA: 0x16A00F0
	public void .ctor(string id, ProductMetadata metadata) { }

	// RVA: 0x16A0160
	public string get_storeSpecificId() { }

	// RVA: 0x16A0168
	private void set_storeSpecificId(string value) { }

	// RVA: 0x16A0170
	public ProductMetadata get_metadata() { }

	// RVA: 0x16A0178
	private void set_metadata(ProductMetadata value) { }

	// RVA: 0x16A0180
	public string get_receipt() { }

	// RVA: 0x16A0188
	private void set_receipt(string value) { }

	// RVA: 0x16A0190
	public string get_transactionId() { }

	// RVA: 0x16A0198
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

	// RVA: 0x169AB84
	public void .ctor(string productId, PurchaseFailureReason reason, string message) { }

	// RVA: 0x16A01A0
	public string get_productId() { }

	// RVA: 0x16A01A8
	private void set_productId(string value) { }

	// RVA: 0x16A01B0
	public PurchaseFailureReason get_reason() { }

	// RVA: 0x16A01B8
	private void set_reason(PurchaseFailureReason value) { }

	// RVA: 0x16A01C0
	public string get_message() { }

	// RVA: 0x16A01C8
	private void set_message(string value) { }

}


