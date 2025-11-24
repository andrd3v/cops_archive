// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xF06538
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xF06540
	public void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xF065CC
	public void .ctor(Byte ) { }

}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0xF065F8
	internal static string GetString(string name) { }

	// RVA: 0xF065FC
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0xF06670
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0xF066F4
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }

}

// Namespace: System
internal static class LocalAppContextSwitches
{
	// Fields
	private static int s_allowArbitraryTypeInstantiation; // 0x0

	// Methods

	// RVA: 0xF06780
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

	// RVA: 0xF06B50
	private static void .cctor() { }

	// RVA: 0xF06BBC
	public void .ctor() { }

	// RVA: 0xF06BC4
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

	// RVA: 0xF0689C
	internal static bool GetCachedSwitchValue(string switchName, int switchValue) { }

	// RVA: 0xF06978
	private static bool GetCachedSwitchValueInternal(string switchName, int switchValue) { }

	// RVA: 0xF06A18
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

	// RVA: 0xF06C48
	public void .ctor() { }

	// RVA: 0xF07068
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0xF06CDC
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0xF0727C
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0xF07D54
	public bool get_AllowDBNull() { }

	// RVA: 0xF07D5C
	public void set_AllowDBNull(bool value) { }

	// RVA: 0xF08324
	public bool get_AutoIncrement() { }

	// RVA: 0xF08344
	public void set_AutoIncrement(bool value) { }

	// RVA: 0xF0953C
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0xF095D0
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0xF093B0
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0xF095B8
	public Int64 get_AutoIncrementSeed() { }

	// RVA: 0xF098B0
	public void set_AutoIncrementSeed(Int64 value) { }

	// RVA: 0xF099C8
	public Int64 get_AutoIncrementStep() { }

	// RVA: 0xF099E4
	public void set_AutoIncrementStep(Int64 value) { }

	// RVA: 0xF09B1C
	public string get_Caption() { }

	// RVA: 0xF09B38
	public void set_Caption(string value) { }

	// RVA: 0xF09CE0
	public string get_ColumnName() { }

	// RVA: 0xF09CE8
	public void set_ColumnName(string value) { }

	// RVA: 0xF0A2C4
	internal string get_EncodedColumnName() { }

	// RVA: 0xF0979C
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xF09C60
	internal CultureInfo get_Locale() { }

	// RVA: 0xF0A360
	internal int get_ObjectID() { }

	// RVA: 0xF0A368
	public string get_Prefix() { }

	// RVA: 0xF0A370
	public void set_Prefix(string value) { }

	// RVA: 0xF0A634
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0xF0A7E8
	internal bool get_Computed() { }

	// RVA: 0xF0A7F8
	internal DataExpression get_DataExpression() { }

	// RVA: 0xF0A800
	public Type get_DataType() { }

	// RVA: 0xF08A40
	public void set_DataType(Type value) { }

	// RVA: 0xF0B43C
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0xF0B444
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0xF0AB48
	public object get_DefaultValue() { }

	// RVA: 0xF0AD10
	public void set_DefaultValue(object value) { }

	// RVA: 0xF0B998
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0xF0B9A0
	internal void BindExpression() { }

	// RVA: 0xF0B9C8
	public string get_Expression() { }

	// RVA: 0xF073B4
	public void set_Expression(string value) { }

	// RVA: 0xF0C170
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF08920
	internal bool get_HasData() { }

	// RVA: 0xF0C1FC
	internal bool get_ImplementsINullable() { }

	// RVA: 0xF0C204
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0xF0C20C
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0xF0C214
	internal bool get_IsValueType() { }

	// RVA: 0xF0C234
	internal bool get_IsSqlType() { }

	// RVA: 0xF0C23C
	private void SetMaxLengthSimpleType() { }

	// RVA: 0xF0C328
	public int get_MaxLength() { }

	// RVA: 0xF0C330
	public void set_MaxLength(int value) { }

	// RVA: 0xF0CD3C
	public string get_Namespace() { }

	// RVA: 0xF0CDC4
	public void set_Namespace(string value) { }

	// RVA: 0xF0D12C
	public int get_Ordinal() { }

	// RVA: 0xF0D134
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0xF0D288
	public bool get_ReadOnly() { }

	// RVA: 0xF0BBD4
	public void set_ReadOnly(bool value) { }

	// RVA: 0xF0D32C
	private Index get_SortIndex() { }

	// RVA: 0xF0D430
	public DataTable get_Table() { }

	// RVA: 0xF0D438
	internal void SetTable(DataTable table) { }

	// RVA: 0xF0D51C
	private DataRow GetDataRow(int index) { }

	// RVA: 0xF0A708
	internal object get_Item(int record) { }

	// RVA: 0xF0D544
	internal void set_Item(int record, object value) { }

	// RVA: 0xF0C040
	internal void InitializeRecord(int record) { }

	// RVA: 0xF0D85C
	internal void SetValue(int record, object value) { }

	// RVA: 0xF0D990
	internal void FreeRecord(int record) { }

	// RVA: 0xF0D9B8
	public bool get_Unique() { }

	// RVA: 0xF0D9C0
	public void set_Unique(bool value) { }

	// RVA: 0xF0DF8C
	internal void InternalUnique(bool value) { }

	// RVA: 0xF0DF94
	internal string get_XmlDataType() { }

	// RVA: 0xF0DF9C
	internal void set_XmlDataType(string value) { }

	// RVA: 0xF0DFA4
	internal SimpleType get_SimpleType() { }

	// RVA: 0xF0721C
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0xF0DFAC
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0xF0DFB4
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0xF0E570
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xF0C890
	internal bool CheckMaxLength() { }

	// RVA: 0xF0E644
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0xF07EFC
	protected internal void CheckNotAllowNull() { }

	// RVA: 0xF0E5C8
	internal void CheckNullable(DataRow row) { }

	// RVA: 0xF0DF34
	protected void CheckUnique() { }

	// RVA: 0xF0EB2C
	internal int Compare(int record1, int record2) { }

	// RVA: 0xF0EB50
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0xF0ED54
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0xF0ED78
	internal object ConvertValue(object value) { }

	// RVA: 0xF0ED9C
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0xF0EDC0
	internal DataColumn Clone() { }

	// RVA: 0xF0F4DC
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0xF0E6C0
	private int GetStringLength(int record) { }

	// RVA: 0xF0F5C0
	internal void Init(int record) { }

	// RVA: 0xF08640
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0xF0F658
	internal bool get_IsCustomType() { }

	// RVA: 0xF0F6E4
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0xF0F7DC
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0xF0A928
	internal bool IsInRelation() { }

	// RVA: 0xF0F7E4
	internal bool IsMaxLengthViolated() { }

	// RVA: 0xF0FED0
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0xF10184
	internal void FinishInitInProgress() { }

	// RVA: 0xF101A0
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF0A248
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF101C4
	private void InsureStorage() { }

	// RVA: 0xF10264
	internal void SetCapacity(int capacity) { }

	// RVA: 0xF10320
	internal void OnSetDataSet() { }

	// RVA: 0xF10324
	public override string ToString() { }

	// RVA: 0xF103E8
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0xF104A4
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xF0A72C
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0xF10568
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xF1063C
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0xF106F0
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xF10710
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xF107CC
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF1089C
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF0BEFC
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

}

// Namespace: System.Data
internal abstract class AutoIncrementValue
{
	// Fields
	private bool <Auto>k__BackingField; // 0x10

	// Methods

	// RVA: 0xF10940
	internal bool get_Auto() { }

	// RVA: 0xF10948
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

	// RVA: 0xF0F368
	internal AutoIncrementValue Clone() { }

	// RVA: 0xF10950
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

	// RVA: 0xF10958
	internal override object get_Current() { }

	// RVA: 0xF109C0
	internal override void set_Current(object value) { }

	// RVA: 0xF10A44
	internal override Type get_DataType() { }

	// RVA: 0xF10AE4
	internal override Int64 get_Seed() { }

	// RVA: 0xF10AEC
	internal override void set_Seed(Int64 value) { }

	// RVA: 0xF10CA8
	internal override Int64 get_Step() { }

	// RVA: 0xF10CB0
	internal override void set_Step(Int64 value) { }

	// RVA: 0xF10DCC
	internal override void MoveAfter() { }

	// RVA: 0xF10DE0
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xF10E60
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0xF10B98
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xF0981C
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

	// RVA: 0xF10FCC
	internal override object get_Current() { }

	// RVA: 0xF11034
	internal override void set_Current(object value) { }

	// RVA: 0xF110C0
	internal override Type get_DataType() { }

	// RVA: 0xF11160
	internal override Int64 get_Seed() { }

	// RVA: 0xF11168
	internal override void set_Seed(Int64 value) { }

	// RVA: 0xF11400
	internal override Int64 get_Step() { }

	// RVA: 0xF1146C
	internal override void set_Step(Int64 value) { }

	// RVA: 0xF11664
	internal override void MoveAfter() { }

	// RVA: 0xF11704
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xF11740
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0xF11284
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xF0982C
	public void .ctor() { }

}

// Namespace: System.Data
[Serializable]
public class DataException
{
	// Methods

	// RVA: 0xF1182C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF11834
	public void .ctor() { }

	// RVA: 0xF1189C
	public void .ctor(string s) { }

	// RVA: 0xF118CC
	public void .ctor(string s, Exception innerException) { }

}

// Namespace: System.Data
[Serializable]
public class ConstraintException
{
	// Methods

	// RVA: 0xF118D4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF118DC
	public void .ctor() { }

