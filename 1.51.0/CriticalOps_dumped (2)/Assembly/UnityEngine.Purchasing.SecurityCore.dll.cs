// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.Purchasing.Security
public class AppleReceipt
{
	// Fields
	private string <bundleID>k__BackingField; // 0x10
	private string <appVersion>k__BackingField; // 0x18
	private Byte[] <opaque>k__BackingField; // 0x20
	private Byte[] <hash>k__BackingField; // 0x28
	private string <originalApplicationVersion>k__BackingField; // 0x30
	private DateTime <receiptCreationDate>k__BackingField; // 0x38
	public AppleInAppPurchaseReceipt[] inAppPurchaseReceipts; // 0x40

	// Methods

	// RVA: 0x175C7B4
	internal void set_bundleID(string value) { }

	// RVA: 0x175C7BC
	internal void set_appVersion(string value) { }

	// RVA: 0x175C7C4
	internal void set_opaque(Byte[] value) { }

	// RVA: 0x175C7CC
	internal void set_hash(Byte[] value) { }

	// RVA: 0x175C7D4
	internal void set_originalApplicationVersion(string value) { }

	// RVA: 0x175C7DC
	internal void set_receiptCreationDate(DateTime value) { }

	// RVA: 0x175C7E4
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class AppleInAppPurchaseReceipt
{
	// Fields
	private int <quantity>k__BackingField; // 0x10
	private string <productID>k__BackingField; // 0x18
	private string <transactionID>k__BackingField; // 0x20
	private string <originalTransactionIdentifier>k__BackingField; // 0x28
	private DateTime <purchaseDate>k__BackingField; // 0x30
	private DateTime <originalPurchaseDate>k__BackingField; // 0x38
	private DateTime <subscriptionExpirationDate>k__BackingField; // 0x40
	private DateTime <cancellationDate>k__BackingField; // 0x48
	private int <isFreeTrial>k__BackingField; // 0x50
	private int <productType>k__BackingField; // 0x54
	private int <isIntroductoryPricePeriod>k__BackingField; // 0x58

	// Methods

	// RVA: 0x175C7EC
	internal void set_quantity(int value) { }

	// RVA: 0x175C7F4
	public string get_productID() { }

	// RVA: 0x175C7FC
	internal void set_productID(string value) { }

	// RVA: 0x175C804
	public string get_transactionID() { }

	// RVA: 0x175C80C
	internal void set_transactionID(string value) { }

	// RVA: 0x175C814
	public string get_originalTransactionIdentifier() { }

	// RVA: 0x175C81C
	internal void set_originalTransactionIdentifier(string value) { }

	// RVA: 0x175C824
	public DateTime get_purchaseDate() { }

	// RVA: 0x175C82C
	internal void set_purchaseDate(DateTime value) { }

	// RVA: 0x175C834
	internal void set_originalPurchaseDate(DateTime value) { }

	// RVA: 0x175C83C
	public DateTime get_subscriptionExpirationDate() { }

	// RVA: 0x175C844
	internal void set_subscriptionExpirationDate(DateTime value) { }

	// RVA: 0x175C84C
	public DateTime get_cancellationDate() { }

	// RVA: 0x175C854
	internal void set_cancellationDate(DateTime value) { }

	// RVA: 0x175C85C
	public int get_isFreeTrial() { }

	// RVA: 0x175C864
	internal void set_isFreeTrial(int value) { }

	// RVA: 0x175C86C
	public int get_productType() { }

	// RVA: 0x175C874
	internal void set_productType(int value) { }

	// RVA: 0x175C87C
	public int get_isIntroductoryPricePeriod() { }

	// RVA: 0x175C884
	internal void set_isIntroductoryPricePeriod(int value) { }

	// RVA: 0x175C88C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class IAPSecurityException
{
	// Methods

	// RVA: 0x175C894
	public void .ctor() { }

}


