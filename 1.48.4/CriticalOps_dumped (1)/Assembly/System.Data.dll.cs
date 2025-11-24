// Namespace: 
internal class <Module> 
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute 
{
	// Methods

	// RVA: 0xECFCDC
	void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute 
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xECFCE4
	void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute 
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xECFD70
	void .ctor(Byte ) { }

}

// Namespace: 
internal static class SR 
{
	// Methods

	// RVA: 0xECFD9C
	string GetString(string name) { }

	// RVA: 0xECFDA0
	string Format(string resourceFormat, object p1) { }

	// RVA: 0xECFE14
	string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0xECFE98
	string Format(string resourceFormat, object p1, object p2, object p3) { }

}

// Namespace: System
internal static class LocalAppContextSwitches 
{
	// Fields
	private static int s_allowArbitraryTypeInstantiation; // 0x0

	// Methods

	// RVA: 0xECFF24
	bool get_AllowArbitraryTypeInstantiation() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.LocalAppContext.<>c <>9; // 0x0
	public static System.Func<System.Boolean> <>9__6_0; // 0x8

	// Methods

	// RVA: 0xED02F4
	void .cctor() { }

	// RVA: 0xED0360
	void .ctor() { }

	// RVA: 0xED0368
	bool <get_DisableCaching>b__6_0() { }

}

// Namespace: System
internal class LocalAppContext 
{
	// Fields
	private static bool s_isDisableCachingInitialized; // 0x0
	private static bool s_disableCaching; // 0x1
	private static object s_syncObject; // 0x8

	// Methods

	// RVA: 0xED0040
	bool GetCachedSwitchValue(string switchName, ref int switchValue) { }

	// RVA: 0xED011C
	bool GetCachedSwitchValueInternal(string switchName, ref int switchValue) { }

	// RVA: 0xED01BC
	bool get_DisableCaching() { }

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

	// RVA: 0xED03EC
	void .ctor() { }

	// RVA: 0xED080C
	void .ctor(string columnName, Type dataType) { }

	// RVA: 0xED0480
	void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0xED0A20
	void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0xED14F8
	bool get_AllowDBNull() { }

	// RVA: 0xED1500
	void set_AllowDBNull(bool value) { }

	// RVA: 0xED1AC8
	bool get_AutoIncrement() { }

	// RVA: 0xED1AE8
	void set_AutoIncrement(bool value) { }

	// RVA: 0xED2CE0
	object get_AutoIncrementCurrent() { }

	// RVA: 0xED2D74
	void set_AutoIncrementCurrent(object value) { }

	// RVA: 0xED2B54
	AutoIncrementValue get_AutoInc() { }

	// RVA: 0xED2D5C
	Int64 get_AutoIncrementSeed() { }

	// RVA: 0xED3054
	void set_AutoIncrementSeed(Int64 value) { }

	// RVA: 0xED316C
	Int64 get_AutoIncrementStep() { }

	// RVA: 0xED3188
	void set_AutoIncrementStep(Int64 value) { }

	// RVA: 0xED32C0
	string get_Caption() { }

	// RVA: 0xED32DC
	void set_Caption(string value) { }

	// RVA: 0xED3484
	string get_ColumnName() { }

	// RVA: 0xED348C
	void set_ColumnName(string value) { }

	// RVA: 0xED3A68
	string get_EncodedColumnName() { }

	// RVA: 0xED2F40
	IFormatProvider get_FormatProvider() { }

	// RVA: 0xED3404
	CultureInfo get_Locale() { }

	// RVA: 0xED3B04
	int get_ObjectID() { }

	// RVA: 0xED3B0C
	string get_Prefix() { }

	// RVA: 0xED3B14
	void set_Prefix(string value) { }

	// RVA: 0xED3DD8
	string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0xED3F8C
	bool get_Computed() { }

	// RVA: 0xED3F9C
	DataExpression get_DataExpression() { }

	// RVA: 0xED3FA4
	Type get_DataType() { }

	// RVA: 0xED21E4
	void set_DataType(Type value) { }

	// RVA: 0xED4BE0
	DataSetDateTime get_DateTimeMode() { }

	// RVA: 0xED4BE8
	void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0xED42EC
	object get_DefaultValue() { }

	// RVA: 0xED44B4
	void set_DefaultValue(object value) { }

	// RVA: 0xED513C
	bool get_DefaultValueIsNull() { }

	// RVA: 0xED5144
	void BindExpression() { }

	// RVA: 0xED516C
	string get_Expression() { }

	// RVA: 0xED0B58
	void set_Expression(string value) { }

	// RVA: 0xED5914
	PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xED20C4
	bool get_HasData() { }

	// RVA: 0xED59A0
	bool get_ImplementsINullable() { }

	// RVA: 0xED59A8
	bool get_ImplementsIChangeTracking() { }

	// RVA: 0xED59B0
	bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0xED59B8
	bool get_IsValueType() { }

	// RVA: 0xED59D8
	bool get_IsSqlType() { }

	// RVA: 0xED59E0
	void SetMaxLengthSimpleType() { }

	// RVA: 0xED5ACC
	int get_MaxLength() { }

	// RVA: 0xED5AD4
	void set_MaxLength(int value) { }

	// RVA: 0xED64E0
	string get_Namespace() { }

	// RVA: 0xED6568
	void set_Namespace(string value) { }

	// RVA: 0xED68D0
	int get_Ordinal() { }

	// RVA: 0xED68D8
	void SetOrdinalInternal(int ordinal) { }

	// RVA: 0xED6A2C
	bool get_ReadOnly() { }

	// RVA: 0xED5378
	void set_ReadOnly(bool value) { }

	// RVA: 0xED6AD0
	Index get_SortIndex() { }

	// RVA: 0xED6BD4
	DataTable get_Table() { }

	// RVA: 0xED6BDC
	void SetTable(DataTable table) { }

	// RVA: 0xED6CC0
	DataRow GetDataRow(int index) { }

	// RVA: 0xED3EAC
	object get_Item(int record) { }

	// RVA: 0xED6CE8
	void set_Item(int record, object value) { }

	// RVA: 0xED57E4
	void InitializeRecord(int record) { }

	// RVA: 0xED7000
	void SetValue(int record, object value) { }

	// RVA: 0xED7134
	void FreeRecord(int record) { }

	// RVA: 0xED715C
	bool get_Unique() { }

	// RVA: 0xED7164
	void set_Unique(bool value) { }

	// RVA: 0xED7730
	void InternalUnique(bool value) { }

	// RVA: 0xED7738
	string get_XmlDataType() { }

	// RVA: 0xED7740
	void set_XmlDataType(string value) { }

	// RVA: 0xED7748
	SimpleType get_SimpleType() { }

	// RVA: 0xED09C0
	void set_SimpleType(SimpleType value) { }

	// RVA: 0xED7750
	MappingType get_ColumnMapping() { }

	// RVA: 0xED7758
	void set_ColumnMapping(MappingType value) { }

	// RVA: 0xED7D14
	void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xED6034
	bool CheckMaxLength() { }

	// RVA: 0xED7DE8
	void CheckMaxLength(DataRow dr) { }

	// RVA: 0xED16A0
	void CheckNotAllowNull() { }

	// RVA: 0xED7D6C
	void CheckNullable(DataRow row) { }

	// RVA: 0xED76D8
	void CheckUnique() { }

	// RVA: 0xED82D0
	int Compare(int record1, int record2) { }

	// RVA: 0xED82F4
	bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0xED84F8
	int CompareValueTo(int record1, object value) { }

	// RVA: 0xED851C
	object ConvertValue(object value) { }

	// RVA: 0xED8540
	void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0xED8564
	DataColumn Clone() { }

	// RVA: 0xED8C80
	object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0xED7E64
	int GetStringLength(int record) { }

	// RVA: 0xED8D64
	void Init(int record) { }

	// RVA: 0xED1DE4
	bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0xED8DFC
	bool get_IsCustomType() { }

	// RVA: 0xED8E88
	bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0xED8F80
	bool get_ImplementsIXMLSerializable() { }

	// RVA: 0xED40CC
	bool IsInRelation() { }

	// RVA: 0xED8F88
	bool IsMaxLengthViolated() { }

	// RVA: 0xED9674
	bool IsNotAllowDBNullViolated() { }

	// RVA: 0xED9928
	void FinishInitInProgress() { }

	// RVA: 0xED9944
	void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xED39EC
	void RaisePropertyChanging(string name) { }

	// RVA: 0xED9968
	void InsureStorage() { }

	// RVA: 0xED9A08
	void SetCapacity(int capacity) { }

	// RVA: 0xED9AC4
	void OnSetDataSet() { }

	// RVA: 0xED9AC8
	string ToString() { }

	// RVA: 0xED9B8C
	object ConvertXmlToObject(string s) { }

	// RVA: 0xED9C48
	object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xED3ED0
	string ConvertObjectToXml(object value) { }

	// RVA: 0xED9D0C
	void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xED9DE0
	object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0xED9E94
	void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xED9EB4
	void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xED9F70
	void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xEDA040
	void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xED56A0
	void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

}

// Namespace: System.Data
internal abstract class AutoIncrementValue 
{
	// Fields
	private bool <Auto>k__BackingField; // 0x10

	// Methods

	// RVA: 0xEDA0E4
	bool get_Auto() { }

	// RVA: 0xEDA0EC
	void set_Auto(bool value) { }

	// RVA: 0x2FE360C
	object get_Current() { }

	// RVA: 0x2FE4574
	void set_Current(object value) { }

	// RVA: 0x2FE34E0
	Int64 get_Seed() { }

	// RVA: -1
	void set_Seed(Int64 value) { }

	// RVA: 0x2FE34E0
	Int64 get_Step() { }

	// RVA: -1
	void set_Step(Int64 value) { }

	// RVA: 0x2FE360C
	Type get_DataType() { }

	// RVA: 0x2FE47D4
	void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x2FE4574
	void SetCurrentAndIncrement(object value) { }

	// RVA: 0x2FE41A8
	void MoveAfter() { }

	// RVA: 0xED8B0C
	AutoIncrementValue Clone() { }

	// RVA: 0xEDA0F4
	void .ctor() { }

}

// Namespace: System.Data
internal sealed class AutoIncrementInt64 
{
	// Fields
	private Int64 _current; // 0x18
	private Int64 _seed; // 0x20
	private Int64 _step; // 0x28

	// Methods

	// RVA: 0xEDA0FC
	object get_Current() { }

	// RVA: 0xEDA164
	void set_Current(object value) { }

	// RVA: 0xEDA1E8
	Type get_DataType() { }

	// RVA: 0xEDA288
	Int64 get_Seed() { }

	// RVA: 0xEDA290
	void set_Seed(Int64 value) { }

	// RVA: 0xEDA44C
	Int64 get_Step() { }

	// RVA: 0xEDA454
	void set_Step(Int64 value) { }

	// RVA: 0xEDA570
	void MoveAfter() { }

	// RVA: 0xEDA584
	void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xEDA604
	void SetCurrentAndIncrement(object value) { }

	// RVA: 0xEDA33C
	bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xED2FC0
	void .ctor() { }

}

// Namespace: System.Data
internal sealed class AutoIncrementBigInteger 
{
	// Fields
	private BigInteger _current; // 0x18
	private Int64 _seed; // 0x28
	private BigInteger _step; // 0x30

	// Methods

	// RVA: 0xEDA770
	object get_Current() { }

	// RVA: 0xEDA7D8
	void set_Current(object value) { }

	// RVA: 0xEDA864
	Type get_DataType() { }

	// RVA: 0xEDA904
	Int64 get_Seed() { }

	// RVA: 0xEDA90C
	void set_Seed(Int64 value) { }

	// RVA: 0xEDABA4
	Int64 get_Step() { }

	// RVA: 0xEDAC10
	void set_Step(Int64 value) { }

	// RVA: 0xEDAE08
	void MoveAfter() { }

	// RVA: 0xEDAEA8
	void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xEDAEE4
	void SetCurrentAndIncrement(object value) { }

	// RVA: 0xEDAA28
	bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xED2FD0
	void .ctor() { }

}

// Namespace: System.Data
public class DataException 
{
	// Methods

	// RVA: 0xEDAFD0
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDAFD8
	void .ctor() { }

	// RVA: 0xEDB040
	void .ctor(string s) { }

	// RVA: 0xEDB070
	void .ctor(string s, Exception innerException) { }

}

// Namespace: System.Data
public class ConstraintException 
{
	// Methods

	// RVA: 0xEDB078
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB080
	void .ctor() { }

	// RVA: 0xEDB0E8
	void .ctor(string s) { }

}

// Namespace: System.Data
public class DeletedRowInaccessibleException 
{
	// Methods

	// RVA: 0xEDB118
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB120
	void .ctor() { }

	// RVA: 0xEDB188
	void .ctor(string s) { }

}

// Namespace: System.Data
public class DuplicateNameException 
{
	// Methods

	// RVA: 0xEDB1B8
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB1C0
	void .ctor() { }

	// RVA: 0xEDB228
	void .ctor(string s) { }

}

// Namespace: System.Data
public class InRowChangingEventException 
{
	// Methods

	// RVA: 0xEDB258
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB260
	void .ctor() { }

	// RVA: 0xEDB2C8
	void .ctor(string s) { }

}

// Namespace: System.Data
public class InvalidConstraintException 
{
	// Methods

	// RVA: 0xEDB2F8
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB300
	void .ctor() { }

	// RVA: 0xEDB368
	void .ctor(string s) { }

}

// Namespace: System.Data
public class NoNullAllowedException 
{
	// Methods

	// RVA: 0xEDB398
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB3A0
	void .ctor() { }

	// RVA: 0xEDB408
	void .ctor(string s) { }

}

// Namespace: System.Data
public class ReadOnlyException 
{
	// Methods

	// RVA: 0xEDB438
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB440
	void .ctor() { }

	// RVA: 0xEDB4A8
	void .ctor(string s) { }

}

// Namespace: System.Data
public class RowNotInTableException 
{
	// Methods

	// RVA: 0xEDB4D8
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB4E0
	void .ctor() { }

	// RVA: 0xEDB548
	void .ctor(string s) { }

}

// Namespace: System.Data
public class VersionNotFoundException 
{
	// Methods

	// RVA: 0xEDB578
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB580
	void .ctor() { }

	// RVA: 0xEDB5E8
	void .ctor(string s) { }

}

// Namespace: System.Data
internal static class ExceptionBuilder 
{
	// Methods

	// RVA: 0xEDB618
	void TraceException(string trace, Exception e) { }

	// RVA: 0xEDB6C0
	Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0xED5490
	Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0xED5824
	Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0xEDB7B0
	Exception _Argument(string error) { }

	// RVA: 0xEDB818
	Exception _Argument(string paramName, string error) { }

	// RVA: 0xEDB880
	Exception _Argument(string error, Exception innerException) { }

	// RVA: 0xEDB8F0
	Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0xEDB960
	Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0xEDB9D0
	Exception _IndexOutOfRange(string error) { }

	// RVA: 0xEDBA38
	Exception _InvalidOperation(string error) { }

	// RVA: 0xEDBAA0
	Exception _InvalidEnumArgumentException(string error) { }

	// RVA: 0x309AF8C
	Exception _InvalidEnumArgumentException(T value) { }

	// RVA: 0xEDBB08
	void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0xEDBB60
	Exception _Data(string error) { }

	// RVA: 0xEDBBD4
	Exception _Constraint(string error) { }

	// RVA: 0xEDBC48
	Exception _InvalidConstraint(string error) { }

	// RVA: 0xEDBCBC
	Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0xEDBD30
	Exception _DuplicateName(string error) { }

	// RVA: 0xEDBDA4
	Exception _InRowChangingEvent(string error) { }

	// RVA: 0xEDBE18
	Exception _NoNullAllowed(string error) { }

	// RVA: 0xEDBE8C
	Exception _ReadOnly(string error) { }

	// RVA: 0xEDBF00
	Exception _RowNotInTable(string error) { }

	// RVA: 0xEDBF74
	Exception _VersionNotFound(string error) { }

	// RVA: 0xED0818
	Exception ArgumentNull(string paramName) { }

	// RVA: 0xEDBFE8
	Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0xEDC0FC
	Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0xEDC20C
	Exception ArgumentContainsNull(string paramName) { }

	// RVA: 0xEDC31C
	Exception TypeNotAllowed(Type type) { }

	// RVA: 0xEDC424
	Exception CannotModifyCollection() { }

	// RVA: 0xEDC4B4
	Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0xEDC5C4
	Exception NamespaceNameConflict(string name) { }

	// RVA: 0xEDC6D4
	Exception InvalidOffsetLength() { }

	// RVA: 0xEDC764
	Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0xEDC884
	Exception ColumnNotInAnyTable() { }

	// RVA: 0xEDC914
	Exception ColumnOutOfRange(int index) { }

	// RVA: 0xEDCA40
	Exception ColumnOutOfRange(string column) { }

	// RVA: 0xEDCB50
	Exception CannotAddColumn1(string column) { }

	// RVA: 0xEDCC60
	Exception CannotAddColumn2(string column) { }

	// RVA: 0xED7B74
	Exception CannotAddColumn3() { }

	// RVA: 0xED7C04
	Exception CannotAddColumn4(string column) { }

	// RVA: 0xEDCD70
	Exception CannotAddDuplicate(string column) { }

	// RVA: 0xEDCE8C
	Exception CannotAddDuplicate2(string table) { }

	// RVA: 0xEDCFA8
	Exception CannotAddDuplicate3(string table) { }

	// RVA: 0xEDD0C4
	Exception CannotRemoveColumn() { }

	// RVA: 0xEDD154
	Exception CannotRemovePrimaryKey() { }

	// RVA: 0xEDD1E4
	Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0xEDD2F4
	Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0xEDD414
	Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0xEDD534
	Exception AddPrimaryKeyConstraint() { }

	// RVA: 0xEDD5C4
	Exception NoConstraintName() { }

	// RVA: 0xEDD654
	Exception ConstraintViolation(string constraint) { }

	// RVA: 0xEDD770
	string KeysToString(object[] keys) { }

	// RVA: 0xEDD890
	string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0xEDDAA4
	Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0xEDDB1C
	Exception ConstraintOutOfRange(int index) { }

	// RVA: 0xEDDC48
	Exception DuplicateConstraint(string constraint) { }

	// RVA: 0xEDDD64
	Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0xEDDE80
	Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0xEDDFAC
	Exception UniqueConstraintViolation() { }

	// RVA: 0xEDE03C
	Exception ConstraintForeignTable() { }

	// RVA: 0xEDE0CC
	Exception ConstraintParentValues() { }

	// RVA: 0xEDE15C
	Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0xEDE25C
	Exception ConstraintRemoveFailed() { }

	// RVA: 0xEDE2EC
	Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0xEDE408
	Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0xEDE524
	Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0xEDE658
	Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0xEDE768
	Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0xED95B0
	string MaxLengthViolationText(string columnName) { }

	// RVA: 0xED9864
	string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0xEDE878
	Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0xED1CC4
	Exception AutoIncrementAndExpression() { }

	// RVA: 0xED1D54
	Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0xEDA4E0
	Exception AutoIncrementSeed() { }

	// RVA: 0xED3FAC
	Exception CantChangeDataType() { }

	// RVA: 0xED403C
	Exception NullDataType() { }

	// RVA: 0xED395C
	Exception ColumnNameRequired() { }

	// RVA: 0xED4F60
	Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0xED4890
	Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xED4FF0
	Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xED51CC
	Exception ExpressionAndUnique() { }

	// RVA: 0xED5580
	Exception ExpressionAndReadOnly() { }

	// RVA: 0xED525C
	Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0xEDE988
	Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0xED5610
	Exception ExpressionCircular() { }

	// RVA: 0xED81B4
	Exception NonUniqueValues(string column) { }

	// RVA: 0xED7F7C
	Exception NullKeyValues(string column) { }

	// RVA: 0xED8098
	Exception NullValues(string column) { }

	// RVA: 0xED6A34
	Exception ReadOnlyAndExpression() { }

	// RVA: 0xEDEA7C
	Exception ReadOnly(string column) { }

	// RVA: 0xED7648
	Exception UniqueAndExpression() { }

	// RVA: 0xED6E8C
	Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0xEDEB98
	Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0xED7E88
	Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0xED6398
	Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0xED5E4C
	Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0xED4AC0
	Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0xED7A54
	Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0xED67C0
	Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0xED5F40
	Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0xED20D4
	Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0xEDEC8C
	Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0xEDED9C
	Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0xEDEEB8
	Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0xEDEFC8
	Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0xED4D18
	Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0xED4EFC
	Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0xED4DA8
	Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0xED092C
	Exception ColumnTypeNotSupported() { }

	// RVA: 0xEDF0D0
	Exception SetFailed(string name) { }

	// RVA: 0xEDF1EC
	Exception SetRowStateFilter() { }

	// RVA: 0xEDF288
	Exception CanNotUseDataViewManager() { }

	// RVA: 0xEDF324
	Exception CanNotSetTable() { }

	// RVA: 0xEDF3C0
	Exception CanNotUse() { }

	// RVA: 0xEDF45C
	Exception CanNotBindTable() { }

	// RVA: 0xEDF4F8
	Exception SetTable() { }

	// RVA: 0xEDF594
	Exception SetIListObject() { }

	// RVA: 0xEDF624
	Exception AddNewNotAllowNull() { }

	// RVA: 0xEDF6C0
	Exception NotOpen() { }

	// RVA: 0xEDF75C
	Exception CreateChildView() { }

	// RVA: 0xEDF7EC
	Exception CanNotDelete() { }

	// RVA: 0xEDF888
	Exception GetElementIndex(int index) { }

	// RVA: 0xEDF9B4
	Exception AddExternalObject() { }

	// RVA: 0xEDFA44
	Exception CanNotClear() { }

	// RVA: 0xEDFAD4
	Exception InsertExternalObject() { }

	// RVA: 0xEDFB64
	Exception RemoveExternalObject() { }

	// RVA: 0xEDFBF4
	Exception ColumnToSortIsOutOfRange(string column) { }

	// RVA: 0xEDFD04
	Exception KeyTableMismatch() { }

	// RVA: 0xEDFDA0
	Exception KeyNoColumns() { }

	// RVA: 0xEDFE3C
	Exception KeyTooManyColumns(int cols) { }

	// RVA: 0xEDFF74
	Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0xEE0090
	Exception RelationDataSetMismatch() { }

	// RVA: 0xED4250
	Exception ColumnsTypeMismatch() { }

	// RVA: 0xEE012C
	Exception KeyLengthMismatch() { }

	// RVA: 0xEE01BC
	Exception KeyLengthZero() { }

	// RVA: 0xEE024C
	Exception ForeignRelation() { }

	// RVA: 0xEE02DC
	Exception KeyColumnsIdentical() { }

	// RVA: 0xEE0378
	Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0xEE04A4
	Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xEE05D0
	Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xEE06FC
	Exception RelationForeignRow() { }

	// RVA: 0xEE078C
	Exception RelationNestedReadOnly() { }

	// RVA: 0xEE081C
	Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0xEE092C
	Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0xEE0A3C
	Exception RelationDoesNotExist() { }

	// RVA: 0xEE0ACC
	Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0xEE0B68
	Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0xEE0C78
	Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0xEE0D88
	Exception RowNotInTheDataSet() { }

	// RVA: 0xEE0E18
	Exception RowNotInTheTable() { }

	// RVA: 0xEE0EB4
	Exception EditInRowChanging() { }

	// RVA: 0xEE0F50
	Exception EndEditInRowChanging() { }

	// RVA: 0xEE0FEC
	Exception BeginEditInRowChanging() { }

	// RVA: 0xEE1088
	Exception CancelEditInRowChanging() { }

	// RVA: 0xEE1124
	Exception DeleteInRowDeleting() { }

	// RVA: 0xEE11C0
	Exception ValueArrayLength() { }

	// RVA: 0xEE1250
	Exception NoCurrentData() { }

	// RVA: 0xEE12EC
	Exception NoOriginalData() { }

	// RVA: 0xEE1388
	Exception NoProposedData() { }

	// RVA: 0xEE1424
	Exception RowRemovedFromTheTable() { }

	// RVA: 0xEE14C0
	Exception DeletedRowInaccessible() { }

	// RVA: 0xEE155C
	Exception RowAlreadyDeleted() { }

	// RVA: 0xEE15F8
	Exception RowEmpty() { }

	// RVA: 0xEE1688
	Exception InvalidRowVersion() { }

	// RVA: 0xEE1724
	Exception RowOutOfRange(int index) { }

	// RVA: 0xEE1850
	Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0xEE198C
	Exception RowInsertMissing(string tableName) { }

	// RVA: 0xEE1A9C
	Exception RowAlreadyRemoved() { }

	// RVA: 0xEE1B38
	Exception MultipleParents() { }

