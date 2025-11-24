// Namespace: 
internal class <Module> 
{}

// Namespace: 
internal static class SR 
{
	// Methods

	// RVA: 0xFFC8D0
	string Format(string resourceFormat, object p1) { }

	// RVA: 0xFFC944
	string Format(string resourceFormat, object p1, object p2) { }

}

// Namespace: System.Xml.Linq
internal class BaseUriAnnotation 
{
	// Fields
	internal string baseUri; // 0x10

	// Methods

	// RVA: 0xFFC9C8
	void .ctor(string baseUri) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoAnnotation 
{
	// Fields
	internal int lineNumber; // 0x10
	internal int linePosition; // 0x14

	// Methods

	// RVA: 0xFFC9FC
	void .ctor(int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoEndElementAnnotation 
{
	// Methods

	// RVA: 0xFFCA34
	void .ctor(int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Linq
public class XAttribute 
{
	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Methods

	// RVA: 0xFFCA6C
	void .ctor(XName name, object value) { }

	// RVA: 0xFFD164
	void .ctor(XAttribute other) { }

	// RVA: 0xFFD1F4
	bool get_IsNamespaceDeclaration() { }

	// RVA: 0xFFD2B4
	XName get_Name() { }

	// RVA: 0xFFD2BC
	XmlNodeType get_NodeType() { }

	// RVA: 0xFFD2C4
	string get_Value() { }

	// RVA: 0xFFD2CC
	string ToString() { }

	// RVA: 0xFFD63C
	string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0xFFCF28
	void ValidateAttribute(XName name, string value) { }

}

// Namespace: System.Xml.Linq
public class XCData 
{
	// Methods

	// RVA: 0xFFDA2C
	void .ctor(string value) { }

	// RVA: 0xFFDAB0
	void .ctor(XCData other) { }

	// RVA: 0xFFDB34
	XmlNodeType get_NodeType() { }

	// RVA: 0xFFDB3C
	void WriteTo(XmlWriter writer) { }

	// RVA: 0xFFDBB8
	XNode CloneNode() { }

}

// Namespace: System.Xml.Linq
public class XComment 
{
	// Fields
	internal string value; // 0x28

	// Methods

	// RVA: 0xFFDC1C
	void .ctor(string value) { }

	// RVA: 0xFFDCA4
	void .ctor(XComment other) { }

	// RVA: 0xFFDD24
	XmlNodeType get_NodeType() { }

	// RVA: 0xFFDD2C
	string get_Value() { }

	// RVA: 0xFFDD34
	void WriteTo(XmlWriter writer) { }

	// RVA: 0xFFDDB0
	XNode CloneNode() { }

}

// Namespace: 
private sealed class ContentReader 
{
	// Fields
	private readonly NamespaceCache _eCache; // 0x10
	private readonly NamespaceCache _aCache; // 0x20
	private readonly IXmlLineInfo _lineInfo; // 0x30
	private XContainer _currentContainer; // 0x38
	private string _baseUri; // 0x40

	// Methods

	// RVA: 0xFFFBD0
	void .ctor(XContainer rootContainer) { }

	// RVA: 0x1000518
	void .ctor(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	// RVA: 0xFFFC04
	bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

	// RVA: 0x10005EC
	bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) { }

}

// Namespace: 
private sealed class <Nodes>d__18 
{
	// Fields
	private int <>1__state; // 0x10
	private XNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XContainer <>4__this; // 0x28
	private XNode <n>5__2; // 0x30

	// Methods

	// RVA: 0xFFF088
	void .ctor(int <>1__state) { }

	// RVA: 0x1001F74
	void System.IDisposable.Dispose() { }

	// RVA: 0x1001F78
	bool MoveNext() { }

	// RVA: 0x1002044
	XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	// RVA: 0x100204C
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x100208C
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1002094
	System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	// RVA: 0x1002148
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public abstract class XContainer 
{
	// Fields
	internal object content; // 0x28

	// Methods

	// RVA: 0xFFDE14
	void .ctor() { }

	// RVA: 0xFFDE1C
	void .ctor(XContainer other) { }

	// RVA: 0xFFE068
	XNode get_LastNode() { }

	// RVA: 0xFFE1EC
	void Add(object content) { }

	// RVA: 0xFFF000
	System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes() { }

	// RVA: 0xFFF0C0
	void AddAttribute(XAttribute a) { }

	// RVA: 0xFFF0C4
	void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0xFFE72C
	void AddContentSkipNotify(object content) { }

	// RVA: 0xFFEB74
	void AddNode(XNode n) { }

	// RVA: 0xFFF0C8
	void AddNodeSkipNotify(XNode n) { }

	// RVA: 0xFFEBF8
	void AddString(string s) { }

	// RVA: 0xFFF14C
	void AddStringSkipNotify(string s) { }

	// RVA: 0xFFF3E8
	void AppendNode(XNode n) { }

	// RVA: 0xFFDF70
	void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0xFFF9CC
	void AppendText(StringBuilder sb) { }

	// RVA: 0xFFF2F0
	void ConvertTextToNode() { }

	// RVA: 0xFFCB58
	string GetStringValue(object value) { }

	// RVA: 0xFFFAC4
	void ReadContentFrom(XmlReader r) { }

	// RVA: 0x10003EC
	void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1001580
	void RemoveNode(XNode n) { }

	// RVA: 0x1001878
	void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x100187C
	void ValidateString(string s) { }

	// RVA: 0x1001880
	void WriteContentTo(XmlWriter writer) { }

}

// Namespace: System.Xml.Linq
public class XDeclaration 
{
	// Fields
	private string _version; // 0x10
	private string _encoding; // 0x18
	private string _standalone; // 0x20

	// Methods

	// RVA: 0x100214C
	void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x10021B0
	void .ctor(XDeclaration other) { }

	// RVA: 0x1002250
	string get_Encoding() { }

	// RVA: 0x1002258
	string get_Standalone() { }

	// RVA: 0x1002260
	string get_Version() { }

	// RVA: 0x1002268
	string ToString() { }

}

// Namespace: System.Xml.Linq
public class XDocument 
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Methods

	// RVA: 0x1002584
	void .ctor() { }

	// RVA: 0x100258C
	void .ctor(XDocument other) { }

	// RVA: 0x1002628
	XDeclaration get_Declaration() { }

	// RVA: 0x1002630
	void set_Declaration(XDeclaration value) { }

	// RVA: 0x1002638
	XmlNodeType get_NodeType() { }

	// RVA: 0x1002640
	XElement get_Root() { }

	// RVA: 0x1002694
	void WriteTo(XmlWriter writer) { }

	// RVA: 0x10027D4
	void AddAttribute(XAttribute a) { }

	// RVA: 0x1002828
	void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x100287C
	XNode CloneNode() { }

	// RVA: 0x309AF8C
	T GetFirstNode() { }

	// RVA: 0x1002998
	bool IsWhitespace(string s) { }

	// RVA: 0x1002A24
	void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x1002BEC
	void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x1002D1C
	void ValidateString(string s) { }

}

// Namespace: System.Xml.Linq
public class XDocumentType 
{
	// Fields
	private string _name; // 0x28
	private string _publicId; // 0x30
	private string _systemId; // 0x38
	private string _internalSubset; // 0x40

	// Methods

	// RVA: 0x1001C30
	void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1002DE4
	void .ctor(XDocumentType other) { }

	// RVA: 0x1002E94
	string get_InternalSubset() { }

	// RVA: 0x1002E9C
	string get_Name() { }

	// RVA: 0x1002EA4
	XmlNodeType get_NodeType() { }

	// RVA: 0x1002EAC
	string get_PublicId() { }

	// RVA: 0x1002EB4
	string get_SystemId() { }

	// RVA: 0x1002EBC
	void WriteTo(XmlWriter writer) { }

	// RVA: 0x1002F38
	XNode CloneNode() { }

}

// Namespace: 
private sealed class <GetAttributes>d__116 
{
	// Fields
	private int <>1__state; // 0x10
	private XAttribute <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XElement <>4__this; // 0x28
	private XName name; // 0x30
	public XName <>3__name; // 0x38
	private XAttribute <a>5__2; // 0x40

	// Methods

	// RVA: 0x1003ED4
	void .ctor(int <>1__state) { }

	// RVA: 0x1004990
	void System.IDisposable.Dispose() { }

	// RVA: 0x1004994
	bool MoveNext() { }

	// RVA: 0x1004A84
	XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	// RVA: 0x1004A8C
	void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1004ACC
	object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1004AD4
	System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	// RVA: 0x1004B8C
	IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public class XElement 
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Methods

	// RVA: 0x1001A98
	void .ctor(XName name) { }

	// RVA: 0x1002F9C
	void .ctor(XElement other) { }

	// RVA: 0xFFEF74
	void .ctor(XStreamingElement other) { }

	// RVA: 0x10030A4
	bool get_HasAttributes() { }

	// RVA: 0x10030B4
	bool get_IsEmpty() { }

	// RVA: 0x10030C4
	XName get_Name() { }

	// RVA: 0x10030CC
	XmlNodeType get_NodeType() { }

	// RVA: 0x10030D4
	string get_Value() { }

	// RVA: 0x1003174
	XAttribute Attribute(XName name) { }

	// RVA: 0x10031B4
	System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes() { }

	// RVA: 0xFFD7A0
	string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1003410
	void WriteTo(XmlWriter writer) { }

	// RVA: 0x1003708
	XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1003710
	void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x10039B4
	void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x10039C0
	void AddAttribute(XAttribute a) { }

	// RVA: 0x1003D30
	void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1003AB4
	void AppendAttribute(XAttribute a) { }

	// RVA: 0x1001B18
	void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1003E70
	XNode CloneNode() { }

	// RVA: 0x100324C
	System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(XName name) { }

	// RVA: 0x10032F4
	string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x1003930
	void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1003F0C
	void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x1001DF8
	void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1004850
	void ValidateNode(XNode node, XNode previous) { }

}

// Namespace: 
public sealed class ExtractKeyDelegate 
{
	// Methods

	// RVA: -1
	internal void .ctor(object object, IntPtr method) { }

	// RVA: 0x309AF8C
	internal string Invoke(TValue value) { }

}

// Namespace: 
private struct Entry 
{
	// Fields
	public TValue Value; // 0x0
	public int HashCode; // 0x0
	public int Next; // 0x0
}

// Namespace: 
private sealed class XHashtableState 
{
	// Fields
	private int[] _buckets; // 0x0
	private Entry[] _entries; // 0x0
	private int _numEntries; // 0x0
	private ExtractKeyDelegate _extractKey; // 0x0

	// Methods

	// RVA: 0x2FE45DC
	void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: 0x2FE360C
	XHashtableState Resize() { }

	// RVA: -1
	bool TryGetValue(string key, int index, int count, out TValue value) { }

	// RVA: 0x309AF8C
	bool TryAdd(TValue value, out TValue newValue) { }

	// RVA: 0x309AF8C
	bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }

	// RVA: 0x2FE61A0
	int ComputeHashCode(string key, int index, int count) { }

}

// Namespace: System.Xml.Linq
internal sealed class XHashtable<T0> 
{
	// Fields
	private XHashtableState _state; // 0x0

	// Methods

	// RVA: 0x2FE45DC
	void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: -1
	bool TryGetValue(string key, int index, int count, out TValue value) { }

	// RVA: 0x309AF8C
	TValue Add(TValue value) { }

}

// Namespace: System.Xml.Linq
internal struct NamespaceCache 
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _namespaceName; // 0x18

	// Methods

	// RVA: 0x10019DC
	XNamespace Get(string namespaceName) { }

}

// Namespace: System.Xml.Linq
internal struct ElementWriter 
{
	// Fields
	private XmlWriter _writer; // 0x10
	private NamespaceResolver _resolver; // 0x18

	// Methods

	// RVA: 0x10034AC
	void .ctor(XmlWriter writer) { }

	// RVA: 0x10034D8
	void WriteElement(XElement e) { }

	// RVA: 0x100513C
	string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x1004B90
	void PushAncestors(XElement e) { }

	// RVA: 0x10054D4
	void PushElement(XElement e) { }

	// RVA: 0x1004FCC
	void WriteEndElement() { }

	// RVA: 0x1005084
	void WriteFullEndElement() { }

	// RVA: 0x1004E60
	void WriteStartElement(XElement e) { }

}

// Namespace: 
private class NamespaceDeclaration 
{
	// Fields
	public string prefix; // 0x10
	public XNamespace ns; // 0x18
	public int scope; // 0x20
	public NamespaceDeclaration prev; // 0x28

	// Methods

	// RVA: 0x1005764
	void .ctor() { }

}

// Namespace: System.Xml.Linq
internal struct NamespaceResolver 
{
	// Fields
	private int _scope; // 0x10
	private NamespaceDeclaration _declaration; // 0x18
	private NamespaceDeclaration _rover; // 0x20

	// Methods

	// RVA: 0x10055B8
	void PushScope() { }

	// RVA: 0x10056C0
	void PopScope() { }

	// RVA: 0x10055C8
	void Add(string prefix, XNamespace ns) { }

	// RVA: 0x10053E0
	void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x1005268
	string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

}

// Namespace: System.Xml.Linq
public enum XObjectChange 
{
	// Fields
	public int value__; // 0x10
	public const XObjectChange Add = 0;
	public const XObjectChange Remove = 1;
	public const XObjectChange Name = 2;
	public const XObjectChange Value = 3;
}

// Namespace: System.Xml.Linq
public enum LoadOptions 
{
	// Fields
	public int value__; // 0x10
	public const LoadOptions None = 0;
	public const LoadOptions PreserveWhitespace = 1;
	public const LoadOptions SetBaseUri = 2;
	public const LoadOptions SetLineInfo = 4;
}

// Namespace: System.Xml.Linq
public enum SaveOptions 
{
	// Fields
	public int value__; // 0x10
	public const SaveOptions None = 0;
	public const SaveOptions DisableFormatting = 1;
	public const SaveOptions OmitDuplicateNamespaces = 2;
}

// Namespace: System.Xml.Linq
public sealed class XName 
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _localName; // 0x18
	private int _hashCode; // 0x20

	// Methods

	// RVA: 0x100576C
	void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x1005848
	string get_LocalName() { }

	// RVA: 0x1005850
	XNamespace get_Namespace() { }

	// RVA: 0xFFD294
	string get_NamespaceName() { }

	// RVA: 0x1005858
	string ToString() { }

	// RVA: 0x10058EC
	XName Get(string expandedName) { }

	// RVA: 0x1006004
	XName Get(string localName, string namespaceName) { }

	// RVA: 0x1006034
	XName op_Implicit(string expandedName) { }

	// RVA: 0x1006040
	bool Equals(object obj) { }

	// RVA: 0x100604C
	int GetHashCode() { }

	// RVA: 0xFFCB4C
	bool op_Equality(XName left, XName right) { }

	// RVA: 0x1006054
	bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x1006060
	void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x10060A0
	void .ctor() { }

}

// Namespace: System.Xml.Linq
public sealed class XNamespace 
{
	// Fields
	private static System.Xml.Linq.XHashtable<System.WeakReference> s_namespaces; // 0x0
	private static WeakReference s_refNone; // 0x8
	private static WeakReference s_refXml; // 0x10
	private static WeakReference s_refXmlns; // 0x18
	private string _namespaceName; // 0x10
	private int _hashCode; // 0x18
	private System.Xml.Linq.XHashtable<System.Xml.Linq.XName> _names; // 0x20

	// Methods

	// RVA: 0x10060DC
	void .ctor(string namespaceName) { }

	// RVA: 0x10061EC
	string get_NamespaceName() { }

	// RVA: 0x1001A2C
	XName GetName(string localName) { }

	// RVA: 0x10061F4
	string ToString() { }

	// RVA: 0x1005F90
	XNamespace get_None() { }

	// RVA: 0x10062E4
	XNamespace get_Xml() { }

	// RVA: 0x1006350
	XNamespace get_Xmlns() { }

	// RVA: 0x1004580
	XNamespace Get(string namespaceName) { }

	// RVA: 0x10063BC
	XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0x10063C8
	bool Equals(object obj) { }

	// RVA: 0x10063D4
	int GetHashCode() { }

	// RVA: 0x10032E8
	bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x10063DC
	bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x1005E64
	XName GetName(string localName, int index, int count) { }

	// RVA: 0x1005A94
	XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x10063E8
	string ExtractLocalName(XName n) { }

	// RVA: 0x1006404
	string ExtractNamespace(WeakReference r) { }

	// RVA: 0x10061FC
	XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }

}

// Namespace: System.Xml.Linq
public abstract class XNode 
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0xFFDC9C
	void .ctor() { }

