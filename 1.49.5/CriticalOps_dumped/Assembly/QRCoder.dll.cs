// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xE20998
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class RefSafetyRulesAttribute
{
	// Fields
	public readonly int Version; // 0x10

	// Methods

	// RVA: 0xE209A0
	public void .ctor(int ) { }

}

// Namespace: QRCoder
public abstract class AbstractQRCode
{
	// Fields
	private QRCodeData <QrCodeData>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE209CC
	protected QRCodeData get_QrCodeData() { }

	// RVA: 0xE209D4
	protected void set_QrCodeData(QRCodeData value) { }

	// RVA: 0xE209DC
	protected void .ctor(QRCodeData data) { }

}

// Namespace: QRCoder
internal static class BitArrayExtensions
{
	// Methods

	// RVA: 0xE20A10
	public static int CopyTo(BitArray source, BitArray destination, int sourceOffset, int destinationOffset, int count) { }

}

// Namespace: QRCoder
public class QRCodeData
{
	// Fields
	private System.Collections.Generic.List<System.Collections.BitArray> <ModuleMatrix>k__BackingField; // 0x10
	private int <Version>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE20AB8
	public System.Collections.Generic.List<System.Collections.BitArray> get_ModuleMatrix() { }

	// RVA: 0xE20AC0
	public void set_ModuleMatrix(System.Collections.Generic.List<System.Collections.BitArray> value) { }

	// RVA: 0xE20AC8
	public void .ctor(int version, bool addPadding) { }

	// RVA: 0xE20C08
	private void set_Version(int value) { }

	// RVA: 0xE20BFC
	private static int ModulesPerSideFromVersion(int version) { }

	// RVA: 0xE20C10
	public void Dispose() { }

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

	// RVA: 0xE27224
	public void .ctor(int codeWordsOffset, int codeWordsLength, Byte[] eccWords) { }

	// RVA: 0xE27234
	public int get_CodeWordsOffset() { }

	// RVA: 0xE2723C
	public int get_CodeWordsLength() { }

	// RVA: 0xE27244
	public Byte[] get_ECCWords() { }

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

	// RVA: 0xE2652C
	public void .ctor(int version, ECCLevel errorCorrectionLevel, int totalDataCodewords, int eccPerBlock, int blocksInGroup1, int codewordsInGroup1, int blocksInGroup2, int codewordsInGroup2) { }

	// RVA: 0xE2724C
	public int get_Version() { }

	// RVA: 0xE27254
	public ECCLevel get_ErrorCorrectionLevel() { }

	// RVA: 0xE2725C
	public int get_TotalDataCodewords() { }

	// RVA: 0xE27264
	public int get_ECCPerBlock() { }

	// RVA: 0xE2726C
	public int get_BlocksInGroup1() { }

	// RVA: 0xE27274
	public int get_CodewordsInGroup1() { }

	// RVA: 0xE2727C
	public int get_BlocksInGroup2() { }

	// RVA: 0xE27284
	public int get_CodewordsInGroup2() { }

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

	// RVA: 0xE2B70C
	public void .ctor(int size) { }

	// RVA: 0xE2984C
	public void Add(Rectangle rect) { }

	// RVA: 0xE27F28
	public bool IsBlocked(int x, int y) { }

	// RVA: 0xE2B4A4
	public bool IsBlocked(Rectangle r1) { }

	// RVA: 0xE2B898
	public void Dispose() { }

}

// Namespace: 
private static class MaskPattern
{
	// Fields
	public static readonly System.Collections.Generic.List<System.Func<System.Int32,System.Int32,System.Boolean>> Patterns; // 0x0

	// Methods

	// RVA: 0xE2B8F4
	public static bool Pattern1(int x, int y) { }

	// RVA: 0xE2B904
	public static bool Pattern2(int x, int y) { }

	// RVA: 0xE2B910
	public static bool Pattern3(int x, int y) { }

	// RVA: 0xE2B934
	public static bool Pattern4(int x, int y) { }

	// RVA: 0xE2B95C
	public static bool Pattern5(int x, int y) { }

	// RVA: 0xE2B9FC
	public static bool Pattern6(int x, int y) { }

	// RVA: 0xE2BA38
	public static bool Pattern7(int x, int y) { }

	// RVA: 0xE2BA68
	public static bool Pattern8(int x, int y) { }

	// RVA: 0xE27F64
	public static int Score(QRCodeData qrCode) { }

	// RVA: 0xE2BA9C
	private static void .cctor() { }

}

// Namespace: 
private static class ModulePlacer
{
	// Methods

