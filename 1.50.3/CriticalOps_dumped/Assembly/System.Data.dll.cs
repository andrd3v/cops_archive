// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xF1FA5C
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xF1FA64
	public void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xF1FAF0
	public void .ctor(Byte ) { }

}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0xF1FB1C
	internal static string GetString(string name) { }

	// RVA: 0xF1FB20
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0xF1FB94
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0xF1FC18
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }

}

// Namespace: System
internal static class LocalAppContextSwitches
{
	// Fields
	private static int s_allowArbitraryTypeInstantiation; // 0x0

	// Methods

	// RVA: 0xF1FCA4
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

	// RVA: 0xF20074
	private static void .cctor() { }

	// RVA: 0xF200E0
	public void .ctor() { }

	// RVA: 0xF200E8
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

	// RVA: 0xF1FDC0
	internal static bool GetCachedSwitchValue(string switchName, int switchValue) { }

	// RVA: 0xF1FE9C
	private static bool GetCachedSwitchValueInternal(string switchName, int switchValue) { }

	// RVA: 0xF1FF3C
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

	// RVA: 0xF2016C
	public void .ctor() { }

	// RVA: 0xF2058C
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0xF20200
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0xF207A0
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0xF21278
	public bool get_AllowDBNull() { }

	// RVA: 0xF21280
	public void set_AllowDBNull(bool value) { }

	// RVA: 0xF21848
	public bool get_AutoIncrement() { }

	// RVA: 0xF21868
	public void set_AutoIncrement(bool value) { }

	// RVA: 0xF22A60
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0xF22AF4
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0xF228D4
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0xF22ADC
	public Int64 get_AutoIncrementSeed() { }

	// RVA: 0xF22DD4
	public void set_AutoIncrementSeed(Int64 value) { }

	// RVA: 0xF22EEC
	public Int64 get_AutoIncrementStep() { }

	// RVA: 0xF22F08
	public void set_AutoIncrementStep(Int64 value) { }

	// RVA: 0xF23040
	public string get_Caption() { }

	// RVA: 0xF2305C
	public void set_Caption(string value) { }

	// RVA: 0xF23204
	public string get_ColumnName() { }

	// RVA: 0xF2320C
	public void set_ColumnName(string value) { }

	// RVA: 0xF237E8
	internal string get_EncodedColumnName() { }

	// RVA: 0xF22CC0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xF23184
	internal CultureInfo get_Locale() { }

	// RVA: 0xF23884
	internal int get_ObjectID() { }

	// RVA: 0xF2388C
	public string get_Prefix() { }

	// RVA: 0xF23894
	public void set_Prefix(string value) { }

	// RVA: 0xF23B58
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0xF23D0C
	internal bool get_Computed() { }

	// RVA: 0xF23D1C
	internal DataExpression get_DataExpression() { }

	// RVA: 0xF23D24
	public Type get_DataType() { }

	// RVA: 0xF21F64
	public void set_DataType(Type value) { }

	// RVA: 0xF24960
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0xF24968
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0xF2406C
	public object get_DefaultValue() { }

	// RVA: 0xF24234
	public void set_DefaultValue(object value) { }

	// RVA: 0xF24EBC
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0xF24EC4
	internal void BindExpression() { }

	// RVA: 0xF24EEC
	public string get_Expression() { }

	// RVA: 0xF208D8
	public void set_Expression(string value) { }

	// RVA: 0xF25694
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF21E44
	internal bool get_HasData() { }

	// RVA: 0xF25720
	internal bool get_ImplementsINullable() { }

	// RVA: 0xF25728
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0xF25730
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0xF25738
	internal bool get_IsValueType() { }

	// RVA: 0xF25758
	internal bool get_IsSqlType() { }

	// RVA: 0xF25760
	private void SetMaxLengthSimpleType() { }

	// RVA: 0xF2584C
	public int get_MaxLength() { }

	// RVA: 0xF25854
	public void set_MaxLength(int value) { }

	// RVA: 0xF26260
	public string get_Namespace() { }

	// RVA: 0xF262E8
	public void set_Namespace(string value) { }

	// RVA: 0xF26650
	public int get_Ordinal() { }

	// RVA: 0xF26658
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0xF267AC
	public bool get_ReadOnly() { }

	// RVA: 0xF250F8
	public void set_ReadOnly(bool value) { }

	// RVA: 0xF26850
	private Index get_SortIndex() { }

	// RVA: 0xF26954
	public DataTable get_Table() { }

	// RVA: 0xF2695C
	internal void SetTable(DataTable table) { }

	// RVA: 0xF26A40
	private DataRow GetDataRow(int index) { }

	// RVA: 0xF23C2C
	internal object get_Item(int record) { }

	// RVA: 0xF26A68
	internal void set_Item(int record, object value) { }

	// RVA: 0xF25564
	internal void InitializeRecord(int record) { }

	// RVA: 0xF26D80
	internal void SetValue(int record, object value) { }

	// RVA: 0xF26EB4
	internal void FreeRecord(int record) { }

	// RVA: 0xF26EDC
	public bool get_Unique() { }

	// RVA: 0xF26EE4
	public void set_Unique(bool value) { }

	// RVA: 0xF274B0
	internal void InternalUnique(bool value) { }

	// RVA: 0xF274B8
	internal string get_XmlDataType() { }

	// RVA: 0xF274C0
	internal void set_XmlDataType(string value) { }

	// RVA: 0xF274C8
	internal SimpleType get_SimpleType() { }

	// RVA: 0xF20740
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0xF274D0
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0xF274D8
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0xF27A94
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xF25DB4
	internal bool CheckMaxLength() { }

	// RVA: 0xF27B68
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0xF21420
	protected internal void CheckNotAllowNull() { }

	// RVA: 0xF27AEC
	internal void CheckNullable(DataRow row) { }

	// RVA: 0xF27458
	protected void CheckUnique() { }

	// RVA: 0xF28050
	internal int Compare(int record1, int record2) { }

	// RVA: 0xF28074
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0xF28278
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0xF2829C
	internal object ConvertValue(object value) { }

	// RVA: 0xF282C0
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0xF282E4
	internal DataColumn Clone() { }

	// RVA: 0xF28A00
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0xF27BE4
	private int GetStringLength(int record) { }

	// RVA: 0xF28AE4
	internal void Init(int record) { }

	// RVA: 0xF21B64
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0xF28B7C
	internal bool get_IsCustomType() { }

	// RVA: 0xF28C08
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0xF28D00
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0xF23E4C
	internal bool IsInRelation() { }

	// RVA: 0xF28D08
	internal bool IsMaxLengthViolated() { }

	// RVA: 0xF293F4
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0xF296A8
	internal void FinishInitInProgress() { }

	// RVA: 0xF296C4
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF2376C
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF296E8
	private void InsureStorage() { }

	// RVA: 0xF29788
	internal void SetCapacity(int capacity) { }

	// RVA: 0xF29844
	internal void OnSetDataSet() { }

	// RVA: 0xF29848
	public override string ToString() { }

	// RVA: 0xF2990C
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0xF299C8
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xF23C50
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0xF29A8C
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xF29B60
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0xF29C14
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xF29C34
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xF29CF0
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF29DC0
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF25420
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

}

// Namespace: System.Data
internal abstract class AutoIncrementValue
{
	// Fields
	private bool <Auto>k__BackingField; // 0x10

	// Methods

	// RVA: 0xF29E64
	internal bool get_Auto() { }

	// RVA: 0xF29E6C
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

	// RVA: 0xF2888C
	internal AutoIncrementValue Clone() { }

	// RVA: 0xF29E74
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

	// RVA: 0xF29E7C
	internal override object get_Current() { }

	// RVA: 0xF29EE4
	internal override void set_Current(object value) { }

	// RVA: 0xF29F68
	internal override Type get_DataType() { }

	// RVA: 0xF2A008
	internal override Int64 get_Seed() { }

	// RVA: 0xF2A010
	internal override void set_Seed(Int64 value) { }

	// RVA: 0xF2A1CC
	internal override Int64 get_Step() { }

	// RVA: 0xF2A1D4
	internal override void set_Step(Int64 value) { }

	// RVA: 0xF2A2F0
	internal override void MoveAfter() { }

	// RVA: 0xF2A304
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xF2A384
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0xF2A0BC
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xF22D40
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

	// RVA: 0xF2A4F0
	internal override object get_Current() { }

	// RVA: 0xF2A558
	internal override void set_Current(object value) { }

	// RVA: 0xF2A5E4
	internal override Type get_DataType() { }

	// RVA: 0xF2A684
	internal override Int64 get_Seed() { }

	// RVA: 0xF2A68C
	internal override void set_Seed(Int64 value) { }

	// RVA: 0xF2A924
	internal override Int64 get_Step() { }

	// RVA: 0xF2A990
	internal override void set_Step(Int64 value) { }

	// RVA: 0xF2AB88
	internal override void MoveAfter() { }

	// RVA: 0xF2AC28
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xF2AC64
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0xF2A7A8
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xF22D50
	public void .ctor() { }

}

// Namespace: System.Data
[Serializable]
public class DataException
{
	// Methods

	// RVA: 0xF2AD50
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2AD58
	public void .ctor() { }

	// RVA: 0xF2ADC0
	public void .ctor(string s) { }

	// RVA: 0xF2ADF0
	public void .ctor(string s, Exception innerException) { }

}

// Namespace: System.Data
[Serializable]
public class ConstraintException
{
	// Methods

	// RVA: 0xF2ADF8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2AE00
	public void .ctor() { }

