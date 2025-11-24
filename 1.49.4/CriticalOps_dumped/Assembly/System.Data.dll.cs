// Namespace: 
internal class <Module>
{}

// Namespace: Microsoft.CodeAnalysis
internal sealed class EmbeddedAttribute
{
	// Methods

	// RVA: 0xEF7208
	public void .ctor() { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableAttribute
{
	// Fields
	public readonly Byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xEF7210
	public void .ctor(Byte ) { }

}

// Namespace: System.Runtime.CompilerServices
internal sealed class NullableContextAttribute
{
	// Fields
	public readonly Byte Flag; // 0x10

	// Methods

	// RVA: 0xEF729C
	public void .ctor(Byte ) { }

}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0xEF72C8
	internal static string GetString(string name) { }

	// RVA: 0xEF72CC
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0xEF7340
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0xEF73C4
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }

}

// Namespace: System
internal static class LocalAppContextSwitches
{
	// Fields
	private static int s_allowArbitraryTypeInstantiation; // 0x0

	// Methods

	// RVA: 0xEF7450
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

	// RVA: 0xEF7820
	private static void .cctor() { }

	// RVA: 0xEF788C
	public void .ctor() { }

	// RVA: 0xEF7894
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

	// RVA: 0xEF756C
	internal static bool GetCachedSwitchValue(string switchName, int switchValue) { }

	// RVA: 0xEF7648
	private static bool GetCachedSwitchValueInternal(string switchName, int switchValue) { }

	// RVA: 0xEF76E8
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

	// RVA: 0xEF7918
	public void .ctor() { }

	// RVA: 0xEF7D38
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0xEF79AC
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0xEF7F4C
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0xEF8A24
	public bool get_AllowDBNull() { }

	// RVA: 0xEF8A2C
	public void set_AllowDBNull(bool value) { }

	// RVA: 0xEF8FF4
	public bool get_AutoIncrement() { }

	// RVA: 0xEF9014
	public void set_AutoIncrement(bool value) { }

	// RVA: 0xEFA20C
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0xEFA2A0
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0xEFA080
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0xEFA288
	public Int64 get_AutoIncrementSeed() { }

	// RVA: 0xEFA580
	public void set_AutoIncrementSeed(Int64 value) { }

	// RVA: 0xEFA698
	public Int64 get_AutoIncrementStep() { }

	// RVA: 0xEFA6B4
	public void set_AutoIncrementStep(Int64 value) { }

	// RVA: 0xEFA7EC
	public string get_Caption() { }

	// RVA: 0xEFA808
	public void set_Caption(string value) { }

	// RVA: 0xEFA9B0
	public string get_ColumnName() { }

	// RVA: 0xEFA9B8
	public void set_ColumnName(string value) { }

	// RVA: 0xEFAF94
	internal string get_EncodedColumnName() { }

	// RVA: 0xEFA46C
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xEFA930
	internal CultureInfo get_Locale() { }

	// RVA: 0xEFB030
	internal int get_ObjectID() { }

	// RVA: 0xEFB038
	public string get_Prefix() { }

	// RVA: 0xEFB040
	public void set_Prefix(string value) { }

	// RVA: 0xEFB304
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0xEFB4B8
	internal bool get_Computed() { }

	// RVA: 0xEFB4C8
	internal DataExpression get_DataExpression() { }

	// RVA: 0xEFB4D0
	public Type get_DataType() { }

	// RVA: 0xEF9710
	public void set_DataType(Type value) { }

	// RVA: 0xEFC10C
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0xEFC114
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0xEFB818
	public object get_DefaultValue() { }

	// RVA: 0xEFB9E0
	public void set_DefaultValue(object value) { }

	// RVA: 0xEFC668
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0xEFC670
	internal void BindExpression() { }

	// RVA: 0xEFC698
	public string get_Expression() { }

	// RVA: 0xEF8084
	public void set_Expression(string value) { }

	// RVA: 0xEFCE40
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xEF95F0
	internal bool get_HasData() { }

	// RVA: 0xEFCECC
	internal bool get_ImplementsINullable() { }

	// RVA: 0xEFCED4
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0xEFCEDC
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0xEFCEE4
	internal bool get_IsValueType() { }

	// RVA: 0xEFCF04
	internal bool get_IsSqlType() { }

	// RVA: 0xEFCF0C
	private void SetMaxLengthSimpleType() { }

	// RVA: 0xEFCFF8
	public int get_MaxLength() { }

	// RVA: 0xEFD000
	public void set_MaxLength(int value) { }

	// RVA: 0xEFDA0C
	public string get_Namespace() { }

	// RVA: 0xEFDA94
	public void set_Namespace(string value) { }

	// RVA: 0xEFDDFC
	public int get_Ordinal() { }

	// RVA: 0xEFDE04
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0xEFDF58
	public bool get_ReadOnly() { }

	// RVA: 0xEFC8A4
	public void set_ReadOnly(bool value) { }

	// RVA: 0xEFDFFC
	private Index get_SortIndex() { }

	// RVA: 0xEFE100
	public DataTable get_Table() { }

	// RVA: 0xEFE108
	internal void SetTable(DataTable table) { }

	// RVA: 0xEFE1EC
	private DataRow GetDataRow(int index) { }

	// RVA: 0xEFB3D8
	internal object get_Item(int record) { }

	// RVA: 0xEFE214
	internal void set_Item(int record, object value) { }

	// RVA: 0xEFCD10
	internal void InitializeRecord(int record) { }

	// RVA: 0xEFE52C
	internal void SetValue(int record, object value) { }

	// RVA: 0xEFE660
	internal void FreeRecord(int record) { }

	// RVA: 0xEFE688
	public bool get_Unique() { }

	// RVA: 0xEFE690
	public void set_Unique(bool value) { }

	// RVA: 0xEFEC5C
	internal void InternalUnique(bool value) { }

	// RVA: 0xEFEC64
	internal string get_XmlDataType() { }

	// RVA: 0xEFEC6C
	internal void set_XmlDataType(string value) { }

	// RVA: 0xEFEC74
	internal SimpleType get_SimpleType() { }

	// RVA: 0xEF7EEC
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0xEFEC7C
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0xEFEC84
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0xEFF240
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xEFD560
	internal bool CheckMaxLength() { }

	// RVA: 0xEFF314
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0xEF8BCC
	protected internal void CheckNotAllowNull() { }

	// RVA: 0xEFF298
	internal void CheckNullable(DataRow row) { }

	// RVA: 0xEFEC04
	protected void CheckUnique() { }

	// RVA: 0xEFF7FC
	internal int Compare(int record1, int record2) { }

	// RVA: 0xEFF820
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0xEFFA24
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0xEFFA48
	internal object ConvertValue(object value) { }

	// RVA: 0xEFFA6C
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0xEFFA90
	internal DataColumn Clone() { }

	// RVA: 0xF001AC
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0xEFF390
	private int GetStringLength(int record) { }

	// RVA: 0xF00290
	internal void Init(int record) { }

	// RVA: 0xEF9310
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0xF00328
	internal bool get_IsCustomType() { }

	// RVA: 0xF003B4
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0xF004AC
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0xEFB5F8
	internal bool IsInRelation() { }

	// RVA: 0xF004B4
	internal bool IsMaxLengthViolated() { }

	// RVA: 0xF00BA0
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0xF00E54
	internal void FinishInitInProgress() { }

	// RVA: 0xF00E70
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xEFAF18
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF00E94
	private void InsureStorage() { }

	// RVA: 0xF00F34
	internal void SetCapacity(int capacity) { }

	// RVA: 0xF00FF0
	internal void OnSetDataSet() { }

	// RVA: 0xF00FF4
	public override string ToString() { }

	// RVA: 0xF010B8
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0xF01174
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xEFB3FC
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0xF01238
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xF0130C
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0xF013C0
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xF013E0
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xF0149C
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xF0156C
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xEFCBCC
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }

}

// Namespace: System.Data
internal abstract class AutoIncrementValue
{
	// Fields
	private bool <Auto>k__BackingField; // 0x10

	// Methods

	// RVA: 0xF01610
	internal bool get_Auto() { }

	// RVA: 0xF01618
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

	// RVA: 0xF00038
	internal AutoIncrementValue Clone() { }

	// RVA: 0xF01620
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

	// RVA: 0xF01628
	internal override object get_Current() { }

	// RVA: 0xF01690
	internal override void set_Current(object value) { }

	// RVA: 0xF01714
	internal override Type get_DataType() { }

	// RVA: 0xF017B4
	internal override Int64 get_Seed() { }

	// RVA: 0xF017BC
	internal override void set_Seed(Int64 value) { }

	// RVA: 0xF01978
	internal override Int64 get_Step() { }

	// RVA: 0xF01980
	internal override void set_Step(Int64 value) { }

	// RVA: 0xF01A9C
	internal override void MoveAfter() { }

	// RVA: 0xF01AB0
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xF01B30
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0xF01868
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xEFA4EC
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

	// RVA: 0xF01C9C
	internal override object get_Current() { }

	// RVA: 0xF01D04
	internal override void set_Current(object value) { }

	// RVA: 0xF01D90
	internal override Type get_DataType() { }

	// RVA: 0xF01E30
	internal override Int64 get_Seed() { }

	// RVA: 0xF01E38
	internal override void set_Seed(Int64 value) { }

	// RVA: 0xF020D0
	internal override Int64 get_Step() { }

	// RVA: 0xF0213C
	internal override void set_Step(Int64 value) { }

	// RVA: 0xF02334
	internal override void MoveAfter() { }

	// RVA: 0xF023D4
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0xF02410
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0xF01F54
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0xEFA4FC
	public void .ctor() { }

}

// Namespace: System.Data
[Serializable]
public class DataException
{
	// Methods

	// RVA: 0xF024FC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF02504
	public void .ctor() { }

	// RVA: 0xF0256C
	public void .ctor(string s) { }

	// RVA: 0xF0259C
	public void .ctor(string s, Exception innerException) { }

}

// Namespace: System.Data
[Serializable]
public class ConstraintException
{
	// Methods

	// RVA: 0xF025A4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF025AC
	public void .ctor() { }

