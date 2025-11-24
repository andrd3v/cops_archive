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

	// RVA: 0x26AD93C
	public <member>j__TPar get_member() { }

	// RVA: 0x26AD93C
	public <data>j__TPar get_data() { }

	// RVA: 0x26AD93C
	public void .ctor(<member>j__TPar member, <data>j__TPar data) { }

	// RVA: 0x35252FC
	public override bool Equals(object value) { }

	// RVA: 0x35254D0
	public override int GetHashCode() { }

	// RVA: 0x3525804
	public override string ToString() { }

}

// Namespace: MsgPack
internal static class BigEndianBinary
{
	// Methods

	// RVA: 0xD3E58C
	public static Int16 ToInt16(Byte[] buffer, int offset) { }

	// RVA: 0xD3E5D4
	public static int ToInt32(Byte[] buffer, int offset) { }

	// RVA: 0xD3E64C
	public static Int64 ToInt64(Byte[] buffer, int offset) { }

	// RVA: 0xD3E724
	public static Byte ToByte(Byte[] buffer, int offset) { }

	// RVA: 0xD3E754
	public static UInt16 ToUInt16(Byte[] buffer, int offset) { }

	// RVA: 0xD3E79C
	public static UInt32 ToUInt32(Byte[] buffer, int offset) { }

	// RVA: 0xD3E814
	public static UInt64 ToUInt64(Byte[] buffer, int offset) { }

	// RVA: 0xD3E8EC
	public static float ToSingle(Byte[] buffer, int offset) { }

	// RVA: 0xD3E9E8
	public static Double ToDouble(Byte[] buffer, int offset) { }

}

// Namespace: MsgPack
internal static class Binary
{
	// Fields
	public static readonly Byte[] Empty; // 0x0

	// Methods

	// RVA: 0xD3EB14
	public static string ToHexString(Byte[] blob) { }

	// RVA: 0xD3EB9C
	public static string ToHexString(Byte[] blob, bool withPrefix) { }

	// RVA: 0xD3EDC8
	public static void ToHexString(Byte[] blob, StringBuilder buffer) { }

	// RVA: 0xD3EC94
	private static void ToHexStringCore(Byte[] blob, StringBuilder buffer, bool withPrefix) { }

	// RVA: 0xD3EE50
	private static Char ToHexChar(int b) { }

	// RVA: 0xD3EE6C
	public static int ToBits(float value) { }

	// RVA: 0xD3EE7C
	public static Int64 ToBits(Double value) { }

	// RVA: 0xD3EE84
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class BufferManager
{
	// Methods

	// RVA: 0xD3EF04
	public static Byte[] NewByteBuffer(int size) { }

	// RVA: 0xD3EF8C
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

	// RVA: 0xD3F014
	protected void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD3F080
	public System.ArraySegment<System.Byte> GetResultBytes() { }

	// RVA: -1
	public abstract Byte[] GetFinalBuffer() { }

}

// Namespace: MsgPack
public abstract class ByteArrayUnpacker
{
	// Methods

	// RVA: 0xD3F138
	protected void .ctor() { }

}

// Namespace: MsgPack
internal abstract class ByteBufferAllocator
{
	// Methods

	// RVA: -1
	public abstract bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xD3F140
	protected void .ctor() { }

}

// Namespace: MsgPack
internal sealed class CollectionDebuggerProxy<T0>
{}

// Namespace: MsgPack
internal static class CollectionOperation
{
	// Methods

	// RVA: 0x26AD93C
	public static void CopyTo(System.Collections.Generic.IEnumerable<T> source, int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x26AD93C
	public static void CopyTo(System.Collections.Generic.IEnumerable<TSource> source, int sourceCount, int index, TDestination[] array, int arrayIndex, int count, System.Func<TSource,TDestination> converter) { }

	// RVA: 0x26AD93C
	private static void ValidateCopyToArguments(int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x26AD93C
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

	// RVA: 0xD3F148
	public static bool EncodeString(Encoder source, Char[] chars, int charsOffset, int charsLength, Byte[] buffer, int bufferOffset, int bufferCount, int charsUsed, int bytesUsed) { }

	// RVA: 0xD3F190
	public static bool DecodeString(Decoder source, Byte[] bytes, int bytesOffset, int bytesLength, Char[] buffer, StringBuilder result) { }

}

// Namespace: MsgPack
internal sealed class FixedArrayBufferAllocator
{
	// Fields
	public static readonly ByteBufferAllocator Instance; // 0x0

	// Methods

	// RVA: 0xD3F2B0
	private void .ctor() { }

	// RVA: 0xD3F2B8
	public override bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xD3F2DC
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

	// RVA: 0xD3EE74
	public void .ctor(float value) { }

	// RVA: 0xD3E95C
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

	// RVA: 0xD3EA18
	public void .ctor(Byte[] bigEndianBytes, int offset) { }

}

// Namespace: MsgPack
[Serializable]
public sealed class InvalidMessagePackStreamException
{
	// Methods

	// RVA: 0xD3F348
	public void .ctor() { }

	// RVA: 0xD3F3CC
	public void .ctor(string message) { }

	// RVA: 0xD3F460
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xD3F4F8
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

	// RVA: 0xD3F57C
	public static Byte get_Timestamp() { }

	// RVA: 0xD3F584
	public static Byte get_MultidimensionalArray() { }

}

// Namespace: MsgPack
public static class KnownExtTypeName
{
	// Methods

	// RVA: 0xD3F58C
	public static string get_Timestamp() { }

	// RVA: 0xD3F5D0
	public static string get_MultidimensionalArray() { }

}

// Namespace: MsgPack
[Serializable]
public sealed class MessageNotSupportedException
{
	// Methods

	// RVA: 0xD3F614
	public void .ctor() { }

	// RVA: 0xD3F698
	public void .ctor(string message) { }

	// RVA: 0xD3F72C
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xD3F7C4
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

	// RVA: 0xD3F848
	public override int get_BytesUsed() { }

	// RVA: 0xD3F854
	public override int get_InitialBufferOffset() { }

	// RVA: 0xD3F85C
	public void .ctor(Byte[] buffer, int startOffset, ByteBufferAllocator allocator, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD3FA40
	public override Byte[] GetFinalBuffer() { }

	// RVA: 0xD3FA48
	protected override void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xD3FB24
	protected override void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xD3FB44
	protected override void WriteByte(Byte value) { }

	// RVA: 0xD3FD2C
	private void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xD3FB04
	private void WriteBytes(Byte[] value) { }

	// RVA: 0xD3FC00
	private void ThrowEofException(int requiredSize) { }

	// RVA: 0xD3FDFC
	protected override void PackCore(bool value) { }

	// RVA: 0xD3FE28
	protected override void PackCore(Byte value) { }

	// RVA: 0xD3FF34
	protected override void PackCore(SByte value) { }

	// RVA: 0xD3FF5C
	protected override void PackCore(Int16 value) { }

	// RVA: 0xD400AC
	protected override void PackCore(UInt16 value) { }

	// RVA: 0xD400E8
	protected override void PackCore(int value) { }

	// RVA: 0xD402A0
	protected override void PackCore(UInt32 value) { }

	// RVA: 0xD402F0
	protected override void PackCore(Int64 value) { }

	// RVA: 0xD40558
	protected override void PackCore(UInt64 value) { }

	// RVA: 0xD405BC
	protected override void PackCore(float value) { }

	// RVA: 0xD40774
	protected override void PackCore(Double value) { }

	// RVA: 0xD409BC
	protected override void PackArrayHeaderCore(int length) { }

	// RVA: 0xD409FC
	protected override void PackMapHeaderCore(int length) { }

	// RVA: 0xD40A38
	protected override void PackStringHeaderCore(int length) { }

	// RVA: 0xD40A94
	protected override void PackBinaryHeaderCore(int length) { }

	// RVA: 0xD40AC8
	protected override void PackRawCore(string value) { }

	// RVA: 0xD40C84
	protected override void PackRawCore(Byte[] value) { }

	// RVA: 0xD40D34
	protected override void PackBinaryCore(Byte[] value) { }

	// RVA: 0xD40DB4
	protected override void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xD40EF0
	private void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xD3FE4C
	private void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xD3FFA0
	private void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xD4014C
	private void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xD40374
	private void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xD405C4
	private void WriteBytes(Byte header, float value) { }

	// RVA: 0xD4077C
	private void WriteBytes(Byte header, Double value) { }

	// RVA: 0xD40AD8
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

	// RVA: 0xD40F4C
	public sealed override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xD40FC4
	protected sealed override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD410A8
	public sealed override MessagePackObject get_LastReadData() { }

	// RVA: 0xD410B4
	protected sealed override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xD410C0
	public sealed override bool get_IsArrayHeader() { }

	// RVA: 0xD410D0
	public sealed override bool get_IsMapHeader() { }

	// RVA: 0xD410E0
	public sealed override bool get_IsCollectionHeader() { }

	// RVA: 0xD410F0
	public sealed override Int64 get_ItemsCount() { }

	// RVA: 0xD4137C
	private CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xD41384
	private System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xD413C8
	private void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD41404
	private MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xD41410
	private void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xD4141C
	internal override bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xD4142C
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xD41624
	private bool ReadBinaryCore(int length, int offset, Byte[] result) { }

	// RVA: 0xD4176C
	private bool ReadStringCore(int length, int offset, string result) { }

	// RVA: 0xD41900
	private bool ReadRawStringCore(int length, int offset, MessagePackString result) { }

	// RVA: 0xD41C18
	private bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xD41CD8
	public sealed override bool ReadByte(Byte result) { }

	// RVA: 0xD41E10
	private bool ReadByteSlow(ReadValueResult header, Byte[] source, int offset, Byte result) { }

	// RVA: 0xD422A4
	public sealed override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD4247C
	private bool ReadNullableByteSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Byte>& result) { }

	// RVA: 0xD42570
	public sealed override bool ReadSByte(SByte result) { }

	// RVA: 0xD4269C
	private bool ReadSByteSlow(ReadValueResult header, Byte[] source, int offset, SByte result) { }

	// RVA: 0xD42994
	public sealed override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD42B60
	private bool ReadNullableSByteSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.SByte>& result) { }

	// RVA: 0xD42C54
	public sealed override bool ReadInt16(Int16 result) { }

	// RVA: 0xD42D84
	private bool ReadInt16Slow(ReadValueResult header, Byte[] source, int offset, Int16 result) { }

	// RVA: 0xD4306C
	public sealed override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD4323C
	private bool ReadNullableInt16Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int16>& result) { }

	// RVA: 0xD43330
	public sealed override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD4346C
	private bool ReadUInt16Slow(ReadValueResult header, Byte[] source, int offset, UInt16 result) { }

	// RVA: 0xD43704
	public sealed override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD438E0
	private bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD439D4
	public sealed override bool ReadInt32(int result) { }

	// RVA: 0xD43B04
	private bool ReadInt32Slow(ReadValueResult header, Byte[] source, int offset, int result) { }

	// RVA: 0xD43DE8
	public sealed override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD43FB8
	private bool ReadNullableInt32Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int32>& result) { }

	// RVA: 0xD440AC
	public sealed override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD441E8
	private bool ReadUInt32Slow(ReadValueResult header, Byte[] source, int offset, UInt32 result) { }

	// RVA: 0xD444AC
	public sealed override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD44688
	private bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD4477C
	public sealed override bool ReadInt64(Int64 result) { }

	// RVA: 0xD448AC
	private bool ReadInt64Slow(ReadValueResult header, Byte[] source, int offset, Int64 result) { }

	// RVA: 0xD44B78
	public sealed override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD44D48
	private bool ReadNullableInt64Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int64>& result) { }

	// RVA: 0xD44E3C
	public sealed override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD44F78
	private bool ReadUInt64Slow(ReadValueResult header, Byte[] source, int offset, UInt64 result) { }

	// RVA: 0xD45224
	public sealed override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD45400
	private bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD454F4
	public sealed override bool ReadSingle(float result) { }

	// RVA: 0xD45628
	private bool ReadSingleSlow(ReadValueResult header, Byte[] source, int offset, float result) { }

	// RVA: 0xD4588C
	public sealed override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD45A60
	private bool ReadNullableSingleSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Single>& result) { }

	// RVA: 0xD45B54
	public sealed override bool ReadDouble(Double result) { }

	// RVA: 0xD45C88
	private bool ReadDoubleSlow(ReadValueResult header, Byte[] source, int offset, Double result) { }

	// RVA: 0xD45EE4
	public sealed override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD460B8
	private bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Double>& result) { }

	// RVA: 0xD461AC
	public sealed override bool ReadBoolean(bool result) { }

	// RVA: 0xD462F4
	public sealed override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD464BC
	public sealed override bool ReadBinary(Byte[] result) { }

	// RVA: 0xD468B8
	public sealed override bool ReadString(string result) { }

	// RVA: 0xD41C78
	private bool ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xD46AC4
	private bool ReadObjectCore(bool isDeep, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xD46E1C
	private bool ReadObjectSlow(ReadValueResult header, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xD47BBC
	private bool ReadItems(int count, bool isMap, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xD48020
	private bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] source, int offset, MessagePackExtendedTypeObject result) { }

	// RVA: 0xD48D00
	protected sealed override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD48DB8
	public sealed override bool ReadObject(MessagePackObject result) { }

	// RVA: 0xD48E1C
	protected sealed override bool ReadCore() { }

	// RVA: 0xD485D0
	private void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xD468A4
	private void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD48E88
	private void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD466C8
	private void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xD420C8
	private void ThrowTypeException(Type type, ReadValueResult header) { }

}

// Namespace: MsgPack
internal static class MessagePackCode
{
	// Methods

	// RVA: 0xD49038
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

	// RVA: 0xD4924C
	internal static Encoding get_Utf8NonBom() { }

	// RVA: 0xD492C8
	internal static Encoding get_Utf8NonBomStrict() { }

	// RVA: 0xD49344
	public static Byte[] EncodeString(string value) { }

	// RVA: 0xD49408
	public static string DecodeStringStrict(Byte[] value) { }

	// RVA: 0xD494D4
	public static DateTimeOffset ToDateTimeOffset(Int64 value) { }

	// RVA: 0xD495B4
	public static DateTime ToDateTime(Int64 value) { }

	// RVA: 0xD49690
	public static Int64 FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xD49794
	public static Int64 FromDateTime(DateTime value) { }

	// RVA: 0xD49880
	private static void .cctor() { }

}

// Namespace: MsgPack
public struct MessagePackExtendedTypeObject
{
	// Fields
	private readonly Byte _typeCode; // 0x10
	private readonly Byte[] _body; // 0x18

	// Methods

	// RVA: 0xD49984
	public Byte get_TypeCode() { }

	// RVA: 0xD4998C
	internal Byte[] get_Body() { }

	// RVA: 0xD49A1C
	public bool get_IsValid() { }

	// RVA: 0xD49A2C
	private void .ctor(Byte[] body, Byte unpackedTypeCode) { }

	// RVA: 0xD48C78
	public static MessagePackExtendedTypeObject Unpack(Byte typeCode, Byte[] body) { }

	// RVA: 0xD49A98
	public override string ToString() { }

	// RVA: 0xD49B54
	internal void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xD49DBC
	public override int GetHashCode() { }

	// RVA: 0xD49F3C
	public override bool Equals(object obj) { }

	// RVA: 0xD4A04C
	public bool Equals(MessagePackExtendedTypeObject other) { }

	// RVA: 0xD4A0D8
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

	// RVA: 0xD51338
	public MessagePackValueTypeCode get_TypeCode() { }

	// RVA: 0xD4A614
	public bool get_IsSigned() { }

	// RVA: 0xD4A604
	public bool get_IsInteger() { }

	// RVA: 0xD51340
	public Type get_Type() { }

	// RVA: 0xD512F0
	internal void .ctor(Type type, MessagePackValueTypeCode typeCode) { }

	// RVA: 0xD51348
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

	// RVA: 0xD513E4
	private static void .cctor() { }

	// RVA: 0xD51450
	public void .ctor() { }

	// RVA: 0xD51458
	internal int <GetHashCode>b__84_0(int hash, MessagePackObject item) { }

	// RVA: 0xD514CC
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

	// RVA: 0xD4A168
	public void .ctor(bool value) { }

	// RVA: 0xD4A1E4
	public void .ctor(int value) { }

	// RVA: 0xD47F80
	public void .ctor(Byte[] value, bool isBinary) { }

	// RVA: 0xD4A260
	public bool AsBoolean() { }

	// RVA: 0xD4A3B8
	public Byte AsByte() { }

	// RVA: 0xD4A620
	public SByte AsSByte() { }

	// RVA: 0xD4A880
	public Int16 AsInt16() { }

	// RVA: 0xD4AAE0
	public UInt16 AsUInt16() { }

	// RVA: 0xD4796C
	public int AsInt32() { }

	// RVA: 0xD4ACE8
	public UInt32 AsUInt32() { }

	// RVA: 0xD41174
	public Int64 AsInt64() { }

	// RVA: 0xD4AEF8
	public UInt64 AsUInt64() { }

	// RVA: 0xD4B0F8
	public float AsSingle() { }

	// RVA: 0xD4B2B8
	public Double AsDouble() { }

	// RVA: 0xD4B478
	public string AsString() { }

	// RVA: 0xD4B550
	public Byte[] AsBinary() { }

	// RVA: 0xD4B628
	public MessagePackExtendedTypeObject AsMessagePackExtendedTypeObject() { }

	// RVA: 0xD4B744
	public static MessagePackObject op_Implicit(bool value) { }

	// RVA: 0xD48374
	public static MessagePackObject op_Implicit(Byte value) { }

	// RVA: 0xD48158
	public static MessagePackObject op_Implicit(SByte value) { }

	// RVA: 0xD481E0
	public static MessagePackObject op_Implicit(Int16 value) { }

	// RVA: 0xD47E68
	public static MessagePackObject op_Implicit(UInt16 value) { }

	// RVA: 0xD48268
	public static MessagePackObject op_Implicit(int value) { }

	// RVA: 0xD47EF0
	public static MessagePackObject op_Implicit(UInt32 value) { }

	// RVA: 0xD482F0
	public static MessagePackObject op_Implicit(Int64 value) { }

	// RVA: 0xD483FC
	public static MessagePackObject op_Implicit(UInt64 value) { }

	// RVA: 0xD48480
	public static MessagePackObject op_Implicit(float value) { }

	// RVA: 0xD4854C
	public static MessagePackObject op_Implicit(Double value) { }

	// RVA: 0xD4B7CC
	public static MessagePackObject op_Implicit(string value) { }

	// RVA: 0xD46D90
	public static MessagePackObject op_Implicit(Byte[] value) { }

	// RVA: 0xD480D0
	public static MessagePackObject op_Implicit(MessagePackExtendedTypeObject value) { }

	// RVA: 0xD4B854
	public static bool op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4B978
	public static Byte op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4BB74
	public static SByte op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4BD8C
	public static Int16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4BFA4
	public static UInt16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4C18C
	public static int op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4C394
	public static UInt32 op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4C584
	public static Int64 op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4C76C
	public static float op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4C910
	public static Double op_Explicit(MessagePackObject value) { }

	// RVA: 0xD4A3A8
	public bool get_IsNil() { }

	// RVA: 0xD4CAB4
	public void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD48730
	public void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value, bool isImmutable) { }

	// RVA: 0xD4CB20
	public void .ctor(MessagePackObjectDictionary value) { }

	// RVA: 0xD48BF4
	public void .ctor(MessagePackObjectDictionary value, bool isImmutable) { }

	// RVA: 0xD47F78
	internal void .ctor(MessagePackString messagePackString) { }

	// RVA: 0xD4D424
	public override bool Equals(object obj) { }

	// RVA: 0xD4D5A4
	public bool Equals(MessagePackObject other) { }

	// RVA: 0xD4DD7C
	private bool EqualsWhenValueType(MessagePackObject other, ValueTypeCode valueTypeCode, ValueTypeCode otherValuetypeCode) { }

	// RVA: 0xD4E1F0
	private static bool IntegerIntegerEquals(UInt64 left, ValueTypeCode leftTypeCode, UInt64 right, ValueTypeCode rightTypeCode) { }

	// RVA: 0xD4E260
	private static bool IntegerSingleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xD4E33C
	private static bool IntegerDoubleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xD4E414
	public override int GetHashCode() { }

	// RVA: 0xD4E6F8
	public override string ToString() { }

	// RVA: 0xD4E7A0
	private void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xD4F334
	private static void ToStringBinary(StringBuilder buffer, bool isJson, MessagePackString asBinary) { }

	// RVA: -1
	public System.Nullable<System.Boolean> IsTypeOf() { }

	// RVA: 0xD4F798
	public System.Nullable<System.Boolean> IsTypeOf(Type type) { }

	// RVA: 0xD4FE40
	public bool get_IsRaw() { }

	// RVA: 0xD4FEF0
	public Type get_UnderlyingType() { }

	// RVA: 0xD50014
	public void PackToMessage(Packer packer, PackingOptions options) { }

	// RVA: 0xD50DC0
	public Char[] AsCharArray() { }

	// RVA: 0x26AD93C
	private static void VerifyUnderlyingType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x26AD93C
	private static void VerifyUnderlyingRawType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x352AE04
	private static void ThrowCannotBeNilAs() { }

	// RVA: -1
	private static void ThrowInvalidTypeAs(MessagePackObject instance) { }

	// RVA: 0xD50E48
	public static bool op_Equality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xD4E170
	public static bool op_Inequality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xD50EC4
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

	// RVA: 0xD54BE4
	public System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> get_Current() { }

	// RVA: 0xD54CDC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xD54E20
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0xD54FDC
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0xD550EC
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0xD54D48
	internal System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> GetCurrentStrict() { }

	// RVA: 0xD55200
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD54C64
	internal void VerifyVersion() { }

	// RVA: 0xD553B4
	public void Dispose() { }

	// RVA: 0xD55408
	public bool MoveNext() { }

	// RVA: 0xD55648
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xD552EC
	internal void ResetCore() { }

}

// Namespace: 
private struct DictionaryEnumerator
{
	// Fields
	private IDictionaryEnumerator _underlying; // 0x10

	// Methods

	// RVA: 0xD55710
	public object get_Current() { }

	// RVA: 0xD557E8
	public DictionaryEntry get_Entry() { }

	// RVA: 0xD558A0
	public object get_Key() { }

	// RVA: 0xD55958
	public object get_Value() { }

	// RVA: 0xD55A08
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD55B6C
	public bool MoveNext() { }

	// RVA: 0xD55C20
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xD561C0
	public MessagePackObject get_Current() { }

	// RVA: 0xD562F0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xD55FC4
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD56400
	public void Dispose() { }

	// RVA: 0xD56454
	public bool MoveNext() { }

	// RVA: 0xD564CC
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
public sealed class KeyCollection
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xD55CD8
	public int get_Count() { }

	// RVA: 0xD55CF8
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xD55D00
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xD55D08
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xD55D0C
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD55D40
	public void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xD55DE0
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xD55E5C
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xD55E7C
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xD55EBC
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xD55EFC
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xD55F3C
	public Enumerator GetEnumerator() { }

	// RVA: 0xD56038
	private System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xD560FC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xD56A7C
	public MessagePackObject get_Current() { }

	// RVA: 0xD56BB0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xD56880
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD56CC4
	public void Dispose() { }

	// RVA: 0xD56D18
	public bool MoveNext() { }

	// RVA: 0xD56D90
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
public sealed class ValueCollection
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xD56594
	public int get_Count() { }

	// RVA: 0xD565B4
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xD565BC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xD565C4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xD565C8
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD565FC
	public void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xD5669C
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xD56718
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xD56738
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xD56778
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xD567B8
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xD567F8
	public Enumerator GetEnumerator() { }

	// RVA: 0xD568F4
	private System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xD569B8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xD56E58
	public void .ctor() { }

	// RVA: 0xD56E60
	internal bool <TryGetValue>b__0(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xD56EE4
	public void .ctor() { }

	// RVA: 0xD56EEC
	internal bool <AddCore>b__0(MessagePackObject item) { }

	// RVA: 0xD56F70
	internal bool <AddCore>b__1(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass59_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xD56FF4
	public void .ctor() { }

	// RVA: 0xD56FFC
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

	// RVA: 0xD57080
	private static void .cctor() { }

	// RVA: 0xD570EC
	public void .ctor() { }

	// RVA: 0xD570F4
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

	// RVA: 0xD51548
	public bool get_IsFrozen() { }

	// RVA: 0xD51550
	public int get_Count() { }

	// RVA: 0xD515C8
	public MessagePackObject get_Item(MessagePackObject key) { }

	// RVA: 0xD51AA0
	public void set_Item(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xD52174
	public KeyCollection get_Keys() { }

	// RVA: 0xD521DC
	public ValueCollection get_Values() { }

	// RVA: 0xD52244
	private System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Keys() { }

	// RVA: 0xD522AC
	private System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Values() { }

	// RVA: 0xD52314
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.get_IsReadOnly() { }

	// RVA: 0xD5231C
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0xD52324
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0xD5232C
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0xD52334
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0xD5239C
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0xD52730
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0xD528E8
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xD528F0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xD528F4
	public void .ctor() { }

	// RVA: 0xD488A0
	public void .ctor(int initialCapacity) { }

	// RVA: 0xD4CC0C
	public void .ctor(System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject> dictionary) { }

	// RVA: 0xD517F0
	private static void ThrowKeyNotNilException(string parameterName) { }

	// RVA: 0xD529AC
	private static void ThrowDuplicatedKeyException(MessagePackObject key, string parameterName) { }

	// RVA: 0xD51BFC
	private void VerifyIsNotFrozen() { }

	// RVA: 0xD52520
	private static MessagePackObject ValidateObjectArgument(object obj, string parameterName) { }

	// RVA: 0xD52AE4
	private static System.Nullable<MsgPack.MessagePackObject> TryValidateObjectArgument(object value) { }

	// RVA: 0xD53000
	public bool ContainsKey(MessagePackObject key) { }

	// RVA: 0xD531D8
	public bool ContainsValue(MessagePackObject value) { }

	// RVA: 0xD53314
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Contains(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xD53544
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0xD5184C
	public bool TryGetValue(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xD48A98
	public void Add(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xD51C64
	private void AddCore(MessagePackObject key, MessagePackObject value, bool allowOverwrite) { }

	// RVA: 0xD53710
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Add(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xD539F8
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0xD53BB4
	public bool Remove(MessagePackObject key) { }

	// RVA: 0xD53D00
	private bool RemoveCore(MessagePackObject key, MessagePackObject value, bool checkValue) { }

	// RVA: 0xD54050
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Remove(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xD54338
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0xD544D0
	public void Clear() { }

	// RVA: 0xD5464C
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.CopyTo(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>[] array, int arrayIndex) { }

	// RVA: 0xD54788
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xD549FC
	public Enumerator GetEnumerator() { }

	// RVA: 0xD54A20
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.GetEnumerator() { }

	// RVA: 0xD54AC4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD54B68
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

}

// Namespace: MsgPack
[Serializable]
internal sealed class MessagePackObjectEqualityComparer
{
	// Fields
	private static readonly MessagePackObjectEqualityComparer _instance; // 0x0

	// Methods

	// RVA: 0xD5729C
	internal static MessagePackObjectEqualityComparer get_Instance() { }

	// RVA: 0xD57318
	public void .ctor() { }

	// RVA: 0xD57320
	public bool Equals(MessagePackObject x, MessagePackObject y) { }

	// RVA: 0xD573A0
	public int GetHashCode(MessagePackObject obj) { }

	// RVA: 0xD57408
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

	// RVA: 0xD57474
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD576D8
	protected override void Dispose(bool disposing) { }

	// RVA: 0xD57710
	protected override void WriteByte(Byte value) { }

	// RVA: 0xD57738
	protected override void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xD577A0
	protected override void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xD5776C
	private void WriteBytes(Byte[] value) { }

	// RVA: 0xD5786C
	private void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xD57894
	protected override void PackCore(bool value) { }

	// RVA: 0xD578C0
	protected override void PackCore(Byte value) { }

	// RVA: 0xD579A8
	protected override void PackCore(SByte value) { }

	// RVA: 0xD57A34
	protected override void PackCore(Int16 value) { }

	// RVA: 0xD57B64
	protected override void PackCore(UInt16 value) { }

	// RVA: 0xD57C08
	protected override void PackCore(int value) { }

	// RVA: 0xD57D94
	protected override void PackCore(UInt32 value) { }

	// RVA: 0xD57E50
	protected override void PackCore(Int64 value) { }

	// RVA: 0xD58070
	protected override void PackCore(UInt64 value) { }

	// RVA: 0xD58144
	protected override void PackCore(float value) { }

	// RVA: 0xD58290
	protected override void PackCore(Double value) { }

	// RVA: 0xD5844C
	protected override void PackArrayHeaderCore(int length) { }

	// RVA: 0xD5848C
	protected override void PackMapHeaderCore(int length) { }

	// RVA: 0xD584C8
	protected override void PackStringHeaderCore(int length) { }

	// RVA: 0xD58590
	protected override void PackBinaryHeaderCore(int length) { }

	// RVA: 0xD5862C
	protected override void PackRawCore(string value) { }

	// RVA: 0xD58734
	protected override void PackRawCore(Byte[] value) { }

	// RVA: 0xD5883C
	protected override void PackBinaryCore(Byte[] value) { }

	// RVA: 0xD58920
	protected override void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xD58AB4
	private void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xD57940
	private void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xD57AE0
	private void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xD57CD8
	private void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xD57F44
	private void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xD5814C
	private void WriteBytes(Byte header, float value) { }

	// RVA: 0xD58298
	private void WriteBytes(Byte header, Double value) { }

	// RVA: 0xD586B4
	private void WriteBytes(string value, bool allowStr8) { }

	// RVA: 0xD58B7C
	private void WriteStringBody(string value) { }

	// RVA: 0xD58C68
	private void WriteStringBody(Char[] value, int remainingCharsLength) { }

	// RVA: 0xD58D54
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

	// RVA: 0xD58D8C
	public sealed override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xD58E04
	protected sealed override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD58EE8
	public sealed override MessagePackObject get_LastReadData() { }

	// RVA: 0xD58EF4
	protected sealed override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xD58F00
	public sealed override bool get_IsArrayHeader() { }

	// RVA: 0xD58F10
	public sealed override bool get_IsMapHeader() { }

	// RVA: 0xD58F20
	public sealed override Int64 get_ItemsCount() { }

	// RVA: 0xD58FAC
	public sealed override bool get_IsCollectionHeader() { }

	// RVA: 0xD58FBC
	private CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xD58FC4
	private System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xD59008
	private void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD59044
	private MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xD59050
	private void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xD5905C
	internal override bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xD5906C
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD59204
	protected override void Dispose(bool disposing) { }

	// RVA: 0xD59270
	protected void BeginReadSubtree() { }

	// RVA: 0xD59280
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD592B0
	private bool ReadBinaryCore(int length, Int64 offset, Byte[] result) { }

	// RVA: 0xD595B8
	private bool ReadStringCore(int length, Int64 offset, string result) { }

	// RVA: 0xD59884
	private bool ReadRawStringCore(int length, Int64 offset, MessagePackString result) { }

	// RVA: 0xD59BAC
	private bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xD59458
	private void ThrowEofException(Int64 reading) { }

	// RVA: 0xD59C74
	public sealed override bool ReadByte(Byte result) { }

	// RVA: 0xD59DC0
	private bool ReadByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, Byte result) { }

	// RVA: 0xD5A2B4
	public sealed override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD5A4A0
	private bool ReadNullableByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Byte>& result) { }

	// RVA: 0xD5A594
	public sealed override bool ReadSByte(SByte result) { }

	// RVA: 0xD5A6D4
	private bool ReadSByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, SByte result) { }

	// RVA: 0xD5AA24
	public sealed override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD5AC04
	private bool ReadNullableSByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.SByte>& result) { }

	// RVA: 0xD5ACF8
	public sealed override bool ReadInt16(Int16 result) { }

	// RVA: 0xD5AE3C
	private bool ReadInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, Int16 result) { }

	// RVA: 0xD5B18C
	public sealed override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD5B370
	private bool ReadNullableInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int16>& result) { }

	// RVA: 0xD5B464
	public sealed override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD5B5B4
	private bool ReadUInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt16 result) { }

	// RVA: 0xD5B8DC
	public sealed override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD5BACC
	private bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD5BBC0
	public sealed override bool ReadInt32(int result) { }

	// RVA: 0xD5BCF0
	private bool ReadInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, int result) { }

