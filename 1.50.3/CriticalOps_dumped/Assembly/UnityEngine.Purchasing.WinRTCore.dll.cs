// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Purchasing.Default
public interface IWindowsIAPCallback
{}

// Namespace: UnityEngine.Purchasing.Default
public interface IWindowsIAP
{
	// Methods

	// RVA: -1
	public abstract void BuildDummyProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Default.WinProductDescription> products) { }

	// RVA: -1
	public abstract void Initialize(IWindowsIAPCallback callback) { }

	// RVA: -1
	public abstract void RetrieveProducts(bool retryIfOffline) { }

	// RVA: -1
	public abstract void Purchase(string productId) { }

	// RVA: -1
	public abstract void FinaliseTransaction(string transactionId) { }

}

// Namespace: UnityEngine.Purchasing.Default
public class WinProductDescription
{
	// Fields
	private string <platformSpecificID>k__BackingField; // 0x10
	private string <price>k__BackingField; // 0x18
	private string <title>k__BackingField; // 0x20
	private string <description>k__BackingField; // 0x28
	private string <ISOCurrencyCode>k__BackingField; // 0x30
	private Decimal <priceDecimal>k__BackingField; // 0x38
	private string <receipt>k__BackingField; // 0x48
	private string <transactionID>k__BackingField; // 0x50
	private bool <consumable>k__BackingField; // 0x58

	// Methods

	// RVA: 0x16DCDFC
	private void set_platformSpecificID(string value) { }

	// RVA: 0x16DCE04
	private void set_price(string value) { }

	// RVA: 0x16DCE0C
	private void set_title(string value) { }

	// RVA: 0x16DCE14
	private void set_description(string value) { }

	// RVA: 0x16DCE1C
	private void set_ISOCurrencyCode(string value) { }

	// RVA: 0x16DCE24
	private void set_priceDecimal(Decimal value) { }

	// RVA: 0x16DCE2C
	private void set_receipt(string value) { }

	// RVA: 0x16DCE34
	private void set_transactionID(string value) { }

	// RVA: 0x16DCE3C
	private void set_consumable(bool value) { }

	// RVA: 0x16DCE44
	public void .ctor(string id, string price, string title, string description, string isoCode, Decimal priceD, string receipt, string transactionId, bool consumable) { }

}


