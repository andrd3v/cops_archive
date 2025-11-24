// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x103312C
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x10331A0
	internal static string Format(string resourceFormat, object p1, object p2) { }

}

// Namespace: System.Xml.Linq
internal class BaseUriAnnotation
{
	// Fields
	internal string baseUri; // 0x10

	// Methods

	// RVA: 0x1033224
	public void .ctor(string baseUri) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoAnnotation
{
	// Fields
	internal int lineNumber; // 0x10
	internal int linePosition; // 0x14

	// Methods

	// RVA: 0x1033258
	public void .ctor(int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoEndElementAnnotation
{
	// Methods

	// RVA: 0x1033290
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

	// RVA: 0x10332C8
	public void .ctor(XName name, object value) { }

	// RVA: 0x10339C0
	public void .ctor(XAttribute other) { }

	// RVA: 0x1033A50
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x1033B10
	public XName get_Name() { }

	// RVA: 0x1033B18
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1033B20
	public string get_Value() { }

	// RVA: 0x1033B28
	public override string ToString() { }

	// RVA: 0x1033E98
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1033784
	private static void ValidateAttribute(XName name, string value) { }

}

// Namespace: System.Xml.Linq
public class XCData
{
	// Methods

	// RVA: 0x1034288
	public void .ctor(string value) { }

	// RVA: 0x103430C
	public void .ctor(XCData other) { }

	// RVA: 0x1034390
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1034398
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1034414
	internal override XNode CloneNode() { }

}

// Namespace: System.Xml.Linq
public class XComment
{
	// Fields
	internal string value; // 0x28

	// Methods

	// RVA: 0x1034478
	public void .ctor(string value) { }

	// RVA: 0x1034500
	public void .ctor(XComment other) { }

	// RVA: 0x1034580
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1034588
	public string get_Value() { }

	// RVA: 0x1034590
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x103460C
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

	// RVA: 0x103642C
	public void .ctor(XContainer rootContainer) { }

	// RVA: 0x1036D74
	public void .ctor(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	// RVA: 0x1036460
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

	// RVA: 0x1036E48
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

	// RVA: 0x10358E4
	public void .ctor(int <>1__state) { }

	// RVA: 0x10387D0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x10387D4
	private bool MoveNext() { }

	// RVA: 0x10388A0
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	// RVA: 0x10388A8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x10388E8
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x10388F0
	private System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	// RVA: 0x10389A4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public abstract class XContainer
{
	// Fields
	internal object content; // 0x28

	// Methods

	// RVA: 0x1034670
	internal void .ctor() { }

	// RVA: 0x1034678
	internal void .ctor(XContainer other) { }

	// RVA: 0x10348C4
	public XNode get_LastNode() { }

	// RVA: 0x1034A48
	public void Add(object content) { }

	// RVA: 0x103585C
	public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes() { }

	// RVA: 0x103591C
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x1035920
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1034F88
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x10353D0
	internal void AddNode(XNode n) { }

	// RVA: 0x1035924
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x1035454
	internal void AddString(string s) { }

	// RVA: 0x10359A8
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x1035C44
	internal void AppendNode(XNode n) { }

	// RVA: 0x10347CC
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x1036228
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x1035B4C
	internal void ConvertTextToNode() { }

	// RVA: 0x10333B4
	internal static string GetStringValue(object value) { }

	// RVA: 0x1036320
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x1036C48
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1037DDC
	internal void RemoveNode(XNode n) { }

	// RVA: 0x10380D4
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x10380D8
	internal virtual void ValidateString(string s) { }

	// RVA: 0x10380DC
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

	// RVA: 0x10389A8
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x1038A0C
	public void .ctor(XDeclaration other) { }

	// RVA: 0x1038AAC
	public string get_Encoding() { }

	// RVA: 0x1038AB4
	public string get_Standalone() { }

	// RVA: 0x1038ABC
	public string get_Version() { }

	// RVA: 0x1038AC4
	public override string ToString() { }

}

// Namespace: System.Xml.Linq
public class XDocument
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Methods

	// RVA: 0x1038DE0
	public void .ctor() { }

	// RVA: 0x1038DE8
	public void .ctor(XDocument other) { }

	// RVA: 0x1038E84
	public XDeclaration get_Declaration() { }

	// RVA: 0x1038E8C
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x1038E94
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1038E9C
	public XElement get_Root() { }

	// RVA: 0x1038EF0
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1039030
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x1039084
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x10390D8
	internal override XNode CloneNode() { }

	// RVA: 0x316B894
	private T GetFirstNode() { }

	// RVA: 0x10391F4
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x1039280
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x1039448
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x1039578
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

	// RVA: 0x103848C
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1039640
	public void .ctor(XDocumentType other) { }

	// RVA: 0x10396F0
	public string get_InternalSubset() { }

	// RVA: 0x10396F8
	public string get_Name() { }

	// RVA: 0x1039700
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1039708
	public string get_PublicId() { }

	// RVA: 0x1039710
	public string get_SystemId() { }

	// RVA: 0x1039718
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1039794
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

	// RVA: 0x103A730
	public void .ctor(int <>1__state) { }

	// RVA: 0x103B1EC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x103B1F0
	private bool MoveNext() { }

	// RVA: 0x103B2E0
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	// RVA: 0x103B2E8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x103B328
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x103B330
	private System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	// RVA: 0x103B3E8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public class XElement
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Methods

	// RVA: 0x10382F4
	public void .ctor(XName name) { }

	// RVA: 0x10397F8
	public void .ctor(XElement other) { }

	// RVA: 0x10357D0
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x1039900
	public bool get_HasAttributes() { }

	// RVA: 0x1039910
	public bool get_IsEmpty() { }

	// RVA: 0x1039920
	public XName get_Name() { }

	// RVA: 0x1039928
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1039930
	public string get_Value() { }

	// RVA: 0x10399D0
	public XAttribute Attribute(XName name) { }

	// RVA: 0x1039A10
	public System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes() { }

	// RVA: 0x1033FFC
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1039C6C
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1039F64
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1039F6C
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x103A210
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x103A21C
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x103A58C
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x103A310
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x1038374
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x103A6CC
	internal override XNode CloneNode() { }

	// RVA: 0x1039AA8
	private System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(XName name) { }

	// RVA: 0x1039B50
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x103A18C
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x103A768
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x1038654
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x103B0AC
	internal override void ValidateNode(XNode node, XNode previous) { }

}

// Namespace: 
public sealed class ExtractKeyDelegate
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x316B894
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

	// RVA: 0x30B2D20
	public void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: 0x30B1CD4
	public XHashtableState Resize() { }

	// RVA: -1
	public bool TryGetValue(string key, int index, int count, TValue value) { }

	// RVA: 0x316B894
	public bool TryAdd(TValue value, TValue newValue) { }

	// RVA: 0x316B894
	private bool FindEntry(int hashCode, string key, int index, int count, int entryIndex) { }

	// RVA: 0x30B48E4
	private static int ComputeHashCode(string key, int index, int count) { }

}

// Namespace: System.Xml.Linq
internal sealed class XHashtable<T0>
{
	// Fields
	private XHashtableState _state; // 0x0

	// Methods

	// RVA: 0x30B2D20
	public void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: -1
	public bool TryGetValue(string key, int index, int count, TValue value) { }

	// RVA: 0x316B894
	public TValue Add(TValue value) { }

}

// Namespace: System.Xml.Linq
internal struct NamespaceCache
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _namespaceName; // 0x18

	// Methods

	// RVA: 0x1038238
	public XNamespace Get(string namespaceName) { }

}

// Namespace: System.Xml.Linq
internal struct ElementWriter
{
	// Fields
	private XmlWriter _writer; // 0x10
	private NamespaceResolver _resolver; // 0x18

	// Methods

	// RVA: 0x1039D08
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1039D34
	public void WriteElement(XElement e) { }

	// RVA: 0x103B998
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x103B3EC
	private void PushAncestors(XElement e) { }

	// RVA: 0x103BD30
	private void PushElement(XElement e) { }

	// RVA: 0x103B828
	private void WriteEndElement() { }

	// RVA: 0x103B8E0
	private void WriteFullEndElement() { }

	// RVA: 0x103B6BC
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

	// RVA: 0x103BFC0
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

	// RVA: 0x103BE14
	public void PushScope() { }

	// RVA: 0x103BF1C
	public void PopScope() { }

	// RVA: 0x103BE24
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x103BC3C
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x103BAC4
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

	// RVA: 0x103BFC8
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x103C0A4
	public string get_LocalName() { }

	// RVA: 0x103C0AC
	public XNamespace get_Namespace() { }

	// RVA: 0x1033AF0
	public string get_NamespaceName() { }

	// RVA: 0x103C0B4
	public override string ToString() { }

	// RVA: 0x103C148
	public static XName Get(string expandedName) { }

	// RVA: 0x103C860
	public static XName Get(string localName, string namespaceName) { }

	// RVA: 0x103C890
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0x103C89C
	public override bool Equals(object obj) { }

	// RVA: 0x103C8A8
	public override int GetHashCode() { }

	// RVA: 0x10333A8
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0x103C8B0
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x103C8BC
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x103C8FC
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

	// RVA: 0x103C938
	internal void .ctor(string namespaceName) { }

	// RVA: 0x103CA48
	public string get_NamespaceName() { }

	// RVA: 0x1038288
	public XName GetName(string localName) { }

	// RVA: 0x103CA50
	public override string ToString() { }

	// RVA: 0x103C7EC
	public static XNamespace get_None() { }

	// RVA: 0x103CB40
	public static XNamespace get_Xml() { }

	// RVA: 0x103CBAC
	public static XNamespace get_Xmlns() { }

	// RVA: 0x103ADDC
	public static XNamespace Get(string namespaceName) { }

	// RVA: 0x103CC18
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0x103CC24
	public override bool Equals(object obj) { }

	// RVA: 0x103CC30
	public override int GetHashCode() { }

	// RVA: 0x1039B44
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x103CC38
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x103C6C0
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x103C2F0
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x103CC44
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x103CC60
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x103CA58
	private static XNamespace EnsureNamespace(WeakReference refNmsp, string namespaceName) { }

}

// Namespace: System.Xml.Linq
public abstract class XNode
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x10344F8
	internal void .ctor() { }

	// RVA: 0x103CCE4
	public void Remove() { }

	// RVA: 0x103CD50
	public override string ToString() { }

	// RVA: -1
	public abstract void WriteTo(XmlWriter writer) { }

	// RVA: 0x103D254
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1
	internal abstract XNode CloneNode() { }

	// RVA: 0x103CE70
	private string GetXmlString(SaveOptions o) { }

}

// Namespace: System.Xml.Linq
public abstract class XObject
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Methods

