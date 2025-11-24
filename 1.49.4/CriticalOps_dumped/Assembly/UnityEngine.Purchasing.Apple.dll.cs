// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Purchasing
internal class iOSStoreBindings
{
	// Methods

	// RVA: 0x1665780
	private static extern void unityPurchasingRetrieveProducts(string json) { }

	// RVA: 0x16657A8
	private static extern void unityPurchasingPurchase(string json, string developerPayload) { }

	// RVA: 0x16657F0
	private static extern void unityPurchasingFinishTransaction(string productJSON, string transactionId) { }

	// RVA: 0x1665838
	private static extern void unityPurchasingAddTransactionObserver() { }

	// RVA: 0x166583C
	private static extern void setUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: 0x1665850
	private static extern string getUnityPurchasingAppReceipt() { }

	// RVA: 0x1665884
	private static extern Double getUnityPurchasingAppReceiptModificationDate() { }

	// RVA: 0x1665888
	private static extern string getUnityPurchasingTransactionReceiptForProductId(string productId) { }

	// RVA: 0x16658D4
	private static extern void unityPurchasingInterceptPromotionalPurchases() { }

	// RVA: 0x16658D8
	public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: 0x16658F0
	public string get_appReceipt() { }

	// RVA: 0x1665924
	public Double get_appReceiptModificationDate() { }

	// RVA: 0x1665928
	public void RetrieveProducts(string json) { }

	// RVA: 0x1665954
	public void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x16659A0
	public void FinishTransaction(string productJSON, string transactionId) { }

	// RVA: 0x16659EC
	public void AddTransactionObserver() { }

	// RVA: 0x16659F0
	public string GetTransactionReceiptForProductId(string productId) { }

	// RVA: 0x1665A40
	public void InterceptPromotionalPurchases() { }

	// RVA: 0x1665A44
	public void .ctor() { }

}


