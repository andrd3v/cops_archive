// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x1686A28
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1686A30
	public void .ctor(Byte ) { }

	// RVA: 0x1686ABC
	public void .ctor(Byte[] ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x1686AF0
	public void .ctor(Byte ) { }

}

// Namespace: Stores.Util
internal class JsonProductDescriptionsDeserializer
{
	// Methods

	// RVA: 0x1686B1C
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> DeserializeProductDescriptions(string json) { }

	// RVA: 0x16870AC
	internal virtual ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

	// RVA: 0x168734C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class AmazonAppStoreStoreExtensions
{
	// Fields
	private readonly AndroidJavaObject android; // 0x10

	// Methods

	// RVA: 0x1687354
	public void .ctor(AndroidJavaObject a) { }

}

// Namespace: UnityEngine.Purchasing
public class FakeAmazonExtensions
{
	// Methods

	// RVA: 0x1687388
	public void .ctor() { }

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

	// RVA: 0x1687390
	public void .ctor(AndroidJavaObject store) { }

	// RVA: 0x16873C4
	public void RetrieveProducts(string json) { }

	// RVA: 0x1687498
	public virtual void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x16875AC
	public virtual void FinishTransaction(string productJSON, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
internal static class ListExtension
{
	// Methods

	// RVA: 0x30B57C8
	internal static AndroidJavaObject ToJava(System.Collections.Generic.List<T> values) { }

	// RVA: 0x30B57C8
	private static AndroidJavaObject ToJavaArray(System.Collections.Generic.List<T> values) { }

}

// Namespace: UnityEngine.Purchasing
internal class UnityActivity
{
	// Fields
	private static AndroidJavaClass s_UnityPlayerClass; // 0x0

	// Methods

	// RVA: 0x16876C0
	private static AndroidJavaClass GetUnityPlayerClass() { }

	// RVA: 0x1687794
	internal static AndroidJavaObject GetCurrentActivity() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.GoogleCachedQueryProductDetailsService.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.String> <>9__5_0; // 0x8

	// Methods

	// RVA: 0x1688358
	private static void .cctor() { }

	// RVA: 0x16883C4
	public void .ctor() { }

	// RVA: 0x16883CC
	internal string <GetCachedQueriedProductDetails>b__5_0(ProductDefinition product) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleCachedQueryProductDetailsService
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.AndroidJavaObject> m_CachedQueriedProductDetails; // 0x10

	// Methods

	// RVA: 0x1687810
	protected override void Finalize() { }

	// RVA: 0x1687AF4
	public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts() { }

	// RVA: 0x1687B48
	private AndroidJavaObject GetCachedQueriedProductDetails(string productId) { }

	// RVA: 0x1687BC0
	private System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<System.String> productIds) { }

	// RVA: 0x1687C68
	public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1687E1C
	private bool Contains(string productId) { }

	// RVA: 0x1687E80
	public bool Contains(ProductDefinition products) { }

	// RVA: 0x1687EE8
	public void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts) { }

	// RVA: 0x16882CC
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public string purchaseToken; // 0x10

	// Methods

	// RVA: 0x1688928
	public void .ctor() { }

	// RVA: 0x1688930
	internal bool <FindPurchase>b__0(IGooglePurchase purchase) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished; // 0x10
	public IGooglePurchase purchase; // 0x18

	// Methods

	// RVA: 0x1688920
	public void .ctor() { }

	// RVA: 0x16889EC
	internal void <FinishTransactionForPurchase>b__0(IGoogleBillingResult result) { }

	// RVA: 0x1688A18
	internal void <FinishTransactionForPurchase>b__1(IGoogleBillingResult result) { }

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

	// RVA: 0x1688A44
	private void MoveNext() { }

	// RVA: 0x1688E68
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1688EE8
	private void MoveNext() { }

	// RVA: 0x16892A8
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleFinishTransactionService
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGoogleQueryPurchasesService m_GoogleQueryPurchasesService; // 0x18

	// Methods

	// RVA: 0x16883E8
	internal void .ctor(IGoogleBillingClient billingClient, IGoogleQueryPurchasesService googleQueryPurchasesService) { }

	// RVA: 0x1688438
	public void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

	// RVA: 0x168854C
	private System.Threading.Tasks.Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase> FindPurchase(string purchaseToken) { }

	// RVA: 0x1688678
	private void FinishTransactionForPurchase(IGooglePurchase purchase, ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleLastKnownProductService
{
	// Fields
	private string <LastKnownOldProductId>k__BackingField; // 0x10
	private string <LastKnownProductId>k__BackingField; // 0x18
	private System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> <LastKnownProrationMode>k__BackingField; // 0x20

	// Methods

	// RVA: 0x16892B4
	public string get_LastKnownOldProductId() { }

	// RVA: 0x16892BC
	public void set_LastKnownOldProductId(string value) { }

	// RVA: 0x16892C4
	public string get_LastKnownProductId() { }

	// RVA: 0x16892CC
	public void set_LastKnownProductId(string value) { }

	// RVA: 0x16892D4
	public System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode() { }

	// RVA: 0x16892DC
	public void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value) { }

	// RVA: 0x16892E4
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public GooglePlayStoreService <>4__this; // 0x10
	public Action ActionToRetry; // 0x18

	// Methods

	// RVA: 0x1689BA4
	public void .ctor() { }

	// RVA: 0x168AD50
	internal void <RetryConnection>b__0() { }

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

	// RVA: 0x168AD74
	private void MoveNext() { }

	// RVA: 0x168B034
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x168B040
	private void MoveNext() { }

	// RVA: 0x168B434
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x1689364
	internal void .ctor(IGoogleBillingClient billingClient, IQueryProductDetailsService queryProductDetailsService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionService finishTransactionService, IGoogleQueryPurchasesService queryPurchasesService, IBillingClientStateListener billingClientStateListener, IGoogleLastKnownProductService lastKnownProductService, ITelemetryDiagnostics telemetryDiagnostics, ILogger logger, IRetryPolicy retryPolicy, IUtil util) { }

	// RVA: 0x1689554
	internal void InitConnectionWithGooglePlay() { }

	// RVA: 0x1689798
	private void StartConnection() { }

	// RVA: 0x1689864
	public void ResumeConnection() { }

	// RVA: 0x1689930
	private void AttemptReconnection() { }

	// RVA: 0x1689A44
	private bool AreConnectionAttemptsExhausted() { }

	// RVA: 0x1689A54
	private void RetryConnection(Action ActionToRetry) { }

	// RVA: 0x1689BAC
	private void RetryConnectionAttempt(Action ActionToRetry) { }

	// RVA: 0x1689D44
	private void OnConnected() { }

	// RVA: 0x1689D80
	protected virtual void DequeueQueryProducts(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x168A2E8
	protected virtual void DequeueFetchPurchases() { }

	// RVA: 0x168A4E4
	private void OnDisconnected(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x168A510
	public virtual void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x168A690
	private void HandleRetrieveProductsNotConnected(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x168A81C
	public void Purchase(ProductDefinition product) { }

	// RVA: 0x168A834
	public virtual void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x168AAB8
	public void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

	// RVA: 0x168A410
	public void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed) { }

	// RVA: 0x168AB84
	private Task TryFetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed) { }

	// RVA: 0x168AC8C
	public IGooglePurchase GetPurchase(string purchaseToken, string skuType) { }

	// RVA: 0x168AD4C
	private void <AttemptReconnection>b__19_0(Action retryAction) { }

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

	// RVA: 0x168B680
	public void .ctor() { }

	// RVA: 0x168C0F4
	internal void <Purchase>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, IGoogleBillingResult _) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePurchaseService
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x18
	private readonly IQueryProductDetailsService m_QueryProductDetailsService; // 0x20

	// Methods

	// RVA: 0x168B4A0
	internal void .ctor(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQueryProductDetailsService queryProductDetailsService) { }

	// RVA: 0x168B504
	public void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x168B688
	private void OnQueryProductDetailsResponse(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, ProductDefinition productToBuy, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x168B73C
	private bool ValidateQueryProductDetailsResponseParams(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, ProductDefinition productToBuy, Product oldProduct) { }

	// RVA: 0x168B968
	private bool ValidateSkus(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus) { }

	// RVA: 0x168BC74
	private static void VerifyAndWarnIfMoreThanOneSku(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus) { }

	// RVA: 0x168B9CC
	private void PurchaseFailedSkuNotFound(ProductDefinition productToBuy) { }

	// RVA: 0x168BAD4
	private bool ValidateOldProduct(Product oldProduct) { }

	// RVA: 0x168BB40
	private void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, Product oldProduct) { }

	// RVA: 0x168B850
	private void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x168BE14
	private void HandleBillingFlowResult(IGoogleBillingResult billingResult, AndroidJavaObject sku) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.GoogleQueryPurchasesService.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>,System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x168C780
	private static void .cctor() { }

	// RVA: 0x168C7EC
	public void .ctor() { }

	// RVA: 0x168C7F4
	internal System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <QueryPurchases>b__3_0(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> result) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public GoogleQueryPurchasesService <>4__this; // 0x10
	public System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> taskCompletion; // 0x18

	// Methods

	// RVA: 0x168C4C8
	public void .ctor() { }

	// RVA: 0x168C7FC
	internal void <QueryPurchasesWithSkuType>b__0(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

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

	// RVA: 0x168C6CC
	public void .ctor() { }

	// RVA: 0x168CA34
	internal void <GetPurchaseByToken>b__0(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

	// RVA: 0x168CC68
	internal bool <GetPurchaseByToken>b__1(AndroidJavaObject purchase) { }

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

	// RVA: 0x168CDA8
	private void MoveNext() { }

	// RVA: 0x168D284
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleQueryPurchasesService
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGooglePurchaseBuilder m_PurchaseBuilder; // 0x18

	// Methods

	// RVA: 0x168C1A8
	internal void .ctor(IGoogleBillingClient billingClient, IGooglePurchaseBuilder purchaseBuilder) { }

	// RVA: 0x168C1F8
	public System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases() { }

	// RVA: 0x168C310
	private System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchasesWithSkuType(string skuType) { }

	// RVA: 0x168C4D0
	public IGooglePurchase GetPurchaseByToken(string purchaseToken, string skuType) { }

	// RVA: 0x168C6D4
	private static bool IsResultOk(IGoogleBillingResult result) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGoogleCachedQueryProductDetailsService
{
	// Methods

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts() { }

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: -1
	public abstract bool Contains(ProductDefinition products) { }

	// RVA: -1
	public abstract void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts) { }

}

// Namespace: UnityEngine.Purchasing
internal class BillingClientStateListener
{
	// Fields
	private Action m_OnConnected; // 0x20
	private System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> m_Disconnect; // 0x28

	// Methods

	// RVA: 0x168D304
	internal void .ctor() { }

	// RVA: 0x168D380
	public void RegisterOnConnected(Action onConnected) { }

	// RVA: 0x168D388
	public void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected) { }

	// RVA: 0x168D390
	public void onBillingSetupFinished(AndroidJavaObject billingResult) { }

	// RVA: 0x168D538
	public void onBillingServiceDisconnected() { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleAcknowledgePurchaseListener
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse; // 0x20

	// Methods

	// RVA: 0x168D578
	internal void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledgePurchaseResponseAction) { }

	// RVA: 0x168D608
	private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleConsumeResponseListener
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse; // 0x20

	// Methods

	// RVA: 0x168D69C
	internal void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsumeResponseAction) { }

	// RVA: 0x168D72C
	private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePurchasesResponseListener
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> m_OnQueryPurchasesResponse; // 0x20

	// Methods

	// RVA: 0x168D7C0
	internal void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse) { }

