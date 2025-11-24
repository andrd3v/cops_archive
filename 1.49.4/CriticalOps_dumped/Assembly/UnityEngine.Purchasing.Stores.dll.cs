// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0x16777B8
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x16777C0
	public void .ctor(Byte ) { }

	// RVA: 0x167784C
	public void .ctor(Byte[] ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0x1677880
	public void .ctor(Byte ) { }

}

// Namespace: Stores.Util
internal class JsonProductDescriptionsDeserializer
{
	// Methods

	// RVA: 0x16778AC
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> DeserializeProductDescriptions(string json) { }

	// RVA: 0x1677E3C
	internal virtual ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

	// RVA: 0x16780DC
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class AmazonAppStoreStoreExtensions
{
	// Fields
	private readonly AndroidJavaObject android; // 0x10

	// Methods

	// RVA: 0x16780E4
	public void .ctor(AndroidJavaObject a) { }

}

// Namespace: UnityEngine.Purchasing
public class FakeAmazonExtensions
{
	// Methods

	// RVA: 0x1678118
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

	// RVA: 0x1678120
	public void .ctor(AndroidJavaObject store) { }

	// RVA: 0x1678154
	public void RetrieveProducts(string json) { }

	// RVA: 0x1678228
	public virtual void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x167833C
	public virtual void FinishTransaction(string productJSON, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
internal static class ListExtension
{
	// Methods

	// RVA: 0x30A52D0
	internal static AndroidJavaObject ToJava(System.Collections.Generic.List<T> values) { }

	// RVA: 0x30A52D0
	private static AndroidJavaObject ToJavaArray(System.Collections.Generic.List<T> values) { }

}

// Namespace: UnityEngine.Purchasing
internal class UnityActivity
{
	// Fields
	private static AndroidJavaClass s_UnityPlayerClass; // 0x0

	// Methods

	// RVA: 0x1678450
	private static AndroidJavaClass GetUnityPlayerClass() { }

	// RVA: 0x1678524
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

	// RVA: 0x16790E8
	private static void .cctor() { }

	// RVA: 0x1679154
	public void .ctor() { }

	// RVA: 0x167915C
	internal string <GetCachedQueriedProductDetails>b__5_0(ProductDefinition product) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleCachedQueryProductDetailsService
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.String,UnityEngine.AndroidJavaObject> m_CachedQueriedProductDetails; // 0x10

	// Methods

	// RVA: 0x16785A0
	protected override void Finalize() { }

	// RVA: 0x1678884
	public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProducts() { }

	// RVA: 0x16788D8
	private AndroidJavaObject GetCachedQueriedProductDetails(string productId) { }

	// RVA: 0x1678950
	private System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<System.String> productIds) { }

	// RVA: 0x16789F8
	public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1678BAC
	private bool Contains(string productId) { }

	// RVA: 0x1678C10
	public bool Contains(ProductDefinition products) { }

	// RVA: 0x1678C78
	public void AddCachedQueriedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> queriedProducts) { }

	// RVA: 0x167905C
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public string purchaseToken; // 0x10

	// Methods

	// RVA: 0x16796B8
	public void .ctor() { }

	// RVA: 0x16796C0
	internal bool <FindPurchase>b__0(IGooglePurchase purchase) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished; // 0x10
	public IGooglePurchase purchase; // 0x18

	// Methods

	// RVA: 0x16796B0
	public void .ctor() { }

	// RVA: 0x167977C
	internal void <FinishTransactionForPurchase>b__0(IGoogleBillingResult result) { }

	// RVA: 0x16797A8
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

	// RVA: 0x16797D4
	private void MoveNext() { }

	// RVA: 0x1679BF8
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

	// RVA: 0x1679C78
	private void MoveNext() { }

	// RVA: 0x167A038
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleFinishTransactionService
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGoogleQueryPurchasesService m_GoogleQueryPurchasesService; // 0x18

	// Methods

	// RVA: 0x1679178
	internal void .ctor(IGoogleBillingClient billingClient, IGoogleQueryPurchasesService googleQueryPurchasesService) { }

	// RVA: 0x16791C8
	public void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

	// RVA: 0x16792DC
	private System.Threading.Tasks.Task<UnityEngine.Purchasing.Interfaces.IGooglePurchase> FindPurchase(string purchaseToken) { }

	// RVA: 0x1679408
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

	// RVA: 0x167A044
	public string get_LastKnownOldProductId() { }

	// RVA: 0x167A04C
	public void set_LastKnownOldProductId(string value) { }

	// RVA: 0x167A054
	public string get_LastKnownProductId() { }

	// RVA: 0x167A05C
	public void set_LastKnownProductId(string value) { }

	// RVA: 0x167A064
	public System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> get_LastKnownProrationMode() { }

	// RVA: 0x167A06C
	public void set_LastKnownProrationMode(System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> value) { }

