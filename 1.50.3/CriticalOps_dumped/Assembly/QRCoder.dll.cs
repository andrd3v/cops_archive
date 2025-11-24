// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xE39EBC
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class RefSafetyRulesAttribute
{
	// Fields
	public readonly int Version; // 0x10

	// Methods

	// RVA: 0xE39EC4
	public void .ctor(int ) { }

}

// Namespace: QRCoder
public abstract class AbstractQRCode
{
	// Fields
	private QRCodeData <QrCodeData>k__BackingField; // 0x10

	// Methods

	// RVA: 0xE39EF0
	protected QRCodeData get_QrCodeData() { }

	// RVA: 0xE39EF8
	protected void set_QrCodeData(QRCodeData value) { }

	// RVA: 0xE39F00
	protected void .ctor(QRCodeData data) { }

}

// Namespace: QRCoder
internal static class BitArrayExtensions
{
	// Methods

	// RVA: 0xE39F34
	public static int CopyTo(BitArray source, BitArray destination, int sourceOffset, int destinationOffset, int count) { }

}

// Namespace: QRCoder
public class QRCodeData
{
	// Fields
	private System.Collections.Generic.List<System.Collections.BitArray> <ModuleMatrix>k__BackingField; // 0x10
	private int <Version>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE39FDC
	public System.Collections.Generic.List<System.Collections.BitArray> get_ModuleMatrix() { }

	// RVA: 0xE39FE4
	public void set_ModuleMatrix(System.Collections.Generic.List<System.Collections.BitArray> value) { }

	// RVA: 0xE39FEC
	public void .ctor(int version, bool addPadding) { }

	// RVA: 0xE3A12C
	private void set_Version(int value) { }

	// RVA: 0xE3A120
	private static int ModulesPerSideFromVersion(int version) { }

	// RVA: 0xE3A134
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

	// RVA: 0xE40748
	public void .ctor(int codeWordsOffset, int codeWordsLength, Byte[] eccWords) { }

	// RVA: 0xE40758
	public int get_CodeWordsOffset() { }

	// RVA: 0xE40760
	public int get_CodeWordsLength() { }

	// RVA: 0xE40768
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

	// RVA: 0xE3FA50
	public void .ctor(int version, ECCLevel errorCorrectionLevel, int totalDataCodewords, int eccPerBlock, int blocksInGroup1, int codewordsInGroup1, int blocksInGroup2, int codewordsInGroup2) { }

	// RVA: 0xE40770
	public int get_Version() { }

	// RVA: 0xE40778
	public ECCLevel get_ErrorCorrectionLevel() { }

	// RVA: 0xE40780
	public int get_TotalDataCodewords() { }

	// RVA: 0xE40788
	public int get_ECCPerBlock() { }

	// RVA: 0xE40790
	public int get_BlocksInGroup1() { }

	// RVA: 0xE40798
	public int get_CodewordsInGroup1() { }

	// RVA: 0xE407A0
	public int get_BlocksInGroup2() { }

	// RVA: 0xE407A8
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

	// RVA: 0xE44C30
	public void .ctor(int size) { }

	// RVA: 0xE42D70
	public void Add(Rectangle rect) { }

	// RVA: 0xE4144C
	public bool IsBlocked(int x, int y) { }

	// RVA: 0xE449C8
	public bool IsBlocked(Rectangle r1) { }

	// RVA: 0xE44DBC
	public void Dispose() { }

}

// Namespace: 
private static class MaskPattern
{
	// Fields
	public static readonly System.Collections.Generic.List<System.Func<System.Int32,System.Int32,System.Boolean>> Patterns; // 0x0

	// Methods

	// RVA: 0xE44E18
	public static bool Pattern1(int x, int y) { }

	// RVA: 0xE44E28
	public static bool Pattern2(int x, int y) { }

	// RVA: 0xE44E34
	public static bool Pattern3(int x, int y) { }

	// RVA: 0xE44E58
	public static bool Pattern4(int x, int y) { }

	// RVA: 0xE44E80
	public static bool Pattern5(int x, int y) { }

	// RVA: 0xE44F20
	public static bool Pattern6(int x, int y) { }

	// RVA: 0xE44F5C
	public static bool Pattern7(int x, int y) { }

	// RVA: 0xE44F8C
	public static bool Pattern8(int x, int y) { }

	// RVA: 0xE41488
	public static int Score(QRCodeData qrCode) { }

