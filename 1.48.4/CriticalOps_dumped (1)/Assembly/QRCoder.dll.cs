// Namespace: 
internal class <Module> 
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute 
{
	// Methods

	// RVA: 0xDEA184
	void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class RefSafetyRulesAttribute 
{
	// Fields
	public readonly int Version; // 0x10

	// Methods

	// RVA: 0xDEA18C
	void .ctor(int ) { }

}

// Namespace: QRCoder
public abstract class AbstractQRCode 
{
	// Fields
	private QRCodeData <QrCodeData>k__BackingField; // 0x10

	// Methods

	// RVA: 0xDEA1B8
	QRCodeData get_QrCodeData() { }

	// RVA: 0xDEA1C0
	void set_QrCodeData(QRCodeData value) { }

	// RVA: 0xDEA1C8
	void .ctor(QRCodeData data) { }

}

// Namespace: QRCoder
internal static class BitArrayExtensions 
{
	// Methods

	// RVA: 0xDEA1FC
	int CopyTo(BitArray source, BitArray destination, int sourceOffset, int destinationOffset, int count) { }

}

// Namespace: QRCoder
public class QRCodeData 
{
	// Fields
	private System.Collections.Generic.List<System.Collections.BitArray> <ModuleMatrix>k__BackingField; // 0x10
	private int <Version>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDEA2A4
	System.Collections.Generic.List<System.Collections.BitArray> get_ModuleMatrix() { }

	// RVA: 0xDEA2AC
	void set_ModuleMatrix(System.Collections.Generic.List<System.Collections.BitArray> value) { }

	// RVA: 0xDEA2B4
	void .ctor(int version, bool addPadding) { }

	// RVA: 0xDEA3F4
	void set_Version(int value) { }

	// RVA: 0xDEA3E8
	int ModulesPerSideFromVersion(int version) { }

	// RVA: 0xDEA3FC
	void Dispose() { }

}

// Namespace: 
private struct AlignmentPattern 
{
	// Fields
	public int Version; // 0x10
	public System.Collections.Generic.List<QRCoder.QRCodeGenerator.Point> PatternPositions; // 0x18
}

// Namespace: 
private struct CodewordBlock 
{
	// Fields
	private readonly int <CodeWordsOffset>k__BackingField; // 0x10
	private readonly int <CodeWordsLength>k__BackingField; // 0x14
	private readonly Byte[] <ECCWords>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDF0A10
	void .ctor(int codeWordsOffset, int codeWordsLength, Byte[] eccWords) { }

	// RVA: 0xDF0A20
	int get_CodeWordsOffset() { }

	// RVA: 0xDF0A28
	int get_CodeWordsLength() { }

	// RVA: 0xDF0A30
	Byte[] get_ECCWords() { }

}

// Namespace: 
private struct ECCInfo 
{
	// Fields
	private readonly int <Version>k__BackingField; // 0x10
	private readonly ECCLevel <ErrorCorrectionLevel>k__BackingField; // 0x14
	private readonly int <TotalDataCodewords>k__BackingField; // 0x18
	private readonly int <ECCPerBlock>k__BackingField; // 0x1C
	private readonly int <BlocksInGroup1>k__BackingField; // 0x20
	private readonly int <CodewordsInGroup1>k__BackingField; // 0x24
	private readonly int <BlocksInGroup2>k__BackingField; // 0x28
	private readonly int <CodewordsInGroup2>k__BackingField; // 0x2C

	// Methods

	// RVA: 0xDEFD18
	void .ctor(int version, ECCLevel errorCorrectionLevel, int totalDataCodewords, int eccPerBlock, int blocksInGroup1, int codewordsInGroup1, int blocksInGroup2, int codewordsInGroup2) { }

	// RVA: 0xDF0A38
	int get_Version() { }

	// RVA: 0xDF0A40
	ECCLevel get_ErrorCorrectionLevel() { }

	// RVA: 0xDF0A48
	int get_TotalDataCodewords() { }

	// RVA: 0xDF0A50
	int get_ECCPerBlock() { }

	// RVA: 0xDF0A58
	int get_BlocksInGroup1() { }

	// RVA: 0xDF0A60
	int get_CodewordsInGroup1() { }

	// RVA: 0xDF0A68
	int get_BlocksInGroup2() { }

	// RVA: 0xDF0A70
	int get_CodewordsInGroup2() { }

}

// Namespace: 
public enum ECCLevel 
{
	// Fields
	public int value__; // 0x10
	public const ECCLevel Default = 4294967295;
	public const ECCLevel L = 0;
	public const ECCLevel M = 1;
	public const ECCLevel Q = 2;
	public const ECCLevel H = 3;
}

// Namespace: 
private enum EncodingMode 
{
	// Fields
	public int value__; // 0x10
	public const EncodingMode Numeric = 1;
	public const EncodingMode Alphanumeric = 2;
	public const EncodingMode Byte = 4;
	public const EncodingMode Kanji = 8;
	public const EncodingMode ECI = 7;
}

// Namespace: 
public struct BlockedModules 
{
	// Fields
	private readonly BitArray[] _blockedModules; // 0x10
	private static BitArray[] _staticBlockedModules; // 0x0

	// Methods

	// RVA: 0xDF4EF8
	void .ctor(int size) { }

	// RVA: 0xDF3038
	void Add(Rectangle rect) { }

	// RVA: 0xDF1714
	bool IsBlocked(int x, int y) { }

	// RVA: 0xDF4C90
	bool IsBlocked(Rectangle r1) { }

	// RVA: 0xDF5084
	void Dispose() { }

}

// Namespace: 
private static class MaskPattern 
{
	// Fields
	public static readonly System.Collections.Generic.List<System.Func<System.Int32,System.Int32,System.Boolean>> Patterns; // 0x0

	// Methods

	// RVA: 0xDF50E0
	bool Pattern1(int x, int y) { }

	// RVA: 0xDF50F0
	bool Pattern2(int x, int y) { }

	// RVA: 0xDF50FC
	bool Pattern3(int x, int y) { }

	// RVA: 0xDF5120
	bool Pattern4(int x, int y) { }

	// RVA: 0xDF5148
	bool Pattern5(int x, int y) { }

	// RVA: 0xDF51E8
	bool Pattern6(int x, int y) { }

	// RVA: 0xDF5224
	bool Pattern7(int x, int y) { }

	// RVA: 0xDF5254
	bool Pattern8(int x, int y) { }

	// RVA: 0xDF1750
	int Score(QRCodeData qrCode) { }

	// RVA: 0xDF5288
	void .cctor() { }

}

// Namespace: 
private static class ModulePlacer 
{
	// Methods

	// RVA: 0xDF0A78
	void PlaceVersion(QRCodeData qrCode, BitArray versionStr, bool offset) { }

	// RVA: 0xDF0D00
	void PlaceFormat(QRCodeData qrCode, BitArray formatStr, bool offset) { }

	// RVA: 0xDF0EC8
	int MaskCode(QRCodeData qrCode, int version, BlockedModules blockedModules, ECCLevel eccLevel) { }

	// RVA: 0xDF25DC
	void PlaceDataWords(QRCodeData qrCode, BitArray data, BlockedModules blockedModules) { }

	// RVA: 0xDF291C
	void ReserveSeperatorAreas(int size, BlockedModules blockedModules) { }

	// RVA: 0xDF30EC
	void ReserveVersionAreas(int size, int version, BlockedModules blockedModules) { }

	// RVA: 0xDF3B18
	void PlaceDarkModule(QRCodeData qrCode, int version, BlockedModules blockedModules) { }

	// RVA: 0xDF3BF0
	void PlaceFinderPatterns(QRCodeData qrCode, BlockedModules blockedModules) { }

	// RVA: 0xDF40E4
	void PlaceAlignmentPatterns(QRCodeData qrCode, System.Collections.Generic.List<QRCoder.QRCodeGenerator.Point> alignmentPatternLocations, BlockedModules blockedModules) { }

	// RVA: 0xDF4D5C
	void PlaceTimingPatterns(QRCodeData qrCode, BlockedModules blockedModules) { }

}

// Namespace: 
private struct Point 
{
	// Fields
	private readonly int <X>k__BackingField; // 0x10
	private readonly int <Y>k__BackingField; // 0x14

	// Methods

	// RVA: 0xDF5570
	int get_X() { }

	// RVA: 0xDF5578
	int get_Y() { }

	// RVA: 0xDEF9DC
	void .ctor(int x, int y) { }

	// RVA: 0xDF5580
	bool Equals(Point other) { }

}

// Namespace: 
public struct PolynumEnumerator 
{
	// Fields
	private Polynom _polynom; // 0x10
	private int _index; // 0x20

	// Methods

	// RVA: 0xDF5E8C
	void .ctor(Polynom polynom) { }

	// RVA: 0xDEE678
	PolynomItem get_Current() { }

	// RVA: 0xDEE680
	bool MoveNext() { }

}

// Namespace: 
private struct <>c__DisplayClass13_0 
{
	// Fields
	public PolynomItem[] items; // 0x10
	public System.Func<QRCoder.QRCodeGenerator.PolynomItem,QRCoder.QRCodeGenerator.PolynomItem,System.Int32> comparer; // 0x18
}

// Namespace: 
private struct Polynom 
{
	// Fields
	private PolynomItem[] _polyItems; // 0x10
	private int _length; // 0x18
	private static System.Collections.Generic.List<QRCoder.QRCodeGenerator.PolynomItem[]> _arrayPool; // 0xFFFFFFFF

	// Methods

	// RVA: 0xDEDD24
	void .ctor(int count) { }

	// RVA: 0xDED508
	void Add(PolynomItem item) { }

	// RVA: 0xDED474
	void RemoveAt(int index) { }

	// RVA: 0xDED36C
	PolynomItem get_Item(int index) { }

	// RVA: 0xDED3F4
	void set_Item(int index, PolynomItem value) { }

	// RVA: 0xDF57D8
	void ThrowIndexOutOfRangeException() { }

	// RVA: 0xDF5818
	int get_Count() { }

	// RVA: 0xDEDFC4
	void Clear() { }

	// RVA: 0xDED30C
	Polynom Clone() { }

	// RVA: 0xDEED40
	void Sort(System.Func<QRCoder.QRCodeGenerator.PolynomItem,QRCoder.QRCodeGenerator.PolynomItem,System.Int32> comparer) { }

	// RVA: 0xDF5A08
	string ToString() { }

	// RVA: 0xDEDB68
	void Dispose() { }

	// RVA: 0xDF5760
	void AssertCapacity(int min) { }

	// RVA: 0xDF55A8
	PolynomItem[] RentArray(int count) { }

	// RVA: 0xDF5C48
	void ReturnArray(PolynomItem[] array) { }

	// RVA: 0xDEE63C
	PolynumEnumerator GetEnumerator() { }

	// RVA: 0xDF5820
	void <Sort>g__QuickSort|13_0(int left, int right, ref QRCoder.QRCodeGenerator.Polynom.<>c__DisplayClass13_0& ) { }

	// RVA: 0xDF5D7C
	void <AssertCapacity>g__ThrowNotSupportedException|16_0() { }

	// RVA: 0xDF5DD0
	void <RentArray>g__ThrowArgumentOutOfRangeException|18_0() { }

	// RVA: 0xDF5E38
	void <ReturnArray>g__ThrowArgumentNullException|19_0() { }

}

// Namespace: 
private struct PolynomItem 
{
	// Fields
	private readonly int <Coefficient>k__BackingField; // 0x10
	private readonly int <Exponent>k__BackingField; // 0x14

	// Methods

	// RVA: 0xDED3EC
	void .ctor(int coefficient, int exponent) { }

	// RVA: 0xDF5EBC
	int get_Coefficient() { }

	// RVA: 0xDF5EC4
	int get_Exponent() { }

}

// Namespace: 
private struct Rectangle 
{
	// Fields
	private readonly int <X>k__BackingField; // 0x10
	private readonly int <Y>k__BackingField; // 0x14
	private readonly int <Width>k__BackingField; // 0x18
	private readonly int <Height>k__BackingField; // 0x1C

	// Methods

	// RVA: 0xDF5ECC
	int get_X() { }

	// RVA: 0xDF5ED4
	int get_Y() { }

	// RVA: 0xDF5EDC
	int get_Width() { }

	// RVA: 0xDF5EE4
	int get_Height() { }

	// RVA: 0xDF302C
	void .ctor(int x, int y, int w, int h) { }

}

// Namespace: 
private struct VersionInfo 
{
	// Fields
	private readonly int <Version>k__BackingField; // 0x10
	private readonly System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfoDetails> <Details>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDF04D8
	void .ctor(int version, System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfoDetails> versionInfoDetails) { }

	// RVA: 0xDF5EEC
	int get_Version() { }

	// RVA: 0xDF5EF4
	System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfoDetails> get_Details() { }

}

// Namespace: 
private struct VersionInfoDetails 
{
	// Fields
	private readonly ECCLevel <ErrorCorrectionLevel>k__BackingField; // 0x10
	private readonly System.Collections.Generic.Dictionary<QRCoder.QRCodeGenerator.EncodingMode,System.Int32> <CapacityDict>k__BackingField; // 0x18

	// Methods

	// RVA: 0xDF04C8
	void .ctor(ECCLevel errorCorrectionLevel, System.Collections.Generic.Dictionary<QRCoder.QRCodeGenerator.EncodingMode,System.Int32> capacityDict) { }

	// RVA: 0xDF5EFC
	ECCLevel get_ErrorCorrectionLevel() { }

	// RVA: 0xDF5F04
	System.Collections.Generic.Dictionary<QRCoder.QRCodeGenerator.EncodingMode,System.Int32> get_CapacityDict() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly QRCoder.QRCodeGenerator.<>c <>9; // 0x0
	public static System.Func<QRCoder.QRCodeGenerator.PolynomItem,QRCoder.QRCodeGenerator.PolynomItem,System.Int32> <>9__52_0; // 0x8

	// Methods

	// RVA: 0xDF5F0C
	void .cctor() { }

	// RVA: 0xDF5F78
	void .ctor() { }

	// RVA: 0xDF5F80
	int <MultiplyAlphaPolynoms>b__52_0(PolynomItem x, PolynomItem y) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0 
{
	// Fields
	public int version; // 0x10
	public ECCLevel eccLevel; // 0x14
	public ECCInfo eccInfo; // 0x18
	public BitArray bitArray; // 0x38
	public System.Collections.Generic.List<QRCoder.QRCodeGenerator.CodewordBlock> codeWordWithECC; // 0x40
	public int interleavedLength; // 0x48
	public BitArray interleavedData; // 0x50

	// Methods

	// RVA: 0xDEB088
	void .ctor() { }

	// RVA: 0xDF5FB4
	bool <GenerateQrCode>b__0(ECCInfo x) { }

	// RVA: 0xDEB090
	void <GenerateQrCode>g__PadData|1() { }

	// RVA: 0xDEB1D4
	System.Collections.Generic.List<QRCoder.QRCodeGenerator.CodewordBlock> <GenerateQrCode>g__CalculateECCBlocks|2() { }

	// RVA: 0xDF5FE0
	void <GenerateQrCode>g__AddCodeWordBlocks|6(int blockNum, int blocksInGroup, int codewordsInGroup, int offset2, int count, Polynom generatorPolynom, ref QRCoder.QRCodeGenerator.<>c__DisplayClass20_1& ) { }

	// RVA: 0xDEB39C
	int <GenerateQrCode>g__CalculateInterleavedLength|3() { }

	// RVA: 0xDEB784
	BitArray <GenerateQrCode>g__InterleaveData|4() { }

	// RVA: 0xDEBE60
	QRCodeData <GenerateQrCode>g__PlaceModules|5() { }

}

// Namespace: 
private struct <>c__DisplayClass20_1 
{
	// Fields
	public System.Collections.Generic.List<QRCoder.QRCodeGenerator.CodewordBlock> codewordBlocks; // 0x10
}

// Namespace: 
private struct <>c__DisplayClass23_0 
{
	// Fields
	public ECCLevel level; // 0x10
	public BitArray fStrEcc; // 0x18
	public int maskVersion; // 0x20
}

// Namespace: 
private sealed class <>c__DisplayClass31_0 
{
	// Fields
	public ECCLevel eccLevel; // 0x10
	public EncodingMode encMode; // 0x14
	public System.Func<QRCoder.QRCodeGenerator.VersionInfoDetails,System.Boolean> <>9__2; // 0x18
	public System.Func<QRCoder.QRCodeGenerator.VersionInfoDetails,System.Boolean> <>9__3; // 0x20

	// Methods

	// RVA: 0xDEDC38
	void .ctor() { }

	// RVA: 0xDF6114
	bool <GetVersion>b__0(VersionInfo x) { }

	// RVA: 0xDF61D8
	bool <GetVersion>b__2(VersionInfoDetails y) { }

	// RVA: 0xDF61E8
	int <GetVersion>b__1(VersionInfo x) { }

	// RVA: 0xDF62F8
	bool <GetVersion>b__3(VersionInfoDetails y) { }

}

// Namespace: QRCoder
public class QRCodeGenerator 
{
	// Fields
	private static readonly Char[] alphanumEncTable; // 0x0
	private static readonly int[] capacityBaseValues; // 0x8
	private static readonly int[] capacityECCBaseValues; // 0x10
	private static readonly int[] alignmentPatternBaseValues; // 0x18
	private static readonly int[] remainderBits; // 0x20
	private static readonly System.Collections.Generic.Dictionary<System.Int32,QRCoder.QRCodeGenerator.AlignmentPattern> alignmentPatternTable; // 0x28
	private static readonly System.Collections.Generic.List<QRCoder.QRCodeGenerator.ECCInfo> capacityECCTable; // 0x30
	private static readonly System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfo> capacityTable; // 0x38
	private static readonly int[] galoisFieldByExponentAlpha; // 0x40
	private static readonly int[] galoisFieldByIntegerValue; // 0x48
	private static readonly System.Collections.Generic.Dictionary<System.Char,System.Int32> alphanumEncDict; // 0x50
	private static readonly BitArray _repeatingPattern; // 0x58
	private static readonly BitArray _getFormatGenerator; // 0x60
	private static readonly BitArray _getFormatMask; // 0x68
	private static readonly BitArray _getVersionGenerator; // 0x70
	private static readonly Encoding _iso88591ExceptionFallback; // 0x78
	private static readonly BitArray _emptyBitArray; // 0x80
	private static readonly Encoding _iso8859_1; // 0x88

	// Methods

	// RVA: 0xDEA42C
	void .ctor() { }

	// RVA: 0xDEA434
	QRCodeData CreateQrCode(Byte[] binaryData, ECCLevel eccLevel) { }

	// RVA: 0xDEA4C0
	QRCodeData GenerateQrCode(Byte[] binaryData, ECCLevel eccLevel) { }

	// RVA: 0xDEA638
	ECCLevel ValidateECCLevel(ECCLevel eccLevel) { }

	// RVA: 0xDEAEF8
	QRCodeData GenerateQrCode(BitArray bitArray, ECCLevel eccLevel, int version) { }

	// RVA: 0xDEC154
	void GetFormatString(BitArray fStrEcc, ECCLevel level, int maskVersion) { }

	// RVA: 0xDEC894
	void TrimLeadingZeros(BitArray fStrEcc, ref int index, ref int count) { }

	// RVA: 0xDEC750
	void ShiftTowardsBit0(BitArray fStrEcc, int num) { }

	// RVA: 0xDEC7F4
	void ShiftAwayFromBit0(BitArray fStrEcc, int num) { }

	// RVA: 0xDEC908
	void GetVersionString(BitArray vStr, int version) { }

	// RVA: 0xDECD0C
	Byte[] CalculateECCWords(BitArray bitArray, int offset, int count, ECCInfo eccInfo, Polynom generatorPolynomBase) { }

	// RVA: 0xDED788
	void ConvertToDecNotationInPlace(Polynom poly) { }

	// RVA: 0xDEA6E4
	int GetVersion(int length, EncodingMode encMode, ECCLevel eccLevel) { }

	// RVA: 0xDED104
	Polynom CalculateMessagePolynom(BitArray bitArray, int offset, int count) { }

	// RVA: 0xDEDDF0
	Polynom CalculateGeneratorPolynom(int numEccWords) { }

	// RVA: 0xDEDD58
	int BinToDec(BitArray bitArray, int offset, int count) { }

	// RVA: 0xDEAE78
	int DecToBin(int decNum, int bits, BitArray bitList, int index) { }

	// RVA: 0xDEACA8
	int GetCountIndicatorLength(int version, EncodingMode encMode) { }

	// RVA: 0xDEAD18
	BitArray ToBitArray(System.ReadOnlySpan<System.Byte> byteArray, int prefixZeros) { }

	// RVA: 0xDED910
	Polynom XORPolynoms(Polynom messagePolynom, Polynom resPolynom) { }

	// RVA: 0xDED690
	Polynom MultiplyGeneratorPolynomByLeadterm(Polynom genPolynom, PolynomItem leadTerm, int lowerExponentBy) { }

	// RVA: 0xDEDFCC
	Polynom MultiplyAlphaPolynoms(Polynom polynomBase, Polynom polynomMultiplier) { }

	// RVA: 0xDEDB98
	int GetIntValFromAlphaExp(int exp) { }

	// RVA: 0xDED5A0
	int GetAlphaExpFromIntVal(int intVal) { }

	// RVA: 0xDEE69C
	int ShrinkAlphaExp(int alphaExp) { }

	// RVA: 0xDEEEA8
	System.Collections.Generic.Dictionary<System.Char,System.Int32> CreateAlphanumEncDict() { }

	// RVA: 0xDEF3A4
	System.Collections.Generic.Dictionary<System.Int32,QRCoder.QRCodeGenerator.AlignmentPattern> CreateAlignmentPatternTable() { }

	// RVA: 0xDEF9E4
	System.Collections.Generic.List<QRCoder.QRCodeGenerator.ECCInfo> CreateCapacityECCTable() { }

	// RVA: 0xDEFD30
	System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfo> CreateCapacityTable() { }

	// RVA: 0xDF04E8
	void Dispose() { }

	// RVA: 0xDF04EC
	void .cctor() { }

	// RVA: 0xDEC658
	void <GetFormatString>g__WriteEccLevelAndVersion|23_0(ref QRCoder.QRCodeGenerator.<>c__DisplayClass23_0& ) { }

	// RVA: 0xDEE710
	int[] <MultiplyAlphaPolynoms>g__GetNotUniqueExponents|52_1(Polynom list) { }

	// RVA: 0xDEEE40
	void <GetAlphaExpFromIntVal>g__ThrowIntValOutOfRangeException|54_0() { }

}

// Namespace: QRCoder.Unity
public class UnityQRCode 
{
	// Methods

	// RVA: 0xDF6308
	void .ctor(QRCodeData data) { }

	// RVA: 0xDF633C
	Texture2D GetGraphic(int pixelsPerModule) { }

	// RVA: 0xDF6360
	Texture2D GetGraphic(int pixelsPerModule, Color darkColor, Color lightColor) { }

	// RVA: 0xDF6594
	Color[] GetBrush(int sizeX, int sizeY, Color defaultColor) { }

}

// Namespace: QRCoder.Exceptions
public class DataTooLongException 
{
	// Methods

	// RVA: 0xDEDC40
	void .ctor(string eccLevel, string encodingMode, int maxSizeByte) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=11 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=13 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=15 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=16 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=18 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=160 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1024 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=1120 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=2560 
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=3840 
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=160 0F6AB72C1131EC25DB11E9215243CB2D7940C4362ED9CF8BBC14E12A0C2736D9; // 0x0
	internal static readonly __StaticArrayInitTypeSize=13 38CE4B211E7565E716F2C671E8CF234F65410198B95789BD640D618BF0E68125; // 0xA0
	internal static readonly __StaticArrayInitTypeSize=2560 6B0294FA96970FD8F93B430E941D5C2DC7E62E232AC5F2080FA2592639DAA92D; // 0xAD
	internal static readonly __StaticArrayInitTypeSize=18 8F2A9ED1BD48A4F03F9B24E204863FBA2EA168B70F01266C739E84C6C3B20FAF; // 0xAAD
	internal static readonly __StaticArrayInitTypeSize=3840 AE4865556499F7A4B79C7AFD2087D682CFD2F2224CCFE5B3428F1825284C5C59; // 0xABF
	internal static readonly __StaticArrayInitTypeSize=1024 C511AC322D19491FC1AEC0F16E619EA93B85F0A8B64D249B4FD2A36037ABFF21; // 0x19BF
	internal static readonly __StaticArrayInitTypeSize=1024 CA82D122A356FBE817025CB720461B079B14CC7C7803DD9C3EF8E92A23FE16E8; // 0x1DBF
	internal static readonly __StaticArrayInitTypeSize=15 E816602213C85AE4EBF680D93CDD59DC2023D72720808B3BD230F2476DB1C7EE; // 0x21BF
	internal static readonly __StaticArrayInitTypeSize=16 EC922EFE6A74929B8C28F907C099B26612DEB610EC9B837AEA669FE64C699F5B; // 0x21CE
	internal static readonly __StaticArrayInitTypeSize=11 F5FB1B566BD838D7A5BC77321B3019347A4B565E33EE21B28EEF49F1A4634637; // 0x21DE
	internal static readonly __StaticArrayInitTypeSize=1120 FF44D0C42F4B010881CFB92F17D48FE9E0DCC62F497BF388AEFD339D45C5D73E; // 0x21E9
}


