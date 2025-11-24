// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xF5C118
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xF5C120
	public void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xF5C1AC
	public void .ctor(Byte ) { }

}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0xF5C1D8
	internal static string GetString(string name) { }

	// RVA: 0xF5C1DC
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0xF5C250
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0xF5C2D4
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }

}

// Namespace: System
internal static class LocalAppContextSwitches
{
	// Fields
	private static int s_allowArbitraryTypeInstantiation; // 0x0

	// Methods

	// RVA: 0xF5C360
	public static bool get_AllowArbitraryTypeInstantiation() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.LocalAppContext.<>c <>9; // 0x0
	public static System.Func<System.Boolean> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xF5C730
	private static void .cctor() { }

	// RVA: 0xF5C79C
	public void .ctor() { }

	// RVA: 0xF5C7A4
	internal bool <get_DisableCaching>b__6_0() { }

}

// Namespace: System
internal class LocalAppContext
{
	// Fields
	private static bool s_isDisableCachingInitialized; // 0x0
	private static bool s_disableCaching; // 0x1
	private static object s_syncObject; // 0x8

	// Methods

	// RVA: 0xF5C47C
	internal static bool GetCachedSwitchValue(string switchName, int switchValue) { }

	// RVA: 0xF5C558
	private static bool GetCachedSwitchValueInternal(string switchName, int switchValue) { }

	// RVA: 0xF5C5F8
	private static bool get_DisableCaching() { }

}

// Namespace: System.Data
public class DataColumn
{
	// Fields
	private bool _allowNull; // 0x20
	private string _caption; // 0x28
	private string _columnName; // 0x30
	private Type _dataType; // 0x38
	private StorageType _storageType; // 0x40
	internal object _defaultValue; // 0x48
	private DataSetDateTime _dateTimeMode; // 0x50
	private DataExpression _expression; // 0x58
	private int _maxLength; // 0x60
	private int _ordinal; // 0x64
	private bool _readOnly; // 0x68
	internal Index _sortIndex; // 0x70
	internal DataTable _table; // 0x78
	private bool _unique; // 0x80
	internal MappingType _columnMapping; // 0x84
	internal int _hashCode; // 0x88
	internal int _errors; // 0x8C
	private bool _isSqlType; // 0x90
	private bool _implementsINullable; // 0x91
	private bool _implementsIChangeTracking; // 0x92
	private bool _implementsIRevertibleChangeTracking; // 0x93
	private bool _implementsIXMLSerializable; // 0x94
	private bool _defaultValueIsNull; // 0x95
	internal System.Collections.Generic.List<System.Data.DataColumn> _dependentColumns; // 0x98
	internal PropertyCollection _extendedProperties; // 0xA0
	private DataStorage _storage; // 0xA8
	private AutoIncrementValue _autoInc; // 0xB0
	internal string _columnUri; // 0xB8
	private string _columnPrefix; // 0xC0
	internal string _encodedColumnName; // 0xC8
	internal SimpleType _simpleType; // 0xD0
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0xD8
	private string <XmlDataType>k__BackingField; // 0xE0
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	// Methods

	// RVA: 0xF5C828
	public void .ctor() { }

	// RVA: 0xF5CBEC
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0xF5C880
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0xF5CE00
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0xF5D8F0
	public bool get_AllowDBNull() { }

	// RVA: 0xF5D8F8
	public void set_AllowDBNull(bool value) { }

	// RVA: 0xF5DEC0
	public bool get_AutoIncrement() { }

	// RVA: 0xF5DEE0
	public void set_AutoIncrement(bool value) { }

	// RVA: 0xF5F00C
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0xF5F070
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0xF5EE8C
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0xF5F058
	public Int64 get_AutoIncrementSeed() { }

	// RVA: 0xF5F350
	public void set_AutoIncrementSeed(Int64 value) { }

	// RVA: 0xF5F468
	public Int64 get_AutoIncrementStep() { }

	// RVA: 0xF5F484
	public void set_AutoIncrementStep(Int64 value) { }

	// RVA: 0xF5F5BC
	public string get_Caption() { }

	// RVA: 0xF5F5D8
	public void set_Caption(string value) { }

	// RVA: 0xF5F75C
	public string get_ColumnName() { }

	// RVA: 0xF5F764
	public void set_ColumnName(string value) { }

	// RVA: 0xF5FD34
	internal string get_EncodedColumnName() { }

	// RVA: 0xF5F23C
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xF5F6DC
	internal CultureInfo get_Locale() { }

	// RVA: 0xF5FDD0
	internal int get_ObjectID() { }

	// RVA: 0xF5FDD8
	public string get_Prefix() { }

	// RVA: 0xF5FDE0
	public void set_Prefix(string value) { }

	// RVA: 0xF60098
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0xF6024C
	internal bool get_Computed() { }

	// RVA: 0xF6025C
	internal DataExpression get_DataExpression() { }

	// RVA: 0xF60264
	public Type get_DataType() { }

	// RVA: 0xF5E584
	public void set_DataType(Type value) { }

	// RVA: 0xF60E84
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0xF60E8C
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0xF605AC
	public object get_DefaultValue() { }

	// RVA: 0xF60774
	public void set_DefaultValue(object value) { }

	// RVA: 0xF613D4
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0xF613DC
	internal void BindExpression() { }

	// RVA: 0xF61404
	public string get_Expression() { }

	// RVA: 0xF5CF38
	public void set_Expression(string value) { }

	// RVA: 0xF61BAC
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF5E464
	internal bool get_HasData() { }

	// RVA: 0xF61C38
	internal bool get_ImplementsINullable() { }

	// RVA: 0xF61C40
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0xF61C48
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0xF61C50
	internal bool get_IsValueType() { }

	// RVA: 0xF61C70
	internal bool get_IsSqlType() { }

	// RVA: 0xF61C78
	private void SetMaxLengthSimpleType() { }

	// RVA: 0xF61D64
	public int get_MaxLength() { }

	// RVA: 0xF61D6C
	public void set_MaxLength(int value) { }

	// RVA: 0xF62758
	public string get_Namespace() { }

	// RVA: 0xF6279C
	public void set_Namespace(string value) { }

	// RVA: 0xF62ABC
	public int get_Ordinal() { }

	// RVA: 0xF62AC4
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0xF62C18
	public bool get_ReadOnly() { }

	// RVA: 0xF61610
	public void set_ReadOnly(bool value) { }

	// RVA: 0xF62CBC
	private Index get_SortIndex() { }

	// RVA: 0xF62DC0
	public DataTable get_Table() { }

	// RVA: 0xF62DC8
	internal void SetTable(DataTable table) { }

	// RVA: 0xF62EAC
	private DataRow GetDataRow(int index) { }

	// RVA: 0xF6016C
	internal object get_Item(int record) { }

	// RVA: 0xF62ED4
	internal void set_Item(int record, object value) { }

	// RVA: 0xF61A7C
	internal void InitializeRecord(int record) { }

	// RVA: 0xF631EC
	internal void SetValue(int record, object value) { }

	// RVA: 0xF63320
	internal void FreeRecord(int record) { }

	// RVA: 0xF63348
	public bool get_Unique() { }

	// RVA: 0xF63350
	public void set_Unique(bool value) { }

	// RVA: 0xF6391C
	internal void InternalUnique(bool value) { }

	// RVA: 0xF63924
	internal string get_XmlDataType() { }

	// RVA: 0xF6392C
	internal void set_XmlDataType(string value) { }

	// RVA: 0xF63934
	internal SimpleType get_SimpleType() { }

	// RVA: 0xF5CDA0
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0xF6393C
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0xF63944
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0xF63EE4
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xF622AC
	internal bool CheckMaxLength() { }

	// RVA: 0xF63FB8
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0xF5DA98
	protected internal void CheckNotAllowNull() { }

	// RVA: 0xF63F3C
	internal void CheckNullable(DataRow row) { }

	// RVA: 0xF638C4
	protected void CheckUnique() { }

	// RVA: 0xF644A0
	internal int Compare(int record1, int record2) { }

	// RVA: 0xF644C4
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0xF64680
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0xF646A4
	internal object ConvertValue(object value) { }

	// RVA: 0xF646C8
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0xF646EC
	internal DataColumn Clone() { }

	// RVA: 0xF64E08
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0xF64034
	private int GetStringLength(int record) { }

	// RVA: 0xF64EE0
	internal void Init(int record) { }

	// RVA: 0xF5E1C0
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0xF64F78
	internal bool get_IsCustomType() { }

	// RVA: 0xF65004
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0xF650F0
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0xF6038C
	internal bool IsInRelation() { }

	// RVA: 0xF650F8
	internal bool IsMaxLengthViolated() { }

	// RVA: 0xF657D8
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0xF65A8C
	internal void FinishInitInProgress() { }

	// RVA: 0xF65AA8
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF5FCB8
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF65ACC
	private void InsureStorage() { }

	// RVA: 0xF65B6C
	internal void SetCapacity(int capacity) { }

	// RVA: 0xF65C28
	internal void OnSetDataSet() { }

	// RVA: 0xF65C2C
	public override string ToString() { }

	// RVA: 0xF65CF0
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0xF65DAC
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xF60190
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0xF65E70
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xF65F44
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0xF65FF8
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xF66018
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xF660D4
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF661A4
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF61938
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

}

// Namespace: System.Data
internal abstract class AutoIncrementValue
{
	// Fields
	private bool <Auto>k__BackingField; // 0x10

	// Methods

	// RVA: 0xF66248
	internal bool get_Auto() { }

	// RVA: 0xF66250
	internal void set_Auto(bool value) { }

	// RVA: -1
	internal abstract object get_Current() { }

	// RVA: -1
	internal abstract void set_Current(object value) { }

	// RVA: -1
	internal abstract Int64 get_Seed() { }

	// RVA: -1
	internal abstract void set_Seed(Int64 value) { }

	// RVA: -1
	internal abstract Int64 get_Step() { }

	// RVA: -1
	internal abstract void set_Step(Int64 value) { }

	// RVA: -1
	internal abstract Type get_DataType() { }

	// RVA: -1
	internal abstract void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: -1
	internal abstract void SetCurrentAndIncrement(object value) { }

	// RVA: -1
	internal abstract void MoveAfter() { }

	// RVA: 0xF64C94
	internal AutoIncrementValue Clone() { }

	// RVA: 0xF66258
	protected void .ctor() { }

}

// Namespace: System.Data
internal sealed class AutoIncrementInt64
{
	// Fields
	private Int64 _current; // 0x18
	private Int64 _seed; // 0x20
	private Int64 _step; // 0x28

	// Methods

	// RVA: 0xF66260
	internal override object get_Current() { }

	// RVA: 0xF66294
	internal override void set_Current(object value) { }

	// RVA: 0xF662F4
	internal override Type get_DataType() { }

	// RVA: 0xF66344
	internal override Int64 get_Seed() { }

	// RVA: 0xF6634C
	internal override void set_Seed(Int64 value) { }

	// RVA: 0xF66508
	internal override Int64 get_Step() { }

	// RVA: 0xF66510
	internal override void set_Step(Int64 value) { }

	// RVA: 0xF6662C
	internal override void MoveAfter() { }

	// RVA: 0xF66640
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xF666C0
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0xF663F8
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xF5F2BC
	public void .ctor() { }

}

// Namespace: System.Data
internal sealed class AutoIncrementBigInteger
{
	// Fields
	private BigInteger _current; // 0x18
	private Int64 _seed; // 0x28
	private BigInteger _step; // 0x30

	// Methods

	// RVA: 0xF667FC
	internal override object get_Current() { }

	// RVA: 0xF66864
	internal override void set_Current(object value) { }

	// RVA: 0xF668F0
	internal override Type get_DataType() { }

	// RVA: 0xF66980
	internal override Int64 get_Seed() { }

	// RVA: 0xF66988
	internal override void set_Seed(Int64 value) { }

	// RVA: 0xF66C20
	internal override Int64 get_Step() { }

	// RVA: 0xF66C8C
	internal override void set_Step(Int64 value) { }

	// RVA: 0xF66E84
	internal override void MoveAfter() { }

	// RVA: 0xF66F24
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xF66F60
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0xF66AA4
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xF5F2CC
	public void .ctor() { }

}

// Namespace: System.Data
[Serializable]
public class DataException
{
	// Methods

	// RVA: 0xF6704C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF67054
	public void .ctor() { }

	// RVA: 0xF670BC
	public void .ctor(string s) { }

	// RVA: 0xF670EC
	public void .ctor(string s, Exception innerException) { }

}

// Namespace: System.Data
[Serializable]
public class ConstraintException
{
	// Methods

	// RVA: 0xF670F4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF670FC
	public void .ctor() { }