	// RVA: 0x168D850
	public void onQueryPurchasesResponse(AndroidJavaObject billingResult, AndroidJavaObject purchases) { }

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

	// RVA: 0x1690448
	private void MoveNext() { }

	// RVA: 0x16906E0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x168DABC
	internal void .ctor(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePurchaseBuilder purchaseBuilder, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, IGoogleQueryPurchasesService googleQueryPurchasesService) { }

	// RVA: 0x168DBC8
	public void SetGoogleQueryPurchaseService(IGoogleQueryPurchasesService googleFetchPurchases) { }

	// RVA: 0x168DBD0
	public void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList) { }

	// RVA: 0x168DEC0
	internal void OnPurchasesUpdated(IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x168E158
	private void HandleResultOkCases(IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x168E480
	private void HandleErrorCases(IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x168E558
	private void HandleErrorGoogleBillingResult(IGoogleBillingResult billingResult) { }

	// RVA: 0x168EFC4
	private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult) { }

	// RVA: 0x168F098
	private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases) { }

	// RVA: 0x168E230
	private void ApplyOnPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase> action) { }

	// RVA: 0x168EC5C
	private void ApplyOnPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, IGoogleBillingResult billingResult, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.String> action) { }

	// RVA: 0x168F200
	private void OnPurchaseOk(IGooglePurchase googlePurchase) { }

	// RVA: 0x168F8B4
	private void HandlePurchasedProduct(IGooglePurchase googlePurchase) { }

	// RVA: 0x168FB6C
	private bool IsDeferredSubscriptionChange(IGooglePurchase googlePurchase) { }

	// RVA: 0x168FCD0
	private bool IsLastProrationModeDeferred() { }

	// RVA: 0x168F6BC
	private void OnPurchaseCancelled(IGoogleBillingResult billingResult) { }

	// RVA: 0x168FE74
	private void OnPurchaseCancelled(IGooglePurchase googlePurchase) { }

	// RVA: 0x168FFF4
	private void OnPurchaseAlreadyOwned(IGooglePurchase googlePurchase) { }

	// RVA: 0x1690174
	private void OnPurchaseFailed(IGooglePurchase googlePurchase, string debugMessage) { }

	// RVA: 0x169030C
	private bool <HandleUserCancelledPurchaseFailure>b__15_0(IGooglePurchase purchase) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public AndroidJavaObject productDetails; // 0x10
	public ProductDetailsResponseListener <>4__this; // 0x18
	public AndroidJavaObject billingResult; // 0x20

	// Methods

	// RVA: 0x1690910
	public void .ctor() { }

	// RVA: 0x1690918
	internal void <onProductDetailsResponse>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductDetailsResponseListener
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> m_OnProductDetailsResponse; // 0x20
	private readonly IUtil m_Util; // 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

	// Methods

	// RVA: 0x16906EC
	internal void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x16907AC
	public void onProductDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject productDetails) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public MetricizedGooglePlayStoreService <>4__this; // 0x10
	public GoogleBillingResponseCode googleBillingResponseCode; // 0x18

	// Methods

	// RVA: 0x1690E50
	public void .ctor() { }

	// RVA: 0x1691304
	internal void <DequeueQueryProducts>b__0() { }

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

	// RVA: 0x1691140
	public void .ctor() { }

	// RVA: 0x1691328
	internal void <RetrieveProducts>b__0() { }

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

	// RVA: 0x16912F0
	public void .ctor() { }

	// RVA: 0x1691350
	internal void <Purchase>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedGooglePlayStoreService
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x80
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x88

	// Methods

	// RVA: 0x1690C74
	internal void .ctor(IGoogleBillingClient billingClient, IQueryProductDetailsService queryProductDetailsService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionService finishTransactionService, IGoogleQueryPurchasesService queryPurchasesService, IBillingClientStateListener billingClientStateListener, IGoogleLastKnownProductService lastKnownProductService, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService, ILogger logger, IRetryPolicy retryPolicy, IUtil util) { }

	// RVA: 0x1690CD8
	protected override void DequeueQueryProducts(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x1690E58
	protected override void DequeueFetchPurchases() { }

	// RVA: 0x1690F8C
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x1691148
	public override void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x16912F8
	private void <>n__0(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x16912FC
	private void <>n__1(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x1691300
	private void <>n__2(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

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
[Serializable]
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

	// RVA: 0x1692198
	private static void .cctor() { }

	// RVA: 0x1692204
	public void .ctor() { }

	// RVA: 0x169220C
	internal AndroidJavaObject <AddResponse>b__2_0(AndroidJavaObject product) { }

	// RVA: 0x1692228
	internal bool <ProductDetails>b__3_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x16922D4
	internal System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> <ProductDetails>b__3_1(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x16922DC
	internal IGoogleBillingResult <IsRecoverable>b__4_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x16922E4
	internal IGoogleBillingResult <GetGoogleBillingResult>b__5_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x16922EC
	internal bool <GetGoogleBillingResult>b__5_1(IGoogleBillingResult response) { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductDetailsQueryResponse
{
	// Fields
	private readonly System.Collections.Concurrent.ConcurrentBag<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>> m_Responses; // 0x10

	// Methods

	// RVA: 0x1691378
	protected override void Finalize() { }

	// RVA: 0x16918A4
	public void AddResponse(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

	// RVA: 0x1691A4C
	public System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails() { }

	// RVA: 0x1691C50
	public bool IsRecoverable() { }

	// RVA: 0x1691DCC
	public IGoogleBillingResult GetGoogleBillingResult() { }

	// RVA: 0x1691FE0
	private static bool IsRecoverable(IGoogleBillingResult billingResult) { }

	// RVA: 0x169210C
	public void .ctor() { }

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

	// RVA: 0x1692398
	internal void .ctor(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> onProductDetailsResponseConsolidated) { }

	// RVA: 0x16924C0
	public void Consolidate(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

}

// Namespace: 
[Serializable]
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

	// RVA: 0x16938A0
	private static void .cctor() { }

	// RVA: 0x169390C
	public void .ctor() { }

	// RVA: 0x1693914
	internal bool <AreAllProductDetailsCached>b__14_0(bool isCached) { }

	// RVA: 0x169391C
	internal bool <QueryInAppsAsync>b__16_0(ProductDefinition product) { }

	// RVA: 0x1693940
	internal string <QueryInAppsAsync>b__16_1(ProductDefinition product) { }

	// RVA: 0x169395C
	internal bool <QuerySubsAsync>b__17_0(ProductDefinition product) { }

	// RVA: 0x1693980
	internal string <QuerySubsAsync>b__17_1(ProductDefinition product) { }

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

	// RVA: 0x1692AC8
	public void .ctor() { }

	// RVA: 0x169399C
	internal void <QueryAsyncProduct>b__0(Action retryAction) { }

	// RVA: 0x16939C4
	internal void <QueryAsyncProduct>g__OnActionRetry|1() { }

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

	// RVA: 0x1692D5C
	public void .ctor() { }

	// RVA: 0x1693A8C
	internal void <TryQueryAsyncProductWithRetries>b__0(IProductDetailsQueryResponse productDetailsQueryResponse) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse; // 0x10
	public QueryProductDetailsService <>4__this; // 0x18

	// Methods

	// RVA: 0x1692AC0
	public void .ctor() { }

	// RVA: 0x1693D7C
	internal void <QueryAsyncProduct>b__0(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetails, IGoogleBillingResult responseCode) { }

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

	// RVA: 0x1692684
	internal void .ctor(IGoogleBillingClient billingClient, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IProductDetailsConverter productDetailsConverter, IRetryPolicy retryPolicy, IGoogleProductCallback googleProductCallback, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x1692748
	public void QueryAsyncProduct(ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x16929D8
	public void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x1692824
	public void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x1692AD0
	private void QueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, Action retryQuery) { }

	// RVA: 0x1692BF8
	private void TryQueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, Action retryQuery) { }

	// RVA: 0x16931BC
	private bool ShouldRetryQuery(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> requestedProducts, IProductDetailsQueryResponse queryResponse) { }

	// RVA: 0x16932A8
	private bool AreAllProductDetailsCached(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1693494
	private System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1692D64
	private void QueryInAppsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, IProductDetailsResponseConsolidator consolidator) { }

	// RVA: 0x1692F90
	private void QuerySubsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, IProductDetailsResponseConsolidator consolidator) { }

	// RVA: 0x169362C
	private void QueryProductDetails(System.Collections.Generic.List<System.String> productList, string type, IProductDetailsResponseConsolidator consolidator) { }

}

// Namespace: UnityEngine.Purchasing
public class FakeGooglePlayStoreConfiguration
{
	// Methods

	// RVA: 0x1693E6C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class FakeGooglePlayStoreExtensions
{
	// Methods

	// RVA: 0x1693E74
	public bool IsPurchasedProductDeferred(Product product) { }

	// RVA: 0x1693E7C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public static class GetGoogleProductMetadataExtension
{
	// Methods

	// RVA: 0x1693E84
	public static GoogleProductMetadata GetGoogleProductMetadata(ProductMetadata productMetadata) { }

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

	// RVA: 0x1693F08
	public void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x1693F44
	public void NotifyInitializationConnectionFailed() { }

	// RVA: 0x1693F60
	public void NotifyQueryProductDetailsFailed(int retryCount) { }

	// RVA: 0x1693F98
	public void NotifyDeferredProrationUpgradeDowngradeSubscription(IStoreCallback storeCallback, string productId) { }

	// RVA: 0x16941BC
	public bool IsFetchPurchasesAtInitializeSkipped() { }

	// RVA: 0x16941CC
	public bool DoesRetrievePurchasesExcludeDeferred() { }

	// RVA: 0x16941D4
	public void NotifyDeferredPurchase(IStoreCallback storeCallback, IGooglePurchase purchase, string receipt, string transactionId) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayProductCallback
{
	// Fields
	private IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x10

	// Methods

	// RVA: 0x1694324
	public void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: 0x169432C
	public void NotifyQueryProductDetailsFailed(int retryCount) { }

	// RVA: 0x16943F0
	public void .ctor() { }

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

	// RVA: 0x1694814
	public void .ctor() { }

	// RVA: 0x1694974
	internal void <NotifyDeferredPurchase>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public GooglePlayPurchaseCallback <>4__this; // 0x10
	public string sku; // 0x18

	// Methods

	// RVA: 0x169496C
	public void .ctor() { }

	// RVA: 0x1694A64
	internal void <NotifyDeferredProrationUpgradeDowngradeSubscription>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayPurchaseCallback
{
	// Fields
	private IStoreCallback m_StoreCallback; // 0x10
	private IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x18
	private readonly IUtil m_Util; // 0x20

	// Methods

	// RVA: 0x16943F8
	public void .ctor(IUtil util) { }

	// RVA: 0x169442C
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x1694434
	public void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: 0x169443C
	public void OnPurchaseSuccessful(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: 0x16945D0
	public void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription) { }

	// RVA: 0x1694694
	public void NotifyDeferredPurchase(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: 0x169481C
	public void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku) { }

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

	// RVA: 0x1694B3C
	public void .ctor(IGooglePlayStoreRetrieveProductsService retrieveProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGoogleFetchPurchases fetchPurchases, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePlayConfigurationInternal googlePlayConfigurationInternal, IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, IUtil util) { }

	// RVA: 0x1694C1C
	public override void Initialize(IStoreCallback callback) { }

	// RVA: 0x1694FA8
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x16951E4
	private bool HasInitiallyRetrievedProducts() { }

	// RVA: 0x1695070
	private bool ShouldFetchPurchasesNext() { }

	// RVA: 0x169529C
	public override void Purchase(ProductDefinition product, string dummy) { }

	// RVA: 0x1695350
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x1695410
	public void OnPause(bool isPaused) { }

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

	// RVA: 0x1695574
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x16955F4
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x16955FC
	public bool IsPurchasedProductDeferred(Product product) { }

	// RVA: 0x1695778
	private bool TryIsPurchasedProductDeferred(Product product) { }

	// RVA: 0x1695798
	public GooglePurchaseState GetPurchaseState(Product product) { }

	// RVA: 0x16959C0
	private IGooglePurchase GooglePurchaseFromProduct(Product product) { }

}

// Namespace: UnityEngine.Purchasing
public interface IGooglePlayConfiguration
{}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayConfigurationInternal
{
	// Methods

	// RVA: -1
	public abstract void NotifyInitializationConnectionFailed() { }

	// RVA: -1
	public abstract void NotifyDeferredPurchase(IStoreCallback storeCallback, IGooglePurchase purchase, string receipt, string transactionId) { }

	// RVA: -1
	public abstract void NotifyDeferredProrationUpgradeDowngradeSubscription(IStoreCallback storeCallback, string productId) { }

	// RVA: -1
	public abstract bool IsFetchPurchasesAtInitializeSkipped() { }

	// RVA: -1
	public abstract bool DoesRetrievePurchasesExcludeDeferred() { }

	// RVA: -1
	public abstract void NotifyQueryProductDetailsFailed(int retryCount) { }

}

// Namespace: UnityEngine.Purchasing
public interface IGooglePlayStoreExtensions
{
	// Methods

	// RVA: -1
	public abstract bool IsPurchasedProductDeferred(Product product) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreExtensionsInternal
{
	// Methods

	// RVA: -1
	public abstract void SetStoreCallback(IStoreCallback storeCallback) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGoogleFetchPurchases
{
	// Methods

	// RVA: -1
	public abstract void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: -1
	public abstract void FetchPurchases() { }

	// RVA: -1
	public abstract void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreFinishTransactionService
{
	// Methods

	// RVA: -1
	public abstract void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: -1
	public abstract void FinishTransaction(ProductDefinition product, string purchaseToken) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStorePurchaseService
{
	// Methods

	// RVA: -1
	public abstract void Purchase(ProductDefinition product) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IGooglePlayStoreRetrieveProductsService
{
	// Methods

	// RVA: -1
	public abstract void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: -1
	public abstract void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases) { }

	// RVA: -1
	public abstract void ResumeConnection() { }

	// RVA: -1
	public abstract bool HasInitiallyRetrievedProducts() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedGooglePlayStoreExtensions
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x38

	// Methods

	// RVA: 0x1695AB0
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

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

	// RVA: 0x1695B44
	public string get_originalJson() { }

	// RVA: 0x1695B4C
	internal void set_originalJson(string value) { }

	// RVA: 0x1695B54
	internal void set_subscriptionPeriod(string value) { }

	// RVA: 0x1695B5C
	internal void set_freeTrialPeriod(string value) { }

	// RVA: 0x1695B64
	internal void set_introductoryPrice(string value) { }

	// RVA: 0x1695B6C
	internal void set_introductoryPricePeriod(string value) { }

	// RVA: 0x1695B74
	internal void set_introductoryPriceCycles(int value) { }

	// RVA: 0x1695B7C
	internal void .ctor(string priceString, string title, string description, string currencyCode, Decimal localizedPrice) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.GoogleFetchPurchases.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> <>9__11_0; // 0x8
	public static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> <>9__12_0; // 0x10

	// Methods

	// RVA: 0x1696C9C
	private static void .cctor() { }

	// RVA: 0x1696D08
	public void .ctor() { }

	// RVA: 0x1696D10
	internal bool <PurchaseIsPurchased>b__11_0(IGooglePurchase purchase) { }

	// RVA: 0x1696DC4
	internal bool <PurchaseIsPending>b__12_0(IGooglePurchase purchase) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public GoogleFetchPurchases <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases; // 0x18

	// Methods

	// RVA: 0x1696524
	public void .ctor() { }

	// RVA: 0x1696E78
	internal void <OnFetchedPurchase>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed; // 0x10
	public GoogleFetchPurchases <>4__this; // 0x18

	// Methods

	// RVA: 0x1695E24
	public void .ctor() { }

	// RVA: 0x1696E9C
	internal void <FetchPurchases>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public GoogleFetchPurchases <>4__this; // 0x10
	public IGooglePurchase purchase; // 0x18

	// Methods

	// RVA: 0x169611C
	public void .ctor() { }

	// RVA: 0x1696EE0
	internal Product <BuildProductsFromPurchase>b__0(string sku) { }

	// RVA: 0x1696F0C
	internal Product <BuildProductsFromPurchase>b__1(Product product) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleFetchPurchases
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
	private IStoreCallback m_StoreCallback; // 0x18
	private IUtil m_Util; // 0x20

	// Methods

	// RVA: 0x1695B84
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService, IUtil util) { }

	// RVA: 0x1695BD4
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x1695BDC
	public void FetchPurchases() { }

	// RVA: 0x1695CD4
	public void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed) { }

	// RVA: 0x1695E2C
	private System.Collections.Generic.List<UnityEngine.Purchasing.Product> FillProductsWithPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x1695EF8
	private System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> BuildProductsFromPurchase(IGooglePurchase purchase) { }

	// RVA: 0x1696124
	private static Product CompleteProductInfoWithPurchase(Product product, IGooglePurchase purchase) { }

	// RVA: 0x16962A8
	private void OnFetchedPurchase(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x169652C
	private static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> PurchaseIsPurchased() { }

	// RVA: 0x1696634
	private static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> PurchaseIsPending() { }

	// RVA: 0x169673C
	private void UpdateDeferredProductsByPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases) { }

	// RVA: 0x1696900
	private void UpdateDeferredProductsByPurchase(IGooglePurchase deferredPurchase) { }

	// RVA: 0x1696B44
	private void UpdateDeferredProduct(IGooglePurchase deferredPurchase, string sku) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public GooglePlayStoreFinishTransactionService <>4__this; // 0x10
	public ProductDefinition product; // 0x18

	// Methods

	// RVA: 0x1697138
	public void .ctor() { }

	// RVA: 0x1697A2C
	internal void <FinishTransaction>b__0(IGoogleBillingResult billingResult, IGooglePurchase googlePurchase) { }

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

	// RVA: 0x1696F1C
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x1696FC4
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x1696FCC
	public void FinishTransaction(ProductDefinition product, string purchaseToken) { }

	// RVA: 0x1697140
	private void HandleFinishTransaction(ProductDefinition product, IGoogleBillingResult billingResult, IGooglePurchase purchase) { }

	// RVA: 0x1697624
	private void CallPurchaseSucceededUpdateReceipt(IGooglePurchase googlePurchase) { }

	// RVA: 0x1697880
	private static bool IsResponseCodeInRecoverableState(IGoogleBillingResult billingResult) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStorePurchaseService
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10

	// Methods

	// RVA: 0x1697A58
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x1697A8C
	public void Purchase(ProductDefinition product) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public GooglePlayStoreRetrieveProductsService <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts; // 0x18

	// Methods

	// RVA: 0x1698038
	public void .ctor() { }

	// RVA: 0x1698B6C
	internal void <OnProductsRetrievedWithPurchaseFetch>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchaseProducts) { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Fields
	public Product purchaseProduct; // 0x10

	// Methods

	// RVA: 0x1698AA8
	public void .ctor() { }

	// RVA: 0x1698C54
	internal bool <MakePurchasesIntoProducts>b__0(ProductDescription product) { }

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

	// RVA: 0x1697B44
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService, IGoogleFetchPurchases googleFetchPurchases, IGooglePlayConfigurationInternal googlePlayConfigurationInternal, IGooglePlayStoreExtensions googlePlayStoreExtensions) { }

	// RVA: 0x1697BCC
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x1697BD4
	public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases) { }

	// RVA: 0x1697DC0
	private void OnProductsRetrievedWithPurchaseFetch(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, IGoogleBillingResult billingResult) { }

	// RVA: 0x1698220
	private void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, IGoogleBillingResult billingResult) { }

	// RVA: 0x1698040
	private void OnRetrieveProductsFailed(GoogleRetrieveProductsFailureReason reason, GoogleBillingResponseCode responseCode) { }

	// RVA: 0x1698404
	public void ResumeConnection() { }

	// RVA: 0x16984BC
	private System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> MakePurchasesIntoProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> purchaseProducts) { }

	// RVA: 0x1698AB0
	private bool IsPurchasedProductDeferred(Product product) { }

	// RVA: 0x1698B64
	public bool HasInitiallyRetrievedProducts() { }

}

// Namespace: UnityEngine.Purchasing
public static class StoreCallbackExtensionMethods
{
	// Methods

	// RVA: 0x1693FE8
	public static Product FindProductById(IStoreCallback storeCallback, string sku) { }

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

	// RVA: 0x1698C88
	public void .ctor(IUnityCallback forwardTo) { }

}

// Namespace: UnityEngine.Purchasing
internal static class SerializationExtensions
{
	// Methods

	// RVA: 0x1686FC8
	public static string TryGetString(System.Collections.Generic.Dictionary<System.String,System.Object> dic, string key) { }

}

// Namespace: UnityEngine.Purchasing
internal class JSONSerializer
{
	// Methods

	// RVA: 0x1698D18
	public static string SerializeProductDef(ProductDefinition product) { }

	// RVA: 0x16995D4
	public static string SerializeProductDefs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x16998FC
	public static string SerializeProductDescs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x1699E2C
	public static PurchaseFailureDescription DeserializeFailureReason(string json) { }

	// RVA: 0x169A1C4
	private static string BuildPurchaseFailureDescriptionMessage(System.Collections.Generic.Dictionary<System.String,System.Object> dic) { }

	// RVA: 0x1698D30
	private static System.Collections.Generic.Dictionary<System.String,System.Object> EncodeProductDef(ProductDefinition product) { }

	// RVA: 0x1699C24
	private static System.Collections.Generic.Dictionary<System.String,System.Object> EncodeProductDesc(ProductDescription product) { }

	// RVA: 0x169A290
	private static System.Collections.Generic.Dictionary<System.String,System.Object> EncodeProductMeta(ProductMetadata product) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public PurchaseFailureDescription desc; // 0x18

	// Methods

	// RVA: 0x169AC08
	public void .ctor() { }

	// RVA: 0x169AC10
	internal void <OnPurchaseFailed>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public InitializationFailureReason reason; // 0x18
	public string message; // 0x20

	// Methods

	// RVA: 0x169A678
	public void .ctor() { }

	// RVA: 0x169ACDC
	internal void <OnSetupFailed>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products; // 0x18

	// Methods

	// RVA: 0x169A7D0
	public void .ctor() { }

	// RVA: 0x169ADA4
	internal void <OnProductsRetrieved>b__0() { }

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

	// RVA: 0x169A958
	public void .ctor() { }

	// RVA: 0x169AE70
	internal void <OnPurchaseSucceeded>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts; // 0x18

	// Methods

	// RVA: 0x169AAB0
	public void .ctor() { }

	// RVA: 0x169AF3C
	internal void <OnAllPurchasesRetrieved>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class ScriptingStoreCallback
{
	// Fields
	private readonly IStoreCallback m_ForwardTo; // 0x10
	private readonly IUtil m_Util; // 0x18

	// Methods

	// RVA: 0x1694F58
	public void .ctor(IStoreCallback forwardTo, IUtil util) { }

	// RVA: 0x169A46C
	public ProductCollection get_products() { }

	// RVA: 0x169A520
	public void OnSetupFailed(InitializationFailureReason reason, string message) { }

	// RVA: 0x169A680
	public void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x169A7D8
	public void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	// RVA: 0x169A960
	public void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts) { }

	// RVA: 0x169AAB8
	public void OnPurchaseFailed(PurchaseFailureDescription desc) { }

}

// Namespace: UnityEngine.Purchasing
internal class ScriptingUnityCallback
{
	// Fields
	private readonly IUnityCallback forwardTo; // 0x10
	private readonly IUtil util; // 0x18

	// Methods

	// RVA: 0x169B008
	public void .ctor(IUnityCallback forwardTo, IUtil util) { }

}

// Namespace: UnityEngine.Purchasing
public class FakeUDPExtension
{
	// Methods

	// RVA: 0x169B058
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal interface INativeUDPStore
{
	// Methods

	// RVA: -1
	public abstract void Initialize(System.Action<System.Boolean,System.String> callback) { }

	// RVA: -1
	public abstract void Purchase(string productId, System.Action<System.Boolean,System.String> callback, string developerPayload) { }

	// RVA: -1
	public abstract void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Boolean,System.String> callback) { }

	// RVA: -1
	public abstract void FinishTransaction(ProductDefinition productDefinition, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
public interface IUDPExtensions
{}

// Namespace: UnityEngine.Purchasing
public class UDP
{
	// Methods

	// RVA: 0x169B060
	public static string get_Name() { }

}

// Namespace: UnityEngine.Purchasing
internal class UDPBindings
{
	// Fields
	private readonly object m_Bridge; // 0x10
	private System.Action<System.Boolean,System.String> m_RetrieveProductsCallbackCache; // 0x18

	// Methods

	// RVA: 0x169B36C
	public void .ctor() { }

	// RVA: 0x169B584
	public void Initialize(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x169B740
	public void Purchase(string productId, System.Action<System.Boolean,System.String> callback, string developerPayload) { }

	// RVA: 0x169B974
	public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x169BF00
	public void FinishTransaction(ProductDefinition productDefinition, string transactionID) { }

	// RVA: 0x169C0BC
	private void OnInventoryQueried(bool success, object payload) { }

	// RVA: 0x169D4A4
	public void RetrieveProducts(string json) { }

	// RVA: 0x169D4E4
	public void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x169D524
	public void FinishTransaction(string productJSON, string transactionID) { }

	// RVA: 0x169D2AC
	internal static System.Collections.Generic.Dictionary<System.String,System.String> StringPropertyToDictionary(object info) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public UDPImpl <>4__this; // 0x10
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x169D774
	public void .ctor() { }

	// RVA: 0x169DD78
	internal void <RetrieveProducts>g__retrieveCallback|0(bool success, string json) { }

	// RVA: 0x169DE34
	internal void <RetrieveProducts>b__1(bool success, string message) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public ProductDefinition product; // 0x10
	public UDPImpl <>4__this; // 0x18

	// Methods

	// RVA: 0x169D8E8
	public void .ctor() { }

	// RVA: 0x169E244
	internal void <Purchase>b__0(bool success, string message) { }

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

	// RVA: 0x169D564
	public void SetNativeStore(INativeUDPStore nativeUdpStore) { }

	// RVA: 0x169D56C
	public override void Initialize(IStoreCallback callback) { }

	// RVA: 0x169D574
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x169D77C
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x169D8F0
	private void OnPurchaseDeferred(string productId) { }

	// RVA: 0x169DA1C
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x169DAFC
	private static void DictionaryToStringProperty(System.Collections.Generic.Dictionary<System.String,System.Object> dic, object info) { }

	// RVA: 0x169DC78
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Assembly assembly; // 0x10

	// Methods

	// RVA: 0x169F15C
	public void .ctor() { }

	// RVA: 0x169F494
	internal bool <GetTypeByName>b__0(string x) { }

}

// Namespace: UnityEngine.Purchasing
internal class UDPReflectionUtils
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Reflection.Assembly,System.Type[]> s_assemblyTypeCache; // 0x0
	private static readonly System.Collections.Generic.Dictionary<System.String,System.Type> s_typeCache; // 0x8
	private static readonly string[] k_whiteListedAssemblies; // 0x10

	// Methods

	// RVA: 0x169E938
	internal static Type GetTypeByName(string typeName) { }

	// RVA: 0x169F138
	private static System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetAllAssemblies() { }

	// RVA: 0x169F164
	private static System.Collections.Generic.IEnumerable<System.Type> GetTypes(Assembly assembly) { }

	// RVA: 0x169F28C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class InventoryInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x169CE70
	internal static Type GetClassType() { }

	// RVA: 0x169CF94
	internal static MethodInfo GetProductListMethod() { }

	// RVA: 0x169D254
	internal static MethodInfo GetPurchaseInfoMethod() { }

	// RVA: 0x169D1FC
	internal static MethodInfo HasPurchaseMethod() { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductInfoInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x169F4D4
	private static Type GetClassType() { }

	// RVA: 0x169D0F4
	public static PropertyInfo GetCurrencyProp() { }

	// RVA: 0x169D09C
	public static PropertyInfo GetDescriptionProp() { }

	// RVA: 0x169CFEC
	public static PropertyInfo GetPriceProp() { }

	// RVA: 0x169D14C
	public static PropertyInfo GetPriceAmountMicrosProp() { }

	// RVA: 0x169D1A4
	public static PropertyInfo GetProductIdProp() { }

	// RVA: 0x169D044
	public static PropertyInfo GetTitleProp() { }

}

// Namespace: UnityEngine.Purchasing
internal class StoreServiceInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x169F5F8
	internal static Type GetClassType() { }

	// RVA: 0x169F71C
	private static PropertyInfo GetNameProp() { }

	// RVA: 0x169B2A0
	internal static string GetName() { }

}

// Namespace: UnityEngine.Purchasing
internal class UdpIapBridgeInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x169B460
	internal static Type GetClassType() { }

	// RVA: 0x169B6E8
	internal static MethodInfo GetInitMethod() { }

	// RVA: 0x169B91C
	internal static MethodInfo GetPurchaseMethod() { }

	// RVA: 0x169BEA8
	internal static MethodInfo GetRetrieveProductsMethod() { }

	// RVA: 0x169C064
	internal static MethodInfo GetFinishTransactionMethod() { }

}

// Namespace: UnityEngine.Purchasing
internal class UserInfoInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x169E120
	internal static Type GetClassType() { }

}

// Namespace: UnityEngine.Purchasing
internal class AppleJsonProductDescriptionsDeserializer
{
	// Methods

	// RVA: 0x169F77C
	internal override ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

	// RVA: 0x169F8DC
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class AppleProductMetadata
{
	// Fields
	private readonly bool <isFamilyShareable>k__BackingField; // 0x40

	// Methods

	// RVA: 0x169F85C
	internal void .ctor(ProductMetadata baseProductMetadata, string isFamilyShareable) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.AppleStoreImpl.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__39_1; // 0x8
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Object>,System.String> <>9__62_0; // 0x10
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Object>,System.String> <>9__62_1; // 0x18

	// Methods

	// RVA: 0x16A3AD4
	private static void .cctor() { }

	// RVA: 0x16A3B40
	public void .ctor() { }

	// RVA: 0x16A3B48
	internal int <FindMostRecentReceipt>b__39_1(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

	// RVA: 0x16A3BD8
	internal string <OnFetchStorePromotionVisibilitySucceeded>b__62_0(System.Collections.Generic.KeyValuePair<System.String,System.Object> k) { }

	// RVA: 0x16A3CA0
	internal string <OnFetchStorePromotionVisibilitySucceeded>b__62_1(System.Collections.Generic.KeyValuePair<System.String,System.Object> k) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public string productId; // 0x10

	// Methods

	// RVA: 0x16A15B0
	public void .ctor() { }

	// RVA: 0x16A3D80
	internal bool <FindMostRecentReceipt>b__0(AppleInAppPurchaseReceipt r) { }

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

	// RVA: 0x16A25DC
	public void .ctor() { }

	// RVA: 0x16A3DA8
	internal void <MessageCallback>b__0() { }

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

	// RVA: 0x169FAB8
	protected void .ctor(IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x169FBF4
	public void SetNativeStore(INativeAppleStore apple) { }

	// RVA: 0x169FD10
	public string get_appReceipt() { }

	// RVA: 0x169FF04
	private System.Nullable<System.Double> get_appReceiptModificationDate() { }

	// RVA: 0x169FFFC
	public string GetTransactionReceiptForProduct(Product product) { }

	// RVA: 0x16A010C
	public override void OnProductsRetrieved(string json) { }

	// RVA: 0x16A04F4
	private bool HasInAppPurchaseReceipts(AppleReceipt appleReceipt) { }

	// RVA: 0x16A0518
	private System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> EnrichProductDescriptions(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> productDescriptions, AppleReceipt appleReceipt) { }

	// RVA: 0x16A0A78
	private static AppleInAppPurchaseReceipt FindMostRecentReceipt(AppleReceipt appleReceipt, string productId) { }

	// RVA: 0x16A15B8
	private static AppleInAppPurchaseReceipt FirstNonCancelledReceipt(AppleInAppPurchaseReceipt[] foundReceipts) { }

	// RVA: 0x16A1678
	public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback) { }

	// RVA: 0x16A1680
	public void OnPurchaseDeferred(string productId) { }

	// RVA: 0x16A1788
	public void OnPromotionalPurchaseAttempted(string productId) { }

	// RVA: 0x16A1890
	public void OnTransactionsRestoredSuccess() { }

	// RVA: 0x16A1900
	public void OnTransactionsRestoredFail(string error) { }

	// RVA: 0x16A196C
	public void OnAppReceiptRetrieved(string receipt) { }

	// RVA: 0x16A1988
	public void OnAppReceiptRefreshedFailed(string error) { }

	// RVA: 0x16A19A4
	private void OnEntitlementsRevoked(string productIds) { }

	// RVA: 0x16A1D54
	private void RevokeEntitlement(AppleReceipt appleReceipt, string productId, System.Collections.Generic.List<UnityEngine.Purchasing.Product> revokedProducts, Product product) { }

	// RVA: 0x16A1E14
	private bool RestoreActiveEntitlement(AppleReceipt appleReceipt, string productId) { }

	// RVA: 0x16A1F24
	public void OnFetchStorePromotionOrderSucceeded(string productIds) { }

	// RVA: 0x16A2264
	public void OnFetchStorePromotionOrderFailed() { }

	// RVA: 0x16A2280
	public void OnFetchStorePromotionVisibilitySucceeded(string result) { }

	// RVA: 0x16A25C0
	public void OnFetchStorePromotionVisibilityFailed() { }

	// RVA: 0x169F8E4
	private static void MessageCallback(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	// RVA: 0x16A25E4
	private void ProcessMessage(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	// RVA: 0x16A2E14
	public void OnPurchaseSucceeded(string id, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	// RVA: 0x16A035C
	private AppleReceipt GetAppleReceiptFromBase64String(string receipt) { }

	// RVA: 0x16A3024
	private static bool IsValidPurchaseState(AppleInAppPurchaseReceipt mostRecentReceipt, string productId) { }

	// RVA: 0x16A319C
	private bool IsRestored(string productId, AppleInAppPurchaseReceipt productReceipt, string transactionId, string originalTransactionId) { }

	// RVA: 0x16A34A8
	private static bool IsSubscriptionRestored(AppleInAppPurchaseReceipt productReceipt, Product previousProduct) { }

	// RVA: 0x16A3488
	private static bool IsNonSubscriptionRestored(string transactionId, string originalTransactionId) { }

	// RVA: 0x16A14AC
	private void UpdateAppleProductFields(string id, string originalTransactionId, bool isRestored) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeAppleConfiguration
{
	// Methods

	// RVA: 0x16A3E24
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeAppleExtensions
{
	// Methods

	// RVA: 0x16A3E2C
	public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback) { }

	// RVA: 0x16A3E30
	public string GetTransactionReceiptForProduct(Product product) { }

	// RVA: 0x16A3E74
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public interface IAppleConfiguration
{}

// Namespace: UnityEngine.Purchasing
public interface IAppleExtensions
{
	// Methods

	// RVA: -1
	public abstract string GetTransactionReceiptForProduct(Product product) { }

	// RVA: -1
	public abstract void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback) { }

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

	// RVA: 0x16A4030
	public void .ctor() { }

	// RVA: 0x16A4438
	internal void <RetrieveProducts>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public MetricizedAppleStoreImpl <>4__this; // 0x10
	public ProductDefinition product; // 0x18
	public string developerPayload; // 0x20

	// Methods

	// RVA: 0x16A41D8
	public void .ctor() { }

	// RVA: 0x16A44FC
	internal void <Purchase>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedAppleStoreImpl
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0xD0

	// Methods

	// RVA: 0x16A3E7C
	public void .ctor(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

	// RVA: 0x16A3EAC
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x16A4038
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x16A41E0
	private void <>n__6(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x16A4360
	private void <>n__7(ProductDefinition product, string developerPayload) { }

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
	public abstract INativeStore GetAndroidStore(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util) { }

	// RVA: -1
	public abstract INativeAppleStore GetStorekit(IUnityCallback callback) { }

}

// Namespace: UnityEngine.Purchasing
internal interface IStoreInternal
{
	// Methods

	// RVA: -1
	public abstract void SetModule(StandardPurchasingModule module) { }

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

	// RVA: 0x169DCF8
	public void .ctor() { }

	// RVA: 0x16A4520
	public void SetNativeStore(INativeStore native) { }

	// RVA: 0x16A4528
	private void UnityEngine.Purchasing.IStoreInternal.SetModule(StandardPurchasingModule module) { }

	// RVA: 0x16A462C
	public override void Initialize(IStoreCallback callback) { }

	// RVA: 0x16A42A0
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x16A4364
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x16A33B0
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x16A2C90
	public void OnSetupFailed(string reason) { }

	// RVA: 0x16A46C4
	public virtual void OnProductsRetrieved(string json) { }

	// RVA: 0x16A32E0
	public virtual void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	// RVA: 0x16A2FF0
	public void OnPurchaseFailed(string json) { }

	// RVA: 0x16A4790
	public void OnPurchaseFailed(PurchaseFailureDescription failure, string json) { }

	// RVA: 0x16A4868
	private StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public MetricizedJsonStore <>4__this; // 0x10
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x16A4D0C
	public void .ctor() { }

	// RVA: 0x16A4F80
	internal void <RetrieveProducts>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public MetricizedJsonStore <>4__this; // 0x10
	public ProductDefinition product; // 0x18
	public string developerPayload; // 0x20

	// Methods

	// RVA: 0x16A4EB4
	public void .ctor() { }

	// RVA: 0x16A5044
	internal void <Purchase>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedJsonStore
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x48

	// Methods

	// RVA: 0x16A4AF4
	public void .ctor(ITelemetryMetricsService telemetryMetricsService) { }

	// RVA: 0x16A4B88
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x16A4D14
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x16A4EBC
	private void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x16A4F7C
	private void <>n__1(ProductDefinition product, string developerPayload) { }

}

// Namespace: UnityEngine.Purchasing
internal class NativeStoreProvider
{
	// Methods

	// RVA: 0x16A5068
	public INativeStore GetAndroidStore(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util) { }

	// RVA: 0x16A51A0
	private INativeStore GetAndroidStoreHelper(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util) { }

	// RVA: 0x16A5854
	public INativeAppleStore GetStorekit(IUnityCallback callback) { }

	// RVA: 0x16A5968
	public void .ctor() { }

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

	// RVA: 0x16A5970
	public void .ctor() { }

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

	// RVA: 0x16A6454
	public void .ctor() { }

	// RVA: 0x16A653C
	internal void <StoreRetrieveProducts>g__handleAllowInitializeOrRetrieveProducts|0(bool allow, InitializationFailureReason failureReason) { }

}

// Namespace: 
private sealed class <>c__DisplayClass15_0
{
	// Fields
	public FakeStore <>4__this; // 0x10
	public ProductDefinition product; // 0x18

	// Methods

	// RVA: 0x16A6BCC
	public void .ctor() { }

	// RVA: 0x16A6BD4
	internal void <FakePurchase>g__handleAllowPurchase|0(bool allow, PurchaseFailureReason failureReason) { }

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

	// RVA: 0x16A5978
	public string get_unavailableProductId() { }

	// RVA: 0x16A5980
	public override void Initialize(IStoreCallback biller) { }

	// RVA: 0x16A5A20
	public void RetrieveProducts(string json) { }

	// RVA: 0x16A5B38
	public void StoreRetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefinitions) { }

	// RVA: 0x16A668C
	public void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x16A6974
	private void FakePurchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x16A6E64
	public void FinishTransaction(string productJSON, string transactionID) { }

	// RVA: 0x16A6E68
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: -1
	protected virtual bool StartUI(object model, DialogType dialogType, System.Action<System.Boolean,T> callback) { }

	// RVA: 0x16A6E6C
	public void .ctor() { }

	// RVA: 0x16A6F4C
	private void <>n__0(string id, string receipt, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
internal class LifecycleNotifier
{
	// Fields
	public Action OnDestroyCallback; // 0x20

	// Methods

	// RVA: 0x16A701C
	private void OnDestroy() { }

	// RVA: 0x16A7038
	public void .ctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.UIFakeStore.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.String> <>9__20_0; // 0x8

	// Methods

	// RVA: 0x16A81A8
	private static void .cctor() { }

	// RVA: 0x16A8214
	public void .ctor() { }

	// RVA: 0x16A821C
	internal string <CreateRetrieveProductsQuestion>b__20_0(ProductDefinition pid) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0<T0>
{
	// Fields
	public System.Action<System.Boolean,T> callback; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: -1
	internal void <StartUI>b__0(bool result, int codeValue) { }

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

	// RVA: 0x16A7040
	public void .ctor() { }

	// RVA: -1
	protected override bool StartUI(object model, DialogType dialogType, System.Action<System.Boolean,T> callback) { }

	// RVA: 0x16A7044
	private bool StartUI(string queryText, string okayButtonText, string cancelButtonText, System.Collections.Generic.List<System.String> options, System.Action<System.Boolean,System.Int32> callback) { }

	// RVA: 0x16A7164
	private void InstantiateDialog() { }

	// RVA: 0x16A7300
	private UIFakeStoreWindow GetOrCreateFakeStoreWindow() { }

	// RVA: 0x16A7500
	private void AddLifeCycleNotifierAndSetDestroyCallback(GameObject gameObject) { }

	// RVA: 0x16A75BC
	private void EnsureEventSystemCreated(Transform rootTransform) { }

	// RVA: 0x16A768C
	private void ConfigureDialogWindow(UIFakeStoreWindow dialogWindow) { }

	// RVA: 0x16A7A88
	private void ConfigureDialogWindowCallbacks(UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback) { }

	// RVA: 0x16A7738
	private void CreateEventSystem(Transform rootTransform) { }

	// RVA: 0x16A7C60
	private string CreatePurchaseQuestion(ProductDefinition definition) { }

	// RVA: 0x16A7CD0
	private string CreateRetrieveProductsQuestion(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> definitions) { }

	// RVA: 0x16A7EF8
	private void OkayButtonClicked() { }

	// RVA: 0x16A80B4
	private void CancelButtonClicked() { }

	// RVA: 0x16A8194
	private void DropdownValueChanged(int selectedItem) { }

	// RVA: 0x16A7FD4
	private void CloseDialog() { }

	// RVA: 0x16A7154
	public bool IsShowingDialog() { }

	// RVA: 0x16A819C
	private void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0() { }

}

// Namespace: UnityEngine.Purchasing
internal class UIFakeStoreDropdown
{
	// Fields
	private System.Collections.Generic.List<System.String> m_Options; // 0x10
	private System.Action<System.Int32,System.String> m_OnDropdown; // 0x18
	private Vector2 scrollPosition; // 0x20

	// Methods

	// RVA: 0x16A8238
	public void DoPopup(int windowID) { }

	// RVA: 0x16A8618
	private void OnOptionSelected(int optionIndex) { }

	// RVA: 0x16A86B0
	internal void SetOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x16A8740
	internal void SetSelectionAction(System.Action<System.Int32,System.String> onDropdown) { }

	// RVA: 0x16A8748
	public void .ctor() { }

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
	private const float k_MenuScreenRatio = 0.6;

	// Methods

	// RVA: 0x16A8750
	private void OnGUI() { }

	// RVA: 0x16A8918
	private Rect CreateCenteredWindowRect() { }

	// RVA: 0x16A899C
	private void DoMainGUI(int windowID) { }

	// RVA: 0x16A8E3C
	private void DoDropDown() { }

	// RVA: 0x16A8E48
	private void OnOkClicked() { }

	// RVA: 0x16A8E64
	private void OnCancelClicked() { }

	// RVA: 0x16A78C8
	internal void ConfigureMainDialogText(string queryText, string okText, string cancelText) { }

	// RVA: 0x16A7918
	internal void ConfigureDropdownOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x16A8E80
	private void OnDropdown(int index, string selectionText) { }

	// RVA: 0x16A7BF8
	internal void AssignCallbacks(Action onOk, Action onCancel, System.Action<System.Int32> onDropdown) { }

	// RVA: 0x16A8EE8
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class Price
{
	// Fields
	public Decimal value; // 0x10
	private int[] data; // 0x20
	private Double num; // 0x28

	// Methods

	// RVA: 0x16A8F60
	public void OnBeforeSerialize() { }

	// RVA: 0x16A8FF0
	public void OnAfterDeserialize() { }

	// RVA: 0x16A906C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
[Serializable]
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
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.LocalizedProductDescription.<>c <>9; // 0x0
	public static MatchEvaluator <>9__11_0; // 0x8

	// Methods

	// RVA: 0x16A91F8
	private static void .cctor() { }

	// RVA: 0x16A9264
	public void .ctor() { }

	// RVA: 0x16A926C
	internal string <DecodeNonLatinCharacters>b__11_0(Match m) { }

}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class LocalizedProductDescription
{
	// Fields
	public TranslationLocale googleLocale; // 0x10
	private string title; // 0x18
	private string description; // 0x20

	// Methods

	// RVA: 0x16A652C
	public string get_Title() { }

	// RVA: 0x16A6534
	public string get_Description() { }

	// RVA: 0x16A9074
	private static string DecodeNonLatinCharacters(string s) { }

	// RVA: 0x16A91E8
	public void .ctor() { }

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
[Serializable]
public class ProductCatalogPayout
{
	// Fields
	private string t; // 0x10
	private string st; // 0x18
	private string d; // 0x20

	// Methods

	// RVA: 0x16A932C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
[Serializable]
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

	// RVA: 0x16A93FC
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
[Serializable]
public class ProductCatalog
{
	// Fields
	private static IProductCatalogImpl instance; // 0x0
	public bool enableCodelessAutoInitialization; // 0x10
	private System.Collections.Generic.List<UnityEngine.Purchasing.ProductCatalogItem> products; // 0x18

	// Methods

	// RVA: 0x16A95D4
	public System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> get_allProducts() { }

	// RVA: 0x16A95DC
	internal static void Initialize() { }

	// RVA: 0x16A96AC
	public static void Initialize(IProductCatalogImpl productCatalogImpl) { }

	// RVA: 0x16A9710
	public static ProductCatalog Deserialize(string catalogJSON) { }

	// RVA: 0x16A9778
	public static ProductCatalog FromTextAsset(TextAsset asset) { }

	// RVA: 0x16A645C
	public static ProductCatalog LoadDefaultCatalog() { }

	// RVA: 0x16A97F0
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public interface IProductCatalogImpl
{
	// Methods

	// RVA: -1
	public abstract ProductCatalog LoadDefaultCatalog() { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductCatalogImpl
{
	// Methods

	// RVA: 0x16A9884
	public ProductCatalog LoadDefaultCatalog() { }

	// RVA: 0x16A96A4
	public void .ctor() { }

}

// Namespace: 
internal class StoreInstance
{
	// Fields
	private readonly string <storeName>k__BackingField; // 0x10
	private readonly IStore <instance>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16AC2A4
	internal string get_storeName() { }

	// RVA: 0x16AC2AC
	internal IStore get_instance() { }

	// RVA: 0x16AAC1C
	internal void .ctor(string name, IStore instance) { }

}

// Namespace: 
private class MicrosoftConfiguration
{
	// Fields
	private readonly StandardPurchasingModule module; // 0x10

	// Methods

	// RVA: 0x16AA898
	public void .ctor(StandardPurchasingModule module) { }

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

	// RVA: 0x16A9A84
	internal IUtil get_util() { }

	// RVA: 0x16A9A8C
	private void set_util(IUtil value) { }

	// RVA: 0x16A9A94
	internal ILogger get_logger() { }

	// RVA: 0x16A9A9C
	private void set_logger(ILogger value) { }

	// RVA: 0x16A9AA4
	internal StoreInstance get_storeInstance() { }

	// RVA: 0x16A9AAC
	private void set_storeInstance(StoreInstance value) { }

	// RVA: 0x16A9AB4
	internal ITelemetryMetricsInstanceWrapper get_telemetryMetricsInstanceWrapper() { }

	// RVA: 0x16A9ABC
	internal void set_telemetryMetricsInstanceWrapper(ITelemetryMetricsInstanceWrapper value) { }

	// RVA: 0x16A9AC4
	internal ITelemetryDiagnosticsInstanceWrapper get_telemetryDiagnosticsInstanceWrapper() { }

	// RVA: 0x16A9ACC
	internal void set_telemetryDiagnosticsInstanceWrapper(ITelemetryDiagnosticsInstanceWrapper value) { }

	// RVA: 0x16A9AD4
	internal void .ctor(IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, RuntimePlatform platform, AppStore android, ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	// RVA: 0x16A9BC8
	public AppStore get_appStore() { }

	// RVA: 0x16A9BD0
	private void set_appStore(AppStore value) { }

	// RVA: 0x16A9BD8
	public FakeStoreUIMode get_useFakeStoreUIMode() { }

	// RVA: 0x16A9BE0
	public void set_useFakeStoreUIMode(FakeStoreUIMode value) { }

	// RVA: 0x16A9BE8
	public bool get_useFakeStoreAlways() { }

	// RVA: 0x16A9BF0
	public void set_useFakeStoreAlways(bool value) { }

	// RVA: 0x16A9BF8
	public static StandardPurchasingModule Instance() { }

	// RVA: 0x16A9C68
	public static StandardPurchasingModule Instance(AppStore androidStore) { }

	// RVA: 0x16AA2E4
	public override void Configure() { }

	// RVA: 0x16AA8CC
	private StoreInstance InstantiateStore() { }

	// RVA: 0x16AAFF8
	private IStore InstantiateAndroid() { }

	// RVA: 0x16AB294
	private IStore InstantiateGoogleStore() { }

	// RVA: 0x16AC020
	private void BindGoogleExtension(GooglePlayStoreExtensions googlePlayStoreExtensions) { }

	// RVA: 0x16ABE38
	private static GooglePlayConfiguration BuildGooglePlayStoreConfiguration(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback) { }

	// RVA: 0x16ABFC4
	private void BindGoogleConfiguration(GooglePlayConfiguration googlePlayConfiguration) { }

	// RVA: 0x16AB894
	private IGooglePlayStoreService BuildAndInitGooglePlayStoreServiceAar(IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider) { }

	// RVA: 0x16AAE14
	private IStore InstantiateUDP() { }

	// RVA: 0x16AB7A4
	private IStore InstantiateAndroidHelper(JSONStore store) { }

	// RVA: 0x16AC07C
	private INativeStore GetAndroidNativeStore(JSONStore store) { }

	// RVA: 0x16AAC6C
	private IStore InstantiateApple() { }

	// RVA: 0x16AB124
	private IStore instantiateWindowsStore() { }

	// RVA: 0x16AAB78
	private IStore InstantiateFakeStore() { }

	// RVA: 0x16AC150
	private static void .cctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class StoreConfiguration
{
	// Fields
	private AppStore <androidStore>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16AC2B4
	public AppStore get_androidStore() { }

	// RVA: 0x16AC2BC
	private void set_androidStore(AppStore value) { }

	// RVA: 0x16AC2C4
	public void .ctor(AppStore store) { }

	// RVA: 0x16AA038
	public static StoreConfiguration Deserialize(string json) { }

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

	// RVA: 0x16AC2F0
	public void .ctor(Double d, int m, int y) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.SubscriptionManager.<>c <>9; // 0x0
	public static System.Comparison<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> <>9__11_0; // 0x8
	public static System.Func<System.Object,System.String> <>9__12_0; // 0x10

	// Methods

	// RVA: 0x16AD910
	private static void .cctor() { }

	// RVA: 0x16AD97C
	public void .ctor() { }

	// RVA: 0x16AD984
	internal int <findMostRecentReceipt>b__11_0(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

	// RVA: 0x16ADA14
	internal string <getGooglePlayStoreSubInfo>b__12_0(object obj) { }

}

// Namespace: UnityEngine.Purchasing
public class SubscriptionManager
{
	// Fields
	private readonly string receipt; // 0x10
	private readonly string productId; // 0x18
	private readonly string intro_json; // 0x20

	// Methods

	// RVA: 0x16A370C
	public void .ctor(Product product, string intro_json) { }

	// RVA: 0x16A377C
	public SubscriptionInfo getSubscriptionInfo() { }

	// RVA: 0x16ACD9C
	private SubscriptionInfo getAmazonAppStoreSubInfo(string productId) { }

	// RVA: 0x16AC9F0
	private SubscriptionInfo getAppleAppStoreSubInfo(string payload, string productId) { }

	// RVA: 0x16ACEC4
	private AppleInAppPurchaseReceipt findMostRecentReceipt(System.Collections.Generic.List<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> receipts) { }

	// RVA: 0x16AC338
	private SubscriptionInfo getGooglePlayStoreSubInfo(string payload) { }

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

	// RVA: 0x16A0C6C
	public void .ctor(AppleInAppPurchaseReceipt r, string intro_json) { }

	// RVA: 0x16AD01C
	public void .ctor(string skuDetails, bool isAutoRenewing, DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata) { }

	// RVA: 0x16ACE00
	public void .ctor(string productId) { }

	// RVA: 0x16AE3E0
	public Result isExpired() { }

	// RVA: 0x16AE3E8
	public Result isCancelled() { }

	// RVA: 0x16AE3F0
	public DateTime getExpireDate() { }

	// RVA: 0x16AE28C
	private DateTime nextBillingDate(DateTime billing_begin_date, TimeSpanUnits units) { }

	// RVA: 0x16ADF14
	private TimeSpan accumulateIntroductoryDuration(TimeSpanUnits units, Int64 cycles) { }

	// RVA: 0x16ADCB4
	private TimeSpan computePeriodTimeSpan(TimeSpanUnits units) { }

	// RVA: 0x16ADFF4
	private Double computeExtraTime(string metadata, Double new_sku_period_in_seconds) { }

	// RVA: 0x16ADD94
	private TimeSpan parseTimeSpan(string period_string) { }

	// RVA: 0x16ADA7C
	private TimeSpanUnits parsePeriodTimeSpanUnits(string time_span) { }

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

	// RVA: 0x16AE3F8
	public void .ctor() { }

	// RVA: 0x16AE480
	public void .ctor(string message) { }

}

// Namespace: UnityEngine.Purchasing
public class InvalidProductTypeException
{
	// Methods

	// RVA: 0x16AE4EC
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class NullProductIdException
{
	// Methods

	// RVA: 0x16AE574
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class NullReceiptException
{
	// Methods

	// RVA: 0x16AE5FC
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class StoreSubscriptionInfoNotSupportedException
{
	// Methods

	// RVA: 0x16AE684
	public void .ctor(string message) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeTransactionHistoryExtensions
{
	// Methods

	// RVA: 0x16AE6F0
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public interface ITransactionHistoryExtensions
{}

// Namespace: 
[Serializable]
private sealed class <>c__0<T0>
{
	// Fields
	public static readonly UnityEngine.Purchasing.EnumerableExtensions.<>c__0<T> <>9; // 0x0
	public static System.Func<T,System.Boolean> <>9__0_0; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal bool <NonNull>b__0_0(T obj) { }

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

	// RVA: 0x30B29E8
	public void .ctor(int <>1__state) { }

	// RVA: 0x30B2870
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30B171C
	private bool MoveNext() { }

	// RVA: 0x30B2870
	private void <>m__Finally1() { }

	// RVA: 0x316B894
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }

	// RVA: 0x30B2870
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.Purchasing
internal static class EnumerableExtensions
{
	// Methods

	// RVA: 0x30B57C8
	public static System.Collections.Generic.IEnumerable<T> NonNull(System.Collections.Generic.IEnumerable<T> enumerable) { }

	// RVA: 0x30B58A8
	public static System.Collections.Generic.IEnumerable<T> IgnoreExceptions(System.Collections.Generic.IEnumerable<T> enumerable, System.Action<TException> onException) { }

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

	// RVA: 0x16AEA60
	private void MoveNext() { }

	// RVA: 0x16AEC34
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x16AEC40
	private void MoveNext() { }

	// RVA: 0x16AEF80
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x16AE848
	public void .ctor() { }

	// RVA: 0x16AE8C0
	internal void <Invoke>g__Retry|0() { }

	// RVA: 0x16AE978
	internal Task <Invoke>g__WaitAndRetry|1() { }

}

// Namespace: UnityEngine.Purchasing
internal class ExponentialRetryPolicy
{
	// Fields
	private readonly int m_BaseRetryDelay; // 0x10
	private readonly int m_MaxRetryDelay; // 0x14
	private readonly int m_ExponentialFactor; // 0x18

	// Methods

	// RVA: 0x16AE6F8
	public void .ctor(int baseRetryDelay, int maxRetryDelay, int exponentialFactor) { }

	// RVA: 0x16AE738
	public void Invoke(System.Action<System.Action> actionToTry, Action onRetryAction) { }

	// RVA: 0x16AE850
	private int AdjustDelay(int delay) { }

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

	// RVA: 0x16AF2A8
	private void MoveNext() { }

	// RVA: 0x16AF5C0
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

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

	// RVA: 0x16AF178
	public void .ctor() { }

	// RVA: 0x16AF180
	internal void <Invoke>g__WaitAndRetry|0() { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleConnectionRetryPolicy
{
	// Fields
	private readonly int m_BaseRetryDelay; // 0x10
	private readonly int m_MaxRetryDelay; // 0x14
	private readonly int m_ExponentialFactor; // 0x18

	// Methods

	// RVA: 0x16AEFEC
	public void .ctor(int baseRetryDelay, int maxRetryDelay, int exponentialFactor) { }

	// RVA: 0x16AF02C
	public void Invoke(System.Action<System.Action> actionToTry, Action onRetryAction) { }

	// RVA: 0x16AF238
	private int AdjustDelay(int delay) { }

}

// Namespace: UnityEngine.Purchasing
internal static class ProductDefinitionExtensions
{
	// Methods

	// RVA: 0x16AF5CC
	internal static System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> DecodeJSON(System.Collections.Generic.List<System.Object> productsList, string storeName) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeMicrosoftExtensions
{
	// Methods

	// RVA: 0x16AFF8C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public interface IMicrosoftConfiguration
{}

// Namespace: UnityEngine.Purchasing
public interface IMicrosoftExtensions
{}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.WinRTStore.<>c <>9; // 0x0
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,System.Boolean> <>9__8_0; // 0x8
	public static System.Func<UnityEngine.Purchasing.ProductDefinition,UnityEngine.Purchasing.Default.WinProductDescription> <>9__8_1; // 0x10

	// Methods

	// RVA: 0x16B060C
	private static void .cctor() { }

	// RVA: 0x16B0678
	public void .ctor() { }

	// RVA: 0x16B0680
	internal bool <RetrieveProducts>b__8_0(ProductDefinition def) { }

	// RVA: 0x16B06A4
	internal WinProductDescription <RetrieveProducts>b__8_1(ProductDefinition def) { }

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

	// RVA: 0x16AFF94
	public void .ctor(IWindowsIAP win8, IUtil util, ILogger logger) { }

	// RVA: 0x16AFFF8
	public override void Initialize(IStoreCallback biller) { }

	// RVA: 0x16B0000
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefs) { }

	// RVA: 0x16B03C0
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x16B0290
	private void init(int delay) { }

	// RVA: 0x16B0478
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x16B0538
	public void restoreTransactions(bool pausing) { }

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

	// RVA: 0x16B1148
	public void .ctor(int <>1__state) { }

	// RVA: 0x16B19A4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x16B19A8
	private bool MoveNext() { }

	// RVA: 0x16B1A74
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x16B1A7C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x16B1ABC
	private object System.Collections.IEnumerator.get_Current() { }

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

	// RVA: 0x30B1CD4
	public T[] GetAnyComponentsOfType() { }

	// RVA: 0x16B0820
	public DateTime get_currentTime() { }

	// RVA: 0x16B0890
	public string get_persistentDataPath() { }

	// RVA: 0x16B0900
	public string get_deviceUniqueIdentifier() { }

	// RVA: 0x16B0908
	public string get_unityVersion() { }

	// RVA: 0x16B0978
	public string get_cloudProjectId() { }

	// RVA: 0x16B09E8
	public string get_userId() { }

	// RVA: 0x16B0A58
	public string get_gameVersion() { }

	// RVA: 0x16B0AC8
	public UInt64 get_sessionId() { }

	// RVA: 0x16B0B38
	public RuntimePlatform get_platform() { }

	// RVA: 0x16B0BA8
	public bool get_isEditor() { }

	// RVA: 0x16B0C18
	public string get_deviceModel() { }

	// RVA: 0x16B0C20
	public string get_deviceName() { }

	// RVA: 0x16B0C28
	public DeviceType get_deviceType() { }

	// RVA: 0x16B0C30
	public string get_operatingSystem() { }

	// RVA: 0x16B0C38
	public int get_screenWidth() { }

	// RVA: 0x16B0C40
	public int get_screenHeight() { }

	// RVA: 0x16B0C48
	public float get_screenDpi() { }

	// RVA: 0x16B0C50
	public string get_screenOrientation() { }

	// RVA: 0x16B0CBC
	private object Uniject.IUtil.InitiateCoroutine(IEnumerator start) { }

	// RVA: 0x16B0CC4
	private void Uniject.IUtil.InitiateCoroutine(IEnumerator start, int delay) { }

	// RVA: 0x16B0DF8
	public void RunOnMainThread(Action runnable) { }

	// RVA: 0x16B0F60
	public object GetWaitForSeconds(int seconds) { }

	// RVA: 0x16B0FC8
	private void Start() { }

	// RVA: 0x316B894
	public static T FindInstanceOfType() { }

	// RVA: 0x316B894
	public static T LoadResourceInstanceOfType() { }

	// RVA: 0x16B1054
	public static bool PcPlatform() { }

	// RVA: 0x16B0D5C
	private IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay) { }

	// RVA: 0x16B1174
	private void Update() { }

	// RVA: 0x16B149C
	public void AddPauseListener(System.Action<System.Boolean> runnable) { }

	// RVA: 0x16B1500
	public void OnApplicationPause(bool paused) { }

	// RVA: 0x16B16E4
	public bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant) { }

	// RVA: 0x16B1788
	public void .ctor() { }

	// RVA: 0x16B1814
	private static void .cctor() { }

}

// Namespace: UnityEngine.Purchasing.Stores.Util
internal interface IRetryPolicy
{
	// Methods

	// RVA: -1
	public abstract void Invoke(System.Action<System.Action> actionToTry, Action onRetryAction) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public CoreRegistry registry; // 0x10
	public ITelemetryMetricsInstanceWrapper metricsInstanceWrapper; // 0x18
	public ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper; // 0x20

	// Methods

	// RVA: 0x16B1E7C
	public void .ctor() { }

	// RVA: 0x16B2388
	internal void <Initialize>b__0() { }

}

// Namespace: UnityEngine.Purchasing.Registration
internal class IapCoreInitializeCallback
{
	// Methods

	// RVA: 0x16B1AC4
	private static void Register() { }

	// RVA: 0x16B1C04
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x16B1E84
	private static void CacheInitializedEnvironment(CoreRegistry registry) { }

	// RVA: 0x16B1EBC
	private static string GetCurrentEnvironment(CoreRegistry registry) { }

	// RVA: 0x16B202C
	private static void InitializeTelemetryComponents(ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper) { }

	// RVA: 0x16B1BFC
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails; // 0x10

	// Methods

	// RVA: 0x16B3588
	public void .ctor() { }

	// RVA: 0x16B3590
	internal AndroidJavaObject <TryFindAllProductDetails>b__0(string sku) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_1
{
	// Fields
	public string sku; // 0x10

	// Methods

	// RVA: 0x16B3690
	public void .ctor() { }

	// RVA: 0x16B3698
	internal bool <TryFindAllProductDetails>b__1(AndroidJavaObject productDetail) { }

}

// Namespace: UnityEngine.Purchasing.Utils
internal class GooglePurchaseBuilder
{
	// Fields
	private readonly IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService; // 0x10
	private readonly ILogger m_Logger; // 0x18

	// Methods

	// RVA: 0x16B23D0
	public void .ctor(IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, ILogger logger) { }

	// RVA: 0x16B2420
	public System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

	// RVA: 0x16B2550
	private void LogWarningForException(Exception exception) { }

	// RVA: 0x16B2594
	public IGooglePurchase BuildPurchase(AndroidJavaObject purchase) { }

	// RVA: 0x16B2AC4
	private static System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> TryFindAllProductDetails(System.Collections.Generic.IEnumerable<System.String> skus, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

}

// Namespace: UnityEngine.Purchasing.Utils
internal static class GoogleReceiptEncoder
{
	// Methods

	// RVA: 0x16B37E0
	internal static string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, System.Collections.Generic.List<System.String> productDetailsJson) { }

}

// Namespace: UnityEngine.Purchasing.Utils
internal class ProductDetailsConverter
{
	// Methods

	// RVA: 0x16B3908
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

	// RVA: 0x16B39C8
	private static ProductDescription ToProductDescription(AndroidJavaObject productDetails) { }

	// RVA: 0x16B3A7C
	internal static ProductDescription BuildProductDescription(AndroidJavaObject productDetails) { }

	// RVA: 0x16B577C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IBillingClientStateListener
{
	// Methods

	// RVA: -1
	public abstract void RegisterOnConnected(Action onConnected) { }

	// RVA: -1
	public abstract void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleBillingClient
{
	// Methods

	// RVA: -1
	public abstract void StartConnection(IBillingClientStateListener billingClientStateListener) { }

	// RVA: -1
	public abstract GoogleBillingConnectionState GetConnectionState() { }

	// RVA: -1
	public abstract void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse) { }

	// RVA: -1
	public abstract void QueryProductDetailsAsync(System.Collections.Generic.List<System.String> skus, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction) { }

	// RVA: -1
	public abstract AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode) { }

	// RVA: -1
	public abstract void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume) { }

	// RVA: -1
	public abstract void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleFinishTransactionService
{
	// Methods

	// RVA: -1
	public abstract void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleLastKnownProductService
{
	// Methods

	// RVA: -1
	public abstract string get_LastKnownOldProductId() { }

	// RVA: -1
	public abstract void set_LastKnownOldProductId(string value) { }

	// RVA: -1
	public abstract string get_LastKnownProductId() { }

	// RVA: -1
	public abstract void set_LastKnownProductId(string value) { }

	// RVA: -1
	public abstract System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode() { }

	// RVA: -1
	public abstract void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePlayStoreService
{
	// Methods

	// RVA: -1
	public abstract void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductFailed) { }

	// RVA: -1
	public abstract void Purchase(ProductDefinition product) { }

	// RVA: -1
	public abstract void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

	// RVA: -1
	public abstract void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed) { }

	// RVA: -1
	public abstract IGooglePurchase GetPurchase(string purchaseToken, string skuType) { }

	// RVA: -1
	public abstract void ResumeConnection() { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleProductCallback
{
	// Methods

	// RVA: -1
	public abstract void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: -1
	public abstract void NotifyQueryProductDetailsFailed(int retryCount) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchase
{
	// Methods

	// RVA: -1
	public abstract int get_purchaseState() { }

	// RVA: -1
	public abstract System.Collections.Generic.List<System.String> get_skus() { }

	// RVA: -1
	public abstract string get_receipt() { }

	// RVA: -1
	public abstract string get_purchaseToken() { }

	// RVA: -1
	public abstract string get_sku() { }

	// RVA: -1
	public abstract bool IsAcknowledged() { }

	// RVA: -1
	public abstract bool IsPurchased() { }

	// RVA: -1
	public abstract bool IsPending() { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseBuilder
{
	// Methods

	// RVA: -1
	public abstract System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

	// RVA: -1
	public abstract IGooglePurchase BuildPurchase(AndroidJavaObject purchase) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseCallback
{
	// Methods

	// RVA: -1
	public abstract void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: -1
	public abstract void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: -1
	public abstract void OnPurchaseSuccessful(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: -1
	public abstract void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription) { }

	// RVA: -1
	public abstract void NotifyDeferredPurchase(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: -1
	public abstract void NotifyDeferredProrationUpgradeDowngradeSubscription(string sku) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseService
{
	// Methods

	// RVA: -1
	public abstract void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseStateEnumProvider
{
	// Methods

	// RVA: -1
	public abstract int Purchased() { }

	// RVA: -1
	public abstract int Pending() { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGooglePurchaseUpdatedListener
{}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IGoogleQueryPurchasesService
{
	// Methods

	// RVA: -1
	public abstract System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases() { }

	// RVA: -1
	public abstract IGooglePurchase GetPurchaseByToken(string token, string skuType) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IProductDetailsConverter
{
	// Methods

	// RVA: -1
	public abstract System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IProductDetailsResponseConsolidator
{
	// Methods

	// RVA: -1
	public abstract void Consolidate(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IQueryProductDetailsService
{
	// Methods

	// RVA: -1
	public abstract void QueryAsyncProduct(ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: -1
	public abstract void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

}

// Namespace: UnityEngine.Purchasing.Interfaces
internal interface IProductDetailsQueryResponse
{
	// Methods

	// RVA: -1
	public abstract void AddResponse(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

	// RVA: -1
	public abstract System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails() { }

	// RVA: -1
	public abstract bool IsRecoverable() { }

	// RVA: -1
	public abstract IGoogleBillingResult GetGoogleBillingResult() { }

}

// Namespace: 
private sealed class <>c__DisplayClass0_0<T0>
{
	// Fields
	public AndroidJavaObject androidJavaList; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal T <Enumerate>b__0(int i) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class AndroidJavaObjectExtensions
{
	// Methods

	// RVA: 0x30B57C8
	internal static System.Collections.Generic.IEnumerable<T> Enumerate(AndroidJavaObject androidJavaList) { }

	// RVA: 0x16B5728
	internal static System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> Enumerate(AndroidJavaObject androidJavaList) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal interface IGoogleBillingResult
{
	// Methods

	// RVA: -1
	public abstract GoogleBillingResponseCode get_responseCode() { }

	// RVA: -1
	public abstract string get_debugMessage() { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public string type; // 0x10

	// Methods

	// RVA: 0x16B6E0C
	public void .ctor() { }

	// RVA: 0x16B9140
	internal AndroidJavaObject <QueryProductDetailsParamsProductList>b__0(string product) { }

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

	// RVA: 0x16B5784
	private static AndroidJavaClass GetProductParamsClass() { }

	// RVA: 0x16B5858
	private static AndroidJavaClass GetQueryProductDetailsParamsParamsClass() { }

	// RVA: 0x16B5924
	private static AndroidJavaClass GetBillingFlowParamClass() { }

	// RVA: 0x16B59F0
	private static AndroidJavaClass GetProductDetailsParamsClass() { }

	// RVA: 0x16B5ABC
	private static AndroidJavaClass GetSubscriptionUpdateParamClass() { }

	// RVA: 0x16B5B88
	private static AndroidJavaClass GetConsumeParamsClass() { }

	// RVA: 0x16B5C54
	private static AndroidJavaClass GetAcknowledgePurchaseParamsClass() { }

	// RVA: 0x16B5D20
	private static AndroidJavaClass GetBillingClientClass() { }

	// RVA: 0x16B5DEC
	internal void .ctor(IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x16B6270
	public void StartConnection(IBillingClientStateListener billingClientStateListener) { }

	// RVA: 0x16B6344
	public GoogleBillingConnectionState GetConnectionState() { }

	// RVA: 0x16B647C
	public void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse) { }

	// RVA: 0x16B65BC
	public void QueryProductDetailsAsync(System.Collections.Generic.List<System.String> products, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction) { }

	// RVA: 0x16B683C
	private static AndroidJavaObject QueryProductDetailsParams(System.Collections.Generic.List<System.String> products, string type) { }

	// RVA: 0x16B6CE4
	private static AndroidJavaObject QueryProductDetailsParamsProductList(System.Collections.Generic.List<System.String> products, string type) { }

	// RVA: 0x16B6E14
	private static AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product) { }

	// RVA: 0x16B729C
	public AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode) { }

	// RVA: 0x16B7C90
	private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode) { }

	// RVA: 0x16B8278
	private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayProrationMode prorationMode) { }

	// RVA: 0x16B8170
	private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	// RVA: 0x16B8068
	private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	// RVA: 0x16B85D8
	public void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume) { }

	// RVA: 0x16B8B8C
	public void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal class GoogleBillingResult
{
	// Fields
	private readonly GoogleBillingResponseCode <responseCode>k__BackingField; // 0x10
	private readonly string <debugMessage>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16B9148
	public GoogleBillingResponseCode get_responseCode() { }

	// RVA: 0x16B9150
	public string get_debugMessage() { }

	// RVA: 0x16B9158
	internal void .ctor(AndroidJavaObject billingResult) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class GoogleBillingStrings
{
	// Methods

	// RVA: 0x16B9340
	internal static string getWarningMessageMoreThanOneSkuFound(string sku) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class GoogleProductTypeEnum
{
	// Methods

	// RVA: 0x16B93B0
	internal static string InApp() { }

	// RVA: 0x16B93F4
	internal static string Sub() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly UnityEngine.Purchasing.Models.GooglePurchase.<>c <>9; // 0x0
	public static System.Func<UnityEngine.AndroidJavaObject,System.String> <>9__32_0; // 0x8

	// Methods

	// RVA: 0x16B9A58
	private static void .cctor() { }

	// RVA: 0x16B9AC4
	public void .ctor() { }

	// RVA: 0x16B9ACC
	internal string <.ctor>b__32_0(AndroidJavaObject productDetails) { }

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

	// RVA: 0x16B9438
	public bool get_isAcknowledged() { }

	// RVA: 0x16B9440
	public int get_purchaseState() { }

	// RVA: 0x16B9448
	public System.Collections.Generic.List<System.String> get_skus() { }

	// RVA: 0x16B9450
	public string get_receipt() { }

	// RVA: 0x16B9458
	public string get_signature() { }

	// RVA: 0x16B9460
	public string get_originalJson() { }

	// RVA: 0x16B9468
	public string get_purchaseToken() { }

	// RVA: 0x16B9470
	public string get_sku() { }

	// RVA: 0x16B2BAC
	internal void .ctor(AndroidJavaObject purchase, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetailsEnum) { }

	// RVA: 0x16B94D8
	public virtual bool IsAcknowledged() { }

	// RVA: 0x16B94E0
	public virtual bool IsPurchased() { }

	// RVA: 0x16B9798
	public virtual bool IsPending() { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class GooglePurchaseStateEnum
{
	// Fields
	private static System.Nullable<System.Int32> s_Purchased; // 0x0
	private static System.Nullable<System.Int32> s_Pending; // 0x8

	// Methods

	// RVA: 0x16B9B00
	private static AndroidJavaObject GetPurchaseStateJavaObject() { }

	// RVA: 0x16B9508
	internal static int Purchased() { }

	// RVA: 0x16B97C0
	internal static int Pending() { }

}

// Namespace: UnityEngine.Purchasing.Models
internal class GooglePurchaseStateEnumProvider
{
	// Methods

	// RVA: 0x16B9B78
	public int Purchased() { }

	// RVA: 0x16B9B7C
	public int Pending() { }

	// RVA: 0x16B9B80
	public void .ctor() { }

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

	// RVA: 0x16B9B88
	internal void .ctor(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

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

	// RVA: 0x16B9BEC
	internal static UInt32 ComputeStringHash(string s) { }

}


