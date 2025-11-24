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

	// RVA: 0x315B3A8
	public <member>j__TPar get_member() { }

	// RVA: 0x315B3A8
	public <data>j__TPar get_data() { }

	// RVA: 0x315B3A8
	public void .ctor(<member>j__TPar member, <data>j__TPar data) { }

	// RVA: 0x30A1344
	public override bool Equals(object value) { }

	// RVA: 0x30A14A4
	public override int GetHashCode() { }

	// RVA: 0x30A17DC
	public override string ToString() { }

}

// Namespace: MsgPack
internal static class BigEndianBinary
{
	// Methods

	// RVA: 0xCD2FC4
	public static Int16 ToInt16(Byte[] buffer, int offset) { }

	// RVA: 0xCD300C
	public static int ToInt32(Byte[] buffer, int offset) { }

	// RVA: 0xCD3084
	public static Int64 ToInt64(Byte[] buffer, int offset) { }

	// RVA: 0xCD315C
	public static Byte ToByte(Byte[] buffer, int offset) { }

	// RVA: 0xCD318C
	public static UInt16 ToUInt16(Byte[] buffer, int offset) { }

	// RVA: 0xCD31D4
	public static UInt32 ToUInt32(Byte[] buffer, int offset) { }

	// RVA: 0xCD324C
	public static UInt64 ToUInt64(Byte[] buffer, int offset) { }

	// RVA: 0xCD3324
	public static float ToSingle(Byte[] buffer, int offset) { }

	// RVA: 0xCD3420
	public static Double ToDouble(Byte[] buffer, int offset) { }

}

// Namespace: MsgPack
internal static class Binary
{
	// Fields
	public static readonly Byte[] Empty; // 0x0

	// Methods

	// RVA: 0xCD354C
	public static string ToHexString(Byte[] blob) { }

	// RVA: 0xCD35D4
	public static string ToHexString(Byte[] blob, bool withPrefix) { }

	// RVA: 0xCD380C
	public static void ToHexString(Byte[] blob, StringBuilder buffer) { }

	// RVA: 0xCD36D8
	private static void ToHexStringCore(Byte[] blob, StringBuilder buffer, bool withPrefix) { }

	// RVA: 0xCD3894
	private static Char ToHexChar(int b) { }

	// RVA: 0xCD38B0
	public static int ToBits(float value) { }

	// RVA: 0xCD38C0
	public static Int64 ToBits(Double value) { }

	// RVA: 0xCD38C8
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class BufferManager
{
	// Methods

	// RVA: 0xCD3948
	public static Byte[] NewByteBuffer(int size) { }

	// RVA: 0xCD39D0
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

	// RVA: 0xCD3A58
	protected void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCD3AC4
	public System.ArraySegment<System.Byte> GetResultBytes() { }

	// RVA: -1
	public abstract Byte[] GetFinalBuffer() { }

}

// Namespace: MsgPack
public abstract class ByteArrayUnpacker
{
	// Methods

	// RVA: 0xCD3B7C
	protected void .ctor() { }

}

// Namespace: MsgPack
internal abstract class ByteBufferAllocator
{
	// Methods

	// RVA: -1
	public abstract bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xCD3B84
	protected void .ctor() { }

}

// Namespace: MsgPack
internal sealed class CollectionDebuggerProxy<T0>
{}

// Namespace: MsgPack
internal static class CollectionOperation
{
	// Methods

	// RVA: 0x315B3A8
	public static void CopyTo(System.Collections.Generic.IEnumerable<T> source, int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x315B3A8
	public static void CopyTo(System.Collections.Generic.IEnumerable<TSource> source, int sourceCount, int index, TDestination[] array, int arrayIndex, int count, System.Func<TSource,TDestination> converter) { }

	// RVA: 0x315B3A8
	private static void ValidateCopyToArguments(int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x315B3A8
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

	// RVA: 0xCD3B8C
	public static bool EncodeString(Encoder source, Char[] chars, int charsOffset, int charsLength, Byte[] buffer, int bufferOffset, int bufferCount, int charsUsed, int bytesUsed) { }

	// RVA: 0xCD3BD4
	public static bool DecodeString(Decoder source, Byte[] bytes, int bytesOffset, int bytesLength, Char[] buffer, StringBuilder result) { }

}

// Namespace: MsgPack
internal sealed class FixedArrayBufferAllocator
{
	// Fields
	public static readonly ByteBufferAllocator Instance; // 0x0

	// Methods

	// RVA: 0xCD3CF4
	private void .ctor() { }

	// RVA: 0xCD3CFC
	public override bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xCD3D20
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

	// RVA: 0xCD38B8
	public void .ctor(float value) { }

	// RVA: 0xCD3394
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

	// RVA: 0xCD3450
	public void .ctor(Byte[] bigEndianBytes, int offset) { }

}

// Namespace: MsgPack
[Serializable]
public sealed class InvalidMessagePackStreamException
{
	// Methods

	// RVA: 0xCD3D8C
	public void .ctor() { }

	// RVA: 0xCD3E10
	public void .ctor(string message) { }

	// RVA: 0xCD3EA4
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xCD3F3C
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

	// RVA: 0xCD3FC0
	public static Byte get_Timestamp() { }

	// RVA: 0xCD3FC8
	public static Byte get_MultidimensionalArray() { }

}

// Namespace: MsgPack
public static class KnownExtTypeName
{
	// Methods

	// RVA: 0xCD3FD0
	public static string get_Timestamp() { }

	// RVA: 0xCD4014
	public static string get_MultidimensionalArray() { }

}

// Namespace: MsgPack
[Serializable]
public sealed class MessageNotSupportedException
{
	// Methods

	// RVA: 0xCD4058
	public void .ctor() { }

	// RVA: 0xCD40DC
	public void .ctor(string message) { }

	// RVA: 0xCD4170
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xCD4208
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

	// RVA: 0xCD428C
	public override int get_BytesUsed() { }

	// RVA: 0xCD4298
	public override int get_InitialBufferOffset() { }

	// RVA: 0xCD42A0
	public void .ctor(Byte[] buffer, int startOffset, ByteBufferAllocator allocator, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCD4484
	public override Byte[] GetFinalBuffer() { }

	// RVA: 0xCD448C
	protected override void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xCD4568
	protected override void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xCD4588
	protected override void WriteByte(Byte value) { }

	// RVA: 0xCD4778
	private void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xCD4548
	private void WriteBytes(Byte[] value) { }

	// RVA: 0xCD4644
	private void ThrowEofException(int requiredSize) { }

	// RVA: 0xCD4848
	protected override void PackCore(bool value) { }

	// RVA: 0xCD4874
	protected override void PackCore(Byte value) { }

	// RVA: 0xCD4980
	protected override void PackCore(SByte value) { }

	// RVA: 0xCD49A8
	protected override void PackCore(Int16 value) { }

	// RVA: 0xCD4AF8
	protected override void PackCore(UInt16 value) { }

	// RVA: 0xCD4B34
	protected override void PackCore(int value) { }

	// RVA: 0xCD4CEC
	protected override void PackCore(UInt32 value) { }

	// RVA: 0xCD4D3C
	protected override void PackCore(Int64 value) { }

	// RVA: 0xCD4FA4
	protected override void PackCore(UInt64 value) { }

	// RVA: 0xCD5008
	protected override void PackCore(float value) { }

	// RVA: 0xCD51C0
	protected override void PackCore(Double value) { }

	// RVA: 0xCD5408
	protected override void PackArrayHeaderCore(int length) { }

	// RVA: 0xCD5448
	protected override void PackMapHeaderCore(int length) { }

	// RVA: 0xCD5484
	protected override void PackStringHeaderCore(int length) { }

	// RVA: 0xCD54E0
	protected override void PackBinaryHeaderCore(int length) { }

	// RVA: 0xCD5514
	protected override void PackRawCore(string value) { }

	// RVA: 0xCD56CC
	protected override void PackRawCore(Byte[] value) { }

	// RVA: 0xCD577C
	protected override void PackBinaryCore(Byte[] value) { }

	// RVA: 0xCD57FC
	protected override void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xCD5938
	private void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xCD4898
	private void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xCD49EC
	private void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xCD4B98
	private void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xCD4DC0
	private void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xCD5010
	private void WriteBytes(Byte header, float value) { }

	// RVA: 0xCD51C8
	private void WriteBytes(Byte header, Double value) { }

	// RVA: 0xCD5524
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

	// RVA: 0xCD5994
	public sealed override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xCD5A0C
	protected sealed override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCD5AF0
	public sealed override MessagePackObject get_LastReadData() { }

	// RVA: 0xCD5AFC
	protected sealed override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCD5B08
	public sealed override bool get_IsArrayHeader() { }

	// RVA: 0xCD5B18
	public sealed override bool get_IsMapHeader() { }

	// RVA: 0xCD5B28
	public sealed override bool get_IsCollectionHeader() { }

	// RVA: 0xCD5B38
	public sealed override Int64 get_ItemsCount() { }

	// RVA: 0xCD5DC4
	private CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xCD5DCC
	private System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xCD5E10
	private void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCD5E4C
	private MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xCD5E58
	private void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCD5E64
	internal override bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xCD5E74
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xCD606C
	private bool ReadBinaryCore(int length, int offset, Byte[] result) { }

	// RVA: 0xCD61B4
	private bool ReadStringCore(int length, int offset, string result) { }

	// RVA: 0xCD6354
	private bool ReadRawStringCore(int length, int offset, MessagePackString result) { }

	// RVA: 0xCD666C
	private bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xCD672C
	public sealed override bool ReadByte(Byte result) { }

	// RVA: 0xCD6864
	private bool ReadByteSlow(ReadValueResult header, Byte[] source, int offset, Byte result) { }

	// RVA: 0xCD6D20
	public sealed override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xCD6EF8
	private bool ReadNullableByteSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Byte>& result) { }

	// RVA: 0xCD6FEC
	public sealed override bool ReadSByte(SByte result) { }

	// RVA: 0xCD7118
	private bool ReadSByteSlow(ReadValueResult header, Byte[] source, int offset, SByte result) { }

	// RVA: 0xCD7430
	public sealed override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xCD75FC
	private bool ReadNullableSByteSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.SByte>& result) { }

	// RVA: 0xCD76F0
	public sealed override bool ReadInt16(Int16 result) { }

	// RVA: 0xCD7820
	private bool ReadInt16Slow(ReadValueResult header, Byte[] source, int offset, Int16 result) { }

	// RVA: 0xCD7B28
	public sealed override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xCD7CF8
	private bool ReadNullableInt16Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int16>& result) { }

	// RVA: 0xCD7DEC
	public sealed override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xCD7F28
	private bool ReadUInt16Slow(ReadValueResult header, Byte[] source, int offset, UInt16 result) { }

	// RVA: 0xCD81E0
	public sealed override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCD83BC
	private bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCD84B0
	public sealed override bool ReadInt32(int result) { }

	// RVA: 0xCD85E0
	private bool ReadInt32Slow(ReadValueResult header, Byte[] source, int offset, int result) { }

	// RVA: 0xCD88E4
	public sealed override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xCD8AB4
	private bool ReadNullableInt32Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int32>& result) { }

	// RVA: 0xCD8BA8
	public sealed override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xCD8CE4
	private bool ReadUInt32Slow(ReadValueResult header, Byte[] source, int offset, UInt32 result) { }

	// RVA: 0xCD8FC8
	public sealed override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCD91A4
	private bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCD9298
	public sealed override bool ReadInt64(Int64 result) { }

	// RVA: 0xCD93C8
	private bool ReadInt64Slow(ReadValueResult header, Byte[] source, int offset, Int64 result) { }

	// RVA: 0xCD96B4
	public sealed override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xCD9884
	private bool ReadNullableInt64Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int64>& result) { }

	// RVA: 0xCD9978
	public sealed override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xCD9AB4
	private bool ReadUInt64Slow(ReadValueResult header, Byte[] source, int offset, UInt64 result) { }

	// RVA: 0xCD9D80
	public sealed override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCD9F5C
	private bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCDA050
	public sealed override bool ReadSingle(float result) { }

	// RVA: 0xCDA184
	private bool ReadSingleSlow(ReadValueResult header, Byte[] source, int offset, float result) { }

	// RVA: 0xCDA42C
	public sealed override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xCDA600
	private bool ReadNullableSingleSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Single>& result) { }

	// RVA: 0xCDA6F4
	public sealed override bool ReadDouble(Double result) { }

	// RVA: 0xCDA828
	private bool ReadDoubleSlow(ReadValueResult header, Byte[] source, int offset, Double result) { }

	// RVA: 0xCDAAC8
	public sealed override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xCDAC9C
	private bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Double>& result) { }

	// RVA: 0xCDAD90
	public sealed override bool ReadBoolean(bool result) { }

	// RVA: 0xCDAEF8
	public sealed override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xCDB0CC
	public sealed override bool ReadBinary(Byte[] result) { }

	// RVA: 0xCDB4D0
	public sealed override bool ReadString(string result) { }

	// RVA: 0xCD66CC
	private bool ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xCDB6DC
	private bool ReadObjectCore(bool isDeep, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xCDBA34
	private bool ReadObjectSlow(ReadValueResult header, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xCDC7D4
	private bool ReadItems(int count, bool isMap, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xCDCC38
	private bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] source, int offset, MessagePackExtendedTypeObject result) { }

	// RVA: 0xCDD91C
	protected sealed override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xCDD9D4
	public sealed override bool ReadObject(MessagePackObject result) { }

	// RVA: 0xCDDA38
	protected sealed override bool ReadCore() { }

	// RVA: 0xCDD1E8
	private void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xCDB4BC
	private void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCDDAA4
	private void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCDB2D8
	private void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xCD6B3C
	private void ThrowTypeException(Type type, ReadValueResult header) { }

}

// Namespace: MsgPack
internal static class MessagePackCode
{
	// Methods

	// RVA: 0xCDDC58
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

	// RVA: 0xCDDE6C
	internal static Encoding get_Utf8NonBom() { }

	// RVA: 0xCDDEE8
	internal static Encoding get_Utf8NonBomStrict() { }

	// RVA: 0xCDDF64
	public static Byte[] EncodeString(string value) { }

	// RVA: 0xCDE028
	public static string DecodeStringStrict(Byte[] value) { }

	// RVA: 0xCDE0F4
	public static DateTimeOffset ToDateTimeOffset(Int64 value) { }

	// RVA: 0xCDE1D4
	public static DateTime ToDateTime(Int64 value) { }

	// RVA: 0xCDE2B0
	public static Int64 FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xCDE3B4
	public static Int64 FromDateTime(DateTime value) { }

	// RVA: 0xCDE4A0
	private static void .cctor() { }

}

// Namespace: MsgPack
public struct MessagePackExtendedTypeObject
{
	// Fields
	private readonly Byte _typeCode; // 0x10
	private readonly Byte[] _body; // 0x18

	// Methods

	// RVA: 0xCDE5A4
	public Byte get_TypeCode() { }

	// RVA: 0xCDE5AC
	internal Byte[] get_Body() { }

	// RVA: 0xCDE63C
	public bool get_IsValid() { }

	// RVA: 0xCDE64C
	private void .ctor(Byte[] body, Byte unpackedTypeCode) { }

	// RVA: 0xCDD894
	public static MessagePackExtendedTypeObject Unpack(Byte typeCode, Byte[] body) { }

	// RVA: 0xCDE6B8
	public override string ToString() { }

	// RVA: 0xCDE780
	internal void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xCDE9E8
	public override int GetHashCode() { }

	// RVA: 0xCDEB68
	public override bool Equals(object obj) { }

	// RVA: 0xCDEC78
	public bool Equals(MessagePackExtendedTypeObject other) { }

	// RVA: 0xCDED04
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

	// RVA: 0xCE6090
	public MessagePackValueTypeCode get_TypeCode() { }

	// RVA: 0xCDF240
	public bool get_IsSigned() { }

	// RVA: 0xCDF230
	public bool get_IsInteger() { }

	// RVA: 0xCE6098
	public Type get_Type() { }

	// RVA: 0xCE6048
	internal void .ctor(Type type, MessagePackValueTypeCode typeCode) { }

	// RVA: 0xCE60A0
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

	// RVA: 0xCE613C
	private static void .cctor() { }

	// RVA: 0xCE61A8
	public void .ctor() { }

	// RVA: 0xCE61B0
	internal int <GetHashCode>b__84_0(int hash, MessagePackObject item) { }

	// RVA: 0xCE6224
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

	// RVA: 0xCDED94
	public void .ctor(bool value) { }

	// RVA: 0xCDEE10
	public void .ctor(int value) { }

	// RVA: 0xCDCB98
	public void .ctor(Byte[] value, bool isBinary) { }

	// RVA: 0xCDEE8C
	public bool AsBoolean() { }

	// RVA: 0xCDEFE4
	public Byte AsByte() { }

	// RVA: 0xCDF24C
	public SByte AsSByte() { }

	// RVA: 0xCDF4AC
	public Int16 AsInt16() { }

	// RVA: 0xCDF70C
	public UInt16 AsUInt16() { }

	// RVA: 0xCDC584
	public int AsInt32() { }

	// RVA: 0xCDF914
	public UInt32 AsUInt32() { }

	// RVA: 0xCD5BBC
	public Int64 AsInt64() { }

	// RVA: 0xCDFB24
	public UInt64 AsUInt64() { }

	// RVA: 0xCDFD24
	public float AsSingle() { }

	// RVA: 0xCDFEE4
	public Double AsDouble() { }

	// RVA: 0xCE00A4
	public string AsString() { }

	// RVA: 0xCE017C
	public Byte[] AsBinary() { }

	// RVA: 0xCE0254
	public MessagePackExtendedTypeObject AsMessagePackExtendedTypeObject() { }

	// RVA: 0xCE0370
	public static MessagePackObject op_Implicit(bool value) { }

	// RVA: 0xCDCF8C
	public static MessagePackObject op_Implicit(Byte value) { }

	// RVA: 0xCDCD70
	public static MessagePackObject op_Implicit(SByte value) { }

	// RVA: 0xCDCDF8
	public static MessagePackObject op_Implicit(Int16 value) { }

	// RVA: 0xCDCA80
	public static MessagePackObject op_Implicit(UInt16 value) { }

	// RVA: 0xCDCE80
	public static MessagePackObject op_Implicit(int value) { }

	// RVA: 0xCDCB08
	public static MessagePackObject op_Implicit(UInt32 value) { }

	// RVA: 0xCDCF08
	public static MessagePackObject op_Implicit(Int64 value) { }

	// RVA: 0xCDD014
	public static MessagePackObject op_Implicit(UInt64 value) { }

	// RVA: 0xCDD098
	public static MessagePackObject op_Implicit(float value) { }

	// RVA: 0xCDD164
	public static MessagePackObject op_Implicit(Double value) { }

	// RVA: 0xCE03F8
	public static MessagePackObject op_Implicit(string value) { }

	// RVA: 0xCDB9A8
	public static MessagePackObject op_Implicit(Byte[] value) { }

	// RVA: 0xCDCCE8
	public static MessagePackObject op_Implicit(MessagePackExtendedTypeObject value) { }

	// RVA: 0xCE0480
	public static bool op_Explicit(MessagePackObject value) { }

	// RVA: 0xCE05A4
	public static Byte op_Explicit(MessagePackObject value) { }

	// RVA: 0xCE07A0
	public static SByte op_Explicit(MessagePackObject value) { }

	// RVA: 0xCE09B8
	public static Int16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCE0BD0
	public static UInt16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCE0DB8
	public static int op_Explicit(MessagePackObject value) { }

	// RVA: 0xCE0FC0
	public static UInt32 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCE11B0
	public static Int64 op_Explicit(MessagePackObject value) { }

	// RVA: 0xCE1398
	public static float op_Explicit(MessagePackObject value) { }

	// RVA: 0xCE153C
	public static Double op_Explicit(MessagePackObject value) { }

	// RVA: 0xCDEFD4
	public bool get_IsNil() { }

	// RVA: 0xCE16E0
	public void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCDD34C
	public void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value, bool isImmutable) { }

	// RVA: 0xCE174C
	public void .ctor(MessagePackObjectDictionary value) { }

	// RVA: 0xCDD810
	public void .ctor(MessagePackObjectDictionary value, bool isImmutable) { }

	// RVA: 0xCDCB90
	internal void .ctor(MessagePackString messagePackString) { }

	// RVA: 0xCE2050
	public override bool Equals(object obj) { }

	// RVA: 0xCE21D0
	public bool Equals(MessagePackObject other) { }

	// RVA: 0xCE29A8
	private bool EqualsWhenValueType(MessagePackObject other, ValueTypeCode valueTypeCode, ValueTypeCode otherValuetypeCode) { }

	// RVA: 0xCE2E1C
	private static bool IntegerIntegerEquals(UInt64 left, ValueTypeCode leftTypeCode, UInt64 right, ValueTypeCode rightTypeCode) { }

	// RVA: 0xCE2E8C
	private static bool IntegerSingleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xCE2F68
	private static bool IntegerDoubleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xCE3040
	public override int GetHashCode() { }

	// RVA: 0xCE3324
	public override string ToString() { }

	// RVA: 0xCE33CC
	private void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xCE3F60
	private static void ToStringBinary(StringBuilder buffer, bool isJson, MessagePackString asBinary) { }

	// RVA: -1
	public System.Nullable<System.Boolean> IsTypeOf() { }

	// RVA: 0xCE43C4
	public System.Nullable<System.Boolean> IsTypeOf(Type type) { }

	// RVA: 0xCE4AA0
	public bool get_IsRaw() { }

	// RVA: 0xCE4B50
	public Type get_UnderlyingType() { }

	// RVA: 0xCE4C80
	public void PackToMessage(Packer packer, PackingOptions options) { }

	// RVA: 0xCE5A48
	public Char[] AsCharArray() { }

	// RVA: 0x315B3A8
	private static void VerifyUnderlyingType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x315B3A8
	private static void VerifyUnderlyingRawType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x30A6D04
	private static void ThrowCannotBeNilAs() { }

	// RVA: -1
	private static void ThrowInvalidTypeAs(MessagePackObject instance) { }

	// RVA: 0xCE5AD0
	public static bool op_Equality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xCE2D9C
	public static bool op_Inequality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xCE5B4C
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

	// RVA: 0xCE9A2C
	public System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> get_Current() { }

	// RVA: 0xCE9B24
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xCE9C68
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0xCE9E24
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0xCE9F34
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0xCE9B90
	internal System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> GetCurrentStrict() { }

	// RVA: 0xCEA048
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCE9AAC
	internal void VerifyVersion() { }

	// RVA: 0xCEA1FC
	public void Dispose() { }

	// RVA: 0xCEA250
	public bool MoveNext() { }

	// RVA: 0xCEA490
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xCEA134
	internal void ResetCore() { }

}

// Namespace: 
private struct DictionaryEnumerator
{
	// Fields
	private IDictionaryEnumerator _underlying; // 0x10

	// Methods

	// RVA: 0xCEA558
	public object get_Current() { }

	// RVA: 0xCEA630
	public DictionaryEntry get_Entry() { }

	// RVA: 0xCEA6E8
	public object get_Key() { }

	// RVA: 0xCEA7A0
	public object get_Value() { }

	// RVA: 0xCEA850
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCEA9B4
	public bool MoveNext() { }

	// RVA: 0xCEAA68
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xCEB008
	public MessagePackObject get_Current() { }

	// RVA: 0xCEB138
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xCEAE0C
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCEB248
	public void Dispose() { }

	// RVA: 0xCEB29C
	public bool MoveNext() { }

	// RVA: 0xCEB314
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
public sealed class KeyCollection
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xCEAB20
	public int get_Count() { }

	// RVA: 0xCEAB40
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xCEAB48
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xCEAB50
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xCEAB54
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCEAB88
	public void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xCEAC28
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xCEACA4
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xCEACC4
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xCEAD04
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xCEAD44
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xCEAD84
	public Enumerator GetEnumerator() { }

	// RVA: 0xCEAE80
	private System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xCEAF44
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xCEB8C4
	public MessagePackObject get_Current() { }

	// RVA: 0xCEB9F8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xCEB6C8
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCEBB0C
	public void Dispose() { }

	// RVA: 0xCEBB60
	public bool MoveNext() { }

	// RVA: 0xCEBBD8
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
public sealed class ValueCollection
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xCEB3DC
	public int get_Count() { }

	// RVA: 0xCEB3FC
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xCEB404
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xCEB40C
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xCEB410
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xCEB444
	public void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xCEB4E4
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xCEB560
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xCEB580
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xCEB5C0
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xCEB600
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xCEB640
	public Enumerator GetEnumerator() { }

	// RVA: 0xCEB73C
	private System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xCEB800
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xCEBCA0
	public void .ctor() { }

	// RVA: 0xCEBCA8
	internal bool <TryGetValue>b__0(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xCEBD2C
	public void .ctor() { }

	// RVA: 0xCEBD34
	internal bool <AddCore>b__0(MessagePackObject item) { }

	// RVA: 0xCEBDB8
	internal bool <AddCore>b__1(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass59_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xCEBE3C
	public void .ctor() { }

	// RVA: 0xCEBE44
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

	// RVA: 0xCEBEC8
	private static void .cctor() { }

	// RVA: 0xCEBF34
	public void .ctor() { }

	// RVA: 0xCEBF3C
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

	// RVA: 0xCE62A0
	public bool get_IsFrozen() { }

	// RVA: 0xCE62A8
	public int get_Count() { }

	// RVA: 0xCE6320
	public MessagePackObject get_Item(MessagePackObject key) { }

	// RVA: 0xCE67F8
	public void set_Item(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xCE6ECC
	public KeyCollection get_Keys() { }

	// RVA: 0xCE6F34
	public ValueCollection get_Values() { }

	// RVA: 0xCE6F9C
	private System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Keys() { }

	// RVA: 0xCE7004
	private System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Values() { }

	// RVA: 0xCE706C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.get_IsReadOnly() { }

	// RVA: 0xCE7074
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0xCE707C
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0xCE7084
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0xCE708C
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0xCE70F4
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0xCE7488
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0xCE7640
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xCE7648
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xCE764C
	public void .ctor() { }

	// RVA: 0xCDD4BC
	public void .ctor(int initialCapacity) { }

	// RVA: 0xCE1838
	public void .ctor(System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject> dictionary) { }

	// RVA: 0xCE6548
	private static void ThrowKeyNotNilException(string parameterName) { }

	// RVA: 0xCE7704
	private static void ThrowDuplicatedKeyException(MessagePackObject key, string parameterName) { }

	// RVA: 0xCE6954
	private void VerifyIsNotFrozen() { }

	// RVA: 0xCE7278
	private static MessagePackObject ValidateObjectArgument(object obj, string parameterName) { }

	// RVA: 0xCE783C
	private static System.Nullable<MsgPack.MessagePackObject> TryValidateObjectArgument(object value) { }

	// RVA: 0xCE7E48
	public bool ContainsKey(MessagePackObject key) { }

	// RVA: 0xCE8020
	public bool ContainsValue(MessagePackObject value) { }

	// RVA: 0xCE815C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Contains(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xCE838C
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0xCE65A4
	public bool TryGetValue(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xCDD6B4
	public void Add(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xCE69BC
	private void AddCore(MessagePackObject key, MessagePackObject value, bool allowOverwrite) { }

	// RVA: 0xCE8558
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Add(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xCE8840
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0xCE89FC
	public bool Remove(MessagePackObject key) { }

	// RVA: 0xCE8B48
	private bool RemoveCore(MessagePackObject key, MessagePackObject value, bool checkValue) { }

	// RVA: 0xCE8E98
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Remove(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xCE9180
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0xCE9318
	public void Clear() { }

	// RVA: 0xCE9494
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.CopyTo(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>[] array, int arrayIndex) { }

	// RVA: 0xCE95D0
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xCE9844
	public Enumerator GetEnumerator() { }

	// RVA: 0xCE9868
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.GetEnumerator() { }

	// RVA: 0xCE990C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xCE99B0
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

}

// Namespace: MsgPack
[Serializable]
internal sealed class MessagePackObjectEqualityComparer
{
	// Fields
	private static readonly MessagePackObjectEqualityComparer _instance; // 0x0

	// Methods

	// RVA: 0xCEC0E4
	internal static MessagePackObjectEqualityComparer get_Instance() { }

	// RVA: 0xCEC160
	public void .ctor() { }

	// RVA: 0xCEC168
	public bool Equals(MessagePackObject x, MessagePackObject y) { }

	// RVA: 0xCEC1E8
	public int GetHashCode(MessagePackObject obj) { }

	// RVA: 0xCEC250
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

	// RVA: 0xCEC2BC
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCEC520
	protected override void Dispose(bool disposing) { }

	// RVA: 0xCEC558
	protected override void WriteByte(Byte value) { }

	// RVA: 0xCEC580
	protected override void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xCEC5E8
	protected override void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xCEC5B4
	private void WriteBytes(Byte[] value) { }

	// RVA: 0xCEC6B4
	private void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xCEC6DC
	protected override void PackCore(bool value) { }

	// RVA: 0xCEC708
	protected override void PackCore(Byte value) { }

	// RVA: 0xCEC7F0
	protected override void PackCore(SByte value) { }

	// RVA: 0xCEC87C
	protected override void PackCore(Int16 value) { }

	// RVA: 0xCEC9AC
	protected override void PackCore(UInt16 value) { }

	// RVA: 0xCECA50
	protected override void PackCore(int value) { }

	// RVA: 0xCECBDC
	protected override void PackCore(UInt32 value) { }

	// RVA: 0xCECC98
	protected override void PackCore(Int64 value) { }

	// RVA: 0xCECEB8
	protected override void PackCore(UInt64 value) { }

	// RVA: 0xCECF8C
	protected override void PackCore(float value) { }

	// RVA: 0xCED0D8
	protected override void PackCore(Double value) { }

	// RVA: 0xCED294
	protected override void PackArrayHeaderCore(int length) { }

	// RVA: 0xCED2D4
	protected override void PackMapHeaderCore(int length) { }

	// RVA: 0xCED310
	protected override void PackStringHeaderCore(int length) { }

	// RVA: 0xCED3D8
	protected override void PackBinaryHeaderCore(int length) { }

	// RVA: 0xCED474
	protected override void PackRawCore(string value) { }

	// RVA: 0xCED574
	protected override void PackRawCore(Byte[] value) { }

	// RVA: 0xCED67C
	protected override void PackBinaryCore(Byte[] value) { }

	// RVA: 0xCED760
	protected override void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xCED8F4
	private void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xCEC788
	private void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xCEC928
	private void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xCECB20
	private void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xCECD8C
	private void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xCECF94
	private void WriteBytes(Byte header, float value) { }

	// RVA: 0xCED0E0
	private void WriteBytes(Byte header, Double value) { }

	// RVA: 0xCED4F8
	private void WriteBytes(string value, bool allowStr8) { }

	// RVA: 0xCED9BC
	private void WriteStringBody(string value) { }

	// RVA: 0xCEDAA8
	private void WriteStringBody(Char[] value, int remainingCharsLength) { }

	// RVA: 0xCEDB94
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

	// RVA: 0xCEDBCC
	public sealed override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xCEDC44
	protected sealed override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCEDD28
	public sealed override MessagePackObject get_LastReadData() { }

	// RVA: 0xCEDD34
	protected sealed override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCEDD40
	public sealed override bool get_IsArrayHeader() { }

	// RVA: 0xCEDD50
	public sealed override bool get_IsMapHeader() { }

	// RVA: 0xCEDD60
	public sealed override Int64 get_ItemsCount() { }

	// RVA: 0xCEDDEC
	public sealed override bool get_IsCollectionHeader() { }

	// RVA: 0xCEDDFC
	private CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xCEDE04
	private System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xCEDE48
	private void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCEDE84
	private MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xCEDE90
	private void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCEDE9C
	internal override bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xCEDEAC
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xCEE044
	protected override void Dispose(bool disposing) { }

	// RVA: 0xCEE0B0
	protected void BeginReadSubtree() { }

	// RVA: 0xCEE0C0
	protected internal override void EndReadSubtree() { }

	// RVA: 0xCEE0F0
	private bool ReadBinaryCore(int length, Int64 offset, Byte[] result) { }

	// RVA: 0xCEE400
	private bool ReadStringCore(int length, Int64 offset, string result) { }

	// RVA: 0xCEE6D8
	private bool ReadRawStringCore(int length, Int64 offset, MessagePackString result) { }

	// RVA: 0xCEEA00
	private bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xCEE298
	private void ThrowEofException(Int64 reading) { }

	// RVA: 0xCEEAC8
	public sealed override bool ReadByte(Byte result) { }

	// RVA: 0xCEEC14
	private bool ReadByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, Byte result) { }

	// RVA: 0xCEF130
	public sealed override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xCEF31C
	private bool ReadNullableByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Byte>& result) { }

	// RVA: 0xCEF410
	public sealed override bool ReadSByte(SByte result) { }

	// RVA: 0xCEF550
	private bool ReadSByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, SByte result) { }

	// RVA: 0xCEF8C0
	public sealed override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xCEFAA0
	private bool ReadNullableSByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.SByte>& result) { }

	// RVA: 0xCEFB94
	public sealed override bool ReadInt16(Int16 result) { }

	// RVA: 0xCEFCD8
	private bool ReadInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, Int16 result) { }

	// RVA: 0xCF0048
	public sealed override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xCF022C
	private bool ReadNullableInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int16>& result) { }

	// RVA: 0xCF0320
	public sealed override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xCF0470
	private bool ReadUInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt16 result) { }