	// RVA: 0xEE1BD4
	Exception InvalidRowState(DataRowState state) { }

	// RVA: 0xEE1C38
	Exception InvalidRowBitPattern() { }

	// RVA: 0xEE1CC8
	Exception SetDataSetNameToEmpty() { }

	// RVA: 0xEE1D58
	Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0xEE1E68
	Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0xEE1F78
	Exception MergeMissingDefinition(string obj) { }

	// RVA: 0xEE2088
	Exception TablesInDifferentSets() { }

	// RVA: 0xEE2118
	Exception RelationAlreadyExists() { }

	// RVA: 0xEE21A8
	Exception RowAlreadyInOtherCollection() { }

	// RVA: 0xEE2238
	Exception RowAlreadyInTheCollection() { }

	// RVA: 0xEE22C8
	Exception RecordStateRange() { }

	// RVA: 0xEE2358
	Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0xEE24FC
	Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0xEE2644
	Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0xEE26D4
	Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0xEE2764
	Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0xEE2874
	Exception RelationOutOfRange(object index) { }

	// RVA: 0xEE2994
	Exception DuplicateRelation(string relation) { }

	// RVA: 0xEE2AB0
	Exception RelationTableNull() { }

	// RVA: 0xEE2B40
	Exception RelationDataSetNull() { }

	// RVA: 0xEE2BD0
	Exception RelationTableWasRemoved() { }

	// RVA: 0xEE2C60
	Exception ParentTableMismatch() { }

	// RVA: 0xEE2CF0
	Exception ChildTableMismatch() { }

	// RVA: 0xEE2D80
	Exception EnforceConstraint() { }

	// RVA: 0xEE2E1C
	Exception CaseLocaleMismatch() { }

	// RVA: 0xEE2EAC
	Exception CannotChangeCaseLocale() { }

	// RVA: 0xEE2F40
	Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0xEE2FD8
	Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0xEE303C
	Exception TableForeignPrimaryKey() { }

	// RVA: 0xEE30CC
	Exception TableCannotAddToSimpleContent() { }

	// RVA: 0xEE315C
	Exception NoTableName() { }

	// RVA: 0xEE31EC
	Exception MultipleTextOnlyColumns() { }

	// RVA: 0xEE327C
	Exception InvalidSortString(string sort) { }

	// RVA: 0xEE338C
	Exception DuplicateTableName(string table) { }

	// RVA: 0xEE34A8
	Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0xEE35D4
	Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0xEE36F0
	Exception DatasetConflictingName(string table) { }

	// RVA: 0xEE380C
	Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0xEE389C
	Exception TableAlreadyInTheDataSet() { }

	// RVA: 0xEE392C
	Exception TableOutOfRange(int index) { }

	// RVA: 0xEE3A58
	Exception TableNotInTheDataSet(string table) { }

	// RVA: 0xEE3B68
	Exception TableInRelation() { }

	// RVA: 0xEE3BF8
	Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0xEE3D14
	Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0xEE3DA4
	Exception CanNotRemoteDataTable() { }

	// RVA: 0xEE3E34
	Exception CanNotSetRemotingFormat() { }

	// RVA: 0xEE3EC4
	Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0xEE3F54
	Exception TableNotFound(string tableName) { }

	// RVA: 0xEE4064
	Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0xEE41C4
	Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0xEE42F8
	Exception RangeArgument(int min, int max) { }

	// RVA: 0xEE444C
	Exception NullRange() { }

	// RVA: 0xEE44E8
	Exception NegativeMinimumCapacity() { }

	// RVA: 0xEE4578
	Exception ProblematicChars(Char charValue) { }

	// RVA: 0xEE46EC
	Exception StorageSetFailed() { }

	// RVA: 0xEE477C
	Exception SimpleTypeNotSupported() { }

	// RVA: 0xEE4818
	Exception MissingAttribute(string attribute) { }

	// RVA: 0xEE4874
	Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0xEE49A0
	Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0xEE4ACC
	Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0xEE4C00
	Exception ElementTypeNotFound(string name) { }

	// RVA: 0xEE4D1C
	Exception RelationParentNameMissing(string rel) { }

	// RVA: 0xEE4E38
	Exception RelationChildNameMissing(string rel) { }

	// RVA: 0xEE4F54
	Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0xEE5070
	Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0xEE518C
	Exception UndefinedDatatype(string name) { }

	// RVA: 0xEE52A8
	Exception DatatypeNotDefined() { }

	// RVA: 0xEE5344
	Exception MismatchKeyLength() { }

	// RVA: 0xEE53E0
	Exception InvalidField(string name) { }

	// RVA: 0xEE54FC
	Exception InvalidSelector(string name) { }

	// RVA: 0xEE5618
	Exception CircularComplexType(string name) { }

	// RVA: 0xEE5734
	Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0xEE5850
	Exception InvalidKey(string name) { }

	// RVA: 0xEE596C
	Exception DiffgramMissingTable(string name) { }

	// RVA: 0xEE5A88
	Exception DiffgramMissingSQL() { }

	// RVA: 0xEE5B24
	Exception DuplicateConstraintRead(string str) { }

	// RVA: 0xEE5C40
	Exception ColumnTypeConflict(string name) { }

	// RVA: 0xEE5D5C
	Exception CannotConvert(string name, string type) { }

	// RVA: 0xEE5E88
	Exception MissingRefer(string name) { }

	// RVA: 0xED3CBC
	Exception InvalidPrefix(string name) { }

	// RVA: 0xEE5FBC
	Exception CanNotDeserializeObjectType() { }

	// RVA: 0xEE604C
	Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0xEE60E8
	Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0xEE6184
	Exception NestedCircular(string name) { }

	// RVA: 0xEE62A0
	Exception MultipleParentRows(string tableQName) { }

	// RVA: 0xEE63BC
	Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0xEE64CC
	Exception DataTableInferenceNotSupported() { }

	// RVA: 0xEE655C
	void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0xEE65F8
	Exception DuplicateDeclaration(string name) { }

	// RVA: 0xEE6714
	Exception FoundEntity() { }

	// RVA: 0xEE67B0
	Exception MergeFailed(string name) { }

	// RVA: 0xEE6824
	Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0xEE6964
	Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0xEE6A84
	Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0xEE6BA0
	Exception EnumeratorModified() { }

}

// Namespace: System.Data
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

	// RVA: 0xEE6C30
	void .ctor() { }

	// RVA: 0xEE6F20
	void .ctor(string dataSetName) { }

	// RVA: 0xEE7124
	SerializationFormat get_RemotingFormat() { }

	// RVA: 0xEE712C
	void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xEE71D8
	SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0xEE71E0
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEE71E8
	void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0xEE7450
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEE7A74
	void InitializeDerivedDataSet() { }

	// RVA: 0xEE7458
	void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xEE73FC
	void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xEE87F4
	void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xEE8CFC
	void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xEE7A78
	void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEE8ED4
	void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEE7C40
	void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEE91D4
	void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEEA56C
	void FailedEnableConstraints() { }

	// RVA: 0xEEA728
	bool get_CaseSensitive() { }

	// RVA: 0xEEA730
	void set_CaseSensitive(bool value) { }

	// RVA: 0xEEAE74
	bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xEEAE7C
	DataViewManager get_DefaultViewManager() { }

	// RVA: 0xEEAFC8
	bool get_EnforceConstraints() { }

	// RVA: 0xEEA5A0
	void set_EnforceConstraints(bool value) { }

	// RVA: 0xEEB728
	void RestoreEnforceConstraints(bool value) { }

	// RVA: 0xEEAFD0
	void EnableConstraints() { }

	// RVA: 0xEEB730
	string get_DataSetName() { }

	// RVA: 0xEE6F4C
	void set_DataSetName(string value) { }

	// RVA: 0xEEB7B4
	string get_Namespace() { }

	// RVA: 0xEEB7BC
	void set_Namespace(string value) { }

	// RVA: 0xEEBD1C
	string get_Prefix() { }

	// RVA: 0xEEBD24
	void set_Prefix(string value) { }

	// RVA: 0xEEA4E0
	PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xEEBEE0
	bool get_IsInitialized() { }

	// RVA: 0xEEBEF0
	CultureInfo get_Locale() { }

	// RVA: 0xEEBEF8
	void set_Locale(CultureInfo value) { }

	// RVA: 0xEEC0A0
	void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0xEECCB0
	bool ShouldSerializeLocale() { }

	// RVA: 0xEECCB8
	ISite get_Site() { }

	// RVA: 0xEECCC0
	void set_Site(ISite value) { }

	// RVA: 0xEECEA0
	DataRelationCollection get_Relations() { }

	// RVA: 0xEECEA8
	DataTableCollection get_Tables() { }

	// RVA: 0xEECEB0
	void add_Initialized(EventHandler value) { }

	// RVA: 0xEECF54
	void remove_Initialized(EventHandler value) { }

	// RVA: 0xEECFF8
	void BeginInit() { }

	// RVA: 0xEED004
	void EndInit() { }

	// RVA: 0xEED234
	void Clear() { }

	// RVA: 0xEED47C
	DataSet Clone() { }

	// RVA: 0xEE84A8
	int EstimatedXmlStringSize() { }

	// RVA: 0xEEE57C
	IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xEEE580
	string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0xEE8310
	string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0xEEE6B8
	void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0xEE9AB0
	void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xEEEC1C
	bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xEEF18C
	void MoveToElement(XmlReader reader) { }

	// RVA: 0xEEECE8
	void ReadEndElement(XmlReader reader) { }

	// RVA: 0xEEE81C
	void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xEEE6C0
	void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xEEF220
	void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xEEF470
	XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0xEEF478
	XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xEEEDC0
	void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0xEF1DA4
	bool IsEmpty() { }

	// RVA: 0xEF0808
	void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xEEA4D8
	XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0xEF2224
	XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xEE85C8
	void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0xEF2098
	void Merge(DataSet dataSet) { }

	// RVA: 0xEF31C0
	void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xEF3444
	void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xEF3468
	void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0xEF34CC
	void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xEF35BC
	void OnDataRowCreated(DataRow row) { }

	// RVA: 0xEED458
	void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0xEED1A4
	void OnInitialized() { }

	// RVA: 0xEF35E0
	void OnRemoveTable(DataTable table) { }

	// RVA: 0xEF35E4
	void OnRemovedTable(DataTable table) { }

	// RVA: 0xEF3614
	void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xEF3618
	void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0xEEB738
	void RaisePropertyChanging(string name) { }

	// RVA: 0xEF3628
	DataTable[] TopLevelTables() { }

	// RVA: 0xEF3630
	DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0xEF396C
	void Reset() { }

	// RVA: 0xEEAA2C
	bool ValidateCaseConstraint() { }

	// RVA: 0xEEC800
	bool ValidateLocaleConstraint() { }

	// RVA: 0xEF3C50
	DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	// RVA: 0xEF3D78
	void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xEF4100
	XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xEF438C
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xEF4560
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xEF47B4
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEF47EC
	string get_MainTableName() { }

	// RVA: 0xEF47F4
	void set_MainTableName(string value) { }

	// RVA: 0xEF47FC
	int get_ObjectID() { }

}

// Namespace: 
internal struct RowDiffIdUsageSection 
{
	// Fields
	private DataTable _targetTable; // 0x10

	// Methods

	// RVA: 0xEF4804
	void Prepare(DataTable table) { }

}

// Namespace: 
internal struct DSRowDiffIdUsageSection 
{
	// Fields
	private DataSet _targetDS; // 0x10

	// Methods

	// RVA: 0xEF0784
	void Prepare(DataSet ds) { }

}

// Namespace: System.Data
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

	// RVA: 0xEB37C4
	void .ctor() { }

	// RVA: 0xEB3DA8
	void .ctor(string tableName) { }

	// RVA: 0xEB3E1C
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEB4378
	void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEB4474
	void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xEB3FD8
	void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xEB484C
	void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xEB5CD0
	void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xEB8FB8
	void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xEBA008
	void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xEBAD8C
	void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEBAF68
	void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEB559C
	void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEB6C3C
	void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEBB424
	DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0xEBB138
	void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xEBB50C
	void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xEBB7FC
	bool get_CaseSensitive() { }

	// RVA: 0xEBB804
	void set_CaseSensitive(bool value) { }

	// RVA: 0xEBB8A4
	bool get_AreIndexEventsSuspended() { }

	// RVA: 0xEBB8B4
	void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0xEBBD08
	void SuspendIndexEvents() { }

	// RVA: 0xEBBDEC
	bool get_IsInitialized() { }

	// RVA: 0xEBBDFC
	bool get_IsTypedDataTable() { }

	// RVA: 0xEB96F4
	bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0xEBBECC
	bool ShouldSerializeCaseSensitive() { }

	// RVA: 0xEBBED4
	bool get_SelfNested() { }

	// RVA: 0xEBC300
	System.Collections.Generic.List<System.Data.Index> get_LiveIndexes() { }

	// RVA: 0xEBC3D0
	SerializationFormat get_RemotingFormat() { }

	// RVA: 0xEBC3D8
	void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xEBC444
	int get_UKColumnPositionForInference() { }

	// RVA: 0xEBC44C
	void set_UKColumnPositionForInference(int value) { }

	// RVA: 0xEBC454
	DataRelationCollection get_ChildRelations() { }

	// RVA: 0xEBC4FC
	DataColumnCollection get_Columns() { }

	// RVA: 0xEBC504
	CompareInfo get_CompareInfo() { }

	// RVA: 0xEBC568
	ConstraintCollection get_Constraints() { }

	// RVA: 0xEBC570
	void ResetConstraints() { }

	// RVA: 0xEBC590
	DataSet get_DataSet() { }

	// RVA: 0xEBC598
	void SetDataSet(DataSet dataSet) { }

	// RVA: 0xEBC668
	DataView get_DefaultView() { }

	// RVA: 0xEBC778
	string get_DisplayExpressionInternal() { }

	// RVA: 0xEBC7E0
	bool get_EnforceConstraints() { }

	// RVA: 0xEBC818
	void set_EnforceConstraints(bool value) { }

	// RVA: 0xEBCE1C
	bool get_SuspendEnforceConstraints() { }

	// RVA: 0xEBCE24
	void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0xEBC868
	void EnableConstraints() { }

	// RVA: 0xEB89C8
	PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xEBCE2C
	IFormatProvider get_FormatProvider() { }

	// RVA: 0xEBCEDC
	CultureInfo get_Locale() { }

	// RVA: 0xEBCEE4
	void set_Locale(CultureInfo value) { }

	// RVA: 0xEB9A0C
	bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0xEBD3AC
	bool ShouldSerializeLocale() { }

	// RVA: 0xEBD3B4
	int get_MinimumCapacity() { }

	// RVA: 0xEB9FD4
	void set_MinimumCapacity(int value) { }

	// RVA: 0xEBD3D4
	int get_RecordCapacity() { }

	// RVA: 0xEBD3F4
	int get_ElementColumnCount() { }

	// RVA: 0xEBD3FC
	void set_ElementColumnCount(int value) { }

	// RVA: 0xEBC258
	DataRelationCollection get_ParentRelations() { }

	// RVA: 0xEBD44C
	bool get_MergingData() { }

	// RVA: 0xEBD454
	void set_MergingData(bool value) { }

	// RVA: 0xEBD45C
	DataRelation[] get_NestedParentRelations() { }

	// RVA: 0xEBD464
	bool get_SchemaLoading() { }

	// RVA: 0xEBD46C
	void CacheNestedParent() { }

	// RVA: 0xEBD498
	DataRelation[] FindNestedParentRelations() { }

	// RVA: 0xEBD94C
	int get_NestedParentsCount() { }

	// RVA: 0xEBDC98
	DataColumn[] get_PrimaryKey() { }

	// RVA: 0xEBDD98
	void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0xEBE2AC
	DataRowCollection get_Rows() { }

	// RVA: 0xEBE2B4
	string get_TableName() { }

	// RVA: 0xEBE2BC
	void set_TableName(string value) { }

	// RVA: 0xEBEA28
	string get_EncodedTableName() { }

	// RVA: 0xEBEAD8
	string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables) { }

	// RVA: 0xEB5C48
	string get_Namespace() { }

	// RVA: 0xEB85C0
	void set_Namespace(string value) { }

	// RVA: 0xEBFC00
	bool IsNamespaceInherited() { }

	// RVA: 0xEBECE0
	void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0xEBF134
	void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0xEBFC10
	void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0xEBF5A8
	void DoRaiseNamespaceChange() { }

	// RVA: 0xEC0068
	void BeginInit() { }

	// RVA: 0xEC0074
	void EndInit() { }

	// RVA: 0xEC06E8
	string get_Prefix() { }

	// RVA: 0xEC06F0
	void set_Prefix(string value) { }

	// RVA: 0xEC089C
	DataColumn get_XmlText() { }

	// RVA: 0xEC08A4
	void set_XmlText(DataColumn value) { }

	// RVA: 0xEC0970
	Decimal get_MaxOccurs() { }

	// RVA: 0xEC097C
	void set_MaxOccurs(Decimal value) { }

	// RVA: 0xEC0984
	Decimal get_MinOccurs() { }

	// RVA: 0xEC0990
	void set_MinOccurs(Decimal value) { }

	// RVA: 0xEC0998
	void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0xEC0A34
	DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0xEC0AC8
	DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0xEC0B54
	void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0xEC0F84
	DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0xEC1B08
	DataTable CreateInstance() { }

	// RVA: 0xEC1B98
	DataTable Clone() { }

	// RVA: 0xEC1BA0
	DataTable Clone(DataSet cloneDS) { }

	// RVA: 0xEC1DB0
	DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0xEC20EC
	DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0xEB7838
	DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0xEC2614
	void add_Initialized(EventHandler value) { }

	// RVA: 0xEC26CC
	void remove_Initialized(EventHandler value) { }

	// RVA: 0xEC2784
	ISite get_Site() { }

	// RVA: 0xEC278C
	void set_Site(ISite value) { }

	// RVA: 0xEC296C
	void AddRow(DataRow row, int proposedID) { }

	// RVA: 0xEC297C
	void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0xEC2988
	void InsertRow(DataRow row, Int64 proposedID, int pos, bool fireEvent) { }

	// RVA: 0xEC37C8
	void CheckNotModifying(DataRow row) { }

	// RVA: 0xEC37FC
	void Clear() { }

	// RVA: 0xEC3804
	void Clear(bool clearAll) { }

	// RVA: 0xEC4244
	void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0xEC4314
	void CommitRow(DataRow row) { }

	// RVA: 0xEC45D0
	int Compare(string s1, string s2) { }

	// RVA: 0xEC45D8
	int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0xEC4774
	int IndexOf(string s1, string s2) { }

	// RVA: 0xEC47FC
	bool IsSuffix(string s1, string s2) { }

	// RVA: 0xEC4884
	bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xEC488C
	void DeleteRow(DataRow row) { }

	// RVA: 0xEC492C
	string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0xEC4A5C
	void FreeRecord(ref int record) { }

	// RVA: 0xEC4A7C
	Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xEC4EA8
	Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xEC50A0
	IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xEC50A4
	System.Collections.Generic.List<System.Data.DataViewListener> GetListeners() { }

	// RVA: 0xEBD2A0
	int GetSpecialHashCode(string name) { }

	// RVA: 0xEC160C
	void InsertRow(DataRow row, Int64 proposedID) { }

	// RVA: 0xEC6108
	int NewRecord() { }

	// RVA: 0xEC61FC
	int NewUninitializedRecord() { }

	// RVA: 0xEC6110
	int NewRecord(int sourceRecord) { }

	// RVA: 0xEBB3C8
	DataRow NewEmptyRow() { }

	// RVA: 0xEC621C
	DataRow NewUninitializedRow() { }

	// RVA: 0xEC62E8
	DataRow NewRow() { }

	// RVA: 0xEC6464
	DataRow CreateEmptyRow() { }

	// RVA: 0xEC63D0
	void NewRowCreated(DataRow row) { }

	// RVA: 0xEC6254
	DataRow NewRow(int record) { }

	// RVA: 0xEC6848
	DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0xEC68B0
	Type GetRowType() { }

	// RVA: 0xEC6950
	DataRow[] NewRowArray(int size) { }

	// RVA: 0xEC6B5C
	bool get_NeedColumnChangeEvents() { }

	// RVA: 0xEC6BB4
	void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0xEC6C98
	void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0xEC6D7C
	void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xEC6E60
	void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0xEC6E70
	void OnRemoveColumn(DataColumn column) { }

	// RVA: 0xEC4520
	DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEC4470
	DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEC6E74
	void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0xEC6F58
	void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0xEC703C
	void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0xEC7120
	void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0xEC7204
	void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0xEC72E8
	void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0xEC73CC
	void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0xEC05DC
	void OnInitialized() { }

	// RVA: 0xEC4ABC
	IndexField[] ParseSortString(string sortString) { }

	// RVA: 0xEBE9AC
	void RaisePropertyChanging(string name) { }

	// RVA: 0xEC74B0
	void RecordChanged(int record) { }

	// RVA: 0xEC767C
	void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0xEC5294
	void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xEC5478
	void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0xEC795C
	int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xEC7B40
	int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xEC7D70
	void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0xEC8A44
	void RemoveRow(DataRow row, bool check) { }

	// RVA: 0xEC8BF8
	void Reset() { }

	// RVA: 0xEB7830
	void ResetIndexes() { }

	// RVA: 0xEC8F84
	void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0xEC91E4
	void RollbackRow(DataRow row) { }

	// RVA: 0xEC5E98
	DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEC9290
	DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEC50AC
	DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0xEC0C78
	void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged) { }

	// RVA: 0xEC2D68
	void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0xEC0CD4
	void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0xEC9508
	void RestoreShadowIndexes() { }

	// RVA: 0xEBBCA8
	void SetShadowIndexes() { }

	// RVA: 0xEC9528
	void ShadowIndexCopy() { }

	// RVA: 0xEC95CC
	string ToString() { }

	// RVA: 0xEC9270
	bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0xEC9698
	DataColumn AddUniqueKey(int position) { }

	// RVA: 0xEC995C
	DataColumn AddUniqueKey() { }

	// RVA: 0xEC9964
	DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0xEC9A18
	void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0xEC9A2C
	PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0xEB8900
	XmlQualifiedName get_TypeName() { }

	// RVA: 0xEC9E40
	void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0xEC9E50
	void Merge(DataTable table) { }

	// RVA: 0xEC9E5C
	void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xECA0E4
	void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0xECA52C
	bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xEB8A54
	bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xECA9D4
	void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0xECAD98
	void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0xECADF0
	bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0xECB034
	XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xECCD2C
	void ReadEndElement(XmlReader reader) { }

	// RVA: 0xECCE04
	void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xECE620
	bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xECC1FC
	void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xECE6EC
	void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xECCE80
	void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xECA5F4
	void CreateTableList(DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xECE970
	void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList) { }

	// RVA: 0xECEEF0
	XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xECF13C
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xECF14C
	XmlSchema GetSchema() { }

	// RVA: 0xECF320
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xECF4DC
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xECF514
	void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xECF520
	Hashtable get_RowDiffId() { }

	// RVA: 0xECF5AC
	int get_ObjectID() { }

	// RVA: 0xECF5B4
	void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xECF6AC
	void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xECF74C
	void EvaluateExpressions() { }

	// RVA: 0xEC57BC
	void EvaluateExpressions(DataRow row, DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows) { }

	// RVA: 0xECFAA8
	void EvaluateExpressions(DataColumn column) { }

	// RVA: 0xEC405C
	void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0xEC7EF8
	void EvaluateDependentExpressions(System.Collections.Generic.List<System.Data.DataColumn> columns, DataRow row, DataRowVersion version, System.Collections.Generic.List<System.Data.DataRow> cachedRows) { }

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

	// RVA: 0xEF483C
	void .ctor(DataTable table, string name) { }

	// RVA: 0xEF49AC
	void AddArgument(ExpressionNode argument) { }

	// RVA: 0xEF4BAC
	void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xEF50B8
	object Eval() { }

	// RVA: 0xEF50CC
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xEF7324
	object Eval(int[] recordNos) { }

	// RVA: 0xEF7360
	bool IsConstant() { }

	// RVA: 0xEF73FC
	bool IsTableConstant() { }

	// RVA: 0xEF7480
	bool HasLocalAggregate() { }

	// RVA: 0xEF7504
	bool HasRemoteAggregate() { }

	// RVA: 0xEF7588
	bool DependsOn(DataColumn column) { }

	// RVA: 0xEF7624
	ExpressionNode Optimize() { }

	// RVA: 0xEF5AAC
	Type GetDataType(ExpressionNode node) { }

	// RVA: 0xEF5D44
	object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0xEF7808
	FunctionId get_Aggregate() { }

	// RVA: 0xEF78B0
	bool get_IsAggregate() { }

	// RVA: 0xEF4EB0
	void Check() { }

	// RVA: 0xEF7B78
	void .cctor() { }

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

	// RVA: 0xEF8554
	void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0xEF87E8
	void .cctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.Data.TypeLimiter.Scope.<>c <>9; // 0x0
	public static System.Func<System.Type,System.Boolean> <>9__3_0; // 0x8

	// Methods

	// RVA: 0xEFA824
	void .cctor() { }

	// RVA: 0xEFA890
	void .ctor() { }

	// RVA: 0xEFA898
	bool <.ctor>b__3_0(Type type) { }

}

