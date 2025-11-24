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

	// RVA: 0x316B894
	public <member>j__TPar get_member() { }

	// RVA: 0x316B894
	public <data>j__TPar get_data() { }

	// RVA: 0x316B894
	public void .ctor(<member>j__TPar member, <data>j__TPar data) { }

	// RVA: 0x30B183C
	public override bool Equals(object value) { }

	// RVA: 0x30B199C
	public override int GetHashCode() { }

	// RVA: 0x30B1CD4
	public override string ToString() { }

}

// Namespace: MsgPack
internal static class BigEndianBinary
{
	// Methods

	// RVA: 0xCE22F4
	public static Int16 ToInt16(Byte[] buffer, int offset) { }

	// RVA: 0xCE233C
	public static int ToInt32(Byte[] buffer, int offset) { }

	// RVA: 0xCE23B4
	public static Int64 ToInt64(Byte[] buffer, int offset) { }

	// RVA: 0xCE248C
	public static Byte ToByte(Byte[] buffer, int offset) { }

	// RVA: 0xCE24BC
	public static UInt16 ToUInt16(Byte[] buffer, int offset) { }

	// RVA: 0xCE2504
	public static UInt32 ToUInt32(Byte[] buffer, int offset) { }

	// RVA: 0xCE257C
	public static UInt64 ToUInt64(Byte[] buffer, int offset) { }

	// RVA: 0xCE2654
	public static float ToSingle(Byte[] buffer, int offset) { }

	// RVA: 0xCE2750
	public static Double ToDouble(Byte[] buffer, int offset) { }

}

// Namespace: MsgPack
internal static class Binary
{
	// Fields
	public static readonly Byte[] Empty; // 0x0

	// Methods

	// RVA: 0xCE287C
	public static string ToHexString(Byte[] blob) { }

	// RVA: 0xCE2904
	public static string ToHexString(Byte[] blob, bool withPrefix) { }

	// RVA: 0xCE2B3C
	public static void ToHexString(Byte[] blob, StringBuilder buffer) { }

	// RVA: 0xCE2A08
	private static void ToHexStringCore(Byte[] blob, StringBuilder buffer, bool withPrefix) { }

	// RVA: 0xCE2BC4
	private static Char ToHexChar(int b) { }

	// RVA: 0xCE2BE0
	public static int ToBits(float value) { }

	// RVA: 0xCE2BF0
	public static Int64 ToBits(Double value) { }

	// RVA: 0xCE2BF8
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class BufferManager
{
	// Methods

	// RVA: 0xCE2C78
	public static Byte[] NewByteBuffer(int size) { }

	// RVA: 0xCE2D00
	public static Char[] NewCharBuffer(int size) { }

}

// Namespace: MsgPack
public abstract class ByteArrayPacker
{
	// Methods

	// RVA: -1
	public abstract int get_BytesUsed() { }

	// RVA: -1
	public abstract int get_InitialBufferOffset() { }

	// RVA: 0xCE2D88
	protected void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCE2DF4
	public System.ArraySegment<System.Byte> GetResultBytes() { }

	// RVA: -1
	public abstract Byte[] GetFinalBuffer() { }

}

// Namespace: MsgPack
public abstract class ByteArrayUnpacker
{
	// Methods

	// RVA: 0xCE2EAC
	protected void .ctor() { }

}

// Namespace: MsgPack
internal abstract class ByteBufferAllocator
{
	// Methods

	// RVA: -1
	public abstract bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xCE2EB4
	protected void .ctor() { }

}

// Namespace: MsgPack
internal sealed class CollectionDebuggerProxy<T0>
{}

// Namespace: MsgPack
internal static class CollectionOperation
{
	// Methods

	// RVA: 0x316B894
	public static void CopyTo(System.Collections.Generic.IEnumerable<T> source, int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x316B894
	public static void CopyTo(System.Collections.Generic.IEnumerable<TSource> source, int sourceCount, int index, TDestination[] array, int arrayIndex, int count, System.Func<TSource,TDestination> converter) { }

	// RVA: 0x316B894
	private static void ValidateCopyToArguments(int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x316B894
	public static void CopyTo(System.Collections.Generic.IEnumerable<T> source, int sourceCount, Array array, int arrayIndex) { }

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

	// RVA: 0xCE2EBC
	public static bool EncodeString(Encoder source, Char[] chars, int charsOffset, int charsLength, Byte[] buffer, int bufferOffset, int bufferCount, int charsUsed, int bytesUsed) { }

	// RVA: 0xCE2F04
	public static bool DecodeString(Decoder source, Byte[] bytes, int bytesOffset, int bytesLength, Char[] buffer, StringBuilder result) { }

}

// Namespace: MsgPack
internal sealed class FixedArrayBufferAllocator
{
	// Fields
	public static readonly ByteBufferAllocator Instance; // 0x0

	// Methods

	// RVA: 0xCE3024
	private void .ctor() { }

	// RVA: 0xCE302C
	public override bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xCE3050
	private static void .cctor() { }

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

	// RVA: 0xCE2BE8
	public void .ctor(float value) { }

	// RVA: 0xCE26C4
	public void .ctor(Byte[] bigEndianBytes, int offset) { }

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

	// RVA: 0xCE2780
	public void .ctor(Byte[] bigEndianBytes, int offset) { }

}

// Namespace: MsgPack
[Serializable]
public sealed class InvalidMessagePackStreamException
{
	// Methods

	// RVA: 0xCE30BC
	public void .ctor() { }

	// RVA: 0xCE3140
	public void .ctor(string message) { }

	// RVA: 0xCE31D4
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xCE326C
	private void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: MsgPack
public interface IPackable
{
	// Methods

	// RVA: -1
	public abstract void PackToMessage(Packer packer, PackingOptions options) { }

}

// Namespace: MsgPack
internal interface IRootUnpacker
{
	// Methods

	// RVA: -1
	public abstract CollectionType get_CollectionType() { }

	// RVA: -1
	public abstract System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: -1
	public abstract void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: -1
	public abstract MessagePackObject get_LastReadData() { }

	// RVA: -1
	public abstract void set_LastReadData(MessagePackObject value) { }

	// RVA: -1
	public abstract bool ReadObject(bool isDeep, MessagePackObject result) { }

}

// Namespace: MsgPack
public interface IUnpackable
{
	// Methods

	// RVA: -1
	public abstract void UnpackFromMessage(Unpacker unpacker) { }

}

// Namespace: MsgPack
public static class KnownExtTypeCode
{
	// Methods

	// RVA: 0xCE32F0
	public static Byte get_Timestamp() { }

	// RVA: 0xCE32F8
	public static Byte get_MultidimensionalArray() { }

}

// Namespace: MsgPack
public static class KnownExtTypeName
{
	// Methods

	// RVA: 0xCE3300
	public static string get_Timestamp() { }

	// RVA: 0xCE3344
	public static string get_MultidimensionalArray() { }

}

// Namespace: MsgPack
[Serializable]
public sealed class MessageNotSupportedException
{
	// Methods

	// RVA: 0xCE3388
	public void .ctor() { }

	// RVA: 0xCE340C
	public void .ctor(string message) { }

	// RVA: 0xCE34A0
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xCE3538
	private void .ctor(SerializationInfo info, StreamingContext context) { }

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

	// RVA: 0xCE35BC
	public override int get_BytesUsed() { }

	// RVA: 0xCE35C8
	public override int get_InitialBufferOffset() { }

	// RVA: 0xCE35D0
	public void .ctor(Byte[] buffer, int startOffset, ByteBufferAllocator allocator, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCE37B4
	public override Byte[] GetFinalBuffer() { }

	// RVA: 0xCE37BC
	protected override void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xCE3898
	protected override void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xCE38B8
	protected override void WriteByte(Byte value) { }

	// RVA: 0xCE3AA8
	private void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xCE3878
	private void WriteBytes(Byte[] value) { }

	// RVA: 0xCE3974
	private void ThrowEofException(int requiredSize) { }

	// RVA: 0xCE3B78
	protected override void PackCore(bool value) { }

	// RVA: 0xCE3BA4
	protected override void PackCore(Byte value) { }

	// RVA: 0xCE3CB0
	protected override void PackCore(SByte value) { }

	// RVA: 0xCE3CD8
	protected override void PackCore(Int16 value) { }

	// RVA: 0xCE3E28
	protected override void PackCore(UInt16 value) { }

	// RVA: 0xCE3E64
	protected override void PackCore(int value) { }

	// RVA: 0xCE401C
	protected override void PackCore(UInt32 value) { }

	// RVA: 0xCE406C
	protected override void PackCore(Int64 value) { }

	// RVA: 0xCE42D4
	protected override void PackCore(UInt64 value) { }

	// RVA: 0xCE4338
	protected override void PackCore(float value) { }

	// RVA: 0xCE44F0
	protected override void PackCore(Double value) { }

	// RVA: 0xCE4738
	protected override void PackArrayHeaderCore(int length) { }

	// RVA: 0xCE4778
	protected override void PackMapHeaderCore(int length) { }

	// RVA: 0xCE47B4
	protected override void PackStringHeaderCore(int length) { }

	// RVA: 0xCE4810
	protected override void PackBinaryHeaderCore(int length) { }

	// RVA: 0xCE4844
	protected override void PackRawCore(string value) { }

	// RVA: 0xCE49FC
	protected override void PackRawCore(Byte[] value) { }

	// RVA: 0xCE4AAC
	protected override void PackBinaryCore(Byte[] value) { }

	// RVA: 0xCE4B2C
	protected override void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xCE4C68
	private void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xCE3BC8
	private void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xCE3D1C
	private void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xCE3EC8
	private void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xCE40F0
	private void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xCE4340
	private void WriteBytes(Byte header, float value) { }

	// RVA: 0xCE44F8
	private void WriteBytes(Byte header, Double value) { }

	// RVA: 0xCE4854
	private void WriteBytes(string value, bool allowStr8) { }

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

	// RVA: 0xCE4CC4
	public sealed override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xCE4D3C
	protected sealed override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCE4E20
	public sealed override MessagePackObject get_LastReadData() { }

	// RVA: 0xCE4E2C
	protected sealed override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCE4E38
	public sealed override bool get_IsArrayHeader() { }

	// RVA: 0xCE4E48
	public sealed override bool get_IsMapHeader() { }

	// RVA: 0xCE4E58
	public sealed override bool get_IsCollectionHeader() { }

	// RVA: 0xCE4E68
	public sealed override Int64 get_ItemsCount() { }

	// RVA: 0xCE50F4
	private CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xCE50FC
	private System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xCE5140
	private void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCE517C
	private MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xCE5188
	private void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCE5194
	internal override bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xCE51A4
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xCE539C
	private bool ReadBinaryCore(int length, int offset, Byte[] result) { }

	// RVA: 0xCE54E4
	private bool ReadStringCore(int length, int offset, string result) { }

	// RVA: 0xCE5684
	private bool ReadRawStringCore(int length, int offset, MessagePackString result) { }

	// RVA: 0xCE599C
	private bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xCE5A5C
	public sealed override bool ReadByte(Byte result) { }

	// RVA: 0xCE5B94
	private bool ReadByteSlow(ReadValueResult header, Byte[] source, int offset, Byte result) { }

	// RVA: 0xCE6050
	public sealed override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xCE6228
	private bool ReadNullableByteSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Byte>& result) { }

	// RVA: 0xCE631C
	public sealed override bool ReadSByte(SByte result) { }

	// RVA: 0xCE6448
	private bool ReadSByteSlow(ReadValueResult header, Byte[] source, int offset, SByte result) { }

	// RVA: 0xCE6760
	public sealed override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xCE692C
	private bool ReadNullableSByteSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.SByte>& result) { }

	// RVA: 0xCE6A20
	public sealed override bool ReadInt16(Int16 result) { }

	// RVA: 0xCE6B50
	private bool ReadInt16Slow(ReadValueResult header, Byte[] source, int offset, Int16 result) { }

	// RVA: 0xCE6E58
	public sealed override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xCE7028
	private bool ReadNullableInt16Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int16>& result) { }

	// RVA: 0xCE711C
	public sealed override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xCE7258
	private bool ReadUInt16Slow(ReadValueResult header, Byte[] source, int offset, UInt16 result) { }

	// RVA: 0xCE7510
	public sealed override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCE76EC
	private bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCE77E0
	public sealed override bool ReadInt32(int result) { }

	// RVA: 0xCE7910
	private bool ReadInt32Slow(ReadValueResult header, Byte[] source, int offset, int result) { }

	// RVA: 0xCE7C14
	public sealed override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xCE7DE4
	private bool ReadNullableInt32Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int32>& result) { }

	// RVA: 0xCE7ED8
	public sealed override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xCE8014
	private bool ReadUInt32Slow(ReadValueResult header, Byte[] source, int offset, UInt32 result) { }

	// RVA: 0xCE82F8
	public sealed override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCE84D4
	private bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCE85C8
	public sealed override bool ReadInt64(Int64 result) { }

	// RVA: 0xCE86F8
	private bool ReadInt64Slow(ReadValueResult header, Byte[] source, int offset, Int64 result) { }

	// RVA: 0xCE89E4
	public sealed override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xCE8BB4
	private bool ReadNullableInt64Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int64>& result) { }

	// RVA: 0xCE8CA8
	public sealed override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xCE8DE4
	private bool ReadUInt64Slow(ReadValueResult header, Byte[] source, int offset, UInt64 result) { }

	// RVA: 0xCE90B0
	public sealed override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCE928C
	private bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCE9380
	public sealed override bool ReadSingle(float result) { }

	// RVA: 0xCE94B4
	private bool ReadSingleSlow(ReadValueResult header, Byte[] source, int offset, float result) { }

	// RVA: 0xCE975C
	public sealed override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xCE9930
	private bool ReadNullableSingleSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Single>& result) { }

	// RVA: 0xCE9A24
	public sealed override bool ReadDouble(Double result) { }

	// RVA: 0xCE9B58
	private bool ReadDoubleSlow(ReadValueResult header, Byte[] source, int offset, Double result) { }

	// RVA: 0xCE9DF8
	public sealed override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xCE9FCC
	private bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Double>& result) { }

	// RVA: 0xCEA0C0
	public sealed override bool ReadBoolean(bool result) { }

	// RVA: 0xCEA228
	public sealed override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xCEA3FC
	public sealed override bool ReadBinary(Byte[] result) { }

	// RVA: 0xCEA800
	public sealed override bool ReadString(string result) { }

	// RVA: 0xCE59FC
	private bool ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xCEAA0C
	private bool ReadObjectCore(bool isDeep, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xCEAD64
	private bool ReadObjectSlow(ReadValueResult header, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xCEBB04
	private bool ReadItems(int count, bool isMap, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xCEBF68
	private bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] source, int offset, MessagePackExtendedTypeObject result) { }

	// RVA: 0xCECC4C
	protected sealed override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xCECD04
	public sealed override bool ReadObject(MessagePackObject result) { }

	// RVA: 0xCECD68
	protected sealed override bool ReadCore() { }

	// RVA: 0xCEC518
	private void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xCEA7EC
	private void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCECDD4
	private void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCEA608
	private void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xCE5E6C
	private void ThrowTypeException(Type type, ReadValueResult header) { }

}

// Namespace: MsgPack
internal static class MessagePackCode
{
	// Methods

	// RVA: 0xCECF88
	public static string ToString(int code) { }

}

// Namespace: MsgPack
public static class MessagePackConvert
{
	// Fields
	private static readonly Encoding _utf8NonBomStrict; // 0x0
	private static readonly Encoding _utf8NonBom; // 0x8
	private static readonly DateTime _unixEpocUtc; // 0x10

	// Methods

	// RVA: 0xCED19C
	internal static Encoding get_Utf8NonBom() { }

	// RVA: 0xCED218
	internal static Encoding get_Utf8NonBomStrict() { }

	// RVA: 0xCED294
	public static Byte[] EncodeString(string value) { }

	// RVA: 0xCED358
	public static string DecodeStringStrict(Byte[] value) { }

	// RVA: 0xCED424
	public static DateTimeOffset ToDateTimeOffset(Int64 value) { }

	// RVA: 0xCED504
	public static DateTime ToDateTime(Int64 value) { }

	// RVA: 0xCED5E0
	public static Int64 FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xCED6E4
	public static Int64 FromDateTime(DateTime value) { }

	// RVA: 0xCED7D0
	private static void .cctor() { }

}

// Namespace: MsgPack
public struct MessagePackExtendedTypeObject
{
	// Fields
	private readonly Byte _typeCode; // 0x10
	private readonly Byte[] _body; // 0x18

	// Methods

	// RVA: 0xCED8D4
	public Byte get_TypeCode() { }

	// RVA: 0xCED8DC
	internal Byte[] get_Body() { }

	// RVA: 0xCED96C
	public bool get_IsValid() { }

	// RVA: 0xCED97C
	private void .ctor(Byte[] body, Byte unpackedTypeCode) { }

	// RVA: 0xCECBC4
	public static MessagePackExtendedTypeObject Unpack(Byte typeCode, Byte[] body) { }

	// RVA: 0xCED9E8
	public override string ToString() { }

	// RVA: 0xCEDAB0
	internal void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xCEDD18
	public override int GetHashCode() { }

	// RVA: 0xCEDE98
	public override bool Equals(object obj) { }

	// RVA: 0xCEDFA8
	public bool Equals(MessagePackExtendedTypeObject other) { }

	// RVA: 0xCEE034
	public static bool op_Equality(MessagePackExtendedTypeObject left, MessagePackExtendedTypeObject right) { }

}

// Namespace: 
[Serializable]
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
[Serializable]
private sealed class ValueTypeCode
{
	// Fields
	private readonly MessagePackValueTypeCode _typeCode; // 0x10
	private readonly Type _type; // 0x18

	// Methods

	// RVA: 0xCF53C0
	public MessagePackValueTypeCode get_TypeCode() { }

	// RVA: 0xCEE570
	public bool get_IsSigned() { }

	// RVA: 0xCEE560
	public bool get_IsInteger() { }

	// RVA: 0xCF53C8
	public Type get_Type() { }

	// RVA: 0xCF5378
	internal void .ctor(Type type, MessagePackValueTypeCode typeCode) { }

	// RVA: 0xCF53D0
	public override string ToString() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.MessagePackObject.<>c <>9; // 0x0
	public static System.Func<System.Int32,MsgPack.MessagePackObject,System.Int32> <>9__84_0; // 0x8
	public static System.Func<System.Int32,System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>,System.Int32> <>9__84_1; // 0x10

	// Methods

	// RVA: 0xCF546C
	private static void .cctor() { }

	// RVA: 0xCF54D8
	public void .ctor() { }

	// RVA: 0xCF54E0
	internal int <GetHashCode>b__84_0(int hash, MessagePackObject item) { }

	// RVA: 0xCF5554
	internal int <GetHashCode>b__84_1(int hash, System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

}

// Namespace: MsgPack
[Serializable]
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

	// RVA: 0xCEE0C4
	public void .ctor(bool value) { }

	// RVA: 0xCEE140
	public void .ctor(int value) { }

	// RVA: 0xCEBEC8
	public void .ctor(Byte[] value, bool isBinary) { }

	// RVA: 0xCEE1BC
	public bool AsBoolean() { }

	// RVA: 0xCEE314
	public Byte AsByte() { }

	// RVA: 0xCEE57C
	public SByte AsSByte() { }

	// RVA: 0xCEE7DC
	public Int16 AsInt16() { }

	// RVA: 0xCEEA3C
	public UInt16 AsUInt16() { }

	// RVA: 0xCEB8B4
	public int AsInt32() { }

	// RVA: 0xCEEC44
	public UInt32 AsUInt32() { }

	// RVA: 0xCE4EEC
	public Int64 AsInt64() { }

	// RVA: 0xCEEE54
	public UInt64 AsUInt64() { }

	// RVA: 0xCEF054
	public float AsSingle() { }

	// RVA: 0xCEF214
	public Double AsDouble() { }

	// RVA: 0xCEF3D4
	public string AsString() { }

	// RVA: 0xCEF4AC
	public Byte[] AsBinary() { }

	// RVA: 0xCEF584
	public MessagePackExtendedTypeObject AsMessagePackExtendedTypeObject() { }

	// RVA: 0xCEF6A0
	public static MessagePackObject op_Implicit(bool value) { }

	// RVA: 0xCEC2BC
	public static MessagePackObject op_Implicit(Byte value) { }

	// RVA: 0xCEC0A0
	public static MessagePackObject op_Implicit(SByte value) { }

	// RVA: 0xCEC128
	public static MessagePackObject op_Implicit(Int16 value) { }

	// RVA: 0xCEBDB0
	public static MessagePackObject op_Implicit(UInt16 value) { }

	// RVA: 0xCEC1B0
	public static MessagePackObject op_Implicit(int value) { }

	// RVA: 0xCEBE38
	public static MessagePackObject op_Implicit(UInt32 value) { }

	// RVA: 0xCEC238
	public static MessagePackObject op_Implicit(Int64 value) { }

	// RVA: 0xCEC344
	public static MessagePackObject op_Implicit(UInt64 value) { }

	// RVA: 0xCEC3C8
	public static MessagePackObject op_Implicit(float value) { }

	// RVA: 0xCEC494
	public static MessagePackObject op_Implicit(Double value) { }

	// RVA: 0xCEF728
	public static MessagePackObject op_Implicit(string value) { }

	// RVA: 0xCEACD8
	public static MessagePackObject op_Implicit(Byte[] value) { }

	// RVA: 0xCEC018
	public static MessagePackObject op_Implicit(MessagePackExtendedTypeObject value) { }

	// RVA: 0xCEF7B0
	public static bool op_Explicit(MessagePackObject value) { }

	// RVA: 0xCEF8D4
	public static Byte op_Explicit(MessagePackObject value) { }

	// RVA: 0xCEFAD0
	public static SByte op_Explicit(MessagePackObject value) { }

	// RVA: 0xCEFCE8
	public static Int16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCEFF00
	public static UInt16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCF00E8
	public static int op_Explicit(MessagePackObject value) { }

	// RVA: 0xCF02F0
	public static UInt32 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCF04E0
	public static Int64 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCF06C8
	public static float op_Explicit(MessagePackObject value) { }

	// RVA: 0xCF086C
	public static Double op_Explicit(MessagePackObject value) { }

	// RVA: 0xCEE304
	public bool get_IsNil() { }

	// RVA: 0xCF0A10
	public void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCEC67C
	public void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value, bool isImmutable) { }

	// RVA: 0xCF0A7C
	public void .ctor(MessagePackObjectDictionary value) { }

	// RVA: 0xCECB40
	public void .ctor(MessagePackObjectDictionary value, bool isImmutable) { }

	// RVA: 0xCEBEC0
	internal void .ctor(MessagePackString messagePackString) { }

	// RVA: 0xCF1380
	public override bool Equals(object obj) { }

	// RVA: 0xCF1500
	public bool Equals(MessagePackObject other) { }

	// RVA: 0xCF1CD8
	private bool EqualsWhenValueType(MessagePackObject other, ValueTypeCode valueTypeCode, ValueTypeCode otherValuetypeCode) { }

	// RVA: 0xCF214C
	private static bool IntegerIntegerEquals(UInt64 left, ValueTypeCode leftTypeCode, UInt64 right, ValueTypeCode rightTypeCode) { }

	// RVA: 0xCF21BC
	private static bool IntegerSingleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xCF2298
	private static bool IntegerDoubleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xCF2370
	public override int GetHashCode() { }

	// RVA: 0xCF2654
	public override string ToString() { }

	// RVA: 0xCF26FC
	private void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xCF3290
	private static void ToStringBinary(StringBuilder buffer, bool isJson, MessagePackString asBinary) { }

	// RVA: -1
	public System.Nullable<System.Boolean> IsTypeOf() { }

	// RVA: 0xCF36F4
	public System.Nullable<System.Boolean> IsTypeOf(Type type) { }

	// RVA: 0xCF3DD0
	public bool get_IsRaw() { }

	// RVA: 0xCF3E80
	public Type get_UnderlyingType() { }

	// RVA: 0xCF3FB0
	public void PackToMessage(Packer packer, PackingOptions options) { }

	// RVA: 0xCF4D78
	public Char[] AsCharArray() { }

	// RVA: 0x316B894
	private static void VerifyUnderlyingType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x316B894
	private static void VerifyUnderlyingRawType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x30B71FC
	private static void ThrowCannotBeNilAs() { }

	// RVA: -1
	private static void ThrowInvalidTypeAs(MessagePackObject instance) { }

	// RVA: 0xCF4E00
	public static bool op_Equality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xCF20CC
	public static bool op_Inequality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xCF4E7C
	private static void .cctor() { }

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

	// RVA: 0xCF8D5C
	public System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> get_Current() { }

	// RVA: 0xCF8E54
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xCF8F98
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0xCF9154
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0xCF9264
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0xCF8EC0
	internal System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> GetCurrentStrict() { }

	// RVA: 0xCF9378
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCF8DDC
	internal void VerifyVersion() { }

	// RVA: 0xCF952C
	public void Dispose() { }

	// RVA: 0xCF9580
	public bool MoveNext() { }

	// RVA: 0xCF97C0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xCF9464
	internal void ResetCore() { }

}

// Namespace: 
private struct DictionaryEnumerator
{
	// Fields
	private IDictionaryEnumerator _underlying; // 0x10

	// Methods

	// RVA: 0xCF9888
	public object get_Current() { }

	// RVA: 0xCF9960
	public DictionaryEntry get_Entry() { }

	// RVA: 0xCF9A18
	public object get_Key() { }

	// RVA: 0xCF9AD0
	public object get_Value() { }

	// RVA: 0xCF9B80
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCF9CE4
	public bool MoveNext() { }

	// RVA: 0xCF9D98
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xCFA338
	public MessagePackObject get_Current() { }

	// RVA: 0xCFA468
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xCFA13C
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCFA578
	public void Dispose() { }

	// RVA: 0xCFA5CC
	public bool MoveNext() { }

	// RVA: 0xCFA644
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
public sealed class KeyCollection
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xCF9E50
	public int get_Count() { }

	// RVA: 0xCF9E70
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xCF9E78
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xCF9E80
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xCF9E84
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCF9EB8
	public void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xCF9F58
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xCF9FD4
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xCF9FF4
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xCFA034
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xCFA074
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xCFA0B4
	public Enumerator GetEnumerator() { }

	// RVA: 0xCFA1B0
	private System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xCFA274
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xCFABF4
	public MessagePackObject get_Current() { }

	// RVA: 0xCFAD28
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xCFA9F8
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCFAE3C
	public void Dispose() { }

	// RVA: 0xCFAE90
	public bool MoveNext() { }

	// RVA: 0xCFAF08
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
public sealed class ValueCollection
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xCFA70C
	public int get_Count() { }

	// RVA: 0xCFA72C
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xCFA734
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xCFA73C
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xCFA740
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCFA774
	public void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xCFA814
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xCFA890
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xCFA8B0
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xCFA8F0
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xCFA930
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xCFA970
	public Enumerator GetEnumerator() { }

	// RVA: 0xCFAA6C
	private System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xCFAB30
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xCFAFD0
	public void .ctor() { }

	// RVA: 0xCFAFD8
	internal bool <TryGetValue>b__0(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xCFB05C
	public void .ctor() { }

	// RVA: 0xCFB064
	internal bool <AddCore>b__0(MessagePackObject item) { }

	// RVA: 0xCFB0E8
	internal bool <AddCore>b__1(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass59_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xCFB16C
	public void .ctor() { }

	// RVA: 0xCFB174
	internal bool <RemoveCore>b__0(MessagePackObject item) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.MessagePackObjectDictionary.<>c <>9; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>,System.Collections.DictionaryEntry> <>9__64_0; // 0x8

	// Methods

	// RVA: 0xCFB1F8
	private static void .cctor() { }

	// RVA: 0xCFB264
	public void .ctor() { }

	// RVA: 0xCFB26C
	internal DictionaryEntry <System.Collections.ICollection.CopyTo>b__64_0(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> kv) { }

}

// Namespace: MsgPack
[Serializable]
public class MessagePackObjectDictionary
{
	// Fields
	private System.Collections.Generic.List<MsgPack.MessagePackObject> _keys; // 0x10
	private System.Collections.Generic.List<MsgPack.MessagePackObject> _values; // 0x18
	private System.Collections.Generic.Dictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject> _dictionary; // 0x20
	private int _version; // 0x28
	private bool _isFrozen; // 0x2C

	// Methods

	// RVA: 0xCF55D0
	public bool get_IsFrozen() { }

	// RVA: 0xCF55D8
	public int get_Count() { }

	// RVA: 0xCF5650
	public MessagePackObject get_Item(MessagePackObject key) { }

	// RVA: 0xCF5B28
	public void set_Item(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xCF61FC
	public KeyCollection get_Keys() { }

	// RVA: 0xCF6264
	public ValueCollection get_Values() { }

	// RVA: 0xCF62CC
	private System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Keys() { }

	// RVA: 0xCF6334
	private System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Values() { }

	// RVA: 0xCF639C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.get_IsReadOnly() { }

	// RVA: 0xCF63A4
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0xCF63AC
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0xCF63B4
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0xCF63BC
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0xCF6424
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0xCF67B8
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0xCF6970
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xCF6978
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xCF697C
	public void .ctor() { }

	// RVA: 0xCEC7EC
	public void .ctor(int initialCapacity) { }

	// RVA: 0xCF0B68
	public void .ctor(System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject> dictionary) { }

	// RVA: 0xCF5878
	private static void ThrowKeyNotNilException(string parameterName) { }

	// RVA: 0xCF6A34
	private static void ThrowDuplicatedKeyException(MessagePackObject key, string parameterName) { }

	// RVA: 0xCF5C84
	private void VerifyIsNotFrozen() { }

	// RVA: 0xCF65A8
	private static MessagePackObject ValidateObjectArgument(object obj, string parameterName) { }

	// RVA: 0xCF6B6C
	private static System.Nullable<MsgPack.MessagePackObject> TryValidateObjectArgument(object value) { }

	// RVA: 0xCF7178
	public bool ContainsKey(MessagePackObject key) { }

	// RVA: 0xCF7350
	public bool ContainsValue(MessagePackObject value) { }

	// RVA: 0xCF748C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Contains(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xCF76BC
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0xCF58D4
	public bool TryGetValue(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xCEC9E4
	public void Add(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xCF5CEC
	private void AddCore(MessagePackObject key, MessagePackObject value, bool allowOverwrite) { }

	// RVA: 0xCF7888
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Add(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xCF7B70
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0xCF7D2C
	public bool Remove(MessagePackObject key) { }

	// RVA: 0xCF7E78
	private bool RemoveCore(MessagePackObject key, MessagePackObject value, bool checkValue) { }

	// RVA: 0xCF81C8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Remove(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xCF84B0
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0xCF8648
	public void Clear() { }

	// RVA: 0xCF87C4
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.CopyTo(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>[] array, int arrayIndex) { }

	// RVA: 0xCF8900
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xCF8B74
	public Enumerator GetEnumerator() { }

	// RVA: 0xCF8B98
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.GetEnumerator() { }

	// RVA: 0xCF8C3C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xCF8CE0
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

}

// Namespace: MsgPack
[Serializable]
internal sealed class MessagePackObjectEqualityComparer
{
	// Fields
	private static readonly MessagePackObjectEqualityComparer _instance; // 0x0

	// Methods

	// RVA: 0xCFB414
	internal static MessagePackObjectEqualityComparer get_Instance() { }

	// RVA: 0xCFB490
	public void .ctor() { }

	// RVA: 0xCFB498
	public bool Equals(MessagePackObject x, MessagePackObject y) { }

	// RVA: 0xCFB518
	public int GetHashCode(MessagePackObject obj) { }

	// RVA: 0xCFB580
	private static void .cctor() { }

}

// Namespace: MsgPack
internal sealed class MessagePackStreamPacker
{
	// Fields
	private readonly Stream _destination; // 0x18
	private readonly Byte[] _scalarBuffer; // 0x20
	private readonly bool _ownsStream; // 0x28

	// Methods

	// RVA: 0xCFB5EC
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCFB850
	protected override void Dispose(bool disposing) { }

	// RVA: 0xCFB888
	protected override void WriteByte(Byte value) { }

	// RVA: 0xCFB8B0
	protected override void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xCFB918
	protected override void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xCFB8E4
	private void WriteBytes(Byte[] value) { }

	// RVA: 0xCFB9E4
	private void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xCFBA0C
	protected override void PackCore(bool value) { }

	// RVA: 0xCFBA38
	protected override void PackCore(Byte value) { }

	// RVA: 0xCFBB20
	protected override void PackCore(SByte value) { }

	// RVA: 0xCFBBAC
	protected override void PackCore(Int16 value) { }

	// RVA: 0xCFBCDC
	protected override void PackCore(UInt16 value) { }

	// RVA: 0xCFBD80
	protected override void PackCore(int value) { }

	// RVA: 0xCFBF0C
	protected override void PackCore(UInt32 value) { }

	// RVA: 0xCFBFC8
	protected override void PackCore(Int64 value) { }

	// RVA: 0xCFC1E8
	protected override void PackCore(UInt64 value) { }

	// RVA: 0xCFC2BC
	protected override void PackCore(float value) { }

	// RVA: 0xCFC408
	protected override void PackCore(Double value) { }

	// RVA: 0xCFC5C4
	protected override void PackArrayHeaderCore(int length) { }

	// RVA: 0xCFC604
	protected override void PackMapHeaderCore(int length) { }

	// RVA: 0xCFC640
	protected override void PackStringHeaderCore(int length) { }

	// RVA: 0xCFC708
	protected override void PackBinaryHeaderCore(int length) { }

	// RVA: 0xCFC7A4
	protected override void PackRawCore(string value) { }

	// RVA: 0xCFC8A4
	protected override void PackRawCore(Byte[] value) { }

	// RVA: 0xCFC9AC
	protected override void PackBinaryCore(Byte[] value) { }

	// RVA: 0xCFCA90
	protected override void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xCFCC24
	private void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xCFBAB8
	private void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xCFBC58
	private void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xCFBE50
	private void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xCFC0BC
	private void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xCFC2C4
	private void WriteBytes(Byte header, float value) { }

	// RVA: 0xCFC410
	private void WriteBytes(Byte header, Double value) { }

	// RVA: 0xCFC828
	private void WriteBytes(string value, bool allowStr8) { }

	// RVA: 0xCFCCEC
	private void WriteStringBody(string value) { }

	// RVA: 0xCFCDD8
	private void WriteStringBody(Char[] value, int remainingCharsLength) { }

	// RVA: 0xCFCEC4
	private static bool EncodeString(Encoder encoder, Char[] value, int startOffset, int count, Byte[] buffer, int charsUsed, int bytesUsed) { }

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

	// RVA: 0xCFCEFC
	public sealed override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xCFCF74
	protected sealed override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCFD058
	public sealed override MessagePackObject get_LastReadData() { }

	// RVA: 0xCFD064
	protected sealed override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCFD070
	public sealed override bool get_IsArrayHeader() { }

	// RVA: 0xCFD080
	public sealed override bool get_IsMapHeader() { }

	// RVA: 0xCFD090
	public sealed override Int64 get_ItemsCount() { }

	// RVA: 0xCFD11C
	public sealed override bool get_IsCollectionHeader() { }

	// RVA: 0xCFD12C
	private CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xCFD134
	private System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xCFD178
	private void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCFD1B4
	private MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xCFD1C0
	private void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCFD1CC
	internal override bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xCFD1DC
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xCFD374
	protected override void Dispose(bool disposing) { }

	// RVA: 0xCFD3E0
	protected void BeginReadSubtree() { }

	// RVA: 0xCFD3F0
	protected internal override void EndReadSubtree() { }

	// RVA: 0xCFD420
	private bool ReadBinaryCore(int length, Int64 offset, Byte[] result) { }

	// RVA: 0xCFD730
	private bool ReadStringCore(int length, Int64 offset, string result) { }

	// RVA: 0xCFDA08
	private bool ReadRawStringCore(int length, Int64 offset, MessagePackString result) { }

	// RVA: 0xCFDD30
	private bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xCFD5C8
	private void ThrowEofException(Int64 reading) { }

	// RVA: 0xCFDDF8
	public sealed override bool ReadByte(Byte result) { }

	// RVA: 0xCFDF44
	private bool ReadByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, Byte result) { }

	// RVA: 0xCFE460
	public sealed override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xCFE64C
	private bool ReadNullableByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Byte>& result) { }

	// RVA: 0xCFE740
	public sealed override bool ReadSByte(SByte result) { }

	// RVA: 0xCFE880
	private bool ReadSByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, SByte result) { }

	// RVA: 0xCFEBF0
	public sealed override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xCFEDD0
	private bool ReadNullableSByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.SByte>& result) { }

	// RVA: 0xCFEEC4
	public sealed override bool ReadInt16(Int16 result) { }

	// RVA: 0xCFF008
	private bool ReadInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, Int16 result) { }

	// RVA: 0xCFF378
	public sealed override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xCFF55C
	private bool ReadNullableInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int16>& result) { }

