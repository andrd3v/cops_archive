// Namespace: 
internal class <Module> 
{}

// Namespace: 
internal sealed class <>f__AnonymousType0<T0, T1> 
{
	// Fields
	private readonly <member>j__TPar <member>i__Field; // 0x0
	private readonly <data>j__TPar <data>i__Field; // 0x0

	// Methods

	// RVA: 0x309AF8C
	<member>j__TPar get_member() { }

	// RVA: 0x309AF8C
	<data>j__TPar get_data() { }

	// RVA: 0x309AF8C
	void .ctor(<member>j__TPar member, <data>j__TPar data) { }

	// RVA: 0x2FE3174
	bool Equals(object value) { }

	// RVA: 0x2FE32D4
	int GetHashCode() { }

	// RVA: 0x2FE360C
	string ToString() { }

}

// Namespace: MsgPack
internal static class BigEndianBinary 
{
	// Methods

	// RVA: 0xCABAE0
	Int16 ToInt16(Byte[] buffer, int offset) { }

	// RVA: 0xCABB28
	int ToInt32(Byte[] buffer, int offset) { }

	// RVA: 0xCABBA0
	Int64 ToInt64(Byte[] buffer, int offset) { }

	// RVA: 0xCABC78
	Byte ToByte(Byte[] buffer, int offset) { }

	// RVA: 0xCABCA8
	UInt16 ToUInt16(Byte[] buffer, int offset) { }

	// RVA: 0xCABCF0
	UInt32 ToUInt32(Byte[] buffer, int offset) { }

	// RVA: 0xCABD68
	UInt64 ToUInt64(Byte[] buffer, int offset) { }

	// RVA: 0xCABE40
	float ToSingle(Byte[] buffer, int offset) { }

	// RVA: 0xCABF3C
	Double ToDouble(Byte[] buffer, int offset) { }

}

// Namespace: MsgPack
internal static class Binary 
{
	// Fields
	public static readonly Byte[] Empty; // 0x0

	// Methods

	// RVA: 0xCAC068
	string ToHexString(Byte[] blob) { }

	// RVA: 0xCAC0F0
	string ToHexString(Byte[] blob, bool withPrefix) { }

	// RVA: 0xCAC328
	void ToHexString(Byte[] blob, StringBuilder buffer) { }

	// RVA: 0xCAC1F4
	void ToHexStringCore(Byte[] blob, StringBuilder buffer, bool withPrefix) { }

	// RVA: 0xCAC3B0
	Char ToHexChar(int b) { }

	// RVA: 0xCAC3CC
	int ToBits(float value) { }

	// RVA: 0xCAC3DC
	Int64 ToBits(Double value) { }

	// RVA: 0xCAC3E4
	void .cctor() { }

}

// Namespace: MsgPack
internal static class BufferManager 
{
	// Methods

	// RVA: 0xCAC464
	Byte[] NewByteBuffer(int size) { }

	// RVA: 0xCAC4EC
	Char[] NewCharBuffer(int size) { }

}

// Namespace: MsgPack
public abstract class ByteArrayPacker 
{
	// Methods

	// RVA: 0x2FE32D4
	int get_BytesUsed() { }

	// RVA: 0x2FE32D4
	int get_InitialBufferOffset() { }

	// RVA: 0xCAC574
	void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCAC5E0
	System.ArraySegment<System.Byte> GetResultBytes() { }

	// RVA: 0x2FE360C
	Byte[] GetFinalBuffer() { }

}

// Namespace: MsgPack
public abstract class ByteArrayUnpacker 
{
	// Methods

	// RVA: 0xCAC698
	void .ctor() { }

}

// Namespace: MsgPack
internal abstract class ByteBufferAllocator 
{
	// Methods

	// RVA: -1
	bool TryAllocate(Byte[] oldBuffer, int requestSize, out Byte[] newBuffer) { }

	// RVA: 0xCAC6A0
	void .ctor() { }

}

// Namespace: MsgPack
internal sealed class CollectionDebuggerProxy<T0> 
{}

// Namespace: MsgPack
internal static class CollectionOperation 
{
	// Methods

	// RVA: 0x309AF8C
	void CopyTo(System.Collections.Generic.IEnumerable<T> source, int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x309AF8C
	void CopyTo(System.Collections.Generic.IEnumerable<TSource> source, int sourceCount, int index, TDestination[] array, int arrayIndex, int count, System.Func<TSource,TDestination> converter) { }

	// RVA: 0x309AF8C
	void ValidateCopyToArguments(int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x309AF8C
	void CopyTo(System.Collections.Generic.IEnumerable<T> source, int sourceCount, Array array, int arrayIndex) { }

}

// Namespace: MsgPack
internal enum CollectionType 
{
	// Fields
	public int value__; // 0x10
	public const CollectionType None = 0;
	public const CollectionType Array = 1;
	public const CollectionType Map = 2;
}

// Namespace: MsgPack
internal sealed class DictionaryDebuggerProxy<T0, T1> 
{}

// Namespace: MsgPack
internal static class EncodingExtensions 
{
	// Methods

	// RVA: 0xCAC6A8
	bool EncodeString(Encoder source, Char[] chars, int charsOffset, int charsLength, Byte[] buffer, int bufferOffset, int bufferCount, out int charsUsed, out int bytesUsed) { }

	// RVA: 0xCAC6F0
	bool DecodeString(Decoder source, Byte[] bytes, int bytesOffset, int bytesLength, Char[] buffer, StringBuilder result) { }

}

// Namespace: MsgPack
internal sealed class FixedArrayBufferAllocator 
{
	// Fields
	public static readonly ByteBufferAllocator Instance; // 0x0

	// Methods

	// RVA: 0xCAC810
	void .ctor() { }

	// RVA: 0xCAC818
	bool TryAllocate(Byte[] oldBuffer, int requestSize, out Byte[] newBuffer) { }

	// RVA: 0xCAC83C
	void .cctor() { }

}

// Namespace: MsgPack
internal struct Float32Bits 
{
	// Fields
	public readonly float Value; // 0x10
	public readonly Byte Byte0; // 0x10
	public readonly Byte Byte1; // 0x11
	public readonly Byte Byte2; // 0x12
	public readonly Byte Byte3; // 0x13

	// Methods

	// RVA: 0xCAC3D4
	void .ctor(float value) { }

	// RVA: 0xCABEB0
	void .ctor(Byte[] bigEndianBytes, int offset) { }

}

// Namespace: MsgPack
internal struct Float64Bits 
{
	// Fields
	public readonly Double Value; // 0x10
	public readonly Byte Byte0; // 0x10
	public readonly Byte Byte1; // 0x11
	public readonly Byte Byte2; // 0x12
	public readonly Byte Byte3; // 0x13
	public readonly Byte Byte4; // 0x14
	public readonly Byte Byte5; // 0x15
	public readonly Byte Byte6; // 0x16
	public readonly Byte Byte7; // 0x17

	// Methods

	// RVA: 0xCABF6C
	void .ctor(Byte[] bigEndianBytes, int offset) { }

}

// Namespace: MsgPack
public sealed class InvalidMessagePackStreamException 
{
	// Methods

	// RVA: 0xCAC8A8
	void .ctor() { }

	// RVA: 0xCAC92C
	void .ctor(string message) { }

	// RVA: 0xCAC9C0
	void .ctor(string message, Exception inner) { }

	// RVA: 0xCACA58
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: MsgPack
public interface IPackable 
{
	// Methods

	// RVA: 0x2FE47D4
	void PackToMessage(Packer packer, PackingOptions options) { }

}

// Namespace: MsgPack
internal interface IRootUnpacker 
{
	// Methods

	// RVA: 0x2FE32D4
	CollectionType get_CollectionType() { }

	// RVA: -1
	System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: -1
	void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: -1
	MessagePackObject get_LastReadData() { }

	// RVA: -1
	void set_LastReadData(MessagePackObject value) { }

	// RVA: -1
	bool ReadObject(bool isDeep, out MessagePackObject result) { }

}

// Namespace: MsgPack
public interface IUnpackable 
{
	// Methods

	// RVA: 0x2FE4574
	void UnpackFromMessage(Unpacker unpacker) { }

}

// Namespace: MsgPack
public static class KnownExtTypeCode 
{
	// Methods

	// RVA: 0xCACADC
	Byte get_Timestamp() { }

	// RVA: 0xCACAE4
	Byte get_MultidimensionalArray() { }

}

// Namespace: MsgPack
public static class KnownExtTypeName 
{
	// Methods

	// RVA: 0xCACAEC
	string get_Timestamp() { }

	// RVA: 0xCACB30
	string get_MultidimensionalArray() { }

}

// Namespace: MsgPack
public sealed class MessageNotSupportedException 
{
	// Methods

	// RVA: 0xCACB74
	void .ctor() { }

	// RVA: 0xCACBF8
	void .ctor(string message) { }

	// RVA: 0xCACC8C
	void .ctor(string message, Exception inner) { }

	// RVA: 0xCACD24
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: MsgPack
internal sealed class MessagePackByteArrayPacker 
{
	// Fields
	private Byte[] _buffer; // 0x18
	private int _offset; // 0x20
	private readonly int _initialOffset; // 0x24
	private readonly ByteBufferAllocator _allocator; // 0x28

	// Methods

	// RVA: 0xCACDA8
	int get_BytesUsed() { }

	// RVA: 0xCACDB4
	int get_InitialBufferOffset() { }

	// RVA: 0xCACDBC
	void .ctor(Byte[] buffer, int startOffset, ByteBufferAllocator allocator, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCACFA0
	Byte[] GetFinalBuffer() { }

	// RVA: 0xCACFA8
	void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xCAD084
	void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xCAD0A4
	void WriteByte(Byte value) { }

	// RVA: 0xCAD294
	void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xCAD064
	void WriteBytes(Byte[] value) { }

	// RVA: 0xCAD160
	void ThrowEofException(int requiredSize) { }

	// RVA: 0xCAD364
	void PackCore(bool value) { }

	// RVA: 0xCAD390
	void PackCore(Byte value) { }

	// RVA: 0xCAD49C
	void PackCore(SByte value) { }

	// RVA: 0xCAD4C4
	void PackCore(Int16 value) { }

	// RVA: 0xCAD614
	void PackCore(UInt16 value) { }

	// RVA: 0xCAD650
	void PackCore(int value) { }

	// RVA: 0xCAD808
	void PackCore(UInt32 value) { }

	// RVA: 0xCAD858
	void PackCore(Int64 value) { }

	// RVA: 0xCADAC0
	void PackCore(UInt64 value) { }

	// RVA: 0xCADB24
	void PackCore(float value) { }

	// RVA: 0xCADCDC
	void PackCore(Double value) { }

	// RVA: 0xCADF24
	void PackArrayHeaderCore(int length) { }

	// RVA: 0xCADF64
	void PackMapHeaderCore(int length) { }

	// RVA: 0xCADFA0
	void PackStringHeaderCore(int length) { }

	// RVA: 0xCADFFC
	void PackBinaryHeaderCore(int length) { }

	// RVA: 0xCAE030
	void PackRawCore(string value) { }

	// RVA: 0xCAE1E8
	void PackRawCore(Byte[] value) { }

	// RVA: 0xCAE298
	void PackBinaryCore(Byte[] value) { }

	// RVA: 0xCAE318
	void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xCAE454
	void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xCAD3B4
	void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xCAD508
	void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xCAD6B4
	void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xCAD8DC
	void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xCADB2C
	void WriteBytes(Byte header, float value) { }

	// RVA: 0xCADCE4
	void WriteBytes(Byte header, Double value) { }

	// RVA: 0xCAE040
	void WriteBytes(string value, bool allowStr8) { }

}

// Namespace: MsgPack
internal abstract class MessagePackByteArrayUnpacker 
{
	// Fields
	private Byte[] _source; // 0x18
	private int _offset; // 0x20
	private readonly Byte[] _scalarBuffer; // 0x28
	private CollectionType _collectionType; // 0x30
	private MessagePackObject _data; // 0x38

	// Methods

	// RVA: 0xCAE4B0
	System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xCAE528
	void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCAE60C
	MessagePackObject get_LastReadData() { }

	// RVA: 0xCAE618
	void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCAE624
	bool get_IsArrayHeader() { }

	// RVA: 0xCAE634
	bool get_IsMapHeader() { }

	// RVA: 0xCAE644
	bool get_IsCollectionHeader() { }

	// RVA: 0xCAE654
	Int64 get_ItemsCount() { }

	// RVA: 0xCAE8E0
	CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xCAE8E8
	System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xCAE92C
	void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCAE968
	MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xCAE974
	void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCAE980
	bool GetPreviousPosition(out Int64 offsetOrPosition) { }

	// RVA: 0xCAE990
	void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xCAEB88
	bool ReadBinaryCore(int length, ref int offset, out Byte[] result) { }

	// RVA: 0xCAECD0
	bool ReadStringCore(int length, ref int offset, out string result) { }

	// RVA: 0xCAEE70
	bool ReadRawStringCore(int length, ref int offset, out MessagePackString result) { }

	// RVA: 0xCAF188
	bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, out MessagePackObject result) { }

	// RVA: 0xCAF248
	bool ReadByte(out Byte result) { }

	// RVA: 0xCAF380
	bool ReadByteSlow(ReadValueResult header, Byte[] source, ref int offset, out Byte result) { }

	// RVA: 0xCAF83C
	bool ReadNullableByte(out System.Nullable<System.Byte>& result) { }

	// RVA: 0xCAFA14
	bool ReadNullableByteSlow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.Byte>& result) { }

	// RVA: 0xCAFB08
	bool ReadSByte(out SByte result) { }

	// RVA: 0xCAFC34
	bool ReadSByteSlow(ReadValueResult header, Byte[] source, ref int offset, out SByte result) { }

	// RVA: 0xCAFF4C
	bool ReadNullableSByte(out System.Nullable<System.SByte>& result) { }

	// RVA: 0xCB0118
	bool ReadNullableSByteSlow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.SByte>& result) { }

	// RVA: 0xCB020C
	bool ReadInt16(out Int16 result) { }

	// RVA: 0xCB033C
	bool ReadInt16Slow(ReadValueResult header, Byte[] source, ref int offset, out Int16 result) { }

	// RVA: 0xCB0644
	bool ReadNullableInt16(out System.Nullable<System.Int16>& result) { }

	// RVA: 0xCB0814
	bool ReadNullableInt16Slow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.Int16>& result) { }

	// RVA: 0xCB0908
	bool ReadUInt16(out UInt16 result) { }

	// RVA: 0xCB0A44
	bool ReadUInt16Slow(ReadValueResult header, Byte[] source, ref int offset, out UInt16 result) { }

	// RVA: 0xCB0CFC
	bool ReadNullableUInt16(out System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCB0ED8
	bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCB0FCC
	bool ReadInt32(out int result) { }

	// RVA: 0xCB10FC
	bool ReadInt32Slow(ReadValueResult header, Byte[] source, ref int offset, out int result) { }

	// RVA: 0xCB1400
	bool ReadNullableInt32(out System.Nullable<System.Int32>& result) { }

	// RVA: 0xCB15D0
	bool ReadNullableInt32Slow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.Int32>& result) { }

	// RVA: 0xCB16C4
	bool ReadUInt32(out UInt32 result) { }

	// RVA: 0xCB1800
	bool ReadUInt32Slow(ReadValueResult header, Byte[] source, ref int offset, out UInt32 result) { }

	// RVA: 0xCB1AE4
	bool ReadNullableUInt32(out System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCB1CC0
	bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCB1DB4
	bool ReadInt64(out Int64 result) { }

	// RVA: 0xCB1EE4
	bool ReadInt64Slow(ReadValueResult header, Byte[] source, ref int offset, out Int64 result) { }

	// RVA: 0xCB21D0
	bool ReadNullableInt64(out System.Nullable<System.Int64>& result) { }

	// RVA: 0xCB23A0
	bool ReadNullableInt64Slow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.Int64>& result) { }

	// RVA: 0xCB2494
	bool ReadUInt64(out UInt64 result) { }

	// RVA: 0xCB25D0
	bool ReadUInt64Slow(ReadValueResult header, Byte[] source, ref int offset, out UInt64 result) { }

	// RVA: 0xCB289C
	bool ReadNullableUInt64(out System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCB2A78
	bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCB2B6C
	bool ReadSingle(out float result) { }

	// RVA: 0xCB2CA0
	bool ReadSingleSlow(ReadValueResult header, Byte[] source, ref int offset, out float result) { }

	// RVA: 0xCB2F48
	bool ReadNullableSingle(out System.Nullable<System.Single>& result) { }

	// RVA: 0xCB311C
	bool ReadNullableSingleSlow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.Single>& result) { }

	// RVA: 0xCB3210
	bool ReadDouble(out Double result) { }

	// RVA: 0xCB3344
	bool ReadDoubleSlow(ReadValueResult header, Byte[] source, ref int offset, out Double result) { }

	// RVA: 0xCB35E4
	bool ReadNullableDouble(out System.Nullable<System.Double>& result) { }

	// RVA: 0xCB37B8
	bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] source, ref int offset, out System.Nullable<System.Double>& result) { }

	// RVA: 0xCB38AC
	bool ReadBoolean(out bool result) { }

	// RVA: 0xCB3A14
	bool ReadNullableBoolean(out System.Nullable<System.Boolean>& result) { }

	// RVA: 0xCB3BE8
	bool ReadBinary(out Byte[] result) { }

	// RVA: 0xCB3FEC
	bool ReadString(out string result) { }

	// RVA: 0xCAF1E8
	bool ReadObject(bool isDeep, out MessagePackObject result) { }

	// RVA: 0xCB41F8
	bool ReadObjectCore(bool isDeep, Byte[] source, ref int offset, out MessagePackObject result) { }

	// RVA: 0xCB4550
	bool ReadObjectSlow(ReadValueResult header, Byte[] source, ref int offset, out MessagePackObject result) { }

	// RVA: 0xCB52F0
	bool ReadItems(int count, bool isMap, Byte[] source, ref int offset, out MessagePackObject result) { }

	// RVA: 0xCB5754
	bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] source, ref int offset, out MessagePackExtendedTypeObject result) { }

	// RVA: 0xCB6438
	System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xCB64F0
	bool ReadObject(out MessagePackObject result) { }

	// RVA: 0xCB6554
	bool ReadCore() { }

	// RVA: 0xCB5D04
	void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xCB3FD8
	void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCB65C0
	void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCB3DF4
	void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xCAF658
	void ThrowTypeException(Type type, ReadValueResult header) { }

}

// Namespace: MsgPack
internal static class MessagePackCode 
{
	// Methods

	// RVA: 0xCB6774
	string ToString(int code) { }

}

// Namespace: MsgPack
public static class MessagePackConvert 
{
	// Fields
	private static readonly Encoding _utf8NonBomStrict; // 0x0
	private static readonly Encoding _utf8NonBom; // 0x8
	private static readonly DateTime _unixEpocUtc; // 0x10

	// Methods

	// RVA: 0xCB6988
	Encoding get_Utf8NonBom() { }

	// RVA: 0xCB6A04
	Encoding get_Utf8NonBomStrict() { }

	// RVA: 0xCB6A80
	Byte[] EncodeString(string value) { }

	// RVA: 0xCB6B44
	string DecodeStringStrict(Byte[] value) { }

	// RVA: 0xCB6C10
	DateTimeOffset ToDateTimeOffset(Int64 value) { }

	// RVA: 0xCB6CF0
	DateTime ToDateTime(Int64 value) { }

	// RVA: 0xCB6DCC
	Int64 FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xCB6ED0
	Int64 FromDateTime(DateTime value) { }

	// RVA: 0xCB6FBC
	void .cctor() { }

}

// Namespace: MsgPack
public struct MessagePackExtendedTypeObject 
{
	// Fields
	private readonly Byte _typeCode; // 0x10
	private readonly Byte[] _body; // 0x18

	// Methods

	// RVA: 0xCB70C0
	Byte get_TypeCode() { }

	// RVA: 0xCB70C8
	Byte[] get_Body() { }

	// RVA: 0xCB7158
	bool get_IsValid() { }

	// RVA: 0xCB7168
	void .ctor(Byte[] body, Byte unpackedTypeCode) { }

	// RVA: 0xCB63B0
	MessagePackExtendedTypeObject Unpack(Byte typeCode, Byte[] body) { }

	// RVA: 0xCB71D4
	string ToString() { }

	// RVA: 0xCB729C
	void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xCB7504
	int GetHashCode() { }

	// RVA: 0xCB7684
	bool Equals(object obj) { }

	// RVA: 0xCB7794
	bool Equals(MessagePackExtendedTypeObject other) { }

	// RVA: 0xCB7820
	bool op_Equality(MessagePackExtendedTypeObject left, MessagePackExtendedTypeObject right) { }

}

// Namespace: 
private enum MessagePackValueTypeCode 
{
	// Fields
	public int value__; // 0x10
	public const MessagePackValueTypeCode Nil = 0;
	public const MessagePackValueTypeCode Int8 = 1;
	public const MessagePackValueTypeCode Int16 = 3;
	public const MessagePackValueTypeCode Int32 = 5;
	public const MessagePackValueTypeCode Int64 = 7;
	public const MessagePackValueTypeCode UInt8 = 2;
	public const MessagePackValueTypeCode UInt16 = 4;
	public const MessagePackValueTypeCode UInt32 = 6;
	public const MessagePackValueTypeCode UInt64 = 8;
	public const MessagePackValueTypeCode Boolean = 10;
	public const MessagePackValueTypeCode Single = 11;
	public const MessagePackValueTypeCode Double = 13;
	public const MessagePackValueTypeCode Object = 16;
}

// Namespace: 
private sealed class ValueTypeCode 
{
	// Fields
	private readonly MessagePackValueTypeCode _typeCode; // 0x10
	private readonly Type _type; // 0x18

	// Methods

	// RVA: 0xCBEBAC
	MessagePackValueTypeCode get_TypeCode() { }

	// RVA: 0xCB7D5C
	bool get_IsSigned() { }

	// RVA: 0xCB7D4C
	bool get_IsInteger() { }

	// RVA: 0xCBEBB4
	Type get_Type() { }

	// RVA: 0xCBEB64
	void .ctor(Type type, MessagePackValueTypeCode typeCode) { }

	// RVA: 0xCBEBBC
	string ToString() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.MessagePackObject.<>c <>9; // 0x0
	public static System.Func<System.Int32,MsgPack.MessagePackObject,System.Int32> <>9__84_0; // 0x8
	public static System.Func<System.Int32,System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>,System.Int32> <>9__84_1; // 0x10

	// Methods

	// RVA: 0xCBEC58
	void .cctor() { }

	// RVA: 0xCBECC4
	void .ctor() { }

	// RVA: 0xCBECCC
	int <GetHashCode>b__84_0(int hash, MessagePackObject item) { }

	// RVA: 0xCBED40
	int <GetHashCode>b__84_1(int hash, System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

}

// Namespace: MsgPack
public struct MessagePackObject 
{
	// Fields
	private static readonly ValueTypeCode _sbyteTypeCode; // 0x0
	private static readonly ValueTypeCode _byteTypeCode; // 0x8
	private static readonly ValueTypeCode _int16TypeCode; // 0x10
	private static readonly ValueTypeCode _uint16TypeCode; // 0x18
	private static readonly ValueTypeCode _int32TypeCode; // 0x20
	private static readonly ValueTypeCode _uint32TypeCode; // 0x28
	private static readonly ValueTypeCode _int64TypeCode; // 0x30
	private static readonly ValueTypeCode _uint64TypeCode; // 0x38
	private static readonly ValueTypeCode _singleTypeCode; // 0x40
	private static readonly ValueTypeCode _doubleTypeCode; // 0x48
	private static readonly ValueTypeCode _booleanTypeCode; // 0x50
	public static readonly MessagePackObject Nil; // 0x58
	private object _handleOrTypeCode; // 0x10
	private UInt64 _value; // 0x18

	// Methods

	// RVA: 0xCB78B0
	void .ctor(bool value) { }

	// RVA: 0xCB792C
	void .ctor(int value) { }

	// RVA: 0xCB56B4
	void .ctor(Byte[] value, bool isBinary) { }

	// RVA: 0xCB79A8
	bool AsBoolean() { }

	// RVA: 0xCB7B00
	Byte AsByte() { }

	// RVA: 0xCB7D68
	SByte AsSByte() { }

	// RVA: 0xCB7FC8
	Int16 AsInt16() { }

	// RVA: 0xCB8228
	UInt16 AsUInt16() { }

	// RVA: 0xCB50A0
	int AsInt32() { }

	// RVA: 0xCB8430
	UInt32 AsUInt32() { }

	// RVA: 0xCAE6D8
	Int64 AsInt64() { }

	// RVA: 0xCB8640
	UInt64 AsUInt64() { }

	// RVA: 0xCB8840
	float AsSingle() { }

	// RVA: 0xCB8A00
	Double AsDouble() { }

	// RVA: 0xCB8BC0
	string AsString() { }

	// RVA: 0xCB8C98
	Byte[] AsBinary() { }

	// RVA: 0xCB8D70
	MessagePackExtendedTypeObject AsMessagePackExtendedTypeObject() { }

	// RVA: 0xCB8E8C
	MessagePackObject op_Implicit(bool value) { }

	// RVA: 0xCB5AA8
	MessagePackObject op_Implicit(Byte value) { }

	// RVA: 0xCB588C
	MessagePackObject op_Implicit(SByte value) { }

	// RVA: 0xCB5914
	MessagePackObject op_Implicit(Int16 value) { }

	// RVA: 0xCB559C
	MessagePackObject op_Implicit(UInt16 value) { }

	// RVA: 0xCB599C
	MessagePackObject op_Implicit(int value) { }

	// RVA: 0xCB5624
	MessagePackObject op_Implicit(UInt32 value) { }

	// RVA: 0xCB5A24
	MessagePackObject op_Implicit(Int64 value) { }

	// RVA: 0xCB5B30
	MessagePackObject op_Implicit(UInt64 value) { }

	// RVA: 0xCB5BB4
	MessagePackObject op_Implicit(float value) { }

	// RVA: 0xCB5C80
	MessagePackObject op_Implicit(Double value) { }

	// RVA: 0xCB8F14
	MessagePackObject op_Implicit(string value) { }

	// RVA: 0xCB44C4
	MessagePackObject op_Implicit(Byte[] value) { }

	// RVA: 0xCB5804
	MessagePackObject op_Implicit(MessagePackExtendedTypeObject value) { }

	// RVA: 0xCB8F9C
	bool op_Explicit(MessagePackObject value) { }

	// RVA: 0xCB90C0
	Byte op_Explicit(MessagePackObject value) { }

	// RVA: 0xCB92BC
	SByte op_Explicit(MessagePackObject value) { }

	// RVA: 0xCB94D4
	Int16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCB96EC
	UInt16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCB98D4
	int op_Explicit(MessagePackObject value) { }

	// RVA: 0xCB9ADC
	UInt32 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCB9CCC
	Int64 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCB9EB4
	float op_Explicit(MessagePackObject value) { }

	// RVA: 0xCBA058
	Double op_Explicit(MessagePackObject value) { }

	// RVA: 0xCB7AF0
	bool get_IsNil() { }

	// RVA: 0xCBA1FC
	void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCB5E68
	void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value, bool isImmutable) { }

	// RVA: 0xCBA268
	void .ctor(MessagePackObjectDictionary value) { }

	// RVA: 0xCB632C
	void .ctor(MessagePackObjectDictionary value, bool isImmutable) { }

	// RVA: 0xCB56AC
	void .ctor(MessagePackString messagePackString) { }

	// RVA: 0xCBAB6C
	bool Equals(object obj) { }

	// RVA: 0xCBACEC
	bool Equals(MessagePackObject other) { }

	// RVA: 0xCBB4C4
	bool EqualsWhenValueType(MessagePackObject other, ValueTypeCode valueTypeCode, ValueTypeCode otherValuetypeCode) { }

	// RVA: 0xCBB938
	bool IntegerIntegerEquals(UInt64 left, ValueTypeCode leftTypeCode, UInt64 right, ValueTypeCode rightTypeCode) { }

	// RVA: 0xCBB9A8
	bool IntegerSingleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xCBBA84
	bool IntegerDoubleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xCBBB5C
	int GetHashCode() { }

	// RVA: 0xCBBE40
	string ToString() { }

	// RVA: 0xCBBEE8
	void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xCBCA7C
	void ToStringBinary(StringBuilder buffer, bool isJson, MessagePackString asBinary) { }

	// RVA: -1
	System.Nullable<System.Boolean> IsTypeOf() { }

	// RVA: 0xCBCEE0
	System.Nullable<System.Boolean> IsTypeOf(Type type) { }

	// RVA: 0xCBD5BC
	bool get_IsRaw() { }

	// RVA: 0xCBD66C
	Type get_UnderlyingType() { }

	// RVA: 0xCBD79C
	void PackToMessage(Packer packer, PackingOptions options) { }

	// RVA: 0xCBE564
	Char[] AsCharArray() { }

	// RVA: 0x309AF8C
	void VerifyUnderlyingType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x309AF8C
	void VerifyUnderlyingRawType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x2FE8AB8
	void ThrowCannotBeNilAs() { }

	// RVA: -1
	void ThrowInvalidTypeAs(MessagePackObject instance) { }

	// RVA: 0xCBE5EC
	bool op_Equality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xCBB8B8
	bool op_Inequality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xCBE668
	void .cctor() { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private readonly MessagePackObjectDictionary _underlying; // 0x10
	private Enumerator _enumerator; // 0x18
	private System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> _current; // 0x50
	private int _position; // 0x70
	private int _initialVersion; // 0x74

	// Methods

	// RVA: 0xCC2548
	System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> get_Current() { }

	// RVA: 0xCC2640
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xCC2784
	DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0xCC2940
	object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0xCC2A50
	object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0xCC26AC
	System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> GetCurrentStrict() { }

	// RVA: 0xCC2B64
	void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCC25C8
	void VerifyVersion() { }

	// RVA: 0xCC2D18
	void Dispose() { }

	// RVA: 0xCC2D6C
	bool MoveNext() { }

	// RVA: 0xCC2FAC
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xCC2C50
	void ResetCore() { }

}

// Namespace: 
private struct DictionaryEnumerator 
{
	// Fields
	private IDictionaryEnumerator _underlying; // 0x10

	// Methods

	// RVA: 0xCC3074
	object get_Current() { }

	// RVA: 0xCC314C
	DictionaryEntry get_Entry() { }

	// RVA: 0xCC3204
	object get_Key() { }

	// RVA: 0xCC32BC
	object get_Value() { }

	// RVA: 0xCC336C
	void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCC34D0
	bool MoveNext() { }

	// RVA: 0xCC3584
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xCC3B24
	MessagePackObject get_Current() { }

	// RVA: 0xCC3C54
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xCC3928
	void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCC3D64
	void Dispose() { }

	// RVA: 0xCC3DB8
	bool MoveNext() { }

	// RVA: 0xCC3E30
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
public sealed class KeyCollection 
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xCC363C
	int get_Count() { }

	// RVA: 0xCC365C
	bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xCC3664
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xCC366C
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xCC3670
	void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCC36A4
	void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xCC3744
	void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xCC37C0
	bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xCC37E0
	void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xCC3820
	void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xCC3860
	bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xCC38A0
	Enumerator GetEnumerator() { }

	// RVA: 0xCC399C
	System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xCC3A60
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
public struct Enumerator 
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xCC43E0
	MessagePackObject get_Current() { }

	// RVA: 0xCC4514
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xCC41E4
	void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCC4628
	void Dispose() { }

	// RVA: 0xCC467C
	bool MoveNext() { }

	// RVA: 0xCC46F4
	void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
public sealed class ValueCollection 
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xCC3EF8
	int get_Count() { }

	// RVA: 0xCC3F18
	bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xCC3F20
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xCC3F28
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xCC3F2C
	void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCC3F60
	void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xCC4000
	void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xCC407C
	bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xCC409C
	void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xCC40DC
	void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xCC411C
	bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xCC415C
	Enumerator GetEnumerator() { }

	// RVA: 0xCC4258
	System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xCC431C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0 
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xCC47BC
	void .ctor() { }

	// RVA: 0xCC47C4
	bool <TryGetValue>b__0(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0 
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xCC4848
	void .ctor() { }

	// RVA: 0xCC4850
	bool <AddCore>b__0(MessagePackObject item) { }

	// RVA: 0xCC48D4
	bool <AddCore>b__1(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass59_0 
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xCC4958
	void .ctor() { }

	// RVA: 0xCC4960
	bool <RemoveCore>b__0(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.MessagePackObjectDictionary.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>,System.Collections.DictionaryEntry> <>9__64_0; // 0x8

	// Methods

	// RVA: 0xCC49E4
	void .cctor() { }

	// RVA: 0xCC4A50
	void .ctor() { }

	// RVA: 0xCC4A58
	DictionaryEntry <System.Collections.ICollection.CopyTo>b__64_0(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> kv) { }

}

// Namespace: MsgPack
public class MessagePackObjectDictionary 
{
	// Fields
	private System.Collections.Generic.List<MsgPack.MessagePackObject> _keys; // 0x10
	private System.Collections.Generic.List<MsgPack.MessagePackObject> _values; // 0x18
	private System.Collections.Generic.Dictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject> _dictionary; // 0x20
	private int _version; // 0x28
	private bool _isFrozen; // 0x2C

	// Methods

	// RVA: 0xCBEDBC
	bool get_IsFrozen() { }

	// RVA: 0xCBEDC4
	int get_Count() { }

	// RVA: 0xCBEE3C
	MessagePackObject get_Item(MessagePackObject key) { }

	// RVA: 0xCBF314
	void set_Item(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xCBF9E8
	KeyCollection get_Keys() { }

	// RVA: 0xCBFA50
	ValueCollection get_Values() { }

	// RVA: 0xCBFAB8
	System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Keys() { }

	// RVA: 0xCBFB20
	System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Values() { }

	// RVA: 0xCBFB88
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.get_IsReadOnly() { }

	// RVA: 0xCBFB90
	bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0xCBFB98
	bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0xCBFBA0
	ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0xCBFBA8
	ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0xCBFC10
	object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0xCBFFA4
	void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0xCC015C
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xCC0164
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xCC0168
	void .ctor() { }

	// RVA: 0xCB5FD8
	void .ctor(int initialCapacity) { }

	// RVA: 0xCBA354
	void .ctor(System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject> dictionary) { }

	// RVA: 0xCBF064
	void ThrowKeyNotNilException(string parameterName) { }

	// RVA: 0xCC0220
	void ThrowDuplicatedKeyException(MessagePackObject key, string parameterName) { }

	// RVA: 0xCBF470
	void VerifyIsNotFrozen() { }

	// RVA: 0xCBFD94
	MessagePackObject ValidateObjectArgument(object obj, string parameterName) { }

	// RVA: 0xCC0358
	System.Nullable<MsgPack.MessagePackObject> TryValidateObjectArgument(object value) { }

	// RVA: 0xCC0964
	bool ContainsKey(MessagePackObject key) { }

	// RVA: 0xCC0B3C
	bool ContainsValue(MessagePackObject value) { }

	// RVA: 0xCC0C78
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Contains(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xCC0EA8
	bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0xCBF0C0
	bool TryGetValue(MessagePackObject key, out MessagePackObject value) { }

	// RVA: 0xCB61D0
	void Add(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xCBF4D8
	void AddCore(MessagePackObject key, MessagePackObject value, bool allowOverwrite) { }

	// RVA: 0xCC1074
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Add(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xCC135C
	void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0xCC1518
	bool Remove(MessagePackObject key) { }

	// RVA: 0xCC1664
	bool RemoveCore(MessagePackObject key, MessagePackObject value, bool checkValue) { }

	// RVA: 0xCC19B4
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Remove(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xCC1C9C
	void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0xCC1E34
	void Clear() { }

	// RVA: 0xCC1FB0
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.CopyTo(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>[] array, int arrayIndex) { }

	// RVA: 0xCC20EC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xCC2360
	Enumerator GetEnumerator() { }

	// RVA: 0xCC2384
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.GetEnumerator() { }

	// RVA: 0xCC2428
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xCC24CC
	IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

}

// Namespace: MsgPack
internal sealed class MessagePackObjectEqualityComparer 
{
	// Fields
	private static readonly MessagePackObjectEqualityComparer _instance; // 0x0

	// Methods

	// RVA: 0xCC4C00
	MessagePackObjectEqualityComparer get_Instance() { }

	// RVA: 0xCC4C7C
	void .ctor() { }

	// RVA: 0xCC4C84
	bool Equals(MessagePackObject x, MessagePackObject y) { }

	// RVA: 0xCC4D04
	int GetHashCode(MessagePackObject obj) { }

	// RVA: 0xCC4D6C
	void .cctor() { }

}

// Namespace: MsgPack
internal sealed class MessagePackStreamPacker 
{
	// Fields
	private readonly Stream _destination; // 0x18
	private readonly Byte[] _scalarBuffer; // 0x20
	private readonly bool _ownsStream; // 0x28

	// Methods

	// RVA: 0xCC4DD8
	void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCC503C
	void Dispose(bool disposing) { }

	// RVA: 0xCC5074
	void WriteByte(Byte value) { }

	// RVA: 0xCC509C
	void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xCC5104
	void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xCC50D0
	void WriteBytes(Byte[] value) { }

	// RVA: 0xCC51D0
	void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xCC51F8
	void PackCore(bool value) { }

	// RVA: 0xCC5224
	void PackCore(Byte value) { }

	// RVA: 0xCC530C
	void PackCore(SByte value) { }

	// RVA: 0xCC5398
	void PackCore(Int16 value) { }

	// RVA: 0xCC54C8
	void PackCore(UInt16 value) { }

	// RVA: 0xCC556C
	void PackCore(int value) { }

	// RVA: 0xCC56F8
	void PackCore(UInt32 value) { }

	// RVA: 0xCC57B4
	void PackCore(Int64 value) { }

	// RVA: 0xCC59D4
	void PackCore(UInt64 value) { }

	// RVA: 0xCC5AA8
	void PackCore(float value) { }

	// RVA: 0xCC5BF4
	void PackCore(Double value) { }

	// RVA: 0xCC5DB0
	void PackArrayHeaderCore(int length) { }

	// RVA: 0xCC5DF0
	void PackMapHeaderCore(int length) { }

	// RVA: 0xCC5E2C
	void PackStringHeaderCore(int length) { }

	// RVA: 0xCC5EF4
	void PackBinaryHeaderCore(int length) { }

	// RVA: 0xCC5F90
	void PackRawCore(string value) { }

	// RVA: 0xCC6090
	void PackRawCore(Byte[] value) { }

	// RVA: 0xCC6198
	void PackBinaryCore(Byte[] value) { }

	// RVA: 0xCC627C
	void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xCC6410
	void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xCC52A4
	void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xCC5444
	void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xCC563C
	void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xCC58A8
	void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xCC5AB0
	void WriteBytes(Byte header, float value) { }

	// RVA: 0xCC5BFC
	void WriteBytes(Byte header, Double value) { }

	// RVA: 0xCC6014
	void WriteBytes(string value, bool allowStr8) { }

	// RVA: 0xCC64D8
	void WriteStringBody(string value) { }

	// RVA: 0xCC65C4
	void WriteStringBody(Char[] value, int remainingCharsLength) { }

	// RVA: 0xCC66B0
	bool EncodeString(Encoder encoder, Char[] value, int startOffset, int count, Byte[] buffer, out int charsUsed, out int bytesUsed) { }

}

// Namespace: MsgPack
internal abstract class MessagePackStreamUnpacker 
{
	// Fields
	private readonly Byte[] _oneByteBuffer; // 0x18
	private readonly Byte[] _scalarBuffer; // 0x20
	private readonly Stream _source; // 0x28
	private readonly bool _useStreamPosition; // 0x30
	private readonly bool _ownsStream; // 0x31
	private CollectionType _collectionType; // 0x34
	private MessagePackObject _data; // 0x38
	private int _subtreeCount; // 0x48
	private Int64 _offset; // 0x50
	private Int64 _lastOffset; // 0x58

	// Methods

	// RVA: 0xCC66E8
	System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xCC6760
	void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCC6844
	MessagePackObject get_LastReadData() { }

	// RVA: 0xCC6850
	void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCC685C
	bool get_IsArrayHeader() { }

	// RVA: 0xCC686C
	bool get_IsMapHeader() { }

	// RVA: 0xCC687C
	Int64 get_ItemsCount() { }

	// RVA: 0xCC6908
	bool get_IsCollectionHeader() { }

	// RVA: 0xCC6918
	CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xCC6920
	System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xCC6964
	void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCC69A0
	MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xCC69AC
	void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCC69B8
	bool GetPreviousPosition(out Int64 offsetOrPosition) { }

	// RVA: 0xCC69C8
	void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xCC6B60
	void Dispose(bool disposing) { }

	// RVA: 0xCC6BCC
	void BeginReadSubtree() { }

	// RVA: 0xCC6BDC
	void EndReadSubtree() { }

	// RVA: 0xCC6C0C
	bool ReadBinaryCore(int length, ref Int64 offset, out Byte[] result) { }

	// RVA: 0xCC6F1C
	bool ReadStringCore(int length, ref Int64 offset, out string result) { }

	// RVA: 0xCC71F4
	bool ReadRawStringCore(int length, ref Int64 offset, out MessagePackString result) { }

	// RVA: 0xCC751C
	bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, out MessagePackObject result) { }

	// RVA: 0xCC6DB4
	void ThrowEofException(Int64 reading) { }

	// RVA: 0xCC75E4
	bool ReadByte(out Byte result) { }

	// RVA: 0xCC7730
	bool ReadByteSlow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out Byte result) { }

	// RVA: 0xCC7C4C
	bool ReadNullableByte(out System.Nullable<System.Byte>& result) { }

	// RVA: 0xCC7E38
	bool ReadNullableByteSlow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.Byte>& result) { }

	// RVA: 0xCC7F2C
	bool ReadSByte(out SByte result) { }

	// RVA: 0xCC806C
	bool ReadSByteSlow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out SByte result) { }

	// RVA: 0xCC83DC
	bool ReadNullableSByte(out System.Nullable<System.SByte>& result) { }

	// RVA: 0xCC85BC
	bool ReadNullableSByteSlow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.SByte>& result) { }

	// RVA: 0xCC86B0
	bool ReadInt16(out Int16 result) { }

	// RVA: 0xCC87F4
	bool ReadInt16Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out Int16 result) { }

	// RVA: 0xCC8B64
	bool ReadNullableInt16(out System.Nullable<System.Int16>& result) { }

	// RVA: 0xCC8D48
	bool ReadNullableInt16Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.Int16>& result) { }

	// RVA: 0xCC8E3C
	bool ReadUInt16(out UInt16 result) { }

	// RVA: 0xCC8F8C
	bool ReadUInt16Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out UInt16 result) { }

	// RVA: 0xCC92D4
	bool ReadNullableUInt16(out System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCC94C4
	bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCC95B8
	bool ReadInt32(out int result) { }

	// RVA: 0xCC96E8
	bool ReadInt32Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out int result) { }

	// RVA: 0xCC9A4C
	bool ReadNullableInt32(out System.Nullable<System.Int32>& result) { }

	// RVA: 0xCC9C30
	bool ReadNullableInt32Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.Int32>& result) { }

	// RVA: 0xCC9D24
	bool ReadUInt32(out UInt32 result) { }

	// RVA: 0xCC9E60
	bool ReadUInt32Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out UInt32 result) { }

	// RVA: 0xCCA1A0
	bool ReadNullableUInt32(out System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCCA390
	bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCCA484
	bool ReadInt64(out Int64 result) { }

	// RVA: 0xCCA5C8
	bool ReadInt64Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out Int64 result) { }

	// RVA: 0xCCA918
	bool ReadNullableInt64(out System.Nullable<System.Int64>& result) { }

	// RVA: 0xCCAAFC
	bool ReadNullableInt64Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.Int64>& result) { }

	// RVA: 0xCCABF0
	bool ReadUInt64(out UInt64 result) { }

	// RVA: 0xCCAD40
	bool ReadUInt64Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out UInt64 result) { }

	// RVA: 0xCCB070
	bool ReadNullableUInt64(out System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCCB260
	bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCCB354
	bool ReadSingle(out float result) { }

	// RVA: 0xCCB49C
	bool ReadSingleSlow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out float result) { }

	// RVA: 0xCCB7A0
	bool ReadNullableSingle(out System.Nullable<System.Single>& result) { }

	// RVA: 0xCCB988
	bool ReadNullableSingleSlow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.Single>& result) { }

	// RVA: 0xCCBA7C
	bool ReadDouble(out Double result) { }

	// RVA: 0xCCBBC4
	bool ReadDoubleSlow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out Double result) { }

	// RVA: 0xCCBEC0
	bool ReadNullableDouble(out System.Nullable<System.Double>& result) { }

	// RVA: 0xCCC0A8
	bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out System.Nullable<System.Double>& result) { }

	// RVA: 0xCCC19C
	bool ReadBoolean(out bool result) { }

	// RVA: 0xCCC318
	bool ReadNullableBoolean(out System.Nullable<System.Boolean>& result) { }

	// RVA: 0xCCC500
	bool ReadBinary(out Byte[] result) { }

	// RVA: 0xCCCA38
	bool ReadString(out string result) { }

	// RVA: 0xCC7580
	bool ReadObject(bool isDeep, out MessagePackObject result) { }

	// RVA: 0xCCCD7C
	bool ReadObjectCore(bool isDeep, Byte[] buffer, ref Int64 offset, out MessagePackObject result) { }

	// RVA: 0xCCCFF8
	bool ReadObjectSlow(ReadValueResult header, Byte[] buffer, ref Int64 offset, out MessagePackObject result) { }

	// RVA: 0xCCDE20
	bool ReadItems(int count, bool isMap, Byte[] buffer, ref Int64 offset, out MessagePackObject result) { }

	// RVA: 0xCCE0A0
	bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] buffer, ref Int64 offset, out MessagePackExtendedTypeObject result) { }

	// RVA: 0xCCE2FC
	System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xCCE3B4
	bool ReadObject(out MessagePackObject result) { }

	// RVA: 0xCCE41C
	bool ReadCore() { }

	// RVA: 0xCCE198
	void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xCCCA24
	void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCCE48C
	void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCCC844
	void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xCC7A6C
	void ThrowTypeException(Type type, ReadValueResult header) { }

}

// Namespace: 
private enum BinaryType 
{
	// Fields
	public int value__; // 0x10
	public const BinaryType Unknwon = 0;
	public const BinaryType String = 1;
	public const BinaryType Blob = 2;
}

// Namespace: 
internal sealed class MessagePackStringDebuggerProxy 
{}

// Namespace: MsgPack
internal sealed class MessagePackString 
{
	// Fields
	private static readonly DecoderFallbackException IsBinary; // 0x0
	private Byte[] _encoded; // 0x10
	private string _decoded; // 0x18
	private DecoderFallbackException _decodingError; // 0x20
	private BinaryType _type; // 0x28

	// Methods

	// RVA: 0xCC7420
	void .ctor(string decoded) { }

	// RVA: 0xCC7460
	void .ctor(Byte[] encoded, bool isBinary) { }

	// RVA: 0xCCE984
	void EncodeIfNeeded() { }

	// RVA: 0xCCEA8C
	void DecodeIfNeeded() { }

	// RVA: 0xCCEBD8
	string TryGetString() { }

	// RVA: 0xCCEBFC
	string GetString() { }

	// RVA: 0xCCECBC
	Byte[] UnsafeGetBuffer() { }

	// RVA: 0xCCECC4
	Byte[] GetBytes() { }

	// RVA: 0xCCECE8
	Type GetUnderlyingType() { }

	// RVA: 0xCCEDB0
	string ToString() { }

	// RVA: 0xCCEE68
	int GetHashCode() { }

	// RVA: 0xCCF0D4
	bool Equals(object obj) { }

	// RVA: 0xCCF1B8
	bool EqualsEncoded(MessagePackString left, MessagePackString right) { }

	// RVA: 0xCCF328
	bool SlowEquals(Byte[] x, Byte[] y) { }

	// RVA: 0xCCF3B0
	void .cctor() { }

}

// Namespace: MsgPack
public class MessageTypeException 
{
	// Methods

	// RVA: 0xCCF450
	void .ctor() { }

	// RVA: 0xCCE8F0
	void .ctor(string message) { }

	// RVA: 0xCCF4D4
	void .ctor(string message, Exception inner) { }

	// RVA: 0xCCF56C
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: MsgPack
internal sealed class PureAttribute 
{
	// Methods

	// RVA: 0xCCF5F0
	void .ctor() { }

}

// Namespace: MsgPack
public abstract class Packer 
{
	// Fields
	private static int _defaultCompatibilityOptions; // 0x0
	private bool _isDisposed; // 0x10
	private readonly PackerCompatibilityOptions _compatibilityOptions; // 0x14

	// Methods

	// RVA: 0xCCF5F8
	PackerCompatibilityOptions get_DefaultCompatibilityOptions() { }

	// RVA: 0xCCF65C
	PackerCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xCC4F50
	void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCCF664
	void Dispose() { }

	// RVA: 0xCC5070
	void Dispose(bool disposing) { }

	// RVA: 0xCCF6FC
	void VerifyNotDisposed() { }

	// RVA: 0xCCF764
	void ThrowObjectDisposedException() { }

	// RVA: 0x2FE4234
	void WriteByte(Byte value) { }

	// RVA: 0xCCF7B8
	void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xCCFB30
	void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xCCFC1C
	Packer Pack(SByte value) { }

	// RVA: 0xCCFC9C
	void PackCore(SByte value) { }

	// RVA: 0xCCFD2C
	bool TryPackInt8(Int64 value) { }

	// RVA: 0xCCFD8C
	Packer Pack(Byte value) { }

	// RVA: 0xCCFE0C
	void PackCore(Byte value) { }

	// RVA: 0xCCFE18
	bool TryPackUInt8(UInt64 value) { }

	// RVA: 0xCCFE6C
	Packer Pack(bool value) { }

	// RVA: 0xCCFEEC
	void PackCore(bool value) { }

	// RVA: 0xCCFCF0
	bool TryPackTinySignedInteger(Int64 value) { }

	// RVA: 0xCCFF18
	bool TryPackTinyUnsignedInteger(UInt64 value) { }

	// RVA: 0xCCFF54
	Packer PackNull() { }

	// RVA: 0xCCFFD8
	void PrivatePackNullCore() { }

	// RVA: 0xCCFAE8
	void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xCCFFE8
	void ThrowCannotBeNegativeException(string parameterName) { }

	// RVA: 0xCD00B0
	void ThrowMissingBodyOfExtTypeValueException(string parameterName) { }

	// RVA: 0xCD010C
	void ThrowExtTypeIsProhibitedException() { }

	// RVA: 0xCD0160
	Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCD0350
	Packer Create(Stream stream, bool ownsStream) { }

	// RVA: 0xCD0270
	Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions, bool ownsStream) { }

	// RVA: 0xCD0424
	ByteArrayPacker Create(Byte[] buffer, bool allowsBufferExpansion, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCD0504
	Packer Pack(System.Nullable<System.SByte> value) { }

	// RVA: 0xCD0654
	Packer Pack(System.Nullable<System.Byte> value) { }

	// RVA: 0xCD0788
	Packer Pack(System.Nullable<System.Int16> value) { }

	// RVA: 0xCD0958
	Packer Pack(System.Nullable<System.UInt16> value) { }

	// RVA: 0xCD0B14
	Packer Pack(System.Nullable<System.Int32> value) { }

	// RVA: 0xCD0CD0
	Packer Pack(System.Nullable<System.UInt32> value) { }

	// RVA: 0xCD0E8C
	Packer Pack(System.Nullable<System.Int64> value) { }

	// RVA: 0xCD1060
	Packer Pack(System.Nullable<System.UInt64> value) { }

	// RVA: 0xCD1234
	Packer Pack(System.Nullable<System.Single> value) { }

	// RVA: 0xCD1408
	Packer Pack(System.Nullable<System.Double> value) { }

	// RVA: 0xCD15DC
	Packer Pack(System.Nullable<System.Boolean> value) { }

	// RVA: 0xCD08D8
	Packer Pack(Int16 value) { }

	// RVA: 0xCD1718
	void PackCore(Int16 value) { }

	// RVA: 0xCD1794
	bool TryPackInt16(Int64 value) { }

	// RVA: 0xCD0A90
	Packer Pack(UInt16 value) { }

	// RVA: 0xCD1808
	void PackCore(UInt16 value) { }

	// RVA: 0xCD1878
	bool TryPackUInt16(UInt64 value) { }

	// RVA: 0xCD0C4C
	Packer Pack(int value) { }

	// RVA: 0xCD18E0
	void PackCore(int value) { }

	// RVA: 0xCD1998
	bool TryPackInt32(Int64 value) { }

	// RVA: 0xCD0E08
	Packer Pack(UInt32 value) { }

	// RVA: 0xCD1A3C
	void PackCore(UInt32 value) { }

	// RVA: 0xCD1AEC
	bool TryPackUInt32(UInt64 value) { }

	// RVA: 0xCD0FDC
	Packer Pack(Int64 value) { }

	// RVA: 0xCD1B84
	void PackCore(Int64 value) { }

	// RVA: 0xCD1C9C
	bool TryPackInt64(Int64 value) { }

	// RVA: 0xCD11B0
	Packer Pack(UInt64 value) { }

	// RVA: 0xCD1D70
	void PackCore(UInt64 value) { }

	// RVA: 0xCD1E84
	bool TryPackUInt64(UInt64 value) { }

	// RVA: 0xCD1384
	Packer Pack(float value) { }

	// RVA: 0xCD1F58
	void PackCore(float value) { }

	// RVA: 0xCD1558
	Packer Pack(Double value) { }

	// RVA: 0xCD1FFC
	void PackCore(Double value) { }

	// RVA: 0xCD20D4
	Packer PackArrayHeader(int count) { }

	// RVA: 0xCD21C0
	void PackArrayHeaderCore(int count) { }

	// RVA: 0xCD2268
	Packer PackMapHeader(int count) { }

	// RVA: 0xCD2354
	void PackMapHeaderCore(int count) { }

	// RVA: 0xCD23F8
	Packer PackStringHeader(int length) { }

	// RVA: 0xCD24E4
	Packer PackBinaryHeader(int length) { }

	// RVA: 0xCD25F4
	void PackStringHeaderCore(int length) { }

	// RVA: 0xCD26C8
	void PackBinaryHeaderCore(int length) { }

	// RVA: 0xCD2770
	Packer PackRaw(Byte[] value) { }

	// RVA: 0xCD281C
	void PackRawCore(Byte[] value) { }

	// RVA: 0xCD286C
	Packer PackBinary(Byte[] value) { }

	// RVA: 0xCD2944
	void PackBinaryCore(Byte[] value) { }

	// RVA: 0xCD2994
	Packer PackString(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xCD2B34
	Packer PackString(string value) { }

	// RVA: 0xCD2B8C
	void PackStringCore(string value, Encoding encoding) { }

	// RVA: 0xCD2CE8
	void PackRawCore(string value) { }

	// RVA: 0xCD2A7C
	void PackRawCore(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xCD2D28
	Packer PackRawBody(Byte[] value) { }

	// RVA: 0xCD2E48
	Packer PackRawBody(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xCD2F60
	int PrivatePackRawBodyCore(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xCD32E0
	int PrivatePackRawBodyCore(System.Collections.Generic.ICollection<System.Byte> value, bool isImmutable) { }

	// RVA: 0xCD33E8
	Packer PackExtendedTypeValue(Byte typeCode, Byte[] body) { }

	// RVA: 0xCD3578
	Packer PackExtendedTypeValue(MessagePackExtendedTypeObject mpeto) { }

	// RVA: 0xCD36E4
	void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xCD3824
	void .cctor() { }

}

// Namespace: MsgPack
public enum PackerCompatibilityOptions 
{
	// Fields
	public int value__; // 0x10
	public const PackerCompatibilityOptions None = 0;
	public const PackerCompatibilityOptions PackBinaryAsRaw = 1;
	public const PackerCompatibilityOptions ProhibitExtendedTypeObjects = 2;
	public const PackerCompatibilityOptions Classic = 3;
}

// Namespace: MsgPack
public static class PackerUnpackerExtensions 
{
	// Methods

	// RVA: 0x309AF8C
	Packer Pack(Packer source, T value) { }

	// RVA: 0x309AF8C
	void PackCore(Packer source, T value, SerializationContext context) { }

	// RVA: 0xCD3878
	Packer PackObject(Packer source, object value) { }

	// RVA: 0xCD3A18
	Packer PackObject(Packer source, object value, SerializationContext context) { }

	// RVA: 0xCD3940
	void PackObjectCore(Packer source, object value, SerializationContext context) { }

}

// Namespace: MsgPack
public sealed class PackerUnpackerStreamOptions 
{
	// Fields
	private static readonly System.Collections.Generic.HashSet<System.String> _knownMemoryOrBufferingStreams; // 0x0
	internal static readonly PackerUnpackerStreamOptions SingletonOwnsStream; // 0x8
	internal static readonly PackerUnpackerStreamOptions SingletonForAsync; // 0x10
	internal static readonly PackerUnpackerStreamOptions None; // 0x18
	private bool <WithBuffering>k__BackingField; // 0x10
	private int _bufferSize; // 0x14
	private bool <OwnsStream>k__BackingField; // 0x18

	// Methods

	// RVA: 0xCD3AAC
	bool ShouldWrapStream(Stream stream) { }

	// RVA: 0xCD3B70
	bool get_WithBuffering() { }

	// RVA: 0xCD3B78
	void set_WithBuffering(bool value) { }

	// RVA: 0xCD3B80
	bool get_OwnsStream() { }

	// RVA: 0xCD3B88
	void set_OwnsStream(bool value) { }

	// RVA: 0xCD3B90
	void .ctor() { }

	// RVA: 0xCC4F7C
	Stream WrapStream(Stream stream) { }

	// RVA: 0xCD3BA0
	void .cctor() { }

}

// Namespace: MsgPack
public sealed class PackingOptions 
{
	// Fields
	private Encoding _stringEncoding; // 0x10

	// Methods

	// RVA: 0xCD3D88
	void .ctor() { }

}

// Namespace: MsgPack
internal sealed class PreserveAttribute 
{
	// Fields
	public bool AllMembers; // 0x10

	// Methods

	// RVA: 0xCD3E5C
	void .ctor() { }

}

// Namespace: MsgPack
internal enum ReadValueResult 
{
	// Fields
	public int value__; // 0x10
	public const ReadValueResult UInt8Type = 256;
	public const ReadValueResult UInt16Type = 512;
	public const ReadValueResult UInt32Type = 1024;
	public const ReadValueResult UInt64Type = 2048;
	public const ReadValueResult Int8Type = 4352;
	public const ReadValueResult Int16Type = 4608;
	public const ReadValueResult Int32Type = 5120;
	public const ReadValueResult Int64Type = 6144;
	public const ReadValueResult Real32Type = 9216;
	public const ReadValueResult Real64Type = 10240;
	public const ReadValueResult Bin8Type = 16640;
	public const ReadValueResult Bin16Type = 16896;
	public const ReadValueResult Bin32Type = 17408;
	public const ReadValueResult FixExtType = 32768;
	public const ReadValueResult Ext8Type = 33024;
	public const ReadValueResult Ext16Type = 33280;
	public const ReadValueResult Ext32Type = 33792;
	public const ReadValueResult FixArrayType = 40960;
	public const ReadValueResult Array16Type = 41472;
	public const ReadValueResult Array32Type = 41984;
	public const ReadValueResult FixMapType = 45056;
	public const ReadValueResult Map16Type = 45568;
	public const ReadValueResult Map32Type = 46080;
	public const ReadValueResult FixStrType = 49152;
	public const ReadValueResult Str8Type = 49408;
	public const ReadValueResult Str16Type = 49664;
	public const ReadValueResult Str32Type = 50176;
	public const ReadValueResult Nil = 16777216;
	public const ReadValueResult False = 33554432;
	public const ReadValueResult True = 33554433;
	public const ReadValueResult InvalidCode = 134217921;
	public const ReadValueResult EoF = 134221327;
	public const ReadValueResult Unexpected = 134283263;
	public const ReadValueResult NonScalarBitMask = 49152;
	public const ReadValueResult ArrayTypeMask = 40960;
	public const ReadValueResult MapTypeMask = 45056;
	public const ReadValueResult BinTypeMask = 24576;
	public const ReadValueResult RawTypeMask = 16384;
	public const ReadValueResult ExtTypeMask = 32768;
	public const ReadValueResult LengthOfLengthMask = 3840;
	public const ReadValueResult ValueOrLengthMask = 255;
	public const ReadValueResult TypeCodeMask = 65280;
	public const ReadValueResult FlagsMask = 4278190080;
	public const ReadValueResult FlagsAndTypeCodeMask = 4278255360;
	public const ReadValueResult FlagsAndLengthOfLengthMask = 4278193920;
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.ReadValueResults.<>c <>9; // 0x0

	// Methods

	// RVA: 0xCD4B10
	void .cctor() { }

	// RVA: 0xCD4B7C
	void .ctor() { }

	// RVA: 0xCD4B84
	ReadValueResult <.cctor>b__5_0(int i) { }

	// RVA: 0xCD4B8C
	ReadValueResult <.cctor>b__5_1(int i) { }

	// RVA: 0xCD4B9C
	ReadValueResult <.cctor>b__5_2(int i) { }

	// RVA: 0xCD4BAC
	ReadValueResult <.cctor>b__5_3(int i) { }

	// RVA: 0xCD4BB8
	ReadValueResult <.cctor>b__5_4(int b) { }

	// RVA: 0xCD4BC0
	MessagePackObject <.cctor>b__5_5(int x) { }

	// RVA: 0xCD4BEC
	MessagePackObject <.cctor>b__5_6(int x) { }

	// RVA: 0xCD4C18
	MessagePackObject <.cctor>b__5_7(int x) { }

	// RVA: 0xCD4C44
	MessagePackObject <.cctor>b__5_8(int x) { }

}

// Namespace: MsgPack
internal static class ReadValueResults 
{
	// Fields
	public static readonly ReadValueResult[] EncodedTypes; // 0x0
	public static readonly bool[] HasConstantObject; // 0x8
	public static readonly MessagePackObject[] ContantObject; // 0x10
	public static readonly CollectionType[] CollectionType; // 0x18

	// Methods

	// RVA: 0xCCE644
	Byte ToByte(ReadValueResult source) { }

	// RVA: 0xCD3E64
	void .cctor() { }

}

// Namespace: MsgPack
internal static class ReflectionAbstractions 
{
	// Fields
	public static readonly Char TypeDelimiter; // 0x0
	public static readonly Type[] EmptyTypes; // 0x8

	// Methods

	// RVA: 0xCD4C70
	bool GetIsValueType(Type source) { }

	// RVA: 0xCD4C88
	bool GetIsEnum(Type source) { }

	// RVA: 0xCD4CAC
	bool GetIsInterface(Type source) { }

	// RVA: 0xCD4CC4
	bool GetIsAbstract(Type source) { }

	// RVA: 0xCD4CDC
	bool GetIsGenericType(Type source) { }

	// RVA: 0xCD4D00
	bool GetIsGenericTypeDefinition(Type source) { }

	// RVA: 0xCD4D24
	Assembly GetAssembly(Type source) { }

	// RVA: 0xCD4D48
	bool GetIsVisible(Type source) { }

	// RVA: 0xCD4D60
	bool GetIsNestedPublic(Type source) { }

	// RVA: 0xCD4D78
	Type GetBaseType(Type source) { }

	// RVA: 0xCD4D9C
	MethodInfo GetRuntimeMethod(Type source, string name, Type[] parameters) { }

	// RVA: 0xCD4DC4
	System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetRuntimeMethods(Type source) { }

	// RVA: 0xCD4DEC
	Delegate CreateDelegate(MethodInfo source, Type delegateType) { }

	// RVA: 0xCD4E00
	Delegate CreateDelegate(MethodInfo source, Type delegateType, object target) { }

	// RVA: 0xCD4E18
	string GetCultureName(AssemblyName source) { }

	// RVA: 0xCD4E48
	bool GetHasDefaultValue(ParameterInfo source) { }

	// RVA: 0xCD4ED0
	void .cctor() { }

}

// Namespace: MsgPack
internal sealed class SingleArrayBufferAllocator 
{
	// Fields
	public static readonly SingleArrayBufferAllocator Default; // 0x0
	private readonly System.Func<System.Byte[],System.Int32,System.Byte[]> _allocator; // 0x10

	// Methods

	// RVA: 0xCD4F58
	void .ctor(System.Func<System.Byte[],System.Int32,System.Byte[]> allocator) { }

	// RVA: 0xCD4F8C
	Byte[] Allocate(Byte[] old, int requestSize) { }

	// RVA: 0xCD50A4
	bool TryAllocate(Byte[] oldBuffer, int requestSize, out Byte[] newBuffer) { }

	// RVA: 0xCD5170
	void .cctor() { }

}

// Namespace: MsgPack
internal static class StringEscape 
{
	// Methods

	// RVA: 0xCD5238
	string ForDisplay(string value) { }

}

// Namespace: 
private enum State 
{
	// Fields
	public int value__; // 0x10
	public const State InHead = 0;
	public const State InProgress = 1;
	public const State Drained = 2;
	public const State Disposed = 3;
}

// Namespace: MsgPack
internal sealed class SubtreeUnpacker 
{
	// Fields
	private readonly Unpacker _root; // 0x18
	private readonly IRootUnpacker _internalRoot; // 0x20
	private readonly SubtreeUnpacker _parent; // 0x28
	private readonly System.Collections.Generic.Stack<System.Boolean> _isMap; // 0x30
	private readonly System.Collections.Generic.Stack<System.Int64> _unpacked; // 0x38
	private readonly System.Collections.Generic.Stack<System.Int64> _itemsCount; // 0x40
	private State _state; // 0x48

	// Methods

	// RVA: 0xCD5544
	Int64 get_ItemsCount() { }

	// RVA: 0xCD5610
	bool get_IsArrayHeader() { }

	// RVA: 0xCD56C0
	bool get_IsMapHeader() { }

	// RVA: 0xCD5770
	bool get_IsCollectionHeader() { }

	// RVA: 0xCD5820
	System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xCD58F4
	void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCD59DC
	MessagePackObject get_LastReadData() { }

	// RVA: 0xCD5A94
	void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCD5B54
	void .ctor(Unpacker parent) { }

	// RVA: 0xCD5B5C
	void .ctor(Unpacker root, SubtreeUnpacker parent) { }

	// RVA: 0xCD5E88
	void Dispose(bool disposing) { }

	// RVA: 0xCD5F04
	void Drain() { }

	// RVA: 0xCD5F44
	void EndReadSubtree() { }

	// RVA: 0xCD6190
	Unpacker ReadSubtreeCore() { }

	// RVA: 0xCD633C
	void ThrowInTailException() { }

	// RVA: 0xCD6390
	void ThrowNotInHeadOfCollectionException() { }

	// RVA: 0xCD63E4
	bool ReadCore() { }

	// RVA: 0xCD6668
	System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xCD6018
	void DiscardCompletedStacks() { }

	// RVA: 0xCD67C8
	bool ReadBoolean(out bool result) { }

	// RVA: 0xCD6A9C
	bool ReadNullableBoolean(out System.Nullable<System.Boolean>& result) { }

	// RVA: 0xCD6D70
	bool ReadByte(out Byte result) { }

	// RVA: 0xCD7044
	bool ReadNullableByte(out System.Nullable<System.Byte>& result) { }

	// RVA: 0xCD7318
	bool ReadSByte(out SByte result) { }

	// RVA: 0xCD75EC
	bool ReadNullableSByte(out System.Nullable<System.SByte>& result) { }

	// RVA: 0xCD78C0
	bool ReadInt16(out Int16 result) { }

	// RVA: 0xCD7B94
	bool ReadNullableInt16(out System.Nullable<System.Int16>& result) { }

	// RVA: 0xCD7E68
	bool ReadUInt16(out UInt16 result) { }

	// RVA: 0xCD813C
	bool ReadNullableUInt16(out System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCD8410
	bool ReadInt32(out int result) { }

	// RVA: 0xCD86E4
	bool ReadNullableInt32(out System.Nullable<System.Int32>& result) { }

	// RVA: 0xCD89B8
	bool ReadUInt32(out UInt32 result) { }

	// RVA: 0xCD8C8C
	bool ReadNullableUInt32(out System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCD8F60
	bool ReadInt64(out Int64 result) { }

	// RVA: 0xCD9234
	bool ReadNullableInt64(out System.Nullable<System.Int64>& result) { }

	// RVA: 0xCD9508
	bool ReadUInt64(out UInt64 result) { }

	// RVA: 0xCD97DC
	bool ReadNullableUInt64(out System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCD9AB0
	bool ReadSingle(out float result) { }

	// RVA: 0xCD9D84
	bool ReadNullableSingle(out System.Nullable<System.Single>& result) { }

	// RVA: 0xCDA058
	bool ReadDouble(out Double result) { }

	// RVA: 0xCDA32C
	bool ReadNullableDouble(out System.Nullable<System.Double>& result) { }

	// RVA: 0xCDA600
	bool ReadBinary(out Byte[] result) { }

	// RVA: 0xCDA8C4
	bool ReadString(out string result) { }

	// RVA: 0xCDAB88
	bool ReadObject(out MessagePackObject result) { }

}

// Namespace: 
internal struct Value 
{
	// Fields
	public Int64 Year; // 0x10
	public int Month; // 0x18
	public int Day; // 0x1C
	public int Hour; // 0x20
	public int Minute; // 0x24
	public int Second; // 0x28
	public UInt32 Nanoseconds; // 0x2C

	// Methods

	// RVA: 0xCDCA00
	void .ctor(Timestamp encoded) { }

}

// Namespace: MsgPack
public struct Timestamp 
{
	// Fields
	public static readonly Timestamp Zero; // 0x0
	public static readonly Timestamp MinValue; // 0x10
	public static readonly Timestamp MaxValue; // 0x20
	private static readonly int[] LastDays; // 0x30
	private readonly Int64 unixEpochSeconds; // 0x10
	private readonly UInt32 nanoseconds; // 0x18
	private static readonly UInt32[] DaysToMonth365; // 0x38
	private static readonly UInt32[] DaysToMonth366; // 0x40
	private static readonly UInt32[] ReversedDaysToMonth365; // 0x48
	private static readonly UInt32[] ReversedDaysToMonth366; // 0x50

	// Methods

	// RVA: 0xCDAEC0
	int CompareTo(Timestamp other) { }

	// RVA: 0xCDAF28
	int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xCDB098
	bool Equals(object obj) { }

	// RVA: 0xCDB178
	bool Equals(Timestamp other) { }

	// RVA: 0xCDB19C
	int GetHashCode() { }

	// RVA: 0xCDB1F0
	Int64 ToTicks(Type destination) { }

	// RVA: 0xCDB388
	DateTime ToDateTime() { }

	// RVA: 0xCDB460
	DateTimeOffset ToDateTimeOffset() { }

	// RVA: 0xCDB568
	MessagePackExtendedTypeObject Encode() { }

	// RVA: 0xCDB7D0
	void FromDateTimeTicks(Int64 ticks, out Int64 unixEpocSeconds, out int nanoSeconds) { }

	// RVA: 0xCDB858
	void FromOffsetTicks(Int64 ticks, out Int64 unixEpocSeconds, out int nanoSeconds) { }

	// RVA: 0xCDBA18
	Timestamp FromDateTime(DateTime value) { }

	// RVA: 0xCDBCB0
	Timestamp FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xCDBE30
	Timestamp Decode(MessagePackExtendedTypeObject value) { }

	// RVA: 0xCDC028
	Timestamp op_Implicit(DateTimeOffset value) { }

	// RVA: 0xCDBC24
	void .ctor(Int64 unixEpochSeconds, int nanoseconds) { }

	// RVA: 0xCDB99C
	Int64 DivRem(Int64 dividend, Int64 divisor, out Int64 remainder) { }

	// RVA: 0xCDC0B4
	int get_Hour() { }

	// RVA: 0xCDC210
	int get_Minute() { }

	// RVA: 0xCDC36C
	int get_Second() { }

	// RVA: 0xCDC3A4
	void GetDatePart(out Int64 year, out int month, out int day, out int dayOfYear) { }

	// RVA: 0xCDC700
	void GetDatePartAD(out Int64 year, out int month, out int day, out int dayOfYear) { }

	// RVA: 0xCDC480
	void GetDatePartBC(out Int64 year, out int month, out int day, out int dayOfYear) { }

	// RVA: 0xCDC92C
	string ToString() { }

	// RVA: 0xCDC9B4
	string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xCDCCB0
	void .cctor() { }

}

// Namespace: MsgPack
internal static class TimestampStringConverter 
{
	// Methods

	// RVA: 0xCDCB78
	string ToString(string format, IFormatProvider formatProvider, ref Value value) { }

	// RVA: 0xCDCEB8
	string ToIso8601String(IFormatProvider formatProvider, bool containsNanosecons, ref Value value) { }

}

// Namespace: MsgPack
public sealed class UnassignedMessageTypeException 
{
	// Methods

	// RVA: 0xCDD104
	void .ctor() { }

	// RVA: 0xCDD160
	void .ctor(string message) { }

	// RVA: 0xCDD1C8
	void .ctor(string message, Exception inner) { }

	// RVA: 0xCDD23C
	void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: 
internal enum UnpackerMode 
{
	// Fields
	public int value__; // 0x10
	public const UnpackerMode Unknown = 0;
	public const UnpackerMode Skipping = 1;
	public const UnpackerMode Streaming = 2;
	public const UnpackerMode Enumerating = 3;
	public const UnpackerMode Disposed = 4;
}

// Namespace: 
private sealed class <GetEnumerator>d__45 
{
	// Fields
	private int <>1__state; // 0x10
	private MessagePackObject <>2__current; // 0x18
	public Unpacker <>4__this; // 0x28

	// Methods

	// RVA: 0xCDDBE0
	void .ctor(int <>1__state) { }

	// RVA: 0xCE0130
	void System.IDisposable.Dispose() { }

	// RVA: 0xCE0134
	bool MoveNext() { }

	// RVA: 0xCE021C
	MessagePackObject System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject>.get_Current() { }

	// RVA: 0xCE0228
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xCE0268
	object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: MsgPack
public abstract class Unpacker 
{
	// Fields
	private UnpackerMode _mode; // 0x10

	// Methods

	// RVA: -1
	System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: -1
	void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCDD244
	MessagePackObject get_LastReadData() { }

	// RVA: 0xCDD33C
	void set_LastReadData(MessagePackObject value) { }

	// RVA: 0x2FE3054
	bool get_IsArrayHeader() { }

	// RVA: 0x2FE3054
	bool get_IsMapHeader() { }

	// RVA: 0xCDD3E4
	bool get_IsCollectionHeader() { }

	// RVA: 0x2FE34E0
	Int64 get_ItemsCount() { }

	// RVA: 0xCDD42C
	void VerifyMode(UnpackerMode mode) { }

	// RVA: 0xCDD478
	void VerifyIsNotDisposed() { }

	// RVA: 0xCDD5E8
	void ThrowObjectDisposedException() { }

	// RVA: 0xCDD4FC
	void ThrowInvalidModeException() { }

	// RVA: 0xCDD654
	bool GetPreviousPosition(out Int64 offsetOrPosition) { }

	// RVA: 0xCDD664
	Unpacker Create(Stream stream, bool ownsStream) { }

	// RVA: 0xCDD748
	Unpacker Create(Stream stream, PackerUnpackerStreamOptions streamOptions, UnpackerOptions unpackerOptions) { }

	// RVA: 0xCDD7F0
	ByteArrayUnpacker Create(Byte[] source, UnpackerOptions unpackerOptions) { }

	// RVA: 0xCDD884
	ByteArrayUnpacker Create(Byte[] source, int startOffset, UnpackerOptions unpackerOptions) { }

	// RVA: 0xCDD92C
	void .ctor() { }

	// RVA: 0xCDD934
	void Dispose() { }

	// RVA: 0xCDD9C8
	void Dispose(bool disposing) { }

	// RVA: 0xCDD9CC
	void Drain() { }

	// RVA: 0xCDD9D0
	Unpacker ReadSubtree() { }

	// RVA: 0xCDD9E0
	Unpacker InternalReadSubtree() { }

	// RVA: 0xCDD9F0
	void ThrowCannotBeSubtreeModeException() { }

	// RVA: 0xCDDA44
	void ThrowInSubtreeModeException() { }

	// RVA: 0x2FE360C
	Unpacker ReadSubtreeCore() { }

	// RVA: 0xCDDA98
	void EndReadSubtree() { }

	// RVA: 0xCDDAA8
	bool Read() { }

	// RVA: 0xCDDB10
	bool ReadInternal() { }

	// RVA: 0xCDDB64
	void EnsureNotInSubtreeMode() { }

	// RVA: 0xCDDAA0
	void SetStable() { }

	// RVA: 0x2FE3054
	bool ReadCore() { }

	// RVA: 0xCDDB68
	System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> GetEnumerator() { }

	// RVA: 0xCDDC0C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xCDDC84
	System.Nullable<System.Int64> Skip() { }

	// RVA: 0xCDDD5C
	void BeginSkip() { }

	// RVA: 0xCDDD98
	void EndSkip(System.Nullable<System.Int64> result) { }

	// RVA: -1
	System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xCDDE28
	MessagePackObject ReadItemData() { }

	// RVA: 0xCDDF6C
	void ThrowEofException() { }

	// RVA: 0xCDDF00
	MessagePackObject UnpackSubtreeData() { }

	// RVA: 0xCDDFC0
	bool UnpackSubtreeDataCore(out MessagePackObject result) { }

	// RVA: 0xCDE53C
	bool ReadBoolean(out bool result) { }

	// RVA: 0xCDE618
	bool ReadNullableBoolean(out System.Nullable<System.Boolean>& result) { }

	// RVA: 0xCDE770
	bool ReadByte(out Byte result) { }

	// RVA: 0xCDE84C
	bool ReadNullableByte(out System.Nullable<System.Byte>& result) { }

	// RVA: 0xCDE9A4
	bool ReadSByte(out SByte result) { }

	// RVA: 0xCDEA80
	bool ReadNullableSByte(out System.Nullable<System.SByte>& result) { }

	// RVA: 0xCDEBD8
	bool ReadInt16(out Int16 result) { }

	// RVA: 0xCDECB4
	bool ReadNullableInt16(out System.Nullable<System.Int16>& result) { }

	// RVA: 0xCDEE28
	bool ReadUInt16(out UInt16 result) { }

	// RVA: 0xCDEF04
	bool ReadNullableUInt16(out System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCDF078
	bool ReadInt32(out int result) { }

	// RVA: 0xCDF154
	bool ReadNullableInt32(out System.Nullable<System.Int32>& result) { }

	// RVA: 0xCDF2CC
	bool ReadUInt32(out UInt32 result) { }

	// RVA: 0xCDF3A8
	bool ReadNullableUInt32(out System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCDF520
	bool ReadInt64(out Int64 result) { }

	// RVA: 0xCDF604
	bool ReadNullableInt64(out System.Nullable<System.Int64>& result) { }

	// RVA: 0xCDF780
	bool ReadUInt64(out UInt64 result) { }

	// RVA: 0xCDF864
	bool ReadNullableUInt64(out System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCDF9E0
	bool ReadSingle(out float result) { }

	// RVA: 0xCDFAC0
	bool ReadNullableSingle(out System.Nullable<System.Single>& result) { }

	// RVA: 0xCDFC38
	bool ReadDouble(out Double result) { }

	// RVA: 0xCDFD18
	bool ReadNullableDouble(out System.Nullable<System.Double>& result) { }

	// RVA: 0xCDFE94
	bool ReadBinary(out Byte[] result) { }

	// RVA: 0xCDFF8C
	bool ReadString(out string result) { }

	// RVA: 0xCE0084
	bool ReadObject(out MessagePackObject result) { }

}

// Namespace: MsgPack
internal sealed class FastStreamUnpacker 
{
	// Methods

	// RVA: 0xCDD7E8
	void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xCE02D0
	Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingStreamUnpacker 
{
	// Fields
	private bool _isSubtreeReading; // 0x60

	// Methods

	// RVA: 0xCDD7E0
	void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xCE02F8
	Unpacker InternalReadSubtree() { }

	// RVA: 0xCE03E0
	Unpacker ReadSubtreeCore() { }

	// RVA: 0xCE0448
	void EndReadSubtree() { }

	// RVA: 0xCE0454
	void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
internal sealed class FastByteArrayUnpacker 
{
	// Methods

	// RVA: 0xCDD924
	void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xCE04E4
	Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingByteArrayUnpacker 
{
	// Fields
	private bool _isSubtreeReading; // 0x48

	// Methods

	// RVA: 0xCDD91C
	void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xCE04E8
	Unpacker InternalReadSubtree() { }

	// RVA: 0xCE05D0
	Unpacker ReadSubtreeCore() { }

	// RVA: 0xCE0638
	void EndReadSubtree() { }

	// RVA: 0xCE0644
	void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
public sealed class UnpackerOptions 
{
	// Fields
	private UnpackerValidationLevel <ValidationLevel>k__BackingField; // 0x10

	// Methods

	// RVA: 0xCE06D4
	UnpackerValidationLevel get_ValidationLevel() { }

	// RVA: 0xCE06DC
	void set_ValidationLevel(UnpackerValidationLevel value) { }

	// RVA: 0xCE06E4
	void .ctor() { }

}

// Namespace: MsgPack
public enum UnpackerValidationLevel 
{
	// Fields
	public int value__; // 0x10
	public const UnpackerValidationLevel None = 0;
	public const UnpackerValidationLevel Collection = 1;
}

// Namespace: MsgPack
internal static class Volatile 
{
	// Methods

	// RVA: 0xCE0710
	int Read(ref int field) { }

	// RVA: 0xCE0718
	void Write(ref int field, int value) { }

}

// Namespace: MsgPack.Serialization
internal enum CollectionDetailedKind 
{
	// Fields
	public int value__; // 0x10
	public const CollectionDetailedKind NotCollection = 0;
	public const CollectionDetailedKind Array = 1;
	public const CollectionDetailedKind GenericList = 2;
	public const CollectionDetailedKind NonGenericList = 3;
	public const CollectionDetailedKind GenericDictionary = 4;
	public const CollectionDetailedKind NonGenericDictionary = 5;
	public const CollectionDetailedKind GenericCollection = 6;
	public const CollectionDetailedKind NonGenericCollection = 7;
	public const CollectionDetailedKind GenericEnumerable = 8;
	public const CollectionDetailedKind NonGenericEnumerable = 9;
	public const CollectionDetailedKind Unserializable = 10;
}

// Namespace: MsgPack.Serialization
internal enum CollectionKind 
{
	// Fields
	public int value__; // 0x10
	public const CollectionKind NotCollection = 0;
	public const CollectionKind Array = 1;
	public const CollectionKind Map = 2;
	public const CollectionKind Unserializable = 3;
}

// Namespace: MsgPack.Serialization
internal enum CollectionTraitOptions 
{
	// Fields
	public int value__; // 0x10
	public const CollectionTraitOptions None = 0;
	public const CollectionTraitOptions WithAddMethod = 1;
	public const CollectionTraitOptions WithCountPropertyGetter = 2;
	public const CollectionTraitOptions WithGetEnumeratorMethod = 4;
	public const CollectionTraitOptions AllowNonCollectionEnumerableTypes = 2048;
	public const CollectionTraitOptions Full = 7;
}

// Namespace: MsgPack.Serialization
internal struct CollectionTraits 
{
	// Fields
	public static readonly CollectionTraits NotCollection; // 0x0
	public static readonly CollectionTraits Unserializable; // 0x28
	public readonly Type ElementType; // 0x10
	public readonly CollectionDetailedKind DetailedCollectionType; // 0x18
	public readonly MethodInfo GetEnumeratorMethod; // 0x20
	public readonly MethodInfo AddMethod; // 0x28
	public readonly MethodInfo CountPropertyGetter; // 0x30

	// Methods

	// RVA: 0xCE0720
	CollectionKind get_CollectionType() { }

	// RVA: 0xCE07CC
	void .ctor(CollectionDetailedKind type, Type elementType, MethodInfo getEnumeratorMethod, MethodInfo addMethod, MethodInfo countPropertyGetter) { }

	// RVA: 0xCE0838
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class DataMemberContract 
{
	// Fields
	public static readonly DataMemberContract Null; // 0x0
	private readonly string _name; // 0x10
	private readonly int _id; // 0x18
	private readonly NilImplication _nilImplication; // 0x1C

	// Methods

	// RVA: 0xCE0988
	string get_Name() { }

	// RVA: 0xCE0990
	int get_Id() { }

	// RVA: 0xCE0998
	NilImplication get_NilImplication() { }

	// RVA: 0xCE09A0
	void .ctor() { }

	// RVA: 0xCE09DC
	void .ctor(MemberInfo member) { }

	// RVA: 0xCE0A34
	void .ctor(MemberInfo member, string name, NilImplication nilImplication, System.Nullable<System.Int32> id) { }

	// RVA: 0xCE0DA4
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
public enum DateTimeConversionMethod 
{
	// Fields
	public int value__; // 0x10
	public const DateTimeConversionMethod Native = 0;
	public const DateTimeConversionMethod UnixEpoc = 1;
	public const DateTimeConversionMethod Timestamp = 2;
}

// Namespace: MsgPack.Serialization
public enum DateTimeMemberConversionMethod 
{
	// Fields
	public int value__; // 0x10
	public const DateTimeMemberConversionMethod Default = 0;
	public const DateTimeMemberConversionMethod Native = 1;
	public const DateTimeMemberConversionMethod UnixEpoc = 2;
	public const DateTimeMemberConversionMethod Timestamp = 3;
}

// Namespace: MsgPack.Serialization
public static class DateTimeMessagePackSerializerHelpers 
{
	// Methods

	// RVA: 0xCE0E28
	DateTimeConversionMethod DetermineDateTimeConversionMethod(SerializationContext context, DateTimeMemberConversionMethod dateTimeMemberConversionMethod) { }

	// RVA: 0xCE0EAC
	bool IsDateTime(Type dateTimeType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DefaultConcreteTypeRepository 
{
	// Fields
	private readonly TypeKeyRepository _defaultCollectionTypes; // 0x10

	// Methods

	// RVA: 0xCE1070
	void .ctor() { }

	// RVA: 0xCE15A4
	Type Get(Type abstractCollectionType) { }

	// RVA: 0xCE1700
	Type GetConcreteType(Type abstractCollectionType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DictionarySerlaizationOptions 
{
	// Fields
	private bool _omitNullEntry; // 0x10
	private System.Func<System.String,System.String> _keyNameHandler; // 0x18

	// Methods

	// RVA: 0xCE180C
	bool get_OmitNullEntry() { }

	// RVA: 0xCE1830
	System.Func<System.String,System.String> get_KeyTransformer() { }

	// RVA: 0xCE1854
	System.Func<System.String,System.String> get_SafeKeyTransformer() { }

	// RVA: 0xCE18F8
	void .ctor() { }

}

// Namespace: MsgPack.Serialization
public enum EnumMemberSerializationMethod 
{
	// Fields
	public int value__; // 0x10
	public const EnumMemberSerializationMethod Default = 0;
	public const EnumMemberSerializationMethod ByName = 1;
	public const EnumMemberSerializationMethod ByUnderlyingValue = 2;
}

// Namespace: MsgPack.Serialization
internal abstract class UnityEnumMessagePackSerializer 
{
	// Fields
	private readonly Type _underlyingType; // 0x38
	private readonly System.Collections.Generic.Dictionary<System.Object,System.String> _serializationMapping; // 0x40
	private readonly System.Collections.Generic.Dictionary<System.String,System.Object> _deserializationMapping; // 0x48
	private EnumSerializationMethod _serializationMethod; // 0x50

	// Methods

	// RVA: 0xCE1900
	void .ctor(SerializationContext ownerContext, Type targetType, EnumSerializationMethod serializationMethod) { }

	// RVA: 0xCE1F7C
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0x2FE47D4
	void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xCE2060
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	object UnpackFromUnderlyingValue(MessagePackObject messagePackObject) { }

	// RVA: 0xCE252C
	ICustomizableEnumSerializer MsgPack.Serialization.ICustomizableEnumSerializer.GetCopyAs(EnumSerializationMethod method) { }

}

// Namespace: MsgPack.Serialization
public static class EnumMessagePackSerializerHelpers 
{
	// Methods

	// RVA: 0xCE25D4
	EnumSerializationMethod DetermineEnumSerializationMethod(SerializationContext context, Type enumType, EnumMemberSerializationMethod enumMemberSerializationMethod) { }

}

// Namespace: MsgPack.Serialization
internal sealed class EnumMessagePackSerializerProvider 
{
	// Fields
	private readonly Type _enumType; // 0x10
	private readonly object _serializerForName; // 0x18
	private readonly object _serializerForIntegral; // 0x20

	// Methods

	// RVA: 0xCE2798
	void .ctor(Type enumType, ICustomizableEnumSerializer serializer) { }

	// RVA: 0xCE28EC
	object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization
public enum EnumSerializationMethod 
{
	// Fields
	public int value__; // 0x10
	public const EnumSerializationMethod ByName = 0;
	public const EnumSerializationMethod ByUnderlyingValue = 1;
}

// Namespace: MsgPack.Serialization
public sealed class EnumSerializationOptions 
{
	// Fields
	private int _serializationMethod; // 0x10
	private System.Func<System.String,System.String> _nameTransformer; // 0x18

	// Methods

	// RVA: 0xCE278C
	EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xCE29C0
	System.Func<System.String,System.String> get_NameTransformer() { }

	// RVA: 0xCE1ED8
	System.Func<System.String,System.String> get_SafeNameTransformer() { }

	// RVA: 0xCE29E4
	void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class ExtTypeCodeMapping 
{
	// Fields
	private readonly object _syncRoot; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.String,System.Byte> _index; // 0x18
	private readonly System.Collections.Generic.Dictionary<System.Byte,System.String> _types; // 0x20

	// Methods

	// RVA: 0xCE29EC
	Byte get_Item(string name) { }

	// RVA: 0xCE2CE4
	void .ctor() { }

	// RVA: 0xCE302C
	bool Add(string name, Byte typeCode) { }

	// RVA: 0xCE2E54
	bool AddInternal(string name, Byte typeCode) { }

	// RVA: 0xCE313C
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Byte>> GetEnumerator() { }

	// RVA: 0xCE3270
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xCE2BD4
	void ValidateName(string name) { }

	// RVA: 0xCE30CC
	void ValidateTypeCode(Byte typeCode) { }

}

// Namespace: MsgPack.Serialization
internal interface ICustomizableEnumSerializer 
{
	// Methods

	// RVA: -1
	ICustomizableEnumSerializer GetCopyAs(EnumSerializationMethod method) { }

}

// Namespace: MsgPack.Serialization
internal interface INilImplicationHandlerOnUnpackedParameter<T0> 
{
	// Methods

	// RVA: 0x309AF8C
	TAction get_Store() { }

}

// Namespace: MsgPack.Serialization
internal interface INilImplicationHandlerParameter 
{
	// Methods

	// RVA: 0x2FE360C
	Type get_ItemType() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.KeyNameTransformers.<>c <>9; // 0x0

	// Methods

	// RVA: 0xCE3348
	void .cctor() { }

	// RVA: 0xCE33B4
	void .ctor() { }

	// RVA: 0xCE33BC
	string <.cctor>b__3_0(string key) { }

}

// Namespace: MsgPack.Serialization
internal static class KeyNameTransformers 
{
	// Fields
	public static readonly System.Func<System.String,System.String> AsIs; // 0x0

	// Methods

	// RVA: 0xCE3274
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class LazyDelegatingMessagePackSerializer<T0> 
{
	// Fields
	private readonly object _providerParameter; // 0x0
	private MsgPack.Serialization.MessagePackSerializer<T> _delegated; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(SerializationContext ownerContext, object providerParameter) { }

	// RVA: 0x2FE360C
	MsgPack.Serialization.MessagePackSerializer<T> GetDelegatedSerializer() { }

	// RVA: 0x309AF8C
	void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x309AF8C
	T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x309AF8C
	void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x2FE360C
	string ToString() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackDateTimeMemberAttribute 
{
	// Fields
	private DateTimeMemberConversionMethod <DateTimeConversionMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xCE33C4
	DateTimeMemberConversionMethod get_DateTimeConversionMethod() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackDeserializationConstructorAttribute 
{}

// Namespace: MsgPack.Serialization
public sealed class MessagePackEnumAttribute 
{
	// Fields
	private EnumSerializationMethod <SerializationMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xCE33CC
	EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xCE33D4
	void set_SerializationMethod(EnumSerializationMethod value) { }

	// RVA: 0xCE33DC
	void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackEnumMemberAttribute 
{
	// Fields
	private EnumMemberSerializationMethod <SerializationMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xCE33E4
	EnumMemberSerializationMethod get_SerializationMethod() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackIgnoreAttribute 
{
	// Methods

	// RVA: 0xCE33EC
	void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTypeAttribute 
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xCE33F4
	PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xCE33FC
	string get_TypeCode() { }

	// RVA: 0xCE3404
	Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownCollectionItemTypeAttribute 
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xCE340C
	PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xCE3414
	string get_TypeCode() { }

	// RVA: 0xCE341C
	Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownDictionaryKeyTypeAttribute 
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xCE3424
	PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xCE342C
	string get_TypeCode() { }

	// RVA: 0xCE3434
	Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTupleItemTypeAttribute 
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xCE343C
	PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xCE3444
	string get_TypeCode() { }

	// RVA: 0xCE344C
	Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackMemberAttribute 
{
	// Fields
	private readonly int _id; // 0x10
	private string _name; // 0x18
	private NilImplication _nilImplication; // 0x20

	// Methods

	// RVA: 0xCE3454
	int get_Id() { }

	// RVA: 0xCE345C
	string get_Name() { }

	// RVA: 0xCE3464
	NilImplication get_NilImplication() { }

	// RVA: 0xCE346C
	void .ctor(int id) { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTypeAttribute 
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xCE3498
	PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xCE34A0
	Type get_VerifierType() { }

	// RVA: 0xCE34A8
	string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeCollectionItemTypeAttribute 
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xCE34B0
	PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xCE34B8
	Type get_VerifierType() { }

	// RVA: 0xCE34C0
	string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeDictionaryKeyTypeAttribute 
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xCE34C8
	PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xCE34D0
	Type get_VerifierType() { }

	// RVA: 0xCE34D8
	string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTupleItemTypeAttribute 
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xCE34E0
	PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xCE34E8
	Type get_VerifierType() { }

	// RVA: 0xCE34F0
	string get_VerifierMethodName() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.MessagePackSerializer.<>c <>9; // 0x0

	// Methods

	// RVA: 0xCE3A6C
	void .cctor() { }

	// RVA: 0xCE3AD8
	void .ctor() { }

	// RVA: 0xCE3AE0
	bool <.cctor>b__49_0(MethodInfo m) { }

}

// Namespace: MsgPack.Serialization
public abstract class MessagePackSerializer 
{
	// Fields
	internal static readonly UnpackerOptions DefaultUnpackerOptions; // 0x0
	private readonly SerializationContext _ownerContext; // 0x10
	private readonly System.Nullable<MsgPack.PackerCompatibilityOptions> _packerCompatibilityOptionsForCompatibility; // 0x18
	private readonly SerializerCapabilities _capabilities; // 0x20
	private static readonly MethodInfo CreateInternal_2; // 0x8
	private static readonly MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _singleTonMpoDeserializer; // 0x10

	// Methods

	// RVA: 0xCE34F8
	SerializationContext get_OwnerContext() { }

	// RVA: 0xCE3500
	PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xCE3598
	void .ctor(SerializationContext ownerContext, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xCE36C8
	void PackTo(Packer packer, object objectTree) { }

	// RVA: 0x2FE47D4
	void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0xCE36D4
	object UnpackFrom(Unpacker unpacker) { }

	// RVA: 0x2FE36BC
	object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0xCE36E0
	void UnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0x2FE47D4
	void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xCE3680
	void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0x2FE704C
	MsgPack.Serialization.MessagePackSerializer<T> Get() { }

	// RVA: 0x2FE7084
	MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x2FE7164
	MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0x2FE7164
	MsgPack.Serialization.MessagePackSerializer<T> CreateInternal(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0x2FE72C0
	MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionInternal(SerializationContext context, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xCE36EC
	void ValidateType(Type type) { }

	// RVA: 0x2FE7164
	MsgPack.Serialization.MessagePackSerializer<T> Wrap(SerializationContext context, MessagePackSerializer nonGeneric) { }

	// RVA: 0x2FE8AB8
	void PrepareType() { }

	// RVA: 0x2FE8AB8
	void PrepareDictionaryType() { }

	// RVA: 0x2FE8AB8
	void PrepareCollectionType() { }

	// RVA: 0x2FE9A04
	void PrepareTypeCore(SerializationContext dummyContext) { }

	// RVA: 0xCE3824
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
public abstract class MessagePackSerializer<T0> 
{
	// Fields
	private static readonly bool IsNullable; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x2FE45DC
	void .ctor(SerializationContext ownerContext, SerializerCapabilities capabilities) { }

	// RVA: -1
	bool JudgeNullable() { }

	// RVA: 0x2FE5D84
	SerializerCapabilities InferCapatibity() { }

	// RVA: 0x309AF8C
	void Pack(Stream stream, T objectTree) { }

	// RVA: 0x309AF8C
	T Unpack(Stream stream) { }

	// RVA: 0x309AF8C
	void PackTo(Packer packer, T objectTree) { }

	// RVA: 0x309AF8C
	void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x309AF8C
	T UnpackFrom(Unpacker unpacker) { }

	// RVA: 0x309AF8C
	T UnpackNil() { }

	// RVA: 0x309AF8C
	T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x309AF8C
	void UnpackTo(Unpacker unpacker, T collection) { }

	// RVA: 0x309AF8C
	void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x309AF8C
	Byte[] PackSingleObject(T objectTree) { }

	// RVA: 0x309AF8C
	System.ArraySegment<System.Byte> PackSingleObjectAsBytes(T objectTree) { }

	// RVA: 0x309AF8C
	T UnpackSingleObject(Byte[] buffer) { }

	// RVA: 0x2FE47D4
	void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0x2FE36BC
	object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x2FE47D4
	void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0x2FEAB7C
	void ThrowArgumentException(string message, string parameterName) { }

	// RVA: 0x2FE8AB8
	void ThrowNewValueTypeCannotBeNullException() { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal abstract class MessagePackSerializerProvider 
{
	// Methods

	// RVA: 0xCE28E4
	void .ctor() { }

	// RVA: 0x2FE37A0
	object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization
public enum NilImplication 
{
	// Fields
	public int value__; // 0x10
	public const NilImplication MemberDefault = 0;
	public const NilImplication Null = 1;
	public const NilImplication Prohibit = 2;
}

// Namespace: MsgPack.Serialization
internal abstract class NilImplicationHandler<T0, T1, T2, T3> 
{
	// Methods

	// RVA: 0x309AF8C
	TAction OnPacking(TPackingParameter parameter, NilImplication nilImplication) { }

	// RVA: 0x309AF8C
	TCondition OnPackingMessagePackObject(TPackingParameter parameter) { }

	// RVA: 0x309AF8C
	TCondition OnPackingReferenceTypeObject(TPackingParameter parameter) { }

	// RVA: 0x309AF8C
	TCondition OnPackingNullableValueTypeObject(TPackingParameter parameter) { }

	// RVA: 0x309AF8C
	TAction OnPackingCore(TPackingParameter parameter, TCondition condition) { }

	// RVA: 0x309AF8C
	TAction OnUnpacked(TUnpackedParameter parameter, NilImplication nilImplication) { }

	// RVA: 0x309AF8C
	TAction OnNopOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: 0x309AF8C
	TAction OnThrowNullIsProhibitedExceptionOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: 0x309AF8C
	TAction OnThrowValueTypeCannotBeNull3OnUnpacked(TUnpackedParameter parameter) { }

	// RVA: 0x2FE41A8
	void .ctor() { }

}

// Namespace: MsgPack.Serialization
public struct PolymorphicTypeVerificationContext 
{
	// Fields
	private readonly string _loadingTypeFullName; // 0x10
	private readonly string _loadingAssemblyFullName; // 0x18
	private readonly AssemblyName _loadingAssemblyName; // 0x20

	// Methods

	// RVA: 0xCE3DFC
	void .ctor(string loadingTypeFullName, AssemblyName loadingAssemblyName, string loadingAssemblyFullName) { }

	// RVA: 0xCE3E4C
	string ToString() { }

	// RVA: 0xCE3ED0
	bool Equals(object obj) { }

	// RVA: 0xCE3F70
	bool Equals(PolymorphicTypeVerificationContext other) { }

	// RVA: 0xCE3FBC
	int GetHashCode() { }

}

// Namespace: 
private sealed class ReadOnlyDictionary<T0, T1> 
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<TKey,TValue> _underlying; // 0x0

	// Methods

	// RVA: 0x2FE360C
	System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x2FE360C
	System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x309AF8C
	TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }

	// RVA: 0x309AF8C
	void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }

	// RVA: 0x2FE32D4
	int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Count() { }

	// RVA: 0x2FE3054
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x2FE4574
	void .ctor(System.Collections.Generic.IDictionary<TKey,TValue> underlying) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.IDictionary<TKey,TValue>.ContainsKey(TKey key) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.IDictionary<TKey,TValue>.TryGetValue(TKey key, out TValue value) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x2FE45DC
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x2FE360C
	System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x2FE360C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x309AF8C
	void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	// RVA: 0x309AF8C
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x2FE41A8
	void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }

	// RVA: 0x309AF8C
	bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

}

// Namespace: 
private struct TypeTable 
{
	// Fields
	public readonly TypeTableEntry Member; // 0x10
	public readonly TypeTableEntry CollectionItem; // 0x18
	public readonly TypeTableEntry DictionaryKey; // 0x20

	// Methods

	// RVA: 0xCE7844
	void .ctor(TypeTableEntry member, TypeTableEntry collectionItem, TypeTableEntry dictionaryKey) { }

	// RVA: 0xCE5D40
	TypeTable Create(MemberInfo member, PolymorphismSchema defaultSchema) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0 
{
	// Fields
	public PolymorphismTarget targetType; // 0x10
	public System.Func<MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xCE7DE4
	void .ctor() { }

	// RVA: 0xCE9B18
	bool <Create>b__0(IPolymorphicHelperAttribute a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0 
{
	// Fields
	public IPolymorphicRuntimeTypeAttribute attribute; // 0x10

	// Methods

	// RVA: 0xCE9984
	void .ctor() { }

	// RVA: 0xCE9BD4
	bool <GetVerifier>b__0(MethodInfo m) { }

}

// Namespace: 
private sealed class TypeTableEntry 
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.String,System.Type> _knownTypeMapping; // 0x10
	private bool _useTypeEmbedding; // 0x18
	private System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> <TypeVerifier>k__BackingField; // 0x20

	// Methods

	// RVA: 0xCE7D40
	System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xCE6A74
	PolymorphismType get_PolymorphismType() { }

	// RVA: 0xCE69FC
	bool get_Exists() { }

	// RVA: 0xCE7D48
	System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xCE7D50
	void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xCE7D58
	void .ctor() { }

	// RVA: 0xCE7894
	TypeTableEntry Create(MemberInfo member, PolymorphismTarget targetType, PolymorphismSchema defaultSchema) { }

	// RVA: 0xCE7DEC
	void Interpret(IPolymorphicHelperAttribute attribute, string memberName, int tupleItemNumber) { }

	// RVA: 0xCE81BC
	void SetDefault(PolymorphismTarget target, string memberName, int tupleItemNumber, PolymorphismSchema defaultSchema) { }

	// RVA: 0xCE8650
	void SetKnownType(PolymorphismTarget target, string memberName, int tupleItemNumber, string typeCode, Type bindingType) { }

	// RVA: 0xCE8DD0
	void SetRuntimeType(PolymorphismTarget target, string memberName, int tupleItemNumber, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xCE8EDC
	string GetCannotSpecifyKnownTypeAndRuntimeTypeErrorMessage(PolymorphismTarget target, string memberName, System.Nullable<System.Int32> tupleItemNumber) { }

	// RVA: 0xCE9544
	string GetCannotDuplicateKnownTypeCodeErrorMessage(PolymorphismTarget target, string typeCode, string memberName, int tupleItemNumber) { }

	// RVA: 0xCE8824
	System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> GetVerifier(IPolymorphicRuntimeTypeAttribute attribute) { }

	// RVA: 0xCE998C
	bool IsVerificationMethod(MethodInfo method, string name) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.PolymorphismSchema.<>c <>9; // 0x0
	public static System.Func<MsgPack.Serialization.PolymorphismSchema,MsgPack.Serialization.PolymorphismSchema> <>9__3_0; // 0x8
	public static System.Func<MsgPack.Serialization.PolymorphismSchema,MsgPack.Serialization.PolymorphismSchema> <>9__4_0; // 0x10

	// Methods

	// RVA: 0xCE9C94
	void .cctor() { }

	// RVA: 0xCE9D00
	void .ctor() { }

	// RVA: 0xCE9D08
	PolymorphismSchema <.ctor>b__3_0(PolymorphismSchema x) { }

	// RVA: 0xCE9D9C
	PolymorphismSchema <.ctor>b__4_0(PolymorphismSchema x) { }

	// RVA: 0xCE9E30
	bool <.cctor>b__70_0(PolymorphicTypeVerificationContext _) { }

}

// Namespace: MsgPack.Serialization
public sealed class PolymorphismSchema 
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.String,System.Type> EmptyMap; // 0x0
	private static readonly PolymorphismSchema[] EmptyChildren; // 0x8
	private Type <TargetType>k__BackingField; // 0x10
	private PolymorphismType <PolymorphismType>k__BackingField; // 0x18
	private readonly MsgPack.Serialization.PolymorphismSchema.ReadOnlyDictionary<System.String,System.Type> _codeTypeMapping; // 0x20
	private System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> <TypeVerifier>k__BackingField; // 0x28
	private PolymorphismSchemaChildrenType <ChildrenType>k__BackingField; // 0x30
	private readonly System.Collections.ObjectModel.ReadOnlyCollection<MsgPack.Serialization.PolymorphismSchema> _children; // 0x38
	private static readonly System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> DefaultTypeVerfiier; // 0x10
	internal static readonly PolymorphismSchema Default; // 0x18
	internal static readonly MethodInfo ForPolymorphicObjectTypeEmbeddingMethod; // 0x20
	internal static readonly MethodInfo ForPolymorphicObjectCodeTypeMappingMethod; // 0x28
	internal static readonly MethodInfo ForContextSpecifiedCollectionMethod; // 0x30
	internal static readonly MethodInfo ForPolymorphicCollectionTypeEmbeddingMethod; // 0x38
	internal static readonly MethodInfo ForPolymorphicCollectionCodeTypeMappingMethod; // 0x40
	internal static readonly MethodInfo ForContextSpecifiedDictionaryMethod; // 0x48
	internal static readonly MethodInfo ForPolymorphicDictionaryTypeEmbeddingMethod; // 0x50
	internal static readonly MethodInfo ForPolymorphicDictionaryCodeTypeMappingMethod; // 0x58
	internal static readonly ConstructorInfo CodeTypeMapConstructor; // 0x60
	internal static readonly MethodInfo AddToCodeTypeMapMethod; // 0x68

	// Methods

	// RVA: 0xCE400C
	void .ctor() { }

	// RVA: 0xCE4180
	void .ctor(Type targetType, PolymorphismType polymorphismType, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xCE4518
	void .ctor(Type targetType, PolymorphismType polymorphismType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xCE43E8
	void .ctor(Type targetType, PolymorphismType polymorphismType, MsgPack.Serialization.PolymorphismSchema.ReadOnlyDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, System.Collections.ObjectModel.ReadOnlyCollection<MsgPack.Serialization.PolymorphismSchema> childItemSchemaList) { }

	// RVA: 0xCE4778
	PolymorphismSchema ForPolymorphicObject(Type targetType) { }

	// RVA: 0xCE482C
	PolymorphismSchema ForPolymorphicObject(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping) { }

	// RVA: 0xCE48F0
	PolymorphismSchema ForContextSpecifiedCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xCE4A00
	PolymorphismSchema ForPolymorphicCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xCE4B10
	PolymorphismSchema ForPolymorphicCollection(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema itemSchema) { }

	// RVA: 0xCE4C28
	PolymorphismSchema ForContextSpecifiedDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xCE4D64
	PolymorphismSchema ForPolymorphicDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xCE4EA0
	PolymorphismSchema ForPolymorphicDictionary(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xCE4FE4
	PolymorphismSchema FilterSelf() { }

	// RVA: 0xCE50B4
	Type get_TargetType() { }

	// RVA: 0xCE50BC
	void set_TargetType(Type value) { }

	// RVA: 0xCE50C4
	PolymorphismType get_PolymorphismType() { }

	// RVA: 0xCE50CC
	void set_PolymorphismType(PolymorphismType value) { }

	// RVA: 0xCE50D4
	System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xCE50DC
	bool get_UseDefault() { }

	// RVA: 0xCE50EC
	bool get_UseTypeEmbedding() { }

	// RVA: 0xCE50FC
	System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xCE5104
	void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xCE510C
	PolymorphismSchemaChildrenType get_ChildrenType() { }

	// RVA: 0xCE5114
	void set_ChildrenType(PolymorphismSchemaChildrenType value) { }

	// RVA: 0xCE511C
	PolymorphismSchema get_ItemSchema() { }

	// RVA: 0xCE5204
	PolymorphismSchema TryGetItemSchema() { }

	// RVA: 0xCE52B4
	PolymorphismSchema get_KeySchema() { }

	// RVA: 0xCE536C
	PolymorphismSchema TryGetKeySchema() { }

	// RVA: 0xCE53EC
	PolymorphismSchema Create(Type type, SerializingMember memberMayBeNull) { }

	// RVA: 0xCE5544
	PolymorphismSchema CreateCore(MemberInfo member, PolymorphismSchema defaultSchema) { }

	// RVA: 0xCE6AEC
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal enum PolymorphismSchemaChildrenType 
{
	// Fields
	public int value__; // 0x10
	public const PolymorphismSchemaChildrenType None = 0;
	public const PolymorphismSchemaChildrenType CollectionItems = 1;
	public const PolymorphismSchemaChildrenType DictionaryKeyValues = 2;
	public const PolymorphismSchemaChildrenType TupleItems = 3;
}

// Namespace: MsgPack.Serialization
internal enum PolymorphismTarget 
{
	// Fields
	public int value__; // 0x10
	public const PolymorphismTarget Member = 0;
	public const PolymorphismTarget CollectionItem = 1;
	public const PolymorphismTarget DictionaryKey = 2;
	public const PolymorphismTarget TupleItem = 3;
}

// Namespace: MsgPack.Serialization
internal enum PolymorphismType 
{
	// Fields
	public int value__; // 0x10
	public const PolymorphismType None = 0;
	public const PolymorphismType KnownTypes = 1;
	public const PolymorphismType RuntimeType = 2;
}

// Namespace: 
private struct GenericCollectionTypes 
{
	// Fields
	internal Type IEnumerableT; // 0x10
	internal Type ICollectionT; // 0x18
	internal Type IListT; // 0x20
	internal Type IDictionaryT; // 0x28
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.ReflectionExtensions.<>c <>9; // 0x0
	public static System.Func<System.Type,System.Boolean> <>9__2_0; // 0x8
	public static System.Func<System.Type,System.Boolean> <>9__2_1; // 0x10
	public static System.Func<System.Type,System.Type> <>9__2_2; // 0x18
	public static System.Func<System.Type,System.Boolean> <>9__2_3; // 0x20
	public static System.Func<System.Type,System.Boolean> <>9__2_4; // 0x28
	public static System.Func<System.Reflection.ParameterInfo,System.Type> <>9__7_2; // 0x30
	public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__15_0; // 0x38
	public static System.Func<System.Reflection.MethodInfo,System.Boolean> <>9__15_1; // 0x40

	// Methods

	// RVA: 0xCECAF0
	void .cctor() { }

	// RVA: 0xCECB5C
	void .ctor() { }

	// RVA: 0xCECB64
	bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_0(Type interface) { }

	// RVA: 0xCECC6C
	bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_1(Type i) { }

	// RVA: 0xCECCF4
	Type <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_2(Type i) { }

	// RVA: 0xCECD20
	bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_3(Type i) { }

	// RVA: 0xCECDA8
	bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_4(Type i) { }

	// RVA: 0xCECE30
	Type <FindInterfaceMethod>b__7_2(ParameterInfo p) { }

	// RVA: 0xCECE58
	bool <GetIsPublic>b__15_0(MethodInfo a) { }

	// RVA: 0xCECF00
	bool <GetIsPublic>b__15_1(MethodInfo a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public Type interfaceType; // 0x10
	public string name; // 0x18
	public Type[] parameterTypes; // 0x20

	// Methods

	// RVA: 0xCEBF00
	void .ctor() { }

	// RVA: 0xCECF1C
	bool <FindInterfaceMethod>b__0(Type type, object _) { }

	// RVA: 0xCECF2C
	bool <FindInterfaceMethod>b__1(MethodInfo method) { }

}

// Namespace: MsgPack.Serialization
internal static class ReflectionExtensions 
{
	// Fields
	private static readonly Type[] ExceptionConstructorWithInnerParameterTypes; // 0x0
	private static readonly Type[] ObjectAddParameterTypes; // 0x8

	// Methods

	// RVA: 0xCE60E8
	CollectionTraits GetCollectionTraits(Type source, CollectionTraitOptions options, bool allowNonCollectionEnumerableTypes) { }

	// RVA: 0xCEB634
	bool TryCreateCollectionTraitsForIEnumerableT(Type source, GenericCollectionTypes genericTypes, CollectionTraitOptions options, MethodInfo getMethod, out CollectionTraits result) { }

	// RVA: 0xCE9E38
	bool TryCreateCollectionTraitsForHasGetEnumeratorType(Type source, CollectionTraitOptions options, MethodInfo getEnumerator, out CollectionTraits result) { }

	// RVA: 0xCEA81C
	bool TryCreateGenericCollectionTraits(Type source, Type type, CollectionTraitOptions options, out CollectionTraits result) { }

	// RVA: 0xCEACDC
	bool DetermineCollectionInterfaces(Type type, ref GenericCollectionTypes genericTypes, ref Type idictionary, ref Type ilist, ref Type icollection, ref Type ienumerable) { }

	// RVA: 0xCEB0A4
	MethodInfo GetGetEnumeratorMethodFromElementType(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xCEB804
	MethodInfo GetGetEnumeratorMethodFromEnumerableType(Type targetType, Type enumerableType, CollectionTraitOptions options) { }

	// RVA: 0xCEBC84
	MethodInfo FindInterfaceMethod(Type targetType, Type interfaceType, string name, Type[] parameterTypes) { }

	// RVA: 0xCEB8C0
	MethodInfo GetAddMethod(Type targetType, Type argumentType, CollectionTraitOptions options) { }

	// RVA: 0xCEB3D4
	MethodInfo GetCountGetterMethod(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xCEB238
	MethodInfo GetAddMethod(Type targetType, Type keyType, Type valueType, CollectionTraitOptions options) { }

	// RVA: 0xCEA6C0
	bool FilterCollectionType(Type type, object filterCriteria) { }

	// RVA: 0xCEBB7C
	bool IsIEnumeratorT(Type interface) { }

	// RVA: 0xCEBF08
	bool GetHasPublicGetter(MemberInfo source) { }

	// RVA: 0xCEC04C
	bool GetIsPublic(MemberInfo source) { }

	// RVA: 0xCE3CC0
	Type[] GetParameterTypes(MethodBase source) { }

	// RVA: 0xCE5E58
	Type GetMemberValueType(MemberInfo source) { }

	// RVA: 0xCEC3D0
	object InvokePreservingExceptionType(ConstructorInfo source, object[] parameters) { }

	// RVA: 0xCEC734
	object InvokePreservingExceptionType(MethodInfo source, object instance, object[] parameters) { }

	// RVA: 0x309AF8C
	T CreateInstancePreservingExceptionType(Type instanceType, object[] constructorParameters) { }

	// RVA: 0xCEC820
	object CreateInstancePreservingExceptionType(Type type, object[] constructorParameters) { }

	// RVA: 0xCEC4BC
	Exception HoistUpInnerException(TargetInvocationException targetInvocationException) { }

	// RVA: 0xCEC8FC
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class ResolveSerializerEventArgs 
{
	// Fields
	private SerializationContext <Context>k__BackingField; // 0x10
	private Type <TargetType>k__BackingField; // 0x18
	private PolymorphismSchema <PolymorphismSchema>k__BackingField; // 0x20
	private MessagePackSerializer _foundSerializer; // 0x28

	// Methods

	// RVA: 0xCED0B8
	void set_Context(SerializationContext value) { }

	// RVA: 0xCED0C0
	void set_TargetType(Type value) { }

	// RVA: 0xCED0C8
	void set_PolymorphismSchema(PolymorphismSchema value) { }

	// RVA: 0x2FE360C
	MsgPack.Serialization.MessagePackSerializer<T> GetFoundSerializer() { }

	// RVA: 0xCED0D0
	void .ctor(SerializationContext context, Type targetType, PolymorphismSchema schema) { }

}

// Namespace: MsgPack.Serialization
public sealed class SerializationCompatibilityOptions 
{
	// Fields
	private bool _oneBoundDataMemberOrder; // 0x10
	private int _packerCompatibilityOptions; // 0x14
	private bool _ignorePackabilityForCollection; // 0x18
	private bool _allowNonCollectionEnumerableTypes; // 0x19
	private bool _allowAsymmetricSerializer; // 0x1A

	// Methods

	// RVA: 0xCED1AC
	bool get_OneBoundDataMemberOrder() { }

	// RVA: 0xCE358C
	PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xCED1D0
	void set_PackerCompatibilityOptions(PackerCompatibilityOptions value) { }

	// RVA: 0xCED1DC
	void set_IgnorePackabilityForCollection(bool value) { }

	// RVA: 0xCED204
	bool get_AllowNonCollectionEnumerableTypes() { }

	// RVA: 0xCED228
	void set_AllowNonCollectionEnumerableTypes(bool value) { }

	// RVA: 0xCED250
	bool get_AllowAsymmetricSerializer() { }

	// RVA: 0xCED274
	void set_AllowAsymmetricSerializer(bool value) { }

	// RVA: 0xCED29C
	void .ctor() { }

}

// Namespace: 
private sealed class SerializerGetter 
{
	// Fields
	public static readonly SerializerGetter Instance; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Reflection.MethodInfo> _cache; // 0x10

	// Methods

	// RVA: 0xCEE5F8
	void .ctor() { }

	// RVA: 0xCEDC78
	MessagePackSerializer Get(SerializationContext context, Type targetType, object providerParameter) { }

	// RVA: 0xCEE684
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class SerializationContext 
{
	// Fields
	private static readonly object DefaultContextSyncRoot; // 0x0
	private static readonly MethodInfo GetSerializer1Method; // 0x8
	private static SerializationContext _default; // 0x10
	private readonly SerializerRepository _serializers; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.Type,System.Object> _typeLock; // 0x18
	private readonly object _generationLock; // 0x20
	private readonly SerializerOptions _serializerGeneratorOptions; // 0x28
	private readonly SerializationCompatibilityOptions _compatibilityOptions; // 0x30
	private readonly DictionarySerlaizationOptions _dictionarySerializationOptions; // 0x38
	private int _serializationMethod; // 0x40
	private readonly EnumSerializationOptions _enumSerializationOptions; // 0x48
	private readonly DefaultConcreteTypeRepository _defaultCollectionTypes; // 0x50
	private int _defaultDateTimeConversionMethod; // 0x58
	private readonly object _resolveSerializerSyncRoot; // 0x60
	private System.EventHandler<MsgPack.Serialization.ResolveSerializerEventArgs> _resolveSerializer; // 0x68
	private readonly ExtTypeCodeMapping _extTypeCodes; // 0x70

	// Methods

	// RVA: 0xCED2EC
	SerializationContext get_Default() { }

	// RVA: 0xCED3E8
	SerializerRepository get_Serializers() { }

	// RVA: 0xCED3F0
	SerializerOptions get_SerializerOptions() { }

	// RVA: 0xCED3F8
	SerializationCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xCED400
	DictionarySerlaizationOptions get_DictionarySerlaizationOptions() { }

	// RVA: 0xCED408
	SerializationMethod get_SerializationMethod() { }

	// RVA: 0xCED414
	EnumSerializationOptions get_EnumSerializationOptions() { }

	// RVA: 0xCED41C
	DefaultConcreteTypeRepository get_DefaultCollectionTypes() { }

	// RVA: 0xCE0EA0
	DateTimeConversionMethod get_DefaultDateTimeConversionMethod() { }

	// RVA: 0x2FE36BC
	MsgPack.Serialization.MessagePackSerializer<T> OnResolveSerializer(PolymorphismSchema schema) { }

	// RVA: 0xCE3A64
	void .ctor() { }

	// RVA: 0xCED424
	void .ctor(PackerCompatibilityOptions packerCompatibilityOptions) { }

	// RVA: 0x2FE360C
	MsgPack.Serialization.MessagePackSerializer<T> GetSerializer() { }

	// RVA: 0x2FE36BC
	MsgPack.Serialization.MessagePackSerializer<T> GetSerializer(object providerParameter) { }

	// RVA: 0xCED8B0
	Type EnsureConcreteTypeRegistered(Type mayBeAbstractType) { }

	// RVA: 0x2FE36BC
	MsgPack.Serialization.MessagePackSerializer<T> GetSerializerWithoutGeneration(PolymorphismSchema schema) { }

	// RVA: 0xCEDAF8
	MessagePackSerializer GetSerializer(Type targetType) { }

	// RVA: 0xCEDB00
	MessagePackSerializer GetSerializer(Type targetType, object providerParameter) { }

	// RVA: 0xCEE3FC
	ExtTypeCodeMapping get_ExtTypeCodeMapping() { }

	// RVA: 0xCEE404
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
public static class SerializationExceptions 
{
	// Methods

	// RVA: 0xCEE764
	Exception NewValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xCEE90C
	void ThrowValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xCEE938
	Exception NewValueTypeCannotBeNull(Type type) { }

	// RVA: 0xCEEA70
	void ThrowMissingItem(int index, Unpacker unpacker) { }

	// RVA: 0xCEEA84
	void ThrowMissingItem(int index, string name, Unpacker unpacker) { }

	// RVA: 0xCEEEC0
	void ThrowMissingKey(int index, Unpacker unpacker) { }

	// RVA: 0xCEF10C
	Exception NewTargetDoesNotHavePublicDefaultConstructor(Type type) { }

	// RVA: 0xCEF244
	Exception NewTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xCEF37C
	void ThrowTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xCEF3A8
	Exception NewMissingProperty(string name) { }

	// RVA: 0xCEF4E0
	void ThrowMissingProperty(string name) { }

	// RVA: 0xCEF50C
	void ThrowUnexpectedEndOfStream(Unpacker unpacker) { }

	// RVA: 0xCEF6B8
	void ThrowIsNotArrayHeader(Unpacker unpacker) { }

	// RVA: 0xCEF858
	void ThrowIsNotMapHeader(Unpacker unpacker) { }

	// RVA: 0xCED9C0
	Exception NewNotSupportedBecauseCannotInstanciateAbstractType(Type type) { }

	// RVA: 0xCEF9F8
	Exception NewIsIncorrectStream(Exception innerException) { }

	// RVA: 0xCEFA78
	void ThrowIsIncorrectStream(Exception innerException) { }

	// RVA: 0xCEFAA4
	Exception NewIsTooLargeCollection() { }

	// RVA: 0xCEFB1C
	void ThrowIsTooLargeCollection() { }

	// RVA: 0xCEFB48
	Exception NewNullIsProhibited(string memberName) { }

	// RVA: 0xCEFC80
	void ThrowNullIsProhibited(string memberName) { }

	// RVA: 0xCEFCAC
	Exception NewReadOnlyMemberItemsMustNotBeNull(string memberName) { }

	// RVA: 0xCEFDE4
	Exception NewUnpackFromIsNotSupported(Type targetType) { }

	// RVA: 0xCEFF1C
	Exception NewCreateInstanceIsNotSupported(Type targetType) { }

	// RVA: 0xCF0054
	Exception NewUnpackToIsNotSupported(Type type, Exception inner) { }

	// RVA: 0xCF0194
	Exception NewValueTypeCannotBePolymorphic(Type type) { }

	// RVA: 0xCF02CC
	Exception NewUnknownTypeEmbedding() { }

	// RVA: 0xCF0344
	Exception NewIncompatibleCollectionSerializer(Type targetType, Type incompatibleType, Type exampleClass) { }

	// RVA: 0xCF05B4
	void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xCF05FC
	void ThrowSerializationException(string message) { }

	// RVA: 0xCF0644
	void ThrowSerializationException(string message, Exception innerException) { }

	// RVA: 0xCF0698
	void ThrowInvalidArrayItemsCount(Unpacker unpacker, Type targetType, int requiredCount) { }

}

// Namespace: MsgPack.Serialization
public enum SerializationMethod 
{
	// Fields
	public int value__; // 0x10
	public const SerializationMethod Array = 0;
	public const SerializationMethod Map = 1;
}

// Namespace: 
private sealed class MemberConstructorParameterEqualityComparer 
{
	// Fields
	public static readonly System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<System.String,System.Type>> Instance; // 0x0

	// Methods

	// RVA: 0xCF5A08
	void .ctor() { }

	// RVA: 0xCF5A5C
	bool Equals(System.Collections.Generic.KeyValuePair<System.String,System.Type> x, System.Collections.Generic.KeyValuePair<System.String,System.Type> y) { }

	// RVA: 0xCF5CDC
	int GetHashCode(System.Collections.Generic.KeyValuePair<System.String,System.Type> obj) { }

	// RVA: 0xCF6014
	void .cctor() { }

}

// Namespace: 
private enum ConstructorKind 
{
	// Fields
	public int value__; // 0x10
	public const ConstructorKind None = 0;
	public const ConstructorKind Marked = 1;
	public const ConstructorKind Default = 2;
	public const ConstructorKind Parameterful = 3;
	public const ConstructorKind Ambiguous = 4;
}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.SerializationTarget.<>c <>9; // 0x0
	public static System.Func<System.Reflection.ParameterInfo,System.Collections.Generic.KeyValuePair<System.String,System.Type>> <>9__26_0; // 0x8
	public static System.Func<MsgPack.Serialization.SerializingMember,System.Collections.Generic.KeyValuePair<System.String,System.Type>> <>9__26_1; // 0x10
	public static System.Func<System.Reflection.ParameterInfo,System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember>,System.String> <>9__26_2; // 0x18
	public static System.Func<MsgPack.Serialization.SerializingMember,System.String> <>9__28_0; // 0x20
	public static System.Func<MsgPack.Serialization.SerializingMember,System.Int32> <>9__32_0; // 0x28
	public static System.Func<MsgPack.Serialization.SerializingMember,System.Boolean> <>9__32_2; // 0x30
	public static System.Func<MsgPack.Serialization.SerializingMember,System.String> <>9__32_3; // 0x38
	public static System.Func<System.String,System.Boolean> <>9__33_0; // 0x40
	public static System.Func<System.Reflection.MemberInfo,System.Boolean> <>9__37_0; // 0x48
	public static System.Func<System.Object,System.Boolean> <>9__37_1; // 0x50
	public static System.Func<System.Reflection.MemberInfo,System.Boolean> <>9__38_0; // 0x58
	public static System.Func<System.Reflection.MemberInfo,MsgPack.Serialization.SerializingMember> <>9__38_1; // 0x60
	public static System.Func<System.Object,System.Boolean> <>9__39_3; // 0x68
	public static System.Func<System.Reflection.MemberInfo,<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object>> <>9__39_0; // 0x70
	public static System.Func<<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object>,System.Boolean> <>9__39_1; // 0x78
	public static System.Func<<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object>,MsgPack.Serialization.SerializingMember> <>9__39_2; // 0x80
	public static System.Func<System.Object,System.String> <>9__40_2; // 0x88
	public static System.Func<System.String,System.Boolean> <>9__40_3; // 0x90
	public static System.Func<System.Reflection.MemberInfo,System.Boolean> <>9__40_0; // 0x98
	public static System.Func<System.Reflection.MemberInfo,MsgPack.Serialization.SerializingMember> <>9__40_1; // 0xA0
	public static System.Func<System.Reflection.ConstructorInfo,System.Int32> <>9__42_0; // 0xA8
	public static System.Func<System.Linq.IGrouping<System.Int32,System.Reflection.ConstructorInfo>,System.Int32> <>9__42_1; // 0xB0
	public static System.Func<System.Reflection.ConstructorInfo,System.String> <>9__42_2; // 0xB8
	public static System.Func<System.Object,System.Boolean> <>9__43_1; // 0xC0
	public static System.Func<System.Reflection.ConstructorInfo,System.Boolean> <>9__43_0; // 0xC8
	public static System.Func<MsgPack.Serialization.SerializingMember,System.Int32> <>9__46_0; // 0xD0
	public static System.Func<System.Reflection.MemberInfo,System.String> <>9__48_1; // 0xD8
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<System.Reflection.MemberInfo>>,System.String> <>9__48_0; // 0xE0

	// Methods

	// RVA: 0xCF60B4
	void .cctor() { }

	// RVA: 0xCF6120
	void .ctor() { }

	// RVA: 0xCF6128
	System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_0(ParameterInfo p) { }

	// RVA: 0xCF61C4
	System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_1(SerializingMember m) { }

	// RVA: 0xCF6284
	string <FindCorrespondingMemberNames>b__26_2(ParameterInfo p, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> ms) { }

	// RVA: 0xCF6310
	string <ThrowAmbigiousMatchException>b__28_0(SerializingMember x) { }

	// RVA: 0xCF6338
	int <Prepare>b__32_0(SerializingMember entry) { }

	// RVA: 0xCF635C
	bool <Prepare>b__32_2(SerializingMember item) { }

	// RVA: 0xCF6388
	string <Prepare>b__32_3(SerializingMember item) { }

	// RVA: 0xCF63AC
	bool <HasAnyCorrespondingMembers>b__33_0(string x) { }

	// RVA: 0xCF63CC
	bool <GetTargetMembers>b__37_0(MemberInfo item) { }

	// RVA: 0xCF64A8
	bool <GetTargetMembers>b__37_1(object attr) { }

	// RVA: 0xCF651C
	bool <GetAnnotatedMembersWithDuplicationDetection>b__38_0(MemberInfo member) { }

	// RVA: 0xCF65F8
	SerializingMember <GetAnnotatedMembersWithDuplicationDetection>b__38_1(MemberInfo member) { }

	// RVA: 0xCF6870
	<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> <GetSystemRuntimeSerializationCompatibleMembers>b__39_0(MemberInfo item) { }

	// RVA: 0xCF69FC
	bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_3(object data) { }

	// RVA: 0xCF6A70
	bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_1(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xCF6B08
	SerializingMember <GetSystemRuntimeSerializationCompatibleMembers>b__39_2(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xCF7208
	bool <GetPublicUnpreventedMembers>b__40_0(MemberInfo member) { }

	// RVA: 0xCF7570
	string <GetPublicUnpreventedMembers>b__40_2(object data) { }

	// RVA: 0xCF75A4
	bool <GetPublicUnpreventedMembers>b__40_3(string attr) { }

	// RVA: 0xCF7638
	SerializingMember <GetPublicUnpreventedMembers>b__40_1(MemberInfo member) { }

	// RVA: 0xCF7728
	int <FindDeserializationConstructor>b__42_0(ConstructorInfo ctor) { }

	// RVA: 0xCF7760
	int <FindDeserializationConstructor>b__42_1(System.Linq.IGrouping<System.Int32,System.Reflection.ConstructorInfo> g) { }

	// RVA: 0xCF7810
	string <FindDeserializationConstructor>b__42_2(ConstructorInfo ctor) { }

	// RVA: 0xCF7838
	bool <FindExplicitDeserializationConstructors>b__43_0(ConstructorInfo ctor) { }

	// RVA: 0xCF7978
	bool <FindExplicitDeserializationConstructors>b__43_1(object a) { }

	// RVA: 0xCF7A0C
	int <ComplementMembers>b__46_0(SerializingMember item) { }

	// RVA: 0xCF7A30
	string <VerifyKeyUniqueness>b__48_0(System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<System.Reflection.MemberInfo>> kv) { }

	// RVA: 0xCF7DC0
	string <VerifyKeyUniqueness>b__48_1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0 
{
	// Fields
	public SerializationContext context; // 0x10

	// Methods

	// RVA: 0xCF1F68
	void .ctor() { }

	// RVA: 0xCF8004
	bool <Prepare>b__1(SerializingMember entry) { }

}

// Namespace: MsgPack.Serialization
internal class SerializationTarget 
{
	// Fields
	private static readonly string MessagePackMemberAttributeTypeName; // 0x0
	private static readonly string MessagePackIgnoreAttributeTypeName; // 0x8
	private static readonly string MessagePackDeserializationConstructorAttributeTypeName; // 0x10
	private static readonly string[] EmptyStrings; // 0x18
	private static readonly SerializingMember[] EmptyMembers; // 0x20
	private static readonly Assembly ThisAssembly; // 0x28
	private System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> <Members>k__BackingField; // 0x10
	private ConstructorInfo <DeserializationConstructor>k__BackingField; // 0x18
	private readonly string[] _correspondingMemberNames; // 0x20
	private bool <IsConstructorDeserialization>k__BackingField; // 0x28
	private bool <CanDeserialize>k__BackingField; // 0x29

	// Methods

	// RVA: 0xCF0A38
	System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> get_Members() { }

	// RVA: 0xCF0A40
	void set_Members(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> value) { }

	// RVA: 0xCF0A48
	ConstructorInfo get_DeserializationConstructor() { }

	// RVA: 0xCF0A50
	void set_DeserializationConstructor(ConstructorInfo value) { }

	// RVA: 0xCF0A58
	bool get_IsConstructorDeserialization() { }

	// RVA: 0xCF0A60
	void set_IsConstructorDeserialization(bool value) { }

	// RVA: 0xCF0A68
	bool get_CanDeserialize() { }

	// RVA: 0xCF0A70
	void set_CanDeserialize(bool value) { }

	// RVA: 0xCF0A78
	void .ctor(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor, string[] correspondingMemberNames, bool canDeserialize) { }

	// RVA: 0xCF0B84
	SerializerCapabilities GetCapabilitiesForObject() { }

	// RVA: 0xCF0B98
	SerializerCapabilities GetCapabilitiesForCollection(CollectionTraits traits) { }

	// RVA: 0xCF0BC0
	string[] FindCorrespondingMemberNames(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor) { }

	// RVA: 0xCF0EC0
	string DetermineCorrespondingMemberName(ParameterInfo parameterInfo, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xCF0F88
	void ThrowAmbigiousMatchException(ParameterInfo parameterInfo, System.Collections.Generic.ICollection<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xCF11C8
	void VerifyType(Type targetType) { }

	// RVA: 0xCF1298
	void VerifyCanSerializeTargetType(SerializationContext context, Type targetType) { }

	// RVA: 0xCF14D8
	SerializationTarget Prepare(SerializationContext context, Type targetType) { }

	// RVA: 0xCF372C
	bool HasAnyCorrespondingMembers(System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames) { }

	// RVA: 0xCF3860
	bool HasUnpackableInterface(Type targetType, SerializationContext context) { }

	// RVA: 0xCF34A4
	bool DetermineCanDeserialize(ConstructorKind kind, SerializationContext context, Type targetType, System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames, bool allowDefault) { }

	// RVA: 0xCF3918
	MemberInfo[] GetDistinctMembers(Type type) { }

	// RVA: 0xCF1F70
	System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetTargetMembers(Type type) { }

	// RVA: 0xCF3CFC
	System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetAnnotatedMembersWithDuplicationDetection(Type type, MemberInfo[] filtered) { }

	// RVA: 0xCF4000
	System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetSystemRuntimeSerializationCompatibleMembers(MemberInfo[] members) { }

	// RVA: 0xCF42C8
	System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetPublicUnpreventedMembers(MemberInfo[] members) { }

	// RVA: 0xCF44C0
	bool IsNonSerializedField(MemberInfo member) { }

	// RVA: 0xCF2264
	ConstructorInfo FindDeserializationConstructor(SerializationContext context, Type targetType, out ConstructorKind constructorKind) { }

	// RVA: 0xCF360C
	System.Collections.Generic.IList<System.Reflection.ConstructorInfo> FindExplicitDeserializationConstructors(System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> construtors) { }

	// RVA: 0xCF4558
	SerializationException NewTypeCannotBeSerializedException(Type targetType) { }

	// RVA: 0xCF4690
	bool CheckTargetEligibility(SerializationContext context, MemberInfo member) { }

	// RVA: 0xCF298C
	System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> ComplementMembers(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> candidates, SerializationContext context, Type targetType) { }

	// RVA: 0xCF49C4
	void VerifyNilImplication(Type type, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> entries) { }

	// RVA: 0xCF4EF0
	void VerifyKeyUniqueness(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> result) { }

	// RVA: 0xCF5728
	SerializationTarget CreateForCollection(ConstructorInfo collectionConstructor, bool canDeserialize) { }

	// RVA: 0xCF57BC
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
public enum SerializerCapabilities 
{
	// Fields
	public int value__; // 0x10
	public const SerializerCapabilities None = 0;
	public const SerializerCapabilities PackTo = 1;
	public const SerializerCapabilities UnpackFrom = 16;
	public const SerializerCapabilities UnpackTo = 32;
}

// Namespace: MsgPack.Serialization
public sealed class SerializerOptions 
{
	// Fields
	private int _emitterFlavor; // 0x10
	private bool _isNonPublicAccessDisabled; // 0x14

	// Methods

	// RVA: 0xCF14B4
	bool get_DisablePrivilegedAccess() { }

	// RVA: 0xCED8A0
	void .ctor() { }

}

// Namespace: MsgPack.Serialization
public enum SerializerRegistrationOptions 
{
	// Fields
	public int value__; // 0x10
	public const SerializerRegistrationOptions None = 0;
	public const SerializerRegistrationOptions AllowOverride = 1;
}

// Namespace: MsgPack.Serialization
public sealed class SerializerRepository 
{
	// Fields
	private static readonly object SyncRoot; // 0x0
	private readonly SerializerTypeKeyRepository _repository; // 0x10

	// Methods

	// RVA: 0xCED7D4
	void .ctor(SerializerRepository copiedFrom) { }

	// RVA: 0xCF8098
	void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xCF8210
	void Dispose() { }

	// RVA: 0x2FE36BC
	MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x2FE37A0
	MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0xCF8214
	bool Register(Type targetType, MessagePackSerializerProvider serializerProvider, Type nullableType, MessagePackSerializerProvider nullableSerializerProvider, SerializerRegistrationOptions options) { }

	// RVA: 0xCED710
	SerializerRepository GetDefault(SerializationContext ownerContext) { }

	// RVA: 0xCF8234
	System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeDefaultTable(SerializationContext ownerContext) { }

	// RVA: 0xCF97D8
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class SerializerTypeKeyRepository 
{
	// Fields
	private static readonly Type[] NonGenericSerializerConstructorParameterTypes; // 0x0

	// Methods

	// RVA: 0xCF8094
	void .ctor(SerializerTypeKeyRepository copiedFrom) { }

	// RVA: 0xCF8180
	void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xCF9954
	object Get(SerializationContext context, Type keyType) { }

	// RVA: 0xCF9CD0
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class SerializingMember 
{
	// Fields
	public readonly MemberInfo Member; // 0x10
	public readonly DataMemberContract Contract; // 0x18
	public readonly string MemberName; // 0x20

	// Methods

	// RVA: 0xCF4924
	void .ctor() { }

	// RVA: 0xCF67E8
	void .ctor(MemberInfo member, DataMemberContract contract) { }

	// RVA: 0xCF9E40
	EnumMemberSerializationMethod GetEnumMemberSerializationMethod() { }

	// RVA: 0xCF9F68
	DateTimeMemberConversionMethod GetDateTimeMemberConversionMethod() { }

	// RVA: 0xCFA090
	string ToString() { }

}

// Namespace: MsgPack.Serialization
internal class TypeKeyRepository 
{
	// Fields
	private readonly ReaderWriterLockSlim _lock; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> _table; // 0x18

	// Methods

	// RVA: 0xCF9860
	void .ctor(TypeKeyRepository copiedFrom) { }

	// RVA: 0xCE1514
	void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xCFA2DC
	System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> GetClonedTable() { }

	// RVA: 0xCE16FC
	bool Get(Type type, out object matched, out object genericDefinitionMatched) { }

	// RVA: 0xCFA434
	bool GetCore(Type type, out object matched, out object genericDefinitionMatched) { }

	// RVA: 0xCF8230
	bool Register(Type type, object entry, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xCFA718
	bool RegisterCore(Type key, object value, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xCFA974
	bool ContainsType(Type baseType, Type nullableType) { }

}

// Namespace: MsgPack.Serialization
public static class UnpackHelpers 
{
	// Fields
	private static readonly MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _messagePackObjectSerializer; // 0x0

	// Methods

	// RVA: 0xCFAA60
	int GetItemsCount(Unpacker unpacker) { }

	// RVA: 0xCFABA0
	SerializationTarget DetermineCollectionSerializationStrategy(Type instanceType, bool allowAsymmetricSerializer) { }

	// RVA: 0xCFAD04
	ConstructorInfo TryGetCollectionConstructor(Type instanceType) { }

	// RVA: 0xCFB088
	bool IsIEqualityComparer(Type type) { }

	// RVA: 0xCFB190
	object GetEqualityComparer(Type comparerType) { }

	// RVA: 0xCFB54C
	void .cctor() { }

}

// Namespace: 
private sealed class BoxingGenericEqualityComparer<T0> 
{
	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	bool Equals(T x, T y) { }

	// RVA: 0x309AF8C
	int GetHashCode(T obj) { }

}

// Namespace: 
private sealed class System_AppDomainManagerInitializationOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD06964
	void .ctor() { }

	// RVA: 0xD0696C
	bool Equals(AppDomainManagerInitializationOptions left, AppDomainManagerInitializationOptions right) { }

	// RVA: 0xD069F4
	int GetHashCode(AppDomainManagerInitializationOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_AppDomainManagerInitializationOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD06A1C
	void .ctor() { }

	// RVA: 0xD06A24
	bool Equals(System.Nullable<System.AppDomainManagerInitializationOptions> left, System.Nullable<System.AppDomainManagerInitializationOptions> right) { }

	// RVA: 0xD06BA0
	int GetHashCode(System.Nullable<System.AppDomainManagerInitializationOptions> obj) { }

}

// Namespace: 
private sealed class System_AttributeTargetsEqualityComparer 
{
	// Methods

	// RVA: 0xD06C54
	void .ctor() { }

	// RVA: 0xD06C5C
	bool Equals(AttributeTargets left, AttributeTargets right) { }

	// RVA: 0xD06CE4
	int GetHashCode(AttributeTargets obj) { }

}

// Namespace: 
private sealed class NullableSystem_AttributeTargetsEqualityComparer 
{
	// Methods

	// RVA: 0xD06D0C
	void .ctor() { }

	// RVA: 0xD06D14
	bool Equals(System.Nullable<System.AttributeTargets> left, System.Nullable<System.AttributeTargets> right) { }

	// RVA: 0xD06E90
	int GetHashCode(System.Nullable<System.AttributeTargets> obj) { }

}

// Namespace: 
private sealed class System_Base64FormattingOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD06F44
	void .ctor() { }

	// RVA: 0xD06F4C
	bool Equals(Base64FormattingOptions left, Base64FormattingOptions right) { }

	// RVA: 0xD06FD4
	int GetHashCode(Base64FormattingOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Base64FormattingOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD06FFC
	void .ctor() { }

	// RVA: 0xD07004
	bool Equals(System.Nullable<System.Base64FormattingOptions> left, System.Nullable<System.Base64FormattingOptions> right) { }

	// RVA: 0xD07180
	int GetHashCode(System.Nullable<System.Base64FormattingOptions> obj) { }

}

// Namespace: 
private sealed class System_BooleanEqualityComparer 
{
	// Methods

	// RVA: 0xD07234
	void .ctor() { }

	// RVA: 0xD0723C
	bool Equals(bool left, bool right) { }

	// RVA: 0xD07248
	int GetHashCode(bool obj) { }

}

// Namespace: 
private sealed class NullableSystem_BooleanEqualityComparer 
{
	// Methods

	// RVA: 0xD072B0
	void .ctor() { }

	// RVA: 0xD072B8
	bool Equals(System.Nullable<System.Boolean> left, System.Nullable<System.Boolean> right) { }

	// RVA: 0xD0740C
	int GetHashCode(System.Nullable<System.Boolean> obj) { }

}

// Namespace: 
private sealed class System_ByteEqualityComparer 
{
	// Methods

	// RVA: 0xD074C0
	void .ctor() { }

	// RVA: 0xD074C8
	bool Equals(Byte left, Byte right) { }

	// RVA: 0xD074D4
	int GetHashCode(Byte obj) { }

}

// Namespace: 
private sealed class NullableSystem_ByteEqualityComparer 
{
	// Methods

	// RVA: 0xD074FC
	void .ctor() { }

	// RVA: 0xD07504
	bool Equals(System.Nullable<System.Byte> left, System.Nullable<System.Byte> right) { }

	// RVA: 0xD0764C
	int GetHashCode(System.Nullable<System.Byte> obj) { }

}

// Namespace: 
private sealed class System_CharEqualityComparer 
{
	// Methods

	// RVA: 0xD07700
	void .ctor() { }

	// RVA: 0xD07708
	bool Equals(Char left, Char right) { }

	// RVA: 0xD07714
	int GetHashCode(Char obj) { }

}

// Namespace: 
private sealed class NullableSystem_CharEqualityComparer 
{
	// Methods

	// RVA: 0xD0777C
	void .ctor() { }

	// RVA: 0xD07784
	bool Equals(System.Nullable<System.Char> left, System.Nullable<System.Char> right) { }

	// RVA: 0xD078C8
	int GetHashCode(System.Nullable<System.Char> obj) { }

}

// Namespace: 
private sealed class System_ConsoleColorEqualityComparer 
{
	// Methods

	// RVA: 0xD0797C
	void .ctor() { }

	// RVA: 0xD07984
	bool Equals(ConsoleColor left, ConsoleColor right) { }

	// RVA: 0xD07A0C
	int GetHashCode(ConsoleColor obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleColorEqualityComparer 
{
	// Methods

	// RVA: 0xD07A34
	void .ctor() { }

	// RVA: 0xD07A3C
	bool Equals(System.Nullable<System.ConsoleColor> left, System.Nullable<System.ConsoleColor> right) { }

	// RVA: 0xD07BB8
	int GetHashCode(System.Nullable<System.ConsoleColor> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyEqualityComparer 
{
	// Methods

	// RVA: 0xD07C6C
	void .ctor() { }

	// RVA: 0xD07C74
	bool Equals(ConsoleKey left, ConsoleKey right) { }

	// RVA: 0xD07CFC
	int GetHashCode(ConsoleKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyEqualityComparer 
{
	// Methods

	// RVA: 0xD07D24
	void .ctor() { }

	// RVA: 0xD07D2C
	bool Equals(System.Nullable<System.ConsoleKey> left, System.Nullable<System.ConsoleKey> right) { }

	// RVA: 0xD07EA8
	int GetHashCode(System.Nullable<System.ConsoleKey> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyInfoEqualityComparer 
{
	// Methods

	// RVA: 0xD07F5C
	void .ctor() { }

	// RVA: 0xD07F64
	bool Equals(ConsoleKeyInfo left, ConsoleKeyInfo right) { }

	// RVA: 0xD07F98
	int GetHashCode(ConsoleKeyInfo obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyInfoEqualityComparer 
{
	// Methods

	// RVA: 0xD07FC4
	void .ctor() { }

	// RVA: 0xD07FCC
	bool Equals(System.Nullable<System.ConsoleKeyInfo> left, System.Nullable<System.ConsoleKeyInfo> right) { }

	// RVA: 0xD08128
	int GetHashCode(System.Nullable<System.ConsoleKeyInfo> obj) { }

}

// Namespace: 
private sealed class System_ConsoleModifiersEqualityComparer 
{
	// Methods

	// RVA: 0xD081DC
	void .ctor() { }

	// RVA: 0xD081E4
	bool Equals(ConsoleModifiers left, ConsoleModifiers right) { }

	// RVA: 0xD0826C
	int GetHashCode(ConsoleModifiers obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleModifiersEqualityComparer 
{
	// Methods

	// RVA: 0xD08294
	void .ctor() { }

	// RVA: 0xD0829C
	bool Equals(System.Nullable<System.ConsoleModifiers> left, System.Nullable<System.ConsoleModifiers> right) { }

	// RVA: 0xD08418
	int GetHashCode(System.Nullable<System.ConsoleModifiers> obj) { }

}

// Namespace: 
private sealed class System_ConsoleSpecialKeyEqualityComparer 
{
	// Methods

	// RVA: 0xD084CC
	void .ctor() { }

	// RVA: 0xD084D4
	bool Equals(ConsoleSpecialKey left, ConsoleSpecialKey right) { }

	// RVA: 0xD0855C
	int GetHashCode(ConsoleSpecialKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleSpecialKeyEqualityComparer 
{
	// Methods

	// RVA: 0xD08584
	void .ctor() { }

	// RVA: 0xD0858C
	bool Equals(System.Nullable<System.ConsoleSpecialKey> left, System.Nullable<System.ConsoleSpecialKey> right) { }

	// RVA: 0xD08708
	int GetHashCode(System.Nullable<System.ConsoleSpecialKey> obj) { }

}

// Namespace: 
private sealed class System_DateTimeEqualityComparer 
{
	// Methods

	// RVA: 0xD087BC
	void .ctor() { }

	// RVA: 0xD087C4
	bool Equals(DateTime left, DateTime right) { }

	// RVA: 0xD0883C
	int GetHashCode(DateTime obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeEqualityComparer 
{
	// Methods

	// RVA: 0xD088A4
	void .ctor() { }

	// RVA: 0xD088AC
	bool Equals(System.Nullable<System.DateTime> left, System.Nullable<System.DateTime> right) { }

	// RVA: 0xD08A20
	int GetHashCode(System.Nullable<System.DateTime> obj) { }

}

// Namespace: 
private sealed class System_DateTimeKindEqualityComparer 
{
	// Methods

	// RVA: 0xD08AD4
	void .ctor() { }

	// RVA: 0xD08ADC
	bool Equals(DateTimeKind left, DateTimeKind right) { }

	// RVA: 0xD08B64
	int GetHashCode(DateTimeKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeKindEqualityComparer 
{
	// Methods

	// RVA: 0xD08B8C
	void .ctor() { }

	// RVA: 0xD08B94
	bool Equals(System.Nullable<System.DateTimeKind> left, System.Nullable<System.DateTimeKind> right) { }

	// RVA: 0xD08D10
	int GetHashCode(System.Nullable<System.DateTimeKind> obj) { }

}

// Namespace: 
private sealed class System_DateTimeOffsetEqualityComparer 
{
	// Methods

	// RVA: 0xD08DC4
	void .ctor() { }

	// RVA: 0xD08DCC
	bool Equals(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0xD08E4C
	int GetHashCode(DateTimeOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeOffsetEqualityComparer 
{
	// Methods

	// RVA: 0xD08EB4
	void .ctor() { }

	// RVA: 0xD08EBC
	bool Equals(System.Nullable<System.DateTimeOffset> left, System.Nullable<System.DateTimeOffset> right) { }

	// RVA: 0xD09048
	int GetHashCode(System.Nullable<System.DateTimeOffset> obj) { }

}

// Namespace: 
private sealed class System_DayOfWeekEqualityComparer 
{
	// Methods

	// RVA: 0xD090F8
	void .ctor() { }

	// RVA: 0xD09100
	bool Equals(DayOfWeek left, DayOfWeek right) { }

	// RVA: 0xD09188
	int GetHashCode(DayOfWeek obj) { }

}

// Namespace: 
private sealed class NullableSystem_DayOfWeekEqualityComparer 
{
	// Methods

	// RVA: 0xD091B0
	void .ctor() { }

	// RVA: 0xD091B8
	bool Equals(System.Nullable<System.DayOfWeek> left, System.Nullable<System.DayOfWeek> right) { }

	// RVA: 0xD09334
	int GetHashCode(System.Nullable<System.DayOfWeek> obj) { }

}

// Namespace: 
private sealed class System_DecimalEqualityComparer 
{
	// Methods

	// RVA: 0xD093E8
	void .ctor() { }

	// RVA: 0xD093F0
	bool Equals(Decimal left, Decimal right) { }

	// RVA: 0xD0949C
	int GetHashCode(Decimal obj) { }

}

// Namespace: 
private sealed class NullableSystem_DecimalEqualityComparer 
{
	// Methods

	// RVA: 0xD09530
	void .ctor() { }

	// RVA: 0xD09538
	bool Equals(System.Nullable<System.Decimal> left, System.Nullable<System.Decimal> right) { }

	// RVA: 0xD096FC
	int GetHashCode(System.Nullable<System.Decimal> obj) { }

}

// Namespace: 
private sealed class System_DoubleEqualityComparer 
{
	// Methods

	// RVA: 0xD097AC
	void .ctor() { }

	// RVA: 0xD097B4
	bool Equals(Double left, Double right) { }

	// RVA: 0xD097C0
	int GetHashCode(Double obj) { }

}

// Namespace: 
private sealed class NullableSystem_DoubleEqualityComparer 
{
	// Methods

	// RVA: 0xD097E0
	void .ctor() { }

	// RVA: 0xD097E8
	bool Equals(System.Nullable<System.Double> left, System.Nullable<System.Double> right) { }

	// RVA: 0xD09940
	int GetHashCode(System.Nullable<System.Double> obj) { }

}

// Namespace: 
private sealed class System_EnvironmentVariableTargetEqualityComparer 
{
	// Methods

	// RVA: 0xD099F4
	void .ctor() { }

	// RVA: 0xD099FC
	bool Equals(EnvironmentVariableTarget left, EnvironmentVariableTarget right) { }

	// RVA: 0xD09A84
	int GetHashCode(EnvironmentVariableTarget obj) { }

}

// Namespace: 
private sealed class NullableSystem_EnvironmentVariableTargetEqualityComparer 
{
	// Methods

	// RVA: 0xD09AAC
	void .ctor() { }

	// RVA: 0xD09AB4
	bool Equals(System.Nullable<System.EnvironmentVariableTarget> left, System.Nullable<System.EnvironmentVariableTarget> right) { }

	// RVA: 0xD09C30
	int GetHashCode(System.Nullable<System.EnvironmentVariableTarget> obj) { }

}

// Namespace: 
private sealed class System_GCCollectionModeEqualityComparer 
{
	// Methods

	// RVA: 0xD09CE4
	void .ctor() { }

	// RVA: 0xD09CEC
	bool Equals(GCCollectionMode left, GCCollectionMode right) { }

	// RVA: 0xD09D74
	int GetHashCode(GCCollectionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCCollectionModeEqualityComparer 
{
	// Methods

	// RVA: 0xD09D9C
	void .ctor() { }

	// RVA: 0xD09DA4
	bool Equals(System.Nullable<System.GCCollectionMode> left, System.Nullable<System.GCCollectionMode> right) { }

	// RVA: 0xD09F20
	int GetHashCode(System.Nullable<System.GCCollectionMode> obj) { }

}

// Namespace: 
private sealed class System_GCNotificationStatusEqualityComparer 
{
	// Methods

	// RVA: 0xD09FD4
	void .ctor() { }

	// RVA: 0xD09FDC
	bool Equals(GCNotificationStatus left, GCNotificationStatus right) { }

	// RVA: 0xD0A064
	int GetHashCode(GCNotificationStatus obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCNotificationStatusEqualityComparer 
{
	// Methods

	// RVA: 0xD0A08C
	void .ctor() { }

	// RVA: 0xD0A094
	bool Equals(System.Nullable<System.GCNotificationStatus> left, System.Nullable<System.GCNotificationStatus> right) { }

	// RVA: 0xD0A210
	int GetHashCode(System.Nullable<System.GCNotificationStatus> obj) { }

}

// Namespace: 
private sealed class System_GuidEqualityComparer 
{
	// Methods

	// RVA: 0xD0A2C4
	void .ctor() { }

	// RVA: 0xD0A2CC
	bool Equals(Guid left, Guid right) { }

	// RVA: 0xD0A2FC
	int GetHashCode(Guid obj) { }

}

// Namespace: 
private sealed class NullableSystem_GuidEqualityComparer 
{
	// Methods

	// RVA: 0xD0A324
	void .ctor() { }

	// RVA: 0xD0A32C
	bool Equals(System.Nullable<System.Guid> left, System.Nullable<System.Guid> right) { }

	// RVA: 0xD0A48C
	int GetHashCode(System.Nullable<System.Guid> obj) { }

}

// Namespace: 
private sealed class System_Int16EqualityComparer 
{
	// Methods

	// RVA: 0xD0A53C
	void .ctor() { }

	// RVA: 0xD0A544
	bool Equals(Int16 left, Int16 right) { }

	// RVA: 0xD0A550
	int GetHashCode(Int16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int16EqualityComparer 
{
	// Methods

	// RVA: 0xD0A578
	void .ctor() { }

	// RVA: 0xD0A580
	bool Equals(System.Nullable<System.Int16> left, System.Nullable<System.Int16> right) { }

	// RVA: 0xD0A6C4
	int GetHashCode(System.Nullable<System.Int16> obj) { }

}

// Namespace: 
private sealed class System_Int32EqualityComparer 
{
	// Methods

	// RVA: 0xD0A778
	void .ctor() { }

	// RVA: 0xD0A780
	bool Equals(int left, int right) { }

	// RVA: 0xD0A78C
	int GetHashCode(int obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int32EqualityComparer 
{
	// Methods

	// RVA: 0xD0A7B4
	void .ctor() { }

	// RVA: 0xD0A7BC
	bool Equals(System.Nullable<System.Int32> left, System.Nullable<System.Int32> right) { }

	// RVA: 0xD0A900
	int GetHashCode(System.Nullable<System.Int32> obj) { }

}

// Namespace: 
private sealed class System_Int64EqualityComparer 
{
	// Methods

	// RVA: 0xD0A9B4
	void .ctor() { }

	// RVA: 0xD0A9BC
	bool Equals(Int64 left, Int64 right) { }

	// RVA: 0xD0A9C8
	int GetHashCode(Int64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int64EqualityComparer 
{
	// Methods

	// RVA: 0xD0A9F0
	void .ctor() { }

	// RVA: 0xD0A9F8
	bool Equals(System.Nullable<System.Int64> left, System.Nullable<System.Int64> right) { }

	// RVA: 0xD0AB40
	int GetHashCode(System.Nullable<System.Int64> obj) { }

}

// Namespace: 
private sealed class System_IntPtrEqualityComparer 
{
	// Methods

	// RVA: 0xD0ABF4
	void .ctor() { }

	// RVA: 0xD0ABFC
	bool Equals(IntPtr left, IntPtr right) { }

	// RVA: 0xD0AC0C
	int GetHashCode(IntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_IntPtrEqualityComparer 
{
	// Methods

	// RVA: 0xD0AC34
	void .ctor() { }

	// RVA: 0xD0AC3C
	bool Equals(System.Nullable<System.IntPtr> left, System.Nullable<System.IntPtr> right) { }

	// RVA: 0xD0AD88
	int GetHashCode(System.Nullable<System.IntPtr> obj) { }

}

// Namespace: 
private sealed class System_LoaderOptimizationEqualityComparer 
{
	// Methods

	// RVA: 0xD0AE3C
	void .ctor() { }

	// RVA: 0xD0AE44
	bool Equals(LoaderOptimization left, LoaderOptimization right) { }

	// RVA: 0xD0AECC
	int GetHashCode(LoaderOptimization obj) { }

}

// Namespace: 
private sealed class NullableSystem_LoaderOptimizationEqualityComparer 
{
	// Methods

	// RVA: 0xD0AEF4
	void .ctor() { }

	// RVA: 0xD0AEFC
	bool Equals(System.Nullable<System.LoaderOptimization> left, System.Nullable<System.LoaderOptimization> right) { }

	// RVA: 0xD0B078
	int GetHashCode(System.Nullable<System.LoaderOptimization> obj) { }

}

// Namespace: 
private sealed class System_MidpointRoundingEqualityComparer 
{
	// Methods

	// RVA: 0xD0B12C
	void .ctor() { }

	// RVA: 0xD0B134
	bool Equals(MidpointRounding left, MidpointRounding right) { }

	// RVA: 0xD0B1BC
	int GetHashCode(MidpointRounding obj) { }

}

// Namespace: 
private sealed class NullableSystem_MidpointRoundingEqualityComparer 
{
	// Methods

	// RVA: 0xD0B1E4
	void .ctor() { }

	// RVA: 0xD0B1EC
	bool Equals(System.Nullable<System.MidpointRounding> left, System.Nullable<System.MidpointRounding> right) { }

	// RVA: 0xD0B368
	int GetHashCode(System.Nullable<System.MidpointRounding> obj) { }

}

// Namespace: 
private sealed class System_ModuleHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD0B41C
	void .ctor() { }

	// RVA: 0xD0B424
	bool Equals(ModuleHandle left, ModuleHandle right) { }

	// RVA: 0xD0B49C
	int GetHashCode(ModuleHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_ModuleHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD0B504
	void .ctor() { }

	// RVA: 0xD0B50C
	bool Equals(System.Nullable<System.ModuleHandle> left, System.Nullable<System.ModuleHandle> right) { }

	// RVA: 0xD0B680
	int GetHashCode(System.Nullable<System.ModuleHandle> obj) { }

}

// Namespace: 
private sealed class System_PlatformIDEqualityComparer 
{
	// Methods

	// RVA: 0xD0B734
	void .ctor() { }

	// RVA: 0xD0B73C
	bool Equals(PlatformID left, PlatformID right) { }

	// RVA: 0xD0B7C4
	int GetHashCode(PlatformID obj) { }

}

// Namespace: 
private sealed class NullableSystem_PlatformIDEqualityComparer 
{
	// Methods

	// RVA: 0xD0B7EC
	void .ctor() { }

	// RVA: 0xD0B7F4
	bool Equals(System.Nullable<System.PlatformID> left, System.Nullable<System.PlatformID> right) { }

	// RVA: 0xD0B970
	int GetHashCode(System.Nullable<System.PlatformID> obj) { }

}

// Namespace: 
private sealed class System_RuntimeFieldHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD0BA24
	void .ctor() { }

	// RVA: 0xD0BA2C
	bool Equals(RuntimeFieldHandle left, RuntimeFieldHandle right) { }

	// RVA: 0xD0BA58
	int GetHashCode(RuntimeFieldHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeFieldHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD0BA80
	void .ctor() { }

	// RVA: 0xD0BA88
	bool Equals(System.Nullable<System.RuntimeFieldHandle> left, System.Nullable<System.RuntimeFieldHandle> right) { }

	// RVA: 0xD0BBD4
	int GetHashCode(System.Nullable<System.RuntimeFieldHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeMethodHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD0BC88
	void .ctor() { }

	// RVA: 0xD0BC90
	bool Equals(RuntimeMethodHandle left, RuntimeMethodHandle right) { }

	// RVA: 0xD0BCBC
	int GetHashCode(RuntimeMethodHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeMethodHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD0BCE4
	void .ctor() { }

	// RVA: 0xD0BCEC
	bool Equals(System.Nullable<System.RuntimeMethodHandle> left, System.Nullable<System.RuntimeMethodHandle> right) { }

	// RVA: 0xD0BE38
	int GetHashCode(System.Nullable<System.RuntimeMethodHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeTypeHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD0BEEC
	void .ctor() { }

	// RVA: 0xD0BEF4
	bool Equals(RuntimeTypeHandle left, RuntimeTypeHandle right) { }

	// RVA: 0xD0BF20
	int GetHashCode(RuntimeTypeHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeTypeHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD0BF48
	void .ctor() { }

	// RVA: 0xD0BF50
	bool Equals(System.Nullable<System.RuntimeTypeHandle> left, System.Nullable<System.RuntimeTypeHandle> right) { }

	// RVA: 0xD0C09C
	int GetHashCode(System.Nullable<System.RuntimeTypeHandle> obj) { }

}

// Namespace: 
private sealed class System_SByteEqualityComparer 
{
	// Methods

	// RVA: 0xD0C150
	void .ctor() { }

	// RVA: 0xD0C158
	bool Equals(SByte left, SByte right) { }

	// RVA: 0xD0C164
	int GetHashCode(SByte obj) { }

}

// Namespace: 
private sealed class NullableSystem_SByteEqualityComparer 
{
	// Methods

	// RVA: 0xD0C18C
	void .ctor() { }

	// RVA: 0xD0C194
	bool Equals(System.Nullable<System.SByte> left, System.Nullable<System.SByte> right) { }

	// RVA: 0xD0C2DC
	int GetHashCode(System.Nullable<System.SByte> obj) { }

}

// Namespace: 
private sealed class System_SingleEqualityComparer 
{
	// Methods

	// RVA: 0xD0C390
	void .ctor() { }

	// RVA: 0xD0C398
	bool Equals(float left, float right) { }

	// RVA: 0xD0C3A4
	int GetHashCode(float obj) { }

}

// Namespace: 
private sealed class NullableSystem_SingleEqualityComparer 
{
	// Methods

	// RVA: 0xD0C3CC
	void .ctor() { }

	// RVA: 0xD0C3D4
	bool Equals(System.Nullable<System.Single> left, System.Nullable<System.Single> right) { }

	// RVA: 0xD0C528
	int GetHashCode(System.Nullable<System.Single> obj) { }

}

// Namespace: 
private sealed class System_StringComparisonEqualityComparer 
{
	// Methods

	// RVA: 0xD0C5DC
	void .ctor() { }

	// RVA: 0xD0C5E4
	bool Equals(StringComparison left, StringComparison right) { }

	// RVA: 0xD0C66C
	int GetHashCode(StringComparison obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringComparisonEqualityComparer 
{
	// Methods

	// RVA: 0xD0C694
	void .ctor() { }

	// RVA: 0xD0C69C
	bool Equals(System.Nullable<System.StringComparison> left, System.Nullable<System.StringComparison> right) { }

	// RVA: 0xD0C818
	int GetHashCode(System.Nullable<System.StringComparison> obj) { }

}

// Namespace: 
private sealed class System_StringSplitOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD0C8CC
	void .ctor() { }

	// RVA: 0xD0C8D4
	bool Equals(StringSplitOptions left, StringSplitOptions right) { }

	// RVA: 0xD0C95C
	int GetHashCode(StringSplitOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringSplitOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD0C984
	void .ctor() { }

	// RVA: 0xD0C98C
	bool Equals(System.Nullable<System.StringSplitOptions> left, System.Nullable<System.StringSplitOptions> right) { }

	// RVA: 0xD0CB08
	int GetHashCode(System.Nullable<System.StringSplitOptions> obj) { }

}

// Namespace: 
private sealed class System_TimeSpanEqualityComparer 
{
	// Methods

	// RVA: 0xD0CBBC
	void .ctor() { }

	// RVA: 0xD0CBC4
	bool Equals(TimeSpan left, TimeSpan right) { }

	// RVA: 0xD0CC3C
	int GetHashCode(TimeSpan obj) { }

}

// Namespace: 
private sealed class NullableSystem_TimeSpanEqualityComparer 
{
	// Methods

	// RVA: 0xD0CCA4
	void .ctor() { }

	// RVA: 0xD0CCAC
	bool Equals(System.Nullable<System.TimeSpan> left, System.Nullable<System.TimeSpan> right) { }

	// RVA: 0xD0CE20
	int GetHashCode(System.Nullable<System.TimeSpan> obj) { }

}

// Namespace: 
private sealed class System_TypeCodeEqualityComparer 
{
	// Methods

	// RVA: 0xD0CED4
	void .ctor() { }

	// RVA: 0xD0CEDC
	bool Equals(TypeCode left, TypeCode right) { }

	// RVA: 0xD0CF64
	int GetHashCode(TypeCode obj) { }

}

// Namespace: 
private sealed class NullableSystem_TypeCodeEqualityComparer 
{
	// Methods

	// RVA: 0xD0CF8C
	void .ctor() { }

	// RVA: 0xD0CF94
	bool Equals(System.Nullable<System.TypeCode> left, System.Nullable<System.TypeCode> right) { }

	// RVA: 0xD0D110
	int GetHashCode(System.Nullable<System.TypeCode> obj) { }

}

// Namespace: 
private sealed class System_UInt16EqualityComparer 
{
	// Methods

	// RVA: 0xD0D1C4
	void .ctor() { }

	// RVA: 0xD0D1CC
	bool Equals(UInt16 left, UInt16 right) { }

	// RVA: 0xD0D1D8
	int GetHashCode(UInt16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt16EqualityComparer 
{
	// Methods

	// RVA: 0xD0D200
	void .ctor() { }

	// RVA: 0xD0D208
	bool Equals(System.Nullable<System.UInt16> left, System.Nullable<System.UInt16> right) { }

	// RVA: 0xD0D34C
	int GetHashCode(System.Nullable<System.UInt16> obj) { }

}

// Namespace: 
private sealed class System_UInt32EqualityComparer 
{
	// Methods

	// RVA: 0xD0D400
	void .ctor() { }

	// RVA: 0xD0D408
	bool Equals(UInt32 left, UInt32 right) { }

	// RVA: 0xD0D414
	int GetHashCode(UInt32 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt32EqualityComparer 
{
	// Methods

	// RVA: 0xD0D43C
	void .ctor() { }

	// RVA: 0xD0D444
	bool Equals(System.Nullable<System.UInt32> left, System.Nullable<System.UInt32> right) { }

	// RVA: 0xD0D588
	int GetHashCode(System.Nullable<System.UInt32> obj) { }

}

// Namespace: 
private sealed class System_UInt64EqualityComparer 
{
	// Methods

	// RVA: 0xD0D63C
	void .ctor() { }

	// RVA: 0xD0D644
	bool Equals(UInt64 left, UInt64 right) { }

	// RVA: 0xD0D650
	int GetHashCode(UInt64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt64EqualityComparer 
{
	// Methods

	// RVA: 0xD0D678
	void .ctor() { }

	// RVA: 0xD0D680
	bool Equals(System.Nullable<System.UInt64> left, System.Nullable<System.UInt64> right) { }

	// RVA: 0xD0D7C8
	int GetHashCode(System.Nullable<System.UInt64> obj) { }

}

// Namespace: 
private sealed class System_UIntPtrEqualityComparer 
{
	// Methods

	// RVA: 0xD0D87C
	void .ctor() { }

	// RVA: 0xD0D884
	bool Equals(UIntPtr left, UIntPtr right) { }

	// RVA: 0xD0D894
	int GetHashCode(UIntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_UIntPtrEqualityComparer 
{
	// Methods

	// RVA: 0xD0D8BC
	void .ctor() { }

	// RVA: 0xD0D8C4
	bool Equals(System.Nullable<System.UIntPtr> left, System.Nullable<System.UIntPtr> right) { }

	// RVA: 0xD0DA10
	int GetHashCode(System.Nullable<System.UIntPtr> obj) { }

}

// Namespace: 
private sealed class System_Collections_DictionaryEntryEqualityComparer 
{
	// Methods

	// RVA: 0xD0DAC4
	void .ctor() { }

	// RVA: 0xD0DACC
	bool Equals(DictionaryEntry left, DictionaryEntry right) { }

	// RVA: 0xD0DB64
	int GetHashCode(DictionaryEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Collections_DictionaryEntryEqualityComparer 
{
	// Methods

	// RVA: 0xD0DBD8
	void .ctor() { }

	// RVA: 0xD0DBE0
	bool Equals(System.Nullable<System.Collections.DictionaryEntry> left, System.Nullable<System.Collections.DictionaryEntry> right) { }

	// RVA: 0xD0DD74
	int GetHashCode(System.Nullable<System.Collections.DictionaryEntry> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_DebuggerBrowsableStateEqualityComparer 
{
	// Methods

	// RVA: 0xD0DE24
	void .ctor() { }

	// RVA: 0xD0DE2C
	bool Equals(DebuggerBrowsableState left, DebuggerBrowsableState right) { }

	// RVA: 0xD0DEB4
	int GetHashCode(DebuggerBrowsableState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_DebuggerBrowsableStateEqualityComparer 
{
	// Methods

	// RVA: 0xD0DEDC
	void .ctor() { }

	// RVA: 0xD0DEE4
	bool Equals(System.Nullable<System.Diagnostics.DebuggerBrowsableState> left, System.Nullable<System.Diagnostics.DebuggerBrowsableState> right) { }

	// RVA: 0xD0E060
	int GetHashCode(System.Nullable<System.Diagnostics.DebuggerBrowsableState> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymAddressKindEqualityComparer 
{
	// Methods

	// RVA: 0xD0E114
	void .ctor() { }

	// RVA: 0xD0E11C
	bool Equals(SymAddressKind left, SymAddressKind right) { }

	// RVA: 0xD0E1A4
	int GetHashCode(SymAddressKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymAddressKindEqualityComparer 
{
	// Methods

	// RVA: 0xD0E1CC
	void .ctor() { }

	// RVA: 0xD0E1D4
	bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> left, System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> right) { }

	// RVA: 0xD0E350
	int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymbolTokenEqualityComparer 
{
	// Methods

	// RVA: 0xD0E404
	void .ctor() { }

	// RVA: 0xD0E40C
	bool Equals(SymbolToken left, SymbolToken right) { }

	// RVA: 0xD0E438
	int GetHashCode(SymbolToken obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymbolTokenEqualityComparer 
{
	// Methods

	// RVA: 0xD0E440
	void .ctor() { }

	// RVA: 0xD0E448
	bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> left, System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> right) { }

	// RVA: 0xD0E590
	int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarAlgorithmTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD0E644
	void .ctor() { }

	// RVA: 0xD0E64C
	bool Equals(CalendarAlgorithmType left, CalendarAlgorithmType right) { }

	// RVA: 0xD0E6D4
	int GetHashCode(CalendarAlgorithmType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarAlgorithmTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD0E6FC
	void .ctor() { }

	// RVA: 0xD0E704
	bool Equals(System.Nullable<System.Globalization.CalendarAlgorithmType> left, System.Nullable<System.Globalization.CalendarAlgorithmType> right) { }

	// RVA: 0xD0E880
	int GetHashCode(System.Nullable<System.Globalization.CalendarAlgorithmType> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarWeekRuleEqualityComparer 
{
	// Methods

	// RVA: 0xD0E934
	void .ctor() { }

	// RVA: 0xD0E93C
	bool Equals(CalendarWeekRule left, CalendarWeekRule right) { }

	// RVA: 0xD0E9C4
	int GetHashCode(CalendarWeekRule obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarWeekRuleEqualityComparer 
{
	// Methods

	// RVA: 0xD0E9EC
	void .ctor() { }

	// RVA: 0xD0E9F4
	bool Equals(System.Nullable<System.Globalization.CalendarWeekRule> left, System.Nullable<System.Globalization.CalendarWeekRule> right) { }

	// RVA: 0xD0EB70
	int GetHashCode(System.Nullable<System.Globalization.CalendarWeekRule> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CompareOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD0EC24
	void .ctor() { }

	// RVA: 0xD0EC2C
	bool Equals(CompareOptions left, CompareOptions right) { }

	// RVA: 0xD0ECB4
	int GetHashCode(CompareOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CompareOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD0ECDC
	void .ctor() { }

	// RVA: 0xD0ECE4
	bool Equals(System.Nullable<System.Globalization.CompareOptions> left, System.Nullable<System.Globalization.CompareOptions> right) { }

	// RVA: 0xD0EE60
	int GetHashCode(System.Nullable<System.Globalization.CompareOptions> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CultureTypesEqualityComparer 
{
	// Methods

	// RVA: 0xD0EF14
	void .ctor() { }

	// RVA: 0xD0EF1C
	bool Equals(CultureTypes left, CultureTypes right) { }

	// RVA: 0xD0EFA4
	int GetHashCode(CultureTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CultureTypesEqualityComparer 
{
	// Methods

	// RVA: 0xD0EFCC
	void .ctor() { }

	// RVA: 0xD0EFD4
	bool Equals(System.Nullable<System.Globalization.CultureTypes> left, System.Nullable<System.Globalization.CultureTypes> right) { }

	// RVA: 0xD0F150
	int GetHashCode(System.Nullable<System.Globalization.CultureTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DateTimeStylesEqualityComparer 
{
	// Methods

	// RVA: 0xD0F204
	void .ctor() { }

	// RVA: 0xD0F20C
	bool Equals(DateTimeStyles left, DateTimeStyles right) { }

	// RVA: 0xD0F294
	int GetHashCode(DateTimeStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DateTimeStylesEqualityComparer 
{
	// Methods

	// RVA: 0xD0F2BC
	void .ctor() { }

	// RVA: 0xD0F2C4
	bool Equals(System.Nullable<System.Globalization.DateTimeStyles> left, System.Nullable<System.Globalization.DateTimeStyles> right) { }

	// RVA: 0xD0F440
	int GetHashCode(System.Nullable<System.Globalization.DateTimeStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DigitShapesEqualityComparer 
{
	// Methods

	// RVA: 0xD0F4F4
	void .ctor() { }

	// RVA: 0xD0F4FC
	bool Equals(DigitShapes left, DigitShapes right) { }

	// RVA: 0xD0F584
	int GetHashCode(DigitShapes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DigitShapesEqualityComparer 
{
	// Methods

	// RVA: 0xD0F5AC
	void .ctor() { }

	// RVA: 0xD0F5B4
	bool Equals(System.Nullable<System.Globalization.DigitShapes> left, System.Nullable<System.Globalization.DigitShapes> right) { }

	// RVA: 0xD0F730
	int GetHashCode(System.Nullable<System.Globalization.DigitShapes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_GregorianCalendarTypesEqualityComparer 
{
	// Methods

	// RVA: 0xD0F7E4
	void .ctor() { }

	// RVA: 0xD0F7EC
	bool Equals(GregorianCalendarTypes left, GregorianCalendarTypes right) { }

	// RVA: 0xD0F874
	int GetHashCode(GregorianCalendarTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_GregorianCalendarTypesEqualityComparer 
{
	// Methods

	// RVA: 0xD0F89C
	void .ctor() { }

	// RVA: 0xD0F8A4
	bool Equals(System.Nullable<System.Globalization.GregorianCalendarTypes> left, System.Nullable<System.Globalization.GregorianCalendarTypes> right) { }

	// RVA: 0xD0FA20
	int GetHashCode(System.Nullable<System.Globalization.GregorianCalendarTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_NumberStylesEqualityComparer 
{
	// Methods

	// RVA: 0xD0FAD4
	void .ctor() { }

	// RVA: 0xD0FADC
	bool Equals(NumberStyles left, NumberStyles right) { }

	// RVA: 0xD0FB64
	int GetHashCode(NumberStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_NumberStylesEqualityComparer 
{
	// Methods

	// RVA: 0xD0FB8C
	void .ctor() { }

	// RVA: 0xD0FB94
	bool Equals(System.Nullable<System.Globalization.NumberStyles> left, System.Nullable<System.Globalization.NumberStyles> right) { }

	// RVA: 0xD0FD10
	int GetHashCode(System.Nullable<System.Globalization.NumberStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_UnicodeCategoryEqualityComparer 
{
	// Methods

	// RVA: 0xD0FDC4
	void .ctor() { }

	// RVA: 0xD0FDCC
	bool Equals(UnicodeCategory left, UnicodeCategory right) { }

	// RVA: 0xD0FE54
	int GetHashCode(UnicodeCategory obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_UnicodeCategoryEqualityComparer 
{
	// Methods

	// RVA: 0xD0FE7C
	void .ctor() { }

	// RVA: 0xD0FE84
	bool Equals(System.Nullable<System.Globalization.UnicodeCategory> left, System.Nullable<System.Globalization.UnicodeCategory> right) { }

	// RVA: 0xD10000
	int GetHashCode(System.Nullable<System.Globalization.UnicodeCategory> obj) { }

}

// Namespace: 
private sealed class System_IO_DriveTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD100B4
	void .ctor() { }

	// RVA: 0xD100BC
	bool Equals(DriveType left, DriveType right) { }

	// RVA: 0xD10144
	int GetHashCode(DriveType obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_DriveTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD1016C
	void .ctor() { }

	// RVA: 0xD10174
	bool Equals(System.Nullable<System.IO.DriveType> left, System.Nullable<System.IO.DriveType> right) { }

	// RVA: 0xD102F0
	int GetHashCode(System.Nullable<System.IO.DriveType> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAccessEqualityComparer 
{
	// Methods

	// RVA: 0xD103A4
	void .ctor() { }

	// RVA: 0xD103AC
	bool Equals(FileAccess left, FileAccess right) { }

	// RVA: 0xD10434
	int GetHashCode(FileAccess obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAccessEqualityComparer 
{
	// Methods

	// RVA: 0xD1045C
	void .ctor() { }

	// RVA: 0xD10464
	bool Equals(System.Nullable<System.IO.FileAccess> left, System.Nullable<System.IO.FileAccess> right) { }

	// RVA: 0xD105E0
	int GetHashCode(System.Nullable<System.IO.FileAccess> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD10694
	void .ctor() { }

	// RVA: 0xD1069C
	bool Equals(FileAttributes left, FileAttributes right) { }

	// RVA: 0xD10724
	int GetHashCode(FileAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD1074C
	void .ctor() { }

	// RVA: 0xD10754
	bool Equals(System.Nullable<System.IO.FileAttributes> left, System.Nullable<System.IO.FileAttributes> right) { }

	// RVA: 0xD108D0
	int GetHashCode(System.Nullable<System.IO.FileAttributes> obj) { }

}

// Namespace: 
private sealed class System_IO_FileModeEqualityComparer 
{
	// Methods

	// RVA: 0xD10984
	void .ctor() { }

	// RVA: 0xD1098C
	bool Equals(FileMode left, FileMode right) { }

	// RVA: 0xD10A14
	int GetHashCode(FileMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileModeEqualityComparer 
{
	// Methods

	// RVA: 0xD10A3C
	void .ctor() { }

	// RVA: 0xD10A44
	bool Equals(System.Nullable<System.IO.FileMode> left, System.Nullable<System.IO.FileMode> right) { }

	// RVA: 0xD10BC0
	int GetHashCode(System.Nullable<System.IO.FileMode> obj) { }

}

// Namespace: 
private sealed class System_IO_FileOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD10C74
	void .ctor() { }

	// RVA: 0xD10C7C
	bool Equals(FileOptions left, FileOptions right) { }

	// RVA: 0xD10D04
	int GetHashCode(FileOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD10D2C
	void .ctor() { }

	// RVA: 0xD10D34
	bool Equals(System.Nullable<System.IO.FileOptions> left, System.Nullable<System.IO.FileOptions> right) { }

	// RVA: 0xD10EB0
	int GetHashCode(System.Nullable<System.IO.FileOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_FileShareEqualityComparer 
{
	// Methods

	// RVA: 0xD10F64
	void .ctor() { }

	// RVA: 0xD10F6C
	bool Equals(FileShare left, FileShare right) { }

	// RVA: 0xD10FF4
	int GetHashCode(FileShare obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileShareEqualityComparer 
{
	// Methods

	// RVA: 0xD1101C
	void .ctor() { }

	// RVA: 0xD11024
	bool Equals(System.Nullable<System.IO.FileShare> left, System.Nullable<System.IO.FileShare> right) { }

	// RVA: 0xD111A0
	int GetHashCode(System.Nullable<System.IO.FileShare> obj) { }

}

// Namespace: 
private sealed class System_IO_HandleInheritabilityEqualityComparer 
{
	// Methods

	// RVA: 0xD11254
	void .ctor() { }

	// RVA: 0xD1125C
	bool Equals(HandleInheritability left, HandleInheritability right) { }

	// RVA: 0xD112E4
	int GetHashCode(HandleInheritability obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_HandleInheritabilityEqualityComparer 
{
	// Methods

	// RVA: 0xD1130C
	void .ctor() { }

	// RVA: 0xD11314
	bool Equals(System.Nullable<System.IO.HandleInheritability> left, System.Nullable<System.IO.HandleInheritability> right) { }

	// RVA: 0xD11490
	int GetHashCode(System.Nullable<System.IO.HandleInheritability> obj) { }

}

// Namespace: 
private sealed class System_IO_SearchOptionEqualityComparer 
{
	// Methods

	// RVA: 0xD11544
	void .ctor() { }

	// RVA: 0xD1154C
	bool Equals(SearchOption left, SearchOption right) { }

	// RVA: 0xD115D4
	int GetHashCode(SearchOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SearchOptionEqualityComparer 
{
	// Methods

	// RVA: 0xD115FC
	void .ctor() { }

	// RVA: 0xD11604
	bool Equals(System.Nullable<System.IO.SearchOption> left, System.Nullable<System.IO.SearchOption> right) { }

	// RVA: 0xD11780
	int GetHashCode(System.Nullable<System.IO.SearchOption> obj) { }

}

// Namespace: 
private sealed class System_IO_SeekOriginEqualityComparer 
{
	// Methods

	// RVA: 0xD11834
	void .ctor() { }

	// RVA: 0xD1183C
	bool Equals(SeekOrigin left, SeekOrigin right) { }

	// RVA: 0xD118C4
	int GetHashCode(SeekOrigin obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SeekOriginEqualityComparer 
{
	// Methods

	// RVA: 0xD118EC
	void .ctor() { }

	// RVA: 0xD118F4
	bool Equals(System.Nullable<System.IO.SeekOrigin> left, System.Nullable<System.IO.SeekOrigin> right) { }

	// RVA: 0xD11A70
	int GetHashCode(System.Nullable<System.IO.SeekOrigin> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeAccessRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD11B24
	void .ctor() { }

	// RVA: 0xD11B2C
	bool Equals(PipeAccessRights left, PipeAccessRights right) { }

	// RVA: 0xD11BB4
	int GetHashCode(PipeAccessRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeAccessRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD11BDC
	void .ctor() { }

	// RVA: 0xD11BE4
	bool Equals(System.Nullable<System.IO.Pipes.PipeAccessRights> left, System.Nullable<System.IO.Pipes.PipeAccessRights> right) { }

	// RVA: 0xD11D60
	int GetHashCode(System.Nullable<System.IO.Pipes.PipeAccessRights> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeDirectionEqualityComparer 
{
	// Methods

	// RVA: 0xD11E14
	void .ctor() { }

	// RVA: 0xD11E1C
	bool Equals(PipeDirection left, PipeDirection right) { }

	// RVA: 0xD11EA4
	int GetHashCode(PipeDirection obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeDirectionEqualityComparer 
{
	// Methods

	// RVA: 0xD11ECC
	void .ctor() { }

	// RVA: 0xD11ED4
	bool Equals(System.Nullable<System.IO.Pipes.PipeDirection> left, System.Nullable<System.IO.Pipes.PipeDirection> right) { }

	// RVA: 0xD12050
	int GetHashCode(System.Nullable<System.IO.Pipes.PipeDirection> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD12104
	void .ctor() { }

	// RVA: 0xD1210C
	bool Equals(PipeOptions left, PipeOptions right) { }

	// RVA: 0xD12194
	int GetHashCode(PipeOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD121BC
	void .ctor() { }

	// RVA: 0xD121C4
	bool Equals(System.Nullable<System.IO.Pipes.PipeOptions> left, System.Nullable<System.IO.Pipes.PipeOptions> right) { }

	// RVA: 0xD12340
	int GetHashCode(System.Nullable<System.IO.Pipes.PipeOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeTransmissionModeEqualityComparer 
{
	// Methods

	// RVA: 0xD123F4
	void .ctor() { }

	// RVA: 0xD123FC
	bool Equals(PipeTransmissionMode left, PipeTransmissionMode right) { }

	// RVA: 0xD12484
	int GetHashCode(PipeTransmissionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeTransmissionModeEqualityComparer 
{
	// Methods

	// RVA: 0xD124AC
	void .ctor() { }

	// RVA: 0xD124B4
	bool Equals(System.Nullable<System.IO.Pipes.PipeTransmissionMode> left, System.Nullable<System.IO.Pipes.PipeTransmissionMode> right) { }

	// RVA: 0xD12630
	int GetHashCode(System.Nullable<System.IO.Pipes.PipeTransmissionMode> obj) { }

}

// Namespace: 
private sealed class System_Reflection_AssemblyNameFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD126E4
	void .ctor() { }

	// RVA: 0xD126EC
	bool Equals(AssemblyNameFlags left, AssemblyNameFlags right) { }

	// RVA: 0xD12774
	int GetHashCode(AssemblyNameFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_AssemblyNameFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1279C
	void .ctor() { }

	// RVA: 0xD127A4
	bool Equals(System.Nullable<System.Reflection.AssemblyNameFlags> left, System.Nullable<System.Reflection.AssemblyNameFlags> right) { }

	// RVA: 0xD12920
	int GetHashCode(System.Nullable<System.Reflection.AssemblyNameFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_BindingFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD129D4
	void .ctor() { }

	// RVA: 0xD129DC
	bool Equals(BindingFlags left, BindingFlags right) { }

	// RVA: 0xD12A64
	int GetHashCode(BindingFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_BindingFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD12A8C
	void .ctor() { }

	// RVA: 0xD12A94
	bool Equals(System.Nullable<System.Reflection.BindingFlags> left, System.Nullable<System.Reflection.BindingFlags> right) { }

	// RVA: 0xD12C10
	int GetHashCode(System.Nullable<System.Reflection.BindingFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CallingConventionsEqualityComparer 
{
	// Methods

	// RVA: 0xD12CC4
	void .ctor() { }

	// RVA: 0xD12CCC
	bool Equals(CallingConventions left, CallingConventions right) { }

	// RVA: 0xD12D54
	int GetHashCode(CallingConventions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CallingConventionsEqualityComparer 
{
	// Methods

	// RVA: 0xD12D7C
	void .ctor() { }

	// RVA: 0xD12D84
	bool Equals(System.Nullable<System.Reflection.CallingConventions> left, System.Nullable<System.Reflection.CallingConventions> right) { }

	// RVA: 0xD12F00
	int GetHashCode(System.Nullable<System.Reflection.CallingConventions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeNamedArgumentEqualityComparer 
{
	// Methods

	// RVA: 0xD12FB4
	void .ctor() { }

	// RVA: 0xD12FBC
	bool Equals(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0xD13040
	int GetHashCode(CustomAttributeNamedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeNamedArgumentEqualityComparer 
{
	// Methods

	// RVA: 0xD1304C
	void .ctor() { }

	// RVA: 0xD13054
	bool Equals(System.Nullable<System.Reflection.CustomAttributeNamedArgument> left, System.Nullable<System.Reflection.CustomAttributeNamedArgument> right) { }

	// RVA: 0xD131EC
	int GetHashCode(System.Nullable<System.Reflection.CustomAttributeNamedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeTypedArgumentEqualityComparer 
{
	// Methods

	// RVA: 0xD1329C
	void .ctor() { }

	// RVA: 0xD132A4
	bool Equals(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0xD13320
	int GetHashCode(CustomAttributeTypedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeTypedArgumentEqualityComparer 
{
	// Methods

	// RVA: 0xD13348
	void .ctor() { }

	// RVA: 0xD13350
	bool Equals(System.Nullable<System.Reflection.CustomAttributeTypedArgument> left, System.Nullable<System.Reflection.CustomAttributeTypedArgument> right) { }

	// RVA: 0xD134D8
	int GetHashCode(System.Nullable<System.Reflection.CustomAttributeTypedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_EventAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD13588
	void .ctor() { }

	// RVA: 0xD13590
	bool Equals(EventAttributes left, EventAttributes right) { }

	// RVA: 0xD13618
	int GetHashCode(EventAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_EventAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD13640
	void .ctor() { }

	// RVA: 0xD13648
	bool Equals(System.Nullable<System.Reflection.EventAttributes> left, System.Nullable<System.Reflection.EventAttributes> right) { }

	// RVA: 0xD137C4
	int GetHashCode(System.Nullable<System.Reflection.EventAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ExceptionHandlingClauseOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD13878
	void .ctor() { }

	// RVA: 0xD13880
	bool Equals(ExceptionHandlingClauseOptions left, ExceptionHandlingClauseOptions right) { }

	// RVA: 0xD13908
	int GetHashCode(ExceptionHandlingClauseOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ExceptionHandlingClauseOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD13930
	void .ctor() { }

	// RVA: 0xD13938
	bool Equals(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> left, System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> right) { }

	// RVA: 0xD13AB4
	int GetHashCode(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_FieldAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD13B68
	void .ctor() { }

	// RVA: 0xD13B70
	bool Equals(FieldAttributes left, FieldAttributes right) { }

	// RVA: 0xD13BF8
	int GetHashCode(FieldAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_FieldAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD13C20
	void .ctor() { }

	// RVA: 0xD13C28
	bool Equals(System.Nullable<System.Reflection.FieldAttributes> left, System.Nullable<System.Reflection.FieldAttributes> right) { }

	// RVA: 0xD13DA4
	int GetHashCode(System.Nullable<System.Reflection.FieldAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_GenericParameterAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD13E58
	void .ctor() { }

	// RVA: 0xD13E60
	bool Equals(GenericParameterAttributes left, GenericParameterAttributes right) { }

	// RVA: 0xD13EE8
	int GetHashCode(GenericParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_GenericParameterAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD13F10
	void .ctor() { }

	// RVA: 0xD13F18
	bool Equals(System.Nullable<System.Reflection.GenericParameterAttributes> left, System.Nullable<System.Reflection.GenericParameterAttributes> right) { }

	// RVA: 0xD14094
	int GetHashCode(System.Nullable<System.Reflection.GenericParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ImageFileMachineEqualityComparer 
{
	// Methods

	// RVA: 0xD14148
	void .ctor() { }

	// RVA: 0xD14150
	bool Equals(ImageFileMachine left, ImageFileMachine right) { }

	// RVA: 0xD141D8
	int GetHashCode(ImageFileMachine obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ImageFileMachineEqualityComparer 
{
	// Methods

	// RVA: 0xD14200
	void .ctor() { }

	// RVA: 0xD14208
	bool Equals(System.Nullable<System.Reflection.ImageFileMachine> left, System.Nullable<System.Reflection.ImageFileMachine> right) { }

	// RVA: 0xD14384
	int GetHashCode(System.Nullable<System.Reflection.ImageFileMachine> obj) { }

}

// Namespace: 
private sealed class System_Reflection_InterfaceMappingEqualityComparer 
{
	// Methods

	// RVA: 0xD14438
	void .ctor() { }

	// RVA: 0xD14440
	bool Equals(InterfaceMapping left, InterfaceMapping right) { }

	// RVA: 0xD144D0
	int GetHashCode(InterfaceMapping obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_InterfaceMappingEqualityComparer 
{
	// Methods

	// RVA: 0xD14544
	void .ctor() { }

	// RVA: 0xD1454C
	bool Equals(System.Nullable<System.Reflection.InterfaceMapping> left, System.Nullable<System.Reflection.InterfaceMapping> right) { }

	// RVA: 0xD146E8
	int GetHashCode(System.Nullable<System.Reflection.InterfaceMapping> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MemberTypesEqualityComparer 
{
	// Methods

	// RVA: 0xD14798
	void .ctor() { }

	// RVA: 0xD147A0
	bool Equals(MemberTypes left, MemberTypes right) { }

	// RVA: 0xD14828
	int GetHashCode(MemberTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MemberTypesEqualityComparer 
{
	// Methods

	// RVA: 0xD14850
	void .ctor() { }

	// RVA: 0xD14858
	bool Equals(System.Nullable<System.Reflection.MemberTypes> left, System.Nullable<System.Reflection.MemberTypes> right) { }

	// RVA: 0xD149D4
	int GetHashCode(System.Nullable<System.Reflection.MemberTypes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD14A88
	void .ctor() { }

	// RVA: 0xD14A90
	bool Equals(MethodAttributes left, MethodAttributes right) { }

	// RVA: 0xD14B18
	int GetHashCode(MethodAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD14B40
	void .ctor() { }

	// RVA: 0xD14B48
	bool Equals(System.Nullable<System.Reflection.MethodAttributes> left, System.Nullable<System.Reflection.MethodAttributes> right) { }

	// RVA: 0xD14CC4
	int GetHashCode(System.Nullable<System.Reflection.MethodAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodImplAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD14D78
	void .ctor() { }

	// RVA: 0xD14D80
	bool Equals(MethodImplAttributes left, MethodImplAttributes right) { }

	// RVA: 0xD14E08
	int GetHashCode(MethodImplAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodImplAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD14E30
	void .ctor() { }

	// RVA: 0xD14E38
	bool Equals(System.Nullable<System.Reflection.MethodImplAttributes> left, System.Nullable<System.Reflection.MethodImplAttributes> right) { }

	// RVA: 0xD14FB4
	int GetHashCode(System.Nullable<System.Reflection.MethodImplAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD15068
	void .ctor() { }

	// RVA: 0xD15070
	bool Equals(ParameterAttributes left, ParameterAttributes right) { }

	// RVA: 0xD150F8
	int GetHashCode(ParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD15120
	void .ctor() { }

	// RVA: 0xD15128
	bool Equals(System.Nullable<System.Reflection.ParameterAttributes> left, System.Nullable<System.Reflection.ParameterAttributes> right) { }

	// RVA: 0xD152A4
	int GetHashCode(System.Nullable<System.Reflection.ParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterModifierEqualityComparer 
{
	// Methods

	// RVA: 0xD15358
	void .ctor() { }

	// RVA: 0xD15360
	bool Equals(ParameterModifier left, ParameterModifier right) { }

	// RVA: 0xD153E8
	int GetHashCode(ParameterModifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterModifierEqualityComparer 
{
	// Methods

	// RVA: 0xD15458
	void .ctor() { }

	// RVA: 0xD15460
	bool Equals(System.Nullable<System.Reflection.ParameterModifier> left, System.Nullable<System.Reflection.ParameterModifier> right) { }

	// RVA: 0xD155DC
	int GetHashCode(System.Nullable<System.Reflection.ParameterModifier> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PortableExecutableKindsEqualityComparer 
{
	// Methods

	// RVA: 0xD15690
	void .ctor() { }

	// RVA: 0xD15698
	bool Equals(PortableExecutableKinds left, PortableExecutableKinds right) { }

	// RVA: 0xD15720
	int GetHashCode(PortableExecutableKinds obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PortableExecutableKindsEqualityComparer 
{
	// Methods

	// RVA: 0xD15748
	void .ctor() { }

	// RVA: 0xD15750
	bool Equals(System.Nullable<System.Reflection.PortableExecutableKinds> left, System.Nullable<System.Reflection.PortableExecutableKinds> right) { }

	// RVA: 0xD158CC
	int GetHashCode(System.Nullable<System.Reflection.PortableExecutableKinds> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ProcessorArchitectureEqualityComparer 
{
	// Methods

	// RVA: 0xD15980
	void .ctor() { }

	// RVA: 0xD15988
	bool Equals(ProcessorArchitecture left, ProcessorArchitecture right) { }

	// RVA: 0xD15A10
	int GetHashCode(ProcessorArchitecture obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ProcessorArchitectureEqualityComparer 
{
	// Methods

	// RVA: 0xD15A38
	void .ctor() { }

	// RVA: 0xD15A40
	bool Equals(System.Nullable<System.Reflection.ProcessorArchitecture> left, System.Nullable<System.Reflection.ProcessorArchitecture> right) { }

	// RVA: 0xD15BBC
	int GetHashCode(System.Nullable<System.Reflection.ProcessorArchitecture> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PropertyAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD15C70
	void .ctor() { }

	// RVA: 0xD15C78
	bool Equals(PropertyAttributes left, PropertyAttributes right) { }

	// RVA: 0xD15D00
	int GetHashCode(PropertyAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PropertyAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD15D28
	void .ctor() { }

	// RVA: 0xD15D30
	bool Equals(System.Nullable<System.Reflection.PropertyAttributes> left, System.Nullable<System.Reflection.PropertyAttributes> right) { }

	// RVA: 0xD15EAC
	int GetHashCode(System.Nullable<System.Reflection.PropertyAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD15F60
	void .ctor() { }

	// RVA: 0xD15F68
	bool Equals(ResourceAttributes left, ResourceAttributes right) { }

	// RVA: 0xD15FF0
	int GetHashCode(ResourceAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD16018
	void .ctor() { }

	// RVA: 0xD16020
	bool Equals(System.Nullable<System.Reflection.ResourceAttributes> left, System.Nullable<System.Reflection.ResourceAttributes> right) { }

	// RVA: 0xD1619C
	int GetHashCode(System.Nullable<System.Reflection.ResourceAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceLocationEqualityComparer 
{
	// Methods

	// RVA: 0xD16250
	void .ctor() { }

	// RVA: 0xD16258
	bool Equals(ResourceLocation left, ResourceLocation right) { }

	// RVA: 0xD162E0
	int GetHashCode(ResourceLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceLocationEqualityComparer 
{
	// Methods

	// RVA: 0xD16308
	void .ctor() { }

	// RVA: 0xD16310
	bool Equals(System.Nullable<System.Reflection.ResourceLocation> left, System.Nullable<System.Reflection.ResourceLocation> right) { }

	// RVA: 0xD1648C
	int GetHashCode(System.Nullable<System.Reflection.ResourceLocation> obj) { }

}

// Namespace: 
private sealed class System_Reflection_TypeAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD16540
	void .ctor() { }

	// RVA: 0xD16548
	bool Equals(TypeAttributes left, TypeAttributes right) { }

	// RVA: 0xD165D0
	int GetHashCode(TypeAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_TypeAttributesEqualityComparer 
{
	// Methods

	// RVA: 0xD165F8
	void .ctor() { }

	// RVA: 0xD16600
	bool Equals(System.Nullable<System.Reflection.TypeAttributes> left, System.Nullable<System.Reflection.TypeAttributes> right) { }

	// RVA: 0xD1677C
	int GetHashCode(System.Nullable<System.Reflection.TypeAttributes> obj) { }

}

// Namespace: 
private sealed class System_Resources_UltimateResourceFallbackLocationEqualityComparer 
{
	// Methods

	// RVA: 0xD16830
	void .ctor() { }

	// RVA: 0xD16838
	bool Equals(UltimateResourceFallbackLocation left, UltimateResourceFallbackLocation right) { }

	// RVA: 0xD168C0
	int GetHashCode(UltimateResourceFallbackLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Resources_UltimateResourceFallbackLocationEqualityComparer 
{
	// Methods

	// RVA: 0xD168E8
	void .ctor() { }

	// RVA: 0xD168F0
	bool Equals(System.Nullable<System.Resources.UltimateResourceFallbackLocation> left, System.Nullable<System.Resources.UltimateResourceFallbackLocation> right) { }

	// RVA: 0xD16A6C
	int GetHashCode(System.Nullable<System.Resources.UltimateResourceFallbackLocation> obj) { }

}

// Namespace: 
private sealed class System_Runtime_GCLatencyModeEqualityComparer 
{
	// Methods

	// RVA: 0xD16B20
	void .ctor() { }

	// RVA: 0xD16B28
	bool Equals(GCLatencyMode left, GCLatencyMode right) { }

	// RVA: 0xD16BB0
	int GetHashCode(GCLatencyMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_GCLatencyModeEqualityComparer 
{
	// Methods

	// RVA: 0xD16BD8
	void .ctor() { }

	// RVA: 0xD16BE0
	bool Equals(System.Nullable<System.Runtime.GCLatencyMode> left, System.Nullable<System.Runtime.GCLatencyMode> right) { }

	// RVA: 0xD16D5C
	int GetHashCode(System.Nullable<System.Runtime.GCLatencyMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer 
{
	// Methods

	// RVA: 0xD16E10
	void .ctor() { }

	// RVA: 0xD16E18
	bool Equals(CompilationRelaxations left, CompilationRelaxations right) { }

	// RVA: 0xD16EA0
	int GetHashCode(CompilationRelaxations obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer 
{
	// Methods

	// RVA: 0xD16EC8
	void .ctor() { }

	// RVA: 0xD16ED0
	bool Equals(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> left, System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> right) { }

	// RVA: 0xD1704C
	int GetHashCode(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_LoadHintEqualityComparer 
{
	// Methods

	// RVA: 0xD17100
	void .ctor() { }

	// RVA: 0xD17108
	bool Equals(LoadHint left, LoadHint right) { }

	// RVA: 0xD17190
	int GetHashCode(LoadHint obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_LoadHintEqualityComparer 
{
	// Methods

	// RVA: 0xD171B8
	void .ctor() { }

	// RVA: 0xD171C0
	bool Equals(System.Nullable<System.Runtime.CompilerServices.LoadHint> left, System.Nullable<System.Runtime.CompilerServices.LoadHint> right) { }

	// RVA: 0xD1733C
	int GetHashCode(System.Nullable<System.Runtime.CompilerServices.LoadHint> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodCodeTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD173F0
	void .ctor() { }

	// RVA: 0xD173F8
	bool Equals(MethodCodeType left, MethodCodeType right) { }

	// RVA: 0xD17480
	int GetHashCode(MethodCodeType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodCodeTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD174A8
	void .ctor() { }

	// RVA: 0xD174B0
	bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> left, System.Nullable<System.Runtime.CompilerServices.MethodCodeType> right) { }

	// RVA: 0xD1762C
	int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodImplOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD176E0
	void .ctor() { }

	// RVA: 0xD176E8
	bool Equals(MethodImplOptions left, MethodImplOptions right) { }

	// RVA: 0xD17770
	int GetHashCode(MethodImplOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodImplOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD17798
	void .ctor() { }

	// RVA: 0xD177A0
	bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> left, System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> right) { }

	// RVA: 0xD1791C
	int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_CerEqualityComparer 
{
	// Methods

	// RVA: 0xD179D0
	void .ctor() { }

	// RVA: 0xD179D8
	bool Equals(Cer left, Cer right) { }

	// RVA: 0xD17A60
	int GetHashCode(Cer obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_CerEqualityComparer 
{
	// Methods

	// RVA: 0xD17A88
	void .ctor() { }

	// RVA: 0xD17A90
	bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Cer> left, System.Nullable<System.Runtime.ConstrainedExecution.Cer> right) { }

	// RVA: 0xD17C0C
	int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Cer> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_ConsistencyEqualityComparer 
{
	// Methods

	// RVA: 0xD17CC0
	void .ctor() { }

	// RVA: 0xD17CC8
	bool Equals(Consistency left, Consistency right) { }

	// RVA: 0xD17D50
	int GetHashCode(Consistency obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_ConsistencyEqualityComparer 
{
	// Methods

	// RVA: 0xD17D78
	void .ctor() { }

	// RVA: 0xD17D80
	bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> left, System.Nullable<System.Runtime.ConstrainedExecution.Consistency> right) { }

	// RVA: 0xD17EFC
	int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ArrayWithOffsetEqualityComparer 
{
	// Methods

	// RVA: 0xD17FB0
	void .ctor() { }

	// RVA: 0xD17FB8
	bool Equals(ArrayWithOffset left, ArrayWithOffset right) { }

	// RVA: 0xD17FE8
	int GetHashCode(ArrayWithOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ArrayWithOffsetEqualityComparer 
{
	// Methods

	// RVA: 0xD18010
	void .ctor() { }

	// RVA: 0xD18018
	bool Equals(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> left, System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> right) { }

	// RVA: 0xD18178
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD18228
	void .ctor() { }

	// RVA: 0xD18230
	bool Equals(AssemblyRegistrationFlags left, AssemblyRegistrationFlags right) { }

	// RVA: 0xD182B8
	int GetHashCode(AssemblyRegistrationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD182E0
	void .ctor() { }

	// RVA: 0xD182E8
	bool Equals(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> left, System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> right) { }

	// RVA: 0xD18464
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CallingConventionEqualityComparer 
{
	// Methods

	// RVA: 0xD18518
	void .ctor() { }

	// RVA: 0xD18520
	bool Equals(CallingConvention left, CallingConvention right) { }

	// RVA: 0xD185A8
	int GetHashCode(CallingConvention obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CallingConventionEqualityComparer 
{
	// Methods

	// RVA: 0xD185D0
	void .ctor() { }

	// RVA: 0xD185D8
	bool Equals(System.Nullable<System.Runtime.InteropServices.CallingConvention> left, System.Nullable<System.Runtime.InteropServices.CallingConvention> right) { }

	// RVA: 0xD18754
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.CallingConvention> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CharSetEqualityComparer 
{
	// Methods

	// RVA: 0xD18808
	void .ctor() { }

	// RVA: 0xD18810
	bool Equals(CharSet left, CharSet right) { }

	// RVA: 0xD18898
	int GetHashCode(CharSet obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CharSetEqualityComparer 
{
	// Methods

	// RVA: 0xD188C0
	void .ctor() { }

	// RVA: 0xD188C8
	bool Equals(System.Nullable<System.Runtime.InteropServices.CharSet> left, System.Nullable<System.Runtime.InteropServices.CharSet> right) { }

	// RVA: 0xD18A44
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.CharSet> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD18AF8
	void .ctor() { }

	// RVA: 0xD18B00
	bool Equals(ClassInterfaceType left, ClassInterfaceType right) { }

	// RVA: 0xD18B88
	int GetHashCode(ClassInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD18BB0
	void .ctor() { }

	// RVA: 0xD18BB8
	bool Equals(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> right) { }

	// RVA: 0xD18D34
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComInterfaceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD18DE8
	void .ctor() { }

	// RVA: 0xD18DF0
	bool Equals(ComInterfaceType left, ComInterfaceType right) { }

	// RVA: 0xD18E78
	int GetHashCode(ComInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComInterfaceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD18EA0
	void .ctor() { }

	// RVA: 0xD18EA8
	bool Equals(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ComInterfaceType> right) { }

	// RVA: 0xD19024
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComMemberTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD190D8
	void .ctor() { }

	// RVA: 0xD190E0
	bool Equals(ComMemberType left, ComMemberType right) { }

	// RVA: 0xD19168
	int GetHashCode(ComMemberType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComMemberTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD19190
	void .ctor() { }

	// RVA: 0xD19198
	bool Equals(System.Nullable<System.Runtime.InteropServices.ComMemberType> left, System.Nullable<System.Runtime.InteropServices.ComMemberType> right) { }

	// RVA: 0xD19314
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComMemberType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ExporterEventKindEqualityComparer 
{
	// Methods

	// RVA: 0xD193C8
	void .ctor() { }

	// RVA: 0xD193D0
	bool Equals(ExporterEventKind left, ExporterEventKind right) { }

	// RVA: 0xD19458
	int GetHashCode(ExporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ExporterEventKindEqualityComparer 
{
	// Methods

	// RVA: 0xD19480
	void .ctor() { }

	// RVA: 0xD19488
	bool Equals(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ExporterEventKind> right) { }

	// RVA: 0xD19604
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD196B8
	void .ctor() { }

	// RVA: 0xD196C0
	bool Equals(GCHandle left, GCHandle right) { }

	// RVA: 0xD19738
	int GetHashCode(GCHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleEqualityComparer 
{
	// Methods

	// RVA: 0xD19760
	void .ctor() { }

	// RVA: 0xD19768
	bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandle> left, System.Nullable<System.Runtime.InteropServices.GCHandle> right) { }

	// RVA: 0xD198D4
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD19988
	void .ctor() { }

	// RVA: 0xD19990
	bool Equals(GCHandleType left, GCHandleType right) { }

	// RVA: 0xD19A18
	int GetHashCode(GCHandleType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD19A40
	void .ctor() { }

	// RVA: 0xD19A48
	bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandleType> left, System.Nullable<System.Runtime.InteropServices.GCHandleType> right) { }

	// RVA: 0xD19BC4
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandleType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_HandleRefEqualityComparer 
{
	// Methods

	// RVA: 0xD19C78
	void .ctor() { }

	// RVA: 0xD19C80
	bool Equals(HandleRef left, HandleRef right) { }

	// RVA: 0xD19D18
	int GetHashCode(HandleRef obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_HandleRefEqualityComparer 
{
	// Methods

	// RVA: 0xD19D8C
	void .ctor() { }

	// RVA: 0xD19D94
	bool Equals(System.Nullable<System.Runtime.InteropServices.HandleRef> left, System.Nullable<System.Runtime.InteropServices.HandleRef> right) { }

	// RVA: 0xD19F28
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.HandleRef> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ImporterEventKindEqualityComparer 
{
	// Methods

	// RVA: 0xD19FD8
	void .ctor() { }

	// RVA: 0xD19FE0
	bool Equals(ImporterEventKind left, ImporterEventKind right) { }

	// RVA: 0xD1A068
	int GetHashCode(ImporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ImporterEventKindEqualityComparer 
{
	// Methods

	// RVA: 0xD1A090
	void .ctor() { }

	// RVA: 0xD1A098
	bool Equals(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ImporterEventKind> right) { }

	// RVA: 0xD1A214
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_LayoutKindEqualityComparer 
{
	// Methods

	// RVA: 0xD1A2C8
	void .ctor() { }

	// RVA: 0xD1A2D0
	bool Equals(LayoutKind left, LayoutKind right) { }

	// RVA: 0xD1A358
	int GetHashCode(LayoutKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_LayoutKindEqualityComparer 
{
	// Methods

	// RVA: 0xD1A380
	void .ctor() { }

	// RVA: 0xD1A388
	bool Equals(System.Nullable<System.Runtime.InteropServices.LayoutKind> left, System.Nullable<System.Runtime.InteropServices.LayoutKind> right) { }

	// RVA: 0xD1A504
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.LayoutKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationClassContextEqualityComparer 
{
	// Methods

	// RVA: 0xD1A5B8
	void .ctor() { }

	// RVA: 0xD1A5C0
	bool Equals(RegistrationClassContext left, RegistrationClassContext right) { }

	// RVA: 0xD1A648
	int GetHashCode(RegistrationClassContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationClassContextEqualityComparer 
{
	// Methods

	// RVA: 0xD1A670
	void .ctor() { }

	// RVA: 0xD1A678
	bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> left, System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> right) { }

	// RVA: 0xD1A7F4
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD1A8A8
	void .ctor() { }

	// RVA: 0xD1A8B0
	bool Equals(RegistrationConnectionType left, RegistrationConnectionType right) { }

	// RVA: 0xD1A938
	int GetHashCode(RegistrationConnectionType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD1A960
	void .ctor() { }

	// RVA: 0xD1A968
	bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> left, System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> right) { }

	// RVA: 0xD1AAE4
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1AB98
	void .ctor() { }

	// RVA: 0xD1ABA0
	bool Equals(TypeLibExporterFlags left, TypeLibExporterFlags right) { }

	// RVA: 0xD1AC28
	int GetHashCode(TypeLibExporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1AC50
	void .ctor() { }

	// RVA: 0xD1AC58
	bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> right) { }

	// RVA: 0xD1ADD4
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1AE88
	void .ctor() { }

	// RVA: 0xD1AE90
	bool Equals(TypeLibFuncFlags left, TypeLibFuncFlags right) { }

	// RVA: 0xD1AF18
	int GetHashCode(TypeLibFuncFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1AF40
	void .ctor() { }

	// RVA: 0xD1AF48
	bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> right) { }

	// RVA: 0xD1B0C4
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1B178
	void .ctor() { }

	// RVA: 0xD1B180
	bool Equals(TypeLibImporterFlags left, TypeLibImporterFlags right) { }

	// RVA: 0xD1B208
	int GetHashCode(TypeLibImporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1B230
	void .ctor() { }

	// RVA: 0xD1B238
	bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> right) { }

	// RVA: 0xD1B3B4
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1B468
	void .ctor() { }

	// RVA: 0xD1B470
	bool Equals(TypeLibTypeFlags left, TypeLibTypeFlags right) { }

	// RVA: 0xD1B4F8
	int GetHashCode(TypeLibTypeFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1B520
	void .ctor() { }

	// RVA: 0xD1B528
	bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> right) { }

	// RVA: 0xD1B6A4
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1B758
	void .ctor() { }

	// RVA: 0xD1B760
	bool Equals(TypeLibVarFlags left, TypeLibVarFlags right) { }

	// RVA: 0xD1B7E8
	int GetHashCode(TypeLibVarFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1B810
	void .ctor() { }

	// RVA: 0xD1B818
	bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> right) { }

	// RVA: 0xD1B994
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_UnmanagedTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD1BA48
	void .ctor() { }

	// RVA: 0xD1BA50
	bool Equals(UnmanagedType left, UnmanagedType right) { }

	// RVA: 0xD1BAD8
	int GetHashCode(UnmanagedType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_UnmanagedTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD1BB00
	void .ctor() { }

	// RVA: 0xD1BB08
	bool Equals(System.Nullable<System.Runtime.InteropServices.UnmanagedType> left, System.Nullable<System.Runtime.InteropServices.UnmanagedType> right) { }

	// RVA: 0xD1BC84
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.UnmanagedType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_VarEnumEqualityComparer 
{
	// Methods

	// RVA: 0xD1BD38
	void .ctor() { }

	// RVA: 0xD1BD40
	bool Equals(VarEnum left, VarEnum right) { }

	// RVA: 0xD1BDC8
	int GetHashCode(VarEnum obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_VarEnumEqualityComparer 
{
	// Methods

	// RVA: 0xD1BDF0
	void .ctor() { }

	// RVA: 0xD1BDF8
	bool Equals(System.Nullable<System.Runtime.InteropServices.VarEnum> left, System.Nullable<System.Runtime.InteropServices.VarEnum> right) { }

	// RVA: 0xD1BF74
	int GetHashCode(System.Nullable<System.Runtime.InteropServices.VarEnum> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_CustomErrorsModesEqualityComparer 
{
	// Methods

	// RVA: 0xD1C028
	void .ctor() { }

	// RVA: 0xD1C030
	bool Equals(CustomErrorsModes left, CustomErrorsModes right) { }

	// RVA: 0xD1C0B8
	int GetHashCode(CustomErrorsModes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_CustomErrorsModesEqualityComparer 
{
	// Methods

	// RVA: 0xD1C0E0
	void .ctor() { }

	// RVA: 0xD1C0E8
	bool Equals(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> left, System.Nullable<System.Runtime.Remoting.CustomErrorsModes> right) { }

	// RVA: 0xD1C264
	int GetHashCode(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_WellKnownObjectModeEqualityComparer 
{
	// Methods

	// RVA: 0xD1C318
	void .ctor() { }

	// RVA: 0xD1C320
	bool Equals(WellKnownObjectMode left, WellKnownObjectMode right) { }

	// RVA: 0xD1C3A8
	int GetHashCode(WellKnownObjectMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_WellKnownObjectModeEqualityComparer 
{
	// Methods

	// RVA: 0xD1C3D0
	void .ctor() { }

	// RVA: 0xD1C3D8
	bool Equals(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> left, System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> right) { }

	// RVA: 0xD1C554
	int GetHashCode(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer 
{
	// Methods

	// RVA: 0xD1C608
	void .ctor() { }

	// RVA: 0xD1C610
	bool Equals(ActivatorLevel left, ActivatorLevel right) { }

	// RVA: 0xD1C698
	int GetHashCode(ActivatorLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer 
{
	// Methods

	// RVA: 0xD1C6C0
	void .ctor() { }

	// RVA: 0xD1C6C8
	bool Equals(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> left, System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> right) { }

	// RVA: 0xD1C844
	int GetHashCode(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Channels_ServerProcessingEqualityComparer 
{
	// Methods

	// RVA: 0xD1C8F8
	void .ctor() { }

	// RVA: 0xD1C900
	bool Equals(ServerProcessing left, ServerProcessing right) { }

	// RVA: 0xD1C988
	int GetHashCode(ServerProcessing obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Channels_ServerProcessingEqualityComparer 
{
	// Methods

	// RVA: 0xD1C9B0
	void .ctor() { }

	// RVA: 0xD1C9B8
	bool Equals(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> left, System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> right) { }

	// RVA: 0xD1CB34
	int GetHashCode(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer 
{
	// Methods

	// RVA: 0xD1CBE8
	void .ctor() { }

	// RVA: 0xD1CBF0
	bool Equals(LeaseState left, LeaseState right) { }

	// RVA: 0xD1CC78
	int GetHashCode(LeaseState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer 
{
	// Methods

	// RVA: 0xD1CCA0
	void .ctor() { }

	// RVA: 0xD1CCA8
	bool Equals(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> left, System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> right) { }

	// RVA: 0xD1CE24
	int GetHashCode(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_SoapOptionEqualityComparer 
{
	// Methods

	// RVA: 0xD1CED8
	void .ctor() { }

	// RVA: 0xD1CEE0
	bool Equals(SoapOption left, SoapOption right) { }

	// RVA: 0xD1CF68
	int GetHashCode(SoapOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_SoapOptionEqualityComparer 
{
	// Methods

	// RVA: 0xD1CF90
	void .ctor() { }

	// RVA: 0xD1CF98
	bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> left, System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> right) { }

	// RVA: 0xD1D114
	int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer 
{
	// Methods

	// RVA: 0xD1D1C8
	void .ctor() { }

	// RVA: 0xD1D1D0
	bool Equals(XmlFieldOrderOption left, XmlFieldOrderOption right) { }

	// RVA: 0xD1D258
	int GetHashCode(XmlFieldOrderOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer 
{
	// Methods

	// RVA: 0xD1D280
	void .ctor() { }

	// RVA: 0xD1D288
	bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> left, System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> right) { }

	// RVA: 0xD1D404
	int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_SerializationEntryEqualityComparer 
{
	// Methods

	// RVA: 0xD1D4B8
	void .ctor() { }

	// RVA: 0xD1D4C0
	bool Equals(SerializationEntry left, SerializationEntry right) { }

	// RVA: 0xD1D560
	int GetHashCode(SerializationEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_SerializationEntryEqualityComparer 
{
	// Methods

	// RVA: 0xD1D5DC
	void .ctor() { }

	// RVA: 0xD1D5E4
	bool Equals(System.Nullable<System.Runtime.Serialization.SerializationEntry> left, System.Nullable<System.Runtime.Serialization.SerializationEntry> right) { }

	// RVA: 0xD1D798
	int GetHashCode(System.Nullable<System.Runtime.Serialization.SerializationEntry> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextEqualityComparer 
{
	// Methods

	// RVA: 0xD1D848
	void .ctor() { }

	// RVA: 0xD1D850
	bool Equals(StreamingContext left, StreamingContext right) { }

	// RVA: 0xD1D8CC
	int GetHashCode(StreamingContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextEqualityComparer 
{
	// Methods

	// RVA: 0xD1D8D4
	void .ctor() { }

	// RVA: 0xD1D8DC
	bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContext> left, System.Nullable<System.Runtime.Serialization.StreamingContext> right) { }

	// RVA: 0xD1DA64
	int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextStatesEqualityComparer 
{
	// Methods

	// RVA: 0xD1DB14
	void .ctor() { }

	// RVA: 0xD1DB1C
	bool Equals(StreamingContextStates left, StreamingContextStates right) { }

	// RVA: 0xD1DBA4
	int GetHashCode(StreamingContextStates obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextStatesEqualityComparer 
{
	// Methods

	// RVA: 0xD1DBCC
	void .ctor() { }

	// RVA: 0xD1DBD4
	bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContextStates> left, System.Nullable<System.Runtime.Serialization.StreamingContextStates> right) { }

	// RVA: 0xD1DD50
	int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContextStates> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer 
{
	// Methods

	// RVA: 0xD1DE04
	void .ctor() { }

	// RVA: 0xD1DE0C
	bool Equals(FormatterAssemblyStyle left, FormatterAssemblyStyle right) { }

	// RVA: 0xD1DE94
	int GetHashCode(FormatterAssemblyStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer 
{
	// Methods

	// RVA: 0xD1DEBC
	void .ctor() { }

	// RVA: 0xD1DEC4
	bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> right) { }

	// RVA: 0xD1E040
	int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer 
{
	// Methods

	// RVA: 0xD1E0F4
	void .ctor() { }

	// RVA: 0xD1E0FC
	bool Equals(FormatterTypeStyle left, FormatterTypeStyle right) { }

	// RVA: 0xD1E184
	int GetHashCode(FormatterTypeStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer 
{
	// Methods

	// RVA: 0xD1E1AC
	void .ctor() { }

	// RVA: 0xD1E1B4
	bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> right) { }

	// RVA: 0xD1E330
	int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer 
{
	// Methods

	// RVA: 0xD1E3E4
	void .ctor() { }

	// RVA: 0xD1E3EC
	bool Equals(TypeFilterLevel left, TypeFilterLevel right) { }

	// RVA: 0xD1E474
	int GetHashCode(TypeFilterLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer 
{
	// Methods

	// RVA: 0xD1E49C
	void .ctor() { }

	// RVA: 0xD1E4A4
	bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> left, System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> right) { }

	// RVA: 0xD1E620
	int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Versioning_ResourceScopeEqualityComparer 
{
	// Methods

	// RVA: 0xD1E6D4
	void .ctor() { }

	// RVA: 0xD1E6DC
	bool Equals(ResourceScope left, ResourceScope right) { }

	// RVA: 0xD1E764
	int GetHashCode(ResourceScope obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Versioning_ResourceScopeEqualityComparer 
{
	// Methods

	// RVA: 0xD1E78C
	void .ctor() { }

	// RVA: 0xD1E794
	bool Equals(System.Nullable<System.Runtime.Versioning.ResourceScope> left, System.Nullable<System.Runtime.Versioning.ResourceScope> right) { }

	// RVA: 0xD1E910
	int GetHashCode(System.Nullable<System.Runtime.Versioning.ResourceScope> obj) { }

}

// Namespace: 
private sealed class System_Security_HostSecurityManagerOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD1E9C4
	void .ctor() { }

	// RVA: 0xD1E9CC
	bool Equals(HostSecurityManagerOptions left, HostSecurityManagerOptions right) { }

	// RVA: 0xD1EA54
	int GetHashCode(HostSecurityManagerOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_HostSecurityManagerOptionsEqualityComparer 
{
	// Methods

	// RVA: 0xD1EA7C
	void .ctor() { }

	// RVA: 0xD1EA84
	bool Equals(System.Nullable<System.Security.HostSecurityManagerOptions> left, System.Nullable<System.Security.HostSecurityManagerOptions> right) { }

	// RVA: 0xD1EC00
	int GetHashCode(System.Nullable<System.Security.HostSecurityManagerOptions> obj) { }

}

// Namespace: 
private sealed class System_Security_PolicyLevelTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD1ECB4
	void .ctor() { }

	// RVA: 0xD1ECBC
	bool Equals(PolicyLevelType left, PolicyLevelType right) { }

	// RVA: 0xD1ED44
	int GetHashCode(PolicyLevelType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_PolicyLevelTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD1ED6C
	void .ctor() { }

	// RVA: 0xD1ED74
	bool Equals(System.Nullable<System.Security.PolicyLevelType> left, System.Nullable<System.Security.PolicyLevelType> right) { }

	// RVA: 0xD1EEF0
	int GetHashCode(System.Nullable<System.Security.PolicyLevelType> obj) { }

}

// Namespace: 
private sealed class System_Security_SecurityZoneEqualityComparer 
{
	// Methods

	// RVA: 0xD1EFA4
	void .ctor() { }

	// RVA: 0xD1EFAC
	bool Equals(SecurityZone left, SecurityZone right) { }

	// RVA: 0xD1F034
	int GetHashCode(SecurityZone obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_SecurityZoneEqualityComparer 
{
	// Methods

	// RVA: 0xD1F05C
	void .ctor() { }

	// RVA: 0xD1F064
	bool Equals(System.Nullable<System.Security.SecurityZone> left, System.Nullable<System.Security.SecurityZone> right) { }

	// RVA: 0xD1F1E0
	int GetHashCode(System.Nullable<System.Security.SecurityZone> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlActionsEqualityComparer 
{
	// Methods

	// RVA: 0xD1F294
	void .ctor() { }

	// RVA: 0xD1F29C
	bool Equals(AccessControlActions left, AccessControlActions right) { }

	// RVA: 0xD1F324
	int GetHashCode(AccessControlActions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlActionsEqualityComparer 
{
	// Methods

	// RVA: 0xD1F34C
	void .ctor() { }

	// RVA: 0xD1F354
	bool Equals(System.Nullable<System.Security.AccessControl.AccessControlActions> left, System.Nullable<System.Security.AccessControl.AccessControlActions> right) { }

	// RVA: 0xD1F4D0
	int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlActions> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlModificationEqualityComparer 
{
	// Methods

	// RVA: 0xD1F584
	void .ctor() { }

	// RVA: 0xD1F58C
	bool Equals(AccessControlModification left, AccessControlModification right) { }

	// RVA: 0xD1F614
	int GetHashCode(AccessControlModification obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlModificationEqualityComparer 
{
	// Methods

	// RVA: 0xD1F63C
	void .ctor() { }

	// RVA: 0xD1F644
	bool Equals(System.Nullable<System.Security.AccessControl.AccessControlModification> left, System.Nullable<System.Security.AccessControl.AccessControlModification> right) { }

	// RVA: 0xD1F7C0
	int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlModification> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlSectionsEqualityComparer 
{
	// Methods

	// RVA: 0xD1F874
	void .ctor() { }

	// RVA: 0xD1F87C
	bool Equals(AccessControlSections left, AccessControlSections right) { }

	// RVA: 0xD1F904
	int GetHashCode(AccessControlSections obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlSectionsEqualityComparer 
{
	// Methods

	// RVA: 0xD1F92C
	void .ctor() { }

	// RVA: 0xD1F934
	bool Equals(System.Nullable<System.Security.AccessControl.AccessControlSections> left, System.Nullable<System.Security.AccessControl.AccessControlSections> right) { }

	// RVA: 0xD1FAB0
	int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlSections> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD1FB64
	void .ctor() { }

	// RVA: 0xD1FB6C
	bool Equals(AccessControlType left, AccessControlType right) { }

	// RVA: 0xD1FBF4
	int GetHashCode(AccessControlType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD1FC1C
	void .ctor() { }

	// RVA: 0xD1FC24
	bool Equals(System.Nullable<System.Security.AccessControl.AccessControlType> left, System.Nullable<System.Security.AccessControl.AccessControlType> right) { }

	// RVA: 0xD1FDA0
	int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1FE54
	void .ctor() { }

	// RVA: 0xD1FE5C
	bool Equals(AceFlags left, AceFlags right) { }

	// RVA: 0xD1FEE4
	int GetHashCode(AceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD1FF0C
	void .ctor() { }

	// RVA: 0xD1FF14
	bool Equals(System.Nullable<System.Security.AccessControl.AceFlags> left, System.Nullable<System.Security.AccessControl.AceFlags> right) { }

	// RVA: 0xD20090
	int GetHashCode(System.Nullable<System.Security.AccessControl.AceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceQualifierEqualityComparer 
{
	// Methods

	// RVA: 0xD20144
	void .ctor() { }

	// RVA: 0xD2014C
	bool Equals(AceQualifier left, AceQualifier right) { }

	// RVA: 0xD201D4
	int GetHashCode(AceQualifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceQualifierEqualityComparer 
{
	// Methods

	// RVA: 0xD201FC
	void .ctor() { }

	// RVA: 0xD20204
	bool Equals(System.Nullable<System.Security.AccessControl.AceQualifier> left, System.Nullable<System.Security.AccessControl.AceQualifier> right) { }

	// RVA: 0xD20380
	int GetHashCode(System.Nullable<System.Security.AccessControl.AceQualifier> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD20434
	void .ctor() { }

	// RVA: 0xD2043C
	bool Equals(AceType left, AceType right) { }

	// RVA: 0xD204C4
	int GetHashCode(AceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD204EC
	void .ctor() { }

	// RVA: 0xD204F4
	bool Equals(System.Nullable<System.Security.AccessControl.AceType> left, System.Nullable<System.Security.AccessControl.AceType> right) { }

	// RVA: 0xD20670
	int GetHashCode(System.Nullable<System.Security.AccessControl.AceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AuditFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD20724
	void .ctor() { }

	// RVA: 0xD2072C
	bool Equals(AuditFlags left, AuditFlags right) { }

	// RVA: 0xD207B4
	int GetHashCode(AuditFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AuditFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD207DC
	void .ctor() { }

	// RVA: 0xD207E4
	bool Equals(System.Nullable<System.Security.AccessControl.AuditFlags> left, System.Nullable<System.Security.AccessControl.AuditFlags> right) { }

	// RVA: 0xD20960
	int GetHashCode(System.Nullable<System.Security.AccessControl.AuditFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CompoundAceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD20A14
	void .ctor() { }

	// RVA: 0xD20A1C
	bool Equals(CompoundAceType left, CompoundAceType right) { }

	// RVA: 0xD20AA4
	int GetHashCode(CompoundAceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CompoundAceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD20ACC
	void .ctor() { }

	// RVA: 0xD20AD4
	bool Equals(System.Nullable<System.Security.AccessControl.CompoundAceType> left, System.Nullable<System.Security.AccessControl.CompoundAceType> right) { }

	// RVA: 0xD20C50
	int GetHashCode(System.Nullable<System.Security.AccessControl.CompoundAceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ControlFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD20D04
	void .ctor() { }

	// RVA: 0xD20D0C
	bool Equals(ControlFlags left, ControlFlags right) { }

	// RVA: 0xD20D94
	int GetHashCode(ControlFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ControlFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD20DBC
	void .ctor() { }

	// RVA: 0xD20DC4
	bool Equals(System.Nullable<System.Security.AccessControl.ControlFlags> left, System.Nullable<System.Security.AccessControl.ControlFlags> right) { }

	// RVA: 0xD20F40
	int GetHashCode(System.Nullable<System.Security.AccessControl.ControlFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CryptoKeyRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD20FF4
	void .ctor() { }

	// RVA: 0xD20FFC
	bool Equals(CryptoKeyRights left, CryptoKeyRights right) { }

	// RVA: 0xD21084
	int GetHashCode(CryptoKeyRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CryptoKeyRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD210AC
	void .ctor() { }

	// RVA: 0xD210B4
	bool Equals(System.Nullable<System.Security.AccessControl.CryptoKeyRights> left, System.Nullable<System.Security.AccessControl.CryptoKeyRights> right) { }

	// RVA: 0xD21230
	int GetHashCode(System.Nullable<System.Security.AccessControl.CryptoKeyRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_EventWaitHandleRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD212E4
	void .ctor() { }

	// RVA: 0xD212EC
	bool Equals(EventWaitHandleRights left, EventWaitHandleRights right) { }

	// RVA: 0xD21374
	int GetHashCode(EventWaitHandleRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_EventWaitHandleRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD2139C
	void .ctor() { }

	// RVA: 0xD213A4
	bool Equals(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> left, System.Nullable<System.Security.AccessControl.EventWaitHandleRights> right) { }

	// RVA: 0xD21520
	int GetHashCode(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_FileSystemRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD215D4
	void .ctor() { }

	// RVA: 0xD215DC
	bool Equals(FileSystemRights left, FileSystemRights right) { }

	// RVA: 0xD21664
	int GetHashCode(FileSystemRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_FileSystemRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD2168C
	void .ctor() { }

	// RVA: 0xD21694
	bool Equals(System.Nullable<System.Security.AccessControl.FileSystemRights> left, System.Nullable<System.Security.AccessControl.FileSystemRights> right) { }

	// RVA: 0xD21810
	int GetHashCode(System.Nullable<System.Security.AccessControl.FileSystemRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_InheritanceFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD218C4
	void .ctor() { }

	// RVA: 0xD218CC
	bool Equals(InheritanceFlags left, InheritanceFlags right) { }

	// RVA: 0xD21954
	int GetHashCode(InheritanceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_InheritanceFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD2197C
	void .ctor() { }

	// RVA: 0xD21984
	bool Equals(System.Nullable<System.Security.AccessControl.InheritanceFlags> left, System.Nullable<System.Security.AccessControl.InheritanceFlags> right) { }

	// RVA: 0xD21B00
	int GetHashCode(System.Nullable<System.Security.AccessControl.InheritanceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_MutexRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD21BB4
	void .ctor() { }

	// RVA: 0xD21BBC
	bool Equals(MutexRights left, MutexRights right) { }

	// RVA: 0xD21C44
	int GetHashCode(MutexRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_MutexRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD21C6C
	void .ctor() { }

	// RVA: 0xD21C74
	bool Equals(System.Nullable<System.Security.AccessControl.MutexRights> left, System.Nullable<System.Security.AccessControl.MutexRights> right) { }

	// RVA: 0xD21DF0
	int GetHashCode(System.Nullable<System.Security.AccessControl.MutexRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ObjectAceFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD21EA4
	void .ctor() { }

	// RVA: 0xD21EAC
	bool Equals(ObjectAceFlags left, ObjectAceFlags right) { }

	// RVA: 0xD21F34
	int GetHashCode(ObjectAceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ObjectAceFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD21F5C
	void .ctor() { }

	// RVA: 0xD21F64
	bool Equals(System.Nullable<System.Security.AccessControl.ObjectAceFlags> left, System.Nullable<System.Security.AccessControl.ObjectAceFlags> right) { }

	// RVA: 0xD220E0
	int GetHashCode(System.Nullable<System.Security.AccessControl.ObjectAceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_PropagationFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD22194
	void .ctor() { }

	// RVA: 0xD2219C
	bool Equals(PropagationFlags left, PropagationFlags right) { }

	// RVA: 0xD22224
	int GetHashCode(PropagationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_PropagationFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD2224C
	void .ctor() { }

	// RVA: 0xD22254
	bool Equals(System.Nullable<System.Security.AccessControl.PropagationFlags> left, System.Nullable<System.Security.AccessControl.PropagationFlags> right) { }

	// RVA: 0xD223D0
	int GetHashCode(System.Nullable<System.Security.AccessControl.PropagationFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_RegistryRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD22484
	void .ctor() { }

	// RVA: 0xD2248C
	bool Equals(RegistryRights left, RegistryRights right) { }

	// RVA: 0xD22514
	int GetHashCode(RegistryRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_RegistryRightsEqualityComparer 
{
	// Methods

	// RVA: 0xD2253C
	void .ctor() { }

	// RVA: 0xD22544
	bool Equals(System.Nullable<System.Security.AccessControl.RegistryRights> left, System.Nullable<System.Security.AccessControl.RegistryRights> right) { }

	// RVA: 0xD226C0
	int GetHashCode(System.Nullable<System.Security.AccessControl.RegistryRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ResourceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD22774
	void .ctor() { }

	// RVA: 0xD2277C
	bool Equals(ResourceType left, ResourceType right) { }

	// RVA: 0xD22804
	int GetHashCode(ResourceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ResourceTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD2282C
	void .ctor() { }

	// RVA: 0xD22834
	bool Equals(System.Nullable<System.Security.AccessControl.ResourceType> left, System.Nullable<System.Security.AccessControl.ResourceType> right) { }

	// RVA: 0xD229B0
	int GetHashCode(System.Nullable<System.Security.AccessControl.ResourceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_SecurityInfosEqualityComparer 
{
	// Methods

	// RVA: 0xD22A64
	void .ctor() { }

	// RVA: 0xD22A6C
	bool Equals(SecurityInfos left, SecurityInfos right) { }

	// RVA: 0xD22AF4
	int GetHashCode(SecurityInfos obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_SecurityInfosEqualityComparer 
{
	// Methods

	// RVA: 0xD22B1C
	void .ctor() { }

	// RVA: 0xD22B24
	bool Equals(System.Nullable<System.Security.AccessControl.SecurityInfos> left, System.Nullable<System.Security.AccessControl.SecurityInfos> right) { }

	// RVA: 0xD22CA0
	int GetHashCode(System.Nullable<System.Security.AccessControl.SecurityInfos> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CipherModeEqualityComparer 
{
	// Methods

	// RVA: 0xD22D54
	void .ctor() { }

	// RVA: 0xD22D5C
	bool Equals(CipherMode left, CipherMode right) { }

	// RVA: 0xD22DE4
	int GetHashCode(CipherMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CipherModeEqualityComparer 
{
	// Methods

	// RVA: 0xD22E0C
	void .ctor() { }

	// RVA: 0xD22E14
	bool Equals(System.Nullable<System.Security.Cryptography.CipherMode> left, System.Nullable<System.Security.Cryptography.CipherMode> right) { }

	// RVA: 0xD22F90
	int GetHashCode(System.Nullable<System.Security.Cryptography.CipherMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CryptoStreamModeEqualityComparer 
{
	// Methods

	// RVA: 0xD23044
	void .ctor() { }

	// RVA: 0xD2304C
	bool Equals(CryptoStreamMode left, CryptoStreamMode right) { }

	// RVA: 0xD230D4
	int GetHashCode(CryptoStreamMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CryptoStreamModeEqualityComparer 
{
	// Methods

	// RVA: 0xD230FC
	void .ctor() { }

	// RVA: 0xD23104
	bool Equals(System.Nullable<System.Security.Cryptography.CryptoStreamMode> left, System.Nullable<System.Security.Cryptography.CryptoStreamMode> right) { }

	// RVA: 0xD23280
	int GetHashCode(System.Nullable<System.Security.Cryptography.CryptoStreamMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CspProviderFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD23334
	void .ctor() { }

	// RVA: 0xD2333C
	bool Equals(CspProviderFlags left, CspProviderFlags right) { }

	// RVA: 0xD233C4
	int GetHashCode(CspProviderFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CspProviderFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD233EC
	void .ctor() { }

	// RVA: 0xD233F4
	bool Equals(System.Nullable<System.Security.Cryptography.CspProviderFlags> left, System.Nullable<System.Security.Cryptography.CspProviderFlags> right) { }

	// RVA: 0xD23570
	int GetHashCode(System.Nullable<System.Security.Cryptography.CspProviderFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_DSAParametersEqualityComparer 
{
	// Methods

	// RVA: 0xD23624
	void .ctor() { }

	// RVA: 0xD2362C
	bool Equals(DSAParameters left, DSAParameters right) { }

	// RVA: 0xD236CC
	int GetHashCode(DSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_DSAParametersEqualityComparer 
{
	// Methods

	// RVA: 0xD23748
	void .ctor() { }

	// RVA: 0xD23750
	bool Equals(System.Nullable<System.Security.Cryptography.DSAParameters> left, System.Nullable<System.Security.Cryptography.DSAParameters> right) { }

	// RVA: 0xD23914
	int GetHashCode(System.Nullable<System.Security.Cryptography.DSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_FromBase64TransformModeEqualityComparer 
{
	// Methods

	// RVA: 0xD239C4
	void .ctor() { }

	// RVA: 0xD239CC
	bool Equals(FromBase64TransformMode left, FromBase64TransformMode right) { }

	// RVA: 0xD23A54
	int GetHashCode(FromBase64TransformMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_FromBase64TransformModeEqualityComparer 
{
	// Methods

	// RVA: 0xD23A7C
	void .ctor() { }

	// RVA: 0xD23A84
	bool Equals(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> left, System.Nullable<System.Security.Cryptography.FromBase64TransformMode> right) { }

	// RVA: 0xD23C00
	int GetHashCode(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_KeyNumberEqualityComparer 
{
	// Methods

	// RVA: 0xD23CB4
	void .ctor() { }

	// RVA: 0xD23CBC
	bool Equals(KeyNumber left, KeyNumber right) { }

	// RVA: 0xD23D44
	int GetHashCode(KeyNumber obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_KeyNumberEqualityComparer 
{
	// Methods

	// RVA: 0xD23D6C
	void .ctor() { }

	// RVA: 0xD23D74
	bool Equals(System.Nullable<System.Security.Cryptography.KeyNumber> left, System.Nullable<System.Security.Cryptography.KeyNumber> right) { }

	// RVA: 0xD23EF0
	int GetHashCode(System.Nullable<System.Security.Cryptography.KeyNumber> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_PaddingModeEqualityComparer 
{
	// Methods

	// RVA: 0xD23FA4
	void .ctor() { }

	// RVA: 0xD23FAC
	bool Equals(PaddingMode left, PaddingMode right) { }

	// RVA: 0xD24034
	int GetHashCode(PaddingMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_PaddingModeEqualityComparer 
{
	// Methods

	// RVA: 0xD2405C
	void .ctor() { }

	// RVA: 0xD24064
	bool Equals(System.Nullable<System.Security.Cryptography.PaddingMode> left, System.Nullable<System.Security.Cryptography.PaddingMode> right) { }

	// RVA: 0xD241E0
	int GetHashCode(System.Nullable<System.Security.Cryptography.PaddingMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_RSAParametersEqualityComparer 
{
	// Methods

	// RVA: 0xD24294
	void .ctor() { }

	// RVA: 0xD2429C
	bool Equals(RSAParameters left, RSAParameters right) { }

	// RVA: 0xD2433C
	int GetHashCode(RSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_RSAParametersEqualityComparer 
{
	// Methods

	// RVA: 0xD243B8
	void .ctor() { }

	// RVA: 0xD243C0
	bool Equals(System.Nullable<System.Security.Cryptography.RSAParameters> left, System.Nullable<System.Security.Cryptography.RSAParameters> right) { }

	// RVA: 0xD24584
	int GetHashCode(System.Nullable<System.Security.Cryptography.RSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD24634
	void .ctor() { }

	// RVA: 0xD2463C
	bool Equals(X509ContentType left, X509ContentType right) { }

	// RVA: 0xD246C4
	int GetHashCode(X509ContentType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD246EC
	void .ctor() { }

	// RVA: 0xD246F4
	bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> right) { }

	// RVA: 0xD24870
	int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD24924
	void .ctor() { }

	// RVA: 0xD2492C
	bool Equals(X509KeyStorageFlags left, X509KeyStorageFlags right) { }

	// RVA: 0xD249B4
	int GetHashCode(X509KeyStorageFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer 
{
	// Methods

	// RVA: 0xD249DC
	void .ctor() { }

	// RVA: 0xD249E4
	bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> right) { }

	// RVA: 0xD24B60
	int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_ApplicationVersionMatchEqualityComparer 
{
	// Methods

	// RVA: 0xD24C14
	void .ctor() { }

	// RVA: 0xD24C1C
	bool Equals(ApplicationVersionMatch left, ApplicationVersionMatch right) { }

	// RVA: 0xD24CA4
	int GetHashCode(ApplicationVersionMatch obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_ApplicationVersionMatchEqualityComparer 
{
	// Methods

	// RVA: 0xD24CCC
	void .ctor() { }

	// RVA: 0xD24CD4
	bool Equals(System.Nullable<System.Security.Policy.ApplicationVersionMatch> left, System.Nullable<System.Security.Policy.ApplicationVersionMatch> right) { }

	// RVA: 0xD24E50
	int GetHashCode(System.Nullable<System.Security.Policy.ApplicationVersionMatch> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_PolicyStatementAttributeEqualityComparer 
{
	// Methods

	// RVA: 0xD24F04
	void .ctor() { }

	// RVA: 0xD24F0C
	bool Equals(PolicyStatementAttribute left, PolicyStatementAttribute right) { }

	// RVA: 0xD24F94
	int GetHashCode(PolicyStatementAttribute obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_PolicyStatementAttributeEqualityComparer 
{
	// Methods

	// RVA: 0xD24FBC
	void .ctor() { }

	// RVA: 0xD24FC4
	bool Equals(System.Nullable<System.Security.Policy.PolicyStatementAttribute> left, System.Nullable<System.Security.Policy.PolicyStatementAttribute> right) { }

	// RVA: 0xD25140
	int GetHashCode(System.Nullable<System.Security.Policy.PolicyStatementAttribute> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_TrustManagerUIContextEqualityComparer 
{
	// Methods

	// RVA: 0xD251F4
	void .ctor() { }

	// RVA: 0xD251FC
	bool Equals(TrustManagerUIContext left, TrustManagerUIContext right) { }

	// RVA: 0xD25284
	int GetHashCode(TrustManagerUIContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_TrustManagerUIContextEqualityComparer 
{
	// Methods

	// RVA: 0xD252AC
	void .ctor() { }

	// RVA: 0xD252B4
	bool Equals(System.Nullable<System.Security.Policy.TrustManagerUIContext> left, System.Nullable<System.Security.Policy.TrustManagerUIContext> right) { }

	// RVA: 0xD25430
	int GetHashCode(System.Nullable<System.Security.Policy.TrustManagerUIContext> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_PrincipalPolicyEqualityComparer 
{
	// Methods

	// RVA: 0xD254E4
	void .ctor() { }

	// RVA: 0xD254EC
	bool Equals(PrincipalPolicy left, PrincipalPolicy right) { }

	// RVA: 0xD25574
	int GetHashCode(PrincipalPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_PrincipalPolicyEqualityComparer 
{
	// Methods

	// RVA: 0xD2559C
	void .ctor() { }

	// RVA: 0xD255A4
	bool Equals(System.Nullable<System.Security.Principal.PrincipalPolicy> left, System.Nullable<System.Security.Principal.PrincipalPolicy> right) { }

	// RVA: 0xD25720
	int GetHashCode(System.Nullable<System.Security.Principal.PrincipalPolicy> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenAccessLevelsEqualityComparer 
{
	// Methods

	// RVA: 0xD257D4
	void .ctor() { }

	// RVA: 0xD257DC
	bool Equals(TokenAccessLevels left, TokenAccessLevels right) { }

	// RVA: 0xD25864
	int GetHashCode(TokenAccessLevels obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenAccessLevelsEqualityComparer 
{
	// Methods

	// RVA: 0xD2588C
	void .ctor() { }

	// RVA: 0xD25894
	bool Equals(System.Nullable<System.Security.Principal.TokenAccessLevels> left, System.Nullable<System.Security.Principal.TokenAccessLevels> right) { }

	// RVA: 0xD25A10
	int GetHashCode(System.Nullable<System.Security.Principal.TokenAccessLevels> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenImpersonationLevelEqualityComparer 
{
	// Methods

	// RVA: 0xD25AC4
	void .ctor() { }

	// RVA: 0xD25ACC
	bool Equals(TokenImpersonationLevel left, TokenImpersonationLevel right) { }

	// RVA: 0xD25B54
	int GetHashCode(TokenImpersonationLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenImpersonationLevelEqualityComparer 
{
	// Methods

	// RVA: 0xD25B7C
	void .ctor() { }

	// RVA: 0xD25B84
	bool Equals(System.Nullable<System.Security.Principal.TokenImpersonationLevel> left, System.Nullable<System.Security.Principal.TokenImpersonationLevel> right) { }

	// RVA: 0xD25D00
	int GetHashCode(System.Nullable<System.Security.Principal.TokenImpersonationLevel> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WellKnownSidTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD25DB4
	void .ctor() { }

	// RVA: 0xD25DBC
	bool Equals(WellKnownSidType left, WellKnownSidType right) { }

	// RVA: 0xD25E44
	int GetHashCode(WellKnownSidType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WellKnownSidTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD25E6C
	void .ctor() { }

	// RVA: 0xD25E74
	bool Equals(System.Nullable<System.Security.Principal.WellKnownSidType> left, System.Nullable<System.Security.Principal.WellKnownSidType> right) { }

	// RVA: 0xD25FF0
	int GetHashCode(System.Nullable<System.Security.Principal.WellKnownSidType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsAccountTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD260A4
	void .ctor() { }

	// RVA: 0xD260AC
	bool Equals(WindowsAccountType left, WindowsAccountType right) { }

	// RVA: 0xD26134
	int GetHashCode(WindowsAccountType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsAccountTypeEqualityComparer 
{
	// Methods

	// RVA: 0xD2615C
	void .ctor() { }

	// RVA: 0xD26164
	bool Equals(System.Nullable<System.Security.Principal.WindowsAccountType> left, System.Nullable<System.Security.Principal.WindowsAccountType> right) { }

	// RVA: 0xD262E0
	int GetHashCode(System.Nullable<System.Security.Principal.WindowsAccountType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsBuiltInRoleEqualityComparer 
{
	// Methods

	// RVA: 0xD26394
	void .ctor() { }

	// RVA: 0xD2639C
	bool Equals(WindowsBuiltInRole left, WindowsBuiltInRole right) { }

	// RVA: 0xD26424
	int GetHashCode(WindowsBuiltInRole obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsBuiltInRoleEqualityComparer 
{
	// Methods

	// RVA: 0xD2644C
	void .ctor() { }

	// RVA: 0xD26454
	bool Equals(System.Nullable<System.Security.Principal.WindowsBuiltInRole> left, System.Nullable<System.Security.Principal.WindowsBuiltInRole> right) { }

	// RVA: 0xD265D0
	int GetHashCode(System.Nullable<System.Security.Principal.WindowsBuiltInRole> obj) { }

}

// Namespace: 
private sealed class System_Text_NormalizationFormEqualityComparer 
{
	// Methods

	// RVA: 0xD26684
	void .ctor() { }

	// RVA: 0xD2668C
	bool Equals(NormalizationForm left, NormalizationForm right) { }

	// RVA: 0xD26714
	int GetHashCode(NormalizationForm obj) { }

}

// Namespace: 
private sealed class NullableSystem_Text_NormalizationFormEqualityComparer 
{
	// Methods

	// RVA: 0xD2673C
	void .ctor() { }

	// RVA: 0xD26744
	bool Equals(System.Nullable<System.Text.NormalizationForm> left, System.Nullable<System.Text.NormalizationForm> right) { }

	// RVA: 0xD268C0
	int GetHashCode(System.Nullable<System.Text.NormalizationForm> obj) { }

}

// Namespace: 
private sealed class System_Threading_ApartmentStateEqualityComparer 
{
	// Methods

	// RVA: 0xD26974
	void .ctor() { }

	// RVA: 0xD2697C
	bool Equals(ApartmentState left, ApartmentState right) { }

	// RVA: 0xD26A04
	int GetHashCode(ApartmentState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ApartmentStateEqualityComparer 
{
	// Methods

	// RVA: 0xD26A2C
	void .ctor() { }

	// RVA: 0xD26A34
	bool Equals(System.Nullable<System.Threading.ApartmentState> left, System.Nullable<System.Threading.ApartmentState> right) { }

	// RVA: 0xD26BB0
	int GetHashCode(System.Nullable<System.Threading.ApartmentState> obj) { }

}

// Namespace: 
private sealed class System_Threading_AsyncFlowControlEqualityComparer 
{
	// Methods

	// RVA: 0xD26C64
	void .ctor() { }

	// RVA: 0xD26C6C
	bool Equals(AsyncFlowControl left, AsyncFlowControl right) { }

	// RVA: 0xD26CA4
	int GetHashCode(AsyncFlowControl obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_AsyncFlowControlEqualityComparer 
{
	// Methods

	// RVA: 0xD26CB0
	void .ctor() { }

	// RVA: 0xD26CB8
	bool Equals(System.Nullable<System.Threading.AsyncFlowControl> left, System.Nullable<System.Threading.AsyncFlowControl> right) { }

	// RVA: 0xD26E30
	int GetHashCode(System.Nullable<System.Threading.AsyncFlowControl> obj) { }

}

// Namespace: 
private sealed class System_Threading_EventResetModeEqualityComparer 
{
	// Methods

	// RVA: 0xD26EE0
	void .ctor() { }

	// RVA: 0xD26EE8
	bool Equals(EventResetMode left, EventResetMode right) { }

	// RVA: 0xD26F70
	int GetHashCode(EventResetMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_EventResetModeEqualityComparer 
{
	// Methods

	// RVA: 0xD26F98
	void .ctor() { }

	// RVA: 0xD26FA0
	bool Equals(System.Nullable<System.Threading.EventResetMode> left, System.Nullable<System.Threading.EventResetMode> right) { }

	// RVA: 0xD2711C
	int GetHashCode(System.Nullable<System.Threading.EventResetMode> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockCookieEqualityComparer 
{
	// Methods

	// RVA: 0xD271D0
	void .ctor() { }

	// RVA: 0xD271D8
	bool Equals(LockCookie left, LockCookie right) { }

	// RVA: 0xD2720C
	int GetHashCode(LockCookie obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockCookieEqualityComparer 
{
	// Methods

	// RVA: 0xD27238
	void .ctor() { }

	// RVA: 0xD27240
	bool Equals(System.Nullable<System.Threading.LockCookie> left, System.Nullable<System.Threading.LockCookie> right) { }

	// RVA: 0xD2739C
	int GetHashCode(System.Nullable<System.Threading.LockCookie> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockRecursionPolicyEqualityComparer 
{
	// Methods

	// RVA: 0xD27450
	void .ctor() { }

	// RVA: 0xD27458
	bool Equals(LockRecursionPolicy left, LockRecursionPolicy right) { }

	// RVA: 0xD274E0
	int GetHashCode(LockRecursionPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockRecursionPolicyEqualityComparer 
{
	// Methods

	// RVA: 0xD27508
	void .ctor() { }

	// RVA: 0xD27510
	bool Equals(System.Nullable<System.Threading.LockRecursionPolicy> left, System.Nullable<System.Threading.LockRecursionPolicy> right) { }

	// RVA: 0xD2768C
	int GetHashCode(System.Nullable<System.Threading.LockRecursionPolicy> obj) { }

}

// Namespace: 
private sealed class System_Threading_NativeOverlappedEqualityComparer 
{
	// Methods

	// RVA: 0xD27740
	void .ctor() { }

	// RVA: 0xD27748
	bool Equals(NativeOverlapped left, NativeOverlapped right) { }

	// RVA: 0xD277D8
	int GetHashCode(NativeOverlapped obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_NativeOverlappedEqualityComparer 
{
	// Methods

	// RVA: 0xD2784C
	void .ctor() { }

	// RVA: 0xD27854
	bool Equals(System.Nullable<System.Threading.NativeOverlapped> left, System.Nullable<System.Threading.NativeOverlapped> right) { }

	// RVA: 0xD279F0
	int GetHashCode(System.Nullable<System.Threading.NativeOverlapped> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadPriorityEqualityComparer 
{
	// Methods

	// RVA: 0xD27AA0
	void .ctor() { }

	// RVA: 0xD27AA8
	bool Equals(ThreadPriority left, ThreadPriority right) { }

	// RVA: 0xD27B30
	int GetHashCode(ThreadPriority obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadPriorityEqualityComparer 
{
	// Methods

	// RVA: 0xD27B58
	void .ctor() { }

	// RVA: 0xD27B60
	bool Equals(System.Nullable<System.Threading.ThreadPriority> left, System.Nullable<System.Threading.ThreadPriority> right) { }

	// RVA: 0xD27CDC
	int GetHashCode(System.Nullable<System.Threading.ThreadPriority> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadStateEqualityComparer 
{
	// Methods

	// RVA: 0xD27D90
	void .ctor() { }

	// RVA: 0xD27D98
	bool Equals(ThreadState left, ThreadState right) { }

	// RVA: 0xD27E20
	int GetHashCode(ThreadState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadStateEqualityComparer 
{
	// Methods

	// RVA: 0xD27E48
	void .ctor() { }

	// RVA: 0xD27E50
	bool Equals(System.Nullable<System.Threading.ThreadState> left, System.Nullable<System.Threading.ThreadState> right) { }

	// RVA: 0xD27FCC
	int GetHashCode(System.Nullable<System.Threading.ThreadState> obj) { }

}

// Namespace: MsgPack.Serialization
internal static class AotHelper 
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> EqualityComparerTable; // 0x0

	// Methods

	// RVA: 0xCEDF1C
	void HandleAotError(Type mayBeGenericArgument, Exception mayBeAotError) { }

	// RVA: 0xCFB604
	object CreateSystemCollectionsGenericDictionary(ConstructorInfo constructor, Type keyType, int initialCapacity) { }

	// RVA: 0xCFB210
	object GetEqualityComparer(Type type) { }

	// RVA: 0x2FE8AB8
	void PrepareEqualityComparer() { }

	// RVA: 0xCFB790
	System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeEqualityComparerTable() { }

	// RVA: 0xD06908
	void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class EnumTypedMessagePackSerializerWrapper<T0> 
{
	// Fields
	private readonly ICustomizableEnumSerializer _underlyingEnumSerializer; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(SerializationContext context, MessagePackSerializer underlying) { }

	// RVA: -1
	ICustomizableEnumSerializer MsgPack.Serialization.ICustomizableEnumSerializer.GetCopyAs(EnumSerializationMethod method) { }

}

// Namespace: MsgPack.Serialization
internal abstract class NonGenericMessagePackSerializer 
{
	// Fields
	private readonly Type _targetType; // 0x28
	private readonly bool _isNullable; // 0x30

	// Methods

	// RVA: 0xD28080
	Type get_TargetType() { }

	// RVA: 0xD28088
	void .ctor(SerializationContext ownerContext, Type targetType, SerializerCapabilities capabilities) { }

	// RVA: 0xD2812C
	void .ctor(SerializationContext ownerContext, Type targetType, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xD281DC
	bool JudgeNullable(Type type) { }

	// RVA: 0xD283AC
	void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0x2FE47D4
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD28430
	object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x2FE36BC
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD28574
	void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xD28690
	void UnpackToCore(Unpacker unpacker, object collection) { }

}

// Namespace: MsgPack.Serialization
internal class TypedMessagePackSerializerWrapper<T0> 
{
	// Fields
	private readonly MessagePackSerializer _underlyingSerializer; // 0x0
	private readonly ICollectionInstanceFactory _underlyingFactory; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(SerializationContext context, MessagePackSerializer underlying) { }

	// RVA: 0x309AF8C
	void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x309AF8C
	T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x309AF8C
	T UnpackNil() { }

	// RVA: 0x309AF8C
	void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: -1
	object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD2896C
	void .ctor() { }

	// RVA: 0xD28C14
	object <.ctor>b__0(int _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionCollectionMessagePackSerializer 
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x50
	private readonly bool _isPackable; // 0x58
	private readonly bool _isUnpackable; // 0x59

	// Methods

	// RVA: 0xD286C8
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD28974
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD28A98
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD28BD0
	object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD28EE4
	void .ctor() { }

	// RVA: 0xD2918C
	object <.ctor>b__0(int _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionDictionaryMessagePackSerializer 
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x68
	private readonly bool _isPackable; // 0x70
	private readonly bool _isUnpackable; // 0x71

	// Methods

	// RVA: 0xD28C48
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD28EEC
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD29010
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD29148
	object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD294E8
	void .ctor() { }

	// RVA: 0xD2983C
	object <.ctor>b__0(int _) { }

	// RVA: 0xD29870
	void <.ctor>b__1(object c, object x) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionEnumerableMessagePackSerializer 
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x48
	private readonly System.Action<System.Object,System.Object> _addItem; // 0x50
	private readonly bool _isPackable; // 0x58
	private readonly bool _isUnpackable; // 0x59

	// Methods

	// RVA: 0xD291C0
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD294F0
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD29614
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD297D0
	object CreateInstance(int initialCapacity) { }

	// RVA: 0xD29814
	void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionEnumMessagePackSerializer 
{
	// Methods

	// RVA: 0xD298A4
	void .ctor(SerializationContext context, Type targetType) { }

	// RVA: 0xD298F8
	void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xD29A8C
	object UnpackFromUnderlyingValue(MessagePackObject messagePackObject) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.ReflectionSerializers.ReflectionNilImplicationHandler.<>c <>9; // 0x0
	public static System.Func<System.Object,System.Boolean> <>9__2_0; // 0x8
	public static System.Func<System.Object,System.Boolean> <>9__3_0; // 0x10
	public static System.Func<System.Object,System.Boolean> <>9__4_0; // 0x18
	public static System.Action<System.Object> <>9__6_0; // 0x20

	// Methods

	// RVA: 0xD2A2B0
	void .cctor() { }

	// RVA: 0xD2A31C
	void .ctor() { }

	// RVA: 0xD2A324
	bool <OnPackingMessagePackObject>b__2_0(object value) { }

	// RVA: 0xD2A3C0
	bool <OnPackingReferenceTypeObject>b__3_0(object value) { }

	// RVA: 0xD2A3CC
	bool <OnPackingNullableValueTypeObject>b__4_0(object value) { }

	// RVA: 0xD2A3D8
	void <OnNopOnUnpacked>b__6_0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public System.Func<System.Object,System.Boolean> condition; // 0x10
	public ReflectionSerializerNilImplicationHandlerParameter parameter; // 0x18

	// Methods

	// RVA: 0xD2A3DC
	void .ctor() { }

	// RVA: 0xD2A3E4
	void <OnPackingCore>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xD2A444
	void .ctor() { }

	// RVA: 0xD2A44C
	void <OnThrowNullIsProhibitedExceptionOnUnpacked>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xD2A470
	void .ctor() { }

	// RVA: 0xD2A478
	void <OnThrowValueTypeCannotBeNull3OnUnpacked>b__0(object _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionNilImplicationHandler 
{
	// Fields
	public static readonly ReflectionNilImplicationHandler Instance; // 0x0

	// Methods

	// RVA: 0xD29B40
	void .ctor() { }

	// RVA: 0xD29B94
	System.Func<System.Object,System.Boolean> OnPackingMessagePackObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD29C9C
	System.Func<System.Object,System.Boolean> OnPackingReferenceTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD29DA4
	System.Func<System.Object,System.Boolean> OnPackingNullableValueTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD29EAC
	System.Action<System.Object> OnPackingCore(ReflectionSerializerNilImplicationHandlerParameter parameter, System.Func<System.Object,System.Boolean> condition) { }

	// RVA: 0xD29F88
	System.Action<System.Object> OnNopOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD2A090
	System.Action<System.Object> OnThrowNullIsProhibitedExceptionOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD2A150
	System.Action<System.Object> OnThrowValueTypeCannotBeNull3OnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD2A210
	void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD2A7C0
	void .ctor() { }

	// RVA: 0xD2B7D8
	object <.ctor>b__0(int _) { }

	// RVA: 0xD2B80C
	void <.ctor>b__1(object c, object x) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionNonGenericCollectionMessagePackSerializer 
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x40
	private readonly System.Action<System.Object,System.Object> _addItem; // 0x48
	private readonly bool _isPackable; // 0x50
	private readonly bool _isUnpackable; // 0x51

	// Methods

	// RVA: 0xD2A4A0
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD2AECC
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD2B380
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD2B76C
	object CreateInstance(int initialCapacity) { }

	// RVA: 0xD2B7B0
	void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD2BB60
	void .ctor() { }

	// RVA: 0xD2C290
	object <.ctor>b__0(int _) { }

	// RVA: 0xD2C2C4
	void <.ctor>b__1(object c, object x) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionNonGenericEnumerableMessagePackSerializer 
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x40
	private readonly System.Action<System.Object,System.Object> _addItem; // 0x48
	private readonly bool _isPackable; // 0x50
	private readonly bool _isUnpackable; // 0x51

	// Methods

	// RVA: 0xD2B840
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD2BB6C
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD2C06C
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD2C224
	object CreateInstance(int initialCapacity) { }

	// RVA: 0xD2C268
	void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD2C59C
	void .ctor() { }

	// RVA: 0xD2CE5C
	object <.ctor>b__0(int _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionNonGenericDictionaryMessagePackSerializer 
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x48
	private readonly bool _isPackable; // 0x50
	private readonly bool _isUnpackable; // 0x51

	// Methods

	// RVA: 0xD2C2F8
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD2C730
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD2CC58
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD2CE18
	object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0 
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD2D134
	void .ctor() { }

	// RVA: 0xD2D464
	object <.ctor>b__0(int _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionNonGenericListMessagePackSerializer 
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x40
	private readonly bool _isPackable; // 0x48
	private readonly bool _isUnpackable; // 0x49

	// Methods

	// RVA: 0xD2CE90
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD2D140
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD2D260
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD2D420
	object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0 
{
	// Fields
	public SerializationContext context; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	string <.ctor>b__2(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_1 
{
	// Fields
	public SerializingMember member; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE3174
	bool <.ctor>b__4(ParameterInfo item) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.ReflectionSerializers.ReflectionObjectMessagePackSerializer.<>c<T> <>9; // 0x0
	public static System.Func<MsgPack.Serialization.DataMemberContract,System.Int32,System.Collections.Generic.KeyValuePair<System.String,System.Int32>> <>9__8_0; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Int32>,System.Boolean> <>9__8_1; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Int32>,System.Int32> <>9__8_3; // 0x0
	public static System.Func<System.Reflection.ParameterInfo,System.Object> <>9__12_0; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	System.Collections.Generic.KeyValuePair<System.String,System.Int32> <.ctor>b__8_0(DataMemberContract contract, int index) { }

	// RVA: 0x309AF8C
	bool <.ctor>b__8_1(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x309AF8C
	int <.ctor>b__8_3(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x2FE36BC
	object <UnpackFromCore>b__12_0(ParameterInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0 
{
	// Fields
	public object objectGraph; // 0x0
	public object nullable; // 0x0
	public System.Action<System.Object,System.Object> setter; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void <UnpackMemberValue>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_1 
{
	// Fields
	public int argumentIndex; // 0x0
	public MsgPack.Serialization.ReflectionSerializers.ReflectionObjectMessagePackSerializer.<>c__DisplayClass13_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x2FE4574
	void <UnpackMemberValue>b__1(object value) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionObjectMessagePackSerializer<T0> 
{
	// Fields
	private readonly System.Func<System.Object,System.Object>[] _getters; // 0x0
	private readonly System.Action<System.Object,System.Object>[] _setters; // 0x0
	private readonly MemberInfo[] _memberInfos; // 0x0
	private readonly DataMemberContract[] _contracts; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.String,System.Int32> _memberIndexes; // 0x0
	private readonly MessagePackSerializer[] _serializers; // 0x0
	private readonly ParameterInfo[] _constructorParameters; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.Int32,System.Int32> _constructorArgumentIndexes; // 0x0

	// Methods

	// RVA: 0x2FE4840
	void .ctor(SerializationContext context, SerializationTarget target, SerializerCapabilities capabilities) { }

	// RVA: 0x309AF8C
	void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x309AF8C
	bool IsNull(T objectTree, int index) { }

	// RVA: 0x309AF8C
	void PackMemberValue(Packer packer, T objectTree, int index) { }

	// RVA: 0x309AF8C
	T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x309AF8C
	object UnpackMemberValue(object objectGraph, Unpacker unpacker, int itemsCount, int unpacked, int index, int unpackerOffset) { }

	// RVA: 0x2FE3728
	object UnpackSingleValue(Unpacker unpacker, int index) { }

	// RVA: 0x2FE4840
	void UnpackAndAddCollectionItem(object objectGraph, Unpacker unpacker, int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0 
{
	// Fields
	public CollectionTraits collectionTraits; // 0x10

	// Methods

	// RVA: 0xD2D498
	void .ctor() { }

	// RVA: 0xD2EA10
	void <GetAddItem>b__0(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public MethodInfo getter; // 0x10
	public MethodInfo setter; // 0x18

	// Methods

	// RVA: 0xD2E77C
	void .ctor() { }

	// RVA: 0xD2EAFC
	object <GetMetadata>b__0(object target) { }

	// RVA: 0xD2EB70
	void <GetMetadata>b__1(object target, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public ConstructorInfo constructor; // 0x10

	// Methods

	// RVA: 0xD2E8C0
	void .ctor() { }

	// RVA: 0xD2EC5C
	object <CreateCollectionInstanceFactory>b__0(int _) { }

	// RVA: 0xD2ECEC
	object <CreateCollectionInstanceFactory>b__1(int capacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1 
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xD2E8C8
	void .ctor() { }

	// RVA: 0xD2EE04
	object <CreateCollectionInstanceFactory>b__2(int _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2 
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xD2E8D0
	void .ctor() { }

	// RVA: 0xD2EEE8
	object <CreateCollectionInstanceFactory>b__3(int capacity) { }

	// RVA: 0xD2F040
	object <CreateCollectionInstanceFactory>b__4(int capacity) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal static class ReflectionSerializerHelper 
{
	// Fields
	internal static readonly PropertyInfo DictionaryEntryKeyProperty; // 0x0
	internal static readonly PropertyInfo DictionaryEntryValueProperty; // 0x8

	// Methods

	// RVA: 0x2FE7084
	MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionEnumMessagePackSerializer(SerializationContext context) { }

	// RVA: 0x309AF8C
	MessagePackSerializer CreateCollectionSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD2ACD4
	System.Action<System.Object,System.Object> GetAddItem(Type targetType, CollectionTraits collectionTraits) { }

	// RVA: 0xD2D9C8
	void GetMetadata(Type targetType, System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, SerializationContext context, out System.Func<System.Object,System.Object>[]& getters, out System.Action<System.Object,System.Object>[]& setters, out MemberInfo[] memberInfos, out DataMemberContract[] contracts, out MessagePackSerializer[] serializers) { }

	// RVA: 0xD2E784
	void ThrowMissingGetterException(Type targetType, int number, PropertyInfo property) { }

	// RVA: 0xD2A7CC
	System.Func<System.Int32,System.Object> CreateCollectionInstanceFactory(Type abstractType, Type targetType, Type comparisonType, ConstructorInfo constructor) { }

	// RVA: 0xD2E8D8
	void .cctor() { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionSerializerNilImplicationHandlerOnUnpackedParameter 
{
	// Fields
	private readonly Type _itemType; // 0x10
	private readonly System.Action<System.Object> _store; // 0x18
	public readonly string MemberName; // 0x20
	public readonly Type DeclaringType; // 0x28

	// Methods

	// RVA: 0xD2F198
	Type get_ItemType() { }

	// RVA: 0xD2F1A0
	System.Action<System.Object> get_Store() { }

	// RVA: 0xD2F1A8
	void .ctor(Type itemType, System.Action<System.Object> store, string memberName, Type declaringType) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionSerializerNilImplicationHandlerParameter 
{
	// Fields
	private readonly Type _itemType; // 0x10
	private readonly string _memberName; // 0x18

	// Methods

	// RVA: 0xD2F228
	Type get_ItemType() { }

	// RVA: 0xD2F230
	string get_MemberName() { }

	// RVA: 0xD2F238
	void .ctor(Type itemType, string memberName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass1_0 
{
	// Fields
	public Type genericType; // 0x10
	public Type source; // 0x18

	// Methods

	// RVA: 0xD2F52C
	void .ctor() { }

	// RVA: 0xD2F534
	bool <EnumerateGenericIntefaces>b__0(Type interface) { }

	// RVA: 0xD2F648
	Type <EnumerateGenericIntefaces>b__1(Type interface) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.Reflection.GenericTypeExtensions.<>c <>9; // 0x0
	public static System.Func<System.Type,System.String> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xD2F708
	void .cctor() { }

	// RVA: 0xD2F774
	void .ctor() { }

	// RVA: 0xD2F77C
	string <GetFullName>b__3_0(Type t) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class GenericTypeExtensions 
{
	// Methods

	// RVA: 0xD2F288
	bool Implements(Type source, Type genericType) { }

	// RVA: 0xD2F2EC
	System.Collections.Generic.IEnumerable<System.Type> EnumerateGenericIntefaces(Type source, Type genericType, bool includesOwn) { }

	// RVA: 0xD2D4A0
	string GetFullName(Type source) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class ReflectionExtensions 
{
	// Methods

	// RVA: 0xD2F784
	bool IsAssignableTo(Type source, Type target) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal interface IPolymorphicDeserializer 
{
	// Methods

	// RVA: 0x2FE36BC
	object PolymorphicUnpackFrom(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal interface IPolymorphicHelperAttribute 
{
	// Methods

	// RVA: 0x2FE32D4
	PolymorphismTarget get_Target() { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal interface IPolymorphicKnownTypeAttribute 
{
	// Methods

	// RVA: 0x2FE360C
	Type get_BindingType() { }

	// RVA: 0x2FE360C
	string get_TypeCode() { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal interface IPolymorphicRuntimeTypeAttribute 
{
	// Methods

	// RVA: 0x2FE360C
	Type get_VerifierType() { }

	// RVA: 0x2FE360C
	string get_VerifierMethodName() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.Polymorphic.KnownTypePolymorphicMessagePackSerializer.<>c<T> <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Type>,System.String> <>9__4_0; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Type>,System.RuntimeTypeHandle> <>9__4_1; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Type>,System.Type> <>9__5_0; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Type>,System.String> <>9__5_1; // 0x0
	public static System.Func<System.String,System.String> <>9__5_2; // 0x0

	// Methods

	// RVA: 0x2FE8AB8
	void .cctor() { }

	// RVA: 0x2FE41A8
	void .ctor() { }

	// RVA: 0x309AF8C
	string <BuildTypeCodeTypeHandleMap>b__4_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x309AF8C
	RuntimeTypeHandle <BuildTypeCodeTypeHandleMap>b__4_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x309AF8C
	Type <BuildTypeHandleTypeCodeMap>b__5_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x309AF8C
	string <BuildTypeHandleTypeCodeMap>b__5_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x2FE36BC
	string <BuildTypeHandleTypeCodeMap>b__5_2(string b) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class KnownTypePolymorphicMessagePackSerializer<T0> 
{
	// Fields
	private readonly PolymorphismSchema _schema; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.String,System.RuntimeTypeHandle> _typeHandleMap; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.RuntimeTypeHandle,System.String> _typeCodeMap; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x2FE7084
	System.Collections.Generic.IDictionary<System.String,System.RuntimeTypeHandle> BuildTypeCodeTypeHandleMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x2FE7084
	System.Collections.Generic.IDictionary<System.RuntimeTypeHandle,System.String> BuildTypeHandleTypeCodeMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x2FE36BC
	MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x309AF8C
	void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x309AF8C
	string GetTypeCode(T objectTree) { }

	// RVA: 0x309AF8C
	T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x2FE36BC
	Type GetTypeFromCode(string typeCode) { }

	// RVA: 0x2FE36BC
	object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x309AF8C
	void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x2FE36BC
	Type <UnpackFromCore>b__9_0(string c) { }

	// RVA: 0x309AF8C
	T <UnpackFromCore>b__9_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class PolymorphicSerializerProvider<T0> 
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<T> _defaultSerializer; // 0x0
	private readonly PolymorphismSchema _defaultSchema; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(SerializationContext context, MessagePackSerializer defaultSerializer) { }

	// RVA: 0x2FE37A0
	object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: 
private class Queue<T0> 
{
	// Fields
	private T[] _array; // 0x0
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _size; // 0x0

	// Methods

	// RVA: 0x2FE42A4
	void .ctor(int capacity) { }

	// RVA: 0x309AF8C
	void Enqueue(T item) { }

	// RVA: 0x309AF8C
	T Dequeue() { }

	// RVA: 0x2FE42A4
	void SetCapacity(int capacity) { }

	// RVA: 0x2FE4574
	void MoveNext(ref int index) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal static class RuntimeTypeVerifier 
{
	// Fields
	private static readonly ReaderWriterLockSlim _resultCacheLock; // 0x0
	private static readonly System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.Boolean> _resultCache; // 0x8
	private static readonly MsgPack.Serialization.Polymorphic.RuntimeTypeVerifier.Queue<System.Collections.Generic.KeyValuePair<System.String,System.String>> _histories; // 0x10

	// Methods

	// RVA: 0xD2F7AC
	void Verify(AssemblyName assemblyName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD2F920
	bool VerifyCore(AssemblyName assemblyName, string assemblyFullName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD2FDF8
	void .cctor() { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class TypeEmbedingPolymorphicMessagePackSerializer<T0> 
{
	// Fields
	private readonly PolymorphismSchema _schema; // 0x0

	// Methods

	// RVA: 0x2FE47D4
	void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x2FE36BC
	MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x309AF8C
	void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x309AF8C
	T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x2FE36BC
	object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x309AF8C
	void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x2FE36BC
	Type <UnpackFromCore>b__4_0(Unpacker u) { }

	// RVA: 0x309AF8C
	T <UnpackFromCore>b__4_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal static class TypeInfoEncoder 
{
	// Methods

	// RVA: 0xD2FF3C
	void Encode(Packer packer, string typeCode) { }

	// RVA: 0xD2FF7C
	void Encode(Packer packer, Type type) { }

	// RVA: 0x309AF8C
	T Decode(Unpacker unpacker, System.Func<System.String,System.Type> typeFinder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0x309AF8C
	T Decode(Unpacker unpacker, System.Func<MsgPack.Unpacker,System.Type> typeDecoder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0xD30288
	Type DecodeRuntimeTypeInfo(Unpacker unpacker, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD30898
	void ThrowFailedToDecodeEncodingType() { }

	// RVA: 0xD308EC
	void ThrowUnknownEncodingType(Byte encodeType) { }

	// RVA: 0xD309D4
	void ThrowFailedToDecodeCompressedTypeName() { }

	// RVA: 0xD30A28
	void ThrowFailedToDecodeAssemblySimpleName() { }

	// RVA: 0xD30A7C
	void ThrowFailedToDecodeAssemblyVersion() { }

	// RVA: 0xD30AD0
	void ThrowFailedToDecodeAssemblyCulture() { }

	// RVA: 0xD30B24
	void ThrowFailedToDecodeAssemblyKeyToken() { }

	// RVA: 0xD307B8
	void CheckUnpackerForRuntimeTypeInfoDecoding(Unpacker unpacker) { }

	// RVA: 0xD30DDC
	void ThrowEncodedTypeIsNotInNonNillArray() { }

	// RVA: 0xD30E30
	void ThrowEncodedTypeDoesNotHaveValidArrayItems() { }

	// RVA: 0xD30B78
	AssemblyName BuildAssemblyName(string assemblySimpleName, Byte[] version, string culture, Byte[] publicKeyToken) { }

	// RVA: 0xD30D0C
	string DecompressTypeName(string assemblySimpleName, string compressedTypeName) { }

	// RVA: 0xD30D9C
	Type LoadDecodedType(AssemblyName assemblyName, string typeFullName) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractCollectionMessagePackSerializer 
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x50
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x58

	// Methods

	// RVA: 0xD30E84
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD31178
	object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD31358
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class AbstractCollectionSerializerHelper 
{
	// Methods

	// RVA: 0xD31020
	void GetConcreteSerializer(SerializationContext context, PolymorphismSchema schema, Type abstractType, Type targetType, Type exampleType, out ICollectionInstanceFactory factory, out MessagePackSerializer serializer) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractDictionaryMessagePackSerializer 
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x68
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x70

	// Methods

	// RVA: 0xD3140C
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD31724
	object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD31904
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractEnumerableMessagePackSerializer 
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly MessagePackSerializer _concreteSerializer; // 0x50

	// Methods

	// RVA: 0xD319B8
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD31AE4
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD31BC4
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericCollectionMessagePackSerializer 
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xD31C78
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD31D4C
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD31E2C
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericDictionaryMessagePackSerializer 
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x50

	// Methods

	// RVA: 0xD31EE0
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD32004
	object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD32194
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericEnumerableMessagePackSerializer 
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xD32248
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD3231C
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD323FC
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericListMessagePackSerializer 
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x48

	// Methods

	// RVA: 0xD324B0
	void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD325D4
	object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD327B4
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySegmentMessageSerializer 
{
	// Methods

	// RVA: 0xD32868
	void PackByteArraySegmentTo(Packer packer, System.ArraySegment<System.Byte> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xD329AC
	void PackCharArraySegmentTo(Packer packer, System.ArraySegment<System.Char> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x309AF8C
	void PackGenericArraySegmentTo(Packer packer, System.ArraySegment<T> objectTree, MsgPack.Serialization.MessagePackSerializer<T> itemSerializer) { }

	// RVA: 0xD32B20
	System.ArraySegment<System.Byte> UnpackByteArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xD32BD8
	System.ArraySegment<System.Char> UnpackCharArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x309AF8C
	System.ArraySegment<T> UnpackGenericArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<T> itemSerializer) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly MsgPack.Serialization.DefaultSerializers.ArraySerializer.<>c <>9; // 0x0
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_0; // 0x8
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_1; // 0x10
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_2; // 0x18
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_3; // 0x20
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_4; // 0x28
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_5; // 0x30
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_6; // 0x38
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_7; // 0x40
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_8; // 0x48
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_9; // 0x50
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_10; // 0x58
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_11; // 0x60
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_12; // 0x68
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_13; // 0x70
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_14; // 0x78
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_15; // 0x80
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_16; // 0x88
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_17; // 0x90
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_18; // 0x98
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_19; // 0xA0
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_20; // 0xA8
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_21; // 0xB0
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_22; // 0xB8
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_23; // 0xC0
	public static System.Func<MsgPack.Serialization.SerializationContext,System.Object> <>9__4_24; // 0xC8

	// Methods

	// RVA: 0xD348F8
	void .cctor() { }

	// RVA: 0xD34964
	void .ctor() { }

	// RVA: 0xD3496C
	object <InitializeArraySerializerFactories>b__4_0(SerializationContext context) { }

	// RVA: 0xD34AAC
	object <InitializeArraySerializerFactories>b__4_1(SerializationContext context) { }

	// RVA: 0xD34BEC
	object <InitializeArraySerializerFactories>b__4_2(SerializationContext context) { }

	// RVA: 0xD34D2C
	object <InitializeArraySerializerFactories>b__4_3(SerializationContext context) { }

	// RVA: 0xD34E6C
	object <InitializeArraySerializerFactories>b__4_4(SerializationContext context) { }

	// RVA: 0xD34FAC
	object <InitializeArraySerializerFactories>b__4_5(SerializationContext context) { }

	// RVA: 0xD350EC
	object <InitializeArraySerializerFactories>b__4_6(SerializationContext context) { }

	// RVA: 0xD3522C
	object <InitializeArraySerializerFactories>b__4_7(SerializationContext context) { }

	// RVA: 0xD3536C
	object <InitializeArraySerializerFactories>b__4_8(SerializationContext context) { }

	// RVA: 0xD354AC
	object <InitializeArraySerializerFactories>b__4_9(SerializationContext context) { }

	// RVA: 0xD355EC
	object <InitializeArraySerializerFactories>b__4_10(SerializationContext context) { }

	// RVA: 0xD3572C
	object <InitializeArraySerializerFactories>b__4_11(SerializationContext context) { }

	// RVA: 0xD3586C
	object <InitializeArraySerializerFactories>b__4_12(SerializationContext context) { }

	// RVA: 0xD359AC
	object <InitializeArraySerializerFactories>b__4_13(SerializationContext context) { }

	// RVA: 0xD35AEC
	object <InitializeArraySerializerFactories>b__4_14(SerializationContext context) { }

	// RVA: 0xD35C2C
	object <InitializeArraySerializerFactories>b__4_15(SerializationContext context) { }

	// RVA: 0xD35D6C
	object <InitializeArraySerializerFactories>b__4_16(SerializationContext context) { }

	// RVA: 0xD35EAC
	object <InitializeArraySerializerFactories>b__4_17(SerializationContext context) { }

	// RVA: 0xD35FEC
	object <InitializeArraySerializerFactories>b__4_18(SerializationContext context) { }

	// RVA: 0xD3612C
	object <InitializeArraySerializerFactories>b__4_19(SerializationContext context) { }

	// RVA: 0xD3626C
	object <InitializeArraySerializerFactories>b__4_20(SerializationContext context) { }

	// RVA: 0xD363AC
	object <InitializeArraySerializerFactories>b__4_21(SerializationContext context) { }

	// RVA: 0xD364EC
	object <InitializeArraySerializerFactories>b__4_22(SerializationContext context) { }

	// RVA: 0xD3662C
	object <InitializeArraySerializerFactories>b__4_23(SerializationContext context) { }

	// RVA: 0xD3676C
	object <InitializeArraySerializerFactories>b__4_24(SerializationContext context) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySerializer 
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> _arraySerializerFactories; // 0x0

	// Methods

	// RVA: 0x2FE7164
	MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD32C90
	MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD32E70
	object GetPrimitiveArraySerializer(SerializationContext context, Type targetType) { }

	// RVA: 0xD3312C
	System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> InitializeArraySerializerFactories() { }

	// RVA: 0xD3489C
	void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SByteArraySerializer 
{
	// Methods

	// RVA: 0xD34A28
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD368AC
	void PackToCore(Packer packer, SByte[] objectTree) { }

	// RVA: 0xD36924
	SByte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD36AC8
	void UnpackToCore(Unpacker unpacker, SByte[] collection) { }

	// RVA: 0xD369F0
	void UnpackToCore(Unpacker unpacker, SByte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int16ArraySerializer 
{
	// Methods

	// RVA: 0xD34CA8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD36B68
	void PackToCore(Packer packer, Int16[] objectTree) { }

	// RVA: 0xD36BE0
	Int16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD36D84
	void UnpackToCore(Unpacker unpacker, Int16[] collection) { }

	// RVA: 0xD36CAC
	void UnpackToCore(Unpacker unpacker, Int16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int32ArraySerializer 
{
	// Methods

	// RVA: 0xD34F28
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD36E24
	void PackToCore(Packer packer, int[] objectTree) { }

	// RVA: 0xD36E9C
	int[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD37040
	void UnpackToCore(Unpacker unpacker, int[] collection) { }

	// RVA: 0xD36F68
	void UnpackToCore(Unpacker unpacker, int[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int64ArraySerializer 
{
	// Methods

	// RVA: 0xD351A8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD370E0
	void PackToCore(Packer packer, Int64[] objectTree) { }

	// RVA: 0xD37158
	Int64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD372FC
	void UnpackToCore(Unpacker unpacker, Int64[] collection) { }

	// RVA: 0xD37224
	void UnpackToCore(Unpacker unpacker, Int64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class ByteArraySerializer 
{
	// Methods

	// RVA: 0xD35428
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3739C
	void PackToCore(Packer packer, Byte[] objectTree) { }

	// RVA: 0xD37414
	Byte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD375B8
	void UnpackToCore(Unpacker unpacker, Byte[] collection) { }

	// RVA: 0xD374E0
	void UnpackToCore(Unpacker unpacker, Byte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt16ArraySerializer 
{
	// Methods

	// RVA: 0xD356A8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD37658
	void PackToCore(Packer packer, UInt16[] objectTree) { }

	// RVA: 0xD376D0
	UInt16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD37874
	void UnpackToCore(Unpacker unpacker, UInt16[] collection) { }

	// RVA: 0xD3779C
	void UnpackToCore(Unpacker unpacker, UInt16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt32ArraySerializer 
{
	// Methods

	// RVA: 0xD35928
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD37914
	void PackToCore(Packer packer, UInt32[] objectTree) { }

	// RVA: 0xD3798C
	UInt32[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD37B30
	void UnpackToCore(Unpacker unpacker, UInt32[] collection) { }

	// RVA: 0xD37A58
	void UnpackToCore(Unpacker unpacker, UInt32[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt64ArraySerializer 
{
	// Methods

	// RVA: 0xD35BA8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD37BD0
	void PackToCore(Packer packer, UInt64[] objectTree) { }

	// RVA: 0xD37C48
	UInt64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD37DEC
	void UnpackToCore(Unpacker unpacker, UInt64[] collection) { }

	// RVA: 0xD37D14
	void UnpackToCore(Unpacker unpacker, UInt64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SingleArraySerializer 
{
	// Methods

	// RVA: 0xD35E28
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD37E8C
	void PackToCore(Packer packer, float[] objectTree) { }

	// RVA: 0xD37F04
	float[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD380A8
	void UnpackToCore(Unpacker unpacker, float[] collection) { }

	// RVA: 0xD37FD0
	void UnpackToCore(Unpacker unpacker, float[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class DoubleArraySerializer 
{
	// Methods

	// RVA: 0xD360A8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD38148
	void PackToCore(Packer packer, Double[] objectTree) { }

	// RVA: 0xD381C0
	Double[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD38364
	void UnpackToCore(Unpacker unpacker, Double[] collection) { }

	// RVA: 0xD3828C
	void UnpackToCore(Unpacker unpacker, Double[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BooleanArraySerializer 
{
	// Methods

	// RVA: 0xD36328
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD38404
	void PackToCore(Packer packer, bool[] objectTree) { }

	// RVA: 0xD3847C
	bool[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD38620
	void UnpackToCore(Unpacker unpacker, bool[] collection) { }

	// RVA: 0xD38548
	void UnpackToCore(Unpacker unpacker, bool[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSByteArraySerializer 
{
	// Methods

	// RVA: 0xD34B68
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD386C0
	void PackToCore(Packer packer, System.Nullable<System.SByte>[] objectTree) { }

	// RVA: 0xD3874C
	System.Nullable<System.SByte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD388F0
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection) { }

	// RVA: 0xD38818
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt16ArraySerializer 
{
	// Methods

	// RVA: 0xD34DE8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD38990
	void PackToCore(Packer packer, System.Nullable<System.Int16>[] objectTree) { }

	// RVA: 0xD38A1C
	System.Nullable<System.Int16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD38BC0
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection) { }

	// RVA: 0xD38AE8
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt32ArraySerializer 
{
	// Methods

	// RVA: 0xD35068
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD38C60
	void PackToCore(Packer packer, System.Nullable<System.Int32>[] objectTree) { }

	// RVA: 0xD38CD8
	System.Nullable<System.Int32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD38E7C
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection) { }

	// RVA: 0xD38DA4
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt64ArraySerializer 
{
	// Methods

	// RVA: 0xD352E8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD38F1C
	void PackToCore(Packer packer, System.Nullable<System.Int64>[] objectTree) { }

	// RVA: 0xD38F98
	System.Nullable<System.Int64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD3913C
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection) { }

	// RVA: 0xD39064
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableByteArraySerializer 
{
	// Methods

	// RVA: 0xD35568
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD391DC
	void PackToCore(Packer packer, System.Nullable<System.Byte>[] objectTree) { }

	// RVA: 0xD39268
	System.Nullable<System.Byte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD3940C
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection) { }

	// RVA: 0xD39334
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt16ArraySerializer 
{
	// Methods

	// RVA: 0xD357E8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD394AC
	void PackToCore(Packer packer, System.Nullable<System.UInt16>[] objectTree) { }

	// RVA: 0xD39538
	System.Nullable<System.UInt16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD396DC
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection) { }

	// RVA: 0xD39604
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt32ArraySerializer 
{
	// Methods

	// RVA: 0xD35A68
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3977C
	void PackToCore(Packer packer, System.Nullable<System.UInt32>[] objectTree) { }

	// RVA: 0xD397F4
	System.Nullable<System.UInt32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD39998
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection) { }

	// RVA: 0xD398C0
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt64ArraySerializer 
{
	// Methods

	// RVA: 0xD35CE8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD39A38
	void PackToCore(Packer packer, System.Nullable<System.UInt64>[] objectTree) { }

	// RVA: 0xD39AB4
	System.Nullable<System.UInt64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD39C58
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection) { }

	// RVA: 0xD39B80
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSingleArraySerializer 
{
	// Methods

	// RVA: 0xD35F68
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD39CF8
	void PackToCore(Packer packer, System.Nullable<System.Single>[] objectTree) { }

	// RVA: 0xD39D70
	System.Nullable<System.Single>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD39F14
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection) { }

	// RVA: 0xD39E3C
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableDoubleArraySerializer 
{
	// Methods

	// RVA: 0xD361E8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD39FB4
	void PackToCore(Packer packer, System.Nullable<System.Double>[] objectTree) { }

	// RVA: 0xD3A030
	System.Nullable<System.Double>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD3A1D4
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection) { }

	// RVA: 0xD3A0FC
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableBooleanArraySerializer 
{
	// Methods

	// RVA: 0xD36468
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3A274
	void PackToCore(Packer packer, System.Nullable<System.Boolean>[] objectTree) { }

	// RVA: 0xD3A300
	System.Nullable<System.Boolean>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD3A4A4
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection) { }

	// RVA: 0xD3A3CC
	void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class StringArraySerializer 
{
	// Methods

	// RVA: 0xD365A8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3A544
	void PackToCore(Packer packer, string[] objectTree) { }

	// RVA: 0xD3A5BC
	string[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD3A770
	void UnpackToCore(Unpacker unpacker, string[] collection) { }

	// RVA: 0xD3A688
	void UnpackToCore(Unpacker unpacker, string[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BinaryArraySerializer 
{
	// Methods

	// RVA: 0xD366E8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3A810
	void PackToCore(Packer packer, Byte[][] objectTree) { }

	// RVA: 0xD3A888
	Byte[][] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD3AA3C
	void UnpackToCore(Unpacker unpacker, Byte[][] collection) { }

	// RVA: 0xD3A954
	void UnpackToCore(Unpacker unpacker, Byte[][] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MessagePackObjectArraySerializer 
{
	// Methods

	// RVA: 0xD36828
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3AADC
	void PackToCore(Packer packer, MessagePackObject[] objectTree) { }

	// RVA: 0xD3ABB0
	MessagePackObject[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD3AD68
	void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection) { }

	// RVA: 0xD3AC7C
	void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UnityArraySerializer 
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38
	private readonly Type _itemType; // 0x40

	// Methods

	// RVA: 0xD32F74
	void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD3AE08
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD3B1AC
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD3B508
	void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD3B270
	void UnpackToCore(Unpacker unpacker, IList collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class DateTimeMessagePackSerializerProvider 
{
	// Fields
	private readonly MessagePackSerializer _unixEpoc; // 0x10
	private readonly MessagePackSerializer _native; // 0x18
	private readonly MessagePackSerializer _timestamp; // 0x20

	// Methods

	// RVA: 0xD3B5DC
	void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD3BC00
	object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class DateTimeOffsetMessagePackSerializer 
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xD3BE34
	void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xD3BECC
	void PackToCore(Packer packer, DateTimeOffset objectTree) { }

	// RVA: 0xD3C118
	DateTimeOffset UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class DateTimeOffsetMessagePackSerializerProvider 
{
	// Fields
	private readonly MessagePackSerializer _unixEpoc; // 0x10
	private readonly MessagePackSerializer _native; // 0x18
	private readonly MessagePackSerializer _timestamp; // 0x20

	// Methods

	// RVA: 0xD3C828
	void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD3CCA0
	object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_BooleanMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3CED4
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3CF58
	void PackToCore(Packer packer, bool value) { }

	// RVA: 0xD3CF78
	bool UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3D1B0
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3D234
	void PackToCore(Packer packer, Byte value) { }

	// RVA: 0xD3D254
	Byte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3D48C
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3D510
	void PackToCore(Packer packer, Char value) { }

	// RVA: 0xD3D530
	Char UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DecimalMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3D734
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3D7B8
	void PackToCore(Packer packer, Decimal value) { }

	// RVA: 0xD3D8BC
	Decimal UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DoubleMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3DB30
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3DBB4
	void PackToCore(Packer packer, Double value) { }

	// RVA: 0xD3DBD0
	Double UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_GuidMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3DE08
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3DE8C
	void PackToCore(Packer packer, Guid value) { }

	// RVA: 0xD3DED8
	Guid UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int16MessagePackSerializer 
{
	// Methods

	// RVA: 0xD3E0F8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3E17C
	void PackToCore(Packer packer, Int16 value) { }

	// RVA: 0xD3E19C
	Int16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int32MessagePackSerializer 
{
	// Methods

	// RVA: 0xD3E3D4
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3E458
	void PackToCore(Packer packer, int value) { }

	// RVA: 0xD3E478
	int UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int64MessagePackSerializer 
{
	// Methods

	// RVA: 0xD3E6B0
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3E734
	void PackToCore(Packer packer, Int64 value) { }

	// RVA: 0xD3E754
	Int64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SByteMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3E98C
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3EA10
	void PackToCore(Packer packer, SByte value) { }

	// RVA: 0xD3EA30
	SByte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SingleMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3EC68
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3ECEC
	void PackToCore(Packer packer, float value) { }

	// RVA: 0xD3ED08
	float UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_TimeSpanMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3EF40
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3EFC4
	void PackToCore(Packer packer, TimeSpan value) { }

	// RVA: 0xD3F048
	TimeSpan UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt16MessagePackSerializer 
{
	// Methods

	// RVA: 0xD3F280
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3F304
	void PackToCore(Packer packer, UInt16 value) { }

	// RVA: 0xD3F324
	UInt16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt32MessagePackSerializer 
{
	// Methods

	// RVA: 0xD3F55C
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3F5E0
	void PackToCore(Packer packer, UInt32 value) { }

	// RVA: 0xD3F600
	UInt32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt64MessagePackSerializer 
{
	// Methods

	// RVA: 0xD3F838
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3F8BC
	void PackToCore(Packer packer, UInt64 value) { }

	// RVA: 0xD3F8DC
	UInt64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_BitVector32MessagePackSerializer 
{
	// Methods

	// RVA: 0xD3FB14
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD3FB98
	void PackToCore(Packer packer, BitVector32 value) { }

	// RVA: 0xD3FBB8
	BitVector32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class GenericSerializer 
{
	// Methods

	// RVA: 0x2FE7164
	MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0xD3FDF0
	MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema schema) { }

	// RVA: 0xD401A4
	MessagePackSerializer CreateArraySerializer(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD4021C
	MessagePackSerializer CreateNullableSerializer(SerializationContext context, Type nullableType, Type underlyingType) { }

	// RVA: 0xD402C4
	MessagePackSerializer CreateListSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD403E0
	MessagePackSerializer CreateDictionarySerializer(SerializationContext context, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema schema) { }

	// RVA: 0xD408F4
	MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD409EC
	MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema, CollectionTraits traits) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class MessagePackObjectExtensions 
{
	// Methods

	// RVA: 0xD3C66C
	Int64 DeserializeAsInt64(MessagePackObject source) { }

	// RVA: 0xD40C80
	string DeserializeAsString(MessagePackObject source) { }

	// RVA: 0xD3C4B0
	MessagePackExtendedTypeObject DeserializeAsMessagePackExtendedTypeObject(MessagePackObject source) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackExtendedTypeObjectMessagePackSerializer 
{
	// Methods

	// RVA: 0xD40E3C
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD40EC0
	void PackToCore(Packer packer, MessagePackExtendedTypeObject value) { }

	// RVA: 0xD40EE4
	MessagePackExtendedTypeObject UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectDictionaryMessagePackSerializer 
{
	// Methods

	// RVA: 0xD410CC
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD41150
	void PackToCore(Packer packer, MessagePackObjectDictionary objectTree) { }

	// RVA: 0xD4141C
	MessagePackObjectDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD41610
	void UnpackToCore(Unpacker unpacker, MessagePackObjectDictionary collection) { }

	// RVA: 0xD414F0
	void UnpackToCore(Unpacker unpacker, int count, MessagePackObjectDictionary collection) { }

	// RVA: 0xD41688
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectMessagePackSerializer 
{
	// Methods

	// RVA: 0xD416F0
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD41774
	void PackToCore(Packer packer, MessagePackObject value) { }

	// RVA: 0xD417F0
	MessagePackObject UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0 
{
	// Fields
	public UnityMultidimensionalArraySerializer <>4__this; // 0x10
	public Packer packer; // 0x18
	public Array array; // 0x20

	// Methods

	// RVA: 0xD41DE0
	void .ctor() { }

	// RVA: 0xD42FDC
	void <PackArrayCore>b__0(int[] indices) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0 
{
	// Fields
	public Unpacker unpacker; // 0x10
	public UnityMultidimensionalArraySerializer <>4__this; // 0x18

	// Methods

	// RVA: 0xD42C84
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1 
{
	// Fields
	public Unpacker arrayUnpacker; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xD42FCC
	void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2 
{
	// Fields
	public Array result; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xD42FD4
	void .ctor() { }

	// RVA: 0xD43030
	void <UnpackFromCore>b__0(int[] indices) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UnityMultidimensionalArraySerializer 
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38
	private readonly MessagePackSerializer _int32ArraySerializer; // 0x40
	private readonly Type _itemType; // 0x48

	// Methods

	// RVA: 0xD3300C
	void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD4185C
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD418F4
	void PackArrayCore(Packer packer, Array array) { }

	// RVA: 0xD41DE8
	void GetArrayMetadata(Array array, out int[] lengths, out int[] lowerBounds) { }

	// RVA: 0xD42154
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD42C8C
	void ReadArrayMetadata(Unpacker metadataUnpacker, out int[] lengths, out int[] lowerBounds) { }

	// RVA: 0xD41F28
	void ForEach(Array array, int totalLength, int[] lowerBounds, int[] lengths, System.Action<System.Int32[]> action) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NativeDateTimeMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3BAF8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD430D0
	void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD43178
	DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NullableMessagePackSerializer 
{
	// Fields
	private readonly MessagePackSerializer _valueSerializer; // 0x38

	// Methods

	// RVA: 0xD40518
	void .ctor(SerializationContext ownerContext, Type nullableType, Type underlyingType) { }

	// RVA: 0xD3BAC0
	void .ctor(SerializationContext ownerContext, Type nullableType, MessagePackSerializer valueSerializer) { }

	// RVA: 0xD43208
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD43228
	object UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_ArraySegment_1MessagePackSerializer<T0> 
{
	// Fields
	private static readonly System.Action<MsgPack.Packer,System.ArraySegment<T>,MsgPack.Serialization.MessagePackSerializer<T>> _packing; // 0x0
	private static readonly System.Func<MsgPack.Unpacker,MsgPack.Serialization.MessagePackSerializer<T>,System.ArraySegment<T>> _unpacking; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<T> _itemSerializer; // 0x0

	// Methods

	// RVA: 0x2FE704C
	System.Action<MsgPack.Packer,System.ArraySegment<T>,MsgPack.Serialization.MessagePackSerializer<T>> InitializePacking() { }

	// RVA: 0x2FE704C
	System.Func<MsgPack.Unpacker,MsgPack.Serialization.MessagePackSerializer<T>,System.ArraySegment<T>> InitializeUnpacking() { }

	// RVA: 0x2FE4574
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x309AF8C
	void PackToCore(Packer packer, System.ArraySegment<T> objectTree) { }

	// RVA: 0x309AF8C
	System.ArraySegment<T> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x2FE8AB8
	void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteArrayMessagePackSerializer 
{
	// Methods

	// RVA: 0xD43248
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD432CC
	void PackToCore(Packer packer, Byte[] value) { }

	// RVA: 0xD432EC
	Byte[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharArrayMessagePackSerializer 
{
	// Methods

	// RVA: 0xD433C0
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD43444
	void PackToCore(Packer packer, Char[] value) { }

	// RVA: 0xD43480
	Char[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_DictionaryEntryMessagePackSerializer 
{
	// Methods

	// RVA: 0xD43554
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD435D8
	void PackToCore(Packer packer, DictionaryEntry objectTree) { }

	// RVA: 0xD4369C
	MessagePackObject EnsureMessagePackObject(object obj) { }

	// RVA: 0xD4377C
	DictionaryEntry UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_Collections_Generic_Dictionary_2MessagePackSerializer 
{
	// Fields
	private readonly MessagePackSerializer _keySerializer; // 0x38
	private readonly MessagePackSerializer _valueSerializer; // 0x40
	private readonly Type _keyType; // 0x48
	private readonly ConstructorInfo _constructor; // 0x50
	private readonly MethodInfo _add; // 0x58

	// Methods

	// RVA: 0xD40664
	void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema keysSchema, PolymorphismSchema valuesSchema) { }

	// RVA: 0xD439D0
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD43E00
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD44498
	void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD43F80
	void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xD43F0C
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_KeyValuePair_2MessagePackSerializer<T0, T1> 
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x309AF8C
	void PackToCore(Packer packer, System.Collections.Generic.KeyValuePair<TKey,TValue> objectTree) { }

	// RVA: 0x309AF8C
	System.Collections.Generic.KeyValuePair<TKey,TValue> UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_Collections_Generic_List_1MessagePackSerializer 
{
	// Fields
	private static readonly Type[] ConstructorWithCapacityParameterTypes; // 0x0
	private readonly MessagePackSerializer _itemSerializer; // 0x38
	private readonly ConstructorInfo _constructor; // 0x40
	private readonly MethodInfo _add; // 0x48

	// Methods

	// RVA: 0xD40574
	void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD44540
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD448F8
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD44E08
	void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD44AD0
	void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xD449B8
	object CreateInstance(int initialCapacity) { }

	// RVA: 0xD44EB0
	void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_Collections_Generic_ListOfMessagePackObjectMessagePackSerializer 
{
	// Methods

	// RVA: 0xD44FC8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD4504C
	void PackToCore(Packer packer, System.Collections.Generic.List<MsgPack.MessagePackObject> objectTree) { }

	// RVA: 0xD45274
	System.Collections.Generic.List<MsgPack.MessagePackObject> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD45448
	void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection) { }

	// RVA: 0xD4535C
	void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection, int count) { }

	// RVA: 0xD454E8
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_Queue_1MessagePackSerializer<T0> 
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TItem> _itemSerializer; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x2FE47D4
	void PackToCore(Packer packer, System.Collections.Generic.Queue<TItem> objectTree) { }

	// RVA: 0x2FE36BC
	System.Collections.Generic.Queue<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x2FE47D4
	void UnpackToCore(Unpacker unpacker, System.Collections.Generic.Queue<TItem> collection) { }

	// RVA: -1
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_Stack_1MessagePackSerializer<T0> 
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TItem> _itemSerializer; // 0x0

	// Methods

	// RVA: 0x2FE4574
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x2FE47D4
	void PackToCore(Packer packer, System.Collections.Generic.Stack<TItem> objectTree) { }

	// RVA: 0x2FE36BC
	System.Collections.Generic.Stack<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x2FE47D4
	void UnpackToCore(Unpacker unpacker, System.Collections.Generic.Stack<TItem> collection) { }

	// RVA: 0x2FE3728
	System.Collections.Generic.IEnumerable<TItem> UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: -1
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_QueueMessagePackSerializer 
{
	// Methods

	// RVA: 0xD45564
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD455E8
	void PackToCore(Packer packer, Queue objectTree) { }

	// RVA: 0xD45884
	Queue UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD45968
	void UnpackToCore(Unpacker unpacker, Queue collection) { }

	// RVA: 0xD45AE4
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_NameValueCollectionMessagePackSerializer 
{
	// Methods

	// RVA: 0xD45B4C
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD45BD0
	void PackToCore(Packer packer, NameValueCollection objectTree) { }

	// RVA: 0xD45FB0
	NameValueCollection UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD463D4
	void UnpackToCore(Unpacker unpacker, NameValueCollection collection) { }

	// RVA: 0xD46084
	void UnpackToCore(Unpacker unpacker, NameValueCollection collection, int keyCount) { }

	// RVA: 0xD46474
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_StackMessagePackSerializer 
{
	// Methods

	// RVA: 0xD464DC
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD46560
	void PackToCore(Packer packer, Stack objectTree) { }

	// RVA: 0xD467FC
	Stack UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD46B34
	void UnpackToCore(Unpacker unpacker, Stack collection) { }

	// RVA: 0xD468CC
	ICollection UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: 0xD46E80
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_DBNullMessagePackSerializer 
{
	// Methods

	// RVA: 0xD46EE8
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD46F6C
	void PackToCore(Packer packer, DBNull objectTree) { }

	// RVA: 0xD46F88
	DBNull UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD46FDC
	DBNull UnpackNil() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Globalization_CultureInfoMessagePackSerializer 
{
	// Methods

	// RVA: 0xD47058
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD470DC
	void PackToCore(Packer packer, CultureInfo objectTree) { }

	// RVA: 0xD47120
	CultureInfo UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ObjectMessagePackSerializer 
{
	// Methods

	// RVA: 0xD471B0
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD47234
	void PackToCore(Packer packer, object value) { }

	// RVA: 0xD4733C
	object UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_StringMessagePackSerializer 
{
	// Methods

	// RVA: 0xD47678
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD476FC
	void PackToCore(Packer packer, string value) { }

	// RVA: 0xD4771C
	string UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Text_StringBuilderMessagePackSerializer 
{
	// Methods

	// RVA: 0xD477DC
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD47860
	void PackToCore(Packer packer, StringBuilder value) { }

	// RVA: 0xD478A4
	StringBuilder UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD47994
	void UnpackToCore(Unpacker unpacker, StringBuilder collection) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UriMessagePackSerializer 
{
	// Methods

	// RVA: 0xD47A68
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD47AEC
	void PackToCore(Packer packer, Uri objectTree) { }

	// RVA: 0xD47B30
	Uri UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_VersionMessagePackSerializer 
{
	// Methods

	// RVA: 0xD47BB0
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD47C34
	void PackToCore(Packer packer, Version objectTree) { }

	// RVA: 0xD47CAC
	Version UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampDateTimeMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3BB7C
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD47F38
	void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD47FE4
	DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampMessagePackSerializer 
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xD4808C
	void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xD48124
	void PackToCore(Packer packer, Timestamp objectTree) { }

	// RVA: 0xD482BC
	Timestamp UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampMessagePackSerializerProvider 
{
	// Fields
	private readonly MessagePackSerializer _unixEpoc; // 0x10
	private readonly MessagePackSerializer _native; // 0x18
	private readonly MessagePackSerializer _timestamp; // 0x20

	// Methods

	// RVA: 0xD48594
	void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD48A0C
	object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class UnixEpocDateTimeMessagePackSerializer 
{
	// Methods

	// RVA: 0xD3BA3C
	void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD48C40
	void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD48CDC
	DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityCollectionMessagePackSerializer 
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40
	private readonly MethodInfo _add; // 0x48

	// Methods

	// RVA: 0xD30FDC
	void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD48E50
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD49210
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD312B4
	object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD494A0
	void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializer<T0, T1, T2> 
{
	// Methods

	// RVA: 0x309AF8C
	int GetCount(TDictionary dictionary) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityDictionaryMessagePackSerializer 
{
	// Fields
	private readonly MessagePackSerializer _keySerializer; // 0x38
	private readonly MessagePackSerializer _valueSerializer; // 0x40
	private readonly MethodInfo _add; // 0x48
	private readonly MethodInfo _getCount; // 0x50
	private readonly MethodInfo _getKey; // 0x58
	private readonly MethodInfo _getValue; // 0x60

	// Methods

	// RVA: 0xD3155C
	void .ctor(SerializationContext ownerContext, Type targetType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD4958C
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD499F0
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD31860
	object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	object CreateInstance(int initialCapacity) { }

	// RVA: 0xD49EE8
	object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD49EF8
	void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD49A4C
	void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializerBase<T0, T1, T2> 
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x309AF8C
	void PackToCore(Packer packer, TDictionary objectTree) { }

	// RVA: 0x309AF8C
	int GetCount(TDictionary dictionary) { }

	// RVA: 0x309AF8C
	TDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x309AF8C
	TDictionary InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x309AF8C
	TDictionary CreateInstance(int initialCapacity) { }

	// RVA: 0x309AF8C
	void UnpackToCore(Unpacker unpacker, TDictionary collection, int itemsCount) { }

	// RVA: 0x309AF8C
	void AddItem(TDictionary dictionary, TKey key, TValue value) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityEnumerableMessagePackSerializer 
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40

	// Methods

	// RVA: 0xD31AB0
	void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD49FA0
	void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class EnumerableMessagePackSerializerBase<T0, T1> 
{
	// Methods

	// RVA: 0x309AF8C
	TCollection CreateInstance(int initialCapacity) { }

	// RVA: -1
	object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityEnumerableMessagePackSerializerBase 
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38

	// Methods

	// RVA: 0xD4A3AC
	MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xD48D6C
	void .ctor(SerializationContext ownerContext, Type targetType, Type itemType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	object CreateInstance(int initialCapacity) { }

	// RVA: 0xD4A3B4
	object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD4A3C4
	void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD4926C
	void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xD4A46C
	void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public interface ICollectionInstanceFactory 
{
	// Methods

	// RVA: -1
	object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericCollectionMessagePackSerializer 
{
	// Methods

	// RVA: 0xD2A7C8
	void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD2AFEC
	void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericDictionaryMessagePackSerializer 
{
	// Fields
	private readonly MessagePackSerializer _keySerializer; // 0x38
	private readonly MessagePackSerializer _valueSerializer; // 0x40

	// Methods

	// RVA: 0xD2C5A4
	void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD2C850
	void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD2CDBC
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD320CC
	object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	object CreateInstance(int initialCapacity) { }

	// RVA: 0xD4AA28
	object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD4AA38
	void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD4A5E8
	void UnpackToCore(Unpacker unpacker, IDictionary collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializer 
{
	// Methods

	// RVA: 0xD2BB68
	void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD2BC8C
	void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializerBase 
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38

	// Methods

	// RVA: 0xD4AB0C
	MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xD4A4A4
	void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	object CreateInstance(int initialCapacity) { }

	// RVA: 0xD4AB14
	object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD4AB24
	void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD2B538
	void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xD4ABCC
	void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericListMessagePackSerializer 
{
	// Methods

	// RVA: 0xD2D13C
	void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD2D3C4
	object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD32710
	object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD4AC04
	void AddItem(object collection, object item) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=52 
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails> 
{
	// Fields
	internal static readonly int 35CCB1599F52363510686EF38B7DB5E7998DB108; // 0x0
	internal static readonly __StaticArrayInitTypeSize=52 77C65B35B8FB1A6C68D5FDBBB7FB67CCABBAFB0E; // 0x4
	internal static readonly __StaticArrayInitTypeSize=52 CD29B993165FCDF5BD5B75645F026F1D1995CF75; // 0x38
	internal static readonly __StaticArrayInitTypeSize=52 D480A9E4D8884B63516CAAD7752399850F1D3A4E; // 0x6C
	internal static readonly __StaticArrayInitTypeSize=52 DD3AEFEADB1CD615F3017763F1568179FEE640B0; // 0xA0
	internal static readonly __StaticArrayInitTypeSize=52 E92B39D8233061927D9ACDE54665E68E7535635A; // 0xD4
}