// Namespace: 
private sealed class Scope 
{
	// Fields
	private static readonly System.Collections.Generic.HashSet<System.Type> s_allowedTypes; // 0x0
	private System.Collections.Generic.HashSet<System.Type> m_allowedTypes; // 0x10
	private readonly Scope m_previousScope; // 0x18

	// Methods

	// RVA: 0xEF9748
	void .ctor(Scope previousScope, System.Collections.Generic.IEnumerable<System.Type> allowedTypes) { }

	// RVA: 0xEF9C14
	void Dispose() { }

	// RVA: 0xEF9238
	bool IsAllowedType(Type type) { }

	// RVA: 0xEF9CF4
	bool IsTypeUnconditionallyAllowed(Type type) { }

	// RVA: 0xEF9EEC
	void .cctor() { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.Data.TypeLimiter.<>c <>9; // 0x0
	public static System.Func<System.Data.DataColumn,System.Type> <>9__10_0; // 0x8
	public static System.Func<System.Data.DataTable,System.Collections.Generic.IEnumerable<System.Type>> <>9__11_0; // 0x10

	// Methods

	// RVA: 0xEFA900
	void .cctor() { }

	// RVA: 0xEFA96C
	void .ctor() { }

	// RVA: 0xEFA974
	Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

	// RVA: 0xEFA990
	System.Collections.Generic.IEnumerable<System.Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }

}

// Namespace: System.Data
internal sealed class TypeLimiter 
{
	// Fields
	private static Scope s_activeScope; // 0xFFFFFFFF
	private Scope m_instanceScope; // 0x10

	// Methods

	// RVA: 0xEF902C
	void .ctor(Scope scope) { }

	// RVA: 0xEF9060
	bool get_IsTypeLimitingDisabled() { }

	// RVA: 0xEF9108
	TypeLimiter Capture() { }

	// RVA: 0xEF9194
	void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0xEF9400
	IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0xEF98CC
	IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0xEF9A20
	System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0xEF9554
	System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }

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

	// RVA: 0xEFA998
	int get_Count() { }

	// RVA: 0xEFA9C8
	void CopyTo(Array ar, int index) { }

	// RVA: 0xEFAA10
	IEnumerator GetEnumerator() { }

	// RVA: 0xEFAA40
	bool get_IsSynchronized() { }

	// RVA: 0xEFAA48
	int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0xEFAB18
	object get_SyncRoot() { }

	// RVA: 0xEFAB1C
	ArrayList get_List() { }

	// RVA: 0xEFAB24
	void .ctor() { }

	// RVA: 0xEFAB2C
	void .cctor() { }

}

// Namespace: System.Data
internal sealed class ColumnTypeConverter 
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0xEFABBC
	void .ctor() { }

	// RVA: 0xEFABC4
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xEFAC90
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xEFB1EC
	bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xEFB2B8
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0xEFB4CC
	StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0xEFB610
	bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0xEFB618
	bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xEFB620
	void .cctor() { }

}

// Namespace: System.Data
internal class DataCommonEventSource 
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static Int64 s_nextScopeId; // 0x8

	// Methods

	// RVA: 0xEFC2E8
	void Trace(string message) { }

	// RVA: 0x309AF8C
	void Trace(string format, T0 arg0) { }

	// RVA: 0x309AF8C
	void Trace(string format, T0 arg0, T1 arg1) { }

	// RVA: 0x309AF8C
	void Trace(string format, T0 arg0, T1 arg1, T2 arg2) { }

	// RVA: 0x309AF8C
	void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x309AF8C
	void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x309AF8C
	void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	// RVA: 0xEFC2F8
	Int64 EnterScope(string message) { }

	// RVA: 0x309AF8C
	Int64 EnterScope(string format, T1 arg1) { }

	// RVA: 0x309AF8C
	Int64 EnterScope(string format, T1 arg1, T2 arg2) { }

	// RVA: 0x309AF8C
	Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x309AF8C
	Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0xEFC3D8
	void ExitScope(Int64 scopeId) { }

	// RVA: 0xEFC3E8
	void .ctor() { }

	// RVA: 0xEFC3F0
	void .cctor() { }

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

	// RVA: 0xEFC46C
	string get_ConstraintName() { }

	// RVA: 0xEFC474
	void set_ConstraintName(string value) { }

	// RVA: 0xEFC914
	string get_SchemaName() { }

	// RVA: 0xEFC95C
	void set_SchemaName(string value) { }

	// RVA: 0xEFC9A4
	bool get_InCollection() { }

	// RVA: 0xEFC9AC
	void set_InCollection(bool value) { }

	// RVA: 0x2FE360C
	DataTable get_Table() { }

	// RVA: 0xEFCA0C
	PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x2FE3174
	bool ContainsColumn(DataColumn column) { }

	// RVA: 0x2FE3054
	bool CanEnableConstraint() { }

	// RVA: 0x2FE36BC
	Constraint Clone(DataSet destination) { }

	// RVA: -1
	Constraint Clone(DataSet destination, bool ignoreNSforTableLookup) { }

	// RVA: 0xEFCA98
	void CheckConstraint() { }

	// RVA: 0x2FE4574
	void CheckCanAddToCollection(ConstraintCollection constraint) { }

	// RVA: -1
	bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException) { }

	// RVA: 0x2FE45DC
	void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x2FE41A8
	void CheckState() { }

	// RVA: 0xEFCAF8
	void CheckStateForProperty() { }

	// RVA: 0xEFCC08
	DataSet get__DataSet() { }

	// RVA: 0x2FE3054
	bool IsConstraintViolated() { }

	// RVA: 0xEFCC10
	string ToString() { }

	// RVA: 0xEFCC1C
	void .ctor() { }

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

	// RVA: 0xEFCCA0
	void .ctor(DataTable table) { }

	// RVA: 0xEFCD64
	ArrayList get_List() { }

	// RVA: 0xEFCD6C
	Constraint get_Item(int index) { }

	// RVA: 0xEFCE74
	DataTable get_Table() { }

	// RVA: 0xEFCE7C
	Constraint get_Item(string name) { }

	// RVA: 0xEFD12C
	void Add(Constraint constraint) { }

	// RVA: 0xEFD134
	void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0xEFDC2C
	Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0xEFD790
	void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0xEFDA88
	void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0xEFD6BC
	bool AutoGenerated(Constraint constraint) { }

	// RVA: 0xEFDBC8
	void ArrayAdd(Constraint constraint) { }

	// RVA: 0xEFDCD8
	void ArrayRemove(Constraint constraint) { }

	// RVA: 0xEFDA58
	string AssignName() { }

	// RVA: 0xEFDAFC
	void BaseAdd(Constraint constraint) { }

	// RVA: 0xEFDDEC
	void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0xEFDFBC
	void BaseRemove(Constraint constraint) { }

	// RVA: 0xEFE284
	bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0xEFE2B4
	void Clear() { }

	// RVA: 0xEFE6B8
	bool Contains(string name) { }

	// RVA: 0xEFE6D4
	bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xEFD544
	Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0xEFD87C
	UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0xEFE868
	UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0xEFE998
	ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xEFE7D0
	bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0xEFCF84
	int InternalIndexOf(string constraintName) { }

	// RVA: 0xEFDD18
	string MakeName(int index) { }

	// RVA: 0xEFDC08
	void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xEFC688
	void RegisterName(string name) { }

	// RVA: 0xEFEC10
	void Remove(Constraint constraint) { }

	// RVA: 0xEFC890
	void UnregisterName(string name) { }

	// RVA: 0xEFED98
	void FinishInitConstraints() { }

}

// Namespace: System.Data
internal sealed class ConstraintConverter 
{
	// Methods

	// RVA: 0xEFF6E4
	void .ctor() { }

	// RVA: 0xEFF6EC
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xEFF7B8
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Data
internal class ConstraintEnumerator 
{
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Methods

	// RVA: 0xF00264
	void .ctor(DataSet dataSet) { }

	// RVA: 0xF002D0
	bool GetNext() { }

	// RVA: 0xF00648
	Constraint GetConstraint() { }

	// RVA: 0xF00650
	bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF00658
	Constraint get_CurrentObject() { }

}

// Namespace: System.Data
internal class ForeignKeyConstraintEnumerator 
{
	// Methods

	// RVA: 0xF00660
	void .ctor(DataSet dataSet) { }

	// RVA: 0xF006CC
	bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF00750
	ForeignKeyConstraint GetForeignKeyConstraint() { }

}

// Namespace: System.Data
internal sealed class ChildForeignKeyConstraintEnumerator 
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF007CC
	void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF00854
	bool IsValidCandidate(Constraint constraint) { }

}

// Namespace: System.Data
internal sealed class ParentForeignKeyConstraintEnumerator 
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF00900
	void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF00988
	bool IsValidCandidate(Constraint constraint) { }

}

// Namespace: System.Data
public class DataColumnChangeEventArgs 
{
	// Fields
	private DataColumn _column; // 0x10
	private readonly DataRow <Row>k__BackingField; // 0x18
	private object <ProposedValue>k__BackingField; // 0x20

	// Methods

	// RVA: 0xF00A38
	void .ctor(DataRow row) { }

	// RVA: 0xF00AB0
	void .ctor(DataRow row, DataColumn column, object value) { }

	// RVA: 0xF00B58
	object get_ProposedValue() { }

	// RVA: 0xF00B60
	void set_ProposedValue(object value) { }

	// RVA: 0xF00B68
	void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

// Namespace: System.Data
public sealed class DataColumnChangeEventHandler 
{
	// Methods

	// RVA: 0xF00B9C
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xF00CC0
	internal void Invoke(object sender, DataColumnChangeEventArgs e) { }

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

	// RVA: 0xF00CD4
	void .ctor(DataTable table) { }

	// RVA: 0xF00E78
	ArrayList get_List() { }

	// RVA: 0xF00E80
	DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0xF00E88
	int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0xF00E90
	int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0xF00E98
	DataColumn get_Item(int index) { }

	// RVA: 0xEFF354
	DataColumn get_Item(string name) { }

	// RVA: 0xF01178
	DataColumn get_Item(string name, string ns) { }

	// RVA: 0xF01238
	void Add(DataColumn column) { }

	// RVA: 0xF01244
	void AddAt(int index, DataColumn column) { }

	// RVA: 0xF01ACC
	void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF01B70
	void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF01C14
	void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF01CB8
	void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF01968
	void ArrayAdd(DataColumn column) { }

	// RVA: 0xF018E8
	void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0xF01DB4
	void ArrayRemove(DataColumn column) { }

	// RVA: 0xF02054
	string AssignName() { }

	// RVA: 0xF01578
	void BaseAdd(DataColumn column) { }

	// RVA: 0xF025CC
	void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0xF027B8
	void BaseRemove(DataColumn column) { }

	// RVA: 0xF02908
	bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0xF01D5C
	void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0xF03350
	void Clear() { }

	// RVA: 0xF03628
	bool Contains(string name) { }

	// RVA: 0xF036DC
	bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF03780
	int IndexOf(string columnName) { }

	// RVA: 0xF00FE0
	int IndexOfCaseInsensitive(string name) { }

	// RVA: 0xF038A0
	void FinishInitCollection() { }

	// RVA: 0xF020F0
	string MakeName(int index) { }

	// RVA: 0xF01A10
	void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF01554
	void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF03980
	void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF021C4
	void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0xF039DC
	bool CanRegisterName(string name) { }

	// RVA: 0xF03A48
	void Remove(DataColumn column) { }

	// RVA: 0xF024A0
	void UnregisterName(string name) { }

	// RVA: 0xF03270
	void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0xF01EF4
	void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

}

// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor 
{
	// Fields
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF03B5C
	void .ctor(DataColumn dataColumn) { }

	// RVA: 0xF03BA0
	AttributeCollection get_Attributes() { }

	// RVA: 0xF03D70
	DataColumn get_Column() { }

	// RVA: 0xF03D78
	Type get_ComponentType() { }

	// RVA: 0xF03E18
	bool get_IsReadOnly() { }

	// RVA: 0xF03E38
	Type get_PropertyType() { }

	// RVA: 0xF03E58
	bool Equals(object other) { }

	// RVA: 0xF03EE0
	int GetHashCode() { }

	// RVA: 0xF03F04
	bool CanResetValue(object component) { }

	// RVA: 0xF040C4
	object GetValue(object component) { }

	// RVA: 0xF04158
	void ResetValue(object component) { }

	// RVA: 0xF042E8
	void SetValue(object component, object value) { }

	// RVA: 0xF043CC
	bool ShouldSerializeValue(object component) { }

	// RVA: 0xF043D4
	bool get_IsBrowsable() { }

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

	// RVA: 0xF0442C
	void .ctor() { }

	// RVA: 0xF04498
	void .ctor(string rowError) { }

	// RVA: 0xF045B8
	string get_Text() { }

	// RVA: 0xF045C0
	void set_Text(string value) { }

	// RVA: 0xF0462C
	bool get_HasErrors() { }

	// RVA: 0xF04668
	void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF04A08
	string GetColumnError(DataColumn column) { }

	// RVA: 0xF0479C
	void Clear(DataColumn column) { }

	// RVA: 0xF04AA8
	void Clear() { }

	// RVA: 0xF04B50
	DataColumn[] GetColumnsInError() { }

	// RVA: 0xF0454C
	void SetText(string errorText) { }

	// RVA: 0xF048B8
	int IndexOf(DataColumn column) { }

}

// Namespace: System.Data
internal struct DataKey 
{
	// Fields
	private readonly DataColumn[] _columns; // 0x10

	// Methods

	// RVA: 0xF04C68
	void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0xF04F34
	DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF04F3C
	bool get_HasValue() { }

	// RVA: 0xF00230
	DataTable get_Table() { }

	// RVA: 0xF04E90
	void CheckState() { }

	// RVA: 0xF04F4C
	bool ColumnsEqual(DataKey key) { }

	// RVA: 0xF05048
	bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0xF031AC
	bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF05144
	int GetHashCode() { }

	// RVA: 0xF051B4
	bool Equals(object value) { }

	// RVA: 0xF052E4
	bool Equals(DataKey value) { }

	// RVA: 0xF053BC
	string[] GetColumnNames() { }

	// RVA: 0xF05498
	IndexField[] GetIndexDesc() { }

	// RVA: 0xF055B0
	object[] GetKeyValues(int record) { }

	// RVA: 0xF056E4
	Index GetSortIndex() { }

	// RVA: 0xF0573C
	Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0xF05798
	bool RecordsEqual(int record1, int record2) { }

	// RVA: 0xF0581C
	DataColumn[] ToArray() { }

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

	// RVA: 0xF05918
	void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0xF05EA0
	void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF05F70
	void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF06044
	void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF0616C
	void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF062CC
	DataColumn[] get_ChildColumns() { }

	// RVA: 0xF063F4
	DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0xF03228
	DataKey get_ChildKey() { }

	// RVA: 0xF06418
	DataTable get_ChildTable() { }

	// RVA: 0xF0645C
	DataSet get_DataSet() { }

	// RVA: 0xF06480
	string[] get_ParentColumnNames() { }

	// RVA: 0xF06488
	string[] get_ChildColumnNames() { }

	// RVA: 0xF06490
	bool IsKeyNull(object[] values) { }

	// RVA: 0xF0654C
	DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0xF06704
	DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF0688C
	DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF06BCC
	void SetDataSet(DataSet dataSet) { }

	// RVA: 0xF06BE4
	DataColumn[] get_ParentColumns() { }

	// RVA: 0xF06C08
	DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0xF0324C
	DataKey get_ParentKey() { }

	// RVA: 0xF06C10
	DataTable get_ParentTable() { }

	// RVA: 0xF06C54
	string get_RelationName() { }

	// RVA: 0xF06C78
	void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0xF07000
	void CheckNestedRelations() { }

	// RVA: 0xF073C0
	bool get_Nested() { }

	// RVA: 0xF073E4
	void set_Nested(bool value) { }

	// RVA: 0xF08C28
	UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0xF08C4C
	void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0xF08C54
	ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0xF08C78
	PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF08D04
	bool get_CheckMultipleNested() { }

	// RVA: 0xF08D0C
	void set_CheckMultipleNested(bool value) { }

	// RVA: 0xF08D14
	void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0xF08D1C
	void CheckState() { }

	// RVA: 0xF062F0
	void CheckStateForProperty() { }

	// RVA: 0xF05B6C
	void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF08FF8
	DataRelation Clone(DataSet destination) { }

	// RVA: 0xF097D0
	void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF08AD8
	void RaisePropertyChanging(string name) { }

	// RVA: 0xF098B4
	string ToString() { }

	// RVA: 0xF08608
	void ValidateMultipleNestedRelations() { }

	// RVA: 0xF098C0
	bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0xF09AA4
	int get_ObjectID() { }

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

	// RVA: 0xF0B21C
	void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0xF0B348
	ArrayList get_List() { }

	// RVA: 0xF0B350
	void EnsureDataSet() { }

	// RVA: 0xF0B3A0
	DataSet GetDataSet() { }

	// RVA: 0xF0B3EC
	DataRelation get_Item(int index) { }

	// RVA: 0xF0B4F8
	DataRelation get_Item(string name) { }

	// RVA: 0xF0B600
	void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF0B6A4
	void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF0B748
	void AddCache(DataRelation relation) { }

	// RVA: 0xF0B7A0
	void AddCore(DataRelation relation) { }

	// RVA: 0xF0B8A0
	void RemoveCache(DataRelation relation) { }

	// RVA: 0xF0B984
	void RemoveCore(DataRelation relation) { }

}

// Namespace: 
internal sealed class DataSetRelationCollection 
{
	// Fields
	private readonly DataSet _dataSet; // 0x38
	private readonly ArrayList _relations; // 0x40
	private DataRelation[] _delayLoadingRelations; // 0x48

	// Methods

	// RVA: 0xF0BA50
	void .ctor(DataSet dataSet) { }

	// RVA: 0xF0BB74
	ArrayList get_List() { }

	// RVA: 0xF0BB7C
	void Clear() { }

	// RVA: 0xF0BBD0
	DataSet GetDataSet() { }

	// RVA: 0xF0BBD8
	DataRelation get_Item(int index) { }

	// RVA: 0xF0BCE4
	DataRelation get_Item(string name) { }

	// RVA: 0xF0BDEC
	void AddCore(DataRelation relation) { }

	// RVA: 0xF0C4D0
	void RemoveCore(DataRelation relation) { }

	// RVA: 0xF0C760
	void FinishInitRelations() { }

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

	// RVA: 0xF09AAC
	int get_ObjectID() { }

	// RVA: -1
	DataRelation get_Item(int index) { }

	// RVA: 0x2FE36BC
	DataRelation get_Item(string name) { }

	// RVA: 0xF09AB4
	void Add(DataRelation relation) { }

	// RVA: 0xF09D70
	void AddCore(DataRelation relation) { }

	// RVA: 0xF0A00C
	void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF0A144
	void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF0A27C
	string AssignName() { }

	// RVA: 0xF0A380
	void Clear() { }

	// RVA: 0xF0A5E8
	bool Contains(string name) { }

	// RVA: 0xF0A604
	int InternalIndexOf(string name) { }

	// RVA: 0x2FE360C
	DataSet GetDataSet() { }

	// RVA: 0xF0A2AC
	string MakeName(int index) { }

	// RVA: 0xF0A7BC
	void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF0A8A0
	void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF0A984
	void RegisterName(string name) { }

	// RVA: 0xF0AB90
	void Remove(DataRelation relation) { }

	// RVA: 0xF0ADAC
	void RemoveAt(int index) { }

	// RVA: 0xF0AE2C
	void RemoveCore(DataRelation relation) { }

	// RVA: 0xF0B014
	void UnregisterName(string name) { }

	// RVA: 0xF0B170
	void .ctor() { }

}

// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor 
{
	// Fields
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF0CC38
	void .ctor(DataRelation dataRelation) { }

	// RVA: 0xF0CC90
	DataRelation get_Relation() { }

	// RVA: 0xF0CC98
	Type get_ComponentType() { }

	// RVA: 0xF0CD38
	bool get_IsReadOnly() { }

	// RVA: 0xF0CD40
	Type get_PropertyType() { }

	// RVA: 0xF0CDE0
	bool Equals(object other) { }

	// RVA: 0xF0CE68
	int GetHashCode() { }

	// RVA: 0xF0CE8C
	bool CanResetValue(object component) { }

	// RVA: 0xF0CE94
	object GetValue(object component) { }

	// RVA: 0xF0CF34
	void ResetValue(object component) { }

	// RVA: 0xF0CF38
	void SetValue(object component, object value) { }

	// RVA: 0xF0CF3C
	bool ShouldSerializeValue(object component) { }

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

	// RVA: 0xF0CF44
	void .ctor(DataRowBuilder builder) { }

	// RVA: 0xF0CFFC
	DataColumn get_LastChangedColumn() { }

	// RVA: 0xF0D018
	void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0xF0D02C
	bool get_HasPropertyChanged() { }

	// RVA: 0xF0D03C
	int get_RBTreeNodeId() { }

	// RVA: 0xF0D044
	void set_RBTreeNodeId(int value) { }

	// RVA: 0xF0D120
	string get_RowError() { }

	// RVA: 0xF0D188
	void set_RowError(string value) { }

	// RVA: 0xF0D3EC
	void RowErrorChanged() { }

	// RVA: 0xF0D44C
	Int64 get_rowID() { }

	// RVA: 0xF0D454
	void set_rowID(Int64 value) { }

	// RVA: 0xF0D4BC
	DataRowState get_RowState() { }

	// RVA: 0xF0D77C
	DataTable get_Table() { }

	// RVA: 0xF08B48
	void CheckForLoops(DataRelation rel) { }

	// RVA: 0xF0D784
	int GetNestedParentCount() { }

	// RVA: 0xF0D844
	void set_Item(string columnName, object value) { }

	// RVA: 0xF0D6F4
	object get_Item(DataColumn column) { }

	// RVA: 0xF0D934
	void set_Item(DataColumn column, object value) { }

	// RVA: 0xF0E078
	object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0xF0E214
	void set_ItemArray(object[] value) { }

	// RVA: 0xF0E67C
	void AcceptChanges() { }

	// RVA: 0xF0EA20
	void BeginEdit() { }

	// RVA: 0xF0DDD0
	bool BeginEditInternal() { }

	// RVA: 0xF0DEFC
	void CancelEdit() { }

	// RVA: 0xF0DCD0
	void CheckColumn(DataColumn column) { }

	// RVA: 0xF0EA24
	void CheckInTable() { }

	// RVA: 0xF0EA6C
	void Delete() { }

	// RVA: 0xF0DF70
	void EndEdit() { }

	// RVA: 0xF0EADC
	void SetColumnError(int columnIndex, string error) { }

	// RVA: 0xF0EB4C
	void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF0EF24
	string GetColumnError(string columnName) { }

	// RVA: 0xF0EDD8
	string GetColumnError(DataColumn column) { }

	// RVA: 0xF0EF98
	void ClearErrors() { }

	// RVA: 0xF03140
	void ClearError(DataColumn column) { }

	// RVA: 0xF0F004
	bool get_HasErrors() { }

	// RVA: 0xF0F054
	DataColumn[] GetColumnsInError() { }

	// RVA: 0xF0F144
	DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0xF0F14C
	DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF0D8C8
	DataColumn GetDataColumn(string columnName) { }

	// RVA: 0xF08C20
	DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0xF0F280
	DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF0F3A8
	DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0xF0F460
	DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0xF0F468
	DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF0F59C
	object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0xF0F634
	object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0xF0F68C
	object[] GetKeyValues(DataKey key) { }

	// RVA: 0xF066D4
	object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0xF0F70C
	int GetCurrentRecordNo() { }

	// RVA: 0xF0DD60
	int GetDefaultRecord() { }

	// RVA: 0xF0F754
	int GetOriginalRecordNo() { }

	// RVA: 0xF0DEB4
	int GetProposedRecordNo() { }

	// RVA: 0xF0E0C8
	int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0xF0F79C
	DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0xF0F7C8
	DataViewRowState GetRecordState(int record) { }

	// RVA: 0xF0F81C
	bool HasKeyChanged(DataKey key) { }

	// RVA: 0xF0F828
	bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF06B10
	bool HasVersion(DataRowVersion version) { }

	// RVA: 0xF0F9F4
	bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0xF0FA84
	bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF0FB24
	void RejectChanges() { }

	// RVA: 0xF0D48C
	void ResetLastChangedColumn() { }

	// RVA: 0xF101A0
	void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0xF1035C
	void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0xF107A8
	void SetParentRowToDBNull() { }

	// RVA: 0xF10A80
	void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0xF10C08
	int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

// Namespace: System.Data
public sealed class DataRowBuilder 
{
	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xF10FE4
	void .ctor(DataTable table, int record) { }

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

	// RVA: 0xF1102C
	void .ctor(DataRow row, DataRowAction action) { }

}

// Namespace: System.Data
public sealed class DataRowChangeEventHandler 
{
	// Methods

	// RVA: 0xF110B8
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xF111DC
	internal void Invoke(object sender, DataRowChangeEventArgs e) { }

}

// Namespace: 
private sealed class DataRowTree 
{
	// Methods

	// RVA: 0xF112D8
	void .ctor() { }

	// RVA: 0xF11A10
	int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0xF11A44
	int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

}

// Namespace: System.Data
public sealed class DataRowCollection 
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Methods

	// RVA: 0xF111F0
	void .ctor(DataTable table) { }

	// RVA: 0xF11330
	int get_Count() { }

	// RVA: 0xF030C8
	DataRow get_Item(int index) { }

	// RVA: 0xF11384
	void Add(DataRow row) { }

	// RVA: 0xF113A8
	void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0xF115EC
	int IndexOf(DataRow row) { }

	// RVA: 0xF11694
	DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0xF11700
	void ArrayAdd(DataRow row) { }

	// RVA: 0xF11774
	void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0xF117F0
	void ArrayClear() { }

	// RVA: 0xF11844
	void ArrayRemove(DataRow row) { }

	// RVA: 0xF118E4
	void CopyTo(Array ar, int index) { }

	// RVA: 0xF11950
	void CopyTo(DataRow[] array, int index) { }

	// RVA: 0xF119BC
	IEnumerator GetEnumerator() { }

}

// Namespace: System.Data
internal sealed class DataRowCreatedEventHandler 
{
	// Methods

