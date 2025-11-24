// Namespace: 
internal class <Module> 
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute 
{
	// Methods

	// RVA: 0x15927D4
	void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute 
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x15927DC
	void .ctor(Byte ) { }

	// RVA: 0x1592868
	void .ctor(Byte[] ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute 
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x159289C
	void .ctor(Byte ) { }

}

// Namespace: Stores.Util
internal class JsonProductDescriptionsDeserializer 
{
	// Methods

	// RVA: 0x15928C8
	System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> DeserializeProductDescriptions(string json) { }

	// RVA: 0x1592E58
	ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

	// RVA: 0x15930F8
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class AmazonAppStoreStoreExtensions 
{
	// Fields
	private readonly AndroidJavaObject android; // 0x10

	// Methods

	// RVA: 0x1593100
	void .ctor(AndroidJavaObject a) { }

}

// Namespace: UnityEngine.Purchasing
public class FakeAmazonExtensions 
{
	// Methods

	// RVA: 0x1593134
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public interface IAmazonConfiguration 
{}

// Namespace: UnityEngine.Purchasing
public interface IAmazonExtensions 
{}

// Namespace: UnityEngine.Purchasing
internal class AndroidJavaStore 
{
	// Fields
	private readonly AndroidJavaObject m_Store; // 0x10

	// Methods

	// RVA: 0x159313C
	void .ctor(AndroidJavaObject store) { }

	// RVA: 0x1593170
	void RetrieveProducts(string json) { }

	// RVA: 0x1593244
	void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x1593358
	void FinishTransaction(string productJSON, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
internal static class ListExtension 
{
	// Methods

	// RVA: 0x2FE7084
	AndroidJavaObject ToJava(System.Collections.Generic.List<T> values) { }

	// RVA: 0x2FE7084
	AndroidJavaObject ToJavaArray(System.Collections.Generic.List<T> values) { }

}

// Namespace: UnityEngine.Purchasing
internal class UnityActivity 
{
	// Fields
	private static AndroidJavaClass s_UnityPlayerClass; // 0x0

	// Methods

	// RVA: 0x159346C
	AndroidJavaClass GetUnityPlayerClass() { }

	// RVA: 0x1593540
	AndroidJavaObject GetCurrentActivity() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.GoogleCachedQueryProductDetailsService.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.String> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x1594104
	void .cctor() { }

	// RVA: 0x1594170
	void .ctor() { }

	// RVA: 0x1594178
	string <GetCachedQueriedProductDetails>b__5_0(ProductDefinition product) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleCachedQueryProductDetailsService 
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.AndroidJavaObject> m_CachedQueriedProductDetails; // 0x10

	// Methods

	// RVA: 0x15935BC
	void Finalize() { }

	// RVA: 0x15938A0
	System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts() { }

	// RVA: 0x15938F4
	AndroidJavaObject GetCachedQueriedProductDetails(string productId) { }

	// RVA: 0x159396C
	System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<System.String> productIds) { }

	// RVA: 0x1593A14
	System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1593BC8
	bool Contains(string productId) { }

	// RVA: 0x1593C2C
	bool Contains(ProductDefinition products) { }

	// RVA: 0x1593C94
	void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts) { }

	// RVA: 0x1594078
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public string purchaseToken; // 0x10

	// Methods

	// RVA: 0x15946D4
	void .ctor() { }

	// RVA: 0x15946DC
	bool <FindPurchase>b__0(IGooglePurchase purchase) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished; // 0x10
	public IGooglePurchase purchase; // 0x18

	// Methods

	// RVA: 0x15946CC
	void .ctor() { }

	// RVA: 0x1594798
	void <FinishTransactionForPurchase>b__0(IGoogleBillingResult result) { }

	// RVA: 0x15947C4
	void <FinishTransactionForPurchase>b__1(IGoogleBillingResult result) { }

}

// Namespace: 
private struct <FindPurchase>d__4 
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>t__builder; // 0x18
	public string purchaseToken; // 0x30
	public GoogleFinishTransactionService <>4__this; // 0x38
	private UnityEngine.Purchasing.GoogleFinishTransactionService.<>c__DisplayClass4_0 <>8__1; // 0x40
	private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1; // 0x48

	// Methods

	// RVA: 0x15947F0
	void MoveNext() { }

	// RVA: 0x1594C14
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <FinishTransaction>d__3 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public GoogleFinishTransactionService <>4__this; // 0x38
	public string purchaseToken; // 0x40
	public ProductDefinition product; // 0x48
	public System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished; // 0x50
	private System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <>u__1; // 0x58

	// Methods

	// RVA: 0x1594C94
	void MoveNext() { }

	// RVA: 0x1595054
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleFinishTransactionService 
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGoogleQueryPurchasesService m_GoogleQueryPurchasesService; // 0x18

	// Methods

	// RVA: 0x1594194
	void .ctor(IGoogleBillingClient billingClient, IGoogleQueryPurchasesService googleQueryPurchasesService) { }

	// RVA: 0x15941E4
	void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

	// RVA: 0x15942F8
	System.Threading.Tasks.Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase> FindPurchase(string purchaseToken) { }

	// RVA: 0x1594424
	void FinishTransactionForPurchase(IGooglePurchase purchase, ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleLastKnownProductService 
{
	// Fields
	private string <LastKnownOldProductId>k__BackingField; // 0x10
	private string <LastKnownProductId>k__BackingField; // 0x18
	private System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> <LastKnownProrationMode>k__BackingField; // 0x20

	// Methods

	// RVA: 0x1595060
	string get_LastKnownOldProductId() { }

	// RVA: 0x1595068
	void set_LastKnownOldProductId(string value) { }

	// RVA: 0x1595070
	string get_LastKnownProductId() { }

	// RVA: 0x1595078
	void set_LastKnownProductId(string value) { }

	// RVA: 0x1595080
	System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode() { }

	// RVA: 0x1595088
	void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value) { }

	// RVA: 0x1595090
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0 
{
	// Fields
	public GooglePlayStoreService <>4__this; // 0x10
	public Action ActionToRetry; // 0x18

	// Methods

	// RVA: 0x1595950
	void .ctor() { }

	// RVA: 0x1596AFC
	void <RetryConnection>b__0() { }

}

// Namespace: 
private struct <FetchPurchases>d__33 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public GooglePlayStoreService <>4__this; // 0x38
	public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed; // 0x40
	private TaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x1596B20
	void MoveNext() { }

	// RVA: 0x1596DE0
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <TryFetchPurchases>d__34 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed; // 0x30
	public GooglePlayStoreService <>4__this; // 0x38
	private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1; // 0x40

	// Methods

	// RVA: 0x1596DEC
	void MoveNext() { }

	// RVA: 0x15971E0
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStoreService 
{
	// Fields
	private int m_CurrentConnectionAttempts; // 0x10
	private int m_MaxConnectionAttempts; // 0x14
	private readonly IGoogleBillingClient m_BillingClient; // 0x18
	private readonly IBillingClientStateListener m_BillingClientStateListener; // 0x20
	private readonly IQueryProductDetailsService m_QueryProductDetailsService; // 0x28
	private readonly System.Collections.Concurrent.ConcurrentQueue<UnityEngine.Purchasing.Models.ProductDescriptionQuery> m_ProductsToQuery; // 0x30
	private readonly System.Collections.Concurrent.ConcurrentQueue<System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>>> m_OnPurchaseSucceededQueue; // 0x38
	private readonly IGooglePurchaseService m_GooglePurchaseService; // 0x40
	private readonly IGoogleFinishTransactionService m_GoogleFinishTransactionService; // 0x48
	private readonly IGoogleQueryPurchasesService m_GoogleQueryPurchasesService; // 0x50
	private readonly IGoogleLastKnownProductService m_GoogleLastKnownProductService; // 0x58
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x60
	private readonly ILogger m_Logger; // 0x68
	private readonly IRetryPolicy m_RetryPolicy; // 0x70
	private readonly IUtil m_Util; // 0x78

	// Methods

	// RVA: 0x1595110
	void .ctor(IGoogleBillingClient billingClient, IQueryProductDetailsService queryProductDetailsService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionService finishTransactionService, IGoogleQueryPurchasesService queryPurchasesService, IBillingClientStateListener billingClientStateListener, IGoogleLastKnownProductService lastKnownProductService, ITelemetryDiagnostics telemetryDiagnostics, ILogger logger, IRetryPolicy retryPolicy, IUtil util) { }

	// RVA: 0x1595300
	void InitConnectionWithGooglePlay() { }

	// RVA: 0x1595544
	void StartConnection() { }

	// RVA: 0x1595610
	void ResumeConnection() { }

	// RVA: 0x15956DC
	void AttemptReconnection() { }

	// RVA: 0x15957F0
	bool AreConnectionAttemptsExhausted() { }

	// RVA: 0x1595800
	void RetryConnection(Action ActionToRetry) { }

	// RVA: 0x1595958
	void RetryConnectionAttempt(Action ActionToRetry) { }

	// RVA: 0x1595AF0
	void OnConnected() { }

	// RVA: 0x1595B2C
	void DequeueQueryProducts(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x1596094
	void DequeueFetchPurchases() { }

	// RVA: 0x1596290
	void OnDisconnected(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x15962BC
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x159643C
	void HandleRetrieveProductsNotConnected(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x15965C8
	void Purchase(ProductDefinition product) { }

	// RVA: 0x15965E0
	void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x1596864
	void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

	// RVA: 0x15961BC
	void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed) { }

	// RVA: 0x1596930
	Task TryFetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed) { }

	// RVA: 0x1596A38
	IGooglePurchase GetPurchase(string purchaseToken, string skuType) { }

	// RVA: 0x1596AF8
	void <AttemptReconnection>b__19_0(Action retryAction) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public GooglePurchaseService <>4__this; // 0x10
	public ProductDefinition product; // 0x18
	public Product oldProduct; // 0x20
	public System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode; // 0x28

	// Methods

	// RVA: 0x159742C
	void .ctor() { }

	// RVA: 0x1597EA0
	void <Purchase>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, IGoogleBillingResult _) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePurchaseService 
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x18
	private readonly IQueryProductDetailsService m_QueryProductDetailsService; // 0x20

	// Methods

	// RVA: 0x159724C
	void .ctor(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQueryProductDetailsService queryProductDetailsService) { }

	// RVA: 0x15972B0
	void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x1597434
	void OnQueryProductDetailsResponse(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, ProductDefinition productToBuy, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x15974E8
	bool ValidateQueryProductDetailsResponseParams(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, ProductDefinition productToBuy, Product oldProduct) { }

	// RVA: 0x1597714
	bool ValidateSkus(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus) { }

	// RVA: 0x1597A20
	void VerifyAndWarnIfMoreThanOneSku(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus) { }

	// RVA: 0x1597778
	void PurchaseFailedSkuNotFound(ProductDefinition productToBuy) { }

	// RVA: 0x1597880
	bool ValidateOldProduct(Product oldProduct) { }

	// RVA: 0x15978EC
	void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, Product oldProduct) { }

	// RVA: 0x15975FC
	void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x1597BC0
	void HandleBillingFlowResult(IGoogleBillingResult billingResult, AndroidJavaObject sku) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.GoogleQueryPurchasesService.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>,System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x159852C
	void .cctor() { }

	// RVA: 0x1598598
	void .ctor() { }

	// RVA: 0x15985A0
	System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <QueryPurchases>b__3_0(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> result) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public GoogleQueryPurchasesService <>4__this; // 0x10
	public System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> taskCompletion; // 0x18

	// Methods

	// RVA: 0x1598274
	void .ctor() { }

	// RVA: 0x15985A8
	void <QueryPurchasesWithSkuType>b__0(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public string purchaseToken; // 0x10
	public GoogleQueryPurchasesService <>4__this; // 0x18
	public System.Threading.Tasks.TaskCompletionSource<UnityEngine.Purchasing.Interfaces.IGooglePurchase> taskCompletion; // 0x20
	public System.Func<UnityEngine.AndroidJavaObject,System.Boolean> <>9__1; // 0x28

	// Methods

	// RVA: 0x1598478
	void .ctor() { }

	// RVA: 0x15987E0
	void <GetPurchaseByToken>b__0(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

	// RVA: 0x1598A14
	bool <GetPurchaseByToken>b__1(AndroidJavaObject purchase) { }

}

// Namespace: 
private struct <QueryPurchases>d__3 
{
	// Fields
	public int <>1__state; // 0x10
	public System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>t__builder; // 0x18
	public GoogleQueryPurchasesService <>4__this; // 0x30
	private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>[]> <>u__1; // 0x38

	// Methods

	// RVA: 0x1598B54
	void MoveNext() { }

	// RVA: 0x1599030
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleQueryPurchasesService 
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGooglePurchaseBuilder m_PurchaseBuilder; // 0x18

	// Methods

	// RVA: 0x1597F54
	void .ctor(IGoogleBillingClient billingClient, IGooglePurchaseBuilder purchaseBuilder) { }

	// RVA: 0x1597FA4
	System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases() { }

	// RVA: 0x15980BC
	System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchasesWithSkuType(string skuType) { }

	// RVA: 0x159827C
	IGooglePurchase GetPurchaseByToken(string purchaseToken, string skuType) { }

	// RVA: 0x1598480
	bool IsResultOk(IGoogleBillingResult result) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGoogleCachedQueryProductDetailsService 
{
	// Methods

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts() { }

	// RVA: 0x2FE36BC
	System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x2FE3174
	bool Contains(ProductDefinition products) { }

	// RVA: 0x2FE4574
	void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts) { }

}

// Namespace: UnityEngine.Purchasing
internal class BillingClientStateListener 
{
	// Fields
	private Action m_OnConnected; // 0x20
	private System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> m_Disconnect; // 0x28

	// Methods

	// RVA: 0x15990B0
	void .ctor() { }

	// RVA: 0x159912C
	void RegisterOnConnected(Action onConnected) { }

	// RVA: 0x1599134
	void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected) { }

	// RVA: 0x159913C
	void onBillingSetupFinished(AndroidJavaObject billingResult) { }

	// RVA: 0x15992E4
	void onBillingServiceDisconnected() { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleAcknowledgePurchaseListener 
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse; // 0x20

	// Methods

	// RVA: 0x1599324
	void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledgePurchaseResponseAction) { }

	// RVA: 0x15993B4
	void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleConsumeResponseListener 
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse; // 0x20

	// Methods

	// RVA: 0x1599448
	void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsumeResponseAction) { }

	// RVA: 0x15994D8
	void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePurchasesResponseListener 
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> m_OnQueryPurchasesResponse; // 0x20

	// Methods

	// RVA: 0x159956C
	void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse) { }

	// RVA: 0x15995FC
	void onQueryPurchasesResponse(AndroidJavaObject billingResult, AndroidJavaObject purchases) { }

}

// Namespace: 
private struct <HandleUserCancelledPurchaseFailure>d__14 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public GooglePurchaseUpdatedListener <>4__this; // 0x38
	public IGoogleBillingResult billingResult; // 0x40
	private System.Runtime.CompilerServices.TaskAwaiter<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>u__1; // 0x48

	// Methods

	// RVA: 0x159C1F4
	void MoveNext() { }

	// RVA: 0x159C48C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePurchaseUpdatedListener 
{
	// Fields
	private readonly IGoogleLastKnownProductService m_LastKnownProductService; // 0x20
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x28
	private readonly IGooglePurchaseBuilder m_PurchaseBuilder; // 0x30
	private readonly IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService; // 0x38
	private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider; // 0x40
	private IGoogleQueryPurchasesService m_GoogleQueryPurchasesService; // 0x48

	// Methods

	// RVA: 0x1599868
	void .ctor(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePurchaseBuilder purchaseBuilder, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, IGoogleQueryPurchasesService googleQueryPurchasesService) { }

	// RVA: 0x1599974
	void SetGoogleQueryPurchaseService(IGoogleQueryPurchasesService googleFetchPurchases) { }

	// RVA: 0x159997C
	void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList) { }

	// RVA: 0x1599C6C
	void OnPurchasesUpdated(IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x1599F04
	void HandleResultOkCases(IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x159A22C
	void HandleErrorCases(IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x159A304
	void HandleErrorGoogleBillingResult(IGoogleBillingResult billingResult) { }

	// RVA: 0x159AD70
	void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult) { }

	// RVA: 0x159AE44
	void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases) { }

	// RVA: 0x1599FDC
	void ApplyOnPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase> action) { }

	// RVA: 0x159AA08
	void ApplyOnPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, IGoogleBillingResult billingResult, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.String> action) { }

	// RVA: 0x159AFAC
	void OnPurchaseOk(IGooglePurchase googlePurchase) { }

	// RVA: 0x159B660
	void HandlePurchasedProduct(IGooglePurchase googlePurchase) { }

	// RVA: 0x159B918
	bool IsDeferredSubscriptionChange(IGooglePurchase googlePurchase) { }

	// RVA: 0x159BA7C
	bool IsLastProrationModeDeferred() { }

	// RVA: 0x159B468
	void OnPurchaseCancelled(IGoogleBillingResult billingResult) { }

	// RVA: 0x159BC20
	void OnPurchaseCancelled(IGooglePurchase googlePurchase) { }

	// RVA: 0x159BDA0
	void OnPurchaseAlreadyOwned(IGooglePurchase googlePurchase) { }

	// RVA: 0x159BF20
	void OnPurchaseFailed(IGooglePurchase googlePurchase, string debugMessage) { }

	// RVA: 0x159C0B8
	bool <HandleUserCancelledPurchaseFailure>b__15_0(IGooglePurchase purchase) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public AndroidJavaObject productDetails; // 0x10
	public ProductDetailsResponseListener <>4__this; // 0x18
	public AndroidJavaObject billingResult; // 0x20

	// Methods

	// RVA: 0x159C6BC
	void .ctor() { }

	// RVA: 0x159C6C4
	void <onProductDetailsResponse>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductDetailsResponseListener 
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> m_OnProductDetailsResponse; // 0x20
	private readonly IUtil m_Util; // 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

	// Methods

	// RVA: 0x159C498
	void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x159C558
	void onProductDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject productDetails) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public MetricizedGooglePlayStoreService <>4__this; // 0x10
	public GoogleBillingResponseCode googleBillingResponseCode; // 0x18

	// Methods

	// RVA: 0x159CBFC
	void .ctor() { }

	// RVA: 0x159D0B0
	void <DequeueQueryProducts>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public MetricizedGooglePlayStoreService <>4__this; // 0x10
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18
	public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived; // 0x20
	public System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed; // 0x28

	// Methods

	// RVA: 0x159CEEC
	void .ctor() { }

	// RVA: 0x159D0D4
	void <RetrieveProducts>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public MetricizedGooglePlayStoreService <>4__this; // 0x10
	public ProductDefinition product; // 0x18
	public Product oldProduct; // 0x20
	public System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode; // 0x28

	// Methods

	// RVA: 0x159D09C
	void .ctor() { }

	// RVA: 0x159D0FC
	void <Purchase>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedGooglePlayStoreService 
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x80
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x88

	// Methods

	// RVA: 0x159CA20
	void .ctor(IGoogleBillingClient billingClient, IQueryProductDetailsService queryProductDetailsService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionService finishTransactionService, IGoogleQueryPurchasesService queryPurchasesService, IBillingClientStateListener billingClientStateListener, IGoogleLastKnownProductService lastKnownProductService, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService, ILogger logger, IRetryPolicy retryPolicy, IUtil util) { }

	// RVA: 0x159CA84
	void DequeueQueryProducts(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x159CC04
	void DequeueFetchPurchases() { }

	// RVA: 0x159CD38
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x159CEF4
	void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x159D0A4
	void <>n__0(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x159D0A8
	void <>n__1(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x159D0AC
	void <>n__2(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

}

// Namespace: UnityEngine.Purchasing
internal enum GoogleBillingConnectionState 
{
	// Fields
	public int value__; // 0x10
	public const GoogleBillingConnectionState Disconnected = 0;
	public const GoogleBillingConnectionState Connecting = 1;
	public const GoogleBillingConnectionState Connected = 2;
	public const GoogleBillingConnectionState Closed = 3;
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.ProductDetailsQueryResponse.<>c <>9; // 0x0
	public static System.Func<UnityEngine.AndroidJavaObject,UnityEngine.AndroidJavaObject> <>9__2_0; // 0x8
	public static System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>,System.Boolean> <>9__3_0; // 0x10
	public static System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> <>9__3_1; // 0x18
	public static System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>,UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__4_0; // 0x20
	public static System.Func<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>,UnityEngine.Purchasing.Models.IGoogleBillingResult> <>9__5_0; // 0x28
	public static System.Func<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Boolean> <>9__5_1; // 0x30

	// Methods

	// RVA: 0x159DF44
	void .cctor() { }

	// RVA: 0x159DFB0
	void .ctor() { }

	// RVA: 0x159DFB8
	AndroidJavaObject <AddResponse>b__2_0(AndroidJavaObject product) { }

	// RVA: 0x159DFD4
	bool <ProductDetails>b__3_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x159E080
	System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> <ProductDetails>b__3_1(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x159E088
	IGoogleBillingResult <IsRecoverable>b__4_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x159E090
	IGoogleBillingResult <GetGoogleBillingResult>b__5_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x159E098
	bool <GetGoogleBillingResult>b__5_1(IGoogleBillingResult response) { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductDetailsQueryResponse 
{
	// Fields
	private readonly System.Collections.Concurrent.ConcurrentBag<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>> m_Responses; // 0x10

	// Methods

	// RVA: 0x159D124
	void Finalize() { }

	// RVA: 0x159D650
	void AddResponse(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

	// RVA: 0x159D7F8
	System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails() { }

	// RVA: 0x159D9FC
	bool IsRecoverable() { }

	// RVA: 0x159DB78
	IGoogleBillingResult GetGoogleBillingResult() { }

	// RVA: 0x159DD8C
	bool IsRecoverable(IGoogleBillingResult billingResult) { }

	// RVA: 0x159DEB8
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductDetailsResponseConsolidator 
{
	// Fields
	private int m_NumberReceivedCallbacks; // 0x10
	private readonly System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> m_OnProductDetailsResponseConsolidated; // 0x18
	private readonly IProductDetailsQueryResponse m_Responses; // 0x20
	private readonly IUtil m_Util; // 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

	// Methods

	// RVA: 0x159E144
	void .ctor(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> onProductDetailsResponseConsolidated) { }

	// RVA: 0x159E26C
	void Consolidate(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.QueryProductDetailsService.<>c <>9; // 0x0
	public static System.Func<System.Boolean,System.Boolean> <>9__14_0; // 0x8
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.Boolean> <>9__16_0; // 0x10
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.String> <>9__16_1; // 0x18
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.Boolean> <>9__17_0; // 0x20
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.String> <>9__17_1; // 0x28

	// Methods

	// RVA: 0x159F64C
	void .cctor() { }

	// RVA: 0x159F6B8
	void .ctor() { }

	// RVA: 0x159F6C0
	bool <AreAllProductDetailsCached>b__14_0(bool isCached) { }

	// RVA: 0x159F6C8
	bool <QueryInAppsAsync>b__16_0(ProductDefinition product) { }

	// RVA: 0x159F6EC
	string <QueryInAppsAsync>b__16_1(ProductDefinition product) { }

	// RVA: 0x159F708
	bool <QuerySubsAsync>b__17_0(ProductDefinition product) { }

	// RVA: 0x159F72C
	string <QuerySubsAsync>b__17_1(ProductDefinition product) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0 
{
	// Fields
	public QueryProductDetailsService <>4__this; // 0x10
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18
	public System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse; // 0x20
	public int retryCount; // 0x28

	// Methods

	// RVA: 0x159E874
	void .ctor() { }

	// RVA: 0x159F748
	void <QueryAsyncProduct>b__0(Action retryAction) { }

	// RVA: 0x159F770
	void <QueryAsyncProduct>g__OnActionRetry|1() { }

}

// Namespace: 
private sealed class <>c__DisplayClass12_0 
{
	// Fields
	public QueryProductDetailsService <>4__this; // 0x10
	public System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18
	public Action retryQuery; // 0x20
	public System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse; // 0x28

	// Methods

	// RVA: 0x159EB08
	void .ctor() { }

	// RVA: 0x159F838
	void <TryQueryAsyncProductWithRetries>b__0(IProductDetailsQueryResponse productDetailsQueryResponse) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0 
{
	// Fields
	public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse; // 0x10
	public QueryProductDetailsService <>4__this; // 0x18

	// Methods

	// RVA: 0x159E86C
	void .ctor() { }

	// RVA: 0x159FB28
	void <QueryAsyncProduct>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetails, IGoogleBillingResult responseCode) { }

}

// Namespace: UnityEngine.Purchasing
internal class QueryProductDetailsService 
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService; // 0x18
	private readonly IProductDetailsConverter m_ProductDetailsConverter; // 0x20
	private readonly IRetryPolicy m_RetryPolicy; // 0x28
	private readonly IGoogleProductCallback m_GoogleProductCallback; // 0x30
	private readonly IUtil m_Util; // 0x38
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x40

	// Methods

	// RVA: 0x159E430
	void .ctor(IGoogleBillingClient billingClient, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IProductDetailsConverter productDetailsConverter, IRetryPolicy retryPolicy, IGoogleProductCallback googleProductCallback, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x159E4F4
	void QueryAsyncProduct(ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x159E784
	void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x159E5D0
	void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x159E87C
	void QueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, Action retryQuery) { }

	// RVA: 0x159E9A4
	void TryQueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, Action retryQuery) { }

	// RVA: 0x159EF68
	bool ShouldRetryQuery(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> requestedProducts, IProductDetailsQueryResponse queryResponse) { }

	// RVA: 0x159F054
	bool AreAllProductDetailsCached(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x159F240
	System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x159EB10
	void QueryInAppsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, IProductDetailsResponseConsolidator consolidator) { }

	// RVA: 0x159ED3C
	void QuerySubsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, IProductDetailsResponseConsolidator consolidator) { }

	// RVA: 0x159F3D8
	void QueryProductDetails(System.Collections.Generic.List<System.String> productList, string type, IProductDetailsResponseConsolidator consolidator) { }

}

// Namespace: UnityEngine.Purchasing
public class FakeGooglePlayStoreConfiguration 
{
	// Methods

	// RVA: 0x159FC18
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class FakeGooglePlayStoreExtensions 
{
	// Methods

	// RVA: 0x159FC20
	bool IsPurchasedProductDeferred(Product product) { }

	// RVA: 0x159FC28
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public static class GetGoogleProductMetadataExtension 
{
	// Methods

	// RVA: 0x159FC30
	GoogleProductMetadata GetGoogleProductMetadata(ProductMetadata productMetadata) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayConfiguration 
{
	// Fields
	private Action m_InitializationConnectionLister; // 0x10
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x18
	private System.Action<UnityEngine.Purchasing.Product> m_DeferredPurchaseAction; // 0x20
	private System.Action<UnityEngine.Purchasing.Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction; // 0x28
	private System.Action<System.Int32> m_QueryProductDetailsFailedListener; // 0x30
	private bool m_FetchPurchasesAtInitialize; // 0x38
	private bool m_FetchPurchasesExcludeDeferred; // 0x39

	// Methods

	// RVA: 0x159FCB4
	void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x159FCF0
	void NotifyInitializationConnectionFailed() { }

	// RVA: 0x159FD0C
	void NotifyQueryProductDetailsFailed(int retryCount) { }

	// RVA: 0x159FD44
	void NotifyDeferredProrationUpgradeDowngradeSubscription(IStoreCallback storeCallback, string productId) { }

	// RVA: 0x159FF68
	bool IsFetchPurchasesAtInitializeSkipped() { }

	// RVA: 0x159FF78
	bool DoesRetrievePurchasesExcludeDeferred() { }

	// RVA: 0x159FF80
	void NotifyDeferredPurchase(IStoreCallback storeCallback, IGooglePurchase purchase, string receipt, string transactionId) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayProductCallback 
{
	// Fields
	private IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x10

	// Methods

	// RVA: 0x15A00D0
	void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: 0x15A00D8
	void NotifyQueryProductDetailsFailed(int retryCount) { }

	// RVA: 0x15A019C
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public enum GooglePlayProrationMode 
{
	// Fields
	public int value__; // 0x10
	public const GooglePlayProrationMode UnknownSubscriptionUpgradeDowngradePolicy = 0;
	public const GooglePlayProrationMode ImmediateWithTimeProration = 1;
	public const GooglePlayProrationMode ImmediateAndChargeProratedPrice = 2;
	public const GooglePlayProrationMode ImmediateWithoutProration = 3;
	public const GooglePlayProrationMode Deferred = 4;
	public const GooglePlayProrationMode ImmediateAndChargeFullPrice = 5;
}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public GooglePlayPurchaseCallback <>4__this; // 0x10
	public IGooglePurchase purchase; // 0x18
	public string receipt; // 0x20
	public string purchaseToken; // 0x28

	// Methods

	// RVA: 0x15A05C0
	void .ctor() { }

	// RVA: 0x15A0720
	void <NotifyDeferredPurchase>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0 
{
	// Fields
	public GooglePlayPurchaseCallback <>4__this; // 0x10
	public string sku; // 0x18

	// Methods

	// RVA: 0x15A0718
	void .ctor() { }

	// RVA: 0x15A0810
	void <NotifyDeferredProrationUpgradeDowngradeSubscription>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayPurchaseCallback 
{
	// Fields
	private IStoreCallback m_StoreCallback; // 0x10
	private IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x18
	private readonly IUtil m_Util; // 0x20

	// Methods

	// RVA: 0x15A01A4
	void .ctor(IUtil util) { }

	// RVA: 0x15A01D8
	void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x15A01E0
	void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: 0x15A01E8
	void OnPurchaseSuccessful(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: 0x15A037C
	void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription) { }

	// RVA: 0x15A0440
	void NotifyDeferredPurchase(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: 0x15A05C8
	void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStore 
{
	// Fields
	private readonly IGooglePlayStoreRetrieveProductsService m_RetrieveProductsService; // 0x10
	private readonly IGooglePlayStorePurchaseService m_StorePurchaseService; // 0x18
	private readonly IGoogleFetchPurchases m_FetchPurchases; // 0x20
	private readonly IGooglePlayStoreFinishTransactionService m_FinishTransactionService; // 0x28
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x30
	private readonly IGooglePlayStoreExtensionsInternal m_GooglePlayStoreExtensions; // 0x38
	private readonly IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x40
	private readonly IUtil m_Util; // 0x48

	// Methods

	// RVA: 0x15A08E8
	void .ctor(IGooglePlayStoreRetrieveProductsService retrieveProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGoogleFetchPurchases fetchPurchases, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePlayConfigurationInternal googlePlayConfigurationInternal, IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, IUtil util) { }

	// RVA: 0x15A09C8
	void Initialize(IStoreCallback callback) { }

	// RVA: 0x15A0D54
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x15A0F90
	bool HasInitiallyRetrievedProducts() { }

	// RVA: 0x15A0E1C
	bool ShouldFetchPurchasesNext() { }

	// RVA: 0x15A1048
	void Purchase(ProductDefinition product, string dummy) { }

	// RVA: 0x15A10FC
	void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x15A11BC
	void OnPause(bool isPaused) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStoreExtensions 
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
	private readonly IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider; // 0x18
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x20
	private readonly ILogger m_Logger; // 0x28
	private IStoreCallback m_StoreCallback; // 0x30

	// Methods

	// RVA: 0x15A1320
	void .ctor(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x15A13A0
	void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x15A13A8
	bool IsPurchasedProductDeferred(Product product) { }

	// RVA: 0x15A1524
	bool TryIsPurchasedProductDeferred(Product product) { }

	// RVA: 0x15A1544
	GooglePurchaseState GetPurchaseState(Product product) { }

	// RVA: 0x15A176C
	IGooglePurchase GooglePurchaseFromProduct(Product product) { }

}

// Namespace: UnityEngine.Purchasing
public interface IGooglePlayConfiguration 
{}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayConfigurationInternal 
{
	// Methods

	// RVA: 0x2FE41A8
	void NotifyInitializationConnectionFailed() { }

	// RVA: 0x2FE4A14
	void NotifyDeferredPurchase(IStoreCallback storeCallback, IGooglePurchase purchase, string receipt, string transactionId) { }

	// RVA: 0x2FE47D4
	void NotifyDeferredProrationUpgradeDowngradeSubscription(IStoreCallback storeCallback, string productId) { }

	// RVA: 0x2FE3054
	bool IsFetchPurchasesAtInitializeSkipped() { }

	// RVA: 0x2FE3054
	bool DoesRetrievePurchasesExcludeDeferred() { }

	// RVA: 0x2FE42A4
	void NotifyQueryProductDetailsFailed(int retryCount) { }

}

// Namespace: UnityEngine.Purchasing
public interface IGooglePlayStoreExtensions 
{
	// Methods

	// RVA: 0x2FE3174
	bool IsPurchasedProductDeferred(Product product) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreExtensionsInternal 
{
	// Methods

	// RVA: 0x2FE4574
	void SetStoreCallback(IStoreCallback storeCallback) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGoogleFetchPurchases 
{
	// Methods

	// RVA: 0x2FE4574
	void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x2FE41A8
	void FetchPurchases() { }

	// RVA: 0x2FE4574
	void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreFinishTransactionService 
{
	// Methods

	// RVA: 0x2FE4574
	void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x2FE47D4
	void FinishTransaction(ProductDefinition product, string purchaseToken) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStorePurchaseService 
{
	// Methods

	// RVA: 0x2FE4574
	void Purchase(ProductDefinition product) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreRetrieveProductsService 
{
	// Methods

	// RVA: 0x2FE4574
	void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: -1
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases) { }

	// RVA: 0x2FE41A8
	void ResumeConnection() { }

	// RVA: 0x2FE3054
	bool HasInitiallyRetrievedProducts() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedGooglePlayStoreExtensions 
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x38

	// Methods

	// RVA: 0x15A185C
	void .ctor(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

}

// Namespace: UnityEngine.Purchasing
public class GoogleProductMetadata 
{
	// Fields
	private string <originalJson>k__BackingField; // 0x40
	private string <subscriptionPeriod>k__BackingField; // 0x48
	private string <freeTrialPeriod>k__BackingField; // 0x50
	private string <introductoryPrice>k__BackingField; // 0x58
	private string <introductoryPricePeriod>k__BackingField; // 0x60
	private int <introductoryPriceCycles>k__BackingField; // 0x68

	// Methods

	// RVA: 0x15A18F0
	string get_originalJson() { }

	// RVA: 0x15A18F8
	void set_originalJson(string value) { }

	// RVA: 0x15A1900
	void set_subscriptionPeriod(string value) { }

	// RVA: 0x15A1908
	void set_freeTrialPeriod(string value) { }

	// RVA: 0x15A1910
	void set_introductoryPrice(string value) { }

	// RVA: 0x15A1918
	void set_introductoryPricePeriod(string value) { }

	// RVA: 0x15A1920
	void set_introductoryPriceCycles(int value) { }

	// RVA: 0x15A1928
	void .ctor(string priceString, string title, string description, string currencyCode, Decimal localizedPrice) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.GoogleFetchPurchases.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> <>9__11_0; // 0x8
	public static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> <>9__12_0; // 0x10

	// Methods

	// RVA: 0x15A2A48
	void .cctor() { }

	// RVA: 0x15A2AB4
	void .ctor() { }

	// RVA: 0x15A2ABC
	bool <PurchaseIsPurchased>b__11_0(IGooglePurchase purchase) { }

	// RVA: 0x15A2B70
	bool <PurchaseIsPending>b__12_0(IGooglePurchase purchase) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0 
{
	// Fields
	public GoogleFetchPurchases <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases; // 0x18

	// Methods

	// RVA: 0x15A22D0
	void .ctor() { }

	// RVA: 0x15A2C24
	void <OnFetchedPurchase>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed; // 0x10
	public GoogleFetchPurchases <>4__this; // 0x18

	// Methods

	// RVA: 0x15A1BD0
	void .ctor() { }

	// RVA: 0x15A2C48
	void <FetchPurchases>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public GoogleFetchPurchases <>4__this; // 0x10
	public IGooglePurchase purchase; // 0x18

	// Methods

	// RVA: 0x15A1EC8
	void .ctor() { }

	// RVA: 0x15A2C8C
	Product <BuildProductsFromPurchase>b__0(string sku) { }

	// RVA: 0x15A2CB8
	Product <BuildProductsFromPurchase>b__1(Product product) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleFetchPurchases 
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
	private IStoreCallback m_StoreCallback; // 0x18
	private IUtil m_Util; // 0x20

	// Methods

	// RVA: 0x15A1930
	void .ctor(IGooglePlayStoreService googlePlayStoreService, IUtil util) { }

	// RVA: 0x15A1980
	void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x15A1988
	void FetchPurchases() { }

	// RVA: 0x15A1A80
	void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed) { }

	// RVA: 0x15A1BD8
	System.Collections.Generic.List<UnityEngine.Purchasing.Product> FillProductsWithPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x15A1CA4
	System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> BuildProductsFromPurchase(IGooglePurchase purchase) { }

	// RVA: 0x15A1ED0
	Product CompleteProductInfoWithPurchase(Product product, IGooglePurchase purchase) { }

	// RVA: 0x15A2054
	void OnFetchedPurchase(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x15A22D8
	System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> PurchaseIsPurchased() { }

	// RVA: 0x15A23E0
	System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> PurchaseIsPending() { }

	// RVA: 0x15A24E8
	void UpdateDeferredProductsByPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases) { }

	// RVA: 0x15A26AC
	void UpdateDeferredProductsByPurchase(IGooglePurchase deferredPurchase) { }

	// RVA: 0x15A28F0
	void UpdateDeferredProduct(IGooglePurchase deferredPurchase, string sku) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public GooglePlayStoreFinishTransactionService <>4__this; // 0x10
	public ProductDefinition product; // 0x18

	// Methods

	// RVA: 0x15A2EE4
	void .ctor() { }

	// RVA: 0x15A37D8
	void <FinishTransaction>b__0(IGoogleBillingResult billingResult, IGooglePurchase googlePurchase) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStoreFinishTransactionService 
{
	// Fields
	private readonly System.Collections.Generic.HashSet<System.String> m_ProcessedPurchaseToken; // 0x10
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x18
	private IStoreCallback m_StoreCallback; // 0x20
	private int m_RetryCount; // 0x28

	// Methods

	// RVA: 0x15A2CC8
	void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x15A2D70
	void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x15A2D78
	void FinishTransaction(ProductDefinition product, string purchaseToken) { }

	// RVA: 0x15A2EEC
	void HandleFinishTransaction(ProductDefinition product, IGoogleBillingResult billingResult, IGooglePurchase purchase) { }

	// RVA: 0x15A33D0
	void CallPurchaseSucceededUpdateReceipt(IGooglePurchase googlePurchase) { }

	// RVA: 0x15A362C
	bool IsResponseCodeInRecoverableState(IGoogleBillingResult billingResult) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStorePurchaseService 
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10

	// Methods

	// RVA: 0x15A3804
	void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x15A3838
	void Purchase(ProductDefinition product) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0 
{
	// Fields
	public GooglePlayStoreRetrieveProductsService <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts; // 0x18

	// Methods

	// RVA: 0x15A3DE4
	void .ctor() { }

	// RVA: 0x15A4918
	void <OnProductsRetrievedWithPurchaseFetch>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchaseProducts) { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0 
{
	// Fields
	public Product purchaseProduct; // 0x10

	// Methods

	// RVA: 0x15A4854
	void .ctor() { }

	// RVA: 0x15A4A00
	bool <MakePurchasesIntoProducts>b__0(ProductDescription product) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStoreRetrieveProductsService 
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
	private readonly IGoogleFetchPurchases m_GoogleFetchPurchases; // 0x18
	private IStoreCallback m_StoreCallback; // 0x20
	private readonly IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x28
	private readonly IGooglePlayStoreExtensions m_GooglePlayStoreExtensions; // 0x30
	private bool m_HasInitiallyRetrievedProducts; // 0x38
	private bool m_RetrieveProductsFailed; // 0x39

	// Methods

	// RVA: 0x15A38F0
	void .ctor(IGooglePlayStoreService googlePlayStoreService, IGoogleFetchPurchases googleFetchPurchases, IGooglePlayConfigurationInternal googlePlayConfigurationInternal, IGooglePlayStoreExtensions googlePlayStoreExtensions) { }

	// RVA: 0x15A3978
	void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x15A3980
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases) { }

	// RVA: 0x15A3B6C
	void OnProductsRetrievedWithPurchaseFetch(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, IGoogleBillingResult billingResult) { }

	// RVA: 0x15A3FCC
	void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, IGoogleBillingResult billingResult) { }

	// RVA: 0x15A3DEC
	void OnRetrieveProductsFailed(GoogleRetrieveProductsFailureReason reason, GoogleBillingResponseCode responseCode) { }

	// RVA: 0x15A41B0
	void ResumeConnection() { }

	// RVA: 0x15A4268
	System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> MakePurchasesIntoProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> purchaseProducts) { }

	// RVA: 0x15A485C
	bool IsPurchasedProductDeferred(Product product) { }

	// RVA: 0x15A4910
	bool HasInitiallyRetrievedProducts() { }

}

// Namespace: UnityEngine.Purchasing
public static class StoreCallbackExtensionMethods 
{
	// Methods

	// RVA: 0x159FD94
	Product FindProductById(IStoreCallback storeCallback, string sku) { }

}

// Namespace: UnityEngine.Purchasing
public interface IAndroidStoreSelection 
{}

// Namespace: UnityEngine.Purchasing
internal interface IUnityCallback 
{}

// Namespace: UnityEngine.Purchasing
internal class JavaBridge 
{
	// Fields
	private readonly IUnityCallback forwardTo; // 0x20

	// Methods

	// RVA: 0x15A4A34
	void .ctor(IUnityCallback forwardTo) { }

}

// Namespace: UnityEngine.Purchasing
internal static class SerializationExtensions 
{
	// Methods

	// RVA: 0x1592D74
	string TryGetString(System.Collections.Generic.Dictionary<System.String,System.Object> dic, string key) { }

}

// Namespace: UnityEngine.Purchasing
internal class JSONSerializer 
{
	// Methods

	// RVA: 0x15A4AC4
	string SerializeProductDef(ProductDefinition product) { }

	// RVA: 0x15A5380
	string SerializeProductDefs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x15A56A8
	string SerializeProductDescs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x15A5BD8
	PurchaseFailureDescription DeserializeFailureReason(string json) { }

	// RVA: 0x15A5F70
	string BuildPurchaseFailureDescriptionMessage(System.Collections.Generic.Dictionary<System.String,System.Object> dic) { }

	// RVA: 0x15A4ADC
	System.Collections.Generic.Dictionary<System.String,System.Object> EncodeProductDef(ProductDefinition product) { }

	// RVA: 0x15A59D0
	System.Collections.Generic.Dictionary<System.String,System.Object> EncodeProductDesc(ProductDescription product) { }

	// RVA: 0x15A603C
	System.Collections.Generic.Dictionary<System.String,System.Object> EncodeProductMeta(ProductMetadata product) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0 
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public PurchaseFailureDescription desc; // 0x18

	// Methods

	// RVA: 0x15A69B4
	void .ctor() { }

	// RVA: 0x15A69BC
	void <OnPurchaseFailed>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public InitializationFailureReason reason; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x15A6424
	void .ctor() { }

	// RVA: 0x15A6A88
	void <OnSetupFailed>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products; // 0x18

	// Methods

	// RVA: 0x15A657C
	void .ctor() { }

	// RVA: 0x15A6B50
	void <OnProductsRetrieved>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public string id; // 0x18
	public string receipt; // 0x20
	public string transactionID; // 0x28

	// Methods

	// RVA: 0x15A6704
	void .ctor() { }

	// RVA: 0x15A6C1C
	void <OnPurchaseSucceeded>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0 
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts; // 0x18

	// Methods

	// RVA: 0x15A685C
	void .ctor() { }

	// RVA: 0x15A6CE8
	void <OnAllPurchasesRetrieved>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class ScriptingStoreCallback 
{
	// Fields
	private readonly IStoreCallback m_ForwardTo; // 0x10
	private readonly IUtil m_Util; // 0x18

	// Methods

	// RVA: 0x15A0D04
	void .ctor(IStoreCallback forwardTo, IUtil util) { }

	// RVA: 0x15A6218
	ProductCollection get_products() { }

	// RVA: 0x15A62CC
	void OnSetupFailed(InitializationFailureReason reason, string message) { }

	// RVA: 0x15A642C
	void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x15A6584
	void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	// RVA: 0x15A670C
	void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts) { }

	// RVA: 0x15A6864
	void OnPurchaseFailed(PurchaseFailureDescription desc) { }

}

// Namespace: UnityEngine.Purchasing
internal class ScriptingUnityCallback 
{
	// Fields
	private readonly IUnityCallback forwardTo; // 0x10
	private readonly IUtil util; // 0x18

	// Methods

	// RVA: 0x15A6DB4
	void .ctor(IUnityCallback forwardTo, IUtil util) { }

}

// Namespace: UnityEngine.Purchasing
public class FakeUDPExtension 
{
	// Methods

	// RVA: 0x15A6E04
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal interface INativeUDPStore 
{
	// Methods

	// RVA: 0x2FE4574
	void Initialize(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x2FE49A8
	void Purchase(string productId, System.Action<System.Boolean,System.String> callback, string developerPayload) { }

	// RVA: 0x2FE47D4
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x2FE47D4
	void FinishTransaction(ProductDefinition productDefinition, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
public interface IUDPExtensions 
{}

// Namespace: UnityEngine.Purchasing
public class UDP 
{
	// Methods

	// RVA: 0x15A6E0C
	string get_Name() { }

}

// Namespace: UnityEngine.Purchasing
internal class UDPBindings 
{
	// Fields
	private readonly object m_Bridge; // 0x10
	private System.Action<System.Boolean,System.String> m_RetrieveProductsCallbackCache; // 0x18

	// Methods

	// RVA: 0x15A7118
	void .ctor() { }

	// RVA: 0x15A7330
	void Initialize(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x15A74EC
	void Purchase(string productId, System.Action<System.Boolean,System.String> callback, string developerPayload) { }

	// RVA: 0x15A7720
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x15A7CAC
	void FinishTransaction(ProductDefinition productDefinition, string transactionID) { }

	// RVA: 0x15A7E68
	void OnInventoryQueried(bool success, object payload) { }

	// RVA: 0x15A9250
	void RetrieveProducts(string json) { }

	// RVA: 0x15A9290
	void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x15A92D0
	void FinishTransaction(string productJSON, string transactionID) { }

	// RVA: 0x15A9058
	System.Collections.Generic.Dictionary<System.String,System.String> StringPropertyToDictionary(object info) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0 
{
	// Fields
	public UDPImpl <>4__this; // 0x10
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x15A9520
	void .ctor() { }

	// RVA: 0x15A9B24
	void <RetrieveProducts>g__retrieveCallback|0(bool success, string json) { }

	// RVA: 0x15A9BE0
	void <RetrieveProducts>b__1(bool success, string message) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0 
{
	// Fields
	public ProductDefinition product; // 0x10
	public UDPImpl <>4__this; // 0x18

	// Methods

	// RVA: 0x15A9694
	void .ctor() { }

	// RVA: 0x15A9FF0
	void <Purchase>b__0(bool success, string message) { }

}

// Namespace: UnityEngine.Purchasing
internal class UDPImpl 
{
	// Fields
	private INativeUDPStore m_Bindings; // 0x48
	private object m_UserInfo; // 0x50
	private string m_LastInitError; // 0x58
	private bool m_Initialized; // 0x60
	private System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback; // 0x68

	// Methods

	// RVA: 0x15A9310
	void SetNativeStore(INativeUDPStore nativeUdpStore) { }

	// RVA: 0x15A9318
	void Initialize(IStoreCallback callback) { }

	// RVA: 0x15A9320
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x15A9528
	void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x15A969C
	void OnPurchaseDeferred(string productId) { }

	// RVA: 0x15A97C8
	void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x15A98A8
	void DictionaryToStringProperty(System.Collections.Generic.Dictionary<System.String,System.Object> dic, object info) { }

	// RVA: 0x15A9A24
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public Assembly assembly; // 0x10

	// Methods

	// RVA: 0x15AAF08
	void .ctor() { }

	// RVA: 0x15AB240
	bool <GetTypeByName>b__0(string x) { }

}

// Namespace: UnityEngine.Purchasing
internal class UDPReflectionUtils 
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Reflection.Assembly,System.Type[]> s_assemblyTypeCache; // 0x0
	private static readonly System.Collections.Generic.Dictionary<System.String,System.Type> s_typeCache; // 0x8
	private static readonly string[] k_whiteListedAssemblies; // 0x10

	// Methods

	// RVA: 0x15AA6E4
	Type GetTypeByName(string typeName) { }

	// RVA: 0x15AAEE4
	System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetAllAssemblies() { }

	// RVA: 0x15AAF10
	System.Collections.Generic.IEnumerable<System.Type> GetTypes(Assembly assembly) { }

	// RVA: 0x15AB038
	void .cctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class InventoryInterface 
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x15A8C1C
	Type GetClassType() { }

	// RVA: 0x15A8D40
	MethodInfo GetProductListMethod() { }

	// RVA: 0x15A9000
	MethodInfo GetPurchaseInfoMethod() { }

	// RVA: 0x15A8FA8
	MethodInfo HasPurchaseMethod() { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductInfoInterface 
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x15AB280
	Type GetClassType() { }

	// RVA: 0x15A8EA0
	PropertyInfo GetCurrencyProp() { }

	// RVA: 0x15A8E48
	PropertyInfo GetDescriptionProp() { }

	// RVA: 0x15A8D98
	PropertyInfo GetPriceProp() { }

	// RVA: 0x15A8EF8
	PropertyInfo GetPriceAmountMicrosProp() { }

	// RVA: 0x15A8F50
	PropertyInfo GetProductIdProp() { }

	// RVA: 0x15A8DF0
	PropertyInfo GetTitleProp() { }

}

// Namespace: UnityEngine.Purchasing
internal class StoreServiceInterface 
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x15AB3A4
	Type GetClassType() { }

	// RVA: 0x15AB4C8
	PropertyInfo GetNameProp() { }

	// RVA: 0x15A704C
	string GetName() { }

}

// Namespace: UnityEngine.Purchasing
internal class UdpIapBridgeInterface 
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x15A720C
	Type GetClassType() { }

	// RVA: 0x15A7494
	MethodInfo GetInitMethod() { }

	// RVA: 0x15A76C8
	MethodInfo GetPurchaseMethod() { }

	// RVA: 0x15A7C54
	MethodInfo GetRetrieveProductsMethod() { }

	// RVA: 0x15A7E10
	MethodInfo GetFinishTransactionMethod() { }

}

// Namespace: UnityEngine.Purchasing
internal class UserInfoInterface 
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x15A9ECC
	Type GetClassType() { }

}

// Namespace: UnityEngine.Purchasing
internal class AppleJsonProductDescriptionsDeserializer 
{
	// Methods

	// RVA: 0x15AB528
	ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

	// RVA: 0x15AB688
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class AppleProductMetadata 
{
	// Fields
	private readonly bool <isFamilyShareable>k__BackingField; // 0x40

	// Methods

	// RVA: 0x15AB608
	void .ctor(ProductMetadata baseProductMetadata, string isFamilyShareable) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.AppleStoreImpl.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__39_1; // 0x8
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Object>,System.String> <>9__62_0; // 0x10
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Object>,System.String> <>9__62_1; // 0x18

	// Methods

	// RVA: 0x15AF880
	void .cctor() { }

	// RVA: 0x15AF8EC
	void .ctor() { }

	// RVA: 0x15AF8F4
	int <FindMostRecentReceipt>b__39_1(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

	// RVA: 0x15AF984
	string <OnFetchStorePromotionVisibilitySucceeded>b__62_0(System.Collections.Generic.KeyValuePair<System.String,System.Object> k) { }

	// RVA: 0x15AFA4C
	string <OnFetchStorePromotionVisibilitySucceeded>b__62_1(System.Collections.Generic.KeyValuePair<System.String,System.Object> k) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0 
{
	// Fields
	public string productId; // 0x10

	// Methods

	// RVA: 0x15AD35C
	void .ctor() { }

	// RVA: 0x15AFB2C
	bool <FindMostRecentReceipt>b__0(AppleInAppPurchaseReceipt r) { }

}

// Namespace: 
private sealed class <>c__DisplayClass64_0 
{
	// Fields
	public string subject; // 0x10
	public string payload; // 0x18
	public string receipt; // 0x20
	public string transactionId; // 0x28
	public string originalTransactionId; // 0x30
	public bool isRestored; // 0x38

	// Methods

	// RVA: 0x15AE388
	void .ctor() { }

	// RVA: 0x15AFB54
	void <MessageCallback>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class AppleStoreImpl 
{
	// Fields
	private System.Action<UnityEngine.Purchasing.Product> m_DeferredCallback; // 0x48
	private System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> m_RevokedCallback; // 0x50
	private System.Action<System.String> m_RefreshReceiptError; // 0x58
	private System.Action<System.String> m_RefreshReceiptSuccess; // 0x60
	private System.Action<System.Boolean> m_ObsoleteRestoreCallback; // 0x68
	private System.Action<System.Boolean,System.String> m_RestoreCallback; // 0x70
	private Action m_FetchStorePromotionOrderError; // 0x78
	private System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> m_FetchStorePromotionOrderSuccess; // 0x80
	private System.Action<UnityEngine.Purchasing.Product> m_PromotionalPurchaseCallback; // 0x88
	private Action m_FetchStorePromotionVisibilityError; // 0x90
	private System.Action<System.String,UnityEngine.Purchasing.AppleStorePromotionVisibility> m_FetchStorePromotionVisibilitySuccess; // 0x98
	private INativeAppleStore m_Native; // 0xA0
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0xA8
	private static IUtil s_Util; // 0x0
	private static AppleStoreImpl s_Instance; // 0x8
	private string m_CachedAppReceipt; // 0xB0
	private System.Nullable<System.Double> m_CachedAppReceiptModificationDate; // 0xB8
	private string m_ProductsJson; // 0xC8

	// Methods

	// RVA: 0x15AB864
	void .ctor(IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x15AB9A0
	void SetNativeStore(INativeAppleStore apple) { }

	// RVA: 0x15ABABC
	string get_appReceipt() { }

	// RVA: 0x15ABCB0
	System.Nullable<System.Double> get_appReceiptModificationDate() { }

	// RVA: 0x15ABDA8
	string GetTransactionReceiptForProduct(Product product) { }

	// RVA: 0x15ABEB8
	void OnProductsRetrieved(string json) { }

	// RVA: 0x15AC2A0
	bool HasInAppPurchaseReceipts(AppleReceipt appleReceipt) { }

	// RVA: 0x15AC2C4
	System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> EnrichProductDescriptions(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> productDescriptions, AppleReceipt appleReceipt) { }

	// RVA: 0x15AC824
	AppleInAppPurchaseReceipt FindMostRecentReceipt(AppleReceipt appleReceipt, string productId) { }

	// RVA: 0x15AD364
	AppleInAppPurchaseReceipt FirstNonCancelledReceipt(AppleInAppPurchaseReceipt[] foundReceipts) { }

	// RVA: 0x15AD424
	void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback) { }

	// RVA: 0x15AD42C
	void OnPurchaseDeferred(string productId) { }

	// RVA: 0x15AD534
	void OnPromotionalPurchaseAttempted(string productId) { }

	// RVA: 0x15AD63C
	void OnTransactionsRestoredSuccess() { }

	// RVA: 0x15AD6AC
	void OnTransactionsRestoredFail(string error) { }

	// RVA: 0x15AD718
	void OnAppReceiptRetrieved(string receipt) { }

	// RVA: 0x15AD734
	void OnAppReceiptRefreshedFailed(string error) { }

	// RVA: 0x15AD750
	void OnEntitlementsRevoked(string productIds) { }

	// RVA: 0x15ADB00
	void RevokeEntitlement(AppleReceipt appleReceipt, string productId, System.Collections.Generic.List<UnityEngine.Purchasing.Product> revokedProducts, Product product) { }

	// RVA: 0x15ADBC0
	bool RestoreActiveEntitlement(AppleReceipt appleReceipt, string productId) { }

	// RVA: 0x15ADCD0
	void OnFetchStorePromotionOrderSucceeded(string productIds) { }

	// RVA: 0x15AE010
	void OnFetchStorePromotionOrderFailed() { }

	// RVA: 0x15AE02C
	void OnFetchStorePromotionVisibilitySucceeded(string result) { }

	// RVA: 0x15AE36C
	void OnFetchStorePromotionVisibilityFailed() { }

	// RVA: 0x15AB690
	void MessageCallback(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	// RVA: 0x15AE390
	void ProcessMessage(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	// RVA: 0x15AEBC0
	void OnPurchaseSucceeded(string id, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	// RVA: 0x15AC108
	AppleReceipt GetAppleReceiptFromBase64String(string receipt) { }

	// RVA: 0x15AEDD0
	bool IsValidPurchaseState(AppleInAppPurchaseReceipt mostRecentReceipt, string productId) { }

	// RVA: 0x15AEF48
	bool IsRestored(string productId, AppleInAppPurchaseReceipt productReceipt, string transactionId, string originalTransactionId) { }

	// RVA: 0x15AF254
	bool IsSubscriptionRestored(AppleInAppPurchaseReceipt productReceipt, Product previousProduct) { }

	// RVA: 0x15AF234
	bool IsNonSubscriptionRestored(string transactionId, string originalTransactionId) { }

	// RVA: 0x15AD258
	void UpdateAppleProductFields(string id, string originalTransactionId, bool isRestored) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeAppleConfiguration 
{
	// Methods

	// RVA: 0x15AFBD0
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeAppleExtensions 
{
	// Methods

	// RVA: 0x15AFBD8
	void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback) { }

	// RVA: 0x15AFBDC
	string GetTransactionReceiptForProduct(Product product) { }

	// RVA: 0x15AFC20
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public interface IAppleConfiguration 
{}

// Namespace: UnityEngine.Purchasing
public interface IAppleExtensions 
{
	// Methods

	// RVA: 0x2FE36BC
	string GetTransactionReceiptForProduct(Product product) { }

	// RVA: 0x2FE4574
	void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback) { }

}

// Namespace: UnityEngine.Purchasing
public enum AppleStorePromotionVisibility 
{
	// Fields
	public int value__; // 0x10
	public const AppleStorePromotionVisibility Default = 0;
	public const AppleStorePromotionVisibility Hide = 1;
	public const AppleStorePromotionVisibility Show = 2;
}

// Namespace: 
private sealed class <>c__DisplayClass10_0 
{
	// Fields
	public MetricizedAppleStoreImpl <>4__this; // 0x10
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x15AFDDC
	void .ctor() { }

	// RVA: 0x15B01E4
	void <RetrieveProducts>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0 
{
	// Fields
	public MetricizedAppleStoreImpl <>4__this; // 0x10
	public ProductDefinition product; // 0x18
	public string developerPayload; // 0x20

	// Methods

	// RVA: 0x15AFF84
	void .ctor() { }

	// RVA: 0x15B02A8
	void <Purchase>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedAppleStoreImpl 
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0xD0

	// Methods

	// RVA: 0x15AFC28
	void .ctor(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

	// RVA: 0x15AFC58
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x15AFDE4
	void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x15AFF8C
	void <>n__6(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x15B010C
	void <>n__7(ProductDefinition product, string developerPayload) { }

}

// Namespace: UnityEngine.Purchasing
public enum AppStore 
{
	// Fields
	public int value__; // 0x10
	public const AppStore NotSpecified = 0;
	public const AppStore GooglePlay = 1;
	public const AppStore AmazonAppStore = 2;
	public const AppStore UDP = 3;
	public const AppStore MacAppStore = 4;
	public const AppStore AppleAppStore = 5;
	public const AppStore WinRT = 6;
	public const AppStore fake = 7;
}

// Namespace: UnityEngine.Purchasing
internal interface INativeStoreProvider 
{
	// Methods

	// RVA: -1
	INativeStore GetAndroidStore(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util) { }

	// RVA: 0x2FE36BC
	INativeAppleStore GetStorekit(IUnityCallback callback) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IStoreInternal 
{
	// Methods

	// RVA: 0x2FE4574
	void SetModule(StandardPurchasingModule module) { }

}

// Namespace: UnityEngine.Purchasing
internal class JSONStore 
{
	// Fields
	protected IStoreCallback unity; // 0x10
	private INativeStore m_Store; // 0x18
	private StandardPurchasingModule m_Module; // 0x20
	protected ILogger m_Logger; // 0x28
	protected JsonProductDescriptionsDeserializer m_ProductDescriptionsDeserializer; // 0x30
	protected PurchaseFailureDescription m_LastPurchaseFailureDescription; // 0x38
	private StoreSpecificPurchaseErrorCode m_LastPurchaseErrorCode; // 0x40

	// Methods

	// RVA: 0x15A9AA4
	void .ctor() { }

	// RVA: 0x15B02CC
	void SetNativeStore(INativeStore native) { }

	// RVA: 0x15B02D4
	void UnityEngine.Purchasing.IStoreInternal.SetModule(StandardPurchasingModule module) { }

	// RVA: 0x15B03D8
	void Initialize(IStoreCallback callback) { }

	// RVA: 0x15B004C
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x15B0110
	void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x15AF15C
	void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x15AEA3C
	void OnSetupFailed(string reason) { }

	// RVA: 0x15B0470
	void OnProductsRetrieved(string json) { }

	// RVA: 0x15AF08C
	void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	// RVA: 0x15AED9C
	void OnPurchaseFailed(string json) { }

	// RVA: 0x15B053C
	void OnPurchaseFailed(PurchaseFailureDescription failure, string json) { }

	// RVA: 0x15B0614
	StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0 
{
	// Fields
	public MetricizedJsonStore <>4__this; // 0x10
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x15B0AB8
	void .ctor() { }

	// RVA: 0x15B0D2C
	void <RetrieveProducts>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public MetricizedJsonStore <>4__this; // 0x10
	public ProductDefinition product; // 0x18
	public string developerPayload; // 0x20

	// Methods

	// RVA: 0x15B0C60
	void .ctor() { }

	// RVA: 0x15B0DF0
	void <Purchase>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedJsonStore 
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x48

	// Methods

	// RVA: 0x15B08A0
	void .ctor(ITelemetryMetricsService telemetryMetricsService) { }

	// RVA: 0x15B0934
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x15B0AC0
	void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x15B0C68
	void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x15B0D28
	void <>n__1(ProductDefinition product, string developerPayload) { }

}

// Namespace: UnityEngine.Purchasing
internal class NativeStoreProvider 
{
	// Methods

	// RVA: 0x15B0E14
	INativeStore GetAndroidStore(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util) { }

	// RVA: 0x15B0F4C
	INativeStore GetAndroidStoreHelper(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util) { }

	// RVA: 0x15B1600
	INativeAppleStore GetStorekit(IUnityCallback callback) { }

	// RVA: 0x15B1714
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class DialogRequest 
{
	// Fields
	public string QueryText; // 0x10
	public string OkayButtonText; // 0x18
	public string CancelButtonText; // 0x20
	public System.Collections.Generic.List<System.String> Options; // 0x28
	public System.Action<System.Boolean,System.Int32> Callback; // 0x30

	// Methods

	// RVA: 0x15B171C
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public enum FakeStoreUIMode 
{
	// Fields
	public int value__; // 0x10
	public const FakeStoreUIMode Default = 0;
	public const FakeStoreUIMode StandardUser = 1;
	public const FakeStoreUIMode DeveloperUser = 2;
}

// Namespace: 
protected enum DialogType 
{
	// Fields
	public int value__; // 0x10
	public const DialogType Purchase = 0;
	public const DialogType RetrieveProducts = 1;
}

// Namespace: 
private sealed class <>c__DisplayClass13_0 
{
	// Fields
	public FakeStore <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products; // 0x18

	// Methods

	// RVA: 0x15B2200
	void .ctor() { }

	// RVA: 0x15B22E8
	void <StoreRetrieveProducts>g__handleAllowInitializeOrRetrieveProducts|0(bool allow, InitializationFailureReason failureReason) { }

}

// Namespace: 
private sealed class <>c__DisplayClass15_0 
{
	// Fields
	public FakeStore <>4__this; // 0x10
	public ProductDefinition product; // 0x18

	// Methods

	// RVA: 0x15B2978
	void .ctor() { }

	// RVA: 0x15B2980
	void <FakePurchase>g__handleAllowPurchase|0(bool allow, PurchaseFailureReason failureReason) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeStore 
{
	// Fields
	private IStoreCallback m_Biller; // 0x48
	private readonly System.Collections.Generic.List<System.String> m_PurchasedProducts; // 0x50
	public bool purchaseCalled; // 0x58
	private string <unavailableProductId>k__BackingField; // 0x60
	public FakeStoreUIMode UIMode; // 0x68

	// Methods

	// RVA: 0x15B1724
	string get_unavailableProductId() { }

	// RVA: 0x15B172C
	void Initialize(IStoreCallback biller) { }

	// RVA: 0x15B17CC
	void RetrieveProducts(string json) { }

	// RVA: 0x15B18E4
	void StoreRetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefinitions) { }

	// RVA: 0x15B2438
	void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x15B2720
	void FakePurchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x15B2C10
	void FinishTransaction(string productJSON, string transactionID) { }

	// RVA: 0x15B2C14
	void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: -1
	bool StartUI(object model, DialogType dialogType, System.Action<System.Boolean,T> callback) { }

	// RVA: 0x15B2C18
	void .ctor() { }

	// RVA: 0x15B2CF8
	void <>n__0(string id, string receipt, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
internal class LifecycleNotifier 
{
	// Fields
	public Action OnDestroyCallback; // 0x20

	// Methods

	// RVA: 0x15B2DC8
	void OnDestroy() { }

	// RVA: 0x15B2DE4
	void .ctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.UIFakeStore.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.String> <>9__20_0; // 0x8

	// Methods

	// RVA: 0x15B3F54
	void .cctor() { }

	// RVA: 0x15B3FC0
	void .ctor() { }

	// RVA: 0x15B3FC8
	string <CreateRetrieveProductsQuestion>b__20_0(ProductDefinition pid) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0<T0> 
{
	// Fields
	public System.Action<System.Boolean,T> callback; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: -1
	void <StartUI>b__0(bool result, int codeValue) { }

}

// Namespace: UnityEngine.Purchasing
internal class UIFakeStore 
{
	// Fields
	private DialogRequest m_CurrentDialog; // 0x70
	private int m_LastSelectedDropdownIndex; // 0x78
	private GameObject m_UIFakeStoreWindowObject; // 0x80
	private GameObject m_EventSystem; // 0x88

	// Methods

	// RVA: 0x15B2DEC
	void .ctor() { }

	// RVA: -1
	bool StartUI(object model, DialogType dialogType, System.Action<System.Boolean,T> callback) { }

	// RVA: 0x15B2DF0
	bool StartUI(string queryText, string okayButtonText, string cancelButtonText, System.Collections.Generic.List<System.String> options, System.Action<System.Boolean,System.Int32> callback) { }

	// RVA: 0x15B2F10
	void InstantiateDialog() { }

	// RVA: 0x15B30AC
	UIFakeStoreWindow GetOrCreateFakeStoreWindow() { }

	// RVA: 0x15B32AC
	void AddLifeCycleNotifierAndSetDestroyCallback(GameObject gameObject) { }

	// RVA: 0x15B3368
	void EnsureEventSystemCreated(Transform rootTransform) { }

	// RVA: 0x15B3438
	void ConfigureDialogWindow(UIFakeStoreWindow dialogWindow) { }

	// RVA: 0x15B3834
	void ConfigureDialogWindowCallbacks(UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback) { }

	// RVA: 0x15B34E4
	void CreateEventSystem(Transform rootTransform) { }

	// RVA: 0x15B3A0C
	string CreatePurchaseQuestion(ProductDefinition definition) { }

	// RVA: 0x15B3A7C
	string CreateRetrieveProductsQuestion(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> definitions) { }

	// RVA: 0x15B3CA4
	void OkayButtonClicked() { }

	// RVA: 0x15B3E60
	void CancelButtonClicked() { }

	// RVA: 0x15B3F40
	void DropdownValueChanged(int selectedItem) { }

	// RVA: 0x15B3D80
	void CloseDialog() { }

	// RVA: 0x15B2F00
	bool IsShowingDialog() { }

	// RVA: 0x15B3F48
	void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0() { }

}

// Namespace: UnityEngine.Purchasing
internal class UIFakeStoreDropdown 
{
	// Fields
	private System.Collections.Generic.List<System.String> m_Options; // 0x10
	private System.Action<System.Int32,System.String> m_OnDropdown; // 0x18
	private Vector2 scrollPosition; // 0x20

	// Methods

	// RVA: 0x15B3FE4
	void DoPopup(int windowID) { }

	// RVA: 0x15B43C4
	void OnOptionSelected(int optionIndex) { }

	// RVA: 0x15B445C
	void SetOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x15B44EC
	void SetSelectionAction(System.Action<System.Int32,System.String> onDropdown) { }

	// RVA: 0x15B44F4
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class UIFakeStoreWindow 
{
	// Fields
	private string m_QueryText; // 0x20
	private string m_OkText; // 0x28
	private string m_CancelText; // 0x30
	private string m_LastSelectedOptionText; // 0x38
	private Action m_OnOk; // 0x40
	private Action m_OnCancel; // 0x48
	private System.Action<System.Int32> m_OnDropdown; // 0x50
	private bool m_CancelEnabled; // 0x58
	private bool m_DropdownEnabled; // 0x59
	private bool m_DoDropdown; // 0x5A
	private readonly UIFakeStoreDropdown m_Dropdown; // 0x60
	private Vector2 scrollPosition; // 0x68
	private const float k_MenuScreenRatio = 1058642330;

	// Methods

	// RVA: 0x15B44FC
	void OnGUI() { }

	// RVA: 0x15B46C4
	Rect CreateCenteredWindowRect() { }

	// RVA: 0x15B4748
	void DoMainGUI(int windowID) { }

	// RVA: 0x15B4BE8
	void DoDropDown() { }

	// RVA: 0x15B4BF4
	void OnOkClicked() { }

	// RVA: 0x15B4C10
	void OnCancelClicked() { }

	// RVA: 0x15B3674
	void ConfigureMainDialogText(string queryText, string okText, string cancelText) { }

	// RVA: 0x15B36C4
	void ConfigureDropdownOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x15B4C2C
	void OnDropdown(int index, string selectionText) { }

	// RVA: 0x15B39A4
	void AssignCallbacks(Action onOk, Action onCancel, System.Action<System.Int32> onDropdown) { }

	// RVA: 0x15B4C94
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class Price 
{
	// Fields
	public Decimal value; // 0x10
	private int[] data; // 0x20
	private Double num; // 0x28

	// Methods

	// RVA: 0x15B4D0C
	void OnBeforeSerialize() { }

	// RVA: 0x15B4D9C
	void OnAfterDeserialize() { }

	// RVA: 0x15B4E18
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class StoreID 
{}

// Namespace: UnityEngine.Purchasing
public enum TranslationLocale 
{
	// Fields
	public int value__; // 0x10
	public const TranslationLocale zh_TW = 0;
	public const TranslationLocale cs_CZ = 1;
	public const TranslationLocale da_DK = 2;
	public const TranslationLocale nl_NL = 3;
	public const TranslationLocale en_US = 4;
	public const TranslationLocale fr_FR = 5;
	public const TranslationLocale fi_FI = 6;
	public const TranslationLocale de_DE = 7;
	public const TranslationLocale iw_IL = 8;
	public const TranslationLocale hi_IN = 9;
	public const TranslationLocale it_IT = 10;
	public const TranslationLocale ja_JP = 11;
	public const TranslationLocale ko_KR = 12;
	public const TranslationLocale no_NO = 13;
	public const TranslationLocale pl_PL = 14;
	public const TranslationLocale pt_PT = 15;
	public const TranslationLocale ru_RU = 16;
	public const TranslationLocale es_ES = 17;
	public const TranslationLocale sv_SE = 18;
	public const TranslationLocale zh_CN = 19;
	public const TranslationLocale en_AU = 20;
	public const TranslationLocale en_CA = 21;
	public const TranslationLocale en_GB = 22;
	public const TranslationLocale fr_CA = 23;
	public const TranslationLocale el_GR = 24;
	public const TranslationLocale id_ID = 25;
	public const TranslationLocale ms_MY = 26;
	public const TranslationLocale pt_BR = 27;
	public const TranslationLocale es_MX = 28;
	public const TranslationLocale th_TH = 29;
	public const TranslationLocale tr_TR = 30;
	public const TranslationLocale vi_VN = 31;
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.LocalizedProductDescription.<>c <>9; // 0x0
	public static MatchEvaluator <>9__11_0; // 0x8

	// Methods

	// RVA: 0x15B4FA4
	void .cctor() { }

	// RVA: 0x15B5010
	void .ctor() { }

	// RVA: 0x15B5018
	string <DecodeNonLatinCharacters>b__11_0(Match m) { }

}

// Namespace: UnityEngine.Purchasing
public class LocalizedProductDescription 
{
	// Fields
	public TranslationLocale googleLocale; // 0x10
	private string title; // 0x18
	private string description; // 0x20

	// Methods

	// RVA: 0x15B22D8
	string get_Title() { }

	// RVA: 0x15B22E0
	string get_Description() { }

	// RVA: 0x15B4E20
	string DecodeNonLatinCharacters(string s) { }

	// RVA: 0x15B4F94
	void .ctor() { }

}

// Namespace: 
public enum ProductCatalogPayoutType 
{
	// Fields
	public int value__; // 0x10
	public const ProductCatalogPayoutType Other = 0;
	public const ProductCatalogPayoutType Currency = 1;
	public const ProductCatalogPayoutType Item = 2;
	public const ProductCatalogPayoutType Resource = 3;
}

// Namespace: UnityEngine.Purchasing
public class ProductCatalogPayout 
{
	// Fields
	private string t; // 0x10
	private string st; // 0x18
	private string d; // 0x20

	// Methods

	// RVA: 0x15B50D8
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class ProductCatalogItem 
{
	// Fields
	public string id; // 0x10
	private System.Collections.Generic.List<UnityEngine.Purchasing.StoreID> storeIDs; // 0x18
	public LocalizedProductDescription defaultDescription; // 0x20
	public Price googlePrice; // 0x28
	private System.Collections.Generic.List<UnityEngine.Purchasing.LocalizedProductDescription> descriptions; // 0x30
	public Price udpPrice; // 0x38
	private System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogPayout> payouts; // 0x40

	// Methods

	// RVA: 0x15B51A8
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class ProductCatalog 
{
	// Fields
	private static IProductCatalogImpl instance; // 0x0
	public bool enableCodelessAutoInitialization; // 0x10
	private System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogItem> products; // 0x18

	// Methods

	// RVA: 0x15B5380
	System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> get_allProducts() { }

	// RVA: 0x15B5388
	void Initialize() { }

	// RVA: 0x15B5458
	void Initialize(IProductCatalogImpl productCatalogImpl) { }

	// RVA: 0x15B54BC
	ProductCatalog Deserialize(string catalogJSON) { }

	// RVA: 0x15B5524
	ProductCatalog FromTextAsset(TextAsset asset) { }

	// RVA: 0x15B2208
	ProductCatalog LoadDefaultCatalog() { }

	// RVA: 0x15B559C
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public interface IProductCatalogImpl 
{
	// Methods

	// RVA: 0x2FE360C
	ProductCatalog LoadDefaultCatalog() { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductCatalogImpl 
{
	// Methods

	// RVA: 0x15B5630
	ProductCatalog LoadDefaultCatalog() { }

	// RVA: 0x15B5450
	void .ctor() { }

}

// Namespace: 
internal class StoreInstance 
{
	// Fields
	private readonly string <storeName>k__BackingField; // 0x10
	private readonly IStore <instance>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15B8050
	string get_storeName() { }

	// RVA: 0x15B8058
	IStore get_instance() { }

	// RVA: 0x15B69C8
	void .ctor(string name, IStore instance) { }

}

// Namespace: 
private class MicrosoftConfiguration 
{
	// Fields
	private readonly StandardPurchasingModule module; // 0x10

	// Methods

	// RVA: 0x15B6644
	void .ctor(StandardPurchasingModule module) { }

}

// Namespace: UnityEngine.Purchasing
public class StandardPurchasingModule 
{
	// Fields
	internal readonly string k_Version; // 0x18
	private readonly INativeStoreProvider m_NativeStoreProvider; // 0x20
	private readonly RuntimePlatform m_RuntimePlatform; // 0x28
	private static StandardPurchasingModule ModuleInstance; // 0x0
	private IUtil <util>k__BackingField; // 0x30
	private ILogger <logger>k__BackingField; // 0x38
	private StoreInstance <storeInstance>k__BackingField; // 0x40
	private ITelemetryMetricsInstanceWrapper <telemetryMetricsInstanceWrapper>k__BackingField; // 0x48
	private ITelemetryDiagnosticsInstanceWrapper <telemetryDiagnosticsInstanceWrapper>k__BackingField; // 0x50
	private static readonly System.Collections.Generic.Dictionary<UnityEngine.Purchasing.AppStore,System.String> AndroidStoreNameMap; // 0x8
	private AppStore <appStore>k__BackingField; // 0x58
	private FakeStoreUIMode <useFakeStoreUIMode>k__BackingField; // 0x5C
	private bool <useFakeStoreAlways>k__BackingField; // 0x60
	private WinRTStore windowsStore; // 0x68

	// Methods

	// RVA: 0x15B5830
	IUtil get_util() { }

	// RVA: 0x15B5838
	void set_util(IUtil value) { }

	// RVA: 0x15B5840
	ILogger get_logger() { }

	// RVA: 0x15B5848
	void set_logger(ILogger value) { }

	// RVA: 0x15B5850
	StoreInstance get_storeInstance() { }

	// RVA: 0x15B5858
	void set_storeInstance(StoreInstance value) { }

	// RVA: 0x15B5860
	ITelemetryMetricsInstanceWrapper get_telemetryMetricsInstanceWrapper() { }

	// RVA: 0x15B5868
	void set_telemetryMetricsInstanceWrapper(ITelemetryMetricsInstanceWrapper value) { }

	// RVA: 0x15B5870
	ITelemetryDiagnosticsInstanceWrapper get_telemetryDiagnosticsInstanceWrapper() { }

	// RVA: 0x15B5878
	void set_telemetryDiagnosticsInstanceWrapper(ITelemetryDiagnosticsInstanceWrapper value) { }

	// RVA: 0x15B5880
	void .ctor(IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, RuntimePlatform platform, AppStore android, ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	// RVA: 0x15B5974
	AppStore get_appStore() { }

	// RVA: 0x15B597C
	void set_appStore(AppStore value) { }

	// RVA: 0x15B5984
	FakeStoreUIMode get_useFakeStoreUIMode() { }

	// RVA: 0x15B598C
	void set_useFakeStoreUIMode(FakeStoreUIMode value) { }

	// RVA: 0x15B5994
	bool get_useFakeStoreAlways() { }

	// RVA: 0x15B599C
	void set_useFakeStoreAlways(bool value) { }

	// RVA: 0x15B59A4
	StandardPurchasingModule Instance() { }

	// RVA: 0x15B5A14
	StandardPurchasingModule Instance(AppStore androidStore) { }

	// RVA: 0x15B6090
	void Configure() { }

	// RVA: 0x15B6678
	StoreInstance InstantiateStore() { }

	// RVA: 0x15B6DA4
	IStore InstantiateAndroid() { }

	// RVA: 0x15B7040
	IStore InstantiateGoogleStore() { }

	// RVA: 0x15B7DCC
	void BindGoogleExtension(GooglePlayStoreExtensions googlePlayStoreExtensions) { }

	// RVA: 0x15B7BE4
	GooglePlayConfiguration BuildGooglePlayStoreConfiguration(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback) { }

	// RVA: 0x15B7D70
	void BindGoogleConfiguration(GooglePlayConfiguration googlePlayConfiguration) { }

	// RVA: 0x15B7640
	IGooglePlayStoreService BuildAndInitGooglePlayStoreServiceAar(IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider) { }

	// RVA: 0x15B6BC0
	IStore InstantiateUDP() { }

	// RVA: 0x15B7550
	IStore InstantiateAndroidHelper(JSONStore store) { }

	// RVA: 0x15B7E28
	INativeStore GetAndroidNativeStore(JSONStore store) { }

	// RVA: 0x15B6A18
	IStore InstantiateApple() { }

	// RVA: 0x15B6ED0
	IStore instantiateWindowsStore() { }

	// RVA: 0x15B6924
	IStore InstantiateFakeStore() { }

	// RVA: 0x15B7EFC
	void .cctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class StoreConfiguration 
{
	// Fields
	private AppStore <androidStore>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15B8060
	AppStore get_androidStore() { }

	// RVA: 0x15B8068
	void set_androidStore(AppStore value) { }

	// RVA: 0x15B8070
	void .ctor(AppStore store) { }

	// RVA: 0x15B5DE4
	StoreConfiguration Deserialize(string json) { }

}

// Namespace: UnityEngine.Purchasing
public enum StoreSpecificPurchaseErrorCode 
{
	// Fields
	public int value__; // 0x10
	public const StoreSpecificPurchaseErrorCode SKErrorUnknown = 0;
	public const StoreSpecificPurchaseErrorCode SKErrorClientInvalid = 1;
	public const StoreSpecificPurchaseErrorCode SKErrorPaymentCancelled = 2;
	public const StoreSpecificPurchaseErrorCode SKErrorPaymentInvalid = 3;
	public const StoreSpecificPurchaseErrorCode SKErrorPaymentNotAllowed = 4;
	public const StoreSpecificPurchaseErrorCode SKErrorStoreProductNotAvailable = 5;
	public const StoreSpecificPurchaseErrorCode SKErrorCloudServicePermissionDenied = 6;
	public const StoreSpecificPurchaseErrorCode SKErrorCloudServiceNetworkConnectionFailed = 7;
	public const StoreSpecificPurchaseErrorCode SKErrorCloudServiceRevoked = 8;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_OK = 9;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_USER_CANCELED = 10;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_SERVICE_UNAVAILABLE = 11;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_BILLING_UNAVAILABLE = 12;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_ITEM_UNAVAILABLE = 13;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_DEVELOPER_ERROR = 14;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_ERROR = 15;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_ITEM_ALREADY_OWNED = 16;
	public const StoreSpecificPurchaseErrorCode BILLING_RESPONSE_RESULT_ITEM_NOT_OWNED = 17;
	public const StoreSpecificPurchaseErrorCode IABHELPER_ERROR_BASE = 18;
	public const StoreSpecificPurchaseErrorCode IABHELPER_REMOTE_EXCEPTION = 19;
	public const StoreSpecificPurchaseErrorCode IABHELPER_BAD_RESPONSE = 20;
	public const StoreSpecificPurchaseErrorCode IABHELPER_VERIFICATION_FAILED = 21;
	public const StoreSpecificPurchaseErrorCode IABHELPER_SEND_INTENT_FAILED = 22;
	public const StoreSpecificPurchaseErrorCode IABHELPER_USER_CANCELLED = 23;
	public const StoreSpecificPurchaseErrorCode IABHELPER_UNKNOWN_PURCHASE_RESPONSE = 24;
	public const StoreSpecificPurchaseErrorCode IABHELPER_MISSING_TOKEN = 25;
	public const StoreSpecificPurchaseErrorCode IABHELPER_UNKNOWN_ERROR = 26;
	public const StoreSpecificPurchaseErrorCode IABHELPER_SUBSCRIPTIONS_NOT_AVAILABLE = 27;
	public const StoreSpecificPurchaseErrorCode IABHELPER_INVALID_CONSUMPTION = 28;
	public const StoreSpecificPurchaseErrorCode Amazon_ALREADY_PURCHASED = 29;
	public const StoreSpecificPurchaseErrorCode Amazon_FAILED = 30;
	public const StoreSpecificPurchaseErrorCode Amazon_INVALID_SKU = 31;
	public const StoreSpecificPurchaseErrorCode Amazon_NOT_SUPPORTED = 32;
	public const StoreSpecificPurchaseErrorCode Unknown = 33;
}

// Namespace: UnityEngine.Purchasing
public class TimeSpanUnits 
{
	// Fields
	public Double days; // 0x10
	public int months; // 0x18
	public int years; // 0x1C

	// Methods

	// RVA: 0x15B809C
	void .ctor(Double d, int m, int y) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.SubscriptionManager.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__11_0; // 0x8
	public static System.Func<System.Object,System.String> <>9__12_0; // 0x10

	// Methods

	// RVA: 0x15B96BC
	void .cctor() { }

	// RVA: 0x15B9728
	void .ctor() { }

	// RVA: 0x15B9730
	int <findMostRecentReceipt>b__11_0(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

	// RVA: 0x15B97C0
	string <getGooglePlayStoreSubInfo>b__12_0(object obj) { }

}

// Namespace: UnityEngine.Purchasing
public class SubscriptionManager 
{
	// Fields
	private readonly string receipt; // 0x10
	private readonly string productId; // 0x18
	private readonly string intro_json; // 0x20

	// Methods

	// RVA: 0x15AF4B8
	void .ctor(Product product, string intro_json) { }

	// RVA: 0x15AF528
	SubscriptionInfo getSubscriptionInfo() { }

	// RVA: 0x15B8B48
	SubscriptionInfo getAmazonAppStoreSubInfo(string productId) { }

	// RVA: 0x15B879C
	SubscriptionInfo getAppleAppStoreSubInfo(string payload, string productId) { }

	// RVA: 0x15B8C70
	AppleInAppPurchaseReceipt findMostRecentReceipt(System.Collections.Generic.List<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> receipts) { }

	// RVA: 0x15B80E4
	SubscriptionInfo getGooglePlayStoreSubInfo(string payload) { }

}

// Namespace: UnityEngine.Purchasing
public class SubscriptionInfo 
{
	// Fields
	private readonly Result is_subscribed; // 0x10
	private readonly Result is_expired; // 0x14
	private readonly Result is_cancelled; // 0x18
	private readonly Result is_free_trial; // 0x1C
	private readonly Result is_auto_renewing; // 0x20
	private readonly Result is_introductory_price_period; // 0x24
	private readonly string productId; // 0x28
	private readonly DateTime purchaseDate; // 0x30
	private readonly DateTime subscriptionExpireDate; // 0x38
	private readonly DateTime subscriptionCancelDate; // 0x40
	private readonly TimeSpan remainedTime; // 0x48
	private readonly string introductory_price; // 0x50
	private readonly TimeSpan introductory_price_period; // 0x58
	private readonly Int64 introductory_price_cycles; // 0x60
	private readonly TimeSpan freeTrialPeriod; // 0x68
	private readonly TimeSpan subscriptionPeriod; // 0x70
	private readonly string free_trial_period_string; // 0x78
	private readonly string sku_details; // 0x80

	// Methods

	// RVA: 0x15ACA18
	void .ctor(AppleInAppPurchaseReceipt r, string intro_json) { }

	// RVA: 0x15B8DC8
	void .ctor(string skuDetails, bool isAutoRenewing, DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata) { }

	// RVA: 0x15B8BAC
	void .ctor(string productId) { }

	// RVA: 0x15BA18C
	Result isExpired() { }

	// RVA: 0x15BA194
	Result isCancelled() { }

	// RVA: 0x15BA19C
	DateTime getExpireDate() { }

	// RVA: 0x15BA038
	DateTime nextBillingDate(DateTime billing_begin_date, TimeSpanUnits units) { }

	// RVA: 0x15B9CC0
	TimeSpan accumulateIntroductoryDuration(TimeSpanUnits units, Int64 cycles) { }

	// RVA: 0x15B9A60
	TimeSpan computePeriodTimeSpan(TimeSpanUnits units) { }

	// RVA: 0x15B9DA0
	Double computeExtraTime(string metadata, Double new_sku_period_in_seconds) { }

	// RVA: 0x15B9B40
	TimeSpan parseTimeSpan(string period_string) { }

	// RVA: 0x15B9828
	TimeSpanUnits parsePeriodTimeSpanUnits(string time_span) { }

}

// Namespace: UnityEngine.Purchasing
public enum Result 
{
	// Fields
	public int value__; // 0x10
	public const Result True = 0;
	public const Result False = 1;
	public const Result Unsupported = 2;
}

// Namespace: UnityEngine.Purchasing
public enum SubscriptionPeriodUnit 
{
	// Fields
	public int value__; // 0x10
	public const SubscriptionPeriodUnit Day = 0;
	public const SubscriptionPeriodUnit Month = 1;
	public const SubscriptionPeriodUnit Week = 2;
	public const SubscriptionPeriodUnit Year = 3;
	public const SubscriptionPeriodUnit NotAvailable = 4;
}

// Namespace: UnityEngine.Purchasing
internal enum AppleStoreProductType 
{
	// Fields
	public int value__; // 0x10
	public const AppleStoreProductType NonConsumable = 0;
	public const AppleStoreProductType Consumable = 1;
	public const AppleStoreProductType NonRenewingSubscription = 2;
	public const AppleStoreProductType AutoRenewingSubscription = 3;
}

// Namespace: UnityEngine.Purchasing
public class ReceiptParserException 
{
	// Methods

	// RVA: 0x15BA1A4
	void .ctor() { }

	// RVA: 0x15BA22C
	void .ctor(string message) { }

}

// Namespace: UnityEngine.Purchasing
public class InvalidProductTypeException 
{
	// Methods

	// RVA: 0x15BA298
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class NullProductIdException 
{
	// Methods

	// RVA: 0x15BA320
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class NullReceiptException 
{
	// Methods

	// RVA: 0x15BA3A8
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class StoreSubscriptionInfoNotSupportedException 
{
	// Methods

	// RVA: 0x15BA430
	void .ctor(string message) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeTransactionHistoryExtensions 
{
	// Methods

	// RVA: 0x15BA49C
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public interface ITransactionHistoryExtensions 
{}

// Namespace: 
private sealed class <>c__0<T0> 
{
	// Fields
	public static readonly UnityEngine.Purchasing.EnumerableExtensions.<>c__0<T> <>9; // 0x0
	public static System.Func<T,System.Boolean> <>9__0_0; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	bool <NonNull>b__0_0(T obj) { }

}

// Namespace: 
private sealed class <IgnoreExceptions>d__1<T0, T1> 
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private System.Collections.Generic.IEnumerable<T> enumerable; // 0x0
	public System.Collections.Generic.IEnumerable<T> <>3__enumerable; // 0x0
	private System.Action<TException> onException; // 0x0
	public System.Action<TException> <>3__onException; // 0x0
	private System.Collections.Generic.IEnumerator<T> <enumerator>5__2; // 0x0
	private bool <hasNext>5__3; // 0x0

	// Methods

	// RVA: 0x2FE42A4
	void .ctor(int <>1__state) { }

	// RVA: 0x2FE41A8
	void System.IDisposable.Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x2FE41A8
	void <>m__Finally1() { }

	// RVA: 0x309AF8C
	T System.Collections.Generic.IEnumerator<T>.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.Purchasing
internal static class EnumerableExtensions 
{
	// Methods

	// RVA: 0x2FE7084
	System.Collections.Generic.IEnumerable<T> NonNull(System.Collections.Generic.IEnumerable<T> enumerable) { }

	// RVA: 0x2FE7164
	System.Collections.Generic.IEnumerable<T> IgnoreExceptions(System.Collections.Generic.IEnumerable<T> enumerable, System.Action<TException> onException) { }

}

// Namespace: 
private struct <<Invoke>g__Retry|0>d 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public UnityEngine.Purchasing.ExponentialRetryPolicy.<>c__DisplayClass4_0 <>4__this; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x15BA80C
	void MoveNext() { }

	// RVA: 0x15BA9E0
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private struct <<Invoke>g__WaitAndRetry|1>d 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncTaskMethodBuilder <>t__builder; // 0x18
	public UnityEngine.Purchasing.ExponentialRetryPolicy.<>c__DisplayClass4_0 <>4__this; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x15BA9EC
	void MoveNext() { }

	// RVA: 0x15BAD2C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public Action onRetryAction; // 0x10
	public int currentRetryDelay; // 0x18
	public ExponentialRetryPolicy <>4__this; // 0x20
	public System.Action<System.Action> actionToTry; // 0x28

	// Methods

	// RVA: 0x15BA5F4
	void .ctor() { }

	// RVA: 0x15BA66C
	void <Invoke>g__Retry|0() { }

	// RVA: 0x15BA724
	Task <Invoke>g__WaitAndRetry|1() { }

}

// Namespace: UnityEngine.Purchasing
internal class ExponentialRetryPolicy 
{
	// Fields
	private readonly int m_BaseRetryDelay; // 0x10
	private readonly int m_MaxRetryDelay; // 0x14
	private readonly int m_ExponentialFactor; // 0x18

	// Methods

	// RVA: 0x15BA4A4
	void .ctor(int baseRetryDelay, int maxRetryDelay, int exponentialFactor) { }

	// RVA: 0x15BA4E4
	void Invoke(System.Action<System.Action> actionToTry, Action onRetryAction) { }

	// RVA: 0x15BA5FC
	int AdjustDelay(int delay) { }

}

// Namespace: 
private struct <<Invoke>g__WaitAndRetry|0>d 
{
	// Fields
	public int <>1__state; // 0x10
	public AsyncVoidMethodBuilder <>t__builder; // 0x18
	public UnityEngine.Purchasing.GoogleConnectionRetryPolicy.<>c__DisplayClass4_0 <>4__this; // 0x38
	private TaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x15BB054
	void MoveNext() { }

	// RVA: 0x15BB36C
	void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public int currentRetryDelay; // 0x10
	public GoogleConnectionRetryPolicy <>4__this; // 0x18
	public System.Action<System.Action> actionToTry; // 0x20
	public Action onRetryAction; // 0x28
	public int retryAttempts; // 0x30

	// Methods

	// RVA: 0x15BAF24
	void .ctor() { }

	// RVA: 0x15BAF2C
	void <Invoke>g__WaitAndRetry|0() { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleConnectionRetryPolicy 
{
	// Fields
	private readonly int m_BaseRetryDelay; // 0x10
	private readonly int m_MaxRetryDelay; // 0x14
	private readonly int m_ExponentialFactor; // 0x18

	// Methods

	// RVA: 0x15BAD98
	void .ctor(int baseRetryDelay, int maxRetryDelay, int exponentialFactor) { }

	// RVA: 0x15BADD8
	void Invoke(System.Action<System.Action> actionToTry, Action onRetryAction) { }

	// RVA: 0x15BAFE4
	int AdjustDelay(int delay) { }

}

// Namespace: UnityEngine.Purchasing
internal static class ProductDefinitionExtensions 
{
	// Methods

	// RVA: 0x15BB378
	System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> DecodeJSON(System.Collections.Generic.List<System.Object> productsList, string storeName) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeMicrosoftExtensions 
{
	// Methods

	// RVA: 0x15BBD38
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public interface IMicrosoftConfiguration 
{}

// Namespace: UnityEngine.Purchasing
public interface IMicrosoftExtensions 
{}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.WinRTStore.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.Boolean> <>9__8_0; // 0x8
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Default.WinProductDescription> <>9__8_1; // 0x10

	// Methods

	// RVA: 0x15BC3B8
	void .cctor() { }

	// RVA: 0x15BC424
	void .ctor() { }

	// RVA: 0x15BC42C
	bool <RetrieveProducts>b__8_0(ProductDefinition def) { }

	// RVA: 0x15BC450
	WinProductDescription <RetrieveProducts>b__8_1(ProductDefinition def) { }

}

// Namespace: UnityEngine.Purchasing
internal class WinRTStore 
{
	// Fields
	private IWindowsIAP win8; // 0x10
	private IStoreCallback callback; // 0x18
	private readonly IUtil util; // 0x20
	private readonly ILogger logger; // 0x28
	private bool m_CanReceivePurchases; // 0x30

	// Methods

	// RVA: 0x15BBD40
	void .ctor(IWindowsIAP win8, IUtil util, ILogger logger) { }

	// RVA: 0x15BBDA4
	void Initialize(IStoreCallback biller) { }

	// RVA: 0x15BBDAC
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefs) { }

	// RVA: 0x15BC16C
	void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x15BC03C
	void init(int delay) { }

	// RVA: 0x15BC224
	void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x15BC2E4
	void restoreTransactions(bool pausing) { }

}

// Namespace: 
private sealed class <DelayedCoroutine>d__48 
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public int delay; // 0x20
	public UnityUtil <>4__this; // 0x28
	public IEnumerator coroutine; // 0x30

	// Methods

	// RVA: 0x15BCEF4
	void .ctor(int <>1__state) { }

	// RVA: 0x15BD750
	void System.IDisposable.Dispose() { }

	// RVA: 0x15BD754
	bool MoveNext() { }

	// RVA: 0x15BD820
	object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x15BD828
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x15BD868
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: UnityEngine.Purchasing.Extension
internal class UnityUtil 
{
	// Fields
	private static readonly System.Collections.Generic.List<System.Action> s_Callbacks; // 0x0
	private static bool s_CallbacksPending; // 0x8
	private static readonly System.Collections.Generic.List<UnityEngine.RuntimePlatform> s_PcControlledPlatforms; // 0x10
	private readonly System.Collections.Generic.List<System.Action<System.Boolean>> pauseListeners; // 0x20

	// Methods

	// RVA: 0x2FE360C
	T[] GetAnyComponentsOfType() { }

	// RVA: 0x15BC5CC
	DateTime get_currentTime() { }

	// RVA: 0x15BC63C
	string get_persistentDataPath() { }

	// RVA: 0x15BC6AC
	string get_deviceUniqueIdentifier() { }

	// RVA: 0x15BC6B4
	string get_unityVersion() { }

	// RVA: 0x15BC724
	string get_cloudProjectId() { }

	// RVA: 0x15BC794
	string get_userId() { }

	// RVA: 0x15BC804
	string get_gameVersion() { }

	// RVA: 0x15BC874
	UInt64 get_sessionId() { }

	// RVA: 0x15BC8E4
	RuntimePlatform get_platform() { }

	// RVA: 0x15BC954
	bool get_isEditor() { }

	// RVA: 0x15BC9C4
	string get_deviceModel() { }

	// RVA: 0x15BC9CC
	string get_deviceName() { }

	// RVA: 0x15BC9D4
	DeviceType get_deviceType() { }

	// RVA: 0x15BC9DC
	string get_operatingSystem() { }

	// RVA: 0x15BC9E4
	int get_screenWidth() { }

	// RVA: 0x15BC9EC
	int get_screenHeight() { }

	// RVA: 0x15BC9F4
	float get_screenDpi() { }

	// RVA: 0x15BC9FC
	string get_screenOrientation() { }

	// RVA: 0x15BCA68
	object Uniject.IUtil.InitiateCoroutine(IEnumerator start) { }

	// RVA: 0x15BCA70
	void Uniject.IUtil.InitiateCoroutine(IEnumerator start, int delay) { }

	// RVA: 0x15BCBA4
	void RunOnMainThread(Action runnable) { }

	// RVA: 0x15BCD0C
	object GetWaitForSeconds(int seconds) { }

	// RVA: 0x15BCD74
	void Start() { }

	// RVA: 0x309AF8C
	T FindInstanceOfType() { }

	// RVA: 0x309AF8C
	T LoadResourceInstanceOfType() { }

	// RVA: 0x15BCE00
	bool PcPlatform() { }

	// RVA: 0x15BCB08
	IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay) { }

	// RVA: 0x15BCF20
	void Update() { }

	// RVA: 0x15BD248
	void AddPauseListener(System.Action<System.Boolean> runnable) { }

	// RVA: 0x15BD2AC
	void OnApplicationPause(bool paused) { }

	// RVA: 0x15BD490
	bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant) { }

	// RVA: 0x15BD534
	void .ctor() { }

	// RVA: 0x15BD5C0
	void .cctor() { }

}

// Namespace: UnityEngine.Purchasing.Stores.Util
internal interface IRetryPolicy 
{
	// Methods

	// RVA: 0x2FE47D4
	void Invoke(System.Action<System.Action> actionToTry, Action onRetryAction) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0 
{
	// Fields
	public CoreRegistry registry; // 0x10
	public ITelemetryMetricsInstanceWrapper metricsInstanceWrapper; // 0x18
	public ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper; // 0x20

	// Methods

	// RVA: 0x15BDC28
	void .ctor() { }

	// RVA: 0x15BE134
	void <Initialize>b__0() { }

}

// Namespace: UnityEngine.Purchasing.Registration
internal class IapCoreInitializeCallback 
{
	// Methods

	// RVA: 0x15BD870
	void Register() { }

	// RVA: 0x15BD9B0
	Task Initialize(CoreRegistry registry) { }

	// RVA: 0x15BDC30
	void CacheInitializedEnvironment(CoreRegistry registry) { }

	// RVA: 0x15BDC68
	string GetCurrentEnvironment(CoreRegistry registry) { }

	// RVA: 0x15BDDD8
	void InitializeTelemetryComponents(ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper) { }

	// RVA: 0x15BD9A8
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails; // 0x10

	// Methods

	// RVA: 0x15BF334
	void .ctor() { }

	// RVA: 0x15BF33C
	AndroidJavaObject <TryFindAllProductDetails>b__0(string sku) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_1 
{
	// Fields
	public string sku; // 0x10

	// Methods

	// RVA: 0x15BF43C
	void .ctor() { }

	// RVA: 0x15BF444
	bool <TryFindAllProductDetails>b__1(AndroidJavaObject productDetail) { }

}

// Namespace: UnityEngine.Purchasing.Utils
internal class GooglePurchaseBuilder 
{
	// Fields
	private readonly IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService; // 0x10
	private readonly ILogger m_Logger; // 0x18

	// Methods

	// RVA: 0x15BE17C
	void .ctor(IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, ILogger logger) { }

	// RVA: 0x15BE1CC
	System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

	// RVA: 0x15BE2FC
	void LogWarningForException(Exception exception) { }

	// RVA: 0x15BE340
	IGooglePurchase BuildPurchase(AndroidJavaObject purchase) { }

	// RVA: 0x15BE870
	System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> TryFindAllProductDetails(System.Collections.Generic.IEnumerable<System.String> skus, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

}

// Namespace: UnityEngine.Purchasing.Utils
internal static class GoogleReceiptEncoder 
{
	// Methods

	// RVA: 0x15BF58C
	string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, System.Collections.Generic.List<System.String> productDetailsJson) { }

}

// Namespace: UnityEngine.Purchasing.Utils
internal class ProductDetailsConverter 
{
	// Methods

	// RVA: 0x15BF6B4
	System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

	// RVA: 0x15BF774
	ProductDescription ToProductDescription(AndroidJavaObject productDetails) { }

	// RVA: 0x15BF828
	ProductDescription BuildProductDescription(AndroidJavaObject productDetails) { }

	// RVA: 0x15C1528
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IBillingClientStateListener 
{
	// Methods

	// RVA: 0x2FE4574
	void RegisterOnConnected(Action onConnected) { }

	// RVA: 0x2FE4574
	void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleBillingClient 
{
	// Methods

	// RVA: 0x2FE4574
	void StartConnection(IBillingClientStateListener billingClientStateListener) { }

	// RVA: 0x2FE32D4
	GoogleBillingConnectionState GetConnectionState() { }

	// RVA: 0x2FE47D4
	void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse) { }

	// RVA: 0x2FE49A8
	void QueryProductDetailsAsync(System.Collections.Generic.List<System.String> skus, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction) { }

	// RVA: -1
	AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode) { }

	// RVA: 0x2FE47D4
	void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume) { }

	// RVA: 0x2FE47D4
	void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleFinishTransactionService 
{
	// Methods

	// RVA: 0x2FE49A8
	void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleLastKnownProductService 
{
	// Methods

	// RVA: 0x2FE360C
	string get_LastKnownOldProductId() { }

	// RVA: 0x2FE4574
	void set_LastKnownOldProductId(string value) { }

	// RVA: 0x2FE360C
	string get_LastKnownProductId() { }

	// RVA: 0x2FE4574
	void set_LastKnownProductId(string value) { }

	// RVA: -1
	System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode() { }

	// RVA: -1
	void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePlayStoreService 
{
	// Methods

	// RVA: 0x2FE49A8
	void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductFailed) { }

	// RVA: 0x2FE4574
	void Purchase(ProductDefinition product) { }

	// RVA: 0x2FE49A8
	void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

	// RVA: 0x2FE4574
	void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed) { }

	// RVA: 0x2FE37A0
	IGooglePurchase GetPurchase(string purchaseToken, string skuType) { }

	// RVA: 0x2FE41A8
	void ResumeConnection() { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleProductCallback 
{
	// Methods

	// RVA: 0x2FE4574
	void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: 0x2FE42A4
	void NotifyQueryProductDetailsFailed(int retryCount) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchase 
{
	// Methods

	// RVA: 0x2FE32D4
	int get_purchaseState() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.List<System.String> get_skus() { }

	// RVA: 0x2FE360C
	string get_receipt() { }

	// RVA: 0x2FE360C
	string get_purchaseToken() { }

	// RVA: 0x2FE360C
	string get_sku() { }

	// RVA: 0x2FE3054
	bool IsAcknowledged() { }

	// RVA: 0x2FE3054
	bool IsPurchased() { }

	// RVA: 0x2FE3054
	bool IsPending() { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseBuilder 
{
	// Methods

	// RVA: 0x2FE36BC
	System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

	// RVA: 0x2FE36BC
	IGooglePurchase BuildPurchase(AndroidJavaObject purchase) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseCallback 
{
	// Methods

	// RVA: 0x2FE4574
	void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x2FE4574
	void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: 0x2FE49A8
	void OnPurchaseSuccessful(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: 0x2FE4574
	void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription) { }

	// RVA: 0x2FE49A8
	void NotifyDeferredPurchase(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: 0x2FE4574
	void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseService 
{
	// Methods

	// RVA: -1
	void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseStateEnumProvider 
{
	// Methods

	// RVA: 0x2FE32D4
	int Purchased() { }

	// RVA: 0x2FE32D4
	int Pending() { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseUpdatedListener 
{}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleQueryPurchasesService 
{
	// Methods

	// RVA: 0x2FE360C
	System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases() { }

	// RVA: 0x2FE37A0
	IGooglePurchase GetPurchaseByToken(string token, string skuType) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IProductDetailsConverter 
{
	// Methods

	// RVA: 0x2FE36BC
	System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IProductDetailsResponseConsolidator 
{
	// Methods

	// RVA: 0x2FE47D4
	void Consolidate(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IQueryProductDetailsService 
{
	// Methods

	// RVA: 0x2FE47D4
	void QueryAsyncProduct(ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x2FE47D4
	void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IProductDetailsQueryResponse 
{
	// Methods

	// RVA: 0x2FE47D4
	void AddResponse(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails() { }

	// RVA: 0x2FE3054
	bool IsRecoverable() { }

	// RVA: 0x2FE360C
	IGoogleBillingResult GetGoogleBillingResult() { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0<T0> 
{
	// Fields
	public AndroidJavaObject androidJavaList; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	T <Enumerate>b__0(int i) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class AndroidJavaObjectExtensions 
{
	// Methods

	// RVA: 0x2FE7084
	System.Collections.Generic.IEnumerable<T> Enumerate(AndroidJavaObject androidJavaList) { }

	// RVA: 0x15C14D4
	System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> Enumerate(AndroidJavaObject androidJavaList) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal interface IGoogleBillingResult 
{
	// Methods

	// RVA: 0x2FE32D4
	GoogleBillingResponseCode get_responseCode() { }

	// RVA: 0x2FE360C
	string get_debugMessage() { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0 
{
	// Fields
	public string type; // 0x10

	// Methods

	// RVA: 0x15C2BB8
	void .ctor() { }

	// RVA: 0x15C4EEC
	AndroidJavaObject <QueryProductDetailsParamsProductList>b__0(string product) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal class GoogleBillingClient 
{
	// Fields
	private static AndroidJavaClass s_AndroidProductClassName; // 0x0
	private static AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName; // 0x8
	private static AndroidJavaClass s_BillingFlowParamsClass; // 0x10
	private static AndroidJavaClass s_ProductDetailsParamsClass; // 0x18
	private static AndroidJavaClass s_SubscriptionUpdateParamsClass; // 0x20
	private static AndroidJavaClass s_ConsumeParamsClass; // 0x28
	private static AndroidJavaClass s_AcknowledgePurchaseParamsClass; // 0x30
	private static AndroidJavaClass s_BillingClientClass; // 0x38
	private readonly AndroidJavaObject m_BillingClient; // 0x10
	private string m_ObfuscatedAccountId; // 0x18
	private string m_ObfuscatedProfileId; // 0x20
	private readonly IUtil m_Util; // 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

	// Methods

	// RVA: 0x15C1530
	AndroidJavaClass GetProductParamsClass() { }

	// RVA: 0x15C1604
	AndroidJavaClass GetQueryProductDetailsParamsParamsClass() { }

	// RVA: 0x15C16D0
	AndroidJavaClass GetBillingFlowParamClass() { }

	// RVA: 0x15C179C
	AndroidJavaClass GetProductDetailsParamsClass() { }

	// RVA: 0x15C1868
	AndroidJavaClass GetSubscriptionUpdateParamClass() { }

	// RVA: 0x15C1934
	AndroidJavaClass GetConsumeParamsClass() { }

	// RVA: 0x15C1A00
	AndroidJavaClass GetAcknowledgePurchaseParamsClass() { }

	// RVA: 0x15C1ACC
	AndroidJavaClass GetBillingClientClass() { }

	// RVA: 0x15C1B98
	void .ctor(IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x15C201C
	void StartConnection(IBillingClientStateListener billingClientStateListener) { }

	// RVA: 0x15C20F0
	GoogleBillingConnectionState GetConnectionState() { }

	// RVA: 0x15C2228
	void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse) { }

	// RVA: 0x15C2368
	void QueryProductDetailsAsync(System.Collections.Generic.List<System.String> products, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction) { }

	// RVA: 0x15C25E8
	AndroidJavaObject QueryProductDetailsParams(System.Collections.Generic.List<System.String> products, string type) { }

	// RVA: 0x15C2A90
	AndroidJavaObject QueryProductDetailsParamsProductList(System.Collections.Generic.List<System.String> products, string type) { }

	// RVA: 0x15C2BC0
	AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product) { }

	// RVA: 0x15C3048
	AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode) { }

	// RVA: 0x15C3A3C
	AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode) { }

	// RVA: 0x15C4024
	AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayProrationMode prorationMode) { }

	// RVA: 0x15C3F1C
	AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	// RVA: 0x15C3E14
	AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	// RVA: 0x15C4384
	void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume) { }

	// RVA: 0x15C4938
	void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal class GoogleBillingResult 
{
	// Fields
	private readonly GoogleBillingResponseCode <responseCode>k__BackingField; // 0x10
	private readonly string <debugMessage>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15C4EF4
	GoogleBillingResponseCode get_responseCode() { }

	// RVA: 0x15C4EFC
	string get_debugMessage() { }

	// RVA: 0x15C4F04
	void .ctor(AndroidJavaObject billingResult) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class GoogleBillingStrings 
{
	// Methods

	// RVA: 0x15C50EC
	string getWarningMessageMoreThanOneSkuFound(string sku) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class GoogleProductTypeEnum 
{
	// Methods

	// RVA: 0x15C515C
	string InApp() { }

	// RVA: 0x15C51A0
	string Sub() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly UnityEngine.Purchasing.Models.GooglePurchase.<>c <>9; // 0x0
	public static System.Func<UnityEngine.AndroidJavaObject,System.String> <>9__32_0; // 0x8

	// Methods

	// RVA: 0x15C5804
	void .cctor() { }

	// RVA: 0x15C5870
	void .ctor() { }

	// RVA: 0x15C5878
	string <.ctor>b__32_0(AndroidJavaObject productDetails) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal class GooglePurchase 
{
	// Fields
	private readonly bool <isAcknowledged>k__BackingField; // 0x10
	private readonly int <purchaseState>k__BackingField; // 0x14
	private readonly System.Collections.Generic.List<System.String> <skus>k__BackingField; // 0x18
	private readonly string <orderId>k__BackingField; // 0x20
	private readonly string <receipt>k__BackingField; // 0x28
	private readonly string <signature>k__BackingField; // 0x30
	private readonly string <originalJson>k__BackingField; // 0x38
	private readonly string <purchaseToken>k__BackingField; // 0x40
	private readonly string <obfuscatedAccountId>k__BackingField; // 0x48
	private readonly string <obfuscatedProfileId>k__BackingField; // 0x50

	// Methods

	// RVA: 0x15C51E4
	bool get_isAcknowledged() { }

	// RVA: 0x15C51EC
	int get_purchaseState() { }

	// RVA: 0x15C51F4
	System.Collections.Generic.List<System.String> get_skus() { }

	// RVA: 0x15C51FC
	string get_receipt() { }

	// RVA: 0x15C5204
	string get_signature() { }

	// RVA: 0x15C520C
	string get_originalJson() { }

	// RVA: 0x15C5214
	string get_purchaseToken() { }

	// RVA: 0x15C521C
	string get_sku() { }

	// RVA: 0x15BE958
	void .ctor(AndroidJavaObject purchase, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetailsEnum) { }

	// RVA: 0x15C5284
	bool IsAcknowledged() { }

	// RVA: 0x15C528C
	bool IsPurchased() { }

	// RVA: 0x15C5544
	bool IsPending() { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class GooglePurchaseStateEnum 
{
	// Fields
	private static System.Nullable<System.Int32> s_Purchased; // 0x0
	private static System.Nullable<System.Int32> s_Pending; // 0x8

	// Methods

	// RVA: 0x15C58AC
	AndroidJavaObject GetPurchaseStateJavaObject() { }

	// RVA: 0x15C52B4
	int Purchased() { }

	// RVA: 0x15C556C
	int Pending() { }

}

// Namespace: UnityEngine.Purchasing.Models
internal class GooglePurchaseStateEnumProvider 
{
	// Methods

	// RVA: 0x15C5924
	int Purchased() { }

	// RVA: 0x15C5928
	int Pending() { }

	// RVA: 0x15C592C
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Models
internal enum GoogleRetrieveProductsFailureReason 
{
	// Fields
	public int value__; // 0x10
	public const GoogleRetrieveProductsFailureReason BillingServiceDisconnected = 0;
	public const GoogleRetrieveProductsFailureReason BillingServiceUnavailable = 1;
}

// Namespace: UnityEngine.Purchasing.Models
internal class ProductDescriptionQuery 
{
	// Fields
	internal System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x10
	internal System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived; // 0x18
	internal System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed; // 0x20

	// Methods

	// RVA: 0x15C5934
	void .ctor(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal enum GoogleBillingResponseCode 
{
	// Fields
	public int value__; // 0x10
	public const GoogleBillingResponseCode ServiceTimeout = 4294967293;
	public const GoogleBillingResponseCode FeatureNotSupported = 4294967294;
	public const GoogleBillingResponseCode ServiceDisconnected = 4294967295;
	public const GoogleBillingResponseCode Ok = 0;
	public const GoogleBillingResponseCode UserCanceled = 1;
	public const GoogleBillingResponseCode ServiceUnavailable = 2;
	public const GoogleBillingResponseCode BillingUnavailable = 3;
	public const GoogleBillingResponseCode ItemUnavailable = 4;
	public const GoogleBillingResponseCode DeveloperError = 5;
	public const GoogleBillingResponseCode FatalError = 6;
	public const GoogleBillingResponseCode ItemAlreadyOwned = 7;
	public const GoogleBillingResponseCode ItemNotOwned = 8;
	public const GoogleBillingResponseCode NetworkError = 12;
}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Methods

	// RVA: 0x15C5998
	UInt32 ComputeStringHash(string s) { }

}


