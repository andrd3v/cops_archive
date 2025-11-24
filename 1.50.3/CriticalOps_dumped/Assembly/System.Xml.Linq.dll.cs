// Namespace: 
internal class <Module>
{}

// Namespace: 
internal static class SR
{
	// Methods

	// RVA: 0x104C650
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x104C6C4
	internal static string Format(string resourceFormat, object p1, object p2) { }

}

// Namespace: System.Xml.Linq
internal class BaseUriAnnotation
{
	// Fields
	internal string baseUri; // 0x10

	// Methods

	// RVA: 0x104C748
	public void .ctor(string baseUri) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoAnnotation
{
	// Fields
	internal int lineNumber; // 0x10
	internal int linePosition; // 0x14

	// Methods

	// RVA: 0x104C77C
	public void .ctor(int lineNumber, int linePosition) { }

}

// Namespace: System.Xml.Linq
internal class LineInfoEndElementAnnotation
{
	// Methods

	// RVA: 0x104C7B4
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

	// RVA: 0x104C7EC
	public void .ctor(XName name, object value) { }

	// RVA: 0x104CEE4
	public void .ctor(XAttribute other) { }

	// RVA: 0x104CF74
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x104D034
	public XName get_Name() { }

	// RVA: 0x104D03C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x104D044
	public string get_Value() { }

	// RVA: 0x104D04C
	public override string ToString() { }

	// RVA: 0x104D3BC
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x104CCA8
	private static void ValidateAttribute(XName name, string value) { }

}

// Namespace: System.Xml.Linq
public class XCData
{
	// Methods

	// RVA: 0x104D7AC
	public void .ctor(string value) { }

	// RVA: 0x104D830
	public void .ctor(XCData other) { }

	// RVA: 0x104D8B4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x104D8BC
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x104D938
	internal override XNode CloneNode() { }

}

// Namespace: System.Xml.Linq
public class XComment
{
	// Fields
	internal string value; // 0x28

	// Methods

	// RVA: 0x104D99C
	public void .ctor(string value) { }

	// RVA: 0x104DA24
	public void .ctor(XComment other) { }

	// RVA: 0x104DAA4
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x104DAAC
	public string get_Value() { }

	// RVA: 0x104DAB4
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x104DB30
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

	// RVA: 0x104F950
	public void .ctor(XContainer rootContainer) { }

