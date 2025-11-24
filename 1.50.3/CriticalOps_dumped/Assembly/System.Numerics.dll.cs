// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x1027E40
	internal static string Format(string resourceFormat, object p1) { }

}

// Namespace: 
private enum GetBytesMode
{
	// Fields
	public int value__; // 0x10
	public const GetBytesMode AllocateArray = 0;
	public const GetBytesMode Count = 1;
	public const GetBytesMode Span = 2;
}

// Namespace: System.Numerics
[Serializable]
public struct BigInteger
{
	// Fields
	internal readonly int _sign; // 0x10
	internal readonly UInt32[] _bits; // 0x18
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly Byte[] s_success; // 0x40

	// Methods

	// RVA: 0x1027EB4
	public void .ctor(int value) { }

	// RVA: 0x1027F64
	public void .ctor(UInt32 value) { }

	// RVA: 0x1028018
	public void .ctor(Int64 value) { }

	// RVA: 0x102818C
	public void .ctor(UInt64 value) { }

	// RVA: 0x1028294
	public void .ctor(float value) { }

	// RVA: 0x1028304
	public void .ctor(Double value) { }

	// RVA: 0x1028690
	public void .ctor(Decimal value) { }

	// RVA: 0x102889C
	public void .ctor(Byte[] value) { }