	// RVA: 0xF02614
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class DeletedRowInaccessibleException
{
	// Methods

	// RVA: 0xF02644
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF0264C
	public void .ctor() { }

	// RVA: 0xF026B4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class DuplicateNameException
{
	// Methods

	// RVA: 0xF026E4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF026EC
	public void .ctor() { }

	// RVA: 0xF02754
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class InRowChangingEventException
{
	// Methods

	// RVA: 0xF02784
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF0278C
	public void .ctor() { }

	// RVA: 0xF027F4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class InvalidConstraintException
{
	// Methods

	// RVA: 0xF02824
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF0282C
	public void .ctor() { }

	// RVA: 0xF02894
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class NoNullAllowedException
{
	// Methods

	// RVA: 0xF028C4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF028CC
	public void .ctor() { }

	// RVA: 0xF02934
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class ReadOnlyException
{
	// Methods

	// RVA: 0xF02964
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF0296C
	public void .ctor() { }

	// RVA: 0xF029D4
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class RowNotInTableException
{
	// Methods

	// RVA: 0xF02A04
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF02A0C
	public void .ctor() { }

	// RVA: 0xF02A74
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class VersionNotFoundException
{
	// Methods

	// RVA: 0xF02AA4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF02AAC
	public void .ctor() { }

	// RVA: 0xF02B14
	public void .ctor(string s) { }

}

// Namespace: System.Data
internal static class ExceptionBuilder
{
	// Methods

	// RVA: 0xF02B44
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0xF02BEC
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0xEFC9BC
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0xEFCD50
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0xF02CDC
	internal static Exception _Argument(string error) { }

	// RVA: 0xF02D44
	internal static Exception _Argument(string paramName, string error) { }

	// RVA: 0xF02DAC
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0xF02E1C
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0xF02E8C
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0xF02EFC
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0xF02F64
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0xF02FCC
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: 0x315B3A8
	private static Exception _InvalidEnumArgumentException(T value) { }

	// RVA: 0xF03034
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0xF0308C
	private static Exception _Data(string error) { }

	// RVA: 0xF03100
	private static Exception _Constraint(string error) { }

	// RVA: 0xF03174
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0xF031E8
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0xF0325C
	private static Exception _DuplicateName(string error) { }

	// RVA: 0xF032D0
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0xF03344
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0xF033B8
	private static Exception _ReadOnly(string error) { }

	// RVA: 0xF0342C
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0xF034A0
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0xEF7D44
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0xF03514
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0xF03628
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0xF03738
	public static Exception ArgumentContainsNull(string paramName) { }

	// RVA: 0xF03848
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0xF03950
	public static Exception CannotModifyCollection() { }

	// RVA: 0xF039E0
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0xF03AF0
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0xF03C00
	public static Exception InvalidOffsetLength() { }

	// RVA: 0xF03C90
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0xF03DB0
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0xF03E40
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0xF03F6C
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0xF0407C
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0xF0418C
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0xEFF0A0
	public static Exception CannotAddColumn3() { }

	// RVA: 0xEFF130
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0xF0429C
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0xF043B8
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0xF044D4
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0xF045F0
	public static Exception CannotRemoveColumn() { }

	// RVA: 0xF04680
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0xF04710
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0xF04820
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0xF04940
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0xF04A60
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0xF04AF0
	public static Exception NoConstraintName() { }

	// RVA: 0xF04B80
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0xF04C9C
	public static string KeysToString(object[] keys) { }

	// RVA: 0xF04DBC
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0xF04FD0
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0xF05048
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0xF05174
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0xF05290
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0xF053AC
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0xF054D8
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0xF05568
	public static Exception ConstraintForeignTable() { }

	// RVA: 0xF055F8
	public static Exception ConstraintParentValues() { }

	// RVA: 0xF05688
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0xF05788
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0xF05818
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0xF05934
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0xF05A50
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0xF05B84
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0xF05C94
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0xF00ADC
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0xF00D90
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0xF05DA4
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0xEF91F0
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0xEF9280
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0xF01A0C
	public static Exception AutoIncrementSeed() { }

	// RVA: 0xEFB4D8
	public static Exception CantChangeDataType() { }

	// RVA: 0xEFB568
	public static Exception NullDataType() { }

	// RVA: 0xEFAE88
	public static Exception ColumnNameRequired() { }

	// RVA: 0xEFC48C
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0xEFBDBC
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xEFC51C
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0xEFC6F8
	public static Exception ExpressionAndUnique() { }

	// RVA: 0xEFCAAC
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0xEFC788
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0xF05EB4
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0xEFCB3C
	public static Exception ExpressionCircular() { }

	// RVA: 0xEFF6E0
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0xEFF4A8
	public static Exception NullKeyValues(string column) { }

	// RVA: 0xEFF5C4
	public static Exception NullValues(string column) { }

	// RVA: 0xEFDF60
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0xF05FA8
	public static Exception ReadOnly(string column) { }

	// RVA: 0xEFEB74
	public static Exception UniqueAndExpression() { }

	// RVA: 0xEFE3B8
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0xF060C4
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0xEFF3B4
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0xEFD8C4
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0xEFD378
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0xEFBFEC
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0xEFEF80
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0xEFDCEC
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0xEFD46C
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0xEF9600
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0xF061B8
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0xF062C8
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0xF063E4
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0xF064F4
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0xEFC244
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0xEFC428
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0xEFC2D4
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0xEF7E58
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0xF065FC
	public static Exception SetFailed(string name) { }

	// RVA: 0xF06718
	public static Exception SetRowStateFilter() { }

	// RVA: 0xF067B4
	public static Exception CanNotUseDataViewManager() { }

	// RVA: 0xF06850
	public static Exception CanNotSetTable() { }

	// RVA: 0xF068EC
	public static Exception CanNotUse() { }

	// RVA: 0xF06988
	public static Exception CanNotBindTable() { }

	// RVA: 0xF06A24
	public static Exception SetTable() { }

	// RVA: 0xF06AC0
	public static Exception SetIListObject() { }

	// RVA: 0xF06B50
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0xF06BEC
	public static Exception NotOpen() { }

	// RVA: 0xF06C88
	public static Exception CreateChildView() { }

	// RVA: 0xF06D18
	public static Exception CanNotDelete() { }

	// RVA: 0xF06DB4
	public static Exception GetElementIndex(int index) { }

	// RVA: 0xF06EE0
	public static Exception AddExternalObject() { }

	// RVA: 0xF06F70
	public static Exception CanNotClear() { }

	// RVA: 0xF07000
	public static Exception InsertExternalObject() { }

	// RVA: 0xF07090
	public static Exception RemoveExternalObject() { }

	// RVA: 0xF07120
	public static Exception ColumnToSortIsOutOfRange(string column) { }

	// RVA: 0xF07230
	public static Exception KeyTableMismatch() { }

	// RVA: 0xF072CC
	public static Exception KeyNoColumns() { }

	// RVA: 0xF07368
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0xF074A0
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0xF075BC
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0xEFB77C
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0xF07658
	public static Exception KeyLengthMismatch() { }

	// RVA: 0xF076E8
	public static Exception KeyLengthZero() { }

	// RVA: 0xF07778
	public static Exception ForeignRelation() { }

	// RVA: 0xF07808
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0xF078A4
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0xF079D0
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xF07AFC
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0xF07C28
	public static Exception RelationForeignRow() { }

	// RVA: 0xF07CB8
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0xF07D48
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0xF07E58
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0xF07F68
	public static Exception RelationDoesNotExist() { }

	// RVA: 0xF07FF8
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0xF08094
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0xF081A4
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0xF082B4
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0xF08344
	public static Exception RowNotInTheTable() { }

	// RVA: 0xF083E0
	public static Exception EditInRowChanging() { }

	// RVA: 0xF0847C
	public static Exception EndEditInRowChanging() { }

	// RVA: 0xF08518
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0xF085B4
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0xF08650
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0xF086EC
	public static Exception ValueArrayLength() { }

	// RVA: 0xF0877C
	public static Exception NoCurrentData() { }

	// RVA: 0xF08818
	public static Exception NoOriginalData() { }

	// RVA: 0xF088B4
	public static Exception NoProposedData() { }

	// RVA: 0xF08950
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0xF089EC
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0xF08A88
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0xF08B24
	public static Exception RowEmpty() { }

	// RVA: 0xF08BB4
	public static Exception InvalidRowVersion() { }

	// RVA: 0xF08C50
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0xF08D7C
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0xF08EB8
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0xF08FC8
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0xF09064
	public static Exception MultipleParents() { }

	// RVA: 0xF09100
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0xF09164
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0xF091F4
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0xF09284
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0xF09394
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0xF094A4
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0xF095B4
	public static Exception TablesInDifferentSets() { }

	// RVA: 0xF09644
	public static Exception RelationAlreadyExists() { }

	// RVA: 0xF096D4
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0xF09764
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0xF097F4
	public static Exception RecordStateRange() { }

	// RVA: 0xF09884
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0xF09A28
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0xF09B70
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0xF09C00
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0xF09C90
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0xF09DA0
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0xF09EC0
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0xF09FDC
	public static Exception RelationTableNull() { }

	// RVA: 0xF0A06C
	public static Exception RelationDataSetNull() { }

	// RVA: 0xF0A0FC
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0xF0A18C
	public static Exception ParentTableMismatch() { }

	// RVA: 0xF0A21C
	public static Exception ChildTableMismatch() { }

	// RVA: 0xF0A2AC
	public static Exception EnforceConstraint() { }

	// RVA: 0xF0A348
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0xF0A3D8
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0xF0A46C
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0xF0A504
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0xF0A568
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0xF0A5F8
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0xF0A688
	public static Exception NoTableName() { }

	// RVA: 0xF0A718
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0xF0A7A8
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0xF0A8B8
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0xF0A9D4
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0xF0AB00
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0xF0AC1C
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0xF0AD38
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0xF0ADC8
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0xF0AE58
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0xF0AF84
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0xF0B094
	public static Exception TableInRelation() { }

	// RVA: 0xF0B124
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0xF0B240
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0xF0B2D0
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0xF0B360
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0xF0B3F0
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0xF0B480
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0xF0B590
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0xF0B6F0
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0xF0B824
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0xF0B978
	public static Exception NullRange() { }

	// RVA: 0xF0BA14
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0xF0BAA4
	public static Exception ProblematicChars(Char charValue) { }

	// RVA: 0xF0BC18
	public static Exception StorageSetFailed() { }

	// RVA: 0xF0BCA8
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0xF0BD44
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0xF0BDA0
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0xF0BECC
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0xF0BFF8
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0xF0C12C
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0xF0C248
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0xF0C364
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0xF0C480
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0xF0C59C
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0xF0C6B8
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0xF0C7D4
	public static Exception DatatypeNotDefined() { }

	// RVA: 0xF0C870
	public static Exception MismatchKeyLength() { }

	// RVA: 0xF0C90C
	public static Exception InvalidField(string name) { }

	// RVA: 0xF0CA28
	public static Exception InvalidSelector(string name) { }

	// RVA: 0xF0CB44
	public static Exception CircularComplexType(string name) { }

	// RVA: 0xF0CC60
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0xF0CD7C
	public static Exception InvalidKey(string name) { }

	// RVA: 0xF0CE98
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0xF0CFB4
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0xF0D050
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0xF0D16C
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0xF0D288
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0xF0D3B4
	public static Exception MissingRefer(string name) { }

	// RVA: 0xEFB1E8
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0xF0D4E8
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0xF0D578
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0xF0D614
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0xF0D6B0
	public static Exception NestedCircular(string name) { }

	// RVA: 0xF0D7CC
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0xF0D8E8
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0xF0D9F8
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0xF0DA88
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0xF0DB24
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0xF0DC40
	public static Exception FoundEntity() { }

	// RVA: 0xF0DCDC
	public static Exception MergeFailed(string name) { }

	// RVA: 0xF0DD50
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0xF0DE90
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0xF0DFB0
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0xF0E0CC
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

	// RVA: 0xF0E15C
	public void .ctor() { }

	// RVA: 0xF0E44C
	public void .ctor(string dataSetName) { }

	// RVA: 0xF0E650
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xF0E658
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xF0E704
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0xF0E70C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF0E714
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0xF0E97C
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF0EFA0
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0xF0E984
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xF0E928
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xF0FD20
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0xF10228
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0xF0EFA4
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF10400
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF0F16C
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF10700
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF11A98
	internal void FailedEnableConstraints() { }

	// RVA: 0xF11C54
	public bool get_CaseSensitive() { }

	// RVA: 0xF11C5C
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xF123A0
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xF123A8
	public DataViewManager get_DefaultViewManager() { }

	// RVA: 0xF124F4
	public bool get_EnforceConstraints() { }

	// RVA: 0xF11ACC
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0xF12C54
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0xF124FC
	internal void EnableConstraints() { }

	// RVA: 0xF12C5C
	public string get_DataSetName() { }

	// RVA: 0xF0E478
	public void set_DataSetName(string value) { }

	// RVA: 0xF12CE0
	public string get_Namespace() { }

	// RVA: 0xF12CE8
	public void set_Namespace(string value) { }

	// RVA: 0xF13248
	public string get_Prefix() { }

	// RVA: 0xF13250
	public void set_Prefix(string value) { }

	// RVA: 0xF11A0C
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF1340C
	public bool get_IsInitialized() { }

	// RVA: 0xF1341C
	public CultureInfo get_Locale() { }

	// RVA: 0xF13424
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xF135CC
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0xF141DC
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xF141E4
	public override ISite get_Site() { }

	// RVA: 0xF141EC
	public override void set_Site(ISite value) { }

	// RVA: 0xF143CC
	public DataRelationCollection get_Relations() { }

	// RVA: 0xF143D4
	public DataTableCollection get_Tables() { }

	// RVA: 0xF143DC
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xF14480
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xF14524
	public void BeginInit() { }

	// RVA: 0xF14530
	public void EndInit() { }

	// RVA: 0xF14760
	public void Clear() { }

	// RVA: 0xF149A8
	public virtual DataSet Clone() { }

	// RVA: 0xF0F9D4
	internal int EstimatedXmlStringSize() { }

	// RVA: 0xF15AA8
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xF15AAC
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0xF0F83C
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0xF15BE4
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0xF10FDC
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF16148
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xF166B8
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0xF16214
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xF15D48
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF15BEC
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xF1674C
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xF1699C
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0xF169A4
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0xF162EC
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0xF192D0
	private bool IsEmpty() { }

	// RVA: 0xF17D34
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xF11A04
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0xF19750
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xF0FAF4
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0xF195C4
	public void Merge(DataSet dataSet) { }

	// RVA: 0xF1A6EC
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF1A970
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF1A994
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0xF1A9F8
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF1AAE8
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0xF14984
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0xF146D0
	private void OnInitialized() { }

	// RVA: 0xF1AB0C
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0xF1AB10
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0xF1AB40
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0xF1AB44
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0xF12C64
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF1AB54
	internal DataTable[] TopLevelTables() { }

	// RVA: 0xF1AB5C
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0xF1AE98
	public virtual void Reset() { }

	// RVA: 0xF11F58
	internal bool ValidateCaseConstraint() { }

	// RVA: 0xF13D2C
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0xF1B17C
	internal DataTable FindTable(DataTable baseTable, PropertyDescriptor[] props, int propStart) { }

	// RVA: 0xF1B2A4
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xF1B62C
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xF1B8B8
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF1BA8C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF1BCE0
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF1BD18
	internal string get_MainTableName() { }

	// RVA: 0xF1BD20
	internal void set_MainTableName(string value) { }

	// RVA: 0xF1BD28
	internal int get_ObjectID() { }

}

// Namespace: 
internal struct RowDiffIdUsageSection
{
	// Fields
	private DataTable _targetTable; // 0x10

	// Methods

	// RVA: 0xF1BD30
	internal void Prepare(DataTable table) { }

}

// Namespace: 
internal struct DSRowDiffIdUsageSection
{
	// Fields
	private DataSet _targetDS; // 0x10

	// Methods

	// RVA: 0xF17CB0
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

	// RVA: 0xEDACF0
	public void .ctor() { }

	// RVA: 0xEDB2D4
	public void .ctor(string tableName) { }

	// RVA: 0xEDB348
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB8A4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xEDB9A0
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xEDB504
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0xEDBD78
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xEDD1FC
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0xEE04E4
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xEE1534
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0xEE22B8
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEE2494
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEDCAC8
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEDE168
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0xEE2950
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0xEE2664
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xEE2A38
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0xEE2D28
	public bool get_CaseSensitive() { }

	// RVA: 0xEE2D30
	public void set_CaseSensitive(bool value) { }

	// RVA: 0xEE2DD0
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0xEE2DE0
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0xEE3234
	internal void SuspendIndexEvents() { }

	// RVA: 0xEE3318
	public bool get_IsInitialized() { }

	// RVA: 0xEE3328
	private bool get_IsTypedDataTable() { }

	// RVA: 0xEE0C20
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0xEE33F8
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0xEE3400
	internal bool get_SelfNested() { }

	// RVA: 0xEE382C
	internal System.Collections.Generic.List<System.Data.Index> get_LiveIndexes() { }

	// RVA: 0xEE38FC
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0xEE3904
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0xEE3970
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0xEE3978
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0xEE3980
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0xEE3A28
	public DataColumnCollection get_Columns() { }

	// RVA: 0xEE3A30
	private CompareInfo get_CompareInfo() { }

	// RVA: 0xEE3A94
	public ConstraintCollection get_Constraints() { }

	// RVA: 0xEE3A9C
	private void ResetConstraints() { }

	// RVA: 0xEE3ABC
	public DataSet get_DataSet() { }

	// RVA: 0xEE3AC4
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xEE3B94
	public DataView get_DefaultView() { }

	// RVA: 0xEE3CA4
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0xEE3D0C
	internal bool get_EnforceConstraints() { }

	// RVA: 0xEE3D44
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0xEE4348
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0xEE4350
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0xEE3D94
	internal void EnableConstraints() { }

	// RVA: 0xEDFEF4
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xEE4358
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xEE4408
	public CultureInfo get_Locale() { }

	// RVA: 0xEE4410
	public void set_Locale(CultureInfo value) { }

	// RVA: 0xEE0F38
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0xEE48D8
	internal bool ShouldSerializeLocale() { }

	// RVA: 0xEE48E0
	public int get_MinimumCapacity() { }

	// RVA: 0xEE1500
	public void set_MinimumCapacity(int value) { }

	// RVA: 0xEE4900
	internal int get_RecordCapacity() { }

	// RVA: 0xEE4920
	internal int get_ElementColumnCount() { }

	// RVA: 0xEE4928
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0xEE3784
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0xEE4978
	internal bool get_MergingData() { }

	// RVA: 0xEE4980
	internal void set_MergingData(bool value) { }

	// RVA: 0xEE4988
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0xEE4990
	internal bool get_SchemaLoading() { }

	// RVA: 0xEE4998
	internal void CacheNestedParent() { }

	// RVA: 0xEE49C4
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0xEE4E78
	internal int get_NestedParentsCount() { }

	// RVA: 0xEE51C4
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0xEE52C4
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0xEE57D8
	public DataRowCollection get_Rows() { }

	// RVA: 0xEE57E0
	public string get_TableName() { }

	// RVA: 0xEE57E8
	public void set_TableName(string value) { }

	// RVA: 0xEE5F54
	internal string get_EncodedTableName() { }

	// RVA: 0xEE6004
	private string GetInheritedNamespace(System.Collections.Generic.List<System.Data.DataTable> visitedTables) { }

	// RVA: 0xEDD174
	public string get_Namespace() { }

	// RVA: 0xEDFAEC
	public void set_Namespace(string value) { }

	// RVA: 0xEE712C
	internal bool IsNamespaceInherited() { }

	// RVA: 0xEE620C
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0xEE6660
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0xEE713C
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0xEE6AD4
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0xEE7594
	public virtual void BeginInit() { }

	// RVA: 0xEE75A0
	public virtual void EndInit() { }

	// RVA: 0xEE7C14
	public string get_Prefix() { }

	// RVA: 0xEE7C1C
	public void set_Prefix(string value) { }

	// RVA: 0xEE7DC8
	internal DataColumn get_XmlText() { }

	// RVA: 0xEE7DD0
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0xEE7E9C
	internal Decimal get_MaxOccurs() { }

	// RVA: 0xEE7EA8
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0xEE7EB0
	internal Decimal get_MinOccurs() { }

	// RVA: 0xEE7EBC
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0xEE7EC4
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0xEE7F60
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0xEE7FF4
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0xEE8080
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0xEE84B0
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0xEE9034
	protected virtual DataTable CreateInstance() { }

	// RVA: 0xEE90C4
	public virtual DataTable Clone() { }

	// RVA: 0xEE90CC
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0xEE92DC
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0xEE9618
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0xEDED64
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0xEE9B40
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xEE9BF8
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xEE9CB0
	public override ISite get_Site() { }

	// RVA: 0xEE9CB8
	public override void set_Site(ISite value) { }

	// RVA: 0xEE9E98
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0xEE9EA8
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0xEE9EB4
	internal void InsertRow(DataRow row, Int64 proposedID, int pos, bool fireEvent) { }

	// RVA: 0xEEACF4
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0xEEAD28
	public void Clear() { }

	// RVA: 0xEEAD30
	internal void Clear(bool clearAll) { }

	// RVA: 0xEEB770
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0xEEB840
	internal void CommitRow(DataRow row) { }

	// RVA: 0xEEBAFC
	internal int Compare(string s1, string s2) { }

	// RVA: 0xEEBB04
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0xEEBCA0
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0xEEBD28
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0xEEBDB0
	private bool System.ComponentModel.IListSource.get_ContainsListCollection() { }

	// RVA: 0xEEBDB8
	internal void DeleteRow(DataRow row) { }

	// RVA: 0xEEBE58
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0xEEBF88
	internal void FreeRecord(int record) { }

	// RVA: 0xEEBFA8
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xEEC3D4
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xEEC5CC
	private IList System.ComponentModel.IListSource.GetList() { }

	// RVA: 0xEEC5D0
	internal System.Collections.Generic.List<System.Data.DataViewListener> GetListeners() { }

	// RVA: 0xEE47CC
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0xEE8B38
	internal void InsertRow(DataRow row, Int64 proposedID) { }

	// RVA: 0xEED634
	internal int NewRecord() { }

	// RVA: 0xEED728
	internal int NewUninitializedRecord() { }

	// RVA: 0xEED63C
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0xEE28F4
	internal DataRow NewEmptyRow() { }

	// RVA: 0xEED748
	private DataRow NewUninitializedRow() { }

	// RVA: 0xEED814
	public DataRow NewRow() { }

	// RVA: 0xEED990
	internal DataRow CreateEmptyRow() { }

	// RVA: 0xEED8FC
	private void NewRowCreated(DataRow row) { }

	// RVA: 0xEED780
	internal DataRow NewRow(int record) { }

	// RVA: 0xEEDD74
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0xEEDDDC
	protected virtual Type GetRowType() { }

	// RVA: 0xEEDE7C
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0xEEE088
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0xEEE0E0
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0xEEE1C4
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0xEEE2A8
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xEEE38C
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0xEEE39C
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0xEEBA4C
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEEB99C
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEEE3A0
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0xEEE484
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0xEEE568
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0xEEE64C
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0xEEE730
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0xEEE814
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0xEEE8F8
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0xEE7B08
	private void OnInitialized() { }

	// RVA: 0xEEBFE8
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0xEE5ED8
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0xEEE9DC
	internal void RecordChanged(int record) { }

	// RVA: 0xEEEBA8
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0xEEC7C0
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xEEC9A4
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0xEEEE88
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xEEF06C
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0xEEF29C
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0xEEFF70
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0xEF0124
	public virtual void Reset() { }

	// RVA: 0xEDED5C
	internal void ResetIndexes() { }

	// RVA: 0xEF04B0
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0xEF0710
	internal void RollbackRow(DataRow row) { }

	// RVA: 0xEED3C4
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEF07BC
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0xEEC5D8
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0xEE81A4
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool fireEvent, bool suppressEnsurePropertyChanged) { }

	// RVA: 0xEEA294
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, Exception deferredException) { }

	// RVA: 0xEE8200
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0xEF0A34
	private void RestoreShadowIndexes() { }

	// RVA: 0xEE31D4
	private void SetShadowIndexes() { }

	// RVA: 0xEF0A54
	internal void ShadowIndexCopy() { }

	// RVA: 0xEF0AF8
	public override string ToString() { }

	// RVA: 0xEF079C
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0xEF0BC4
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0xEF0E88
	internal DataColumn AddUniqueKey() { }

	// RVA: 0xEF0E90
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0xEF0F44
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0xEF0F58
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0xEDFE2C
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0xEF136C
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0xEF137C
	public void Merge(DataTable table) { }

	// RVA: 0xEF1388
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xEF1610
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0xEF1A58
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xEDFF80
	private bool CheckForClosureOnExpressionTables(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xEF1F00
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0xEF22C4
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0xEF231C
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0xEF2560
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0xEF4258
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0xEF4330
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0xEF5B4C
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0xEF3728
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0xEF5C18
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xEF43AC
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0xEF1B20
	private void CreateTableList(DataTable currentTable, System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xEF5E9C
	private void CreateRelationList(System.Collections.Generic.List<System.Data.DataTable> tableList, System.Collections.Generic.List<System.Data.DataRelation> relationList) { }

	// RVA: 0xEF641C
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0xEF6668
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xEF6678
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0xEF684C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xEF6A08
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xEF6A40
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0xEF6A4C
	internal Hashtable get_RowDiffId() { }

	// RVA: 0xEF6AD8
	internal int get_ObjectID() { }

	// RVA: 0xEF6AE0
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xEF6BD8
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0xEF6C78
	internal void EvaluateExpressions() { }

	// RVA: 0xEECCE8
	internal void EvaluateExpressions(DataRow row, DataRowAction action, System.Collections.Generic.List<System.Data.DataRow> cachedRows) { }

	// RVA: 0xEF6FD4
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0xEEB588
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0xEEF424
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

	// RVA: 0xF1BD68
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xF1BED8
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0xF1C0D8
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF1C5E4
	internal override object Eval() { }

	// RVA: 0xF1C5F8
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF1E850
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF1E88C
	internal override bool IsConstant() { }

	// RVA: 0xF1E928
	internal override bool IsTableConstant() { }

	// RVA: 0xF1E9AC
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF1EA30
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF1EAB4
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF1EB50
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF1CFD8
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0xF1D270
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0xF1ED34
	internal FunctionId get_Aggregate() { }

	// RVA: 0xF1EDDC
	internal bool get_IsAggregate() { }

	// RVA: 0xF1C3DC
	internal void Check() { }

	// RVA: 0xF1F0A4
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

	// RVA: 0xF1FA80
	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0xF1FD14
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

	// RVA: 0xF21D50
	private static void .cctor() { }

	// RVA: 0xF21DBC
	public void .ctor() { }

	// RVA: 0xF21DC4
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

	// RVA: 0xF20C74
	internal void .ctor(Scope previousScope, System.Collections.Generic.IEnumerable<System.Type> allowedTypes) { }

	// RVA: 0xF21140
	public void Dispose() { }

	// RVA: 0xF20764
	public bool IsAllowedType(Type type) { }

	// RVA: 0xF21220
	private static bool IsTypeUnconditionallyAllowed(Type type) { }

	// RVA: 0xF21418
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

	// RVA: 0xF21E2C
	private static void .cctor() { }

	// RVA: 0xF21E98
	public void .ctor() { }

	// RVA: 0xF21EA0
	internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

	// RVA: 0xF21EBC
	internal System.Collections.Generic.IEnumerable<System.Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }

}

// Namespace: System.Data
internal sealed class TypeLimiter
{
	// Fields
	private static Scope s_activeScope; // 0xFFFFFFFF
	private Scope m_instanceScope; // 0x10

	// Methods

	// RVA: 0xF20558
	private void .ctor(Scope scope) { }

	// RVA: 0xF2058C
	private static bool get_IsTypeLimitingDisabled() { }

	// RVA: 0xF20634
	public static TypeLimiter Capture() { }

	// RVA: 0xF206C0
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0xF2092C
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0xF20DF8
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0xF20F4C
	private static System.Collections.Generic.IEnumerable<System.Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0xF20A80
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

	// RVA: 0xF21EC4
	public virtual int get_Count() { }

	// RVA: 0xF21EF4
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0xF21F3C
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0xF21F6C
	public bool get_IsSynchronized() { }

	// RVA: 0xF21F74
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0xF22044
	public object get_SyncRoot() { }

	// RVA: 0xF22048
	protected virtual ArrayList get_List() { }

	// RVA: 0xF22050
	public void .ctor() { }

	// RVA: 0xF22058
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class ColumnTypeConverter
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0xF220E8
	public void .ctor() { }

	// RVA: 0xF220F0
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF221BC
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xF22718
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0xF227E4
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0xF229F8
	public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0xF22B3C
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0xF22B44
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xF22B4C
	private static void .cctor() { }

}

// Namespace: System.Data
internal class DataCommonEventSource
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static Int64 s_nextScopeId; // 0x8

	// Methods

	// RVA: 0xF23814
	internal void Trace(string message) { }

	// RVA: 0x315B3A8
	internal void Trace(string format, T0 arg0) { }

	// RVA: 0x315B3A8
	internal void Trace(string format, T0 arg0, T1 arg1) { }

	// RVA: 0x315B3A8
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2) { }

	// RVA: 0x315B3A8
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x315B3A8
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0x315B3A8
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

	// RVA: 0xF23824
	internal Int64 EnterScope(string message) { }

	// RVA: 0x315B3A8
	internal Int64 EnterScope(string format, T1 arg1) { }

	// RVA: 0x315B3A8
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2) { }

	// RVA: 0x315B3A8
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3) { }

	// RVA: 0x315B3A8
	internal Int64 EnterScope(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	// RVA: 0xF23904
	internal void ExitScope(Int64 scopeId) { }

	// RVA: 0xF23914
	public void .ctor() { }

	// RVA: 0xF2391C
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

	// RVA: 0xF23998
	public virtual string get_ConstraintName() { }

	// RVA: 0xF239A0
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0xF23E40
	internal string get_SchemaName() { }

	// RVA: 0xF23E88
	internal void set_SchemaName(string value) { }

	// RVA: 0xF23ED0
	internal virtual bool get_InCollection() { }

	// RVA: 0xF23ED8
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1
	public abstract DataTable get_Table() { }

	// RVA: 0xF23F38
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1
	internal abstract bool ContainsColumn(DataColumn column) { }

	// RVA: -1
	internal abstract bool CanEnableConstraint() { }

	// RVA: -1
	internal abstract Constraint Clone(DataSet destination) { }

	// RVA: -1
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup) { }

	// RVA: 0xF23FC4
	internal void CheckConstraint() { }

	// RVA: -1
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint) { }

	// RVA: -1
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException) { }

	// RVA: -1
	internal abstract void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: -1
	internal abstract void CheckState() { }

	// RVA: 0xF24024
	protected void CheckStateForProperty() { }

	// RVA: 0xF24134
	protected virtual DataSet get__DataSet() { }

	// RVA: -1
	internal abstract bool IsConstraintViolated() { }

	// RVA: 0xF2413C
	public override string ToString() { }

	// RVA: 0xF24148
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

	// RVA: 0xF241CC
	internal void .ctor(DataTable table) { }

	// RVA: 0xF24290
	protected override ArrayList get_List() { }

	// RVA: 0xF24298
	public Constraint get_Item(int index) { }

	// RVA: 0xF243A0
	internal DataTable get_Table() { }

	// RVA: 0xF243A8
	public Constraint get_Item(string name) { }

	// RVA: 0xF24658
	public void Add(Constraint constraint) { }

	// RVA: 0xF24660
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0xF25158
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0xF24CBC
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0xF24FB4
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0xF24BE8
	private bool AutoGenerated(Constraint constraint) { }

	// RVA: 0xF250F4
	private void ArrayAdd(Constraint constraint) { }

	// RVA: 0xF25204
	private void ArrayRemove(Constraint constraint) { }

	// RVA: 0xF24F84
	internal string AssignName() { }

	// RVA: 0xF25028
	private void BaseAdd(Constraint constraint) { }

	// RVA: 0xF25318
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0xF254E8
	private void BaseRemove(Constraint constraint) { }

	// RVA: 0xF257B0
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0xF257E0
	public void Clear() { }

	// RVA: 0xF25BE4
	public bool Contains(string name) { }

	// RVA: 0xF25C00
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF24A70
	internal Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0xF24DA8
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0xF25D94
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0xF25EC4
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF25CFC
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0xF244B0
	internal int InternalIndexOf(string constraintName) { }

	// RVA: 0xF25244
	private string MakeName(int index) { }

	// RVA: 0xF25134
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF23BB4
	internal void RegisterName(string name) { }

	// RVA: 0xF2613C
	public void Remove(Constraint constraint) { }

	// RVA: 0xF23DBC
	internal void UnregisterName(string name) { }

	// RVA: 0xF262C4
	internal void FinishInitConstraints() { }

}

// Namespace: System.Data
internal sealed class ConstraintConverter
{
	// Methods

