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

	// RVA: 0x1677650
	internal void set_bundleID(string value) { }

	// RVA: 0x1677658
	internal void set_appVersion(string value) { }

	// RVA: 0x1677660
	internal void set_opaque(Byte[] value) { }

	// RVA: 0x1677668
	internal void set_hash(Byte[] value) { }

	// RVA: 0x1677670
	internal void set_originalApplicationVersion(string value) { }

	// RVA: 0x1677678
	internal void set_receiptCreationDate(DateTime value) { }

	// RVA: 0x1677680
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

	// RVA: 0x1677688
	internal void set_quantity(int value) { }

	// RVA: 0x1677690
	public string get_productID() { }

	// RVA: 0x1677698
	internal void set_productID(string value) { }

	// RVA: 0x16776A0
	public string get_transactionID() { }

	// RVA: 0x16776A8
	internal void set_transactionID(string value) { }

	// RVA: 0x16776B0
	public string get_originalTransactionIdentifier() { }

	// RVA: 0x16776B8
	internal void set_originalTransactionIdentifier(string value) { }

	// RVA: 0x16776C0
	public DateTime get_purchaseDate() { }

	// RVA: 0x16776C8
	internal void set_purchaseDate(DateTime value) { }

	// RVA: 0x16776D0
	internal void set_originalPurchaseDate(DateTime value) { }

	// RVA: 0x16776D8
	public DateTime get_subscriptionExpirationDate() { }

	// RVA: 0x16776E0
	internal void set_subscriptionExpirationDate(DateTime value) { }

	// RVA: 0x16776E8
	public DateTime get_cancellationDate() { }

	// RVA: 0x16776F0
	internal void set_cancellationDate(DateTime value) { }

	// RVA: 0x16776F8
	public int get_isFreeTrial() { }

	// RVA: 0x1677700
	internal void set_isFreeTrial(int value) { }

	// RVA: 0x1677708
	public int get_productType() { }

	// RVA: 0x1677710
	internal void set_productType(int value) { }

	// RVA: 0x1677718
	public int get_isIntroductoryPricePeriod() { }

	// RVA: 0x1677720
	internal void set_isIntroductoryPricePeriod(int value) { }

	// RVA: 0x1677728
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class IAPSecurityException
{
	// Methods

	// RVA: 0x1677730
	public void .ctor() { }

}


