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

	// RVA: 0x159266C
	void set_bundleID(string value) { }

	// RVA: 0x1592674
	void set_appVersion(string value) { }

	// RVA: 0x159267C
	void set_opaque(Byte[] value) { }

	// RVA: 0x1592684
	void set_hash(Byte[] value) { }

	// RVA: 0x159268C
	void set_originalApplicationVersion(string value) { }

	// RVA: 0x1592694
	void set_receiptCreationDate(DateTime value) { }

	// RVA: 0x159269C
	void .ctor() { }

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

	// RVA: 0x15926A4
	void set_quantity(int value) { }

	// RVA: 0x15926AC
	string get_productID() { }

	// RVA: 0x15926B4
	void set_productID(string value) { }

	// RVA: 0x15926BC
	string get_transactionID() { }

	// RVA: 0x15926C4
	void set_transactionID(string value) { }

	// RVA: 0x15926CC
	string get_originalTransactionIdentifier() { }

	// RVA: 0x15926D4
	void set_originalTransactionIdentifier(string value) { }

	// RVA: 0x15926DC
	DateTime get_purchaseDate() { }

	// RVA: 0x15926E4
	void set_purchaseDate(DateTime value) { }

	// RVA: 0x15926EC
	void set_originalPurchaseDate(DateTime value) { }

	// RVA: 0x15926F4
	DateTime get_subscriptionExpirationDate() { }

	// RVA: 0x15926FC
	void set_subscriptionExpirationDate(DateTime value) { }

	// RVA: 0x1592704
	DateTime get_cancellationDate() { }

	// RVA: 0x159270C
	void set_cancellationDate(DateTime value) { }

	// RVA: 0x1592714
	int get_isFreeTrial() { }

	// RVA: 0x159271C
	void set_isFreeTrial(int value) { }

	// RVA: 0x1592724
	int get_productType() { }

	// RVA: 0x159272C
	void set_productType(int value) { }

	// RVA: 0x1592734
	int get_isIntroductoryPricePeriod() { }

	// RVA: 0x159273C
	void set_isIntroductoryPricePeriod(int value) { }

	// RVA: 0x1592744
	void .ctor() { }

}

// Namespace: UnityEngine.Purchasing.Security
public class IAPSecurityException 
{
	// Methods

	// RVA: 0x159274C
	void .ctor() { }

}