	// RVA: 0xF67164
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class DeletedRowInaccessibleException
{
	// Methods

	// RVA: 0xF67194
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF6719C
	public void .ctor() { }

	// RVA: 0xF67204
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class DuplicateNameException
{
	// Methods

	// RVA: 0xF67234
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF6723C
	public void .ctor() { }

	// RVA: 0xF672A4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class InRowChangingEventException
{
	// Methods

	// RVA: 0xF672D4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF672DC
	public void .ctor() { }

	// RVA: 0xF67344
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class InvalidConstraintException
{
	// Methods

	// RVA: 0xF67374
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF6737C
	public void .ctor() { }

	// RVA: 0xF673E4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class NoNullAllowedException
{
	// Methods

	// RVA: 0xF67414
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF6741C
	public void .ctor() { }

	// RVA: 0xF67484
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class ReadOnlyException
{
	// Methods

	// RVA: 0xF674B4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF674BC
	public void .ctor() { }

	// RVA: 0xF67524
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class RowNotInTableException
{
	// Methods

	// RVA: 0xF67554
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF6755C
	public void .ctor() { }

	// RVA: 0xF675C4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class VersionNotFoundException
{
	// Methods

	// RVA: 0xF675F4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF675FC
	public void .ctor() { }

	// RVA: 0xF67664
	public void .ctor(string s) { }

}

// Namespace: System.Data
internal static class ExceptionBuilder
{
	// Methods

	// RVA: 0xF67694
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0xF6773C
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0xF61728
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0xF61ABC
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0xF6782C
	internal static Exception _Argument(string error) { }

	// RVA: 0xF67894
	internal static Exception _Argument(string paramName, string error) { }

	// RVA: 0xF678FC
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0xF6796C
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0xF679DC
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0xF67A4C
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0xF67AB4
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0xF67B1C
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: 0x26AD93C
	private static Exception _InvalidEnumArgumentException(T value) { }

	// RVA: 0xF67B84
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0xF67BDC
	private static Exception _Data(string error) { }

	// RVA: 0xF67C50
	private static Exception _Constraint(string error) { }

	// RVA: 0xF67CC4
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0xF67D38
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0xF67DAC
	private static Exception _DuplicateName(string error) { }

	// RVA: 0xF67E20
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0xF67E94
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0xF67F08
	private static Exception _ReadOnly(string error) { }

	// RVA: 0xF67F7C
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0xF67FF0
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0xF5CBF8
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0xF68064
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0xF68178
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0xF68288
	public static Exception ArgumentContainsNull(string paramName) { }

	// RVA: 0xF68398
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0xF684A0
	public static Exception CannotModifyCollection() { }

	// RVA: 0xF68530
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0xF68640
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0xF68750
	public static Exception InvalidOffsetLength() { }

	// RVA: 0xF687E0
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0xF68900
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0xF68990
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0xF68ABC
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0xF68BCC
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0xF68CDC
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0xF63D44
	public static Exception CannotAddColumn3() { }

	// RVA: 0xF63DD4
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0xF68DEC
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0xF68F08
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0xF69024
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0xF69140
	public static Exception CannotRemoveColumn() { }

	// RVA: 0xF691D0
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0xF69260
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0xF69370
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0xF69490
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0xF695B0
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0xF69640
	public static Exception NoConstraintName() { }

	// RVA: 0xF696D0
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0xF697EC
	public static string KeysToString(object[] keys) { }

	// RVA: 0xF69900
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0xF69B08
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0xF69B80
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0xF69CAC
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0xF69DC8
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0xF69EE4
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0xF6A010
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0xF6A0A0
	public static Exception ConstraintForeignTable() { }

	// RVA: 0xF6A130
	public static Exception ConstraintParentValues() { }

	// RVA: 0xF6A1C0
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0xF6A2C0
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0xF6A350
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0xF6A46C
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0xF6A588
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0xF6A6BC
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0xF6A7CC
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0xF65714
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0xF659C8
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0xF6A8DC
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0xF5E0A0
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0xF5E130
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0xF6659C
	public static Exception AutoIncrementSeed() { }

	// RVA: 0xF6026C
	public static Exception CantChangeDataType() { }

	// RVA: 0xF602FC
	public static Exception NullDataType() { }

	// RVA: 0xF5FC28
	public static Exception ColumnNameRequired() { }

	// RVA: 0xF611F8
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0xF60B34
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xF61288
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xF61464
	public static Exception ExpressionAndUnique() { }

	// RVA: 0xF61818
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0xF614F4
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0xF6A9EC
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0xF618A8
	public static Exception ExpressionCircular() { }

	// RVA: 0xF64384
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0xF6414C
	public static Exception NullKeyValues(string column) { }

	// RVA: 0xF64268
	public static Exception NullValues(string column) { }

	// RVA: 0xF62C20
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0xF6AAE0
	public static Exception ReadOnly(string column) { }

	// RVA: 0xF63834
	public static Exception UniqueAndExpression() { }

	// RVA: 0xF63078
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0xF6ABFC
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0xF64058
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0xF62610
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0xF620C4
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0xF60D64
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0xF63C24
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0xF629AC
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0xF621B8
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0xF5E474
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0xF6ACF0
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0xF6AE00
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0xF6AF1C
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0xF6B02C
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0xF60FB0
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0xF61194
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0xF61040
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0xF5CD0C
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0xF6B134
	public static Exception SetFailed(string name) { }

	// RVA: 0xF6B250
	public static Exception SetRowStateFilter() { }

	// RVA: 0xF6B2EC
	public static Exception CanNotUseDataViewManager() { }

	// RVA: 0xF6B388
	public static Exception CanNotSetTable() { }

	// RVA: 0xF6B424
	public static Exception CanNotUse() { }

	// RVA: 0xF6B4C0
	public static Exception CanNotBindTable() { }

	// RVA: 0xF6B55C
	public static Exception SetTable() { }

	// RVA: 0xF6B5F8
	public static Exception SetIListObject() { }

	// RVA: 0xF6B688
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0xF6B724
	public static Exception NotOpen() { }

	// RVA: 0xF6B7C0
	public static Exception CreateChildView() { }

	// RVA: 0xF6B850
	public static Exception CanNotDelete() { }

	// RVA: 0xF6B8EC
	public static Exception GetElementIndex(int index) { }

	// RVA: 0xF6BA18
	public static Exception AddExternalObject() { }

	// RVA: 0xF6BAA8
	public static Exception CanNotClear() { }

	// RVA: 0xF6BB38
	public static Exception InsertExternalObject() { }

	// RVA: 0xF6BBC8
	public static Exception RemoveExternalObject() { }

	// RVA: 0xF6BC58
	public static Exception ColumnToSortIsOutOfRange(string column) { }

	// RVA: 0xF6BD68
	public static Exception KeyTableMismatch() { }

	// RVA: 0xF6BE04
	public static Exception KeyNoColumns() { }

	// RVA: 0xF6BEA0
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0xF6BFD8
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0xF6C0F4
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0xF60510
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0xF6C190
	public static Exception KeyLengthMismatch() { }

	// RVA: 0xF6C220
	public static Exception KeyLengthZero() { }

	// RVA: 0xF6C2B0
	public static Exception ForeignRelation() { }

	// RVA: 0xF6C340
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0xF6C3DC
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0xF6C508
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xF6C634
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xF6C760
	public static Exception RelationForeignRow() { }

	// RVA: 0xF6C7F0
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0xF6C880
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0xF6C990
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0xF6CAA0
	public static Exception RelationDoesNotExist() { }

	// RVA: 0xF6CB30
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0xF6CBCC
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0xF6CCDC
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0xF6CDEC
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0xF6CE7C
	public static Exception RowNotInTheTable() { }

	// RVA: 0xF6CF18
	public static Exception EditInRowChanging() { }

	// RVA: 0xF6CFB4
	public static Exception EndEditInRowChanging() { }

	// RVA: 0xF6D050
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0xF6D0EC
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0xF6D188
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0xF6D224
	public static Exception ValueArrayLength() { }

	// RVA: 0xF6D2B4
	public static Exception NoCurrentData() { }

	// RVA: 0xF6D350
	public static Exception NoOriginalData() { }

	// RVA: 0xF6D3EC
	public static Exception NoProposedData() { }

	// RVA: 0xF6D488
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0xF6D524
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0xF6D5C0
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0xF6D65C
	public static Exception RowEmpty() { }

	// RVA: 0xF6D6EC
	public static Exception InvalidRowVersion() { }

	// RVA: 0xF6D788
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0xF6D8B4
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0xF6D9F0
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0xF6DB00
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0xF6DB9C
	public static Exception MultipleParents() { }

	// RVA: 0xF6DC38
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0xF6DC9C
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0xF6DD2C
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0xF6DDBC
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0xF6DECC
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0xF6DFDC
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0xF6E0EC
	public static Exception TablesInDifferentSets() { }

	// RVA: 0xF6E17C
	public static Exception RelationAlreadyExists() { }

	// RVA: 0xF6E20C
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0xF6E29C
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0xF6E32C
	public static Exception RecordStateRange() { }

	// RVA: 0xF6E3BC
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0xF6E560
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0xF6E6A8
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0xF6E738
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0xF6E7C8
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0xF6E8D8
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0xF6E9F8
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0xF6EB14
	public static Exception RelationTableNull() { }

	// RVA: 0xF6EBA4
	public static Exception RelationDataSetNull() { }

	// RVA: 0xF6EC34
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0xF6ECC4
	public static Exception ParentTableMismatch() { }

	// RVA: 0xF6ED54
	public static Exception ChildTableMismatch() { }

	// RVA: 0xF6EDE4
	public static Exception EnforceConstraint() { }

	// RVA: 0xF6EE80
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0xF6EF10
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0xF6EFA4
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0xF6F03C
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0xF6F0A0
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0xF6F130
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0xF6F1C0
	public static Exception NoTableName() { }

	// RVA: 0xF6F250
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0xF6F2E0
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0xF6F3F0
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0xF6F50C
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0xF6F638
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0xF6F754
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0xF6F870
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0xF6F900
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0xF6F990
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0xF6FABC
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0xF6FBCC
	public static Exception TableInRelation() { }

	// RVA: 0xF6FC5C
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0xF6FD78
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0xF6FE08
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0xF6FE98
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0xF6FF28
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0xF6FFB8
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0xF700C8
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0xF70228
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0xF7035C
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0xF704B0
	public static Exception NullRange() { }

	// RVA: 0xF7054C
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0xF705DC
	public static Exception ProblematicChars(Char charValue) { }

	// RVA: 0xF70750
	public static Exception StorageSetFailed() { }

	// RVA: 0xF707E0
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0xF7087C
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0xF70898
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0xF709C4
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0xF70AF0
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0xF70C24
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0xF70D40
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0xF70E5C
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0xF70F78
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0xF71094
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0xF711B0
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0xF712CC
	public static Exception DatatypeNotDefined() { }

	// RVA: 0xF71368
	public static Exception MismatchKeyLength() { }

	// RVA: 0xF71404
	public static Exception InvalidField(string name) { }

	// RVA: 0xF71520
	public static Exception InvalidSelector(string name) { }

	// RVA: 0xF7163C
	public static Exception CircularComplexType(string name) { }

	// RVA: 0xF71758
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0xF71874
	public static Exception InvalidKey(string name) { }

	// RVA: 0xF71990
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0xF71AAC
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0xF71B48
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0xF71C64
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0xF71D80
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0xF71EAC
	public static Exception MissingRefer(string name) { }

	// RVA: 0xF5FF7C
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0xF71FE0
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0xF72070
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0xF7210C
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0xF721A8
	public static Exception NestedCircular(string name) { }

	// RVA: 0xF722C4
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0xF723E0
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0xF724F0
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0xF72580
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0xF7261C
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0xF72738
	public static Exception FoundEntity() { }

	// RVA: 0xF727D4
	public static Exception MergeFailed(string name) { }

	// RVA: 0xF72848
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0xF72988
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0xF72AA8
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0xF72BB8
	public static Exception EnumeratorModified() { }

}

// Namespace: System.Data
[Serializable]
public class DataSet
{
	// Fields
	private DataViewManager _defaultViewManager; // 0x20
	private readonly DataTableCollection _tableCollection; // 0x28
	private readonly DataRelationCollection _relationCollection; // 0x30
	internal PropertyCollection _extendedProperties; // 0x38
	private string _dataSetName; // 0x40
	private string _datasetPrefix; // 0x48
	internal string _namespaceURI; // 0x50
	private bool _enforceConstraints; // 0x58
	private bool _caseSensitive; // 0x59
	private CultureInfo _culture; // 0x60
	private bool _cultureUserSet; // 0x68
	internal bool _fInReadXml; // 0x69
	internal bool _fInLoadDiffgram; // 0x6A
	internal bool _fTopLevelTable; // 0x6B
	internal bool _fInitInProgress; // 0x6C
	internal bool _fEnableCascading; // 0x6D
	internal bool _fIsSchemaLoading; // 0x6E
	internal string _mainTableName; // 0x70
	private SerializationFormat _remotingFormat; // 0x78
	private object _defaultViewManagerLock; // 0x80
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x88
	private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
	internal bool _useDataSetSchemaOnly; // 0x8C
	internal bool _udtIsWrapped; // 0x8D
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	private MergeFailedEventHandler MergeFailed; // 0x98
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8
	private EventHandler Initialized; // 0xB0

	// Methods

	// RVA: 0xF72C48
	public void .ctor() { }

	// RVA: 0xF72F24
	public void .ctor(string dataSetName) { }

	// RVA: 0xF73128
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xF73130
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xF731DC
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0xF731E4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF731EC
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0xF73454
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF73A58
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0xF7345C
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xF73400
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xF747CC
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xF74C7C
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xF73A5C
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF74E24
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF73C24
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF750F4
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF76444
	internal void FailedEnableConstraints() { }

	// RVA: 0xF76600
	public bool get_CaseSensitive() { }

	// RVA: 0xF76608
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xF76D4C
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xF76D54
	public DataViewManager get_DefaultViewManager() { }

	// RVA: 0xF76EA0
	public bool get_EnforceConstraints() { }

	// RVA: 0xF76478
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0xF77600
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0xF76EA8
	internal void EnableConstraints() { }

	// RVA: 0xF77608
	public string get_DataSetName() { }

	// RVA: 0xF72F50
	public void set_DataSetName(string value) { }

	// RVA: 0xF7768C
	public string get_Namespace() { }

	// RVA: 0xF77694
	public void set_Namespace(string value) { }

	// RVA: 0xF77BE8
	public string get_Prefix() { }

	// RVA: 0xF77BF0
	public void set_Prefix(string value) { }

	// RVA: 0xF763B8
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF77DA0
	public bool get_IsInitialized() { }

	// RVA: 0xF77DB0
	public CultureInfo get_Locale() { }

	// RVA: 0xF77DB8
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xF77F60
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0xF78B70
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xF78B78
	public override ISite get_Site() { }

	// RVA: 0xF78B80
	public override void set_Site(ISite value) { }

	// RVA: 0xF78D60
	public DataRelationCollection get_Relations() { }

	// RVA: 0xF78D68
	public DataTableCollection get_Tables() { }

	// RVA: 0xF78D70
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xF78E14
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xF78EB8
	public void BeginInit() { }

	// RVA: 0xF78EC4
	public void EndInit() { }

	// RVA: 0xF790F4
	public void Clear() { }

	// RVA: 0xF7933C
	public virtual DataSet Clone() { }

	// RVA: 0xF74480
	internal int EstimatedXmlStringSize() { }

	// RVA: 0xF7A43C
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xF7A440
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0xF742E8
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0xF7A578
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0xF75988
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF7AADC
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xF7B04C
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0xF7ABA8
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xF7A6DC
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF7A580
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xF7B0E0
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xF7B330
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0xF7B338
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF7AC80
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0xF7DC58
	private bool IsEmpty() { }

	// RVA: 0xF7C6BC
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xF763B0
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0xF7E0D8
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xF745A0
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0xF7DF4C
	public void Merge(DataSet dataSet) { }

	// RVA: 0xF7F074
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF7F2F8
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF7F31C
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0xF7F380
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF7F470
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0xF79318
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0xF79064
	private void OnInitialized() { }

	// RVA: 0xF7F494
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0xF7F498
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0xF7F4C8
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xF7F4CC
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0xF77610
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF7F4DC
	internal DataTable[] TopLevelTables() { }

	// RVA: 0xF7F4E4
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0xF7F820
	public virtual void Reset() { }

	// RVA: 0xF76904
	internal bool ValidateCaseConstraint() { }

	// RVA: 0xF786C0
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0xF7FB04
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	// RVA: 0xF7FC2C
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xF7FFB4
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xF80240
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF80408
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF8065C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF80694
	internal string get_MainTableName() { }

	// RVA: 0xF8069C
	internal void set_MainTableName(string value) { }

	// RVA: 0xF806A4
	internal int get_ObjectID() { }

}

// Namespace: 
internal struct RowDiffIdUsageSection
{
	// Fields
	private DataTable _targetTable; // 0x10

	// Methods

	// RVA: 0xF806AC
	internal void Prepare(DataTable table) { }

}

// Namespace: 
internal struct DSRowDiffIdUsageSection
{
	// Fields
	private DataSet _targetDS; // 0x10

	// Methods

	// RVA: 0xF7C638
	internal void Prepare(DataSet ds) { }

}

// Namespace: System.Data
[Serializable]
public class DataTable
{
	// Fields
	private DataSet _dataSet; // 0x20
	private DataView _defaultView; // 0x28
	internal Int64 _nextRowID; // 0x30
	internal readonly DataRowCollection _rowCollection; // 0x38
	internal readonly DataColumnCollection _columnCollection; // 0x40
	private readonly ConstraintCollection _constraintCollection; // 0x48
	private int _elementColumnCount; // 0x50
	internal DataRelationCollection _parentRelationsCollection; // 0x58
	internal DataRelationCollection _childRelationsCollection; // 0x60
	internal readonly RecordManager _recordManager; // 0x68
	internal readonly System.Collections.Generic.List<System.Data.Index> _indexes; // 0x70
	private System.Collections.Generic.List<System.Data.Index> _shadowIndexes; // 0x78
	private int _shadowCount; // 0x80
	internal PropertyCollection _extendedProperties; // 0x88
	private string _tableName; // 0x90
	internal string _tableNamespace; // 0x98
	private string _tablePrefix; // 0xA0
	internal DataExpression _displayExpression; // 0xA8
	internal bool _fNestedInDataset; // 0xB0
	private CultureInfo _culture; // 0xB8
	private bool _cultureUserSet; // 0xC0
	private CompareInfo _compareInfo; // 0xC8
	private CompareOptions _compareFlags; // 0xD0
	private IFormatProvider _formatProvider; // 0xD8
	private StringComparer _hashCodeProvider; // 0xE0
	private bool _caseSensitive; // 0xE8
	private bool _caseSensitiveUserSet; // 0xE9
	internal string _encodedTableName; // 0xF0
	internal DataColumn _xmlText; // 0xF8
	internal DataColumn _colUnique; // 0x100
	internal Decimal _minOccurs; // 0x108
	internal Decimal _maxOccurs; // 0x118
	internal bool _repeatableElement; // 0x128
	private object _typeName; // 0x130
	internal UniqueConstraint _primaryKey; // 0x138
	internal IndexField[] _primaryIndex; // 0x140
	private DataColumn[] _delayedSetPrimaryKey; // 0x148
	private Index _loadIndex; // 0x150
	private Index _loadIndexwithOriginalAdded; // 0x158
	private Index _loadIndexwithCurrentDeleted; // 0x160
	private int _suspendIndexEvents; // 0x168
	private bool _inDataLoad; // 0x16C
	private bool _schemaLoading; // 0x16D
	private bool _enforceConstraints; // 0x16E
	internal bool _suspendEnforceConstraints; // 0x16F
	protected internal bool fInitInProgress; // 0x170
	private bool _inLoad; // 0x171
	internal bool _fInLoadDiffgram; // 0x172
	private Byte _isTypedDataTable; // 0x173
	private DataRow[] _emptyDataRowArray; // 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
	private DataRelation[] _nestedParentRelations; // 0x188
	internal System.Collections.Generic.List<System.Data.DataColumn> _dependentColumns; // 0x190
	private bool _mergingData; // 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
	private EventHandler _onInitialized; // 0x1F0
	private readonly DataRowBuilder _rowBuilder; // 0x1F8
	internal readonly System.Collections.Generic.List<System.Data.DataView> _delayedViews; // 0x200
	private readonly System.Collections.Generic.List<System.Data.DataViewListener> _dataViewListeners; // 0x208
	internal Hashtable _rowDiffId; // 0x210
	internal readonly ReaderWriterLockSlim _indexesLock; // 0x218
	internal int _ukColumnPositionForInference; // 0x220
	private SerializationFormat _remotingFormat; // 0x224
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x228

	// Methods

	// RVA: 0xF3FB9C
	public void .ctor() { }

	// RVA: 0xF40174
	public void .ctor(string tableName) { }

	// RVA: 0xF401E8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF40714
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF40810
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xF403A4
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xF40BDC
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xF42044
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xF45288
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xF462C0
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xF4700C
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xF471E4
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xF41920
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xF42F34
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xF47694
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0xF473B0
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xF4777C
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xF47A4C
	public bool get_CaseSensitive() { }

	// RVA: 0xF47A54
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xF47AF4
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0xF47B04
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0xF47F74
	internal void SuspendIndexEvents() { }

	// RVA: 0xF48058
	public bool get_IsInitialized() { }

	// RVA: 0xF48068
	private bool get_IsTypedDataTable() { }

	// RVA: 0xF459AC
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0xF4812C
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0xF48134
	internal bool get_SelfNested() { }

	// RVA: 0xF48560
	internal System.Collections.Generic.List<System.Data.Index> get_LiveIndexes() { }

	// RVA: 0xF48630
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xF48638
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xF486A4
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0xF486AC
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0xF486B4
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0xF4875C
	public DataColumnCollection get_Columns() { }

	// RVA: 0xF48764
	private CompareInfo get_CompareInfo() { }

	// RVA: 0xF487C8
	public ConstraintCollection get_Constraints() { }

	// RVA: 0xF487D0
	private void ResetConstraints() { }

	// RVA: 0xF487F0
	public DataSet get_DataSet() { }

	// RVA: 0xF487F8
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xF488C8
	public DataView get_DefaultView() { }

	// RVA: 0xF489D8
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0xF48A00
	internal bool get_EnforceConstraints() { }

	// RVA: 0xF48A38
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0xF4903C
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0xF49044
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0xF48A88
	internal void EnableConstraints() { }

	// RVA: 0xF44C98
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF4904C
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xF490FC
	public CultureInfo get_Locale() { }

	// RVA: 0xF49104
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xF45CC4
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0xF495CC
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xF495D4
	public int get_MinimumCapacity() { }

	// RVA: 0xF4628C
	public void set_MinimumCapacity(int value) { }

	// RVA: 0xF495F4
	internal int get_RecordCapacity() { }

	// RVA: 0xF49614
	internal int get_ElementColumnCount() { }

	// RVA: 0xF4961C
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0xF484B8
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0xF4966C
	internal bool get_MergingData() { }

	// RVA: 0xF49674
	internal void set_MergingData(bool value) { }

	// RVA: 0xF4967C
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0xF49684
	internal bool get_SchemaLoading() { }

	// RVA: 0xF4968C
	internal void CacheNestedParent() { }

	// RVA: 0xF496B8
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0xF49B6C
	internal int get_NestedParentsCount() { }

	// RVA: 0xF49EB8
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0xF49FB8
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0xF4A4B8
	public DataRowCollection get_Rows() { }

	// RVA: 0xF4A4C0
	public string get_TableName() { }

	// RVA: 0xF4A4C8
	public void set_TableName(string value) { }

	// RVA: 0xF4AC28
	internal string get_EncodedTableName() { }

	// RVA: 0xF4ACD8
	private string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables) { }

	// RVA: 0xF41FBC
	public string get_Namespace() { }

	// RVA: 0xF44890
	public void set_Namespace(string value) { }

	// RVA: 0xF4BDF8
	internal bool IsNamespaceInherited() { }

	// RVA: 0xF4AED8
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0xF4B32C
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0xF4BE08
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0xF4B7A0
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0xF4C260
	public virtual void BeginInit() { }

	// RVA: 0xF4C26C
	public virtual void EndInit() { }

	// RVA: 0xF4C8E0
	public string get_Prefix() { }

	// RVA: 0xF4C8E8
	public void set_Prefix(string value) { }

	// RVA: 0xF4CA88
	internal DataColumn get_XmlText() { }

	// RVA: 0xF4CA90
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0xF4CB5C
	internal Decimal get_MaxOccurs() { }

	// RVA: 0xF4CB68
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0xF4CB70
	internal Decimal get_MinOccurs() { }

	// RVA: 0xF4CB7C
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0xF4CB84
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0xF4CC20
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0xF4CCB4
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0xF4CD40
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0xF4D170
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0xF4DCF4
	protected virtual DataTable CreateInstance() { }

	// RVA: 0xF4DD84
	public virtual DataTable Clone() { }

	// RVA: 0xF4DD8C
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0xF4DF9C
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0xF4E2D8
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0xF43B10
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0xF4E800
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xF4E8B8
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xF4E970
	public override ISite get_Site() { }

	// RVA: 0xF4E978
	public override void set_Site(ISite value) { }

	// RVA: 0xF4EB58
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0xF4EB68
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0xF4EB74
	internal void InsertRow(DataRow row, Int64 proposedID, int pos, bool fireEvent) { }

	// RVA: 0xF4F9B0
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0xF4F9E4
	public void Clear() { }

	// RVA: 0xF4F9EC
	internal void Clear(bool clearAll) { }

	// RVA: 0xF5042C
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0xF504FC
	internal void CommitRow(DataRow row) { }

	// RVA: 0xF507F0
	internal int Compare(string s1, string s2) { }

	// RVA: 0xF507F8
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0xF50994
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0xF50A1C
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0xF50AA4
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xF50AAC
	internal void DeleteRow(DataRow row) { }

	// RVA: 0xF50B4C
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0xF50C7C
	internal void FreeRecord(int record) { }

	// RVA: 0xF50C9C
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF510B8
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF512B0
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xF512B4
	internal System.Collections.Generic.List<System.Data.DataViewListener> GetListeners() { }

	// RVA: 0xF494C0
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0xF4D7F8
	internal void InsertRow(DataRow row, Int64 proposedID) { }

	// RVA: 0xF52404
	internal int NewRecord() { }

	// RVA: 0xF524F8
	internal int NewUninitializedRecord() { }

	// RVA: 0xF5240C
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0xF47638
	internal DataRow NewEmptyRow() { }

	// RVA: 0xF52518
	private DataRow NewUninitializedRow() { }

	// RVA: 0xF525E4
	public DataRow NewRow() { }

	// RVA: 0xF52760
	internal DataRow CreateEmptyRow() { }

	// RVA: 0xF526CC
	private void NewRowCreated(DataRow row) { }

	// RVA: 0xF52550
	internal DataRow NewRow(int record) { }

	// RVA: 0xF52B44
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0xF52BAC
	protected virtual Type GetRowType() { }

	// RVA: 0xF52C3C
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0xF52EEC
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0xF52FE4
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0xF530C8
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0xF531AC
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF53290
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0xF532A0
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0xF506B4
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xF50578
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xF532A4
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0xF53388
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0xF5346C
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0xF53550
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0xF53634
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0xF53718
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0xF537FC
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0xF4C7D4
	private void OnInitialized() { }

	// RVA: 0xF50CDC
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0xF4ABAC
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF538E0
	internal void RecordChanged(int record) { }

	// RVA: 0xF53AAC
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0xF514A4
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF51688
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0xF53D8C
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xF53F70
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xF541A0
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0xF54E74
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0xF55028
	public virtual void Reset() { }

	// RVA: 0xF43B08
	internal void ResetIndexes() { }

	// RVA: 0xF553B4
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0xF55614
	internal void RollbackRow(DataRow row) { }

	// RVA: 0xF520A8
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xF556C0
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xF512BC
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0xF4CE64
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged) { }

	// RVA: 0xF4EF54
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, Exception deferredException) { }

	// RVA: 0xF4CEC0
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0xF559DC
	private void RestoreShadowIndexes() { }

	// RVA: 0xF47F14
	private void SetShadowIndexes() { }

	// RVA: 0xF559FC
	internal void ShadowIndexCopy() { }

	// RVA: 0xF55AA0
	public override string ToString() { }

	// RVA: 0xF556A0
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0xF55B18
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0xF55DC0
	internal DataColumn AddUniqueKey() { }

	// RVA: 0xF55DC8
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0xF55E7C
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0xF55E90
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0xF44BD0
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0xF562A4
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0xF562B4
	public void Merge(DataTable table) { }

	// RVA: 0xF562C0
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF56548
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0xF56990
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xF44D24
	private bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF56E38
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0xF571FC
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0xF57254
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0xF57498
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xF59190
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xF59268
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xF5AA68
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xF58660
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xF5AB34
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF592E4
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF56A58
	private void CreateTableList(DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF5ADB8
	private void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList) { }

	// RVA: 0xF5B338
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xF5B584
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF5B594
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0xF5B75C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF5B918
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF5B950
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xF5B95C
	internal Hashtable get_RowDiffId() { }

	// RVA: 0xF5B9E8
	internal int get_ObjectID() { }

	// RVA: 0xF5B9F0
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF5BAE8
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF5BB88
	internal void EvaluateExpressions() { }

	// RVA: 0xF519CC
	internal void EvaluateExpressions(DataRow row, DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows) { }

	// RVA: 0xF5BEE4
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0xF50244
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0xF54328
	internal void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, DataRow row, DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows) { }

}

// Namespace: System.Data
internal sealed class FunctionNode
{
	// Fields
	internal readonly string _name; // 0x18
	internal readonly int _info; // 0x20
	internal int _argumentCount; // 0x24
	internal ExpressionNode[] _arguments; // 0x28
	private readonly TypeLimiter _capturedLimiter; // 0x30
	private static readonly Function[] s_funcs; // 0x0

	// Methods

	// RVA: 0xF806E4
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xF80854
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0xF80A54
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF80F54
	internal override object Eval() { }

	// RVA: 0xF80F68
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF83088
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF830C4
	internal override bool IsConstant() { }

	// RVA: 0xF83160
	internal override bool IsTableConstant() { }

	// RVA: 0xF831E4
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF83268
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF832EC
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF83388
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF818E8
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0xF81B60
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0xF8356C
	internal FunctionId get_Aggregate() { }

	// RVA: 0xF83614
	internal bool get_IsAggregate() { }

	// RVA: 0xF80D4C
	internal void Check() { }

	// RVA: 0xF838DC
	private static void .cctor() { }

}

// Namespace: System.Data
internal enum FunctionId
{
	// Fields
	public int value__; // 0x10
	public const FunctionId none = 4294967295;
	public const FunctionId Ascii = 0;
	public const FunctionId Char = 1;
	public const FunctionId Charindex = 2;
	public const FunctionId Difference = 3;
	public const FunctionId Len = 4;
	public const FunctionId Lower = 5;
	public const FunctionId LTrim = 6;
	public const FunctionId Patindex = 7;
	public const FunctionId Replicate = 8;
	public const FunctionId Reverse = 9;
	public const FunctionId Right = 10;
	public const FunctionId RTrim = 11;
	public const FunctionId Soundex = 12;
	public const FunctionId Space = 13;
	public const FunctionId Str = 14;
	public const FunctionId Stuff = 15;
	public const FunctionId Substring = 16;
	public const FunctionId Upper = 17;
	public const FunctionId IsNull = 18;
	public const FunctionId Iif = 19;
	public const FunctionId Convert = 20;
	public const FunctionId cInt = 21;
	public const FunctionId cBool = 22;
	public const FunctionId cDate = 23;
	public const FunctionId cDbl = 24;
	public const FunctionId cStr = 25;
	public const FunctionId Abs = 26;
	public const FunctionId Acos = 27;
	public const FunctionId In = 28;
	public const FunctionId Trim = 29;
	public const FunctionId Sum = 30;
	public const FunctionId Avg = 31;
	public const FunctionId Min = 32;
	public const FunctionId Max = 33;
	public const FunctionId Count = 34;
	public const FunctionId StDev = 35;
	public const FunctionId Var = 37;
	public const FunctionId DateTimeOffset = 38;
}

// Namespace: System.Data
internal sealed class Function
{
	// Fields
	internal readonly string _name; // 0x10
	internal readonly FunctionId _id; // 0x18
	internal readonly Type _result; // 0x20
	internal readonly bool _isValidateArguments; // 0x28
	internal readonly bool _isVariantArgumentList; // 0x29
	internal readonly int _argumentCount; // 0x2C
	internal readonly Type[] _parameters; // 0x30
	internal static string[] s_functionName; // 0x0

	// Methods

	// RVA: 0xF842C0
	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0xF8456C
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Data.TypeLimiter.Scope.<>c <>9; // 0x0
	public static System.Func<System.Type,System.Boolean> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xF86494
	private static void .cctor() { }

	// RVA: 0xF86500
	public void .ctor() { }

	// RVA: 0xF86508
	internal bool <.ctor>b__3_0(Type type) { }

}

// Namespace: 
private sealed class Scope
{
	// Fields
	private static readonly System.Collections.Generic.HashSet<System.Type> s_allowedTypes; // 0x0
	private System.Collections.Generic.HashSet<System.Type> m_allowedTypes; // 0x10
	private readonly Scope m_previousScope; // 0x18

	// Methods

	// RVA: 0xF854C0
	internal void .ctor(Scope previousScope, System.Collections.Generic.IEnumerable<System.Type> allowedTypes) { }

	// RVA: 0xF8598C
	public void Dispose() { }

	// RVA: 0xF84FBC
	public bool IsAllowedType(Type type) { }

	// RVA: 0xF85A6C
	private static bool IsTypeUnconditionallyAllowed(Type type) { }

	// RVA: 0xF85C58
	private static void .cctor() { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Data.TypeLimiter.<>c <>9; // 0x0
	public static System.Func<System.Data.DataColumn,System.Type> <>9__10_0; // 0x8
	public static System.Func<System.Data.DataTable,System.Collections.Generic.IEnumerable<System.Type>> <>9__11_0; // 0x10

	// Methods

	// RVA: 0xF86560
	private static void .cctor() { }

	// RVA: 0xF865CC
	public void .ctor() { }

	// RVA: 0xF865D4
	internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

	// RVA: 0xF865F0
	internal System.Collections.Generic.IEnumerable<System.Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }

}

// Namespace: System.Data
internal sealed class TypeLimiter
{
	// Fields
	private static Scope s_activeScope; // 0xFFFFFFFF
	private Scope m_instanceScope; // 0x10

	// Methods

	// RVA: 0xF84DB0
	private void .ctor(Scope scope) { }

	// RVA: 0xF84DE4
	private static bool get_IsTypeLimitingDisabled() { }

	// RVA: 0xF84E8C
	public static TypeLimiter Capture() { }

	// RVA: 0xF84F18
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0xF85178
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0xF85644
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0xF85798
	private static System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0xF852CC
	private static System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }

}

// Namespace: System.Data
public enum AcceptRejectRule
{
	// Fields
	public int value__; // 0x10
	public const AcceptRejectRule None = 0;
	public const AcceptRejectRule Cascade = 1;
}

// Namespace: System.Data
internal enum AggregateType
{
	// Fields
	public int value__; // 0x10
	public const AggregateType None = 0;
	public const AggregateType Sum = 4;
	public const AggregateType Mean = 5;
	public const AggregateType Min = 6;
	public const AggregateType Max = 7;
	public const AggregateType First = 8;
	public const AggregateType Count = 9;
	public const AggregateType Var = 10;
	public const AggregateType StDev = 11;
}

// Namespace: System.Data
public class InternalDataCollectionBase
{
	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x0

	// Methods

	// RVA: 0xF865F8
	public virtual int get_Count() { }

	// RVA: 0xF86628
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0xF86670
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xF866A0
	public bool get_IsSynchronized() { }

	// RVA: 0xF866A8
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0xF86778
	public object get_SyncRoot() { }

	// RVA: 0xF8677C
	protected virtual ArrayList get_List() { }

	// RVA: 0xF86784
	public void .ctor() { }

	// RVA: 0xF8678C
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class ColumnTypeConverter
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0xF8681C
	public void .ctor() { }

	// RVA: 0xF86824
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF868E4
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xF86DD8
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xF86E68
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0xF87064
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0xF871A8
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0xF871B0
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xF871B8
	private static void .cctor() { }

}

// Namespace: System.Data
internal class DataCommonEventSource
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static Int64 s_nextScopeId; // 0x8

	// Methods

	// RVA: 0xF87D94
	internal void Trace(string message) { }

	// RVA: 0x26AD93C
	internal void Trace(string format, T0 arg0) { }

	// RVA: 0x26AD93C
	internal void Trace(string format, T0 arg0, T1 arg1) { }

	// RVA: 0x26AD93C
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2) { }

	// RVA: 0x26AD93C
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x26AD93C
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x26AD93C
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	// RVA: 0xF87DA4
	internal Int64 EnterScope(string message) { }

	// RVA: 0x26AD93C
	internal Int64 EnterScope(string format, T1 arg1) { }

	// RVA: 0x26AD93C
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2) { }

	// RVA: 0x26AD93C
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x26AD93C
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0xF87E84
	internal void ExitScope(Int64 scopeId) { }

	// RVA: 0xF87E94
	public void .ctor() { }

	// RVA: 0xF87E9C
	private static void .cctor() { }

}

// Namespace: System.Data
public abstract class Constraint
{
	// Fields
	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	// Methods

	// RVA: 0xF87F18
	public virtual string get_ConstraintName() { }

	// RVA: 0xF87F20
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0xF883B4
	internal string get_SchemaName() { }

	// RVA: 0xF883FC
	internal void set_SchemaName(string value) { }

	// RVA: 0xF88444
	internal virtual bool get_InCollection() { }

	// RVA: 0xF8844C
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1
	public abstract DataTable get_Table() { }

	// RVA: 0xF884AC
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1
	internal abstract bool ContainsColumn(DataColumn column) { }

	// RVA: -1
	internal abstract bool CanEnableConstraint() { }

	// RVA: -1
	internal abstract Constraint Clone(DataSet destination) { }

	// RVA: -1
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup) { }

	// RVA: 0xF88538
	internal void CheckConstraint() { }

	// RVA: -1
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint) { }

	// RVA: -1
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException) { }

	// RVA: -1
	internal abstract void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: -1
	internal abstract void CheckState() { }

	// RVA: 0xF88598
	protected void CheckStateForProperty() { }

	// RVA: 0xF886E8
	protected virtual DataSet get__DataSet() { }

	// RVA: -1
	internal abstract bool IsConstraintViolated() { }

	// RVA: 0xF886F0
	public override string ToString() { }

	// RVA: 0xF886FC
	protected void .ctor() { }

}

// Namespace: System.Data
public sealed class ConstraintCollection
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private CollectionChangeEventHandler _onCollectionChanged; // 0x28
	private Constraint[] _delayLoadingConstraints; // 0x30
	private bool _fLoadForeignKeyConstraintsOnly; // 0x38

	// Methods

	// RVA: 0xF88754
	internal void .ctor(DataTable table) { }

	// RVA: 0xF88818
	protected override ArrayList get_List() { }

	// RVA: 0xF88820
	public Constraint get_Item(int index) { }

	// RVA: 0xF88928
	internal DataTable get_Table() { }

	// RVA: 0xF88930
	public Constraint get_Item(string name) { }

	// RVA: 0xF88BE0
	public void Add(Constraint constraint) { }

	// RVA: 0xF88BE8
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0xF896E0
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0xF89244
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0xF8953C
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0xF89170
	private bool AutoGenerated(Constraint constraint) { }

	// RVA: 0xF8967C
	private void ArrayAdd(Constraint constraint) { }

	// RVA: 0xF8978C
	private void ArrayRemove(Constraint constraint) { }

	// RVA: 0xF8950C
	internal string AssignName() { }

	// RVA: 0xF895B0
	private void BaseAdd(Constraint constraint) { }

	// RVA: 0xF898A0
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0xF89A70
	private void BaseRemove(Constraint constraint) { }

	// RVA: 0xF89D38
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0xF89D68
	public void Clear() { }

	// RVA: 0xF8A1A8
	public bool Contains(string name) { }

	// RVA: 0xF8A1C4
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF88FF8
	internal Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0xF89330
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0xF8A358
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0xF8A488
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF8A2C0
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0xF88A38
	internal int InternalIndexOf(string constraintName) { }

	// RVA: 0xF897CC
	private string MakeName(int index) { }

	// RVA: 0xF896BC
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF88128
	internal void RegisterName(string name) { }

	// RVA: 0xF8A700
	public void Remove(Constraint constraint) { }

	// RVA: 0xF88330
	internal void UnregisterName(string name) { }

	// RVA: 0xF8A888
	internal void FinishInitConstraints() { }

}

// Namespace: System.Data
internal sealed class ConstraintConverter
{
	// Methods

	// RVA: 0xF8B1BC
	public void .ctor() { }