	// RVA: 0xF26C10
	public void .ctor() { }

	// RVA: 0xF26C18
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF26CE4
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

	// RVA: 0xF27790
	public void .ctor(DataSet dataSet) { }

	// RVA: 0xF277FC
	public bool GetNext() { }

	// RVA: 0xF27B74
	public Constraint GetConstraint() { }

	// RVA: 0xF27B7C
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF27B84
	protected Constraint get_CurrentObject() { }

}

// Namespace: System.Data
internal class ForeignKeyConstraintEnumerator
{
	// Methods

	// RVA: 0xF27B8C
	public void .ctor(DataSet dataSet) { }

	// RVA: 0xF27BF8
	protected override bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0xF27C7C
	public ForeignKeyConstraint GetForeignKeyConstraint() { }

}

// Namespace: System.Data
internal sealed class ChildForeignKeyConstraintEnumerator
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF27CF8
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF27D80
	protected override bool IsValidCandidate(Constraint constraint) { }

}

// Namespace: System.Data
internal sealed class ParentForeignKeyConstraintEnumerator
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0xF27E2C
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0xF27EB4
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

	// RVA: 0xF27F64
	internal void .ctor(DataRow row) { }

	// RVA: 0xF27FDC
	public void .ctor(DataRow row, DataColumn column, object value) { }

	// RVA: 0xF28084
	public object get_ProposedValue() { }

	// RVA: 0xF2808C
	public void set_ProposedValue(object value) { }

	// RVA: 0xF28094
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

}

// Namespace: System.Data
public sealed class DataColumnChangeEventHandler
{
	// Methods

	// RVA: 0xF280C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF281EC
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

	// RVA: 0xF28200
	internal void .ctor(DataTable table) { }

	// RVA: 0xF283A4
	protected override ArrayList get_List() { }

	// RVA: 0xF283AC
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0xF283B4
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0xF283BC
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0xF283C4
	public DataColumn get_Item(int index) { }

	// RVA: 0xF26880
	public DataColumn get_Item(string name) { }

	// RVA: 0xF286A4
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0xF28764
	public void Add(DataColumn column) { }

	// RVA: 0xF28770
	internal void AddAt(int index, DataColumn column) { }

	// RVA: 0xF28FF8
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF2909C
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF29140
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF291E4
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF28E94
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0xF28E14
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0xF292E0
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0xF29580
	internal string AssignName() { }

	// RVA: 0xF28AA4
	private void BaseAdd(DataColumn column) { }

	// RVA: 0xF29AF8
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0xF29CE4
	private void BaseRemove(DataColumn column) { }

	// RVA: 0xF29E34
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0xF29288
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0xF2A87C
	public void Clear() { }

	// RVA: 0xF2AB54
	public bool Contains(string name) { }

	// RVA: 0xF2AC08
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF2ACAC
	public int IndexOf(string columnName) { }

	// RVA: 0xF2850C
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0xF2ADCC
	internal void FinishInitCollection() { }

	// RVA: 0xF2961C
	private string MakeName(int index) { }

	// RVA: 0xF28F3C
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF28A80
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF2AEAC
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF296F0
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0xF2AF08
	internal bool CanRegisterName(string name) { }

	// RVA: 0xF2AF74
	public void Remove(DataColumn column) { }

	// RVA: 0xF299CC
	internal void UnregisterName(string name) { }

	// RVA: 0xF2A79C
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0xF29420
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

}

// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor
{
	// Fields
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF2B088
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0xF2B0CC
	public override AttributeCollection get_Attributes() { }

	// RVA: 0xF2B29C
	internal DataColumn get_Column() { }

	// RVA: 0xF2B2A4
	public override Type get_ComponentType() { }

	// RVA: 0xF2B344
	public override bool get_IsReadOnly() { }

	// RVA: 0xF2B364
	public override Type get_PropertyType() { }

	// RVA: 0xF2B384
	public override bool Equals(object other) { }

	// RVA: 0xF2B40C
	public override int GetHashCode() { }

	// RVA: 0xF2B430
	public override bool CanResetValue(object component) { }

	// RVA: 0xF2B5F0
	public override object GetValue(object component) { }

	// RVA: 0xF2B684
	public override void ResetValue(object component) { }

	// RVA: 0xF2B814
	public override void SetValue(object component, object value) { }

	// RVA: 0xF2B8F8
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0xF2B900
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

	// RVA: 0xF2B958
	internal void .ctor() { }

	// RVA: 0xF2B9C4
	internal void .ctor(string rowError) { }

	// RVA: 0xF2BAE4
	internal string get_Text() { }

	// RVA: 0xF2BAEC
	internal void set_Text(string value) { }

	// RVA: 0xF2BB58
	internal bool get_HasErrors() { }

	// RVA: 0xF2BB94
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF2BF34
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0xF2BCC8
	internal void Clear(DataColumn column) { }

	// RVA: 0xF2BFD4
	internal void Clear() { }

	// RVA: 0xF2C07C
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0xF2BA78
	private void SetText(string errorText) { }

	// RVA: 0xF2BDE4
	internal int IndexOf(DataColumn column) { }

}

// Namespace: System.Data
internal struct DataKey
{
	// Fields
	private readonly DataColumn[] _columns; // 0x10

	// Methods

	// RVA: 0xF2C194
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0xF2C460
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF2C468
	internal bool get_HasValue() { }

	// RVA: 0xF2775C
	internal DataTable get_Table() { }

	// RVA: 0xF2C3BC
	internal void CheckState() { }

	// RVA: 0xF2C478
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0xF2C574
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0xF2A6D8
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF2C670
	public override int GetHashCode() { }

	// RVA: 0xF2C6E0
	public override bool Equals(object value) { }

	// RVA: 0xF2C810
	internal bool Equals(DataKey value) { }

	// RVA: 0xF2C8E8
	internal string[] GetColumnNames() { }

	// RVA: 0xF2C9C4
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0xF2CADC
	internal object[] GetKeyValues(int record) { }

	// RVA: 0xF2CC10
	internal Index GetSortIndex() { }

	// RVA: 0xF2CC68
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0xF2CCC4
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0xF2CD48
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

	// RVA: 0xF2CE44
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0xF2D3CC
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF2D49C
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF2D570
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF2D698
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0xF2D7F8
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0xF2D920
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0xF2A754
	internal DataKey get_ChildKey() { }

	// RVA: 0xF2D944
	public virtual DataTable get_ChildTable() { }

	// RVA: 0xF2D988
	public virtual DataSet get_DataSet() { }

	// RVA: 0xF2D9AC
	internal string[] get_ParentColumnNames() { }

	// RVA: 0xF2D9B4
	internal string[] get_ChildColumnNames() { }

	// RVA: 0xF2D9BC
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0xF2DA78
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0xF2DC30
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF2DDB8
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0xF2E0F8
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0xF2E110
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0xF2E134
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0xF2A778
	internal DataKey get_ParentKey() { }

	// RVA: 0xF2E13C
	public virtual DataTable get_ParentTable() { }

	// RVA: 0xF2E180
	public virtual string get_RelationName() { }

	// RVA: 0xF2E1A4
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0xF2E52C
	internal void CheckNestedRelations() { }

	// RVA: 0xF2E8EC
	public virtual bool get_Nested() { }

	// RVA: 0xF2E910
	public virtual void set_Nested(bool value) { }

	// RVA: 0xF30154
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0xF30178
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0xF30180
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0xF301A4
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0xF30230
	internal bool get_CheckMultipleNested() { }

	// RVA: 0xF30238
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0xF30240
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0xF30248
	internal void CheckState() { }

	// RVA: 0xF2D81C
	protected void CheckStateForProperty() { }

	// RVA: 0xF2D098
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0xF30524
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0xF30CFC
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0xF30004
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0xF30DE0
	public override string ToString() { }

	// RVA: 0xF2FB34
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0xF30DEC
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0xF30FD0
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

	// RVA: 0xF32748
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0xF32874
	protected override ArrayList get_List() { }

	// RVA: 0xF3287C
	private void EnsureDataSet() { }

	// RVA: 0xF328CC
	protected override DataSet GetDataSet() { }

	// RVA: 0xF32918
	public override DataRelation get_Item(int index) { }

	// RVA: 0xF32A24
	public override DataRelation get_Item(string name) { }

	// RVA: 0xF32B2C
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF32BD0
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF32C74
	private void AddCache(DataRelation relation) { }

	// RVA: 0xF32CCC
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xF32DCC
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0xF32EB0
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

	// RVA: 0xF32F7C
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0xF330A0
	protected override ArrayList get_List() { }

	// RVA: 0xF330A8
	public override void Clear() { }

	// RVA: 0xF330FC
	protected override DataSet GetDataSet() { }

	// RVA: 0xF33104
	public override DataRelation get_Item(int index) { }

	// RVA: 0xF33210
	public override DataRelation get_Item(string name) { }

	// RVA: 0xF33318
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0xF339FC
	protected override void RemoveCore(DataRelation relation) { }

	// RVA: 0xF33C8C
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

	// RVA: 0xF30FD8
	internal int get_ObjectID() { }

	// RVA: -1
	public abstract DataRelation get_Item(int index) { }

	// RVA: -1
	public abstract DataRelation get_Item(string name) { }

	// RVA: 0xF30FE0
	public void Add(DataRelation relation) { }

	// RVA: 0xF3129C
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0xF31538
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF31670
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF317A8
	internal string AssignName() { }

	// RVA: 0xF318AC
	public virtual void Clear() { }

	// RVA: 0xF31B14
	public virtual bool Contains(string name) { }

	// RVA: 0xF31B30
	internal int InternalIndexOf(string name) { }

	// RVA: -1
	protected abstract DataSet GetDataSet() { }

	// RVA: 0xF317D8
	private string MakeName(int index) { }

	// RVA: 0xF31CE8
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF31DCC
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF31EB0
	internal void RegisterName(string name) { }

	// RVA: 0xF320BC
	public void Remove(DataRelation relation) { }

	// RVA: 0xF322D8
	public void RemoveAt(int index) { }

	// RVA: 0xF32358
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0xF32540
	internal void UnregisterName(string name) { }

	// RVA: 0xF3269C
	protected void .ctor() { }

}

// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor
{
	// Fields
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF34164
	internal void .ctor(DataRelation dataRelation) { }

	// RVA: 0xF341BC
	internal DataRelation get_Relation() { }

	// RVA: 0xF341C4
	public override Type get_ComponentType() { }

	// RVA: 0xF34264
	public override bool get_IsReadOnly() { }

	// RVA: 0xF3426C
	public override Type get_PropertyType() { }

	// RVA: 0xF3430C
	public override bool Equals(object other) { }

	// RVA: 0xF34394
	public override int GetHashCode() { }

	// RVA: 0xF343B8
	public override bool CanResetValue(object component) { }

	// RVA: 0xF343C0
	public override object GetValue(object component) { }

	// RVA: 0xF34460
	public override void ResetValue(object component) { }

	// RVA: 0xF34464
	public override void SetValue(object component, object value) { }

	// RVA: 0xF34468
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

	// RVA: 0xF34470
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0xF34528
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0xF34544
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0xF34558
	internal bool get_HasPropertyChanged() { }

	// RVA: 0xF34568
	internal int get_RBTreeNodeId() { }

	// RVA: 0xF34570
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0xF3464C
	public string get_RowError() { }

	// RVA: 0xF346B4
	public void set_RowError(string value) { }

	// RVA: 0xF34918
	private void RowErrorChanged() { }

	// RVA: 0xF34978
	internal Int64 get_rowID() { }

	// RVA: 0xF34980
	internal void set_rowID(Int64 value) { }

	// RVA: 0xF349E8
	public DataRowState get_RowState() { }

	// RVA: 0xF34CA8
	public DataTable get_Table() { }

	// RVA: 0xF30074
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0xF34CB0
	internal int GetNestedParentCount() { }

	// RVA: 0xF34D70
	public void set_Item(string columnName, object value) { }

	// RVA: 0xF34C20
	public object get_Item(DataColumn column) { }

	// RVA: 0xF34E60
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0xF355A4
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0xF35740
	public void set_ItemArray(object[] value) { }

	// RVA: 0xF35BA8
	public void AcceptChanges() { }

	// RVA: 0xF35F4C
	public void BeginEdit() { }

	// RVA: 0xF352FC
	private bool BeginEditInternal() { }

	// RVA: 0xF35428
	public void CancelEdit() { }

	// RVA: 0xF351FC
	private void CheckColumn(DataColumn column) { }

	// RVA: 0xF35F50
	internal void CheckInTable() { }

	// RVA: 0xF35F98
	public void Delete() { }

	// RVA: 0xF3549C
	public void EndEdit() { }

	// RVA: 0xF36008
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0xF36078
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0xF36450
	public string GetColumnError(string columnName) { }

	// RVA: 0xF36304
	public string GetColumnError(DataColumn column) { }

	// RVA: 0xF364C4
	public void ClearErrors() { }

	// RVA: 0xF2A66C
	internal void ClearError(DataColumn column) { }

	// RVA: 0xF36530
	public bool get_HasErrors() { }

	// RVA: 0xF36580
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0xF36670
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0xF36678
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF34DF4
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0xF3014C
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0xF367AC
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF368D4
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0xF3698C
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0xF36994
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0xF36AC8
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0xF36B60
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0xF36BB8
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0xF2DC00
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0xF36C38
	internal int GetCurrentRecordNo() { }

	// RVA: 0xF3528C
	internal int GetDefaultRecord() { }

	// RVA: 0xF36C80
	internal int GetOriginalRecordNo() { }

	// RVA: 0xF353E0
	private int GetProposedRecordNo() { }

	// RVA: 0xF355F4
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0xF36CC8
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0xF36CF4
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0xF36D48
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0xF36D54
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF2E03C
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0xF36F20
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0xF36FB0
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0xF37050
	public void RejectChanges() { }

	// RVA: 0xF349B8
	internal void ResetLastChangedColumn() { }

	// RVA: 0xF376CC
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0xF37888
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0xF37CD4
	internal void SetParentRowToDBNull() { }

	// RVA: 0xF37FAC
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0xF38134
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }

}

// Namespace: System.Data
public sealed class DataRowBuilder
{
	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0xF38510
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

	// RVA: 0xF38558
	public void .ctor(DataRow row, DataRowAction action) { }

}

// Namespace: System.Data
public sealed class DataRowChangeEventHandler
{
	// Methods

	// RVA: 0xF385E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF38708
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }

}

// Namespace: 
private sealed class DataRowTree
{
	// Methods

	// RVA: 0xF38804
	internal void .ctor() { }

	// RVA: 0xF38F3C
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0xF38F70
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

	// RVA: 0xF3871C
	internal void .ctor(DataTable table) { }

	// RVA: 0xF3885C
	public override int get_Count() { }

	// RVA: 0xF2A5F4
	public DataRow get_Item(int index) { }

	// RVA: 0xF388B0
	public void Add(DataRow row) { }

	// RVA: 0xF388D4
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0xF38B18
	public int IndexOf(DataRow row) { }

	// RVA: 0xF38BC0
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0xF38C2C
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0xF38CA0
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0xF38D1C
	internal void ArrayClear() { }

	// RVA: 0xF38D70
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0xF38E10
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0xF38E7C
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0xF38EE8
	public override IEnumerator GetEnumerator() { }

}

// Namespace: System.Data
internal sealed class DataRowCreatedEventHandler
{
	// Methods

	// RVA: 0xF38FA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF390C8
	public virtual void Invoke(object sender, DataRow r) { }

}

// Namespace: System.Data
internal sealed class DataSetClearEventhandler
{
	// Methods

	// RVA: 0xF390DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF39200
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

	// RVA: 0xF39214
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0xF39264
	public override bool Equals(object other) { }

	// RVA: 0xF39270
	public override int GetHashCode() { }

	// RVA: 0xF39294
	public DataView get_DataView() { }

	// RVA: 0xF3929C
	private string System.ComponentModel.IDataErrorInfo.get_Item(string colName) { }

	// RVA: 0xF392B8
	private string System.ComponentModel.IDataErrorInfo.get_Error() { }

	// RVA: 0xF39328
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0xF39384
	internal int GetRecord() { }

	// RVA: 0xF393D4
	internal bool HasRecord() { }

	// RVA: 0xF2B568
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0xF2B760
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0xF39438
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0xF34458
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0xF39624
	public DataRow get_Row() { }

	// RVA: 0xF3962C
	public void BeginEdit() { }

	// RVA: 0xF39638
	public void CancelEdit() { }

	// RVA: 0xF39714
	public void EndEdit() { }

	// RVA: 0xF396E8
	public bool get_IsNew() { }

	// RVA: 0xF39778
	public void add_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF3981C
	public void remove_PropertyChanged(PropertyChangedEventHandler value) { }

	// RVA: 0xF398C0
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0xF39954
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xF399B0
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xF399B8
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xF399C0
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xF399C8
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xF399D0
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xF399D8
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xF399E0
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xF39A3C
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xF39A98
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xF39B40
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xF39BF0
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0xF39BF4
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

	// RVA: 0xF39C80
	public void .ctor(DataTable dataTable) { }

}

// Namespace: System.Data
public sealed class DataTableClearEventHandler
{
	// Methods

	// RVA: 0xF39CF8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF39E1C
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

	// RVA: 0xF39E30
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0xF39FE0
	protected override ArrayList get_List() { }

	// RVA: 0xF39FE8
	internal int get_ObjectID() { }

	// RVA: 0xF39FF0
	public DataTable get_Item(int index) { }

	// RVA: 0xF269E4
	public DataTable get_Item(string name) { }

	// RVA: 0xF26AF4
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0xF3A544
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0xF3A680
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0xF3A7C4
	public void Add(DataTable table) { }

	// RVA: 0xF3AE08
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF3AF40
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0xF3ACFC
	private void ArrayAdd(DataTable table) { }

	// RVA: 0xF3B078
	internal string AssignName() { }

	// RVA: 0xF3AB5C
	private void BaseAdd(DataTable table) { }