	// RVA: 0xCF07B8
	public sealed override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCF09A8
	private bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCF0A9C
	public sealed override bool ReadInt32(int result) { }

	// RVA: 0xCF0BCC
	private bool ReadInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, int result) { }

	// RVA: 0xCF0F30
	public sealed override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xCF1114
	private bool ReadNullableInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int32>& result) { }

	// RVA: 0xCF1208
	public sealed override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xCF1344
	private bool ReadUInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt32 result) { }

	// RVA: 0xCF1684
	public sealed override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCF1874
	private bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt32>& result) { }

	// RVA: 0xCF1968
	public sealed override bool ReadInt64(Int64 result) { }

	// RVA: 0xCF1AAC
	private bool ReadInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, Int64 result) { }

	// RVA: 0xCF1DFC
	public sealed override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xCF1FE0
	private bool ReadNullableInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int64>& result) { }

	// RVA: 0xCF20D4
	public sealed override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xCF2224
	private bool ReadUInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt64 result) { }

	// RVA: 0xCF2554
	public sealed override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCF2744
	private bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt64>& result) { }

	// RVA: 0xCF2838
	public sealed override bool ReadSingle(float result) { }

	// RVA: 0xCF2980
	private bool ReadSingleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, float result) { }

	// RVA: 0xCF2C84
	public sealed override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xCF2E6C
	private bool ReadNullableSingleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Single>& result) { }

	// RVA: 0xCF2F60
	public sealed override bool ReadDouble(Double result) { }

	// RVA: 0xCF30A8
	private bool ReadDoubleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, Double result) { }

	// RVA: 0xCF33A4
	public sealed override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xCF358C
	private bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Double>& result) { }

	// RVA: 0xCF3680
	public sealed override bool ReadBoolean(bool result) { }

	// RVA: 0xCF37FC
	public sealed override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xCF39E4
	public sealed override bool ReadBinary(Byte[] result) { }

	// RVA: 0xCF3F1C
	public sealed override bool ReadString(string result) { }

	// RVA: 0xCEEA64
	private bool ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xCF4260
	private bool ReadObjectCore(bool isDeep, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xCF44DC
	private bool ReadObjectSlow(ReadValueResult header, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xCF5304
	private bool ReadItems(int count, bool isMap, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xCF5584
	private bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] buffer, Int64 offset, MessagePackExtendedTypeObject result) { }

	// RVA: 0xCF57E0
	protected sealed override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xCF5898
	public sealed override bool ReadObject(MessagePackObject result) { }

	// RVA: 0xCF5900
	protected sealed override bool ReadCore() { }

	// RVA: 0xCF567C
	private void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xCF3F08
	private void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCF5970
	private void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xCF3D28
	private void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xCEEF50
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

	// RVA: 0xCEE904
	public void .ctor(string decoded) { }

	// RVA: 0xCEE944
	public void .ctor(Byte[] encoded, bool isBinary) { }

	// RVA: 0xCF5E68
	private void EncodeIfNeeded() { }

	// RVA: 0xCF5F70
	private void DecodeIfNeeded() { }

	// RVA: 0xCF60BC
	public string TryGetString() { }

	// RVA: 0xCF60E0
	public string GetString() { }

	// RVA: 0xCF61A0
	public Byte[] UnsafeGetBuffer() { }

	// RVA: 0xCF61A8
	public Byte[] GetBytes() { }

	// RVA: 0xCF61CC
	public Type GetUnderlyingType() { }

	// RVA: 0xCF6294
	public override string ToString() { }

	// RVA: 0xCF634C
	public override int GetHashCode() { }

	// RVA: 0xCF65B8
	public override bool Equals(object obj) { }

	// RVA: 0xCF669C
	private static bool EqualsEncoded(MessagePackString left, MessagePackString right) { }

	// RVA: 0xCF680C
	private static bool SlowEquals(Byte[] x, Byte[] y) { }

	// RVA: 0xCF6894
	private static void .cctor() { }

}

// Namespace: MsgPack
[Serializable]
public class MessageTypeException
{
	// Methods

	// RVA: 0xCF6934
	public void .ctor() { }

	// RVA: 0xCF5DD4
	public void .ctor(string message) { }

	// RVA: 0xCF69B8
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xCF6A50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: MsgPack
internal sealed class PureAttribute
{
	// Methods

	// RVA: 0xCF6AD4
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

	// RVA: 0xCF6ADC
	public static PackerCompatibilityOptions get_DefaultCompatibilityOptions() { }

	// RVA: 0xCF6B40
	public PackerCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xCEC434
	protected void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCF6B48
	public void Dispose() { }

	// RVA: 0xCEC554
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xCF6BE0
	private void VerifyNotDisposed() { }

	// RVA: 0xCF6C48
	private void ThrowObjectDisposedException() { }

	// RVA: -1
	protected abstract void WriteByte(Byte value) { }

	// RVA: 0xCF6C9C
	protected virtual void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xCF7014
	protected virtual void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xCF7100
	public Packer Pack(SByte value) { }

	// RVA: 0xCF7180
	protected virtual void PackCore(SByte value) { }

	// RVA: 0xCF7210
	protected bool TryPackInt8(Int64 value) { }

	// RVA: 0xCF7270
	public Packer Pack(Byte value) { }

	// RVA: 0xCF72F0
	protected virtual void PackCore(Byte value) { }

	// RVA: 0xCF72FC
	protected bool TryPackUInt8(UInt64 value) { }

	// RVA: 0xCF7350
	public Packer Pack(bool value) { }

	// RVA: 0xCF73D0
	protected virtual void PackCore(bool value) { }

	// RVA: 0xCF71D4
	protected bool TryPackTinySignedInteger(Int64 value) { }

	// RVA: 0xCF73FC
	protected bool TryPackTinyUnsignedInteger(UInt64 value) { }

	// RVA: 0xCF7438
	public Packer PackNull() { }

	// RVA: 0xCF74BC
	private void PrivatePackNullCore() { }

	// RVA: 0xCF6FCC
	private static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xCF74CC
	private static void ThrowCannotBeNegativeException(string parameterName) { }

	// RVA: 0xCF7594
	private static void ThrowMissingBodyOfExtTypeValueException(string parameterName) { }

	// RVA: 0xCF75F0
	private static void ThrowExtTypeIsProhibitedException() { }

	// RVA: 0xCF7644
	public static Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCF7834
	public static Packer Create(Stream stream, bool ownsStream) { }

	// RVA: 0xCF7754
	public static Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions, bool ownsStream) { }