	// RVA: 0xF8B1C4
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF8B284
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Data
internal class ConstraintEnumerator
{
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Methods

	// RVA: 0xF8BCF8
	public void .ctor(DataSet dataSet) { }

	// RVA: 0xF8BD64
	public bool GetNext() { }

	// RVA: 0xF8C0DC
	public Constraint GetConstraint() { }

	// RVA: 0xF8C0E4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF8C0EC
	protected Constraint get_CurrentObject() { }

}

// Namespace: System.Data
internal class ForeignKeyConstraintEnumerator
{
	// Methods

	// RVA: 0xF8C0F4
	public void .ctor(DataSet dataSet) { }

	// RVA: 0xF8C160
	protected override bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF8C1E4
	public ForeignKeyConstraint GetForeignKeyConstraint() { }

}

// Namespace: System.Data
internal sealed class ChildForeignKeyConstraintEnumerator
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF8C260
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF8C2E8
	protected override bool IsValidCandidate(Constraint constraint) { }

}

// Namespace: System.Data
internal sealed class ParentForeignKeyConstraintEnumerator
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF8C394
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF8C41C
	protected override bool IsValidCandidate(Constraint constraint) { }

}

// Namespace: System.Data
public class DataColumnChangeEventArgs
{
	// Fields
	private DataColumn _column; // 0x10
	private readonly DataRow <Row>k__BackingField; // 0x18
	private object <ProposedValue>k__BackingField; // 0x20

	// Methods

	// RVA: 0xF8C4CC
	internal void .ctor(DataRow row) { }

	// RVA: 0xF8C544
	public void .ctor(DataRow row, DataColumn column, object value) { }

	// RVA: 0xF8C5EC
	public object get_ProposedValue() { }

	// RVA: 0xF8C5F4
	public void set_ProposedValue(object value) { }

	// RVA: 0xF8C5FC
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

// Namespace: System.Data
public sealed class DataColumnChangeEventHandler
{
	// Methods

	// RVA: 0xF8C630
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF8C754
	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }

}

// Namespace: System.Data
public sealed class DataColumnCollection
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataColumn[] _delayedAddRangeColumns; // 0x28
	private readonly System.Collections.Generic.Dictionary<System.String,System.Data.DataColumn> _columnFromName; // 0x30
	private bool _fInClear; // 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
	private int _nColumnsImplementingIChangeTracking; // 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	private CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

	// Methods

	// RVA: 0xF8C768
	internal void .ctor(DataTable table) { }

	// RVA: 0xF8C90C
	protected override ArrayList get_List() { }

	// RVA: 0xF8C914
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0xF8C91C
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0xF8C924
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0xF8C92C
	public DataColumn get_Item(int index) { }

	// RVA: 0xF8AE2C
	public DataColumn get_Item(string name) { }

	// RVA: 0xF8CC0C
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0xF8CCCC
	public void Add(DataColumn column) { }

	// RVA: 0xF8CCD8
	internal void AddAt(int index, DataColumn column) { }

	// RVA: 0xF8D5A8
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF8D64C
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF8D6F0
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF8D794
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF8D444
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0xF8D3C4
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0xF8D890
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0xF8DB30
	internal string AssignName() { }

	// RVA: 0xF8D00C
	private void BaseAdd(DataColumn column) { }

	// RVA: 0xF8E0A8
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0xF8E294
	private void BaseRemove(DataColumn column) { }

	// RVA: 0xF8E3E4
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0xF8D838
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0xF8EE2C
	public void Clear() { }

	// RVA: 0xF8F140
	public bool Contains(string name) { }

	// RVA: 0xF8F1F4
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF8F298
	public int IndexOf(string columnName) { }

	// RVA: 0xF8CA74
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0xF8F3B8
	internal void FinishInitCollection() { }

	// RVA: 0xF8DBCC
	private string MakeName(int index) { }

	// RVA: 0xF8D4EC
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF8CFE8
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF8F498
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF8DCA0
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0xF8F4F4
	internal bool CanRegisterName(string name) { }

	// RVA: 0xF8F560
	public void Remove(DataColumn column) { }

	// RVA: 0xF8DF7C
	internal void UnregisterName(string name) { }

	// RVA: 0xF8ED4C
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0xF8D9D0
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

}

// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor
{
	// Fields
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF8F674
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0xF8F6B8
	public override AttributeCollection get_Attributes() { }

	// RVA: 0xF8F87C
	internal DataColumn get_Column() { }

	// RVA: 0xF8F884
	public override Type get_ComponentType() { }

	// RVA: 0xF8F914
	public override bool get_IsReadOnly() { }

	// RVA: 0xF8F934
	public override Type get_PropertyType() { }

	// RVA: 0xF8F954
	public override bool Equals(object other) { }

	// RVA: 0xF8F9DC
	public override int GetHashCode() { }

	// RVA: 0xF8FA00
	public override bool CanResetValue(object component) { }

	// RVA: 0xF8FBC0
	public override object GetValue(object component) { }

	// RVA: 0xF8FC54
	public override void ResetValue(object component) { }

	// RVA: 0xF8FDE4
	public override void SetValue(object component, object value) { }

	// RVA: 0xF8FEC8
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xF8FED0
	public override bool get_IsBrowsable() { }

}

// Namespace: 
internal struct ColumnError
{
	// Fields
	internal DataColumn _column; // 0x10
	internal string _error; // 0x18
}

// Namespace: System.Data
internal sealed class DataError
{
	// Fields
	private string _rowError; // 0x10
	private int _count; // 0x18
	private ColumnError[] _errorList; // 0x20

	// Methods

	// RVA: 0xF8FF28
	internal void .ctor() { }

	// RVA: 0xF8FF68
	internal void .ctor(string rowError) { }

	// RVA: 0xF90004
	internal string get_Text() { }

	// RVA: 0xF9000C
	internal void set_Text(string value) { }

	// RVA: 0xF90034
	internal bool get_HasErrors() { }

	// RVA: 0xF90070
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF90410
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0xF901A4
	internal void Clear(DataColumn column) { }

	// RVA: 0xF90478
	internal void Clear() { }

	// RVA: 0xF904F0
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0xF8FFDC
	private void SetText(string errorText) { }

	// RVA: 0xF902C0
	internal int IndexOf(DataColumn column) { }

}

// Namespace: System.Data
internal struct DataKey
{
	// Fields
	private readonly DataColumn[] _columns; // 0x10

	// Methods

	// RVA: 0xF90608
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0xF908D8
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF908E0
	internal bool get_HasValue() { }

	// RVA: 0xF8BCC4
	internal DataTable get_Table() { }

	// RVA: 0xF90834
	internal void CheckState() { }

	// RVA: 0xF908F0
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0xF909EC
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0xF8EC88
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF90AE8
	public override int GetHashCode() { }

	// RVA: 0xF90B58
	public override bool Equals(object value) { }

	// RVA: 0xF90C88
	internal bool Equals(DataKey value) { }

	// RVA: 0xF90D60
	internal string[] GetColumnNames() { }

	// RVA: 0xF90E38
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0xF90F50
	internal object[] GetKeyValues(int record) { }

	// RVA: 0xF91084
	internal Index GetSortIndex() { }

	// RVA: 0xF910DC
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0xF91138
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0xF911BC
	internal DataColumn[] ToArray() { }

}

// Namespace: System.Data
public class DataRelation
{
	// Fields
	private DataSet _dataSet; // 0x10
	internal PropertyCollection _extendedProperties; // 0x18
	internal string _relationName; // 0x20
	private DataKey _childKey; // 0x28
	private DataKey _parentKey; // 0x30
	private UniqueConstraint _parentKeyConstraint; // 0x38
	private ForeignKeyConstraint _childKeyConstraint; // 0x40
	internal string[] _parentColumnNames; // 0x48
	internal string[] _childColumnNames; // 0x50
	internal string _parentTableName; // 0x58
	internal string _childTableName; // 0x60
	internal string _parentTableNamespace; // 0x68
	internal string _childTableNamespace; // 0x70
	internal bool _nested; // 0x78
	internal bool _createConstraints; // 0x79
	private bool _checkMultipleNested; // 0x7A
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x7C
	private PropertyChangedEventHandler PropertyChanging; // 0x80

	// Methods

	// RVA: 0xF912B8
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0xF9182C
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF918E8
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF919B0
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF91ACC
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF91C20
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0xF91D88
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0xF8ED04
	internal DataKey get_ChildKey() { }

	// RVA: 0xF91DAC
	public virtual DataTable get_ChildTable() { }

	// RVA: 0xF91DF0
	public virtual DataSet get_DataSet() { }

	// RVA: 0xF91E14
	internal string[] get_ParentColumnNames() { }

	// RVA: 0xF91E1C
	internal string[] get_ChildColumnNames() { }

	// RVA: 0xF91E24
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0xF91EE0
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0xF92098
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF92220
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF92560
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xF92578
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0xF9259C
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0xF8ED28
	internal DataKey get_ParentKey() { }

	// RVA: 0xF925A4
	public virtual DataTable get_ParentTable() { }

	// RVA: 0xF925E8
	public virtual string get_RelationName() { }

	// RVA: 0xF9260C
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0xF92994
	internal void CheckNestedRelations() { }

	// RVA: 0xF92D54
	public virtual bool get_Nested() { }

	// RVA: 0xF92D78
	public virtual void set_Nested(bool value) { }

	// RVA: 0xF945BC
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0xF945E0
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0xF945E8
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0xF9460C
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF94698
	internal bool get_CheckMultipleNested() { }

	// RVA: 0xF946A0
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0xF946A8
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0xF946B0
	internal void CheckState() { }

	// RVA: 0xF91C44
	protected void CheckStateForProperty() { }

	// RVA: 0xF914F8
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF94980
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0xF9514C
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF9446C
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF95230
	public override string ToString() { }

	// RVA: 0xF93F9C
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0xF9523C
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0xF95404
	internal int get_ObjectID() { }

}

// Namespace: 
internal sealed class DataTableRelationCollection
{
	// Fields
	private readonly DataTable _table; // 0x38
	private readonly ArrayList _relations; // 0x40
	private readonly bool _fParentCollection; // 0x48
	private CollectionChangeEventHandler RelationPropertyChanged; // 0x50

	// Methods

	// RVA: 0xF96B7C
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0xF96CA8
	protected override ArrayList get_List() { }

	// RVA: 0xF96CB0
	private void EnsureDataSet() { }

	// RVA: 0xF96D00
	protected override DataSet GetDataSet() { }

	// RVA: 0xF96D4C
	public override DataRelation get_Item(int index) { }

	// RVA: 0xF96E58
	public override DataRelation get_Item(string name) { }

	// RVA: 0xF96F60
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF97004
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF970A8
	private void AddCache(DataRelation relation) { }

	// RVA: 0xF97100
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xF97200
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0xF972E4
	protected override void RemoveCore(DataRelation relation) { }

}

// Namespace: 
internal sealed class DataSetRelationCollection
{
	// Fields
	private readonly DataSet _dataSet; // 0x38
	private readonly ArrayList _relations; // 0x40
	private DataRelation[] _delayLoadingRelations; // 0x48

	// Methods

	// RVA: 0xF973B0
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0xF974D4
	protected override ArrayList get_List() { }

	// RVA: 0xF974DC
	public override void Clear() { }

	// RVA: 0xF97530
	protected override DataSet GetDataSet() { }

	// RVA: 0xF97538
	public override DataRelation get_Item(int index) { }

	// RVA: 0xF97644
	public override DataRelation get_Item(string name) { }

	// RVA: 0xF9774C
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xF97E68
	protected override void RemoveCore(DataRelation relation) { }

	// RVA: 0xF980F8
	internal void FinishInitRelations() { }

}

// Namespace: System.Data
public abstract class DataRelationCollection
{
	// Fields
	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

	// Methods

	// RVA: 0xF9540C
	internal int get_ObjectID() { }

	// RVA: -1
	public abstract DataRelation get_Item(int index) { }

	// RVA: -1
	public abstract DataRelation get_Item(string name) { }

	// RVA: 0xF95414
	public void Add(DataRelation relation) { }

	// RVA: 0xF956D0
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0xF9596C
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF95AA4
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF95BDC
	internal string AssignName() { }

	// RVA: 0xF95CE0
	public virtual void Clear() { }

	// RVA: 0xF95F48
	public virtual bool Contains(string name) { }

	// RVA: 0xF95F64
	internal int InternalIndexOf(string name) { }

	// RVA: -1
	protected abstract DataSet GetDataSet() { }

	// RVA: 0xF95C0C
	private string MakeName(int index) { }

	// RVA: 0xF9611C
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF96200
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF962E4
	internal void RegisterName(string name) { }

	// RVA: 0xF964F0
	public void Remove(DataRelation relation) { }

	// RVA: 0xF9670C
	public void RemoveAt(int index) { }

	// RVA: 0xF9678C
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0xF96974
	internal void UnregisterName(string name) { }

	// RVA: 0xF96AD0
	protected void .ctor() { }

}

// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor
{
	// Fields
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF985C4
	internal void .ctor(DataRelation dataRelation) { }

	// RVA: 0xF9861C
	internal DataRelation get_Relation() { }

	// RVA: 0xF98624
	public override Type get_ComponentType() { }

	// RVA: 0xF986B4
	public override bool get_IsReadOnly() { }

	// RVA: 0xF986BC
	public override Type get_PropertyType() { }

	// RVA: 0xF9874C
	public override bool Equals(object other) { }

	// RVA: 0xF987D4
	public override int GetHashCode() { }

	// RVA: 0xF987F8
	public override bool CanResetValue(object component) { }

	// RVA: 0xF98800
	public override object GetValue(object component) { }

	// RVA: 0xF988A0
	public override void ResetValue(object component) { }

	// RVA: 0xF988A4
	public override void SetValue(object component, object value) { }

	// RVA: 0xF988A8
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: System.Data
public class DataRow
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataColumnCollection _columns; // 0x18
	internal int _oldRecord; // 0x20
	internal int _newRecord; // 0x24
	internal int _tempRecord; // 0x28
	internal Int64 _rowID; // 0x30
	internal DataRowAction _action; // 0x38
	internal bool _inChangingEvent; // 0x3C
	internal bool _inDeletingEvent; // 0x3D
	internal bool _inCascade; // 0x3E
	private DataColumn _lastChangedColumn; // 0x40
	private int _countColumnChange; // 0x48
	private DataError _error; // 0x50
	private int _rbTreeNodeId; // 0x58
	private static int s_objectTypeCount; // 0x0
	internal readonly int _objectID; // 0x5C

	// Methods

	// RVA: 0xF988B0
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0xF98968
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0xF98984
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0xF98998
	internal bool get_HasPropertyChanged() { }

	// RVA: 0xF989A8
	internal int get_RBTreeNodeId() { }

	// RVA: 0xF989B0
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0xF98A8C
	public string get_RowError() { }

	// RVA: 0xF98AB4
	public void set_RowError(string value) { }

	// RVA: 0xF98CAC
	private void RowErrorChanged() { }

	// RVA: 0xF98D0C
	internal Int64 get_rowID() { }

	// RVA: 0xF98D14
	internal void set_rowID(Int64 value) { }

	// RVA: 0xF98D7C
	public DataRowState get_RowState() { }

	// RVA: 0xF9903C
	public DataTable get_Table() { }

	// RVA: 0xF944DC
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0xF99044
	internal int GetNestedParentCount() { }

	// RVA: 0xF99104
	public void set_Item(string columnName, object value) { }

	// RVA: 0xF98FB4
	public object get_Item(DataColumn column) { }

	// RVA: 0xF991F4
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0xF999C4
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0xF99B60
	public void set_ItemArray(object[] value) { }

	// RVA: 0xF9A004
	public void AcceptChanges() { }

	// RVA: 0xF9A3A8
	public void BeginEdit() { }

	// RVA: 0xF9971C
	private bool BeginEditInternal() { }

	// RVA: 0xF99848
	public void CancelEdit() { }

	// RVA: 0xF9961C
	private void CheckColumn(DataColumn column) { }

	// RVA: 0xF9A3AC
	internal void CheckInTable() { }

	// RVA: 0xF9A3F4
	public void Delete() { }

	// RVA: 0xF998BC
	public void EndEdit() { }

	// RVA: 0xF9A464
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0xF9A4D4
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF9A834
	public string GetColumnError(string columnName) { }

	// RVA: 0xF9A734
	public string GetColumnError(DataColumn column) { }

	// RVA: 0xF9A8A8
	public void ClearErrors() { }

	// RVA: 0xF8EC1C
	internal void ClearError(DataColumn column) { }

	// RVA: 0xF9A978
	public bool get_HasErrors() { }

	// RVA: 0xF9A9C8
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0xF9AAB8
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0xF9AAC0
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF99188
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0xF945B4
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0xF9ABF4
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF9AD1C
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0xF9ADD4
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0xF9ADDC
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF9AF10
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0xF9AFA8
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0xF9B000
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0xF92068
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0xF9B080
	internal int GetCurrentRecordNo() { }

	// RVA: 0xF996AC
	internal int GetDefaultRecord() { }

	// RVA: 0xF9B0C8
	internal int GetOriginalRecordNo() { }

	// RVA: 0xF99800
	private int GetProposedRecordNo() { }

	// RVA: 0xF99A14
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0xF9B110
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0xF9B13C
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0xF9B190
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0xF9B19C
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF924A4
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0xF9B368
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0xF9B3F8
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF9B498
	public void RejectChanges() { }

	// RVA: 0xF98D4C
	internal void ResetLastChangedColumn() { }

	// RVA: 0xF9BB14
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0xF9BCD0
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0xF9C11C
	internal void SetParentRowToDBNull() { }

	// RVA: 0xF9C3F4
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0xF9C57C
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

// Namespace: System.Data
public sealed class DataRowBuilder
{
	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xF9C958
	internal void .ctor(DataTable table, int record) { }

}

// Namespace: System.Data
public enum DataRowAction
{
	// Fields
	public int value__; // 0x10
	public const DataRowAction Nothing = 0;
	public const DataRowAction Delete = 1;
	public const DataRowAction Change = 2;
	public const DataRowAction Rollback = 4;
	public const DataRowAction Commit = 8;
	public const DataRowAction Add = 16;
	public const DataRowAction ChangeOriginal = 32;
	public const DataRowAction ChangeCurrentAndOriginal = 64;
}

// Namespace: System.Data
public class DataRowChangeEventArgs
{
	// Fields
	private readonly DataRow <Row>k__BackingField; // 0x10
	private readonly DataRowAction <Action>k__BackingField; // 0x18

	// Methods

	// RVA: 0xF9C9A0
	public void .ctor(DataRow row, DataRowAction action) { }

}

// Namespace: System.Data
public sealed class DataRowChangeEventHandler
{
	// Methods

	// RVA: 0xF9CA2C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF9CB50
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

}

// Namespace: 
private sealed class DataRowTree
{
	// Methods

	// RVA: 0xF9CC4C
	internal void .ctor() { }

	// RVA: 0xF9D384
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0xF9D3B8
	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

}

// Namespace: System.Data
public sealed class DataRowCollection
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Methods

	// RVA: 0xF9CB64
	internal void .ctor(DataTable table) { }

	// RVA: 0xF9CCA4
	public override int get_Count() { }

	// RVA: 0xF8EBA4
	public DataRow get_Item(int index) { }

	// RVA: 0xF9CCF8
	public void Add(DataRow row) { }

	// RVA: 0xF9CD1C
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0xF9CF60
	public int IndexOf(DataRow row) { }

	// RVA: 0xF9D008
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0xF9D074
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0xF9D0E8
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0xF9D164
	internal void ArrayClear() { }

	// RVA: 0xF9D1B8
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0xF9D258
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0xF9D2C4
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0xF9D330
	public override IEnumerator GetEnumerator() { }

}

// Namespace: System.Data
internal sealed class DataRowCreatedEventHandler
{
	// Methods

	// RVA: 0xF9D3EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF9D510
	public virtual void Invoke(object sender, DataRow r) { }

}

// Namespace: System.Data
internal sealed class DataSetClearEventhandler
{
	// Methods

	// RVA: 0xF9D524
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF9D648
	public virtual void Invoke(object sender, DataTable table) { }

}

// Namespace: System.Data
public enum DataRowState
{
	// Fields
	public int value__; // 0x10
	public const DataRowState Detached = 1;
	public const DataRowState Unchanged = 2;
	public const DataRowState Added = 4;
	public const DataRowState Deleted = 8;
	public const DataRowState Modified = 16;
}

// Namespace: System.Data
public enum DataRowVersion
{
	// Fields
	public int value__; // 0x10
	public const DataRowVersion Original = 256;
	public const DataRowVersion Current = 512;
	public const DataRowVersion Proposed = 1024;
	public const DataRowVersion Default = 1536;
}

// Namespace: System.Data
public class DataRowView
{
	// Fields
	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Methods

	// RVA: 0xF9D65C
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xF9D6AC
	public override bool Equals(object other) { }

	// RVA: 0xF9D6B8
	public override int GetHashCode() { }

	// RVA: 0xF9D6DC
	public DataView get_DataView() { }

	// RVA: 0xF9D6E4
	private string System.ComponentModel.IDataErrorInfo.get_Item(string colName) { }

	// RVA: 0xF9D700
	private string System.ComponentModel.IDataErrorInfo.get_Error() { }

	// RVA: 0xF9D744
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0xF9D7A0
	internal int GetRecord() { }

	// RVA: 0xF9D7F0
	internal bool HasRecord() { }

	// RVA: 0xF8FB38
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0xF8FD30
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0xF9D854
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0xF98898
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0xF9DA40
	public DataRow get_Row() { }

	// RVA: 0xF9DA48
	public void BeginEdit() { }

	// RVA: 0xF9DA54
	public void CancelEdit() { }

	// RVA: 0xF9DB30
	public void EndEdit() { }

	// RVA: 0xF9DB04
	public bool get_IsNew() { }

	// RVA: 0xF9DB94
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF9DC38
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF9DCDC
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0xF9DD70
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xF9DDCC
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xF9DDD4
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xF9DDDC
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xF9DDE4
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xF9DDEC
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xF9DDF4
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xF9DDFC
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xF9DE58
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xF9DEB4
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xF9DF5C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xF9E00C
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xF9E010
	private static void .cctor() { }

}

// Namespace: System.Data
public enum SerializationFormat
{
	// Fields
	public int value__; // 0x10
	public const SerializationFormat Xml = 0;
	public const SerializationFormat Binary = 1;
}

// Namespace: System.Data
public enum DataSetDateTime
{
	// Fields
	public int value__; // 0x10
	public const DataSetDateTime Local = 1;
	public const DataSetDateTime Unspecified = 2;
	public const DataSetDateTime UnspecifiedLocal = 3;
	public const DataSetDateTime Utc = 4;
}

// Namespace: System.Data
public sealed class DataTableClearEventArgs
{
	// Fields
	private readonly DataTable <Table>k__BackingField; // 0x10

	// Methods

	// RVA: 0xF9E09C
	public void .ctor(DataTable dataTable) { }

}

// Namespace: System.Data
public sealed class DataTableClearEventHandler
{
	// Methods

	// RVA: 0xF9E114
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF9E238
	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }

}

// Namespace: System.Data
public sealed class DataTableCollection
{
	// Fields
	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

	// Methods

	// RVA: 0xF9E24C
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0xF9E3FC
	protected override ArrayList get_List() { }

	// RVA: 0xF9E404
	internal int get_ObjectID() { }

	// RVA: 0xF9E40C
	public DataTable get_Item(int index) { }

	// RVA: 0xF8AF90
	public DataTable get_Item(string name) { }

	// RVA: 0xF8B0A0
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0xF9E960
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0xF9EA9C
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0xF9EBE0
	public void Add(DataTable table) { }

	// RVA: 0xF9F224
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF9F35C
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF9F118
	private void ArrayAdd(DataTable table) { }

	// RVA: 0xF9F494
	internal string AssignName() { }

	// RVA: 0xF9EF78
	private void BaseAdd(DataTable table) { }

	// RVA: 0xF9F878
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0xF9FA54
	private void BaseRemove(DataTable table) { }

	// RVA: 0xF9FAD0
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0xFA0168
	public void Clear() { }

	// RVA: 0xF9F5C8
	public bool Contains(string name) { }

	// RVA: 0xFA04B4
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0xFA06F8
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xFA0844
	public int IndexOf(DataTable table) { }

	// RVA: 0xFA0934
	public int IndexOf(string tableName) { }

	// RVA: 0xFA0950
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0xFA09BC
	internal void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF9E554
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0xF9E7A8
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0xFA0A10
	internal void FinishInitCollection() { }

	// RVA: 0xF9F4F4
	private string MakeName(int index) { }

	// RVA: 0xF9F140
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF9EE94
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF9F5E4
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0xFA0AA4
	public void Remove(DataTable table) { }