	// RVA: 0xE2728C
	public static void PlaceVersion(QRCodeData qrCode, BitArray versionStr, bool offset) { }

	// RVA: 0xE27514
	public static void PlaceFormat(QRCodeData qrCode, BitArray formatStr, bool offset) { }

	// RVA: 0xE276DC
	public static int MaskCode(QRCodeData qrCode, int version, BlockedModules blockedModules, ECCLevel eccLevel) { }

	// RVA: 0xE28DF0
	public static void PlaceDataWords(QRCodeData qrCode, BitArray data, BlockedModules blockedModules) { }

	// RVA: 0xE29130
	public static void ReserveSeperatorAreas(int size, BlockedModules blockedModules) { }

	// RVA: 0xE29900
	public static void ReserveVersionAreas(int size, int version, BlockedModules blockedModules) { }

	// RVA: 0xE2A32C
	public static void PlaceDarkModule(QRCodeData qrCode, int version, BlockedModules blockedModules) { }

	// RVA: 0xE2A404
	public static void PlaceFinderPatterns(QRCodeData qrCode, BlockedModules blockedModules) { }

	// RVA: 0xE2A8F8
	public static void PlaceAlignmentPatterns(QRCodeData qrCode, System.Collections.Generic.List<QRCoder.QRCodeGenerator.Point> alignmentPatternLocations, BlockedModules blockedModules) { }

	// RVA: 0xE2B570
	public static void PlaceTimingPatterns(QRCodeData qrCode, BlockedModules blockedModules) { }

}

// Namespace: 
private struct Point
{
	// Fields
	private readonly int <X>k__BackingField; // 0x10
	private readonly int <Y>k__BackingField; // 0x14

	// Methods

	// RVA: 0xE2BD84
	public int get_X() { }

	// RVA: 0xE2BD8C
	public int get_Y() { }

	// RVA: 0xE261F0
	public void .ctor(int x, int y) { }

	// RVA: 0xE2BD94
	public bool Equals(Point other) { }

}

// Namespace: 
public struct PolynumEnumerator
{
	// Fields
	private Polynom _polynom; // 0x10
	private int _index; // 0x20

	// Methods

	// RVA: 0xE2C6A0
	public void .ctor(Polynom polynom) { }

	// RVA: 0xE24E8C
	public PolynomItem get_Current() { }

	// RVA: 0xE24E94
	public bool MoveNext() { }

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

	// RVA: 0xE24538
	public void .ctor(int count) { }

	// RVA: 0xE23D1C
	public void Add(PolynomItem item) { }

	// RVA: 0xE23C88
	public void RemoveAt(int index) { }

	// RVA: 0xE23B80
	public PolynomItem get_Item(int index) { }

	// RVA: 0xE23C08
	public void set_Item(int index, PolynomItem value) { }

	// RVA: 0xE2BFEC
	private static void ThrowIndexOutOfRangeException() { }

	// RVA: 0xE2C02C
	public int get_Count() { }

	// RVA: 0xE247D8
	public void Clear() { }

	// RVA: 0xE23B20
	public Polynom Clone() { }

	// RVA: 0xE25554
	public void Sort(System.Func<QRCoder.QRCodeGenerator.PolynomItem,QRCoder.QRCodeGenerator.PolynomItem,System.Int32> comparer) { }

	// RVA: 0xE2C21C
	public override string ToString() { }

	// RVA: 0xE2437C
	public void Dispose() { }

	// RVA: 0xE2BF74
	private void AssertCapacity(int min) { }

	// RVA: 0xE2BDBC
	private static PolynomItem[] RentArray(int count) { }

	// RVA: 0xE2C45C
	private static void ReturnArray(PolynomItem[] array) { }

	// RVA: 0xE24E50
	public PolynumEnumerator GetEnumerator() { }

	// RVA: 0xE2C034
	internal static void <Sort>g__QuickSort|13_0(int left, int right, QRCoder.QRCodeGenerator.Polynom.<>c__DisplayClass13_0& ) { }

	// RVA: 0xE2C590
	internal static void <AssertCapacity>g__ThrowNotSupportedException|16_0() { }

	// RVA: 0xE2C5E4
	internal static void <RentArray>g__ThrowArgumentOutOfRangeException|18_0() { }

	// RVA: 0xE2C64C
	internal static void <ReturnArray>g__ThrowArgumentNullException|19_0() { }

}

// Namespace: 
private struct PolynomItem
{
	// Fields
	private readonly int <Coefficient>k__BackingField; // 0x10
	private readonly int <Exponent>k__BackingField; // 0x14

	// Methods

	// RVA: 0xE23C00
	public void .ctor(int coefficient, int exponent) { }

