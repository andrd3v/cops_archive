// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x108593C
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x10859B0
	internal static string Format(string resourceFormat, object p1, object p2) { }

}

// Namespace: System.Xml.Linq
internal class BaseUriAnnotation
{
	// Fields
	internal string baseUri; // 0x10

	// Methods

	// RVA: 0x1085A34
	public void .ctor(string baseUri) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoAnnotation
{
	// Fields
	internal int lineNumber; // 0x10
	internal int linePosition; // 0x14

	// Methods

	// RVA: 0x1085A68
	public void .ctor(int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoEndElementAnnotation
{
	// Methods

	// RVA: 0x1085AA0
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

	// RVA: 0x1085AD8
	public void .ctor(XName name, object value) { }

	// RVA: 0x1086190
	public void .ctor(XAttribute other) { }

	// RVA: 0x1086220
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x10862E0
	public XName get_Name() { }

	// RVA: 0x10862E8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x10862F0
	public string get_Value() { }

	// RVA: 0x10862F8
	public override string ToString() { }

	// RVA: 0x1086668
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1085F54
	private static void ValidateAttribute(XName name, string value) { }

}

// Namespace: System.Xml.Linq
public class XCData
{
	// Methods

	// RVA: 0x1086A4C
	public void .ctor(string value) { }

	// RVA: 0x1086AD0
	public void .ctor(XCData other) { }

	// RVA: 0x1086B54
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1086B5C
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1086BD8
	internal override XNode CloneNode() { }

}

// Namespace: System.Xml.Linq
public class XComment
{
	// Fields
	internal string value; // 0x28

	// Methods

	// RVA: 0x1086C3C
	public void .ctor(string value) { }

	// RVA: 0x1086CC4
	public void .ctor(XComment other) { }

	// RVA: 0x1086D44
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1086D4C
	public string get_Value() { }

	// RVA: 0x1086D54
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1086DD0
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

	// RVA: 0x1088B90
	public void .ctor(XContainer rootContainer) { }

	// RVA: 0x10894CC
	public void .ctor(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	// RVA: 0x1088BC4
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

	// RVA: 0x10895A0
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

	// RVA: 0x108806C
	public void .ctor(int <>1__state) { }

	// RVA: 0x108AF04
	private void System.IDisposable.Dispose() { }

	// RVA: 0x108AF08
	private bool MoveNext() { }

	// RVA: 0x108AFD4
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	// RVA: 0x108AFDC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x108B01C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x108B024
	private System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	// RVA: 0x108B0D8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public abstract class XContainer
{
	// Fields
	internal object content; // 0x28

	// Methods

	// RVA: 0x1086E34
	internal void .ctor() { }

	// RVA: 0x1086E3C
	internal void .ctor(XContainer other) { }

	// RVA: 0x1087070
	public XNode get_LastNode() { }

	// RVA: 0x10871E8
	public void Add(object content) { }

	// RVA: 0x1087FE4
	public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes() { }

	// RVA: 0x10880A4
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x10880A8
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x108771C
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x1087B58
	internal void AddNode(XNode n) { }

	// RVA: 0x10880AC
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x1087BDC
	internal void AddString(string s) { }

	// RVA: 0x1088130
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x10883B4
	internal void AppendNode(XNode n) { }

	// RVA: 0x1086F84
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x1088998
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x10882C8
	internal void ConvertTextToNode() { }

	// RVA: 0x1085BC4
	internal static string GetStringValue(object value) { }

	// RVA: 0x1088A84
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x10893A0
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x108A528
	internal void RemoveNode(XNode n) { }

	// RVA: 0x108A820
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x108A824
	internal virtual void ValidateString(string s) { }

	// RVA: 0x108A828
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

	// RVA: 0x108B0DC
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x108B140
	public void .ctor(XDeclaration other) { }

	// RVA: 0x108B1E0
	public string get_Encoding() { }

	// RVA: 0x108B1E8
	public string get_Standalone() { }

	// RVA: 0x108B1F0
	public string get_Version() { }

	// RVA: 0x108B1F8
	public override string ToString() { }

}

// Namespace: System.Xml.Linq
public class XDocument
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Methods

	// RVA: 0x108B514
	public void .ctor() { }

	// RVA: 0x108B51C
	public void .ctor(XDocument other) { }

	// RVA: 0x108B5B8
	public XDeclaration get_Declaration() { }

	// RVA: 0x108B5C0
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x108B5C8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x108B5D0
	public XElement get_Root() { }

	// RVA: 0x108B624
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x108B764
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x108B7B8
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x108B80C
	internal override XNode CloneNode() { }

	// RVA: 0x26AD93C
	private T GetFirstNode() { }

	// RVA: 0x108B928
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x108B9B4
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x108BB7C
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x108BCAC
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

	// RVA: 0x108ABCC
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x108BD74
	public void .ctor(XDocumentType other) { }

	// RVA: 0x108BE24
	public string get_InternalSubset() { }

	// RVA: 0x108BE2C
	public string get_Name() { }

	// RVA: 0x108BE34
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x108BE3C
	public string get_PublicId() { }

	// RVA: 0x108BE44
	public string get_SystemId() { }

	// RVA: 0x108BE4C
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x108BEC8
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

	// RVA: 0x108CE2C
	public void .ctor(int <>1__state) { }

	// RVA: 0x108D8DC
	private void System.IDisposable.Dispose() { }

	// RVA: 0x108D8E0
	private bool MoveNext() { }

	// RVA: 0x108D9D0
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	// RVA: 0x108D9D8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x108DA18
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x108DA20
	private System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	// RVA: 0x108DAD8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public class XElement
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Methods

	// RVA: 0x108AA34
	public void .ctor(XName name) { }

	// RVA: 0x108BF2C
	public void .ctor(XElement other) { }

	// RVA: 0x1087F58
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x108C034
	public bool get_HasAttributes() { }

	// RVA: 0x108C044
	public bool get_IsEmpty() { }

	// RVA: 0x108C054
	public XName get_Name() { }

	// RVA: 0x108C05C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x108C064
	public string get_Value() { }

	// RVA: 0x108C0D8
	public XAttribute Attribute(XName name) { }

	// RVA: 0x108C118
	public System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes() { }

	// RVA: 0x10867C0
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x108C374
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x108C660
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x108C668
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x108C90C
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x108C918
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x108CC88
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x108CA0C
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x108AAB4
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x108CDC8
	internal override XNode CloneNode() { }

	// RVA: 0x108C1B0
	private System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(XName name) { }

	// RVA: 0x108C258
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x108C888
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x108CE64
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x108AD94
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x108D79C
	internal override void ValidateNode(XNode node, XNode previous) { }

}

// Namespace: 
public sealed class ExtractKeyDelegate
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26AD93C
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

	// RVA: 0x3526850
	public void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: 0x3525804
	public XHashtableState Resize() { }

	// RVA: -1
	public bool TryGetValue(string key, int index, int count, TValue value) { }

	// RVA: 0x26AD93C
	public bool TryAdd(TValue value, TValue newValue) { }

	// RVA: 0x26AD93C
	private bool FindEntry(int hashCode, string key, int index, int count, int entryIndex) { }

	// RVA: 0x3528514
	private static int ComputeHashCode(string key, int index, int count) { }

}

// Namespace: System.Xml.Linq
internal sealed class XHashtable<T0>
{
	// Fields
	private XHashtableState _state; // 0x0

	// Methods

	// RVA: 0x3526850
	public void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: -1
	public bool TryGetValue(string key, int index, int count, TValue value) { }

	// RVA: 0x26AD93C
	public TValue Add(TValue value) { }

}

// Namespace: System.Xml.Linq
internal struct NamespaceCache
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _namespaceName; // 0x18

	// Methods

	// RVA: 0x108A978
	public XNamespace Get(string namespaceName) { }

}

// Namespace: System.Xml.Linq
internal struct ElementWriter
{
	// Fields
	private XmlWriter _writer; // 0x10
	private NamespaceResolver _resolver; // 0x18

	// Methods

	// RVA: 0x108C410
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x108C43C
	public void WriteElement(XElement e) { }

	// RVA: 0x108E07C
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x108DADC
	private void PushAncestors(XElement e) { }

	// RVA: 0x108E408
	private void PushElement(XElement e) { }

	// RVA: 0x108DF0C
	private void WriteEndElement() { }

	// RVA: 0x108DFC4
	private void WriteFullEndElement() { }

	// RVA: 0x108DDA0
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

	// RVA: 0x108E678
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

	// RVA: 0x108E4CC
	public void PushScope() { }

	// RVA: 0x108E5D4
	public void PopScope() { }

	// RVA: 0x108E4DC
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x108E314
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x108E19C
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

	// RVA: 0x108E680
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x108E75C
	public string get_LocalName() { }

	// RVA: 0x108E764
	public XNamespace get_Namespace() { }

	// RVA: 0x10862C0
	public string get_NamespaceName() { }

	// RVA: 0x108E76C
	public override string ToString() { }

	// RVA: 0x108E800
	public static XName Get(string expandedName) { }

	// RVA: 0x108EEEC
	public static XName Get(string localName, string namespaceName) { }

	// RVA: 0x108EF1C
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0x108EF28
	public override bool Equals(object obj) { }

	// RVA: 0x108EF34
	public override int GetHashCode() { }

	// RVA: 0x1085BB8
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0x108EF3C
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x108EF48
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x108EF88
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

	// RVA: 0x108EFC4
	internal void .ctor(string namespaceName) { }

	// RVA: 0x108F0D4
	public string get_NamespaceName() { }

	// RVA: 0x108A9C8
	public XName GetName(string localName) { }

	// RVA: 0x108F0DC
	public override string ToString() { }

	// RVA: 0x108EE8C
	public static XNamespace get_None() { }

	// RVA: 0x108F1CC
	public static XNamespace get_Xml() { }

	// RVA: 0x108F238
	public static XNamespace get_Xmlns() { }

	// RVA: 0x108D4CC
	public static XNamespace Get(string namespaceName) { }

	// RVA: 0x108F2A4
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0x108F2B0
	public override bool Equals(object obj) { }

	// RVA: 0x108F2BC
	public override int GetHashCode() { }

	// RVA: 0x108C24C
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x108F2C4
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x108ED60
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x108E99C
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x108F2D0
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x108F2EC
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x108F0E4
	private static XNamespace EnsureNamespace(WeakReference refNmsp, string namespaceName) { }

}

// Namespace: System.Xml.Linq
public abstract class XNode
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x1086CBC
	internal void .ctor() { }

	// RVA: 0x108F370
	public void Remove() { }

	// RVA: 0x108F3DC
	public override string ToString() { }

	// RVA: -1
	public abstract void WriteTo(XmlWriter writer) { }

	// RVA: 0x108F8D4
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1
	internal abstract XNode CloneNode() { }

	// RVA: 0x108F4F0
	private string GetXmlString(SaveOptions o) { }

}

// Namespace: System.Xml.Linq
public abstract class XObject
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Methods

