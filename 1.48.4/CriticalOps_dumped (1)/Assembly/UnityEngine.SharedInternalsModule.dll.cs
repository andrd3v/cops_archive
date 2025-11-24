// Namespace: 
internal class <Module> 
{}

// Namespace: UnityEngine
internal sealed class AssetFileNameExtensionAttribute 
{
	// Fields
	private readonly string <preferredExtension>k__BackingField; // 0x10
	private readonly System.Collections.Generic.IEnumerable<System.String> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15C5B9C
	void .ctor(string preferredExtension, string[] otherExtensions) { }

}

// Namespace: UnityEngine
internal class ThreadAndSerializationSafeAttribute 
{
	// Methods

	// RVA: 0x15C5BEC
	void .ctor() { }

}

// Namespace: UnityEngine
internal class WritableAttribute 
{
	// Methods

	// RVA: 0x15C5BF4
	void .ctor() { }

}

// Namespace: UnityEngine
internal class UnityEngineModuleAssembly 
{
	// Methods

	// RVA: 0x15C5BFC
	void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NativeClassAttribute 
{
	// Fields
	private string <QualifiedNativeName>k__BackingField; // 0x10
	private string <Declaration>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15C5C04
	void set_QualifiedNativeName(string value) { }

	// RVA: 0x15C5C0C
	void set_Declaration(string value) { }

	// RVA: 0x15C5C14
	void .ctor(string qualifiedCppName) { }

	// RVA: 0x15C5C9C
	void .ctor(string qualifiedCppName, string declaration) { }

}

// Namespace: UnityEngine
internal sealed class UnityString 
{
	// Methods

	// RVA: 0x15C5CEC
	string Format(string fmt, object[] args) { }

}

// Namespace: UnityEngine.Bindings
internal class VisibleToOtherModulesAttribute 
{
	// Methods

	// RVA: 0x15C5D90
	void .ctor() { }