	// RVA: 0xF11A78
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xF11B9C
	internal void Invoke(object sender, DataRow r) { }

}

// Namespace: System.Data
internal sealed class DataSetClearEventhandler 
{
	// Methods

	// RVA: 0xF11BB0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xF11CD4
	internal void Invoke(object sender, DataTable table) { }

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

	// RVA: 0xF11CE8
	void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xF11D38
	bool Equals(object other) { }

	// RVA: 0xF11D44
	int GetHashCode() { }

	// RVA: 0xF11D68
	DataView get_DataView() { }

	// RVA: 0xF11D70
	string System.ComponentModel.IDataErrorInfo.get_Item(string colName) { }

	// RVA: 0xF11D8C
	string System.ComponentModel.IDataErrorInfo.get_Error() { }

	// RVA: 0xF11DFC
	DataRowVersion get_RowVersionDefault() { }

	// RVA: 0xF11E58
	int GetRecord() { }

	// RVA: 0xF11EA8
	bool HasRecord() { }

	// RVA: 0xF0403C
	object GetColumnValue(DataColumn column) { }

	// RVA: 0xF04234
	void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0xF11F0C
	DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0xF0CF2C
	DataView CreateChildView(DataRelation relation) { }

	// RVA: 0xF120F8
	DataRow get_Row() { }

	// RVA: 0xF12100
	void BeginEdit() { }

	// RVA: 0xF1210C
	void CancelEdit() { }

	// RVA: 0xF121E8
	void EndEdit() { }

	// RVA: 0xF121BC
	bool get_IsNew() { }

	// RVA: 0xF1224C
	void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF122F0
	void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF12394
	void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0xF12428
	AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xF12484
	string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xF1248C
	string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xF12494
	TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xF1249C
	EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xF124A4
	PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xF124AC
	object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xF124B4
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xF12510
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xF1256C
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xF12614
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xF126C4
	object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xF126C8
	void .cctor() { }

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

	// RVA: 0xF12754
	void .ctor(DataTable dataTable) { }

}

// Namespace: System.Data
public sealed class DataTableClearEventHandler 
{
	// Methods

	// RVA: 0xF127CC
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xF128F0
	internal void Invoke(object sender, DataTableClearEventArgs e) { }

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

	// RVA: 0xF12904
	void .ctor(DataSet dataSet) { }

	// RVA: 0xF12AB4
	ArrayList get_List() { }

	// RVA: 0xF12ABC
	int get_ObjectID() { }

	// RVA: 0xF12AC4
	DataTable get_Item(int index) { }

	// RVA: 0xEFF4B8
	DataTable get_Item(string name) { }

	// RVA: 0xEFF5C8
	DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0xF13018
	DataTable GetTable(string name, string ns) { }

	// RVA: 0xF13154
	DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0xF13298
	void Add(DataTable table) { }

	// RVA: 0xF138DC
	void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF13A14
	void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF137D0
	void ArrayAdd(DataTable table) { }

	// RVA: 0xF13B4C
	string AssignName() { }

	// RVA: 0xF13630
	void BaseAdd(DataTable table) { }

	// RVA: 0xF13F30
	void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0xF1410C
	void BaseRemove(DataTable table) { }

	// RVA: 0xF14188
	bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0xF14820
	void Clear() { }

	// RVA: 0xF13C80
	bool Contains(string name) { }

	// RVA: 0xF14B6C
	bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0xF14DB0
	bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF14EFC
	int IndexOf(DataTable table) { }

	// RVA: 0xF14FEC
	int IndexOf(string tableName) { }

	// RVA: 0xF15008
	int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0xF15074
	void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF12C0C
	int InternalIndexOf(string tableName) { }

	// RVA: 0xF12E60
	int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0xF150C8
	void FinishInitCollection() { }

	// RVA: 0xF13BAC
	string MakeName(int index) { }

	// RVA: 0xF137F8
	void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF1354C
	void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF13C9C
	void RegisterName(string name, string tbNamespace) { }

	// RVA: 0xF1515C
	void Remove(DataTable table) { }

	// RVA: 0xF146E4
	void UnregisterName(string name) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventArgs 
{
	// Fields
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0xF15358
	void .ctor(DataRow dataRow) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventHandler 
{
	// Methods

	// RVA: 0xF153D0
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xF154F4
	internal void Invoke(object sender, DataTableNewRowEventArgs e) { }

}

// Namespace: System.Data
internal sealed class DataTablePropertyDescriptor 
{
	// Fields
	private readonly DataTable <Table>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF15508
	DataTable get_Table() { }

	// RVA: 0xF15510
	void .ctor(DataTable dataTable) { }

	// RVA: 0xF15554
	Type get_ComponentType() { }

	// RVA: 0xF155F4
	bool get_IsReadOnly() { }

	// RVA: 0xF155FC
	Type get_PropertyType() { }

	// RVA: 0xF1569C
	bool Equals(object other) { }

	// RVA: 0xF15724
	int GetHashCode() { }

	// RVA: 0xF15748
	bool CanResetValue(object component) { }

	// RVA: 0xF15750
	object GetValue(object component) { }

	// RVA: 0xF15894
	void ResetValue(object component) { }

	// RVA: 0xF15898
	void SetValue(object component, object value) { }

	// RVA: 0xF1589C
	bool ShouldSerializeValue(object component) { }

}

// Namespace: System.Data
internal sealed class DataTableTypeConverter 
{
	// Methods

	// RVA: 0xF158A4
	void .ctor() { }

	// RVA: 0xF15958
	bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: 
private sealed class DataRowReferenceComparer 
{
	// Fields
	internal static readonly DataRowReferenceComparer s_default; // 0x0

	// Methods

	// RVA: 0xF1BA60
	void .ctor() { }

	// RVA: 0xF1BA68
	bool Equals(DataRow x, DataRow y) { }

	// RVA: 0xF1BA74
	int GetHashCode(DataRow obj) { }

	// RVA: 0xF1BA90
	void .cctor() { }

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

	// RVA: 0xF15960
	void .ctor(DataTable table, bool locked) { }

	// RVA: 0xF15F58
	void .ctor(DataTable table) { }

	// RVA: 0xF1636C
	bool get_AllowDelete() { }

	// RVA: 0xF16374
	bool get_AllowEdit() { }

	// RVA: 0xF1637C
	bool get_AllowNew() { }

	// RVA: 0xF16384
	int get_Count() { }

	// RVA: 0xF163D8
	int get_CountFromIndex() { }

	// RVA: 0xF163F4
	DataViewManager get_DataViewManager() { }

	// RVA: 0xF163FC
	bool get_IsInitialized() { }

	// RVA: 0xF1640C
	bool get_IsOpen() { }

	// RVA: 0xF16414
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xF1641C
	string get_RowFilter() { }

	// RVA: 0xF16534
	void set_RowFilter(string value) { }

	// RVA: 0xF16758
	DataViewRowState get_RowStateFilter() { }

	// RVA: 0xF16760
	void set_RowStateFilter(DataViewRowState value) { }

	// RVA: 0xF168C8
	string get_Sort() { }

	// RVA: 0xF16920
	void set_Sort(string value) { }

	// RVA: 0xF16BA0
	System.Comparison<System.Data.DataRow> get_SortComparison() { }

	// RVA: 0xF16BA8
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xF16BAC
	DataTable get_Table() { }

	// RVA: 0xF16BB4
	void set_Table(DataTable value) { }

	// RVA: 0xF16E7C
	object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0xF16F74
	void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0xF16EF8
	DataRowView get_Item(int recordIndex) { }

	// RVA: 0xF170FC
	DataRowView AddNew() { }

	// RVA: 0xF175AC
	void BeginInit() { }

	// RVA: 0xF175B8
	void EndInit() { }

	// RVA: 0xF1743C
	void CheckOpen() { }

	// RVA: 0xF16B40
	void CheckSort(string sort) { }

	// RVA: 0xF17844
	void Close() { }

	// RVA: 0xF1789C
	void CopyTo(Array array, int index) { }

	// RVA: 0xF17B8C
	void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0xF17E64
	void Delete(int index) { }

	// RVA: 0xF17E8C
	void Delete(DataRow row) { }

	// RVA: 0xF1829C
	void Dispose(bool disposing) { }

	// RVA: 0xF18074
	void FinishAddNew(bool success) { }

	// RVA: 0xF182FC
	IEnumerator GetEnumerator() { }

	// RVA: 0xF183C0
	bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xF183C8
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xF183D0
	int System.Collections.IList.Add(object value) { }

	// RVA: 0xF18464
	void System.Collections.IList.Clear() { }

	// RVA: 0xF18494
	bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xF1852C
	int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xF17480
	int IndexOf(DataRowView rowview) { }

	// RVA: 0xF185C8
	int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0xF18624
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xF18654
	void System.Collections.IList.Remove(object value) { }

	// RVA: 0xF18788
	void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xF187B0
	Index GetFindIndex(string column, bool keepIndex) { }

	// RVA: 0xF1896C
	bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xF18974
	object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xF18984
	bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xF1898C
	bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xF18994
	bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xF1899C
	bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xF189A4
	bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xF189AC
	bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xF18A2C
	PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xF18ACC
	PropertyDescriptor GetSortProperty() { }

	// RVA: 0xF18B6C
	ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xF18BAC
	void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF18CE4
	void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF18E1C
	void add_Initialized(EventHandler value) { }

	// RVA: 0xF18EC0
	void remove_Initialized(EventHandler value) { }

	// RVA: 0xF18F64
	void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xF18FA8
	void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF190B8
	int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xF19354
	void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xF19398
	void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xF19490
	void System.ComponentModel.IBindingListView.ApplySort(ListSortDescriptionCollection sorts) { }

	// RVA: 0xF18FD0
	string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF199B4
	void System.ComponentModel.IBindingListView.RemoveFilter() { }

	// RVA: 0xF19AB8
	string System.ComponentModel.IBindingListView.get_Filter() { }

	// RVA: 0xF19AC8
	void System.ComponentModel.IBindingListView.set_Filter(string value) { }

	// RVA: 0xF19AD8
	ListSortDescriptionCollection System.ComponentModel.IBindingListView.get_SortDescriptions() { }

	// RVA: 0xF19ADC
	ListSortDescriptionCollection GetSortDescriptions() { }

	// RVA: 0xF19D80
	bool System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting() { }

	// RVA: 0xF19D88
	bool System.ComponentModel.IBindingListView.get_SupportsFiltering() { }

	// RVA: 0xF19D90
	string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF19E4C
	PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF19F1C
	IFilter GetFilter() { }

	// RVA: 0xF19F24
	int GetRecord(int recordIndex) { }

	// RVA: 0xF16FA4
	DataRow GetRow(int index) { }

	// RVA: 0xF17AFC
	DataRowView GetRowView(int record) { }

	// RVA: 0xF17084
	DataRowView GetRowView(DataRow dr) { }

	// RVA: 0xF19FF0
	void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0xF1A08C
	void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0xF1A158
	void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xF1A740
	void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF177B4
	void OnInitialized() { }

	// RVA: 0xF1AB04
	void Reset() { }

	// RVA: 0xF1A47C
	void ResetRowViewCache() { }

	// RVA: 0xF1AB34
	void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xF1AD88
	void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0xF15FCC
	void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0xF17888
	void UpdateIndex() { }

	// RVA: 0xF1B14C
	void UpdateIndex(bool force) { }

	// RVA: 0xF1AD90
	void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0xF1B358
	void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF1B578
	void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF1B798
	void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF1B9B8
	void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF1B9C8
	int get_ObjectID() { }

	// RVA: 0xF1B9D0
	void .cctor() { }

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

	// RVA: 0xF15CDC
	void .ctor(DataView dv) { }

	// RVA: 0xF1BAFC
	void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF1BBE0
	void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF1BCA0
	void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF1BD70
	void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xF1BE4C
	void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF15D6C
	void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0xF16E74
	void UnregisterMetaDataEvents() { }

	// RVA: 0xF1C10C
	void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0xF1B264
	void RegisterListChangedEvent(Index index) { }

	// RVA: 0xF1B154
	void UnregisterListChangedEvent() { }

	// RVA: 0xF1BBBC
	void CleanUp(bool updateListeners) { }

	// RVA: 0xF1BF0C
	void RegisterListener(DataTable table) { }

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

	// RVA: 0xF1C3CC
	void .ctor(DataSet dataSet, bool locked) { }

	// RVA: 0xF1C6C4
	DataSet get_DataSet() { }

	// RVA: 0xF1C6CC
	DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0xF1C6D4
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF1C7C8
	int System.Collections.ICollection.get_Count() { }

	// RVA: 0xF1C7D0
	object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xF1C7D4
	bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xF1C7DC
	bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xF1C7E4
	bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xF1C7EC
	void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xF1C884
	object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xF1C88C
	void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xF1C8BC
	int System.Collections.IList.Add(object value) { }

	// RVA: 0xF1C8EC
	void System.Collections.IList.Clear() { }

	// RVA: 0xF1C91C
	bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xF1C92C
	int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xF1C940
	void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xF1C970
	void System.Collections.IList.Remove(object value) { }

	// RVA: 0xF1C9A0
	void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xF1C9D0
	bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xF1C9D8
	object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xF1CA20
	bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xF1CA28
	bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xF1CA30
	bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xF1CA38
	bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xF1CA40
	bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xF1CA48
	bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xF1CA90
	PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xF1CAD8
	ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xF1CB20
	void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF1CBC4
	void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF1CC68
	void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xF1CC6C
	void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF1CCB4
	int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xF1CCFC
	void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xF1CD00
	void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xF1CD48
	string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF1CE20
	PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF1CFB8
	DataView CreateDataView(DataTable table) { }

	// RVA: 0xF1D0B0
	void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF1D1A8
	void TableCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF1D3F8
	void RelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF1D618
	void .cctor() { }

}

// Namespace: System.Data
internal sealed class DataViewManagerListItemTypeDescriptor 
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private PropertyDescriptorCollection _propsCollection; // 0x18

	// Methods

	// RVA: 0xF1C5D0
	void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xF157C8
	DataView GetDataView(DataTable table) { }

	// RVA: 0xF1D6A0
	AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xF1D6FC
	string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xF1D704
	string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xF1D70C
	TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xF1D714
	EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xF1D71C
	PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xF1D724
	object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xF1D72C
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xF1D788
	EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xF1D7E4
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xF1D88C
	PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xF1DA9C
	object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

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

	// RVA: 0xF1DAA0
	void .ctor() { }

	// RVA: 0xF1DB2C
	bool get_ApplyDefaultSort() { }

	// RVA: 0xF1DB34
	void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xF1DB4C
	void SetDataTable(DataTable table) { }

	// RVA: 0xF1DB64
	string get_RowFilter() { }

	// RVA: 0xF1DB6C
	DataViewRowState get_RowStateFilter() { }

	// RVA: 0xF1DB74
	string get_Sort() { }

}

// Namespace: 
private sealed class DataViewSettingsEnumerator 
{
	// Fields
	private DataViewSettingCollection _dataViewSettings; // 0x10
	private IEnumerator _tableEnumerator; // 0x18

	// Methods

	// RVA: 0xF1E024
	void .ctor(DataViewManager dvm) { }

	// RVA: 0xF1E1AC
	bool MoveNext() { }

	// RVA: 0xF1E260
	void Reset() { }

	// RVA: 0xF1E318
	object get_Current() { }

}

// Namespace: System.Data
public class DataViewSettingCollection 
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Methods

	// RVA: 0xF1C604
	void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xF1DB7C
	DataViewSetting get_Item(DataTable table) { }

	// RVA: 0xF1DD10
	void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0xF1DDCC
	void CopyTo(Array ar, int index) { }

	// RVA: 0xF1DFE4
	int get_Count() { }

	// RVA: 0xF1DF7C
	IEnumerator GetEnumerator() { }

	// RVA: 0xF1E178
	bool get_IsSynchronized() { }

	// RVA: 0xF1E180
	object get_SyncRoot() { }

	// RVA: 0xF1E184
	void Remove(DataTable table) { }

}

// Namespace: System.Data
internal sealed class DefaultValueTypeConverter 
{
	// Methods

	// RVA: 0xF1E438
	void .ctor() { }

	// RVA: 0xF1E440
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xF1E62C
	object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

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

	// RVA: 0xF1E7D8
	void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0xF1E7E4
	void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0xF1E924
	void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF1EBC0
	void Bind(DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF1ED40
	object Eval() { }

	// RVA: 0xF1ED54
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF1F010
	object Eval(int[] records) { }

	// RVA: 0xF1F098
	bool IsConstant() { }

	// RVA: 0xF1F0A0
	bool IsTableConstant() { }

	// RVA: 0xF1F0A8
	bool HasLocalAggregate() { }

	// RVA: 0xF1F0B0
	bool HasRemoteAggregate() { }

	// RVA: 0xF1F0C0
	bool DependsOn(DataColumn column) { }

	// RVA: 0xF1F154
	ExpressionNode Optimize() { }

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

	// RVA: 0xF1F158
	void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xF1F1CC
	void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF1F240
	object Eval() { }

	// RVA: 0xF1F254
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF24EF0
	object Eval(int[] recordNos) { }

	// RVA: 0xF24F08
	bool IsConstant() { }

	// RVA: 0xF24F5C
	bool IsTableConstant() { }

	// RVA: 0xF24FB0
	bool HasLocalAggregate() { }

	// RVA: 0xF25008
	bool HasRemoteAggregate() { }

	// RVA: 0xF25060
	bool DependsOn(DataColumn column) { }

	// RVA: 0xF250C8
	ExpressionNode Optimize() { }

	// RVA: 0xF256A8
	void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0xF256E4
	object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xF25720
	int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0xF25728
	int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0xF1F26C
	object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xF27D78
	DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0xF27D9C
	StorageType GetPrecedenceType(DataTypePrecedence code) { }

	// RVA: 0xF27DC0
	bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0xF27E7C
	bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0xF27890
	StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xF26F70
	StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xF27F50
	int SqlResultType(int typeCode) { }

}

// Namespace: System.Data
internal sealed class LikeNode 
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0xF27FA0
	void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xF28014
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF285D4
	string AnalyzePattern(string pat) { }

}

// Namespace: System.Data
internal sealed class ConstNode 
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0xF28B34
	void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0xF25374
	void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0xF2953C
	void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF29544
	object Eval() { }

	// RVA: 0xF2954C
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF29558
	object Eval(int[] recordNos) { }

	// RVA: 0xF29564
	bool IsConstant() { }

	// RVA: 0xF2956C
	bool IsTableConstant() { }

	// RVA: 0xF29574
	bool HasLocalAggregate() { }

	// RVA: 0xF2957C
	bool HasRemoteAggregate() { }

	// RVA: 0xF29584
	ExpressionNode Optimize() { }

	// RVA: 0xF2909C
	object SmallestDecimal(object constant) { }

	// RVA: 0xF28B3C
	object SmallestNumeric(object constant) { }

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

	// RVA: 0xF16750
	void .ctor(DataTable table, string expression) { }

	// RVA: 0xF29588
	void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0xF164D8
	string get_Expression() { }

	// RVA: 0xF2A988
	bool get_HasValue() { }

	// RVA: 0xF2A840
	void Bind(DataTable table) { }

	// RVA: 0xF1F138
	bool DependsOn(DataColumn column) { }

	// RVA: 0xF2A998
	object Evaluate() { }

	// RVA: 0xF2A9A4
	object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0xF2ABDC
	bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xF2ACCC
	DataColumn[] GetDependency() { }

	// RVA: 0xF2ACD4
	bool IsTableAggregate() { }

	// RVA: 0xF2ACEC
	bool IsUnknown(object value) { }

	// RVA: 0xF2AD74
	bool HasLocalAggregate() { }

	// RVA: 0xF2AD8C
	bool HasRemoteAggregate() { }

	// RVA: 0xF26C54
	bool ToBoolean(object value) { }

}

// Namespace: System.Data
internal abstract class ExpressionNode 
{
	// Fields
	private DataTable _table; // 0x10

	// Methods

	// RVA: 0xF1E8F0
	void .ctor(DataTable table) { }

	// RVA: 0xF26BD4
	IFormatProvider get_FormatProvider() { }

	// RVA: 0xF2ADA4
	bool get_IsSqlColumn() { }

	// RVA: 0xF2ADAC
	DataTable get_table() { }

	// RVA: 0xF2ADB4
	void BindTable(DataTable table) { }

	// RVA: 0x2FE47D4
	void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0x2FE360C
	object Eval() { }

	// RVA: 0x2FE3728
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x2FE36BC
	object Eval(int[] recordNos) { }

	// RVA: 0x2FE3054
	bool IsConstant() { }

	// RVA: 0x2FE3054
	bool IsTableConstant() { }

	// RVA: 0x2FE3054
	bool HasLocalAggregate() { }

	// RVA: 0x2FE3054
	bool HasRemoteAggregate() { }

	// RVA: 0x2FE360C
	ExpressionNode Optimize() { }

	// RVA: 0xF2ADBC
	bool DependsOn(DataColumn column) { }

	// RVA: 0xF27F40
	bool IsInteger(StorageType type) { }

	// RVA: 0xF27D58
	bool IsIntegerSql(StorageType type) { }

	// RVA: 0xF27E3C
	bool IsSigned(StorageType type) { }

	// RVA: 0xF27EF4
	bool IsSignedSql(StorageType type) { }

	// RVA: 0xF27E6C
	bool IsUnsigned(StorageType type) { }

	// RVA: 0xF27F10
	bool IsUnsignedSql(StorageType type) { }

	// RVA: 0xF27F30
	bool IsNumeric(StorageType type) { }

	// RVA: 0xF27F80
	bool IsNumericSql(StorageType type) { }

	// RVA: 0xF2ADC4
	bool IsFloat(StorageType type) { }

	// RVA: 0xF2ADD4
	bool IsFloatSql(StorageType type) { }

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

	// RVA: 0xF2CA88
	void .ctor(string word, Tokens token, int op) { }

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

	// RVA: 0xF297A8
	void .ctor(DataTable table) { }

	// RVA: 0xF29878
	void LoadExpression(string data) { }

	// RVA: 0xF2ADF0
	void StartScan() { }

	// RVA: 0xF29980
	ExpressionNode Parse() { }

	// RVA: 0xF2B9D0
	ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0xF2B990
	ExpressionNode NodePop() { }

	// RVA: 0xF2B944
	ExpressionNode NodePeek() { }

	// RVA: 0xF2B89C
	void NodePush(ExpressionNode node) { }

	// RVA: 0xF2B53C
	void BuildExpression(int pri) { }

	// RVA: 0xF2B848
	void CheckToken(Tokens token) { }

