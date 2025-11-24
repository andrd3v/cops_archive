// Namespace: 
internal class <Module> 
{}

// Namespace: 
internal static class SR 
{
	// Methods

	// RVA: 0xFD80C0
	string Format(string resourceFormat, object p1) { }

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

	// RVA: 0xFD8134
	void .ctor(int value) { }

	// RVA: 0xFD81E4
	void .ctor(UInt32 value) { }

	// RVA: 0xFD8298
	void .ctor(Int64 value) { }

	// RVA: 0xFD840C
	void .ctor(UInt64 value) { }

	// RVA: 0xFD8514
	void .ctor(float value) { }

	// RVA: 0xFD8584
	void .ctor(Double value) { }

	// RVA: 0xFD8910
	void .ctor(Decimal value) { }

	// RVA: 0xFD8B1C
	void .ctor(Byte[] value) { }

	// RVA: 0xFD8BEC
	void .ctor(System.ReadOnlySpan<System.Byte> value, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0xFD9520
	void .ctor(int n, UInt32[] rgu) { }

	// RVA: 0xFD9530
	void .ctor(UInt32[] value, bool negative) { }

	// RVA: 0xFD9744
	BigInteger get_Zero() { }

	// RVA: 0xFD97C0
	BigInteger get_MinusOne() { }

	// RVA: 0xFD983C
	bool get_IsZero() { }

	// RVA: 0xFD984C
	BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0xFD98D4
	BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0xFD99BC
	int GetHashCode() { }

	// RVA: 0xFD99F8
	bool Equals(object obj) { }

	// RVA: 0xFD9BEC
	bool Equals(Int64 other) { }

	// RVA: 0xFD9AC0
	bool Equals(BigInteger other) { }

	// RVA: 0xFD9D14
	int CompareTo(Int64 other) { }

	// RVA: 0xFD9DBC
	int CompareTo(BigInteger other) { }

	// RVA: 0xFD9F20
	int CompareTo(object obj) { }

	// RVA: 0xFDA044
	bool TryWriteBytes(System.Span<System.Byte> destination, out int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0xFDA6B0
	bool TryWriteOrCountBytes(System.Span<System.Byte> destination, out int bytesWritten, bool isUnsigned, bool isBigEndian) { }

	// RVA: 0xFDA0F8
	Byte[] TryGetBytes(GetBytesMode mode, System.Span<System.Byte> destination, bool isUnsigned, bool isBigEndian, ref int bytesWritten) { }

	// RVA: 0xFDA75C
	string ToString() { }

	// RVA: 0xFDA89C
	string ToString(IFormatProvider provider) { }

	// RVA: 0xFDA92C
	string ToString(string format, IFormatProvider provider) { }

	// RVA: 0xFDA9E8
	BigInteger Add(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0xFDAE08
	BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0xFDAEBC
	BigInteger Subtract(UInt32[] leftBits, int leftSign, UInt32[] rightBits, int rightSign) { }

	// RVA: 0xFDB380
	BigInteger op_Implicit(Byte value) { }

	// RVA: 0xFDB3E4
	BigInteger op_Implicit(SByte value) { }

	// RVA: 0xFDB448
	BigInteger op_Implicit(Int16 value) { }

	// RVA: 0xFDB4AC
	BigInteger op_Implicit(UInt16 value) { }

	// RVA: 0xFDB510
	BigInteger op_Implicit(int value) { }

	// RVA: 0xFDB5C0
	BigInteger op_Implicit(UInt32 value) { }

	// RVA: 0xFDAB5C
	BigInteger op_Implicit(Int64 value) { }

	// RVA: 0xFD88E4
	BigInteger op_Implicit(UInt64 value) { }

	// RVA: 0xFDB5EC
	Byte op_Explicit(BigInteger value) { }

	// RVA: 0xFDB7A0
	SByte op_Explicit(BigInteger value) { }

	// RVA: 0xFDB858
	Int16 op_Explicit(BigInteger value) { }

	// RVA: 0xFDB910
	UInt16 op_Explicit(BigInteger value) { }

	// RVA: 0xFDB6A4
	int op_Explicit(BigInteger value) { }

	// RVA: 0xFDB9C8
	UInt32 op_Explicit(BigInteger value) { }

	// RVA: 0xFDBA7C
	Int64 op_Explicit(BigInteger value) { }

	// RVA: 0xFDBB48
	UInt64 op_Explicit(BigInteger value) { }

	// RVA: 0xFDBC2C
	float op_Explicit(BigInteger value) { }

	// RVA: 0xFDBC9C
	Double op_Explicit(BigInteger value) { }

	// RVA: 0xFDBFC8
	Decimal op_Explicit(BigInteger value) { }

	// RVA: 0xFDC124
	BigInteger op_LeftShift(BigInteger value, int shift) { }

	// RVA: 0xFDC394
	BigInteger op_RightShift(BigInteger value, int shift) { }

	// RVA: 0xFDC9E4
	BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0xFDCA18
	BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0xFDCACC
	BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0xFDCF08
	BigInteger op_Division(BigInteger dividend, BigInteger divisor) { }

	// RVA: 0xFDD2E8
	bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0xFDD36C
	bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0xFDD3EC
	bool op_LessThan(BigInteger left, Int64 right) { }

	// RVA: 0xFDD4E8
	bool op_LessThanOrEqual(BigInteger left, Int64 right) { }

	// RVA: 0xFDD5E8
	bool op_Equality(BigInteger left, Int64 right) { }

	// RVA: 0xFDD6FC
	bool op_Inequality(BigInteger left, Int64 right) { }

	// RVA: 0xFDD7F0
	bool op_LessThan(Int64 left, BigInteger right) { }

	// RVA: 0xFDD8F0
	bool op_LessThanOrEqual(Int64 left, BigInteger right) { }

	// RVA: 0xFDC8FC
	bool GetPartsForBitManipulation(ref BigInteger x, out UInt32[] xd, out int xl) { }

	// RVA: 0xFD9C7C
	int GetDiffLength(UInt32[] rgu1, UInt32[] rgu2, int cu) { }

	// RVA: 0xFDD9F0
	void .cctor() { }

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

	// RVA: 0xFDAB94
	UInt32[] Add(UInt32[] left, UInt32 right) { }

	// RVA: 0xFDAC7C
	UInt32[] Add(UInt32[] left, UInt32[] right) { }

	// RVA: 0xFDDC78
	void Add(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0xFDDD0C
	void AddSelf(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0xFDB0B0
	UInt32[] Subtract(UInt32[] left, UInt32 right) { }

	// RVA: 0xFDB1F8
	UInt32[] Subtract(UInt32[] left, UInt32[] right) { }

	// RVA: 0xFDDD7C
	void Subtract(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0xFDB170
	int Compare(UInt32[] left, UInt32[] right) { }

	// RVA: 0xFDD0EC
	UInt32[] Divide(UInt32[] left, UInt32 right) { }

	// RVA: 0xFDD1A8
	UInt32[] Divide(UInt32[] left, UInt32[] right) { }

	// RVA: 0xFDDE84
	void Divide(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0xFDE39C
	UInt32 AddDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength) { }

	// RVA: 0xFDE354
	UInt32 SubtractDivisor(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt64 q) { }

	// RVA: 0xFDE314
	bool DivideGuessTooBig(UInt64 q, UInt64 valHi, UInt32 valLo, UInt32 divHi, UInt32 divLo) { }

	// RVA: 0xFDDE04
	UInt32[] CreateCopy(UInt32[] value) { }

	// RVA: 0xFDE29C
	int LeadingZeros(UInt32 value) { }

	// RVA: 0xFDCD4C
	UInt32[] Square(UInt32[] value) { }

	// RVA: 0xFDE3E0
	void Square(UInt32* value, int valueLength, UInt32* bits, int bitsLength) { }

	// RVA: 0xFDCC6C
	UInt32[] Multiply(UInt32[] left, UInt32 right) { }

	// RVA: 0xFDCE14
	UInt32[] Multiply(UInt32[] left, UInt32[] right) { }

	// RVA: 0xFDEC70
	void Multiply(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* bits, int bitsLength) { }

	// RVA: 0xFDEB90
	void SubtractCore(UInt32* left, int leftLength, UInt32* right, int rightLength, UInt32* core, int coreLength) { }

	// RVA: 0xFDF610
	void .cctor() { }

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

	// RVA: 0xFDFA28
	BigNumberBuffer Create() { }

}

// Namespace: System.Numerics
internal static class BigNumber 
{
	// Methods

	// RVA: 0xFDF664
	bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0xFDF7C8
	bool TryParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0xFD990C
	BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0xFE00AC
	BigInteger ParseBigInteger(System.ReadOnlySpan<System.Char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0xFDFBA0
	bool HexNumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0xFDFD64
	bool NumberToBigInteger(ref BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0xFE0218
	Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, out int digits) { }

	// RVA: 0xFE0324
	string FormatBigIntegerToHex(bool targetSpan, BigInteger value, Char format, int digits, NumberFormatInfo info, System.Span<System.Char> destination, out int charsWritten, out bool spanSuccess) { }

	// RVA: 0xFDA7E8
	string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0xFE126C
	string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, System.ReadOnlySpan<System.Char> formatSpan, NumberFormatInfo info, System.Span<System.Char> destination, out int charsWritten, out bool spanSuccess) { }

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

	// RVA: 0xFD8868
	void GetDoubleParts(Double dbl, out int sign, out int exp, out UInt64 man, out bool fFinite) { }

	// RVA: 0xFDBE6C
	Double GetDoubleFromParts(int sign, int exp, UInt64 man) { }

	// RVA: 0xFD93FC
	void DangerousMakeTwosComplement(UInt32[] d) { }

	// RVA: 0xFD9C70
	UInt64 MakeUlong(UInt32 uHi, UInt32 uLo) { }

	// RVA: 0xFDAB88
	UInt32 Abs(int a) { }

	// RVA: 0xFE2368
	UInt32 CombineHash(UInt32 u1, UInt32 u2) { }

	// RVA: 0xFD99F0
	int CombineHash(int n1, int n2) { }

	// RVA: 0xFDBDF4
	int CbitHighZero(UInt32 u) { }

	// RVA: 0xFE2278
	int CbitHighZero(UInt64 uu) { }

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

	// RVA: 0xFE7DD4
	Char* get_digits() { }

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

	// RVA: 0xFE45AC
	bool IsWhite(Char ch) { }

	// RVA: 0xFE45C0
	Char* MatchChars(Char* p, Char* pEnd, string str) { }

	// RVA: 0xFE46A8
	Char* MatchChars(Char* p, Char* pEnd, Char* str) { }

	// RVA: 0xFE4710
	bool ParseNumber(ref Char* str, Char* strEnd, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0xFE5710
	bool TrailingZeros(System.ReadOnlySpan<System.Char> s, int index) { }

	// RVA: 0xFE43FC
	bool TryStringToNumber(System.ReadOnlySpan<System.Char> str, NumberStyles options, ref NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0xFE57BC
	void Int32ToDecChars(Char* buffer, ref int index, UInt32 value, int digits) { }

	// RVA: 0xFE2370
	Char ParseFormatSpecifier(System.ReadOnlySpan<System.Char> format, out int digits) { }

	// RVA: 0xFE24E8
	void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, Char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0xFE5918
	void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0xFE6CE0
	int wcslen(Char* s) { }

	// RVA: 0xFE5BB8
	void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0xFE6150
	void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0xFE63D0
	void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar) { }

	// RVA: 0xFE6FC0
	void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, Char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0xFE6670
	void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Char expChar, bool bSuppressScientific) { }

	// RVA: 0xFE6A40
	void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0xFE5818
	void RoundNumber(ref NumberBuffer number, int pos) { }

	// RVA: 0xFE7308
	int FindSection(System.ReadOnlySpan<System.Char> format, int section) { }

	// RVA: 0xFE3018
	void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, System.ReadOnlySpan<System.Char> format, NumberFormatInfo info) { }

	// RVA: 0xFE7450
	void .cctor() { }

}

// Namespace: System.Globalization
internal class FormatProvider 
{
	// Methods

	// RVA: 0xFE2124
	void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, System.ReadOnlySpan<System.Char> format, NumberFormatInfo numberFormatInfo, Char[] digits, int startIndex) { }

	// RVA: 0xFDFAB4
	bool TryStringToBigInteger(System.ReadOnlySpan<System.Char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }

}

// Namespace: System.Text
internal struct ValueStringBuilder 
{
	// Fields
	private Char[] _arrayToReturnToPool; // 0x10
	private System.Span<System.Char> _chars; // 0x18
	private int _pos; // 0x28

	// Methods

	// RVA: 0xFE0C28
	void .ctor(System.Span<System.Char> initialBuffer) { }

	// RVA: 0xFE7DDC
	int get_Length() { }

	// RVA: 0xFE1138
	string ToString() { }

	// RVA: 0xFE0FE8
	bool TryCopyTo(System.Span<System.Char> destination, out int charsWritten) { }

	// RVA: 0xFE0D3C
	void Insert(int index, Char value, int count) { }

	// RVA: 0xFE8278
	void Append(Char c) { }

	// RVA: 0xFE8398
	void Append(string s) { }

	// RVA: 0xFE8448
	void AppendSlow(string s) { }

	// RVA: 0xFE6E48
	void Append(Char c, int count) { }

	// RVA: 0xFE6D0C
	void Append(Char* value, int length) { }

	// RVA: 0xFE85B0
	System.Span<System.Char> AppendSpan(int length) { }

	// RVA: 0xFE8304
	void GrowAndAppend(Char c) { }

	// RVA: 0xFE7F4C
	void Grow(int requiredAdditionalCapacity) { }

	// RVA: 0xFE86CC
	void Dispose() { }

}