	// RVA: 0xCFF650
	public sealed override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xCFF7A0
	private bool ReadUInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt16 result) { }

	// RVA: 0xCFFAE8
	public sealed override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCFFCD8
	private bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCFFDCC
	public sealed override bool ReadInt32(int result) { }

	// RVA: 0xCFFEFC
	private bool ReadInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, int result) { }

	// RVA: 0xD00260
	public sealed override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD00444
	private bool ReadNullableInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int32>& result) { }

	// RVA: 0xD00538
	public sealed override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD00674
	private bool ReadUInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt32 result) { }

	// RVA: 0xD009B4
	public sealed override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD00BA4
	private bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD00C98
	public sealed override bool ReadInt64(Int64 result) { }

	// RVA: 0xD00DDC
	private bool ReadInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, Int64 result) { }

	// RVA: 0xD0112C
	public sealed override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD01310
	private bool ReadNullableInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int64>& result) { }

	// RVA: 0xD01404
	public sealed override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD01554
	private bool ReadUInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt64 result) { }

	// RVA: 0xD01884
	public sealed override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD01A74
	private bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD01B68
	public sealed override bool ReadSingle(float result) { }

	// RVA: 0xD01CB0
	private bool ReadSingleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, float result) { }

	// RVA: 0xD01FB4
	public sealed override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD0219C
	private bool ReadNullableSingleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Single>& result) { }

	// RVA: 0xD02290
	public sealed override bool ReadDouble(Double result) { }

	// RVA: 0xD023D8
	private bool ReadDoubleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, Double result) { }

	// RVA: 0xD026D4
	public sealed override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD028BC
	private bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Double>& result) { }

	// RVA: 0xD029B0
	public sealed override bool ReadBoolean(bool result) { }

	// RVA: 0xD02B2C
	public sealed override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD02D14
	public sealed override bool ReadBinary(Byte[] result) { }

	// RVA: 0xD0324C
	public sealed override bool ReadString(string result) { }

	// RVA: 0xCFDD94
	private bool ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xD03590
	private bool ReadObjectCore(bool isDeep, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xD0380C
	private bool ReadObjectSlow(ReadValueResult header, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xD04634
	private bool ReadItems(int count, bool isMap, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xD048B4
	private bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] buffer, Int64 offset, MessagePackExtendedTypeObject result) { }

	// RVA: 0xD04B10
	protected sealed override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD04BC8
	public sealed override bool ReadObject(MessagePackObject result) { }

	// RVA: 0xD04C30
	protected sealed override bool ReadCore() { }

	// RVA: 0xD049AC
	private void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xD03238
	private void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD04CA0
	private void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD03058
	private void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xCFE280
	private void ThrowTypeException(Type type, ReadValueResult header) { }

}

// Namespace: 
[Serializable]
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
[Serializable]
internal sealed class MessagePackString
{
	// Fields
	private static readonly DecoderFallbackException IsBinary; // 0x0
	private Byte[] _encoded; // 0x10
	private string _decoded; // 0x18
	private DecoderFallbackException _decodingError; // 0x20
	private BinaryType _type; // 0x28

	// Methods

	// RVA: 0xCFDC34
	public void .ctor(string decoded) { }

	// RVA: 0xCFDC74
	public void .ctor(Byte[] encoded, bool isBinary) { }

	// RVA: 0xD05198
	private void EncodeIfNeeded() { }

	// RVA: 0xD052A0
	private void DecodeIfNeeded() { }

	// RVA: 0xD053EC
	public string TryGetString() { }

	// RVA: 0xD05410
	public string GetString() { }

	// RVA: 0xD054D0
	public Byte[] UnsafeGetBuffer() { }

	// RVA: 0xD054D8
	public Byte[] GetBytes() { }

	// RVA: 0xD054FC
	public Type GetUnderlyingType() { }

	// RVA: 0xD055C4
	public override string ToString() { }

	// RVA: 0xD0567C
	public override int GetHashCode() { }

	// RVA: 0xD058E8
	public override bool Equals(object obj) { }

	// RVA: 0xD059CC
	private static bool EqualsEncoded(MessagePackString left, MessagePackString right) { }

	// RVA: 0xD05B3C
	private static bool SlowEquals(Byte[] x, Byte[] y) { }

	// RVA: 0xD05BC4
	private static void .cctor() { }

}

// Namespace: MsgPack
[Serializable]
public class MessageTypeException
{
	// Methods

	// RVA: 0xD05C64
	public void .ctor() { }

	// RVA: 0xD05104
	public void .ctor(string message) { }

	// RVA: 0xD05CE8
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xD05D80
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: MsgPack
internal sealed class PureAttribute
{
	// Methods

	// RVA: 0xD05E04
	public void .ctor() { }

}

// Namespace: MsgPack
public abstract class Packer
{
	// Fields
	private static int _defaultCompatibilityOptions; // 0x0
	private bool _isDisposed; // 0x10
	private readonly PackerCompatibilityOptions _compatibilityOptions; // 0x14

	// Methods

	// RVA: 0xD05E0C
	public static PackerCompatibilityOptions get_DefaultCompatibilityOptions() { }

	// RVA: 0xD05E70
	public PackerCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xCFB764
	protected void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD05E78
	public void Dispose() { }

	// RVA: 0xCFB884
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD05F10
	private void VerifyNotDisposed() { }

	// RVA: 0xD05F78
	private void ThrowObjectDisposedException() { }

	// RVA: -1
	protected abstract void WriteByte(Byte value) { }

	// RVA: 0xD05FCC
	protected virtual void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xD06344
	protected virtual void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xD06430
	public Packer Pack(SByte value) { }

	// RVA: 0xD064B0
	protected virtual void PackCore(SByte value) { }

	// RVA: 0xD06540
	protected bool TryPackInt8(Int64 value) { }

	// RVA: 0xD065A0
	public Packer Pack(Byte value) { }

	// RVA: 0xD06620
	protected virtual void PackCore(Byte value) { }

	// RVA: 0xD0662C
	protected bool TryPackUInt8(UInt64 value) { }

	// RVA: 0xD06680
	public Packer Pack(bool value) { }

	// RVA: 0xD06700
	protected virtual void PackCore(bool value) { }

	// RVA: 0xD06504
	protected bool TryPackTinySignedInteger(Int64 value) { }

	// RVA: 0xD0672C
	protected bool TryPackTinyUnsignedInteger(UInt64 value) { }

	// RVA: 0xD06768
	public Packer PackNull() { }

	// RVA: 0xD067EC
	private void PrivatePackNullCore() { }

	// RVA: 0xD062FC
	private static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xD067FC
	private static void ThrowCannotBeNegativeException(string parameterName) { }

	// RVA: 0xD068C4
	private static void ThrowMissingBodyOfExtTypeValueException(string parameterName) { }

	// RVA: 0xD06920
	private static void ThrowExtTypeIsProhibitedException() { }

	// RVA: 0xD06974
	public static Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD06B64
	public static Packer Create(Stream stream, bool ownsStream) { }

	// RVA: 0xD06A84
	public static Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions, bool ownsStream) { }