	// RVA: 0xF11944
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class DeletedRowInaccessibleException
{
	// Methods

	// RVA: 0xF11974
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF1197C
	public void .ctor() { }

	// RVA: 0xF119E4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class DuplicateNameException
{
	// Methods

	// RVA: 0xF11A14
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF11A1C
	public void .ctor() { }

	// RVA: 0xF11A84
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class InRowChangingEventException
{
	// Methods

	// RVA: 0xF11AB4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF11ABC
	public void .ctor() { }

	// RVA: 0xF11B24
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class InvalidConstraintException
{
	// Methods

	// RVA: 0xF11B54
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF11B5C
	public void .ctor() { }

	// RVA: 0xF11BC4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class NoNullAllowedException
{
	// Methods

	// RVA: 0xF11BF4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF11BFC
	public void .ctor() { }

	// RVA: 0xF11C64
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class ReadOnlyException
{
	// Methods

	// RVA: 0xF11C94
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF11C9C
	public void .ctor() { }

	// RVA: 0xF11D04
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class RowNotInTableException
{
	// Methods

	// RVA: 0xF11D34
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF11D3C
	public void .ctor() { }

	// RVA: 0xF11DA4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class VersionNotFoundException
{
	// Methods

	// RVA: 0xF11DD4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF11DDC
	public void .ctor() { }

	// RVA: 0xF11E44
	public void .ctor(string s) { }

}

// Namespace: System.Data
internal static class ExceptionBuilder
{
	// Methods

	// RVA: 0xF11E74
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0xF11F1C
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0xF0BCEC
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0xF0C080
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0xF1200C
	internal static Exception _Argument(string error) { }

	// RVA: 0xF12074
	internal static Exception _Argument(string paramName, string error) { }

	// RVA: 0xF120DC
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0xF1214C
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0xF121BC
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0xF1222C
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0xF12294
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0xF122FC
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: 0x316B894
	private static Exception _InvalidEnumArgumentException(T value) { }

	// RVA: 0xF12364
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0xF123BC
	private static Exception _Data(string error) { }

	// RVA: 0xF12430
	private static Exception _Constraint(string error) { }

	// RVA: 0xF124A4
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0xF12518
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0xF1258C
	private static Exception _DuplicateName(string error) { }

	// RVA: 0xF12600
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0xF12674
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0xF126E8
	private static Exception _ReadOnly(string error) { }

	// RVA: 0xF1275C
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0xF127D0
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0xF07074
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0xF12844
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0xF12958
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0xF12A68
	public static Exception ArgumentContainsNull(string paramName) { }

	// RVA: 0xF12B78
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0xF12C80
	public static Exception CannotModifyCollection() { }

	// RVA: 0xF12D10
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0xF12E20
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0xF12F30
	public static Exception InvalidOffsetLength() { }

	// RVA: 0xF12FC0
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0xF130E0
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0xF13170
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0xF1329C
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0xF133AC
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0xF134BC
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0xF0E3D0
	public static Exception CannotAddColumn3() { }

	// RVA: 0xF0E460
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0xF135CC
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0xF136E8
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0xF13804
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0xF13920
	public static Exception CannotRemoveColumn() { }

	// RVA: 0xF139B0
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0xF13A40
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0xF13B50
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0xF13C70
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0xF13D90
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0xF13E20
	public static Exception NoConstraintName() { }

	// RVA: 0xF13EB0
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0xF13FCC
	public static string KeysToString(object[] keys) { }

	// RVA: 0xF140EC
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0xF14300
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0xF14378
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0xF144A4
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0xF145C0
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0xF146DC
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0xF14808
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0xF14898
	public static Exception ConstraintForeignTable() { }

	// RVA: 0xF14928
	public static Exception ConstraintParentValues() { }

	// RVA: 0xF149B8
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0xF14AB8
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0xF14B48
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0xF14C64
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0xF14D80
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0xF14EB4
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0xF14FC4
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0xF0FE0C
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0xF100C0
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0xF150D4
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0xF08520
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0xF085B0
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0xF10D3C
	public static Exception AutoIncrementSeed() { }

	// RVA: 0xF0A808
	public static Exception CantChangeDataType() { }

	// RVA: 0xF0A898
	public static Exception NullDataType() { }

	// RVA: 0xF0A1B8
	public static Exception ColumnNameRequired() { }

	// RVA: 0xF0B7BC
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0xF0B0EC
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xF0B84C
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xF0BA28
	public static Exception ExpressionAndUnique() { }

	// RVA: 0xF0BDDC
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0xF0BAB8
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0xF151E4
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0xF0BE6C
	public static Exception ExpressionCircular() { }

	// RVA: 0xF0EA10
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0xF0E7D8
	public static Exception NullKeyValues(string column) { }

	// RVA: 0xF0E8F4
	public static Exception NullValues(string column) { }

	// RVA: 0xF0D290
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0xF152D8
	public static Exception ReadOnly(string column) { }

	// RVA: 0xF0DEA4
	public static Exception UniqueAndExpression() { }

	// RVA: 0xF0D6E8
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0xF153F4
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0xF0E6E4
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0xF0CBF4
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0xF0C6A8
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0xF0B31C
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0xF0E2B0
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0xF0D01C
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0xF0C79C
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0xF08930
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0xF154E8
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0xF155F8
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0xF15714
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0xF15824
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0xF0B574
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0xF0B758
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0xF0B604
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0xF07188
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0xF1592C
	public static Exception SetFailed(string name) { }

	// RVA: 0xF15A48
	public static Exception SetRowStateFilter() { }

	// RVA: 0xF15AE4
	public static Exception CanNotUseDataViewManager() { }

	// RVA: 0xF15B80
	public static Exception CanNotSetTable() { }

	// RVA: 0xF15C1C
	public static Exception CanNotUse() { }

	// RVA: 0xF15CB8
	public static Exception CanNotBindTable() { }

	// RVA: 0xF15D54
	public static Exception SetTable() { }

	// RVA: 0xF15DF0
	public static Exception SetIListObject() { }

	// RVA: 0xF15E80
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0xF15F1C
	public static Exception NotOpen() { }

	// RVA: 0xF15FB8
	public static Exception CreateChildView() { }

	// RVA: 0xF16048
	public static Exception CanNotDelete() { }

	// RVA: 0xF160E4
	public static Exception GetElementIndex(int index) { }

	// RVA: 0xF16210
	public static Exception AddExternalObject() { }

	// RVA: 0xF162A0
	public static Exception CanNotClear() { }

	// RVA: 0xF16330
	public static Exception InsertExternalObject() { }

	// RVA: 0xF163C0
	public static Exception RemoveExternalObject() { }

	// RVA: 0xF16450
	public static Exception ColumnToSortIsOutOfRange(string column) { }

	// RVA: 0xF16560
	public static Exception KeyTableMismatch() { }

	// RVA: 0xF165FC
	public static Exception KeyNoColumns() { }

	// RVA: 0xF16698
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0xF167D0
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0xF168EC
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0xF0AAAC
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0xF16988
	public static Exception KeyLengthMismatch() { }

	// RVA: 0xF16A18
	public static Exception KeyLengthZero() { }

	// RVA: 0xF16AA8
	public static Exception ForeignRelation() { }

	// RVA: 0xF16B38
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0xF16BD4
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0xF16D00
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xF16E2C
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xF16F58
	public static Exception RelationForeignRow() { }

	// RVA: 0xF16FE8
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0xF17078
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0xF17188
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0xF17298
	public static Exception RelationDoesNotExist() { }

	// RVA: 0xF17328
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0xF173C4
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0xF174D4
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0xF175E4
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0xF17674
	public static Exception RowNotInTheTable() { }

	// RVA: 0xF17710
	public static Exception EditInRowChanging() { }

	// RVA: 0xF177AC
	public static Exception EndEditInRowChanging() { }

	// RVA: 0xF17848
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0xF178E4
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0xF17980
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0xF17A1C
	public static Exception ValueArrayLength() { }

	// RVA: 0xF17AAC
	public static Exception NoCurrentData() { }

	// RVA: 0xF17B48
	public static Exception NoOriginalData() { }

	// RVA: 0xF17BE4
	public static Exception NoProposedData() { }

	// RVA: 0xF17C80
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0xF17D1C
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0xF17DB8
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0xF17E54
	public static Exception RowEmpty() { }

	// RVA: 0xF17EE4
	public static Exception InvalidRowVersion() { }

	// RVA: 0xF17F80
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0xF180AC
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0xF181E8
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0xF182F8
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0xF18394
	public static Exception MultipleParents() { }

	// RVA: 0xF18430
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0xF18494
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0xF18524
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0xF185B4
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0xF186C4
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0xF187D4
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0xF188E4
	public static Exception TablesInDifferentSets() { }

	// RVA: 0xF18974
	public static Exception RelationAlreadyExists() { }

	// RVA: 0xF18A04
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0xF18A94
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0xF18B24
	public static Exception RecordStateRange() { }

	// RVA: 0xF18BB4
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0xF18D58
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0xF18EA0
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0xF18F30
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0xF18FC0
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0xF190D0
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0xF191F0
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0xF1930C
	public static Exception RelationTableNull() { }

	// RVA: 0xF1939C
	public static Exception RelationDataSetNull() { }

	// RVA: 0xF1942C
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0xF194BC
	public static Exception ParentTableMismatch() { }

	// RVA: 0xF1954C
	public static Exception ChildTableMismatch() { }

	// RVA: 0xF195DC
	public static Exception EnforceConstraint() { }

	// RVA: 0xF19678
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0xF19708
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0xF1979C
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0xF19834
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0xF19898
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0xF19928
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0xF199B8
	public static Exception NoTableName() { }

	// RVA: 0xF19A48
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0xF19AD8
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0xF19BE8
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0xF19D04
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0xF19E30
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0xF19F4C
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0xF1A068
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0xF1A0F8
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0xF1A188
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0xF1A2B4
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0xF1A3C4
	public static Exception TableInRelation() { }

	// RVA: 0xF1A454
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0xF1A570
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0xF1A600
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0xF1A690
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0xF1A720
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0xF1A7B0
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0xF1A8C0
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0xF1AA20
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0xF1AB54
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0xF1ACA8
	public static Exception NullRange() { }

	// RVA: 0xF1AD44
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0xF1ADD4
	public static Exception ProblematicChars(Char charValue) { }

	// RVA: 0xF1AF48
	public static Exception StorageSetFailed() { }

	// RVA: 0xF1AFD8
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0xF1B074
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0xF1B0D0
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0xF1B1FC
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0xF1B328
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0xF1B45C
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0xF1B578
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0xF1B694
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0xF1B7B0
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0xF1B8CC
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0xF1B9E8
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0xF1BB04
	public static Exception DatatypeNotDefined() { }

	// RVA: 0xF1BBA0
	public static Exception MismatchKeyLength() { }

	// RVA: 0xF1BC3C
	public static Exception InvalidField(string name) { }

	// RVA: 0xF1BD58
	public static Exception InvalidSelector(string name) { }

	// RVA: 0xF1BE74
	public static Exception CircularComplexType(string name) { }

	// RVA: 0xF1BF90
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0xF1C0AC
	public static Exception InvalidKey(string name) { }

	// RVA: 0xF1C1C8
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0xF1C2E4
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0xF1C380
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0xF1C49C
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0xF1C5B8
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0xF1C6E4
	public static Exception MissingRefer(string name) { }

	// RVA: 0xF0A518
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0xF1C818
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0xF1C8A8
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0xF1C944
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0xF1C9E0
	public static Exception NestedCircular(string name) { }

	// RVA: 0xF1CAFC
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0xF1CC18
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0xF1CD28
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0xF1CDB8
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0xF1CE54
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0xF1CF70
	public static Exception FoundEntity() { }

	// RVA: 0xF1D00C
	public static Exception MergeFailed(string name) { }

	// RVA: 0xF1D080
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0xF1D1C0
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0xF1D2E0
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0xF1D3FC
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

	// RVA: 0xF1D48C
	public void .ctor() { }

	// RVA: 0xF1D77C
	public void .ctor(string dataSetName) { }

	// RVA: 0xF1D980
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xF1D988
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xF1DA34
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0xF1DA3C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF1DA44
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0xF1DCAC
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF1E2D0
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0xF1DCB4
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xF1DC58
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xF1F050
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xF1F558
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xF1E2D4
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF1F730
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF1E49C
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF1FA30
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF20DC8
	internal void FailedEnableConstraints() { }

	// RVA: 0xF20F84
	public bool get_CaseSensitive() { }

	// RVA: 0xF20F8C
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xF216D0
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xF216D8
	public DataViewManager get_DefaultViewManager() { }

	// RVA: 0xF21824
	public bool get_EnforceConstraints() { }

	// RVA: 0xF20DFC
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0xF21F84
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0xF2182C
	internal void EnableConstraints() { }

	// RVA: 0xF21F8C
	public string get_DataSetName() { }

	// RVA: 0xF1D7A8
	public void set_DataSetName(string value) { }

	// RVA: 0xF22010
	public string get_Namespace() { }

	// RVA: 0xF22018
	public void set_Namespace(string value) { }

	// RVA: 0xF22578
	public string get_Prefix() { }

	// RVA: 0xF22580
	public void set_Prefix(string value) { }

	// RVA: 0xF20D3C
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF2273C
	public bool get_IsInitialized() { }

	// RVA: 0xF2274C
	public CultureInfo get_Locale() { }

	// RVA: 0xF22754
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xF228FC
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0xF2350C
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xF23514
	public override ISite get_Site() { }

	// RVA: 0xF2351C
	public override void set_Site(ISite value) { }

	// RVA: 0xF236FC
	public DataRelationCollection get_Relations() { }

	// RVA: 0xF23704
	public DataTableCollection get_Tables() { }

	// RVA: 0xF2370C
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xF237B0
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xF23854
	public void BeginInit() { }

	// RVA: 0xF23860
	public void EndInit() { }

	// RVA: 0xF23A90
	public void Clear() { }

	// RVA: 0xF23CD8
	public virtual DataSet Clone() { }

	// RVA: 0xF1ED04
	internal int EstimatedXmlStringSize() { }

	// RVA: 0xF24DD8
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xF24DDC
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0xF1EB6C
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0xF24F14
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0xF2030C
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF25478
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xF259E8
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0xF25544
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xF25078
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF24F1C
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xF25A7C
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xF25CCC
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0xF25CD4
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF2561C
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0xF28600
	private bool IsEmpty() { }

	// RVA: 0xF27064
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xF20D34
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0xF28A80
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xF1EE24
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0xF288F4
	public void Merge(DataSet dataSet) { }

	// RVA: 0xF29A1C
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF29CA0
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF29CC4
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0xF29D28
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF29E18
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0xF23CB4
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0xF23A00
	private void OnInitialized() { }

	// RVA: 0xF29E3C
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0xF29E40
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0xF29E70
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xF29E74
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0xF21F94
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF29E84
	internal DataTable[] TopLevelTables() { }

	// RVA: 0xF29E8C
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0xF2A1C8
	public virtual void Reset() { }

	// RVA: 0xF21288
	internal bool ValidateCaseConstraint() { }

	// RVA: 0xF2305C
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0xF2A4AC
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	// RVA: 0xF2A5D4
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xF2A95C
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xF2ABE8
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF2ADBC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF2B010
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF2B048
	internal string get_MainTableName() { }

	// RVA: 0xF2B050
	internal void set_MainTableName(string value) { }

	// RVA: 0xF2B058
	internal int get_ObjectID() { }

}

// Namespace: 
internal struct RowDiffIdUsageSection
{
	// Fields
	private DataTable _targetTable; // 0x10

	// Methods

	// RVA: 0xF2B060
	internal void Prepare(DataTable table) { }

}

// Namespace: 
internal struct DSRowDiffIdUsageSection
{
	// Fields
	private DataSet _targetDS; // 0x10

	// Methods

	// RVA: 0xF26FE0
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

	// RVA: 0xEEA020
	public void .ctor() { }

	// RVA: 0xEEA604
	public void .ctor(string tableName) { }

	// RVA: 0xEEA678
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEEABD4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEEACD0
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xEEA834
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xEEB0A8
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xEEC52C
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xEEF814
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xEF0864
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xEF15E8
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEF17C4
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEEBDF8
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEED498
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEF1C80
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0xEF1994
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xEF1D68
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xEF2058
	public bool get_CaseSensitive() { }

	// RVA: 0xEF2060
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xEF2100
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0xEF2110
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0xEF2564
	internal void SuspendIndexEvents() { }

	// RVA: 0xEF2648
	public bool get_IsInitialized() { }

	// RVA: 0xEF2658
	private bool get_IsTypedDataTable() { }

	// RVA: 0xEEFF50
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0xEF2728
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0xEF2730
	internal bool get_SelfNested() { }

	// RVA: 0xEF2B5C
	internal System.Collections.Generic.List<System.Data.Index> get_LiveIndexes() { }

	// RVA: 0xEF2C2C
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xEF2C34
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xEF2CA0
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0xEF2CA8
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0xEF2CB0
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0xEF2D58
	public DataColumnCollection get_Columns() { }

	// RVA: 0xEF2D60
	private CompareInfo get_CompareInfo() { }

	// RVA: 0xEF2DC4
	public ConstraintCollection get_Constraints() { }

	// RVA: 0xEF2DCC
	private void ResetConstraints() { }

	// RVA: 0xEF2DEC
	public DataSet get_DataSet() { }

	// RVA: 0xEF2DF4
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xEF2EC4
	public DataView get_DefaultView() { }

	// RVA: 0xEF2FD4
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0xEF303C
	internal bool get_EnforceConstraints() { }

	// RVA: 0xEF3074
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0xEF3678
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0xEF3680
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0xEF30C4
	internal void EnableConstraints() { }

	// RVA: 0xEEF224
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xEF3688
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xEF3738
	public CultureInfo get_Locale() { }

	// RVA: 0xEF3740
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xEF0268
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0xEF3C08
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xEF3C10
	public int get_MinimumCapacity() { }

	// RVA: 0xEF0830
	public void set_MinimumCapacity(int value) { }

	// RVA: 0xEF3C30
	internal int get_RecordCapacity() { }

	// RVA: 0xEF3C50
	internal int get_ElementColumnCount() { }

	// RVA: 0xEF3C58
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0xEF2AB4
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0xEF3CA8
	internal bool get_MergingData() { }

	// RVA: 0xEF3CB0
	internal void set_MergingData(bool value) { }

	// RVA: 0xEF3CB8
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0xEF3CC0
	internal bool get_SchemaLoading() { }

	// RVA: 0xEF3CC8
	internal void CacheNestedParent() { }

	// RVA: 0xEF3CF4
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0xEF41A8
	internal int get_NestedParentsCount() { }

	// RVA: 0xEF44F4
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0xEF45F4
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0xEF4B08
	public DataRowCollection get_Rows() { }

	// RVA: 0xEF4B10
	public string get_TableName() { }

	// RVA: 0xEF4B18
	public void set_TableName(string value) { }

	// RVA: 0xEF5284
	internal string get_EncodedTableName() { }

	// RVA: 0xEF5334
	private string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables) { }

	// RVA: 0xEEC4A4
	public string get_Namespace() { }

	// RVA: 0xEEEE1C
	public void set_Namespace(string value) { }

	// RVA: 0xEF645C
	internal bool IsNamespaceInherited() { }

	// RVA: 0xEF553C
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0xEF5990
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0xEF646C
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0xEF5E04
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0xEF68C4
	public virtual void BeginInit() { }

	// RVA: 0xEF68D0
	public virtual void EndInit() { }

	// RVA: 0xEF6F44
	public string get_Prefix() { }

	// RVA: 0xEF6F4C
	public void set_Prefix(string value) { }

	// RVA: 0xEF70F8
	internal DataColumn get_XmlText() { }

	// RVA: 0xEF7100
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0xEF71CC
	internal Decimal get_MaxOccurs() { }

	// RVA: 0xEF71D8
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0xEF71E0
	internal Decimal get_MinOccurs() { }

	// RVA: 0xEF71EC
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0xEF71F4
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0xEF7290
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0xEF7324
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0xEF73B0
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0xEF77E0
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0xEF8364
	protected virtual DataTable CreateInstance() { }

	// RVA: 0xEF83F4
	public virtual DataTable Clone() { }

	// RVA: 0xEF83FC
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0xEF860C
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0xEF8948
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0xEEE094
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0xEF8E70
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xEF8F28
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xEF8FE0
	public override ISite get_Site() { }

	// RVA: 0xEF8FE8
	public override void set_Site(ISite value) { }

	// RVA: 0xEF91C8
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0xEF91D8
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0xEF91E4
	internal void InsertRow(DataRow row, Int64 proposedID, int pos, bool fireEvent) { }

	// RVA: 0xEFA024
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0xEFA058
	public void Clear() { }

	// RVA: 0xEFA060
	internal void Clear(bool clearAll) { }

	// RVA: 0xEFAAA0
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0xEFAB70
	internal void CommitRow(DataRow row) { }

	// RVA: 0xEFAE2C
	internal int Compare(string s1, string s2) { }

	// RVA: 0xEFAE34
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0xEFAFD0
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0xEFB058
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0xEFB0E0
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xEFB0E8
	internal void DeleteRow(DataRow row) { }

	// RVA: 0xEFB188
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0xEFB2B8
	internal void FreeRecord(int record) { }

	// RVA: 0xEFB2D8
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xEFB704
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xEFB8FC
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xEFB900
	internal System.Collections.Generic.List<System.Data.DataViewListener> GetListeners() { }

	// RVA: 0xEF3AFC
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0xEF7E68
	internal void InsertRow(DataRow row, Int64 proposedID) { }

	// RVA: 0xEFC964
	internal int NewRecord() { }

	// RVA: 0xEFCA58
	internal int NewUninitializedRecord() { }

	// RVA: 0xEFC96C
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0xEF1C24
	internal DataRow NewEmptyRow() { }

	// RVA: 0xEFCA78
	private DataRow NewUninitializedRow() { }

	// RVA: 0xEFCB44
	public DataRow NewRow() { }

	// RVA: 0xEFCCC0
	internal DataRow CreateEmptyRow() { }

	// RVA: 0xEFCC2C
	private void NewRowCreated(DataRow row) { }

	// RVA: 0xEFCAB0
	internal DataRow NewRow(int record) { }

	// RVA: 0xEFD0A4
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0xEFD10C
	protected virtual Type GetRowType() { }

	// RVA: 0xEFD1AC
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0xEFD3B8
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0xEFD410
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0xEFD4F4
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0xEFD5D8
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xEFD6BC
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0xEFD6CC
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0xEFAD7C
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEFACCC
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEFD6D0
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0xEFD7B4
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0xEFD898
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0xEFD97C
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0xEFDA60
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0xEFDB44
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0xEFDC28
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0xEF6E38
	private void OnInitialized() { }

	// RVA: 0xEFB318
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0xEF5208
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0xEFDD0C
	internal void RecordChanged(int record) { }

	// RVA: 0xEFDED8
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0xEFBAF0
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xEFBCD4
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0xEFE1B8
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xEFE39C
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xEFE5CC
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0xEFF2A0
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0xEFF454
	public virtual void Reset() { }

	// RVA: 0xEEE08C
	internal void ResetIndexes() { }

	// RVA: 0xEFF7E0
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0xEFFA40
	internal void RollbackRow(DataRow row) { }

	// RVA: 0xEFC6F4
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEFFAEC
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEFB908
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0xEF74D4
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged) { }

	// RVA: 0xEF95C4
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, Exception deferredException) { }

	// RVA: 0xEF7530
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0xEFFD64
	private void RestoreShadowIndexes() { }

	// RVA: 0xEF2504
	private void SetShadowIndexes() { }

	// RVA: 0xEFFD84
	internal void ShadowIndexCopy() { }

	// RVA: 0xEFFE28
	public override string ToString() { }

	// RVA: 0xEFFACC
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0xEFFEF4
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0xF001B8
	internal DataColumn AddUniqueKey() { }

	// RVA: 0xF001C0
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0xF00274
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0xF00288
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0xEEF15C
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0xF0069C
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0xF006AC
	public void Merge(DataTable table) { }

	// RVA: 0xF006B8
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF00940
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0xF00D88
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xEEF2B0
	private bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF01230
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0xF015F4
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0xF0164C
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0xF01890
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xF03588
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xF03660
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xF04E7C
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xF02A58
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xF04F48
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF036DC
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF00E50
	private void CreateTableList(DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF051CC
	private void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList) { }

	// RVA: 0xF0574C
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xF05998
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF059A8
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0xF05B7C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF05D38
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF05D70
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xF05D7C
	internal Hashtable get_RowDiffId() { }

	// RVA: 0xF05E08
	internal int get_ObjectID() { }

	// RVA: 0xF05E10
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF05F08
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF05FA8
	internal void EvaluateExpressions() { }

	// RVA: 0xEFC018
	internal void EvaluateExpressions(DataRow row, DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows) { }

	// RVA: 0xF06304
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0xEFA8B8
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0xEFE754
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

	// RVA: 0xF2B098
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xF2B208
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0xF2B408
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF2B914
	internal override object Eval() { }

	// RVA: 0xF2B928
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF2DB80
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF2DBBC
	internal override bool IsConstant() { }

	// RVA: 0xF2DC58
	internal override bool IsTableConstant() { }

	// RVA: 0xF2DCDC
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF2DD60
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF2DDE4
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF2DE80
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF2C308
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0xF2C5A0
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0xF2E064
	internal FunctionId get_Aggregate() { }

	// RVA: 0xF2E10C
	internal bool get_IsAggregate() { }

	// RVA: 0xF2B70C
	internal void Check() { }

	// RVA: 0xF2E3D4
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

	// RVA: 0xF2EDB0
	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0xF2F044
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

	// RVA: 0xF31080
	private static void .cctor() { }

	// RVA: 0xF310EC
	public void .ctor() { }

	// RVA: 0xF310F4
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

	// RVA: 0xF2FFA4
	internal void .ctor(Scope previousScope, System.Collections.Generic.IEnumerable<System.Type> allowedTypes) { }

	// RVA: 0xF30470
	public void Dispose() { }

	// RVA: 0xF2FA94
	public bool IsAllowedType(Type type) { }

	// RVA: 0xF30550
	private static bool IsTypeUnconditionallyAllowed(Type type) { }

	// RVA: 0xF30748
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

	// RVA: 0xF3115C
	private static void .cctor() { }

	// RVA: 0xF311C8
	public void .ctor() { }

	// RVA: 0xF311D0
	internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

	// RVA: 0xF311EC
	internal System.Collections.Generic.IEnumerable<System.Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }

}

// Namespace: System.Data
internal sealed class TypeLimiter
{
	// Fields
	private static Scope s_activeScope; // 0xFFFFFFFF
	private Scope m_instanceScope; // 0x10

	// Methods

	// RVA: 0xF2F888
	private void .ctor(Scope scope) { }

	// RVA: 0xF2F8BC
	private static bool get_IsTypeLimitingDisabled() { }

	// RVA: 0xF2F964
	public static TypeLimiter Capture() { }

	// RVA: 0xF2F9F0
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0xF2FC5C
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0xF30128
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0xF3027C
	private static System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0xF2FDB0
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

	// RVA: 0xF311F4
	public virtual int get_Count() { }

	// RVA: 0xF31224
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0xF3126C
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xF3129C
	public bool get_IsSynchronized() { }

	// RVA: 0xF312A4
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0xF31374
	public object get_SyncRoot() { }

	// RVA: 0xF31378
	protected virtual ArrayList get_List() { }

	// RVA: 0xF31380
	public void .ctor() { }

	// RVA: 0xF31388
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class ColumnTypeConverter
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0xF31418
	public void .ctor() { }

	// RVA: 0xF31420
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF314EC
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xF31A48
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xF31B14
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0xF31D28
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0xF31E6C
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0xF31E74
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xF31E7C
	private static void .cctor() { }

}

// Namespace: System.Data
internal class DataCommonEventSource
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static Int64 s_nextScopeId; // 0x8

	// Methods

	// RVA: 0xF32B44
	internal void Trace(string message) { }

	// RVA: 0x316B894
	internal void Trace(string format, T0 arg0) { }

	// RVA: 0x316B894
	internal void Trace(string format, T0 arg0, T1 arg1) { }

	// RVA: 0x316B894
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2) { }

	// RVA: 0x316B894
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x316B894
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x316B894
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	// RVA: 0xF32B54
	internal Int64 EnterScope(string message) { }

	// RVA: 0x316B894
	internal Int64 EnterScope(string format, T1 arg1) { }

	// RVA: 0x316B894
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2) { }

	// RVA: 0x316B894
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x316B894
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0xF32C34
	internal void ExitScope(Int64 scopeId) { }

	// RVA: 0xF32C44
	public void .ctor() { }

	// RVA: 0xF32C4C
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

	// RVA: 0xF32CC8
	public virtual string get_ConstraintName() { }

	// RVA: 0xF32CD0
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0xF33170
	internal string get_SchemaName() { }

	// RVA: 0xF331B8
	internal void set_SchemaName(string value) { }

	// RVA: 0xF33200
	internal virtual bool get_InCollection() { }

	// RVA: 0xF33208
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1
	public abstract DataTable get_Table() { }

	// RVA: 0xF33268
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1
	internal abstract bool ContainsColumn(DataColumn column) { }

	// RVA: -1
	internal abstract bool CanEnableConstraint() { }

	// RVA: -1
	internal abstract Constraint Clone(DataSet destination) { }

	// RVA: -1
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup) { }