	// RVA: 0xF2AE90
	Tokens Scan() { }

	// RVA: 0xF2C184
	void ScanNumeric() { }

	// RVA: 0xF2C568
	void ScanName() { }

	// RVA: 0xF2BFF8
	void ScanName(Char chEnd, Char esc, string charsToEscape) { }

	// RVA: 0xF2BE50
	void ScanDate() { }

	// RVA: 0xF2C2C4
	void ScanBinaryConstant() { }

	// RVA: 0xF2C2D8
	void ScanReserved() { }

	// RVA: 0xF2BF10
	void ScanString(Char escape) { }

	// RVA: 0xF2B7EC
	void ScanToken(Tokens token) { }

	// RVA: 0xF2BDE4
	void ScanWhite() { }

	// RVA: 0xF2C5F4
	bool IsWhiteSpace(Char ch) { }

	// RVA: 0xF2C51C
	bool IsAlphaNumeric(Char ch) { }

	// RVA: 0xF2C2C8
	bool IsDigit(Char ch) { }

	// RVA: 0xF2C5D4
	bool IsAlpha(Char ch) { }

	// RVA: 0xF2C604
	void .cctor() { }

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

	// RVA: 0xF2CAC0
	void .ctor(Nodes type, int op, int pri) { }

}

// Namespace: System.Data
public class InvalidExpressionException 
{
	// Methods

	// RVA: 0xF2CB00
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2CB08
	void .ctor() { }

	// RVA: 0xF2CB10
	void .ctor(string s) { }

}

// Namespace: System.Data
public class EvaluateException 
{
	// Methods

	// RVA: 0xF2CB18
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2CB20
	void .ctor() { }

	// RVA: 0xF2CB28
	void .ctor(string s) { }

}

// Namespace: System.Data
public class SyntaxErrorException 
{
	// Methods

	// RVA: 0xF2CB30
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2CB38
	void .ctor() { }

	// RVA: 0xF2CB40
	void .ctor(string s) { }

}

// Namespace: System.Data
internal sealed class ExprException 
{
	// Methods

	// RVA: 0xF2CB48
	OverflowException _Overflow(string error) { }

	// RVA: 0xF2CBBC
	InvalidExpressionException _Expr(string error) { }

	// RVA: 0xF2CC30
	SyntaxErrorException _Syntax(string error) { }

	// RVA: 0xF2CCA4
	EvaluateException _Eval(string error) { }

	// RVA: 0xF2CD18
	EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0xF2CD8C
	Exception InvokeArgument() { }

	// RVA: 0xF2CDD4
	Exception NYI(string moreinfo) { }

	// RVA: 0xF2CE84
	Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0xF2D060
	Exception MissingOperator(string token) { }

	// RVA: 0xF2D110
	Exception TypeMismatch(string expr) { }

	// RVA: 0xF2D1C0
	Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0xF2D22C
	Exception ExpressionTooComplex() { }

	// RVA: 0xF2D2C8
	Exception UnboundName(string name) { }

	// RVA: 0xF2D378
	Exception InvalidString(string str) { }

	// RVA: 0xF2D428
	Exception UndefinedFunction(string name) { }

	// RVA: 0xF2D4D8
	Exception SyntaxError() { }

	// RVA: 0xF2D574
	Exception FunctionArgumentCount(string name) { }

	// RVA: 0xF2D624
	Exception MissingRightParen() { }

	// RVA: 0xF2D6C0
	Exception UnknownToken(string token, int position) { }

	// RVA: 0xF2D7BC
	Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0xF2D918
	Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0xF2DA00
	Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0xF2DAE8
	Exception InvalidName(string name) { }

	// RVA: 0xF2DB98
	Exception InvalidDate(string date) { }

	// RVA: 0xF2DC48
	Exception NonConstantArgument() { }

	// RVA: 0xF2DCE4
	Exception InvalidPattern(string pat) { }

	// RVA: 0xF2DD94
	Exception InWithoutParentheses() { }

	// RVA: 0xF2DE30
	Exception InWithoutList() { }

	// RVA: 0xF2DECC
	Exception InvalidIsSyntax() { }

	// RVA: 0xF2DF68
	Exception Overflow(Type type) { }

	// RVA: 0xF2E030
	Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0xF2E150
	Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0xF2E24C
	Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0xF2E390
	Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0xF2E4D4
	Exception UnsupportedOperator(int op) { }

	// RVA: 0xF2E5B0
	Exception InvalidNameBracketing(string name) { }

	// RVA: 0xF2E660
	Exception MissingOperandBefore(string op) { }

	// RVA: 0xF2E710
	Exception TooManyRightParentheses() { }

	// RVA: 0xF2E7AC
	Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0xF2E864
	EvaluateException BindFailure(string relationName) { }

	// RVA: 0xF2E914
	Exception AggregateArgument() { }

	// RVA: 0xF2E9B0
	Exception AggregateUnbound(string expr) { }

	// RVA: 0xF2EA60
	Exception EvalNoContext() { }

	// RVA: 0xF2EAFC
	Exception ExpressionUnbound(string expr) { }

	// RVA: 0xF2EBAC
	Exception ComputeNotAggregate(string expr) { }

	// RVA: 0xF2EC5C
	Exception FilterConvertion(string expr) { }

	// RVA: 0xF2ED0C
	Exception LookupArgument() { }

	// RVA: 0xF2EDA8
	Exception InvalidType(string typeName) { }

	// RVA: 0xF2EE58
	Exception InvalidHoursArgument() { }

	// RVA: 0xF2EEF4
	Exception InvalidMinutesArgument() { }

	// RVA: 0xF2EF90
	Exception InvalidTimeZoneRange() { }

	// RVA: 0xF2F02C
	Exception MismatchKindandTimeSpan() { }

	// RVA: 0xF2F0C8
	Exception UnsupportedDataType(Type type) { }

}

// Namespace: System.Data
internal interface IFilter 
{
	// Methods

	// RVA: 0x2FE31E0
	bool Invoke(DataRow row, DataRowVersion version) { }

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

	// RVA: 0xF2F13C
	void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0xF2F18C
	void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF2F410
	object Eval() { }

	// RVA: 0xF2F43C
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF2F55C
	object Eval(int[] recordNos) { }

	// RVA: 0xF2F594
	bool IsConstant() { }

	// RVA: 0xF2F59C
	bool IsTableConstant() { }

	// RVA: 0xF2F5A4
	bool HasLocalAggregate() { }

	// RVA: 0xF2F5AC
	bool HasRemoteAggregate() { }

	// RVA: 0xF2F5B4
	bool DependsOn(DataColumn column) { }

	// RVA: 0xF2F5C4
	ExpressionNode Optimize() { }

}

// Namespace: System.Data
internal sealed class NameNode 
{
	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Methods

	// RVA: 0xF2F5C8
	void .ctor(DataTable table, Char[] text, int start, int pos) { }

	// RVA: 0xF2F86C
	void .ctor(DataTable table, string name) { }

	// RVA: 0xF2F8A0
	bool get_IsSqlColumn() { }

	// RVA: 0xF2F8C0
	void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF2FAF0
	object Eval() { }

	// RVA: 0xF2FB1C
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF2FBC4
	object Eval(int[] records) { }

	// RVA: 0xF2FBFC
	bool IsConstant() { }

	// RVA: 0xF2FC04
	bool IsTableConstant() { }

	// RVA: 0xF2FC5C
	bool HasLocalAggregate() { }

	// RVA: 0xF2FCB4
	bool HasRemoteAggregate() { }

	// RVA: 0xF2FD0C
	bool DependsOn(DataColumn column) { }

	// RVA: 0xF2FD74
	ExpressionNode Optimize() { }

	// RVA: 0xF2F61C
	string ParseName(Char[] text, int start, int pos) { }

}

// Namespace: System.Data
internal sealed class Operators 
{
	// Fields
	private static readonly int[] s_priority; // 0x0
	private static readonly string[] s_looks; // 0x8

	// Methods

	// RVA: 0xF2FD78
	bool IsArithmetical(int op) { }

	// RVA: 0xF2FD94
	bool IsLogical(int op) { }

	// RVA: 0xF2FDB4
	bool IsRelational(int op) { }

	// RVA: 0xF2FDC4
	int Priority(int op) { }

	// RVA: 0xF2CF6C
	string ToString(int op) { }

	// RVA: 0xF2FEA4
	void .cctor() { }

}

// Namespace: System.Data
internal sealed class UnaryNode 
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0xF30744
	void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0xF30788
	void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF307DC
	object Eval() { }

	// RVA: 0xF307F0
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF30F24
	object Eval(int[] recordNos) { }

	// RVA: 0xF30834
	object EvalUnaryOp(int op, object vl) { }

	// RVA: 0xF30F48
	bool IsConstant() { }

	// RVA: 0xF30F6C
	bool IsTableConstant() { }

	// RVA: 0xF30F90
	bool HasLocalAggregate() { }

	// RVA: 0xF30FB4
	bool HasRemoteAggregate() { }

	// RVA: 0xF30FD8
	bool DependsOn(DataColumn column) { }

	// RVA: 0xF31000
	ExpressionNode Optimize() { }

}

// Namespace: System.Data
internal sealed class ZeroOpNode 
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0xF310D0
	void .ctor(int op) { }

	// RVA: 0xF31100
	void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF31104
	object Eval() { }

	// RVA: 0xF31200
	object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF3120C
	object Eval(int[] recordNos) { }

	// RVA: 0xF31218
	bool IsConstant() { }

	// RVA: 0xF31220
	bool IsTableConstant() { }

	// RVA: 0xF31228
	bool HasLocalAggregate() { }

	// RVA: 0xF31230
	bool HasRemoteAggregate() { }

	// RVA: 0xF31238
	ExpressionNode Optimize() { }

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

	// RVA: 0xF3123C
	void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF31288
	void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF3146C
	void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0xF31518
	DataKey get_ChildKey() { }

	// RVA: 0xF31540
	DataColumn[] get_Columns() { }

	// RVA: 0xF3156C
	DataTable get_Table() { }

	// RVA: 0xF31598
	string[] get_ParentColumnNames() { }

	// RVA: 0xF315A4
	string[] get_ChildColumnNames() { }

	// RVA: 0xF315B0
	void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xF316D8
	bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xF316E0
	bool IsKeyNull(object[] values) { }

	// RVA: 0xF3179C
	bool IsConstraintViolated() { }

	// RVA: 0xF31F04
	bool CanEnableConstraint() { }

	// RVA: 0xF3219C
	void CascadeCommit(DataRow row) { }

	// RVA: 0xF32378
	void CascadeDelete(DataRow row) { }

	// RVA: 0xF329F8
	void CascadeRollback(DataRow row) { }

	// RVA: 0xF32C58
	void CascadeUpdate(DataRow row) { }

	// RVA: 0xF33194
	void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0xF33278
	void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0xF33354
	void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0xF33484
	void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0xF337B4
	void NonVirtualCheckState() { }

	// RVA: 0xF33A14
	void CheckState() { }

	// RVA: 0xF33A18
	AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0xF33A40
	void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0xF33AA0
	bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF33AEC
	Constraint Clone(DataSet destination) { }

	// RVA: 0xF33AFC
	Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xF342EC
	ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0xF312D8
	void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF34964
	Rule get_DeleteRule() { }

	// RVA: 0xF3498C
	void set_DeleteRule(Rule value) { }

	// RVA: 0xF349EC
	bool Equals(object key) { }

	// RVA: 0xF34B08
	int GetHashCode() { }

	// RVA: 0xF34B10
	DataColumn[] get_RelatedColumns() { }

	// RVA: 0xF342C4
	DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0xF3332C
	DataKey get_ParentKey() { }

	// RVA: 0xF34B3C
	DataRelation FindParentRelation() { }

	// RVA: 0xF34C14
	DataTable get_RelatedTable() { }

	// RVA: 0xF34C40
	Rule get_UpdateRule() { }

	// RVA: 0xF34C68
	void set_UpdateRule(Rule value) { }

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

	// RVA: 0xF34CC8
	void .ctor(DataTable table, string conflict) { }

	// RVA: 0xF34D5C
	string get_Conflict() { }

}

// Namespace: System.Data
public sealed class MergeFailedEventHandler 
{
	// Methods

	// RVA: 0xF34D64
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0xF34E88
	internal void Invoke(object sender, MergeFailedEventArgs e) { }

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

	// RVA: 0xF34E9C
	void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF34EF4
	void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF34F54
	void MergeDataSet(DataSet source) { }

	// RVA: 0xF36C08
	void MergeTable(DataTable src) { }

	// RVA: 0xF36E88
	void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0xF374EC
	DataTable MergeSchema(DataTable table) { }

	// RVA: 0xF35F1C
	void MergeTableData(DataTable src) { }

	// RVA: 0xF35FD4
	void MergeConstraints(DataSet source) { }

	// RVA: 0xF37C38
	void MergeConstraints(DataTable table) { }

	// RVA: 0xF36050
	void MergeRelation(DataRelation relation) { }

	// RVA: 0xF36980
	void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0xF37368
	DataKey GetSrcKey(DataTable src, DataTable dst) { }

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

	// RVA: 0xF37EF4
	void .ctor() { }

	// RVA: 0xF37FA8
	bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xF37FB0
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF3807C
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Data
public class PropertyCollection 
{
	// Methods

	// RVA: 0xF382B0
	void .ctor() { }

	// RVA: 0xF382B8
	void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF382C0
	object Clone() { }

}

// Namespace: System.Data
internal struct Range 
{
	// Fields
	private int _min; // 0x10
	private int _max; // 0x14
	private bool _isNotNull; // 0x18

	// Methods

	// RVA: 0xF385C0
	void .ctor(int min, int max) { }

	// RVA: 0xF328E8
	int get_Count() { }

	// RVA: 0xF32368
	bool get_IsNull() { }

	// RVA: 0xF32908
	int get_Min() { }

	// RVA: 0xF38618
	void CheckNull() { }

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

	// RVA: 0x2FE4314
	void .ctor(int nodeID, int mainTreeNodeID) { }

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

	// RVA: 0x2FE42A4
	void .ctor(int size) { }

	// RVA: 0x2FE3404
	int AllocSlot(System.Data.RBTree<K> tree) { }

	// RVA: 0x2FE32D4
	int get_InUseCount() { }

	// RVA: 0x2FE42A4
	void set_InUseCount(int value) { }

	// RVA: 0x2FE32D4
	int get_PageId() { }

	// RVA: 0x2FE42A4
	void set_PageId(int value) { }

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

	// RVA: 0x2FE4574
	void .ctor(System.Data.RBTree<K> tree) { }

	// RVA: 0x2FE45DC
	void .ctor(System.Data.RBTree<K> tree, int position) { }

	// RVA: 0x2FE41A8
	void Dispose() { }

	// RVA: 0x2FE3054
	bool MoveNext() { }

	// RVA: 0x309AF8C
	K get_Current() { }

	// RVA: 0x2FE360C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2FE41A8
	void System.Collections.IEnumerator.Reset() { }

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

	// RVA: 0x309AF8C
	int CompareNode(K record1, K record2) { }

	// RVA: 0x309AF8C
	int CompareSateliteTreeNode(K record1, K record2) { }

	// RVA: 0x2FE42A4
	void .ctor(TreeAccessMethod accessMethod) { }

	// RVA: 0x2FE41A8
	void InitTree() { }

	// RVA: 0x2FE4574
	void FreePage(TreePage page) { }

	// RVA: -1
	TreePage AllocPage(int size) { }

	// RVA: 0x2FE4574
	void MarkPageFull(TreePage page) { }

	// RVA: 0x2FE4574
	void MarkPageFree(TreePage page) { }

	// RVA: 0x309AF8C
	int GetIntValueFromBitMap(UInt32 bitMap) { }

	// RVA: 0x2FE42A4
	void FreeNode(int nodeId) { }

	// RVA: -1
	int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }

	// RVA: 0x2FE32D4
	int get_Count() { }

	// RVA: 0x2FE3054
	bool get_HasDuplicates() { }

	// RVA: 0x309AF8C
	int GetNewNode(K key) { }

	// RVA: -1
	int Successor(int x_id) { }

	// RVA: -1
	bool Successor(ref int nodeId, ref int mainTreeNodeId) { }

	// RVA: -1
	int Minimum(int x_id) { }

	// RVA: -1
	int LeftRotate(int root_id, int x_id, int mainTreeNode) { }

	// RVA: -1
	int RightRotate(int root_id, int x_id, int mainTreeNode) { }

	// RVA: 0x309AF8C
	int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }

	// RVA: 0x309AF8C
	void UpdateNodeKey(K currentKey, K newKey) { }

	// RVA: 0x309AF8C
	K DeleteByIndex(int i) { }

	// RVA: -1
	int RBDelete(int z_id) { }

	// RVA: -1
	int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }

	// RVA: 0x309AF8C
	int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }

	// RVA: 0x309AF8C
	int SearchSubTree(int root_id, K key) { }

	// RVA: 0x309AF8C
	K get_Item(int index) { }

	// RVA: 0x309AF8C
	NodePath GetNodeByKey(K key) { }

	// RVA: 0x309AF8C
	int GetIndexByKey(K key) { }

	// RVA: -1
	int GetIndexByNode(int node) { }

	// RVA: 0x309AF8C
	int GetIndexByNodePath(NodePath path) { }

	// RVA: -1
	int ComputeIndexByNode(int nodeId) { }

	// RVA: -1
	int ComputeIndexWithSatelliteByNode(int nodeId) { }

	// RVA: 0x309AF8C
	NodePath GetNodeByIndex(int userIndex) { }

	// RVA: -1
	int ComputeNodeByIndex(int index, out int satelliteRootId) { }

	// RVA: 0x2FE3308
	int ComputeNodeByIndex(int x_id, int index) { }

	// RVA: 0x309AF8C
	int Insert(K item) { }

	// RVA: 0x309AF8C
	int Add(K item) { }

	// RVA: 0x2FE360C
	IEnumerator GetEnumerator() { }

	// RVA: 0x309AF8C
	int IndexOf(int nodeId, K item) { }

	// RVA: 0x309AF8C
	int Insert(int position, K item) { }

	// RVA: 0x309AF8C
	int InsertAt(int position, K item, bool append) { }

	// RVA: 0x2FE42A4
	void RemoveAt(int position) { }

	// RVA: 0x2FE41A8
	void Clear() { }

	// RVA: 0x2FE45DC
	void CopyTo(Array array, int index) { }

	// RVA: 0x2FE45DC
	void CopyTo(K[] array, int index) { }

	// RVA: 0x2FE4314
	void SetRight(int nodeId, int rightNodeId) { }

	// RVA: 0x2FE4314
	void SetLeft(int nodeId, int leftNodeId) { }

	// RVA: 0x2FE4314
	void SetParent(int nodeId, int parentNodeId) { }

	// RVA: 0x309AF8C
	void SetColor(int nodeId, NodeColor color) { }

	// RVA: 0x309AF8C
	void SetKey(int nodeId, K key) { }

	// RVA: 0x2FE4314
	void SetNext(int nodeId, int nextNodeId) { }

	// RVA: 0x2FE4314
	void SetSubTreeSize(int nodeId, int size) { }

	// RVA: 0x2FE42A4
	void IncreaseSize(int nodeId) { }

	// RVA: 0x2FE42A4
	void RecomputeSize(int nodeId) { }

	// RVA: 0x2FE42A4
	void DecreaseSize(int nodeId) { }

	// RVA: -1
	int Right(int nodeId) { }

	// RVA: -1
	int Left(int nodeId) { }

	// RVA: -1
	int Parent(int nodeId) { }

	// RVA: 0x309AF8C
	NodeColor color(int nodeId) { }

	// RVA: -1
	int Next(int nodeId) { }

	// RVA: -1
	int SubTreeSize(int nodeId) { }

	// RVA: 0x309AF8C
	K Key(int nodeId) { }

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

	// RVA: 0xF3865C
	void .ctor(DataTable table) { }

	// RVA: 0xF38740
	void GrowRecordCapacity() { }

	// RVA: 0xF38938
	int get_LastFreeRecord() { }

	// RVA: 0xF38940
	int get_MinimumCapacity() { }

	// RVA: 0xF38948
	void set_MinimumCapacity(int value) { }

	// RVA: 0xF38998
	int get_RecordCapacity() { }

	// RVA: 0xF3889C
	void set_RecordCapacity(int value) { }

	// RVA: 0xF38854
	int NewCapacity(int capacity) { }

	// RVA: 0xF38868
	int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0xF389A0
	int NewRecordBase() { }

	// RVA: 0xF38A88
	void FreeRecord(ref int record) { }

	// RVA: 0xF38C38
	void Clear(bool clearAll) { }

	// RVA: 0xF38EA8
	DataRow get_Item(int record) { }

	// RVA: 0xF38BC4
	void set_Item(int record, DataRow value) { }

	// RVA: 0xF38EDC
	int ImportRecord(DataTable src, int record) { }

	// RVA: 0xF38EE4
	int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0xF39328
	void SetRowCache(DataRow[] newRows) { }

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

	// RVA: 0xF3936C
	void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0xF394B4
	void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0xF395F8
	object[] GetParentValues() { }

	// RVA: 0xF396B0
	bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xF39844
	IFilter GetFilter() { }

	// RVA: 0xF39848
	DataRowView AddNew() { }

	// RVA: 0xF398AC
	void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

// Namespace: System.Data
internal sealed class RelationshipConverter 
{
	// Methods

	// RVA: 0xF398DC
	void .ctor() { }

	// RVA: 0xF398E4
	bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF399B0
	object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

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

	// RVA: 0xF3A5D8
	void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0xF3A604
	bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0xF3A618
	bool Equals(object obj) { }

	// RVA: 0xF3A6B8
	int GetHashCode() { }

}

// Namespace: 
private sealed class IndexTree 
{
	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0xF3D6C8
	void .ctor(Index index) { }

	// RVA: 0xF3E3C8
	int CompareNode(int record1, int record2) { }

	// RVA: 0xF3E3E4
	int CompareSateliteTreeNode(int record1, int record2) { }

}

// Namespace: 
private sealed class <>c 
{
	// Fields
	public static readonly System.Data.Index.<>c <>9; // 0x0
	public static System.Data.Listeners.Func<System.Data.DataViewListener,System.Data.DataViewListener,System.Boolean> <>9__22_0; // 0x8
	public static System.Data.Listeners.Action<System.Data.DataViewListener,System.Data.DataViewListener,System.ComponentModel.ListChangedEventArgs,System.Boolean,System.Boolean> <>9__85_0; // 0x10

	// Methods

	// RVA: 0xF3E400
	void .cctor() { }

	// RVA: 0xF3E46C
	void .ctor() { }

	// RVA: 0xF3E474
	bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0xF3E480
	void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

}

// Namespace: 
private sealed class <>c__DisplayClass86_0 
{
	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0xF3D950
	void .ctor() { }

	// RVA: 0xF3E4A0
	void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }

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

	// RVA: 0xF3A740
	void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF3AAA4
	void .ctor(DataTable table, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF3AB08
	IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0xF3A750
	void .ctor(DataTable table, IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF3B028
	bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF3B0C8
	bool get_HasRemoteAggregate() { }

	// RVA: 0xF3B0D0
	int get_ObjectID() { }

	// RVA: 0xF3B0D8
	DataViewRowState get_RecordStates() { }

	// RVA: 0xF3B0E0
	IFilter get_RowFilter() { }

	// RVA: 0xF3B15C
	int GetRecord(int recordIndex) { }

	// RVA: 0xF3B1D4
	bool get_HasDuplicates() { }

	// RVA: 0xF3B228
	int get_RecordCount() { }

	// RVA: 0xF3B230
	bool AcceptRecord(int record) { }

	// RVA: 0xF3B2E0
	bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0xF3B4FC
	void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0xF3B560
	void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0xF3B5C4
	int get_RefCount() { }

	// RVA: 0xF3B5CC
	void AddRef() { }

	// RVA: 0xF3B7AC
	int RemoveRef() { }

	// RVA: 0xF3B9AC
	void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0xF3C020
	bool CheckUnique() { }

	// RVA: 0xF3C07C
	int CompareRecords(int record1, int record2) { }

	// RVA: 0xF3C224
	int CompareDataRows(int record1, int record2) { }

	// RVA: 0xF3C28C
	int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0xF3C434
	int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0xF3C518
	void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0xF3BFA4
	void DeleteRecord(int recordIndex) { }

	// RVA: 0xF3C520
	void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0xF3C8C4
	RBTreeEnumerator GetEnumerator(int startIndex) { }

	// RVA: 0xF3BFAC
	int GetIndex(int record) { }

	// RVA: 0xF3BDFC
	int GetIndex(int record, int changeRecord) { }

	// RVA: 0xF31AE8
	object[] GetUniqueKeyValues() { }

	// RVA: 0xF3CB3C
	int FindNodeByKey(object originalKey) { }

	// RVA: 0xF3CD80
	int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0xF3D008
	int FindNodeByKeyRecord(int record) { }

	// RVA: 0xF3D118
	Range GetRangeFromNode(int nodeId) { }

	// RVA: 0xF3D254
	Range FindRecords(object key) { }

	// RVA: 0xF31C74
	Range FindRecords(object[] key) { }

	// RVA: 0xF3D284
	void FireResetEvent() { }

	// RVA: 0xF3D650
	int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF3D66C
	int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0xF32950
	DataRow GetRow(int i) { }

	// RVA: 0xF3D68C
	DataRow[] GetRows(object[] values) { }

	// RVA: 0xF31CA4
	DataRow[] GetRows(Range range) { }

	// RVA: 0xF3AC08
	void InitRecords(IFilter filter) { }

	// RVA: 0xF3D734
	int InsertRecordToIndex(int record) { }

	// RVA: 0xF3BB3C
	int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0xF3D808
	bool IsKeyInIndex(object key) { }

	// RVA: 0xF31C58
	bool IsKeyInIndex(object[] key) { }

	// RVA: 0xF3D824
	bool IsKeyRecordInIndex(int record) { }

	// RVA: 0xF3D3F8
	bool get_DoListChanged() { }

	// RVA: 0xF3D840
	void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0xF3C7C8
	void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0xF3D480
	void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF3C678
	void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0xF3D958
	void Reset() { }

	// RVA: 0xF3DAB4
	void RecordChanged(int record) { }

	// RVA: 0xF3DC50
	void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0xF3DDB4
	void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF3DEE8
	void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0xF3E3C0
	DataTable get_Table() { }

	// RVA: 0xF3C938
	void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId) { }

	// RVA: 0x309AF8C
	int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

}

