// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x100E91C
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

	// RVA: 0x100E990
	public void .ctor(int value) { }

	// RVA: 0x100EA40
	public void .ctor(UInt32 value) { }

	// RVA: 0x100EAF4
	public void .ctor(Int64 value) { }

	// RVA: 0x100EC68
	public void .ctor(UInt64 value) { }

	// RVA: 0x100ED70
	public void .ctor(float value) { }

	// RVA: 0x100EDE0
	public void .ctor(Double value) { }

	// RVA: 0x100F16C
	public void .ctor(Decimal value) { }

	// RVA: 0x100F378
	public void .ctor(Byte[] value) { }

	// RVA: 0x100F448
	public void .ctor(System.ReadOnlySpan<System.Byte> value, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x100FD7C
	internal void .ctor(int n, UInt32[] rgu) { }

	// RVA: 0x100FD8C
	internal void .ctor(UInt32[] value, bool negative) { }

	// RVA: 0x100FFA0
	public static BigInteger get_Zero() { }

	// RVA: 0x101001C
	public static BigInteger get_MinusOne() { }

	// RVA: 0x1010098
	public bool get_IsZero() { }

	// RVA: 0x10100A8
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x1010130
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1010218
	public override int GetHashCode() { }

	// RVA: 0x1010254
	public override bool Equals(object obj) { }

	// RVA: 0x1010448
	public bool Equals(Int64 other) { }

	// RVA: 0x101031C
	public bool Equals(BigInteger other) { }

	// RVA: 0x1010570
	public int CompareTo(Int64 other) { }

	// RVA: 0x1010618
	public int CompareTo(BigInteger other) { }

	// RVA: 0x101077C
	public int CompareTo(object obj) { }

	// RVA: 0x10108A0
	public bool TryWriteBytes(System.Span<System.Byte> destination, int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x1010F0C
	internal bool TryWriteOrCountBytes(System.Span<System.Byte> destination, int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x1010954
	private Byte[] TryGetBytes(GetBytesMode mode, System.Span<System.Byte> destination, bool isUnsigned, bool isBigEndian, int bytesWritten) { }

	// RVA: 0x1010FB8
	public override string ToString() { }

	// RVA: 0x10110F8
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1011188
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1011244
	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x1011664
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x1011718
	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x1011BDC
	public static BigInteger op_Implicit(Byte value) { }

	// RVA: 0x1011C40
	public static BigInteger op_Implicit(SByte value) { }

	// RVA: 0x1011CA4
	public static BigInteger op_Implicit(Int16 value) { }

	// RVA: 0x1011D08
	public static BigInteger op_Implicit(UInt16 value) { }

	// RVA: 0x1011D6C
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1011E1C
	public static BigInteger op_Implicit(UInt32 value) { }

	// RVA: 0x10113B8
	public static BigInteger op_Implicit(Int64 value) { }

	// RVA: 0x100F140
	public static BigInteger op_Implicit(UInt64 value) { }

	// RVA: 0x1011E48
	public static Byte op_Explicit(BigInteger value) { }

	// RVA: 0x1011FFC
	public static SByte op_Explicit(BigInteger value) { }

	// RVA: 0x10120B4
	public static Int16 op_Explicit(BigInteger value) { }

	// RVA: 0x101216C
	public static UInt16 op_Explicit(BigInteger value) { }

	// RVA: 0x1011F00
	public static int op_Explicit(BigInteger value) { }

	// RVA: 0x1012224
	public static UInt32 op_Explicit(BigInteger value) { }

	// RVA: 0x10122D8
	public static Int64 op_Explicit(BigInteger value) { }

	// RVA: 0x10123A4
	public static UInt64 op_Explicit(BigInteger value) { }

	// RVA: 0x1012488
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x10124F8
	public static Double op_Explicit(BigInteger value) { }

	// RVA: 0x1012824
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x1012980
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x1012BF0
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x1013240
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x1013274
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x1013328
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x1013764
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x1013B44
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x1013BC8
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x1013C48
	public static bool op_LessThan(BigInteger left, Int64 right) { }

	// RVA: 0x1013D44
	public static bool op_LessThanOrEqual(BigInteger left, Int64 right) { }

	// RVA: 0x1013E44
	public static bool op_Equality(BigInteger left, Int64 right) { }

	// RVA: 0x1013F58
	public static bool op_Inequality(BigInteger left, Int64 right) { }

	// RVA: 0x101404C
	public static bool op_LessThan(Int64 left, BigInteger right) { }

	// RVA: 0x101414C
	public static bool op_LessThanOrEqual(Int64 left, BigInteger right) { }

	// RVA: 0x1013158
	private static bool GetPartsForBitManipulation(BigInteger x, UInt32[] xd, int xl) { }

	// RVA: 0x10104D8
	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	// RVA: 0x101424C
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

	// RVA: 0x10113F0
	public static UInt32[] Add(UInt32[] left, UInt32 right) { }

	// RVA: 0x10114D8
	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	// RVA: 0x10144D4
	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x1014568
	private static void AddSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0x101190C
	public static UInt32[] Subtract(UInt32[] left, UInt32 right) { }

	// RVA: 0x1011A54
	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	// RVA: 0x10145D8
	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x10119CC
	public static int Compare(UInt32[] left, UInt32[] right) { }

	// RVA: 0x1013948
	public static UInt32[] Divide(UInt32[] left, UInt32 right) { }

	// RVA: 0x1013A04
	public static UInt32[] Divide(UInt32[] left, UInt32[] right) { }

	// RVA: 0x10146E0
	private static void Divide(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x1014BF8
	private static UInt32 AddDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0x1014BB0
	private static UInt32 SubtractDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt64 q) { }

	// RVA: 0x1014B70
	private static bool DivideGuessTooBig(UInt64 q, UInt64 valHi, UInt32 valLo, UInt32 divHi, UInt32 divLo) { }

	// RVA: 0x1014660
	private static UInt32[] CreateCopy(UInt32[] value) { }

	// RVA: 0x1014AF8
	private static int LeadingZeros(UInt32 value) { }

	// RVA: 0x10135A8
	public static UInt32[] Square(UInt32[] value) { }

	// RVA: 0x1014C3C
	private static void Square(UInt32* value, int valueLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x10134C8
	public static UInt32[] Multiply(UInt32[] left, UInt32 right) { }

	// RVA: 0x1013670
	public static UInt32[] Multiply(UInt32[] left, UInt32[] right) { }

	// RVA: 0x10154CC
	private static void Multiply(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x10153EC
	private static void SubtractCore(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* core, int coreLength) { }

	// RVA: 0x1015E6C
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

	// RVA: 0x1016284
	public static BigNumberBuffer Create() { }

}

// Namespace: System.Numerics
internal static class BigNumber
{
	// Methods

	// RVA: 0x1015EC0
	internal static bool TryValidateParseStyleInteger(NumberStyles style, ArgumentException e) { }

	// RVA: 0x1016024
	internal static bool TryParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info, BigInteger result) { }

	// RVA: 0x1010168
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x1016908
	internal static BigInteger ParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x10163FC
	private static bool HexNumberToBigInteger(BigNumberBuffer number, BigInteger value) { }

	// RVA: 0x10165C0
	private static bool NumberToBigInteger(BigNumberBuffer number, BigInteger value) { }

	// RVA: 0x1016A74
	internal static Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, int digits) { }

	// RVA: 0x1016B80
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, Char format, int digits, NumberFormatInfo info, System.Span<System.Char> destination, int charsWritten, bool spanSuccess) { }

	// RVA: 0x1011044
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x1017AC8
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

	// RVA: 0x100F0C4
	public static void GetDoubleParts(Double dbl, int sign, int exp, UInt64 man, bool fFinite) { }

	// RVA: 0x10126C8
	public static Double GetDoubleFromParts(int sign, int exp, UInt64 man) { }

	// RVA: 0x100FC58
	public static void DangerousMakeTwosComplement(UInt32[] d) { }

	// RVA: 0x10104CC
	public static UInt64 MakeUlong(UInt32 uHi, UInt32 uLo) { }

	// RVA: 0x10113E4
	public static UInt32 Abs(int a) { }

	// RVA: 0x1018BC4
	public static UInt32 CombineHash(UInt32 u1, UInt32 u2) { }

	// RVA: 0x101024C
	public static int CombineHash(int n1, int n2) { }

	// RVA: 0x1012650
	public static int CbitHighZero(UInt32 u) { }

	// RVA: 0x1018AD4
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

	// RVA: 0x101E630
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

	// RVA: 0x101AE08
	private static bool IsWhite(Char ch) { }

	// RVA: 0x101AE1C
	private static Char* MatchChars(Char* p, Char* pEnd, string str) { }

	// RVA: 0x101AF04
	private static Char* MatchChars(Char* p, Char* pEnd, Char* str) { }

	// RVA: 0x101AF6C
	private static bool ParseNumber(Char* str, Char* strEnd, NumberStyles options, NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x101BF6C
	private static bool TrailingZeros(System.ReadOnlySpan<System.Char> s, int index) { }

	// RVA: 0x101AC58
	internal static bool TryStringToNumber(System.ReadOnlySpan<System.Char> str, NumberStyles options, NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x101C018
	internal static void Int32ToDecChars(Char* buffer, int index, UInt32 value, int digits) { }

	// RVA: 0x1018BCC
	internal static Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, int digits) { }

	// RVA: 0x1018D44
	internal static void NumberToString(ValueStringBuilder sb, NumberBuffer number, Char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x101C174
	private static void FormatCurrency(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x101D53C
	private static int wcslen(Char* s) { }

	// RVA: 0x101C414
	private static void FormatFixed(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x101C9AC
	private static void FormatNumber(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x101CC2C
	private static void FormatScientific(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar) { }

	// RVA: 0x101D81C
	private static void FormatExponent(ValueStringBuilder sb, NumberFormatInfo info, int value, Char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x101CECC
	private static void FormatGeneral(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar, bool bSuppressScientific) { }

	// RVA: 0x101D29C
	private static void FormatPercent(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x101C074
	private static void RoundNumber(NumberBuffer number, int pos) { }

	// RVA: 0x101DB64
	private static int FindSection(System.ReadOnlySpan<System.Char> format, int section) { }

	// RVA: 0x1019874
	internal static void NumberToStringFormat(ValueStringBuilder sb, NumberBuffer number, System.ReadOnlySpan<System.Char> format, NumberFormatInfo info) { }

	// RVA: 0x101DCAC
	private static void .cctor() { }

}

// Namespace: System.Globalization
internal class FormatProvider
{
	// Methods

	// RVA: 0x1018980
	internal static void FormatBigInteger(ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<System.Char> format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

	// RVA: 0x1016310
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

	// RVA: 0x1017484
	public void .ctor(System.Span<System.Char> initialBuffer) { }

	// RVA: 0x101E638
	public int get_Length() { }

	// RVA: 0x1017994
	public override string ToString() { }

	// RVA: 0x1017844
	public bool TryCopyTo(System.Span<System.Char> destination, int charsWritten) { }

	// RVA: 0x1017598
	public void Insert(int index, Char value, int count) { }

	// RVA: 0x101EAD4
	public void Append(Char c) { }

	// RVA: 0x101EBF4
	public void Append(string s) { }

	// RVA: 0x101ECA4
	private void AppendSlow(string s) { }

	// RVA: 0x101D6A4
	public void Append(Char c, int count) { }

	// RVA: 0x101D568
	public void Append(Char* value, int length) { }

	// RVA: 0x101EE0C
	public System.Span<System.Char> AppendSpan(int length) { }

	// RVA: 0x101EB60
	private void GrowAndAppend(Char c) { }

	// RVA: 0x101E7A8
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x101EF28
	public void Dispose() { }

}


