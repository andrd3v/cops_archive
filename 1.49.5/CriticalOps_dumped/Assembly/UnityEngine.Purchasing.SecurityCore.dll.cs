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

	// RVA: 0x16868C0
	internal void set_bundleID(string value) { }

	// RVA: 0x16868C8
	internal void set_appVersion(string value) { }

	// RVA: 0x16868D0
	internal void set_opaque(Byte[] value) { }

	// RVA: 0x16868D8
	internal void set_hash(Byte[] value) { }

	// RVA: 0x16868E0
	internal void set_originalApplicationVersion(string value) { }

	// RVA: 0x16868E8
	internal void set_receiptCreationDate(DateTime value) { }

	// RVA: 0x16868F0
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

	// RVA: 0x16868F8
	internal void set_quantity(int value) { }

	// RVA: 0x1686900
	public string get_productID() { }

	// RVA: 0x1686908
	internal void set_productID(string value) { }

	// RVA: 0x1686910
	public string get_transactionID() { }

	// RVA: 0x1686918
	internal void set_transactionID(string value) { }

	// RVA: 0x1686920
	public string get_originalTransactionIdentifier() { }

	// RVA: 0x1686928
	internal void set_originalTransactionIdentifier(string value) { }

	// RVA: 0x1686930
	public DateTime get_purchaseDate() { }

	// RVA: 0x1686938
	internal void set_purchaseDate(DateTime value) { }

	// RVA: 0x1686940
	internal void set_originalPurchaseDate(DateTime value) { }

	// RVA: 0x1686948
	public DateTime get_subscriptionExpirationDate() { }

	// RVA: 0x1686950
	internal void set_subscriptionExpirationDate(DateTime value) { }

	// RVA: 0x1686958
	public DateTime get_cancellationDate() { }

	// RVA: 0x1686960
	internal void set_cancellationDate(DateTime value) { }

	// RVA: 0x1686968
	public int get_isFreeTrial() { }

	// RVA: 0x1686970
	internal void set_isFreeTrial(int value) { }

	// RVA: 0x1686978
	public int get_productType() { }

	// RVA: 0x1686980
	internal void set_productType(int value) { }

	// RVA: 0x1686988
	public int get_isIntroductoryPricePeriod() { }

	// RVA: 0x1686990
	internal void set_isIntroductoryPricePeriod(int value) { }

	// RVA: 0x1686998
	public void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class IAPSecurityException
{
	// Methods

	// RVA: 0x16869A0
	public void .ctor() { }

}