// Namespace: 
internal sealed class Action<T0, T1, T2, T3> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

}

// Namespace: 
internal sealed class Func<T0, T1> 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal TResult Invoke(T1 arg1) { }

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

	// RVA: 0x2FE440C
	void .ctor(int ObjectID, System.Data.Listeners.Func<TElem,TElem,System.Boolean> notifyFilter) { }

	// RVA: 0x2FE3054
	bool get_HasListeners() { }

	// RVA: 0x309AF8C
	void Add(TElem listener) { }

	// RVA: 0x309AF8C
	int IndexOfReference(TElem listener) { }

	// RVA: 0x309AF8C
	void Remove(TElem listener) { }

	// RVA: 0x309AF8C
	void Notify(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem,TElem,T1,T2,T3> action) { }

	// RVA: 0x2FE42A4
	void RemoveNullListeners(int nullIndex) { }

}

// Namespace: System.Data
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

	// RVA: 0xF3E4D0
	void .ctor(string baseType) { }

	// RVA: 0xF3E608
	void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0xF3F1B4
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF3E7FC
	void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0xF3F1F4
	bool IsPlainString() { }

	// RVA: 0xF3F338
	string get_BaseType() { }

	// RVA: 0xF3F340
	XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0xF3F348
	string get_Name() { }

	// RVA: 0xF3F350
	string get_Namespace() { }

	// RVA: 0xF3F358
	int get_Length() { }

	// RVA: 0xF3F360
	int get_MaxLength() { }

	// RVA: 0xF3F368
	void set_MaxLength(int value) { }

	// RVA: 0xF3F370
	SimpleType get_BaseSimpleType() { }

	// RVA: 0xF3F378
	string get_SimpleTypeQualifiedName() { }

	// RVA: 0xF3F3EC
	string QualifiedName(string name) { }

	// RVA: 0xF3F46C
	XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0xF3F970
	SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0xF3FA00
	SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0xF3FA74
	SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0xF3FAF8
	SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0xF3FC04
	string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0xF3FD50
	bool CanHaveMaxLength() { }

	// RVA: 0xF3FDB8
	void ConvertToAnnonymousSimpleType() { }

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

	// RVA: 0xF3FE68
	void .ctor(DataColumn column) { }

	// RVA: 0xF40024
	void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0xF40064
	void .ctor(DataColumn[] columns) { }

	// RVA: 0xF40098
	void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0xF400F4
	void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0xF4013C
	string[] get_ColumnNames() { }

	// RVA: 0xF40148
	Index get_ConstraintIndex() { }

	// RVA: 0xF40150
	void ConstraintIndexClear() { }

	// RVA: 0xF40190
	void ConstraintIndexInitialize() { }

	// RVA: 0xF401EC
	void CheckState() { }

	// RVA: 0xF401F8
	void NonVirtualCheckState() { }

	// RVA: 0xF40204
	void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xF40208
	bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xF4039C
	bool CanEnableConstraint() { }

	// RVA: 0xF4042C
	bool IsConstraintViolated() { }

	// RVA: 0xF406C0
	void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xF407C4
	bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF407D0
	Constraint Clone(DataSet destination) { }

	// RVA: 0xF407E0
	Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xF40D9C
	UniqueConstraint Clone(DataTable table) { }

	// RVA: 0xF412B4
	DataColumn[] get_Columns() { }

	// RVA: 0xF407BC
	DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF412C0
	bool get_IsPrimaryKey() { }

	// RVA: 0xF3FF28
	void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0xF41310
	bool Equals(object key2) { }

	// RVA: 0xF413C8
	int GetHashCode() { }

	// RVA: 0xF413D0
	void set_InCollection(bool value) { }

	// RVA: 0xF4141C
	DataKey get_Key() { }

	// RVA: 0xF41424
	DataTable get_Table() { }

}

// Namespace: 
private sealed class NameType 
{
	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0xF45038
	void .ctor(string n, Type t) { }

	// RVA: 0xF45088
	int CompareTo(object obj) { }

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

	// RVA: 0xF41468
	void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0xF41510
	void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0xF4195C
	XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0xF41CB0
	bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0xF41EC0
	bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0xF4178C
	DataTable HandleTable(XmlElement node) { }

	// RVA: 0xF4293C
	NameType FindNameType(string name) { }

	// RVA: 0xF42A40
	Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0xF42BA4
	string GetInstanceName(XmlElement node) { }

	// RVA: 0xF42D28
	void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0xF42040
	void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xF436E0
	void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0xF43A3C
	void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0xF4228C
	DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0xF42050
	DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0xF43C38
	void .cctor() { }

}

// Namespace: System.Data
internal sealed class XMLDiffLoader 
{
	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0xF45104
	void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0xF45A1C
	void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xF45D94
	void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0xF452BC
	void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0xF45FB0
	void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0xF45674
	void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0xF4633C
	void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0xF477E8
	DataTable GetTable(string tableName, string ns) { }

	// RVA: 0xF46858
	int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0xF467EC
	void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0xF479D0
	void .ctor() { }

}

// Namespace: System.Data
internal class XMLSchema 
{
	// Methods

	// RVA: 0xF479D8
	TypeConverter GetConverter(Type type) { }

	// RVA: 0xF47A60
	void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xF47F00
	bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0xF47F8C
	bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0xF48118
	string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0xF48244
	void .ctor() { }

}

// Namespace: System.Data
internal sealed class ConstraintTable 
{
	// Fields
	public DataTable table; // 0x10
	public XmlSchemaIdentityConstraint constraint; // 0x18

	// Methods

	// RVA: 0xF4824C
	void .ctor(DataTable t, XmlSchemaIdentityConstraint c) { }

}

// Namespace: 
private sealed class NameType 
{
	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0xF594C8
	void .ctor(string n, Type t) { }

	// RVA: 0xF59518
	int CompareTo(object obj) { }

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

	// RVA: 0xF4829C
	bool get_FromInference() { }

	// RVA: 0xF482A4
	void set_FromInference(bool value) { }

	// RVA: 0xF482AC
	void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0xF48338
	void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0xF48E30
	string QualifiedName(string name) { }

	// RVA: 0xF48EB0
	void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF4945C
	void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF4981C
	void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF48D08
	string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0xF49A28
	void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xF49C70
	void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0xF49E5C
	void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0xF4A6D4
	bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xF4A92C
	bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0xF4B338
	int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0xF4B700
	XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0xF4BCF4
	void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0xF4BD1C
	void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0xF4F490
	void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0xF4AEAC
	XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0xF4F7CC
	void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0xF510A0
	void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0xF51E2C
	void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0xF521E0
	void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0xF4BBBC
	XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0xF53A5C
	DataColumn FindField(DataTable table, string field) { }

	// RVA: 0xF53BE0
	DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0xF4B550
	bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0xF4DD40
	string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0xF53F08
	AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0xF53FA4
	Rule TranslateRule(string strRule) { }

	// RVA: 0xF540C0
	void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0xF54AA8
	void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0xF54F5C
	DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0xF49D5C
	string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0xF55B9C
	DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0xF57290
	Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0xF5739C
	NameType FindNameType(string name) { }

	// RVA: 0xF574A0
	Type ParseDataType(string dt) { }

	// RVA: 0xF57690
	bool IsXsdType(string name) { }

	// RVA: 0xF4DDEC
	XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0xF52F90
	void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xF527E0
	void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xF51370
	void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0xF50114
	void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0xF4E2B0
	void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0xF5770C
	void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, DataTable dt) { }

	// RVA: 0xF55798
	string GetPrefix(string ns) { }

	// RVA: 0xF5795C
	string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0xF57100
	string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xF54978
	string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xF4B0D8
	bool IsTable(XmlSchemaElement node) { }

	// RVA: 0xF4E104
	DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0xF57D68
	void .ctor() { }

	// RVA: 0xF57D70
	void .cctor() { }

}

// Namespace: System.Data
internal sealed class XmlIgnoreNamespaceReader 
{
	// Fields
	private System.Collections.Generic.List<System.String> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0xF59594
	void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0xF59638
	bool MoveToFirstAttribute() { }

	// RVA: 0xF59744
	bool MoveToNextAttribute() { }

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

	// RVA: 0xF59888
	void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xF59930
	void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xF59A30
	void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xF59AF0
	void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xF59C08
	bool get_FromInference() { }

	// RVA: 0xF59C10
	void set_FromInference(bool value) { }

	// RVA: 0xF59C18
	void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xF59E98
	int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0xF5A090
	string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0xF5A384
	string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0xF5A638
	DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0xF59DF4
	DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0xF5A70C
	bool FColumnElement(XmlElement e) { }

	// RVA: 0xF59FF4
	bool FExcludedNamespace(string ns) { }

	// RVA: 0xF5A824
	bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0xF5AB58
	bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0xF5A328
	bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0xF5A6D4
	bool IsTextOnly(DataColumn c) { }

	// RVA: 0xF5ABF8
	void LoadData(XmlDocument xdoc) { }

	// RVA: 0xF5B08C
	void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0xF5BCDC
	void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xF5C094
	void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0xF5C110
	void InitNameTable() { }

	// RVA: 0xF5C41C
	void LoadData(XmlReader reader) { }

	// RVA: 0xF5C8CC
	void LoadTopMostTable(DataTable table) { }

	// RVA: 0xF5D5FC
	void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0xF5E5E0
	void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0xF5D3B0
	bool ProcessXsdSchema() { }

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

	// RVA: 0xF619EC
	void .ctor(string localName, string namespaceURI) { }

	// RVA: 0xF61A3C
	int GetHashCode() { }

	// RVA: 0xF61A60
	bool Equals(object obj) { }

}

// Namespace: 
internal sealed class XmlNodeIdHashtable 
{
	// Fields
	private XmlNodeIdentety _id; // 0x50

	// Methods

	// RVA: 0xF61B08
	void .ctor(int capacity) { }

	// RVA: 0xF61BD0
	object get_Item(XmlNode node) { }

	// RVA: 0xF61C6C
	object get_Item(XmlReader dataReader) { }

	// RVA: 0xF61D00
	object get_Item(DataTable table) { }

	// RVA: 0xF61D8C
	object get_Item(string name) { }

}

// Namespace: 
private sealed class TableSchemaInfo 
{
	// Fields
	public DataTable TableSchema; // 0x10
	public XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0xF61E24
	void .ctor(DataTable tableSchema) { }

}

// Namespace: System.Data
internal sealed class XmlToDatasetMap 
{
	// Fields
	private XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0xF5AF58
	void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xF5C84C
	void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xF5AF18
	void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xF5C88C
	void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xF5C0E0
	bool IsMappedColumn(DataColumn c) { }

	// RVA: 0xF60E5C
	TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0xF60F9C
	TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0xF61138
	bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	// RVA: 0xF613D4
	bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns) { }

	// RVA: 0xF5F030
	void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xF5F60C
	void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xF600AC
	void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xF60400
	void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xF615A0
	ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0xF5A914
	object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xF5E47C
	object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0xF5AF98
	object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xF5D2BC
	DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0xF61270
	void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

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

	// RVA: 0xF61ED0
	void .ctor(SchemaFormat format) { }

	// RVA: 0xF61F80
	void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0xF61F88
	void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0xF626CC
	void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xF62888
	void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xF631BC
	string XmlDataTypeName(Type type) { }

	// RVA: 0xF64240
	void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0xF64734
	void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0xF64834
	void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0xF64B0C
	bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0xF64B38
	bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0xF64CE8
	void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0xF64F5C
	void ValidateColumnMapping(Type columnType) { }

	// RVA: 0xF6500C
	void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0xF65D70
	void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0xF652E0
	void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0xF664A0
	void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xF66818
	void CreateRelations(DataTable dt) { }

	// RVA: 0xF66B60
	DataTable[] CreateToplevelTables() { }

	// RVA: 0xF66E8C
	void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0xF6A6C0
	XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0xF699C4
	XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0xF6D908
	void SetPath(XmlWriter xw) { }

	// RVA: 0xF6DC28
	void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0xF6DC48
	void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0xF6DC3C
	void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0xF6DD14
	void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0xF6DD1C
	void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xF6A0F4
	XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0xF6DE80
	XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0xF6DF7C
	XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0xF6E220
	void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0xF6E7A4
	void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0xF6EDAC
	string FindTargetNamespace(DataTable table) { }

	// RVA: 0xF6EED8
	XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0xF6FCCC
	string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0xF6FD54
	string TranslateRule(Rule rule) { }

	// RVA: 0xF6A038
	void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0xF6FAF0
	XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0xF6A030
	XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0xF6FE3C
	bool HasMixedColumns(DataTable table) { }

	// RVA: 0xF65E6C
	bool AutoGenerated(DataColumn col) { }

	// RVA: 0xF701EC
	bool AutoGenerated(DataRelation rel) { }

	// RVA: 0xF663C8
	bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0xF663BC
	bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0xF702CC
	bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0xF7041C
	bool IsAutoGenerated(object o) { }

	// RVA: 0xF6AB9C
	XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0xF63FE4
	void SetMSDataAttribute(XmlElement root, Type type) { }

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

	// RVA: 0xF704E0
	void .ctor(DataSet ds) { }

	// RVA: 0xF708B8
	void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xF709E0
	void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0xF70634
	void DoAssignments(ArrayList tables) { }

	// RVA: 0xF70D58
	bool EmptyData() { }

	// RVA: 0xF70E50
	void Save(XmlWriter xmlw) { }

	// RVA: 0xF70E58
	void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0xF71FF0
	void GenerateTable(DataTable table) { }

	// RVA: 0xF72070
	void GenerateTableErrors(DataTable table) { }

	// RVA: 0xF72614
	void GenerateRow(DataRow row) { }

	// RVA: 0xF72CF8
	void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0xF70468
	string QualifiedName(string prefix, string name) { }

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

	// RVA: 0xF71C8C
	void .ctor(DataSet ds) { }

	// RVA: 0xF713C8
	void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xF73B7C
	DataTable[] CreateToplevelTables() { }

	// RVA: 0xF73804
	void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xF72C00
	bool RowHasErrors(DataRow row) { }

	// RVA: 0xF7157C
	void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0xF758D4
	void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0xF761E0
	ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0xF73EA8
	void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0xF73728
	bool PreserveSpace(object value) { }

}

// Namespace: System.Data
internal sealed class DataTextWriter 
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Methods

	// RVA: 0xF71354
	XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0xF7651C
	void .ctor(XmlWriter w) { }

	// RVA: 0xF6DB9C
	Stream get_BaseStream() { }

	// RVA: 0xF76550
	void WriteStartDocument() { }

	// RVA: 0xF76574
	void WriteStartDocument(bool standalone) { }

	// RVA: 0xF76598
	void WriteEndDocument() { }

	// RVA: 0xF765BC
	void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF765E0
	void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF76604
	void WriteEndElement() { }

	// RVA: 0xF76628
	void WriteFullEndElement() { }

	// RVA: 0xF7664C
	void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF76670
	void WriteEndAttribute() { }

	// RVA: 0xF76698
	void WriteCData(string text) { }

	// RVA: 0xF766C0
	void WriteComment(string text) { }

	// RVA: 0xF766E8
	void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xF76710
	void WriteEntityRef(string name) { }

	// RVA: 0xF76738
	void WriteCharEntity(Char ch) { }

	// RVA: 0xF76760
	void WriteWhitespace(string ws) { }

	// RVA: 0xF76788
	void WriteString(string text) { }

	// RVA: 0xF767B0
	void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0xF767D8
	void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0xF76800
	void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0xF76828
	void WriteRaw(string data) { }

	// RVA: 0xF76850
	void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0xF76878
	void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0xF768A0
	WriteState get_WriteState() { }

	// RVA: 0xF768C8
	void Close() { }

	// RVA: 0xF768F0
	void Flush() { }

	// RVA: 0xF76918
	string LookupPrefix(string ns) { }

}

// Namespace: System.Data
internal sealed class DataTextReader 
{
	// Fields
	private XmlReader _xmlreader; // 0x10

	// Methods

	// RVA: 0xF76940
	XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0xF769F0
	void .ctor(XmlReader input) { }

	// RVA: 0xF76A68
	XmlReaderSettings get_Settings() { }

	// RVA: 0xF76A8C
	XmlNodeType get_NodeType() { }

	// RVA: 0xF76AB0
	string get_Name() { }

	// RVA: 0xF76AD4
	string get_LocalName() { }

	// RVA: 0xF76AF8
	string get_NamespaceURI() { }

	// RVA: 0xF76B1C
	string get_Prefix() { }

	// RVA: 0xF76B40
	string get_Value() { }

	// RVA: 0xF76B64
	int get_Depth() { }

	// RVA: 0xF76B88
	string get_BaseURI() { }

	// RVA: 0xF76BB0
	bool get_IsEmptyElement() { }

	// RVA: 0xF76BD8
	bool get_IsDefault() { }

	// RVA: 0xF76C00
	Char get_QuoteChar() { }

	// RVA: 0xF76C28
	XmlSpace get_XmlSpace() { }

	// RVA: 0xF76C50
	string get_XmlLang() { }

	// RVA: 0xF76C78
	int get_AttributeCount() { }

	// RVA: 0xF76CA0
	string GetAttribute(string name) { }

	// RVA: 0xF76CC8
	string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xF76CF0
	string GetAttribute(int i) { }

	// RVA: 0xF76D18
	bool MoveToAttribute(string name) { }

	// RVA: 0xF76D40
	void MoveToAttribute(int i) { }

	// RVA: 0xF76D68
	bool MoveToFirstAttribute() { }

	// RVA: 0xF76D90
	bool MoveToNextAttribute() { }

	// RVA: 0xF76DB8
	bool MoveToElement() { }

	// RVA: 0xF76DE0
	bool ReadAttributeValue() { }

	// RVA: 0xF76E08
	bool Read() { }

	// RVA: 0xF76E30
	bool get_EOF() { }

	// RVA: 0xF76E58
	void Close() { }

	// RVA: 0xF76E80
	ReadState get_ReadState() { }

	// RVA: 0xF76EA8
	void Skip() { }

	// RVA: 0xF76ED0
	XmlNameTable get_NameTable() { }

	// RVA: 0xF76EF8
	string LookupNamespace(string prefix) { }

	// RVA: 0xF76F20
	bool get_CanResolveEntity() { }

	// RVA: 0xF76F48
	void ResolveEntity() { }

	// RVA: 0xF76F70
	bool get_CanReadValueChunk() { }

	// RVA: 0xF76F98
	string ReadString() { }

}

// Namespace: System.Data.SqlTypes
internal static class SQLResource 
{
	// Methods

	// RVA: 0xF76FC0
	string get_NullString() { }

	// RVA: 0xF77004
	string get_ArithOverflowMessage() { }

	// RVA: 0xF77048
	string get_DivideByZeroMessage() { }

	// RVA: 0xF7708C
	string get_NullValueMessage() { }

	// RVA: 0xF770D0
	string get_TruncationMessage() { }

	// RVA: 0xF77114
	string get_DateTimeOverflowMessage() { }

	// RVA: 0xF77158
	string get_ConcatDiffCollationMessage() { }

	// RVA: 0xF7719C
	string get_CompareDiffCollationMessage() { }

	// RVA: 0xF771E0
	string get_ConversionOverflowMessage() { }

	// RVA: 0xF77224
	string get_TimeZoneSpecifiedMessage() { }

	// RVA: 0xF77268
	string get_InvalidPrecScaleMessage() { }

	// RVA: 0xF772AC
	string get_FormatMessage() { }

	// RVA: 0xF772F0
	string InvalidOpStreamClosed(string method) { }

	// RVA: 0xF77348
	string InvalidOpStreamNonWritable(string method) { }

	// RVA: 0xF773A0
	string InvalidOpStreamNonReadable(string method) { }

	// RVA: 0xF773F8
	string InvalidOpStreamNonSeekable(string method) { }

}

// Namespace: System.Data.SqlTypes
public interface INullable 
{
	// Methods

	// RVA: 0x2FE3054
	bool get_IsNull() { }

}

// Namespace: System.Data.SqlTypes
public struct SqlBinary 
{
	// Fields
	private Byte[] _value; // 0x10
	public static readonly SqlBinary Null; // 0x0

	// Methods

	// RVA: 0xF77450
	void .ctor(bool fNull) { }

	// RVA: 0xF7745C
	void .ctor(Byte[] value) { }

	// RVA: 0xF774F8
	bool get_IsNull() { }

	// RVA: 0xF77508
	Byte[] get_Value() { }

	// RVA: 0xF775F8
	SqlBinary op_Implicit(Byte[] x) { }

	// RVA: 0xF776A0
	string ToString() { }

	// RVA: 0xF777E0
	EComparison PerformCompareByte(Byte[] x, Byte[] y) { }

	// RVA: 0xF778FC
	SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0xF77A2C
	SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xF77B48
	SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xF77C64
	int CompareTo(object value) { }

	// RVA: 0xF77D88
	int CompareTo(SqlBinary value) { }

	// RVA: 0xF78014
	bool Equals(object value) { }

	// RVA: 0xF78210
	int HashByteArray(Byte[] rgbValue, int length) { }

	// RVA: 0xF78278
	int GetHashCode() { }

	// RVA: 0xF783BC
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF783C4
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF785E8
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF7872C
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF787BC
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF77A18
	void .ctor(bool value) { }

	// RVA: 0xF78834
	void .ctor(int value) { }

	// RVA: 0xF788A4
	void .ctor(int value, bool fNull) { }

	// RVA: 0xF788C0
	bool get_IsNull() { }

	// RVA: 0xF781AC
	bool get_Value() { }

	// RVA: 0xF788D0
	bool get_IsTrue() { }

	// RVA: 0xF788E0
	bool get_IsFalse() { }

	// RVA: 0xF788F0
	SqlBoolean op_Implicit(bool x) { }

	// RVA: 0xF77FAC
	bool op_True(SqlBoolean x) { }

	// RVA: 0xF78900
	SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xF789FC
	SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xF78AE0
	Byte get_ByteValue() { }

	// RVA: 0xF78B94
	string ToString() { }

	// RVA: 0xF78CE4
	SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xF78DCC
	SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xF78F08
	SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xF7905C
	int CompareTo(object value) { }

	// RVA: 0xF79180
	int CompareTo(SqlBoolean value) { }

	// RVA: 0xF792DC
	bool Equals(object value) { }

	// RVA: 0xF79468
	int GetHashCode() { }

	// RVA: 0xF79590
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF79598
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF796DC
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF79814
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF798A4
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF79998
	void .ctor(bool fNull) { }

	// RVA: 0xF799A0
	void .ctor(Byte value) { }

	// RVA: 0xF799B0
	bool get_IsNull() { }

	// RVA: 0xF799C0
	Byte get_Value() { }

	// RVA: 0xF79A58
	SqlByte op_Implicit(Byte x) { }

	// RVA: 0xF79A64
	string ToString() { }