	// RVA: 0x1050298
	public void .ctor(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	// RVA: 0x104F984
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

	// RVA: 0x105036C
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

	// RVA: 0x104EE08
	public void .ctor(int <>1__state) { }

	// RVA: 0x1051CF4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1051CF8
	private bool MoveNext() { }

	// RVA: 0x1051DC4
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	// RVA: 0x1051DCC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1051E0C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1051E14
	private System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	// RVA: 0x1051EC8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public abstract class XContainer
{
	// Fields
	internal object content; // 0x28

	// Methods

	// RVA: 0x104DB94
	internal void .ctor() { }

	// RVA: 0x104DB9C
	internal void .ctor(XContainer other) { }

	// RVA: 0x104DDE8
	public XNode get_LastNode() { }

	// RVA: 0x104DF6C
	public void Add(object content) { }

	// RVA: 0x104ED80
	public System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode> Nodes() { }

	// RVA: 0x104EE40
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x104EE44
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x104E4AC
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x104E8F4
	internal void AddNode(XNode n) { }

	// RVA: 0x104EE48
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x104E978
	internal void AddString(string s) { }

	// RVA: 0x104EECC
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x104F168
	internal void AppendNode(XNode n) { }

	// RVA: 0x104DCF0
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x104F74C
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x104F070
	internal void ConvertTextToNode() { }

	// RVA: 0x104C8D8
	internal static string GetStringValue(object value) { }

	// RVA: 0x104F844
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x105016C
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1051300
	internal void RemoveNode(XNode n) { }

	// RVA: 0x10515F8
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x10515FC
	internal virtual void ValidateString(string s) { }

	// RVA: 0x1051600
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

	// RVA: 0x1051ECC
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x1051F30
	public void .ctor(XDeclaration other) { }

	// RVA: 0x1051FD0
	public string get_Encoding() { }

	// RVA: 0x1051FD8
	public string get_Standalone() { }

	// RVA: 0x1051FE0
	public string get_Version() { }

	// RVA: 0x1051FE8
	public override string ToString() { }

}

// Namespace: System.Xml.Linq
public class XDocument
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Methods

	// RVA: 0x1052304
	public void .ctor() { }

	// RVA: 0x105230C
	public void .ctor(XDocument other) { }

	// RVA: 0x10523A8
	public XDeclaration get_Declaration() { }

	// RVA: 0x10523B0
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x10523B8
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x10523C0
	public XElement get_Root() { }

	// RVA: 0x1052414
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1052554
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x10525A8
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x10525FC
	internal override XNode CloneNode() { }

	// RVA: 0x318DB98
	private T GetFirstNode() { }

	// RVA: 0x1052718
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x10527A4
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x105296C
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x1052A9C
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

	// RVA: 0x10519B0
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1052B64
	public void .ctor(XDocumentType other) { }

	// RVA: 0x1052C14
	public string get_InternalSubset() { }

	// RVA: 0x1052C1C
	public string get_Name() { }

	// RVA: 0x1052C24
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1052C2C
	public string get_PublicId() { }

	// RVA: 0x1052C34
	public string get_SystemId() { }

	// RVA: 0x1052C3C
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1052CB8
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

	// RVA: 0x1053C54
	public void .ctor(int <>1__state) { }

	// RVA: 0x1054710
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1054714
	private bool MoveNext() { }

	// RVA: 0x1054804
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	// RVA: 0x105480C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x105484C
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1054854
	private System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	// RVA: 0x105490C
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: System.Xml.Linq
public class XElement
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Methods

	// RVA: 0x1051818
	public void .ctor(XName name) { }

	// RVA: 0x1052D1C
	public void .ctor(XElement other) { }

	// RVA: 0x104ECF4
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x1052E24
	public bool get_HasAttributes() { }

	// RVA: 0x1052E34
	public bool get_IsEmpty() { }

	// RVA: 0x1052E44
	public XName get_Name() { }

	// RVA: 0x1052E4C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1052E54
	public string get_Value() { }

	// RVA: 0x1052EF4
	public XAttribute Attribute(XName name) { }

	// RVA: 0x1052F34
	public System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> Attributes() { }

	// RVA: 0x104D520
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1053190
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1053488
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1053490
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1053734
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1053740
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x1053AB0
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1053834
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x1051898
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1053BF0
	internal override XNode CloneNode() { }

	// RVA: 0x1052FCC
	private System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute> GetAttributes(XName name) { }

	// RVA: 0x1053074
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x10536B0
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1053C8C
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x1051B78
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x10545D0
	internal override void ValidateNode(XNode node, XNode previous) { }

}

// Namespace: 
public sealed class ExtractKeyDelegate
{
	// Methods

	// RVA: -1
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x318DB98
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

	// RVA: 0x30D4D3C
	public void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: 0x30D3CF0
	public XHashtableState Resize() { }

	// RVA: -1
	public bool TryGetValue(string key, int index, int count, TValue value) { }

	// RVA: 0x318DB98
	public bool TryAdd(TValue value, TValue newValue) { }

	// RVA: 0x318DB98
	private bool FindEntry(int hashCode, string key, int index, int count, int entryIndex) { }

	// RVA: 0x30D6900
	private static int ComputeHashCode(string key, int index, int count) { }

}

// Namespace: System.Xml.Linq
internal sealed class XHashtable<T0>
{
	// Fields
	private XHashtableState _state; // 0x0

	// Methods

	// RVA: 0x30D4D3C
	public void .ctor(ExtractKeyDelegate extractKey, int capacity) { }

	// RVA: -1
	public bool TryGetValue(string key, int index, int count, TValue value) { }

	// RVA: 0x318DB98
	public TValue Add(TValue value) { }

}

// Namespace: System.Xml.Linq
internal struct NamespaceCache
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _namespaceName; // 0x18

	// Methods

	// RVA: 0x105175C
	public XNamespace Get(string namespaceName) { }

}

// Namespace: System.Xml.Linq
internal struct ElementWriter
{
	// Fields
	private XmlWriter _writer; // 0x10
	private NamespaceResolver _resolver; // 0x18

	// Methods

	// RVA: 0x105322C
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1053258
	public void WriteElement(XElement e) { }

	// RVA: 0x1054EBC
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x1054910
	private void PushAncestors(XElement e) { }

	// RVA: 0x1055254
	private void PushElement(XElement e) { }

	// RVA: 0x1054D4C
	private void WriteEndElement() { }

	// RVA: 0x1054E04
	private void WriteFullEndElement() { }

	// RVA: 0x1054BE0
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

	// RVA: 0x10554E4
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

	// RVA: 0x1055338
	public void PushScope() { }

	// RVA: 0x1055440
	public void PopScope() { }

	// RVA: 0x1055348
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x1055160
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x1054FE8
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

	// RVA: 0x10554EC
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x10555C8
	public string get_LocalName() { }