	// RVA: 0xD06C38
	public static ByteArrayPacker Create(Byte[] buffer, bool allowsBufferExpansion, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD06D18
	public Packer Pack(System.Nullable<System.SByte> value) { }

	// RVA: 0xD06E68
	public Packer Pack(System.Nullable<System.Byte> value) { }

	// RVA: 0xD06F9C
	public Packer Pack(System.Nullable<System.Int16> value) { }

	// RVA: 0xD0716C
	public Packer Pack(System.Nullable<System.UInt16> value) { }

	// RVA: 0xD07328
	public Packer Pack(System.Nullable<System.Int32> value) { }

	// RVA: 0xD074E4
	public Packer Pack(System.Nullable<System.UInt32> value) { }

	// RVA: 0xD076A0
	public Packer Pack(System.Nullable<System.Int64> value) { }

	// RVA: 0xD07874
	public Packer Pack(System.Nullable<System.UInt64> value) { }

	// RVA: 0xD07A48
	public Packer Pack(System.Nullable<System.Single> value) { }

	// RVA: 0xD07C1C
	public Packer Pack(System.Nullable<System.Double> value) { }

	// RVA: 0xD07DF0
	public Packer Pack(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD070EC
	public Packer Pack(Int16 value) { }

	// RVA: 0xD07F2C
	protected virtual void PackCore(Int16 value) { }

	// RVA: 0xD07FA8
	protected bool TryPackInt16(Int64 value) { }

	// RVA: 0xD072A4
	public Packer Pack(UInt16 value) { }

	// RVA: 0xD0801C
	protected virtual void PackCore(UInt16 value) { }

	// RVA: 0xD0808C
	protected bool TryPackUInt16(UInt64 value) { }

	// RVA: 0xD07460
	public Packer Pack(int value) { }

	// RVA: 0xD080F4
	protected virtual void PackCore(int value) { }

	// RVA: 0xD081AC
	protected bool TryPackInt32(Int64 value) { }

	// RVA: 0xD0761C
	public Packer Pack(UInt32 value) { }

	// RVA: 0xD08250
	protected virtual void PackCore(UInt32 value) { }

	// RVA: 0xD08300
	protected bool TryPackUInt32(UInt64 value) { }

	// RVA: 0xD077F0
	public Packer Pack(Int64 value) { }

	// RVA: 0xD08398
	protected virtual void PackCore(Int64 value) { }

	// RVA: 0xD084B0
	protected bool TryPackInt64(Int64 value) { }

	// RVA: 0xD079C4
	public Packer Pack(UInt64 value) { }

	// RVA: 0xD08584
	protected virtual void PackCore(UInt64 value) { }

	// RVA: 0xD08698
	protected bool TryPackUInt64(UInt64 value) { }

	// RVA: 0xD07B98
	public Packer Pack(float value) { }

	// RVA: 0xD0876C
	protected virtual void PackCore(float value) { }

	// RVA: 0xD07D6C
	public Packer Pack(Double value) { }

	// RVA: 0xD08810
	protected virtual void PackCore(Double value) { }

	// RVA: 0xD088E8
	public Packer PackArrayHeader(int count) { }

	// RVA: 0xD089D4
	protected virtual void PackArrayHeaderCore(int count) { }

	// RVA: 0xD08A7C
	public Packer PackMapHeader(int count) { }

	// RVA: 0xD08B68
	protected virtual void PackMapHeaderCore(int count) { }

	// RVA: 0xD08C0C
	public Packer PackStringHeader(int length) { }

	// RVA: 0xD08CF8
	public Packer PackBinaryHeader(int length) { }

	// RVA: 0xD08E08
	protected virtual void PackStringHeaderCore(int length) { }

	// RVA: 0xD08EDC
	protected virtual void PackBinaryHeaderCore(int length) { }

	// RVA: 0xD08F84
	public Packer PackRaw(Byte[] value) { }

	// RVA: 0xD09030
	protected virtual void PackRawCore(Byte[] value) { }

	// RVA: 0xD09080
	public Packer PackBinary(Byte[] value) { }

	// RVA: 0xD09158
	protected virtual void PackBinaryCore(Byte[] value) { }

	// RVA: 0xD091A8
	public Packer PackString(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xD09348
	public Packer PackString(string value) { }

	// RVA: 0xD093A0
	protected virtual void PackStringCore(string value, Encoding encoding) { }

	// RVA: 0xD094FC
	protected virtual void PackRawCore(string value) { }

	// RVA: 0xD09290
	private void PackRawCore(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xD0953C
	public Packer PackRawBody(Byte[] value) { }

	// RVA: 0xD0965C
	public Packer PackRawBody(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xD09774
	private int PrivatePackRawBodyCore(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xD09AF4
	private int PrivatePackRawBodyCore(System.Collections.Generic.ICollection<System.Byte> value, bool isImmutable) { }

	// RVA: 0xD09BFC
	public Packer PackExtendedTypeValue(Byte typeCode, Byte[] body) { }

	// RVA: 0xD09D8C
	public Packer PackExtendedTypeValue(MessagePackExtendedTypeObject mpeto) { }

	// RVA: 0xD09EF8
	protected virtual void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xD0A038
	private static void .cctor() { }

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

	// RVA: 0x316B894
	public static Packer Pack(Packer source, T value) { }

	// RVA: 0x316B894
	private static void PackCore(Packer source, T value, SerializationContext context) { }

	// RVA: 0xD0A08C
	public static Packer PackObject(Packer source, object value) { }

	// RVA: 0xD0A22C
	public static Packer PackObject(Packer source, object value, SerializationContext context) { }

	// RVA: 0xD0A154
	private static void PackObjectCore(Packer source, object value, SerializationContext context) { }

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

	// RVA: 0xD0A2C0
	private static bool ShouldWrapStream(Stream stream) { }

	// RVA: 0xD0A384
	public bool get_WithBuffering() { }

	// RVA: 0xD0A38C
	public void set_WithBuffering(bool value) { }

	// RVA: 0xD0A394
	public bool get_OwnsStream() { }

	// RVA: 0xD0A39C
	public void set_OwnsStream(bool value) { }

	// RVA: 0xD0A3A4
	public void .ctor() { }

	// RVA: 0xCFB790
	internal Stream WrapStream(Stream stream) { }

	// RVA: 0xD0A3B4
	private static void .cctor() { }

}

// Namespace: MsgPack
public sealed class PackingOptions
{
	// Fields
	private Encoding _stringEncoding; // 0x10

	// Methods

	// RVA: 0xD0A59C
	public void .ctor() { }

}

// Namespace: MsgPack
internal sealed class PreserveAttribute
{
	// Fields
	public bool AllMembers; // 0x10

	// Methods

	// RVA: 0xD0A670
	public void .ctor() { }

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
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.ReadValueResults.<>c <>9; // 0x0

	// Methods

	// RVA: 0xD0B324
	private static void .cctor() { }

	// RVA: 0xD0B390
	public void .ctor() { }

	// RVA: 0xD0B398
	internal ReadValueResult <.cctor>b__5_0(int i) { }

	// RVA: 0xD0B3A0
	internal ReadValueResult <.cctor>b__5_1(int i) { }

	// RVA: 0xD0B3B0
	internal ReadValueResult <.cctor>b__5_2(int i) { }

	// RVA: 0xD0B3C0
	internal ReadValueResult <.cctor>b__5_3(int i) { }

	// RVA: 0xD0B3CC
	internal ReadValueResult <.cctor>b__5_4(int b) { }

	// RVA: 0xD0B3D4
	internal MessagePackObject <.cctor>b__5_5(int x) { }

	// RVA: 0xD0B400
	internal MessagePackObject <.cctor>b__5_6(int x) { }

	// RVA: 0xD0B42C
	internal MessagePackObject <.cctor>b__5_7(int x) { }

	// RVA: 0xD0B458
	internal MessagePackObject <.cctor>b__5_8(int x) { }

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

	// RVA: 0xD04E58
	public static Byte ToByte(ReadValueResult source) { }

	// RVA: 0xD0A678
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class ReflectionAbstractions
{
	// Fields
	public static readonly Char TypeDelimiter; // 0x0
	public static readonly Type[] EmptyTypes; // 0x8

	// Methods

	// RVA: 0xD0B484
	public static bool GetIsValueType(Type source) { }

	// RVA: 0xD0B49C
	public static bool GetIsEnum(Type source) { }

	// RVA: 0xD0B4C0
	public static bool GetIsInterface(Type source) { }

	// RVA: 0xD0B4D8
	public static bool GetIsAbstract(Type source) { }

	// RVA: 0xD0B4F0
	public static bool GetIsGenericType(Type source) { }

	// RVA: 0xD0B514
	public static bool GetIsGenericTypeDefinition(Type source) { }

	// RVA: 0xD0B538
	public static Assembly GetAssembly(Type source) { }

	// RVA: 0xD0B55C
	public static bool GetIsVisible(Type source) { }

	// RVA: 0xD0B574
	public static bool GetIsNestedPublic(Type source) { }

	// RVA: 0xD0B58C
	public static Type GetBaseType(Type source) { }

	// RVA: 0xD0B5B0
	public static MethodInfo GetRuntimeMethod(Type source, string name, Type[] parameters) { }

	// RVA: 0xD0B5D8
	public static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetRuntimeMethods(Type source) { }

	// RVA: 0xD0B600
	public static Delegate CreateDelegate(MethodInfo source, Type delegateType) { }

	// RVA: 0xD0B614
	public static Delegate CreateDelegate(MethodInfo source, Type delegateType, object target) { }

	// RVA: 0xD0B62C
	public static string GetCultureName(AssemblyName source) { }

	// RVA: 0xD0B65C
	public static bool GetHasDefaultValue(ParameterInfo source) { }

	// RVA: 0xD0B6E4
	private static void .cctor() { }

}

// Namespace: MsgPack
internal sealed class SingleArrayBufferAllocator
{
	// Fields
	public static readonly SingleArrayBufferAllocator Default; // 0x0
	private readonly System.Func<System.Byte[],System.Int32,System.Byte[]> _allocator; // 0x10

	// Methods

	// RVA: 0xD0B76C
	public void .ctor(System.Func<System.Byte[],System.Int32,System.Byte[]> allocator) { }

	// RVA: 0xD0B7A0
	private static Byte[] Allocate(Byte[] old, int requestSize) { }

	// RVA: 0xD0B8B8
	public override bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xD0B984
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class StringEscape
{
	// Methods

	// RVA: 0xD0BA4C
	public static string ForDisplay(string value) { }

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

	// RVA: 0xD0BD58
	public override Int64 get_ItemsCount() { }

	// RVA: 0xD0BE24
	public override bool get_IsArrayHeader() { }

	// RVA: 0xD0BED4
	public override bool get_IsMapHeader() { }

	// RVA: 0xD0BF84
	public override bool get_IsCollectionHeader() { }

	// RVA: 0xD0C034
	public override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xD0C108
	protected override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD0C1F0
	public override MessagePackObject get_LastReadData() { }

	// RVA: 0xD0C2A8
	protected override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xD0C368
	public void .ctor(Unpacker parent) { }

	// RVA: 0xD0C370
	private void .ctor(Unpacker root, SubtreeUnpacker parent) { }

	// RVA: 0xD0C69C
	protected override void Dispose(bool disposing) { }

	// RVA: 0xD0C718
	public override void Drain() { }

	// RVA: 0xD0C758
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD0C9A4
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD0CB50
	private static void ThrowInTailException() { }

	// RVA: 0xD0CBA4
	private static void ThrowNotInHeadOfCollectionException() { }

	// RVA: 0xD0CBF8
	protected override bool ReadCore() { }

	// RVA: 0xD0CE7C
	protected override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD0C82C
	private void DiscardCompletedStacks() { }

	// RVA: 0xD0CFDC
	public override bool ReadBoolean(bool result) { }

	// RVA: 0xD0D2B0
	public override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD0D584
	public override bool ReadByte(Byte result) { }

	// RVA: 0xD0D858
	public override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD0DB2C
	public override bool ReadSByte(SByte result) { }

	// RVA: 0xD0DE00
	public override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD0E0D4
	public override bool ReadInt16(Int16 result) { }

	// RVA: 0xD0E3A8
	public override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD0E67C
	public override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD0E950
	public override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD0EC24
	public override bool ReadInt32(int result) { }

	// RVA: 0xD0EEF8
	public override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD0F1CC
	public override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD0F4A0
	public override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD0F774
	public override bool ReadInt64(Int64 result) { }

	// RVA: 0xD0FA48
	public override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD0FD1C
	public override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD0FFF0
	public override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD102C4
	public override bool ReadSingle(float result) { }

	// RVA: 0xD10598
	public override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD1086C
	public override bool ReadDouble(Double result) { }

	// RVA: 0xD10B40
	public override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD10E14
	public override bool ReadBinary(Byte[] result) { }

	// RVA: 0xD110D8
	public override bool ReadString(string result) { }

	// RVA: 0xD1139C
	public override bool ReadObject(MessagePackObject result) { }

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

	// RVA: 0xD13214
	public void .ctor(Timestamp encoded) { }

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

	// RVA: 0xD116D4
	public int CompareTo(Timestamp other) { }

	// RVA: 0xD1173C
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xD118AC
	public override bool Equals(object obj) { }

	// RVA: 0xD1198C
	public bool Equals(Timestamp other) { }

	// RVA: 0xD119B0
	public override int GetHashCode() { }

	// RVA: 0xD11A04
	private Int64 ToTicks(Type destination) { }

	// RVA: 0xD11B9C
	public DateTime ToDateTime() { }

	// RVA: 0xD11C74
	public DateTimeOffset ToDateTimeOffset() { }

	// RVA: 0xD11D7C
	public MessagePackExtendedTypeObject Encode() { }

	// RVA: 0xD11FE4
	private static void FromDateTimeTicks(Int64 ticks, Int64 unixEpocSeconds, int nanoSeconds) { }

	// RVA: 0xD1206C
	private static void FromOffsetTicks(Int64 ticks, Int64 unixEpocSeconds, int nanoSeconds) { }

	// RVA: 0xD1222C
	public static Timestamp FromDateTime(DateTime value) { }

	// RVA: 0xD124C4
	public static Timestamp FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xD12644
	public static Timestamp Decode(MessagePackExtendedTypeObject value) { }

	// RVA: 0xD1283C
	public static Timestamp op_Implicit(DateTimeOffset value) { }

	// RVA: 0xD12438
	public void .ctor(Int64 unixEpochSeconds, int nanoseconds) { }

	// RVA: 0xD121B0
	internal static Int64 DivRem(Int64 dividend, Int64 divisor, Int64 remainder) { }

	// RVA: 0xD128C8
	public int get_Hour() { }

	// RVA: 0xD12A24
	public int get_Minute() { }

	// RVA: 0xD12B80
	public int get_Second() { }

	// RVA: 0xD12BB8
	private void GetDatePart(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD12F14
	private void GetDatePartAD(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD12C94
	private void GetDatePartBC(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD13140
	public override string ToString() { }

	// RVA: 0xD131C8
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xD134C4
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class TimestampStringConverter
{
	// Methods

	// RVA: 0xD1338C
	public static string ToString(string format, IFormatProvider formatProvider, Value value) { }

	// RVA: 0xD136CC
	private static string ToIso8601String(IFormatProvider formatProvider, bool containsNanosecons, Value value) { }

}

// Namespace: MsgPack
[Serializable]
public sealed class UnassignedMessageTypeException
{
	// Methods

	// RVA: 0xD13918
	public void .ctor() { }

	// RVA: 0xD13974
	public void .ctor(string message) { }

	// RVA: 0xD139DC
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xD13A50
	private void .ctor(SerializationInfo info, StreamingContext context) { }

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

	// RVA: 0xD143F4
	public void .ctor(int <>1__state) { }

	// RVA: 0xD16944
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD16948
	private bool MoveNext() { }

	// RVA: 0xD16A30
	private MessagePackObject System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject>.get_Current() { }

	// RVA: 0xD16A3C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xD16A7C
	private object System.Collections.IEnumerator.get_Current() { }

}

// Namespace: MsgPack
public abstract class Unpacker
{
	// Fields
	private UnpackerMode _mode; // 0x10

	// Methods

	// RVA: -1
	public abstract System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: -1
	protected abstract void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD13A58
	public virtual MessagePackObject get_LastReadData() { }

	// RVA: 0xD13B50
	protected virtual void set_LastReadData(MessagePackObject value) { }

	// RVA: -1
	public abstract bool get_IsArrayHeader() { }

	// RVA: -1
	public abstract bool get_IsMapHeader() { }

	// RVA: 0xD13BF8
	public virtual bool get_IsCollectionHeader() { }

	// RVA: -1
	public abstract Int64 get_ItemsCount() { }

	// RVA: 0xD13C40
	internal void VerifyMode(UnpackerMode mode) { }

	// RVA: 0xD13C8C
	internal void VerifyIsNotDisposed() { }

	// RVA: 0xD13DFC
	private void ThrowObjectDisposedException() { }

	// RVA: 0xD13D10
	internal void ThrowInvalidModeException() { }

	// RVA: 0xD13E68
	internal virtual bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xD13E78
	public static Unpacker Create(Stream stream, bool ownsStream) { }

	// RVA: 0xD13F5C
	public static Unpacker Create(Stream stream, PackerUnpackerStreamOptions streamOptions, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD14004
	public static ByteArrayUnpacker Create(Byte[] source, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD14098
	public static ByteArrayUnpacker Create(Byte[] source, int startOffset, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD14140
	protected void .ctor() { }

	// RVA: 0xD14148
	public void Dispose() { }

	// RVA: 0xD141DC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD141E0
	public virtual void Drain() { }

	// RVA: 0xD141E4
	public Unpacker ReadSubtree() { }

	// RVA: 0xD141F4
	internal virtual Unpacker InternalReadSubtree() { }

	// RVA: 0xD14204
	internal static void ThrowCannotBeSubtreeModeException() { }

	// RVA: 0xD14258
	internal static void ThrowInSubtreeModeException() { }

	// RVA: -1
	protected abstract Unpacker ReadSubtreeCore() { }

	// RVA: 0xD142AC
	protected internal virtual void EndReadSubtree() { }

	// RVA: 0xD142BC
	public bool Read() { }

	// RVA: 0xD14324
	internal bool ReadInternal() { }

	// RVA: 0xD14378
	internal virtual void EnsureNotInSubtreeMode() { }

	// RVA: 0xD142B4
	private void SetStable() { }

	// RVA: -1
	protected abstract bool ReadCore() { }

	// RVA: 0xD1437C
	public System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> GetEnumerator() { }

	// RVA: 0xD14420
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD14498
	public System.Nullable<System.Int64> Skip() { }

	// RVA: 0xD14570
	private void BeginSkip() { }

	// RVA: 0xD145AC
	private void EndSkip(System.Nullable<System.Int64> result) { }

	// RVA: -1
	protected abstract System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD1463C
	public MessagePackObject ReadItemData() { }

	// RVA: 0xD14780
	internal virtual void ThrowEofException() { }

	// RVA: 0xD14714
	public MessagePackObject UnpackSubtreeData() { }

	// RVA: 0xD147D4
	internal bool UnpackSubtreeDataCore(MessagePackObject result) { }

	// RVA: 0xD14D50
	public virtual bool ReadBoolean(bool result) { }

	// RVA: 0xD14E2C
	public virtual bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD14F84
	public virtual bool ReadByte(Byte result) { }

	// RVA: 0xD15060
	public virtual bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD151B8
	public virtual bool ReadSByte(SByte result) { }

	// RVA: 0xD15294
	public virtual bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD153EC
	public virtual bool ReadInt16(Int16 result) { }

	// RVA: 0xD154C8
	public virtual bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD1563C
	public virtual bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD15718
	public virtual bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD1588C
	public virtual bool ReadInt32(int result) { }

	// RVA: 0xD15968
	public virtual bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD15AE0
	public virtual bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD15BBC
	public virtual bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD15D34
	public virtual bool ReadInt64(Int64 result) { }

	// RVA: 0xD15E18
	public virtual bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD15F94
	public virtual bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD16078
	public virtual bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD161F4
	public virtual bool ReadSingle(float result) { }

	// RVA: 0xD162D4
	public virtual bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD1644C
	public virtual bool ReadDouble(Double result) { }

	// RVA: 0xD1652C
	public virtual bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD166A8
	public virtual bool ReadBinary(Byte[] result) { }

	// RVA: 0xD167A0
	public virtual bool ReadString(string result) { }

	// RVA: 0xD16898
	public virtual bool ReadObject(MessagePackObject result) { }

}

// Namespace: MsgPack
internal sealed class FastStreamUnpacker
{
	// Methods

	// RVA: 0xD13FFC
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD16AE4
	protected override Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingStreamUnpacker
{
	// Fields
	private bool _isSubtreeReading; // 0x60

	// Methods

	// RVA: 0xD13FF4
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD16B0C
	internal override Unpacker InternalReadSubtree() { }

	// RVA: 0xD16BF4
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD16C5C
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD16C68
	internal override void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
internal sealed class FastByteArrayUnpacker
{
	// Methods

	// RVA: 0xD14138
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xD16CF8
	protected override Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingByteArrayUnpacker
{
	// Fields
	private bool _isSubtreeReading; // 0x48

	// Methods

	// RVA: 0xD14130
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xD16CFC
	internal override Unpacker InternalReadSubtree() { }

	// RVA: 0xD16DE4
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD16E4C
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD16E58
	internal override void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
public sealed class UnpackerOptions
{
	// Fields
	private UnpackerValidationLevel <ValidationLevel>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD16EE8
	public UnpackerValidationLevel get_ValidationLevel() { }

	// RVA: 0xD16EF0
	public void set_ValidationLevel(UnpackerValidationLevel value) { }

	// RVA: 0xD16EF8
	public void .ctor() { }

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

	// RVA: 0xD16F24
	public static int Read(int field) { }

	// RVA: 0xD16F2C
	public static void Write(int field, int value) { }

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

	// RVA: 0xD16F34
	public CollectionKind get_CollectionType() { }

	// RVA: 0xD16FE0
	public void .ctor(CollectionDetailedKind type, Type elementType, MethodInfo getEnumeratorMethod, MethodInfo addMethod, MethodInfo countPropertyGetter) { }

	// RVA: 0xD1704C
	private static void .cctor() { }

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

	// RVA: 0xD1719C
	public string get_Name() { }

	// RVA: 0xD171A4
	public int get_Id() { }

	// RVA: 0xD171AC
	public NilImplication get_NilImplication() { }

	// RVA: 0xD171B4
	public void .ctor() { }

	// RVA: 0xD171F0
	public void .ctor(MemberInfo member) { }

	// RVA: 0xD17248
	public void .ctor(MemberInfo member, string name, NilImplication nilImplication, System.Nullable<System.Int32> id) { }

	// RVA: 0xD175B8
	private static void .cctor() { }

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

	// RVA: 0xD1763C
	public static DateTimeConversionMethod DetermineDateTimeConversionMethod(SerializationContext context, DateTimeMemberConversionMethod dateTimeMemberConversionMethod) { }

	// RVA: 0xD176C0
	internal static bool IsDateTime(Type dateTimeType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DefaultConcreteTypeRepository
{
	// Fields
	private readonly TypeKeyRepository _defaultCollectionTypes; // 0x10

	// Methods

	// RVA: 0xD17884
	internal void .ctor() { }

	// RVA: 0xD17DB8
	public Type Get(Type abstractCollectionType) { }

	// RVA: 0xD17F14
	internal Type GetConcreteType(Type abstractCollectionType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DictionarySerlaizationOptions
{
	// Fields
	private bool _omitNullEntry; // 0x10
	private System.Func<System.String,System.String> _keyNameHandler; // 0x18

	// Methods

	// RVA: 0xD18020
	public bool get_OmitNullEntry() { }

	// RVA: 0xD18044
	public System.Func<System.String,System.String> get_KeyTransformer() { }

	// RVA: 0xD18068
	internal System.Func<System.String,System.String> get_SafeKeyTransformer() { }

	// RVA: 0xD1810C
	public void .ctor() { }

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

	// RVA: 0xD18114
	protected void .ctor(SerializationContext ownerContext, Type targetType, EnumSerializationMethod serializationMethod) { }

	// RVA: 0xD18790
	protected internal sealed override void PackToCore(Packer packer, object objectTree) { }

	// RVA: -1
	protected internal abstract void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xD18874
	protected internal sealed override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected internal abstract object UnpackFromUnderlyingValue(MessagePackObject messagePackObject) { }

	// RVA: 0xD18D40
	private ICustomizableEnumSerializer MsgPack.Serialization.ICustomizableEnumSerializer.GetCopyAs(EnumSerializationMethod method) { }

}

// Namespace: MsgPack.Serialization
public static class EnumMessagePackSerializerHelpers
{
	// Methods

	// RVA: 0xD18DE8
	public static EnumSerializationMethod DetermineEnumSerializationMethod(SerializationContext context, Type enumType, EnumMemberSerializationMethod enumMemberSerializationMethod) { }

}

// Namespace: MsgPack.Serialization
internal sealed class EnumMessagePackSerializerProvider
{
	// Fields
	private readonly Type _enumType; // 0x10
	private readonly object _serializerForName; // 0x18
	private readonly object _serializerForIntegral; // 0x20

	// Methods

	// RVA: 0xD18FAC
	public void .ctor(Type enumType, ICustomizableEnumSerializer serializer) { }

	// RVA: 0xD19100
	public override object Get(SerializationContext context, object providerParameter) { }

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

	// RVA: 0xD18FA0
	public EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xD191D4
	public System.Func<System.String,System.String> get_NameTransformer() { }

	// RVA: 0xD186EC
	internal System.Func<System.String,System.String> get_SafeNameTransformer() { }

	// RVA: 0xD191F8
	public void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class ExtTypeCodeMapping
{
	// Fields
	private readonly object _syncRoot; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.String,System.Byte> _index; // 0x18
	private readonly System.Collections.Generic.Dictionary<System.Byte,System.String> _types; // 0x20

	// Methods

	// RVA: 0xD19200
	public Byte get_Item(string name) { }

	// RVA: 0xD194F8
	internal void .ctor() { }

	// RVA: 0xD19840
	public bool Add(string name, Byte typeCode) { }

	// RVA: 0xD19668
	private bool AddInternal(string name, Byte typeCode) { }

	// RVA: 0xD19950
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Byte>> GetEnumerator() { }

	// RVA: 0xD19A84
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD193E8
	private static void ValidateName(string name) { }

	// RVA: 0xD198E0
	private static void ValidateTypeCode(Byte typeCode) { }

}

// Namespace: MsgPack.Serialization
internal interface ICustomizableEnumSerializer
{
	// Methods

	// RVA: -1
	public abstract ICustomizableEnumSerializer GetCopyAs(EnumSerializationMethod method) { }

}

// Namespace: MsgPack.Serialization
internal interface INilImplicationHandlerOnUnpackedParameter<T0>
{
	// Methods

	// RVA: -1
	public abstract TAction get_Store() { }

}

// Namespace: MsgPack.Serialization
internal interface INilImplicationHandlerParameter
{
	// Methods

	// RVA: -1
	public abstract Type get_ItemType() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.Serialization.KeyNameTransformers.<>c <>9; // 0x0

	// Methods

	// RVA: 0xD19B5C
	private static void .cctor() { }

	// RVA: 0xD19BC8
	public void .ctor() { }

	// RVA: 0xD19BD0
	internal string <.cctor>b__3_0(string key) { }

}

// Namespace: MsgPack.Serialization
internal static class KeyNameTransformers
{
	// Fields
	public static readonly System.Func<System.String,System.String> AsIs; // 0x0

	// Methods

	// RVA: 0xD19A88
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class LazyDelegatingMessagePackSerializer<T0>
{
	// Fields
	private readonly object _providerParameter; // 0x0
	private MsgPack.Serialization.MessagePackSerializer<T> _delegated; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(SerializationContext ownerContext, object providerParameter) { }

	// RVA: 0x30B1CD4
	private MsgPack.Serialization.MessagePackSerializer<T> GetDelegatedSerializer() { }

	// RVA: 0x316B894
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x316B894
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x316B894
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x30B1CD4
	public override string ToString() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackDateTimeMemberAttribute
{
	// Fields
	private DateTimeMemberConversionMethod <DateTimeConversionMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD19BD8
	public DateTimeMemberConversionMethod get_DateTimeConversionMethod() { }

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

	// RVA: 0xD19BE0
	public EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xD19BE8
	public void set_SerializationMethod(EnumSerializationMethod value) { }

	// RVA: 0xD19BF0
	public void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackEnumMemberAttribute
{
	// Fields
	private EnumMemberSerializationMethod <SerializationMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD19BF8
	public EnumMemberSerializationMethod get_SerializationMethod() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackIgnoreAttribute
{
	// Methods

	// RVA: 0xD19C00
	public void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD19C08
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD19C10
	public string get_TypeCode() { }

	// RVA: 0xD19C18
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownCollectionItemTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD19C20
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD19C28
	public string get_TypeCode() { }

	// RVA: 0xD19C30
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownDictionaryKeyTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD19C38
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD19C40
	public string get_TypeCode() { }

	// RVA: 0xD19C48
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTupleItemTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD19C50
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD19C58
	public string get_TypeCode() { }

	// RVA: 0xD19C60
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackMemberAttribute
{
	// Fields
	private readonly int _id; // 0x10
	private string _name; // 0x18
	private NilImplication _nilImplication; // 0x20

	// Methods

	// RVA: 0xD19C68
	public int get_Id() { }

	// RVA: 0xD19C70
	public string get_Name() { }

	// RVA: 0xD19C78
	public NilImplication get_NilImplication() { }

	// RVA: 0xD19C80
	public void .ctor(int id) { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD19CAC
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD19CB4
	public Type get_VerifierType() { }

	// RVA: 0xD19CBC
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeCollectionItemTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD19CC4
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD19CCC
	public Type get_VerifierType() { }

	// RVA: 0xD19CD4
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeDictionaryKeyTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD19CDC
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD19CE4
	public Type get_VerifierType() { }

	// RVA: 0xD19CEC
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTupleItemTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD19CF4
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD19CFC
	public Type get_VerifierType() { }

	// RVA: 0xD19D04
	public string get_VerifierMethodName() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.Serialization.MessagePackSerializer.<>c <>9; // 0x0

	// Methods

	// RVA: 0xD1A280
	private static void .cctor() { }

	// RVA: 0xD1A2EC
	public void .ctor() { }

	// RVA: 0xD1A2F4
	internal bool <.cctor>b__49_0(MethodInfo m) { }

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

	// RVA: 0xD19D0C
	protected internal SerializationContext get_OwnerContext() { }

	// RVA: 0xD19D14
	protected internal PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xD19DAC
	internal void .ctor(SerializationContext ownerContext, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xD19EDC
	public void PackTo(Packer packer, object objectTree) { }

	// RVA: -1
	internal abstract void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0xD19EE8
	public object UnpackFrom(Unpacker unpacker) { }

	// RVA: -1
	internal abstract object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0xD19EF4
	public void UnpackTo(Unpacker unpacker, object collection) { }

	// RVA: -1
	internal abstract void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xD19E94
	internal static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0x30B5790
	public static MsgPack.Serialization.MessagePackSerializer<T> Get() { }

	// RVA: 0x30B57C8
	public static MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x30B58A8
	public static MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0x30B58A8
	internal static MsgPack.Serialization.MessagePackSerializer<T> CreateInternal(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0x30B5A04
	internal static MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionInternal(SerializationContext context, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD19F00
	private static void ValidateType(Type type) { }

	// RVA: 0x30B58A8
	internal static MsgPack.Serialization.MessagePackSerializer<T> Wrap(SerializationContext context, MessagePackSerializer nonGeneric) { }

	// RVA: 0x30B71FC
	public static void PrepareType() { }

	// RVA: 0x30B71FC
	public static void PrepareDictionaryType() { }

	// RVA: 0x30B71FC
	public static void PrepareCollectionType() { }

	// RVA: 0x30B8148
	private static void PrepareTypeCore(SerializationContext dummyContext) { }

	// RVA: 0xD1A038
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
public abstract class MessagePackSerializer<T0>
{
	// Fields
	private static readonly bool IsNullable; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	protected void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x30B2D20
	protected void .ctor(SerializationContext ownerContext, SerializerCapabilities capabilities) { }

	// RVA: -1
	private static bool JudgeNullable() { }

	// RVA: 0x30B44C8
	private static SerializerCapabilities InferCapatibity() { }

	// RVA: 0x316B894
	public void Pack(Stream stream, T objectTree) { }

	// RVA: 0x316B894
	public T Unpack(Stream stream) { }

	// RVA: 0x316B894
	public void PackTo(Packer packer, T objectTree) { }

	// RVA: -1
	protected internal abstract void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x316B894
	public T UnpackFrom(Unpacker unpacker) { }

	// RVA: 0x316B894
	protected internal virtual T UnpackNil() { }

	// RVA: -1
	protected internal abstract T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x316B894
	public void UnpackTo(Unpacker unpacker, T collection) { }

	// RVA: 0x316B894
	protected internal virtual void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x316B894
	public Byte[] PackSingleObject(T objectTree) { }

	// RVA: 0x316B894
	public System.ArraySegment<System.Byte> PackSingleObjectAsBytes(T objectTree) { }

	// RVA: 0x316B894
	public T UnpackSingleObject(Byte[] buffer) { }

	// RVA: 0x30B2F18
	internal sealed override void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0x30B1D84
	internal sealed override object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x30B2F18
	internal sealed override void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0x30B933C
	private static void ThrowArgumentException(string message, string parameterName) { }

	// RVA: 0x30B71FC
	private static void ThrowNewValueTypeCannotBeNullException() { }

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal abstract class MessagePackSerializerProvider
{
	// Methods

	// RVA: 0xD190F8
	protected void .ctor() { }

	// RVA: -1
	public abstract object Get(SerializationContext context, object providerParameter) { }

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

	// RVA: 0x316B894
	public TAction OnPacking(TPackingParameter parameter, NilImplication nilImplication) { }

	// RVA: -1
	protected abstract TCondition OnPackingMessagePackObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TCondition OnPackingReferenceTypeObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TCondition OnPackingNullableValueTypeObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnPackingCore(TPackingParameter parameter, TCondition condition) { }

	// RVA: 0x316B894
	public TAction OnUnpacked(TUnpackedParameter parameter, NilImplication nilImplication) { }

	// RVA: -1
	protected abstract TAction OnNopOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnThrowNullIsProhibitedExceptionOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnThrowValueTypeCannotBeNull3OnUnpacked(TUnpackedParameter parameter) { }

	// RVA: 0x30B2870
	protected void .ctor() { }

}

// Namespace: MsgPack.Serialization
public struct PolymorphicTypeVerificationContext
{
	// Fields
	private readonly string _loadingTypeFullName; // 0x10
	private readonly string _loadingAssemblyFullName; // 0x18
	private readonly AssemblyName _loadingAssemblyName; // 0x20

	// Methods

	// RVA: 0xD1A610
	internal void .ctor(string loadingTypeFullName, AssemblyName loadingAssemblyName, string loadingAssemblyFullName) { }

	// RVA: 0xD1A660
	public override string ToString() { }

	// RVA: 0xD1A6E4
	public override bool Equals(object obj) { }

	// RVA: 0xD1A784
	public bool Equals(PolymorphicTypeVerificationContext other) { }

	// RVA: 0xD1A7D0
	public override int GetHashCode() { }

}

// Namespace: 
private sealed class ReadOnlyDictionary<T0, T1>
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<TKey,TValue> _underlying; // 0x0

	// Methods

	// RVA: 0x30B1CD4
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x316B894
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }

	// RVA: 0x316B894
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }

	// RVA: 0x30B199C
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Count() { }

	// RVA: 0x30B171C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x30B2CB8
	public void .ctor(System.Collections.Generic.IDictionary<TKey,TValue> underlying) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.ContainsKey(TKey key) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.TryGetValue(TKey key, TValue value) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30B2D20
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x30B1CD4
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x30B1CD4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x316B894
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	// RVA: 0x316B894
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30B2870
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }

	// RVA: 0x316B894
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

}

// Namespace: 
private struct TypeTable
{
	// Fields
	public readonly TypeTableEntry Member; // 0x10
	public readonly TypeTableEntry CollectionItem; // 0x18
	public readonly TypeTableEntry DictionaryKey; // 0x20

	// Methods

	// RVA: 0xD1E058
	private void .ctor(TypeTableEntry member, TypeTableEntry collectionItem, TypeTableEntry dictionaryKey) { }

	// RVA: 0xD1C554
	public static TypeTable Create(MemberInfo member, PolymorphismSchema defaultSchema) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public PolymorphismTarget targetType; // 0x10
	public System.Func<MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xD1E5F8
	public void .ctor() { }

	// RVA: 0xD2032C
	internal bool <Create>b__0(IPolymorphicHelperAttribute a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public IPolymorphicRuntimeTypeAttribute attribute; // 0x10

	// Methods

	// RVA: 0xD20198
	public void .ctor() { }

	// RVA: 0xD203E8
	internal bool <GetVerifier>b__0(MethodInfo m) { }

}

// Namespace: 
private sealed class TypeTableEntry
{
	// Fields
	private readonly System.Collections.Generic.Dictionary<System.String,System.Type> _knownTypeMapping; // 0x10
	private bool _useTypeEmbedding; // 0x18
	private System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> <TypeVerifier>k__BackingField; // 0x20

	// Methods

	// RVA: 0xD1E554
	public System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xD1D288
	public PolymorphismType get_PolymorphismType() { }

	// RVA: 0xD1D210
	public bool get_Exists() { }

	// RVA: 0xD1E55C
	public System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xD1E564
	private void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xD1E56C
	private void .ctor() { }

	// RVA: 0xD1E0A8
	public static TypeTableEntry Create(MemberInfo member, PolymorphismTarget targetType, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD1E600
	private void Interpret(IPolymorphicHelperAttribute attribute, string memberName, int tupleItemNumber) { }

	// RVA: 0xD1E9D0
	private void SetDefault(PolymorphismTarget target, string memberName, int tupleItemNumber, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD1EE64
	private void SetKnownType(PolymorphismTarget target, string memberName, int tupleItemNumber, string typeCode, Type bindingType) { }

	// RVA: 0xD1F5E4
	private void SetRuntimeType(PolymorphismTarget target, string memberName, int tupleItemNumber, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD1F6F0
	private static string GetCannotSpecifyKnownTypeAndRuntimeTypeErrorMessage(PolymorphismTarget target, string memberName, System.Nullable<System.Int32> tupleItemNumber) { }

	// RVA: 0xD1FD58
	private static string GetCannotDuplicateKnownTypeCodeErrorMessage(PolymorphismTarget target, string typeCode, string memberName, int tupleItemNumber) { }

	// RVA: 0xD1F038
	private static System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> GetVerifier(IPolymorphicRuntimeTypeAttribute attribute) { }

	// RVA: 0xD201A0
	private static bool IsVerificationMethod(MethodInfo method, string name) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.Serialization.PolymorphismSchema.<>c <>9; // 0x0
	public static System.Func<MsgPack.Serialization.PolymorphismSchema,MsgPack.Serialization.PolymorphismSchema> <>9__3_0; // 0x8
	public static System.Func<MsgPack.Serialization.PolymorphismSchema,MsgPack.Serialization.PolymorphismSchema> <>9__4_0; // 0x10

	// Methods

	// RVA: 0xD204A8
	private static void .cctor() { }

	// RVA: 0xD20514
	public void .ctor() { }

	// RVA: 0xD2051C
	internal PolymorphismSchema <.ctor>b__3_0(PolymorphismSchema x) { }

	// RVA: 0xD205B0
	internal PolymorphismSchema <.ctor>b__4_0(PolymorphismSchema x) { }

	// RVA: 0xD20644
	internal bool <.cctor>b__70_0(PolymorphicTypeVerificationContext _) { }

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

	// RVA: 0xD1A820
	private void .ctor() { }

	// RVA: 0xD1A994
	private void .ctor(Type targetType, PolymorphismType polymorphismType, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xD1AD2C
	private void .ctor(Type targetType, PolymorphismType polymorphismType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xD1ABFC
	private void .ctor(Type targetType, PolymorphismType polymorphismType, MsgPack.Serialization.PolymorphismSchema.ReadOnlyDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, System.Collections.ObjectModel.ReadOnlyCollection<MsgPack.Serialization.PolymorphismSchema> childItemSchemaList) { }

	// RVA: 0xD1AF8C
	public static PolymorphismSchema ForPolymorphicObject(Type targetType) { }

	// RVA: 0xD1B040
	public static PolymorphismSchema ForPolymorphicObject(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping) { }

	// RVA: 0xD1B104
	public static PolymorphismSchema ForContextSpecifiedCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xD1B214
	public static PolymorphismSchema ForPolymorphicCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xD1B324
	public static PolymorphismSchema ForPolymorphicCollection(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema itemSchema) { }

	// RVA: 0xD1B43C
	public static PolymorphismSchema ForContextSpecifiedDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD1B578
	public static PolymorphismSchema ForPolymorphicDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD1B6B4
	public static PolymorphismSchema ForPolymorphicDictionary(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD1B7F8
	internal PolymorphismSchema FilterSelf() { }

	// RVA: 0xD1B8C8
	internal Type get_TargetType() { }

	// RVA: 0xD1B8D0
	private void set_TargetType(Type value) { }

	// RVA: 0xD1B8D8
	internal PolymorphismType get_PolymorphismType() { }

	// RVA: 0xD1B8E0
	private void set_PolymorphismType(PolymorphismType value) { }

	// RVA: 0xD1B8E8
	internal System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xD1B8F0
	internal bool get_UseDefault() { }

	// RVA: 0xD1B900
	internal bool get_UseTypeEmbedding() { }

	// RVA: 0xD1B910
	internal System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xD1B918
	private void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xD1B920
	internal PolymorphismSchemaChildrenType get_ChildrenType() { }

	// RVA: 0xD1B928
	private void set_ChildrenType(PolymorphismSchemaChildrenType value) { }

	// RVA: 0xD1B930
	internal PolymorphismSchema get_ItemSchema() { }

	// RVA: 0xD1BA18
	private PolymorphismSchema TryGetItemSchema() { }

	// RVA: 0xD1BAC8
	internal PolymorphismSchema get_KeySchema() { }

	// RVA: 0xD1BB80
	private PolymorphismSchema TryGetKeySchema() { }

	// RVA: 0xD1BC00
	internal static PolymorphismSchema Create(Type type, SerializingMember memberMayBeNull) { }

	// RVA: 0xD1BD58
	private static PolymorphismSchema CreateCore(MemberInfo member, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD1D300
	private static void .cctor() { }

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
[Serializable]
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

	// RVA: 0xD23304
	private static void .cctor() { }

	// RVA: 0xD23370
	public void .ctor() { }

	// RVA: 0xD23378
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_0(Type interface) { }

	// RVA: 0xD23480
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_1(Type i) { }

	// RVA: 0xD23508
	internal Type <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_2(Type i) { }

	// RVA: 0xD23534
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_3(Type i) { }

	// RVA: 0xD235BC
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_4(Type i) { }

	// RVA: 0xD23644
	internal Type <FindInterfaceMethod>b__7_2(ParameterInfo p) { }

	// RVA: 0xD2366C
	internal bool <GetIsPublic>b__15_0(MethodInfo a) { }

	// RVA: 0xD23714
	internal bool <GetIsPublic>b__15_1(MethodInfo a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public Type interfaceType; // 0x10
	public string name; // 0x18
	public Type[] parameterTypes; // 0x20

	// Methods

	// RVA: 0xD22714
	public void .ctor() { }

	// RVA: 0xD23730
	internal bool <FindInterfaceMethod>b__0(Type type, object _) { }

	// RVA: 0xD23740
	internal bool <FindInterfaceMethod>b__1(MethodInfo method) { }

}

// Namespace: MsgPack.Serialization
internal static class ReflectionExtensions
{
	// Fields
	private static readonly Type[] ExceptionConstructorWithInnerParameterTypes; // 0x0
	private static readonly Type[] ObjectAddParameterTypes; // 0x8

	// Methods

	// RVA: 0xD1C8FC
	internal static CollectionTraits GetCollectionTraits(Type source, CollectionTraitOptions options, bool allowNonCollectionEnumerableTypes) { }

	// RVA: 0xD21E48
	private static bool TryCreateCollectionTraitsForIEnumerableT(Type source, GenericCollectionTypes genericTypes, CollectionTraitOptions options, MethodInfo getMethod, CollectionTraits result) { }

	// RVA: 0xD2064C
	private static bool TryCreateCollectionTraitsForHasGetEnumeratorType(Type source, CollectionTraitOptions options, MethodInfo getEnumerator, CollectionTraits result) { }

	// RVA: 0xD21030
	private static bool TryCreateGenericCollectionTraits(Type source, Type type, CollectionTraitOptions options, CollectionTraits result) { }

	// RVA: 0xD214F0
	private static bool DetermineCollectionInterfaces(Type type, GenericCollectionTypes genericTypes, Type idictionary, Type ilist, Type icollection, Type ienumerable) { }

	// RVA: 0xD218B8
	private static MethodInfo GetGetEnumeratorMethodFromElementType(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xD22018
	private static MethodInfo GetGetEnumeratorMethodFromEnumerableType(Type targetType, Type enumerableType, CollectionTraitOptions options) { }

	// RVA: 0xD22498
	private static MethodInfo FindInterfaceMethod(Type targetType, Type interfaceType, string name, Type[] parameterTypes) { }

	// RVA: 0xD220D4
	private static MethodInfo GetAddMethod(Type targetType, Type argumentType, CollectionTraitOptions options) { }

	// RVA: 0xD21BE8
	private static MethodInfo GetCountGetterMethod(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xD21A4C
	private static MethodInfo GetAddMethod(Type targetType, Type keyType, Type valueType, CollectionTraitOptions options) { }

	// RVA: 0xD20ED4
	private static bool FilterCollectionType(Type type, object filterCriteria) { }

	// RVA: 0xD22390
	private static bool IsIEnumeratorT(Type interface) { }

	// RVA: 0xD2271C
	public static bool GetHasPublicGetter(MemberInfo source) { }

	// RVA: 0xD22860
	public static bool GetIsPublic(MemberInfo source) { }

	// RVA: 0xD1A4D4
	public static Type[] GetParameterTypes(MethodBase source) { }

	// RVA: 0xD1C66C
	public static Type GetMemberValueType(MemberInfo source) { }

	// RVA: 0xD22BE4
	public static object InvokePreservingExceptionType(ConstructorInfo source, object[] parameters) { }

	// RVA: 0xD22F48
	public static object InvokePreservingExceptionType(MethodInfo source, object instance, object[] parameters) { }

	// RVA: 0x316B894
	public static T CreateInstancePreservingExceptionType(Type instanceType, object[] constructorParameters) { }

	// RVA: 0xD23034
	public static object CreateInstancePreservingExceptionType(Type type, object[] constructorParameters) { }

	// RVA: 0xD22CD0
	private static Exception HoistUpInnerException(TargetInvocationException targetInvocationException) { }

	// RVA: 0xD23110
	private static void .cctor() { }

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

	// RVA: 0xD238CC
	private void set_Context(SerializationContext value) { }

	// RVA: 0xD238D4
	private void set_TargetType(Type value) { }

	// RVA: 0xD238DC
	private void set_PolymorphismSchema(PolymorphismSchema value) { }

	// RVA: 0x30B1CD4
	internal MsgPack.Serialization.MessagePackSerializer<T> GetFoundSerializer() { }

	// RVA: 0xD238E4
	internal void .ctor(SerializationContext context, Type targetType, PolymorphismSchema schema) { }

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

	// RVA: 0xD239C0
	public bool get_OneBoundDataMemberOrder() { }

	// RVA: 0xD19DA0
	public PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xD239E4
	public void set_PackerCompatibilityOptions(PackerCompatibilityOptions value) { }

	// RVA: 0xD239F0
	public void set_IgnorePackabilityForCollection(bool value) { }

	// RVA: 0xD23A18
	public bool get_AllowNonCollectionEnumerableTypes() { }

	// RVA: 0xD23A3C
	public void set_AllowNonCollectionEnumerableTypes(bool value) { }

	// RVA: 0xD23A64
	public bool get_AllowAsymmetricSerializer() { }

	// RVA: 0xD23A88
	public void set_AllowAsymmetricSerializer(bool value) { }

	// RVA: 0xD23AB0
	internal void .ctor() { }

}

// Namespace: 
private sealed class SerializerGetter
{
	// Fields
	public static readonly SerializerGetter Instance; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Reflection.MethodInfo> _cache; // 0x10

	// Methods

	// RVA: 0xD24E0C
	private void .ctor() { }

	// RVA: 0xD2448C
	public MessagePackSerializer Get(SerializationContext context, Type targetType, object providerParameter) { }

	// RVA: 0xD24E98
	private static void .cctor() { }

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

	// RVA: 0xD23B00
	public static SerializationContext get_Default() { }

	// RVA: 0xD23BFC
	public SerializerRepository get_Serializers() { }

	// RVA: 0xD23C04
	public SerializerOptions get_SerializerOptions() { }

	// RVA: 0xD23C0C
	public SerializationCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xD23C14
	public DictionarySerlaizationOptions get_DictionarySerlaizationOptions() { }

	// RVA: 0xD23C1C
	public SerializationMethod get_SerializationMethod() { }

	// RVA: 0xD23C28
	public EnumSerializationOptions get_EnumSerializationOptions() { }

	// RVA: 0xD23C30
	public DefaultConcreteTypeRepository get_DefaultCollectionTypes() { }

	// RVA: 0xD176B4
	public DateTimeConversionMethod get_DefaultDateTimeConversionMethod() { }

	// RVA: 0x30B1D84
	private MsgPack.Serialization.MessagePackSerializer<T> OnResolveSerializer(PolymorphismSchema schema) { }

	// RVA: 0xD1A278
	public void .ctor() { }

	// RVA: 0xD23C38
	public void .ctor(PackerCompatibilityOptions packerCompatibilityOptions) { }

	// RVA: 0x30B1CD4
	public MsgPack.Serialization.MessagePackSerializer<T> GetSerializer() { }

	// RVA: 0x30B1D84
	public MsgPack.Serialization.MessagePackSerializer<T> GetSerializer(object providerParameter) { }

	// RVA: 0xD240C4
	private Type EnsureConcreteTypeRegistered(Type mayBeAbstractType) { }

	// RVA: 0x30B1D84
	private MsgPack.Serialization.MessagePackSerializer<T> GetSerializerWithoutGeneration(PolymorphismSchema schema) { }

	// RVA: 0xD2430C
	public MessagePackSerializer GetSerializer(Type targetType) { }

	// RVA: 0xD24314
	public MessagePackSerializer GetSerializer(Type targetType, object providerParameter) { }

	// RVA: 0xD24C10
	public ExtTypeCodeMapping get_ExtTypeCodeMapping() { }

	// RVA: 0xD24C18
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
public static class SerializationExceptions
{
	// Methods

	// RVA: 0xD24F78
	public static Exception NewValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xD25120
	public static void ThrowValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xD2514C
	public static Exception NewValueTypeCannotBeNull(Type type) { }

	// RVA: 0xD25284
	public static void ThrowMissingItem(int index, Unpacker unpacker) { }

	// RVA: 0xD25298
	public static void ThrowMissingItem(int index, string name, Unpacker unpacker) { }

	// RVA: 0xD256D4
	internal static void ThrowMissingKey(int index, Unpacker unpacker) { }

	// RVA: 0xD25920
	internal static Exception NewTargetDoesNotHavePublicDefaultConstructor(Type type) { }

	// RVA: 0xD25A58
	internal static Exception NewTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xD25B90
	internal static void ThrowTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xD25BBC
	public static Exception NewMissingProperty(string name) { }

	// RVA: 0xD25CF4
	internal static void ThrowMissingProperty(string name) { }

	// RVA: 0xD25D20
	internal static void ThrowUnexpectedEndOfStream(Unpacker unpacker) { }

	// RVA: 0xD25ECC
	public static void ThrowIsNotArrayHeader(Unpacker unpacker) { }

	// RVA: 0xD2606C
	public static void ThrowIsNotMapHeader(Unpacker unpacker) { }

	// RVA: 0xD241D4
	public static Exception NewNotSupportedBecauseCannotInstanciateAbstractType(Type type) { }

	// RVA: 0xD2620C
	public static Exception NewIsIncorrectStream(Exception innerException) { }

	// RVA: 0xD2628C
	internal static void ThrowIsIncorrectStream(Exception innerException) { }

	// RVA: 0xD262B8
	public static Exception NewIsTooLargeCollection() { }

	// RVA: 0xD26330
	internal static void ThrowIsTooLargeCollection() { }

	// RVA: 0xD2635C
	public static Exception NewNullIsProhibited(string memberName) { }

	// RVA: 0xD26494
	public static void ThrowNullIsProhibited(string memberName) { }

	// RVA: 0xD264C0
	public static Exception NewReadOnlyMemberItemsMustNotBeNull(string memberName) { }

	// RVA: 0xD265F8
	public static Exception NewUnpackFromIsNotSupported(Type targetType) { }

	// RVA: 0xD26730
	public static Exception NewCreateInstanceIsNotSupported(Type targetType) { }

	// RVA: 0xD26868
	internal static Exception NewUnpackToIsNotSupported(Type type, Exception inner) { }

	// RVA: 0xD269A8
	internal static Exception NewValueTypeCannotBePolymorphic(Type type) { }

	// RVA: 0xD26AE0
	internal static Exception NewUnknownTypeEmbedding() { }

	// RVA: 0xD26B58
	internal static Exception NewIncompatibleCollectionSerializer(Type targetType, Type incompatibleType, Type exampleClass) { }

	// RVA: 0xD26DC8
	internal static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xD26E10
	internal static void ThrowSerializationException(string message) { }

	// RVA: 0xD26E58
	internal static void ThrowSerializationException(string message, Exception innerException) { }

	// RVA: 0xD26EAC
	internal static void ThrowInvalidArrayItemsCount(Unpacker unpacker, Type targetType, int requiredCount) { }

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

	// RVA: 0xD2C21C
	private void .ctor() { }

	// RVA: 0xD2C270
	public override bool Equals(System.Collections.Generic.KeyValuePair<System.String,System.Type> x, System.Collections.Generic.KeyValuePair<System.String,System.Type> y) { }

	// RVA: 0xD2C4F0
	public override int GetHashCode(System.Collections.Generic.KeyValuePair<System.String,System.Type> obj) { }

	// RVA: 0xD2C828
	private static void .cctor() { }

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
[Serializable]
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

	// RVA: 0xD2C8C8
	private static void .cctor() { }

	// RVA: 0xD2C934
	public void .ctor() { }

	// RVA: 0xD2C93C
	internal System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_0(ParameterInfo p) { }

	// RVA: 0xD2C9D8
	internal System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_1(SerializingMember m) { }

	// RVA: 0xD2CA98
	internal string <FindCorrespondingMemberNames>b__26_2(ParameterInfo p, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> ms) { }

	// RVA: 0xD2CB24
	internal string <ThrowAmbigiousMatchException>b__28_0(SerializingMember x) { }

	// RVA: 0xD2CB4C
	internal int <Prepare>b__32_0(SerializingMember entry) { }

	// RVA: 0xD2CB70
	internal bool <Prepare>b__32_2(SerializingMember item) { }

	// RVA: 0xD2CB9C
	internal string <Prepare>b__32_3(SerializingMember item) { }

	// RVA: 0xD2CBC0
	internal bool <HasAnyCorrespondingMembers>b__33_0(string x) { }

	// RVA: 0xD2CBE0
	internal bool <GetTargetMembers>b__37_0(MemberInfo item) { }

	// RVA: 0xD2CCBC
	internal bool <GetTargetMembers>b__37_1(object attr) { }

	// RVA: 0xD2CD30
	internal bool <GetAnnotatedMembersWithDuplicationDetection>b__38_0(MemberInfo member) { }

	// RVA: 0xD2CE0C
	internal SerializingMember <GetAnnotatedMembersWithDuplicationDetection>b__38_1(MemberInfo member) { }

	// RVA: 0xD2D084
	internal <>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> <GetSystemRuntimeSerializationCompatibleMembers>b__39_0(MemberInfo item) { }

	// RVA: 0xD2D210
	internal bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_3(object data) { }

	// RVA: 0xD2D284
	internal bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_1(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xD2D31C
	internal SerializingMember <GetSystemRuntimeSerializationCompatibleMembers>b__39_2(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xD2DA1C
	internal bool <GetPublicUnpreventedMembers>b__40_0(MemberInfo member) { }

	// RVA: 0xD2DD84
	internal string <GetPublicUnpreventedMembers>b__40_2(object data) { }

	// RVA: 0xD2DDB8
	internal bool <GetPublicUnpreventedMembers>b__40_3(string attr) { }

	// RVA: 0xD2DE4C
	internal SerializingMember <GetPublicUnpreventedMembers>b__40_1(MemberInfo member) { }

	// RVA: 0xD2DF3C
	internal int <FindDeserializationConstructor>b__42_0(ConstructorInfo ctor) { }

	// RVA: 0xD2DF74
	internal int <FindDeserializationConstructor>b__42_1(System.Linq.IGrouping<System.Int32,System.Reflection.ConstructorInfo> g) { }

	// RVA: 0xD2E024
	internal string <FindDeserializationConstructor>b__42_2(ConstructorInfo ctor) { }

	// RVA: 0xD2E04C
	internal bool <FindExplicitDeserializationConstructors>b__43_0(ConstructorInfo ctor) { }

	// RVA: 0xD2E18C
	internal bool <FindExplicitDeserializationConstructors>b__43_1(object a) { }

	// RVA: 0xD2E220
	internal int <ComplementMembers>b__46_0(SerializingMember item) { }

	// RVA: 0xD2E244
	internal string <VerifyKeyUniqueness>b__48_0(System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<System.Reflection.MemberInfo>> kv) { }

	// RVA: 0xD2E5D4
	internal string <VerifyKeyUniqueness>b__48_1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public SerializationContext context; // 0x10

	// Methods

	// RVA: 0xD2877C
	public void .ctor() { }

	// RVA: 0xD2E818
	internal bool <Prepare>b__1(SerializingMember entry) { }

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

	// RVA: 0xD2724C
	public System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> get_Members() { }

	// RVA: 0xD27254
	private void set_Members(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> value) { }

	// RVA: 0xD2725C
	public ConstructorInfo get_DeserializationConstructor() { }

	// RVA: 0xD27264
	private void set_DeserializationConstructor(ConstructorInfo value) { }

	// RVA: 0xD2726C
	public bool get_IsConstructorDeserialization() { }

	// RVA: 0xD27274
	private void set_IsConstructorDeserialization(bool value) { }

	// RVA: 0xD2727C
	public bool get_CanDeserialize() { }

	// RVA: 0xD27284
	private void set_CanDeserialize(bool value) { }

	// RVA: 0xD2728C
	private void .ctor(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor, string[] correspondingMemberNames, bool canDeserialize) { }

	// RVA: 0xD27398
	public SerializerCapabilities GetCapabilitiesForObject() { }

	// RVA: 0xD273AC
	public SerializerCapabilities GetCapabilitiesForCollection(CollectionTraits traits) { }

	// RVA: 0xD273D4
	private static string[] FindCorrespondingMemberNames(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor) { }

	// RVA: 0xD276D4
	private static string DetermineCorrespondingMemberName(ParameterInfo parameterInfo, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xD2779C
	private static void ThrowAmbigiousMatchException(ParameterInfo parameterInfo, System.Collections.Generic.ICollection<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xD279DC
	public static void VerifyType(Type targetType) { }

	// RVA: 0xD27AAC
	public static void VerifyCanSerializeTargetType(SerializationContext context, Type targetType) { }

	// RVA: 0xD27CEC
	public static SerializationTarget Prepare(SerializationContext context, Type targetType) { }

	// RVA: 0xD29F40
	private static bool HasAnyCorrespondingMembers(System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames) { }

	// RVA: 0xD2A074
	private static bool HasUnpackableInterface(Type targetType, SerializationContext context) { }

	// RVA: 0xD29CB8
	private static bool DetermineCanDeserialize(ConstructorKind kind, SerializationContext context, Type targetType, System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames, bool allowDefault) { }

	// RVA: 0xD2A12C
	private static MemberInfo[] GetDistinctMembers(Type type) { }

	// RVA: 0xD28784
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetTargetMembers(Type type) { }

	// RVA: 0xD2A510
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetAnnotatedMembersWithDuplicationDetection(Type type, MemberInfo[] filtered) { }

	// RVA: 0xD2A814
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetSystemRuntimeSerializationCompatibleMembers(MemberInfo[] members) { }

	// RVA: 0xD2AADC
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetPublicUnpreventedMembers(MemberInfo[] members) { }

	// RVA: 0xD2ACD4
	private static bool IsNonSerializedField(MemberInfo member) { }

	// RVA: 0xD28A78
	private static ConstructorInfo FindDeserializationConstructor(SerializationContext context, Type targetType, ConstructorKind constructorKind) { }

	// RVA: 0xD29E20
	private static System.Collections.Generic.IList<System.Reflection.ConstructorInfo> FindExplicitDeserializationConstructors(System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> construtors) { }

	// RVA: 0xD2AD6C
	private static SerializationException NewTypeCannotBeSerializedException(Type targetType) { }

	// RVA: 0xD2AEA4
	private static bool CheckTargetEligibility(SerializationContext context, MemberInfo member) { }

	// RVA: 0xD291A0
	private static System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> ComplementMembers(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> candidates, SerializationContext context, Type targetType) { }

	// RVA: 0xD2B1D8
	private static void VerifyNilImplication(Type type, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> entries) { }

	// RVA: 0xD2B704
	private static void VerifyKeyUniqueness(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> result) { }

	// RVA: 0xD2BF3C
	public static SerializationTarget CreateForCollection(ConstructorInfo collectionConstructor, bool canDeserialize) { }

	// RVA: 0xD2BFD0
	private static void .cctor() { }

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

	// RVA: 0xD27CC8
	public bool get_DisablePrivilegedAccess() { }

	// RVA: 0xD240B4
	internal void .ctor() { }

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

	// RVA: 0xD23FE8
	public void .ctor(SerializerRepository copiedFrom) { }

	// RVA: 0xD2E8AC
	private void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD2EA24
	public void Dispose() { }

	// RVA: 0x30B1D84
	public MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x30B1E68
	public MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0xD2EA28
	internal bool Register(Type targetType, MessagePackSerializerProvider serializerProvider, Type nullableType, MessagePackSerializerProvider nullableSerializerProvider, SerializerRegistrationOptions options) { }

	// RVA: 0xD23F24
	public static SerializerRepository GetDefault(SerializationContext ownerContext) { }

	// RVA: 0xD2EA48
	internal static System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeDefaultTable(SerializationContext ownerContext) { }

	// RVA: 0xD2FFEC
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class SerializerTypeKeyRepository
{
	// Fields
	private static readonly Type[] NonGenericSerializerConstructorParameterTypes; // 0x0

	// Methods

	// RVA: 0xD2E8A8
	public void .ctor(SerializerTypeKeyRepository copiedFrom) { }

	// RVA: 0xD2E994
	public void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD30168
	public object Get(SerializationContext context, Type keyType) { }

	// RVA: 0xD304E4
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class SerializingMember
{
	// Fields
	public readonly MemberInfo Member; // 0x10
	public readonly DataMemberContract Contract; // 0x18
	public readonly string MemberName; // 0x20

	// Methods

	// RVA: 0xD2B138
	public void .ctor() { }

	// RVA: 0xD2CFFC
	public void .ctor(MemberInfo member, DataMemberContract contract) { }

	// RVA: 0xD30654
	public EnumMemberSerializationMethod GetEnumMemberSerializationMethod() { }

	// RVA: 0xD3077C
	public DateTimeMemberConversionMethod GetDateTimeMemberConversionMethod() { }

	// RVA: 0xD308A4
	public override string ToString() { }

}

// Namespace: MsgPack.Serialization
internal class TypeKeyRepository
{
	// Fields
	private readonly ReaderWriterLockSlim _lock; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> _table; // 0x18

	// Methods

	// RVA: 0xD30074
	public void .ctor(TypeKeyRepository copiedFrom) { }

	// RVA: 0xD17D28
	public void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD30AF0
	private System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> GetClonedTable() { }

	// RVA: 0xD17F10
	public bool Get(Type type, object matched, object genericDefinitionMatched) { }

	// RVA: 0xD30C48
	private bool GetCore(Type type, object matched, object genericDefinitionMatched) { }

	// RVA: 0xD2EA44
	public bool Register(Type type, object entry, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xD30F2C
	private bool RegisterCore(Type key, object value, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xD31188
	private bool ContainsType(Type baseType, Type nullableType) { }

}

// Namespace: MsgPack.Serialization
public static class UnpackHelpers
{
	// Fields
	private static readonly MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _messagePackObjectSerializer; // 0x0

	// Methods

	// RVA: 0xD31274
	public static int GetItemsCount(Unpacker unpacker) { }

	// RVA: 0xD313B4
	internal static SerializationTarget DetermineCollectionSerializationStrategy(Type instanceType, bool allowAsymmetricSerializer) { }

	// RVA: 0xD31518
	private static ConstructorInfo TryGetCollectionConstructor(Type instanceType) { }

	// RVA: 0xD3189C
	internal static bool IsIEqualityComparer(Type type) { }

	// RVA: 0xD319A4
	internal static object GetEqualityComparer(Type comparerType) { }

	// RVA: 0xD31D60
	private static void .cctor() { }

}

// Namespace: 
private sealed class BoxingGenericEqualityComparer<T0>
{
	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	public bool Equals(T x, T y) { }

	// RVA: 0x316B894
	public int GetHashCode(T obj) { }

}

// Namespace: 
private sealed class System_AppDomainManagerInitializationOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD3D178
	public void .ctor() { }

	// RVA: 0xD3D180
	public bool Equals(AppDomainManagerInitializationOptions left, AppDomainManagerInitializationOptions right) { }

	// RVA: 0xD3D208
	public int GetHashCode(AppDomainManagerInitializationOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_AppDomainManagerInitializationOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD3D230
	public void .ctor() { }

	// RVA: 0xD3D238
	public bool Equals(System.Nullable<System.AppDomainManagerInitializationOptions> left, System.Nullable<System.AppDomainManagerInitializationOptions> right) { }

	// RVA: 0xD3D3B4
	public int GetHashCode(System.Nullable<System.AppDomainManagerInitializationOptions> obj) { }

}

// Namespace: 
private sealed class System_AttributeTargetsEqualityComparer
{
	// Methods

	// RVA: 0xD3D468
	public void .ctor() { }

	// RVA: 0xD3D470
	public bool Equals(AttributeTargets left, AttributeTargets right) { }

	// RVA: 0xD3D4F8
	public int GetHashCode(AttributeTargets obj) { }

}

// Namespace: 
private sealed class NullableSystem_AttributeTargetsEqualityComparer
{
	// Methods

	// RVA: 0xD3D520
	public void .ctor() { }

	// RVA: 0xD3D528
	public bool Equals(System.Nullable<System.AttributeTargets> left, System.Nullable<System.AttributeTargets> right) { }

	// RVA: 0xD3D6A4
	public int GetHashCode(System.Nullable<System.AttributeTargets> obj) { }

}

// Namespace: 
private sealed class System_Base64FormattingOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD3D758
	public void .ctor() { }

	// RVA: 0xD3D760
	public bool Equals(Base64FormattingOptions left, Base64FormattingOptions right) { }

	// RVA: 0xD3D7E8
	public int GetHashCode(Base64FormattingOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Base64FormattingOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD3D810
	public void .ctor() { }

	// RVA: 0xD3D818
	public bool Equals(System.Nullable<System.Base64FormattingOptions> left, System.Nullable<System.Base64FormattingOptions> right) { }

	// RVA: 0xD3D994
	public int GetHashCode(System.Nullable<System.Base64FormattingOptions> obj) { }

}

// Namespace: 
private sealed class System_BooleanEqualityComparer
{
	// Methods

	// RVA: 0xD3DA48
	public void .ctor() { }

	// RVA: 0xD3DA50
	public bool Equals(bool left, bool right) { }

	// RVA: 0xD3DA5C
	public int GetHashCode(bool obj) { }

}

// Namespace: 
private sealed class NullableSystem_BooleanEqualityComparer
{
	// Methods

	// RVA: 0xD3DAC4
	public void .ctor() { }

	// RVA: 0xD3DACC
	public bool Equals(System.Nullable<System.Boolean> left, System.Nullable<System.Boolean> right) { }

	// RVA: 0xD3DC20
	public int GetHashCode(System.Nullable<System.Boolean> obj) { }

}

// Namespace: 
private sealed class System_ByteEqualityComparer
{
	// Methods

	// RVA: 0xD3DCD4
	public void .ctor() { }

	// RVA: 0xD3DCDC
	public bool Equals(Byte left, Byte right) { }

	// RVA: 0xD3DCE8
	public int GetHashCode(Byte obj) { }

}

// Namespace: 
private sealed class NullableSystem_ByteEqualityComparer
{
	// Methods

	// RVA: 0xD3DD10
	public void .ctor() { }

	// RVA: 0xD3DD18
	public bool Equals(System.Nullable<System.Byte> left, System.Nullable<System.Byte> right) { }

	// RVA: 0xD3DE60
	public int GetHashCode(System.Nullable<System.Byte> obj) { }

}

// Namespace: 
private sealed class System_CharEqualityComparer
{
	// Methods

	// RVA: 0xD3DF14
	public void .ctor() { }

	// RVA: 0xD3DF1C
	public bool Equals(Char left, Char right) { }

	// RVA: 0xD3DF28
	public int GetHashCode(Char obj) { }

}

// Namespace: 
private sealed class NullableSystem_CharEqualityComparer
{
	// Methods

	// RVA: 0xD3DF90
	public void .ctor() { }

	// RVA: 0xD3DF98
	public bool Equals(System.Nullable<System.Char> left, System.Nullable<System.Char> right) { }

	// RVA: 0xD3E0DC
	public int GetHashCode(System.Nullable<System.Char> obj) { }

}

// Namespace: 
private sealed class System_ConsoleColorEqualityComparer
{
	// Methods

	// RVA: 0xD3E190
	public void .ctor() { }

	// RVA: 0xD3E198
	public bool Equals(ConsoleColor left, ConsoleColor right) { }

	// RVA: 0xD3E220
	public int GetHashCode(ConsoleColor obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleColorEqualityComparer
{
	// Methods

	// RVA: 0xD3E248
	public void .ctor() { }

	// RVA: 0xD3E250
	public bool Equals(System.Nullable<System.ConsoleColor> left, System.Nullable<System.ConsoleColor> right) { }

	// RVA: 0xD3E3CC
	public int GetHashCode(System.Nullable<System.ConsoleColor> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyEqualityComparer
{
	// Methods

	// RVA: 0xD3E480
	public void .ctor() { }

	// RVA: 0xD3E488
	public bool Equals(ConsoleKey left, ConsoleKey right) { }

	// RVA: 0xD3E510
	public int GetHashCode(ConsoleKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyEqualityComparer
{
	// Methods

	// RVA: 0xD3E538
	public void .ctor() { }

	// RVA: 0xD3E540
	public bool Equals(System.Nullable<System.ConsoleKey> left, System.Nullable<System.ConsoleKey> right) { }

	// RVA: 0xD3E6BC
	public int GetHashCode(System.Nullable<System.ConsoleKey> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyInfoEqualityComparer
{
	// Methods

	// RVA: 0xD3E770
	public void .ctor() { }

	// RVA: 0xD3E778
	public bool Equals(ConsoleKeyInfo left, ConsoleKeyInfo right) { }

	// RVA: 0xD3E7AC
	public int GetHashCode(ConsoleKeyInfo obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyInfoEqualityComparer
{
	// Methods

	// RVA: 0xD3E7D8
	public void .ctor() { }

	// RVA: 0xD3E7E0
	public bool Equals(System.Nullable<System.ConsoleKeyInfo> left, System.Nullable<System.ConsoleKeyInfo> right) { }

	// RVA: 0xD3E93C
	public int GetHashCode(System.Nullable<System.ConsoleKeyInfo> obj) { }

}

// Namespace: 
private sealed class System_ConsoleModifiersEqualityComparer
{
	// Methods

	// RVA: 0xD3E9F0
	public void .ctor() { }

	// RVA: 0xD3E9F8
	public bool Equals(ConsoleModifiers left, ConsoleModifiers right) { }

	// RVA: 0xD3EA80
	public int GetHashCode(ConsoleModifiers obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleModifiersEqualityComparer
{
	// Methods

	// RVA: 0xD3EAA8
	public void .ctor() { }

	// RVA: 0xD3EAB0
	public bool Equals(System.Nullable<System.ConsoleModifiers> left, System.Nullable<System.ConsoleModifiers> right) { }

	// RVA: 0xD3EC2C
	public int GetHashCode(System.Nullable<System.ConsoleModifiers> obj) { }

}

// Namespace: 
private sealed class System_ConsoleSpecialKeyEqualityComparer
{
	// Methods

	// RVA: 0xD3ECE0
	public void .ctor() { }

	// RVA: 0xD3ECE8
	public bool Equals(ConsoleSpecialKey left, ConsoleSpecialKey right) { }

	// RVA: 0xD3ED70
	public int GetHashCode(ConsoleSpecialKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleSpecialKeyEqualityComparer
{
	// Methods

	// RVA: 0xD3ED98
	public void .ctor() { }

	// RVA: 0xD3EDA0
	public bool Equals(System.Nullable<System.ConsoleSpecialKey> left, System.Nullable<System.ConsoleSpecialKey> right) { }

	// RVA: 0xD3EF1C
	public int GetHashCode(System.Nullable<System.ConsoleSpecialKey> obj) { }

}

// Namespace: 
private sealed class System_DateTimeEqualityComparer
{
	// Methods

	// RVA: 0xD3EFD0
	public void .ctor() { }

	// RVA: 0xD3EFD8
	public bool Equals(DateTime left, DateTime right) { }

	// RVA: 0xD3F050
	public int GetHashCode(DateTime obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeEqualityComparer
{
	// Methods

	// RVA: 0xD3F0B8
	public void .ctor() { }

	// RVA: 0xD3F0C0
	public bool Equals(System.Nullable<System.DateTime> left, System.Nullable<System.DateTime> right) { }

	// RVA: 0xD3F234
	public int GetHashCode(System.Nullable<System.DateTime> obj) { }

}

// Namespace: 
private sealed class System_DateTimeKindEqualityComparer
{
	// Methods

	// RVA: 0xD3F2E8
	public void .ctor() { }

	// RVA: 0xD3F2F0
	public bool Equals(DateTimeKind left, DateTimeKind right) { }

	// RVA: 0xD3F378
	public int GetHashCode(DateTimeKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeKindEqualityComparer
{
	// Methods

	// RVA: 0xD3F3A0
	public void .ctor() { }

	// RVA: 0xD3F3A8
	public bool Equals(System.Nullable<System.DateTimeKind> left, System.Nullable<System.DateTimeKind> right) { }

	// RVA: 0xD3F524
	public int GetHashCode(System.Nullable<System.DateTimeKind> obj) { }

}

// Namespace: 
private sealed class System_DateTimeOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD3F5D8
	public void .ctor() { }

	// RVA: 0xD3F5E0
	public bool Equals(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0xD3F660
	public int GetHashCode(DateTimeOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD3F6C8
	public void .ctor() { }

	// RVA: 0xD3F6D0
	public bool Equals(System.Nullable<System.DateTimeOffset> left, System.Nullable<System.DateTimeOffset> right) { }

	// RVA: 0xD3F85C
	public int GetHashCode(System.Nullable<System.DateTimeOffset> obj) { }

}

// Namespace: 
private sealed class System_DayOfWeekEqualityComparer
{
	// Methods

	// RVA: 0xD3F90C
	public void .ctor() { }

	// RVA: 0xD3F914
	public bool Equals(DayOfWeek left, DayOfWeek right) { }

	// RVA: 0xD3F99C
	public int GetHashCode(DayOfWeek obj) { }

}

// Namespace: 
private sealed class NullableSystem_DayOfWeekEqualityComparer
{
	// Methods

	// RVA: 0xD3F9C4
	public void .ctor() { }

	// RVA: 0xD3F9CC
	public bool Equals(System.Nullable<System.DayOfWeek> left, System.Nullable<System.DayOfWeek> right) { }

	// RVA: 0xD3FB48
	public int GetHashCode(System.Nullable<System.DayOfWeek> obj) { }

}

// Namespace: 
private sealed class System_DecimalEqualityComparer
{
	// Methods

	// RVA: 0xD3FBFC
	public void .ctor() { }

	// RVA: 0xD3FC04
	public bool Equals(Decimal left, Decimal right) { }

	// RVA: 0xD3FCB0
	public int GetHashCode(Decimal obj) { }

}

// Namespace: 
private sealed class NullableSystem_DecimalEqualityComparer
{
	// Methods

	// RVA: 0xD3FD44
	public void .ctor() { }

	// RVA: 0xD3FD4C
	public bool Equals(System.Nullable<System.Decimal> left, System.Nullable<System.Decimal> right) { }

	// RVA: 0xD3FF10
	public int GetHashCode(System.Nullable<System.Decimal> obj) { }

}

// Namespace: 
private sealed class System_DoubleEqualityComparer
{
	// Methods

	// RVA: 0xD3FFC0
	public void .ctor() { }

	// RVA: 0xD3FFC8
	public bool Equals(Double left, Double right) { }

	// RVA: 0xD3FFD4
	public int GetHashCode(Double obj) { }

}

// Namespace: 
private sealed class NullableSystem_DoubleEqualityComparer
{
	// Methods

	// RVA: 0xD3FFF4
	public void .ctor() { }

	// RVA: 0xD3FFFC
	public bool Equals(System.Nullable<System.Double> left, System.Nullable<System.Double> right) { }

	// RVA: 0xD40154
	public int GetHashCode(System.Nullable<System.Double> obj) { }

}

// Namespace: 
private sealed class System_EnvironmentVariableTargetEqualityComparer
{
	// Methods

	// RVA: 0xD40208
	public void .ctor() { }

	// RVA: 0xD40210
	public bool Equals(EnvironmentVariableTarget left, EnvironmentVariableTarget right) { }

	// RVA: 0xD40298
	public int GetHashCode(EnvironmentVariableTarget obj) { }

}

// Namespace: 
private sealed class NullableSystem_EnvironmentVariableTargetEqualityComparer
{
	// Methods

	// RVA: 0xD402C0
	public void .ctor() { }

	// RVA: 0xD402C8
	public bool Equals(System.Nullable<System.EnvironmentVariableTarget> left, System.Nullable<System.EnvironmentVariableTarget> right) { }

	// RVA: 0xD40444
	public int GetHashCode(System.Nullable<System.EnvironmentVariableTarget> obj) { }

}

// Namespace: 
private sealed class System_GCCollectionModeEqualityComparer
{
	// Methods

	// RVA: 0xD404F8
	public void .ctor() { }

	// RVA: 0xD40500
	public bool Equals(GCCollectionMode left, GCCollectionMode right) { }

	// RVA: 0xD40588
	public int GetHashCode(GCCollectionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCCollectionModeEqualityComparer
{
	// Methods

	// RVA: 0xD405B0
	public void .ctor() { }

	// RVA: 0xD405B8
	public bool Equals(System.Nullable<System.GCCollectionMode> left, System.Nullable<System.GCCollectionMode> right) { }

	// RVA: 0xD40734
	public int GetHashCode(System.Nullable<System.GCCollectionMode> obj) { }

}

// Namespace: 
private sealed class System_GCNotificationStatusEqualityComparer
{
	// Methods

	// RVA: 0xD407E8
	public void .ctor() { }

	// RVA: 0xD407F0
	public bool Equals(GCNotificationStatus left, GCNotificationStatus right) { }

	// RVA: 0xD40878
	public int GetHashCode(GCNotificationStatus obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCNotificationStatusEqualityComparer
{
	// Methods

	// RVA: 0xD408A0
	public void .ctor() { }

	// RVA: 0xD408A8
	public bool Equals(System.Nullable<System.GCNotificationStatus> left, System.Nullable<System.GCNotificationStatus> right) { }

	// RVA: 0xD40A24
	public int GetHashCode(System.Nullable<System.GCNotificationStatus> obj) { }

}

// Namespace: 
private sealed class System_GuidEqualityComparer
{
	// Methods

	// RVA: 0xD40AD8
	public void .ctor() { }

	// RVA: 0xD40AE0
	public bool Equals(Guid left, Guid right) { }

	// RVA: 0xD40B10
	public int GetHashCode(Guid obj) { }

}

// Namespace: 
private sealed class NullableSystem_GuidEqualityComparer
{
	// Methods

	// RVA: 0xD40B38
	public void .ctor() { }

	// RVA: 0xD40B40
	public bool Equals(System.Nullable<System.Guid> left, System.Nullable<System.Guid> right) { }

	// RVA: 0xD40CA0
	public int GetHashCode(System.Nullable<System.Guid> obj) { }

}

// Namespace: 
private sealed class System_Int16EqualityComparer
{
	// Methods

	// RVA: 0xD40D50
	public void .ctor() { }

	// RVA: 0xD40D58
	public bool Equals(Int16 left, Int16 right) { }

	// RVA: 0xD40D64
	public int GetHashCode(Int16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int16EqualityComparer
{
	// Methods

	// RVA: 0xD40D8C
	public void .ctor() { }

	// RVA: 0xD40D94
	public bool Equals(System.Nullable<System.Int16> left, System.Nullable<System.Int16> right) { }

	// RVA: 0xD40ED8
	public int GetHashCode(System.Nullable<System.Int16> obj) { }

}

// Namespace: 
private sealed class System_Int32EqualityComparer
{
	// Methods

	// RVA: 0xD40F8C
	public void .ctor() { }

	// RVA: 0xD40F94
	public bool Equals(int left, int right) { }

	// RVA: 0xD40FA0
	public int GetHashCode(int obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int32EqualityComparer
{
	// Methods

	// RVA: 0xD40FC8
	public void .ctor() { }

	// RVA: 0xD40FD0
	public bool Equals(System.Nullable<System.Int32> left, System.Nullable<System.Int32> right) { }

	// RVA: 0xD41114
	public int GetHashCode(System.Nullable<System.Int32> obj) { }

}

// Namespace: 
private sealed class System_Int64EqualityComparer
{
	// Methods

	// RVA: 0xD411C8
	public void .ctor() { }

	// RVA: 0xD411D0
	public bool Equals(Int64 left, Int64 right) { }

	// RVA: 0xD411DC
	public int GetHashCode(Int64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int64EqualityComparer
{
	// Methods

	// RVA: 0xD41204
	public void .ctor() { }

	// RVA: 0xD4120C
	public bool Equals(System.Nullable<System.Int64> left, System.Nullable<System.Int64> right) { }

	// RVA: 0xD41354
	public int GetHashCode(System.Nullable<System.Int64> obj) { }

}

// Namespace: 
private sealed class System_IntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD41408
	public void .ctor() { }

	// RVA: 0xD41410
	public bool Equals(IntPtr left, IntPtr right) { }

	// RVA: 0xD41420
	public int GetHashCode(IntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_IntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD41448
	public void .ctor() { }

	// RVA: 0xD41450
	public bool Equals(System.Nullable<System.IntPtr> left, System.Nullable<System.IntPtr> right) { }

	// RVA: 0xD4159C
	public int GetHashCode(System.Nullable<System.IntPtr> obj) { }

}

// Namespace: 
private sealed class System_LoaderOptimizationEqualityComparer
{
	// Methods

	// RVA: 0xD41650
	public void .ctor() { }

	// RVA: 0xD41658
	public bool Equals(LoaderOptimization left, LoaderOptimization right) { }

	// RVA: 0xD416E0
	public int GetHashCode(LoaderOptimization obj) { }

}

// Namespace: 
private sealed class NullableSystem_LoaderOptimizationEqualityComparer
{
	// Methods

	// RVA: 0xD41708
	public void .ctor() { }

	// RVA: 0xD41710
	public bool Equals(System.Nullable<System.LoaderOptimization> left, System.Nullable<System.LoaderOptimization> right) { }

	// RVA: 0xD4188C
	public int GetHashCode(System.Nullable<System.LoaderOptimization> obj) { }

}

// Namespace: 
private sealed class System_MidpointRoundingEqualityComparer
{
	// Methods

	// RVA: 0xD41940
	public void .ctor() { }

	// RVA: 0xD41948
	public bool Equals(MidpointRounding left, MidpointRounding right) { }

	// RVA: 0xD419D0
	public int GetHashCode(MidpointRounding obj) { }

}

// Namespace: 
private sealed class NullableSystem_MidpointRoundingEqualityComparer
{
	// Methods

	// RVA: 0xD419F8
	public void .ctor() { }

	// RVA: 0xD41A00
	public bool Equals(System.Nullable<System.MidpointRounding> left, System.Nullable<System.MidpointRounding> right) { }

	// RVA: 0xD41B7C
	public int GetHashCode(System.Nullable<System.MidpointRounding> obj) { }

}

// Namespace: 
private sealed class System_ModuleHandleEqualityComparer
{
	// Methods

	// RVA: 0xD41C30
	public void .ctor() { }

	// RVA: 0xD41C38
	public bool Equals(ModuleHandle left, ModuleHandle right) { }

	// RVA: 0xD41CB0
	public int GetHashCode(ModuleHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_ModuleHandleEqualityComparer
{
	// Methods

	// RVA: 0xD41D18
	public void .ctor() { }

	// RVA: 0xD41D20
	public bool Equals(System.Nullable<System.ModuleHandle> left, System.Nullable<System.ModuleHandle> right) { }

	// RVA: 0xD41E94
	public int GetHashCode(System.Nullable<System.ModuleHandle> obj) { }

}

// Namespace: 
private sealed class System_PlatformIDEqualityComparer
{
	// Methods

	// RVA: 0xD41F48
	public void .ctor() { }

	// RVA: 0xD41F50
	public bool Equals(PlatformID left, PlatformID right) { }

	// RVA: 0xD41FD8
	public int GetHashCode(PlatformID obj) { }

}

// Namespace: 
private sealed class NullableSystem_PlatformIDEqualityComparer
{
	// Methods

	// RVA: 0xD42000
	public void .ctor() { }

	// RVA: 0xD42008
	public bool Equals(System.Nullable<System.PlatformID> left, System.Nullable<System.PlatformID> right) { }

	// RVA: 0xD42184
	public int GetHashCode(System.Nullable<System.PlatformID> obj) { }

}

// Namespace: 
private sealed class System_RuntimeFieldHandleEqualityComparer
{
	// Methods

	// RVA: 0xD42238
	public void .ctor() { }

	// RVA: 0xD42240
	public bool Equals(RuntimeFieldHandle left, RuntimeFieldHandle right) { }

	// RVA: 0xD4226C
	public int GetHashCode(RuntimeFieldHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeFieldHandleEqualityComparer
{
	// Methods

	// RVA: 0xD42294
	public void .ctor() { }

	// RVA: 0xD4229C
	public bool Equals(System.Nullable<System.RuntimeFieldHandle> left, System.Nullable<System.RuntimeFieldHandle> right) { }

	// RVA: 0xD423E8
	public int GetHashCode(System.Nullable<System.RuntimeFieldHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeMethodHandleEqualityComparer
{
	// Methods

	// RVA: 0xD4249C
	public void .ctor() { }

	// RVA: 0xD424A4
	public bool Equals(RuntimeMethodHandle left, RuntimeMethodHandle right) { }

	// RVA: 0xD424D0
	public int GetHashCode(RuntimeMethodHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeMethodHandleEqualityComparer
{
	// Methods

	// RVA: 0xD424F8
	public void .ctor() { }

	// RVA: 0xD42500
	public bool Equals(System.Nullable<System.RuntimeMethodHandle> left, System.Nullable<System.RuntimeMethodHandle> right) { }

	// RVA: 0xD4264C
	public int GetHashCode(System.Nullable<System.RuntimeMethodHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeTypeHandleEqualityComparer
{
	// Methods

	// RVA: 0xD42700
	public void .ctor() { }

	// RVA: 0xD42708
	public bool Equals(RuntimeTypeHandle left, RuntimeTypeHandle right) { }

	// RVA: 0xD42734
	public int GetHashCode(RuntimeTypeHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeTypeHandleEqualityComparer
{
	// Methods

	// RVA: 0xD4275C
	public void .ctor() { }

	// RVA: 0xD42764
	public bool Equals(System.Nullable<System.RuntimeTypeHandle> left, System.Nullable<System.RuntimeTypeHandle> right) { }

	// RVA: 0xD428B0
	public int GetHashCode(System.Nullable<System.RuntimeTypeHandle> obj) { }

}

// Namespace: 
private sealed class System_SByteEqualityComparer
{
	// Methods

	// RVA: 0xD42964
	public void .ctor() { }

	// RVA: 0xD4296C
	public bool Equals(SByte left, SByte right) { }

	// RVA: 0xD42978
	public int GetHashCode(SByte obj) { }

}

// Namespace: 
private sealed class NullableSystem_SByteEqualityComparer
{
	// Methods

	// RVA: 0xD429A0
	public void .ctor() { }

	// RVA: 0xD429A8
	public bool Equals(System.Nullable<System.SByte> left, System.Nullable<System.SByte> right) { }

	// RVA: 0xD42AF0
	public int GetHashCode(System.Nullable<System.SByte> obj) { }

}

// Namespace: 
private sealed class System_SingleEqualityComparer
{
	// Methods

	// RVA: 0xD42BA4
	public void .ctor() { }

	// RVA: 0xD42BAC
	public bool Equals(float left, float right) { }

	// RVA: 0xD42BB8
	public int GetHashCode(float obj) { }

}

// Namespace: 
private sealed class NullableSystem_SingleEqualityComparer
{
	// Methods

	// RVA: 0xD42BE0
	public void .ctor() { }

	// RVA: 0xD42BE8
	public bool Equals(System.Nullable<System.Single> left, System.Nullable<System.Single> right) { }

	// RVA: 0xD42D3C
	public int GetHashCode(System.Nullable<System.Single> obj) { }

}

// Namespace: 
private sealed class System_StringComparisonEqualityComparer
{
	// Methods

	// RVA: 0xD42DF0
	public void .ctor() { }

	// RVA: 0xD42DF8
	public bool Equals(StringComparison left, StringComparison right) { }

	// RVA: 0xD42E80
	public int GetHashCode(StringComparison obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringComparisonEqualityComparer
{
	// Methods

	// RVA: 0xD42EA8
	public void .ctor() { }

	// RVA: 0xD42EB0
	public bool Equals(System.Nullable<System.StringComparison> left, System.Nullable<System.StringComparison> right) { }

	// RVA: 0xD4302C
	public int GetHashCode(System.Nullable<System.StringComparison> obj) { }

}

// Namespace: 
private sealed class System_StringSplitOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD430E0
	public void .ctor() { }

	// RVA: 0xD430E8
	public bool Equals(StringSplitOptions left, StringSplitOptions right) { }

	// RVA: 0xD43170
	public int GetHashCode(StringSplitOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringSplitOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD43198
	public void .ctor() { }

	// RVA: 0xD431A0
	public bool Equals(System.Nullable<System.StringSplitOptions> left, System.Nullable<System.StringSplitOptions> right) { }

	// RVA: 0xD4331C
	public int GetHashCode(System.Nullable<System.StringSplitOptions> obj) { }

}

// Namespace: 
private sealed class System_TimeSpanEqualityComparer
{
	// Methods

	// RVA: 0xD433D0
	public void .ctor() { }

	// RVA: 0xD433D8
	public bool Equals(TimeSpan left, TimeSpan right) { }

	// RVA: 0xD43450
	public int GetHashCode(TimeSpan obj) { }

}

// Namespace: 
private sealed class NullableSystem_TimeSpanEqualityComparer
{
	// Methods

	// RVA: 0xD434B8
	public void .ctor() { }

	// RVA: 0xD434C0
	public bool Equals(System.Nullable<System.TimeSpan> left, System.Nullable<System.TimeSpan> right) { }

	// RVA: 0xD43634
	public int GetHashCode(System.Nullable<System.TimeSpan> obj) { }

}

// Namespace: 
private sealed class System_TypeCodeEqualityComparer
{
	// Methods

	// RVA: 0xD436E8
	public void .ctor() { }

	// RVA: 0xD436F0
	public bool Equals(TypeCode left, TypeCode right) { }

	// RVA: 0xD43778
	public int GetHashCode(TypeCode obj) { }

}

// Namespace: 
private sealed class NullableSystem_TypeCodeEqualityComparer
{
	// Methods

	// RVA: 0xD437A0
	public void .ctor() { }

	// RVA: 0xD437A8
	public bool Equals(System.Nullable<System.TypeCode> left, System.Nullable<System.TypeCode> right) { }

	// RVA: 0xD43924
	public int GetHashCode(System.Nullable<System.TypeCode> obj) { }

}

// Namespace: 
private sealed class System_UInt16EqualityComparer
{
	// Methods

	// RVA: 0xD439D8
	public void .ctor() { }

	// RVA: 0xD439E0
	public bool Equals(UInt16 left, UInt16 right) { }

	// RVA: 0xD439EC
	public int GetHashCode(UInt16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt16EqualityComparer
{
	// Methods

	// RVA: 0xD43A14
	public void .ctor() { }

	// RVA: 0xD43A1C
	public bool Equals(System.Nullable<System.UInt16> left, System.Nullable<System.UInt16> right) { }

	// RVA: 0xD43B60
	public int GetHashCode(System.Nullable<System.UInt16> obj) { }

}

// Namespace: 
private sealed class System_UInt32EqualityComparer
{
	// Methods

	// RVA: 0xD43C14
	public void .ctor() { }

	// RVA: 0xD43C1C
	public bool Equals(UInt32 left, UInt32 right) { }

	// RVA: 0xD43C28
	public int GetHashCode(UInt32 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt32EqualityComparer
{
	// Methods

	// RVA: 0xD43C50
	public void .ctor() { }

	// RVA: 0xD43C58
	public bool Equals(System.Nullable<System.UInt32> left, System.Nullable<System.UInt32> right) { }

	// RVA: 0xD43D9C
	public int GetHashCode(System.Nullable<System.UInt32> obj) { }

}

// Namespace: 
private sealed class System_UInt64EqualityComparer
{
	// Methods

	// RVA: 0xD43E50
	public void .ctor() { }

	// RVA: 0xD43E58
	public bool Equals(UInt64 left, UInt64 right) { }

	// RVA: 0xD43E64
	public int GetHashCode(UInt64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt64EqualityComparer
{
	// Methods

	// RVA: 0xD43E8C
	public void .ctor() { }

	// RVA: 0xD43E94
	public bool Equals(System.Nullable<System.UInt64> left, System.Nullable<System.UInt64> right) { }

	// RVA: 0xD43FDC
	public int GetHashCode(System.Nullable<System.UInt64> obj) { }

}

// Namespace: 
private sealed class System_UIntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD44090
	public void .ctor() { }

	// RVA: 0xD44098
	public bool Equals(UIntPtr left, UIntPtr right) { }

	// RVA: 0xD440A8
	public int GetHashCode(UIntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_UIntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD440D0
	public void .ctor() { }

	// RVA: 0xD440D8
	public bool Equals(System.Nullable<System.UIntPtr> left, System.Nullable<System.UIntPtr> right) { }

	// RVA: 0xD44224
	public int GetHashCode(System.Nullable<System.UIntPtr> obj) { }

}

// Namespace: 
private sealed class System_Collections_DictionaryEntryEqualityComparer
{
	// Methods

	// RVA: 0xD442D8
	public void .ctor() { }

	// RVA: 0xD442E0
	public bool Equals(DictionaryEntry left, DictionaryEntry right) { }

	// RVA: 0xD44378
	public int GetHashCode(DictionaryEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Collections_DictionaryEntryEqualityComparer
{
	// Methods

	// RVA: 0xD443EC
	public void .ctor() { }

	// RVA: 0xD443F4
	public bool Equals(System.Nullable<System.Collections.DictionaryEntry> left, System.Nullable<System.Collections.DictionaryEntry> right) { }

	// RVA: 0xD44588
	public int GetHashCode(System.Nullable<System.Collections.DictionaryEntry> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_DebuggerBrowsableStateEqualityComparer
{
	// Methods

	// RVA: 0xD44638
	public void .ctor() { }

	// RVA: 0xD44640
	public bool Equals(DebuggerBrowsableState left, DebuggerBrowsableState right) { }

	// RVA: 0xD446C8
	public int GetHashCode(DebuggerBrowsableState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_DebuggerBrowsableStateEqualityComparer
{
	// Methods

	// RVA: 0xD446F0
	public void .ctor() { }

	// RVA: 0xD446F8
	public bool Equals(System.Nullable<System.Diagnostics.DebuggerBrowsableState> left, System.Nullable<System.Diagnostics.DebuggerBrowsableState> right) { }

	// RVA: 0xD44874
	public int GetHashCode(System.Nullable<System.Diagnostics.DebuggerBrowsableState> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymAddressKindEqualityComparer
{
	// Methods

	// RVA: 0xD44928
	public void .ctor() { }

	// RVA: 0xD44930
	public bool Equals(SymAddressKind left, SymAddressKind right) { }

	// RVA: 0xD449B8
	public int GetHashCode(SymAddressKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymAddressKindEqualityComparer
{
	// Methods

	// RVA: 0xD449E0
	public void .ctor() { }

	// RVA: 0xD449E8
	public bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> left, System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> right) { }

	// RVA: 0xD44B64
	public int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymbolTokenEqualityComparer
{
	// Methods

	// RVA: 0xD44C18
	public void .ctor() { }

	// RVA: 0xD44C20
	public bool Equals(SymbolToken left, SymbolToken right) { }

	// RVA: 0xD44C4C
	public int GetHashCode(SymbolToken obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymbolTokenEqualityComparer
{
	// Methods

	// RVA: 0xD44C54
	public void .ctor() { }

	// RVA: 0xD44C5C
	public bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> left, System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> right) { }

	// RVA: 0xD44DA4
	public int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarAlgorithmTypeEqualityComparer
{
	// Methods

	// RVA: 0xD44E58
	public void .ctor() { }

	// RVA: 0xD44E60
	public bool Equals(CalendarAlgorithmType left, CalendarAlgorithmType right) { }

	// RVA: 0xD44EE8
	public int GetHashCode(CalendarAlgorithmType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarAlgorithmTypeEqualityComparer
{
	// Methods

	// RVA: 0xD44F10
	public void .ctor() { }

	// RVA: 0xD44F18
	public bool Equals(System.Nullable<System.Globalization.CalendarAlgorithmType> left, System.Nullable<System.Globalization.CalendarAlgorithmType> right) { }

	// RVA: 0xD45094
	public int GetHashCode(System.Nullable<System.Globalization.CalendarAlgorithmType> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarWeekRuleEqualityComparer
{
	// Methods

	// RVA: 0xD45148
	public void .ctor() { }

	// RVA: 0xD45150
	public bool Equals(CalendarWeekRule left, CalendarWeekRule right) { }

	// RVA: 0xD451D8
	public int GetHashCode(CalendarWeekRule obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarWeekRuleEqualityComparer
{
	// Methods

	// RVA: 0xD45200
	public void .ctor() { }

	// RVA: 0xD45208
	public bool Equals(System.Nullable<System.Globalization.CalendarWeekRule> left, System.Nullable<System.Globalization.CalendarWeekRule> right) { }

	// RVA: 0xD45384
	public int GetHashCode(System.Nullable<System.Globalization.CalendarWeekRule> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CompareOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD45438
	public void .ctor() { }

	// RVA: 0xD45440
	public bool Equals(CompareOptions left, CompareOptions right) { }

	// RVA: 0xD454C8
	public int GetHashCode(CompareOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CompareOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD454F0
	public void .ctor() { }

	// RVA: 0xD454F8
	public bool Equals(System.Nullable<System.Globalization.CompareOptions> left, System.Nullable<System.Globalization.CompareOptions> right) { }

	// RVA: 0xD45674
	public int GetHashCode(System.Nullable<System.Globalization.CompareOptions> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CultureTypesEqualityComparer
{
	// Methods

	// RVA: 0xD45728
	public void .ctor() { }

	// RVA: 0xD45730
	public bool Equals(CultureTypes left, CultureTypes right) { }

	// RVA: 0xD457B8
	public int GetHashCode(CultureTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CultureTypesEqualityComparer
{
	// Methods

	// RVA: 0xD457E0
	public void .ctor() { }

	// RVA: 0xD457E8
	public bool Equals(System.Nullable<System.Globalization.CultureTypes> left, System.Nullable<System.Globalization.CultureTypes> right) { }

	// RVA: 0xD45964
	public int GetHashCode(System.Nullable<System.Globalization.CultureTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DateTimeStylesEqualityComparer
{
	// Methods

	// RVA: 0xD45A18
	public void .ctor() { }

	// RVA: 0xD45A20
	public bool Equals(DateTimeStyles left, DateTimeStyles right) { }

	// RVA: 0xD45AA8
	public int GetHashCode(DateTimeStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DateTimeStylesEqualityComparer
{
	// Methods

	// RVA: 0xD45AD0
	public void .ctor() { }

	// RVA: 0xD45AD8
	public bool Equals(System.Nullable<System.Globalization.DateTimeStyles> left, System.Nullable<System.Globalization.DateTimeStyles> right) { }

	// RVA: 0xD45C54
	public int GetHashCode(System.Nullable<System.Globalization.DateTimeStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DigitShapesEqualityComparer
{
	// Methods

	// RVA: 0xD45D08
	public void .ctor() { }

	// RVA: 0xD45D10
	public bool Equals(DigitShapes left, DigitShapes right) { }

	// RVA: 0xD45D98
	public int GetHashCode(DigitShapes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DigitShapesEqualityComparer
{
	// Methods

	// RVA: 0xD45DC0
	public void .ctor() { }

	// RVA: 0xD45DC8
	public bool Equals(System.Nullable<System.Globalization.DigitShapes> left, System.Nullable<System.Globalization.DigitShapes> right) { }

	// RVA: 0xD45F44
	public int GetHashCode(System.Nullable<System.Globalization.DigitShapes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_GregorianCalendarTypesEqualityComparer
{
	// Methods

	// RVA: 0xD45FF8
	public void .ctor() { }

	// RVA: 0xD46000
	public bool Equals(GregorianCalendarTypes left, GregorianCalendarTypes right) { }

	// RVA: 0xD46088
	public int GetHashCode(GregorianCalendarTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_GregorianCalendarTypesEqualityComparer
{
	// Methods

	// RVA: 0xD460B0
	public void .ctor() { }

	// RVA: 0xD460B8
	public bool Equals(System.Nullable<System.Globalization.GregorianCalendarTypes> left, System.Nullable<System.Globalization.GregorianCalendarTypes> right) { }

	// RVA: 0xD46234
	public int GetHashCode(System.Nullable<System.Globalization.GregorianCalendarTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_NumberStylesEqualityComparer
{
	// Methods

	// RVA: 0xD462E8
	public void .ctor() { }

	// RVA: 0xD462F0
	public bool Equals(NumberStyles left, NumberStyles right) { }

	// RVA: 0xD46378
	public int GetHashCode(NumberStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_NumberStylesEqualityComparer
{
	// Methods

	// RVA: 0xD463A0
	public void .ctor() { }

	// RVA: 0xD463A8
	public bool Equals(System.Nullable<System.Globalization.NumberStyles> left, System.Nullable<System.Globalization.NumberStyles> right) { }

	// RVA: 0xD46524
	public int GetHashCode(System.Nullable<System.Globalization.NumberStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_UnicodeCategoryEqualityComparer
{
	// Methods

	// RVA: 0xD465D8
	public void .ctor() { }

	// RVA: 0xD465E0
	public bool Equals(UnicodeCategory left, UnicodeCategory right) { }

	// RVA: 0xD46668
	public int GetHashCode(UnicodeCategory obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_UnicodeCategoryEqualityComparer
{
	// Methods

	// RVA: 0xD46690
	public void .ctor() { }

	// RVA: 0xD46698
	public bool Equals(System.Nullable<System.Globalization.UnicodeCategory> left, System.Nullable<System.Globalization.UnicodeCategory> right) { }

	// RVA: 0xD46814
	public int GetHashCode(System.Nullable<System.Globalization.UnicodeCategory> obj) { }

}

// Namespace: 
private sealed class System_IO_DriveTypeEqualityComparer
{
	// Methods

	// RVA: 0xD468C8
	public void .ctor() { }

	// RVA: 0xD468D0
	public bool Equals(DriveType left, DriveType right) { }

	// RVA: 0xD46958
	public int GetHashCode(DriveType obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_DriveTypeEqualityComparer
{
	// Methods

	// RVA: 0xD46980
	public void .ctor() { }

	// RVA: 0xD46988
	public bool Equals(System.Nullable<System.IO.DriveType> left, System.Nullable<System.IO.DriveType> right) { }

	// RVA: 0xD46B04
	public int GetHashCode(System.Nullable<System.IO.DriveType> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAccessEqualityComparer
{
	// Methods

	// RVA: 0xD46BB8
	public void .ctor() { }

	// RVA: 0xD46BC0
	public bool Equals(FileAccess left, FileAccess right) { }

	// RVA: 0xD46C48
	public int GetHashCode(FileAccess obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAccessEqualityComparer
{
	// Methods

	// RVA: 0xD46C70
	public void .ctor() { }

	// RVA: 0xD46C78
	public bool Equals(System.Nullable<System.IO.FileAccess> left, System.Nullable<System.IO.FileAccess> right) { }

	// RVA: 0xD46DF4
	public int GetHashCode(System.Nullable<System.IO.FileAccess> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD46EA8
	public void .ctor() { }

	// RVA: 0xD46EB0
	public bool Equals(FileAttributes left, FileAttributes right) { }

	// RVA: 0xD46F38
	public int GetHashCode(FileAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD46F60
	public void .ctor() { }

	// RVA: 0xD46F68
	public bool Equals(System.Nullable<System.IO.FileAttributes> left, System.Nullable<System.IO.FileAttributes> right) { }

	// RVA: 0xD470E4
	public int GetHashCode(System.Nullable<System.IO.FileAttributes> obj) { }

}

// Namespace: 
private sealed class System_IO_FileModeEqualityComparer
{
	// Methods

	// RVA: 0xD47198
	public void .ctor() { }

	// RVA: 0xD471A0
	public bool Equals(FileMode left, FileMode right) { }

	// RVA: 0xD47228
	public int GetHashCode(FileMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileModeEqualityComparer
{
	// Methods

	// RVA: 0xD47250
	public void .ctor() { }

	// RVA: 0xD47258
	public bool Equals(System.Nullable<System.IO.FileMode> left, System.Nullable<System.IO.FileMode> right) { }

	// RVA: 0xD473D4
	public int GetHashCode(System.Nullable<System.IO.FileMode> obj) { }

}

// Namespace: 
private sealed class System_IO_FileOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD47488
	public void .ctor() { }

	// RVA: 0xD47490
	public bool Equals(FileOptions left, FileOptions right) { }

	// RVA: 0xD47518
	public int GetHashCode(FileOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD47540
	public void .ctor() { }

	// RVA: 0xD47548
	public bool Equals(System.Nullable<System.IO.FileOptions> left, System.Nullable<System.IO.FileOptions> right) { }

	// RVA: 0xD476C4
	public int GetHashCode(System.Nullable<System.IO.FileOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_FileShareEqualityComparer
{
	// Methods

	// RVA: 0xD47778
	public void .ctor() { }

	// RVA: 0xD47780
	public bool Equals(FileShare left, FileShare right) { }

	// RVA: 0xD47808
	public int GetHashCode(FileShare obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileShareEqualityComparer
{
	// Methods

	// RVA: 0xD47830
	public void .ctor() { }

	// RVA: 0xD47838
	public bool Equals(System.Nullable<System.IO.FileShare> left, System.Nullable<System.IO.FileShare> right) { }

	// RVA: 0xD479B4
	public int GetHashCode(System.Nullable<System.IO.FileShare> obj) { }

}

// Namespace: 
private sealed class System_IO_HandleInheritabilityEqualityComparer
{
	// Methods

	// RVA: 0xD47A68
	public void .ctor() { }

	// RVA: 0xD47A70
	public bool Equals(HandleInheritability left, HandleInheritability right) { }

	// RVA: 0xD47AF8
	public int GetHashCode(HandleInheritability obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_HandleInheritabilityEqualityComparer
{
	// Methods

	// RVA: 0xD47B20
	public void .ctor() { }

	// RVA: 0xD47B28
	public bool Equals(System.Nullable<System.IO.HandleInheritability> left, System.Nullable<System.IO.HandleInheritability> right) { }

	// RVA: 0xD47CA4
	public int GetHashCode(System.Nullable<System.IO.HandleInheritability> obj) { }

}

// Namespace: 
private sealed class System_IO_SearchOptionEqualityComparer
{
	// Methods

	// RVA: 0xD47D58
	public void .ctor() { }

	// RVA: 0xD47D60
	public bool Equals(SearchOption left, SearchOption right) { }

	// RVA: 0xD47DE8
	public int GetHashCode(SearchOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SearchOptionEqualityComparer
{
	// Methods

	// RVA: 0xD47E10
	public void .ctor() { }

	// RVA: 0xD47E18
	public bool Equals(System.Nullable<System.IO.SearchOption> left, System.Nullable<System.IO.SearchOption> right) { }

	// RVA: 0xD47F94
	public int GetHashCode(System.Nullable<System.IO.SearchOption> obj) { }

}

// Namespace: 
private sealed class System_IO_SeekOriginEqualityComparer
{
	// Methods

	// RVA: 0xD48048
	public void .ctor() { }

	// RVA: 0xD48050
	public bool Equals(SeekOrigin left, SeekOrigin right) { }

	// RVA: 0xD480D8
	public int GetHashCode(SeekOrigin obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SeekOriginEqualityComparer
{
	// Methods

	// RVA: 0xD48100
	public void .ctor() { }

	// RVA: 0xD48108
	public bool Equals(System.Nullable<System.IO.SeekOrigin> left, System.Nullable<System.IO.SeekOrigin> right) { }

	// RVA: 0xD48284
	public int GetHashCode(System.Nullable<System.IO.SeekOrigin> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeAccessRightsEqualityComparer
{
	// Methods

	// RVA: 0xD48338
	public void .ctor() { }

	// RVA: 0xD48340
	public bool Equals(PipeAccessRights left, PipeAccessRights right) { }

	// RVA: 0xD483C8
	public int GetHashCode(PipeAccessRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeAccessRightsEqualityComparer
{
	// Methods

	// RVA: 0xD483F0
	public void .ctor() { }

	// RVA: 0xD483F8
	public bool Equals(System.Nullable<System.IO.Pipes.PipeAccessRights> left, System.Nullable<System.IO.Pipes.PipeAccessRights> right) { }

	// RVA: 0xD48574
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeAccessRights> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeDirectionEqualityComparer
{
	// Methods

	// RVA: 0xD48628
	public void .ctor() { }

	// RVA: 0xD48630
	public bool Equals(PipeDirection left, PipeDirection right) { }

	// RVA: 0xD486B8
	public int GetHashCode(PipeDirection obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeDirectionEqualityComparer
{
	// Methods

	// RVA: 0xD486E0
	public void .ctor() { }

	// RVA: 0xD486E8
	public bool Equals(System.Nullable<System.IO.Pipes.PipeDirection> left, System.Nullable<System.IO.Pipes.PipeDirection> right) { }

	// RVA: 0xD48864
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeDirection> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD48918
	public void .ctor() { }

	// RVA: 0xD48920
	public bool Equals(PipeOptions left, PipeOptions right) { }

	// RVA: 0xD489A8
	public int GetHashCode(PipeOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD489D0
	public void .ctor() { }

	// RVA: 0xD489D8
	public bool Equals(System.Nullable<System.IO.Pipes.PipeOptions> left, System.Nullable<System.IO.Pipes.PipeOptions> right) { }

	// RVA: 0xD48B54
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeTransmissionModeEqualityComparer
{
	// Methods

	// RVA: 0xD48C08
	public void .ctor() { }

	// RVA: 0xD48C10
	public bool Equals(PipeTransmissionMode left, PipeTransmissionMode right) { }

	// RVA: 0xD48C98
	public int GetHashCode(PipeTransmissionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeTransmissionModeEqualityComparer
{
	// Methods

	// RVA: 0xD48CC0
	public void .ctor() { }

	// RVA: 0xD48CC8
	public bool Equals(System.Nullable<System.IO.Pipes.PipeTransmissionMode> left, System.Nullable<System.IO.Pipes.PipeTransmissionMode> right) { }

	// RVA: 0xD48E44
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeTransmissionMode> obj) { }

}

// Namespace: 
private sealed class System_Reflection_AssemblyNameFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD48EF8
	public void .ctor() { }

	// RVA: 0xD48F00
	public bool Equals(AssemblyNameFlags left, AssemblyNameFlags right) { }

	// RVA: 0xD48F88
	public int GetHashCode(AssemblyNameFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_AssemblyNameFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD48FB0
	public void .ctor() { }

	// RVA: 0xD48FB8
	public bool Equals(System.Nullable<System.Reflection.AssemblyNameFlags> left, System.Nullable<System.Reflection.AssemblyNameFlags> right) { }

	// RVA: 0xD49134
	public int GetHashCode(System.Nullable<System.Reflection.AssemblyNameFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_BindingFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD491E8
	public void .ctor() { }

	// RVA: 0xD491F0
	public bool Equals(BindingFlags left, BindingFlags right) { }

	// RVA: 0xD49278
	public int GetHashCode(BindingFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_BindingFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD492A0
	public void .ctor() { }

	// RVA: 0xD492A8
	public bool Equals(System.Nullable<System.Reflection.BindingFlags> left, System.Nullable<System.Reflection.BindingFlags> right) { }

	// RVA: 0xD49424
	public int GetHashCode(System.Nullable<System.Reflection.BindingFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CallingConventionsEqualityComparer
{
	// Methods

	// RVA: 0xD494D8
	public void .ctor() { }

	// RVA: 0xD494E0
	public bool Equals(CallingConventions left, CallingConventions right) { }

	// RVA: 0xD49568
	public int GetHashCode(CallingConventions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CallingConventionsEqualityComparer
{
	// Methods

	// RVA: 0xD49590
	public void .ctor() { }

	// RVA: 0xD49598
	public bool Equals(System.Nullable<System.Reflection.CallingConventions> left, System.Nullable<System.Reflection.CallingConventions> right) { }

	// RVA: 0xD49714
	public int GetHashCode(System.Nullable<System.Reflection.CallingConventions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeNamedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD497C8
	public void .ctor() { }

	// RVA: 0xD497D0
	public bool Equals(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0xD49854
	public int GetHashCode(CustomAttributeNamedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeNamedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD49860
	public void .ctor() { }

	// RVA: 0xD49868
	public bool Equals(System.Nullable<System.Reflection.CustomAttributeNamedArgument> left, System.Nullable<System.Reflection.CustomAttributeNamedArgument> right) { }

	// RVA: 0xD49A00
	public int GetHashCode(System.Nullable<System.Reflection.CustomAttributeNamedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeTypedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD49AB0
	public void .ctor() { }

	// RVA: 0xD49AB8
	public bool Equals(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0xD49B34
	public int GetHashCode(CustomAttributeTypedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeTypedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD49B5C
	public void .ctor() { }

	// RVA: 0xD49B64
	public bool Equals(System.Nullable<System.Reflection.CustomAttributeTypedArgument> left, System.Nullable<System.Reflection.CustomAttributeTypedArgument> right) { }

	// RVA: 0xD49CEC
	public int GetHashCode(System.Nullable<System.Reflection.CustomAttributeTypedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_EventAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD49D9C
	public void .ctor() { }

	// RVA: 0xD49DA4
	public bool Equals(EventAttributes left, EventAttributes right) { }

	// RVA: 0xD49E2C
	public int GetHashCode(EventAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_EventAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD49E54
	public void .ctor() { }

	// RVA: 0xD49E5C
	public bool Equals(System.Nullable<System.Reflection.EventAttributes> left, System.Nullable<System.Reflection.EventAttributes> right) { }

	// RVA: 0xD49FD8
	public int GetHashCode(System.Nullable<System.Reflection.EventAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ExceptionHandlingClauseOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD4A08C
	public void .ctor() { }

	// RVA: 0xD4A094
	public bool Equals(ExceptionHandlingClauseOptions left, ExceptionHandlingClauseOptions right) { }

	// RVA: 0xD4A11C
	public int GetHashCode(ExceptionHandlingClauseOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ExceptionHandlingClauseOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD4A144
	public void .ctor() { }

	// RVA: 0xD4A14C
	public bool Equals(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> left, System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> right) { }

	// RVA: 0xD4A2C8
	public int GetHashCode(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_FieldAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4A37C
	public void .ctor() { }

	// RVA: 0xD4A384
	public bool Equals(FieldAttributes left, FieldAttributes right) { }

	// RVA: 0xD4A40C
	public int GetHashCode(FieldAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_FieldAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4A434
	public void .ctor() { }

	// RVA: 0xD4A43C
	public bool Equals(System.Nullable<System.Reflection.FieldAttributes> left, System.Nullable<System.Reflection.FieldAttributes> right) { }

	// RVA: 0xD4A5B8
	public int GetHashCode(System.Nullable<System.Reflection.FieldAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_GenericParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4A66C
	public void .ctor() { }

	// RVA: 0xD4A674
	public bool Equals(GenericParameterAttributes left, GenericParameterAttributes right) { }

	// RVA: 0xD4A6FC
	public int GetHashCode(GenericParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_GenericParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4A724
	public void .ctor() { }

	// RVA: 0xD4A72C
	public bool Equals(System.Nullable<System.Reflection.GenericParameterAttributes> left, System.Nullable<System.Reflection.GenericParameterAttributes> right) { }

	// RVA: 0xD4A8A8
	public int GetHashCode(System.Nullable<System.Reflection.GenericParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ImageFileMachineEqualityComparer
{
	// Methods

	// RVA: 0xD4A95C
	public void .ctor() { }

	// RVA: 0xD4A964
	public bool Equals(ImageFileMachine left, ImageFileMachine right) { }

	// RVA: 0xD4A9EC
	public int GetHashCode(ImageFileMachine obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ImageFileMachineEqualityComparer
{
	// Methods

	// RVA: 0xD4AA14
	public void .ctor() { }

	// RVA: 0xD4AA1C
	public bool Equals(System.Nullable<System.Reflection.ImageFileMachine> left, System.Nullable<System.Reflection.ImageFileMachine> right) { }

	// RVA: 0xD4AB98
	public int GetHashCode(System.Nullable<System.Reflection.ImageFileMachine> obj) { }

}

// Namespace: 
private sealed class System_Reflection_InterfaceMappingEqualityComparer
{
	// Methods

	// RVA: 0xD4AC4C
	public void .ctor() { }

	// RVA: 0xD4AC54
	public bool Equals(InterfaceMapping left, InterfaceMapping right) { }

	// RVA: 0xD4ACE4
	public int GetHashCode(InterfaceMapping obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_InterfaceMappingEqualityComparer
{
	// Methods

	// RVA: 0xD4AD58
	public void .ctor() { }

	// RVA: 0xD4AD60
	public bool Equals(System.Nullable<System.Reflection.InterfaceMapping> left, System.Nullable<System.Reflection.InterfaceMapping> right) { }

	// RVA: 0xD4AEFC
	public int GetHashCode(System.Nullable<System.Reflection.InterfaceMapping> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MemberTypesEqualityComparer
{
	// Methods

	// RVA: 0xD4AFAC
	public void .ctor() { }

	// RVA: 0xD4AFB4
	public bool Equals(MemberTypes left, MemberTypes right) { }

	// RVA: 0xD4B03C
	public int GetHashCode(MemberTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MemberTypesEqualityComparer
{
	// Methods

	// RVA: 0xD4B064
	public void .ctor() { }

	// RVA: 0xD4B06C
	public bool Equals(System.Nullable<System.Reflection.MemberTypes> left, System.Nullable<System.Reflection.MemberTypes> right) { }

	// RVA: 0xD4B1E8
	public int GetHashCode(System.Nullable<System.Reflection.MemberTypes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4B29C
	public void .ctor() { }

	// RVA: 0xD4B2A4
	public bool Equals(MethodAttributes left, MethodAttributes right) { }

	// RVA: 0xD4B32C
	public int GetHashCode(MethodAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4B354
	public void .ctor() { }

	// RVA: 0xD4B35C
	public bool Equals(System.Nullable<System.Reflection.MethodAttributes> left, System.Nullable<System.Reflection.MethodAttributes> right) { }

	// RVA: 0xD4B4D8
	public int GetHashCode(System.Nullable<System.Reflection.MethodAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodImplAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4B58C
	public void .ctor() { }

	// RVA: 0xD4B594
	public bool Equals(MethodImplAttributes left, MethodImplAttributes right) { }

	// RVA: 0xD4B61C
	public int GetHashCode(MethodImplAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodImplAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4B644
	public void .ctor() { }

	// RVA: 0xD4B64C
	public bool Equals(System.Nullable<System.Reflection.MethodImplAttributes> left, System.Nullable<System.Reflection.MethodImplAttributes> right) { }

	// RVA: 0xD4B7C8
	public int GetHashCode(System.Nullable<System.Reflection.MethodImplAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4B87C
	public void .ctor() { }

	// RVA: 0xD4B884
	public bool Equals(ParameterAttributes left, ParameterAttributes right) { }

	// RVA: 0xD4B90C
	public int GetHashCode(ParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4B934
	public void .ctor() { }

	// RVA: 0xD4B93C
	public bool Equals(System.Nullable<System.Reflection.ParameterAttributes> left, System.Nullable<System.Reflection.ParameterAttributes> right) { }

	// RVA: 0xD4BAB8
	public int GetHashCode(System.Nullable<System.Reflection.ParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterModifierEqualityComparer
{
	// Methods

	// RVA: 0xD4BB6C
	public void .ctor() { }

	// RVA: 0xD4BB74
	public bool Equals(ParameterModifier left, ParameterModifier right) { }

	// RVA: 0xD4BBFC
	public int GetHashCode(ParameterModifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterModifierEqualityComparer
{
	// Methods

	// RVA: 0xD4BC6C
	public void .ctor() { }

	// RVA: 0xD4BC74
	public bool Equals(System.Nullable<System.Reflection.ParameterModifier> left, System.Nullable<System.Reflection.ParameterModifier> right) { }

	// RVA: 0xD4BDF0
	public int GetHashCode(System.Nullable<System.Reflection.ParameterModifier> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PortableExecutableKindsEqualityComparer
{
	// Methods

	// RVA: 0xD4BEA4
	public void .ctor() { }

	// RVA: 0xD4BEAC
	public bool Equals(PortableExecutableKinds left, PortableExecutableKinds right) { }

	// RVA: 0xD4BF34
	public int GetHashCode(PortableExecutableKinds obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PortableExecutableKindsEqualityComparer
{
	// Methods

	// RVA: 0xD4BF5C
	public void .ctor() { }

	// RVA: 0xD4BF64
	public bool Equals(System.Nullable<System.Reflection.PortableExecutableKinds> left, System.Nullable<System.Reflection.PortableExecutableKinds> right) { }

	// RVA: 0xD4C0E0
	public int GetHashCode(System.Nullable<System.Reflection.PortableExecutableKinds> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ProcessorArchitectureEqualityComparer
{
	// Methods

	// RVA: 0xD4C194
	public void .ctor() { }

	// RVA: 0xD4C19C
	public bool Equals(ProcessorArchitecture left, ProcessorArchitecture right) { }

	// RVA: 0xD4C224
	public int GetHashCode(ProcessorArchitecture obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ProcessorArchitectureEqualityComparer
{
	// Methods

	// RVA: 0xD4C24C
	public void .ctor() { }

	// RVA: 0xD4C254
	public bool Equals(System.Nullable<System.Reflection.ProcessorArchitecture> left, System.Nullable<System.Reflection.ProcessorArchitecture> right) { }

	// RVA: 0xD4C3D0
	public int GetHashCode(System.Nullable<System.Reflection.ProcessorArchitecture> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PropertyAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4C484
	public void .ctor() { }

	// RVA: 0xD4C48C
	public bool Equals(PropertyAttributes left, PropertyAttributes right) { }

	// RVA: 0xD4C514
	public int GetHashCode(PropertyAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PropertyAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4C53C
	public void .ctor() { }

	// RVA: 0xD4C544
	public bool Equals(System.Nullable<System.Reflection.PropertyAttributes> left, System.Nullable<System.Reflection.PropertyAttributes> right) { }

	// RVA: 0xD4C6C0
	public int GetHashCode(System.Nullable<System.Reflection.PropertyAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4C774
	public void .ctor() { }

	// RVA: 0xD4C77C
	public bool Equals(ResourceAttributes left, ResourceAttributes right) { }

	// RVA: 0xD4C804
	public int GetHashCode(ResourceAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4C82C
	public void .ctor() { }

	// RVA: 0xD4C834
	public bool Equals(System.Nullable<System.Reflection.ResourceAttributes> left, System.Nullable<System.Reflection.ResourceAttributes> right) { }

	// RVA: 0xD4C9B0
	public int GetHashCode(System.Nullable<System.Reflection.ResourceAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceLocationEqualityComparer
{
	// Methods

	// RVA: 0xD4CA64
	public void .ctor() { }

	// RVA: 0xD4CA6C
	public bool Equals(ResourceLocation left, ResourceLocation right) { }

	// RVA: 0xD4CAF4
	public int GetHashCode(ResourceLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceLocationEqualityComparer
{
	// Methods

	// RVA: 0xD4CB1C
	public void .ctor() { }

	// RVA: 0xD4CB24
	public bool Equals(System.Nullable<System.Reflection.ResourceLocation> left, System.Nullable<System.Reflection.ResourceLocation> right) { }

	// RVA: 0xD4CCA0
	public int GetHashCode(System.Nullable<System.Reflection.ResourceLocation> obj) { }

}

// Namespace: 
private sealed class System_Reflection_TypeAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4CD54
	public void .ctor() { }

	// RVA: 0xD4CD5C
	public bool Equals(TypeAttributes left, TypeAttributes right) { }

	// RVA: 0xD4CDE4
	public int GetHashCode(TypeAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_TypeAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD4CE0C
	public void .ctor() { }

	// RVA: 0xD4CE14
	public bool Equals(System.Nullable<System.Reflection.TypeAttributes> left, System.Nullable<System.Reflection.TypeAttributes> right) { }

	// RVA: 0xD4CF90
	public int GetHashCode(System.Nullable<System.Reflection.TypeAttributes> obj) { }

}

// Namespace: 
private sealed class System_Resources_UltimateResourceFallbackLocationEqualityComparer
{
	// Methods

	// RVA: 0xD4D044
	public void .ctor() { }

	// RVA: 0xD4D04C
	public bool Equals(UltimateResourceFallbackLocation left, UltimateResourceFallbackLocation right) { }

	// RVA: 0xD4D0D4
	public int GetHashCode(UltimateResourceFallbackLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Resources_UltimateResourceFallbackLocationEqualityComparer
{
	// Methods

	// RVA: 0xD4D0FC
	public void .ctor() { }

	// RVA: 0xD4D104
	public bool Equals(System.Nullable<System.Resources.UltimateResourceFallbackLocation> left, System.Nullable<System.Resources.UltimateResourceFallbackLocation> right) { }

	// RVA: 0xD4D280
	public int GetHashCode(System.Nullable<System.Resources.UltimateResourceFallbackLocation> obj) { }

}

// Namespace: 
private sealed class System_Runtime_GCLatencyModeEqualityComparer
{
	// Methods

	// RVA: 0xD4D334
	public void .ctor() { }

	// RVA: 0xD4D33C
	public bool Equals(GCLatencyMode left, GCLatencyMode right) { }

	// RVA: 0xD4D3C4
	public int GetHashCode(GCLatencyMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_GCLatencyModeEqualityComparer
{
	// Methods

	// RVA: 0xD4D3EC
	public void .ctor() { }

	// RVA: 0xD4D3F4
	public bool Equals(System.Nullable<System.Runtime.GCLatencyMode> left, System.Nullable<System.Runtime.GCLatencyMode> right) { }

	// RVA: 0xD4D570
	public int GetHashCode(System.Nullable<System.Runtime.GCLatencyMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer
{
	// Methods

	// RVA: 0xD4D624
	public void .ctor() { }

	// RVA: 0xD4D62C
	public bool Equals(CompilationRelaxations left, CompilationRelaxations right) { }

	// RVA: 0xD4D6B4
	public int GetHashCode(CompilationRelaxations obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer
{
	// Methods

	// RVA: 0xD4D6DC
	public void .ctor() { }

	// RVA: 0xD4D6E4
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> left, System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> right) { }

	// RVA: 0xD4D860
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_LoadHintEqualityComparer
{
	// Methods

	// RVA: 0xD4D914
	public void .ctor() { }

	// RVA: 0xD4D91C
	public bool Equals(LoadHint left, LoadHint right) { }

	// RVA: 0xD4D9A4
	public int GetHashCode(LoadHint obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_LoadHintEqualityComparer
{
	// Methods

	// RVA: 0xD4D9CC
	public void .ctor() { }

	// RVA: 0xD4D9D4
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.LoadHint> left, System.Nullable<System.Runtime.CompilerServices.LoadHint> right) { }

	// RVA: 0xD4DB50
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.LoadHint> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodCodeTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4DC04
	public void .ctor() { }

	// RVA: 0xD4DC0C
	public bool Equals(MethodCodeType left, MethodCodeType right) { }

	// RVA: 0xD4DC94
	public int GetHashCode(MethodCodeType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodCodeTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4DCBC
	public void .ctor() { }

	// RVA: 0xD4DCC4
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> left, System.Nullable<System.Runtime.CompilerServices.MethodCodeType> right) { }

	// RVA: 0xD4DE40
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodImplOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD4DEF4
	public void .ctor() { }

	// RVA: 0xD4DEFC
	public bool Equals(MethodImplOptions left, MethodImplOptions right) { }

	// RVA: 0xD4DF84
	public int GetHashCode(MethodImplOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodImplOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD4DFAC
	public void .ctor() { }

	// RVA: 0xD4DFB4
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> left, System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> right) { }

	// RVA: 0xD4E130
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_CerEqualityComparer
{
	// Methods

	// RVA: 0xD4E1E4
	public void .ctor() { }

	// RVA: 0xD4E1EC
	public bool Equals(Cer left, Cer right) { }

	// RVA: 0xD4E274
	public int GetHashCode(Cer obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_CerEqualityComparer
{
	// Methods

	// RVA: 0xD4E29C
	public void .ctor() { }

	// RVA: 0xD4E2A4
	public bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Cer> left, System.Nullable<System.Runtime.ConstrainedExecution.Cer> right) { }

	// RVA: 0xD4E420
	public int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Cer> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_ConsistencyEqualityComparer
{
	// Methods

	// RVA: 0xD4E4D4
	public void .ctor() { }

	// RVA: 0xD4E4DC
	public bool Equals(Consistency left, Consistency right) { }

	// RVA: 0xD4E564
	public int GetHashCode(Consistency obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_ConsistencyEqualityComparer
{
	// Methods

	// RVA: 0xD4E58C
	public void .ctor() { }

	// RVA: 0xD4E594
	public bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> left, System.Nullable<System.Runtime.ConstrainedExecution.Consistency> right) { }

	// RVA: 0xD4E710
	public int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ArrayWithOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD4E7C4
	public void .ctor() { }

	// RVA: 0xD4E7CC
	public bool Equals(ArrayWithOffset left, ArrayWithOffset right) { }

	// RVA: 0xD4E7FC
	public int GetHashCode(ArrayWithOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ArrayWithOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD4E824
	public void .ctor() { }

	// RVA: 0xD4E82C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> left, System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> right) { }

	// RVA: 0xD4E98C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4EA3C
	public void .ctor() { }

	// RVA: 0xD4EA44
	public bool Equals(AssemblyRegistrationFlags left, AssemblyRegistrationFlags right) { }

	// RVA: 0xD4EACC
	public int GetHashCode(AssemblyRegistrationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4EAF4
	public void .ctor() { }

	// RVA: 0xD4EAFC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> left, System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> right) { }

	// RVA: 0xD4EC78
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CallingConventionEqualityComparer
{
	// Methods

	// RVA: 0xD4ED2C
	public void .ctor() { }

	// RVA: 0xD4ED34
	public bool Equals(CallingConvention left, CallingConvention right) { }

	// RVA: 0xD4EDBC
	public int GetHashCode(CallingConvention obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CallingConventionEqualityComparer
{
	// Methods

	// RVA: 0xD4EDE4
	public void .ctor() { }

	// RVA: 0xD4EDEC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.CallingConvention> left, System.Nullable<System.Runtime.InteropServices.CallingConvention> right) { }

	// RVA: 0xD4EF68
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.CallingConvention> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CharSetEqualityComparer
{
	// Methods

	// RVA: 0xD4F01C
	public void .ctor() { }

	// RVA: 0xD4F024
	public bool Equals(CharSet left, CharSet right) { }

	// RVA: 0xD4F0AC
	public int GetHashCode(CharSet obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CharSetEqualityComparer
{
	// Methods

	// RVA: 0xD4F0D4
	public void .ctor() { }

	// RVA: 0xD4F0DC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.CharSet> left, System.Nullable<System.Runtime.InteropServices.CharSet> right) { }

	// RVA: 0xD4F258
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.CharSet> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4F30C
	public void .ctor() { }

	// RVA: 0xD4F314
	public bool Equals(ClassInterfaceType left, ClassInterfaceType right) { }

	// RVA: 0xD4F39C
	public int GetHashCode(ClassInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4F3C4
	public void .ctor() { }

	// RVA: 0xD4F3CC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> right) { }

	// RVA: 0xD4F548
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4F5FC
	public void .ctor() { }

	// RVA: 0xD4F604
	public bool Equals(ComInterfaceType left, ComInterfaceType right) { }

	// RVA: 0xD4F68C
	public int GetHashCode(ComInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4F6B4
	public void .ctor() { }

	// RVA: 0xD4F6BC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ComInterfaceType> right) { }

	// RVA: 0xD4F838
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComMemberTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4F8EC
	public void .ctor() { }

	// RVA: 0xD4F8F4
	public bool Equals(ComMemberType left, ComMemberType right) { }

	// RVA: 0xD4F97C
	public int GetHashCode(ComMemberType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComMemberTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4F9A4
	public void .ctor() { }

	// RVA: 0xD4F9AC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ComMemberType> left, System.Nullable<System.Runtime.InteropServices.ComMemberType> right) { }

	// RVA: 0xD4FB28
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComMemberType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ExporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD4FBDC
	public void .ctor() { }

	// RVA: 0xD4FBE4
	public bool Equals(ExporterEventKind left, ExporterEventKind right) { }

	// RVA: 0xD4FC6C
	public int GetHashCode(ExporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ExporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD4FC94
	public void .ctor() { }

	// RVA: 0xD4FC9C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ExporterEventKind> right) { }

	// RVA: 0xD4FE18
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleEqualityComparer
{
	// Methods

	// RVA: 0xD4FECC
	public void .ctor() { }

	// RVA: 0xD4FED4
	public bool Equals(GCHandle left, GCHandle right) { }

	// RVA: 0xD4FF4C
	public int GetHashCode(GCHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleEqualityComparer
{
	// Methods

	// RVA: 0xD4FF74
	public void .ctor() { }

	// RVA: 0xD4FF7C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandle> left, System.Nullable<System.Runtime.InteropServices.GCHandle> right) { }

	// RVA: 0xD500E8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5019C
	public void .ctor() { }

	// RVA: 0xD501A4
	public bool Equals(GCHandleType left, GCHandleType right) { }

	// RVA: 0xD5022C
	public int GetHashCode(GCHandleType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleTypeEqualityComparer
{
	// Methods

	// RVA: 0xD50254
	public void .ctor() { }

	// RVA: 0xD5025C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandleType> left, System.Nullable<System.Runtime.InteropServices.GCHandleType> right) { }

	// RVA: 0xD503D8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandleType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_HandleRefEqualityComparer
{
	// Methods

	// RVA: 0xD5048C
	public void .ctor() { }

	// RVA: 0xD50494
	public bool Equals(HandleRef left, HandleRef right) { }

	// RVA: 0xD5052C
	public int GetHashCode(HandleRef obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_HandleRefEqualityComparer
{
	// Methods

	// RVA: 0xD505A0
	public void .ctor() { }

	// RVA: 0xD505A8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.HandleRef> left, System.Nullable<System.Runtime.InteropServices.HandleRef> right) { }

	// RVA: 0xD5073C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.HandleRef> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ImporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD507EC
	public void .ctor() { }

	// RVA: 0xD507F4
	public bool Equals(ImporterEventKind left, ImporterEventKind right) { }

	// RVA: 0xD5087C
	public int GetHashCode(ImporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ImporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD508A4
	public void .ctor() { }

	// RVA: 0xD508AC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ImporterEventKind> right) { }

	// RVA: 0xD50A28
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_LayoutKindEqualityComparer
{
	// Methods

	// RVA: 0xD50ADC
	public void .ctor() { }

	// RVA: 0xD50AE4
	public bool Equals(LayoutKind left, LayoutKind right) { }

	// RVA: 0xD50B6C
	public int GetHashCode(LayoutKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_LayoutKindEqualityComparer
{
	// Methods

	// RVA: 0xD50B94
	public void .ctor() { }

	// RVA: 0xD50B9C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.LayoutKind> left, System.Nullable<System.Runtime.InteropServices.LayoutKind> right) { }

	// RVA: 0xD50D18
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.LayoutKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationClassContextEqualityComparer
{
	// Methods

	// RVA: 0xD50DCC
	public void .ctor() { }

	// RVA: 0xD50DD4
	public bool Equals(RegistrationClassContext left, RegistrationClassContext right) { }

	// RVA: 0xD50E5C
	public int GetHashCode(RegistrationClassContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationClassContextEqualityComparer
{
	// Methods

	// RVA: 0xD50E84
	public void .ctor() { }

	// RVA: 0xD50E8C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> left, System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> right) { }

	// RVA: 0xD51008
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer
{
	// Methods

	// RVA: 0xD510BC
	public void .ctor() { }

	// RVA: 0xD510C4
	public bool Equals(RegistrationConnectionType left, RegistrationConnectionType right) { }

	// RVA: 0xD5114C
	public int GetHashCode(RegistrationConnectionType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer
{
	// Methods

	// RVA: 0xD51174
	public void .ctor() { }

	// RVA: 0xD5117C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> left, System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> right) { }

	// RVA: 0xD512F8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD513AC
	public void .ctor() { }

	// RVA: 0xD513B4
	public bool Equals(TypeLibExporterFlags left, TypeLibExporterFlags right) { }

	// RVA: 0xD5143C
	public int GetHashCode(TypeLibExporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD51464
	public void .ctor() { }

	// RVA: 0xD5146C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> right) { }

	// RVA: 0xD515E8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD5169C
	public void .ctor() { }

	// RVA: 0xD516A4
	public bool Equals(TypeLibFuncFlags left, TypeLibFuncFlags right) { }

	// RVA: 0xD5172C
	public int GetHashCode(TypeLibFuncFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD51754
	public void .ctor() { }

	// RVA: 0xD5175C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> right) { }

	// RVA: 0xD518D8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD5198C
	public void .ctor() { }

	// RVA: 0xD51994
	public bool Equals(TypeLibImporterFlags left, TypeLibImporterFlags right) { }

	// RVA: 0xD51A1C
	public int GetHashCode(TypeLibImporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD51A44
	public void .ctor() { }

	// RVA: 0xD51A4C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> right) { }

	// RVA: 0xD51BC8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD51C7C
	public void .ctor() { }

	// RVA: 0xD51C84
	public bool Equals(TypeLibTypeFlags left, TypeLibTypeFlags right) { }

	// RVA: 0xD51D0C
	public int GetHashCode(TypeLibTypeFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD51D34
	public void .ctor() { }

	// RVA: 0xD51D3C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> right) { }

	// RVA: 0xD51EB8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD51F6C
	public void .ctor() { }

	// RVA: 0xD51F74
	public bool Equals(TypeLibVarFlags left, TypeLibVarFlags right) { }

	// RVA: 0xD51FFC
	public int GetHashCode(TypeLibVarFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD52024
	public void .ctor() { }

	// RVA: 0xD5202C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> right) { }

	// RVA: 0xD521A8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_UnmanagedTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5225C
	public void .ctor() { }

	// RVA: 0xD52264
	public bool Equals(UnmanagedType left, UnmanagedType right) { }

	// RVA: 0xD522EC
	public int GetHashCode(UnmanagedType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_UnmanagedTypeEqualityComparer
{
	// Methods

	// RVA: 0xD52314
	public void .ctor() { }

	// RVA: 0xD5231C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.UnmanagedType> left, System.Nullable<System.Runtime.InteropServices.UnmanagedType> right) { }

	// RVA: 0xD52498
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.UnmanagedType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_VarEnumEqualityComparer
{
	// Methods

	// RVA: 0xD5254C
	public void .ctor() { }

	// RVA: 0xD52554
	public bool Equals(VarEnum left, VarEnum right) { }

	// RVA: 0xD525DC
	public int GetHashCode(VarEnum obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_VarEnumEqualityComparer
{
	// Methods

	// RVA: 0xD52604
	public void .ctor() { }

	// RVA: 0xD5260C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.VarEnum> left, System.Nullable<System.Runtime.InteropServices.VarEnum> right) { }

	// RVA: 0xD52788
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.VarEnum> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_CustomErrorsModesEqualityComparer
{
	// Methods

	// RVA: 0xD5283C
	public void .ctor() { }

	// RVA: 0xD52844
	public bool Equals(CustomErrorsModes left, CustomErrorsModes right) { }

	// RVA: 0xD528CC
	public int GetHashCode(CustomErrorsModes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_CustomErrorsModesEqualityComparer
{
	// Methods

	// RVA: 0xD528F4
	public void .ctor() { }

	// RVA: 0xD528FC
	public bool Equals(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> left, System.Nullable<System.Runtime.Remoting.CustomErrorsModes> right) { }

	// RVA: 0xD52A78
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_WellKnownObjectModeEqualityComparer
{
	// Methods

	// RVA: 0xD52B2C
	public void .ctor() { }

	// RVA: 0xD52B34
	public bool Equals(WellKnownObjectMode left, WellKnownObjectMode right) { }

	// RVA: 0xD52BBC
	public int GetHashCode(WellKnownObjectMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_WellKnownObjectModeEqualityComparer
{
	// Methods

	// RVA: 0xD52BE4
	public void .ctor() { }

	// RVA: 0xD52BEC
	public bool Equals(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> left, System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> right) { }

	// RVA: 0xD52D68
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer
{
	// Methods

	// RVA: 0xD52E1C
	public void .ctor() { }

	// RVA: 0xD52E24
	public bool Equals(ActivatorLevel left, ActivatorLevel right) { }

	// RVA: 0xD52EAC
	public int GetHashCode(ActivatorLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer
{
	// Methods

	// RVA: 0xD52ED4
	public void .ctor() { }

	// RVA: 0xD52EDC
	public bool Equals(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> left, System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> right) { }

	// RVA: 0xD53058
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Channels_ServerProcessingEqualityComparer
{
	// Methods

	// RVA: 0xD5310C
	public void .ctor() { }

	// RVA: 0xD53114
	public bool Equals(ServerProcessing left, ServerProcessing right) { }

	// RVA: 0xD5319C
	public int GetHashCode(ServerProcessing obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Channels_ServerProcessingEqualityComparer
{
	// Methods

	// RVA: 0xD531C4
	public void .ctor() { }

	// RVA: 0xD531CC
	public bool Equals(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> left, System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> right) { }

	// RVA: 0xD53348
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer
{
	// Methods

	// RVA: 0xD533FC
	public void .ctor() { }

	// RVA: 0xD53404
	public bool Equals(LeaseState left, LeaseState right) { }

	// RVA: 0xD5348C
	public int GetHashCode(LeaseState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer
{
	// Methods

	// RVA: 0xD534B4
	public void .ctor() { }

	// RVA: 0xD534BC
	public bool Equals(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> left, System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> right) { }

	// RVA: 0xD53638
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_SoapOptionEqualityComparer
{
	// Methods

	// RVA: 0xD536EC
	public void .ctor() { }

	// RVA: 0xD536F4
	public bool Equals(SoapOption left, SoapOption right) { }

	// RVA: 0xD5377C
	public int GetHashCode(SoapOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_SoapOptionEqualityComparer
{
	// Methods

	// RVA: 0xD537A4
	public void .ctor() { }

	// RVA: 0xD537AC
	public bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> left, System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> right) { }

	// RVA: 0xD53928
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer
{
	// Methods

	// RVA: 0xD539DC
	public void .ctor() { }

	// RVA: 0xD539E4
	public bool Equals(XmlFieldOrderOption left, XmlFieldOrderOption right) { }

	// RVA: 0xD53A6C
	public int GetHashCode(XmlFieldOrderOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer
{
	// Methods

	// RVA: 0xD53A94
	public void .ctor() { }

	// RVA: 0xD53A9C
	public bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> left, System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> right) { }

	// RVA: 0xD53C18
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_SerializationEntryEqualityComparer
{
	// Methods

	// RVA: 0xD53CCC
	public void .ctor() { }

	// RVA: 0xD53CD4
	public bool Equals(SerializationEntry left, SerializationEntry right) { }

	// RVA: 0xD53D74
	public int GetHashCode(SerializationEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_SerializationEntryEqualityComparer
{
	// Methods

	// RVA: 0xD53DF0
	public void .ctor() { }

	// RVA: 0xD53DF8
	public bool Equals(System.Nullable<System.Runtime.Serialization.SerializationEntry> left, System.Nullable<System.Runtime.Serialization.SerializationEntry> right) { }

	// RVA: 0xD53FAC
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.SerializationEntry> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextEqualityComparer
{
	// Methods

	// RVA: 0xD5405C
	public void .ctor() { }

	// RVA: 0xD54064
	public bool Equals(StreamingContext left, StreamingContext right) { }

	// RVA: 0xD540E0
	public int GetHashCode(StreamingContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextEqualityComparer
{
	// Methods

	// RVA: 0xD540E8
	public void .ctor() { }

	// RVA: 0xD540F0
	public bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContext> left, System.Nullable<System.Runtime.Serialization.StreamingContext> right) { }

	// RVA: 0xD54278
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextStatesEqualityComparer
{
	// Methods

	// RVA: 0xD54328
	public void .ctor() { }

	// RVA: 0xD54330
	public bool Equals(StreamingContextStates left, StreamingContextStates right) { }

	// RVA: 0xD543B8
	public int GetHashCode(StreamingContextStates obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextStatesEqualityComparer
{
	// Methods

	// RVA: 0xD543E0
	public void .ctor() { }

	// RVA: 0xD543E8
	public bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContextStates> left, System.Nullable<System.Runtime.Serialization.StreamingContextStates> right) { }

	// RVA: 0xD54564
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContextStates> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer
{
	// Methods

	// RVA: 0xD54618
	public void .ctor() { }

	// RVA: 0xD54620
	public bool Equals(FormatterAssemblyStyle left, FormatterAssemblyStyle right) { }

	// RVA: 0xD546A8
	public int GetHashCode(FormatterAssemblyStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer
{
	// Methods

	// RVA: 0xD546D0
	public void .ctor() { }

	// RVA: 0xD546D8
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> right) { }

	// RVA: 0xD54854
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer
{
	// Methods

	// RVA: 0xD54908
	public void .ctor() { }

	// RVA: 0xD54910
	public bool Equals(FormatterTypeStyle left, FormatterTypeStyle right) { }

	// RVA: 0xD54998
	public int GetHashCode(FormatterTypeStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer
{
	// Methods

	// RVA: 0xD549C0
	public void .ctor() { }

	// RVA: 0xD549C8
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> right) { }

	// RVA: 0xD54B44
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer
{
	// Methods

	// RVA: 0xD54BF8
	public void .ctor() { }

	// RVA: 0xD54C00
	public bool Equals(TypeFilterLevel left, TypeFilterLevel right) { }

	// RVA: 0xD54C88
	public int GetHashCode(TypeFilterLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer
{
	// Methods

	// RVA: 0xD54CB0
	public void .ctor() { }

	// RVA: 0xD54CB8
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> left, System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> right) { }

	// RVA: 0xD54E34
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Versioning_ResourceScopeEqualityComparer
{
	// Methods

	// RVA: 0xD54EE8
	public void .ctor() { }

	// RVA: 0xD54EF0
	public bool Equals(ResourceScope left, ResourceScope right) { }

	// RVA: 0xD54F78
	public int GetHashCode(ResourceScope obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Versioning_ResourceScopeEqualityComparer
{
	// Methods

	// RVA: 0xD54FA0
	public void .ctor() { }

	// RVA: 0xD54FA8
	public bool Equals(System.Nullable<System.Runtime.Versioning.ResourceScope> left, System.Nullable<System.Runtime.Versioning.ResourceScope> right) { }

	// RVA: 0xD55124
	public int GetHashCode(System.Nullable<System.Runtime.Versioning.ResourceScope> obj) { }

}

// Namespace: 
private sealed class System_Security_HostSecurityManagerOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD551D8
	public void .ctor() { }

	// RVA: 0xD551E0
	public bool Equals(HostSecurityManagerOptions left, HostSecurityManagerOptions right) { }

	// RVA: 0xD55268
	public int GetHashCode(HostSecurityManagerOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_HostSecurityManagerOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD55290
	public void .ctor() { }

	// RVA: 0xD55298
	public bool Equals(System.Nullable<System.Security.HostSecurityManagerOptions> left, System.Nullable<System.Security.HostSecurityManagerOptions> right) { }

	// RVA: 0xD55414
	public int GetHashCode(System.Nullable<System.Security.HostSecurityManagerOptions> obj) { }

}

// Namespace: 
private sealed class System_Security_PolicyLevelTypeEqualityComparer
{
	// Methods

	// RVA: 0xD554C8
	public void .ctor() { }

	// RVA: 0xD554D0
	public bool Equals(PolicyLevelType left, PolicyLevelType right) { }

	// RVA: 0xD55558
	public int GetHashCode(PolicyLevelType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_PolicyLevelTypeEqualityComparer
{
	// Methods

	// RVA: 0xD55580
	public void .ctor() { }

	// RVA: 0xD55588
	public bool Equals(System.Nullable<System.Security.PolicyLevelType> left, System.Nullable<System.Security.PolicyLevelType> right) { }

	// RVA: 0xD55704
	public int GetHashCode(System.Nullable<System.Security.PolicyLevelType> obj) { }

}

// Namespace: 
private sealed class System_Security_SecurityZoneEqualityComparer
{
	// Methods

	// RVA: 0xD557B8
	public void .ctor() { }

	// RVA: 0xD557C0
	public bool Equals(SecurityZone left, SecurityZone right) { }

	// RVA: 0xD55848
	public int GetHashCode(SecurityZone obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_SecurityZoneEqualityComparer
{
	// Methods

	// RVA: 0xD55870
	public void .ctor() { }

	// RVA: 0xD55878
	public bool Equals(System.Nullable<System.Security.SecurityZone> left, System.Nullable<System.Security.SecurityZone> right) { }

	// RVA: 0xD559F4
	public int GetHashCode(System.Nullable<System.Security.SecurityZone> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlActionsEqualityComparer
{
	// Methods

	// RVA: 0xD55AA8
	public void .ctor() { }

	// RVA: 0xD55AB0
	public bool Equals(AccessControlActions left, AccessControlActions right) { }

	// RVA: 0xD55B38
	public int GetHashCode(AccessControlActions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlActionsEqualityComparer
{
	// Methods

	// RVA: 0xD55B60
	public void .ctor() { }

	// RVA: 0xD55B68
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlActions> left, System.Nullable<System.Security.AccessControl.AccessControlActions> right) { }

	// RVA: 0xD55CE4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlActions> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlModificationEqualityComparer
{
	// Methods

	// RVA: 0xD55D98
	public void .ctor() { }

	// RVA: 0xD55DA0
	public bool Equals(AccessControlModification left, AccessControlModification right) { }

	// RVA: 0xD55E28
	public int GetHashCode(AccessControlModification obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlModificationEqualityComparer
{
	// Methods

	// RVA: 0xD55E50
	public void .ctor() { }

	// RVA: 0xD55E58
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlModification> left, System.Nullable<System.Security.AccessControl.AccessControlModification> right) { }

	// RVA: 0xD55FD4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlModification> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlSectionsEqualityComparer
{
	// Methods

	// RVA: 0xD56088
	public void .ctor() { }

	// RVA: 0xD56090
	public bool Equals(AccessControlSections left, AccessControlSections right) { }

	// RVA: 0xD56118
	public int GetHashCode(AccessControlSections obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlSectionsEqualityComparer
{
	// Methods

	// RVA: 0xD56140
	public void .ctor() { }

	// RVA: 0xD56148
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlSections> left, System.Nullable<System.Security.AccessControl.AccessControlSections> right) { }

	// RVA: 0xD562C4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlSections> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlTypeEqualityComparer
{
	// Methods

	// RVA: 0xD56378
	public void .ctor() { }

	// RVA: 0xD56380
	public bool Equals(AccessControlType left, AccessControlType right) { }

	// RVA: 0xD56408
	public int GetHashCode(AccessControlType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlTypeEqualityComparer
{
	// Methods

	// RVA: 0xD56430
	public void .ctor() { }

	// RVA: 0xD56438
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlType> left, System.Nullable<System.Security.AccessControl.AccessControlType> right) { }

	// RVA: 0xD565B4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD56668
	public void .ctor() { }

	// RVA: 0xD56670
	public bool Equals(AceFlags left, AceFlags right) { }

	// RVA: 0xD566F8
	public int GetHashCode(AceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD56720
	public void .ctor() { }

	// RVA: 0xD56728
	public bool Equals(System.Nullable<System.Security.AccessControl.AceFlags> left, System.Nullable<System.Security.AccessControl.AceFlags> right) { }

	// RVA: 0xD568A4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceQualifierEqualityComparer
{
	// Methods

	// RVA: 0xD56958
	public void .ctor() { }

	// RVA: 0xD56960
	public bool Equals(AceQualifier left, AceQualifier right) { }

	// RVA: 0xD569E8
	public int GetHashCode(AceQualifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceQualifierEqualityComparer
{
	// Methods

	// RVA: 0xD56A10
	public void .ctor() { }

	// RVA: 0xD56A18
	public bool Equals(System.Nullable<System.Security.AccessControl.AceQualifier> left, System.Nullable<System.Security.AccessControl.AceQualifier> right) { }

	// RVA: 0xD56B94
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceQualifier> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD56C48
	public void .ctor() { }

	// RVA: 0xD56C50
	public bool Equals(AceType left, AceType right) { }

	// RVA: 0xD56CD8
	public int GetHashCode(AceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD56D00
	public void .ctor() { }

	// RVA: 0xD56D08
	public bool Equals(System.Nullable<System.Security.AccessControl.AceType> left, System.Nullable<System.Security.AccessControl.AceType> right) { }

	// RVA: 0xD56E84
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AuditFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD56F38
	public void .ctor() { }

	// RVA: 0xD56F40
	public bool Equals(AuditFlags left, AuditFlags right) { }

	// RVA: 0xD56FC8
	public int GetHashCode(AuditFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AuditFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD56FF0
	public void .ctor() { }

	// RVA: 0xD56FF8
	public bool Equals(System.Nullable<System.Security.AccessControl.AuditFlags> left, System.Nullable<System.Security.AccessControl.AuditFlags> right) { }

	// RVA: 0xD57174
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AuditFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CompoundAceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD57228
	public void .ctor() { }

	// RVA: 0xD57230
	public bool Equals(CompoundAceType left, CompoundAceType right) { }

	// RVA: 0xD572B8
	public int GetHashCode(CompoundAceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CompoundAceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD572E0
	public void .ctor() { }

	// RVA: 0xD572E8
	public bool Equals(System.Nullable<System.Security.AccessControl.CompoundAceType> left, System.Nullable<System.Security.AccessControl.CompoundAceType> right) { }

	// RVA: 0xD57464
	public int GetHashCode(System.Nullable<System.Security.AccessControl.CompoundAceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ControlFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD57518
	public void .ctor() { }

	// RVA: 0xD57520
	public bool Equals(ControlFlags left, ControlFlags right) { }

	// RVA: 0xD575A8
	public int GetHashCode(ControlFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ControlFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD575D0
	public void .ctor() { }

	// RVA: 0xD575D8
	public bool Equals(System.Nullable<System.Security.AccessControl.ControlFlags> left, System.Nullable<System.Security.AccessControl.ControlFlags> right) { }

	// RVA: 0xD57754
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ControlFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CryptoKeyRightsEqualityComparer
{
	// Methods

	// RVA: 0xD57808
	public void .ctor() { }

	// RVA: 0xD57810
	public bool Equals(CryptoKeyRights left, CryptoKeyRights right) { }

	// RVA: 0xD57898
	public int GetHashCode(CryptoKeyRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CryptoKeyRightsEqualityComparer
{
	// Methods

	// RVA: 0xD578C0
	public void .ctor() { }

	// RVA: 0xD578C8
	public bool Equals(System.Nullable<System.Security.AccessControl.CryptoKeyRights> left, System.Nullable<System.Security.AccessControl.CryptoKeyRights> right) { }

	// RVA: 0xD57A44
	public int GetHashCode(System.Nullable<System.Security.AccessControl.CryptoKeyRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_EventWaitHandleRightsEqualityComparer
{
	// Methods

	// RVA: 0xD57AF8
	public void .ctor() { }

	// RVA: 0xD57B00
	public bool Equals(EventWaitHandleRights left, EventWaitHandleRights right) { }

	// RVA: 0xD57B88
	public int GetHashCode(EventWaitHandleRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_EventWaitHandleRightsEqualityComparer
{
	// Methods

	// RVA: 0xD57BB0
	public void .ctor() { }

	// RVA: 0xD57BB8
	public bool Equals(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> left, System.Nullable<System.Security.AccessControl.EventWaitHandleRights> right) { }

	// RVA: 0xD57D34
	public int GetHashCode(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_FileSystemRightsEqualityComparer
{
	// Methods

	// RVA: 0xD57DE8
	public void .ctor() { }

	// RVA: 0xD57DF0
	public bool Equals(FileSystemRights left, FileSystemRights right) { }

	// RVA: 0xD57E78
	public int GetHashCode(FileSystemRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_FileSystemRightsEqualityComparer
{
	// Methods

	// RVA: 0xD57EA0
	public void .ctor() { }

	// RVA: 0xD57EA8
	public bool Equals(System.Nullable<System.Security.AccessControl.FileSystemRights> left, System.Nullable<System.Security.AccessControl.FileSystemRights> right) { }

	// RVA: 0xD58024
	public int GetHashCode(System.Nullable<System.Security.AccessControl.FileSystemRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_InheritanceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD580D8
	public void .ctor() { }

	// RVA: 0xD580E0
	public bool Equals(InheritanceFlags left, InheritanceFlags right) { }

	// RVA: 0xD58168
	public int GetHashCode(InheritanceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_InheritanceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD58190
	public void .ctor() { }

	// RVA: 0xD58198
	public bool Equals(System.Nullable<System.Security.AccessControl.InheritanceFlags> left, System.Nullable<System.Security.AccessControl.InheritanceFlags> right) { }

	// RVA: 0xD58314
	public int GetHashCode(System.Nullable<System.Security.AccessControl.InheritanceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_MutexRightsEqualityComparer
{
	// Methods

	// RVA: 0xD583C8
	public void .ctor() { }

	// RVA: 0xD583D0
	public bool Equals(MutexRights left, MutexRights right) { }

	// RVA: 0xD58458
	public int GetHashCode(MutexRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_MutexRightsEqualityComparer
{
	// Methods

	// RVA: 0xD58480
	public void .ctor() { }

	// RVA: 0xD58488
	public bool Equals(System.Nullable<System.Security.AccessControl.MutexRights> left, System.Nullable<System.Security.AccessControl.MutexRights> right) { }

	// RVA: 0xD58604
	public int GetHashCode(System.Nullable<System.Security.AccessControl.MutexRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ObjectAceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD586B8
	public void .ctor() { }

	// RVA: 0xD586C0
	public bool Equals(ObjectAceFlags left, ObjectAceFlags right) { }

	// RVA: 0xD58748
	public int GetHashCode(ObjectAceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ObjectAceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD58770
	public void .ctor() { }

	// RVA: 0xD58778
	public bool Equals(System.Nullable<System.Security.AccessControl.ObjectAceFlags> left, System.Nullable<System.Security.AccessControl.ObjectAceFlags> right) { }

	// RVA: 0xD588F4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ObjectAceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_PropagationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD589A8
	public void .ctor() { }

	// RVA: 0xD589B0
	public bool Equals(PropagationFlags left, PropagationFlags right) { }

	// RVA: 0xD58A38
	public int GetHashCode(PropagationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_PropagationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD58A60
	public void .ctor() { }

	// RVA: 0xD58A68
	public bool Equals(System.Nullable<System.Security.AccessControl.PropagationFlags> left, System.Nullable<System.Security.AccessControl.PropagationFlags> right) { }

	// RVA: 0xD58BE4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.PropagationFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_RegistryRightsEqualityComparer
{
	// Methods

	// RVA: 0xD58C98
	public void .ctor() { }

	// RVA: 0xD58CA0
	public bool Equals(RegistryRights left, RegistryRights right) { }

	// RVA: 0xD58D28
	public int GetHashCode(RegistryRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_RegistryRightsEqualityComparer
{
	// Methods

	// RVA: 0xD58D50
	public void .ctor() { }

	// RVA: 0xD58D58
	public bool Equals(System.Nullable<System.Security.AccessControl.RegistryRights> left, System.Nullable<System.Security.AccessControl.RegistryRights> right) { }

	// RVA: 0xD58ED4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.RegistryRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ResourceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD58F88
	public void .ctor() { }

	// RVA: 0xD58F90
	public bool Equals(ResourceType left, ResourceType right) { }

	// RVA: 0xD59018
	public int GetHashCode(ResourceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ResourceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD59040
	public void .ctor() { }

	// RVA: 0xD59048
	public bool Equals(System.Nullable<System.Security.AccessControl.ResourceType> left, System.Nullable<System.Security.AccessControl.ResourceType> right) { }

	// RVA: 0xD591C4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ResourceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_SecurityInfosEqualityComparer
{
	// Methods

	// RVA: 0xD59278
	public void .ctor() { }

	// RVA: 0xD59280
	public bool Equals(SecurityInfos left, SecurityInfos right) { }

	// RVA: 0xD59308
	public int GetHashCode(SecurityInfos obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_SecurityInfosEqualityComparer
{
	// Methods

	// RVA: 0xD59330
	public void .ctor() { }

	// RVA: 0xD59338
	public bool Equals(System.Nullable<System.Security.AccessControl.SecurityInfos> left, System.Nullable<System.Security.AccessControl.SecurityInfos> right) { }

	// RVA: 0xD594B4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.SecurityInfos> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CipherModeEqualityComparer
{
	// Methods

	// RVA: 0xD59568
	public void .ctor() { }

	// RVA: 0xD59570
	public bool Equals(CipherMode left, CipherMode right) { }

	// RVA: 0xD595F8
	public int GetHashCode(CipherMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CipherModeEqualityComparer
{
	// Methods

	// RVA: 0xD59620
	public void .ctor() { }

	// RVA: 0xD59628
	public bool Equals(System.Nullable<System.Security.Cryptography.CipherMode> left, System.Nullable<System.Security.Cryptography.CipherMode> right) { }

	// RVA: 0xD597A4
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CipherMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CryptoStreamModeEqualityComparer
{
	// Methods

	// RVA: 0xD59858
	public void .ctor() { }

	// RVA: 0xD59860
	public bool Equals(CryptoStreamMode left, CryptoStreamMode right) { }

	// RVA: 0xD598E8
	public int GetHashCode(CryptoStreamMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CryptoStreamModeEqualityComparer
{
	// Methods

	// RVA: 0xD59910
	public void .ctor() { }

	// RVA: 0xD59918
	public bool Equals(System.Nullable<System.Security.Cryptography.CryptoStreamMode> left, System.Nullable<System.Security.Cryptography.CryptoStreamMode> right) { }

	// RVA: 0xD59A94
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CryptoStreamMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CspProviderFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD59B48
	public void .ctor() { }

	// RVA: 0xD59B50
	public bool Equals(CspProviderFlags left, CspProviderFlags right) { }

	// RVA: 0xD59BD8
	public int GetHashCode(CspProviderFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CspProviderFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD59C00
	public void .ctor() { }

	// RVA: 0xD59C08
	public bool Equals(System.Nullable<System.Security.Cryptography.CspProviderFlags> left, System.Nullable<System.Security.Cryptography.CspProviderFlags> right) { }

	// RVA: 0xD59D84
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CspProviderFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_DSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD59E38
	public void .ctor() { }

	// RVA: 0xD59E40
	public bool Equals(DSAParameters left, DSAParameters right) { }

	// RVA: 0xD59EE0
	public int GetHashCode(DSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_DSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD59F5C
	public void .ctor() { }

	// RVA: 0xD59F64
	public bool Equals(System.Nullable<System.Security.Cryptography.DSAParameters> left, System.Nullable<System.Security.Cryptography.DSAParameters> right) { }

	// RVA: 0xD5A128
	public int GetHashCode(System.Nullable<System.Security.Cryptography.DSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_FromBase64TransformModeEqualityComparer
{
	// Methods

	// RVA: 0xD5A1D8
	public void .ctor() { }

	// RVA: 0xD5A1E0
	public bool Equals(FromBase64TransformMode left, FromBase64TransformMode right) { }

	// RVA: 0xD5A268
	public int GetHashCode(FromBase64TransformMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_FromBase64TransformModeEqualityComparer
{
	// Methods

	// RVA: 0xD5A290
	public void .ctor() { }

	// RVA: 0xD5A298
	public bool Equals(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> left, System.Nullable<System.Security.Cryptography.FromBase64TransformMode> right) { }

	// RVA: 0xD5A414
	public int GetHashCode(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_KeyNumberEqualityComparer
{
	// Methods

	// RVA: 0xD5A4C8
	public void .ctor() { }

	// RVA: 0xD5A4D0
	public bool Equals(KeyNumber left, KeyNumber right) { }

	// RVA: 0xD5A558
	public int GetHashCode(KeyNumber obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_KeyNumberEqualityComparer
{
	// Methods

	// RVA: 0xD5A580
	public void .ctor() { }

	// RVA: 0xD5A588
	public bool Equals(System.Nullable<System.Security.Cryptography.KeyNumber> left, System.Nullable<System.Security.Cryptography.KeyNumber> right) { }

	// RVA: 0xD5A704
	public int GetHashCode(System.Nullable<System.Security.Cryptography.KeyNumber> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_PaddingModeEqualityComparer
{
	// Methods

	// RVA: 0xD5A7B8
	public void .ctor() { }

	// RVA: 0xD5A7C0
	public bool Equals(PaddingMode left, PaddingMode right) { }

	// RVA: 0xD5A848
	public int GetHashCode(PaddingMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_PaddingModeEqualityComparer
{
	// Methods

	// RVA: 0xD5A870
	public void .ctor() { }

	// RVA: 0xD5A878
	public bool Equals(System.Nullable<System.Security.Cryptography.PaddingMode> left, System.Nullable<System.Security.Cryptography.PaddingMode> right) { }

	// RVA: 0xD5A9F4
	public int GetHashCode(System.Nullable<System.Security.Cryptography.PaddingMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_RSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD5AAA8
	public void .ctor() { }

	// RVA: 0xD5AAB0
	public bool Equals(RSAParameters left, RSAParameters right) { }

	// RVA: 0xD5AB50
	public int GetHashCode(RSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_RSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD5ABCC
	public void .ctor() { }

	// RVA: 0xD5ABD4
	public bool Equals(System.Nullable<System.Security.Cryptography.RSAParameters> left, System.Nullable<System.Security.Cryptography.RSAParameters> right) { }

	// RVA: 0xD5AD98
	public int GetHashCode(System.Nullable<System.Security.Cryptography.RSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5AE48
	public void .ctor() { }

	// RVA: 0xD5AE50
	public bool Equals(X509ContentType left, X509ContentType right) { }

	// RVA: 0xD5AED8
	public int GetHashCode(X509ContentType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5AF00
	public void .ctor() { }

	// RVA: 0xD5AF08
	public bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> right) { }

	// RVA: 0xD5B084
	public int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD5B138
	public void .ctor() { }

	// RVA: 0xD5B140
	public bool Equals(X509KeyStorageFlags left, X509KeyStorageFlags right) { }

	// RVA: 0xD5B1C8
	public int GetHashCode(X509KeyStorageFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD5B1F0
	public void .ctor() { }

	// RVA: 0xD5B1F8
	public bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> right) { }

	// RVA: 0xD5B374
	public int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_ApplicationVersionMatchEqualityComparer
{
	// Methods

	// RVA: 0xD5B428
	public void .ctor() { }

	// RVA: 0xD5B430
	public bool Equals(ApplicationVersionMatch left, ApplicationVersionMatch right) { }

	// RVA: 0xD5B4B8
	public int GetHashCode(ApplicationVersionMatch obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_ApplicationVersionMatchEqualityComparer
{
	// Methods

	// RVA: 0xD5B4E0
	public void .ctor() { }

	// RVA: 0xD5B4E8
	public bool Equals(System.Nullable<System.Security.Policy.ApplicationVersionMatch> left, System.Nullable<System.Security.Policy.ApplicationVersionMatch> right) { }

	// RVA: 0xD5B664
	public int GetHashCode(System.Nullable<System.Security.Policy.ApplicationVersionMatch> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_PolicyStatementAttributeEqualityComparer
{
	// Methods

	// RVA: 0xD5B718
	public void .ctor() { }

	// RVA: 0xD5B720
	public bool Equals(PolicyStatementAttribute left, PolicyStatementAttribute right) { }

	// RVA: 0xD5B7A8
	public int GetHashCode(PolicyStatementAttribute obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_PolicyStatementAttributeEqualityComparer
{
	// Methods

	// RVA: 0xD5B7D0
	public void .ctor() { }

	// RVA: 0xD5B7D8
	public bool Equals(System.Nullable<System.Security.Policy.PolicyStatementAttribute> left, System.Nullable<System.Security.Policy.PolicyStatementAttribute> right) { }

	// RVA: 0xD5B954
	public int GetHashCode(System.Nullable<System.Security.Policy.PolicyStatementAttribute> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_TrustManagerUIContextEqualityComparer
{
	// Methods

	// RVA: 0xD5BA08
	public void .ctor() { }

	// RVA: 0xD5BA10
	public bool Equals(TrustManagerUIContext left, TrustManagerUIContext right) { }

	// RVA: 0xD5BA98
	public int GetHashCode(TrustManagerUIContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_TrustManagerUIContextEqualityComparer
{
	// Methods

	// RVA: 0xD5BAC0
	public void .ctor() { }

	// RVA: 0xD5BAC8
	public bool Equals(System.Nullable<System.Security.Policy.TrustManagerUIContext> left, System.Nullable<System.Security.Policy.TrustManagerUIContext> right) { }

	// RVA: 0xD5BC44
	public int GetHashCode(System.Nullable<System.Security.Policy.TrustManagerUIContext> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_PrincipalPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD5BCF8
	public void .ctor() { }

	// RVA: 0xD5BD00
	public bool Equals(PrincipalPolicy left, PrincipalPolicy right) { }

	// RVA: 0xD5BD88
	public int GetHashCode(PrincipalPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_PrincipalPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD5BDB0
	public void .ctor() { }

	// RVA: 0xD5BDB8
	public bool Equals(System.Nullable<System.Security.Principal.PrincipalPolicy> left, System.Nullable<System.Security.Principal.PrincipalPolicy> right) { }

	// RVA: 0xD5BF34
	public int GetHashCode(System.Nullable<System.Security.Principal.PrincipalPolicy> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenAccessLevelsEqualityComparer
{
	// Methods

	// RVA: 0xD5BFE8
	public void .ctor() { }

	// RVA: 0xD5BFF0
	public bool Equals(TokenAccessLevels left, TokenAccessLevels right) { }

	// RVA: 0xD5C078
	public int GetHashCode(TokenAccessLevels obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenAccessLevelsEqualityComparer
{
	// Methods

	// RVA: 0xD5C0A0
	public void .ctor() { }

	// RVA: 0xD5C0A8
	public bool Equals(System.Nullable<System.Security.Principal.TokenAccessLevels> left, System.Nullable<System.Security.Principal.TokenAccessLevels> right) { }

	// RVA: 0xD5C224
	public int GetHashCode(System.Nullable<System.Security.Principal.TokenAccessLevels> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenImpersonationLevelEqualityComparer
{
	// Methods

	// RVA: 0xD5C2D8
	public void .ctor() { }

	// RVA: 0xD5C2E0
	public bool Equals(TokenImpersonationLevel left, TokenImpersonationLevel right) { }

	// RVA: 0xD5C368
	public int GetHashCode(TokenImpersonationLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenImpersonationLevelEqualityComparer
{
	// Methods

	// RVA: 0xD5C390
	public void .ctor() { }

	// RVA: 0xD5C398
	public bool Equals(System.Nullable<System.Security.Principal.TokenImpersonationLevel> left, System.Nullable<System.Security.Principal.TokenImpersonationLevel> right) { }

	// RVA: 0xD5C514
	public int GetHashCode(System.Nullable<System.Security.Principal.TokenImpersonationLevel> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WellKnownSidTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5C5C8
	public void .ctor() { }

	// RVA: 0xD5C5D0
	public bool Equals(WellKnownSidType left, WellKnownSidType right) { }

	// RVA: 0xD5C658
	public int GetHashCode(WellKnownSidType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WellKnownSidTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5C680
	public void .ctor() { }

	// RVA: 0xD5C688
	public bool Equals(System.Nullable<System.Security.Principal.WellKnownSidType> left, System.Nullable<System.Security.Principal.WellKnownSidType> right) { }

	// RVA: 0xD5C804
	public int GetHashCode(System.Nullable<System.Security.Principal.WellKnownSidType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsAccountTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5C8B8
	public void .ctor() { }

	// RVA: 0xD5C8C0
	public bool Equals(WindowsAccountType left, WindowsAccountType right) { }

	// RVA: 0xD5C948
	public int GetHashCode(WindowsAccountType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsAccountTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5C970
	public void .ctor() { }

	// RVA: 0xD5C978
	public bool Equals(System.Nullable<System.Security.Principal.WindowsAccountType> left, System.Nullable<System.Security.Principal.WindowsAccountType> right) { }

	// RVA: 0xD5CAF4
	public int GetHashCode(System.Nullable<System.Security.Principal.WindowsAccountType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsBuiltInRoleEqualityComparer
{
	// Methods

	// RVA: 0xD5CBA8
	public void .ctor() { }

	// RVA: 0xD5CBB0
	public bool Equals(WindowsBuiltInRole left, WindowsBuiltInRole right) { }

	// RVA: 0xD5CC38
	public int GetHashCode(WindowsBuiltInRole obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsBuiltInRoleEqualityComparer
{
	// Methods

	// RVA: 0xD5CC60
	public void .ctor() { }

	// RVA: 0xD5CC68
	public bool Equals(System.Nullable<System.Security.Principal.WindowsBuiltInRole> left, System.Nullable<System.Security.Principal.WindowsBuiltInRole> right) { }

	// RVA: 0xD5CDE4
	public int GetHashCode(System.Nullable<System.Security.Principal.WindowsBuiltInRole> obj) { }

}

// Namespace: 
private sealed class System_Text_NormalizationFormEqualityComparer
{
	// Methods

	// RVA: 0xD5CE98
	public void .ctor() { }

	// RVA: 0xD5CEA0
	public bool Equals(NormalizationForm left, NormalizationForm right) { }

	// RVA: 0xD5CF28
	public int GetHashCode(NormalizationForm obj) { }

}

// Namespace: 
private sealed class NullableSystem_Text_NormalizationFormEqualityComparer
{
	// Methods

	// RVA: 0xD5CF50
	public void .ctor() { }

	// RVA: 0xD5CF58
	public bool Equals(System.Nullable<System.Text.NormalizationForm> left, System.Nullable<System.Text.NormalizationForm> right) { }

	// RVA: 0xD5D0D4
	public int GetHashCode(System.Nullable<System.Text.NormalizationForm> obj) { }

}

// Namespace: 
private sealed class System_Threading_ApartmentStateEqualityComparer
{
	// Methods

	// RVA: 0xD5D188
	public void .ctor() { }

	// RVA: 0xD5D190
	public bool Equals(ApartmentState left, ApartmentState right) { }

	// RVA: 0xD5D218
	public int GetHashCode(ApartmentState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ApartmentStateEqualityComparer
{
	// Methods

	// RVA: 0xD5D240
	public void .ctor() { }

	// RVA: 0xD5D248
	public bool Equals(System.Nullable<System.Threading.ApartmentState> left, System.Nullable<System.Threading.ApartmentState> right) { }

	// RVA: 0xD5D3C4
	public int GetHashCode(System.Nullable<System.Threading.ApartmentState> obj) { }

}

// Namespace: 
private sealed class System_Threading_AsyncFlowControlEqualityComparer
{
	// Methods

	// RVA: 0xD5D478
	public void .ctor() { }

	// RVA: 0xD5D480
	public bool Equals(AsyncFlowControl left, AsyncFlowControl right) { }

	// RVA: 0xD5D4B8
	public int GetHashCode(AsyncFlowControl obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_AsyncFlowControlEqualityComparer
{
	// Methods

	// RVA: 0xD5D4C4
	public void .ctor() { }

	// RVA: 0xD5D4CC
	public bool Equals(System.Nullable<System.Threading.AsyncFlowControl> left, System.Nullable<System.Threading.AsyncFlowControl> right) { }

	// RVA: 0xD5D644
	public int GetHashCode(System.Nullable<System.Threading.AsyncFlowControl> obj) { }

}

// Namespace: 
private sealed class System_Threading_EventResetModeEqualityComparer
{
	// Methods

	// RVA: 0xD5D6F4
	public void .ctor() { }

	// RVA: 0xD5D6FC
	public bool Equals(EventResetMode left, EventResetMode right) { }

	// RVA: 0xD5D784
	public int GetHashCode(EventResetMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_EventResetModeEqualityComparer
{
	// Methods

	// RVA: 0xD5D7AC
	public void .ctor() { }

	// RVA: 0xD5D7B4
	public bool Equals(System.Nullable<System.Threading.EventResetMode> left, System.Nullable<System.Threading.EventResetMode> right) { }

	// RVA: 0xD5D930
	public int GetHashCode(System.Nullable<System.Threading.EventResetMode> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockCookieEqualityComparer
{
	// Methods

	// RVA: 0xD5D9E4
	public void .ctor() { }

	// RVA: 0xD5D9EC
	public bool Equals(LockCookie left, LockCookie right) { }

	// RVA: 0xD5DA20
	public int GetHashCode(LockCookie obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockCookieEqualityComparer
{
	// Methods

	// RVA: 0xD5DA4C
	public void .ctor() { }

	// RVA: 0xD5DA54
	public bool Equals(System.Nullable<System.Threading.LockCookie> left, System.Nullable<System.Threading.LockCookie> right) { }

	// RVA: 0xD5DBB0
	public int GetHashCode(System.Nullable<System.Threading.LockCookie> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockRecursionPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD5DC64
	public void .ctor() { }

	// RVA: 0xD5DC6C
	public bool Equals(LockRecursionPolicy left, LockRecursionPolicy right) { }

	// RVA: 0xD5DCF4
	public int GetHashCode(LockRecursionPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockRecursionPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD5DD1C
	public void .ctor() { }

	// RVA: 0xD5DD24
	public bool Equals(System.Nullable<System.Threading.LockRecursionPolicy> left, System.Nullable<System.Threading.LockRecursionPolicy> right) { }

	// RVA: 0xD5DEA0
	public int GetHashCode(System.Nullable<System.Threading.LockRecursionPolicy> obj) { }

}

// Namespace: 
private sealed class System_Threading_NativeOverlappedEqualityComparer
{
	// Methods

	// RVA: 0xD5DF54
	public void .ctor() { }

	// RVA: 0xD5DF5C
	public bool Equals(NativeOverlapped left, NativeOverlapped right) { }

	// RVA: 0xD5DFEC
	public int GetHashCode(NativeOverlapped obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_NativeOverlappedEqualityComparer
{
	// Methods

	// RVA: 0xD5E060
	public void .ctor() { }

	// RVA: 0xD5E068
	public bool Equals(System.Nullable<System.Threading.NativeOverlapped> left, System.Nullable<System.Threading.NativeOverlapped> right) { }

	// RVA: 0xD5E204
	public int GetHashCode(System.Nullable<System.Threading.NativeOverlapped> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadPriorityEqualityComparer
{
	// Methods

	// RVA: 0xD5E2B4
	public void .ctor() { }

	// RVA: 0xD5E2BC
	public bool Equals(ThreadPriority left, ThreadPriority right) { }

	// RVA: 0xD5E344
	public int GetHashCode(ThreadPriority obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadPriorityEqualityComparer
{
	// Methods

	// RVA: 0xD5E36C
	public void .ctor() { }

	// RVA: 0xD5E374
	public bool Equals(System.Nullable<System.Threading.ThreadPriority> left, System.Nullable<System.Threading.ThreadPriority> right) { }

	// RVA: 0xD5E4F0
	public int GetHashCode(System.Nullable<System.Threading.ThreadPriority> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadStateEqualityComparer
{
	// Methods

	// RVA: 0xD5E5A4
	public void .ctor() { }

	// RVA: 0xD5E5AC
	public bool Equals(ThreadState left, ThreadState right) { }

	// RVA: 0xD5E634
	public int GetHashCode(ThreadState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadStateEqualityComparer
{
	// Methods

	// RVA: 0xD5E65C
	public void .ctor() { }

	// RVA: 0xD5E664
	public bool Equals(System.Nullable<System.Threading.ThreadState> left, System.Nullable<System.Threading.ThreadState> right) { }

	// RVA: 0xD5E7E0
	public int GetHashCode(System.Nullable<System.Threading.ThreadState> obj) { }

}

// Namespace: MsgPack.Serialization
internal static class AotHelper
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> EqualityComparerTable; // 0x0

	// Methods

	// RVA: 0xD24730
	public static void HandleAotError(Type mayBeGenericArgument, Exception mayBeAotError) { }

	// RVA: 0xD31E18
	public static object CreateSystemCollectionsGenericDictionary(ConstructorInfo constructor, Type keyType, int initialCapacity) { }

	// RVA: 0xD31A24
	public static object GetEqualityComparer(Type type) { }

	// RVA: 0x30B71FC
	public static void PrepareEqualityComparer() { }

	// RVA: 0xD31FA4
	private static System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeEqualityComparerTable() { }

	// RVA: 0xD3D11C
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class EnumTypedMessagePackSerializerWrapper<T0>
{
	// Fields
	private readonly ICustomizableEnumSerializer _underlyingEnumSerializer; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(SerializationContext context, MessagePackSerializer underlying) { }

	// RVA: -1
	private ICustomizableEnumSerializer MsgPack.Serialization.ICustomizableEnumSerializer.GetCopyAs(EnumSerializationMethod method) { }

}

// Namespace: MsgPack.Serialization
internal abstract class NonGenericMessagePackSerializer
{
	// Fields
	private readonly Type _targetType; // 0x28
	private readonly bool _isNullable; // 0x30

	// Methods

	// RVA: 0xD5E894
	protected Type get_TargetType() { }

	// RVA: 0xD5E89C
	protected void .ctor(SerializationContext ownerContext, Type targetType, SerializerCapabilities capabilities) { }

	// RVA: 0xD5E940
	private void .ctor(SerializationContext ownerContext, Type targetType, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xD5E9F0
	private static bool JudgeNullable(Type type) { }

	// RVA: 0xD5EBC0
	internal override void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: -1
	protected internal abstract void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD5EC44
	internal override object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: -1
	protected internal abstract object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5ED88
	internal override void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xD5EEA4
	protected internal virtual void UnpackToCore(Unpacker unpacker, object collection) { }

}

// Namespace: MsgPack.Serialization
internal class TypedMessagePackSerializerWrapper<T0>
{
	// Fields
	private readonly MessagePackSerializer _underlyingSerializer; // 0x0
	private readonly ICollectionInstanceFactory _underlyingFactory; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(SerializationContext context, MessagePackSerializer underlying) { }

	// RVA: 0x316B894
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x316B894
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x316B894
	protected internal override T UnpackNil() { }

	// RVA: 0x316B894
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: -1
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD5F180
	public void .ctor() { }

	// RVA: 0xD5F428
	internal object <.ctor>b__0(int _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionCollectionMessagePackSerializer
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x50
	private readonly bool _isPackable; // 0x58
	private readonly bool _isUnpackable; // 0x59

	// Methods

	// RVA: 0xD5EEDC
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD5F188
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD5F2AC
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5F3E4
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD5F6F8
	public void .ctor() { }

	// RVA: 0xD5F9A0
	internal object <.ctor>b__0(int _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionDictionaryMessagePackSerializer
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x68
	private readonly bool _isPackable; // 0x70
	private readonly bool _isUnpackable; // 0x71

	// Methods

	// RVA: 0xD5F45C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD5F700
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD5F824
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5F95C
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD5FCFC
	public void .ctor() { }

	// RVA: 0xD60050
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xD60084
	internal void <.ctor>b__1(object c, object x) { }

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

	// RVA: 0xD5F9D4
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD5FD04
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD5FE28
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5FFE4
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xD60028
	protected override void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionEnumMessagePackSerializer
{
	// Methods

	// RVA: 0xD600B8
	public void .ctor(SerializationContext context, Type targetType) { }

	// RVA: 0xD6010C
	protected internal override void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xD602A0
	protected internal override object UnpackFromUnderlyingValue(MessagePackObject messagePackObject) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.Serialization.ReflectionSerializers.ReflectionNilImplicationHandler.<>c <>9; // 0x0
	public static System.Func<System.Object,System.Boolean> <>9__2_0; // 0x8
	public static System.Func<System.Object,System.Boolean> <>9__3_0; // 0x10
	public static System.Func<System.Object,System.Boolean> <>9__4_0; // 0x18
	public static System.Action<System.Object> <>9__6_0; // 0x20

	// Methods

	// RVA: 0xD60AC4
	private static void .cctor() { }

	// RVA: 0xD60B30
	public void .ctor() { }

	// RVA: 0xD60B38
	internal bool <OnPackingMessagePackObject>b__2_0(object value) { }

	// RVA: 0xD60BD4
	internal bool <OnPackingReferenceTypeObject>b__3_0(object value) { }

	// RVA: 0xD60BE0
	internal bool <OnPackingNullableValueTypeObject>b__4_0(object value) { }

	// RVA: 0xD60BEC
	internal void <OnNopOnUnpacked>b__6_0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public System.Func<System.Object,System.Boolean> condition; // 0x10
	public ReflectionSerializerNilImplicationHandlerParameter parameter; // 0x18

	// Methods

	// RVA: 0xD60BF0
	public void .ctor() { }

	// RVA: 0xD60BF8
	internal void <OnPackingCore>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xD60C58
	public void .ctor() { }

	// RVA: 0xD60C60
	internal void <OnThrowNullIsProhibitedExceptionOnUnpacked>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xD60C84
	public void .ctor() { }

	// RVA: 0xD60C8C
	internal void <OnThrowValueTypeCannotBeNull3OnUnpacked>b__0(object _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionNilImplicationHandler
{
	// Fields
	public static readonly ReflectionNilImplicationHandler Instance; // 0x0

	// Methods

	// RVA: 0xD60354
	private void .ctor() { }

	// RVA: 0xD603A8
	protected override System.Func<System.Object,System.Boolean> OnPackingMessagePackObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD604B0
	protected override System.Func<System.Object,System.Boolean> OnPackingReferenceTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD605B8
	protected override System.Func<System.Object,System.Boolean> OnPackingNullableValueTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD606C0
	protected override System.Action<System.Object> OnPackingCore(ReflectionSerializerNilImplicationHandlerParameter parameter, System.Func<System.Object,System.Boolean> condition) { }

	// RVA: 0xD6079C
	protected override System.Action<System.Object> OnNopOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD608A4
	protected override System.Action<System.Object> OnThrowNullIsProhibitedExceptionOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD60964
	protected override System.Action<System.Object> OnThrowValueTypeCannotBeNull3OnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD60A24
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD60FD4
	public void .ctor() { }

	// RVA: 0xD61FEC
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xD62020
	internal void <.ctor>b__1(object c, object x) { }

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

	// RVA: 0xD60CB4
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD616E0
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD61B94
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD61F80
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xD61FC4
	protected override void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD62374
	public void .ctor() { }

	// RVA: 0xD62AA4
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xD62AD8
	internal void <.ctor>b__1(object c, object x) { }

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

	// RVA: 0xD62054
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD62380
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD62880
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD62A38
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xD62A7C
	protected override void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD62DB0
	public void .ctor() { }

	// RVA: 0xD63670
	internal object <.ctor>b__0(int _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionNonGenericDictionaryMessagePackSerializer
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x48
	private readonly bool _isPackable; // 0x50
	private readonly bool _isUnpackable; // 0x51

	// Methods

	// RVA: 0xD62B0C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD62F44
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD6346C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6362C
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD63948
	public void .ctor() { }

	// RVA: 0xD63C78
	internal object <.ctor>b__0(int _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionNonGenericListMessagePackSerializer
{
	// Fields
	private readonly System.Func<System.Int32,System.Object> _factory; // 0x40
	private readonly bool _isPackable; // 0x48
	private readonly bool _isUnpackable; // 0x49

	// Methods

	// RVA: 0xD636A4
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD63954
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD63A74
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD63C34
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public SerializationContext context; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal string <.ctor>b__2(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_1
{
	// Fields
	public SerializingMember member; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B183C
	internal bool <.ctor>b__4(ParameterInfo item) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.Serialization.ReflectionSerializers.ReflectionObjectMessagePackSerializer.<>c<T> <>9; // 0x0
	public static System.Func<MsgPack.Serialization.DataMemberContract,System.Int32,System.Collections.Generic.KeyValuePair<System.String,System.Int32>> <>9__8_0; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Int32>,System.Boolean> <>9__8_1; // 0x0
	public static System.Func<System.Collections.Generic.KeyValuePair<System.String,System.Int32>,System.Int32> <>9__8_3; // 0x0
	public static System.Func<System.Reflection.ParameterInfo,System.Object> <>9__12_0; // 0x0

	// Methods

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal System.Collections.Generic.KeyValuePair<System.String,System.Int32> <.ctor>b__8_0(DataMemberContract contract, int index) { }

	// RVA: 0x316B894
	internal bool <.ctor>b__8_1(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x316B894
	internal int <.ctor>b__8_3(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x30B1D84
	internal object <UnpackFromCore>b__12_0(ParameterInfo p) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public object objectGraph; // 0x0
	public object nullable; // 0x0
	public System.Action<System.Object,System.Object> setter; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2CB8
	internal void <UnpackMemberValue>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_1
{
	// Fields
	public int argumentIndex; // 0x0
	public MsgPack.Serialization.ReflectionSerializers.ReflectionObjectMessagePackSerializer.<>c__DisplayClass13_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x30B2CB8
	internal void <UnpackMemberValue>b__1(object value) { }

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

	// RVA: 0x30B2F84
	public void .ctor(SerializationContext context, SerializationTarget target, SerializerCapabilities capabilities) { }

	// RVA: 0x316B894
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x316B894
	private bool IsNull(T objectTree, int index) { }

	// RVA: 0x316B894
	private void PackMemberValue(Packer packer, T objectTree, int index) { }

	// RVA: 0x316B894
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x316B894
	private object UnpackMemberValue(object objectGraph, Unpacker unpacker, int itemsCount, int unpacked, int index, int unpackerOffset) { }

	// RVA: 0x30B1DF0
	private object UnpackSingleValue(Unpacker unpacker, int index) { }

	// RVA: 0x30B2F84
	private void UnpackAndAddCollectionItem(object objectGraph, Unpacker unpacker, int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public CollectionTraits collectionTraits; // 0x10

	// Methods

	// RVA: 0xD63CAC
	public void .ctor() { }

	// RVA: 0xD65224
	internal void <GetAddItem>b__0(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public MethodInfo getter; // 0x10
	public MethodInfo setter; // 0x18

	// Methods

	// RVA: 0xD64F90
	public void .ctor() { }

	// RVA: 0xD65310
	internal object <GetMetadata>b__0(object target) { }

	// RVA: 0xD65384
	internal void <GetMetadata>b__1(object target, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ConstructorInfo constructor; // 0x10

	// Methods

	// RVA: 0xD650D4
	public void .ctor() { }

	// RVA: 0xD65470
	internal object <CreateCollectionInstanceFactory>b__0(int _) { }

	// RVA: 0xD65500
	internal object <CreateCollectionInstanceFactory>b__1(int capacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xD650DC
	public void .ctor() { }

	// RVA: 0xD65618
	internal object <CreateCollectionInstanceFactory>b__2(int _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xD650E4
	public void .ctor() { }

	// RVA: 0xD656FC
	internal object <CreateCollectionInstanceFactory>b__3(int capacity) { }

	// RVA: 0xD65854
	internal object <CreateCollectionInstanceFactory>b__4(int capacity) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal static class ReflectionSerializerHelper
{
	// Fields
	internal static readonly PropertyInfo DictionaryEntryKeyProperty; // 0x0
	internal static readonly PropertyInfo DictionaryEntryValueProperty; // 0x8

	// Methods

	// RVA: 0x30B57C8
	public static MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionEnumMessagePackSerializer(SerializationContext context) { }

	// RVA: 0x316B894
	public static MessagePackSerializer CreateCollectionSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD614E8
	public static System.Action<System.Object,System.Object> GetAddItem(Type targetType, CollectionTraits collectionTraits) { }

	// RVA: 0xD641DC
	public static void GetMetadata(Type targetType, System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, SerializationContext context, System.Func<System.Object,System.Object>[]& getters, System.Action<System.Object,System.Object>[]& setters, MemberInfo[] memberInfos, DataMemberContract[] contracts, MessagePackSerializer[] serializers) { }

	// RVA: 0xD64F98
	private static void ThrowMissingGetterException(Type targetType, int number, PropertyInfo property) { }

	// RVA: 0xD60FE0
	public static System.Func<System.Int32,System.Object> CreateCollectionInstanceFactory(Type abstractType, Type targetType, Type comparisonType, ConstructorInfo constructor) { }

	// RVA: 0xD650EC
	private static void .cctor() { }

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

	// RVA: 0xD659AC
	public Type get_ItemType() { }

	// RVA: 0xD659B4
	public System.Action<System.Object> get_Store() { }

	// RVA: 0xD659BC
	public void .ctor(Type itemType, System.Action<System.Object> store, string memberName, Type declaringType) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionSerializerNilImplicationHandlerParameter
{
	// Fields
	private readonly Type _itemType; // 0x10
	private readonly string _memberName; // 0x18

	// Methods

	// RVA: 0xD65A3C
	public Type get_ItemType() { }

	// RVA: 0xD65A44
	public string get_MemberName() { }

	// RVA: 0xD65A4C
	public void .ctor(Type itemType, string memberName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass1_0
{
	// Fields
	public Type genericType; // 0x10
	public Type source; // 0x18

	// Methods

	// RVA: 0xD65D40
	public void .ctor() { }

	// RVA: 0xD65D48
	internal bool <EnumerateGenericIntefaces>b__0(Type interface) { }

	// RVA: 0xD65E5C
	internal Type <EnumerateGenericIntefaces>b__1(Type interface) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.Serialization.Reflection.GenericTypeExtensions.<>c <>9; // 0x0
	public static System.Func<System.Type,System.String> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xD65F1C
	private static void .cctor() { }

	// RVA: 0xD65F88
	public void .ctor() { }

	// RVA: 0xD65F90
	internal string <GetFullName>b__3_0(Type t) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class GenericTypeExtensions
{
	// Methods

	// RVA: 0xD65A9C
	public static bool Implements(Type source, Type genericType) { }

	// RVA: 0xD65B00
	private static System.Collections.Generic.IEnumerable<System.Type> EnumerateGenericIntefaces(Type source, Type genericType, bool includesOwn) { }

	// RVA: 0xD63CB4
	public static string GetFullName(Type source) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class ReflectionExtensions
{
	// Methods

	// RVA: 0xD65F98
	public static bool IsAssignableTo(Type source, Type target) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal interface IPolymorphicDeserializer
{
	// Methods

	// RVA: -1
	public abstract object PolymorphicUnpackFrom(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal interface IPolymorphicHelperAttribute
{
	// Methods

	// RVA: -1
	public abstract PolymorphismTarget get_Target() { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal interface IPolymorphicKnownTypeAttribute
{
	// Methods

	// RVA: -1
	public abstract Type get_BindingType() { }

	// RVA: -1
	public abstract string get_TypeCode() { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal interface IPolymorphicRuntimeTypeAttribute
{
	// Methods

	// RVA: -1
	public abstract Type get_VerifierType() { }

	// RVA: -1
	public abstract string get_VerifierMethodName() { }

}

// Namespace: 
[Serializable]
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

	// RVA: 0x30B71FC
	private static void .cctor() { }

	// RVA: 0x30B2870
	public void .ctor() { }

	// RVA: 0x316B894
	internal string <BuildTypeCodeTypeHandleMap>b__4_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x316B894
	internal RuntimeTypeHandle <BuildTypeCodeTypeHandleMap>b__4_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x316B894
	internal Type <BuildTypeHandleTypeCodeMap>b__5_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x316B894
	internal string <BuildTypeHandleTypeCodeMap>b__5_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x30B1D84
	internal string <BuildTypeHandleTypeCodeMap>b__5_2(string b) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class KnownTypePolymorphicMessagePackSerializer<T0>
{
	// Fields
	private readonly PolymorphismSchema _schema; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.String,System.RuntimeTypeHandle> _typeHandleMap; // 0x0
	private readonly System.Collections.Generic.IDictionary<System.RuntimeTypeHandle,System.String> _typeCodeMap; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x30B57C8
	private static System.Collections.Generic.IDictionary<System.String,System.RuntimeTypeHandle> BuildTypeCodeTypeHandleMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x30B57C8
	private static System.Collections.Generic.IDictionary<System.RuntimeTypeHandle,System.String> BuildTypeHandleTypeCodeMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x30B1D84
	private MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x316B894
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x316B894
	private string GetTypeCode(T objectTree) { }

	// RVA: 0x316B894
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30B1D84
	private Type GetTypeFromCode(string typeCode) { }

	// RVA: 0x30B1D84
	private object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x316B894
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x30B1D84
	private Type <UnpackFromCore>b__9_0(string c) { }

	// RVA: 0x316B894
	private T <UnpackFromCore>b__9_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class PolymorphicSerializerProvider<T0>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<T> _defaultSerializer; // 0x0
	private readonly PolymorphismSchema _defaultSchema; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(SerializationContext context, MessagePackSerializer defaultSerializer) { }

	// RVA: 0x30B1E68
	public override object Get(SerializationContext context, object providerParameter) { }

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

	// RVA: 0x30B29E8
	public void .ctor(int capacity) { }

	// RVA: 0x316B894
	public void Enqueue(T item) { }

	// RVA: 0x316B894
	public T Dequeue() { }

	// RVA: 0x30B29E8
	private void SetCapacity(int capacity) { }

	// RVA: 0x30B2CB8
	private void MoveNext(int index) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal static class RuntimeTypeVerifier
{
	// Fields
	private static readonly ReaderWriterLockSlim _resultCacheLock; // 0x0
	private static readonly System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.String,System.String>,System.Boolean> _resultCache; // 0x8
	private static readonly MsgPack.Serialization.Polymorphic.RuntimeTypeVerifier.Queue<System.Collections.Generic.KeyValuePair<System.String,System.String>> _histories; // 0x10

	// Methods

	// RVA: 0xD65FC0
	public static void Verify(AssemblyName assemblyName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD66134
	private static bool VerifyCore(AssemblyName assemblyName, string assemblyFullName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD6660C
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class TypeEmbedingPolymorphicMessagePackSerializer<T0>
{
	// Fields
	private readonly PolymorphismSchema _schema; // 0x0

	// Methods

	// RVA: 0x30B2F18
	public void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x30B1D84
	private MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x316B894
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x316B894
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30B1D84
	private object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x316B894
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x30B1D84
	private Type <UnpackFromCore>b__4_0(Unpacker u) { }

	// RVA: 0x316B894
	private T <UnpackFromCore>b__4_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal static class TypeInfoEncoder
{
	// Methods

	// RVA: 0xD66750
	public static void Encode(Packer packer, string typeCode) { }

	// RVA: 0xD66790
	public static void Encode(Packer packer, Type type) { }

	// RVA: 0x316B894
	public static T Decode(Unpacker unpacker, System.Func<System.String,System.Type> typeFinder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0x316B894
	public static T Decode(Unpacker unpacker, System.Func<MsgPack.Unpacker,System.Type> typeDecoder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0xD66A9C
	public static Type DecodeRuntimeTypeInfo(Unpacker unpacker, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD670AC
	private static void ThrowFailedToDecodeEncodingType() { }

	// RVA: 0xD67100
	private static void ThrowUnknownEncodingType(Byte encodeType) { }

	// RVA: 0xD671E8
	private static void ThrowFailedToDecodeCompressedTypeName() { }

	// RVA: 0xD6723C
	private static void ThrowFailedToDecodeAssemblySimpleName() { }

	// RVA: 0xD67290
	private static void ThrowFailedToDecodeAssemblyVersion() { }

	// RVA: 0xD672E4
	private static void ThrowFailedToDecodeAssemblyCulture() { }

	// RVA: 0xD67338
	private static void ThrowFailedToDecodeAssemblyKeyToken() { }

	// RVA: 0xD66FCC
	private static void CheckUnpackerForRuntimeTypeInfoDecoding(Unpacker unpacker) { }

	// RVA: 0xD675F0
	private static void ThrowEncodedTypeIsNotInNonNillArray() { }

	// RVA: 0xD67644
	private static void ThrowEncodedTypeDoesNotHaveValidArrayItems() { }

	// RVA: 0xD6738C
	private static AssemblyName BuildAssemblyName(string assemblySimpleName, Byte[] version, string culture, Byte[] publicKeyToken) { }

	// RVA: 0xD67520
	private static string DecompressTypeName(string assemblySimpleName, string compressedTypeName) { }

	// RVA: 0xD675B0
	private static Type LoadDecodedType(AssemblyName assemblyName, string typeFullName) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractCollectionMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x50
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x58

	// Methods

	// RVA: 0xD67698
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD6798C
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD67B6C
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class AbstractCollectionSerializerHelper
{
	// Methods

	// RVA: 0xD67834
	public static void GetConcreteSerializer(SerializationContext context, PolymorphismSchema schema, Type abstractType, Type targetType, Type exampleType, ICollectionInstanceFactory factory, MessagePackSerializer serializer) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractDictionaryMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x68
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x70

	// Methods

	// RVA: 0xD67C20
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD67F38
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD68118
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractEnumerableMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly MessagePackSerializer _concreteSerializer; // 0x50

	// Methods

	// RVA: 0xD681CC
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD682F8
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD683D8
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericCollectionMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xD6848C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD68560
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD68640
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericDictionaryMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x50

	// Methods

	// RVA: 0xD686F4
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD68818
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD689A8
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericEnumerableMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xD68A5C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD68B30
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD68C10
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericListMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x48

	// Methods

	// RVA: 0xD68CC4
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD68DE8
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD68FC8
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySegmentMessageSerializer
{
	// Methods

	// RVA: 0xD6907C
	public static void PackByteArraySegmentTo(Packer packer, System.ArraySegment<System.Byte> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xD691C0
	public static void PackCharArraySegmentTo(Packer packer, System.ArraySegment<System.Char> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x316B894
	public static void PackGenericArraySegmentTo(Packer packer, System.ArraySegment<T> objectTree, MsgPack.Serialization.MessagePackSerializer<T> itemSerializer) { }

	// RVA: 0xD69334
	public static System.ArraySegment<System.Byte> UnpackByteArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xD693EC
	public static System.ArraySegment<System.Char> UnpackCharArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x316B894
	public static System.ArraySegment<T> UnpackGenericArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<T> itemSerializer) { }

}

// Namespace: 
[Serializable]
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

	// RVA: 0xD6B10C
	private static void .cctor() { }

	// RVA: 0xD6B178
	public void .ctor() { }

	// RVA: 0xD6B180
	internal object <InitializeArraySerializerFactories>b__4_0(SerializationContext context) { }

	// RVA: 0xD6B2C0
	internal object <InitializeArraySerializerFactories>b__4_1(SerializationContext context) { }

	// RVA: 0xD6B400
	internal object <InitializeArraySerializerFactories>b__4_2(SerializationContext context) { }

	// RVA: 0xD6B540
	internal object <InitializeArraySerializerFactories>b__4_3(SerializationContext context) { }

	// RVA: 0xD6B680
	internal object <InitializeArraySerializerFactories>b__4_4(SerializationContext context) { }

	// RVA: 0xD6B7C0
	internal object <InitializeArraySerializerFactories>b__4_5(SerializationContext context) { }

	// RVA: 0xD6B900
	internal object <InitializeArraySerializerFactories>b__4_6(SerializationContext context) { }

	// RVA: 0xD6BA40
	internal object <InitializeArraySerializerFactories>b__4_7(SerializationContext context) { }

	// RVA: 0xD6BB80
	internal object <InitializeArraySerializerFactories>b__4_8(SerializationContext context) { }

	// RVA: 0xD6BCC0
	internal object <InitializeArraySerializerFactories>b__4_9(SerializationContext context) { }

	// RVA: 0xD6BE00
	internal object <InitializeArraySerializerFactories>b__4_10(SerializationContext context) { }

	// RVA: 0xD6BF40
	internal object <InitializeArraySerializerFactories>b__4_11(SerializationContext context) { }

	// RVA: 0xD6C080
	internal object <InitializeArraySerializerFactories>b__4_12(SerializationContext context) { }

	// RVA: 0xD6C1C0
	internal object <InitializeArraySerializerFactories>b__4_13(SerializationContext context) { }

	// RVA: 0xD6C300
	internal object <InitializeArraySerializerFactories>b__4_14(SerializationContext context) { }

	// RVA: 0xD6C440
	internal object <InitializeArraySerializerFactories>b__4_15(SerializationContext context) { }

	// RVA: 0xD6C580
	internal object <InitializeArraySerializerFactories>b__4_16(SerializationContext context) { }

	// RVA: 0xD6C6C0
	internal object <InitializeArraySerializerFactories>b__4_17(SerializationContext context) { }

	// RVA: 0xD6C800
	internal object <InitializeArraySerializerFactories>b__4_18(SerializationContext context) { }

	// RVA: 0xD6C940
	internal object <InitializeArraySerializerFactories>b__4_19(SerializationContext context) { }

	// RVA: 0xD6CA80
	internal object <InitializeArraySerializerFactories>b__4_20(SerializationContext context) { }

	// RVA: 0xD6CBC0
	internal object <InitializeArraySerializerFactories>b__4_21(SerializationContext context) { }

	// RVA: 0xD6CD00
	internal object <InitializeArraySerializerFactories>b__4_22(SerializationContext context) { }

	// RVA: 0xD6CE40
	internal object <InitializeArraySerializerFactories>b__4_23(SerializationContext context) { }

	// RVA: 0xD6CF80
	internal object <InitializeArraySerializerFactories>b__4_24(SerializationContext context) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySerializer
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> _arraySerializerFactories; // 0x0

	// Methods

	// RVA: 0x30B58A8
	public static MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD694A4
	public static MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD69684
	private static object GetPrimitiveArraySerializer(SerializationContext context, Type targetType) { }

	// RVA: 0xD69940
	private static System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> InitializeArraySerializerFactories() { }

	// RVA: 0xD6B0B0
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SByteArraySerializer
{
	// Methods

	// RVA: 0xD6B23C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6D0C0
	protected internal override void PackToCore(Packer packer, SByte[] objectTree) { }

	// RVA: 0xD6D138
	protected internal override SByte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6D2DC
	protected internal override void UnpackToCore(Unpacker unpacker, SByte[] collection) { }

	// RVA: 0xD6D204
	private static void UnpackToCore(Unpacker unpacker, SByte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int16ArraySerializer
{
	// Methods

	// RVA: 0xD6B4BC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6D37C
	protected internal override void PackToCore(Packer packer, Int16[] objectTree) { }

	// RVA: 0xD6D3F4
	protected internal override Int16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6D598
	protected internal override void UnpackToCore(Unpacker unpacker, Int16[] collection) { }

	// RVA: 0xD6D4C0
	private static void UnpackToCore(Unpacker unpacker, Int16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int32ArraySerializer
{
	// Methods

	// RVA: 0xD6B73C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6D638
	protected internal override void PackToCore(Packer packer, int[] objectTree) { }

	// RVA: 0xD6D6B0
	protected internal override int[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6D854
	protected internal override void UnpackToCore(Unpacker unpacker, int[] collection) { }

	// RVA: 0xD6D77C
	private static void UnpackToCore(Unpacker unpacker, int[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int64ArraySerializer
{
	// Methods

	// RVA: 0xD6B9BC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6D8F4
	protected internal override void PackToCore(Packer packer, Int64[] objectTree) { }

	// RVA: 0xD6D96C
	protected internal override Int64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6DB10
	protected internal override void UnpackToCore(Unpacker unpacker, Int64[] collection) { }

	// RVA: 0xD6DA38
	private static void UnpackToCore(Unpacker unpacker, Int64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class ByteArraySerializer
{
	// Methods

	// RVA: 0xD6BC3C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6DBB0
	protected internal override void PackToCore(Packer packer, Byte[] objectTree) { }

	// RVA: 0xD6DC28
	protected internal override Byte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6DDCC
	protected internal override void UnpackToCore(Unpacker unpacker, Byte[] collection) { }

	// RVA: 0xD6DCF4
	private static void UnpackToCore(Unpacker unpacker, Byte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt16ArraySerializer
{
	// Methods

	// RVA: 0xD6BEBC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6DE6C
	protected internal override void PackToCore(Packer packer, UInt16[] objectTree) { }

	// RVA: 0xD6DEE4
	protected internal override UInt16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6E088
	protected internal override void UnpackToCore(Unpacker unpacker, UInt16[] collection) { }

	// RVA: 0xD6DFB0
	private static void UnpackToCore(Unpacker unpacker, UInt16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt32ArraySerializer
{
	// Methods

	// RVA: 0xD6C13C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6E128
	protected internal override void PackToCore(Packer packer, UInt32[] objectTree) { }

	// RVA: 0xD6E1A0
	protected internal override UInt32[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6E344
	protected internal override void UnpackToCore(Unpacker unpacker, UInt32[] collection) { }

	// RVA: 0xD6E26C
	private static void UnpackToCore(Unpacker unpacker, UInt32[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt64ArraySerializer
{
	// Methods

	// RVA: 0xD6C3BC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6E3E4
	protected internal override void PackToCore(Packer packer, UInt64[] objectTree) { }

	// RVA: 0xD6E45C
	protected internal override UInt64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6E600
	protected internal override void UnpackToCore(Unpacker unpacker, UInt64[] collection) { }

	// RVA: 0xD6E528
	private static void UnpackToCore(Unpacker unpacker, UInt64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SingleArraySerializer
{
	// Methods

	// RVA: 0xD6C63C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6E6A0
	protected internal override void PackToCore(Packer packer, float[] objectTree) { }

	// RVA: 0xD6E718
	protected internal override float[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6E8BC
	protected internal override void UnpackToCore(Unpacker unpacker, float[] collection) { }

	// RVA: 0xD6E7E4
	private static void UnpackToCore(Unpacker unpacker, float[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class DoubleArraySerializer
{
	// Methods

	// RVA: 0xD6C8BC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6E95C
	protected internal override void PackToCore(Packer packer, Double[] objectTree) { }

	// RVA: 0xD6E9D4
	protected internal override Double[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6EB78
	protected internal override void UnpackToCore(Unpacker unpacker, Double[] collection) { }

	// RVA: 0xD6EAA0
	private static void UnpackToCore(Unpacker unpacker, Double[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BooleanArraySerializer
{
	// Methods

	// RVA: 0xD6CB3C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6EC18
	protected internal override void PackToCore(Packer packer, bool[] objectTree) { }

	// RVA: 0xD6EC90
	protected internal override bool[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6EE34
	protected internal override void UnpackToCore(Unpacker unpacker, bool[] collection) { }

	// RVA: 0xD6ED5C
	private static void UnpackToCore(Unpacker unpacker, bool[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSByteArraySerializer
{
	// Methods

	// RVA: 0xD6B37C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6EED4
	protected internal override void PackToCore(Packer packer, System.Nullable<System.SByte>[] objectTree) { }

	// RVA: 0xD6EF60
	protected internal override System.Nullable<System.SByte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6F104
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection) { }

	// RVA: 0xD6F02C
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt16ArraySerializer
{
	// Methods

	// RVA: 0xD6B5FC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6F1A4
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int16>[] objectTree) { }

	// RVA: 0xD6F230
	protected internal override System.Nullable<System.Int16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6F3D4
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection) { }

	// RVA: 0xD6F2FC
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt32ArraySerializer
{
	// Methods

	// RVA: 0xD6B87C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6F474
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int32>[] objectTree) { }

	// RVA: 0xD6F4EC
	protected internal override System.Nullable<System.Int32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6F690
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection) { }

	// RVA: 0xD6F5B8
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt64ArraySerializer
{
	// Methods

	// RVA: 0xD6BAFC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6F730
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int64>[] objectTree) { }

	// RVA: 0xD6F7AC
	protected internal override System.Nullable<System.Int64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6F950
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection) { }

	// RVA: 0xD6F878
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableByteArraySerializer
{
	// Methods

	// RVA: 0xD6BD7C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6F9F0
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Byte>[] objectTree) { }

	// RVA: 0xD6FA7C
	protected internal override System.Nullable<System.Byte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6FC20
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection) { }

	// RVA: 0xD6FB48
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt16ArraySerializer
{
	// Methods

	// RVA: 0xD6BFFC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6FCC0
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt16>[] objectTree) { }

	// RVA: 0xD6FD4C
	protected internal override System.Nullable<System.UInt16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6FEF0
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection) { }

	// RVA: 0xD6FE18
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt32ArraySerializer
{
	// Methods

	// RVA: 0xD6C27C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6FF90
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt32>[] objectTree) { }

	// RVA: 0xD70008
	protected internal override System.Nullable<System.UInt32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD701AC
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection) { }

	// RVA: 0xD700D4
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt64ArraySerializer
{
	// Methods

	// RVA: 0xD6C4FC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7024C
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt64>[] objectTree) { }

	// RVA: 0xD702C8
	protected internal override System.Nullable<System.UInt64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7046C
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection) { }

	// RVA: 0xD70394
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSingleArraySerializer
{
	// Methods

	// RVA: 0xD6C77C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7050C
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Single>[] objectTree) { }

	// RVA: 0xD70584
	protected internal override System.Nullable<System.Single>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD70728
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection) { }

	// RVA: 0xD70650
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableDoubleArraySerializer
{
	// Methods

	// RVA: 0xD6C9FC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD707C8
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Double>[] objectTree) { }

	// RVA: 0xD70844
	protected internal override System.Nullable<System.Double>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD709E8
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection) { }

	// RVA: 0xD70910
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableBooleanArraySerializer
{
	// Methods

	// RVA: 0xD6CC7C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD70A88
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Boolean>[] objectTree) { }

	// RVA: 0xD70B14
	protected internal override System.Nullable<System.Boolean>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD70CB8
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection) { }

	// RVA: 0xD70BE0
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class StringArraySerializer
{
	// Methods

	// RVA: 0xD6CDBC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD70D58
	protected internal override void PackToCore(Packer packer, string[] objectTree) { }

	// RVA: 0xD70DD0
	protected internal override string[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD70F84
	protected internal override void UnpackToCore(Unpacker unpacker, string[] collection) { }

	// RVA: 0xD70E9C
	private static void UnpackToCore(Unpacker unpacker, string[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BinaryArraySerializer
{
	// Methods

	// RVA: 0xD6CEFC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD71024
	protected internal override void PackToCore(Packer packer, Byte[][] objectTree) { }

	// RVA: 0xD7109C
	protected internal override Byte[][] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD71250
	protected internal override void UnpackToCore(Unpacker unpacker, Byte[][] collection) { }

	// RVA: 0xD71168
	private static void UnpackToCore(Unpacker unpacker, Byte[][] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MessagePackObjectArraySerializer
{
	// Methods

	// RVA: 0xD6D03C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD712F0
	protected internal override void PackToCore(Packer packer, MessagePackObject[] objectTree) { }

	// RVA: 0xD713C4
	protected internal override MessagePackObject[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7157C
	protected internal override void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection) { }

	// RVA: 0xD71490
	private static void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UnityArraySerializer
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38
	private readonly Type _itemType; // 0x40

	// Methods

	// RVA: 0xD69788
	public void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD7161C
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD719C0
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD71D1C
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD71A84
	private void UnpackToCore(Unpacker unpacker, IList collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class DateTimeMessagePackSerializerProvider
{
	// Fields
	private readonly MessagePackSerializer _unixEpoc; // 0x10
	private readonly MessagePackSerializer _native; // 0x18
	private readonly MessagePackSerializer _timestamp; // 0x20

	// Methods

	// RVA: 0xD71DF0
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD72414
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class DateTimeOffsetMessagePackSerializer
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xD72648
	public void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xD726E0
	protected internal override void PackToCore(Packer packer, DateTimeOffset objectTree) { }

	// RVA: 0xD7292C
	protected internal override DateTimeOffset UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class DateTimeOffsetMessagePackSerializerProvider
{
	// Fields
	private readonly MessagePackSerializer _unixEpoc; // 0x10
	private readonly MessagePackSerializer _native; // 0x18
	private readonly MessagePackSerializer _timestamp; // 0x20

	// Methods

	// RVA: 0xD7303C
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD734B4
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_BooleanMessagePackSerializer
{
	// Methods

	// RVA: 0xD736E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7376C
	protected internal override void PackToCore(Packer packer, bool value) { }

	// RVA: 0xD7378C
	protected internal override bool UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteMessagePackSerializer
{
	// Methods

	// RVA: 0xD739C4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD73A48
	protected internal override void PackToCore(Packer packer, Byte value) { }

	// RVA: 0xD73A68
	protected internal override Byte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharMessagePackSerializer
{
	// Methods

	// RVA: 0xD73CA0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD73D24
	protected internal override void PackToCore(Packer packer, Char value) { }

	// RVA: 0xD73D44
	protected internal override Char UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DecimalMessagePackSerializer
{
	// Methods

	// RVA: 0xD73F48
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD73FCC
	protected internal override void PackToCore(Packer packer, Decimal value) { }

	// RVA: 0xD740D0
	protected internal override Decimal UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DoubleMessagePackSerializer
{
	// Methods

	// RVA: 0xD74344
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD743C8
	protected internal override void PackToCore(Packer packer, Double value) { }

	// RVA: 0xD743E4
	protected internal override Double UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_GuidMessagePackSerializer
{
	// Methods

	// RVA: 0xD7461C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD746A0
	protected internal override void PackToCore(Packer packer, Guid value) { }

	// RVA: 0xD746EC
	protected internal override Guid UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int16MessagePackSerializer
{
	// Methods

	// RVA: 0xD7490C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD74990
	protected internal override void PackToCore(Packer packer, Int16 value) { }

	// RVA: 0xD749B0
	protected internal override Int16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int32MessagePackSerializer
{
	// Methods

	// RVA: 0xD74BE8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD74C6C
	protected internal override void PackToCore(Packer packer, int value) { }

	// RVA: 0xD74C8C
	protected internal override int UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int64MessagePackSerializer
{
	// Methods

	// RVA: 0xD74EC4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD74F48
	protected internal override void PackToCore(Packer packer, Int64 value) { }

	// RVA: 0xD74F68
	protected internal override Int64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SByteMessagePackSerializer
{
	// Methods

	// RVA: 0xD751A0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD75224
	protected internal override void PackToCore(Packer packer, SByte value) { }

	// RVA: 0xD75244
	protected internal override SByte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SingleMessagePackSerializer
{
	// Methods

	// RVA: 0xD7547C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD75500
	protected internal override void PackToCore(Packer packer, float value) { }

	// RVA: 0xD7551C
	protected internal override float UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_TimeSpanMessagePackSerializer
{
	// Methods

	// RVA: 0xD75754
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD757D8
	protected internal override void PackToCore(Packer packer, TimeSpan value) { }

	// RVA: 0xD7585C
	protected internal override TimeSpan UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt16MessagePackSerializer
{
	// Methods

	// RVA: 0xD75A94
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD75B18
	protected internal override void PackToCore(Packer packer, UInt16 value) { }

	// RVA: 0xD75B38
	protected internal override UInt16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt32MessagePackSerializer
{
	// Methods

	// RVA: 0xD75D70
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD75DF4
	protected internal override void PackToCore(Packer packer, UInt32 value) { }

	// RVA: 0xD75E14
	protected internal override UInt32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt64MessagePackSerializer
{
	// Methods

	// RVA: 0xD7604C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD760D0
	protected internal override void PackToCore(Packer packer, UInt64 value) { }

	// RVA: 0xD760F0
	protected internal override UInt64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_BitVector32MessagePackSerializer
{
	// Methods

	// RVA: 0xD76328
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD763AC
	protected internal override void PackToCore(Packer packer, BitVector32 value) { }

	// RVA: 0xD763CC
	protected internal override BitVector32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class GenericSerializer
{
	// Methods

	// RVA: 0x30B58A8
	public static MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0xD76604
	public static MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema schema) { }

	// RVA: 0xD769B8
	private static MessagePackSerializer CreateArraySerializer(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD76A30
	private static MessagePackSerializer CreateNullableSerializer(SerializationContext context, Type nullableType, Type underlyingType) { }

	// RVA: 0xD76AD8
	private static MessagePackSerializer CreateListSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD76BF4
	private static MessagePackSerializer CreateDictionarySerializer(SerializationContext context, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema schema) { }

	// RVA: 0xD77108
	public static MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD77200
	internal static MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema, CollectionTraits traits) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class MessagePackObjectExtensions
{
	// Methods

	// RVA: 0xD72E80
	public static Int64 DeserializeAsInt64(MessagePackObject source) { }

	// RVA: 0xD77494
	public static string DeserializeAsString(MessagePackObject source) { }

	// RVA: 0xD72CC4
	public static MessagePackExtendedTypeObject DeserializeAsMessagePackExtendedTypeObject(MessagePackObject source) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackExtendedTypeObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD77650
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD776D4
	protected internal override void PackToCore(Packer packer, MessagePackExtendedTypeObject value) { }

	// RVA: 0xD776F8
	protected internal override MessagePackExtendedTypeObject UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectDictionaryMessagePackSerializer
{
	// Methods

	// RVA: 0xD778E0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD77964
	protected internal override void PackToCore(Packer packer, MessagePackObjectDictionary objectTree) { }

	// RVA: 0xD77C30
	protected internal override MessagePackObjectDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD77E24
	protected internal override void UnpackToCore(Unpacker unpacker, MessagePackObjectDictionary collection) { }

	// RVA: 0xD77D04
	private static void UnpackToCore(Unpacker unpacker, int count, MessagePackObjectDictionary collection) { }

	// RVA: 0xD77E9C
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD77F04
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD77F88
	protected internal override void PackToCore(Packer packer, MessagePackObject value) { }

	// RVA: 0xD78004
	protected internal override MessagePackObject UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public UnityMultidimensionalArraySerializer <>4__this; // 0x10
	public Packer packer; // 0x18
	public Array array; // 0x20

	// Methods

	// RVA: 0xD785F4
	public void .ctor() { }

	// RVA: 0xD797F0
	internal void <PackArrayCore>b__0(int[] indices) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public Unpacker unpacker; // 0x10
	public UnityMultidimensionalArraySerializer <>4__this; // 0x18

	// Methods

	// RVA: 0xD79498
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1
{
	// Fields
	public Unpacker arrayUnpacker; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xD797E0
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2
{
	// Fields
	public Array result; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xD797E8
	public void .ctor() { }

	// RVA: 0xD79844
	internal void <UnpackFromCore>b__0(int[] indices) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UnityMultidimensionalArraySerializer
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38
	private readonly MessagePackSerializer _int32ArraySerializer; // 0x40
	private readonly Type _itemType; // 0x48

	// Methods

	// RVA: 0xD69820
	public void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD78070
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD78108
	private void PackArrayCore(Packer packer, Array array) { }

	// RVA: 0xD785FC
	private static void GetArrayMetadata(Array array, int[] lengths, int[] lowerBounds) { }

	// RVA: 0xD78968
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD794A0
	private void ReadArrayMetadata(Unpacker metadataUnpacker, int[] lengths, int[] lowerBounds) { }

	// RVA: 0xD7873C
	private static void ForEach(Array array, int totalLength, int[] lowerBounds, int[] lengths, System.Action<System.Int32[]> action) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NativeDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xD7230C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD798E4
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD7998C
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NullableMessagePackSerializer
{
	// Fields
	private readonly MessagePackSerializer _valueSerializer; // 0x38

	// Methods

	// RVA: 0xD76D2C
	public void .ctor(SerializationContext ownerContext, Type nullableType, Type underlyingType) { }

	// RVA: 0xD722D4
	public void .ctor(SerializationContext ownerContext, Type nullableType, MessagePackSerializer valueSerializer) { }

	// RVA: 0xD79A1C
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD79A3C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_ArraySegment_1MessagePackSerializer<T0>
{
	// Fields
	private static readonly System.Action<MsgPack.Packer,System.ArraySegment<T>,MsgPack.Serialization.MessagePackSerializer<T>> _packing; // 0x0
	private static readonly System.Func<MsgPack.Unpacker,MsgPack.Serialization.MessagePackSerializer<T>,System.ArraySegment<T>> _unpacking; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<T> _itemSerializer; // 0x0

	// Methods

	// RVA: 0x30B5790
	private static System.Action<MsgPack.Packer,System.ArraySegment<T>,MsgPack.Serialization.MessagePackSerializer<T>> InitializePacking() { }

	// RVA: 0x30B5790
	private static System.Func<MsgPack.Unpacker,MsgPack.Serialization.MessagePackSerializer<T>,System.ArraySegment<T>> InitializeUnpacking() { }

	// RVA: 0x30B2CB8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x316B894
	protected internal sealed override void PackToCore(Packer packer, System.ArraySegment<T> objectTree) { }

	// RVA: 0x316B894
	protected internal sealed override System.ArraySegment<T> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30B71FC
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteArrayMessagePackSerializer
{
	// Methods

	// RVA: 0xD79A5C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD79AE0
	protected internal override void PackToCore(Packer packer, Byte[] value) { }

	// RVA: 0xD79B00
	protected internal override Byte[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharArrayMessagePackSerializer
{
	// Methods

	// RVA: 0xD79BD4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD79C58
	protected internal override void PackToCore(Packer packer, Char[] value) { }

	// RVA: 0xD79C94
	protected internal override Char[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_DictionaryEntryMessagePackSerializer
{
	// Methods

	// RVA: 0xD79D68
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD79DEC
	protected internal override void PackToCore(Packer packer, DictionaryEntry objectTree) { }

	// RVA: 0xD79EB0
	private static MessagePackObject EnsureMessagePackObject(object obj) { }

	// RVA: 0xD79F90
	protected internal override DictionaryEntry UnpackFromCore(Unpacker unpacker) { }

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

	// RVA: 0xD76E78
	public void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema keysSchema, PolymorphismSchema valuesSchema) { }

	// RVA: 0xD7A1E4
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD7A614
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7ACAC
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD7A794
	private void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xD7A720
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_KeyValuePair_2MessagePackSerializer<T0, T1>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x316B894
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.KeyValuePair<TKey,TValue> objectTree) { }

	// RVA: 0x316B894
	protected internal override System.Collections.Generic.KeyValuePair<TKey,TValue> UnpackFromCore(Unpacker unpacker) { }

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

	// RVA: 0xD76D88
	public void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD7AD54
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD7B10C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7B61C
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD7B2E4
	private void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xD7B1CC
	public object CreateInstance(int initialCapacity) { }

	// RVA: 0xD7B6C4
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_Collections_Generic_ListOfMessagePackObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD7B7DC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7B860
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.List<MsgPack.MessagePackObject> objectTree) { }

	// RVA: 0xD7BA88
	protected internal override System.Collections.Generic.List<MsgPack.MessagePackObject> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7BC5C
	protected internal override void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection) { }

	// RVA: 0xD7BB70
	private static void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection, int count) { }

	// RVA: 0xD7BCFC
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_Queue_1MessagePackSerializer<T0>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TItem> _itemSerializer; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x30B2F18
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.Queue<TItem> objectTree) { }

	// RVA: 0x30B1D84
	protected internal override System.Collections.Generic.Queue<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30B2F18
	protected internal override void UnpackToCore(Unpacker unpacker, System.Collections.Generic.Queue<TItem> collection) { }

	// RVA: -1
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_Stack_1MessagePackSerializer<T0>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TItem> _itemSerializer; // 0x0

	// Methods

	// RVA: 0x30B2CB8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x30B2F18
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.Stack<TItem> objectTree) { }

	// RVA: 0x30B1D84
	protected internal override System.Collections.Generic.Stack<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30B2F18
	protected internal override void UnpackToCore(Unpacker unpacker, System.Collections.Generic.Stack<TItem> collection) { }

	// RVA: 0x30B1DF0
	private System.Collections.Generic.IEnumerable<TItem> UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: -1
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_QueueMessagePackSerializer
{
	// Methods

	// RVA: 0xD7BD78
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7BDFC
	protected internal override void PackToCore(Packer packer, Queue objectTree) { }

	// RVA: 0xD7C098
	protected internal override Queue UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7C17C
	protected internal override void UnpackToCore(Unpacker unpacker, Queue collection) { }

	// RVA: 0xD7C2F8
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_NameValueCollectionMessagePackSerializer
{
	// Methods

	// RVA: 0xD7C360
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7C3E4
	protected internal override void PackToCore(Packer packer, NameValueCollection objectTree) { }

	// RVA: 0xD7C7C4
	protected internal override NameValueCollection UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7CBE8
	protected internal override void UnpackToCore(Unpacker unpacker, NameValueCollection collection) { }

	// RVA: 0xD7C898
	private static void UnpackToCore(Unpacker unpacker, NameValueCollection collection, int keyCount) { }

	// RVA: 0xD7CC88
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_StackMessagePackSerializer
{
	// Methods

	// RVA: 0xD7CCF0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7CD74
	protected internal override void PackToCore(Packer packer, Stack objectTree) { }

	// RVA: 0xD7D010
	protected internal override Stack UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7D348
	protected internal override void UnpackToCore(Unpacker unpacker, Stack collection) { }

	// RVA: 0xD7D0E0
	private static ICollection UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: 0xD7D694
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_DBNullMessagePackSerializer
{
	// Methods

	// RVA: 0xD7D6FC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7D780
	protected internal override void PackToCore(Packer packer, DBNull objectTree) { }

	// RVA: 0xD7D79C
	protected internal override DBNull UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7D7F0
	protected internal override DBNull UnpackNil() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Globalization_CultureInfoMessagePackSerializer
{
	// Methods

	// RVA: 0xD7D86C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7D8F0
	protected internal override void PackToCore(Packer packer, CultureInfo objectTree) { }

	// RVA: 0xD7D934
	protected internal override CultureInfo UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD7D9C4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7DA48
	protected internal override void PackToCore(Packer packer, object value) { }

	// RVA: 0xD7DB50
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_StringMessagePackSerializer
{
	// Methods

	// RVA: 0xD7DE8C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7DF10
	protected internal override void PackToCore(Packer packer, string value) { }

	// RVA: 0xD7DF30
	protected internal override string UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Text_StringBuilderMessagePackSerializer
{
	// Methods

	// RVA: 0xD7DFF0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7E074
	protected internal override void PackToCore(Packer packer, StringBuilder value) { }

	// RVA: 0xD7E0B8
	protected internal override StringBuilder UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7E1A8
	protected internal override void UnpackToCore(Unpacker unpacker, StringBuilder collection) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UriMessagePackSerializer
{
	// Methods

	// RVA: 0xD7E27C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7E300
	protected internal override void PackToCore(Packer packer, Uri objectTree) { }

	// RVA: 0xD7E344
	protected internal override Uri UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_VersionMessagePackSerializer
{
	// Methods

	// RVA: 0xD7E3C4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7E448
	protected internal override void PackToCore(Packer packer, Version objectTree) { }

	// RVA: 0xD7E4C0
	protected internal override Version UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xD72390
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7E74C
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD7E7F8
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampMessagePackSerializer
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xD7E8A0
	public void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xD7E938
	protected internal override void PackToCore(Packer packer, Timestamp objectTree) { }

	// RVA: 0xD7EAD0
	protected internal override Timestamp UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampMessagePackSerializerProvider
{
	// Fields
	private readonly MessagePackSerializer _unixEpoc; // 0x10
	private readonly MessagePackSerializer _native; // 0x18
	private readonly MessagePackSerializer _timestamp; // 0x20

	// Methods

	// RVA: 0xD7EDA8
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD7F220
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class UnixEpocDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xD72250
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD7F454
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD7F4F0
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityCollectionMessagePackSerializer
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40
	private readonly MethodInfo _add; // 0x48

	// Methods

	// RVA: 0xD677F0
	protected void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD7F664
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD7FA24
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD67AC8
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7FCB4
	protected override void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializer<T0, T1, T2>
{
	// Methods

	// RVA: 0x316B894
	protected override int GetCount(TDictionary dictionary) { }

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

	// RVA: 0xD67D70
	protected void .ctor(SerializationContext ownerContext, Type targetType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD7FDA0
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD80204
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD68074
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD806FC
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD8070C
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD80260
	private void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializerBase<T0, T1, T2>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x316B894
	protected internal override void PackToCore(Packer packer, TDictionary objectTree) { }

	// RVA: -1
	protected abstract int GetCount(TDictionary dictionary) { }

	// RVA: 0x316B894
	protected internal override TDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x316B894
	internal virtual TDictionary InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract TDictionary CreateInstance(int initialCapacity) { }

	// RVA: 0x316B894
	private void UnpackToCore(Unpacker unpacker, TDictionary collection, int itemsCount) { }

	// RVA: 0x316B894
	protected virtual void AddItem(TDictionary dictionary, TKey key, TValue value) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityEnumerableMessagePackSerializer
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40

	// Methods

	// RVA: 0xD682C4
	protected void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD807B4
	protected internal override void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class EnumerableMessagePackSerializerBase<T0, T1>
{
	// Methods

	// RVA: -1
	protected abstract TCollection CreateInstance(int initialCapacity) { }

	// RVA: -1
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityEnumerableMessagePackSerializerBase
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38

	// Methods

	// RVA: 0xD80BC0
	internal MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xD7F580
	protected void .ctor(SerializationContext ownerContext, Type targetType, Type itemType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD80BC8
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD80BD8
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD7FA80
	internal void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xD80C80
	protected virtual void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public interface ICollectionInstanceFactory
{
	// Methods

	// RVA: -1
	public abstract object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericCollectionMessagePackSerializer
{
	// Methods

	// RVA: 0xD60FDC
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD61800
	protected internal override void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericDictionaryMessagePackSerializer
{
	// Fields
	private readonly MessagePackSerializer _keySerializer; // 0x38
	private readonly MessagePackSerializer _valueSerializer; // 0x40

	// Methods

	// RVA: 0xD62DB8
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD63064
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD635D0
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD688E0
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD8123C
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD8124C
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD80DFC
	private void UnpackToCore(Unpacker unpacker, IDictionary collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializer
{
	// Methods

	// RVA: 0xD6237C
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD624A0
	protected internal override void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializerBase
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38

	// Methods

	// RVA: 0xD81320
	internal MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xD80CB8
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD81328
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD81338
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD61D4C
	internal void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xD813E0
	protected virtual void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericListMessagePackSerializer
{
	// Methods

	// RVA: 0xD63950
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD63BD8
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD68F24
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD81418
	protected override void AddItem(object collection, object item) { }

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