	// RVA: 0x15C5D98
	void .ctor(string[] modules) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeConditionalAttribute 
{
	// Fields
	private string <Condition>k__BackingField; // 0x10
	private bool <Enabled>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15C5DA0
	void set_Condition(string value) { }

	// RVA: 0x15C5DA8
	void set_Enabled(bool value) { }

	// RVA: 0x15C5DB0
	void .ctor(string condition) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeHeaderAttribute 
{
	// Fields
	private string <Header>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15C5DF0
	void set_Header(string value) { }

	// RVA: 0x15C5DF8
	void .ctor(string header) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeNameAttribute 
{
	// Fields
	private string <Name>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15C5F1C
	void set_Name(string value) { }

	// RVA: 0x15C5F24
	void .ctor(string name) { }

}

// Namespace: UnityEngine.Bindings
internal sealed class NativeWritableSelfAttribute 
{
	// Fields
	private bool <WritableSelf>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15C6048
	void set_WritableSelf(bool value) { }

	// RVA: 0x15C6050
	void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class NativeMethodAttribute 
{
	// Fields
	private string <Name>k__BackingField; // 0x10
	private bool <IsThreadSafe>k__BackingField; // 0x18
	private bool <IsFreeFunction>k__BackingField; // 0x19
	private bool <ThrowsException>k__BackingField; // 0x1A
	private bool <HasExplicitThis>k__BackingField; // 0x1B

	// Methods

	// RVA: 0x15C607C
	void set_Name(string value) { }

	// RVA: 0x15C6084
	void set_IsThreadSafe(bool value) { }

	// RVA: 0x15C608C
	void set_IsFreeFunction(bool value) { }

	// RVA: 0x15C6094
	void set_ThrowsException(bool value) { }

	// RVA: 0x15C609C
	void set_HasExplicitThis(bool value) { }

	// RVA: 0x15C60A4
	void .ctor() { }

	// RVA: 0x15C60AC
	void .ctor(string name) { }

	// RVA: 0x15C61D0
	void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x15C61F8
	void .ctor(string name, bool isFreeFunction, bool isThreadSafe) { }

}

// Namespace: UnityEngine.Bindings
internal enum TargetType 
{
	// Fields
	public int value__; // 0x10
	public const TargetType Function = 0;
	public const TargetType Field = 1;
}

// Namespace: UnityEngine.Bindings
internal class NativePropertyAttribute 
{
	// Fields
	private TargetType <TargetType>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x15C6230
	void set_TargetType(TargetType value) { }

	// RVA: 0x15C6238
	void .ctor() { }

	// RVA: 0x15C6240
	void .ctor(string name) { }

	// RVA: 0x15C6244
	void .ctor(string name, bool isFree, TargetType targetType) { }

	// RVA: 0x15C627C
	void .ctor(string name, bool isFree, TargetType targetType, bool isThreadSafe) { }

}

// Namespace: UnityEngine.Bindings
internal enum CodegenOptions 
{
	// Fields
	public int value__; // 0x10
	public const CodegenOptions Auto = 0;
	public const CodegenOptions Custom = 1;
	public const CodegenOptions Force = 2;
}

// Namespace: UnityEngine.Bindings
internal class NativeAsStructAttribute 
{
	// Methods

	// RVA: 0x15C62BC
	void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class NativeTypeAttribute 
{
	// Fields
	private string <Header>k__BackingField; // 0x10
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Methods

	// RVA: 0x15C62C4
	void set_Header(string value) { }

	// RVA: 0x15C62CC
	void set_IntermediateScriptingStructName(string value) { }

	// RVA: 0x15C62D4
	void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x15C62DC
	void .ctor() { }

	// RVA: 0x15C6304
	void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x15C6330
	void .ctor(string header) { }

	// RVA: 0x15C6458
	void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }

}

// Namespace: UnityEngine.Bindings
internal class NotNullAttribute 
{
	// Fields
	private string <Exception>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15C649C
	void set_Exception(string value) { }

	// RVA: 0x15C64A4
	void .ctor(string exception) { }

}

// Namespace: UnityEngine.Bindings
internal class UnmarshalledAttribute 
{
	// Methods

	// RVA: 0x15C64D8
	void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class FreeFunctionAttribute 
{
	// Methods

	// RVA: 0x15C64E0
	void .ctor() { }

	// RVA: 0x15C650C
	void .ctor(string name) { }

	// RVA: 0x15C6534
	void .ctor(string name, bool isThreadSafe) { }

}

// Namespace: UnityEngine.Bindings
internal class ThreadSafeAttribute 
{
	// Methods

	// RVA: 0x15C6564
	void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal enum StaticAccessorType 
{
	// Fields
	public int value__; // 0x10
	public const StaticAccessorType Dot = 0;
	public const StaticAccessorType Arrow = 1;
	public const StaticAccessorType DoubleColon = 2;
	public const StaticAccessorType ArrowWithDefaultReturnIfNull = 3;
}

// Namespace: UnityEngine.Bindings
internal class StaticAccessorAttribute 
{
	// Fields
	private string <Name>k__BackingField; // 0x10
	private StaticAccessorType <Type>k__BackingField; // 0x18

	// Methods

	// RVA: 0x15C6590
	void set_Name(string value) { }

	// RVA: 0x15C6598
	void set_Type(StaticAccessorType value) { }

	// RVA: 0x15C65A0
	void .ctor(string name) { }

	// RVA: 0x15C65D4
	void .ctor(string name, StaticAccessorType type) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeThrowsAttribute 
{
	// Fields
	private bool <ThrowsException>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15C661C
	void set_ThrowsException(bool value) { }

	// RVA: 0x15C6624
	void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class IgnoreAttribute 
{
	// Fields
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15C6650
	void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x15C6658
	void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class PreventReadOnlyInstanceModificationAttribute 
{
	// Methods

	// RVA: 0x15C6660
	void .ctor() { }

}

// Namespace: UnityEngine.Scripting
internal class UsedByNativeCodeAttribute 
{
	// Methods

	// RVA: 0x15C6668
	void .ctor() { }

}

// Namespace: UnityEngine.Scripting
internal class RequiredByNativeCodeAttribute 
{
	// Fields
	private string <Name>k__BackingField; // 0x10
	private bool <Optional>k__BackingField; // 0x18
	private bool <GenerateProxy>k__BackingField; // 0x19

	// Methods

	// RVA: 0x15C6670
	void .ctor() { }

	// RVA: 0x15C6678
	void .ctor(string name) { }

	// RVA: 0x15C66AC
	void set_Name(string value) { }

	// RVA: 0x15C66B4
	void set_Optional(bool value) { }

	// RVA: 0x15C66BC
	void set_GenerateProxy(bool value) { }

}