	// RVA: 0x10555D0
	public XNamespace get_Namespace() { }

	// RVA: 0x104D014
	public string get_NamespaceName() { }

	// RVA: 0x10555D8
	public override string ToString() { }

	// RVA: 0x105566C
	public static XName Get(string expandedName) { }

	// RVA: 0x1055D84
	public static XName Get(string localName, string namespaceName) { }

	// RVA: 0x1055DB4
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0x1055DC0
	public override bool Equals(object obj) { }

	// RVA: 0x1055DCC
	public override int GetHashCode() { }

	// RVA: 0x104C8CC
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0x1055DD4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x1055DE0
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1055E20
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

	// RVA: 0x1055E5C
	internal void .ctor(string namespaceName) { }

	// RVA: 0x1055F6C
	public string get_NamespaceName() { }

	// RVA: 0x10517AC
	public XName GetName(string localName) { }

	// RVA: 0x1055F74
	public override string ToString() { }

	// RVA: 0x1055D10
	public static XNamespace get_None() { }

	// RVA: 0x1056064
	public static XNamespace get_Xml() { }

	// RVA: 0x10560D0
	public static XNamespace get_Xmlns() { }

	// RVA: 0x1054300
	public static XNamespace Get(string namespaceName) { }

	// RVA: 0x105613C
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0x1056148
	public override bool Equals(object obj) { }

	// RVA: 0x1056154
	public override int GetHashCode() { }

	// RVA: 0x1053068
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x105615C
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x1055BE4
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x1055814
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x1056168
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x1056184
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x1055F7C
	private static XNamespace EnsureNamespace(WeakReference refNmsp, string namespaceName) { }

}

// Namespace: System.Xml.Linq
public abstract class XNode
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x104DA1C
	internal void .ctor() { }

	// RVA: 0x1056208
	public void Remove() { }

	// RVA: 0x1056274
	public override string ToString() { }

	// RVA: -1
	public abstract void WriteTo(XmlWriter writer) { }

	// RVA: 0x1056778
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1
	internal abstract XNode CloneNode() { }

	// RVA: 0x1056394
	private string GetXmlString(SaveOptions o) { }

}

// Namespace: System.Xml.Linq
public abstract class XObject
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Methods

	// RVA: 0x104C8C4
	internal void .ctor() { }

	// RVA: 0x1051C54
	public string get_BaseUri() { }

	// RVA: -1
	public abstract XmlNodeType get_NodeType() { }

	// RVA: 0x105677C
	public XElement get_Parent() { }

	// RVA: 0x105436C
	public void AddAnnotation(object annotation) { }

	// RVA: 0x1056804
	private object AnnotationForSealedType(Type type) { }

	// RVA: 0x318DB98
	public T Annotation() { }

	// RVA: 0x1056948
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x10569A8
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1056A08
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1051BF4
	internal bool get_HasBaseUri() { }

	// RVA: 0x104F454
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x104F3A0
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1051A80
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x1051AFC
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x104E42C
	internal bool SkipNotify() { }

	// RVA: 0x105629C
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

	// RVA: 0x1056A68
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x1056AD8
	private static void .cctor() { }

}

// Namespace: System.Xml.Linq
public class XProcessingInstruction
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Methods

	// RVA: 0x105190C
	public void .ctor(string target, string data) { }

	// RVA: 0x1056D94
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x1056E24
	public string get_Data() { }

	// RVA: 0x1056E2C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1056E34
	public string get_Target() { }

	// RVA: 0x1056E3C
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1056EB8
	internal override XNode CloneNode() { }

	// RVA: 0x1056CB0
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

	// RVA: 0x104D7B0
	public void .ctor(string value) { }

	// RVA: 0x104D834
	public void .ctor(XText other) { }

	// RVA: 0x1056F1C
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1056F24
	public string get_Value() { }

	// RVA: 0x104F508
	public void set_Value(string value) { }

	// RVA: 0x1056F2C
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1057034
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x105705C
	internal override XNode CloneNode() { }

}

// Namespace: System.Text
internal static class StringBuilderCache
{
	// Fields
	private static StringBuilder t_cachedInstance; // 0xFFFFFFFF

	// Methods

	// RVA: 0x1052160
	public static StringBuilder Acquire(int capacity) { }

	// RVA: 0x10570C0
	public static void Release(StringBuilder sb) { }

	// RVA: 0x1052244
	public static string GetStringAndRelease(StringBuilder sb) { }

}

// Namespace: Unity
internal sealed class ThrowStub
{
	// Methods

	// RVA: 0x1057144
	public static void ThrowNotSupportedException() { }

}