	// RVA: 0xF3B45C
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0xF3B638
	private void BaseRemove(DataTable table) { }

	// RVA: 0xF3B6B4
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0xF3BD4C
	public void Clear() { }

	// RVA: 0xF3B1AC
	public bool Contains(string name) { }

	// RVA: 0xF3C098
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0xF3C2DC
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0xF3C428
	public int IndexOf(DataTable table) { }

	// RVA: 0xF3C518
	public int IndexOf(string tableName) { }

	// RVA: 0xF3C534
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0xF3C5A0
	internal void ReplaceFromInference(System.Collections.Generic.List<System.Data.DataTable> tableList) { }

	// RVA: 0xF3A138
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0xF3A38C
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0xF3C5F4
	internal void FinishInitCollection() { }

	// RVA: 0xF3B0D8
	private string MakeName(int index) { }

	// RVA: 0xF3AD24
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF3AA78
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0xF3B1C8
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0xF3C688
	public void Remove(DataTable table) { }

	// RVA: 0xF3BC10
	internal void UnregisterName(string name) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventArgs
{
	// Fields
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0xF3C884
	public void .ctor(DataRow dataRow) { }

}

// Namespace: System.Data
public sealed class DataTableNewRowEventHandler
{
	// Methods

	// RVA: 0xF3C8FC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF3CA20
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }

}

// Namespace: System.Data
internal sealed class DataTablePropertyDescriptor
{
	// Fields
	private readonly DataTable <Table>k__BackingField; // 0x88

	// Methods

	// RVA: 0xF3CA34
	public DataTable get_Table() { }

	// RVA: 0xF3CA3C
	internal void .ctor(DataTable dataTable) { }

	// RVA: 0xF3CA80
	public override Type get_ComponentType() { }

	// RVA: 0xF3CB20
	public override bool get_IsReadOnly() { }

	// RVA: 0xF3CB28
	public override Type get_PropertyType() { }

	// RVA: 0xF3CBC8
	public override bool Equals(object other) { }

	// RVA: 0xF3CC50
	public override int GetHashCode() { }

	// RVA: 0xF3CC74
	public override bool CanResetValue(object component) { }

	// RVA: 0xF3CC7C
	public override object GetValue(object component) { }

	// RVA: 0xF3CDC0
	public override void ResetValue(object component) { }

	// RVA: 0xF3CDC4
	public override void SetValue(object component, object value) { }

	// RVA: 0xF3CDC8
	public override bool ShouldSerializeValue(object component) { }

}

// Namespace: System.Data
internal sealed class DataTableTypeConverter
{
	// Methods

	// RVA: 0xF3CDD0
	public void .ctor() { }

	// RVA: 0xF3CE84
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

}

// Namespace: 
private sealed class DataRowReferenceComparer
{
	// Fields
	internal static readonly DataRowReferenceComparer s_default; // 0x0

	// Methods

	// RVA: 0xF42F8C
	private void .ctor() { }

	// RVA: 0xF42F94
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0xF42FA0
	public int GetHashCode(DataRow obj) { }

	// RVA: 0xF42FBC
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

	// RVA: 0xF3CE8C
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0xF3D484
	public void .ctor(DataTable table) { }

	// RVA: 0xF3D898
	public bool get_AllowDelete() { }

	// RVA: 0xF3D8A0
	public bool get_AllowEdit() { }

	// RVA: 0xF3D8A8
	public bool get_AllowNew() { }

	// RVA: 0xF3D8B0
	public int get_Count() { }

	// RVA: 0xF3D904
	private int get_CountFromIndex() { }

	// RVA: 0xF3D920
	public DataViewManager get_DataViewManager() { }

	// RVA: 0xF3D928
	public bool get_IsInitialized() { }

	// RVA: 0xF3D938
	protected bool get_IsOpen() { }

	// RVA: 0xF3D940
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xF3D948
	public virtual string get_RowFilter() { }

	// RVA: 0xF3DA60
	public virtual void set_RowFilter(string value) { }

	// RVA: 0xF3DC84
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0xF3DC8C
	public void set_RowStateFilter(DataViewRowState value) { }

	// RVA: 0xF3DDF4
	public string get_Sort() { }

	// RVA: 0xF3DE4C
	public void set_Sort(string value) { }

	// RVA: 0xF3E0CC
	internal System.Comparison<System.Data.DataRow> get_SortComparison() { }

	// RVA: 0xF3E0D4
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xF3E0D8
	public DataTable get_Table() { }

	// RVA: 0xF3E0E0
	public void set_Table(DataTable value) { }

	// RVA: 0xF3E3A8
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0xF3E4A0
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0xF3E424
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0xF3E628
	public virtual DataRowView AddNew() { }

	// RVA: 0xF3EAD8
	public void BeginInit() { }

	// RVA: 0xF3EAE4
	public void EndInit() { }

	// RVA: 0xF3E968
	private void CheckOpen() { }

	// RVA: 0xF3E06C
	private void CheckSort(string sort) { }

	// RVA: 0xF3ED70
	protected void Close() { }

	// RVA: 0xF3EDC8
	public void CopyTo(Array array, int index) { }

	// RVA: 0xF3F0B8
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0xF3F390
	public void Delete(int index) { }

	// RVA: 0xF3F3B8
	internal void Delete(DataRow row) { }

	// RVA: 0xF3F7C8
	protected override void Dispose(bool disposing) { }

	// RVA: 0xF3F5A0
	internal void FinishAddNew(bool success) { }

	// RVA: 0xF3F828
	public IEnumerator GetEnumerator() { }

	// RVA: 0xF3F8EC
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xF3F8F4
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xF3F8FC
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xF3F990
	private void System.Collections.IList.Clear() { }

	// RVA: 0xF3F9C0
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xF3FA58
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xF3E9AC
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0xF3FAF4
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0xF3FB50
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xF3FB80
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xF3FCB4
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xF3FCDC
	internal Index GetFindIndex(string column, bool keepIndex) { }

	// RVA: 0xF3FE98
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xF3FEA0
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xF3FEB0
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xF3FEB8
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xF3FEC0
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xF3FEC8
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xF3FED0
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xF3FED8
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xF3FF58
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xF3FFF8
	internal PropertyDescriptor GetSortProperty() { }

	// RVA: 0xF40098
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xF400D8
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF40210
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF40348
	public void add_Initialized(EventHandler value) { }

	// RVA: 0xF403EC
	public void remove_Initialized(EventHandler value) { }

	// RVA: 0xF40490
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xF404D4
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF405E4
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xF40880
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xF408C4
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xF409BC
	private void System.ComponentModel.IBindingListView.ApplySort(ListSortDescriptionCollection sorts) { }

	// RVA: 0xF404FC
	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF40EE0
	private void System.ComponentModel.IBindingListView.RemoveFilter() { }

	// RVA: 0xF40FE4
	private string System.ComponentModel.IBindingListView.get_Filter() { }

	// RVA: 0xF40FF4
	private void System.ComponentModel.IBindingListView.set_Filter(string value) { }

	// RVA: 0xF41004
	private ListSortDescriptionCollection System.ComponentModel.IBindingListView.get_SortDescriptions() { }

	// RVA: 0xF41008
	internal ListSortDescriptionCollection GetSortDescriptions() { }

	// RVA: 0xF412AC
	private bool System.ComponentModel.IBindingListView.get_SupportsAdvancedSorting() { }

	// RVA: 0xF412B4
	private bool System.ComponentModel.IBindingListView.get_SupportsFiltering() { }

	// RVA: 0xF412BC
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF41378
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF41448
	internal virtual IFilter GetFilter() { }

	// RVA: 0xF41450
	private int GetRecord(int recordIndex) { }

	// RVA: 0xF3E4D0
	internal DataRow GetRow(int index) { }

	// RVA: 0xF3F028
	private DataRowView GetRowView(int record) { }

	// RVA: 0xF3E5B0
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0xF4151C
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0xF415B8
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0xF41684
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xF41C6C
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF3ECE0
	private void OnInitialized() { }

	// RVA: 0xF42030
	protected void Reset() { }

	// RVA: 0xF419A8
	internal void ResetRowViewCache() { }

	// RVA: 0xF42060
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xF422B4
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0xF3D4F8
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0xF3EDB4
	protected void UpdateIndex() { }

	// RVA: 0xF42678
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0xF422BC
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0xF42884
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF42AA4
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF42CC4
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF42EE4
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF42EF4
	internal int get_ObjectID() { }

	// RVA: 0xF42EFC
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

	// RVA: 0xF3D208
	internal void .ctor(DataView dv) { }

	// RVA: 0xF43028
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF4310C
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF431CC
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF4329C
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0xF43378
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF3D298
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0xF3E3A0
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0xF43638
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0xF42790
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0xF42680
	internal void UnregisterListChangedEvent() { }

	// RVA: 0xF430E8
	private void CleanUp(bool updateListeners) { }

	// RVA: 0xF43438
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

	// RVA: 0xF438F8
	internal void .ctor(DataSet dataSet, bool locked) { }

	// RVA: 0xF43BF0
	public DataSet get_DataSet() { }

	// RVA: 0xF43BF8
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0xF43C00
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF43CF4
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0xF43CFC
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0xF43D00
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0xF43D08
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0xF43D10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0xF43D18
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0xF43DB0
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0xF43DB8
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0xF43DE8
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0xF43E18
	private void System.Collections.IList.Clear() { }

	// RVA: 0xF43E48
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0xF43E58
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0xF43E6C
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0xF43E9C
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0xF43ECC
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0xF43EFC
	private bool System.ComponentModel.IBindingList.get_AllowNew() { }

	// RVA: 0xF43F04
	private object System.ComponentModel.IBindingList.AddNew() { }

	// RVA: 0xF43F4C
	private bool System.ComponentModel.IBindingList.get_AllowEdit() { }

	// RVA: 0xF43F54
	private bool System.ComponentModel.IBindingList.get_AllowRemove() { }

	// RVA: 0xF43F5C
	private bool System.ComponentModel.IBindingList.get_SupportsChangeNotification() { }

	// RVA: 0xF43F64
	private bool System.ComponentModel.IBindingList.get_SupportsSearching() { }

	// RVA: 0xF43F6C
	private bool System.ComponentModel.IBindingList.get_SupportsSorting() { }

	// RVA: 0xF43F74
	private bool System.ComponentModel.IBindingList.get_IsSorted() { }

	// RVA: 0xF43FBC
	private PropertyDescriptor System.ComponentModel.IBindingList.get_SortProperty() { }

	// RVA: 0xF44004
	private ListSortDirection System.ComponentModel.IBindingList.get_SortDirection() { }

	// RVA: 0xF4404C
	public void add_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF440F0
	public void remove_ListChanged(ListChangedEventHandler value) { }

	// RVA: 0xF44194
	private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor property) { }

	// RVA: 0xF44198
	private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction) { }

	// RVA: 0xF441E0
	private int System.ComponentModel.IBindingList.Find(PropertyDescriptor property, object key) { }

	// RVA: 0xF44228
	private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor property) { }

	// RVA: 0xF4422C
	private void System.ComponentModel.IBindingList.RemoveSort() { }

	// RVA: 0xF44274
	private string System.ComponentModel.ITypedList.GetListName(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF4434C
	private PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors) { }

	// RVA: 0xF444E4
	public DataView CreateDataView(DataTable table) { }

	// RVA: 0xF445DC
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF446D4
	protected virtual void TableCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF44924
	protected virtual void RelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0xF44B44
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class DataViewManagerListItemTypeDescriptor
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private PropertyDescriptorCollection _propsCollection; // 0x18

	// Methods

	// RVA: 0xF43AFC
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xF3CCF4
	internal DataView GetDataView(DataTable table) { }

	// RVA: 0xF44BCC
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0xF44C28
	private string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { }

	// RVA: 0xF44C30
	private string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { }

	// RVA: 0xF44C38
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0xF44C40
	private EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { }

	// RVA: 0xF44C48
	private PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { }

	// RVA: 0xF44C50
	private object System.ComponentModel.ICustomTypeDescriptor.GetEditor(Type editorBaseType) { }

	// RVA: 0xF44C58
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { }

	// RVA: 0xF44CB4
	private EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { }

	// RVA: 0xF44D10
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0xF44DB8
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0xF44FC8
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

	// RVA: 0xF44FCC
	internal void .ctor() { }

	// RVA: 0xF45058
	public bool get_ApplyDefaultSort() { }

	// RVA: 0xF45060
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0xF45078
	internal void SetDataTable(DataTable table) { }

	// RVA: 0xF45090
	public string get_RowFilter() { }

	// RVA: 0xF45098
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0xF450A0
	public string get_Sort() { }

}

// Namespace: 
private sealed class DataViewSettingsEnumerator
{
	// Fields
	private DataViewSettingCollection _dataViewSettings; // 0x10
	private IEnumerator _tableEnumerator; // 0x18

	// Methods

	// RVA: 0xF45550
	public void .ctor(DataViewManager dvm) { }

	// RVA: 0xF456D8
	public bool MoveNext() { }

	// RVA: 0xF4578C
	public void Reset() { }

	// RVA: 0xF45844
	public object get_Current() { }

}

// Namespace: System.Data
public class DataViewSettingCollection
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Methods

	// RVA: 0xF43B30
	internal void .ctor(DataViewManager dataViewManager) { }

	// RVA: 0xF450A8
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0xF4523C
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0xF452F8
	public void CopyTo(Array ar, int index) { }

	// RVA: 0xF45510
	public virtual int get_Count() { }

	// RVA: 0xF454A8
	public IEnumerator GetEnumerator() { }

	// RVA: 0xF456A4
	public bool get_IsSynchronized() { }

	// RVA: 0xF456AC
	public object get_SyncRoot() { }

	// RVA: 0xF456B0
	internal void Remove(DataTable table) { }

}

// Namespace: System.Data
internal sealed class DefaultValueTypeConverter
{
	// Methods

	// RVA: 0xF45964
	public void .ctor() { }

	// RVA: 0xF4596C
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0xF45B58
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

	// RVA: 0xF45D04
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0xF45D10
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0xF45E50
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF460EC
	internal static void Bind(DataRelation relation, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF4626C
	internal override object Eval() { }

	// RVA: 0xF46280
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF4653C
	internal override object Eval(int[] records) { }

	// RVA: 0xF465C4
	internal override bool IsConstant() { }

	// RVA: 0xF465CC
	internal override bool IsTableConstant() { }

	// RVA: 0xF465D4
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF465DC
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF465EC
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF46680
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

	// RVA: 0xF46684
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xF466F8
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF4676C
	internal override object Eval() { }

	// RVA: 0xF46780
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF4C41C
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF4C434
	internal override bool IsConstant() { }

	// RVA: 0xF4C488
	internal override bool IsTableConstant() { }

	// RVA: 0xF4C4DC
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF4C534
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF4C58C
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF4C5F4
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF4CBD4
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0xF4CC10
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xF4CC4C
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0xF4CC54
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0xF46798
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0xF4F2A4
	private DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0xF4F2C8
	private static StorageType GetPrecedenceType(DataTypePrecedence code) { }

	// RVA: 0xF4F2EC
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0xF4F3A8
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0xF4EDBC
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xF4E49C
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0xF4F47C
	private int SqlResultType(int typeCode) { }

}

// Namespace: System.Data
internal sealed class LikeNode
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0xF4F4CC
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0xF4F540
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF4FB00
	internal string AnalyzePattern(string pat) { }

}

// Namespace: System.Data
internal sealed class ConstNode
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0xF50060
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0xF4C8A0
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0xF50A68
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF50A70
	internal override object Eval() { }

	// RVA: 0xF50A78
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF50A84
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF50A90
	internal override bool IsConstant() { }

	// RVA: 0xF50A98
	internal override bool IsTableConstant() { }

	// RVA: 0xF50AA0
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF50AA8
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF50AB0
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF505C8
	private object SmallestDecimal(object constant) { }

	// RVA: 0xF50068
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

	// RVA: 0xF3DC7C
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0xF50AB4
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0xF3DA04
	internal string get_Expression() { }

	// RVA: 0xF51EB4
	internal bool get_HasValue() { }

	// RVA: 0xF51D6C
	internal void Bind(DataTable table) { }

	// RVA: 0xF46664
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0xF51EC4
	internal object Evaluate() { }

	// RVA: 0xF51ED0
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0xF52108
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xF521F8
	internal DataColumn[] GetDependency() { }

	// RVA: 0xF52200
	internal bool IsTableAggregate() { }

	// RVA: 0xF52218
	internal static bool IsUnknown(object value) { }

	// RVA: 0xF522A0
	internal bool HasLocalAggregate() { }

	// RVA: 0xF522B8
	internal bool HasRemoteAggregate() { }

	// RVA: 0xF4E180
	internal static bool ToBoolean(object value) { }

}

// Namespace: System.Data
internal abstract class ExpressionNode
{
	// Fields
	private DataTable _table; // 0x10

	// Methods

	// RVA: 0xF45E1C
	protected void .ctor(DataTable table) { }

	// RVA: 0xF4E100
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xF522D0
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0xF522D8
	protected DataTable get_table() { }

	// RVA: 0xF522E0
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

	// RVA: 0xF522E8
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0xF4F46C
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0xF4F284
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0xF4F368
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0xF4F420
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0xF4F398
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0xF4F43C
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0xF4F45C
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0xF4F4AC
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0xF522F0
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0xF52300
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

	// RVA: 0xF53FB4
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

	// RVA: 0xF50CD4
	internal void .ctor(DataTable table) { }

	// RVA: 0xF50DA4
	internal void LoadExpression(string data) { }

	// RVA: 0xF5231C
	internal void StartScan() { }

	// RVA: 0xF50EAC
	internal ExpressionNode Parse() { }

	// RVA: 0xF52EFC
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0xF52EBC
	private ExpressionNode NodePop() { }

	// RVA: 0xF52E70
	private ExpressionNode NodePeek() { }

	// RVA: 0xF52DC8
	private void NodePush(ExpressionNode node) { }

	// RVA: 0xF52A68
	private void BuildExpression(int pri) { }

	// RVA: 0xF52D74
	internal void CheckToken(Tokens token) { }

	// RVA: 0xF523BC
	internal Tokens Scan() { }

	// RVA: 0xF536B0
	private void ScanNumeric() { }

	// RVA: 0xF53A94
	private void ScanName() { }

	// RVA: 0xF53524
	private void ScanName(Char chEnd, Char esc, string charsToEscape) { }

	// RVA: 0xF5337C
	private void ScanDate() { }

	// RVA: 0xF537F0
	private void ScanBinaryConstant() { }

	// RVA: 0xF53804
	private void ScanReserved() { }

	// RVA: 0xF5343C
	private void ScanString(Char escape) { }

	// RVA: 0xF52D18
	internal void ScanToken(Tokens token) { }

	// RVA: 0xF53310
	private void ScanWhite() { }

	// RVA: 0xF53B20
	private bool IsWhiteSpace(Char ch) { }

	// RVA: 0xF53A48
	private bool IsAlphaNumeric(Char ch) { }

	// RVA: 0xF537F4
	private bool IsDigit(Char ch) { }

	// RVA: 0xF53B00
	private bool IsAlpha(Char ch) { }

	// RVA: 0xF53B30
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

	// RVA: 0xF53FEC
	internal void .ctor(Nodes type, int op, int pri) { }

}

// Namespace: System.Data
[Serializable]
public class InvalidExpressionException
{
	// Methods

	// RVA: 0xF5402C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF54034
	public void .ctor() { }

	// RVA: 0xF5403C
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class EvaluateException
{
	// Methods

	// RVA: 0xF54044
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF5404C
	public void .ctor() { }

	// RVA: 0xF54054
	public void .ctor(string s) { }

}

// Namespace: System.Data
[Serializable]
public class SyntaxErrorException
{
	// Methods

	// RVA: 0xF5405C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF54064
	public void .ctor() { }

	// RVA: 0xF5406C
	public void .ctor(string s) { }

}

// Namespace: System.Data
internal sealed class ExprException
{
	// Methods

	// RVA: 0xF54074
	private static OverflowException _Overflow(string error) { }

	// RVA: 0xF540E8
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0xF5415C
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0xF541D0
	private static EvaluateException _Eval(string error) { }

	// RVA: 0xF54244
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0xF542B8
	public static Exception InvokeArgument() { }

	// RVA: 0xF54300
	public static Exception NYI(string moreinfo) { }