	// RVA: 0xCF7908
	public static ByteArrayPacker Create(Byte[] buffer, bool allowsBufferExpansion, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCF79E8
	public Packer Pack(System.Nullable<System.SByte> value) { }

	// RVA: 0xCF7B38
	public Packer Pack(System.Nullable<System.Byte> value) { }

	// RVA: 0xCF7C6C
	public Packer Pack(System.Nullable<System.Int16> value) { }

	// RVA: 0xCF7E3C
	public Packer Pack(System.Nullable<System.UInt16> value) { }

	// RVA: 0xCF7FF8
	public Packer Pack(System.Nullable<System.Int32> value) { }

	// RVA: 0xCF81B4
	public Packer Pack(System.Nullable<System.UInt32> value) { }

	// RVA: 0xCF8370
	public Packer Pack(System.Nullable<System.Int64> value) { }

	// RVA: 0xCF8544
	public Packer Pack(System.Nullable<System.UInt64> value) { }

	// RVA: 0xCF8718
	public Packer Pack(System.Nullable<System.Single> value) { }

	// RVA: 0xCF88EC
	public Packer Pack(System.Nullable<System.Double> value) { }

	// RVA: 0xCF8AC0
	public Packer Pack(System.Nullable<System.Boolean> value) { }

	// RVA: 0xCF7DBC
	public Packer Pack(Int16 value) { }

	// RVA: 0xCF8BFC
	protected virtual void PackCore(Int16 value) { }

	// RVA: 0xCF8C78
	protected bool TryPackInt16(Int64 value) { }

	// RVA: 0xCF7F74
	public Packer Pack(UInt16 value) { }

	// RVA: 0xCF8CEC
	protected virtual void PackCore(UInt16 value) { }

	// RVA: 0xCF8D5C
	protected bool TryPackUInt16(UInt64 value) { }

	// RVA: 0xCF8130
	public Packer Pack(int value) { }

	// RVA: 0xCF8DC4
	protected virtual void PackCore(int value) { }

	// RVA: 0xCF8E7C
	protected bool TryPackInt32(Int64 value) { }

	// RVA: 0xCF82EC
	public Packer Pack(UInt32 value) { }

	// RVA: 0xCF8F20
	protected virtual void PackCore(UInt32 value) { }

	// RVA: 0xCF8FD0
	protected bool TryPackUInt32(UInt64 value) { }

	// RVA: 0xCF84C0
	public Packer Pack(Int64 value) { }

	// RVA: 0xCF9068
	protected virtual void PackCore(Int64 value) { }

	// RVA: 0xCF9180
	protected bool TryPackInt64(Int64 value) { }

	// RVA: 0xCF8694
	public Packer Pack(UInt64 value) { }

	// RVA: 0xCF9254
	protected virtual void PackCore(UInt64 value) { }

	// RVA: 0xCF9368
	protected bool TryPackUInt64(UInt64 value) { }

	// RVA: 0xCF8868
	public Packer Pack(float value) { }

	// RVA: 0xCF943C
	protected virtual void PackCore(float value) { }

	// RVA: 0xCF8A3C
	public Packer Pack(Double value) { }

	// RVA: 0xCF94E0
	protected virtual void PackCore(Double value) { }

	// RVA: 0xCF95B8
	public Packer PackArrayHeader(int count) { }

	// RVA: 0xCF96A4
	protected virtual void PackArrayHeaderCore(int count) { }

	// RVA: 0xCF974C
	public Packer PackMapHeader(int count) { }

	// RVA: 0xCF9838
	protected virtual void PackMapHeaderCore(int count) { }

	// RVA: 0xCF98DC
	public Packer PackStringHeader(int length) { }

	// RVA: 0xCF99C8
	public Packer PackBinaryHeader(int length) { }

	// RVA: 0xCF9AD8
	protected virtual void PackStringHeaderCore(int length) { }

	// RVA: 0xCF9BAC
	protected virtual void PackBinaryHeaderCore(int length) { }

	// RVA: 0xCF9C54
	public Packer PackRaw(Byte[] value) { }

	// RVA: 0xCF9D00
	protected virtual void PackRawCore(Byte[] value) { }

	// RVA: 0xCF9D50
	public Packer PackBinary(Byte[] value) { }

	// RVA: 0xCF9E28
	protected virtual void PackBinaryCore(Byte[] value) { }

	// RVA: 0xCF9E78
	public Packer PackString(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xCFA018
	public Packer PackString(string value) { }

	// RVA: 0xCFA070
	protected virtual void PackStringCore(string value, Encoding encoding) { }

	// RVA: 0xCFA1CC
	protected virtual void PackRawCore(string value) { }

	// RVA: 0xCF9F60
	private void PackRawCore(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xCFA20C
	public Packer PackRawBody(Byte[] value) { }

	// RVA: 0xCFA32C
	public Packer PackRawBody(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xCFA444
	private int PrivatePackRawBodyCore(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xCFA7C4
	private int PrivatePackRawBodyCore(System.Collections.Generic.ICollection<System.Byte> value, bool isImmutable) { }

	// RVA: 0xCFA8CC
	public Packer PackExtendedTypeValue(Byte typeCode, Byte[] body) { }

	// RVA: 0xCFAA5C
	public Packer PackExtendedTypeValue(MessagePackExtendedTypeObject mpeto) { }

	// RVA: 0xCFABC8
	protected virtual void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xCFAD08
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

	// RVA: 0x315B3A8
	public static Packer Pack(Packer source, T value) { }

	// RVA: 0x315B3A8
	private static void PackCore(Packer source, T value, SerializationContext context) { }

	// RVA: 0xCFAD5C
	public static Packer PackObject(Packer source, object value) { }

	// RVA: 0xCFAEFC
	public static Packer PackObject(Packer source, object value, SerializationContext context) { }

	// RVA: 0xCFAE24
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

	// RVA: 0xCFAF90
	private static bool ShouldWrapStream(Stream stream) { }

	// RVA: 0xCFB054
	public bool get_WithBuffering() { }

	// RVA: 0xCFB05C
	public void set_WithBuffering(bool value) { }

	// RVA: 0xCFB064
	public bool get_OwnsStream() { }

	// RVA: 0xCFB06C
	public void set_OwnsStream(bool value) { }

	// RVA: 0xCFB074
	public void .ctor() { }

	// RVA: 0xCEC460
	internal Stream WrapStream(Stream stream) { }

	// RVA: 0xCFB084
	private static void .cctor() { }

}

// Namespace: MsgPack
public sealed class PackingOptions
{
	// Fields
	private Encoding _stringEncoding; // 0x10

	// Methods

	// RVA: 0xCFB26C
	public void .ctor() { }

}

// Namespace: MsgPack
internal sealed class PreserveAttribute
{
	// Fields
	public bool AllMembers; // 0x10

	// Methods

	// RVA: 0xCFB340
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

	// RVA: 0xCFBFF4
	private static void .cctor() { }

	// RVA: 0xCFC060
	public void .ctor() { }

	// RVA: 0xCFC068
	internal ReadValueResult <.cctor>b__5_0(int i) { }

	// RVA: 0xCFC070
	internal ReadValueResult <.cctor>b__5_1(int i) { }

	// RVA: 0xCFC080
	internal ReadValueResult <.cctor>b__5_2(int i) { }

	// RVA: 0xCFC090
	internal ReadValueResult <.cctor>b__5_3(int i) { }

	// RVA: 0xCFC09C
	internal ReadValueResult <.cctor>b__5_4(int b) { }

	// RVA: 0xCFC0A4
	internal MessagePackObject <.cctor>b__5_5(int x) { }

	// RVA: 0xCFC0D0
	internal MessagePackObject <.cctor>b__5_6(int x) { }

	// RVA: 0xCFC0FC
	internal MessagePackObject <.cctor>b__5_7(int x) { }

	// RVA: 0xCFC128
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

	// RVA: 0xCF5B28
	public static Byte ToByte(ReadValueResult source) { }

	// RVA: 0xCFB348
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class ReflectionAbstractions
{
	// Fields
	public static readonly Char TypeDelimiter; // 0x0
	public static readonly Type[] EmptyTypes; // 0x8

	// Methods

	// RVA: 0xCFC154
	public static bool GetIsValueType(Type source) { }

	// RVA: 0xCFC16C
	public static bool GetIsEnum(Type source) { }

	// RVA: 0xCFC190
	public static bool GetIsInterface(Type source) { }

	// RVA: 0xCFC1A8
	public static bool GetIsAbstract(Type source) { }

	// RVA: 0xCFC1C0
	public static bool GetIsGenericType(Type source) { }

	// RVA: 0xCFC1E4
	public static bool GetIsGenericTypeDefinition(Type source) { }

	// RVA: 0xCFC208
	public static Assembly GetAssembly(Type source) { }

	// RVA: 0xCFC22C
	public static bool GetIsVisible(Type source) { }

	// RVA: 0xCFC244
	public static bool GetIsNestedPublic(Type source) { }

	// RVA: 0xCFC25C
	public static Type GetBaseType(Type source) { }

	// RVA: 0xCFC280
	public static MethodInfo GetRuntimeMethod(Type source, string name, Type[] parameters) { }

	// RVA: 0xCFC2A8
	public static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetRuntimeMethods(Type source) { }

	// RVA: 0xCFC2D0
	public static Delegate CreateDelegate(MethodInfo source, Type delegateType) { }

	// RVA: 0xCFC2E4
	public static Delegate CreateDelegate(MethodInfo source, Type delegateType, object target) { }

	// RVA: 0xCFC2FC
	public static string GetCultureName(AssemblyName source) { }

	// RVA: 0xCFC32C
	public static bool GetHasDefaultValue(ParameterInfo source) { }

	// RVA: 0xCFC3B4
	private static void .cctor() { }

}

// Namespace: MsgPack
internal sealed class SingleArrayBufferAllocator
{
	// Fields
	public static readonly SingleArrayBufferAllocator Default; // 0x0
	private readonly System.Func<System.Byte[],System.Int32,System.Byte[]> _allocator; // 0x10

	// Methods

	// RVA: 0xCFC43C
	public void .ctor(System.Func<System.Byte[],System.Int32,System.Byte[]> allocator) { }

	// RVA: 0xCFC470
	private static Byte[] Allocate(Byte[] old, int requestSize) { }

	// RVA: 0xCFC588
	public override bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xCFC654
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class StringEscape
{
	// Methods

	// RVA: 0xCFC71C
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

	// RVA: 0xCFCA28
	public override Int64 get_ItemsCount() { }

	// RVA: 0xCFCAF4
	public override bool get_IsArrayHeader() { }

	// RVA: 0xCFCBA4
	public override bool get_IsMapHeader() { }

	// RVA: 0xCFCC54
	public override bool get_IsCollectionHeader() { }

	// RVA: 0xCFCD04
	public override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xCFCDD8
	protected override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCFCEC0
	public override MessagePackObject get_LastReadData() { }

	// RVA: 0xCFCF78
	protected override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCFD038
	public void .ctor(Unpacker parent) { }

	// RVA: 0xCFD040
	private void .ctor(Unpacker root, SubtreeUnpacker parent) { }

	// RVA: 0xCFD36C
	protected override void Dispose(bool disposing) { }

	// RVA: 0xCFD3E8
	public override void Drain() { }

	// RVA: 0xCFD428
	protected internal override void EndReadSubtree() { }

	// RVA: 0xCFD674
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xCFD820
	private static void ThrowInTailException() { }

	// RVA: 0xCFD874
	private static void ThrowNotInHeadOfCollectionException() { }

	// RVA: 0xCFD8C8
	protected override bool ReadCore() { }

	// RVA: 0xCFDB4C
	protected override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xCFD4FC
	private void DiscardCompletedStacks() { }

	// RVA: 0xCFDCAC
	public override bool ReadBoolean(bool result) { }

	// RVA: 0xCFDF80
	public override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xCFE254
	public override bool ReadByte(Byte result) { }

	// RVA: 0xCFE528
	public override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xCFE7FC
	public override bool ReadSByte(SByte result) { }

	// RVA: 0xCFEAD0
	public override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xCFEDA4
	public override bool ReadInt16(Int16 result) { }

	// RVA: 0xCFF078
	public override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xCFF34C
	public override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xCFF620
	public override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xCFF8F4
	public override bool ReadInt32(int result) { }

	// RVA: 0xCFFBC8
	public override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xCFFE9C
	public override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD00170
	public override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD00444
	public override bool ReadInt64(Int64 result) { }

	// RVA: 0xD00718
	public override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD009EC
	public override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD00CC0
	public override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD00F94
	public override bool ReadSingle(float result) { }

	// RVA: 0xD01268
	public override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD0153C
	public override bool ReadDouble(Double result) { }

	// RVA: 0xD01810
	public override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD01AE4
	public override bool ReadBinary(Byte[] result) { }

	// RVA: 0xD01DA8
	public override bool ReadString(string result) { }

	// RVA: 0xD0206C
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

	// RVA: 0xD03EE4
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

	// RVA: 0xD023A4
	public int CompareTo(Timestamp other) { }

	// RVA: 0xD0240C
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xD0257C
	public override bool Equals(object obj) { }

	// RVA: 0xD0265C
	public bool Equals(Timestamp other) { }

	// RVA: 0xD02680
	public override int GetHashCode() { }

	// RVA: 0xD026D4
	private Int64 ToTicks(Type destination) { }

	// RVA: 0xD0286C
	public DateTime ToDateTime() { }

	// RVA: 0xD02944
	public DateTimeOffset ToDateTimeOffset() { }

	// RVA: 0xD02A4C
	public MessagePackExtendedTypeObject Encode() { }

	// RVA: 0xD02CB4
	private static void FromDateTimeTicks(Int64 ticks, Int64 unixEpocSeconds, int nanoSeconds) { }

	// RVA: 0xD02D3C
	private static void FromOffsetTicks(Int64 ticks, Int64 unixEpocSeconds, int nanoSeconds) { }

	// RVA: 0xD02EFC
	public static Timestamp FromDateTime(DateTime value) { }

	// RVA: 0xD03194
	public static Timestamp FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xD03314
	public static Timestamp Decode(MessagePackExtendedTypeObject value) { }

	// RVA: 0xD0350C
	public static Timestamp op_Implicit(DateTimeOffset value) { }

	// RVA: 0xD03108
	public void .ctor(Int64 unixEpochSeconds, int nanoseconds) { }

	// RVA: 0xD02E80
	internal static Int64 DivRem(Int64 dividend, Int64 divisor, Int64 remainder) { }

	// RVA: 0xD03598
	public int get_Hour() { }

	// RVA: 0xD036F4
	public int get_Minute() { }

	// RVA: 0xD03850
	public int get_Second() { }

	// RVA: 0xD03888
	private void GetDatePart(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD03BE4
	private void GetDatePartAD(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD03964
	private void GetDatePartBC(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD03E10
	public override string ToString() { }

	// RVA: 0xD03E98
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xD04194
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class TimestampStringConverter
{
	// Methods

	// RVA: 0xD0405C
	public static string ToString(string format, IFormatProvider formatProvider, Value value) { }

	// RVA: 0xD0439C
	private static string ToIso8601String(IFormatProvider formatProvider, bool containsNanosecons, Value value) { }

}

// Namespace: MsgPack
[Serializable]
public sealed class UnassignedMessageTypeException
{
	// Methods

	// RVA: 0xD045E8
	public void .ctor() { }

	// RVA: 0xD04644
	public void .ctor(string message) { }

	// RVA: 0xD046AC
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xD04720
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

	// RVA: 0xD050C4
	public void .ctor(int <>1__state) { }

	// RVA: 0xD07614
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD07618
	private bool MoveNext() { }

	// RVA: 0xD07700
	private MessagePackObject System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject>.get_Current() { }

	// RVA: 0xD0770C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xD0774C
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

	// RVA: 0xD04728
	public virtual MessagePackObject get_LastReadData() { }

	// RVA: 0xD04820
	protected virtual void set_LastReadData(MessagePackObject value) { }

	// RVA: -1
	public abstract bool get_IsArrayHeader() { }

	// RVA: -1
	public abstract bool get_IsMapHeader() { }

	// RVA: 0xD048C8
	public virtual bool get_IsCollectionHeader() { }

	// RVA: -1
	public abstract Int64 get_ItemsCount() { }

	// RVA: 0xD04910
	internal void VerifyMode(UnpackerMode mode) { }

	// RVA: 0xD0495C
	internal void VerifyIsNotDisposed() { }

	// RVA: 0xD04ACC
	private void ThrowObjectDisposedException() { }

	// RVA: 0xD049E0
	internal void ThrowInvalidModeException() { }

	// RVA: 0xD04B38
	internal virtual bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xD04B48
	public static Unpacker Create(Stream stream, bool ownsStream) { }

	// RVA: 0xD04C2C
	public static Unpacker Create(Stream stream, PackerUnpackerStreamOptions streamOptions, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD04CD4
	public static ByteArrayUnpacker Create(Byte[] source, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD04D68
	public static ByteArrayUnpacker Create(Byte[] source, int startOffset, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD04E10
	protected void .ctor() { }

	// RVA: 0xD04E18
	public void Dispose() { }

	// RVA: 0xD04EAC
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD04EB0
	public virtual void Drain() { }

	// RVA: 0xD04EB4
	public Unpacker ReadSubtree() { }

	// RVA: 0xD04EC4
	internal virtual Unpacker InternalReadSubtree() { }

	// RVA: 0xD04ED4
	internal static void ThrowCannotBeSubtreeModeException() { }

	// RVA: 0xD04F28
	internal static void ThrowInSubtreeModeException() { }

	// RVA: -1
	protected abstract Unpacker ReadSubtreeCore() { }

	// RVA: 0xD04F7C
	protected internal virtual void EndReadSubtree() { }

	// RVA: 0xD04F8C
	public bool Read() { }

	// RVA: 0xD04FF4
	internal bool ReadInternal() { }

	// RVA: 0xD05048
	internal virtual void EnsureNotInSubtreeMode() { }

	// RVA: 0xD04F84
	private void SetStable() { }

	// RVA: -1
	protected abstract bool ReadCore() { }

	// RVA: 0xD0504C
	public System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> GetEnumerator() { }

	// RVA: 0xD050F0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD05168
	public System.Nullable<System.Int64> Skip() { }

	// RVA: 0xD05240
	private void BeginSkip() { }

	// RVA: 0xD0527C
	private void EndSkip(System.Nullable<System.Int64> result) { }

	// RVA: -1
	protected abstract System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD0530C
	public MessagePackObject ReadItemData() { }

	// RVA: 0xD05450
	internal virtual void ThrowEofException() { }

	// RVA: 0xD053E4
	public MessagePackObject UnpackSubtreeData() { }

	// RVA: 0xD054A4
	internal bool UnpackSubtreeDataCore(MessagePackObject result) { }

	// RVA: 0xD05A20
	public virtual bool ReadBoolean(bool result) { }

	// RVA: 0xD05AFC
	public virtual bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD05C54
	public virtual bool ReadByte(Byte result) { }

	// RVA: 0xD05D30
	public virtual bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD05E88
	public virtual bool ReadSByte(SByte result) { }

	// RVA: 0xD05F64
	public virtual bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD060BC
	public virtual bool ReadInt16(Int16 result) { }

	// RVA: 0xD06198
	public virtual bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD0630C
	public virtual bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD063E8
	public virtual bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD0655C
	public virtual bool ReadInt32(int result) { }

	// RVA: 0xD06638
	public virtual bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD067B0
	public virtual bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD0688C
	public virtual bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD06A04
	public virtual bool ReadInt64(Int64 result) { }

	// RVA: 0xD06AE8
	public virtual bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD06C64
	public virtual bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD06D48
	public virtual bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD06EC4
	public virtual bool ReadSingle(float result) { }

	// RVA: 0xD06FA4
	public virtual bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD0711C
	public virtual bool ReadDouble(Double result) { }

	// RVA: 0xD071FC
	public virtual bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD07378
	public virtual bool ReadBinary(Byte[] result) { }

	// RVA: 0xD07470
	public virtual bool ReadString(string result) { }

	// RVA: 0xD07568
	public virtual bool ReadObject(MessagePackObject result) { }

}

// Namespace: MsgPack
internal sealed class FastStreamUnpacker
{
	// Methods

	// RVA: 0xD04CCC
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD077B4
	protected override Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingStreamUnpacker
{
	// Fields
	private bool _isSubtreeReading; // 0x60

	// Methods

	// RVA: 0xD04CC4
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD077DC
	internal override Unpacker InternalReadSubtree() { }

	// RVA: 0xD078C4
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD0792C
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD07938
	internal override void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
internal sealed class FastByteArrayUnpacker
{
	// Methods

	// RVA: 0xD04E08
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xD079C8
	protected override Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingByteArrayUnpacker
{
	// Fields
	private bool _isSubtreeReading; // 0x48

	// Methods

	// RVA: 0xD04E00
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xD079CC
	internal override Unpacker InternalReadSubtree() { }

	// RVA: 0xD07AB4
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD07B1C
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD07B28
	internal override void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
public sealed class UnpackerOptions
{
	// Fields
	private UnpackerValidationLevel <ValidationLevel>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD07BB8
	public UnpackerValidationLevel get_ValidationLevel() { }

	// RVA: 0xD07BC0
	public void set_ValidationLevel(UnpackerValidationLevel value) { }

	// RVA: 0xD07BC8
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

	// RVA: 0xD07BF4
	public static int Read(int field) { }

	// RVA: 0xD07BFC
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

	// RVA: 0xD07C04
	public CollectionKind get_CollectionType() { }

	// RVA: 0xD07CB0
	public void .ctor(CollectionDetailedKind type, Type elementType, MethodInfo getEnumeratorMethod, MethodInfo addMethod, MethodInfo countPropertyGetter) { }

	// RVA: 0xD07D1C
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

	// RVA: 0xD07E6C
	public string get_Name() { }

	// RVA: 0xD07E74
	public int get_Id() { }

	// RVA: 0xD07E7C
	public NilImplication get_NilImplication() { }

	// RVA: 0xD07E84
	public void .ctor() { }

	// RVA: 0xD07EC0
	public void .ctor(MemberInfo member) { }

	// RVA: 0xD07F18
	public void .ctor(MemberInfo member, string name, NilImplication nilImplication, System.Nullable<System.Int32> id) { }

	// RVA: 0xD08288
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

	// RVA: 0xD0830C
	public static DateTimeConversionMethod DetermineDateTimeConversionMethod(SerializationContext context, DateTimeMemberConversionMethod dateTimeMemberConversionMethod) { }

	// RVA: 0xD08390
	internal static bool IsDateTime(Type dateTimeType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DefaultConcreteTypeRepository
{
	// Fields
	private readonly TypeKeyRepository _defaultCollectionTypes; // 0x10

	// Methods

	// RVA: 0xD08554
	internal void .ctor() { }

	// RVA: 0xD08A88
	public Type Get(Type abstractCollectionType) { }

	// RVA: 0xD08BE4
	internal Type GetConcreteType(Type abstractCollectionType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DictionarySerlaizationOptions
{
	// Fields
	private bool _omitNullEntry; // 0x10
	private System.Func<System.String,System.String> _keyNameHandler; // 0x18

	// Methods

	// RVA: 0xD08CF0
	public bool get_OmitNullEntry() { }

	// RVA: 0xD08D14
	public System.Func<System.String,System.String> get_KeyTransformer() { }

	// RVA: 0xD08D38
	internal System.Func<System.String,System.String> get_SafeKeyTransformer() { }

	// RVA: 0xD08DDC
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

	// RVA: 0xD08DE4
	protected void .ctor(SerializationContext ownerContext, Type targetType, EnumSerializationMethod serializationMethod) { }

	// RVA: 0xD09460
	protected internal sealed override void PackToCore(Packer packer, object objectTree) { }

	// RVA: -1
	protected internal abstract void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xD09544
	protected internal sealed override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected internal abstract object UnpackFromUnderlyingValue(MessagePackObject messagePackObject) { }

	// RVA: 0xD09A10
	private ICustomizableEnumSerializer MsgPack.Serialization.ICustomizableEnumSerializer.GetCopyAs(EnumSerializationMethod method) { }

}

// Namespace: MsgPack.Serialization
public static class EnumMessagePackSerializerHelpers
{
	// Methods

	// RVA: 0xD09AB8
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

	// RVA: 0xD09C7C
	public void .ctor(Type enumType, ICustomizableEnumSerializer serializer) { }

	// RVA: 0xD09DD0
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

	// RVA: 0xD09C70
	public EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xD09EA4
	public System.Func<System.String,System.String> get_NameTransformer() { }

	// RVA: 0xD093BC
	internal System.Func<System.String,System.String> get_SafeNameTransformer() { }

	// RVA: 0xD09EC8
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

	// RVA: 0xD09ED0
	public Byte get_Item(string name) { }

	// RVA: 0xD0A1C8
	internal void .ctor() { }

	// RVA: 0xD0A510
	public bool Add(string name, Byte typeCode) { }

	// RVA: 0xD0A338
	private bool AddInternal(string name, Byte typeCode) { }

	// RVA: 0xD0A620
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Byte>> GetEnumerator() { }

	// RVA: 0xD0A754
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD0A0B8
	private static void ValidateName(string name) { }

	// RVA: 0xD0A5B0
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

	// RVA: 0xD0A82C
	private static void .cctor() { }

	// RVA: 0xD0A898
	public void .ctor() { }

	// RVA: 0xD0A8A0
	internal string <.cctor>b__3_0(string key) { }

}

// Namespace: MsgPack.Serialization
internal static class KeyNameTransformers
{
	// Fields
	public static readonly System.Func<System.String,System.String> AsIs; // 0x0

	// Methods

	// RVA: 0xD0A758
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class LazyDelegatingMessagePackSerializer<T0>
{
	// Fields
	private readonly object _providerParameter; // 0x0
	private MsgPack.Serialization.MessagePackSerializer<T> _delegated; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(SerializationContext ownerContext, object providerParameter) { }

	// RVA: 0x30A17DC
	private MsgPack.Serialization.MessagePackSerializer<T> GetDelegatedSerializer() { }

	// RVA: 0x315B3A8
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x315B3A8
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x315B3A8
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x30A17DC
	public override string ToString() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackDateTimeMemberAttribute
{
	// Fields
	private DateTimeMemberConversionMethod <DateTimeConversionMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD0A8A8
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

	// RVA: 0xD0A8B0
	public EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xD0A8B8
	public void set_SerializationMethod(EnumSerializationMethod value) { }

	// RVA: 0xD0A8C0
	public void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackEnumMemberAttribute
{
	// Fields
	private EnumMemberSerializationMethod <SerializationMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD0A8C8
	public EnumMemberSerializationMethod get_SerializationMethod() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackIgnoreAttribute
{
	// Methods

	// RVA: 0xD0A8D0
	public void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD0A8D8
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD0A8E0
	public string get_TypeCode() { }

	// RVA: 0xD0A8E8
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownCollectionItemTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD0A8F0
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD0A8F8
	public string get_TypeCode() { }

	// RVA: 0xD0A900
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownDictionaryKeyTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD0A908
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD0A910
	public string get_TypeCode() { }

	// RVA: 0xD0A918
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTupleItemTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD0A920
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD0A928
	public string get_TypeCode() { }

	// RVA: 0xD0A930
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

	// RVA: 0xD0A938
	public int get_Id() { }

	// RVA: 0xD0A940
	public string get_Name() { }

	// RVA: 0xD0A948
	public NilImplication get_NilImplication() { }

	// RVA: 0xD0A950
	public void .ctor(int id) { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD0A97C
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD0A984
	public Type get_VerifierType() { }

	// RVA: 0xD0A98C
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeCollectionItemTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD0A994
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD0A99C
	public Type get_VerifierType() { }

	// RVA: 0xD0A9A4
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeDictionaryKeyTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD0A9AC
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD0A9B4
	public Type get_VerifierType() { }

	// RVA: 0xD0A9BC
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTupleItemTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD0A9C4
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD0A9CC
	public Type get_VerifierType() { }

	// RVA: 0xD0A9D4
	public string get_VerifierMethodName() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.Serialization.MessagePackSerializer.<>c <>9; // 0x0

	// Methods

	// RVA: 0xD0AF50
	private static void .cctor() { }

	// RVA: 0xD0AFBC
	public void .ctor() { }

	// RVA: 0xD0AFC4
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

	// RVA: 0xD0A9DC
	protected internal SerializationContext get_OwnerContext() { }

	// RVA: 0xD0A9E4
	protected internal PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xD0AA7C
	internal void .ctor(SerializationContext ownerContext, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xD0ABAC
	public void PackTo(Packer packer, object objectTree) { }

	// RVA: -1
	internal abstract void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0xD0ABB8
	public object UnpackFrom(Unpacker unpacker) { }

	// RVA: -1
	internal abstract object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0xD0ABC4
	public void UnpackTo(Unpacker unpacker, object collection) { }

	// RVA: -1
	internal abstract void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xD0AB64
	internal static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0x30A5298
	public static MsgPack.Serialization.MessagePackSerializer<T> Get() { }

	// RVA: 0x30A52D0
	public static MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x30A53B0
	public static MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0x30A53B0
	internal static MsgPack.Serialization.MessagePackSerializer<T> CreateInternal(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0x30A550C
	internal static MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionInternal(SerializationContext context, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD0ABD0
	private static void ValidateType(Type type) { }

	// RVA: 0x30A53B0
	internal static MsgPack.Serialization.MessagePackSerializer<T> Wrap(SerializationContext context, MessagePackSerializer nonGeneric) { }

	// RVA: 0x30A6D04
	public static void PrepareType() { }

	// RVA: 0x30A6D04
	public static void PrepareDictionaryType() { }

	// RVA: 0x30A6D04
	public static void PrepareCollectionType() { }

	// RVA: 0x30A7C50
	private static void PrepareTypeCore(SerializationContext dummyContext) { }

	// RVA: 0xD0AD08
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
public abstract class MessagePackSerializer<T0>
{
	// Fields
	private static readonly bool IsNullable; // 0x0

	// Methods

	// RVA: 0x30A27C0
	protected void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x30A2828
	protected void .ctor(SerializationContext ownerContext, SerializerCapabilities capabilities) { }

	// RVA: -1
	private static bool JudgeNullable() { }

	// RVA: 0x30A3FD0
	private static SerializerCapabilities InferCapatibity() { }

	// RVA: 0x315B3A8
	public void Pack(Stream stream, T objectTree) { }

	// RVA: 0x315B3A8
	public T Unpack(Stream stream) { }

	// RVA: 0x315B3A8
	public void PackTo(Packer packer, T objectTree) { }

	// RVA: -1
	protected internal abstract void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x315B3A8
	public T UnpackFrom(Unpacker unpacker) { }

	// RVA: 0x315B3A8
	protected internal virtual T UnpackNil() { }

	// RVA: -1
	protected internal abstract T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x315B3A8
	public void UnpackTo(Unpacker unpacker, T collection) { }

	// RVA: 0x315B3A8
	protected internal virtual void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x315B3A8
	public Byte[] PackSingleObject(T objectTree) { }

	// RVA: 0x315B3A8
	public System.ArraySegment<System.Byte> PackSingleObjectAsBytes(T objectTree) { }

	// RVA: 0x315B3A8
	public T UnpackSingleObject(Byte[] buffer) { }

	// RVA: 0x30A2A20
	internal sealed override void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0x30A188C
	internal sealed override object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x30A2A20
	internal sealed override void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0x30A8E44
	private static void ThrowArgumentException(string message, string parameterName) { }

	// RVA: 0x30A6D04
	private static void ThrowNewValueTypeCannotBeNullException() { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal abstract class MessagePackSerializerProvider
{
	// Methods

	// RVA: 0xD09DC8
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

	// RVA: 0x315B3A8
	public TAction OnPacking(TPackingParameter parameter, NilImplication nilImplication) { }

	// RVA: -1
	protected abstract TCondition OnPackingMessagePackObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TCondition OnPackingReferenceTypeObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TCondition OnPackingNullableValueTypeObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnPackingCore(TPackingParameter parameter, TCondition condition) { }

	// RVA: 0x315B3A8
	public TAction OnUnpacked(TUnpackedParameter parameter, NilImplication nilImplication) { }

	// RVA: -1
	protected abstract TAction OnNopOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnThrowNullIsProhibitedExceptionOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnThrowValueTypeCannotBeNull3OnUnpacked(TUnpackedParameter parameter) { }

	// RVA: 0x30A2378
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

	// RVA: 0xD0B2E0
	internal void .ctor(string loadingTypeFullName, AssemblyName loadingAssemblyName, string loadingAssemblyFullName) { }

	// RVA: 0xD0B330
	public override string ToString() { }

	// RVA: 0xD0B3B4
	public override bool Equals(object obj) { }

	// RVA: 0xD0B454
	public bool Equals(PolymorphicTypeVerificationContext other) { }

	// RVA: 0xD0B4A0
	public override int GetHashCode() { }

}

// Namespace: 
private sealed class ReadOnlyDictionary<T0, T1>
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<TKey,TValue> _underlying; // 0x0

	// Methods

	// RVA: 0x30A17DC
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x315B3A8
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }

	// RVA: 0x315B3A8
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }

	// RVA: 0x30A14A4
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Count() { }

	// RVA: 0x30A1224
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x30A27C0
	public void .ctor(System.Collections.Generic.IDictionary<TKey,TValue> underlying) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.ContainsKey(TKey key) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.TryGetValue(TKey key, TValue value) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30A2828
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x30A17DC
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x30A17DC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x315B3A8
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	// RVA: 0x315B3A8
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	// RVA: 0x315B3A8
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30A2378
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }

	// RVA: 0x315B3A8
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

	// RVA: 0xD0ED28
	private void .ctor(TypeTableEntry member, TypeTableEntry collectionItem, TypeTableEntry dictionaryKey) { }

	// RVA: 0xD0D224
	public static TypeTable Create(MemberInfo member, PolymorphismSchema defaultSchema) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public PolymorphismTarget targetType; // 0x10
	public System.Func<MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xD0F2C8
	public void .ctor() { }

	// RVA: 0xD10FFC
	internal bool <Create>b__0(IPolymorphicHelperAttribute a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public IPolymorphicRuntimeTypeAttribute attribute; // 0x10

	// Methods

	// RVA: 0xD10E68
	public void .ctor() { }

	// RVA: 0xD110B8
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

	// RVA: 0xD0F224
	public System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xD0DF58
	public PolymorphismType get_PolymorphismType() { }

	// RVA: 0xD0DEE0
	public bool get_Exists() { }

	// RVA: 0xD0F22C
	public System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xD0F234
	private void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xD0F23C
	private void .ctor() { }

	// RVA: 0xD0ED78
	public static TypeTableEntry Create(MemberInfo member, PolymorphismTarget targetType, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD0F2D0
	private void Interpret(IPolymorphicHelperAttribute attribute, string memberName, int tupleItemNumber) { }

	// RVA: 0xD0F6A0
	private void SetDefault(PolymorphismTarget target, string memberName, int tupleItemNumber, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD0FB34
	private void SetKnownType(PolymorphismTarget target, string memberName, int tupleItemNumber, string typeCode, Type bindingType) { }

	// RVA: 0xD102B4
	private void SetRuntimeType(PolymorphismTarget target, string memberName, int tupleItemNumber, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD103C0
	private static string GetCannotSpecifyKnownTypeAndRuntimeTypeErrorMessage(PolymorphismTarget target, string memberName, System.Nullable<System.Int32> tupleItemNumber) { }

	// RVA: 0xD10A28
	private static string GetCannotDuplicateKnownTypeCodeErrorMessage(PolymorphismTarget target, string typeCode, string memberName, int tupleItemNumber) { }

	// RVA: 0xD0FD08
	private static System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> GetVerifier(IPolymorphicRuntimeTypeAttribute attribute) { }

	// RVA: 0xD10E70
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

	// RVA: 0xD11178
	private static void .cctor() { }

	// RVA: 0xD111E4
	public void .ctor() { }

	// RVA: 0xD111EC
	internal PolymorphismSchema <.ctor>b__3_0(PolymorphismSchema x) { }

	// RVA: 0xD11280
	internal PolymorphismSchema <.ctor>b__4_0(PolymorphismSchema x) { }

	// RVA: 0xD11314
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

	// RVA: 0xD0B4F0
	private void .ctor() { }

	// RVA: 0xD0B664
	private void .ctor(Type targetType, PolymorphismType polymorphismType, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xD0B9FC
	private void .ctor(Type targetType, PolymorphismType polymorphismType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xD0B8CC
	private void .ctor(Type targetType, PolymorphismType polymorphismType, MsgPack.Serialization.PolymorphismSchema.ReadOnlyDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, System.Collections.ObjectModel.ReadOnlyCollection<MsgPack.Serialization.PolymorphismSchema> childItemSchemaList) { }

	// RVA: 0xD0BC5C
	public static PolymorphismSchema ForPolymorphicObject(Type targetType) { }

	// RVA: 0xD0BD10
	public static PolymorphismSchema ForPolymorphicObject(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping) { }

	// RVA: 0xD0BDD4
	public static PolymorphismSchema ForContextSpecifiedCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xD0BEE4
	public static PolymorphismSchema ForPolymorphicCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xD0BFF4
	public static PolymorphismSchema ForPolymorphicCollection(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema itemSchema) { }

	// RVA: 0xD0C10C
	public static PolymorphismSchema ForContextSpecifiedDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD0C248
	public static PolymorphismSchema ForPolymorphicDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD0C384
	public static PolymorphismSchema ForPolymorphicDictionary(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD0C4C8
	internal PolymorphismSchema FilterSelf() { }

	// RVA: 0xD0C598
	internal Type get_TargetType() { }

	// RVA: 0xD0C5A0
	private void set_TargetType(Type value) { }

	// RVA: 0xD0C5A8
	internal PolymorphismType get_PolymorphismType() { }

	// RVA: 0xD0C5B0
	private void set_PolymorphismType(PolymorphismType value) { }

	// RVA: 0xD0C5B8
	internal System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xD0C5C0
	internal bool get_UseDefault() { }

	// RVA: 0xD0C5D0
	internal bool get_UseTypeEmbedding() { }

	// RVA: 0xD0C5E0
	internal System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xD0C5E8
	private void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xD0C5F0
	internal PolymorphismSchemaChildrenType get_ChildrenType() { }

	// RVA: 0xD0C5F8
	private void set_ChildrenType(PolymorphismSchemaChildrenType value) { }

	// RVA: 0xD0C600
	internal PolymorphismSchema get_ItemSchema() { }

	// RVA: 0xD0C6E8
	private PolymorphismSchema TryGetItemSchema() { }

	// RVA: 0xD0C798
	internal PolymorphismSchema get_KeySchema() { }

	// RVA: 0xD0C850
	private PolymorphismSchema TryGetKeySchema() { }

	// RVA: 0xD0C8D0
	internal static PolymorphismSchema Create(Type type, SerializingMember memberMayBeNull) { }

	// RVA: 0xD0CA28
	private static PolymorphismSchema CreateCore(MemberInfo member, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD0DFD0
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

	// RVA: 0xD13FD4
	private static void .cctor() { }

	// RVA: 0xD14040
	public void .ctor() { }

	// RVA: 0xD14048
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_0(Type interface) { }

	// RVA: 0xD14150
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_1(Type i) { }

	// RVA: 0xD141D8
	internal Type <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_2(Type i) { }

	// RVA: 0xD14204
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_3(Type i) { }

	// RVA: 0xD1428C
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_4(Type i) { }

	// RVA: 0xD14314
	internal Type <FindInterfaceMethod>b__7_2(ParameterInfo p) { }

	// RVA: 0xD1433C
	internal bool <GetIsPublic>b__15_0(MethodInfo a) { }

	// RVA: 0xD143E4
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

	// RVA: 0xD133E4
	public void .ctor() { }

	// RVA: 0xD14400
	internal bool <FindInterfaceMethod>b__0(Type type, object _) { }

	// RVA: 0xD14410
	internal bool <FindInterfaceMethod>b__1(MethodInfo method) { }

}

// Namespace: MsgPack.Serialization
internal static class ReflectionExtensions
{
	// Fields
	private static readonly Type[] ExceptionConstructorWithInnerParameterTypes; // 0x0
	private static readonly Type[] ObjectAddParameterTypes; // 0x8

	// Methods

	// RVA: 0xD0D5CC
	internal static CollectionTraits GetCollectionTraits(Type source, CollectionTraitOptions options, bool allowNonCollectionEnumerableTypes) { }

	// RVA: 0xD12B18
	private static bool TryCreateCollectionTraitsForIEnumerableT(Type source, GenericCollectionTypes genericTypes, CollectionTraitOptions options, MethodInfo getMethod, CollectionTraits result) { }

	// RVA: 0xD1131C
	private static bool TryCreateCollectionTraitsForHasGetEnumeratorType(Type source, CollectionTraitOptions options, MethodInfo getEnumerator, CollectionTraits result) { }

	// RVA: 0xD11D00
	private static bool TryCreateGenericCollectionTraits(Type source, Type type, CollectionTraitOptions options, CollectionTraits result) { }

	// RVA: 0xD121C0
	private static bool DetermineCollectionInterfaces(Type type, GenericCollectionTypes genericTypes, Type idictionary, Type ilist, Type icollection, Type ienumerable) { }

	// RVA: 0xD12588
	private static MethodInfo GetGetEnumeratorMethodFromElementType(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xD12CE8
	private static MethodInfo GetGetEnumeratorMethodFromEnumerableType(Type targetType, Type enumerableType, CollectionTraitOptions options) { }

	// RVA: 0xD13168
	private static MethodInfo FindInterfaceMethod(Type targetType, Type interfaceType, string name, Type[] parameterTypes) { }

	// RVA: 0xD12DA4
	private static MethodInfo GetAddMethod(Type targetType, Type argumentType, CollectionTraitOptions options) { }

	// RVA: 0xD128B8
	private static MethodInfo GetCountGetterMethod(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xD1271C
	private static MethodInfo GetAddMethod(Type targetType, Type keyType, Type valueType, CollectionTraitOptions options) { }

	// RVA: 0xD11BA4
	private static bool FilterCollectionType(Type type, object filterCriteria) { }

	// RVA: 0xD13060
	private static bool IsIEnumeratorT(Type interface) { }

	// RVA: 0xD133EC
	public static bool GetHasPublicGetter(MemberInfo source) { }

	// RVA: 0xD13530
	public static bool GetIsPublic(MemberInfo source) { }

	// RVA: 0xD0B1A4
	public static Type[] GetParameterTypes(MethodBase source) { }

	// RVA: 0xD0D33C
	public static Type GetMemberValueType(MemberInfo source) { }

	// RVA: 0xD138B4
	public static object InvokePreservingExceptionType(ConstructorInfo source, object[] parameters) { }

	// RVA: 0xD13C18
	public static object InvokePreservingExceptionType(MethodInfo source, object instance, object[] parameters) { }

	// RVA: 0x315B3A8
	public static T CreateInstancePreservingExceptionType(Type instanceType, object[] constructorParameters) { }

	// RVA: 0xD13D04
	public static object CreateInstancePreservingExceptionType(Type type, object[] constructorParameters) { }

	// RVA: 0xD139A0
	private static Exception HoistUpInnerException(TargetInvocationException targetInvocationException) { }

	// RVA: 0xD13DE0
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

	// RVA: 0xD1459C
	private void set_Context(SerializationContext value) { }

	// RVA: 0xD145A4
	private void set_TargetType(Type value) { }

	// RVA: 0xD145AC
	private void set_PolymorphismSchema(PolymorphismSchema value) { }

	// RVA: 0x30A17DC
	internal MsgPack.Serialization.MessagePackSerializer<T> GetFoundSerializer() { }

	// RVA: 0xD145B4
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

	// RVA: 0xD14690
	public bool get_OneBoundDataMemberOrder() { }

	// RVA: 0xD0AA70
	public PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xD146B4
	public void set_PackerCompatibilityOptions(PackerCompatibilityOptions value) { }

	// RVA: 0xD146C0
	public void set_IgnorePackabilityForCollection(bool value) { }

	// RVA: 0xD146E8
	public bool get_AllowNonCollectionEnumerableTypes() { }

	// RVA: 0xD1470C
	public void set_AllowNonCollectionEnumerableTypes(bool value) { }

	// RVA: 0xD14734
	public bool get_AllowAsymmetricSerializer() { }

	// RVA: 0xD14758
	public void set_AllowAsymmetricSerializer(bool value) { }

	// RVA: 0xD14780
	internal void .ctor() { }

}

// Namespace: 
private sealed class SerializerGetter
{
	// Fields
	public static readonly SerializerGetter Instance; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Reflection.MethodInfo> _cache; // 0x10

	// Methods

	// RVA: 0xD15ADC
	private void .ctor() { }

	// RVA: 0xD1515C
	public MessagePackSerializer Get(SerializationContext context, Type targetType, object providerParameter) { }

	// RVA: 0xD15B68
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

	// RVA: 0xD147D0
	public static SerializationContext get_Default() { }

	// RVA: 0xD148CC
	public SerializerRepository get_Serializers() { }

	// RVA: 0xD148D4
	public SerializerOptions get_SerializerOptions() { }

	// RVA: 0xD148DC
	public SerializationCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xD148E4
	public DictionarySerlaizationOptions get_DictionarySerlaizationOptions() { }

	// RVA: 0xD148EC
	public SerializationMethod get_SerializationMethod() { }

	// RVA: 0xD148F8
	public EnumSerializationOptions get_EnumSerializationOptions() { }

	// RVA: 0xD14900
	public DefaultConcreteTypeRepository get_DefaultCollectionTypes() { }

	// RVA: 0xD08384
	public DateTimeConversionMethod get_DefaultDateTimeConversionMethod() { }

	// RVA: 0x30A188C
	private MsgPack.Serialization.MessagePackSerializer<T> OnResolveSerializer(PolymorphismSchema schema) { }

	// RVA: 0xD0AF48
	public void .ctor() { }

	// RVA: 0xD14908
	public void .ctor(PackerCompatibilityOptions packerCompatibilityOptions) { }

	// RVA: 0x30A17DC
	public MsgPack.Serialization.MessagePackSerializer<T> GetSerializer() { }

	// RVA: 0x30A188C
	public MsgPack.Serialization.MessagePackSerializer<T> GetSerializer(object providerParameter) { }

	// RVA: 0xD14D94
	private Type EnsureConcreteTypeRegistered(Type mayBeAbstractType) { }

	// RVA: 0x30A188C
	private MsgPack.Serialization.MessagePackSerializer<T> GetSerializerWithoutGeneration(PolymorphismSchema schema) { }

	// RVA: 0xD14FDC
	public MessagePackSerializer GetSerializer(Type targetType) { }

	// RVA: 0xD14FE4
	public MessagePackSerializer GetSerializer(Type targetType, object providerParameter) { }

	// RVA: 0xD158E0
	public ExtTypeCodeMapping get_ExtTypeCodeMapping() { }

	// RVA: 0xD158E8
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
public static class SerializationExceptions
{
	// Methods

	// RVA: 0xD15C48
	public static Exception NewValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xD15DF0
	public static void ThrowValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xD15E1C
	public static Exception NewValueTypeCannotBeNull(Type type) { }

	// RVA: 0xD15F54
	public static void ThrowMissingItem(int index, Unpacker unpacker) { }

	// RVA: 0xD15F68
	public static void ThrowMissingItem(int index, string name, Unpacker unpacker) { }

	// RVA: 0xD163A4
	internal static void ThrowMissingKey(int index, Unpacker unpacker) { }

	// RVA: 0xD165F0
	internal static Exception NewTargetDoesNotHavePublicDefaultConstructor(Type type) { }

	// RVA: 0xD16728
	internal static Exception NewTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xD16860
	internal static void ThrowTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xD1688C
	public static Exception NewMissingProperty(string name) { }

	// RVA: 0xD169C4
	internal static void ThrowMissingProperty(string name) { }

	// RVA: 0xD169F0
	internal static void ThrowUnexpectedEndOfStream(Unpacker unpacker) { }

	// RVA: 0xD16B9C
	public static void ThrowIsNotArrayHeader(Unpacker unpacker) { }

	// RVA: 0xD16D3C
	public static void ThrowIsNotMapHeader(Unpacker unpacker) { }

	// RVA: 0xD14EA4
	public static Exception NewNotSupportedBecauseCannotInstanciateAbstractType(Type type) { }

	// RVA: 0xD16EDC
	public static Exception NewIsIncorrectStream(Exception innerException) { }

	// RVA: 0xD16F5C
	internal static void ThrowIsIncorrectStream(Exception innerException) { }

	// RVA: 0xD16F88
	public static Exception NewIsTooLargeCollection() { }

	// RVA: 0xD17000
	internal static void ThrowIsTooLargeCollection() { }

	// RVA: 0xD1702C
	public static Exception NewNullIsProhibited(string memberName) { }

	// RVA: 0xD17164
	public static void ThrowNullIsProhibited(string memberName) { }

	// RVA: 0xD17190
	public static Exception NewReadOnlyMemberItemsMustNotBeNull(string memberName) { }

	// RVA: 0xD172C8
	public static Exception NewUnpackFromIsNotSupported(Type targetType) { }

	// RVA: 0xD17400
	public static Exception NewCreateInstanceIsNotSupported(Type targetType) { }

	// RVA: 0xD17538
	internal static Exception NewUnpackToIsNotSupported(Type type, Exception inner) { }

	// RVA: 0xD17678
	internal static Exception NewValueTypeCannotBePolymorphic(Type type) { }

	// RVA: 0xD177B0
	internal static Exception NewUnknownTypeEmbedding() { }

	// RVA: 0xD17828
	internal static Exception NewIncompatibleCollectionSerializer(Type targetType, Type incompatibleType, Type exampleClass) { }

	// RVA: 0xD17A98
	internal static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xD17AE0
	internal static void ThrowSerializationException(string message) { }

	// RVA: 0xD17B28
	internal static void ThrowSerializationException(string message, Exception innerException) { }

	// RVA: 0xD17B7C
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

	// RVA: 0xD1CEEC
	private void .ctor() { }

	// RVA: 0xD1CF40
	public override bool Equals(System.Collections.Generic.KeyValuePair<System.String,System.Type> x, System.Collections.Generic.KeyValuePair<System.String,System.Type> y) { }

	// RVA: 0xD1D1C0
	public override int GetHashCode(System.Collections.Generic.KeyValuePair<System.String,System.Type> obj) { }

	// RVA: 0xD1D4F8
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

	// RVA: 0xD1D598
	private static void .cctor() { }

	// RVA: 0xD1D604
	public void .ctor() { }

	// RVA: 0xD1D60C
	internal System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_0(ParameterInfo p) { }

	// RVA: 0xD1D6A8
	internal System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_1(SerializingMember m) { }

	// RVA: 0xD1D768
	internal string <FindCorrespondingMemberNames>b__26_2(ParameterInfo p, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> ms) { }

	// RVA: 0xD1D7F4
	internal string <ThrowAmbigiousMatchException>b__28_0(SerializingMember x) { }

	// RVA: 0xD1D81C
	internal int <Prepare>b__32_0(SerializingMember entry) { }

	// RVA: 0xD1D840
	internal bool <Prepare>b__32_2(SerializingMember item) { }

	// RVA: 0xD1D86C
	internal string <Prepare>b__32_3(SerializingMember item) { }

	// RVA: 0xD1D890
	internal bool <HasAnyCorrespondingMembers>b__33_0(string x) { }

	// RVA: 0xD1D8B0
	internal bool <GetTargetMembers>b__37_0(MemberInfo item) { }

	// RVA: 0xD1D98C
	internal bool <GetTargetMembers>b__37_1(object attr) { }

	// RVA: 0xD1DA00
	internal bool <GetAnnotatedMembersWithDuplicationDetection>b__38_0(MemberInfo member) { }

	// RVA: 0xD1DADC
	internal SerializingMember <GetAnnotatedMembersWithDuplicationDetection>b__38_1(MemberInfo member) { }

	// RVA: 0xD1DD54
	internal <>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> <GetSystemRuntimeSerializationCompatibleMembers>b__39_0(MemberInfo item) { }

	// RVA: 0xD1DEE0
	internal bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_3(object data) { }

	// RVA: 0xD1DF54
	internal bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_1(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xD1DFEC
	internal SerializingMember <GetSystemRuntimeSerializationCompatibleMembers>b__39_2(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xD1E6EC
	internal bool <GetPublicUnpreventedMembers>b__40_0(MemberInfo member) { }

	// RVA: 0xD1EA54
	internal string <GetPublicUnpreventedMembers>b__40_2(object data) { }

	// RVA: 0xD1EA88
	internal bool <GetPublicUnpreventedMembers>b__40_3(string attr) { }

	// RVA: 0xD1EB1C
	internal SerializingMember <GetPublicUnpreventedMembers>b__40_1(MemberInfo member) { }

	// RVA: 0xD1EC0C
	internal int <FindDeserializationConstructor>b__42_0(ConstructorInfo ctor) { }

	// RVA: 0xD1EC44
	internal int <FindDeserializationConstructor>b__42_1(System.Linq.IGrouping<System.Int32,System.Reflection.ConstructorInfo> g) { }

	// RVA: 0xD1ECF4
	internal string <FindDeserializationConstructor>b__42_2(ConstructorInfo ctor) { }

	// RVA: 0xD1ED1C
	internal bool <FindExplicitDeserializationConstructors>b__43_0(ConstructorInfo ctor) { }

	// RVA: 0xD1EE5C
	internal bool <FindExplicitDeserializationConstructors>b__43_1(object a) { }

	// RVA: 0xD1EEF0
	internal int <ComplementMembers>b__46_0(SerializingMember item) { }

	// RVA: 0xD1EF14
	internal string <VerifyKeyUniqueness>b__48_0(System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<System.Reflection.MemberInfo>> kv) { }

	// RVA: 0xD1F2A4
	internal string <VerifyKeyUniqueness>b__48_1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public SerializationContext context; // 0x10

	// Methods

	// RVA: 0xD1944C
	public void .ctor() { }

	// RVA: 0xD1F4E8
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

	// RVA: 0xD17F1C
	public System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> get_Members() { }

	// RVA: 0xD17F24
	private void set_Members(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> value) { }

	// RVA: 0xD17F2C
	public ConstructorInfo get_DeserializationConstructor() { }

	// RVA: 0xD17F34
	private void set_DeserializationConstructor(ConstructorInfo value) { }

	// RVA: 0xD17F3C
	public bool get_IsConstructorDeserialization() { }

	// RVA: 0xD17F44
	private void set_IsConstructorDeserialization(bool value) { }

	// RVA: 0xD17F4C
	public bool get_CanDeserialize() { }

	// RVA: 0xD17F54
	private void set_CanDeserialize(bool value) { }

	// RVA: 0xD17F5C
	private void .ctor(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor, string[] correspondingMemberNames, bool canDeserialize) { }

	// RVA: 0xD18068
	public SerializerCapabilities GetCapabilitiesForObject() { }

	// RVA: 0xD1807C
	public SerializerCapabilities GetCapabilitiesForCollection(CollectionTraits traits) { }

	// RVA: 0xD180A4
	private static string[] FindCorrespondingMemberNames(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor) { }

	// RVA: 0xD183A4
	private static string DetermineCorrespondingMemberName(ParameterInfo parameterInfo, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xD1846C
	private static void ThrowAmbigiousMatchException(ParameterInfo parameterInfo, System.Collections.Generic.ICollection<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xD186AC
	public static void VerifyType(Type targetType) { }

	// RVA: 0xD1877C
	public static void VerifyCanSerializeTargetType(SerializationContext context, Type targetType) { }

	// RVA: 0xD189BC
	public static SerializationTarget Prepare(SerializationContext context, Type targetType) { }

	// RVA: 0xD1AC10
	private static bool HasAnyCorrespondingMembers(System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames) { }

	// RVA: 0xD1AD44
	private static bool HasUnpackableInterface(Type targetType, SerializationContext context) { }

	// RVA: 0xD1A988
	private static bool DetermineCanDeserialize(ConstructorKind kind, SerializationContext context, Type targetType, System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames, bool allowDefault) { }

	// RVA: 0xD1ADFC
	private static MemberInfo[] GetDistinctMembers(Type type) { }

	// RVA: 0xD19454
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetTargetMembers(Type type) { }

	// RVA: 0xD1B1E0
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetAnnotatedMembersWithDuplicationDetection(Type type, MemberInfo[] filtered) { }

	// RVA: 0xD1B4E4
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetSystemRuntimeSerializationCompatibleMembers(MemberInfo[] members) { }

	// RVA: 0xD1B7AC
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetPublicUnpreventedMembers(MemberInfo[] members) { }

	// RVA: 0xD1B9A4
	private static bool IsNonSerializedField(MemberInfo member) { }

	// RVA: 0xD19748
	private static ConstructorInfo FindDeserializationConstructor(SerializationContext context, Type targetType, ConstructorKind constructorKind) { }

	// RVA: 0xD1AAF0
	private static System.Collections.Generic.IList<System.Reflection.ConstructorInfo> FindExplicitDeserializationConstructors(System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> construtors) { }

	// RVA: 0xD1BA3C
	private static SerializationException NewTypeCannotBeSerializedException(Type targetType) { }

	// RVA: 0xD1BB74
	private static bool CheckTargetEligibility(SerializationContext context, MemberInfo member) { }

	// RVA: 0xD19E70
	private static System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> ComplementMembers(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> candidates, SerializationContext context, Type targetType) { }

	// RVA: 0xD1BEA8
	private static void VerifyNilImplication(Type type, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> entries) { }

	// RVA: 0xD1C3D4
	private static void VerifyKeyUniqueness(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> result) { }

	// RVA: 0xD1CC0C
	public static SerializationTarget CreateForCollection(ConstructorInfo collectionConstructor, bool canDeserialize) { }

	// RVA: 0xD1CCA0
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

	// RVA: 0xD18998
	public bool get_DisablePrivilegedAccess() { }

	// RVA: 0xD14D84
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

	// RVA: 0xD14CB8
	public void .ctor(SerializerRepository copiedFrom) { }

	// RVA: 0xD1F57C
	private void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD1F6F4
	public void Dispose() { }

	// RVA: 0x30A188C
	public MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x30A1970
	public MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0xD1F6F8
	internal bool Register(Type targetType, MessagePackSerializerProvider serializerProvider, Type nullableType, MessagePackSerializerProvider nullableSerializerProvider, SerializerRegistrationOptions options) { }

	// RVA: 0xD14BF4
	public static SerializerRepository GetDefault(SerializationContext ownerContext) { }

	// RVA: 0xD1F718
	internal static System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeDefaultTable(SerializationContext ownerContext) { }

	// RVA: 0xD20CBC
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class SerializerTypeKeyRepository
{
	// Fields
	private static readonly Type[] NonGenericSerializerConstructorParameterTypes; // 0x0

	// Methods

	// RVA: 0xD1F578
	public void .ctor(SerializerTypeKeyRepository copiedFrom) { }

	// RVA: 0xD1F664
	public void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD20E38
	public object Get(SerializationContext context, Type keyType) { }

	// RVA: 0xD211B4
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

	// RVA: 0xD1BE08
	public void .ctor() { }

	// RVA: 0xD1DCCC
	public void .ctor(MemberInfo member, DataMemberContract contract) { }

	// RVA: 0xD21324
	public EnumMemberSerializationMethod GetEnumMemberSerializationMethod() { }

	// RVA: 0xD2144C
	public DateTimeMemberConversionMethod GetDateTimeMemberConversionMethod() { }

	// RVA: 0xD21574
	public override string ToString() { }

}

// Namespace: MsgPack.Serialization
internal class TypeKeyRepository
{
	// Fields
	private readonly ReaderWriterLockSlim _lock; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> _table; // 0x18

	// Methods

	// RVA: 0xD20D44
	public void .ctor(TypeKeyRepository copiedFrom) { }

	// RVA: 0xD089F8
	public void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD217C0
	private System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> GetClonedTable() { }

	// RVA: 0xD08BE0
	public bool Get(Type type, object matched, object genericDefinitionMatched) { }

	// RVA: 0xD21918
	private bool GetCore(Type type, object matched, object genericDefinitionMatched) { }

	// RVA: 0xD1F714
	public bool Register(Type type, object entry, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xD21BFC
	private bool RegisterCore(Type key, object value, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xD21E58
	private bool ContainsType(Type baseType, Type nullableType) { }

}

// Namespace: MsgPack.Serialization
public static class UnpackHelpers
{
	// Fields
	private static readonly MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _messagePackObjectSerializer; // 0x0

	// Methods

	// RVA: 0xD21F44
	public static int GetItemsCount(Unpacker unpacker) { }

	// RVA: 0xD22084
	internal static SerializationTarget DetermineCollectionSerializationStrategy(Type instanceType, bool allowAsymmetricSerializer) { }

	// RVA: 0xD221E8
	private static ConstructorInfo TryGetCollectionConstructor(Type instanceType) { }

	// RVA: 0xD2256C
	internal static bool IsIEqualityComparer(Type type) { }

	// RVA: 0xD22674
	internal static object GetEqualityComparer(Type comparerType) { }

	// RVA: 0xD22A30
	private static void .cctor() { }

}

// Namespace: 
private sealed class BoxingGenericEqualityComparer<T0>
{
	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	public bool Equals(T x, T y) { }

	// RVA: 0x315B3A8
	public int GetHashCode(T obj) { }

}

// Namespace: 
private sealed class System_AppDomainManagerInitializationOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD2DE48
	public void .ctor() { }

	// RVA: 0xD2DE50
	public bool Equals(AppDomainManagerInitializationOptions left, AppDomainManagerInitializationOptions right) { }

	// RVA: 0xD2DED8
	public int GetHashCode(AppDomainManagerInitializationOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_AppDomainManagerInitializationOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD2DF00
	public void .ctor() { }

	// RVA: 0xD2DF08
	public bool Equals(System.Nullable<System.AppDomainManagerInitializationOptions> left, System.Nullable<System.AppDomainManagerInitializationOptions> right) { }

	// RVA: 0xD2E084
	public int GetHashCode(System.Nullable<System.AppDomainManagerInitializationOptions> obj) { }

}

// Namespace: 
private sealed class System_AttributeTargetsEqualityComparer
{
	// Methods

	// RVA: 0xD2E138
	public void .ctor() { }

	// RVA: 0xD2E140
	public bool Equals(AttributeTargets left, AttributeTargets right) { }

	// RVA: 0xD2E1C8
	public int GetHashCode(AttributeTargets obj) { }

}

// Namespace: 
private sealed class NullableSystem_AttributeTargetsEqualityComparer
{
	// Methods

	// RVA: 0xD2E1F0
	public void .ctor() { }

	// RVA: 0xD2E1F8
	public bool Equals(System.Nullable<System.AttributeTargets> left, System.Nullable<System.AttributeTargets> right) { }

	// RVA: 0xD2E374
	public int GetHashCode(System.Nullable<System.AttributeTargets> obj) { }

}

// Namespace: 
private sealed class System_Base64FormattingOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD2E428
	public void .ctor() { }

	// RVA: 0xD2E430
	public bool Equals(Base64FormattingOptions left, Base64FormattingOptions right) { }

	// RVA: 0xD2E4B8
	public int GetHashCode(Base64FormattingOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Base64FormattingOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD2E4E0
	public void .ctor() { }

	// RVA: 0xD2E4E8
	public bool Equals(System.Nullable<System.Base64FormattingOptions> left, System.Nullable<System.Base64FormattingOptions> right) { }

	// RVA: 0xD2E664
	public int GetHashCode(System.Nullable<System.Base64FormattingOptions> obj) { }

}

// Namespace: 
private sealed class System_BooleanEqualityComparer
{
	// Methods

	// RVA: 0xD2E718
	public void .ctor() { }

	// RVA: 0xD2E720
	public bool Equals(bool left, bool right) { }

	// RVA: 0xD2E72C
	public int GetHashCode(bool obj) { }

}

// Namespace: 
private sealed class NullableSystem_BooleanEqualityComparer
{
	// Methods

	// RVA: 0xD2E794
	public void .ctor() { }

	// RVA: 0xD2E79C
	public bool Equals(System.Nullable<System.Boolean> left, System.Nullable<System.Boolean> right) { }

	// RVA: 0xD2E8F0
	public int GetHashCode(System.Nullable<System.Boolean> obj) { }

}

// Namespace: 
private sealed class System_ByteEqualityComparer
{
	// Methods

	// RVA: 0xD2E9A4
	public void .ctor() { }

	// RVA: 0xD2E9AC
	public bool Equals(Byte left, Byte right) { }

	// RVA: 0xD2E9B8
	public int GetHashCode(Byte obj) { }

}

// Namespace: 
private sealed class NullableSystem_ByteEqualityComparer
{
	// Methods

	// RVA: 0xD2E9E0
	public void .ctor() { }

	// RVA: 0xD2E9E8
	public bool Equals(System.Nullable<System.Byte> left, System.Nullable<System.Byte> right) { }

	// RVA: 0xD2EB30
	public int GetHashCode(System.Nullable<System.Byte> obj) { }

}

// Namespace: 
private sealed class System_CharEqualityComparer
{
	// Methods

	// RVA: 0xD2EBE4
	public void .ctor() { }

	// RVA: 0xD2EBEC
	public bool Equals(Char left, Char right) { }

	// RVA: 0xD2EBF8
	public int GetHashCode(Char obj) { }

}

// Namespace: 
private sealed class NullableSystem_CharEqualityComparer
{
	// Methods

	// RVA: 0xD2EC60
	public void .ctor() { }

	// RVA: 0xD2EC68
	public bool Equals(System.Nullable<System.Char> left, System.Nullable<System.Char> right) { }

	// RVA: 0xD2EDAC
	public int GetHashCode(System.Nullable<System.Char> obj) { }

}

// Namespace: 
private sealed class System_ConsoleColorEqualityComparer
{
	// Methods

	// RVA: 0xD2EE60
	public void .ctor() { }

	// RVA: 0xD2EE68
	public bool Equals(ConsoleColor left, ConsoleColor right) { }

	// RVA: 0xD2EEF0
	public int GetHashCode(ConsoleColor obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleColorEqualityComparer
{
	// Methods

	// RVA: 0xD2EF18
	public void .ctor() { }

	// RVA: 0xD2EF20
	public bool Equals(System.Nullable<System.ConsoleColor> left, System.Nullable<System.ConsoleColor> right) { }

	// RVA: 0xD2F09C
	public int GetHashCode(System.Nullable<System.ConsoleColor> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyEqualityComparer
{
	// Methods

	// RVA: 0xD2F150
	public void .ctor() { }

	// RVA: 0xD2F158
	public bool Equals(ConsoleKey left, ConsoleKey right) { }

	// RVA: 0xD2F1E0
	public int GetHashCode(ConsoleKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyEqualityComparer
{
	// Methods

	// RVA: 0xD2F208
	public void .ctor() { }

	// RVA: 0xD2F210
	public bool Equals(System.Nullable<System.ConsoleKey> left, System.Nullable<System.ConsoleKey> right) { }

	// RVA: 0xD2F38C
	public int GetHashCode(System.Nullable<System.ConsoleKey> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyInfoEqualityComparer
{
	// Methods

	// RVA: 0xD2F440
	public void .ctor() { }

	// RVA: 0xD2F448
	public bool Equals(ConsoleKeyInfo left, ConsoleKeyInfo right) { }

	// RVA: 0xD2F47C
	public int GetHashCode(ConsoleKeyInfo obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyInfoEqualityComparer
{
	// Methods

	// RVA: 0xD2F4A8
	public void .ctor() { }

	// RVA: 0xD2F4B0
	public bool Equals(System.Nullable<System.ConsoleKeyInfo> left, System.Nullable<System.ConsoleKeyInfo> right) { }

	// RVA: 0xD2F60C
	public int GetHashCode(System.Nullable<System.ConsoleKeyInfo> obj) { }

}

// Namespace: 
private sealed class System_ConsoleModifiersEqualityComparer
{
	// Methods

	// RVA: 0xD2F6C0
	public void .ctor() { }

	// RVA: 0xD2F6C8
	public bool Equals(ConsoleModifiers left, ConsoleModifiers right) { }

	// RVA: 0xD2F750
	public int GetHashCode(ConsoleModifiers obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleModifiersEqualityComparer
{
	// Methods

	// RVA: 0xD2F778
	public void .ctor() { }

	// RVA: 0xD2F780
	public bool Equals(System.Nullable<System.ConsoleModifiers> left, System.Nullable<System.ConsoleModifiers> right) { }

	// RVA: 0xD2F8FC
	public int GetHashCode(System.Nullable<System.ConsoleModifiers> obj) { }

}

// Namespace: 
private sealed class System_ConsoleSpecialKeyEqualityComparer
{
	// Methods

	// RVA: 0xD2F9B0
	public void .ctor() { }

	// RVA: 0xD2F9B8
	public bool Equals(ConsoleSpecialKey left, ConsoleSpecialKey right) { }

	// RVA: 0xD2FA40
	public int GetHashCode(ConsoleSpecialKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleSpecialKeyEqualityComparer
{
	// Methods

	// RVA: 0xD2FA68
	public void .ctor() { }

	// RVA: 0xD2FA70
	public bool Equals(System.Nullable<System.ConsoleSpecialKey> left, System.Nullable<System.ConsoleSpecialKey> right) { }

	// RVA: 0xD2FBEC
	public int GetHashCode(System.Nullable<System.ConsoleSpecialKey> obj) { }

}

// Namespace: 
private sealed class System_DateTimeEqualityComparer
{
	// Methods

	// RVA: 0xD2FCA0
	public void .ctor() { }

	// RVA: 0xD2FCA8
	public bool Equals(DateTime left, DateTime right) { }

	// RVA: 0xD2FD20
	public int GetHashCode(DateTime obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeEqualityComparer
{
	// Methods

	// RVA: 0xD2FD88
	public void .ctor() { }

	// RVA: 0xD2FD90
	public bool Equals(System.Nullable<System.DateTime> left, System.Nullable<System.DateTime> right) { }

	// RVA: 0xD2FF04
	public int GetHashCode(System.Nullable<System.DateTime> obj) { }

}

// Namespace: 
private sealed class System_DateTimeKindEqualityComparer
{
	// Methods

	// RVA: 0xD2FFB8
	public void .ctor() { }

	// RVA: 0xD2FFC0
	public bool Equals(DateTimeKind left, DateTimeKind right) { }

	// RVA: 0xD30048
	public int GetHashCode(DateTimeKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeKindEqualityComparer
{
	// Methods

	// RVA: 0xD30070
	public void .ctor() { }

	// RVA: 0xD30078
	public bool Equals(System.Nullable<System.DateTimeKind> left, System.Nullable<System.DateTimeKind> right) { }

	// RVA: 0xD301F4
	public int GetHashCode(System.Nullable<System.DateTimeKind> obj) { }

}

// Namespace: 
private sealed class System_DateTimeOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD302A8
	public void .ctor() { }

	// RVA: 0xD302B0
	public bool Equals(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0xD30330
	public int GetHashCode(DateTimeOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD30398
	public void .ctor() { }

	// RVA: 0xD303A0
	public bool Equals(System.Nullable<System.DateTimeOffset> left, System.Nullable<System.DateTimeOffset> right) { }

	// RVA: 0xD3052C
	public int GetHashCode(System.Nullable<System.DateTimeOffset> obj) { }

}

// Namespace: 
private sealed class System_DayOfWeekEqualityComparer
{
	// Methods

	// RVA: 0xD305DC
	public void .ctor() { }

	// RVA: 0xD305E4
	public bool Equals(DayOfWeek left, DayOfWeek right) { }

	// RVA: 0xD3066C
	public int GetHashCode(DayOfWeek obj) { }

}

// Namespace: 
private sealed class NullableSystem_DayOfWeekEqualityComparer
{
	// Methods

	// RVA: 0xD30694
	public void .ctor() { }

	// RVA: 0xD3069C
	public bool Equals(System.Nullable<System.DayOfWeek> left, System.Nullable<System.DayOfWeek> right) { }

	// RVA: 0xD30818
	public int GetHashCode(System.Nullable<System.DayOfWeek> obj) { }

}

// Namespace: 
private sealed class System_DecimalEqualityComparer
{
	// Methods

	// RVA: 0xD308CC
	public void .ctor() { }

	// RVA: 0xD308D4
	public bool Equals(Decimal left, Decimal right) { }

	// RVA: 0xD30980
	public int GetHashCode(Decimal obj) { }

}

// Namespace: 
private sealed class NullableSystem_DecimalEqualityComparer
{
	// Methods

	// RVA: 0xD30A14
	public void .ctor() { }

	// RVA: 0xD30A1C
	public bool Equals(System.Nullable<System.Decimal> left, System.Nullable<System.Decimal> right) { }

	// RVA: 0xD30BE0
	public int GetHashCode(System.Nullable<System.Decimal> obj) { }

}

// Namespace: 
private sealed class System_DoubleEqualityComparer
{
	// Methods

	// RVA: 0xD30C90
	public void .ctor() { }

	// RVA: 0xD30C98
	public bool Equals(Double left, Double right) { }

	// RVA: 0xD30CA4
	public int GetHashCode(Double obj) { }

}

// Namespace: 
private sealed class NullableSystem_DoubleEqualityComparer
{
	// Methods

	// RVA: 0xD30CC4
	public void .ctor() { }

	// RVA: 0xD30CCC
	public bool Equals(System.Nullable<System.Double> left, System.Nullable<System.Double> right) { }

	// RVA: 0xD30E24
	public int GetHashCode(System.Nullable<System.Double> obj) { }

}

// Namespace: 
private sealed class System_EnvironmentVariableTargetEqualityComparer
{
	// Methods

	// RVA: 0xD30ED8
	public void .ctor() { }

	// RVA: 0xD30EE0
	public bool Equals(EnvironmentVariableTarget left, EnvironmentVariableTarget right) { }

	// RVA: 0xD30F68
	public int GetHashCode(EnvironmentVariableTarget obj) { }

}

// Namespace: 
private sealed class NullableSystem_EnvironmentVariableTargetEqualityComparer
{
	// Methods

	// RVA: 0xD30F90
	public void .ctor() { }

	// RVA: 0xD30F98
	public bool Equals(System.Nullable<System.EnvironmentVariableTarget> left, System.Nullable<System.EnvironmentVariableTarget> right) { }

	// RVA: 0xD31114
	public int GetHashCode(System.Nullable<System.EnvironmentVariableTarget> obj) { }

}

// Namespace: 
private sealed class System_GCCollectionModeEqualityComparer
{
	// Methods

	// RVA: 0xD311C8
	public void .ctor() { }

	// RVA: 0xD311D0
	public bool Equals(GCCollectionMode left, GCCollectionMode right) { }

	// RVA: 0xD31258
	public int GetHashCode(GCCollectionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCCollectionModeEqualityComparer
{
	// Methods

	// RVA: 0xD31280
	public void .ctor() { }

	// RVA: 0xD31288
	public bool Equals(System.Nullable<System.GCCollectionMode> left, System.Nullable<System.GCCollectionMode> right) { }

	// RVA: 0xD31404
	public int GetHashCode(System.Nullable<System.GCCollectionMode> obj) { }

}

// Namespace: 
private sealed class System_GCNotificationStatusEqualityComparer
{
	// Methods

	// RVA: 0xD314B8
	public void .ctor() { }

	// RVA: 0xD314C0
	public bool Equals(GCNotificationStatus left, GCNotificationStatus right) { }

	// RVA: 0xD31548
	public int GetHashCode(GCNotificationStatus obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCNotificationStatusEqualityComparer
{
	// Methods

	// RVA: 0xD31570
	public void .ctor() { }

	// RVA: 0xD31578
	public bool Equals(System.Nullable<System.GCNotificationStatus> left, System.Nullable<System.GCNotificationStatus> right) { }

	// RVA: 0xD316F4
	public int GetHashCode(System.Nullable<System.GCNotificationStatus> obj) { }

}

// Namespace: 
private sealed class System_GuidEqualityComparer
{
	// Methods

	// RVA: 0xD317A8
	public void .ctor() { }

	// RVA: 0xD317B0
	public bool Equals(Guid left, Guid right) { }

	// RVA: 0xD317E0
	public int GetHashCode(Guid obj) { }

}

// Namespace: 
private sealed class NullableSystem_GuidEqualityComparer
{
	// Methods

	// RVA: 0xD31808
	public void .ctor() { }

	// RVA: 0xD31810
	public bool Equals(System.Nullable<System.Guid> left, System.Nullable<System.Guid> right) { }

	// RVA: 0xD31970
	public int GetHashCode(System.Nullable<System.Guid> obj) { }

}

// Namespace: 
private sealed class System_Int16EqualityComparer
{
	// Methods

	// RVA: 0xD31A20
	public void .ctor() { }

	// RVA: 0xD31A28
	public bool Equals(Int16 left, Int16 right) { }

	// RVA: 0xD31A34
	public int GetHashCode(Int16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int16EqualityComparer
{
	// Methods

	// RVA: 0xD31A5C
	public void .ctor() { }

	// RVA: 0xD31A64
	public bool Equals(System.Nullable<System.Int16> left, System.Nullable<System.Int16> right) { }

	// RVA: 0xD31BA8
	public int GetHashCode(System.Nullable<System.Int16> obj) { }

}

// Namespace: 
private sealed class System_Int32EqualityComparer
{
	// Methods

	// RVA: 0xD31C5C
	public void .ctor() { }

	// RVA: 0xD31C64
	public bool Equals(int left, int right) { }

	// RVA: 0xD31C70
	public int GetHashCode(int obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int32EqualityComparer
{
	// Methods

	// RVA: 0xD31C98
	public void .ctor() { }

	// RVA: 0xD31CA0
	public bool Equals(System.Nullable<System.Int32> left, System.Nullable<System.Int32> right) { }

	// RVA: 0xD31DE4
	public int GetHashCode(System.Nullable<System.Int32> obj) { }

}

// Namespace: 
private sealed class System_Int64EqualityComparer
{
	// Methods

	// RVA: 0xD31E98
	public void .ctor() { }

	// RVA: 0xD31EA0
	public bool Equals(Int64 left, Int64 right) { }

	// RVA: 0xD31EAC
	public int GetHashCode(Int64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int64EqualityComparer
{
	// Methods

	// RVA: 0xD31ED4
	public void .ctor() { }

	// RVA: 0xD31EDC
	public bool Equals(System.Nullable<System.Int64> left, System.Nullable<System.Int64> right) { }

	// RVA: 0xD32024
	public int GetHashCode(System.Nullable<System.Int64> obj) { }

}

// Namespace: 
private sealed class System_IntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD320D8
	public void .ctor() { }

	// RVA: 0xD320E0
	public bool Equals(IntPtr left, IntPtr right) { }

	// RVA: 0xD320F0
	public int GetHashCode(IntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_IntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD32118
	public void .ctor() { }

	// RVA: 0xD32120
	public bool Equals(System.Nullable<System.IntPtr> left, System.Nullable<System.IntPtr> right) { }

	// RVA: 0xD3226C
	public int GetHashCode(System.Nullable<System.IntPtr> obj) { }

}

// Namespace: 
private sealed class System_LoaderOptimizationEqualityComparer
{
	// Methods

	// RVA: 0xD32320
	public void .ctor() { }

	// RVA: 0xD32328
	public bool Equals(LoaderOptimization left, LoaderOptimization right) { }

	// RVA: 0xD323B0
	public int GetHashCode(LoaderOptimization obj) { }

}

// Namespace: 
private sealed class NullableSystem_LoaderOptimizationEqualityComparer
{
	// Methods

	// RVA: 0xD323D8
	public void .ctor() { }

	// RVA: 0xD323E0
	public bool Equals(System.Nullable<System.LoaderOptimization> left, System.Nullable<System.LoaderOptimization> right) { }

	// RVA: 0xD3255C
	public int GetHashCode(System.Nullable<System.LoaderOptimization> obj) { }

}

// Namespace: 
private sealed class System_MidpointRoundingEqualityComparer
{
	// Methods

	// RVA: 0xD32610
	public void .ctor() { }

	// RVA: 0xD32618
	public bool Equals(MidpointRounding left, MidpointRounding right) { }

	// RVA: 0xD326A0
	public int GetHashCode(MidpointRounding obj) { }

}

// Namespace: 
private sealed class NullableSystem_MidpointRoundingEqualityComparer
{
	// Methods

	// RVA: 0xD326C8
	public void .ctor() { }

	// RVA: 0xD326D0
	public bool Equals(System.Nullable<System.MidpointRounding> left, System.Nullable<System.MidpointRounding> right) { }

	// RVA: 0xD3284C
	public int GetHashCode(System.Nullable<System.MidpointRounding> obj) { }

}

// Namespace: 
private sealed class System_ModuleHandleEqualityComparer
{
	// Methods

	// RVA: 0xD32900
	public void .ctor() { }

	// RVA: 0xD32908
	public bool Equals(ModuleHandle left, ModuleHandle right) { }

	// RVA: 0xD32980
	public int GetHashCode(ModuleHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_ModuleHandleEqualityComparer
{
	// Methods

	// RVA: 0xD329E8
	public void .ctor() { }

	// RVA: 0xD329F0
	public bool Equals(System.Nullable<System.ModuleHandle> left, System.Nullable<System.ModuleHandle> right) { }

	// RVA: 0xD32B64
	public int GetHashCode(System.Nullable<System.ModuleHandle> obj) { }

}

// Namespace: 
private sealed class System_PlatformIDEqualityComparer
{
	// Methods

	// RVA: 0xD32C18
	public void .ctor() { }

	// RVA: 0xD32C20
	public bool Equals(PlatformID left, PlatformID right) { }

	// RVA: 0xD32CA8
	public int GetHashCode(PlatformID obj) { }

}

// Namespace: 
private sealed class NullableSystem_PlatformIDEqualityComparer
{
	// Methods

	// RVA: 0xD32CD0
	public void .ctor() { }

	// RVA: 0xD32CD8
	public bool Equals(System.Nullable<System.PlatformID> left, System.Nullable<System.PlatformID> right) { }

	// RVA: 0xD32E54
	public int GetHashCode(System.Nullable<System.PlatformID> obj) { }

}

// Namespace: 
private sealed class System_RuntimeFieldHandleEqualityComparer
{
	// Methods

	// RVA: 0xD32F08
	public void .ctor() { }

	// RVA: 0xD32F10
	public bool Equals(RuntimeFieldHandle left, RuntimeFieldHandle right) { }

	// RVA: 0xD32F3C
	public int GetHashCode(RuntimeFieldHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeFieldHandleEqualityComparer
{
	// Methods

	// RVA: 0xD32F64
	public void .ctor() { }

	// RVA: 0xD32F6C
	public bool Equals(System.Nullable<System.RuntimeFieldHandle> left, System.Nullable<System.RuntimeFieldHandle> right) { }

	// RVA: 0xD330B8
	public int GetHashCode(System.Nullable<System.RuntimeFieldHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeMethodHandleEqualityComparer
{
	// Methods

	// RVA: 0xD3316C
	public void .ctor() { }

	// RVA: 0xD33174
	public bool Equals(RuntimeMethodHandle left, RuntimeMethodHandle right) { }

	// RVA: 0xD331A0
	public int GetHashCode(RuntimeMethodHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeMethodHandleEqualityComparer
{
	// Methods

	// RVA: 0xD331C8
	public void .ctor() { }

	// RVA: 0xD331D0
	public bool Equals(System.Nullable<System.RuntimeMethodHandle> left, System.Nullable<System.RuntimeMethodHandle> right) { }

	// RVA: 0xD3331C
	public int GetHashCode(System.Nullable<System.RuntimeMethodHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeTypeHandleEqualityComparer
{
	// Methods

	// RVA: 0xD333D0
	public void .ctor() { }

	// RVA: 0xD333D8
	public bool Equals(RuntimeTypeHandle left, RuntimeTypeHandle right) { }

	// RVA: 0xD33404
	public int GetHashCode(RuntimeTypeHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeTypeHandleEqualityComparer
{
	// Methods

	// RVA: 0xD3342C
	public void .ctor() { }

	// RVA: 0xD33434
	public bool Equals(System.Nullable<System.RuntimeTypeHandle> left, System.Nullable<System.RuntimeTypeHandle> right) { }

	// RVA: 0xD33580
	public int GetHashCode(System.Nullable<System.RuntimeTypeHandle> obj) { }

}

// Namespace: 
private sealed class System_SByteEqualityComparer
{
	// Methods

	// RVA: 0xD33634
	public void .ctor() { }

	// RVA: 0xD3363C
	public bool Equals(SByte left, SByte right) { }

	// RVA: 0xD33648
	public int GetHashCode(SByte obj) { }

}

// Namespace: 
private sealed class NullableSystem_SByteEqualityComparer
{
	// Methods

	// RVA: 0xD33670
	public void .ctor() { }

	// RVA: 0xD33678
	public bool Equals(System.Nullable<System.SByte> left, System.Nullable<System.SByte> right) { }

	// RVA: 0xD337C0
	public int GetHashCode(System.Nullable<System.SByte> obj) { }

}

// Namespace: 
private sealed class System_SingleEqualityComparer
{
	// Methods

	// RVA: 0xD33874
	public void .ctor() { }

	// RVA: 0xD3387C
	public bool Equals(float left, float right) { }

	// RVA: 0xD33888
	public int GetHashCode(float obj) { }

}

// Namespace: 
private sealed class NullableSystem_SingleEqualityComparer
{
	// Methods

	// RVA: 0xD338B0
	public void .ctor() { }

	// RVA: 0xD338B8
	public bool Equals(System.Nullable<System.Single> left, System.Nullable<System.Single> right) { }

	// RVA: 0xD33A0C
	public int GetHashCode(System.Nullable<System.Single> obj) { }

}

// Namespace: 
private sealed class System_StringComparisonEqualityComparer
{
	// Methods

	// RVA: 0xD33AC0
	public void .ctor() { }

	// RVA: 0xD33AC8
	public bool Equals(StringComparison left, StringComparison right) { }

	// RVA: 0xD33B50
	public int GetHashCode(StringComparison obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringComparisonEqualityComparer
{
	// Methods

	// RVA: 0xD33B78
	public void .ctor() { }

	// RVA: 0xD33B80
	public bool Equals(System.Nullable<System.StringComparison> left, System.Nullable<System.StringComparison> right) { }

	// RVA: 0xD33CFC
	public int GetHashCode(System.Nullable<System.StringComparison> obj) { }

}

// Namespace: 
private sealed class System_StringSplitOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD33DB0
	public void .ctor() { }

	// RVA: 0xD33DB8
	public bool Equals(StringSplitOptions left, StringSplitOptions right) { }

	// RVA: 0xD33E40
	public int GetHashCode(StringSplitOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringSplitOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD33E68
	public void .ctor() { }

	// RVA: 0xD33E70
	public bool Equals(System.Nullable<System.StringSplitOptions> left, System.Nullable<System.StringSplitOptions> right) { }

	// RVA: 0xD33FEC
	public int GetHashCode(System.Nullable<System.StringSplitOptions> obj) { }

}

// Namespace: 
private sealed class System_TimeSpanEqualityComparer
{
	// Methods

	// RVA: 0xD340A0
	public void .ctor() { }

	// RVA: 0xD340A8
	public bool Equals(TimeSpan left, TimeSpan right) { }

	// RVA: 0xD34120
	public int GetHashCode(TimeSpan obj) { }

}

// Namespace: 
private sealed class NullableSystem_TimeSpanEqualityComparer
{
	// Methods

	// RVA: 0xD34188
	public void .ctor() { }

	// RVA: 0xD34190
	public bool Equals(System.Nullable<System.TimeSpan> left, System.Nullable<System.TimeSpan> right) { }

	// RVA: 0xD34304
	public int GetHashCode(System.Nullable<System.TimeSpan> obj) { }

}

// Namespace: 
private sealed class System_TypeCodeEqualityComparer
{
	// Methods

	// RVA: 0xD343B8
	public void .ctor() { }

	// RVA: 0xD343C0
	public bool Equals(TypeCode left, TypeCode right) { }

	// RVA: 0xD34448
	public int GetHashCode(TypeCode obj) { }

}

// Namespace: 
private sealed class NullableSystem_TypeCodeEqualityComparer
{
	// Methods

	// RVA: 0xD34470
	public void .ctor() { }

	// RVA: 0xD34478
	public bool Equals(System.Nullable<System.TypeCode> left, System.Nullable<System.TypeCode> right) { }

	// RVA: 0xD345F4
	public int GetHashCode(System.Nullable<System.TypeCode> obj) { }

}

// Namespace: 
private sealed class System_UInt16EqualityComparer
{
	// Methods

	// RVA: 0xD346A8
	public void .ctor() { }

	// RVA: 0xD346B0
	public bool Equals(UInt16 left, UInt16 right) { }

	// RVA: 0xD346BC
	public int GetHashCode(UInt16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt16EqualityComparer
{
	// Methods

	// RVA: 0xD346E4
	public void .ctor() { }

	// RVA: 0xD346EC
	public bool Equals(System.Nullable<System.UInt16> left, System.Nullable<System.UInt16> right) { }

	// RVA: 0xD34830
	public int GetHashCode(System.Nullable<System.UInt16> obj) { }

}

// Namespace: 
private sealed class System_UInt32EqualityComparer
{
	// Methods

	// RVA: 0xD348E4
	public void .ctor() { }

	// RVA: 0xD348EC
	public bool Equals(UInt32 left, UInt32 right) { }

	// RVA: 0xD348F8
	public int GetHashCode(UInt32 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt32EqualityComparer
{
	// Methods

	// RVA: 0xD34920
	public void .ctor() { }

	// RVA: 0xD34928
	public bool Equals(System.Nullable<System.UInt32> left, System.Nullable<System.UInt32> right) { }

	// RVA: 0xD34A6C
	public int GetHashCode(System.Nullable<System.UInt32> obj) { }

}

// Namespace: 
private sealed class System_UInt64EqualityComparer
{
	// Methods

	// RVA: 0xD34B20
	public void .ctor() { }

	// RVA: 0xD34B28
	public bool Equals(UInt64 left, UInt64 right) { }

	// RVA: 0xD34B34
	public int GetHashCode(UInt64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt64EqualityComparer
{
	// Methods

	// RVA: 0xD34B5C
	public void .ctor() { }

	// RVA: 0xD34B64
	public bool Equals(System.Nullable<System.UInt64> left, System.Nullable<System.UInt64> right) { }

	// RVA: 0xD34CAC
	public int GetHashCode(System.Nullable<System.UInt64> obj) { }

}

// Namespace: 
private sealed class System_UIntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD34D60
	public void .ctor() { }

	// RVA: 0xD34D68
	public bool Equals(UIntPtr left, UIntPtr right) { }

	// RVA: 0xD34D78
	public int GetHashCode(UIntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_UIntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD34DA0
	public void .ctor() { }

	// RVA: 0xD34DA8
	public bool Equals(System.Nullable<System.UIntPtr> left, System.Nullable<System.UIntPtr> right) { }

	// RVA: 0xD34EF4
	public int GetHashCode(System.Nullable<System.UIntPtr> obj) { }

}

// Namespace: 
private sealed class System_Collections_DictionaryEntryEqualityComparer
{
	// Methods

	// RVA: 0xD34FA8
	public void .ctor() { }

	// RVA: 0xD34FB0
	public bool Equals(DictionaryEntry left, DictionaryEntry right) { }

	// RVA: 0xD35048
	public int GetHashCode(DictionaryEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Collections_DictionaryEntryEqualityComparer
{
	// Methods

	// RVA: 0xD350BC
	public void .ctor() { }

	// RVA: 0xD350C4
	public bool Equals(System.Nullable<System.Collections.DictionaryEntry> left, System.Nullable<System.Collections.DictionaryEntry> right) { }

	// RVA: 0xD35258
	public int GetHashCode(System.Nullable<System.Collections.DictionaryEntry> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_DebuggerBrowsableStateEqualityComparer
{
	// Methods

	// RVA: 0xD35308
	public void .ctor() { }

	// RVA: 0xD35310
	public bool Equals(DebuggerBrowsableState left, DebuggerBrowsableState right) { }

	// RVA: 0xD35398
	public int GetHashCode(DebuggerBrowsableState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_DebuggerBrowsableStateEqualityComparer
{
	// Methods

	// RVA: 0xD353C0
	public void .ctor() { }

	// RVA: 0xD353C8
	public bool Equals(System.Nullable<System.Diagnostics.DebuggerBrowsableState> left, System.Nullable<System.Diagnostics.DebuggerBrowsableState> right) { }

	// RVA: 0xD35544
	public int GetHashCode(System.Nullable<System.Diagnostics.DebuggerBrowsableState> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymAddressKindEqualityComparer
{
	// Methods

	// RVA: 0xD355F8
	public void .ctor() { }

	// RVA: 0xD35600
	public bool Equals(SymAddressKind left, SymAddressKind right) { }

	// RVA: 0xD35688
	public int GetHashCode(SymAddressKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymAddressKindEqualityComparer
{
	// Methods

	// RVA: 0xD356B0
	public void .ctor() { }

	// RVA: 0xD356B8
	public bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> left, System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> right) { }

	// RVA: 0xD35834
	public int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymbolTokenEqualityComparer
{
	// Methods

	// RVA: 0xD358E8
	public void .ctor() { }

	// RVA: 0xD358F0
	public bool Equals(SymbolToken left, SymbolToken right) { }

	// RVA: 0xD3591C
	public int GetHashCode(SymbolToken obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymbolTokenEqualityComparer
{
	// Methods

	// RVA: 0xD35924
	public void .ctor() { }

	// RVA: 0xD3592C
	public bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> left, System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> right) { }

	// RVA: 0xD35A74
	public int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarAlgorithmTypeEqualityComparer
{
	// Methods

	// RVA: 0xD35B28
	public void .ctor() { }

	// RVA: 0xD35B30
	public bool Equals(CalendarAlgorithmType left, CalendarAlgorithmType right) { }

	// RVA: 0xD35BB8
	public int GetHashCode(CalendarAlgorithmType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarAlgorithmTypeEqualityComparer
{
	// Methods

	// RVA: 0xD35BE0
	public void .ctor() { }

	// RVA: 0xD35BE8
	public bool Equals(System.Nullable<System.Globalization.CalendarAlgorithmType> left, System.Nullable<System.Globalization.CalendarAlgorithmType> right) { }

	// RVA: 0xD35D64
	public int GetHashCode(System.Nullable<System.Globalization.CalendarAlgorithmType> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarWeekRuleEqualityComparer
{
	// Methods

	// RVA: 0xD35E18
	public void .ctor() { }

	// RVA: 0xD35E20
	public bool Equals(CalendarWeekRule left, CalendarWeekRule right) { }

	// RVA: 0xD35EA8
	public int GetHashCode(CalendarWeekRule obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarWeekRuleEqualityComparer
{
	// Methods

	// RVA: 0xD35ED0
	public void .ctor() { }

	// RVA: 0xD35ED8
	public bool Equals(System.Nullable<System.Globalization.CalendarWeekRule> left, System.Nullable<System.Globalization.CalendarWeekRule> right) { }

	// RVA: 0xD36054
	public int GetHashCode(System.Nullable<System.Globalization.CalendarWeekRule> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CompareOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD36108
	public void .ctor() { }

	// RVA: 0xD36110
	public bool Equals(CompareOptions left, CompareOptions right) { }

	// RVA: 0xD36198
	public int GetHashCode(CompareOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CompareOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD361C0
	public void .ctor() { }

	// RVA: 0xD361C8
	public bool Equals(System.Nullable<System.Globalization.CompareOptions> left, System.Nullable<System.Globalization.CompareOptions> right) { }

	// RVA: 0xD36344
	public int GetHashCode(System.Nullable<System.Globalization.CompareOptions> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CultureTypesEqualityComparer
{
	// Methods

	// RVA: 0xD363F8
	public void .ctor() { }

	// RVA: 0xD36400
	public bool Equals(CultureTypes left, CultureTypes right) { }

	// RVA: 0xD36488
	public int GetHashCode(CultureTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CultureTypesEqualityComparer
{
	// Methods

	// RVA: 0xD364B0
	public void .ctor() { }

	// RVA: 0xD364B8
	public bool Equals(System.Nullable<System.Globalization.CultureTypes> left, System.Nullable<System.Globalization.CultureTypes> right) { }

	// RVA: 0xD36634
	public int GetHashCode(System.Nullable<System.Globalization.CultureTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DateTimeStylesEqualityComparer
{
	// Methods

	// RVA: 0xD366E8
	public void .ctor() { }

	// RVA: 0xD366F0
	public bool Equals(DateTimeStyles left, DateTimeStyles right) { }

	// RVA: 0xD36778
	public int GetHashCode(DateTimeStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DateTimeStylesEqualityComparer
{
	// Methods

	// RVA: 0xD367A0
	public void .ctor() { }

	// RVA: 0xD367A8
	public bool Equals(System.Nullable<System.Globalization.DateTimeStyles> left, System.Nullable<System.Globalization.DateTimeStyles> right) { }

	// RVA: 0xD36924
	public int GetHashCode(System.Nullable<System.Globalization.DateTimeStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DigitShapesEqualityComparer
{
	// Methods

	// RVA: 0xD369D8
	public void .ctor() { }

	// RVA: 0xD369E0
	public bool Equals(DigitShapes left, DigitShapes right) { }

	// RVA: 0xD36A68
	public int GetHashCode(DigitShapes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DigitShapesEqualityComparer
{
	// Methods

	// RVA: 0xD36A90
	public void .ctor() { }

	// RVA: 0xD36A98
	public bool Equals(System.Nullable<System.Globalization.DigitShapes> left, System.Nullable<System.Globalization.DigitShapes> right) { }

	// RVA: 0xD36C14
	public int GetHashCode(System.Nullable<System.Globalization.DigitShapes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_GregorianCalendarTypesEqualityComparer
{
	// Methods

	// RVA: 0xD36CC8
	public void .ctor() { }

	// RVA: 0xD36CD0
	public bool Equals(GregorianCalendarTypes left, GregorianCalendarTypes right) { }

	// RVA: 0xD36D58
	public int GetHashCode(GregorianCalendarTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_GregorianCalendarTypesEqualityComparer
{
	// Methods

	// RVA: 0xD36D80
	public void .ctor() { }

	// RVA: 0xD36D88
	public bool Equals(System.Nullable<System.Globalization.GregorianCalendarTypes> left, System.Nullable<System.Globalization.GregorianCalendarTypes> right) { }

	// RVA: 0xD36F04
	public int GetHashCode(System.Nullable<System.Globalization.GregorianCalendarTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_NumberStylesEqualityComparer
{
	// Methods

	// RVA: 0xD36FB8
	public void .ctor() { }

	// RVA: 0xD36FC0
	public bool Equals(NumberStyles left, NumberStyles right) { }

	// RVA: 0xD37048
	public int GetHashCode(NumberStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_NumberStylesEqualityComparer
{
	// Methods

	// RVA: 0xD37070
	public void .ctor() { }

	// RVA: 0xD37078
	public bool Equals(System.Nullable<System.Globalization.NumberStyles> left, System.Nullable<System.Globalization.NumberStyles> right) { }

	// RVA: 0xD371F4
	public int GetHashCode(System.Nullable<System.Globalization.NumberStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_UnicodeCategoryEqualityComparer
{
	// Methods

	// RVA: 0xD372A8
	public void .ctor() { }

	// RVA: 0xD372B0
	public bool Equals(UnicodeCategory left, UnicodeCategory right) { }

	// RVA: 0xD37338
	public int GetHashCode(UnicodeCategory obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_UnicodeCategoryEqualityComparer
{
	// Methods

	// RVA: 0xD37360
	public void .ctor() { }

	// RVA: 0xD37368
	public bool Equals(System.Nullable<System.Globalization.UnicodeCategory> left, System.Nullable<System.Globalization.UnicodeCategory> right) { }

	// RVA: 0xD374E4
	public int GetHashCode(System.Nullable<System.Globalization.UnicodeCategory> obj) { }

}

// Namespace: 
private sealed class System_IO_DriveTypeEqualityComparer
{
	// Methods

	// RVA: 0xD37598
	public void .ctor() { }

	// RVA: 0xD375A0
	public bool Equals(DriveType left, DriveType right) { }

	// RVA: 0xD37628
	public int GetHashCode(DriveType obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_DriveTypeEqualityComparer
{
	// Methods

	// RVA: 0xD37650
	public void .ctor() { }

	// RVA: 0xD37658
	public bool Equals(System.Nullable<System.IO.DriveType> left, System.Nullable<System.IO.DriveType> right) { }

	// RVA: 0xD377D4
	public int GetHashCode(System.Nullable<System.IO.DriveType> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAccessEqualityComparer
{
	// Methods

	// RVA: 0xD37888
	public void .ctor() { }

	// RVA: 0xD37890
	public bool Equals(FileAccess left, FileAccess right) { }

	// RVA: 0xD37918
	public int GetHashCode(FileAccess obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAccessEqualityComparer
{
	// Methods

	// RVA: 0xD37940
	public void .ctor() { }

	// RVA: 0xD37948
	public bool Equals(System.Nullable<System.IO.FileAccess> left, System.Nullable<System.IO.FileAccess> right) { }

	// RVA: 0xD37AC4
	public int GetHashCode(System.Nullable<System.IO.FileAccess> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD37B78
	public void .ctor() { }

	// RVA: 0xD37B80
	public bool Equals(FileAttributes left, FileAttributes right) { }

	// RVA: 0xD37C08
	public int GetHashCode(FileAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD37C30
	public void .ctor() { }

	// RVA: 0xD37C38
	public bool Equals(System.Nullable<System.IO.FileAttributes> left, System.Nullable<System.IO.FileAttributes> right) { }

	// RVA: 0xD37DB4
	public int GetHashCode(System.Nullable<System.IO.FileAttributes> obj) { }

}

// Namespace: 
private sealed class System_IO_FileModeEqualityComparer
{
	// Methods

	// RVA: 0xD37E68
	public void .ctor() { }

	// RVA: 0xD37E70
	public bool Equals(FileMode left, FileMode right) { }

	// RVA: 0xD37EF8
	public int GetHashCode(FileMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileModeEqualityComparer
{
	// Methods

	// RVA: 0xD37F20
	public void .ctor() { }

	// RVA: 0xD37F28
	public bool Equals(System.Nullable<System.IO.FileMode> left, System.Nullable<System.IO.FileMode> right) { }

	// RVA: 0xD380A4
	public int GetHashCode(System.Nullable<System.IO.FileMode> obj) { }

}

// Namespace: 
private sealed class System_IO_FileOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD38158
	public void .ctor() { }

	// RVA: 0xD38160
	public bool Equals(FileOptions left, FileOptions right) { }

	// RVA: 0xD381E8
	public int GetHashCode(FileOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD38210
	public void .ctor() { }

	// RVA: 0xD38218
	public bool Equals(System.Nullable<System.IO.FileOptions> left, System.Nullable<System.IO.FileOptions> right) { }

	// RVA: 0xD38394
	public int GetHashCode(System.Nullable<System.IO.FileOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_FileShareEqualityComparer
{
	// Methods

	// RVA: 0xD38448
	public void .ctor() { }

	// RVA: 0xD38450
	public bool Equals(FileShare left, FileShare right) { }

	// RVA: 0xD384D8
	public int GetHashCode(FileShare obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileShareEqualityComparer
{
	// Methods

	// RVA: 0xD38500
	public void .ctor() { }

	// RVA: 0xD38508
	public bool Equals(System.Nullable<System.IO.FileShare> left, System.Nullable<System.IO.FileShare> right) { }

	// RVA: 0xD38684
	public int GetHashCode(System.Nullable<System.IO.FileShare> obj) { }

}

// Namespace: 
private sealed class System_IO_HandleInheritabilityEqualityComparer
{
	// Methods

	// RVA: 0xD38738
	public void .ctor() { }

	// RVA: 0xD38740
	public bool Equals(HandleInheritability left, HandleInheritability right) { }

	// RVA: 0xD387C8
	public int GetHashCode(HandleInheritability obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_HandleInheritabilityEqualityComparer
{
	// Methods

	// RVA: 0xD387F0
	public void .ctor() { }

	// RVA: 0xD387F8
	public bool Equals(System.Nullable<System.IO.HandleInheritability> left, System.Nullable<System.IO.HandleInheritability> right) { }

	// RVA: 0xD38974
	public int GetHashCode(System.Nullable<System.IO.HandleInheritability> obj) { }

}

// Namespace: 
private sealed class System_IO_SearchOptionEqualityComparer
{
	// Methods

	// RVA: 0xD38A28
	public void .ctor() { }

	// RVA: 0xD38A30
	public bool Equals(SearchOption left, SearchOption right) { }

	// RVA: 0xD38AB8
	public int GetHashCode(SearchOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SearchOptionEqualityComparer
{
	// Methods

	// RVA: 0xD38AE0
	public void .ctor() { }

	// RVA: 0xD38AE8
	public bool Equals(System.Nullable<System.IO.SearchOption> left, System.Nullable<System.IO.SearchOption> right) { }

	// RVA: 0xD38C64
	public int GetHashCode(System.Nullable<System.IO.SearchOption> obj) { }

}

// Namespace: 
private sealed class System_IO_SeekOriginEqualityComparer
{
	// Methods

	// RVA: 0xD38D18
	public void .ctor() { }

	// RVA: 0xD38D20
	public bool Equals(SeekOrigin left, SeekOrigin right) { }

	// RVA: 0xD38DA8
	public int GetHashCode(SeekOrigin obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SeekOriginEqualityComparer
{
	// Methods

	// RVA: 0xD38DD0
	public void .ctor() { }

	// RVA: 0xD38DD8
	public bool Equals(System.Nullable<System.IO.SeekOrigin> left, System.Nullable<System.IO.SeekOrigin> right) { }

	// RVA: 0xD38F54
	public int GetHashCode(System.Nullable<System.IO.SeekOrigin> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeAccessRightsEqualityComparer
{
	// Methods

	// RVA: 0xD39008
	public void .ctor() { }

	// RVA: 0xD39010
	public bool Equals(PipeAccessRights left, PipeAccessRights right) { }

	// RVA: 0xD39098
	public int GetHashCode(PipeAccessRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeAccessRightsEqualityComparer
{
	// Methods

	// RVA: 0xD390C0
	public void .ctor() { }

	// RVA: 0xD390C8
	public bool Equals(System.Nullable<System.IO.Pipes.PipeAccessRights> left, System.Nullable<System.IO.Pipes.PipeAccessRights> right) { }

	// RVA: 0xD39244
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeAccessRights> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeDirectionEqualityComparer
{
	// Methods

	// RVA: 0xD392F8
	public void .ctor() { }

	// RVA: 0xD39300
	public bool Equals(PipeDirection left, PipeDirection right) { }

	// RVA: 0xD39388
	public int GetHashCode(PipeDirection obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeDirectionEqualityComparer
{
	// Methods

	// RVA: 0xD393B0
	public void .ctor() { }

	// RVA: 0xD393B8
	public bool Equals(System.Nullable<System.IO.Pipes.PipeDirection> left, System.Nullable<System.IO.Pipes.PipeDirection> right) { }

	// RVA: 0xD39534
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeDirection> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD395E8
	public void .ctor() { }

	// RVA: 0xD395F0
	public bool Equals(PipeOptions left, PipeOptions right) { }

	// RVA: 0xD39678
	public int GetHashCode(PipeOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD396A0
	public void .ctor() { }

	// RVA: 0xD396A8
	public bool Equals(System.Nullable<System.IO.Pipes.PipeOptions> left, System.Nullable<System.IO.Pipes.PipeOptions> right) { }

	// RVA: 0xD39824
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeTransmissionModeEqualityComparer
{
	// Methods

	// RVA: 0xD398D8
	public void .ctor() { }

	// RVA: 0xD398E0
	public bool Equals(PipeTransmissionMode left, PipeTransmissionMode right) { }

	// RVA: 0xD39968
	public int GetHashCode(PipeTransmissionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeTransmissionModeEqualityComparer
{
	// Methods

	// RVA: 0xD39990
	public void .ctor() { }

	// RVA: 0xD39998
	public bool Equals(System.Nullable<System.IO.Pipes.PipeTransmissionMode> left, System.Nullable<System.IO.Pipes.PipeTransmissionMode> right) { }

	// RVA: 0xD39B14
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeTransmissionMode> obj) { }

}

// Namespace: 
private sealed class System_Reflection_AssemblyNameFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD39BC8
	public void .ctor() { }

	// RVA: 0xD39BD0
	public bool Equals(AssemblyNameFlags left, AssemblyNameFlags right) { }

	// RVA: 0xD39C58
	public int GetHashCode(AssemblyNameFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_AssemblyNameFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD39C80
	public void .ctor() { }

	// RVA: 0xD39C88
	public bool Equals(System.Nullable<System.Reflection.AssemblyNameFlags> left, System.Nullable<System.Reflection.AssemblyNameFlags> right) { }

	// RVA: 0xD39E04
	public int GetHashCode(System.Nullable<System.Reflection.AssemblyNameFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_BindingFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD39EB8
	public void .ctor() { }

	// RVA: 0xD39EC0
	public bool Equals(BindingFlags left, BindingFlags right) { }

	// RVA: 0xD39F48
	public int GetHashCode(BindingFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_BindingFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD39F70
	public void .ctor() { }

	// RVA: 0xD39F78
	public bool Equals(System.Nullable<System.Reflection.BindingFlags> left, System.Nullable<System.Reflection.BindingFlags> right) { }

	// RVA: 0xD3A0F4
	public int GetHashCode(System.Nullable<System.Reflection.BindingFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CallingConventionsEqualityComparer
{
	// Methods

	// RVA: 0xD3A1A8
	public void .ctor() { }

	// RVA: 0xD3A1B0
	public bool Equals(CallingConventions left, CallingConventions right) { }

	// RVA: 0xD3A238
	public int GetHashCode(CallingConventions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CallingConventionsEqualityComparer
{
	// Methods

	// RVA: 0xD3A260
	public void .ctor() { }

	// RVA: 0xD3A268
	public bool Equals(System.Nullable<System.Reflection.CallingConventions> left, System.Nullable<System.Reflection.CallingConventions> right) { }

	// RVA: 0xD3A3E4
	public int GetHashCode(System.Nullable<System.Reflection.CallingConventions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeNamedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD3A498
	public void .ctor() { }

	// RVA: 0xD3A4A0
	public bool Equals(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0xD3A524
	public int GetHashCode(CustomAttributeNamedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeNamedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD3A530
	public void .ctor() { }

	// RVA: 0xD3A538
	public bool Equals(System.Nullable<System.Reflection.CustomAttributeNamedArgument> left, System.Nullable<System.Reflection.CustomAttributeNamedArgument> right) { }

	// RVA: 0xD3A6D0
	public int GetHashCode(System.Nullable<System.Reflection.CustomAttributeNamedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeTypedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD3A780
	public void .ctor() { }

	// RVA: 0xD3A788
	public bool Equals(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0xD3A804
	public int GetHashCode(CustomAttributeTypedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeTypedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD3A82C
	public void .ctor() { }

	// RVA: 0xD3A834
	public bool Equals(System.Nullable<System.Reflection.CustomAttributeTypedArgument> left, System.Nullable<System.Reflection.CustomAttributeTypedArgument> right) { }

	// RVA: 0xD3A9BC
	public int GetHashCode(System.Nullable<System.Reflection.CustomAttributeTypedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_EventAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3AA6C
	public void .ctor() { }

	// RVA: 0xD3AA74
	public bool Equals(EventAttributes left, EventAttributes right) { }

	// RVA: 0xD3AAFC
	public int GetHashCode(EventAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_EventAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3AB24
	public void .ctor() { }

	// RVA: 0xD3AB2C
	public bool Equals(System.Nullable<System.Reflection.EventAttributes> left, System.Nullable<System.Reflection.EventAttributes> right) { }

	// RVA: 0xD3ACA8
	public int GetHashCode(System.Nullable<System.Reflection.EventAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ExceptionHandlingClauseOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD3AD5C
	public void .ctor() { }

	// RVA: 0xD3AD64
	public bool Equals(ExceptionHandlingClauseOptions left, ExceptionHandlingClauseOptions right) { }

	// RVA: 0xD3ADEC
	public int GetHashCode(ExceptionHandlingClauseOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ExceptionHandlingClauseOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD3AE14
	public void .ctor() { }

	// RVA: 0xD3AE1C
	public bool Equals(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> left, System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> right) { }

	// RVA: 0xD3AF98
	public int GetHashCode(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_FieldAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3B04C
	public void .ctor() { }

	// RVA: 0xD3B054
	public bool Equals(FieldAttributes left, FieldAttributes right) { }

	// RVA: 0xD3B0DC
	public int GetHashCode(FieldAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_FieldAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3B104
	public void .ctor() { }

	// RVA: 0xD3B10C
	public bool Equals(System.Nullable<System.Reflection.FieldAttributes> left, System.Nullable<System.Reflection.FieldAttributes> right) { }

	// RVA: 0xD3B288
	public int GetHashCode(System.Nullable<System.Reflection.FieldAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_GenericParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3B33C
	public void .ctor() { }

	// RVA: 0xD3B344
	public bool Equals(GenericParameterAttributes left, GenericParameterAttributes right) { }

	// RVA: 0xD3B3CC
	public int GetHashCode(GenericParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_GenericParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3B3F4
	public void .ctor() { }

	// RVA: 0xD3B3FC
	public bool Equals(System.Nullable<System.Reflection.GenericParameterAttributes> left, System.Nullable<System.Reflection.GenericParameterAttributes> right) { }

	// RVA: 0xD3B578
	public int GetHashCode(System.Nullable<System.Reflection.GenericParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ImageFileMachineEqualityComparer
{
	// Methods

	// RVA: 0xD3B62C
	public void .ctor() { }

	// RVA: 0xD3B634
	public bool Equals(ImageFileMachine left, ImageFileMachine right) { }

	// RVA: 0xD3B6BC
	public int GetHashCode(ImageFileMachine obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ImageFileMachineEqualityComparer
{
	// Methods

	// RVA: 0xD3B6E4
	public void .ctor() { }

	// RVA: 0xD3B6EC
	public bool Equals(System.Nullable<System.Reflection.ImageFileMachine> left, System.Nullable<System.Reflection.ImageFileMachine> right) { }

	// RVA: 0xD3B868
	public int GetHashCode(System.Nullable<System.Reflection.ImageFileMachine> obj) { }

}

// Namespace: 
private sealed class System_Reflection_InterfaceMappingEqualityComparer
{
	// Methods

	// RVA: 0xD3B91C
	public void .ctor() { }

	// RVA: 0xD3B924
	public bool Equals(InterfaceMapping left, InterfaceMapping right) { }

	// RVA: 0xD3B9B4
	public int GetHashCode(InterfaceMapping obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_InterfaceMappingEqualityComparer
{
	// Methods

	// RVA: 0xD3BA28
	public void .ctor() { }

	// RVA: 0xD3BA30
	public bool Equals(System.Nullable<System.Reflection.InterfaceMapping> left, System.Nullable<System.Reflection.InterfaceMapping> right) { }

	// RVA: 0xD3BBCC
	public int GetHashCode(System.Nullable<System.Reflection.InterfaceMapping> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MemberTypesEqualityComparer
{
	// Methods

	// RVA: 0xD3BC7C
	public void .ctor() { }

	// RVA: 0xD3BC84
	public bool Equals(MemberTypes left, MemberTypes right) { }

	// RVA: 0xD3BD0C
	public int GetHashCode(MemberTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MemberTypesEqualityComparer
{
	// Methods

	// RVA: 0xD3BD34
	public void .ctor() { }

	// RVA: 0xD3BD3C
	public bool Equals(System.Nullable<System.Reflection.MemberTypes> left, System.Nullable<System.Reflection.MemberTypes> right) { }

	// RVA: 0xD3BEB8
	public int GetHashCode(System.Nullable<System.Reflection.MemberTypes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3BF6C
	public void .ctor() { }

	// RVA: 0xD3BF74
	public bool Equals(MethodAttributes left, MethodAttributes right) { }

	// RVA: 0xD3BFFC
	public int GetHashCode(MethodAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3C024
	public void .ctor() { }

	// RVA: 0xD3C02C
	public bool Equals(System.Nullable<System.Reflection.MethodAttributes> left, System.Nullable<System.Reflection.MethodAttributes> right) { }

	// RVA: 0xD3C1A8
	public int GetHashCode(System.Nullable<System.Reflection.MethodAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodImplAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3C25C
	public void .ctor() { }

	// RVA: 0xD3C264
	public bool Equals(MethodImplAttributes left, MethodImplAttributes right) { }

	// RVA: 0xD3C2EC
	public int GetHashCode(MethodImplAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodImplAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3C314
	public void .ctor() { }

	// RVA: 0xD3C31C
	public bool Equals(System.Nullable<System.Reflection.MethodImplAttributes> left, System.Nullable<System.Reflection.MethodImplAttributes> right) { }

	// RVA: 0xD3C498
	public int GetHashCode(System.Nullable<System.Reflection.MethodImplAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3C54C
	public void .ctor() { }

	// RVA: 0xD3C554
	public bool Equals(ParameterAttributes left, ParameterAttributes right) { }

	// RVA: 0xD3C5DC
	public int GetHashCode(ParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3C604
	public void .ctor() { }

	// RVA: 0xD3C60C
	public bool Equals(System.Nullable<System.Reflection.ParameterAttributes> left, System.Nullable<System.Reflection.ParameterAttributes> right) { }

	// RVA: 0xD3C788
	public int GetHashCode(System.Nullable<System.Reflection.ParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterModifierEqualityComparer
{
	// Methods

	// RVA: 0xD3C83C
	public void .ctor() { }

	// RVA: 0xD3C844
	public bool Equals(ParameterModifier left, ParameterModifier right) { }

	// RVA: 0xD3C8CC
	public int GetHashCode(ParameterModifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterModifierEqualityComparer
{
	// Methods

	// RVA: 0xD3C93C
	public void .ctor() { }

	// RVA: 0xD3C944
	public bool Equals(System.Nullable<System.Reflection.ParameterModifier> left, System.Nullable<System.Reflection.ParameterModifier> right) { }

	// RVA: 0xD3CAC0
	public int GetHashCode(System.Nullable<System.Reflection.ParameterModifier> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PortableExecutableKindsEqualityComparer
{
	// Methods

	// RVA: 0xD3CB74
	public void .ctor() { }

	// RVA: 0xD3CB7C
	public bool Equals(PortableExecutableKinds left, PortableExecutableKinds right) { }

	// RVA: 0xD3CC04
	public int GetHashCode(PortableExecutableKinds obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PortableExecutableKindsEqualityComparer
{
	// Methods

	// RVA: 0xD3CC2C
	public void .ctor() { }

	// RVA: 0xD3CC34
	public bool Equals(System.Nullable<System.Reflection.PortableExecutableKinds> left, System.Nullable<System.Reflection.PortableExecutableKinds> right) { }

	// RVA: 0xD3CDB0
	public int GetHashCode(System.Nullable<System.Reflection.PortableExecutableKinds> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ProcessorArchitectureEqualityComparer
{
	// Methods

	// RVA: 0xD3CE64
	public void .ctor() { }

	// RVA: 0xD3CE6C
	public bool Equals(ProcessorArchitecture left, ProcessorArchitecture right) { }

	// RVA: 0xD3CEF4
	public int GetHashCode(ProcessorArchitecture obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ProcessorArchitectureEqualityComparer
{
	// Methods

	// RVA: 0xD3CF1C
	public void .ctor() { }

	// RVA: 0xD3CF24
	public bool Equals(System.Nullable<System.Reflection.ProcessorArchitecture> left, System.Nullable<System.Reflection.ProcessorArchitecture> right) { }

	// RVA: 0xD3D0A0
	public int GetHashCode(System.Nullable<System.Reflection.ProcessorArchitecture> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PropertyAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3D154
	public void .ctor() { }

	// RVA: 0xD3D15C
	public bool Equals(PropertyAttributes left, PropertyAttributes right) { }

	// RVA: 0xD3D1E4
	public int GetHashCode(PropertyAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PropertyAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3D20C
	public void .ctor() { }

	// RVA: 0xD3D214
	public bool Equals(System.Nullable<System.Reflection.PropertyAttributes> left, System.Nullable<System.Reflection.PropertyAttributes> right) { }

	// RVA: 0xD3D390
	public int GetHashCode(System.Nullable<System.Reflection.PropertyAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3D444
	public void .ctor() { }

	// RVA: 0xD3D44C
	public bool Equals(ResourceAttributes left, ResourceAttributes right) { }

	// RVA: 0xD3D4D4
	public int GetHashCode(ResourceAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3D4FC
	public void .ctor() { }

	// RVA: 0xD3D504
	public bool Equals(System.Nullable<System.Reflection.ResourceAttributes> left, System.Nullable<System.Reflection.ResourceAttributes> right) { }

	// RVA: 0xD3D680
	public int GetHashCode(System.Nullable<System.Reflection.ResourceAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceLocationEqualityComparer
{
	// Methods

	// RVA: 0xD3D734
	public void .ctor() { }

	// RVA: 0xD3D73C
	public bool Equals(ResourceLocation left, ResourceLocation right) { }

	// RVA: 0xD3D7C4
	public int GetHashCode(ResourceLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceLocationEqualityComparer
{
	// Methods

	// RVA: 0xD3D7EC
	public void .ctor() { }

	// RVA: 0xD3D7F4
	public bool Equals(System.Nullable<System.Reflection.ResourceLocation> left, System.Nullable<System.Reflection.ResourceLocation> right) { }

	// RVA: 0xD3D970
	public int GetHashCode(System.Nullable<System.Reflection.ResourceLocation> obj) { }

}

// Namespace: 
private sealed class System_Reflection_TypeAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3DA24
	public void .ctor() { }

	// RVA: 0xD3DA2C
	public bool Equals(TypeAttributes left, TypeAttributes right) { }

	// RVA: 0xD3DAB4
	public int GetHashCode(TypeAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_TypeAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD3DADC
	public void .ctor() { }

	// RVA: 0xD3DAE4
	public bool Equals(System.Nullable<System.Reflection.TypeAttributes> left, System.Nullable<System.Reflection.TypeAttributes> right) { }

	// RVA: 0xD3DC60
	public int GetHashCode(System.Nullable<System.Reflection.TypeAttributes> obj) { }

}

// Namespace: 
private sealed class System_Resources_UltimateResourceFallbackLocationEqualityComparer
{
	// Methods

	// RVA: 0xD3DD14
	public void .ctor() { }

	// RVA: 0xD3DD1C
	public bool Equals(UltimateResourceFallbackLocation left, UltimateResourceFallbackLocation right) { }

	// RVA: 0xD3DDA4
	public int GetHashCode(UltimateResourceFallbackLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Resources_UltimateResourceFallbackLocationEqualityComparer
{
	// Methods

	// RVA: 0xD3DDCC
	public void .ctor() { }

	// RVA: 0xD3DDD4
	public bool Equals(System.Nullable<System.Resources.UltimateResourceFallbackLocation> left, System.Nullable<System.Resources.UltimateResourceFallbackLocation> right) { }

	// RVA: 0xD3DF50
	public int GetHashCode(System.Nullable<System.Resources.UltimateResourceFallbackLocation> obj) { }

}

// Namespace: 
private sealed class System_Runtime_GCLatencyModeEqualityComparer
{
	// Methods

	// RVA: 0xD3E004
	public void .ctor() { }

	// RVA: 0xD3E00C
	public bool Equals(GCLatencyMode left, GCLatencyMode right) { }

	// RVA: 0xD3E094
	public int GetHashCode(GCLatencyMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_GCLatencyModeEqualityComparer
{
	// Methods

	// RVA: 0xD3E0BC
	public void .ctor() { }

	// RVA: 0xD3E0C4
	public bool Equals(System.Nullable<System.Runtime.GCLatencyMode> left, System.Nullable<System.Runtime.GCLatencyMode> right) { }

	// RVA: 0xD3E240
	public int GetHashCode(System.Nullable<System.Runtime.GCLatencyMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer
{
	// Methods

	// RVA: 0xD3E2F4
	public void .ctor() { }

	// RVA: 0xD3E2FC
	public bool Equals(CompilationRelaxations left, CompilationRelaxations right) { }

	// RVA: 0xD3E384
	public int GetHashCode(CompilationRelaxations obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer
{
	// Methods

	// RVA: 0xD3E3AC
	public void .ctor() { }

	// RVA: 0xD3E3B4
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> left, System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> right) { }

	// RVA: 0xD3E530
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_LoadHintEqualityComparer
{
	// Methods

	// RVA: 0xD3E5E4
	public void .ctor() { }

	// RVA: 0xD3E5EC
	public bool Equals(LoadHint left, LoadHint right) { }

	// RVA: 0xD3E674
	public int GetHashCode(LoadHint obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_LoadHintEqualityComparer
{
	// Methods

	// RVA: 0xD3E69C
	public void .ctor() { }

	// RVA: 0xD3E6A4
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.LoadHint> left, System.Nullable<System.Runtime.CompilerServices.LoadHint> right) { }

	// RVA: 0xD3E820
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.LoadHint> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodCodeTypeEqualityComparer
{
	// Methods

	// RVA: 0xD3E8D4
	public void .ctor() { }

	// RVA: 0xD3E8DC
	public bool Equals(MethodCodeType left, MethodCodeType right) { }

	// RVA: 0xD3E964
	public int GetHashCode(MethodCodeType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodCodeTypeEqualityComparer
{
	// Methods

	// RVA: 0xD3E98C
	public void .ctor() { }

	// RVA: 0xD3E994
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> left, System.Nullable<System.Runtime.CompilerServices.MethodCodeType> right) { }

	// RVA: 0xD3EB10
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodImplOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD3EBC4
	public void .ctor() { }

	// RVA: 0xD3EBCC
	public bool Equals(MethodImplOptions left, MethodImplOptions right) { }

	// RVA: 0xD3EC54
	public int GetHashCode(MethodImplOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodImplOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD3EC7C
	public void .ctor() { }

	// RVA: 0xD3EC84
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> left, System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> right) { }

	// RVA: 0xD3EE00
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_CerEqualityComparer
{
	// Methods

	// RVA: 0xD3EEB4
	public void .ctor() { }

	// RVA: 0xD3EEBC
	public bool Equals(Cer left, Cer right) { }

	// RVA: 0xD3EF44
	public int GetHashCode(Cer obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_CerEqualityComparer
{
	// Methods

	// RVA: 0xD3EF6C
	public void .ctor() { }

	// RVA: 0xD3EF74
	public bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Cer> left, System.Nullable<System.Runtime.ConstrainedExecution.Cer> right) { }

	// RVA: 0xD3F0F0
	public int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Cer> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_ConsistencyEqualityComparer
{
	// Methods

	// RVA: 0xD3F1A4
	public void .ctor() { }

	// RVA: 0xD3F1AC
	public bool Equals(Consistency left, Consistency right) { }

	// RVA: 0xD3F234
	public int GetHashCode(Consistency obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_ConsistencyEqualityComparer
{
	// Methods

	// RVA: 0xD3F25C
	public void .ctor() { }

	// RVA: 0xD3F264
	public bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> left, System.Nullable<System.Runtime.ConstrainedExecution.Consistency> right) { }

	// RVA: 0xD3F3E0
	public int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ArrayWithOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD3F494
	public void .ctor() { }

	// RVA: 0xD3F49C
	public bool Equals(ArrayWithOffset left, ArrayWithOffset right) { }

	// RVA: 0xD3F4CC
	public int GetHashCode(ArrayWithOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ArrayWithOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD3F4F4
	public void .ctor() { }

	// RVA: 0xD3F4FC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> left, System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> right) { }

	// RVA: 0xD3F65C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD3F70C
	public void .ctor() { }

	// RVA: 0xD3F714
	public bool Equals(AssemblyRegistrationFlags left, AssemblyRegistrationFlags right) { }

	// RVA: 0xD3F79C
	public int GetHashCode(AssemblyRegistrationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD3F7C4
	public void .ctor() { }

	// RVA: 0xD3F7CC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> left, System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> right) { }

	// RVA: 0xD3F948
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CallingConventionEqualityComparer
{
	// Methods

	// RVA: 0xD3F9FC
	public void .ctor() { }

	// RVA: 0xD3FA04
	public bool Equals(CallingConvention left, CallingConvention right) { }

	// RVA: 0xD3FA8C
	public int GetHashCode(CallingConvention obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CallingConventionEqualityComparer
{
	// Methods

	// RVA: 0xD3FAB4
	public void .ctor() { }

	// RVA: 0xD3FABC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.CallingConvention> left, System.Nullable<System.Runtime.InteropServices.CallingConvention> right) { }

	// RVA: 0xD3FC38
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.CallingConvention> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CharSetEqualityComparer
{
	// Methods

	// RVA: 0xD3FCEC
	public void .ctor() { }

	// RVA: 0xD3FCF4
	public bool Equals(CharSet left, CharSet right) { }

	// RVA: 0xD3FD7C
	public int GetHashCode(CharSet obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CharSetEqualityComparer
{
	// Methods

	// RVA: 0xD3FDA4
	public void .ctor() { }

	// RVA: 0xD3FDAC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.CharSet> left, System.Nullable<System.Runtime.InteropServices.CharSet> right) { }

	// RVA: 0xD3FF28
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.CharSet> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD3FFDC
	public void .ctor() { }

	// RVA: 0xD3FFE4
	public bool Equals(ClassInterfaceType left, ClassInterfaceType right) { }

	// RVA: 0xD4006C
	public int GetHashCode(ClassInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD40094
	public void .ctor() { }

	// RVA: 0xD4009C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> right) { }

	// RVA: 0xD40218
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD402CC
	public void .ctor() { }

	// RVA: 0xD402D4
	public bool Equals(ComInterfaceType left, ComInterfaceType right) { }

	// RVA: 0xD4035C
	public int GetHashCode(ComInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD40384
	public void .ctor() { }

	// RVA: 0xD4038C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ComInterfaceType> right) { }

	// RVA: 0xD40508
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComMemberTypeEqualityComparer
{
	// Methods

	// RVA: 0xD405BC
	public void .ctor() { }

	// RVA: 0xD405C4
	public bool Equals(ComMemberType left, ComMemberType right) { }

	// RVA: 0xD4064C
	public int GetHashCode(ComMemberType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComMemberTypeEqualityComparer
{
	// Methods

	// RVA: 0xD40674
	public void .ctor() { }

	// RVA: 0xD4067C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ComMemberType> left, System.Nullable<System.Runtime.InteropServices.ComMemberType> right) { }

	// RVA: 0xD407F8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComMemberType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ExporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD408AC
	public void .ctor() { }

	// RVA: 0xD408B4
	public bool Equals(ExporterEventKind left, ExporterEventKind right) { }

	// RVA: 0xD4093C
	public int GetHashCode(ExporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ExporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD40964
	public void .ctor() { }

	// RVA: 0xD4096C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ExporterEventKind> right) { }

	// RVA: 0xD40AE8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleEqualityComparer
{
	// Methods

	// RVA: 0xD40B9C
	public void .ctor() { }

	// RVA: 0xD40BA4
	public bool Equals(GCHandle left, GCHandle right) { }

	// RVA: 0xD40C1C
	public int GetHashCode(GCHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleEqualityComparer
{
	// Methods

	// RVA: 0xD40C44
	public void .ctor() { }

	// RVA: 0xD40C4C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandle> left, System.Nullable<System.Runtime.InteropServices.GCHandle> right) { }

	// RVA: 0xD40DB8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleTypeEqualityComparer
{
	// Methods

	// RVA: 0xD40E6C
	public void .ctor() { }

	// RVA: 0xD40E74
	public bool Equals(GCHandleType left, GCHandleType right) { }

	// RVA: 0xD40EFC
	public int GetHashCode(GCHandleType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleTypeEqualityComparer
{
	// Methods

	// RVA: 0xD40F24
	public void .ctor() { }

	// RVA: 0xD40F2C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandleType> left, System.Nullable<System.Runtime.InteropServices.GCHandleType> right) { }

	// RVA: 0xD410A8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandleType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_HandleRefEqualityComparer
{
	// Methods

	// RVA: 0xD4115C
	public void .ctor() { }

	// RVA: 0xD41164
	public bool Equals(HandleRef left, HandleRef right) { }

	// RVA: 0xD411FC
	public int GetHashCode(HandleRef obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_HandleRefEqualityComparer
{
	// Methods

	// RVA: 0xD41270
	public void .ctor() { }

	// RVA: 0xD41278
	public bool Equals(System.Nullable<System.Runtime.InteropServices.HandleRef> left, System.Nullable<System.Runtime.InteropServices.HandleRef> right) { }

	// RVA: 0xD4140C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.HandleRef> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ImporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD414BC
	public void .ctor() { }

	// RVA: 0xD414C4
	public bool Equals(ImporterEventKind left, ImporterEventKind right) { }

	// RVA: 0xD4154C
	public int GetHashCode(ImporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ImporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD41574
	public void .ctor() { }

	// RVA: 0xD4157C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ImporterEventKind> right) { }

	// RVA: 0xD416F8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_LayoutKindEqualityComparer
{
	// Methods

	// RVA: 0xD417AC
	public void .ctor() { }

	// RVA: 0xD417B4
	public bool Equals(LayoutKind left, LayoutKind right) { }

	// RVA: 0xD4183C
	public int GetHashCode(LayoutKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_LayoutKindEqualityComparer
{
	// Methods

	// RVA: 0xD41864
	public void .ctor() { }

	// RVA: 0xD4186C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.LayoutKind> left, System.Nullable<System.Runtime.InteropServices.LayoutKind> right) { }

	// RVA: 0xD419E8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.LayoutKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationClassContextEqualityComparer
{
	// Methods

	// RVA: 0xD41A9C
	public void .ctor() { }

	// RVA: 0xD41AA4
	public bool Equals(RegistrationClassContext left, RegistrationClassContext right) { }

	// RVA: 0xD41B2C
	public int GetHashCode(RegistrationClassContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationClassContextEqualityComparer
{
	// Methods

	// RVA: 0xD41B54
	public void .ctor() { }

	// RVA: 0xD41B5C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> left, System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> right) { }

	// RVA: 0xD41CD8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer
{
	// Methods

	// RVA: 0xD41D8C
	public void .ctor() { }

	// RVA: 0xD41D94
	public bool Equals(RegistrationConnectionType left, RegistrationConnectionType right) { }

	// RVA: 0xD41E1C
	public int GetHashCode(RegistrationConnectionType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer
{
	// Methods

	// RVA: 0xD41E44
	public void .ctor() { }

	// RVA: 0xD41E4C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> left, System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> right) { }

	// RVA: 0xD41FC8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4207C
	public void .ctor() { }

	// RVA: 0xD42084
	public bool Equals(TypeLibExporterFlags left, TypeLibExporterFlags right) { }

	// RVA: 0xD4210C
	public int GetHashCode(TypeLibExporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD42134
	public void .ctor() { }

	// RVA: 0xD4213C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> right) { }

	// RVA: 0xD422B8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4236C
	public void .ctor() { }

	// RVA: 0xD42374
	public bool Equals(TypeLibFuncFlags left, TypeLibFuncFlags right) { }

	// RVA: 0xD423FC
	public int GetHashCode(TypeLibFuncFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD42424
	public void .ctor() { }

	// RVA: 0xD4242C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> right) { }

	// RVA: 0xD425A8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4265C
	public void .ctor() { }

	// RVA: 0xD42664
	public bool Equals(TypeLibImporterFlags left, TypeLibImporterFlags right) { }

	// RVA: 0xD426EC
	public int GetHashCode(TypeLibImporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD42714
	public void .ctor() { }

	// RVA: 0xD4271C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> right) { }

	// RVA: 0xD42898
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4294C
	public void .ctor() { }

	// RVA: 0xD42954
	public bool Equals(TypeLibTypeFlags left, TypeLibTypeFlags right) { }

	// RVA: 0xD429DC
	public int GetHashCode(TypeLibTypeFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD42A04
	public void .ctor() { }

	// RVA: 0xD42A0C
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> right) { }

	// RVA: 0xD42B88
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD42C3C
	public void .ctor() { }

	// RVA: 0xD42C44
	public bool Equals(TypeLibVarFlags left, TypeLibVarFlags right) { }

	// RVA: 0xD42CCC
	public int GetHashCode(TypeLibVarFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD42CF4
	public void .ctor() { }

	// RVA: 0xD42CFC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> right) { }

	// RVA: 0xD42E78
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_UnmanagedTypeEqualityComparer
{
	// Methods

	// RVA: 0xD42F2C
	public void .ctor() { }

	// RVA: 0xD42F34
	public bool Equals(UnmanagedType left, UnmanagedType right) { }

	// RVA: 0xD42FBC
	public int GetHashCode(UnmanagedType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_UnmanagedTypeEqualityComparer
{
	// Methods

	// RVA: 0xD42FE4
	public void .ctor() { }

	// RVA: 0xD42FEC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.UnmanagedType> left, System.Nullable<System.Runtime.InteropServices.UnmanagedType> right) { }

	// RVA: 0xD43168
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.UnmanagedType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_VarEnumEqualityComparer
{
	// Methods

	// RVA: 0xD4321C
	public void .ctor() { }

	// RVA: 0xD43224
	public bool Equals(VarEnum left, VarEnum right) { }

	// RVA: 0xD432AC
	public int GetHashCode(VarEnum obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_VarEnumEqualityComparer
{
	// Methods

	// RVA: 0xD432D4
	public void .ctor() { }

	// RVA: 0xD432DC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.VarEnum> left, System.Nullable<System.Runtime.InteropServices.VarEnum> right) { }

	// RVA: 0xD43458
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.VarEnum> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_CustomErrorsModesEqualityComparer
{
	// Methods

	// RVA: 0xD4350C
	public void .ctor() { }

	// RVA: 0xD43514
	public bool Equals(CustomErrorsModes left, CustomErrorsModes right) { }

	// RVA: 0xD4359C
	public int GetHashCode(CustomErrorsModes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_CustomErrorsModesEqualityComparer
{
	// Methods

	// RVA: 0xD435C4
	public void .ctor() { }

	// RVA: 0xD435CC
	public bool Equals(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> left, System.Nullable<System.Runtime.Remoting.CustomErrorsModes> right) { }

	// RVA: 0xD43748
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_WellKnownObjectModeEqualityComparer
{
	// Methods

	// RVA: 0xD437FC
	public void .ctor() { }

	// RVA: 0xD43804
	public bool Equals(WellKnownObjectMode left, WellKnownObjectMode right) { }

	// RVA: 0xD4388C
	public int GetHashCode(WellKnownObjectMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_WellKnownObjectModeEqualityComparer
{
	// Methods

	// RVA: 0xD438B4
	public void .ctor() { }

	// RVA: 0xD438BC
	public bool Equals(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> left, System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> right) { }

	// RVA: 0xD43A38
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer
{
	// Methods

	// RVA: 0xD43AEC
	public void .ctor() { }

	// RVA: 0xD43AF4
	public bool Equals(ActivatorLevel left, ActivatorLevel right) { }

	// RVA: 0xD43B7C
	public int GetHashCode(ActivatorLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer
{
	// Methods

	// RVA: 0xD43BA4
	public void .ctor() { }

	// RVA: 0xD43BAC
	public bool Equals(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> left, System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> right) { }

	// RVA: 0xD43D28
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Channels_ServerProcessingEqualityComparer
{
	// Methods

	// RVA: 0xD43DDC
	public void .ctor() { }

	// RVA: 0xD43DE4
	public bool Equals(ServerProcessing left, ServerProcessing right) { }

	// RVA: 0xD43E6C
	public int GetHashCode(ServerProcessing obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Channels_ServerProcessingEqualityComparer
{
	// Methods

	// RVA: 0xD43E94
	public void .ctor() { }

	// RVA: 0xD43E9C
	public bool Equals(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> left, System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> right) { }

	// RVA: 0xD44018
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer
{
	// Methods

	// RVA: 0xD440CC
	public void .ctor() { }

	// RVA: 0xD440D4
	public bool Equals(LeaseState left, LeaseState right) { }

	// RVA: 0xD4415C
	public int GetHashCode(LeaseState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer
{
	// Methods

	// RVA: 0xD44184
	public void .ctor() { }

	// RVA: 0xD4418C
	public bool Equals(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> left, System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> right) { }

	// RVA: 0xD44308
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_SoapOptionEqualityComparer
{
	// Methods

	// RVA: 0xD443BC
	public void .ctor() { }

	// RVA: 0xD443C4
	public bool Equals(SoapOption left, SoapOption right) { }

	// RVA: 0xD4444C
	public int GetHashCode(SoapOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_SoapOptionEqualityComparer
{
	// Methods

	// RVA: 0xD44474
	public void .ctor() { }

	// RVA: 0xD4447C
	public bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> left, System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> right) { }

	// RVA: 0xD445F8
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer
{
	// Methods

	// RVA: 0xD446AC
	public void .ctor() { }

	// RVA: 0xD446B4
	public bool Equals(XmlFieldOrderOption left, XmlFieldOrderOption right) { }

	// RVA: 0xD4473C
	public int GetHashCode(XmlFieldOrderOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer
{
	// Methods

	// RVA: 0xD44764
	public void .ctor() { }

	// RVA: 0xD4476C
	public bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> left, System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> right) { }

	// RVA: 0xD448E8
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_SerializationEntryEqualityComparer
{
	// Methods

	// RVA: 0xD4499C
	public void .ctor() { }

	// RVA: 0xD449A4
	public bool Equals(SerializationEntry left, SerializationEntry right) { }

	// RVA: 0xD44A44
	public int GetHashCode(SerializationEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_SerializationEntryEqualityComparer
{
	// Methods

	// RVA: 0xD44AC0
	public void .ctor() { }

	// RVA: 0xD44AC8
	public bool Equals(System.Nullable<System.Runtime.Serialization.SerializationEntry> left, System.Nullable<System.Runtime.Serialization.SerializationEntry> right) { }

	// RVA: 0xD44C7C
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.SerializationEntry> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextEqualityComparer
{
	// Methods

	// RVA: 0xD44D2C
	public void .ctor() { }

	// RVA: 0xD44D34
	public bool Equals(StreamingContext left, StreamingContext right) { }

	// RVA: 0xD44DB0
	public int GetHashCode(StreamingContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextEqualityComparer
{
	// Methods

	// RVA: 0xD44DB8
	public void .ctor() { }

	// RVA: 0xD44DC0
	public bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContext> left, System.Nullable<System.Runtime.Serialization.StreamingContext> right) { }

	// RVA: 0xD44F48
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextStatesEqualityComparer
{
	// Methods

	// RVA: 0xD44FF8
	public void .ctor() { }

	// RVA: 0xD45000
	public bool Equals(StreamingContextStates left, StreamingContextStates right) { }

	// RVA: 0xD45088
	public int GetHashCode(StreamingContextStates obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextStatesEqualityComparer
{
	// Methods

	// RVA: 0xD450B0
	public void .ctor() { }

	// RVA: 0xD450B8
	public bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContextStates> left, System.Nullable<System.Runtime.Serialization.StreamingContextStates> right) { }

	// RVA: 0xD45234
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContextStates> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer
{
	// Methods

	// RVA: 0xD452E8
	public void .ctor() { }

	// RVA: 0xD452F0
	public bool Equals(FormatterAssemblyStyle left, FormatterAssemblyStyle right) { }

	// RVA: 0xD45378
	public int GetHashCode(FormatterAssemblyStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer
{
	// Methods

	// RVA: 0xD453A0
	public void .ctor() { }

	// RVA: 0xD453A8
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> right) { }

	// RVA: 0xD45524
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer
{
	// Methods

	// RVA: 0xD455D8
	public void .ctor() { }

	// RVA: 0xD455E0
	public bool Equals(FormatterTypeStyle left, FormatterTypeStyle right) { }

	// RVA: 0xD45668
	public int GetHashCode(FormatterTypeStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer
{
	// Methods

	// RVA: 0xD45690
	public void .ctor() { }

	// RVA: 0xD45698
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> right) { }

	// RVA: 0xD45814
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer
{
	// Methods

	// RVA: 0xD458C8
	public void .ctor() { }

	// RVA: 0xD458D0
	public bool Equals(TypeFilterLevel left, TypeFilterLevel right) { }

	// RVA: 0xD45958
	public int GetHashCode(TypeFilterLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer
{
	// Methods

	// RVA: 0xD45980
	public void .ctor() { }

	// RVA: 0xD45988
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> left, System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> right) { }

	// RVA: 0xD45B04
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Versioning_ResourceScopeEqualityComparer
{
	// Methods

	// RVA: 0xD45BB8
	public void .ctor() { }

	// RVA: 0xD45BC0
	public bool Equals(ResourceScope left, ResourceScope right) { }

	// RVA: 0xD45C48
	public int GetHashCode(ResourceScope obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Versioning_ResourceScopeEqualityComparer
{
	// Methods

	// RVA: 0xD45C70
	public void .ctor() { }

	// RVA: 0xD45C78
	public bool Equals(System.Nullable<System.Runtime.Versioning.ResourceScope> left, System.Nullable<System.Runtime.Versioning.ResourceScope> right) { }

	// RVA: 0xD45DF4
	public int GetHashCode(System.Nullable<System.Runtime.Versioning.ResourceScope> obj) { }

}

// Namespace: 
private sealed class System_Security_HostSecurityManagerOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD45EA8
	public void .ctor() { }

	// RVA: 0xD45EB0
	public bool Equals(HostSecurityManagerOptions left, HostSecurityManagerOptions right) { }

	// RVA: 0xD45F38
	public int GetHashCode(HostSecurityManagerOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_HostSecurityManagerOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD45F60
	public void .ctor() { }

	// RVA: 0xD45F68
	public bool Equals(System.Nullable<System.Security.HostSecurityManagerOptions> left, System.Nullable<System.Security.HostSecurityManagerOptions> right) { }

	// RVA: 0xD460E4
	public int GetHashCode(System.Nullable<System.Security.HostSecurityManagerOptions> obj) { }

}

// Namespace: 
private sealed class System_Security_PolicyLevelTypeEqualityComparer
{
	// Methods

	// RVA: 0xD46198
	public void .ctor() { }

	// RVA: 0xD461A0
	public bool Equals(PolicyLevelType left, PolicyLevelType right) { }

	// RVA: 0xD46228
	public int GetHashCode(PolicyLevelType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_PolicyLevelTypeEqualityComparer
{
	// Methods

	// RVA: 0xD46250
	public void .ctor() { }

	// RVA: 0xD46258
	public bool Equals(System.Nullable<System.Security.PolicyLevelType> left, System.Nullable<System.Security.PolicyLevelType> right) { }

	// RVA: 0xD463D4
	public int GetHashCode(System.Nullable<System.Security.PolicyLevelType> obj) { }

}

// Namespace: 
private sealed class System_Security_SecurityZoneEqualityComparer
{
	// Methods

	// RVA: 0xD46488
	public void .ctor() { }

	// RVA: 0xD46490
	public bool Equals(SecurityZone left, SecurityZone right) { }

	// RVA: 0xD46518
	public int GetHashCode(SecurityZone obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_SecurityZoneEqualityComparer
{
	// Methods

	// RVA: 0xD46540
	public void .ctor() { }

	// RVA: 0xD46548
	public bool Equals(System.Nullable<System.Security.SecurityZone> left, System.Nullable<System.Security.SecurityZone> right) { }

	// RVA: 0xD466C4
	public int GetHashCode(System.Nullable<System.Security.SecurityZone> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlActionsEqualityComparer
{
	// Methods

	// RVA: 0xD46778
	public void .ctor() { }

	// RVA: 0xD46780
	public bool Equals(AccessControlActions left, AccessControlActions right) { }

	// RVA: 0xD46808
	public int GetHashCode(AccessControlActions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlActionsEqualityComparer
{
	// Methods

	// RVA: 0xD46830
	public void .ctor() { }

	// RVA: 0xD46838
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlActions> left, System.Nullable<System.Security.AccessControl.AccessControlActions> right) { }

	// RVA: 0xD469B4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlActions> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlModificationEqualityComparer
{
	// Methods

	// RVA: 0xD46A68
	public void .ctor() { }

	// RVA: 0xD46A70
	public bool Equals(AccessControlModification left, AccessControlModification right) { }

	// RVA: 0xD46AF8
	public int GetHashCode(AccessControlModification obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlModificationEqualityComparer
{
	// Methods

	// RVA: 0xD46B20
	public void .ctor() { }

	// RVA: 0xD46B28
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlModification> left, System.Nullable<System.Security.AccessControl.AccessControlModification> right) { }

	// RVA: 0xD46CA4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlModification> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlSectionsEqualityComparer
{
	// Methods

	// RVA: 0xD46D58
	public void .ctor() { }

	// RVA: 0xD46D60
	public bool Equals(AccessControlSections left, AccessControlSections right) { }

	// RVA: 0xD46DE8
	public int GetHashCode(AccessControlSections obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlSectionsEqualityComparer
{
	// Methods

	// RVA: 0xD46E10
	public void .ctor() { }

	// RVA: 0xD46E18
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlSections> left, System.Nullable<System.Security.AccessControl.AccessControlSections> right) { }

	// RVA: 0xD46F94
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlSections> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlTypeEqualityComparer
{
	// Methods

	// RVA: 0xD47048
	public void .ctor() { }

	// RVA: 0xD47050
	public bool Equals(AccessControlType left, AccessControlType right) { }

	// RVA: 0xD470D8
	public int GetHashCode(AccessControlType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlTypeEqualityComparer
{
	// Methods

	// RVA: 0xD47100
	public void .ctor() { }

	// RVA: 0xD47108
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlType> left, System.Nullable<System.Security.AccessControl.AccessControlType> right) { }

	// RVA: 0xD47284
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD47338
	public void .ctor() { }

	// RVA: 0xD47340
	public bool Equals(AceFlags left, AceFlags right) { }

	// RVA: 0xD473C8
	public int GetHashCode(AceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD473F0
	public void .ctor() { }

	// RVA: 0xD473F8
	public bool Equals(System.Nullable<System.Security.AccessControl.AceFlags> left, System.Nullable<System.Security.AccessControl.AceFlags> right) { }

	// RVA: 0xD47574
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceQualifierEqualityComparer
{
	// Methods

	// RVA: 0xD47628
	public void .ctor() { }

	// RVA: 0xD47630
	public bool Equals(AceQualifier left, AceQualifier right) { }

	// RVA: 0xD476B8
	public int GetHashCode(AceQualifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceQualifierEqualityComparer
{
	// Methods

	// RVA: 0xD476E0
	public void .ctor() { }

	// RVA: 0xD476E8
	public bool Equals(System.Nullable<System.Security.AccessControl.AceQualifier> left, System.Nullable<System.Security.AccessControl.AceQualifier> right) { }

	// RVA: 0xD47864
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceQualifier> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD47918
	public void .ctor() { }

	// RVA: 0xD47920
	public bool Equals(AceType left, AceType right) { }

	// RVA: 0xD479A8
	public int GetHashCode(AceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD479D0
	public void .ctor() { }

	// RVA: 0xD479D8
	public bool Equals(System.Nullable<System.Security.AccessControl.AceType> left, System.Nullable<System.Security.AccessControl.AceType> right) { }

	// RVA: 0xD47B54
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AuditFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD47C08
	public void .ctor() { }

	// RVA: 0xD47C10
	public bool Equals(AuditFlags left, AuditFlags right) { }

	// RVA: 0xD47C98
	public int GetHashCode(AuditFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AuditFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD47CC0
	public void .ctor() { }

	// RVA: 0xD47CC8
	public bool Equals(System.Nullable<System.Security.AccessControl.AuditFlags> left, System.Nullable<System.Security.AccessControl.AuditFlags> right) { }

	// RVA: 0xD47E44
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AuditFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CompoundAceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD47EF8
	public void .ctor() { }

	// RVA: 0xD47F00
	public bool Equals(CompoundAceType left, CompoundAceType right) { }

	// RVA: 0xD47F88
	public int GetHashCode(CompoundAceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CompoundAceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD47FB0
	public void .ctor() { }

	// RVA: 0xD47FB8
	public bool Equals(System.Nullable<System.Security.AccessControl.CompoundAceType> left, System.Nullable<System.Security.AccessControl.CompoundAceType> right) { }

	// RVA: 0xD48134
	public int GetHashCode(System.Nullable<System.Security.AccessControl.CompoundAceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ControlFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD481E8
	public void .ctor() { }

	// RVA: 0xD481F0
	public bool Equals(ControlFlags left, ControlFlags right) { }

	// RVA: 0xD48278
	public int GetHashCode(ControlFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ControlFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD482A0
	public void .ctor() { }

	// RVA: 0xD482A8
	public bool Equals(System.Nullable<System.Security.AccessControl.ControlFlags> left, System.Nullable<System.Security.AccessControl.ControlFlags> right) { }

	// RVA: 0xD48424
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ControlFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CryptoKeyRightsEqualityComparer
{
	// Methods

	// RVA: 0xD484D8
	public void .ctor() { }

	// RVA: 0xD484E0
	public bool Equals(CryptoKeyRights left, CryptoKeyRights right) { }

	// RVA: 0xD48568
	public int GetHashCode(CryptoKeyRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CryptoKeyRightsEqualityComparer
{
	// Methods

	// RVA: 0xD48590
	public void .ctor() { }

	// RVA: 0xD48598
	public bool Equals(System.Nullable<System.Security.AccessControl.CryptoKeyRights> left, System.Nullable<System.Security.AccessControl.CryptoKeyRights> right) { }

	// RVA: 0xD48714
	public int GetHashCode(System.Nullable<System.Security.AccessControl.CryptoKeyRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_EventWaitHandleRightsEqualityComparer
{
	// Methods

	// RVA: 0xD487C8
	public void .ctor() { }

	// RVA: 0xD487D0
	public bool Equals(EventWaitHandleRights left, EventWaitHandleRights right) { }

	// RVA: 0xD48858
	public int GetHashCode(EventWaitHandleRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_EventWaitHandleRightsEqualityComparer
{
	// Methods

	// RVA: 0xD48880
	public void .ctor() { }

	// RVA: 0xD48888
	public bool Equals(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> left, System.Nullable<System.Security.AccessControl.EventWaitHandleRights> right) { }

	// RVA: 0xD48A04
	public int GetHashCode(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_FileSystemRightsEqualityComparer
{
	// Methods

	// RVA: 0xD48AB8
	public void .ctor() { }

	// RVA: 0xD48AC0
	public bool Equals(FileSystemRights left, FileSystemRights right) { }

	// RVA: 0xD48B48
	public int GetHashCode(FileSystemRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_FileSystemRightsEqualityComparer
{
	// Methods

	// RVA: 0xD48B70
	public void .ctor() { }

	// RVA: 0xD48B78
	public bool Equals(System.Nullable<System.Security.AccessControl.FileSystemRights> left, System.Nullable<System.Security.AccessControl.FileSystemRights> right) { }

	// RVA: 0xD48CF4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.FileSystemRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_InheritanceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD48DA8
	public void .ctor() { }

	// RVA: 0xD48DB0
	public bool Equals(InheritanceFlags left, InheritanceFlags right) { }

	// RVA: 0xD48E38
	public int GetHashCode(InheritanceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_InheritanceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD48E60
	public void .ctor() { }

	// RVA: 0xD48E68
	public bool Equals(System.Nullable<System.Security.AccessControl.InheritanceFlags> left, System.Nullable<System.Security.AccessControl.InheritanceFlags> right) { }

	// RVA: 0xD48FE4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.InheritanceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_MutexRightsEqualityComparer
{
	// Methods

	// RVA: 0xD49098
	public void .ctor() { }

	// RVA: 0xD490A0
	public bool Equals(MutexRights left, MutexRights right) { }

	// RVA: 0xD49128
	public int GetHashCode(MutexRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_MutexRightsEqualityComparer
{
	// Methods

	// RVA: 0xD49150
	public void .ctor() { }

	// RVA: 0xD49158
	public bool Equals(System.Nullable<System.Security.AccessControl.MutexRights> left, System.Nullable<System.Security.AccessControl.MutexRights> right) { }

	// RVA: 0xD492D4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.MutexRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ObjectAceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD49388
	public void .ctor() { }

	// RVA: 0xD49390
	public bool Equals(ObjectAceFlags left, ObjectAceFlags right) { }

	// RVA: 0xD49418
	public int GetHashCode(ObjectAceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ObjectAceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD49440
	public void .ctor() { }

	// RVA: 0xD49448
	public bool Equals(System.Nullable<System.Security.AccessControl.ObjectAceFlags> left, System.Nullable<System.Security.AccessControl.ObjectAceFlags> right) { }

	// RVA: 0xD495C4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ObjectAceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_PropagationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD49678
	public void .ctor() { }

	// RVA: 0xD49680
	public bool Equals(PropagationFlags left, PropagationFlags right) { }

	// RVA: 0xD49708
	public int GetHashCode(PropagationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_PropagationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD49730
	public void .ctor() { }

	// RVA: 0xD49738
	public bool Equals(System.Nullable<System.Security.AccessControl.PropagationFlags> left, System.Nullable<System.Security.AccessControl.PropagationFlags> right) { }

	// RVA: 0xD498B4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.PropagationFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_RegistryRightsEqualityComparer
{
	// Methods

	// RVA: 0xD49968
	public void .ctor() { }

	// RVA: 0xD49970
	public bool Equals(RegistryRights left, RegistryRights right) { }

	// RVA: 0xD499F8
	public int GetHashCode(RegistryRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_RegistryRightsEqualityComparer
{
	// Methods

	// RVA: 0xD49A20
	public void .ctor() { }

	// RVA: 0xD49A28
	public bool Equals(System.Nullable<System.Security.AccessControl.RegistryRights> left, System.Nullable<System.Security.AccessControl.RegistryRights> right) { }

	// RVA: 0xD49BA4
	public int GetHashCode(System.Nullable<System.Security.AccessControl.RegistryRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ResourceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD49C58
	public void .ctor() { }

	// RVA: 0xD49C60
	public bool Equals(ResourceType left, ResourceType right) { }

	// RVA: 0xD49CE8
	public int GetHashCode(ResourceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ResourceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD49D10
	public void .ctor() { }

	// RVA: 0xD49D18
	public bool Equals(System.Nullable<System.Security.AccessControl.ResourceType> left, System.Nullable<System.Security.AccessControl.ResourceType> right) { }

	// RVA: 0xD49E94
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ResourceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_SecurityInfosEqualityComparer
{
	// Methods

	// RVA: 0xD49F48
	public void .ctor() { }

	// RVA: 0xD49F50
	public bool Equals(SecurityInfos left, SecurityInfos right) { }

	// RVA: 0xD49FD8
	public int GetHashCode(SecurityInfos obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_SecurityInfosEqualityComparer
{
	// Methods

	// RVA: 0xD4A000
	public void .ctor() { }

	// RVA: 0xD4A008
	public bool Equals(System.Nullable<System.Security.AccessControl.SecurityInfos> left, System.Nullable<System.Security.AccessControl.SecurityInfos> right) { }

	// RVA: 0xD4A184
	public int GetHashCode(System.Nullable<System.Security.AccessControl.SecurityInfos> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CipherModeEqualityComparer
{
	// Methods

	// RVA: 0xD4A238
	public void .ctor() { }

	// RVA: 0xD4A240
	public bool Equals(CipherMode left, CipherMode right) { }

	// RVA: 0xD4A2C8
	public int GetHashCode(CipherMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CipherModeEqualityComparer
{
	// Methods

	// RVA: 0xD4A2F0
	public void .ctor() { }

	// RVA: 0xD4A2F8
	public bool Equals(System.Nullable<System.Security.Cryptography.CipherMode> left, System.Nullable<System.Security.Cryptography.CipherMode> right) { }

	// RVA: 0xD4A474
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CipherMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CryptoStreamModeEqualityComparer
{
	// Methods

	// RVA: 0xD4A528
	public void .ctor() { }

	// RVA: 0xD4A530
	public bool Equals(CryptoStreamMode left, CryptoStreamMode right) { }

	// RVA: 0xD4A5B8
	public int GetHashCode(CryptoStreamMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CryptoStreamModeEqualityComparer
{
	// Methods

	// RVA: 0xD4A5E0
	public void .ctor() { }

	// RVA: 0xD4A5E8
	public bool Equals(System.Nullable<System.Security.Cryptography.CryptoStreamMode> left, System.Nullable<System.Security.Cryptography.CryptoStreamMode> right) { }

	// RVA: 0xD4A764
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CryptoStreamMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CspProviderFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4A818
	public void .ctor() { }

	// RVA: 0xD4A820
	public bool Equals(CspProviderFlags left, CspProviderFlags right) { }

	// RVA: 0xD4A8A8
	public int GetHashCode(CspProviderFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CspProviderFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4A8D0
	public void .ctor() { }

	// RVA: 0xD4A8D8
	public bool Equals(System.Nullable<System.Security.Cryptography.CspProviderFlags> left, System.Nullable<System.Security.Cryptography.CspProviderFlags> right) { }

	// RVA: 0xD4AA54
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CspProviderFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_DSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD4AB08
	public void .ctor() { }

	// RVA: 0xD4AB10
	public bool Equals(DSAParameters left, DSAParameters right) { }

	// RVA: 0xD4ABB0
	public int GetHashCode(DSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_DSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD4AC2C
	public void .ctor() { }

	// RVA: 0xD4AC34
	public bool Equals(System.Nullable<System.Security.Cryptography.DSAParameters> left, System.Nullable<System.Security.Cryptography.DSAParameters> right) { }

	// RVA: 0xD4ADF8
	public int GetHashCode(System.Nullable<System.Security.Cryptography.DSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_FromBase64TransformModeEqualityComparer
{
	// Methods

	// RVA: 0xD4AEA8
	public void .ctor() { }

	// RVA: 0xD4AEB0
	public bool Equals(FromBase64TransformMode left, FromBase64TransformMode right) { }

	// RVA: 0xD4AF38
	public int GetHashCode(FromBase64TransformMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_FromBase64TransformModeEqualityComparer
{
	// Methods

	// RVA: 0xD4AF60
	public void .ctor() { }

	// RVA: 0xD4AF68
	public bool Equals(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> left, System.Nullable<System.Security.Cryptography.FromBase64TransformMode> right) { }

	// RVA: 0xD4B0E4
	public int GetHashCode(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_KeyNumberEqualityComparer
{
	// Methods

	// RVA: 0xD4B198
	public void .ctor() { }

	// RVA: 0xD4B1A0
	public bool Equals(KeyNumber left, KeyNumber right) { }

	// RVA: 0xD4B228
	public int GetHashCode(KeyNumber obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_KeyNumberEqualityComparer
{
	// Methods

	// RVA: 0xD4B250
	public void .ctor() { }

	// RVA: 0xD4B258
	public bool Equals(System.Nullable<System.Security.Cryptography.KeyNumber> left, System.Nullable<System.Security.Cryptography.KeyNumber> right) { }

	// RVA: 0xD4B3D4
	public int GetHashCode(System.Nullable<System.Security.Cryptography.KeyNumber> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_PaddingModeEqualityComparer
{
	// Methods

	// RVA: 0xD4B488
	public void .ctor() { }

	// RVA: 0xD4B490
	public bool Equals(PaddingMode left, PaddingMode right) { }

	// RVA: 0xD4B518
	public int GetHashCode(PaddingMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_PaddingModeEqualityComparer
{
	// Methods

	// RVA: 0xD4B540
	public void .ctor() { }

	// RVA: 0xD4B548
	public bool Equals(System.Nullable<System.Security.Cryptography.PaddingMode> left, System.Nullable<System.Security.Cryptography.PaddingMode> right) { }

	// RVA: 0xD4B6C4
	public int GetHashCode(System.Nullable<System.Security.Cryptography.PaddingMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_RSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD4B778
	public void .ctor() { }

	// RVA: 0xD4B780
	public bool Equals(RSAParameters left, RSAParameters right) { }

	// RVA: 0xD4B820
	public int GetHashCode(RSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_RSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD4B89C
	public void .ctor() { }

	// RVA: 0xD4B8A4
	public bool Equals(System.Nullable<System.Security.Cryptography.RSAParameters> left, System.Nullable<System.Security.Cryptography.RSAParameters> right) { }

	// RVA: 0xD4BA68
	public int GetHashCode(System.Nullable<System.Security.Cryptography.RSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4BB18
	public void .ctor() { }

	// RVA: 0xD4BB20
	public bool Equals(X509ContentType left, X509ContentType right) { }

	// RVA: 0xD4BBA8
	public int GetHashCode(X509ContentType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4BBD0
	public void .ctor() { }

	// RVA: 0xD4BBD8
	public bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> right) { }

	// RVA: 0xD4BD54
	public int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4BE08
	public void .ctor() { }

	// RVA: 0xD4BE10
	public bool Equals(X509KeyStorageFlags left, X509KeyStorageFlags right) { }

	// RVA: 0xD4BE98
	public int GetHashCode(X509KeyStorageFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD4BEC0
	public void .ctor() { }

	// RVA: 0xD4BEC8
	public bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> right) { }

	// RVA: 0xD4C044
	public int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_ApplicationVersionMatchEqualityComparer
{
	// Methods

	// RVA: 0xD4C0F8
	public void .ctor() { }

	// RVA: 0xD4C100
	public bool Equals(ApplicationVersionMatch left, ApplicationVersionMatch right) { }

	// RVA: 0xD4C188
	public int GetHashCode(ApplicationVersionMatch obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_ApplicationVersionMatchEqualityComparer
{
	// Methods

	// RVA: 0xD4C1B0
	public void .ctor() { }

	// RVA: 0xD4C1B8
	public bool Equals(System.Nullable<System.Security.Policy.ApplicationVersionMatch> left, System.Nullable<System.Security.Policy.ApplicationVersionMatch> right) { }

	// RVA: 0xD4C334
	public int GetHashCode(System.Nullable<System.Security.Policy.ApplicationVersionMatch> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_PolicyStatementAttributeEqualityComparer
{
	// Methods

	// RVA: 0xD4C3E8
	public void .ctor() { }

	// RVA: 0xD4C3F0
	public bool Equals(PolicyStatementAttribute left, PolicyStatementAttribute right) { }

	// RVA: 0xD4C478
	public int GetHashCode(PolicyStatementAttribute obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_PolicyStatementAttributeEqualityComparer
{
	// Methods

	// RVA: 0xD4C4A0
	public void .ctor() { }

	// RVA: 0xD4C4A8
	public bool Equals(System.Nullable<System.Security.Policy.PolicyStatementAttribute> left, System.Nullable<System.Security.Policy.PolicyStatementAttribute> right) { }

	// RVA: 0xD4C624
	public int GetHashCode(System.Nullable<System.Security.Policy.PolicyStatementAttribute> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_TrustManagerUIContextEqualityComparer
{
	// Methods

	// RVA: 0xD4C6D8
	public void .ctor() { }

	// RVA: 0xD4C6E0
	public bool Equals(TrustManagerUIContext left, TrustManagerUIContext right) { }

	// RVA: 0xD4C768
	public int GetHashCode(TrustManagerUIContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_TrustManagerUIContextEqualityComparer
{
	// Methods

	// RVA: 0xD4C790
	public void .ctor() { }

	// RVA: 0xD4C798
	public bool Equals(System.Nullable<System.Security.Policy.TrustManagerUIContext> left, System.Nullable<System.Security.Policy.TrustManagerUIContext> right) { }

	// RVA: 0xD4C914
	public int GetHashCode(System.Nullable<System.Security.Policy.TrustManagerUIContext> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_PrincipalPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD4C9C8
	public void .ctor() { }

	// RVA: 0xD4C9D0
	public bool Equals(PrincipalPolicy left, PrincipalPolicy right) { }

	// RVA: 0xD4CA58
	public int GetHashCode(PrincipalPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_PrincipalPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD4CA80
	public void .ctor() { }

	// RVA: 0xD4CA88
	public bool Equals(System.Nullable<System.Security.Principal.PrincipalPolicy> left, System.Nullable<System.Security.Principal.PrincipalPolicy> right) { }

	// RVA: 0xD4CC04
	public int GetHashCode(System.Nullable<System.Security.Principal.PrincipalPolicy> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenAccessLevelsEqualityComparer
{
	// Methods

	// RVA: 0xD4CCB8
	public void .ctor() { }

	// RVA: 0xD4CCC0
	public bool Equals(TokenAccessLevels left, TokenAccessLevels right) { }

	// RVA: 0xD4CD48
	public int GetHashCode(TokenAccessLevels obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenAccessLevelsEqualityComparer
{
	// Methods

	// RVA: 0xD4CD70
	public void .ctor() { }

	// RVA: 0xD4CD78
	public bool Equals(System.Nullable<System.Security.Principal.TokenAccessLevels> left, System.Nullable<System.Security.Principal.TokenAccessLevels> right) { }

	// RVA: 0xD4CEF4
	public int GetHashCode(System.Nullable<System.Security.Principal.TokenAccessLevels> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenImpersonationLevelEqualityComparer
{
	// Methods

	// RVA: 0xD4CFA8
	public void .ctor() { }

	// RVA: 0xD4CFB0
	public bool Equals(TokenImpersonationLevel left, TokenImpersonationLevel right) { }

	// RVA: 0xD4D038
	public int GetHashCode(TokenImpersonationLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenImpersonationLevelEqualityComparer
{
	// Methods

	// RVA: 0xD4D060
	public void .ctor() { }

	// RVA: 0xD4D068
	public bool Equals(System.Nullable<System.Security.Principal.TokenImpersonationLevel> left, System.Nullable<System.Security.Principal.TokenImpersonationLevel> right) { }

	// RVA: 0xD4D1E4
	public int GetHashCode(System.Nullable<System.Security.Principal.TokenImpersonationLevel> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WellKnownSidTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4D298
	public void .ctor() { }

	// RVA: 0xD4D2A0
	public bool Equals(WellKnownSidType left, WellKnownSidType right) { }

	// RVA: 0xD4D328
	public int GetHashCode(WellKnownSidType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WellKnownSidTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4D350
	public void .ctor() { }

	// RVA: 0xD4D358
	public bool Equals(System.Nullable<System.Security.Principal.WellKnownSidType> left, System.Nullable<System.Security.Principal.WellKnownSidType> right) { }

	// RVA: 0xD4D4D4
	public int GetHashCode(System.Nullable<System.Security.Principal.WellKnownSidType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsAccountTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4D588
	public void .ctor() { }

	// RVA: 0xD4D590
	public bool Equals(WindowsAccountType left, WindowsAccountType right) { }

	// RVA: 0xD4D618
	public int GetHashCode(WindowsAccountType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsAccountTypeEqualityComparer
{
	// Methods

	// RVA: 0xD4D640
	public void .ctor() { }

	// RVA: 0xD4D648
	public bool Equals(System.Nullable<System.Security.Principal.WindowsAccountType> left, System.Nullable<System.Security.Principal.WindowsAccountType> right) { }

	// RVA: 0xD4D7C4
	public int GetHashCode(System.Nullable<System.Security.Principal.WindowsAccountType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsBuiltInRoleEqualityComparer
{
	// Methods

	// RVA: 0xD4D878
	public void .ctor() { }

	// RVA: 0xD4D880
	public bool Equals(WindowsBuiltInRole left, WindowsBuiltInRole right) { }

	// RVA: 0xD4D908
	public int GetHashCode(WindowsBuiltInRole obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsBuiltInRoleEqualityComparer
{
	// Methods

	// RVA: 0xD4D930
	public void .ctor() { }

	// RVA: 0xD4D938
	public bool Equals(System.Nullable<System.Security.Principal.WindowsBuiltInRole> left, System.Nullable<System.Security.Principal.WindowsBuiltInRole> right) { }

	// RVA: 0xD4DAB4
	public int GetHashCode(System.Nullable<System.Security.Principal.WindowsBuiltInRole> obj) { }

}

// Namespace: 
private sealed class System_Text_NormalizationFormEqualityComparer
{
	// Methods

	// RVA: 0xD4DB68
	public void .ctor() { }

	// RVA: 0xD4DB70
	public bool Equals(NormalizationForm left, NormalizationForm right) { }

	// RVA: 0xD4DBF8
	public int GetHashCode(NormalizationForm obj) { }

}

// Namespace: 
private sealed class NullableSystem_Text_NormalizationFormEqualityComparer
{
	// Methods

	// RVA: 0xD4DC20
	public void .ctor() { }

	// RVA: 0xD4DC28
	public bool Equals(System.Nullable<System.Text.NormalizationForm> left, System.Nullable<System.Text.NormalizationForm> right) { }

	// RVA: 0xD4DDA4
	public int GetHashCode(System.Nullable<System.Text.NormalizationForm> obj) { }

}

// Namespace: 
private sealed class System_Threading_ApartmentStateEqualityComparer
{
	// Methods

	// RVA: 0xD4DE58
	public void .ctor() { }

	// RVA: 0xD4DE60
	public bool Equals(ApartmentState left, ApartmentState right) { }

	// RVA: 0xD4DEE8
	public int GetHashCode(ApartmentState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ApartmentStateEqualityComparer
{
	// Methods

	// RVA: 0xD4DF10
	public void .ctor() { }

	// RVA: 0xD4DF18
	public bool Equals(System.Nullable<System.Threading.ApartmentState> left, System.Nullable<System.Threading.ApartmentState> right) { }

	// RVA: 0xD4E094
	public int GetHashCode(System.Nullable<System.Threading.ApartmentState> obj) { }

}

// Namespace: 
private sealed class System_Threading_AsyncFlowControlEqualityComparer
{
	// Methods

	// RVA: 0xD4E148
	public void .ctor() { }

	// RVA: 0xD4E150
	public bool Equals(AsyncFlowControl left, AsyncFlowControl right) { }

	// RVA: 0xD4E188
	public int GetHashCode(AsyncFlowControl obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_AsyncFlowControlEqualityComparer
{
	// Methods

	// RVA: 0xD4E194
	public void .ctor() { }

	// RVA: 0xD4E19C
	public bool Equals(System.Nullable<System.Threading.AsyncFlowControl> left, System.Nullable<System.Threading.AsyncFlowControl> right) { }

	// RVA: 0xD4E314
	public int GetHashCode(System.Nullable<System.Threading.AsyncFlowControl> obj) { }

}

// Namespace: 
private sealed class System_Threading_EventResetModeEqualityComparer
{
	// Methods

	// RVA: 0xD4E3C4
	public void .ctor() { }

	// RVA: 0xD4E3CC
	public bool Equals(EventResetMode left, EventResetMode right) { }

	// RVA: 0xD4E454
	public int GetHashCode(EventResetMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_EventResetModeEqualityComparer
{
	// Methods

	// RVA: 0xD4E47C
	public void .ctor() { }

	// RVA: 0xD4E484
	public bool Equals(System.Nullable<System.Threading.EventResetMode> left, System.Nullable<System.Threading.EventResetMode> right) { }

	// RVA: 0xD4E600
	public int GetHashCode(System.Nullable<System.Threading.EventResetMode> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockCookieEqualityComparer
{
	// Methods

	// RVA: 0xD4E6B4
	public void .ctor() { }

	// RVA: 0xD4E6BC
	public bool Equals(LockCookie left, LockCookie right) { }

	// RVA: 0xD4E6F0
	public int GetHashCode(LockCookie obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockCookieEqualityComparer
{
	// Methods

	// RVA: 0xD4E71C
	public void .ctor() { }

	// RVA: 0xD4E724
	public bool Equals(System.Nullable<System.Threading.LockCookie> left, System.Nullable<System.Threading.LockCookie> right) { }

	// RVA: 0xD4E880
	public int GetHashCode(System.Nullable<System.Threading.LockCookie> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockRecursionPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD4E934
	public void .ctor() { }

	// RVA: 0xD4E93C
	public bool Equals(LockRecursionPolicy left, LockRecursionPolicy right) { }

	// RVA: 0xD4E9C4
	public int GetHashCode(LockRecursionPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockRecursionPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD4E9EC
	public void .ctor() { }

	// RVA: 0xD4E9F4
	public bool Equals(System.Nullable<System.Threading.LockRecursionPolicy> left, System.Nullable<System.Threading.LockRecursionPolicy> right) { }

	// RVA: 0xD4EB70
	public int GetHashCode(System.Nullable<System.Threading.LockRecursionPolicy> obj) { }

}

// Namespace: 
private sealed class System_Threading_NativeOverlappedEqualityComparer
{
	// Methods

	// RVA: 0xD4EC24
	public void .ctor() { }

	// RVA: 0xD4EC2C
	public bool Equals(NativeOverlapped left, NativeOverlapped right) { }

	// RVA: 0xD4ECBC
	public int GetHashCode(NativeOverlapped obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_NativeOverlappedEqualityComparer
{
	// Methods

	// RVA: 0xD4ED30
	public void .ctor() { }

	// RVA: 0xD4ED38
	public bool Equals(System.Nullable<System.Threading.NativeOverlapped> left, System.Nullable<System.Threading.NativeOverlapped> right) { }

	// RVA: 0xD4EED4
	public int GetHashCode(System.Nullable<System.Threading.NativeOverlapped> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadPriorityEqualityComparer
{
	// Methods

	// RVA: 0xD4EF84
	public void .ctor() { }

	// RVA: 0xD4EF8C
	public bool Equals(ThreadPriority left, ThreadPriority right) { }

	// RVA: 0xD4F014
	public int GetHashCode(ThreadPriority obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadPriorityEqualityComparer
{
	// Methods

	// RVA: 0xD4F03C
	public void .ctor() { }

	// RVA: 0xD4F044
	public bool Equals(System.Nullable<System.Threading.ThreadPriority> left, System.Nullable<System.Threading.ThreadPriority> right) { }

	// RVA: 0xD4F1C0
	public int GetHashCode(System.Nullable<System.Threading.ThreadPriority> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadStateEqualityComparer
{
	// Methods

	// RVA: 0xD4F274
	public void .ctor() { }

	// RVA: 0xD4F27C
	public bool Equals(ThreadState left, ThreadState right) { }

	// RVA: 0xD4F304
	public int GetHashCode(ThreadState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadStateEqualityComparer
{
	// Methods

	// RVA: 0xD4F32C
	public void .ctor() { }

	// RVA: 0xD4F334
	public bool Equals(System.Nullable<System.Threading.ThreadState> left, System.Nullable<System.Threading.ThreadState> right) { }

	// RVA: 0xD4F4B0
	public int GetHashCode(System.Nullable<System.Threading.ThreadState> obj) { }

}

// Namespace: MsgPack.Serialization
internal static class AotHelper
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> EqualityComparerTable; // 0x0

	// Methods

	// RVA: 0xD15400
	public static void HandleAotError(Type mayBeGenericArgument, Exception mayBeAotError) { }

	// RVA: 0xD22AE8
	public static object CreateSystemCollectionsGenericDictionary(ConstructorInfo constructor, Type keyType, int initialCapacity) { }

	// RVA: 0xD226F4
	public static object GetEqualityComparer(Type type) { }

	// RVA: 0x30A6D04
	public static void PrepareEqualityComparer() { }

	// RVA: 0xD22C74
	private static System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeEqualityComparerTable() { }

	// RVA: 0xD2DDEC
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class EnumTypedMessagePackSerializerWrapper<T0>
{
	// Fields
	private readonly ICustomizableEnumSerializer _underlyingEnumSerializer; // 0x0

	// Methods

	// RVA: 0x30A2A20
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

	// RVA: 0xD4F564
	protected Type get_TargetType() { }

	// RVA: 0xD4F56C
	protected void .ctor(SerializationContext ownerContext, Type targetType, SerializerCapabilities capabilities) { }

	// RVA: 0xD4F610
	private void .ctor(SerializationContext ownerContext, Type targetType, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xD4F6C0
	private static bool JudgeNullable(Type type) { }

	// RVA: 0xD4F890
	internal override void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: -1
	protected internal abstract void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD4F914
	internal override object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: -1
	protected internal abstract object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD4FA58
	internal override void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xD4FB74
	protected internal virtual void UnpackToCore(Unpacker unpacker, object collection) { }

}

// Namespace: MsgPack.Serialization
internal class TypedMessagePackSerializerWrapper<T0>
{
	// Fields
	private readonly MessagePackSerializer _underlyingSerializer; // 0x0
	private readonly ICollectionInstanceFactory _underlyingFactory; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(SerializationContext context, MessagePackSerializer underlying) { }

	// RVA: 0x315B3A8
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x315B3A8
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x315B3A8
	protected internal override T UnpackNil() { }

	// RVA: 0x315B3A8
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

	// RVA: 0xD4FE50
	public void .ctor() { }

	// RVA: 0xD500F8
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

	// RVA: 0xD4FBAC
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD4FE58
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD4FF7C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD500B4
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD503C8
	public void .ctor() { }

	// RVA: 0xD50670
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

	// RVA: 0xD5012C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD503D0
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD504F4
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5062C
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD509CC
	public void .ctor() { }

	// RVA: 0xD50D20
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xD50D54
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

	// RVA: 0xD506A4
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD509D4
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD50AF8
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD50CB4
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xD50CF8
	protected override void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionEnumMessagePackSerializer
{
	// Methods

	// RVA: 0xD50D88
	public void .ctor(SerializationContext context, Type targetType) { }

	// RVA: 0xD50DDC
	protected internal override void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xD50F70
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

	// RVA: 0xD51794
	private static void .cctor() { }

	// RVA: 0xD51800
	public void .ctor() { }

	// RVA: 0xD51808
	internal bool <OnPackingMessagePackObject>b__2_0(object value) { }

	// RVA: 0xD518A4
	internal bool <OnPackingReferenceTypeObject>b__3_0(object value) { }

	// RVA: 0xD518B0
	internal bool <OnPackingNullableValueTypeObject>b__4_0(object value) { }

	// RVA: 0xD518BC
	internal void <OnNopOnUnpacked>b__6_0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public System.Func<System.Object,System.Boolean> condition; // 0x10
	public ReflectionSerializerNilImplicationHandlerParameter parameter; // 0x18

	// Methods

	// RVA: 0xD518C0
	public void .ctor() { }

	// RVA: 0xD518C8
	internal void <OnPackingCore>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xD51928
	public void .ctor() { }

	// RVA: 0xD51930
	internal void <OnThrowNullIsProhibitedExceptionOnUnpacked>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xD51954
	public void .ctor() { }

	// RVA: 0xD5195C
	internal void <OnThrowValueTypeCannotBeNull3OnUnpacked>b__0(object _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionNilImplicationHandler
{
	// Fields
	public static readonly ReflectionNilImplicationHandler Instance; // 0x0

	// Methods

	// RVA: 0xD51024
	private void .ctor() { }

	// RVA: 0xD51078
	protected override System.Func<System.Object,System.Boolean> OnPackingMessagePackObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD51180
	protected override System.Func<System.Object,System.Boolean> OnPackingReferenceTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD51288
	protected override System.Func<System.Object,System.Boolean> OnPackingNullableValueTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD51390
	protected override System.Action<System.Object> OnPackingCore(ReflectionSerializerNilImplicationHandlerParameter parameter, System.Func<System.Object,System.Boolean> condition) { }

	// RVA: 0xD5146C
	protected override System.Action<System.Object> OnNopOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD51574
	protected override System.Action<System.Object> OnThrowNullIsProhibitedExceptionOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD51634
	protected override System.Action<System.Object> OnThrowValueTypeCannotBeNull3OnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD516F4
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD51CA4
	public void .ctor() { }

	// RVA: 0xD52CBC
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xD52CF0
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

	// RVA: 0xD51984
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD523B0
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD52864
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD52C50
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xD52C94
	protected override void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD53044
	public void .ctor() { }

	// RVA: 0xD53774
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xD537A8
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

	// RVA: 0xD52D24
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD53050
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD53550
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD53708
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xD5374C
	protected override void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD53A80
	public void .ctor() { }

	// RVA: 0xD54340
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

	// RVA: 0xD537DC
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD53C14
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD5413C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD542FC
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD54618
	public void .ctor() { }

	// RVA: 0xD54948
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

	// RVA: 0xD54374
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD54624
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD54744
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD54904
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public SerializationContext context; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal string <.ctor>b__2(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_1
{
	// Fields
	public SerializingMember member; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A1344
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal System.Collections.Generic.KeyValuePair<System.String,System.Int32> <.ctor>b__8_0(DataMemberContract contract, int index) { }

	// RVA: 0x315B3A8
	internal bool <.ctor>b__8_1(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x315B3A8
	internal int <.ctor>b__8_3(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
	internal void <UnpackMemberValue>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_1
{
	// Fields
	public int argumentIndex; // 0x0
	public MsgPack.Serialization.ReflectionSerializers.ReflectionObjectMessagePackSerializer.<>c__DisplayClass13_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x30A27C0
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

	// RVA: 0x30A2A8C
	public void .ctor(SerializationContext context, SerializationTarget target, SerializerCapabilities capabilities) { }

	// RVA: 0x315B3A8
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x315B3A8
	private bool IsNull(T objectTree, int index) { }

	// RVA: 0x315B3A8
	private void PackMemberValue(Packer packer, T objectTree, int index) { }

	// RVA: 0x315B3A8
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x315B3A8
	private object UnpackMemberValue(object objectGraph, Unpacker unpacker, int itemsCount, int unpacked, int index, int unpackerOffset) { }

	// RVA: 0x30A18F8
	private object UnpackSingleValue(Unpacker unpacker, int index) { }

	// RVA: 0x30A2A8C
	private void UnpackAndAddCollectionItem(object objectGraph, Unpacker unpacker, int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public CollectionTraits collectionTraits; // 0x10

	// Methods

	// RVA: 0xD5497C
	public void .ctor() { }

	// RVA: 0xD55EF4
	internal void <GetAddItem>b__0(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public MethodInfo getter; // 0x10
	public MethodInfo setter; // 0x18

	// Methods

	// RVA: 0xD55C60
	public void .ctor() { }

	// RVA: 0xD55FE0
	internal object <GetMetadata>b__0(object target) { }

	// RVA: 0xD56054
	internal void <GetMetadata>b__1(object target, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ConstructorInfo constructor; // 0x10

	// Methods

	// RVA: 0xD55DA4
	public void .ctor() { }

	// RVA: 0xD56140
	internal object <CreateCollectionInstanceFactory>b__0(int _) { }

	// RVA: 0xD561D0
	internal object <CreateCollectionInstanceFactory>b__1(int capacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xD55DAC
	public void .ctor() { }

	// RVA: 0xD562E8
	internal object <CreateCollectionInstanceFactory>b__2(int _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xD55DB4
	public void .ctor() { }

	// RVA: 0xD563CC
	internal object <CreateCollectionInstanceFactory>b__3(int capacity) { }

	// RVA: 0xD56524
	internal object <CreateCollectionInstanceFactory>b__4(int capacity) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal static class ReflectionSerializerHelper
{
	// Fields
	internal static readonly PropertyInfo DictionaryEntryKeyProperty; // 0x0
	internal static readonly PropertyInfo DictionaryEntryValueProperty; // 0x8

	// Methods

	// RVA: 0x30A52D0
	public static MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionEnumMessagePackSerializer(SerializationContext context) { }

	// RVA: 0x315B3A8
	public static MessagePackSerializer CreateCollectionSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD521B8
	public static System.Action<System.Object,System.Object> GetAddItem(Type targetType, CollectionTraits collectionTraits) { }

	// RVA: 0xD54EAC
	public static void GetMetadata(Type targetType, System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, SerializationContext context, System.Func<System.Object,System.Object>[]& getters, System.Action<System.Object,System.Object>[]& setters, MemberInfo[] memberInfos, DataMemberContract[] contracts, MessagePackSerializer[] serializers) { }

	// RVA: 0xD55C68
	private static void ThrowMissingGetterException(Type targetType, int number, PropertyInfo property) { }

	// RVA: 0xD51CB0
	public static System.Func<System.Int32,System.Object> CreateCollectionInstanceFactory(Type abstractType, Type targetType, Type comparisonType, ConstructorInfo constructor) { }

	// RVA: 0xD55DBC
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

	// RVA: 0xD5667C
	public Type get_ItemType() { }

	// RVA: 0xD56684
	public System.Action<System.Object> get_Store() { }

	// RVA: 0xD5668C
	public void .ctor(Type itemType, System.Action<System.Object> store, string memberName, Type declaringType) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionSerializerNilImplicationHandlerParameter
{
	// Fields
	private readonly Type _itemType; // 0x10
	private readonly string _memberName; // 0x18

	// Methods

	// RVA: 0xD5670C
	public Type get_ItemType() { }

	// RVA: 0xD56714
	public string get_MemberName() { }

	// RVA: 0xD5671C
	public void .ctor(Type itemType, string memberName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass1_0
{
	// Fields
	public Type genericType; // 0x10
	public Type source; // 0x18

	// Methods

	// RVA: 0xD56A10
	public void .ctor() { }

	// RVA: 0xD56A18
	internal bool <EnumerateGenericIntefaces>b__0(Type interface) { }

	// RVA: 0xD56B2C
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

	// RVA: 0xD56BEC
	private static void .cctor() { }

	// RVA: 0xD56C58
	public void .ctor() { }

	// RVA: 0xD56C60
	internal string <GetFullName>b__3_0(Type t) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class GenericTypeExtensions
{
	// Methods

	// RVA: 0xD5676C
	public static bool Implements(Type source, Type genericType) { }

	// RVA: 0xD567D0
	private static System.Collections.Generic.IEnumerable<System.Type> EnumerateGenericIntefaces(Type source, Type genericType, bool includesOwn) { }

	// RVA: 0xD54984
	public static string GetFullName(Type source) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class ReflectionExtensions
{
	// Methods

	// RVA: 0xD56C68
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

	// RVA: 0x30A6D04
	private static void .cctor() { }

	// RVA: 0x30A2378
	public void .ctor() { }

	// RVA: 0x315B3A8
	internal string <BuildTypeCodeTypeHandleMap>b__4_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x315B3A8
	internal RuntimeTypeHandle <BuildTypeCodeTypeHandleMap>b__4_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x315B3A8
	internal Type <BuildTypeHandleTypeCodeMap>b__5_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x315B3A8
	internal string <BuildTypeHandleTypeCodeMap>b__5_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x30A188C
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

	// RVA: 0x30A2A20
	public void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x30A52D0
	private static System.Collections.Generic.IDictionary<System.String,System.RuntimeTypeHandle> BuildTypeCodeTypeHandleMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x30A52D0
	private static System.Collections.Generic.IDictionary<System.RuntimeTypeHandle,System.String> BuildTypeHandleTypeCodeMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x30A188C
	private MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x315B3A8
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x315B3A8
	private string GetTypeCode(T objectTree) { }

	// RVA: 0x315B3A8
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30A188C
	private Type GetTypeFromCode(string typeCode) { }

	// RVA: 0x30A188C
	private object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x315B3A8
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x30A188C
	private Type <UnpackFromCore>b__9_0(string c) { }

	// RVA: 0x315B3A8
	private T <UnpackFromCore>b__9_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class PolymorphicSerializerProvider<T0>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<T> _defaultSerializer; // 0x0
	private readonly PolymorphismSchema _defaultSchema; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(SerializationContext context, MessagePackSerializer defaultSerializer) { }

	// RVA: 0x30A1970
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

	// RVA: 0x30A24F0
	public void .ctor(int capacity) { }

	// RVA: 0x315B3A8
	public void Enqueue(T item) { }

	// RVA: 0x315B3A8
	public T Dequeue() { }

	// RVA: 0x30A24F0
	private void SetCapacity(int capacity) { }

	// RVA: 0x30A27C0
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

	// RVA: 0xD56C90
	public static void Verify(AssemblyName assemblyName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD56E04
	private static bool VerifyCore(AssemblyName assemblyName, string assemblyFullName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD572DC
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class TypeEmbedingPolymorphicMessagePackSerializer<T0>
{
	// Fields
	private readonly PolymorphismSchema _schema; // 0x0

	// Methods

	// RVA: 0x30A2A20
	public void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x30A188C
	private MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x315B3A8
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x315B3A8
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30A188C
	private object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x315B3A8
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x30A188C
	private Type <UnpackFromCore>b__4_0(Unpacker u) { }

	// RVA: 0x315B3A8
	private T <UnpackFromCore>b__4_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal static class TypeInfoEncoder
{
	// Methods

	// RVA: 0xD57420
	public static void Encode(Packer packer, string typeCode) { }

	// RVA: 0xD57460
	public static void Encode(Packer packer, Type type) { }

	// RVA: 0x315B3A8
	public static T Decode(Unpacker unpacker, System.Func<System.String,System.Type> typeFinder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0x315B3A8
	public static T Decode(Unpacker unpacker, System.Func<MsgPack.Unpacker,System.Type> typeDecoder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0xD5776C
	public static Type DecodeRuntimeTypeInfo(Unpacker unpacker, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD57D7C
	private static void ThrowFailedToDecodeEncodingType() { }

	// RVA: 0xD57DD0
	private static void ThrowUnknownEncodingType(Byte encodeType) { }

	// RVA: 0xD57EB8
	private static void ThrowFailedToDecodeCompressedTypeName() { }

	// RVA: 0xD57F0C
	private static void ThrowFailedToDecodeAssemblySimpleName() { }

	// RVA: 0xD57F60
	private static void ThrowFailedToDecodeAssemblyVersion() { }

	// RVA: 0xD57FB4
	private static void ThrowFailedToDecodeAssemblyCulture() { }

	// RVA: 0xD58008
	private static void ThrowFailedToDecodeAssemblyKeyToken() { }

	// RVA: 0xD57C9C
	private static void CheckUnpackerForRuntimeTypeInfoDecoding(Unpacker unpacker) { }

	// RVA: 0xD582C0
	private static void ThrowEncodedTypeIsNotInNonNillArray() { }

	// RVA: 0xD58314
	private static void ThrowEncodedTypeDoesNotHaveValidArrayItems() { }

	// RVA: 0xD5805C
	private static AssemblyName BuildAssemblyName(string assemblySimpleName, Byte[] version, string culture, Byte[] publicKeyToken) { }

	// RVA: 0xD581F0
	private static string DecompressTypeName(string assemblySimpleName, string compressedTypeName) { }

	// RVA: 0xD58280
	private static Type LoadDecodedType(AssemblyName assemblyName, string typeFullName) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractCollectionMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x50
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x58

	// Methods

	// RVA: 0xD58368
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD5865C
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5883C
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class AbstractCollectionSerializerHelper
{
	// Methods

	// RVA: 0xD58504
	public static void GetConcreteSerializer(SerializationContext context, PolymorphismSchema schema, Type abstractType, Type targetType, Type exampleType, ICollectionInstanceFactory factory, MessagePackSerializer serializer) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractDictionaryMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x68
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x70

	// Methods

	// RVA: 0xD588F0
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD58C08
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD58DE8
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractEnumerableMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly MessagePackSerializer _concreteSerializer; // 0x50

	// Methods

	// RVA: 0xD58E9C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD58FC8
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD590A8
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericCollectionMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xD5915C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD59230
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD59310
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericDictionaryMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x50

	// Methods

	// RVA: 0xD593C4
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD594E8
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD59678
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericEnumerableMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xD5972C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD59800
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD598E0
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericListMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x48

	// Methods

	// RVA: 0xD59994
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD59AB8
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD59C98
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySegmentMessageSerializer
{
	// Methods

	// RVA: 0xD59D4C
	public static void PackByteArraySegmentTo(Packer packer, System.ArraySegment<System.Byte> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xD59E90
	public static void PackCharArraySegmentTo(Packer packer, System.ArraySegment<System.Char> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x315B3A8
	public static void PackGenericArraySegmentTo(Packer packer, System.ArraySegment<T> objectTree, MsgPack.Serialization.MessagePackSerializer<T> itemSerializer) { }

	// RVA: 0xD5A004
	public static System.ArraySegment<System.Byte> UnpackByteArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xD5A0BC
	public static System.ArraySegment<System.Char> UnpackCharArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x315B3A8
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

	// RVA: 0xD5BDDC
	private static void .cctor() { }

	// RVA: 0xD5BE48
	public void .ctor() { }

	// RVA: 0xD5BE50
	internal object <InitializeArraySerializerFactories>b__4_0(SerializationContext context) { }

	// RVA: 0xD5BF90
	internal object <InitializeArraySerializerFactories>b__4_1(SerializationContext context) { }

	// RVA: 0xD5C0D0
	internal object <InitializeArraySerializerFactories>b__4_2(SerializationContext context) { }

	// RVA: 0xD5C210
	internal object <InitializeArraySerializerFactories>b__4_3(SerializationContext context) { }

	// RVA: 0xD5C350
	internal object <InitializeArraySerializerFactories>b__4_4(SerializationContext context) { }

	// RVA: 0xD5C490
	internal object <InitializeArraySerializerFactories>b__4_5(SerializationContext context) { }

	// RVA: 0xD5C5D0
	internal object <InitializeArraySerializerFactories>b__4_6(SerializationContext context) { }

	// RVA: 0xD5C710
	internal object <InitializeArraySerializerFactories>b__4_7(SerializationContext context) { }

	// RVA: 0xD5C850
	internal object <InitializeArraySerializerFactories>b__4_8(SerializationContext context) { }

	// RVA: 0xD5C990
	internal object <InitializeArraySerializerFactories>b__4_9(SerializationContext context) { }

	// RVA: 0xD5CAD0
	internal object <InitializeArraySerializerFactories>b__4_10(SerializationContext context) { }

	// RVA: 0xD5CC10
	internal object <InitializeArraySerializerFactories>b__4_11(SerializationContext context) { }

	// RVA: 0xD5CD50
	internal object <InitializeArraySerializerFactories>b__4_12(SerializationContext context) { }

	// RVA: 0xD5CE90
	internal object <InitializeArraySerializerFactories>b__4_13(SerializationContext context) { }

	// RVA: 0xD5CFD0
	internal object <InitializeArraySerializerFactories>b__4_14(SerializationContext context) { }

	// RVA: 0xD5D110
	internal object <InitializeArraySerializerFactories>b__4_15(SerializationContext context) { }

	// RVA: 0xD5D250
	internal object <InitializeArraySerializerFactories>b__4_16(SerializationContext context) { }

	// RVA: 0xD5D390
	internal object <InitializeArraySerializerFactories>b__4_17(SerializationContext context) { }

	// RVA: 0xD5D4D0
	internal object <InitializeArraySerializerFactories>b__4_18(SerializationContext context) { }

	// RVA: 0xD5D610
	internal object <InitializeArraySerializerFactories>b__4_19(SerializationContext context) { }

	// RVA: 0xD5D750
	internal object <InitializeArraySerializerFactories>b__4_20(SerializationContext context) { }

	// RVA: 0xD5D890
	internal object <InitializeArraySerializerFactories>b__4_21(SerializationContext context) { }

	// RVA: 0xD5D9D0
	internal object <InitializeArraySerializerFactories>b__4_22(SerializationContext context) { }

	// RVA: 0xD5DB10
	internal object <InitializeArraySerializerFactories>b__4_23(SerializationContext context) { }

	// RVA: 0xD5DC50
	internal object <InitializeArraySerializerFactories>b__4_24(SerializationContext context) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySerializer
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> _arraySerializerFactories; // 0x0

	// Methods

	// RVA: 0x30A53B0
	public static MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD5A174
	public static MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD5A354
	private static object GetPrimitiveArraySerializer(SerializationContext context, Type targetType) { }

	// RVA: 0xD5A610
	private static System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> InitializeArraySerializerFactories() { }

	// RVA: 0xD5BD80
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SByteArraySerializer
{
	// Methods

	// RVA: 0xD5BF0C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5DD90
	protected internal override void PackToCore(Packer packer, SByte[] objectTree) { }

	// RVA: 0xD5DE08
	protected internal override SByte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5DFAC
	protected internal override void UnpackToCore(Unpacker unpacker, SByte[] collection) { }

	// RVA: 0xD5DED4
	private static void UnpackToCore(Unpacker unpacker, SByte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int16ArraySerializer
{
	// Methods

	// RVA: 0xD5C18C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5E04C
	protected internal override void PackToCore(Packer packer, Int16[] objectTree) { }

	// RVA: 0xD5E0C4
	protected internal override Int16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5E268
	protected internal override void UnpackToCore(Unpacker unpacker, Int16[] collection) { }

	// RVA: 0xD5E190
	private static void UnpackToCore(Unpacker unpacker, Int16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int32ArraySerializer
{
	// Methods

	// RVA: 0xD5C40C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5E308
	protected internal override void PackToCore(Packer packer, int[] objectTree) { }

	// RVA: 0xD5E380
	protected internal override int[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5E524
	protected internal override void UnpackToCore(Unpacker unpacker, int[] collection) { }

	// RVA: 0xD5E44C
	private static void UnpackToCore(Unpacker unpacker, int[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int64ArraySerializer
{
	// Methods

	// RVA: 0xD5C68C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5E5C4
	protected internal override void PackToCore(Packer packer, Int64[] objectTree) { }

	// RVA: 0xD5E63C
	protected internal override Int64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5E7E0
	protected internal override void UnpackToCore(Unpacker unpacker, Int64[] collection) { }

	// RVA: 0xD5E708
	private static void UnpackToCore(Unpacker unpacker, Int64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class ByteArraySerializer
{
	// Methods

	// RVA: 0xD5C90C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5E880
	protected internal override void PackToCore(Packer packer, Byte[] objectTree) { }

	// RVA: 0xD5E8F8
	protected internal override Byte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5EA9C
	protected internal override void UnpackToCore(Unpacker unpacker, Byte[] collection) { }

	// RVA: 0xD5E9C4
	private static void UnpackToCore(Unpacker unpacker, Byte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt16ArraySerializer
{
	// Methods

	// RVA: 0xD5CB8C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5EB3C
	protected internal override void PackToCore(Packer packer, UInt16[] objectTree) { }

	// RVA: 0xD5EBB4
	protected internal override UInt16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5ED58
	protected internal override void UnpackToCore(Unpacker unpacker, UInt16[] collection) { }

	// RVA: 0xD5EC80
	private static void UnpackToCore(Unpacker unpacker, UInt16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt32ArraySerializer
{
	// Methods

	// RVA: 0xD5CE0C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5EDF8
	protected internal override void PackToCore(Packer packer, UInt32[] objectTree) { }

	// RVA: 0xD5EE70
	protected internal override UInt32[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5F014
	protected internal override void UnpackToCore(Unpacker unpacker, UInt32[] collection) { }

	// RVA: 0xD5EF3C
	private static void UnpackToCore(Unpacker unpacker, UInt32[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt64ArraySerializer
{
	// Methods

	// RVA: 0xD5D08C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5F0B4
	protected internal override void PackToCore(Packer packer, UInt64[] objectTree) { }

	// RVA: 0xD5F12C
	protected internal override UInt64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5F2D0
	protected internal override void UnpackToCore(Unpacker unpacker, UInt64[] collection) { }

	// RVA: 0xD5F1F8
	private static void UnpackToCore(Unpacker unpacker, UInt64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SingleArraySerializer
{
	// Methods

	// RVA: 0xD5D30C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5F370
	protected internal override void PackToCore(Packer packer, float[] objectTree) { }

	// RVA: 0xD5F3E8
	protected internal override float[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5F58C
	protected internal override void UnpackToCore(Unpacker unpacker, float[] collection) { }

	// RVA: 0xD5F4B4
	private static void UnpackToCore(Unpacker unpacker, float[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class DoubleArraySerializer
{
	// Methods

	// RVA: 0xD5D58C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5F62C
	protected internal override void PackToCore(Packer packer, Double[] objectTree) { }

	// RVA: 0xD5F6A4
	protected internal override Double[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5F848
	protected internal override void UnpackToCore(Unpacker unpacker, Double[] collection) { }

	// RVA: 0xD5F770
	private static void UnpackToCore(Unpacker unpacker, Double[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BooleanArraySerializer
{
	// Methods

	// RVA: 0xD5D80C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5F8E8
	protected internal override void PackToCore(Packer packer, bool[] objectTree) { }

	// RVA: 0xD5F960
	protected internal override bool[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5FB04
	protected internal override void UnpackToCore(Unpacker unpacker, bool[] collection) { }

	// RVA: 0xD5FA2C
	private static void UnpackToCore(Unpacker unpacker, bool[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSByteArraySerializer
{
	// Methods

	// RVA: 0xD5C04C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5FBA4
	protected internal override void PackToCore(Packer packer, System.Nullable<System.SByte>[] objectTree) { }

	// RVA: 0xD5FC30
	protected internal override System.Nullable<System.SByte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD5FDD4
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection) { }

	// RVA: 0xD5FCFC
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt16ArraySerializer
{
	// Methods

	// RVA: 0xD5C2CC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD5FE74
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int16>[] objectTree) { }

	// RVA: 0xD5FF00
	protected internal override System.Nullable<System.Int16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD600A4
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection) { }

	// RVA: 0xD5FFCC
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt32ArraySerializer
{
	// Methods

	// RVA: 0xD5C54C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD60144
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int32>[] objectTree) { }

	// RVA: 0xD601BC
	protected internal override System.Nullable<System.Int32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD60360
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection) { }

	// RVA: 0xD60288
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt64ArraySerializer
{
	// Methods

	// RVA: 0xD5C7CC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD60400
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int64>[] objectTree) { }

	// RVA: 0xD6047C
	protected internal override System.Nullable<System.Int64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD60620
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection) { }

	// RVA: 0xD60548
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableByteArraySerializer
{
	// Methods

	// RVA: 0xD5CA4C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD606C0
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Byte>[] objectTree) { }

	// RVA: 0xD6074C
	protected internal override System.Nullable<System.Byte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD608F0
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection) { }

	// RVA: 0xD60818
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt16ArraySerializer
{
	// Methods

	// RVA: 0xD5CCCC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD60990
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt16>[] objectTree) { }

	// RVA: 0xD60A1C
	protected internal override System.Nullable<System.UInt16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD60BC0
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection) { }

	// RVA: 0xD60AE8
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt32ArraySerializer
{
	// Methods

	// RVA: 0xD5CF4C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD60C60
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt32>[] objectTree) { }

	// RVA: 0xD60CD8
	protected internal override System.Nullable<System.UInt32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD60E7C
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection) { }

	// RVA: 0xD60DA4
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt64ArraySerializer
{
	// Methods

	// RVA: 0xD5D1CC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD60F1C
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt64>[] objectTree) { }

	// RVA: 0xD60F98
	protected internal override System.Nullable<System.UInt64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6113C
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection) { }

	// RVA: 0xD61064
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSingleArraySerializer
{
	// Methods

	// RVA: 0xD5D44C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD611DC
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Single>[] objectTree) { }

	// RVA: 0xD61254
	protected internal override System.Nullable<System.Single>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD613F8
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection) { }

	// RVA: 0xD61320
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableDoubleArraySerializer
{
	// Methods

	// RVA: 0xD5D6CC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD61498
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Double>[] objectTree) { }

	// RVA: 0xD61514
	protected internal override System.Nullable<System.Double>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD616B8
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection) { }

	// RVA: 0xD615E0
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableBooleanArraySerializer
{
	// Methods

	// RVA: 0xD5D94C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD61758
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Boolean>[] objectTree) { }

	// RVA: 0xD617E4
	protected internal override System.Nullable<System.Boolean>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD61988
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection) { }

	// RVA: 0xD618B0
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class StringArraySerializer
{
	// Methods

	// RVA: 0xD5DA8C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD61A28
	protected internal override void PackToCore(Packer packer, string[] objectTree) { }

	// RVA: 0xD61AA0
	protected internal override string[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD61C54
	protected internal override void UnpackToCore(Unpacker unpacker, string[] collection) { }

	// RVA: 0xD61B6C
	private static void UnpackToCore(Unpacker unpacker, string[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BinaryArraySerializer
{
	// Methods

	// RVA: 0xD5DBCC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD61CF4
	protected internal override void PackToCore(Packer packer, Byte[][] objectTree) { }

	// RVA: 0xD61D6C
	protected internal override Byte[][] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD61F20
	protected internal override void UnpackToCore(Unpacker unpacker, Byte[][] collection) { }

	// RVA: 0xD61E38
	private static void UnpackToCore(Unpacker unpacker, Byte[][] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MessagePackObjectArraySerializer
{
	// Methods

	// RVA: 0xD5DD0C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD61FC0
	protected internal override void PackToCore(Packer packer, MessagePackObject[] objectTree) { }

	// RVA: 0xD62094
	protected internal override MessagePackObject[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6224C
	protected internal override void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection) { }

	// RVA: 0xD62160
	private static void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UnityArraySerializer
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38
	private readonly Type _itemType; // 0x40

	// Methods

	// RVA: 0xD5A458
	public void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD622EC
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD62690
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD629EC
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD62754
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

	// RVA: 0xD62AC0
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD630E4
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class DateTimeOffsetMessagePackSerializer
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xD63318
	public void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xD633B0
	protected internal override void PackToCore(Packer packer, DateTimeOffset objectTree) { }

	// RVA: 0xD635FC
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

	// RVA: 0xD63D0C
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD64184
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_BooleanMessagePackSerializer
{
	// Methods

	// RVA: 0xD643B8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6443C
	protected internal override void PackToCore(Packer packer, bool value) { }

	// RVA: 0xD6445C
	protected internal override bool UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteMessagePackSerializer
{
	// Methods

	// RVA: 0xD64694
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD64718
	protected internal override void PackToCore(Packer packer, Byte value) { }

	// RVA: 0xD64738
	protected internal override Byte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharMessagePackSerializer
{
	// Methods

	// RVA: 0xD64970
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD649F4
	protected internal override void PackToCore(Packer packer, Char value) { }

	// RVA: 0xD64A14
	protected internal override Char UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DecimalMessagePackSerializer
{
	// Methods

	// RVA: 0xD64C18
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD64C9C
	protected internal override void PackToCore(Packer packer, Decimal value) { }

	// RVA: 0xD64DA0
	protected internal override Decimal UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DoubleMessagePackSerializer
{
	// Methods

	// RVA: 0xD65014
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD65098
	protected internal override void PackToCore(Packer packer, Double value) { }

	// RVA: 0xD650B4
	protected internal override Double UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_GuidMessagePackSerializer
{
	// Methods

	// RVA: 0xD652EC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD65370
	protected internal override void PackToCore(Packer packer, Guid value) { }

	// RVA: 0xD653BC
	protected internal override Guid UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int16MessagePackSerializer
{
	// Methods

	// RVA: 0xD655DC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD65660
	protected internal override void PackToCore(Packer packer, Int16 value) { }

	// RVA: 0xD65680
	protected internal override Int16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int32MessagePackSerializer
{
	// Methods

	// RVA: 0xD658B8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6593C
	protected internal override void PackToCore(Packer packer, int value) { }

	// RVA: 0xD6595C
	protected internal override int UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int64MessagePackSerializer
{
	// Methods

	// RVA: 0xD65B94
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD65C18
	protected internal override void PackToCore(Packer packer, Int64 value) { }

	// RVA: 0xD65C38
	protected internal override Int64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SByteMessagePackSerializer
{
	// Methods

	// RVA: 0xD65E70
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD65EF4
	protected internal override void PackToCore(Packer packer, SByte value) { }

	// RVA: 0xD65F14
	protected internal override SByte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SingleMessagePackSerializer
{
	// Methods

	// RVA: 0xD6614C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD661D0
	protected internal override void PackToCore(Packer packer, float value) { }

	// RVA: 0xD661EC
	protected internal override float UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_TimeSpanMessagePackSerializer
{
	// Methods

	// RVA: 0xD66424
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD664A8
	protected internal override void PackToCore(Packer packer, TimeSpan value) { }

	// RVA: 0xD6652C
	protected internal override TimeSpan UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt16MessagePackSerializer
{
	// Methods

	// RVA: 0xD66764
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD667E8
	protected internal override void PackToCore(Packer packer, UInt16 value) { }

	// RVA: 0xD66808
	protected internal override UInt16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt32MessagePackSerializer
{
	// Methods

	// RVA: 0xD66A40
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD66AC4
	protected internal override void PackToCore(Packer packer, UInt32 value) { }

	// RVA: 0xD66AE4
	protected internal override UInt32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt64MessagePackSerializer
{
	// Methods

	// RVA: 0xD66D1C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD66DA0
	protected internal override void PackToCore(Packer packer, UInt64 value) { }

	// RVA: 0xD66DC0
	protected internal override UInt64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_BitVector32MessagePackSerializer
{
	// Methods

	// RVA: 0xD66FF8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6707C
	protected internal override void PackToCore(Packer packer, BitVector32 value) { }

	// RVA: 0xD6709C
	protected internal override BitVector32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class GenericSerializer
{
	// Methods

	// RVA: 0x30A53B0
	public static MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0xD672D4
	public static MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema schema) { }

	// RVA: 0xD67688
	private static MessagePackSerializer CreateArraySerializer(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD67700
	private static MessagePackSerializer CreateNullableSerializer(SerializationContext context, Type nullableType, Type underlyingType) { }

	// RVA: 0xD677A8
	private static MessagePackSerializer CreateListSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD678C4
	private static MessagePackSerializer CreateDictionarySerializer(SerializationContext context, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema schema) { }

	// RVA: 0xD67DD8
	public static MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD67ED0
	internal static MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema, CollectionTraits traits) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class MessagePackObjectExtensions
{
	// Methods

	// RVA: 0xD63B50
	public static Int64 DeserializeAsInt64(MessagePackObject source) { }

	// RVA: 0xD68164
	public static string DeserializeAsString(MessagePackObject source) { }

	// RVA: 0xD63994
	public static MessagePackExtendedTypeObject DeserializeAsMessagePackExtendedTypeObject(MessagePackObject source) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackExtendedTypeObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD68320
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD683A4
	protected internal override void PackToCore(Packer packer, MessagePackExtendedTypeObject value) { }

	// RVA: 0xD683C8
	protected internal override MessagePackExtendedTypeObject UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectDictionaryMessagePackSerializer
{
	// Methods

	// RVA: 0xD685B0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD68634
	protected internal override void PackToCore(Packer packer, MessagePackObjectDictionary objectTree) { }

	// RVA: 0xD68900
	protected internal override MessagePackObjectDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD68AF4
	protected internal override void UnpackToCore(Unpacker unpacker, MessagePackObjectDictionary collection) { }

	// RVA: 0xD689D4
	private static void UnpackToCore(Unpacker unpacker, int count, MessagePackObjectDictionary collection) { }

	// RVA: 0xD68B6C
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD68BD4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD68C58
	protected internal override void PackToCore(Packer packer, MessagePackObject value) { }

	// RVA: 0xD68CD4
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

	// RVA: 0xD692C4
	public void .ctor() { }

	// RVA: 0xD6A4C0
	internal void <PackArrayCore>b__0(int[] indices) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public Unpacker unpacker; // 0x10
	public UnityMultidimensionalArraySerializer <>4__this; // 0x18

	// Methods

	// RVA: 0xD6A168
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1
{
	// Fields
	public Unpacker arrayUnpacker; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xD6A4B0
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2
{
	// Fields
	public Array result; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xD6A4B8
	public void .ctor() { }

	// RVA: 0xD6A514
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

	// RVA: 0xD5A4F0
	public void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD68D40
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD68DD8
	private void PackArrayCore(Packer packer, Array array) { }

	// RVA: 0xD692CC
	private static void GetArrayMetadata(Array array, int[] lengths, int[] lowerBounds) { }

	// RVA: 0xD69638
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6A170
	private void ReadArrayMetadata(Unpacker metadataUnpacker, int[] lengths, int[] lowerBounds) { }

	// RVA: 0xD6940C
	private static void ForEach(Array array, int totalLength, int[] lowerBounds, int[] lengths, System.Action<System.Int32[]> action) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NativeDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xD62FDC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6A5B4
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD6A65C
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NullableMessagePackSerializer
{
	// Fields
	private readonly MessagePackSerializer _valueSerializer; // 0x38

	// Methods

	// RVA: 0xD679FC
	public void .ctor(SerializationContext ownerContext, Type nullableType, Type underlyingType) { }

	// RVA: 0xD62FA4
	public void .ctor(SerializationContext ownerContext, Type nullableType, MessagePackSerializer valueSerializer) { }

	// RVA: 0xD6A6EC
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD6A70C
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

	// RVA: 0x30A5298
	private static System.Action<MsgPack.Packer,System.ArraySegment<T>,MsgPack.Serialization.MessagePackSerializer<T>> InitializePacking() { }

	// RVA: 0x30A5298
	private static System.Func<MsgPack.Unpacker,MsgPack.Serialization.MessagePackSerializer<T>,System.ArraySegment<T>> InitializeUnpacking() { }

	// RVA: 0x30A27C0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x315B3A8
	protected internal sealed override void PackToCore(Packer packer, System.ArraySegment<T> objectTree) { }

	// RVA: 0x315B3A8
	protected internal sealed override System.ArraySegment<T> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30A6D04
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteArrayMessagePackSerializer
{
	// Methods

	// RVA: 0xD6A72C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6A7B0
	protected internal override void PackToCore(Packer packer, Byte[] value) { }

	// RVA: 0xD6A7D0
	protected internal override Byte[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharArrayMessagePackSerializer
{
	// Methods

	// RVA: 0xD6A8A4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6A928
	protected internal override void PackToCore(Packer packer, Char[] value) { }

	// RVA: 0xD6A964
	protected internal override Char[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_DictionaryEntryMessagePackSerializer
{
	// Methods

	// RVA: 0xD6AA38
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6AABC
	protected internal override void PackToCore(Packer packer, DictionaryEntry objectTree) { }

	// RVA: 0xD6AB80
	private static MessagePackObject EnsureMessagePackObject(object obj) { }

	// RVA: 0xD6AC60
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

	// RVA: 0xD67B48
	public void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema keysSchema, PolymorphismSchema valuesSchema) { }

	// RVA: 0xD6AEB4
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD6B2E4
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6B97C
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD6B464
	private void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xD6B3F0
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_KeyValuePair_2MessagePackSerializer<T0, T1>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x315B3A8
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.KeyValuePair<TKey,TValue> objectTree) { }

	// RVA: 0x315B3A8
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

	// RVA: 0xD67A58
	public void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD6BA24
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD6BDDC
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6C2EC
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD6BFB4
	private void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xD6BE9C
	public object CreateInstance(int initialCapacity) { }

	// RVA: 0xD6C394
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_Collections_Generic_ListOfMessagePackObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD6C4AC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6C530
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.List<MsgPack.MessagePackObject> objectTree) { }

	// RVA: 0xD6C758
	protected internal override System.Collections.Generic.List<MsgPack.MessagePackObject> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6C92C
	protected internal override void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection) { }

	// RVA: 0xD6C840
	private static void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection, int count) { }

	// RVA: 0xD6C9CC
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_Queue_1MessagePackSerializer<T0>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TItem> _itemSerializer; // 0x0

	// Methods

	// RVA: 0x30A27C0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x30A2A20
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.Queue<TItem> objectTree) { }

	// RVA: 0x30A188C
	protected internal override System.Collections.Generic.Queue<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30A2A20
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

	// RVA: 0x30A27C0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x30A2A20
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.Stack<TItem> objectTree) { }

	// RVA: 0x30A188C
	protected internal override System.Collections.Generic.Stack<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30A2A20
	protected internal override void UnpackToCore(Unpacker unpacker, System.Collections.Generic.Stack<TItem> collection) { }

	// RVA: 0x30A18F8
	private System.Collections.Generic.IEnumerable<TItem> UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: -1
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_QueueMessagePackSerializer
{
	// Methods

	// RVA: 0xD6CA48
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6CACC
	protected internal override void PackToCore(Packer packer, Queue objectTree) { }

	// RVA: 0xD6CD68
	protected internal override Queue UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6CE4C
	protected internal override void UnpackToCore(Unpacker unpacker, Queue collection) { }

	// RVA: 0xD6CFC8
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_NameValueCollectionMessagePackSerializer
{
	// Methods

	// RVA: 0xD6D030
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6D0B4
	protected internal override void PackToCore(Packer packer, NameValueCollection objectTree) { }

	// RVA: 0xD6D494
	protected internal override NameValueCollection UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6D8B8
	protected internal override void UnpackToCore(Unpacker unpacker, NameValueCollection collection) { }

	// RVA: 0xD6D568
	private static void UnpackToCore(Unpacker unpacker, NameValueCollection collection, int keyCount) { }

	// RVA: 0xD6D958
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_StackMessagePackSerializer
{
	// Methods

	// RVA: 0xD6D9C0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6DA44
	protected internal override void PackToCore(Packer packer, Stack objectTree) { }

	// RVA: 0xD6DCE0
	protected internal override Stack UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6E018
	protected internal override void UnpackToCore(Unpacker unpacker, Stack collection) { }

	// RVA: 0xD6DDB0
	private static ICollection UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: 0xD6E364
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_DBNullMessagePackSerializer
{
	// Methods

	// RVA: 0xD6E3CC
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6E450
	protected internal override void PackToCore(Packer packer, DBNull objectTree) { }

	// RVA: 0xD6E46C
	protected internal override DBNull UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6E4C0
	protected internal override DBNull UnpackNil() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Globalization_CultureInfoMessagePackSerializer
{
	// Methods

	// RVA: 0xD6E53C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6E5C0
	protected internal override void PackToCore(Packer packer, CultureInfo objectTree) { }

	// RVA: 0xD6E604
	protected internal override CultureInfo UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD6E694
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6E718
	protected internal override void PackToCore(Packer packer, object value) { }

	// RVA: 0xD6E820
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_StringMessagePackSerializer
{
	// Methods

	// RVA: 0xD6EB5C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6EBE0
	protected internal override void PackToCore(Packer packer, string value) { }

	// RVA: 0xD6EC00
	protected internal override string UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Text_StringBuilderMessagePackSerializer
{
	// Methods

	// RVA: 0xD6ECC0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6ED44
	protected internal override void PackToCore(Packer packer, StringBuilder value) { }

	// RVA: 0xD6ED88
	protected internal override StringBuilder UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD6EE78
	protected internal override void UnpackToCore(Unpacker unpacker, StringBuilder collection) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UriMessagePackSerializer
{
	// Methods

	// RVA: 0xD6EF4C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6EFD0
	protected internal override void PackToCore(Packer packer, Uri objectTree) { }

	// RVA: 0xD6F014
	protected internal override Uri UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_VersionMessagePackSerializer
{
	// Methods

	// RVA: 0xD6F094
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6F118
	protected internal override void PackToCore(Packer packer, Version objectTree) { }

	// RVA: 0xD6F190
	protected internal override Version UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xD63060
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD6F41C
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD6F4C8
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampMessagePackSerializer
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xD6F570
	public void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xD6F608
	protected internal override void PackToCore(Packer packer, Timestamp objectTree) { }

	// RVA: 0xD6F7A0
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

	// RVA: 0xD6FA78
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD6FEF0
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class UnixEpocDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xD62F20
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD70124
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD701C0
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityCollectionMessagePackSerializer
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40
	private readonly MethodInfo _add; // 0x48

	// Methods

	// RVA: 0xD584C0
	protected void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD70334
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD706F4
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD58798
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD70984
	protected override void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializer<T0, T1, T2>
{
	// Methods

	// RVA: 0x315B3A8
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

	// RVA: 0xD58A40
	protected void .ctor(SerializationContext ownerContext, Type targetType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD70A70
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD70ED4
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD58D44
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD713CC
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD713DC
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD70F30
	private void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializerBase<T0, T1, T2>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x315B3A8
	protected internal override void PackToCore(Packer packer, TDictionary objectTree) { }

	// RVA: -1
	protected abstract int GetCount(TDictionary dictionary) { }

	// RVA: 0x315B3A8
	protected internal override TDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x315B3A8
	internal virtual TDictionary InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract TDictionary CreateInstance(int initialCapacity) { }

	// RVA: 0x315B3A8
	private void UnpackToCore(Unpacker unpacker, TDictionary collection, int itemsCount) { }

	// RVA: 0x315B3A8
	protected virtual void AddItem(TDictionary dictionary, TKey key, TValue value) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityEnumerableMessagePackSerializer
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40

	// Methods

	// RVA: 0xD58F94
	protected void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD71484
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

	// RVA: 0xD71890
	internal MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xD70250
	protected void .ctor(SerializationContext ownerContext, Type targetType, Type itemType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD71898
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD718A8
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD70750
	internal void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xD71950
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

	// RVA: 0xD51CAC
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD524D0
	protected internal override void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericDictionaryMessagePackSerializer
{
	// Fields
	private readonly MessagePackSerializer _keySerializer; // 0x38
	private readonly MessagePackSerializer _valueSerializer; // 0x40

	// Methods

	// RVA: 0xD53A88
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD53D34
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD542A0
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD595B0
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD71F0C
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD71F1C
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD71ACC
	private void UnpackToCore(Unpacker unpacker, IDictionary collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializer
{
	// Methods

	// RVA: 0xD5304C
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD53170
	protected internal override void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializerBase
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38

	// Methods

	// RVA: 0xD71FF0
	internal MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xD71988
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD71FF8
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD72008
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD52A1C
	internal void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xD720B0
	protected virtual void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericListMessagePackSerializer
{
	// Methods

	// RVA: 0xD54620
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD548A8
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD59BF4
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD720E8
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