	// RVA: 0x1085BB0
	internal void .ctor() { }

	// RVA: 0x108AE70
	public string get_BaseUri() { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x108F8D8
	public XElement get_Parent() { }

	// RVA: 0x108D538
	public void AddAnnotation(object annotation) { }

	// RVA: 0x108F960
	private object AnnotationForSealedType(Type type) { }

	// RVA: 0x26AD93C
	public T Annotation() { }

	// RVA: 0x108FA98
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x108FAF8
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x108FB58
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x108AE10
	internal bool get_HasBaseUri() { }

	// RVA: 0x10886A0
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x10885EC
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x108AC9C
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x108AD18
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x108769C
	internal bool SkipNotify() { }

	// RVA: 0x108F404
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

	// RVA: 0x108FBB8
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x108FC28
	private static void .cctor() { }

}

// Namespace: System.Xml.Linq
public class XProcessingInstruction
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Methods

	// RVA: 0x108AB28
	public void .ctor(string target, string data) { }

	// RVA: 0x108FEE4
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x108FF74
	public string get_Data() { }

	// RVA: 0x108FF7C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x108FF84
	public string get_Target() { }

	// RVA: 0x108FF8C
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1090008
	internal override XNode CloneNode() { }

	// RVA: 0x108FE00
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

	// RVA: 0x1086A50
	public void .ctor(string value) { }

	// RVA: 0x1086AD4
	public void .ctor(XText other) { }

	// RVA: 0x109006C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1090074
	public string get_Value() { }

	// RVA: 0x1088754
	public void set_Value(string value) { }

	// RVA: 0x109007C
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1090184
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x10901AC
	internal override XNode CloneNode() { }

}

// Namespace: System.Text
internal static class StringBuilderCache
{
	// Fields
	private static StringBuilder t_cachedInstance; // 0xFFFFFFFF

	// Methods

	// RVA: 0x108B370
	public static StringBuilder Acquire(int capacity) { }

	// RVA: 0x1090210
	public static void Release(StringBuilder sb) { }

	// RVA: 0x108B454
	public static string GetStringAndRelease(StringBuilder sb) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0x1090294
	public static void ThrowNotSupportedException() { }

}