	// RVA: 0xF543B0
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0xF5458C
	public static Exception MissingOperator(string token) { }

	// RVA: 0xF5463C
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0xF546EC
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0xF54758
	public static Exception ExpressionTooComplex() { }

	// RVA: 0xF547F4
	public static Exception UnboundName(string name) { }

	// RVA: 0xF548A4
	public static Exception InvalidString(string str) { }

	// RVA: 0xF54954
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0xF54A04
	public static Exception SyntaxError() { }

	// RVA: 0xF54AA0
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0xF54B50
	public static Exception MissingRightParen() { }

	// RVA: 0xF54BEC
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0xF54CE8
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0xF54E44
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0xF54F2C
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0xF55014
	public static Exception InvalidName(string name) { }

	// RVA: 0xF550C4
	public static Exception InvalidDate(string date) { }

	// RVA: 0xF55174
	public static Exception NonConstantArgument() { }

	// RVA: 0xF55210
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0xF552C0
	public static Exception InWithoutParentheses() { }

	// RVA: 0xF5535C
	public static Exception InWithoutList() { }

	// RVA: 0xF553F8
	public static Exception InvalidIsSyntax() { }

	// RVA: 0xF55494
	public static Exception Overflow(Type type) { }

	// RVA: 0xF5555C
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0xF5567C
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0xF55778
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0xF558BC
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0xF55A00
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0xF55ADC
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0xF55B8C
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0xF55C3C
	public static Exception TooManyRightParentheses() { }

	// RVA: 0xF55CD8
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0xF55D90
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0xF55E40
	public static Exception AggregateArgument() { }

	// RVA: 0xF55EDC
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0xF55F8C
	public static Exception EvalNoContext() { }

	// RVA: 0xF56028
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0xF560D8
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0xF56188
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0xF56238
	public static Exception LookupArgument() { }

	// RVA: 0xF562D4
	public static Exception InvalidType(string typeName) { }

	// RVA: 0xF56384
	public static Exception InvalidHoursArgument() { }

	// RVA: 0xF56420
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0xF564BC
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0xF56558
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0xF565F4
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

	// RVA: 0xF56668
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0xF566B8
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF5693C
	internal override object Eval() { }

	// RVA: 0xF56968
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF56A88
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF56AC0
	internal override bool IsConstant() { }

	// RVA: 0xF56AC8
	internal override bool IsTableConstant() { }

	// RVA: 0xF56AD0
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF56AD8
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF56AE0
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF56AF0
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

	// RVA: 0xF56AF4
	internal void .ctor(DataTable table, Char[] text, int start, int pos) { }

	// RVA: 0xF56D98
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0xF56DCC
	internal override bool get_IsSqlColumn() { }

	// RVA: 0xF56DEC
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF5701C
	internal override object Eval() { }

	// RVA: 0xF57048
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF570F0
	internal override object Eval(int[] records) { }

	// RVA: 0xF57128
	internal override bool IsConstant() { }

	// RVA: 0xF57130
	internal override bool IsTableConstant() { }

	// RVA: 0xF57188
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF571E0
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF57238
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF572A0
	internal override ExpressionNode Optimize() { }

	// RVA: 0xF56B48
	internal static string ParseName(Char[] text, int start, int pos) { }

}

// Namespace: System.Data
internal sealed class Operators
{
	// Fields
	private static readonly int[] s_priority; // 0x0
	private static readonly string[] s_looks; // 0x8

	// Methods

	// RVA: 0xF572A4
	internal static bool IsArithmetical(int op) { }

	// RVA: 0xF572C0
	internal static bool IsLogical(int op) { }

	// RVA: 0xF572E0
	internal static bool IsRelational(int op) { }

	// RVA: 0xF572F0
	internal static int Priority(int op) { }

	// RVA: 0xF54498
	internal static string ToString(int op) { }

	// RVA: 0xF573D0
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class UnaryNode
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0xF57C70
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0xF57CB4
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF57D08
	internal override object Eval() { }

	// RVA: 0xF57D1C
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF58450
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF57D60
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0xF58474
	internal override bool IsConstant() { }

	// RVA: 0xF58498
	internal override bool IsTableConstant() { }

	// RVA: 0xF584BC
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF584E0
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF58504
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0xF5852C
	internal override ExpressionNode Optimize() { }

}

// Namespace: System.Data
internal sealed class ZeroOpNode
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0xF585FC
	internal void .ctor(int op) { }

	// RVA: 0xF5862C
	internal override void Bind(DataTable table, System.Collections.Generic.List<System.Data.DataColumn> list) { }

	// RVA: 0xF58630
	internal override object Eval() { }

	// RVA: 0xF5872C
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0xF58738
	internal override object Eval(int[] recordNos) { }

	// RVA: 0xF58744
	internal override bool IsConstant() { }

	// RVA: 0xF5874C
	internal override bool IsTableConstant() { }

	// RVA: 0xF58754
	internal override bool HasLocalAggregate() { }

	// RVA: 0xF5875C
	internal override bool HasRemoteAggregate() { }

	// RVA: 0xF58764
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

	// RVA: 0xF58768
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF587B4
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF58998
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0xF58A44
	internal DataKey get_ChildKey() { }

	// RVA: 0xF58A6C
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0xF58A98
	public override DataTable get_Table() { }

	// RVA: 0xF58AC4
	internal string[] get_ParentColumnNames() { }

	// RVA: 0xF58AD0
	internal string[] get_ChildColumnNames() { }

	// RVA: 0xF58ADC
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xF58C04
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xF58C0C
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0xF58CC8
	internal override bool IsConstraintViolated() { }

	// RVA: 0xF59430
	internal override bool CanEnableConstraint() { }

	// RVA: 0xF596C8
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0xF598A4
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0xF59F24
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0xF5A184
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0xF5A6C0
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0xF5A7A4
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0xF5A880
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0xF5A9B0
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0xF5ACE0
	private void NonVirtualCheckState() { }

	// RVA: 0xF5AF40
	internal override void CheckState() { }

	// RVA: 0xF5AF44
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0xF5AF6C
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0xF5AFCC
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF5B018
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xF5B028
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xF5B818
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0xF58804
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0xF5BE90
	public virtual Rule get_DeleteRule() { }

	// RVA: 0xF5BEB8
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0xF5BF18
	public override bool Equals(object key) { }

	// RVA: 0xF5C034
	public override int GetHashCode() { }

	// RVA: 0xF5C03C
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0xF5B7F0
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0xF5A858
	internal DataKey get_ParentKey() { }

	// RVA: 0xF5C068
	internal DataRelation FindParentRelation() { }

	// RVA: 0xF5C140
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0xF5C16C
	public virtual Rule get_UpdateRule() { }

	// RVA: 0xF5C194
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

	// RVA: 0xF5C1F4
	public void .ctor(DataTable table, string conflict) { }

	// RVA: 0xF5C288
	public string get_Conflict() { }

}

// Namespace: System.Data
public sealed class MergeFailedEventHandler
{
	// Methods

	// RVA: 0xF5C290
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF5C3B4
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

	// RVA: 0xF5C3C8
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF5C420
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0xF5C480
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0xF5E134
	internal void MergeTable(DataTable src) { }

	// RVA: 0xF5E3B4
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0xF5EA18
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0xF5D448
	private void MergeTableData(DataTable src) { }

	// RVA: 0xF5D500
	private void MergeConstraints(DataSet source) { }

	// RVA: 0xF5F164
	private void MergeConstraints(DataTable table) { }

	// RVA: 0xF5D57C
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0xF5DEAC
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0xF5E894
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

	// RVA: 0xF5F420
	public void .ctor() { }

	// RVA: 0xF5F4D4
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xF5F4DC
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF5F5A8
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

}

// Namespace: System.Data
[Serializable]
public class PropertyCollection
{
	// Methods

	// RVA: 0xF5F7DC
	public void .ctor() { }

	// RVA: 0xF5F7E4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF5F7EC
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

	// RVA: 0xF5FAEC
	public void .ctor(int min, int max) { }

	// RVA: 0xF59E14
	public int get_Count() { }

	// RVA: 0xF59894
	public bool get_IsNull() { }

	// RVA: 0xF59E34
	public int get_Min() { }

	// RVA: 0xF5FB44
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

	// RVA: 0x30A2560
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

	// RVA: 0x30A24F0
	internal void .ctor(int size) { }

	// RVA: 0x30A15D4
	internal int AllocSlot(System.Data.RBTree<K> tree) { }

	// RVA: 0x30A14A4
	internal int get_InUseCount() { }

	// RVA: 0x30A24F0
	internal void set_InUseCount(int value) { }

	// RVA: 0x30A14A4
	internal int get_PageId() { }

	// RVA: 0x30A24F0
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

	// RVA: 0x30A27C0
	internal void .ctor(System.Data.RBTree<K> tree) { }

	// RVA: 0x30A2828
	internal void .ctor(System.Data.RBTree<K> tree, int position) { }

	// RVA: 0x30A2378
	public void Dispose() { }

	// RVA: 0x30A1224
	public bool MoveNext() { }

	// RVA: 0x315B3A8
	public K get_Current() { }

	// RVA: 0x30A17DC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30A2378
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

	// RVA: 0x30A24F0
	protected void .ctor(TreeAccessMethod accessMethod) { }

	// RVA: 0x30A2378
	private void InitTree() { }

	// RVA: 0x30A27C0
	private void FreePage(TreePage page) { }

	// RVA: -1
	private TreePage AllocPage(int size) { }

	// RVA: 0x30A27C0
	private void MarkPageFull(TreePage page) { }

	// RVA: 0x30A27C0
	private void MarkPageFree(TreePage page) { }

	// RVA: 0x315B3A8
	private static int GetIntValueFromBitMap(UInt32 bitMap) { }

	// RVA: 0x30A24F0
	private void FreeNode(int nodeId) { }

	// RVA: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }

	// RVA: 0x30A14A4
	public int get_Count() { }

	// RVA: 0x30A1224
	public bool get_HasDuplicates() { }

	// RVA: 0x315B3A8
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

	// RVA: 0x315B3A8
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }

	// RVA: 0x315B3A8
	public void UpdateNodeKey(K currentKey, K newKey) { }

	// RVA: 0x315B3A8
	public K DeleteByIndex(int i) { }

	// RVA: -1
	public int RBDelete(int z_id) { }

	// RVA: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }

	// RVA: 0x315B3A8
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }

	// RVA: 0x315B3A8
	private int SearchSubTree(int root_id, K key) { }

	// RVA: 0x315B3A8
	public K get_Item(int index) { }

	// RVA: 0x315B3A8
	private NodePath GetNodeByKey(K key) { }

	// RVA: 0x315B3A8
	public int GetIndexByKey(K key) { }

	// RVA: -1
	public int GetIndexByNode(int node) { }

	// RVA: 0x315B3A8
	private int GetIndexByNodePath(NodePath path) { }

	// RVA: -1
	private int ComputeIndexByNode(int nodeId) { }

	// RVA: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }

	// RVA: 0x315B3A8
	private NodePath GetNodeByIndex(int userIndex) { }

	// RVA: -1
	private int ComputeNodeByIndex(int index, int satelliteRootId) { }

	// RVA: 0x30A14D8
	private int ComputeNodeByIndex(int x_id, int index) { }

	// RVA: 0x315B3A8
	public int Insert(K item) { }

	// RVA: 0x315B3A8
	public int Add(K item) { }

	// RVA: 0x30A17DC
	public IEnumerator GetEnumerator() { }

	// RVA: 0x315B3A8
	public int IndexOf(int nodeId, K item) { }

	// RVA: 0x315B3A8
	public int Insert(int position, K item) { }

	// RVA: 0x315B3A8
	public int InsertAt(int position, K item, bool append) { }

	// RVA: 0x30A24F0
	public void RemoveAt(int position) { }

	// RVA: 0x30A2378
	public void Clear() { }

	// RVA: 0x30A2828
	public void CopyTo(Array array, int index) { }

	// RVA: 0x30A2828
	public void CopyTo(K[] array, int index) { }

	// RVA: 0x30A2560
	private void SetRight(int nodeId, int rightNodeId) { }

	// RVA: 0x30A2560
	private void SetLeft(int nodeId, int leftNodeId) { }

	// RVA: 0x30A2560
	private void SetParent(int nodeId, int parentNodeId) { }

	// RVA: 0x315B3A8
	private void SetColor(int nodeId, NodeColor color) { }

	// RVA: 0x315B3A8
	private void SetKey(int nodeId, K key) { }

	// RVA: 0x30A2560
	private void SetNext(int nodeId, int nextNodeId) { }

	// RVA: 0x30A2560
	private void SetSubTreeSize(int nodeId, int size) { }

	// RVA: 0x30A24F0
	private void IncreaseSize(int nodeId) { }

	// RVA: 0x30A24F0
	private void RecomputeSize(int nodeId) { }

	// RVA: 0x30A24F0
	private void DecreaseSize(int nodeId) { }

	// RVA: -1
	public int Right(int nodeId) { }

	// RVA: -1
	public int Left(int nodeId) { }

	// RVA: -1
	public int Parent(int nodeId) { }

	// RVA: 0x315B3A8
	private NodeColor color(int nodeId) { }

	// RVA: -1
	public int Next(int nodeId) { }

	// RVA: -1
	public int SubTreeSize(int nodeId) { }

	// RVA: 0x315B3A8
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

	// RVA: 0xF5FB88
	internal void .ctor(DataTable table) { }

	// RVA: 0xF5FC6C
	private void GrowRecordCapacity() { }

	// RVA: 0xF5FE64
	internal int get_LastFreeRecord() { }

	// RVA: 0xF5FE6C
	internal int get_MinimumCapacity() { }

	// RVA: 0xF5FE74
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0xF5FEC4
	internal int get_RecordCapacity() { }

	// RVA: 0xF5FDC8
	internal void set_RecordCapacity(int value) { }

	// RVA: 0xF5FD80
	internal static int NewCapacity(int capacity) { }

	// RVA: 0xF5FD94
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0xF5FECC
	internal int NewRecordBase() { }

	// RVA: 0xF5FFB4
	internal void FreeRecord(int record) { }

	// RVA: 0xF60164
	internal void Clear(bool clearAll) { }

	// RVA: 0xF603D4
	internal DataRow get_Item(int record) { }

	// RVA: 0xF600F0
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0xF60408
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0xF60410
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0xF60854
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

	// RVA: 0xF60898
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0xF609E0
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0xF60B24
	private object[] GetParentValues() { }

	// RVA: 0xF60BDC
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0xF60D70
	internal override IFilter GetFilter() { }

	// RVA: 0xF60D74
	public override DataRowView AddNew() { }

	// RVA: 0xF60DD8
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

// Namespace: System.Data
internal sealed class RelationshipConverter
{
	// Methods

	// RVA: 0xF60E08
	public void .ctor() { }

	// RVA: 0xF60E10
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0xF60EDC
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

	// RVA: 0xF61B04
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0xF61B30
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0xF61B44
	public override bool Equals(object obj) { }

	// RVA: 0xF61BE4
	public override int GetHashCode() { }

}

// Namespace: 
private sealed class IndexTree
{
	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0xF64BF4
	internal void .ctor(Index index) { }

	// RVA: 0xF658F4
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0xF65910
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

	// RVA: 0xF6592C
	private static void .cctor() { }

	// RVA: 0xF65998
	public void .ctor() { }

	// RVA: 0xF659A0
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0xF659AC
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }

}

// Namespace: 
private sealed class <>c__DisplayClass86_0
{
	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0xF64E7C
	public void .ctor() { }

	// RVA: 0xF659CC
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

	// RVA: 0xF61C6C
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF61FD0
	public void .ctor(DataTable table, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF62034
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0xF61C7C
	private void .ctor(DataTable table, IndexField[] indexFields, System.Comparison<System.Data.DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF62554
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0xF625F4
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0xF625FC
	internal int get_ObjectID() { }

	// RVA: 0xF62604
	public DataViewRowState get_RecordStates() { }

	// RVA: 0xF6260C
	public IFilter get_RowFilter() { }

	// RVA: 0xF62688
	public int GetRecord(int recordIndex) { }

	// RVA: 0xF62700
	public bool get_HasDuplicates() { }

	// RVA: 0xF62754
	public int get_RecordCount() { }

	// RVA: 0xF6275C
	private bool AcceptRecord(int record) { }

	// RVA: 0xF6280C
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0xF62A28
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0xF62A8C
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0xF62AF0
	public int get_RefCount() { }

	// RVA: 0xF62AF8
	public void AddRef() { }

	// RVA: 0xF62CD8
	public int RemoveRef() { }

	// RVA: 0xF62ED8
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0xF6354C
	public bool CheckUnique() { }

	// RVA: 0xF635A8
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0xF63750
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0xF637B8
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0xF63960
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0xF63A44
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0xF634D0
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0xF63A4C
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0xF63DF0
	public RBTreeEnumerator GetEnumerator(int startIndex) { }

	// RVA: 0xF634D8
	public int GetIndex(int record) { }

	// RVA: 0xF63328
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0xF59014
	public object[] GetUniqueKeyValues() { }

	// RVA: 0xF64068
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0xF642AC
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0xF64534
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0xF64644
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0xF64780
	public Range FindRecords(object key) { }

	// RVA: 0xF591A0
	public Range FindRecords(object[] key) { }

	// RVA: 0xF647B0
	internal void FireResetEvent() { }

	// RVA: 0xF64B7C
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF64B98
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0xF59E7C
	public DataRow GetRow(int i) { }

	// RVA: 0xF64BB8
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0xF591D0
	public DataRow[] GetRows(Range range) { }

	// RVA: 0xF62134
	private void InitRecords(IFilter filter) { }

	// RVA: 0xF64C60
	public int InsertRecordToIndex(int record) { }

	// RVA: 0xF63068
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0xF64D34
	public bool IsKeyInIndex(object key) { }

	// RVA: 0xF59184
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0xF64D50
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0xF64924
	private bool get_DoListChanged() { }

	// RVA: 0xF64D6C
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0xF63CF4
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0xF649AC
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0xF63BA4
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0xF64E84
	public void Reset() { }

	// RVA: 0xF64FE0
	public void RecordChanged(int record) { }

	// RVA: 0xF6517C
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0xF652E0
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0xF65414
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0xF658EC
	internal DataTable get_Table() { }

	// RVA: 0xF63E64
	private void GetUniqueKeyValues(System.Collections.Generic.List<System.Object[]> list, int curNodeId) { }

	// RVA: 0x315B3A8
	internal static int IndexOfReference(System.Collections.Generic.List<T> list, T item) { }

}

// Namespace: 
internal sealed class Action<T0, T1, T2, T3>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

}

// Namespace: 
internal sealed class Func<T0, T1>
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
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

	// RVA: 0x30A2658
	internal void .ctor(int ObjectID, System.Data.Listeners.Func<TElem,TElem,System.Boolean> notifyFilter) { }

	// RVA: 0x30A1224
	internal bool get_HasListeners() { }

	// RVA: 0x315B3A8
	internal void Add(TElem listener) { }

	// RVA: 0x315B3A8
	internal int IndexOfReference(TElem listener) { }

	// RVA: 0x315B3A8
	internal void Remove(TElem listener) { }

	// RVA: 0x315B3A8
	internal void Notify(T1 arg1, T2 arg2, T3 arg3, System.Data.Listeners.Action<TElem,TElem,T1,T2,T3> action) { }

	// RVA: 0x30A24F0
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

	// RVA: 0xF659FC
	internal void .ctor(string baseType) { }

	// RVA: 0xF65B34
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0xF666E0
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xF65D28
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0xF66720
	internal bool IsPlainString() { }

	// RVA: 0xF66864
	internal string get_BaseType() { }

	// RVA: 0xF6686C
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0xF66874
	internal string get_Name() { }

	// RVA: 0xF6687C
	internal string get_Namespace() { }

	// RVA: 0xF66884
	internal int get_Length() { }

	// RVA: 0xF6688C
	internal int get_MaxLength() { }

	// RVA: 0xF66894
	internal void set_MaxLength(int value) { }

	// RVA: 0xF6689C
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0xF668A4
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0xF66918
	internal string QualifiedName(string name) { }

	// RVA: 0xF66998
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0xF66E9C
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0xF66F2C
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0xF66FA0
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0xF67024
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0xF67130
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0xF6727C
	internal bool CanHaveMaxLength() { }

	// RVA: 0xF672E4
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

	// RVA: 0xF67394
	public void .ctor(DataColumn column) { }

