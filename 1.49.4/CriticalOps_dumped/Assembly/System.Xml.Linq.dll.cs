// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x1023DFC
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x1023E70
	internal static string Format(string resourceFormat, object p1, object p2) { }

}

// Namespace: System.Xml.Linq
internal class BaseUriAnnotation
{
	// Fields
	internal string baseUri; // 0x10

	// Methods

	// RVA: 0x1023EF4
	public void .ctor(string baseUri) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoAnnotation
{
	// Fields
	internal int lineNumber; // 0x10
	internal int linePosition; // 0x14

	// Methods

	// RVA: 0x1023F28
	public void .ctor(int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoEndElementAnnotation
{
	// Methods

	// RVA: 0x1023F60
	public void .ctor(int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Linq
public class XAttribute
{
	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Methods

	// RVA: 0x1023F98
	public void .ctor(XName name, object value) { }

	// RVA: 0x1024690
	public void .ctor(XAttribute other) { }

	// RVA: 0x1024720
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x10247E0
	public XName get_Name() { }

	// RVA: 0x10247E8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x10247F0
	public string get_Value() { }

	// RVA: 0x10247F8
	public override string ToString() { }

	// RVA: 0x1024B68
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1024454
	private static void ValidateAttribute(XName name, string value) { }

}

// Namespace: System.Xml.Linq
public class XCData
{
	// Methods

	// RVA: 0x1024F58
	public void .ctor(string value) { }

	// RVA: 0x1024FDC
	public void .ctor(XCData other) { }

	// RVA: 0x1025060
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1025068
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x10250E4
	internal override XNode CloneNode() { }

}

// Namespace: System.Xml.Linq
public class XComment
{
	// Fields
	internal string value; // 0x28

	// Methods

	// RVA: 0x1025148
	public void .ctor(string value) { }

	// RVA: 0x10251D0
	public void .ctor(XComment other) { }

	// RVA: 0x1025250
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1025258
	public string get_Value() { }

	// RVA: 0x1025260
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x10252DC
	internal override XNode CloneNode() { }

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

	// RVA: 0x10270FC
	public void .ctor(XContainer rootContainer) { }

	// RVA: 0x1027A44
	public void .ctor(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	// RVA: 0x1027130
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

	// RVA: 0x1027B18
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) { }

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

	// RVA: 0x10265B4
	public void .ctor(int <>1__state) { }

	// RVA: 0x10294A0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x10294A4
	private bool MoveNext() { }

	// RVA: 0x1029570
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	// RVA: 0x1029578
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x10295B8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x10295C0
	private System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	// RVA: 0x1029674
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public abstract class XContainer
{
	// Fields
	internal object content; // 0x28

	// Methods

	// RVA: 0x1025340
	internal void .ctor() { }

	// RVA: 0x1025348
	internal void .ctor(XContainer other) { }

	// RVA: 0x1025594
	public XNode get_LastNode() { }

	// RVA: 0x1025718
	public void Add(object content) { }

	// RVA: 0x102652C
	public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes() { }

	// RVA: 0x10265EC
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x10265F0
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1025C58
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x10260A0
	internal void AddNode(XNode n) { }

	// RVA: 0x10265F4
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x1026124
	internal void AddString(string s) { }

	// RVA: 0x1026678
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x1026914
	internal void AppendNode(XNode n) { }

	// RVA: 0x102549C
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x1026EF8
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x102681C
	internal void ConvertTextToNode() { }

	// RVA: 0x1024084
	internal static string GetStringValue(object value) { }

	// RVA: 0x1026FF0
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x1027918
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1028AAC
	internal void RemoveNode(XNode n) { }

	// RVA: 0x1028DA4
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x1028DA8
	internal virtual void ValidateString(string s) { }

	// RVA: 0x1028DAC
	internal void WriteContentTo(XmlWriter writer) { }

}

// Namespace: System.Xml.Linq
public class XDeclaration
{
	// Fields
	private string _version; // 0x10
	private string _encoding; // 0x18
	private string _standalone; // 0x20

	// Methods

	// RVA: 0x1029678
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x10296DC
	public void .ctor(XDeclaration other) { }

	// RVA: 0x102977C
	public string get_Encoding() { }

	// RVA: 0x1029784
	public string get_Standalone() { }

	// RVA: 0x102978C
	public string get_Version() { }

	// RVA: 0x1029794
	public override string ToString() { }

}

// Namespace: System.Xml.Linq
public class XDocument
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Methods

	// RVA: 0x1029AB0
	public void .ctor() { }

	// RVA: 0x1029AB8
	public void .ctor(XDocument other) { }

	// RVA: 0x1029B54
	public XDeclaration get_Declaration() { }

	// RVA: 0x1029B5C
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x1029B64
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1029B6C
	public XElement get_Root() { }

	// RVA: 0x1029BC0
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1029D00
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x1029D54
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1029DA8
	internal override XNode CloneNode() { }

	// RVA: 0x315B3A8
	private T GetFirstNode() { }

	// RVA: 0x1029EC4
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x1029F50
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x102A118
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x102A248
	internal override void ValidateString(string s) { }

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

	// RVA: 0x102915C
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x102A310
	public void .ctor(XDocumentType other) { }

	// RVA: 0x102A3C0
	public string get_InternalSubset() { }

	// RVA: 0x102A3C8
	public string get_Name() { }

	// RVA: 0x102A3D0
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x102A3D8
	public string get_PublicId() { }

	// RVA: 0x102A3E0
	public string get_SystemId() { }

	// RVA: 0x102A3E8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x102A464
	internal override XNode CloneNode() { }

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

	// RVA: 0x102B400
	public void .ctor(int <>1__state) { }

	// RVA: 0x102BEBC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x102BEC0
	private bool MoveNext() { }

	// RVA: 0x102BFB0
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	// RVA: 0x102BFB8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x102BFF8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x102C000
	private System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	// RVA: 0x102C0B8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public class XElement
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Methods

	// RVA: 0x1028FC4
	public void .ctor(XName name) { }

	// RVA: 0x102A4C8
	public void .ctor(XElement other) { }

	// RVA: 0x10264A0
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x102A5D0
	public bool get_HasAttributes() { }

	// RVA: 0x102A5E0
	public bool get_IsEmpty() { }

	// RVA: 0x102A5F0
	public XName get_Name() { }

	// RVA: 0x102A5F8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x102A600
	public string get_Value() { }

	// RVA: 0x102A6A0
	public XAttribute Attribute(XName name) { }

	// RVA: 0x102A6E0
	public System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes() { }

	// RVA: 0x1024CCC
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x102A93C
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x102AC34
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x102AC3C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x102AEE0
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x102AEEC
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x102B25C
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x102AFE0
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x1029044
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x102B39C
	internal override XNode CloneNode() { }

	// RVA: 0x102A778
	private System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(XName name) { }

	// RVA: 0x102A820
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x102AE5C
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x102B438
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x1029324
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x102BD7C
	internal override void ValidateNode(XNode node, XNode previous) { }

}

// Namespace: 
public sealed class ExtractKeyDelegate
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x315B3A8
	public virtual string Invoke(TValue value) { }

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

	// RVA: 0x30A2828
	public void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: 0x30A17DC
	public XHashtableState Resize() { }

	// RVA: -1
	public bool TryGetValue(string key, int index, int count, TValue value) { }

	// RVA: 0x315B3A8
	public bool TryAdd(TValue value, TValue newValue) { }

	// RVA: 0x315B3A8
	private bool FindEntry(int hashCode, string key, int index, int count, int entryIndex) { }

	// RVA: 0x30A43EC
	private static int ComputeHashCode(string key, int index, int count) { }

}

// Namespace: System.Xml.Linq
internal sealed class XHashtable<T0>
{
	// Fields
	private XHashtableState _state; // 0x0

	// Methods

	// RVA: 0x30A2828
	public void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: -1
	public bool TryGetValue(string key, int index, int count, TValue value) { }

	// RVA: 0x315B3A8
	public TValue Add(TValue value) { }

}

// Namespace: System.Xml.Linq
internal struct NamespaceCache
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _namespaceName; // 0x18

	// Methods

	// RVA: 0x1028F08
	public XNamespace Get(string namespaceName) { }

}

// Namespace: System.Xml.Linq
internal struct ElementWriter
{
	// Fields
	private XmlWriter _writer; // 0x10
	private NamespaceResolver _resolver; // 0x18

	// Methods

	// RVA: 0x102A9D8
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x102AA04
	public void WriteElement(XElement e) { }

	// RVA: 0x102C668
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x102C0BC
	private void PushAncestors(XElement e) { }

	// RVA: 0x102CA00
	private void PushElement(XElement e) { }

	// RVA: 0x102C4F8
	private void WriteEndElement() { }

	// RVA: 0x102C5B0
	private void WriteFullEndElement() { }

	// RVA: 0x102C38C
	private void WriteStartElement(XElement e) { }

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

	// RVA: 0x102CC90
	public void .ctor() { }

}

// Namespace: System.Xml.Linq
internal struct NamespaceResolver
{
	// Fields
	private int _scope; // 0x10
	private NamespaceDeclaration _declaration; // 0x18
	private NamespaceDeclaration _rover; // 0x20

	// Methods

	// RVA: 0x102CAE4
	public void PushScope() { }

	// RVA: 0x102CBEC
	public void PopScope() { }

	// RVA: 0x102CAF4
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x102C90C
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x102C794
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

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
[Serializable]
public sealed class XName
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _localName; // 0x18
	private int _hashCode; // 0x20

	// Methods

	// RVA: 0x102CC98
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x102CD74
	public string get_LocalName() { }

	// RVA: 0x102CD7C
	public XNamespace get_Namespace() { }

	// RVA: 0x10247C0
	public string get_NamespaceName() { }

	// RVA: 0x102CD84
	public override string ToString() { }

	// RVA: 0x102CE18
	public static XName Get(string expandedName) { }

	// RVA: 0x102D530
	public static XName Get(string localName, string namespaceName) { }

	// RVA: 0x102D560
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0x102D56C
	public override bool Equals(object obj) { }

	// RVA: 0x102D578
	public override int GetHashCode() { }

	// RVA: 0x1024078
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0x102D580
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x102D58C
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x102D5CC
	internal void .ctor() { }

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

	// RVA: 0x102D608
	internal void .ctor(string namespaceName) { }

	// RVA: 0x102D718
	public string get_NamespaceName() { }

	// RVA: 0x1028F58
	public XName GetName(string localName) { }

	// RVA: 0x102D720
	public override string ToString() { }

	// RVA: 0x102D4BC
	public static XNamespace get_None() { }

	// RVA: 0x102D810
	public static XNamespace get_Xml() { }

	// RVA: 0x102D87C
	public static XNamespace get_Xmlns() { }

	// RVA: 0x102BAAC
	public static XNamespace Get(string namespaceName) { }

	// RVA: 0x102D8E8
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0x102D8F4
	public override bool Equals(object obj) { }

	// RVA: 0x102D900
	public override int GetHashCode() { }

	// RVA: 0x102A814
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x102D908
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x102D390
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x102CFC0
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x102D914
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x102D930
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x102D728
	private static XNamespace EnsureNamespace(WeakReference refNmsp, string namespaceName) { }

}

// Namespace: System.Xml.Linq
public abstract class XNode
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x10251C8
	internal void .ctor() { }

	// RVA: 0x102D9B4
	public void Remove() { }

	// RVA: 0x102DA20
	public override string ToString() { }

	// RVA: -1
	public abstract void WriteTo(XmlWriter writer) { }

	// RVA: 0x102DF24
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1
	internal abstract XNode CloneNode() { }

	// RVA: 0x102DB40
	private string GetXmlString(SaveOptions o) { }

}

// Namespace: System.Xml.Linq
public abstract class XObject
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Methods

	// RVA: 0x1024070
	internal void .ctor() { }

	// RVA: 0x1029400
	public string get_BaseUri() { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x102DF28
	public XElement get_Parent() { }

	// RVA: 0x102BB18
	public void AddAnnotation(object annotation) { }

	// RVA: 0x102DFB0
	private object AnnotationForSealedType(Type type) { }

	// RVA: 0x315B3A8
	public T Annotation() { }

	// RVA: 0x102E0F4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x102E154
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x102E1B4
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x10293A0
	internal bool get_HasBaseUri() { }

	// RVA: 0x1026C00
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1026B4C
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x102922C
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x10292A8
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1025BD8
	internal bool SkipNotify() { }

	// RVA: 0x102DA48
	internal SaveOptions GetSaveOptionsFromAnnotations() { }

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

	// RVA: 0x102E214
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x102E284
	private static void .cctor() { }

}

// Namespace: System.Xml.Linq
public class XProcessingInstruction
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Methods

	// RVA: 0x10290B8
	public void .ctor(string target, string data) { }

	// RVA: 0x102E540
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x102E5D0
	public string get_Data() { }

	// RVA: 0x102E5D8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x102E5E0
	public string get_Target() { }

	// RVA: 0x102E5E8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x102E664
	internal override XNode CloneNode() { }

	// RVA: 0x102E45C
	private static void ValidateName(string name) { }

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

	// RVA: 0x1024F5C
	public void .ctor(string value) { }

	// RVA: 0x1024FE0
	public void .ctor(XText other) { }

	// RVA: 0x102E6C8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x102E6D0
	public string get_Value() { }

	// RVA: 0x1026CB4
	public void set_Value(string value) { }

	// RVA: 0x102E6D8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x102E7E0
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x102E808
	internal override XNode CloneNode() { }

}

// Namespace: System.Text
internal static class StringBuilderCache
{
	// Fields
	private static StringBuilder t_cachedInstance; // 0xFFFFFFFF

	// Methods

	// RVA: 0x102990C
	public static StringBuilder Acquire(int capacity) { }

	// RVA: 0x102E86C
	public static void Release(StringBuilder sb) { }

	// RVA: 0x10299F0
	public static string GetStringAndRelease(StringBuilder sb) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0x102E8F0
	public static void ThrowNotSupportedException() { }

}