	// RVA: 0xF2AE68
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class DeletedRowInaccessibleException
{
	// Methods

	// RVA: 0xF2AE98
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2AEA0
	public void .ctor() { }

	// RVA: 0xF2AF08
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class DuplicateNameException
{
	// Methods

	// RVA: 0xF2AF38
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2AF40
	public void .ctor() { }

	// RVA: 0xF2AFA8
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class InRowChangingEventException
{
	// Methods

	// RVA: 0xF2AFD8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2AFE0
	public void .ctor() { }

	// RVA: 0xF2B048
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class InvalidConstraintException
{
	// Methods

	// RVA: 0xF2B078
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2B080
	public void .ctor() { }

	// RVA: 0xF2B0E8
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class NoNullAllowedException
{
	// Methods

	// RVA: 0xF2B118
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2B120
	public void .ctor() { }

	// RVA: 0xF2B188
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class ReadOnlyException
{
	// Methods

	// RVA: 0xF2B1B8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2B1C0
	public void .ctor() { }

	// RVA: 0xF2B228
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class RowNotInTableException
{
	// Methods

	// RVA: 0xF2B258
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2B260
	public void .ctor() { }

	// RVA: 0xF2B2C8
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class VersionNotFoundException
{
	// Methods

	// RVA: 0xF2B2F8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF2B300
	public void .ctor() { }

	// RVA: 0xF2B368
	public void .ctor(string s) { }

}

// Namespace: System.Data
internal static class ExceptionBuilder
{
	// Methods

	// RVA: 0xF2B398
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0xF2B440
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0xF25210
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0xF255A4
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0xF2B530
	internal static Exception _Argument(string error) { }

	// RVA: 0xF2B598
	internal static Exception _Argument(string paramName, string error) { }

	// RVA: 0xF2B600
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0xF2B670
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0xF2B6E0
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0xF2B750
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0xF2B7B8
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0xF2B820
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: 0x318DB98
	private static Exception _InvalidEnumArgumentException(T value) { }

	// RVA: 0xF2B888
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0xF2B8E0
	private static Exception _Data(string error) { }

	// RVA: 0xF2B954
	private static Exception _Constraint(string error) { }

	// RVA: 0xF2B9C8
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0xF2BA3C
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0xF2BAB0
	private static Exception _DuplicateName(string error) { }

	// RVA: 0xF2BB24
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0xF2BB98
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0xF2BC0C
	private static Exception _ReadOnly(string error) { }

	// RVA: 0xF2BC80
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0xF2BCF4
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0xF20598
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0xF2BD68
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0xF2BE7C
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0xF2BF8C
	public static Exception ArgumentContainsNull(string paramName) { }

	// RVA: 0xF2C09C
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0xF2C1A4
	public static Exception CannotModifyCollection() { }

	// RVA: 0xF2C234
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0xF2C344
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0xF2C454
	public static Exception InvalidOffsetLength() { }

	// RVA: 0xF2C4E4
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0xF2C604
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0xF2C694
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0xF2C7C0
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0xF2C8D0
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0xF2C9E0
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0xF278F4
	public static Exception CannotAddColumn3() { }

	// RVA: 0xF27984
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0xF2CAF0
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0xF2CC0C
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0xF2CD28
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0xF2CE44
	public static Exception CannotRemoveColumn() { }

	// RVA: 0xF2CED4
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0xF2CF64
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0xF2D074
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0xF2D194
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0xF2D2B4
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0xF2D344
	public static Exception NoConstraintName() { }

	// RVA: 0xF2D3D4
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0xF2D4F0
	public static string KeysToString(object[] keys) { }

	// RVA: 0xF2D610
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0xF2D824
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0xF2D89C
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0xF2D9C8
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0xF2DAE4
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0xF2DC00
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0xF2DD2C
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0xF2DDBC
	public static Exception ConstraintForeignTable() { }

	// RVA: 0xF2DE4C
	public static Exception ConstraintParentValues() { }

	// RVA: 0xF2DEDC
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0xF2DFDC
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0xF2E06C
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0xF2E188
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0xF2E2A4
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0xF2E3D8
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0xF2E4E8
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0xF29330
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0xF295E4
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0xF2E5F8
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0xF21A44
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0xF21AD4
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0xF2A260
	public static Exception AutoIncrementSeed() { }

	// RVA: 0xF23D2C
	public static Exception CantChangeDataType() { }

	// RVA: 0xF23DBC
	public static Exception NullDataType() { }

	// RVA: 0xF236DC
	public static Exception ColumnNameRequired() { }

	// RVA: 0xF24CE0
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0xF24610
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xF24D70
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xF24F4C
	public static Exception ExpressionAndUnique() { }

	// RVA: 0xF25300
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0xF24FDC
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0xF2E708
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0xF25390
	public static Exception ExpressionCircular() { }

	// RVA: 0xF27F34
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0xF27CFC
	public static Exception NullKeyValues(string column) { }

	// RVA: 0xF27E18
	public static Exception NullValues(string column) { }

	// RVA: 0xF267B4
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0xF2E7FC
	public static Exception ReadOnly(string column) { }

	// RVA: 0xF273C8
	public static Exception UniqueAndExpression() { }

	// RVA: 0xF26C0C
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0xF2E918
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0xF27C08
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0xF26118
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0xF25BCC
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0xF24840
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0xF277D4
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0xF26540
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0xF25CC0
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0xF21E54
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0xF2EA0C
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0xF2EB1C
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0xF2EC38
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0xF2ED48
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0xF24A98
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0xF24C7C
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0xF24B28
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0xF206AC
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0xF2EE50
	public static Exception SetFailed(string name) { }

	// RVA: 0xF2EF6C
	public static Exception SetRowStateFilter() { }

	// RVA: 0xF2F008
	public static Exception CanNotUseDataViewManager() { }

	// RVA: 0xF2F0A4
	public static Exception CanNotSetTable() { }

	// RVA: 0xF2F140
	public static Exception CanNotUse() { }

	// RVA: 0xF2F1DC
	public static Exception CanNotBindTable() { }

	// RVA: 0xF2F278
	public static Exception SetTable() { }

	// RVA: 0xF2F314
	public static Exception SetIListObject() { }

	// RVA: 0xF2F3A4
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0xF2F440
	public static Exception NotOpen() { }

	// RVA: 0xF2F4DC
	public static Exception CreateChildView() { }

	// RVA: 0xF2F56C
	public static Exception CanNotDelete() { }

	// RVA: 0xF2F608
	public static Exception GetElementIndex(int index) { }

	// RVA: 0xF2F734
	public static Exception AddExternalObject() { }

	// RVA: 0xF2F7C4
	public static Exception CanNotClear() { }

	// RVA: 0xF2F854
	public static Exception InsertExternalObject() { }

	// RVA: 0xF2F8E4
	public static Exception RemoveExternalObject() { }

	// RVA: 0xF2F974
	public static Exception ColumnToSortIsOutOfRange(string column) { }

	// RVA: 0xF2FA84
	public static Exception KeyTableMismatch() { }

	// RVA: 0xF2FB20
	public static Exception KeyNoColumns() { }

	// RVA: 0xF2FBBC
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0xF2FCF4
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0xF2FE10
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0xF23FD0
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0xF2FEAC
	public static Exception KeyLengthMismatch() { }

	// RVA: 0xF2FF3C
	public static Exception KeyLengthZero() { }

	// RVA: 0xF2FFCC
	public static Exception ForeignRelation() { }

	// RVA: 0xF3005C
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0xF300F8
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0xF30224
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xF30350
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xF3047C
	public static Exception RelationForeignRow() { }

	// RVA: 0xF3050C
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0xF3059C
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0xF306AC
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0xF307BC
	public static Exception RelationDoesNotExist() { }

	// RVA: 0xF3084C
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0xF308E8
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0xF309F8
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0xF30B08
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0xF30B98
	public static Exception RowNotInTheTable() { }

	// RVA: 0xF30C34
	public static Exception EditInRowChanging() { }

	// RVA: 0xF30CD0
	public static Exception EndEditInRowChanging() { }

	// RVA: 0xF30D6C
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0xF30E08
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0xF30EA4
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0xF30F40
	public static Exception ValueArrayLength() { }

	// RVA: 0xF30FD0
	public static Exception NoCurrentData() { }

	// RVA: 0xF3106C
	public static Exception NoOriginalData() { }

	// RVA: 0xF31108
	public static Exception NoProposedData() { }

	// RVA: 0xF311A4
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0xF31240
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0xF312DC
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0xF31378
	public static Exception RowEmpty() { }

	// RVA: 0xF31408
	public static Exception InvalidRowVersion() { }

	// RVA: 0xF314A4
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0xF315D0
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0xF3170C
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0xF3181C
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0xF318B8
	public static Exception MultipleParents() { }

	// RVA: 0xF31954
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0xF319B8
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0xF31A48
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0xF31AD8
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0xF31BE8
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0xF31CF8
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0xF31E08
	public static Exception TablesInDifferentSets() { }

	// RVA: 0xF31E98
	public static Exception RelationAlreadyExists() { }

	// RVA: 0xF31F28
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0xF31FB8
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0xF32048
	public static Exception RecordStateRange() { }

	// RVA: 0xF320D8
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0xF3227C
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0xF323C4
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0xF32454
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0xF324E4
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0xF325F4
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0xF32714
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0xF32830
	public static Exception RelationTableNull() { }

	// RVA: 0xF328C0
	public static Exception RelationDataSetNull() { }

	// RVA: 0xF32950
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0xF329E0
	public static Exception ParentTableMismatch() { }

	// RVA: 0xF32A70
	public static Exception ChildTableMismatch() { }

	// RVA: 0xF32B00
	public static Exception EnforceConstraint() { }

	// RVA: 0xF32B9C
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0xF32C2C
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0xF32CC0
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0xF32D58
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0xF32DBC
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0xF32E4C
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0xF32EDC
	public static Exception NoTableName() { }

	// RVA: 0xF32F6C
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0xF32FFC
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0xF3310C
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0xF33228
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0xF33354
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0xF33470
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0xF3358C
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0xF3361C
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0xF336AC
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0xF337D8
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0xF338E8
	public static Exception TableInRelation() { }

	// RVA: 0xF33978
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0xF33A94
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0xF33B24
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0xF33BB4
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0xF33C44
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0xF33CD4
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0xF33DE4
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0xF33F44
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0xF34078
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0xF341CC
	public static Exception NullRange() { }

	// RVA: 0xF34268
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0xF342F8
	public static Exception ProblematicChars(Char charValue) { }

	// RVA: 0xF3446C
	public static Exception StorageSetFailed() { }

	// RVA: 0xF344FC
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0xF34598
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0xF345F4
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0xF34720
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0xF3484C
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0xF34980
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0xF34A9C
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0xF34BB8
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0xF34CD4
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0xF34DF0
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0xF34F0C
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0xF35028
	public static Exception DatatypeNotDefined() { }

	// RVA: 0xF350C4
	public static Exception MismatchKeyLength() { }

	// RVA: 0xF35160
	public static Exception InvalidField(string name) { }

	// RVA: 0xF3527C
	public static Exception InvalidSelector(string name) { }

	// RVA: 0xF35398
	public static Exception CircularComplexType(string name) { }

	// RVA: 0xF354B4
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0xF355D0
	public static Exception InvalidKey(string name) { }

	// RVA: 0xF356EC
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0xF35808
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0xF358A4
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0xF359C0
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0xF35ADC
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0xF35C08
	public static Exception MissingRefer(string name) { }

	// RVA: 0xF23A3C
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0xF35D3C
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0xF35DCC
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0xF35E68
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0xF35F04
	public static Exception NestedCircular(string name) { }

	// RVA: 0xF36020
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0xF3613C
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0xF3624C
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0xF362DC
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0xF36378
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0xF36494
	public static Exception FoundEntity() { }

	// RVA: 0xF36530
	public static Exception MergeFailed(string name) { }

	// RVA: 0xF365A4
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0xF366E4
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0xF36804
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0xF36920
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

	// RVA: 0xF369B0
	public void .ctor() { }

	// RVA: 0xF36CA0
	public void .ctor(string dataSetName) { }

	// RVA: 0xF36EA4
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xF36EAC
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xF36F58
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0xF36F60
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF36F68
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0xF371D0
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF377F4
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0xF371D8
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xF3717C
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xF38574
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xF38A7C
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xF377F8
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF38C54
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF379C0
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF38F54
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF3A2EC
	internal void FailedEnableConstraints() { }

	// RVA: 0xF3A4A8
	public bool get_CaseSensitive() { }

	// RVA: 0xF3A4B0
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xF3ABF4
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xF3ABFC
	public DataViewManager get_DefaultViewManager() { }

	// RVA: 0xF3AD48
	public bool get_EnforceConstraints() { }

	// RVA: 0xF3A320
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0xF3B4A8
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0xF3AD50
	internal void EnableConstraints() { }

	// RVA: 0xF3B4B0
	public string get_DataSetName() { }

	// RVA: 0xF36CCC
	public void set_DataSetName(string value) { }

	// RVA: 0xF3B534
	public string get_Namespace() { }

	// RVA: 0xF3B53C
	public void set_Namespace(string value) { }

	// RVA: 0xF3BA9C
	public string get_Prefix() { }

	// RVA: 0xF3BAA4
	public void set_Prefix(string value) { }

	// RVA: 0xF3A260
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF3BC60
	public bool get_IsInitialized() { }

	// RVA: 0xF3BC70
	public CultureInfo get_Locale() { }

	// RVA: 0xF3BC78
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xF3BE20
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0xF3CA30
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xF3CA38
	public override ISite get_Site() { }

	// RVA: 0xF3CA40
	public override void set_Site(ISite value) { }

	// RVA: 0xF3CC20
	public DataRelationCollection get_Relations() { }

	// RVA: 0xF3CC28
	public DataTableCollection get_Tables() { }

	// RVA: 0xF3CC30
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xF3CCD4
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xF3CD78
	public void BeginInit() { }

	// RVA: 0xF3CD84
	public void EndInit() { }

	// RVA: 0xF3CFB4
	public void Clear() { }

	// RVA: 0xF3D1FC
	public virtual DataSet Clone() { }

	// RVA: 0xF38228
	internal int EstimatedXmlStringSize() { }

	// RVA: 0xF3E2FC
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xF3E300
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0xF38090
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0xF3E438
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0xF39830
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF3E99C
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xF3EF0C
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0xF3EA68
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xF3E59C
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF3E440
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xF3EFA0
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xF3F1F0
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0xF3F1F8
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF3EB40
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0xF41B24
	private bool IsEmpty() { }

	// RVA: 0xF40588
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xF3A258
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0xF41FA4
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xF38348
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0xF41E18
	public void Merge(DataSet dataSet) { }

	// RVA: 0xF42F40
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF431C4
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF431E8
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0xF4324C
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF4333C
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0xF3D1D8
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0xF3CF24
	private void OnInitialized() { }

	// RVA: 0xF43360
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0xF43364
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0xF43394
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xF43398
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0xF3B4B8
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF433A8
	internal DataTable[] TopLevelTables() { }

	// RVA: 0xF433B0
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0xF436EC
	public virtual void Reset() { }

	// RVA: 0xF3A7AC
	internal bool ValidateCaseConstraint() { }

	// RVA: 0xF3C580
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0xF439D0
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	// RVA: 0xF43AF8
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xF43E80
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xF4410C
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF442E0
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF44534
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF4456C
	internal string get_MainTableName() { }

	// RVA: 0xF44574
	internal void set_MainTableName(string value) { }

	// RVA: 0xF4457C
	internal int get_ObjectID() { }

}

// Namespace: 
internal struct RowDiffIdUsageSection
{
	// Fields
	private DataTable _targetTable; // 0x10

	// Methods

	// RVA: 0xF44584
	internal void Prepare(DataTable table) { }

}

// Namespace: 
internal struct DSRowDiffIdUsageSection
{
	// Fields
	private DataSet _targetDS; // 0x10

	// Methods

	// RVA: 0xF40504
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

	// RVA: 0xF03544
	public void .ctor() { }

	// RVA: 0xF03B28
	public void .ctor(string tableName) { }

	// RVA: 0xF03B9C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF040F8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF041F4
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xF03D58
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xF045CC
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xF05A50
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xF08D38
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xF09D88
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xF0AB0C
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xF0ACE8
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xF0531C
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xF069BC
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xF0B1A4
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0xF0AEB8
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xF0B28C
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xF0B57C
	public bool get_CaseSensitive() { }

	// RVA: 0xF0B584
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xF0B624
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0xF0B634
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0xF0BA88
	internal void SuspendIndexEvents() { }

	// RVA: 0xF0BB6C
	public bool get_IsInitialized() { }

	// RVA: 0xF0BB7C
	private bool get_IsTypedDataTable() { }

	// RVA: 0xF09474
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0xF0BC4C
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0xF0BC54
	internal bool get_SelfNested() { }

	// RVA: 0xF0C080
	internal System.Collections.Generic.List<System.Data.Index> get_LiveIndexes() { }

	// RVA: 0xF0C150
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xF0C158
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xF0C1C4
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0xF0C1CC
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0xF0C1D4
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0xF0C27C
	public DataColumnCollection get_Columns() { }

	// RVA: 0xF0C284
	private CompareInfo get_CompareInfo() { }

	// RVA: 0xF0C2E8
	public ConstraintCollection get_Constraints() { }

	// RVA: 0xF0C2F0
	private void ResetConstraints() { }

	// RVA: 0xF0C310
	public DataSet get_DataSet() { }

	// RVA: 0xF0C318
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xF0C3E8
	public DataView get_DefaultView() { }

	// RVA: 0xF0C4F8
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0xF0C560
	internal bool get_EnforceConstraints() { }

	// RVA: 0xF0C598
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0xF0CB9C
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0xF0CBA4
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0xF0C5E8
	internal void EnableConstraints() { }

	// RVA: 0xF08748
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF0CBAC
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xF0CC5C
	public CultureInfo get_Locale() { }

	// RVA: 0xF0CC64
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xF0978C
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0xF0D12C
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xF0D134
	public int get_MinimumCapacity() { }

	// RVA: 0xF09D54
	public void set_MinimumCapacity(int value) { }

	// RVA: 0xF0D154
	internal int get_RecordCapacity() { }

	// RVA: 0xF0D174
	internal int get_ElementColumnCount() { }

	// RVA: 0xF0D17C
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0xF0BFD8
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0xF0D1CC
	internal bool get_MergingData() { }

	// RVA: 0xF0D1D4
	internal void set_MergingData(bool value) { }

	// RVA: 0xF0D1DC
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0xF0D1E4
	internal bool get_SchemaLoading() { }

	// RVA: 0xF0D1EC
	internal void CacheNestedParent() { }

	// RVA: 0xF0D218
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0xF0D6CC
	internal int get_NestedParentsCount() { }

	// RVA: 0xF0DA18
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0xF0DB18
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0xF0E02C
	public DataRowCollection get_Rows() { }

	// RVA: 0xF0E034
	public string get_TableName() { }

	// RVA: 0xF0E03C
	public void set_TableName(string value) { }

	// RVA: 0xF0E7A8
	internal string get_EncodedTableName() { }

	// RVA: 0xF0E858
	private string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables) { }

	// RVA: 0xF059C8
	public string get_Namespace() { }

	// RVA: 0xF08340
	public void set_Namespace(string value) { }

	// RVA: 0xF0F980
	internal bool IsNamespaceInherited() { }

	// RVA: 0xF0EA60
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0xF0EEB4
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0xF0F990
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0xF0F328
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0xF0FDE8
	public virtual void BeginInit() { }

	// RVA: 0xF0FDF4
	public virtual void EndInit() { }

	// RVA: 0xF10468
	public string get_Prefix() { }

	// RVA: 0xF10470
	public void set_Prefix(string value) { }

	// RVA: 0xF1061C
	internal DataColumn get_XmlText() { }

	// RVA: 0xF10624
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0xF106F0
	internal Decimal get_MaxOccurs() { }

	// RVA: 0xF106FC
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0xF10704
	internal Decimal get_MinOccurs() { }

	// RVA: 0xF10710
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0xF10718
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0xF107B4
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0xF10848
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0xF108D4
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0xF10D04
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0xF11888
	protected virtual DataTable CreateInstance() { }

	// RVA: 0xF11918
	public virtual DataTable Clone() { }

	// RVA: 0xF11920
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0xF11B30
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0xF11E6C
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0xF075B8
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0xF12394
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xF1244C
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xF12504
	public override ISite get_Site() { }

	// RVA: 0xF1250C
	public override void set_Site(ISite value) { }

	// RVA: 0xF126EC
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0xF126FC
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0xF12708
	internal void InsertRow(DataRow row, Int64 proposedID, int pos, bool fireEvent) { }

	// RVA: 0xF13548
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0xF1357C
	public void Clear() { }

	// RVA: 0xF13584
	internal void Clear(bool clearAll) { }

	// RVA: 0xF13FC4
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0xF14094
	internal void CommitRow(DataRow row) { }

	// RVA: 0xF14350
	internal int Compare(string s1, string s2) { }

	// RVA: 0xF14358
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0xF144F4
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0xF1457C
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0xF14604
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xF1460C
	internal void DeleteRow(DataRow row) { }

	// RVA: 0xF146AC
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0xF147DC
	internal void FreeRecord(int record) { }

	// RVA: 0xF147FC
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF14C28
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF14E20
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xF14E24
	internal System.Collections.Generic.List<System.Data.DataViewListener> GetListeners() { }

	// RVA: 0xF0D020
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0xF1138C
	internal void InsertRow(DataRow row, Int64 proposedID) { }

	// RVA: 0xF15E88
	internal int NewRecord() { }

	// RVA: 0xF15F7C
	internal int NewUninitializedRecord() { }

	// RVA: 0xF15E90
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0xF0B148
	internal DataRow NewEmptyRow() { }

	// RVA: 0xF15F9C
	private DataRow NewUninitializedRow() { }

	// RVA: 0xF16068
	public DataRow NewRow() { }

	// RVA: 0xF161E4
	internal DataRow CreateEmptyRow() { }

	// RVA: 0xF16150
	private void NewRowCreated(DataRow row) { }

	// RVA: 0xF15FD4
	internal DataRow NewRow(int record) { }

	// RVA: 0xF165C8
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0xF16630
	protected virtual Type GetRowType() { }

	// RVA: 0xF166D0
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0xF168DC
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0xF16934
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0xF16A18
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0xF16AFC
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF16BE0
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0xF16BF0
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0xF142A0
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xF141F0
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xF16BF4
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0xF16CD8
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0xF16DBC
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0xF16EA0
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0xF16F84
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0xF17068
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0xF1714C
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0xF1035C
	private void OnInitialized() { }

	// RVA: 0xF1483C
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0xF0E72C
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF17230
	internal void RecordChanged(int record) { }

	// RVA: 0xF173FC
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0xF15014
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF151F8
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0xF176DC
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xF178C0
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xF17AF0
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0xF187C4
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0xF18978
	public virtual void Reset() { }

	// RVA: 0xF075B0
	internal void ResetIndexes() { }

	// RVA: 0xF18D04
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0xF18F64
	internal void RollbackRow(DataRow row) { }

	// RVA: 0xF15C18
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xF19010
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xF14E2C
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0xF109F8
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged) { }

	// RVA: 0xF12AE8
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, Exception deferredException) { }

	// RVA: 0xF10A54
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0xF19288
	private void RestoreShadowIndexes() { }

	// RVA: 0xF0BA28
	private void SetShadowIndexes() { }

	// RVA: 0xF192A8
	internal void ShadowIndexCopy() { }

	// RVA: 0xF1934C
	public override string ToString() { }

	// RVA: 0xF18FF0
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0xF19418
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0xF196DC
	internal DataColumn AddUniqueKey() { }

	// RVA: 0xF196E4
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0xF19798
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0xF197AC
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0xF08680
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0xF19BC0
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0xF19BD0
	public void Merge(DataTable table) { }

	// RVA: 0xF19BDC
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF19E64
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0xF1A2AC
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xF087D4
	private bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF1A754
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0xF1AB18
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0xF1AB70
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0xF1ADB4
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xF1CAAC
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xF1CB84
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xF1E3A0
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xF1BF7C
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xF1E46C
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF1CC00
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF1A374
	private void CreateTableList(DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF1E6F0
	private void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList) { }

	// RVA: 0xF1EC70
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xF1EEBC
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF1EECC
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0xF1F0A0
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF1F25C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF1F294
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xF1F2A0
	internal Hashtable get_RowDiffId() { }

	// RVA: 0xF1F32C
	internal int get_ObjectID() { }

	// RVA: 0xF1F334
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF1F42C
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF1F4CC
	internal void EvaluateExpressions() { }

	// RVA: 0xF1553C
	internal void EvaluateExpressions(DataRow row, DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows) { }

	// RVA: 0xF1F828
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0xF13DDC
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0xF17C78
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

	// RVA: 0xF445BC
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xF4472C
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0xF4492C
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF44E38
	internal override object Eval() { }

	// RVA: 0xF44E4C
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF470A4
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF470E0
	internal override bool IsConstant() { }

	// RVA: 0xF4717C
	internal override bool IsTableConstant() { }

	// RVA: 0xF47200
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF47284
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF47308
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF473A4
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF4582C
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0xF45AC4
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0xF47588
	internal FunctionId get_Aggregate() { }

	// RVA: 0xF47630
	internal bool get_IsAggregate() { }

	// RVA: 0xF44C30
	internal void Check() { }

	// RVA: 0xF478F8
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

	// RVA: 0xF482D4
	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0xF48568
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

	// RVA: 0xF4A5A4
	private static void .cctor() { }

	// RVA: 0xF4A610
	public void .ctor() { }

	// RVA: 0xF4A618
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

	// RVA: 0xF494C8
	internal void .ctor(Scope previousScope, System.Collections.Generic.IEnumerable<System.Type> allowedTypes) { }

	// RVA: 0xF49994
	public void Dispose() { }

	// RVA: 0xF48FB8
	public bool IsAllowedType(Type type) { }

	// RVA: 0xF49A74
	private static bool IsTypeUnconditionallyAllowed(Type type) { }

	// RVA: 0xF49C6C
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

	// RVA: 0xF4A680
	private static void .cctor() { }

	// RVA: 0xF4A6EC
	public void .ctor() { }

	// RVA: 0xF4A6F4
	internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

	// RVA: 0xF4A710
	internal System.Collections.Generic.IEnumerable<System.Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }

}

// Namespace: System.Data
internal sealed class TypeLimiter
{
	// Fields
	private static Scope s_activeScope; // 0xFFFFFFFF
	private Scope m_instanceScope; // 0x10

	// Methods

	// RVA: 0xF48DAC
	private void .ctor(Scope scope) { }

	// RVA: 0xF48DE0
	private static bool get_IsTypeLimitingDisabled() { }

	// RVA: 0xF48E88
	public static TypeLimiter Capture() { }

	// RVA: 0xF48F14
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0xF49180
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0xF4964C
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0xF497A0
	private static System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0xF492D4
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

	// RVA: 0xF4A718
	public virtual int get_Count() { }

	// RVA: 0xF4A748
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0xF4A790
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xF4A7C0
	public bool get_IsSynchronized() { }

	// RVA: 0xF4A7C8
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0xF4A898
	public object get_SyncRoot() { }

	// RVA: 0xF4A89C
	protected virtual ArrayList get_List() { }

	// RVA: 0xF4A8A4
	public void .ctor() { }

	// RVA: 0xF4A8AC
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class ColumnTypeConverter
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0xF4A93C
	public void .ctor() { }

	// RVA: 0xF4A944
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF4AA10
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xF4AF6C
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xF4B038
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0xF4B24C
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0xF4B390
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0xF4B398
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xF4B3A0
	private static void .cctor() { }

}

// Namespace: System.Data
internal class DataCommonEventSource
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static Int64 s_nextScopeId; // 0x8

	// Methods

	// RVA: 0xF4C068
	internal void Trace(string message) { }

	// RVA: 0x318DB98
	internal void Trace(string format, T0 arg0) { }

	// RVA: 0x318DB98
	internal void Trace(string format, T0 arg0, T1 arg1) { }

	// RVA: 0x318DB98
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2) { }

	// RVA: 0x318DB98
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x318DB98
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x318DB98
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	// RVA: 0xF4C078
	internal Int64 EnterScope(string message) { }

	// RVA: 0x318DB98
	internal Int64 EnterScope(string format, T1 arg1) { }

	// RVA: 0x318DB98
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2) { }

	// RVA: 0x318DB98
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x318DB98
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0xF4C158
	internal void ExitScope(Int64 scopeId) { }

	// RVA: 0xF4C168
	public void .ctor() { }

	// RVA: 0xF4C170
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

	// RVA: 0xF4C1EC
	public virtual string get_ConstraintName() { }

	// RVA: 0xF4C1F4
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0xF4C694
	internal string get_SchemaName() { }

	// RVA: 0xF4C6DC
	internal void set_SchemaName(string value) { }

	// RVA: 0xF4C724
	internal virtual bool get_InCollection() { }

	// RVA: 0xF4C72C
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1
	public abstract DataTable get_Table() { }

	// RVA: 0xF4C78C
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1
	internal abstract bool ContainsColumn(DataColumn column) { }

	// RVA: -1
	internal abstract bool CanEnableConstraint() { }

	// RVA: -1
	internal abstract Constraint Clone(DataSet destination) { }

	// RVA: -1
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup) { }

	// RVA: 0xF4C818
	internal void CheckConstraint() { }

