// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Purchasing
internal class iOSStoreBindings
{
	// Methods

	// RVA: 0x1697B74
	private static extern void unityPurchasingRetrieveProducts(string json) { }

	// RVA: 0x1697B9C
	private static extern void unityPurchasingPurchase(string json, string developerPayload) { }

	// RVA: 0x1697BE4
	private static extern void unityPurchasingFinishTransaction(string productJSON, string transactionId) { }

	// RVA: 0x1697C2C
	private static extern void unityPurchasingAddTransactionObserver() { }

	// RVA: 0x1697C30
	private static extern void setUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: 0x1697C44
	private static extern string getUnityPurchasingAppReceipt() { }

	// RVA: 0x1697C78
	private static extern Double getUnityPurchasingAppReceiptModificationDate() { }

	// RVA: 0x1697C7C
	private static extern string getUnityPurchasingTransactionReceiptForProductId(string productId) { }

	// RVA: 0x1697CC8
	private static extern void unityPurchasingInterceptPromotionalPurchases() { }

	// RVA: 0x1697CCC
	public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: 0x1697CE4
	public string get_appReceipt() { }

	// RVA: 0x1697D18
	public Double get_appReceiptModificationDate() { }

	// RVA: 0x1697D1C
	public void RetrieveProducts(string json) { }

	// RVA: 0x1697D48
	public void Purchase(string productJSON, string developerPayload) { }

	// RVA: 0x1697D94
	public void FinishTransaction(string productJSON, string transactionId) { }

	// RVA: 0x1697DE0
	public void AddTransactionObserver() { }

	// RVA: 0x1697DE4
	public string GetTransactionReceiptForProductId(string productId) { }

	// RVA: 0x1697E34
	public void InterceptPromotionalPurchases() { }

	// RVA: 0x1697E38
	public void .ctor() { }

}