	// RVA: 0xE2C6D0
	public int get_Coefficient() { }

	// RVA: 0xE2C6D8
	public int get_Exponent() { }

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

	// RVA: 0xE2C6E0
	public int get_X() { }

	// RVA: 0xE2C6E8
	public int get_Y() { }

	// RVA: 0xE2C6F0
	public int get_Width() { }

	// RVA: 0xE2C6F8
	public int get_Height() { }

	// RVA: 0xE29840
	public void .ctor(int x, int y, int w, int h) { }

}

// Namespace: 
private struct VersionInfo
{
	// Fields
	private readonly int <Version>k__BackingField; // 0x10
	private readonly System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfoDetails> <Details>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE26CEC
	public void .ctor(int version, System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfoDetails> versionInfoDetails) { }

	// RVA: 0xE2C700
	public int get_Version() { }

	// RVA: 0xE2C708
	public System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfoDetails> get_Details() { }

}

// Namespace: 
private struct VersionInfoDetails
{
	// Fields
	private readonly ECCLevel <ErrorCorrectionLevel>k__BackingField; // 0x10
	private readonly System.Collections.Generic.Dictionary<QRCoder.QRCodeGenerator.EncodingMode,System.Int32> <CapacityDict>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE26CDC
	public void .ctor(ECCLevel errorCorrectionLevel, System.Collections.Generic.Dictionary<QRCoder.QRCodeGenerator.EncodingMode,System.Int32> capacityDict) { }

	// RVA: 0xE2C710
	public ECCLevel get_ErrorCorrectionLevel() { }

	// RVA: 0xE2C718
	public System.Collections.Generic.Dictionary<QRCoder.QRCodeGenerator.EncodingMode,System.Int32> get_CapacityDict() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly QRCoder.QRCodeGenerator.<>c <>9; // 0x0
	public static System.Func<QRCoder.QRCodeGenerator.PolynomItem,QRCoder.QRCodeGenerator.PolynomItem,System.Int32> <>9__52_0; // 0x8

	// Methods

	// RVA: 0xE2C720
	private static void .cctor() { }

	// RVA: 0xE2C78C
	public void .ctor() { }

	// RVA: 0xE2C794
	internal int <MultiplyAlphaPolynoms>b__52_0(PolynomItem x, PolynomItem y) { }

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

	// RVA: 0xE2189C
	public void .ctor() { }

	// RVA: 0xE2C7C8
	internal bool <GenerateQrCode>b__0(ECCInfo x) { }

	// RVA: 0xE218A4
	internal void <GenerateQrCode>g__PadData|1() { }

	// RVA: 0xE219E8
	internal System.Collections.Generic.List<QRCoder.QRCodeGenerator.CodewordBlock> <GenerateQrCode>g__CalculateECCBlocks|2() { }

	// RVA: 0xE2C7F4
	internal void <GenerateQrCode>g__AddCodeWordBlocks|6(int blockNum, int blocksInGroup, int codewordsInGroup, int offset2, int count, Polynom generatorPolynom, QRCoder.QRCodeGenerator.<>c__DisplayClass20_1& ) { }

	// RVA: 0xE21BB0
	internal int <GenerateQrCode>g__CalculateInterleavedLength|3() { }

	// RVA: 0xE21F98
	internal BitArray <GenerateQrCode>g__InterleaveData|4() { }

	// RVA: 0xE22674
	internal QRCodeData <GenerateQrCode>g__PlaceModules|5() { }

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

	// RVA: 0xE2444C
	public void .ctor() { }

	// RVA: 0xE2C928
	internal bool <GetVersion>b__0(VersionInfo x) { }

	// RVA: 0xE2C9EC
	internal bool <GetVersion>b__2(VersionInfoDetails y) { }

	// RVA: 0xE2C9FC
	internal int <GetVersion>b__1(VersionInfo x) { }

	// RVA: 0xE2CB0C
	internal bool <GetVersion>b__3(VersionInfoDetails y) { }

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

	// RVA: 0xE20C40
	public void .ctor() { }

	// RVA: 0xE20C48
	public QRCodeData CreateQrCode(Byte[] binaryData, ECCLevel eccLevel) { }

	// RVA: 0xE20CD4
	public static QRCodeData GenerateQrCode(Byte[] binaryData, ECCLevel eccLevel) { }

	// RVA: 0xE20E4C
	private static ECCLevel ValidateECCLevel(ECCLevel eccLevel) { }

	// RVA: 0xE2170C
	private static QRCodeData GenerateQrCode(BitArray bitArray, ECCLevel eccLevel, int version) { }