	// RVA: 0xF67550
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0xF67590
	public void .ctor(DataColumn[] columns) { }

	// RVA: 0xF675C4
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0xF67620
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0xF67668
	internal string[] get_ColumnNames() { }

	// RVA: 0xF67674
	internal Index get_ConstraintIndex() { }

	// RVA: 0xF6767C
	internal void ConstraintIndexClear() { }

	// RVA: 0xF676BC
	internal void ConstraintIndexInitialize() { }

	// RVA: 0xF67718
	internal override void CheckState() { }

	// RVA: 0xF67724
	private void NonVirtualCheckState() { }

	// RVA: 0xF67730
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0xF67734
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0xF678C8
	internal override bool CanEnableConstraint() { }

	// RVA: 0xF67958
	internal override bool IsConstraintViolated() { }

	// RVA: 0xF67BEC
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0xF67CF0
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0xF67CFC
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0xF67D0C
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0xF682C8
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0xF687E0
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0xF67CE8
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0xF687EC
	public bool get_IsPrimaryKey() { }

	// RVA: 0xF67454
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0xF6883C
	public override bool Equals(object key2) { }

	// RVA: 0xF688F4
	public override int GetHashCode() { }

	// RVA: 0xF688FC
	internal override void set_InCollection(bool value) { }

	// RVA: 0xF68948
	internal DataKey get_Key() { }

	// RVA: 0xF68950
	public override DataTable get_Table() { }

}

// Namespace: 
private sealed class NameType
{
	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0xF6C564
	public void .ctor(string n, Type t) { }

	// RVA: 0xF6C5B4
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

	// RVA: 0xF68994
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0xF68A3C
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0xF68E88
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0xF691DC
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0xF693EC
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0xF68CB8
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0xF69E68
	private static NameType FindNameType(string name) { }

	// RVA: 0xF69F6C
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0xF6A0D0
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0xF6A254
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0xF6956C
	internal void GetMinMax(XmlElement elNode, int minOccurs, int maxOccurs) { }

	// RVA: 0xF6AC0C
	internal void GetMinMax(XmlElement elNode, bool isAttribute, int minOccurs, int maxOccurs) { }

	// RVA: 0xF6AF68
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0xF697B8
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0xF6957C
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0xF6B164
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

	// RVA: 0xF6C630
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0xF6CF48
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xF6D2C0
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0xF6C7E8
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0xF6D4DC
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0xF6CBA0
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0xF6D868
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0xF6ED14
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0xF6DD84
	private int ReadOldRowData(DataSet ds, DataTable table, int pos, XmlReader row) { }

	// RVA: 0xF6DD18
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0xF6EEFC
	public void .ctor() { }

}

// Namespace: System.Data
internal class XMLSchema
{
	// Methods

	// RVA: 0xF6EF04
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0xF6EF8C
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xF6F42C
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0xF6F4B8
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0xF6F644
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0xF6F770
	public void .ctor() { }

}

// Namespace: System.Data
internal sealed class ConstraintTable
{
	// Fields
	public DataTable table; // 0x10
	public XmlSchemaIdentityConstraint constraint; // 0x18

	// Methods

	// RVA: 0xF6F778
	public void .ctor(DataTable t, XmlSchemaIdentityConstraint c) { }

}

// Namespace: 
private sealed class NameType
{
	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0xF809F4
	public void .ctor(string n, Type t) { }

	// RVA: 0xF80A44
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

	// RVA: 0xF6F7C8
	internal bool get_FromInference() { }

	// RVA: 0xF6F7D0
	internal void set_FromInference(bool value) { }

	// RVA: 0xF6F7D8
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0xF6F864
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0xF7035C
	internal static string QualifiedName(string name) { }

	// RVA: 0xF703DC
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF70988
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF70D48
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0xF70234
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0xF70F54
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0xF7119C
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0xF71388
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0xF71C00
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0xF71E58
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0xF72864
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0xF72C2C
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0xF73220
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0xF73248
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0xF769BC
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0xF723D8
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0xF76CF8
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0xF785CC
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0xF79358
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0xF7970C
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0xF730E8
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0xF7AF88
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0xF7B10C
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0xF72A7C
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0xF7526C
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0xF7B434
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0xF7B4D0
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0xF7B5EC
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0xF7BFD4
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0xF7C488
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0xF71288
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0xF7D0C8
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0xF7E7BC
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0xF7E8C8
	private static NameType FindNameType(string name) { }

	// RVA: 0xF7E9CC
	private Type ParseDataType(string dt) { }

	// RVA: 0xF7EBBC
	internal static bool IsXsdType(string name) { }

	// RVA: 0xF75318
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0xF7A4BC
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xF79D0C
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0xF7889C
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0xF77640
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0xF757DC
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0xF7EC38
	private void AddTablesToList(System.Collections.Generic.List<System.Data.DataTable> tableList, DataTable dt) { }

	// RVA: 0xF7CCC4
	private string GetPrefix(string ns) { }

	// RVA: 0xF7EE88
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0xF7E62C
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xF7BEA4
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0xF72604
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0xF75630
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0xF7F294
	public void .ctor() { }

	// RVA: 0xF7F29C
	private static void .cctor() { }

}

// Namespace: System.Data
internal sealed class XmlIgnoreNamespaceReader
{
	// Fields
	private System.Collections.Generic.List<System.String> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0xF80AC0
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0xF80B64
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xF80C70
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

	// RVA: 0xF80DB4
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xF80E5C
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xF80F5C
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0xF8101C
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0xF81134
	internal bool get_FromInference() { }

	// RVA: 0xF8113C
	internal void set_FromInference(bool value) { }

	// RVA: 0xF81144
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xF813C4
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0xF815BC
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0xF818B0
	private string GetInitialTextFromNodes(XmlNode n) { }

	// RVA: 0xF81B64
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0xF81320
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0xF81C38
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0xF81520
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0xF81D50
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0xF82084
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0xF81854
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0xF81C00
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0xF82124
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0xF825B8
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0xF83208
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0xF835C0
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0xF8363C
	private void InitNameTable() { }

	// RVA: 0xF83948
	internal void LoadData(XmlReader reader) { }

	// RVA: 0xF83DF8
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0xF84B28
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0xF85B0C
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0xF848DC
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

	// RVA: 0xF88F18
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0xF88F68
	public override int GetHashCode() { }

	// RVA: 0xF88F8C
	public override bool Equals(object obj) { }

}

// Namespace: 
internal sealed class XmlNodeIdHashtable
{
	// Fields
	private XmlNodeIdentety _id; // 0x50

	// Methods

	// RVA: 0xF89034
	public void .ctor(int capacity) { }

	// RVA: 0xF890FC
	public object get_Item(XmlNode node) { }

	// RVA: 0xF89198
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0xF8922C
	public object get_Item(DataTable table) { }

	// RVA: 0xF892B8
	public object get_Item(string name) { }

}

// Namespace: 
private sealed class TableSchemaInfo
{
	// Fields
	public DataTable TableSchema; // 0x10
	public XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0xF89350
	public void .ctor(DataTable tableSchema) { }

}

// Namespace: System.Data
internal sealed class XmlToDatasetMap
{
	// Fields
	private XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0xF82484
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xF83D78
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xF82444
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xF83DB8
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xF8360C
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0xF88388
	private TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0xF884C8
	private TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0xF88664
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlNodeIdHashtable columns) { }

	// RVA: 0xF88900
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlNodeIdHashtable columns) { }

	// RVA: 0xF8655C
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0xF86B38
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0xF875D8
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0xF8792C
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0xF88ACC
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0xF81E40
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xF859A8
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0xF824C4
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0xF847E8
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0xF8879C
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

	// RVA: 0xF893FC
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0xF894AC
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0xF894B4
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0xF89BF8
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xF89DB4
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0xF8A6E8
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0xF8B76C
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0xF8BC60
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0xF8BD60
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0xF8C038
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0xF8C064
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0xF8C214
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0xF8C488
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0xF8C538
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0xF8D29C
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0xF8C80C
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0xF8D9CC
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xF8DD44
	private void CreateRelations(DataTable dt) { }

	// RVA: 0xF8E08C
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0xF8E3B8
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0xF91BEC
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0xF90EF0
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0xF94E34
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0xF95154
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0xF95174
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0xF95168
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0xF95240
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0xF95248
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, System.Converter<System.Type,System.String> multipleTargetConverter) { }

	// RVA: 0xF91620
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0xF953AC
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0xF954A8
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0xF9574C
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0xF95CD0
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0xF962D8
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0xF96404
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0xF971F8
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0xF97280
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0xF91564
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0xF9701C
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0xF9155C
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0xF97368
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0xF8D398
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0xF97718
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0xF8D8F4
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0xF8D8E8
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0xF977F8
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0xF97948
	private bool IsAutoGenerated(object o) { }

	// RVA: 0xF920C8
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0xF8B510
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

	// RVA: 0xF97A0C
	internal void .ctor(DataSet ds) { }

	// RVA: 0xF97DE4
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xF97F0C
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0xF97B60
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0xF98284
	private bool EmptyData() { }

	// RVA: 0xF9837C
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0xF98384
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0xF9951C
	private void GenerateTable(DataTable table) { }

	// RVA: 0xF9959C
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0xF99B40
	private void GenerateRow(DataRow row) { }

	// RVA: 0xF9A224
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0xF97994
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

	// RVA: 0xF991B8
	internal void .ctor(DataSet ds) { }

	// RVA: 0xF988F4
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0xF9B0A8
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0xF9AD30
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0xF9A12C
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0xF98AA8
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0xF9CE00
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0xF9D70C
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0xF9B3D4
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0xF9AC54
	internal static bool PreserveSpace(object value) { }

}

// Namespace: System.Data
internal sealed class DataTextWriter
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Methods

	// RVA: 0xF98880
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0xF9DA48
	private void .ctor(XmlWriter w) { }

	// RVA: 0xF950C8
	internal Stream get_BaseStream() { }

	// RVA: 0xF9DA7C
	public override void WriteStartDocument() { }

	// RVA: 0xF9DAA0
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0xF9DAC4
	public override void WriteEndDocument() { }

	// RVA: 0xF9DAE8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0xF9DB0C
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0xF9DB30
	public override void WriteEndElement() { }

	// RVA: 0xF9DB54
	public override void WriteFullEndElement() { }

	// RVA: 0xF9DB78
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0xF9DB9C
	public override void WriteEndAttribute() { }

	// RVA: 0xF9DBC4
	public override void WriteCData(string text) { }

	// RVA: 0xF9DBEC
	public override void WriteComment(string text) { }

	// RVA: 0xF9DC14
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0xF9DC3C
	public override void WriteEntityRef(string name) { }

	// RVA: 0xF9DC64
	public override void WriteCharEntity(Char ch) { }

	// RVA: 0xF9DC8C
	public override void WriteWhitespace(string ws) { }

	// RVA: 0xF9DCB4
	public override void WriteString(string text) { }

	// RVA: 0xF9DCDC
	public override void WriteSurrogateCharEntity(Char lowChar, Char highChar) { }

	// RVA: 0xF9DD04
	public override void WriteChars(Char[] buffer, int index, int count) { }

	// RVA: 0xF9DD2C
	public override void WriteRaw(Char[] buffer, int index, int count) { }

	// RVA: 0xF9DD54
	public override void WriteRaw(string data) { }

	// RVA: 0xF9DD7C
	public override void WriteBase64(Byte[] buffer, int index, int count) { }

	// RVA: 0xF9DDA4
	public override void WriteBinHex(Byte[] buffer, int index, int count) { }

	// RVA: 0xF9DDCC
	public override WriteState get_WriteState() { }

	// RVA: 0xF9DDF4
	public override void Close() { }

	// RVA: 0xF9DE1C
	public override void Flush() { }

	// RVA: 0xF9DE44
	public override string LookupPrefix(string ns) { }

}

// Namespace: System.Data
internal sealed class DataTextReader
{
	// Fields
	private XmlReader _xmlreader; // 0x10

	// Methods

	// RVA: 0xF9DE6C
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0xF9DF1C
	private void .ctor(XmlReader input) { }

	// RVA: 0xF9DF94
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0xF9DFB8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0xF9DFDC
	public override string get_Name() { }

	// RVA: 0xF9E000
	public override string get_LocalName() { }

	// RVA: 0xF9E024
	public override string get_NamespaceURI() { }

	// RVA: 0xF9E048
	public override string get_Prefix() { }

	// RVA: 0xF9E06C
	public override string get_Value() { }

	// RVA: 0xF9E090
	public override int get_Depth() { }

	// RVA: 0xF9E0B4
	public override string get_BaseURI() { }

	// RVA: 0xF9E0DC
	public override bool get_IsEmptyElement() { }

	// RVA: 0xF9E104
	public override bool get_IsDefault() { }

	// RVA: 0xF9E12C
	public override Char get_QuoteChar() { }

	// RVA: 0xF9E154
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0xF9E17C
	public override string get_XmlLang() { }

	// RVA: 0xF9E1A4
	public override int get_AttributeCount() { }

	// RVA: 0xF9E1CC
	public override string GetAttribute(string name) { }

	// RVA: 0xF9E1F4
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0xF9E21C
	public override string GetAttribute(int i) { }

	// RVA: 0xF9E244
	public override bool MoveToAttribute(string name) { }

	// RVA: 0xF9E26C
	public override void MoveToAttribute(int i) { }

	// RVA: 0xF9E294
	public override bool MoveToFirstAttribute() { }

	// RVA: 0xF9E2BC
	public override bool MoveToNextAttribute() { }

	// RVA: 0xF9E2E4
	public override bool MoveToElement() { }

	// RVA: 0xF9E30C
	public override bool ReadAttributeValue() { }

	// RVA: 0xF9E334
	public override bool Read() { }

	// RVA: 0xF9E35C
	public override bool get_EOF() { }

	// RVA: 0xF9E384
	public override void Close() { }

	// RVA: 0xF9E3AC
	public override ReadState get_ReadState() { }

	// RVA: 0xF9E3D4
	public override void Skip() { }

	// RVA: 0xF9E3FC
	public override XmlNameTable get_NameTable() { }

	// RVA: 0xF9E424
	public override string LookupNamespace(string prefix) { }

	// RVA: 0xF9E44C
	public override bool get_CanResolveEntity() { }

	// RVA: 0xF9E474
	public override void ResolveEntity() { }

	// RVA: 0xF9E49C
	public override bool get_CanReadValueChunk() { }

	// RVA: 0xF9E4C4
	public override string ReadString() { }

}

// Namespace: System.Data.SqlTypes
internal static class SQLResource
{
	// Methods

	// RVA: 0xF9E4EC
	internal static string get_NullString() { }

	// RVA: 0xF9E530
	internal static string get_ArithOverflowMessage() { }

	// RVA: 0xF9E574
	internal static string get_DivideByZeroMessage() { }

	// RVA: 0xF9E5B8
	internal static string get_NullValueMessage() { }

	// RVA: 0xF9E5FC
	internal static string get_TruncationMessage() { }

	// RVA: 0xF9E640
	internal static string get_DateTimeOverflowMessage() { }

	// RVA: 0xF9E684
	internal static string get_ConcatDiffCollationMessage() { }

	// RVA: 0xF9E6C8
	internal static string get_CompareDiffCollationMessage() { }

	// RVA: 0xF9E70C
	internal static string get_ConversionOverflowMessage() { }

	// RVA: 0xF9E750
	internal static string get_TimeZoneSpecifiedMessage() { }

	// RVA: 0xF9E794
	internal static string get_InvalidPrecScaleMessage() { }

	// RVA: 0xF9E7D8
	internal static string get_FormatMessage() { }

	// RVA: 0xF9E81C
	internal static string InvalidOpStreamClosed(string method) { }

	// RVA: 0xF9E874
	internal static string InvalidOpStreamNonWritable(string method) { }

	// RVA: 0xF9E8CC
	internal static string InvalidOpStreamNonReadable(string method) { }

	// RVA: 0xF9E924
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

	// RVA: 0xF9E97C
	private void .ctor(bool fNull) { }

	// RVA: 0xF9E988
	public void .ctor(Byte[] value) { }

	// RVA: 0xF9EA24
	public bool get_IsNull() { }

	// RVA: 0xF9EA34
	public Byte[] get_Value() { }

	// RVA: 0xF9EB24
	public static SqlBinary op_Implicit(Byte[] x) { }

	// RVA: 0xF9EBCC
	public override string ToString() { }

	// RVA: 0xF9ED0C
	private static EComparison PerformCompareByte(Byte[] x, Byte[] y) { }

	// RVA: 0xF9EE28
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0xF9EF58
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xF9F074
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0xF9F190
	public int CompareTo(object value) { }

	// RVA: 0xF9F2B4
	public int CompareTo(SqlBinary value) { }

	// RVA: 0xF9F540
	public override bool Equals(object value) { }

	// RVA: 0xF9F73C
	internal static int HashByteArray(Byte[] rgbValue, int length) { }

	// RVA: 0xF9F7A4
	public override int GetHashCode() { }

	// RVA: 0xF9F8E8
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xF9F8F0
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xF9FB14
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xF9FC58
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xF9FCE8
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

	// RVA: 0xF9EF44
	public void .ctor(bool value) { }

	// RVA: 0xF9FD60
	public void .ctor(int value) { }

	// RVA: 0xF9FDD0
	private void .ctor(int value, bool fNull) { }

	// RVA: 0xF9FDEC
	public bool get_IsNull() { }

	// RVA: 0xF9F6D8
	public bool get_Value() { }

	// RVA: 0xF9FDFC
	public bool get_IsTrue() { }

	// RVA: 0xF9FE0C
	public bool get_IsFalse() { }

	// RVA: 0xF9FE1C
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0xF9F4D8
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0xF9FE2C
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xF9FF28
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFA000C
	public Byte get_ByteValue() { }

	// RVA: 0xFA00C0
	public override string ToString() { }

	// RVA: 0xFA0210
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFA02F8
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFA0434
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0xFA0588
	public int CompareTo(object value) { }

	// RVA: 0xFA06AC
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0xFA0808
	public override bool Equals(object value) { }

	// RVA: 0xFA0994
	public override int GetHashCode() { }

	// RVA: 0xFA0ABC
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFA0AC4
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFA0C08
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFA0D40
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFA0DD0
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

	// RVA: 0xFA0EC4
	private void .ctor(bool fNull) { }

	// RVA: 0xFA0ECC
	public void .ctor(Byte value) { }

	// RVA: 0xFA0EDC
	public bool get_IsNull() { }

	// RVA: 0xFA0EEC
	public Byte get_Value() { }

	// RVA: 0xFA0F84
	public static SqlByte op_Implicit(Byte x) { }

	// RVA: 0xFA0F90
	public override string ToString() { }

	// RVA: 0xFA1028
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0xFA117C
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0xFA12C8
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0xFA141C
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0xFA155C
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0xFA171C
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0xFA1834
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFA194C
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFA1A64
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFA1AF0
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0xFA1B7C
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFA1D48
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFA1EB8
	public int CompareTo(object value) { }

	// RVA: 0xFA1FDC
	public int CompareTo(SqlByte value) { }

	// RVA: 0xFA2188
	public override bool Equals(object value) { }

	// RVA: 0xFA2300
	public override int GetHashCode() { }

	// RVA: 0xFA23F4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFA23FC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFA253C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFA2684
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFA2714
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

	// RVA: 0xFA2790
	public void .ctor() { }

	// RVA: 0xFA2808
	public void .ctor(Byte[] buffer) { }

	// RVA: 0xFA288C
	public void .ctor(SqlBinary value) { }

	// RVA: 0xFA29B0
	public bool get_IsNull() { }

	// RVA: 0xFA29C0
	public Byte[] get_Buffer() { }

	// RVA: 0xFA2B78
	public Int64 get_Length() { }

	// RVA: 0xFA2BF4
	public Byte[] get_Value() { }

	// RVA: 0xFA27D0
	public void SetNull() { }

	// RVA: 0xFA2A04
	private void CopyStreamToBuffer() { }

	// RVA: 0xFA29F4
	internal bool FStream() { }

	// RVA: 0xFA2E1C
	private void SetBuffer(Byte[] buffer) { }

	// RVA: 0xFA2E80
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFA2E88
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xFA3110
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFA3244
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFA32D4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFA3314
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

	// RVA: 0xFA33C4
	public void .ctor() { }

	// RVA: 0xFA343C
	public void .ctor(Char[] buffer) { }