	// RVA: 0xF332F4
	internal void CheckConstraint() { }

	// RVA: -1
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint) { }

	// RVA: -1
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException) { }

	// RVA: -1
	internal abstract void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: -1
	internal abstract void CheckState() { }

	// RVA: 0xF33354
	protected void CheckStateForProperty() { }

	// RVA: 0xF33464
	protected virtual DataSet get__DataSet() { }

	// RVA: -1
	internal abstract bool IsConstraintViolated() { }

	// RVA: 0xF3346C
	public override string ToString() { }

	// RVA: 0xF33478
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

	// RVA: 0xF334FC
	internal void .ctor(DataTable table) { }

	// RVA: 0xF335C0
	protected override ArrayList get_List() { }

	// RVA: 0xF335C8
	public Constraint get_Item(int index) { }

	// RVA: 0xF336D0
	internal DataTable get_Table() { }

	// RVA: 0xF336D8
	public Constraint get_Item(string name) { }

	// RVA: 0xF33988
	public void Add(Constraint constraint) { }

	// RVA: 0xF33990
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0xF34488
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0xF33FEC
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0xF342E4
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0xF33F18
	private bool AutoGenerated(Constraint constraint) { }

	// RVA: 0xF34424
	private void ArrayAdd(Constraint constraint) { }

	// RVA: 0xF34534
	private void ArrayRemove(Constraint constraint) { }

	// RVA: 0xF342B4
	internal string AssignName() { }

	// RVA: 0xF34358
	private void BaseAdd(Constraint constraint) { }

	// RVA: 0xF34648
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0xF34818
	private void BaseRemove(Constraint constraint) { }

	// RVA: 0xF34AE0
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0xF34B10
	public void Clear() { }

	// RVA: 0xF34F14
	public bool Contains(string name) { }

	// RVA: 0xF34F30
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF33DA0
	internal Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0xF340D8
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0xF350C4
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0xF351F4
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF3502C
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0xF337E0
	internal int InternalIndexOf(string constraintName) { }

	// RVA: 0xF34574
	private string MakeName(int index) { }

	// RVA: 0xF34464
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF32EE4
	internal void RegisterName(string name) { }

	// RVA: 0xF3546C
	public void Remove(Constraint constraint) { }

	// RVA: 0xF330EC
	internal void UnregisterName(string name) { }

	// RVA: 0xF355F4
	internal void FinishInitConstraints() { }

}

// Namespace: System.Data
internal sealed class ConstraintConverter
{
	// Methods

	// RVA: 0xF35F40
	public void .ctor() { }

	// RVA: 0xF35F48
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF36014
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

	// RVA: 0xF36AC0
	public void .ctor(DataSet dataSet) { }

	// RVA: 0xF36B2C
	public bool GetNext() { }

	// RVA: 0xF36EA4
	public Constraint GetConstraint() { }

	// RVA: 0xF36EAC
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF36EB4
	protected Constraint get_CurrentObject() { }

}

// Namespace: System.Data
internal class ForeignKeyConstraintEnumerator
{
	// Methods

	// RVA: 0xF36EBC
	public void .ctor(DataSet dataSet) { }

	// RVA: 0xF36F28
	protected override bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF36FAC
	public ForeignKeyConstraint GetForeignKeyConstraint() { }

}

// Namespace: System.Data
internal sealed class ChildForeignKeyConstraintEnumerator
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF37028
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF370B0
	protected override bool IsValidCandidate(Constraint constraint) { }

}

// Namespace: System.Data
internal sealed class ParentForeignKeyConstraintEnumerator
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF3715C
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF371E4
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

	// RVA: 0xF37294
	internal void .ctor(DataRow row) { }

	// RVA: 0xF3730C
	public void .ctor(DataRow row, DataColumn column, object value) { }

	// RVA: 0xF373B4
	public object get_ProposedValue() { }

	// RVA: 0xF373BC
	public void set_ProposedValue(object value) { }

	// RVA: 0xF373C4
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

// Namespace: System.Data
public sealed class DataColumnChangeEventHandler
{
	// Methods

	// RVA: 0xF373F8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF3751C
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

	// RVA: 0xF37530
	internal void .ctor(DataTable table) { }

	// RVA: 0xF376D4
	protected override ArrayList get_List() { }

	// RVA: 0xF376DC
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0xF376E4
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0xF376EC
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0xF376F4
	public DataColumn get_Item(int index) { }

	// RVA: 0xF35BB0
	public DataColumn get_Item(string name) { }

	// RVA: 0xF379D4
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0xF37A94
	public void Add(DataColumn column) { }

	// RVA: 0xF37AA0
	internal void AddAt(int index, DataColumn column) { }

	// RVA: 0xF38328
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF383CC
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF38470
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF38514
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF381C4
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0xF38144
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0xF38610
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0xF388B0
	internal string AssignName() { }

	// RVA: 0xF37DD4
	private void BaseAdd(DataColumn column) { }

	// RVA: 0xF38E28
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0xF39014
	private void BaseRemove(DataColumn column) { }

	// RVA: 0xF39164
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0xF385B8
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0xF39BAC
	public void Clear() { }

	// RVA: 0xF39E84
	public bool Contains(string name) { }

	// RVA: 0xF39F38
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF39FDC
	public int IndexOf(string columnName) { }

	// RVA: 0xF3783C
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0xF3A0FC
	internal void FinishInitCollection() { }

	// RVA: 0xF3894C
	private string MakeName(int index) { }

	// RVA: 0xF3826C
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF37DB0
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF3A1DC
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF38A20
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0xF3A238
	internal bool CanRegisterName(string name) { }

	// RVA: 0xF3A2A4
	public void Remove(DataColumn column) { }

	// RVA: 0xF38CFC
	internal void UnregisterName(string name) { }

	// RVA: 0xF39ACC
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0xF38750
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

}

// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor
{
	// Fields
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF3A3B8
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0xF3A3FC
	public override AttributeCollection get_Attributes() { }

	// RVA: 0xF3A5CC
	internal DataColumn get_Column() { }

	// RVA: 0xF3A5D4
	public override Type get_ComponentType() { }

	// RVA: 0xF3A674
	public override bool get_IsReadOnly() { }

	// RVA: 0xF3A694
	public override Type get_PropertyType() { }

	// RVA: 0xF3A6B4
	public override bool Equals(object other) { }

	// RVA: 0xF3A73C
	public override int GetHashCode() { }

	// RVA: 0xF3A760
	public override bool CanResetValue(object component) { }

	// RVA: 0xF3A920
	public override object GetValue(object component) { }

	// RVA: 0xF3A9B4
	public override void ResetValue(object component) { }

	// RVA: 0xF3AB44
	public override void SetValue(object component, object value) { }

	// RVA: 0xF3AC28
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xF3AC30
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

	// RVA: 0xF3AC88
	internal void .ctor() { }

	// RVA: 0xF3ACF4
	internal void .ctor(string rowError) { }

	// RVA: 0xF3AE14
	internal string get_Text() { }

	// RVA: 0xF3AE1C
	internal void set_Text(string value) { }

	// RVA: 0xF3AE88
	internal bool get_HasErrors() { }

	// RVA: 0xF3AEC4
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF3B264
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0xF3AFF8
	internal void Clear(DataColumn column) { }

	// RVA: 0xF3B304
	internal void Clear() { }

	// RVA: 0xF3B3AC
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0xF3ADA8
	private void SetText(string errorText) { }

	// RVA: 0xF3B114
	internal int IndexOf(DataColumn column) { }

}

// Namespace: System.Data
internal struct DataKey
{
	// Fields
	private readonly DataColumn[] _columns; // 0x10

	// Methods

	// RVA: 0xF3B4C4
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0xF3B790
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF3B798
	internal bool get_HasValue() { }

	// RVA: 0xF36A8C
	internal DataTable get_Table() { }

	// RVA: 0xF3B6EC
	internal void CheckState() { }

	// RVA: 0xF3B7A8
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0xF3B8A4
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0xF39A08
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF3B9A0
	public override int GetHashCode() { }

	// RVA: 0xF3BA10
	public override bool Equals(object value) { }

	// RVA: 0xF3BB40
	internal bool Equals(DataKey value) { }

	// RVA: 0xF3BC18
	internal string[] GetColumnNames() { }

	// RVA: 0xF3BCF4
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0xF3BE0C
	internal object[] GetKeyValues(int record) { }

	// RVA: 0xF3BF40
	internal Index GetSortIndex() { }

	// RVA: 0xF3BF98
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0xF3BFF4
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0xF3C078
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

	// RVA: 0xF3C174
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0xF3C6FC
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF3C7CC
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF3C8A0
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF3C9C8
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF3CB28
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0xF3CC50
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0xF39A84
	internal DataKey get_ChildKey() { }

	// RVA: 0xF3CC74
	public virtual DataTable get_ChildTable() { }

	// RVA: 0xF3CCB8
	public virtual DataSet get_DataSet() { }

	// RVA: 0xF3CCDC
	internal string[] get_ParentColumnNames() { }

	// RVA: 0xF3CCE4
	internal string[] get_ChildColumnNames() { }

	// RVA: 0xF3CCEC
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0xF3CDA8
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0xF3CF60
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF3D0E8
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF3D428
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xF3D440
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0xF3D464
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0xF39AA8
	internal DataKey get_ParentKey() { }

	// RVA: 0xF3D46C
	public virtual DataTable get_ParentTable() { }

	// RVA: 0xF3D4B0
	public virtual string get_RelationName() { }

	// RVA: 0xF3D4D4
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0xF3D85C
	internal void CheckNestedRelations() { }

	// RVA: 0xF3DC1C
	public virtual bool get_Nested() { }

	// RVA: 0xF3DC40
	public virtual void set_Nested(bool value) { }

	// RVA: 0xF3F484
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0xF3F4A8
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0xF3F4B0
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0xF3F4D4
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF3F560
	internal bool get_CheckMultipleNested() { }

	// RVA: 0xF3F568
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0xF3F570
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0xF3F578
	internal void CheckState() { }

	// RVA: 0xF3CB4C
	protected void CheckStateForProperty() { }

	// RVA: 0xF3C3C8
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF3F854
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0xF4002C
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF3F334
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF40110
	public override string ToString() { }

	// RVA: 0xF3EE64
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0xF4011C
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0xF40300
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

	// RVA: 0xF41A78
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0xF41BA4
	protected override ArrayList get_List() { }

	// RVA: 0xF41BAC
	private void EnsureDataSet() { }

	// RVA: 0xF41BFC
	protected override DataSet GetDataSet() { }

	// RVA: 0xF41C48
	public override DataRelation get_Item(int index) { }

	// RVA: 0xF41D54
	public override DataRelation get_Item(string name) { }

	// RVA: 0xF41E5C
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF41F00
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF41FA4
	private void AddCache(DataRelation relation) { }

	// RVA: 0xF41FFC
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xF420FC
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0xF421E0
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

	// RVA: 0xF422AC
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0xF423D0
	protected override ArrayList get_List() { }

	// RVA: 0xF423D8
	public override void Clear() { }

	// RVA: 0xF4242C
	protected override DataSet GetDataSet() { }

	// RVA: 0xF42434
	public override DataRelation get_Item(int index) { }

	// RVA: 0xF42540
	public override DataRelation get_Item(string name) { }

	// RVA: 0xF42648
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xF42D2C
	protected override void RemoveCore(DataRelation relation) { }

	// RVA: 0xF42FBC
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

	// RVA: 0xF40308
	internal int get_ObjectID() { }

	// RVA: -1
	public abstract DataRelation get_Item(int index) { }

	// RVA: -1
	public abstract DataRelation get_Item(string name) { }

	// RVA: 0xF40310
	public void Add(DataRelation relation) { }

	// RVA: 0xF405CC
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0xF40868
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF409A0
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF40AD8
	internal string AssignName() { }

	// RVA: 0xF40BDC
	public virtual void Clear() { }

	// RVA: 0xF40E44
	public virtual bool Contains(string name) { }

	// RVA: 0xF40E60
	internal int InternalIndexOf(string name) { }

	// RVA: -1
	protected abstract DataSet GetDataSet() { }

	// RVA: 0xF40B08
	private string MakeName(int index) { }

	// RVA: 0xF41018
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF410FC
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF411E0
	internal void RegisterName(string name) { }

	// RVA: 0xF413EC
	public void Remove(DataRelation relation) { }

	// RVA: 0xF41608
	public void RemoveAt(int index) { }

	// RVA: 0xF41688
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0xF41870
	internal void UnregisterName(string name) { }

	// RVA: 0xF419CC
	protected void .ctor() { }

}

// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor
{
	// Fields
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF43494
	internal void .ctor(DataRelation dataRelation) { }

	// RVA: 0xF434EC
	internal DataRelation get_Relation() { }

	// RVA: 0xF434F4
	public override Type get_ComponentType() { }

	// RVA: 0xF43594
	public override bool get_IsReadOnly() { }

	// RVA: 0xF4359C
	public override Type get_PropertyType() { }

	// RVA: 0xF4363C
	public override bool Equals(object other) { }

	// RVA: 0xF436C4
	public override int GetHashCode() { }

	// RVA: 0xF436E8
	public override bool CanResetValue(object component) { }

	// RVA: 0xF436F0
	public override object GetValue(object component) { }

	// RVA: 0xF43790
	public override void ResetValue(object component) { }

	// RVA: 0xF43794
	public override void SetValue(object component, object value) { }

	// RVA: 0xF43798
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

	// RVA: 0xF437A0
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0xF43858
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0xF43874
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0xF43888
	internal bool get_HasPropertyChanged() { }

	// RVA: 0xF43898
	internal int get_RBTreeNodeId() { }

	// RVA: 0xF438A0
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0xF4397C
	public string get_RowError() { }

	// RVA: 0xF439E4
	public void set_RowError(string value) { }

	// RVA: 0xF43C48
	private void RowErrorChanged() { }

	// RVA: 0xF43CA8
	internal Int64 get_rowID() { }

	// RVA: 0xF43CB0
	internal void set_rowID(Int64 value) { }

	// RVA: 0xF43D18
	public DataRowState get_RowState() { }

	// RVA: 0xF43FD8
	public DataTable get_Table() { }

	// RVA: 0xF3F3A4
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0xF43FE0
	internal int GetNestedParentCount() { }

	// RVA: 0xF440A0
	public void set_Item(string columnName, object value) { }

	// RVA: 0xF43F50
	public object get_Item(DataColumn column) { }

	// RVA: 0xF44190
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0xF448D4
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0xF44A70
	public void set_ItemArray(object[] value) { }

	// RVA: 0xF44ED8
	public void AcceptChanges() { }

	// RVA: 0xF4527C
	public void BeginEdit() { }

	// RVA: 0xF4462C
	private bool BeginEditInternal() { }

	// RVA: 0xF44758
	public void CancelEdit() { }

	// RVA: 0xF4452C
	private void CheckColumn(DataColumn column) { }

	// RVA: 0xF45280
	internal void CheckInTable() { }

	// RVA: 0xF452C8
	public void Delete() { }

	// RVA: 0xF447CC
	public void EndEdit() { }

	// RVA: 0xF45338
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0xF453A8
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF45780
	public string GetColumnError(string columnName) { }

	// RVA: 0xF45634
	public string GetColumnError(DataColumn column) { }

	// RVA: 0xF457F4
	public void ClearErrors() { }

	// RVA: 0xF3999C
	internal void ClearError(DataColumn column) { }

	// RVA: 0xF45860
	public bool get_HasErrors() { }

	// RVA: 0xF458B0
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0xF459A0
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0xF459A8
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF44124
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0xF3F47C
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0xF45ADC
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF45C04
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0xF45CBC
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0xF45CC4
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF45DF8
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0xF45E90
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0xF45EE8
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0xF3CF30
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0xF45F68
	internal int GetCurrentRecordNo() { }

	// RVA: 0xF445BC
	internal int GetDefaultRecord() { }

	// RVA: 0xF45FB0
	internal int GetOriginalRecordNo() { }

	// RVA: 0xF44710
	private int GetProposedRecordNo() { }

	// RVA: 0xF44924
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0xF45FF8
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0xF46024
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0xF46078
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0xF46084
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF3D36C
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0xF46250
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0xF462E0
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF46380
	public void RejectChanges() { }

	// RVA: 0xF43CE8
	internal void ResetLastChangedColumn() { }

	// RVA: 0xF469FC
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0xF46BB8
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0xF47004
	internal void SetParentRowToDBNull() { }

	// RVA: 0xF472DC
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0xF47464
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

// Namespace: System.Data
public sealed class DataRowBuilder
{
	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xF47840
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

	// RVA: 0xF47888
	public void .ctor(DataRow row, DataRowAction action) { }

}

// Namespace: System.Data
public sealed class DataRowChangeEventHandler
{
	// Methods

	// RVA: 0xF47914
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF47A38
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

}

// Namespace: 
private sealed class DataRowTree
{
	// Methods

	// RVA: 0xF47B34
	internal void .ctor() { }

	// RVA: 0xF4826C
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0xF482A0
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

	// RVA: 0xF47A4C
	internal void .ctor(DataTable table) { }

	// RVA: 0xF47B8C
	public override int get_Count() { }

	// RVA: 0xF39924
	public DataRow get_Item(int index) { }

	// RVA: 0xF47BE0
	public void Add(DataRow row) { }

	// RVA: 0xF47C04
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0xF47E48
	public int IndexOf(DataRow row) { }

	// RVA: 0xF47EF0
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0xF47F5C
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0xF47FD0
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0xF4804C
	internal void ArrayClear() { }

	// RVA: 0xF480A0
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0xF48140
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0xF481AC
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0xF48218
	public override IEnumerator GetEnumerator() { }

}

// Namespace: System.Data
internal sealed class DataRowCreatedEventHandler
{
	// Methods

	// RVA: 0xF482D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF483F8
	public virtual void Invoke(object sender, DataRow r) { }

}

// Namespace: System.Data
internal sealed class DataSetClearEventhandler
{
	// Methods

	// RVA: 0xF4840C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF48530
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

	// RVA: 0xF48544
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xF48594
	public override bool Equals(object other) { }

	// RVA: 0xF485A0
	public override int GetHashCode() { }

	// RVA: 0xF485C4
	public DataView get_DataView() { }

	// RVA: 0xF485CC
	private string System.ComponentModel.IDataErrorInfo.get_Item(string colName) { }

	// RVA: 0xF485E8
	private string System.ComponentModel.IDataErrorInfo.get_Error() { }

	// RVA: 0xF48658
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0xF486B4
	internal int GetRecord() { }

	// RVA: 0xF48704
	internal bool HasRecord() { }

	// RVA: 0xF3A898
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0xF3AA90
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0xF48768
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0xF43788
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0xF48954
	public DataRow get_Row() { }

	// RVA: 0xF4895C
	public void BeginEdit() { }

	// RVA: 0xF48968
	public void CancelEdit() { }

	// RVA: 0xF48A44
	public void EndEdit() { }

	// RVA: 0xF48A18
	public bool get_IsNew() { }

	// RVA: 0xF48AA8
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF48B4C
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF48BF0
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0xF48C84
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xF48CE0
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xF48CE8
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xF48CF0
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xF48CF8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xF48D00
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xF48D08
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xF48D10
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xF48D6C
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xF48DC8
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xF48E70
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xF48F20
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xF48F24
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

	// RVA: 0xF48FB0
	public void .ctor(DataTable dataTable) { }

}

// Namespace: System.Data
public sealed class DataTableClearEventHandler
{
	// Methods

	// RVA: 0xF49028
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF4914C
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

	// RVA: 0xF49160
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0xF49310
	protected override ArrayList get_List() { }

	// RVA: 0xF49318
	internal int get_ObjectID() { }

	// RVA: 0xF49320
	public DataTable get_Item(int index) { }

	// RVA: 0xF35D14
	public DataTable get_Item(string name) { }

	// RVA: 0xF35E24
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0xF49874
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0xF499B0
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0xF49AF4
	public void Add(DataTable table) { }

	// RVA: 0xF4A138
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF4A270
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF4A02C
	private void ArrayAdd(DataTable table) { }

	// RVA: 0xF4A3A8
	internal string AssignName() { }

	// RVA: 0xF49E8C
	private void BaseAdd(DataTable table) { }

	// RVA: 0xF4A78C
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0xF4A968
	private void BaseRemove(DataTable table) { }

	// RVA: 0xF4A9E4
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0xF4B07C
	public void Clear() { }

	// RVA: 0xF4A4DC
	public bool Contains(string name) { }

	// RVA: 0xF4B3C8
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0xF4B60C
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF4B758
	public int IndexOf(DataTable table) { }

	// RVA: 0xF4B848
	public int IndexOf(string tableName) { }

	// RVA: 0xF4B864
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0xF4B8D0
	internal void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF49468
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0xF496BC
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0xF4B924
	internal void FinishInitCollection() { }

	// RVA: 0xF4A408
	private string MakeName(int index) { }

	// RVA: 0xF4A054
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF49DA8
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF4A4F8
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0xF4B9B8
	public void Remove(DataTable table) { }

	// RVA: 0xF4AF40
	internal void UnregisterName(string name) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventArgs
{
	// Fields
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0xF4BBB4
	public void .ctor(DataRow dataRow) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventHandler
{
	// Methods

	// RVA: 0xF4BC2C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF4BD50
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

}

// Namespace: System.Data
internal sealed class DataTablePropertyDescriptor
{
	// Fields
	private readonly DataTable <Table>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF4BD64
	public DataTable get_Table() { }

	// RVA: 0xF4BD6C
	internal void .ctor(DataTable dataTable) { }

	// RVA: 0xF4BDB0
	public override Type get_ComponentType() { }

	// RVA: 0xF4BE50
	public override bool get_IsReadOnly() { }

	// RVA: 0xF4BE58
	public override Type get_PropertyType() { }

	// RVA: 0xF4BEF8
	public override bool Equals(object other) { }

	// RVA: 0xF4BF80
	public override int GetHashCode() { }

	// RVA: 0xF4BFA4
	public override bool CanResetValue(object component) { }

	// RVA: 0xF4BFAC
	public override object GetValue(object component) { }

	// RVA: 0xF4C0F0
	public override void ResetValue(object component) { }

	// RVA: 0xF4C0F4
	public override void SetValue(object component, object value) { }

	// RVA: 0xF4C0F8
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: System.Data
internal sealed class DataTableTypeConverter
{
	// Methods

	// RVA: 0xF4C100
	public void .ctor() { }

	// RVA: 0xF4C1B4
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: 
private sealed class DataRowReferenceComparer
{
	// Fields
	internal static readonly DataRowReferenceComparer s_default; // 0x0

	// Methods

	// RVA: 0xF522BC
	private void .ctor() { }

	// RVA: 0xF522C4
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0xF522D0
	public int GetHashCode(DataRow obj) { }

	// RVA: 0xF522EC
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

	// RVA: 0xF4C1BC
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0xF4C7B4
	public void .ctor(DataTable table) { }

	// RVA: 0xF4CBC8
	public bool get_AllowDelete() { }

	// RVA: 0xF4CBD0
	public bool get_AllowEdit() { }

	// RVA: 0xF4CBD8
	public bool get_AllowNew() { }

	// RVA: 0xF4CBE0
	public int get_Count() { }

	// RVA: 0xF4CC34
	private int get_CountFromIndex() { }

	// RVA: 0xF4CC50
	public DataViewManager get_DataViewManager() { }

	// RVA: 0xF4CC58
	public bool get_IsInitialized() { }

	// RVA: 0xF4CC68
	protected bool get_IsOpen() { }

	// RVA: 0xF4CC70
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xF4CC78
	public virtual string get_RowFilter() { }

	// RVA: 0xF4CD90
	public virtual void set_RowFilter(string value) { }

	// RVA: 0xF4CFB4
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0xF4CFBC
	public void set_RowStateFilter(DataViewRowState value) { }

	// RVA: 0xF4D124
	public string get_Sort() { }

	// RVA: 0xF4D17C
	public void set_Sort(string value) { }

	// RVA: 0xF4D3FC
	internal System.Comparison<System.Data.DataRow> get_SortComparison() { }

	// RVA: 0xF4D404
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xF4D408
	public DataTable get_Table() { }

	// RVA: 0xF4D410
	public void set_Table(DataTable value) { }

	// RVA: 0xF4D6D8
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0xF4D7D0
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0xF4D754
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0xF4D958
	public virtual DataRowView AddNew() { }

	// RVA: 0xF4DE08
	public void BeginInit() { }

	// RVA: 0xF4DE14
	public void EndInit() { }

	// RVA: 0xF4DC98
	private void CheckOpen() { }

	// RVA: 0xF4D39C
	private void CheckSort(string sort) { }

	// RVA: 0xF4E0A0
	protected void Close() { }

	// RVA: 0xF4E0F8
	public void CopyTo(Array array, int index) { }

	// RVA: 0xF4E3E8
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0xF4E6C0
	public void Delete(int index) { }

	// RVA: 0xF4E6E8
	internal void Delete(DataRow row) { }

	// RVA: 0xF4EAF8
	protected override void Dispose(bool disposing) { }

	// RVA: 0xF4E8D0
	internal void FinishAddNew(bool success) { }

	// RVA: 0xF4EB58
	public IEnumerator GetEnumerator() { }

	// RVA: 0xF4EC1C
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xF4EC24
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xF4EC2C
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xF4ECC0
	private void System.Collections.IList.Clear() { }

	// RVA: 0xF4ECF0
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xF4ED88
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xF4DCDC
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0xF4EE24
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0xF4EE80
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xF4EEB0
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xF4EFE4
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xF4F00C
	internal Index GetFindIndex(string column, bool keepIndex) { }

	// RVA: 0xF4F1C8
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xF4F1D0
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xF4F1E0
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xF4F1E8
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xF4F1F0
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xF4F1F8
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xF4F200
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xF4F208
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xF4F288
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xF4F328
	internal PropertyDescriptor GetSortProperty() { }

	// RVA: 0xF4F3C8
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xF4F408
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF4F540
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF4F678
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xF4F71C
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xF4F7C0
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xF4F804
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF4F914
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xF4FBB0
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xF4FBF4
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xF4FCEC
	private void System.ComponentModel.IBindingListView.ApplySort(ListSortDescriptionCollection sorts) { }

	// RVA: 0xF4F82C
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF50210
	private void System.ComponentModel.IBindingListView.RemoveFilter() { }

	// RVA: 0xF50314
	private string System.ComponentModel.IBindingListView.get_Filter() { }

	// RVA: 0xF50324
	private void System.ComponentModel.IBindingListView.set_Filter(string value) { }

	// RVA: 0xF50334
	private ListSortDescriptionCollection System.ComponentModel.IBindingListView.get_SortDescriptions() { }

	// RVA: 0xF50338
	internal ListSortDescriptionCollection GetSortDescriptions() { }

	// RVA: 0xF505DC
	private bool System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting() { }

	// RVA: 0xF505E4
	private bool System.ComponentModel.IBindingListView.get_SupportsFiltering() { }

	// RVA: 0xF505EC
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF506A8
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF50778
	internal virtual IFilter GetFilter() { }

	// RVA: 0xF50780
	private int GetRecord(int recordIndex) { }

	// RVA: 0xF4D800
	internal DataRow GetRow(int index) { }

	// RVA: 0xF4E358
	private DataRowView GetRowView(int record) { }

	// RVA: 0xF4D8E0
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0xF5084C
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0xF508E8
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0xF509B4
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xF50F9C
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF4E010
	private void OnInitialized() { }

	// RVA: 0xF51360
	protected void Reset() { }

	// RVA: 0xF50CD8
	internal void ResetRowViewCache() { }

	// RVA: 0xF51390
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xF515E4
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0xF4C828
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0xF4E0E4
	protected void UpdateIndex() { }

	// RVA: 0xF519A8
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0xF515EC
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0xF51BB4
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF51DD4
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF51FF4
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF52214
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF52224
	internal int get_ObjectID() { }

	// RVA: 0xF5222C
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

	// RVA: 0xF4C538
	internal void .ctor(DataView dv) { }

	// RVA: 0xF52358
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF5243C
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF524FC
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF525CC
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xF526A8
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF4C5C8
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0xF4D6D0
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0xF52968
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0xF51AC0
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0xF519B0
	internal void UnregisterListChangedEvent() { }

	// RVA: 0xF52418
	private void CleanUp(bool updateListeners) { }

	// RVA: 0xF52768
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

	// RVA: 0xF52C28
	internal void .ctor(DataSet dataSet, bool locked) { }

	// RVA: 0xF52F20
	public DataSet get_DataSet() { }

	// RVA: 0xF52F28
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0xF52F30
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF53024
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0xF5302C
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xF53030
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xF53038
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xF53040
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xF53048
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xF530E0
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xF530E8
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xF53118
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xF53148
	private void System.Collections.IList.Clear() { }

	// RVA: 0xF53178
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xF53188
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xF5319C
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xF531CC
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xF531FC
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xF5322C
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xF53234
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xF5327C
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xF53284
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xF5328C
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xF53294
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xF5329C
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xF532A4
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xF532EC
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xF53334
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xF5337C
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF53420
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF534C4
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xF534C8
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF53510
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xF53558
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xF5355C
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xF535A4
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF5367C
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF53814
	public DataView CreateDataView(DataTable table) { }

	// RVA: 0xF5390C
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF53A04
	protected virtual void TableCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF53C54
	protected virtual void RelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF53E74
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class DataViewManagerListItemTypeDescriptor
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private PropertyDescriptorCollection _propsCollection; // 0x18

	// Methods

	// RVA: 0xF52E2C
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xF4C024
	internal DataView GetDataView(DataTable table) { }

	// RVA: 0xF53EFC
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xF53F58
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xF53F60
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xF53F68
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xF53F70
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xF53F78
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xF53F80
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xF53F88
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xF53FE4
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xF54040
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xF540E8
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xF542F8
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

	// RVA: 0xF542FC
	internal void .ctor() { }

	// RVA: 0xF54388
	public bool get_ApplyDefaultSort() { }

	// RVA: 0xF54390
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xF543A8
	internal void SetDataTable(DataTable table) { }

	// RVA: 0xF543C0
	public string get_RowFilter() { }

	// RVA: 0xF543C8
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0xF543D0
	public string get_Sort() { }

}

// Namespace: 
private sealed class DataViewSettingsEnumerator
{
	// Fields
	private DataViewSettingCollection _dataViewSettings; // 0x10
	private IEnumerator _tableEnumerator; // 0x18

	// Methods

	// RVA: 0xF54880
	public void .ctor(DataViewManager dvm) { }

	// RVA: 0xF54A08
	public bool MoveNext() { }

	// RVA: 0xF54ABC
	public void Reset() { }

	// RVA: 0xF54B74
	public object get_Current() { }

}

// Namespace: System.Data
public class DataViewSettingCollection
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Methods

	// RVA: 0xF52E60
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xF543D8
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0xF5456C
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0xF54628
	public void CopyTo(Array ar, int index) { }

	// RVA: 0xF54840
	public virtual int get_Count() { }

	// RVA: 0xF547D8
	public IEnumerator GetEnumerator() { }

	// RVA: 0xF549D4
	public bool get_IsSynchronized() { }

	// RVA: 0xF549DC
	public object get_SyncRoot() { }

	// RVA: 0xF549E0
	internal void Remove(DataTable table) { }

}

// Namespace: System.Data
internal sealed class DefaultValueTypeConverter
{
	// Methods

	// RVA: 0xF54C94
	public void .ctor() { }

	// RVA: 0xF54C9C
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xF54E88
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

	// RVA: 0xF55034
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0xF55040
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0xF55180
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF5541C
	internal static void Bind(DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF5559C
	internal override object Eval() { }

	// RVA: 0xF555B0
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF5586C
	internal override object Eval(int[] records) { }

	// RVA: 0xF558F4
	internal override bool IsConstant() { }

	// RVA: 0xF558FC
	internal override bool IsTableConstant() { }

	// RVA: 0xF55904
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF5590C
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF5591C
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF559B0
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

	// RVA: 0xF559B4
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xF55A28
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF55A9C
	internal override object Eval() { }

	// RVA: 0xF55AB0
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF5B74C
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF5B764
	internal override bool IsConstant() { }

	// RVA: 0xF5B7B8
	internal override bool IsTableConstant() { }

	// RVA: 0xF5B80C
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF5B864
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF5B8BC
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF5B924
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF5BF04
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0xF5BF40
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xF5BF7C
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0xF5BF84
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0xF55AC8
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xF5E5D4
	private DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0xF5E5F8
	private static StorageType GetPrecedenceType(DataTypePrecedence code) { }

	// RVA: 0xF5E61C
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0xF5E6D8
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0xF5E0EC
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xF5D7CC
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xF5E7AC
	private int SqlResultType(int typeCode) { }

}

// Namespace: System.Data
internal sealed class LikeNode
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0xF5E7FC
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xF5E870
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF5EE30
	internal string AnalyzePattern(string pat) { }

}

// Namespace: System.Data
internal sealed class ConstNode
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0xF5F390
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0xF5BBD0
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0xF5FD98
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF5FDA0
	internal override object Eval() { }

	// RVA: 0xF5FDA8
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF5FDB4
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF5FDC0
	internal override bool IsConstant() { }

	// RVA: 0xF5FDC8
	internal override bool IsTableConstant() { }

	// RVA: 0xF5FDD0
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF5FDD8
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF5FDE0
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF5F8F8
	private object SmallestDecimal(object constant) { }

	// RVA: 0xF5F398
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

	// RVA: 0xF4CFAC
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0xF5FDE4
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0xF4CD34
	internal string get_Expression() { }

	// RVA: 0xF611E4
	internal bool get_HasValue() { }

	// RVA: 0xF6109C
	internal void Bind(DataTable table) { }

	// RVA: 0xF55994
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0xF611F4
	internal object Evaluate() { }

	// RVA: 0xF61200
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0xF61438
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xF61528
	internal DataColumn[] GetDependency() { }

	// RVA: 0xF61530
	internal bool IsTableAggregate() { }

	// RVA: 0xF61548
	internal static bool IsUnknown(object value) { }

	// RVA: 0xF615D0
	internal bool HasLocalAggregate() { }

	// RVA: 0xF615E8
	internal bool HasRemoteAggregate() { }

	// RVA: 0xF5D4B0
	internal static bool ToBoolean(object value) { }

}

// Namespace: System.Data
internal abstract class ExpressionNode
{
	// Fields
	private DataTable _table; // 0x10

	// Methods

	// RVA: 0xF5514C
	protected void .ctor(DataTable table) { }

	// RVA: 0xF5D430
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xF61600
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0xF61608
	protected DataTable get_table() { }

	// RVA: 0xF61610
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

	// RVA: 0xF61618
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0xF5E79C
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0xF5E5B4
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0xF5E698
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0xF5E750
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0xF5E6C8
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0xF5E76C
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0xF5E78C
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0xF5E7DC
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0xF61620
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0xF61630
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

	// RVA: 0xF632E4
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

	// RVA: 0xF60004
	internal void .ctor(DataTable table) { }

	// RVA: 0xF600D4
	internal void LoadExpression(string data) { }

	// RVA: 0xF6164C
	internal void StartScan() { }

	// RVA: 0xF601DC
	internal ExpressionNode Parse() { }

	// RVA: 0xF6222C
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0xF621EC
	private ExpressionNode NodePop() { }

	// RVA: 0xF621A0
	private ExpressionNode NodePeek() { }

	// RVA: 0xF620F8
	private void NodePush(ExpressionNode node) { }

	// RVA: 0xF61D98
	private void BuildExpression(int pri) { }

	// RVA: 0xF620A4
	internal void CheckToken(Tokens token) { }

	// RVA: 0xF616EC
	internal Tokens Scan() { }

	// RVA: 0xF629E0
	private void ScanNumeric() { }

	// RVA: 0xF62DC4
	private void ScanName() { }

	// RVA: 0xF62854
	private void ScanName(Char chEnd, Char esc, string charsToEscape) { }

	// RVA: 0xF626AC
	private void ScanDate() { }

	// RVA: 0xF62B20
	private void ScanBinaryConstant() { }

	// RVA: 0xF62B34
	private void ScanReserved() { }

	// RVA: 0xF6276C
	private void ScanString(Char escape) { }

	// RVA: 0xF62048
	internal void ScanToken(Tokens token) { }

	// RVA: 0xF62640
	private void ScanWhite() { }

	// RVA: 0xF62E50
	private bool IsWhiteSpace(Char ch) { }

	// RVA: 0xF62D78
	private bool IsAlphaNumeric(Char ch) { }

	// RVA: 0xF62B24
	private bool IsDigit(Char ch) { }

	// RVA: 0xF62E30
	private bool IsAlpha(Char ch) { }

	// RVA: 0xF62E60
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

	// RVA: 0xF6331C
	internal void .ctor(Nodes type, int op, int pri) { }

}

// Namespace: System.Data
[Serializable]
public class InvalidExpressionException
{
	// Methods

	// RVA: 0xF6335C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF63364
	public void .ctor() { }

	// RVA: 0xF6336C
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class EvaluateException
{
	// Methods

	// RVA: 0xF63374
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF6337C
	public void .ctor() { }

	// RVA: 0xF63384
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class SyntaxErrorException
{
	// Methods

	// RVA: 0xF6338C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF63394
	public void .ctor() { }

	// RVA: 0xF6339C
	public void .ctor(string s) { }

}

// Namespace: System.Data
internal sealed class ExprException
{
	// Methods

	// RVA: 0xF633A4
	private static OverflowException _Overflow(string error) { }

	// RVA: 0xF63418
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0xF6348C
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0xF63500
	private static EvaluateException _Eval(string error) { }

	// RVA: 0xF63574
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0xF635E8
	public static Exception InvokeArgument() { }

	// RVA: 0xF63630
	public static Exception NYI(string moreinfo) { }

	// RVA: 0xF636E0
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0xF638BC
	public static Exception MissingOperator(string token) { }

	// RVA: 0xF6396C
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0xF63A1C
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0xF63A88
	public static Exception ExpressionTooComplex() { }

	// RVA: 0xF63B24
	public static Exception UnboundName(string name) { }

	// RVA: 0xF63BD4
	public static Exception InvalidString(string str) { }

	// RVA: 0xF63C84
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0xF63D34
	public static Exception SyntaxError() { }

	// RVA: 0xF63DD0
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0xF63E80
	public static Exception MissingRightParen() { }

	// RVA: 0xF63F1C
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0xF64018
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0xF64174
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0xF6425C
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0xF64344
	public static Exception InvalidName(string name) { }

	// RVA: 0xF643F4
	public static Exception InvalidDate(string date) { }

	// RVA: 0xF644A4
	public static Exception NonConstantArgument() { }

	// RVA: 0xF64540
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0xF645F0
	public static Exception InWithoutParentheses() { }

	// RVA: 0xF6468C
	public static Exception InWithoutList() { }

	// RVA: 0xF64728
	public static Exception InvalidIsSyntax() { }

	// RVA: 0xF647C4
	public static Exception Overflow(Type type) { }

	// RVA: 0xF6488C
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0xF649AC
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0xF64AA8
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0xF64BEC
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0xF64D30
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0xF64E0C
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0xF64EBC
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0xF64F6C
	public static Exception TooManyRightParentheses() { }

	// RVA: 0xF65008
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0xF650C0
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0xF65170
	public static Exception AggregateArgument() { }

	// RVA: 0xF6520C
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0xF652BC
	public static Exception EvalNoContext() { }

	// RVA: 0xF65358
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0xF65408
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0xF654B8
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0xF65568
	public static Exception LookupArgument() { }

	// RVA: 0xF65604
	public static Exception InvalidType(string typeName) { }

	// RVA: 0xF656B4
	public static Exception InvalidHoursArgument() { }

	// RVA: 0xF65750
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0xF657EC
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0xF65888
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0xF65924
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

	// RVA: 0xF65998
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0xF659E8
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF65C6C
	internal override object Eval() { }

	// RVA: 0xF65C98
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF65DB8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF65DF0
	internal override bool IsConstant() { }

	// RVA: 0xF65DF8
	internal override bool IsTableConstant() { }

	// RVA: 0xF65E00
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF65E08
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF65E10
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF65E20
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

	// RVA: 0xF65E24
	internal void .ctor(DataTable table, Char[] text, int start, int pos) { }

	// RVA: 0xF660C8
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xF660FC
	internal override bool get_IsSqlColumn() { }

	// RVA: 0xF6611C
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF6634C
	internal override object Eval() { }

	// RVA: 0xF66378
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF66420
	internal override object Eval(int[] records) { }

	// RVA: 0xF66458
	internal override bool IsConstant() { }

	// RVA: 0xF66460
	internal override bool IsTableConstant() { }

	// RVA: 0xF664B8
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF66510
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF66568
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF665D0
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF65E78
	internal static string ParseName(Char[] text, int start, int pos) { }

}

// Namespace: System.Data
internal sealed class Operators
{
	// Fields
	private static readonly int[] s_priority; // 0x0
	private static readonly string[] s_looks; // 0x8

	// Methods

	// RVA: 0xF665D4
	internal static bool IsArithmetical(int op) { }

	// RVA: 0xF665F0
	internal static bool IsLogical(int op) { }

	// RVA: 0xF66610
	internal static bool IsRelational(int op) { }

	// RVA: 0xF66620
	internal static int Priority(int op) { }

	// RVA: 0xF637C8
	internal static string ToString(int op) { }

	// RVA: 0xF66700
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class UnaryNode
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0xF66FA0
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0xF66FE4
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF67038
	internal override object Eval() { }

	// RVA: 0xF6704C
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF67780
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF67090
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0xF677A4
	internal override bool IsConstant() { }

	// RVA: 0xF677C8
	internal override bool IsTableConstant() { }

	// RVA: 0xF677EC
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF67810
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF67834
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF6785C
	internal override ExpressionNode Optimize() { }

}

// Namespace: System.Data
internal sealed class ZeroOpNode
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0xF6792C
	internal void .ctor(int op) { }

	// RVA: 0xF6795C
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF67960
	internal override object Eval() { }

	// RVA: 0xF67A5C
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF67A68
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF67A74
	internal override bool IsConstant() { }

	// RVA: 0xF67A7C
	internal override bool IsTableConstant() { }

	// RVA: 0xF67A84
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF67A8C
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF67A94
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

	// RVA: 0xF67A98
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF67AE4
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF67CC8
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0xF67D74
	internal DataKey get_ChildKey() { }

	// RVA: 0xF67D9C
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0xF67DC8
	public override DataTable get_Table() { }

	// RVA: 0xF67DF4
	internal string[] get_ParentColumnNames() { }

	// RVA: 0xF67E00
	internal string[] get_ChildColumnNames() { }

	// RVA: 0xF67E0C
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xF67F34
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xF67F3C
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0xF67FF8
	internal override bool IsConstraintViolated() { }

	// RVA: 0xF68760
	internal override bool CanEnableConstraint() { }

	// RVA: 0xF689F8
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0xF68BD4
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0xF69254
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0xF694B4
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0xF699F0
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0xF69AD4
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0xF69BB0
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0xF69CE0
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0xF6A010
	private void NonVirtualCheckState() { }

	// RVA: 0xF6A270
	internal override void CheckState() { }

	// RVA: 0xF6A274
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0xF6A29C
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0xF6A2FC
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF6A348
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xF6A358
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xF6AB48
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0xF67B34
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF6B1C0
	public virtual Rule get_DeleteRule() { }

	// RVA: 0xF6B1E8
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0xF6B248
	public override bool Equals(object key) { }

	// RVA: 0xF6B364
	public override int GetHashCode() { }

	// RVA: 0xF6B36C
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0xF6AB20
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0xF69B88
	internal DataKey get_ParentKey() { }

	// RVA: 0xF6B398
	internal DataRelation FindParentRelation() { }

	// RVA: 0xF6B470
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0xF6B49C
	public virtual Rule get_UpdateRule() { }

	// RVA: 0xF6B4C4
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

	// RVA: 0xF6B524
	public void .ctor(DataTable table, string conflict) { }

	// RVA: 0xF6B5B8
	public string get_Conflict() { }

}

// Namespace: System.Data
public sealed class MergeFailedEventHandler
{
	// Methods

	// RVA: 0xF6B5C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF6B6E4
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

	// RVA: 0xF6B6F8
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF6B750
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF6B7B0
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0xF6D464
	internal void MergeTable(DataTable src) { }

	// RVA: 0xF6D6E4
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0xF6DD48
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0xF6C778
	private void MergeTableData(DataTable src) { }

	// RVA: 0xF6C830
	private void MergeConstraints(DataSet source) { }

	// RVA: 0xF6E494
	private void MergeConstraints(DataTable table) { }

	// RVA: 0xF6C8AC
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0xF6D1DC
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0xF6DBC4
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

	// RVA: 0xF6E750
	public void .ctor() { }

	// RVA: 0xF6E804
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xF6E80C
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF6E8D8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Data
[Serializable]
public class PropertyCollection
{
	// Methods

	// RVA: 0xF6EB0C
	public void .ctor() { }

	// RVA: 0xF6EB14
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF6EB1C
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

	// RVA: 0xF6EE1C
	public void .ctor(int min, int max) { }

	// RVA: 0xF69144
	public int get_Count() { }

	// RVA: 0xF68BC4
	public bool get_IsNull() { }

	// RVA: 0xF69164
	public int get_Min() { }

	// RVA: 0xF6EE74
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

	// RVA: 0x30B2A58
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

	// RVA: 0x30B29E8
	internal void .ctor(int size) { }

	// RVA: 0x30B1ACC
	internal int AllocSlot(System.Data.RBTree<K> tree) { }

	// RVA: 0x30B199C
	internal int get_InUseCount() { }

	// RVA: 0x30B29E8
	internal void set_InUseCount(int value) { }

	// RVA: 0x30B199C
	internal int get_PageId() { }

	// RVA: 0x30B29E8
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

	// RVA: 0x30B2CB8
	internal void .ctor(System.Data.RBTree<K> tree) { }

	// RVA: 0x30B2D20
	internal void .ctor(System.Data.RBTree<K> tree, int position) { }

	// RVA: 0x30B2870
	public void Dispose() { }

	// RVA: 0x30B171C
	public bool MoveNext() { }

	// RVA: 0x316B894
	public K get_Current() { }

	// RVA: 0x30B1CD4
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30B2870
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

	// RVA: 0x30B29E8
	protected void .ctor(TreeAccessMethod accessMethod) { }

	// RVA: 0x30B2870
	private void InitTree() { }

	// RVA: 0x30B2CB8
	private void FreePage(TreePage page) { }

	// RVA: -1
	private TreePage AllocPage(int size) { }

	// RVA: 0x30B2CB8
	private void MarkPageFull(TreePage page) { }

	// RVA: 0x30B2CB8
	private void MarkPageFree(TreePage page) { }

	// RVA: 0x316B894
	private static int GetIntValueFromBitMap(UInt32 bitMap) { }

	// RVA: 0x30B29E8
	private void FreeNode(int nodeId) { }

	// RVA: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }

	// RVA: 0x30B199C
	public int get_Count() { }

	// RVA: 0x30B171C
	public bool get_HasDuplicates() { }

	// RVA: 0x316B894
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

	// RVA: 0x316B894
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }

	// RVA: 0x316B894
	public void UpdateNodeKey(K currentKey, K newKey) { }

	// RVA: 0x316B894
	public K DeleteByIndex(int i) { }

	// RVA: -1
	public int RBDelete(int z_id) { }

	// RVA: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }

	// RVA: 0x316B894
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }

	// RVA: 0x316B894
	private int SearchSubTree(int root_id, K key) { }

	// RVA: 0x316B894
	public K get_Item(int index) { }

	// RVA: 0x316B894
	private NodePath GetNodeByKey(K key) { }

	// RVA: 0x316B894
	public int GetIndexByKey(K key) { }

	// RVA: -1
	public int GetIndexByNode(int node) { }

	// RVA: 0x316B894
	private int GetIndexByNodePath(NodePath path) { }

	// RVA: -1
	private int ComputeIndexByNode(int nodeId) { }

	// RVA: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }

	// RVA: 0x316B894
	private NodePath GetNodeByIndex(int userIndex) { }

	// RVA: -1
	private int ComputeNodeByIndex(int index, int satelliteRootId) { }

	// RVA: 0x30B19D0
	private int ComputeNodeByIndex(int x_id, int index) { }

	// RVA: 0x316B894
	public int Insert(K item) { }

	// RVA: 0x316B894
	public int Add(K item) { }

	// RVA: 0x30B1CD4
	public IEnumerator GetEnumerator() { }

	// RVA: 0x316B894
	public int IndexOf(int nodeId, K item) { }

	// RVA: 0x316B894
	public int Insert(int position, K item) { }

	// RVA: 0x316B894
	public int InsertAt(int position, K item, bool append) { }

	// RVA: 0x30B29E8
	public void RemoveAt(int position) { }

	// RVA: 0x30B2870
	public void Clear() { }

	// RVA: 0x30B2D20
	public void CopyTo(Array array, int index) { }

	// RVA: 0x30B2D20
	public void CopyTo(K[] array, int index) { }

	// RVA: 0x30B2A58
	private void SetRight(int nodeId, int rightNodeId) { }

	// RVA: 0x30B2A58
	private void SetLeft(int nodeId, int leftNodeId) { }

	// RVA: 0x30B2A58
	private void SetParent(int nodeId, int parentNodeId) { }

	// RVA: 0x316B894
	private void SetColor(int nodeId, NodeColor color) { }

	// RVA: 0x316B894
	private void SetKey(int nodeId, K key) { }

	// RVA: 0x30B2A58
	private void SetNext(int nodeId, int nextNodeId) { }

	// RVA: 0x30B2A58
	private void SetSubTreeSize(int nodeId, int size) { }

	// RVA: 0x30B29E8
	private void IncreaseSize(int nodeId) { }

	// RVA: 0x30B29E8
	private void RecomputeSize(int nodeId) { }

	// RVA: 0x30B29E8
	private void DecreaseSize(int nodeId) { }

	// RVA: -1
	public int Right(int nodeId) { }

	// RVA: -1
	public int Left(int nodeId) { }

	// RVA: -1
	public int Parent(int nodeId) { }

	// RVA: 0x316B894
	private NodeColor color(int nodeId) { }

	// RVA: -1
	public int Next(int nodeId) { }

	// RVA: -1
	public int SubTreeSize(int nodeId) { }

	// RVA: 0x316B894
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

	// RVA: 0xF6EEB8
	internal void .ctor(DataTable table) { }

	// RVA: 0xF6EF9C
	private void GrowRecordCapacity() { }

	// RVA: 0xF6F194
	internal int get_LastFreeRecord() { }

	// RVA: 0xF6F19C
	internal int get_MinimumCapacity() { }

	// RVA: 0xF6F1A4
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0xF6F1F4
	internal int get_RecordCapacity() { }

	// RVA: 0xF6F0F8
	internal void set_RecordCapacity(int value) { }

	// RVA: 0xF6F0B0
	internal static int NewCapacity(int capacity) { }

	// RVA: 0xF6F0C4
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0xF6F1FC
	internal int NewRecordBase() { }

	// RVA: 0xF6F2E4
	internal void FreeRecord(int record) { }

	// RVA: 0xF6F494
	internal void Clear(bool clearAll) { }

	// RVA: 0xF6F704
	internal DataRow get_Item(int record) { }

	// RVA: 0xF6F420
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0xF6F738
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0xF6F740
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0xF6FB84
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

	// RVA: 0xF6FBC8
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0xF6FD10
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0xF6FE54
	private object[] GetParentValues() { }

	// RVA: 0xF6FF0C
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xF700A0
	internal override IFilter GetFilter() { }

	// RVA: 0xF700A4
	public override DataRowView AddNew() { }

	// RVA: 0xF70108
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

// Namespace: System.Data
internal sealed class RelationshipConverter
{
	// Methods

	// RVA: 0xF70138
	public void .ctor() { }

	// RVA: 0xF70140
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF7020C
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

	// RVA: 0xF70E34
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0xF70E60
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0xF70E74
	public override bool Equals(object obj) { }

	// RVA: 0xF70F14
	public override int GetHashCode() { }

}

// Namespace: 
private sealed class IndexTree
{
	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0xF73F24
	internal void .ctor(Index index) { }

	// RVA: 0xF74C24
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0xF74C40
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

	// RVA: 0xF74C5C
	private static void .cctor() { }

	// RVA: 0xF74CC8
	public void .ctor() { }

	// RVA: 0xF74CD0
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0xF74CDC
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

}

// Namespace: 
private sealed class <>c__DisplayClass86_0
{
	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0xF741AC
	public void .ctor() { }

	// RVA: 0xF74CFC
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

	// RVA: 0xF70F9C
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF71300
	public void .ctor(DataTable table, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF71364
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0xF70FAC
	private void .ctor(DataTable table, IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF71884
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF71924
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0xF7192C
	internal int get_ObjectID() { }

	// RVA: 0xF71934
	public DataViewRowState get_RecordStates() { }

	// RVA: 0xF7193C
	public IFilter get_RowFilter() { }

	// RVA: 0xF719B8
	public int GetRecord(int recordIndex) { }

	// RVA: 0xF71A30
	public bool get_HasDuplicates() { }

	// RVA: 0xF71A84
	public int get_RecordCount() { }

	// RVA: 0xF71A8C
	private bool AcceptRecord(int record) { }

	// RVA: 0xF71B3C
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0xF71D58
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0xF71DBC
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0xF71E20
	public int get_RefCount() { }

	// RVA: 0xF71E28
	public void AddRef() { }

	// RVA: 0xF72008
	public int RemoveRef() { }

	// RVA: 0xF72208
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0xF7287C
	public bool CheckUnique() { }

	// RVA: 0xF728D8
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xF72A80
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0xF72AE8
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0xF72C90
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0xF72D74
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0xF72800
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0xF72D7C
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0xF73120
	public RBTreeEnumerator GetEnumerator(int startIndex) { }

	// RVA: 0xF72808
	public int GetIndex(int record) { }

	// RVA: 0xF72658
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0xF68344
	public object[] GetUniqueKeyValues() { }

	// RVA: 0xF73398
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0xF735DC
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0xF73864
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0xF73974
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0xF73AB0
	public Range FindRecords(object key) { }

	// RVA: 0xF684D0
	public Range FindRecords(object[] key) { }

	// RVA: 0xF73AE0
	internal void FireResetEvent() { }

	// RVA: 0xF73EAC
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF73EC8
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0xF691AC
	public DataRow GetRow(int i) { }

	// RVA: 0xF73EE8
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0xF68500
	public DataRow[] GetRows(Range range) { }

	// RVA: 0xF71464
	private void InitRecords(IFilter filter) { }

	// RVA: 0xF73F90
	public int InsertRecordToIndex(int record) { }

	// RVA: 0xF72398
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0xF74064
	public bool IsKeyInIndex(object key) { }

	// RVA: 0xF684B4
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0xF74080
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0xF73C54
	private bool get_DoListChanged() { }

	// RVA: 0xF7409C
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0xF73024
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0xF73CDC
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF72ED4
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0xF741B4
	public void Reset() { }

	// RVA: 0xF74310
	public void RecordChanged(int record) { }

	// RVA: 0xF744AC
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0xF74610
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF74744
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0xF74C1C
	internal DataTable get_Table() { }

	// RVA: 0xF73194
	private void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId) { }

	// RVA: 0x316B894
	internal static int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

}

// Namespace: 
internal sealed class Action<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

}

// Namespace: 
internal sealed class Func<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
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

	// RVA: 0x30B2B50
	internal void .ctor(int ObjectID, System.Data.Listeners.Func<TElem,TElem,System.Boolean> notifyFilter) { }

	// RVA: 0x30B171C
	internal bool get_HasListeners() { }

	// RVA: 0x316B894
	internal void Add(TElem listener) { }

	// RVA: 0x316B894
	internal int IndexOfReference(TElem listener) { }

	// RVA: 0x316B894
	internal void Remove(TElem listener) { }

	// RVA: 0x316B894
	internal void Notify(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem,TElem,T1,T2,T3> action) { }

	// RVA: 0x30B29E8
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

	// RVA: 0xF74D2C
	internal void .ctor(string baseType) { }

	// RVA: 0xF74E64
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0xF75A10
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF75058
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0xF75A50
	internal bool IsPlainString() { }

	// RVA: 0xF75B94
	internal string get_BaseType() { }

	// RVA: 0xF75B9C
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0xF75BA4
	internal string get_Name() { }

	// RVA: 0xF75BAC
	internal string get_Namespace() { }

	// RVA: 0xF75BB4
	internal int get_Length() { }

	// RVA: 0xF75BBC
	internal int get_MaxLength() { }

	// RVA: 0xF75BC4
	internal void set_MaxLength(int value) { }

	// RVA: 0xF75BCC
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0xF75BD4
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0xF75C48
	internal string QualifiedName(string name) { }

	// RVA: 0xF75CC8
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0xF761CC
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0xF7625C
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0xF762D0
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0xF76354
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0xF76460
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0xF765AC
	internal bool CanHaveMaxLength() { }

	// RVA: 0xF76614
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

	// RVA: 0xF766C4
	public void .ctor(DataColumn column) { }

	// RVA: 0xF76880
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0xF768C0
	public void .ctor(DataColumn[] columns) { }

	// RVA: 0xF768F4
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0xF76950
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0xF76998
	internal string[] get_ColumnNames() { }

	// RVA: 0xF769A4
	internal Index get_ConstraintIndex() { }

	// RVA: 0xF769AC
	internal void ConstraintIndexClear() { }

	// RVA: 0xF769EC
	internal void ConstraintIndexInitialize() { }

	// RVA: 0xF76A48
	internal override void CheckState() { }

	// RVA: 0xF76A54
	private void NonVirtualCheckState() { }

	// RVA: 0xF76A60
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xF76A64
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xF76BF8
	internal override bool CanEnableConstraint() { }

	// RVA: 0xF76C88
	internal override bool IsConstraintViolated() { }

	// RVA: 0xF76F1C
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xF77020
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF7702C
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xF7703C
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xF775F8
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0xF77B10
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0xF77018
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF77B1C
	public bool get_IsPrimaryKey() { }

	// RVA: 0xF76784
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0xF77B6C
	public override bool Equals(object key2) { }

	// RVA: 0xF77C24
	public override int GetHashCode() { }

	// RVA: 0xF77C2C
	internal override void set_InCollection(bool value) { }

	// RVA: 0xF77C78
	internal DataKey get_Key() { }

	// RVA: 0xF77C80
	public override DataTable get_Table() { }

}

// Namespace: 
private sealed class NameType
{
	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0xF7B894
	public void .ctor(string n, Type t) { }

	// RVA: 0xF7B8E4
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

	// RVA: 0xF77CC4
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0xF77D6C
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0xF781B8
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0xF7850C
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0xF7871C
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0xF77FE8
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0xF79198
	private static NameType FindNameType(string name) { }

	// RVA: 0xF7929C
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0xF79400
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0xF79584
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0xF7889C
	internal void GetMinMax(XmlElement elNode, int minOccurs, int maxOccurs) { }

	// RVA: 0xF79F3C
	internal void GetMinMax(XmlElement elNode, bool isAttribute, int minOccurs, int maxOccurs) { }

	// RVA: 0xF7A298
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0xF78AE8
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0xF788AC
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0xF7A494
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

	// RVA: 0xF7B960
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0xF7C278
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xF7C5F0
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0xF7BB18
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0xF7C80C
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0xF7BED0
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0xF7CB98
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0xF7E044
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0xF7D0B4
	private int ReadOldRowData(DataSet ds, DataTable table, int pos, XmlReader row) { }

	// RVA: 0xF7D048
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0xF7E22C
	public void .ctor() { }

}

// Namespace: System.Data
internal class XMLSchema
{
	// Methods

	// RVA: 0xF7E234
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0xF7E2BC
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xF7E75C
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0xF7E7E8
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0xF7E974
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0xF7EAA0
	public void .ctor() { }

}

// Namespace: System.Data
internal sealed class ConstraintTable
{
	// Fields
	public DataTable table; // 0x10
	public XmlSchemaIdentityConstraint constraint; // 0x18

	// Methods

	// RVA: 0xF7EAA8
	public void .ctor(DataTable t, XmlSchemaIdentityConstraint c) { }

}

// Namespace: 
private sealed class NameType
{
	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0xF8FD24
	public void .ctor(string n, Type t) { }

	// RVA: 0xF8FD74
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

	// RVA: 0xF7EAF8
	internal bool get_FromInference() { }

	// RVA: 0xF7EB00
	internal void set_FromInference(bool value) { }

	// RVA: 0xF7EB08
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0xF7EB94
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0xF7F68C
	internal static string QualifiedName(string name) { }

	// RVA: 0xF7F70C
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF7FCB8
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF80078
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF7F564
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0xF80284
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xF804CC
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0xF806B8
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0xF80F30
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xF81188
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0xF81B94
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0xF81F5C
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0xF82550
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0xF82578
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0xF85CEC
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0xF81708
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0xF86028
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0xF878FC
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0xF88688
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0xF88A3C
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0xF82418
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0xF8A2B8
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0xF8A43C
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0xF81DAC
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0xF8459C
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0xF8A764
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0xF8A800
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0xF8A91C
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0xF8B304
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0xF8B7B8
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0xF805B8
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0xF8C3F8
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0xF8DAEC
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0xF8DBF8
	private static NameType FindNameType(string name) { }

	// RVA: 0xF8DCFC
	private Type ParseDataType(string dt) { }

	// RVA: 0xF8DEEC
	internal static bool IsXsdType(string name) { }

	// RVA: 0xF84648
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0xF897EC
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xF8903C
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xF87BCC
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0xF86970
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0xF84B0C
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0xF8DF68
	private void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, DataTable dt) { }

	// RVA: 0xF8BFF4
	private string GetPrefix(string ns) { }

	// RVA: 0xF8E1B8
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0xF8D95C
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xF8B1D4
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xF81934
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0xF84960
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0xF8E5C4
	public void .ctor() { }

	// RVA: 0xF8E5CC
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class XmlIgnoreNamespaceReader
{
	// Fields
	private System.Collections.Generic.List<System.String> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0xF8FDF0
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0xF8FE94
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xF8FFA0
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

	// RVA: 0xF900E4
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xF9018C
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xF9028C
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xF9034C
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xF90464
	internal bool get_FromInference() { }

	// RVA: 0xF9046C
	internal void set_FromInference(bool value) { }

	// RVA: 0xF90474
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xF906F4
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0xF908EC
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0xF90BE0
	private string GetInitialTextFromNodes(XmlNode n) { }

	// RVA: 0xF90E94
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0xF90650
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0xF90F68
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0xF90850
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0xF91080
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0xF913B4
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0xF90B84
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0xF90F30
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0xF91454
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0xF918E8
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0xF92538
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xF928F0
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0xF9296C
	private void InitNameTable() { }

	// RVA: 0xF92C78
	internal void LoadData(XmlReader reader) { }

	// RVA: 0xF93128
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0xF93E58
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0xF94E3C
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0xF93C0C
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

	// RVA: 0xF98248
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0xF98298
	public override int GetHashCode() { }

	// RVA: 0xF982BC
	public override bool Equals(object obj) { }

}

// Namespace: 
internal sealed class XmlNodeIdHashtable
{
	// Fields
	private XmlNodeIdentety _id; // 0x50

	// Methods

	// RVA: 0xF98364
	public void .ctor(int capacity) { }

	// RVA: 0xF9842C
	public object get_Item(XmlNode node) { }

	// RVA: 0xF984C8
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0xF9855C
	public object get_Item(DataTable table) { }

	// RVA: 0xF985E8
	public object get_Item(string name) { }

}

// Namespace: 
private sealed class TableSchemaInfo
{
	// Fields
	public DataTable TableSchema; // 0x10
	public XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0xF98680
	public void .ctor(DataTable tableSchema) { }

}

// Namespace: System.Data
internal sealed class XmlToDatasetMap
{
	// Fields
	private XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0xF917B4
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xF930A8
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xF91774
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xF930E8
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xF9293C
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0xF976B8
	private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0xF977F8
	private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0xF97994
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	// RVA: 0xF97C30
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns) { }

	// RVA: 0xF9588C
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xF95E68
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xF96908
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xF96C5C
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xF97DFC
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0xF91170
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xF94CD8
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0xF917F4
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xF93B18
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0xF97ACC
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

	// RVA: 0xF9872C
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0xF987DC
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0xF987E4
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0xF98F28
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xF990E4
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xF99A18
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0xF9AA9C
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0xF9AF90
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0xF9B090
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0xF9B368
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0xF9B394
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0xF9B544
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0xF9B7B8
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0xF9B868
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0xF9C5CC
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0xF9BB3C
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0xF9CCFC
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xF9D074
	private void CreateRelations(DataTable dt) { }

	// RVA: 0xF9D3BC
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0xF9D6E8
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0xFA0F1C
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0xFA0220
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0xFA4164
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0xFA4484
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0xFA44A4
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0xFA4498
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0xFA4570
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0xFA4578
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xFA0950
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0xFA46DC
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0xFA47D8
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0xFA4A7C
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0xFA5000
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0xFA5608
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0xFA5734
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0xFA6528
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0xFA65B0
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0xFA0894
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0xFA634C
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0xFA088C
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0xFA6698
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0xF9C6C8
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0xFA6A48
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0xF9CC24
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0xF9CC18
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0xFA6B28
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0xFA6C78
	private bool IsAutoGenerated(object o) { }

	// RVA: 0xFA13F8
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0xF9A840
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

	// RVA: 0xFA6D3C
	internal void .ctor(DataSet ds) { }

	// RVA: 0xFA7114
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xFA723C
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0xFA6E90
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0xFA75B4
	private bool EmptyData() { }

	// RVA: 0xFA76AC
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0xFA76B4
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0xFA884C
	private void GenerateTable(DataTable table) { }

	// RVA: 0xFA88CC
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0xFA8E70
	private void GenerateRow(DataRow row) { }

	// RVA: 0xFA9554
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0xFA6CC4
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

	// RVA: 0xFA84E8
	internal void .ctor(DataSet ds) { }

	// RVA: 0xFA7C24
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xFAA3D8
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0xFAA060
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xFA945C
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0xFA7DD8
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0xFAC130
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0xFACA3C
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0xFAA704
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0xFA9F84
	internal static bool PreserveSpace(object value) { }

}

// Namespace: System.Data
internal sealed class DataTextWriter
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Methods

	// RVA: 0xFA7BB0
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0xFACD78
	private void .ctor(XmlWriter w) { }

	// RVA: 0xFA43F8
	internal Stream get_BaseStream() { }

	// RVA: 0xFACDAC
	public override void WriteStartDocument() { }

	// RVA: 0xFACDD0
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xFACDF4
	public override void WriteEndDocument() { }

	// RVA: 0xFACE18
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xFACE3C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xFACE60
	public override void WriteEndElement() { }

	// RVA: 0xFACE84
	public override void WriteFullEndElement() { }

	// RVA: 0xFACEA8
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xFACECC
	public override void WriteEndAttribute() { }

	// RVA: 0xFACEF4
	public override void WriteCData(string text) { }

	// RVA: 0xFACF1C
	public override void WriteComment(string text) { }

	// RVA: 0xFACF44
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xFACF6C
	public override void WriteEntityRef(string name) { }

	// RVA: 0xFACF94
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0xFACFBC
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xFACFE4
	public override void WriteString(string text) { }

	// RVA: 0xFAD00C
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0xFAD034
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0xFAD05C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0xFAD084
	public override void WriteRaw(string data) { }

	// RVA: 0xFAD0AC
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0xFAD0D4
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0xFAD0FC
	public override WriteState get_WriteState() { }

	// RVA: 0xFAD124
	public override void Close() { }

	// RVA: 0xFAD14C
	public override void Flush() { }

	// RVA: 0xFAD174
	public override string LookupPrefix(string ns) { }

}

// Namespace: System.Data
internal sealed class DataTextReader
{
	// Fields
	private XmlReader _xmlreader; // 0x10

	// Methods

	// RVA: 0xFAD19C
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0xFAD24C
	private void .ctor(XmlReader input) { }

	// RVA: 0xFAD2C4
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xFAD2E8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xFAD30C
	public override string get_Name() { }

	// RVA: 0xFAD330
	public override string get_LocalName() { }

	// RVA: 0xFAD354
	public override string get_NamespaceURI() { }

	// RVA: 0xFAD378
	public override string get_Prefix() { }

	// RVA: 0xFAD39C
	public override string get_Value() { }

	// RVA: 0xFAD3C0
	public override int get_Depth() { }

	// RVA: 0xFAD3E4
	public override string get_BaseURI() { }

	// RVA: 0xFAD40C
	public override bool get_IsEmptyElement() { }

	// RVA: 0xFAD434
	public override bool get_IsDefault() { }

	// RVA: 0xFAD45C
	public override Char get_QuoteChar() { }

	// RVA: 0xFAD484
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xFAD4AC
	public override string get_XmlLang() { }

	// RVA: 0xFAD4D4
	public override int get_AttributeCount() { }

	// RVA: 0xFAD4FC
	public override string GetAttribute(string name) { }

	// RVA: 0xFAD524
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xFAD54C
	public override string GetAttribute(int i) { }

	// RVA: 0xFAD574
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xFAD59C
	public override void MoveToAttribute(int i) { }

	// RVA: 0xFAD5C4
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xFAD5EC
	public override bool MoveToNextAttribute() { }

	// RVA: 0xFAD614
	public override bool MoveToElement() { }

	// RVA: 0xFAD63C
	public override bool ReadAttributeValue() { }

	// RVA: 0xFAD664
	public override bool Read() { }

	// RVA: 0xFAD68C
	public override bool get_EOF() { }

	// RVA: 0xFAD6B4
	public override void Close() { }

	// RVA: 0xFAD6DC
	public override ReadState get_ReadState() { }

	// RVA: 0xFAD704
	public override void Skip() { }

	// RVA: 0xFAD72C
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xFAD754
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xFAD77C
	public override bool get_CanResolveEntity() { }

	// RVA: 0xFAD7A4
	public override void ResolveEntity() { }

	// RVA: 0xFAD7CC
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xFAD7F4
	public override string ReadString() { }

}

// Namespace: System.Data.SqlTypes
internal static class SQLResource
{
	// Methods

	// RVA: 0xFAD81C
	internal static string get_NullString() { }

	// RVA: 0xFAD860
	internal static string get_ArithOverflowMessage() { }

	// RVA: 0xFAD8A4
	internal static string get_DivideByZeroMessage() { }

	// RVA: 0xFAD8E8
	internal static string get_NullValueMessage() { }

	// RVA: 0xFAD92C
	internal static string get_TruncationMessage() { }

	// RVA: 0xFAD970
	internal static string get_DateTimeOverflowMessage() { }

	// RVA: 0xFAD9B4
	internal static string get_ConcatDiffCollationMessage() { }

	// RVA: 0xFAD9F8
	internal static string get_CompareDiffCollationMessage() { }

	// RVA: 0xFADA3C
	internal static string get_ConversionOverflowMessage() { }

	// RVA: 0xFADA80
	internal static string get_TimeZoneSpecifiedMessage() { }

	// RVA: 0xFADAC4
	internal static string get_InvalidPrecScaleMessage() { }

	// RVA: 0xFADB08
	internal static string get_FormatMessage() { }

	// RVA: 0xFADB4C
	internal static string InvalidOpStreamClosed(string method) { }

	// RVA: 0xFADBA4
	internal static string InvalidOpStreamNonWritable(string method) { }

	// RVA: 0xFADBFC
	internal static string InvalidOpStreamNonReadable(string method) { }

	// RVA: 0xFADC54
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

	// RVA: 0xFADCAC
	private void .ctor(bool fNull) { }

	// RVA: 0xFADCB8
	public void .ctor(Byte[] value) { }

	// RVA: 0xFADD54
	public bool get_IsNull() { }

	// RVA: 0xFADD64
	public Byte[] get_Value() { }

	// RVA: 0xFADE54
	public static SqlBinary op_Implicit(Byte[] x) { }

	// RVA: 0xFADEFC
	public override string ToString() { }

	// RVA: 0xFAE03C
	private static EComparison PerformCompareByte(Byte[] x, Byte[] y) { }

	// RVA: 0xFAE158
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0xFAE288
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xFAE3A4
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xFAE4C0
	public int CompareTo(object value) { }

	// RVA: 0xFAE5E4
	public int CompareTo(SqlBinary value) { }

	// RVA: 0xFAE870
	public override bool Equals(object value) { }

	// RVA: 0xFAEA6C
	internal static int HashByteArray(Byte[] rgbValue, int length) { }

	// RVA: 0xFAEAD4
	public override int GetHashCode() { }

	// RVA: 0xFAEC18
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFAEC20
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFAEE44
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFAEF88
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFAF018
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

	// RVA: 0xFAE274
	public void .ctor(bool value) { }

	// RVA: 0xFAF090
	public void .ctor(int value) { }

	// RVA: 0xFAF100
	private void .ctor(int value, bool fNull) { }

	// RVA: 0xFAF11C
	public bool get_IsNull() { }

	// RVA: 0xFAEA08
	public bool get_Value() { }

	// RVA: 0xFAF12C
	public bool get_IsTrue() { }

	// RVA: 0xFAF13C
	public bool get_IsFalse() { }

	// RVA: 0xFAF14C
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0xFAE808
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0xFAF15C
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFAF258
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFAF33C
	public Byte get_ByteValue() { }

	// RVA: 0xFAF3F0
	public override string ToString() { }

	// RVA: 0xFAF540
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFAF628
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFAF764
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFAF8B8
	public int CompareTo(object value) { }

	// RVA: 0xFAF9DC
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0xFAFB38
	public override bool Equals(object value) { }

	// RVA: 0xFAFCC4
	public override int GetHashCode() { }

	// RVA: 0xFAFDEC
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFAFDF4
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFAFF38
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB0070
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB0100
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

	// RVA: 0xFB01F4
	private void .ctor(bool fNull) { }

	// RVA: 0xFB01FC
	public void .ctor(Byte value) { }

	// RVA: 0xFB020C
	public bool get_IsNull() { }

	// RVA: 0xFB021C
	public Byte get_Value() { }

	// RVA: 0xFB02B4
	public static SqlByte op_Implicit(Byte x) { }

	// RVA: 0xFB02C0
	public override string ToString() { }

	// RVA: 0xFB0358
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0xFB04AC
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0xFB05F8
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0xFB074C
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0xFB088C
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0xFB0A4C
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0xFB0B64
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFB0C7C
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFB0D94
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFB0E20
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFB0EAC
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFB1078
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFB11E8
	public int CompareTo(object value) { }

	// RVA: 0xFB130C
	public int CompareTo(SqlByte value) { }

	// RVA: 0xFB14B8
	public override bool Equals(object value) { }

	// RVA: 0xFB1630
	public override int GetHashCode() { }

	// RVA: 0xFB1724
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB172C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFB186C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB19B4
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB1A44
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

	// RVA: 0xFB1AC0
	public void .ctor() { }

	// RVA: 0xFB1B38
	public void .ctor(Byte[] buffer) { }

	// RVA: 0xFB1BBC
	public void .ctor(SqlBinary value) { }

	// RVA: 0xFB1CE0
	public bool get_IsNull() { }

	// RVA: 0xFB1CF0
	public Byte[] get_Buffer() { }

	// RVA: 0xFB1EA8
	public Int64 get_Length() { }

	// RVA: 0xFB1F24
	public Byte[] get_Value() { }

	// RVA: 0xFB1B00
	public void SetNull() { }

	// RVA: 0xFB1D34
	private void CopyStreamToBuffer() { }

	// RVA: 0xFB1D24
	internal bool FStream() { }

	// RVA: 0xFB214C
	private void SetBuffer(Byte[] buffer) { }

	// RVA: 0xFB21B0
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB21B8
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xFB2440
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB2574
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB2604
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFB2644
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

	// RVA: 0xFB26F4
	public void .ctor() { }

	// RVA: 0xFB276C
	public void .ctor(Char[] buffer) { }

	// RVA: 0xFB27F0
	public void .ctor(SqlString value) { }

	// RVA: 0xFB29BC
	public bool get_IsNull() { }

	// RVA: 0xFB29CC
	public Char[] get_Buffer() { }

	// RVA: 0xFB2B7C
	public Int64 get_Length() { }

	// RVA: 0xFB2BF8
	public Char[] get_Value() { }

	// RVA: 0xFB2734
	public void SetNull() { }

	// RVA: 0xFB2A00
	internal bool FStream() { }

	// RVA: 0xFB2A10
	private void CopyStreamToBuffer() { }

	// RVA: 0xFB2DE4
	private void SetBuffer(Char[] buffer) { }

	// RVA: 0xFB2E48
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB2E50
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xFB2FD8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB30E8
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB3178
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFB31B8
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

	// RVA: 0xFB3268
	private void .ctor(bool fNull) { }

	// RVA: 0xFB3274
	public void .ctor(DateTime value) { }

	// RVA: 0xFB340C
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0xFB3560
	public bool get_IsNull() { }

	// RVA: 0xFB3570
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0xFB361C
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0xFB3778
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0xFB32E4
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0xFB39E0
	public DateTime get_Value() { }

	// RVA: 0xFB3A90
	public int get_DayTicks() { }

	// RVA: 0xFB3AE4
	public int get_TimeTicks() { }

	// RVA: 0xFB3B38
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0xFB3BA0
	public override string ToString() { }

	// RVA: 0xFB3C94
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFB3DAC
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFB3ED0
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFB3FF4
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFB4074
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFB40F4
	public int CompareTo(object value) { }

	// RVA: 0xFB4208
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0xFB43D0
	public override bool Equals(object value) { }

	// RVA: 0xFB4560
	public override int GetHashCode() { }

	// RVA: 0xFB4660
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB4668
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFB489C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB4A0C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB4A9C
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

	// RVA: 0xFB4F40
	private Byte CalculatePrecision() { }

	// RVA: 0xFB51B8
	private bool VerifyPrecision(Byte precision) { }

	// RVA: 0xFB543C
	private void .ctor(bool fNull) { }

	// RVA: 0xFB54B0
	public void .ctor(Decimal value) { }

	// RVA: 0xFB56A8
	public void .ctor(int value) { }

	// RVA: 0xFB59C4
	public void .ctor(Int64 value) { }

	// RVA: 0xFB5EC0
	private void .ctor(UInt32[] rglData, Byte bLen, Byte bPrec, Byte bScale, bool fPositive) { }

	// RVA: 0xFB6224
	public bool get_IsNull() { }

	// RVA: 0xFB62A0
	public Decimal get_Value() { }

	// RVA: 0xFB650C
	public bool get_IsPositive() { }

	// RVA: 0xFB61B0
	private void SetPositive() { }

	// RVA: 0xFB6654
	private void SetSignBit(bool fPositive) { }

	// RVA: 0xFB670C
	public Byte get_Scale() { }

	// RVA: 0xFB682C
	public int[] get_Data() { }

	// RVA: 0xFB69B4
	public override string ToString() { }

	// RVA: 0xFB701C
	public static SqlDecimal Parse(string s) { }

	// RVA: 0xFB7BC8
	public Double ToDouble() { }

	// RVA: 0xFB6320
	private Decimal ToDecimal() { }

	// RVA: 0xFB7D9C
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0xFB7DB4
	public static SqlDecimal op_Implicit(Int64 x) { }

	// RVA: 0xFB7E2C
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0xFB80CC
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFB8E34
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFB8F18
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFB9AFC
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFBAB04
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0xFBABEC
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0xFBAD38
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0xFBAEF4
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0xFBAFEC
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0xFBAA84
	private static void ZeroToMaxLen(UInt32[] rgulData, int cUI4sCur) { }

	// RVA: 0xFB6190
	private bool FZero() { }

	// RVA: 0xFB8DCC
	private bool FGt10_38() { }

	// RVA: 0xFBB22C
	private bool FGt10_38(UInt32[] rglData) { }

	// RVA: 0xFB57AC
	private static Byte BGetPrecUI4(UInt32 value) { }

	// RVA: 0xFB5AB4
	private static Byte BGetPrecUI8(UInt64 dwlVal) { }

	// RVA: 0xFB7988
	private void AddULong(UInt32 ulAdd) { }

	// RVA: 0xFB76E8
	private void MultByULong(UInt32 uiMultiplier) { }

	// RVA: 0xFBB30C
	private UInt32 DivByULong(UInt32 iDivisor) { }

	// RVA: 0xFB8860
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0xFB8C44
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0xFBB540
	private static void MpMove(UInt32[] rgulS, int ciulS, UInt32[] rgulD, int ciulD) { }

	// RVA: 0xFBB5B0
	private static void MpSet(UInt32[] rgulD, int ciulD, UInt32 iulN) { }

	// RVA: 0xFBB5E0
	private static void MpNormalize(UInt32[] rgulU, int ciulU) { }

	// RVA: 0xFBB634
	private static void MpMul1(UInt32[] piulD, int ciulD, UInt32 iulX) { }

	// RVA: 0xFB6ED8
	private static void MpDiv1(UInt32[] rgulU, int ciulU, UInt32 iulD, UInt32 iulR) { }

	// RVA: 0xFBB740
	internal static UInt64 DWL(UInt32 lo, UInt32 hi) { }

	// RVA: 0xFBB734
	private static UInt32 HI(UInt64 x) { }

	// RVA: 0xFBB73C
	private static UInt32 LO(UInt64 x) { }

	// RVA: 0xFBA098
	private static void MpDiv(UInt32[] rgulU, int ciulU, UInt32[] rgulD, int ciulD, UInt32[] rgulQ, int ciulQ, UInt32[] rgulR, int ciulR) { }

	// RVA: 0xFBB74C
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0xFB60B0
	private static void CheckValidPrecScale(Byte bPrec, Byte bScale) { }

	// RVA: 0xFBBC00
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFBBE18
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFBC030
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFBC248
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFBC2FC
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFBC3B0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFBC5D4
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFBC8D0
	public SqlMoney ToSqlMoney() { }

	// RVA: 0xFB7010
	private static Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0xFBB2B0
	private void StoreFromWorkingArray(UInt32[] rguiData) { }

	// RVA: 0xFB7664
	private void SetToZero() { }

	// RVA: 0xFBCB1C
	public int CompareTo(object value) { }

	// RVA: 0xFBCC50
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0xFBCFA0
	public override bool Equals(object value) { }

	// RVA: 0xFBD2F8
	public override int GetHashCode() { }

	// RVA: 0xFBD4A4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFBD4AC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFBD630
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFBD7CC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFBD85C
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

	// RVA: 0xFBDC18
	private void .ctor(bool fNull) { }

	// RVA: 0xFBDC24
	public void .ctor(Double value) { }

	// RVA: 0xFBDC9C
	public bool get_IsNull() { }

	// RVA: 0xFBDCAC
	public Double get_Value() { }

	// RVA: 0xFBDD00
	public static SqlDouble op_Implicit(Double x) { }

	// RVA: 0xFBDD68
	public override string ToString() { }

	// RVA: 0xFBDE00
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0xFBDF18
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFBE0B4
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFBE250
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFBE3EC
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFB0F34
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0xFBE5C0
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0xFBE704
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0xFBE840
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0xFBE980
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0xFBEB1C
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0xFBC43C
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0xFBED80
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFBEE94
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFBEFA8
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFBF0BC
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFBF13C
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFBF1BC
	public SqlSingle ToSqlSingle() { }

	// RVA: 0xFBF334
	public int CompareTo(object value) { }

	// RVA: 0xFBF444
	public int CompareTo(SqlDouble value) { }

	// RVA: 0xFBF600
	public override bool Equals(object value) { }

	// RVA: 0xFBF788
	public override int GetHashCode() { }

	// RVA: 0xFBF878
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFBF880
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFBF9C0
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFBFB14
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFBFBA4
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

	// RVA: 0xFBFC38
	private void .ctor(bool fNull) { }

	// RVA: 0xFBFC44
	public void .ctor(Guid g) { }

	// RVA: 0xFBFC88
	public bool get_IsNull() { }

	// RVA: 0xFBFC98
	public Guid get_Value() { }

	// RVA: 0xFBFD5C
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0xFBFD98
	public override string ToString() { }

	// RVA: 0xFBFE50
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFBFFF8
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFC0114
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFC0230
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFC034C
	public int CompareTo(object value) { }

	// RVA: 0xFC0470
	public int CompareTo(SqlGuid value) { }

	// RVA: 0xFC0610
	public override bool Equals(object value) { }

	// RVA: 0xFC0774
	public override int GetHashCode() { }

	// RVA: 0xFC0834
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFC083C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFC0998
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFC0AFC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFC0B8C
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

	// RVA: 0xFC0C74
	private void .ctor(bool fNull) { }

	// RVA: 0xFC0C80
	public void .ctor(Int16 value) { }

	// RVA: 0xFBACD4
	public bool get_IsNull() { }

	// RVA: 0xFBACE4
	public Int16 get_Value() { }

	// RVA: 0xFC0C90
	public static SqlInt16 op_Implicit(Int16 x) { }

	// RVA: 0xFC0C9C
	public override string ToString() { }

	// RVA: 0xFC0D34
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0xFC0E08
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFC0F5C
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFC10B0
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFC1248
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFC1400
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0xFC14F0
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0xFC1630
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFC1744
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFC1858
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFC196C
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFC19F8
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFC1A84
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFC1B0C
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFC1C7C
	public int CompareTo(object value) { }

	// RVA: 0xFC1DA0
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0xFC1F4C
	public override bool Equals(object value) { }

	// RVA: 0xFC20BC
	public override int GetHashCode() { }

	// RVA: 0xFC21B0
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFC21B8
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFC22F8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFC2440
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFC24D0
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

	// RVA: 0xFC2550
	private void .ctor(bool fNull) { }

	// RVA: 0xFC255C
	public void .ctor(int value) { }

	// RVA: 0xFBAE38
	public bool get_IsNull() { }

	// RVA: 0xFBAE48
	public int get_Value() { }

	// RVA: 0xFC256C
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0xFC2578
	public override string ToString() { }

	// RVA: 0xFC2610
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0xFC26E0
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFC2864
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFC29DC
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFC2B74
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFC2D2C
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0xFC2E1C
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0xFC2F0C
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0xFC2858
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0xFC304C
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFC3164
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFC327C
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFC3394
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFC3420
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFC34AC
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFC3534
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFC36A4
	public int CompareTo(object value) { }

	// RVA: 0xFC37C8
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0xFC3970
	public override bool Equals(object value) { }

	// RVA: 0xFC3AE0
	public override int GetHashCode() { }

	// RVA: 0xFC3BA0
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFC3BA8
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFC3CE8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFC3E30
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFC3EC0
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

	// RVA: 0xFC3F40
	private void .ctor(bool fNull) { }

	// RVA: 0xFC3F4C
	public void .ctor(Int64 value) { }

	// RVA: 0xFB09E8
	public bool get_IsNull() { }

	// RVA: 0xFB09F8
	public Int64 get_Value() { }

	// RVA: 0xFC3F5C
	public static SqlInt64 op_Implicit(Int64 x) { }

	// RVA: 0xFC3F68
	public override string ToString() { }

	// RVA: 0xFC4000
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0xFC40C8
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFC4240
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFC43A8
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFC454C
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFC46DC
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB1100
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0xFC1B94
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0xFC35BC
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0xFBC660
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0xFC4230
	private static bool SameSignLong(Int64 x, Int64 y) { }

	// RVA: 0xFC4870
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFC497C
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFC4A88
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFC4B94
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFC4C14
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFC4C94
	public SqlByte ToSqlByte() { }

	// RVA: 0xFC4D24
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFC4DB4
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0xFC4E44
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0xFC4ED4
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0xFC4F60
	public int CompareTo(object value) { }

	// RVA: 0xFC5070
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0xFC522C
	public override bool Equals(object value) { }

	// RVA: 0xFC53B4
	public override int GetHashCode() { }

	// RVA: 0xFC54A8
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFC54B0
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFC55F0
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFC5738
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFC57C8
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

	// RVA: 0xFC5864
	private void .ctor(bool fNull) { }

	// RVA: 0xFC5870
	internal void .ctor(Int64 value, int ignored) { }

	// RVA: 0xFC5880
	public void .ctor(int value) { }

	// RVA: 0xFC5900
	public void .ctor(Int64 value) { }

	// RVA: 0xFC5A20
	public void .ctor(Decimal value) { }

	// RVA: 0xFBB0F8
	public bool get_IsNull() { }

	// RVA: 0xFC5B98
	public Decimal get_Value() { }

	// RVA: 0xFBB108
	public Decimal ToDecimal() { }

	// RVA: 0xFBECE4
	public Double ToDouble() { }

	// RVA: 0xFC5C38
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0xFC5C68
	public static SqlMoney op_Implicit(Int64 x) { }

	// RVA: 0xFC5CD4
	public override string ToString() { }

	// RVA: 0xFC5E18
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0xFC5F48
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFC6124
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFC6300
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFC6470
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFC65E0
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0xFC6730
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0xFC6884
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0xFC69E0
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0xFBC95C
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0xFC6AD4
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFC6BE0
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFC6CEC
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFC6DF8
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFC6E78
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFC6EF8
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFC6F88
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0xFC7014
	public int CompareTo(object value) { }

	// RVA: 0xFC7124
	public int CompareTo(SqlMoney value) { }

	// RVA: 0xFC72E0
	public override bool Equals(object value) { }

	// RVA: 0xFC7468
	public override int GetHashCode() { }

	// RVA: 0xFC74FC
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFC7504
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFC76A0
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFC7808
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFC7898
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

	// RVA: 0xFC797C
	private void .ctor(bool fNull) { }

	// RVA: 0xFC7988
	public void .ctor(float value) { }

	// RVA: 0xFC7A00
	public void .ctor(Double value) { }

	// RVA: 0xFBEAB8
	public bool get_IsNull() { }

	// RVA: 0xFBEAC8
	public float get_Value() { }

	// RVA: 0xFC7AEC
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0xFC7B58
	public override string ToString() { }

	// RVA: 0xFC7BF0
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0xFC7CF8
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFC7E90
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFC8028
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFC81C0
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFC8390
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0xFC84C4
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0xFC85F8
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0xFC873C
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0xFC886C
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0xFC89F0
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0xFBF24C
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0xFC8B50
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFC8C70
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFC8D90
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFC8EB0
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFC8F3C
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFC8FC8
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFC9050
	public int CompareTo(object value) { }

	// RVA: 0xFC9174
	public int CompareTo(SqlSingle value) { }

	// RVA: 0xFC931C
	public override bool Equals(object value) { }

	// RVA: 0xFC948C
	public override int GetHashCode() { }

	// RVA: 0xFC9580
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFC9588
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFC96C8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFC981C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFC98AC
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

	// RVA: 0xFC992C
	private void .ctor(bool fNull) { }

	// RVA: 0xFC996C
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0xFC9B0C
	public void .ctor(string data) { }

	// RVA: 0xFC9BE0
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0xFB2900
	public bool get_IsNull() { }

	// RVA: 0xFB2910
	public string get_Value() { }

	// RVA: 0xFC9CF0
	private void SetCompareInfo() { }

	// RVA: 0xFC9D8C
	public static SqlString op_Implicit(string x) { }

	// RVA: 0xFC9DA0
	public override string ToString() { }

	// RVA: 0xFC9E30
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0xFC9FB0
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0xFCA784
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0xFCA924
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0xFC9A38
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xFCA6B4
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xFCA9BC
	private bool FBinarySort() { }

	// RVA: 0xFCA2DC
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0xFCA4F0
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0xFCAA54
	public int CompareTo(object value) { }

	// RVA: 0xFCAB78
	public int CompareTo(SqlString value) { }

	// RVA: 0xFCACC0
	public override bool Equals(object value) { }

	// RVA: 0xFCAEC8
	public override int GetHashCode() { }

	// RVA: 0xFCB1E4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFCB1EC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFCB318
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFCB42C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFCB4BC
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

	// RVA: 0xFCB5CC
	public void .ctor() { }

	// RVA: 0xFB2118
	public void .ctor(string message) { }

	// RVA: 0xFCB638
	public void .ctor(string message, Exception e) { }

	// RVA: 0xFCB668
	protected void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xFCB6BC
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlNullValueException
{
	// Methods

	// RVA: 0xFB0270
	public void .ctor() { }

	// RVA: 0xFCB7C8
	public void .ctor(string message) { }

	// RVA: 0xFCB798
	public void .ctor(string message, Exception e) { }

	// RVA: 0xFCB7FC
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xFCB860
	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlTruncateException
{
	// Methods

	// RVA: 0xFBB4FC
	public void .ctor() { }

	// RVA: 0xFCB96C
	public void .ctor(string message) { }

	// RVA: 0xFCB93C
	public void .ctor(string message, Exception e) { }

	// RVA: 0xFCB9A0
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xFCBA04
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

	// RVA: 0xFCBAE0
	public void .ctor() { }

	// RVA: 0xFCBB58
	public XmlReader CreateReader() { }

	// RVA: 0xFCBF10
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput, bool throwTargetInvocationExceptions) { }

	// RVA: 0xFCC0F8
	private static System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0xFCBDA8
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0xFCBD14
	public bool get_IsNull() { }

	// RVA: 0xFCBB20
	private void SetNull() { }

	// RVA: 0xFCC220
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFCC228
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xFCC434
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFCC5A8
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFCC638
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

	// RVA: 0xFCBD24
	internal void .ctor(Stream stream) { }

	// RVA: 0xFCC73C
	public override bool get_CanRead() { }

	// RVA: 0xFCC850
	public override bool get_CanSeek() { }

	// RVA: 0xFCC8E0
	public override bool get_CanWrite() { }

	// RVA: 0xFCC970
	public override Int64 get_Length() { }

	// RVA: 0xFCCB24
	public override Int64 get_Position() { }

	// RVA: 0xFCCB8C
	public override void set_Position(Int64 value) { }

	// RVA: 0xFCCC64
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFCCDEC
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xFCD03C
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xFCD28C
	public override int ReadByte() { }

	// RVA: 0xFCD3B8
	public override void WriteByte(Byte value) { }

	// RVA: 0xFCD4A0
	public override void Flush() { }

	// RVA: 0xFCD4BC
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFCCAA4
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0xFCCFBC
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0xFCD20C
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0xFCC9E8
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0xFCC7CC
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

	// RVA: 0xFD1270
	private void .ctor() { }

	// RVA: 0xFD1278
	public bool Equals(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> y) { }

	// RVA: 0xFD1AF0
	public int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> obj) { }

	// RVA: 0xFD1C84
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

	// RVA: 0xFCD4CC
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0xFCD6A0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFCD6D8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFCDDC4
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xFCDFE0
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0xFCD8C0
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0xFCE2C0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFCE344
	public override object Get(int recordNo) { }

	// RVA: 0xFCE180
	private Families GetFamily(Type dataType) { }

	// RVA: 0xFCE390
	public override bool IsNull(int record) { }

	// RVA: 0xFCE3CC
	public override void Set(int recordNo, object value) { }

	// RVA: 0xFCEC6C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFCED30
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFCF374
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFD04F0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD0A2C
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFD0B9C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD0BF0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD0E2C
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFD1044
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0xFCF2D0
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0xFCFAB0
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0xFD1198
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

	// RVA: 0xFD1CF0
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0xFD1D98
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0xFD1EB4
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0xFD1FD0
	internal static ArgumentException Argument(string error) { }

	// RVA: 0xFD2064
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0xFD20F8
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0xFD219C
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0xFD2230
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0xFD22C4
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0xFD259C
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0xFD280C
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0xFD2998
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0xFD2AB0
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0xFD2B78
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0xFD2C40
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0xFD2D08
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0xFD2E44
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class BigIntegerStorage
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0xFD31B0
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFD3424
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD345C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD3634
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD37C8
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0xFD3FAC
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xFD4744
	public override object ConvertValue(object value) { }

	// RVA: 0xFD4820
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD48F0
	public override object Get(int record) { }

	// RVA: 0xFD4A34
	public override void Set(int record, object value) { }

	// RVA: 0xFD4BD8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD4DB0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD4E94
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD4F88
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD4FDC
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD50FC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class BooleanStorage
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0xFD51CC
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFD5334
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD56E4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD57EC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD5928
	public override object ConvertValue(object value) { }

	// RVA: 0xFD5A8C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD5B10
	public override object Get(int record) { }

	// RVA: 0xFD5BDC
	public override void Set(int record, object value) { }

	// RVA: 0xFD5D80
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD5EC4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD5F58
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD600C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD6060
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD6164
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class ByteStorage
{
	// Fields
	private Byte[] _values; // 0x50

	// Methods

	// RVA: 0xFD6234
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFD639C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD6BC0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD6C84
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD6DAC
	public override object ConvertValue(object value) { }

	// RVA: 0xFD6F10
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD6F94
	public override object Get(int record) { }

	// RVA: 0xFD7060
	public override void Set(int record, object value) { }

	// RVA: 0xFD7204
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD7348
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD73DC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD7490
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD74E4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD75E8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class CharStorage
{
	// Fields
	private Char[] _values; // 0x50

	// Methods

	// RVA: 0xFD76B8
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFD7820
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD7BB4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD7CB8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD7DF4
	public override object ConvertValue(object value) { }

	// RVA: 0xFD7F58
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD7FDC
	public override object Get(int record) { }

	// RVA: 0xFD80A8
	public override void Set(int record, object value) { }

	// RVA: 0xFD8298
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD83DC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD8470
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD8524
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD8578
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD867C
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

	// RVA: 0xFD3384
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0xFD88CC
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0xFD874C
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0xFD8934
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0xFD4800
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xFD56D0
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0xFD8954
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0xFD35C8
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract int Compare(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xFD8A18
	public virtual object ConvertValue(object value) { }

	// RVA: 0xFD48AC
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1
	public abstract void Copy(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract object Get(int recordNo) { }

	// RVA: 0xFD49F0
	protected object GetBits(int recordNo) { }

	// RVA: 0xFD8A20
	public virtual int GetStringLength(int record) { }

	// RVA: 0xFD37A0
	protected bool HasValue(int recordNo) { }

	// RVA: 0xFD8A28
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1
	public abstract void Set(int recordNo, object value) { }

	// RVA: 0xFD4BB8
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0xFD4D1C
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1
	public abstract object ConvertXmlToObject(string s) { }

	// RVA: 0xFD8A48
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1
	public abstract string ConvertObjectToXml(object value) { }

	// RVA: 0xFD8A94
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFD8ADC
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0xFDA728
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0xFDA858
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0xFDA8F8
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0xFD88D8
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0xFDA974
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0xFDA980
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0xFD88F4
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0xFDAA90
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, bool sqlType, bool nullable, bool xmlSerializable, bool changeTracking, bool revertibleChangeTracking) { }

	// RVA: 0xFDAD0C
	private static System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0xFDAEF4
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0xFDAFD4
	public static bool IsObjectNull(object value) { }

	// RVA: 0xFDB168
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0xFDB240
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0xFDB250
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFDB260
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1
	protected abstract object GetEmptyStorage(int recordCount) { }

	// RVA: -1
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: -1
	protected abstract void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFDB270
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0xFDB278
	internal static Type GetType(string value) { }

	// RVA: 0xFDB3C0
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0xFDB45C
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0xFD9EC0
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFDC398
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFDC8B4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFDCA8C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFDCC44
	public override object ConvertValue(object value) { }

	// RVA: 0xFDCD08
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFDCD8C
	public override object Get(int record) { }

	// RVA: 0xFDCEBC
	public override void Set(int record, object value) { }

	// RVA: 0xFDCFF0
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFDD134
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFDD1C8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFDD280
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFDD2D4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFDD3E8
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFDD4B8
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeStorage
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0xFD9D28
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFDD534
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFDDA30
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFDDC2C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFDDDDC
	public override object ConvertValue(object value) { }

	// RVA: 0xFDDF40
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFDDFC4
	public override object Get(int record) { }

	// RVA: 0xFDE10C
	public override void Set(int record, object value) { }

	// RVA: 0xFDE4EC
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFDE630
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFDE6F8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFDE7F4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFDE848
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFDE9C4
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFDEBF8
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DecimalStorage
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0xFD9B6C
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFDEC74
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFDF7A8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFDF960
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFDFAF0
	public override object ConvertValue(object value) { }

	// RVA: 0xFDFC74
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFDFCF8
	public override object Get(int record) { }

	// RVA: 0xFDFDD0
	public override void Set(int record, object value) { }

	// RVA: 0xFDFF94
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE00D8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE0198
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE0250
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE02A4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE03B8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class DoubleStorage
{
	// Fields
	private Double[] _values; // 0x50

	// Methods

	// RVA: 0xFD9A04
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFE0488
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE0C0C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE0CDC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE0E08
	public override object ConvertValue(object value) { }

	// RVA: 0xFE0F6C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE0FF0
	public override object Get(int record) { }

	// RVA: 0xFE10C0
	public override void Set(int record, object value) { }

	// RVA: 0xFE1264
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE13A8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE143C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE14F0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE1544
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE1650
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int16Storage
{
	// Fields
	private Int16[] _values; // 0x50

	// Methods

	// RVA: 0xFD95CC
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFE1720
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE1F8C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE2044
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE216C
	public override object ConvertValue(object value) { }

	// RVA: 0xFE22D0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE2354
	public override object Get(int record) { }

	// RVA: 0xFE2420
	public override void Set(int record, object value) { }

	// RVA: 0xFE25C4
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE2708
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE279C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE2850
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE28A4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE29A8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int32Storage
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0xFD9734
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFE2A78
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE32D8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE33AC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE34D4
	public override object ConvertValue(object value) { }

	// RVA: 0xFE3638
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE36BC
	public override object Get(int record) { }

	// RVA: 0xFE3788
	public override void Set(int record, object value) { }

	// RVA: 0xFE392C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE3A70
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE3B04
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE3BB8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE3C0C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE3D10
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int64Storage
{
	// Fields
	private Int64[] _values; // 0x50

	// Methods

	// RVA: 0xFD989C
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFE3DE0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE4680
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE4754
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE487C
	public override object ConvertValue(object value) { }

	// RVA: 0xFE49E0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE4A64
	public override object Get(int record) { }

	// RVA: 0xFE4B30
	public override void Set(int record, object value) { }

	// RVA: 0xFE4CD4
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE4E18
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE4EAC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE4F60
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE4FB4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE50B8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SByteStorage
{
	// Fields
	private SByte[] _values; // 0x50

	// Methods

	// RVA: 0xFD9464
	public void .ctor(DataColumn column) { }

	// RVA: 0xFE5188
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE59C8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE5AB4
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE5BDC
	public override object ConvertValue(object value) { }

	// RVA: 0xFE5D40
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE5DC4
	public override object Get(int record) { }

	// RVA: 0xFE5EA8
	public override void Set(int record, object value) { }

	// RVA: 0xFE604C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE6190
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE6224
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE62D8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE632C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE6430
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal static class SqlConvert
{
	// Methods

	// RVA: 0xFE6500
	public static SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0xFE6738
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0xFE6A50
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0xFE6EA8
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0xFE7400
	public static SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0xFE7B6C
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0xFE81D4
	public static SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0xFE88D4
	public static SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0xFE8F64
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0xFE91A0
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0xFE93C4
	public static SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0xFE9604
	public static SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0xFE9838
	public static SqlString ConvertToSqlString(object value) { }

	// RVA: 0xFE9A40
	public static SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0xFE9BB0
	public static SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0xFE9D20
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0xFE9D8C
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xFE9F78
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xFEB04C
	public static object ChangeTypeForXML(object value, Type type) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0xFDA058
	public void .ctor(DataColumn column) { }

	// RVA: 0xFECE44
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFED0A0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFED144
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFED204
	public override object ConvertValue(object value) { }

	// RVA: 0xFED290
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFED2D8
	public override object Get(int record) { }

	// RVA: 0xFED364
	public override bool IsNull(int record) { }

	// RVA: 0xFED3EC
	public override void Set(int record, object value) { }

	// RVA: 0xFED43C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFED500
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFED7AC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFEDA14
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFEDA68
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFEDB74
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlByteStorage
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0xFDA190
	public void .ctor(DataColumn column) { }

	// RVA: 0xFEDC24
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFEEA60
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFEEB04
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFEEBC4
	public override object ConvertValue(object value) { }

	// RVA: 0xFEEC50
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFEEC90
	public override object Get(int record) { }

	// RVA: 0xFEED1C
	public override bool IsNull(int record) { }

	// RVA: 0xFEEDA4
	public override void Set(int record, object value) { }

	// RVA: 0xFEEDEC
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFEEEB0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFEF15C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFEF3C4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFEF418
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFEF51C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBytesStorage
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0xFDA2C8
	public void .ctor(DataColumn column) { }

	// RVA: 0xFEF5CC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFEF800
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFEF808
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFEF810
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFEF854
	public override object Get(int record) { }

	// RVA: 0xFEF888
	public override bool IsNull(int record) { }

	// RVA: 0xFEF8C4
	public override void Set(int record, object value) { }

	// RVA: 0xFEF9F0
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFEFAB4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFEFD84
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFEFFEC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF0040
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF014C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlCharsStorage
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0xFDA3B0
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF01FC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF0430
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF0438
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF0440
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF0484
	public override object Get(int record) { }

	// RVA: 0xFF04B8
	public override bool IsNull(int record) { }

	// RVA: 0xFF04F4
	public override void Set(int record, object value) { }

	// RVA: 0xFF0620
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF06E4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF09C0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF0C28
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF0C7C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF0D88
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0xFDA498
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF0E38
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF1454
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF1508
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF15D0
	public override object ConvertValue(object value) { }

	// RVA: 0xFF1660
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF16B4
	public override object Get(int record) { }

	// RVA: 0xFF174C
	public override bool IsNull(int record) { }

	// RVA: 0xFF17D8
	public override void Set(int record, object value) { }

	// RVA: 0xFF1828
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF18EC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF1BA4
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF1E0C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF1E60
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF1F7C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0xFDA5E0
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF202C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF2F48
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF301C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF30FC
	public override object ConvertValue(object value) { }

	// RVA: 0xFF3188
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF31DC
	public override object Get(int record) { }

	// RVA: 0xFF327C
	public override bool IsNull(int record) { }

	// RVA: 0xFF3308
	public override void Set(int record, object value) { }

	// RVA: 0xFF336C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF3430
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF36E8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF3950
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF39A4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF3AD0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0xFF3B80
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF3CB8
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF49D0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF4A78
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF4B38
	public override object ConvertValue(object value) { }

	// RVA: 0xFF4BC8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF4C08
	public override object Get(int record) { }

	// RVA: 0xFF4C94
	public override bool IsNull(int record) { }

	// RVA: 0xFF4D1C
	public override void Set(int record, object value) { }

	// RVA: 0xFF4D68
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF4E2C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF50D8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF533C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF5390
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF54A4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlGuidStorage
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0xFF5554
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF568C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF58E8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF598C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF5A4C
	public override object ConvertValue(object value) { }

	// RVA: 0xFF5ADC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF5B24
	public override object Get(int record) { }

	// RVA: 0xFF5BB0
	public override bool IsNull(int record) { }

	// RVA: 0xFF5C38
	public override void Set(int record, object value) { }

	// RVA: 0xFF5C8C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF5D50
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF5FFC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF6260
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF62B4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF63C0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt16Storage
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0xFF6470
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF65A8
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF73E4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF7488
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF7548
	public override object ConvertValue(object value) { }

	// RVA: 0xFF75D8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF7618
	public override object Get(int record) { }

	// RVA: 0xFF76A4
	public override bool IsNull(int record) { }

	// RVA: 0xFF772C
	public override void Set(int record, object value) { }

	// RVA: 0xFF7778
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF783C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF7AE8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF7D4C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF7DA0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF7EA4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt32Storage
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0xFF7F54
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF808C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF8E98
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF8F3C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF8FFC
	public override object ConvertValue(object value) { }

	// RVA: 0xFF908C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF90CC
	public override object Get(int record) { }

	// RVA: 0xFF9158
	public override bool IsNull(int record) { }

	// RVA: 0xFF91E0
	public override void Set(int record, object value) { }

	// RVA: 0xFF922C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF92F0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF959C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF9800
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF9854
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF9958
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt64Storage
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0xFF9A08
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF9B40
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFFAA40
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFAAE8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFABA8
	public override object ConvertValue(object value) { }

	// RVA: 0xFFAC38
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFAC78
	public override object Get(int record) { }

	// RVA: 0xFFAD04
	public override bool IsNull(int record) { }

	// RVA: 0xFFAD8C
	public override void Set(int record, object value) { }

	// RVA: 0xFFADD8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFAE9C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFB148
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFB3AC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFB400
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFB514
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0xFFB5C4
	public void .ctor(DataColumn column) { }

	// RVA: 0xFFB6FC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFFC5FC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFC6A4
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFC764
	public override object ConvertValue(object value) { }

	// RVA: 0xFFC7F4
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFC834
	public override object Get(int record) { }

	// RVA: 0xFFC8C0
	public override bool IsNull(int record) { }

	// RVA: 0xFFC948
	public override void Set(int record, object value) { }

	// RVA: 0xFFC994
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFCA58
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFCD04
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFCF68
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFCFBC
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFD0D0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlSingleStorage
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0xFFD180
	public void .ctor(DataColumn column) { }

	// RVA: 0xFFD2B8
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFFE094
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFE138
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFE1F8
	public override object ConvertValue(object value) { }

	// RVA: 0xFFE288
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFE2C8
	public override object Get(int record) { }

	// RVA: 0xFFE354
	public override bool IsNull(int record) { }

	// RVA: 0xFFE3DC
	public override void Set(int record, object value) { }

	// RVA: 0xFFE428
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFE4EC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFE798
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFE9FC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFEA50
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFEB54
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlStringStorage
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0xFFEC04
	public void .ctor(DataColumn column) { }

	// RVA: 0xFFED48
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0xFFF170
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFF1E0
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0xFFF39C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFF464
	public override object ConvertValue(object value) { }

	// RVA: 0xFFF4FC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFF550
	public override object Get(int record) { }

	// RVA: 0xFFF5E4
	public override int GetStringLength(int record) { }

	// RVA: 0xFFF6D4
	public override bool IsNull(int record) { }

	// RVA: 0xFFF760
	public override void Set(int record, object value) { }

	// RVA: 0xFFF7CC
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFF890
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFFB40
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFFDA4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFFDF8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFFF20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0xFFFFD0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1000108
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1000590
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1000634
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x10006F4
	public override object ConvertValue(object value) { }

	// RVA: 0x1000784
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10007C4
	public override object Get(int record) { }

	// RVA: 0x1000850
	public override bool IsNull(int record) { }

	// RVA: 0x10008D8
	public override void Set(int record, object value) { }

	// RVA: 0x1000924
	public override void SetCapacity(int capacity) { }

	// RVA: 0x10009E8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1000C94
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1000EF8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1000F4C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1001050
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SingleStorage
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x1001100
	public void .ctor(DataColumn column) { }

	// RVA: 0x1001200
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x100191C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x10019B0
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1001ADC
	public override object ConvertValue(object value) { }

	// RVA: 0x1001C38
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1001C9C
	public override object Get(int record) { }

	// RVA: 0x1001D50
	public override void Set(int record, object value) { }

	// RVA: 0x1001EE8
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1001FC8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x100205C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1002110
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1002164
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1002270
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x10026A4
	public void .ctor() { }

	// RVA: 0x1003B24
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

	// RVA: 0x1002340
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x10024F8
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x10023C4
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x10026AC
	public override bool IsNull(int record) { }

	// RVA: 0x10027D0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1002808
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1002844
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1002B04
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1002B98
	public override object Get(int recordNo) { }

	// RVA: 0x1002BCC
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1002D60
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1002E40
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1003150
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x10033FC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10036D8
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1003840
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1003894
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10039D8
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1003A88
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class StringStorage
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x1003C5C
	public void .ctor(DataColumn column) { }

	// RVA: 0x1003D48
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1004034
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x10040B8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x100419C
	public override object ConvertValue(object value) { }

	// RVA: 0x10041CC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1004210
	public override object Get(int recordNo) { }

	// RVA: 0x100425C
	public override int GetStringLength(int record) { }

	// RVA: 0x10042A4
	public override bool IsNull(int record) { }

	// RVA: 0x10042E0
	public override void Set(int record, object value) { }

	// RVA: 0x100436C
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1004430
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1004438
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x100449C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10044F0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10045FC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class TimeSpanStorage
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x10046AC
	public void .ctor(DataColumn column) { }

	// RVA: 0x10047DC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x10053C8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1005598
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1005760
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x1005990
	public override object ConvertValue(object value) { }

	// RVA: 0x1005A58
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1005ABC
	public override object Get(int record) { }

	// RVA: 0x1005BF0
	public override void Set(int record, object value) { }

	// RVA: 0x1005CD0
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1005DB0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1005E44
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1005EF8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1005F4C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1006050
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1006120
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class UInt16Storage
{
	// Fields
	private static readonly UInt16 s_defaultValue; // 0x0
	private UInt16[] _values; // 0x50

	// Methods

	// RVA: 0x100619C
	public void .ctor(DataColumn column) { }

	// RVA: 0x10062C4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1006AE4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1006BB8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1006CF8
	public override object ConvertValue(object value) { }

	// RVA: 0x1006E54
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1006EB8
	public override object Get(int record) { }

	// RVA: 0x1006FA0
	public override void Set(int record, object value) { }

	// RVA: 0x1007158
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1007238
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10072CC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1007380
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x10073D4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x10074D4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt32Storage
{
	// Fields
	private static readonly UInt32 s_defaultValue; // 0x0
	private UInt32[] _values; // 0x50

	// Methods

	// RVA: 0x10075A4
	public void .ctor(DataColumn column) { }

	// RVA: 0x10076CC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1007EF0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1007FE8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1008128
	public override object ConvertValue(object value) { }

	// RVA: 0x1008284
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x10082E8
	public override object Get(int record) { }

	// RVA: 0x10083D0
	public override void Set(int record, object value) { }

	// RVA: 0x1008588
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1008668
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x10086FC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x10087B0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1008804
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1008904
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt64Storage
{
	// Fields
	private static readonly UInt64 s_defaultValue; // 0x0
	private UInt64[] _values; // 0x50

	// Methods

	// RVA: 0x10089D4
	public void .ctor(DataColumn column) { }

	// RVA: 0x1008AFC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x100931C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x100942C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x100956C
	public override object ConvertValue(object value) { }

	// RVA: 0x10096C8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x100972C
	public override object Get(int record) { }

	// RVA: 0x1009814
	public override void Set(int record, object value) { }

	// RVA: 0x10099CC
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1009AAC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1009B40
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1009BF4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1009C48
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1009D48
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