	// RVA: 0x1006488
	void Remove() { }

	// RVA: 0x10064F4
	string ToString() { }

	// RVA: 0x2FE4574
	void WriteTo(XmlWriter writer) { }

	// RVA: 0x10069F8
	void AppendText(StringBuilder sb) { }

	// RVA: 0x2FE360C
	XNode CloneNode() { }

	// RVA: 0x1006614
	string GetXmlString(SaveOptions o) { }

}

// Namespace: System.Xml.Linq
public abstract class XObject 
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Methods

	// RVA: 0xFFCB44
	void .ctor() { }

	// RVA: 0x1001ED4
	string get_BaseUri() { }

	// RVA: 0x2FE32D4
	XmlNodeType get_NodeType() { }

	// RVA: 0x10069FC
	XElement get_Parent() { }

	// RVA: 0x10045EC
	void AddAnnotation(object annotation) { }

	// RVA: 0x1006A84
	object AnnotationForSealedType(Type type) { }

	// RVA: 0x309AF8C
	T Annotation() { }

	// RVA: 0x1006BC8
	bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x1006C28
	int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1006C88
	int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1001E74
	bool get_HasBaseUri() { }

	// RVA: 0xFFF6D4
	bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0xFFF620
	bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1001D00
	void SetBaseUri(string baseUri) { }

	// RVA: 0x1001D7C
	void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0xFFE6AC
	bool SkipNotify() { }

	// RVA: 0x100651C
	SaveOptions GetSaveOptionsFromAnnotations() { }

}