	// RVA: 0xFA34C0
	public void .ctor(SqlString value) { }

	// RVA: 0xFA368C
	public bool get_IsNull() { }

	// RVA: 0xFA369C
	public Char[] get_Buffer() { }

	// RVA: 0xFA384C
	public Int64 get_Length() { }

	// RVA: 0xFA38C8
	public Char[] get_Value() { }

	// RVA: 0xFA3404
	public void SetNull() { }

	// RVA: 0xFA36D0
	internal bool FStream() { }

	// RVA: 0xFA36E0
	private void CopyStreamToBuffer() { }

	// RVA: 0xFA3AB4
	private void SetBuffer(Char[] buffer) { }

	// RVA: 0xFA3B18
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFA3B20
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xFA3CA8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFA3DB8
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFA3E48
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFA3E88
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

	// RVA: 0xFA3F38
	private void .ctor(bool fNull) { }

	// RVA: 0xFA3F44
	public void .ctor(DateTime value) { }

	// RVA: 0xFA40DC
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0xFA4230
	public bool get_IsNull() { }

	// RVA: 0xFA4240
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0xFA42EC
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0xFA4448
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0xFA3FB4
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0xFA46B0
	public DateTime get_Value() { }

	// RVA: 0xFA4760
	public int get_DayTicks() { }

	// RVA: 0xFA47B4
	public int get_TimeTicks() { }

	// RVA: 0xFA4808
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0xFA4870
	public override string ToString() { }

	// RVA: 0xFA4964
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFA4A7C
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFA4BA0
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFA4CC4
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFA4D44
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0xFA4DC4
	public int CompareTo(object value) { }

	// RVA: 0xFA4ED8
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0xFA50A0
	public override bool Equals(object value) { }

	// RVA: 0xFA5230
	public override int GetHashCode() { }

	// RVA: 0xFA5330
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFA5338
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFA556C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFA56DC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFA576C
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

	// RVA: 0xFA5C10
	private Byte CalculatePrecision() { }

	// RVA: 0xFA5E88
	private bool VerifyPrecision(Byte precision) { }

	// RVA: 0xFA610C
	private void .ctor(bool fNull) { }

	// RVA: 0xFA6180
	public void .ctor(Decimal value) { }

	// RVA: 0xFA6378
	public void .ctor(int value) { }

	// RVA: 0xFA6694
	public void .ctor(Int64 value) { }

	// RVA: 0xFA6B90
	private void .ctor(UInt32[] rglData, Byte bLen, Byte bPrec, Byte bScale, bool fPositive) { }

	// RVA: 0xFA6EF4
	public bool get_IsNull() { }

	// RVA: 0xFA6F70
	public Decimal get_Value() { }

	// RVA: 0xFA71DC
	public bool get_IsPositive() { }

	// RVA: 0xFA6E80
	private void SetPositive() { }

	// RVA: 0xFA7324
	private void SetSignBit(bool fPositive) { }

	// RVA: 0xFA73DC
	public Byte get_Scale() { }

	// RVA: 0xFA74FC
	public int[] get_Data() { }

	// RVA: 0xFA7684
	public override string ToString() { }

	// RVA: 0xFA7CEC
	public static SqlDecimal Parse(string s) { }

	// RVA: 0xFA8898
	public Double ToDouble() { }

	// RVA: 0xFA6FF0
	private Decimal ToDecimal() { }

	// RVA: 0xFA8A6C
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0xFA8A84
	public static SqlDecimal op_Implicit(Int64 x) { }

	// RVA: 0xFA8AFC
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0xFA8D9C
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFA9B04
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFA9BE8
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFAA7CC
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFAB7D4
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0xFAB8BC
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0xFABA08
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0xFABBC4
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0xFABCBC
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0xFAB754
	private static void ZeroToMaxLen(UInt32[] rgulData, int cUI4sCur) { }

	// RVA: 0xFA6E60
	private bool FZero() { }

	// RVA: 0xFA9A9C
	private bool FGt10_38() { }

	// RVA: 0xFABEFC
	private bool FGt10_38(UInt32[] rglData) { }

	// RVA: 0xFA647C
	private static Byte BGetPrecUI4(UInt32 value) { }

	// RVA: 0xFA6784
	private static Byte BGetPrecUI8(UInt64 dwlVal) { }

	// RVA: 0xFA8658
	private void AddULong(UInt32 ulAdd) { }

	// RVA: 0xFA83B8
	private void MultByULong(UInt32 uiMultiplier) { }

	// RVA: 0xFABFDC
	private UInt32 DivByULong(UInt32 iDivisor) { }

	// RVA: 0xFA9530
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0xFA9914
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0xFAC210
	private static void MpMove(UInt32[] rgulS, int ciulS, UInt32[] rgulD, int ciulD) { }

	// RVA: 0xFAC280
	private static void MpSet(UInt32[] rgulD, int ciulD, UInt32 iulN) { }

	// RVA: 0xFAC2B0
	private static void MpNormalize(UInt32[] rgulU, int ciulU) { }

	// RVA: 0xFAC304
	private static void MpMul1(UInt32[] piulD, int ciulD, UInt32 iulX) { }

	// RVA: 0xFA7BA8
	private static void MpDiv1(UInt32[] rgulU, int ciulU, UInt32 iulD, UInt32 iulR) { }

	// RVA: 0xFAC410
	internal static UInt64 DWL(UInt32 lo, UInt32 hi) { }

	// RVA: 0xFAC404
	private static UInt32 HI(UInt64 x) { }

	// RVA: 0xFAC40C
	private static UInt32 LO(UInt64 x) { }

	// RVA: 0xFAAD68
	private static void MpDiv(UInt32[] rgulU, int ciulU, UInt32[] rgulD, int ciulD, UInt32[] rgulQ, int ciulQ, UInt32[] rgulR, int ciulR) { }

	// RVA: 0xFAC41C
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0xFA6D80
	private static void CheckValidPrecScale(Byte bPrec, Byte bScale) { }

	// RVA: 0xFAC8D0
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFACAE8
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFACD00
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFACF18
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFACFCC
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0xFAD080
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFAD2A4
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFAD5A0
	public SqlMoney ToSqlMoney() { }

	// RVA: 0xFA7CE0
	private static Char ChFromDigit(UInt32 uiDigit) { }

	// RVA: 0xFABF80
	private void StoreFromWorkingArray(UInt32[] rguiData) { }

	// RVA: 0xFA8334
	private void SetToZero() { }

	// RVA: 0xFAD7EC
	public int CompareTo(object value) { }

	// RVA: 0xFAD920
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0xFADC70
	public override bool Equals(object value) { }

	// RVA: 0xFADFC8
	public override int GetHashCode() { }

	// RVA: 0xFAE174
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFAE17C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFAE300
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFAE49C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFAE52C
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

	// RVA: 0xFAE8E8
	private void .ctor(bool fNull) { }

	// RVA: 0xFAE8F4
	public void .ctor(Double value) { }

	// RVA: 0xFAE96C
	public bool get_IsNull() { }

	// RVA: 0xFAE97C
	public Double get_Value() { }

	// RVA: 0xFAE9D0
	public static SqlDouble op_Implicit(Double x) { }

	// RVA: 0xFAEA38
	public override string ToString() { }

	// RVA: 0xFAEAD0
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0xFAEBE8
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFAED84
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFAEF20
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFAF0BC
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFA1C04
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0xFAF290
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0xFAF3D4
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0xFAF510
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0xFAF650
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0xFAF7EC
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0xFAD10C
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0xFAFA50
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFAFB64
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFAFC78
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFAFD8C
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFAFE0C
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0xFAFE8C
	public SqlSingle ToSqlSingle() { }

	// RVA: 0xFB0004
	public int CompareTo(object value) { }

	// RVA: 0xFB0114
	public int CompareTo(SqlDouble value) { }

	// RVA: 0xFB02D0
	public override bool Equals(object value) { }

	// RVA: 0xFB0458
	public override int GetHashCode() { }

	// RVA: 0xFB0548
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB0550
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFB0690
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB07E4
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB0874
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

	// RVA: 0xFB0908
	private void .ctor(bool fNull) { }

	// RVA: 0xFB0914
	public void .ctor(Guid g) { }

	// RVA: 0xFB0958
	public bool get_IsNull() { }

	// RVA: 0xFB0968
	public Guid get_Value() { }

	// RVA: 0xFB0A2C
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0xFB0A68
	public override string ToString() { }

	// RVA: 0xFB0B20
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFB0CC8
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFB0DE4
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFB0F00
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0xFB101C
	public int CompareTo(object value) { }

	// RVA: 0xFB1140
	public int CompareTo(SqlGuid value) { }

	// RVA: 0xFB12E0
	public override bool Equals(object value) { }

	// RVA: 0xFB1444
	public override int GetHashCode() { }

	// RVA: 0xFB1504
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB150C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFB1668
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB17CC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB185C
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

	// RVA: 0xFB1944
	private void .ctor(bool fNull) { }

	// RVA: 0xFB1950
	public void .ctor(Int16 value) { }

	// RVA: 0xFAB9A4
	public bool get_IsNull() { }

	// RVA: 0xFAB9B4
	public Int16 get_Value() { }

	// RVA: 0xFB1960
	public static SqlInt16 op_Implicit(Int16 x) { }

	// RVA: 0xFB196C
	public override string ToString() { }

	// RVA: 0xFB1A04
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0xFB1AD8
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFB1C2C
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFB1D80
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFB1F18
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFB20D0
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0xFB21C0
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0xFB2300
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFB2414
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFB2528
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFB263C
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFB26C8
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0xFB2754
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFB27DC
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFB294C
	public int CompareTo(object value) { }

	// RVA: 0xFB2A70
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0xFB2C1C
	public override bool Equals(object value) { }

	// RVA: 0xFB2D8C
	public override int GetHashCode() { }

	// RVA: 0xFB2E80
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB2E88
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFB2FC8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB3110
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB31A0
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

	// RVA: 0xFB3220
	private void .ctor(bool fNull) { }

	// RVA: 0xFB322C
	public void .ctor(int value) { }

	// RVA: 0xFABB08
	public bool get_IsNull() { }

	// RVA: 0xFABB18
	public int get_Value() { }

	// RVA: 0xFB323C
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0xFB3248
	public override string ToString() { }

	// RVA: 0xFB32E0
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0xFB33B0
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFB3534
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFB36AC
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFB3844
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFB39FC
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0xFB3AEC
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0xFB3BDC
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0xFB3528
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0xFB3D1C
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFB3E34
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFB3F4C
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFB4064
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFB40F0
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0xFB417C
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFB4204
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0xFB4374
	public int CompareTo(object value) { }

	// RVA: 0xFB4498
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0xFB4640
	public override bool Equals(object value) { }

	// RVA: 0xFB47B0
	public override int GetHashCode() { }

	// RVA: 0xFB4870
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB4878
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFB49B8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB4B00
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB4B90
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

	// RVA: 0xFB4C10
	private void .ctor(bool fNull) { }

	// RVA: 0xFB4C1C
	public void .ctor(Int64 value) { }

	// RVA: 0xFA16B8
	public bool get_IsNull() { }

	// RVA: 0xFA16C8
	public Int64 get_Value() { }

	// RVA: 0xFB4C2C
	public static SqlInt64 op_Implicit(Int64 x) { }

	// RVA: 0xFB4C38
	public override string ToString() { }

	// RVA: 0xFB4CD0
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0xFB4D98
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB4F10
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB5078
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB521C
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB53AC
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFA1DD0
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0xFB2864
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0xFB428C
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0xFAD330
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0xFB4F00
	private static bool SameSignLong(Int64 x, Int64 y) { }

	// RVA: 0xFB5540
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB564C
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB5758
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB5864
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB58E4
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0xFB5964
	public SqlByte ToSqlByte() { }

	// RVA: 0xFB59F4
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFB5A84
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0xFB5B14
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0xFB5BA4
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0xFB5C30
	public int CompareTo(object value) { }

	// RVA: 0xFB5D40
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0xFB5EFC
	public override bool Equals(object value) { }

	// RVA: 0xFB6084
	public override int GetHashCode() { }

	// RVA: 0xFB6178
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB6180
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFB62C0
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB6408
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB6498
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

	// RVA: 0xFB6534
	private void .ctor(bool fNull) { }

	// RVA: 0xFB6540
	internal void .ctor(Int64 value, int ignored) { }

	// RVA: 0xFB6550
	public void .ctor(int value) { }

	// RVA: 0xFB65D0
	public void .ctor(Int64 value) { }

	// RVA: 0xFB66F0
	public void .ctor(Decimal value) { }

	// RVA: 0xFABDC8
	public bool get_IsNull() { }

	// RVA: 0xFB6868
	public Decimal get_Value() { }

	// RVA: 0xFABDD8
	public Decimal ToDecimal() { }

	// RVA: 0xFAF9B4
	public Double ToDouble() { }

	// RVA: 0xFB6908
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0xFB6938
	public static SqlMoney op_Implicit(Int64 x) { }

	// RVA: 0xFB69A4
	public override string ToString() { }

	// RVA: 0xFB6AE8
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0xFB6C18
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFB6DF4
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFB6FD0
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFB7140
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFB72B0
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0xFB7400
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0xFB7554
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0xFB76B0
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0xFAD62C
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0xFB77A4
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFB78B0
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFB79BC
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFB7AC8
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFB7B48
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0xFB7BC8
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFB7C58
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0xFB7CE4
	public int CompareTo(object value) { }

	// RVA: 0xFB7DF4
	public int CompareTo(SqlMoney value) { }

	// RVA: 0xFB7FB0
	public override bool Equals(object value) { }

	// RVA: 0xFB8138
	public override int GetHashCode() { }

	// RVA: 0xFB81CC
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFB81D4
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFB8370
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFB84D8
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFB8568
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

	// RVA: 0xFB864C
	private void .ctor(bool fNull) { }

	// RVA: 0xFB8658
	public void .ctor(float value) { }

	// RVA: 0xFB86D0
	public void .ctor(Double value) { }

	// RVA: 0xFAF788
	public bool get_IsNull() { }

	// RVA: 0xFAF798
	public float get_Value() { }

	// RVA: 0xFB87BC
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0xFB8828
	public override string ToString() { }

	// RVA: 0xFB88C0
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0xFB89C8
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFB8B60
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFB8CF8
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFB8E90
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFB9060
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0xFB9194
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0xFB92C8
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0xFB940C
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0xFB953C
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0xFB96C0
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0xFAFF1C
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0xFB9820
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFB9940
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFB9A60
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFB9B80
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFB9C0C
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0xFB9C98
	public SqlDouble ToSqlDouble() { }

	// RVA: 0xFB9D20
	public int CompareTo(object value) { }

	// RVA: 0xFB9E44
	public int CompareTo(SqlSingle value) { }

	// RVA: 0xFB9FEC
	public override bool Equals(object value) { }

	// RVA: 0xFBA15C
	public override int GetHashCode() { }

	// RVA: 0xFBA250
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFBA258
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFBA398
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFBA4EC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFBA57C
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

	// RVA: 0xFBA5FC
	private void .ctor(bool fNull) { }

	// RVA: 0xFBA63C
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0xFBA7DC
	public void .ctor(string data) { }

	// RVA: 0xFBA8B0
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0xFA35D0
	public bool get_IsNull() { }

	// RVA: 0xFA35E0
	public string get_Value() { }

	// RVA: 0xFBA9C0
	private void SetCompareInfo() { }

	// RVA: 0xFBAA5C
	public static SqlString op_Implicit(string x) { }

	// RVA: 0xFBAA70
	public override string ToString() { }

	// RVA: 0xFBAB00
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0xFBAC80
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0xFBB454
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0xFBB5F4
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0xFBA708
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xFBB384
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0xFBB68C
	private bool FBinarySort() { }

	// RVA: 0xFBAFAC
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0xFBB1C0
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0xFBB724
	public int CompareTo(object value) { }

	// RVA: 0xFBB848
	public int CompareTo(SqlString value) { }

	// RVA: 0xFBB990
	public override bool Equals(object value) { }

	// RVA: 0xFBBB98
	public override int GetHashCode() { }

	// RVA: 0xFBBEB4
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFBBEBC
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0xFBBFE8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFBC0FC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFBC18C
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

	// RVA: 0xFBC29C
	public void .ctor() { }

	// RVA: 0xFA2DE8
	public void .ctor(string message) { }

	// RVA: 0xFBC308
	public void .ctor(string message, Exception e) { }