	// RVA: 0xFA002C
	internal void UnregisterName(string name) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventArgs
{
	// Fields
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0xFA0CA0
	public void .ctor(DataRow dataRow) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventHandler
{
	// Methods

	// RVA: 0xFA0D18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFA0E3C
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

}

// Namespace: System.Data
internal sealed class DataTablePropertyDescriptor
{
	// Fields
	private readonly DataTable <Table>k__BackingField; // 0x88

	// Methods

	// RVA: 0xFA0E50
	public DataTable get_Table() { }

	// RVA: 0xFA0E58
	internal void .ctor(DataTable dataTable) { }

	// RVA: 0xFA0E9C
	public override Type get_ComponentType() { }

	// RVA: 0xFA0F2C
	public override bool get_IsReadOnly() { }

	// RVA: 0xFA0F34
	public override Type get_PropertyType() { }

	// RVA: 0xFA0FC4
	public override bool Equals(object other) { }

	// RVA: 0xFA104C
	public override int GetHashCode() { }

	// RVA: 0xFA1070
	public override bool CanResetValue(object component) { }

	// RVA: 0xFA1078
	public override object GetValue(object component) { }

	// RVA: 0xFA11BC
	public override void ResetValue(object component) { }

	// RVA: 0xFA11C0
	public override void SetValue(object component, object value) { }

	// RVA: 0xFA11C4
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: System.Data
internal sealed class DataTableTypeConverter
{
	// Methods

	// RVA: 0xFA11CC
	public void .ctor() { }

	// RVA: 0xFA1274
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: 
private sealed class DataRowReferenceComparer
{
	// Fields
	internal static readonly DataRowReferenceComparer s_default; // 0x0

	// Methods

	// RVA: 0xFA7338
	private void .ctor() { }

	// RVA: 0xFA7340
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0xFA734C
	public int GetHashCode(DataRow obj) { }

	// RVA: 0xFA7368
	private static void .cctor() { }

}

// Namespace: System.Data
public class DataView
{
	// Fields
	private DataViewManager _dataViewManager; // 0x20
	private DataTable _table; // 0x28
	private bool _locked; // 0x30
	private Index _index; // 0x38
	private System.Collections.Generic.Dictionary<System.String,System.Data.Index> _findIndexes; // 0x40
	private string _sort; // 0x48
	private System.Comparison<System.Data.DataRow> _comparison; // 0x50
	private IFilter _rowFilter; // 0x58
	private DataViewRowState _recordStates; // 0x60
	private bool _shouldOpen; // 0x64
	private bool _open; // 0x65
	private bool _allowNew; // 0x66
	private bool _allowEdit; // 0x67
	private bool _allowDelete; // 0x68
	private bool _applyDefaultSort; // 0x69
	internal DataRow _addNewRow; // 0x70
	private ListChangedEventArgs _addNewMoved; // 0x78
	private ListChangedEventHandler _onListChanged; // 0x80
	internal static ListChangedEventArgs s_resetEventArgs; // 0x0
	private DataTable _delayedTable; // 0x88
	private string _delayedRowFilter; // 0x90
	private string _delayedSort; // 0x98
	private DataViewRowState _delayedRecordStates; // 0xA0
	private bool _fInitInProgress; // 0xA4
	private bool _fEndInitInProgress; // 0xA5
	private System.Collections.Generic.Dictionary<System.Data.DataRow,System.Data.DataRowView> _rowViewCache; // 0xA8
	private readonly System.Collections.Generic.Dictionary<System.Data.DataRow,System.Data.DataRowView> _rowViewBuffer; // 0xB0
	private DataViewListener _dvListener; // 0xB8
	private static int s_objectTypeCount; // 0x8
	private readonly int _objectID; // 0xC0
	private EventHandler Initialized; // 0xC8

	// Methods

	// RVA: 0xFA127C
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0xFA1868
	public void .ctor(DataTable table) { }

	// RVA: 0xFA1C7C
	public bool get_AllowDelete() { }

	// RVA: 0xFA1C84
	public bool get_AllowEdit() { }

	// RVA: 0xFA1C8C
	public bool get_AllowNew() { }

	// RVA: 0xFA1C94
	public int get_Count() { }

	// RVA: 0xFA1CE8
	private int get_CountFromIndex() { }

	// RVA: 0xFA1D04
	public DataViewManager get_DataViewManager() { }

	// RVA: 0xFA1D0C
	public bool get_IsInitialized() { }

	// RVA: 0xFA1D1C
	protected bool get_IsOpen() { }

	// RVA: 0xFA1D24
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFA1D2C
	public virtual string get_RowFilter() { }

	// RVA: 0xFA1E44
	public virtual void set_RowFilter(string value) { }

	// RVA: 0xFA205C
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0xFA2064
	public void set_RowStateFilter(DataViewRowState value) { }

	// RVA: 0xFA21CC
	public string get_Sort() { }

	// RVA: 0xFA2224
	public void set_Sort(string value) { }

	// RVA: 0xFA2498
	internal System.Comparison<System.Data.DataRow> get_SortComparison() { }

	// RVA: 0xFA24A0
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFA24A4
	public DataTable get_Table() { }

	// RVA: 0xFA24AC
	public void set_Table(DataTable value) { }

	// RVA: 0xFA2774
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0xFA286C
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0xFA27F0
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0xFA29F4
	public virtual DataRowView AddNew() { }

	// RVA: 0xFA2EA4
	public void BeginInit() { }

	// RVA: 0xFA2EB0
	public void EndInit() { }

	// RVA: 0xFA2D34
	private void CheckOpen() { }

	// RVA: 0xFA2438
	private void CheckSort(string sort) { }

	// RVA: 0xFA313C
	protected void Close() { }

	// RVA: 0xFA3194
	public void CopyTo(Array array, int index) { }

	// RVA: 0xFA3484
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0xFA375C
	public void Delete(int index) { }

	// RVA: 0xFA3784
	internal void Delete(DataRow row) { }

	// RVA: 0xFA3B94
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFA396C
	internal void FinishAddNew(bool success) { }

	// RVA: 0xFA3BF4
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFA3CB8
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xFA3CC0
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xFA3CC8
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xFA3D5C
	private void System.Collections.IList.Clear() { }

	// RVA: 0xFA3D8C
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xFA3E24
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xFA2D78
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0xFA3EC0
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0xFA3F1C
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xFA3F4C
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xFA4080
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xFA40A8
	internal Index GetFindIndex(string column, bool keepIndex) { }

	// RVA: 0xFA4264
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xFA426C
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xFA427C
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xFA4284
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xFA428C
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xFA4294
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xFA429C
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xFA42A4
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xFA4324
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xFA43C4
	internal PropertyDescriptor GetSortProperty() { }

	// RVA: 0xFA4464
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xFA44A4
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xFA45DC
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xFA4714
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xFA47B8
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xFA485C
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xFA48A0
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xFA49B0
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xFA4C4C
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xFA4C90
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xFA4D7C
	private void System.ComponentModel.IBindingListView.ApplySort(ListSortDescriptionCollection sorts) { }

	// RVA: 0xFA48C8
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xFA52A0
	private void System.ComponentModel.IBindingListView.RemoveFilter() { }

	// RVA: 0xFA5398
	private string System.ComponentModel.IBindingListView.get_Filter() { }

	// RVA: 0xFA53A8
	private void System.ComponentModel.IBindingListView.set_Filter(string value) { }

	// RVA: 0xFA53B8
	private ListSortDescriptionCollection System.ComponentModel.IBindingListView.get_SortDescriptions() { }

	// RVA: 0xFA53BC
	internal ListSortDescriptionCollection GetSortDescriptions() { }

	// RVA: 0xFA5660
	private bool System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting() { }

	// RVA: 0xFA5668
	private bool System.ComponentModel.IBindingListView.get_SupportsFiltering() { }

	// RVA: 0xFA5670
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xFA56E4
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xFA57B4
	internal virtual IFilter GetFilter() { }

	// RVA: 0xFA57BC
	private int GetRecord(int recordIndex) { }

	// RVA: 0xFA289C
	internal DataRow GetRow(int index) { }

	// RVA: 0xFA33F4
	private DataRowView GetRowView(int record) { }

	// RVA: 0xFA297C
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0xFA5888
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0xFA5924
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0xFA59F0
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xFA5FD8
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xFA30AC
	private void OnInitialized() { }

	// RVA: 0xFA63A0
	protected void Reset() { }

	// RVA: 0xFA5D14
	internal void ResetRowViewCache() { }

	// RVA: 0xFA63D0
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xFA6660
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0xFA18DC
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0xFA3180
	protected void UpdateIndex() { }

	// RVA: 0xFA6A24
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0xFA6668
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0xFA6C30
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xFA6E50
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xFA7070
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xFA7290
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xFA72A0
	internal int get_ObjectID() { }

	// RVA: 0xFA72A8
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class DataViewListener
{
	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0xFA15EC
	internal void .ctor(DataView dv) { }

	// RVA: 0xFA73D4
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xFA74B8
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xFA7578
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xFA7648
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xFA7724
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0xFA167C
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0xFA276C
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0xFA79E4
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0xFA6B3C
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0xFA6A2C
	internal void UnregisterListChangedEvent() { }

	// RVA: 0xFA7494
	private void CleanUp(bool updateListeners) { }

	// RVA: 0xFA77E4
	private void RegisterListener(DataTable table) { }

}

// Namespace: System.Data
public class DataViewManager
{
	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	private DataSet _dataSet; // 0x28
	private DataViewManagerListItemTypeDescriptor _item; // 0x30
	private bool _locked; // 0x38
	internal int _nViews; // 0x3C
	private static NotSupportedException s_notSupported; // 0x0
	private ListChangedEventHandler ListChanged; // 0x40

	// Methods

	// RVA: 0xFA7CA4
	internal void .ctor(DataSet dataSet, bool locked) { }

	// RVA: 0xFA7F9C
	public DataSet get_DataSet() { }

	// RVA: 0xFA7FA4
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0xFA7FAC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFA80A0
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0xFA80A8
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xFA80AC
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xFA80B4
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xFA80BC
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xFA80C4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xFA815C
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xFA8164
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xFA8194
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xFA81C4
	private void System.Collections.IList.Clear() { }

	// RVA: 0xFA81F4
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xFA8204
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xFA8218
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xFA8248
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xFA8278
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xFA82A8
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xFA82B0
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xFA82F8
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xFA8300
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xFA8308
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xFA8310
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xFA8318
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xFA8320
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xFA8368
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xFA83B0
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xFA83F8
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xFA849C
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xFA8540
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xFA8544
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xFA858C
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xFA85D4
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xFA85D8
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xFA8620
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xFA86C0
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xFA8858
	public DataView CreateDataView(DataTable table) { }

	// RVA: 0xFA8950
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xFA8A8C
	protected virtual void TableCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xFA8CDC
	protected virtual void RelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xFA8EFC
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class DataViewManagerListItemTypeDescriptor
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private PropertyDescriptorCollection _propsCollection; // 0x18

	// Methods

	// RVA: 0xFA7EA8
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xFA10F0
	internal DataView GetDataView(DataTable table) { }

	// RVA: 0xFA8F84
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xFA8FE0
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xFA8FE8
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xFA8FF0
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xFA8FF8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xFA9000
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xFA9008
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xFA9010
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xFA906C
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xFA90C8
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xFA9170
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xFA9380
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

}

// Namespace: System.Data
public enum DataViewRowState
{
	// Fields
	public int value__; // 0x10
	public const DataViewRowState None = 0;
	public const DataViewRowState Unchanged = 2;
	public const DataViewRowState Added = 4;
	public const DataViewRowState Deleted = 8;
	public const DataViewRowState ModifiedCurrent = 16;
	public const DataViewRowState ModifiedOriginal = 32;
	public const DataViewRowState OriginalRows = 42;
	public const DataViewRowState CurrentRows = 22;
}

// Namespace: System.Data
public class DataViewSetting
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

	// Methods

	// RVA: 0xFA9384
	internal void .ctor() { }

	// RVA: 0xFA93E4
	public bool get_ApplyDefaultSort() { }

	// RVA: 0xFA93EC
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xFA9404
	internal void SetDataTable(DataTable table) { }

	// RVA: 0xFA941C
	public string get_RowFilter() { }

	// RVA: 0xFA9424
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0xFA942C
	public string get_Sort() { }

}

// Namespace: 
private sealed class DataViewSettingsEnumerator
{
	// Fields
	private DataViewSettingCollection _dataViewSettings; // 0x10
	private IEnumerator _tableEnumerator; // 0x18

	// Methods

	// RVA: 0xFA98AC
	public void .ctor(DataViewManager dvm) { }

	// RVA: 0xFA9A34
	public bool MoveNext() { }

	// RVA: 0xFA9AE8
	public void Reset() { }

	// RVA: 0xFA9BA0
	public object get_Current() { }

}

// Namespace: System.Data
public class DataViewSettingCollection
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Methods

	// RVA: 0xFA7EDC
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xFA9434
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0xFA9598
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0xFA9654
	public void CopyTo(Array ar, int index) { }

	// RVA: 0xFA986C
	public virtual int get_Count() { }

	// RVA: 0xFA9804
	public IEnumerator GetEnumerator() { }

	// RVA: 0xFA9A00
	public bool get_IsSynchronized() { }

	// RVA: 0xFA9A08
	public object get_SyncRoot() { }

	// RVA: 0xFA9A0C
	internal void Remove(DataTable table) { }

}

// Namespace: System.Data
internal sealed class DefaultValueTypeConverter
{
	// Methods

	// RVA: 0xFA9CC0
	public void .ctor() { }

	// RVA: 0xFA9CC8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xFA9EA0
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

}

// Namespace: System.Data
internal enum Aggregate
{
	// Fields
	public int value__; // 0x10
	public const Aggregate None = 4294967295;
	public const Aggregate Sum = 30;
	public const Aggregate Avg = 31;
	public const Aggregate Min = 32;
	public const Aggregate Max = 33;
	public const Aggregate Count = 34;
	public const Aggregate StDev = 35;
	public const Aggregate Var = 37;
}

// Namespace: System.Data
internal sealed class AggregateNode
{
	// Fields
	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48

	// Methods

	// RVA: 0xFAA01C
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0xFAA028
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0xFAA168
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xFAA404
	internal static void Bind(DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xFAA584
	internal override object Eval() { }

	// RVA: 0xFAA598
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xFAA854
	internal override object Eval(int[] records) { }

	// RVA: 0xFAA8DC
	internal override bool IsConstant() { }

	// RVA: 0xFAA8E4
	internal override bool IsTableConstant() { }

	// RVA: 0xFAA8EC
	internal override bool HasLocalAggregate() { }

	// RVA: 0xFAA8F4
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xFAA904
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xFAA998
	internal override ExpressionNode Optimize() { }

}

// Namespace: 
private enum DataTypePrecedence
{
	// Fields
	public int value__; // 0x10
	public const DataTypePrecedence SqlDateTime = 25;
	public const DataTypePrecedence DateTimeOffset = 24;
	public const DataTypePrecedence DateTime = 23;
	public const DataTypePrecedence TimeSpan = 20;
	public const DataTypePrecedence SqlDouble = 19;
	public const DataTypePrecedence Double = 18;
	public const DataTypePrecedence SqlSingle = 17;
	public const DataTypePrecedence Single = 16;
	public const DataTypePrecedence SqlDecimal = 15;
	public const DataTypePrecedence Decimal = 14;
	public const DataTypePrecedence SqlMoney = 13;
	public const DataTypePrecedence UInt64 = 12;
	public const DataTypePrecedence SqlInt64 = 11;
	public const DataTypePrecedence Int64 = 10;
	public const DataTypePrecedence UInt32 = 9;
	public const DataTypePrecedence SqlInt32 = 8;
	public const DataTypePrecedence Int32 = 7;
	public const DataTypePrecedence UInt16 = 6;
	public const DataTypePrecedence SqlInt16 = 5;
	public const DataTypePrecedence Int16 = 4;
	public const DataTypePrecedence Byte = 3;
	public const DataTypePrecedence SqlByte = 2;
	public const DataTypePrecedence SByte = 1;
	public const DataTypePrecedence Error = 0;
	public const DataTypePrecedence SqlBoolean = 4294967295;
	public const DataTypePrecedence Boolean = 4294967294;
	public const DataTypePrecedence SqlGuid = 4294967293;
	public const DataTypePrecedence SqlString = 4294967292;
	public const DataTypePrecedence String = 4294967291;
	public const DataTypePrecedence SqlXml = 4294967290;
	public const DataTypePrecedence SqlChars = 4294967289;
	public const DataTypePrecedence Char = 4294967288;
	public const DataTypePrecedence SqlBytes = 4294967287;
	public const DataTypePrecedence SqlBinary = 4294967286;
}

// Namespace: System.Data
internal class BinaryNode
{
	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0xFAA99C
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xFAAA10
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xFAAA84
	internal override object Eval() { }

	// RVA: 0xFAAA98
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xFB062C
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xFB0644
	internal override bool IsConstant() { }

	// RVA: 0xFB0698
	internal override bool IsTableConstant() { }

	// RVA: 0xFB06EC
	internal override bool HasLocalAggregate() { }

	// RVA: 0xFB0744
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xFB079C
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xFB0804
	internal override ExpressionNode Optimize() { }

	// RVA: 0xFB0DB8
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0xFB0DF4
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xFB0E30
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0xFB0E38
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0xFAAAB0
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xFB3458
	private DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0xFB347C
	private static StorageType GetPrecedenceType(DataTypePrecedence code) { }

	// RVA: 0xFB34A0
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0xFB355C
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0xFB2F70
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xFB2650
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xFB3630
	private int SqlResultType(int typeCode) { }

}

// Namespace: System.Data
internal sealed class LikeNode
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0xFB3680
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xFB36F4
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xFB3C58
	internal string AnalyzePattern(string pat) { }

}

// Namespace: System.Data
internal sealed class ConstNode
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0xFB41B8
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0xFB0AA4
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0xFB4B40
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xFB4B48
	internal override object Eval() { }

	// RVA: 0xFB4B50
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xFB4B5C
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xFB4B68
	internal override bool IsConstant() { }

	// RVA: 0xFB4B70
	internal override bool IsTableConstant() { }

	// RVA: 0xFB4B78
	internal override bool HasLocalAggregate() { }

	// RVA: 0xFB4B80
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xFB4B88
	internal override ExpressionNode Optimize() { }

	// RVA: 0xFB46D0
	private object SmallestDecimal(object constant) { }

	// RVA: 0xFB41C0
	private object SmallestNumeric(object constant) { }

}

// Namespace: System.Data
internal sealed class DataExpression
{
	// Fields
	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

	// Methods

	// RVA: 0xFA2054
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0xFB4B8C
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0xFA1DE8
	internal string get_Expression() { }

	// RVA: 0xFB5FBC
	internal bool get_HasValue() { }

	// RVA: 0xFB5E74
	internal void Bind(DataTable table) { }

	// RVA: 0xFAA97C
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0xFB5FCC
	internal object Evaluate() { }

	// RVA: 0xFB5FD8
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0xFB625C
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xFB634C
	internal DataColumn[] GetDependency() { }

	// RVA: 0xFB6354
	internal bool IsTableAggregate() { }

	// RVA: 0xFB636C
	internal static bool IsUnknown(object value) { }

	// RVA: 0xFB63F4
	internal bool HasLocalAggregate() { }

	// RVA: 0xFB640C
	internal bool HasRemoteAggregate() { }

	// RVA: 0xFB2330
	internal static bool ToBoolean(object value) { }

}

// Namespace: System.Data
internal abstract class ExpressionNode
{
	// Fields
	private DataTable _table; // 0x10

	// Methods

	// RVA: 0xFAA134
	protected void .ctor(DataTable table) { }

	// RVA: 0xFB22B0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xFB6424
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0xFB642C
	protected DataTable get_table() { }

	// RVA: 0xFB6434
	protected void BindTable(DataTable table) { }

	// RVA: -1
	internal abstract void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: -1
	internal abstract object Eval() { }

	// RVA: -1
	internal abstract object Eval(DataRow row, DataRowVersion version) { }

	// RVA: -1
	internal abstract object Eval(int[] recordNos) { }

	// RVA: -1
	internal abstract bool IsConstant() { }

	// RVA: -1
	internal abstract bool IsTableConstant() { }

	// RVA: -1
	internal abstract bool HasLocalAggregate() { }

	// RVA: -1
	internal abstract bool HasRemoteAggregate() { }

	// RVA: -1
	internal abstract ExpressionNode Optimize() { }

	// RVA: 0xFB643C
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0xFB3620
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0xFB3438
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0xFB351C
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0xFB35D4
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0xFB354C
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0xFB35F0
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0xFB3610
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0xFB3660
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0xFB6444
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0xFB6454
	internal static bool IsFloatSql(StorageType type) { }

}

// Namespace: System.Data
internal enum ValueType
{
	// Fields
	public int value__; // 0x10
	public const ValueType Unknown = 4294967295;
	public const ValueType Null = 0;
	public const ValueType Bool = 1;
	public const ValueType Numeric = 2;
	public const ValueType Str = 3;
	public const ValueType Float = 4;
	public const ValueType Decimal = 5;
	public const ValueType Object = 6;
	public const ValueType Date = 7;
}

// Namespace: System.Data
internal enum Nodes
{
	// Fields
	public int value__; // 0x10
	public const Nodes Noop = 0;
	public const Nodes Unop = 1;
	public const Nodes UnopSpec = 2;
	public const Nodes Binop = 3;
	public const Nodes BinopSpec = 4;
	public const Nodes Zop = 5;
	public const Nodes Call = 6;
	public const Nodes Const = 7;
	public const Nodes Name = 8;
	public const Nodes Paren = 9;
	public const Nodes Conv = 10;
}

// Namespace: 
private struct ReservedWords
{
	// Fields
	internal readonly string _word; // 0x10
	internal readonly Tokens _token; // 0x18
	internal readonly int _op; // 0x1C

	// Methods

	// RVA: 0xFB8144
	internal void .ctor(string word, Tokens token, int op) { }

}

// Namespace: System.Data
internal sealed class ExpressionParser
{
	// Fields
	private static readonly ReservedWords[] s_reservedwords; // 0x0
	private Char _escape; // 0x10
	private Char _decimalSeparator; // 0x12
	private Char _listSeparator; // 0x14
	private Char _exponentL; // 0x16
	private Char _exponentU; // 0x18
	internal Char[] _text; // 0x20
	internal int _pos; // 0x28
	internal int _start; // 0x2C
	internal Tokens _token; // 0x30
	internal int _op; // 0x34
	internal OperatorInfo[] _ops; // 0x38
	internal int _topOperator; // 0x40
	internal int _topNode; // 0x44
	private readonly DataTable _table; // 0x48
	internal ExpressionNode[] _nodeStack; // 0x50
	internal int _prevOperand; // 0x58
	internal ExpressionNode _expression; // 0x60

	// Methods

	// RVA: 0xFB4DAC
	internal void .ctor(DataTable table) { }

	// RVA: 0xFB4E7C
	internal void LoadExpression(string data) { }

	// RVA: 0xFB6470
	internal void StartScan() { }

	// RVA: 0xFB4F84
	internal ExpressionNode Parse() { }

	// RVA: 0xFB7050
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0xFB7010
	private ExpressionNode NodePop() { }

	// RVA: 0xFB6FC4
	private ExpressionNode NodePeek() { }

	// RVA: 0xFB6F1C
	private void NodePush(ExpressionNode node) { }

	// RVA: 0xFB6BBC
	private void BuildExpression(int pri) { }

	// RVA: 0xFB6EC8
	internal void CheckToken(Tokens token) { }

	// RVA: 0xFB6510
	internal Tokens Scan() { }

	// RVA: 0xFB7840
	private void ScanNumeric() { }

	// RVA: 0xFB7C24
	private void ScanName() { }

	// RVA: 0xFB76B4
	private void ScanName(Char chEnd, Char esc, string charsToEscape) { }

	// RVA: 0xFB750C
	private void ScanDate() { }

	// RVA: 0xFB7980
	private void ScanBinaryConstant() { }

	// RVA: 0xFB7994
	private void ScanReserved() { }

	// RVA: 0xFB75CC
	private void ScanString(Char escape) { }

	// RVA: 0xFB6E6C
	internal void ScanToken(Tokens token) { }

	// RVA: 0xFB74A0
	private void ScanWhite() { }

	// RVA: 0xFB7CB0
	private bool IsWhiteSpace(Char ch) { }

	// RVA: 0xFB7BD8
	private bool IsAlphaNumeric(Char ch) { }

	// RVA: 0xFB7984
	private bool IsDigit(Char ch) { }

	// RVA: 0xFB7C90
	private bool IsAlpha(Char ch) { }

	// RVA: 0xFB7CC0
	private static void .cctor() { }

}

// Namespace: System.Data
internal enum Tokens
{
	// Fields
	public int value__; // 0x10
	public const Tokens None = 0;
	public const Tokens Name = 1;
	public const Tokens Numeric = 2;
	public const Tokens Decimal = 3;
	public const Tokens Float = 4;
	public const Tokens BinaryConst = 5;
	public const Tokens StringConst = 6;
	public const Tokens Date = 7;
	public const Tokens ListSeparator = 8;
	public const Tokens LeftParen = 9;
	public const Tokens RightParen = 10;
	public const Tokens ZeroOp = 11;
	public const Tokens UnaryOp = 12;
	public const Tokens BinaryOp = 13;
	public const Tokens Child = 14;
	public const Tokens Parent = 15;
	public const Tokens Dot = 16;
	public const Tokens Unknown = 17;
	public const Tokens EOS = 18;
}

// Namespace: System.Data
internal sealed class OperatorInfo
{
	// Fields
	internal Nodes _type; // 0x10
	internal int _op; // 0x14
	internal int _priority; // 0x18

	// Methods

	// RVA: 0xFB817C
	internal void .ctor(Nodes type, int op, int pri) { }

}

// Namespace: System.Data
[Serializable]
public class InvalidExpressionException
{
	// Methods

	// RVA: 0xFB81BC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFB81C4
	public void .ctor() { }

	// RVA: 0xFB81CC
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class EvaluateException
{
	// Methods

	// RVA: 0xFB81D4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFB81DC
	public void .ctor() { }

	// RVA: 0xFB81E4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class SyntaxErrorException
{
	// Methods

	// RVA: 0xFB81EC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFB81F4
	public void .ctor() { }

	// RVA: 0xFB81FC
	public void .ctor(string s) { }

}

// Namespace: System.Data
internal sealed class ExprException
{
	// Methods

	// RVA: 0xFB8204
	private static OverflowException _Overflow(string error) { }

	// RVA: 0xFB8278
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0xFB82EC
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0xFB8360
	private static EvaluateException _Eval(string error) { }

	// RVA: 0xFB83D4
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0xFB8448
	public static Exception InvokeArgument() { }

	// RVA: 0xFB8490
	public static Exception NYI(string moreinfo) { }

	// RVA: 0xFB8540
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0xFB871C
	public static Exception MissingOperator(string token) { }

	// RVA: 0xFB87CC
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0xFB887C
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0xFB88E8
	public static Exception ExpressionTooComplex() { }

	// RVA: 0xFB8984
	public static Exception UnboundName(string name) { }

	// RVA: 0xFB8A34
	public static Exception InvalidString(string str) { }

	// RVA: 0xFB8AE4
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0xFB8B94
	public static Exception SyntaxError() { }

	// RVA: 0xFB8C30
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0xFB8CE0
	public static Exception MissingRightParen() { }

	// RVA: 0xFB8D7C
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0xFB8E78
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0xFB8FD4
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0xFB90BC
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0xFB91A4
	public static Exception InvalidName(string name) { }

	// RVA: 0xFB9254
	public static Exception InvalidDate(string date) { }

	// RVA: 0xFB9304
	public static Exception NonConstantArgument() { }

	// RVA: 0xFB93A0
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0xFB9450
	public static Exception InWithoutParentheses() { }

	// RVA: 0xFB94EC
	public static Exception InWithoutList() { }

	// RVA: 0xFB9588
	public static Exception InvalidIsSyntax() { }

	// RVA: 0xFB9624
	public static Exception Overflow(Type type) { }

	// RVA: 0xFB96EC
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0xFB980C
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0xFB9908
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0xFB9A4C
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0xFB9B90
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0xFB9C6C
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0xFB9D1C
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0xFB9DCC
	public static Exception TooManyRightParentheses() { }

	// RVA: 0xFB9E68
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0xFB9F20
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0xFB9FD0
	public static Exception AggregateArgument() { }

	// RVA: 0xFBA06C
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0xFBA11C
	public static Exception EvalNoContext() { }

	// RVA: 0xFBA1B8
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0xFBA268
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0xFBA318
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0xFBA3C8
	public static Exception LookupArgument() { }

	// RVA: 0xFBA464
	public static Exception InvalidType(string typeName) { }

	// RVA: 0xFBA514
	public static Exception InvalidHoursArgument() { }

	// RVA: 0xFBA5B0
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0xFBA64C
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0xFBA6E8
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0xFBA784
	public static Exception UnsupportedDataType(Type type) { }

}

// Namespace: System.Data
internal interface IFilter
{
	// Methods

	// RVA: -1
	public abstract bool Invoke(DataRow row, DataRowVersion version) { }

}

// Namespace: System.Data
internal sealed class LookupNode
{
	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0xFBA7F8
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0xFBA848
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xFBAACC
	internal override object Eval() { }

	// RVA: 0xFBAAF8
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xFBAC18
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xFBAC50
	internal override bool IsConstant() { }

	// RVA: 0xFBAC58
	internal override bool IsTableConstant() { }

	// RVA: 0xFBAC60
	internal override bool HasLocalAggregate() { }

	// RVA: 0xFBAC68
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xFBAC70
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xFBAC80
	internal override ExpressionNode Optimize() { }

}

// Namespace: System.Data
internal sealed class NameNode
{
	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Methods

	// RVA: 0xFBAC84
	internal void .ctor(DataTable table, Char[] text, int start, int pos) { }

	// RVA: 0xFBAF1C
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xFBAF50
	internal override bool get_IsSqlColumn() { }

	// RVA: 0xFBAF70
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xFBB1A0
	internal override object Eval() { }

	// RVA: 0xFBB1CC
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xFBB274
	internal override object Eval(int[] records) { }

	// RVA: 0xFBB2AC
	internal override bool IsConstant() { }

	// RVA: 0xFBB2B4
	internal override bool IsTableConstant() { }

	// RVA: 0xFBB30C
	internal override bool HasLocalAggregate() { }

	// RVA: 0xFBB364
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xFBB3BC
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xFBB424
	internal override ExpressionNode Optimize() { }

	// RVA: 0xFBACD8
	internal static string ParseName(Char[] text, int start, int pos) { }

}

// Namespace: System.Data
internal sealed class Operators
{
	// Fields
	private static readonly int[] s_priority; // 0x0
	private static readonly string[] s_looks; // 0x8

	// Methods

	// RVA: 0xFBB428
	internal static bool IsArithmetical(int op) { }

	// RVA: 0xFBB444
	internal static bool IsLogical(int op) { }

	// RVA: 0xFBB464
	internal static bool IsRelational(int op) { }

	// RVA: 0xFBB474
	internal static int Priority(int op) { }

	// RVA: 0xFB8628
	internal static string ToString(int op) { }

	// RVA: 0xFBB554
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class UnaryNode
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0xFBBDF4
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0xFBBE38
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xFBBE8C
	internal override object Eval() { }

	// RVA: 0xFBBEA0
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xFBC57C
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xFBBEE4
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0xFBC5A0
	internal override bool IsConstant() { }

	// RVA: 0xFBC5C4
	internal override bool IsTableConstant() { }

	// RVA: 0xFBC5E8
	internal override bool HasLocalAggregate() { }

	// RVA: 0xFBC60C
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xFBC630
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xFBC658
	internal override ExpressionNode Optimize() { }

}

// Namespace: System.Data
internal sealed class ZeroOpNode
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0xFBC728
	internal void .ctor(int op) { }

	// RVA: 0xFBC758
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xFBC75C
	internal override object Eval() { }

	// RVA: 0xFBC84C
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xFBC858
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xFBC864
	internal override bool IsConstant() { }

	// RVA: 0xFBC86C
	internal override bool IsTableConstant() { }

	// RVA: 0xFBC874
	internal override bool HasLocalAggregate() { }

	// RVA: 0xFBC87C
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xFBC884
	internal override ExpressionNode Optimize() { }

}

// Namespace: System.Data
public class ForeignKeyConstraint
{
	// Fields
	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50
	internal string _constraintName; // 0x58
	internal string[] _parentColumnNames; // 0x60
	internal string[] _childColumnNames; // 0x68
	internal string _parentTableName; // 0x70
	internal string _parentTableNamespace; // 0x78

	// Methods

	// RVA: 0xFBC888
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xFBC8D4
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xFBCAB8
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0xFBCB64
	internal DataKey get_ChildKey() { }

	// RVA: 0xFBCB8C
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0xFBCBB8
	public override DataTable get_Table() { }

	// RVA: 0xFBCBE4
	internal string[] get_ParentColumnNames() { }

	// RVA: 0xFBCBF0
	internal string[] get_ChildColumnNames() { }

	// RVA: 0xFBCBFC
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xFBCD24
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xFBCD2C
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0xFBCDE8
	internal override bool IsConstraintViolated() { }

	// RVA: 0xFBD550
	internal override bool CanEnableConstraint() { }

	// RVA: 0xFBD7E8
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0xFBD9C4
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0xFBE044
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0xFBE2A4
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0xFBE7E0
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0xFBE8C4
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0xFBE9A0
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0xFBEAD0
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0xFBEE00
	private void NonVirtualCheckState() { }

	// RVA: 0xFBF054
	internal override void CheckState() { }

	// RVA: 0xFBF058
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0xFBF080
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0xFBF0E0
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xFBF12C
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xFBF13C
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xFBF92C
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0xFBC924
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xFBFFA4
	public virtual Rule get_DeleteRule() { }

	// RVA: 0xFBFFCC
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0xFC002C
	public override bool Equals(object key) { }

	// RVA: 0xFC0148
	public override int GetHashCode() { }

	// RVA: 0xFC0150
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0xFBF904
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0xFBE978
	internal DataKey get_ParentKey() { }

	// RVA: 0xFC017C
	internal DataRelation FindParentRelation() { }

	// RVA: 0xFC0254
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0xFC0280
	public virtual Rule get_UpdateRule() { }

	// RVA: 0xFC02A8
	public virtual void set_UpdateRule(Rule value) { }

}

// Namespace: System.Data
public enum MappingType
{
	// Fields
	public int value__; // 0x10
	public const MappingType Element = 1;
	public const MappingType Attribute = 2;
	public const MappingType SimpleContent = 3;
	public const MappingType Hidden = 4;
}

// Namespace: System.Data
public class MergeFailedEventArgs
{
	// Fields
	private readonly DataTable <Table>k__BackingField; // 0x10
	private readonly string <Conflict>k__BackingField; // 0x18

	// Methods

	// RVA: 0xFC0308
	public void .ctor(DataTable table, string conflict) { }

	// RVA: 0xFC039C
	public string get_Conflict() { }

}

// Namespace: System.Data
public sealed class MergeFailedEventHandler
{
	// Methods

	// RVA: 0xFC03A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xFC04C8
	public virtual void Invoke(object sender, MergeFailedEventArgs e) { }

}

// Namespace: System.Data
internal sealed class Merger
{
	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0xFC04DC
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xFC0534
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xFC0594
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0xFC2288
	internal void MergeTable(DataTable src) { }

	// RVA: 0xFC2508
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0xFC2B5C
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0xFC155C
	private void MergeTableData(DataTable src) { }

	// RVA: 0xFC1614
	private void MergeConstraints(DataSet source) { }

	// RVA: 0xFC3294
	private void MergeConstraints(DataTable table) { }

	// RVA: 0xFC1690
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0xFC2000
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0xFC29E8
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }

}

// Namespace: System.Data
public enum MissingSchemaAction
{
	// Fields
	public int value__; // 0x10
	public const MissingSchemaAction Add = 1;
	public const MissingSchemaAction Ignore = 2;
	public const MissingSchemaAction Error = 3;
	public const MissingSchemaAction AddWithKey = 4;
}

// Namespace: System.Data
internal sealed class PrimaryKeyTypeConverter
{
	// Methods

	// RVA: 0xFC354C
	public void .ctor() { }

	// RVA: 0xFC35F4
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xFC35FC
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xFC368C
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Data
[Serializable]
public class PropertyCollection
{
	// Methods

	// RVA: 0xFC38AC
	public void .ctor() { }

	// RVA: 0xFC38B4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC38BC
	public override object Clone() { }

}

// Namespace: System.Data
internal struct Range
{
	// Fields
	private int _min; // 0x10
	private int _max; // 0x14
	private bool _isNotNull; // 0x18

	// Methods

	// RVA: 0xFC3BBC
	public void .ctor(int min, int max) { }

	// RVA: 0xFBDF34
	public int get_Count() { }

	// RVA: 0xFBD9B4
	public bool get_IsNull() { }

	// RVA: 0xFBDF54
	public int get_Min() { }

	// RVA: 0xFC3C14
	internal void CheckNull() { }

}

// Namespace: System.Data
internal enum RBTreeError
{
	// Fields
	public int value__; // 0x10
	public const RBTreeError InvalidPageSize = 1;
	public const RBTreeError PagePositionInSlotInUse = 3;
	public const RBTreeError NoFreeSlots = 4;
	public const RBTreeError InvalidStateinInsert = 5;
	public const RBTreeError InvalidNextSizeInDelete = 7;
	public const RBTreeError InvalidStateinDelete = 8;
	public const RBTreeError InvalidNodeSizeinDelete = 9;
	public const RBTreeError InvalidStateinEndDelete = 10;
	public const RBTreeError CannotRotateInvalidsuccessorNodeinDelete = 11;
	public const RBTreeError IndexOutOFRangeinGetNodeByIndex = 13;
	public const RBTreeError RBDeleteFixup = 14;
	public const RBTreeError UnsupportedAccessMethod1 = 15;
	public const RBTreeError UnsupportedAccessMethod2 = 16;
	public const RBTreeError UnsupportedAccessMethodInNonNillRootSubtree = 17;
	public const RBTreeError AttachedNodeWithZerorbTreeNodeId = 18;
	public const RBTreeError CompareNodeInDataRowTree = 19;
	public const RBTreeError CompareSateliteTreeNodeInDataRowTree = 20;
	public const RBTreeError NestedSatelliteTreeEnumerator = 21;
}

// Namespace: System.Data
internal enum TreeAccessMethod
{
	// Fields
	public int value__; // 0x10
	public const TreeAccessMethod KEY_SEARCH_AND_INDEX = 1;
	public const TreeAccessMethod INDEX_ONLY = 2;
}

// Namespace: 
private enum NodeColor
{
	// Fields
	public int value__; // 0x0
	public const NodeColor red = 0;
	public const NodeColor black = 1;
}

// Namespace: 
private struct Node
{
	// Fields
	internal int _selfId; // 0x0
	internal int _leftId; // 0x0
	internal int _rightId; // 0x0
	internal int _parentId; // 0x0
	internal int _nextId; // 0x0
	internal int _subTreeSize; // 0x0
	internal K _keyOfNode; // 0x0
	internal NodeColor _nodeColor; // 0x0
}

// Namespace: 
private struct NodePath
{
	// Fields
	internal readonly int _nodeID; // 0x0
	internal readonly int _mainTreeNodeID; // 0x0

	// Methods

	// RVA: 0x3526588
	internal void .ctor(int nodeID, int mainTreeNodeID) { }

}

// Namespace: 
private sealed class TreePage
{
	// Fields
	internal readonly Node[] _slots; // 0x0
	internal readonly int[] _slotMap; // 0x0
	private int _inUseCount; // 0x0
	private int _pageId; // 0x0
	private int _nextFreeSlotLine; // 0x0

	// Methods

	// RVA: 0x3526518
	internal void .ctor(int size) { }

	// RVA: 0x3525600
	internal int AllocSlot(System.Data.RBTree<K> tree) { }

	// RVA: 0x35254D0
	internal int get_InUseCount() { }

	// RVA: 0x3526518
	internal void set_InUseCount(int value) { }

	// RVA: 0x35254D0
	internal int get_PageId() { }

	// RVA: 0x3526518
	internal void set_PageId(int value) { }

}

// Namespace: 
internal struct RBTreeEnumerator
{
	// Fields
	private readonly System.Data.RBTree<K> _tree; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private int _mainTreeNodeId; // 0x0
	private K _current; // 0x0

	// Methods

	// RVA: 0x35267E8
	internal void .ctor(System.Data.RBTree<K> tree) { }

	// RVA: 0x3526850
	internal void .ctor(System.Data.RBTree<K> tree, int position) { }

	// RVA: 0x35263A0
	public void Dispose() { }

	// RVA: 0x35251DC
	public bool MoveNext() { }

	// RVA: 0x26AD93C
	public K get_Current() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

}

// Namespace: System.Data
internal abstract class RBTree<T0>
{
	// Fields
	private TreePage[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	// Methods

	// RVA: -1
	protected abstract int CompareNode(K record1, K record2) { }

	// RVA: -1
	protected abstract int CompareSateliteTreeNode(K record1, K record2) { }

	// RVA: 0x3526518
	protected void .ctor(TreeAccessMethod accessMethod) { }

	// RVA: 0x35263A0
	private void InitTree() { }

	// RVA: 0x35267E8
	private void FreePage(TreePage page) { }

	// RVA: -1
	private TreePage AllocPage(int size) { }

	// RVA: 0x35267E8
	private void MarkPageFull(TreePage page) { }

	// RVA: 0x35267E8
	private void MarkPageFree(TreePage page) { }

	// RVA: 0x26AD93C
	private static int GetIntValueFromBitMap(UInt32 bitMap) { }

	// RVA: 0x3526518
	private void FreeNode(int nodeId) { }

	// RVA: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }

	// RVA: 0x35254D0
	public int get_Count() { }

	// RVA: 0x35251DC
	public bool get_HasDuplicates() { }

	// RVA: 0x26AD93C
	private int GetNewNode(K key) { }

	// RVA: -1
	private int Successor(int x_id) { }

	// RVA: -1
	private bool Successor(int nodeId, int mainTreeNodeId) { }

	// RVA: -1
	private int Minimum(int x_id) { }

	// RVA: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }

	// RVA: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }

	// RVA: 0x26AD93C
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }

	// RVA: 0x26AD93C
	public void UpdateNodeKey(K currentKey, K newKey) { }

	// RVA: 0x26AD93C
	public K DeleteByIndex(int i) { }

	// RVA: -1
	public int RBDelete(int z_id) { }

	// RVA: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }

	// RVA: 0x26AD93C
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }

	// RVA: 0x26AD93C
	private int SearchSubTree(int root_id, K key) { }

	// RVA: 0x26AD93C
	public K get_Item(int index) { }

	// RVA: 0x26AD93C
	private NodePath GetNodeByKey(K key) { }

	// RVA: 0x26AD93C
	public int GetIndexByKey(K key) { }

	// RVA: -1
	public int GetIndexByNode(int node) { }

	// RVA: 0x26AD93C
	private int GetIndexByNodePath(NodePath path) { }

	// RVA: -1
	private int ComputeIndexByNode(int nodeId) { }

	// RVA: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }

	// RVA: 0x26AD93C
	private NodePath GetNodeByIndex(int userIndex) { }

	// RVA: -1
	private int ComputeNodeByIndex(int index, int satelliteRootId) { }

	// RVA: 0x3525504
	private int ComputeNodeByIndex(int x_id, int index) { }

	// RVA: 0x26AD93C
	public int Insert(K item) { }

	// RVA: 0x26AD93C
	public int Add(K item) { }

	// RVA: 0x3525804
	public IEnumerator GetEnumerator() { }

	// RVA: 0x26AD93C
	public int IndexOf(int nodeId, K item) { }

	// RVA: 0x26AD93C
	public int Insert(int position, K item) { }

	// RVA: 0x26AD93C
	public int InsertAt(int position, K item, bool append) { }

	// RVA: 0x3526518
	public void RemoveAt(int position) { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x3526850
	public void CopyTo(Array array, int index) { }

	// RVA: 0x3526850
	public void CopyTo(K[] array, int index) { }

	// RVA: 0x3526588
	private void SetRight(int nodeId, int rightNodeId) { }

	// RVA: 0x3526588
	private void SetLeft(int nodeId, int leftNodeId) { }

	// RVA: 0x3526588
	private void SetParent(int nodeId, int parentNodeId) { }

	// RVA: 0x26AD93C
	private void SetColor(int nodeId, NodeColor color) { }

	// RVA: 0x26AD93C
	private void SetKey(int nodeId, K key) { }

	// RVA: 0x3526588
	private void SetNext(int nodeId, int nextNodeId) { }

	// RVA: 0x3526588
	private void SetSubTreeSize(int nodeId, int size) { }

	// RVA: 0x3526518
	private void IncreaseSize(int nodeId) { }

	// RVA: 0x3526518
	private void RecomputeSize(int nodeId) { }

	// RVA: 0x3526518
	private void DecreaseSize(int nodeId) { }

	// RVA: -1
	public int Right(int nodeId) { }

	// RVA: -1
	public int Left(int nodeId) { }

	// RVA: -1
	public int Parent(int nodeId) { }

	// RVA: 0x26AD93C
	private NodeColor color(int nodeId) { }

	// RVA: -1
	public int Next(int nodeId) { }

	// RVA: -1
	public int SubTreeSize(int nodeId) { }

	// RVA: 0x26AD93C
	public K Key(int nodeId) { }

}

// Namespace: System.Data
internal sealed class RecordManager
{
	// Fields
	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly System.Collections.Generic.List<System.Int32> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	// Methods

	// RVA: 0xFC3C58
	internal void .ctor(DataTable table) { }

	// RVA: 0xFC3D3C
	private void GrowRecordCapacity() { }

	// RVA: 0xFC3F34
	internal int get_LastFreeRecord() { }

	// RVA: 0xFC3F3C
	internal int get_MinimumCapacity() { }

	// RVA: 0xFC3F44
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0xFC3F94
	internal int get_RecordCapacity() { }

	// RVA: 0xFC3E98
	internal void set_RecordCapacity(int value) { }

	// RVA: 0xFC3E50
	internal static int NewCapacity(int capacity) { }

	// RVA: 0xFC3E64
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0xFC3F9C
	internal int NewRecordBase() { }

	// RVA: 0xFC4084
	internal void FreeRecord(int record) { }

	// RVA: 0xFC4234
	internal void Clear(bool clearAll) { }

	// RVA: 0xFC44A4
	internal DataRow get_Item(int record) { }

	// RVA: 0xFC41C0
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0xFC44D8
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0xFC44E0
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0xFC49A4
	internal void SetRowCache(DataRow[] newRows) { }

}

// Namespace: System.Data
internal sealed class RelatedView
{
	// Fields
	private readonly System.Nullable<System.Data.DataKey> _parentKey; // 0xD0
	private readonly DataKey _childKey; // 0xE0
	private readonly DataRowView _parentRowView; // 0xE8
	private readonly object[] _filterValues; // 0xF0

	// Methods

	// RVA: 0xFC49E8
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0xFC4B30
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0xFC4C74
	private object[] GetParentValues() { }

	// RVA: 0xFC4D2C
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xFC4EC0
	internal override IFilter GetFilter() { }

	// RVA: 0xFC4EC4
	public override DataRowView AddNew() { }

	// RVA: 0xFC4F28
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

// Namespace: System.Data
internal sealed class RelationshipConverter
{
	// Methods

	// RVA: 0xFC4F58
	public void .ctor() { }

	// RVA: 0xFC4F60
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xFC5020
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Data
public enum Rule
{
	// Fields
	public int value__; // 0x10
	public const Rule None = 0;
	public const Rule Cascade = 1;
	public const Rule SetNull = 2;
	public const Rule SetDefault = 3;
}

// Namespace: System.Data
public enum SchemaSerializationMode
{
	// Fields
	public int value__; // 0x10
	public const SchemaSerializationMode IncludeSchema = 1;
	public const SchemaSerializationMode ExcludeSchema = 2;
}

// Namespace: System.Data
internal struct IndexField
{
	// Fields
	public readonly DataColumn Column; // 0x10
	public readonly bool IsDescending; // 0x18

	// Methods

	// RVA: 0xFC5C18
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0xFC5C44
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0xFC5C58
	public override bool Equals(object obj) { }

	// RVA: 0xFC5CF8
	public override int GetHashCode() { }

}

// Namespace: 
private sealed class IndexTree
{
	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0xFC8CD0
	internal void .ctor(Index index) { }

	// RVA: 0xFC99D0
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0xFC99EC
	protected override int CompareSateliteTreeNode(int record1, int record2) { }

}

// Namespace: 
[Serializable]
private sealed class <>c
{
	// Fields
	public static readonly System.Data.Index.<>c <>9; // 0x0
	public static System.Data.Listeners.Func<System.Data.DataViewListener,System.Data.DataViewListener,System.Boolean> <>9__22_0; // 0x8
	public static System.Data.Listeners.Action<System.Data.DataViewListener,System.Data.DataViewListener,System.ComponentModel.ListChangedEventArgs,System.Boolean,System.Boolean> <>9__85_0; // 0x10

	// Methods

	// RVA: 0xFC9A08
	private static void .cctor() { }

	// RVA: 0xFC9A74
	public void .ctor() { }

	// RVA: 0xFC9A7C
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0xFC9A88
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

}

// Namespace: 
private sealed class <>c__DisplayClass86_0
{
	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0xFC8F58
	public void .ctor() { }

	// RVA: 0xFC9AA8
	internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }

}

// Namespace: System.Data
internal sealed class Index
{
	// Fields
	private readonly DataTable _table; // 0x10
	internal readonly IndexField[] _indexFields; // 0x18
	private readonly System.Comparison<System.Data.DataRow> _comparison; // 0x20
	private readonly DataViewRowState _recordStates; // 0x28
	private WeakReference _rowFilter; // 0x30
	private IndexTree _records; // 0x38
	private int _recordCount; // 0x40
	private int _refCount; // 0x44
	private System.Data.Listeners<System.Data.DataViewListener> _listeners; // 0x48
	private bool _suspendEvents; // 0x50
	private readonly bool _isSharable; // 0x51
	private readonly bool _hasRemoteAggregate; // 0x52
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x54

	// Methods

	// RVA: 0xFC5D58
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xFC60BC
	public void .ctor(DataTable table, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xFC6120
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0xFC5D68
	private void .ctor(DataTable table, IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xFC6640
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xFC66E0
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0xFC66E8
	internal int get_ObjectID() { }

	// RVA: 0xFC66F0
	public DataViewRowState get_RecordStates() { }

	// RVA: 0xFC66F8
	public IFilter get_RowFilter() { }

	// RVA: 0xFC6774
	public int GetRecord(int recordIndex) { }

	// RVA: 0xFC67EC
	public bool get_HasDuplicates() { }

	// RVA: 0xFC6840
	public int get_RecordCount() { }

	// RVA: 0xFC6848
	private bool AcceptRecord(int record) { }

	// RVA: 0xFC68F8
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0xFC6B14
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0xFC6B78
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0xFC6BDC
	public int get_RefCount() { }

	// RVA: 0xFC6BE4
	public void AddRef() { }

	// RVA: 0xFC6DC4
	public int RemoveRef() { }

	// RVA: 0xFC6FC4
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0xFC7638
	public bool CheckUnique() { }

	// RVA: 0xFC7694
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xFC783C
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0xFC78A4
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0xFC7A4C
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0xFC7B30
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0xFC75BC
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0xFC7B38
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0xFC7EDC
	public RBTreeEnumerator GetEnumerator(int startIndex) { }

	// RVA: 0xFC75C4
	public int GetIndex(int record) { }

	// RVA: 0xFC7414
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0xFBD134
	public object[] GetUniqueKeyValues() { }

	// RVA: 0xFC8154
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0xFC8398
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0xFC8610
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0xFC8720
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0xFC885C
	public Range FindRecords(object key) { }

	// RVA: 0xFBD2C0
	public Range FindRecords(object[] key) { }

	// RVA: 0xFC888C
	internal void FireResetEvent() { }

	// RVA: 0xFC8C58
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xFC8C74
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0xFBDF9C
	public DataRow GetRow(int i) { }

	// RVA: 0xFC8C94
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0xFBD2F0
	public DataRow[] GetRows(Range range) { }

	// RVA: 0xFC6220
	private void InitRecords(IFilter filter) { }

	// RVA: 0xFC8D3C
	public int InsertRecordToIndex(int record) { }

	// RVA: 0xFC7154
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0xFC8E10
	public bool IsKeyInIndex(object key) { }

	// RVA: 0xFBD2A4
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0xFC8E2C
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0xFC8A00
	private bool get_DoListChanged() { }

	// RVA: 0xFC8E48
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0xFC7DE0
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0xFC8A88
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xFC7C90
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0xFC8F60
	public void Reset() { }

	// RVA: 0xFC90BC
	public void RecordChanged(int record) { }

	// RVA: 0xFC9258
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0xFC93BC
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xFC94F0
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0xFC99C8
	internal DataTable get_Table() { }

	// RVA: 0xFC7F50
	private void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId) { }

	// RVA: 0x26AD93C
	internal static int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

}

// Namespace: 
internal sealed class Action<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

}

// Namespace: 
internal sealed class Func<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
	public virtual TResult Invoke(T1 arg1) { }

}

// Namespace: System.Data
internal sealed class Listeners<T0>
{
	// Fields
	private readonly System.Collections.Generic.List<TElem> _listeners; // 0x0
	private readonly System.Data.Listeners.Func<TElem,TElem,System.Boolean> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	// Methods

	// RVA: 0x3526680
	internal void .ctor(int ObjectID, System.Data.Listeners.Func<TElem,TElem,System.Boolean> notifyFilter) { }

	// RVA: 0x35251DC
	internal bool get_HasListeners() { }

	// RVA: 0x26AD93C
	internal void Add(TElem listener) { }

	// RVA: 0x26AD93C
	internal int IndexOfReference(TElem listener) { }

	// RVA: 0x26AD93C
	internal void Remove(TElem listener) { }

	// RVA: 0x26AD93C
	internal void Notify(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem,TElem,T1,T2,T3> action) { }

	// RVA: 0x3526518
	private void RemoveNullListeners(int nullIndex) { }

}

// Namespace: System.Data
[Serializable]
internal sealed class SimpleType
{
	// Fields
	private string _baseType; // 0x10
	private SimpleType _baseSimpleType; // 0x18
	private XmlQualifiedName _xmlBaseType; // 0x20
	private string _name; // 0x28
	private int _length; // 0x30
	private int _minLength; // 0x34
	private int _maxLength; // 0x38
	private string _pattern; // 0x40
	private string _ns; // 0x48
	private string _maxExclusive; // 0x50
	private string _maxInclusive; // 0x58
	private string _minExclusive; // 0x60
	private string _minInclusive; // 0x68
	internal string _enumeration; // 0x70

	// Methods

	// RVA: 0xFC9AD8
	internal void .ctor(string baseType) { }

	// RVA: 0xFC9BEC
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0xFCA78C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC9DD4
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0xFCA7CC
	internal bool IsPlainString() { }

	// RVA: 0xFCA910
	internal string get_BaseType() { }

	// RVA: 0xFCA918
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0xFCA920
	internal string get_Name() { }

	// RVA: 0xFCA928
	internal string get_Namespace() { }

	// RVA: 0xFCA930
	internal int get_Length() { }

	// RVA: 0xFCA938
	internal int get_MaxLength() { }

	// RVA: 0xFCA940
	internal void set_MaxLength(int value) { }

	// RVA: 0xFCA948
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0xFCA950
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0xFCA9C4
	internal string QualifiedName(string name) { }

	// RVA: 0xFCAA44
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0xFCAF3C
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0xFCAFCC
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0xFCB040
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0xFCB0C4
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0xFCB1B4
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0xFCB2F4
	internal bool CanHaveMaxLength() { }

	// RVA: 0xFCB35C
	internal void ConvertToAnnonymousSimpleType() { }

}

// Namespace: System.Data
public class UniqueConstraint
{
	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48
	internal string _constraintName; // 0x50
	internal string[] _columnNames; // 0x58

	// Methods

	// RVA: 0xFCB3E0
	public void .ctor(DataColumn column) { }

	// RVA: 0xFCB59C
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0xFCB5DC
	public void .ctor(DataColumn[] columns) { }

	// RVA: 0xFCB610
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0xFCB66C
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0xFCB6B4
	internal string[] get_ColumnNames() { }

	// RVA: 0xFCB6C0
	internal Index get_ConstraintIndex() { }

	// RVA: 0xFCB6C8
	internal void ConstraintIndexClear() { }

	// RVA: 0xFCB708
	internal void ConstraintIndexInitialize() { }

	// RVA: 0xFCB764
	internal override void CheckState() { }

	// RVA: 0xFCB770
	private void NonVirtualCheckState() { }

	// RVA: 0xFCB77C
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xFCB780
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xFCB914
	internal override bool CanEnableConstraint() { }

	// RVA: 0xFCB9A4
	internal override bool IsConstraintViolated() { }

	// RVA: 0xFCBC38
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xFCBD3C
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xFCBD48
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xFCBD58
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xFCC314
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0xFCC82C
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0xFCBD34
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xFCC838
	public bool get_IsPrimaryKey() { }

	// RVA: 0xFCB4A0
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0xFCC888
	public override bool Equals(object key2) { }

	// RVA: 0xFCC940
	public override int GetHashCode() { }

	// RVA: 0xFCC948
	internal override void set_InCollection(bool value) { }

	// RVA: 0xFCC994
	internal DataKey get_Key() { }

	// RVA: 0xFCC99C
	public override DataTable get_Table() { }

}

// Namespace: 
private sealed class NameType
{
	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0xFD0514
	public void .ctor(string n, Type t) { }

	// RVA: 0xFD0564
	public int CompareTo(object obj) { }

}

// Namespace: System.Data
internal sealed class XDRSchema
{
	// Fields
	internal string _schemaName; // 0x10
	internal string _schemaUri; // 0x18
	internal XmlElement _schemaRoot; // 0x20
	internal DataSet _ds; // 0x28
	private static readonly Char[] s_colonArray; // 0x0
	private static NameType[] s_mapNameTypeXdr; // 0x8
	private static NameType s_enumerationNameType; // 0x10

	// Methods

	// RVA: 0xFCC9E0
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0xFCCA64
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0xFCCEA4
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0xFCD1F8
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0xFCD408
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0xFCCCD4
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0xFCDE78
	private static NameType FindNameType(string name) { }

	// RVA: 0xFCDF7C
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0xFCE0E0
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0xFCE264
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0xFCD588
	internal void GetMinMax(XmlElement elNode, int minOccurs, int maxOccurs) { }

	// RVA: 0xFCEBE8
	internal void GetMinMax(XmlElement elNode, bool isAttribute, int minOccurs, int maxOccurs) { }

	// RVA: 0xFCEFD0
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0xFCD7D4
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0xFCD598
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0xFCF1CC
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class XMLDiffLoader
{
	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0xFD05A8
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0xFD0EC0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xFD1238
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0xFD0760
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0xFD1454
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0xFD0B18
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0xFD17E0
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0xFD2C20
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0xFD1CFC
	private int ReadOldRowData(DataSet ds, DataTable table, int pos, XmlReader row) { }

	// RVA: 0xFD1C90
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0xFD2E08
	public void .ctor() { }

}

// Namespace: System.Data
internal class XMLSchema
{
	// Methods

	// RVA: 0xFD2E10
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0xFD2E98
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xFD32F8
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0xFD3384
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0xFD3510
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0xFD363C
	public void .ctor() { }

}

// Namespace: System.Data
internal sealed class ConstraintTable
{
	// Fields
	public DataTable table; // 0x10
	public XmlSchemaIdentityConstraint constraint; // 0x18

	// Methods

	// RVA: 0xFD3644
	public void .ctor(DataTable t, XmlSchemaIdentityConstraint c) { }

}

// Namespace: 
private sealed class NameType
{
	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0xFE470C
	public void .ctor(string n, Type t) { }

	// RVA: 0xFE475C
	public int CompareTo(object obj) { }

}

// Namespace: System.Data
internal sealed class XSDSchema
{
	// Fields
	private XmlSchemaSet _schemaSet; // 0x10
	private XmlSchemaElement _dsElement; // 0x18
	private DataSet _ds; // 0x20
	private string _schemaName; // 0x28
	private ArrayList _columnExpressions; // 0x30
	private Hashtable _constraintNodes; // 0x38
	private ArrayList _refTables; // 0x40
	private ArrayList _complexTypes; // 0x48
	private XmlSchemaObjectCollection _annotations; // 0x50
	private XmlSchemaObjectCollection _elements; // 0x58
	private Hashtable _attributes; // 0x60
	private Hashtable _elementsTable; // 0x68
	private Hashtable _attributeGroups; // 0x70
	private Hashtable _schemaTypes; // 0x78
	private Hashtable _expressions; // 0x80
	private System.Collections.Generic.Dictionary<System.Data.DataTable,System.Collections.Generic.List<System.Data.DataTable>> _tableDictionary; // 0x88
	private Hashtable _udSimpleTypes; // 0x90
	private Hashtable _existingSimpleTypeMap; // 0x98
	private bool _fromInference; // 0xA0
	private static readonly NameType[] s_mapNameTypeXsd; // 0x0

	// Methods

	// RVA: 0xFD3694
	internal bool get_FromInference() { }

	// RVA: 0xFD369C
	internal void set_FromInference(bool value) { }

	// RVA: 0xFD36A4
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0xFD3730
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0xFD4228
	internal static string QualifiedName(string name) { }

	// RVA: 0xFD42A8
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xFD4834
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xFD4BF4
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xFD4100
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0xFD4E00
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xFD5048
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0xFD5234
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0xFD5AAC
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xFD5D04
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0xFD6710
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0xFD6AD8
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0xFD70CC
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0xFD70F4
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0xFDA85C
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0xFD6284
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0xFDAB98
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0xFDC420
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0xFDD164
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0xFDD518
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0xFD6F94
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0xFDED40
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0xFDEEC4
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0xFD6928
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0xFD910C
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0xFDF1EC
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0xFDF288
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0xFDF3A4
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0xFDFD8C
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0xFE0240
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0xFD5134
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0xFE0E80
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0xFE2568
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0xFE2674
	private static NameType FindNameType(string name) { }

	// RVA: 0xFE2778
	private Type ParseDataType(string dt) { }

	// RVA: 0xFE2968
	internal static bool IsXsdType(string name) { }

	// RVA: 0xFD91B8
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0xFDE298
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xFDDB18
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xFDC6F0
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0xFDB4E0
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0xFD967C
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0xFE29E4
	private void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, DataTable dt) { }

	// RVA: 0xFE0A7C
	private string GetPrefix(string ns) { }

	// RVA: 0xFE2C34
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0xFE23E4
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xFDFC5C
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xFD64B0
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0xFD94D0
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0xFE3040
	public void .ctor() { }

	// RVA: 0xFE3048
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class XmlIgnoreNamespaceReader
{
	// Fields
	private System.Collections.Generic.List<System.String> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0xFE47A0
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0xFE4844
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xFE4950
	public override bool MoveToNextAttribute() { }

}

// Namespace: System.Data
internal sealed class XmlDataLoader
{
	// Fields
	private DataSet _dataSet; // 0x10
	private XmlToDatasetMap _nodeToSchemaMap; // 0x18
	private Hashtable _nodeToRowMap; // 0x20
	private Stack _childRowsStack; // 0x28
	private Hashtable _htableExcludedNS; // 0x30
	private bool _fIsXdr; // 0x38
	internal bool _isDiffgram; // 0x39
	private XmlElement _topMostNode; // 0x40
	private bool _ignoreSchema; // 0x48
	private DataTable _dataTable; // 0x50
	private bool _isTableLevel; // 0x58
	private bool _fromInference; // 0x59
	private XmlReader _dataReader; // 0x60
	private object _XSD_XMLNS_NS; // 0x68
	private object _XDR_SCHEMA; // 0x70
	private object _XDRNS; // 0x78
	private object _SQL_SYNC; // 0x80
	private object _UPDGNS; // 0x88
	private object _XSD_SCHEMA; // 0x90
	private object _XSDNS; // 0x98
	private object _DFFNS; // 0xA0
	private object _MSDNS; // 0xA8
	private object _DIFFID; // 0xB0
	private object _HASCHANGES; // 0xB8
	private object _ROWORDER; // 0xC0

	// Methods

	// RVA: 0xFE4A94
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xFE4B3C
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xFE4C3C
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xFE4CFC
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xFE4E14
	internal bool get_FromInference() { }

	// RVA: 0xFE4E1C
	internal void set_FromInference(bool value) { }

	// RVA: 0xFE4E24
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xFE50A4
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0xFE529C
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0xFE5584
	private string GetInitialTextFromNodes(XmlNode n) { }

	// RVA: 0xFE582C
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0xFE5000
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0xFE5900
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0xFE5200
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0xFE5A18
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0xFE5D4C
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0xFE5528
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0xFE58C8
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0xFE5DEC
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0xFE6280
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0xFE6ED0
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xFE7288
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0xFE7304
	private void InitNameTable() { }

	// RVA: 0xFE7610
	internal void LoadData(XmlReader reader) { }

	// RVA: 0xFE7AC0
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0xFE87F0
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0xFE977C
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0xFE85A4
	private bool ProcessXsdSchema() { }

}

// Namespace: System.Data
public enum XmlReadMode
{
	// Fields
	public int value__; // 0x10
	public const XmlReadMode Auto = 0;
	public const XmlReadMode ReadSchema = 1;
	public const XmlReadMode IgnoreSchema = 2;
	public const XmlReadMode InferSchema = 3;
	public const XmlReadMode DiffGram = 4;
	public const XmlReadMode Fragment = 5;
	public const XmlReadMode InferTypedSchema = 6;
}

// Namespace: 
private sealed class XmlNodeIdentety
{
	// Fields
	public string LocalName; // 0x10
	public string NamespaceURI; // 0x18

	// Methods

	// RVA: 0xFECB58
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0xFECBA8
	public override int GetHashCode() { }

	// RVA: 0xFECBCC
	public override bool Equals(object obj) { }

}

// Namespace: 
internal sealed class XmlNodeIdHashtable
{
	// Fields
	private XmlNodeIdentety _id; // 0x50

	// Methods

	// RVA: 0xFECC74
	public void .ctor(int capacity) { }

	// RVA: 0xFECD28
	public object get_Item(XmlNode node) { }

	// RVA: 0xFECDC4
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0xFECE58
	public object get_Item(DataTable table) { }

	// RVA: 0xFECEE4
	public object get_Item(string name) { }

}

// Namespace: 
private sealed class TableSchemaInfo
{
	// Fields
	public DataTable TableSchema; // 0x10
	public XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0xFECF4C
	public void .ctor(DataTable tableSchema) { }

}

// Namespace: System.Data
internal sealed class XmlToDatasetMap
{
	// Fields
	private XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0xFE614C
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xFE7A40
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xFE610C
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xFE7A80
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xFE72D4
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0xFEBFC8
	private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0xFEC108
	private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0xFEC2A4
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	// RVA: 0xFEC540
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns) { }

	// RVA: 0xFEA19C
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xFEA778
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xFEB218
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xFEB56C
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xFEC70C
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0xFE5B08
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xFE9618
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0xFE618C
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xFE84B0
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0xFEC3DC
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

}

// Namespace: System.Data
public enum XmlWriteMode
{
	// Fields
	public int value__; // 0x10
	public const XmlWriteMode WriteSchema = 0;
	public const XmlWriteMode IgnoreSchema = 1;
	public const XmlWriteMode DiffGram = 2;
}

// Namespace: System.Data
internal enum SchemaFormat
{
	// Fields
	public int value__; // 0x10
	public const SchemaFormat Public = 1;
	public const SchemaFormat Remoting = 2;
	public const SchemaFormat WebService = 3;
	public const SchemaFormat RemotingSkipSchema = 4;
	public const SchemaFormat WebServiceSkipSchema = 5;
}

// Namespace: System.Data
internal sealed class XmlTreeGen
{
	// Fields
	private ArrayList _constraintNames; // 0x10
	private Hashtable _namespaces; // 0x18
	private Hashtable _autogenerated; // 0x20
	private Hashtable _prefixes; // 0x28
	private DataSet _ds; // 0x30
	private ArrayList _tables; // 0x38
	private ArrayList _relations; // 0x40
	private XmlDocument _dc; // 0x48
	private XmlElement _sRoot; // 0x50
	private int _prefixCount; // 0x58
	private SchemaFormat _schFormat; // 0x5C
	private string _filePath; // 0x60
	private string _fileName; // 0x68
	private string _fileExt; // 0x70
	private XmlElement _dsElement; // 0x78
	private XmlElement _constraintSeparator; // 0x80
	private System.Converter<System.Type,System.String> _targetConverter; // 0x88

	// Methods

	// RVA: 0xFECFF8
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0xFED0A8
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0xFED0B0
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0xFED7B0
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xFED96C
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xFEE220
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0xFEF1D0
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0xFEF6C4
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0xFEF7C4
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0xFEFA9C
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0xFEFAC8
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0xFEFC78
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0xFEFEEC
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0xFEFF9C
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0xFF0D00
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0xFF0270
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0xFF1400
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xFF1778
	private void CreateRelations(DataTable dt) { }

	// RVA: 0xFF1AC0
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0xFF1DEC
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0xFF5614
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0xFF4918
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0xFF8838
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0xFF8B58
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0xFF8B78
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0xFF8B6C
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0xFF8C44
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0xFF8C4C
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xFF5048
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0xFF8DB0
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0xFF8EAC
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0xFF9150
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0xFF96A8
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0xFF9C94
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0xFF9DC0
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0xFFAB60
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0xFFABE8
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0xFF4F8C
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0xFFA984
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0xFF4F84
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0xFFACD0
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0xFF0DFC
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0xFFB080
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0xFF1328
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0xFF131C
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0xFFB160
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0xFFB2B0
	private bool IsAutoGenerated(object o) { }

	// RVA: 0xFF5AF0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0xFEEF4C
	private void SetMSDataAttribute(XmlElement root, Type type) { }

}

// Namespace: System.Data
internal sealed class NewDiffgramGen
{
	// Fields
	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0xFFB374
	internal void .ctor(DataSet ds) { }

	// RVA: 0xFFB740
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xFFB868
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0xFFB4C8
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0xFFBBE0
	private bool EmptyData() { }

	// RVA: 0xFFBCD8
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0xFFBCE0
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0xFFCE78
	private void GenerateTable(DataTable table) { }

	// RVA: 0xFFCEF8
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0xFFD490
	private void GenerateRow(DataRow row) { }

	// RVA: 0xFFDB68
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0xFFB2FC
	internal static string QualifiedName(string prefix, string name) { }

}

// Namespace: System.Data
internal sealed class XmlDataTreeWriter
{
	// Fields
	private XmlWriter _xmlw; // 0x10
	private DataSet _ds; // 0x18
	private DataTable _dt; // 0x20
	private ArrayList _dTables; // 0x28
	private DataTable[] _topLevelTables; // 0x30
	private bool _fFromTable; // 0x38
	private bool _isDiffgram; // 0x39
	private Hashtable _rowsOrder; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0xFFCB14
	internal void .ctor(DataSet ds) { }

	// RVA: 0xFFC250
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xFFE9C8
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0xFFE650
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xFFDA70
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0xFFC404
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x1000754
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x1001060
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0xFFECF4
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0xFFE59C
	internal static bool PreserveSpace(object value) { }

}

// Namespace: System.Data
internal sealed class DataTextWriter
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Methods

	// RVA: 0xFFC1DC
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x100139C
	private void .ctor(XmlWriter w) { }

	// RVA: 0xFF8ACC
	internal Stream get_BaseStream() { }

	// RVA: 0x10013D0
	public override void WriteStartDocument() { }

	// RVA: 0x10013F4
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1001418
	public override void WriteEndDocument() { }

	// RVA: 0x100143C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1001460
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1001484
	public override void WriteEndElement() { }

	// RVA: 0x10014A8
	public override void WriteFullEndElement() { }

	// RVA: 0x10014CC
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x10014F0
	public override void WriteEndAttribute() { }

	// RVA: 0x1001518
	public override void WriteCData(string text) { }

	// RVA: 0x1001540
	public override void WriteComment(string text) { }

	// RVA: 0x1001568
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1001590
	public override void WriteEntityRef(string name) { }

	// RVA: 0x10015B8
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0x10015E0
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1001608
	public override void WriteString(string text) { }

	// RVA: 0x1001630
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0x1001658
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0x1001680
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0x10016A8
	public override void WriteRaw(string data) { }

	// RVA: 0x10016D0
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0x10016F8
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0x1001720
	public override WriteState get_WriteState() { }

	// RVA: 0x1001748
	public override void Close() { }

	// RVA: 0x1001770
	public override void Flush() { }

	// RVA: 0x1001798
	public override string LookupPrefix(string ns) { }

}

// Namespace: System.Data
internal sealed class DataTextReader
{
	// Fields
	private XmlReader _xmlreader; // 0x10

	// Methods

	// RVA: 0x10017C0
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x1001870
	private void .ctor(XmlReader input) { }

	// RVA: 0x10018E8
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x100190C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1001930
	public override string get_Name() { }

	// RVA: 0x1001954
	public override string get_LocalName() { }

	// RVA: 0x1001978
	public override string get_NamespaceURI() { }

	// RVA: 0x100199C
	public override string get_Prefix() { }

	// RVA: 0x10019C0
	public override string get_Value() { }

	// RVA: 0x10019E4
	public override int get_Depth() { }

	// RVA: 0x1001A08
	public override string get_BaseURI() { }

	// RVA: 0x1001A30
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1001A58
	public override bool get_IsDefault() { }

	// RVA: 0x1001A80
	public override Char get_QuoteChar() { }

	// RVA: 0x1001AA8
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1001AD0
	public override string get_XmlLang() { }

	// RVA: 0x1001AF8
	public override int get_AttributeCount() { }

	// RVA: 0x1001B20
	public override string GetAttribute(string name) { }

	// RVA: 0x1001B48
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1001B70
	public override string GetAttribute(int i) { }

	// RVA: 0x1001B98
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1001BC0
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1001BE8
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1001C10
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1001C38
	public override bool MoveToElement() { }

	// RVA: 0x1001C60
	public override bool ReadAttributeValue() { }

	// RVA: 0x1001C88
	public override bool Read() { }

	// RVA: 0x1001CB0
	public override bool get_EOF() { }

	// RVA: 0x1001CD8
	public override void Close() { }

	// RVA: 0x1001D00
	public override ReadState get_ReadState() { }

	// RVA: 0x1001D28
	public override void Skip() { }

	// RVA: 0x1001D50
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1001D78
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1001DA0
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1001DC8
	public override void ResolveEntity() { }

	// RVA: 0x1001DF0
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1001E18
	public override string ReadString() { }

}

// Namespace: System.Data.SqlTypes
internal static class SQLResource
{
	// Methods

	// RVA: 0x1001E40
	internal static string get_NullString() { }

	// RVA: 0x1001E84
	internal static string get_ArithOverflowMessage() { }

	// RVA: 0x1001EC8
	internal static string get_DivideByZeroMessage() { }

	// RVA: 0x1001F0C
	internal static string get_NullValueMessage() { }

	// RVA: 0x1001F50
	internal static string get_TruncationMessage() { }

	// RVA: 0x1001F94
	internal static string get_DateTimeOverflowMessage() { }

	// RVA: 0x1001FD8
	internal static string get_ConcatDiffCollationMessage() { }

	// RVA: 0x100201C
	internal static string get_CompareDiffCollationMessage() { }

	// RVA: 0x1002060
	internal static string get_ConversionOverflowMessage() { }

	// RVA: 0x10020A4
	internal static string get_TimeZoneSpecifiedMessage() { }

	// RVA: 0x10020E8
	internal static string get_InvalidPrecScaleMessage() { }

	// RVA: 0x100212C
	internal static string get_FormatMessage() { }

	// RVA: 0x1002170
	internal static string InvalidOpStreamClosed(string method) { }

	// RVA: 0x10021C8
	internal static string InvalidOpStreamNonWritable(string method) { }

	// RVA: 0x1002220
	internal static string InvalidOpStreamNonReadable(string method) { }

	// RVA: 0x1002278
	internal static string InvalidOpStreamNonSeekable(string method) { }

}

// Namespace: System.Data.SqlTypes
public interface INullable
{
	// Methods

	// RVA: -1
	public abstract bool get_IsNull() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlBinary
{
	// Fields
	private Byte[] _value; // 0x10
	public static readonly SqlBinary Null; // 0x0

	// Methods

	// RVA: 0x10022D0
	private void .ctor(bool fNull) { }

	// RVA: 0x10022DC
	public void .ctor(Byte[] value) { }

	// RVA: 0x1002378
	public bool get_IsNull() { }

	// RVA: 0x1002388
	public Byte[] get_Value() { }

	// RVA: 0x1002478
	public static SqlBinary op_Implicit(Byte[] x) { }

	// RVA: 0x1002520
	public override string ToString() { }

	// RVA: 0x1002660
	private static EComparison PerformCompareByte(Byte[] x, Byte[] y) { }

	// RVA: 0x100277C
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0x10028AC
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x10029C8
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1002AE4
	public int CompareTo(object value) { }

	// RVA: 0x1002C08
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x1002E94
	public override bool Equals(object value) { }

	// RVA: 0x1003090
	internal static int HashByteArray(Byte[] rgbValue, int length) { }

	// RVA: 0x10030F8
	public override int GetHashCode() { }

	// RVA: 0x100323C
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1003244
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1003468
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x10035AC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x100363C
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlBoolean
{
	// Fields
	private Byte m_value; // 0x10
	public static readonly SqlBoolean True; // 0x0
	public static readonly SqlBoolean False; // 0x1
	public static readonly SqlBoolean Null; // 0x2
	public static readonly SqlBoolean Zero; // 0x3
	public static readonly SqlBoolean One; // 0x4

	// Methods

	// RVA: 0x1002898
	public void .ctor(bool value) { }

	// RVA: 0x10036B4
	public void .ctor(int value) { }

	// RVA: 0x1003724
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x1003740
	public bool get_IsNull() { }

	// RVA: 0x100302C
	public bool get_Value() { }

	// RVA: 0x1003750
	public bool get_IsTrue() { }

	// RVA: 0x1003760
	public bool get_IsFalse() { }

	// RVA: 0x1003770
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0x1002E2C
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0x1003780
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x100387C
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1003960
	public Byte get_ByteValue() { }

	// RVA: 0x1003A14
	public override string ToString() { }

	// RVA: 0x1003B58
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1003C40
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1003D7C
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1003ED0
	public int CompareTo(object value) { }

	// RVA: 0x1003FF4
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x1004150
	public override bool Equals(object value) { }

	// RVA: 0x10042DC
	public override int GetHashCode() { }

	// RVA: 0x10043F8
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1004400
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1004544
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x100467C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x100470C
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlByte
{
	// Fields
	private bool m_fNotNull; // 0x10
	private Byte m_value; // 0x11
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	// Methods

	// RVA: 0x1004800
	private void .ctor(bool fNull) { }

	// RVA: 0x1004808
	public void .ctor(Byte value) { }

	// RVA: 0x1004818
	public bool get_IsNull() { }

	// RVA: 0x1004828
	public Byte get_Value() { }

	// RVA: 0x10048C0
	public static SqlByte op_Implicit(Byte x) { }

	// RVA: 0x10048CC
	public override string ToString() { }

	// RVA: 0x1004964
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0x1004AB8
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0x1004C04
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0x1004D58
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0x1004E98
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0x1005058
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0x1005170
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1005288
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x10053A0
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x100542C
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x10054B8
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1005684
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x10057F4
	public int CompareTo(object value) { }

	// RVA: 0x1005918
	public int CompareTo(SqlByte value) { }

	// RVA: 0x1005AC4
	public override bool Equals(object value) { }

	// RVA: 0x1005C3C
	public override int GetHashCode() { }

	// RVA: 0x1005D30
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1005D38
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1005E78
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1005FC0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1006050
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
internal enum SqlBytesCharsState
{
	// Fields
	public int value__; // 0x10
	public const SqlBytesCharsState Null = 0;
	public const SqlBytesCharsState Buffer = 1;
	public const SqlBytesCharsState Stream = 3;
}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlBytes
{
	// Fields
	internal Byte[] _rgbBuf; // 0x10
	private Int64 _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private Byte[] _rgbWorkBuf; // 0x30

	// Methods

	// RVA: 0x10060CC
	public void .ctor() { }

	// RVA: 0x1006144
	public void .ctor(Byte[] buffer) { }

	// RVA: 0x10061C8
	public void .ctor(SqlBinary value) { }

	// RVA: 0x10062EC
	public bool get_IsNull() { }

	// RVA: 0x10062FC
	public Byte[] get_Buffer() { }

	// RVA: 0x10064B4
	public Int64 get_Length() { }

	// RVA: 0x1006530
	public Byte[] get_Value() { }

	// RVA: 0x100610C
	public void SetNull() { }

	// RVA: 0x1006340
	private void CopyStreamToBuffer() { }

	// RVA: 0x1006330
	internal bool FStream() { }

	// RVA: 0x1006758
	private void SetBuffer(Byte[] buffer) { }

	// RVA: 0x10067BC
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x10067C4
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1006A4C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1006B80
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1006C10
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1006C50
	public static SqlBytes get_Null() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlChars
{
	// Fields
	internal Char[] _rgchBuf; // 0x10
	private Int64 _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private Char[] _rgchWorkBuf; // 0x30

	// Methods

	// RVA: 0x1006D00
	public void .ctor() { }

	// RVA: 0x1006D78
	public void .ctor(Char[] buffer) { }

	// RVA: 0x1006DFC
	public void .ctor(SqlString value) { }

	// RVA: 0x1006FC8
	public bool get_IsNull() { }

	// RVA: 0x1006FD8
	public Char[] get_Buffer() { }

	// RVA: 0x1007188
	public Int64 get_Length() { }

	// RVA: 0x1007204
	public Char[] get_Value() { }

	// RVA: 0x1006D40
	public void SetNull() { }

	// RVA: 0x100700C
	internal bool FStream() { }

	// RVA: 0x100701C
	private void CopyStreamToBuffer() { }

	// RVA: 0x10073F0
	private void SetBuffer(Char[] buffer) { }

	// RVA: 0x1007454
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x100745C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x10075E4
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x10076F4
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1007784
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10077C4
	public static SqlChars get_Null() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlDateTime
{
	// Fields
	private bool m_fNotNull; // 0x10
	private int m_day; // 0x14
	private int m_time; // 0x18
	private static readonly Double s_SQLTicksPerMillisecond; // 0x0
	public static readonly int SQLTicksPerSecond; // 0x8
	public static readonly int SQLTicksPerMinute; // 0xC
	public static readonly int SQLTicksPerHour; // 0x10
	private static readonly int s_SQLTicksPerDay; // 0x14
	private static readonly Int64 s_ticksPerSecond; // 0x18
	private static readonly DateTime s_SQLBaseDate; // 0x20
	private static readonly Int64 s_SQLBaseDateTicks; // 0x28
	private static readonly int s_minYear; // 0x30
	private static readonly int s_maxYear; // 0x34
	private static readonly int s_minDay; // 0x38
	private static readonly int s_maxDay; // 0x3C
	private static readonly int s_minTime; // 0x40
	private static readonly int s_maxTime; // 0x44
	private static readonly int s_dayBase; // 0x48
	private static readonly int[] s_daysToMonth365; // 0x50
	private static readonly int[] s_daysToMonth366; // 0x58
	private static readonly DateTime s_minDateTime; // 0x60
	private static readonly DateTime s_maxDateTime; // 0x68
	private static readonly TimeSpan s_minTimeSpan; // 0x70
	private static readonly TimeSpan s_maxTimeSpan; // 0x78
	private static readonly string s_ISO8601_DateTimeFormat; // 0x80
	private static readonly string[] s_dateTimeFormats; // 0x88
	public static readonly SqlDateTime MinValue; // 0x90
	public static readonly SqlDateTime MaxValue; // 0x9C
	public static readonly SqlDateTime Null; // 0xA8

	// Methods

	// RVA: 0x1007874
	private void .ctor(bool fNull) { }

	// RVA: 0x1007880
	public void .ctor(DateTime value) { }

	// RVA: 0x1007A18
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0x1007B6C
	public bool get_IsNull() { }

	// RVA: 0x1007B7C
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0x1007C28
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0x1007D84
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0x10078F0
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0x1007FEC
	public DateTime get_Value() { }

	// RVA: 0x100809C
	public int get_DayTicks() { }

	// RVA: 0x10080F0
	public int get_TimeTicks() { }

	// RVA: 0x1008144
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0x10081AC
	public override string ToString() { }

	// RVA: 0x10082A0
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x10083B8
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x10084DC
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1008600
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1008680
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1008700
	public int CompareTo(object value) { }

	// RVA: 0x1008814
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0x10089DC
	public override bool Equals(object value) { }

	// RVA: 0x1008B6C
	public override int GetHashCode() { }

	// RVA: 0x1008C6C
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1008C74
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1008EA8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1009018
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x10090A8
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlDecimal
{
	// Fields
	internal Byte _bStatus; // 0x10
	internal Byte _bLen; // 0x11
	internal Byte _bPrec; // 0x12
	internal Byte _bScale; // 0x13
	internal UInt32 _data1; // 0x14
	internal UInt32 _data2; // 0x18
	internal UInt32 _data3; // 0x1C
	internal UInt32 _data4; // 0x20
	private static readonly Byte s_NUMERIC_MAX_PRECISION; // 0x0
	public static readonly Byte MaxPrecision; // 0x1
	public static readonly Byte MaxScale; // 0x2
	private static readonly Byte s_bNullMask; // 0x3
	private static readonly Byte s_bIsNull; // 0x4
	private static readonly Byte s_bNotNull; // 0x5
	private static readonly Byte s_bReverseNullMask; // 0x6
	private static readonly Byte s_bSignMask; // 0x7
	private static readonly Byte s_bPositive; // 0x8
	private static readonly Byte s_bNegative; // 0x9
	private static readonly Byte s_bReverseSignMask; // 0xA
	private static readonly UInt32 s_uiZero; // 0xC
	private static readonly int s_cNumeMax; // 0x10
	private static readonly Int64 s_lInt32Base; // 0x18
	private static readonly UInt64 s_ulInt32Base; // 0x20
	private static readonly UInt64 s_ulInt32BaseForMod; // 0x28
	internal static readonly UInt64 s_llMax; // 0x30
	private static readonly UInt32 s_ulBase10; // 0x38
	private static readonly Double s_DUINT_BASE; // 0x40
	private static readonly Double s_DUINT_BASE2; // 0x48
	private static readonly Double s_DUINT_BASE3; // 0x50
	private static readonly Double s_DMAX_NUME; // 0x58
	private static readonly UInt32 s_DBL_DIG; // 0x60
	private static readonly Byte s_cNumeDivScaleMin; // 0x64
	private static readonly UInt32[] s_rgulShiftBase; // 0x68
	private static readonly UInt32[] s_decimalHelpersLo; // 0x70
	private static readonly UInt32[] s_decimalHelpersMid; // 0x78
	private static readonly UInt32[] s_decimalHelpersHi; // 0x80
	private static readonly UInt32[] s_decimalHelpersHiHi; // 0x88
	private static readonly Byte[] s_rgCLenFromPrec; // 0x90
	private static readonly UInt32 s_ulT1; // 0x98
	private static readonly UInt32 s_ulT2; // 0x9C
	private static readonly UInt32 s_ulT3; // 0xA0
	private static readonly UInt32 s_ulT4; // 0xA4
	private static readonly UInt32 s_ulT5; // 0xA8
	private static readonly UInt32 s_ulT6; // 0xAC
	private static readonly UInt32 s_ulT7; // 0xB0
	private static readonly UInt32 s_ulT8; // 0xB4
	private static readonly UInt32 s_ulT9; // 0xB8
	private static readonly UInt64 s_dwlT10; // 0xC0
	private static readonly UInt64 s_dwlT11; // 0xC8
	private static readonly UInt64 s_dwlT12; // 0xD0
	private static readonly UInt64 s_dwlT13; // 0xD8
	private static readonly UInt64 s_dwlT14; // 0xE0
	private static readonly UInt64 s_dwlT15; // 0xE8
	private static readonly UInt64 s_dwlT16; // 0xF0
	private static readonly UInt64 s_dwlT17; // 0xF8
	private static readonly UInt64 s_dwlT18; // 0x100
	private static readonly UInt64 s_dwlT19; // 0x108
	public static readonly SqlDecimal Null; // 0x110
	public static readonly SqlDecimal MinValue; // 0x124
	public static readonly SqlDecimal MaxValue; // 0x138

	// Methods

	// RVA: 0x100954C
	private Byte CalculatePrecision() { }

	// RVA: 0x10097C4
	private bool VerifyPrecision(Byte precision) { }

	// RVA: 0x1009A48
	private void .ctor(bool fNull) { }

	// RVA: 0x1009ABC
	public void .ctor(Decimal value) { }

	// RVA: 0x1009CB4
	public void .ctor(int value) { }

	// RVA: 0x1009FD0
	public void .ctor(Int64 value) { }

	// RVA: 0x100A4CC
	private void .ctor(UInt32[] rglData, Byte bLen, Byte bPrec, Byte bScale, bool fPositive) { }

	// RVA: 0x100A830
	public bool get_IsNull() { }

	// RVA: 0x100A8AC
	public Decimal get_Value() { }

	// RVA: 0x100AB18
	public bool get_IsPositive() { }

	// RVA: 0x100A7BC
	private void SetPositive() { }

	// RVA: 0x100AC60
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x100AD18
	public Byte get_Scale() { }

	// RVA: 0x100AE38
	public int[] get_Data() { }

	// RVA: 0x100AFC0
	public override string ToString() { }

	// RVA: 0x100B628
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x100C1D4
	public Double ToDouble() { }

	// RVA: 0x100A92C
	private Decimal ToDecimal() { }

	// RVA: 0x100C3A8
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0x100C3C0
	public static SqlDecimal op_Implicit(Int64 x) { }

	// RVA: 0x100C438
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0x100C6D8
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x100D438
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x100D51C
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x100E100
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x100F108
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0x100F1F0
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0x100F33C
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0x100F4F8
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0x100F5F0
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0x100F088
	private static void ZeroToMaxLen(UInt32[] rgulData, int cUI4sCur) { }

	// RVA: 0x100A79C
	private bool FZero() { }

	// RVA: 0x100D3D0
	private bool FGt10_38() { }

	// RVA: 0x100F830
	private bool FGt10_38(UInt32[] rglData) { }

	// RVA: 0x1009DB8
	private static Byte BGetPrecUI4(UInt32 value) { }

	// RVA: 0x100A0C0
	private static Byte BGetPrecUI8(UInt64 dwlVal) { }

	// RVA: 0x100BF94
	private void AddULong(UInt32 ulAdd) { }

	// RVA: 0x100BCF4
	private void MultByULong(UInt32 uiMultiplier) { }

	// RVA: 0x100F910
	private UInt32 DivByULong(UInt32 iDivisor) { }

	// RVA: 0x100CE64
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x100D248
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0x100FB44
	private static void MpMove(UInt32[] rgulS, int ciulS, UInt32[] rgulD, int ciulD) { }

	// RVA: 0x100FBB4
	private static void MpSet(UInt32[] rgulD, int ciulD, UInt32 iulN) { }

	// RVA: 0x100FBE4
	private static void MpNormalize(UInt32[] rgulU, int ciulU) { }

	// RVA: 0x100FC38
	private static void MpMul1(UInt32[] piulD, int ciulD, UInt32 iulX) { }

	// RVA: 0x100B4E4
	private static void MpDiv1(UInt32[] rgulU, int ciulU, UInt32 iulD, UInt32 iulR) { }

	// RVA: 0x100FD44
	internal static UInt64 DWL(UInt32 lo, UInt32 hi) { }

	// RVA: 0x100FD38
	private static UInt32 HI(UInt64 x) { }

	// RVA: 0x100FD40
	private static UInt32 LO(UInt64 x) { }

	// RVA: 0x100E69C
	private static void MpDiv(UInt32[] rgulU, int ciulU, UInt32[] rgulD, int ciulD, UInt32[] rgulQ, int ciulQ, UInt32[] rgulR, int ciulR) { }

	// RVA: 0x100FD50
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0x100A6BC
	private static void CheckValidPrecScale(Byte bPrec, Byte bScale) { }

	// RVA: 0x1010204
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x101041C
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1010634
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x101084C
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1010900
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x10109B4
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1010BD8
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1010ED4
	public SqlMoney ToSqlMoney() { }

	// RVA: 0x100B61C
	private static Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0x100F8B4
	private void StoreFromWorkingArray(UInt32[] rguiData) { }

	// RVA: 0x100BC70
	private void SetToZero() { }

	// RVA: 0x1011120
	public int CompareTo(object value) { }

	// RVA: 0x1011254
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x10115A4
	public override bool Equals(object value) { }

	// RVA: 0x10118FC
	public override int GetHashCode() { }

	// RVA: 0x1011AA8
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1011AB0
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1011C34
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1011DD0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1011E60
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlDouble
{
	// Fields
	private bool m_fNotNull; // 0x10
	private Double m_value; // 0x18
	public static readonly SqlDouble Null; // 0x0
	public static readonly SqlDouble Zero; // 0x10
	public static readonly SqlDouble MinValue; // 0x20
	public static readonly SqlDouble MaxValue; // 0x30

	// Methods

	// RVA: 0x101221C
	private void .ctor(bool fNull) { }

	// RVA: 0x1012228
	public void .ctor(Double value) { }

	// RVA: 0x10122A0
	public bool get_IsNull() { }

	// RVA: 0x10122B0
	public Double get_Value() { }

	// RVA: 0x1012304
	public static SqlDouble op_Implicit(Double x) { }

	// RVA: 0x101236C
	public override string ToString() { }

	// RVA: 0x1012404
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0x101251C
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0x10126B8
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1012854
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0x10129F0
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1005540
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0x1012BC4
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0x1012D08
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0x1012E44
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0x1012F84
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0x1013120
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0x1010A40
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0x1013384
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1013498
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x10135AC
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x10136C0
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1013740
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x10137C0
	public SqlSingle ToSqlSingle() { }

	// RVA: 0x1013938
	public int CompareTo(object value) { }

	// RVA: 0x1013A48
	public int CompareTo(SqlDouble value) { }

	// RVA: 0x1013C04
	public override bool Equals(object value) { }

	// RVA: 0x1013D8C
	public override int GetHashCode() { }

	// RVA: 0x1013E7C
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1013E84
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1013FC4
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1014118
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x10141A8
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlGuid
{
	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private Byte[] m_value; // 0x10
	public static readonly SqlGuid Null; // 0x10

	// Methods

	// RVA: 0x101423C
	private void .ctor(bool fNull) { }

	// RVA: 0x1014248
	public void .ctor(Guid g) { }

	// RVA: 0x101428C
	public bool get_IsNull() { }

	// RVA: 0x101429C
	public Guid get_Value() { }

	// RVA: 0x1014360
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x101439C
	public override string ToString() { }

	// RVA: 0x1014454
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0x10145FC
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1014718
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1014834
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1014950
	public int CompareTo(object value) { }

	// RVA: 0x1014A74
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x1014C14
	public override bool Equals(object value) { }

	// RVA: 0x1014D78
	public override int GetHashCode() { }

	// RVA: 0x1014E38
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1014E40
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1014F9C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1015100
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1015190
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlInt16
{
	// Fields
	private bool m_fNotNull; // 0x10
	private Int16 m_value; // 0x12
	private static readonly int s_MASKI2; // 0x0
	public static readonly SqlInt16 Null; // 0x4
	public static readonly SqlInt16 Zero; // 0x8
	public static readonly SqlInt16 MinValue; // 0xC
	public static readonly SqlInt16 MaxValue; // 0x10

	// Methods

	// RVA: 0x1015278
	private void .ctor(bool fNull) { }

	// RVA: 0x1015284
	public void .ctor(Int16 value) { }

	// RVA: 0x100F2D8
	public bool get_IsNull() { }

	// RVA: 0x100F2E8
	public Int16 get_Value() { }

	// RVA: 0x1015294
	public static SqlInt16 op_Implicit(Int16 x) { }

	// RVA: 0x10152A0
	public override string ToString() { }

	// RVA: 0x1015338
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0x101540C
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1015560
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x10156B4
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x101584C
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1015A04
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0x1015AF4
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0x1015C34
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1015D48
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1015E5C
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1015F70
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1015FFC
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1016088
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1016110
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1016280
	public int CompareTo(object value) { }

	// RVA: 0x10163A4
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x1016550
	public override bool Equals(object value) { }

	// RVA: 0x10166C0
	public override int GetHashCode() { }

	// RVA: 0x10167B4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x10167BC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x10168FC
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1016A44
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1016AD4
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlInt32
{
	// Fields
	private bool m_fNotNull; // 0x10
	private int m_value; // 0x14
	private static readonly Int64 s_iIntMin; // 0x0
	private static readonly Int64 s_lBitNotIntMax; // 0x8
	public static readonly SqlInt32 Null; // 0x10
	public static readonly SqlInt32 Zero; // 0x18
	public static readonly SqlInt32 MinValue; // 0x20
	public static readonly SqlInt32 MaxValue; // 0x28

	// Methods

	// RVA: 0x1016B54
	private void .ctor(bool fNull) { }

	// RVA: 0x1016B60
	public void .ctor(int value) { }

	// RVA: 0x100F43C
	public bool get_IsNull() { }

	// RVA: 0x100F44C
	public int get_Value() { }

	// RVA: 0x1016B70
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x1016B7C
	public override string ToString() { }

	// RVA: 0x1016C14
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0x1016CE4
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1016E68
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1016FE0
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1017178
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1017330
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0x1017420
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0x1017510
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0x1016E5C
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0x1017650
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1017768
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1017880
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1017998
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1017A24
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1017AB0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1017B38
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1017CA8
	public int CompareTo(object value) { }

	// RVA: 0x1017DCC
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x1017F74
	public override bool Equals(object value) { }

	// RVA: 0x10180E4
	public override int GetHashCode() { }

	// RVA: 0x10181A4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x10181AC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x10182EC
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1018434
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x10184C4
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlInt64
{
	// Fields
	private bool m_fNotNull; // 0x10
	private Int64 m_value; // 0x18
	private static readonly Int64 s_lLowIntMask; // 0x0
	private static readonly Int64 s_lHighIntMask; // 0x8
	public static readonly SqlInt64 Null; // 0x10
	public static readonly SqlInt64 Zero; // 0x20
	public static readonly SqlInt64 MinValue; // 0x30
	public static readonly SqlInt64 MaxValue; // 0x40

	// Methods

	// RVA: 0x1018544
	private void .ctor(bool fNull) { }

	// RVA: 0x1018550
	public void .ctor(Int64 value) { }

	// RVA: 0x1004FF4
	public bool get_IsNull() { }

	// RVA: 0x1005004
	public Int64 get_Value() { }

	// RVA: 0x1018560
	public static SqlInt64 op_Implicit(Int64 x) { }

	// RVA: 0x101856C
	public override string ToString() { }

	// RVA: 0x1018604
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0x10186CC
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1018844
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x10189AC
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1018B50
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1018CE0
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x100570C
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0x1016198
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0x1017BC0
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0x1010C64
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0x1018834
	private static bool SameSignLong(Int64 x, Int64 y) { }

	// RVA: 0x1018E74
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1018F80
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x101908C
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1019198
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1019218
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1019298
	public SqlByte ToSqlByte() { }

	// RVA: 0x1019328
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x10193B8
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0x1019448
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0x10194D8
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x1019564
	public int CompareTo(object value) { }

	// RVA: 0x1019674
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0x1019830
	public override bool Equals(object value) { }

	// RVA: 0x10199B8
	public override int GetHashCode() { }

	// RVA: 0x1019AAC
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1019AB4
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1019BF4
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1019D3C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1019DCC
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlMoney
{
	// Fields
	private bool _fNotNull; // 0x10
	private Int64 _value; // 0x18
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly Int64 s_lTickBase; // 0x8
	private static readonly Double s_dTickBase; // 0x10
	private static readonly Int64 s_minLong; // 0x18
	private static readonly Int64 s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

	// Methods

	// RVA: 0x1019E68
	private void .ctor(bool fNull) { }

	// RVA: 0x1019E74
	internal void .ctor(Int64 value, int ignored) { }

	// RVA: 0x1019E84
	public void .ctor(int value) { }

	// RVA: 0x1019F04
	public void .ctor(Int64 value) { }

	// RVA: 0x101A024
	public void .ctor(Decimal value) { }

	// RVA: 0x100F6FC
	public bool get_IsNull() { }

	// RVA: 0x101A19C
	public Decimal get_Value() { }

	// RVA: 0x100F70C
	public Decimal ToDecimal() { }

	// RVA: 0x10132E8
	public Double ToDouble() { }

	// RVA: 0x101A23C
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0x101A26C
	public static SqlMoney op_Implicit(Int64 x) { }

	// RVA: 0x101A2D8
	public override string ToString() { }

	// RVA: 0x101A41C
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0x101A54C
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0x101A728
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0x101A904
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0x101AA74
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0x101ABE4
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0x101AD34
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0x101AE88
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0x101AFE4
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0x1010F60
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0x101B0D8
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0x101B1E4
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x101B2F0
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x101B3FC
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x101B47C
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x101B4FC
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x101B58C
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x101B618
	public int CompareTo(object value) { }

	// RVA: 0x101B728
	public int CompareTo(SqlMoney value) { }

	// RVA: 0x101B8E4
	public override bool Equals(object value) { }

	// RVA: 0x101BA6C
	public override int GetHashCode() { }

	// RVA: 0x101BB00
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x101BB08
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x101BCA4
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x101BE0C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x101BE9C
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlSingle
{
	// Fields
	private bool _fNotNull; // 0x10
	private float _value; // 0x14
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	// Methods

	// RVA: 0x101BF80
	private void .ctor(bool fNull) { }

	// RVA: 0x101BF8C
	public void .ctor(float value) { }

	// RVA: 0x101C004
	public void .ctor(Double value) { }

	// RVA: 0x10130BC
	public bool get_IsNull() { }

	// RVA: 0x10130CC
	public float get_Value() { }

	// RVA: 0x101C0F0
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x101C15C
	public override string ToString() { }

	// RVA: 0x101C1F4
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0x101C2FC
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0x101C494
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0x101C62C
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0x101C7C4
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0x101C994
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0x101CAC8
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0x101CBFC
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0x101CD40
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0x101CE70
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0x101CFF4
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0x1013850
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0x101D154
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0x101D274
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x101D394
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x101D4B4
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x101D540
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x101D5CC
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x101D654
	public int CompareTo(object value) { }

	// RVA: 0x101D778
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x101D920
	public override bool Equals(object value) { }

	// RVA: 0x101DA90
	public override int GetHashCode() { }

	// RVA: 0x101DB84
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x101DB8C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x101DCCC
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x101DE20
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x101DEB0
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
public enum SqlCompareOptions
{
	// Fields
	public int value__; // 0x10
	public const SqlCompareOptions None = 0;
	public const SqlCompareOptions IgnoreCase = 1;
	public const SqlCompareOptions IgnoreNonSpace = 2;
	public const SqlCompareOptions IgnoreKanaType = 8;
	public const SqlCompareOptions IgnoreWidth = 16;
	public const SqlCompareOptions BinarySort = 32768;
	public const SqlCompareOptions BinarySort2 = 16384;
}

// Namespace: System.Data.SqlTypes
[Serializable]
public struct SqlString
{
	// Fields
	private string m_value; // 0x10
	private CompareInfo m_cmpInfo; // 0x18
	private int m_lcid; // 0x20
	private SqlCompareOptions m_flag; // 0x24
	private bool m_fNotNull; // 0x28
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	// Methods

	// RVA: 0x101DF30
	private void .ctor(bool fNull) { }

	// RVA: 0x101DF70
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x101E110
	public void .ctor(string data) { }

	// RVA: 0x101E1E4
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x1006F0C
	public bool get_IsNull() { }

	// RVA: 0x1006F1C
	public string get_Value() { }

	// RVA: 0x101E2F4
	private void SetCompareInfo() { }

	// RVA: 0x101E390
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x101E3A4
	public override string ToString() { }

	// RVA: 0x101E434
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0x101E5B4
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0x101ED88
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0x101EF28
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0x101E03C
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x101ECB8
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x101EFC0
	private bool FBinarySort() { }

	// RVA: 0x101E8E0
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0x101EAF4
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x101F058
	public int CompareTo(object value) { }

	// RVA: 0x101F17C
	public int CompareTo(SqlString value) { }

	// RVA: 0x101F2C4
	public override bool Equals(object value) { }

	// RVA: 0x101F4CC
	public override int GetHashCode() { }

	// RVA: 0x101F7E8
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x101F7F0
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x101F91C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x101FA30
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x101FAC0
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
internal enum EComparison
{
	// Fields
	public int value__; // 0x10
	public const EComparison LT = 0;
	public const EComparison LE = 1;
	public const EComparison EQ = 2;
	public const EComparison GE = 3;
	public const EComparison GT = 4;
	public const EComparison NE = 5;
}

// Namespace: System.Data.SqlTypes
[Serializable]
public class SqlTypeException
{
	// Methods

	// RVA: 0x101FBD0
	public void .ctor() { }

	// RVA: 0x1006724
	public void .ctor(string message) { }

	// RVA: 0x101FC3C
	public void .ctor(string message, Exception e) { }

	// RVA: 0x101FC6C
	protected void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x101FCC0
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlNullValueException
{
	// Methods

	// RVA: 0x100487C
	public void .ctor() { }

	// RVA: 0x101FDCC
	public void .ctor(string message) { }

	// RVA: 0x101FD9C
	public void .ctor(string message, Exception e) { }

	// RVA: 0x101FE00
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x101FE64
	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlTruncateException
{
	// Methods

	// RVA: 0x100FB00
	public void .ctor() { }

	// RVA: 0x101FF70
	public void .ctor(string message) { }

	// RVA: 0x101FF40
	public void .ctor(string message, Exception e) { }

	// RVA: 0x101FFA4
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1020008
	private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
internal abstract class SqlStreamChars
{
	// Methods

	// RVA: -1
	public abstract Int64 get_Length() { }

	// RVA: -1
	public abstract Int64 get_Position() { }

	// RVA: -1
	public abstract int Read(Char[] buffer, int offset, int count) { }

	// RVA: -1
	public abstract Int64 Seek(Int64 offset, SeekOrigin origin) { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlXml
{
	// Fields
	private static readonly System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> s_sqlReaderDelegate; // 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
	private MethodInfo _createSqlReaderMethodInfo; // 0x10
	private bool _fNotNull; // 0x18
	private Stream _stream; // 0x20
	private bool _firstCreateReader; // 0x28

	// Methods

	// RVA: 0x10200E4
	public void .ctor() { }

	// RVA: 0x102015C
	public XmlReader CreateReader() { }

	// RVA: 0x1020508
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput, bool throwTargetInvocationExceptions) { }

	// RVA: 0x10206F0
	private static System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0x10203AC
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0x1020318
	public bool get_IsNull() { }

	// RVA: 0x1020124
	private void SetNull() { }

	// RVA: 0x10207DC
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x10207E4
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x10209F0
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1020B64
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1020BF4
	private static void .cctor() { }

}

// Namespace: System.Data.SqlTypes
internal sealed class SqlXmlStreamWrapper
{
	// Fields
	private Stream _stream; // 0x28
	private Int64 _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Methods

	// RVA: 0x1020328
	internal void .ctor(Stream stream) { }

	// RVA: 0x1020CF8
	public override bool get_CanRead() { }

	// RVA: 0x1020E0C
	public override bool get_CanSeek() { }

	// RVA: 0x1020E9C
	public override bool get_CanWrite() { }

	// RVA: 0x1020F2C
	public override Int64 get_Length() { }

	// RVA: 0x10210E0
	public override Int64 get_Position() { }

	// RVA: 0x1021148
	public override void set_Position(Int64 value) { }

	// RVA: 0x1021220
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0x10213A8
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0x10215F8
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0x1021848
	public override int ReadByte() { }

	// RVA: 0x1021974
	public override void WriteByte(Byte value) { }

	// RVA: 0x1021A5C
	public override void Flush() { }

	// RVA: 0x1021A78
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1021060
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0x1021578
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0x10217C8
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0x1020FA4
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0x1020D88
	private bool IsStreamClosed() { }

}

// Namespace: 
private enum Families
{
	// Fields
	public int value__; // 0x10
	public const Families DATETIME = 0;
	public const Families NUMBER = 1;
	public const Families STRING = 2;
	public const Families BOOLEAN = 3;
	public const Families ARRAY = 4;
}

// Namespace: 
private class TempAssemblyComparer
{
	// Fields
	internal static readonly System.Collections.Generic.IEqualityComparer<System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute>> s_default; // 0x0

	// Methods

	// RVA: 0x1025554
	private void .ctor() { }

	// RVA: 0x102555C
	public bool Equals(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> y) { }

	// RVA: 0x1025DC0
	public int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> obj) { }

	// RVA: 0x1025F54
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class ObjectStorage
{
	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static System.Collections.Generic.Dictionary<System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute>,System.Xml.Serialization.XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x1021A88
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x1021C24
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1021C5C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1022324
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1022520
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x1021E44
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x10227FC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1022880
	public override object Get(int recordNo) { }

	// RVA: 0x10226C0
	private Families GetFamily(Type dataType) { }

	// RVA: 0x10228CC
	public override bool IsNull(int record) { }

	// RVA: 0x1022908
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1023000
	public override void SetCapacity(int capacity) { }

	// RVA: 0x10230C4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10236E8
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1024808
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1024D14
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1024E84
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1024ED8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1025114
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x102532C
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x1023644
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x1023DC8
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x102547C
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal static class ADP
{
	// Fields
	private static readonly Type s_stackOverflowType; // 0x0
	private static readonly Type s_outOfMemoryType; // 0x8
	private static readonly Type s_threadAbortType; // 0x10
	private static readonly Type s_nullReferenceType; // 0x18
	private static readonly Type s_accessViolationType; // 0x20
	private static readonly Type s_securityType; // 0x28
	internal static readonly string StrEmpty; // 0x30
	internal static readonly string[] AzureSqlServerEndpoints; // 0x38
	internal static readonly IntPtr PtrZero; // 0x40
	internal static readonly int PtrSize; // 0x48

	// Methods

	// RVA: 0x1025FC0
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1026068
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1026184
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x10262A0
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x1026334
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x10263C8
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x102646C
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x1026500
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x1026594
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x102684C
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x1026A9C
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x1026C28
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x1026D40
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x1026DFC
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x1026EB8
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x1026F74
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x10270B0
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class BigIntegerStorage
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x1027410
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1027678
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10276B0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1027888
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1027A1C
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x10280A8
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x10286DC
	public override object ConvertValue(object value) { }

	// RVA: 0x10287B8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1028888
	public override object Get(int record) { }

	// RVA: 0x10289CC
	public override void Set(int record, object value) { }

	// RVA: 0x1028B70
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1028D48
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1028E2C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1028F20
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1028F74
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1029094
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class BooleanStorage
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x1029164
	internal void .ctor(DataColumn column) { }

	// RVA: 0x102929C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1029734
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1029814
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1029908
	public override object ConvertValue(object value) { }

	// RVA: 0x1029A60
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1029AE4
	public override object Get(int record) { }

	// RVA: 0x1029B7C
	public override void Set(int record, object value) { }

	// RVA: 0x1029D20
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1029E64
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1029EEC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1029F94
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1029FE8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x102A0EC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class ByteStorage
{
	// Fields
	private Byte[] _values; // 0x50

	// Methods

	// RVA: 0x102A1BC
	internal void .ctor(DataColumn column) { }

	// RVA: 0x102A2F4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x102AAD0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x102AB94
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x102AC74
	public override object ConvertValue(object value) { }

	// RVA: 0x102ADCC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x102AE50
	public override object Get(int record) { }

	// RVA: 0x102AEE8
	public override void Set(int record, object value) { }

	// RVA: 0x102B08C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x102B1D0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x102B258
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x102B300
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x102B354
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x102B458
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class CharStorage
{
	// Fields
	private Char[] _values; // 0x50

	// Methods

	// RVA: 0x102B528
	internal void .ctor(DataColumn column) { }

	// RVA: 0x102B660
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x102BA28
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x102BB04
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x102BBF8
	public override object ConvertValue(object value) { }

	// RVA: 0x102BD50
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x102BDD4
	public override object Get(int record) { }

	// RVA: 0x102BE6C
	public override void Set(int record, object value) { }

	// RVA: 0x102C05C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x102C1A0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x102C228
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x102C2D0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x102C324
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x102C428
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal enum StorageType
{
	// Fields
	public int value__; // 0x10
	public const StorageType Empty = 0;
	public const StorageType Object = 1;
	public const StorageType DBNull = 2;
	public const StorageType Boolean = 3;
	public const StorageType Char = 4;
	public const StorageType SByte = 5;
	public const StorageType Byte = 6;
	public const StorageType Int16 = 7;
	public const StorageType UInt16 = 8;
	public const StorageType Int32 = 9;
	public const StorageType UInt32 = 10;
	public const StorageType Int64 = 11;
	public const StorageType UInt64 = 12;
	public const StorageType Single = 13;
	public const StorageType Double = 14;
	public const StorageType Decimal = 15;
	public const StorageType DateTime = 16;
	public const StorageType TimeSpan = 17;
	public const StorageType String = 18;
	public const StorageType Guid = 19;
	public const StorageType ByteArray = 20;
	public const StorageType CharArray = 21;
	public const StorageType Type = 22;
	public const StorageType DateTimeOffset = 23;
	public const StorageType BigInteger = 24;
	public const StorageType Uri = 25;
	public const StorageType SqlBinary = 26;
	public const StorageType SqlBoolean = 27;
	public const StorageType SqlByte = 28;
	public const StorageType SqlBytes = 29;
	public const StorageType SqlChars = 30;
	public const StorageType SqlDateTime = 31;
	public const StorageType SqlDecimal = 32;
	public const StorageType SqlDouble = 33;
	public const StorageType SqlGuid = 34;
	public const StorageType SqlInt16 = 35;
	public const StorageType SqlInt32 = 36;
	public const StorageType SqlInt64 = 37;
	public const StorageType SqlMoney = 38;
	public const StorageType SqlSingle = 39;
	public const StorageType SqlString = 40;
}

// Namespace: System.Data.Common
internal abstract class DataStorage
{
	// Fields
	private static readonly Type[] s_storageClassType; // 0x0
	internal readonly DataColumn _column; // 0x10
	internal readonly DataTable _table; // 0x18
	internal readonly Type _dataType; // 0x20
	internal readonly StorageType _storageTypeCode; // 0x28
	private BitArray _dbNullBits; // 0x30
	private readonly object _defaultValue; // 0x38
	internal readonly object _nullValue; // 0x40
	internal readonly bool _isCloneable; // 0x48
	internal readonly bool _isCustomDefinedType; // 0x49
	internal readonly bool _isStringType; // 0x4A
	internal readonly bool _isValueType; // 0x4B
	private static readonly System.Func<System.Type,System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean>> s_inspectTypeForInterfaces; // 0x8
	private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean>> s_typeImplementsInterface; // 0x10

	// Methods

	// RVA: 0x10275D8
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x102C678
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x102C4F8
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x102C6E0
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1028798
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x102966C
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x102C700
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x102781C
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract int Compare(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x102C7A4
	public virtual object ConvertValue(object value) { }

	// RVA: 0x1028844
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1
	public abstract void Copy(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract object Get(int recordNo) { }

	// RVA: 0x1028988
	protected object GetBits(int recordNo) { }

	// RVA: 0x102C7AC
	public virtual int GetStringLength(int record) { }

	// RVA: 0x10279F4
	protected bool HasValue(int recordNo) { }

	// RVA: 0x102C7B4
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1
	public abstract void Set(int recordNo, object value) { }

	// RVA: 0x1028B50
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x1028CB4
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1
	public abstract object ConvertXmlToObject(string s) { }

	// RVA: 0x102C7D4
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1
	public abstract string ConvertObjectToXml(object value) { }

	// RVA: 0x102C820
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x102C868
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x102E344
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x102E468
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x102E508
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x102C684
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x102E584
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x102E590
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x102C6A0
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x102E694
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, bool sqlType, bool nullable, bool xmlSerializable, bool changeTracking, bool revertibleChangeTracking) { }

	// RVA: 0x102E910
	private static System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x102EAF4
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x102EBC8
	public static bool IsObjectNull(object value) { }

	// RVA: 0x102ED5C
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x102EE34
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x102EE44
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x102EE54
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1
	protected abstract object GetEmptyStorage(int recordCount) { }

	// RVA: -1
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: -1
	protected abstract void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x102EE64
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x102EE6C
	internal static Type GetType(string value) { }

	// RVA: 0x102EFA8
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x102F044
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0x102DB30
	internal void .ctor(DataColumn column) { }

	// RVA: 0x102FE84
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1030394
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x103056C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1030724
	public override object ConvertValue(object value) { }

	// RVA: 0x10307E8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x103086C
	public override object Get(int record) { }

	// RVA: 0x103099C
	public override void Set(int record, object value) { }

	// RVA: 0x1030AD0
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1030C14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1030CA8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1030D60
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1030DB4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1030EC8
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1030F98
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeStorage
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x102D9A4
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1031014
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1031504
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1031700
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x10318B0
	public override object ConvertValue(object value) { }

	// RVA: 0x1031A14
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1031A98
	public override object Get(int record) { }

	// RVA: 0x1031BE0
	public override void Set(int record, object value) { }

	// RVA: 0x1031FC0
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1032104
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10321CC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10322C8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x103231C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1032498
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x10326CC
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DecimalStorage
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x102D7FC
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1032748
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1033250
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1033408
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1033598
	public override object ConvertValue(object value) { }

	// RVA: 0x103371C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10337A0
	public override object Get(int record) { }

	// RVA: 0x1033878
	public override void Set(int record, object value) { }

	// RVA: 0x1033A3C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1033B80
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1033C40
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1033CF8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1033D4C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1033E60
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class DoubleStorage
{
	// Fields
	private Double[] _values; // 0x50

	// Methods

	// RVA: 0x102D6C4
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1033F30
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x103467C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x103474C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1034830
	public override object ConvertValue(object value) { }

	// RVA: 0x1034988
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1034A0C
	public override object Get(int record) { }

	// RVA: 0x1034AA8
	public override void Set(int record, object value) { }

	// RVA: 0x1034C4C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1034D90
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1034E18
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1034EC0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1034F14
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1035020
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int16Storage
{
	// Fields
	private Int16[] _values; // 0x50

	// Methods

	// RVA: 0x102D31C
	internal void .ctor(DataColumn column) { }

	// RVA: 0x10350F0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1035924
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x10359DC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1035AC4
	public override object ConvertValue(object value) { }

	// RVA: 0x1035C1C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1035CA0
	public override object Get(int record) { }

	// RVA: 0x1035D38
	public override void Set(int record, object value) { }

	// RVA: 0x1035EDC
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1036020
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10360A8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1036150
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10361A4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10362A8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int32Storage
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x102D454
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1036378
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1036BAC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1036C80
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1036D68
	public override object ConvertValue(object value) { }

	// RVA: 0x1036EC0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1036F44
	public override object Get(int record) { }

	// RVA: 0x1036FDC
	public override void Set(int record, object value) { }

	// RVA: 0x1037180
	public override void SetCapacity(int capacity) { }

	// RVA: 0x10372C4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x103734C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10373F4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1037448
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x103754C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int64Storage
{
	// Fields
	private Int64[] _values; // 0x50

	// Methods

	// RVA: 0x102D58C
	internal void .ctor(DataColumn column) { }

	// RVA: 0x103761C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1037E80
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1037F54
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x103803C
	public override object ConvertValue(object value) { }

	// RVA: 0x1038194
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1038218
	public override object Get(int record) { }

	// RVA: 0x10382B0
	public override void Set(int record, object value) { }

	// RVA: 0x1038454
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1038598
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1038620
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10386C8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x103871C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1038820
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SByteStorage
{
	// Fields
	private SByte[] _values; // 0x50

	// Methods

	// RVA: 0x102D1E4
	public void .ctor(DataColumn column) { }

	// RVA: 0x10388F0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10390E4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x10391D0
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x10392B0
	public override object ConvertValue(object value) { }

	// RVA: 0x1039408
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x103948C
	public override object Get(int record) { }

	// RVA: 0x1039544
	public override void Set(int record, object value) { }

	// RVA: 0x10396E8
	public override void SetCapacity(int capacity) { }

	// RVA: 0x103982C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10398B4
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x103995C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10399B0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1039AB4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal static class SqlConvert
{
	// Methods

	// RVA: 0x1039B84
	public static SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0x1039DB0
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0x103A0B0
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0x103A4D8
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0x103A9E8
	public static SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0x103B0E8
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0x103B6FC
	public static SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0x103BD9C
	public static SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0x103C3D8
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0x103C614
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0x103C82C
	public static SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0x103CA6C
	public static SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0x103CCA0
	public static SqlString ConvertToSqlString(object value) { }

	// RVA: 0x103CE9C
	public static SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0x103D00C
	public static SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0x103D17C
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0x103D1E8
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x103D3C8
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x103E3CC
	public static object ChangeTypeForXML(object value, Type type) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x102DCBC
	public void .ctor(DataColumn column) { }

	// RVA: 0x10400F0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1040340
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x10403E4
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x10404A4
	public override object ConvertValue(object value) { }

	// RVA: 0x1040530
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1040578
	public override object Get(int record) { }

	// RVA: 0x1040604
	public override bool IsNull(int record) { }

	// RVA: 0x104068C
	public override void Set(int record, object value) { }

	// RVA: 0x10406DC
	public override void SetCapacity(int capacity) { }

	// RVA: 0x10407A0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1040A4C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1040CB4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1040D08
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1040E14
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlByteStorage
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x102DDE8
	public void .ctor(DataColumn column) { }

	// RVA: 0x1040EC4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1041CE8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1041D8C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1041E4C
	public override object ConvertValue(object value) { }

	// RVA: 0x1041ED8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1041F18
	public override object Get(int record) { }

	// RVA: 0x1041FA4
	public override bool IsNull(int record) { }

	// RVA: 0x104202C
	public override void Set(int record, object value) { }

	// RVA: 0x1042074
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1042138
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10423E4
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x104264C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10426A0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10427A4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBytesStorage
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x102DF14
	public void .ctor(DataColumn column) { }

	// RVA: 0x1042854
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1042A64
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1042A6C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1042A74
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1042AB8
	public override object Get(int record) { }

	// RVA: 0x1042AEC
	public override bool IsNull(int record) { }

	// RVA: 0x1042B28
	public override void Set(int record, object value) { }

	// RVA: 0x1042C54
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1042D18
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1042FE8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1043250
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10432A4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10433B0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlCharsStorage
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x102DFF0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1043460
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1043670
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1043678
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1043680
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10436C4
	public override object Get(int record) { }

	// RVA: 0x10436F8
	public override bool IsNull(int record) { }

	// RVA: 0x1043734
	public override void Set(int record, object value) { }

	// RVA: 0x1043860
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1043924
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1043C00
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1043E68
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1043EBC
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1043FC8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x102E0CC
	public void .ctor(DataColumn column) { }

	// RVA: 0x1044078
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1044688
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x104473C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1044804
	public override object ConvertValue(object value) { }

	// RVA: 0x1044894
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10448E8
	public override object Get(int record) { }

	// RVA: 0x1044980
	public override bool IsNull(int record) { }

	// RVA: 0x1044A0C
	public override void Set(int record, object value) { }

	// RVA: 0x1044A5C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1044B20
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1044DD8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1045040
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1045094
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10451B0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x102E208
	public void .ctor(DataColumn column) { }

	// RVA: 0x1045260
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1046164
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1046238
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1046318
	public override object ConvertValue(object value) { }

	// RVA: 0x10463A4
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10463F8
	public override object Get(int record) { }

	// RVA: 0x1046498
	public override bool IsNull(int record) { }

	// RVA: 0x1046524
	public override void Set(int record, object value) { }

	// RVA: 0x1046588
	public override void SetCapacity(int capacity) { }

	// RVA: 0x104664C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1046904
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1046B6C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1046BC0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1046CEC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x1046D9C
	public void .ctor(DataColumn column) { }

	// RVA: 0x1046EC8
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1047BC8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1047C70
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1047D30
	public override object ConvertValue(object value) { }

	// RVA: 0x1047DC0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1047E00
	public override object Get(int record) { }

	// RVA: 0x1047E8C
	public override bool IsNull(int record) { }

	// RVA: 0x1047F14
	public override void Set(int record, object value) { }

	// RVA: 0x1047F60
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1048024
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10482D0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1048534
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1048588
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x104869C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlGuidStorage
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x104874C
	public void .ctor(DataColumn column) { }

	// RVA: 0x1048878
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1048AC8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1048B6C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1048C2C
	public override object ConvertValue(object value) { }

	// RVA: 0x1048CBC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1048D04
	public override object Get(int record) { }

	// RVA: 0x1048D90
	public override bool IsNull(int record) { }

	// RVA: 0x1048E18
	public override void Set(int record, object value) { }

	// RVA: 0x1048E6C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1048F30
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10491DC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1049440
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1049494
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10495A0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt16Storage
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x1049650
	public void .ctor(DataColumn column) { }

	// RVA: 0x104977C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x104A5A0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x104A644
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x104A704
	public override object ConvertValue(object value) { }

	// RVA: 0x104A794
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x104A7D4
	public override object Get(int record) { }

	// RVA: 0x104A860
	public override bool IsNull(int record) { }

	// RVA: 0x104A8E8
	public override void Set(int record, object value) { }

	// RVA: 0x104A934
	public override void SetCapacity(int capacity) { }

	// RVA: 0x104A9F8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x104ACA4
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x104AF08
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x104AF5C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x104B060
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt32Storage
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x104B110
	public void .ctor(DataColumn column) { }

	// RVA: 0x104B23C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x104C030
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x104C0D4
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x104C194
	public override object ConvertValue(object value) { }

	// RVA: 0x104C224
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x104C264
	public override object Get(int record) { }

	// RVA: 0x104C2F0
	public override bool IsNull(int record) { }

	// RVA: 0x104C378
	public override void Set(int record, object value) { }

	// RVA: 0x104C3C4
	public override void SetCapacity(int capacity) { }

	// RVA: 0x104C488
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x104C734
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x104C998
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x104C9EC
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x104CAF0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt64Storage
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x104CBA0
	public void .ctor(DataColumn column) { }

	// RVA: 0x104CCCC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x104DBB4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x104DC5C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x104DD1C
	public override object ConvertValue(object value) { }

	// RVA: 0x104DDAC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x104DDEC
	public override object Get(int record) { }

	// RVA: 0x104DE78
	public override bool IsNull(int record) { }

	// RVA: 0x104DF00
	public override void Set(int record, object value) { }

	// RVA: 0x104DF4C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x104E010
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x104E2BC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x104E520
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x104E574
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x104E688
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x104E738
	public void .ctor(DataColumn column) { }

	// RVA: 0x104E864
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x104F74C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x104F7F4
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x104F8B4
	public override object ConvertValue(object value) { }

	// RVA: 0x104F944
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x104F984
	public override object Get(int record) { }

	// RVA: 0x104FA10
	public override bool IsNull(int record) { }

	// RVA: 0x104FA98
	public override void Set(int record, object value) { }

	// RVA: 0x104FAE4
	public override void SetCapacity(int capacity) { }

	// RVA: 0x104FBA8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x104FE54
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10500B8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x105010C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1050220
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlSingleStorage
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x10502D0
	public void .ctor(DataColumn column) { }

	// RVA: 0x10503FC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10511C0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1051264
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1051324
	public override object ConvertValue(object value) { }

	// RVA: 0x10513B4
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10513F4
	public override object Get(int record) { }

	// RVA: 0x1051480
	public override bool IsNull(int record) { }

	// RVA: 0x1051508
	public override void Set(int record, object value) { }

	// RVA: 0x1051554
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1051618
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10518C4
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1051B28
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1051B7C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1051C80
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlStringStorage
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x1051D30
	public void .ctor(DataColumn column) { }

	// RVA: 0x1051E68
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x105226C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x10522DC
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x1052498
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1052560
	public override object ConvertValue(object value) { }

	// RVA: 0x10525F8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x105264C
	public override object Get(int record) { }

	// RVA: 0x10526E0
	public override int GetStringLength(int record) { }

	// RVA: 0x10527D0
	public override bool IsNull(int record) { }

	// RVA: 0x105285C
	public override void Set(int record, object value) { }

	// RVA: 0x10528C8
	public override void SetCapacity(int capacity) { }

	// RVA: 0x105298C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1052C3C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1052EA0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1052EF4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x105301C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x10530CC
	public void .ctor(DataColumn column) { }

	// RVA: 0x10531F8
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1053674
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1053718
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x10537D8
	public override object ConvertValue(object value) { }

	// RVA: 0x1053868
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10538A8
	public override object Get(int record) { }

	// RVA: 0x1053934
	public override bool IsNull(int record) { }

	// RVA: 0x10539BC
	public override void Set(int record, object value) { }

	// RVA: 0x1053A08
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1053ACC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1053D78
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1053FDC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1054030
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1054134
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SingleStorage
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x10541E4
	public void .ctor(DataColumn column) { }

	// RVA: 0x10542B4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10549B0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1054A44
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1054B28
	public override object ConvertValue(object value) { }

	// RVA: 0x1054C78
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1054CDC
	public override object Get(int record) { }

	// RVA: 0x1054D48
	public override void Set(int record, object value) { }

	// RVA: 0x1054EE0
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1054FC0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1055048
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10550F0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1055144
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1055250
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x1055680
	public void .ctor() { }

	// RVA: 0x1056AF4
	internal object <GetStaticNullForUdtType>b__0(Type t) { }

}

// Namespace: System.Data.Common
internal sealed class SqlUdtStorage
{
	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly System.Collections.Concurrent.ConcurrentDictionary<System.Type,System.Object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x1055320
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x10554D8
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x10553A4
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x1055688
	public override bool IsNull(int record) { }

	// RVA: 0x10557AC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10557E4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1055820
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1055AE0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1055B74
	public override object Get(int recordNo) { }

	// RVA: 0x1055BA8
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1055D3C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1055E1C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x105612C
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x10563CC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10566A8
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1056810
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1056864
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10569A8
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1056A58
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class StringStorage
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x1056C2C
	public void .ctor(DataColumn column) { }

	// RVA: 0x1056CE8
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1056FB0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1057034
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x10570C8
	public override object ConvertValue(object value) { }

	// RVA: 0x10570F8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x105713C
	public override object Get(int recordNo) { }

	// RVA: 0x1057188
	public override int GetStringLength(int record) { }

	// RVA: 0x10571D0
	public override bool IsNull(int record) { }

	// RVA: 0x105720C
	public override void Set(int record, object value) { }

	// RVA: 0x1057298
	public override void SetCapacity(int capacity) { }

	// RVA: 0x105735C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1057364
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1057398
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10573EC
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10574F8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class TimeSpanStorage
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x10575A8
	public void .ctor(DataColumn column) { }

	// RVA: 0x10576CC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10582B8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1058488
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1058650
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x105880C
	public override object ConvertValue(object value) { }

	// RVA: 0x10588D4
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1058938
	public override object Get(int record) { }

	// RVA: 0x1058A6C
	public override void Set(int record, object value) { }

	// RVA: 0x1058B4C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1058C2C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1058CC0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1058D74
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1058DC8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1058ECC
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1058F9C
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class UInt16Storage
{
	// Fields
	private static readonly UInt16 s_defaultValue; // 0x0
	private UInt16[] _values; // 0x50

	// Methods

	// RVA: 0x1059018
	public void .ctor(DataColumn column) { }

	// RVA: 0x1059108
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10598F0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x10599C4
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1059AF8
	public override object ConvertValue(object value) { }

	// RVA: 0x1059C48
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1059CAC
	public override object Get(int record) { }

	// RVA: 0x1059D88
	public override void Set(int record, object value) { }

	// RVA: 0x1059F40
	public override void SetCapacity(int capacity) { }

	// RVA: 0x105A020
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x105A0A8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x105A150
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x105A1A4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x105A2A4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt32Storage
{
	// Fields
	private static readonly UInt32 s_defaultValue; // 0x0
	private UInt32[] _values; // 0x50

	// Methods

	// RVA: 0x105A374
	public void .ctor(DataColumn column) { }

	// RVA: 0x105A464
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x105AC50
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x105AD48
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x105AE7C
	public override object ConvertValue(object value) { }

	// RVA: 0x105AFCC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x105B030
	public override object Get(int record) { }

	// RVA: 0x105B10C
	public override void Set(int record, object value) { }

	// RVA: 0x105B2C4
	public override void SetCapacity(int capacity) { }

	// RVA: 0x105B3A4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x105B42C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x105B4D4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x105B528
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x105B628
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt64Storage
{
	// Fields
	private static readonly UInt64 s_defaultValue; // 0x0
	private UInt64[] _values; // 0x50

	// Methods

	// RVA: 0x105B6F8
	public void .ctor(DataColumn column) { }

	// RVA: 0x105B7E8
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x105BFE8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x105C0F8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x105C22C
	public override object ConvertValue(object value) { }

	// RVA: 0x105C37C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x105C3E0
	public override object Get(int record) { }

	// RVA: 0x105C4BC
	public override void Set(int record, object value) { }

	// RVA: 0x105C674
	public override void SetCapacity(int capacity) { }

	// RVA: 0x105C754
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x105C7DC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x105C884
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x105C8D8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x105C9D8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: 
private struct __StaticArrayInitTypeSize=36
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=38
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=52
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=64
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=152
{}

// Namespace: 
private struct __StaticArrayInitTypeSize=176
{}

// Namespace: 
internal sealed class <PrivateImplementationDetails>
{
	// Fields
	internal static readonly __StaticArrayInitTypeSize=152 39A47A6A540EB845B37C85CE8C346359A0DB937D4AAF7A74A6C207205E0BC61E; // 0x0
	internal static readonly __StaticArrayInitTypeSize=38 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D; // 0x98
	internal static readonly __StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA; // 0xBE
	internal static readonly __StaticArrayInitTypeSize=36 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD; // 0xF2
	internal static readonly __StaticArrayInitTypeSize=152 BA1E68F004F9EFDE72987E33682A8A5C579C4A609FBECE4F6EDBB844431D9226; // 0x116
	internal static readonly __StaticArrayInitTypeSize=152 C44E90B8C219817ECD3C403823D4770C0F744358EBF32A4282B3CE0338D4602E; // 0x1AE
	internal static readonly __StaticArrayInitTypeSize=152 D44900CF81FC3D53E7F8D2FCB6EF3B50B39ED1A857628FA737F5B4B7E0382939; // 0x246
	internal static readonly __StaticArrayInitTypeSize=176 E29424929B12EB1FDF4FD2E4911E09644CB58261C6033211F88022DDED785AE6; // 0x2DE
	internal static readonly __StaticArrayInitTypeSize=64 F327BBE8D18E0318C5295B25F9A8BA9B3AFE1F44C3C244BB3921AFEB578F1591; // 0x38E
	internal static readonly __StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315; // 0x3CE
}