	// RVA: 0x102896C
	public void .ctor(System.ReadOnlySpan<System.Byte> value, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x10292A0
	internal void .ctor(int n, UInt32[] rgu) { }

	// RVA: 0x10292B0
	internal void .ctor(UInt32[] value, bool negative) { }

	// RVA: 0x10294C4
	public static BigInteger get_Zero() { }

	// RVA: 0x1029540
	public static BigInteger get_MinusOne() { }

	// RVA: 0x10295BC
	public bool get_IsZero() { }

	// RVA: 0x10295CC
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x1029654
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x102973C
	public override int GetHashCode() { }

	// RVA: 0x1029778
	public override bool Equals(object obj) { }

	// RVA: 0x102996C
	public bool Equals(Int64 other) { }

	// RVA: 0x1029840
	public bool Equals(BigInteger other) { }

	// RVA: 0x1029A94
	public int CompareTo(Int64 other) { }

	// RVA: 0x1029B3C
	public int CompareTo(BigInteger other) { }

	// RVA: 0x1029CA0
	public int CompareTo(object obj) { }

	// RVA: 0x1029DC4
	public bool TryWriteBytes(System.Span<System.Byte> destination, int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x102A430
	internal bool TryWriteOrCountBytes(System.Span<System.Byte> destination, int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x1029E78
	private Byte[] TryGetBytes(GetBytesMode mode, System.Span<System.Byte> destination, bool isUnsigned, bool isBigEndian, int bytesWritten) { }

	// RVA: 0x102A4DC
	public override string ToString() { }

	// RVA: 0x102A61C
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x102A6AC
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x102A768
	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x102AB88
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x102AC3C
	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x102B100
	public static BigInteger op_Implicit(Byte value) { }

	// RVA: 0x102B164
	public static BigInteger op_Implicit(SByte value) { }

	// RVA: 0x102B1C8
	public static BigInteger op_Implicit(Int16 value) { }

	// RVA: 0x102B22C
	public static BigInteger op_Implicit(UInt16 value) { }

	// RVA: 0x102B290
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x102B340
	public static BigInteger op_Implicit(UInt32 value) { }

	// RVA: 0x102A8DC
	public static BigInteger op_Implicit(Int64 value) { }

	// RVA: 0x1028664
	public static BigInteger op_Implicit(UInt64 value) { }

	// RVA: 0x102B36C
	public static Byte op_Explicit(BigInteger value) { }

	// RVA: 0x102B520
	public static SByte op_Explicit(BigInteger value) { }

	// RVA: 0x102B5D8
	public static Int16 op_Explicit(BigInteger value) { }

	// RVA: 0x102B690
	public static UInt16 op_Explicit(BigInteger value) { }

	// RVA: 0x102B424
	public static int op_Explicit(BigInteger value) { }

	// RVA: 0x102B748
	public static UInt32 op_Explicit(BigInteger value) { }

	// RVA: 0x102B7FC
	public static Int64 op_Explicit(BigInteger value) { }

	// RVA: 0x102B8C8
	public static UInt64 op_Explicit(BigInteger value) { }

	// RVA: 0x102B9AC
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x102BA1C
	public static Double op_Explicit(BigInteger value) { }

	// RVA: 0x102BD48
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x102BEA4
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x102C114
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x102C764
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x102C798
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x102C84C
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x102CC88
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x102D068
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x102D0EC
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x102D16C
	public static bool op_LessThan(BigInteger left, Int64 right) { }

	// RVA: 0x102D268
	public static bool op_LessThanOrEqual(BigInteger left, Int64 right) { }

	// RVA: 0x102D368
	public static bool op_Equality(BigInteger left, Int64 right) { }

	// RVA: 0x102D47C
	public static bool op_Inequality(BigInteger left, Int64 right) { }

	// RVA: 0x102D570
	public static bool op_LessThan(Int64 left, BigInteger right) { }

	// RVA: 0x102D670
	public static bool op_LessThanOrEqual(Int64 left, BigInteger right) { }

	// RVA: 0x102C67C
	private static bool GetPartsForBitManipulation(BigInteger x, UInt32[] xd, int xl) { }

	// RVA: 0x10299FC
	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	// RVA: 0x102D770
	private static void .cctor() { }

}

// Namespace: System.Numerics
internal static class BigIntegerCalculator
{
	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x102A914
	public static UInt32[] Add(UInt32[] left, UInt32 right) { }

	// RVA: 0x102A9FC
	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	// RVA: 0x102D9F8
	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x102DA8C
	private static void AddSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0x102AE30
	public static UInt32[] Subtract(UInt32[] left, UInt32 right) { }

	// RVA: 0x102AF78
	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	// RVA: 0x102DAFC
	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x102AEF0
	public static int Compare(UInt32[] left, UInt32[] right) { }

	// RVA: 0x102CE6C
	public static UInt32[] Divide(UInt32[] left, UInt32 right) { }

	// RVA: 0x102CF28
	public static UInt32[] Divide(UInt32[] left, UInt32[] right) { }

	// RVA: 0x102DC04
	private static void Divide(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x102E11C
	private static UInt32 AddDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0x102E0D4
	private static UInt32 SubtractDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt64 q) { }

	// RVA: 0x102E094
	private static bool DivideGuessTooBig(UInt64 q, UInt64 valHi, UInt32 valLo, UInt32 divHi, UInt32 divLo) { }

	// RVA: 0x102DB84
	private static UInt32[] CreateCopy(UInt32[] value) { }

	// RVA: 0x102E01C
	private static int LeadingZeros(UInt32 value) { }

	// RVA: 0x102CACC
	public static UInt32[] Square(UInt32[] value) { }

	// RVA: 0x102E160
	private static void Square(UInt32* value, int valueLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x102C9EC
	public static UInt32[] Multiply(UInt32[] left, UInt32 right) { }

	// RVA: 0x102CB94
	public static UInt32[] Multiply(UInt32[] left, UInt32[] right) { }

	// RVA: 0x102E9F0
	private static void Multiply(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x102E910
	private static void SubtractCore(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* core, int coreLength) { }

	// RVA: 0x102F390
	private static void .cctor() { }

}

// Namespace: 
private struct BigNumberBuffer
{
	// Fields
	public StringBuilder digits; // 0x10
	public int precision; // 0x18
	public int scale; // 0x1C
	public bool sign; // 0x20

	// Methods

	// RVA: 0x102F7A8
	public static BigNumberBuffer Create() { }

}

// Namespace: System.Numerics
internal static class BigNumber
{
	// Methods

	// RVA: 0x102F3E4
	internal static bool TryValidateParseStyleInteger(NumberStyles style, ArgumentException e) { }

	// RVA: 0x102F548
	internal static bool TryParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info, BigInteger result) { }

	// RVA: 0x102968C
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x102FE2C
	internal static BigInteger ParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x102F920
	private static bool HexNumberToBigInteger(BigNumberBuffer number, BigInteger value) { }

	// RVA: 0x102FAE4
	private static bool NumberToBigInteger(BigNumberBuffer number, BigInteger value) { }

	// RVA: 0x102FF98
	internal static Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, int digits) { }

	// RVA: 0x10300A4
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, Char format, int digits, NumberFormatInfo info, System.Span<System.Char> destination, int charsWritten, bool spanSuccess) { }

	// RVA: 0x102A568
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x1030FEC
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, System.ReadOnlySpan<System.Char> formatSpan, NumberFormatInfo info, System.Span<System.Char> destination, int charsWritten, bool spanSuccess) { }

}

// Namespace: System.Numerics
internal struct DoubleUlong
{
	// Fields
	public Double dbl; // 0x10
	public UInt64 uu; // 0x10
}

// Namespace: System.Numerics
internal static class NumericsHelpers
{
	// Methods

	// RVA: 0x10285E8
	public static void GetDoubleParts(Double dbl, int sign, int exp, UInt64 man, bool fFinite) { }

	// RVA: 0x102BBEC
	public static Double GetDoubleFromParts(int sign, int exp, UInt64 man) { }

	// RVA: 0x102917C
	public static void DangerousMakeTwosComplement(UInt32[] d) { }

	// RVA: 0x10299F0
	public static UInt64 MakeUlong(UInt32 uHi, UInt32 uLo) { }