	// RVA: 0xFBC338
	protected void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xFBC38C
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlNullValueException
{
	// Methods

	// RVA: 0xFA0F40
	public void .ctor() { }

	// RVA: 0xFBC498
	public void .ctor(string message) { }

	// RVA: 0xFBC468
	public void .ctor(string message, Exception e) { }

	// RVA: 0xFBC4CC
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xFBC530
	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }

}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlTruncateException
{
	// Methods

	// RVA: 0xFAC1CC
	public void .ctor() { }

	// RVA: 0xFBC63C
	public void .ctor(string message) { }

	// RVA: 0xFBC60C
	public void .ctor(string message, Exception e) { }

	// RVA: 0xFBC670
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0xFBC6D4
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

	// RVA: 0xFBC7B0
	public void .ctor() { }

	// RVA: 0xFBC828
	public XmlReader CreateReader() { }

	// RVA: 0xFBCBE0
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput, bool throwTargetInvocationExceptions) { }

	// RVA: 0xFBCDC8
	private static System.Func<System.IO.Stream,System.Xml.XmlReaderSettings,System.Xml.XmlParserContext,System.Xml.XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0xFBCA78
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0xFBC9E4
	public bool get_IsNull() { }

	// RVA: 0xFBC7F0
	private void SetNull() { }

	// RVA: 0xFBCEF0
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0xFBCEF8
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0xFBD104
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0xFBD278
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0xFBD308
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

	// RVA: 0xFBC9F4
	internal void .ctor(Stream stream) { }

	// RVA: 0xFBD40C
	public override bool get_CanRead() { }

	// RVA: 0xFBD520
	public override bool get_CanSeek() { }

	// RVA: 0xFBD5B0
	public override bool get_CanWrite() { }

	// RVA: 0xFBD640
	public override Int64 get_Length() { }

	// RVA: 0xFBD7F4
	public override Int64 get_Position() { }

	// RVA: 0xFBD85C
	public override void set_Position(Int64 value) { }

	// RVA: 0xFBD934
	public override Int64 Seek(Int64 offset, SeekOrigin origin) { }

	// RVA: 0xFBDABC
	public override int Read(Byte[] buffer, int offset, int count) { }

	// RVA: 0xFBDD0C
	public override void Write(Byte[] buffer, int offset, int count) { }

	// RVA: 0xFBDF5C
	public override int ReadByte() { }

	// RVA: 0xFBE088
	public override void WriteByte(Byte value) { }

	// RVA: 0xFBE170
	public override void Flush() { }

	// RVA: 0xFBE18C
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFBD774
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0xFBDC8C
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0xFBDEDC
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0xFBD6B8
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0xFBD49C
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

	// RVA: 0xFC1F40
	private void .ctor() { }

	// RVA: 0xFC1F48
	public bool Equals(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> x, System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> y) { }

	// RVA: 0xFC27C0
	public int GetHashCode(System.Collections.Generic.KeyValuePair<System.Type,System.Xml.Serialization.XmlRootAttribute> obj) { }

	// RVA: 0xFC2954
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

	// RVA: 0xFBE19C
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0xFBE370
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFBE3A8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFBEA94
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xFBECB0
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0xFBE590
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0xFBEF90
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFBF014
	public override object Get(int recordNo) { }

	// RVA: 0xFBEE50
	private Families GetFamily(Type dataType) { }

	// RVA: 0xFBF060
	public override bool IsNull(int record) { }

	// RVA: 0xFBF09C
	public override void Set(int recordNo, object value) { }

	// RVA: 0xFBF93C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFBFA00
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFC0044
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFC11C0
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFC16FC
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFC186C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC18C0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC1AFC
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFC1D14
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0xFBFFA0
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0xFC0780
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0xFC1E68
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

	// RVA: 0xFC29C0
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0xFC2A68
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0xFC2B84
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0xFC2CA0
	internal static ArgumentException Argument(string error) { }

	// RVA: 0xFC2D34
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0xFC2DC8
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0xFC2E6C
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0xFC2F00
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0xFC2F94
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0xFC326C
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0xFC34DC
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0xFC3668
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0xFC3780
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0xFC3848
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0xFC3910
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0xFC39D8
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0xFC3B14
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class BigIntegerStorage
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0xFC3E80
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFC40F4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC412C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC4304
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC4498
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0xFC4C7C
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xFC5414
	public override object ConvertValue(object value) { }

	// RVA: 0xFC54F0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC55C0
	public override object Get(int record) { }

	// RVA: 0xFC5704
	public override void Set(int record, object value) { }

	// RVA: 0xFC58A8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFC5A80
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFC5B64
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFC5C58
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC5CAC
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC5DCC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class BooleanStorage
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0xFC5E9C
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFC6004
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC63B4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC64BC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC65F8
	public override object ConvertValue(object value) { }

	// RVA: 0xFC675C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC67E0
	public override object Get(int record) { }

	// RVA: 0xFC68AC
	public override void Set(int record, object value) { }

	// RVA: 0xFC6A50
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFC6B94
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFC6C28
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFC6CDC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC6D30
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC6E34
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class ByteStorage
{
	// Fields
	private Byte[] _values; // 0x50

	// Methods

	// RVA: 0xFC6F04
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFC706C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC7890
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC7954
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC7A7C
	public override object ConvertValue(object value) { }

	// RVA: 0xFC7BE0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC7C64
	public override object Get(int record) { }

	// RVA: 0xFC7D30
	public override void Set(int record, object value) { }

	// RVA: 0xFC7ED4
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFC8018
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFC80AC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFC8160
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC81B4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC82B8
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class CharStorage
{
	// Fields
	private Char[] _values; // 0x50

	// Methods

	// RVA: 0xFC8388
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFC84F0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFC8884
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFC8988
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFC8AC4
	public override object ConvertValue(object value) { }

	// RVA: 0xFC8C28
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFC8CAC
	public override object Get(int record) { }

	// RVA: 0xFC8D78
	public override void Set(int record, object value) { }

	// RVA: 0xFC8F68
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFC90AC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFC9140
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFC91F4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFC9248
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFC934C
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

	// RVA: 0xFC4054
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0xFC959C
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0xFC941C
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0xFC9604
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0xFC54D0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0xFC63A0
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0xFC9624
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0xFC4298
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract int Compare(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xFC96E8
	public virtual object ConvertValue(object value) { }

	// RVA: 0xFC557C
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1
	public abstract void Copy(int recordNo1, int recordNo2) { }

	// RVA: -1
	public abstract object Get(int recordNo) { }

	// RVA: 0xFC56C0
	protected object GetBits(int recordNo) { }

	// RVA: 0xFC96F0
	public virtual int GetStringLength(int record) { }

	// RVA: 0xFC4470
	protected bool HasValue(int recordNo) { }

	// RVA: 0xFC96F8
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1
	public abstract void Set(int recordNo, object value) { }

	// RVA: 0xFC5888
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0xFC59EC
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1
	public abstract object ConvertXmlToObject(string s) { }

	// RVA: 0xFC9718
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1
	public abstract string ConvertObjectToXml(object value) { }

	// RVA: 0xFC9764
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFC97AC
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0xFCB3F8
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0xFCB528
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0xFCB5C8
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0xFC95A8
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0xFCB644
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0xFCB650
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0xFC95C4
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0xFCB760
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, bool sqlType, bool nullable, bool xmlSerializable, bool changeTracking, bool revertibleChangeTracking) { }

	// RVA: 0xFCB9DC
	private static System.Tuple<System.Boolean,System.Boolean,System.Boolean,System.Boolean> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0xFCBBC4
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0xFCBCA4
	public static bool IsObjectNull(object value) { }

	// RVA: 0xFCBE38
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0xFCBF10
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0xFCBF20
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFCBF30
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1
	protected abstract object GetEmptyStorage(int recordCount) { }

	// RVA: -1
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: -1
	protected abstract void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFCBF40
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0xFCBF48
	internal static Type GetType(string value) { }

	// RVA: 0xFCC090
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0xFCC12C
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0xFCAB90
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFCD068
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFCD584
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFCD75C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFCD914
	public override object ConvertValue(object value) { }

	// RVA: 0xFCD9D8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFCDA5C
	public override object Get(int record) { }

	// RVA: 0xFCDB8C
	public override void Set(int record, object value) { }

	// RVA: 0xFCDCC0
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFCDE04
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFCDE98
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFCDF50
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFCDFA4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFCE0B8
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFCE188
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DateTimeStorage
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0xFCA9F8
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFCE204
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFCE700
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFCE8FC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFCEAAC
	public override object ConvertValue(object value) { }

	// RVA: 0xFCEC10
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFCEC94
	public override object Get(int record) { }

	// RVA: 0xFCEDDC
	public override void Set(int record, object value) { }

	// RVA: 0xFCF1BC
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFCF300
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFCF3C8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFCF4C4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFCF518
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFCF694
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFCF8C8
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class DecimalStorage
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0xFCA83C
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFCF944
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD0478
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD0630
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD07C0
	public override object ConvertValue(object value) { }

	// RVA: 0xFD0944
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD09C8
	public override object Get(int record) { }

	// RVA: 0xFD0AA0
	public override void Set(int record, object value) { }

	// RVA: 0xFD0C64
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD0DA8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD0E68
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD0F20
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD0F74
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD1088
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class DoubleStorage
{
	// Fields
	private Double[] _values; // 0x50

	// Methods

	// RVA: 0xFCA6D4
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFD1158
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD18DC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD19AC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD1AD8
	public override object ConvertValue(object value) { }

	// RVA: 0xFD1C3C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD1CC0
	public override object Get(int record) { }

	// RVA: 0xFD1D90
	public override void Set(int record, object value) { }

	// RVA: 0xFD1F34
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD2078
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD210C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD21C0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD2214
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD2320
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int16Storage
{
	// Fields
	private Int16[] _values; // 0x50

	// Methods

	// RVA: 0xFCA29C
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFD23F0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD2C5C
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD2D14
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD2E3C
	public override object ConvertValue(object value) { }

	// RVA: 0xFD2FA0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD3024
	public override object Get(int record) { }

	// RVA: 0xFD30F0
	public override void Set(int record, object value) { }

	// RVA: 0xFD3294
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD33D8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD346C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD3520
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD3574
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD3678
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int32Storage
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0xFCA404
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFD3748
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD3FA8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD407C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD41A4
	public override object ConvertValue(object value) { }

	// RVA: 0xFD4308
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD438C
	public override object Get(int record) { }

	// RVA: 0xFD4458
	public override void Set(int record, object value) { }

	// RVA: 0xFD45FC
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD4740
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD47D4
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD4888
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD48DC
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD49E0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class Int64Storage
{
	// Fields
	private Int64[] _values; // 0x50

	// Methods

	// RVA: 0xFCA56C
	internal void .ctor(DataColumn column) { }

	// RVA: 0xFD4AB0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD5350
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD5424
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD554C
	public override object ConvertValue(object value) { }

	// RVA: 0xFD56B0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD5734
	public override object Get(int record) { }

	// RVA: 0xFD5800
	public override void Set(int record, object value) { }

	// RVA: 0xFD59A4
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD5AE8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD5B7C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD5C30
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD5C84
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD5D88
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SByteStorage
{
	// Fields
	private SByte[] _values; // 0x50

	// Methods

	// RVA: 0xFCA134
	public void .ctor(DataColumn column) { }

	// RVA: 0xFD5E58
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFD6698
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFD6784
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFD68AC
	public override object ConvertValue(object value) { }

	// RVA: 0xFD6A10
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFD6A94
	public override object Get(int record) { }

	// RVA: 0xFD6B78
	public override void Set(int record, object value) { }

	// RVA: 0xFD6D1C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFD6E60
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFD6EF4
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFD6FA8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFD6FFC
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFD7100
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal static class SqlConvert
{
	// Methods

	// RVA: 0xFD71D0
	public static SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0xFD7408
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0xFD7720
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0xFD7B78
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0xFD80D0
	public static SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0xFD883C
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0xFD8EA4
	public static SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0xFD95A4
	public static SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0xFD9C34
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0xFD9E70
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0xFDA094
	public static SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0xFDA2D4
	public static SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0xFDA508
	public static SqlString ConvertToSqlString(object value) { }

	// RVA: 0xFDA710
	public static SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0xFDA880
	public static SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0xFDA9F0
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0xFDAA5C
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xFDAC48
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0xFDBD1C
	public static object ChangeTypeForXML(object value, Type type) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0xFCAD28
	public void .ctor(DataColumn column) { }

	// RVA: 0xFDDB14
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFDDD70
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFDDE14
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFDDED4
	public override object ConvertValue(object value) { }

	// RVA: 0xFDDF60
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFDDFA8
	public override object Get(int record) { }

	// RVA: 0xFDE034
	public override bool IsNull(int record) { }

	// RVA: 0xFDE0BC
	public override void Set(int record, object value) { }

	// RVA: 0xFDE10C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFDE1D0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFDE47C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFDE6E4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFDE738
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFDE844
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlByteStorage
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0xFCAE60
	public void .ctor(DataColumn column) { }

	// RVA: 0xFDE8F4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFDF730
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFDF7D4
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFDF894
	public override object ConvertValue(object value) { }

	// RVA: 0xFDF920
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFDF960
	public override object Get(int record) { }

	// RVA: 0xFDF9EC
	public override bool IsNull(int record) { }

	// RVA: 0xFDFA74
	public override void Set(int record, object value) { }

	// RVA: 0xFDFABC
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFDFB80
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFDFE2C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE0094
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE00E8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE01EC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBytesStorage
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0xFCAF98
	public void .ctor(DataColumn column) { }

	// RVA: 0xFE029C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE04D0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE04D8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE04E0
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE0524
	public override object Get(int record) { }

	// RVA: 0xFE0558
	public override bool IsNull(int record) { }

	// RVA: 0xFE0594
	public override void Set(int record, object value) { }

	// RVA: 0xFE06C0
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE0784
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE0A54
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE0CBC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE0D10
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE0E1C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlCharsStorage
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0xFCB080
	public void .ctor(DataColumn column) { }

	// RVA: 0xFE0ECC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE1100
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE1108
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE1110
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE1154
	public override object Get(int record) { }

	// RVA: 0xFE1188
	public override bool IsNull(int record) { }

	// RVA: 0xFE11C4
	public override void Set(int record, object value) { }

	// RVA: 0xFE12F0
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE13B4
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE1690
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE18F8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE194C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE1A58
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0xFCB168
	public void .ctor(DataColumn column) { }

	// RVA: 0xFE1B08
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE2124
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE21D8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE22A0
	public override object ConvertValue(object value) { }

	// RVA: 0xFE2330
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE2384
	public override object Get(int record) { }

	// RVA: 0xFE241C
	public override bool IsNull(int record) { }

	// RVA: 0xFE24A8
	public override void Set(int record, object value) { }

	// RVA: 0xFE24F8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE25BC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE2874
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE2ADC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE2B30
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE2C4C
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0xFCB2B0
	public void .ctor(DataColumn column) { }

	// RVA: 0xFE2CFC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE3C18
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE3CEC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE3DCC
	public override object ConvertValue(object value) { }

	// RVA: 0xFE3E58
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE3EAC
	public override object Get(int record) { }

	// RVA: 0xFE3F4C
	public override bool IsNull(int record) { }

	// RVA: 0xFE3FD8
	public override void Set(int record, object value) { }

	// RVA: 0xFE403C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE4100
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE43B8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE4620
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE4674
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE47A0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0xFE4850
	public void .ctor(DataColumn column) { }

	// RVA: 0xFE4988
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE56A0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE5748
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE5808
	public override object ConvertValue(object value) { }

	// RVA: 0xFE5898
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE58D8
	public override object Get(int record) { }

	// RVA: 0xFE5964
	public override bool IsNull(int record) { }

	// RVA: 0xFE59EC
	public override void Set(int record, object value) { }

	// RVA: 0xFE5A38
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE5AFC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE5DA8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE600C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE6060
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE6174
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlGuidStorage
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0xFE6224
	public void .ctor(DataColumn column) { }

	// RVA: 0xFE635C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE65B8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE665C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE671C
	public override object ConvertValue(object value) { }

	// RVA: 0xFE67AC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE67F4
	public override object Get(int record) { }

	// RVA: 0xFE6880
	public override bool IsNull(int record) { }

	// RVA: 0xFE6908
	public override void Set(int record, object value) { }

	// RVA: 0xFE695C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE6A20
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE6CCC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE6F30
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE6F84
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE7090
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt16Storage
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0xFE7140
	public void .ctor(DataColumn column) { }

	// RVA: 0xFE7278
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE80B4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE8158
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE8218
	public override object ConvertValue(object value) { }

	// RVA: 0xFE82A8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE82E8
	public override object Get(int record) { }

	// RVA: 0xFE8374
	public override bool IsNull(int record) { }

	// RVA: 0xFE83FC
	public override void Set(int record, object value) { }

	// RVA: 0xFE8448
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE850C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFE87B8
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFE8A1C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFE8A70
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFE8B74
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt32Storage
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0xFE8C24
	public void .ctor(DataColumn column) { }

	// RVA: 0xFE8D5C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFE9B68
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFE9C0C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFE9CCC
	public override object ConvertValue(object value) { }

	// RVA: 0xFE9D5C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFE9D9C
	public override object Get(int record) { }

	// RVA: 0xFE9E28
	public override bool IsNull(int record) { }

	// RVA: 0xFE9EB0
	public override void Set(int record, object value) { }

	// RVA: 0xFE9EFC
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFE9FC0
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFEA26C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFEA4D0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFEA524
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFEA628
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlInt64Storage
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0xFEA6D8
	public void .ctor(DataColumn column) { }

	// RVA: 0xFEA810
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFEB710
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFEB7B8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFEB878
	public override object ConvertValue(object value) { }

	// RVA: 0xFEB908
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFEB948
	public override object Get(int record) { }

	// RVA: 0xFEB9D4
	public override bool IsNull(int record) { }

	// RVA: 0xFEBA5C
	public override void Set(int record, object value) { }

	// RVA: 0xFEBAA8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFEBB6C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFEBE18
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFEC07C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFEC0D0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFEC1E4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0xFEC294
	public void .ctor(DataColumn column) { }

	// RVA: 0xFEC3CC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFED2CC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFED374
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFED434
	public override object ConvertValue(object value) { }

	// RVA: 0xFED4C4
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFED504
	public override object Get(int record) { }

	// RVA: 0xFED590
	public override bool IsNull(int record) { }

	// RVA: 0xFED618
	public override void Set(int record, object value) { }

	// RVA: 0xFED664
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFED728
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFED9D4
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFEDC38
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFEDC8C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFEDDA0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlSingleStorage
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0xFEDE50
	public void .ctor(DataColumn column) { }

	// RVA: 0xFEDF88
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFEED64
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFEEE08
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFEEEC8
	public override object ConvertValue(object value) { }

	// RVA: 0xFEEF58
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFEEF98
	public override object Get(int record) { }

	// RVA: 0xFEF024
	public override bool IsNull(int record) { }

	// RVA: 0xFEF0AC
	public override void Set(int record, object value) { }

	// RVA: 0xFEF0F8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFEF1BC
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFEF468
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFEF6CC
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFEF720
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFEF824
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlStringStorage
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0xFEF8D4
	public void .ctor(DataColumn column) { }

	// RVA: 0xFEFA18
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0xFEFE40
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFEFEB0
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0xFF006C
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF0134
	public override object ConvertValue(object value) { }

	// RVA: 0xFF01CC
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF0220
	public override object Get(int record) { }

	// RVA: 0xFF02B4
	public override int GetStringLength(int record) { }

	// RVA: 0xFF03A4
	public override bool IsNull(int record) { }

	// RVA: 0xFF0430
	public override void Set(int record, object value) { }

	// RVA: 0xFF049C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF0560
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF0810
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF0A74
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF0AC8
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF0BF0
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0xFF0CA0
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF0DD8
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF1260
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF1304
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF13C4
	public override object ConvertValue(object value) { }

	// RVA: 0xFF1454
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF1494
	public override object Get(int record) { }

	// RVA: 0xFF1520
	public override bool IsNull(int record) { }

	// RVA: 0xFF15A8
	public override void Set(int record, object value) { }

	// RVA: 0xFF15F4
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF16B8
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF1964
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF1BC8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF1C1C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF1D20
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class SingleStorage
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0xFF1DD0
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF1ED0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF25EC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF2680
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF27AC
	public override object ConvertValue(object value) { }

	// RVA: 0xFF2908
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF296C
	public override object Get(int record) { }

	// RVA: 0xFF2A20
	public override void Set(int record, object value) { }

	// RVA: 0xFF2BB8
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF2C98
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF2D2C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF2DE0
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF2E34
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF2F40
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: 
private sealed class <>c__DisplayClass6_0
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0xFF3374
	public void .ctor() { }

	// RVA: 0xFF47F4
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

	// RVA: 0xFF3010
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0xFF31C8
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0xFF3094
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0xFF337C
	public override bool IsNull(int record) { }

	// RVA: 0xFF34A0
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF34D8
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF3514
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0xFF37D4
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF3868
	public override object Get(int recordNo) { }

	// RVA: 0xFF389C
	public override void Set(int recordNo, object value) { }

	// RVA: 0xFF3A30
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF3B10
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF3E20
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFF40CC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF43A8
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0xFF4510
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF4564
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF46A8
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFF4758
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class StringStorage
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0xFF492C
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF4A18
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0xFF4D04
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF4D88
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF4E6C
	public override object ConvertValue(object value) { }

	// RVA: 0xFF4E9C
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF4EE0
	public override object Get(int recordNo) { }

	// RVA: 0xFF4F2C
	public override int GetStringLength(int record) { }

	// RVA: 0xFF4F74
	public override bool IsNull(int record) { }

	// RVA: 0xFF4FB0
	public override void Set(int record, object value) { }

	// RVA: 0xFF503C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF5100
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF5108
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF516C
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF51C0
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF52CC
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class TimeSpanStorage
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0xFF537C
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF54AC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF6098
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF6268
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF6430
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0xFF6660
	public override object ConvertValue(object value) { }

	// RVA: 0xFF6728
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF678C
	public override object Get(int record) { }

	// RVA: 0xFF68C0
	public override void Set(int record, object value) { }

	// RVA: 0xFF69A0
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF6A80
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF6B14
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF6BC8
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF6C1C
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF6D20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0xFF6DF0
	private static void .cctor() { }

}

// Namespace: System.Data.Common
internal sealed class UInt16Storage
{
	// Fields
	private static readonly UInt16 s_defaultValue; // 0x0
	private UInt16[] _values; // 0x50

	// Methods

	// RVA: 0xFF6E6C
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF6F94
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF77B4
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF7888
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF79C8
	public override object ConvertValue(object value) { }

	// RVA: 0xFF7B24
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF7B88
	public override object Get(int record) { }

	// RVA: 0xFF7C70
	public override void Set(int record, object value) { }

	// RVA: 0xFF7E28
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF7F08
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF7F9C
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF8050
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF80A4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF81A4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt32Storage
{
	// Fields
	private static readonly UInt32 s_defaultValue; // 0x0
	private UInt32[] _values; // 0x50

	// Methods

	// RVA: 0xFF8274
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF839C
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF8BC0
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFF8CB8
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFF8DF8
	public override object ConvertValue(object value) { }

	// RVA: 0xFF8F54
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFF8FB8
	public override object Get(int record) { }

	// RVA: 0xFF90A0
	public override void Set(int record, object value) { }

	// RVA: 0xFF9258
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFF9338
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFF93CC
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFF9480
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFF94D4
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFF95D4
	protected override void SetStorage(object store, BitArray nullbits) { }

}

// Namespace: System.Data.Common
internal sealed class UInt64Storage
{
	// Fields
	private static readonly UInt64 s_defaultValue; // 0x0
	private UInt64[] _values; // 0x50

	// Methods

	// RVA: 0xFF96A4
	public void .ctor(DataColumn column) { }

	// RVA: 0xFF97CC
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0xFF9FEC
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0xFFA0FC
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0xFFA23C
	public override object ConvertValue(object value) { }

	// RVA: 0xFFA398
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0xFFA3FC
	public override object Get(int record) { }

	// RVA: 0xFFA4E4
	public override void Set(int record, object value) { }

	// RVA: 0xFFA69C
	public override void SetCapacity(int capacity) { }

	// RVA: 0xFFA77C
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0xFFA810
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0xFFA8C4
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0xFFA918
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0xFFAA18
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


