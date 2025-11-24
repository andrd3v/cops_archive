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

	// RVA: 0x318DB98
	public <member>j__TPar get_member() { }

	// RVA: 0x318DB98
	public <data>j__TPar get_data() { }

	// RVA: 0x318DB98
	public void .ctor(<member>j__TPar member, <data>j__TPar data) { }

	// RVA: 0x30D3858
	public override bool Equals(object value) { }

	// RVA: 0x30D39B8
	public override int GetHashCode() { }

	// RVA: 0x30D3CF0
	public override string ToString() { }

}

// Namespace: MsgPack
internal static class BigEndianBinary
{
	// Methods

	// RVA: 0xCFB80C
	public static Int16 ToInt16(Byte[] buffer, int offset) { }

	// RVA: 0xCFB854
	public static int ToInt32(Byte[] buffer, int offset) { }

	// RVA: 0xCFB8CC
	public static Int64 ToInt64(Byte[] buffer, int offset) { }

	// RVA: 0xCFB9A4
	public static Byte ToByte(Byte[] buffer, int offset) { }

	// RVA: 0xCFB9D4
	public static UInt16 ToUInt16(Byte[] buffer, int offset) { }

	// RVA: 0xCFBA1C
	public static UInt32 ToUInt32(Byte[] buffer, int offset) { }

	// RVA: 0xCFBA94
	public static UInt64 ToUInt64(Byte[] buffer, int offset) { }

	// RVA: 0xCFBB6C
	public static float ToSingle(Byte[] buffer, int offset) { }

	// RVA: 0xCFBC68
	public static Double ToDouble(Byte[] buffer, int offset) { }

}

// Namespace: MsgPack
internal static class Binary
{
	// Fields
	public static readonly Byte[] Empty; // 0x0

	// Methods

	// RVA: 0xCFBD94
	public static string ToHexString(Byte[] blob) { }

	// RVA: 0xCFBE1C
	public static string ToHexString(Byte[] blob, bool withPrefix) { }

	// RVA: 0xCFC054
	public static void ToHexString(Byte[] blob, StringBuilder buffer) { }

	// RVA: 0xCFBF20
	private static void ToHexStringCore(Byte[] blob, StringBuilder buffer, bool withPrefix) { }

	// RVA: 0xCFC0DC
	private static Char ToHexChar(int b) { }

	// RVA: 0xCFC0F8
	public static int ToBits(float value) { }

	// RVA: 0xCFC108
	public static Int64 ToBits(Double value) { }

	// RVA: 0xCFC110
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class BufferManager
{
	// Methods

	// RVA: 0xCFC190
	public static Byte[] NewByteBuffer(int size) { }

	// RVA: 0xCFC218
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

	// RVA: 0xCFC2A0
	protected void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCFC30C
	public System.ArraySegment<System.Byte> GetResultBytes() { }

	// RVA: -1
	public abstract Byte[] GetFinalBuffer() { }

}

// Namespace: MsgPack
public abstract class ByteArrayUnpacker
{
	// Methods

	// RVA: 0xCFC3C4
	protected void .ctor() { }

}

// Namespace: MsgPack
internal abstract class ByteBufferAllocator
{
	// Methods

	// RVA: -1
	public abstract bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xCFC3CC
	protected void .ctor() { }

}

// Namespace: MsgPack
internal sealed class CollectionDebuggerProxy<T0>
{}

// Namespace: MsgPack
internal static class CollectionOperation
{
	// Methods

	// RVA: 0x318DB98
	public static void CopyTo(System.Collections.Generic.IEnumerable<T> source, int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x318DB98
	public static void CopyTo(System.Collections.Generic.IEnumerable<TSource> source, int sourceCount, int index, TDestination[] array, int arrayIndex, int count, System.Func<TSource,TDestination> converter) { }

	// RVA: 0x318DB98
	private static void ValidateCopyToArguments(int sourceCount, int index, T[] array, int arrayIndex, int count) { }

	// RVA: 0x318DB98
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

	// RVA: 0xCFC3D4
	public static bool EncodeString(Encoder source, Char[] chars, int charsOffset, int charsLength, Byte[] buffer, int bufferOffset, int bufferCount, int charsUsed, int bytesUsed) { }

	// RVA: 0xCFC41C
	public static bool DecodeString(Decoder source, Byte[] bytes, int bytesOffset, int bytesLength, Char[] buffer, StringBuilder result) { }

}

// Namespace: MsgPack
internal sealed class FixedArrayBufferAllocator
{
	// Fields
	public static readonly ByteBufferAllocator Instance; // 0x0

	// Methods

	// RVA: 0xCFC53C
	private void .ctor() { }

	// RVA: 0xCFC544
	public override bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xCFC568
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

	// RVA: 0xCFC100
	public void .ctor(float value) { }

	// RVA: 0xCFBBDC
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

	// RVA: 0xCFBC98
	public void .ctor(Byte[] bigEndianBytes, int offset) { }

}

// Namespace: MsgPack
[Serializable]
public sealed class InvalidMessagePackStreamException
{
	// Methods

	// RVA: 0xCFC5D4
	public void .ctor() { }

	// RVA: 0xCFC658
	public void .ctor(string message) { }

	// RVA: 0xCFC6EC
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xCFC784
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

	// RVA: 0xCFC808
	public static Byte get_Timestamp() { }

	// RVA: 0xCFC810
	public static Byte get_MultidimensionalArray() { }

}

// Namespace: MsgPack
public static class KnownExtTypeName
{
	// Methods

	// RVA: 0xCFC818
	public static string get_Timestamp() { }

	// RVA: 0xCFC85C
	public static string get_MultidimensionalArray() { }

}

// Namespace: MsgPack
[Serializable]
public sealed class MessageNotSupportedException
{
	// Methods

	// RVA: 0xCFC8A0
	public void .ctor() { }

	// RVA: 0xCFC924
	public void .ctor(string message) { }

	// RVA: 0xCFC9B8
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xCFCA50
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

	// RVA: 0xCFCAD4
	public override int get_BytesUsed() { }

	// RVA: 0xCFCAE0
	public override int get_InitialBufferOffset() { }

	// RVA: 0xCFCAE8
	public void .ctor(Byte[] buffer, int startOffset, ByteBufferAllocator allocator, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xCFCCCC
	public override Byte[] GetFinalBuffer() { }

	// RVA: 0xCFCCD4
	protected override void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xCFCDB0
	protected override void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xCFCDD0
	protected override void WriteByte(Byte value) { }

	// RVA: 0xCFCFC0
	private void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xCFCD90
	private void WriteBytes(Byte[] value) { }

	// RVA: 0xCFCE8C
	private void ThrowEofException(int requiredSize) { }

	// RVA: 0xCFD090
	protected override void PackCore(bool value) { }

	// RVA: 0xCFD0BC
	protected override void PackCore(Byte value) { }

	// RVA: 0xCFD1C8
	protected override void PackCore(SByte value) { }

	// RVA: 0xCFD1F0
	protected override void PackCore(Int16 value) { }

	// RVA: 0xCFD340
	protected override void PackCore(UInt16 value) { }

	// RVA: 0xCFD37C
	protected override void PackCore(int value) { }

	// RVA: 0xCFD534
	protected override void PackCore(UInt32 value) { }

	// RVA: 0xCFD584
	protected override void PackCore(Int64 value) { }

	// RVA: 0xCFD7EC
	protected override void PackCore(UInt64 value) { }

	// RVA: 0xCFD850
	protected override void PackCore(float value) { }

	// RVA: 0xCFDA08
	protected override void PackCore(Double value) { }

	// RVA: 0xCFDC50
	protected override void PackArrayHeaderCore(int length) { }

	// RVA: 0xCFDC90
	protected override void PackMapHeaderCore(int length) { }

	// RVA: 0xCFDCCC
	protected override void PackStringHeaderCore(int length) { }

	// RVA: 0xCFDD28
	protected override void PackBinaryHeaderCore(int length) { }

	// RVA: 0xCFDD5C
	protected override void PackRawCore(string value) { }

	// RVA: 0xCFDF18
	protected override void PackRawCore(Byte[] value) { }

	// RVA: 0xCFDFC8
	protected override void PackBinaryCore(Byte[] value) { }

	// RVA: 0xCFE048
	protected override void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xCFE184
	private void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xCFD0E0
	private void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xCFD234
	private void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xCFD3E0
	private void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xCFD608
	private void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xCFD858
	private void WriteBytes(Byte header, float value) { }

	// RVA: 0xCFDA10
	private void WriteBytes(Byte header, Double value) { }

	// RVA: 0xCFDD6C
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

	// RVA: 0xCFE1E0
	public sealed override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xCFE258
	protected sealed override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCFE33C
	public sealed override MessagePackObject get_LastReadData() { }

	// RVA: 0xCFE348
	protected sealed override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCFE354
	public sealed override bool get_IsArrayHeader() { }

	// RVA: 0xCFE364
	public sealed override bool get_IsMapHeader() { }

	// RVA: 0xCFE374
	public sealed override bool get_IsCollectionHeader() { }

	// RVA: 0xCFE384
	public sealed override Int64 get_ItemsCount() { }

	// RVA: 0xCFE610
	private CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xCFE618
	private System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xCFE65C
	private void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xCFE698
	private MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xCFE6A4
	private void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xCFE6B0
	internal override bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xCFE6C0
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xCFE8B8
	private bool ReadBinaryCore(int length, int offset, Byte[] result) { }

	// RVA: 0xCFEA00
	private bool ReadStringCore(int length, int offset, string result) { }

	// RVA: 0xCFEBA0
	private bool ReadRawStringCore(int length, int offset, MessagePackString result) { }

	// RVA: 0xCFEEB8
	private bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xCFEF78
	public sealed override bool ReadByte(Byte result) { }

	// RVA: 0xCFF0B0
	private bool ReadByteSlow(ReadValueResult header, Byte[] source, int offset, Byte result) { }

	// RVA: 0xCFF56C
	public sealed override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xCFF744
	private bool ReadNullableByteSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Byte>& result) { }

	// RVA: 0xCFF838
	public sealed override bool ReadSByte(SByte result) { }

	// RVA: 0xCFF964
	private bool ReadSByteSlow(ReadValueResult header, Byte[] source, int offset, SByte result) { }

	// RVA: 0xCFFC7C
	public sealed override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xCFFE48
	private bool ReadNullableSByteSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.SByte>& result) { }

	// RVA: 0xCFFF3C
	public sealed override bool ReadInt16(Int16 result) { }

	// RVA: 0xD0006C
	private bool ReadInt16Slow(ReadValueResult header, Byte[] source, int offset, Int16 result) { }

	// RVA: 0xD00374
	public sealed override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD00544
	private bool ReadNullableInt16Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int16>& result) { }

	// RVA: 0xD00638
	public sealed override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD00774
	private bool ReadUInt16Slow(ReadValueResult header, Byte[] source, int offset, UInt16 result) { }

	// RVA: 0xD00A2C
	public sealed override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD00C08
	private bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD00CFC
	public sealed override bool ReadInt32(int result) { }

	// RVA: 0xD00E2C
	private bool ReadInt32Slow(ReadValueResult header, Byte[] source, int offset, int result) { }

	// RVA: 0xD01130
	public sealed override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD01300
	private bool ReadNullableInt32Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int32>& result) { }

	// RVA: 0xD013F4
	public sealed override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD01530
	private bool ReadUInt32Slow(ReadValueResult header, Byte[] source, int offset, UInt32 result) { }

	// RVA: 0xD01814
	public sealed override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD019F0
	private bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD01AE4
	public sealed override bool ReadInt64(Int64 result) { }

	// RVA: 0xD01C14
	private bool ReadInt64Slow(ReadValueResult header, Byte[] source, int offset, Int64 result) { }

	// RVA: 0xD01F00
	public sealed override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD020D0
	private bool ReadNullableInt64Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Int64>& result) { }

	// RVA: 0xD021C4
	public sealed override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD02300
	private bool ReadUInt64Slow(ReadValueResult header, Byte[] source, int offset, UInt64 result) { }

	// RVA: 0xD025CC
	public sealed override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD027A8
	private bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD0289C
	public sealed override bool ReadSingle(float result) { }

	// RVA: 0xD029D0
	private bool ReadSingleSlow(ReadValueResult header, Byte[] source, int offset, float result) { }

	// RVA: 0xD02C78
	public sealed override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD02E4C
	private bool ReadNullableSingleSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Single>& result) { }

	// RVA: 0xD02F40
	public sealed override bool ReadDouble(Double result) { }

	// RVA: 0xD03074
	private bool ReadDoubleSlow(ReadValueResult header, Byte[] source, int offset, Double result) { }

	// RVA: 0xD03314
	public sealed override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD034E8
	private bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] source, int offset, System.Nullable<System.Double>& result) { }

	// RVA: 0xD035DC
	public sealed override bool ReadBoolean(bool result) { }

	// RVA: 0xD03744
	public sealed override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD03918
	public sealed override bool ReadBinary(Byte[] result) { }

	// RVA: 0xD03D1C
	public sealed override bool ReadString(string result) { }

	// RVA: 0xCFEF18
	private bool ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xD03F28
	private bool ReadObjectCore(bool isDeep, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xD04280
	private bool ReadObjectSlow(ReadValueResult header, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xD05020
	private bool ReadItems(int count, bool isMap, Byte[] source, int offset, MessagePackObject result) { }

	// RVA: 0xD05484
	private bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] source, int offset, MessagePackExtendedTypeObject result) { }

	// RVA: 0xD06168
	protected sealed override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD06220
	public sealed override bool ReadObject(MessagePackObject result) { }

	// RVA: 0xD06284
	protected sealed override bool ReadCore() { }

	// RVA: 0xD05A34
	private void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xD03D08
	private void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD062F0
	private void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD03B24
	private void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xCFF388
	private void ThrowTypeException(Type type, ReadValueResult header) { }

}

// Namespace: MsgPack
internal static class MessagePackCode
{
	// Methods

	// RVA: 0xD064A4
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

	// RVA: 0xD066B8
	internal static Encoding get_Utf8NonBom() { }

	// RVA: 0xD06734
	internal static Encoding get_Utf8NonBomStrict() { }

	// RVA: 0xD067B0
	public static Byte[] EncodeString(string value) { }

	// RVA: 0xD06874
	public static string DecodeStringStrict(Byte[] value) { }

	// RVA: 0xD06940
	public static DateTimeOffset ToDateTimeOffset(Int64 value) { }

	// RVA: 0xD06A20
	public static DateTime ToDateTime(Int64 value) { }

	// RVA: 0xD06AFC
	public static Int64 FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xD06C00
	public static Int64 FromDateTime(DateTime value) { }

	// RVA: 0xD06CEC
	private static void .cctor() { }

}

// Namespace: MsgPack
public struct MessagePackExtendedTypeObject
{
	// Fields
	private readonly Byte _typeCode; // 0x10
	private readonly Byte[] _body; // 0x18

	// Methods

	// RVA: 0xD06DF0
	public Byte get_TypeCode() { }

	// RVA: 0xD06DF8
	internal Byte[] get_Body() { }

	// RVA: 0xD06E88
	public bool get_IsValid() { }

	// RVA: 0xD06E98
	private void .ctor(Byte[] body, Byte unpackedTypeCode) { }

	// RVA: 0xD060E0
	public static MessagePackExtendedTypeObject Unpack(Byte typeCode, Byte[] body) { }

	// RVA: 0xD06F04
	public override string ToString() { }

	// RVA: 0xD06FCC
	internal void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xD07234
	public override int GetHashCode() { }

	// RVA: 0xD073B4
	public override bool Equals(object obj) { }

	// RVA: 0xD074C4
	public bool Equals(MessagePackExtendedTypeObject other) { }

	// RVA: 0xD07550
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

	// RVA: 0xD0E8DC
	public MessagePackValueTypeCode get_TypeCode() { }

	// RVA: 0xD07A8C
	public bool get_IsSigned() { }

	// RVA: 0xD07A7C
	public bool get_IsInteger() { }

	// RVA: 0xD0E8E4
	public Type get_Type() { }

	// RVA: 0xD0E894
	internal void .ctor(Type type, MessagePackValueTypeCode typeCode) { }

	// RVA: 0xD0E8EC
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

	// RVA: 0xD0E988
	private static void .cctor() { }

	// RVA: 0xD0E9F4
	public void .ctor() { }

	// RVA: 0xD0E9FC
	internal int <GetHashCode>b__84_0(int hash, MessagePackObject item) { }

	// RVA: 0xD0EA70
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

	// RVA: 0xD075E0
	public void .ctor(bool value) { }

	// RVA: 0xD0765C
	public void .ctor(int value) { }

	// RVA: 0xD053E4
	public void .ctor(Byte[] value, bool isBinary) { }

	// RVA: 0xD076D8
	public bool AsBoolean() { }

	// RVA: 0xD07830
	public Byte AsByte() { }

	// RVA: 0xD07A98
	public SByte AsSByte() { }

	// RVA: 0xD07CF8
	public Int16 AsInt16() { }

	// RVA: 0xD07F58
	public UInt16 AsUInt16() { }

	// RVA: 0xD04DD0
	public int AsInt32() { }

	// RVA: 0xD08160
	public UInt32 AsUInt32() { }

	// RVA: 0xCFE408
	public Int64 AsInt64() { }

	// RVA: 0xD08370
	public UInt64 AsUInt64() { }

	// RVA: 0xD08570
	public float AsSingle() { }

	// RVA: 0xD08730
	public Double AsDouble() { }

	// RVA: 0xD088F0
	public string AsString() { }

	// RVA: 0xD089C8
	public Byte[] AsBinary() { }

	// RVA: 0xD08AA0
	public MessagePackExtendedTypeObject AsMessagePackExtendedTypeObject() { }

	// RVA: 0xD08BBC
	public static MessagePackObject op_Implicit(bool value) { }

	// RVA: 0xD057D8
	public static MessagePackObject op_Implicit(Byte value) { }

	// RVA: 0xD055BC
	public static MessagePackObject op_Implicit(SByte value) { }

	// RVA: 0xD05644
	public static MessagePackObject op_Implicit(Int16 value) { }

	// RVA: 0xD052CC
	public static MessagePackObject op_Implicit(UInt16 value) { }

	// RVA: 0xD056CC
	public static MessagePackObject op_Implicit(int value) { }

	// RVA: 0xD05354
	public static MessagePackObject op_Implicit(UInt32 value) { }

	// RVA: 0xD05754
	public static MessagePackObject op_Implicit(Int64 value) { }

	// RVA: 0xD05860
	public static MessagePackObject op_Implicit(UInt64 value) { }

	// RVA: 0xD058E4
	public static MessagePackObject op_Implicit(float value) { }

	// RVA: 0xD059B0
	public static MessagePackObject op_Implicit(Double value) { }

	// RVA: 0xD08C44
	public static MessagePackObject op_Implicit(string value) { }

	// RVA: 0xD041F4
	public static MessagePackObject op_Implicit(Byte[] value) { }

	// RVA: 0xD05534
	public static MessagePackObject op_Implicit(MessagePackExtendedTypeObject value) { }

	// RVA: 0xD08CCC
	public static bool op_Explicit(MessagePackObject value) { }

	// RVA: 0xD08DF0
	public static Byte op_Explicit(MessagePackObject value) { }

	// RVA: 0xD08FEC
	public static SByte op_Explicit(MessagePackObject value) { }

	// RVA: 0xD09204
	public static Int16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xD0941C
	public static UInt16 op_Explicit(MessagePackObject value) { }

	// RVA: 0xD09604
	public static int op_Explicit(MessagePackObject value) { }

	// RVA: 0xD0980C
	public static UInt32 op_Explicit(MessagePackObject value) { }

	// RVA: 0xD099FC
	public static Int64 op_Explicit(MessagePackObject value) { }

	// RVA: 0xD09BE4
	public static float op_Explicit(MessagePackObject value) { }

	// RVA: 0xD09D88
	public static Double op_Explicit(MessagePackObject value) { }

	// RVA: 0xD07820
	public bool get_IsNil() { }

	// RVA: 0xD09F2C
	public void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD05B98
	public void .ctor(System.Collections.Generic.IList<MsgPack.MessagePackObject> value, bool isImmutable) { }

	// RVA: 0xD09F98
	public void .ctor(MessagePackObjectDictionary value) { }

	// RVA: 0xD0605C
	public void .ctor(MessagePackObjectDictionary value, bool isImmutable) { }

	// RVA: 0xD053DC
	internal void .ctor(MessagePackString messagePackString) { }

	// RVA: 0xD0A89C
	public override bool Equals(object obj) { }

	// RVA: 0xD0AA1C
	public bool Equals(MessagePackObject other) { }

	// RVA: 0xD0B1F4
	private bool EqualsWhenValueType(MessagePackObject other, ValueTypeCode valueTypeCode, ValueTypeCode otherValuetypeCode) { }

	// RVA: 0xD0B668
	private static bool IntegerIntegerEquals(UInt64 left, ValueTypeCode leftTypeCode, UInt64 right, ValueTypeCode rightTypeCode) { }

	// RVA: 0xD0B6D8
	private static bool IntegerSingleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xD0B7B4
	private static bool IntegerDoubleEquals(MessagePackObject integer, MessagePackObject real) { }

	// RVA: 0xD0B88C
	public override int GetHashCode() { }

	// RVA: 0xD0BB70
	public override string ToString() { }

	// RVA: 0xD0BC18
	private void ToString(StringBuilder buffer, bool isJson) { }

	// RVA: 0xD0C7AC
	private static void ToStringBinary(StringBuilder buffer, bool isJson, MessagePackString asBinary) { }

	// RVA: -1
	public System.Nullable<System.Boolean> IsTypeOf() { }

	// RVA: 0xD0CC10
	public System.Nullable<System.Boolean> IsTypeOf(Type type) { }

	// RVA: 0xD0D2EC
	public bool get_IsRaw() { }

	// RVA: 0xD0D39C
	public Type get_UnderlyingType() { }

	// RVA: 0xD0D4CC
	public void PackToMessage(Packer packer, PackingOptions options) { }

	// RVA: 0xD0E294
	public Char[] AsCharArray() { }

	// RVA: 0x318DB98
	private static void VerifyUnderlyingType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x318DB98
	private static void VerifyUnderlyingRawType(MessagePackObject instance, string parameterName) { }

	// RVA: 0x30D9218
	private static void ThrowCannotBeNilAs() { }

	// RVA: -1
	private static void ThrowInvalidTypeAs(MessagePackObject instance) { }

	// RVA: 0xD0E31C
	public static bool op_Equality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xD0B5E8
	public static bool op_Inequality(MessagePackObject left, MessagePackObject right) { }

	// RVA: 0xD0E398
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

	// RVA: 0xD12278
	public System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> get_Current() { }

	// RVA: 0xD12370
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xD124B4
	private DictionaryEntry System.Collections.IDictionaryEnumerator.get_Entry() { }

	// RVA: 0xD12670
	private object System.Collections.IDictionaryEnumerator.get_Key() { }

	// RVA: 0xD12780
	private object System.Collections.IDictionaryEnumerator.get_Value() { }

	// RVA: 0xD123DC
	internal System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> GetCurrentStrict() { }

	// RVA: 0xD12894
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD122F8
	internal void VerifyVersion() { }

	// RVA: 0xD12A48
	public void Dispose() { }

	// RVA: 0xD12A9C
	public bool MoveNext() { }

	// RVA: 0xD12CDC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xD12980
	internal void ResetCore() { }

}

// Namespace: 
private struct DictionaryEnumerator
{
	// Fields
	private IDictionaryEnumerator _underlying; // 0x10

	// Methods

	// RVA: 0xD12DA4
	public object get_Current() { }

	// RVA: 0xD12E7C
	public DictionaryEntry get_Entry() { }

	// RVA: 0xD12F34
	public object get_Key() { }

	// RVA: 0xD12FEC
	public object get_Value() { }

	// RVA: 0xD1309C
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD13200
	public bool MoveNext() { }

	// RVA: 0xD132B4
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xD13854
	public MessagePackObject get_Current() { }

	// RVA: 0xD13984
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xD13658
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD13A94
	public void Dispose() { }

	// RVA: 0xD13AE8
	public bool MoveNext() { }

	// RVA: 0xD13B60
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
public sealed class KeyCollection
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xD1336C
	public int get_Count() { }

	// RVA: 0xD1338C
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xD13394
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xD1339C
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xD133A0
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD133D4
	public void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xD13474
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xD134F0
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xD13510
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xD13550
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xD13590
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xD135D0
	public Enumerator GetEnumerator() { }

	// RVA: 0xD136CC
	private System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xD13790
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
public struct Enumerator
{
	// Fields
	private Enumerator _underlying; // 0x10

	// Methods

	// RVA: 0xD14110
	public MessagePackObject get_Current() { }

	// RVA: 0xD14244
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0xD13F14
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD14358
	public void Dispose() { }

	// RVA: 0xD143AC
	public bool MoveNext() { }

	// RVA: 0xD14424
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: 
[Serializable]
public sealed class ValueCollection
{
	// Fields
	private readonly MessagePackObjectDictionary _dictionary; // 0x10

	// Methods

	// RVA: 0xD13C28
	public int get_Count() { }

	// RVA: 0xD13C48
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.get_IsReadOnly() { }

	// RVA: 0xD13C50
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xD13C58
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xD13C5C
	internal void .ctor(MessagePackObjectDictionary dictionary) { }

	// RVA: 0xD13C90
	public void CopyTo(MessagePackObject[] array, int arrayIndex) { }

	// RVA: 0xD13D30
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }

	// RVA: 0xD13DAC
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Contains(MessagePackObject item) { }

	// RVA: 0xD13DCC
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Add(MessagePackObject item) { }

	// RVA: 0xD13E0C
	private void System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Clear() { }

	// RVA: 0xD13E4C
	private bool System.Collections.Generic.ICollection<MsgPack.MessagePackObject>.Remove(MessagePackObject item) { }

	// RVA: 0xD13E8C
	public Enumerator GetEnumerator() { }

	// RVA: 0xD13F88
	private System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> System.Collections.Generic.IEnumerable<MsgPack.MessagePackObject>.GetEnumerator() { }

	// RVA: 0xD1404C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <>c__DisplayClass53_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xD144EC
	public void .ctor() { }

	// RVA: 0xD144F4
	internal bool <TryGetValue>b__0(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass55_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xD14578
	public void .ctor() { }

	// RVA: 0xD14580
	internal bool <AddCore>b__0(MessagePackObject item) { }

	// RVA: 0xD14604
	internal bool <AddCore>b__1(MessagePackObject item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass59_0
{
	// Fields
	public MessagePackObject key; // 0x10

	// Methods

	// RVA: 0xD14688
	public void .ctor() { }

	// RVA: 0xD14690
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

	// RVA: 0xD14714
	private static void .cctor() { }

	// RVA: 0xD14780
	public void .ctor() { }

	// RVA: 0xD14788
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

	// RVA: 0xD0EAEC
	public bool get_IsFrozen() { }

	// RVA: 0xD0EAF4
	public int get_Count() { }

	// RVA: 0xD0EB6C
	public MessagePackObject get_Item(MessagePackObject key) { }

	// RVA: 0xD0F044
	public void set_Item(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xD0F718
	public KeyCollection get_Keys() { }

	// RVA: 0xD0F780
	public ValueCollection get_Values() { }

	// RVA: 0xD0F7E8
	private System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Keys() { }

	// RVA: 0xD0F850
	private System.Collections.Generic.ICollection<MsgPack.MessagePackObject> System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject>.get_Values() { }

	// RVA: 0xD0F8B8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.get_IsReadOnly() { }

	// RVA: 0xD0F8C0
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0xD0F8C8
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0xD0F8D0
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0xD0F8D8
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0xD0F940
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0xD0FCD4
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0xD0FE8C
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xD0FE94
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xD0FE98
	public void .ctor() { }

	// RVA: 0xD05D08
	public void .ctor(int initialCapacity) { }

	// RVA: 0xD0A084
	public void .ctor(System.Collections.Generic.IDictionary<MsgPack.MessagePackObject,MsgPack.MessagePackObject> dictionary) { }

	// RVA: 0xD0ED94
	private static void ThrowKeyNotNilException(string parameterName) { }

	// RVA: 0xD0FF50
	private static void ThrowDuplicatedKeyException(MessagePackObject key, string parameterName) { }

	// RVA: 0xD0F1A0
	private void VerifyIsNotFrozen() { }

	// RVA: 0xD0FAC4
	private static MessagePackObject ValidateObjectArgument(object obj, string parameterName) { }

	// RVA: 0xD10088
	private static System.Nullable<MsgPack.MessagePackObject> TryValidateObjectArgument(object value) { }

	// RVA: 0xD10694
	public bool ContainsKey(MessagePackObject key) { }

	// RVA: 0xD1086C
	public bool ContainsValue(MessagePackObject value) { }

	// RVA: 0xD109A8
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Contains(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xD10BD8
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0xD0EDF0
	public bool TryGetValue(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xD05F00
	public void Add(MessagePackObject key, MessagePackObject value) { }

	// RVA: 0xD0F208
	private void AddCore(MessagePackObject key, MessagePackObject value, bool allowOverwrite) { }

	// RVA: 0xD10DA4
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Add(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xD1108C
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0xD11248
	public bool Remove(MessagePackObject key) { }

	// RVA: 0xD11394
	private bool RemoveCore(MessagePackObject key, MessagePackObject value, bool checkValue) { }

	// RVA: 0xD116E4
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.Remove(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject> item) { }

	// RVA: 0xD119CC
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0xD11B64
	public void Clear() { }

	// RVA: 0xD11CE0
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.CopyTo(System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>[] array, int arrayIndex) { }

	// RVA: 0xD11E1C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xD12090
	public Enumerator GetEnumerator() { }

	// RVA: 0xD120B4
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<MsgPack.MessagePackObject,MsgPack.MessagePackObject>>.GetEnumerator() { }

	// RVA: 0xD12158
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD121FC
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

}

// Namespace: MsgPack
[Serializable]
internal sealed class MessagePackObjectEqualityComparer
{
	// Fields
	private static readonly MessagePackObjectEqualityComparer _instance; // 0x0

	// Methods

	// RVA: 0xD14930
	internal static MessagePackObjectEqualityComparer get_Instance() { }

	// RVA: 0xD149AC
	public void .ctor() { }

	// RVA: 0xD149B4
	public bool Equals(MessagePackObject x, MessagePackObject y) { }

	// RVA: 0xD14A34
	public int GetHashCode(MessagePackObject obj) { }

	// RVA: 0xD14A9C
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

	// RVA: 0xD14B08
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD14D6C
	protected override void Dispose(bool disposing) { }

	// RVA: 0xD14DA4
	protected override void WriteByte(Byte value) { }

	// RVA: 0xD14DCC
	protected override void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xD14E34
	protected override void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xD14E00
	private void WriteBytes(Byte[] value) { }

	// RVA: 0xD14F00
	private void WriteBytes(Byte[] value, int startIndex, int count) { }

	// RVA: 0xD14F28
	protected override void PackCore(bool value) { }

	// RVA: 0xD14F54
	protected override void PackCore(Byte value) { }

	// RVA: 0xD1503C
	protected override void PackCore(SByte value) { }

	// RVA: 0xD150C8
	protected override void PackCore(Int16 value) { }

	// RVA: 0xD151F8
	protected override void PackCore(UInt16 value) { }

	// RVA: 0xD1529C
	protected override void PackCore(int value) { }

	// RVA: 0xD15428
	protected override void PackCore(UInt32 value) { }

	// RVA: 0xD154E4
	protected override void PackCore(Int64 value) { }

	// RVA: 0xD15704
	protected override void PackCore(UInt64 value) { }

	// RVA: 0xD157D8
	protected override void PackCore(float value) { }

	// RVA: 0xD15924
	protected override void PackCore(Double value) { }

	// RVA: 0xD15AE0
	protected override void PackArrayHeaderCore(int length) { }

	// RVA: 0xD15B20
	protected override void PackMapHeaderCore(int length) { }

	// RVA: 0xD15B5C
	protected override void PackStringHeaderCore(int length) { }

	// RVA: 0xD15C24
	protected override void PackBinaryHeaderCore(int length) { }

	// RVA: 0xD15CC0
	protected override void PackRawCore(string value) { }

	// RVA: 0xD15DC8
	protected override void PackRawCore(Byte[] value) { }

	// RVA: 0xD15ED0
	protected override void PackBinaryCore(Byte[] value) { }

	// RVA: 0xD15FB4
	protected override void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xD16148
	private void WriteStringHeader(int bytesLength, bool allowStr8) { }

	// RVA: 0xD14FD4
	private void WriteBytes(Byte header, Byte value) { }

	// RVA: 0xD15174
	private void WriteBytes(Byte header, UInt16 value) { }

	// RVA: 0xD1536C
	private void WriteBytes(Byte header, UInt32 value) { }

	// RVA: 0xD155D8
	private void WriteBytes(Byte header, UInt64 value) { }

	// RVA: 0xD157E0
	private void WriteBytes(Byte header, float value) { }

	// RVA: 0xD1592C
	private void WriteBytes(Byte header, Double value) { }

	// RVA: 0xD15D48
	private void WriteBytes(string value, bool allowStr8) { }

	// RVA: 0xD16210
	private void WriteStringBody(string value) { }

	// RVA: 0xD162FC
	private void WriteStringBody(Char[] value, int remainingCharsLength) { }

	// RVA: 0xD163E8
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

	// RVA: 0xD16420
	public sealed override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xD16498
	protected sealed override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD1657C
	public sealed override MessagePackObject get_LastReadData() { }

	// RVA: 0xD16588
	protected sealed override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xD16594
	public sealed override bool get_IsArrayHeader() { }

	// RVA: 0xD165A4
	public sealed override bool get_IsMapHeader() { }

	// RVA: 0xD165B4
	public sealed override Int64 get_ItemsCount() { }

	// RVA: 0xD16640
	public sealed override bool get_IsCollectionHeader() { }

	// RVA: 0xD16650
	private CollectionType MsgPack.IRootUnpacker.get_CollectionType() { }

	// RVA: 0xD16658
	private System.Nullable<MsgPack.MessagePackObject> MsgPack.IRootUnpacker.get_Data() { }

	// RVA: 0xD1669C
	private void MsgPack.IRootUnpacker.set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD166D8
	private MessagePackObject MsgPack.IRootUnpacker.get_LastReadData() { }

	// RVA: 0xD166E4
	private void MsgPack.IRootUnpacker.set_LastReadData(MessagePackObject value) { }

	// RVA: 0xD166F0
	internal override bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xD16700
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD16898
	protected override void Dispose(bool disposing) { }

	// RVA: 0xD16904
	protected void BeginReadSubtree() { }

	// RVA: 0xD16914
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD16944
	private bool ReadBinaryCore(int length, Int64 offset, Byte[] result) { }

	// RVA: 0xD16C54
	private bool ReadStringCore(int length, Int64 offset, string result) { }

	// RVA: 0xD16F2C
	private bool ReadRawStringCore(int length, Int64 offset, MessagePackString result) { }

	// RVA: 0xD17254
	private bool MsgPack.IRootUnpacker.ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xD16AEC
	private void ThrowEofException(Int64 reading) { }

	// RVA: 0xD1731C
	public sealed override bool ReadByte(Byte result) { }

	// RVA: 0xD17468
	private bool ReadByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, Byte result) { }

	// RVA: 0xD17984
	public sealed override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD17B70
	private bool ReadNullableByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Byte>& result) { }

	// RVA: 0xD17C64
	public sealed override bool ReadSByte(SByte result) { }

	// RVA: 0xD17DA4
	private bool ReadSByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, SByte result) { }

	// RVA: 0xD18114
	public sealed override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD182F4
	private bool ReadNullableSByteSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.SByte>& result) { }

	// RVA: 0xD183E8
	public sealed override bool ReadInt16(Int16 result) { }

	// RVA: 0xD1852C
	private bool ReadInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, Int16 result) { }

	// RVA: 0xD1889C
	public sealed override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD18A80
	private bool ReadNullableInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int16>& result) { }

	// RVA: 0xD18B74
	public sealed override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD18CC4
	private bool ReadUInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt16 result) { }

	// RVA: 0xD1900C
	public sealed override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD191FC
	private bool ReadNullableUInt16Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD192F0
	public sealed override bool ReadInt32(int result) { }

	// RVA: 0xD19420
	private bool ReadInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, int result) { }