	// RVA: 0xE22968
	private static void GetFormatString(BitArray fStrEcc, ECCLevel level, int maskVersion) { }

	// RVA: 0xE230A8
	private static void TrimLeadingZeros(BitArray fStrEcc, int index, int count) { }

	// RVA: 0xE22F64
	private static void ShiftTowardsBit0(BitArray fStrEcc, int num) { }

	// RVA: 0xE23008
	private static void ShiftAwayFromBit0(BitArray fStrEcc, int num) { }

	// RVA: 0xE2311C
	private static void GetVersionString(BitArray vStr, int version) { }

	// RVA: 0xE23520
	private static Byte[] CalculateECCWords(BitArray bitArray, int offset, int count, ECCInfo eccInfo, Polynom generatorPolynomBase) { }

	// RVA: 0xE23F9C
	private static void ConvertToDecNotationInPlace(Polynom poly) { }

	// RVA: 0xE20EF8
	private static int GetVersion(int length, EncodingMode encMode, ECCLevel eccLevel) { }

	// RVA: 0xE23918
	private static Polynom CalculateMessagePolynom(BitArray bitArray, int offset, int count) { }

	// RVA: 0xE24604
	private static Polynom CalculateGeneratorPolynom(int numEccWords) { }

	// RVA: 0xE2456C
	private static int BinToDec(BitArray bitArray, int offset, int count) { }

	// RVA: 0xE2168C
	private static int DecToBin(int decNum, int bits, BitArray bitList, int index) { }

	// RVA: 0xE214BC
	private static int GetCountIndicatorLength(int version, EncodingMode encMode) { }

	// RVA: 0xE2152C
	private static BitArray ToBitArray(System.ReadOnlySpan<System.Byte> byteArray, int prefixZeros) { }

	// RVA: 0xE24124
	private static Polynom XORPolynoms(Polynom messagePolynom, Polynom resPolynom) { }

	// RVA: 0xE23EA4
	private static Polynom MultiplyGeneratorPolynomByLeadterm(Polynom genPolynom, PolynomItem leadTerm, int lowerExponentBy) { }

	// RVA: 0xE247E0
	private static Polynom MultiplyAlphaPolynoms(Polynom polynomBase, Polynom polynomMultiplier) { }

	// RVA: 0xE243AC
	private static int GetIntValFromAlphaExp(int exp) { }

	// RVA: 0xE23DB4
	private static int GetAlphaExpFromIntVal(int intVal) { }

	// RVA: 0xE24EB0
	private static int ShrinkAlphaExp(int alphaExp) { }

	// RVA: 0xE256BC
	private static System.Collections.Generic.Dictionary<System.Char,System.Int32> CreateAlphanumEncDict() { }

	// RVA: 0xE25BB8
	private static System.Collections.Generic.Dictionary<System.Int32,QRCoder.QRCodeGenerator.AlignmentPattern> CreateAlignmentPatternTable() { }

	// RVA: 0xE261F8
	private static System.Collections.Generic.List<QRCoder.QRCodeGenerator.ECCInfo> CreateCapacityECCTable() { }

	// RVA: 0xE26544
	private static System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfo> CreateCapacityTable() { }

	// RVA: 0xE26CFC
	public void Dispose() { }

	// RVA: 0xE26D00
	private static void .cctor() { }

	// RVA: 0xE22E6C
	internal static void <GetFormatString>g__WriteEccLevelAndVersion|23_0(QRCoder.QRCodeGenerator.<>c__DisplayClass23_0& ) { }

	// RVA: 0xE24F24
	internal static int[] <MultiplyAlphaPolynoms>g__GetNotUniqueExponents|52_1(Polynom list) { }

	// RVA: 0xE25654
	internal static void <GetAlphaExpFromIntVal>g__ThrowIntValOutOfRangeException|54_0() { }

}

// Namespace: QRCoder.Unity
public class UnityQRCode
{
	// Methods

	// RVA: 0xE2CB1C
	public void .ctor(QRCodeData data) { }

	// RVA: 0xE2CB50
	public Texture2D GetGraphic(int pixelsPerModule) { }

	// RVA: 0xE2CB74
	public Texture2D GetGraphic(int pixelsPerModule, Color darkColor, Color lightColor) { }

	// RVA: 0xE2CDA8
	internal Color[] GetBrush(int sizeX, int sizeY, Color defaultColor) { }

}

// Namespace: QRCoder.Exceptions
public class DataTooLongException
{
	// Methods

	// RVA: 0xE24454
	public void .ctor(string eccLevel, string encodingMode, int maxSizeByte) { }

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