	// RVA: -1
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint) { }

	// RVA: -1
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException) { }

	// RVA: -1
	internal abstract void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: -1
	internal abstract void CheckState() { }

	// RVA: 0xF4C878
	protected void CheckStateForProperty() { }

	// RVA: 0xF4C988
	protected virtual DataSet get__DataSet() { }

	// RVA: -1
	internal abstract bool IsConstraintViolated() { }

	// RVA: 0xF4C990
	public override string ToString() { }

	// RVA: 0xF4C99C
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

	// RVA: 0xF4CA20
	internal void .ctor(DataTable table) { }

	// RVA: 0xF4CAE4
	protected override ArrayList get_List() { }

	// RVA: 0xF4CAEC
	public Constraint get_Item(int index) { }

	// RVA: 0xF4CBF4
	internal DataTable get_Table() { }

	// RVA: 0xF4CBFC
	public Constraint get_Item(string name) { }

	// RVA: 0xF4CEAC
	public void Add(Constraint constraint) { }

	// RVA: 0xF4CEB4
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0xF4D9AC
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0xF4D510
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0xF4D808
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0xF4D43C
	private bool AutoGenerated(Constraint constraint) { }

	// RVA: 0xF4D948
	private void ArrayAdd(Constraint constraint) { }

	// RVA: 0xF4DA58
	private void ArrayRemove(Constraint constraint) { }

	// RVA: 0xF4D7D8
	internal string AssignName() { }

	// RVA: 0xF4D87C
	private void BaseAdd(Constraint constraint) { }

	// RVA: 0xF4DB6C
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0xF4DD3C
	private void BaseRemove(Constraint constraint) { }

	// RVA: 0xF4E004
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0xF4E034
	public void Clear() { }

	// RVA: 0xF4E438
	public bool Contains(string name) { }

	// RVA: 0xF4E454
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF4D2C4
	internal Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0xF4D5FC
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0xF4E5E8
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0xF4E718
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF4E550
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0xF4CD04
	internal int InternalIndexOf(string constraintName) { }

	// RVA: 0xF4DA98
	private string MakeName(int index) { }

	// RVA: 0xF4D988
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF4C408
	internal void RegisterName(string name) { }

	// RVA: 0xF4E990
	public void Remove(Constraint constraint) { }

	// RVA: 0xF4C610
	internal void UnregisterName(string name) { }

	// RVA: 0xF4EB18
	internal void FinishInitConstraints() { }

}

// Namespace: System.Data
internal sealed class ConstraintConverter
{
	// Methods

	// RVA: 0xF4F464
	public void .ctor() { }

	// RVA: 0xF4F46C
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF4F538
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

	// RVA: 0xF4FFE4
	public void .ctor(DataSet dataSet) { }

	// RVA: 0xF50050
	public bool GetNext() { }

	// RVA: 0xF503C8
	public Constraint GetConstraint() { }

	// RVA: 0xF503D0
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF503D8
	protected Constraint get_CurrentObject() { }

}

// Namespace: System.Data
internal class ForeignKeyConstraintEnumerator
{
	// Methods

	// RVA: 0xF503E0
	public void .ctor(DataSet dataSet) { }

	// RVA: 0xF5044C
	protected override bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF504D0
	public ForeignKeyConstraint GetForeignKeyConstraint() { }

}

// Namespace: System.Data
internal sealed class ChildForeignKeyConstraintEnumerator
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF5054C
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF505D4
	protected override bool IsValidCandidate(Constraint constraint) { }

}

// Namespace: System.Data
internal sealed class ParentForeignKeyConstraintEnumerator
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF50680
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF50708
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

	// RVA: 0xF507B8
	internal void .ctor(DataRow row) { }

	// RVA: 0xF50830
	public void .ctor(DataRow row, DataColumn column, object value) { }

	// RVA: 0xF508D8
	public object get_ProposedValue() { }

	// RVA: 0xF508E0
	public void set_ProposedValue(object value) { }

	// RVA: 0xF508E8
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

// Namespace: System.Data
public sealed class DataColumnChangeEventHandler
{
	// Methods

	// RVA: 0xF5091C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF50A40
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

	// RVA: 0xF50A54
	internal void .ctor(DataTable table) { }

	// RVA: 0xF50BF8
	protected override ArrayList get_List() { }

	// RVA: 0xF50C00
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0xF50C08
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0xF50C10
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0xF50C18
	public DataColumn get_Item(int index) { }

	// RVA: 0xF4F0D4
	public DataColumn get_Item(string name) { }

	// RVA: 0xF50EF8
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0xF50FB8
	public void Add(DataColumn column) { }

	// RVA: 0xF50FC4
	internal void AddAt(int index, DataColumn column) { }

	// RVA: 0xF5184C
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF518F0
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF51994
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF51A38
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF516E8
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0xF51668
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0xF51B34
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0xF51DD4
	internal string AssignName() { }

	// RVA: 0xF512F8
	private void BaseAdd(DataColumn column) { }

	// RVA: 0xF5234C
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0xF52538
	private void BaseRemove(DataColumn column) { }

	// RVA: 0xF52688
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0xF51ADC
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0xF530D0
	public void Clear() { }

	// RVA: 0xF533A8
	public bool Contains(string name) { }

	// RVA: 0xF5345C
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF53500
	public int IndexOf(string columnName) { }

	// RVA: 0xF50D60
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0xF53620
	internal void FinishInitCollection() { }

	// RVA: 0xF51E70
	private string MakeName(int index) { }

	// RVA: 0xF51790
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF512D4
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF53700
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF51F44
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0xF5375C
	internal bool CanRegisterName(string name) { }

	// RVA: 0xF537C8
	public void Remove(DataColumn column) { }

	// RVA: 0xF52220
	internal void UnregisterName(string name) { }

	// RVA: 0xF52FF0
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0xF51C74
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

}

// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor
{
	// Fields
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF538DC
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0xF53920
	public override AttributeCollection get_Attributes() { }

	// RVA: 0xF53AF0
	internal DataColumn get_Column() { }

	// RVA: 0xF53AF8
	public override Type get_ComponentType() { }

	// RVA: 0xF53B98
	public override bool get_IsReadOnly() { }

	// RVA: 0xF53BB8
	public override Type get_PropertyType() { }

	// RVA: 0xF53BD8
	public override bool Equals(object other) { }

	// RVA: 0xF53C60
	public override int GetHashCode() { }

	// RVA: 0xF53C84
	public override bool CanResetValue(object component) { }

	// RVA: 0xF53E44
	public override object GetValue(object component) { }

	// RVA: 0xF53ED8
	public override void ResetValue(object component) { }

	// RVA: 0xF54068
	public override void SetValue(object component, object value) { }

	// RVA: 0xF5414C
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xF54154
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

	// RVA: 0xF541AC
	internal void .ctor() { }

	// RVA: 0xF54218
	internal void .ctor(string rowError) { }

	// RVA: 0xF54338
	internal string get_Text() { }

	// RVA: 0xF54340
	internal void set_Text(string value) { }

	// RVA: 0xF543AC
	internal bool get_HasErrors() { }

	// RVA: 0xF543E8
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF54788
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0xF5451C
	internal void Clear(DataColumn column) { }

	// RVA: 0xF54828
	internal void Clear() { }

	// RVA: 0xF548D0
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0xF542CC
	private void SetText(string errorText) { }

	// RVA: 0xF54638
	internal int IndexOf(DataColumn column) { }

}

// Namespace: System.Data
internal struct DataKey
{
	// Fields
	private readonly DataColumn[] _columns; // 0x10

	// Methods

	// RVA: 0xF549E8
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0xF54CB4
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF54CBC
	internal bool get_HasValue() { }

	// RVA: 0xF4FFB0
	internal DataTable get_Table() { }

	// RVA: 0xF54C10
	internal void CheckState() { }

	// RVA: 0xF54CCC
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0xF54DC8
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0xF52F2C
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF54EC4
	public override int GetHashCode() { }

	// RVA: 0xF54F34
	public override bool Equals(object value) { }

	// RVA: 0xF55064
	internal bool Equals(DataKey value) { }

	// RVA: 0xF5513C
	internal string[] GetColumnNames() { }

	// RVA: 0xF55218
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0xF55330
	internal object[] GetKeyValues(int record) { }

	// RVA: 0xF55464
	internal Index GetSortIndex() { }

	// RVA: 0xF554BC
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0xF55518
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0xF5559C
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

	// RVA: 0xF55698
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0xF55C20
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF55CF0
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF55DC4
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF55EEC
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF5604C
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0xF56174
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0xF52FA8
	internal DataKey get_ChildKey() { }

	// RVA: 0xF56198
	public virtual DataTable get_ChildTable() { }

	// RVA: 0xF561DC
	public virtual DataSet get_DataSet() { }

	// RVA: 0xF56200
	internal string[] get_ParentColumnNames() { }

	// RVA: 0xF56208
	internal string[] get_ChildColumnNames() { }

	// RVA: 0xF56210
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0xF562CC
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0xF56484
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF5660C
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF5694C
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xF56964
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0xF56988
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0xF52FCC
	internal DataKey get_ParentKey() { }

	// RVA: 0xF56990
	public virtual DataTable get_ParentTable() { }

	// RVA: 0xF569D4
	public virtual string get_RelationName() { }

	// RVA: 0xF569F8
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0xF56D80
	internal void CheckNestedRelations() { }

	// RVA: 0xF57140
	public virtual bool get_Nested() { }

	// RVA: 0xF57164
	public virtual void set_Nested(bool value) { }

	// RVA: 0xF589A8
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0xF589CC
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0xF589D4
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0xF589F8
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF58A84
	internal bool get_CheckMultipleNested() { }

	// RVA: 0xF58A8C
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0xF58A94
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0xF58A9C
	internal void CheckState() { }

	// RVA: 0xF56070
	protected void CheckStateForProperty() { }

	// RVA: 0xF558EC
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF58D78
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0xF59550
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF58858
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF59634
	public override string ToString() { }

	// RVA: 0xF58388
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0xF59640
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0xF59824
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

	// RVA: 0xF5AF9C
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0xF5B0C8
	protected override ArrayList get_List() { }

	// RVA: 0xF5B0D0
	private void EnsureDataSet() { }

	// RVA: 0xF5B120
	protected override DataSet GetDataSet() { }

	// RVA: 0xF5B16C
	public override DataRelation get_Item(int index) { }

	// RVA: 0xF5B278
	public override DataRelation get_Item(string name) { }

	// RVA: 0xF5B380
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF5B424
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF5B4C8
	private void AddCache(DataRelation relation) { }

	// RVA: 0xF5B520
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xF5B620
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0xF5B704
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

	// RVA: 0xF5B7D0
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0xF5B8F4
	protected override ArrayList get_List() { }

	// RVA: 0xF5B8FC
	public override void Clear() { }

	// RVA: 0xF5B950
	protected override DataSet GetDataSet() { }

	// RVA: 0xF5B958
	public override DataRelation get_Item(int index) { }

	// RVA: 0xF5BA64
	public override DataRelation get_Item(string name) { }

	// RVA: 0xF5BB6C
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xF5C250
	protected override void RemoveCore(DataRelation relation) { }

	// RVA: 0xF5C4E0
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

	// RVA: 0xF5982C
	internal int get_ObjectID() { }

	// RVA: -1
	public abstract DataRelation get_Item(int index) { }

	// RVA: -1
	public abstract DataRelation get_Item(string name) { }

	// RVA: 0xF59834
	public void Add(DataRelation relation) { }

	// RVA: 0xF59AF0
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0xF59D8C
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF59EC4
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF59FFC
	internal string AssignName() { }

	// RVA: 0xF5A100
	public virtual void Clear() { }

	// RVA: 0xF5A368
	public virtual bool Contains(string name) { }

	// RVA: 0xF5A384
	internal int InternalIndexOf(string name) { }

	// RVA: -1
	protected abstract DataSet GetDataSet() { }

	// RVA: 0xF5A02C
	private string MakeName(int index) { }

	// RVA: 0xF5A53C
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF5A620
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF5A704
	internal void RegisterName(string name) { }

	// RVA: 0xF5A910
	public void Remove(DataRelation relation) { }

	// RVA: 0xF5AB2C
	public void RemoveAt(int index) { }

	// RVA: 0xF5ABAC
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0xF5AD94
	internal void UnregisterName(string name) { }

	// RVA: 0xF5AEF0
	protected void .ctor() { }

}

// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor
{
	// Fields
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF5C9B8
	internal void .ctor(DataRelation dataRelation) { }

	// RVA: 0xF5CA10
	internal DataRelation get_Relation() { }

	// RVA: 0xF5CA18
	public override Type get_ComponentType() { }

	// RVA: 0xF5CAB8
	public override bool get_IsReadOnly() { }

	// RVA: 0xF5CAC0
	public override Type get_PropertyType() { }

	// RVA: 0xF5CB60
	public override bool Equals(object other) { }

	// RVA: 0xF5CBE8
	public override int GetHashCode() { }

	// RVA: 0xF5CC0C
	public override bool CanResetValue(object component) { }

	// RVA: 0xF5CC14
	public override object GetValue(object component) { }

	// RVA: 0xF5CCB4
	public override void ResetValue(object component) { }

	// RVA: 0xF5CCB8
	public override void SetValue(object component, object value) { }

	// RVA: 0xF5CCBC
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

	// RVA: 0xF5CCC4
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0xF5CD7C
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0xF5CD98
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0xF5CDAC
	internal bool get_HasPropertyChanged() { }

	// RVA: 0xF5CDBC
	internal int get_RBTreeNodeId() { }

	// RVA: 0xF5CDC4
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0xF5CEA0
	public string get_RowError() { }

	// RVA: 0xF5CF08
	public void set_RowError(string value) { }

	// RVA: 0xF5D16C
	private void RowErrorChanged() { }

	// RVA: 0xF5D1CC
	internal Int64 get_rowID() { }

	// RVA: 0xF5D1D4
	internal void set_rowID(Int64 value) { }

	// RVA: 0xF5D23C
	public DataRowState get_RowState() { }

	// RVA: 0xF5D4FC
	public DataTable get_Table() { }

	// RVA: 0xF588C8
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0xF5D504
	internal int GetNestedParentCount() { }

	// RVA: 0xF5D5C4
	public void set_Item(string columnName, object value) { }

	// RVA: 0xF5D474
	public object get_Item(DataColumn column) { }

	// RVA: 0xF5D6B4
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0xF5DDF8
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0xF5DF94
	public void set_ItemArray(object[] value) { }

	// RVA: 0xF5E3FC
	public void AcceptChanges() { }

	// RVA: 0xF5E7A0
	public void BeginEdit() { }

	// RVA: 0xF5DB50
	private bool BeginEditInternal() { }

	// RVA: 0xF5DC7C
	public void CancelEdit() { }

	// RVA: 0xF5DA50
	private void CheckColumn(DataColumn column) { }

	// RVA: 0xF5E7A4
	internal void CheckInTable() { }

	// RVA: 0xF5E7EC
	public void Delete() { }

	// RVA: 0xF5DCF0
	public void EndEdit() { }

	// RVA: 0xF5E85C
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0xF5E8CC
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF5ECA4
	public string GetColumnError(string columnName) { }

	// RVA: 0xF5EB58
	public string GetColumnError(DataColumn column) { }

	// RVA: 0xF5ED18
	public void ClearErrors() { }

	// RVA: 0xF52EC0
	internal void ClearError(DataColumn column) { }

	// RVA: 0xF5ED84
	public bool get_HasErrors() { }

	// RVA: 0xF5EDD4
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0xF5EEC4
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0xF5EECC
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF5D648
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0xF589A0
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0xF5F000
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF5F128
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0xF5F1E0
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0xF5F1E8
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF5F31C
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0xF5F3B4
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0xF5F40C
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0xF56454
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0xF5F48C
	internal int GetCurrentRecordNo() { }

	// RVA: 0xF5DAE0
	internal int GetDefaultRecord() { }

	// RVA: 0xF5F4D4
	internal int GetOriginalRecordNo() { }

	// RVA: 0xF5DC34
	private int GetProposedRecordNo() { }

	// RVA: 0xF5DE48
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0xF5F51C
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0xF5F548
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0xF5F59C
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0xF5F5A8
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF56890
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0xF5F774
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0xF5F804
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF5F8A4
	public void RejectChanges() { }

	// RVA: 0xF5D20C
	internal void ResetLastChangedColumn() { }

	// RVA: 0xF5FF20
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0xF600DC
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0xF60528
	internal void SetParentRowToDBNull() { }

	// RVA: 0xF60800
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0xF60988
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

// Namespace: System.Data
public sealed class DataRowBuilder
{
	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xF60D64
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

	// RVA: 0xF60DAC
	public void .ctor(DataRow row, DataRowAction action) { }

}

// Namespace: System.Data
public sealed class DataRowChangeEventHandler
{
	// Methods

	// RVA: 0xF60E38
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF60F5C
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

}

// Namespace: 
private sealed class DataRowTree
{
	// Methods

	// RVA: 0xF61058
	internal void .ctor() { }

	// RVA: 0xF61790
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0xF617C4
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

	// RVA: 0xF60F70
	internal void .ctor(DataTable table) { }

	// RVA: 0xF610B0
	public override int get_Count() { }

	// RVA: 0xF52E48
	public DataRow get_Item(int index) { }

	// RVA: 0xF61104
	public void Add(DataRow row) { }

	// RVA: 0xF61128
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0xF6136C
	public int IndexOf(DataRow row) { }

	// RVA: 0xF61414
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0xF61480
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0xF614F4
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0xF61570
	internal void ArrayClear() { }

	// RVA: 0xF615C4
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0xF61664
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0xF616D0
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0xF6173C
	public override IEnumerator GetEnumerator() { }

}

// Namespace: System.Data
internal sealed class DataRowCreatedEventHandler
{
	// Methods

	// RVA: 0xF617F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF6191C
	public virtual void Invoke(object sender, DataRow r) { }

}

// Namespace: System.Data
internal sealed class DataSetClearEventhandler
{
	// Methods

	// RVA: 0xF61930
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF61A54
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

	// RVA: 0xF61A68
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xF61AB8
	public override bool Equals(object other) { }

	// RVA: 0xF61AC4
	public override int GetHashCode() { }

	// RVA: 0xF61AE8
	public DataView get_DataView() { }

	// RVA: 0xF61AF0
	private string System.ComponentModel.IDataErrorInfo.get_Item(string colName) { }

	// RVA: 0xF61B0C
	private string System.ComponentModel.IDataErrorInfo.get_Error() { }

	// RVA: 0xF61B7C
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0xF61BD8
	internal int GetRecord() { }

	// RVA: 0xF61C28
	internal bool HasRecord() { }

	// RVA: 0xF53DBC
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0xF53FB4
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0xF61C8C
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0xF5CCAC
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0xF61E78
	public DataRow get_Row() { }

	// RVA: 0xF61E80
	public void BeginEdit() { }

	// RVA: 0xF61E8C
	public void CancelEdit() { }

	// RVA: 0xF61F68
	public void EndEdit() { }

	// RVA: 0xF61F3C
	public bool get_IsNew() { }

	// RVA: 0xF61FCC
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF62070
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF62114
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0xF621A8
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xF62204
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xF6220C
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xF62214
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xF6221C
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xF62224
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xF6222C
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xF62234
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xF62290
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xF622EC
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xF62394
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xF62444
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xF62448
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

	// RVA: 0xF624D4
	public void .ctor(DataTable dataTable) { }

}

// Namespace: System.Data
public sealed class DataTableClearEventHandler
{
	// Methods

	// RVA: 0xF6254C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF62670
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

	// RVA: 0xF62684
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0xF62834
	protected override ArrayList get_List() { }

	// RVA: 0xF6283C
	internal int get_ObjectID() { }

	// RVA: 0xF62844
	public DataTable get_Item(int index) { }

	// RVA: 0xF4F238
	public DataTable get_Item(string name) { }

	// RVA: 0xF4F348
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0xF62D98
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0xF62ED4
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0xF63018
	public void Add(DataTable table) { }

	// RVA: 0xF6365C
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF63794
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF63550
	private void ArrayAdd(DataTable table) { }

	// RVA: 0xF638CC
	internal string AssignName() { }

	// RVA: 0xF633B0
	private void BaseAdd(DataTable table) { }

	// RVA: 0xF63CB0
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0xF63E8C
	private void BaseRemove(DataTable table) { }

	// RVA: 0xF63F08
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0xF645A0
	public void Clear() { }

	// RVA: 0xF63A00
	public bool Contains(string name) { }

	// RVA: 0xF648EC
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0xF64B30
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF64C7C
	public int IndexOf(DataTable table) { }

	// RVA: 0xF64D6C
	public int IndexOf(string tableName) { }

	// RVA: 0xF64D88
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0xF64DF4
	internal void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF6298C
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0xF62BE0
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0xF64E48
	internal void FinishInitCollection() { }

	// RVA: 0xF6392C
	private string MakeName(int index) { }

	// RVA: 0xF63578
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF632CC
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF63A1C
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0xF64EDC
	public void Remove(DataTable table) { }

	// RVA: 0xF64464
	internal void UnregisterName(string name) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventArgs
{
	// Fields
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0xF650D8
	public void .ctor(DataRow dataRow) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventHandler
{
	// Methods

	// RVA: 0xF65150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF65274
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

}

// Namespace: System.Data
internal sealed class DataTablePropertyDescriptor
{
	// Fields
	private readonly DataTable <Table>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF65288
	public DataTable get_Table() { }

	// RVA: 0xF65290
	internal void .ctor(DataTable dataTable) { }

	// RVA: 0xF652D4
	public override Type get_ComponentType() { }

	// RVA: 0xF65374
	public override bool get_IsReadOnly() { }

	// RVA: 0xF6537C
	public override Type get_PropertyType() { }

	// RVA: 0xF6541C
	public override bool Equals(object other) { }

	// RVA: 0xF654A4
	public override int GetHashCode() { }

	// RVA: 0xF654C8
	public override bool CanResetValue(object component) { }

	// RVA: 0xF654D0
	public override object GetValue(object component) { }

	// RVA: 0xF65614
	public override void ResetValue(object component) { }

	// RVA: 0xF65618
	public override void SetValue(object component, object value) { }

	// RVA: 0xF6561C
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: System.Data
internal sealed class DataTableTypeConverter
{
	// Methods

	// RVA: 0xF65624
	public void .ctor() { }

	// RVA: 0xF656D8
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: 
private sealed class DataRowReferenceComparer
{
	// Fields
	internal static readonly DataRowReferenceComparer s_default; // 0x0

	// Methods

	// RVA: 0xF6B7E0
	private void .ctor() { }

	// RVA: 0xF6B7E8
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0xF6B7F4
	public int GetHashCode(DataRow obj) { }

	// RVA: 0xF6B810
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

	// RVA: 0xF656E0
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0xF65CD8
	public void .ctor(DataTable table) { }

	// RVA: 0xF660EC
	public bool get_AllowDelete() { }

	// RVA: 0xF660F4
	public bool get_AllowEdit() { }

	// RVA: 0xF660FC
	public bool get_AllowNew() { }

	// RVA: 0xF66104
	public int get_Count() { }

	// RVA: 0xF66158
	private int get_CountFromIndex() { }

	// RVA: 0xF66174
	public DataViewManager get_DataViewManager() { }

	// RVA: 0xF6617C
	public bool get_IsInitialized() { }

	// RVA: 0xF6618C
	protected bool get_IsOpen() { }

	// RVA: 0xF66194
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xF6619C
	public virtual string get_RowFilter() { }

	// RVA: 0xF662B4
	public virtual void set_RowFilter(string value) { }

	// RVA: 0xF664D8
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0xF664E0
	public void set_RowStateFilter(DataViewRowState value) { }

	// RVA: 0xF66648
	public string get_Sort() { }

	// RVA: 0xF666A0
	public void set_Sort(string value) { }

	// RVA: 0xF66920
	internal System.Comparison<System.Data.DataRow> get_SortComparison() { }

	// RVA: 0xF66928
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xF6692C
	public DataTable get_Table() { }

	// RVA: 0xF66934
	public void set_Table(DataTable value) { }

	// RVA: 0xF66BFC
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0xF66CF4
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0xF66C78
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0xF66E7C
	public virtual DataRowView AddNew() { }

	// RVA: 0xF6732C
	public void BeginInit() { }

	// RVA: 0xF67338
	public void EndInit() { }

	// RVA: 0xF671BC
	private void CheckOpen() { }

	// RVA: 0xF668C0
	private void CheckSort(string sort) { }

	// RVA: 0xF675C4
	protected void Close() { }

	// RVA: 0xF6761C
	public void CopyTo(Array array, int index) { }

	// RVA: 0xF6790C
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0xF67BE4
	public void Delete(int index) { }

	// RVA: 0xF67C0C
	internal void Delete(DataRow row) { }

	// RVA: 0xF6801C
	protected override void Dispose(bool disposing) { }

	// RVA: 0xF67DF4
	internal void FinishAddNew(bool success) { }

	// RVA: 0xF6807C
	public IEnumerator GetEnumerator() { }

	// RVA: 0xF68140
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xF68148
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xF68150
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xF681E4
	private void System.Collections.IList.Clear() { }

	// RVA: 0xF68214
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xF682AC
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xF67200
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0xF68348
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0xF683A4
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xF683D4
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xF68508
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xF68530
	internal Index GetFindIndex(string column, bool keepIndex) { }

	// RVA: 0xF686EC
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xF686F4
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xF68704
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xF6870C
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xF68714
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xF6871C
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xF68724
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xF6872C
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xF687AC
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xF6884C
	internal PropertyDescriptor GetSortProperty() { }

	// RVA: 0xF688EC
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xF6892C
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF68A64
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF68B9C
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xF68C40
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xF68CE4
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xF68D28
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF68E38
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xF690D4
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xF69118
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xF69210
	private void System.ComponentModel.IBindingListView.ApplySort(ListSortDescriptionCollection sorts) { }

	// RVA: 0xF68D50
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF69734
	private void System.ComponentModel.IBindingListView.RemoveFilter() { }

	// RVA: 0xF69838
	private string System.ComponentModel.IBindingListView.get_Filter() { }

	// RVA: 0xF69848
	private void System.ComponentModel.IBindingListView.set_Filter(string value) { }

	// RVA: 0xF69858
	private ListSortDescriptionCollection System.ComponentModel.IBindingListView.get_SortDescriptions() { }

	// RVA: 0xF6985C
	internal ListSortDescriptionCollection GetSortDescriptions() { }

	// RVA: 0xF69B00
	private bool System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting() { }

	// RVA: 0xF69B08
	private bool System.ComponentModel.IBindingListView.get_SupportsFiltering() { }

	// RVA: 0xF69B10
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF69BCC
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF69C9C
	internal virtual IFilter GetFilter() { }

	// RVA: 0xF69CA4
	private int GetRecord(int recordIndex) { }

	// RVA: 0xF66D24
	internal DataRow GetRow(int index) { }

	// RVA: 0xF6787C
	private DataRowView GetRowView(int record) { }

	// RVA: 0xF66E04
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0xF69D70
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0xF69E0C
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0xF69ED8
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xF6A4C0
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF67534
	private void OnInitialized() { }

	// RVA: 0xF6A884
	protected void Reset() { }

	// RVA: 0xF6A1FC
	internal void ResetRowViewCache() { }

	// RVA: 0xF6A8B4
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xF6AB08
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0xF65D4C
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0xF67608
	protected void UpdateIndex() { }

	// RVA: 0xF6AECC
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0xF6AB10
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0xF6B0D8
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF6B2F8
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF6B518
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF6B738
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF6B748
	internal int get_ObjectID() { }

	// RVA: 0xF6B750
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

	// RVA: 0xF65A5C
	internal void .ctor(DataView dv) { }

	// RVA: 0xF6B87C
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF6B960
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF6BA20
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF6BAF0
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xF6BBCC
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF65AEC
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0xF66BF4
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0xF6BE8C
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0xF6AFE4
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0xF6AED4
	internal void UnregisterListChangedEvent() { }

	// RVA: 0xF6B93C
	private void CleanUp(bool updateListeners) { }

	// RVA: 0xF6BC8C
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

	// RVA: 0xF6C14C
	internal void .ctor(DataSet dataSet, bool locked) { }

	// RVA: 0xF6C444
	public DataSet get_DataSet() { }

	// RVA: 0xF6C44C
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0xF6C454
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF6C548
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0xF6C550
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xF6C554
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xF6C55C
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xF6C564
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xF6C56C
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xF6C604
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xF6C60C
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xF6C63C
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xF6C66C
	private void System.Collections.IList.Clear() { }

	// RVA: 0xF6C69C
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xF6C6AC
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xF6C6C0
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xF6C6F0
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xF6C720
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xF6C750
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xF6C758
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xF6C7A0
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xF6C7A8
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xF6C7B0
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xF6C7B8
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xF6C7C0
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xF6C7C8
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xF6C810
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xF6C858
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xF6C8A0
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF6C944
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF6C9E8
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xF6C9EC
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF6CA34
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xF6CA7C
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xF6CA80
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xF6CAC8
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF6CBA0
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF6CD38
	public DataView CreateDataView(DataTable table) { }

	// RVA: 0xF6CE30
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF6CF28
	protected virtual void TableCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF6D178
	protected virtual void RelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF6D398
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class DataViewManagerListItemTypeDescriptor
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private PropertyDescriptorCollection _propsCollection; // 0x18

	// Methods

	// RVA: 0xF6C350
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xF65548
	internal DataView GetDataView(DataTable table) { }

	// RVA: 0xF6D420
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xF6D47C
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xF6D484
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xF6D48C
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xF6D494
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xF6D49C
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xF6D4A4
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xF6D4AC
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xF6D508
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xF6D564
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xF6D60C
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xF6D81C
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

	// RVA: 0xF6D820
	internal void .ctor() { }

	// RVA: 0xF6D8AC
	public bool get_ApplyDefaultSort() { }

	// RVA: 0xF6D8B4
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xF6D8CC
	internal void SetDataTable(DataTable table) { }

	// RVA: 0xF6D8E4
	public string get_RowFilter() { }

	// RVA: 0xF6D8EC
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0xF6D8F4
	public string get_Sort() { }

}

// Namespace: 
private sealed class DataViewSettingsEnumerator
{
	// Fields
	private DataViewSettingCollection _dataViewSettings; // 0x10
	private IEnumerator _tableEnumerator; // 0x18

	// Methods

	// RVA: 0xF6DDA4
	public void .ctor(DataViewManager dvm) { }

	// RVA: 0xF6DF2C
	public bool MoveNext() { }

	// RVA: 0xF6DFE0
	public void Reset() { }

	// RVA: 0xF6E098
	public object get_Current() { }

}

// Namespace: System.Data
public class DataViewSettingCollection
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Methods

	// RVA: 0xF6C384
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xF6D8FC
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0xF6DA90
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0xF6DB4C
	public void CopyTo(Array ar, int index) { }

	// RVA: 0xF6DD64
	public virtual int get_Count() { }

	// RVA: 0xF6DCFC
	public IEnumerator GetEnumerator() { }

	// RVA: 0xF6DEF8
	public bool get_IsSynchronized() { }

	// RVA: 0xF6DF00
	public object get_SyncRoot() { }

	// RVA: 0xF6DF04
	internal void Remove(DataTable table) { }

}

// Namespace: System.Data
internal sealed class DefaultValueTypeConverter
{
	// Methods

	// RVA: 0xF6E1B8
	public void .ctor() { }

	// RVA: 0xF6E1C0
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xF6E3AC
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

	// RVA: 0xF6E558
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0xF6E564
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0xF6E6A4
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF6E940
	internal static void Bind(DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF6EAC0
	internal override object Eval() { }

	// RVA: 0xF6EAD4
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF6ED90
	internal override object Eval(int[] records) { }

	// RVA: 0xF6EE18
	internal override bool IsConstant() { }

	// RVA: 0xF6EE20
	internal override bool IsTableConstant() { }

	// RVA: 0xF6EE28
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF6EE30
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF6EE40
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF6EED4
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

	// RVA: 0xF6EED8
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xF6EF4C
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF6EFC0
	internal override object Eval() { }

	// RVA: 0xF6EFD4
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF74C70
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF74C88
	internal override bool IsConstant() { }

	// RVA: 0xF74CDC
	internal override bool IsTableConstant() { }

	// RVA: 0xF74D30
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF74D88
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF74DE0
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF74E48
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF75428
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0xF75464
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xF754A0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0xF754A8
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0xF6EFEC
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xF77AF8
	private DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0xF77B1C
	private static StorageType GetPrecedenceType(DataTypePrecedence code) { }

	// RVA: 0xF77B40
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0xF77BFC
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0xF77610
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xF76CF0
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xF77CD0
	private int SqlResultType(int typeCode) { }

}

// Namespace: System.Data
internal sealed class LikeNode
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0xF77D20
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xF77D94
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF78354
	internal string AnalyzePattern(string pat) { }

}

// Namespace: System.Data
internal sealed class ConstNode
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0xF788B4
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0xF750F4
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0xF792BC
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF792C4
	internal override object Eval() { }

	// RVA: 0xF792CC
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF792D8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF792E4
	internal override bool IsConstant() { }

	// RVA: 0xF792EC
	internal override bool IsTableConstant() { }

	// RVA: 0xF792F4
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF792FC
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF79304
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF78E1C
	private object SmallestDecimal(object constant) { }

	// RVA: 0xF788BC
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

	// RVA: 0xF664D0
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0xF79308
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0xF66258
	internal string get_Expression() { }

	// RVA: 0xF7A708
	internal bool get_HasValue() { }

	// RVA: 0xF7A5C0
	internal void Bind(DataTable table) { }

	// RVA: 0xF6EEB8
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0xF7A718
	internal object Evaluate() { }

	// RVA: 0xF7A724
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0xF7A95C
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xF7AA4C
	internal DataColumn[] GetDependency() { }

	// RVA: 0xF7AA54
	internal bool IsTableAggregate() { }

	// RVA: 0xF7AA6C
	internal static bool IsUnknown(object value) { }

	// RVA: 0xF7AAF4
	internal bool HasLocalAggregate() { }

	// RVA: 0xF7AB0C
	internal bool HasRemoteAggregate() { }

	// RVA: 0xF769D4
	internal static bool ToBoolean(object value) { }

}

// Namespace: System.Data
internal abstract class ExpressionNode
{
	// Fields
	private DataTable _table; // 0x10

	// Methods

	// RVA: 0xF6E670
	protected void .ctor(DataTable table) { }

	// RVA: 0xF76954
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xF7AB24
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0xF7AB2C
	protected DataTable get_table() { }

	// RVA: 0xF7AB34
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

	// RVA: 0xF7AB3C
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0xF77CC0
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0xF77AD8
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0xF77BBC
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0xF77C74
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0xF77BEC
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0xF77C90
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0xF77CB0
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0xF77D00
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0xF7AB44
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0xF7AB54
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

	// RVA: 0xF7C808
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

	// RVA: 0xF79528
	internal void .ctor(DataTable table) { }

	// RVA: 0xF795F8
	internal void LoadExpression(string data) { }

	// RVA: 0xF7AB70
	internal void StartScan() { }

	// RVA: 0xF79700
	internal ExpressionNode Parse() { }

	// RVA: 0xF7B750
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0xF7B710
	private ExpressionNode NodePop() { }

	// RVA: 0xF7B6C4
	private ExpressionNode NodePeek() { }

	// RVA: 0xF7B61C
	private void NodePush(ExpressionNode node) { }

	// RVA: 0xF7B2BC
	private void BuildExpression(int pri) { }

	// RVA: 0xF7B5C8
	internal void CheckToken(Tokens token) { }

	// RVA: 0xF7AC10
	internal Tokens Scan() { }

	// RVA: 0xF7BF04
	private void ScanNumeric() { }

	// RVA: 0xF7C2E8
	private void ScanName() { }

	// RVA: 0xF7BD78
	private void ScanName(Char chEnd, Char esc, string charsToEscape) { }

	// RVA: 0xF7BBD0
	private void ScanDate() { }

	// RVA: 0xF7C044
	private void ScanBinaryConstant() { }

	// RVA: 0xF7C058
	private void ScanReserved() { }

	// RVA: 0xF7BC90
	private void ScanString(Char escape) { }

	// RVA: 0xF7B56C
	internal void ScanToken(Tokens token) { }

	// RVA: 0xF7BB64
	private void ScanWhite() { }

	// RVA: 0xF7C374
	private bool IsWhiteSpace(Char ch) { }

	// RVA: 0xF7C29C
	private bool IsAlphaNumeric(Char ch) { }

	// RVA: 0xF7C048
	private bool IsDigit(Char ch) { }

	// RVA: 0xF7C354
	private bool IsAlpha(Char ch) { }

	// RVA: 0xF7C384
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

	// RVA: 0xF7C840
	internal void .ctor(Nodes type, int op, int pri) { }

}

// Namespace: System.Data
[Serializable]
public class InvalidExpressionException
{
	// Methods

	// RVA: 0xF7C880
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF7C888
	public void .ctor() { }

	// RVA: 0xF7C890
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class EvaluateException
{
	// Methods

	// RVA: 0xF7C898
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF7C8A0
	public void .ctor() { }

	// RVA: 0xF7C8A8
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class SyntaxErrorException
{
	// Methods

	// RVA: 0xF7C8B0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF7C8B8
	public void .ctor() { }

	// RVA: 0xF7C8C0
	public void .ctor(string s) { }

}

// Namespace: System.Data
internal sealed class ExprException
{
	// Methods

	// RVA: 0xF7C8C8
	private static OverflowException _Overflow(string error) { }

	// RVA: 0xF7C93C
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0xF7C9B0
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0xF7CA24
	private static EvaluateException _Eval(string error) { }

	// RVA: 0xF7CA98
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0xF7CB0C
	public static Exception InvokeArgument() { }

	// RVA: 0xF7CB54
	public static Exception NYI(string moreinfo) { }

	// RVA: 0xF7CC04
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0xF7CDE0
	public static Exception MissingOperator(string token) { }

	// RVA: 0xF7CE90
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0xF7CF40
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0xF7CFAC
	public static Exception ExpressionTooComplex() { }

	// RVA: 0xF7D048
	public static Exception UnboundName(string name) { }

	// RVA: 0xF7D0F8
	public static Exception InvalidString(string str) { }

	// RVA: 0xF7D1A8
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0xF7D258
	public static Exception SyntaxError() { }

	// RVA: 0xF7D2F4
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0xF7D3A4
	public static Exception MissingRightParen() { }

	// RVA: 0xF7D440
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0xF7D53C
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0xF7D698
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0xF7D780
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0xF7D868
	public static Exception InvalidName(string name) { }

	// RVA: 0xF7D918
	public static Exception InvalidDate(string date) { }

	// RVA: 0xF7D9C8
	public static Exception NonConstantArgument() { }

	// RVA: 0xF7DA64
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0xF7DB14
	public static Exception InWithoutParentheses() { }

	// RVA: 0xF7DBB0
	public static Exception InWithoutList() { }

	// RVA: 0xF7DC4C
	public static Exception InvalidIsSyntax() { }

	// RVA: 0xF7DCE8
	public static Exception Overflow(Type type) { }

	// RVA: 0xF7DDB0
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0xF7DED0
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0xF7DFCC
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0xF7E110
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0xF7E254
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0xF7E330
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0xF7E3E0
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0xF7E490
	public static Exception TooManyRightParentheses() { }

	// RVA: 0xF7E52C
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0xF7E5E4
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0xF7E694
	public static Exception AggregateArgument() { }

	// RVA: 0xF7E730
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0xF7E7E0
	public static Exception EvalNoContext() { }

	// RVA: 0xF7E87C
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0xF7E92C
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0xF7E9DC
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0xF7EA8C
	public static Exception LookupArgument() { }

	// RVA: 0xF7EB28
	public static Exception InvalidType(string typeName) { }

	// RVA: 0xF7EBD8
	public static Exception InvalidHoursArgument() { }

	// RVA: 0xF7EC74
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0xF7ED10
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0xF7EDAC
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0xF7EE48
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

	// RVA: 0xF7EEBC
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0xF7EF0C
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF7F190
	internal override object Eval() { }

	// RVA: 0xF7F1BC
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF7F2DC
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF7F314
	internal override bool IsConstant() { }

	// RVA: 0xF7F31C
	internal override bool IsTableConstant() { }

	// RVA: 0xF7F324
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF7F32C
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF7F334
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF7F344
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

	// RVA: 0xF7F348
	internal void .ctor(DataTable table, Char[] text, int start, int pos) { }

	// RVA: 0xF7F5EC
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xF7F620
	internal override bool get_IsSqlColumn() { }

	// RVA: 0xF7F640
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF7F870
	internal override object Eval() { }

	// RVA: 0xF7F89C
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF7F944
	internal override object Eval(int[] records) { }

	// RVA: 0xF7F97C
	internal override bool IsConstant() { }

	// RVA: 0xF7F984
	internal override bool IsTableConstant() { }

	// RVA: 0xF7F9DC
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF7FA34
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF7FA8C
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF7FAF4
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF7F39C
	internal static string ParseName(Char[] text, int start, int pos) { }

}

// Namespace: System.Data
internal sealed class Operators
{
	// Fields
	private static readonly int[] s_priority; // 0x0
	private static readonly string[] s_looks; // 0x8

	// Methods

	// RVA: 0xF7FAF8
	internal static bool IsArithmetical(int op) { }

	// RVA: 0xF7FB14
	internal static bool IsLogical(int op) { }

	// RVA: 0xF7FB34
	internal static bool IsRelational(int op) { }

	// RVA: 0xF7FB44
	internal static int Priority(int op) { }

	// RVA: 0xF7CCEC
	internal static string ToString(int op) { }

	// RVA: 0xF7FC24
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class UnaryNode
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0xF804C4
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0xF80508
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF8055C
	internal override object Eval() { }

	// RVA: 0xF80570
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF80CA4
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF805B4
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0xF80CC8
	internal override bool IsConstant() { }

	// RVA: 0xF80CEC
	internal override bool IsTableConstant() { }

	// RVA: 0xF80D10
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF80D34
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF80D58
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF80D80
	internal override ExpressionNode Optimize() { }

}

// Namespace: System.Data
internal sealed class ZeroOpNode
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0xF80E50
	internal void .ctor(int op) { }

	// RVA: 0xF80E80
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF80E84
	internal override object Eval() { }

	// RVA: 0xF80F80
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF80F8C
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF80F98
	internal override bool IsConstant() { }

	// RVA: 0xF80FA0
	internal override bool IsTableConstant() { }

	// RVA: 0xF80FA8
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF80FB0
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF80FB8
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

	// RVA: 0xF80FBC
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF81008
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF811EC
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0xF81298
	internal DataKey get_ChildKey() { }

	// RVA: 0xF812C0
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0xF812EC
	public override DataTable get_Table() { }

	// RVA: 0xF81318
	internal string[] get_ParentColumnNames() { }

	// RVA: 0xF81324
	internal string[] get_ChildColumnNames() { }

	// RVA: 0xF81330
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xF81458
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xF81460
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0xF8151C
	internal override bool IsConstraintViolated() { }

	// RVA: 0xF81C84
	internal override bool CanEnableConstraint() { }

	// RVA: 0xF81F1C
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0xF820F8
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0xF82778
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0xF829D8
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0xF82F14
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0xF82FF8
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0xF830D4
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0xF83204
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0xF83534
	private void NonVirtualCheckState() { }

	// RVA: 0xF83794
	internal override void CheckState() { }

	// RVA: 0xF83798
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0xF837C0
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0xF83820
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF8386C
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xF8387C
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xF8406C
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0xF81058
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF846E4
	public virtual Rule get_DeleteRule() { }

	// RVA: 0xF8470C
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0xF8476C
	public override bool Equals(object key) { }

	// RVA: 0xF84888
	public override int GetHashCode() { }

	// RVA: 0xF84890
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0xF84044
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0xF830AC
	internal DataKey get_ParentKey() { }

	// RVA: 0xF848BC
	internal DataRelation FindParentRelation() { }

	// RVA: 0xF84994
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0xF849C0
	public virtual Rule get_UpdateRule() { }

	// RVA: 0xF849E8
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

	// RVA: 0xF84A48
	public void .ctor(DataTable table, string conflict) { }

	// RVA: 0xF84ADC
	public string get_Conflict() { }

}

// Namespace: System.Data
public sealed class MergeFailedEventHandler
{
	// Methods

	// RVA: 0xF84AE4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF84C08
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

	// RVA: 0xF84C1C
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF84C74
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF84CD4
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0xF86988
	internal void MergeTable(DataTable src) { }

	// RVA: 0xF86C08
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0xF8726C
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0xF85C9C
	private void MergeTableData(DataTable src) { }

	// RVA: 0xF85D54
	private void MergeConstraints(DataSet source) { }

	// RVA: 0xF879B8
	private void MergeConstraints(DataTable table) { }

	// RVA: 0xF85DD0
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0xF86700
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0xF870E8
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

	// RVA: 0xF87C74
	public void .ctor() { }

	// RVA: 0xF87D28
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xF87D30
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF87DFC
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Data
[Serializable]
public class PropertyCollection
{
	// Methods

	// RVA: 0xF88030
	public void .ctor() { }

	// RVA: 0xF88038
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF88040
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

	// RVA: 0xF88340
	public void .ctor(int min, int max) { }

	// RVA: 0xF82668
	public int get_Count() { }

	// RVA: 0xF820E8
	public bool get_IsNull() { }

	// RVA: 0xF82688
	public int get_Min() { }

	// RVA: 0xF88398
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

	// RVA: 0x30D4A74
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

	// RVA: 0x30D4A04
	internal void .ctor(int size) { }

	// RVA: 0x30D3AE8
	internal int AllocSlot(System.Data.RBTree<K> tree) { }

	// RVA: 0x30D39B8
	internal int get_InUseCount() { }

	// RVA: 0x30D4A04
	internal void set_InUseCount(int value) { }

	// RVA: 0x30D39B8
	internal int get_PageId() { }

	// RVA: 0x30D4A04
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

	// RVA: 0x30D4CD4
	internal void .ctor(System.Data.RBTree<K> tree) { }

	// RVA: 0x30D4D3C
	internal void .ctor(System.Data.RBTree<K> tree, int position) { }

	// RVA: 0x30D488C
	public void Dispose() { }

	// RVA: 0x30D3738
	public bool MoveNext() { }

	// RVA: 0x318DB98
	public K get_Current() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D488C
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

	// RVA: 0x30D4A04
	protected void .ctor(TreeAccessMethod accessMethod) { }

	// RVA: 0x30D488C
	private void InitTree() { }

	// RVA: 0x30D4CD4
	private void FreePage(TreePage page) { }

	// RVA: -1
	private TreePage AllocPage(int size) { }

	// RVA: 0x30D4CD4
	private void MarkPageFull(TreePage page) { }

	// RVA: 0x30D4CD4
	private void MarkPageFree(TreePage page) { }

	// RVA: 0x318DB98
	private static int GetIntValueFromBitMap(UInt32 bitMap) { }

	// RVA: 0x30D4A04
	private void FreeNode(int nodeId) { }

	// RVA: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }

	// RVA: 0x30D39B8
	public int get_Count() { }

	// RVA: 0x30D3738
	public bool get_HasDuplicates() { }

	// RVA: 0x318DB98
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

	// RVA: 0x318DB98
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }

	// RVA: 0x318DB98
	public void UpdateNodeKey(K currentKey, K newKey) { }

	// RVA: 0x318DB98
	public K DeleteByIndex(int i) { }

	// RVA: -1
	public int RBDelete(int z_id) { }

	// RVA: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }

	// RVA: 0x318DB98
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }

	// RVA: 0x318DB98
	private int SearchSubTree(int root_id, K key) { }

	// RVA: 0x318DB98
	public K get_Item(int index) { }

	// RVA: 0x318DB98
	private NodePath GetNodeByKey(K key) { }

	// RVA: 0x318DB98
	public int GetIndexByKey(K key) { }

	// RVA: -1
	public int GetIndexByNode(int node) { }

	// RVA: 0x318DB98
	private int GetIndexByNodePath(NodePath path) { }

	// RVA: -1
	private int ComputeIndexByNode(int nodeId) { }

	// RVA: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }

	// RVA: 0x318DB98
	private NodePath GetNodeByIndex(int userIndex) { }

	// RVA: -1
	private int ComputeNodeByIndex(int index, int satelliteRootId) { }

	// RVA: 0x30D39EC
	private int ComputeNodeByIndex(int x_id, int index) { }

	// RVA: 0x318DB98
	public int Insert(K item) { }

	// RVA: 0x318DB98
	public int Add(K item) { }

	// RVA: 0x30D3CF0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x318DB98
	public int IndexOf(int nodeId, K item) { }

	// RVA: 0x318DB98
	public int Insert(int position, K item) { }

	// RVA: 0x318DB98
	public int InsertAt(int position, K item, bool append) { }

	// RVA: 0x30D4A04
	public void RemoveAt(int position) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x30D4D3C
	public void CopyTo(Array array, int index) { }

	// RVA: 0x30D4D3C
	public void CopyTo(K[] array, int index) { }

	// RVA: 0x30D4A74
	private void SetRight(int nodeId, int rightNodeId) { }

	// RVA: 0x30D4A74
	private void SetLeft(int nodeId, int leftNodeId) { }

	// RVA: 0x30D4A74
	private void SetParent(int nodeId, int parentNodeId) { }

	// RVA: 0x318DB98
	private void SetColor(int nodeId, NodeColor color) { }

	// RVA: 0x318DB98
	private void SetKey(int nodeId, K key) { }

	// RVA: 0x30D4A74
	private void SetNext(int nodeId, int nextNodeId) { }

	// RVA: 0x30D4A74
	private void SetSubTreeSize(int nodeId, int size) { }

	// RVA: 0x30D4A04
	private void IncreaseSize(int nodeId) { }

	// RVA: 0x30D4A04
	private void RecomputeSize(int nodeId) { }

	// RVA: 0x30D4A04
	private void DecreaseSize(int nodeId) { }

	// RVA: -1
	public int Right(int nodeId) { }

	// RVA: -1
	public int Left(int nodeId) { }

	// RVA: -1
	public int Parent(int nodeId) { }

	// RVA: 0x318DB98
	private NodeColor color(int nodeId) { }

	// RVA: -1
	public int Next(int nodeId) { }

	// RVA: -1
	public int SubTreeSize(int nodeId) { }

	// RVA: 0x318DB98
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

	// RVA: 0xF883DC
	internal void .ctor(DataTable table) { }

	// RVA: 0xF884C0
	private void GrowRecordCapacity() { }

	// RVA: 0xF886B8
	internal int get_LastFreeRecord() { }

	// RVA: 0xF886C0
	internal int get_MinimumCapacity() { }

	// RVA: 0xF886C8
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0xF88718
	internal int get_RecordCapacity() { }

	// RVA: 0xF8861C
	internal void set_RecordCapacity(int value) { }

	// RVA: 0xF885D4
	internal static int NewCapacity(int capacity) { }

	// RVA: 0xF885E8
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0xF88720
	internal int NewRecordBase() { }

	// RVA: 0xF88808
	internal void FreeRecord(int record) { }

	// RVA: 0xF889B8
	internal void Clear(bool clearAll) { }

	// RVA: 0xF88C28
	internal DataRow get_Item(int record) { }

	// RVA: 0xF88944
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0xF88C5C
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0xF88C64
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0xF890A8
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

	// RVA: 0xF890EC
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0xF89234
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0xF89378
	private object[] GetParentValues() { }

	// RVA: 0xF89430
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xF895C4
	internal override IFilter GetFilter() { }

	// RVA: 0xF895C8
	public override DataRowView AddNew() { }

	// RVA: 0xF8962C
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

// Namespace: System.Data
internal sealed class RelationshipConverter
{
	// Methods

	// RVA: 0xF8965C
	public void .ctor() { }

	// RVA: 0xF89664
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF89730
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

	// RVA: 0xF8A358
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0xF8A384
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0xF8A398
	public override bool Equals(object obj) { }

	// RVA: 0xF8A438
	public override int GetHashCode() { }

}

// Namespace: 
private sealed class IndexTree
{
	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0xF8D448
	internal void .ctor(Index index) { }

	// RVA: 0xF8E148
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0xF8E164
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

	// RVA: 0xF8E180
	private static void .cctor() { }

	// RVA: 0xF8E1EC
	public void .ctor() { }

	// RVA: 0xF8E1F4
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0xF8E200
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

}

// Namespace: 
private sealed class <>c__DisplayClass86_0
{
	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0xF8D6D0
	public void .ctor() { }

	// RVA: 0xF8E220
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

	// RVA: 0xF8A4C0
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF8A824
	public void .ctor(DataTable table, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF8A888
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0xF8A4D0
	private void .ctor(DataTable table, IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF8ADA8
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF8AE48
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0xF8AE50
	internal int get_ObjectID() { }

	// RVA: 0xF8AE58
	public DataViewRowState get_RecordStates() { }

	// RVA: 0xF8AE60
	public IFilter get_RowFilter() { }

	// RVA: 0xF8AEDC
	public int GetRecord(int recordIndex) { }

	// RVA: 0xF8AF54
	public bool get_HasDuplicates() { }

	// RVA: 0xF8AFA8
	public int get_RecordCount() { }

	// RVA: 0xF8AFB0
	private bool AcceptRecord(int record) { }

	// RVA: 0xF8B060
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0xF8B27C
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0xF8B2E0
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0xF8B344
	public int get_RefCount() { }

	// RVA: 0xF8B34C
	public void AddRef() { }

	// RVA: 0xF8B52C
	public int RemoveRef() { }

	// RVA: 0xF8B72C
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0xF8BDA0
	public bool CheckUnique() { }

	// RVA: 0xF8BDFC
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xF8BFA4
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0xF8C00C
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0xF8C1B4
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0xF8C298
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0xF8BD24
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0xF8C2A0
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0xF8C644
	public RBTreeEnumerator GetEnumerator(int startIndex) { }

	// RVA: 0xF8BD2C
	public int GetIndex(int record) { }

	// RVA: 0xF8BB7C
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0xF81868
	public object[] GetUniqueKeyValues() { }

	// RVA: 0xF8C8BC
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0xF8CB00
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0xF8CD88
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0xF8CE98
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0xF8CFD4
	public Range FindRecords(object key) { }

	// RVA: 0xF819F4
	public Range FindRecords(object[] key) { }

	// RVA: 0xF8D004
	internal void FireResetEvent() { }

	// RVA: 0xF8D3D0
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF8D3EC
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0xF826D0
	public DataRow GetRow(int i) { }

	// RVA: 0xF8D40C
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0xF81A24
	public DataRow[] GetRows(Range range) { }

	// RVA: 0xF8A988
	private void InitRecords(IFilter filter) { }

	// RVA: 0xF8D4B4
	public int InsertRecordToIndex(int record) { }

	// RVA: 0xF8B8BC
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0xF8D588
	public bool IsKeyInIndex(object key) { }

	// RVA: 0xF819D8
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0xF8D5A4
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0xF8D178
	private bool get_DoListChanged() { }

	// RVA: 0xF8D5C0
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0xF8C548
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0xF8D200
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF8C3F8
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0xF8D6D8
	public void Reset() { }

	// RVA: 0xF8D834
	public void RecordChanged(int record) { }

	// RVA: 0xF8D9D0
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0xF8DB34
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF8DC68
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0xF8E140
	internal DataTable get_Table() { }

	// RVA: 0xF8C6B8
	private void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId) { }

	// RVA: 0x318DB98
	internal static int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

}

// Namespace: 
internal sealed class Action<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

}

// Namespace: 
internal sealed class Func<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D4B6C
	internal void .ctor(int ObjectID, System.Data.Listeners.Func<TElem,TElem,System.Boolean> notifyFilter) { }

	// RVA: 0x30D3738
	internal bool get_HasListeners() { }

	// RVA: 0x318DB98
	internal void Add(TElem listener) { }

	// RVA: 0x318DB98
	internal int IndexOfReference(TElem listener) { }

	// RVA: 0x318DB98
	internal void Remove(TElem listener) { }

	// RVA: 0x318DB98
	internal void Notify(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem,TElem,T1,T2,T3> action) { }

	// RVA: 0x30D4A04
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

	// RVA: 0xF8E250
	internal void .ctor(string baseType) { }

	// RVA: 0xF8E388
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0xF8EF34
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF8E57C
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0xF8EF74
	internal bool IsPlainString() { }

	// RVA: 0xF8F0B8
	internal string get_BaseType() { }

	// RVA: 0xF8F0C0
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0xF8F0C8
	internal string get_Name() { }

	// RVA: 0xF8F0D0
	internal string get_Namespace() { }

	// RVA: 0xF8F0D8
	internal int get_Length() { }

	// RVA: 0xF8F0E0
	internal int get_MaxLength() { }

	// RVA: 0xF8F0E8
	internal void set_MaxLength(int value) { }

	// RVA: 0xF8F0F0
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0xF8F0F8
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0xF8F16C
	internal string QualifiedName(string name) { }

	// RVA: 0xF8F1EC
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0xF8F6F0
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0xF8F780
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0xF8F7F4
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0xF8F878
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0xF8F984
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0xF8FAD0
	internal bool CanHaveMaxLength() { }

	// RVA: 0xF8FB38
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

	// RVA: 0xF8FBE8
	public void .ctor(DataColumn column) { }

	// RVA: 0xF8FDA4
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0xF8FDE4
	public void .ctor(DataColumn[] columns) { }

	// RVA: 0xF8FE18
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0xF8FE74
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0xF8FEBC
	internal string[] get_ColumnNames() { }

	// RVA: 0xF8FEC8
	internal Index get_ConstraintIndex() { }

	// RVA: 0xF8FED0
	internal void ConstraintIndexClear() { }

	// RVA: 0xF8FF10
	internal void ConstraintIndexInitialize() { }

	// RVA: 0xF8FF6C
	internal override void CheckState() { }

	// RVA: 0xF8FF78
	private void NonVirtualCheckState() { }

	// RVA: 0xF8FF84
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xF8FF88
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xF9011C
	internal override bool CanEnableConstraint() { }

	// RVA: 0xF901AC
	internal override bool IsConstraintViolated() { }

	// RVA: 0xF90440
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xF90544
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF90550
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xF90560
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xF90B1C
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0xF91034
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0xF9053C
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF91040
	public bool get_IsPrimaryKey() { }

	// RVA: 0xF8FCA8
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0xF91090
	public override bool Equals(object key2) { }

	// RVA: 0xF91148
	public override int GetHashCode() { }

	// RVA: 0xF91150
	internal override void set_InCollection(bool value) { }

	// RVA: 0xF9119C
	internal DataKey get_Key() { }

	// RVA: 0xF911A4
	public override DataTable get_Table() { }

}

// Namespace: 
private sealed class NameType
{
	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0xF94DB8
	public void .ctor(string n, Type t) { }

	// RVA: 0xF94E08
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

	// RVA: 0xF911E8
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0xF91290
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0xF916DC
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0xF91A30
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0xF91C40
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0xF9150C
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0xF926BC
	private static NameType FindNameType(string name) { }

	// RVA: 0xF927C0
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0xF92924
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0xF92AA8
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0xF91DC0
	internal void GetMinMax(XmlElement elNode, int minOccurs, int maxOccurs) { }

	// RVA: 0xF93460
	internal void GetMinMax(XmlElement elNode, bool isAttribute, int minOccurs, int maxOccurs) { }

	// RVA: 0xF937BC
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0xF9200C
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0xF91DD0
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0xF939B8
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

	// RVA: 0xF94E84
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0xF9579C
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xF95B14
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0xF9503C
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0xF95D30
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0xF953F4
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0xF960BC
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0xF97568
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0xF965D8
	private int ReadOldRowData(DataSet ds, DataTable table, int pos, XmlReader row) { }

	// RVA: 0xF9656C
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0xF97750
	public void .ctor() { }

}

// Namespace: System.Data
internal class XMLSchema
{
	// Methods

	// RVA: 0xF97758
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0xF977E0
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xF97C80
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0xF97D0C
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0xF97E98
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0xF97FC4
	public void .ctor() { }

}

// Namespace: System.Data
internal sealed class ConstraintTable
{
	// Fields
	public DataTable table; // 0x10
	public XmlSchemaIdentityConstraint constraint; // 0x18

	// Methods

	// RVA: 0xF97FCC
	public void .ctor(DataTable t, XmlSchemaIdentityConstraint c) { }

}

// Namespace: 
private sealed class NameType
{
	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0xFA9248
	public void .ctor(string n, Type t) { }

	// RVA: 0xFA9298
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

	// RVA: 0xF9801C
	internal bool get_FromInference() { }

	// RVA: 0xF98024
	internal void set_FromInference(bool value) { }

	// RVA: 0xF9802C
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0xF980B8
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0xF98BB0
	internal static string QualifiedName(string name) { }

	// RVA: 0xF98C30
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF991DC
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF9959C
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF98A88
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0xF997A8
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xF999F0
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0xF99BDC
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0xF9A454
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xF9A6AC
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0xF9B0B8
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0xF9B480
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0xF9BA74
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0xF9BA9C
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0xF9F210
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0xF9AC2C
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0xF9F54C
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0xFA0E20
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0xFA1BAC
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0xFA1F60
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0xF9B93C
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0xFA37DC
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0xFA3960
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0xF9B2D0
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0xF9DAC0
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0xFA3C88
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0xFA3D24
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0xFA3E40
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0xFA4828
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0xFA4CDC
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0xF99ADC
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0xFA591C
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0xFA7010
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0xFA711C
	private static NameType FindNameType(string name) { }

	// RVA: 0xFA7220
	private Type ParseDataType(string dt) { }

	// RVA: 0xFA7410
	internal static bool IsXsdType(string name) { }

	// RVA: 0xF9DB6C
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0xFA2D10
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xFA2560
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xFA10F0
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0xF9FE94
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0xF9E030
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0xFA748C
	private void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, DataTable dt) { }

	// RVA: 0xFA5518
	private string GetPrefix(string ns) { }

	// RVA: 0xFA76DC
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0xFA6E80
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xFA46F8
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xF9AE58
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0xF9DE84
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0xFA7AE8
	public void .ctor() { }

	// RVA: 0xFA7AF0
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class XmlIgnoreNamespaceReader
{
	// Fields
	private System.Collections.Generic.List<System.String> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0xFA9314
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0xFA93B8
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xFA94C4
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

	// RVA: 0xFA9608
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xFA96B0
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xFA97B0
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xFA9870
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xFA9988
	internal bool get_FromInference() { }

	// RVA: 0xFA9990
	internal void set_FromInference(bool value) { }

	// RVA: 0xFA9998
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xFA9C18
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0xFA9E10
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0xFAA104
	private string GetInitialTextFromNodes(XmlNode n) { }

	// RVA: 0xFAA3B8
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0xFA9B74
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0xFAA48C
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0xFA9D74
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0xFAA5A4
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0xFAA8D8
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0xFAA0A8
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0xFAA454
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0xFAA978
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0xFAAE0C
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0xFABA5C
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xFABE14
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0xFABE90
	private void InitNameTable() { }

	// RVA: 0xFAC19C
	internal void LoadData(XmlReader reader) { }

	// RVA: 0xFAC64C
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0xFAD37C
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0xFAE360
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0xFAD130
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

	// RVA: 0xFB176C
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0xFB17BC
	public override int GetHashCode() { }

	// RVA: 0xFB17E0
	public override bool Equals(object obj) { }

}

// Namespace: 
internal sealed class XmlNodeIdHashtable
{
	// Fields
	private XmlNodeIdentety _id; // 0x50

	// Methods

	// RVA: 0xFB1888
	public void .ctor(int capacity) { }

	// RVA: 0xFB1950
	public object get_Item(XmlNode node) { }

	// RVA: 0xFB19EC
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0xFB1A80
	public object get_Item(DataTable table) { }

	// RVA: 0xFB1B0C
	public object get_Item(string name) { }

}

// Namespace: 
private sealed class TableSchemaInfo
{
	// Fields
	public DataTable TableSchema; // 0x10
	public XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0xFB1BA4
	public void .ctor(DataTable tableSchema) { }

}

// Namespace: System.Data
internal sealed class XmlToDatasetMap
{
	// Fields
	private XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0xFAACD8
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xFAC5CC
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xFAAC98
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xFAC60C
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xFABE60
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0xFB0BDC
	private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0xFB0D1C
	private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0xFB0EB8
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	// RVA: 0xFB1154
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns) { }

	// RVA: 0xFAEDB0
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xFAF38C
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xFAFE2C
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xFB0180
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xFB1320
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0xFAA694
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xFAE1FC
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0xFAAD18
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xFAD03C
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0xFB0FF0
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

	// RVA: 0xFB1C50
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0xFB1D00
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0xFB1D08
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0xFB244C
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xFB2608
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xFB2F3C
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0xFB3FC0
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0xFB44B4
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0xFB45B4
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0xFB488C
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0xFB48B8
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0xFB4A68
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0xFB4CDC
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0xFB4D8C
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0xFB5AF0
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0xFB5060
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0xFB6220
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xFB6598
	private void CreateRelations(DataTable dt) { }

	// RVA: 0xFB68E0
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0xFB6C0C
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0xFBA440
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0xFB9744
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0xFBD688
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0xFBD9A8
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0xFBD9C8
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0xFBD9BC
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0xFBDA94
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0xFBDA9C
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xFB9E74
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0xFBDC00
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0xFBDCFC
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0xFBDFA0
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0xFBE524
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0xFBEB2C
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0xFBEC58
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0xFBFA4C
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0xFBFAD4
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0xFB9DB8
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0xFBF870
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0xFB9DB0
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0xFBFBBC
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0xFB5BEC
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0xFBFF6C
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0xFB6148
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0xFB613C
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0xFC004C
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0xFC019C
	private bool IsAutoGenerated(object o) { }

	// RVA: 0xFBA91C
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0xFB3D64
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

	// RVA: 0xFC0260
	internal void .ctor(DataSet ds) { }

	// RVA: 0xFC0638
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xFC0760
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0xFC03B4
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0xFC0AD8
	private bool EmptyData() { }

	// RVA: 0xFC0BD0
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0xFC0BD8
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0xFC1D70
	private void GenerateTable(DataTable table) { }

	// RVA: 0xFC1DF0
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0xFC2394
	private void GenerateRow(DataRow row) { }

	// RVA: 0xFC2A78
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0xFC01E8
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

	// RVA: 0xFC1A0C
	internal void .ctor(DataSet ds) { }

	// RVA: 0xFC1148
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xFC38FC
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0xFC3584
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xFC2980
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0xFC12FC
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0xFC5654
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0xFC5F60
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0xFC3C28
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0xFC34A8
	internal static bool PreserveSpace(object value) { }

}

// Namespace: System.Data
internal sealed class DataTextWriter
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Methods

	// RVA: 0xFC10D4
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0xFC629C
	private void .ctor(XmlWriter w) { }

	// RVA: 0xFBD91C
	internal Stream get_BaseStream() { }

	// RVA: 0xFC62D0
	public override void WriteStartDocument() { }

	// RVA: 0xFC62F4
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xFC6318
	public override void WriteEndDocument() { }

	// RVA: 0xFC633C
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xFC6360
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xFC6384
	public override void WriteEndElement() { }

	// RVA: 0xFC63A8
	public override void WriteFullEndElement() { }

	// RVA: 0xFC63CC
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xFC63F0
	public override void WriteEndAttribute() { }

	// RVA: 0xFC6418
	public override void WriteCData(string text) { }

	// RVA: 0xFC6440
	public override void WriteComment(string text) { }

	// RVA: 0xFC6468
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xFC6490
	public override void WriteEntityRef(string name) { }

	// RVA: 0xFC64B8
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0xFC64E0
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xFC6508
	public override void WriteString(string text) { }

	// RVA: 0xFC6530
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0xFC6558
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0xFC6580
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0xFC65A8
	public override void WriteRaw(string data) { }

	// RVA: 0xFC65D0
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0xFC65F8
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0xFC6620
	public override WriteState get_WriteState() { }

	// RVA: 0xFC6648
	public override void Close() { }

	// RVA: 0xFC6670
	public override void Flush() { }

	// RVA: 0xFC6698
	public override string LookupPrefix(string ns) { }

}

// Namespace: System.Data
internal sealed class DataTextReader
{
	// Fields
	private XmlReader _xmlreader; // 0x10

	// Methods

	// RVA: 0xFC66C0
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0xFC6770
	private void .ctor(XmlReader input) { }

	// RVA: 0xFC67E8
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xFC680C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFC6830
	public override string get_Name() { }

	// RVA: 0xFC6854
	public override string get_LocalName() { }

	// RVA: 0xFC6878
	public override string get_NamespaceURI() { }

	// RVA: 0xFC689C
	public override string get_Prefix() { }

	// RVA: 0xFC68C0
	public override string get_Value() { }

	// RVA: 0xFC68E4
	public override int get_Depth() { }

	// RVA: 0xFC6908
	public override string get_BaseURI() { }

	// RVA: 0xFC6930
	public override bool get_IsEmptyElement() { }

	// RVA: 0xFC6958
	public override bool get_IsDefault() { }

	// RVA: 0xFC6980
	public override Char get_QuoteChar() { }

	// RVA: 0xFC69A8
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xFC69D0
	public override string get_XmlLang() { }

	// RVA: 0xFC69F8
	public override int get_AttributeCount() { }

	// RVA: 0xFC6A20
	public override string GetAttribute(string name) { }

	// RVA: 0xFC6A48
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xFC6A70
	public override string GetAttribute(int i) { }

	// RVA: 0xFC6A98
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xFC6AC0
	public override void MoveToAttribute(int i) { }

	// RVA: 0xFC6AE8
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xFC6B10
	public override bool MoveToNextAttribute() { }

	// RVA: 0xFC6B38
	public override bool MoveToElement() { }

	// RVA: 0xFC6B60
	public override bool ReadAttributeValue() { }

	// RVA: 0xFC6B88
	public override bool Read() { }

	// RVA: 0xFC6BB0
	public override bool get_EOF() { }

	// RVA: 0xFC6BD8
	public override void Close() { }

	// RVA: 0xFC6C00
	public override ReadState get_ReadState() { }

	// RVA: 0xFC6C28
	public override void Skip() { }

	// RVA: 0xFC6C50
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xFC6C78
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xFC6CA0
	public override bool get_CanResolveEntity() { }

	// RVA: 0xFC6CC8
	public override void ResolveEntity() { }

	// RVA: 0xFC6CF0
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xFC6D18
	public override string ReadString() { }

}

// Namespace: System.Data.SqlTypes
internal static class SQLResource
{
	// Methods

	// RVA: 0xFC6D40
	internal static string get_NullString() { }

	// RVA: 0xFC6D84
	internal static string get_ArithOverflowMessage() { }

	// RVA: 0xFC6DC8
	internal static string get_DivideByZeroMessage() { }

	// RVA: 0xFC6E0C
	internal static string get_NullValueMessage() { }

	// RVA: 0xFC6E50
	internal static string get_TruncationMessage() { }

	// RVA: 0xFC6E94
	internal static string get_DateTimeOverflowMessage() { }

	// RVA: 0xFC6ED8
	internal static string get_ConcatDiffCollationMessage() { }

	// RVA: 0xFC6F1C
	internal static string get_CompareDiffCollationMessage() { }

	// RVA: 0xFC6F60
	internal static string get_ConversionOverflowMessage() { }

	// RVA: 0xFC6FA4
	internal static string get_TimeZoneSpecifiedMessage() { }

	// RVA: 0xFC6FE8
	internal static string get_InvalidPrecScaleMessage() { }

	// RVA: 0xFC702C
	internal static string get_FormatMessage() { }

	// RVA: 0xFC7070
	internal static string InvalidOpStreamClosed(string method) { }

	// RVA: 0xFC70C8
	internal static string InvalidOpStreamNonWritable(string method) { }

	// RVA: 0xFC7120
	internal static string InvalidOpStreamNonReadable(string method) { }

	// RVA: 0xFC7178
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

	// RVA: 0xFC71D0
	private void .ctor(bool fNull) { }

	// RVA: 0xFC71DC
	public void .ctor(Byte[] value) { }

	// RVA: 0xFC7278
	public bool get_IsNull() { }

	// RVA: 0xFC7288
	public Byte[] get_Value() { }

	// RVA: 0xFC7378
	public static SqlBinary op_Implicit(Byte[] x) { }

	// RVA: 0xFC7420
	public override string ToString() { }

	// RVA: 0xFC7560
	private static EComparison PerformCompareByte(Byte[] x, Byte[] y) { }

	// RVA: 0xFC767C
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0xFC77AC
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xFC78C8
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xFC79E4
	public int CompareTo(object value) { }

	// RVA: 0xFC7B08
	public int CompareTo(SqlBinary value) { }

	// RVA: 0xFC7D94
	public override bool Equals(object value) { }

	// RVA: 0xFC7F90
	internal static int HashByteArray(Byte[] rgbValue, int length) { }

	// RVA: 0xFC7FF8
	public override int GetHashCode() { }

	// RVA: 0xFC813C
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFC8144
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFC8368
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFC84AC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFC853C
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

	// RVA: 0xFC7798
	public void .ctor(bool value) { }

	// RVA: 0xFC85B4
	public void .ctor(int value) { }

	// RVA: 0xFC8624
	private void .ctor(int value, bool fNull) { }

	// RVA: 0xFC8640
	public bool get_IsNull() { }

	// RVA: 0xFC7F2C
	public bool get_Value() { }

	// RVA: 0xFC8650
	public bool get_IsTrue() { }

	// RVA: 0xFC8660
	public bool get_IsFalse() { }

	// RVA: 0xFC8670
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0xFC7D2C
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0xFC8680
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFC877C
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFC8860
	public Byte get_ByteValue() { }

	// RVA: 0xFC8914
	public override string ToString() { }

	// RVA: 0xFC8A64
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFC8B4C
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFC8C88
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFC8DDC
	public int CompareTo(object value) { }

	// RVA: 0xFC8F00
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0xFC905C
	public override bool Equals(object value) { }

	// RVA: 0xFC91E8
	public override int GetHashCode() { }

	// RVA: 0xFC9310
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFC9318
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFC945C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFC9594
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFC9624
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

	// RVA: 0xFC9718
	private void .ctor(bool fNull) { }

	// RVA: 0xFC9720
	public void .ctor(Byte value) { }

	// RVA: 0xFC9730
	public bool get_IsNull() { }

	// RVA: 0xFC9740
	public Byte get_Value() { }

	// RVA: 0xFC97D8
	public static SqlByte op_Implicit(Byte x) { }

	// RVA: 0xFC97E4
	public override string ToString() { }

	// RVA: 0xFC987C
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0xFC99D0
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0xFC9B1C
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0xFC9C70
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0xFC9DB0
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0xFC9F70
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0xFCA088
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFCA1A0
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFCA2B8
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFCA344
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFCA3D0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFCA59C
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFCA70C
	public int CompareTo(object value) { }

	// RVA: 0xFCA830
	public int CompareTo(SqlByte value) { }

	// RVA: 0xFCA9DC
	public override bool Equals(object value) { }

	// RVA: 0xFCAB54
	public override int GetHashCode() { }

	// RVA: 0xFCAC48
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFCAC50
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFCAD90
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFCAED8
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFCAF68
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

	// RVA: 0xFCAFE4
	public void .ctor() { }

	// RVA: 0xFCB05C
	public void .ctor(Byte[] buffer) { }

	// RVA: 0xFCB0E0
	public void .ctor(SqlBinary value) { }

	// RVA: 0xFCB204
	public bool get_IsNull() { }

	// RVA: 0xFCB214
	public Byte[] get_Buffer() { }

	// RVA: 0xFCB3CC
	public Int64 get_Length() { }

	// RVA: 0xFCB448
	public Byte[] get_Value() { }

	// RVA: 0xFCB024
	public void SetNull() { }

	// RVA: 0xFCB258
	private void CopyStreamToBuffer() { }

	// RVA: 0xFCB248
	internal bool FStream() { }

	// RVA: 0xFCB670
	private void SetBuffer(Byte[] buffer) { }

	// RVA: 0xFCB6D4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFCB6DC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xFCB964
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFCBA98
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFCBB28
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFCBB68
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

	// RVA: 0xFCBC18
	public void .ctor() { }

	// RVA: 0xFCBC90
	public void .ctor(Char[] buffer) { }

	// RVA: 0xFCBD14
	public void .ctor(SqlString value) { }

	// RVA: 0xFCBEE0
	public bool get_IsNull() { }

	// RVA: 0xFCBEF0
	public Char[] get_Buffer() { }

	// RVA: 0xFCC0A0
	public Int64 get_Length() { }

	// RVA: 0xFCC11C
	public Char[] get_Value() { }

	// RVA: 0xFCBC58
	public void SetNull() { }

	// RVA: 0xFCBF24
	internal bool FStream() { }

	// RVA: 0xFCBF34
	private void CopyStreamToBuffer() { }

	// RVA: 0xFCC308
	private void SetBuffer(Char[] buffer) { }

	// RVA: 0xFCC36C
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFCC374
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xFCC4FC
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFCC60C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFCC69C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFCC6DC
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

	// RVA: 0xFCC78C
	private void .ctor(bool fNull) { }

	// RVA: 0xFCC798
	public void .ctor(DateTime value) { }

	// RVA: 0xFCC930
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0xFCCA84
	public bool get_IsNull() { }

	// RVA: 0xFCCA94
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0xFCCB40
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0xFCCC9C
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0xFCC808
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0xFCCF04
	public DateTime get_Value() { }

	// RVA: 0xFCCFB4
	public int get_DayTicks() { }

	// RVA: 0xFCD008
	public int get_TimeTicks() { }

	// RVA: 0xFCD05C
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0xFCD0C4
	public override string ToString() { }

	// RVA: 0xFCD1B8
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFCD2D0
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFCD3F4
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFCD518
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFCD598
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFCD618
	public int CompareTo(object value) { }

	// RVA: 0xFCD72C
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0xFCD8F4
	public override bool Equals(object value) { }

	// RVA: 0xFCDA84
	public override int GetHashCode() { }

	// RVA: 0xFCDB84
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFCDB8C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFCDDC0
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFCDF30
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFCDFC0
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

	// RVA: 0xFCE464
	private Byte CalculatePrecision() { }

	// RVA: 0xFCE6DC
	private bool VerifyPrecision(Byte precision) { }

	// RVA: 0xFCE960
	private void .ctor(bool fNull) { }

	// RVA: 0xFCE9D4
	public void .ctor(Decimal value) { }

	// RVA: 0xFCEBCC
	public void .ctor(int value) { }

	// RVA: 0xFCEEE8
	public void .ctor(Int64 value) { }

	// RVA: 0xFCF3E4
	private void .ctor(UInt32[] rglData, Byte bLen, Byte bPrec, Byte bScale, bool fPositive) { }

	// RVA: 0xFCF748
	public bool get_IsNull() { }

	// RVA: 0xFCF7C4
	public Decimal get_Value() { }

	// RVA: 0xFCFA30
	public bool get_IsPositive() { }

	// RVA: 0xFCF6D4
	private void SetPositive() { }

	// RVA: 0xFCFB78
	private void SetSignBit(bool fPositive) { }

	// RVA: 0xFCFC30
	public Byte get_Scale() { }

	// RVA: 0xFCFD50
	public int[] get_Data() { }

	// RVA: 0xFCFED8
	public override string ToString() { }

	// RVA: 0xFD0540
	public static SqlDecimal Parse(string s) { }

	// RVA: 0xFD10EC
	public Double ToDouble() { }

	// RVA: 0xFCF844
	private Decimal ToDecimal() { }

	// RVA: 0xFD12C0
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0xFD12D8
	public static SqlDecimal op_Implicit(Int64 x) { }

	// RVA: 0xFD1350
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0xFD15F0
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFD2358
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFD243C
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFD3020
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFD4028
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0xFD4110
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0xFD425C
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0xFD4418
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0xFD4510
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0xFD3FA8
	private static void ZeroToMaxLen(UInt32[] rgulData, int cUI4sCur) { }

	// RVA: 0xFCF6B4
	private bool FZero() { }

	// RVA: 0xFD22F0
	private bool FGt10_38() { }

	// RVA: 0xFD4750
	private bool FGt10_38(UInt32[] rglData) { }

	// RVA: 0xFCECD0
	private static Byte BGetPrecUI4(UInt32 value) { }

	// RVA: 0xFCEFD8
	private static Byte BGetPrecUI8(UInt64 dwlVal) { }

	// RVA: 0xFD0EAC
	private void AddULong(UInt32 ulAdd) { }

	// RVA: 0xFD0C0C
	private void MultByULong(UInt32 uiMultiplier) { }

	// RVA: 0xFD4830
	private UInt32 DivByULong(UInt32 iDivisor) { }

	// RVA: 0xFD1D84
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0xFD2168
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0xFD4A64
	private static void MpMove(UInt32[] rgulS, int ciulS, UInt32[] rgulD, int ciulD) { }

	// RVA: 0xFD4AD4
	private static void MpSet(UInt32[] rgulD, int ciulD, UInt32 iulN) { }

	// RVA: 0xFD4B04
	private static void MpNormalize(UInt32[] rgulU, int ciulU) { }

	// RVA: 0xFD4B58
	private static void MpMul1(UInt32[] piulD, int ciulD, UInt32 iulX) { }

	// RVA: 0xFD03FC
	private static void MpDiv1(UInt32[] rgulU, int ciulU, UInt32 iulD, UInt32 iulR) { }

	// RVA: 0xFD4C64
	internal static UInt64 DWL(UInt32 lo, UInt32 hi) { }

	// RVA: 0xFD4C58
	private static UInt32 HI(UInt64 x) { }

	// RVA: 0xFD4C60
	private static UInt32 LO(UInt64 x) { }

	// RVA: 0xFD35BC
	private static void MpDiv(UInt32[] rgulU, int ciulU, UInt32[] rgulD, int ciulD, UInt32[] rgulQ, int ciulQ, UInt32[] rgulR, int ciulR) { }

	// RVA: 0xFD4C70
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0xFCF5D4
	private static void CheckValidPrecScale(Byte bPrec, Byte bScale) { }

	// RVA: 0xFD5124
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFD533C
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFD5554
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFD576C
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFD5820
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFD58D4
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFD5AF8
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFD5DF4
	public SqlMoney ToSqlMoney() { }

	// RVA: 0xFD0534
	private static Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0xFD47D4
	private void StoreFromWorkingArray(UInt32[] rguiData) { }

	// RVA: 0xFD0B88
	private void SetToZero() { }

	// RVA: 0xFD6040
	public int CompareTo(object value) { }

	// RVA: 0xFD6174
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0xFD64C4
	public override bool Equals(object value) { }

	// RVA: 0xFD681C
	public override int GetHashCode() { }

	// RVA: 0xFD69C8
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFD69D0
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFD6B54
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFD6CF0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFD6D80
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

	// RVA: 0xFD713C
	private void .ctor(bool fNull) { }

	// RVA: 0xFD7148
	public void .ctor(Double value) { }

	// RVA: 0xFD71C0
	public bool get_IsNull() { }

	// RVA: 0xFD71D0
	public Double get_Value() { }

	// RVA: 0xFD7224
	public static SqlDouble op_Implicit(Double x) { }

	// RVA: 0xFD728C
	public override string ToString() { }

	// RVA: 0xFD7324
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0xFD743C
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFD75D8
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFD7774
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFD7910
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFCA458
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0xFD7AE4
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0xFD7C28
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0xFD7D64
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0xFD7EA4
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0xFD8040
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0xFD5960
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0xFD82A4
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFD83B8
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFD84CC
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFD85E0
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFD8660
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFD86E0
	public SqlSingle ToSqlSingle() { }

	// RVA: 0xFD8858
	public int CompareTo(object value) { }

	// RVA: 0xFD8968
	public int CompareTo(SqlDouble value) { }

	// RVA: 0xFD8B24
	public override bool Equals(object value) { }

	// RVA: 0xFD8CAC
	public override int GetHashCode() { }

	// RVA: 0xFD8D9C
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFD8DA4
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFD8EE4
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFD9038
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFD90C8
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

	// RVA: 0xFD915C
	private void .ctor(bool fNull) { }

	// RVA: 0xFD9168
	public void .ctor(Guid g) { }

	// RVA: 0xFD91AC
	public bool get_IsNull() { }

	// RVA: 0xFD91BC
	public Guid get_Value() { }

	// RVA: 0xFD9280
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0xFD92BC
	public override string ToString() { }

	// RVA: 0xFD9374
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFD951C
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFD9638
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFD9754
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFD9870
	public int CompareTo(object value) { }

	// RVA: 0xFD9994
	public int CompareTo(SqlGuid value) { }

	// RVA: 0xFD9B34
	public override bool Equals(object value) { }

	// RVA: 0xFD9C98
	public override int GetHashCode() { }

	// RVA: 0xFD9D58
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFD9D60
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFD9EBC
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFDA020
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFDA0B0
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

	// RVA: 0xFDA198
	private void .ctor(bool fNull) { }

	// RVA: 0xFDA1A4
	public void .ctor(Int16 value) { }

	// RVA: 0xFD41F8
	public bool get_IsNull() { }

	// RVA: 0xFD4208
	public Int16 get_Value() { }

	// RVA: 0xFDA1B4
	public static SqlInt16 op_Implicit(Int16 x) { }

	// RVA: 0xFDA1C0
	public override string ToString() { }

	// RVA: 0xFDA258
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0xFDA32C
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFDA480
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFDA5D4
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFDA76C
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFDA924
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0xFDAA14
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0xFDAB54
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFDAC68
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFDAD7C
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFDAE90
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFDAF1C
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFDAFA8
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFDB030
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFDB1A0
	public int CompareTo(object value) { }

	// RVA: 0xFDB2C4
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0xFDB470
	public override bool Equals(object value) { }

	// RVA: 0xFDB5E0
	public override int GetHashCode() { }

	// RVA: 0xFDB6D4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFDB6DC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFDB81C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFDB964
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFDB9F4
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

	// RVA: 0xFDBA74
	private void .ctor(bool fNull) { }

	// RVA: 0xFDBA80
	public void .ctor(int value) { }

	// RVA: 0xFD435C
	public bool get_IsNull() { }

	// RVA: 0xFD436C
	public int get_Value() { }

	// RVA: 0xFDBA90
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0xFDBA9C
	public override string ToString() { }

	// RVA: 0xFDBB34
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0xFDBC04
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFDBD88
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFDBF00
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFDC098
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFDC250
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0xFDC340
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0xFDC430
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0xFDBD7C
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0xFDC570
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFDC688
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFDC7A0
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFDC8B8
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFDC944
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFDC9D0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFDCA58
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFDCBC8
	public int CompareTo(object value) { }

	// RVA: 0xFDCCEC
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0xFDCE94
	public override bool Equals(object value) { }

	// RVA: 0xFDD004
	public override int GetHashCode() { }

	// RVA: 0xFDD0C4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFDD0CC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFDD20C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFDD354
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFDD3E4
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

	// RVA: 0xFDD464
	private void .ctor(bool fNull) { }

	// RVA: 0xFDD470
	public void .ctor(Int64 value) { }

	// RVA: 0xFC9F0C
	public bool get_IsNull() { }

	// RVA: 0xFC9F1C
	public Int64 get_Value() { }

	// RVA: 0xFDD480
	public static SqlInt64 op_Implicit(Int64 x) { }

	// RVA: 0xFDD48C
	public override string ToString() { }

	// RVA: 0xFDD524
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0xFDD5EC
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFDD764
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFDD8CC
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFDDA70
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFDDC00
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFCA624
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0xFDB0B8
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0xFDCAE0
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0xFD5B84
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0xFDD754
	private static bool SameSignLong(Int64 x, Int64 y) { }

	// RVA: 0xFDDD94
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFDDEA0
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFDDFAC
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFDE0B8
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFDE138
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFDE1B8
	public SqlByte ToSqlByte() { }

	// RVA: 0xFDE248
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFDE2D8
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0xFDE368
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0xFDE3F8
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0xFDE484
	public int CompareTo(object value) { }

	// RVA: 0xFDE594
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0xFDE750
	public override bool Equals(object value) { }

	// RVA: 0xFDE8D8
	public override int GetHashCode() { }

	// RVA: 0xFDE9CC
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFDE9D4
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFDEB14
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFDEC5C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFDECEC
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

	// RVA: 0xFDED88
	private void .ctor(bool fNull) { }

	// RVA: 0xFDED94
	internal void .ctor(Int64 value, int ignored) { }

	// RVA: 0xFDEDA4
	public void .ctor(int value) { }

	// RVA: 0xFDEE24
	public void .ctor(Int64 value) { }

	// RVA: 0xFDEF44
	public void .ctor(Decimal value) { }

	// RVA: 0xFD461C
	public bool get_IsNull() { }

	// RVA: 0xFDF0BC
	public Decimal get_Value() { }

	// RVA: 0xFD462C
	public Decimal ToDecimal() { }

	// RVA: 0xFD8208
	public Double ToDouble() { }

	// RVA: 0xFDF15C
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0xFDF18C
	public static SqlMoney op_Implicit(Int64 x) { }

	// RVA: 0xFDF1F8
	public override string ToString() { }

	// RVA: 0xFDF33C
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0xFDF46C
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFDF648
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFDF824
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFDF994
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFDFB04
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0xFDFC54
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0xFDFDA8
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0xFDFF04
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0xFD5E80
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0xFDFFF8
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFE0104
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFE0210
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFE031C
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFE039C
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFE041C
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFE04AC
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0xFE0538
	public int CompareTo(object value) { }

	// RVA: 0xFE0648
	public int CompareTo(SqlMoney value) { }

	// RVA: 0xFE0804
	public override bool Equals(object value) { }

	// RVA: 0xFE098C
	public override int GetHashCode() { }

	// RVA: 0xFE0A20
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFE0A28
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFE0BC4
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFE0D2C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFE0DBC
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

	// RVA: 0xFE0EA0
	private void .ctor(bool fNull) { }

	// RVA: 0xFE0EAC
	public void .ctor(float value) { }

	// RVA: 0xFE0F24
	public void .ctor(Double value) { }

	// RVA: 0xFD7FDC
	public bool get_IsNull() { }

	// RVA: 0xFD7FEC
	public float get_Value() { }

	// RVA: 0xFE1010
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0xFE107C
	public override string ToString() { }

	// RVA: 0xFE1114
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0xFE121C
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFE13B4
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFE154C
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFE16E4
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFE18B4
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0xFE19E8
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0xFE1B1C
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0xFE1C60
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0xFE1D90
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0xFE1F14
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0xFD8770
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0xFE2074
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFE2194
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFE22B4
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFE23D4
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFE2460
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFE24EC
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFE2574
	public int CompareTo(object value) { }

	// RVA: 0xFE2698
	public int CompareTo(SqlSingle value) { }

	// RVA: 0xFE2840
	public override bool Equals(object value) { }

	// RVA: 0xFE29B0
	public override int GetHashCode() { }

	// RVA: 0xFE2AA4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFE2AAC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFE2BEC
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFE2D40
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFE2DD0
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

	// RVA: 0xFE2E50
	private void .ctor(bool fNull) { }

	// RVA: 0xFE2E90
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0xFE3030
	public void .ctor(string data) { }

	// RVA: 0xFE3104
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0xFCBE24
	public bool get_IsNull() { }

	// RVA: 0xFCBE34
	public string get_Value() { }

	// RVA: 0xFE3214
	private void SetCompareInfo() { }

	// RVA: 0xFE32B0
	public static SqlString op_Implicit(string x) { }

	// RVA: 0xFE32C4
	public override string ToString() { }

	// RVA: 0xFE3354
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0xFE34D4
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0xFE3CA8
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0xFE3E48
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0xFE2F5C
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xFE3BD8
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xFE3EE0
	private bool FBinarySort() { }

	// RVA: 0xFE3800
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0xFE3A14
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0xFE3F78
	public int CompareTo(object value) { }

	// RVA: 0xFE409C
	public int CompareTo(SqlString value) { }

	// RVA: 0xFE41E4
	public override bool Equals(object value) { }

	// RVA: 0xFE43EC
	public override int GetHashCode() { }

	// RVA: 0xFE4708
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFE4710
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFE483C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFE4950
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFE49E0
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

	// RVA: 0xFE4AF0
	public void .ctor() { }

	// RVA: 0xFCB63C
	public void .ctor(string message) { }

	// RVA: 0xFE4B5C
	public void .ctor(string message, Exception e) { }

	// RVA: 0xFE4B8C
	protected void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xFE4BE0
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlNullValueException
{
	// Methods

	// RVA: 0xFC9794
	public void .ctor() { }

	// RVA: 0xFE4CEC
	public void .ctor(string message) { }

	// RVA: 0xFE4CBC
	public void .ctor(string message, Exception e) { }

	// RVA: 0xFE4D20
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xFE4D84
	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlTruncateException
{
	// Methods

	// RVA: 0xFD4A20
	public void .ctor() { }

	// RVA: 0xFE4E90
	public void .ctor(string message) { }

	// RVA: 0xFE4E60
	public void .ctor(string message, Exception e) { }

	// RVA: 0xFE4EC4
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xFE4F28
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

	// RVA: 0xFE5004
	public void .ctor() { }

	// RVA: 0xFE507C
	public XmlReader CreateReader() { }

	// RVA: 0xFE5434
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput, bool throwTargetInvocationExceptions) { }

	// RVA: 0xFE561C
	private static System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0xFE52CC
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0xFE5238
	public bool get_IsNull() { }

	// RVA: 0xFE5044
	private void SetNull() { }

	// RVA: 0xFE5744
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFE574C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xFE5958
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFE5ACC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFE5B5C
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

	// RVA: 0xFE5248
	internal void .ctor(Stream stream) { }

	// RVA: 0xFE5C60
	public override bool get_CanRead() { }

	// RVA: 0xFE5D74
	public override bool get_CanSeek() { }

	// RVA: 0xFE5E04
	public override bool get_CanWrite() { }

	// RVA: 0xFE5E94
	public override Int64 get_Length() { }

	// RVA: 0xFE6048
	public override Int64 get_Position() { }

	// RVA: 0xFE60B0
	public override void set_Position(Int64 value) { }

	// RVA: 0xFE6188
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFE6310
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xFE6560
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xFE67B0
	public override int ReadByte() { }

	// RVA: 0xFE68DC
	public override void WriteByte(Byte value) { }

	// RVA: 0xFE69C4
	public override void Flush() { }

	// RVA: 0xFE69E0
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFE5FC8
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0xFE64E0
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0xFE6730
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0xFE5F0C
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0xFE5CF0
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

	// RVA: 0xFEA794
	private void .ctor() { }

	// RVA: 0xFEA79C
	public bool Equals(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> y) { }

	// RVA: 0xFEB014
	public int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> obj) { }

	// RVA: 0xFEB1A8
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

	// RVA: 0xFE69F0
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0xFE6BC4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE6BFC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE72E8
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xFE7504
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0xFE6DE4
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0xFE77E4
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE7868
	public override object Get(int recordNo) { }

	// RVA: 0xFE76A4
	private Families GetFamily(Type dataType) { }

	// RVA: 0xFE78B4
	public override bool IsNull(int record) { }

	// RVA: 0xFE78F0
	public override void Set(int recordNo, object value) { }

	// RVA: 0xFE8190
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE8254
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE8898
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFE9A14
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE9F50
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFEA0C0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFEA114
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFEA350
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFEA568
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0xFE87F4
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0xFE8FD4
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0xFEA6BC
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

	// RVA: 0xFEB214
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0xFEB2BC
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0xFEB3D8
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0xFEB4F4
	internal static ArgumentException Argument(string error) { }

	// RVA: 0xFEB588
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0xFEB61C
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0xFEB6C0
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0xFEB754
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0xFEB7E8
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0xFEBAC0
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0xFEBD30
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0xFEBEBC
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0xFEBFD4
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0xFEC09C
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0xFEC164
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0xFEC22C
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0xFEC368
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class BigIntegerStorage
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0xFEC6D4
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFEC948
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFEC980
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFECB58
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFECCEC
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0xFED4D0
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xFEDC68
	public override object ConvertValue(object value) { }

	// RVA: 0xFEDD44
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFEDE14
	public override object Get(int record) { }

	// RVA: 0xFEDF58
	public override void Set(int record, object value) { }

	// RVA: 0xFEE0FC
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFEE2D4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFEE3B8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFEE4AC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFEE500
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFEE620
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class BooleanStorage
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0xFEE6F0
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFEE858
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFEEC08
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFEED10
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFEEE4C
	public override object ConvertValue(object value) { }

	// RVA: 0xFEEFB0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFEF034
	public override object Get(int record) { }

	// RVA: 0xFEF100
	public override void Set(int record, object value) { }

	// RVA: 0xFEF2A4
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFEF3E8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFEF47C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFEF530
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFEF584
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFEF688
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class ByteStorage
{
	// Fields
	private Byte[] _values; // 0x50

	// Methods

	// RVA: 0xFEF758
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFEF8C0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF00E4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF01A8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF02D0
	public override object ConvertValue(object value) { }

	// RVA: 0xFF0434
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF04B8
	public override object Get(int record) { }

	// RVA: 0xFF0584
	public override void Set(int record, object value) { }

	// RVA: 0xFF0728
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF086C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF0900
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF09B4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF0A08
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF0B0C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class CharStorage
{
	// Fields
	private Char[] _values; // 0x50

	// Methods

	// RVA: 0xFF0BDC
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFF0D44
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF10D8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF11DC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF1318
	public override object ConvertValue(object value) { }

	// RVA: 0xFF147C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF1500
	public override object Get(int record) { }

	// RVA: 0xFF15CC
	public override void Set(int record, object value) { }

	// RVA: 0xFF17BC
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF1900
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF1994
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF1A48
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF1A9C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF1BA0
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

	// RVA: 0xFEC8A8
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0xFF1DF0
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0xFF1C70
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0xFF1E58
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0xFEDD24
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xFEEBF4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0xFF1E78
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0xFECAEC
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract int Compare(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xFF1F3C
	public virtual object ConvertValue(object value) { }

	// RVA: 0xFEDDD0
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1
	public abstract void Copy(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract object Get(int recordNo) { }

	// RVA: 0xFEDF14
	protected object GetBits(int recordNo) { }

	// RVA: 0xFF1F44
	public virtual int GetStringLength(int record) { }

	// RVA: 0xFECCC4
	protected bool HasValue(int recordNo) { }

	// RVA: 0xFF1F4C
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1
	public abstract void Set(int recordNo, object value) { }

	// RVA: 0xFEE0DC
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0xFEE240
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1
	public abstract object ConvertXmlToObject(string s) { }

	// RVA: 0xFF1F6C
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1
	public abstract string ConvertObjectToXml(object value) { }

	// RVA: 0xFF1FB8
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFF2000
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0xFF3C4C
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0xFF3D7C
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0xFF3E1C
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0xFF1DFC
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0xFF3E98
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0xFF3EA4
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0xFF1E18
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0xFF3FB4
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, bool sqlType, bool nullable, bool xmlSerializable, bool changeTracking, bool revertibleChangeTracking) { }

	// RVA: 0xFF4230
	private static System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0xFF4418
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0xFF44F8
	public static bool IsObjectNull(object value) { }

	// RVA: 0xFF468C
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0xFF4764
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0xFF4774
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF4784
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1
	protected abstract object GetEmptyStorage(int recordCount) { }

	// RVA: -1
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: -1
	protected abstract void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFF4794
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0xFF479C
	internal static Type GetType(string value) { }

	// RVA: 0xFF48E4
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0xFF4980
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0xFF33E4
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFF58BC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF5DD8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF5FB0
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF6168
	public override object ConvertValue(object value) { }

	// RVA: 0xFF622C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF62B0
	public override object Get(int record) { }

	// RVA: 0xFF63E0
	public override void Set(int record, object value) { }

	// RVA: 0xFF6514
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF6658
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF66EC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF67A4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF67F8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF690C
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFF69DC
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeStorage
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0xFF324C
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFF6A58
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF6F54
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF7150
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF7300
	public override object ConvertValue(object value) { }

	// RVA: 0xFF7464
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF74E8
	public override object Get(int record) { }

	// RVA: 0xFF7630
	public override void Set(int record, object value) { }

	// RVA: 0xFF7A10
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF7B54
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF7C1C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF7D18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF7D6C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF7EE8
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFF811C
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DecimalStorage
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0xFF3090
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFF8198
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF8CCC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF8E84
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF9014
	public override object ConvertValue(object value) { }

	// RVA: 0xFF9198
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF921C
	public override object Get(int record) { }

	// RVA: 0xFF92F4
	public override void Set(int record, object value) { }

	// RVA: 0xFF94B8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF95FC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF96BC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF9774
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF97C8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF98DC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class DoubleStorage
{
	// Fields
	private Double[] _values; // 0x50

	// Methods

	// RVA: 0xFF2F28
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFF99AC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFFA130
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFA200
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFA32C
	public override object ConvertValue(object value) { }

	// RVA: 0xFFA490
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFA514
	public override object Get(int record) { }

	// RVA: 0xFFA5E4
	public override void Set(int record, object value) { }

	// RVA: 0xFFA788
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFA8CC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFA960
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFAA14
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFAA68
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFAB74
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int16Storage
{
	// Fields
	private Int16[] _values; // 0x50

	// Methods

	// RVA: 0xFF2AF0
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFFAC44
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFFB4B0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFB568
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFB690
	public override object ConvertValue(object value) { }

	// RVA: 0xFFB7F4
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFB878
	public override object Get(int record) { }

	// RVA: 0xFFB944
	public override void Set(int record, object value) { }

	// RVA: 0xFFBAE8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFBC2C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFBCC0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFBD74
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFBDC8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFBECC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int32Storage
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0xFF2C58
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFFBF9C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFFC7FC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFC8D0
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFC9F8
	public override object ConvertValue(object value) { }

	// RVA: 0xFFCB5C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFCBE0
	public override object Get(int record) { }

	// RVA: 0xFFCCAC
	public override void Set(int record, object value) { }

	// RVA: 0xFFCE50
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFCF94
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFD028
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFD0DC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFD130
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFD234
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int64Storage
{
	// Fields
	private Int64[] _values; // 0x50

	// Methods

	// RVA: 0xFF2DC0
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFFD304
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFFDBA4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFDC78
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFDDA0
	public override object ConvertValue(object value) { }

	// RVA: 0xFFDF04
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFDF88
	public override object Get(int record) { }

	// RVA: 0xFFE054
	public override void Set(int record, object value) { }

	// RVA: 0xFFE1F8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFE33C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFE3D0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFE484
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFE4D8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFE5DC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SByteStorage
{
	// Fields
	private SByte[] _values; // 0x50

	// Methods

	// RVA: 0xFF2988
	public void .ctor(DataColumn column) { }

	// RVA: 0xFFE6AC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFFEEEC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFEFD8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFF100
	public override object ConvertValue(object value) { }

	// RVA: 0xFFF264
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFF2E8
	public override object Get(int record) { }

	// RVA: 0xFFF3CC
	public override void Set(int record, object value) { }

	// RVA: 0xFFF570
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFF6B4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFF748
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFF7FC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFF850
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFF954
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal static class SqlConvert
{
	// Methods

	// RVA: 0xFFFA24
	public static SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0xFFFC5C
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0xFFFF74
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0x10003CC
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0x1000924
	public static SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0x1001090
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0x10016F8
	public static SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0x1001DF8
	public static SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0x1002488
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0x10026C4
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0x10028E8
	public static SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0x1002B28
	public static SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0x1002D5C
	public static SqlString ConvertToSqlString(object value) { }

	// RVA: 0x1002F64
	public static SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0x10030D4
	public static SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0x1003244
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0x10032B0
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x100349C
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1004570
	public static object ChangeTypeForXML(object value, Type type) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0xFF357C
	public void .ctor(DataColumn column) { }

	// RVA: 0x1006368
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10065C4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1006668
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1006728
	public override object ConvertValue(object value) { }

	// RVA: 0x10067B4
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10067FC
	public override object Get(int record) { }

	// RVA: 0x1006888
	public override bool IsNull(int record) { }

	// RVA: 0x1006910
	public override void Set(int record, object value) { }

	// RVA: 0x1006960
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1006A24
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1006CD0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1006F38
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1006F8C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1007098
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlByteStorage
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0xFF36B4
	public void .ctor(DataColumn column) { }

	// RVA: 0x1007148
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1007F84
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1008028
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x10080E8
	public override object ConvertValue(object value) { }

	// RVA: 0x1008174
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10081B4
	public override object Get(int record) { }

	// RVA: 0x1008240
	public override bool IsNull(int record) { }

	// RVA: 0x10082C8
	public override void Set(int record, object value) { }

	// RVA: 0x1008310
	public override void SetCapacity(int capacity) { }

	// RVA: 0x10083D4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1008680
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10088E8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x100893C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1008A40
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBytesStorage
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0xFF37EC
	public void .ctor(DataColumn column) { }

	// RVA: 0x1008AF0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1008D24
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1008D2C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1008D34
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1008D78
	public override object Get(int record) { }

	// RVA: 0x1008DAC
	public override bool IsNull(int record) { }

	// RVA: 0x1008DE8
	public override void Set(int record, object value) { }

	// RVA: 0x1008F14
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1008FD8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10092A8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1009510
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1009564
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1009670
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlCharsStorage
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0xFF38D4
	public void .ctor(DataColumn column) { }

	// RVA: 0x1009720
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1009954
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x100995C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1009964
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10099A8
	public override object Get(int record) { }

	// RVA: 0x10099DC
	public override bool IsNull(int record) { }

	// RVA: 0x1009A18
	public override void Set(int record, object value) { }

	// RVA: 0x1009B44
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1009C08
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1009EE4
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x100A14C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x100A1A0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x100A2AC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0xFF39BC
	public void .ctor(DataColumn column) { }

	// RVA: 0x100A35C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x100A978
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x100AA2C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x100AAF4
	public override object ConvertValue(object value) { }

	// RVA: 0x100AB84
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x100ABD8
	public override object Get(int record) { }

	// RVA: 0x100AC70
	public override bool IsNull(int record) { }

	// RVA: 0x100ACFC
	public override void Set(int record, object value) { }

	// RVA: 0x100AD4C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x100AE10
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x100B0C8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x100B330
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x100B384
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x100B4A0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0xFF3B04
	public void .ctor(DataColumn column) { }

	// RVA: 0x100B550
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x100C46C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x100C540
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x100C620
	public override object ConvertValue(object value) { }

	// RVA: 0x100C6AC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x100C700
	public override object Get(int record) { }

	// RVA: 0x100C7A0
	public override bool IsNull(int record) { }

	// RVA: 0x100C82C
	public override void Set(int record, object value) { }

	// RVA: 0x100C890
	public override void SetCapacity(int capacity) { }

	// RVA: 0x100C954
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x100CC0C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x100CE74
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x100CEC8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x100CFF4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x100D0A4
	public void .ctor(DataColumn column) { }

	// RVA: 0x100D1DC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x100DEF4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x100DF9C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x100E05C
	public override object ConvertValue(object value) { }

	// RVA: 0x100E0EC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x100E12C
	public override object Get(int record) { }

	// RVA: 0x100E1B8
	public override bool IsNull(int record) { }

	// RVA: 0x100E240
	public override void Set(int record, object value) { }

	// RVA: 0x100E28C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x100E350
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x100E5FC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x100E860
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x100E8B4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x100E9C8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlGuidStorage
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x100EA78
	public void .ctor(DataColumn column) { }

	// RVA: 0x100EBB0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x100EE0C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x100EEB0
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x100EF70
	public override object ConvertValue(object value) { }

	// RVA: 0x100F000
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x100F048
	public override object Get(int record) { }

	// RVA: 0x100F0D4
	public override bool IsNull(int record) { }

	// RVA: 0x100F15C
	public override void Set(int record, object value) { }

	// RVA: 0x100F1B0
	public override void SetCapacity(int capacity) { }

	// RVA: 0x100F274
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x100F520
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x100F784
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x100F7D8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x100F8E4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt16Storage
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x100F994
	public void .ctor(DataColumn column) { }

	// RVA: 0x100FACC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1010908
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x10109AC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1010A6C
	public override object ConvertValue(object value) { }

	// RVA: 0x1010AFC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1010B3C
	public override object Get(int record) { }

	// RVA: 0x1010BC8
	public override bool IsNull(int record) { }

	// RVA: 0x1010C50
	public override void Set(int record, object value) { }

	// RVA: 0x1010C9C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1010D60
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x101100C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1011270
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10112C4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10113C8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt32Storage
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x1011478
	public void .ctor(DataColumn column) { }

	// RVA: 0x10115B0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10123BC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1012460
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1012520
	public override object ConvertValue(object value) { }

	// RVA: 0x10125B0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10125F0
	public override object Get(int record) { }

	// RVA: 0x101267C
	public override bool IsNull(int record) { }

	// RVA: 0x1012704
	public override void Set(int record, object value) { }

	// RVA: 0x1012750
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1012814
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1012AC0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1012D24
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1012D78
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1012E7C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt64Storage
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x1012F2C
	public void .ctor(DataColumn column) { }

	// RVA: 0x1013064
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1013F64
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x101400C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x10140CC
	public override object ConvertValue(object value) { }

	// RVA: 0x101415C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x101419C
	public override object Get(int record) { }

	// RVA: 0x1014228
	public override bool IsNull(int record) { }

	// RVA: 0x10142B0
	public override void Set(int record, object value) { }

	// RVA: 0x10142FC
	public override void SetCapacity(int capacity) { }

	// RVA: 0x10143C0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x101466C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10148D0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1014924
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1014A38
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x1014AE8
	public void .ctor(DataColumn column) { }

	// RVA: 0x1014C20
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1015B20
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1015BC8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1015C88
	public override object ConvertValue(object value) { }

	// RVA: 0x1015D18
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1015D58
	public override object Get(int record) { }

	// RVA: 0x1015DE4
	public override bool IsNull(int record) { }

	// RVA: 0x1015E6C
	public override void Set(int record, object value) { }

	// RVA: 0x1015EB8
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1015F7C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1016228
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x101648C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10164E0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10165F4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlSingleStorage
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x10166A4
	public void .ctor(DataColumn column) { }

	// RVA: 0x10167DC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10175B8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x101765C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x101771C
	public override object ConvertValue(object value) { }

	// RVA: 0x10177AC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10177EC
	public override object Get(int record) { }

	// RVA: 0x1017878
	public override bool IsNull(int record) { }

	// RVA: 0x1017900
	public override void Set(int record, object value) { }

	// RVA: 0x101794C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1017A10
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1017CBC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1017F20
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1017F74
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1018078
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlStringStorage
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x1018128
	public void .ctor(DataColumn column) { }

	// RVA: 0x101826C
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1018694
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1018704
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x10188C0
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1018988
	public override object ConvertValue(object value) { }

	// RVA: 0x1018A20
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1018A74
	public override object Get(int record) { }

	// RVA: 0x1018B08
	public override int GetStringLength(int record) { }

	// RVA: 0x1018BF8
	public override bool IsNull(int record) { }

	// RVA: 0x1018C84
	public override void Set(int record, object value) { }

	// RVA: 0x1018CF0
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1018DB4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1019064
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10192C8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x101931C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1019444
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x10194F4
	public void .ctor(DataColumn column) { }

	// RVA: 0x101962C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1019AB4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1019B58
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1019C18
	public override object ConvertValue(object value) { }

	// RVA: 0x1019CA8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1019CE8
	public override object Get(int record) { }

	// RVA: 0x1019D74
	public override bool IsNull(int record) { }

	// RVA: 0x1019DFC
	public override void Set(int record, object value) { }

	// RVA: 0x1019E48
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1019F0C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x101A1B8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x101A41C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x101A470
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x101A574
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SingleStorage
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x101A624
	public void .ctor(DataColumn column) { }

	// RVA: 0x101A724
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x101AE40
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x101AED4
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x101B000
	public override object ConvertValue(object value) { }

	// RVA: 0x101B15C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x101B1C0
	public override object Get(int record) { }

	// RVA: 0x101B274
	public override void Set(int record, object value) { }

	// RVA: 0x101B40C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x101B4EC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x101B580
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x101B634
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x101B688
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x101B794
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x101BBC8
	public void .ctor() { }

	// RVA: 0x101D048
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

	// RVA: 0x101B864
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x101BA1C
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x101B8E8
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x101BBD0
	public override bool IsNull(int record) { }

	// RVA: 0x101BCF4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x101BD2C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x101BD68
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x101C028
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x101C0BC
	public override object Get(int recordNo) { }

	// RVA: 0x101C0F0
	public override void Set(int recordNo, object value) { }

	// RVA: 0x101C284
	public override void SetCapacity(int capacity) { }

	// RVA: 0x101C364
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x101C674
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x101C920
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x101CBFC
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x101CD64
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x101CDB8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x101CEFC
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x101CFAC
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class StringStorage
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x101D180
	public void .ctor(DataColumn column) { }

	// RVA: 0x101D26C
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x101D558
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x101D5DC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x101D6C0
	public override object ConvertValue(object value) { }

	// RVA: 0x101D6F0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x101D734
	public override object Get(int recordNo) { }

	// RVA: 0x101D780
	public override int GetStringLength(int record) { }

	// RVA: 0x101D7C8
	public override bool IsNull(int record) { }

	// RVA: 0x101D804
	public override void Set(int record, object value) { }

	// RVA: 0x101D890
	public override void SetCapacity(int capacity) { }

	// RVA: 0x101D954
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x101D95C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x101D9C0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x101DA14
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x101DB20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class TimeSpanStorage
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x101DBD0
	public void .ctor(DataColumn column) { }

	// RVA: 0x101DD00
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x101E8EC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x101EABC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x101EC84
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x101EEB4
	public override object ConvertValue(object value) { }

	// RVA: 0x101EF7C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x101EFE0
	public override object Get(int record) { }

	// RVA: 0x101F114
	public override void Set(int record, object value) { }

	// RVA: 0x101F1F4
	public override void SetCapacity(int capacity) { }

	// RVA: 0x101F2D4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x101F368
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x101F41C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x101F470
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x101F574
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x101F644
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class UInt16Storage
{
	// Fields
	private static readonly UInt16 s_defaultValue; // 0x0
	private UInt16[] _values; // 0x50

	// Methods

	// RVA: 0x101F6C0
	public void .ctor(DataColumn column) { }

	// RVA: 0x101F7E8
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1020008
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x10200DC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x102021C
	public override object ConvertValue(object value) { }

	// RVA: 0x1020378
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10203DC
	public override object Get(int record) { }

	// RVA: 0x10204C4
	public override void Set(int record, object value) { }

	// RVA: 0x102067C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x102075C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10207F0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10208A4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10208F8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10209F8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt32Storage
{
	// Fields
	private static readonly UInt32 s_defaultValue; // 0x0
	private UInt32[] _values; // 0x50

	// Methods

	// RVA: 0x1020AC8
	public void .ctor(DataColumn column) { }

	// RVA: 0x1020BF0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1021414
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x102150C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x102164C
	public override object ConvertValue(object value) { }

	// RVA: 0x10217A8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x102180C
	public override object Get(int record) { }

	// RVA: 0x10218F4
	public override void Set(int record, object value) { }

	// RVA: 0x1021AAC
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1021B8C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1021C20
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1021CD4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1021D28
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1021E28
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt64Storage
{
	// Fields
	private static readonly UInt64 s_defaultValue; // 0x0
	private UInt64[] _values; // 0x50

	// Methods

	// RVA: 0x1021EF8
	public void .ctor(DataColumn column) { }

	// RVA: 0x1022020
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1022840
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1022950
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1022A90
	public override object ConvertValue(object value) { }

	// RVA: 0x1022BEC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1022C50
	public override object Get(int record) { }

	// RVA: 0x1022D38
	public override void Set(int record, object value) { }

	// RVA: 0x1022EF0
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1022FD0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1023064
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1023118
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x102316C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x102326C
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