	// RVA: 0xE44FC0
	private static void .cctor() { }

}

// Namespace: 
private static class ModulePlacer
{
	// Methods

	// RVA: 0xE407B0
	public static void PlaceVersion(QRCodeData qrCode, BitArray versionStr, bool offset) { }

	// RVA: 0xE40A38
	public static void PlaceFormat(QRCodeData qrCode, BitArray formatStr, bool offset) { }

	// RVA: 0xE40C00
	public static int MaskCode(QRCodeData qrCode, int version, BlockedModules blockedModules, ECCLevel eccLevel) { }

	// RVA: 0xE42314
	public static void PlaceDataWords(QRCodeData qrCode, BitArray data, BlockedModules blockedModules) { }

	// RVA: 0xE42654
	public static void ReserveSeperatorAreas(int size, BlockedModules blockedModules) { }

	// RVA: 0xE42E24
	public static void ReserveVersionAreas(int size, int version, BlockedModules blockedModules) { }

	// RVA: 0xE43850
	public static void PlaceDarkModule(QRCodeData qrCode, int version, BlockedModules blockedModules) { }

	// RVA: 0xE43928
	public static void PlaceFinderPatterns(QRCodeData qrCode, BlockedModules blockedModules) { }

	// RVA: 0xE43E1C
	public static void PlaceAlignmentPatterns(QRCodeData qrCode, System.Collections.Generic.List<QRCoder.QRCodeGenerator.Point> alignmentPatternLocations, BlockedModules blockedModules) { }

	// RVA: 0xE44A94
	public static void PlaceTimingPatterns(QRCodeData qrCode, BlockedModules blockedModules) { }

}

// Namespace: 
private struct Point
{
	// Fields
	private readonly int <X>k__BackingField; // 0x10
	private readonly int <Y>k__BackingField; // 0x14

	// Methods

	// RVA: 0xE452A8
	public int get_X() { }

	// RVA: 0xE452B0
	public int get_Y() { }

	// RVA: 0xE3F714
	public void .ctor(int x, int y) { }

	// RVA: 0xE452B8
	public bool Equals(Point other) { }

}

// Namespace: 
public struct PolynumEnumerator
{
	// Fields
	private Polynom _polynom; // 0x10
	private int _index; // 0x20

	// Methods

	// RVA: 0xE45BC4
	public void .ctor(Polynom polynom) { }

	// RVA: 0xE3E3B0
	public PolynomItem get_Current() { }

	// RVA: 0xE3E3B8
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

	// RVA: 0xE3DA5C
	public void .ctor(int count) { }

	// RVA: 0xE3D240
	public void Add(PolynomItem item) { }

	// RVA: 0xE3D1AC
	public void RemoveAt(int index) { }

	// RVA: 0xE3D0A4
	public PolynomItem get_Item(int index) { }

	// RVA: 0xE3D12C
	public void set_Item(int index, PolynomItem value) { }

	// RVA: 0xE45510
	private static void ThrowIndexOutOfRangeException() { }

	// RVA: 0xE45550
	public int get_Count() { }

	// RVA: 0xE3DCFC
	public void Clear() { }

	// RVA: 0xE3D044
	public Polynom Clone() { }

	// RVA: 0xE3EA78
	public void Sort(System.Func<QRCoder.QRCodeGenerator.PolynomItem,QRCoder.QRCodeGenerator.PolynomItem,System.Int32> comparer) { }

	// RVA: 0xE45740
	public override string ToString() { }

	// RVA: 0xE3D8A0
	public void Dispose() { }

	// RVA: 0xE45498
	private void AssertCapacity(int min) { }

	// RVA: 0xE452E0
	private static PolynomItem[] RentArray(int count) { }

	// RVA: 0xE45980
	private static void ReturnArray(PolynomItem[] array) { }

	// RVA: 0xE3E374
	public PolynumEnumerator GetEnumerator() { }

	// RVA: 0xE45558
	internal static void <Sort>g__QuickSort|13_0(int left, int right, QRCoder.QRCodeGenerator.Polynom.<>c__DisplayClass13_0& ) { }

	// RVA: 0xE45AB4
	internal static void <AssertCapacity>g__ThrowNotSupportedException|16_0() { }

	// RVA: 0xE45B08
	internal static void <RentArray>g__ThrowArgumentOutOfRangeException|18_0() { }

	// RVA: 0xE45B70
	internal static void <ReturnArray>g__ThrowArgumentNullException|19_0() { }

}

