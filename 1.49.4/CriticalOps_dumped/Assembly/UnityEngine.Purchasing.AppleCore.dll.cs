// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Purchasing
internal interface INativeAppleStore
{
	// Methods

	// RVA: -1
	public abstract void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

	// RVA: -1
	public abstract void AddTransactionObserver() { }

	// RVA: -1
	public abstract string get_appReceipt() { }

	// RVA: -1
	public abstract Double get_appReceiptModificationDate() { }

	// RVA: -1
	public abstract string GetTransactionReceiptForProductId(string productId) { }

	// RVA: -1
	public abstract void InterceptPromotionalPurchases() { }

}