// Namespace: System.Xml.Linq
internal class XObjectChangeAnnotation 
{
	// Fields
	internal System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changing; // 0x10
	internal System.EventHandler<System.Xml.Linq.XObjectChangeEventArgs> changed; // 0x18
}

// Namespace: System.Xml.Linq
public class XObjectChangeEventArgs 
{
	// Fields
	private XObjectChange _objectChange; // 0x10
	public static readonly XObjectChangeEventArgs Add; // 0x0
	public static readonly XObjectChangeEventArgs Remove; // 0x8
	public static readonly XObjectChangeEventArgs Name; // 0x10
	public static readonly XObjectChangeEventArgs Value; // 0x18

	// Methods

	// RVA: 0x1006CE8
	void .ctor(XObjectChange objectChange) { }

	// RVA: 0x1006D58
	void .cctor() { }

}

// Namespace: System.Xml.Linq
public class XProcessingInstruction 
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Methods

	// RVA: 0x1001B8C
	void .ctor(string target, string data) { }

	// RVA: 0x1007014
	void .ctor(XProcessingInstruction other) { }

	// RVA: 0x10070A4
	string get_Data() { }

	// RVA: 0x10070AC
	XmlNodeType get_NodeType() { }

	// RVA: 0x10070B4
	string get_Target() { }

	// RVA: 0x10070BC
	void WriteTo(XmlWriter writer) { }

	// RVA: 0x1007138
	XNode CloneNode() { }

	// RVA: 0x1006F30
	void ValidateName(string name) { }

}