// Namespace: 
private struct PolynomItem
{
	// Fields
	private readonly int <Coefficient>k__BackingField; // 0x10
	private readonly int <Exponent>k__BackingField; // 0x14

	// Methods

	// RVA: 0xE3D124
	public void .ctor(int coefficient, int exponent) { }

	// RVA: 0xE45BF4
	public int get_Coefficient() { }

	// RVA: 0xE45BFC
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

	// RVA: 0xE45C04
	public int get_X() { }

	// RVA: 0xE45C0C
	public int get_Y() { }

	// RVA: 0xE45C14
	public int get_Width() { }

	// RVA: 0xE45C1C
	public int get_Height() { }

	// RVA: 0xE42D64
	public void .ctor(int x, int y, int w, int h) { }

}

// Namespace: 
private struct VersionInfo
{
	// Fields
	private readonly int <Version>k__BackingField; // 0x10
	private readonly System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfoDetails> <Details>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE40210
	public void .ctor(int version, System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfoDetails> versionInfoDetails) { }

	// RVA: 0xE45C24
	public int get_Version() { }

	// RVA: 0xE45C2C
	public System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfoDetails> get_Details() { }

}

// Namespace: 
private struct VersionInfoDetails
{
	// Fields
	private readonly ECCLevel <ErrorCorrectionLevel>k__BackingField; // 0x10
	private readonly System.Collections.Generic.Dictionary<QRCoder.QRCodeGenerator.EncodingMode,System.Int32> <CapacityDict>k__BackingField; // 0x18

	// Methods

	// RVA: 0xE40200
	public void .ctor(ECCLevel errorCorrectionLevel, System.Collections.Generic.Dictionary<QRCoder.QRCodeGenerator.EncodingMode,System.Int32> capacityDict) { }

	// RVA: 0xE45C34
	public ECCLevel get_ErrorCorrectionLevel() { }

	// RVA: 0xE45C3C
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

	// RVA: 0xE45C44
	private static void .cctor() { }

	// RVA: 0xE45CB0
	public void .ctor() { }

	// RVA: 0xE45CB8
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

	// RVA: 0xE3ADC0
	public void .ctor() { }

	// RVA: 0xE45CEC
	internal bool <GenerateQrCode>b__0(ECCInfo x) { }

	// RVA: 0xE3ADC8
	internal void <GenerateQrCode>g__PadData|1() { }

	// RVA: 0xE3AF0C
	internal System.Collections.Generic.List<QRCoder.QRCodeGenerator.CodewordBlock> <GenerateQrCode>g__CalculateECCBlocks|2() { }

	// RVA: 0xE45D18
	internal void <GenerateQrCode>g__AddCodeWordBlocks|6(int blockNum, int blocksInGroup, int codewordsInGroup, int offset2, int count, Polynom generatorPolynom, QRCoder.QRCodeGenerator.<>c__DisplayClass20_1& ) { }

	// RVA: 0xE3B0D4
	internal int <GenerateQrCode>g__CalculateInterleavedLength|3() { }

	// RVA: 0xE3B4BC
	internal BitArray <GenerateQrCode>g__InterleaveData|4() { }

	// RVA: 0xE3BB98
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

	// RVA: 0xE3D970
	public void .ctor() { }

	// RVA: 0xE45E4C
	internal bool <GetVersion>b__0(VersionInfo x) { }

	// RVA: 0xE45F10
	internal bool <GetVersion>b__2(VersionInfoDetails y) { }

	// RVA: 0xE45F20
	internal int <GetVersion>b__1(VersionInfo x) { }

	// RVA: 0xE46030
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

	// RVA: 0xE3A164
	public void .ctor() { }

	// RVA: 0xE3A16C
	public QRCodeData CreateQrCode(Byte[] binaryData, ECCLevel eccLevel) { }

	// RVA: 0xE3A1F8
	public static QRCodeData GenerateQrCode(Byte[] binaryData, ECCLevel eccLevel) { }

	// RVA: 0xE3A370
	private static ECCLevel ValidateECCLevel(ECCLevel eccLevel) { }

	// RVA: 0xE3AC30
	private static QRCodeData GenerateQrCode(BitArray bitArray, ECCLevel eccLevel, int version) { }

	// RVA: 0xE3BE8C
	private static void GetFormatString(BitArray fStrEcc, ECCLevel level, int maskVersion) { }

	// RVA: 0xE3C5CC
	private static void TrimLeadingZeros(BitArray fStrEcc, int index, int count) { }

