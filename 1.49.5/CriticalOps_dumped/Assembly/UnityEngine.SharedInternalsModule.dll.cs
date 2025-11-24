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

	// RVA: 0x16B9DF0
	public void .ctor(string preferredExtension, string[] otherExtensions) { }

}

// Namespace: UnityEngine
internal class ThreadAndSerializationSafeAttribute
{
	// Methods

	// RVA: 0x16B9E40
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class WritableAttribute
{
	// Methods

	// RVA: 0x16B9E48
	public void .ctor() { }

}

// Namespace: UnityEngine
internal class UnityEngineModuleAssembly
{
	// Methods

	// RVA: 0x16B9E50
	public void .ctor() { }

}

// Namespace: UnityEngine
internal sealed class NativeClassAttribute
{
	// Fields
	private string <QualifiedNativeName>k__BackingField; // 0x10
	private string <Declaration>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16B9E58
	private void set_QualifiedNativeName(string value) { }

	// RVA: 0x16B9E60
	private void set_Declaration(string value) { }

	// RVA: 0x16B9E68
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x16B9EF0
	public void .ctor(string qualifiedCppName, string declaration) { }

}

// Namespace: UnityEngine
internal sealed class UnityString
{
	// Methods

	// RVA: 0x16B9F40
	public static string Format(string fmt, object[] args) { }

}

// Namespace: UnityEngine.Bindings
internal class VisibleToOtherModulesAttribute
{
	// Methods

	// RVA: 0x16B9FE4
	public void .ctor() { }

	// RVA: 0x16B9FEC
	public void .ctor(string[] modules) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeConditionalAttribute
{
	// Fields
	private string <Condition>k__BackingField; // 0x10
	private bool <Enabled>k__BackingField; // 0x18

	// Methods

	// RVA: 0x16B9FF4
	public void set_Condition(string value) { }

	// RVA: 0x16B9FFC
	public void set_Enabled(bool value) { }

	// RVA: 0x16BA004
	public void .ctor(string condition) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeHeaderAttribute
{
	// Fields
	private string <Header>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16BA044
	public void set_Header(string value) { }

	// RVA: 0x16BA04C
	public void .ctor(string header) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeNameAttribute
{
	// Fields
	private string <Name>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16BA170
	public void set_Name(string value) { }

	// RVA: 0x16BA178
	public void .ctor(string name) { }

}

// Namespace: UnityEngine.Bindings
internal sealed class NativeWritableSelfAttribute
{
	// Fields
	private bool <WritableSelf>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16BA29C
	public void set_WritableSelf(bool value) { }

	// RVA: 0x16BA2A4
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

	// RVA: 0x16BA2D0
	public void set_Name(string value) { }

	// RVA: 0x16BA2D8
	public void set_IsThreadSafe(bool value) { }

	// RVA: 0x16BA2E0
	public void set_IsFreeFunction(bool value) { }

	// RVA: 0x16BA2E8
	public void set_ThrowsException(bool value) { }

	// RVA: 0x16BA2F0
	public void set_HasExplicitThis(bool value) { }

	// RVA: 0x16BA2F8
	public void .ctor() { }

	// RVA: 0x16BA300
	public void .ctor(string name) { }

	// RVA: 0x16BA424
	public void .ctor(string name, bool isFreeFunction) { }

	// RVA: 0x16BA44C
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

	// RVA: 0x16BA484
	public void set_TargetType(TargetType value) { }

	// RVA: 0x16BA48C
	public void .ctor() { }

	// RVA: 0x16BA494
	public void .ctor(string name) { }

	// RVA: 0x16BA498
	public void .ctor(string name, bool isFree, TargetType targetType) { }

	// RVA: 0x16BA4D0
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

	// RVA: 0x16BA510
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

	// RVA: 0x16BA518
	public void set_Header(string value) { }

	// RVA: 0x16BA520
	public void set_IntermediateScriptingStructName(string value) { }

	// RVA: 0x16BA528
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x16BA530
	public void .ctor() { }

	// RVA: 0x16BA558
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x16BA584
	public void .ctor(string header) { }

	// RVA: 0x16BA6AC
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }

}

// Namespace: UnityEngine.Bindings
internal class NotNullAttribute
{
	// Fields
	private string <Exception>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16BA6F0
	public void set_Exception(string value) { }

	// RVA: 0x16BA6F8
	public void .ctor(string exception) { }

}

// Namespace: UnityEngine.Bindings
internal class UnmarshalledAttribute
{
	// Methods

	// RVA: 0x16BA72C
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class FreeFunctionAttribute
{
	// Methods

	// RVA: 0x16BA734
	public void .ctor() { }

	// RVA: 0x16BA760
	public void .ctor(string name) { }

	// RVA: 0x16BA788
	public void .ctor(string name, bool isThreadSafe) { }

}

// Namespace: UnityEngine.Bindings
internal class ThreadSafeAttribute
{
	// Methods

	// RVA: 0x16BA7B8
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

	// RVA: 0x16BA7E4
	public void set_Name(string value) { }

	// RVA: 0x16BA7EC
	public void set_Type(StaticAccessorType value) { }

	// RVA: 0x16BA7F4
	internal void .ctor(string name) { }

	// RVA: 0x16BA828
	public void .ctor(string name, StaticAccessorType type) { }

}

// Namespace: UnityEngine.Bindings
internal class NativeThrowsAttribute
{
	// Fields
	private bool <ThrowsException>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16BA870
	public void set_ThrowsException(bool value) { }

	// RVA: 0x16BA878
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class IgnoreAttribute
{
	// Fields
	private bool <DoesNotContributeToSize>k__BackingField; // 0x10

	// Methods

	// RVA: 0x16BA8A4
	public void set_DoesNotContributeToSize(bool value) { }

	// RVA: 0x16BA8AC
	public void .ctor() { }

}

// Namespace: UnityEngine.Bindings
internal class PreventReadOnlyInstanceModificationAttribute
{
	// Methods

	// RVA: 0x16BA8B4
	public void .ctor() { }

}

// Namespace: UnityEngine.Scripting
internal class UsedByNativeCodeAttribute
{
	// Methods

	// RVA: 0x16BA8BC
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

	// RVA: 0x16BA8C4
	public void .ctor() { }

	// RVA: 0x16BA8CC
	public void .ctor(string name) { }

	// RVA: 0x16BA900
	public void set_Name(string value) { }

	// RVA: 0x16BA908
	public void set_Optional(bool value) { }

	// RVA: 0x16BA910
	public void set_GenerateProxy(bool value) { }

}


