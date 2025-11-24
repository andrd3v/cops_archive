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

	// RVA: 0x178F748
	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

// Namespace: UnityEngine
internal class ThreadAndSerializationSafeAttribute
{
	// Methods

	// RVA: 0x178F798
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class WritableAttribute
{
	// Methods

	// RVA: 0x178F7A0
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class UnityEngineModuleAssembly
{
	// Methods

	// RVA: 0x178F7A8
	public void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NativeClassAttribute
{
	// Fields
	private string <QualifiedNativeName>k__BackingField; // 0x10
	private string <Declaration>k__BackingField; // 0x18

	// Methods

	// RVA: 0x178F7B0
	private void set_QualifiedNativeName(string value) { }

	// RVA: 0x178F7B8
	private void set_Declaration(string value) { }

	// RVA: 0x178F7C0
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x178F848
	public void .ctor(string qualifiedCppName, string declaration) { }

}

// Namespace: UnityEngine
internal sealed class UnityString
{
	// Methods

	// RVA: 0x178F898
	public static string Format(string fmt, object[] args) { }

}

// Namespace: UnityEngine.Bindings
internal class VisibleToOtherModulesAttribute
{
	// Methods

	// RVA: 0x178F93C
	public void .ctor() { }

	// RVA: 0x178F944
	public void .ctor(string[] modules) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeConditionalAttribute
{
	// Fields
	private string <Condition>k__BackingField; // 0x10
	private bool <Enabled>k__BackingField; // 0x18

	// Methods

	// RVA: 0x178F94C
	public void set_Condition(string value) { }

	// RVA: 0x178F954
	public void set_Enabled(bool value) { }

	// RVA: 0x178F95C
	public void .ctor(string condition) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeHeaderAttribute
{
	// Fields
	private string <Header>k__BackingField; // 0x10

	// Methods

	// RVA: 0x178F99C
	public void set_Header(string value) { }

	// RVA: 0x178F9A4
	public void .ctor(string header) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeNameAttribute
{
	// Fields
	private string <Name>k__BackingField; // 0x10

	// Methods

	// RVA: 0x178FAC8
	public void set_Name(string value) { }

	// RVA: 0x178FAD0
	public void .ctor(string name) { }

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

	// RVA: 0x178FBF4
	public void set_Name(string value) { }

	// RVA: 0x178FBFC
	public void set_IsThreadSafe(bool value) { }

	// RVA: 0x178FC04
	public void set_IsFreeFunction(bool value) { }

	// RVA: 0x178FC0C
	public void set_ThrowsException(bool value) { }

	// RVA: 0x178FC14
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x178FC1C
	public void .ctor() { }

	// RVA: 0x178FC24
	public void .ctor(string name) { }

	// RVA: 0x178FD48
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x178FD70
	public void .ctor(string name, bool isFreeFunction, bool isThreadSafe) { }

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

	// RVA: 0x178FDA8
	public void set_TargetType(TargetType value) { }

	// RVA: 0x178FDB0
	public void .ctor() { }

	// RVA: 0x178FDB8
	public void .ctor(string name) { }

	// RVA: 0x178FDBC
	public void .ctor(string name, bool isFree, TargetType targetType) { }

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

	// RVA: 0x178FDF4
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class NativeTypeAttribute
{
	// Fields
	private string <Header>k__BackingField; // 0x10
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Methods

	// RVA: 0x178FDFC
	public void set_Header(string value) { }

	// RVA: 0x178FE04
	public void set_IntermediateScriptingStructName(string value) { }

	// RVA: 0x178FE0C
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x178FE14
	public void .ctor() { }

	// RVA: 0x178FE3C
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x178FE68
	public void .ctor(string header) { }

	// RVA: 0x178FF90
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }

}

// Namespace: UnityEngine.Bindings
internal class NotNullAttribute
{
	// Methods

	// RVA: 0x178FFD4
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class UnmarshalledAttribute
{
	// Methods

	// RVA: 0x178FFDC
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class FreeFunctionAttribute
{
	// Methods

	// RVA: 0x178FFE4
	public void .ctor() { }

	// RVA: 0x1790010
	public void .ctor(string name) { }

	// RVA: 0x1790038
	public void .ctor(string name, bool isThreadSafe) { }

}

// Namespace: UnityEngine.Bindings
internal class ThreadSafeAttribute
{
	// Methods

	// RVA: 0x1790068
	public void .ctor() { }

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

	// RVA: 0x1790094
	public void set_Name(string value) { }

	// RVA: 0x179009C
	public void set_Type(StaticAccessorType value) { }

	// RVA: 0x17900A4
	internal void .ctor(string name) { }

	// RVA: 0x17900D8
	public void .ctor(string name, StaticAccessorType type) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeThrowsAttribute
{
	// Fields
	private bool <ThrowsException>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1790120
	public void set_ThrowsException(bool value) { }

	// RVA: 0x1790128
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class IgnoreAttribute
{
	// Fields
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1790154
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x179015C
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class PreventReadOnlyInstanceModificationAttribute
{
	// Methods

	// RVA: 0x1790164
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
internal class UsedByNativeCodeAttribute
{
	// Fields
	private string <Name>k__BackingField; // 0x10

	// Methods

	// RVA: 0x179016C
	public void .ctor() { }

	// RVA: 0x1790174
	public void .ctor(string name) { }

	// RVA: 0x17901A8
	public void set_Name(string value) { }

}

// Namespace: UnityEngine.Scripting
internal class RequiredByNativeCodeAttribute
{
	// Fields
	private string <Name>k__BackingField; // 0x10
	private bool <Optional>k__BackingField; // 0x18
	private bool <GenerateProxy>k__BackingField; // 0x19

	// Methods

	// RVA: 0x17901B0
	public void .ctor() { }

	// RVA: 0x17901B8
	public void .ctor(string name) { }

	// RVA: 0x17901EC
	public void .ctor(bool optional) { }

	// RVA: 0x1790218
	public void set_Name(string value) { }

	// RVA: 0x1790220
	public void set_Optional(bool value) { }

	// RVA: 0x1790228
	public void set_GenerateProxy(bool value) { }

}


