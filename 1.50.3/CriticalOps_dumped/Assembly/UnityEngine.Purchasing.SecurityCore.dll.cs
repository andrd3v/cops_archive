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

	// RVA: 0x16A9A44
	internal void set_bundleID(string value) { }

	// RVA: 0x16A9A4C
	internal void set_appVersion(string value) { }

	// RVA: 0x16A9A54
	internal void set_opaque(Byte[] value) { }

	// RVA: 0x16A9A5C
	internal void set_hash(Byte[] value) { }

	// RVA: 0x16A9A64
	internal void set_originalApplicationVersion(string value) { }

	// RVA: 0x16A9A6C
	internal void set_receiptCreationDate(DateTime value) { }

	// RVA: 0x16A9A74
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

	// RVA: 0x16A9A7C
	internal void set_quantity(int value) { }

	// RVA: 0x16A9A84
	public string get_productID() { }

	// RVA: 0x16A9A8C
	internal void set_productID(string value) { }

	// RVA: 0x16A9A94
	public string get_transactionID() { }

	// RVA: 0x16A9A9C
	internal void set_transactionID(string value) { }

	// RVA: 0x16A9AA4
	public string get_originalTransactionIdentifier() { }

	// RVA: 0x16A9AAC
	internal void set_originalTransactionIdentifier(string value) { }

	// RVA: 0x16A9AB4
	public DateTime get_purchaseDate() { }

	// RVA: 0x16A9ABC
	internal void set_purchaseDate(DateTime value) { }

	// RVA: 0x16A9AC4
	internal void set_originalPurchaseDate(DateTime value) { }

	// RVA: 0x16A9ACC
	public DateTime get_subscriptionExpirationDate() { }

	// RVA: 0x16A9AD4
	internal void set_subscriptionExpirationDate(DateTime value) { }

	// RVA: 0x16A9ADC
	public DateTime get_cancellationDate() { }

	// RVA: 0x16A9AE4
	internal void set_cancellationDate(DateTime value) { }

	// RVA: 0x16A9AEC
	public int get_isFreeTrial() { }

	// RVA: 0x16A9AF4
	internal void set_isFreeTrial(int value) { }

	// RVA: 0x16A9AFC
	public int get_productType() { }

	// RVA: 0x16A9B04
	internal void set_productType(int value) { }

	// RVA: 0x16A9B0C
	public int get_isIntroductoryPricePeriod() { }

	// RVA: 0x16A9B14
	internal void set_isIntroductoryPricePeriod(int value) { }

	// RVA: 0x16A9B1C
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class IAPSecurityException
{
	// Methods

	// RVA: 0x16A9B24
	public void .ctor() { }

}


