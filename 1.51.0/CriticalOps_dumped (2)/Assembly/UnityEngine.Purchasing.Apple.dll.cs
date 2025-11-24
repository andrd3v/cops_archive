// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Purchasing
internal class iOSStoreBindings
{
	// Methods

	// RVA: 0x174A780
	private static extern void unityPurchasingRetrieveProducts(string json) { }

	// RVA: 0x174A7A8
	private static extern void unityPurchasingPurchase(string json, string developerPayload) { }

	// RVA: 0x174A7F0
	private static extern void unityPurchasingFinishTransaction(string productJSON, string transactionId) { }

	// RVA: 0x174A838
	private static extern void unityPurchasingAddTransactionObserver() { }

	// RVA: 0x174A83C
	private static extern void setUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: 0x174A850
	private static extern string getUnityPurchasingAppReceipt() { }

	// RVA: 0x174A884
	private static extern Double getUnityPurchasingAppReceiptModificationDate() { }

	// RVA: 0x174A888
	private static extern string getUnityPurchasingTransactionReceiptForProductId(string productId) { }

	// RVA: 0x174A8D4
	private static extern void unityPurchasingInterceptPromotionalPurchases() { }

	// RVA: 0x174A8D8
	public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: 0x174A8F0
	public string get_appReceipt() { }

	// RVA: 0x174A924
	public Double get_appReceiptModificationDate() { }

	// RVA: 0x174A928
	public void RetrieveProducts(string json) { }

	// RVA: 0x174A954
	public void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x174A9A0
	public void FinishTransaction(string productJSON, string transactionId) { }

	// RVA: 0x174A9EC
	public void AddTransactionObserver() { }

	// RVA: 0x174A9F0
	public string GetTransactionReceiptForProductId(string productId) { }

	// RVA: 0x174AA40
	public void InterceptPromotionalPurchases() { }

	// RVA: 0x174AA44
	public void .ctor() { }

}