	// RVA: 0x102A908
	public static UInt32 Abs(int a) { }

	// RVA: 0x10320E8
	public static UInt32 CombineHash(UInt32 u1, UInt32 u2) { }

	// RVA: 0x1029770
	public static int CombineHash(int n1, int n2) { }

	// RVA: 0x102BB74
	public static int CbitHighZero(UInt32 u) { }

	// RVA: 0x1031FF8
	public static int CbitHighZero(UInt64 uu) { }

}

// Namespace: 
internal struct NumberBuffer
{
	// Fields
	public int precision; // 0x10
	public int scale; // 0x14
	public bool sign; // 0x18
	public Char* overrideDigits; // 0x20

	// Methods

	// RVA: 0x1037B54
	public Char* get_digits() { }

}

// Namespace: 
private class Number
{
	// Fields
	private static string[] s_posCurrencyFormats; // 0x0
	private static string[] s_negCurrencyFormats; // 0x8
	private static string[] s_posPercentFormats; // 0x10
	private static string[] s_negPercentFormats; // 0x18
	private static string[] s_negNumberFormats; // 0x20
	private static string s_posNumberFormat; // 0x28

	// Methods

	// RVA: 0x103432C
	private static bool IsWhite(Char ch) { }

	// RVA: 0x1034340
	private static Char* MatchChars(Char* p, Char* pEnd, string str) { }

	// RVA: 0x1034428
	private static Char* MatchChars(Char* p, Char* pEnd, Char* str) { }

	// RVA: 0x1034490
	private static bool ParseNumber(Char* str, Char* strEnd, NumberStyles options, NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x1035490
	private static bool TrailingZeros(System.ReadOnlySpan<System.Char> s, int index) { }

	// RVA: 0x103417C
	internal static bool TryStringToNumber(System.ReadOnlySpan<System.Char> str, NumberStyles options, NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x103553C
	internal static void Int32ToDecChars(Char* buffer, int index, UInt32 value, int digits) { }

	// RVA: 0x10320F0
	internal static Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, int digits) { }

	// RVA: 0x1032268
	internal static void NumberToString(ValueStringBuilder sb, NumberBuffer number, Char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x1035698
	private static void FormatCurrency(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1036A60
	private static int wcslen(Char* s) { }

	// RVA: 0x1035938
	private static void FormatFixed(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x1035ED0
	private static void FormatNumber(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1036150
	private static void FormatScientific(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar) { }

	// RVA: 0x1036D40
	private static void FormatExponent(ValueStringBuilder sb, NumberFormatInfo info, int value, Char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x10363F0
	private static void FormatGeneral(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar, bool bSuppressScientific) { }

	// RVA: 0x10367C0
	private static void FormatPercent(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x1035598
	private static void RoundNumber(NumberBuffer number, int pos) { }

	// RVA: 0x1037088
	private static int FindSection(System.ReadOnlySpan<System.Char> format, int section) { }

	// RVA: 0x1032D98
	internal static void NumberToStringFormat(ValueStringBuilder sb, NumberBuffer number, System.ReadOnlySpan<System.Char> format, NumberFormatInfo info) { }

	// RVA: 0x10371D0
	private static void .cctor() { }

}

// Namespace: System.Globalization
internal class FormatProvider
{
	// Methods

	// RVA: 0x1031EA4
	internal static void FormatBigInteger(ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<System.Char> format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

	// RVA: 0x102F834
	internal static bool TryStringToBigInteger(System.ReadOnlySpan<System.Char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, int precision, int scale, bool sign) { }

}

// Namespace: System.Text
internal struct ValueStringBuilder
{
	// Fields
	private Char[] _arrayToReturnToPool; // 0x10
	private System.Span<System.Char> _chars; // 0x18
	private int _pos; // 0x28

	// Methods

	// RVA: 0x10309A8
	public void .ctor(System.Span<System.Char> initialBuffer) { }

	// RVA: 0x1037B5C
	public int get_Length() { }

	// RVA: 0x1030EB8
	public override string ToString() { }

	// RVA: 0x1030D68
	public bool TryCopyTo(System.Span<System.Char> destination, int charsWritten) { }

	// RVA: 0x1030ABC
	public void Insert(int index, Char value, int count) { }

	// RVA: 0x1037FF8
	public void Append(Char c) { }

	// RVA: 0x1038118
	public void Append(string s) { }

	// RVA: 0x10381C8
	private void AppendSlow(string s) { }

	// RVA: 0x1036BC8
	public void Append(Char c, int count) { }

	// RVA: 0x1036A8C
	public void Append(Char* value, int length) { }

	// RVA: 0x1038330
	public System.Span<System.Char> AppendSpan(int length) { }

	// RVA: 0x1038084
	private void GrowAndAppend(Char c) { }

	// RVA: 0x1037CCC
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x103844C
	public void Dispose() { }

}