	// RVA: 0x10333A0
	internal void .ctor() { }

	// RVA: 0x1038730
	public string get_BaseUri() { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x103D258
	public XElement get_Parent() { }

	// RVA: 0x103AE48
	public void AddAnnotation(object annotation) { }

	// RVA: 0x103D2E0
	private object AnnotationForSealedType(Type type) { }

	// RVA: 0x316B894
	public T Annotation() { }

	// RVA: 0x103D424
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x103D484
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x103D4E4
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x10386D0
	internal bool get_HasBaseUri() { }

	// RVA: 0x1035F30
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1035E7C
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x103855C
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x10385D8
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1034F08
	internal bool SkipNotify() { }

	// RVA: 0x103CD78
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

	// RVA: 0x103D544
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x103D5B4
	private static void .cctor() { }

}

// Namespace: System.Xml.Linq
public class XProcessingInstruction
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Methods

	// RVA: 0x10383E8
	public void .ctor(string target, string data) { }

	// RVA: 0x103D870
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x103D900
	public string get_Data() { }

	// RVA: 0x103D908
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x103D910
	public string get_Target() { }

	// RVA: 0x103D918
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x103D994
	internal override XNode CloneNode() { }

	// RVA: 0x103D78C
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

	// RVA: 0x103428C
	public void .ctor(string value) { }

	// RVA: 0x1034310
	public void .ctor(XText other) { }

	// RVA: 0x103D9F8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x103DA00
	public string get_Value() { }

	// RVA: 0x1035FE4
	public void set_Value(string value) { }

	// RVA: 0x103DA08
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x103DB10
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x103DB38
	internal override XNode CloneNode() { }

}

// Namespace: System.Text
internal static class StringBuilderCache
{
	// Fields
	private static StringBuilder t_cachedInstance; // 0xFFFFFFFF

	// Methods

	// RVA: 0x1038C3C
	public static StringBuilder Acquire(int capacity) { }

	// RVA: 0x103DB9C
	public static void Release(StringBuilder sb) { }

	// RVA: 0x1038D20
	public static string GetStringAndRelease(StringBuilder sb) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0x103DC20
	public static void ThrowNotSupportedException() { }

}