	// RVA: 0xD5C034
	public sealed override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD5C218
	private bool ReadNullableInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int32>& result) { }

	// RVA: 0xD5C30C
	public sealed override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD5C448
	private bool ReadUInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt32 result) { }

	// RVA: 0xD5C768
	public sealed override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD5C958
	private bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD5CA4C
	public sealed override bool ReadInt64(Int64 result) { }

	// RVA: 0xD5CB90
	private bool ReadInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, Int64 result) { }

	// RVA: 0xD5CEC0
	public sealed override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD5D0A4
	private bool ReadNullableInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int64>& result) { }

	// RVA: 0xD5D198
	public sealed override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD5D2E8
	private bool ReadUInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt64 result) { }

	// RVA: 0xD5D5F8
	public sealed override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD5D7E8
	private bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD5D8DC
	public sealed override bool ReadSingle(float result) { }

	// RVA: 0xD5DA24
	private bool ReadSingleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, float result) { }

	// RVA: 0xD5DCF4
	public sealed override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD5DEDC
	private bool ReadNullableSingleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Single>& result) { }

	// RVA: 0xD5DFD0
	public sealed override bool ReadDouble(Double result) { }

	// RVA: 0xD5E118
	private bool ReadDoubleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, Double result) { }

	// RVA: 0xD5E3E0
	public sealed override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD5E5C8
	private bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Double>& result) { }

	// RVA: 0xD5E6BC
	public sealed override bool ReadBoolean(bool result) { }

	// RVA: 0xD5E818
	public sealed override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD5E9F4
	public sealed override bool ReadBinary(Byte[] result) { }

	// RVA: 0xD5EF24
	public sealed override bool ReadString(string result) { }

	// RVA: 0xD59C10
	private bool ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xD5F268
	private bool ReadObjectCore(bool isDeep, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xD5F4E4
	private bool ReadObjectSlow(ReadValueResult header, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xD6030C
	private bool ReadItems(int count, bool isMap, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xD6058C
	private bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] buffer, Int64 offset, MessagePackExtendedTypeObject result) { }

	// RVA: 0xD607E4
	protected sealed override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD6089C
	public sealed override bool ReadObject(MessagePackObject result) { }

	// RVA: 0xD60904
	protected sealed override bool ReadCore() { }

	// RVA: 0xD60684
	private void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xD5EF10
	private void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD60974
	private void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD5ED38
	private void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xD5A0DC
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

	// RVA: 0xD59AB0
	public void .ctor(string decoded) { }

	// RVA: 0xD59AF0
	public void .ctor(Byte[] encoded, bool isBinary) { }

	// RVA: 0xD60E68
	private void EncodeIfNeeded() { }

	// RVA: 0xD60F70
	private void DecodeIfNeeded() { }

	// RVA: 0xD610BC
	public string TryGetString() { }

	// RVA: 0xD610E0
	public string GetString() { }

	// RVA: 0xD611A0
	public Byte[] UnsafeGetBuffer() { }

	// RVA: 0xD611A8
	public Byte[] GetBytes() { }

	// RVA: 0xD611CC
	public Type GetUnderlyingType() { }

	// RVA: 0xD61290
	public override string ToString() { }

	// RVA: 0xD6133C
	public override int GetHashCode() { }

	// RVA: 0xD615A8
	public override bool Equals(object obj) { }

	// RVA: 0xD6168C
	private static bool EqualsEncoded(MessagePackString left, MessagePackString right) { }

	// RVA: 0xD617FC
	private static bool SlowEquals(Byte[] x, Byte[] y) { }

	// RVA: 0xD61884
	private static void .cctor() { }

}

// Namespace: MsgPack
[Serializable]
public class MessageTypeException
{
	// Methods

	// RVA: 0xD61924
	public void .ctor() { }

	// RVA: 0xD60DD4
	public void .ctor(string message) { }

	// RVA: 0xD619A8
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xD61A40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: MsgPack
internal sealed class PureAttribute
{
	// Methods

	// RVA: 0xD61AC4
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

	// RVA: 0xD61ACC
	public static PackerCompatibilityOptions get_DefaultCompatibilityOptions() { }

	// RVA: 0xD61B30
	public PackerCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xD575EC
	protected void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD61B38
	public void Dispose() { }

	// RVA: 0xD5770C
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD61BD0
	private void VerifyNotDisposed() { }

	// RVA: 0xD61C38
	private void ThrowObjectDisposedException() { }

	// RVA: -1
	protected abstract void WriteByte(Byte value) { }

	// RVA: 0xD61C8C
	protected virtual void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xD62004
	protected virtual void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xD620F0
	public Packer Pack(SByte value) { }

	// RVA: 0xD62170
	protected virtual void PackCore(SByte value) { }

	// RVA: 0xD62200
	protected bool TryPackInt8(Int64 value) { }

	// RVA: 0xD62260
	public Packer Pack(Byte value) { }

	// RVA: 0xD622E0
	protected virtual void PackCore(Byte value) { }

	// RVA: 0xD622EC
	protected bool TryPackUInt8(UInt64 value) { }

	// RVA: 0xD62340
	public Packer Pack(bool value) { }

	// RVA: 0xD623C0
	protected virtual void PackCore(bool value) { }

	// RVA: 0xD621C4
	protected bool TryPackTinySignedInteger(Int64 value) { }

	// RVA: 0xD623EC
	protected bool TryPackTinyUnsignedInteger(UInt64 value) { }

	// RVA: 0xD62428
	public Packer PackNull() { }

	// RVA: 0xD624AC
	private void PrivatePackNullCore() { }

	// RVA: 0xD61FBC
	private static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xD624BC
	private static void ThrowCannotBeNegativeException(string parameterName) { }

	// RVA: 0xD62584
	private static void ThrowMissingBodyOfExtTypeValueException(string parameterName) { }

	// RVA: 0xD625E0
	private static void ThrowExtTypeIsProhibitedException() { }

	// RVA: 0xD62634
	public static Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD62824
	public static Packer Create(Stream stream, bool ownsStream) { }

	// RVA: 0xD62744
	public static Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions, bool ownsStream) { }

