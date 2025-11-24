// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Purchasing
internal class iOSStoreBindings
{
	// Methods

	// RVA: 0x16749F0
	private static extern void unityPurchasingRetrieveProducts(string json) { }

	// RVA: 0x1674A18
	private static extern void unityPurchasingPurchase(string json, string developerPayload) { }

	// RVA: 0x1674A60
	private static extern void unityPurchasingFinishTransaction(string productJSON, string transactionId) { }

	// RVA: 0x1674AA8
	private static extern void unityPurchasingAddTransactionObserver() { }

	// RVA: 0x1674AAC
	private static extern void setUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: 0x1674AC0
	private static extern string getUnityPurchasingAppReceipt() { }

	// RVA: 0x1674AF4
	private static extern Double getUnityPurchasingAppReceiptModificationDate() { }

	// RVA: 0x1674AF8
	private static extern string getUnityPurchasingTransactionReceiptForProductId(string productId) { }

	// RVA: 0x1674B44
	private static extern void unityPurchasingInterceptPromotionalPurchases() { }

	// RVA: 0x1674B48
	public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: 0x1674B60
	public string get_appReceipt() { }

	// RVA: 0x1674B94
	public Double get_appReceiptModificationDate() { }

	// RVA: 0x1674B98
	public void RetrieveProducts(string json) { }

	// RVA: 0x1674BC4
	public void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x1674C10
	public void FinishTransaction(string productJSON, string transactionId) { }

	// RVA: 0x1674C5C
	public void AddTransactionObserver() { }

	// RVA: 0x1674C60
	public string GetTransactionReceiptForProductId(string productId) { }

	// RVA: 0x1674CB0
	public void InterceptPromotionalPurchases() { }

	// RVA: 0x1674CB4
	public void .ctor() { }

}


