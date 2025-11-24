// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0xFFF5EC
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

	// RVA: 0xFFF660
	public void .ctor(int value) { }

	// RVA: 0xFFF710
	public void .ctor(UInt32 value) { }

	// RVA: 0xFFF7C4
	public void .ctor(Int64 value) { }

	// RVA: 0xFFF938
	public void .ctor(UInt64 value) { }

	// RVA: 0xFFFA40
	public void .ctor(float value) { }

	// RVA: 0xFFFAB0
	public void .ctor(Double value) { }

	// RVA: 0xFFFE3C
	public void .ctor(Decimal value) { }

	// RVA: 0x1000048
	public void .ctor(Byte[] value) { }

	// RVA: 0x1000118
	public void .ctor(System.ReadOnlySpan<System.Byte> value, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x1000A4C
	internal void .ctor(int n, UInt32[] rgu) { }

	// RVA: 0x1000A5C
	internal void .ctor(UInt32[] value, bool negative) { }

	// RVA: 0x1000C70
	public static BigInteger get_Zero() { }

	// RVA: 0x1000CEC
	public static BigInteger get_MinusOne() { }

	// RVA: 0x1000D68
	public bool get_IsZero() { }

	// RVA: 0x1000D78
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x1000E00
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x1000EE8
	public override int GetHashCode() { }

	// RVA: 0x1000F24
	public override bool Equals(object obj) { }

	// RVA: 0x1001118
	public bool Equals(Int64 other) { }

	// RVA: 0x1000FEC
	public bool Equals(BigInteger other) { }

	// RVA: 0x1001240
	public int CompareTo(Int64 other) { }

	// RVA: 0x10012E8
	public int CompareTo(BigInteger other) { }

	// RVA: 0x100144C
	public int CompareTo(object obj) { }

	// RVA: 0x1001570
	public bool TryWriteBytes(System.Span<System.Byte> destination, int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x1001BDC
	internal bool TryWriteOrCountBytes(System.Span<System.Byte> destination, int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0x1001624
	private Byte[] TryGetBytes(GetBytesMode mode, System.Span<System.Byte> destination, bool isUnsigned, bool isBigEndian, int bytesWritten) { }

	// RVA: 0x1001C88
	public override string ToString() { }

	// RVA: 0x1001DC8
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1001E58
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x1001F14
	private static BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x1002334
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x10023E8
	private static BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0x10028AC
	public static BigInteger op_Implicit(Byte value) { }

	// RVA: 0x1002910
	public static BigInteger op_Implicit(SByte value) { }

	// RVA: 0x1002974
	public static BigInteger op_Implicit(Int16 value) { }

	// RVA: 0x10029D8
	public static BigInteger op_Implicit(UInt16 value) { }

	// RVA: 0x1002A3C
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1002AEC
	public static BigInteger op_Implicit(UInt32 value) { }

	// RVA: 0x1002088
	public static BigInteger op_Implicit(Int64 value) { }

	// RVA: 0xFFFE10
	public static BigInteger op_Implicit(UInt64 value) { }

	// RVA: 0x1002B18
	public static Byte op_Explicit(BigInteger value) { }

	// RVA: 0x1002CCC
	public static SByte op_Explicit(BigInteger value) { }

	// RVA: 0x1002D84
	public static Int16 op_Explicit(BigInteger value) { }

	// RVA: 0x1002E3C
	public static UInt16 op_Explicit(BigInteger value) { }

	// RVA: 0x1002BD0
	public static int op_Explicit(BigInteger value) { }

	// RVA: 0x1002EF4
	public static UInt32 op_Explicit(BigInteger value) { }

	// RVA: 0x1002FA8
	public static Int64 op_Explicit(BigInteger value) { }

	// RVA: 0x1003074
	public static UInt64 op_Explicit(BigInteger value) { }

	// RVA: 0x1003158
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x10031C8
	public static Double op_Explicit(BigInteger value) { }

	// RVA: 0x10034F4
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x1003650
	public static BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0x10038C0
	public static BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0x1003F10
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x1003F44
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x1003FF8
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x1004434
	public static BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0x1004814
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x1004898
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x1004918
	public static bool op_LessThan(BigInteger left, Int64 right) { }

	// RVA: 0x1004A14
	public static bool op_LessThanOrEqual(BigInteger left, Int64 right) { }

	// RVA: 0x1004B14
	public static bool op_Equality(BigInteger left, Int64 right) { }

	// RVA: 0x1004C28
	public static bool op_Inequality(BigInteger left, Int64 right) { }

	// RVA: 0x1004D1C
	public static bool op_LessThan(Int64 left, BigInteger right) { }

	// RVA: 0x1004E1C
	public static bool op_LessThanOrEqual(Int64 left, BigInteger right) { }

	// RVA: 0x1003E28
	private static bool GetPartsForBitManipulation(BigInteger x, UInt32[] xd, int xl) { }

	// RVA: 0x10011A8
	internal static int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	// RVA: 0x1004F1C
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

	// RVA: 0x10020C0
	public static UInt32[] Add(UInt32[] left, UInt32 right) { }

	// RVA: 0x10021A8
	public static UInt32[] Add(UInt32[] left, UInt32[] right) { }

	// RVA: 0x10051A4
	private static void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x1005238
	private static void AddSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0x10025DC
	public static UInt32[] Subtract(UInt32[] left, UInt32 right) { }

	// RVA: 0x1002724
	public static UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	// RVA: 0x10052A8
	private static void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x100269C
	public static int Compare(UInt32[] left, UInt32[] right) { }

	// RVA: 0x1004618
	public static UInt32[] Divide(UInt32[] left, UInt32 right) { }

	// RVA: 0x10046D4
	public static UInt32[] Divide(UInt32[] left, UInt32[] right) { }

	// RVA: 0x10053B0
	private static void Divide(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x10058C8
	private static UInt32 AddDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0x1005880
	private static UInt32 SubtractDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt64 q) { }

	// RVA: 0x1005840
	private static bool DivideGuessTooBig(UInt64 q, UInt64 valHi, UInt32 valLo, UInt32 divHi, UInt32 divLo) { }

	// RVA: 0x1005330
	private static UInt32[] CreateCopy(UInt32[] value) { }

	// RVA: 0x10057C8
	private static int LeadingZeros(UInt32 value) { }

	// RVA: 0x1004278
	public static UInt32[] Square(UInt32[] value) { }

	// RVA: 0x100590C
	private static void Square(UInt32* value, int valueLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x1004198
	public static UInt32[] Multiply(UInt32[] left, UInt32 right) { }

	// RVA: 0x1004340
	public static UInt32[] Multiply(UInt32[] left, UInt32[] right) { }

	// RVA: 0x100619C
	private static void Multiply(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0x10060BC
	private static void SubtractCore(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* core, int coreLength) { }

	// RVA: 0x1006B3C
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

	// RVA: 0x1006F54
	public static BigNumberBuffer Create() { }

}

// Namespace: System.Numerics
internal static class BigNumber
{
	// Methods

	// RVA: 0x1006B90
	internal static bool TryValidateParseStyleInteger(NumberStyles style, ArgumentException e) { }

	// RVA: 0x1006CF4
	internal static bool TryParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info, BigInteger result) { }

	// RVA: 0x1000E38
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x10075D8
	internal static BigInteger ParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x10070CC
	private static bool HexNumberToBigInteger(BigNumberBuffer number, BigInteger value) { }

	// RVA: 0x1007290
	private static bool NumberToBigInteger(BigNumberBuffer number, BigInteger value) { }

	// RVA: 0x1007744
	internal static Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, int digits) { }

	// RVA: 0x1007850
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, Char format, int digits, NumberFormatInfo info, System.Span<System.Char> destination, int charsWritten, bool spanSuccess) { }

	// RVA: 0x1001D14
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x1008798
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

	// RVA: 0xFFFD94
	public static void GetDoubleParts(Double dbl, int sign, int exp, UInt64 man, bool fFinite) { }

	// RVA: 0x1003398
	public static Double GetDoubleFromParts(int sign, int exp, UInt64 man) { }

	// RVA: 0x1000928
	public static void DangerousMakeTwosComplement(UInt32[] d) { }

	// RVA: 0x100119C
	public static UInt64 MakeUlong(UInt32 uHi, UInt32 uLo) { }

	// RVA: 0x10020B4
	public static UInt32 Abs(int a) { }

	// RVA: 0x1009894
	public static UInt32 CombineHash(UInt32 u1, UInt32 u2) { }

	// RVA: 0x1000F1C
	public static int CombineHash(int n1, int n2) { }

	// RVA: 0x1003320
	public static int CbitHighZero(UInt32 u) { }

	// RVA: 0x10097A4
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

	// RVA: 0x100F300
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

	// RVA: 0x100BAD8
	private static bool IsWhite(Char ch) { }

	// RVA: 0x100BAEC
	private static Char* MatchChars(Char* p, Char* pEnd, string str) { }

	// RVA: 0x100BBD4
	private static Char* MatchChars(Char* p, Char* pEnd, Char* str) { }

	// RVA: 0x100BC3C
	private static bool ParseNumber(Char* str, Char* strEnd, NumberStyles options, NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x100CC3C
	private static bool TrailingZeros(System.ReadOnlySpan<System.Char> s, int index) { }

	// RVA: 0x100B928
	internal static bool TryStringToNumber(System.ReadOnlySpan<System.Char> str, NumberStyles options, NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x100CCE8
	internal static void Int32ToDecChars(Char* buffer, int index, UInt32 value, int digits) { }

	// RVA: 0x100989C
	internal static Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, int digits) { }

	// RVA: 0x1009A14
	internal static void NumberToString(ValueStringBuilder sb, NumberBuffer number, Char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x100CE44
	private static void FormatCurrency(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x100E20C
	private static int wcslen(Char* s) { }

	// RVA: 0x100D0E4
	private static void FormatFixed(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x100D67C
	private static void FormatNumber(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x100D8FC
	private static void FormatScientific(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar) { }

	// RVA: 0x100E4EC
	private static void FormatExponent(ValueStringBuilder sb, NumberFormatInfo info, int value, Char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x100DB9C
	private static void FormatGeneral(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar, bool bSuppressScientific) { }

	// RVA: 0x100DF6C
	private static void FormatPercent(ValueStringBuilder sb, NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x100CD44
	private static void RoundNumber(NumberBuffer number, int pos) { }

	// RVA: 0x100E834
	private static int FindSection(System.ReadOnlySpan<System.Char> format, int section) { }

	// RVA: 0x100A544
	internal static void NumberToStringFormat(ValueStringBuilder sb, NumberBuffer number, System.ReadOnlySpan<System.Char> format, NumberFormatInfo info) { }

	// RVA: 0x100E97C
	private static void .cctor() { }

}

// Namespace: System.Globalization
internal class FormatProvider
{
	// Methods

	// RVA: 0x1009650
	internal static void FormatBigInteger(ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<System.Char> format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

	// RVA: 0x1006FE0
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

	// RVA: 0x1008154
	public void .ctor(System.Span<System.Char> initialBuffer) { }

	// RVA: 0x100F308
	public int get_Length() { }

	// RVA: 0x1008664
	public override string ToString() { }

	// RVA: 0x1008514
	public bool TryCopyTo(System.Span<System.Char> destination, int charsWritten) { }

	// RVA: 0x1008268
	public void Insert(int index, Char value, int count) { }

	// RVA: 0x100F7A4
	public void Append(Char c) { }

	// RVA: 0x100F8C4
	public void Append(string s) { }

	// RVA: 0x100F974
	private void AppendSlow(string s) { }

	// RVA: 0x100E374
	public void Append(Char c, int count) { }

	// RVA: 0x100E238
	public void Append(Char* value, int length) { }

	// RVA: 0x100FADC
	public System.Span<System.Char> AppendSpan(int length) { }

	// RVA: 0x100F830
	private void GrowAndAppend(Char c) { }

	// RVA: 0x100F478
	private void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0x100FBF8
	public void Dispose() { }

}