	// RVA: 0xF79AFC
	SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0xF79C50
	SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0xF79D9C
	SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0xF79EF0
	SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0xF7A030
	SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0xF7A1F0
	SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0xF7A308
	SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xF7A420
	SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xF7A538
	SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xF7A5C4
	SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xF7A650
	SqlDouble ToSqlDouble() { }

	// RVA: 0xF7A81C
	SqlInt64 ToSqlInt64() { }

	// RVA: 0xF7A98C
	int CompareTo(object value) { }

	// RVA: 0xF7AAB0
	int CompareTo(SqlByte value) { }

	// RVA: 0xF7AC5C
	bool Equals(object value) { }

	// RVA: 0xF7ADD4
	int GetHashCode() { }

	// RVA: 0xF7AEC8
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF7AED0
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF7B010
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF7B158
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF7B1E8
	void .cctor() { }

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
public sealed class SqlBytes 
{
	// Fields
	internal Byte[] _rgbBuf; // 0x10
	private Int64 _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private Byte[] _rgbWorkBuf; // 0x30

	// Methods

	// RVA: 0xF7B264
	void .ctor() { }

	// RVA: 0xF7B2DC
	void .ctor(Byte[] buffer) { }

	// RVA: 0xF7B360
	void .ctor(SqlBinary value) { }

	// RVA: 0xF7B484
	bool get_IsNull() { }

	// RVA: 0xF7B494
	Byte[] get_Buffer() { }

	// RVA: 0xF7B64C
	Int64 get_Length() { }

	// RVA: 0xF7B6C8
	Byte[] get_Value() { }

	// RVA: 0xF7B2A4
	void SetNull() { }

	// RVA: 0xF7B4D8
	void CopyStreamToBuffer() { }

	// RVA: 0xF7B4C8
	bool FStream() { }

	// RVA: 0xF7B8F0
	void SetBuffer(Byte[] buffer) { }

	// RVA: 0xF7B954
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF7B95C
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xF7BBE4
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF7BD18
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF7BDA8
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF7BDE8
	SqlBytes get_Null() { }

}

// Namespace: System.Data.SqlTypes
public sealed class SqlChars 
{
	// Fields
	internal Char[] _rgchBuf; // 0x10
	private Int64 _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private Char[] _rgchWorkBuf; // 0x30

	// Methods

	// RVA: 0xF7BE98
	void .ctor() { }

	// RVA: 0xF7BF10
	void .ctor(Char[] buffer) { }

	// RVA: 0xF7BF94
	void .ctor(SqlString value) { }

	// RVA: 0xF7C160
	bool get_IsNull() { }

	// RVA: 0xF7C170
	Char[] get_Buffer() { }

	// RVA: 0xF7C320
	Int64 get_Length() { }

	// RVA: 0xF7C39C
	Char[] get_Value() { }

	// RVA: 0xF7BED8
	void SetNull() { }

	// RVA: 0xF7C1A4
	bool FStream() { }

	// RVA: 0xF7C1B4
	void CopyStreamToBuffer() { }

	// RVA: 0xF7C588
	void SetBuffer(Char[] buffer) { }

	// RVA: 0xF7C5EC
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF7C5F4
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xF7C77C
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF7C88C
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF7C91C
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF7C95C
	SqlChars get_Null() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF7CA0C
	void .ctor(bool fNull) { }

	// RVA: 0xF7CA18
	void .ctor(DateTime value) { }

	// RVA: 0xF7CBB0
	void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0xF7CD04
	bool get_IsNull() { }

	// RVA: 0xF7CD14
	TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0xF7CDC0
	DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0xF7CF1C
	SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0xF7CA88
	SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0xF7D184
	DateTime get_Value() { }

	// RVA: 0xF7D234
	int get_DayTicks() { }

	// RVA: 0xF7D288
	int get_TimeTicks() { }

	// RVA: 0xF7D2DC
	SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0xF7D344
	string ToString() { }

	// RVA: 0xF7D438
	SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xF7D550
	SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xF7D674
	SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xF7D798
	SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xF7D818
	SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xF7D898
	int CompareTo(object value) { }

	// RVA: 0xF7D9AC
	int CompareTo(SqlDateTime value) { }

	// RVA: 0xF7DB74
	bool Equals(object value) { }

	// RVA: 0xF7DD04
	int GetHashCode() { }

	// RVA: 0xF7DE04
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF7DE0C
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF7E040
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF7E1B0
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF7E240
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF7E6E4
	Byte CalculatePrecision() { }

	// RVA: 0xF7E95C
	bool VerifyPrecision(Byte precision) { }

	// RVA: 0xF7EBE0
	void .ctor(bool fNull) { }

	// RVA: 0xF7EC54
	void .ctor(Decimal value) { }

	// RVA: 0xF7EE4C
	void .ctor(int value) { }

	// RVA: 0xF7F168
	void .ctor(Int64 value) { }

	// RVA: 0xF7F664
	void .ctor(UInt32[] rglData, Byte bLen, Byte bPrec, Byte bScale, bool fPositive) { }

	// RVA: 0xF7F9C8
	bool get_IsNull() { }

	// RVA: 0xF7FA44
	Decimal get_Value() { }

	// RVA: 0xF7FCB0
	bool get_IsPositive() { }

	// RVA: 0xF7F954
	void SetPositive() { }

	// RVA: 0xF7FDF8
	void SetSignBit(bool fPositive) { }

	// RVA: 0xF7FEB0
	Byte get_Scale() { }

	// RVA: 0xF7FFD0
	int[] get_Data() { }

	// RVA: 0xF80158
	string ToString() { }

	// RVA: 0xF807C0
	SqlDecimal Parse(string s) { }

	// RVA: 0xF8136C
	Double ToDouble() { }

	// RVA: 0xF7FAC4
	Decimal ToDecimal() { }

	// RVA: 0xF81540
	SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0xF81558
	SqlDecimal op_Implicit(Int64 x) { }

	// RVA: 0xF815D0
	SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0xF81870
	SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xF825D8
	SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xF826BC
	SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xF832A0
	SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xF842A8
	SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0xF84390
	SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0xF844DC
	SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0xF84698
	SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0xF84790
	SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0xF84228
	void ZeroToMaxLen(UInt32[] rgulData, int cUI4sCur) { }

	// RVA: 0xF7F934
	bool FZero() { }

	// RVA: 0xF82570
	bool FGt10_38() { }

	// RVA: 0xF849D0
	bool FGt10_38(UInt32[] rglData) { }

	// RVA: 0xF7EF50
	Byte BGetPrecUI4(UInt32 value) { }

	// RVA: 0xF7F258
	Byte BGetPrecUI8(UInt64 dwlVal) { }

	// RVA: 0xF8112C
	void AddULong(UInt32 ulAdd) { }

	// RVA: 0xF80E8C
	void MultByULong(UInt32 uiMultiplier) { }

	// RVA: 0xF84AB0
	UInt32 DivByULong(UInt32 iDivisor) { }

	// RVA: 0xF82004
	void AdjustScale(int digits, bool fRound) { }

	// RVA: 0xF823E8
	int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0xF84CE4
	void MpMove(UInt32[] rgulS, int ciulS, UInt32[] rgulD, out int ciulD) { }

	// RVA: 0xF84D54
	void MpSet(UInt32[] rgulD, out int ciulD, UInt32 iulN) { }

	// RVA: 0xF84D84
	void MpNormalize(UInt32[] rgulU, ref int ciulU) { }

	// RVA: 0xF84DD8
	void MpMul1(UInt32[] piulD, ref int ciulD, UInt32 iulX) { }

	// RVA: 0xF8067C
	void MpDiv1(UInt32[] rgulU, ref int ciulU, UInt32 iulD, out UInt32 iulR) { }

	// RVA: 0xF84EE4
	UInt64 DWL(UInt32 lo, UInt32 hi) { }

	// RVA: 0xF84ED8
	UInt32 HI(UInt64 x) { }

	// RVA: 0xF84EE0
	UInt32 LO(UInt64 x) { }

	// RVA: 0xF8383C
	void MpDiv(UInt32[] rgulU, int ciulU, UInt32[] rgulD, int ciulD, UInt32[] rgulQ, out int ciulQ, UInt32[] rgulR, out int ciulR) { }

	// RVA: 0xF84EF0
	EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0xF7F854
	void CheckValidPrecScale(Byte bPrec, Byte bScale) { }

	// RVA: 0xF853A4
	SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xF855BC
	SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xF857D4
	SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xF859EC
	SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xF85AA0
	SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xF85B54
	SqlDouble ToSqlDouble() { }

	// RVA: 0xF85D78
	SqlInt64 ToSqlInt64() { }

	// RVA: 0xF86074
	SqlMoney ToSqlMoney() { }

	// RVA: 0xF807B4
	Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0xF84A54
	void StoreFromWorkingArray(UInt32[] rguiData) { }

	// RVA: 0xF80E08
	void SetToZero() { }

	// RVA: 0xF862C0
	int CompareTo(object value) { }

	// RVA: 0xF863F4
	int CompareTo(SqlDecimal value) { }

	// RVA: 0xF86744
	bool Equals(object value) { }

	// RVA: 0xF86A9C
	int GetHashCode() { }

	// RVA: 0xF86C48
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF86C50
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF86DD4
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF86F70
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF87000
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF873BC
	void .ctor(bool fNull) { }

	// RVA: 0xF873C8
	void .ctor(Double value) { }

	// RVA: 0xF87440
	bool get_IsNull() { }

	// RVA: 0xF87450
	Double get_Value() { }

	// RVA: 0xF874A4
	SqlDouble op_Implicit(Double x) { }

	// RVA: 0xF8750C
	string ToString() { }

	// RVA: 0xF875A4
	SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0xF876BC
	SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0xF87858
	SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0xF879F4
	SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0xF87B90
	SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0xF7A6D8
	SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0xF87D64
	SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0xF87EA8
	SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0xF87FE4
	SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0xF88124
	SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0xF882C0
	SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0xF85BE0
	SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0xF88524
	SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0xF88638
	SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xF8874C
	SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xF88860
	SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xF888E0
	SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xF88960
	SqlSingle ToSqlSingle() { }

	// RVA: 0xF88AD8
	int CompareTo(object value) { }

	// RVA: 0xF88BE8
	int CompareTo(SqlDouble value) { }

	// RVA: 0xF88DA4
	bool Equals(object value) { }

	// RVA: 0xF88F2C
	int GetHashCode() { }

	// RVA: 0xF8901C
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF89024
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF89164
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF892B8
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF89348
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
public struct SqlGuid 
{
	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private Byte[] m_value; // 0x10
	public static readonly SqlGuid Null; // 0x10

	// Methods

	// RVA: 0xF893DC
	void .ctor(bool fNull) { }

	// RVA: 0xF893E8
	void .ctor(Guid g) { }

	// RVA: 0xF8942C
	bool get_IsNull() { }

	// RVA: 0xF8943C
	Guid get_Value() { }

	// RVA: 0xF89500
	SqlGuid op_Implicit(Guid x) { }

	// RVA: 0xF8953C
	string ToString() { }

	// RVA: 0xF895F4
	EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0xF8979C
	SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0xF898B8
	SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xF899D4
	SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xF89AF0
	int CompareTo(object value) { }

	// RVA: 0xF89C14
	int CompareTo(SqlGuid value) { }

	// RVA: 0xF89DB4
	bool Equals(object value) { }

	// RVA: 0xF89F18
	int GetHashCode() { }

	// RVA: 0xF89FD8
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF89FE0
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF8A13C
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF8A2A0
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF8A330
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF8A418
	void .ctor(bool fNull) { }

	// RVA: 0xF8A424
	void .ctor(Int16 value) { }

	// RVA: 0xF84478
	bool get_IsNull() { }

	// RVA: 0xF84488
	Int16 get_Value() { }

	// RVA: 0xF8A434
	SqlInt16 op_Implicit(Int16 x) { }

	// RVA: 0xF8A440
	string ToString() { }

	// RVA: 0xF8A4D8
	SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0xF8A5AC
	SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xF8A700
	SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xF8A854
	SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xF8A9EC
	SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xF8ABA4
	SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0xF8AC94
	SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0xF8ADD4
	SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xF8AEE8
	SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xF8AFFC
	SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xF8B110
	SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xF8B19C
	SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xF8B228
	SqlDouble ToSqlDouble() { }

	// RVA: 0xF8B2B0
	SqlInt64 ToSqlInt64() { }

	// RVA: 0xF8B420
	int CompareTo(object value) { }

	// RVA: 0xF8B544
	int CompareTo(SqlInt16 value) { }

	// RVA: 0xF8B6F0
	bool Equals(object value) { }

	// RVA: 0xF8B860
	int GetHashCode() { }

	// RVA: 0xF8B954
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF8B95C
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF8BA9C
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF8BBE4
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF8BC74
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF8BCF4
	void .ctor(bool fNull) { }

	// RVA: 0xF8BD00
	void .ctor(int value) { }

	// RVA: 0xF845DC
	bool get_IsNull() { }

	// RVA: 0xF845EC
	int get_Value() { }

	// RVA: 0xF8BD10
	SqlInt32 op_Implicit(int x) { }

	// RVA: 0xF8BD1C
	string ToString() { }

	// RVA: 0xF8BDB4
	SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0xF8BE84
	SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xF8C008
	SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xF8C180
	SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xF8C318
	SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xF8C4D0
	SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0xF8C5C0
	SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0xF8C6B0
	SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0xF8BFFC
	bool SameSignInt(int x, int y) { }

	// RVA: 0xF8C7F0
	SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xF8C908
	SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xF8CA20
	SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xF8CB38
	SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xF8CBC4
	SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xF8CC50
	SqlDouble ToSqlDouble() { }

	// RVA: 0xF8CCD8
	SqlInt64 ToSqlInt64() { }

	// RVA: 0xF8CE48
	int CompareTo(object value) { }

	// RVA: 0xF8CF6C
	int CompareTo(SqlInt32 value) { }

	// RVA: 0xF8D114
	bool Equals(object value) { }

	// RVA: 0xF8D284
	int GetHashCode() { }

	// RVA: 0xF8D344
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF8D34C
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF8D48C
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF8D5D4
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF8D664
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF8D6E4
	void .ctor(bool fNull) { }

	// RVA: 0xF8D6F0
	void .ctor(Int64 value) { }

	// RVA: 0xF7A18C
	bool get_IsNull() { }

	// RVA: 0xF7A19C
	Int64 get_Value() { }

	// RVA: 0xF8D700
	SqlInt64 op_Implicit(Int64 x) { }

	// RVA: 0xF8D70C
	string ToString() { }

	// RVA: 0xF8D7A4
	SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0xF8D86C
	SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF8D9E4
	SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF8DB4C
	SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF8DCF0
	SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF8DE80
	SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF7A8A4
	SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0xF8B338
	SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0xF8CD60
	SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0xF85E04
	SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0xF8D9D4
	bool SameSignLong(Int64 x, Int64 y) { }

	// RVA: 0xF8E014
	SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF8E120
	SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF8E22C
	SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF8E338
	SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF8E3B8
	SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xF8E438
	SqlByte ToSqlByte() { }

	// RVA: 0xF8E4C8
	SqlDouble ToSqlDouble() { }

	// RVA: 0xF8E558
	SqlInt16 ToSqlInt16() { }

	// RVA: 0xF8E5E8
	SqlInt32 ToSqlInt32() { }

	// RVA: 0xF8E678
	SqlDecimal ToSqlDecimal() { }

	// RVA: 0xF8E704
	int CompareTo(object value) { }

	// RVA: 0xF8E814
	int CompareTo(SqlInt64 value) { }

	// RVA: 0xF8E9D0
	bool Equals(object value) { }

	// RVA: 0xF8EB58
	int GetHashCode() { }

	// RVA: 0xF8EC4C
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF8EC54
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF8ED94
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF8EEDC
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF8EF6C
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF8F008
	void .ctor(bool fNull) { }

	// RVA: 0xF8F014
	void .ctor(Int64 value, int ignored) { }

	// RVA: 0xF8F024
	void .ctor(int value) { }

	// RVA: 0xF8F0A4
	void .ctor(Int64 value) { }

	// RVA: 0xF8F1C4
	void .ctor(Decimal value) { }

	// RVA: 0xF8489C
	bool get_IsNull() { }

	// RVA: 0xF8F33C
	Decimal get_Value() { }

	// RVA: 0xF848AC
	Decimal ToDecimal() { }

	// RVA: 0xF88488
	Double ToDouble() { }

	// RVA: 0xF8F3DC
	SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0xF8F40C
	SqlMoney op_Implicit(Int64 x) { }

	// RVA: 0xF8F478
	string ToString() { }

	// RVA: 0xF8F5BC
	SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0xF8F6EC
	SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0xF8F8C8
	SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0xF8FAA4
	SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0xF8FC14
	SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0xF8FD84
	SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0xF8FED4
	SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0xF90028
	SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0xF90184
	SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0xF86100
	SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0xF90278
	SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0xF90384
	SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xF90490
	SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xF9059C
	SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xF9061C
	SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xF9069C
	SqlDouble ToSqlDouble() { }

	// RVA: 0xF9072C
	SqlDecimal ToSqlDecimal() { }

	// RVA: 0xF907B8
	int CompareTo(object value) { }

	// RVA: 0xF908C8
	int CompareTo(SqlMoney value) { }

	// RVA: 0xF90A84
	bool Equals(object value) { }

	// RVA: 0xF90C0C
	int GetHashCode() { }

	// RVA: 0xF90CA0
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF90CA8
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF90E44
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF90FAC
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF9103C
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF91120
	void .ctor(bool fNull) { }

	// RVA: 0xF9112C
	void .ctor(float value) { }

	// RVA: 0xF911A4
	void .ctor(Double value) { }

	// RVA: 0xF8825C
	bool get_IsNull() { }

	// RVA: 0xF8826C
	float get_Value() { }

	// RVA: 0xF91290
	SqlSingle op_Implicit(float x) { }

	// RVA: 0xF912FC
	string ToString() { }

	// RVA: 0xF91394
	SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0xF9149C
	SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0xF91634
	SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0xF917CC
	SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0xF91964
	SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0xF91B34
	SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0xF91C68
	SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0xF91D9C
	SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0xF91EE0
	SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0xF92010
	SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0xF92194
	SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0xF889F0
	SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0xF922F4
	SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0xF92414
	SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xF92534
	SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xF92654
	SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xF926E0
	SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xF9276C
	SqlDouble ToSqlDouble() { }

	// RVA: 0xF927F4
	int CompareTo(object value) { }

	// RVA: 0xF92918
	int CompareTo(SqlSingle value) { }

	// RVA: 0xF92AC0
	bool Equals(object value) { }

	// RVA: 0xF92C30
	int GetHashCode() { }

	// RVA: 0xF92D24
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF92D2C
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF92E6C
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF92FC0
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF93050
	void .cctor() { }

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

	// RVA: 0xF930D0
	void .ctor(bool fNull) { }

	// RVA: 0xF93110
	void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0xF932B0
	void .ctor(string data) { }

	// RVA: 0xF93384
	void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0xF7C0A4
	bool get_IsNull() { }

	// RVA: 0xF7C0B4
	string get_Value() { }

	// RVA: 0xF93494
	void SetCompareInfo() { }

	// RVA: 0xF93530
	SqlString op_Implicit(string x) { }

	// RVA: 0xF93544
	string ToString() { }

	// RVA: 0xF935D4
	SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0xF93754
	int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0xF93F28
	SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0xF940C8
	SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0xF931DC
	void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xF93E58
	CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xF94160
	bool FBinarySort() { }

	// RVA: 0xF93A80
	int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0xF93C94
	int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0xF941F8
	int CompareTo(object value) { }

	// RVA: 0xF9431C
	int CompareTo(SqlString value) { }

	// RVA: 0xF94464
	bool Equals(object value) { }

	// RVA: 0xF9466C
	int GetHashCode() { }

	// RVA: 0xF94988
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF94990
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF94ABC
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF94BD0
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF94C60
	void .cctor() { }

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
public class SqlTypeException 
{
	// Methods

	// RVA: 0xF94D70
	void .ctor() { }

	// RVA: 0xF7B8BC
	void .ctor(string message) { }

	// RVA: 0xF94DDC
	void .ctor(string message, Exception e) { }

	// RVA: 0xF94E0C
	void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xF94E60
	SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
public sealed class SqlNullValueException 
{
	// Methods

	// RVA: 0xF79A14
	void .ctor() { }

	// RVA: 0xF94F6C
	void .ctor(string message) { }

	// RVA: 0xF94F3C
	void .ctor(string message, Exception e) { }

	// RVA: 0xF94FA0
	void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xF95004
	SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
public sealed class SqlTruncateException 
{
	// Methods

	// RVA: 0xF84CA0
	void .ctor() { }

	// RVA: 0xF95110
	void .ctor(string message) { }

	// RVA: 0xF950E0
	void .ctor(string message, Exception e) { }

	// RVA: 0xF95144
	void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xF951A8
	SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
internal abstract class SqlStreamChars 
{
	// Methods

	// RVA: 0x2FE34E0
	Int64 get_Length() { }

	// RVA: 0x2FE34E0
	Int64 get_Position() { }

	// RVA: -1
	int Read(Char[] buffer, int offset, int count) { }

	// RVA: -1
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

}

// Namespace: System.Data.SqlTypes
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

	// RVA: 0xF95284
	void .ctor() { }

	// RVA: 0xF952FC
	XmlReader CreateReader() { }

	// RVA: 0xF956B4
	XmlReader CreateSqlXmlReader(Stream stream, bool closeInput, bool throwTargetInvocationExceptions) { }

	// RVA: 0xF9589C
	System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0xF9554C
	MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0xF954B8
	bool get_IsNull() { }

	// RVA: 0xF952C4
	void SetNull() { }

	// RVA: 0xF959C4
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF959CC
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xF95BD8
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF95D4C
	XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF95DDC
	void .cctor() { }

}

// Namespace: System.Data.SqlTypes
internal sealed class SqlXmlStreamWrapper 
{
	// Fields
	private Stream _stream; // 0x28
	private Int64 _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Methods

	// RVA: 0xF954C8
	void .ctor(Stream stream) { }

	// RVA: 0xF95EE0
	bool get_CanRead() { }

	// RVA: 0xF95FF4
	bool get_CanSeek() { }

	// RVA: 0xF96084
	bool get_CanWrite() { }

	// RVA: 0xF96114
	Int64 get_Length() { }

	// RVA: 0xF962C8
	Int64 get_Position() { }

	// RVA: 0xF96330
	void set_Position(Int64 value) { }

	// RVA: 0xF96408
	Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xF96590
	int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xF967E0
	void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xF96A30
	int ReadByte() { }

	// RVA: 0xF96B5C
	void WriteByte(Byte value) { }

	// RVA: 0xF96C44
	void Flush() { }

	// RVA: 0xF96C60
	void Dispose(bool disposing) { }

	// RVA: 0xF96248
	void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0xF96760
	void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0xF969B0
	void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0xF9618C
	void ThrowIfStreamClosed(string method) { }

	// RVA: 0xF95F70
	bool IsStreamClosed() { }

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

	// RVA: 0xF9AA14
	void .ctor() { }

	// RVA: 0xF9AA1C
	bool Equals(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> y) { }

	// RVA: 0xF9B294
	int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> obj) { }

	// RVA: 0xF9B428
	void .cctor() { }

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

	// RVA: 0xF96C70
	void .ctor(DataColumn column, Type type) { }

	// RVA: 0xF96E44
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xF96E7C
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xF97568
	int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xF97784
	int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0xF97064
	int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0xF97A64
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xF97AE8
	object Get(int recordNo) { }

	// RVA: 0xF97924
	Families GetFamily(Type dataType) { }

	// RVA: 0xF97B34
	bool IsNull(int record) { }

	// RVA: 0xF97B70
	void Set(int recordNo, object value) { }

	// RVA: 0xF98410
	void SetCapacity(int capacity) { }

	// RVA: 0xF984D4
	object ConvertXmlToObject(string s) { }

	// RVA: 0xF98B18
	object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xF99C94
	string ConvertObjectToXml(object value) { }

	// RVA: 0xF9A1D0
	void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xF9A340
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xF9A394
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xF9A5D0
	void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xF9A7E8
	void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0xF98A74
	XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0xF99254
	XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0xF9A93C
	void .cctor() { }

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

	// RVA: 0xF9B494
	void TraceException(string trace, Exception e) { }

	// RVA: 0xF9B53C
	void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0xF9B658
	void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0xF9B774
	ArgumentException Argument(string error) { }

	// RVA: 0xF9B808
	ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0xF9B89C
	ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0xF9B940
	InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0xF9B9D4
	NotSupportedException NotSupported(string error) { }