	// RVA: 0xE3C488
	private static void ShiftTowardsBit0(BitArray fStrEcc, int num) { }

	// RVA: 0xE3C52C
	private static void ShiftAwayFromBit0(BitArray fStrEcc, int num) { }

	// RVA: 0xE3C640
	private static void GetVersionString(BitArray vStr, int version) { }

	// RVA: 0xE3CA44
	private static Byte[] CalculateECCWords(BitArray bitArray, int offset, int count, ECCInfo eccInfo, Polynom generatorPolynomBase) { }

	// RVA: 0xE3D4C0
	private static void ConvertToDecNotationInPlace(Polynom poly) { }

	// RVA: 0xE3A41C
	private static int GetVersion(int length, EncodingMode encMode, ECCLevel eccLevel) { }

	// RVA: 0xE3CE3C
	private static Polynom CalculateMessagePolynom(BitArray bitArray, int offset, int count) { }

	// RVA: 0xE3DB28
	private static Polynom CalculateGeneratorPolynom(int numEccWords) { }

	// RVA: 0xE3DA90
	private static int BinToDec(BitArray bitArray, int offset, int count) { }

	// RVA: 0xE3ABB0
	private static int DecToBin(int decNum, int bits, BitArray bitList, int index) { }

	// RVA: 0xE3A9E0
	private static int GetCountIndicatorLength(int version, EncodingMode encMode) { }

	// RVA: 0xE3AA50
	private static BitArray ToBitArray(System.ReadOnlySpan<System.Byte> byteArray, int prefixZeros) { }

	// RVA: 0xE3D648
	private static Polynom XORPolynoms(Polynom messagePolynom, Polynom resPolynom) { }

	// RVA: 0xE3D3C8
	private static Polynom MultiplyGeneratorPolynomByLeadterm(Polynom genPolynom, PolynomItem leadTerm, int lowerExponentBy) { }

	// RVA: 0xE3DD04
	private static Polynom MultiplyAlphaPolynoms(Polynom polynomBase, Polynom polynomMultiplier) { }

	// RVA: 0xE3D8D0
	private static int GetIntValFromAlphaExp(int exp) { }

	// RVA: 0xE3D2D8
	private static int GetAlphaExpFromIntVal(int intVal) { }

	// RVA: 0xE3E3D4
	private static int ShrinkAlphaExp(int alphaExp) { }

	// RVA: 0xE3EBE0
	private static System.Collections.Generic.Dictionary<System.Char,System.Int32> CreateAlphanumEncDict() { }

	// RVA: 0xE3F0DC
	private static System.Collections.Generic.Dictionary<System.Int32,QRCoder.QRCodeGenerator.AlignmentPattern> CreateAlignmentPatternTable() { }

	// RVA: 0xE3F71C
	private static System.Collections.Generic.List<QRCoder.QRCodeGenerator.ECCInfo> CreateCapacityECCTable() { }

	// RVA: 0xE3FA68
	private static System.Collections.Generic.List<QRCoder.QRCodeGenerator.VersionInfo> CreateCapacityTable() { }

	// RVA: 0xE40220
	public void Dispose() { }

	// RVA: 0xE40224
	private static void .cctor() { }

	// RVA: 0xE3C390
	internal static void <GetFormatString>g__WriteEccLevelAndVersion|23_0(QRCoder.QRCodeGenerator.<>c__DisplayClass23_0& ) { }

	// RVA: 0xE3E448
	internal static int[] <MultiplyAlphaPolynoms>g__GetNotUniqueExponents|52_1(Polynom list) { }

	// RVA: 0xE3EB78
	internal static void <GetAlphaExpFromIntVal>g__ThrowIntValOutOfRangeException|54_0() { }

}

// Namespace: QRCoder.Unity
public class UnityQRCode
{
	// Methods

	// RVA: 0xE46040
	public void .ctor(QRCodeData data) { }

	// RVA: 0xE46074
	public Texture2D GetGraphic(int pixelsPerModule) { }

	// RVA: 0xE46098
	public Texture2D GetGraphic(int pixelsPerModule, Color darkColor, Color lightColor) { }

	// RVA: 0xE462CC
	internal Color[] GetBrush(int sizeX, int sizeY, Color defaultColor) { }

}

// Namespace: QRCoder.Exceptions
public class DataTooLongException
{
	// Methods

	// RVA: 0xE3D978
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