	// RVA: 0x167A074
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass21_0
{
	// Fields
	public GooglePlayStoreService <>4__this; // 0x10
	public Action ActionToRetry; // 0x18

	// Methods

	// RVA: 0x167A934
	public void .ctor() { }

	// RVA: 0x167BAE0
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

	// RVA: 0x167BB04
	private void MoveNext() { }

	// RVA: 0x167BDC4
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

	// RVA: 0x167BDD0
	private void MoveNext() { }

	// RVA: 0x167C1C4
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

	// RVA: 0x167A0F4
	internal void .ctor(IGoogleBillingClient billingClient, IQueryProductDetailsService queryProductDetailsService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionService finishTransactionService, IGoogleQueryPurchasesService queryPurchasesService, IBillingClientStateListener billingClientStateListener, IGoogleLastKnownProductService lastKnownProductService, ITelemetryDiagnostics telemetryDiagnostics, ILogger logger, IRetryPolicy retryPolicy, IUtil util) { }

	// RVA: 0x167A2E4
	internal void InitConnectionWithGooglePlay() { }

	// RVA: 0x167A528
	private void StartConnection() { }

	// RVA: 0x167A5F4
	public void ResumeConnection() { }

	// RVA: 0x167A6C0
	private void AttemptReconnection() { }

	// RVA: 0x167A7D4
	private bool AreConnectionAttemptsExhausted() { }

	// RVA: 0x167A7E4
	private void RetryConnection(Action ActionToRetry) { }

	// RVA: 0x167A93C
	private void RetryConnectionAttempt(Action ActionToRetry) { }

	// RVA: 0x167AAD4
	private void OnConnected() { }

	// RVA: 0x167AB10
	protected virtual void DequeueQueryProducts(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x167B078
	protected virtual void DequeueFetchPurchases() { }

	// RVA: 0x167B274
	private void OnDisconnected(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x167B2A0
	public virtual void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x167B420
	private void HandleRetrieveProductsNotConnected(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x167B5AC
	public void Purchase(ProductDefinition product) { }

	// RVA: 0x167B5C4
	public virtual void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x167B848
	public void FinishTransaction(ProductDefinition product, string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,UnityEngine.Purchasing.Interfaces.IGooglePurchase> onTransactionFinished) { }

	// RVA: 0x167B1A0
	public void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed) { }

	// RVA: 0x167B914
	private Task TryFetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> onQueryPurchaseSucceed) { }

	// RVA: 0x167BA1C
	public IGooglePurchase GetPurchase(string purchaseToken, string skuType) { }

	// RVA: 0x167BADC
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

	// RVA: 0x167C410
	public void .ctor() { }

	// RVA: 0x167CE84
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

	// RVA: 0x167C230
	internal void .ctor(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQueryProductDetailsService queryProductDetailsService) { }

	// RVA: 0x167C294
	public void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x167C418
	private void OnQueryProductDetailsResponse(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> productDetailsList, ProductDefinition productToBuy, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x167C4CC
	private bool ValidateQueryProductDetailsResponseParams(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus, ProductDefinition productToBuy, Product oldProduct) { }

	// RVA: 0x167C6F8
	private bool ValidateSkus(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus) { }

	// RVA: 0x167CA04
	private static void VerifyAndWarnIfMoreThanOneSku(System.Collections.Generic.List<UnityEngine.AndroidJavaObject> skus) { }

	// RVA: 0x167C75C
	private void PurchaseFailedSkuNotFound(ProductDefinition productToBuy) { }

	// RVA: 0x167C864
	private bool ValidateOldProduct(Product oldProduct) { }

	// RVA: 0x167C8D0
	private void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, Product oldProduct) { }

	// RVA: 0x167C5E0
	private void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x167CBA4
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

	// RVA: 0x167D510
	private static void .cctor() { }

	// RVA: 0x167D57C
	public void .ctor() { }

	// RVA: 0x167D584
	internal System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> <QueryPurchases>b__3_0(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> result) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public GoogleQueryPurchasesService <>4__this; // 0x10
	public System.Threading.Tasks.TaskCompletionSource<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> taskCompletion; // 0x18

	// Methods

	// RVA: 0x167D258
	public void .ctor() { }

	// RVA: 0x167D58C
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

	// RVA: 0x167D45C
	public void .ctor() { }

	// RVA: 0x167D7C4
	internal void <GetPurchaseByToken>b__0(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

	// RVA: 0x167D9F8
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

	// RVA: 0x167DB38
	private void MoveNext() { }

	// RVA: 0x167E014
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleQueryPurchasesService
{
	// Fields
	private readonly IGoogleBillingClient m_BillingClient; // 0x10
	private readonly IGooglePurchaseBuilder m_PurchaseBuilder; // 0x18

	// Methods

	// RVA: 0x167CF38
	internal void .ctor(IGoogleBillingClient billingClient, IGooglePurchaseBuilder purchaseBuilder) { }

	// RVA: 0x167CF88
	public System.Threading.Tasks.Task<System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchases() { }

	// RVA: 0x167D0A0
	private System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase>> QueryPurchasesWithSkuType(string skuType) { }

	// RVA: 0x167D260
	public IGooglePurchase GetPurchaseByToken(string purchaseToken, string skuType) { }

	// RVA: 0x167D464
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

	// RVA: 0x167E094
	internal void .ctor() { }

	// RVA: 0x167E110
	public void RegisterOnConnected(Action onConnected) { }

	// RVA: 0x167E118
	public void RegisterOnDisconnected(System.Action<UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onDisconnected) { }

	// RVA: 0x167E120
	public void onBillingSetupFinished(AndroidJavaObject billingResult) { }

	// RVA: 0x167E2C8
	public void onBillingServiceDisconnected() { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleAcknowledgePurchaseListener
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse; // 0x20

	// Methods

	// RVA: 0x167E308
	internal void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledgePurchaseResponseAction) { }

	// RVA: 0x167E398
	private void onAcknowledgePurchaseResponse(AndroidJavaObject billingResult) { }

}

// Namespace: UnityEngine.Purchasing
internal class GoogleConsumeResponseListener
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse; // 0x20

	// Methods

	// RVA: 0x167E42C
	internal void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsumeResponseAction) { }

	// RVA: 0x167E4BC
	private void onConsumeResponse(AndroidJavaObject billingResult, string purchaseToken) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePurchasesResponseListener
{
	// Fields
	private readonly System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> m_OnQueryPurchasesResponse; // 0x20

	// Methods

	// RVA: 0x167E550
	internal void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse) { }

	// RVA: 0x167E5E0
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

	// RVA: 0x16811D8
	private void MoveNext() { }

	// RVA: 0x1681470
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

	// RVA: 0x167E84C
	internal void .ctor(IGoogleLastKnownProductService googleLastKnownProductService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePurchaseBuilder purchaseBuilder, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, IGoogleQueryPurchasesService googleQueryPurchasesService) { }

	// RVA: 0x167E958
	public void SetGoogleQueryPurchaseService(IGoogleQueryPurchasesService googleFetchPurchases) { }

	// RVA: 0x167E960
	public void onPurchasesUpdated(AndroidJavaObject billingResult, AndroidJavaObject javaPurchasesList) { }

	// RVA: 0x167EC50
	internal void OnPurchasesUpdated(IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x167EEE8
	private void HandleResultOkCases(IGoogleBillingResult result, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x167F210
	private void HandleErrorCases(IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x167F2E8
	private void HandleErrorGoogleBillingResult(IGoogleBillingResult billingResult) { }

	// RVA: 0x167FD54
	private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult) { }

	// RVA: 0x167FE28
	private void HandleUserCancelledPurchaseFailure(IGoogleBillingResult billingResult, System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases) { }

	// RVA: 0x167EFC0
	private void ApplyOnPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase> action) { }

	// RVA: 0x167F9EC
	private void ApplyOnPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases, IGoogleBillingResult billingResult, System.Action<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.String> action) { }

	// RVA: 0x167FF90
	private void OnPurchaseOk(IGooglePurchase googlePurchase) { }

	// RVA: 0x1680644
	private void HandlePurchasedProduct(IGooglePurchase googlePurchase) { }

	// RVA: 0x16808FC
	private bool IsDeferredSubscriptionChange(IGooglePurchase googlePurchase) { }

	// RVA: 0x1680A60
	private bool IsLastProrationModeDeferred() { }

	// RVA: 0x168044C
	private void OnPurchaseCancelled(IGoogleBillingResult billingResult) { }

	// RVA: 0x1680C04
	private void OnPurchaseCancelled(IGooglePurchase googlePurchase) { }

	// RVA: 0x1680D84
	private void OnPurchaseAlreadyOwned(IGooglePurchase googlePurchase) { }

	// RVA: 0x1680F04
	private void OnPurchaseFailed(IGooglePurchase googlePurchase, string debugMessage) { }

	// RVA: 0x168109C
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

	// RVA: 0x16816A0
	public void .ctor() { }

	// RVA: 0x16816A8
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

	// RVA: 0x168147C
	internal void .ctor(System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x168153C
	public void onProductDetailsResponse(AndroidJavaObject billingResult, AndroidJavaObject productDetails) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public MetricizedGooglePlayStoreService <>4__this; // 0x10
	public GoogleBillingResponseCode googleBillingResponseCode; // 0x18

	// Methods

	// RVA: 0x1681BE0
	public void .ctor() { }

	// RVA: 0x1682094
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

	// RVA: 0x1681ED0
	public void .ctor() { }

	// RVA: 0x16820B8
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

	// RVA: 0x1682080
	public void .ctor() { }

	// RVA: 0x16820E0
	internal void <Purchase>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedGooglePlayStoreService
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x80
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x88

	// Methods

	// RVA: 0x1681A04
	internal void .ctor(IGoogleBillingClient billingClient, IQueryProductDetailsService queryProductDetailsService, IGooglePurchaseService purchaseService, IGoogleFinishTransactionService finishTransactionService, IGoogleQueryPurchasesService queryPurchasesService, IBillingClientStateListener billingClientStateListener, IGoogleLastKnownProductService lastKnownProductService, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService, ILogger logger, IRetryPolicy retryPolicy, IUtil util) { }

	// RVA: 0x1681A68
	protected override void DequeueQueryProducts(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x1681BE8
	protected override void DequeueFetchPurchases() { }

	// RVA: 0x1681D1C
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x1681ED8
	public override void Purchase(ProductDefinition product, Product oldProduct, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> desiredProrationMode) { }

	// RVA: 0x1682088
	private void <>n__0(GoogleBillingResponseCode googleBillingResponseCode) { }

	// RVA: 0x168208C
	private void <>n__1(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived, System.Action<UnityEngine.Purchasing.Models.GoogleRetrieveProductsFailureReason,UnityEngine.Purchasing.Models.GoogleBillingResponseCode> onRetrieveProductsFailed) { }

	// RVA: 0x1682090
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

	// RVA: 0x1682F28
	private static void .cctor() { }

	// RVA: 0x1682F94
	public void .ctor() { }

	// RVA: 0x1682F9C
	internal AndroidJavaObject <AddResponse>b__2_0(AndroidJavaObject product) { }

	// RVA: 0x1682FB8
	internal bool <ProductDetails>b__3_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x1683064
	internal System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> <ProductDetails>b__3_1(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x168306C
	internal IGoogleBillingResult <IsRecoverable>b__4_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x1683074
	internal IGoogleBillingResult <GetGoogleBillingResult>b__5_0(System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> response) { }

	// RVA: 0x168307C
	internal bool <GetGoogleBillingResult>b__5_1(IGoogleBillingResult response) { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductDetailsQueryResponse
{
	// Fields
	private readonly System.Collections.Concurrent.ConcurrentBag<System.ValueTuple<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>>> m_Responses; // 0x10

	// Methods

	// RVA: 0x1682108
	protected override void Finalize() { }

	// RVA: 0x1682634
	public void AddResponse(IGoogleBillingResult billingResult, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

	// RVA: 0x16827DC
	public System.Collections.Generic.List<UnityEngine.AndroidJavaObject> ProductDetails() { }

	// RVA: 0x16829E0
	public bool IsRecoverable() { }

	// RVA: 0x1682B5C
	public IGoogleBillingResult GetGoogleBillingResult() { }

	// RVA: 0x1682D70
	private static bool IsRecoverable(IGoogleBillingResult billingResult) { }

	// RVA: 0x1682E9C
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

	// RVA: 0x1683128
	internal void .ctor(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, System.Action<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> onProductDetailsResponseConsolidated) { }

	// RVA: 0x1683250
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

	// RVA: 0x1684630
	private static void .cctor() { }

	// RVA: 0x168469C
	public void .ctor() { }

	// RVA: 0x16846A4
	internal bool <AreAllProductDetailsCached>b__14_0(bool isCached) { }

	// RVA: 0x16846AC
	internal bool <QueryInAppsAsync>b__16_0(ProductDefinition product) { }

	// RVA: 0x16846D0
	internal string <QueryInAppsAsync>b__16_1(ProductDefinition product) { }

	// RVA: 0x16846EC
	internal bool <QuerySubsAsync>b__17_0(ProductDefinition product) { }

	// RVA: 0x1684710
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

	// RVA: 0x1683858
	public void .ctor() { }

	// RVA: 0x168472C
	internal void <QueryAsyncProduct>b__0(Action retryAction) { }

	// RVA: 0x1684754
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

	// RVA: 0x1683AEC
	public void .ctor() { }

	// RVA: 0x168481C
	internal void <TryQueryAsyncProductWithRetries>b__0(IProductDetailsQueryResponse productDetailsQueryResponse) { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse; // 0x10
	public QueryProductDetailsService <>4__this; // 0x18

	// Methods

	// RVA: 0x1683850
	public void .ctor() { }

	// RVA: 0x1684B0C
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

	// RVA: 0x1683414
	internal void .ctor(IGoogleBillingClient billingClient, IGoogleCachedQueryProductDetailsService googleCachedQueryProductDetailsService, IProductDetailsConverter productDetailsConverter, IRetryPolicy retryPolicy, IGoogleProductCallback googleProductCallback, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x16834D8
	public void QueryAsyncProduct(ProductDefinition product, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x1683768
	public void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x16835B4
	public void QueryAsyncProduct(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse) { }

	// RVA: 0x1683860
	private void QueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, Action retryQuery) { }

	// RVA: 0x1683988
	private void TryQueryAsyncProductWithRetries(System.Collections.Generic.IReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Collections.Generic.List<UnityEngine.AndroidJavaObject>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductDetailsResponse, Action retryQuery) { }

	// RVA: 0x1683F4C
	private bool ShouldRetryQuery(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> requestedProducts, IProductDetailsQueryResponse queryResponse) { }

	// RVA: 0x1684038
	private bool AreAllProductDetailsCached(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1684224
	private System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> GetCachedProductDetails(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1683AF4
	private void QueryInAppsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, IProductDetailsResponseConsolidator consolidator) { }

	// RVA: 0x1683D20
	private void QuerySubsAsync(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products, IProductDetailsResponseConsolidator consolidator) { }

	// RVA: 0x16843BC
	private void QueryProductDetails(System.Collections.Generic.List<System.String> productList, string type, IProductDetailsResponseConsolidator consolidator) { }

}

// Namespace: UnityEngine.Purchasing
public class FakeGooglePlayStoreConfiguration
{
	// Methods

	// RVA: 0x1684BFC
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class FakeGooglePlayStoreExtensions
{
	// Methods

	// RVA: 0x1684C04
	public bool IsPurchasedProductDeferred(Product product) { }

	// RVA: 0x1684C0C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public static class GetGoogleProductMetadataExtension
{
	// Methods

	// RVA: 0x1684C14
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

	// RVA: 0x1684C98
	public void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x1684CD4
	public void NotifyInitializationConnectionFailed() { }

	// RVA: 0x1684CF0
	public void NotifyQueryProductDetailsFailed(int retryCount) { }

	// RVA: 0x1684D28
	public void NotifyDeferredProrationUpgradeDowngradeSubscription(IStoreCallback storeCallback, string productId) { }

	// RVA: 0x1684F4C
	public bool IsFetchPurchasesAtInitializeSkipped() { }

	// RVA: 0x1684F5C
	public bool DoesRetrievePurchasesExcludeDeferred() { }

	// RVA: 0x1684F64
	public void NotifyDeferredPurchase(IStoreCallback storeCallback, IGooglePurchase purchase, string receipt, string transactionId) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayProductCallback
{
	// Fields
	private IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x10

	// Methods

	// RVA: 0x16850B4
	public void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: 0x16850BC
	public void NotifyQueryProductDetailsFailed(int retryCount) { }

	// RVA: 0x1685180
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

	// RVA: 0x16855A4
	public void .ctor() { }

	// RVA: 0x1685704
	internal void <NotifyDeferredPurchase>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public GooglePlayPurchaseCallback <>4__this; // 0x10
	public string sku; // 0x18

	// Methods

	// RVA: 0x16856FC
	public void .ctor() { }

	// RVA: 0x16857F4
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

	// RVA: 0x1685188
	public void .ctor(IUtil util) { }

	// RVA: 0x16851BC
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x16851C4
	public void SetStoreConfiguration(IGooglePlayConfigurationInternal configuration) { }

	// RVA: 0x16851CC
	public void OnPurchaseSuccessful(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: 0x1685360
	public void OnPurchaseFailed(PurchaseFailureDescription purchaseFailureDescription) { }

	// RVA: 0x1685424
	public void NotifyDeferredPurchase(IGooglePurchase purchase, string receipt, string purchaseToken) { }

	// RVA: 0x16855AC
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

	// RVA: 0x16858CC
	public void .ctor(IGooglePlayStoreRetrieveProductsService retrieveProductsService, IGooglePlayStorePurchaseService storePurchaseService, IGoogleFetchPurchases fetchPurchases, IGooglePlayStoreFinishTransactionService transactionService, IGooglePurchaseCallback googlePurchaseCallback, IGooglePlayConfigurationInternal googlePlayConfigurationInternal, IGooglePlayStoreExtensionsInternal googlePlayStoreExtensions, IUtil util) { }

	// RVA: 0x16859AC
	public override void Initialize(IStoreCallback callback) { }

	// RVA: 0x1685D38
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1685F74
	private bool HasInitiallyRetrievedProducts() { }

	// RVA: 0x1685E00
	private bool ShouldFetchPurchasesNext() { }

	// RVA: 0x168602C
	public override void Purchase(ProductDefinition product, string dummy) { }

	// RVA: 0x16860E0
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x16861A0
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

	// RVA: 0x1686304
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider, ILogger logger, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x1686384
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x168638C
	public bool IsPurchasedProductDeferred(Product product) { }

	// RVA: 0x1686508
	private bool TryIsPurchasedProductDeferred(Product product) { }

	// RVA: 0x1686528
	public GooglePurchaseState GetPurchaseState(Product product) { }

	// RVA: 0x1686750
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

	// RVA: 0x1686840
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

	// RVA: 0x16868D4
	public string get_originalJson() { }

	// RVA: 0x16868DC
	internal void set_originalJson(string value) { }

	// RVA: 0x16868E4
	internal void set_subscriptionPeriod(string value) { }

	// RVA: 0x16868EC
	internal void set_freeTrialPeriod(string value) { }

	// RVA: 0x16868F4
	internal void set_introductoryPrice(string value) { }

	// RVA: 0x16868FC
	internal void set_introductoryPricePeriod(string value) { }

	// RVA: 0x1686904
	internal void set_introductoryPriceCycles(int value) { }

	// RVA: 0x168690C
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

	// RVA: 0x1687A2C
	private static void .cctor() { }

	// RVA: 0x1687A98
	public void .ctor() { }

	// RVA: 0x1687AA0
	internal bool <PurchaseIsPurchased>b__11_0(IGooglePurchase purchase) { }

	// RVA: 0x1687B54
	internal bool <PurchaseIsPending>b__12_0(IGooglePurchase purchase) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public GoogleFetchPurchases <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases; // 0x18

	// Methods

	// RVA: 0x16872B4
	public void .ctor() { }

	// RVA: 0x1687C08
	internal void <OnFetchedPurchase>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed; // 0x10
	public GoogleFetchPurchases <>4__this; // 0x18

	// Methods

	// RVA: 0x1686BB4
	public void .ctor() { }

	// RVA: 0x1687C2C
	internal void <FetchPurchases>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> googlePurchases) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public GoogleFetchPurchases <>4__this; // 0x10
	public IGooglePurchase purchase; // 0x18

	// Methods

	// RVA: 0x1686EAC
	public void .ctor() { }

	// RVA: 0x1687C70
	internal Product <BuildProductsFromPurchase>b__0(string sku) { }

	// RVA: 0x1687C9C
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

	// RVA: 0x1686914
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService, IUtil util) { }

	// RVA: 0x1686964
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x168696C
	public void FetchPurchases() { }

	// RVA: 0x1686A64
	public void FetchPurchases(System.Action<System.Collections.Generic.List<UnityEngine.Purchasing.Product>> onQueryPurchaseSucceed) { }

	// RVA: 0x1686BBC
	private System.Collections.Generic.List<UnityEngine.Purchasing.Product> FillProductsWithPurchases(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x1686C88
	private System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> BuildProductsFromPurchase(IGooglePurchase purchase) { }

	// RVA: 0x1686EB4
	private static Product CompleteProductInfoWithPurchase(Product product, IGooglePurchase purchase) { }

	// RVA: 0x1687038
	private void OnFetchedPurchase(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> purchases) { }

	// RVA: 0x16872BC
	private static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> PurchaseIsPurchased() { }

	// RVA: 0x16873C4
	private static System.Func<UnityEngine.Purchasing.Interfaces.IGooglePurchase,System.Boolean> PurchaseIsPending() { }

	// RVA: 0x16874CC
	private void UpdateDeferredProductsByPurchases(System.Collections.Generic.List<UnityEngine.Purchasing.Interfaces.IGooglePurchase> deferredPurchases) { }

	// RVA: 0x1687690
	private void UpdateDeferredProductsByPurchase(IGooglePurchase deferredPurchase) { }

	// RVA: 0x16878D4
	private void UpdateDeferredProduct(IGooglePurchase deferredPurchase, string sku) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public GooglePlayStoreFinishTransactionService <>4__this; // 0x10
	public ProductDefinition product; // 0x18

	// Methods

	// RVA: 0x1687EC8
	public void .ctor() { }

	// RVA: 0x16887BC
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

	// RVA: 0x1687CAC
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x1687D54
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x1687D5C
	public void FinishTransaction(ProductDefinition product, string purchaseToken) { }

	// RVA: 0x1687ED0
	private void HandleFinishTransaction(ProductDefinition product, IGoogleBillingResult billingResult, IGooglePurchase purchase) { }

	// RVA: 0x16883B4
	private void CallPurchaseSucceededUpdateReceipt(IGooglePurchase googlePurchase) { }

	// RVA: 0x1688610
	private static bool IsResponseCodeInRecoverableState(IGoogleBillingResult billingResult) { }

}

// Namespace: UnityEngine.Purchasing
internal class GooglePlayStorePurchaseService
{
	// Fields
	private readonly IGooglePlayStoreService m_GooglePlayStoreService; // 0x10

	// Methods

	// RVA: 0x16887E8
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService) { }

	// RVA: 0x168881C
	public void Purchase(ProductDefinition product) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public GooglePlayStoreRetrieveProductsService <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts; // 0x18

	// Methods

	// RVA: 0x1688DC8
	public void .ctor() { }

	// RVA: 0x16898FC
	internal void <OnProductsRetrievedWithPurchaseFetch>b__0(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchaseProducts) { }

}

// Namespace: 
private sealed class <>c__DisplayClass14_0
{
	// Fields
	public Product purchaseProduct; // 0x10

	// Methods

	// RVA: 0x1689838
	public void .ctor() { }

	// RVA: 0x16899E4
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

	// RVA: 0x16888D4
	internal void .ctor(IGooglePlayStoreService googlePlayStoreService, IGoogleFetchPurchases googleFetchPurchases, IGooglePlayConfigurationInternal googlePlayConfigurationInternal, IGooglePlayStoreExtensions googlePlayStoreExtensions) { }

	// RVA: 0x168895C
	public void SetStoreCallback(IStoreCallback storeCallback) { }

	// RVA: 0x1688964
	public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, bool wantPurchases) { }

	// RVA: 0x1688B50
	private void OnProductsRetrievedWithPurchaseFetch(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, IGoogleBillingResult billingResult) { }

	// RVA: 0x1688FB0
	private void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, IGoogleBillingResult billingResult) { }

	// RVA: 0x1688DD0
	private void OnRetrieveProductsFailed(GoogleRetrieveProductsFailureReason reason, GoogleBillingResponseCode responseCode) { }

	// RVA: 0x1689194
	public void ResumeConnection() { }

	// RVA: 0x168924C
	private System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> MakePurchasesIntoProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> retrievedProducts, System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Product> purchaseProducts) { }

	// RVA: 0x1689840
	private bool IsPurchasedProductDeferred(Product product) { }

	// RVA: 0x16898F4
	public bool HasInitiallyRetrievedProducts() { }

}

// Namespace: UnityEngine.Purchasing
public static class StoreCallbackExtensionMethods
{
	// Methods

	// RVA: 0x1684D78
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

	// RVA: 0x1689A18
	public void .ctor(IUnityCallback forwardTo) { }

}

// Namespace: UnityEngine.Purchasing
internal static class SerializationExtensions
{
	// Methods

	// RVA: 0x1677D58
	public static string TryGetString(System.Collections.Generic.Dictionary<System.String,System.Object> dic, string key) { }

}

// Namespace: UnityEngine.Purchasing
internal class JSONSerializer
{
	// Methods

	// RVA: 0x1689AA8
	public static string SerializeProductDef(ProductDefinition product) { }

	// RVA: 0x168A364
	public static string SerializeProductDefs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x168A68C
	public static string SerializeProductDescs(System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x168ABBC
	public static PurchaseFailureDescription DeserializeFailureReason(string json) { }

	// RVA: 0x168AF54
	private static string BuildPurchaseFailureDescriptionMessage(System.Collections.Generic.Dictionary<System.String,System.Object> dic) { }

	// RVA: 0x1689AC0
	private static System.Collections.Generic.Dictionary<System.String,System.Object> EncodeProductDef(ProductDefinition product) { }

	// RVA: 0x168A9B4
	private static System.Collections.Generic.Dictionary<System.String,System.Object> EncodeProductDesc(ProductDescription product) { }

	// RVA: 0x168B020
	private static System.Collections.Generic.Dictionary<System.String,System.Object> EncodeProductMeta(ProductMetadata product) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public PurchaseFailureDescription desc; // 0x18

	// Methods

	// RVA: 0x168B998
	public void .ctor() { }

	// RVA: 0x168B9A0
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

	// RVA: 0x168B408
	public void .ctor() { }

	// RVA: 0x168BA6C
	internal void <OnSetupFailed>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products; // 0x18

	// Methods

	// RVA: 0x168B560
	public void .ctor() { }

	// RVA: 0x168BB34
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

	// RVA: 0x168B6E8
	public void .ctor() { }

	// RVA: 0x168BC00
	internal void <OnPurchaseSucceeded>b__0() { }

}

// Namespace: 
private sealed class <>c__DisplayClass9_0
{
	// Fields
	public ScriptingStoreCallback <>4__this; // 0x10
	public System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts; // 0x18

	// Methods

	// RVA: 0x168B840
	public void .ctor() { }

	// RVA: 0x168BCCC
	internal void <OnAllPurchasesRetrieved>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class ScriptingStoreCallback
{
	// Fields
	private readonly IStoreCallback m_ForwardTo; // 0x10
	private readonly IUtil m_Util; // 0x18

	// Methods

	// RVA: 0x1685CE8
	public void .ctor(IStoreCallback forwardTo, IUtil util) { }

	// RVA: 0x168B1FC
	public ProductCollection get_products() { }

	// RVA: 0x168B2B0
	public void OnSetupFailed(InitializationFailureReason reason, string message) { }

	// RVA: 0x168B410
	public void OnProductsRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> products) { }

	// RVA: 0x168B568
	public void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	// RVA: 0x168B6F0
	public void OnAllPurchasesRetrieved(System.Collections.Generic.List<UnityEngine.Purchasing.Product> purchasedProducts) { }

	// RVA: 0x168B848
	public void OnPurchaseFailed(PurchaseFailureDescription desc) { }

}

// Namespace: UnityEngine.Purchasing
internal class ScriptingUnityCallback
{
	// Fields
	private readonly IUnityCallback forwardTo; // 0x10
	private readonly IUtil util; // 0x18

	// Methods

	// RVA: 0x168BD98
	public void .ctor(IUnityCallback forwardTo, IUtil util) { }

}

// Namespace: UnityEngine.Purchasing
public class FakeUDPExtension
{
	// Methods

	// RVA: 0x168BDE8
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

	// RVA: 0x168BDF0
	public static string get_Name() { }

}

// Namespace: UnityEngine.Purchasing
internal class UDPBindings
{
	// Fields
	private readonly object m_Bridge; // 0x10
	private System.Action<System.Boolean,System.String> m_RetrieveProductsCallbackCache; // 0x18

	// Methods

	// RVA: 0x168C0FC
	public void .ctor() { }

	// RVA: 0x168C314
	public void Initialize(System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x168C4D0
	public void Purchase(string productId, System.Action<System.Boolean,System.String> callback, string developerPayload) { }

	// RVA: 0x168C704
	public void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products, System.Action<System.Boolean,System.String> callback) { }

	// RVA: 0x168CC90
	public void FinishTransaction(ProductDefinition productDefinition, string transactionID) { }

	// RVA: 0x168CE4C
	private void OnInventoryQueried(bool success, object payload) { }

	// RVA: 0x168E234
	public void RetrieveProducts(string json) { }

	// RVA: 0x168E274
	public void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x168E2B4
	public void FinishTransaction(string productJSON, string transactionID) { }

	// RVA: 0x168E03C
	internal static System.Collections.Generic.Dictionary<System.String,System.String> StringPropertyToDictionary(object info) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0
{
	// Fields
	public UDPImpl <>4__this; // 0x10
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x168E504
	public void .ctor() { }

	// RVA: 0x168EB08
	internal void <RetrieveProducts>g__retrieveCallback|0(bool success, string json) { }

	// RVA: 0x168EBC4
	internal void <RetrieveProducts>b__1(bool success, string message) { }

}

// Namespace: 
private sealed class <>c__DisplayClass11_0
{
	// Fields
	public ProductDefinition product; // 0x10
	public UDPImpl <>4__this; // 0x18

	// Methods

	// RVA: 0x168E678
	public void .ctor() { }

	// RVA: 0x168EFD4
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

	// RVA: 0x168E2F4
	public void SetNativeStore(INativeUDPStore nativeUdpStore) { }

	// RVA: 0x168E2FC
	public override void Initialize(IStoreCallback callback) { }

	// RVA: 0x168E304
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x168E50C
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x168E680
	private void OnPurchaseDeferred(string productId) { }

	// RVA: 0x168E7AC
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x168E88C
	private static void DictionaryToStringProperty(System.Collections.Generic.Dictionary<System.String,System.Object> dic, object info) { }

	// RVA: 0x168EA08
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Assembly assembly; // 0x10

	// Methods

	// RVA: 0x168FEEC
	public void .ctor() { }

	// RVA: 0x1690224
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

	// RVA: 0x168F6C8
	internal static Type GetTypeByName(string typeName) { }

	// RVA: 0x168FEC8
	private static System.Collections.Generic.IEnumerable<System.Reflection.Assembly> GetAllAssemblies() { }

	// RVA: 0x168FEF4
	private static System.Collections.Generic.IEnumerable<System.Type> GetTypes(Assembly assembly) { }

	// RVA: 0x169001C
	private static void .cctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class InventoryInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x168DC00
	internal static Type GetClassType() { }

	// RVA: 0x168DD24
	internal static MethodInfo GetProductListMethod() { }

	// RVA: 0x168DFE4
	internal static MethodInfo GetPurchaseInfoMethod() { }

	// RVA: 0x168DF8C
	internal static MethodInfo HasPurchaseMethod() { }

}

// Namespace: UnityEngine.Purchasing
internal class ProductInfoInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x1690264
	private static Type GetClassType() { }

	// RVA: 0x168DE84
	public static PropertyInfo GetCurrencyProp() { }

	// RVA: 0x168DE2C
	public static PropertyInfo GetDescriptionProp() { }

	// RVA: 0x168DD7C
	public static PropertyInfo GetPriceProp() { }

	// RVA: 0x168DEDC
	public static PropertyInfo GetPriceAmountMicrosProp() { }

	// RVA: 0x168DF34
	public static PropertyInfo GetProductIdProp() { }

	// RVA: 0x168DDD4
	public static PropertyInfo GetTitleProp() { }

}

// Namespace: UnityEngine.Purchasing
internal class StoreServiceInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x1690388
	internal static Type GetClassType() { }

	// RVA: 0x16904AC
	private static PropertyInfo GetNameProp() { }

	// RVA: 0x168C030
	internal static string GetName() { }

}

// Namespace: UnityEngine.Purchasing
internal class UdpIapBridgeInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x168C1F0
	internal static Type GetClassType() { }

	// RVA: 0x168C478
	internal static MethodInfo GetInitMethod() { }

	// RVA: 0x168C6AC
	internal static MethodInfo GetPurchaseMethod() { }

	// RVA: 0x168CC38
	internal static MethodInfo GetRetrieveProductsMethod() { }

	// RVA: 0x168CDF4
	internal static MethodInfo GetFinishTransactionMethod() { }

}

// Namespace: UnityEngine.Purchasing
internal class UserInfoInterface
{
	// Fields
	private static Type s_typeCache; // 0x0

	// Methods

	// RVA: 0x168EEB0
	internal static Type GetClassType() { }

}

// Namespace: UnityEngine.Purchasing
internal class AppleJsonProductDescriptionsDeserializer
{
	// Methods

	// RVA: 0x169050C
	internal override ProductMetadata DeserializeMetadata(System.Collections.Generic.Dictionary<System.String,System.Object> data) { }

	// RVA: 0x169066C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class AppleProductMetadata
{
	// Fields
	private readonly bool <isFamilyShareable>k__BackingField; // 0x40

	// Methods

	// RVA: 0x16905EC
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

	// RVA: 0x1694864
	private static void .cctor() { }

	// RVA: 0x16948D0
	public void .ctor() { }

	// RVA: 0x16948D8
	internal int <FindMostRecentReceipt>b__39_1(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

	// RVA: 0x1694968
	internal string <OnFetchStorePromotionVisibilitySucceeded>b__62_0(System.Collections.Generic.KeyValuePair<System.String,System.Object> k) { }

	// RVA: 0x1694A30
	internal string <OnFetchStorePromotionVisibilitySucceeded>b__62_1(System.Collections.Generic.KeyValuePair<System.String,System.Object> k) { }

}

// Namespace: 
private sealed class <>c__DisplayClass39_0
{
	// Fields
	public string productId; // 0x10

	// Methods

	// RVA: 0x1692340
	public void .ctor() { }

	// RVA: 0x1694B10
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

	// RVA: 0x169336C
	public void .ctor() { }

	// RVA: 0x1694B38
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

	// RVA: 0x1690848
	protected void .ctor(IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x1690984
	public void SetNativeStore(INativeAppleStore apple) { }

	// RVA: 0x1690AA0
	public string get_appReceipt() { }

	// RVA: 0x1690C94
	private System.Nullable<System.Double> get_appReceiptModificationDate() { }

	// RVA: 0x1690D8C
	public string GetTransactionReceiptForProduct(Product product) { }

	// RVA: 0x1690E9C
	public override void OnProductsRetrieved(string json) { }

	// RVA: 0x1691284
	private bool HasInAppPurchaseReceipts(AppleReceipt appleReceipt) { }

	// RVA: 0x16912A8
	private System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> EnrichProductDescriptions(System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> productDescriptions, AppleReceipt appleReceipt) { }

	// RVA: 0x1691808
	private static AppleInAppPurchaseReceipt FindMostRecentReceipt(AppleReceipt appleReceipt, string productId) { }

	// RVA: 0x1692348
	private static AppleInAppPurchaseReceipt FirstNonCancelledReceipt(AppleInAppPurchaseReceipt[] foundReceipts) { }

	// RVA: 0x1692408
	public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback) { }

	// RVA: 0x1692410
	public void OnPurchaseDeferred(string productId) { }

	// RVA: 0x1692518
	public void OnPromotionalPurchaseAttempted(string productId) { }

	// RVA: 0x1692620
	public void OnTransactionsRestoredSuccess() { }

	// RVA: 0x1692690
	public void OnTransactionsRestoredFail(string error) { }

	// RVA: 0x16926FC
	public void OnAppReceiptRetrieved(string receipt) { }

	// RVA: 0x1692718
	public void OnAppReceiptRefreshedFailed(string error) { }

	// RVA: 0x1692734
	private void OnEntitlementsRevoked(string productIds) { }

	// RVA: 0x1692AE4
	private void RevokeEntitlement(AppleReceipt appleReceipt, string productId, System.Collections.Generic.List<UnityEngine.Purchasing.Product> revokedProducts, Product product) { }

	// RVA: 0x1692BA4
	private bool RestoreActiveEntitlement(AppleReceipt appleReceipt, string productId) { }

	// RVA: 0x1692CB4
	public void OnFetchStorePromotionOrderSucceeded(string productIds) { }

	// RVA: 0x1692FF4
	public void OnFetchStorePromotionOrderFailed() { }

	// RVA: 0x1693010
	public void OnFetchStorePromotionVisibilitySucceeded(string result) { }

	// RVA: 0x1693350
	public void OnFetchStorePromotionVisibilityFailed() { }

	// RVA: 0x1690674
	private static void MessageCallback(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	// RVA: 0x1693374
	private void ProcessMessage(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	// RVA: 0x1693BA4
	public void OnPurchaseSucceeded(string id, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

	// RVA: 0x16910EC
	private AppleReceipt GetAppleReceiptFromBase64String(string receipt) { }

	// RVA: 0x1693DB4
	private static bool IsValidPurchaseState(AppleInAppPurchaseReceipt mostRecentReceipt, string productId) { }

	// RVA: 0x1693F2C
	private bool IsRestored(string productId, AppleInAppPurchaseReceipt productReceipt, string transactionId, string originalTransactionId) { }

	// RVA: 0x1694238
	private static bool IsSubscriptionRestored(AppleInAppPurchaseReceipt productReceipt, Product previousProduct) { }

	// RVA: 0x1694218
	private static bool IsNonSubscriptionRestored(string transactionId, string originalTransactionId) { }

	// RVA: 0x169223C
	private void UpdateAppleProductFields(string id, string originalTransactionId, bool isRestored) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeAppleConfiguration
{
	// Methods

	// RVA: 0x1694BB4
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeAppleExtensions
{
	// Methods

	// RVA: 0x1694BBC
	public void RegisterPurchaseDeferredListener(System.Action<UnityEngine.Purchasing.Product> callback) { }

	// RVA: 0x1694BC0
	public string GetTransactionReceiptForProduct(Product product) { }

	// RVA: 0x1694C04
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

	// RVA: 0x1694DC0
	public void .ctor() { }

	// RVA: 0x16951C8
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

	// RVA: 0x1694F68
	public void .ctor() { }

	// RVA: 0x169528C
	internal void <Purchase>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedAppleStoreImpl
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0xD0

	// Methods

	// RVA: 0x1694C0C
	public void .ctor(IUtil util, ITelemetryDiagnostics telemetryDiagnostics, ITelemetryMetricsService telemetryMetricsService) { }

	// RVA: 0x1694C3C
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1694DC8
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x1694F70
	private void <>n__6(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x16950F0
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

	// RVA: 0x168EA88
	public void .ctor() { }

	// RVA: 0x16952B0
	public void SetNativeStore(INativeStore native) { }

	// RVA: 0x16952B8
	private void UnityEngine.Purchasing.IStoreInternal.SetModule(StandardPurchasingModule module) { }

	// RVA: 0x16953BC
	public override void Initialize(IStoreCallback callback) { }

	// RVA: 0x1695030
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x16950F4
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x1694140
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x1693A20
	public void OnSetupFailed(string reason) { }

	// RVA: 0x1695454
	public virtual void OnProductsRetrieved(string json) { }

	// RVA: 0x1694070
	public virtual void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	// RVA: 0x1693D80
	public void OnPurchaseFailed(string json) { }

	// RVA: 0x1695520
	public void OnPurchaseFailed(PurchaseFailureDescription failure, string json) { }

	// RVA: 0x16955F8
	private StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json) { }

}

// Namespace: 
private sealed class <>c__DisplayClass2_0
{
	// Fields
	public MetricizedJsonStore <>4__this; // 0x10
	public System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products; // 0x18

	// Methods

	// RVA: 0x1695A9C
	public void .ctor() { }

	// RVA: 0x1695D10
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

	// RVA: 0x1695C44
	public void .ctor() { }

	// RVA: 0x1695DD4
	internal void <Purchase>b__0() { }

}

// Namespace: UnityEngine.Purchasing
internal class MetricizedJsonStore
{
	// Fields
	private readonly ITelemetryMetricsService m_TelemetryMetricsService; // 0x48

	// Methods

	// RVA: 0x1695884
	public void .ctor(ITelemetryMetricsService telemetryMetricsService) { }

	// RVA: 0x1695918
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1695AA4
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x1695C4C
	private void <>n__0(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> products) { }

	// RVA: 0x1695D0C
	private void <>n__1(ProductDefinition product, string developerPayload) { }

}

// Namespace: UnityEngine.Purchasing
internal class NativeStoreProvider
{
	// Methods

	// RVA: 0x1695DF8
	public INativeStore GetAndroidStore(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util) { }

	// RVA: 0x1695F30
	private INativeStore GetAndroidStoreHelper(IUnityCallback callback, AppStore store, IPurchasingBinder binder, IUtil util) { }

	// RVA: 0x16965E4
	public INativeAppleStore GetStorekit(IUnityCallback callback) { }

	// RVA: 0x16966F8
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

	// RVA: 0x1696700
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

	// RVA: 0x16971E4
	public void .ctor() { }

	// RVA: 0x16972CC
	internal void <StoreRetrieveProducts>g__handleAllowInitializeOrRetrieveProducts|0(bool allow, InitializationFailureReason failureReason) { }

}

// Namespace: 
private sealed class <>c__DisplayClass15_0
{
	// Fields
	public FakeStore <>4__this; // 0x10
	public ProductDefinition product; // 0x18

	// Methods

	// RVA: 0x169795C
	public void .ctor() { }

	// RVA: 0x1697964
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

	// RVA: 0x1696708
	public string get_unavailableProductId() { }

	// RVA: 0x1696710
	public override void Initialize(IStoreCallback biller) { }

	// RVA: 0x16967B0
	public void RetrieveProducts(string json) { }

	// RVA: 0x16968C8
	public void StoreRetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefinitions) { }

	// RVA: 0x169741C
	public void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x1697704
	private void FakePurchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x1697BF4
	public void FinishTransaction(string productJSON, string transactionID) { }

	// RVA: 0x1697BF8
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: -1
	protected virtual bool StartUI(object model, DialogType dialogType, System.Action<System.Boolean,T> callback) { }

	// RVA: 0x1697BFC
	public void .ctor() { }

	// RVA: 0x1697CDC
	private void <>n__0(string id, string receipt, string transactionID) { }

}

// Namespace: UnityEngine.Purchasing
internal class LifecycleNotifier
{
	// Fields
	public Action OnDestroyCallback; // 0x20

	// Methods

	// RVA: 0x1697DAC
	private void OnDestroy() { }

	// RVA: 0x1697DC8
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

	// RVA: 0x1698F38
	private static void .cctor() { }

	// RVA: 0x1698FA4
	public void .ctor() { }

	// RVA: 0x1698FAC
	internal string <CreateRetrieveProductsQuestion>b__20_0(ProductDefinition pid) { }

}

// Namespace: 
private sealed class <>c__DisplayClass10_0<T0>
{
	// Fields
	public System.Action<System.Boolean,T> callback; // 0x0

	// Methods

	// RVA: 0x30A2378
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

	// RVA: 0x1697DD0
	public void .ctor() { }

	// RVA: -1
	protected override bool StartUI(object model, DialogType dialogType, System.Action<System.Boolean,T> callback) { }

	// RVA: 0x1697DD4
	private bool StartUI(string queryText, string okayButtonText, string cancelButtonText, System.Collections.Generic.List<System.String> options, System.Action<System.Boolean,System.Int32> callback) { }

	// RVA: 0x1697EF4
	private void InstantiateDialog() { }

	// RVA: 0x1698090
	private UIFakeStoreWindow GetOrCreateFakeStoreWindow() { }

	// RVA: 0x1698290
	private void AddLifeCycleNotifierAndSetDestroyCallback(GameObject gameObject) { }

	// RVA: 0x169834C
	private void EnsureEventSystemCreated(Transform rootTransform) { }

	// RVA: 0x169841C
	private void ConfigureDialogWindow(UIFakeStoreWindow dialogWindow) { }

	// RVA: 0x1698818
	private void ConfigureDialogWindowCallbacks(UIFakeStoreWindow dialogWindow, bool assignCancelCallback, bool assignDropDownCallback) { }

	// RVA: 0x16984C8
	private void CreateEventSystem(Transform rootTransform) { }

	// RVA: 0x16989F0
	private string CreatePurchaseQuestion(ProductDefinition definition) { }

	// RVA: 0x1698A60
	private string CreateRetrieveProductsQuestion(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> definitions) { }

	// RVA: 0x1698C88
	private void OkayButtonClicked() { }

	// RVA: 0x1698E44
	private void CancelButtonClicked() { }

	// RVA: 0x1698F24
	private void DropdownValueChanged(int selectedItem) { }

	// RVA: 0x1698D64
	private void CloseDialog() { }

	// RVA: 0x1697EE4
	public bool IsShowingDialog() { }

	// RVA: 0x1698F2C
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

	// RVA: 0x1698FC8
	public void DoPopup(int windowID) { }

	// RVA: 0x16993A8
	private void OnOptionSelected(int optionIndex) { }

	// RVA: 0x1699440
	internal void SetOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x16994D0
	internal void SetSelectionAction(System.Action<System.Int32,System.String> onDropdown) { }

	// RVA: 0x16994D8
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

	// RVA: 0x16994E0
	private void OnGUI() { }

	// RVA: 0x16996A8
	private Rect CreateCenteredWindowRect() { }

	// RVA: 0x169972C
	private void DoMainGUI(int windowID) { }

	// RVA: 0x1699BCC
	private void DoDropDown() { }

	// RVA: 0x1699BD8
	private void OnOkClicked() { }

	// RVA: 0x1699BF4
	private void OnCancelClicked() { }

	// RVA: 0x1698658
	internal void ConfigureMainDialogText(string queryText, string okText, string cancelText) { }

	// RVA: 0x16986A8
	internal void ConfigureDropdownOptions(System.Collections.Generic.List<System.String> options) { }

	// RVA: 0x1699C10
	private void OnDropdown(int index, string selectionText) { }

	// RVA: 0x1698988
	internal void AssignCallbacks(Action onOk, Action onCancel, System.Action<System.Int32> onDropdown) { }

	// RVA: 0x1699C78
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

	// RVA: 0x1699CF0
	public void OnBeforeSerialize() { }

	// RVA: 0x1699D80
	public void OnAfterDeserialize() { }

	// RVA: 0x1699DFC
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

	// RVA: 0x1699F88
	private static void .cctor() { }

	// RVA: 0x1699FF4
	public void .ctor() { }

	// RVA: 0x1699FFC
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

	// RVA: 0x16972BC
	public string get_Title() { }

	// RVA: 0x16972C4
	public string get_Description() { }

	// RVA: 0x1699E04
	private static string DecodeNonLatinCharacters(string s) { }

	// RVA: 0x1699F78
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

	// RVA: 0x169A0BC
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

	// RVA: 0x169A18C
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

	// RVA: 0x169A364
	public System.Collections.Generic.ICollection<UnityEngine.Purchasing.ProductCatalogItem> get_allProducts() { }

	// RVA: 0x169A36C
	internal static void Initialize() { }

	// RVA: 0x169A43C
	public static void Initialize(IProductCatalogImpl productCatalogImpl) { }

	// RVA: 0x169A4A0
	public static ProductCatalog Deserialize(string catalogJSON) { }

	// RVA: 0x169A508
	public static ProductCatalog FromTextAsset(TextAsset asset) { }

	// RVA: 0x16971EC
	public static ProductCatalog LoadDefaultCatalog() { }

	// RVA: 0x169A580
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

	// RVA: 0x169A614
	public ProductCatalog LoadDefaultCatalog() { }

	// RVA: 0x169A434
	public void .ctor() { }

}

// Namespace: 
internal class StoreInstance
{
	// Fields
	private readonly string <storeName>k__BackingField; // 0x10
	private readonly IStore <instance>k__BackingField; // 0x18

	// Methods

	// RVA: 0x169D034
	internal string get_storeName() { }

	// RVA: 0x169D03C
	internal IStore get_instance() { }

	// RVA: 0x169B9AC
	internal void .ctor(string name, IStore instance) { }

}

// Namespace: 
private class MicrosoftConfiguration
{
	// Fields
	private readonly StandardPurchasingModule module; // 0x10

	// Methods

	// RVA: 0x169B628
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

	// RVA: 0x169A814
	internal IUtil get_util() { }

	// RVA: 0x169A81C
	private void set_util(IUtil value) { }

	// RVA: 0x169A824
	internal ILogger get_logger() { }

	// RVA: 0x169A82C
	private void set_logger(ILogger value) { }

	// RVA: 0x169A834
	internal StoreInstance get_storeInstance() { }

	// RVA: 0x169A83C
	private void set_storeInstance(StoreInstance value) { }

	// RVA: 0x169A844
	internal ITelemetryMetricsInstanceWrapper get_telemetryMetricsInstanceWrapper() { }

	// RVA: 0x169A84C
	internal void set_telemetryMetricsInstanceWrapper(ITelemetryMetricsInstanceWrapper value) { }

	// RVA: 0x169A854
	internal ITelemetryDiagnosticsInstanceWrapper get_telemetryDiagnosticsInstanceWrapper() { }

	// RVA: 0x169A85C
	internal void set_telemetryDiagnosticsInstanceWrapper(ITelemetryDiagnosticsInstanceWrapper value) { }

	// RVA: 0x169A864
	internal void .ctor(IUtil util, ILogger logger, INativeStoreProvider nativeStoreProvider, RuntimePlatform platform, AppStore android, ITelemetryDiagnosticsInstanceWrapper telemetryDiagnosticsInstanceWrapper, ITelemetryMetricsInstanceWrapper telemetryMetricsInstanceWrapper) { }

	// RVA: 0x169A958
	public AppStore get_appStore() { }

	// RVA: 0x169A960
	private void set_appStore(AppStore value) { }

	// RVA: 0x169A968
	public FakeStoreUIMode get_useFakeStoreUIMode() { }

	// RVA: 0x169A970
	public void set_useFakeStoreUIMode(FakeStoreUIMode value) { }

	// RVA: 0x169A978
	public bool get_useFakeStoreAlways() { }

	// RVA: 0x169A980
	public void set_useFakeStoreAlways(bool value) { }

	// RVA: 0x169A988
	public static StandardPurchasingModule Instance() { }

	// RVA: 0x169A9F8
	public static StandardPurchasingModule Instance(AppStore androidStore) { }

	// RVA: 0x169B074
	public override void Configure() { }

	// RVA: 0x169B65C
	private StoreInstance InstantiateStore() { }

	// RVA: 0x169BD88
	private IStore InstantiateAndroid() { }

	// RVA: 0x169C024
	private IStore InstantiateGoogleStore() { }

	// RVA: 0x169CDB0
	private void BindGoogleExtension(GooglePlayStoreExtensions googlePlayStoreExtensions) { }

	// RVA: 0x169CBC8
	private static GooglePlayConfiguration BuildGooglePlayStoreConfiguration(IGooglePlayStoreService googlePlayStoreService, IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback) { }

	// RVA: 0x169CD54
	private void BindGoogleConfiguration(GooglePlayConfiguration googlePlayConfiguration) { }

	// RVA: 0x169C624
	private IGooglePlayStoreService BuildAndInitGooglePlayStoreServiceAar(IGooglePurchaseCallback googlePurchaseCallback, IGoogleProductCallback googleProductCallback, IGooglePurchaseStateEnumProvider googlePurchaseStateEnumProvider) { }

	// RVA: 0x169BBA4
	private IStore InstantiateUDP() { }

	// RVA: 0x169C534
	private IStore InstantiateAndroidHelper(JSONStore store) { }

	// RVA: 0x169CE0C
	private INativeStore GetAndroidNativeStore(JSONStore store) { }

	// RVA: 0x169B9FC
	private IStore InstantiateApple() { }

	// RVA: 0x169BEB4
	private IStore instantiateWindowsStore() { }

	// RVA: 0x169B908
	private IStore InstantiateFakeStore() { }

	// RVA: 0x169CEE0
	private static void .cctor() { }

}

// Namespace: UnityEngine.Purchasing
internal class StoreConfiguration
{
	// Fields
	private AppStore <androidStore>k__BackingField; // 0x10

	// Methods

	// RVA: 0x169D044
	public AppStore get_androidStore() { }

	// RVA: 0x169D04C
	private void set_androidStore(AppStore value) { }

	// RVA: 0x169D054
	public void .ctor(AppStore store) { }

	// RVA: 0x169ADC8
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

	// RVA: 0x169D080
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

	// RVA: 0x169E6A0
	private static void .cctor() { }

	// RVA: 0x169E70C
	public void .ctor() { }

	// RVA: 0x169E714
	internal int <findMostRecentReceipt>b__11_0(AppleInAppPurchaseReceipt b, AppleInAppPurchaseReceipt a) { }

	// RVA: 0x169E7A4
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

	// RVA: 0x169449C
	public void .ctor(Product product, string intro_json) { }

	// RVA: 0x169450C
	public SubscriptionInfo getSubscriptionInfo() { }

	// RVA: 0x169DB2C
	private SubscriptionInfo getAmazonAppStoreSubInfo(string productId) { }

	// RVA: 0x169D780
	private SubscriptionInfo getAppleAppStoreSubInfo(string payload, string productId) { }

	// RVA: 0x169DC54
	private AppleInAppPurchaseReceipt findMostRecentReceipt(System.Collections.Generic.List<UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt> receipts) { }

	// RVA: 0x169D0C8
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

	// RVA: 0x16919FC
	public void .ctor(AppleInAppPurchaseReceipt r, string intro_json) { }

	// RVA: 0x169DDAC
	public void .ctor(string skuDetails, bool isAutoRenewing, DateTime purchaseDate, bool isFreeTrial, bool hasIntroductoryPriceTrial, bool purchaseHistorySupported, string updateMetadata) { }

	// RVA: 0x169DB90
	public void .ctor(string productId) { }

	// RVA: 0x169F170
	public Result isExpired() { }

	// RVA: 0x169F178
	public Result isCancelled() { }

	// RVA: 0x169F180
	public DateTime getExpireDate() { }

	// RVA: 0x169F01C
	private DateTime nextBillingDate(DateTime billing_begin_date, TimeSpanUnits units) { }

	// RVA: 0x169ECA4
	private TimeSpan accumulateIntroductoryDuration(TimeSpanUnits units, Int64 cycles) { }

	// RVA: 0x169EA44
	private TimeSpan computePeriodTimeSpan(TimeSpanUnits units) { }

	// RVA: 0x169ED84
	private Double computeExtraTime(string metadata, Double new_sku_period_in_seconds) { }

	// RVA: 0x169EB24
	private TimeSpan parseTimeSpan(string period_string) { }

	// RVA: 0x169E80C
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

	// RVA: 0x169F188
	public void .ctor() { }

	// RVA: 0x169F210
	public void .ctor(string message) { }

}

// Namespace: UnityEngine.Purchasing
public class InvalidProductTypeException
{
	// Methods

	// RVA: 0x169F27C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class NullProductIdException
{
	// Methods

	// RVA: 0x169F304
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class NullReceiptException
{
	// Methods

	// RVA: 0x169F38C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing
public class StoreSubscriptionInfoNotSupportedException
{
	// Methods

	// RVA: 0x169F414
	public void .ctor(string message) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeTransactionHistoryExtensions
{
	// Methods

	// RVA: 0x169F480
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A24F0
	public void .ctor(int <>1__state) { }

	// RVA: 0x30A2378
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30A1224
	private bool MoveNext() { }

	// RVA: 0x30A2378
	private void <>m__Finally1() { }

	// RVA: 0x315B3A8
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }

	// RVA: 0x30A2378
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.Purchasing
internal static class EnumerableExtensions
{
	// Methods

	// RVA: 0x30A52D0
	public static System.Collections.Generic.IEnumerable<T> NonNull(System.Collections.Generic.IEnumerable<T> enumerable) { }

	// RVA: 0x30A53B0
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

	// RVA: 0x169F7F0
	private void MoveNext() { }

	// RVA: 0x169F9C4
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

	// RVA: 0x169F9D0
	private void MoveNext() { }

	// RVA: 0x169FD10
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

	// RVA: 0x169F5D8
	public void .ctor() { }

	// RVA: 0x169F650
	internal void <Invoke>g__Retry|0() { }

	// RVA: 0x169F708
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

	// RVA: 0x169F488
	public void .ctor(int baseRetryDelay, int maxRetryDelay, int exponentialFactor) { }

	// RVA: 0x169F4C8
	public void Invoke(System.Action<System.Action> actionToTry, Action onRetryAction) { }

	// RVA: 0x169F5E0
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

	// RVA: 0x16A0038
	private void MoveNext() { }

	// RVA: 0x16A0350
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

	// RVA: 0x169FF08
	public void .ctor() { }

	// RVA: 0x169FF10
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

	// RVA: 0x169FD7C
	public void .ctor(int baseRetryDelay, int maxRetryDelay, int exponentialFactor) { }

	// RVA: 0x169FDBC
	public void Invoke(System.Action<System.Action> actionToTry, Action onRetryAction) { }

	// RVA: 0x169FFC8
	private int AdjustDelay(int delay) { }

}

// Namespace: UnityEngine.Purchasing
internal static class ProductDefinitionExtensions
{
	// Methods

	// RVA: 0x16A035C
	internal static System.Collections.Generic.List<UnityEngine.Purchasing.ProductDefinition> DecodeJSON(System.Collections.Generic.List<System.Object> productsList, string storeName) { }

}

// Namespace: UnityEngine.Purchasing
internal class FakeMicrosoftExtensions
{
	// Methods

	// RVA: 0x16A0D1C
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

	// RVA: 0x16A139C
	private static void .cctor() { }

	// RVA: 0x16A1408
	public void .ctor() { }

	// RVA: 0x16A1410
	internal bool <RetrieveProducts>b__8_0(ProductDefinition def) { }

	// RVA: 0x16A1434
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

	// RVA: 0x16A0D24
	public void .ctor(IWindowsIAP win8, IUtil util, ILogger logger) { }

	// RVA: 0x16A0D88
	public override void Initialize(IStoreCallback biller) { }

	// RVA: 0x16A0D90
	public override void RetrieveProducts(System.Collections.ObjectModel.ReadOnlyCollection<UnityEngine.Purchasing.ProductDefinition> productDefs) { }

	// RVA: 0x16A1150
	public override void FinishTransaction(ProductDefinition product, string transactionId) { }

	// RVA: 0x16A1020
	private void init(int delay) { }

	// RVA: 0x16A1208
	public override void Purchase(ProductDefinition product, string developerPayload) { }

	// RVA: 0x16A12C8
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

	// RVA: 0x16A1ED8
	public void .ctor(int <>1__state) { }

	// RVA: 0x16A2734
	private void System.IDisposable.Dispose() { }

	// RVA: 0x16A2738
	private bool MoveNext() { }

	// RVA: 0x16A2804
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	// RVA: 0x16A280C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x16A284C
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

	// RVA: 0x30A17DC
	public T[] GetAnyComponentsOfType() { }

	// RVA: 0x16A15B0
	public DateTime get_currentTime() { }

	// RVA: 0x16A1620
	public string get_persistentDataPath() { }

	// RVA: 0x16A1690
	public string get_deviceUniqueIdentifier() { }

	// RVA: 0x16A1698
	public string get_unityVersion() { }

	// RVA: 0x16A1708
	public string get_cloudProjectId() { }

	// RVA: 0x16A1778
	public string get_userId() { }

	// RVA: 0x16A17E8
	public string get_gameVersion() { }

	// RVA: 0x16A1858
	public UInt64 get_sessionId() { }

	// RVA: 0x16A18C8
	public RuntimePlatform get_platform() { }

	// RVA: 0x16A1938
	public bool get_isEditor() { }

	// RVA: 0x16A19A8
	public string get_deviceModel() { }

	// RVA: 0x16A19B0
	public string get_deviceName() { }

	// RVA: 0x16A19B8
	public DeviceType get_deviceType() { }

	// RVA: 0x16A19C0
	public string get_operatingSystem() { }

	// RVA: 0x16A19C8
	public int get_screenWidth() { }

	// RVA: 0x16A19D0
	public int get_screenHeight() { }

	// RVA: 0x16A19D8
	public float get_screenDpi() { }

	// RVA: 0x16A19E0
	public string get_screenOrientation() { }

	// RVA: 0x16A1A4C
	private object Uniject.IUtil.InitiateCoroutine(IEnumerator start) { }

	// RVA: 0x16A1A54
	private void Uniject.IUtil.InitiateCoroutine(IEnumerator start, int delay) { }

	// RVA: 0x16A1B88
	public void RunOnMainThread(Action runnable) { }

	// RVA: 0x16A1CF0
	public object GetWaitForSeconds(int seconds) { }

	// RVA: 0x16A1D58
	private void Start() { }

	// RVA: 0x315B3A8
	public static T FindInstanceOfType() { }

	// RVA: 0x315B3A8
	public static T LoadResourceInstanceOfType() { }

	// RVA: 0x16A1DE4
	public static bool PcPlatform() { }

	// RVA: 0x16A1AEC
	private IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay) { }

	// RVA: 0x16A1F04
	private void Update() { }

	// RVA: 0x16A222C
	public void AddPauseListener(System.Action<System.Boolean> runnable) { }

	// RVA: 0x16A2290
	public void OnApplicationPause(bool paused) { }

	// RVA: 0x16A2474
	public bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant) { }

	// RVA: 0x16A2518
	public void .ctor() { }

	// RVA: 0x16A25A4
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

	// RVA: 0x16A2C0C
	public void .ctor() { }

	// RVA: 0x16A3118
	internal void <Initialize>b__0() { }

}

// Namespace: UnityEngine.Purchasing.Registration
internal class IapCoreInitializeCallback
{
	// Methods

	// RVA: 0x16A2854
	private static void Register() { }

	// RVA: 0x16A2994
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x16A2C14
	private static void CacheInitializedEnvironment(CoreRegistry registry) { }

	// RVA: 0x16A2C4C
	private static string GetCurrentEnvironment(CoreRegistry registry) { }

	// RVA: 0x16A2DBC
	private static void InitializeTelemetryComponents(ITelemetryMetricsInstanceWrapper metricsInstanceWrapper, ITelemetryDiagnosticsInstanceWrapper diagnosticsInstanceWrapper) { }

	// RVA: 0x16A298C
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails; // 0x10

	// Methods

	// RVA: 0x16A4318
	public void .ctor() { }

	// RVA: 0x16A4320
	internal AndroidJavaObject <TryFindAllProductDetails>b__0(string sku) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_1
{
	// Fields
	public string sku; // 0x10

	// Methods

	// RVA: 0x16A4420
	public void .ctor() { }

	// RVA: 0x16A4428
	internal bool <TryFindAllProductDetails>b__1(AndroidJavaObject productDetail) { }

}

// Namespace: UnityEngine.Purchasing.Utils
internal class GooglePurchaseBuilder
{
	// Fields
	private readonly IGoogleCachedQueryProductDetailsService m_CachedQueryProductDetailsService; // 0x10
	private readonly ILogger m_Logger; // 0x18

	// Methods

	// RVA: 0x16A3160
	public void .ctor(IGoogleCachedQueryProductDetailsService cachedQueryProductDetailsService, ILogger logger) { }

	// RVA: 0x16A31B0
	public System.Collections.Generic.IEnumerable<UnityEngine.Purchasing.Interfaces.IGooglePurchase> BuildPurchases(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> purchases) { }

	// RVA: 0x16A32E0
	private void LogWarningForException(Exception exception) { }

	// RVA: 0x16A3324
	public IGooglePurchase BuildPurchase(AndroidJavaObject purchase) { }

	// RVA: 0x16A3854
	private static System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> TryFindAllProductDetails(System.Collections.Generic.IEnumerable<System.String> skus, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

}

// Namespace: UnityEngine.Purchasing.Utils
internal static class GoogleReceiptEncoder
{
	// Methods

	// RVA: 0x16A4570
	internal static string EncodeReceipt(string purchaseOriginalJson, string purchaseSignature, System.Collections.Generic.List<System.String> productDetailsJson) { }

}

// Namespace: UnityEngine.Purchasing.Utils
internal class ProductDetailsConverter
{
	// Methods

	// RVA: 0x16A4698
	public System.Collections.Generic.List<UnityEngine.Purchasing.Extension.ProductDescription> ConvertOnQueryProductDetailsResponse(System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetails) { }

	// RVA: 0x16A4758
	private static ProductDescription ToProductDescription(AndroidJavaObject productDetails) { }

	// RVA: 0x16A480C
	internal static ProductDescription BuildProductDescription(AndroidJavaObject productDetails) { }

	// RVA: 0x16A650C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal T <Enumerate>b__0(int i) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class AndroidJavaObjectExtensions
{
	// Methods

	// RVA: 0x30A52D0
	internal static System.Collections.Generic.IEnumerable<T> Enumerate(AndroidJavaObject androidJavaList) { }

	// RVA: 0x16A64B8
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

	// RVA: 0x16A7B9C
	public void .ctor() { }

	// RVA: 0x16A9ED0
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

	// RVA: 0x16A6514
	private static AndroidJavaClass GetProductParamsClass() { }

	// RVA: 0x16A65E8
	private static AndroidJavaClass GetQueryProductDetailsParamsParamsClass() { }

	// RVA: 0x16A66B4
	private static AndroidJavaClass GetBillingFlowParamClass() { }

	// RVA: 0x16A6780
	private static AndroidJavaClass GetProductDetailsParamsClass() { }

	// RVA: 0x16A684C
	private static AndroidJavaClass GetSubscriptionUpdateParamClass() { }

	// RVA: 0x16A6918
	private static AndroidJavaClass GetConsumeParamsClass() { }

	// RVA: 0x16A69E4
	private static AndroidJavaClass GetAcknowledgePurchaseParamsClass() { }

	// RVA: 0x16A6AB0
	private static AndroidJavaClass GetBillingClientClass() { }

	// RVA: 0x16A6B7C
	internal void .ctor(IGooglePurchaseUpdatedListener googlePurchaseUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	// RVA: 0x16A7000
	public void StartConnection(IBillingClientStateListener billingClientStateListener) { }

	// RVA: 0x16A70D4
	public GoogleBillingConnectionState GetConnectionState() { }

	// RVA: 0x16A720C
	public void QueryPurchasesAsync(string skuType, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject>> onQueryPurchasesResponse) { }

	// RVA: 0x16A734C
	public void QueryProductDetailsAsync(System.Collections.Generic.List<System.String> products, string type, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List<UnityEngine.AndroidJavaObject>> onProductDetailsResponseAction) { }

	// RVA: 0x16A75CC
	private static AndroidJavaObject QueryProductDetailsParams(System.Collections.Generic.List<System.String> products, string type) { }

	// RVA: 0x16A7A74
	private static AndroidJavaObject QueryProductDetailsParamsProductList(System.Collections.Generic.List<System.String> products, string type) { }

	// RVA: 0x16A7BA4
	private static AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product) { }

	// RVA: 0x16A802C
	public AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode) { }

	// RVA: 0x16A8A20
	private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, System.Nullable<UnityEngine.Purchasing.GooglePlayProrationMode> prorationMode) { }

	// RVA: 0x16A9008
	private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayProrationMode prorationMode) { }

	// RVA: 0x16A8F00
	private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	// RVA: 0x16A8DF8
	private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	// RVA: 0x16A9368
	public void ConsumeAsync(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onConsume) { }

	// RVA: 0x16A991C
	public void AcknowledgePurchase(string purchaseToken, System.Action<UnityEngine.Purchasing.Models.IGoogleBillingResult> onAcknowledge) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal class GoogleBillingResult
{
	// Fields
	private readonly GoogleBillingResponseCode <responseCode>k__BackingField; // 0x10
	private readonly string <debugMessage>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16A9ED8
	public GoogleBillingResponseCode get_responseCode() { }

	// RVA: 0x16A9EE0
	public string get_debugMessage() { }

	// RVA: 0x16A9EE8
	internal void .ctor(AndroidJavaObject billingResult) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class GoogleBillingStrings
{
	// Methods

	// RVA: 0x16AA0D0
	internal static string getWarningMessageMoreThanOneSkuFound(string sku) { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class GoogleProductTypeEnum
{
	// Methods

	// RVA: 0x16AA140
	internal static string InApp() { }

	// RVA: 0x16AA184
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

	// RVA: 0x16AA7E8
	private static void .cctor() { }

	// RVA: 0x16AA854
	public void .ctor() { }

	// RVA: 0x16AA85C
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

	// RVA: 0x16AA1C8
	public bool get_isAcknowledged() { }

	// RVA: 0x16AA1D0
	public int get_purchaseState() { }

	// RVA: 0x16AA1D8
	public System.Collections.Generic.List<System.String> get_skus() { }

	// RVA: 0x16AA1E0
	public string get_receipt() { }

	// RVA: 0x16AA1E8
	public string get_signature() { }

	// RVA: 0x16AA1F0
	public string get_originalJson() { }

	// RVA: 0x16AA1F8
	public string get_purchaseToken() { }

	// RVA: 0x16AA200
	public string get_sku() { }

	// RVA: 0x16A393C
	internal void .ctor(AndroidJavaObject purchase, System.Collections.Generic.IEnumerable<UnityEngine.AndroidJavaObject> productDetailsEnum) { }

	// RVA: 0x16AA268
	public virtual bool IsAcknowledged() { }

	// RVA: 0x16AA270
	public virtual bool IsPurchased() { }

	// RVA: 0x16AA528
	public virtual bool IsPending() { }

}

// Namespace: UnityEngine.Purchasing.Models
internal static class GooglePurchaseStateEnum
{
	// Fields
	private static System.Nullable<System.Int32> s_Purchased; // 0x0
	private static System.Nullable<System.Int32> s_Pending; // 0x8

	// Methods

	// RVA: 0x16AA890
	private static AndroidJavaObject GetPurchaseStateJavaObject() { }

	// RVA: 0x16AA298
	internal static int Purchased() { }

	// RVA: 0x16AA550
	internal static int Pending() { }

}

// Namespace: UnityEngine.Purchasing.Models
internal class GooglePurchaseStateEnumProvider
{
	// Methods

	// RVA: 0x16AA908
	public int Purchased() { }

	// RVA: 0x16AA90C
	public int Pending() { }

	// RVA: 0x16AA910
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

	// RVA: 0x16AA918
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

	// RVA: 0x16AA97C
	internal static UInt32 ComputeStringHash(string s) { }

}