	// RVA: 0xD628F8
	public static ByteArrayPacker Create(Byte[] buffer, bool allowsBufferExpansion, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD629D8
	public Packer Pack(System.Nullable<System.SByte> value) { }

	// RVA: 0xD62B28
	public Packer Pack(System.Nullable<System.Byte> value) { }

	// RVA: 0xD62C5C
	public Packer Pack(System.Nullable<System.Int16> value) { }

	// RVA: 0xD62E2C
	public Packer Pack(System.Nullable<System.UInt16> value) { }

	// RVA: 0xD62FE8
	public Packer Pack(System.Nullable<System.Int32> value) { }

	// RVA: 0xD631A4
	public Packer Pack(System.Nullable<System.UInt32> value) { }

	// RVA: 0xD63360
	public Packer Pack(System.Nullable<System.Int64> value) { }

	// RVA: 0xD63534
	public Packer Pack(System.Nullable<System.UInt64> value) { }

	// RVA: 0xD63708
	public Packer Pack(System.Nullable<System.Single> value) { }

	// RVA: 0xD638DC
	public Packer Pack(System.Nullable<System.Double> value) { }

	// RVA: 0xD63AB0
	public Packer Pack(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD62DAC
	public Packer Pack(Int16 value) { }

	// RVA: 0xD63BEC
	protected virtual void PackCore(Int16 value) { }

	// RVA: 0xD63C68
	protected bool TryPackInt16(Int64 value) { }

	// RVA: 0xD62F64
	public Packer Pack(UInt16 value) { }

	// RVA: 0xD63CDC
	protected virtual void PackCore(UInt16 value) { }

	// RVA: 0xD63D4C
	protected bool TryPackUInt16(UInt64 value) { }

	// RVA: 0xD63120
	public Packer Pack(int value) { }

	// RVA: 0xD63DB4
	protected virtual void PackCore(int value) { }

	// RVA: 0xD63E6C
	protected bool TryPackInt32(Int64 value) { }

	// RVA: 0xD632DC
	public Packer Pack(UInt32 value) { }

	// RVA: 0xD63F10
	protected virtual void PackCore(UInt32 value) { }

	// RVA: 0xD63FC0
	protected bool TryPackUInt32(UInt64 value) { }

	// RVA: 0xD634B0
	public Packer Pack(Int64 value) { }

	// RVA: 0xD64058
	protected virtual void PackCore(Int64 value) { }

	// RVA: 0xD64170
	protected bool TryPackInt64(Int64 value) { }

	// RVA: 0xD63684
	public Packer Pack(UInt64 value) { }

	// RVA: 0xD64244
	protected virtual void PackCore(UInt64 value) { }

	// RVA: 0xD64358
	protected bool TryPackUInt64(UInt64 value) { }

	// RVA: 0xD63858
	public Packer Pack(float value) { }

	// RVA: 0xD6442C
	protected virtual void PackCore(float value) { }

	// RVA: 0xD63A2C
	public Packer Pack(Double value) { }

	// RVA: 0xD644D0
	protected virtual void PackCore(Double value) { }

	// RVA: 0xD645A8
	public Packer PackArrayHeader(int count) { }

	// RVA: 0xD64694
	protected virtual void PackArrayHeaderCore(int count) { }

	// RVA: 0xD6473C
	public Packer PackMapHeader(int count) { }

	// RVA: 0xD64828
	protected virtual void PackMapHeaderCore(int count) { }

	// RVA: 0xD648CC
	public Packer PackStringHeader(int length) { }

	// RVA: 0xD649B8
	public Packer PackBinaryHeader(int length) { }

	// RVA: 0xD64AC8
	protected virtual void PackStringHeaderCore(int length) { }

	// RVA: 0xD64B9C
	protected virtual void PackBinaryHeaderCore(int length) { }

	// RVA: 0xD64C44
	public Packer PackRaw(Byte[] value) { }

	// RVA: 0xD64CF0
	protected virtual void PackRawCore(Byte[] value) { }

	// RVA: 0xD64D40
	public Packer PackBinary(Byte[] value) { }

	// RVA: 0xD64E18
	protected virtual void PackBinaryCore(Byte[] value) { }

	// RVA: 0xD64E68
	public Packer PackString(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xD64FF0
	public Packer PackString(string value) { }

	// RVA: 0xD65048
	protected virtual void PackStringCore(string value, Encoding encoding) { }

	// RVA: 0xD651A4
	protected virtual void PackRawCore(string value) { }

	// RVA: 0xD64F44
	private void PackRawCore(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xD651E4
	public Packer PackRawBody(Byte[] value) { }

	// RVA: 0xD65304
	public Packer PackRawBody(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xD6541C
	private int PrivatePackRawBodyCore(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xD6579C
	private int PrivatePackRawBodyCore(System.Collections.Generic.ICollection<System.Byte> value, bool isImmutable) { }

	// RVA: 0xD658A4
	public Packer PackExtendedTypeValue(Byte typeCode, Byte[] body) { }

	// RVA: 0xD65A34
	public Packer PackExtendedTypeValue(MessagePackExtendedTypeObject mpeto) { }

	// RVA: 0xD65BA0
	protected virtual void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xD65CE0
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

	// RVA: 0x26AD93C
	public static Packer Pack(Packer source, T value) { }

	// RVA: 0x26AD93C
	private static void PackCore(Packer source, T value, SerializationContext context) { }

	// RVA: 0xD65D34
	public static Packer PackObject(Packer source, object value) { }

	// RVA: 0xD65ED4
	public static Packer PackObject(Packer source, object value, SerializationContext context) { }

	// RVA: 0xD65DFC
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

	// RVA: 0xD65F68
	private static bool ShouldWrapStream(Stream stream) { }

	// RVA: 0xD6602C
	public bool get_WithBuffering() { }

	// RVA: 0xD66034
	public void set_WithBuffering(bool value) { }

	// RVA: 0xD6603C
	public bool get_OwnsStream() { }

	// RVA: 0xD66044
	public void set_OwnsStream(bool value) { }

	// RVA: 0xD6604C
	public void .ctor() { }

	// RVA: 0xD57618
	internal Stream WrapStream(Stream stream) { }

	// RVA: 0xD6605C
	private static void .cctor() { }

}

// Namespace: MsgPack
public sealed class PackingOptions
{
	// Fields
	private Encoding _stringEncoding; // 0x10

	// Methods

	// RVA: 0xD66244
	public void .ctor() { }

}

// Namespace: MsgPack
internal sealed class PreserveAttribute
{
	// Fields
	public bool AllMembers; // 0x10

	// Methods

	// RVA: 0xD66318
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

	// RVA: 0xD66FCC
	private static void .cctor() { }

	// RVA: 0xD67038
	public void .ctor() { }

	// RVA: 0xD67040
	internal ReadValueResult <.cctor>b__5_0(int i) { }

	// RVA: 0xD67048
	internal ReadValueResult <.cctor>b__5_1(int i) { }

	// RVA: 0xD67058
	internal ReadValueResult <.cctor>b__5_2(int i) { }

	// RVA: 0xD67068
	internal ReadValueResult <.cctor>b__5_3(int i) { }

	// RVA: 0xD67074
	internal ReadValueResult <.cctor>b__5_4(int b) { }

	// RVA: 0xD6707C
	internal MessagePackObject <.cctor>b__5_5(int x) { }

	// RVA: 0xD670A8
	internal MessagePackObject <.cctor>b__5_6(int x) { }

	// RVA: 0xD670D4
	internal MessagePackObject <.cctor>b__5_7(int x) { }

	// RVA: 0xD67100
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

	// RVA: 0xD60B28
	public static Byte ToByte(ReadValueResult source) { }

	// RVA: 0xD66320
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class ReflectionAbstractions
{
	// Fields
	public static readonly Char TypeDelimiter; // 0x0
	public static readonly Type[] EmptyTypes; // 0x8

	// Methods

	// RVA: 0xD6712C
	public static bool GetIsValueType(Type source) { }

	// RVA: 0xD67144
	public static bool GetIsEnum(Type source) { }

	// RVA: 0xD67168
	public static bool GetIsInterface(Type source) { }

	// RVA: 0xD67180
	public static bool GetIsAbstract(Type source) { }

	// RVA: 0xD67198
	public static bool GetIsGenericType(Type source) { }

	// RVA: 0xD671BC
	public static bool GetIsGenericTypeDefinition(Type source) { }

	// RVA: 0xD671E0
	public static Assembly GetAssembly(Type source) { }

	// RVA: 0xD67204
	public static bool GetIsVisible(Type source) { }

	// RVA: 0xD6721C
	public static bool GetIsNestedPublic(Type source) { }

	// RVA: 0xD67234
	public static Type GetBaseType(Type source) { }

	// RVA: 0xD67258
	public static MethodInfo GetRuntimeMethod(Type source, string name, Type[] parameters) { }

	// RVA: 0xD67280
	public static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetRuntimeMethods(Type source) { }

	// RVA: 0xD672A8
	public static Delegate CreateDelegate(MethodInfo source, Type delegateType) { }

	// RVA: 0xD672BC
	public static Delegate CreateDelegate(MethodInfo source, Type delegateType, object target) { }

	// RVA: 0xD672D4
	public static string GetCultureName(AssemblyName source) { }

	// RVA: 0xD67304
	public static bool GetHasDefaultValue(ParameterInfo source) { }

	// RVA: 0xD6738C
	private static void .cctor() { }

}

// Namespace: MsgPack
internal sealed class SingleArrayBufferAllocator
{
	// Fields
	public static readonly SingleArrayBufferAllocator Default; // 0x0
	private readonly System.Func<System.Byte[],System.Int32,System.Byte[]> _allocator; // 0x10

	// Methods

	// RVA: 0xD67414
	public void .ctor(System.Func<System.Byte[],System.Int32,System.Byte[]> allocator) { }

	// RVA: 0xD67448
	private static Byte[] Allocate(Byte[] old, int requestSize) { }

	// RVA: 0xD67560
	public override bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xD6762C
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class StringEscape
{
	// Methods

	// RVA: 0xD676F4
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

	// RVA: 0xD679F4
	public override Int64 get_ItemsCount() { }

	// RVA: 0xD67AC0
	public override bool get_IsArrayHeader() { }

	// RVA: 0xD67B70
	public override bool get_IsMapHeader() { }

	// RVA: 0xD67C20
	public override bool get_IsCollectionHeader() { }

	// RVA: 0xD67CD0
	public override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xD67DA4
	protected override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD67E8C
	public override MessagePackObject get_LastReadData() { }

	// RVA: 0xD67F44
	protected override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xD68004
	public void .ctor(Unpacker parent) { }

	// RVA: 0xD6800C
	private void .ctor(Unpacker root, SubtreeUnpacker parent) { }

	// RVA: 0xD68338
	protected override void Dispose(bool disposing) { }

	// RVA: 0xD683B4
	public override void Drain() { }

	// RVA: 0xD683F4
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD68640
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD687EC
	private static void ThrowInTailException() { }

	// RVA: 0xD68840
	private static void ThrowNotInHeadOfCollectionException() { }

	// RVA: 0xD68894
	protected override bool ReadCore() { }

	// RVA: 0xD68B18
	protected override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD684C8
	private void DiscardCompletedStacks() { }

	// RVA: 0xD68C78
	public override bool ReadBoolean(bool result) { }

	// RVA: 0xD68F4C
	public override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD69220
	public override bool ReadByte(Byte result) { }

	// RVA: 0xD694F4
	public override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD697C8
	public override bool ReadSByte(SByte result) { }

	// RVA: 0xD69A9C
	public override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD69D70
	public override bool ReadInt16(Int16 result) { }

	// RVA: 0xD6A044
	public override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD6A318
	public override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD6A5EC
	public override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD6A8C0
	public override bool ReadInt32(int result) { }

	// RVA: 0xD6AB94
	public override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD6AE68
	public override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD6B13C
	public override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD6B410
	public override bool ReadInt64(Int64 result) { }

	// RVA: 0xD6B6E4
	public override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD6B9B8
	public override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD6BC8C
	public override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD6BF60
	public override bool ReadSingle(float result) { }

	// RVA: 0xD6C234
	public override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD6C508
	public override bool ReadDouble(Double result) { }

	// RVA: 0xD6C7DC
	public override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD6CAB0
	public override bool ReadBinary(Byte[] result) { }

	// RVA: 0xD6CD74
	public override bool ReadString(string result) { }

	// RVA: 0xD6D038
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

	// RVA: 0xD6EE98
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

	// RVA: 0xD6D370
	public int CompareTo(Timestamp other) { }

	// RVA: 0xD6D3D8
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xD6D548
	public override bool Equals(object obj) { }

	// RVA: 0xD6D628
	public bool Equals(Timestamp other) { }

	// RVA: 0xD6D64C
	public override int GetHashCode() { }

	// RVA: 0xD6D6A0
	private Int64 ToTicks(Type destination) { }

	// RVA: 0xD6D838
	public DateTime ToDateTime() { }

	// RVA: 0xD6D904
	public DateTimeOffset ToDateTimeOffset() { }

	// RVA: 0xD6DA00
	public MessagePackExtendedTypeObject Encode() { }

	// RVA: 0xD6DC68
	private static void FromDateTimeTicks(Int64 ticks, Int64 unixEpocSeconds, int nanoSeconds) { }

	// RVA: 0xD6DCF0
	private static void FromOffsetTicks(Int64 ticks, Int64 unixEpocSeconds, int nanoSeconds) { }

	// RVA: 0xD6DEB0
	public static Timestamp FromDateTime(DateTime value) { }

	// RVA: 0xD6E148
	public static Timestamp FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xD6E2C8
	public static Timestamp Decode(MessagePackExtendedTypeObject value) { }

	// RVA: 0xD6E4C0
	public static Timestamp op_Implicit(DateTimeOffset value) { }

	// RVA: 0xD6E0BC
	public void .ctor(Int64 unixEpochSeconds, int nanoseconds) { }

	// RVA: 0xD6DE34
	internal static Int64 DivRem(Int64 dividend, Int64 divisor, Int64 remainder) { }

	// RVA: 0xD6E54C
	public int get_Hour() { }

	// RVA: 0xD6E6A8
	public int get_Minute() { }

	// RVA: 0xD6E804
	public int get_Second() { }

	// RVA: 0xD6E83C
	private void GetDatePart(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD6EB98
	private void GetDatePartAD(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD6E918
	private void GetDatePartBC(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD6EDC4
	public override string ToString() { }

	// RVA: 0xD6EE4C
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xD6F148
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class TimestampStringConverter
{
	// Methods

	// RVA: 0xD6F010
	public static string ToString(string format, IFormatProvider formatProvider, Value value) { }

	// RVA: 0xD6F350
	private static string ToIso8601String(IFormatProvider formatProvider, bool containsNanosecons, Value value) { }

}

// Namespace: MsgPack
[Serializable]
public sealed class UnassignedMessageTypeException
{
	// Methods

	// RVA: 0xD6F59C
	public void .ctor() { }

	// RVA: 0xD6F5F8
	public void .ctor(string message) { }

	// RVA: 0xD6F660
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xD6F6D4
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

	// RVA: 0xD70078
	public void .ctor(int <>1__state) { }

	// RVA: 0xD725C8
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD725CC
	private bool MoveNext() { }

	// RVA: 0xD726B4
	private MessagePackObject System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject>.get_Current() { }

	// RVA: 0xD726C0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xD72700
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

	// RVA: 0xD6F6DC
	public virtual MessagePackObject get_LastReadData() { }

	// RVA: 0xD6F7D4
	protected virtual void set_LastReadData(MessagePackObject value) { }

	// RVA: -1
	public abstract bool get_IsArrayHeader() { }

	// RVA: -1
	public abstract bool get_IsMapHeader() { }

	// RVA: 0xD6F87C
	public virtual bool get_IsCollectionHeader() { }

	// RVA: -1
	public abstract Int64 get_ItemsCount() { }

	// RVA: 0xD6F8C4
	internal void VerifyMode(UnpackerMode mode) { }

	// RVA: 0xD6F910
	internal void VerifyIsNotDisposed() { }

	// RVA: 0xD6FA80
	private void ThrowObjectDisposedException() { }

	// RVA: 0xD6F994
	internal void ThrowInvalidModeException() { }

	// RVA: 0xD6FAEC
	internal virtual bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xD6FAFC
	public static Unpacker Create(Stream stream, bool ownsStream) { }

	// RVA: 0xD6FBE0
	public static Unpacker Create(Stream stream, PackerUnpackerStreamOptions streamOptions, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD6FC88
	public static ByteArrayUnpacker Create(Byte[] source, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD6FD1C
	public static ByteArrayUnpacker Create(Byte[] source, int startOffset, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD6FDC4
	protected void .ctor() { }

	// RVA: 0xD6FDCC
	public void Dispose() { }

	// RVA: 0xD6FE60
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD6FE64
	public virtual void Drain() { }

	// RVA: 0xD6FE68
	public Unpacker ReadSubtree() { }

	// RVA: 0xD6FE78
	internal virtual Unpacker InternalReadSubtree() { }

	// RVA: 0xD6FE88
	internal static void ThrowCannotBeSubtreeModeException() { }

	// RVA: 0xD6FEDC
	internal static void ThrowInSubtreeModeException() { }

	// RVA: -1
	protected abstract Unpacker ReadSubtreeCore() { }

	// RVA: 0xD6FF30
	protected internal virtual void EndReadSubtree() { }

	// RVA: 0xD6FF40
	public bool Read() { }

	// RVA: 0xD6FFA8
	internal bool ReadInternal() { }

	// RVA: 0xD6FFFC
	internal virtual void EnsureNotInSubtreeMode() { }

	// RVA: 0xD6FF38
	private void SetStable() { }

	// RVA: -1
	protected abstract bool ReadCore() { }

	// RVA: 0xD70000
	public System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> GetEnumerator() { }

	// RVA: 0xD700A4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD7011C
	public System.Nullable<System.Int64> Skip() { }

	// RVA: 0xD701F4
	private void BeginSkip() { }

	// RVA: 0xD70230
	private void EndSkip(System.Nullable<System.Int64> result) { }

	// RVA: -1
	protected abstract System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD702C0
	public MessagePackObject ReadItemData() { }

	// RVA: 0xD70404
	internal virtual void ThrowEofException() { }

	// RVA: 0xD70398
	public MessagePackObject UnpackSubtreeData() { }

	// RVA: 0xD70458
	internal bool UnpackSubtreeDataCore(MessagePackObject result) { }

	// RVA: 0xD709D4
	public virtual bool ReadBoolean(bool result) { }

	// RVA: 0xD70AB0
	public virtual bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD70C08
	public virtual bool ReadByte(Byte result) { }

	// RVA: 0xD70CE4
	public virtual bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD70E3C
	public virtual bool ReadSByte(SByte result) { }

	// RVA: 0xD70F18
	public virtual bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD71070
	public virtual bool ReadInt16(Int16 result) { }

	// RVA: 0xD7114C
	public virtual bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD712C0
	public virtual bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD7139C
	public virtual bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD71510
	public virtual bool ReadInt32(int result) { }

	// RVA: 0xD715EC
	public virtual bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD71764
	public virtual bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD71840
	public virtual bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD719B8
	public virtual bool ReadInt64(Int64 result) { }

	// RVA: 0xD71A9C
	public virtual bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD71C18
	public virtual bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD71CFC
	public virtual bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD71E78
	public virtual bool ReadSingle(float result) { }

	// RVA: 0xD71F58
	public virtual bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD720D0
	public virtual bool ReadDouble(Double result) { }

	// RVA: 0xD721B0
	public virtual bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD7232C
	public virtual bool ReadBinary(Byte[] result) { }

	// RVA: 0xD72424
	public virtual bool ReadString(string result) { }

	// RVA: 0xD7251C
	public virtual bool ReadObject(MessagePackObject result) { }

}

// Namespace: MsgPack
internal sealed class FastStreamUnpacker
{
	// Methods

	// RVA: 0xD6FC80
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD72768
	protected override Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingStreamUnpacker
{
	// Fields
	private bool _isSubtreeReading; // 0x60

	// Methods

	// RVA: 0xD6FC78
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD72790
	internal override Unpacker InternalReadSubtree() { }

	// RVA: 0xD72878
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD728E0
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD728EC
	internal override void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
internal sealed class FastByteArrayUnpacker
{
	// Methods

	// RVA: 0xD6FDBC
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xD7297C
	protected override Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingByteArrayUnpacker
{
	// Fields
	private bool _isSubtreeReading; // 0x48

	// Methods

	// RVA: 0xD6FDB4
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xD72980
	internal override Unpacker InternalReadSubtree() { }

	// RVA: 0xD72A68
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD72AD0
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD72ADC
	internal override void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
public sealed class UnpackerOptions
{
	// Fields
	private UnpackerValidationLevel <ValidationLevel>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD72B6C
	public UnpackerValidationLevel get_ValidationLevel() { }

	// RVA: 0xD72B74
	public void set_ValidationLevel(UnpackerValidationLevel value) { }

	// RVA: 0xD72B7C
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

	// RVA: 0xD72BA8
	public static int Read(int field) { }

	// RVA: 0xD72BB0
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

	// RVA: 0xD72BB8
	public CollectionKind get_CollectionType() { }

	// RVA: 0xD72C64
	public void .ctor(CollectionDetailedKind type, Type elementType, MethodInfo getEnumeratorMethod, MethodInfo addMethod, MethodInfo countPropertyGetter) { }

	// RVA: 0xD72CD0
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

	// RVA: 0xD72E20
	public string get_Name() { }

	// RVA: 0xD72E28
	public int get_Id() { }

	// RVA: 0xD72E30
	public NilImplication get_NilImplication() { }

	// RVA: 0xD72E38
	public void .ctor() { }

	// RVA: 0xD72E74
	public void .ctor(MemberInfo member) { }

	// RVA: 0xD72ECC
	public void .ctor(MemberInfo member, string name, NilImplication nilImplication, System.Nullable<System.Int32> id) { }

	// RVA: 0xD7323C
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

	// RVA: 0xD732C0
	public static DateTimeConversionMethod DetermineDateTimeConversionMethod(SerializationContext context, DateTimeMemberConversionMethod dateTimeMemberConversionMethod) { }

	// RVA: 0xD73344
	internal static bool IsDateTime(Type dateTimeType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DefaultConcreteTypeRepository
{
	// Fields
	private readonly TypeKeyRepository _defaultCollectionTypes; // 0x10

	// Methods

	// RVA: 0xD73504
	internal void .ctor() { }

	// RVA: 0xD73A2C
	public Type Get(Type abstractCollectionType) { }

	// RVA: 0xD73B4C
	internal Type GetConcreteType(Type abstractCollectionType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DictionarySerlaizationOptions
{
	// Fields
	private bool _omitNullEntry; // 0x10
	private System.Func<System.String,System.String> _keyNameHandler; // 0x18

	// Methods

	// RVA: 0xD73C58
	public bool get_OmitNullEntry() { }

	// RVA: 0xD73C7C
	public System.Func<System.String,System.String> get_KeyTransformer() { }

	// RVA: 0xD73CA0
	internal System.Func<System.String,System.String> get_SafeKeyTransformer() { }

	// RVA: 0xD73D44
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

	// RVA: 0xD73D4C
	protected void .ctor(SerializationContext ownerContext, Type targetType, EnumSerializationMethod serializationMethod) { }

	// RVA: 0xD743BC
	protected internal sealed override void PackToCore(Packer packer, object objectTree) { }

	// RVA: -1
	protected internal abstract void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xD744A0
	protected internal sealed override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected internal abstract object UnpackFromUnderlyingValue(MessagePackObject messagePackObject) { }

	// RVA: 0xD74960
	private ICustomizableEnumSerializer MsgPack.Serialization.ICustomizableEnumSerializer.GetCopyAs(EnumSerializationMethod method) { }

}

// Namespace: MsgPack.Serialization
public static class EnumMessagePackSerializerHelpers
{
	// Methods

	// RVA: 0xD74A08
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

	// RVA: 0xD74BC0
	public void .ctor(Type enumType, ICustomizableEnumSerializer serializer) { }

	// RVA: 0xD74D14
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

	// RVA: 0xD74BB4
	public EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xD74DE8
	public System.Func<System.String,System.String> get_NameTransformer() { }

	// RVA: 0xD74318
	internal System.Func<System.String,System.String> get_SafeNameTransformer() { }

	// RVA: 0xD74E0C
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

	// RVA: 0xD74E14
	public Byte get_Item(string name) { }

	// RVA: 0xD7510C
	internal void .ctor() { }

	// RVA: 0xD75454
	public bool Add(string name, Byte typeCode) { }

	// RVA: 0xD7527C
	private bool AddInternal(string name, Byte typeCode) { }

	// RVA: 0xD75564
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Byte>> GetEnumerator() { }

	// RVA: 0xD75698
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD74FFC
	private static void ValidateName(string name) { }

	// RVA: 0xD754F4
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

	// RVA: 0xD75770
	private static void .cctor() { }

	// RVA: 0xD757DC
	public void .ctor() { }

	// RVA: 0xD757E4
	internal string <.cctor>b__3_0(string key) { }

}

// Namespace: MsgPack.Serialization
internal static class KeyNameTransformers
{
	// Fields
	public static readonly System.Func<System.String,System.String> AsIs; // 0x0

	// Methods

	// RVA: 0xD7569C
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class LazyDelegatingMessagePackSerializer<T0>
{
	// Fields
	private readonly object _providerParameter; // 0x0
	private MsgPack.Serialization.MessagePackSerializer<T> _delegated; // 0x0

	// Methods

	// RVA: 0x35269D4
	public void .ctor(SerializationContext ownerContext, object providerParameter) { }

	// RVA: 0x3525804
	private MsgPack.Serialization.MessagePackSerializer<T> GetDelegatedSerializer() { }

	// RVA: 0x26AD93C
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x26AD93C
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x26AD93C
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x3525804
	public override string ToString() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackDateTimeMemberAttribute
{
	// Fields
	private DateTimeMemberConversionMethod <DateTimeConversionMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD757EC
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

	// RVA: 0xD757F4
	public EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xD757FC
	public void set_SerializationMethod(EnumSerializationMethod value) { }

	// RVA: 0xD75804
	public void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackEnumMemberAttribute
{
	// Fields
	private EnumMemberSerializationMethod <SerializationMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD7580C
	public EnumMemberSerializationMethod get_SerializationMethod() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackIgnoreAttribute
{
	// Methods

	// RVA: 0xD75814
	public void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD7581C
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD75824
	public string get_TypeCode() { }

	// RVA: 0xD7582C
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownCollectionItemTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD75834
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD7583C
	public string get_TypeCode() { }

	// RVA: 0xD75844
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownDictionaryKeyTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD7584C
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD75854
	public string get_TypeCode() { }

	// RVA: 0xD7585C
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTupleItemTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD75864
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD7586C
	public string get_TypeCode() { }

	// RVA: 0xD75874
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

	// RVA: 0xD7587C
	public int get_Id() { }

	// RVA: 0xD75884
	public string get_Name() { }

	// RVA: 0xD7588C
	public NilImplication get_NilImplication() { }

	// RVA: 0xD75894
	public void .ctor(int id) { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD758C0
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD758C8
	public Type get_VerifierType() { }

	// RVA: 0xD758D0
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeCollectionItemTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD758D8
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD758E0
	public Type get_VerifierType() { }

	// RVA: 0xD758E8
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeDictionaryKeyTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD758F0
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD758F8
	public Type get_VerifierType() { }

	// RVA: 0xD75900
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTupleItemTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD75908
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD75910
	public Type get_VerifierType() { }

	// RVA: 0xD75918
	public string get_VerifierMethodName() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.Serialization.MessagePackSerializer.<>c <>9; // 0x0

	// Methods

	// RVA: 0xD75E88
	private static void .cctor() { }

	// RVA: 0xD75EF4
	public void .ctor() { }

	// RVA: 0xD75EFC
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

	// RVA: 0xD75920
	protected internal SerializationContext get_OwnerContext() { }

	// RVA: 0xD75928
	protected internal PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xD759C0
	internal void .ctor(SerializationContext ownerContext, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xD75AF0
	public void PackTo(Packer packer, object objectTree) { }

	// RVA: -1
	internal abstract void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0xD75AFC
	public object UnpackFrom(Unpacker unpacker) { }

	// RVA: -1
	internal abstract object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0xD75B08
	public void UnpackTo(Unpacker unpacker, object collection) { }

	// RVA: -1
	internal abstract void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xD75AA8
	internal static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0x35293B4
	public static MsgPack.Serialization.MessagePackSerializer<T> Get() { }

	// RVA: 0x35293EC
	public static MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x35294CC
	public static MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0x35294CC
	internal static MsgPack.Serialization.MessagePackSerializer<T> CreateInternal(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0x3529628
	internal static MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionInternal(SerializationContext context, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD75B14
	private static void ValidateType(Type type) { }

	// RVA: 0x35294CC
	internal static MsgPack.Serialization.MessagePackSerializer<T> Wrap(SerializationContext context, MessagePackSerializer nonGeneric) { }

	// RVA: 0x352AE04
	public static void PrepareType() { }

	// RVA: 0x352AE04
	public static void PrepareDictionaryType() { }

	// RVA: 0x352AE04
	public static void PrepareCollectionType() { }

	// RVA: 0x352BD5C
	private static void PrepareTypeCore(SerializationContext dummyContext) { }

	// RVA: 0xD75C4C
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
public abstract class MessagePackSerializer<T0>
{
	// Fields
	private static readonly bool IsNullable; // 0x0

	// Methods

	// RVA: 0x35267E8
	protected void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x3526850
	protected void .ctor(SerializationContext ownerContext, SerializerCapabilities capabilities) { }

	// RVA: -1
	private static bool JudgeNullable() { }

	// RVA: 0x35280F8
	private static SerializerCapabilities InferCapatibity() { }

	// RVA: 0x26AD93C
	public void Pack(Stream stream, T objectTree) { }

	// RVA: 0x26AD93C
	public T Unpack(Stream stream) { }

	// RVA: 0x26AD93C
	public void PackTo(Packer packer, T objectTree) { }

	// RVA: -1
	protected internal abstract void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x26AD93C
	public T UnpackFrom(Unpacker unpacker) { }

	// RVA: 0x26AD93C
	protected internal virtual T UnpackNil() { }

	// RVA: -1
	protected internal abstract T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x26AD93C
	public void UnpackTo(Unpacker unpacker, T collection) { }

	// RVA: 0x26AD93C
	protected internal virtual void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x26AD93C
	public Byte[] PackSingleObject(T objectTree) { }

	// RVA: 0x26AD93C
	public System.ArraySegment<System.Byte> PackSingleObjectAsBytes(T objectTree) { }

	// RVA: 0x26AD93C
	public T UnpackSingleObject(Byte[] buffer) { }

	// RVA: 0x35269D4
	internal sealed override void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0x35258B4
	internal sealed override object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x35269D4
	internal sealed override void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0x352CF50
	private static void ThrowArgumentException(string message, string parameterName) { }

	// RVA: 0x352AE04
	private static void ThrowNewValueTypeCannotBeNullException() { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal abstract class MessagePackSerializerProvider
{
	// Methods

	// RVA: 0xD74D0C
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

	// RVA: 0x26AD93C
	public TAction OnPacking(TPackingParameter parameter, NilImplication nilImplication) { }

	// RVA: -1
	protected abstract TCondition OnPackingMessagePackObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TCondition OnPackingReferenceTypeObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TCondition OnPackingNullableValueTypeObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnPackingCore(TPackingParameter parameter, TCondition condition) { }

	// RVA: 0x26AD93C
	public TAction OnUnpacked(TUnpackedParameter parameter, NilImplication nilImplication) { }

	// RVA: -1
	protected abstract TAction OnNopOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnThrowNullIsProhibitedExceptionOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnThrowValueTypeCannotBeNull3OnUnpacked(TUnpackedParameter parameter) { }

	// RVA: 0x35263A0
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

	// RVA: 0xD761FC
	internal void .ctor(string loadingTypeFullName, AssemblyName loadingAssemblyName, string loadingAssemblyFullName) { }

	// RVA: 0xD7624C
	public override string ToString() { }

	// RVA: 0xD762C4
	public override bool Equals(object obj) { }

	// RVA: 0xD76364
	public bool Equals(PolymorphicTypeVerificationContext other) { }

	// RVA: 0xD763B0
	public override int GetHashCode() { }

}

// Namespace: 
private sealed class ReadOnlyDictionary<T0, T1>
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<TKey,TValue> _underlying; // 0x0

	// Methods

	// RVA: 0x3525804
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x3525804
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x26AD93C
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }

	// RVA: 0x26AD93C
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }

	// RVA: 0x35254D0
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Count() { }

	// RVA: 0x35251DC
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x35267E8
	public void .ctor(System.Collections.Generic.IDictionary<TKey,TValue> underlying) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.ContainsKey(TKey key) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.TryGetValue(TKey key, TValue value) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x3526850
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x3525804
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26AD93C
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	// RVA: 0x26AD93C
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	// RVA: 0x26AD93C
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x35263A0
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }

	// RVA: 0x26AD93C
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

	// RVA: 0xD79C14
	private void .ctor(TypeTableEntry member, TypeTableEntry collectionItem, TypeTableEntry dictionaryKey) { }

	// RVA: 0xD78134
	public static TypeTable Create(MemberInfo member, PolymorphismSchema defaultSchema) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public PolymorphismTarget targetType; // 0x10
	public System.Func<MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xD7A1B4
	public void .ctor() { }

	// RVA: 0xD7BEA0
	internal bool <Create>b__0(IPolymorphicHelperAttribute a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public IPolymorphicRuntimeTypeAttribute attribute; // 0x10

	// Methods

	// RVA: 0xD7BD28
	public void .ctor() { }

	// RVA: 0xD7BF5C
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

	// RVA: 0xD7A110
	public System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xD78E50
	public PolymorphismType get_PolymorphismType() { }

	// RVA: 0xD78DD8
	public bool get_Exists() { }

	// RVA: 0xD7A118
	public System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xD7A120
	private void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xD7A128
	private void .ctor() { }

	// RVA: 0xD79C64
	public static TypeTableEntry Create(MemberInfo member, PolymorphismTarget targetType, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD7A1BC
	private void Interpret(IPolymorphicHelperAttribute attribute, string memberName, int tupleItemNumber) { }

	// RVA: 0xD7A584
	private void SetDefault(PolymorphismTarget target, string memberName, int tupleItemNumber, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD7AA18
	private void SetKnownType(PolymorphismTarget target, string memberName, int tupleItemNumber, string typeCode, Type bindingType) { }

	// RVA: 0xD7B18C
	private void SetRuntimeType(PolymorphismTarget target, string memberName, int tupleItemNumber, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD7B298
	private static string GetCannotSpecifyKnownTypeAndRuntimeTypeErrorMessage(PolymorphismTarget target, string memberName, System.Nullable<System.Int32> tupleItemNumber) { }

	// RVA: 0xD7B8F4
	private static string GetCannotDuplicateKnownTypeCodeErrorMessage(PolymorphismTarget target, string typeCode, string memberName, int tupleItemNumber) { }

	// RVA: 0xD7ABEC
	private static System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> GetVerifier(IPolymorphicRuntimeTypeAttribute attribute) { }

	// RVA: 0xD7BD30
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

	// RVA: 0xD7C01C
	private static void .cctor() { }

	// RVA: 0xD7C088
	public void .ctor() { }

	// RVA: 0xD7C090
	internal PolymorphismSchema <.ctor>b__3_0(PolymorphismSchema x) { }

	// RVA: 0xD7C124
	internal PolymorphismSchema <.ctor>b__4_0(PolymorphismSchema x) { }

	// RVA: 0xD7C1B8
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

	// RVA: 0xD76400
	private void .ctor() { }

	// RVA: 0xD76574
	private void .ctor(Type targetType, PolymorphismType polymorphismType, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xD7690C
	private void .ctor(Type targetType, PolymorphismType polymorphismType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xD767DC
	private void .ctor(Type targetType, PolymorphismType polymorphismType, MsgPack.Serialization.PolymorphismSchema.ReadOnlyDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, System.Collections.ObjectModel.ReadOnlyCollection<MsgPack.Serialization.PolymorphismSchema> childItemSchemaList) { }

	// RVA: 0xD76B6C
	public static PolymorphismSchema ForPolymorphicObject(Type targetType) { }

	// RVA: 0xD76C20
	public static PolymorphismSchema ForPolymorphicObject(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping) { }

	// RVA: 0xD76CE4
	public static PolymorphismSchema ForContextSpecifiedCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xD76DF4
	public static PolymorphismSchema ForPolymorphicCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xD76F04
	public static PolymorphismSchema ForPolymorphicCollection(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema itemSchema) { }

	// RVA: 0xD7701C
	public static PolymorphismSchema ForContextSpecifiedDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD77158
	public static PolymorphismSchema ForPolymorphicDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD77294
	public static PolymorphismSchema ForPolymorphicDictionary(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD773D8
	internal PolymorphismSchema FilterSelf() { }

	// RVA: 0xD774A8
	internal Type get_TargetType() { }

	// RVA: 0xD774B0
	private void set_TargetType(Type value) { }

	// RVA: 0xD774B8
	internal PolymorphismType get_PolymorphismType() { }

	// RVA: 0xD774C0
	private void set_PolymorphismType(PolymorphismType value) { }

	// RVA: 0xD774C8
	internal System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xD774D0
	internal bool get_UseDefault() { }

	// RVA: 0xD774E0
	internal bool get_UseTypeEmbedding() { }

	// RVA: 0xD774F0
	internal System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xD774F8
	private void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xD77500
	internal PolymorphismSchemaChildrenType get_ChildrenType() { }

	// RVA: 0xD77508
	private void set_ChildrenType(PolymorphismSchemaChildrenType value) { }

	// RVA: 0xD77510
	internal PolymorphismSchema get_ItemSchema() { }

	// RVA: 0xD775F8
	private PolymorphismSchema TryGetItemSchema() { }

	// RVA: 0xD776A8
	internal PolymorphismSchema get_KeySchema() { }

	// RVA: 0xD77760
	private PolymorphismSchema TryGetKeySchema() { }

	// RVA: 0xD777E0
	internal static PolymorphismSchema Create(Type type, SerializingMember memberMayBeNull) { }

	// RVA: 0xD77938
	private static PolymorphismSchema CreateCore(MemberInfo member, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD78EC8
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

	// RVA: 0xD7EDBC
	private static void .cctor() { }

	// RVA: 0xD7EE28
	public void .ctor() { }

	// RVA: 0xD7EE30
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_0(Type interface) { }

	// RVA: 0xD7EF2C
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_1(Type i) { }

	// RVA: 0xD7EFB4
	internal Type <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_2(Type i) { }

	// RVA: 0xD7EFE0
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_3(Type i) { }

	// RVA: 0xD7F05C
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_4(Type i) { }

	// RVA: 0xD7F0D8
	internal Type <FindInterfaceMethod>b__7_2(ParameterInfo p) { }

	// RVA: 0xD7F100
	internal bool <GetIsPublic>b__15_0(MethodInfo a) { }

	// RVA: 0xD7F16C
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

	// RVA: 0xD7E204
	public void .ctor() { }

	// RVA: 0xD7F188
	internal bool <FindInterfaceMethod>b__0(Type type, object _) { }

	// RVA: 0xD7F198
	internal bool <FindInterfaceMethod>b__1(MethodInfo method) { }

}

// Namespace: MsgPack.Serialization
internal static class ReflectionExtensions
{
	// Fields
	private static readonly Type[] ExceptionConstructorWithInnerParameterTypes; // 0x0
	private static readonly Type[] ObjectAddParameterTypes; // 0x8

	// Methods

	// RVA: 0xD784D0
	internal static CollectionTraits GetCollectionTraits(Type source, CollectionTraitOptions options, bool allowNonCollectionEnumerableTypes) { }

	// RVA: 0xD7D950
	private static bool TryCreateCollectionTraitsForIEnumerableT(Type source, GenericCollectionTypes genericTypes, CollectionTraitOptions options, MethodInfo getMethod, CollectionTraits result) { }

	// RVA: 0xD7C1C0
	private static bool TryCreateCollectionTraitsForHasGetEnumeratorType(Type source, CollectionTraitOptions options, MethodInfo getEnumerator, CollectionTraits result) { }

	// RVA: 0xD7CB74
	private static bool TryCreateGenericCollectionTraits(Type source, Type type, CollectionTraitOptions options, CollectionTraits result) { }

	// RVA: 0xD7D028
	private static bool DetermineCollectionInterfaces(Type type, GenericCollectionTypes genericTypes, Type idictionary, Type ilist, Type icollection, Type ienumerable) { }

	// RVA: 0xD7D3E4
	private static MethodInfo GetGetEnumeratorMethodFromElementType(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xD7DB20
	private static MethodInfo GetGetEnumeratorMethodFromEnumerableType(Type targetType, Type enumerableType, CollectionTraitOptions options) { }

	// RVA: 0xD7DF88
	private static MethodInfo FindInterfaceMethod(Type targetType, Type interfaceType, string name, Type[] parameterTypes) { }

	// RVA: 0xD7DBDC
	private static MethodInfo GetAddMethod(Type targetType, Type argumentType, CollectionTraitOptions options) { }

	// RVA: 0xD7D6FC
	private static MethodInfo GetCountGetterMethod(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xD7D56C
	private static MethodInfo GetAddMethod(Type targetType, Type keyType, Type valueType, CollectionTraitOptions options) { }

	// RVA: 0xD7CA34
	private static bool FilterCollectionType(Type type, object filterCriteria) { }

	// RVA: 0xD7DE8C
	private static bool IsIEnumeratorT(Type interface) { }

	// RVA: 0xD7E20C
	public static bool GetHasPublicGetter(MemberInfo source) { }

	// RVA: 0xD7E350
	public static bool GetIsPublic(MemberInfo source) { }

	// RVA: 0xD760D0
	public static Type[] GetParameterTypes(MethodBase source) { }

	// RVA: 0xD7824C
	public static Type GetMemberValueType(MemberInfo source) { }

	// RVA: 0xD7E6C8
	public static object InvokePreservingExceptionType(ConstructorInfo source, object[] parameters) { }

	// RVA: 0xD7EA2C
	public static object InvokePreservingExceptionType(MethodInfo source, object instance, object[] parameters) { }

	// RVA: 0x26AD93C
	public static T CreateInstancePreservingExceptionType(Type instanceType, object[] constructorParameters) { }

	// RVA: 0xD7EB18
	public static object CreateInstancePreservingExceptionType(Type type, object[] constructorParameters) { }

	// RVA: 0xD7E7B4
	private static Exception HoistUpInnerException(TargetInvocationException targetInvocationException) { }

	// RVA: 0xD7EBF4
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

	// RVA: 0xD7F324
	private void set_Context(SerializationContext value) { }

	// RVA: 0xD7F32C
	private void set_TargetType(Type value) { }

	// RVA: 0xD7F334
	private void set_PolymorphismSchema(PolymorphismSchema value) { }

	// RVA: 0x3525804
	internal MsgPack.Serialization.MessagePackSerializer<T> GetFoundSerializer() { }

	// RVA: 0xD7F33C
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

	// RVA: 0xD7F418
	public bool get_OneBoundDataMemberOrder() { }

	// RVA: 0xD759B4
	public PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xD7F43C
	public void set_PackerCompatibilityOptions(PackerCompatibilityOptions value) { }

	// RVA: 0xD7F448
	public void set_IgnorePackabilityForCollection(bool value) { }

	// RVA: 0xD7F470
	public bool get_AllowNonCollectionEnumerableTypes() { }

	// RVA: 0xD7F494
	public void set_AllowNonCollectionEnumerableTypes(bool value) { }

	// RVA: 0xD7F4BC
	public bool get_AllowAsymmetricSerializer() { }

	// RVA: 0xD7F4E0
	public void set_AllowAsymmetricSerializer(bool value) { }

	// RVA: 0xD7F508
	internal void .ctor() { }

}

// Namespace: 
private sealed class SerializerGetter
{
	// Fields
	public static readonly SerializerGetter Instance; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Reflection.MethodInfo> _cache; // 0x10

	// Methods

	// RVA: 0xD8082C
	private void .ctor() { }

	// RVA: 0xD7FEE4
	public MessagePackSerializer Get(SerializationContext context, Type targetType, object providerParameter) { }

	// RVA: 0xD808B8
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

	// RVA: 0xD7F558
	public static SerializationContext get_Default() { }

	// RVA: 0xD7F654
	public SerializerRepository get_Serializers() { }

	// RVA: 0xD7F65C
	public SerializerOptions get_SerializerOptions() { }

	// RVA: 0xD7F664
	public SerializationCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xD7F66C
	public DictionarySerlaizationOptions get_DictionarySerlaizationOptions() { }

	// RVA: 0xD7F674
	public SerializationMethod get_SerializationMethod() { }

	// RVA: 0xD7F680
	public EnumSerializationOptions get_EnumSerializationOptions() { }

	// RVA: 0xD7F688
	public DefaultConcreteTypeRepository get_DefaultCollectionTypes() { }

	// RVA: 0xD73338
	public DateTimeConversionMethod get_DefaultDateTimeConversionMethod() { }

	// RVA: 0x35258B4
	private MsgPack.Serialization.MessagePackSerializer<T> OnResolveSerializer(PolymorphismSchema schema) { }

	// RVA: 0xD75E80
	public void .ctor() { }

	// RVA: 0xD7F690
	public void .ctor(PackerCompatibilityOptions packerCompatibilityOptions) { }

	// RVA: 0x3525804
	public MsgPack.Serialization.MessagePackSerializer<T> GetSerializer() { }

	// RVA: 0x35258B4
	public MsgPack.Serialization.MessagePackSerializer<T> GetSerializer(object providerParameter) { }

	// RVA: 0xD7FB1C
	private Type EnsureConcreteTypeRegistered(Type mayBeAbstractType) { }

	// RVA: 0x35258B4
	private MsgPack.Serialization.MessagePackSerializer<T> GetSerializerWithoutGeneration(PolymorphismSchema schema) { }

	// RVA: 0xD7FD64
	public MessagePackSerializer GetSerializer(Type targetType) { }

	// RVA: 0xD7FD6C
	public MessagePackSerializer GetSerializer(Type targetType, object providerParameter) { }

	// RVA: 0xD8064C
	public ExtTypeCodeMapping get_ExtTypeCodeMapping() { }

	// RVA: 0xD80654
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
public static class SerializationExceptions
{
	// Methods

	// RVA: 0xD80998
	public static Exception NewValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xD80B40
	public static void ThrowValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xD80B6C
	public static Exception NewValueTypeCannotBeNull(Type type) { }

	// RVA: 0xD80CA4
	public static void ThrowMissingItem(int index, Unpacker unpacker) { }

	// RVA: 0xD80CB8
	public static void ThrowMissingItem(int index, string name, Unpacker unpacker) { }

	// RVA: 0xD810D4
	internal static void ThrowMissingKey(int index, Unpacker unpacker) { }

	// RVA: 0xD81310
	internal static Exception NewTargetDoesNotHavePublicDefaultConstructor(Type type) { }

	// RVA: 0xD81448
	internal static Exception NewTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xD81580
	internal static void ThrowTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xD815AC
	public static Exception NewMissingProperty(string name) { }

	// RVA: 0xD816E4
	internal static void ThrowMissingProperty(string name) { }

	// RVA: 0xD81710
	internal static void ThrowUnexpectedEndOfStream(Unpacker unpacker) { }

	// RVA: 0xD818BC
	public static void ThrowIsNotArrayHeader(Unpacker unpacker) { }

	// RVA: 0xD81A5C
	public static void ThrowIsNotMapHeader(Unpacker unpacker) { }

	// RVA: 0xD7FC2C
	public static Exception NewNotSupportedBecauseCannotInstanciateAbstractType(Type type) { }

	// RVA: 0xD81BFC
	public static Exception NewIsIncorrectStream(Exception innerException) { }

	// RVA: 0xD81C7C
	internal static void ThrowIsIncorrectStream(Exception innerException) { }

	// RVA: 0xD81CA8
	public static Exception NewIsTooLargeCollection() { }

	// RVA: 0xD81D20
	internal static void ThrowIsTooLargeCollection() { }

	// RVA: 0xD81D4C
	public static Exception NewNullIsProhibited(string memberName) { }

	// RVA: 0xD81E84
	public static void ThrowNullIsProhibited(string memberName) { }

	// RVA: 0xD81EB0
	public static Exception NewReadOnlyMemberItemsMustNotBeNull(string memberName) { }

	// RVA: 0xD81FE8
	public static Exception NewUnpackFromIsNotSupported(Type targetType) { }

	// RVA: 0xD82120
	public static Exception NewCreateInstanceIsNotSupported(Type targetType) { }

	// RVA: 0xD82258
	internal static Exception NewUnpackToIsNotSupported(Type type, Exception inner) { }

	// RVA: 0xD82398
	internal static Exception NewValueTypeCannotBePolymorphic(Type type) { }

	// RVA: 0xD824D0
	internal static Exception NewUnknownTypeEmbedding() { }

	// RVA: 0xD82548
	internal static Exception NewIncompatibleCollectionSerializer(Type targetType, Type incompatibleType, Type exampleClass) { }

	// RVA: 0xD827AC
	internal static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xD827F4
	internal static void ThrowSerializationException(string message) { }

	// RVA: 0xD8283C
	internal static void ThrowSerializationException(string message, Exception innerException) { }

	// RVA: 0xD82890
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

	// RVA: 0xD87BC4
	private void .ctor() { }

	// RVA: 0xD87C18
	public override bool Equals(System.Collections.Generic.KeyValuePair<System.String,System.Type> x, System.Collections.Generic.KeyValuePair<System.String,System.Type> y) { }

	// RVA: 0xD87E98
	public override int GetHashCode(System.Collections.Generic.KeyValuePair<System.String,System.Type> obj) { }

	// RVA: 0xD881D0
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

	// RVA: 0xD88270
	private static void .cctor() { }

	// RVA: 0xD882DC
	public void .ctor() { }

	// RVA: 0xD882E4
	internal System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_0(ParameterInfo p) { }

	// RVA: 0xD88380
	internal System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_1(SerializingMember m) { }

	// RVA: 0xD88440
	internal string <FindCorrespondingMemberNames>b__26_2(ParameterInfo p, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> ms) { }

	// RVA: 0xD884CC
	internal string <ThrowAmbigiousMatchException>b__28_0(SerializingMember x) { }

	// RVA: 0xD884F4
	internal int <Prepare>b__32_0(SerializingMember entry) { }

	// RVA: 0xD88518
	internal bool <Prepare>b__32_2(SerializingMember item) { }

	// RVA: 0xD88544
	internal string <Prepare>b__32_3(SerializingMember item) { }

	// RVA: 0xD88568
	internal bool <HasAnyCorrespondingMembers>b__33_0(string x) { }

	// RVA: 0xD88588
	internal bool <GetTargetMembers>b__37_0(MemberInfo item) { }

	// RVA: 0xD88660
	internal bool <GetTargetMembers>b__37_1(object attr) { }

	// RVA: 0xD886D4
	internal bool <GetAnnotatedMembersWithDuplicationDetection>b__38_0(MemberInfo member) { }

	// RVA: 0xD887AC
	internal SerializingMember <GetAnnotatedMembersWithDuplicationDetection>b__38_1(MemberInfo member) { }

	// RVA: 0xD88A20
	internal <>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> <GetSystemRuntimeSerializationCompatibleMembers>b__39_0(MemberInfo item) { }

	// RVA: 0xD88BAC
	internal bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_3(object data) { }

	// RVA: 0xD88C20
	internal bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_1(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xD88CB8
	internal SerializingMember <GetSystemRuntimeSerializationCompatibleMembers>b__39_2(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xD893AC
	internal bool <GetPublicUnpreventedMembers>b__40_0(MemberInfo member) { }

	// RVA: 0xD89714
	internal string <GetPublicUnpreventedMembers>b__40_2(object data) { }

	// RVA: 0xD89748
	internal bool <GetPublicUnpreventedMembers>b__40_3(string attr) { }

	// RVA: 0xD897DC
	internal SerializingMember <GetPublicUnpreventedMembers>b__40_1(MemberInfo member) { }

	// RVA: 0xD898CC
	internal int <FindDeserializationConstructor>b__42_0(ConstructorInfo ctor) { }

	// RVA: 0xD89904
	internal int <FindDeserializationConstructor>b__42_1(System.Linq.IGrouping<System.Int32,System.Reflection.ConstructorInfo> g) { }

	// RVA: 0xD899B4
	internal string <FindDeserializationConstructor>b__42_2(ConstructorInfo ctor) { }

	// RVA: 0xD899DC
	internal bool <FindExplicitDeserializationConstructors>b__43_0(ConstructorInfo ctor) { }

	// RVA: 0xD89B1C
	internal bool <FindExplicitDeserializationConstructors>b__43_1(object a) { }

	// RVA: 0xD89BB0
	internal int <ComplementMembers>b__46_0(SerializingMember item) { }

	// RVA: 0xD89BD4
	internal string <VerifyKeyUniqueness>b__48_0(System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<System.Reflection.MemberInfo>> kv) { }

	// RVA: 0xD89F64
	internal string <VerifyKeyUniqueness>b__48_1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public SerializationContext context; // 0x10

	// Methods

	// RVA: 0xD8414C
	public void .ctor() { }

	// RVA: 0xD8A1A8
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

	// RVA: 0xD82C28
	public System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> get_Members() { }

	// RVA: 0xD82C30
	private void set_Members(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> value) { }

	// RVA: 0xD82C38
	public ConstructorInfo get_DeserializationConstructor() { }

	// RVA: 0xD82C40
	private void set_DeserializationConstructor(ConstructorInfo value) { }

	// RVA: 0xD82C48
	public bool get_IsConstructorDeserialization() { }

	// RVA: 0xD82C50
	private void set_IsConstructorDeserialization(bool value) { }

	// RVA: 0xD82C58
	public bool get_CanDeserialize() { }

	// RVA: 0xD82C60
	private void set_CanDeserialize(bool value) { }

	// RVA: 0xD82C68
	private void .ctor(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor, string[] correspondingMemberNames, bool canDeserialize) { }

	// RVA: 0xD82D74
	public SerializerCapabilities GetCapabilitiesForObject() { }

	// RVA: 0xD82D88
	public SerializerCapabilities GetCapabilitiesForCollection(CollectionTraits traits) { }

	// RVA: 0xD82DB0
	private static string[] FindCorrespondingMemberNames(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor) { }

	// RVA: 0xD830B0
	private static string DetermineCorrespondingMemberName(ParameterInfo parameterInfo, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xD83178
	private static void ThrowAmbigiousMatchException(ParameterInfo parameterInfo, System.Collections.Generic.ICollection<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xD833B8
	public static void VerifyType(Type targetType) { }

	// RVA: 0xD83488
	public static void VerifyCanSerializeTargetType(SerializationContext context, Type targetType) { }

	// RVA: 0xD836C8
	public static SerializationTarget Prepare(SerializationContext context, Type targetType) { }

	// RVA: 0xD8592C
	private static bool HasAnyCorrespondingMembers(System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames) { }

	// RVA: 0xD85A60
	private static bool HasUnpackableInterface(Type targetType, SerializationContext context) { }

	// RVA: 0xD85688
	private static bool DetermineCanDeserialize(ConstructorKind kind, SerializationContext context, Type targetType, System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames, bool allowDefault) { }

	// RVA: 0xD85B14
	private static MemberInfo[] GetDistinctMembers(Type type) { }

	// RVA: 0xD84154
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetTargetMembers(Type type) { }

	// RVA: 0xD85EC8
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetAnnotatedMembersWithDuplicationDetection(Type type, MemberInfo[] filtered) { }

	// RVA: 0xD861CC
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetSystemRuntimeSerializationCompatibleMembers(MemberInfo[] members) { }

	// RVA: 0xD86494
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetPublicUnpreventedMembers(MemberInfo[] members) { }

	// RVA: 0xD8668C
	private static bool IsNonSerializedField(MemberInfo member) { }

	// RVA: 0xD84448
	private static ConstructorInfo FindDeserializationConstructor(SerializationContext context, Type targetType, ConstructorKind constructorKind) { }

	// RVA: 0xD8580C
	private static System.Collections.Generic.IList<System.Reflection.ConstructorInfo> FindExplicitDeserializationConstructors(System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> construtors) { }

	// RVA: 0xD86724
	private static SerializationException NewTypeCannotBeSerializedException(Type targetType) { }

	// RVA: 0xD8685C
	private static bool CheckTargetEligibility(SerializationContext context, MemberInfo member) { }

	// RVA: 0xD84B70
	private static System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> ComplementMembers(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> candidates, SerializationContext context, Type targetType) { }

	// RVA: 0xD86B90
	private static void VerifyNilImplication(Type type, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> entries) { }

	// RVA: 0xD870B0
	private static void VerifyKeyUniqueness(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> result) { }

	// RVA: 0xD878E8
	public static SerializationTarget CreateForCollection(ConstructorInfo collectionConstructor, bool canDeserialize) { }

	// RVA: 0xD8797C
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

	// RVA: 0xD836A4
	public bool get_DisablePrivilegedAccess() { }

	// RVA: 0xD7FB0C
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

	// RVA: 0xD7FA40
	public void .ctor(SerializerRepository copiedFrom) { }

	// RVA: 0xD8A23C
	private void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD8A3B4
	public void Dispose() { }

	// RVA: 0x35258B4
	public MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x3525998
	public MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0xD8A3B8
	internal bool Register(Type targetType, MessagePackSerializerProvider serializerProvider, Type nullableType, MessagePackSerializerProvider nullableSerializerProvider, SerializerRegistrationOptions options) { }

	// RVA: 0xD7F97C
	public static SerializerRepository GetDefault(SerializationContext ownerContext) { }

	// RVA: 0xD8A3D8
	internal static System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeDefaultTable(SerializationContext ownerContext) { }

	// RVA: 0xD8B890
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class SerializerTypeKeyRepository
{
	// Fields
	private static readonly Type[] NonGenericSerializerConstructorParameterTypes; // 0x0

	// Methods

	// RVA: 0xD8A238
	public void .ctor(SerializerTypeKeyRepository copiedFrom) { }

	// RVA: 0xD8A324
	public void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD8BA0C
	public object Get(SerializationContext context, Type keyType) { }

	// RVA: 0xD8BD7C
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

	// RVA: 0xD86AF0
	public void .ctor() { }

	// RVA: 0xD88998
	public void .ctor(MemberInfo member, DataMemberContract contract) { }

	// RVA: 0xD8BED0
	public EnumMemberSerializationMethod GetEnumMemberSerializationMethod() { }

	// RVA: 0xD8BFC4
	public DateTimeMemberConversionMethod GetDateTimeMemberConversionMethod() { }

	// RVA: 0xD8C0B8
	public override string ToString() { }

}

// Namespace: MsgPack.Serialization
internal class TypeKeyRepository
{
	// Fields
	private readonly ReaderWriterLockSlim _lock; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> _table; // 0x18

	// Methods

	// RVA: 0xD8B918
	public void .ctor(TypeKeyRepository copiedFrom) { }

	// RVA: 0xD7399C
	public void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD8C2EC
	private System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> GetClonedTable() { }

	// RVA: 0xD73B48
	public bool Get(Type type, object matched, object genericDefinitionMatched) { }

	// RVA: 0xD8C444
	private bool GetCore(Type type, object matched, object genericDefinitionMatched) { }

	// RVA: 0xD8A3D4
	public bool Register(Type type, object entry, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xD8C728
	private bool RegisterCore(Type key, object value, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xD8C984
	private bool ContainsType(Type baseType, Type nullableType) { }

}

// Namespace: MsgPack.Serialization
public static class UnpackHelpers
{
	// Fields
	private static readonly MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _messagePackObjectSerializer; // 0x0

	// Methods

	// RVA: 0xD8CA70
	public static int GetItemsCount(Unpacker unpacker) { }

	// RVA: 0xD8CBB0
	internal static SerializationTarget DetermineCollectionSerializationStrategy(Type instanceType, bool allowAsymmetricSerializer) { }

	// RVA: 0xD8CD14
	private static ConstructorInfo TryGetCollectionConstructor(Type instanceType) { }

	// RVA: 0xD8D068
	internal static bool IsIEqualityComparer(Type type) { }

	// RVA: 0xD8D164
	internal static object GetEqualityComparer(Type comparerType) { }

	// RVA: 0xD8D514
	private static void .cctor() { }

}

// Namespace: 
private sealed class BoxingGenericEqualityComparer<T0>
{
	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	public bool Equals(T x, T y) { }

	// RVA: 0x26AD93C
	public int GetHashCode(T obj) { }

}

// Namespace: 
private sealed class System_AppDomainManagerInitializationOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD9881C
	public void .ctor() { }

	// RVA: 0xD98824
	public bool Equals(AppDomainManagerInitializationOptions left, AppDomainManagerInitializationOptions right) { }

	// RVA: 0xD988AC
	public int GetHashCode(AppDomainManagerInitializationOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_AppDomainManagerInitializationOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD988D4
	public void .ctor() { }

	// RVA: 0xD988DC
	public bool Equals(System.Nullable<System.AppDomainManagerInitializationOptions> left, System.Nullable<System.AppDomainManagerInitializationOptions> right) { }

	// RVA: 0xD98A58
	public int GetHashCode(System.Nullable<System.AppDomainManagerInitializationOptions> obj) { }

}

// Namespace: 
private sealed class System_AttributeTargetsEqualityComparer
{
	// Methods

	// RVA: 0xD98B0C
	public void .ctor() { }

	// RVA: 0xD98B14
	public bool Equals(AttributeTargets left, AttributeTargets right) { }

	// RVA: 0xD98B9C
	public int GetHashCode(AttributeTargets obj) { }

}

// Namespace: 
private sealed class NullableSystem_AttributeTargetsEqualityComparer
{
	// Methods

	// RVA: 0xD98BC4
	public void .ctor() { }

	// RVA: 0xD98BCC
	public bool Equals(System.Nullable<System.AttributeTargets> left, System.Nullable<System.AttributeTargets> right) { }

	// RVA: 0xD98D48
	public int GetHashCode(System.Nullable<System.AttributeTargets> obj) { }

}

// Namespace: 
private sealed class System_Base64FormattingOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD98DFC
	public void .ctor() { }

	// RVA: 0xD98E04
	public bool Equals(Base64FormattingOptions left, Base64FormattingOptions right) { }

	// RVA: 0xD98E8C
	public int GetHashCode(Base64FormattingOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Base64FormattingOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD98EB4
	public void .ctor() { }

	// RVA: 0xD98EBC
	public bool Equals(System.Nullable<System.Base64FormattingOptions> left, System.Nullable<System.Base64FormattingOptions> right) { }

	// RVA: 0xD99038
	public int GetHashCode(System.Nullable<System.Base64FormattingOptions> obj) { }

}

// Namespace: 
private sealed class System_BooleanEqualityComparer
{
	// Methods

	// RVA: 0xD990EC
	public void .ctor() { }

	// RVA: 0xD990F4
	public bool Equals(bool left, bool right) { }

	// RVA: 0xD99100
	public int GetHashCode(bool obj) { }

}

// Namespace: 
private sealed class NullableSystem_BooleanEqualityComparer
{
	// Methods

	// RVA: 0xD99158
	public void .ctor() { }

	// RVA: 0xD99160
	public bool Equals(System.Nullable<System.Boolean> left, System.Nullable<System.Boolean> right) { }

	// RVA: 0xD992B4
	public int GetHashCode(System.Nullable<System.Boolean> obj) { }

}

// Namespace: 
private sealed class System_ByteEqualityComparer
{
	// Methods

	// RVA: 0xD99368
	public void .ctor() { }

	// RVA: 0xD99370
	public bool Equals(Byte left, Byte right) { }

	// RVA: 0xD9937C
	public int GetHashCode(Byte obj) { }

}

// Namespace: 
private sealed class NullableSystem_ByteEqualityComparer
{
	// Methods

	// RVA: 0xD993A4
	public void .ctor() { }

	// RVA: 0xD993AC
	public bool Equals(System.Nullable<System.Byte> left, System.Nullable<System.Byte> right) { }

	// RVA: 0xD994F4
	public int GetHashCode(System.Nullable<System.Byte> obj) { }

}

// Namespace: 
private sealed class System_CharEqualityComparer
{
	// Methods

	// RVA: 0xD995A8
	public void .ctor() { }

	// RVA: 0xD995B0
	public bool Equals(Char left, Char right) { }

	// RVA: 0xD995BC
	public int GetHashCode(Char obj) { }

}

// Namespace: 
private sealed class NullableSystem_CharEqualityComparer
{
	// Methods

	// RVA: 0xD99614
	public void .ctor() { }

	// RVA: 0xD9961C
	public bool Equals(System.Nullable<System.Char> left, System.Nullable<System.Char> right) { }

	// RVA: 0xD99760
	public int GetHashCode(System.Nullable<System.Char> obj) { }

}

// Namespace: 
private sealed class System_ConsoleColorEqualityComparer
{
	// Methods

	// RVA: 0xD99814
	public void .ctor() { }

	// RVA: 0xD9981C
	public bool Equals(ConsoleColor left, ConsoleColor right) { }

	// RVA: 0xD998A4
	public int GetHashCode(ConsoleColor obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleColorEqualityComparer
{
	// Methods

	// RVA: 0xD998CC
	public void .ctor() { }

	// RVA: 0xD998D4
	public bool Equals(System.Nullable<System.ConsoleColor> left, System.Nullable<System.ConsoleColor> right) { }

	// RVA: 0xD99A50
	public int GetHashCode(System.Nullable<System.ConsoleColor> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyEqualityComparer
{
	// Methods

	// RVA: 0xD99B04
	public void .ctor() { }

	// RVA: 0xD99B0C
	public bool Equals(ConsoleKey left, ConsoleKey right) { }

	// RVA: 0xD99B94
	public int GetHashCode(ConsoleKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyEqualityComparer
{
	// Methods

	// RVA: 0xD99BBC
	public void .ctor() { }

	// RVA: 0xD99BC4
	public bool Equals(System.Nullable<System.ConsoleKey> left, System.Nullable<System.ConsoleKey> right) { }

	// RVA: 0xD99D40
	public int GetHashCode(System.Nullable<System.ConsoleKey> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyInfoEqualityComparer
{
	// Methods

	// RVA: 0xD99DF4
	public void .ctor() { }

	// RVA: 0xD99DFC
	public bool Equals(ConsoleKeyInfo left, ConsoleKeyInfo right) { }

	// RVA: 0xD99E30
	public int GetHashCode(ConsoleKeyInfo obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyInfoEqualityComparer
{
	// Methods

	// RVA: 0xD99E5C
	public void .ctor() { }

	// RVA: 0xD99E64
	public bool Equals(System.Nullable<System.ConsoleKeyInfo> left, System.Nullable<System.ConsoleKeyInfo> right) { }

	// RVA: 0xD99FC0
	public int GetHashCode(System.Nullable<System.ConsoleKeyInfo> obj) { }

}

// Namespace: 
private sealed class System_ConsoleModifiersEqualityComparer
{
	// Methods

	// RVA: 0xD9A074
	public void .ctor() { }

	// RVA: 0xD9A07C
	public bool Equals(ConsoleModifiers left, ConsoleModifiers right) { }

	// RVA: 0xD9A104
	public int GetHashCode(ConsoleModifiers obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleModifiersEqualityComparer
{
	// Methods

	// RVA: 0xD9A12C
	public void .ctor() { }

	// RVA: 0xD9A134
	public bool Equals(System.Nullable<System.ConsoleModifiers> left, System.Nullable<System.ConsoleModifiers> right) { }

	// RVA: 0xD9A2B0
	public int GetHashCode(System.Nullable<System.ConsoleModifiers> obj) { }

}

// Namespace: 
private sealed class System_ConsoleSpecialKeyEqualityComparer
{
	// Methods

	// RVA: 0xD9A364
	public void .ctor() { }

	// RVA: 0xD9A36C
	public bool Equals(ConsoleSpecialKey left, ConsoleSpecialKey right) { }

	// RVA: 0xD9A3F4
	public int GetHashCode(ConsoleSpecialKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleSpecialKeyEqualityComparer
{
	// Methods

	// RVA: 0xD9A41C
	public void .ctor() { }

	// RVA: 0xD9A424
	public bool Equals(System.Nullable<System.ConsoleSpecialKey> left, System.Nullable<System.ConsoleSpecialKey> right) { }

	// RVA: 0xD9A5A0
	public int GetHashCode(System.Nullable<System.ConsoleSpecialKey> obj) { }

}

// Namespace: 
private sealed class System_DateTimeEqualityComparer
{
	// Methods

	// RVA: 0xD9A654
	public void .ctor() { }

	// RVA: 0xD9A65C
	public bool Equals(DateTime left, DateTime right) { }

	// RVA: 0xD9A6D4
	public int GetHashCode(DateTime obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeEqualityComparer
{
	// Methods

	// RVA: 0xD9A73C
	public void .ctor() { }

	// RVA: 0xD9A744
	public bool Equals(System.Nullable<System.DateTime> left, System.Nullable<System.DateTime> right) { }

	// RVA: 0xD9A8B8
	public int GetHashCode(System.Nullable<System.DateTime> obj) { }

}

// Namespace: 
private sealed class System_DateTimeKindEqualityComparer
{
	// Methods

	// RVA: 0xD9A96C
	public void .ctor() { }

	// RVA: 0xD9A974
	public bool Equals(DateTimeKind left, DateTimeKind right) { }

	// RVA: 0xD9A9FC
	public int GetHashCode(DateTimeKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeKindEqualityComparer
{
	// Methods

	// RVA: 0xD9AA24
	public void .ctor() { }

	// RVA: 0xD9AA2C
	public bool Equals(System.Nullable<System.DateTimeKind> left, System.Nullable<System.DateTimeKind> right) { }

	// RVA: 0xD9ABA8
	public int GetHashCode(System.Nullable<System.DateTimeKind> obj) { }

}

// Namespace: 
private sealed class System_DateTimeOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD9AC5C
	public void .ctor() { }

	// RVA: 0xD9AC64
	public bool Equals(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0xD9ACE4
	public int GetHashCode(DateTimeOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD9AD4C
	public void .ctor() { }

	// RVA: 0xD9AD54
	public bool Equals(System.Nullable<System.DateTimeOffset> left, System.Nullable<System.DateTimeOffset> right) { }

	// RVA: 0xD9AEE0
	public int GetHashCode(System.Nullable<System.DateTimeOffset> obj) { }

}

// Namespace: 
private sealed class System_DayOfWeekEqualityComparer
{
	// Methods

	// RVA: 0xD9AF90
	public void .ctor() { }

	// RVA: 0xD9AF98
	public bool Equals(DayOfWeek left, DayOfWeek right) { }

	// RVA: 0xD9B020
	public int GetHashCode(DayOfWeek obj) { }

}

// Namespace: 
private sealed class NullableSystem_DayOfWeekEqualityComparer
{
	// Methods

	// RVA: 0xD9B048
	public void .ctor() { }

	// RVA: 0xD9B050
	public bool Equals(System.Nullable<System.DayOfWeek> left, System.Nullable<System.DayOfWeek> right) { }

	// RVA: 0xD9B1CC
	public int GetHashCode(System.Nullable<System.DayOfWeek> obj) { }

}

// Namespace: 
private sealed class System_DecimalEqualityComparer
{
	// Methods

	// RVA: 0xD9B280
	public void .ctor() { }

	// RVA: 0xD9B288
	public bool Equals(Decimal left, Decimal right) { }

	// RVA: 0xD9B334
	public int GetHashCode(Decimal obj) { }

}

// Namespace: 
private sealed class NullableSystem_DecimalEqualityComparer
{
	// Methods

	// RVA: 0xD9B3C8
	public void .ctor() { }

	// RVA: 0xD9B3D0
	public bool Equals(System.Nullable<System.Decimal> left, System.Nullable<System.Decimal> right) { }

	// RVA: 0xD9B594
	public int GetHashCode(System.Nullable<System.Decimal> obj) { }

}

// Namespace: 
private sealed class System_DoubleEqualityComparer
{
	// Methods

	// RVA: 0xD9B644
	public void .ctor() { }

	// RVA: 0xD9B64C
	public bool Equals(Double left, Double right) { }

	// RVA: 0xD9B658
	public int GetHashCode(Double obj) { }

}

// Namespace: 
private sealed class NullableSystem_DoubleEqualityComparer
{
	// Methods

	// RVA: 0xD9B678
	public void .ctor() { }

	// RVA: 0xD9B680
	public bool Equals(System.Nullable<System.Double> left, System.Nullable<System.Double> right) { }

	// RVA: 0xD9B7D8
	public int GetHashCode(System.Nullable<System.Double> obj) { }

}

// Namespace: 
private sealed class System_EnvironmentVariableTargetEqualityComparer
{
	// Methods

	// RVA: 0xD9B88C
	public void .ctor() { }

	// RVA: 0xD9B894
	public bool Equals(EnvironmentVariableTarget left, EnvironmentVariableTarget right) { }

	// RVA: 0xD9B91C
	public int GetHashCode(EnvironmentVariableTarget obj) { }

}

// Namespace: 
private sealed class NullableSystem_EnvironmentVariableTargetEqualityComparer
{
	// Methods

	// RVA: 0xD9B944
	public void .ctor() { }

	// RVA: 0xD9B94C
	public bool Equals(System.Nullable<System.EnvironmentVariableTarget> left, System.Nullable<System.EnvironmentVariableTarget> right) { }

	// RVA: 0xD9BAC8
	public int GetHashCode(System.Nullable<System.EnvironmentVariableTarget> obj) { }

}

// Namespace: 
private sealed class System_GCCollectionModeEqualityComparer
{
	// Methods

	// RVA: 0xD9BB7C
	public void .ctor() { }

	// RVA: 0xD9BB84
	public bool Equals(GCCollectionMode left, GCCollectionMode right) { }

	// RVA: 0xD9BC0C
	public int GetHashCode(GCCollectionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCCollectionModeEqualityComparer
{
	// Methods

	// RVA: 0xD9BC34
	public void .ctor() { }

	// RVA: 0xD9BC3C
	public bool Equals(System.Nullable<System.GCCollectionMode> left, System.Nullable<System.GCCollectionMode> right) { }

	// RVA: 0xD9BDB8
	public int GetHashCode(System.Nullable<System.GCCollectionMode> obj) { }

}

// Namespace: 
private sealed class System_GCNotificationStatusEqualityComparer
{
	// Methods

	// RVA: 0xD9BE6C
	public void .ctor() { }

	// RVA: 0xD9BE74
	public bool Equals(GCNotificationStatus left, GCNotificationStatus right) { }

	// RVA: 0xD9BEFC
	public int GetHashCode(GCNotificationStatus obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCNotificationStatusEqualityComparer
{
	// Methods

	// RVA: 0xD9BF24
	public void .ctor() { }

	// RVA: 0xD9BF2C
	public bool Equals(System.Nullable<System.GCNotificationStatus> left, System.Nullable<System.GCNotificationStatus> right) { }

	// RVA: 0xD9C0A8
	public int GetHashCode(System.Nullable<System.GCNotificationStatus> obj) { }

}

// Namespace: 
private sealed class System_GuidEqualityComparer
{
	// Methods

	// RVA: 0xD9C15C
	public void .ctor() { }

	// RVA: 0xD9C164
	public bool Equals(Guid left, Guid right) { }

	// RVA: 0xD9C194
	public int GetHashCode(Guid obj) { }

}

// Namespace: 
private sealed class NullableSystem_GuidEqualityComparer
{
	// Methods

	// RVA: 0xD9C1BC
	public void .ctor() { }

	// RVA: 0xD9C1C4
	public bool Equals(System.Nullable<System.Guid> left, System.Nullable<System.Guid> right) { }

	// RVA: 0xD9C324
	public int GetHashCode(System.Nullable<System.Guid> obj) { }

}

// Namespace: 
private sealed class System_Int16EqualityComparer
{
	// Methods

	// RVA: 0xD9C3D4
	public void .ctor() { }

	// RVA: 0xD9C3DC
	public bool Equals(Int16 left, Int16 right) { }

	// RVA: 0xD9C3E8
	public int GetHashCode(Int16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int16EqualityComparer
{
	// Methods

	// RVA: 0xD9C410
	public void .ctor() { }

	// RVA: 0xD9C418
	public bool Equals(System.Nullable<System.Int16> left, System.Nullable<System.Int16> right) { }

	// RVA: 0xD9C55C
	public int GetHashCode(System.Nullable<System.Int16> obj) { }

}

// Namespace: 
private sealed class System_Int32EqualityComparer
{
	// Methods

	// RVA: 0xD9C610
	public void .ctor() { }

	// RVA: 0xD9C618
	public bool Equals(int left, int right) { }

	// RVA: 0xD9C624
	public int GetHashCode(int obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int32EqualityComparer
{
	// Methods

	// RVA: 0xD9C64C
	public void .ctor() { }

	// RVA: 0xD9C654
	public bool Equals(System.Nullable<System.Int32> left, System.Nullable<System.Int32> right) { }

	// RVA: 0xD9C798
	public int GetHashCode(System.Nullable<System.Int32> obj) { }

}

// Namespace: 
private sealed class System_Int64EqualityComparer
{
	// Methods

	// RVA: 0xD9C84C
	public void .ctor() { }

	// RVA: 0xD9C854
	public bool Equals(Int64 left, Int64 right) { }

	// RVA: 0xD9C860
	public int GetHashCode(Int64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int64EqualityComparer
{
	// Methods

	// RVA: 0xD9C888
	public void .ctor() { }

	// RVA: 0xD9C890
	public bool Equals(System.Nullable<System.Int64> left, System.Nullable<System.Int64> right) { }

	// RVA: 0xD9C9D8
	public int GetHashCode(System.Nullable<System.Int64> obj) { }

}

// Namespace: 
private sealed class System_IntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD9CA8C
	public void .ctor() { }

	// RVA: 0xD9CA94
	public bool Equals(IntPtr left, IntPtr right) { }

	// RVA: 0xD9CAA0
	public int GetHashCode(IntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_IntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD9CAC8
	public void .ctor() { }

	// RVA: 0xD9CAD0
	public bool Equals(System.Nullable<System.IntPtr> left, System.Nullable<System.IntPtr> right) { }

	// RVA: 0xD9CC18
	public int GetHashCode(System.Nullable<System.IntPtr> obj) { }

}

// Namespace: 
private sealed class System_LoaderOptimizationEqualityComparer
{
	// Methods

	// RVA: 0xD9CCCC
	public void .ctor() { }

	// RVA: 0xD9CCD4
	public bool Equals(LoaderOptimization left, LoaderOptimization right) { }

	// RVA: 0xD9CD5C
	public int GetHashCode(LoaderOptimization obj) { }

}

// Namespace: 
private sealed class NullableSystem_LoaderOptimizationEqualityComparer
{
	// Methods

	// RVA: 0xD9CD84
	public void .ctor() { }

	// RVA: 0xD9CD8C
	public bool Equals(System.Nullable<System.LoaderOptimization> left, System.Nullable<System.LoaderOptimization> right) { }

	// RVA: 0xD9CF08
	public int GetHashCode(System.Nullable<System.LoaderOptimization> obj) { }

}

// Namespace: 
private sealed class System_MidpointRoundingEqualityComparer
{
	// Methods

	// RVA: 0xD9CFBC
	public void .ctor() { }

	// RVA: 0xD9CFC4
	public bool Equals(MidpointRounding left, MidpointRounding right) { }

	// RVA: 0xD9D04C
	public int GetHashCode(MidpointRounding obj) { }

}

// Namespace: 
private sealed class NullableSystem_MidpointRoundingEqualityComparer
{
	// Methods

	// RVA: 0xD9D074
	public void .ctor() { }

	// RVA: 0xD9D07C
	public bool Equals(System.Nullable<System.MidpointRounding> left, System.Nullable<System.MidpointRounding> right) { }

	// RVA: 0xD9D1F8
	public int GetHashCode(System.Nullable<System.MidpointRounding> obj) { }

}

// Namespace: 
private sealed class System_ModuleHandleEqualityComparer
{
	// Methods

	// RVA: 0xD9D2AC
	public void .ctor() { }

	// RVA: 0xD9D2B4
	public bool Equals(ModuleHandle left, ModuleHandle right) { }

	// RVA: 0xD9D32C
	public int GetHashCode(ModuleHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_ModuleHandleEqualityComparer
{
	// Methods

	// RVA: 0xD9D394
	public void .ctor() { }

	// RVA: 0xD9D39C
	public bool Equals(System.Nullable<System.ModuleHandle> left, System.Nullable<System.ModuleHandle> right) { }

	// RVA: 0xD9D510
	public int GetHashCode(System.Nullable<System.ModuleHandle> obj) { }

}

// Namespace: 
private sealed class System_PlatformIDEqualityComparer
{
	// Methods

	// RVA: 0xD9D5C4
	public void .ctor() { }

	// RVA: 0xD9D5CC
	public bool Equals(PlatformID left, PlatformID right) { }

	// RVA: 0xD9D654
	public int GetHashCode(PlatformID obj) { }

}

// Namespace: 
private sealed class NullableSystem_PlatformIDEqualityComparer
{
	// Methods

	// RVA: 0xD9D67C
	public void .ctor() { }

	// RVA: 0xD9D684
	public bool Equals(System.Nullable<System.PlatformID> left, System.Nullable<System.PlatformID> right) { }

	// RVA: 0xD9D800
	public int GetHashCode(System.Nullable<System.PlatformID> obj) { }

}

// Namespace: 
private sealed class System_RuntimeFieldHandleEqualityComparer
{
	// Methods

	// RVA: 0xD9D8B4
	public void .ctor() { }

	// RVA: 0xD9D8BC
	public bool Equals(RuntimeFieldHandle left, RuntimeFieldHandle right) { }

	// RVA: 0xD9D8E8
	public int GetHashCode(RuntimeFieldHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeFieldHandleEqualityComparer
{
	// Methods

	// RVA: 0xD9D910
	public void .ctor() { }

	// RVA: 0xD9D918
	public bool Equals(System.Nullable<System.RuntimeFieldHandle> left, System.Nullable<System.RuntimeFieldHandle> right) { }

	// RVA: 0xD9DA64
	public int GetHashCode(System.Nullable<System.RuntimeFieldHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeMethodHandleEqualityComparer
{
	// Methods

	// RVA: 0xD9DB18
	public void .ctor() { }

	// RVA: 0xD9DB20
	public bool Equals(RuntimeMethodHandle left, RuntimeMethodHandle right) { }

	// RVA: 0xD9DB4C
	public int GetHashCode(RuntimeMethodHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeMethodHandleEqualityComparer
{
	// Methods

	// RVA: 0xD9DB74
	public void .ctor() { }

	// RVA: 0xD9DB7C
	public bool Equals(System.Nullable<System.RuntimeMethodHandle> left, System.Nullable<System.RuntimeMethodHandle> right) { }

	// RVA: 0xD9DCC8
	public int GetHashCode(System.Nullable<System.RuntimeMethodHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeTypeHandleEqualityComparer
{
	// Methods

	// RVA: 0xD9DD7C
	public void .ctor() { }

	// RVA: 0xD9DD84
	public bool Equals(RuntimeTypeHandle left, RuntimeTypeHandle right) { }

	// RVA: 0xD9DDB0
	public int GetHashCode(RuntimeTypeHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeTypeHandleEqualityComparer
{
	// Methods

	// RVA: 0xD9DDD8
	public void .ctor() { }

	// RVA: 0xD9DDE0
	public bool Equals(System.Nullable<System.RuntimeTypeHandle> left, System.Nullable<System.RuntimeTypeHandle> right) { }

	// RVA: 0xD9DF2C
	public int GetHashCode(System.Nullable<System.RuntimeTypeHandle> obj) { }

}

// Namespace: 
private sealed class System_SByteEqualityComparer
{
	// Methods

	// RVA: 0xD9DFE0
	public void .ctor() { }

	// RVA: 0xD9DFE8
	public bool Equals(SByte left, SByte right) { }

	// RVA: 0xD9DFF4
	public int GetHashCode(SByte obj) { }

}

// Namespace: 
private sealed class NullableSystem_SByteEqualityComparer
{
	// Methods

	// RVA: 0xD9E01C
	public void .ctor() { }

	// RVA: 0xD9E024
	public bool Equals(System.Nullable<System.SByte> left, System.Nullable<System.SByte> right) { }

	// RVA: 0xD9E16C
	public int GetHashCode(System.Nullable<System.SByte> obj) { }

}

// Namespace: 
private sealed class System_SingleEqualityComparer
{
	// Methods

	// RVA: 0xD9E220
	public void .ctor() { }

	// RVA: 0xD9E228
	public bool Equals(float left, float right) { }

	// RVA: 0xD9E234
	public int GetHashCode(float obj) { }

}

// Namespace: 
private sealed class NullableSystem_SingleEqualityComparer
{
	// Methods

	// RVA: 0xD9E25C
	public void .ctor() { }

	// RVA: 0xD9E264
	public bool Equals(System.Nullable<System.Single> left, System.Nullable<System.Single> right) { }

	// RVA: 0xD9E3B8
	public int GetHashCode(System.Nullable<System.Single> obj) { }

}

// Namespace: 
private sealed class System_StringComparisonEqualityComparer
{
	// Methods

	// RVA: 0xD9E46C
	public void .ctor() { }

	// RVA: 0xD9E474
	public bool Equals(StringComparison left, StringComparison right) { }

	// RVA: 0xD9E4FC
	public int GetHashCode(StringComparison obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringComparisonEqualityComparer
{
	// Methods

	// RVA: 0xD9E524
	public void .ctor() { }

	// RVA: 0xD9E52C
	public bool Equals(System.Nullable<System.StringComparison> left, System.Nullable<System.StringComparison> right) { }

	// RVA: 0xD9E6A8
	public int GetHashCode(System.Nullable<System.StringComparison> obj) { }

}

// Namespace: 
private sealed class System_StringSplitOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD9E75C
	public void .ctor() { }

	// RVA: 0xD9E764
	public bool Equals(StringSplitOptions left, StringSplitOptions right) { }

	// RVA: 0xD9E7EC
	public int GetHashCode(StringSplitOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringSplitOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD9E814
	public void .ctor() { }

	// RVA: 0xD9E81C
	public bool Equals(System.Nullable<System.StringSplitOptions> left, System.Nullable<System.StringSplitOptions> right) { }

	// RVA: 0xD9E998
	public int GetHashCode(System.Nullable<System.StringSplitOptions> obj) { }

}

// Namespace: 
private sealed class System_TimeSpanEqualityComparer
{
	// Methods

	// RVA: 0xD9EA4C
	public void .ctor() { }

	// RVA: 0xD9EA54
	public bool Equals(TimeSpan left, TimeSpan right) { }

	// RVA: 0xD9EACC
	public int GetHashCode(TimeSpan obj) { }

}

// Namespace: 
private sealed class NullableSystem_TimeSpanEqualityComparer
{
	// Methods

	// RVA: 0xD9EB34
	public void .ctor() { }

	// RVA: 0xD9EB3C
	public bool Equals(System.Nullable<System.TimeSpan> left, System.Nullable<System.TimeSpan> right) { }

	// RVA: 0xD9ECB0
	public int GetHashCode(System.Nullable<System.TimeSpan> obj) { }

}

// Namespace: 
private sealed class System_TypeCodeEqualityComparer
{
	// Methods

	// RVA: 0xD9ED64
	public void .ctor() { }

	// RVA: 0xD9ED6C
	public bool Equals(TypeCode left, TypeCode right) { }

	// RVA: 0xD9EDF4
	public int GetHashCode(TypeCode obj) { }

}

// Namespace: 
private sealed class NullableSystem_TypeCodeEqualityComparer
{
	// Methods

	// RVA: 0xD9EE1C
	public void .ctor() { }

	// RVA: 0xD9EE24
	public bool Equals(System.Nullable<System.TypeCode> left, System.Nullable<System.TypeCode> right) { }

	// RVA: 0xD9EFA0
	public int GetHashCode(System.Nullable<System.TypeCode> obj) { }

}

// Namespace: 
private sealed class System_UInt16EqualityComparer
{
	// Methods

	// RVA: 0xD9F054
	public void .ctor() { }

	// RVA: 0xD9F05C
	public bool Equals(UInt16 left, UInt16 right) { }

	// RVA: 0xD9F068
	public int GetHashCode(UInt16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt16EqualityComparer
{
	// Methods

	// RVA: 0xD9F090
	public void .ctor() { }

	// RVA: 0xD9F098
	public bool Equals(System.Nullable<System.UInt16> left, System.Nullable<System.UInt16> right) { }

	// RVA: 0xD9F1DC
	public int GetHashCode(System.Nullable<System.UInt16> obj) { }

}

// Namespace: 
private sealed class System_UInt32EqualityComparer
{
	// Methods

	// RVA: 0xD9F290
	public void .ctor() { }

	// RVA: 0xD9F298
	public bool Equals(UInt32 left, UInt32 right) { }

	// RVA: 0xD9F2A4
	public int GetHashCode(UInt32 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt32EqualityComparer
{
	// Methods

	// RVA: 0xD9F2CC
	public void .ctor() { }

	// RVA: 0xD9F2D4
	public bool Equals(System.Nullable<System.UInt32> left, System.Nullable<System.UInt32> right) { }

	// RVA: 0xD9F418
	public int GetHashCode(System.Nullable<System.UInt32> obj) { }

}

// Namespace: 
private sealed class System_UInt64EqualityComparer
{
	// Methods

	// RVA: 0xD9F4CC
	public void .ctor() { }

	// RVA: 0xD9F4D4
	public bool Equals(UInt64 left, UInt64 right) { }

	// RVA: 0xD9F4E0
	public int GetHashCode(UInt64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt64EqualityComparer
{
	// Methods

	// RVA: 0xD9F508
	public void .ctor() { }

	// RVA: 0xD9F510
	public bool Equals(System.Nullable<System.UInt64> left, System.Nullable<System.UInt64> right) { }

	// RVA: 0xD9F658
	public int GetHashCode(System.Nullable<System.UInt64> obj) { }

}

// Namespace: 
private sealed class System_UIntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD9F70C
	public void .ctor() { }

	// RVA: 0xD9F714
	public bool Equals(UIntPtr left, UIntPtr right) { }

	// RVA: 0xD9F724
	public int GetHashCode(UIntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_UIntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD9F74C
	public void .ctor() { }

	// RVA: 0xD9F754
	public bool Equals(System.Nullable<System.UIntPtr> left, System.Nullable<System.UIntPtr> right) { }

	// RVA: 0xD9F8A0
	public int GetHashCode(System.Nullable<System.UIntPtr> obj) { }

}

// Namespace: 
private sealed class System_Collections_DictionaryEntryEqualityComparer
{
	// Methods

	// RVA: 0xD9F954
	public void .ctor() { }

	// RVA: 0xD9F95C
	public bool Equals(DictionaryEntry left, DictionaryEntry right) { }

	// RVA: 0xD9F9F4
	public int GetHashCode(DictionaryEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Collections_DictionaryEntryEqualityComparer
{
	// Methods

	// RVA: 0xD9FA68
	public void .ctor() { }

	// RVA: 0xD9FA70
	public bool Equals(System.Nullable<System.Collections.DictionaryEntry> left, System.Nullable<System.Collections.DictionaryEntry> right) { }

	// RVA: 0xD9FC04
	public int GetHashCode(System.Nullable<System.Collections.DictionaryEntry> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_DebuggerBrowsableStateEqualityComparer
{
	// Methods

	// RVA: 0xD9FCB4
	public void .ctor() { }

	// RVA: 0xD9FCBC
	public bool Equals(DebuggerBrowsableState left, DebuggerBrowsableState right) { }

	// RVA: 0xD9FD44
	public int GetHashCode(DebuggerBrowsableState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_DebuggerBrowsableStateEqualityComparer
{
	// Methods

	// RVA: 0xD9FD6C
	public void .ctor() { }

	// RVA: 0xD9FD74
	public bool Equals(System.Nullable<System.Diagnostics.DebuggerBrowsableState> left, System.Nullable<System.Diagnostics.DebuggerBrowsableState> right) { }

	// RVA: 0xD9FEF0
	public int GetHashCode(System.Nullable<System.Diagnostics.DebuggerBrowsableState> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymAddressKindEqualityComparer
{
	// Methods

	// RVA: 0xD9FFA4
	public void .ctor() { }

	// RVA: 0xD9FFAC
	public bool Equals(SymAddressKind left, SymAddressKind right) { }

	// RVA: 0xDA0034
	public int GetHashCode(SymAddressKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymAddressKindEqualityComparer
{
	// Methods

	// RVA: 0xDA005C
	public void .ctor() { }

	// RVA: 0xDA0064
	public bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> left, System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> right) { }

	// RVA: 0xDA01E0
	public int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymbolTokenEqualityComparer
{
	// Methods

	// RVA: 0xDA0294
	public void .ctor() { }

	// RVA: 0xDA029C
	public bool Equals(SymbolToken left, SymbolToken right) { }

	// RVA: 0xDA02C8
	public int GetHashCode(SymbolToken obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymbolTokenEqualityComparer
{
	// Methods

	// RVA: 0xDA02D0
	public void .ctor() { }

	// RVA: 0xDA02D8
	public bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> left, System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> right) { }

	// RVA: 0xDA0420
	public int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarAlgorithmTypeEqualityComparer
{
	// Methods

	// RVA: 0xDA04D4
	public void .ctor() { }

	// RVA: 0xDA04DC
	public bool Equals(CalendarAlgorithmType left, CalendarAlgorithmType right) { }

	// RVA: 0xDA0564
	public int GetHashCode(CalendarAlgorithmType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarAlgorithmTypeEqualityComparer
{
	// Methods

	// RVA: 0xDA058C
	public void .ctor() { }

	// RVA: 0xDA0594
	public bool Equals(System.Nullable<System.Globalization.CalendarAlgorithmType> left, System.Nullable<System.Globalization.CalendarAlgorithmType> right) { }

	// RVA: 0xDA0710
	public int GetHashCode(System.Nullable<System.Globalization.CalendarAlgorithmType> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarWeekRuleEqualityComparer
{
	// Methods

	// RVA: 0xDA07C4
	public void .ctor() { }

	// RVA: 0xDA07CC
	public bool Equals(CalendarWeekRule left, CalendarWeekRule right) { }

	// RVA: 0xDA0854
	public int GetHashCode(CalendarWeekRule obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarWeekRuleEqualityComparer
{
	// Methods

	// RVA: 0xDA087C
	public void .ctor() { }

	// RVA: 0xDA0884
	public bool Equals(System.Nullable<System.Globalization.CalendarWeekRule> left, System.Nullable<System.Globalization.CalendarWeekRule> right) { }

	// RVA: 0xDA0A00
	public int GetHashCode(System.Nullable<System.Globalization.CalendarWeekRule> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CompareOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA0AB4
	public void .ctor() { }

	// RVA: 0xDA0ABC
	public bool Equals(CompareOptions left, CompareOptions right) { }

	// RVA: 0xDA0B44
	public int GetHashCode(CompareOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CompareOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA0B6C
	public void .ctor() { }

	// RVA: 0xDA0B74
	public bool Equals(System.Nullable<System.Globalization.CompareOptions> left, System.Nullable<System.Globalization.CompareOptions> right) { }

	// RVA: 0xDA0CF0
	public int GetHashCode(System.Nullable<System.Globalization.CompareOptions> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CultureTypesEqualityComparer
{
	// Methods

	// RVA: 0xDA0DA4
	public void .ctor() { }

	// RVA: 0xDA0DAC
	public bool Equals(CultureTypes left, CultureTypes right) { }

	// RVA: 0xDA0E34
	public int GetHashCode(CultureTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CultureTypesEqualityComparer
{
	// Methods

	// RVA: 0xDA0E5C
	public void .ctor() { }

	// RVA: 0xDA0E64
	public bool Equals(System.Nullable<System.Globalization.CultureTypes> left, System.Nullable<System.Globalization.CultureTypes> right) { }

	// RVA: 0xDA0FE0
	public int GetHashCode(System.Nullable<System.Globalization.CultureTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DateTimeStylesEqualityComparer
{
	// Methods

	// RVA: 0xDA1094
	public void .ctor() { }

	// RVA: 0xDA109C
	public bool Equals(DateTimeStyles left, DateTimeStyles right) { }

	// RVA: 0xDA1124
	public int GetHashCode(DateTimeStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DateTimeStylesEqualityComparer
{
	// Methods

	// RVA: 0xDA114C
	public void .ctor() { }

	// RVA: 0xDA1154
	public bool Equals(System.Nullable<System.Globalization.DateTimeStyles> left, System.Nullable<System.Globalization.DateTimeStyles> right) { }

	// RVA: 0xDA12D0
	public int GetHashCode(System.Nullable<System.Globalization.DateTimeStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DigitShapesEqualityComparer
{
	// Methods

	// RVA: 0xDA1384
	public void .ctor() { }

	// RVA: 0xDA138C
	public bool Equals(DigitShapes left, DigitShapes right) { }

	// RVA: 0xDA1414
	public int GetHashCode(DigitShapes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DigitShapesEqualityComparer
{
	// Methods

	// RVA: 0xDA143C
	public void .ctor() { }

	// RVA: 0xDA1444
	public bool Equals(System.Nullable<System.Globalization.DigitShapes> left, System.Nullable<System.Globalization.DigitShapes> right) { }

	// RVA: 0xDA15C0
	public int GetHashCode(System.Nullable<System.Globalization.DigitShapes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_GregorianCalendarTypesEqualityComparer
{
	// Methods

	// RVA: 0xDA1674
	public void .ctor() { }

	// RVA: 0xDA167C
	public bool Equals(GregorianCalendarTypes left, GregorianCalendarTypes right) { }

	// RVA: 0xDA1704
	public int GetHashCode(GregorianCalendarTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_GregorianCalendarTypesEqualityComparer
{
	// Methods

	// RVA: 0xDA172C
	public void .ctor() { }

	// RVA: 0xDA1734
	public bool Equals(System.Nullable<System.Globalization.GregorianCalendarTypes> left, System.Nullable<System.Globalization.GregorianCalendarTypes> right) { }

	// RVA: 0xDA18B0
	public int GetHashCode(System.Nullable<System.Globalization.GregorianCalendarTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_NumberStylesEqualityComparer
{
	// Methods

	// RVA: 0xDA1964
	public void .ctor() { }

	// RVA: 0xDA196C
	public bool Equals(NumberStyles left, NumberStyles right) { }

	// RVA: 0xDA19F4
	public int GetHashCode(NumberStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_NumberStylesEqualityComparer
{
	// Methods

	// RVA: 0xDA1A1C
	public void .ctor() { }

	// RVA: 0xDA1A24
	public bool Equals(System.Nullable<System.Globalization.NumberStyles> left, System.Nullable<System.Globalization.NumberStyles> right) { }

	// RVA: 0xDA1BA0
	public int GetHashCode(System.Nullable<System.Globalization.NumberStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_UnicodeCategoryEqualityComparer
{
	// Methods

	// RVA: 0xDA1C54
	public void .ctor() { }

	// RVA: 0xDA1C5C
	public bool Equals(UnicodeCategory left, UnicodeCategory right) { }

	// RVA: 0xDA1CE4
	public int GetHashCode(UnicodeCategory obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_UnicodeCategoryEqualityComparer
{
	// Methods

	// RVA: 0xDA1D0C
	public void .ctor() { }

	// RVA: 0xDA1D14
	public bool Equals(System.Nullable<System.Globalization.UnicodeCategory> left, System.Nullable<System.Globalization.UnicodeCategory> right) { }

	// RVA: 0xDA1E90
	public int GetHashCode(System.Nullable<System.Globalization.UnicodeCategory> obj) { }

}

// Namespace: 
private sealed class System_IO_DriveTypeEqualityComparer
{
	// Methods

	// RVA: 0xDA1F44
	public void .ctor() { }

	// RVA: 0xDA1F4C
	public bool Equals(DriveType left, DriveType right) { }

	// RVA: 0xDA1FD4
	public int GetHashCode(DriveType obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_DriveTypeEqualityComparer
{
	// Methods

	// RVA: 0xDA1FFC
	public void .ctor() { }

	// RVA: 0xDA2004
	public bool Equals(System.Nullable<System.IO.DriveType> left, System.Nullable<System.IO.DriveType> right) { }

	// RVA: 0xDA2180
	public int GetHashCode(System.Nullable<System.IO.DriveType> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAccessEqualityComparer
{
	// Methods

	// RVA: 0xDA2234
	public void .ctor() { }

	// RVA: 0xDA223C
	public bool Equals(FileAccess left, FileAccess right) { }

	// RVA: 0xDA22C4
	public int GetHashCode(FileAccess obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAccessEqualityComparer
{
	// Methods

	// RVA: 0xDA22EC
	public void .ctor() { }

	// RVA: 0xDA22F4
	public bool Equals(System.Nullable<System.IO.FileAccess> left, System.Nullable<System.IO.FileAccess> right) { }

	// RVA: 0xDA2470
	public int GetHashCode(System.Nullable<System.IO.FileAccess> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA2524
	public void .ctor() { }

	// RVA: 0xDA252C
	public bool Equals(FileAttributes left, FileAttributes right) { }

	// RVA: 0xDA25B4
	public int GetHashCode(FileAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA25DC
	public void .ctor() { }

	// RVA: 0xDA25E4
	public bool Equals(System.Nullable<System.IO.FileAttributes> left, System.Nullable<System.IO.FileAttributes> right) { }

	// RVA: 0xDA2760
	public int GetHashCode(System.Nullable<System.IO.FileAttributes> obj) { }

}

// Namespace: 
private sealed class System_IO_FileModeEqualityComparer
{
	// Methods

	// RVA: 0xDA2814
	public void .ctor() { }

	// RVA: 0xDA281C
	public bool Equals(FileMode left, FileMode right) { }

	// RVA: 0xDA28A4
	public int GetHashCode(FileMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileModeEqualityComparer
{
	// Methods

	// RVA: 0xDA28CC
	public void .ctor() { }

	// RVA: 0xDA28D4
	public bool Equals(System.Nullable<System.IO.FileMode> left, System.Nullable<System.IO.FileMode> right) { }

	// RVA: 0xDA2A50
	public int GetHashCode(System.Nullable<System.IO.FileMode> obj) { }

}

// Namespace: 
private sealed class System_IO_FileOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA2B04
	public void .ctor() { }

	// RVA: 0xDA2B0C
	public bool Equals(FileOptions left, FileOptions right) { }

	// RVA: 0xDA2B94
	public int GetHashCode(FileOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA2BBC
	public void .ctor() { }

	// RVA: 0xDA2BC4
	public bool Equals(System.Nullable<System.IO.FileOptions> left, System.Nullable<System.IO.FileOptions> right) { }

	// RVA: 0xDA2D40
	public int GetHashCode(System.Nullable<System.IO.FileOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_FileShareEqualityComparer
{
	// Methods

	// RVA: 0xDA2DF4
	public void .ctor() { }

	// RVA: 0xDA2DFC
	public bool Equals(FileShare left, FileShare right) { }

	// RVA: 0xDA2E84
	public int GetHashCode(FileShare obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileShareEqualityComparer
{
	// Methods

	// RVA: 0xDA2EAC
	public void .ctor() { }

	// RVA: 0xDA2EB4
	public bool Equals(System.Nullable<System.IO.FileShare> left, System.Nullable<System.IO.FileShare> right) { }

	// RVA: 0xDA3030
	public int GetHashCode(System.Nullable<System.IO.FileShare> obj) { }

}

// Namespace: 
private sealed class System_IO_HandleInheritabilityEqualityComparer
{
	// Methods

	// RVA: 0xDA30E4
	public void .ctor() { }

	// RVA: 0xDA30EC
	public bool Equals(HandleInheritability left, HandleInheritability right) { }

	// RVA: 0xDA3174
	public int GetHashCode(HandleInheritability obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_HandleInheritabilityEqualityComparer
{
	// Methods

	// RVA: 0xDA319C
	public void .ctor() { }

	// RVA: 0xDA31A4
	public bool Equals(System.Nullable<System.IO.HandleInheritability> left, System.Nullable<System.IO.HandleInheritability> right) { }

	// RVA: 0xDA3320
	public int GetHashCode(System.Nullable<System.IO.HandleInheritability> obj) { }

}

// Namespace: 
private sealed class System_IO_SearchOptionEqualityComparer
{
	// Methods

	// RVA: 0xDA33D4
	public void .ctor() { }

	// RVA: 0xDA33DC
	public bool Equals(SearchOption left, SearchOption right) { }

	// RVA: 0xDA3464
	public int GetHashCode(SearchOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SearchOptionEqualityComparer
{
	// Methods

	// RVA: 0xDA348C
	public void .ctor() { }

	// RVA: 0xDA3494
	public bool Equals(System.Nullable<System.IO.SearchOption> left, System.Nullable<System.IO.SearchOption> right) { }

	// RVA: 0xDA3610
	public int GetHashCode(System.Nullable<System.IO.SearchOption> obj) { }

}

// Namespace: 
private sealed class System_IO_SeekOriginEqualityComparer
{
	// Methods

	// RVA: 0xDA36C4
	public void .ctor() { }

	// RVA: 0xDA36CC
	public bool Equals(SeekOrigin left, SeekOrigin right) { }

	// RVA: 0xDA3754
	public int GetHashCode(SeekOrigin obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SeekOriginEqualityComparer
{
	// Methods

	// RVA: 0xDA377C
	public void .ctor() { }

	// RVA: 0xDA3784
	public bool Equals(System.Nullable<System.IO.SeekOrigin> left, System.Nullable<System.IO.SeekOrigin> right) { }

	// RVA: 0xDA3900
	public int GetHashCode(System.Nullable<System.IO.SeekOrigin> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeAccessRightsEqualityComparer
{
	// Methods

	// RVA: 0xDA39B4
	public void .ctor() { }

	// RVA: 0xDA39BC
	public bool Equals(PipeAccessRights left, PipeAccessRights right) { }

	// RVA: 0xDA3A44
	public int GetHashCode(PipeAccessRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeAccessRightsEqualityComparer
{
	// Methods

	// RVA: 0xDA3A6C
	public void .ctor() { }

	// RVA: 0xDA3A74
	public bool Equals(System.Nullable<System.IO.Pipes.PipeAccessRights> left, System.Nullable<System.IO.Pipes.PipeAccessRights> right) { }

	// RVA: 0xDA3BF0
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeAccessRights> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeDirectionEqualityComparer
{
	// Methods

	// RVA: 0xDA3CA4
	public void .ctor() { }

	// RVA: 0xDA3CAC
	public bool Equals(PipeDirection left, PipeDirection right) { }

	// RVA: 0xDA3D34
	public int GetHashCode(PipeDirection obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeDirectionEqualityComparer
{
	// Methods

	// RVA: 0xDA3D5C
	public void .ctor() { }

	// RVA: 0xDA3D64
	public bool Equals(System.Nullable<System.IO.Pipes.PipeDirection> left, System.Nullable<System.IO.Pipes.PipeDirection> right) { }

	// RVA: 0xDA3EE0
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeDirection> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA3F94
	public void .ctor() { }

	// RVA: 0xDA3F9C
	public bool Equals(PipeOptions left, PipeOptions right) { }

	// RVA: 0xDA4024
	public int GetHashCode(PipeOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA404C
	public void .ctor() { }

	// RVA: 0xDA4054
	public bool Equals(System.Nullable<System.IO.Pipes.PipeOptions> left, System.Nullable<System.IO.Pipes.PipeOptions> right) { }

	// RVA: 0xDA41D0
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeTransmissionModeEqualityComparer
{
	// Methods

	// RVA: 0xDA4284
	public void .ctor() { }

	// RVA: 0xDA428C
	public bool Equals(PipeTransmissionMode left, PipeTransmissionMode right) { }

	// RVA: 0xDA4314
	public int GetHashCode(PipeTransmissionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeTransmissionModeEqualityComparer
{
	// Methods

	// RVA: 0xDA433C
	public void .ctor() { }

	// RVA: 0xDA4344
	public bool Equals(System.Nullable<System.IO.Pipes.PipeTransmissionMode> left, System.Nullable<System.IO.Pipes.PipeTransmissionMode> right) { }

	// RVA: 0xDA44C0
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeTransmissionMode> obj) { }

}

// Namespace: 
private sealed class System_Reflection_AssemblyNameFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDA4574
	public void .ctor() { }

	// RVA: 0xDA457C
	public bool Equals(AssemblyNameFlags left, AssemblyNameFlags right) { }

	// RVA: 0xDA4604
	public int GetHashCode(AssemblyNameFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_AssemblyNameFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDA462C
	public void .ctor() { }

	// RVA: 0xDA4634
	public bool Equals(System.Nullable<System.Reflection.AssemblyNameFlags> left, System.Nullable<System.Reflection.AssemblyNameFlags> right) { }

	// RVA: 0xDA47B0
	public int GetHashCode(System.Nullable<System.Reflection.AssemblyNameFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_BindingFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDA4864
	public void .ctor() { }

	// RVA: 0xDA486C
	public bool Equals(BindingFlags left, BindingFlags right) { }

	// RVA: 0xDA48F4
	public int GetHashCode(BindingFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_BindingFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDA491C
	public void .ctor() { }

	// RVA: 0xDA4924
	public bool Equals(System.Nullable<System.Reflection.BindingFlags> left, System.Nullable<System.Reflection.BindingFlags> right) { }

	// RVA: 0xDA4AA0
	public int GetHashCode(System.Nullable<System.Reflection.BindingFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CallingConventionsEqualityComparer
{
	// Methods

	// RVA: 0xDA4B54
	public void .ctor() { }

	// RVA: 0xDA4B5C
	public bool Equals(CallingConventions left, CallingConventions right) { }

	// RVA: 0xDA4BE4
	public int GetHashCode(CallingConventions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CallingConventionsEqualityComparer
{
	// Methods

	// RVA: 0xDA4C0C
	public void .ctor() { }

	// RVA: 0xDA4C14
	public bool Equals(System.Nullable<System.Reflection.CallingConventions> left, System.Nullable<System.Reflection.CallingConventions> right) { }

	// RVA: 0xDA4D90
	public int GetHashCode(System.Nullable<System.Reflection.CallingConventions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeNamedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xDA4E44
	public void .ctor() { }

	// RVA: 0xDA4E4C
	public bool Equals(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0xDA4ED0
	public int GetHashCode(CustomAttributeNamedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeNamedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xDA4EDC
	public void .ctor() { }

	// RVA: 0xDA4EE4
	public bool Equals(System.Nullable<System.Reflection.CustomAttributeNamedArgument> left, System.Nullable<System.Reflection.CustomAttributeNamedArgument> right) { }

	// RVA: 0xDA507C
	public int GetHashCode(System.Nullable<System.Reflection.CustomAttributeNamedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeTypedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xDA512C
	public void .ctor() { }

	// RVA: 0xDA5134
	public bool Equals(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0xDA51B0
	public int GetHashCode(CustomAttributeTypedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeTypedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xDA51D8
	public void .ctor() { }

	// RVA: 0xDA51E0
	public bool Equals(System.Nullable<System.Reflection.CustomAttributeTypedArgument> left, System.Nullable<System.Reflection.CustomAttributeTypedArgument> right) { }

	// RVA: 0xDA5368
	public int GetHashCode(System.Nullable<System.Reflection.CustomAttributeTypedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_EventAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA5418
	public void .ctor() { }

	// RVA: 0xDA5420
	public bool Equals(EventAttributes left, EventAttributes right) { }

	// RVA: 0xDA54A8
	public int GetHashCode(EventAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_EventAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA54D0
	public void .ctor() { }

	// RVA: 0xDA54D8
	public bool Equals(System.Nullable<System.Reflection.EventAttributes> left, System.Nullable<System.Reflection.EventAttributes> right) { }

	// RVA: 0xDA5654
	public int GetHashCode(System.Nullable<System.Reflection.EventAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ExceptionHandlingClauseOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA5708
	public void .ctor() { }

	// RVA: 0xDA5710
	public bool Equals(ExceptionHandlingClauseOptions left, ExceptionHandlingClauseOptions right) { }

	// RVA: 0xDA5798
	public int GetHashCode(ExceptionHandlingClauseOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ExceptionHandlingClauseOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA57C0
	public void .ctor() { }

	// RVA: 0xDA57C8
	public bool Equals(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> left, System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> right) { }

	// RVA: 0xDA5944
	public int GetHashCode(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_FieldAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA59F8
	public void .ctor() { }

	// RVA: 0xDA5A00
	public bool Equals(FieldAttributes left, FieldAttributes right) { }

	// RVA: 0xDA5A88
	public int GetHashCode(FieldAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_FieldAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA5AB0
	public void .ctor() { }

	// RVA: 0xDA5AB8
	public bool Equals(System.Nullable<System.Reflection.FieldAttributes> left, System.Nullable<System.Reflection.FieldAttributes> right) { }

	// RVA: 0xDA5C34
	public int GetHashCode(System.Nullable<System.Reflection.FieldAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_GenericParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA5CE8
	public void .ctor() { }

	// RVA: 0xDA5CF0
	public bool Equals(GenericParameterAttributes left, GenericParameterAttributes right) { }

	// RVA: 0xDA5D78
	public int GetHashCode(GenericParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_GenericParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA5DA0
	public void .ctor() { }

	// RVA: 0xDA5DA8
	public bool Equals(System.Nullable<System.Reflection.GenericParameterAttributes> left, System.Nullable<System.Reflection.GenericParameterAttributes> right) { }

	// RVA: 0xDA5F24
	public int GetHashCode(System.Nullable<System.Reflection.GenericParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ImageFileMachineEqualityComparer
{
	// Methods

	// RVA: 0xDA5FD8
	public void .ctor() { }

	// RVA: 0xDA5FE0
	public bool Equals(ImageFileMachine left, ImageFileMachine right) { }

	// RVA: 0xDA6068
	public int GetHashCode(ImageFileMachine obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ImageFileMachineEqualityComparer
{
	// Methods

	// RVA: 0xDA6090
	public void .ctor() { }

	// RVA: 0xDA6098
	public bool Equals(System.Nullable<System.Reflection.ImageFileMachine> left, System.Nullable<System.Reflection.ImageFileMachine> right) { }

	// RVA: 0xDA6214
	public int GetHashCode(System.Nullable<System.Reflection.ImageFileMachine> obj) { }

}

// Namespace: 
private sealed class System_Reflection_InterfaceMappingEqualityComparer
{
	// Methods

	// RVA: 0xDA62C8
	public void .ctor() { }

	// RVA: 0xDA62D0
	public bool Equals(InterfaceMapping left, InterfaceMapping right) { }

	// RVA: 0xDA6360
	public int GetHashCode(InterfaceMapping obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_InterfaceMappingEqualityComparer
{
	// Methods

	// RVA: 0xDA63D4
	public void .ctor() { }

	// RVA: 0xDA63DC
	public bool Equals(System.Nullable<System.Reflection.InterfaceMapping> left, System.Nullable<System.Reflection.InterfaceMapping> right) { }

	// RVA: 0xDA6578
	public int GetHashCode(System.Nullable<System.Reflection.InterfaceMapping> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MemberTypesEqualityComparer
{
	// Methods

	// RVA: 0xDA6628
	public void .ctor() { }

	// RVA: 0xDA6630
	public bool Equals(MemberTypes left, MemberTypes right) { }

	// RVA: 0xDA66B8
	public int GetHashCode(MemberTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MemberTypesEqualityComparer
{
	// Methods

	// RVA: 0xDA66E0
	public void .ctor() { }

	// RVA: 0xDA66E8
	public bool Equals(System.Nullable<System.Reflection.MemberTypes> left, System.Nullable<System.Reflection.MemberTypes> right) { }

	// RVA: 0xDA6864
	public int GetHashCode(System.Nullable<System.Reflection.MemberTypes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA6918
	public void .ctor() { }

	// RVA: 0xDA6920
	public bool Equals(MethodAttributes left, MethodAttributes right) { }

	// RVA: 0xDA69A8
	public int GetHashCode(MethodAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA69D0
	public void .ctor() { }

	// RVA: 0xDA69D8
	public bool Equals(System.Nullable<System.Reflection.MethodAttributes> left, System.Nullable<System.Reflection.MethodAttributes> right) { }

	// RVA: 0xDA6B54
	public int GetHashCode(System.Nullable<System.Reflection.MethodAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodImplAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA6C08
	public void .ctor() { }

	// RVA: 0xDA6C10
	public bool Equals(MethodImplAttributes left, MethodImplAttributes right) { }

	// RVA: 0xDA6C98
	public int GetHashCode(MethodImplAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodImplAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA6CC0
	public void .ctor() { }

	// RVA: 0xDA6CC8
	public bool Equals(System.Nullable<System.Reflection.MethodImplAttributes> left, System.Nullable<System.Reflection.MethodImplAttributes> right) { }

	// RVA: 0xDA6E44
	public int GetHashCode(System.Nullable<System.Reflection.MethodImplAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA6EF8
	public void .ctor() { }

	// RVA: 0xDA6F00
	public bool Equals(ParameterAttributes left, ParameterAttributes right) { }

	// RVA: 0xDA6F88
	public int GetHashCode(ParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA6FB0
	public void .ctor() { }

	// RVA: 0xDA6FB8
	public bool Equals(System.Nullable<System.Reflection.ParameterAttributes> left, System.Nullable<System.Reflection.ParameterAttributes> right) { }

	// RVA: 0xDA7134
	public int GetHashCode(System.Nullable<System.Reflection.ParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterModifierEqualityComparer
{
	// Methods

	// RVA: 0xDA71E8
	public void .ctor() { }

	// RVA: 0xDA71F0
	public bool Equals(ParameterModifier left, ParameterModifier right) { }

	// RVA: 0xDA7278
	public int GetHashCode(ParameterModifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterModifierEqualityComparer
{
	// Methods

	// RVA: 0xDA72E8
	public void .ctor() { }

	// RVA: 0xDA72F0
	public bool Equals(System.Nullable<System.Reflection.ParameterModifier> left, System.Nullable<System.Reflection.ParameterModifier> right) { }

	// RVA: 0xDA746C
	public int GetHashCode(System.Nullable<System.Reflection.ParameterModifier> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PortableExecutableKindsEqualityComparer
{
	// Methods

	// RVA: 0xDA7520
	public void .ctor() { }

	// RVA: 0xDA7528
	public bool Equals(PortableExecutableKinds left, PortableExecutableKinds right) { }

	// RVA: 0xDA75B0
	public int GetHashCode(PortableExecutableKinds obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PortableExecutableKindsEqualityComparer
{
	// Methods

	// RVA: 0xDA75D8
	public void .ctor() { }

	// RVA: 0xDA75E0
	public bool Equals(System.Nullable<System.Reflection.PortableExecutableKinds> left, System.Nullable<System.Reflection.PortableExecutableKinds> right) { }

	// RVA: 0xDA775C
	public int GetHashCode(System.Nullable<System.Reflection.PortableExecutableKinds> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ProcessorArchitectureEqualityComparer
{
	// Methods

	// RVA: 0xDA7810
	public void .ctor() { }

	// RVA: 0xDA7818
	public bool Equals(ProcessorArchitecture left, ProcessorArchitecture right) { }

	// RVA: 0xDA78A0
	public int GetHashCode(ProcessorArchitecture obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ProcessorArchitectureEqualityComparer
{
	// Methods

	// RVA: 0xDA78C8
	public void .ctor() { }

	// RVA: 0xDA78D0
	public bool Equals(System.Nullable<System.Reflection.ProcessorArchitecture> left, System.Nullable<System.Reflection.ProcessorArchitecture> right) { }

	// RVA: 0xDA7A4C
	public int GetHashCode(System.Nullable<System.Reflection.ProcessorArchitecture> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PropertyAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA7B00
	public void .ctor() { }

	// RVA: 0xDA7B08
	public bool Equals(PropertyAttributes left, PropertyAttributes right) { }

	// RVA: 0xDA7B90
	public int GetHashCode(PropertyAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PropertyAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA7BB8
	public void .ctor() { }

	// RVA: 0xDA7BC0
	public bool Equals(System.Nullable<System.Reflection.PropertyAttributes> left, System.Nullable<System.Reflection.PropertyAttributes> right) { }

	// RVA: 0xDA7D3C
	public int GetHashCode(System.Nullable<System.Reflection.PropertyAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA7DF0
	public void .ctor() { }

	// RVA: 0xDA7DF8
	public bool Equals(ResourceAttributes left, ResourceAttributes right) { }

	// RVA: 0xDA7E80
	public int GetHashCode(ResourceAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA7EA8
	public void .ctor() { }

	// RVA: 0xDA7EB0
	public bool Equals(System.Nullable<System.Reflection.ResourceAttributes> left, System.Nullable<System.Reflection.ResourceAttributes> right) { }

	// RVA: 0xDA802C
	public int GetHashCode(System.Nullable<System.Reflection.ResourceAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceLocationEqualityComparer
{
	// Methods

	// RVA: 0xDA80E0
	public void .ctor() { }

	// RVA: 0xDA80E8
	public bool Equals(ResourceLocation left, ResourceLocation right) { }

	// RVA: 0xDA8170
	public int GetHashCode(ResourceLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceLocationEqualityComparer
{
	// Methods

	// RVA: 0xDA8198
	public void .ctor() { }

	// RVA: 0xDA81A0
	public bool Equals(System.Nullable<System.Reflection.ResourceLocation> left, System.Nullable<System.Reflection.ResourceLocation> right) { }

	// RVA: 0xDA831C
	public int GetHashCode(System.Nullable<System.Reflection.ResourceLocation> obj) { }

}

// Namespace: 
private sealed class System_Reflection_TypeAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA83D0
	public void .ctor() { }

	// RVA: 0xDA83D8
	public bool Equals(TypeAttributes left, TypeAttributes right) { }

	// RVA: 0xDA8460
	public int GetHashCode(TypeAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_TypeAttributesEqualityComparer
{
	// Methods

	// RVA: 0xDA8488
	public void .ctor() { }

	// RVA: 0xDA8490
	public bool Equals(System.Nullable<System.Reflection.TypeAttributes> left, System.Nullable<System.Reflection.TypeAttributes> right) { }

	// RVA: 0xDA860C
	public int GetHashCode(System.Nullable<System.Reflection.TypeAttributes> obj) { }

}

// Namespace: 
private sealed class System_Resources_UltimateResourceFallbackLocationEqualityComparer
{
	// Methods

	// RVA: 0xDA86C0
	public void .ctor() { }

	// RVA: 0xDA86C8
	public bool Equals(UltimateResourceFallbackLocation left, UltimateResourceFallbackLocation right) { }

	// RVA: 0xDA8750
	public int GetHashCode(UltimateResourceFallbackLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Resources_UltimateResourceFallbackLocationEqualityComparer
{
	// Methods

	// RVA: 0xDA8778
	public void .ctor() { }

	// RVA: 0xDA8780
	public bool Equals(System.Nullable<System.Resources.UltimateResourceFallbackLocation> left, System.Nullable<System.Resources.UltimateResourceFallbackLocation> right) { }

	// RVA: 0xDA88FC
	public int GetHashCode(System.Nullable<System.Resources.UltimateResourceFallbackLocation> obj) { }

}

// Namespace: 
private sealed class System_Runtime_GCLatencyModeEqualityComparer
{
	// Methods

	// RVA: 0xDA89B0
	public void .ctor() { }

	// RVA: 0xDA89B8
	public bool Equals(GCLatencyMode left, GCLatencyMode right) { }

	// RVA: 0xDA8A40
	public int GetHashCode(GCLatencyMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_GCLatencyModeEqualityComparer
{
	// Methods

	// RVA: 0xDA8A68
	public void .ctor() { }

	// RVA: 0xDA8A70
	public bool Equals(System.Nullable<System.Runtime.GCLatencyMode> left, System.Nullable<System.Runtime.GCLatencyMode> right) { }

	// RVA: 0xDA8BEC
	public int GetHashCode(System.Nullable<System.Runtime.GCLatencyMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer
{
	// Methods

	// RVA: 0xDA8CA0
	public void .ctor() { }

	// RVA: 0xDA8CA8
	public bool Equals(CompilationRelaxations left, CompilationRelaxations right) { }

	// RVA: 0xDA8D30
	public int GetHashCode(CompilationRelaxations obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer
{
	// Methods

	// RVA: 0xDA8D58
	public void .ctor() { }

	// RVA: 0xDA8D60
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> left, System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> right) { }

	// RVA: 0xDA8EDC
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_LoadHintEqualityComparer
{
	// Methods

	// RVA: 0xDA8F90
	public void .ctor() { }

	// RVA: 0xDA8F98
	public bool Equals(LoadHint left, LoadHint right) { }

	// RVA: 0xDA9020
	public int GetHashCode(LoadHint obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_LoadHintEqualityComparer
{
	// Methods

	// RVA: 0xDA9048
	public void .ctor() { }

	// RVA: 0xDA9050
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.LoadHint> left, System.Nullable<System.Runtime.CompilerServices.LoadHint> right) { }

	// RVA: 0xDA91CC
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.LoadHint> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodCodeTypeEqualityComparer
{
	// Methods

	// RVA: 0xDA9280
	public void .ctor() { }

	// RVA: 0xDA9288
	public bool Equals(MethodCodeType left, MethodCodeType right) { }

	// RVA: 0xDA9310
	public int GetHashCode(MethodCodeType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodCodeTypeEqualityComparer
{
	// Methods

	// RVA: 0xDA9338
	public void .ctor() { }

	// RVA: 0xDA9340
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> left, System.Nullable<System.Runtime.CompilerServices.MethodCodeType> right) { }

	// RVA: 0xDA94BC
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodImplOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA9570
	public void .ctor() { }

	// RVA: 0xDA9578
	public bool Equals(MethodImplOptions left, MethodImplOptions right) { }

	// RVA: 0xDA9600
	public int GetHashCode(MethodImplOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodImplOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDA9628
	public void .ctor() { }

	// RVA: 0xDA9630
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> left, System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> right) { }

	// RVA: 0xDA97AC
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_CerEqualityComparer
{
	// Methods

	// RVA: 0xDA9860
	public void .ctor() { }

	// RVA: 0xDA9868
	public bool Equals(Cer left, Cer right) { }

	// RVA: 0xDA98F0
	public int GetHashCode(Cer obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_CerEqualityComparer
{
	// Methods

	// RVA: 0xDA9918
	public void .ctor() { }

	// RVA: 0xDA9920
	public bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Cer> left, System.Nullable<System.Runtime.ConstrainedExecution.Cer> right) { }

	// RVA: 0xDA9A9C
	public int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Cer> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_ConsistencyEqualityComparer
{
	// Methods

	// RVA: 0xDA9B50
	public void .ctor() { }

	// RVA: 0xDA9B58
	public bool Equals(Consistency left, Consistency right) { }

	// RVA: 0xDA9BE0
	public int GetHashCode(Consistency obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_ConsistencyEqualityComparer
{
	// Methods

	// RVA: 0xDA9C08
	public void .ctor() { }

	// RVA: 0xDA9C10
	public bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> left, System.Nullable<System.Runtime.ConstrainedExecution.Consistency> right) { }

	// RVA: 0xDA9D8C
	public int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ArrayWithOffsetEqualityComparer
{
	// Methods

	// RVA: 0xDA9E40
	public void .ctor() { }

	// RVA: 0xDA9E48
	public bool Equals(ArrayWithOffset left, ArrayWithOffset right) { }

	// RVA: 0xDA9E78
	public int GetHashCode(ArrayWithOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ArrayWithOffsetEqualityComparer
{
	// Methods

	// RVA: 0xDA9EA0
	public void .ctor() { }

	// RVA: 0xDA9EA8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> left, System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> right) { }

	// RVA: 0xDAA008
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDAA0B8
	public void .ctor() { }

	// RVA: 0xDAA0C0
	public bool Equals(AssemblyRegistrationFlags left, AssemblyRegistrationFlags right) { }

	// RVA: 0xDAA148
	public int GetHashCode(AssemblyRegistrationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDAA170
	public void .ctor() { }

	// RVA: 0xDAA178
	public bool Equals(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> left, System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> right) { }

	// RVA: 0xDAA2F4
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CallingConventionEqualityComparer
{
	// Methods

	// RVA: 0xDAA3A8
	public void .ctor() { }

	// RVA: 0xDAA3B0
	public bool Equals(CallingConvention left, CallingConvention right) { }

	// RVA: 0xDAA438
	public int GetHashCode(CallingConvention obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CallingConventionEqualityComparer
{
	// Methods

	// RVA: 0xDAA460
	public void .ctor() { }

	// RVA: 0xDAA468
	public bool Equals(System.Nullable<System.Runtime.InteropServices.CallingConvention> left, System.Nullable<System.Runtime.InteropServices.CallingConvention> right) { }

	// RVA: 0xDAA5E4
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.CallingConvention> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CharSetEqualityComparer
{
	// Methods

	// RVA: 0xDAA698
	public void .ctor() { }

	// RVA: 0xDAA6A0
	public bool Equals(CharSet left, CharSet right) { }

	// RVA: 0xDAA728
	public int GetHashCode(CharSet obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CharSetEqualityComparer
{
	// Methods

	// RVA: 0xDAA750
	public void .ctor() { }

	// RVA: 0xDAA758
	public bool Equals(System.Nullable<System.Runtime.InteropServices.CharSet> left, System.Nullable<System.Runtime.InteropServices.CharSet> right) { }

	// RVA: 0xDAA8D4
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.CharSet> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAA988
	public void .ctor() { }

	// RVA: 0xDAA990
	public bool Equals(ClassInterfaceType left, ClassInterfaceType right) { }

	// RVA: 0xDAAA18
	public int GetHashCode(ClassInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAAA40
	public void .ctor() { }

	// RVA: 0xDAAA48
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> right) { }

	// RVA: 0xDAABC4
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAAC78
	public void .ctor() { }

	// RVA: 0xDAAC80
	public bool Equals(ComInterfaceType left, ComInterfaceType right) { }

	// RVA: 0xDAAD08
	public int GetHashCode(ComInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAAD30
	public void .ctor() { }

	// RVA: 0xDAAD38
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ComInterfaceType> right) { }

	// RVA: 0xDAAEB4
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComMemberTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAAF68
	public void .ctor() { }

	// RVA: 0xDAAF70
	public bool Equals(ComMemberType left, ComMemberType right) { }

	// RVA: 0xDAAFF8
	public int GetHashCode(ComMemberType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComMemberTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAB020
	public void .ctor() { }

	// RVA: 0xDAB028
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ComMemberType> left, System.Nullable<System.Runtime.InteropServices.ComMemberType> right) { }

	// RVA: 0xDAB1A4
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComMemberType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ExporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xDAB258
	public void .ctor() { }

	// RVA: 0xDAB260
	public bool Equals(ExporterEventKind left, ExporterEventKind right) { }

	// RVA: 0xDAB2E8
	public int GetHashCode(ExporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ExporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xDAB310
	public void .ctor() { }

	// RVA: 0xDAB318
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ExporterEventKind> right) { }

	// RVA: 0xDAB494
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleEqualityComparer
{
	// Methods

	// RVA: 0xDAB548
	public void .ctor() { }

	// RVA: 0xDAB550
	public bool Equals(GCHandle left, GCHandle right) { }

	// RVA: 0xDAB5C8
	public int GetHashCode(GCHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleEqualityComparer
{
	// Methods

	// RVA: 0xDAB5F0
	public void .ctor() { }

	// RVA: 0xDAB5F8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandle> left, System.Nullable<System.Runtime.InteropServices.GCHandle> right) { }

	// RVA: 0xDAB764
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAB818
	public void .ctor() { }

	// RVA: 0xDAB820
	public bool Equals(GCHandleType left, GCHandleType right) { }

	// RVA: 0xDAB8A8
	public int GetHashCode(GCHandleType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAB8D0
	public void .ctor() { }

	// RVA: 0xDAB8D8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandleType> left, System.Nullable<System.Runtime.InteropServices.GCHandleType> right) { }

	// RVA: 0xDABA54
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandleType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_HandleRefEqualityComparer
{
	// Methods

	// RVA: 0xDABB08
	public void .ctor() { }

	// RVA: 0xDABB10
	public bool Equals(HandleRef left, HandleRef right) { }

	// RVA: 0xDABBA8
	public int GetHashCode(HandleRef obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_HandleRefEqualityComparer
{
	// Methods

	// RVA: 0xDABC1C
	public void .ctor() { }

	// RVA: 0xDABC24
	public bool Equals(System.Nullable<System.Runtime.InteropServices.HandleRef> left, System.Nullable<System.Runtime.InteropServices.HandleRef> right) { }

	// RVA: 0xDABDB8
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.HandleRef> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ImporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xDABE68
	public void .ctor() { }

	// RVA: 0xDABE70
	public bool Equals(ImporterEventKind left, ImporterEventKind right) { }

	// RVA: 0xDABEF8
	public int GetHashCode(ImporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ImporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xDABF20
	public void .ctor() { }

	// RVA: 0xDABF28
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ImporterEventKind> right) { }

	// RVA: 0xDAC0A4
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_LayoutKindEqualityComparer
{
	// Methods

	// RVA: 0xDAC158
	public void .ctor() { }

	// RVA: 0xDAC160
	public bool Equals(LayoutKind left, LayoutKind right) { }

	// RVA: 0xDAC1E8
	public int GetHashCode(LayoutKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_LayoutKindEqualityComparer
{
	// Methods

	// RVA: 0xDAC210
	public void .ctor() { }

	// RVA: 0xDAC218
	public bool Equals(System.Nullable<System.Runtime.InteropServices.LayoutKind> left, System.Nullable<System.Runtime.InteropServices.LayoutKind> right) { }

	// RVA: 0xDAC394
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.LayoutKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationClassContextEqualityComparer
{
	// Methods

	// RVA: 0xDAC448
	public void .ctor() { }

	// RVA: 0xDAC450
	public bool Equals(RegistrationClassContext left, RegistrationClassContext right) { }

	// RVA: 0xDAC4D8
	public int GetHashCode(RegistrationClassContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationClassContextEqualityComparer
{
	// Methods

	// RVA: 0xDAC500
	public void .ctor() { }

	// RVA: 0xDAC508
	public bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> left, System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> right) { }

	// RVA: 0xDAC684
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAC738
	public void .ctor() { }

	// RVA: 0xDAC740
	public bool Equals(RegistrationConnectionType left, RegistrationConnectionType right) { }

	// RVA: 0xDAC7C8
	public int GetHashCode(RegistrationConnectionType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAC7F0
	public void .ctor() { }

	// RVA: 0xDAC7F8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> left, System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> right) { }

	// RVA: 0xDAC974
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDACA28
	public void .ctor() { }

	// RVA: 0xDACA30
	public bool Equals(TypeLibExporterFlags left, TypeLibExporterFlags right) { }

	// RVA: 0xDACAB8
	public int GetHashCode(TypeLibExporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDACAE0
	public void .ctor() { }

	// RVA: 0xDACAE8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> right) { }

	// RVA: 0xDACC64
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDACD18
	public void .ctor() { }

	// RVA: 0xDACD20
	public bool Equals(TypeLibFuncFlags left, TypeLibFuncFlags right) { }

	// RVA: 0xDACDA8
	public int GetHashCode(TypeLibFuncFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDACDD0
	public void .ctor() { }

	// RVA: 0xDACDD8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> right) { }

	// RVA: 0xDACF54
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDAD008
	public void .ctor() { }

	// RVA: 0xDAD010
	public bool Equals(TypeLibImporterFlags left, TypeLibImporterFlags right) { }

	// RVA: 0xDAD098
	public int GetHashCode(TypeLibImporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDAD0C0
	public void .ctor() { }

	// RVA: 0xDAD0C8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> right) { }

	// RVA: 0xDAD244
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDAD2F8
	public void .ctor() { }

	// RVA: 0xDAD300
	public bool Equals(TypeLibTypeFlags left, TypeLibTypeFlags right) { }

	// RVA: 0xDAD388
	public int GetHashCode(TypeLibTypeFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDAD3B0
	public void .ctor() { }

	// RVA: 0xDAD3B8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> right) { }

	// RVA: 0xDAD534
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDAD5E8
	public void .ctor() { }

	// RVA: 0xDAD5F0
	public bool Equals(TypeLibVarFlags left, TypeLibVarFlags right) { }

	// RVA: 0xDAD678
	public int GetHashCode(TypeLibVarFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDAD6A0
	public void .ctor() { }

	// RVA: 0xDAD6A8
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> right) { }

	// RVA: 0xDAD824
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_UnmanagedTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAD8D8
	public void .ctor() { }

	// RVA: 0xDAD8E0
	public bool Equals(UnmanagedType left, UnmanagedType right) { }

	// RVA: 0xDAD968
	public int GetHashCode(UnmanagedType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_UnmanagedTypeEqualityComparer
{
	// Methods

	// RVA: 0xDAD990
	public void .ctor() { }

	// RVA: 0xDAD998
	public bool Equals(System.Nullable<System.Runtime.InteropServices.UnmanagedType> left, System.Nullable<System.Runtime.InteropServices.UnmanagedType> right) { }

	// RVA: 0xDADB14
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.UnmanagedType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_VarEnumEqualityComparer
{
	// Methods

	// RVA: 0xDADBC8
	public void .ctor() { }

	// RVA: 0xDADBD0
	public bool Equals(VarEnum left, VarEnum right) { }

	// RVA: 0xDADC58
	public int GetHashCode(VarEnum obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_VarEnumEqualityComparer
{
	// Methods

	// RVA: 0xDADC80
	public void .ctor() { }

	// RVA: 0xDADC88
	public bool Equals(System.Nullable<System.Runtime.InteropServices.VarEnum> left, System.Nullable<System.Runtime.InteropServices.VarEnum> right) { }

	// RVA: 0xDADE04
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.VarEnum> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_CustomErrorsModesEqualityComparer
{
	// Methods

	// RVA: 0xDADEB8
	public void .ctor() { }

	// RVA: 0xDADEC0
	public bool Equals(CustomErrorsModes left, CustomErrorsModes right) { }

	// RVA: 0xDADF48
	public int GetHashCode(CustomErrorsModes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_CustomErrorsModesEqualityComparer
{
	// Methods

	// RVA: 0xDADF70
	public void .ctor() { }

	// RVA: 0xDADF78
	public bool Equals(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> left, System.Nullable<System.Runtime.Remoting.CustomErrorsModes> right) { }

	// RVA: 0xDAE0F4
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_WellKnownObjectModeEqualityComparer
{
	// Methods

	// RVA: 0xDAE1A8
	public void .ctor() { }

	// RVA: 0xDAE1B0
	public bool Equals(WellKnownObjectMode left, WellKnownObjectMode right) { }

	// RVA: 0xDAE238
	public int GetHashCode(WellKnownObjectMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_WellKnownObjectModeEqualityComparer
{
	// Methods

	// RVA: 0xDAE260
	public void .ctor() { }

	// RVA: 0xDAE268
	public bool Equals(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> left, System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> right) { }

	// RVA: 0xDAE3E4
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer
{
	// Methods

	// RVA: 0xDAE498
	public void .ctor() { }

	// RVA: 0xDAE4A0
	public bool Equals(ActivatorLevel left, ActivatorLevel right) { }

	// RVA: 0xDAE528
	public int GetHashCode(ActivatorLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer
{
	// Methods

	// RVA: 0xDAE550
	public void .ctor() { }

	// RVA: 0xDAE558
	public bool Equals(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> left, System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> right) { }

	// RVA: 0xDAE6D4
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Channels_ServerProcessingEqualityComparer
{
	// Methods

	// RVA: 0xDAE788
	public void .ctor() { }

	// RVA: 0xDAE790
	public bool Equals(ServerProcessing left, ServerProcessing right) { }

	// RVA: 0xDAE818
	public int GetHashCode(ServerProcessing obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Channels_ServerProcessingEqualityComparer
{
	// Methods

	// RVA: 0xDAE840
	public void .ctor() { }

	// RVA: 0xDAE848
	public bool Equals(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> left, System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> right) { }

	// RVA: 0xDAE9C4
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer
{
	// Methods

	// RVA: 0xDAEA78
	public void .ctor() { }

	// RVA: 0xDAEA80
	public bool Equals(LeaseState left, LeaseState right) { }

	// RVA: 0xDAEB08
	public int GetHashCode(LeaseState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer
{
	// Methods

	// RVA: 0xDAEB30
	public void .ctor() { }

	// RVA: 0xDAEB38
	public bool Equals(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> left, System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> right) { }

	// RVA: 0xDAECB4
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_SoapOptionEqualityComparer
{
	// Methods

	// RVA: 0xDAED68
	public void .ctor() { }

	// RVA: 0xDAED70
	public bool Equals(SoapOption left, SoapOption right) { }

	// RVA: 0xDAEDF8
	public int GetHashCode(SoapOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_SoapOptionEqualityComparer
{
	// Methods

	// RVA: 0xDAEE20
	public void .ctor() { }

	// RVA: 0xDAEE28
	public bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> left, System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> right) { }

	// RVA: 0xDAEFA4
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer
{
	// Methods

	// RVA: 0xDAF058
	public void .ctor() { }

	// RVA: 0xDAF060
	public bool Equals(XmlFieldOrderOption left, XmlFieldOrderOption right) { }

	// RVA: 0xDAF0E8
	public int GetHashCode(XmlFieldOrderOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer
{
	// Methods

	// RVA: 0xDAF110
	public void .ctor() { }

	// RVA: 0xDAF118
	public bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> left, System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> right) { }

	// RVA: 0xDAF294
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_SerializationEntryEqualityComparer
{
	// Methods

	// RVA: 0xDAF348
	public void .ctor() { }

	// RVA: 0xDAF350
	public bool Equals(SerializationEntry left, SerializationEntry right) { }

	// RVA: 0xDAF3F0
	public int GetHashCode(SerializationEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_SerializationEntryEqualityComparer
{
	// Methods

	// RVA: 0xDAF46C
	public void .ctor() { }

	// RVA: 0xDAF474
	public bool Equals(System.Nullable<System.Runtime.Serialization.SerializationEntry> left, System.Nullable<System.Runtime.Serialization.SerializationEntry> right) { }

	// RVA: 0xDAF628
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.SerializationEntry> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextEqualityComparer
{
	// Methods

	// RVA: 0xDAF6D8
	public void .ctor() { }

	// RVA: 0xDAF6E0
	public bool Equals(StreamingContext left, StreamingContext right) { }

	// RVA: 0xDAF75C
	public int GetHashCode(StreamingContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextEqualityComparer
{
	// Methods

	// RVA: 0xDAF764
	public void .ctor() { }

	// RVA: 0xDAF76C
	public bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContext> left, System.Nullable<System.Runtime.Serialization.StreamingContext> right) { }

	// RVA: 0xDAF8F4
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextStatesEqualityComparer
{
	// Methods

	// RVA: 0xDAF9A4
	public void .ctor() { }

	// RVA: 0xDAF9AC
	public bool Equals(StreamingContextStates left, StreamingContextStates right) { }

	// RVA: 0xDAFA34
	public int GetHashCode(StreamingContextStates obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextStatesEqualityComparer
{
	// Methods

	// RVA: 0xDAFA5C
	public void .ctor() { }

	// RVA: 0xDAFA64
	public bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContextStates> left, System.Nullable<System.Runtime.Serialization.StreamingContextStates> right) { }

	// RVA: 0xDAFBE0
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContextStates> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer
{
	// Methods

	// RVA: 0xDAFC94
	public void .ctor() { }

	// RVA: 0xDAFC9C
	public bool Equals(FormatterAssemblyStyle left, FormatterAssemblyStyle right) { }

	// RVA: 0xDAFD24
	public int GetHashCode(FormatterAssemblyStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer
{
	// Methods

	// RVA: 0xDAFD4C
	public void .ctor() { }

	// RVA: 0xDAFD54
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> right) { }

	// RVA: 0xDAFED0
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer
{
	// Methods

	// RVA: 0xDAFF84
	public void .ctor() { }

	// RVA: 0xDAFF8C
	public bool Equals(FormatterTypeStyle left, FormatterTypeStyle right) { }

	// RVA: 0xDB0014
	public int GetHashCode(FormatterTypeStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer
{
	// Methods

	// RVA: 0xDB003C
	public void .ctor() { }

	// RVA: 0xDB0044
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> right) { }

	// RVA: 0xDB01C0
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer
{
	// Methods

	// RVA: 0xDB0274
	public void .ctor() { }

	// RVA: 0xDB027C
	public bool Equals(TypeFilterLevel left, TypeFilterLevel right) { }

	// RVA: 0xDB0304
	public int GetHashCode(TypeFilterLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer
{
	// Methods

	// RVA: 0xDB032C
	public void .ctor() { }

	// RVA: 0xDB0334
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> left, System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> right) { }

	// RVA: 0xDB04B0
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Versioning_ResourceScopeEqualityComparer
{
	// Methods

	// RVA: 0xDB0564
	public void .ctor() { }

	// RVA: 0xDB056C
	public bool Equals(ResourceScope left, ResourceScope right) { }

	// RVA: 0xDB05F4
	public int GetHashCode(ResourceScope obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Versioning_ResourceScopeEqualityComparer
{
	// Methods

	// RVA: 0xDB061C
	public void .ctor() { }

	// RVA: 0xDB0624
	public bool Equals(System.Nullable<System.Runtime.Versioning.ResourceScope> left, System.Nullable<System.Runtime.Versioning.ResourceScope> right) { }

	// RVA: 0xDB07A0
	public int GetHashCode(System.Nullable<System.Runtime.Versioning.ResourceScope> obj) { }

}

// Namespace: 
private sealed class System_Security_HostSecurityManagerOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDB0854
	public void .ctor() { }

	// RVA: 0xDB085C
	public bool Equals(HostSecurityManagerOptions left, HostSecurityManagerOptions right) { }

	// RVA: 0xDB08E4
	public int GetHashCode(HostSecurityManagerOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_HostSecurityManagerOptionsEqualityComparer
{
	// Methods

	// RVA: 0xDB090C
	public void .ctor() { }

	// RVA: 0xDB0914
	public bool Equals(System.Nullable<System.Security.HostSecurityManagerOptions> left, System.Nullable<System.Security.HostSecurityManagerOptions> right) { }

	// RVA: 0xDB0A90
	public int GetHashCode(System.Nullable<System.Security.HostSecurityManagerOptions> obj) { }

}

// Namespace: 
private sealed class System_Security_PolicyLevelTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB0B44
	public void .ctor() { }

	// RVA: 0xDB0B4C
	public bool Equals(PolicyLevelType left, PolicyLevelType right) { }

	// RVA: 0xDB0BD4
	public int GetHashCode(PolicyLevelType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_PolicyLevelTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB0BFC
	public void .ctor() { }

	// RVA: 0xDB0C04
	public bool Equals(System.Nullable<System.Security.PolicyLevelType> left, System.Nullable<System.Security.PolicyLevelType> right) { }

	// RVA: 0xDB0D80
	public int GetHashCode(System.Nullable<System.Security.PolicyLevelType> obj) { }

}

// Namespace: 
private sealed class System_Security_SecurityZoneEqualityComparer
{
	// Methods

	// RVA: 0xDB0E34
	public void .ctor() { }

	// RVA: 0xDB0E3C
	public bool Equals(SecurityZone left, SecurityZone right) { }

	// RVA: 0xDB0EC4
	public int GetHashCode(SecurityZone obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_SecurityZoneEqualityComparer
{
	// Methods

	// RVA: 0xDB0EEC
	public void .ctor() { }

	// RVA: 0xDB0EF4
	public bool Equals(System.Nullable<System.Security.SecurityZone> left, System.Nullable<System.Security.SecurityZone> right) { }

	// RVA: 0xDB1070
	public int GetHashCode(System.Nullable<System.Security.SecurityZone> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlActionsEqualityComparer
{
	// Methods

	// RVA: 0xDB1124
	public void .ctor() { }

	// RVA: 0xDB112C
	public bool Equals(AccessControlActions left, AccessControlActions right) { }

	// RVA: 0xDB11B4
	public int GetHashCode(AccessControlActions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlActionsEqualityComparer
{
	// Methods

	// RVA: 0xDB11DC
	public void .ctor() { }

	// RVA: 0xDB11E4
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlActions> left, System.Nullable<System.Security.AccessControl.AccessControlActions> right) { }

	// RVA: 0xDB1360
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlActions> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlModificationEqualityComparer
{
	// Methods

	// RVA: 0xDB1414
	public void .ctor() { }

	// RVA: 0xDB141C
	public bool Equals(AccessControlModification left, AccessControlModification right) { }

	// RVA: 0xDB14A4
	public int GetHashCode(AccessControlModification obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlModificationEqualityComparer
{
	// Methods

	// RVA: 0xDB14CC
	public void .ctor() { }

	// RVA: 0xDB14D4
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlModification> left, System.Nullable<System.Security.AccessControl.AccessControlModification> right) { }

	// RVA: 0xDB1650
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlModification> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlSectionsEqualityComparer
{
	// Methods

	// RVA: 0xDB1704
	public void .ctor() { }

	// RVA: 0xDB170C
	public bool Equals(AccessControlSections left, AccessControlSections right) { }

	// RVA: 0xDB1794
	public int GetHashCode(AccessControlSections obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlSectionsEqualityComparer
{
	// Methods

	// RVA: 0xDB17BC
	public void .ctor() { }

	// RVA: 0xDB17C4
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlSections> left, System.Nullable<System.Security.AccessControl.AccessControlSections> right) { }

	// RVA: 0xDB1940
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlSections> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB19F4
	public void .ctor() { }

	// RVA: 0xDB19FC
	public bool Equals(AccessControlType left, AccessControlType right) { }

	// RVA: 0xDB1A84
	public int GetHashCode(AccessControlType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB1AAC
	public void .ctor() { }

	// RVA: 0xDB1AB4
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlType> left, System.Nullable<System.Security.AccessControl.AccessControlType> right) { }

	// RVA: 0xDB1C30
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB1CE4
	public void .ctor() { }

	// RVA: 0xDB1CEC
	public bool Equals(AceFlags left, AceFlags right) { }

	// RVA: 0xDB1D74
	public int GetHashCode(AceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB1D9C
	public void .ctor() { }

	// RVA: 0xDB1DA4
	public bool Equals(System.Nullable<System.Security.AccessControl.AceFlags> left, System.Nullable<System.Security.AccessControl.AceFlags> right) { }

	// RVA: 0xDB1F20
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceQualifierEqualityComparer
{
	// Methods

	// RVA: 0xDB1FD4
	public void .ctor() { }

	// RVA: 0xDB1FDC
	public bool Equals(AceQualifier left, AceQualifier right) { }

	// RVA: 0xDB2064
	public int GetHashCode(AceQualifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceQualifierEqualityComparer
{
	// Methods

	// RVA: 0xDB208C
	public void .ctor() { }

	// RVA: 0xDB2094
	public bool Equals(System.Nullable<System.Security.AccessControl.AceQualifier> left, System.Nullable<System.Security.AccessControl.AceQualifier> right) { }

	// RVA: 0xDB2210
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceQualifier> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB22C4
	public void .ctor() { }

	// RVA: 0xDB22CC
	public bool Equals(AceType left, AceType right) { }

	// RVA: 0xDB2354
	public int GetHashCode(AceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB237C
	public void .ctor() { }

	// RVA: 0xDB2384
	public bool Equals(System.Nullable<System.Security.AccessControl.AceType> left, System.Nullable<System.Security.AccessControl.AceType> right) { }

	// RVA: 0xDB2500
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AuditFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB25B4
	public void .ctor() { }

	// RVA: 0xDB25BC
	public bool Equals(AuditFlags left, AuditFlags right) { }

	// RVA: 0xDB2644
	public int GetHashCode(AuditFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AuditFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB266C
	public void .ctor() { }

	// RVA: 0xDB2674
	public bool Equals(System.Nullable<System.Security.AccessControl.AuditFlags> left, System.Nullable<System.Security.AccessControl.AuditFlags> right) { }

	// RVA: 0xDB27F0
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AuditFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CompoundAceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB28A4
	public void .ctor() { }

	// RVA: 0xDB28AC
	public bool Equals(CompoundAceType left, CompoundAceType right) { }

	// RVA: 0xDB2934
	public int GetHashCode(CompoundAceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CompoundAceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB295C
	public void .ctor() { }

	// RVA: 0xDB2964
	public bool Equals(System.Nullable<System.Security.AccessControl.CompoundAceType> left, System.Nullable<System.Security.AccessControl.CompoundAceType> right) { }

	// RVA: 0xDB2AE0
	public int GetHashCode(System.Nullable<System.Security.AccessControl.CompoundAceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ControlFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB2B94
	public void .ctor() { }

	// RVA: 0xDB2B9C
	public bool Equals(ControlFlags left, ControlFlags right) { }

	// RVA: 0xDB2C24
	public int GetHashCode(ControlFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ControlFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB2C4C
	public void .ctor() { }

	// RVA: 0xDB2C54
	public bool Equals(System.Nullable<System.Security.AccessControl.ControlFlags> left, System.Nullable<System.Security.AccessControl.ControlFlags> right) { }

	// RVA: 0xDB2DD0
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ControlFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CryptoKeyRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB2E84
	public void .ctor() { }

	// RVA: 0xDB2E8C
	public bool Equals(CryptoKeyRights left, CryptoKeyRights right) { }

	// RVA: 0xDB2F14
	public int GetHashCode(CryptoKeyRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CryptoKeyRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB2F3C
	public void .ctor() { }

	// RVA: 0xDB2F44
	public bool Equals(System.Nullable<System.Security.AccessControl.CryptoKeyRights> left, System.Nullable<System.Security.AccessControl.CryptoKeyRights> right) { }

	// RVA: 0xDB30C0
	public int GetHashCode(System.Nullable<System.Security.AccessControl.CryptoKeyRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_EventWaitHandleRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB3174
	public void .ctor() { }

	// RVA: 0xDB317C
	public bool Equals(EventWaitHandleRights left, EventWaitHandleRights right) { }

	// RVA: 0xDB3204
	public int GetHashCode(EventWaitHandleRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_EventWaitHandleRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB322C
	public void .ctor() { }

	// RVA: 0xDB3234
	public bool Equals(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> left, System.Nullable<System.Security.AccessControl.EventWaitHandleRights> right) { }

	// RVA: 0xDB33B0
	public int GetHashCode(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_FileSystemRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB3464
	public void .ctor() { }

	// RVA: 0xDB346C
	public bool Equals(FileSystemRights left, FileSystemRights right) { }

	// RVA: 0xDB34F4
	public int GetHashCode(FileSystemRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_FileSystemRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB351C
	public void .ctor() { }

	// RVA: 0xDB3524
	public bool Equals(System.Nullable<System.Security.AccessControl.FileSystemRights> left, System.Nullable<System.Security.AccessControl.FileSystemRights> right) { }

	// RVA: 0xDB36A0
	public int GetHashCode(System.Nullable<System.Security.AccessControl.FileSystemRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_InheritanceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB3754
	public void .ctor() { }

	// RVA: 0xDB375C
	public bool Equals(InheritanceFlags left, InheritanceFlags right) { }

	// RVA: 0xDB37E4
	public int GetHashCode(InheritanceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_InheritanceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB380C
	public void .ctor() { }

	// RVA: 0xDB3814
	public bool Equals(System.Nullable<System.Security.AccessControl.InheritanceFlags> left, System.Nullable<System.Security.AccessControl.InheritanceFlags> right) { }

	// RVA: 0xDB3990
	public int GetHashCode(System.Nullable<System.Security.AccessControl.InheritanceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_MutexRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB3A44
	public void .ctor() { }

	// RVA: 0xDB3A4C
	public bool Equals(MutexRights left, MutexRights right) { }

	// RVA: 0xDB3AD4
	public int GetHashCode(MutexRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_MutexRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB3AFC
	public void .ctor() { }

	// RVA: 0xDB3B04
	public bool Equals(System.Nullable<System.Security.AccessControl.MutexRights> left, System.Nullable<System.Security.AccessControl.MutexRights> right) { }

	// RVA: 0xDB3C80
	public int GetHashCode(System.Nullable<System.Security.AccessControl.MutexRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ObjectAceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB3D34
	public void .ctor() { }

	// RVA: 0xDB3D3C
	public bool Equals(ObjectAceFlags left, ObjectAceFlags right) { }

	// RVA: 0xDB3DC4
	public int GetHashCode(ObjectAceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ObjectAceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB3DEC
	public void .ctor() { }

	// RVA: 0xDB3DF4
	public bool Equals(System.Nullable<System.Security.AccessControl.ObjectAceFlags> left, System.Nullable<System.Security.AccessControl.ObjectAceFlags> right) { }

	// RVA: 0xDB3F70
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ObjectAceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_PropagationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB4024
	public void .ctor() { }

	// RVA: 0xDB402C
	public bool Equals(PropagationFlags left, PropagationFlags right) { }

	// RVA: 0xDB40B4
	public int GetHashCode(PropagationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_PropagationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB40DC
	public void .ctor() { }

	// RVA: 0xDB40E4
	public bool Equals(System.Nullable<System.Security.AccessControl.PropagationFlags> left, System.Nullable<System.Security.AccessControl.PropagationFlags> right) { }

	// RVA: 0xDB4260
	public int GetHashCode(System.Nullable<System.Security.AccessControl.PropagationFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_RegistryRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB4314
	public void .ctor() { }

	// RVA: 0xDB431C
	public bool Equals(RegistryRights left, RegistryRights right) { }

	// RVA: 0xDB43A4
	public int GetHashCode(RegistryRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_RegistryRightsEqualityComparer
{
	// Methods

	// RVA: 0xDB43CC
	public void .ctor() { }

	// RVA: 0xDB43D4
	public bool Equals(System.Nullable<System.Security.AccessControl.RegistryRights> left, System.Nullable<System.Security.AccessControl.RegistryRights> right) { }

	// RVA: 0xDB4550
	public int GetHashCode(System.Nullable<System.Security.AccessControl.RegistryRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ResourceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB4604
	public void .ctor() { }

	// RVA: 0xDB460C
	public bool Equals(ResourceType left, ResourceType right) { }

	// RVA: 0xDB4694
	public int GetHashCode(ResourceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ResourceTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB46BC
	public void .ctor() { }

	// RVA: 0xDB46C4
	public bool Equals(System.Nullable<System.Security.AccessControl.ResourceType> left, System.Nullable<System.Security.AccessControl.ResourceType> right) { }

	// RVA: 0xDB4840
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ResourceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_SecurityInfosEqualityComparer
{
	// Methods

	// RVA: 0xDB48F4
	public void .ctor() { }

	// RVA: 0xDB48FC
	public bool Equals(SecurityInfos left, SecurityInfos right) { }

	// RVA: 0xDB4984
	public int GetHashCode(SecurityInfos obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_SecurityInfosEqualityComparer
{
	// Methods

	// RVA: 0xDB49AC
	public void .ctor() { }

	// RVA: 0xDB49B4
	public bool Equals(System.Nullable<System.Security.AccessControl.SecurityInfos> left, System.Nullable<System.Security.AccessControl.SecurityInfos> right) { }

	// RVA: 0xDB4B30
	public int GetHashCode(System.Nullable<System.Security.AccessControl.SecurityInfos> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CipherModeEqualityComparer
{
	// Methods

	// RVA: 0xDB4BE4
	public void .ctor() { }

	// RVA: 0xDB4BEC
	public bool Equals(CipherMode left, CipherMode right) { }

	// RVA: 0xDB4C74
	public int GetHashCode(CipherMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CipherModeEqualityComparer
{
	// Methods

	// RVA: 0xDB4C9C
	public void .ctor() { }

	// RVA: 0xDB4CA4
	public bool Equals(System.Nullable<System.Security.Cryptography.CipherMode> left, System.Nullable<System.Security.Cryptography.CipherMode> right) { }

	// RVA: 0xDB4E20
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CipherMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CryptoStreamModeEqualityComparer
{
	// Methods

	// RVA: 0xDB4ED4
	public void .ctor() { }

	// RVA: 0xDB4EDC
	public bool Equals(CryptoStreamMode left, CryptoStreamMode right) { }

	// RVA: 0xDB4F64
	public int GetHashCode(CryptoStreamMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CryptoStreamModeEqualityComparer
{
	// Methods

	// RVA: 0xDB4F8C
	public void .ctor() { }

	// RVA: 0xDB4F94
	public bool Equals(System.Nullable<System.Security.Cryptography.CryptoStreamMode> left, System.Nullable<System.Security.Cryptography.CryptoStreamMode> right) { }

	// RVA: 0xDB5110
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CryptoStreamMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CspProviderFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB51C4
	public void .ctor() { }

	// RVA: 0xDB51CC
	public bool Equals(CspProviderFlags left, CspProviderFlags right) { }

	// RVA: 0xDB5254
	public int GetHashCode(CspProviderFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CspProviderFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB527C
	public void .ctor() { }

	// RVA: 0xDB5284
	public bool Equals(System.Nullable<System.Security.Cryptography.CspProviderFlags> left, System.Nullable<System.Security.Cryptography.CspProviderFlags> right) { }

	// RVA: 0xDB5400
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CspProviderFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_DSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xDB54B4
	public void .ctor() { }

	// RVA: 0xDB54BC
	public bool Equals(DSAParameters left, DSAParameters right) { }

	// RVA: 0xDB555C
	public int GetHashCode(DSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_DSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xDB55D8
	public void .ctor() { }

	// RVA: 0xDB55E0
	public bool Equals(System.Nullable<System.Security.Cryptography.DSAParameters> left, System.Nullable<System.Security.Cryptography.DSAParameters> right) { }

	// RVA: 0xDB57A4
	public int GetHashCode(System.Nullable<System.Security.Cryptography.DSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_FromBase64TransformModeEqualityComparer
{
	// Methods

	// RVA: 0xDB5854
	public void .ctor() { }

	// RVA: 0xDB585C
	public bool Equals(FromBase64TransformMode left, FromBase64TransformMode right) { }

	// RVA: 0xDB58E4
	public int GetHashCode(FromBase64TransformMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_FromBase64TransformModeEqualityComparer
{
	// Methods

	// RVA: 0xDB590C
	public void .ctor() { }

	// RVA: 0xDB5914
	public bool Equals(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> left, System.Nullable<System.Security.Cryptography.FromBase64TransformMode> right) { }

	// RVA: 0xDB5A90
	public int GetHashCode(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_KeyNumberEqualityComparer
{
	// Methods

	// RVA: 0xDB5B44
	public void .ctor() { }

	// RVA: 0xDB5B4C
	public bool Equals(KeyNumber left, KeyNumber right) { }

	// RVA: 0xDB5BD4
	public int GetHashCode(KeyNumber obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_KeyNumberEqualityComparer
{
	// Methods

	// RVA: 0xDB5BFC
	public void .ctor() { }

	// RVA: 0xDB5C04
	public bool Equals(System.Nullable<System.Security.Cryptography.KeyNumber> left, System.Nullable<System.Security.Cryptography.KeyNumber> right) { }

	// RVA: 0xDB5D80
	public int GetHashCode(System.Nullable<System.Security.Cryptography.KeyNumber> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_PaddingModeEqualityComparer
{
	// Methods

	// RVA: 0xDB5E34
	public void .ctor() { }

	// RVA: 0xDB5E3C
	public bool Equals(PaddingMode left, PaddingMode right) { }

	// RVA: 0xDB5EC4
	public int GetHashCode(PaddingMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_PaddingModeEqualityComparer
{
	// Methods

	// RVA: 0xDB5EEC
	public void .ctor() { }

	// RVA: 0xDB5EF4
	public bool Equals(System.Nullable<System.Security.Cryptography.PaddingMode> left, System.Nullable<System.Security.Cryptography.PaddingMode> right) { }

	// RVA: 0xDB6070
	public int GetHashCode(System.Nullable<System.Security.Cryptography.PaddingMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_RSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xDB6124
	public void .ctor() { }

	// RVA: 0xDB612C
	public bool Equals(RSAParameters left, RSAParameters right) { }

	// RVA: 0xDB61CC
	public int GetHashCode(RSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_RSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xDB6248
	public void .ctor() { }

	// RVA: 0xDB6250
	public bool Equals(System.Nullable<System.Security.Cryptography.RSAParameters> left, System.Nullable<System.Security.Cryptography.RSAParameters> right) { }

	// RVA: 0xDB6414
	public int GetHashCode(System.Nullable<System.Security.Cryptography.RSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB64C4
	public void .ctor() { }

	// RVA: 0xDB64CC
	public bool Equals(X509ContentType left, X509ContentType right) { }

	// RVA: 0xDB6554
	public int GetHashCode(X509ContentType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB657C
	public void .ctor() { }

	// RVA: 0xDB6584
	public bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> right) { }

	// RVA: 0xDB6700
	public int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB67B4
	public void .ctor() { }

	// RVA: 0xDB67BC
	public bool Equals(X509KeyStorageFlags left, X509KeyStorageFlags right) { }

	// RVA: 0xDB6844
	public int GetHashCode(X509KeyStorageFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer
{
	// Methods

	// RVA: 0xDB686C
	public void .ctor() { }

	// RVA: 0xDB6874
	public bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> right) { }

	// RVA: 0xDB69F0
	public int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_ApplicationVersionMatchEqualityComparer
{
	// Methods

	// RVA: 0xDB6AA4
	public void .ctor() { }

	// RVA: 0xDB6AAC
	public bool Equals(ApplicationVersionMatch left, ApplicationVersionMatch right) { }

	// RVA: 0xDB6B34
	public int GetHashCode(ApplicationVersionMatch obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_ApplicationVersionMatchEqualityComparer
{
	// Methods

	// RVA: 0xDB6B5C
	public void .ctor() { }

	// RVA: 0xDB6B64
	public bool Equals(System.Nullable<System.Security.Policy.ApplicationVersionMatch> left, System.Nullable<System.Security.Policy.ApplicationVersionMatch> right) { }

	// RVA: 0xDB6CE0
	public int GetHashCode(System.Nullable<System.Security.Policy.ApplicationVersionMatch> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_PolicyStatementAttributeEqualityComparer
{
	// Methods

	// RVA: 0xDB6D94
	public void .ctor() { }

	// RVA: 0xDB6D9C
	public bool Equals(PolicyStatementAttribute left, PolicyStatementAttribute right) { }

	// RVA: 0xDB6E24
	public int GetHashCode(PolicyStatementAttribute obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_PolicyStatementAttributeEqualityComparer
{
	// Methods

	// RVA: 0xDB6E4C
	public void .ctor() { }

	// RVA: 0xDB6E54
	public bool Equals(System.Nullable<System.Security.Policy.PolicyStatementAttribute> left, System.Nullable<System.Security.Policy.PolicyStatementAttribute> right) { }

	// RVA: 0xDB6FD0
	public int GetHashCode(System.Nullable<System.Security.Policy.PolicyStatementAttribute> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_TrustManagerUIContextEqualityComparer
{
	// Methods

	// RVA: 0xDB7084
	public void .ctor() { }

	// RVA: 0xDB708C
	public bool Equals(TrustManagerUIContext left, TrustManagerUIContext right) { }

	// RVA: 0xDB7114
	public int GetHashCode(TrustManagerUIContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_TrustManagerUIContextEqualityComparer
{
	// Methods

	// RVA: 0xDB713C
	public void .ctor() { }

	// RVA: 0xDB7144
	public bool Equals(System.Nullable<System.Security.Policy.TrustManagerUIContext> left, System.Nullable<System.Security.Policy.TrustManagerUIContext> right) { }

	// RVA: 0xDB72C0
	public int GetHashCode(System.Nullable<System.Security.Policy.TrustManagerUIContext> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_PrincipalPolicyEqualityComparer
{
	// Methods

	// RVA: 0xDB7374
	public void .ctor() { }

	// RVA: 0xDB737C
	public bool Equals(PrincipalPolicy left, PrincipalPolicy right) { }

	// RVA: 0xDB7404
	public int GetHashCode(PrincipalPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_PrincipalPolicyEqualityComparer
{
	// Methods

	// RVA: 0xDB742C
	public void .ctor() { }

	// RVA: 0xDB7434
	public bool Equals(System.Nullable<System.Security.Principal.PrincipalPolicy> left, System.Nullable<System.Security.Principal.PrincipalPolicy> right) { }

	// RVA: 0xDB75B0
	public int GetHashCode(System.Nullable<System.Security.Principal.PrincipalPolicy> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenAccessLevelsEqualityComparer
{
	// Methods

	// RVA: 0xDB7664
	public void .ctor() { }

	// RVA: 0xDB766C
	public bool Equals(TokenAccessLevels left, TokenAccessLevels right) { }

	// RVA: 0xDB76F4
	public int GetHashCode(TokenAccessLevels obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenAccessLevelsEqualityComparer
{
	// Methods

	// RVA: 0xDB771C
	public void .ctor() { }

	// RVA: 0xDB7724
	public bool Equals(System.Nullable<System.Security.Principal.TokenAccessLevels> left, System.Nullable<System.Security.Principal.TokenAccessLevels> right) { }

	// RVA: 0xDB78A0
	public int GetHashCode(System.Nullable<System.Security.Principal.TokenAccessLevels> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenImpersonationLevelEqualityComparer
{
	// Methods

	// RVA: 0xDB7954
	public void .ctor() { }

	// RVA: 0xDB795C
	public bool Equals(TokenImpersonationLevel left, TokenImpersonationLevel right) { }

	// RVA: 0xDB79E4
	public int GetHashCode(TokenImpersonationLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenImpersonationLevelEqualityComparer
{
	// Methods

	// RVA: 0xDB7A0C
	public void .ctor() { }

	// RVA: 0xDB7A14
	public bool Equals(System.Nullable<System.Security.Principal.TokenImpersonationLevel> left, System.Nullable<System.Security.Principal.TokenImpersonationLevel> right) { }

	// RVA: 0xDB7B90
	public int GetHashCode(System.Nullable<System.Security.Principal.TokenImpersonationLevel> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WellKnownSidTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB7C44
	public void .ctor() { }

	// RVA: 0xDB7C4C
	public bool Equals(WellKnownSidType left, WellKnownSidType right) { }

	// RVA: 0xDB7CD4
	public int GetHashCode(WellKnownSidType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WellKnownSidTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB7CFC
	public void .ctor() { }

	// RVA: 0xDB7D04
	public bool Equals(System.Nullable<System.Security.Principal.WellKnownSidType> left, System.Nullable<System.Security.Principal.WellKnownSidType> right) { }

	// RVA: 0xDB7E80
	public int GetHashCode(System.Nullable<System.Security.Principal.WellKnownSidType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsAccountTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB7F34
	public void .ctor() { }

	// RVA: 0xDB7F3C
	public bool Equals(WindowsAccountType left, WindowsAccountType right) { }

	// RVA: 0xDB7FC4
	public int GetHashCode(WindowsAccountType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsAccountTypeEqualityComparer
{
	// Methods

	// RVA: 0xDB7FEC
	public void .ctor() { }

	// RVA: 0xDB7FF4
	public bool Equals(System.Nullable<System.Security.Principal.WindowsAccountType> left, System.Nullable<System.Security.Principal.WindowsAccountType> right) { }

	// RVA: 0xDB8170
	public int GetHashCode(System.Nullable<System.Security.Principal.WindowsAccountType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsBuiltInRoleEqualityComparer
{
	// Methods

	// RVA: 0xDB8224
	public void .ctor() { }

	// RVA: 0xDB822C
	public bool Equals(WindowsBuiltInRole left, WindowsBuiltInRole right) { }

	// RVA: 0xDB82B4
	public int GetHashCode(WindowsBuiltInRole obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsBuiltInRoleEqualityComparer
{
	// Methods

	// RVA: 0xDB82DC
	public void .ctor() { }

	// RVA: 0xDB82E4
	public bool Equals(System.Nullable<System.Security.Principal.WindowsBuiltInRole> left, System.Nullable<System.Security.Principal.WindowsBuiltInRole> right) { }

	// RVA: 0xDB8460
	public int GetHashCode(System.Nullable<System.Security.Principal.WindowsBuiltInRole> obj) { }

}

// Namespace: 
private sealed class System_Text_NormalizationFormEqualityComparer
{
	// Methods

	// RVA: 0xDB8514
	public void .ctor() { }

	// RVA: 0xDB851C
	public bool Equals(NormalizationForm left, NormalizationForm right) { }

	// RVA: 0xDB85A4
	public int GetHashCode(NormalizationForm obj) { }

}

// Namespace: 
private sealed class NullableSystem_Text_NormalizationFormEqualityComparer
{
	// Methods

	// RVA: 0xDB85CC
	public void .ctor() { }

	// RVA: 0xDB85D4
	public bool Equals(System.Nullable<System.Text.NormalizationForm> left, System.Nullable<System.Text.NormalizationForm> right) { }

	// RVA: 0xDB8750
	public int GetHashCode(System.Nullable<System.Text.NormalizationForm> obj) { }

}

// Namespace: 
private sealed class System_Threading_ApartmentStateEqualityComparer
{
	// Methods

	// RVA: 0xDB8804
	public void .ctor() { }

	// RVA: 0xDB880C
	public bool Equals(ApartmentState left, ApartmentState right) { }

	// RVA: 0xDB8894
	public int GetHashCode(ApartmentState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ApartmentStateEqualityComparer
{
	// Methods

	// RVA: 0xDB88BC
	public void .ctor() { }

	// RVA: 0xDB88C4
	public bool Equals(System.Nullable<System.Threading.ApartmentState> left, System.Nullable<System.Threading.ApartmentState> right) { }

	// RVA: 0xDB8A40
	public int GetHashCode(System.Nullable<System.Threading.ApartmentState> obj) { }

}

// Namespace: 
private sealed class System_Threading_AsyncFlowControlEqualityComparer
{
	// Methods

	// RVA: 0xDB8AF4
	public void .ctor() { }

	// RVA: 0xDB8AFC
	public bool Equals(AsyncFlowControl left, AsyncFlowControl right) { }

	// RVA: 0xDB8B34
	public int GetHashCode(AsyncFlowControl obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_AsyncFlowControlEqualityComparer
{
	// Methods

	// RVA: 0xDB8B40
	public void .ctor() { }

	// RVA: 0xDB8B48
	public bool Equals(System.Nullable<System.Threading.AsyncFlowControl> left, System.Nullable<System.Threading.AsyncFlowControl> right) { }

	// RVA: 0xDB8CC0
	public int GetHashCode(System.Nullable<System.Threading.AsyncFlowControl> obj) { }

}

// Namespace: 
private sealed class System_Threading_EventResetModeEqualityComparer
{
	// Methods

	// RVA: 0xDB8D70
	public void .ctor() { }

	// RVA: 0xDB8D78
	public bool Equals(EventResetMode left, EventResetMode right) { }

	// RVA: 0xDB8E00
	public int GetHashCode(EventResetMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_EventResetModeEqualityComparer
{
	// Methods

	// RVA: 0xDB8E28
	public void .ctor() { }

	// RVA: 0xDB8E30
	public bool Equals(System.Nullable<System.Threading.EventResetMode> left, System.Nullable<System.Threading.EventResetMode> right) { }

	// RVA: 0xDB8FAC
	public int GetHashCode(System.Nullable<System.Threading.EventResetMode> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockCookieEqualityComparer
{
	// Methods

	// RVA: 0xDB9060
	public void .ctor() { }

	// RVA: 0xDB9068
	public bool Equals(LockCookie left, LockCookie right) { }

	// RVA: 0xDB909C
	public int GetHashCode(LockCookie obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockCookieEqualityComparer
{
	// Methods

	// RVA: 0xDB90C8
	public void .ctor() { }

	// RVA: 0xDB90D0
	public bool Equals(System.Nullable<System.Threading.LockCookie> left, System.Nullable<System.Threading.LockCookie> right) { }

	// RVA: 0xDB922C
	public int GetHashCode(System.Nullable<System.Threading.LockCookie> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockRecursionPolicyEqualityComparer
{
	// Methods

	// RVA: 0xDB92E0
	public void .ctor() { }

	// RVA: 0xDB92E8
	public bool Equals(LockRecursionPolicy left, LockRecursionPolicy right) { }

	// RVA: 0xDB9370
	public int GetHashCode(LockRecursionPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockRecursionPolicyEqualityComparer
{
	// Methods

	// RVA: 0xDB9398
	public void .ctor() { }

	// RVA: 0xDB93A0
	public bool Equals(System.Nullable<System.Threading.LockRecursionPolicy> left, System.Nullable<System.Threading.LockRecursionPolicy> right) { }

	// RVA: 0xDB951C
	public int GetHashCode(System.Nullable<System.Threading.LockRecursionPolicy> obj) { }

}

// Namespace: 
private sealed class System_Threading_NativeOverlappedEqualityComparer
{
	// Methods

	// RVA: 0xDB95D0
	public void .ctor() { }

	// RVA: 0xDB95D8
	public bool Equals(NativeOverlapped left, NativeOverlapped right) { }

	// RVA: 0xDB9668
	public int GetHashCode(NativeOverlapped obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_NativeOverlappedEqualityComparer
{
	// Methods

	// RVA: 0xDB96DC
	public void .ctor() { }

	// RVA: 0xDB96E4
	public bool Equals(System.Nullable<System.Threading.NativeOverlapped> left, System.Nullable<System.Threading.NativeOverlapped> right) { }

	// RVA: 0xDB9880
	public int GetHashCode(System.Nullable<System.Threading.NativeOverlapped> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadPriorityEqualityComparer
{
	// Methods

	// RVA: 0xDB9930
	public void .ctor() { }

	// RVA: 0xDB9938
	public bool Equals(ThreadPriority left, ThreadPriority right) { }

	// RVA: 0xDB99C0
	public int GetHashCode(ThreadPriority obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadPriorityEqualityComparer
{
	// Methods

	// RVA: 0xDB99E8
	public void .ctor() { }

	// RVA: 0xDB99F0
	public bool Equals(System.Nullable<System.Threading.ThreadPriority> left, System.Nullable<System.Threading.ThreadPriority> right) { }

	// RVA: 0xDB9B6C
	public int GetHashCode(System.Nullable<System.Threading.ThreadPriority> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadStateEqualityComparer
{
	// Methods

	// RVA: 0xDB9C20
	public void .ctor() { }

	// RVA: 0xDB9C28
	public bool Equals(ThreadState left, ThreadState right) { }

	// RVA: 0xDB9CB0
	public int GetHashCode(ThreadState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadStateEqualityComparer
{
	// Methods

	// RVA: 0xDB9CD8
	public void .ctor() { }

	// RVA: 0xDB9CE0
	public bool Equals(System.Nullable<System.Threading.ThreadState> left, System.Nullable<System.Threading.ThreadState> right) { }

	// RVA: 0xDB9E5C
	public int GetHashCode(System.Nullable<System.Threading.ThreadState> obj) { }

}

// Namespace: MsgPack.Serialization
internal static class AotHelper
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> EqualityComparerTable; // 0x0

	// Methods

	// RVA: 0xD80188
	public static void HandleAotError(Type mayBeGenericArgument, Exception mayBeAotError) { }

	// RVA: 0xD8D5CC
	public static object CreateSystemCollectionsGenericDictionary(ConstructorInfo constructor, Type keyType, int initialCapacity) { }

	// RVA: 0xD8D1E4
	public static object GetEqualityComparer(Type type) { }

	// RVA: 0x352AE04
	public static void PrepareEqualityComparer() { }

	// RVA: 0xD8D74C
	private static System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeEqualityComparerTable() { }

	// RVA: 0xD987C0
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class EnumTypedMessagePackSerializerWrapper<T0>
{
	// Fields
	private readonly ICustomizableEnumSerializer _underlyingEnumSerializer; // 0x0

	// Methods

	// RVA: 0x35269D4
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

	// RVA: 0xDB9F10
	protected Type get_TargetType() { }

	// RVA: 0xDB9F18
	protected void .ctor(SerializationContext ownerContext, Type targetType, SerializerCapabilities capabilities) { }

	// RVA: 0xDB9FBC
	private void .ctor(SerializationContext ownerContext, Type targetType, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xDBA06C
	private static bool JudgeNullable(Type type) { }

	// RVA: 0xDBA230
	internal override void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: -1
	protected internal abstract void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDBA2B4
	internal override object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: -1
	protected internal abstract object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDBA3F8
	internal override void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xDBA514
	protected internal virtual void UnpackToCore(Unpacker unpacker, object collection) { }

}

// Namespace: MsgPack.Serialization
internal class TypedMessagePackSerializerWrapper<T0>
{
	// Fields
	private readonly MessagePackSerializer _underlyingSerializer; // 0x0
	private readonly ICollectionInstanceFactory _underlyingFactory; // 0x0

	// Methods

	// RVA: 0x35269D4
	public void .ctor(SerializationContext context, MessagePackSerializer underlying) { }

	// RVA: 0x26AD93C
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x26AD93C
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x26AD93C
	protected internal override T UnpackNil() { }

	// RVA: 0x26AD93C
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

	// RVA: 0xDBA7D0
	public void .ctor() { }

	// RVA: 0xDBAA78
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

	// RVA: 0xDBA54C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xDBA7D8
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDBA8FC
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDBAA34
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xDBAD3C
	public void .ctor() { }

	// RVA: 0xDBAFE4
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

	// RVA: 0xDBAAAC
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xDBAD44
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDBAE68
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDBAFA0
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xDBB320
	public void .ctor() { }

	// RVA: 0xDBB674
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xDBB6A8
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

	// RVA: 0xDBB018
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xDBB328
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDBB44C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDBB608
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xDBB64C
	protected override void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionEnumMessagePackSerializer
{
	// Methods

	// RVA: 0xDBB6DC
	public void .ctor(SerializationContext context, Type targetType) { }

	// RVA: 0xDBB730
	protected internal override void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xDBB8C4
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

	// RVA: 0xDBC0DC
	private static void .cctor() { }

	// RVA: 0xDBC148
	public void .ctor() { }

	// RVA: 0xDBC150
	internal bool <OnPackingMessagePackObject>b__2_0(object value) { }

	// RVA: 0xDBC1EC
	internal bool <OnPackingReferenceTypeObject>b__3_0(object value) { }

	// RVA: 0xDBC1F8
	internal bool <OnPackingNullableValueTypeObject>b__4_0(object value) { }

	// RVA: 0xDBC204
	internal void <OnNopOnUnpacked>b__6_0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public System.Func<System.Object,System.Boolean> condition; // 0x10
	public ReflectionSerializerNilImplicationHandlerParameter parameter; // 0x18

	// Methods

	// RVA: 0xDBC208
	public void .ctor() { }

	// RVA: 0xDBC210
	internal void <OnPackingCore>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xDBC270
	public void .ctor() { }

	// RVA: 0xDBC278
	internal void <OnThrowNullIsProhibitedExceptionOnUnpacked>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xDBC29C
	public void .ctor() { }

	// RVA: 0xDBC2A4
	internal void <OnThrowValueTypeCannotBeNull3OnUnpacked>b__0(object _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionNilImplicationHandler
{
	// Fields
	public static readonly ReflectionNilImplicationHandler Instance; // 0x0

	// Methods

	// RVA: 0xDBB96C
	private void .ctor() { }

	// RVA: 0xDBB9C0
	protected override System.Func<System.Object,System.Boolean> OnPackingMessagePackObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xDBBAC8
	protected override System.Func<System.Object,System.Boolean> OnPackingReferenceTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xDBBBD0
	protected override System.Func<System.Object,System.Boolean> OnPackingNullableValueTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xDBBCD8
	protected override System.Action<System.Object> OnPackingCore(ReflectionSerializerNilImplicationHandlerParameter parameter, System.Func<System.Object,System.Boolean> condition) { }

	// RVA: 0xDBBDB4
	protected override System.Action<System.Object> OnNopOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xDBBEBC
	protected override System.Action<System.Object> OnThrowNullIsProhibitedExceptionOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xDBBF7C
	protected override System.Action<System.Object> OnThrowValueTypeCannotBeNull3OnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xDBC03C
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xDBC5D0
	public void .ctor() { }

	// RVA: 0xDBD5C4
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xDBD5F8
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

	// RVA: 0xDBC2CC
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xDBCCB8
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDBD16C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDBD558
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xDBD59C
	protected override void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xDBD930
	public void .ctor() { }

	// RVA: 0xDBE060
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xDBE094
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

	// RVA: 0xDBD62C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xDBD93C
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDBDE3C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDBDFF4
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xDBE038
	protected override void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xDBE350
	public void .ctor() { }

	// RVA: 0xDBEBCC
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

	// RVA: 0xDBE0C8
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xDBE4A0
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDBE9C8
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDBEB88
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xDBEE88
	public void .ctor() { }

	// RVA: 0xDBF1B8
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

	// RVA: 0xDBEC00
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xDBEE94
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDBEFB4
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDBF174
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public SerializationContext context; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal string <.ctor>b__2(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_1
{
	// Fields
	public SerializingMember member; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35252FC
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

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal System.Collections.Generic.KeyValuePair<System.String,System.Int32> <.ctor>b__8_0(DataMemberContract contract, int index) { }

	// RVA: 0x26AD93C
	internal bool <.ctor>b__8_1(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x26AD93C
	internal int <.ctor>b__8_3(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x35258B4
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

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
	internal void <UnpackMemberValue>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_1
{
	// Fields
	public int argumentIndex; // 0x0
	public MsgPack.Serialization.ReflectionSerializers.ReflectionObjectMessagePackSerializer.<>c__DisplayClass13_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x35267E8
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

	// RVA: 0x3526A40
	public void .ctor(SerializationContext context, SerializationTarget target, SerializerCapabilities capabilities) { }

	// RVA: 0x26AD93C
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x26AD93C
	private bool IsNull(T objectTree, int index) { }

	// RVA: 0x26AD93C
	private void PackMemberValue(Packer packer, T objectTree, int index) { }

	// RVA: 0x26AD93C
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x26AD93C
	private object UnpackMemberValue(object objectGraph, Unpacker unpacker, int itemsCount, int unpacked, int index, int unpackerOffset) { }

	// RVA: 0x3525920
	private object UnpackSingleValue(Unpacker unpacker, int index) { }

	// RVA: 0x3526A40
	private void UnpackAndAddCollectionItem(object objectGraph, Unpacker unpacker, int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public CollectionTraits collectionTraits; // 0x10

	// Methods

	// RVA: 0xDBF1EC
	public void .ctor() { }

	// RVA: 0xDC0740
	internal void <GetAddItem>b__0(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public MethodInfo getter; // 0x10
	public MethodInfo setter; // 0x18

	// Methods

	// RVA: 0xDC04B8
	public void .ctor() { }

	// RVA: 0xDC082C
	internal object <GetMetadata>b__0(object target) { }

	// RVA: 0xDC08A0
	internal void <GetMetadata>b__1(object target, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ConstructorInfo constructor; // 0x10

	// Methods

	// RVA: 0xDC05FC
	public void .ctor() { }

	// RVA: 0xDC098C
	internal object <CreateCollectionInstanceFactory>b__0(int _) { }

	// RVA: 0xDC0A1C
	internal object <CreateCollectionInstanceFactory>b__1(int capacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xDC0604
	public void .ctor() { }

	// RVA: 0xDC0B20
	internal object <CreateCollectionInstanceFactory>b__2(int _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xDC060C
	public void .ctor() { }

	// RVA: 0xDC0C04
	internal object <CreateCollectionInstanceFactory>b__3(int capacity) { }

	// RVA: 0xDC0D48
	internal object <CreateCollectionInstanceFactory>b__4(int capacity) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal static class ReflectionSerializerHelper
{
	// Fields
	internal static readonly PropertyInfo DictionaryEntryKeyProperty; // 0x0
	internal static readonly PropertyInfo DictionaryEntryValueProperty; // 0x8

	// Methods

	// RVA: 0x35293EC
	public static MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionEnumMessagePackSerializer(SerializationContext context) { }

	// RVA: 0x26AD93C
	public static MessagePackSerializer CreateCollectionSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xDBCAC0
	public static System.Action<System.Object,System.Object> GetAddItem(Type targetType, CollectionTraits collectionTraits) { }

	// RVA: 0xDBF710
	public static void GetMetadata(Type targetType, System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, SerializationContext context, System.Func<System.Object,System.Object>[]& getters, System.Action<System.Object,System.Object>[]& setters, MemberInfo[] memberInfos, DataMemberContract[] contracts, MessagePackSerializer[] serializers) { }

	// RVA: 0xDC04C0
	private static void ThrowMissingGetterException(Type targetType, int number, PropertyInfo property) { }

	// RVA: 0xDBC5DC
	public static System.Func<System.Int32,System.Object> CreateCollectionInstanceFactory(Type abstractType, Type targetType, Type comparisonType, ConstructorInfo constructor) { }

	// RVA: 0xDC0614
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

	// RVA: 0xDC0E8C
	public Type get_ItemType() { }

	// RVA: 0xDC0E94
	public System.Action<System.Object> get_Store() { }

	// RVA: 0xDC0E9C
	public void .ctor(Type itemType, System.Action<System.Object> store, string memberName, Type declaringType) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionSerializerNilImplicationHandlerParameter
{
	// Fields
	private readonly Type _itemType; // 0x10
	private readonly string _memberName; // 0x18

	// Methods

	// RVA: 0xDC0F1C
	public Type get_ItemType() { }

	// RVA: 0xDC0F24
	public string get_MemberName() { }

	// RVA: 0xDC0F2C
	public void .ctor(Type itemType, string memberName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass1_0
{
	// Fields
	public Type genericType; // 0x10
	public Type source; // 0x18

	// Methods

	// RVA: 0xDC1220
	public void .ctor() { }

	// RVA: 0xDC1228
	internal bool <EnumerateGenericIntefaces>b__0(Type interface) { }

	// RVA: 0xDC133C
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

	// RVA: 0xDC13FC
	private static void .cctor() { }

	// RVA: 0xDC1468
	public void .ctor() { }

	// RVA: 0xDC1470
	internal string <GetFullName>b__3_0(Type t) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class GenericTypeExtensions
{
	// Methods

	// RVA: 0xDC0F7C
	public static bool Implements(Type source, Type genericType) { }

	// RVA: 0xDC0FE0
	private static System.Collections.Generic.IEnumerable<System.Type> EnumerateGenericIntefaces(Type source, Type genericType, bool includesOwn) { }

	// RVA: 0xDBF1F4
	public static string GetFullName(Type source) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class ReflectionExtensions
{
	// Methods

	// RVA: 0xDC1478
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

	// RVA: 0x352AE04
	private static void .cctor() { }

	// RVA: 0x35263A0
	public void .ctor() { }

	// RVA: 0x26AD93C
	internal string <BuildTypeCodeTypeHandleMap>b__4_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x26AD93C
	internal RuntimeTypeHandle <BuildTypeCodeTypeHandleMap>b__4_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x26AD93C
	internal Type <BuildTypeHandleTypeCodeMap>b__5_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x26AD93C
	internal string <BuildTypeHandleTypeCodeMap>b__5_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x35258B4
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

	// RVA: 0x35269D4
	public void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x35293EC
	private static System.Collections.Generic.IDictionary<System.String,System.RuntimeTypeHandle> BuildTypeCodeTypeHandleMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x35293EC
	private static System.Collections.Generic.IDictionary<System.RuntimeTypeHandle,System.String> BuildTypeHandleTypeCodeMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x35258B4
	private MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x26AD93C
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x26AD93C
	private string GetTypeCode(T objectTree) { }

	// RVA: 0x26AD93C
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x35258B4
	private Type GetTypeFromCode(string typeCode) { }

	// RVA: 0x35258B4
	private object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x26AD93C
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x35258B4
	private Type <UnpackFromCore>b__9_0(string c) { }

	// RVA: 0x26AD93C
	private T <UnpackFromCore>b__9_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class PolymorphicSerializerProvider<T0>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<T> _defaultSerializer; // 0x0
	private readonly PolymorphismSchema _defaultSchema; // 0x0

	// Methods

	// RVA: 0x35269D4
	public void .ctor(SerializationContext context, MessagePackSerializer defaultSerializer) { }

	// RVA: 0x3525998
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

	// RVA: 0x3526518
	public void .ctor(int capacity) { }

	// RVA: 0x26AD93C
	public void Enqueue(T item) { }

	// RVA: 0x26AD93C
	public T Dequeue() { }

	// RVA: 0x3526518
	private void SetCapacity(int capacity) { }

	// RVA: 0x35267E8
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

	// RVA: 0xDC14A0
	public static void Verify(AssemblyName assemblyName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xDC1614
	private static bool VerifyCore(AssemblyName assemblyName, string assemblyFullName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xDC1AEC
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class TypeEmbedingPolymorphicMessagePackSerializer<T0>
{
	// Fields
	private readonly PolymorphismSchema _schema; // 0x0

	// Methods

	// RVA: 0x35269D4
	public void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x35258B4
	private MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x26AD93C
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x26AD93C
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x35258B4
	private object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x26AD93C
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x35258B4
	private Type <UnpackFromCore>b__4_0(Unpacker u) { }

	// RVA: 0x26AD93C
	private T <UnpackFromCore>b__4_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal static class TypeInfoEncoder
{
	// Methods

	// RVA: 0xDC1C30
	public static void Encode(Packer packer, string typeCode) { }

	// RVA: 0xDC1C70
	public static void Encode(Packer packer, Type type) { }

	// RVA: 0x26AD93C
	public static T Decode(Unpacker unpacker, System.Func<System.String,System.Type> typeFinder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0x26AD93C
	public static T Decode(Unpacker unpacker, System.Func<MsgPack.Unpacker,System.Type> typeDecoder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0xDC1F7C
	public static Type DecodeRuntimeTypeInfo(Unpacker unpacker, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xDC258C
	private static void ThrowFailedToDecodeEncodingType() { }

	// RVA: 0xDC25E0
	private static void ThrowUnknownEncodingType(Byte encodeType) { }

	// RVA: 0xDC26C8
	private static void ThrowFailedToDecodeCompressedTypeName() { }

	// RVA: 0xDC271C
	private static void ThrowFailedToDecodeAssemblySimpleName() { }

	// RVA: 0xDC2770
	private static void ThrowFailedToDecodeAssemblyVersion() { }

	// RVA: 0xDC27C4
	private static void ThrowFailedToDecodeAssemblyCulture() { }

	// RVA: 0xDC2818
	private static void ThrowFailedToDecodeAssemblyKeyToken() { }

	// RVA: 0xDC24AC
	private static void CheckUnpackerForRuntimeTypeInfoDecoding(Unpacker unpacker) { }

	// RVA: 0xDC2AD0
	private static void ThrowEncodedTypeIsNotInNonNillArray() { }

	// RVA: 0xDC2B24
	private static void ThrowEncodedTypeDoesNotHaveValidArrayItems() { }

	// RVA: 0xDC286C
	private static AssemblyName BuildAssemblyName(string assemblySimpleName, Byte[] version, string culture, Byte[] publicKeyToken) { }

	// RVA: 0xDC2A00
	private static string DecompressTypeName(string assemblySimpleName, string compressedTypeName) { }

	// RVA: 0xDC2A90
	private static Type LoadDecodedType(AssemblyName assemblyName, string typeFullName) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractCollectionMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x50
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x58

	// Methods

	// RVA: 0xDC2B78
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xDC2E60
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC3040
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class AbstractCollectionSerializerHelper
{
	// Methods

	// RVA: 0xDC2D08
	public static void GetConcreteSerializer(SerializationContext context, PolymorphismSchema schema, Type abstractType, Type targetType, Type exampleType, ICollectionInstanceFactory factory, MessagePackSerializer serializer) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractDictionaryMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x68
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x70

	// Methods

	// RVA: 0xDC30F4
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xDC3400
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC35E0
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractEnumerableMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly MessagePackSerializer _concreteSerializer; // 0x50

	// Methods

	// RVA: 0xDC3694
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xDC37AC
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC388C
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericCollectionMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xDC3940
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xDC3A08
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC3AE8
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericDictionaryMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x50

	// Methods

	// RVA: 0xDC3B9C
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xDC3CB4
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC3E44
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericEnumerableMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xDC3EF8
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xDC3FC0
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC40A0
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericListMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x48

	// Methods

	// RVA: 0xDC4154
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xDC426C
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC444C
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySegmentMessageSerializer
{
	// Methods

	// RVA: 0xDC4500
	public static void PackByteArraySegmentTo(Packer packer, System.ArraySegment<System.Byte> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xDC4644
	public static void PackCharArraySegmentTo(Packer packer, System.ArraySegment<System.Char> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x26AD93C
	public static void PackGenericArraySegmentTo(Packer packer, System.ArraySegment<T> objectTree, MsgPack.Serialization.MessagePackSerializer<T> itemSerializer) { }

	// RVA: 0xDC47B8
	public static System.ArraySegment<System.Byte> UnpackByteArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xDC4870
	public static System.ArraySegment<System.Char> UnpackCharArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x26AD93C
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

	// RVA: 0xDC6578
	private static void .cctor() { }

	// RVA: 0xDC65E4
	public void .ctor() { }

	// RVA: 0xDC65EC
	internal object <InitializeArraySerializerFactories>b__4_0(SerializationContext context) { }

	// RVA: 0xDC672C
	internal object <InitializeArraySerializerFactories>b__4_1(SerializationContext context) { }

	// RVA: 0xDC686C
	internal object <InitializeArraySerializerFactories>b__4_2(SerializationContext context) { }

	// RVA: 0xDC69AC
	internal object <InitializeArraySerializerFactories>b__4_3(SerializationContext context) { }

	// RVA: 0xDC6AEC
	internal object <InitializeArraySerializerFactories>b__4_4(SerializationContext context) { }

	// RVA: 0xDC6C2C
	internal object <InitializeArraySerializerFactories>b__4_5(SerializationContext context) { }

	// RVA: 0xDC6D6C
	internal object <InitializeArraySerializerFactories>b__4_6(SerializationContext context) { }

	// RVA: 0xDC6EAC
	internal object <InitializeArraySerializerFactories>b__4_7(SerializationContext context) { }

	// RVA: 0xDC6FEC
	internal object <InitializeArraySerializerFactories>b__4_8(SerializationContext context) { }

	// RVA: 0xDC712C
	internal object <InitializeArraySerializerFactories>b__4_9(SerializationContext context) { }

	// RVA: 0xDC726C
	internal object <InitializeArraySerializerFactories>b__4_10(SerializationContext context) { }

	// RVA: 0xDC73AC
	internal object <InitializeArraySerializerFactories>b__4_11(SerializationContext context) { }

	// RVA: 0xDC74EC
	internal object <InitializeArraySerializerFactories>b__4_12(SerializationContext context) { }

	// RVA: 0xDC762C
	internal object <InitializeArraySerializerFactories>b__4_13(SerializationContext context) { }

	// RVA: 0xDC776C
	internal object <InitializeArraySerializerFactories>b__4_14(SerializationContext context) { }

	// RVA: 0xDC78AC
	internal object <InitializeArraySerializerFactories>b__4_15(SerializationContext context) { }

	// RVA: 0xDC79EC
	internal object <InitializeArraySerializerFactories>b__4_16(SerializationContext context) { }

	// RVA: 0xDC7B2C
	internal object <InitializeArraySerializerFactories>b__4_17(SerializationContext context) { }

	// RVA: 0xDC7C6C
	internal object <InitializeArraySerializerFactories>b__4_18(SerializationContext context) { }

	// RVA: 0xDC7DAC
	internal object <InitializeArraySerializerFactories>b__4_19(SerializationContext context) { }

	// RVA: 0xDC7EEC
	internal object <InitializeArraySerializerFactories>b__4_20(SerializationContext context) { }

	// RVA: 0xDC802C
	internal object <InitializeArraySerializerFactories>b__4_21(SerializationContext context) { }

	// RVA: 0xDC816C
	internal object <InitializeArraySerializerFactories>b__4_22(SerializationContext context) { }

	// RVA: 0xDC82AC
	internal object <InitializeArraySerializerFactories>b__4_23(SerializationContext context) { }

	// RVA: 0xDC83EC
	internal object <InitializeArraySerializerFactories>b__4_24(SerializationContext context) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySerializer
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> _arraySerializerFactories; // 0x0

	// Methods

	// RVA: 0x35294CC
	public static MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema itemsSchema) { }

	// RVA: 0xDC4928
	public static MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xDC4B08
	private static object GetPrimitiveArraySerializer(SerializationContext context, Type targetType) { }

	// RVA: 0xDC4DB8
	private static System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> InitializeArraySerializerFactories() { }

	// RVA: 0xDC651C
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SByteArraySerializer
{
	// Methods

	// RVA: 0xDC66A8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC852C
	protected internal override void PackToCore(Packer packer, SByte[] objectTree) { }

	// RVA: 0xDC85A4
	protected internal override SByte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC8748
	protected internal override void UnpackToCore(Unpacker unpacker, SByte[] collection) { }

	// RVA: 0xDC8670
	private static void UnpackToCore(Unpacker unpacker, SByte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int16ArraySerializer
{
	// Methods

	// RVA: 0xDC6928
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC87E8
	protected internal override void PackToCore(Packer packer, Int16[] objectTree) { }

	// RVA: 0xDC8860
	protected internal override Int16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC8A04
	protected internal override void UnpackToCore(Unpacker unpacker, Int16[] collection) { }

	// RVA: 0xDC892C
	private static void UnpackToCore(Unpacker unpacker, Int16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int32ArraySerializer
{
	// Methods

	// RVA: 0xDC6BA8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC8AA4
	protected internal override void PackToCore(Packer packer, int[] objectTree) { }

	// RVA: 0xDC8B1C
	protected internal override int[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC8CC0
	protected internal override void UnpackToCore(Unpacker unpacker, int[] collection) { }

	// RVA: 0xDC8BE8
	private static void UnpackToCore(Unpacker unpacker, int[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int64ArraySerializer
{
	// Methods

	// RVA: 0xDC6E28
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC8D60
	protected internal override void PackToCore(Packer packer, Int64[] objectTree) { }

	// RVA: 0xDC8DD8
	protected internal override Int64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC8F7C
	protected internal override void UnpackToCore(Unpacker unpacker, Int64[] collection) { }

	// RVA: 0xDC8EA4
	private static void UnpackToCore(Unpacker unpacker, Int64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class ByteArraySerializer
{
	// Methods

	// RVA: 0xDC70A8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC901C
	protected internal override void PackToCore(Packer packer, Byte[] objectTree) { }

	// RVA: 0xDC9094
	protected internal override Byte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC9238
	protected internal override void UnpackToCore(Unpacker unpacker, Byte[] collection) { }

	// RVA: 0xDC9160
	private static void UnpackToCore(Unpacker unpacker, Byte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt16ArraySerializer
{
	// Methods

	// RVA: 0xDC7328
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC92D8
	protected internal override void PackToCore(Packer packer, UInt16[] objectTree) { }

	// RVA: 0xDC9350
	protected internal override UInt16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC94F4
	protected internal override void UnpackToCore(Unpacker unpacker, UInt16[] collection) { }

	// RVA: 0xDC941C
	private static void UnpackToCore(Unpacker unpacker, UInt16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt32ArraySerializer
{
	// Methods

	// RVA: 0xDC75A8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC9594
	protected internal override void PackToCore(Packer packer, UInt32[] objectTree) { }

	// RVA: 0xDC960C
	protected internal override UInt32[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC97B0
	protected internal override void UnpackToCore(Unpacker unpacker, UInt32[] collection) { }

	// RVA: 0xDC96D8
	private static void UnpackToCore(Unpacker unpacker, UInt32[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt64ArraySerializer
{
	// Methods

	// RVA: 0xDC7828
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC9850
	protected internal override void PackToCore(Packer packer, UInt64[] objectTree) { }

	// RVA: 0xDC98C8
	protected internal override UInt64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC9A6C
	protected internal override void UnpackToCore(Unpacker unpacker, UInt64[] collection) { }

	// RVA: 0xDC9994
	private static void UnpackToCore(Unpacker unpacker, UInt64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SingleArraySerializer
{
	// Methods

	// RVA: 0xDC7AA8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC9B0C
	protected internal override void PackToCore(Packer packer, float[] objectTree) { }

	// RVA: 0xDC9B84
	protected internal override float[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC9D28
	protected internal override void UnpackToCore(Unpacker unpacker, float[] collection) { }

	// RVA: 0xDC9C50
	private static void UnpackToCore(Unpacker unpacker, float[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class DoubleArraySerializer
{
	// Methods

	// RVA: 0xDC7D28
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDC9DC8
	protected internal override void PackToCore(Packer packer, Double[] objectTree) { }

	// RVA: 0xDC9E40
	protected internal override Double[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC9FE4
	protected internal override void UnpackToCore(Unpacker unpacker, Double[] collection) { }

	// RVA: 0xDC9F0C
	private static void UnpackToCore(Unpacker unpacker, Double[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BooleanArraySerializer
{
	// Methods

	// RVA: 0xDC7FA8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCA084
	protected internal override void PackToCore(Packer packer, bool[] objectTree) { }

	// RVA: 0xDCA0FC
	protected internal override bool[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCA2A0
	protected internal override void UnpackToCore(Unpacker unpacker, bool[] collection) { }

	// RVA: 0xDCA1C8
	private static void UnpackToCore(Unpacker unpacker, bool[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSByteArraySerializer
{
	// Methods

	// RVA: 0xDC67E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCA340
	protected internal override void PackToCore(Packer packer, System.Nullable<System.SByte>[] objectTree) { }

	// RVA: 0xDCA3CC
	protected internal override System.Nullable<System.SByte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCA570
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection) { }

	// RVA: 0xDCA498
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt16ArraySerializer
{
	// Methods

	// RVA: 0xDC6A68
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCA610
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int16>[] objectTree) { }

	// RVA: 0xDCA69C
	protected internal override System.Nullable<System.Int16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCA840
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection) { }

	// RVA: 0xDCA768
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt32ArraySerializer
{
	// Methods

	// RVA: 0xDC6CE8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCA8E0
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int32>[] objectTree) { }

	// RVA: 0xDCA958
	protected internal override System.Nullable<System.Int32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCAAFC
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection) { }

	// RVA: 0xDCAA24
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt64ArraySerializer
{
	// Methods

	// RVA: 0xDC6F68
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCAB9C
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int64>[] objectTree) { }

	// RVA: 0xDCAC18
	protected internal override System.Nullable<System.Int64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCADBC
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection) { }

	// RVA: 0xDCACE4
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableByteArraySerializer
{
	// Methods

	// RVA: 0xDC71E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCAE5C
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Byte>[] objectTree) { }

	// RVA: 0xDCAEE8
	protected internal override System.Nullable<System.Byte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCB08C
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection) { }

	// RVA: 0xDCAFB4
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt16ArraySerializer
{
	// Methods

	// RVA: 0xDC7468
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCB12C
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt16>[] objectTree) { }

	// RVA: 0xDCB1B8
	protected internal override System.Nullable<System.UInt16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCB35C
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection) { }

	// RVA: 0xDCB284
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt32ArraySerializer
{
	// Methods

	// RVA: 0xDC76E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCB3FC
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt32>[] objectTree) { }

	// RVA: 0xDCB474
	protected internal override System.Nullable<System.UInt32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCB618
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection) { }

	// RVA: 0xDCB540
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt64ArraySerializer
{
	// Methods

	// RVA: 0xDC7968
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCB6B8
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt64>[] objectTree) { }

	// RVA: 0xDCB734
	protected internal override System.Nullable<System.UInt64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCB8D8
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection) { }

	// RVA: 0xDCB800
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSingleArraySerializer
{
	// Methods

	// RVA: 0xDC7BE8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCB978
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Single>[] objectTree) { }

	// RVA: 0xDCB9F0
	protected internal override System.Nullable<System.Single>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCBB94
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection) { }

	// RVA: 0xDCBABC
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableDoubleArraySerializer
{
	// Methods

	// RVA: 0xDC7E68
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCBC34
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Double>[] objectTree) { }

	// RVA: 0xDCBCB0
	protected internal override System.Nullable<System.Double>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCBE54
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection) { }

	// RVA: 0xDCBD7C
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableBooleanArraySerializer
{
	// Methods

	// RVA: 0xDC80E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCBEF4
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Boolean>[] objectTree) { }

	// RVA: 0xDCBF80
	protected internal override System.Nullable<System.Boolean>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCC124
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection) { }

	// RVA: 0xDCC04C
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class StringArraySerializer
{
	// Methods

	// RVA: 0xDC8228
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCC1C4
	protected internal override void PackToCore(Packer packer, string[] objectTree) { }

	// RVA: 0xDCC23C
	protected internal override string[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCC3F0
	protected internal override void UnpackToCore(Unpacker unpacker, string[] collection) { }

	// RVA: 0xDCC308
	private static void UnpackToCore(Unpacker unpacker, string[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BinaryArraySerializer
{
	// Methods

	// RVA: 0xDC8368
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCC490
	protected internal override void PackToCore(Packer packer, Byte[][] objectTree) { }

	// RVA: 0xDCC508
	protected internal override Byte[][] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCC6BC
	protected internal override void UnpackToCore(Unpacker unpacker, Byte[][] collection) { }

	// RVA: 0xDCC5D4
	private static void UnpackToCore(Unpacker unpacker, Byte[][] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MessagePackObjectArraySerializer
{
	// Methods

	// RVA: 0xDC84A8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCC75C
	protected internal override void PackToCore(Packer packer, MessagePackObject[] objectTree) { }

	// RVA: 0xDCC830
	protected internal override MessagePackObject[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCC9E8
	protected internal override void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection) { }

	// RVA: 0xDCC8FC
	private static void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UnityArraySerializer
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38
	private readonly Type _itemType; // 0x40

	// Methods

	// RVA: 0xDC4C0C
	public void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xDCCA88
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDCCE2C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDCD188
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xDCCEF0
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

	// RVA: 0xDCD25C
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xDCD874
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class DateTimeOffsetMessagePackSerializer
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xDCDAA8
	public void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xDCDB40
	protected internal override void PackToCore(Packer packer, DateTimeOffset objectTree) { }

	// RVA: 0xDCDD8C
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

	// RVA: 0xDCE490
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xDCE8FC
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_BooleanMessagePackSerializer
{
	// Methods

	// RVA: 0xDCEB30
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCEBB4
	protected internal override void PackToCore(Packer packer, bool value) { }

	// RVA: 0xDCEBD4
	protected internal override bool UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteMessagePackSerializer
{
	// Methods

	// RVA: 0xDCEE04
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCEE88
	protected internal override void PackToCore(Packer packer, Byte value) { }

	// RVA: 0xDCEEA8
	protected internal override Byte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharMessagePackSerializer
{
	// Methods

	// RVA: 0xDCF0D8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCF15C
	protected internal override void PackToCore(Packer packer, Char value) { }

	// RVA: 0xDCF17C
	protected internal override Char UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DecimalMessagePackSerializer
{
	// Methods

	// RVA: 0xDCF380
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCF404
	protected internal override void PackToCore(Packer packer, Decimal value) { }

	// RVA: 0xDCF508
	protected internal override Decimal UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DoubleMessagePackSerializer
{
	// Methods

	// RVA: 0xDCF77C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCF800
	protected internal override void PackToCore(Packer packer, Double value) { }

	// RVA: 0xDCF81C
	protected internal override Double UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_GuidMessagePackSerializer
{
	// Methods

	// RVA: 0xDCFA4C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCFAD0
	protected internal override void PackToCore(Packer packer, Guid value) { }

	// RVA: 0xDCFB1C
	protected internal override Guid UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int16MessagePackSerializer
{
	// Methods

	// RVA: 0xDCFD3C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDCFDC0
	protected internal override void PackToCore(Packer packer, Int16 value) { }

	// RVA: 0xDCFDE0
	protected internal override Int16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int32MessagePackSerializer
{
	// Methods

	// RVA: 0xDD0010
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD0094
	protected internal override void PackToCore(Packer packer, int value) { }

	// RVA: 0xDD00B4
	protected internal override int UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int64MessagePackSerializer
{
	// Methods

	// RVA: 0xDD02E4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD0368
	protected internal override void PackToCore(Packer packer, Int64 value) { }

	// RVA: 0xDD0388
	protected internal override Int64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SByteMessagePackSerializer
{
	// Methods

	// RVA: 0xDD05B8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD063C
	protected internal override void PackToCore(Packer packer, SByte value) { }

	// RVA: 0xDD065C
	protected internal override SByte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SingleMessagePackSerializer
{
	// Methods

	// RVA: 0xDD088C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD0910
	protected internal override void PackToCore(Packer packer, float value) { }

	// RVA: 0xDD092C
	protected internal override float UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_TimeSpanMessagePackSerializer
{
	// Methods

	// RVA: 0xDD0B5C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD0BE0
	protected internal override void PackToCore(Packer packer, TimeSpan value) { }

	// RVA: 0xDD0C64
	protected internal override TimeSpan UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt16MessagePackSerializer
{
	// Methods

	// RVA: 0xDD0E94
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD0F18
	protected internal override void PackToCore(Packer packer, UInt16 value) { }

	// RVA: 0xDD0F38
	protected internal override UInt16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt32MessagePackSerializer
{
	// Methods

	// RVA: 0xDD1168
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD11EC
	protected internal override void PackToCore(Packer packer, UInt32 value) { }

	// RVA: 0xDD120C
	protected internal override UInt32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt64MessagePackSerializer
{
	// Methods

	// RVA: 0xDD143C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD14C0
	protected internal override void PackToCore(Packer packer, UInt64 value) { }

	// RVA: 0xDD14E0
	protected internal override UInt64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_BitVector32MessagePackSerializer
{
	// Methods

	// RVA: 0xDD1710
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD1794
	protected internal override void PackToCore(Packer packer, BitVector32 value) { }

	// RVA: 0xDD17B4
	protected internal override BitVector32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class GenericSerializer
{
	// Methods

	// RVA: 0x35294CC
	public static MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0xDD19E4
	public static MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema schema) { }

	// RVA: 0xDD1D8C
	private static MessagePackSerializer CreateArraySerializer(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xDD1E04
	private static MessagePackSerializer CreateNullableSerializer(SerializationContext context, Type nullableType, Type underlyingType) { }

	// RVA: 0xDD1EAC
	private static MessagePackSerializer CreateListSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xDD1FC8
	private static MessagePackSerializer CreateDictionarySerializer(SerializationContext context, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema schema) { }

	// RVA: 0xDD24B4
	public static MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xDD25AC
	internal static MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema, CollectionTraits traits) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class MessagePackObjectExtensions
{
	// Methods

	// RVA: 0xDCE2D4
	public static Int64 DeserializeAsInt64(MessagePackObject source) { }

	// RVA: 0xDD28F8
	public static string DeserializeAsString(MessagePackObject source) { }

	// RVA: 0xDCE118
	public static MessagePackExtendedTypeObject DeserializeAsMessagePackExtendedTypeObject(MessagePackObject source) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackExtendedTypeObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xDD2AB4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD2B38
	protected internal override void PackToCore(Packer packer, MessagePackExtendedTypeObject value) { }

	// RVA: 0xDD2B5C
	protected internal override MessagePackExtendedTypeObject UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectDictionaryMessagePackSerializer
{
	// Methods

	// RVA: 0xDD2D44
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD2DC8
	protected internal override void PackToCore(Packer packer, MessagePackObjectDictionary objectTree) { }

	// RVA: 0xDD3094
	protected internal override MessagePackObjectDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD3288
	protected internal override void UnpackToCore(Unpacker unpacker, MessagePackObjectDictionary collection) { }

	// RVA: 0xDD3168
	private static void UnpackToCore(Unpacker unpacker, int count, MessagePackObjectDictionary collection) { }

	// RVA: 0xDD3300
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xDD3368
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD33EC
	protected internal override void PackToCore(Packer packer, MessagePackObject value) { }

	// RVA: 0xDD3468
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

	// RVA: 0xDD3A14
	public void .ctor() { }

	// RVA: 0xDD4C04
	internal void <PackArrayCore>b__0(int[] indices) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public Unpacker unpacker; // 0x10
	public UnityMultidimensionalArraySerializer <>4__this; // 0x18

	// Methods

	// RVA: 0xDD48AC
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1
{
	// Fields
	public Unpacker arrayUnpacker; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xDD4BF4
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2
{
	// Fields
	public Array result; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xDD4BFC
	public void .ctor() { }

	// RVA: 0xDD4C58
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

	// RVA: 0xDC4CA4
	public void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xDD34D4
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDD3528
	private void PackArrayCore(Packer packer, Array array) { }

	// RVA: 0xDD3A1C
	private static void GetArrayMetadata(Array array, int[] lengths, int[] lowerBounds) { }

	// RVA: 0xDD3D88
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD48B4
	private void ReadArrayMetadata(Unpacker metadataUnpacker, int[] lengths, int[] lowerBounds) { }

	// RVA: 0xDD3B5C
	private static void ForEach(Array array, int totalLength, int[] lowerBounds, int[] lengths, System.Action<System.Int32[]> action) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NativeDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xDCD76C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD4CF8
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xDD4DA0
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NullableMessagePackSerializer
{
	// Fields
	private readonly MessagePackSerializer _valueSerializer; // 0x38

	// Methods

	// RVA: 0xDD2100
	public void .ctor(SerializationContext ownerContext, Type nullableType, Type underlyingType) { }

	// RVA: 0xDCD734
	public void .ctor(SerializationContext ownerContext, Type nullableType, MessagePackSerializer valueSerializer) { }

	// RVA: 0xDD4E30
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDD4E50
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

	// RVA: 0x35293B4
	private static System.Action<MsgPack.Packer,System.ArraySegment<T>,MsgPack.Serialization.MessagePackSerializer<T>> InitializePacking() { }

	// RVA: 0x35293B4
	private static System.Func<MsgPack.Unpacker,MsgPack.Serialization.MessagePackSerializer<T>,System.ArraySegment<T>> InitializeUnpacking() { }

	// RVA: 0x35267E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x26AD93C
	protected internal sealed override void PackToCore(Packer packer, System.ArraySegment<T> objectTree) { }

	// RVA: 0x26AD93C
	protected internal sealed override System.ArraySegment<T> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x352AE04
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteArrayMessagePackSerializer
{
	// Methods

	// RVA: 0xDD4E70
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD4EF4
	protected internal override void PackToCore(Packer packer, Byte[] value) { }

	// RVA: 0xDD4F14
	protected internal override Byte[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharArrayMessagePackSerializer
{
	// Methods

	// RVA: 0xDD4FE8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD506C
	protected internal override void PackToCore(Packer packer, Char[] value) { }

	// RVA: 0xDD50A8
	protected internal override Char[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_DictionaryEntryMessagePackSerializer
{
	// Methods

	// RVA: 0xDD517C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD5200
	protected internal override void PackToCore(Packer packer, DictionaryEntry objectTree) { }

	// RVA: 0xDD52C4
	private static MessagePackObject EnsureMessagePackObject(object obj) { }

	// RVA: 0xDD53A4
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

	// RVA: 0xDD224C
	public void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema keysSchema, PolymorphismSchema valuesSchema) { }

	// RVA: 0xDD55F8
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDD5A28
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD60C0
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xDD5BA8
	private void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xDD5B34
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_KeyValuePair_2MessagePackSerializer<T0, T1>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x35267E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x26AD93C
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.KeyValuePair<TKey,TValue> objectTree) { }

	// RVA: 0x26AD93C
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

	// RVA: 0xDD215C
	public void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema itemsSchema) { }

	// RVA: 0xDD6168
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDD6520
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD6A1C
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xDD66E4
	private void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xDD65E0
	public object CreateInstance(int initialCapacity) { }

	// RVA: 0xDD6AC4
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_Collections_Generic_ListOfMessagePackObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xDD6BC0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD6C44
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.List<MsgPack.MessagePackObject> objectTree) { }

	// RVA: 0xDD6E6C
	protected internal override System.Collections.Generic.List<MsgPack.MessagePackObject> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD7040
	protected internal override void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection) { }

	// RVA: 0xDD6F54
	private static void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection, int count) { }

	// RVA: 0xDD70E0
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_Queue_1MessagePackSerializer<T0>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TItem> _itemSerializer; // 0x0

	// Methods

	// RVA: 0x35267E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x35269D4
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.Queue<TItem> objectTree) { }

	// RVA: 0x35258B4
	protected internal override System.Collections.Generic.Queue<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x35269D4
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

	// RVA: 0x35267E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x35269D4
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.Stack<TItem> objectTree) { }

	// RVA: 0x35258B4
	protected internal override System.Collections.Generic.Stack<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x35269D4
	protected internal override void UnpackToCore(Unpacker unpacker, System.Collections.Generic.Stack<TItem> collection) { }

	// RVA: 0x3525920
	private System.Collections.Generic.IEnumerable<TItem> UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: -1
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_QueueMessagePackSerializer
{
	// Methods

	// RVA: 0xDD715C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD71E0
	protected internal override void PackToCore(Packer packer, Queue objectTree) { }

	// RVA: 0xDD747C
	protected internal override Queue UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD7560
	protected internal override void UnpackToCore(Unpacker unpacker, Queue collection) { }

	// RVA: 0xDD76DC
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_NameValueCollectionMessagePackSerializer
{
	// Methods

	// RVA: 0xDD7744
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD77C8
	protected internal override void PackToCore(Packer packer, NameValueCollection objectTree) { }

	// RVA: 0xDD7B9C
	protected internal override NameValueCollection UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD7FC0
	protected internal override void UnpackToCore(Unpacker unpacker, NameValueCollection collection) { }

	// RVA: 0xDD7C70
	private static void UnpackToCore(Unpacker unpacker, NameValueCollection collection, int keyCount) { }

	// RVA: 0xDD8060
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_StackMessagePackSerializer
{
	// Methods

	// RVA: 0xDD80C8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD814C
	protected internal override void PackToCore(Packer packer, Stack objectTree) { }

	// RVA: 0xDD83E8
	protected internal override Stack UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD8720
	protected internal override void UnpackToCore(Unpacker unpacker, Stack collection) { }

	// RVA: 0xDD84B8
	private static ICollection UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: 0xDD8A6C
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_DBNullMessagePackSerializer
{
	// Methods

	// RVA: 0xDD8AD4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD8B58
	protected internal override void PackToCore(Packer packer, DBNull objectTree) { }

	// RVA: 0xDD8B74
	protected internal override DBNull UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD8BC8
	protected internal override DBNull UnpackNil() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Globalization_CultureInfoMessagePackSerializer
{
	// Methods

	// RVA: 0xDD8C44
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD8CC8
	protected internal override void PackToCore(Packer packer, CultureInfo objectTree) { }

	// RVA: 0xDD8D0C
	protected internal override CultureInfo UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xDD8D9C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD8E20
	protected internal override void PackToCore(Packer packer, object value) { }

	// RVA: 0xDD8EF8
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_StringMessagePackSerializer
{
	// Methods

	// RVA: 0xDD9234
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD92B8
	protected internal override void PackToCore(Packer packer, string value) { }

	// RVA: 0xDD92D8
	protected internal override string UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Text_StringBuilderMessagePackSerializer
{
	// Methods

	// RVA: 0xDD9398
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD941C
	protected internal override void PackToCore(Packer packer, StringBuilder value) { }

	// RVA: 0xDD9460
	protected internal override StringBuilder UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDD9550
	protected internal override void UnpackToCore(Unpacker unpacker, StringBuilder collection) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UriMessagePackSerializer
{
	// Methods

	// RVA: 0xDD9624
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD96A8
	protected internal override void PackToCore(Packer packer, Uri objectTree) { }

	// RVA: 0xDD96EC
	protected internal override Uri UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_VersionMessagePackSerializer
{
	// Methods

	// RVA: 0xDD976C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD97F0
	protected internal override void PackToCore(Packer packer, Version objectTree) { }

	// RVA: 0xDD9868
	protected internal override Version UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xDCD7F0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDD9AE8
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xDD9B94
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampMessagePackSerializer
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xDD9C3C
	public void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xDD9CD4
	protected internal override void PackToCore(Packer packer, Timestamp objectTree) { }

	// RVA: 0xDD9E6C
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

	// RVA: 0xDDA144
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xDDA5B0
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class UnixEpocDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xDCD6B0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xDDA7E4
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xDDA880
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityCollectionMessagePackSerializer
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40
	private readonly MethodInfo _add; // 0x48

	// Methods

	// RVA: 0xDC2CC4
	protected void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xDDA9F4
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDDADA8
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC2F9C
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDDB038
	protected override void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializer<T0, T1, T2>
{
	// Methods

	// RVA: 0x26AD93C
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

	// RVA: 0xDC3238
	protected void .ctor(SerializationContext ownerContext, Type targetType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xDDB124
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDDB57C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC353C
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xDDBA68
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xDDBA78
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xDDB5D8
	private void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializerBase<T0, T1, T2>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x26AD93C
	protected internal override void PackToCore(Packer packer, TDictionary objectTree) { }

	// RVA: -1
	protected abstract int GetCount(TDictionary dictionary) { }

	// RVA: 0x26AD93C
	protected internal override TDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x26AD93C
	internal virtual TDictionary InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract TDictionary CreateInstance(int initialCapacity) { }

	// RVA: 0x26AD93C
	private void UnpackToCore(Unpacker unpacker, TDictionary collection, int itemsCount) { }

	// RVA: 0x26AD93C
	protected virtual void AddItem(TDictionary dictionary, TKey key, TValue value) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityEnumerableMessagePackSerializer
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40

	// Methods

	// RVA: 0xDC3778
	protected void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xDDBB20
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

	// RVA: 0xDDBF20
	internal MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xDDA910
	protected void .ctor(SerializationContext ownerContext, Type targetType, Type itemType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xDDBF28
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xDDBF38
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xDDAE04
	internal void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xDDBFE0
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

	// RVA: 0xDBC5D8
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xDBCDD8
	protected internal override void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericDictionaryMessagePackSerializer
{
	// Fields
	private readonly MessagePackSerializer _keySerializer; // 0x38
	private readonly MessagePackSerializer _valueSerializer; // 0x40

	// Methods

	// RVA: 0xDBE358
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xDBE5C0
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xDBEB2C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC3D7C
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xDDC56C
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xDDC57C
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xDDC138
	private void UnpackToCore(Unpacker unpacker, IDictionary collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializer
{
	// Methods

	// RVA: 0xDBD938
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xDBDA5C
	protected internal override void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializerBase
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38

	// Methods

	// RVA: 0xDDC650
	internal MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xDDC018
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xDDC658
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xDDC668
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xDBD324
	internal void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xDDC710
	protected virtual void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericListMessagePackSerializer
{
	// Methods

	// RVA: 0xDBEE90
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xDBF118
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDC43A8
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xDDC748
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


