// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x10615AC
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

	// RVA: 0x1061620
	public void .ctor(int value) { }

	// RVA: 0x10616D0
	public void .ctor(UInt32 value) { }

	// RVA: 0x1061784
	public void .ctor(Int64 value) { }

	// RVA: 0x10618F8
	public void .ctor(UInt64 value) { }

	// RVA: 0x1061A00
	public void .ctor(float value) { }

	// RVA: 0x1061A70
	public void .ctor(Double value) { }

	// RVA: 0x1061DFC
	public void .ctor(Decimal value) { }

	// RVA: 0x1062008
	public void .ctor(Byte[] value) { }

	// RVA: 0x10620D8
	public void .ctor(System.ReadOnlySpan<System.Byte> value, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x1062A04
	internal void .ctor(int n, UInt32[] rgu) { }

	// RVA: 0x1062A14
	internal void .ctor(UInt32[] value, bool negative) { }

	// RVA: 0x1062C28
	public static BigInteger get_Zero() { }

	// RVA: 0x1062CA4
	public static BigInteger get_MinusOne() { }

	// RVA: 0x1062D20
	public bool get_IsZero() { }

	// RVA: 0x1062D30
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x1062DB8
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1062EA0
	public override int GetHashCode() { }

	// RVA: 0x1062EDC
	public override bool Equals(object obj) { }

	// RVA: 0x10630D0
	public bool Equals(Int64 other) { }

	// RVA: 0x1062FA4
	public bool Equals(BigInteger other) { }

	// RVA: 0x10631F8
	public int CompareTo(Int64 other) { }

	// RVA: 0x10632A0
	public int CompareTo(BigInteger other) { }

	// RVA: 0x1063404
	public int CompareTo(object obj) { }

	// RVA: 0x1063528
	public bool TryWriteBytes(System.Span<System.Byte> destination, int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x1063B94
	internal bool TryWriteOrCountBytes(System.Span<System.Byte> destination, int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x10635DC
	private Byte[] TryGetBytes(GetBytesMode mode, System.Span<System.Byte> destination, bool isUnsigned, bool isBigEndian, int bytesWritten) { }

	// RVA: 0x1063C40
	public override string ToString() { }

	// RVA: 0x1063D80
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1063E10
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1063ECC
	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x10642EC
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x10643A0
	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x1064864
	public static BigInteger op_Implicit(Byte value) { }

	// RVA: 0x10648C8
	public static BigInteger op_Implicit(SByte value) { }

	// RVA: 0x106492C
	public static BigInteger op_Implicit(Int16 value) { }

	// RVA: 0x1064990
	public static BigInteger op_Implicit(UInt16 value) { }

	// RVA: 0x10649F4
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1064AA4
	public static BigInteger op_Implicit(UInt32 value) { }

	// RVA: 0x1064040
	public static BigInteger op_Implicit(Int64 value) { }

	// RVA: 0x1061DD0
	public static BigInteger op_Implicit(UInt64 value) { }

	// RVA: 0x1064AD0
	public static Byte op_Explicit(BigInteger value) { }

	// RVA: 0x1064C84
	public static SByte op_Explicit(BigInteger value) { }

	// RVA: 0x1064D3C
	public static Int16 op_Explicit(BigInteger value) { }

	// RVA: 0x1064DF4
	public static UInt16 op_Explicit(BigInteger value) { }

	// RVA: 0x1064B88
	public static int op_Explicit(BigInteger value) { }

	// RVA: 0x1064EAC
	public static UInt32 op_Explicit(BigInteger value) { }

	// RVA: 0x1064F60
	public static Int64 op_Explicit(BigInteger value) { }

	// RVA: 0x106502C
	public static UInt64 op_Explicit(BigInteger value) { }

	// RVA: 0x1065110
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x1065180
	public static Double op_Explicit(BigInteger value) { }

	// RVA: 0x10654AC
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x1065608
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x1065878
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x1065EC8
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x1065EFC
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x1065FB0
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x10663EC
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x10667CC
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x1066850
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x10668D0
	public static bool op_LessThan(BigInteger left, Int64 right) { }

	// RVA: 0x10669CC
	public static bool op_LessThanOrEqual(BigInteger left, Int64 right) { }

	// RVA: 0x1066ACC
	public static bool op_Equality(BigInteger left, Int64 right) { }

	// RVA: 0x1066BE0
	public static bool op_Inequality(BigInteger left, Int64 right) { }

	// RVA: 0x1066CD4
	public static bool op_LessThan(Int64 left, BigInteger right) { }

	// RVA: 0x1066DD4
	public static bool op_LessThanOrEqual(Int64 left, BigInteger right) { }

	// RVA: 0x1065DE0
	private static bool GetPartsForBitManipulation(BigInteger x, UInt32[] xd, int xl) { }

	// RVA: 0x1063160
	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	// RVA: 0x1066ED4
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

	// RVA: 0x1064078
	public static UInt32[] Add(UInt32[] left, UInt32 right) { }

	// RVA: 0x1064160
	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	// RVA: 0x106715C
	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x10671F0
	private static void AddSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0x1064594
	public static UInt32[] Subtract(UInt32[] left, UInt32 right) { }

	// RVA: 0x10646DC
	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	// RVA: 0x1067260
	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x1064654
	public static int Compare(UInt32[] left, UInt32[] right) { }

	// RVA: 0x10665D0
	public static UInt32[] Divide(UInt32[] left, UInt32 right) { }

	// RVA: 0x106668C
	public static UInt32[] Divide(UInt32[] left, UInt32[] right) { }

	// RVA: 0x1067368
	private static void Divide(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x1067880
	private static UInt32 AddDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0x1067838
	private static UInt32 SubtractDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt64 q) { }

	// RVA: 0x10677F8
	private static bool DivideGuessTooBig(UInt64 q, UInt64 valHi, UInt32 valLo, UInt32 divHi, UInt32 divLo) { }

	// RVA: 0x10672E8
	private static UInt32[] CreateCopy(UInt32[] value) { }

	// RVA: 0x1067780
	private static int LeadingZeros(UInt32 value) { }

	// RVA: 0x1066230
	public static UInt32[] Square(UInt32[] value) { }

	// RVA: 0x10678C4
	private static void Square(UInt32* value, int valueLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x1066150
	public static UInt32[] Multiply(UInt32[] left, UInt32 right) { }

	// RVA: 0x10662F8
	public static UInt32[] Multiply(UInt32[] left, UInt32[] right) { }

	// RVA: 0x1068154
	private static void Multiply(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x1068074
	private static void SubtractCore(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* core, int coreLength) { }

	// RVA: 0x1068B14
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

	// RVA: 0x1068F2C
	public static BigNumberBuffer Create() { }

}

// Namespace: System.Numerics
internal static class BigNumber
{
	// Methods

	// RVA: 0x1068B68
	internal static bool TryValidateParseStyleInteger(NumberStyles style, ArgumentException e) { }

	// RVA: 0x1068CCC
	internal static bool TryParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info, BigInteger result) { }

	// RVA: 0x1062DF0
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x10695B0
	internal static BigInteger ParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x10690A4
	private static bool HexNumberToBigInteger(BigNumberBuffer number, BigInteger value) { }

	// RVA: 0x1069268
	private static bool NumberToBigInteger(BigNumberBuffer number, BigInteger value) { }

	// RVA: 0x106971C
	internal static Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, int digits) { }

	// RVA: 0x1069828
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, Char format, int digits, NumberFormatInfo info, System.Span<System.Char> destination, int charsWritten, bool spanSuccess) { }

	// RVA: 0x1063CCC
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x106A70C
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

	// RVA: 0x1061D54
	public static void GetDoubleParts(Double dbl, int sign, int exp, UInt64 man, bool fFinite) { }

	// RVA: 0x1065350
	public static Double GetDoubleFromParts(int sign, int exp, UInt64 man) { }

	// RVA: 0x10628E0
	public static void DangerousMakeTwosComplement(UInt32[] d) { }

	// RVA: 0x1063154
	public static UInt64 MakeUlong(UInt32 uHi, UInt32 uLo) { }

	// RVA: 0x106406C
	public static UInt32 Abs(int a) { }

	// RVA: 0x106B7A8
	public static UInt32 CombineHash(UInt32 u1, UInt32 u2) { }

	// RVA: 0x1062ED4
	public static int CombineHash(int n1, int n2) { }

	// RVA: 0x10652D8
	public static int CbitHighZero(UInt32 u) { }

	// RVA: 0x106B6B8
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

	// RVA: 0x1071194
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

	// RVA: 0x106D96C
	private static bool IsWhite(Char ch) { }

	// RVA: 0x106D980
	private static Char* MatchChars(Char* p, Char* pEnd, string str) { }

	// RVA: 0x106DA68
	private static Char* MatchChars(Char* p, Char* pEnd, Char* str) { }

	// RVA: 0x106DAD0
	private static bool ParseNumber(Char* str, Char* strEnd, NumberStyles options, NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x106EAD0
	private static bool TrailingZeros(System.ReadOnlySpan<System.Char> s, int index) { }

	// RVA: 0x106D7BC
	internal static bool TryStringToNumber(System.ReadOnlySpan<System.Char> str, NumberStyles options, NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x106EB7C
	internal static void Int32ToDecChars(Char* buffer, int index, UInt32 value, int digits) { }

	// RVA: 0x106B7B0
	internal static Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, int digits) { }

	// RVA: 0x106B928
	internal static void NumberToString(ValueStringBuilder sb, NumberBuffer number, Char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x106ECD8
	private static void FormatCurrency(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x10700A0
	private static int wcslen(Char* s) { }

	// RVA: 0x106EF78
	private static void FormatFixed(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x106F510
	private static void FormatNumber(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x106F790
	private static void FormatScientific(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar) { }

	// RVA: 0x1070380
	private static void FormatExponent(ValueStringBuilder sb, NumberFormatInfo info, int value, Char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x106FA30
	private static void FormatGeneral(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar, bool bSuppressScientific) { }

	// RVA: 0x106FE00
	private static void FormatPercent(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x106EBD8
	private static void RoundNumber(NumberBuffer number, int pos) { }

	// RVA: 0x10706C8
	private static int FindSection(System.ReadOnlySpan<System.Char> format, int section) { }

	// RVA: 0x106C458
	internal static void NumberToStringFormat(ValueStringBuilder sb, NumberBuffer number, System.ReadOnlySpan<System.Char> format, NumberFormatInfo info) { }

	// RVA: 0x1070810
	private static void .cctor() { }

}

// Namespace: System.Globalization
internal class FormatProvider
{
	// Methods

	// RVA: 0x106B564
	internal static void FormatBigInteger(ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<System.Char> format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

	// RVA: 0x1068FB8
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

	// RVA: 0x106A0C8
	public void .ctor(System.Span<System.Char> initialBuffer) { }

	// RVA: 0x107119C
	public int get_Length() { }

	// RVA: 0x106A5D8
	public override string ToString() { }

	// RVA: 0x106A488
	public bool TryCopyTo(System.Span<System.Char> destination, int charsWritten) { }

	// RVA: 0x106A1DC
	public void Insert(int index, Char value, int count) { }

	// RVA: 0x1071638
	public void Append(Char c) { }

	// RVA: 0x1071758
	public void Append(string s) { }

	// RVA: 0x1071808
	private void AppendSlow(string s) { }

	// RVA: 0x1070208
	public void Append(Char c, int count) { }

	// RVA: 0x10700CC
	public void Append(Char* value, int length) { }

	// RVA: 0x1071970
	public System.Span<System.Char> AppendSpan(int length) { }

	// RVA: 0x10716C4
	private void GrowAndAppend(Char c) { }

	// RVA: 0x107130C
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x1071A8C
	public void Dispose() { }

}


