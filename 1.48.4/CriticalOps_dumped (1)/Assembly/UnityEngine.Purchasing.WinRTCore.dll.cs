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

	// RVA: 0x2FE4574
	void BuildDummyProducts(System.Collections.Generic.List<UnityEngine.Purchasing.Default.WinProductDescription> products) { }

	// RVA: 0x2FE4574
	void Initialize(IWindowsIAPCallback callback) { }

	// RVA: 0x2FE4234
	void RetrieveProducts(bool retryIfOffline) { }

	// RVA: 0x2FE4574
	void Purchase(string productId) { }

	// RVA: 0x2FE4574
	void FinaliseTransaction(string transactionId) { }

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

	// RVA: 0x15C5A24
	void set_platformSpecificID(string value) { }

	// RVA: 0x15C5A2C
	void set_price(string value) { }

	// RVA: 0x15C5A34
	void set_title(string value) { }

	// RVA: 0x15C5A3C
	void set_description(string value) { }

	// RVA: 0x15C5A44
	void set_ISOCurrencyCode(string value) { }

	// RVA: 0x15C5A4C
	void set_priceDecimal(Decimal value) { }

	// RVA: 0x15C5A54
	void set_receipt(string value) { }

	// RVA: 0x15C5A5C
	void set_transactionID(string value) { }

	// RVA: 0x15C5A64
	void set_consumable(bool value) { }

	// RVA: 0x15C5A6C
	void .ctor(string id, string price, string title, string description, string isoCode, Decimal priceD, string receipt, string transactionId, bool consumable) { }

}