	// RVA: 0xD19784
	public sealed override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD19968
	private bool ReadNullableInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int32>& result) { }

	// RVA: 0xD19A5C
	public sealed override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD19B98
	private bool ReadUInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt32 result) { }

	// RVA: 0xD19ED8
	public sealed override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD1A0C8
	private bool ReadNullableUInt32Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD1A1BC
	public sealed override bool ReadInt64(Int64 result) { }

	// RVA: 0xD1A300
	private bool ReadInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, Int64 result) { }

	// RVA: 0xD1A650
	public sealed override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD1A834
	private bool ReadNullableInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Int64>& result) { }

	// RVA: 0xD1A928
	public sealed override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD1AA78
	private bool ReadUInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, UInt64 result) { }

	// RVA: 0xD1ADA8
	public sealed override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD1AF98
	private bool ReadNullableUInt64Slow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD1B08C
	public sealed override bool ReadSingle(float result) { }

	// RVA: 0xD1B1D4
	private bool ReadSingleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, float result) { }

	// RVA: 0xD1B4D8
	public sealed override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD1B6C0
	private bool ReadNullableSingleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Single>& result) { }

	// RVA: 0xD1B7B4
	public sealed override bool ReadDouble(Double result) { }

	// RVA: 0xD1B8FC
	private bool ReadDoubleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, Double result) { }

	// RVA: 0xD1BBF8
	public sealed override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD1BDE0
	private bool ReadNullableDoubleSlow(ReadValueResult header, Byte[] buffer, Int64 offset, System.Nullable<System.Double>& result) { }

	// RVA: 0xD1BED4
	public sealed override bool ReadBoolean(bool result) { }

	// RVA: 0xD1C050
	public sealed override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD1C238
	public sealed override bool ReadBinary(Byte[] result) { }

	// RVA: 0xD1C770
	public sealed override bool ReadString(string result) { }

	// RVA: 0xD172B8
	private bool ReadObject(bool isDeep, MessagePackObject result) { }

	// RVA: 0xD1CAB4
	private bool ReadObjectCore(bool isDeep, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xD1CD30
	private bool ReadObjectSlow(ReadValueResult header, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xD1DB58
	private bool ReadItems(int count, bool isMap, Byte[] buffer, Int64 offset, MessagePackObject result) { }

	// RVA: 0xD1DDD8
	private bool ReadMessagePackExtendedTypeObjectCore(int length, Byte[] buffer, Int64 offset, MessagePackExtendedTypeObject result) { }

	// RVA: 0xD1E034
	protected sealed override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD1E0EC
	public sealed override bool ReadObject(MessagePackObject result) { }

	// RVA: 0xD1E154
	protected sealed override bool ReadCore() { }

	// RVA: 0xD1DED0
	private void ThrowUnassignedMessageTypeException(int header) { }

	// RVA: 0xD1C75C
	private void CheckLength(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD1E1C4
	private void ThrowTooLongLengthException(UInt32 length, ReadValueResult type) { }

	// RVA: 0xD1C57C
	private void ThrowTypeException(string type, ReadValueResult header) { }

	// RVA: 0xD177A4
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

	// RVA: 0xD17158
	public void .ctor(string decoded) { }

	// RVA: 0xD17198
	public void .ctor(Byte[] encoded, bool isBinary) { }

	// RVA: 0xD1E6BC
	private void EncodeIfNeeded() { }

	// RVA: 0xD1E7C4
	private void DecodeIfNeeded() { }

	// RVA: 0xD1E910
	public string TryGetString() { }

	// RVA: 0xD1E934
	public string GetString() { }

	// RVA: 0xD1E9F4
	public Byte[] UnsafeGetBuffer() { }

	// RVA: 0xD1E9FC
	public Byte[] GetBytes() { }

	// RVA: 0xD1EA20
	public Type GetUnderlyingType() { }

	// RVA: 0xD1EAE8
	public override string ToString() { }

	// RVA: 0xD1EBA0
	public override int GetHashCode() { }

	// RVA: 0xD1EE0C
	public override bool Equals(object obj) { }

	// RVA: 0xD1EEF0
	private static bool EqualsEncoded(MessagePackString left, MessagePackString right) { }

	// RVA: 0xD1F060
	private static bool SlowEquals(Byte[] x, Byte[] y) { }

	// RVA: 0xD1F0E8
	private static void .cctor() { }

}

// Namespace: MsgPack
[Serializable]
public class MessageTypeException
{
	// Methods

	// RVA: 0xD1F188
	public void .ctor() { }

	// RVA: 0xD1E628
	public void .ctor(string message) { }

	// RVA: 0xD1F20C
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xD1F2A4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

}

// Namespace: MsgPack
internal sealed class PureAttribute
{
	// Methods

	// RVA: 0xD1F328
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

	// RVA: 0xD1F330
	public static PackerCompatibilityOptions get_DefaultCompatibilityOptions() { }

	// RVA: 0xD1F394
	public PackerCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xD14C80
	protected void .ctor(PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD1F39C
	public void Dispose() { }

	// RVA: 0xD14DA0
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD1F434
	private void VerifyNotDisposed() { }

	// RVA: 0xD1F49C
	private void ThrowObjectDisposedException() { }

	// RVA: -1
	protected abstract void WriteByte(Byte value) { }

	// RVA: 0xD1F4F0
	protected virtual void WriteBytes(System.Collections.Generic.ICollection<System.Byte> value) { }

	// RVA: 0xD1F868
	protected virtual void WriteBytes(Byte[] value, bool isImmutable) { }

	// RVA: 0xD1F954
	public Packer Pack(SByte value) { }

	// RVA: 0xD1F9D4
	protected virtual void PackCore(SByte value) { }

	// RVA: 0xD1FA64
	protected bool TryPackInt8(Int64 value) { }

	// RVA: 0xD1FAC4
	public Packer Pack(Byte value) { }

	// RVA: 0xD1FB44
	protected virtual void PackCore(Byte value) { }

	// RVA: 0xD1FB50
	protected bool TryPackUInt8(UInt64 value) { }

	// RVA: 0xD1FBA4
	public Packer Pack(bool value) { }

	// RVA: 0xD1FC24
	protected virtual void PackCore(bool value) { }

	// RVA: 0xD1FA28
	protected bool TryPackTinySignedInteger(Int64 value) { }

	// RVA: 0xD1FC50
	protected bool TryPackTinyUnsignedInteger(UInt64 value) { }

	// RVA: 0xD1FC8C
	public Packer PackNull() { }

	// RVA: 0xD1FD10
	private void PrivatePackNullCore() { }

	// RVA: 0xD1F820
	private static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xD1FD20
	private static void ThrowCannotBeNegativeException(string parameterName) { }

	// RVA: 0xD1FDE8
	private static void ThrowMissingBodyOfExtTypeValueException(string parameterName) { }

	// RVA: 0xD1FE44
	private static void ThrowExtTypeIsProhibitedException() { }

	// RVA: 0xD1FE98
	public static Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD20088
	public static Packer Create(Stream stream, bool ownsStream) { }

	// RVA: 0xD1FFA8
	public static Packer Create(Stream stream, PackerCompatibilityOptions compatibilityOptions, bool ownsStream) { }

	// RVA: 0xD2015C
	public static ByteArrayPacker Create(Byte[] buffer, bool allowsBufferExpansion, PackerCompatibilityOptions compatibilityOptions) { }

	// RVA: 0xD2023C
	public Packer Pack(System.Nullable<System.SByte> value) { }

	// RVA: 0xD2038C
	public Packer Pack(System.Nullable<System.Byte> value) { }

	// RVA: 0xD204C0
	public Packer Pack(System.Nullable<System.Int16> value) { }

	// RVA: 0xD20690
	public Packer Pack(System.Nullable<System.UInt16> value) { }

	// RVA: 0xD2084C
	public Packer Pack(System.Nullable<System.Int32> value) { }

	// RVA: 0xD20A08
	public Packer Pack(System.Nullable<System.UInt32> value) { }

	// RVA: 0xD20BC4
	public Packer Pack(System.Nullable<System.Int64> value) { }

	// RVA: 0xD20D98
	public Packer Pack(System.Nullable<System.UInt64> value) { }

	// RVA: 0xD20F6C
	public Packer Pack(System.Nullable<System.Single> value) { }

	// RVA: 0xD21140
	public Packer Pack(System.Nullable<System.Double> value) { }

	// RVA: 0xD21314
	public Packer Pack(System.Nullable<System.Boolean> value) { }

	// RVA: 0xD20610
	public Packer Pack(Int16 value) { }

	// RVA: 0xD21450
	protected virtual void PackCore(Int16 value) { }

	// RVA: 0xD214CC
	protected bool TryPackInt16(Int64 value) { }

	// RVA: 0xD207C8
	public Packer Pack(UInt16 value) { }

	// RVA: 0xD21540
	protected virtual void PackCore(UInt16 value) { }

	// RVA: 0xD215B0
	protected bool TryPackUInt16(UInt64 value) { }

	// RVA: 0xD20984
	public Packer Pack(int value) { }

	// RVA: 0xD21618
	protected virtual void PackCore(int value) { }

	// RVA: 0xD216D0
	protected bool TryPackInt32(Int64 value) { }

	// RVA: 0xD20B40
	public Packer Pack(UInt32 value) { }

	// RVA: 0xD21774
	protected virtual void PackCore(UInt32 value) { }

	// RVA: 0xD21824
	protected bool TryPackUInt32(UInt64 value) { }

	// RVA: 0xD20D14
	public Packer Pack(Int64 value) { }

	// RVA: 0xD218BC
	protected virtual void PackCore(Int64 value) { }

	// RVA: 0xD219D4
	protected bool TryPackInt64(Int64 value) { }

	// RVA: 0xD20EE8
	public Packer Pack(UInt64 value) { }

	// RVA: 0xD21AA8
	protected virtual void PackCore(UInt64 value) { }

	// RVA: 0xD21BBC
	protected bool TryPackUInt64(UInt64 value) { }

	// RVA: 0xD210BC
	public Packer Pack(float value) { }

	// RVA: 0xD21C90
	protected virtual void PackCore(float value) { }

	// RVA: 0xD21290
	public Packer Pack(Double value) { }

	// RVA: 0xD21D34
	protected virtual void PackCore(Double value) { }

	// RVA: 0xD21E0C
	public Packer PackArrayHeader(int count) { }

	// RVA: 0xD21EF8
	protected virtual void PackArrayHeaderCore(int count) { }

	// RVA: 0xD21FA0
	public Packer PackMapHeader(int count) { }

	// RVA: 0xD2208C
	protected virtual void PackMapHeaderCore(int count) { }

	// RVA: 0xD22130
	public Packer PackStringHeader(int length) { }

	// RVA: 0xD2221C
	public Packer PackBinaryHeader(int length) { }

	// RVA: 0xD2232C
	protected virtual void PackStringHeaderCore(int length) { }

	// RVA: 0xD22400
	protected virtual void PackBinaryHeaderCore(int length) { }

	// RVA: 0xD224A8
	public Packer PackRaw(Byte[] value) { }

	// RVA: 0xD22554
	protected virtual void PackRawCore(Byte[] value) { }

	// RVA: 0xD225A4
	public Packer PackBinary(Byte[] value) { }

	// RVA: 0xD2267C
	protected virtual void PackBinaryCore(Byte[] value) { }

	// RVA: 0xD226CC
	public Packer PackString(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xD2286C
	public Packer PackString(string value) { }

	// RVA: 0xD228C4
	protected virtual void PackStringCore(string value, Encoding encoding) { }

	// RVA: 0xD22A20
	protected virtual void PackRawCore(string value) { }

	// RVA: 0xD227B4
	private void PackRawCore(System.Collections.Generic.IEnumerable<System.Char> value) { }

	// RVA: 0xD22A60
	public Packer PackRawBody(Byte[] value) { }

	// RVA: 0xD22B80
	public Packer PackRawBody(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xD22C98
	private int PrivatePackRawBodyCore(System.Collections.Generic.IEnumerable<System.Byte> value) { }

	// RVA: 0xD23018
	private int PrivatePackRawBodyCore(System.Collections.Generic.ICollection<System.Byte> value, bool isImmutable) { }

	// RVA: 0xD23120
	public Packer PackExtendedTypeValue(Byte typeCode, Byte[] body) { }

	// RVA: 0xD232B0
	public Packer PackExtendedTypeValue(MessagePackExtendedTypeObject mpeto) { }

	// RVA: 0xD2341C
	protected virtual void PackExtendedTypeValueCore(Byte typeCode, Byte[] body) { }

	// RVA: 0xD2355C
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

	// RVA: 0x318DB98
	public static Packer Pack(Packer source, T value) { }

	// RVA: 0x318DB98
	private static void PackCore(Packer source, T value, SerializationContext context) { }

	// RVA: 0xD235B0
	public static Packer PackObject(Packer source, object value) { }

	// RVA: 0xD23750
	public static Packer PackObject(Packer source, object value, SerializationContext context) { }

	// RVA: 0xD23678
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

	// RVA: 0xD237E4
	private static bool ShouldWrapStream(Stream stream) { }

	// RVA: 0xD238A8
	public bool get_WithBuffering() { }

	// RVA: 0xD238B0
	public void set_WithBuffering(bool value) { }

	// RVA: 0xD238B8
	public bool get_OwnsStream() { }

	// RVA: 0xD238C0
	public void set_OwnsStream(bool value) { }

	// RVA: 0xD238C8
	public void .ctor() { }

	// RVA: 0xD14CAC
	internal Stream WrapStream(Stream stream) { }

	// RVA: 0xD238D8
	private static void .cctor() { }

}

// Namespace: MsgPack
public sealed class PackingOptions
{
	// Fields
	private Encoding _stringEncoding; // 0x10

	// Methods

	// RVA: 0xD23AC0
	public void .ctor() { }

}

// Namespace: MsgPack
internal sealed class PreserveAttribute
{
	// Fields
	public bool AllMembers; // 0x10

	// Methods

	// RVA: 0xD23B94
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

	// RVA: 0xD24848
	private static void .cctor() { }

	// RVA: 0xD248B4
	public void .ctor() { }

	// RVA: 0xD248BC
	internal ReadValueResult <.cctor>b__5_0(int i) { }

	// RVA: 0xD248C4
	internal ReadValueResult <.cctor>b__5_1(int i) { }

	// RVA: 0xD248D4
	internal ReadValueResult <.cctor>b__5_2(int i) { }

	// RVA: 0xD248E4
	internal ReadValueResult <.cctor>b__5_3(int i) { }

	// RVA: 0xD248F0
	internal ReadValueResult <.cctor>b__5_4(int b) { }

	// RVA: 0xD248F8
	internal MessagePackObject <.cctor>b__5_5(int x) { }

	// RVA: 0xD24924
	internal MessagePackObject <.cctor>b__5_6(int x) { }

	// RVA: 0xD24950
	internal MessagePackObject <.cctor>b__5_7(int x) { }

	// RVA: 0xD2497C
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

	// RVA: 0xD1E37C
	public static Byte ToByte(ReadValueResult source) { }

	// RVA: 0xD23B9C
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class ReflectionAbstractions
{
	// Fields
	public static readonly Char TypeDelimiter; // 0x0
	public static readonly Type[] EmptyTypes; // 0x8

	// Methods

	// RVA: 0xD249A8
	public static bool GetIsValueType(Type source) { }

	// RVA: 0xD249C0
	public static bool GetIsEnum(Type source) { }

	// RVA: 0xD249E4
	public static bool GetIsInterface(Type source) { }

	// RVA: 0xD249FC
	public static bool GetIsAbstract(Type source) { }

	// RVA: 0xD24A14
	public static bool GetIsGenericType(Type source) { }

	// RVA: 0xD24A38
	public static bool GetIsGenericTypeDefinition(Type source) { }

	// RVA: 0xD24A5C
	public static Assembly GetAssembly(Type source) { }

	// RVA: 0xD24A80
	public static bool GetIsVisible(Type source) { }

	// RVA: 0xD24A98
	public static bool GetIsNestedPublic(Type source) { }

	// RVA: 0xD24AB0
	public static Type GetBaseType(Type source) { }

	// RVA: 0xD24AD4
	public static MethodInfo GetRuntimeMethod(Type source, string name, Type[] parameters) { }

	// RVA: 0xD24AFC
	public static System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetRuntimeMethods(Type source) { }

	// RVA: 0xD24B24
	public static Delegate CreateDelegate(MethodInfo source, Type delegateType) { }

	// RVA: 0xD24B38
	public static Delegate CreateDelegate(MethodInfo source, Type delegateType, object target) { }

	// RVA: 0xD24B50
	public static string GetCultureName(AssemblyName source) { }

	// RVA: 0xD24B80
	public static bool GetHasDefaultValue(ParameterInfo source) { }

	// RVA: 0xD24C08
	private static void .cctor() { }

}

// Namespace: MsgPack
internal sealed class SingleArrayBufferAllocator
{
	// Fields
	public static readonly SingleArrayBufferAllocator Default; // 0x0
	private readonly System.Func<System.Byte[],System.Int32,System.Byte[]> _allocator; // 0x10

	// Methods

	// RVA: 0xD24C90
	public void .ctor(System.Func<System.Byte[],System.Int32,System.Byte[]> allocator) { }

	// RVA: 0xD24CC4
	private static Byte[] Allocate(Byte[] old, int requestSize) { }

	// RVA: 0xD24DDC
	public override bool TryAllocate(Byte[] oldBuffer, int requestSize, Byte[] newBuffer) { }

	// RVA: 0xD24EA8
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class StringEscape
{
	// Methods

	// RVA: 0xD24F70
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

	// RVA: 0xD2527C
	public override Int64 get_ItemsCount() { }

	// RVA: 0xD25348
	public override bool get_IsArrayHeader() { }

	// RVA: 0xD253F8
	public override bool get_IsMapHeader() { }

	// RVA: 0xD254A8
	public override bool get_IsCollectionHeader() { }

	// RVA: 0xD25558
	public override System.Nullable<MsgPack.MessagePackObject> get_Data() { }

	// RVA: 0xD2562C
	protected override void set_Data(System.Nullable<MsgPack.MessagePackObject> value) { }

	// RVA: 0xD25714
	public override MessagePackObject get_LastReadData() { }

	// RVA: 0xD257CC
	protected override void set_LastReadData(MessagePackObject value) { }

	// RVA: 0xD2588C
	public void .ctor(Unpacker parent) { }

	// RVA: 0xD25894
	private void .ctor(Unpacker root, SubtreeUnpacker parent) { }

	// RVA: 0xD25BC0
	protected override void Dispose(bool disposing) { }

	// RVA: 0xD25C3C
	public override void Drain() { }

	// RVA: 0xD25C7C
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD25EC8
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD26074
	private static void ThrowInTailException() { }

	// RVA: 0xD260C8
	private static void ThrowNotInHeadOfCollectionException() { }

	// RVA: 0xD2611C
	protected override bool ReadCore() { }

	// RVA: 0xD263A0
	protected override System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD25D50
	private void DiscardCompletedStacks() { }

	// RVA: 0xD26500
	public override bool ReadBoolean(bool result) { }

	// RVA: 0xD267D4
	public override bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD26AA8
	public override bool ReadByte(Byte result) { }

	// RVA: 0xD26D7C
	public override bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD27050
	public override bool ReadSByte(SByte result) { }

	// RVA: 0xD27324
	public override bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD275F8
	public override bool ReadInt16(Int16 result) { }

	// RVA: 0xD278CC
	public override bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD27BA0
	public override bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD27E74
	public override bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD28148
	public override bool ReadInt32(int result) { }

	// RVA: 0xD2841C
	public override bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD286F0
	public override bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD289C4
	public override bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD28C98
	public override bool ReadInt64(Int64 result) { }

	// RVA: 0xD28F6C
	public override bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD29240
	public override bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD29514
	public override bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD297E8
	public override bool ReadSingle(float result) { }

	// RVA: 0xD29ABC
	public override bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD29D90
	public override bool ReadDouble(Double result) { }

	// RVA: 0xD2A064
	public override bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD2A338
	public override bool ReadBinary(Byte[] result) { }

	// RVA: 0xD2A5FC
	public override bool ReadString(string result) { }

	// RVA: 0xD2A8C0
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

	// RVA: 0xD2C738
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

	// RVA: 0xD2ABF8
	public int CompareTo(Timestamp other) { }

	// RVA: 0xD2AC60
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0xD2ADD0
	public override bool Equals(object obj) { }

	// RVA: 0xD2AEB0
	public bool Equals(Timestamp other) { }

	// RVA: 0xD2AED4
	public override int GetHashCode() { }

	// RVA: 0xD2AF28
	private Int64 ToTicks(Type destination) { }

	// RVA: 0xD2B0C0
	public DateTime ToDateTime() { }

	// RVA: 0xD2B198
	public DateTimeOffset ToDateTimeOffset() { }

	// RVA: 0xD2B2A0
	public MessagePackExtendedTypeObject Encode() { }

	// RVA: 0xD2B508
	private static void FromDateTimeTicks(Int64 ticks, Int64 unixEpocSeconds, int nanoSeconds) { }

	// RVA: 0xD2B590
	private static void FromOffsetTicks(Int64 ticks, Int64 unixEpocSeconds, int nanoSeconds) { }

	// RVA: 0xD2B750
	public static Timestamp FromDateTime(DateTime value) { }

	// RVA: 0xD2B9E8
	public static Timestamp FromDateTimeOffset(DateTimeOffset value) { }

	// RVA: 0xD2BB68
	public static Timestamp Decode(MessagePackExtendedTypeObject value) { }

	// RVA: 0xD2BD60
	public static Timestamp op_Implicit(DateTimeOffset value) { }

	// RVA: 0xD2B95C
	public void .ctor(Int64 unixEpochSeconds, int nanoseconds) { }

	// RVA: 0xD2B6D4
	internal static Int64 DivRem(Int64 dividend, Int64 divisor, Int64 remainder) { }

	// RVA: 0xD2BDEC
	public int get_Hour() { }

	// RVA: 0xD2BF48
	public int get_Minute() { }

	// RVA: 0xD2C0A4
	public int get_Second() { }

	// RVA: 0xD2C0DC
	private void GetDatePart(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD2C438
	private void GetDatePartAD(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD2C1B8
	private void GetDatePartBC(Int64 year, int month, int day, int dayOfYear) { }

	// RVA: 0xD2C664
	public override string ToString() { }

	// RVA: 0xD2C6EC
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0xD2C9E8
	private static void .cctor() { }

}

// Namespace: MsgPack
internal static class TimestampStringConverter
{
	// Methods

	// RVA: 0xD2C8B0
	public static string ToString(string format, IFormatProvider formatProvider, Value value) { }

	// RVA: 0xD2CBF0
	private static string ToIso8601String(IFormatProvider formatProvider, bool containsNanosecons, Value value) { }

}

// Namespace: MsgPack
[Serializable]
public sealed class UnassignedMessageTypeException
{
	// Methods

	// RVA: 0xD2CE3C
	public void .ctor() { }

	// RVA: 0xD2CE98
	public void .ctor(string message) { }

	// RVA: 0xD2CF00
	public void .ctor(string message, Exception inner) { }

	// RVA: 0xD2CF74
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

	// RVA: 0xD2D918
	public void .ctor(int <>1__state) { }

	// RVA: 0xD2FE68
	private void System.IDisposable.Dispose() { }

	// RVA: 0xD2FE6C
	private bool MoveNext() { }

	// RVA: 0xD2FF54
	private MessagePackObject System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject>.get_Current() { }

	// RVA: 0xD2FF60
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0xD2FFA0
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

	// RVA: 0xD2CF7C
	public virtual MessagePackObject get_LastReadData() { }

	// RVA: 0xD2D074
	protected virtual void set_LastReadData(MessagePackObject value) { }

	// RVA: -1
	public abstract bool get_IsArrayHeader() { }

	// RVA: -1
	public abstract bool get_IsMapHeader() { }

	// RVA: 0xD2D11C
	public virtual bool get_IsCollectionHeader() { }

	// RVA: -1
	public abstract Int64 get_ItemsCount() { }

	// RVA: 0xD2D164
	internal void VerifyMode(UnpackerMode mode) { }

	// RVA: 0xD2D1B0
	internal void VerifyIsNotDisposed() { }

	// RVA: 0xD2D320
	private void ThrowObjectDisposedException() { }

	// RVA: 0xD2D234
	internal void ThrowInvalidModeException() { }

	// RVA: 0xD2D38C
	internal virtual bool GetPreviousPosition(Int64 offsetOrPosition) { }

	// RVA: 0xD2D39C
	public static Unpacker Create(Stream stream, bool ownsStream) { }

	// RVA: 0xD2D480
	public static Unpacker Create(Stream stream, PackerUnpackerStreamOptions streamOptions, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD2D528
	public static ByteArrayUnpacker Create(Byte[] source, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD2D5BC
	public static ByteArrayUnpacker Create(Byte[] source, int startOffset, UnpackerOptions unpackerOptions) { }

	// RVA: 0xD2D664
	protected void .ctor() { }

	// RVA: 0xD2D66C
	public void Dispose() { }

	// RVA: 0xD2D700
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xD2D704
	public virtual void Drain() { }

	// RVA: 0xD2D708
	public Unpacker ReadSubtree() { }

	// RVA: 0xD2D718
	internal virtual Unpacker InternalReadSubtree() { }

	// RVA: 0xD2D728
	internal static void ThrowCannotBeSubtreeModeException() { }

	// RVA: 0xD2D77C
	internal static void ThrowInSubtreeModeException() { }

	// RVA: -1
	protected abstract Unpacker ReadSubtreeCore() { }

	// RVA: 0xD2D7D0
	protected internal virtual void EndReadSubtree() { }

	// RVA: 0xD2D7E0
	public bool Read() { }

	// RVA: 0xD2D848
	internal bool ReadInternal() { }

	// RVA: 0xD2D89C
	internal virtual void EnsureNotInSubtreeMode() { }

	// RVA: 0xD2D7D8
	private void SetStable() { }

	// RVA: -1
	protected abstract bool ReadCore() { }

	// RVA: 0xD2D8A0
	public System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> GetEnumerator() { }

	// RVA: 0xD2D944
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD2D9BC
	public System.Nullable<System.Int64> Skip() { }

	// RVA: 0xD2DA94
	private void BeginSkip() { }

	// RVA: 0xD2DAD0
	private void EndSkip(System.Nullable<System.Int64> result) { }

	// RVA: -1
	protected abstract System.Nullable<System.Int64> SkipCore() { }

	// RVA: 0xD2DB60
	public MessagePackObject ReadItemData() { }

	// RVA: 0xD2DCA4
	internal virtual void ThrowEofException() { }

	// RVA: 0xD2DC38
	public MessagePackObject UnpackSubtreeData() { }

	// RVA: 0xD2DCF8
	internal bool UnpackSubtreeDataCore(MessagePackObject result) { }

	// RVA: 0xD2E274
	public virtual bool ReadBoolean(bool result) { }

	// RVA: 0xD2E350
	public virtual bool ReadNullableBoolean(System.Nullable<System.Boolean>& result) { }

	// RVA: 0xD2E4A8
	public virtual bool ReadByte(Byte result) { }

	// RVA: 0xD2E584
	public virtual bool ReadNullableByte(System.Nullable<System.Byte>& result) { }

	// RVA: 0xD2E6DC
	public virtual bool ReadSByte(SByte result) { }

	// RVA: 0xD2E7B8
	public virtual bool ReadNullableSByte(System.Nullable<System.SByte>& result) { }

	// RVA: 0xD2E910
	public virtual bool ReadInt16(Int16 result) { }

	// RVA: 0xD2E9EC
	public virtual bool ReadNullableInt16(System.Nullable<System.Int16>& result) { }

	// RVA: 0xD2EB60
	public virtual bool ReadUInt16(UInt16 result) { }

	// RVA: 0xD2EC3C
	public virtual bool ReadNullableUInt16(System.Nullable<System.UInt16>& result) { }

	// RVA: 0xD2EDB0
	public virtual bool ReadInt32(int result) { }

	// RVA: 0xD2EE8C
	public virtual bool ReadNullableInt32(System.Nullable<System.Int32>& result) { }

	// RVA: 0xD2F004
	public virtual bool ReadUInt32(UInt32 result) { }

	// RVA: 0xD2F0E0
	public virtual bool ReadNullableUInt32(System.Nullable<System.UInt32>& result) { }

	// RVA: 0xD2F258
	public virtual bool ReadInt64(Int64 result) { }

	// RVA: 0xD2F33C
	public virtual bool ReadNullableInt64(System.Nullable<System.Int64>& result) { }

	// RVA: 0xD2F4B8
	public virtual bool ReadUInt64(UInt64 result) { }

	// RVA: 0xD2F59C
	public virtual bool ReadNullableUInt64(System.Nullable<System.UInt64>& result) { }

	// RVA: 0xD2F718
	public virtual bool ReadSingle(float result) { }

	// RVA: 0xD2F7F8
	public virtual bool ReadNullableSingle(System.Nullable<System.Single>& result) { }

	// RVA: 0xD2F970
	public virtual bool ReadDouble(Double result) { }

	// RVA: 0xD2FA50
	public virtual bool ReadNullableDouble(System.Nullable<System.Double>& result) { }

	// RVA: 0xD2FBCC
	public virtual bool ReadBinary(Byte[] result) { }

	// RVA: 0xD2FCC4
	public virtual bool ReadString(string result) { }

	// RVA: 0xD2FDBC
	public virtual bool ReadObject(MessagePackObject result) { }

}

// Namespace: MsgPack
internal sealed class FastStreamUnpacker
{
	// Methods

	// RVA: 0xD2D520
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD30008
	protected override Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingStreamUnpacker
{
	// Fields
	private bool _isSubtreeReading; // 0x60

	// Methods

	// RVA: 0xD2D518
	public void .ctor(Stream stream, PackerUnpackerStreamOptions streamOptions) { }

	// RVA: 0xD30030
	internal override Unpacker InternalReadSubtree() { }

	// RVA: 0xD30118
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD30180
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD3018C
	internal override void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
internal sealed class FastByteArrayUnpacker
{
	// Methods

	// RVA: 0xD2D65C
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xD3021C
	protected override Unpacker ReadSubtreeCore() { }

}

// Namespace: MsgPack
internal sealed class CollectionValidatingByteArrayUnpacker
{
	// Fields
	private bool _isSubtreeReading; // 0x48

	// Methods

	// RVA: 0xD2D654
	public void .ctor(Byte[] source, int startOffset) { }

	// RVA: 0xD30220
	internal override Unpacker InternalReadSubtree() { }

	// RVA: 0xD30308
	protected override Unpacker ReadSubtreeCore() { }

	// RVA: 0xD30370
	protected internal override void EndReadSubtree() { }

	// RVA: 0xD3037C
	internal override void EnsureNotInSubtreeMode() { }

}

// Namespace: MsgPack
public sealed class UnpackerOptions
{
	// Fields
	private UnpackerValidationLevel <ValidationLevel>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD3040C
	public UnpackerValidationLevel get_ValidationLevel() { }

	// RVA: 0xD30414
	public void set_ValidationLevel(UnpackerValidationLevel value) { }

	// RVA: 0xD3041C
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

	// RVA: 0xD30448
	public static int Read(int field) { }

	// RVA: 0xD30450
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

	// RVA: 0xD30458
	public CollectionKind get_CollectionType() { }

	// RVA: 0xD30504
	public void .ctor(CollectionDetailedKind type, Type elementType, MethodInfo getEnumeratorMethod, MethodInfo addMethod, MethodInfo countPropertyGetter) { }

	// RVA: 0xD30570
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

	// RVA: 0xD306C0
	public string get_Name() { }

	// RVA: 0xD306C8
	public int get_Id() { }

	// RVA: 0xD306D0
	public NilImplication get_NilImplication() { }

	// RVA: 0xD306D8
	public void .ctor() { }

	// RVA: 0xD30714
	public void .ctor(MemberInfo member) { }

	// RVA: 0xD3076C
	public void .ctor(MemberInfo member, string name, NilImplication nilImplication, System.Nullable<System.Int32> id) { }

	// RVA: 0xD30ADC
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

	// RVA: 0xD30B60
	public static DateTimeConversionMethod DetermineDateTimeConversionMethod(SerializationContext context, DateTimeMemberConversionMethod dateTimeMemberConversionMethod) { }

	// RVA: 0xD30BE4
	internal static bool IsDateTime(Type dateTimeType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DefaultConcreteTypeRepository
{
	// Fields
	private readonly TypeKeyRepository _defaultCollectionTypes; // 0x10

	// Methods

	// RVA: 0xD30DA8
	internal void .ctor() { }

	// RVA: 0xD312DC
	public Type Get(Type abstractCollectionType) { }

	// RVA: 0xD31438
	internal Type GetConcreteType(Type abstractCollectionType) { }

}

// Namespace: MsgPack.Serialization
public sealed class DictionarySerlaizationOptions
{
	// Fields
	private bool _omitNullEntry; // 0x10
	private System.Func<System.String,System.String> _keyNameHandler; // 0x18

	// Methods

	// RVA: 0xD31544
	public bool get_OmitNullEntry() { }

	// RVA: 0xD31568
	public System.Func<System.String,System.String> get_KeyTransformer() { }

	// RVA: 0xD3158C
	internal System.Func<System.String,System.String> get_SafeKeyTransformer() { }

	// RVA: 0xD31630
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

	// RVA: 0xD31638
	protected void .ctor(SerializationContext ownerContext, Type targetType, EnumSerializationMethod serializationMethod) { }

	// RVA: 0xD31CB4
	protected internal sealed override void PackToCore(Packer packer, object objectTree) { }

	// RVA: -1
	protected internal abstract void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xD31D98
	protected internal sealed override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected internal abstract object UnpackFromUnderlyingValue(MessagePackObject messagePackObject) { }

	// RVA: 0xD32264
	private ICustomizableEnumSerializer MsgPack.Serialization.ICustomizableEnumSerializer.GetCopyAs(EnumSerializationMethod method) { }

}

// Namespace: MsgPack.Serialization
public static class EnumMessagePackSerializerHelpers
{
	// Methods

	// RVA: 0xD3230C
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

	// RVA: 0xD324D0
	public void .ctor(Type enumType, ICustomizableEnumSerializer serializer) { }

	// RVA: 0xD32624
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

	// RVA: 0xD324C4
	public EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xD326F8
	public System.Func<System.String,System.String> get_NameTransformer() { }

	// RVA: 0xD31C10
	internal System.Func<System.String,System.String> get_SafeNameTransformer() { }

	// RVA: 0xD3271C
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

	// RVA: 0xD32724
	public Byte get_Item(string name) { }

	// RVA: 0xD32A1C
	internal void .ctor() { }

	// RVA: 0xD32D64
	public bool Add(string name, Byte typeCode) { }

	// RVA: 0xD32B8C
	private bool AddInternal(string name, Byte typeCode) { }

	// RVA: 0xD32E74
	public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Byte>> GetEnumerator() { }

	// RVA: 0xD32FA8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD3290C
	private static void ValidateName(string name) { }

	// RVA: 0xD32E04
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

	// RVA: 0xD33080
	private static void .cctor() { }

	// RVA: 0xD330EC
	public void .ctor() { }

	// RVA: 0xD330F4
	internal string <.cctor>b__3_0(string key) { }

}

// Namespace: MsgPack.Serialization
internal static class KeyNameTransformers
{
	// Fields
	public static readonly System.Func<System.String,System.String> AsIs; // 0x0

	// Methods

	// RVA: 0xD32FAC
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class LazyDelegatingMessagePackSerializer<T0>
{
	// Fields
	private readonly object _providerParameter; // 0x0
	private MsgPack.Serialization.MessagePackSerializer<T> _delegated; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(SerializationContext ownerContext, object providerParameter) { }

	// RVA: 0x30D3CF0
	private MsgPack.Serialization.MessagePackSerializer<T> GetDelegatedSerializer() { }

	// RVA: 0x318DB98
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x318DB98
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x318DB98
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x30D3CF0
	public override string ToString() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackDateTimeMemberAttribute
{
	// Fields
	private DateTimeMemberConversionMethod <DateTimeConversionMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD330FC
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

	// RVA: 0xD33104
	public EnumSerializationMethod get_SerializationMethod() { }

	// RVA: 0xD3310C
	public void set_SerializationMethod(EnumSerializationMethod value) { }

	// RVA: 0xD33114
	public void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackEnumMemberAttribute
{
	// Fields
	private EnumMemberSerializationMethod <SerializationMethod>k__BackingField; // 0x10

	// Methods

	// RVA: 0xD3311C
	public EnumMemberSerializationMethod get_SerializationMethod() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackIgnoreAttribute
{
	// Methods

	// RVA: 0xD33124
	public void .ctor() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD3312C
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD33134
	public string get_TypeCode() { }

	// RVA: 0xD3313C
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownCollectionItemTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD33144
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD3314C
	public string get_TypeCode() { }

	// RVA: 0xD33154
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownDictionaryKeyTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD3315C
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD33164
	public string get_TypeCode() { }

	// RVA: 0xD3316C
	public Type get_BindingType() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackKnownTupleItemTypeAttribute
{
	// Fields
	private string <TypeCode>k__BackingField; // 0x10
	private Type <BindingType>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD33174
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD3317C
	public string get_TypeCode() { }

	// RVA: 0xD33184
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

	// RVA: 0xD3318C
	public int get_Id() { }

	// RVA: 0xD33194
	public string get_Name() { }

	// RVA: 0xD3319C
	public NilImplication get_NilImplication() { }

	// RVA: 0xD331A4
	public void .ctor(int id) { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD331D0
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD331D8
	public Type get_VerifierType() { }

	// RVA: 0xD331E0
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeCollectionItemTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD331E8
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD331F0
	public Type get_VerifierType() { }

	// RVA: 0xD331F8
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeDictionaryKeyTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD33200
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD33208
	public Type get_VerifierType() { }

	// RVA: 0xD33210
	public string get_VerifierMethodName() { }

}

// Namespace: MsgPack.Serialization
public sealed class MessagePackRuntimeTupleItemTypeAttribute
{
	// Fields
	private Type <VerifierType>k__BackingField; // 0x10
	private string <VerifierMethodName>k__BackingField; // 0x18

	// Methods

	// RVA: 0xD33218
	private PolymorphismTarget MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute.get_Target() { }

	// RVA: 0xD33220
	public Type get_VerifierType() { }

	// RVA: 0xD33228
	public string get_VerifierMethodName() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly MsgPack.Serialization.MessagePackSerializer.<>c <>9; // 0x0

	// Methods

	// RVA: 0xD337A4
	private static void .cctor() { }

	// RVA: 0xD33810
	public void .ctor() { }

	// RVA: 0xD33818
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

	// RVA: 0xD33230
	protected internal SerializationContext get_OwnerContext() { }

	// RVA: 0xD33238
	protected internal PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xD332D0
	internal void .ctor(SerializationContext ownerContext, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xD33400
	public void PackTo(Packer packer, object objectTree) { }

	// RVA: -1
	internal abstract void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0xD3340C
	public object UnpackFrom(Unpacker unpacker) { }

	// RVA: -1
	internal abstract object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0xD33418
	public void UnpackTo(Unpacker unpacker, object collection) { }

	// RVA: -1
	internal abstract void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xD333B8
	internal static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0x30D77AC
	public static MsgPack.Serialization.MessagePackSerializer<T> Get() { }

	// RVA: 0x30D77E4
	public static MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x30D78C4
	public static MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0x30D78C4
	internal static MsgPack.Serialization.MessagePackSerializer<T> CreateInternal(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0x30D7A20
	internal static MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionInternal(SerializationContext context, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD33424
	private static void ValidateType(Type type) { }

	// RVA: 0x30D78C4
	internal static MsgPack.Serialization.MessagePackSerializer<T> Wrap(SerializationContext context, MessagePackSerializer nonGeneric) { }

	// RVA: 0x30D9218
	public static void PrepareType() { }

	// RVA: 0x30D9218
	public static void PrepareDictionaryType() { }

	// RVA: 0x30D9218
	public static void PrepareCollectionType() { }

	// RVA: 0x30DA164
	private static void PrepareTypeCore(SerializationContext dummyContext) { }

	// RVA: 0xD3355C
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
public abstract class MessagePackSerializer<T0>
{
	// Fields
	private static readonly bool IsNullable; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	protected void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x30D4D3C
	protected void .ctor(SerializationContext ownerContext, SerializerCapabilities capabilities) { }

	// RVA: -1
	private static bool JudgeNullable() { }

	// RVA: 0x30D64E4
	private static SerializerCapabilities InferCapatibity() { }

	// RVA: 0x318DB98
	public void Pack(Stream stream, T objectTree) { }

	// RVA: 0x318DB98
	public T Unpack(Stream stream) { }

	// RVA: 0x318DB98
	public void PackTo(Packer packer, T objectTree) { }

	// RVA: -1
	protected internal abstract void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x318DB98
	public T UnpackFrom(Unpacker unpacker) { }

	// RVA: 0x318DB98
	protected internal virtual T UnpackNil() { }

	// RVA: -1
	protected internal abstract T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x318DB98
	public void UnpackTo(Unpacker unpacker, T collection) { }

	// RVA: 0x318DB98
	protected internal virtual void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x318DB98
	public Byte[] PackSingleObject(T objectTree) { }

	// RVA: 0x318DB98
	public System.ArraySegment<System.Byte> PackSingleObjectAsBytes(T objectTree) { }

	// RVA: 0x318DB98
	public T UnpackSingleObject(Byte[] buffer) { }

	// RVA: 0x30D4F34
	internal sealed override void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: 0x30D3DA0
	internal sealed override object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x30D4F34
	internal sealed override void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0x30DB358
	private static void ThrowArgumentException(string message, string parameterName) { }

	// RVA: 0x30D9218
	private static void ThrowNewValueTypeCannotBeNullException() { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal abstract class MessagePackSerializerProvider
{
	// Methods

	// RVA: 0xD3261C
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

	// RVA: 0x318DB98
	public TAction OnPacking(TPackingParameter parameter, NilImplication nilImplication) { }

	// RVA: -1
	protected abstract TCondition OnPackingMessagePackObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TCondition OnPackingReferenceTypeObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TCondition OnPackingNullableValueTypeObject(TPackingParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnPackingCore(TPackingParameter parameter, TCondition condition) { }

	// RVA: 0x318DB98
	public TAction OnUnpacked(TUnpackedParameter parameter, NilImplication nilImplication) { }

	// RVA: -1
	protected abstract TAction OnNopOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnThrowNullIsProhibitedExceptionOnUnpacked(TUnpackedParameter parameter) { }

	// RVA: -1
	protected abstract TAction OnThrowValueTypeCannotBeNull3OnUnpacked(TUnpackedParameter parameter) { }

	// RVA: 0x30D488C
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

	// RVA: 0xD33B34
	internal void .ctor(string loadingTypeFullName, AssemblyName loadingAssemblyName, string loadingAssemblyFullName) { }

	// RVA: 0xD33B84
	public override string ToString() { }

	// RVA: 0xD33C08
	public override bool Equals(object obj) { }

	// RVA: 0xD33CA8
	public bool Equals(PolymorphicTypeVerificationContext other) { }

	// RVA: 0xD33CF4
	public override int GetHashCode() { }

}

// Namespace: 
private sealed class ReadOnlyDictionary<T0, T1>
{
	// Fields
	private readonly System.Collections.Generic.IDictionary<TKey,TValue> _underlying; // 0x0

	// Methods

	// RVA: 0x30D3CF0
	private System.Collections.Generic.ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }

	// RVA: 0x318DB98
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }

	// RVA: 0x318DB98
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }

	// RVA: 0x30D39B8
	private int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Count() { }

	// RVA: 0x30D3738
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }

	// RVA: 0x30D4CD4
	public void .ctor(System.Collections.Generic.IDictionary<TKey,TValue> underlying) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.ContainsKey(TKey key) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.TryGetValue(TKey key, TValue value) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30D4D3C
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey,TValue>[] array, int arrayIndex) { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x318DB98
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }

	// RVA: 0x318DB98
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }

	// RVA: 0x318DB98
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey,TValue> item) { }

	// RVA: 0x30D488C
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }

	// RVA: 0x318DB98
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

	// RVA: 0xD3757C
	private void .ctor(TypeTableEntry member, TypeTableEntry collectionItem, TypeTableEntry dictionaryKey) { }

	// RVA: 0xD35A78
	public static TypeTable Create(MemberInfo member, PolymorphismSchema defaultSchema) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_0
{
	// Fields
	public PolymorphismTarget targetType; // 0x10
	public System.Func<MsgPack.Serialization.Polymorphic.IPolymorphicHelperAttribute,System.Boolean> <>9__0; // 0x18

	// Methods

	// RVA: 0xD37B1C
	public void .ctor() { }

	// RVA: 0xD39850
	internal bool <Create>b__0(IPolymorphicHelperAttribute a) { }

}

// Namespace: 
private sealed class <>c__DisplayClass20_0
{
	// Fields
	public IPolymorphicRuntimeTypeAttribute attribute; // 0x10

	// Methods

	// RVA: 0xD396BC
	public void .ctor() { }

	// RVA: 0xD3990C
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

	// RVA: 0xD37A78
	public System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xD367AC
	public PolymorphismType get_PolymorphismType() { }

	// RVA: 0xD36734
	public bool get_Exists() { }

	// RVA: 0xD37A80
	public System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xD37A88
	private void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xD37A90
	private void .ctor() { }

	// RVA: 0xD375CC
	public static TypeTableEntry Create(MemberInfo member, PolymorphismTarget targetType, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD37B24
	private void Interpret(IPolymorphicHelperAttribute attribute, string memberName, int tupleItemNumber) { }

	// RVA: 0xD37EF4
	private void SetDefault(PolymorphismTarget target, string memberName, int tupleItemNumber, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD38388
	private void SetKnownType(PolymorphismTarget target, string memberName, int tupleItemNumber, string typeCode, Type bindingType) { }

	// RVA: 0xD38B08
	private void SetRuntimeType(PolymorphismTarget target, string memberName, int tupleItemNumber, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD38C14
	private static string GetCannotSpecifyKnownTypeAndRuntimeTypeErrorMessage(PolymorphismTarget target, string memberName, System.Nullable<System.Int32> tupleItemNumber) { }

	// RVA: 0xD3927C
	private static string GetCannotDuplicateKnownTypeCodeErrorMessage(PolymorphismTarget target, string typeCode, string memberName, int tupleItemNumber) { }

	// RVA: 0xD3855C
	private static System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> GetVerifier(IPolymorphicRuntimeTypeAttribute attribute) { }

	// RVA: 0xD396C4
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

	// RVA: 0xD399CC
	private static void .cctor() { }

	// RVA: 0xD39A38
	public void .ctor() { }

	// RVA: 0xD39A40
	internal PolymorphismSchema <.ctor>b__3_0(PolymorphismSchema x) { }

	// RVA: 0xD39AD4
	internal PolymorphismSchema <.ctor>b__4_0(PolymorphismSchema x) { }

	// RVA: 0xD39B68
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

	// RVA: 0xD33D44
	private void .ctor() { }

	// RVA: 0xD33EB8
	private void .ctor(Type targetType, PolymorphismType polymorphismType, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xD34250
	private void .ctor(Type targetType, PolymorphismType polymorphismType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, PolymorphismSchema[] childItemSchemaList) { }

	// RVA: 0xD34120
	private void .ctor(Type targetType, PolymorphismType polymorphismType, MsgPack.Serialization.PolymorphismSchema.ReadOnlyDictionary<System.String,System.Type> codeTypeMapping, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier, PolymorphismSchemaChildrenType childrenType, System.Collections.ObjectModel.ReadOnlyCollection<MsgPack.Serialization.PolymorphismSchema> childItemSchemaList) { }

	// RVA: 0xD344B0
	public static PolymorphismSchema ForPolymorphicObject(Type targetType) { }

	// RVA: 0xD34564
	public static PolymorphismSchema ForPolymorphicObject(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping) { }

	// RVA: 0xD34628
	public static PolymorphismSchema ForContextSpecifiedCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xD34738
	public static PolymorphismSchema ForPolymorphicCollection(Type targetType, PolymorphismSchema itemSchema) { }

	// RVA: 0xD34848
	public static PolymorphismSchema ForPolymorphicCollection(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema itemSchema) { }

	// RVA: 0xD34960
	public static PolymorphismSchema ForContextSpecifiedDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD34A9C
	public static PolymorphismSchema ForPolymorphicDictionary(Type targetType, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD34BD8
	public static PolymorphismSchema ForPolymorphicDictionary(Type targetType, System.Collections.Generic.IDictionary<System.String,System.Type> codeTypeMapping, PolymorphismSchema keySchema, PolymorphismSchema valueSchema) { }

	// RVA: 0xD34D1C
	internal PolymorphismSchema FilterSelf() { }

	// RVA: 0xD34DEC
	internal Type get_TargetType() { }

	// RVA: 0xD34DF4
	private void set_TargetType(Type value) { }

	// RVA: 0xD34DFC
	internal PolymorphismType get_PolymorphismType() { }

	// RVA: 0xD34E04
	private void set_PolymorphismType(PolymorphismType value) { }

	// RVA: 0xD34E0C
	internal System.Collections.Generic.IDictionary<System.String,System.Type> get_CodeTypeMapping() { }

	// RVA: 0xD34E14
	internal bool get_UseDefault() { }

	// RVA: 0xD34E24
	internal bool get_UseTypeEmbedding() { }

	// RVA: 0xD34E34
	internal System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> get_TypeVerifier() { }

	// RVA: 0xD34E3C
	private void set_TypeVerifier(System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> value) { }

	// RVA: 0xD34E44
	internal PolymorphismSchemaChildrenType get_ChildrenType() { }

	// RVA: 0xD34E4C
	private void set_ChildrenType(PolymorphismSchemaChildrenType value) { }

	// RVA: 0xD34E54
	internal PolymorphismSchema get_ItemSchema() { }

	// RVA: 0xD34F3C
	private PolymorphismSchema TryGetItemSchema() { }

	// RVA: 0xD34FEC
	internal PolymorphismSchema get_KeySchema() { }

	// RVA: 0xD350A4
	private PolymorphismSchema TryGetKeySchema() { }

	// RVA: 0xD35124
	internal static PolymorphismSchema Create(Type type, SerializingMember memberMayBeNull) { }

	// RVA: 0xD3527C
	private static PolymorphismSchema CreateCore(MemberInfo member, PolymorphismSchema defaultSchema) { }

	// RVA: 0xD36824
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

	// RVA: 0xD3C828
	private static void .cctor() { }

	// RVA: 0xD3C894
	public void .ctor() { }

	// RVA: 0xD3C89C
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_0(Type interface) { }

	// RVA: 0xD3C9A4
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_1(Type i) { }

	// RVA: 0xD3CA2C
	internal Type <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_2(Type i) { }

	// RVA: 0xD3CA58
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_3(Type i) { }

	// RVA: 0xD3CAE0
	internal bool <TryCreateCollectionTraitsForHasGetEnumeratorType>b__2_4(Type i) { }

	// RVA: 0xD3CB68
	internal Type <FindInterfaceMethod>b__7_2(ParameterInfo p) { }

	// RVA: 0xD3CB90
	internal bool <GetIsPublic>b__15_0(MethodInfo a) { }

	// RVA: 0xD3CC38
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

	// RVA: 0xD3BC38
	public void .ctor() { }

	// RVA: 0xD3CC54
	internal bool <FindInterfaceMethod>b__0(Type type, object _) { }

	// RVA: 0xD3CC64
	internal bool <FindInterfaceMethod>b__1(MethodInfo method) { }

}

// Namespace: MsgPack.Serialization
internal static class ReflectionExtensions
{
	// Fields
	private static readonly Type[] ExceptionConstructorWithInnerParameterTypes; // 0x0
	private static readonly Type[] ObjectAddParameterTypes; // 0x8

	// Methods

	// RVA: 0xD35E20
	internal static CollectionTraits GetCollectionTraits(Type source, CollectionTraitOptions options, bool allowNonCollectionEnumerableTypes) { }

	// RVA: 0xD3B36C
	private static bool TryCreateCollectionTraitsForIEnumerableT(Type source, GenericCollectionTypes genericTypes, CollectionTraitOptions options, MethodInfo getMethod, CollectionTraits result) { }

	// RVA: 0xD39B70
	private static bool TryCreateCollectionTraitsForHasGetEnumeratorType(Type source, CollectionTraitOptions options, MethodInfo getEnumerator, CollectionTraits result) { }

	// RVA: 0xD3A554
	private static bool TryCreateGenericCollectionTraits(Type source, Type type, CollectionTraitOptions options, CollectionTraits result) { }

	// RVA: 0xD3AA14
	private static bool DetermineCollectionInterfaces(Type type, GenericCollectionTypes genericTypes, Type idictionary, Type ilist, Type icollection, Type ienumerable) { }

	// RVA: 0xD3ADDC
	private static MethodInfo GetGetEnumeratorMethodFromElementType(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xD3B53C
	private static MethodInfo GetGetEnumeratorMethodFromEnumerableType(Type targetType, Type enumerableType, CollectionTraitOptions options) { }

	// RVA: 0xD3B9BC
	private static MethodInfo FindInterfaceMethod(Type targetType, Type interfaceType, string name, Type[] parameterTypes) { }

	// RVA: 0xD3B5F8
	private static MethodInfo GetAddMethod(Type targetType, Type argumentType, CollectionTraitOptions options) { }

	// RVA: 0xD3B10C
	private static MethodInfo GetCountGetterMethod(Type targetType, Type elementType, CollectionTraitOptions options) { }

	// RVA: 0xD3AF70
	private static MethodInfo GetAddMethod(Type targetType, Type keyType, Type valueType, CollectionTraitOptions options) { }

	// RVA: 0xD3A3F8
	private static bool FilterCollectionType(Type type, object filterCriteria) { }

	// RVA: 0xD3B8B4
	private static bool IsIEnumeratorT(Type interface) { }

	// RVA: 0xD3BC40
	public static bool GetHasPublicGetter(MemberInfo source) { }

	// RVA: 0xD3BD84
	public static bool GetIsPublic(MemberInfo source) { }

	// RVA: 0xD339F8
	public static Type[] GetParameterTypes(MethodBase source) { }

	// RVA: 0xD35B90
	public static Type GetMemberValueType(MemberInfo source) { }

	// RVA: 0xD3C108
	public static object InvokePreservingExceptionType(ConstructorInfo source, object[] parameters) { }

	// RVA: 0xD3C46C
	public static object InvokePreservingExceptionType(MethodInfo source, object instance, object[] parameters) { }

	// RVA: 0x318DB98
	public static T CreateInstancePreservingExceptionType(Type instanceType, object[] constructorParameters) { }

	// RVA: 0xD3C558
	public static object CreateInstancePreservingExceptionType(Type type, object[] constructorParameters) { }

	// RVA: 0xD3C1F4
	private static Exception HoistUpInnerException(TargetInvocationException targetInvocationException) { }

	// RVA: 0xD3C634
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

	// RVA: 0xD3CDF0
	private void set_Context(SerializationContext value) { }

	// RVA: 0xD3CDF8
	private void set_TargetType(Type value) { }

	// RVA: 0xD3CE00
	private void set_PolymorphismSchema(PolymorphismSchema value) { }

	// RVA: 0x30D3CF0
	internal MsgPack.Serialization.MessagePackSerializer<T> GetFoundSerializer() { }

	// RVA: 0xD3CE08
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

	// RVA: 0xD3CEE4
	public bool get_OneBoundDataMemberOrder() { }

	// RVA: 0xD332C4
	public PackerCompatibilityOptions get_PackerCompatibilityOptions() { }

	// RVA: 0xD3CF08
	public void set_PackerCompatibilityOptions(PackerCompatibilityOptions value) { }

	// RVA: 0xD3CF14
	public void set_IgnorePackabilityForCollection(bool value) { }

	// RVA: 0xD3CF3C
	public bool get_AllowNonCollectionEnumerableTypes() { }

	// RVA: 0xD3CF60
	public void set_AllowNonCollectionEnumerableTypes(bool value) { }

	// RVA: 0xD3CF88
	public bool get_AllowAsymmetricSerializer() { }

	// RVA: 0xD3CFAC
	public void set_AllowAsymmetricSerializer(bool value) { }

	// RVA: 0xD3CFD4
	internal void .ctor() { }

}

// Namespace: 
private sealed class SerializerGetter
{
	// Fields
	public static readonly SerializerGetter Instance; // 0x0
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Reflection.MethodInfo> _cache; // 0x10

	// Methods

	// RVA: 0xD3E330
	private void .ctor() { }

	// RVA: 0xD3D9B0
	public MessagePackSerializer Get(SerializationContext context, Type targetType, object providerParameter) { }

	// RVA: 0xD3E3BC
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

	// RVA: 0xD3D024
	public static SerializationContext get_Default() { }

	// RVA: 0xD3D120
	public SerializerRepository get_Serializers() { }

	// RVA: 0xD3D128
	public SerializerOptions get_SerializerOptions() { }

	// RVA: 0xD3D130
	public SerializationCompatibilityOptions get_CompatibilityOptions() { }

	// RVA: 0xD3D138
	public DictionarySerlaizationOptions get_DictionarySerlaizationOptions() { }

	// RVA: 0xD3D140
	public SerializationMethod get_SerializationMethod() { }

	// RVA: 0xD3D14C
	public EnumSerializationOptions get_EnumSerializationOptions() { }

	// RVA: 0xD3D154
	public DefaultConcreteTypeRepository get_DefaultCollectionTypes() { }

	// RVA: 0xD30BD8
	public DateTimeConversionMethod get_DefaultDateTimeConversionMethod() { }

	// RVA: 0x30D3DA0
	private MsgPack.Serialization.MessagePackSerializer<T> OnResolveSerializer(PolymorphismSchema schema) { }

	// RVA: 0xD3379C
	public void .ctor() { }

	// RVA: 0xD3D15C
	public void .ctor(PackerCompatibilityOptions packerCompatibilityOptions) { }

	// RVA: 0x30D3CF0
	public MsgPack.Serialization.MessagePackSerializer<T> GetSerializer() { }

	// RVA: 0x30D3DA0
	public MsgPack.Serialization.MessagePackSerializer<T> GetSerializer(object providerParameter) { }

	// RVA: 0xD3D5E8
	private Type EnsureConcreteTypeRegistered(Type mayBeAbstractType) { }

	// RVA: 0x30D3DA0
	private MsgPack.Serialization.MessagePackSerializer<T> GetSerializerWithoutGeneration(PolymorphismSchema schema) { }

	// RVA: 0xD3D830
	public MessagePackSerializer GetSerializer(Type targetType) { }

	// RVA: 0xD3D838
	public MessagePackSerializer GetSerializer(Type targetType, object providerParameter) { }

	// RVA: 0xD3E134
	public ExtTypeCodeMapping get_ExtTypeCodeMapping() { }

	// RVA: 0xD3E13C
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
public static class SerializationExceptions
{
	// Methods

	// RVA: 0xD3E49C
	public static Exception NewValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xD3E644
	public static void ThrowValueTypeCannotBeNull(string name, Type memberType, Type declaringType) { }

	// RVA: 0xD3E670
	public static Exception NewValueTypeCannotBeNull(Type type) { }

	// RVA: 0xD3E7A8
	public static void ThrowMissingItem(int index, Unpacker unpacker) { }

	// RVA: 0xD3E7BC
	public static void ThrowMissingItem(int index, string name, Unpacker unpacker) { }

	// RVA: 0xD3EBF8
	internal static void ThrowMissingKey(int index, Unpacker unpacker) { }

	// RVA: 0xD3EE44
	internal static Exception NewTargetDoesNotHavePublicDefaultConstructor(Type type) { }

	// RVA: 0xD3EF7C
	internal static Exception NewTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xD3F0B4
	internal static void ThrowTargetDoesNotHavePublicDefaultConstructorNorInitialCapacity(Type type) { }

	// RVA: 0xD3F0E0
	public static Exception NewMissingProperty(string name) { }

	// RVA: 0xD3F218
	internal static void ThrowMissingProperty(string name) { }

	// RVA: 0xD3F244
	internal static void ThrowUnexpectedEndOfStream(Unpacker unpacker) { }

	// RVA: 0xD3F3F0
	public static void ThrowIsNotArrayHeader(Unpacker unpacker) { }

	// RVA: 0xD3F590
	public static void ThrowIsNotMapHeader(Unpacker unpacker) { }

	// RVA: 0xD3D6F8
	public static Exception NewNotSupportedBecauseCannotInstanciateAbstractType(Type type) { }

	// RVA: 0xD3F730
	public static Exception NewIsIncorrectStream(Exception innerException) { }

	// RVA: 0xD3F7B0
	internal static void ThrowIsIncorrectStream(Exception innerException) { }

	// RVA: 0xD3F7DC
	public static Exception NewIsTooLargeCollection() { }

	// RVA: 0xD3F854
	internal static void ThrowIsTooLargeCollection() { }

	// RVA: 0xD3F880
	public static Exception NewNullIsProhibited(string memberName) { }

	// RVA: 0xD3F9B8
	public static void ThrowNullIsProhibited(string memberName) { }

	// RVA: 0xD3F9E4
	public static Exception NewReadOnlyMemberItemsMustNotBeNull(string memberName) { }

	// RVA: 0xD3FB1C
	public static Exception NewUnpackFromIsNotSupported(Type targetType) { }

	// RVA: 0xD3FC54
	public static Exception NewCreateInstanceIsNotSupported(Type targetType) { }

	// RVA: 0xD3FD8C
	internal static Exception NewUnpackToIsNotSupported(Type type, Exception inner) { }

	// RVA: 0xD3FECC
	internal static Exception NewValueTypeCannotBePolymorphic(Type type) { }

	// RVA: 0xD40004
	internal static Exception NewUnknownTypeEmbedding() { }

	// RVA: 0xD4007C
	internal static Exception NewIncompatibleCollectionSerializer(Type targetType, Type incompatibleType, Type exampleClass) { }

	// RVA: 0xD402EC
	internal static void ThrowArgumentNullException(string parameterName) { }

	// RVA: 0xD40334
	internal static void ThrowSerializationException(string message) { }

	// RVA: 0xD4037C
	internal static void ThrowSerializationException(string message, Exception innerException) { }

	// RVA: 0xD403D0
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

	// RVA: 0xD45740
	private void .ctor() { }

	// RVA: 0xD45794
	public override bool Equals(System.Collections.Generic.KeyValuePair<System.String,System.Type> x, System.Collections.Generic.KeyValuePair<System.String,System.Type> y) { }

	// RVA: 0xD45A14
	public override int GetHashCode(System.Collections.Generic.KeyValuePair<System.String,System.Type> obj) { }

	// RVA: 0xD45D4C
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

	// RVA: 0xD45DEC
	private static void .cctor() { }

	// RVA: 0xD45E58
	public void .ctor() { }

	// RVA: 0xD45E60
	internal System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_0(ParameterInfo p) { }

	// RVA: 0xD45EFC
	internal System.Collections.Generic.KeyValuePair<System.String,System.Type> <FindCorrespondingMemberNames>b__26_1(SerializingMember m) { }

	// RVA: 0xD45FBC
	internal string <FindCorrespondingMemberNames>b__26_2(ParameterInfo p, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> ms) { }

	// RVA: 0xD46048
	internal string <ThrowAmbigiousMatchException>b__28_0(SerializingMember x) { }

	// RVA: 0xD46070
	internal int <Prepare>b__32_0(SerializingMember entry) { }

	// RVA: 0xD46094
	internal bool <Prepare>b__32_2(SerializingMember item) { }

	// RVA: 0xD460C0
	internal string <Prepare>b__32_3(SerializingMember item) { }

	// RVA: 0xD460E4
	internal bool <HasAnyCorrespondingMembers>b__33_0(string x) { }

	// RVA: 0xD46104
	internal bool <GetTargetMembers>b__37_0(MemberInfo item) { }

	// RVA: 0xD461E0
	internal bool <GetTargetMembers>b__37_1(object attr) { }

	// RVA: 0xD46254
	internal bool <GetAnnotatedMembersWithDuplicationDetection>b__38_0(MemberInfo member) { }

	// RVA: 0xD46330
	internal SerializingMember <GetAnnotatedMembersWithDuplicationDetection>b__38_1(MemberInfo member) { }

	// RVA: 0xD465A8
	internal <>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> <GetSystemRuntimeSerializationCompatibleMembers>b__39_0(MemberInfo item) { }

	// RVA: 0xD46734
	internal bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_3(object data) { }

	// RVA: 0xD467A8
	internal bool <GetSystemRuntimeSerializationCompatibleMembers>b__39_1(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xD46840
	internal SerializingMember <GetSystemRuntimeSerializationCompatibleMembers>b__39_2(<>f__AnonymousType0<System.Reflection.MemberInfo,System.Object> item) { }

	// RVA: 0xD46F40
	internal bool <GetPublicUnpreventedMembers>b__40_0(MemberInfo member) { }

	// RVA: 0xD472A8
	internal string <GetPublicUnpreventedMembers>b__40_2(object data) { }

	// RVA: 0xD472DC
	internal bool <GetPublicUnpreventedMembers>b__40_3(string attr) { }

	// RVA: 0xD47370
	internal SerializingMember <GetPublicUnpreventedMembers>b__40_1(MemberInfo member) { }

	// RVA: 0xD47460
	internal int <FindDeserializationConstructor>b__42_0(ConstructorInfo ctor) { }

	// RVA: 0xD47498
	internal int <FindDeserializationConstructor>b__42_1(System.Linq.IGrouping<System.Int32,System.Reflection.ConstructorInfo> g) { }

	// RVA: 0xD47548
	internal string <FindDeserializationConstructor>b__42_2(ConstructorInfo ctor) { }

	// RVA: 0xD47570
	internal bool <FindExplicitDeserializationConstructors>b__43_0(ConstructorInfo ctor) { }

	// RVA: 0xD476B0
	internal bool <FindExplicitDeserializationConstructors>b__43_1(object a) { }

	// RVA: 0xD47744
	internal int <ComplementMembers>b__46_0(SerializingMember item) { }

	// RVA: 0xD47768
	internal string <VerifyKeyUniqueness>b__48_0(System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.List<System.Reflection.MemberInfo>> kv) { }

	// RVA: 0xD47AF8
	internal string <VerifyKeyUniqueness>b__48_1(MemberInfo m) { }

}

// Namespace: 
private sealed class <>c__DisplayClass32_0
{
	// Fields
	public SerializationContext context; // 0x10

	// Methods

	// RVA: 0xD41CA0
	public void .ctor() { }

	// RVA: 0xD47D3C
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

	// RVA: 0xD40770
	public System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> get_Members() { }

	// RVA: 0xD40778
	private void set_Members(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> value) { }

	// RVA: 0xD40780
	public ConstructorInfo get_DeserializationConstructor() { }

	// RVA: 0xD40788
	private void set_DeserializationConstructor(ConstructorInfo value) { }

	// RVA: 0xD40790
	public bool get_IsConstructorDeserialization() { }

	// RVA: 0xD40798
	private void set_IsConstructorDeserialization(bool value) { }

	// RVA: 0xD407A0
	public bool get_CanDeserialize() { }

	// RVA: 0xD407A8
	private void set_CanDeserialize(bool value) { }

	// RVA: 0xD407B0
	private void .ctor(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor, string[] correspondingMemberNames, bool canDeserialize) { }

	// RVA: 0xD408BC
	public SerializerCapabilities GetCapabilitiesForObject() { }

	// RVA: 0xD408D0
	public SerializerCapabilities GetCapabilitiesForCollection(CollectionTraits traits) { }

	// RVA: 0xD408F8
	private static string[] FindCorrespondingMemberNames(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, ConstructorInfo constructor) { }

	// RVA: 0xD40BF8
	private static string DetermineCorrespondingMemberName(ParameterInfo parameterInfo, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xD40CC0
	private static void ThrowAmbigiousMatchException(ParameterInfo parameterInfo, System.Collections.Generic.ICollection<MsgPack.Serialization.SerializingMember> members) { }

	// RVA: 0xD40F00
	public static void VerifyType(Type targetType) { }

	// RVA: 0xD40FD0
	public static void VerifyCanSerializeTargetType(SerializationContext context, Type targetType) { }

	// RVA: 0xD41210
	public static SerializationTarget Prepare(SerializationContext context, Type targetType) { }

	// RVA: 0xD43464
	private static bool HasAnyCorrespondingMembers(System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames) { }

	// RVA: 0xD43598
	private static bool HasUnpackableInterface(Type targetType, SerializationContext context) { }

	// RVA: 0xD431DC
	private static bool DetermineCanDeserialize(ConstructorKind kind, SerializationContext context, Type targetType, System.Collections.Generic.IEnumerable<System.String> correspondingMemberNames, bool allowDefault) { }

	// RVA: 0xD43650
	private static MemberInfo[] GetDistinctMembers(Type type) { }

	// RVA: 0xD41CA8
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetTargetMembers(Type type) { }

	// RVA: 0xD43A34
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetAnnotatedMembersWithDuplicationDetection(Type type, MemberInfo[] filtered) { }

	// RVA: 0xD43D38
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetSystemRuntimeSerializationCompatibleMembers(MemberInfo[] members) { }

	// RVA: 0xD44000
	private static System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> GetPublicUnpreventedMembers(MemberInfo[] members) { }

	// RVA: 0xD441F8
	private static bool IsNonSerializedField(MemberInfo member) { }

	// RVA: 0xD41F9C
	private static ConstructorInfo FindDeserializationConstructor(SerializationContext context, Type targetType, ConstructorKind constructorKind) { }

	// RVA: 0xD43344
	private static System.Collections.Generic.IList<System.Reflection.ConstructorInfo> FindExplicitDeserializationConstructors(System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> construtors) { }

	// RVA: 0xD44290
	private static SerializationException NewTypeCannotBeSerializedException(Type targetType) { }

	// RVA: 0xD443C8
	private static bool CheckTargetEligibility(SerializationContext context, MemberInfo member) { }

	// RVA: 0xD426C4
	private static System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> ComplementMembers(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> candidates, SerializationContext context, Type targetType) { }

	// RVA: 0xD446FC
	private static void VerifyNilImplication(Type type, System.Collections.Generic.IEnumerable<MsgPack.Serialization.SerializingMember> entries) { }

	// RVA: 0xD44C28
	private static void VerifyKeyUniqueness(System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> result) { }

	// RVA: 0xD45460
	public static SerializationTarget CreateForCollection(ConstructorInfo collectionConstructor, bool canDeserialize) { }

	// RVA: 0xD454F4
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

	// RVA: 0xD411EC
	public bool get_DisablePrivilegedAccess() { }

	// RVA: 0xD3D5D8
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

	// RVA: 0xD3D50C
	public void .ctor(SerializerRepository copiedFrom) { }

	// RVA: 0xD47DD0
	private void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD47F48
	public void Dispose() { }

	// RVA: 0x30D3DA0
	public MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context) { }

	// RVA: 0x30D3E84
	public MsgPack.Serialization.MessagePackSerializer<T> Get(SerializationContext context, object providerParameter) { }

	// RVA: 0xD47F4C
	internal bool Register(Type targetType, MessagePackSerializerProvider serializerProvider, Type nullableType, MessagePackSerializerProvider nullableSerializerProvider, SerializerRegistrationOptions options) { }

	// RVA: 0xD3D448
	public static SerializerRepository GetDefault(SerializationContext ownerContext) { }

	// RVA: 0xD47F6C
	internal static System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeDefaultTable(SerializationContext ownerContext) { }

	// RVA: 0xD49510
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class SerializerTypeKeyRepository
{
	// Fields
	private static readonly Type[] NonGenericSerializerConstructorParameterTypes; // 0x0

	// Methods

	// RVA: 0xD47DCC
	public void .ctor(SerializerTypeKeyRepository copiedFrom) { }

	// RVA: 0xD47EB8
	public void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD4968C
	public object Get(SerializationContext context, Type keyType) { }

	// RVA: 0xD49A08
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

	// RVA: 0xD4465C
	public void .ctor() { }

	// RVA: 0xD46520
	public void .ctor(MemberInfo member, DataMemberContract contract) { }

	// RVA: 0xD49B78
	public EnumMemberSerializationMethod GetEnumMemberSerializationMethod() { }

	// RVA: 0xD49CA0
	public DateTimeMemberConversionMethod GetDateTimeMemberConversionMethod() { }

	// RVA: 0xD49DC8
	public override string ToString() { }

}

// Namespace: MsgPack.Serialization
internal class TypeKeyRepository
{
	// Fields
	private readonly ReaderWriterLockSlim _lock; // 0x10
	private readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> _table; // 0x18

	// Methods

	// RVA: 0xD49598
	public void .ctor(TypeKeyRepository copiedFrom) { }

	// RVA: 0xD3124C
	public void .ctor(System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> table) { }

	// RVA: 0xD4A014
	private System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> GetClonedTable() { }

	// RVA: 0xD31434
	public bool Get(Type type, object matched, object genericDefinitionMatched) { }

	// RVA: 0xD4A16C
	private bool GetCore(Type type, object matched, object genericDefinitionMatched) { }

	// RVA: 0xD47F68
	public bool Register(Type type, object entry, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xD4A450
	private bool RegisterCore(Type key, object value, Type nullableType, object nullableValue, SerializerRegistrationOptions options) { }

	// RVA: 0xD4A6AC
	private bool ContainsType(Type baseType, Type nullableType) { }

}

// Namespace: MsgPack.Serialization
public static class UnpackHelpers
{
	// Fields
	private static readonly MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _messagePackObjectSerializer; // 0x0

	// Methods

	// RVA: 0xD4A798
	public static int GetItemsCount(Unpacker unpacker) { }

	// RVA: 0xD4A8D8
	internal static SerializationTarget DetermineCollectionSerializationStrategy(Type instanceType, bool allowAsymmetricSerializer) { }

	// RVA: 0xD4AA3C
	private static ConstructorInfo TryGetCollectionConstructor(Type instanceType) { }

	// RVA: 0xD4ADC0
	internal static bool IsIEqualityComparer(Type type) { }

	// RVA: 0xD4AEC8
	internal static object GetEqualityComparer(Type comparerType) { }

	// RVA: 0xD4B284
	private static void .cctor() { }

}

// Namespace: 
private sealed class BoxingGenericEqualityComparer<T0>
{
	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	public bool Equals(T x, T y) { }

	// RVA: 0x318DB98
	public int GetHashCode(T obj) { }

}

// Namespace: 
private sealed class System_AppDomainManagerInitializationOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD5669C
	public void .ctor() { }

	// RVA: 0xD566A4
	public bool Equals(AppDomainManagerInitializationOptions left, AppDomainManagerInitializationOptions right) { }

	// RVA: 0xD5672C
	public int GetHashCode(AppDomainManagerInitializationOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_AppDomainManagerInitializationOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD56754
	public void .ctor() { }

	// RVA: 0xD5675C
	public bool Equals(System.Nullable<System.AppDomainManagerInitializationOptions> left, System.Nullable<System.AppDomainManagerInitializationOptions> right) { }

	// RVA: 0xD568D8
	public int GetHashCode(System.Nullable<System.AppDomainManagerInitializationOptions> obj) { }

}

// Namespace: 
private sealed class System_AttributeTargetsEqualityComparer
{
	// Methods

	// RVA: 0xD5698C
	public void .ctor() { }

	// RVA: 0xD56994
	public bool Equals(AttributeTargets left, AttributeTargets right) { }

	// RVA: 0xD56A1C
	public int GetHashCode(AttributeTargets obj) { }

}

// Namespace: 
private sealed class NullableSystem_AttributeTargetsEqualityComparer
{
	// Methods

	// RVA: 0xD56A44
	public void .ctor() { }

	// RVA: 0xD56A4C
	public bool Equals(System.Nullable<System.AttributeTargets> left, System.Nullable<System.AttributeTargets> right) { }

	// RVA: 0xD56BC8
	public int GetHashCode(System.Nullable<System.AttributeTargets> obj) { }

}

// Namespace: 
private sealed class System_Base64FormattingOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD56C7C
	public void .ctor() { }

	// RVA: 0xD56C84
	public bool Equals(Base64FormattingOptions left, Base64FormattingOptions right) { }

	// RVA: 0xD56D0C
	public int GetHashCode(Base64FormattingOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Base64FormattingOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD56D34
	public void .ctor() { }

	// RVA: 0xD56D3C
	public bool Equals(System.Nullable<System.Base64FormattingOptions> left, System.Nullable<System.Base64FormattingOptions> right) { }

	// RVA: 0xD56EB8
	public int GetHashCode(System.Nullable<System.Base64FormattingOptions> obj) { }

}

// Namespace: 
private sealed class System_BooleanEqualityComparer
{
	// Methods

	// RVA: 0xD56F6C
	public void .ctor() { }

	// RVA: 0xD56F74
	public bool Equals(bool left, bool right) { }

	// RVA: 0xD56F80
	public int GetHashCode(bool obj) { }

}

// Namespace: 
private sealed class NullableSystem_BooleanEqualityComparer
{
	// Methods

	// RVA: 0xD56FE8
	public void .ctor() { }

	// RVA: 0xD56FF0
	public bool Equals(System.Nullable<System.Boolean> left, System.Nullable<System.Boolean> right) { }

	// RVA: 0xD57144
	public int GetHashCode(System.Nullable<System.Boolean> obj) { }

}

// Namespace: 
private sealed class System_ByteEqualityComparer
{
	// Methods

	// RVA: 0xD571F8
	public void .ctor() { }

	// RVA: 0xD57200
	public bool Equals(Byte left, Byte right) { }

	// RVA: 0xD5720C
	public int GetHashCode(Byte obj) { }

}

// Namespace: 
private sealed class NullableSystem_ByteEqualityComparer
{
	// Methods

	// RVA: 0xD57234
	public void .ctor() { }

	// RVA: 0xD5723C
	public bool Equals(System.Nullable<System.Byte> left, System.Nullable<System.Byte> right) { }

	// RVA: 0xD57384
	public int GetHashCode(System.Nullable<System.Byte> obj) { }

}

// Namespace: 
private sealed class System_CharEqualityComparer
{
	// Methods

	// RVA: 0xD57438
	public void .ctor() { }

	// RVA: 0xD57440
	public bool Equals(Char left, Char right) { }

	// RVA: 0xD5744C
	public int GetHashCode(Char obj) { }

}

// Namespace: 
private sealed class NullableSystem_CharEqualityComparer
{
	// Methods

	// RVA: 0xD574B4
	public void .ctor() { }

	// RVA: 0xD574BC
	public bool Equals(System.Nullable<System.Char> left, System.Nullable<System.Char> right) { }

	// RVA: 0xD57600
	public int GetHashCode(System.Nullable<System.Char> obj) { }

}

// Namespace: 
private sealed class System_ConsoleColorEqualityComparer
{
	// Methods

	// RVA: 0xD576B4
	public void .ctor() { }

	// RVA: 0xD576BC
	public bool Equals(ConsoleColor left, ConsoleColor right) { }

	// RVA: 0xD57744
	public int GetHashCode(ConsoleColor obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleColorEqualityComparer
{
	// Methods

	// RVA: 0xD5776C
	public void .ctor() { }

	// RVA: 0xD57774
	public bool Equals(System.Nullable<System.ConsoleColor> left, System.Nullable<System.ConsoleColor> right) { }

	// RVA: 0xD578F0
	public int GetHashCode(System.Nullable<System.ConsoleColor> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyEqualityComparer
{
	// Methods

	// RVA: 0xD579A4
	public void .ctor() { }

	// RVA: 0xD579AC
	public bool Equals(ConsoleKey left, ConsoleKey right) { }

	// RVA: 0xD57A34
	public int GetHashCode(ConsoleKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyEqualityComparer
{
	// Methods

	// RVA: 0xD57A5C
	public void .ctor() { }

	// RVA: 0xD57A64
	public bool Equals(System.Nullable<System.ConsoleKey> left, System.Nullable<System.ConsoleKey> right) { }

	// RVA: 0xD57BE0
	public int GetHashCode(System.Nullable<System.ConsoleKey> obj) { }

}

// Namespace: 
private sealed class System_ConsoleKeyInfoEqualityComparer
{
	// Methods

	// RVA: 0xD57C94
	public void .ctor() { }

	// RVA: 0xD57C9C
	public bool Equals(ConsoleKeyInfo left, ConsoleKeyInfo right) { }

	// RVA: 0xD57CD0
	public int GetHashCode(ConsoleKeyInfo obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleKeyInfoEqualityComparer
{
	// Methods

	// RVA: 0xD57CFC
	public void .ctor() { }

	// RVA: 0xD57D04
	public bool Equals(System.Nullable<System.ConsoleKeyInfo> left, System.Nullable<System.ConsoleKeyInfo> right) { }

	// RVA: 0xD57E60
	public int GetHashCode(System.Nullable<System.ConsoleKeyInfo> obj) { }

}

// Namespace: 
private sealed class System_ConsoleModifiersEqualityComparer
{
	// Methods

	// RVA: 0xD57F14
	public void .ctor() { }

	// RVA: 0xD57F1C
	public bool Equals(ConsoleModifiers left, ConsoleModifiers right) { }

	// RVA: 0xD57FA4
	public int GetHashCode(ConsoleModifiers obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleModifiersEqualityComparer
{
	// Methods

	// RVA: 0xD57FCC
	public void .ctor() { }

	// RVA: 0xD57FD4
	public bool Equals(System.Nullable<System.ConsoleModifiers> left, System.Nullable<System.ConsoleModifiers> right) { }

	// RVA: 0xD58150
	public int GetHashCode(System.Nullable<System.ConsoleModifiers> obj) { }

}

// Namespace: 
private sealed class System_ConsoleSpecialKeyEqualityComparer
{
	// Methods

	// RVA: 0xD58204
	public void .ctor() { }

	// RVA: 0xD5820C
	public bool Equals(ConsoleSpecialKey left, ConsoleSpecialKey right) { }

	// RVA: 0xD58294
	public int GetHashCode(ConsoleSpecialKey obj) { }

}

// Namespace: 
private sealed class NullableSystem_ConsoleSpecialKeyEqualityComparer
{
	// Methods

	// RVA: 0xD582BC
	public void .ctor() { }

	// RVA: 0xD582C4
	public bool Equals(System.Nullable<System.ConsoleSpecialKey> left, System.Nullable<System.ConsoleSpecialKey> right) { }

	// RVA: 0xD58440
	public int GetHashCode(System.Nullable<System.ConsoleSpecialKey> obj) { }

}

// Namespace: 
private sealed class System_DateTimeEqualityComparer
{
	// Methods

	// RVA: 0xD584F4
	public void .ctor() { }

	// RVA: 0xD584FC
	public bool Equals(DateTime left, DateTime right) { }

	// RVA: 0xD58574
	public int GetHashCode(DateTime obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeEqualityComparer
{
	// Methods

	// RVA: 0xD585DC
	public void .ctor() { }

	// RVA: 0xD585E4
	public bool Equals(System.Nullable<System.DateTime> left, System.Nullable<System.DateTime> right) { }

	// RVA: 0xD58758
	public int GetHashCode(System.Nullable<System.DateTime> obj) { }

}

// Namespace: 
private sealed class System_DateTimeKindEqualityComparer
{
	// Methods

	// RVA: 0xD5880C
	public void .ctor() { }

	// RVA: 0xD58814
	public bool Equals(DateTimeKind left, DateTimeKind right) { }

	// RVA: 0xD5889C
	public int GetHashCode(DateTimeKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeKindEqualityComparer
{
	// Methods

	// RVA: 0xD588C4
	public void .ctor() { }

	// RVA: 0xD588CC
	public bool Equals(System.Nullable<System.DateTimeKind> left, System.Nullable<System.DateTimeKind> right) { }

	// RVA: 0xD58A48
	public int GetHashCode(System.Nullable<System.DateTimeKind> obj) { }

}

// Namespace: 
private sealed class System_DateTimeOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD58AFC
	public void .ctor() { }

	// RVA: 0xD58B04
	public bool Equals(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0xD58B84
	public int GetHashCode(DateTimeOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_DateTimeOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD58BEC
	public void .ctor() { }

	// RVA: 0xD58BF4
	public bool Equals(System.Nullable<System.DateTimeOffset> left, System.Nullable<System.DateTimeOffset> right) { }

	// RVA: 0xD58D80
	public int GetHashCode(System.Nullable<System.DateTimeOffset> obj) { }

}

// Namespace: 
private sealed class System_DayOfWeekEqualityComparer
{
	// Methods

	// RVA: 0xD58E30
	public void .ctor() { }

	// RVA: 0xD58E38
	public bool Equals(DayOfWeek left, DayOfWeek right) { }

	// RVA: 0xD58EC0
	public int GetHashCode(DayOfWeek obj) { }

}

// Namespace: 
private sealed class NullableSystem_DayOfWeekEqualityComparer
{
	// Methods

	// RVA: 0xD58EE8
	public void .ctor() { }

	// RVA: 0xD58EF0
	public bool Equals(System.Nullable<System.DayOfWeek> left, System.Nullable<System.DayOfWeek> right) { }

	// RVA: 0xD5906C
	public int GetHashCode(System.Nullable<System.DayOfWeek> obj) { }

}

// Namespace: 
private sealed class System_DecimalEqualityComparer
{
	// Methods

	// RVA: 0xD59120
	public void .ctor() { }

	// RVA: 0xD59128
	public bool Equals(Decimal left, Decimal right) { }

	// RVA: 0xD591D4
	public int GetHashCode(Decimal obj) { }

}

// Namespace: 
private sealed class NullableSystem_DecimalEqualityComparer
{
	// Methods

	// RVA: 0xD59268
	public void .ctor() { }

	// RVA: 0xD59270
	public bool Equals(System.Nullable<System.Decimal> left, System.Nullable<System.Decimal> right) { }

	// RVA: 0xD59434
	public int GetHashCode(System.Nullable<System.Decimal> obj) { }

}

// Namespace: 
private sealed class System_DoubleEqualityComparer
{
	// Methods

	// RVA: 0xD594E4
	public void .ctor() { }

	// RVA: 0xD594EC
	public bool Equals(Double left, Double right) { }

	// RVA: 0xD594F8
	public int GetHashCode(Double obj) { }

}

// Namespace: 
private sealed class NullableSystem_DoubleEqualityComparer
{
	// Methods

	// RVA: 0xD59518
	public void .ctor() { }

	// RVA: 0xD59520
	public bool Equals(System.Nullable<System.Double> left, System.Nullable<System.Double> right) { }

	// RVA: 0xD59678
	public int GetHashCode(System.Nullable<System.Double> obj) { }

}

// Namespace: 
private sealed class System_EnvironmentVariableTargetEqualityComparer
{
	// Methods

	// RVA: 0xD5972C
	public void .ctor() { }

	// RVA: 0xD59734
	public bool Equals(EnvironmentVariableTarget left, EnvironmentVariableTarget right) { }

	// RVA: 0xD597BC
	public int GetHashCode(EnvironmentVariableTarget obj) { }

}

// Namespace: 
private sealed class NullableSystem_EnvironmentVariableTargetEqualityComparer
{
	// Methods

	// RVA: 0xD597E4
	public void .ctor() { }

	// RVA: 0xD597EC
	public bool Equals(System.Nullable<System.EnvironmentVariableTarget> left, System.Nullable<System.EnvironmentVariableTarget> right) { }

	// RVA: 0xD59968
	public int GetHashCode(System.Nullable<System.EnvironmentVariableTarget> obj) { }

}

// Namespace: 
private sealed class System_GCCollectionModeEqualityComparer
{
	// Methods

	// RVA: 0xD59A1C
	public void .ctor() { }

	// RVA: 0xD59A24
	public bool Equals(GCCollectionMode left, GCCollectionMode right) { }

	// RVA: 0xD59AAC
	public int GetHashCode(GCCollectionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCCollectionModeEqualityComparer
{
	// Methods

	// RVA: 0xD59AD4
	public void .ctor() { }

	// RVA: 0xD59ADC
	public bool Equals(System.Nullable<System.GCCollectionMode> left, System.Nullable<System.GCCollectionMode> right) { }

	// RVA: 0xD59C58
	public int GetHashCode(System.Nullable<System.GCCollectionMode> obj) { }

}

// Namespace: 
private sealed class System_GCNotificationStatusEqualityComparer
{
	// Methods

	// RVA: 0xD59D0C
	public void .ctor() { }

	// RVA: 0xD59D14
	public bool Equals(GCNotificationStatus left, GCNotificationStatus right) { }

	// RVA: 0xD59D9C
	public int GetHashCode(GCNotificationStatus obj) { }

}

// Namespace: 
private sealed class NullableSystem_GCNotificationStatusEqualityComparer
{
	// Methods

	// RVA: 0xD59DC4
	public void .ctor() { }

	// RVA: 0xD59DCC
	public bool Equals(System.Nullable<System.GCNotificationStatus> left, System.Nullable<System.GCNotificationStatus> right) { }

	// RVA: 0xD59F48
	public int GetHashCode(System.Nullable<System.GCNotificationStatus> obj) { }

}

// Namespace: 
private sealed class System_GuidEqualityComparer
{
	// Methods

	// RVA: 0xD59FFC
	public void .ctor() { }

	// RVA: 0xD5A004
	public bool Equals(Guid left, Guid right) { }

	// RVA: 0xD5A034
	public int GetHashCode(Guid obj) { }

}

// Namespace: 
private sealed class NullableSystem_GuidEqualityComparer
{
	// Methods

	// RVA: 0xD5A05C
	public void .ctor() { }

	// RVA: 0xD5A064
	public bool Equals(System.Nullable<System.Guid> left, System.Nullable<System.Guid> right) { }

	// RVA: 0xD5A1C4
	public int GetHashCode(System.Nullable<System.Guid> obj) { }

}

// Namespace: 
private sealed class System_Int16EqualityComparer
{
	// Methods

	// RVA: 0xD5A274
	public void .ctor() { }

	// RVA: 0xD5A27C
	public bool Equals(Int16 left, Int16 right) { }

	// RVA: 0xD5A288
	public int GetHashCode(Int16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int16EqualityComparer
{
	// Methods

	// RVA: 0xD5A2B0
	public void .ctor() { }

	// RVA: 0xD5A2B8
	public bool Equals(System.Nullable<System.Int16> left, System.Nullable<System.Int16> right) { }

	// RVA: 0xD5A3FC
	public int GetHashCode(System.Nullable<System.Int16> obj) { }

}

// Namespace: 
private sealed class System_Int32EqualityComparer
{
	// Methods

	// RVA: 0xD5A4B0
	public void .ctor() { }

	// RVA: 0xD5A4B8
	public bool Equals(int left, int right) { }

	// RVA: 0xD5A4C4
	public int GetHashCode(int obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int32EqualityComparer
{
	// Methods

	// RVA: 0xD5A4EC
	public void .ctor() { }

	// RVA: 0xD5A4F4
	public bool Equals(System.Nullable<System.Int32> left, System.Nullable<System.Int32> right) { }

	// RVA: 0xD5A638
	public int GetHashCode(System.Nullable<System.Int32> obj) { }

}

// Namespace: 
private sealed class System_Int64EqualityComparer
{
	// Methods

	// RVA: 0xD5A6EC
	public void .ctor() { }

	// RVA: 0xD5A6F4
	public bool Equals(Int64 left, Int64 right) { }

	// RVA: 0xD5A700
	public int GetHashCode(Int64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_Int64EqualityComparer
{
	// Methods

	// RVA: 0xD5A728
	public void .ctor() { }

	// RVA: 0xD5A730
	public bool Equals(System.Nullable<System.Int64> left, System.Nullable<System.Int64> right) { }

	// RVA: 0xD5A878
	public int GetHashCode(System.Nullable<System.Int64> obj) { }

}

// Namespace: 
private sealed class System_IntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD5A92C
	public void .ctor() { }

	// RVA: 0xD5A934
	public bool Equals(IntPtr left, IntPtr right) { }

	// RVA: 0xD5A944
	public int GetHashCode(IntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_IntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD5A96C
	public void .ctor() { }

	// RVA: 0xD5A974
	public bool Equals(System.Nullable<System.IntPtr> left, System.Nullable<System.IntPtr> right) { }

	// RVA: 0xD5AAC0
	public int GetHashCode(System.Nullable<System.IntPtr> obj) { }

}

// Namespace: 
private sealed class System_LoaderOptimizationEqualityComparer
{
	// Methods

	// RVA: 0xD5AB74
	public void .ctor() { }

	// RVA: 0xD5AB7C
	public bool Equals(LoaderOptimization left, LoaderOptimization right) { }

	// RVA: 0xD5AC04
	public int GetHashCode(LoaderOptimization obj) { }

}

// Namespace: 
private sealed class NullableSystem_LoaderOptimizationEqualityComparer
{
	// Methods

	// RVA: 0xD5AC2C
	public void .ctor() { }

	// RVA: 0xD5AC34
	public bool Equals(System.Nullable<System.LoaderOptimization> left, System.Nullable<System.LoaderOptimization> right) { }

	// RVA: 0xD5ADB0
	public int GetHashCode(System.Nullable<System.LoaderOptimization> obj) { }

}

// Namespace: 
private sealed class System_MidpointRoundingEqualityComparer
{
	// Methods

	// RVA: 0xD5AE64
	public void .ctor() { }

	// RVA: 0xD5AE6C
	public bool Equals(MidpointRounding left, MidpointRounding right) { }

	// RVA: 0xD5AEF4
	public int GetHashCode(MidpointRounding obj) { }

}

// Namespace: 
private sealed class NullableSystem_MidpointRoundingEqualityComparer
{
	// Methods

	// RVA: 0xD5AF1C
	public void .ctor() { }

	// RVA: 0xD5AF24
	public bool Equals(System.Nullable<System.MidpointRounding> left, System.Nullable<System.MidpointRounding> right) { }

	// RVA: 0xD5B0A0
	public int GetHashCode(System.Nullable<System.MidpointRounding> obj) { }

}

// Namespace: 
private sealed class System_ModuleHandleEqualityComparer
{
	// Methods

	// RVA: 0xD5B154
	public void .ctor() { }

	// RVA: 0xD5B15C
	public bool Equals(ModuleHandle left, ModuleHandle right) { }

	// RVA: 0xD5B1D4
	public int GetHashCode(ModuleHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_ModuleHandleEqualityComparer
{
	// Methods

	// RVA: 0xD5B23C
	public void .ctor() { }

	// RVA: 0xD5B244
	public bool Equals(System.Nullable<System.ModuleHandle> left, System.Nullable<System.ModuleHandle> right) { }

	// RVA: 0xD5B3B8
	public int GetHashCode(System.Nullable<System.ModuleHandle> obj) { }

}

// Namespace: 
private sealed class System_PlatformIDEqualityComparer
{
	// Methods

	// RVA: 0xD5B46C
	public void .ctor() { }

	// RVA: 0xD5B474
	public bool Equals(PlatformID left, PlatformID right) { }

	// RVA: 0xD5B4FC
	public int GetHashCode(PlatformID obj) { }

}

// Namespace: 
private sealed class NullableSystem_PlatformIDEqualityComparer
{
	// Methods

	// RVA: 0xD5B524
	public void .ctor() { }

	// RVA: 0xD5B52C
	public bool Equals(System.Nullable<System.PlatformID> left, System.Nullable<System.PlatformID> right) { }

	// RVA: 0xD5B6A8
	public int GetHashCode(System.Nullable<System.PlatformID> obj) { }

}

// Namespace: 
private sealed class System_RuntimeFieldHandleEqualityComparer
{
	// Methods

	// RVA: 0xD5B75C
	public void .ctor() { }

	// RVA: 0xD5B764
	public bool Equals(RuntimeFieldHandle left, RuntimeFieldHandle right) { }

	// RVA: 0xD5B790
	public int GetHashCode(RuntimeFieldHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeFieldHandleEqualityComparer
{
	// Methods

	// RVA: 0xD5B7B8
	public void .ctor() { }

	// RVA: 0xD5B7C0
	public bool Equals(System.Nullable<System.RuntimeFieldHandle> left, System.Nullable<System.RuntimeFieldHandle> right) { }

	// RVA: 0xD5B90C
	public int GetHashCode(System.Nullable<System.RuntimeFieldHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeMethodHandleEqualityComparer
{
	// Methods

	// RVA: 0xD5B9C0
	public void .ctor() { }

	// RVA: 0xD5B9C8
	public bool Equals(RuntimeMethodHandle left, RuntimeMethodHandle right) { }

	// RVA: 0xD5B9F4
	public int GetHashCode(RuntimeMethodHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeMethodHandleEqualityComparer
{
	// Methods

	// RVA: 0xD5BA1C
	public void .ctor() { }

	// RVA: 0xD5BA24
	public bool Equals(System.Nullable<System.RuntimeMethodHandle> left, System.Nullable<System.RuntimeMethodHandle> right) { }

	// RVA: 0xD5BB70
	public int GetHashCode(System.Nullable<System.RuntimeMethodHandle> obj) { }

}

// Namespace: 
private sealed class System_RuntimeTypeHandleEqualityComparer
{
	// Methods

	// RVA: 0xD5BC24
	public void .ctor() { }

	// RVA: 0xD5BC2C
	public bool Equals(RuntimeTypeHandle left, RuntimeTypeHandle right) { }

	// RVA: 0xD5BC58
	public int GetHashCode(RuntimeTypeHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_RuntimeTypeHandleEqualityComparer
{
	// Methods

	// RVA: 0xD5BC80
	public void .ctor() { }

	// RVA: 0xD5BC88
	public bool Equals(System.Nullable<System.RuntimeTypeHandle> left, System.Nullable<System.RuntimeTypeHandle> right) { }

	// RVA: 0xD5BDD4
	public int GetHashCode(System.Nullable<System.RuntimeTypeHandle> obj) { }

}

// Namespace: 
private sealed class System_SByteEqualityComparer
{
	// Methods

	// RVA: 0xD5BE88
	public void .ctor() { }

	// RVA: 0xD5BE90
	public bool Equals(SByte left, SByte right) { }

	// RVA: 0xD5BE9C
	public int GetHashCode(SByte obj) { }

}

// Namespace: 
private sealed class NullableSystem_SByteEqualityComparer
{
	// Methods

	// RVA: 0xD5BEC4
	public void .ctor() { }

	// RVA: 0xD5BECC
	public bool Equals(System.Nullable<System.SByte> left, System.Nullable<System.SByte> right) { }

	// RVA: 0xD5C014
	public int GetHashCode(System.Nullable<System.SByte> obj) { }

}

// Namespace: 
private sealed class System_SingleEqualityComparer
{
	// Methods

	// RVA: 0xD5C0C8
	public void .ctor() { }

	// RVA: 0xD5C0D0
	public bool Equals(float left, float right) { }

	// RVA: 0xD5C0DC
	public int GetHashCode(float obj) { }

}

// Namespace: 
private sealed class NullableSystem_SingleEqualityComparer
{
	// Methods

	// RVA: 0xD5C104
	public void .ctor() { }

	// RVA: 0xD5C10C
	public bool Equals(System.Nullable<System.Single> left, System.Nullable<System.Single> right) { }

	// RVA: 0xD5C260
	public int GetHashCode(System.Nullable<System.Single> obj) { }

}

// Namespace: 
private sealed class System_StringComparisonEqualityComparer
{
	// Methods

	// RVA: 0xD5C314
	public void .ctor() { }

	// RVA: 0xD5C31C
	public bool Equals(StringComparison left, StringComparison right) { }

	// RVA: 0xD5C3A4
	public int GetHashCode(StringComparison obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringComparisonEqualityComparer
{
	// Methods

	// RVA: 0xD5C3CC
	public void .ctor() { }

	// RVA: 0xD5C3D4
	public bool Equals(System.Nullable<System.StringComparison> left, System.Nullable<System.StringComparison> right) { }

	// RVA: 0xD5C550
	public int GetHashCode(System.Nullable<System.StringComparison> obj) { }

}

// Namespace: 
private sealed class System_StringSplitOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD5C604
	public void .ctor() { }

	// RVA: 0xD5C60C
	public bool Equals(StringSplitOptions left, StringSplitOptions right) { }

	// RVA: 0xD5C694
	public int GetHashCode(StringSplitOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_StringSplitOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD5C6BC
	public void .ctor() { }

	// RVA: 0xD5C6C4
	public bool Equals(System.Nullable<System.StringSplitOptions> left, System.Nullable<System.StringSplitOptions> right) { }

	// RVA: 0xD5C840
	public int GetHashCode(System.Nullable<System.StringSplitOptions> obj) { }

}

// Namespace: 
private sealed class System_TimeSpanEqualityComparer
{
	// Methods

	// RVA: 0xD5C8F4
	public void .ctor() { }

	// RVA: 0xD5C8FC
	public bool Equals(TimeSpan left, TimeSpan right) { }

	// RVA: 0xD5C974
	public int GetHashCode(TimeSpan obj) { }

}

// Namespace: 
private sealed class NullableSystem_TimeSpanEqualityComparer
{
	// Methods

	// RVA: 0xD5C9DC
	public void .ctor() { }

	// RVA: 0xD5C9E4
	public bool Equals(System.Nullable<System.TimeSpan> left, System.Nullable<System.TimeSpan> right) { }

	// RVA: 0xD5CB58
	public int GetHashCode(System.Nullable<System.TimeSpan> obj) { }

}

// Namespace: 
private sealed class System_TypeCodeEqualityComparer
{
	// Methods

	// RVA: 0xD5CC0C
	public void .ctor() { }

	// RVA: 0xD5CC14
	public bool Equals(TypeCode left, TypeCode right) { }

	// RVA: 0xD5CC9C
	public int GetHashCode(TypeCode obj) { }

}

// Namespace: 
private sealed class NullableSystem_TypeCodeEqualityComparer
{
	// Methods

	// RVA: 0xD5CCC4
	public void .ctor() { }

	// RVA: 0xD5CCCC
	public bool Equals(System.Nullable<System.TypeCode> left, System.Nullable<System.TypeCode> right) { }

	// RVA: 0xD5CE48
	public int GetHashCode(System.Nullable<System.TypeCode> obj) { }

}

// Namespace: 
private sealed class System_UInt16EqualityComparer
{
	// Methods

	// RVA: 0xD5CEFC
	public void .ctor() { }

	// RVA: 0xD5CF04
	public bool Equals(UInt16 left, UInt16 right) { }

	// RVA: 0xD5CF10
	public int GetHashCode(UInt16 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt16EqualityComparer
{
	// Methods

	// RVA: 0xD5CF38
	public void .ctor() { }

	// RVA: 0xD5CF40
	public bool Equals(System.Nullable<System.UInt16> left, System.Nullable<System.UInt16> right) { }

	// RVA: 0xD5D084
	public int GetHashCode(System.Nullable<System.UInt16> obj) { }

}

// Namespace: 
private sealed class System_UInt32EqualityComparer
{
	// Methods

	// RVA: 0xD5D138
	public void .ctor() { }

	// RVA: 0xD5D140
	public bool Equals(UInt32 left, UInt32 right) { }

	// RVA: 0xD5D14C
	public int GetHashCode(UInt32 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt32EqualityComparer
{
	// Methods

	// RVA: 0xD5D174
	public void .ctor() { }

	// RVA: 0xD5D17C
	public bool Equals(System.Nullable<System.UInt32> left, System.Nullable<System.UInt32> right) { }

	// RVA: 0xD5D2C0
	public int GetHashCode(System.Nullable<System.UInt32> obj) { }

}

// Namespace: 
private sealed class System_UInt64EqualityComparer
{
	// Methods

	// RVA: 0xD5D374
	public void .ctor() { }

	// RVA: 0xD5D37C
	public bool Equals(UInt64 left, UInt64 right) { }

	// RVA: 0xD5D388
	public int GetHashCode(UInt64 obj) { }

}

// Namespace: 
private sealed class NullableSystem_UInt64EqualityComparer
{
	// Methods

	// RVA: 0xD5D3B0
	public void .ctor() { }

	// RVA: 0xD5D3B8
	public bool Equals(System.Nullable<System.UInt64> left, System.Nullable<System.UInt64> right) { }

	// RVA: 0xD5D500
	public int GetHashCode(System.Nullable<System.UInt64> obj) { }

}

// Namespace: 
private sealed class System_UIntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD5D5B4
	public void .ctor() { }

	// RVA: 0xD5D5BC
	public bool Equals(UIntPtr left, UIntPtr right) { }

	// RVA: 0xD5D5CC
	public int GetHashCode(UIntPtr obj) { }

}

// Namespace: 
private sealed class NullableSystem_UIntPtrEqualityComparer
{
	// Methods

	// RVA: 0xD5D5F4
	public void .ctor() { }

	// RVA: 0xD5D5FC
	public bool Equals(System.Nullable<System.UIntPtr> left, System.Nullable<System.UIntPtr> right) { }

	// RVA: 0xD5D748
	public int GetHashCode(System.Nullable<System.UIntPtr> obj) { }

}

// Namespace: 
private sealed class System_Collections_DictionaryEntryEqualityComparer
{
	// Methods

	// RVA: 0xD5D7FC
	public void .ctor() { }

	// RVA: 0xD5D804
	public bool Equals(DictionaryEntry left, DictionaryEntry right) { }

	// RVA: 0xD5D89C
	public int GetHashCode(DictionaryEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Collections_DictionaryEntryEqualityComparer
{
	// Methods

	// RVA: 0xD5D910
	public void .ctor() { }

	// RVA: 0xD5D918
	public bool Equals(System.Nullable<System.Collections.DictionaryEntry> left, System.Nullable<System.Collections.DictionaryEntry> right) { }

	// RVA: 0xD5DAAC
	public int GetHashCode(System.Nullable<System.Collections.DictionaryEntry> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_DebuggerBrowsableStateEqualityComparer
{
	// Methods

	// RVA: 0xD5DB5C
	public void .ctor() { }

	// RVA: 0xD5DB64
	public bool Equals(DebuggerBrowsableState left, DebuggerBrowsableState right) { }

	// RVA: 0xD5DBEC
	public int GetHashCode(DebuggerBrowsableState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_DebuggerBrowsableStateEqualityComparer
{
	// Methods

	// RVA: 0xD5DC14
	public void .ctor() { }

	// RVA: 0xD5DC1C
	public bool Equals(System.Nullable<System.Diagnostics.DebuggerBrowsableState> left, System.Nullable<System.Diagnostics.DebuggerBrowsableState> right) { }

	// RVA: 0xD5DD98
	public int GetHashCode(System.Nullable<System.Diagnostics.DebuggerBrowsableState> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymAddressKindEqualityComparer
{
	// Methods

	// RVA: 0xD5DE4C
	public void .ctor() { }

	// RVA: 0xD5DE54
	public bool Equals(SymAddressKind left, SymAddressKind right) { }

	// RVA: 0xD5DEDC
	public int GetHashCode(SymAddressKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymAddressKindEqualityComparer
{
	// Methods

	// RVA: 0xD5DF04
	public void .ctor() { }

	// RVA: 0xD5DF0C
	public bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> left, System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> right) { }

	// RVA: 0xD5E088
	public int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymAddressKind> obj) { }

}

// Namespace: 
private sealed class System_Diagnostics_SymbolStore_SymbolTokenEqualityComparer
{
	// Methods

	// RVA: 0xD5E13C
	public void .ctor() { }

	// RVA: 0xD5E144
	public bool Equals(SymbolToken left, SymbolToken right) { }

	// RVA: 0xD5E170
	public int GetHashCode(SymbolToken obj) { }

}

// Namespace: 
private sealed class NullableSystem_Diagnostics_SymbolStore_SymbolTokenEqualityComparer
{
	// Methods

	// RVA: 0xD5E178
	public void .ctor() { }

	// RVA: 0xD5E180
	public bool Equals(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> left, System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> right) { }

	// RVA: 0xD5E2C8
	public int GetHashCode(System.Nullable<System.Diagnostics.SymbolStore.SymbolToken> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarAlgorithmTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5E37C
	public void .ctor() { }

	// RVA: 0xD5E384
	public bool Equals(CalendarAlgorithmType left, CalendarAlgorithmType right) { }

	// RVA: 0xD5E40C
	public int GetHashCode(CalendarAlgorithmType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarAlgorithmTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5E434
	public void .ctor() { }

	// RVA: 0xD5E43C
	public bool Equals(System.Nullable<System.Globalization.CalendarAlgorithmType> left, System.Nullable<System.Globalization.CalendarAlgorithmType> right) { }

	// RVA: 0xD5E5B8
	public int GetHashCode(System.Nullable<System.Globalization.CalendarAlgorithmType> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CalendarWeekRuleEqualityComparer
{
	// Methods

	// RVA: 0xD5E66C
	public void .ctor() { }

	// RVA: 0xD5E674
	public bool Equals(CalendarWeekRule left, CalendarWeekRule right) { }

	// RVA: 0xD5E6FC
	public int GetHashCode(CalendarWeekRule obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CalendarWeekRuleEqualityComparer
{
	// Methods

	// RVA: 0xD5E724
	public void .ctor() { }

	// RVA: 0xD5E72C
	public bool Equals(System.Nullable<System.Globalization.CalendarWeekRule> left, System.Nullable<System.Globalization.CalendarWeekRule> right) { }

	// RVA: 0xD5E8A8
	public int GetHashCode(System.Nullable<System.Globalization.CalendarWeekRule> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CompareOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD5E95C
	public void .ctor() { }

	// RVA: 0xD5E964
	public bool Equals(CompareOptions left, CompareOptions right) { }

	// RVA: 0xD5E9EC
	public int GetHashCode(CompareOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CompareOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD5EA14
	public void .ctor() { }

	// RVA: 0xD5EA1C
	public bool Equals(System.Nullable<System.Globalization.CompareOptions> left, System.Nullable<System.Globalization.CompareOptions> right) { }

	// RVA: 0xD5EB98
	public int GetHashCode(System.Nullable<System.Globalization.CompareOptions> obj) { }

}

// Namespace: 
private sealed class System_Globalization_CultureTypesEqualityComparer
{
	// Methods

	// RVA: 0xD5EC4C
	public void .ctor() { }

	// RVA: 0xD5EC54
	public bool Equals(CultureTypes left, CultureTypes right) { }

	// RVA: 0xD5ECDC
	public int GetHashCode(CultureTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_CultureTypesEqualityComparer
{
	// Methods

	// RVA: 0xD5ED04
	public void .ctor() { }

	// RVA: 0xD5ED0C
	public bool Equals(System.Nullable<System.Globalization.CultureTypes> left, System.Nullable<System.Globalization.CultureTypes> right) { }

	// RVA: 0xD5EE88
	public int GetHashCode(System.Nullable<System.Globalization.CultureTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DateTimeStylesEqualityComparer
{
	// Methods

	// RVA: 0xD5EF3C
	public void .ctor() { }

	// RVA: 0xD5EF44
	public bool Equals(DateTimeStyles left, DateTimeStyles right) { }

	// RVA: 0xD5EFCC
	public int GetHashCode(DateTimeStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DateTimeStylesEqualityComparer
{
	// Methods

	// RVA: 0xD5EFF4
	public void .ctor() { }

	// RVA: 0xD5EFFC
	public bool Equals(System.Nullable<System.Globalization.DateTimeStyles> left, System.Nullable<System.Globalization.DateTimeStyles> right) { }

	// RVA: 0xD5F178
	public int GetHashCode(System.Nullable<System.Globalization.DateTimeStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_DigitShapesEqualityComparer
{
	// Methods

	// RVA: 0xD5F22C
	public void .ctor() { }

	// RVA: 0xD5F234
	public bool Equals(DigitShapes left, DigitShapes right) { }

	// RVA: 0xD5F2BC
	public int GetHashCode(DigitShapes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_DigitShapesEqualityComparer
{
	// Methods

	// RVA: 0xD5F2E4
	public void .ctor() { }

	// RVA: 0xD5F2EC
	public bool Equals(System.Nullable<System.Globalization.DigitShapes> left, System.Nullable<System.Globalization.DigitShapes> right) { }

	// RVA: 0xD5F468
	public int GetHashCode(System.Nullable<System.Globalization.DigitShapes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_GregorianCalendarTypesEqualityComparer
{
	// Methods

	// RVA: 0xD5F51C
	public void .ctor() { }

	// RVA: 0xD5F524
	public bool Equals(GregorianCalendarTypes left, GregorianCalendarTypes right) { }

	// RVA: 0xD5F5AC
	public int GetHashCode(GregorianCalendarTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_GregorianCalendarTypesEqualityComparer
{
	// Methods

	// RVA: 0xD5F5D4
	public void .ctor() { }

	// RVA: 0xD5F5DC
	public bool Equals(System.Nullable<System.Globalization.GregorianCalendarTypes> left, System.Nullable<System.Globalization.GregorianCalendarTypes> right) { }

	// RVA: 0xD5F758
	public int GetHashCode(System.Nullable<System.Globalization.GregorianCalendarTypes> obj) { }

}

// Namespace: 
private sealed class System_Globalization_NumberStylesEqualityComparer
{
	// Methods

	// RVA: 0xD5F80C
	public void .ctor() { }

	// RVA: 0xD5F814
	public bool Equals(NumberStyles left, NumberStyles right) { }

	// RVA: 0xD5F89C
	public int GetHashCode(NumberStyles obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_NumberStylesEqualityComparer
{
	// Methods

	// RVA: 0xD5F8C4
	public void .ctor() { }

	// RVA: 0xD5F8CC
	public bool Equals(System.Nullable<System.Globalization.NumberStyles> left, System.Nullable<System.Globalization.NumberStyles> right) { }

	// RVA: 0xD5FA48
	public int GetHashCode(System.Nullable<System.Globalization.NumberStyles> obj) { }

}

// Namespace: 
private sealed class System_Globalization_UnicodeCategoryEqualityComparer
{
	// Methods

	// RVA: 0xD5FAFC
	public void .ctor() { }

	// RVA: 0xD5FB04
	public bool Equals(UnicodeCategory left, UnicodeCategory right) { }

	// RVA: 0xD5FB8C
	public int GetHashCode(UnicodeCategory obj) { }

}

// Namespace: 
private sealed class NullableSystem_Globalization_UnicodeCategoryEqualityComparer
{
	// Methods

	// RVA: 0xD5FBB4
	public void .ctor() { }

	// RVA: 0xD5FBBC
	public bool Equals(System.Nullable<System.Globalization.UnicodeCategory> left, System.Nullable<System.Globalization.UnicodeCategory> right) { }

	// RVA: 0xD5FD38
	public int GetHashCode(System.Nullable<System.Globalization.UnicodeCategory> obj) { }

}

// Namespace: 
private sealed class System_IO_DriveTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5FDEC
	public void .ctor() { }

	// RVA: 0xD5FDF4
	public bool Equals(DriveType left, DriveType right) { }

	// RVA: 0xD5FE7C
	public int GetHashCode(DriveType obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_DriveTypeEqualityComparer
{
	// Methods

	// RVA: 0xD5FEA4
	public void .ctor() { }

	// RVA: 0xD5FEAC
	public bool Equals(System.Nullable<System.IO.DriveType> left, System.Nullable<System.IO.DriveType> right) { }

	// RVA: 0xD60028
	public int GetHashCode(System.Nullable<System.IO.DriveType> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAccessEqualityComparer
{
	// Methods

	// RVA: 0xD600DC
	public void .ctor() { }

	// RVA: 0xD600E4
	public bool Equals(FileAccess left, FileAccess right) { }

	// RVA: 0xD6016C
	public int GetHashCode(FileAccess obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAccessEqualityComparer
{
	// Methods

	// RVA: 0xD60194
	public void .ctor() { }

	// RVA: 0xD6019C
	public bool Equals(System.Nullable<System.IO.FileAccess> left, System.Nullable<System.IO.FileAccess> right) { }

	// RVA: 0xD60318
	public int GetHashCode(System.Nullable<System.IO.FileAccess> obj) { }

}

// Namespace: 
private sealed class System_IO_FileAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD603CC
	public void .ctor() { }

	// RVA: 0xD603D4
	public bool Equals(FileAttributes left, FileAttributes right) { }

	// RVA: 0xD6045C
	public int GetHashCode(FileAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD60484
	public void .ctor() { }

	// RVA: 0xD6048C
	public bool Equals(System.Nullable<System.IO.FileAttributes> left, System.Nullable<System.IO.FileAttributes> right) { }

	// RVA: 0xD60608
	public int GetHashCode(System.Nullable<System.IO.FileAttributes> obj) { }

}

// Namespace: 
private sealed class System_IO_FileModeEqualityComparer
{
	// Methods

	// RVA: 0xD606BC
	public void .ctor() { }

	// RVA: 0xD606C4
	public bool Equals(FileMode left, FileMode right) { }

	// RVA: 0xD6074C
	public int GetHashCode(FileMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileModeEqualityComparer
{
	// Methods

	// RVA: 0xD60774
	public void .ctor() { }

	// RVA: 0xD6077C
	public bool Equals(System.Nullable<System.IO.FileMode> left, System.Nullable<System.IO.FileMode> right) { }

	// RVA: 0xD608F8
	public int GetHashCode(System.Nullable<System.IO.FileMode> obj) { }

}

// Namespace: 
private sealed class System_IO_FileOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD609AC
	public void .ctor() { }

	// RVA: 0xD609B4
	public bool Equals(FileOptions left, FileOptions right) { }

	// RVA: 0xD60A3C
	public int GetHashCode(FileOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD60A64
	public void .ctor() { }

	// RVA: 0xD60A6C
	public bool Equals(System.Nullable<System.IO.FileOptions> left, System.Nullable<System.IO.FileOptions> right) { }

	// RVA: 0xD60BE8
	public int GetHashCode(System.Nullable<System.IO.FileOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_FileShareEqualityComparer
{
	// Methods

	// RVA: 0xD60C9C
	public void .ctor() { }

	// RVA: 0xD60CA4
	public bool Equals(FileShare left, FileShare right) { }

	// RVA: 0xD60D2C
	public int GetHashCode(FileShare obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_FileShareEqualityComparer
{
	// Methods

	// RVA: 0xD60D54
	public void .ctor() { }

	// RVA: 0xD60D5C
	public bool Equals(System.Nullable<System.IO.FileShare> left, System.Nullable<System.IO.FileShare> right) { }

	// RVA: 0xD60ED8
	public int GetHashCode(System.Nullable<System.IO.FileShare> obj) { }

}

// Namespace: 
private sealed class System_IO_HandleInheritabilityEqualityComparer
{
	// Methods

	// RVA: 0xD60F8C
	public void .ctor() { }

	// RVA: 0xD60F94
	public bool Equals(HandleInheritability left, HandleInheritability right) { }

	// RVA: 0xD6101C
	public int GetHashCode(HandleInheritability obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_HandleInheritabilityEqualityComparer
{
	// Methods

	// RVA: 0xD61044
	public void .ctor() { }

	// RVA: 0xD6104C
	public bool Equals(System.Nullable<System.IO.HandleInheritability> left, System.Nullable<System.IO.HandleInheritability> right) { }

	// RVA: 0xD611C8
	public int GetHashCode(System.Nullable<System.IO.HandleInheritability> obj) { }

}

// Namespace: 
private sealed class System_IO_SearchOptionEqualityComparer
{
	// Methods

	// RVA: 0xD6127C
	public void .ctor() { }

	// RVA: 0xD61284
	public bool Equals(SearchOption left, SearchOption right) { }

	// RVA: 0xD6130C
	public int GetHashCode(SearchOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SearchOptionEqualityComparer
{
	// Methods

	// RVA: 0xD61334
	public void .ctor() { }

	// RVA: 0xD6133C
	public bool Equals(System.Nullable<System.IO.SearchOption> left, System.Nullable<System.IO.SearchOption> right) { }

	// RVA: 0xD614B8
	public int GetHashCode(System.Nullable<System.IO.SearchOption> obj) { }

}

// Namespace: 
private sealed class System_IO_SeekOriginEqualityComparer
{
	// Methods

	// RVA: 0xD6156C
	public void .ctor() { }

	// RVA: 0xD61574
	public bool Equals(SeekOrigin left, SeekOrigin right) { }

	// RVA: 0xD615FC
	public int GetHashCode(SeekOrigin obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_SeekOriginEqualityComparer
{
	// Methods

	// RVA: 0xD61624
	public void .ctor() { }

	// RVA: 0xD6162C
	public bool Equals(System.Nullable<System.IO.SeekOrigin> left, System.Nullable<System.IO.SeekOrigin> right) { }

	// RVA: 0xD617A8
	public int GetHashCode(System.Nullable<System.IO.SeekOrigin> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeAccessRightsEqualityComparer
{
	// Methods

	// RVA: 0xD6185C
	public void .ctor() { }

	// RVA: 0xD61864
	public bool Equals(PipeAccessRights left, PipeAccessRights right) { }

	// RVA: 0xD618EC
	public int GetHashCode(PipeAccessRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeAccessRightsEqualityComparer
{
	// Methods

	// RVA: 0xD61914
	public void .ctor() { }

	// RVA: 0xD6191C
	public bool Equals(System.Nullable<System.IO.Pipes.PipeAccessRights> left, System.Nullable<System.IO.Pipes.PipeAccessRights> right) { }

	// RVA: 0xD61A98
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeAccessRights> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeDirectionEqualityComparer
{
	// Methods

	// RVA: 0xD61B4C
	public void .ctor() { }

	// RVA: 0xD61B54
	public bool Equals(PipeDirection left, PipeDirection right) { }

	// RVA: 0xD61BDC
	public int GetHashCode(PipeDirection obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeDirectionEqualityComparer
{
	// Methods

	// RVA: 0xD61C04
	public void .ctor() { }

	// RVA: 0xD61C0C
	public bool Equals(System.Nullable<System.IO.Pipes.PipeDirection> left, System.Nullable<System.IO.Pipes.PipeDirection> right) { }

	// RVA: 0xD61D88
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeDirection> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD61E3C
	public void .ctor() { }

	// RVA: 0xD61E44
	public bool Equals(PipeOptions left, PipeOptions right) { }

	// RVA: 0xD61ECC
	public int GetHashCode(PipeOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD61EF4
	public void .ctor() { }

	// RVA: 0xD61EFC
	public bool Equals(System.Nullable<System.IO.Pipes.PipeOptions> left, System.Nullable<System.IO.Pipes.PipeOptions> right) { }

	// RVA: 0xD62078
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeOptions> obj) { }

}

// Namespace: 
private sealed class System_IO_Pipes_PipeTransmissionModeEqualityComparer
{
	// Methods

	// RVA: 0xD6212C
	public void .ctor() { }

	// RVA: 0xD62134
	public bool Equals(PipeTransmissionMode left, PipeTransmissionMode right) { }

	// RVA: 0xD621BC
	public int GetHashCode(PipeTransmissionMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_IO_Pipes_PipeTransmissionModeEqualityComparer
{
	// Methods

	// RVA: 0xD621E4
	public void .ctor() { }

	// RVA: 0xD621EC
	public bool Equals(System.Nullable<System.IO.Pipes.PipeTransmissionMode> left, System.Nullable<System.IO.Pipes.PipeTransmissionMode> right) { }

	// RVA: 0xD62368
	public int GetHashCode(System.Nullable<System.IO.Pipes.PipeTransmissionMode> obj) { }

}

// Namespace: 
private sealed class System_Reflection_AssemblyNameFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6241C
	public void .ctor() { }

	// RVA: 0xD62424
	public bool Equals(AssemblyNameFlags left, AssemblyNameFlags right) { }

	// RVA: 0xD624AC
	public int GetHashCode(AssemblyNameFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_AssemblyNameFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD624D4
	public void .ctor() { }

	// RVA: 0xD624DC
	public bool Equals(System.Nullable<System.Reflection.AssemblyNameFlags> left, System.Nullable<System.Reflection.AssemblyNameFlags> right) { }

	// RVA: 0xD62658
	public int GetHashCode(System.Nullable<System.Reflection.AssemblyNameFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_BindingFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6270C
	public void .ctor() { }

	// RVA: 0xD62714
	public bool Equals(BindingFlags left, BindingFlags right) { }

	// RVA: 0xD6279C
	public int GetHashCode(BindingFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_BindingFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD627C4
	public void .ctor() { }

	// RVA: 0xD627CC
	public bool Equals(System.Nullable<System.Reflection.BindingFlags> left, System.Nullable<System.Reflection.BindingFlags> right) { }

	// RVA: 0xD62948
	public int GetHashCode(System.Nullable<System.Reflection.BindingFlags> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CallingConventionsEqualityComparer
{
	// Methods

	// RVA: 0xD629FC
	public void .ctor() { }

	// RVA: 0xD62A04
	public bool Equals(CallingConventions left, CallingConventions right) { }

	// RVA: 0xD62A8C
	public int GetHashCode(CallingConventions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CallingConventionsEqualityComparer
{
	// Methods

	// RVA: 0xD62AB4
	public void .ctor() { }

	// RVA: 0xD62ABC
	public bool Equals(System.Nullable<System.Reflection.CallingConventions> left, System.Nullable<System.Reflection.CallingConventions> right) { }

	// RVA: 0xD62C38
	public int GetHashCode(System.Nullable<System.Reflection.CallingConventions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeNamedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD62CEC
	public void .ctor() { }

	// RVA: 0xD62CF4
	public bool Equals(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0xD62D78
	public int GetHashCode(CustomAttributeNamedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeNamedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD62D84
	public void .ctor() { }

	// RVA: 0xD62D8C
	public bool Equals(System.Nullable<System.Reflection.CustomAttributeNamedArgument> left, System.Nullable<System.Reflection.CustomAttributeNamedArgument> right) { }

	// RVA: 0xD62F24
	public int GetHashCode(System.Nullable<System.Reflection.CustomAttributeNamedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_CustomAttributeTypedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD62FD4
	public void .ctor() { }

	// RVA: 0xD62FDC
	public bool Equals(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0xD63058
	public int GetHashCode(CustomAttributeTypedArgument obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_CustomAttributeTypedArgumentEqualityComparer
{
	// Methods

	// RVA: 0xD63080
	public void .ctor() { }

	// RVA: 0xD63088
	public bool Equals(System.Nullable<System.Reflection.CustomAttributeTypedArgument> left, System.Nullable<System.Reflection.CustomAttributeTypedArgument> right) { }

	// RVA: 0xD63210
	public int GetHashCode(System.Nullable<System.Reflection.CustomAttributeTypedArgument> obj) { }

}

// Namespace: 
private sealed class System_Reflection_EventAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD632C0
	public void .ctor() { }

	// RVA: 0xD632C8
	public bool Equals(EventAttributes left, EventAttributes right) { }

	// RVA: 0xD63350
	public int GetHashCode(EventAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_EventAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD63378
	public void .ctor() { }

	// RVA: 0xD63380
	public bool Equals(System.Nullable<System.Reflection.EventAttributes> left, System.Nullable<System.Reflection.EventAttributes> right) { }

	// RVA: 0xD634FC
	public int GetHashCode(System.Nullable<System.Reflection.EventAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ExceptionHandlingClauseOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD635B0
	public void .ctor() { }

	// RVA: 0xD635B8
	public bool Equals(ExceptionHandlingClauseOptions left, ExceptionHandlingClauseOptions right) { }

	// RVA: 0xD63640
	public int GetHashCode(ExceptionHandlingClauseOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ExceptionHandlingClauseOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD63668
	public void .ctor() { }

	// RVA: 0xD63670
	public bool Equals(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> left, System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> right) { }

	// RVA: 0xD637EC
	public int GetHashCode(System.Nullable<System.Reflection.ExceptionHandlingClauseOptions> obj) { }

}

// Namespace: 
private sealed class System_Reflection_FieldAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD638A0
	public void .ctor() { }

	// RVA: 0xD638A8
	public bool Equals(FieldAttributes left, FieldAttributes right) { }

	// RVA: 0xD63930
	public int GetHashCode(FieldAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_FieldAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD63958
	public void .ctor() { }

	// RVA: 0xD63960
	public bool Equals(System.Nullable<System.Reflection.FieldAttributes> left, System.Nullable<System.Reflection.FieldAttributes> right) { }

	// RVA: 0xD63ADC
	public int GetHashCode(System.Nullable<System.Reflection.FieldAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_GenericParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD63B90
	public void .ctor() { }

	// RVA: 0xD63B98
	public bool Equals(GenericParameterAttributes left, GenericParameterAttributes right) { }

	// RVA: 0xD63C20
	public int GetHashCode(GenericParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_GenericParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD63C48
	public void .ctor() { }

	// RVA: 0xD63C50
	public bool Equals(System.Nullable<System.Reflection.GenericParameterAttributes> left, System.Nullable<System.Reflection.GenericParameterAttributes> right) { }

	// RVA: 0xD63DCC
	public int GetHashCode(System.Nullable<System.Reflection.GenericParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ImageFileMachineEqualityComparer
{
	// Methods

	// RVA: 0xD63E80
	public void .ctor() { }

	// RVA: 0xD63E88
	public bool Equals(ImageFileMachine left, ImageFileMachine right) { }

	// RVA: 0xD63F10
	public int GetHashCode(ImageFileMachine obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ImageFileMachineEqualityComparer
{
	// Methods

	// RVA: 0xD63F38
	public void .ctor() { }

	// RVA: 0xD63F40
	public bool Equals(System.Nullable<System.Reflection.ImageFileMachine> left, System.Nullable<System.Reflection.ImageFileMachine> right) { }

	// RVA: 0xD640BC
	public int GetHashCode(System.Nullable<System.Reflection.ImageFileMachine> obj) { }

}

// Namespace: 
private sealed class System_Reflection_InterfaceMappingEqualityComparer
{
	// Methods

	// RVA: 0xD64170
	public void .ctor() { }

	// RVA: 0xD64178
	public bool Equals(InterfaceMapping left, InterfaceMapping right) { }

	// RVA: 0xD64208
	public int GetHashCode(InterfaceMapping obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_InterfaceMappingEqualityComparer
{
	// Methods

	// RVA: 0xD6427C
	public void .ctor() { }

	// RVA: 0xD64284
	public bool Equals(System.Nullable<System.Reflection.InterfaceMapping> left, System.Nullable<System.Reflection.InterfaceMapping> right) { }

	// RVA: 0xD64420
	public int GetHashCode(System.Nullable<System.Reflection.InterfaceMapping> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MemberTypesEqualityComparer
{
	// Methods

	// RVA: 0xD644D0
	public void .ctor() { }

	// RVA: 0xD644D8
	public bool Equals(MemberTypes left, MemberTypes right) { }

	// RVA: 0xD64560
	public int GetHashCode(MemberTypes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MemberTypesEqualityComparer
{
	// Methods

	// RVA: 0xD64588
	public void .ctor() { }

	// RVA: 0xD64590
	public bool Equals(System.Nullable<System.Reflection.MemberTypes> left, System.Nullable<System.Reflection.MemberTypes> right) { }

	// RVA: 0xD6470C
	public int GetHashCode(System.Nullable<System.Reflection.MemberTypes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD647C0
	public void .ctor() { }

	// RVA: 0xD647C8
	public bool Equals(MethodAttributes left, MethodAttributes right) { }

	// RVA: 0xD64850
	public int GetHashCode(MethodAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD64878
	public void .ctor() { }

	// RVA: 0xD64880
	public bool Equals(System.Nullable<System.Reflection.MethodAttributes> left, System.Nullable<System.Reflection.MethodAttributes> right) { }

	// RVA: 0xD649FC
	public int GetHashCode(System.Nullable<System.Reflection.MethodAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_MethodImplAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD64AB0
	public void .ctor() { }

	// RVA: 0xD64AB8
	public bool Equals(MethodImplAttributes left, MethodImplAttributes right) { }

	// RVA: 0xD64B40
	public int GetHashCode(MethodImplAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_MethodImplAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD64B68
	public void .ctor() { }

	// RVA: 0xD64B70
	public bool Equals(System.Nullable<System.Reflection.MethodImplAttributes> left, System.Nullable<System.Reflection.MethodImplAttributes> right) { }

	// RVA: 0xD64CEC
	public int GetHashCode(System.Nullable<System.Reflection.MethodImplAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD64DA0
	public void .ctor() { }

	// RVA: 0xD64DA8
	public bool Equals(ParameterAttributes left, ParameterAttributes right) { }

	// RVA: 0xD64E30
	public int GetHashCode(ParameterAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD64E58
	public void .ctor() { }

	// RVA: 0xD64E60
	public bool Equals(System.Nullable<System.Reflection.ParameterAttributes> left, System.Nullable<System.Reflection.ParameterAttributes> right) { }

	// RVA: 0xD64FDC
	public int GetHashCode(System.Nullable<System.Reflection.ParameterAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ParameterModifierEqualityComparer
{
	// Methods

	// RVA: 0xD65090
	public void .ctor() { }

	// RVA: 0xD65098
	public bool Equals(ParameterModifier left, ParameterModifier right) { }

	// RVA: 0xD65120
	public int GetHashCode(ParameterModifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ParameterModifierEqualityComparer
{
	// Methods

	// RVA: 0xD65190
	public void .ctor() { }

	// RVA: 0xD65198
	public bool Equals(System.Nullable<System.Reflection.ParameterModifier> left, System.Nullable<System.Reflection.ParameterModifier> right) { }

	// RVA: 0xD65314
	public int GetHashCode(System.Nullable<System.Reflection.ParameterModifier> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PortableExecutableKindsEqualityComparer
{
	// Methods

	// RVA: 0xD653C8
	public void .ctor() { }

	// RVA: 0xD653D0
	public bool Equals(PortableExecutableKinds left, PortableExecutableKinds right) { }

	// RVA: 0xD65458
	public int GetHashCode(PortableExecutableKinds obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PortableExecutableKindsEqualityComparer
{
	// Methods

	// RVA: 0xD65480
	public void .ctor() { }

	// RVA: 0xD65488
	public bool Equals(System.Nullable<System.Reflection.PortableExecutableKinds> left, System.Nullable<System.Reflection.PortableExecutableKinds> right) { }

	// RVA: 0xD65604
	public int GetHashCode(System.Nullable<System.Reflection.PortableExecutableKinds> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ProcessorArchitectureEqualityComparer
{
	// Methods

	// RVA: 0xD656B8
	public void .ctor() { }

	// RVA: 0xD656C0
	public bool Equals(ProcessorArchitecture left, ProcessorArchitecture right) { }

	// RVA: 0xD65748
	public int GetHashCode(ProcessorArchitecture obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ProcessorArchitectureEqualityComparer
{
	// Methods

	// RVA: 0xD65770
	public void .ctor() { }

	// RVA: 0xD65778
	public bool Equals(System.Nullable<System.Reflection.ProcessorArchitecture> left, System.Nullable<System.Reflection.ProcessorArchitecture> right) { }

	// RVA: 0xD658F4
	public int GetHashCode(System.Nullable<System.Reflection.ProcessorArchitecture> obj) { }

}

// Namespace: 
private sealed class System_Reflection_PropertyAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD659A8
	public void .ctor() { }

	// RVA: 0xD659B0
	public bool Equals(PropertyAttributes left, PropertyAttributes right) { }

	// RVA: 0xD65A38
	public int GetHashCode(PropertyAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_PropertyAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD65A60
	public void .ctor() { }

	// RVA: 0xD65A68
	public bool Equals(System.Nullable<System.Reflection.PropertyAttributes> left, System.Nullable<System.Reflection.PropertyAttributes> right) { }

	// RVA: 0xD65BE4
	public int GetHashCode(System.Nullable<System.Reflection.PropertyAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD65C98
	public void .ctor() { }

	// RVA: 0xD65CA0
	public bool Equals(ResourceAttributes left, ResourceAttributes right) { }

	// RVA: 0xD65D28
	public int GetHashCode(ResourceAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD65D50
	public void .ctor() { }

	// RVA: 0xD65D58
	public bool Equals(System.Nullable<System.Reflection.ResourceAttributes> left, System.Nullable<System.Reflection.ResourceAttributes> right) { }

	// RVA: 0xD65ED4
	public int GetHashCode(System.Nullable<System.Reflection.ResourceAttributes> obj) { }

}

// Namespace: 
private sealed class System_Reflection_ResourceLocationEqualityComparer
{
	// Methods

	// RVA: 0xD65F88
	public void .ctor() { }

	// RVA: 0xD65F90
	public bool Equals(ResourceLocation left, ResourceLocation right) { }

	// RVA: 0xD66018
	public int GetHashCode(ResourceLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_ResourceLocationEqualityComparer
{
	// Methods

	// RVA: 0xD66040
	public void .ctor() { }

	// RVA: 0xD66048
	public bool Equals(System.Nullable<System.Reflection.ResourceLocation> left, System.Nullable<System.Reflection.ResourceLocation> right) { }

	// RVA: 0xD661C4
	public int GetHashCode(System.Nullable<System.Reflection.ResourceLocation> obj) { }

}

// Namespace: 
private sealed class System_Reflection_TypeAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD66278
	public void .ctor() { }

	// RVA: 0xD66280
	public bool Equals(TypeAttributes left, TypeAttributes right) { }

	// RVA: 0xD66308
	public int GetHashCode(TypeAttributes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Reflection_TypeAttributesEqualityComparer
{
	// Methods

	// RVA: 0xD66330
	public void .ctor() { }

	// RVA: 0xD66338
	public bool Equals(System.Nullable<System.Reflection.TypeAttributes> left, System.Nullable<System.Reflection.TypeAttributes> right) { }

	// RVA: 0xD664B4
	public int GetHashCode(System.Nullable<System.Reflection.TypeAttributes> obj) { }

}

// Namespace: 
private sealed class System_Resources_UltimateResourceFallbackLocationEqualityComparer
{
	// Methods

	// RVA: 0xD66568
	public void .ctor() { }

	// RVA: 0xD66570
	public bool Equals(UltimateResourceFallbackLocation left, UltimateResourceFallbackLocation right) { }

	// RVA: 0xD665F8
	public int GetHashCode(UltimateResourceFallbackLocation obj) { }

}

// Namespace: 
private sealed class NullableSystem_Resources_UltimateResourceFallbackLocationEqualityComparer
{
	// Methods

	// RVA: 0xD66620
	public void .ctor() { }

	// RVA: 0xD66628
	public bool Equals(System.Nullable<System.Resources.UltimateResourceFallbackLocation> left, System.Nullable<System.Resources.UltimateResourceFallbackLocation> right) { }

	// RVA: 0xD667A4
	public int GetHashCode(System.Nullable<System.Resources.UltimateResourceFallbackLocation> obj) { }

}

// Namespace: 
private sealed class System_Runtime_GCLatencyModeEqualityComparer
{
	// Methods

	// RVA: 0xD66858
	public void .ctor() { }

	// RVA: 0xD66860
	public bool Equals(GCLatencyMode left, GCLatencyMode right) { }

	// RVA: 0xD668E8
	public int GetHashCode(GCLatencyMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_GCLatencyModeEqualityComparer
{
	// Methods

	// RVA: 0xD66910
	public void .ctor() { }

	// RVA: 0xD66918
	public bool Equals(System.Nullable<System.Runtime.GCLatencyMode> left, System.Nullable<System.Runtime.GCLatencyMode> right) { }

	// RVA: 0xD66A94
	public int GetHashCode(System.Nullable<System.Runtime.GCLatencyMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer
{
	// Methods

	// RVA: 0xD66B48
	public void .ctor() { }

	// RVA: 0xD66B50
	public bool Equals(CompilationRelaxations left, CompilationRelaxations right) { }

	// RVA: 0xD66BD8
	public int GetHashCode(CompilationRelaxations obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_CompilationRelaxationsEqualityComparer
{
	// Methods

	// RVA: 0xD66C00
	public void .ctor() { }

	// RVA: 0xD66C08
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> left, System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> right) { }

	// RVA: 0xD66D84
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.CompilationRelaxations> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_LoadHintEqualityComparer
{
	// Methods

	// RVA: 0xD66E38
	public void .ctor() { }

	// RVA: 0xD66E40
	public bool Equals(LoadHint left, LoadHint right) { }

	// RVA: 0xD66EC8
	public int GetHashCode(LoadHint obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_LoadHintEqualityComparer
{
	// Methods

	// RVA: 0xD66EF0
	public void .ctor() { }

	// RVA: 0xD66EF8
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.LoadHint> left, System.Nullable<System.Runtime.CompilerServices.LoadHint> right) { }

	// RVA: 0xD67074
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.LoadHint> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodCodeTypeEqualityComparer
{
	// Methods

	// RVA: 0xD67128
	public void .ctor() { }

	// RVA: 0xD67130
	public bool Equals(MethodCodeType left, MethodCodeType right) { }

	// RVA: 0xD671B8
	public int GetHashCode(MethodCodeType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodCodeTypeEqualityComparer
{
	// Methods

	// RVA: 0xD671E0
	public void .ctor() { }

	// RVA: 0xD671E8
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> left, System.Nullable<System.Runtime.CompilerServices.MethodCodeType> right) { }

	// RVA: 0xD67364
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodCodeType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_CompilerServices_MethodImplOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD67418
	public void .ctor() { }

	// RVA: 0xD67420
	public bool Equals(MethodImplOptions left, MethodImplOptions right) { }

	// RVA: 0xD674A8
	public int GetHashCode(MethodImplOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_CompilerServices_MethodImplOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD674D0
	public void .ctor() { }

	// RVA: 0xD674D8
	public bool Equals(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> left, System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> right) { }

	// RVA: 0xD67654
	public int GetHashCode(System.Nullable<System.Runtime.CompilerServices.MethodImplOptions> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_CerEqualityComparer
{
	// Methods

	// RVA: 0xD67708
	public void .ctor() { }

	// RVA: 0xD67710
	public bool Equals(Cer left, Cer right) { }

	// RVA: 0xD67798
	public int GetHashCode(Cer obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_CerEqualityComparer
{
	// Methods

	// RVA: 0xD677C0
	public void .ctor() { }

	// RVA: 0xD677C8
	public bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Cer> left, System.Nullable<System.Runtime.ConstrainedExecution.Cer> right) { }

	// RVA: 0xD67944
	public int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Cer> obj) { }

}

// Namespace: 
private sealed class System_Runtime_ConstrainedExecution_ConsistencyEqualityComparer
{
	// Methods

	// RVA: 0xD679F8
	public void .ctor() { }

	// RVA: 0xD67A00
	public bool Equals(Consistency left, Consistency right) { }

	// RVA: 0xD67A88
	public int GetHashCode(Consistency obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_ConstrainedExecution_ConsistencyEqualityComparer
{
	// Methods

	// RVA: 0xD67AB0
	public void .ctor() { }

	// RVA: 0xD67AB8
	public bool Equals(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> left, System.Nullable<System.Runtime.ConstrainedExecution.Consistency> right) { }

	// RVA: 0xD67C34
	public int GetHashCode(System.Nullable<System.Runtime.ConstrainedExecution.Consistency> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ArrayWithOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD67CE8
	public void .ctor() { }

	// RVA: 0xD67CF0
	public bool Equals(ArrayWithOffset left, ArrayWithOffset right) { }

	// RVA: 0xD67D20
	public int GetHashCode(ArrayWithOffset obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ArrayWithOffsetEqualityComparer
{
	// Methods

	// RVA: 0xD67D48
	public void .ctor() { }

	// RVA: 0xD67D50
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> left, System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> right) { }

	// RVA: 0xD67EB0
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ArrayWithOffset> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD67F60
	public void .ctor() { }

	// RVA: 0xD67F68
	public bool Equals(AssemblyRegistrationFlags left, AssemblyRegistrationFlags right) { }

	// RVA: 0xD67FF0
	public int GetHashCode(AssemblyRegistrationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_AssemblyRegistrationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD68018
	public void .ctor() { }

	// RVA: 0xD68020
	public bool Equals(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> left, System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> right) { }

	// RVA: 0xD6819C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.AssemblyRegistrationFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CallingConventionEqualityComparer
{
	// Methods

	// RVA: 0xD68250
	public void .ctor() { }

	// RVA: 0xD68258
	public bool Equals(CallingConvention left, CallingConvention right) { }

	// RVA: 0xD682E0
	public int GetHashCode(CallingConvention obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CallingConventionEqualityComparer
{
	// Methods

	// RVA: 0xD68308
	public void .ctor() { }

	// RVA: 0xD68310
	public bool Equals(System.Nullable<System.Runtime.InteropServices.CallingConvention> left, System.Nullable<System.Runtime.InteropServices.CallingConvention> right) { }

	// RVA: 0xD6848C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.CallingConvention> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_CharSetEqualityComparer
{
	// Methods

	// RVA: 0xD68540
	public void .ctor() { }

	// RVA: 0xD68548
	public bool Equals(CharSet left, CharSet right) { }

	// RVA: 0xD685D0
	public int GetHashCode(CharSet obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_CharSetEqualityComparer
{
	// Methods

	// RVA: 0xD685F8
	public void .ctor() { }

	// RVA: 0xD68600
	public bool Equals(System.Nullable<System.Runtime.InteropServices.CharSet> left, System.Nullable<System.Runtime.InteropServices.CharSet> right) { }

	// RVA: 0xD6877C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.CharSet> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD68830
	public void .ctor() { }

	// RVA: 0xD68838
	public bool Equals(ClassInterfaceType left, ClassInterfaceType right) { }

	// RVA: 0xD688C0
	public int GetHashCode(ClassInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ClassInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD688E8
	public void .ctor() { }

	// RVA: 0xD688F0
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> right) { }

	// RVA: 0xD68A6C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ClassInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD68B20
	public void .ctor() { }

	// RVA: 0xD68B28
	public bool Equals(ComInterfaceType left, ComInterfaceType right) { }

	// RVA: 0xD68BB0
	public int GetHashCode(ComInterfaceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComInterfaceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD68BD8
	public void .ctor() { }

	// RVA: 0xD68BE0
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> left, System.Nullable<System.Runtime.InteropServices.ComInterfaceType> right) { }

	// RVA: 0xD68D5C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComInterfaceType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ComMemberTypeEqualityComparer
{
	// Methods

	// RVA: 0xD68E10
	public void .ctor() { }

	// RVA: 0xD68E18
	public bool Equals(ComMemberType left, ComMemberType right) { }

	// RVA: 0xD68EA0
	public int GetHashCode(ComMemberType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ComMemberTypeEqualityComparer
{
	// Methods

	// RVA: 0xD68EC8
	public void .ctor() { }

	// RVA: 0xD68ED0
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ComMemberType> left, System.Nullable<System.Runtime.InteropServices.ComMemberType> right) { }

	// RVA: 0xD6904C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ComMemberType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ExporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD69100
	public void .ctor() { }

	// RVA: 0xD69108
	public bool Equals(ExporterEventKind left, ExporterEventKind right) { }

	// RVA: 0xD69190
	public int GetHashCode(ExporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ExporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD691B8
	public void .ctor() { }

	// RVA: 0xD691C0
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ExporterEventKind> right) { }

	// RVA: 0xD6933C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ExporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleEqualityComparer
{
	// Methods

	// RVA: 0xD693F0
	public void .ctor() { }

	// RVA: 0xD693F8
	public bool Equals(GCHandle left, GCHandle right) { }

	// RVA: 0xD69470
	public int GetHashCode(GCHandle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleEqualityComparer
{
	// Methods

	// RVA: 0xD69498
	public void .ctor() { }

	// RVA: 0xD694A0
	public bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandle> left, System.Nullable<System.Runtime.InteropServices.GCHandle> right) { }

	// RVA: 0xD6960C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_GCHandleTypeEqualityComparer
{
	// Methods

	// RVA: 0xD696C0
	public void .ctor() { }

	// RVA: 0xD696C8
	public bool Equals(GCHandleType left, GCHandleType right) { }

	// RVA: 0xD69750
	public int GetHashCode(GCHandleType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_GCHandleTypeEqualityComparer
{
	// Methods

	// RVA: 0xD69778
	public void .ctor() { }

	// RVA: 0xD69780
	public bool Equals(System.Nullable<System.Runtime.InteropServices.GCHandleType> left, System.Nullable<System.Runtime.InteropServices.GCHandleType> right) { }

	// RVA: 0xD698FC
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.GCHandleType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_HandleRefEqualityComparer
{
	// Methods

	// RVA: 0xD699B0
	public void .ctor() { }

	// RVA: 0xD699B8
	public bool Equals(HandleRef left, HandleRef right) { }

	// RVA: 0xD69A50
	public int GetHashCode(HandleRef obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_HandleRefEqualityComparer
{
	// Methods

	// RVA: 0xD69AC4
	public void .ctor() { }

	// RVA: 0xD69ACC
	public bool Equals(System.Nullable<System.Runtime.InteropServices.HandleRef> left, System.Nullable<System.Runtime.InteropServices.HandleRef> right) { }

	// RVA: 0xD69C60
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.HandleRef> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_ImporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD69D10
	public void .ctor() { }

	// RVA: 0xD69D18
	public bool Equals(ImporterEventKind left, ImporterEventKind right) { }

	// RVA: 0xD69DA0
	public int GetHashCode(ImporterEventKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_ImporterEventKindEqualityComparer
{
	// Methods

	// RVA: 0xD69DC8
	public void .ctor() { }

	// RVA: 0xD69DD0
	public bool Equals(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> left, System.Nullable<System.Runtime.InteropServices.ImporterEventKind> right) { }

	// RVA: 0xD69F4C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.ImporterEventKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_LayoutKindEqualityComparer
{
	// Methods

	// RVA: 0xD6A000
	public void .ctor() { }

	// RVA: 0xD6A008
	public bool Equals(LayoutKind left, LayoutKind right) { }

	// RVA: 0xD6A090
	public int GetHashCode(LayoutKind obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_LayoutKindEqualityComparer
{
	// Methods

	// RVA: 0xD6A0B8
	public void .ctor() { }

	// RVA: 0xD6A0C0
	public bool Equals(System.Nullable<System.Runtime.InteropServices.LayoutKind> left, System.Nullable<System.Runtime.InteropServices.LayoutKind> right) { }

	// RVA: 0xD6A23C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.LayoutKind> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationClassContextEqualityComparer
{
	// Methods

	// RVA: 0xD6A2F0
	public void .ctor() { }

	// RVA: 0xD6A2F8
	public bool Equals(RegistrationClassContext left, RegistrationClassContext right) { }

	// RVA: 0xD6A380
	public int GetHashCode(RegistrationClassContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationClassContextEqualityComparer
{
	// Methods

	// RVA: 0xD6A3A8
	public void .ctor() { }

	// RVA: 0xD6A3B0
	public bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> left, System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> right) { }

	// RVA: 0xD6A52C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationClassContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer
{
	// Methods

	// RVA: 0xD6A5E0
	public void .ctor() { }

	// RVA: 0xD6A5E8
	public bool Equals(RegistrationConnectionType left, RegistrationConnectionType right) { }

	// RVA: 0xD6A670
	public int GetHashCode(RegistrationConnectionType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_RegistrationConnectionTypeEqualityComparer
{
	// Methods

	// RVA: 0xD6A698
	public void .ctor() { }

	// RVA: 0xD6A6A0
	public bool Equals(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> left, System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> right) { }

	// RVA: 0xD6A81C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.RegistrationConnectionType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6A8D0
	public void .ctor() { }

	// RVA: 0xD6A8D8
	public bool Equals(TypeLibExporterFlags left, TypeLibExporterFlags right) { }

	// RVA: 0xD6A960
	public int GetHashCode(TypeLibExporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibExporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6A988
	public void .ctor() { }

	// RVA: 0xD6A990
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> right) { }

	// RVA: 0xD6AB0C
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibExporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6ABC0
	public void .ctor() { }

	// RVA: 0xD6ABC8
	public bool Equals(TypeLibFuncFlags left, TypeLibFuncFlags right) { }

	// RVA: 0xD6AC50
	public int GetHashCode(TypeLibFuncFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibFuncFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6AC78
	public void .ctor() { }

	// RVA: 0xD6AC80
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> right) { }

	// RVA: 0xD6ADFC
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibFuncFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6AEB0
	public void .ctor() { }

	// RVA: 0xD6AEB8
	public bool Equals(TypeLibImporterFlags left, TypeLibImporterFlags right) { }

	// RVA: 0xD6AF40
	public int GetHashCode(TypeLibImporterFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibImporterFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6AF68
	public void .ctor() { }

	// RVA: 0xD6AF70
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> right) { }

	// RVA: 0xD6B0EC
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibImporterFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6B1A0
	public void .ctor() { }

	// RVA: 0xD6B1A8
	public bool Equals(TypeLibTypeFlags left, TypeLibTypeFlags right) { }

	// RVA: 0xD6B230
	public int GetHashCode(TypeLibTypeFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibTypeFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6B258
	public void .ctor() { }

	// RVA: 0xD6B260
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> right) { }

	// RVA: 0xD6B3DC
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibTypeFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6B490
	public void .ctor() { }

	// RVA: 0xD6B498
	public bool Equals(TypeLibVarFlags left, TypeLibVarFlags right) { }

	// RVA: 0xD6B520
	public int GetHashCode(TypeLibVarFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_TypeLibVarFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6B548
	public void .ctor() { }

	// RVA: 0xD6B550
	public bool Equals(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> left, System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> right) { }

	// RVA: 0xD6B6CC
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.TypeLibVarFlags> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_UnmanagedTypeEqualityComparer
{
	// Methods

	// RVA: 0xD6B780
	public void .ctor() { }

	// RVA: 0xD6B788
	public bool Equals(UnmanagedType left, UnmanagedType right) { }

	// RVA: 0xD6B810
	public int GetHashCode(UnmanagedType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_UnmanagedTypeEqualityComparer
{
	// Methods

	// RVA: 0xD6B838
	public void .ctor() { }

	// RVA: 0xD6B840
	public bool Equals(System.Nullable<System.Runtime.InteropServices.UnmanagedType> left, System.Nullable<System.Runtime.InteropServices.UnmanagedType> right) { }

	// RVA: 0xD6B9BC
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.UnmanagedType> obj) { }

}

// Namespace: 
private sealed class System_Runtime_InteropServices_VarEnumEqualityComparer
{
	// Methods

	// RVA: 0xD6BA70
	public void .ctor() { }

	// RVA: 0xD6BA78
	public bool Equals(VarEnum left, VarEnum right) { }

	// RVA: 0xD6BB00
	public int GetHashCode(VarEnum obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_InteropServices_VarEnumEqualityComparer
{
	// Methods

	// RVA: 0xD6BB28
	public void .ctor() { }

	// RVA: 0xD6BB30
	public bool Equals(System.Nullable<System.Runtime.InteropServices.VarEnum> left, System.Nullable<System.Runtime.InteropServices.VarEnum> right) { }

	// RVA: 0xD6BCAC
	public int GetHashCode(System.Nullable<System.Runtime.InteropServices.VarEnum> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_CustomErrorsModesEqualityComparer
{
	// Methods

	// RVA: 0xD6BD60
	public void .ctor() { }

	// RVA: 0xD6BD68
	public bool Equals(CustomErrorsModes left, CustomErrorsModes right) { }

	// RVA: 0xD6BDF0
	public int GetHashCode(CustomErrorsModes obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_CustomErrorsModesEqualityComparer
{
	// Methods

	// RVA: 0xD6BE18
	public void .ctor() { }

	// RVA: 0xD6BE20
	public bool Equals(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> left, System.Nullable<System.Runtime.Remoting.CustomErrorsModes> right) { }

	// RVA: 0xD6BF9C
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.CustomErrorsModes> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_WellKnownObjectModeEqualityComparer
{
	// Methods

	// RVA: 0xD6C050
	public void .ctor() { }

	// RVA: 0xD6C058
	public bool Equals(WellKnownObjectMode left, WellKnownObjectMode right) { }

	// RVA: 0xD6C0E0
	public int GetHashCode(WellKnownObjectMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_WellKnownObjectModeEqualityComparer
{
	// Methods

	// RVA: 0xD6C108
	public void .ctor() { }

	// RVA: 0xD6C110
	public bool Equals(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> left, System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> right) { }

	// RVA: 0xD6C28C
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.WellKnownObjectMode> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer
{
	// Methods

	// RVA: 0xD6C340
	public void .ctor() { }

	// RVA: 0xD6C348
	public bool Equals(ActivatorLevel left, ActivatorLevel right) { }

	// RVA: 0xD6C3D0
	public int GetHashCode(ActivatorLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Activation_ActivatorLevelEqualityComparer
{
	// Methods

	// RVA: 0xD6C3F8
	public void .ctor() { }

	// RVA: 0xD6C400
	public bool Equals(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> left, System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> right) { }

	// RVA: 0xD6C57C
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Activation.ActivatorLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Channels_ServerProcessingEqualityComparer
{
	// Methods

	// RVA: 0xD6C630
	public void .ctor() { }

	// RVA: 0xD6C638
	public bool Equals(ServerProcessing left, ServerProcessing right) { }

	// RVA: 0xD6C6C0
	public int GetHashCode(ServerProcessing obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Channels_ServerProcessingEqualityComparer
{
	// Methods

	// RVA: 0xD6C6E8
	public void .ctor() { }

	// RVA: 0xD6C6F0
	public bool Equals(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> left, System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> right) { }

	// RVA: 0xD6C86C
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Channels.ServerProcessing> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer
{
	// Methods

	// RVA: 0xD6C920
	public void .ctor() { }

	// RVA: 0xD6C928
	public bool Equals(LeaseState left, LeaseState right) { }

	// RVA: 0xD6C9B0
	public int GetHashCode(LeaseState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Lifetime_LeaseStateEqualityComparer
{
	// Methods

	// RVA: 0xD6C9D8
	public void .ctor() { }

	// RVA: 0xD6C9E0
	public bool Equals(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> left, System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> right) { }

	// RVA: 0xD6CB5C
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Lifetime.LeaseState> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_SoapOptionEqualityComparer
{
	// Methods

	// RVA: 0xD6CC10
	public void .ctor() { }

	// RVA: 0xD6CC18
	public bool Equals(SoapOption left, SoapOption right) { }

	// RVA: 0xD6CCA0
	public int GetHashCode(SoapOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_SoapOptionEqualityComparer
{
	// Methods

	// RVA: 0xD6CCC8
	public void .ctor() { }

	// RVA: 0xD6CCD0
	public bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> left, System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> right) { }

	// RVA: 0xD6CE4C
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.SoapOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer
{
	// Methods

	// RVA: 0xD6CF00
	public void .ctor() { }

	// RVA: 0xD6CF08
	public bool Equals(XmlFieldOrderOption left, XmlFieldOrderOption right) { }

	// RVA: 0xD6CF90
	public int GetHashCode(XmlFieldOrderOption obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Remoting_Metadata_XmlFieldOrderOptionEqualityComparer
{
	// Methods

	// RVA: 0xD6CFB8
	public void .ctor() { }

	// RVA: 0xD6CFC0
	public bool Equals(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> left, System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> right) { }

	// RVA: 0xD6D13C
	public int GetHashCode(System.Nullable<System.Runtime.Remoting.Metadata.XmlFieldOrderOption> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_SerializationEntryEqualityComparer
{
	// Methods

	// RVA: 0xD6D1F0
	public void .ctor() { }

	// RVA: 0xD6D1F8
	public bool Equals(SerializationEntry left, SerializationEntry right) { }

	// RVA: 0xD6D298
	public int GetHashCode(SerializationEntry obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_SerializationEntryEqualityComparer
{
	// Methods

	// RVA: 0xD6D314
	public void .ctor() { }

	// RVA: 0xD6D31C
	public bool Equals(System.Nullable<System.Runtime.Serialization.SerializationEntry> left, System.Nullable<System.Runtime.Serialization.SerializationEntry> right) { }

	// RVA: 0xD6D4D0
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.SerializationEntry> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextEqualityComparer
{
	// Methods

	// RVA: 0xD6D580
	public void .ctor() { }

	// RVA: 0xD6D588
	public bool Equals(StreamingContext left, StreamingContext right) { }

	// RVA: 0xD6D604
	public int GetHashCode(StreamingContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextEqualityComparer
{
	// Methods

	// RVA: 0xD6D60C
	public void .ctor() { }

	// RVA: 0xD6D614
	public bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContext> left, System.Nullable<System.Runtime.Serialization.StreamingContext> right) { }

	// RVA: 0xD6D79C
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContext> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_StreamingContextStatesEqualityComparer
{
	// Methods

	// RVA: 0xD6D84C
	public void .ctor() { }

	// RVA: 0xD6D854
	public bool Equals(StreamingContextStates left, StreamingContextStates right) { }

	// RVA: 0xD6D8DC
	public int GetHashCode(StreamingContextStates obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_StreamingContextStatesEqualityComparer
{
	// Methods

	// RVA: 0xD6D904
	public void .ctor() { }

	// RVA: 0xD6D90C
	public bool Equals(System.Nullable<System.Runtime.Serialization.StreamingContextStates> left, System.Nullable<System.Runtime.Serialization.StreamingContextStates> right) { }

	// RVA: 0xD6DA88
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.StreamingContextStates> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer
{
	// Methods

	// RVA: 0xD6DB3C
	public void .ctor() { }

	// RVA: 0xD6DB44
	public bool Equals(FormatterAssemblyStyle left, FormatterAssemblyStyle right) { }

	// RVA: 0xD6DBCC
	public int GetHashCode(FormatterAssemblyStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterAssemblyStyleEqualityComparer
{
	// Methods

	// RVA: 0xD6DBF4
	public void .ctor() { }

	// RVA: 0xD6DBFC
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> right) { }

	// RVA: 0xD6DD78
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterAssemblyStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer
{
	// Methods

	// RVA: 0xD6DE2C
	public void .ctor() { }

	// RVA: 0xD6DE34
	public bool Equals(FormatterTypeStyle left, FormatterTypeStyle right) { }

	// RVA: 0xD6DEBC
	public int GetHashCode(FormatterTypeStyle obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_FormatterTypeStyleEqualityComparer
{
	// Methods

	// RVA: 0xD6DEE4
	public void .ctor() { }

	// RVA: 0xD6DEEC
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> left, System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> right) { }

	// RVA: 0xD6E068
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.FormatterTypeStyle> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer
{
	// Methods

	// RVA: 0xD6E11C
	public void .ctor() { }

	// RVA: 0xD6E124
	public bool Equals(TypeFilterLevel left, TypeFilterLevel right) { }

	// RVA: 0xD6E1AC
	public int GetHashCode(TypeFilterLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Serialization_Formatters_TypeFilterLevelEqualityComparer
{
	// Methods

	// RVA: 0xD6E1D4
	public void .ctor() { }

	// RVA: 0xD6E1DC
	public bool Equals(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> left, System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> right) { }

	// RVA: 0xD6E358
	public int GetHashCode(System.Nullable<System.Runtime.Serialization.Formatters.TypeFilterLevel> obj) { }

}

// Namespace: 
private sealed class System_Runtime_Versioning_ResourceScopeEqualityComparer
{
	// Methods

	// RVA: 0xD6E40C
	public void .ctor() { }

	// RVA: 0xD6E414
	public bool Equals(ResourceScope left, ResourceScope right) { }

	// RVA: 0xD6E49C
	public int GetHashCode(ResourceScope obj) { }

}

// Namespace: 
private sealed class NullableSystem_Runtime_Versioning_ResourceScopeEqualityComparer
{
	// Methods

	// RVA: 0xD6E4C4
	public void .ctor() { }

	// RVA: 0xD6E4CC
	public bool Equals(System.Nullable<System.Runtime.Versioning.ResourceScope> left, System.Nullable<System.Runtime.Versioning.ResourceScope> right) { }

	// RVA: 0xD6E648
	public int GetHashCode(System.Nullable<System.Runtime.Versioning.ResourceScope> obj) { }

}

// Namespace: 
private sealed class System_Security_HostSecurityManagerOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD6E6FC
	public void .ctor() { }

	// RVA: 0xD6E704
	public bool Equals(HostSecurityManagerOptions left, HostSecurityManagerOptions right) { }

	// RVA: 0xD6E78C
	public int GetHashCode(HostSecurityManagerOptions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_HostSecurityManagerOptionsEqualityComparer
{
	// Methods

	// RVA: 0xD6E7B4
	public void .ctor() { }

	// RVA: 0xD6E7BC
	public bool Equals(System.Nullable<System.Security.HostSecurityManagerOptions> left, System.Nullable<System.Security.HostSecurityManagerOptions> right) { }

	// RVA: 0xD6E938
	public int GetHashCode(System.Nullable<System.Security.HostSecurityManagerOptions> obj) { }

}

// Namespace: 
private sealed class System_Security_PolicyLevelTypeEqualityComparer
{
	// Methods

	// RVA: 0xD6E9EC
	public void .ctor() { }

	// RVA: 0xD6E9F4
	public bool Equals(PolicyLevelType left, PolicyLevelType right) { }

	// RVA: 0xD6EA7C
	public int GetHashCode(PolicyLevelType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_PolicyLevelTypeEqualityComparer
{
	// Methods

	// RVA: 0xD6EAA4
	public void .ctor() { }

	// RVA: 0xD6EAAC
	public bool Equals(System.Nullable<System.Security.PolicyLevelType> left, System.Nullable<System.Security.PolicyLevelType> right) { }

	// RVA: 0xD6EC28
	public int GetHashCode(System.Nullable<System.Security.PolicyLevelType> obj) { }

}

// Namespace: 
private sealed class System_Security_SecurityZoneEqualityComparer
{
	// Methods

	// RVA: 0xD6ECDC
	public void .ctor() { }

	// RVA: 0xD6ECE4
	public bool Equals(SecurityZone left, SecurityZone right) { }

	// RVA: 0xD6ED6C
	public int GetHashCode(SecurityZone obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_SecurityZoneEqualityComparer
{
	// Methods

	// RVA: 0xD6ED94
	public void .ctor() { }

	// RVA: 0xD6ED9C
	public bool Equals(System.Nullable<System.Security.SecurityZone> left, System.Nullable<System.Security.SecurityZone> right) { }

	// RVA: 0xD6EF18
	public int GetHashCode(System.Nullable<System.Security.SecurityZone> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlActionsEqualityComparer
{
	// Methods

	// RVA: 0xD6EFCC
	public void .ctor() { }

	// RVA: 0xD6EFD4
	public bool Equals(AccessControlActions left, AccessControlActions right) { }

	// RVA: 0xD6F05C
	public int GetHashCode(AccessControlActions obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlActionsEqualityComparer
{
	// Methods

	// RVA: 0xD6F084
	public void .ctor() { }

	// RVA: 0xD6F08C
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlActions> left, System.Nullable<System.Security.AccessControl.AccessControlActions> right) { }

	// RVA: 0xD6F208
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlActions> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlModificationEqualityComparer
{
	// Methods

	// RVA: 0xD6F2BC
	public void .ctor() { }

	// RVA: 0xD6F2C4
	public bool Equals(AccessControlModification left, AccessControlModification right) { }

	// RVA: 0xD6F34C
	public int GetHashCode(AccessControlModification obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlModificationEqualityComparer
{
	// Methods

	// RVA: 0xD6F374
	public void .ctor() { }

	// RVA: 0xD6F37C
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlModification> left, System.Nullable<System.Security.AccessControl.AccessControlModification> right) { }

	// RVA: 0xD6F4F8
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlModification> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlSectionsEqualityComparer
{
	// Methods

	// RVA: 0xD6F5AC
	public void .ctor() { }

	// RVA: 0xD6F5B4
	public bool Equals(AccessControlSections left, AccessControlSections right) { }

	// RVA: 0xD6F63C
	public int GetHashCode(AccessControlSections obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlSectionsEqualityComparer
{
	// Methods

	// RVA: 0xD6F664
	public void .ctor() { }

	// RVA: 0xD6F66C
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlSections> left, System.Nullable<System.Security.AccessControl.AccessControlSections> right) { }

	// RVA: 0xD6F7E8
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlSections> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AccessControlTypeEqualityComparer
{
	// Methods

	// RVA: 0xD6F89C
	public void .ctor() { }

	// RVA: 0xD6F8A4
	public bool Equals(AccessControlType left, AccessControlType right) { }

	// RVA: 0xD6F92C
	public int GetHashCode(AccessControlType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AccessControlTypeEqualityComparer
{
	// Methods

	// RVA: 0xD6F954
	public void .ctor() { }

	// RVA: 0xD6F95C
	public bool Equals(System.Nullable<System.Security.AccessControl.AccessControlType> left, System.Nullable<System.Security.AccessControl.AccessControlType> right) { }

	// RVA: 0xD6FAD8
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AccessControlType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6FB8C
	public void .ctor() { }

	// RVA: 0xD6FB94
	public bool Equals(AceFlags left, AceFlags right) { }

	// RVA: 0xD6FC1C
	public int GetHashCode(AceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD6FC44
	public void .ctor() { }

	// RVA: 0xD6FC4C
	public bool Equals(System.Nullable<System.Security.AccessControl.AceFlags> left, System.Nullable<System.Security.AccessControl.AceFlags> right) { }

	// RVA: 0xD6FDC8
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceQualifierEqualityComparer
{
	// Methods

	// RVA: 0xD6FE7C
	public void .ctor() { }

	// RVA: 0xD6FE84
	public bool Equals(AceQualifier left, AceQualifier right) { }

	// RVA: 0xD6FF0C
	public int GetHashCode(AceQualifier obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceQualifierEqualityComparer
{
	// Methods

	// RVA: 0xD6FF34
	public void .ctor() { }

	// RVA: 0xD6FF3C
	public bool Equals(System.Nullable<System.Security.AccessControl.AceQualifier> left, System.Nullable<System.Security.AccessControl.AceQualifier> right) { }

	// RVA: 0xD700B8
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceQualifier> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD7016C
	public void .ctor() { }

	// RVA: 0xD70174
	public bool Equals(AceType left, AceType right) { }

	// RVA: 0xD701FC
	public int GetHashCode(AceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD70224
	public void .ctor() { }

	// RVA: 0xD7022C
	public bool Equals(System.Nullable<System.Security.AccessControl.AceType> left, System.Nullable<System.Security.AccessControl.AceType> right) { }

	// RVA: 0xD703A8
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_AuditFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD7045C
	public void .ctor() { }

	// RVA: 0xD70464
	public bool Equals(AuditFlags left, AuditFlags right) { }

	// RVA: 0xD704EC
	public int GetHashCode(AuditFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_AuditFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD70514
	public void .ctor() { }

	// RVA: 0xD7051C
	public bool Equals(System.Nullable<System.Security.AccessControl.AuditFlags> left, System.Nullable<System.Security.AccessControl.AuditFlags> right) { }

	// RVA: 0xD70698
	public int GetHashCode(System.Nullable<System.Security.AccessControl.AuditFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CompoundAceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD7074C
	public void .ctor() { }

	// RVA: 0xD70754
	public bool Equals(CompoundAceType left, CompoundAceType right) { }

	// RVA: 0xD707DC
	public int GetHashCode(CompoundAceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CompoundAceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD70804
	public void .ctor() { }

	// RVA: 0xD7080C
	public bool Equals(System.Nullable<System.Security.AccessControl.CompoundAceType> left, System.Nullable<System.Security.AccessControl.CompoundAceType> right) { }

	// RVA: 0xD70988
	public int GetHashCode(System.Nullable<System.Security.AccessControl.CompoundAceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ControlFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD70A3C
	public void .ctor() { }

	// RVA: 0xD70A44
	public bool Equals(ControlFlags left, ControlFlags right) { }

	// RVA: 0xD70ACC
	public int GetHashCode(ControlFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ControlFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD70AF4
	public void .ctor() { }

	// RVA: 0xD70AFC
	public bool Equals(System.Nullable<System.Security.AccessControl.ControlFlags> left, System.Nullable<System.Security.AccessControl.ControlFlags> right) { }

	// RVA: 0xD70C78
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ControlFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_CryptoKeyRightsEqualityComparer
{
	// Methods

	// RVA: 0xD70D2C
	public void .ctor() { }

	// RVA: 0xD70D34
	public bool Equals(CryptoKeyRights left, CryptoKeyRights right) { }

	// RVA: 0xD70DBC
	public int GetHashCode(CryptoKeyRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_CryptoKeyRightsEqualityComparer
{
	// Methods

	// RVA: 0xD70DE4
	public void .ctor() { }

	// RVA: 0xD70DEC
	public bool Equals(System.Nullable<System.Security.AccessControl.CryptoKeyRights> left, System.Nullable<System.Security.AccessControl.CryptoKeyRights> right) { }

	// RVA: 0xD70F68
	public int GetHashCode(System.Nullable<System.Security.AccessControl.CryptoKeyRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_EventWaitHandleRightsEqualityComparer
{
	// Methods

	// RVA: 0xD7101C
	public void .ctor() { }

	// RVA: 0xD71024
	public bool Equals(EventWaitHandleRights left, EventWaitHandleRights right) { }

	// RVA: 0xD710AC
	public int GetHashCode(EventWaitHandleRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_EventWaitHandleRightsEqualityComparer
{
	// Methods

	// RVA: 0xD710D4
	public void .ctor() { }

	// RVA: 0xD710DC
	public bool Equals(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> left, System.Nullable<System.Security.AccessControl.EventWaitHandleRights> right) { }

	// RVA: 0xD71258
	public int GetHashCode(System.Nullable<System.Security.AccessControl.EventWaitHandleRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_FileSystemRightsEqualityComparer
{
	// Methods

	// RVA: 0xD7130C
	public void .ctor() { }

	// RVA: 0xD71314
	public bool Equals(FileSystemRights left, FileSystemRights right) { }

	// RVA: 0xD7139C
	public int GetHashCode(FileSystemRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_FileSystemRightsEqualityComparer
{
	// Methods

	// RVA: 0xD713C4
	public void .ctor() { }

	// RVA: 0xD713CC
	public bool Equals(System.Nullable<System.Security.AccessControl.FileSystemRights> left, System.Nullable<System.Security.AccessControl.FileSystemRights> right) { }

	// RVA: 0xD71548
	public int GetHashCode(System.Nullable<System.Security.AccessControl.FileSystemRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_InheritanceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD715FC
	public void .ctor() { }

	// RVA: 0xD71604
	public bool Equals(InheritanceFlags left, InheritanceFlags right) { }

	// RVA: 0xD7168C
	public int GetHashCode(InheritanceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_InheritanceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD716B4
	public void .ctor() { }

	// RVA: 0xD716BC
	public bool Equals(System.Nullable<System.Security.AccessControl.InheritanceFlags> left, System.Nullable<System.Security.AccessControl.InheritanceFlags> right) { }

	// RVA: 0xD71838
	public int GetHashCode(System.Nullable<System.Security.AccessControl.InheritanceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_MutexRightsEqualityComparer
{
	// Methods

	// RVA: 0xD718EC
	public void .ctor() { }

	// RVA: 0xD718F4
	public bool Equals(MutexRights left, MutexRights right) { }

	// RVA: 0xD7197C
	public int GetHashCode(MutexRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_MutexRightsEqualityComparer
{
	// Methods

	// RVA: 0xD719A4
	public void .ctor() { }

	// RVA: 0xD719AC
	public bool Equals(System.Nullable<System.Security.AccessControl.MutexRights> left, System.Nullable<System.Security.AccessControl.MutexRights> right) { }

	// RVA: 0xD71B28
	public int GetHashCode(System.Nullable<System.Security.AccessControl.MutexRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ObjectAceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD71BDC
	public void .ctor() { }

	// RVA: 0xD71BE4
	public bool Equals(ObjectAceFlags left, ObjectAceFlags right) { }

	// RVA: 0xD71C6C
	public int GetHashCode(ObjectAceFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ObjectAceFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD71C94
	public void .ctor() { }

	// RVA: 0xD71C9C
	public bool Equals(System.Nullable<System.Security.AccessControl.ObjectAceFlags> left, System.Nullable<System.Security.AccessControl.ObjectAceFlags> right) { }

	// RVA: 0xD71E18
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ObjectAceFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_PropagationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD71ECC
	public void .ctor() { }

	// RVA: 0xD71ED4
	public bool Equals(PropagationFlags left, PropagationFlags right) { }

	// RVA: 0xD71F5C
	public int GetHashCode(PropagationFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_PropagationFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD71F84
	public void .ctor() { }

	// RVA: 0xD71F8C
	public bool Equals(System.Nullable<System.Security.AccessControl.PropagationFlags> left, System.Nullable<System.Security.AccessControl.PropagationFlags> right) { }

	// RVA: 0xD72108
	public int GetHashCode(System.Nullable<System.Security.AccessControl.PropagationFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_RegistryRightsEqualityComparer
{
	// Methods

	// RVA: 0xD721BC
	public void .ctor() { }

	// RVA: 0xD721C4
	public bool Equals(RegistryRights left, RegistryRights right) { }

	// RVA: 0xD7224C
	public int GetHashCode(RegistryRights obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_RegistryRightsEqualityComparer
{
	// Methods

	// RVA: 0xD72274
	public void .ctor() { }

	// RVA: 0xD7227C
	public bool Equals(System.Nullable<System.Security.AccessControl.RegistryRights> left, System.Nullable<System.Security.AccessControl.RegistryRights> right) { }

	// RVA: 0xD723F8
	public int GetHashCode(System.Nullable<System.Security.AccessControl.RegistryRights> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_ResourceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD724AC
	public void .ctor() { }

	// RVA: 0xD724B4
	public bool Equals(ResourceType left, ResourceType right) { }

	// RVA: 0xD7253C
	public int GetHashCode(ResourceType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_ResourceTypeEqualityComparer
{
	// Methods

	// RVA: 0xD72564
	public void .ctor() { }

	// RVA: 0xD7256C
	public bool Equals(System.Nullable<System.Security.AccessControl.ResourceType> left, System.Nullable<System.Security.AccessControl.ResourceType> right) { }

	// RVA: 0xD726E8
	public int GetHashCode(System.Nullable<System.Security.AccessControl.ResourceType> obj) { }

}

// Namespace: 
private sealed class System_Security_AccessControl_SecurityInfosEqualityComparer
{
	// Methods

	// RVA: 0xD7279C
	public void .ctor() { }

	// RVA: 0xD727A4
	public bool Equals(SecurityInfos left, SecurityInfos right) { }

	// RVA: 0xD7282C
	public int GetHashCode(SecurityInfos obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_AccessControl_SecurityInfosEqualityComparer
{
	// Methods

	// RVA: 0xD72854
	public void .ctor() { }

	// RVA: 0xD7285C
	public bool Equals(System.Nullable<System.Security.AccessControl.SecurityInfos> left, System.Nullable<System.Security.AccessControl.SecurityInfos> right) { }

	// RVA: 0xD729D8
	public int GetHashCode(System.Nullable<System.Security.AccessControl.SecurityInfos> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CipherModeEqualityComparer
{
	// Methods

	// RVA: 0xD72A8C
	public void .ctor() { }

	// RVA: 0xD72A94
	public bool Equals(CipherMode left, CipherMode right) { }

	// RVA: 0xD72B1C
	public int GetHashCode(CipherMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CipherModeEqualityComparer
{
	// Methods

	// RVA: 0xD72B44
	public void .ctor() { }

	// RVA: 0xD72B4C
	public bool Equals(System.Nullable<System.Security.Cryptography.CipherMode> left, System.Nullable<System.Security.Cryptography.CipherMode> right) { }

	// RVA: 0xD72CC8
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CipherMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CryptoStreamModeEqualityComparer
{
	// Methods

	// RVA: 0xD72D7C
	public void .ctor() { }

	// RVA: 0xD72D84
	public bool Equals(CryptoStreamMode left, CryptoStreamMode right) { }

	// RVA: 0xD72E0C
	public int GetHashCode(CryptoStreamMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CryptoStreamModeEqualityComparer
{
	// Methods

	// RVA: 0xD72E34
	public void .ctor() { }

	// RVA: 0xD72E3C
	public bool Equals(System.Nullable<System.Security.Cryptography.CryptoStreamMode> left, System.Nullable<System.Security.Cryptography.CryptoStreamMode> right) { }

	// RVA: 0xD72FB8
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CryptoStreamMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_CspProviderFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD7306C
	public void .ctor() { }

	// RVA: 0xD73074
	public bool Equals(CspProviderFlags left, CspProviderFlags right) { }

	// RVA: 0xD730FC
	public int GetHashCode(CspProviderFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_CspProviderFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD73124
	public void .ctor() { }

	// RVA: 0xD7312C
	public bool Equals(System.Nullable<System.Security.Cryptography.CspProviderFlags> left, System.Nullable<System.Security.Cryptography.CspProviderFlags> right) { }

	// RVA: 0xD732A8
	public int GetHashCode(System.Nullable<System.Security.Cryptography.CspProviderFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_DSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD7335C
	public void .ctor() { }

	// RVA: 0xD73364
	public bool Equals(DSAParameters left, DSAParameters right) { }

	// RVA: 0xD73404
	public int GetHashCode(DSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_DSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD73480
	public void .ctor() { }

	// RVA: 0xD73488
	public bool Equals(System.Nullable<System.Security.Cryptography.DSAParameters> left, System.Nullable<System.Security.Cryptography.DSAParameters> right) { }

	// RVA: 0xD7364C
	public int GetHashCode(System.Nullable<System.Security.Cryptography.DSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_FromBase64TransformModeEqualityComparer
{
	// Methods

	// RVA: 0xD736FC
	public void .ctor() { }

	// RVA: 0xD73704
	public bool Equals(FromBase64TransformMode left, FromBase64TransformMode right) { }

	// RVA: 0xD7378C
	public int GetHashCode(FromBase64TransformMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_FromBase64TransformModeEqualityComparer
{
	// Methods

	// RVA: 0xD737B4
	public void .ctor() { }

	// RVA: 0xD737BC
	public bool Equals(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> left, System.Nullable<System.Security.Cryptography.FromBase64TransformMode> right) { }

	// RVA: 0xD73938
	public int GetHashCode(System.Nullable<System.Security.Cryptography.FromBase64TransformMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_KeyNumberEqualityComparer
{
	// Methods

	// RVA: 0xD739EC
	public void .ctor() { }

	// RVA: 0xD739F4
	public bool Equals(KeyNumber left, KeyNumber right) { }

	// RVA: 0xD73A7C
	public int GetHashCode(KeyNumber obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_KeyNumberEqualityComparer
{
	// Methods

	// RVA: 0xD73AA4
	public void .ctor() { }

	// RVA: 0xD73AAC
	public bool Equals(System.Nullable<System.Security.Cryptography.KeyNumber> left, System.Nullable<System.Security.Cryptography.KeyNumber> right) { }

	// RVA: 0xD73C28
	public int GetHashCode(System.Nullable<System.Security.Cryptography.KeyNumber> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_PaddingModeEqualityComparer
{
	// Methods

	// RVA: 0xD73CDC
	public void .ctor() { }

	// RVA: 0xD73CE4
	public bool Equals(PaddingMode left, PaddingMode right) { }

	// RVA: 0xD73D6C
	public int GetHashCode(PaddingMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_PaddingModeEqualityComparer
{
	// Methods

	// RVA: 0xD73D94
	public void .ctor() { }

	// RVA: 0xD73D9C
	public bool Equals(System.Nullable<System.Security.Cryptography.PaddingMode> left, System.Nullable<System.Security.Cryptography.PaddingMode> right) { }

	// RVA: 0xD73F18
	public int GetHashCode(System.Nullable<System.Security.Cryptography.PaddingMode> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_RSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD73FCC
	public void .ctor() { }

	// RVA: 0xD73FD4
	public bool Equals(RSAParameters left, RSAParameters right) { }

	// RVA: 0xD74074
	public int GetHashCode(RSAParameters obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_RSAParametersEqualityComparer
{
	// Methods

	// RVA: 0xD740F0
	public void .ctor() { }

	// RVA: 0xD740F8
	public bool Equals(System.Nullable<System.Security.Cryptography.RSAParameters> left, System.Nullable<System.Security.Cryptography.RSAParameters> right) { }

	// RVA: 0xD742BC
	public int GetHashCode(System.Nullable<System.Security.Cryptography.RSAParameters> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer
{
	// Methods

	// RVA: 0xD7436C
	public void .ctor() { }

	// RVA: 0xD74374
	public bool Equals(X509ContentType left, X509ContentType right) { }

	// RVA: 0xD743FC
	public int GetHashCode(X509ContentType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509ContentTypeEqualityComparer
{
	// Methods

	// RVA: 0xD74424
	public void .ctor() { }

	// RVA: 0xD7442C
	public bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> right) { }

	// RVA: 0xD745A8
	public int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509ContentType> obj) { }

}

// Namespace: 
private sealed class System_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD7465C
	public void .ctor() { }

	// RVA: 0xD74664
	public bool Equals(X509KeyStorageFlags left, X509KeyStorageFlags right) { }

	// RVA: 0xD746EC
	public int GetHashCode(X509KeyStorageFlags obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Cryptography_X509Certificates_X509KeyStorageFlagsEqualityComparer
{
	// Methods

	// RVA: 0xD74714
	public void .ctor() { }

	// RVA: 0xD7471C
	public bool Equals(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> left, System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> right) { }

	// RVA: 0xD74898
	public int GetHashCode(System.Nullable<System.Security.Cryptography.X509Certificates.X509KeyStorageFlags> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_ApplicationVersionMatchEqualityComparer
{
	// Methods

	// RVA: 0xD7494C
	public void .ctor() { }

	// RVA: 0xD74954
	public bool Equals(ApplicationVersionMatch left, ApplicationVersionMatch right) { }

	// RVA: 0xD749DC
	public int GetHashCode(ApplicationVersionMatch obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_ApplicationVersionMatchEqualityComparer
{
	// Methods

	// RVA: 0xD74A04
	public void .ctor() { }

	// RVA: 0xD74A0C
	public bool Equals(System.Nullable<System.Security.Policy.ApplicationVersionMatch> left, System.Nullable<System.Security.Policy.ApplicationVersionMatch> right) { }

	// RVA: 0xD74B88
	public int GetHashCode(System.Nullable<System.Security.Policy.ApplicationVersionMatch> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_PolicyStatementAttributeEqualityComparer
{
	// Methods

	// RVA: 0xD74C3C
	public void .ctor() { }

	// RVA: 0xD74C44
	public bool Equals(PolicyStatementAttribute left, PolicyStatementAttribute right) { }

	// RVA: 0xD74CCC
	public int GetHashCode(PolicyStatementAttribute obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_PolicyStatementAttributeEqualityComparer
{
	// Methods

	// RVA: 0xD74CF4
	public void .ctor() { }

	// RVA: 0xD74CFC
	public bool Equals(System.Nullable<System.Security.Policy.PolicyStatementAttribute> left, System.Nullable<System.Security.Policy.PolicyStatementAttribute> right) { }

	// RVA: 0xD74E78
	public int GetHashCode(System.Nullable<System.Security.Policy.PolicyStatementAttribute> obj) { }

}

// Namespace: 
private sealed class System_Security_Policy_TrustManagerUIContextEqualityComparer
{
	// Methods

	// RVA: 0xD74F2C
	public void .ctor() { }

	// RVA: 0xD74F34
	public bool Equals(TrustManagerUIContext left, TrustManagerUIContext right) { }

	// RVA: 0xD74FBC
	public int GetHashCode(TrustManagerUIContext obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Policy_TrustManagerUIContextEqualityComparer
{
	// Methods

	// RVA: 0xD74FE4
	public void .ctor() { }

	// RVA: 0xD74FEC
	public bool Equals(System.Nullable<System.Security.Policy.TrustManagerUIContext> left, System.Nullable<System.Security.Policy.TrustManagerUIContext> right) { }

	// RVA: 0xD75168
	public int GetHashCode(System.Nullable<System.Security.Policy.TrustManagerUIContext> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_PrincipalPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD7521C
	public void .ctor() { }

	// RVA: 0xD75224
	public bool Equals(PrincipalPolicy left, PrincipalPolicy right) { }

	// RVA: 0xD752AC
	public int GetHashCode(PrincipalPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_PrincipalPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD752D4
	public void .ctor() { }

	// RVA: 0xD752DC
	public bool Equals(System.Nullable<System.Security.Principal.PrincipalPolicy> left, System.Nullable<System.Security.Principal.PrincipalPolicy> right) { }

	// RVA: 0xD75458
	public int GetHashCode(System.Nullable<System.Security.Principal.PrincipalPolicy> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenAccessLevelsEqualityComparer
{
	// Methods

	// RVA: 0xD7550C
	public void .ctor() { }

	// RVA: 0xD75514
	public bool Equals(TokenAccessLevels left, TokenAccessLevels right) { }

	// RVA: 0xD7559C
	public int GetHashCode(TokenAccessLevels obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenAccessLevelsEqualityComparer
{
	// Methods

	// RVA: 0xD755C4
	public void .ctor() { }

	// RVA: 0xD755CC
	public bool Equals(System.Nullable<System.Security.Principal.TokenAccessLevels> left, System.Nullable<System.Security.Principal.TokenAccessLevels> right) { }

	// RVA: 0xD75748
	public int GetHashCode(System.Nullable<System.Security.Principal.TokenAccessLevels> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_TokenImpersonationLevelEqualityComparer
{
	// Methods

	// RVA: 0xD757FC
	public void .ctor() { }

	// RVA: 0xD75804
	public bool Equals(TokenImpersonationLevel left, TokenImpersonationLevel right) { }

	// RVA: 0xD7588C
	public int GetHashCode(TokenImpersonationLevel obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_TokenImpersonationLevelEqualityComparer
{
	// Methods

	// RVA: 0xD758B4
	public void .ctor() { }

	// RVA: 0xD758BC
	public bool Equals(System.Nullable<System.Security.Principal.TokenImpersonationLevel> left, System.Nullable<System.Security.Principal.TokenImpersonationLevel> right) { }

	// RVA: 0xD75A38
	public int GetHashCode(System.Nullable<System.Security.Principal.TokenImpersonationLevel> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WellKnownSidTypeEqualityComparer
{
	// Methods

	// RVA: 0xD75AEC
	public void .ctor() { }

	// RVA: 0xD75AF4
	public bool Equals(WellKnownSidType left, WellKnownSidType right) { }

	// RVA: 0xD75B7C
	public int GetHashCode(WellKnownSidType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WellKnownSidTypeEqualityComparer
{
	// Methods

	// RVA: 0xD75BA4
	public void .ctor() { }

	// RVA: 0xD75BAC
	public bool Equals(System.Nullable<System.Security.Principal.WellKnownSidType> left, System.Nullable<System.Security.Principal.WellKnownSidType> right) { }

	// RVA: 0xD75D28
	public int GetHashCode(System.Nullable<System.Security.Principal.WellKnownSidType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsAccountTypeEqualityComparer
{
	// Methods

	// RVA: 0xD75DDC
	public void .ctor() { }

	// RVA: 0xD75DE4
	public bool Equals(WindowsAccountType left, WindowsAccountType right) { }

	// RVA: 0xD75E6C
	public int GetHashCode(WindowsAccountType obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsAccountTypeEqualityComparer
{
	// Methods

	// RVA: 0xD75E94
	public void .ctor() { }

	// RVA: 0xD75E9C
	public bool Equals(System.Nullable<System.Security.Principal.WindowsAccountType> left, System.Nullable<System.Security.Principal.WindowsAccountType> right) { }

	// RVA: 0xD76018
	public int GetHashCode(System.Nullable<System.Security.Principal.WindowsAccountType> obj) { }

}

// Namespace: 
private sealed class System_Security_Principal_WindowsBuiltInRoleEqualityComparer
{
	// Methods

	// RVA: 0xD760CC
	public void .ctor() { }

	// RVA: 0xD760D4
	public bool Equals(WindowsBuiltInRole left, WindowsBuiltInRole right) { }

	// RVA: 0xD7615C
	public int GetHashCode(WindowsBuiltInRole obj) { }

}

// Namespace: 
private sealed class NullableSystem_Security_Principal_WindowsBuiltInRoleEqualityComparer
{
	// Methods

	// RVA: 0xD76184
	public void .ctor() { }

	// RVA: 0xD7618C
	public bool Equals(System.Nullable<System.Security.Principal.WindowsBuiltInRole> left, System.Nullable<System.Security.Principal.WindowsBuiltInRole> right) { }

	// RVA: 0xD76308
	public int GetHashCode(System.Nullable<System.Security.Principal.WindowsBuiltInRole> obj) { }

}

// Namespace: 
private sealed class System_Text_NormalizationFormEqualityComparer
{
	// Methods

	// RVA: 0xD763BC
	public void .ctor() { }

	// RVA: 0xD763C4
	public bool Equals(NormalizationForm left, NormalizationForm right) { }

	// RVA: 0xD7644C
	public int GetHashCode(NormalizationForm obj) { }

}

// Namespace: 
private sealed class NullableSystem_Text_NormalizationFormEqualityComparer
{
	// Methods

	// RVA: 0xD76474
	public void .ctor() { }

	// RVA: 0xD7647C
	public bool Equals(System.Nullable<System.Text.NormalizationForm> left, System.Nullable<System.Text.NormalizationForm> right) { }

	// RVA: 0xD765F8
	public int GetHashCode(System.Nullable<System.Text.NormalizationForm> obj) { }

}

// Namespace: 
private sealed class System_Threading_ApartmentStateEqualityComparer
{
	// Methods

	// RVA: 0xD766AC
	public void .ctor() { }

	// RVA: 0xD766B4
	public bool Equals(ApartmentState left, ApartmentState right) { }

	// RVA: 0xD7673C
	public int GetHashCode(ApartmentState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ApartmentStateEqualityComparer
{
	// Methods

	// RVA: 0xD76764
	public void .ctor() { }

	// RVA: 0xD7676C
	public bool Equals(System.Nullable<System.Threading.ApartmentState> left, System.Nullable<System.Threading.ApartmentState> right) { }

	// RVA: 0xD768E8
	public int GetHashCode(System.Nullable<System.Threading.ApartmentState> obj) { }

}

// Namespace: 
private sealed class System_Threading_AsyncFlowControlEqualityComparer
{
	// Methods

	// RVA: 0xD7699C
	public void .ctor() { }

	// RVA: 0xD769A4
	public bool Equals(AsyncFlowControl left, AsyncFlowControl right) { }

	// RVA: 0xD769DC
	public int GetHashCode(AsyncFlowControl obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_AsyncFlowControlEqualityComparer
{
	// Methods

	// RVA: 0xD769E8
	public void .ctor() { }

	// RVA: 0xD769F0
	public bool Equals(System.Nullable<System.Threading.AsyncFlowControl> left, System.Nullable<System.Threading.AsyncFlowControl> right) { }

	// RVA: 0xD76B68
	public int GetHashCode(System.Nullable<System.Threading.AsyncFlowControl> obj) { }

}

// Namespace: 
private sealed class System_Threading_EventResetModeEqualityComparer
{
	// Methods

	// RVA: 0xD76C18
	public void .ctor() { }

	// RVA: 0xD76C20
	public bool Equals(EventResetMode left, EventResetMode right) { }

	// RVA: 0xD76CA8
	public int GetHashCode(EventResetMode obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_EventResetModeEqualityComparer
{
	// Methods

	// RVA: 0xD76CD0
	public void .ctor() { }

	// RVA: 0xD76CD8
	public bool Equals(System.Nullable<System.Threading.EventResetMode> left, System.Nullable<System.Threading.EventResetMode> right) { }

	// RVA: 0xD76E54
	public int GetHashCode(System.Nullable<System.Threading.EventResetMode> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockCookieEqualityComparer
{
	// Methods

	// RVA: 0xD76F08
	public void .ctor() { }

	// RVA: 0xD76F10
	public bool Equals(LockCookie left, LockCookie right) { }

	// RVA: 0xD76F44
	public int GetHashCode(LockCookie obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockCookieEqualityComparer
{
	// Methods

	// RVA: 0xD76F70
	public void .ctor() { }

	// RVA: 0xD76F78
	public bool Equals(System.Nullable<System.Threading.LockCookie> left, System.Nullable<System.Threading.LockCookie> right) { }

	// RVA: 0xD770D4
	public int GetHashCode(System.Nullable<System.Threading.LockCookie> obj) { }

}

// Namespace: 
private sealed class System_Threading_LockRecursionPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD77188
	public void .ctor() { }

	// RVA: 0xD77190
	public bool Equals(LockRecursionPolicy left, LockRecursionPolicy right) { }

	// RVA: 0xD77218
	public int GetHashCode(LockRecursionPolicy obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_LockRecursionPolicyEqualityComparer
{
	// Methods

	// RVA: 0xD77240
	public void .ctor() { }

	// RVA: 0xD77248
	public bool Equals(System.Nullable<System.Threading.LockRecursionPolicy> left, System.Nullable<System.Threading.LockRecursionPolicy> right) { }

	// RVA: 0xD773C4
	public int GetHashCode(System.Nullable<System.Threading.LockRecursionPolicy> obj) { }

}

// Namespace: 
private sealed class System_Threading_NativeOverlappedEqualityComparer
{
	// Methods

	// RVA: 0xD77478
	public void .ctor() { }

	// RVA: 0xD77480
	public bool Equals(NativeOverlapped left, NativeOverlapped right) { }

	// RVA: 0xD77510
	public int GetHashCode(NativeOverlapped obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_NativeOverlappedEqualityComparer
{
	// Methods

	// RVA: 0xD77584
	public void .ctor() { }

	// RVA: 0xD7758C
	public bool Equals(System.Nullable<System.Threading.NativeOverlapped> left, System.Nullable<System.Threading.NativeOverlapped> right) { }

	// RVA: 0xD77728
	public int GetHashCode(System.Nullable<System.Threading.NativeOverlapped> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadPriorityEqualityComparer
{
	// Methods

	// RVA: 0xD777D8
	public void .ctor() { }

	// RVA: 0xD777E0
	public bool Equals(ThreadPriority left, ThreadPriority right) { }

	// RVA: 0xD77868
	public int GetHashCode(ThreadPriority obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadPriorityEqualityComparer
{
	// Methods

	// RVA: 0xD77890
	public void .ctor() { }

	// RVA: 0xD77898
	public bool Equals(System.Nullable<System.Threading.ThreadPriority> left, System.Nullable<System.Threading.ThreadPriority> right) { }

	// RVA: 0xD77A14
	public int GetHashCode(System.Nullable<System.Threading.ThreadPriority> obj) { }

}

// Namespace: 
private sealed class System_Threading_ThreadStateEqualityComparer
{
	// Methods

	// RVA: 0xD77AC8
	public void .ctor() { }

	// RVA: 0xD77AD0
	public bool Equals(ThreadState left, ThreadState right) { }

	// RVA: 0xD77B58
	public int GetHashCode(ThreadState obj) { }

}

// Namespace: 
private sealed class NullableSystem_Threading_ThreadStateEqualityComparer
{
	// Methods

	// RVA: 0xD77B80
	public void .ctor() { }

	// RVA: 0xD77B88
	public bool Equals(System.Nullable<System.Threading.ThreadState> left, System.Nullable<System.Threading.ThreadState> right) { }

	// RVA: 0xD77D04
	public int GetHashCode(System.Nullable<System.Threading.ThreadState> obj) { }

}

// Namespace: MsgPack.Serialization
internal static class AotHelper
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> EqualityComparerTable; // 0x0

	// Methods

	// RVA: 0xD3DC54
	public static void HandleAotError(Type mayBeGenericArgument, Exception mayBeAotError) { }

	// RVA: 0xD4B33C
	public static object CreateSystemCollectionsGenericDictionary(ConstructorInfo constructor, Type keyType, int initialCapacity) { }

	// RVA: 0xD4AF48
	public static object GetEqualityComparer(Type type) { }

	// RVA: 0x30D9218
	public static void PrepareEqualityComparer() { }

	// RVA: 0xD4B4C8
	private static System.Collections.Generic.Dictionary<System.RuntimeTypeHandle,System.Object> InitializeEqualityComparerTable() { }

	// RVA: 0xD56640
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization
internal sealed class EnumTypedMessagePackSerializerWrapper<T0>
{
	// Fields
	private readonly ICustomizableEnumSerializer _underlyingEnumSerializer; // 0x0

	// Methods

	// RVA: 0x30D4F34
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

	// RVA: 0xD77DB8
	protected Type get_TargetType() { }

	// RVA: 0xD77DC0
	protected void .ctor(SerializationContext ownerContext, Type targetType, SerializerCapabilities capabilities) { }

	// RVA: 0xD77E64
	private void .ctor(SerializationContext ownerContext, Type targetType, System.Nullable<MsgPack.PackerCompatibilityOptions> packerCompatibilityOptions, SerializerCapabilities capabilities) { }

	// RVA: 0xD77F14
	private static bool JudgeNullable(Type type) { }

	// RVA: 0xD780E4
	internal override void InternalPackTo(Packer packer, object objectTree) { }

	// RVA: -1
	protected internal abstract void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD78168
	internal override object InternalUnpackFrom(Unpacker unpacker) { }

	// RVA: -1
	protected internal abstract object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD782AC
	internal override void InternalUnpackTo(Unpacker unpacker, object collection) { }

	// RVA: 0xD783C8
	protected internal virtual void UnpackToCore(Unpacker unpacker, object collection) { }

}

// Namespace: MsgPack.Serialization
internal class TypedMessagePackSerializerWrapper<T0>
{
	// Fields
	private readonly MessagePackSerializer _underlyingSerializer; // 0x0
	private readonly ICollectionInstanceFactory _underlyingFactory; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(SerializationContext context, MessagePackSerializer underlying) { }

	// RVA: 0x318DB98
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x318DB98
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x318DB98
	protected internal override T UnpackNil() { }

	// RVA: 0x318DB98
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

	// RVA: 0xD786A4
	public void .ctor() { }

	// RVA: 0xD7894C
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

	// RVA: 0xD78400
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD786AC
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD787D0
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD78908
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD78C1C
	public void .ctor() { }

	// RVA: 0xD78EC4
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

	// RVA: 0xD78980
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD78C24
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD78D48
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD78E80
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD79220
	public void .ctor() { }

	// RVA: 0xD79574
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xD795A8
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

	// RVA: 0xD78EF8
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD79228
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD7934C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD79508
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xD7954C
	protected override void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionEnumMessagePackSerializer
{
	// Methods

	// RVA: 0xD795DC
	public void .ctor(SerializationContext context, Type targetType) { }

	// RVA: 0xD79630
	protected internal override void PackUnderlyingValueTo(Packer packer, object enumValue) { }

	// RVA: 0xD797C4
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

	// RVA: 0xD79FE8
	private static void .cctor() { }

	// RVA: 0xD7A054
	public void .ctor() { }

	// RVA: 0xD7A05C
	internal bool <OnPackingMessagePackObject>b__2_0(object value) { }

	// RVA: 0xD7A0F8
	internal bool <OnPackingReferenceTypeObject>b__3_0(object value) { }

	// RVA: 0xD7A104
	internal bool <OnPackingNullableValueTypeObject>b__4_0(object value) { }

	// RVA: 0xD7A110
	internal void <OnNopOnUnpacked>b__6_0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public System.Func<System.Object,System.Boolean> condition; // 0x10
	public ReflectionSerializerNilImplicationHandlerParameter parameter; // 0x18

	// Methods

	// RVA: 0xD7A114
	public void .ctor() { }

	// RVA: 0xD7A11C
	internal void <OnPackingCore>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xD7A17C
	public void .ctor() { }

	// RVA: 0xD7A184
	internal void <OnThrowNullIsProhibitedExceptionOnUnpacked>b__0(object _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter; // 0x10

	// Methods

	// RVA: 0xD7A1A8
	public void .ctor() { }

	// RVA: 0xD7A1B0
	internal void <OnThrowValueTypeCannotBeNull3OnUnpacked>b__0(object _) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal class ReflectionNilImplicationHandler
{
	// Fields
	public static readonly ReflectionNilImplicationHandler Instance; // 0x0

	// Methods

	// RVA: 0xD79878
	private void .ctor() { }

	// RVA: 0xD798CC
	protected override System.Func<System.Object,System.Boolean> OnPackingMessagePackObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD799D4
	protected override System.Func<System.Object,System.Boolean> OnPackingReferenceTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD79ADC
	protected override System.Func<System.Object,System.Boolean> OnPackingNullableValueTypeObject(ReflectionSerializerNilImplicationHandlerParameter parameter) { }

	// RVA: 0xD79BE4
	protected override System.Action<System.Object> OnPackingCore(ReflectionSerializerNilImplicationHandlerParameter parameter, System.Func<System.Object,System.Boolean> condition) { }

	// RVA: 0xD79CC0
	protected override System.Action<System.Object> OnNopOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD79DC8
	protected override System.Action<System.Object> OnThrowNullIsProhibitedExceptionOnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD79E88
	protected override System.Action<System.Object> OnThrowValueTypeCannotBeNull3OnUnpacked(ReflectionSerializerNilImplicationHandlerOnUnpackedParameter parameter) { }

	// RVA: 0xD79F48
	private static void .cctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD7A4F8
	public void .ctor() { }

	// RVA: 0xD7B510
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xD7B544
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

	// RVA: 0xD7A1D8
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD7AC04
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD7B0B8
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7B4A4
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xD7B4E8
	protected override void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD7B898
	public void .ctor() { }

	// RVA: 0xD7BFC8
	internal object <.ctor>b__0(int _) { }

	// RVA: 0xD7BFFC
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

	// RVA: 0xD7B578
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD7B8A4
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD7BDA4
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7BF5C
	protected override object CreateInstance(int initialCapacity) { }

	// RVA: 0xD7BFA0
	protected override void AddItem(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD7C2D4
	public void .ctor() { }

	// RVA: 0xD7CB94
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

	// RVA: 0xD7C030
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD7C468
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD7C990
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7CB50
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass3_0
{
	// Fields
	public Type concreteType; // 0x10

	// Methods

	// RVA: 0xD7CE6C
	public void .ctor() { }

	// RVA: 0xD7D19C
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

	// RVA: 0xD7CBC8
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits concreteTypeCollectionTraits, PolymorphismSchema itemsSchema, SerializationTarget targetInfo) { }

	// RVA: 0xD7CE78
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD7CF98
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD7D158
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_0
{
	// Fields
	public SerializationContext context; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal string <.ctor>b__2(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

}

// Namespace: 
private sealed class <>c__DisplayClass8_1
{
	// Fields
	public SerializingMember member; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D3858
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal System.Collections.Generic.KeyValuePair<System.String,System.Int32> <.ctor>b__8_0(DataMemberContract contract, int index) { }

	// RVA: 0x318DB98
	internal bool <.ctor>b__8_1(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x318DB98
	internal int <.ctor>b__8_3(System.Collections.Generic.KeyValuePair<System.String,System.Int32> kv) { }

	// RVA: 0x30D3DA0
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

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
	internal void <UnpackMemberValue>b__0(object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass13_1
{
	// Fields
	public int argumentIndex; // 0x0
	public MsgPack.Serialization.ReflectionSerializers.ReflectionObjectMessagePackSerializer.<>c__DisplayClass13_0<T> CS$<>8__locals1; // 0x0

	// Methods

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x30D4CD4
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

	// RVA: 0x30D4FA0
	public void .ctor(SerializationContext context, SerializationTarget target, SerializerCapabilities capabilities) { }

	// RVA: 0x318DB98
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x318DB98
	private bool IsNull(T objectTree, int index) { }

	// RVA: 0x318DB98
	private void PackMemberValue(Packer packer, T objectTree, int index) { }

	// RVA: 0x318DB98
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x318DB98
	private object UnpackMemberValue(object objectGraph, Unpacker unpacker, int itemsCount, int unpacked, int index, int unpackerOffset) { }

	// RVA: 0x30D3E0C
	private object UnpackSingleValue(Unpacker unpacker, int index) { }

	// RVA: 0x30D4FA0
	private void UnpackAndAddCollectionItem(object objectGraph, Unpacker unpacker, int index) { }

}

// Namespace: 
private sealed class <>c__DisplayClass4_0
{
	// Fields
	public CollectionTraits collectionTraits; // 0x10

	// Methods

	// RVA: 0xD7D1D0
	public void .ctor() { }

	// RVA: 0xD7E748
	internal void <GetAddItem>b__0(object collection, object item) { }

}

// Namespace: 
private sealed class <>c__DisplayClass5_0
{
	// Fields
	public MethodInfo getter; // 0x10
	public MethodInfo setter; // 0x18

	// Methods

	// RVA: 0xD7E4B4
	public void .ctor() { }

	// RVA: 0xD7E834
	internal object <GetMetadata>b__0(object target) { }

	// RVA: 0xD7E8A8
	internal void <GetMetadata>b__1(object target, object value) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public ConstructorInfo constructor; // 0x10

	// Methods

	// RVA: 0xD7E5F8
	public void .ctor() { }

	// RVA: 0xD7E994
	internal object <CreateCollectionInstanceFactory>b__0(int _) { }

	// RVA: 0xD7EA24
	internal object <CreateCollectionInstanceFactory>b__1(int capacity) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xD7E600
	public void .ctor() { }

	// RVA: 0xD7EB3C
	internal object <CreateCollectionInstanceFactory>b__2(int _) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2
{
	// Fields
	public object comparer; // 0x10
	public MsgPack.Serialization.ReflectionSerializers.ReflectionSerializerHelper.<>c__DisplayClass7_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xD7E608
	public void .ctor() { }

	// RVA: 0xD7EC20
	internal object <CreateCollectionInstanceFactory>b__3(int capacity) { }

	// RVA: 0xD7ED78
	internal object <CreateCollectionInstanceFactory>b__4(int capacity) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal static class ReflectionSerializerHelper
{
	// Fields
	internal static readonly PropertyInfo DictionaryEntryKeyProperty; // 0x0
	internal static readonly PropertyInfo DictionaryEntryValueProperty; // 0x8

	// Methods

	// RVA: 0x30D77E4
	public static MsgPack.Serialization.MessagePackSerializer<T> CreateReflectionEnumMessagePackSerializer(SerializationContext context) { }

	// RVA: 0x318DB98
	public static MessagePackSerializer CreateCollectionSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD7AA0C
	public static System.Action<System.Object,System.Object> GetAddItem(Type targetType, CollectionTraits collectionTraits) { }

	// RVA: 0xD7D700
	public static void GetMetadata(Type targetType, System.Collections.Generic.IList<MsgPack.Serialization.SerializingMember> members, SerializationContext context, System.Func<System.Object,System.Object>[]& getters, System.Action<System.Object,System.Object>[]& setters, MemberInfo[] memberInfos, DataMemberContract[] contracts, MessagePackSerializer[] serializers) { }

	// RVA: 0xD7E4BC
	private static void ThrowMissingGetterException(Type targetType, int number, PropertyInfo property) { }

	// RVA: 0xD7A504
	public static System.Func<System.Int32,System.Object> CreateCollectionInstanceFactory(Type abstractType, Type targetType, Type comparisonType, ConstructorInfo constructor) { }

	// RVA: 0xD7E610
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

	// RVA: 0xD7EED0
	public Type get_ItemType() { }

	// RVA: 0xD7EED8
	public System.Action<System.Object> get_Store() { }

	// RVA: 0xD7EEE0
	public void .ctor(Type itemType, System.Action<System.Object> store, string memberName, Type declaringType) { }

}

// Namespace: MsgPack.Serialization.ReflectionSerializers
internal sealed class ReflectionSerializerNilImplicationHandlerParameter
{
	// Fields
	private readonly Type _itemType; // 0x10
	private readonly string _memberName; // 0x18

	// Methods

	// RVA: 0xD7EF60
	public Type get_ItemType() { }

	// RVA: 0xD7EF68
	public string get_MemberName() { }

	// RVA: 0xD7EF70
	public void .ctor(Type itemType, string memberName) { }

}

// Namespace: 
private sealed class <>c__DisplayClass1_0
{
	// Fields
	public Type genericType; // 0x10
	public Type source; // 0x18

	// Methods

	// RVA: 0xD7F264
	public void .ctor() { }

	// RVA: 0xD7F26C
	internal bool <EnumerateGenericIntefaces>b__0(Type interface) { }

	// RVA: 0xD7F380
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

	// RVA: 0xD7F440
	private static void .cctor() { }

	// RVA: 0xD7F4AC
	public void .ctor() { }

	// RVA: 0xD7F4B4
	internal string <GetFullName>b__3_0(Type t) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class GenericTypeExtensions
{
	// Methods

	// RVA: 0xD7EFC0
	public static bool Implements(Type source, Type genericType) { }

	// RVA: 0xD7F024
	private static System.Collections.Generic.IEnumerable<System.Type> EnumerateGenericIntefaces(Type source, Type genericType, bool includesOwn) { }

	// RVA: 0xD7D1D8
	public static string GetFullName(Type source) { }

}

// Namespace: MsgPack.Serialization.Reflection
internal static class ReflectionExtensions
{
	// Methods

	// RVA: 0xD7F4BC
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

	// RVA: 0x30D9218
	private static void .cctor() { }

	// RVA: 0x30D488C
	public void .ctor() { }

	// RVA: 0x318DB98
	internal string <BuildTypeCodeTypeHandleMap>b__4_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x318DB98
	internal RuntimeTypeHandle <BuildTypeCodeTypeHandleMap>b__4_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x318DB98
	internal Type <BuildTypeHandleTypeCodeMap>b__5_0(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x318DB98
	internal string <BuildTypeHandleTypeCodeMap>b__5_1(System.Collections.Generic.KeyValuePair<System.String,System.Type> kv) { }

	// RVA: 0x30D3DA0
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

	// RVA: 0x30D4F34
	public void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x30D77E4
	private static System.Collections.Generic.IDictionary<System.String,System.RuntimeTypeHandle> BuildTypeCodeTypeHandleMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x30D77E4
	private static System.Collections.Generic.IDictionary<System.RuntimeTypeHandle,System.String> BuildTypeHandleTypeCodeMap(System.Collections.Generic.IDictionary<System.String,System.Type> typeMap) { }

	// RVA: 0x30D3DA0
	private MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x318DB98
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x318DB98
	private string GetTypeCode(T objectTree) { }

	// RVA: 0x318DB98
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30D3DA0
	private Type GetTypeFromCode(string typeCode) { }

	// RVA: 0x30D3DA0
	private object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x318DB98
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x30D3DA0
	private Type <UnpackFromCore>b__9_0(string c) { }

	// RVA: 0x318DB98
	private T <UnpackFromCore>b__9_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class PolymorphicSerializerProvider<T0>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<T> _defaultSerializer; // 0x0
	private readonly PolymorphismSchema _defaultSchema; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(SerializationContext context, MessagePackSerializer defaultSerializer) { }

	// RVA: 0x30D3E84
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

	// RVA: 0x30D4A04
	public void .ctor(int capacity) { }

	// RVA: 0x318DB98
	public void Enqueue(T item) { }

	// RVA: 0x318DB98
	public T Dequeue() { }

	// RVA: 0x30D4A04
	private void SetCapacity(int capacity) { }

	// RVA: 0x30D4CD4
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

	// RVA: 0xD7F4E4
	public static void Verify(AssemblyName assemblyName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD7F658
	private static bool VerifyCore(AssemblyName assemblyName, string assemblyFullName, string typeFullName, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD7FB30
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal sealed class TypeEmbedingPolymorphicMessagePackSerializer<T0>
{
	// Fields
	private readonly PolymorphismSchema _schema; // 0x0

	// Methods

	// RVA: 0x30D4F34
	public void .ctor(SerializationContext ownerContext, PolymorphismSchema schema) { }

	// RVA: 0x30D3DA0
	private MessagePackSerializer GetActualTypeSerializer(Type actualType) { }

	// RVA: 0x318DB98
	protected internal override void PackToCore(Packer packer, T objectTree) { }

	// RVA: 0x318DB98
	protected internal override T UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30D3DA0
	private object MsgPack.Serialization.Polymorphic.IPolymorphicDeserializer.PolymorphicUnpackFrom(Unpacker unpacker) { }

	// RVA: 0x318DB98
	protected internal override void UnpackToCore(Unpacker unpacker, T collection) { }

	// RVA: 0x30D3DA0
	private Type <UnpackFromCore>b__4_0(Unpacker u) { }

	// RVA: 0x318DB98
	private T <UnpackFromCore>b__4_1(Type t, Unpacker u) { }

}

// Namespace: MsgPack.Serialization.Polymorphic
internal static class TypeInfoEncoder
{
	// Methods

	// RVA: 0xD7FC74
	public static void Encode(Packer packer, string typeCode) { }

	// RVA: 0xD7FCB4
	public static void Encode(Packer packer, Type type) { }

	// RVA: 0x318DB98
	public static T Decode(Unpacker unpacker, System.Func<System.String,System.Type> typeFinder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0x318DB98
	public static T Decode(Unpacker unpacker, System.Func<MsgPack.Unpacker,System.Type> typeDecoder, System.Func<System.Type,MsgPack.Unpacker,T> unpacking) { }

	// RVA: 0xD7FFC0
	public static Type DecodeRuntimeTypeInfo(Unpacker unpacker, System.Func<MsgPack.Serialization.PolymorphicTypeVerificationContext,System.Boolean> typeVerifier) { }

	// RVA: 0xD805D0
	private static void ThrowFailedToDecodeEncodingType() { }

	// RVA: 0xD80624
	private static void ThrowUnknownEncodingType(Byte encodeType) { }

	// RVA: 0xD8070C
	private static void ThrowFailedToDecodeCompressedTypeName() { }

	// RVA: 0xD80760
	private static void ThrowFailedToDecodeAssemblySimpleName() { }

	// RVA: 0xD807B4
	private static void ThrowFailedToDecodeAssemblyVersion() { }

	// RVA: 0xD80808
	private static void ThrowFailedToDecodeAssemblyCulture() { }

	// RVA: 0xD8085C
	private static void ThrowFailedToDecodeAssemblyKeyToken() { }

	// RVA: 0xD804F0
	private static void CheckUnpackerForRuntimeTypeInfoDecoding(Unpacker unpacker) { }

	// RVA: 0xD80B14
	private static void ThrowEncodedTypeIsNotInNonNillArray() { }

	// RVA: 0xD80B68
	private static void ThrowEncodedTypeDoesNotHaveValidArrayItems() { }

	// RVA: 0xD808B0
	private static AssemblyName BuildAssemblyName(string assemblySimpleName, Byte[] version, string culture, Byte[] publicKeyToken) { }

	// RVA: 0xD80A44
	private static string DecompressTypeName(string assemblySimpleName, string compressedTypeName) { }

	// RVA: 0xD80AD4
	private static Type LoadDecodedType(AssemblyName assemblyName, string typeFullName) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractCollectionMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x50
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x58

	// Methods

	// RVA: 0xD80BBC
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD80EB0
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD81090
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class AbstractCollectionSerializerHelper
{
	// Methods

	// RVA: 0xD80D58
	public static void GetConcreteSerializer(SerializationContext context, PolymorphismSchema schema, Type abstractType, Type targetType, Type exampleType, ICollectionInstanceFactory factory, MessagePackSerializer serializer) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractDictionaryMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x68
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x70

	// Methods

	// RVA: 0xD81144
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD8145C
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD8163C
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractEnumerableMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly MessagePackSerializer _concreteSerializer; // 0x50

	// Methods

	// RVA: 0xD816F0
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD8181C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD818FC
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericCollectionMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xD819B0
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD81A84
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD81B64
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericDictionaryMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x48
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x50

	// Methods

	// RVA: 0xD81C18
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD81D3C
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD81ECC
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericEnumerableMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly MessagePackSerializer _concreteSerializer; // 0x48

	// Methods

	// RVA: 0xD81F80
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD82054
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD82134
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class AbstractNonGenericListMessagePackSerializer
{
	// Fields
	private readonly ICollectionInstanceFactory _concreteCollectionInstanceFactory; // 0x40
	private readonly IPolymorphicDeserializer _polymorphicDeserializer; // 0x48

	// Methods

	// RVA: 0xD821E8
	public void .ctor(SerializationContext ownerContext, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD8230C
	internal override object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD824EC
	protected override object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySegmentMessageSerializer
{
	// Methods

	// RVA: 0xD825A0
	public static void PackByteArraySegmentTo(Packer packer, System.ArraySegment<System.Byte> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xD826E4
	public static void PackCharArraySegmentTo(Packer packer, System.ArraySegment<System.Char> objectTree, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x318DB98
	public static void PackGenericArraySegmentTo(Packer packer, System.ArraySegment<T> objectTree, MsgPack.Serialization.MessagePackSerializer<T> itemSerializer) { }

	// RVA: 0xD82858
	public static System.ArraySegment<System.Byte> UnpackByteArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Byte> itemSerializer) { }

	// RVA: 0xD82910
	public static System.ArraySegment<System.Char> UnpackCharArraySegmentFrom(Unpacker unpacker, MsgPack.Serialization.MessagePackSerializer<System.Char> itemSerializer) { }

	// RVA: 0x318DB98
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

	// RVA: 0xD84630
	private static void .cctor() { }

	// RVA: 0xD8469C
	public void .ctor() { }

	// RVA: 0xD846A4
	internal object <InitializeArraySerializerFactories>b__4_0(SerializationContext context) { }

	// RVA: 0xD847E4
	internal object <InitializeArraySerializerFactories>b__4_1(SerializationContext context) { }

	// RVA: 0xD84924
	internal object <InitializeArraySerializerFactories>b__4_2(SerializationContext context) { }

	// RVA: 0xD84A64
	internal object <InitializeArraySerializerFactories>b__4_3(SerializationContext context) { }

	// RVA: 0xD84BA4
	internal object <InitializeArraySerializerFactories>b__4_4(SerializationContext context) { }

	// RVA: 0xD84CE4
	internal object <InitializeArraySerializerFactories>b__4_5(SerializationContext context) { }

	// RVA: 0xD84E24
	internal object <InitializeArraySerializerFactories>b__4_6(SerializationContext context) { }

	// RVA: 0xD84F64
	internal object <InitializeArraySerializerFactories>b__4_7(SerializationContext context) { }

	// RVA: 0xD850A4
	internal object <InitializeArraySerializerFactories>b__4_8(SerializationContext context) { }

	// RVA: 0xD851E4
	internal object <InitializeArraySerializerFactories>b__4_9(SerializationContext context) { }

	// RVA: 0xD85324
	internal object <InitializeArraySerializerFactories>b__4_10(SerializationContext context) { }

	// RVA: 0xD85464
	internal object <InitializeArraySerializerFactories>b__4_11(SerializationContext context) { }

	// RVA: 0xD855A4
	internal object <InitializeArraySerializerFactories>b__4_12(SerializationContext context) { }

	// RVA: 0xD856E4
	internal object <InitializeArraySerializerFactories>b__4_13(SerializationContext context) { }

	// RVA: 0xD85824
	internal object <InitializeArraySerializerFactories>b__4_14(SerializationContext context) { }

	// RVA: 0xD85964
	internal object <InitializeArraySerializerFactories>b__4_15(SerializationContext context) { }

	// RVA: 0xD85AA4
	internal object <InitializeArraySerializerFactories>b__4_16(SerializationContext context) { }

	// RVA: 0xD85BE4
	internal object <InitializeArraySerializerFactories>b__4_17(SerializationContext context) { }

	// RVA: 0xD85D24
	internal object <InitializeArraySerializerFactories>b__4_18(SerializationContext context) { }

	// RVA: 0xD85E64
	internal object <InitializeArraySerializerFactories>b__4_19(SerializationContext context) { }

	// RVA: 0xD85FA4
	internal object <InitializeArraySerializerFactories>b__4_20(SerializationContext context) { }

	// RVA: 0xD860E4
	internal object <InitializeArraySerializerFactories>b__4_21(SerializationContext context) { }

	// RVA: 0xD86224
	internal object <InitializeArraySerializerFactories>b__4_22(SerializationContext context) { }

	// RVA: 0xD86364
	internal object <InitializeArraySerializerFactories>b__4_23(SerializationContext context) { }

	// RVA: 0xD864A4
	internal object <InitializeArraySerializerFactories>b__4_24(SerializationContext context) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class ArraySerializer
{
	// Fields
	private static readonly System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> _arraySerializerFactories; // 0x0

	// Methods

	// RVA: 0x30D78C4
	public static MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD829C8
	public static MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD82BA8
	private static object GetPrimitiveArraySerializer(SerializationContext context, Type targetType) { }

	// RVA: 0xD82E64
	private static System.Collections.Generic.Dictionary<System.Type,System.Func<MsgPack.Serialization.SerializationContext,System.Object>> InitializeArraySerializerFactories() { }

	// RVA: 0xD845D4
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SByteArraySerializer
{
	// Methods

	// RVA: 0xD84760
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD865E4
	protected internal override void PackToCore(Packer packer, SByte[] objectTree) { }

	// RVA: 0xD8665C
	protected internal override SByte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD86800
	protected internal override void UnpackToCore(Unpacker unpacker, SByte[] collection) { }

	// RVA: 0xD86728
	private static void UnpackToCore(Unpacker unpacker, SByte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int16ArraySerializer
{
	// Methods

	// RVA: 0xD849E0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD868A0
	protected internal override void PackToCore(Packer packer, Int16[] objectTree) { }

	// RVA: 0xD86918
	protected internal override Int16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD86ABC
	protected internal override void UnpackToCore(Unpacker unpacker, Int16[] collection) { }

	// RVA: 0xD869E4
	private static void UnpackToCore(Unpacker unpacker, Int16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int32ArraySerializer
{
	// Methods

	// RVA: 0xD84C60
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD86B5C
	protected internal override void PackToCore(Packer packer, int[] objectTree) { }

	// RVA: 0xD86BD4
	protected internal override int[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD86D78
	protected internal override void UnpackToCore(Unpacker unpacker, int[] collection) { }

	// RVA: 0xD86CA0
	private static void UnpackToCore(Unpacker unpacker, int[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class Int64ArraySerializer
{
	// Methods

	// RVA: 0xD84EE0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD86E18
	protected internal override void PackToCore(Packer packer, Int64[] objectTree) { }

	// RVA: 0xD86E90
	protected internal override Int64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD87034
	protected internal override void UnpackToCore(Unpacker unpacker, Int64[] collection) { }

	// RVA: 0xD86F5C
	private static void UnpackToCore(Unpacker unpacker, Int64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class ByteArraySerializer
{
	// Methods

	// RVA: 0xD85160
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD870D4
	protected internal override void PackToCore(Packer packer, Byte[] objectTree) { }

	// RVA: 0xD8714C
	protected internal override Byte[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD872F0
	protected internal override void UnpackToCore(Unpacker unpacker, Byte[] collection) { }

	// RVA: 0xD87218
	private static void UnpackToCore(Unpacker unpacker, Byte[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt16ArraySerializer
{
	// Methods

	// RVA: 0xD853E0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD87390
	protected internal override void PackToCore(Packer packer, UInt16[] objectTree) { }

	// RVA: 0xD87408
	protected internal override UInt16[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD875AC
	protected internal override void UnpackToCore(Unpacker unpacker, UInt16[] collection) { }

	// RVA: 0xD874D4
	private static void UnpackToCore(Unpacker unpacker, UInt16[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt32ArraySerializer
{
	// Methods

	// RVA: 0xD85660
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8764C
	protected internal override void PackToCore(Packer packer, UInt32[] objectTree) { }

	// RVA: 0xD876C4
	protected internal override UInt32[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD87868
	protected internal override void UnpackToCore(Unpacker unpacker, UInt32[] collection) { }

	// RVA: 0xD87790
	private static void UnpackToCore(Unpacker unpacker, UInt32[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UInt64ArraySerializer
{
	// Methods

	// RVA: 0xD858E0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD87908
	protected internal override void PackToCore(Packer packer, UInt64[] objectTree) { }

	// RVA: 0xD87980
	protected internal override UInt64[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD87B24
	protected internal override void UnpackToCore(Unpacker unpacker, UInt64[] collection) { }

	// RVA: 0xD87A4C
	private static void UnpackToCore(Unpacker unpacker, UInt64[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class SingleArraySerializer
{
	// Methods

	// RVA: 0xD85B60
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD87BC4
	protected internal override void PackToCore(Packer packer, float[] objectTree) { }

	// RVA: 0xD87C3C
	protected internal override float[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD87DE0
	protected internal override void UnpackToCore(Unpacker unpacker, float[] collection) { }

	// RVA: 0xD87D08
	private static void UnpackToCore(Unpacker unpacker, float[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class DoubleArraySerializer
{
	// Methods

	// RVA: 0xD85DE0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD87E80
	protected internal override void PackToCore(Packer packer, Double[] objectTree) { }

	// RVA: 0xD87EF8
	protected internal override Double[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD8809C
	protected internal override void UnpackToCore(Unpacker unpacker, Double[] collection) { }

	// RVA: 0xD87FC4
	private static void UnpackToCore(Unpacker unpacker, Double[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BooleanArraySerializer
{
	// Methods

	// RVA: 0xD86060
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8813C
	protected internal override void PackToCore(Packer packer, bool[] objectTree) { }

	// RVA: 0xD881B4
	protected internal override bool[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD88358
	protected internal override void UnpackToCore(Unpacker unpacker, bool[] collection) { }

	// RVA: 0xD88280
	private static void UnpackToCore(Unpacker unpacker, bool[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSByteArraySerializer
{
	// Methods

	// RVA: 0xD848A0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD883F8
	protected internal override void PackToCore(Packer packer, System.Nullable<System.SByte>[] objectTree) { }

	// RVA: 0xD88484
	protected internal override System.Nullable<System.SByte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD88628
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection) { }

	// RVA: 0xD88550
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.SByte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt16ArraySerializer
{
	// Methods

	// RVA: 0xD84B20
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD886C8
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int16>[] objectTree) { }

	// RVA: 0xD88754
	protected internal override System.Nullable<System.Int16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD888F8
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection) { }

	// RVA: 0xD88820
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt32ArraySerializer
{
	// Methods

	// RVA: 0xD84DA0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD88998
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int32>[] objectTree) { }

	// RVA: 0xD88A10
	protected internal override System.Nullable<System.Int32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD88BB4
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection) { }

	// RVA: 0xD88ADC
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableInt64ArraySerializer
{
	// Methods

	// RVA: 0xD85020
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD88C54
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Int64>[] objectTree) { }

	// RVA: 0xD88CD0
	protected internal override System.Nullable<System.Int64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD88E74
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection) { }

	// RVA: 0xD88D9C
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Int64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableByteArraySerializer
{
	// Methods

	// RVA: 0xD852A0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD88F14
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Byte>[] objectTree) { }

	// RVA: 0xD88FA0
	protected internal override System.Nullable<System.Byte>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD89144
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection) { }

	// RVA: 0xD8906C
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Byte>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt16ArraySerializer
{
	// Methods

	// RVA: 0xD85520
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD891E4
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt16>[] objectTree) { }

	// RVA: 0xD89270
	protected internal override System.Nullable<System.UInt16>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD89414
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection) { }

	// RVA: 0xD8933C
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt16>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt32ArraySerializer
{
	// Methods

	// RVA: 0xD857A0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD894B4
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt32>[] objectTree) { }

	// RVA: 0xD8952C
	protected internal override System.Nullable<System.UInt32>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD896D0
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection) { }

	// RVA: 0xD895F8
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt32>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableUInt64ArraySerializer
{
	// Methods

	// RVA: 0xD85A20
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD89770
	protected internal override void PackToCore(Packer packer, System.Nullable<System.UInt64>[] objectTree) { }

	// RVA: 0xD897EC
	protected internal override System.Nullable<System.UInt64>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD89990
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection) { }

	// RVA: 0xD898B8
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.UInt64>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableSingleArraySerializer
{
	// Methods

	// RVA: 0xD85CA0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD89A30
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Single>[] objectTree) { }

	// RVA: 0xD89AA8
	protected internal override System.Nullable<System.Single>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD89C4C
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection) { }

	// RVA: 0xD89B74
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Single>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableDoubleArraySerializer
{
	// Methods

	// RVA: 0xD85F20
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD89CEC
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Double>[] objectTree) { }

	// RVA: 0xD89D68
	protected internal override System.Nullable<System.Double>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD89F0C
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection) { }

	// RVA: 0xD89E34
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Double>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class NullableBooleanArraySerializer
{
	// Methods

	// RVA: 0xD861A0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD89FAC
	protected internal override void PackToCore(Packer packer, System.Nullable<System.Boolean>[] objectTree) { }

	// RVA: 0xD8A038
	protected internal override System.Nullable<System.Boolean>[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD8A1DC
	protected internal override void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection) { }

	// RVA: 0xD8A104
	private static void UnpackToCore(Unpacker unpacker, System.Nullable<System.Boolean>[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class StringArraySerializer
{
	// Methods

	// RVA: 0xD862E0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8A27C
	protected internal override void PackToCore(Packer packer, string[] objectTree) { }

	// RVA: 0xD8A2F4
	protected internal override string[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD8A4A8
	protected internal override void UnpackToCore(Unpacker unpacker, string[] collection) { }

	// RVA: 0xD8A3C0
	private static void UnpackToCore(Unpacker unpacker, string[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class BinaryArraySerializer
{
	// Methods

	// RVA: 0xD86420
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8A548
	protected internal override void PackToCore(Packer packer, Byte[][] objectTree) { }

	// RVA: 0xD8A5C0
	protected internal override Byte[][] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD8A774
	protected internal override void UnpackToCore(Unpacker unpacker, Byte[][] collection) { }

	// RVA: 0xD8A68C
	private static void UnpackToCore(Unpacker unpacker, Byte[][] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MessagePackObjectArraySerializer
{
	// Methods

	// RVA: 0xD86560
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8A814
	protected internal override void PackToCore(Packer packer, MessagePackObject[] objectTree) { }

	// RVA: 0xD8A8E8
	protected internal override MessagePackObject[] UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD8AAA0
	protected internal override void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection) { }

	// RVA: 0xD8A9B4
	private static void UnpackToCore(Unpacker unpacker, MessagePackObject[] collection, int count) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class UnityArraySerializer
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38
	private readonly Type _itemType; // 0x40

	// Methods

	// RVA: 0xD82CAC
	public void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD8AB40
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD8AEE4
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD8B240
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD8AFA8
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

	// RVA: 0xD8B314
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD8B938
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class DateTimeOffsetMessagePackSerializer
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xD8BB6C
	public void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xD8BC04
	protected internal override void PackToCore(Packer packer, DateTimeOffset objectTree) { }

	// RVA: 0xD8BE50
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

	// RVA: 0xD8C560
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD8C9D8
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_BooleanMessagePackSerializer
{
	// Methods

	// RVA: 0xD8CC0C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8CC90
	protected internal override void PackToCore(Packer packer, bool value) { }

	// RVA: 0xD8CCB0
	protected internal override bool UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteMessagePackSerializer
{
	// Methods

	// RVA: 0xD8CEE8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8CF6C
	protected internal override void PackToCore(Packer packer, Byte value) { }

	// RVA: 0xD8CF8C
	protected internal override Byte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharMessagePackSerializer
{
	// Methods

	// RVA: 0xD8D1C4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8D248
	protected internal override void PackToCore(Packer packer, Char value) { }

	// RVA: 0xD8D268
	protected internal override Char UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DecimalMessagePackSerializer
{
	// Methods

	// RVA: 0xD8D46C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8D4F0
	protected internal override void PackToCore(Packer packer, Decimal value) { }

	// RVA: 0xD8D5F4
	protected internal override Decimal UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_DoubleMessagePackSerializer
{
	// Methods

	// RVA: 0xD8D868
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8D8EC
	protected internal override void PackToCore(Packer packer, Double value) { }

	// RVA: 0xD8D908
	protected internal override Double UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_GuidMessagePackSerializer
{
	// Methods

	// RVA: 0xD8DB40
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8DBC4
	protected internal override void PackToCore(Packer packer, Guid value) { }

	// RVA: 0xD8DC10
	protected internal override Guid UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int16MessagePackSerializer
{
	// Methods

	// RVA: 0xD8DE30
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8DEB4
	protected internal override void PackToCore(Packer packer, Int16 value) { }

	// RVA: 0xD8DED4
	protected internal override Int16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int32MessagePackSerializer
{
	// Methods

	// RVA: 0xD8E10C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8E190
	protected internal override void PackToCore(Packer packer, int value) { }

	// RVA: 0xD8E1B0
	protected internal override int UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Int64MessagePackSerializer
{
	// Methods

	// RVA: 0xD8E3E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8E46C
	protected internal override void PackToCore(Packer packer, Int64 value) { }

	// RVA: 0xD8E48C
	protected internal override Int64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SByteMessagePackSerializer
{
	// Methods

	// RVA: 0xD8E6C4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8E748
	protected internal override void PackToCore(Packer packer, SByte value) { }

	// RVA: 0xD8E768
	protected internal override SByte UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_SingleMessagePackSerializer
{
	// Methods

	// RVA: 0xD8E9A0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8EA24
	protected internal override void PackToCore(Packer packer, float value) { }

	// RVA: 0xD8EA40
	protected internal override float UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_TimeSpanMessagePackSerializer
{
	// Methods

	// RVA: 0xD8EC78
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8ECFC
	protected internal override void PackToCore(Packer packer, TimeSpan value) { }

	// RVA: 0xD8ED80
	protected internal override TimeSpan UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt16MessagePackSerializer
{
	// Methods

	// RVA: 0xD8EFB8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8F03C
	protected internal override void PackToCore(Packer packer, UInt16 value) { }

	// RVA: 0xD8F05C
	protected internal override UInt16 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt32MessagePackSerializer
{
	// Methods

	// RVA: 0xD8F294
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8F318
	protected internal override void PackToCore(Packer packer, UInt32 value) { }

	// RVA: 0xD8F338
	protected internal override UInt32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UInt64MessagePackSerializer
{
	// Methods

	// RVA: 0xD8F570
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8F5F4
	protected internal override void PackToCore(Packer packer, UInt64 value) { }

	// RVA: 0xD8F614
	protected internal override UInt64 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_BitVector32MessagePackSerializer
{
	// Methods

	// RVA: 0xD8F84C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD8F8D0
	protected internal override void PackToCore(Packer packer, BitVector32 value) { }

	// RVA: 0xD8F8F0
	protected internal override BitVector32 UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class GenericSerializer
{
	// Methods

	// RVA: 0x30D78C4
	public static MsgPack.Serialization.MessagePackSerializer<T> Create(SerializationContext context, PolymorphismSchema schema) { }

	// RVA: 0xD8FB28
	public static MessagePackSerializer Create(SerializationContext context, Type targetType, PolymorphismSchema schema) { }

	// RVA: 0xD8FEDC
	private static MessagePackSerializer CreateArraySerializer(SerializationContext context, Type targetType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD8FF54
	private static MessagePackSerializer CreateNullableSerializer(SerializationContext context, Type nullableType, Type underlyingType) { }

	// RVA: 0xD8FFFC
	private static MessagePackSerializer CreateListSerializer(SerializationContext context, Type targetType, CollectionTraits traits, PolymorphismSchema schema) { }

	// RVA: 0xD90118
	private static MessagePackSerializer CreateDictionarySerializer(SerializationContext context, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema schema) { }

	// RVA: 0xD9062C
	public static MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema) { }

	// RVA: 0xD90724
	internal static MessagePackSerializer TryCreateAbstractCollectionSerializer(SerializationContext context, Type abstractType, Type concreteType, PolymorphismSchema schema, CollectionTraits traits) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal static class MessagePackObjectExtensions
{
	// Methods

	// RVA: 0xD8C3A4
	public static Int64 DeserializeAsInt64(MessagePackObject source) { }

	// RVA: 0xD909B8
	public static string DeserializeAsString(MessagePackObject source) { }

	// RVA: 0xD8C1E8
	public static MessagePackExtendedTypeObject DeserializeAsMessagePackExtendedTypeObject(MessagePackObject source) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackExtendedTypeObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD90B74
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD90BF8
	protected internal override void PackToCore(Packer packer, MessagePackExtendedTypeObject value) { }

	// RVA: 0xD90C1C
	protected internal override MessagePackExtendedTypeObject UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectDictionaryMessagePackSerializer
{
	// Methods

	// RVA: 0xD90E04
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD90E88
	protected internal override void PackToCore(Packer packer, MessagePackObjectDictionary objectTree) { }

	// RVA: 0xD91154
	protected internal override MessagePackObjectDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD91348
	protected internal override void UnpackToCore(Unpacker unpacker, MessagePackObjectDictionary collection) { }

	// RVA: 0xD91228
	private static void UnpackToCore(Unpacker unpacker, int count, MessagePackObjectDictionary collection) { }

	// RVA: 0xD913C0
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class MsgPack_MessagePackObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD91428
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD914AC
	protected internal override void PackToCore(Packer packer, MessagePackObject value) { }

	// RVA: 0xD91528
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

	// RVA: 0xD91B18
	public void .ctor() { }

	// RVA: 0xD92D14
	internal void <PackArrayCore>b__0(int[] indices) { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_0
{
	// Fields
	public Unpacker unpacker; // 0x10
	public UnityMultidimensionalArraySerializer <>4__this; // 0x18

	// Methods

	// RVA: 0xD929BC
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_1
{
	// Fields
	public Unpacker arrayUnpacker; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xD92D04
	public void .ctor() { }

}

// Namespace: 
private sealed class <>c__DisplayClass7_2
{
	// Fields
	public Array result; // 0x10
	public MsgPack.Serialization.DefaultSerializers.UnityMultidimensionalArraySerializer.<>c__DisplayClass7_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xD92D0C
	public void .ctor() { }

	// RVA: 0xD92D68
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

	// RVA: 0xD82D44
	public void .ctor(SerializationContext ownerContext, Type itemType, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD91594
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD9162C
	private void PackArrayCore(Packer packer, Array array) { }

	// RVA: 0xD91B20
	private static void GetArrayMetadata(Array array, int[] lengths, int[] lowerBounds) { }

	// RVA: 0xD91E8C
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD929C4
	private void ReadArrayMetadata(Unpacker metadataUnpacker, int[] lengths, int[] lowerBounds) { }

	// RVA: 0xD91C60
	private static void ForEach(Array array, int totalLength, int[] lowerBounds, int[] lengths, System.Action<System.Int32[]> action) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NativeDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xD8B830
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD92E08
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD92EB0
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class NullableMessagePackSerializer
{
	// Fields
	private readonly MessagePackSerializer _valueSerializer; // 0x38

	// Methods

	// RVA: 0xD90250
	public void .ctor(SerializationContext ownerContext, Type nullableType, Type underlyingType) { }

	// RVA: 0xD8B7F8
	public void .ctor(SerializationContext ownerContext, Type nullableType, MessagePackSerializer valueSerializer) { }

	// RVA: 0xD92F40
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD92F60
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

	// RVA: 0x30D77AC
	private static System.Action<MsgPack.Packer,System.ArraySegment<T>,MsgPack.Serialization.MessagePackSerializer<T>> InitializePacking() { }

	// RVA: 0x30D77AC
	private static System.Func<MsgPack.Unpacker,MsgPack.Serialization.MessagePackSerializer<T>,System.ArraySegment<T>> InitializeUnpacking() { }

	// RVA: 0x30D4CD4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x318DB98
	protected internal sealed override void PackToCore(Packer packer, System.ArraySegment<T> objectTree) { }

	// RVA: 0x318DB98
	protected internal sealed override System.ArraySegment<T> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30D9218
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ByteArrayMessagePackSerializer
{
	// Methods

	// RVA: 0xD92F80
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD93004
	protected internal override void PackToCore(Packer packer, Byte[] value) { }

	// RVA: 0xD93024
	protected internal override Byte[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_CharArrayMessagePackSerializer
{
	// Methods

	// RVA: 0xD930F8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD9317C
	protected internal override void PackToCore(Packer packer, Char[] value) { }

	// RVA: 0xD931B8
	protected internal override Char[] UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_DictionaryEntryMessagePackSerializer
{
	// Methods

	// RVA: 0xD9328C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD93310
	protected internal override void PackToCore(Packer packer, DictionaryEntry objectTree) { }

	// RVA: 0xD933D4
	private static MessagePackObject EnsureMessagePackObject(object obj) { }

	// RVA: 0xD934B4
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

	// RVA: 0xD9039C
	public void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, Type keyType, Type valueType, PolymorphismSchema keysSchema, PolymorphismSchema valuesSchema) { }

	// RVA: 0xD93708
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD93B38
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD941D0
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD93CB8
	private void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xD93C44
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_KeyValuePair_2MessagePackSerializer<T0, T1>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x318DB98
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.KeyValuePair<TKey,TValue> objectTree) { }

	// RVA: 0x318DB98
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

	// RVA: 0xD902AC
	public void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema itemsSchema) { }

	// RVA: 0xD94278
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD94630
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD94B40
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD94808
	private void UnpackToCore(Unpacker unpacker, object collection, int count) { }

	// RVA: 0xD946F0
	public object CreateInstance(int initialCapacity) { }

	// RVA: 0xD94BE8
	private static void .cctor() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_Collections_Generic_ListOfMessagePackObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD94D00
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD94D84
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.List<MsgPack.MessagePackObject> objectTree) { }

	// RVA: 0xD94FAC
	protected internal override System.Collections.Generic.List<MsgPack.MessagePackObject> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD95180
	protected internal override void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection) { }

	// RVA: 0xD95094
	private static void UnpackToCore(Unpacker unpacker, System.Collections.Generic.List<MsgPack.MessagePackObject> collection, int count) { }

	// RVA: 0xD95220
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Generic_Queue_1MessagePackSerializer<T0>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TItem> _itemSerializer; // 0x0

	// Methods

	// RVA: 0x30D4CD4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x30D4F34
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.Queue<TItem> objectTree) { }

	// RVA: 0x30D3DA0
	protected internal override System.Collections.Generic.Queue<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30D4F34
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

	// RVA: 0x30D4CD4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0x30D4F34
	protected internal override void PackToCore(Packer packer, System.Collections.Generic.Stack<TItem> objectTree) { }

	// RVA: 0x30D3DA0
	protected internal override System.Collections.Generic.Stack<TItem> UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x30D4F34
	protected internal override void UnpackToCore(Unpacker unpacker, System.Collections.Generic.Stack<TItem> collection) { }

	// RVA: 0x30D3E0C
	private System.Collections.Generic.IEnumerable<TItem> UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: -1
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_QueueMessagePackSerializer
{
	// Methods

	// RVA: 0xD9529C
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD95320
	protected internal override void PackToCore(Packer packer, Queue objectTree) { }

	// RVA: 0xD955BC
	protected internal override Queue UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD956A0
	protected internal override void UnpackToCore(Unpacker unpacker, Queue collection) { }

	// RVA: 0xD9581C
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_Specialized_NameValueCollectionMessagePackSerializer
{
	// Methods

	// RVA: 0xD95884
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD95908
	protected internal override void PackToCore(Packer packer, NameValueCollection objectTree) { }

	// RVA: 0xD95CE8
	protected internal override NameValueCollection UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD9610C
	protected internal override void UnpackToCore(Unpacker unpacker, NameValueCollection collection) { }

	// RVA: 0xD95DBC
	private static void UnpackToCore(Unpacker unpacker, NameValueCollection collection, int keyCount) { }

	// RVA: 0xD961AC
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Collections_StackMessagePackSerializer
{
	// Methods

	// RVA: 0xD96214
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD96298
	protected internal override void PackToCore(Packer packer, Stack objectTree) { }

	// RVA: 0xD96534
	protected internal override Stack UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD9686C
	protected internal override void UnpackToCore(Unpacker unpacker, Stack collection) { }

	// RVA: 0xD96604
	private static ICollection UnpackItemsInReverseOrder(Unpacker unpacker, int count) { }

	// RVA: 0xD96BB8
	public object CreateInstance(int initialCapacity) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class System_DBNullMessagePackSerializer
{
	// Methods

	// RVA: 0xD96C20
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD96CA4
	protected internal override void PackToCore(Packer packer, DBNull objectTree) { }

	// RVA: 0xD96CC0
	protected internal override DBNull UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD96D14
	protected internal override DBNull UnpackNil() { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Globalization_CultureInfoMessagePackSerializer
{
	// Methods

	// RVA: 0xD96D90
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD96E14
	protected internal override void PackToCore(Packer packer, CultureInfo objectTree) { }

	// RVA: 0xD96E58
	protected internal override CultureInfo UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_ObjectMessagePackSerializer
{
	// Methods

	// RVA: 0xD96EE8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD96F6C
	protected internal override void PackToCore(Packer packer, object value) { }

	// RVA: 0xD97074
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_StringMessagePackSerializer
{
	// Methods

	// RVA: 0xD973B0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD97434
	protected internal override void PackToCore(Packer packer, string value) { }

	// RVA: 0xD97454
	protected internal override string UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_Text_StringBuilderMessagePackSerializer
{
	// Methods

	// RVA: 0xD97514
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD97598
	protected internal override void PackToCore(Packer packer, StringBuilder value) { }

	// RVA: 0xD975DC
	protected internal override StringBuilder UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD976CC
	protected internal override void UnpackToCore(Unpacker unpacker, StringBuilder collection) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_UriMessagePackSerializer
{
	// Methods

	// RVA: 0xD977A0
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD97824
	protected internal override void PackToCore(Packer packer, Uri objectTree) { }

	// RVA: 0xD97868
	protected internal override Uri UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal sealed class System_VersionMessagePackSerializer
{
	// Methods

	// RVA: 0xD978E8
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD9796C
	protected internal override void PackToCore(Packer packer, Version objectTree) { }

	// RVA: 0xD979E4
	protected internal override Version UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xD8B8B4
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD97C70
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD97D1C
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class TimestampMessagePackSerializer
{
	// Fields
	private readonly DateTimeConversionMethod _conversion; // 0x24

	// Methods

	// RVA: 0xD97DC4
	public void .ctor(SerializationContext ownerContext, DateTimeConversionMethod conversion) { }

	// RVA: 0xD97E5C
	protected internal override void PackToCore(Packer packer, Timestamp objectTree) { }

	// RVA: 0xD97FF4
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

	// RVA: 0xD982CC
	public void .ctor(SerializationContext context, bool isNullable) { }

	// RVA: 0xD98744
	public override object Get(SerializationContext context, object providerParameter) { }

}

// Namespace: MsgPack.Serialization.DefaultSerializers
internal class UnixEpocDateTimeMessagePackSerializer
{
	// Methods

	// RVA: 0xD8B774
	public void .ctor(SerializationContext ownerContext) { }

	// RVA: 0xD98978
	protected internal override void PackToCore(Packer packer, DateTime objectTree) { }

	// RVA: 0xD98A14
	protected internal override DateTime UnpackFromCore(Unpacker unpacker) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityCollectionMessagePackSerializer
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40
	private readonly MethodInfo _add; // 0x48

	// Methods

	// RVA: 0xD80D14
	protected void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD98B88
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD98F48
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD80FEC
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD991D8
	protected override void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializer<T0, T1, T2>
{
	// Methods

	// RVA: 0x318DB98
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

	// RVA: 0xD81294
	protected void .ctor(SerializationContext ownerContext, Type targetType, Type keyType, Type valueType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD992C4
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD99728
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD81598
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD99C20
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD99C30
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD99784
	private void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
public abstract class DictionaryMessagePackSerializerBase<T0, T1, T2>
{
	// Fields
	private readonly MsgPack.Serialization.MessagePackSerializer<TKey> _keySerializer; // 0x0
	private readonly MsgPack.Serialization.MessagePackSerializer<TValue> _valueSerializer; // 0x0

	// Methods

	// RVA: 0x318DB98
	protected internal override void PackToCore(Packer packer, TDictionary objectTree) { }

	// RVA: -1
	protected abstract int GetCount(TDictionary dictionary) { }

	// RVA: 0x318DB98
	protected internal override TDictionary UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0x318DB98
	internal virtual TDictionary InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract TDictionary CreateInstance(int initialCapacity) { }

	// RVA: 0x318DB98
	private void UnpackToCore(Unpacker unpacker, TDictionary collection, int itemsCount) { }

	// RVA: 0x318DB98
	protected virtual void AddItem(TDictionary dictionary, TKey key, TValue value) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityEnumerableMessagePackSerializer
{
	// Fields
	private readonly MethodInfo _getCount; // 0x40

	// Methods

	// RVA: 0xD817E8
	protected void .ctor(SerializationContext ownerContext, Type targetType, CollectionTraits traits, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD99CD8
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

	// RVA: 0xD9A0E4
	internal MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xD98AA4
	protected void .ctor(SerializationContext ownerContext, Type targetType, Type itemType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD9A0EC
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD9A0FC
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD98FA4
	internal void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xD9A1A4
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

	// RVA: 0xD7A500
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD7AD24
	protected internal override void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericDictionaryMessagePackSerializer
{
	// Fields
	private readonly MessagePackSerializer _keySerializer; // 0x38
	private readonly MessagePackSerializer _valueSerializer; // 0x40

	// Methods

	// RVA: 0xD7C2DC
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD7C588
	protected internal override void PackToCore(Packer packer, object objectTree) { }

	// RVA: 0xD7CAF4
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD81E04
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD9A760
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD9A770
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD9A320
	private void UnpackToCore(Unpacker unpacker, IDictionary collection, int itemsCount) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializer
{
	// Methods

	// RVA: 0xD7B8A0
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD7B9C4
	protected internal override void PackToCore(Packer packer, object objectTree) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericEnumerableMessagePackSerializerBase
{
	// Fields
	private readonly MessagePackSerializer _itemSerializer; // 0x38

	// Methods

	// RVA: 0xD9A844
	internal MessagePackSerializer get_ItemSerializer() { }

	// RVA: 0xD9A1DC
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: -1
	protected abstract object CreateInstance(int initialCapacity) { }

	// RVA: 0xD9A84C
	private object MsgPack.Serialization.CollectionSerializers.ICollectionInstanceFactory.CreateInstance(int initialCapacity) { }

	// RVA: 0xD9A85C
	protected internal override void UnpackToCore(Unpacker unpacker, object collection) { }

	// RVA: 0xD7B270
	internal void UnpackToCore(Unpacker unpacker, object collection, int itemsCount) { }

	// RVA: 0xD9A904
	protected virtual void AddItem(object collection, object item) { }

}

// Namespace: MsgPack.Serialization.CollectionSerializers
internal abstract class UnityNonGenericListMessagePackSerializer
{
	// Methods

	// RVA: 0xD7CE74
	protected void .ctor(SerializationContext ownerContext, Type targetType, PolymorphismSchema schema, SerializerCapabilities capabilities) { }

	// RVA: 0xD7D0FC
	protected internal override object UnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD82448
	internal virtual object InternalUnpackFromCore(Unpacker unpacker) { }

	// RVA: 0xD9A93C
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