	// RVA: 0xF9BA68
	bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0xF9BD40
	bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0xF9BFB0
	ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0xF9C13C
	Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0xF9C254
	ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0xF9C31C
	ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0xF9C3E4
	ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0xF9C4AC
	Exception WrongType(Type got, Type expected) { }

	// RVA: 0xF9C5E8
	void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class BigIntegerStorage 
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0xF9C954
	void .ctor(DataColumn column) { }

	// RVA: 0xF9CBC8
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xF9CC00
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xF9CDD8
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xF9CF6C
	BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0xF9D750
	object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xF9DEE8
	object ConvertValue(object value) { }

	// RVA: 0xF9DFC4
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xF9E094
	object Get(int record) { }

	// RVA: 0xF9E1D8
	void Set(int record, object value) { }

	// RVA: 0xF9E37C
	void SetCapacity(int capacity) { }

	// RVA: 0xF9E554
	object ConvertXmlToObject(string s) { }

	// RVA: 0xF9E638
	string ConvertObjectToXml(object value) { }

	// RVA: 0xF9E72C
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xF9E780
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xF9E8A0
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class BooleanStorage 
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0xF9E970
	void .ctor(DataColumn column) { }

	// RVA: 0xF9EAD8
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xF9EE88
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xF9EF90
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xF9F0CC
	object ConvertValue(object value) { }

	// RVA: 0xF9F230
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xF9F2B4
	object Get(int record) { }

	// RVA: 0xF9F380
	void Set(int record, object value) { }

	// RVA: 0xF9F524
	void SetCapacity(int capacity) { }

	// RVA: 0xF9F668
	object ConvertXmlToObject(string s) { }

	// RVA: 0xF9F6FC
	string ConvertObjectToXml(object value) { }

	// RVA: 0xF9F7B0
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xF9F804
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xF9F908
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class ByteStorage 
{
	// Fields
	private Byte[] _values; // 0x50

	// Methods

	// RVA: 0xF9F9D8
	void .ctor(DataColumn column) { }

	// RVA: 0xF9FB40
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFA0364
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFA0428
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFA0550
	object ConvertValue(object value) { }

	// RVA: 0xFA06B4
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFA0738
	object Get(int record) { }

	// RVA: 0xFA0804
	void Set(int record, object value) { }

	// RVA: 0xFA09A8
	void SetCapacity(int capacity) { }

	// RVA: 0xFA0AEC
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFA0B80
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFA0C34
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFA0C88
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFA0D8C
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class CharStorage 
{
	// Fields
	private Char[] _values; // 0x50

	// Methods

	// RVA: 0xFA0E5C
	void .ctor(DataColumn column) { }

	// RVA: 0xFA0FC4
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFA1358
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFA145C
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFA1598
	object ConvertValue(object value) { }

	// RVA: 0xFA16FC
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFA1780
	object Get(int record) { }

	// RVA: 0xFA184C
	void Set(int record, object value) { }

	// RVA: 0xFA1A3C
	void SetCapacity(int capacity) { }

	// RVA: 0xFA1B80
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFA1C14
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFA1CC8
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFA1D1C
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFA1E20
	void SetStorage(object store, BitArray nullbits) { }

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

	// RVA: 0xF9CB28
	void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0xFA2070
	void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0xFA1EF0
	void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0xFA20D8
	DataSetDateTime get_DateTimeMode() { }

	// RVA: 0xF9DFA4
	IFormatProvider get_FormatProvider() { }

	// RVA: 0xF9EE74
	object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0xFA20F8
	object AggregateCount(int[] recordNos) { }

	// RVA: 0xF9CD6C
	int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: 0x2FE3308
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: -1
	int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xFA21BC
	object ConvertValue(object value) { }

	// RVA: 0xF9E050
	void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x2FE4314
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: -1
	object Get(int recordNo) { }

	// RVA: 0xF9E194
	object GetBits(int recordNo) { }

	// RVA: 0xFA21C4
	int GetStringLength(int record) { }

	// RVA: 0xF9CF44
	bool HasValue(int recordNo) { }

	// RVA: 0xFA21CC
	bool IsNull(int recordNo) { }

	// RVA: 0x2FE440C
	void Set(int recordNo, object value) { }

	// RVA: 0xF9E35C
	void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0xF9E4C0
	void SetCapacity(int capacity) { }

	// RVA: 0x2FE36BC
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFA21EC
	object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x2FE36BC
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFA2238
	void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFA2280
	DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0xFA3ECC
	StorageType GetStorageType(Type dataType) { }

	// RVA: 0xFA3FFC
	Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0xFA409C
	bool IsTypeCustomType(Type type) { }

	// RVA: 0xFA207C
	bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0xFA4118
	bool IsSqlType(StorageType storageType) { }

	// RVA: 0xFA4124
	bool IsSqlType(Type dataType) { }

	// RVA: 0xFA2098
	bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0xFA4234
	void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0xFA44B0
	System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0xFA4698
	bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0xFA4778
	bool IsObjectNull(object value) { }

	// RVA: 0xFA490C
	bool IsObjectSqlNull(object value) { }

	// RVA: 0xFA49E4
	object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0xFA49F4
	void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFA4A04
	void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1
	object GetEmptyStorage(int recordCount) { }

	// RVA: -1
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x2FE47D4
	void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFA4A14
	void SetNullStorage(BitArray nullbits) { }

	// RVA: 0xFA4A1C
	Type GetType(string value) { }

	// RVA: 0xFA4B64
	string GetQualifiedName(Type type) { }

	// RVA: 0xFA4C00
	void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage 
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0xFA3664
	void .ctor(DataColumn column) { }

	// RVA: 0xFA5B3C
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFA6058
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFA6230
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFA63E8
	object ConvertValue(object value) { }

	// RVA: 0xFA64AC
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFA6530
	object Get(int record) { }

	// RVA: 0xFA6660
	void Set(int record, object value) { }

	// RVA: 0xFA6794
	void SetCapacity(int capacity) { }

	// RVA: 0xFA68D8
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFA696C
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFA6A24
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFA6A78
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFA6B8C
	void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFA6C5C
	void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeStorage 
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0xFA34CC
	void .ctor(DataColumn column) { }

	// RVA: 0xFA6CD8
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFA71D4
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFA73D0
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFA7580
	object ConvertValue(object value) { }

	// RVA: 0xFA76E4
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFA7768
	object Get(int record) { }

	// RVA: 0xFA78B0
	void Set(int record, object value) { }

	// RVA: 0xFA7C90
	void SetCapacity(int capacity) { }

	// RVA: 0xFA7DD4
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFA7E9C
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFA7F98
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFA7FEC
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFA8168
	void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFA839C
	void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DecimalStorage 
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0xFA3310
	void .ctor(DataColumn column) { }

	// RVA: 0xFA8418
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFA8F4C
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFA9104
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFA9294
	object ConvertValue(object value) { }

	// RVA: 0xFA9418
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFA949C
	object Get(int record) { }

	// RVA: 0xFA9574
	void Set(int record, object value) { }

	// RVA: 0xFA9738
	void SetCapacity(int capacity) { }

	// RVA: 0xFA987C
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFA993C
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFA99F4
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFA9A48
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFA9B5C
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class DoubleStorage 
{
	// Fields
	private Double[] _values; // 0x50

	// Methods

	// RVA: 0xFA31A8
	void .ctor(DataColumn column) { }

	// RVA: 0xFA9C2C
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFAA3B0
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFAA480
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFAA5AC
	object ConvertValue(object value) { }

	// RVA: 0xFAA710
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFAA794
	object Get(int record) { }

	// RVA: 0xFAA864
	void Set(int record, object value) { }

	// RVA: 0xFAAA08
	void SetCapacity(int capacity) { }

	// RVA: 0xFAAB4C
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFAABE0
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFAAC94
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFAACE8
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFAADF4
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int16Storage 
{
	// Fields
	private Int16[] _values; // 0x50

	// Methods

	// RVA: 0xFA2D70
	void .ctor(DataColumn column) { }

	// RVA: 0xFAAEC4
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFAB730
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFAB7E8
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFAB910
	object ConvertValue(object value) { }

	// RVA: 0xFABA74
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFABAF8
	object Get(int record) { }

	// RVA: 0xFABBC4
	void Set(int record, object value) { }

	// RVA: 0xFABD68
	void SetCapacity(int capacity) { }

	// RVA: 0xFABEAC
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFABF40
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFABFF4
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFAC048
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFAC14C
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int32Storage 
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0xFA2ED8
	void .ctor(DataColumn column) { }

	// RVA: 0xFAC21C
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFACA7C
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFACB50
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFACC78
	object ConvertValue(object value) { }

	// RVA: 0xFACDDC
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFACE60
	object Get(int record) { }

	// RVA: 0xFACF2C
	void Set(int record, object value) { }

	// RVA: 0xFAD0D0
	void SetCapacity(int capacity) { }

	// RVA: 0xFAD214
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFAD2A8
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFAD35C
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFAD3B0
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFAD4B4
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int64Storage 
{
	// Fields
	private Int64[] _values; // 0x50

	// Methods

	// RVA: 0xFA3040
	void .ctor(DataColumn column) { }

	// RVA: 0xFAD584
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFADE24
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFADEF8
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFAE020
	object ConvertValue(object value) { }

	// RVA: 0xFAE184
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFAE208
	object Get(int record) { }

	// RVA: 0xFAE2D4
	void Set(int record, object value) { }

	// RVA: 0xFAE478
	void SetCapacity(int capacity) { }

	// RVA: 0xFAE5BC
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFAE650
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFAE704
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFAE758
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFAE85C
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SByteStorage 
{
	// Fields
	private SByte[] _values; // 0x50

	// Methods

	// RVA: 0xFA2C08
	void .ctor(DataColumn column) { }

	// RVA: 0xFAE92C
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFAF16C
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFAF258
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFAF380
	object ConvertValue(object value) { }

	// RVA: 0xFAF4E4
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFAF568
	object Get(int record) { }

	// RVA: 0xFAF64C
	void Set(int record, object value) { }

	// RVA: 0xFAF7F0
	void SetCapacity(int capacity) { }

	// RVA: 0xFAF934
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFAF9C8
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFAFA7C
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFAFAD0
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFAFBD4
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal static class SqlConvert 
{
	// Methods

	// RVA: 0xFAFCA4
	SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0xFAFEDC
	SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0xFB01F4
	SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0xFB064C
	SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0xFB0BA4
	SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0xFB1310
	SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0xFB1978
	SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0xFB2078
	SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0xFB2708
	SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0xFB2944
	SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0xFB2B68
	SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0xFB2DA8
	SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0xFB2FDC
	SqlString ConvertToSqlString(object value) { }

	// RVA: 0xFB31E4
	SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0xFB3354
	SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0xFB34C4
	DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0xFB3530
	object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xFB371C
	object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xFB47F0
	object ChangeTypeForXML(object value, Type type) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage 
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0xFA37FC
	void .ctor(DataColumn column) { }

	// RVA: 0xFB65E8
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFB6844
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFB68E8
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFB69A8
	object ConvertValue(object value) { }

	// RVA: 0xFB6A34
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFB6A7C
	object Get(int record) { }

	// RVA: 0xFB6B08
	bool IsNull(int record) { }

	// RVA: 0xFB6B90
	void Set(int record, object value) { }

	// RVA: 0xFB6BE0
	void SetCapacity(int capacity) { }

	// RVA: 0xFB6CA4
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFB6F50
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFB71B8
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFB720C
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFB7318
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlByteStorage 
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0xFA3934
	void .ctor(DataColumn column) { }

	// RVA: 0xFB73C8
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFB8204
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFB82A8
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFB8368
	object ConvertValue(object value) { }

	// RVA: 0xFB83F4
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFB8434
	object Get(int record) { }

	// RVA: 0xFB84C0
	bool IsNull(int record) { }

	// RVA: 0xFB8548
	void Set(int record, object value) { }

	// RVA: 0xFB8590
	void SetCapacity(int capacity) { }

	// RVA: 0xFB8654
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFB8900
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFB8B68
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFB8BBC
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFB8CC0
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBytesStorage 
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0xFA3A6C
	void .ctor(DataColumn column) { }

	// RVA: 0xFB8D70
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFB8FA4
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFB8FAC
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFB8FB4
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFB8FF8
	object Get(int record) { }

	// RVA: 0xFB902C
	bool IsNull(int record) { }

	// RVA: 0xFB9068
	void Set(int record, object value) { }

	// RVA: 0xFB9194
	void SetCapacity(int capacity) { }

	// RVA: 0xFB9258
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFB9528
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFB9790
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFB97E4
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFB98F0
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlCharsStorage 
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0xFA3B54
	void .ctor(DataColumn column) { }

	// RVA: 0xFB99A0
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFB9BD4
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFB9BDC
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFB9BE4
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFB9C28
	object Get(int record) { }

	// RVA: 0xFB9C5C
	bool IsNull(int record) { }

	// RVA: 0xFB9C98
	void Set(int record, object value) { }

	// RVA: 0xFB9DC4
	void SetCapacity(int capacity) { }

	// RVA: 0xFB9E88
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFBA164
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFBA3CC
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFBA420
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFBA52C
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage 
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0xFA3C3C
	void .ctor(DataColumn column) { }

	// RVA: 0xFBA5DC
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFBABF8
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFBACAC
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFBAD74
	object ConvertValue(object value) { }

	// RVA: 0xFBAE04
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFBAE58
	object Get(int record) { }

	// RVA: 0xFBAEF0
	bool IsNull(int record) { }

	// RVA: 0xFBAF7C
	void Set(int record, object value) { }

	// RVA: 0xFBAFCC
	void SetCapacity(int capacity) { }

	// RVA: 0xFBB090
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFBB348
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFBB5B0
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFBB604
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFBB720
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage 
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0xFA3D84
	void .ctor(DataColumn column) { }

	// RVA: 0xFBB7D0
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFBC6EC
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFBC7C0
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFBC8A0
	object ConvertValue(object value) { }

	// RVA: 0xFBC92C
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFBC980
	object Get(int record) { }

	// RVA: 0xFBCA20
	bool IsNull(int record) { }

	// RVA: 0xFBCAAC
	void Set(int record, object value) { }

	// RVA: 0xFBCB10
	void SetCapacity(int capacity) { }

	// RVA: 0xFBCBD4
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFBCE8C
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFBD0F4
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFBD148
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFBD274
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage 
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0xFBD324
	void .ctor(DataColumn column) { }

	// RVA: 0xFBD45C
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFBE174
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFBE21C
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFBE2DC
	object ConvertValue(object value) { }

	// RVA: 0xFBE36C
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFBE3AC
	object Get(int record) { }

	// RVA: 0xFBE438
	bool IsNull(int record) { }

	// RVA: 0xFBE4C0
	void Set(int record, object value) { }

	// RVA: 0xFBE50C
	void SetCapacity(int capacity) { }

	// RVA: 0xFBE5D0
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFBE87C
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFBEAE0
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFBEB34
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFBEC48
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlGuidStorage 
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0xFBECF8
	void .ctor(DataColumn column) { }

	// RVA: 0xFBEE30
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFBF08C
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFBF130
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFBF1F0
	object ConvertValue(object value) { }

	// RVA: 0xFBF280
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFBF2C8
	object Get(int record) { }

	// RVA: 0xFBF354
	bool IsNull(int record) { }

	// RVA: 0xFBF3DC
	void Set(int record, object value) { }

	// RVA: 0xFBF430
	void SetCapacity(int capacity) { }

	// RVA: 0xFBF4F4
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFBF7A0
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFBFA04
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFBFA58
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFBFB64
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt16Storage 
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0xFBFC14
	void .ctor(DataColumn column) { }

	// RVA: 0xFBFD4C
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC0B88
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC0C2C
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC0CEC
	object ConvertValue(object value) { }

	// RVA: 0xFC0D7C
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC0DBC
	object Get(int record) { }

	// RVA: 0xFC0E48
	bool IsNull(int record) { }

	// RVA: 0xFC0ED0
	void Set(int record, object value) { }

	// RVA: 0xFC0F1C
	void SetCapacity(int capacity) { }

	// RVA: 0xFC0FE0
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFC128C
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFC14F0
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC1544
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC1648
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt32Storage 
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0xFC16F8
	void .ctor(DataColumn column) { }

	// RVA: 0xFC1830
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC263C
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC26E0
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC27A0
	object ConvertValue(object value) { }

	// RVA: 0xFC2830
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC2870
	object Get(int record) { }

	// RVA: 0xFC28FC
	bool IsNull(int record) { }

	// RVA: 0xFC2984
	void Set(int record, object value) { }

	// RVA: 0xFC29D0
	void SetCapacity(int capacity) { }

	// RVA: 0xFC2A94
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFC2D40
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFC2FA4
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC2FF8
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC30FC
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt64Storage 
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0xFC31AC
	void .ctor(DataColumn column) { }

	// RVA: 0xFC32E4
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC41E4
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC428C
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC434C
	object ConvertValue(object value) { }

	// RVA: 0xFC43DC
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC441C
	object Get(int record) { }

	// RVA: 0xFC44A8
	bool IsNull(int record) { }

	// RVA: 0xFC4530
	void Set(int record, object value) { }

	// RVA: 0xFC457C
	void SetCapacity(int capacity) { }

	// RVA: 0xFC4640
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFC48EC
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFC4B50
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC4BA4
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC4CB8
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage 
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0xFC4D68
	void .ctor(DataColumn column) { }

	// RVA: 0xFC4EA0
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC5DA0
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC5E48
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC5F08
	object ConvertValue(object value) { }

	// RVA: 0xFC5F98
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC5FD8
	object Get(int record) { }

	// RVA: 0xFC6064
	bool IsNull(int record) { }

	// RVA: 0xFC60EC
	void Set(int record, object value) { }

	// RVA: 0xFC6138
	void SetCapacity(int capacity) { }

	// RVA: 0xFC61FC
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFC64A8
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFC670C
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC6760
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC6874
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlSingleStorage 
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0xFC6924
	void .ctor(DataColumn column) { }

	// RVA: 0xFC6A5C
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC7838
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC78DC
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC799C
	object ConvertValue(object value) { }

	// RVA: 0xFC7A2C
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC7A6C
	object Get(int record) { }

	// RVA: 0xFC7AF8
	bool IsNull(int record) { }

	// RVA: 0xFC7B80
	void Set(int record, object value) { }

	// RVA: 0xFC7BCC
	void SetCapacity(int capacity) { }

	// RVA: 0xFC7C90
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFC7F3C
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFC81A0
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC81F4
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC82F8
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlStringStorage 
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0xFC83A8
	void .ctor(DataColumn column) { }

	// RVA: 0xFC84EC
	object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0xFC8914
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC8984
	int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0xFC8B40
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC8C08
	object ConvertValue(object value) { }

	// RVA: 0xFC8CA0
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC8CF4
	object Get(int record) { }

	// RVA: 0xFC8D88
	int GetStringLength(int record) { }

	// RVA: 0xFC8E78
	bool IsNull(int record) { }

	// RVA: 0xFC8F04
	void Set(int record, object value) { }

	// RVA: 0xFC8F70
	void SetCapacity(int capacity) { }

	// RVA: 0xFC9034
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFC92E4
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFC9548
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC959C
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC96C4
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage 
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0xFC9774
	void .ctor(DataColumn column) { }

	// RVA: 0xFC98AC
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC9D34
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC9DD8
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC9E98
	object ConvertValue(object value) { }

	// RVA: 0xFC9F28
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC9F68
	object Get(int record) { }

	// RVA: 0xFC9FF4
	bool IsNull(int record) { }

	// RVA: 0xFCA07C
	void Set(int record, object value) { }

	// RVA: 0xFCA0C8
	void SetCapacity(int capacity) { }

	// RVA: 0xFCA18C
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFCA438
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFCA69C
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFCA6F0
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFCA7F4
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SingleStorage 
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0xFCA8A4
	void .ctor(DataColumn column) { }

	// RVA: 0xFCA9A4
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFCB0C0
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFCB154
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFCB280
	object ConvertValue(object value) { }

	// RVA: 0xFCB3DC
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFCB440
	object Get(int record) { }

	// RVA: 0xFCB4F4
	void Set(int record, object value) { }

	// RVA: 0xFCB68C
	void SetCapacity(int capacity) { }

	// RVA: 0xFCB76C
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFCB800
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFCB8B4
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFCB908
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFCBA14
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0 
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0xFCBE48
	void .ctor() { }

	// RVA: 0xFCD2C8
	object <GetStaticNullForUdtType>b__0(Type t) { }

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

	// RVA: 0xFCBAE4
	void .ctor(DataColumn column, Type type) { }

	// RVA: 0xFCBC9C
	void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0xFCBB68
	object GetStaticNullForUdtType(Type type) { }

	// RVA: 0xFCBE50
	bool IsNull(int record) { }

	// RVA: 0xFCBF74
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFCBFAC
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFCBFE8
	int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xFCC2A8
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFCC33C
	object Get(int recordNo) { }

	// RVA: 0xFCC370
	void Set(int recordNo, object value) { }

	// RVA: 0xFCC504
	void SetCapacity(int capacity) { }

	// RVA: 0xFCC5E4
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFCC8F4
	object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFCCBA0
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFCCE7C
	void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFCCFE4
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFCD038
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFCD17C
	void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFCD22C
	void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class StringStorage 
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0xFCD400
	void .ctor(DataColumn column) { }

	// RVA: 0xFCD4EC
	object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0xFCD7D8
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFCD85C
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFCD940
	object ConvertValue(object value) { }

	// RVA: 0xFCD970
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFCD9B4
	object Get(int recordNo) { }

	// RVA: 0xFCDA00
	int GetStringLength(int record) { }

	// RVA: 0xFCDA48
	bool IsNull(int record) { }

	// RVA: 0xFCDA84
	void Set(int record, object value) { }

	// RVA: 0xFCDB10
	void SetCapacity(int capacity) { }

	// RVA: 0xFCDBD4
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFCDBDC
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFCDC40
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFCDC94
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFCDDA0
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class TimeSpanStorage 
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0xFCDE50
	void .ctor(DataColumn column) { }

	// RVA: 0xFCDF80
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFCEB6C
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFCED3C
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFCEF04
	TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0xFCF134
	object ConvertValue(object value) { }

	// RVA: 0xFCF1FC
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFCF260
	object Get(int record) { }

	// RVA: 0xFCF394
	void Set(int record, object value) { }

	// RVA: 0xFCF474
	void SetCapacity(int capacity) { }

	// RVA: 0xFCF554
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFCF5E8
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFCF69C
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFCF6F0
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFCF7F4
	void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFCF8C4
	void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class UInt16Storage 
{
	// Fields
	private static readonly UInt16 s_defaultValue; // 0x0
	private UInt16[] _values; // 0x50

	// Methods

	// RVA: 0xFCF940
	void .ctor(DataColumn column) { }

	// RVA: 0xFCFA68
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD0288
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD035C
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD049C
	object ConvertValue(object value) { }

	// RVA: 0xFD05F8
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD065C
	object Get(int record) { }

	// RVA: 0xFD0744
	void Set(int record, object value) { }

	// RVA: 0xFD08FC
	void SetCapacity(int capacity) { }

	// RVA: 0xFD09DC
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFD0A70
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFD0B24
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD0B78
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD0C78
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt32Storage 
{
	// Fields
	private static readonly UInt32 s_defaultValue; // 0x0
	private UInt32[] _values; // 0x50

	// Methods

	// RVA: 0xFD0D48
	void .ctor(DataColumn column) { }

	// RVA: 0xFD0E70
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD1694
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD178C
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD18CC
	object ConvertValue(object value) { }

	// RVA: 0xFD1A28
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD1A8C
	object Get(int record) { }

	// RVA: 0xFD1B74
	void Set(int record, object value) { }

	// RVA: 0xFD1D2C
	void SetCapacity(int capacity) { }

	// RVA: 0xFD1E0C
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFD1EA0
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFD1F54
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD1FA8
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD20A8
	void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt64Storage 
{
	// Fields
	private static readonly UInt64 s_defaultValue; // 0x0
	private UInt64[] _values; // 0x50

	// Methods

	// RVA: 0xFD2178
	void .ctor(DataColumn column) { }

	// RVA: 0xFD22A0
	object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD2AC0
	int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD2BD0
	int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD2D10
	object ConvertValue(object value) { }

	// RVA: 0xFD2E6C
	void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD2ED0
	object Get(int record) { }

	// RVA: 0xFD2FB8
	void Set(int record, object value) { }

	// RVA: 0xFD3170
	void SetCapacity(int capacity) { }

	// RVA: 0xFD3250
	object ConvertXmlToObject(string s) { }

	// RVA: 0xFD32E4
	string ConvertObjectToXml(object value) { }

	// RVA: 0xFD3398
	object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD33EC
	void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD34EC
	void SetStorage(object store, BitArray nullbits) { }

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


