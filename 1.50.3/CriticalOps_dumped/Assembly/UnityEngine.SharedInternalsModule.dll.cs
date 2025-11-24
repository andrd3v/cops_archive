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

	// RVA: 0x16DCF74
	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

// Namespace: UnityEngine
internal class ThreadAndSerializationSafeAttribute
{
	// Methods

	// RVA: 0x16DCFC4
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class WritableAttribute
{
	// Methods

	// RVA: 0x16DCFCC
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class UnityEngineModuleAssembly
{
	// Methods

	// RVA: 0x16DCFD4
	public void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NativeClassAttribute
{
	// Fields
	private string <QualifiedNativeName>k__BackingField; // 0x10
	private string <Declaration>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16DCFDC
	private void set_QualifiedNativeName(string value) { }

	// RVA: 0x16DCFE4
	private void set_Declaration(string value) { }

	// RVA: 0x16DCFEC
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x16DD074
	public void .ctor(string qualifiedCppName, string declaration) { }

}

// Namespace: UnityEngine
internal sealed class UnityString
{
	// Methods

	// RVA: 0x16DD0C4
	public static string Format(string fmt, object[] args) { }

}

// Namespace: UnityEngine.Bindings
internal class VisibleToOtherModulesAttribute
{
	// Methods

	// RVA: 0x16DD168
	public void .ctor() { }

	// RVA: 0x16DD170
	public void .ctor(string[] modules) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeConditionalAttribute
{
	// Fields
	private string <Condition>k__BackingField; // 0x10
	private bool <Enabled>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16DD178
	public void set_Condition(string value) { }

	// RVA: 0x16DD180
	public void set_Enabled(bool value) { }

	// RVA: 0x16DD188
	public void .ctor(string condition) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeHeaderAttribute
{
	// Fields
	private string <Header>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16DD1C8
	public void set_Header(string value) { }

	// RVA: 0x16DD1D0
	public void .ctor(string header) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeNameAttribute
{
	// Fields
	private string <Name>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16DD2F4
	public void set_Name(string value) { }

	// RVA: 0x16DD2FC
	public void .ctor(string name) { }

}

// Namespace: UnityEngine.Bindings
internal sealed class NativeWritableSelfAttribute
{
	// Fields
	private bool <WritableSelf>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16DD420
	public void set_WritableSelf(bool value) { }

	// RVA: 0x16DD428
	public void .ctor() { }

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

	// RVA: 0x16DD454
	public void set_Name(string value) { }

	// RVA: 0x16DD45C
	public void set_IsThreadSafe(bool value) { }

	// RVA: 0x16DD464
	public void set_IsFreeFunction(bool value) { }

	// RVA: 0x16DD46C
	public void set_ThrowsException(bool value) { }

	// RVA: 0x16DD474
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x16DD47C
	public void .ctor() { }

	// RVA: 0x16DD484
	public void .ctor(string name) { }

	// RVA: 0x16DD5A8
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x16DD5D0
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

	// RVA: 0x16DD608
	public void set_TargetType(TargetType value) { }

	// RVA: 0x16DD610
	public void .ctor() { }

	// RVA: 0x16DD618
	public void .ctor(string name) { }

	// RVA: 0x16DD61C
	public void .ctor(string name, bool isFree, TargetType targetType) { }

	// RVA: 0x16DD654
	public void .ctor(string name, bool isFree, TargetType targetType, bool isThreadSafe) { }

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

	// RVA: 0x16DD694
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

	// RVA: 0x16DD69C
	public void set_Header(string value) { }

	// RVA: 0x16DD6A4
	public void set_IntermediateScriptingStructName(string value) { }

	// RVA: 0x16DD6AC
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x16DD6B4
	public void .ctor() { }

	// RVA: 0x16DD6DC
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x16DD708
	public void .ctor(string header) { }

	// RVA: 0x16DD830
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }

}

// Namespace: UnityEngine.Bindings
internal class NotNullAttribute
{
	// Fields
	private string <Exception>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16DD874
	public void set_Exception(string value) { }

	// RVA: 0x16DD87C
	public void .ctor(string exception) { }

}

// Namespace: UnityEngine.Bindings
internal class UnmarshalledAttribute
{
	// Methods

	// RVA: 0x16DD8B0
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class FreeFunctionAttribute
{
	// Methods

	// RVA: 0x16DD8B8
	public void .ctor() { }

	// RVA: 0x16DD8E4
	public void .ctor(string name) { }

	// RVA: 0x16DD90C
	public void .ctor(string name, bool isThreadSafe) { }

}

// Namespace: UnityEngine.Bindings
internal class ThreadSafeAttribute
{
	// Methods

	// RVA: 0x16DD93C
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

	// RVA: 0x16DD968
	public void set_Name(string value) { }

	// RVA: 0x16DD970
	public void set_Type(StaticAccessorType value) { }

	// RVA: 0x16DD978
	internal void .ctor(string name) { }

	// RVA: 0x16DD9AC
	public void .ctor(string name, StaticAccessorType type) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeThrowsAttribute
{
	// Fields
	private bool <ThrowsException>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16DD9F4
	public void set_ThrowsException(bool value) { }

	// RVA: 0x16DD9FC
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class IgnoreAttribute
{
	// Fields
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16DDA28
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x16DDA30
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class PreventReadOnlyInstanceModificationAttribute
{
	// Methods

	// RVA: 0x16DDA38
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
internal class UsedByNativeCodeAttribute
{
	// Methods

	// RVA: 0x16DDA40
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
internal class RequiredByNativeCodeAttribute
{
	// Fields
	private string <Name>k__BackingField; // 0x10
	private bool <Optional>k__BackingField; // 0x18
	private bool <GenerateProxy>k__BackingField; // 0x19

	// Methods

	// RVA: 0x16DDA48
	public void .ctor() { }

	// RVA: 0x16DDA50
	public void .ctor(string name) { }

	// RVA: 0x16DDA84
	public void set_Name(string value) { }

	// RVA: 0x16DDA8C
	public void set_Optional(bool value) { }

	// RVA: 0x16DDA94
	public void set_GenerateProxy(bool value) { }

}


