// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine.Purchasing
internal interface INativeAppleStore 
{
	// Methods

	// RVA: 0x2FE4574
	void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: 0x2FE41A8
	void AddTransactionObserver() { }

	// RVA: 0x2FE360C
	string get_appReceipt() { }

	// RVA: -1
	Double get_appReceiptModificationDate() { }

	// RVA: 0x2FE36BC
	string GetTransactionReceiptForProductId(string productId) { }

	// RVA: 0x2FE41A8
	void InterceptPromotionalPurchases() { }

}