// Namespace: System.Xml.Linq
public class XStreamingElement 
{
	// Fields
	internal XName name; // 0x10
	internal object content; // 0x18
}

// Namespace: System.Xml.Linq
public class XText 
{
	// Fields
	internal string text; // 0x28

	// Methods

	// RVA: 0xFFDA30
	void .ctor(string value) { }

	// RVA: 0xFFDAB4
	void .ctor(XText other) { }

	// RVA: 0x100719C
	XmlNodeType get_NodeType() { }

	// RVA: 0x10071A4
	string get_Value() { }

	// RVA: 0xFFF788
	void set_Value(string value) { }

	// RVA: 0x10071AC
	void WriteTo(XmlWriter writer) { }

	// RVA: 0x10072B4
	void AppendText(StringBuilder sb) { }

	// RVA: 0x10072DC
	XNode CloneNode() { }

}

// Namespace: System.Text
internal static class StringBuilderCache 
{
	// Fields
	private static StringBuilder t_cachedInstance; // 0xFFFFFFFF

	// Methods

	// RVA: 0x10023E0
	StringBuilder Acquire(int capacity) { }

	// RVA: 0x1007340
	void Release(StringBuilder sb) { }

	// RVA: 0x10024C4
	string GetStringAndRelease(StringBuilder sb) { }

}

// Namespace: Unity
internal sealed class ThrowStub 
{
	// Methods

	// RVA: 0x10073C4
	void ThrowNotSupportedException() { }

}


